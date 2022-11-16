using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EpamTestingLab
{
    class AndroIdDemo
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("D:\\3rdparty\\chrome");
        }

        [Test]
        public void test1()
        {
            driver.Url = "https://pastebin.com/";
            IWebElement CodeInput = driver.FindElement(By.Id("postform-text"));
            CodeInput.SendKeys("Hello from WebDriver");
            driver.FindElement(By.Id("select2-postform-expiration-container")).Click();
            driver.FindElement(By.XPath("//li[text()='10 Minutes']")).Click();

            IWebElement NameInput = driver.FindElement(By.Id("postform-name"));
            NameInput.SendKeys("helloweb");

            driver.FindElement(By.XPath("//button[@class='btn -big']")).Click();
        }
        [Test]
        public void test2()
        {
            driver.Url = "https://pastebin.com/";
            IWebElement CodeInput = driver.FindElement(By.Id("postform-text"));
            CodeInput.SendKeys("git config —global user.name \"New Sheriff in Town\"\n" +
            "git reset $(git commit-tree HEAD^{tree} -m \"Legacy code\")\n" +
            "git push origin master —forceHello from WebDriver");

            driver.FindElement(By.Id("select2-postform-format-container")).Click();
            driver.FindElement(By.XPath("//li[text()='Bash']")).Click();

            driver.FindElement(By.Id("select2-postform-expiration-container")).Click();
            driver.FindElement(By.XPath("//li[text()='10 Minutes']")).Click();

            IWebElement NameInput = driver.FindElement(By.Id("postform-name"));
            NameInput.SendKeys("how to gain dominance among developers");

            driver.FindElement(By.XPath("//button[@class='btn -big']")).Click();
        }
        [Test]
        public void test3()
        {
            driver.Url = "https://cloud.google.com/";
            driver.FindElement((By.XPath("//div[@class='devsite-search-container']"))).Click();
            IWebElement Search = driver.FindElement(By.XPath("//input[@class='devsite-search-field devsite-search-query']"));
            Search.Click();
            Search.SendKeys("Google Cloud Pricing Calculator");
            Search.SendKeys(Keys.Enter);
            Thread.Sleep(10000);
            driver.FindElement(By.XPath("//b[text()='Google Cloud Pricing Calculator']/parent::a")).Click();
            Thread.Sleep(10000);
            driver.Url="https://cloud.google.com/products/calculator";
            IWebElement element = driver.FindElement(By.XPath("//iframe[contains(@name,'goog_')]"));
            driver.SwitchTo().Frame(element);
            driver.SwitchTo().Frame("myFrame");
            IWebElement numberOfInstancesField = driver.FindElement(By.XPath("//md-input-container/child::input[@ng-model='listingCtrl.computeServer.quantity']"));
            numberOfInstancesField.SendKeys("4");
            Thread.Sleep(2000);
            IWebElement Series = driver.FindElement(By.XPath("//*[@id=\"select_value_label_85\"]"));
            Series.Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//md-option[@id='select_option_201']")).Click();
            Thread.Sleep(2000);
            IWebElement Machine_Family = driver.FindElement(By.XPath("//*[@id=\"select_value_label_86\"]"));
            Machine_Family.Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//md-option[@value='CP-COMPUTEENGINE-VMIMAGE-N1-STANDARD-8']")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//md-checkbox[@aria-label='Add GPUs']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//md-select[@placeholder='GPU type']")).Click();
            driver.FindElement(By.XPath("//md-option[@id='select_option_474']")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//md-select[@placeholder='Number of GPUs']")).Click();
            driver.FindElement(By.XPath("//md-option[@id='select_option_477']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//md-select[@placeholder='Local SSD']")).Click();
            driver.FindElement(By.XPath("//md-op    tion[@id='select_option_450']")).Click();

            driver.FindElement(By.XPath("//md-select[@placeholder='Committed usage']")).Click();
            driver.FindElement(By.XPath("//md-option[@id='select_option_128']")).Click();

            driver.FindElement(By.XPath("//button[@aria-label='Add to Estimate']")).Click();
        }
        [Test]
        public void test4()
        {
            driver.Url="https://yopmail.com/en";
            driver.FindElement(By.XPath("//a[@href='email-generator']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[@id='cprnd']")).Click();
            Thread.Sleep(2000);


            ((IJavaScriptExecutor)driver).ExecuteScript("window.open()");
            List<String> tabs = new List<String>(driver.WindowHandles);
            driver.SwitchTo().Window(tabs[1]);

            driver.Url="https://cloud.google.com/products/calculator";
            IWebElement element = driver.FindElement(By.XPath("//iframe[contains(@name,'goog_')]"));
            driver.SwitchTo().Frame(element);
            driver.SwitchTo().Frame("myFrame");
            IWebElement numberOfInstancesField = driver.FindElement(By.XPath("//md-input-container/child::input[@ng-model='listingCtrl.computeServer.quantity']"));
            numberOfInstancesField.SendKeys("4");
            Thread.Sleep(2000);
            IWebElement Series = driver.FindElement(By.XPath("//*[@id=\"select_value_label_85\"]"));
            Series.Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//md-option[@id='select_option_201']")).Click();
            Thread.Sleep(2000);
            IWebElement Machine_Family = driver.FindElement(By.XPath("//*[@id=\"select_value_label_86\"]"));
            Machine_Family.Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//md-option[@value='CP-COMPUTEENGINE-VMIMAGE-N1-STANDARD-8']")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//md-checkbox[@aria-label='Add GPUs']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//md-select[@placeholder='GPU type']")).Click();
            driver.FindElement(By.XPath("//md-option[@id='select_option_474']")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//md-select[@placeholder='Number of GPUs']")).Click();
            driver.FindElement(By.XPath("//md-option[@id='select_option_477']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//md-select[@placeholder='Local SSD']")).Click();
            driver.FindElement(By.XPath("//md-option[@id='select_option_450']")).Click();

            driver.FindElement(By.XPath("//md-select[@placeholder='Committed usage']")).Click();
            driver.FindElement(By.XPath("//md-option[@id='select_option_128']")).Click();

            driver.FindElement(By.XPath("//button[@aria-label='Add to Estimate']")).Click();
            driver.FindElement(By.XPath("//button[@aria-label='Email']")).Click();

            driver.FindElement(By.XPath("//input[@type='email']"))
            .SendKeys(Keys.Control+ "v");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[@aria-label='Send Email']")).Click();
            driver.SwitchTo().Window(tabs[0]);
            driver.FindElement(By.XPath("/html/body/div/div[2]/main/div/div[2]/div/div/div[2]/button[2]/span")).Click();
        }
        [Test]
        public void test5()
        {
            driver.Url="https://catalog.onliner.by/videocard/msi/gf3060gam2x12";
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div/div/div/div[2]/div[1]/main/div/div/aside/div[1]/div[3]/div[1]/div[1]/div[3]/a[2]")).Click();
        }

        //[TearDown]
        //public voId closeBrowser()
        //{
        //    driver.Close();
        //}

    }
}