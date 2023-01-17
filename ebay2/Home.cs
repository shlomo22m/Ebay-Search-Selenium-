using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V106.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ebay2
{
	public class Home
	{
		public SearchBar home;
		
		

		public Home(IWebDriver web1)
		{

			web1.Navigate().GoToUrl("http://www.ebay.com");
			web1.Manage().Window.Maximize();
			home =new SearchBar();
			

		}

		
	}
}
