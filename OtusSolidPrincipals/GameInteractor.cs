using OtusSolidPrincipals.Abstractions;
using OtusSolidPrincipals.Models;

namespace OtusSolidPrincipals
{
    public class GameInteractor : IGameInteractor
    {
        private readonly IDigitGenerator _digitGenerator;
        private readonly IConfigManager _configManager;
        private readonly IGamePresenter _gamePresenter;
        private int _generatedDigit;
        private int _attemptsAmount;

        public GameInteractor(IDigitGenerator digitGenerator, IConfigManager configManager, IGamePresenter gamePresenter)
        {
            _digitGenerator = digitGenerator;
            _configManager = configManager;
            _gamePresenter = gamePresenter;
        }
        public void StartTheGame()
        {
            _attemptsAmount = _configManager.GetAttemptsAmount();
            GenerationSet generationSet = new()
            {
                LowerRange = _configManager.GetLowerRange(),
                UpperRange = _configManager.GetUpperRange()
            };
            _generatedDigit = _digitGenerator.GenerateDigit(generationSet);
        }
        public bool TryToGuess(int guessDigit)
        {
            bool result = true;

            if(guessDigit == _generatedDigit)
            {
                _gamePresenter.ShowWin();
                return false;
            }
            else if(_attemptsAmount == 0)
            {
                _gamePresenter.ShowLoss();
                return false;
            }
            else if(guessDigit < _generatedDigit)
            {
                _gamePresenter.ShowGuessDigitLowerThenGenDigit();
            }
            else if(guessDigit > _generatedDigit)
            {
                _gamePresenter.ShowGuessDigitGreaterThenGenDigit();
            }
            _attemptsAmount--;

            return result;
        }
    }
}
