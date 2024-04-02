using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusSolidPrincipals.Abstractions
{
    public interface IConfigManager
    {
        void ReadAttemptsAmount(int attemptsAmount);
        void ReadUpperRange(int upperRange);
        void ReadLowerRange(int lowerRange);

        int GetAttemptsAmount();
        int GetUpperRange();
        int GetLowerRange();
    }
}
