using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronCodingChallenge
{
    public class MySolution
    {
        public static readonly Dictionary<char, string> KeyMap = new Dictionary<char, string>
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

        private static bool ValidateInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) 
                return false;
            if (input.Last() != '#')
                return false;
            if(input.Contains('1')  || input.Contains("0"))
                return false;
            // TODO: check if it contains anything else than the predefined characters
            // then return false;

            return true;
        }

        public static string ConvertInput(string input)
        {
            var isValidInput = ValidateInput(input);
            if (!isValidInput)
            {
                return string.Empty;
            }

            Stack<char> stack = new Stack<char>();

            foreach (char c in input)
            {
                if (c == '*')
                {
                    processNumber(stack);
                    stack.Pop(); // remove the last letter
                }
                else if (c == ' ')
                {
                    processNumber(stack); // process the last number's corresponding letter
                }
                else if (c == '#')
                {
                    processNumber(stack); // process the last number's corresponding letter and then return
                    break;
                }
                else
                {
                    if(stack.Any() && c != stack.Peek())
                        processNumber(stack);

                    stack.Push(c);
                }
            }

            // build the result from the stack.
            var result = "";
            foreach (char c in stack)
            {
                result = c + result;
            }
            return result;
        }

        private static void processNumber(Stack<char> stack)
        {
            char currentChar = stack.Peek();
            if (!(currentChar >= '2' && currentChar <= '9'))
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
