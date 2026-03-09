# 🔐 Gerador de Senha em C#

Um gerador simples de senhas feito em **C#** que cria senhas aleatórias com letras, números e símbolos diretamente no terminal.

## 📌 Tecnologias usadas

- C#
- .NET
- Console Application

## 🚀 Como funciona

O programa:

1. Limpa o terminal
2. Pergunta ao usuário o tamanho da senha
3. Gera caracteres aleatórios
4. Mostra a senha gerada

Os caracteres possíveis incluem:

- Letras minúsculas
- Letras maiúsculas
- Números
- Símbolos

## 💻 Código

```csharp
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
```

## ▶️ Como executar

1. Instale o **.NET SDK**
2. Compile o projeto
3. Execute no terminal

Exemplo:

```
dotnet run
```

Depois informe o tamanho da senha desejada.

Exemplo de saída:

```
Qual tamanho de senha você quer?
12
Senha gerada: A7d!9Kp#2Lm$
```

## 📚 Objetivo do projeto

Este projeto foi criado para praticar:

- Estruturas de repetição (`for`)
- Geração de números aleatórios
- Manipulação de strings
- Entrada de dados no console

## 🧠 Melhorias futuras

Algumas melhorias possíveis:

- Escolher se quer usar números
- Escolher se quer usar símbolos
- Escolher se quer letras maiúsculas
- Copiar senha automaticamente
- Criar interface gráfica

---

💡 Projeto feito para praticar **lógica de programação em C#**.