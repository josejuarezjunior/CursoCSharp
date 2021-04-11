using System;
using ExcecoesPersonalizadas.Entities;
using ExcecoesPersonalizadas.Entities.Exceptions;

namespace ExcecoesPersonalizadas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exceções Personalizadas - Aulas 143, 144 e 145.

            //O bloco "try" faz uma tentativa de executar o programa.
            try
            {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
            }
            //Caso haja uma exceção(erro) no programa, será executado o bloco catch(captura)
            //FormatException é um erro de formatação
            catch (FormatException e)
            {
                Console.WriteLine("Error in format: " + e.Message);
            }
            //Caso haja uma exceção(erro) no domínio, relativo à lógica desse programa
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            /*Exception é o erro mais genérico na hierarquia de exceções.
            ** Qualquer outro erro será direcionado para esta exceção!
            */
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}