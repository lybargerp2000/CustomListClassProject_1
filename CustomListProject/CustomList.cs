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
        public int index;
        
     

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
            // itemsArrays [ 4, 2, 6, 4, 1 ]
            // .Remove(6) item = 6
            // Result after remove: itemsArray [ 4, 2, 4, 1 ]
            
            T[] newArray = new T[capacity];
            bool isFound = false;

            for (int i =0; i < itemArray.Length; i++)
            {
                if (itemArray[i] == null)
                {
                    break;
                }
                if (itemArray[i].Equals(item))
                {
                    isFound = true;
                    
                }
                if(isFound == true)
                {
                    itemArray[i] = itemArray[i + 1];
                    newArray[i] = itemArray[i];
                    Console.WriteLine(newArray[i]);
                }
                else
                {
                    newArray[i] = itemArray[i];
                    Console.WriteLine(newArray[i]);
                }
              
            }
            itemArray = newArray;
           
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
            if (count == capacity && capacity >= 8)
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
