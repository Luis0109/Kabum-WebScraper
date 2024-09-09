using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KabumWebScraping.Model {
    public class Item {

        public string Title { get; set; }  // criando o atributo responsável pelo titulo do produto
        public string Price { get; set; }// criando o atributo responsável pelo preço do produto
        public override string ToString() {
            return $"{Title} - {Price}";  //convertendo para ToString para que seja possível imprimir no console
        }
    }
}
