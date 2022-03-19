using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Calculadora
{
    

    public static int  Soma(int x, int y)
    {
        return x + y;
    }
    public static int Subt(int x, int y)
    {
        return x - y;
    }
    public static int Mult(int x, int y)
    {
        return x * y;
    }
    public static int Divs(int x, int y)
    {
        if (y == 0)
        {
            Console.WriteLine("ERRO! Zero não é divisor.");
            return -1;
        }
        return x / y;
    }
    public static void EqGrauDois()
    {
        double delta, x1, x2;
        int a = Convert.ToInt32(Console.Read());
        int b = Convert.ToInt32(Console.Read());
        int c = Convert.ToInt32(Console.Read());



        delta = ((b * b) - 4 * a * c);
        x1 = (-b + Math.Sqrt(delta) / (2 * a));
        x2 = (-b + Math.Sqrt(delta) / (2 * a));
        Console.WriteLine($"x' = {x1}\n x'' = {x2}");
    }
    public static void Main()
    {

        Console.WriteLine("=======================");
        Console.WriteLine("======Calculadora======");
        Console.WriteLine("=======================");
        Console.WriteLine("\n[1] - SOMA");
        Console.WriteLine("[2] - SUBTRACAO");
        Console.WriteLine("[3] - DIVISAO");
        Console.WriteLine("[4] - MULTIPLICAÇÃO");
        Console.WriteLine("[5] - EQUAÇÃO GRAU 2");

        int opcao = Convert. ToInt32(Console.ReadLine());
        int numero1 = Convert.ToInt32(Console.ReadLine());
        int numero2 = Convert.ToInt32(Console.ReadLine());
        
        switch (opcao)
        {
            case 1: 
                Console.WriteLine($"===SOMA===\n {numero1}+{numero2} = {Soma(numero1, numero2)}");
                break;
            case 2:
                Console.WriteLine($"===SUBTRAÇÃO===\n {numero1}-{numero2} = {Subt(numero1, numero2)}");
                break;
            case 3:
                Console.WriteLine($"===DIVISÃO===\n {numero1}/{numero2} = {Divs(numero1, numero2)}");
                break;
            case 4:
                Console.WriteLine($"===MULTIPLICAÇÃO===\n {numero1}*{numero2} = {Mult(numero1, numero2)}");
                break;
            case 5:
                Console.WriteLine($"===EQUAÇÃO GRAU 2===\n");
                EqGrauDois();
                break;
        }
    }

}