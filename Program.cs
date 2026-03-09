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
			int senha = int.Parse(Console.ReadLine());
		}
	}
}