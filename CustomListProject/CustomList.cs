﻿using System;
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
            capacity = 4;
            itemArray = new T[capacity];
 
        }


        public void Add(T item)
        {
            itemArray[count] = item;
            count++;

        }


        public T this[int index]
        {
            get
            {
                return itemArray [index];
            }
            set
            {
                itemArray[index] = value;
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
