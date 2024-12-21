namespace IronCodingChallenge;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("****************************************************");
        Console.WriteLine(OldPhoneKeyPadConverter.ConvertOldPhoneInputToRegularText("33#")); // Output: E
        Console.WriteLine(OldPhoneKeyPadConverter.ConvertOldPhoneInputToRegularText("227*#")); // Output: B
        Console.WriteLine(OldPhoneKeyPadConverter.ConvertOldPhoneInputToRegularText("4433555 555666#")); // Output: HELLO
        Console.WriteLine(OldPhoneKeyPadConverter.ConvertOldPhoneInputToRegularText("8 88777444666*664#")); // Output: TURING
        Console.WriteLine(OldPhoneKeyPadConverter.ConvertOldPhoneInputToRegularText("222 2 22#")); // Output: CAB 
        Console.WriteLine(OldPhoneKeyPadConverter.ConvertOldPhoneInputToRegularText("2#")); // Output: A
        Console.WriteLine(OldPhoneKeyPadConverter.ConvertOldPhoneInputToRegularText("9#")); // Output: W 
        Console.WriteLine(OldPhoneKeyPadConverter.ConvertOldPhoneInputToRegularText("*#")); // Output: '' 
        Console.WriteLine(OldPhoneKeyPadConverter.ConvertOldPhoneInputToRegularText("gff#")); // Output: ''
        Console.WriteLine(OldPhoneKeyPadConverter.ConvertOldPhoneInputToRegularText("#")); // Output: ''
    }
}
