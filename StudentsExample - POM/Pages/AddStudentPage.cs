using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriver_POM_Example.Pages
{
    public class AddStudentPage : BasePage
    {
        public AddStudentPage(IWebDriver driver) : base(driver)
        {

        }
        public override string PageUrl => "https://mvc-app-node-express.nakov.repl.co/add-student";
        public IWebElement InputName => driver.FindElement(By.Id("name"));
        public IWebElement EmailName => driver.FindElement(By.Id("email"));
        public IWebElement AddButton => driver.FindElement(By.CssSelector("button[type='submit']"));

        public IWebElement ErrorMessage => driver.FindElement(By.CssSelector("body > div"));

        public void AddStudent(string name, string email)
        {
            this.InputName.SendKeys(name);
            this.EmailName.SendKeys(email);
            this.AddButton.Click();
        }
    }
}
