using System;
using System.Threading.Tasks;
using instation.Views;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using System.ComponentModel;


namespace instation.ViewModels
{
    /// <summary>
    /// ViewModel for login page.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class LoginPageViewModel : LoginViewModel
    {
        #region Fields

        private string password;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance for the <see cref="LoginPageViewModel" /> class.
        /// </summary>
        public LoginPageViewModel()
        {
            this.LoginCommand = new Command(this.LoginClicked);
            this.SignUpCommand = new Command(this.SignUpClicked);
            this.ForgotPasswordCommand = new Command(this.ForgotPasswordClicked);
            this.SocialMediaLoginCommand = new Command(this.SocialLoggedIn);
        }

        #endregion

        #region property

        /// <summary>
        /// Gets or sets the property that is bound with an entry that gets the password from user in the login page.
        /// </summary>
        public string Password
        {
            get
            {
                return this.password;
            }

            set
            {
                if (this.password == value)
                {
                    return;
                }

                this.password = value;
                this.NotifyPropertyChanged();
            }
        }

        #endregion

        #region Command

        /// <summary>
        /// Gets or sets the command that is executed when the Log In button is clicked.
        /// </summary>
        public Command LoginCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the Sign Up button is clicked.
        /// </summary>
        public Command SignUpCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the Forgot Password button is clicked.
        /// </summary>
        public Command ForgotPasswordCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the social media login button is clicked.
        /// </summary>
        public Command SocialMediaLoginCommand { get; set; }

        #endregion

        #region methods

        /// <summary>
        /// Invoked when the Log In button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
        async void LoginClicked(object obj)
        {
            LoginPage s = new LoginPage();
            IAuth auth = s.GetAuth();

            MainPage main = new MainPage();

            Console.WriteLine("loginclickeddeyim loginpageviewmodel xdxdxd");
            Console.WriteLine("email: " + Email);
            Console.WriteLine("pass: " + Password);
            string Token = await auth.LoginWithEmailPassword(Email, Password);
            Console.WriteLine("token: " + Token);
            if (Token != "")
            {
                await Application.Current.MainPage.Navigation.PushAsync(new LoginPage());
                await Application.Current.MainPage.DisplayAlert("Authentication Successed", "Welcome", "OK");
            }
            else
            {

               Console.WriteLine("elseteyim kkkkkk");
                await Application.Current.MainPage.DisplayAlert("Authentication Failed", "E-mail or password are incorrect. Try again!", "OK");

            }
        }

       



        /// <summary>
        /// Invoked when the Sign Up button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
        private async void SignUpClicked(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SignUpPage());
        }

        /// <summary>
        /// Invoked when the Forgot Password button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
        private async void ForgotPasswordClicked(object obj)
        {
            var label = obj as Label;
            label.BackgroundColor = Color.FromHex("#70FFFFFF");
            await Task.Delay(100);
            label.BackgroundColor = Color.Transparent;

            await Application.Current.MainPage.Navigation.PushAsync(new ForgotPasswordPage());
        }

        /// <summary>
        /// Invoked when social media login button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
        private async void SocialLoggedIn(object obj)
        {
            await Application.Current.MainPage.DisplayAlert("Alert", "╭∩╮（︶︿︶） social login ╭∩╮", "OK");

        }

        #endregion
    }
}