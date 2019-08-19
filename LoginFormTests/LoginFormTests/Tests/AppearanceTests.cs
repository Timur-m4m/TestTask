using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace LoginFormTests
{
    [TestFixture]
    public class AppearanceTests
    {
        ChromeDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }


        [Test, Description("Check success login message color is green")]
        public void CheckSuccessLoginMsgColor()
        {
            var user = TestData.userCorrectData;
            var successLoginMsgTextColor = TestData.successTextColor;
            var successLoginMsgBackgroundColor = TestData.successBackgroundColor;
            var successLoginMsgBorderColor = TestData.successBorderColor;
            CommonOperations.Login(driver, user);
            var textColor = driver.FindElementByXPath("//div[@class='flash success']").GetCssValue("color");
            var backgroundColor = driver.FindElementByXPath("//div[@class='flash success']")
                .GetCssValue("background-color");
            var borderColor = driver.FindElementByXPath("//div[@class='flash success']").GetCssValue("border-color");

            try
            {
                Assert.AreEqual(successLoginMsgTextColor, textColor);
                Assert.AreEqual(successLoginMsgBackgroundColor, backgroundColor);
                Assert.AreEqual(successLoginMsgBorderColor, borderColor);
            }
            catch (Exception e)
            {
                Log.WriteLog(e.Message);
                Log.WriteLog(e.StackTrace);
            }
        }

        [Test, Description("Check success logout message color is green")]
        public void CheckSuccessLogoutMsgColor()
        {
            var user = TestData.userCorrectData;
            var successLogoutMsgTextColor = TestData.successTextColor;
            var successLogoutMsgBackgroundColor = TestData.successBackgroundColor;
            var successLogoutMsgBorderColor = TestData.successBorderColor;
            CommonOperations.Login(driver, user);
            driver.FindElementByXPath("//a[@href='/logout']").Click();
            var textColor = driver.FindElementByXPath("//div[@class='flash success']").GetCssValue("color");
            var backgroundColor = driver.FindElementByXPath("//div[@class='flash success']")
                .GetCssValue("background-color");
            var borderColor = driver.FindElementByXPath("//div[@class='flash success']").GetCssValue("border-color");

            try
            {
                Assert.AreEqual(successLogoutMsgTextColor, textColor);
                Assert.AreEqual(successLogoutMsgBackgroundColor, backgroundColor);
                Assert.AreEqual(successLogoutMsgBorderColor, borderColor);
            }
            catch (Exception e)
            {
                Log.WriteLog(e.Message);
                Log.WriteLog(e.StackTrace);
            }
        }

        [Test, Description("Check invalid login message color is red ")]
        public void CheckInvalidLoginMsgColor()
        {
            var user = TestData.userWrongLogin;
            var invalidLoginMsgTextColor = TestData.errorTextColor;
            var invalidLoginMsgBackgroundColor = TestData.errorBackgroundColor;
            var invalidLoginMsgBorderColor = TestData.errorBorderColor;
            CommonOperations.Login(driver, user);
            var textColor = driver.FindElementByXPath("//div[@class='flash error']").GetCssValue("color");
            var backgroundColor =
                driver.FindElementByXPath("//div[@class='flash error']").GetCssValue("background-color");
            var borderColor = driver.FindElementByXPath("//div[@class='flash error']").GetCssValue("border-color");

            try
            {
                Assert.AreEqual(invalidLoginMsgTextColor, textColor);
                Assert.AreEqual(invalidLoginMsgBackgroundColor, backgroundColor);
                Assert.AreEqual(invalidLoginMsgBorderColor, borderColor);
            }
            catch (Exception e)
            {
                Log.WriteLog(e.Message);
                Log.WriteLog(e.StackTrace);
            }
        }

        [Test, Description("Check invalid password message color is red")]
        public void CheckInvalidPasswordMsgColor()
        {
            var user = TestData.userWrongPassword;
            var invalidPasswordMsgTextColor = TestData.errorTextColor;
            var invalidPasswordMsgBackgroundColor = TestData.errorBackgroundColor;
            var invalidPasswordMsgBorderColor = TestData.errorBorderColor;
            CommonOperations.Login(driver, user);
            var textColor = driver.FindElementByXPath("//div[@class='flash error']").GetCssValue("color");
            var backgroundColor =
                driver.FindElementByXPath("//div[@class='flash error']").GetCssValue("background-color");
            var borderColor = driver.FindElementByXPath("//div[@class='flash error']").GetCssValue("border-color");

            try
            {
                Assert.AreEqual(invalidPasswordMsgTextColor, textColor);
                Assert.AreEqual(invalidPasswordMsgBackgroundColor, backgroundColor);
                Assert.AreEqual(invalidPasswordMsgBorderColor, borderColor);
            }
            catch (Exception e)
            {
                Log.WriteLog(e.Message);
                Log.WriteLog(e.StackTrace);
            }
        }

        [Test, Description("Check login button color is blue")]
        public void CheckLoginButtonColor()
        {
            var url = TestData.loginFormUrl;
            driver.Navigate().GoToUrl(url);
            var loginButtonTextColor = TestData.loginButtonTextColor;
            var loginButtonBackgroundColor = TestData.loginButtonBackgroundColor;
            var loginButtonBorderColor = TestData.loginButtonBorderColor;
            var textColor = driver.FindElementByXPath("//button[@type='submit']").GetCssValue("color");
            var backgroundColor = driver.FindElementByXPath("//button[@type='submit']").GetCssValue("background-color");
            var borderColor = driver.FindElementByXPath("//button[@type='submit']").GetCssValue("border-color");

            try
            {
                Assert.AreEqual(loginButtonTextColor, textColor);
                Assert.AreEqual(loginButtonBackgroundColor, backgroundColor);
                Assert.AreEqual(loginButtonBorderColor, borderColor);
            }
            catch (Exception e)
            {
                Log.WriteLog(e.Message);
                Log.WriteLog(e.StackTrace);
            }
        }

        [Test, Description("Check logout button color is gray")]
        public void CheckLogoutButtonColor()
        {
            var user = TestData.userCorrectData;
            var logoutButtonTextColor = TestData.logoutButtonTextColor;
            var logoutButtonBackgroundColor = TestData.logoutButtonBackgroundColor;
            var logoutButtonBorderColor = TestData.logoutButtonBorderColor;
            CommonOperations.Login(driver, user);
            var textColor = driver.FindElementByXPath("//a[@href='/logout']").GetCssValue("color");
            var backgroundColor = driver.FindElementByXPath("//a[@href='/logout']").GetCssValue("background-color");
            var borderColor = driver.FindElementByXPath("//a[@href='/logout']").GetCssValue("border-color");

            try
            {
                Assert.AreEqual(logoutButtonTextColor, textColor);
                Assert.AreEqual(logoutButtonBackgroundColor, backgroundColor);
                Assert.AreEqual(logoutButtonBorderColor, borderColor);
            }
            catch (Exception e)
            {
                Log.WriteLog(e.Message);
                Log.WriteLog(e.StackTrace);
            }
        }
    }
}
