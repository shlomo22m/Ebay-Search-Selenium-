using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ebay2
{
	internal class BrowserFactory
	{
		public IWebDriver driver;

		public IWebDriver Driver
		{
			get
			{
				if (driver == null)
					throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method InitBrowser.");
				return driver;
			}
			private set
			{
				this.driver = value;
			}
		}
		public IWebDriver InitBrowser()
		{
			driver = new ChromeDriver("D:\\Drivers\\");
			return driver;
		}
	}
}
