namespace IronCodingChallenge;
public class OldPhoneKeyPadConverter
{
    /// <summary>
    /// Converts the Input String from Old Phone KeyPad to Regular Text.
    /// </summary>
    /// <param name="input">The string input in old phone keypad format.</param>
    /// <returns>The converted regular text string.</returns>
    public static string ConvertOldPhoneInputToRegularText(string input)
    {
        try
        {
            InputValidator.ValidateInput(input);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Validation Error: {ex.Message}");
            return string.Empty;
        }
        catch (KeyNotFoundException ex)
        {
            Console.WriteLine($"Validation Error: {ex.Message}");
            return string.Empty;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            return string.Empty;
        }

        var stack = new Stack<char>();

        foreach (char c in input)
        {
            switch (c)
            {
                case (Constants.BackspaceChar):
                    processLastSequence(stack);
                    if (stack.Any())
                        stack.Pop();
                    break;

                case (Constants.SpaceChar):
                    processLastSequence(stack);
                    break;

                case (Constants.EndInputChar):
                    processLastSequence(stack);
                    return prepareResult(stack);

                default:
                    if (stack.Any() && c != stack.Peek())       // if the current character and stacks top differ, then process the last sequence
                        processLastSequence(stack);

                    stack.Push(c);
                    break;
            }
        }

        return string.Empty;
    }

    /// <summary>
    /// Reverse the stack and returns the result array
    /// </summary>
    /// <param name="stack">Final Stack that contains the result reveresly.</param>
    /// <returns>Final converted result from the stack.</returns>
    private static string prepareResult(Stack<char> stack)
        => new string(stack.Reverse().ToArray());

    /// <summary>
    /// Processes the last remaining conversion on the stack and returns the result.
    /// </summary>
    /// <param name="stack">Stack that contains the result until now and also contains unprocessed characters.</param>
    /// <returns>Result of the conversion.</returns>
    private static void processLastSequence(Stack<char> stack)
    {
        if (!stack.Any())
            return;

        var currentChar = stack.Peek();
        if (!Constants.KeyMap.ContainsKey(currentChar))
            return;

        var currentCharAppearedCount = 0;
        while (stack.Any() && stack.Peek() == currentChar)
        {
            stack.Pop();
            currentCharAppearedCount++;
        }

        var lettersForCurrentChar = Constants.KeyMap[currentChar];
        var index = (currentCharAppearedCount - 1) % lettersForCurrentChar.Length;           // Cycle through letters, if 2222, then first three 2's are discarded and only the last one is considered 
        stack.Push(lettersForCurrentChar[index]);
        return;
    }
}
