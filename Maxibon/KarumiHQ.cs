namespace ConsoleApp1;

public class KarumiHQ
{
    public static int OpenFridge(List<Developer> developers, Fridge fridge)
    {
        var maxibonsLeft = 0;
        foreach (Developer dev in developers)
        {
            maxibonsLeft = fridge.Maxibons -= dev.NumberOfMaxibons;
            if (maxibonsLeft <= 2)
            {
                Console.WriteLine($"Hi guys, I'm {dev.Name}. We need more maxibons!");
                maxibonsLeft = 10;
            }
        }
        Console.WriteLine($"We have {maxibonsLeft} maxibones left");
        return maxibonsLeft;
    }
}