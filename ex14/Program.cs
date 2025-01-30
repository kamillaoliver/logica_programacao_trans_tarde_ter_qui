﻿/*Objetivo: Criar um array que armazene 5 nomes de frutas e, em seguida, imprimir cada nome na tela.
 
Instruções:
- Crie um array de strings para armazenar os nomes das frutas.
- Preencha o array com 5 frutas diferentes.
- Use um loop para iterar sobre o array e imprimir cada fruta. */

string[] frutas = new string[5];

for(int i = 0;  i < frutas.Length; i++)
{
    Console.WriteLine($"Digite o nome da {i + 1}ª fruta: ");
    frutas[i] = Console.ReadLine();
}

Console.Clear();

//for (int i = 0; i < frutas.Length; i++)
//{
//   Console.WriteLine($"Fruta na posição {i}: {frutas[i]}");
//}

Console.WriteLine("=======================");
Console.WriteLine("===frutas digitadas====");
Console.WriteLine("=======================");

int index = 0;
foreach(string fruta in frutas)
{
    Console.WriteLine($"Fruta na posição {index}: {fruta}");
    index ++;
}