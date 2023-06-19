using System;

namespace CollectionsAndGenerics.Boxing
{
    internal class Boxing
    {
        static public void SimpleBoxUnboxOperation()
        {
            int mylnt = 25;
         
            object boxedlnt = mylnt;

            int unboxedlnt = (int)boxedlnt;


        }

      

    }
}
