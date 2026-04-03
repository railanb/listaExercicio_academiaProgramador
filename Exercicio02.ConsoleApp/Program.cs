/* Crie um programa que calcule o consumo de combustível por quilômetro percorrido em uma
viagem.
    O programa deve solicitar ao usuário:
        a. A quilometragem inicial do veículo no início da viagem.
        b. A quilometragem final ao término da viagem.
        c. A quantidade de combustível consumida durante a viagem (em litros).
*/

Console.Clear();

Console.WriteLine("---------------------------------");
Console.WriteLine("Vamos calcular o seu consumo");
Console.WriteLine("---------------------------------");


Console.Write("\n=> Por favor digite a quilometragem no inicio da viagem: ");
double kmInical = Convert.ToDouble(Console.ReadLine());

Console.Write("=> Por favor digite a quilometragem no final da viagem: ");
double kmFinal = Convert.ToDouble(Console.ReadLine());

Console.Write("=> Por favor digite quantos litros foram consumidos na viagem: ");
double combustivel = Convert.ToDouble(Console.ReadLine());

double distancia = (kmFinal - kmInical) / combustivel;

Console.WriteLine($"\nSeu carro consumiu {distancia:F2} km/l.");
Console.ReadLine();