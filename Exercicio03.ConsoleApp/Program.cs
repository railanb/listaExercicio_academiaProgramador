// Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit

Console.Clear();

Console.WriteLine("--------------------------------------------------");
Console.WriteLine("Vamos converter as escalas Celsius para Fahrenheit");
Console.WriteLine("--------------------------------------------------");


Console.Write("\n=> Quantos graus °C esta agora: ");
double celsius = Convert.ToDouble(Console.ReadLine());

double fahrenheit = (celsius * 1.8) + 32;

Console.WriteLine($"\n=> Na escala Fahrenheit, agora está: {fahrenheit:F2} °F");
Console.ReadLine();