using OtusSolidPrincipals.Models;

namespace OtusSolidPrincipals.Abstractions
{
    public interface IDigitGenerator
    {
        int GenerateDigit(GenerationSet generationSet);
    }
}
