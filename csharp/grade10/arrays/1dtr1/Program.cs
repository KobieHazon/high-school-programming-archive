using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void newarray(int[] array1, int[] array2)
        {
            int[] newarray = new int[array1.Length + array2.Length];
            int i = 0;
            for (i = 0; i < array1.Length; i++)
            {
                newarray[i] = array1[i];
            }
            for (int j = 0; j < array2.Length; j++)
            {
                newarray[i] = array2[j];
            }
            
        }

        static void Main(string[] args)
        {
            
        }
    }
}

/* כתוב תכנית  שקולטת 2 מערכים שמספר איבריהם לא שווה. מציגה מערך חדש המכיל את האיברים המשותפים לשני מערכים . */
