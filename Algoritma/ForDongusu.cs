using System;
using System.Collections.Generic;
using System.Text;

namespace Sayilar
{
    class ForDongusu
    {
        public static bool TekSayilariGoster(int a)
        {
            if (a % 2 == 1)
            {
                return true;
            }
            else
            {
                return false;
            }


            
        }
        public static bool KatiMi(int n,int x)
        {
            if (n % x == 0 && n!=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
