namespace OtusSolidPrincipals.Abstractions
{
    public interface IGameInteractor
    {
        void StartTheGame();

        bool TryToGuess(int guessDigit);
    }
}
