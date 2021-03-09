using System;
using System.Collections.Generic;
using System.Text;
using testHashTable.Chaining_Method;

namespace testHashTable.HashTable
{
    class OpenAddressingHashTable<Tkey, Tvalue>
    {
        OpenItems<Tkey, Tvalue>[] items;
        private int size;
        private int noNullSize = 0;
        private double maxPostSize = 0.75;
        private int allElements = 0;

        public OpenAddressingHashTable(int size)
        {
            this.size = size;
            Initialization(size);
        }
        private void Initialization(int size)
        {
            items = new OpenItems<Tkey, Tvalue>[size];
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new OpenItems<Tkey, Tvalue>();
            }
        }
        public void Add(Tkey tkey, Tvalue tvalue)
        {
            var index = HashFunction(tkey);
            if (noNullSize> size * maxPostSize)
            {
                Resize();
            }
            else if (allElements > size - 2)
            {
                Rehash();
            }
            if (!index.Equals(HashFunction(items[index].key)) && items[index].realQount == 0)
            {
                for (int qount = 0, backIndex= index; qount < items.Length; qount++, index++, backIndex--)
                {
                    if (index < size)
                    {
                        if (items[index].qount == 0 && items[index].delete == true)
                        {
                            items[index].delete = false;
                            items[index].key = tkey;
                            items[index].value = tvalue;
                            items[index - qount].realQount = qount;
                            noNullSize++;
                            allElements++;
                            return;
                        }
                    }                    
                    if (backIndex > 0)
                    {
                        if (items[backIndex].qount == 0 && items[backIndex].delete == true)
                        {
                            items[backIndex].delete = false;
                            items[backIndex].key = tkey;
                            items[backIndex].value = tvalue;
                            items[backIndex + qount].realQount = 0- qount;
                            noNullSize++;
                            allElements++;
                            return;
                        }
                    }
                    
                }
            } if (!index.Equals(HashFunction(items[index].key)))
            {
                index += items[index].realQount;
            }
            for (int i=0;i<items.Length;i++)
            {
                if (items[index].key.Equals(tkey))
                {
                    items[index].value = tvalue;
                    return;
                }
                else if (items[index].qount != 0)
                {
                    index += items[index].qount;
                }
                else
                    for (int qount = 0, backIndex=index; qount < items.Length; qount++, index++, backIndex--)
                    {
                        if(index < size)
                        {
                            if (items[index].qount == 0 && items[index].delete == true)
                            {
                                items[index].delete = false;
                                items[index].key = tkey;
                                items[index].value = tvalue;
                                items[index - qount].qount = qount;
                                noNullSize++;
                                allElements++;
                                return;
                            }
                        }
                        if (backIndex > 0)
                        {
                            if (items[backIndex].qount == 0 && items[backIndex].delete == true)
                            {
                                items[backIndex].delete = false;
                                items[backIndex].key = tkey;
                                items[backIndex].value = tvalue;
                                items[backIndex + qount].qount = 0 - qount;
                                noNullSize++;
                                allElements++;
                                return;
                            }
                        }
                    }             
            }         
        }
        public Tvalue Find(Tkey tkey)
        {
            var index = Search(tkey);
            if (index!=-1 && items[index].delete == false)
            {
                return items[index].value;
            }
            else
            {
                return default;
            }
        }
        public bool Remove(Tkey tkey)
        {           
            int index = Search(tkey);
            if (index != -1)
            {
                if (items[index].delete == false)
                {
                    items[index].key = default;
                    items[index].value = default;
                    items[index].delete = true;
                    noNullSize--;
                    return true;
                }
            }
            return false;
        }
        private int Search(Tkey tkey)
        {
            int thisQount, BackItems = HashFunction(tkey);
            int index = HashFunction(tkey);
            if (index != HashFunction(items[index].key))
            {
                thisQount = items[index].realQount;
                index += items[index].realQount;
            }
            while (true)          
            {                
                if (HashFunction(items[index].key) != -1 && items[index].key.Equals(tkey) )
                { 
                        return index ;                    
                }
                else if (!(items[index].key.Equals(tkey))&& items[index].qount == 0 )
                {
                    return -1;
                }
                else
                {
                    thisQount = items[index].qount;
                    BackItems = index;
                    index += items[index].qount;
                }                
            }
             
        }
        private void Resize()
        {
            allElements = 0;
            noNullSize = 0;
            size *= 2;
            var temp = this.items;            
            Initialization(size);
            foreach (var item in temp)
            {
                if (item.delete == false)
                {
                    Add(item.key, item.value);
                }                
            }
        }
        private void Rehash()
        {
            allElements = 0;
            noNullSize = 0;
            size += (size/2);
            var temp = this.items;
            Initialization(size);
            foreach (var item in temp)
            {
                if (item.delete == false)
                {
                    Add(item.key, item.value);
                }
            }
        }
        private int HashFunction(Tkey tkey)
        {
            if (tkey == null)
            {
                return -1;
            }
            else
            {
                var key = tkey.GetHashCode() % items.Length;
                if (key < 0)
                {
                    key = 0;
                }
                return key;
            }
        } 
    }
}
