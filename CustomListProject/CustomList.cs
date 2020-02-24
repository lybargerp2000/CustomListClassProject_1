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
        public int Count;

        public void Add(T item)
        {

            T[] itemArray = new T[Count];

        }
        public void CreatedList_AddToList_ValuesCombined()
        {
            CustomList<string> names = new CustomList<string>{ "Sam", "Pete", "Pat" };
        }



        //public void Count()
        //{

        //}
    }
}
