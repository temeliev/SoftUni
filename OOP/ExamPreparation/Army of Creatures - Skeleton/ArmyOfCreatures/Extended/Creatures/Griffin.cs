namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Logic.Creatures;
    using ArmyOfCreatures.Logic.Specialties;

    public class Griffin : Creature
    {
        private const int DefaultAttack = 8;
        private const int DefaultDefense = 8;
        private const int DefaultHealth = 25;
        private const decimal DefaultDamage = 4.5M;
        private const int DefaultDefensePointsWhenSkip = 3;
        private const int DefaultDoubleDefenseRounds = 5;

        public Griffin()
            : base(DefaultAttack, DefaultDefense, DefaultHealth, DefaultDamage)
        {
            this.AddSpecialty(new DoubleDefenseWhenDefending(DefaultDoubleDefenseRounds));
            this.AddSpecialty(new AddDefenseWhenSkip(DefaultDefensePointsWhenSkip));
            this.AddSpecialty(new Hate(typeof(WolfRaider)));
        }
    }
}
