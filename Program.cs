using Pereirão.Entities;
using System;
using System.Globalization;
using Pereirão.Services.Services;
namespace Pereirão
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os Dados do aluguel");
            Console.WriteLine("Cliente");
            Console.WriteLine("Nome");
            string nome = Console.ReadLine();
            Console.WriteLine("CPF");
            string cpf = Console.ReadLine();
            Console.WriteLine("Data de nascimento");
            DateTime dataNascimento = DateTime.Parse(Console.ReadLine());


            Client client = new Client(cpf, nome, dataNascimento);

            Console.WriteLine("Modelo do carro");
            string modelo = Console.ReadLine();
            Console.Write("Retirada:");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Devolução:");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            CarRental CarRental = new CarRental(start, finish);

            Console.WriteLine("Entre com o preço Por hora");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com o preço Por Dia");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            RentalService rentalService = new RentalService(hour, day, new BrasilTexServices());

            rentalService.ProcessInvoice(CarRental);

            Console.WriteLine("Dados do cliente");
            Console.WriteLine(client);
            Console.WriteLine("Descrição do pedido");
            
            Console.WriteLine(CarRental.Invoice);


        }
    }
}
