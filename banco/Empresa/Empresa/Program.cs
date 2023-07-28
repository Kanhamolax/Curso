using System;
using System.Security.Cryptography.X509Certificates;

namespace Empresa // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
             int n,hours;
            char sn;
            string nome;
            double value;

            Console.WriteLine("numero de empregados :");
            n=int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("$$Empregado "+i+" Infos $$");
                Console.WriteLine("O funcionario é Tercerisado ? s/n");
                sn=char.Parse(Console.ReadLine());
                Console.WriteLine("quano o nome do funcionario :");
                nome = Console.ReadLine();
                Console.WriteLine("horas :");
                hours = int.Parse(Console.ReadLine());
                Console.WriteLine("Qual o valor da hora :");
                value=double.Parse(Console.ReadLine());

                if (sn == 'n')
                {
                    list.Add(new Employee(nome, hours, value));

                }
                else
                {
                    Console.WriteLine("digite o valor adicional :");
                    double addvalue = double.Parse(Console.ReadLine());

                    list.Add( new OutSorcererEmployee(nome, hours, value,addvalue));
                }


            }
            foreach (Employee emp in list)
            {

                Console.WriteLine("funcionario " + emp.Nome + "ganha :" + emp.Payment());
            }

           

        }
    }
}