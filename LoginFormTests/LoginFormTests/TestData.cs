using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace LoginFormTests
{
    public static class TestData
    {
        // Login form URL
        public static string loginFormUrl = "https://the-internet.herokuapp.com/login";

        // Test users
        public static User userCorrectData = new User("tomsmith", "SuperSecretPassword!");
        public static User userWrongLogin = new User("WrongLogin", "SuperSecretPassword!");
        public static User userWrongPassword = new User("tomsmith", "WrongPassword");
        public static User userEmptyLogin = new User("", "SuperSecretPassword!");
        public static User userEmptyPassword = new User("tomsmith", "");

        // Return messages
        public static string successLoginMsg = "You logged into a secure area!\r\n×";
        public static string invalidUsernameMsg = "Your username is invalid!\r\n×";
        public static string invalidPasswordMsg = "Your password is invalid!\r\n×";
        public static string successLogoutMsg = "You logged out of the secure area!\r\n×";

        // Message colors
        public static string successTextColor = "rgba(255, 255, 255, 1)";
        public static string successBackgroundColor = "rgba(93, 164, 35, 1)";
        public static string successBorderColor = "rgb(69, 122, 26)";
        public static string errorTextColor = "rgba(255, 255, 255, 1)";
        public static string errorBackgroundColor = "rgba(198, 15, 19, 1)";
        public static string errorBorderColor = "rgb(151, 11, 14)";

        // Button colors
        public static string loginButtonTextColor = "rgba(255, 255, 255, 1)";
        public static string loginButtonBackgroundColor = "rgba(43, 166, 203, 1)";
        public static string loginButtonBorderColor = "rgb(34, 132, 161)";
        public static string logoutButtonTextColor = "rgba(51, 51, 51, 1)";
        public static string logoutButtonBackgroundColor = "rgba(233, 233, 233, 1)";
        public static string logoutButtonBorderColor = "rgb(208, 208, 208)";
    }
}
