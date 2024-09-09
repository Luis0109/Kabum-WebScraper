using EasyAutomationFramework;
using EasyAutomationFramework.Model;
using java.lang;
using KabumWebScraping.Driver;
using OpenQA.Selenium.DevTools.V126.Database;


class Program {
    static void Main(string[] args) {
        var web = new WebScraper(); //isntancia da classe
        var items = web.GetData();  //instacia do método que está dentro da classe que foi instanciada  



        var excelAutomation = new ExcelAutomation(); //instancia da classe responsável pela criação do excel
        excelAutomation.SaveDataToExcel(items, @"C:\Users\lhspinheiro\Documents\projects.net\aulas c#\cursoUdemy\KabumWebScraping\KabumWebScraping\ExcelScraper\produtos.xlsx"); //salva o excel na pasta especificada

        
    }
}









