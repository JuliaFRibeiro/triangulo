using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {

            //declaração de variavel da classe triângulo
            Triangulo x;
            Triangulo y;

            //isntanciar a variavel
            x = new Triangulo();
            y = new Triangulo();

            //info para o meu usuario
            Console.WriteLine("Entre com as medidas do triâgulo X:");
          
            //dados imputados do meu usuario para as variaveis do obj classe triângulo
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com as medidas do triâgulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //formula do calculo da area do triangulo
            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));
            double i = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(i * (i - y.A) * (i - y.B) * (i - y.C));

            //impressado do resultado
            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            //comparando tamanho
            if (areaX > areaY)
            {
                Console.WriteLine("A áera do trinângulo X é maior");
            }
            else
            {
                Console.WriteLine("A áera do trinângulo Y é maior");
            }
            Console.ReadKey();
        }
    }
}
