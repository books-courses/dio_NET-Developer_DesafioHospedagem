// Projeto Hospedagem
// https://github.com/digitalinnovationone/trilha-net-explorando-desafio
// https://github.com/AndersonMazah/DIO.ProgramandoEmCSharp/tree/master/DesafioDeProjeto_HospedagemHotel

using System.Text;
using Desafio4.Models;
Console.OutputEncoding = Encoding.UTF8;


// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();
hospedes.Add(new Pessoa(nome: "Michel", "Metran"));
hospedes.Add(new Pessoa(nome: "Hóspede 2", "Sobrenome 1"));


// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 4, valorDiaria: 30);


// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);


// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
