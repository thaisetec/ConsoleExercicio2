using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe sua idade em anos:");
                int ano = int.Parse(Console.ReadLine());
            Console.WriteLine("informe sua idade em meses:");
                int meses = int.Parse(Console.ReadLine());
            Console.WriteLine("informe sua idade em dias:");
            int dias = int.Parse(Console.ReadLine());
            int total_dias= (ano * 365) + (meses * 30) + dias;
            Console.WriteLine("o total de dias vividos é" + total_dias);
            Console.ReadKey();


        }
    }
}
