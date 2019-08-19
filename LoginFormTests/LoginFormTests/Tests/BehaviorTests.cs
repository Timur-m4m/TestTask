using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace LoginFormTests
{
    [TestFixture]
    public class BehaviorTests
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

        [Test, Description("Correct login and password")]
        public void LoginWithCorrectData()
        {
            var user = TestData.userCorrectData;
            var successLoginMsg = TestData.successLoginMsg;
            CommonOperations.Login(driver, user);
            var msg = driver.FindElementByXPath("//div[@class='flash success']").Text;

            try
            {
                Assert.AreEqual(successLoginMsg, msg);
            }
            catch (Exception e)
            {
                Log.WriteLog(e.Message);
                Log.WriteLog(e.StackTrace);
            }
        }

        [Test, Description("Logout")]
        public void Logout()
        {
            var user = TestData.userCorrectData;
            var successLogoutMsg = TestData.successLogoutMsg;
            CommonOperations.Login(driver, user);
            driver.FindElementByXPath("//a[@href='/logout']").Click();
            var msg = driver.FindElementByXPath("//div[@class='flash success']").Text;

            try
            {
                Assert.AreEqual(successLogoutMsg, msg);
            }
            catch (Exception e)
            {
                Log.WriteLog(e.Message);
                Log.WriteLog(e.StackTrace);
            }
            
        }

        [Test, Description("Wrong login and correct password")]
        public void LoginWithWrongLogin()
        {
            var user = TestData.userWrongLogin;
            var invalidUsernameMsg = TestData.invalidUsernameMsg;
            CommonOperations.Login(driver, user);
            var msg = driver.FindElementByXPath("//div[@class='flash error']").Text;
            Assert.AreEqual(invalidUsernameMsg, msg);
        }

        [Test, Description("Correct login and wrong password")] 
        public void LoginWithWrongPassword()
        {
            var user = TestData.userWrongPassword;
            var invalidPasswordMsg = TestData.invalidPasswordMsg;
            CommonOperations.Login(driver, user);
            var msg = driver.FindElementByXPath("//div[@class='flash error']").Text;

            try
            {
                Assert.AreEqual(invalidPasswordMsg, msg);
            }
            catch (Exception e)
            {
                Log.WriteLog(e.Message);
                Log.WriteLog(e.StackTrace);
            }
        }

        [Test, Description("Empty login and correct password")]
        public void LoginWithEmptyLogin()
        {
            var user = TestData.userEmptyLogin;
            var invalidUsernameMsg = TestData.invalidUsernameMsg;
            CommonOperations.Login(driver, user);
            var msg = driver.FindElementByXPath("//div[@class='flash error']").Text;

            try
            {
                Assert.AreEqual(invalidUsernameMsg, msg);
            }
            catch (Exception e)
            {
                Log.WriteLog(e.Message);
                Log.WriteLog(e.StackTrace);
            }
        }

        [Test, Description("Correct login and empty password")]
        public void LoginWithEmptyPassword()
        {
            var user = TestData.userEmptyPassword;
            var invalidPasswordMsg = TestData.invalidPasswordMsg;
            CommonOperations.Login(driver, user);
            var msg = driver.FindElementByXPath("//div[@class='flash error']").Text;
            try
            {
                Assert.AreEqual(invalidPasswordMsg, msg);
            }
            catch (Exception e)
            {
                Log.WriteLog(e.Message);
                Log.WriteLog(e.StackTrace);
            }
        }
    }
}
