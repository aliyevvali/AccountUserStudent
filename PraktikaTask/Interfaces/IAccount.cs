using System;
using System.Collections.Generic;
using System.Text;

namespace PraktikaTask.Interfaces
{
    interface IAccount
    {
        bool PasswordChecker(string password);
        void ShowInfo();
    }
}
