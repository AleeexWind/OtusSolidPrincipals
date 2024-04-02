// See https://aka.ms/new-console-template for more information

using OtusSolidPrincipals;
using OtusSolidPrincipals.Abstractions;
using OtusSolidPrincipals.Controllers;


IConfigManager configManager = new ConfigManager();
IConfigController inputDataController = new ConsoleConfigController(configManager);


IGamePresenter gamePresenter = new ConsolePresenter();
IDigitGenerator generator = new DigitGenerator();
IGameInteractor gameInteractor = new GameInteractor(generator, configManager, gamePresenter);
IGameController gameController = new GameController(gameInteractor);

inputDataController.GetConfigs();

gameController.StartTheGame();
bool InGame = true;
while(InGame)
{
    Console.WriteLine("Write your guess digit");
    InGame = gameController.TryToGuess(Console.ReadLine());
    Console.WriteLine("");
};