namespace WinterIsComing.Models.CombatHandlers
{
    using System.Collections.Generic;
    using System.Linq;

    using WinterIsComing.Contracts;
    using WinterIsComing.Core.Exceptions;
    using WinterIsComing.Models.Spells;

    public class IceGiantCombatHandler : CombatHandler
    {
        public IceGiantCombatHandler(IUnit unit) : base(unit) { }

        public override IEnumerable<IUnit> PickNextTargets(IEnumerable<IUnit> candidateTargets)
        {
            if (this.Unit.HealthPoints <= 150)
            {
                return candidateTargets.Take(1);
            }

            return candidateTargets;
        }

        public override ISpell GenerateAttack()
        {
            Stomp spell = new Stomp(this.Unit.AttackPoints);

            if (spell.EnergyCost > this.Unit.EnergyPoints)
            {
                throw new NotEnoughEnergyException(string.Format("{0} does not have enough energy to cast {1}", this.Unit.Name, spell.GetType().Name));
            }

            this.Unit.EnergyPoints -= spell.EnergyCost;
            this.Unit.AttackPoints += 5;

            return spell;
        }
    }
}
