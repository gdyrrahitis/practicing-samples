namespace LinkedLists
{
    public class Link
    {
        public Link(int value)
        {
            Value = value;
        }

        public int Value { get; set; }
        public Link Next { get; set; }
        public static Link Null => new NullLink(0);

        private class NullLink : Link
        {
            public NullLink(int value) : base(value)
            {
            }
        }
    }
}