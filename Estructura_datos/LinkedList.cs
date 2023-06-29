using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_datos
{
    public class ListNode<T>
    {
        public T Data { get; set; }
        public ListNode<T> Next { get; set; }
    }

    public class LinkedList<T>
    {
        public ListNode<T> Head { get; private set; }
        public ListNode<T> Tail { get; private set; }
        public int Count { get; private set; }

        // Constructor que inicializa la lista enlazada vacía
        public LinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        // Método para agregar un nuevo nodo al final de la lista enlazada
        public void Add(T data)
        {
            ListNode<T> newNode = new ListNode<T>() { Data = data };

            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Tail.Next = newNode;
                Tail = newNode;
            }

            Count++;
        }

        // Método para eliminar un nodo específico de la lista enlazada
        public bool Remove(T data)
        {
            if (Head == null)
            {
                return false;
            }

            if (EqualityComparer<T>.Default.Equals(Head.Data, data))
            {
                Head = Head.Next;
                Count--;
                return true;
            }

            ListNode<T> current = Head;
            while (current.Next != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Next.Data, data))
                {
                    current.Next = current.Next.Next;
                    if (current.Next == null)
                    {
                        Tail = current;
                    }
                    Count--;
                    return true;
                }
                current = current.Next;
            }

            return false;
        }

        // Método para verificar si un valor específico existe en la lista enlazada
        public bool Contains(T data)
        {
            ListNode<T> current = Head;
            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Data, data))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }
    }
}
