/*
Desafio: Criar um programa que receba 6 nome utilizando arrays. Ao final o programa deve exibir todos os nome digitados
*/

string[] nomes = new string[6];
    for (int i = 0; i < nomes.Length; i++)
   { 

    Console.WriteLine($"Digite o nome {i + 1}: ");
        nomes[i] = Console.ReadLine();
    }

    Console.Clear();

   

    Console.WriteLine("======================");
    Console.WriteLine("===nomes digitados====");
    Console.WriteLine("======================");

    int index = 0;
    foreach (string nome in nomes)
    {
        Console.WriteLine($"Nome na posição {index}: {nome}");
        index++;
    }
