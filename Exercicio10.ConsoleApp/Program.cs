/*
    Escreva um programa que imprima os números de 1 a 100 em ordem crescente, 
    substituindo os números múltiplos de 3 pela palavra "Fizz" 
    substituindo os números múltiplos de 5 pela palavra "Buzz". 
    Para números que são múltiplos de ambos, use "FizzBuzz".
*/

Console.Clear();
Console.WriteLine("###################################");
Console.WriteLine("#           FIZZ/BUZZ             #");
Console.WriteLine("###################################");

// laço para percorrer o numeo de 1 a 100
for (int i = 1; i <= 100; i++)
{
    // resto da divisão % 
    // basicamente se numero dividido por 3 ou 5, o resto da divisão for 0 então é multiplo
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}
Console.ReadLine();
