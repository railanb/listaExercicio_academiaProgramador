/*
    Escreva um algoritmo que leia um valor inicial A e imprima a sequência de valores do cálculo
    de A! e o seu resultado.
    a. Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
    b. Pesquise sobre “fatorial”
*/
Console.Clear();
Console.WriteLine("###################################");
Console.WriteLine("#            FATORIAL             #");
Console.WriteLine("###################################");

Console.Write("Digite um número inteiro: ");
int numeroDigitado = Convert.ToInt32(Console.ReadLine());

int numeroExib = numeroDigitado;
int fat = 1;
while (numeroDigitado > 1)
{
    // declarando variavel, para exibir em tela o fat anterior
    int fatAnt = fat;

    fat *= numeroDigitado;
    Console.WriteLine($"{fatAnt} x {numeroDigitado} = {fat}");
    numeroDigitado--;
}

Console.WriteLine($"=> O fatorial de {numeroExib} é {fat}");
Console.ReadLine();