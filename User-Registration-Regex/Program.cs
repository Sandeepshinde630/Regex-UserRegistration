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
            bool result1 = userRegistration.validateLastName("Shinde");
            Console.WriteLine(result1);
            bool result2 = userRegistration.validateEmail("sandeepshinde630@gmail.com");
            Console.WriteLine(result2);
        }
    }
}
