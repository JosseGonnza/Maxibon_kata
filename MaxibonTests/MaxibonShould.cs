using ConsoleApp1;
using FluentAssertions;

namespace MaxibonTests;

public class MaxibonShould
{
    [Fact(DisplayName = "Return number of maxibons in the fridge")]
    public void return_number_of_maxibons_in_the_fridge()
    {
        //Arrange
        var fridge = new Fridge(10);
        var developers = new List<Developer>()
        {
            new Developer("Pedro", 3),
            new Developer("Fran", 1),
            new Developer("Davide", 0),
            new Developer("Sergio", 2),
            new Developer("Jorge", 3),
            new Developer("Toni", 3)
        };

        //Act
        var result = KarumiHQ.OpenFridge(developers, fridge);

        //Assert
        result.Should().Be(7);
    }
}