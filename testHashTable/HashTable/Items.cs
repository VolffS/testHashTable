using System;
using System.Collections.Generic;
using System.Text;

namespace testHashTable.Chaining_Method
{
    class OpenItems<Tkey,Tvalue>
    {
        public Tvalue value;
        public Tkey key { get; set; }
        /// <summary>
        /// Показатель до следующего элемента по этой хэшфункции
        /// </summary>
        public int qount=0;
        /// <summary>
        ///  Показатель до следующего элемента, если элемент занят числом попавшим сюда по методу очереди
        /// </summary>
        public int realQount = 0;
        public bool delete = true;
        
    }

    class Node<Tkey,Tvalue>
    {
        public Tvalue value;
        public Tkey key { get; set; }
    }
    class ChainingItems<Tkey, Tvalue>
    {
        public List<Node<Tkey, Tvalue>> Nodes;
        public ChainingItems()
        {
            Nodes = new List<Node<Tkey, Tvalue>>();
        }
    }
}
