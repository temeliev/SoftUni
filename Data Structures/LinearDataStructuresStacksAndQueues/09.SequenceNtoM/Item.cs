namespace _09.SequenceNtoM
{
    public class Item
    {
        public Item(int value, Item item)
        {
            this.Value = value;
            this.NextItem = item;
        }

        public int Value { get; private set; }
        public Item NextItem { get; set; }
    }
}
