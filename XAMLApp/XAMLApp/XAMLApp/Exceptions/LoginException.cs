using System;
using System.Collections.Generic;
using System.Text;

namespace XAMLApp.Exceptions
{
    public class LoginException : Exception
    {
        public LoginException(string message) : base(message)
        {
        }
    }
}
