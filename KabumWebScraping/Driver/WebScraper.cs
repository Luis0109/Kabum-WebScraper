using EasyAutomationFramework;
using KabumWebScraping.Model;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KabumWebScraping.Driver {
    public class WebScraper{

        private IWebDriver driver; // responsável pelo controle do navegador 

        public WebScraper() {

            var options = new ChromeOptions();
        
            driver = new ChromeDriver(); //contrutor responsável pela interação com o Chrome 
        
        }

        public List<Item> GetData() {

            driver.Navigate().GoToUrl("https://www.kabum.com.br/busca/headset-corsair-sem-fio-"); //caminho da navegação 


            var items = new List<Item>(); //criação de Lista


            try {
                var elements = driver.FindElement(By.XPath("//*[@id=\"listing\"]/div[3]/div/div/div[2]/div")).FindElements(By.ClassName("rounded-4")); // localize a div do elemtno ontem contem o nome e titulo do produto

                foreach (var element in elements) {
                    var item = new Item();
                    item.Title = element.FindElement(By.ClassName("nameCard")).Text; //localize tudo o que está na classe nameCard que sera impressor o nome do produto
                    item.Price = element.FindElement(By.ClassName("priceCard")).Text; //localiza tudo o que está na classe priceCard, que será impresso o preço do produto

                    Console.WriteLine($"Produto: {item.Title} - Preço: {item.Price}"); //imprimindo para verificar se obteve êxito na Web Scraper 

                

                    items.Add(item); // Adiciona na lista as coletas de dados

                }
            } catch (Exception ex) {
                Console.WriteLine("Erro inesperado: " + ex.Message); // exibe mensagem de erro caso a tarefa não consiga ser executada 
            } finally {
                driver.Quit(); // Fechar o navegador após a execução
            }

            return items;

            
        }

    }
}
