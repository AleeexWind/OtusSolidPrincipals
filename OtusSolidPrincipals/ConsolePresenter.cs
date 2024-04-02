using OtusSolidPrincipals.Abstractions;

namespace OtusSolidPrincipals
{
    public class ConsolePresenter : IGamePresenter
    {
        public void ShowGuessDigitGreaterThenGenDigit()
        {
            Console.WriteLine("Your digit is greater then generated digit");
        }

        public void ShowGuessDigitLowerThenGenDigit()
        {
            Console.WriteLine("Your digit is lower then generated digit");
        }

        public void ShowLoss()
        {
            Console.WriteLine("Your attempts amount is over. Game is over");
        }

        public void ShowWin()
        {
            Console.WriteLine("You win!");
        }
    }
}
