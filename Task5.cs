// В задании сказано минимум два класса, поэтому вот так

using System;
using System.Collections.Generic;
using System.Linq;


namespace Task5_ConsoleApp1
{
    class Massiv
    {
        private int[] elem; //массив с элементами
        private int N;
        public Massiv(int n)
        {
            elem = new int[n];
            N = n;
        }
        public void Filling() //Заполнение массива
        {
            Console.WriteLine("Fill this array [{0}]:", N);
            for(int i=0; i<N; i++)
            {
                Console.WriteLine("Elem №{0}=", i+1);
                elem[i]= int.Parse(Console.ReadLine());
            }
        }
        public string Sum_more_max() //Нахождение первой тройки элементов, сумма которых больше максимального числа
        {
            int max = elem.Max();
            Func<int, int, int, int> sum = (int x, int y, int z) => x + y+z;

            string str = "";
            for(int i=0; i<N-2; i++)
            {
                if (sum(elem[i], elem[i + 1], elem[i + 2]) > max)
                {
                    str += elem[i]; str += " "; str += elem[i + 1]; str += " "; str += elem[i + 2];
                    return str;
                }
            }
            return "no elements";
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            int n = Num();
            Massiv mas=new Massiv(n);
            mas.Filling();
            Console.WriteLine("Elements, which sum > max: {0}",mas.Sum_more_max());

            Console.ReadKey();
        }

        public static int Num()
        {
            int n = 0;
            for (; ; )
            {
                Console.WriteLine("Enter the number of elements: ");
                n = int.Parse(Console.ReadLine());
                if (n >= 3) break;
                else Console.WriteLine("Enter again (your number shoulb be > 2)\n\n");
            }
            return n;
        }
    }
}
