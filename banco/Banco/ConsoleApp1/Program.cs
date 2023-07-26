using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace Banco // Note: actual namespace depends on the project name.
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            int op;
            double valor;
            Conta conta=new Conta();
            do
            {
                Console.WriteLine("*********Banco************");
                Console.WriteLine("1-Criar Conta");
                Console.WriteLine("2-Consultar Saldo");
                Console.WriteLine("3-Deposito");
                Console.WriteLine("4-Saque");
                Console.WriteLine("5-Atualizar dados");

                Console.WriteLine("Digite uma opção :");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        string nome;
                        int op2;
                        double saldo;
                        Console.WriteLine("Digite seu nome");
                        nome = Console.ReadLine();

                        Console.WriteLine("Ira adicionar saldio inicial ?");
                        Console.WriteLine("1-Sim");
                        Console.WriteLine("2-Não");
                        op2 = int.Parse(Console.ReadLine());

                        switch (op2)
                        {
                            case 1:
                                Console.WriteLine("Digite o valor do saldo inicial :");
                                saldo = double.Parse(Console.ReadLine());
                                conta.CriaConta(nome, saldo);


                                break;
                            case 2:

                                conta.CriaConta(nome);
                                break;

                        }
                       
                        break;
                    case 2:
                        conta.MostraSaldo();
                        break;
                  
                    case 3:
                        Console.WriteLine("Digite o valo que quer depositar:");
                        valor = double.Parse(Console.ReadLine());
                        conta.Deposita(valor );
                        break;
                    case 4:

                        Console.WriteLine("Digite o valo que quer sacar:");
                        valor = double.Parse(Console.ReadLine());
                        conta.Saque(valor);
                        break;
                    case 5:
                        Console.WriteLine("Digite o nome:");
                        nome = Console.ReadLine();
                        conta.Atualiza(nome );
                        break;
                }


            } while (true);

           
        }
       
       



    }
}