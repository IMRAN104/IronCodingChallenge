namespace IronCodingChallenge.Tests;
public class InputValidatorTests
{
    private string _emptyInput;
    private string _inputWithoutEndChar;
    private string _inputWithInvalidChar;
    private string _inputWithValidChars;
    private string _inputWithSpaceAndBackspace;

    [SetUp]
    public void Setup()
    {
        // Arrange
        _emptyInput = "";
        _inputWithoutEndChar = "223";
        _inputWithInvalidChar = "356 $ 56#";
        _inputWithValidChars = _inputWithoutEndChar + Constants.EndInputChar;
        _inputWithSpaceAndBackspace = _inputWithoutEndChar + Constants.SpaceChar + Constants.BackspaceChar + Constants.EndInputChar;
    }

    [Test]
    public void ValidateInputTests()
    {
        // Test for null or empty input
        Assert.Throws<ArgumentException>(() => InputValidator.ValidateInput(_emptyInput));

        // Test for input without the end character
        Assert.Throws<ArgumentException>(() => InputValidator.ValidateInput(_inputWithoutEndChar));

        // Test for input with invalid characters
        Assert.Throws<KeyNotFoundException>(() => InputValidator.ValidateInput(_inputWithInvalidChar));

        // Test for valid input
        Assert.DoesNotThrow(() => InputValidator.ValidateInput(_inputWithValidChars));

        // Test for input with space and backspace characters
        Assert.DoesNotThrow(() => InputValidator.ValidateInput(_inputWithSpaceAndBackspace));
    }
}
