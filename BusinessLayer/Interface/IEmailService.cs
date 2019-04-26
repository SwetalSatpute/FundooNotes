using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interface
{
    interface IEmailService
    {
        Task<object> ForgetPassword(ForgotModel model);
    }

    public class ForgotModel
    {
        private string email;

        public string Email { get => email; set => email = value; }
    }
}
