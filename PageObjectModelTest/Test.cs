using NUnit.Framework;
using PageObjectModelTest.Helper;
using PageObjectModelTest.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModelTest
{
    public class Tests:Base
    {
        PracticeForm form;

        [Test]

        public void Test1()
        { 
            form = new PracticeForm();
            form.EnterName("Bane");
            form.EnterLastName("Jovanovic");
            form.EnterEmail("bane@mail.com");
            form.EnterPhone("1234567890");
            form.Subject.SendKeys("Math");
            form.Subject.Click("Math");
            form.SelectGender.Click();
            form.Hobbis.Click();

        }
    }
}
