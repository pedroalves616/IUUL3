using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace ATV3
{
    internal class Armstrong
    {
        internal static bool IsArmstrong(int num)
        {
            int  temp =0 , sum = 0, rem;


            while (num > 0)
            {
                rem = num % 10;
                sum = sum + rem * rem * rem;
                num = num / 10;
            }

            return temp == sum ? true : false;


        }
    }
}
