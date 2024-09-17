namespace ConsoleApp1;

public class KarumiHQ
{
    public static string OpenFridge(List<Developer> developers, Fridge fridge)
    {
        foreach (var developer in developers)
        {
            fridge.Maxibons -= developer.NumberOfMaxibons;
            if (fridge.Maxibons <= 2)
            {
                Console.WriteLine($"Hi guys, I'm {developer.Name}. We need more maxibons!");
                fridge.Maxibons += 10;
            }
        }
        return $"Maxibons left: {fridge.Maxibons}";
    }
}