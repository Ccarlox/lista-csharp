//SINTAXE BASICA

// exercicio 1

//Crie um programa que:
//a. exiba seu nome
//b. exiba sua idade

using System.Net.Http.Headers;

Console.WriteLine("Digite seu nome:");

string nome = Console.ReadLine();
Console.WriteLine("Seu nome é: " + nome);


//exercicio 2
//crie um programa que:
//a. leia um número inteiro
//b. exiba o dobro desse número

Console.WriteLine("Digite um numero inteiro: ");

int num0 = int.Parse(Console.ReadLine());
Console.WriteLine("Esse e o dobro de seu numero  " + (num0 * 2));

//ex3
//Faça um programa que:
//a. leia dois números
//b. calcule e exiba:
//c. soma
//d. subtração
//e. multiplicação
//f. Divisão

Console.WriteLine("Digite dois numeros:(um por vez)");
int num = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Essa e a soma do seu numero: " + (num + num2));
Console.WriteLine("Essa e a subtracao do seu numero: " + (num - num2));
Console.WriteLine("Essa e a multiplicacao do seu numero: " + (num * num2));
Console.WriteLine("Essa e a divisao do seu numero: " + (num / num2));

//ex4
//Crie um programa que:
//a. leia a idade de uma pessoa
//b. informe se ela é maior ou menor de idade

Console.WriteLine("Informe sua idade: ");
int idade = int.Parse(Console.ReadLine());

if(idade >= 18)
{
    Console.WriteLine("Voce e maior de idade!");
}
else
{
    Console.WriteLine("Voce e menor de idade");
}

//ESTRUTURAS DE DECISAO E REPETICAO
//ex5
//5. Leia um número e informe:
//a. positivo
//b. negativo
//c. Zero

Console.WriteLine("Informe um numero: ");
int num3 = int.Parse(Console.ReadLine());

if(num3 > 0)
{
    Console.WriteLine("Esse numero e positivo!");
}
else if(num3 < 0)
{
    Console.WriteLine("Esse numero e negativo!");
}
else
{
    Console.WriteLine("Este numero e 0!");

}
//ex6
//Leia um número e exiba a tabuada de 1 a 10
Console.WriteLine("Informe um numero para mostrarmos a tabuada");
int num4 = int.Parse(Console.ReadLine());

for(int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{num4} x {i} = {num4 * i}");
}

//ex7
//Leia 5 números e exiba:
//a. a soma total
//b. a média

Console.WriteLine("Digite 5 numeros um de cada vez: ");

double soma = 0;

for(int i = 1; i <=5; i++)
{
    int numerolido = int.Parse(Console.ReadLine());
    soma = soma + numerolido;
}
double media = soma / 5;

Console.WriteLine("A soma dos seus numeros: " + soma);
Console.WriteLine("Essa e a media: " + media);


//ex8
//Crie um programa que:
//a. leia vários números até o usuário digitar 0
//b. mostre a soma dos números

Console.WriteLine("Digite numeros(digite zero para parar e mostrar a soma do seus numeros): ");

int num10 = -1;
double som = 0;

while(num10 != 0){
    num10 = int.Parse(Console.ReadLine());
    som = som + num10;
}
Console.WriteLine("ESSA E A SOMA: " + som);

//METODOS

// ex 9
Console.WriteLine("Digite o primeiro numero: ");
int numMetodo = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo numero: ");
int numMetodo1 = int.Parse(Console.ReadLine());

int resultado = Soma(numMetodo, numMetodo1);
Console.WriteLine("O resultado: " + resultado);

// ex 10
Console.WriteLine("O numero 10 e par? " + EhPar(10));

// ex 11
Console.WriteLine("O maior entre 50 e 20 e: " + Maior(50, 20));

// ex 12
Console.WriteLine("A media de 7, 8 e 9 e: " + Media(7, 8, 9));

// ex 9
static int Soma(int a, int b)
{
    return a + b;
}

// ex 10
static bool EhPar(int n)
{
    return n % 2 == 0;
}

// ex11
static int Maior(int a, int b)
{
    if (a > b) return a;
    else return b;
}

// ex12
static double Media(double a, double b, double c)
{
    return (a + b + c) / 3;
}

//CLASSES E OBJETOS

//ex13 ex14
Console.WriteLine("\n--- Cadastro de Carro ---");
Carro meuCarro = new Carro();

Console.WriteLine("Digite a marca:");
meuCarro.Marca = Console.ReadLine();

Console.WriteLine("Digite o modelo:");
meuCarro.Modelo = Console.ReadLine();

Console.WriteLine("Digite o ano:");
meuCarro.Ano = int.Parse(Console.ReadLine());

Console.WriteLine("\nDados do Carro:");
meuCarro.ExibirDados();

//ex 15 16 17
Console.WriteLine("\n--- Cadastro de Funcionario ---");
Funcionario func = new Funcionario();

Console.WriteLine("Nome:");
func.Nome = Console.ReadLine();

Console.WriteLine("Salario mensal:");
func.Salario = double.Parse(Console.ReadLine());

Console.WriteLine("Cargo:");
func.Cargo = Console.ReadLine();

Console.WriteLine("\nDados Iniciais:");
func.ExibirDados();
Console.WriteLine($"Salario Anual: R$ {func.CalcularSalarioAnual():F2}");

Console.WriteLine("\nDigite o percentual de aumento:");
double perc = double.Parse(Console.ReadLine());
func.AumentarSalario(perc);

Console.WriteLine("Digite um valor para descontar:");
double desc = double.Parse(Console.ReadLine());
func.DescontarSalario(desc);

Console.WriteLine("\nDados Atualizados:");
func.ExibirDados();

//EXERCICIOS DE ARRAYS

// ex 18
Console.WriteLine("\n Exercicio 18: Vetor de 5 posicoes ");
int[] vetor = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Digite o valor para a posicao {i}:");
    vetor[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Valores digitados:");
foreach (int valor in vetor)
{
    Console.Write(valor + " ");
}
Console.WriteLine();

// ex 19
Console.WriteLine("\nExercicio 19: Maior valor no vetor ");
int maiorValor = vetor[0];
for (int i = 1; i < 5; i++)
{
    if (vetor[i] > maiorValor)
    {
        maiorValor = vetor[i];
    }
}
Console.WriteLine("O maior valor: " + maiorValor);

// ex 20 e 21
Console.WriteLine("\n Exercicio 20 e 21: Media ");
double somaParaMedia = 0;
for (int i = 0; i < 5; i++)
{
    somaParaMedia += vetor[i];
}
double resultadoMedia = somaParaMedia / 5;
Console.WriteLine("A media dos valores e: " + resultadoMedia);

// --- EXERCICIOS 22, 23 e 24 ---
Console.WriteLine("\n Cadastro de Frota (3 Carros) ");
Carro[] frota = new Carro[3];

for (int i = 0; i < frota.Length; i++)
{
    frota[i] = new Carro();
    
    Console.WriteLine($"\nCarro {i + 1}:");
    Console.Write("Marca: ");
    frota[i].Marca = Console.ReadLine();
    
    Console.Write("Modelo: ");
    frota[i].Modelo = Console.ReadLine();
    
    Console.Write("Ano: ");
    frota[i].Ano = int.Parse(Console.ReadLine());
}

// 23. Exibir todos
Console.WriteLine("\n Lista de Carros ");
double somaAnos = 0;
foreach (var c in frota)
{
    c.ExibirDados();
    somaAnos += c.Ano;
}

// 24. Média dos anos
double mediaAnos = somaAnos / frota.Length;
Console.WriteLine($"\nA média de ano da frota é: {mediaAnos:F0}");

// --- EXERCICIO 25 (DESAFIO: LISTA DINÂMICA) ---
Console.WriteLine("\n Gerenciar Lista ");
List<Carro> listaDinamica = new List<Carro>(frota);

Console.WriteLine("Escolha uma opção: 1-Adicionar | 2-Remover | 3-Sair");
string opcao = Console.ReadLine();

if (opcao == "1")
{
    Carro novo = new Carro();
    Console.Write("Nova Marca: "); novo.Marca = Console.ReadLine();
    Console.Write("Novo Modelo: "); novo.Modelo = Console.ReadLine();
    Console.Write("Novo Ano: "); novo.Ano = int.Parse(Console.ReadLine());
    listaDinamica.Add(novo);
    Console.WriteLine("Carro adicionado com sucesso!");
}
else if (opcao == "2")
{
    Console.WriteLine("Digite o índice (0, 1, 2...) para remover:");
    int idx = int.Parse(Console.ReadLine());
    if (idx >= 0 && idx < listaDinamica.Count) {
        listaDinamica.RemoveAt(idx);
        Console.WriteLine("Carro removido!");
    }
}

Console.WriteLine($"Total de carros agora: {listaDinamica.Count}");


//CLASSES E OBJETOS//
//ex 13 e 14
class Carro
{
    public string Marca;
    public string Modelo;
    public int Ano;

    public void ExibirDados()
    {
        Console.WriteLine($"Marca: {Marca} | Modelo: {Modelo} | Ano: {Ano}");
    }
}

//ex 15 16 17
class Funcionario
{
    public string none;
    public double Salario;
    public string Cargo;

    public void ExibirDados()
    {
        Console.WriteLine($"Nome: {none} | Cargo: {Cargo} | Salario: R$ {Salario:F2}");
    }

    public double CalcularSalarioAnual()
    {
        return Salario * 12;
    }

    public void AumentarSalario(double percentual)
    {
        Salario += Salario * (percentual / 100);
    }

    public void DescontarSalario(double valor)
    {
        Salario -= valor;
    }
}


