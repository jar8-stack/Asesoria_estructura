using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_datos
{
    public class MyArray<T>
    {
        private T[] array;

        // Propiedad que devuelve la longitud del arreglo
        public int Length
        {
            get { return array.Length; }
        }

        // Constructor que inicializa el arreglo con un tamaño específico
        public MyArray(int size)
        {
            array = new T[size];
        }

        // Índexador para acceder a los elementos del arreglo
        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

        // Método para obtener el índice de un elemento en el arreglo
        public int IndexOf(T item)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (EqualityComparer<T>.Default.Equals(array[i], item))
                {
                    return i;
                }
            }
            return -1;
        }

        // Método para determinar si el arreglo contiene un elemento específico
        public bool Contains(T item)
        {
            return IndexOf(item) != -1;
        }

        // Método para insertar un elemento en una posición específica del arreglo
        public void Insert(int index, T item)
        {
            if (index < 0 || index >= array.Length)
            {
                throw new IndexOutOfRangeException();
            }

            T[] newArray = new T[array.Length + 1];
            for (int i = 0, j = 0; i < newArray.Length; i++, j++)
            {
                if (i == index)
                {
                    newArray[i] = item;
                    j--;
                }
                else
                {
                    newArray[i] = array[j];
                }
            }
            array = newArray;
        }

        // Método para eliminar un elemento en una posición específica del arreglo
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= array.Length)
            {
                throw new IndexOutOfRangeException();
            }

            T[] newArray = new T[array.Length - 1];
            for (int i = 0, j = 0; i < newArray.Length; i++, j++)
            {
                if (j == index)
                {
                    j++;
                }
                newArray[i] = array[j];
            }
            array = newArray;
        }


        // Método para limpiar el arreglo, eliminando todos los elementos
        public void Clear()
        {
            array = new T[0];
        }
    }
}
