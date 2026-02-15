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

Console.WriteLine("\nA sua média final é: " + $"{media:F2}");
#endregion

#region 2.  Conversor de Idade
Console.Write("Digite a sua idade: ");
int idadeUsuario = Convert.ToInt32(Console.ReadLine());

int diasIdade = idadeUsuario * 365;
Console.WriteLine("Os dias são: " + diasIdade);
#endregion

#region 3.Troca de Valores
Console.Write("Informe um valor A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Informe um valor B: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nValor Original do A: " + a + "\nValor Original do B: " + b);

int valor1 = a;
int valor2 = b;
a = valor2;
b = valor1;

Console.WriteLine("\nOs valores trocados são: \nA - " + a + "\nB - " + b);
#endregion

//Nível 2: Estruturas Condicionais (if, else if, else)
#region 1. Verificador de Maioridade
#endregion

#region 2. Classificador de Número
#endregion

#region 3. Validação de Login Simples
#endregion

////Nível 3: Estruturas de Repetição (Loops)
#region 1. Contagem Regressiva
#endregion

#region 2. Soma de Ímpares (Loop while)
#endregion

#region 3. Tabuada Personalizada
#endregion

//Nível 4: Coleções (Arrays e Listas)
#region 1. Inversão de Array
#endregion

#region 2. Busca e Contagem em Lista (foreach)
#endregion

#region 3. Gerenciador de Tarefas Simples (CRUD Básico em Memória)
#endregion