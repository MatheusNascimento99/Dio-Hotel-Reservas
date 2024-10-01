using System;

namespace ExProjetoHotel.Models
{
    public class Reserva
    {
        public List<Pessoa>? Hospedes { get; set; }
        public Suite? ReservaSuite { get; set; }
        public int DiasReservados { get; set; }

        public void CadastrarHospedes(List<Pessoa> Hospedes) { }


        //TODO fazer lógica de nao deixar cadastrar suite com menor quantidade de hospedes
        public void CadastrarSuite(Suite ReservaSuite, int quantidade)
        {
            int numPessoa = ObterQuantidadeHospedes(quantidade);

            if (numPessoa > ReservaSuite.Capacidade)
            {
                Console.WriteLine(
                    $"Esta suite não acomoda {numPessoa}, favor escolher outra suíte."
                );
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine($"Reservado com sucesso a suíte tipo: {ReservaSuite.TipoSuite}, com diária no valor de: {ReservaSuite.ValorDiaria}");
            }
        }

        public int ObterQuantidadeHospedes(int quantidade)
        {
            int numeroDeHospedes = quantidade;
            return numeroDeHospedes;
        }

        public decimal CalcularValorDiaria(Suite suiteEscolhida, int diasResvadosPeloCliente)
        {
            if (diasResvadosPeloCliente > 10)
            {
                decimal valorCalcular = suiteEscolhida.ValorDiaria * diasResvadosPeloCliente;
                decimal descontoQuantidadePessoas = 0.10M;
                decimal valorTotalComDesconto = valorCalcular - (valorCalcular * descontoQuantidadePessoas);
                return valorTotalComDesconto;
            }
            else
            {

                decimal valorCalcular = suiteEscolhida.ValorDiaria * diasResvadosPeloCliente;
                return valorCalcular;
            }
        }
    }
}
