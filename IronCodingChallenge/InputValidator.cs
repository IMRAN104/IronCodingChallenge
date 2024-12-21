namespace IronCodingChallenge;
public class InputValidator
{
    public static bool ValidateInput(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return false;
        if (input.Last() != Constants.EndInputChar)
            return false;
        // Check if it contains anything else than the predefined characters
        foreach (char c in input)
        {
            if (!Constants.KeyMap.ContainsKey(c)
                && c != Constants.BackspaceChar
                && c != Constants.SpaceChar
                && c != Constants.EndInputChar)
                return false;
        }

        return true;
    }
}
