using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using ExProjetoHotel.Models;

List<Pessoa> familia = new();


int opEscolha = 1;
Console.WriteLine("Bem Vindo a hospedaria Taverna! ");
Console.WriteLine("Informe seu nome completo:");
string? hospedePrincipal = Console.ReadLine();
Pessoa hospede1 = new(hospedePrincipal);
familia.Add(hospede1);


while (opEscolha == 1)
{
    Console.WriteLine("Deseja adicionar mais hóspedes? Digite: [1]");
    Console.WriteLine("Deseja proseguir? Digite: [2]");
    opEscolha = Convert.ToInt32(Console.ReadLine());
    if (opEscolha == 2)
    {
        break;
    }
    Console.WriteLine("Informe o nome completo do hóspede:");
    string? hospedeSecundario = Console.ReadLine();
    Pessoa hospede2 = new(hospedeSecundario);
    familia.Add(hospede2);
}


Console.WriteLine($"LISTA DE HÓSPEDES CADASTRADOS");

foreach (Pessoa hospede in familia)
{
    Console.WriteLine($"{hospede.Nome}");
}

Reserva reserva = new();

reserva.CadastrarHospedes(familia);

Console.WriteLine("SUÍTES DISPONÍVEiS:");
Console.WriteLine(
    "Opção: 1 \n"
        + "Tipo Suíte: Master \n"
        + "Capacidade de pessoas: 1\n"
        + "Valor da diária: 150,32"
);
Console.WriteLine(
    "Opção: 2 \n"
        + "Tipo Suíte: Medium \n"
        + "Capacidade de pessoas: 5\n"
        + "Valor da diária: 100,05"
);
Console.WriteLine(
    "Opção: 3 \n" + "Tipo Suíte: Join \n" + "Capacidade de pessoas: 10\n" + "Valor da diária: 60,77"
);

Suite suite1 = new()
{
    TipoSuite = "Master",
    Capacidade = 1,
    ValorDiaria = 150.32M
};

Suite suite2 = new()
{
    TipoSuite = "Medium",
    Capacidade = 5,
    ValorDiaria = 100.05M
};

Suite suite3 = new()
{
    TipoSuite = "Join",
    Capacidade = 10,
    ValorDiaria = 60.77M
};

Console.WriteLine("Informe a quantidade de dias a reservar: ");
int diasResvadosPeloCliente = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Por favor, escolha o número da sua suíte: ");
int? escolhaDoCliente = Convert.ToInt32(Console.ReadLine());

Suite suiteEscolhida = null;

if (escolhaDoCliente == 1)
{
    reserva.CadastrarSuite(suite1, familia.Count);
    suiteEscolhida = suite1;
}
else if (escolhaDoCliente == 2)
{
    reserva.CadastrarSuite(suite2, familia.Count);
    suiteEscolhida = suite2;
}
else
{
    reserva.CadastrarSuite(suite3, familia.Count);
    suiteEscolhida = suite3;
}



Console.WriteLine(
    $" Número de pessoas hospedadas: {reserva.ObterQuantidadeHospedes(familia.Count)}"
);


Console.WriteLine($"Valor total a pagar: {reserva.CalcularValorDiaria(suiteEscolhida, diasResvadosPeloCliente):F2}");



Console.ReadLine();

