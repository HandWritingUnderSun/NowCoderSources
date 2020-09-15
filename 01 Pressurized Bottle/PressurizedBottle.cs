using System;
using System.Collections.Generic;
using System.Text;

namespace NowCoderSources
{
    public class PressurizedBottle
    {
        public void Solution1()
        {
                int num = 0;
                Scanner myScanner = new Scanner(System.in);
                while (myScanner.hasNextInt())
                {
                    System.out.println(test(myScanner.nextInt()));
                }

            }

            public static int test(int n)
            {
                if (n <= 1)
                    return 0;
                else if (n == 2)
                    return 1;
                else
                    return (int)(n / 3) + test((int)(n / 3) + n % 3);
            }
        }
    }
    }
}
