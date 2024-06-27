public class LinkedList
{
    private Node first;
    private Node last;
    private class Node
    {
        private int value;
        private Node next;

        public Node(int value)
        {
            this.value = value;
        }

        private Node Next { get => next; set => next = value; }

        public void setNextNode(Node node) { // Çözüm
            this.next = node;
        }
    }

    public void addLast(int item)
    {
        Node node = new Node(item);

        // Check if the list is empty
        if (first == null)
        {
            first = last = node;
        }
        else
        {
            last.setNextNode(node); // Hatayı aldığım satır "last.next = node;"
            last = node;
        }
    }

    

    // addFirst
    // addLast
    // deleteFirst
    // deleteLast
    // contains
    // indexOf

    public void addFirst(int item)
    {
        if (first != null)
        {
            first.setNextNode() 
        }
    }

    public void print()
    {
        
    }

    //public void addFirst(int value)
    //{
    //    Node newNode = new Node(value);

    //    newNode.
    //}
}
