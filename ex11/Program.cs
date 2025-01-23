// Crie um programa que peça ao usuário para inserir um número inteiro positivo e então conte de 1 até esse número

Console.WriteLine(" Digite um número inteiro positivo: ");
int numero = Convert.ToInt32(Console.ReadLine());

//Contagem usando while
Console.WriteLine("Contagem usando while: ");
int i = 1;
    while (i <= numero)
{
    Console.WriteLine(i);
    i++;
}

//Contagem usando do while
Console.WriteLine( "Contagem usando do while: ");
do
{
    Console.WriteLine(i);
    i++;
} while ( i <= numero );


//Contagem usando for
Console.WriteLine("Contagem usando for: ");

for (int k = 1; k <= numero; k++)
{
    Console.Write ( k );
}


