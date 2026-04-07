/*
    Crie um programa para calcular o salário total de um vendedor. 
    Deverá ser informado o salário base e o total de vendas. 
    A comissão é calculada com um percentual (informado pelo usuário) sobre o total de vendas.

*/
bool repetirCalculo = true;

while (repetirCalculo == true)
{
    Console.Clear();
    Console.WriteLine("###################################");
    Console.WriteLine("##    CALCULADORA DE COMISSÃO    ##");
    Console.WriteLine("###################################");
    
    Console.Write(" => Qual é o salario base: ");
    double salariobase = Convert.ToDouble(Console.ReadLine());

    Console.Write(" => Qual foi o valor total de vendas: ");
    double totalVendas = Convert.ToDouble(Console.ReadLine());

    Console.Write(" => Qual é o percentual de comissão: ");
    double porcentagemComissao = Convert.ToDouble(Console.ReadLine());

    double porcentagem = porcentagemComissao / 100;

    double salarioComissao = totalVendas * porcentagem;
    double salarioTotal = salarioComissao + salariobase;

    Console.WriteLine($"-- Seu vendedor teve uma comissão de R$ {salarioComissao:F2}");
    Console.WriteLine($"-- Tendo um salario total de R$ {salarioTotal:F2}");

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

Console.ReadLine();