namespace IsItLeapYear.test;

public class IsItLeapYearTest
{
    [Fact]
    public void Is1700LeapYear()
    {
        // Arrange
        //var program = new LeapYearFinder();
        
         // Act
        bool isleapyear = LeapYearFinder.IsItLeapYear(1700);
        

        // Assert
        isleapyear.Should().Be(false);
    }

    [Fact]
    public void Is2000LeapYear()
    {
        // Arrange
        //var program = new LeapYearFinder();
        
         // Act
        bool isleapyear = LeapYearFinder.IsItLeapYear(2000);
        

        // Assert
        isleapyear.Should().Be(true);
    }

    [Fact]
    public void Is2001LeapYear()
    {
        // Arrange
        //var program = new LeapYearFinder();
        
         // Act
        bool isleapyear = LeapYearFinder.IsItLeapYear(2001);
        

        // Assert
        isleapyear.Should().Be(false);
    }

    [Fact]
    public void Is2004LeapYear()
    {
        // Arrange
        //var program = new LeapYearFinder();
        
         // Act
        bool isleapyear = LeapYearFinder.IsItLeapYear(2004);
        

        // Assert
        isleapyear.Should().Be(true);
    }
}