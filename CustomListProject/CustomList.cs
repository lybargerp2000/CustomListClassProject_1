using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T> 
    {
        
        public int count;
        int capacity;
        T[] itemArray;
        public T item;

        public CustomList()
        {
            capacity = 4;
            itemArray = new T[capacity];
            Add(item);
        }

        public void Add(T item)
        {
            itemArray[count]= item;
            for (count = 0; count < itemArray.Length; count++)
            {
                Console.WriteLine(item);
            }
            foreach(T items in itemArray)
            {
                Console.WriteLine(items);
            }

        }




        //public void CreatedList()
        //{
        //    CustomList<string> names = new CustomList<string>{ "Sam", "Pete", "Pat" };
        //}



        //public void Count()
        //{

        //}
        //public void Add(T item)
        //{
        //    itemArray[0] = item;

        //    

        //}
    }
}
