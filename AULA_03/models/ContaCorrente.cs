using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AULA_03.models
{
    public class ContaCorrente
    {
        public int numero { get; set; } 
        private decimal saldo { get; set; }

        public ContaCorrente(decimal saldoInicial)
        {
            saldo = saldoInicial;
        }
        public void sacar(decimal valor){
            if(valor<= saldo){
                saldo = saldo - valor;
                Console.WriteLine("Saldo de R$" + valor + " realizado com sucesso!");
            }else{
                Console.WriteLine("Saldo insuficiente");
            }
            
        }
        public void ExibirSaldo() {
            Console.WriteLine("Seu saldo é: R$" + saldo);
        }
    }
}