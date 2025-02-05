using System;

class Program
{
    static void Main()
    {
        int quantidadeNumeros;
        int soma = 0;
        int contador = 1;

        // Solicita ao usuário a quantidade de números a ser inserida
        Console.Write("Digite a quantidade de números a serem somados: ");
        quantidadeNumeros = int.Parse(Console.ReadLine());

        // Solicita ao usuário para inserir os números e soma cada um
        while (contador <= quantidadeNumeros)
        {
            Console.Write($"Digite o {contador}º número: ");
            int numero = int.Parse(Console.ReadLine());
            soma += numero;
            contador++;
        }

        // Exibe o resultado da soma
        Console.WriteLine($"A soma dos números inseridos é: {soma}");
        Console.WriteLine();
        Console.ReadKey(true);
    }
}
