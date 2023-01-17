using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V106.DOM;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ebay2
{
	public class SearchBar
	{
		//public IWebDriver forfillter = new ChromeDriver();
		private string searchfor;
		private string min;
		private IWebElement searchbar;
		public Fillter fillter=new Fillter();


		public  SearchBar()
		{
			
			
		}
		
		public string Min 
		{
			get { return min; }
			set { min = value;}
		}

		public string SearchFor
		{
			get { return searchfor; }
			set { searchfor = value; }
		}

		public void SearchInBar(IWebDriver web1) 
		{
			web1.FindElement(By.Id("gh-ac")).SendKeys(searchfor);
			web1.FindElement(By.Id("gh-btn")).Click();
			fillter.Fillterapllay(web1,min);
		}

	}
}
