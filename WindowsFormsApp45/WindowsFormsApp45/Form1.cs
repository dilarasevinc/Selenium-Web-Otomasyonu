using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace WindowsFormsApp45
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.beymen.com/";
            Thread.Sleep(TimeSpan.FromSeconds(5));
            
             driver.FindElement(By.LinkText("Hesabım")).Click();
             Thread.Sleep(TimeSpan.FromSeconds(5));
             driver.FindElement(By.LinkText("Favorilerim")).Click();
             Thread.Sleep(TimeSpan.FromSeconds(5));
             driver.FindElement(By.LinkText("Sepetim")).Click();
             Thread.Sleep(TimeSpan.FromSeconds(5));
             driver.FindElement(By.ClassName("o-header__logo--img")).Click();
             Thread.Sleep(TimeSpan.FromSeconds(5)); 
            var arama = driver.FindElement(By.XPath("//input[@placeholder='Ürün, Marka Arayın']"));

            if (arama != null)
            {
                arama.SendKeys("Pantolon");
                arama.SendKeys(OpenQA.Selenium.Keys.Enter);
            }
            
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            Thread.Sleep(TimeSpan.FromSeconds(5));
            js.ExecuteScript("window.scrollBy(0,5500);");
            Thread.Sleep(TimeSpan.FromSeconds(3));
            driver.FindElement(By.Id("moreContentButton")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            driver.FindElement(By.LinkText("Bej Jogger Eşofman")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            driver.FindElement(By.XPath("//span[@class= 'm-variation__item']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            driver.FindElement(By.Id("addBasket")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            driver.FindElement(By.LinkText("Sepetim")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
             var option = driver.FindElement(By.Id("quantitySelect0"));
             var select_option = new SelectElement(option);
            select_option.SelectByValue("2");
            Thread.Sleep(TimeSpan.FromSeconds(5));
            driver.FindElement(By.Id("removeCartItemBtn0")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            
        }
    }
}
