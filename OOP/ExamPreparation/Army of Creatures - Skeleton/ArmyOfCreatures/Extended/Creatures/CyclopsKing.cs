namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Extended.Specialties;
    using ArmyOfCreatures.Logic.Creatures;
    
    public class CyclopsKing : Creature
    {
        private const int DefaultAttack = 17;
        private const int DefaultDefense = 13;
        private const int DefaultHealth = 70;
        private const decimal DefaultDamage = 18M;
        private const int DefaultAttackPointsWhenSkip = 3;
        private const int DefaultDoubleAttackRounds = 4;
        private const int DefaultDoubleDamageRounds = 1;

        public CyclopsKing()
            : base(DefaultAttack, DefaultDefense, DefaultHealth, DefaultDamage)
        {
            this.AddSpecialty(new AddAttackWhenSkip(DefaultAttackPointsWhenSkip));
            this.AddSpecialty(new DoubleAttackWhenAttacking(DefaultDoubleAttackRounds));
            this.AddSpecialty(new DoubleDamage(DefaultDoubleDamageRounds));
        }
    }
}
