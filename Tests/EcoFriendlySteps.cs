using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Ciandt.Configs;
using NUnit.Framework;

namespace Ciandt.Tests 
{
    [Binding]
    public class EcoFriendlySteps : WebDriver
    {
        EcoFriendlyPO eco = new EcoFriendlyPO(driver);

        [Given]
        public void DadoEstarNoSiteGoogleShop()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given]
        public void DadoClicarNoMenuEcoFriendy()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given]
        public void DadoEntrarNaPáginaEcoFriendly()
        {
            Assert.AreEqual("Eco-Friendly", driver.Title);
        }
        
        [Given]
        public void DadoEstarNaPáginaEcoFriendly()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given]
        public void DadoEsta()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When]
        public void QuandoClicarNoFiltroSubcategory()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When]
        public void QuandoSelecionar_P0(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When]
        public void QuandoSelecionarLifeStyle()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When]
        public void QuandoClicarNoFiltroOrderBy()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When]
        public void QuandoSelecionarSortBy()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When]
        public void QuandoRolarAPágina()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When]
        public void QuandoClicarEmUmProduto()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then]
        public void EntãoApenasItensComASubcategoria_P0_SendoMostrados(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then]
        public void EntãoApenasItensComASubcategoriaLifeStyleSendoMostrados()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then]
        public void EntãoItensOrdenadosDeAcordoCom_P0(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then]
        public void EntãoItensNovosSerãoMostrados()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then]
        public void EntãoDetalhesDoProdutoSerãoExibidos()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
