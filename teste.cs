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

        bool eMaiorDeIdade = idade >= 18;

            Console.WriteLine($"Olá, {nome} {sobrenome}!");

            if (eMaiorDeIdade)
            {
                Console.WriteLine($"Você é maior de idade, você tem {idade} anos.");
            }
            else
            {
                Console.WriteLine($"Você é menor de idade, você tem {idade} anos.");
            }
              
    }
}




    
