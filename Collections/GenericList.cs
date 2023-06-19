using System;
using System.Collections;
using System.Collections.Generic;


namespace CollectionsAndGenerics.Collections
{
    internal class GenericList
    {
        static public void UseGenencList()
        {
            Console.WriteLine("*****Fun with Generics * ****\n");

            List<string> morePeople = new List<string>();
            morePeople.Add("Frank");
            Console.WriteLine(morePeople[0]);

            List<int> morelnts = new List<int>();
            morelnts.Add(10);
            morelnts.Add(2);
            int sum = morelnts[0] + morelnts[1];

        }
    }
}
