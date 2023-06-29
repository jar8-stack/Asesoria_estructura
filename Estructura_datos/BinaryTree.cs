using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_datos
{
    public class TreeNode<T>
    {
        public T Data { get; set; }
        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }
    }

    public class BinaryTree<T>
    {
        public TreeNode<T> Root { get; set; }

        // Constructor que inicializa el árbol binario con un nodo raíz
        public BinaryTree(T data)
        {
            Root = new TreeNode<T>() { Data = data };
        }

        // Método para agregar un nuevo nodo al árbol binario
        public void Add(T data)
        {
            TreeNode<T> newNode = new TreeNode<T>() { Data = data };

            if (Root == null)
            {
                Root = newNode;
            }
            else
            {
                AddRecursive(Root, newNode);
            }
        }

        // Método recursivo auxiliar para agregar un nuevo nodo en el árbol binario
        private void AddRecursive(TreeNode<T> current, TreeNode<T> newNode)
        {
            if (EqualityComparer<T>.Default.Equals(newNode.Data, current.Data))
            {
                // Ignorar si el nodo ya existe en el árbol
                return;
            }
            else if (Comparer<T>.Default.Compare(newNode.Data, current.Data) < 0)
            {
                // Agregar el nuevo nodo en el subárbol izquierdo
                if (current.Left == null)
                {
                    current.Left = newNode;
                }
                else
                {
                    AddRecursive(current.Left, newNode);
                }
            }
            else
            {
                // Agregar el nuevo nodo en el subárbol derecho
                if (current.Right == null)
                {
                    current.Right = newNode;
                }
                else
                {
                    AddRecursive(current.Right, newNode);
                }
            }
        }

        // Método para realizar un recorrido inorden en el árbol binario
        public void InOrderTraversal(Action<T> action)
        {
            InOrderTraversalRecursive(Root, action);
        }

        // Método recursivo auxiliar para el recorrido inorden en el árbol binario
        private void InOrderTraversalRecursive(TreeNode<T> current, Action<T> action)
        {
            if (current != null)
            {
                InOrderTraversalRecursive(current.Left, action);
                action(current.Data);
                InOrderTraversalRecursive(current.Right, action);
            }
        }
    }
}
