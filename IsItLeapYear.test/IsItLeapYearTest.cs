namespace IsItLeapYear.test;

public class IsItLeapYearTest
{
    [Fact]
    public void IsItLeapYear1700()
    {
        // Arrange
        //var program = new LeapYearFinder();
        
         // Act
        bool isleapyear = LeapYearFinder.IsItLeapYear(1700);
        

        // Assert
        isleapyear.Should().Be(false);
    }
}