using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_datos
{
    public class MyList<T>
    {
        private T[] items;
        private int count;
        private const int DefaultCapacity = 4;

        // Propiedad que indica la cantidad de elementos en la lista
        public int Count
        {
            get { return count; }
        }

        // Constructor que inicializa la lista vacía con una capacidad inicial predeterminada
        public MyList()
        {
            items = new T[DefaultCapacity];
            count = 0;
        }

        // Constructor que inicializa la lista vacía con una capacidad inicial especificada
        public MyList(int capacity)
        {
            items = new T[capacity];
            count = 0;
        }

        // Método para agregar un elemento al final de la lista
        public void Add(T item)
        {
            if (count == items.Length)
            {
                ResizeArray(items.Length * 2);
            }

            items[count] = item;
            count++;
        }

        // Método para insertar un elemento en una posición específica de la lista
        public void Insert(int index, T item)
        {
            if (index < 0 || index > count)
            {
                throw new IndexOutOfRangeException();
            }

            if (count == items.Length)
            {
                ResizeArray(items.Length * 2);
            }

            Array.Copy(items, index, items, index + 1, count - index);
            items[index] = item;
            count++;
        }

        // Método para eliminar el primer elemento igual al elemento especificado de la lista
        public bool Remove(T item)
        {
            int index = Array.IndexOf(items, item);
            if (index >= 0)
            {
                RemoveAt(index);
                return true;
            }
            return false;
        }

        // Método para eliminar el elemento en una posición específica de la lista
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException();
            }

            Array.Copy(items, index + 1, items, index, count - index - 1);
            items[count - 1] = default(T);
            count--;

            if (count < items.Length / 4)
            {
                ResizeArray(items.Length / 2);
            }
        }

        // Método para obtener el elemento en una posición específica de la lista
        public T Get(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException();
            }

            return items[index];
        }

        // Método para modificar el elemento en una posición específica de la lista
        public void Set(int index, T item)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException();
            }

            items[index] = item;
        }

        // Método para limpiar la lista, eliminando todos los elementos
        public void Clear()
        {
            Array.Clear(items, 0, count);
            count = 0;
        }

        // Método para redimensionar el arreglo interno de la lista
        private void ResizeArray(int newCapacity)
        {
            T[] newArray = new T[newCapacity];
            Array.Copy(items, newArray, count);
            items = newArray;
        }
    }

}
