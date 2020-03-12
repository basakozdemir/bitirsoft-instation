
using System;
using System.Threading.Tasks;
using instation;
using instation.Droid;
using Firebase.Auth;
using Xamarin.Forms;

[assembly: Dependency(typeof(AuthDroid))]
namespace instation.Droid
{
    public class AuthDroid : IAuth
    {
        public async Task<string> LoginWithEmailPassword(string email, string password)
        {
            try
            {
                Console.WriteLine("loginwithemailpass içindyeim");
                var user = await FirebaseAuth.Instance.SignInWithEmailAndPasswordAsync(email, password);
                var token = await user.User.GetIdTokenAsync(false);
                Console.WriteLine("Token ne: "+token);
                Console.WriteLine("return ne: " + token.Token);
                return token.Token;
            }
            catch (FirebaseAuthInvalidUserException e)
            {   
                e.PrintStackTrace();
                Console.WriteLine("catche mi düştüm");
                return "";
            }
        }

        public bool SignUpWithEmailPassword(string email, string password)
        {
            
        
            try
            {
                
                FirebaseAuth.Instance.CreateUserWithEmailAndPassword(email, password);
                //var signUpTask = await FirebaseAuth.Instance.CreateUserWithEmailAndPasswordAsync();
               
                Task.Delay(5000);
                var user = FirebaseAuth.Instance.CurrentUser;
            
                return user != null;
            }
            catch (Exception e)
            {
         
                return false;
            }
        }

        
    }
}