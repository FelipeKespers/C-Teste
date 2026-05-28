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
        
        Console.WriteLine($"Olá, {nome} {sobrenome}! Você tem {idade} anos.");
    }
}
