using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitNumberInClass
{
    class EnglishB : InputClass
    {
        public void EBNum(int a)
        {
            int MyNumber = Attandance(a);
            if (MyNumber == person) Console.WriteLine("今日最初にあたるぜ。よかったな");
            else
            {
                for (int i = 0; i < CNumbers.Count; i++)
                {
                    if (CNumbers[i] == MyNumber) Console.WriteLine("{0}番目にあたるよ", i + 1);
                }
            }
        }
    }
}
