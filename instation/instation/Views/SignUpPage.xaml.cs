using System;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace instation.Views
{
    
    /// <summary>
    /// Page to sign in with user details.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignUpPage" /> class.
        /// </summary>
        IAuth auth;
      
        public SignUpPage()
        {

            InitializeComponent();            
            auth = DependencyService.Get<IAuth>();

        }
        public IAuth getAuth()
        {
            return this.auth;
        }
        

    }
}