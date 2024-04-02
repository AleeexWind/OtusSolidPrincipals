
namespace OtusSolidPrincipals.Abstractions
{
    internal interface IGameController
    {
        public void StartTheGame();

        public bool TryToGuess(string? guessDigit);
    }
}
