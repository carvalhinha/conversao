using System;
using System.Globalization;

namespace uri1021
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal real, dolar, euro, cotacao;
            int n, c = 0;


            do
            {
                Console.WriteLine("digite a cotação da moeda que deseja converter ");
                cotacao = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("dolar para real digite 1 \n" + "real para dolar digite 2 \n" + "euro para dolar digite 3 \n" + "dolar para euro digite 4 \n" + "euro para real digite 5 \n" + "real para euro digite 6");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.WriteLine("digite  quantos dolares ");
                        dolar = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        real = dolar * cotacao;
                        Console.WriteLine("valor em real R$ " + real.ToString("f2", CultureInfo.InvariantCulture));
                        break;

                    case 2:
                        Console.WriteLine("digite quantos reais ");
                        real = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        dolar = real * cotacao / real;
                        Console.WriteLine("valor em dolar $ " + dolar.ToString("f2", CultureInfo.InvariantCulture));
                        break;
                    case 3:
                        Console.WriteLine("digite quantos euros ");
                        euro = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        dolar = euro * cotacao;
                        Console.WriteLine("valor em dolar $ " + dolar.ToString("f2", CultureInfo.InvariantCulture));
                        break;
                    case 4:
                        Console.WriteLine("digite  quantos dolares ");
                        dolar = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        euro = dolar * cotacao / dolar;
                        Console.WriteLine("valor em euro € " + euro.ToString("f2", CultureInfo.InvariantCulture));
                        break;
                    case 5:
                        Console.WriteLine("digite  quantos euro ");
                        euro = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        real = euro * cotacao;
                        Console.WriteLine("valor em real R$ " + real.ToString("f2", CultureInfo.InvariantCulture));
                        break;

                    case 6:
                        Console.WriteLine("digite quantos reais ");
                        real = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        euro = real * cotacao / real;
                        Console.WriteLine("valor em euro € " + euro.ToString("f2", CultureInfo.InvariantCulture));
                        break;
                }
            } while (c < 10);
        }
    }
}