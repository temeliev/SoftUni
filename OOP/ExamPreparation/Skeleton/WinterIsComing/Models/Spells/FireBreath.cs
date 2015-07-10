namespace WinterIsComing.Models.Spells
{
    public class FireBreath : Spell
    {
        private const int DefaultEnergyConst = 30;
        public FireBreath(int damage)
            : base(damage, DefaultEnergyConst)
        {
        }
    }
}
