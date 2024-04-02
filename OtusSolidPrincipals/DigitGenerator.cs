using OtusSolidPrincipals.Abstractions;
using OtusSolidPrincipals.Models;

namespace OtusSolidPrincipals
{
    public class DigitGenerator : IDigitGenerator
    {
        private readonly Random _random = new();
        public int GenerateDigit(GenerationSet generationSet)
        {
            return _random.Next(generationSet.LowerRange, generationSet.UpperRange);
        }
    }
}

