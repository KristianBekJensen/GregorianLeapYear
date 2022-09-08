namespace IsItLeapYear.test;
public class LeapYearInterfacetest
{
    [Fact]
    public void Main_when_input_1700()
    {
        // Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);
        using var reader = new StringReader("1700");
        Console.SetIn(reader);

         // Act
        var program = Assembly.Load(nameof(IsItLeapYear));
        program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output = output.Substring(output.Length-3);
        output.Should().Be("nay");
    }
    [Fact]
    public void to_early_year_Exception(){       
        // Assert
        Assert.Throws<ArgumentException>(() => LeapYearFinder.IsLeapYear(1581));
    }
    [Fact]
    public void Main_when_input_Is_String()
    {
        // Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);
        using var reader = new StringReader("hej");
        Console.SetIn(reader);
        using var reader2 = new StringReader("1700");
        Console.SetIn(reader2);

         // Act
        var program = Assembly.Load(nameof(IsItLeapYear));
        program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output = output.Substring(output.Length-3);
        output.Should().Be("nay");
    }
}