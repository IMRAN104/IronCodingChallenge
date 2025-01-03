﻿namespace IronCodingChallenge;
public class InputValidator
{
    /// <summary>
    /// Validates the input string.
    /// </summary>
    /// <param name="input">Input String from Old Phone KeyPad to convert to Regular Text</param>
    /// <exception cref="ArgumentException"></exception>
    /// <exception cref="KeyNotFoundException"></exception>
    public static void ValidateInput(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            throw new ArgumentException("Input cannot be null or empty.");
        
        if (input.Last() != Constants.EndInputChar)
            throw new ArgumentException("Input must end with #.");
        
        // Check if it contains anything else than the predefined characters
        foreach (char c in input)
        {
            if (!Constants.KeyMap.ContainsKey(c)
                && c != Constants.BackspaceChar
                && c != Constants.SpaceChar
                && c != Constants.EndInputChar)
                throw new KeyNotFoundException($"Invalid key '{c}' found in input.");
        }
    }
}
