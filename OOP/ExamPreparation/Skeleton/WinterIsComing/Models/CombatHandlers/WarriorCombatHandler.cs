namespace WinterIsComing.Models.CombatHandlers
{
    using System.Collections.Generic;
    using System.Linq;

    using WinterIsComing.Contracts;
    using WinterIsComing.Core.Exceptions;
    using WinterIsComing.Models.Spells;

    public class WarriorCombatHandler : CombatHandler
    {
        public WarriorCombatHandler(IUnit unit) : base(unit) { }

        public override IEnumerable<IUnit> PickNextTargets(IEnumerable<IUnit> candidateTargets)
        {
            var targets = candidateTargets.OrderBy(x => x.HealthPoints).ThenBy(x => x.Name).Take(1);
            return targets;
        }

        public override ISpell GenerateAttack()
        {
            Cleave spell;
            if (this.Unit.HealthPoints <= 80)
            {
                spell = new Cleave(this.Unit.AttackPoints + (this.Unit.HealthPoints * 2));
            }
            else
            {
                spell = new Cleave(this.Unit.AttackPoints);
            }

            if (this.Unit.HealthPoints > 50 && spell.EnergyCost > this.Unit.EnergyPoints)
            {
                throw new NotEnoughEnergyException(string.Format("{0} does not have enough energy to cast {1}", this.Unit.Name, spell.GetType().Name));
            }

            if (this.Unit.HealthPoints > 50)
            {
                this.Unit.EnergyPoints -= spell.EnergyCost;
            }

            return spell;
        }
    }
}
