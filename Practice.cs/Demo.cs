using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manoj.Practice.cs
{
    class Demo
    {
        [Test]
        public void Array()
        {
            string str = "abcd";
            
            for (int i = 0; i < str.Length; i++)
            {
                for(int j = 0; j < str.Length; j++)
                {

                
                    char[] arr = str.ToCharArray();
                    char temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    
                    Console.WriteLine(arr);
                }
            }
        }
    }
}

