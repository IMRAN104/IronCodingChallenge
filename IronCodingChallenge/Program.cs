namespace IronCodingChallenge;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Here's some sample input and output for the OldPhoneKeyPadConverter class:");
        Console.WriteLine($"Input: 33# and Output: {OldPhoneKeyPadConverter.ConvertOldPhoneInputToRegularText("33#")}"); // Output: E
        Console.WriteLine($"Input: 227*# and Output: {OldPhoneKeyPadConverter.ConvertOldPhoneInputToRegularText("227*#")}"); // Output: B
        Console.WriteLine($"Input: 4433555 555666# and Output: {OldPhoneKeyPadConverter.ConvertOldPhoneInputToRegularText("4433555 555666#")}"); // Output: HELLO
        Console.WriteLine($"Input: 8 88777444666*664# and Output: {OldPhoneKeyPadConverter.ConvertOldPhoneInputToRegularText("8 88777444666*664#")}"); // Output: TURING
        Console.WriteLine($"Input: 222 2 22# and Output: {OldPhoneKeyPadConverter.ConvertOldPhoneInputToRegularText("222 2 22#")}"); // Output: CAB
        Console.WriteLine($"Input: 2# and Output: {OldPhoneKeyPadConverter.ConvertOldPhoneInputToRegularText("2#")}"); // Output: A
        Console.WriteLine($"Input: 9# and Output: {OldPhoneKeyPadConverter.ConvertOldPhoneInputToRegularText("9#")}"); // Output: W
        Console.WriteLine($"Input: *# and Output: {OldPhoneKeyPadConverter.ConvertOldPhoneInputToRegularText("*#")}"); // Output: ''
        Console.WriteLine($"Input: gff# and Output: {OldPhoneKeyPadConverter.ConvertOldPhoneInputToRegularText("gff#")}"); // Output: ''
        Console.WriteLine($"Input: # and Output: {OldPhoneKeyPadConverter.ConvertOldPhoneInputToRegularText("#")}"); // Output: ''
        Console.WriteLine($"Input: 33# and Output: {OldPhoneKeyPadConverter.ConvertOldPhoneInputToRegularText("33#")}"); // Output: E
        Console.WriteLine($"Input: 4433555 555666096667775553# and Output: {OldPhoneKeyPadConverter.ConvertOldPhoneInputToRegularText("4433555 555666096667775553#")}"); // Output: HELLO WORLD
        Console.WriteLine($"Input: 222 2# and Output: {OldPhoneKeyPadConverter.ConvertOldPhoneInputToRegularText("222 2#")}"); // Output: CA
        Console.WriteLine($"Input: 7777# and Output: {OldPhoneKeyPadConverter.ConvertOldPhoneInputToRegularText("7777#")}"); // Output: S
        Console.WriteLine($"Input: 8888# and Output: {OldPhoneKeyPadConverter.ConvertOldPhoneInputToRegularText("8888#")}"); // Output: T
        Console.WriteLine($"Input: 9999# and Output: {OldPhoneKeyPadConverter.ConvertOldPhoneInputToRegularText("9999#")}"); // Output: Z
        Console.WriteLine($"Input: 0# and Output: {OldPhoneKeyPadConverter.ConvertOldPhoneInputToRegularText("0#")}"); // Output: (space)
        Console.WriteLine($"Input: 111# and Output: {OldPhoneKeyPadConverter.ConvertOldPhoneInputToRegularText("111#")}"); // Output: (empty)
        Console.WriteLine($"Input: 2222# and Output: {OldPhoneKeyPadConverter.ConvertOldPhoneInputToRegularText("2222#")}"); // Output: C
    }
}
