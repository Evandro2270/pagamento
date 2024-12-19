using System;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;

                string nome = "";
                double valorHora, trabalhadaHora, pagamento;

                Console.WriteLine("Entre com nome do funcionario");
                Console.Write("Nome: ");
                nome = Console.ReadLine();

                Console.WriteLine();

                Console.WriteLine("Qual valor das horas trabalhada");
                Console.Write("Valor das Horas: ");
                valorHora = double.Parse(Console.ReadLine(), CI);

                Console.WriteLine();

                Console.WriteLine("Quantas hora funcionario trabalhou");
                Console.Write("Total das horas trabalhada: ");
                trabalhadaHora = double.Parse(Console.ReadLine());

                Console.WriteLine();

                pagamento = trabalhadaHora * valorHora;

                Console.WriteLine("O pagamento para funcionario " + nome + " deve ser de " + pagamento.ToString("F2", CI));

            }
        }
    }
}