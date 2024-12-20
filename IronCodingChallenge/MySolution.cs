using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronCodingChallenge
{
    public class MySolution
    {
        private static readonly Dictionary<char, string> KeyMap = new Dictionary<char, string>
            {
                { '2', "ABC" },
                { '3', "DEF" },
                { '4', "GHI" },
                { '5', "JKL" },
                { '6', "MNO" },
                { '7', "PQRS" },
                { '8', "TUV" },
                { '9', "WXYZ" }
            };
        private const char EndInputChar = '#';
        private const char BackspaceChar = '*';
        private const char SpaceChar = ' ';

        private static bool ValidateInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return false;
            if (input.Last() != EndInputChar)
                return false;
            // Check if it contains anything else than the predefined characters
            foreach (char c in input)
            {
                if (!KeyMap.ContainsKey(c)
                    && c != BackspaceChar
                    && c != SpaceChar
                    && c != EndInputChar)
                    return false;
            }
            return true;
        }

        public static string ConvertInput(string input)
        {
            if (!ValidateInput(input))
                return string.Empty;

            var stack = new Stack<char>();

            foreach (char c in input)
            {
                switch (c)
                {
                    case (BackspaceChar):
                        processNumber(stack);
                        if (stack.Any())
                            stack.Pop(); // remove the last inserted letter

                        break;
                    case (SpaceChar):
                        processNumber(stack); // process the last number's corresponding letter
                        break;

                    case (EndInputChar):
                        processNumber(stack); // process the last number's corresponding letter and return
                        return prepareResult(stack);

                    default:
                        if (stack.Any() && c != stack.Peek())
                            processNumber(stack);

                        stack.Push(c);
                        break;
                }
            }

            return string.Empty;
        }

        private static string prepareResult(Stack<char> stack)
        {
            // build the result from the stack.
            var result = "";
            foreach (char c in stack)
                result = c + result;

            return result;
        }

        private static void processNumber(Stack<char> stack)
        {
            if (!stack.Any())
                return;

            char currentChar = stack.Peek();
            if (!KeyMap.ContainsKey(currentChar))
                return;
            
            var numberOfTimesAppeared = 0;
            while (stack.Any() && stack.Peek() == currentChar)
            {
                stack.Pop();
                numberOfTimesAppeared++;
            }
            
            char key = currentChar;
            int count = numberOfTimesAppeared;
            if (MySolution.KeyMap.ContainsKey(key))
            {
                string letters = MySolution.KeyMap[key];
                int index = (count - 1) % letters.Length; // Cycle through letters
                stack.Push(letters[index]);
            }
        }
    }
}
