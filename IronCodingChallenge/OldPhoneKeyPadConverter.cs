namespace IronCodingChallenge;
public class OldPhoneKeyPadConverter
{
    public static string ConvertOldPhoneInputToRegularText(string input)
    {
        if (!InputValidator.ValidateInput(input))
            return string.Empty;

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

    private static string prepareResult(Stack<char> stack)
        => new string(stack.Reverse().ToArray());

    private static void processLastSequence(Stack<char> stack)
    {
        if (!stack.Any())
            return;

        char currentChar = stack.Peek();
        if (!Constants.KeyMap.ContainsKey(currentChar))
            return;

        var currentCharAppearedCount = 0;
        while (stack.Any() && stack.Peek() == currentChar)
        {
            stack.Pop();
            currentCharAppearedCount++;
        }

        string letters = Constants.KeyMap[currentChar];
        int index = (currentCharAppearedCount - 1) % letters.Length;           // Cycle through letters
        stack.Push(letters[index]);
        return;
    }
}
