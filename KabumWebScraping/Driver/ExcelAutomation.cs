using KabumWebScraping.Model;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KabumWebScraping.Driver {
    public class ExcelAutomation { 
        public void SaveDataToExcel(List<Item> items, string filePath) {
            using (var package = new ExcelPackage()) {
                var worksheet = package.Workbook.Worksheets.Add("Produtos"); //cria uma aba na planilha com nome Produtos 

                // Adicionar cabeçalhos 
                worksheet.Cells[1, 1].Value = "Produto"; //Cria uma coluna Produto
                worksheet.Cells[1, 2].Value = "Preço"; //Cria uma coluna Preço

                // Adicionar dados
                for (int i = 0; i < items.Count; i++) {
                    worksheet.Cells[i + 2, 1].Value = items[i].Title;  //adiciona todos intens coletados na coluna Produto
                    worksheet.Cells[i + 2, 2].Value = items[i].Price; //adiciona todos intens coletados na coluna preço
                }

                // Salvar o arquivo
                FileInfo fileInfo = new FileInfo(filePath);  // Cria uma instância da classe FileInfo, classe responsável para criar e manipular o arquivos.
                package.SaveAs(fileInfo); // responsável por salvar o arquivo

            }
        }
    }
}
