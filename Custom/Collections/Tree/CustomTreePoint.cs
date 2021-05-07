namespace Custom.Collections.Tree
{
    public class CustomTreePoint
    {
        public int Item { get; set; }
        public CustomTreePoint Left { get; set; }
        public CustomTreePoint Right { get; set; }

        public CustomTreePoint(int item)
        {
            Item = item;
            Left = null;
            Right = null;
        }
    }
}
