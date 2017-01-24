namespace mszi.Classes
{
    public class Item
    {
        public int Letter { get; set; }
        public int Count { get; set; }
        public Item() { }
        public Item(int l, int c)
        {
            Letter = l;
            Count = c;
        }
    }
}
