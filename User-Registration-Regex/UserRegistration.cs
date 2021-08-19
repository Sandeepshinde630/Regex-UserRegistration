using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace User_Registration_Regex
{
    class UserRegistration
    {
        public static string FirstName = "^[A-Z][a-z]{2,}$";
        public static string LastName = "^[A-Z][a-z]{2,}$";
        public static string Email = "^[a-z]+([._+-]*[a-z0-9]+)*[@][a-z0-9]+[.][a-z]{2,3}(.[a-z]{2})?$";
        public static string MobileNo = "^[0-9]{2}[ ][1-9][0-9]{9}$";
        public static string PasswordRule1 = "^[a-z0-9A-Z]{8}";
        public static string PasswordRule2 = "[A-Z]+[a-z]{8}";


        public bool validateUserInfo(string input)
        {
            return Regex.IsMatch(input, FirstName);
        }
        public bool validateLastName(string input)
        {
            return Regex.IsMatch(input, LastName);
        }
        public bool validateEmail(string input)
        {
            return Regex.IsMatch(input, Email);
        }
        public bool validateMobileNumber(string input)
        {
            return Regex.IsMatch(input, MobileNo);
        }
        public bool validatePasswordRule1(string input)
        {
            return Regex.IsMatch(input, PasswordRule1);
        }
        public bool validatePasswordRule2(string input)
        {
            return Regex.IsMatch(input, PasswordRule2);
        }
    }
}
