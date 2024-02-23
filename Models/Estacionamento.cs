using System;
using System.Collections.Generic;

namespace Parking.Models
{
    public class Veiculo 
    {
        public string Placa { get; set; }

        public Veiculo(string placa)
        {
            Placa = placa;
        }
    }

    public class Estacionamento
    {
        public int ValorInicial { get; set; }
        public int valorHora = 2;

        List<Veiculo> ListaVeiculos = new List<Veiculo>();

        public void AdicionarVeiculo() 
        {
            string placaVeiculo;
            int valorInicio;

            Console.WriteLine("Insira a placa do veículo: ");
            placaVeiculo = Console.ReadLine();

            Console.WriteLine("Insira o valor inicial: ");
            valorInicio = Convert.ToInt32(Console.ReadLine());

            this.ValorInicial = valorInicio;

            Veiculo novoVeiculo = new Veiculo(placaVeiculo);
            ListaVeiculos.Add(novoVeiculo);

            Console.WriteLine($"Veículo {placaVeiculo} estacionado com sucesso! Pressione uma tecla para continuar...");
            Console.ReadKey();

        }

        public void RemoverVeiculo () 
        {
            string placaRemover;
            int HorasEstacionado;

            Console.WriteLine("Digite a placa do veículo a ser removido: ");
            placaRemover = Console.ReadLine();

            Console.WriteLine("Digite a quantidade de horas estacionado: ");
            HorasEstacionado = Convert.ToInt32(Console.ReadLine());

            int valorFinal = (this.valorHora * HorasEstacionado) + this.ValorInicial;

            for (int i = ListaVeiculos.Count - 1; i >= 0; i--)
            {
                if (ListaVeiculos[i].Placa == placaRemover)
                {
                    ListaVeiculos.RemoveAt(i);
                    Console.WriteLine($"Veículo removido {placaRemover} com sucesso! O valor final ficou {valorFinal}" );
                    return; 
                }
            }
            Console.WriteLine("Placa não encontrada");

            Console.WriteLine("Pressione uma tecla para continuar...");
            Console.ReadKey();
        }
        public void MostrarVeiculos() 
        {
            Console.WriteLine($"Os véiculos estacionados são:");

            if(ListaVeiculos.Count > 0)
            {
            foreach (var veiculo in ListaVeiculos)
            {
                Console.WriteLine(veiculo.Placa);
            }

            }else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }

            Console.WriteLine("Pressione uma tecla para continuar...");
            Console.ReadKey();
       }
    }
}
