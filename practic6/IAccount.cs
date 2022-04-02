using System;
using System.Collections.Generic;
using System.Text;

namespace practic6
{
    internal interface IAccount
    {
        bool PasswordChacker(string password);
        string Showinfo(string email, string fullname);


    }
}
