using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ebay2
{
	public class Tests
	{
		BrowserFactory testdrive = new BrowserFactory();
		IWebDriver driver;
		Home drive;


		[SetUp]
		public void Setup()
		{
			driver = testdrive.InitBrowser();
			drive = new Home(driver);
		}

		[Test]
		public void Test1()
		{
			//setup the product for search
			drive.home.SearchFor = "mouse";

			//setup the minimum price
			drive.home.Min = "50";

			//search for the product with the fillter
			drive.home.SearchInBar(driver);
			
			
			
			//Assert.Pass();
		}
	}
}