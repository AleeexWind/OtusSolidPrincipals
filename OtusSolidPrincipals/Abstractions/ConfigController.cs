using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusSolidPrincipals.Abstractions
{
    public abstract class ConfigController : IConfigController
    {
        public virtual void GetConfigs()
        {
            PrepareConfiguration();
            ProvideAttemptsAmount();
            ProvideUpperRange();
            ProvideLowerRange();
        }
        public abstract void PrepareConfiguration();
        public abstract void ProvideAttemptsAmount();
        public abstract void ProvideUpperRange();
        public abstract void ProvideLowerRange();
    }
}
