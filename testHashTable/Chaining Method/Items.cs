using System;
using System.Collections.Generic;
using System.Text;

namespace testHashTable.Chaining_Method
{
    class OpenItems<Tkey,Tvalue>
    {
        public Tvalue openItem;
        public Tkey key { get; set; }
        public int q=0;
        public bool delete;
        
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
