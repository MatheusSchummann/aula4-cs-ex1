﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula4_cs_ex1
{
    
    /*Escreva um programa em C#, seguindo as orientações do início deste documento. O
    seu programa deve receber 3 valores v1, v2 e v3 (inteiros), e retorná-los em
    ordem crescente*/
    
    public class Program
    {
        static void Main(string[] args)
        {
            Program start = new Program(); 
        }
        public Program()
        {
            Convert Converter = new Convert();

            List<string> listaS = new List<string>();
            List<int> listaA = new List<int>();

            for(int i = 0; i < 3; i++) 
            {
                Console.Write("Digite o valor {0}/3: ", i+1);
                listaS.Add(Console.ReadLine());
            }
            listaA = Converter.conversor(listaS);
            Converter.logica(listaA);

            Console.WriteLine("Os valores após o sort foram:");
            for (int i = 0; i < 3; i++)         
            {
                Console.WriteLine("{0}",listaA[i]);
            }
            Console.ReadKey();
        }
    }
}
