﻿using System;

namespace tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0; i <= 10; i++){
                for(int j=1; j<=10;j++){
                    Console.WriteLine($"{j} * {i} = {j*i}");
                }
                Console.WriteLine();
            }
    
        }
    }
}
    

