using Parking.Models;

Estacionamento estacionamento = new Estacionamento();

 string opcao;
 while (true)
 {

   Console.WriteLine("Bem vindo ao Parking Show! Selecione a opção desejada: ");
   Console.WriteLine("1 - Estacionar Veículo");
   Console.WriteLine("2 - Listar Veículos");
   Console.WriteLine("3 - Remover veículos");
   Console.WriteLine("4 - Encerrar");

   opcao = Console.ReadLine();

   switch (opcao)
   {
     case "1": 
       estacionamento.AdicionarVeiculo();
       break;
     case "2": 
       estacionamento.MostrarVeiculos();
       break;
     case "3": 
       estacionamento.RemoverVeiculo();
       break;
     case "4": 
       Console.WriteLine("Encerrou");
       Environment.Exit(0);
       break;

     default:
      Console.WriteLine("Opção inválida!!!");
       break;
  }
 }