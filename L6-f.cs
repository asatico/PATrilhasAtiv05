using System;

class Program
{
    static void Main()
    {
      Console.WriteLine("Digite um número: ");
      int numero = int.Parse(Console.ReadLine());

      switch (numero){
        case > 0 :
          Console.WriteLine("O número e positivo.");
          break;
        case < 0 :
          Console.WriteLine("O número e negativo.");  
          break; 
        default:
          Console.WriteLine("O número e zero");
          break;
      }
    Console.WriteLine("Presione algo para sair . . . ");
		Console.ReadKey(true);
    }
}
