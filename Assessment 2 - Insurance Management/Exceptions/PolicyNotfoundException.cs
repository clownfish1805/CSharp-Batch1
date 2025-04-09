using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Exceptions
{
    class PolicyNotfoundException : Exception
    {
        public PolicyNotfoundException(string message) : base(message)
        {
        }

    }

}
