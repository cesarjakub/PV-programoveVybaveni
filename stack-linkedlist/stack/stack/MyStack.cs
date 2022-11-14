using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    public class MyStack<T>
    {
        private Node<T>? head;
        private int count;
        
        public int Count { get { return count; } set { count = value; } }

        public MyStack()
        {
            head = null;
            count = 0;
        }

        public void Push(T value)
        {
            Node<T> node = new Node<T>(value);
            node.Next = head;
            head = node;
            count++;

        }

        public T? Pop()
        {
            if(head == null)
            {
                throw new StackEmptyException();
            }
            Node<T> node = head;
            head = node.Next;
            return node.Value;
            count--;
        }

        public bool IsEmpty()
        {
            return head == null; 
        }
    }
}