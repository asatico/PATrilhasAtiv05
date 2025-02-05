using System;

namespace name
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num;
			int soma =0;
			
			do{
			Console.WriteLine("Escreva um número ");
			num = int.Parse(Console.ReadLine());
			if (num >= 0) {
				soma += num;
			}
			}while (num >= 0);
				
				Console.WriteLine("A soma dos números inseridos (Excluido os negativos) é: " + soma);
			
			
			   Console.WriteLine("Presione algo para sair . . . ");
			   Console.ReadKey(true);
			}
		}
	}
