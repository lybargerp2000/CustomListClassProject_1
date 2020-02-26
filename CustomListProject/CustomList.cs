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
            T[] newArraay = new T[capacity];
           for (int index = 0; index > itemArray.Length; index--)
            {
                newArraay[index] = itemArray[index];
                Console.WriteLine(newArraay[index]);
            }
            itemArray = newArraay;
            
            count--;
            DecreaseCapacity();
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
