// Ex. 07 - Calcule a média de um aluno a partir de três notas fornecidas pelo usuário.

Console.WriteLine("Digite a 1° nota: ");
double nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a 2° nota: ");
double nota2 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a 3° nota: ");
double nota3 = double.Parse(Console.ReadLine());

double media = (nota1 + nota2 + nota2 + nota3)/3;

if (media >= 7 )
{
    Console.WriteLine($"sua media é: {media}. Aprovado!");
}
else if (media >= 4 )
{
    Console.WriteLine($"sua media é: {media}. Em recuperação!");
}
else
{
    Console.WriteLine($"sua media é: {media}. Reprovado!");
}
