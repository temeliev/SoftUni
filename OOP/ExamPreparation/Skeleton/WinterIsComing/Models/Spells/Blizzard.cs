namespace WinterIsComing.Models.Spells
{
    public class Blizzard : Spell
    {
        private const int DefaultEnergyConst = 40;
        public Blizzard(int damage)
            : base(damage, DefaultEnergyConst)
        {
        }
    }
}
