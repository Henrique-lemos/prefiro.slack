﻿using System;

namespace penacova
{
    class Program
    {
        static void Main(string[] args)
        {
            int anoatual = 2019;
            int anonasc = 0;
            int idade;

            Console.WriteLine("Qual o ano de nascimento");
            anonasc = int.Parse(Console.ReadLine());
            idade = anoatual - anonasc;

            Console.WriteLine("Sua idade atual é de" + idade + "anos");

            if(idade <= 2) {
                Console.WriteLine("Você é um recém nascido");
            }else if((idade >=3) && (idade <= 11)){
                Console.WriteLine("Voce é uma criança");
            }else if ((idade >= 12) && (idade <= 19)){
                Console.WriteLine("Voce e um adolescente");
            }else if((idade >=20) && (idade <=65)){
                Console.WriteLine("voce e um adulto");
            }else if(idade >65){
                Console.WriteLine("voce e um idoso");
            }


        }
    }
}
