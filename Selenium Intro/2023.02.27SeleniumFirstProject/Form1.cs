using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//Lecture Notes
namespace _2023._02._27SeleniumFirstProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IWebDriver driver= new ChromeDriver();
            driver.Url = "https://www.google.com";
            var searchBox = driver.FindElement(By.Name("q"));

            if (searchBox != null)
            {
                Thread.Sleep(5000);
                searchBox.SendKeys("Muhammed EROGLU");
                searchBox.SendKeys(OpenQA.Selenium.Keys.Enter);
                Thread.Sleep(5000);
                driver.Quit();
            }
        }
    }
}