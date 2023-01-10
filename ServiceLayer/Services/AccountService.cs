using ServiceLayer.Exceptions;
using ServiceLayer.Helpers.Constans;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class AccountService : IAccountService
    {
        public string Register(string username, string email, string password)//Emaili eyni olan accounta yazilsin this email used;
        {
            try
            {
                var res = GetAllEmails();
                if (res.Contains(email))
                {
                    throw new RegisterExceptions(ResponseMessages.InvalidRegisterMessage);
                }
                return ResponseMessages.SuccessRegisterMessage;
            }

            catch (Exception ex)
            {

                return ex.Message;
            }
           

        }

        private List<string> GetAllEmails()
        {
            return new List<string>() { "mirze@code.edu.az", "cahandar@code.edu.az", "cavid@code.edu.az", "konul@code.edu.az" };
            
        }
    }
}
