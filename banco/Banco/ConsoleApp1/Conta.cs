using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class Conta
    {
        public double saldo{ get;  private set; }
    public string nome { get;  set; }
    public int numereoConta { get; private set; }
        public Conta(double saldo, string nome,int numeroConta)
        {
            this.saldo = saldo;
            this.nome = nome;
            this.numereoConta = numeroConta;
        }
        public Conta()
        {
            this.saldo = 0;
            this.nome = "";
            this.numereoConta = 0;
        }
        public void CriaConta(string nome,double valor)
        {
           
            this.nome = nome;
            this.numereoConta=123321;
            this.saldo = valor;

        }
        public void CriaConta(string nome)
        {

            this.nome = nome;
            this.numereoConta = 123321;
            this.saldo = 0;

        }
       
        public void MostraSaldo()
        {

            Console.WriteLine(this.nome+" Seu saldo é:");
            Console.WriteLine(this.saldo);

        }
      public  void Deposita(double valor)
        {
           
            
          this.saldo += valor;

        }
        public void Saque(double valor )
        {
          
            this.saldo -= valor+5;

        }
        public void Atualiza(string nome)
        {
           
           
            this.nome = nome;
           

        }

    }
}
