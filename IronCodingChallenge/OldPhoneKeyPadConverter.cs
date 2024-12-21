namespace IronCodingChallenge
{
    public class OldPhoneKeyPadConverter
    {
        public static string ConvertInput(string input)
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
                            stack.Pop();                            // remove the last inserted letter

                        break;
                    case (Constants.SpaceChar):
                        processLastSequence(stack);                 // process the last number's corresponding letter
                        break;

                    case (Constants.EndInputChar):
                        processLastSequence(stack);                 // process the last number's corresponding letter and return
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
        {
            var result = "";
            foreach (char c in stack)
                result = c + result;

            return result;
        }

        private static void processLastSequence(Stack<char> stack)
        {
            if (!stack.Any())
                return;

            char currentChar = stack.Peek();
            if (!Constants.KeyMap.ContainsKey(currentChar))
                return;
            
            var numberOfTimesAppeared = 0;
            while (stack.Any() && stack.Peek() == currentChar)
            {
                stack.Pop();
                numberOfTimesAppeared++;
            }
            
            char key = currentChar;
            int count = numberOfTimesAppeared;
            if (Constants.KeyMap.ContainsKey(key))
            {
                string letters = Constants.KeyMap[key];
                int index = (count - 1) % letters.Length;           // Cycle through letters
                stack.Push(letters[index]);
            }
        }
    }
}
