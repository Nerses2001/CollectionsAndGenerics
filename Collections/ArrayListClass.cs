using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsAndGenerics.Collections
{
    class ArrayListClass
    {
        private ArrayList _strArray = new ArrayList();

        public void ImplArrayLisMethods() 
        {
            _strArray.AddRange(new string[] { "First", "Second", "Third" });

            Console.WriteLine("This collection has {0} items.", _strArray.Count);
            Console.WriteLine();
            
            _strArray.Add("Fourth!");
            Console.WriteLine("This collection has {0} items.", _strArray.Count);

            foreach (string s in _strArray)
            {
                Console.WriteLine("Entry: {0}", s);
            }

        }
    }
}
