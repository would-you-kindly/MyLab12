namespace Custom.Collections.List
{
    public class CustomListPoint<T>
    {
        public T Item { get; set; }
        public CustomListPoint<T> Next { get; set; }

        public CustomListPoint(T item)
        {
            Item = item;
            Next = null;
        }
    }
}
