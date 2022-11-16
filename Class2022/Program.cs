using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

driver.Navigate().GoToUrl("https://www.google.com");

IWebElement searchInput = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[2]/input"));
searchInput.SendKeys("Origami");

IWebElement searchButton = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[4]/center/input[1]"));
searchButton.Click();

IWebElement visualSearch = driver.FindElement(By.XPath("//*[@id=\"tsf\"]/div[1]/div[1]/div[2]/div/div[2]/input"));

var equalText = visualSearch.TagName == "Origami" ? "Found Origami Text" : "Failed";

Console.WriteLine(equalText);