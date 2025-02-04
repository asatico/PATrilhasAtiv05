using System;

namespace name
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("====Escolha uma opçao====");
			Console.WriteLine("1 - Opçao 1"); //Bem vindo 
			Console.WriteLine("2 - Opçao 2"); // ?? 
			Console.WriteLine("3 - Opçao 3"); // sair
			Console.WriteLine("=========================");
			
			string opcaoS = Console.ReadLine();
			int opcao;
			
			if (int.TryParse(opcaoS, out opcao )) {
				switch (opcao) {
					case 1 :
						Console.WriteLine("Bem vindo ao programa!. :)");
						break;
					case 2 : 
						Console.WriteLine("Ai ze da manga");
						break;
					case 3 :
						Console.WriteLine("Adeus!");
						break;
					default: 
						Console.WriteLine("Opçao inválida :( . Por Favor escole uma opçao entre 1 2 é 3");
						break;
				}					
			}else {
				Console.WriteLine("Porfavor insira um número.");
			
			}
			   Console.WriteLine("Presione algo para sair . . . ");
			   Console.ReadKey(true);
			}
		}
	}
