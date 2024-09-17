namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Maxibon Kata!");
        KarumiHQ.OpenFridge(new List<Developer>()
        {
            new Developer("Pedro", 3),
            new Developer("Fran", 1),
            new Developer("Davide", 0),
            new Developer("Sergio", 2),
            new Developer("Jorge", 1),
            new Developer("Toni", 2)
        }, new Fridge(10));
    }
}