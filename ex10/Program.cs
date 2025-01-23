// Descrição: Crie um programa que gera a tabuada de um numero escolhido pelo usuario
//For

Console.WriteLine("Digite um número para ver a tabuada: ");
int numero = Convert.ToInt32(Console.ReadLine());

for (int contador = 1; contador <=10; contador++)
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
}