namespace WinterIsComing.Models.Spells
{
    public class Stomp : Spell
    {
        private const int DefaultEnergyConst = 10;
        public Stomp(int damage)
            : base(damage, DefaultEnergyConst)
        {
        }
    }
}
