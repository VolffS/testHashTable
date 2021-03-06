using System;
using System.Collections.Generic;
using System.Text;

namespace testHashTable.Chaining_Method
{
    class ChainingHashTable<Tkey,Tvalue>
    {
        ChainingItems<Tkey, Tvalue>[] items;
        private int lineSize = 6;
        private double maxPostSize = 0.75;
        private int size;
        public ChainingHashTable(int size)
        {
            items = new ChainingItems<Tkey,Tvalue>[size];
            this.size = size;
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new ChainingItems<Tkey,Tvalue>();
            }
        }
        public void Add(Tkey tkey, Tvalue tvalue)
        {
            var key = HashFuctions(tkey);            
            if (items[key].Nodes.Count != 0)
            {
                for (int i = 0; i < items[key].Nodes.Count; i++)
                {
                    if (items[key].Nodes[i].key.Equals(tkey))
                    {
                        items[key].Nodes[i].value = tvalue;
                        return;
                    }
                }
                var item = new Node<Tkey, Tvalue>();
                item.value = tvalue;
                item.key = tkey;
                items[key].Nodes.Add(item);
            }
            else
            {
                var item = new Node<Tkey, Tvalue>();
                item.value = tvalue;
                item.key = tkey;
                items[key].Nodes.Add(item);
            }
        }
        public Tvalue Find(Tkey tkey)
        {
            var key = HashFuctions(tkey);
            var index = Search(tkey);
            if (index >= 0)
            {
                return items[key].Nodes[index].value;
            }
            else
            {
                return default;
            }
        }

        private int Search (Tkey tkey)
        {
            var key = HashFuctions(tkey);
            int index;
            for ( index=0; index < items[key].Nodes.Count; index++)
            {            
                if (items[key].Nodes[index].key.Equals(tkey))
                {
                    return index;
                }
            }
            return -1;
        }

        public bool Remove(Tkey tkey)
        {
            var key = HashFuctions(tkey);
            var index = Search(tkey);
             if (index >= 0)
             {
                items[key].Nodes.RemoveAt(Search(tkey));
                return true;
             }           
             else
             {
                return false;
             }            
        }
        private void Resize()
        {

        }
        private int HashFuctions(Tkey tkey)
        {
            return tkey.GetHashCode() % items.Length;
        }
    }
}
