using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            //kullanıcı dizinin sınırını belirlicek, dizi random dolucak,aynı diziyi tersten doldurcaz.
            int a = Convert.ToInt32(Console.ReadLine());
            Random r = new Random();
            int[] dizi = new int[a];
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = r.Next(100);
                Console.WriteLine(dizi[i]);
            }
            for (int i = 0; i < dizi.Length / 2; i++)
            {
                int b = dizi[dizi.Length - 1 - i];
                dizi[dizi.Length - 1 - i] = dizi[i];
                dizi[i] = b;
            }
            Console.WriteLine("********************************");
            foreach (int x in dizi)
            {
                Console.WriteLine(x);
            }
        }
    }
}
