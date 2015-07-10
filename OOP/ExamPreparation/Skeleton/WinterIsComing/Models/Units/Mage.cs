namespace WinterIsComing.Models.Units
{
    using WinterIsComing.Models.CombatHandlers;

    public class Mage : Unit
    {
        private const int DefaultHealthPoints = 80;
        private const int DefaultAttackPoints = 80;
        private const int DefaultDefensePoints = 40;
        private const int DefaultEnergyPoints = 120;
        private const int DefaultRange = 2;

        public Mage(string name, int x, int y)
            : base(x, y, name, DefaultRange, DefaultHealthPoints, DefaultAttackPoints, DefaultDefensePoints, DefaultEnergyPoints)
        {
            this.CombatHandler = new MageCombatHandler(this);
        }
    }
}
