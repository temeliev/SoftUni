namespace WinterIsComing.Models
{
    using System.Collections.Generic;

    using WinterIsComing.Contracts;

    public class ExtendedUnitAffector : IUnitEffector
    {
        public void ApplyEffect(IEnumerable<IUnit> units)
        {
            foreach (var unit in units)
            {
                unit.HealthPoints += 50;
            }
        }
    }
}
