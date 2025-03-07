using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manoj.Programs
{
    class Class
    {
        [Test]
        public void Program()
        {
            string s = "aabbabac";
            char[] ch = s.ToCharArray();
            string res = "";
            bool[] b = new bool[ch.Length];
            for (int i = 0; i < ch.Length; i++)
            {
                if (b[i] == false)
                {
                    int count = 0;
                    for (int j = 0; j < ch.Length; j++)
                    {
                        if (ch[i] == ch[j])
                        {
                            count++;
                            b[j] = true;
                        }
                    }
                    if (count > 1)
                    {
                        Console.WriteLine(ch[i]);
                    }
                }
            }
        }
    }
}

