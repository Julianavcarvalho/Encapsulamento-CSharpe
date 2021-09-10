using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Principal {
    class ContaBancaria {

        public double Saldo { get; private set; }
        public int Conta { get; private set; }
        public String Nome { get; set; }

        public ContaBancaria(int conta, string nome) {
            Conta = conta;
            Nome = nome;
        }

        public ContaBancaria(double deposito, int conta, string nome):this(conta, nome){
            Deposito(deposito);
        }

        public void Deposito (double deposito) {
            Saldo += deposito;
        }

        public void Saque (double saque) {
            Saldo -= (saque + 5.00);
        }

        public override string ToString() {
            return "\nDados da Conta: \nConta " + Conta + 
                ", Titular " + Nome+ 
                ", Saldo: $ " + Saldo;
        }

    }
}
