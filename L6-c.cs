using System;

namespace name
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite a primeira data (Formato: dd/MM/yyyy ): ");
			string data1s = Console.ReadLine();
			DateTime data1 = DateTime.ParseExact(data1s, "dd/MM/yyyy", null);
			
			Console.WriteLine("Digite a primeira data (Formato: dd/MM/yyyy ): ");
			string data2s = Console.ReadLine();
			DateTime data2 = DateTime.ParseExact(data2s, "dd/MM/yyyy", null);
			
			
			TimeSpan diferenca = data1 - data2; 
			
			Console.WriteLine("A diferença é de " +diferenca.Days );
			
		
			   Console.WriteLine("Presione algo para sair . . . ");
			   Console.ReadKey(true);
			}
		}
	}
