namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Extended.Specialties;
    using ArmyOfCreatures.Logic.Creatures;

    public class WolfRaider : Creature
    {
        private const int DefaultAttack = 8;
        private const int DefaultDefense = 5;
        private const int DefaultHealth = 10;
        private const decimal DefaultDamage = 3.5M;
        private const int DefaultDoubleDamageRounds = 7;

        public WolfRaider()
            : base(DefaultAttack, DefaultDefense, DefaultHealth, DefaultDamage)
        {
            this.AddSpecialty(new DoubleDamage(DefaultDoubleDamageRounds));
        }
    }
}
