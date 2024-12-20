namespace IronCodingChallenge;

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
        Console.WriteLine(MySolution.ConvertInput("2#")); // Output: CAB 
        Console.WriteLine(MySolution.ConvertInput("9#")); // Output: CAB 
        Console.WriteLine(MySolution.ConvertInput("*#")); // Output: CAB 
        Console.WriteLine(MySolution.ConvertInput("gff")); // Output: CAB 
    }
}
