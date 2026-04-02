// Crie um programa para calcular o volume de uma caixa retangular
// COMPRIMENTO * LARGURA * ALTURA.

Console.Clear();

Console.WriteLine("-----------------------");
Console.WriteLine("Calculadora de volume");
Console.WriteLine("-----------------------");
Console.WriteLine("Digite valores em cm³");


Console.Write("\nDigite o comprimento: ");
double comprimento = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a Largura: ");
double altura =  Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a Altura: ");
double largura = Convert.ToDouble(Console.ReadLine());



double volume = comprimento * largura * altura;

Console.WriteLine($"O volume do seu retangulo: {volume:F2} cm³");
Console.ReadLine();
