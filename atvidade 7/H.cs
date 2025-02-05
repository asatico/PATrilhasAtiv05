using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número inteiro: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Tabuada do {0}:", numero);
        
        int i = 1;
        do
        {
            Console.WriteLine("{0} x {1} = {2}", numero, i, numero * i);
            i++;
        } while (i <= 10);
        
        Console.WriteLine("Presione algo para sair . . . ");
		    Console.ReadKey(true);
    }
}
