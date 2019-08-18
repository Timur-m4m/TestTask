using OpenQA.Selenium.Chrome;

namespace LoginFormTests
{
    public static class CommonOperations
    {
        /// <summary>
        /// Common login method
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="user"></param>
        public static void Login(ChromeDriver driver, User user)
        {
            var url = TestData.loginFormUrl;
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            driver.FindElementByXPath("//input[@id='username']").SendKeys(user.Login);
            driver.FindElementByXPath("//input[@id='password']").SendKeys(user.Password);
            driver.FindElementByXPath("//button[@type='submit']").Submit();
        }
    }
}
