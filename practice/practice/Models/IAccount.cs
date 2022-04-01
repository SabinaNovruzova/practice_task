using System;
using System.Collections.Generic;
using System.Text;

namespace practice.Models
{
   interface IAccount
    {
        public bool PasswordChecker(string password);
        public void ShowInfo();
    }
}
