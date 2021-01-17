using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class CustomerManager 
    {
        public void Add(Customer customer)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Customer Added!");
            Console.ResetColor();
            Console.WriteLine($"\nMüşteri Bilgileri : \n Id : {customer.Id} \n FirstName : {customer.FirstName} \n " +
                    $"LastName : {customer.LastName} \n Address : {customer.Address}");
            Console.WriteLine();
        }

        public void Update(Customer customer)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Customer Updated!");
            Console.ResetColor();
            Console.WriteLine($"\nMüşteri Bilgileri : \n Id : {customer.Id} \n FirstName : {customer.FirstName} \n " +
                    $"LastName : {customer.LastName} \n Address : {customer.Address}");
            Console.WriteLine();
        }

        public void Delete(Customer customer)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Customer Deleted!");
            Console.ResetColor();
            Console.WriteLine($"\nMüşteri Bilgileri : \n Id : {customer.Id} \n FirstName : {customer.FirstName} \n " +
                    $"LastName : {customer.LastName} \n Address : {customer.Address}");
            Console.WriteLine();
        }


    }
}
