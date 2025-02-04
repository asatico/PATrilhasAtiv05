using System;
using System.Security.Cryptography;

class Program
{
    static void Main()
    {
     Console.WriteLine("==== Escolha o tamanho da camisa =====");
     Console.WriteLine(" Camisa P");
     Console.WriteLine(" Camisa M");
     Console.WriteLine(" Camisa G");
     Console.WriteLine("=======================================");
    char tamanho = char.ToUpper(Convert.ToChar(Console.ReadLine()));
    
      switch (tamanho){
        case 'P':
          Console.WriteLine("O preço dessa camisa é R$ 50,00");
        break;
        case 'M':
          Console.WriteLine("O preço dessa camisa é R$ 30,00");
        break;
        case 'G':
          Console.WriteLine("O preço  dessa camisa é R$ 20,00");
        break;
        default:
          Console.WriteLine("VALOR INVALIDO. Digite o tamanho de acordo com P, M e G");
        break;
      }
   

    Console.WriteLine("Presione algo para sair . . . ");
		Console.ReadKey(true);
    }
}
