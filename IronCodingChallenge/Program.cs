using System;
using System.Collections.Generic;
using System.Text;

namespace IronCodingChallenge;

public class OldPhonePad_without_DesignPattern
{
    // Mapping of keys to their corresponding letters
    private static readonly Dictionary<char, string> KeyMap
        = new Dictionary<char, string>
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

    public static string ConvertInput(string input)
    {
        StringBuilder output = new StringBuilder();
        StringBuilder currentSequence = new StringBuilder();

        foreach (char c in input)
        {
            if (c == '#') // End of input
            {
                break;
            }
            else if (c == '*') // Backspace
            {
                if (currentSequence.Length > 0)
                {
                    // Process the current sequence before backspacing
                    ProcessCurrentSequence(currentSequence, output);
                }
                if (output.Length > 0)
                {
                    output.Length--; // Remove last character from output
                }
            }
            else if (c == ' ') // Space indicates a pause
            {
                ProcessCurrentSequence(currentSequence, output);
            }
            else // Handle key presses
            {
                if (currentSequence.Length > 0 && currentSequence[0] != c)
                {
                    ProcessCurrentSequence(currentSequence, output);
                }
                currentSequence.Append(c);
            }
        }

        // Process any remaining sequence
        ProcessCurrentSequence(currentSequence, output);

        return output.ToString();
    }

    private static void ProcessCurrentSequence(StringBuilder currentSequence, StringBuilder output)
    {
        if (currentSequence.Length > 0)
        {
            char key = currentSequence[0];
            int count = currentSequence.Length;

            if (KeyMap.ContainsKey(key))
            {
                string letters = KeyMap[key];
                int index = (count - 1) % letters.Length; // Cycle through letters
                output.Append(letters[index]);
            }

            currentSequence.Clear(); // Clear the current sequence after processing
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("****************************************************");
        Console.WriteLine(MySolution.ConvertInput("33#")); // Output: E
        Console.WriteLine(MySolution.ConvertInput("227*#")); // Output: B
        Console.WriteLine(MySolution.ConvertInput("4433555 555666#")); // Output: HELLO
        Console.WriteLine(MySolution.ConvertInput("8 88777444666*664#")); // Output: TURING
        Console.WriteLine(MySolution.ConvertInput("222 2 22#")); // Output: CAB 
    }
}
