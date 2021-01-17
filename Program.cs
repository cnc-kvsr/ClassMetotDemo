using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new Customer
            {
                Id = 1,
                FirstName = "Ahmet",
                LastName = "Kağan",
                Address = "Konya"
            });
            customerManager.Add(new Customer()
            {
                Id = 2,
                FirstName = "Ahmet",
                LastName = "Kenan",
                Address = "Ankara"
            });

            customerManager.Add(new Customer()
                {
                    Id = 3,
                    FirstName = "Firdevs",
                    LastName = "Beyza",
                    Address = "İstanbul"
                });

            customerManager.Update(new Customer()
            {
                Id = 1,
                FirstName = "Ahmet",
                LastName = "Kağan",
                Address = "Ankara"
            });

            customerManager.Delete(new Customer()
            {
                Id = 2,
                FirstName = "Ahmet",
                LastName = "Kenan",
                Address = "Ankara"
            });


        }
    }
}
