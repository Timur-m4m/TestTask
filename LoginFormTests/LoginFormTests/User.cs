﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginFormTests
{
    public class User
    {
        public string Login;
        public string Password;

        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}
