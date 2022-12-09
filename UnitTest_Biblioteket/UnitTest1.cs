namespace UnitTest_Biblioteket;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        //Arrange
        Biblioteket.Bibliotek MitBib = new Biblioteket.Bibliotek("bonk");

        Biblioteket.Laaner MinLaaner = new Biblioteket.Laaner(1, "Egon", "test@mail.dk");

        string expected = "Egon";

        //Act
        string actual = MinLaaner.navn;

        //Assert
        Assert.Equal(expected, actual);

    }
}
