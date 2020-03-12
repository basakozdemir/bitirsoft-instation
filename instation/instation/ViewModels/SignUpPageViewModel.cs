﻿using System;
using System.Threading.Tasks;
using instation.Views;
using Xamarin.Forms;
using Xamarin.Forms.Internals;


namespace instation.ViewModels
{
    /// <summary>
    /// ViewModel for sign-up page.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class SignUpPageViewModel : LoginViewModel
    {
      
        #region Fields

        private string name;

        private string password;

        private string confirmPassword;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance for the <see cref="SignUpPageViewModel" /> class.
        /// </summary>
        
        public SignUpPageViewModel()
        {
            
            this.LoginCommand = new Command(this.LoginClicked);
            this.SignUpCommand = new Command(this.SignUpClicked);
            
        }

        #endregion

        #region Property

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the name from user in the Sign Up page.
        /// </summary>
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (this.name == value)
                {
                    return;
                }

                this.name = value;
                this.NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the password from users in the Sign Up page.
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

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the password confirmation from users in the Sign Up page.
        /// </summary>
        public string ConfirmPassword
        {
            get
            {
                return this.confirmPassword;
            }

            set
            {
                if (this.confirmPassword == value)
                {
                    return;
                }

                this.confirmPassword = value;
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

        #endregion

        #region Methods

        /// <summary>
        /// Invoked when the Log in button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
        private async void LoginClicked()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new LoginPage());

        }

        /// <summary>
        /// Invoked when the Sign Up button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
       

        private async void SignUpClicked(object obj)
        {
            SignUpPage s = new SignUpPage();
            IAuth auth = s.getAuth();
         
            bool created = auth.SignUpWithEmailPassword(Email, Password);

            if (created)
            {
                await Application.Current.MainPage.DisplayAlert("Success", "Welcome to our system. Log in to have full access", "OK");
                await Application.Current.MainPage.Navigation.PopAsync();
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Sign Up Failed", "Something went wrong. Try again!", "OK");
            }
        }

        

        #endregion
    }
}