using OtusSolidPrincipals.Abstractions;

namespace OtusSolidPrincipals
{
    public class ConfigManager : IConfigManager
    {
        private int _attemptsAmount;
        private int _upperRange;
        private int _lowerRange;

        public void ReadAttemptsAmount(int attemptsAmount)
        {
            _attemptsAmount = attemptsAmount;
        }

        public void ReadLowerRange(int lowerRange)
        {
            _lowerRange = lowerRange;
        }

        public void ReadUpperRange(int upperRange)
        {
            _upperRange = upperRange;
        }

        public int GetAttemptsAmount()
        {
            return _attemptsAmount;
        }

        public int GetLowerRange()
        {
            return _lowerRange;
        }

        public int GetUpperRange()
        {
            return _upperRange;
        }
    }
}
