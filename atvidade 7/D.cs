using System;

namespace name
{
	class Program
	{
		public static void Main(string[] args)
		{
			string senhaCoreta = "La ele";
			string senhaUsuario;
			int tentativas = 0;
			int Maxtentativas = 3;
			
			
			while (tentativas < Maxtentativas) {
				Console.WriteLine("Digite a senha: ");
				senhaUsuario = (Console.ReadLine());
				
				
				if (senhaUsuario.ToLower() == senhaCoreta.ToLower()) {
					Console.WriteLine("SENHA CORRETA :). Seja bem vido");
					Console.WriteLine("Presione alguma tecla do teclado . . .");
					Console.ReadKey();
					return;
					
				} else {
					tentativas++;
					Console.WriteLine("Senha incoreta");
				}
				
				if (tentativas == Maxtentativas) {
					Console.WriteLine("ACESSO NEGADO :(. Maximo de tentaivas alcansadas ");
				}
			}
			
			
			   Console.WriteLine("Presione algo para sair . . . ");
			   Console.ReadKey(true);
			}
		}
	}
