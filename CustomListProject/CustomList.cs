using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T> 
    {
        T item;
        int count;
        int capacity;
        T[] itemArray;

        CustomList()
        {
            capacity = 4;
            itemArray = new T[capacity];

        }

        public void Add(T item)
        {
            itemArray[0] = item;
            itemArray[1] = item;

 
           

        }




        public void CreatedList()
        {
            CustomList<string> names = new CustomList<string>{ "Sam", "Pete", "Pat" };
        }



        //public void Count()
        //{

        //}
    }
}
