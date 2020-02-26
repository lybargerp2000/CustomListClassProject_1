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
        public T removeItem;
        
     

        public CustomList()
        {
            capacity = 4;
            //capacity = Capacity(capacity);
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
            IncreaseCapacity();

        }
        public void Remove(T item)
        {
            T[] newArray = new T[count];
            for (int i =0; i < itemArray.Length; i++)
            {
               if(itemArray[i].Equals(item))
                {
                    continue;
                }
                else
                {
                    //Build using created Add method
                    newArray[i] = itemArray[i];
                }
                
                newArray[i] = itemArray[i];
                
            }

        }
        

        public void IncreaseCapacity()
        {
            if (count == capacity)
            {
                capacity = capacity * 2;
                T[] newArray = new T[capacity];
                for (int index = 0; index < itemArray.Length; index++)
                {
                    newArray[index] = itemArray[index];
                    Console.WriteLine(newArray[index]);
                }
                itemArray = newArray;
            }
           


        }
        public void DecreaseCapacity()
        {
            if (count == capacity)
            {
                capacity = capacity / 2;
                T[] newArray = new T[capacity];
                for (int index = 0; index > itemArray.Length; index--)
                {
                    newArray[index] = itemArray[index];
                    Console.WriteLine(newArray[index]);
                }
                itemArray = newArray;
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
