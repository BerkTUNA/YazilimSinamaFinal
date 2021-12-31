using System;
using System.Linq;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace yazilimcilarDunyasi
{
    public class UnitTest1 // test sınfıımız 
    {
        IWebDriver driver = new FirefoxDriver();// 
        [Fact] //bu ifade bize bu metodun test metodu olduğunu gösterir
        public void SiteyeGiris() // test metodumuz
        {
            
            driver.Navigate().GoToUrl("https://stackoverflow.com/users/login");
        }
        [Fact]
        public void sitedeAramaYap() // sitede arama yapan fonksiyonu test eden metodumuz
        {
            SiteyeGiris();
              System.Threading.Thread.Sleep(1000);
              driver.FindElement(By.Name("email")).SendKeys("berk.tuna@hotmail.com.tr"); //elementin ismine göre verdiğimiz text atanıyor
              System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.Name("password")).SendKeys("123456789"); //elementin ismine göre verdiğimiz text atanıyor
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div[3]/form/div[3]")).Click(); //html kod satırında ilgili alandaki butonu bulup click işlemi yapıyoruz.
            System.Threading.Thread.Sleep(1000);
        }
    }
}
