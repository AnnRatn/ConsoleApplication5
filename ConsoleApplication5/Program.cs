using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {

        static void dem1025()
        {
            Console.WriteLine("Задача № 1025. Демократия в опасности");
            int k, t = 0, s = 0;
            k = Convert.ToInt32(Console.ReadLine());
            int[] m = new int[k];
            for(int i = 0; i < k; i++)
            {
                m[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < k - 1; i++)
            {
                for (int j = i + 1; j < k; j++)
                {
                    if (m[i] > m[j])
                    {
                        t = m[i];
                        m[i] = m[j];
                        m[j] = t;
                    }
                }
            }
            for (int i = 0; i < (k / 2 +1); i++)
            {
                s = s + (m[i] / 2 + 1);
            }
            Console.WriteLine("Минимальное количество человек= " + s);
        }


        static void des1209()
        {
            Console.WriteLine("Задача № 1209. 1, 10, 100, 1000...");
            int N, K;
            N = Convert.ToInt32(Console.ReadLine());
            int[] m = new int[N];
            for (int i = 0; i < N; i++)
            {
                K = Convert.ToInt32(Console.ReadLine());
                int x = 0;
                while (K > 0)
                {
                    x++;
                    K = K - x;
                }
                K = K + x;
                if (K == 1) m[i] = 1;
                else m[i] = 0;
            }
            for (int i = 0; i < N; i++)
                Console.WriteLine(m[i] + " ");
        }


        static void Main(string[] args)
        {
            dem1025();
            des1209();
            int a;
            a = Convert.ToInt32(Console.ReadLine());
        }
    }
}
