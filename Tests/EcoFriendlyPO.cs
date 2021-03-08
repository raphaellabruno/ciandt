using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Ciandt.Tests
{
    public class EcoFriendlyPO
    {
        private IWebDriver driver;
        private By byMenuEco;

        //sortby
        private By bySortBy;
        private By bySortByOp;
        private By byNewest;
        private By byPriceAsc;
        private By byPriceDesc;
        private By byOrderscount;
        private By byTitle;

        //subcategory
        private By bySubcategory;
        private By byApparel;
        private By byLifestyle;
        private By byStationery;

        public EcoFriendlyPO(IWebDriver driver) //injeção de dependencias, depende do webdriver
        {
            this.driver = driver;
            byMenuEco = By.XPath("(//a[contains(text(),'Eco-Friendly')])");

            //sortby
            bySortBy = By.Id("sortby");
            bySortByOp = By.XPath("//option[@value='']");
            byTitle = By.XPath("//option[@value='stitle asc']");
            byPriceDesc = By.XPath("//option[@value='newest desc']");
            byPriceAsc = By.XPath("//option[@value='price asc']");
            byOrderscount = By.XPath("//option[@value='orderscount desc']");

            //subcategory
            bySubcategory = By.Name("Subcategory]");
            byApparel = By.XPath("//option[@value='']");
            byLifestyle = By.XPath("//option[@value='stitle asc']");
            byStationery = By.XPath("//option[@value='stitle asc']");
        }


    }
}
