using System;
using System.Collections.Generic;
using System.Text;

namespace testHashTable.Chaining_Method
{
    class ChainingHashTable<Tkey,Tvalue>
    {
        ChainingItems<Tkey, Tvalue>[] items;

        public ChainingHashTable(int size)
        {
            items = new ChainingItems<Tkey,Tvalue>[size];
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
        public Tvalue Sheart(Tkey tkey)
        {
            var key = HashFuctions(tkey);
            int index = 0;
            while (true)
            {                
                if (items[key].Nodes[index].key.Equals(tkey))
                {
                    return items[key].Nodes[index].value;                    
                }
                else
                {
                    index++;
                }
            }
        }
        public bool Remove(Tkey tkey)
        {
            var key = HashFuctions(tkey);             
            if (items[key].Nodes.Count != 0)
            {
                for (int i = 0; i < items[key].Nodes.Count; i++)
                {
                    if (items[key].Nodes[i].key.Equals(tkey))
                    {                        
                        items[key].Nodes.RemoveAt(i);
                        return true;
                    }
                }
            }
            return false;
        }
        private int HashFuctions(Tkey tkey)
        {
            return tkey.GetHashCode() % items.Length;
        }
    }
}
