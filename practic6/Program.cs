using System;

namespace practic6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zehmet olamasa email daxil edin");
            string Email = Console.ReadLine();
            Console.WriteLine("Zehmet olamasa password daxil edin");
            string Password = Console.ReadLine();
            Console.WriteLine("Zehmet olamasa fullname daxil edin");
            string Fullname = Console.ReadLine();
            User user = new User(Email, Fullname,Password);
            Console.WriteLine(((IAccount)user).PasswordChacker(Password));
            if (((IAccount)user).PasswordChacker(Password)==true)
            {
                Console.WriteLine(user.Showinfo(Email, Fullname));

            }
            else
            {
                Console.WriteLine("Password duzgun deyil");


            }



        }
    }
}
