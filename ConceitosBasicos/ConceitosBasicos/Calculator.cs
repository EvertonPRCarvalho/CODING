public class Calculadora
{
    

    public static int  soma(int x, int y)
    {
        return x + y;
    }
    public static int subt(int x, int y)
    {
        return x - y;
    }
    public static int mult(int x, int y)
    {
        return x * y;
    }
    public static int divs(int x, int y)
    {
        if (y == 0)
        {
            Console.WriteLine("ERRO! Zero não é divisor.");
            return -1;
        }
        return x / y;
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

        int opcao = Convert. ToInt32(Console.ReadLine());
        int numero1 = Convert.ToInt32(Console.ReadLine());
        int numero2 = Convert.ToInt32(Console.ReadLine());
        
        switch (opcao)
        {
            case 1: 
                Console.WriteLine($"===SOMA===\n {numero1}+{numero2} = {soma(numero1, numero2)}");
                break;
            case 2:
                Console.WriteLine($"===SUBTRAÇÃO===\n {numero1}-{numero2} = {subt(numero1, numero2)}");
                break;
            case 3:
                Console.WriteLine($"===DIVISÃO===\n {numero1}/{numero2} = {divs(numero1, numero2)}");
                break;
            case 4:
                Console.WriteLine($"===MULTIPLICAÇÃO===\n {numero1}*{numero2} = {mult(numero1, numero2)}");
                break;
        }
    }

}