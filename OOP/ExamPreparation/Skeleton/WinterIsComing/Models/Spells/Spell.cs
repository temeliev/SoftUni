namespace WinterIsComing.Models.Spells
{
    using WinterIsComing.Contracts;

    public abstract class Spell : ISpell
    {
        protected Spell(int damage, int energyCost)
        {
            this.Damage = damage;
            this.EnergyCost = energyCost;
        }

        public int Damage { get; protected set; }

        public int EnergyCost { get; protected set; }
    }
}
