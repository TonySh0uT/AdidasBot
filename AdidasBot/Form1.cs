using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Chrome.ChromeDriverExtensions;


namespace AdidasBot
{
    public partial class Form1 : Form
    {
        IWebDriver browser;

       


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var chromeOptions = new OpenQA.Selenium.Chrome.ChromeOptions();

           chromeOptions.AddHttpProxy("46.150.254.217", 52879, "FU8cdVUd", "CuAjzPf1");
            //   chromeOptions.AddArguments(new List<string>() { "no-sandbox", "headless", "disable-gpu" });
            //    chromeOptions.AddArgument("disable-gpu");

            var chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;






            Console.WriteLine("Starting Web Driver");
            browser = new OpenQA.Selenium.Chrome.ChromeDriver(chromeDriverService, chromeOptions);
            Console.WriteLine("Web Driver started");
            browser.Navigate().GoToUrl("https://www.adidas.ru/account-login");
            //browser.Navigate().GoToUrl("https://2ip.ru/");



            Thread.Sleep(1000);


            IWebElement emailInput = browser.FindElement(By.Id("login-email"));
            IWebElement passwordInput = browser.FindElement(By.Id("login-password"));
            emailInput.SendKeys(loginField.Text);
            passwordInput.SendKeys(PassField.Text);



            Thread.Sleep(1000);

            IWebElement loginBtn = browser.FindElement(By.CssSelector("[data-auto-id='login-form-login']"));
            loginBtn.Click();

            Thread.Sleep(1000);
            browser.Navigate().GoToUrl(LinkField.Text);

            Thread.Sleep(1000);

            IWebElement sizeInput = browser.FindElement(By.XPath($"//span[.='{SizeField.Text} RU']"));
            sizeInput.Click();



            Thread.Sleep(1000);

            IWebElement buy = browser.FindElement(By.XPath("//span[.='Добавить в корзину']"));
            buy.Click();
            Thread.Sleep(30000);
            sizeInput.Click();
            Thread.Sleep(1000);
            buy = browser.FindElement(By.XPath("//span[.='Добавить в корзину']"));
            buy.Click();
            Thread.Sleep(3000);


            IWebElement order = browser.FindElement(By.XPath("//span[.='ОФОРМИТЬ']"));
            order.Click();

            Thread.Sleep(3000);

            IWebElement shipmentFName = browser.FindElement(By.CssSelector("[data-auto-id='shippingAddress-firstName']"));
            IWebElement shipmentLName = browser.FindElement(By.CssSelector("[data-auto-id='shippingAddress-lastName']"));
            IWebElement shipmentCity = browser.FindElement(By.CssSelector("[data-auto-id='shippingAddress-city']"));
            IWebElement shipmentZipCode = browser.FindElement(By.CssSelector("[data-auto-id='shippingAddress-zipcode']"));

            IWebElement shipmentStreet = browser.FindElement(By.CssSelector("[data-auto-id='shippingAddress-address1']"));
            IWebElement shipmentHouse = browser.FindElement(By.CssSelector("[data-auto-id='shippingAddress-houseNumber']"));
            IWebElement shipmentApartNum = browser.FindElement(By.CssSelector("[data-auto-id='shippingAddress-apartmentNumber']"));
            IWebElement shipmentPhoneNum = browser.FindElement(By.Id("contact-phoneNumber"));

            shipmentFName.SendKeys(OpenQA.Selenium.Keys.Control + "a");
            shipmentFName.SendKeys(OpenQA.Selenium.Keys.Delete);

            shipmentLName.SendKeys(OpenQA.Selenium.Keys.Control + "a");
            shipmentLName.SendKeys(OpenQA.Selenium.Keys.Delete);

            shipmentCity.SendKeys(OpenQA.Selenium.Keys.Control + "a");
            shipmentCity.SendKeys(OpenQA.Selenium.Keys.Delete);

            shipmentZipCode.SendKeys(OpenQA.Selenium.Keys.Control + "a");
            shipmentZipCode.SendKeys(OpenQA.Selenium.Keys.Delete);

            shipmentStreet.SendKeys(OpenQA.Selenium.Keys.Control + "a");
            shipmentStreet.SendKeys(OpenQA.Selenium.Keys.Delete);

            shipmentHouse.SendKeys(OpenQA.Selenium.Keys.Control + "a");
            shipmentHouse.SendKeys(OpenQA.Selenium.Keys.Delete);


            shipmentApartNum.SendKeys(OpenQA.Selenium.Keys.Control + "a");
            shipmentApartNum.SendKeys(OpenQA.Selenium.Keys.Delete);


            shipmentPhoneNum.SendKeys(OpenQA.Selenium.Keys.Control + "a");
            shipmentPhoneNum.SendKeys(OpenQA.Selenium.Keys.Delete);


            Thread.Sleep(2000);

            
           IWebElement shipmentAdressRepeat = browser.FindElement(By.CssSelector("[data-auto-id='save-selected-address-checkbox']"));
            shipmentAdressRepeat.Click();

            Thread.Sleep(2000);

            IWebElement shipmentConifirmition = browser.FindElement(By.CssSelector("[data-auto-id='explicit-consent-checkbox']"));
            shipmentConifirmition.Click();

            Thread.Sleep(1000);

            shipmentFName.SendKeys(FNameField.Text);
            shipmentLName.SendKeys(LNameField.Text);
            shipmentCity.SendKeys(CityField.Text);
            shipmentZipCode.SendKeys(ZipField.Text);
            shipmentStreet.SendKeys(StreetField.Text);
            shipmentHouse.SendKeys(HouseField.Text);
            shipmentApartNum.SendKeys(ApartField.Text);
            shipmentPhoneNum.SendKeys(PhoneField.Text);



            Thread.Sleep(1000);

            IWebElement continueBuy = browser.FindElement(By.XPath("//span[.='Продолжить оформление']"));
            continueBuy.Click();

            Thread.Sleep(10000);

            IWebElement continueBuy2 = browser.FindElement(By.XPath("//span[.='Банковская карта']"));
            continueBuy2.Click();

            




            /*

            string FName = "Какое-то имя";
            string LName = "Какая-то фамилия";
            string City = "Город 1";
            string Zip = "123456";
            string Street = "Какая-то улица";
            string House = "Какой-то дом";
            string Apartament = "Какая-то квартира";
            string Phone = "7777777777";



            */

            



            //  browser.Quit();
            //  Application.Exit();
















        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void PhoneField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
