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
using OpenQA.Selenium.Interactions;



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

        private void CheckingAddingToCartTC()
        {
            try
            {
                IWebElement shipmentFName = browser.FindElement(By.CssSelector("[data-auto-id='shippingAddress-firstName']"));
                IWebElement shipmentLName = browser.FindElement(By.CssSelector("[data-auto-id='shippingAddress-lastName']"));
                IWebElement shipmentCity = browser.FindElement(By.CssSelector("[data-auto-id='shippingAddress-city']"));
                IWebElement shipmentZipCode = browser.FindElement(By.CssSelector("[data-auto-id='shippingAddress-zipcode']"));

                IWebElement shipmentStreet = browser.FindElement(By.CssSelector("[data-auto-id='shippingAddress-address1']"));
                IWebElement shipmentHouse = browser.FindElement(By.CssSelector("[data-auto-id='shippingAddress-houseNumber']"));
                IWebElement shipmentApartNum = browser.FindElement(By.CssSelector("[data-auto-id='shippingAddress-apartmentNumber']"));
                IWebElement shipmentPhoneNum = browser.FindElement(By.Id("contact-phoneNumber"));
            }
            catch
            {
                Thread.Sleep(1000);
                CheckingAddingToCartTC();
            }

        }


        private void ContinueBuyingTC()
        {
            try
            {

            }

            catch
            {

            }
        }














        private void button1_Click(object sender, EventArgs e)
        {

            var chromeOptions = new OpenQA.Selenium.Chrome.ChromeOptions();

//           chromeOptions.AddHttpProxy("46.150.254.217", 52879, "FU8cdVUd", "CuAjzPf1");
            //   chromeOptions.AddArguments(new List<string>() { "no-sandbox", "headless", "disable-gpu" });
                chromeOptions.AddArguments("--blink-settings=imagesEnabled=false", "--disable-remote-fonts", "--disable-login-animations", "--disable-modal-animations", "--animation-duration-scale=0", "--hide-icons");

            var chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;






            Console.WriteLine("Starting Web Driver");
            browser = new OpenQA.Selenium.Chrome.ChromeDriver(chromeDriverService, chromeOptions);
            Console.WriteLine("Web Driver started");
            browser.Navigate().GoToUrl("https://www.adidas.ru/account-login");
            //browser.Navigate().GoToUrl("https://2ip.ru/");



            Thread.Sleep(500);


            IWebElement emailInput = browser.FindElement(By.Id("login-email"));
            IWebElement passwordInput = browser.FindElement(By.Id("login-password"));
            emailInput.SendKeys(loginField.Text);
            passwordInput.SendKeys(PassField.Text);



            Thread.Sleep(500);

            IWebElement loginBtn = browser.FindElement(By.CssSelector("[data-auto-id='login-form-login']"));
            loginBtn.Click();

            Thread.Sleep(5000);
            browser.Navigate().GoToUrl(LinkField.Text);

            Thread.Sleep(500);

            IWebElement sizeInput = browser.FindElement(By.XPath($"//span[.='{SizeField.Text} RU']"));
            sizeInput.Click();



            Thread.Sleep(500);

            IWebElement buy = browser.FindElement(By.XPath("//span[.='Добавить в корзину']"));
            buy.Click();



            try
            {
                Thread.Sleep(2000);
                IWebElement order = browser.FindElement(By.XPath("//span[.='ОФОРМИТЬ']"));
                order.Click();
         
            }
            catch
            {
                Thread.Sleep(30000);
                sizeInput.Click();
                Thread.Sleep(500);
                buy = browser.FindElement(By.XPath("//span[.='Добавить в корзину']"));
                buy.Click();
                Thread.Sleep(1000);
                IWebElement order = browser.FindElement(By.XPath("//span[.='ОФОРМИТЬ']"));
                order.Click();
            }


          
            Thread.Sleep(1000);


          
            CheckingAddingToCartTC();









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


            Thread.Sleep(1000);

            
           IWebElement shipmentAdressRepeat = browser.FindElement(By.CssSelector("[data-auto-id='save-selected-address-checkbox']"));
            shipmentAdressRepeat.Click();

            Thread.Sleep(1000);

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
            Thread.Sleep(1000);

            try
            {
                continueBuy.Click();
            }
            catch{}

            

         //   Thread.Sleep(10000);


            //      IWebElement continueBuy2 = browser.FindElement(By.XPath("//div[@data-qa-payment-option-preview-type='anyCard']//div[@class='Text__StyledTextDiv-sc-9bqqn7-1 kxjlbW qa-payment-option-title Preview__StyledTitle-aie99n-0 QtQbL']"));
        //    IWebElement continueBuy2 = browser.FindElement(By.LinkText("Банковская карта"));


            //new Actions(browser).MoveToElement(element).MoveByOffset(dx, dy).Click().Perform();


            browser.Manage().Window.Size = new Size(500,500);
            IJavaScriptExecutor js = (IJavaScriptExecutor)browser;
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,300)", "");
            //continueBuy2.Click();
            Thread.Sleep(4000);

            Actions act = new Actions(browser);
            act.MoveByOffset(200, 100).Click().Perform();

            Thread.Sleep(1000);

            Actions act2 = new Actions(browser);
            act2.SendKeys("5404364262171722").Perform();

            Thread.Sleep(500);

            Actions act4 = new Actions(browser);
            Thread.Sleep(500);
            act4.SendKeys("07").Perform();
            Actions act5 = new Actions(browser);
            Thread.Sleep(100);

            Actions act6 = new Actions(browser);
            Thread.Sleep(500);
            act6.SendKeys("23").Perform();
            Actions act7 = new Actions(browser);
            Thread.Sleep(100);

            Actions act8 = new Actions(browser);
            Thread.Sleep(500);
            act8.SendKeys("968").Perform();
            Actions act9 = new Actions(browser);
            Thread.Sleep(100);

            Actions act10 = new Actions(browser);
            Thread.Sleep(500);
            act10.SendKeys(OpenQA.Selenium.Keys.Enter).Perform();





         





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
