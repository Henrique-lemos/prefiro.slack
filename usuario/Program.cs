using System;

namespace usuario
{
    class Program
    {
        static void Main(string[] args)
        {
            string login,senha;

            Console.WriteLine("qual seu usuario?");
            login = (Console.ReadLine());
            Console.WriteLine("qual sua senha?");
            senha = (Console.ReadLine());

            if((login == "admin") && (senha == "admin")){
                Console.WriteLine("Seja bem vindo agora trabaia vagabundo");
            }
            else{
                Console.WriteLine("Seja bem vindo saiba td vai dar errado");
            }



            

            
        }
    }
}
