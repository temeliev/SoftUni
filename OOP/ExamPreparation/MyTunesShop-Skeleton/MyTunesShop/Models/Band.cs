namespace MyTunesShop.Models
{
    using System.Collections.Generic;

    using MyTunesShop.Interfaces;

    public class Band : Performer, IBand
    {
        public Band(string name)
            : base(name)
        {
            this.Members = new List<string>();
        }

        public IList<string> Members { get; private set; }

        public void AddMember(string memberName)
        {
            this.Members.Add(memberName);
        }

        public override PerformerType Type
        {
            get
            {
                return PerformerType.Band;

            }
        }

    }
}
