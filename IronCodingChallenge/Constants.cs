namespace IronCodingChallenge;
public class Constants
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
    public const char EndInputChar  = '#';
    public const char BackspaceChar = '*';
    public const char SpaceChar     = ' ';
}
