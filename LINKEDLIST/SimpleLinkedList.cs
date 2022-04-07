namespace DATASTRUCTURE.LINKEDLIST
{
    public class SimpleLinkedList
    {
        private Node? first;
        private Node? last;

        public void AddLast(int item)
        {
            var node = new Node(item);
            if (first == null)
                first = last = node;
            else
            {
                last.next = node;
                last = node;
            }

        }

        public void AddFirst(int item)
        {
            var node = new Node(item);
            if(isEmpty())
            first = last = node;
            else{
                node.next = first;
                first = node;
            }
        }

        public int IndexOf(int item)
        {
            int index = 0;
            var current = first;
            while(current != null)
            {
                if(current.value == item)  return index;
                current = current.next;
                index++;
               
            }
            return -1;

        }

        public bool Contains(int item)
        {
            return IndexOf(item) != -1;
        }

        public void removeFirst()
        {
            if(isEmpty()) throw new InvalidOperationException("No such element exception");
            if (first == last)
            {
                first = last = null;
                return;
            }
            var second = first.next;
            first.next = null;
            first = second;
        }

        public void removeLast()
        {
            if(isEmpty()) throw new InvalidOperationException("No such element exception");
            if (first == last)
            {
                first = last = null;
                return;
            }
            var previous = getPrevious(last);
            last = previous;
            last.next = null;
        }

        public void ReadAll()
        {
            Node current = first;
            while(current.next != null) {
               var result = current.value;
                Console.WriteLine(result);
                current = current.next;
                //Console.WriteLine(result);
                              
            }
            
        }
        private Node getPrevious(Node node)
        {
            var current = first;
            while (current != null)
            {
                if(current.next == node) return current;
                current = current.next;
            }
            return null;
        }

        private bool isEmpty()
        {
            return first == null;
        }
    }
}