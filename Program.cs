using System;
using System.Globalization;

namespace Principal {
    class Program {
        static void Main(string[] args) {

            ContaBancaria c;

            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá deposito inicial? (s/n) ");
            char escolha = char.Parse(Console.ReadLine());
            if (escolha == 's' || escolha == 'S') {
                Console.Write("Qual o valor do deposito? ");
                double saldo = double.Parse(Console.ReadLine());
                c = new ContaBancaria(saldo, numero, nome);
            } else {
                c = new ContaBancaria(numero, nome);
            }

            Console.WriteLine(c);


            Console.Write("\n\nEntre com um valor para deposito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Deposito(deposito);
            Console.WriteLine(c);

            Console.Write("\n\nEntre com um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Saque(saque);
            Console.WriteLine(c);

        }
    }
}
