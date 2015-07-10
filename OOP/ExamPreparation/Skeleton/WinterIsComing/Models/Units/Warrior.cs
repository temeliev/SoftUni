namespace WinterIsComing.Models.Units
{
    using WinterIsComing.Models.CombatHandlers;

    public class Warrior : Unit
    {
        private const int DefaultHealthPoints = 180;
        private const int DefaultAttackPoints = 120;
        private const int DefaultDefensePoints = 70;
        private const int DefaultEnergyPoints = 60;
        private const int DefaultRange = 1;

        public Warrior(string name, int x, int y)
            : base(x, y, name, DefaultRange, DefaultHealthPoints, DefaultAttackPoints, DefaultDefensePoints, DefaultEnergyPoints)
        {
            this.CombatHandler = new WarriorCombatHandler(this);
        }
    }
}
