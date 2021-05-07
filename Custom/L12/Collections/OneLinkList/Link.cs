namespace Custom.L12.Collections.OneLinkList
{
    public class Link<T>
    {
        public T Item { get; set; }
        public Link<T> Next { get; set; }

        public Link(T item)
        {
            Item = item;
            Next = null;
        }
    }
}
