namespace IronCodingChallenge;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("****************************************************");
        Console.WriteLine(OldPhoneKeyPadConverter.ConvertInput("33#")); // Output: E
        Console.WriteLine(OldPhoneKeyPadConverter.ConvertInput("227*#")); // Output: B
        Console.WriteLine(OldPhoneKeyPadConverter.ConvertInput("4433555 555666#")); // Output: HELLO
        Console.WriteLine(OldPhoneKeyPadConverter.ConvertInput("8 88777444666*664#")); // Output: TURING
        Console.WriteLine(OldPhoneKeyPadConverter.ConvertInput("222 2 22#")); // Output: CAB 
        Console.WriteLine(OldPhoneKeyPadConverter.ConvertInput("2#")); // Output: CAB 
        Console.WriteLine(OldPhoneKeyPadConverter.ConvertInput("9#")); // Output: CAB 
        Console.WriteLine(OldPhoneKeyPadConverter.ConvertInput("*#")); // Output: CAB 
        Console.WriteLine(OldPhoneKeyPadConverter.ConvertInput("gff")); // Output: CAB 
    }
}
