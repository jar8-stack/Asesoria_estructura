using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_datos
{
    public class MyStack<T>
    {
        private List<T> stack;

        // Propiedad que indica si la pila está vacía
        public bool IsEmpty
        {
            get { return stack.Count == 0; }
        }

        // Constructor que inicializa la pila vacía
        public MyStack()
        {
            stack = new List<T>();
        }

        // Método para apilar un elemento en la parte superior de la pila
        public void Push(T item)
        {
            stack.Add(item);
        }

        // Método para desapilar y devolver el elemento en la parte superior de la pila
        public T Pop()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            int lastIndex = stack.Count - 1;
            T item = stack[lastIndex];
            stack.RemoveAt(lastIndex);
            return item;
        }

        // Método para obtener el elemento en la parte superior de la pila sin desapilarlo
        public T Peek()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            return stack[stack.Count - 1];
        }

        // Método para limpiar la pila, eliminando todos los elementos
        public void Clear()
        {
            stack.Clear();
        }
    }
}
