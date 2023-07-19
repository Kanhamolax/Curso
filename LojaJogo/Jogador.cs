using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaJogo
{
    internal class Jogador
    {
        public int moedas,quantidade;
        public Itens ItensComprados;
        public Jogador()
        {
            this.moedas = 10;
            this.quantidade = 0;
        }

        public void  CompraItens()
        {
            Console.WriteLine("uma Espada foi comprada");
            ItensComprados = new Itens("Espada", 20);
            this.quantidade++;
            this.moedas -= ItensComprados.valor;

        }
        public void  AddMoedas()
        {
            Console.WriteLine("Digite a quantidade de Moedas que quer adicior :");
           int  op = int.Parse(Console.ReadLine());
            this.moedas += op;
        }
        public void MostraSaldo()
        {
            Console.WriteLine("Seu Saldo é :"+this.moedas);

        }
        public void BolsaJogador()
        {
            Console.WriteLine("O Jogador tem "+this.quantidade+" Espadas");
        }
    }
}
