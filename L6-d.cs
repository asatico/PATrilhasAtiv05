using System;
using System.Collections.Generic;

namespace name
{
	class Program
	{
		public static void Main(string[] args)
		{
			 
			var feriados = new List<DateTime>{
				new DateTime(DateTime.Now.Year, 1, 1),  // Ano Novo
				new DateTime(DateTime.Now.Year, 4, 21), //Tiradentes
				new DateTime(DateTime.Now.Year, 9 ,7),  //Independência do Brasil
				new DateTime(DateTime.Now.Year, 10,12),	// Nossa Senhora Aparecida 
				new DateTime(DateTime.Now.Year, 11,15),	// Plocamaçao da Replubilica 
				new DateTime(DateTime.Now.Year, 12,25), // Natal
			};
			Console.WriteLine("Digite a data (formato:  dd/MM/yyyy): ");
			string datas = Console.ReadLine();
			DateTime data = DateTime.ParseExact(datas, "dd/MM/yyyy", null);
			
			
			if (feriados.Contains(data)) {
				Console.WriteLine("A data informada é um feriado nacional fixo!");
			} else {
				Console.WriteLine("A data informada não e um feriado nacional fixo!");
			}
		
			   Console.WriteLine("Presione algo para sair . . . ");
			   Console.ReadKey(true);
			}
		}
	}
