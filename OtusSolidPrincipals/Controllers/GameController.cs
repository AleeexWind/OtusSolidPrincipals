using OtusSolidPrincipals.Abstractions;

namespace OtusSolidPrincipals.Controllers
{
    public class GameController : IGameController
    {
        private readonly IGameInteractor _gameInteractor;
        public GameController(IGameInteractor gameInteractor)
        {
            _gameInteractor = gameInteractor;
        }
        public void StartTheGame()
        {
            _gameInteractor.StartTheGame();
        }

        public bool TryToGuess(string? guessDigit)
        {
            int guess = Convert.ToInt32(guessDigit);
            return _gameInteractor.TryToGuess(guess);
        }
    }
}
