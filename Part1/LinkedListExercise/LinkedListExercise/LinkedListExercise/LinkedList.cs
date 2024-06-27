public class LinkedList
{
    private Node first;
    private Node last;
    public int count;

    private class Node
    {
        private Node next;
        private int value;
        private int item;

        public Node(int item) //constructor for Node
        {
            this.item = item;
        }

        public Node Next //getter setters for data "next"
        {
            get { return next; }
            set { this.next = next; }
        }

        public int Value //getter setters for data "vext"
        {
            get { return value; }
            set { this.value = value; }
        }


        //public Node(int value)
        //{
        //    this.value = value;
        //}

        //private Node Next { get => next; set => next = value; }

        //public void setNextNode(Node node)
        //{ // Çözüm
        //    this.next = node;
        //}
    }

    // addFirst
    // addLast
    // deleteFirst
    // deleteLast
    // contains
    // indexOf

    public void addLast(int item)
    {
        var node = new Node(item);

        // Check if the list is empty
        if (isEmpty())
        {
            first = last = node;
        }
        else
        {
            ////last.Next;

            last.setNextNode(node) = node; // Hatayı aldığım satır "last.next = node;"
            last = node;
        }

        count++;
    }

    private bool isEmpty()
    {
        return first == null;
    }

    public void addFirst(int item)
    {
        var node = new Node(item);

        if (isEmpty())
            first = last = node;
        else
        {
            node.next = first;
            first = node;
        }

        count++;
    }

    public int indexOf(int item)
    {
        int index = 0;
        var current = first;

        while (current != null)
        {
            if (current.value == item)
            {
                return index;
            }
            current = current.next;
            index++;
        }
        return -1;
    }

    public bool contains(int item)
    {
        return indexOf(item) != -1;
    }

    public void removeFirst()
    {
        if (isEmpty())
        {
            throw new InvalidOperationException("List is empty.");
        }

        if (first == last)
        {
            first = last = null;
            return;
        }
        else
        {
            var second = first.next;
            first.next = null;
            first = second;
        }


        count--;
    }

    public void removeLast()
    {
        if (isEmpty())
        {
            throw new InvalidOperationException("List is empty.");
        }

        if (first == last)
        {
            first = last = null;
            return;
        }
        else
        {
            var previous = getPrevious(last);
            last = previous;
            last.next = null;
        }

        count--;
    }

    private Node getPrevious(Node node)
    {
        var current = first;
        while (current != null)
        {
            if (current.next == last) return current;

            current = current.next;
        }
        return null;
    }

    public int size()
    {
        return count;
    }

    public int[] toArray()
    {
        int[] array = new int[count];
        int index = 0;
        var current = first;

        while (current != null)
        {
            array[index++] = current.value;
            current = current.next;
        }
        return array;
    }

    public LinkedList toLinkedList()
    {
        var list = new LinkedList();

        
    }

    public void reverse()
    {
        var linkedList = new LinkedList();

        linkedList.toArray();







        //while (first != null)
        //{
        //    var buffer = new int[count];
        //    var current = first;
        //    for (int i = 0; i < count; i++)
        //    {
        //        buffer[i] = current.value;
        //        current = current.next;
        //    }

        //    foreach (var item in buffer)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
        
    }


}
