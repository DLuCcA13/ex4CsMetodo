/* Crie um método chamado Multiplicar que receba dois inteiros como parâmetros e retorne o produto desses dois números. */
using System;

class Program
{
    static int Multiplicar(int a, int b)
    {
        return a * b;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro número: ");
        int n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        int n2 = int.Parse(Console.ReadLine());
        int resultado = Multiplicar(n1, n2);
        Console.WriteLine("O resultado da multiplicação foi de " + resultado);
    }
}