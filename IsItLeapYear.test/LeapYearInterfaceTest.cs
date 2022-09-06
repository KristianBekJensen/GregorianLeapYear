namespace IsItLeapYear.test;
public class LeapYearInterfacetest
{
    [Fact]
    public void Main_when_run_prints_Hello_World()
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
}