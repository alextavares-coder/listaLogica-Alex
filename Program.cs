// See https://aka.ms/new-console-template for more information

//Nível 1: Variáveis e Operações Básicas
#region 1. Calculadora de Média Simples

Console.Write("Digite a sua primeira nota: ");
double nota1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite a sua segunda nota: ");
double nota2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite a sua terceira nota: ");
double nota3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\nA sua primeira nota é: " + nota1 + "\nA sua segunda nota é: " + nota2 + "\nA sua terceira nota é: " + nota3);

double soma = nota1 + nota2 + nota3;
double media = soma / 3;

Console.WriteLine("\nA sua média final é: " + media);
#endregion