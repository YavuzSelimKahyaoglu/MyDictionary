using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> myDictionary = new MyDictionary<string>();

            

            myDictionary.Add("armut","pear");
            myDictionary.Add("elma", "apple");

            Console.WriteLine(myDictionary.Count());


        }
    }
}
