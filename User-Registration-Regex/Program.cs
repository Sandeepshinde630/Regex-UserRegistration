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
            bool result3 = userRegistration.validateMobileNumber("91 7757343443");
            Console.WriteLine(result3);
            bool result4 = userRegistration.validatePasswordRule1("Sandeep123");
            Console.WriteLine(result4);
            bool result5 = userRegistration.validatePasswordRule2("Sandeepshinde");
            Console.WriteLine(result5);
            bool result6 = userRegistration.validatePasswordRule3("Sandeep@shinde1");
            Console.WriteLine(result6);
        }
    }
}
