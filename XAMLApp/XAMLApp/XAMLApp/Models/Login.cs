using System;
using System.Collections.Generic;
using System.Text;

namespace XAMLApp.Models
{
    public class Login
    {
        public string Email { get; private set; }
        public string Password { get; private set; }

        public Login(string email, string password)
        {
            this.Email = email;
            this.Password = password;
        }
    }
}
