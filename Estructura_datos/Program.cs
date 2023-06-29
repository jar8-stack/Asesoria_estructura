using System;

namespace Estructura_datos // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyArray<int> arrayInt = new MyArray<int>(5);




            arrayInt.Insert(0, 5);
            arrayInt.Insert(1, 3);
            arrayInt.Insert(2, 2);
            arrayInt.Insert(3, 1);
            arrayInt.Insert(4, 4);

            arrayInt.RemoveAt(5);
            arrayInt.RemoveAt(6);
            arrayInt.RemoveAt(7);
            arrayInt.RemoveAt(6);
            arrayInt.RemoveAt(5);


            for (int i = 0; i < arrayInt.Length; i++) {
                Console.WriteLine(arrayInt[i].ToString()); 
            }

            
        }
    }
}