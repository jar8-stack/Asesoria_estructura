using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_datos
{
    public class MyQueue<T>
    {
        private List<T> queue;

        // Propiedad que indica si la cola está vacía
        public bool IsEmpty
        {
            get { return queue.Count == 0; }
        }

        // Constructor que inicializa la cola vacía
        public MyQueue()
        {
            queue = new List<T>();
        }

        // Método para encolar un elemento al final de la cola
        public void Enqueue(T item)
        {
            queue.Add(item);
        }

        // Método para desencolar y devolver el elemento al frente de la cola
        public T Dequeue()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            T item = queue[0];
            queue.RemoveAt(0);
            return item;
        }

        // Método para obtener el elemento al frente de la cola sin desencolarlo
        public T Peek()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            return queue[0];
        }

        // Método para limpiar la cola, eliminando todos los elementos
        public void Clear()
        {
            queue.Clear();
        }
    }
}
