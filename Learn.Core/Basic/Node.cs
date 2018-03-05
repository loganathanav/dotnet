namespace Learn.Core.Basic
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node(int value, Node next)
        {
            this.Value = value;
            this.Next = next;
        }
    }
}