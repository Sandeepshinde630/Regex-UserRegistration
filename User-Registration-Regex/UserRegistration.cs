using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace User_Registration_Regex
{
    class UserRegistration
    {
        string FirstName = "^[A-Z][a-z]{2,}$";
        string LastName = "^[A-Z][a-z]{2,}$";

        public bool validateUserInfo(string input)
        {
            return Regex.IsMatch(input, FirstName);
        }
        public bool validateLastName(string input)
        {
            return Regex.IsMatch(input, LastName);
        }
    }
}
