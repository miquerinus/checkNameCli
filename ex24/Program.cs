/*
Algoritmo abaixo tem a finadalide de comparar o conteúdo de 2 variaveis se são iguais ou não. Caso o conteudo for igual o retorno sera TRUE, caso os valores forem diferentes
o retorno sera FALSE. */
using System;

namespace Names 
{

    public class checkNames()
    {
        public static bool verificar(string n1, string n2)
        {
            return n1 == n2;
        }
    }
}

class Program
{
   static void Main(string[] args)
   {
     Console.WriteLine("insira alguma frase: ");
     string input1 = Console.ReadLine();

     Console.WriteLine();

     Console.WriteLine("insira uma nova frase: ");
     string input2 = Console.ReadLine();

     bool result = Names.checkNames.verificar(input1, input2);

     Console.WriteLine($"-> As letras informadas são iguais: {result} "); 
   }
}