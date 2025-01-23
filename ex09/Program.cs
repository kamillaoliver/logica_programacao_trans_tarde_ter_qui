// Crie um programa que gera a tabuada de um numero escolhido pelo usuário.
// Do While

Console.WriteLine("digite um numero para ver a tabuada");
int numero = Convert.ToInt32(Console.ReadLine());
int contador = 1;

do
{

    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
    contador++;
}
while (contador <= 10);
