using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T>
    {

        T[] value;
        T[] key;
        public MyDictionary()
        {
            value=new T[0];
            key = new T[0];
        }

        public void Add(T value1,T key1)
        {
            T[] tempValue = value;
            T[] tempKey= key;

            value = new T[tempValue.Length+1];
            key = new T[tempKey.Length+1];
            for (int i = 0; i < tempValue.Length; i++)
            {
                value[i] = tempValue[i];
                key[i] = tempKey[i];
            }


            value[value.Length - 1]=value1;
            key[key.Length - 1] = key1;

        }
       
        public int Count()
        {
            return value.Length;
        }

        
    }
}
