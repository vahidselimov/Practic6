using System;
using System.Collections.Generic;
using System.Text;

namespace practic6
{
    internal class User : IAccount
    {
        public string Fullname;
        public string Email;
        public string Password;
        public User(string fullname, string email, string password)
        {
            Fullname = fullname;
            Email = email;
            Password = password;

        }
        bool check = false;
        bool PasswordChacker(string password)
        {

          
            bool isDigit = false;
            bool isUpper = false;
            bool isLower = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (password.Length >4)
                {
                    if (char.IsLower(password[i]))
                    {
                        isLower = true;


                    }
                    if (char.IsLower(password[i]))
                    {
                        isLower = true;


                    }
                    if (char.IsDigit(password[i]))
                    {
                        isDigit = true;


                    }
                    if (char.IsUpper(password[i]))
                    {
                        isUpper = true;


                    }
                    bool Check1 = isUpper && isLower && isDigit==true;
                    return Check1;
                }
                
                  
            }

       
        }
        



        public string Showinfo(string email, string fullname)
        {
            return $"Email-duzgundur FUllname-duzgundur";
        }

    }
}
