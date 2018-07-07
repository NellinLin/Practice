using System;
using System.Collections.Generic;
using System.Linq;

namespace Test_ConsoleApp1
{
    class Conkat
    {
      private List<string> elem=new List<string>();

      public void Add(string a)
        {
            elem.Add(a);
        }
      public void print_el()
        {
            foreach (string item in elem)
                Console.WriteLine(item);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<string> m_str = new List<string>() { "aaa", "bbb", "ccc" };
            int size = m_str.Count();
            Conkat con = new Conkat();
       

            for (int i=0; i<size; i++)
            {
                for(int k=0; k<size; k++)
                {
                    if (i != k)
                    {
                        con.Add(m_str[i] + m_str[k]);
                    }
                }
            }
            con.print_el();
            //Console.ReadKey();
        }
    }
}
