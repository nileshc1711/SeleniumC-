using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using AutoIt;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace SampleSelenium
{
    [TestClass]
    public class UnitTest1
    {

        IWebDriver driver = new ChromeDriver();
        string fromEmailId = "abc@gmail.com"; // Enter your email
        string emailPassword = "xxxxxxx"; // Enter your password

        [TestInitialize]
        public void Initialize()
        {
            driver.Navigate().GoToUrl("https://gmail.com");
        }

        [TestMethod]
        public void TestExecution()
        {
            var toEmailIDs = TextFileUtility.GetAllTextFromFile("Data.txt");
            //Find and Enter email value
            var emailInput = driver.FindElement(By.Name("identifier"));
            emailInput.SendKeys(fromEmailId);
            emailInput.SendKeys(Keys.Enter);

            //wait for password field to get enable
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Name("password")));

            //Find and Enter the password value
            var passwordInput = driver.FindElement(By.Name("password"));
            passwordInput.SendKeys(emailPassword);
            passwordInput.SendKeys(Keys.Enter);

            //wait for Home page
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[text()='COMPOSE']")));
            var composeDiv = driver.FindElement(By.XPath("//div[text()='COMPOSE']"));
            composeDiv.Click();

            //wait for Compose mail Dialog
            wait.Until(ExpectedConditions.ElementIsVisible(By.Name("to")));
            var toInputField = driver.FindElement(By.Name("to"));
            toInputField.SendKeys(string.Join(",", toEmailIDs));

            //Find and Enter Subject Box
            var subjectField = driver.FindElement(By.Name("subjectbox"));
            subjectField.SendKeys("Test");

            //var bodyField = driver.FindElement(By.TagName("//div[@aria-label='Message Body'][@role='textbox']"));
            var bodyField = driver.FindElement(By.CssSelector(".Am.Al.editable.LW-avf"));
            bodyField.SendKeys("The Time is always right to do Right ");

            var attachmentLink = driver.FindElement(By.CssSelector(".a1.aaA.aMZ"));
            attachmentLink.Click();

            Process.Start(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "SeleniumAttachScrpit.exe"));

            wait.Until(ExpectedConditions.ElementExists(By.Name("attach")));

            //new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            var sendButton = driver.FindElement(By.CssSelector(".T-I.J-J5-Ji.aoO.T-I-atl.L3"));
            sendButton.Click();

            Console.WriteLine("Execution Finish");
        }

        [TestCleanup]
        public void CleanUp()
        {
           // driver.Close();
        }
    }
}
