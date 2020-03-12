using System;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace instation.Views
{
    /// <summary>
    /// Page to login with user name and password
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginPage" /> class.
        /// </summary>
        IAuth auth;
        public LoginPage()
        {
            InitializeComponent();
            auth = DependencyService.Get<IAuth>();
        }
        public IAuth GetAuth()
        {
            return this.auth;
        }
    }

}