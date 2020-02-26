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
        public int capacity;
        T[] itemArray;
        public T item;
     

        public CustomList()
        {

            capacity = Capacity(capacity);
            itemArray = new T[capacity];
 
        }
        public T this[int index]
        {
            get
            {
                return itemArray[index];
                
            }
            set
            {
                itemArray[index] = value;
            }

        }

        public void Add(T item)
        {
            itemArray[count] = item;
            count++;

        }

        //public void Capacity(int item)
        //{
        //    capacity = item;
        //    capacity++;
        //}
        public int Capacity(int item)
        {
            capacity = item;
            for (item = 4; item >= 4;)
            {
                item = capacity * 2;
                
            }
            return item;
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
