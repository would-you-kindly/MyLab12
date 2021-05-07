namespace Custom.Collections.JavaList
{
    public class CustomLink<T>
    {
        public T Item { get; set; }
        public CustomLink<T> Next { get; set; }

        public CustomLink(T item)
        {
            Item = item;
            Next = null;
        }

        public override string ToString()
        {
           return "{" + Item.ToString() + "}\n";
        }
    }
}
