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
        _inputWithInvalidChar = "356 $ 56";
        _inputWithValidChars = _inputWithoutEndChar + Constants.EndInputChar;
        _inputWithSpaceAndBackspace = _inputWithoutEndChar + Constants.SpaceChar + Constants.BackspaceChar + Constants.EndInputChar;
    }

    [Test]
    public void ValidateInput_ShouldReturnExpectedResults()
    {
        // Act and Assert
        Assert.IsFalse(InputValidator.ValidateInput(_emptyInput));
        Assert.IsFalse(InputValidator.ValidateInput(_inputWithoutEndChar));
        Assert.IsFalse(InputValidator.ValidateInput(_inputWithInvalidChar));
        Assert.IsTrue(InputValidator.ValidateInput(_inputWithValidChars));
        Assert.IsTrue(InputValidator.ValidateInput(_inputWithSpaceAndBackspace));
    }
}
