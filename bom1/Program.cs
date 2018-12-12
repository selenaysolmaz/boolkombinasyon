using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bom1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kac adet sayı için tüm T,F kombinasyolarını görmek istersiniz?");
            int n = Convert.ToInt32(Console.ReadLine());
            BoolKom(n);
            Console.ReadKey();
        }
        static void BoolKom(int n)
        {
            BoolKomYrd(" ", n);
        }
        static void BoolKomYrd(string oncekiler, int n)
        {
            if (n > 0)
            {
                BoolKomYrd(oncekiler + "true,", (n - 1));
                BoolKomYrd(oncekiler + "false,", (n - 1));
            }
            else
            {
                Console.WriteLine(oncekiler);
            }
        }
    }
}
