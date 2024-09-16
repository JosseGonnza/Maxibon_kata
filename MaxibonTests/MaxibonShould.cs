using FluentAssertions;

namespace MaxibonTests;

public class MaxibonShould
{
    [Fact(DisplayName = "Return number of maxibons in the fridge")]
    public void return_number_of_maxibons_in_the_fridge()
    {
        //Arrange
        var developers = new List<Developer>()
        {
            new Developer("Pedro", 3),
            new Developer("Fran", 1),
            new Developer("Davide", 0),
            new Developer("Sergio", 2),
            new Developer("Jorge", 1),
            new Developer("Toni", 2)
        };
        var fridge = new Fridge(10);

        //Act
        var result = KarumiHQ.OpenFridge(developers, fridge);

        //Assert
        result.Should().Be("Maxibons left: 10");
    }
}

public class KarumiHQ
{
    public static int MaxibonsLeft { get; set; } = 10;

    static bool ShouldBuyMoreMaxibons => MaxibonsLeft <= 2;
    
    public static string OpenFridge(List<Developer> developers, Fridge fridge)
    {
        developers.ForEach(developer =>
        { 
            GrabMaxibons(developer);
            if (ShouldBuyMoreMaxibons)
            {
                NotifyWeShouldBuyMaxibons(developer);
                MaxibonsLeft =+ 10;
            }
        });
        return $"Maxibons left: {MaxibonsLeft}";
    }

    private static string NotifyWeShouldBuyMaxibons(Developer developer)
    {
        return $"Hi guys, I'm {developer}. We need more maxibons!";
    }

    public static void GrabMaxibons(Developer developer)
    {
         MaxibonsLeft =- developer.numberOfMaxibons;
    }
}

public class Fridge
{
    public int maxibons;

    public Fridge(int maxibons)
    {
        this.maxibons = maxibons;
    }
}

public class Developer
{
    public string name;
    public int numberOfMaxibons;

    public Developer(string name, int numberOfMaxibons)
    {
        this.name = name;
        this.numberOfMaxibons = numberOfMaxibons;
    }
}