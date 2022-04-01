using PraktikaTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PraktikaTask.Models
{
    class User: IAccount
    {
        private static int _id;
        private string _password;
        public int Id { get; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password 
        {
            get
            {
                return _password;
            }
            set
            {
                if (PasswordChecker(value))
                {
                    _password = value;
                }
                throw new Exception("nagarsan qadanalim");
            }
        
        }


        private User()
        {
            _id++;
            Id = _id;
        }
        public User(string email, string password):this()
        {
            Email = email; Password = password;
        }
        
        
        public bool PasswordChecker(string password)
        {
            if (password.Length >= 8 && !string.IsNullOrEmpty(password) && !string.IsNullOrWhiteSpace(password))
            {
                bool hasUpper = false;
                bool hasLower = false;
                bool hasDigit = false;
                for (int i = 0; i < password.Length; i++)
                {
                    if (char.IsUpper(password[i])) hasUpper = true;
                    else if (char.IsLower(password[i])) hasLower = true;
                    else if (char.IsDigit(password[i])) hasDigit = true;
                    if (hasDigit && hasLower && hasUpper)
                    {
                        return true;
                    }
                }

            }
            return false;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Id : {Id}  , Full Name : {Fullname}  , Email : {Email}");
        }
    }
}
