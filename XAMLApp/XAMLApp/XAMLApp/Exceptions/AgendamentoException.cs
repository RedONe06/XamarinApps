using System;
using System.Collections.Generic;
using System.Text;

namespace XAMLApp.Exceptions
{
    public class AgendamentoException : Exception
    {
        public AgendamentoException(string message) : base(message)
        {
        }
    }
}
