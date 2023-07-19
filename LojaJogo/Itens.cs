using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaJogo
{
    internal class Itens
    {
        public string item;
        public int valor;
        List<Itens> itemList = new List<Itens>();

        public Itens(string item, int valor)
        {
            this.item = item;
            this.valor = valor;
        }
        public Itens()
        {
            
        }

        public void Cadastra()
        {

            itemList.Add(new Itens("Espada Flamejante ", 20));
            itemList.Add(new Itens("Espada de Gelo ", 50));
            itemList.Add(new Itens("Espada de Vento ", 100));
            itemList.Add(new Itens("Espada de Cristal ", 500));
        }
        public void Imprime()
        {
            foreach (var item in itemList)
            {
                Console.WriteLine(item.item + "-" + item.valor);
            }
        }
            
    }
}
