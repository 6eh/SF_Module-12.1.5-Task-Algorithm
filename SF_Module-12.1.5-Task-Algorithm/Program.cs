using System;
using System.Threading;

namespace SF_Module_12._1._5_Task_Algorithm
{
    class Program
    {

        static void Main(string[] args)
        {
            User[] users = new User[]
            {
                new User() { Login = "leo", Name = "Leonardo", IsPremium = false },
                new User() { Login = "mike", Name = "Mikelangelo", IsPremium = true },
                new User() { Login = "don", Name = "Donatello", IsPremium = true },
                new User() { Login = "raf", Name = "Rafael", IsPremium = false }                
            };

            foreach (var user in users)
            {
                Console.WriteLine($"Hi, {user.Name}!");

                if (!user.IsPremium)
                    ShowAds();
                Console.WriteLine("---");
            }

            Console.ReadLine();
        }

        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
}

public class User
{
    public string Login { get; set; }
    public string Name { get; set; }
    public bool IsPremium { get; set; }
}