using System;
using System.Collections.Generic;
using System.Text;

namespace practice.Exceptions
{
    class NullReferanceException:Exception
    {
        public NullReferanceException(string message) : base(message)
        {

        }
    }
}
