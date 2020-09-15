using System;
using System.Collections.Generic;
using System.Text;

namespace NowCoderSources
{
    public class MingmingsRandomNumber
    {
        StreamReader rd = File.OpenText(@"C:\Users\Administrator\Desktop\jiaodianzuobiao.txt");
        string s = rd.ReadLine();
        int n = 0;
                Scanner myScanner = new Scanner(System.in);
                n = myScanner.nextInt();
                int[] myArr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    myArr[i] = myScanner.nextInt();
                }

                test(myArr);
                for (int i:myArr)
                {
                    if (i != 0)
                    {
                        System.out.println(i);
                    }
                }
            }

            public static void test(int[] arr)
{
    int len = arr.length;
    for (int i = 0; i < len; i++)
    {
        int temp = i;
        int tempmin = i;
        int exchange = 0;
        if (arr[i] != 0 && i != len - 1)
        {
            for (int j = i + 1; j < len; j++)
            {
                if (arr[j] != 0)
                {
                    if (arr[j] == arr[temp] || arr[j] == arr[tempmin])
                    {
                        arr[j] = 0;
                    }
                    else if (arr[j] < arr[tempmin])
                    {
                        tempmin = j;
                    }
                }
            }
            exchange = arr[temp];
            arr[temp] = arr[tempmin];
            arr[tempmin] = exchange;
        }
    }
}