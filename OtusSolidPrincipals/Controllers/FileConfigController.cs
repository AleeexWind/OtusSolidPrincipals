using OtusSolidPrincipals.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusSolidPrincipals.Controllers
{
    internal class FileConfigController : ConfigController
    {
        private readonly string _filePath;
        private readonly string _configs;
        public FileConfigController(string filePath)
        {
            _filePath = filePath;
        }
        public override void PrepareConfiguration()
        {
            ReadFile(_filePath);
        }

        public override void ProvideAttemptsAmount()
        {
            // Parse attempts amount from configs
        }

        public override void ProvideLowerRange()
        {
            // Parse lower range from configs
        }

        public override void ProvideUpperRange()
        {
            // Parse upper range from configs
        }

        private void ReadFile(string filePath)
        {
            // Read configs from the file
        }
    }
}
