using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriver_POM_Example.Pages;

namespace WebDriver_POM_Example.Tests
{
    public class HomePageTests : BaseTests
    {
        [Test]
        public void Test_HomePage_TitleAndHeading()
        {
            var page = new HomePage(driver);
            page.Open();
            Assert.That(page.GetPageTitle(), Is.EqualTo("MVC Example"));
            Assert.That(page.GetPageHeadingTexts(), Is.EqualTo("Students Registry"));
            Assert.Greater(page.GetStudentsCount(), 0);
        }

        [Test]
        public void Test_HomePage_ViewStudentsLink()
        {
            var home_page = new HomePage(driver);
            home_page.Open();
            //home_page.LinkViewStudentsPage.Click();
            home_page.ViewStudentsLink.Click();
            Assert.IsTrue(new ViewStudentsPage(driver).isOpen());
        }

        [Test]
        public void Test_HomePage_OpenAddStudentPage()
        {
            var home_page = new HomePage(driver);
            home_page.Open();
            //home_page.LinkAddStudentPage.Click();
            home_page.AddStudentLink.Click();
            Assert.IsTrue(new AddStudentPage(driver).isOpen());
        }

        [Test]
        public void Test_HomePage_ViewHomeLinlk()
        {
            var home_page = new HomePage(driver);
            home_page.Open();
            //home_page.LinkHomePage.Click();
            home_page.HomeLink.Click();
            Assert.IsTrue(home_page.isOpen());
        }
    }
}
