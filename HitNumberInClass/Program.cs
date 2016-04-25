using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitNumberInClass
{
    class Program
    {
        static void Main(string[] args)
        {
            InputClass input = new InputClass();
            Chemistry chem = new Chemistry();
            EnglishB eb = new EnglishB();
            Console.WriteLine("英語B:1,化学:2");
            int choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    input.EngBIn();
                    eb.EBNum(input.ClassCount);
                    break;
                case 2:
                    input.ChemiIn();
                    chem.ChemiNum(input.ClassCount);
                    break;
                default:
                    Console.WriteLine("その値は未実装");
                    break;
            }
        }
    }
}
