using System;

class EntradaSaida
{
    static void Main()
    {
        Console.Write("Digite o seu nome: ");
        string nome = Console.ReadLine(); 
        Console.Write("Digite seu sobrenome: ");
        string sobrenome = Console.ReadLine();

        Console.Write("Digite a sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Digite sua altura (em metros): ");
        double altura = double.Parse(Console.ReadLine());

        bool eMaiorDeIdade = idade >= 18;
        bool eAlto = altura >= 1.80;

            

            if (eMaiorDeIdade)
            {
                Console.WriteLine($"Você é maior de idade, você tem {idade} anos.");
            }
            else
            {
                Console.WriteLine($"Você é menor de idade, você tem {idade} anos.");
            }

            if (eAlto)
            {
                Console.WriteLine($"Você é considerado alto, você tem {altura} metros de altura.");
            }
            else
            {
                Console.WriteLine($"Você é considerado baixo, você tem {altura} metros de altura.");
            }

            Console.WriteLine($"Olá, {nome} {sobrenome}, você tem {idade} anos e sua altura é {altura} metros.");
    }
}




    
