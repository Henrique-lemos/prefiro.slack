using System;

namespace geometria
{
    class Program
    {
        static void Main(string[] args)
        {
            string forma = "";
            
            Console.WriteLine("Calcula Area");
            Console.WriteLine("1 - Circulo");
            Console.WriteLine("2 - quadrado");
            Console.WriteLine("3 - retangulo");
            Console.WriteLine("4 - triangulo");
            Console.WriteLine("5 - losango");
            Console.WriteLine("6 - trapezio");
            Console.WriteLine("Selecione uma forma");
            forma = Console.ReadLine();

            switch(forma){
               
                case "1":
                Console.Write("qual o raio da circunferencia");
                double r = double.Parse(Console.ReadLine());
                double area = 3.14 * r * r;
                Console.WriteLine("A area da circunferencia e" + area);
                break;
                 case "2":
                Console.Write("qual a area do quadrado");
                double r = double.Parse(Console.ReadLine());
                double area = 3.14 * r * r;
                Console.WriteLine("A area da circunferencia e" + area);
                break;
            }


           

        }
    }
}
