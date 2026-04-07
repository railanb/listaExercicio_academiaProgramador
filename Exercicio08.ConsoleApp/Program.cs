/*Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.*/
Console.Clear();
Console.WriteLine("###################################");
Console.WriteLine("#         É IMPAR OU PAR?         #");
Console.WriteLine("###################################");

Console.Write("Digite algum número inteiro: ");
int numeroDigitado = Convert.ToInt32(Console.ReadLine());

int numero = numeroDigitado % 2;

if (numero == 0)
{
    Console.WriteLine($"O Número digitado é PAR");
} else
{
    Console.WriteLine($"O Número digitado é IMPAR");
}

Console.ReadLine();