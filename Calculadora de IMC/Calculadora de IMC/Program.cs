using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double peso, altura, imc, altura2, imc2;


            Console.WriteLine("Qual o seu Peso? ");
            peso = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual o sua Altura? ");
            altura = float.Parse(Console.ReadLine());


            altura2 = altura * altura;
            imc = peso / altura2;
            imc2 = imc * 10000;

            Console.WriteLine("SEU IMC É " + imc2 );
            Console.WriteLine("SEU STATUS É");

            if (imc2 <= 18.5)
            {
                Console.WriteLine("MAGREZA");
            }
            else if (imc2 > 18.5 && imc2 <= 24.9)
            {
                Console.WriteLine("NORMAL");
            }
            else if (imc2 > 25 && imc2 <= 29.9)
            {
                Console.WriteLine("SOBREPESO  | ");
            }
            else if (imc2 > 30 && imc2 <= 39.9)
            {
                Console.WriteLine("OBESIDADE || ");
            }
            else 
            {
                Console.WriteLine("OBESIDADE GRAVE ||| ");
            }













            Console.ReadKey();
        }
    }
}
