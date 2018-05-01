using DemoConsole.Entities;
using System;

namespace DemoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ActorDbContext())
            {
                db.Actors.AddRange(
                        new Actor
                        {
                            Name = "Ewan McGregor",
                            Age = 45,
                            AcademyWinner = false
                        },
                        new Actor
                        {
                            Name = "Kelly MacDonald",
                            Age = 41,
                            AcademyWinner = false
                        },
                        new Actor
                        {
                            Name = "Ewan Bremmer",
                            Age = 47,
                            AcademyWinner = false
                        },
                        new Actor
                        {
                            Name = "Johnny Lee Miller",
                            Age = 44,
                            AcademyWinner = false
                        }
                    );

                var count = db.SaveChanges();

                Console.WriteLine($"{ count } records were added");
                foreach (var actor in db.Actors)
                {
                    Console.WriteLine($"Name: { actor.Name }");
                    Console.WriteLine($"Age: { actor.Age }");
                    if (actor.AcademyWinner)
                    {
                        Console.WriteLine("Academy award winner");
                    }
                    else
                    {
                        Console.WriteLine("Not an academy award winner");
                    }

                }

                Console.ReadLine();
            }
        }
    }
}
