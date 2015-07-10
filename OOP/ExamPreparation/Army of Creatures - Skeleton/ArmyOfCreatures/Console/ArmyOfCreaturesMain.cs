namespace ArmyOfCreatures.Console
{
    using System;
    using System.Globalization;
    using System.Threading;

    using ArmyOfCreatures.Extended;

    using Commands;
    using Logic;
    using Logic.Battles;

    public static class ArmyOfCreaturesMain
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            ICreaturesFactory creaturesFactory = GetCreaturesFactory();
            ILogger logger = new ConsoleLogger();
            IBattleManager battleManager = GetBattleManager(creaturesFactory, logger);

            ICommandManager commandManager = new CommandManager();

            while (true)
            {
                var commandLine = Console.ReadLine();
                commandManager.ProcessCommand(commandLine, battleManager);
            }
        }

        private static ExtendedBattleManager GetBattleManager(ICreaturesFactory creaturesFactory, ILogger logger)
        {
            // You are allowed to add, change and remove code here
            return new ExtendedBattleManager(creaturesFactory, logger);
        }

        private static ExtendedCreaturesFactory GetCreaturesFactory()
        {
            // You are allowed to add, change and remove code here
            return new ExtendedCreaturesFactory();
        }
    }
}
