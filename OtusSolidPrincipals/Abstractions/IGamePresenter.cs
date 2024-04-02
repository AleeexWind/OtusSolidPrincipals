namespace OtusSolidPrincipals.Abstractions
{
    public interface IGamePresenter
    {
        void ShowWin();
        void ShowGuessDigitGreaterThenGenDigit();
        void ShowGuessDigitLowerThenGenDigit();
        void ShowLoss();
    }
}
