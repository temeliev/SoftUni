namespace WinterIsComing.Models.Units
{
    using System;
    using System.Text;

    using WinterIsComing.Contracts;

    public abstract class Unit : IUnit
    {
        private string name;

        private int range;

        protected Unit(int x, int y, string name, int range, int healthPoints, int attackPoints, int defensePoints, int energyPoints)
        {
            this.X = x;
            this.Y = y;
            this.Name = name;
            this.Range = range;
            this.HealthPoints = healthPoints;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.EnergyPoints = energyPoints;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name of the unit is missing!");
                }

                this.name = value;
            }
        }

        public int Range
        {
            get
            {
                return this.range;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Range cannot be negative!");
                }

                this.range = value;
            }
        }

        public int AttackPoints { get; set; }


        public int HealthPoints { get; set; }

        public int DefensePoints { get; set; }

        public int EnergyPoints { get; set; }

        public ICombatHandler CombatHandler { get; protected set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(">{0} - {1} at ({2},{3})", this.Name, this.GetType().Name, this.X, this.Y)
                .AppendLine();
            if (this.HealthPoints > 0)
            {
                sb.AppendFormat("-Health points = {0}", this.HealthPoints)
                    .AppendLine()
                    .AppendFormat("-Attack points = {0}", this.AttackPoints)
                    .AppendLine()
                    .AppendFormat("-Defense points = {0}", this.DefensePoints)
                    .AppendLine()
                    .AppendFormat("-Energy points = {0}", this.EnergyPoints)
                    .AppendLine()
                    .AppendFormat("-Range = {0}", this.Range);
            }
            else
            {
                sb.Append("(Dead)");
            }

            return sb.ToString().TrimEnd('\n');
        }
    }
}
