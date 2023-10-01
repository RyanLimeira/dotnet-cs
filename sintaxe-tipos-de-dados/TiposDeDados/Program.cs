using System.Security.Cryptography.X509Certificates;
using bootcamp_dotnet_cs.Models;

string opcao;
bool exibirMenu = true;

while(exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção: ");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;
        
        case "2":
            Console.WriteLine("Busca de cliente");
            break;

        case "3":
            Console.WriteLine("Apagar cliente");
            break;

        case "4":
            Console.WriteLine("Encerrar");
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}






























// int soma = 0, numero = 0;

// do
// {
//     Console.WriteLine("Digite um número (0 para parar): ");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// }while(numero != 0);

// Console.WriteLine($"Total da soma dos número digitados é: {soma}");



// int numero = 5;
// int contador = 0;

// while(contador <= 10)
// {
//     Console.WriteLine($"{contador} execução: {numero} x {contador} = {numero * contador}");
//     contador++;
// }



// int numero = 5;

// for(int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }



// Calculadora calc = new Calculadora();

// calc.Somar(5, 5);
// calc.Subtrair(10, 50);
// calc.Dividir(20, 20);
// calc.Multiplicar(10, 10);
// calc.Potencia(3, 3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
// calc.RaizQuadrada(9);


// int numero = 10;

// Console.WriteLine(numero);

// Console.WriteLine("Decrementando o 10");
// // numero = numero + 1;
// numero--;

// Console.WriteLine(numero);


// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual);

// string apresentacao = "Olá, seja bem vindo!";

// int quantidade = 1;
// quantidade = 10;

// double altura = 1.80;

// decimal preco = 1.80M;

// bool condicao = true;


// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Ryan";
// pessoa1.Idade = 21;
// pessoa1.Apresentar();