namespace IsItLeapYear.test;

public class IsItLeapYearTest
{
    [Fact]
    public void Is1700LeapYear()
    {
        // Arrange
        
         // Act
        bool isleapyear = LeapYearFinder.IsLeapYear(1700);
        
        // Assert
        isleapyear.Should().Be(false);
    }

    [Fact]
    public void Is2000LeapYear()
    {
        // Arrange
        
         // Act
        bool isleapyear = LeapYearFinder.IsLeapYear(2000);
        
        // Assert
        isleapyear.Should().Be(true);
    }

    [Fact]
    public void Is2001LeapYear()
    {
        // Arrange
        
         // Act
        bool isleapyear = LeapYearFinder.IsLeapYear(2001);
        
        // Assert
        isleapyear.Should().Be(false);
    }

    [Fact]
    public void Is2004LeapYear()
    {
        // Arrange
        
         // Act
        bool isleapyear = LeapYearFinder.IsLeapYear(2004);
        
        // Assert
        isleapyear.Should().Be(true);
    }
}