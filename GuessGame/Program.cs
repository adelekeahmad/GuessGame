// See https://aka.ms/new-console-template for more information
namespace GuessGame;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        string secretWord = "Chelsea";
        string guess = "";
        int guessCount = 0;
        int guessLimit = 3;
        bool outOfGuesses = false;
        while(guess != secretWord && !outOfGuesses)
          {

        if (guessCount < guessLimit) 
        {
            Console.Write("Who wins today's match: ");
            guess = Console.ReadLine();
            guessCount++;
        }   
        
        else
        {
             outOfGuesses = true;
        }
                                       
        }
        if (outOfGuesses) 
        {
            Console.Write("you lose!");
        }
        else 
        { 
            //if condition does not hold
        Console.Write("you win!");
        }
        Console.ReadLine();
    }   
 
}
