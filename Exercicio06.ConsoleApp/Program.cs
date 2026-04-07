/*
Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor
que C.
*/

Console.Clear();
Console.WriteLine("###################################");
Console.WriteLine("##     COMPARADOR DE NÚMEROS     ##");
Console.WriteLine("###################################");

Console.Write("=> Digite o valor de A: ");
double valorA = Convert.ToDouble(Console.ReadLine());

Console.Write("=> Digite o valor de B: ");
double valorB = Convert.ToDouble(Console.ReadLine());

Console.Write("=> Digite o valor de C: ");
double valorC = Convert.ToDouble(Console.ReadLine());

double somaAB = valorA + valorB;

if (somaAB == valorC)
{
    Console.WriteLine("\nA soma dos valores A e B, é igual ao valor de C");
    Console.ReadLine();
} else if (somaAB < valorC)
{
    Console.WriteLine("\nA soma dos valores A e B, é menor que o valor de C");
    Console.ReadLine();
} else
{
    Console.WriteLine("\n=> A soma dos valores A e B, é maior que o valor de C");
    Console.ReadLine();
}