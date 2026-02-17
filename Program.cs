// See https://aka.ms/new-console-template for more information

////Nível 1: Variáveis e Operações Básicas
//#region 1. Calculadora de Média Simples

//Console.Write("Digite a sua primeira nota: ");
//double nota1 = Convert.ToDouble(Console.ReadLine());
//Console.Write("Digite a sua segunda nota: ");
//double nota2 = Convert.ToDouble(Console.ReadLine());
//Console.Write("Digite a sua terceira nota: ");
//double nota3 = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("\nA sua primeira nota é: " + nota1 + "\nA sua segunda nota é: " + nota2 + "\nA sua terceira nota é: " + nota3);

//double soma = nota1 + nota2 + nota3;
//double media = soma / 3;

//Console.WriteLine("\nA sua média final é: " + $"{media:F2}");
//#endregion

//#region 2.  Conversor de Idade
//Console.Write("Digite a sua idade: ");
//int idadeUsuario = Convert.ToInt32(Console.ReadLine());

//int diasIdade = idadeUsuario * 365;
//Console.WriteLine("Os dias são: " + diasIdade);
//#endregion

//#region 3.Troca de Valores
//Console.Write("Informe um valor A: ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.Write("Informe um valor B: ");
//int b = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("\nValor Original do A: " + a + "\nValor Original do B: " + b);

//int valor1 = a;
//int valor2 = b;
//a = valor2;
//b = valor1;

//Console.WriteLine("\nOs valores trocados são: \nA - " + a + "\nB - " + b);
//#endregion

////Nível 2: Estruturas Condicionais (if, else if, else)
//#region 1. Verificador de Maioridade
//Console.Write("Digite a sua idade: ");
//int idade = Convert.ToInt32(Console.ReadLine());

//if (idade >= 18)
//{
//    Console.WriteLine("Entrada autorizada.");
//}
//else {
//    Console.WriteLine("Entrada não autorizada. Menor de idade.");
//}
//#endregion

//#region 2. Classificador de Número
//Console.Write("Digite um número: ");
//int numero = Convert.ToInt32(Console.ReadLine());

//if (numero == 0) {
//    Console.WriteLine("\nZero.");
//}
//else if (numero > 0 && numero % 2 == 0) {
//    Console.WriteLine("\nPar e positivo.");
//}
//else if (numero > 0 && numero % 2 != 0) {
//    Console.WriteLine("\nÍmpar e positivo.");
//}
//else {
//    Console.WriteLine("\nNegativo.");
//}
//#endregion

//#region 3. Validação de Login Simples
//string usuarioCorreto = "admin";
//int senhaCorreta = 12345;

//Console.Write("Digite o nome do seu Usuário: ");
//string usuario = Console.ReadLine();

//Console.Write("Digite a sua senha: ");
//int senha = Convert.ToInt32(Console.ReadLine());

//if (usuario == usuarioCorreto && senha == senhaCorreta) {
//    Console.WriteLine("\nLogin efetuado com sucesso!");
//}
//else {
//    Console.WriteLine("\nUsuário ou senha inválidos.");
//}
//#endregion

////Nível 3: Estruturas de Repetição (Loops)
//#region 1. Contagem Regressiva
//Console.WriteLine("Aperte Enter para iniciar a contagem regressiva.");
//Console.Read();

//for (int i = 10; i >= 1; i--) {
//    Console.WriteLine(i);
//    Thread.Sleep(3000);
//}

//Console.WriteLine("\nLançar!");
//#endregion

//#region 2. Soma de Ímpares (Loop while)
//int somaNumero = 0;
//int numeroInteiro = -1;

//while (numeroInteiro != 0)
//{
//    Console.Write("Digite um número inteiro (0 para sair): ");
//    numeroInteiro = Convert.ToInt32(Console.ReadLine());
//    if (numeroInteiro == 0)
//    {
//        Console.WriteLine("\nSaindo...");
//    }
//    else if (numeroInteiro % 2 != 0)
//    {
//        somaNumero = somaNumero + numeroInteiro;
//        Console.WriteLine("\nEste número é ímpar.\n");
//    }
//    else
//    {
//        Console.WriteLine("\nEste número não é ímpar.\n");
//    }
//}

//Console.WriteLine("\nA soma total dos ímpares é: " + somaNumero);
//#endregion

#region 3. Tabuada Personalizada
Console.Write("Digite um número da tabuada: ");
int tabuadaNumero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nTabuada de Multiplicação.\n");
Console.WriteLine($"\nTabuada do {tabuadaNumero}:\n");

for (int i = 1; i <= 10; i++) {
    int multTabuada = tabuadaNumero * i;
    Console.WriteLine($"{tabuadaNumero} X {i} = {multTabuada}");
}
#endregion

//Nível 4: Coleções (Arrays e Listas)
#region 1. Inversão de Array
#endregion

#region 2. Busca e Contagem em Lista (foreach)
#endregion

#region 3. Gerenciador de Tarefas Simples (CRUD Básico em Memória)
#endregion