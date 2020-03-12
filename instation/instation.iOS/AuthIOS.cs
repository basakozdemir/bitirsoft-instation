using System;
using System.Threading.Tasks;
using instation;
using instation.iOS;
using Xamarin.Forms;
using Firebase.Auth;

[assembly: Dependency(typeof(AuthIOS))]
namespace instation.iOS
{
    public class AuthIOS : IAuth
    {
        public async Task<string> LoginWithEmailPassword(string email, string password)
        {
            try
            {
                var user = await Auth.DefaultInstance.SignInWithPasswordAsync(email, password);
                return await user.User.GetIdTokenAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return "";
            }

        }
        public bool SignUpWithEmailPassword(string email, string password)
        {
            try
            {

                Auth.DefaultInstance.CreateUserAsync(email, password);
                //var signUpTask = await FirebaseAuth.Instance.CreateUserWithEmailAndPasswordAsync();

                Task.Delay(5000);
                var user = Auth.DefaultInstance.CurrentUser;

                return user != null;
            }
            catch (Exception e)
            {

                return false;
            }
        }

        }
}
