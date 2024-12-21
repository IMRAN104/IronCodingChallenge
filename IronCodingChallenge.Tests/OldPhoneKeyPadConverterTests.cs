using NUnit.Framework;

namespace IronCodingChallenge.Tests;
public class OldPhoneKeyPadConverterTests
{
    [Test]
    public void ConvertOldPhoneInputToRegularText_ValidInputs_ReturnsExpectedResults()
    {
        // Arrange
        var testCases = new[]
        {
                new { Input = "33#", ExpectedOutput = "E" },
                new { Input = "227*#", ExpectedOutput = "B" },
                new { Input = "4433555 555666#", ExpectedOutput = "HELLO" },
                new { Input = "2#", ExpectedOutput = "A" },
                new { Input = "9#", ExpectedOutput = "W" }
            };

        // Act and Assert
        foreach (var testCase in testCases)
        {
            var result = OldPhoneKeyPadConverter.ConvertOldPhoneInputToRegularText(testCase.Input);
            Assert.That(result, Is.EqualTo(testCase.ExpectedOutput));
        }
    }

    [Test]
    public void ConvertOldPhoneInputToRegularText_InvalidInputs_ReturnsEmptyString()
    {
        // Arrange
        var testCases = new[]
        {
                "*#",
                "gff#",
                "#"
            };

        // Act and Assert
        foreach (var testCase in testCases)
        {
            var result = OldPhoneKeyPadConverter.ConvertOldPhoneInputToRegularText(testCase);
            Assert.That(result, Is.EqualTo(string.Empty));
        }
    }

    [Test]
    public void ConvertOldPhoneInputToRegularText_InputWithBackspace_ReturnsExpectedResult()
    {
        // Arrange
        var input = "8 88777444666*664#";
        var expectedOutput = "TURING";           // characters after the first # will not be considered

        // Act
        var result = OldPhoneKeyPadConverter.ConvertOldPhoneInputToRegularText(input);

        // Assert
        Assert.That(result, Is.EqualTo(expectedOutput));
    }

    [Test]
    public void ConvertOldPhoneInputToRegularText_InputWithSpaces_ReturnsExpectedResult()
    {
        // Arrange
        var input = "222 2 22#";
        var expectedOutput = "CAB";

        // Act
        var result = OldPhoneKeyPadConverter.ConvertOldPhoneInputToRegularText(input);

        // Assert
        Assert.That(result, Is.EqualTo(expectedOutput));
    }

    [Test]
    public void ConvertOldPhoneInputToRegularText_InputWithInvalidInput_ReturnsExpectedResult()
    {
        // Arrange
        var input = "GH4243%65#";
        var expectedOutput = "";

        // Act
        var result = OldPhoneKeyPadConverter.ConvertOldPhoneInputToRegularText(input);

        // Assert
        Assert.That(result, Is.EqualTo(expectedOutput));
    }
}
