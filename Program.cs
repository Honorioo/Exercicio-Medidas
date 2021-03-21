using System;

namespace Exercicio_Medidas
{
    class Program
    {
        static void Main(string[] args)
        {
            double metros, cm = 100 , resultadoCm, km = 1000, ResultadoKm;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("-------Transformação de Metros para Cm e Km-------");
            Console.WriteLine();
            Console.Write("Digite um valor em Metros: ");
            
                metros = Convert.ToDouble(Console.ReadLine());
                Console.ResetColor();
                Console.WriteLine();
            resultadoCm = metros*cm;
            ResultadoKm = metros/km;
            
                    
            Console.ForegroundColor = ConsoleColor.Green;
                     Console.WriteLine($"{resultadoCm} Cm");
                     Console.WriteLine($"{ResultadoKm} Km");
             Console.ResetColor();



        }
    }
}
