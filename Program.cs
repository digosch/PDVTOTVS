using System;
using TPDV.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace PDV
{
    class Program
    {
        static void Main(string[] args)
        {
            Transacao T = new Transacao();
            T.ValorPagar = 0;
            T.ValorPago = 0;

            Console.WriteLine("Bem vindo a TOTVS PDV, Insira o Valor a Ser Pago");
            T.ValorPagar = Int32.Parse(Console.ReadLine());
            Console.ReadKey();

            Console.WriteLine("PASSO 2 > Insira o Valor que foi Pago : ");
            T.ValorPago = Int32.Parse(Console.ReadLine());
            Console.ReadKey();

            Console.WriteLine("Valor que Deve ser Pago > " + T.ValorPagar);
            Console.ReadKey();

            Console.WriteLine("Valor que Foi EFETIVAMENTE Pago > " + T.ValorPago);
            Console.ReadKey();

            int totaltroco = (T.ValorPago - T.ValorPagar);

            Console.WriteLine("TOTAL DO TROCO A SER ENTREGUE > " + totaltroco);
            Console.ReadKey();

            int ced = 100;

            int totced = 0;


            while (true)
            {
                if (totaltroco >= ced)
                {
                    totaltroco -= ced;
                    totced += 1;
                }
                else
                {
                    if (totced > 0)
                    {
                        Console.WriteLine(" Total de " + totced + " Cédulas de R$ " + ced);
                    }
                    if (ced == 100)
                    {
                        ced = 50;
                    }
                    else if (ced == 50)
                    {
                        ced = 20;
                    }
                    else if (ced == 20)
                    {
                        ced = 10;
                    }
                    else if (ced == 10)
                    {
                        ced = 1;
                    }
                    totced = 0;
                    if (totaltroco == 0)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(" = ");
            Console.ReadKey();
        }

       
    }
}
