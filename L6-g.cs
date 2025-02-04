using System;

class Program
{
    static void Main()
    {
      Console.WriteLine("==== Escolha uma Cor =====");
      Console.WriteLine("1_ Vermelho");
      Console.WriteLine("2_ Azul");
      Console.WriteLine("3_ Verde");
      Console.WriteLine("======================== ");
      string opcaos = Console.ReadLine();
      int opcao;
      


     if(int.TryParse(opcaos, out opcao) ){ 
      switch (opcao){
        case 1 :
          Console.WriteLine("voce escolheu a cor Vermelho.");
          break;
        case 2 :
          Console.WriteLine("voce escolheu a cor Azul.");  
          break; 
        case 3:
          Console.WriteLine("Voce escolheu a cor Verde.");
          break;
        default:
          Console.WriteLine("Digite um número entre 1 2 ou 3");
          break;
      }
     }  
    Console.WriteLine("Presione algo para sair . . . ");
		Console.ReadKey(true);
    }
}
