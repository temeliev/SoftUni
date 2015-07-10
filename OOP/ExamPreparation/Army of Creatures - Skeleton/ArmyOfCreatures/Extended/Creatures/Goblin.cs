namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Logic.Creatures;
    
    public class Goblin : Creature
    {
        private const int DefaultAttack = 4;
        private const int DefaultDefense = 2;
        private const int DefaultHealth = 5;
        private const decimal DefaultDamage = 1.5M;

        public Goblin()
            : base(DefaultAttack, DefaultDefense, DefaultHealth, DefaultDamage)
        {
        }
    }
}
