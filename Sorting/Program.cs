using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = {'a','t','b','z','s','q','l','c','h'};
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = 0; j < arr.Length-1; j++)
                {
                    if (arr[j]>arr[j+1])
                    {
                        char tempVar = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tempVar;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]+" ");
            }
        }
    }
}
