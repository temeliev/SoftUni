namespace WinterIsComing.Models.CombatHandlers
{
    using System.Collections.Generic;
    using System.Linq;

    using WinterIsComing.Contracts;
    using WinterIsComing.Core.Exceptions;
    using WinterIsComing.Models.Spells;

    public class MageCombatHandler : CombatHandler
    {
        private int spellCounter;

        public MageCombatHandler(IUnit unit)
            : base(unit)
        {
            this.spellCounter = 2;
        }

        public override IEnumerable<IUnit> PickNextTargets(IEnumerable<IUnit> candidateTargets)
        {
            var targets = candidateTargets.OrderByDescending(x => x.HealthPoints).ThenBy(x => x.Name).Take(3);

            return targets;
        }

        public override ISpell GenerateAttack()
        {
            Spell spell;
            if (this.spellCounter % 2 == 0)
            {
                spell = new FireBreath(this.Unit.AttackPoints);
            }
            else
            {
                spell = new Blizzard(this.Unit.AttackPoints * 2);
            }

            if (spell.EnergyCost > this.Unit.EnergyPoints)
            {
                throw new NotEnoughEnergyException(string.Format("{0} does not have enough energy to cast {1}", this.Unit.Name, spell.GetType().Name));
            }

            this.spellCounter++;
            this.Unit.EnergyPoints -= spell.EnergyCost;

            return spell;
        }
    }
}
