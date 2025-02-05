using System;
using System.Security.Cryptography;

class Program
{
    static void Main()
    {
     int num;
     do{
        Console.WriteLine("Digite um numero inteiro positivo: ");
        num = Convert.ToInt32(Console.ReadLine());
     } while (num < 0);
        Console.WriteLine("O números pares entre 0 e {0} sao: ", num);
        int i = 1;
        while (i <= num){
          if (i % 2 == 0 ){
            Console.Write(i + "\n" );
          }
          i++;
      }


    Console.WriteLine("Presione algo para sair . . . ");
		Console.ReadKey(true);
    }
}
