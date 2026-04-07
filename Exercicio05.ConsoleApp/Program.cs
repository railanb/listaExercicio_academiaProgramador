/*
    Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno
*/

bool repetirCalculo = true;

while (repetirCalculo == true)
{
    Console.Clear();
    Console.WriteLine("###################################");
    Console.WriteLine("# CALCULADORA DE MEDIA PONDERADA ##");
    Console.WriteLine("###################################");

    Console.Write("\n => Qual foi a NOTA da primeira prova: ");
    double primeiraNota = Convert.ToDouble(Console.ReadLine());

    Console.Write(" => Qual o peso da NOTA 1: ");
    double peso1 = Convert.ToDouble(Console.ReadLine());
    
    Console.Write(" => Qual foi a NOTA da primeira prova: ");
    double segundaNota = Convert.ToDouble(Console.ReadLine());
    
    Console.Write(" => Qual o peso da NOTA 2: ");
    double peso2 = Convert.ToDouble(Console.ReadLine());

    double mediaPonderada = (primeiraNota * peso1 + segundaNota * peso2) / (peso1 + peso2);

    Console.WriteLine($"A média ponderada dessas notas foi: {mediaPonderada:F2}");  
    Console.ReadLine();
    
    Console.Write("\nDeseja fazer um novo calculo? [s/N] => ");
    string decisao = Console.ReadLine();

    if (decisao != "s" && decisao != "S")
    {
        repetirCalculo = false;
        Console.WriteLine("Saindo da calculadora...");
        break;
    }

    
}
