using OtusSolidPrincipals.Abstractions;

namespace OtusSolidPrincipals.Controllers
{
    public class ConsoleConfigController : ConfigController
    {
        private readonly IConfigManager _configManager;
        public ConsoleConfigController(IConfigManager configManager)
        {
            _configManager = configManager;
        }
        public override void ProvideAttemptsAmount()
        {
            Console.WriteLine("Write attempts amount");
            string? attemptsAmount = Console.ReadLine();
            Console.WriteLine("");

            int attempts = Convert.ToInt32(attemptsAmount);
            _configManager.ReadAttemptsAmount(attempts);
        }
        public override void ProvideUpperRange()
        {
            Console.WriteLine("Write upper range");
            string? upperRange = Console.ReadLine();
            Console.WriteLine("");

            int upper = Convert.ToInt32(upperRange);
            _configManager.ReadUpperRange(upper);
        }
        public override void ProvideLowerRange()
        {
            Console.WriteLine("Write lower range");
            string? lowerRange = Console.ReadLine();
            Console.WriteLine("");

            int lower = Convert.ToInt32(lowerRange);
            _configManager.ReadLowerRange(lower);
        }

        public override void PrepareConfiguration()
        {
            Console.WriteLine("Hello, click any key to start!");
            Console.ReadKey();
        }
    }
}
