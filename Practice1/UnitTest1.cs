using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Sai_Test1;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        Console.WriteLine("opening Amazon Application");
        string base_url = "https://www.amazon.com/";
        IWebDriver driver = new ChromeDriver();
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        driver.Navigate().GoToUrl(base_url);
        Console.WriteLine("Maximizing chrome browser");
        driver.Manage().Window.Maximize();
        Thread.Sleep(60);
        Console.WriteLine("Maximizing chrome browser");
        driver.Close();
    }





    [TestMethod]
    public void TestMethod2()
    {
    }

    [TestMethod]
    public void TestMethod3()
    {
    }

    [TestMethod]
    public void TestMethod4()
    {
    }
}
