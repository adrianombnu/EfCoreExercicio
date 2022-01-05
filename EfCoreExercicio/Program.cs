using System;

namespace EfCoreExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ModelContext())
            {
                var rnd = new Random();

                var cliente = new Cliente
                {
                    ClienteId = Guid.NewGuid().ToString(),
                    Email = "teste@ig.com",
                    Idade = rnd.Next(22, 40),
                    Nome = "teste" + rnd.Next(22, 40)

                };

                db.Clientes.Add(cliente);
                db.SaveChanges();
            }




            using (var db = new ModelContext())
            {
                var clientes = db.Clientes;

                foreach (var cliente in clientes)
                {
                    Console.WriteLine(new string('*', 20));
                    Console.WriteLine("\nID: " + cliente.ClienteId.ToString());
                    Console.WriteLine("Nome : " + cliente.Nome);
                    Console.WriteLine("Idade: " + cliente.Idade.ToString());
                    Console.WriteLine(new string('*', 20));
                }

            }
        }
    }
}
