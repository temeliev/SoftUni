namespace MusicShop.Models
{
    using System.Text;

    using MusicShopManager.Interfaces;

    public class AcousticGuitar : Guitar, IAcousticGuitar
    {
        public AcousticGuitar(string make,
            string model,
            decimal price,
            string color,
            string bodyWood,
            string fingerboardWood,
            bool caseIncluded,
            StringMaterialType stringMaterial)
            : base(make, model, price, color, false, bodyWood, fingerboardWood)
        {
            this.CaseIncluded = caseIncluded;
            this.StringMaterial = stringMaterial;
        }

        public bool CaseIncluded { get; private set; }

        public StringMaterialType StringMaterial { get; private set; }

        public override string ToString()
        {
            var guitar = new StringBuilder();
            guitar.Append(base.ToString())
                .AppendFormat("Case included: {0}", this.CaseIncluded ? "yes" : "no")
                .AppendLine()
                .AppendFormat("String material: {0}", this.StringMaterial)
                .AppendLine();
                 
            return guitar.ToString();
        }
    }
}
