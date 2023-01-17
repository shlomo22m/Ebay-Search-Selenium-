using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ebay2
{
	public class Fillter
	{

		public Fillter() 
		{

		}

		public void Fillterapllay(IWebDriver web1,string min_price) 
		{
			
			web1.FindElement(By.Id("s0-52-12-0-1-2-6-0-8[3]-0-textrange-beginParamValue-textbox")).SendKeys(min_price);
			web1.FindElement(By.XPath("//*[@id=\"s0-52-12-0-1-2-6-0-8[3]-0-textrange\"]/div/div[3]/button[1]")).Click();
		}
	} 
}
