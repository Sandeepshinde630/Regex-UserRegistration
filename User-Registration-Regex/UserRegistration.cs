﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace User_Registration_Regex
{
    class UserRegistration
    {
        public static string FirstName = "^[A-Z][a-z]{2,}$";
        public static string LastName = "^[A-Z][a-z]{2,}$";
        public static string Email= "^[a-z]+([._+-]*[a-z0-9]+)*[@][a-z0-9]+[.][a-z]{2,3}(.[a-z]{2})?$";

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
    }
}
