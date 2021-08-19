using System;

namespace User_Registration_Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User Registration Regex Demo!");
            UserRegistration userRegistration = new UserRegistration();
            bool result =userRegistration.validateUserInfo("Sandeep");
            Console.WriteLine(result);
        }
    }
}
