using System;
using System.Threading.Tasks;

namespace instation
{
    public interface IAuth
    {
        Task<string> LoginWithEmailPassword(string email, string password);
        bool SignUpWithEmailPassword(string email, string password);
    }
}