using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{   
    class MyList<T>
    {
            private T[] _items;

            public MyList()
            {
                _items = new T[0];
            }

            public void AddItem(T value)
            {
                Array.Resize(ref _items, _items.Length + 1);
                _items[_items.Length - 1] = value;
            }

            public void ShowItems()
            {
                foreach (T item in _items)
                {
                    Console.WriteLine(item);
                }
            }

        public void RemoveItem()
        {
            Array.Resize(ref _items, _items.Length - 1);
            

        }

        public void Uptadeitem(int index,T value)
        {
           _items[index]  = value;
        }  


    }
}

