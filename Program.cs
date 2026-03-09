using System;

namespace Gerador
{
	class Program
	{
		static void Main()
		{
			Console.Clear();

			string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%&*";
			Random random = new Random();

			Console.WriteLine("Qual tamanho de senha você quer?");
			int tamanho = int.Parse(Console.ReadLine());

			string senha = "";

			for(var i = 0; i < tamanho; i++)
			{
				var indice = random.Next(caracteres.Length);
				senha += caracteres[indice];
			}
			Console.WriteLine("Senha gerada: " + senha);
		}
	}
}