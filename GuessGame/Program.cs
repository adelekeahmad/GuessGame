// See https://aka.ms/new-console-template for more information
namespace GuessGame;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        string secretWord = "Chelsea";
        string guess = "";
        while(guess != secretWord)
        {
            Console.Write("Who wins today's match: ");
            guess = Console.ReadLine();
    
        }
        //if condition does not hold
        Console.Write("you win the game!");

    }
 
}
