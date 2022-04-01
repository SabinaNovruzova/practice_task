using System;
using System.Collections.Generic;
using System.Text;

namespace practice.Models
{
    public class user : IAccount
    {
        private static int _id = 0;
        public int Id { get;}
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        

        private user()
        {
           ++_id;
            Id = _id; 
        }
        public user( string fullName,string email,string password):this()
        {
            FullName = fullName;
            Email = email;
            Password = password;         
        }
        public bool PasswordChecker(string password)
        {
            bool isupper = false;
            bool islower = false;
            bool isdigit = false;
            if (password.Length>=8)
            {
                foreach (var item in password)
                {
                    if (char.IsUpper(item)) isupper = true;
                    else if (char.IsLower(item)) islower = true;
                    else if (char.IsDigit(item)) isdigit = true;
                }
                if (isdigit && islower && isupper) return true;
            }
            return false;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"id:{Id} name:{FullName} mail:{Email}");
        }       
    }
}
