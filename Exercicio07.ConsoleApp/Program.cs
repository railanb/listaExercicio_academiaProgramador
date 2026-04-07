/*

    O IMC – Índice de Massa Corporal é um critério da Organização Mundial de Saúde para dar
    uma indicação sobre a condição de peso de uma pessoa adulta. A fórmula é IMC = peso /
    (altura) 
    2. Elabore um algoritmo que leia o peso e a altura de um adulto e mostre sua condição
    de acordo com a listagem abaixo:
        a. IMC em adultos Condição
        b. Abaixo de 18,5 - Abaixo do peso
        d. Entre 18,5 e 25 - Peso normal
        e. Entre 25 e 30 -  Acima do peso
        g. Acima de 30 - beso

*/
Console.Clear();
Console.WriteLine("###################################");
Console.WriteLine("# IMC - ÍNDICE DE MASSA CORPORAL  #");
Console.WriteLine("###################################");

Console.Write("\n=> Qual o seu peso: ");
double peso = Convert.ToDouble(Console.ReadLine());

Console.Write("=> Qual a sua altura (cm): ");
double alturaM = Convert.ToDouble(Console.ReadLine());

double altura = alturaM / 100;
double imc = peso / (altura * altura);


if (imc < 18.5)
{
    Console.WriteLine($"Seu IMC é de {imc:F2}");
    Console.WriteLine("Você esta abaixo do peso!");
    Console.ReadLine();
} else if (imc >= 18.5 && imc < 25)
{
    Console.WriteLine($"Seu IMC é de {imc:F2}");
    Console.WriteLine("Você esta com o peso ideal!");
    Console.ReadLine();
} else if (imc >= 25 && imc < 30)
{
    Console.WriteLine($"Seu IMC é de {imc:F2}");
    Console.WriteLine("Você esta acima do peso!");
    Console.ReadLine();
} else
{
    Console.WriteLine($"Seu IMC é de {imc:F2}");
    Console.WriteLine("Você esta obeso!");
    Console.ReadLine();
}

Console.WriteLine("Saindo do sistema...");
Console.ReadLine();