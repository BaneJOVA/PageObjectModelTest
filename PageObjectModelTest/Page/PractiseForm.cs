using OpenQA.Selenium;
using System.Xml.Linq;

namespace PageObjectModelTest.Page
{
    public class PractiseForm
    {
        private IWebDriver driver = WebDriver.Instance;

        public IWebElement FirstName => driver.FindElement(By.Id("firstName"));
        public IWebElement LastName => driver.FindElement(By.Id("lastName"));
        public IWebElement Email => driver.FindElement(By.Id("userEmail"));
        public IWebElement Gender => driver.FindElement(By.Id("gender-radio-1"));
        public IWebElement PhoneNumber => driver.FindElement(By.Id("userNumber-wrapper"));
        public IWebElement Subject => driver.FindElement(By.Id("subjectsWrapper"));
        public IWebElement Hobbies => driver.FindElement(By.Id("hobbies-checkbox-1"));
        public IWebElement Button => driver.FindElement(By.Id("submit"));

        public void EnterName(string name)
        {
            FirstName.SendKeys(name);
        }
        public void EnterLastName(string name)
        {
             LastName.SendKeys(name);
        }

        public void EnterEmail(string email)
        {
            Email.SendKeys(email);
        }

        public void EnterGender(string gender)
        {
            Gender.SendKeys(gender);
        }

        public void SelectHobbis()
        {
            Hobbies.Click();
        }
 
        public void PressButon()
        {
            Button.Click();
        }
    }
}
