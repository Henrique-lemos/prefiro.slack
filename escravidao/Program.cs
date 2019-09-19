using System;

namespace escravidao
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario,aumento;
            

            Console.WriteLine("Qual seu salario: ");
            salario = double.Parse(Console.ReadLine());
            
            if (salario < 500){
                aumento = salario * 0.3;
                salario += aumento;
                Console.WriteLine("Parabens, ganhou uns troco para as dividas");
                Console.WriteLine("Seu novo salario é " + salario);
            }else {
                Console.WriteLine("Ih rapaz, nao vai dar nao");
            }

        }  
    }
}
