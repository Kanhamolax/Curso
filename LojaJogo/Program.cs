using System;
using System.Security.Cryptography.X509Certificates;

namespace LojaJogo // Note: actual namespace depends on the project name.
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            int op;
           
            Jogador jogador = new Jogador();



            jogador.ItensComprados.Cadastra();
            do
            {
               
              

                Console.WriteLine("Loja de Espadas");
                Console.WriteLine("1 - Itens  a venda.");
                Console.WriteLine("2 - Adicionar Moedas.");
                Console.WriteLine("3 - Exibir Saldo.");
                Console.WriteLine("4 - Comprar item.");
                Console.WriteLine("5 - Bolsa do jogado.");

                op =  int.Parse(Console.ReadLine());

                switch(op)
                {
                    case 1:
                        jogador.ItensComprados.Imprime();
                        
                        break;
                    case 2:
                        jogador.AddMoedas();
                        break;
                    case 3:
                        jogador.MostraSaldo();

                        break;
                    case 4:
                        jogador.CompraItens();
                        break;
                    case 5:
                        jogador.BolsaJogador();
                        break;
                }
               


            } while (true);
        }
    }
}