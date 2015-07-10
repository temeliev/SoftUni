namespace MusicShop.Models
{
    using System.Text;

    using MusicShopManager.Interfaces;

    public class Microphone : Article, IMicrophone
    {
        public Microphone(string make, string model, decimal price, bool hasCable)
            : base(make, model, price)
        {
            this.HasCable = hasCable;
        }

        public bool HasCable { get; private set; }

        public override string ToString()
        {
            var mic = new StringBuilder();
            mic.Append(base.ToString()).AppendFormat("Cable: {0}", this.HasCable ? "yes" : "no").AppendLine();

            return mic.ToString();
        }
    }
}
