using NPOI.OpenXmlFormats.Vml.Office;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FirstNunitTest.PageObject
{
    public class loginpage
    {
        private readonly IWebDriver _driver;

        //public loginpage(IWebDriver driver)
        //{
        //    _driver = driver; // Store the driver instance
        //}

        //// You can also add other elements similarly
        //public IWebElement UsernameTextbox => _driver.FindElement(By.Id("usernameTag")); // Example for another element
        //// Directly using a property to find the PasswordTextbox
        //public IWebElement PasswordTextbox => _driver.FindElement(By.Id("passwordTag"));

        //public IWebElement SubmitButton => _driver.FindElement(By.Id("#btnLogn"));

        //public void Login()
        //{
        //    UsernameTextbox.SendKeys("username");
        //    PasswordTextbox.SendKeys("password");
        //    SubmitButton.Click();

        //}


        // Method to enter username
        //public void EnterUsername(string username)
        //{
        //    UsernameTextbox.SendKeys(username);
        //}

        //// Method to enter password
        //public void EnterPassword(string password)
        //{
        //    PasswordTextbox.SendKeys(password);
        //}

        //public void ClickSubmit(string password)
        //{
        //    SubmitButton.Click();
        //}

         
    }

    
}
 