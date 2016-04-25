using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitNumberInClass
{
    class Chemistry : InputClass
    {
        public void ChemiNum(int a)
        {
            int num = 1;
            int MyNumber = Attandance(a);
            if (MyNumber == int.Parse(DateTime.Today.ToString("dd"))) Console.WriteLine("今日最初にあたるぜ。よかったな");
            else
            {
                for (int i = 0; i < CNumbers.Count; i++)
                {
                    if (CNumbers[i] == MyNumber) num = i + 1;
                }
                Console.WriteLine("{0}番目にあたるよ", num);
            }
        }
    }
}
