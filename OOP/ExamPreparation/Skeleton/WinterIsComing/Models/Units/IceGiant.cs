namespace WinterIsComing.Models.Units
{
    using WinterIsComing.Models.CombatHandlers;

    public class IceGiant : Unit
    {
        private const int DefaultHealthPoints = 300;
        private const int DefaultAttackPoints = 150;
        private const int DefaultDefensePoints = 60;
        private const int DefaultEnergyPoints = 50;
        private const int DefaultRange = 1;

        public IceGiant(string name, int x, int y)
            : base(x, y, name, DefaultRange, DefaultHealthPoints, DefaultAttackPoints, DefaultDefensePoints, DefaultEnergyPoints)
        {
            this.CombatHandler = new IceGiantCombatHandler(this);
        }
    }
}
