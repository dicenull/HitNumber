using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitNumberInClass
{
    class InputClass
    {
        public int ClassCount { get; set; }
        public int today { get; set; }
        public static List<int> CNumbers = new List<int>();
        public static int person;

        public static int Attandance(int cc)
        {
            Console.Write("出席番号を入力:");
            int MyNumber = int.Parse(Console.ReadLine());
            while (cc < MyNumber)
            {
                Console.Write("もう一度出席番号を入力:");
                MyNumber = int.Parse(Console.ReadLine());
            }
            return MyNumber;
        }

        public void EngBIn()
        {
            Console.Write("クラスの人数:");
            ClassCount = int.Parse(Console.ReadLine());
            Console.Write("始まりの人:");
            person = int.Parse(Console.ReadLine());
            for (int i = 0; i < ClassCount; i++)
            {
                CNumbers.Add(person);
                if (person > ClassCount) person = 1;
                else person++;
            }
            Absence();
        }

        private void Absence()
        {
            Console.WriteLine("欠席者の番号(いない場合0)(カンマ','区切りで入力):");
            string[] abs = Console.ReadLine().Split(',');
            int[] absence = new int[abs.Length];
            for (int i = 0; i < abs.Length; i++) absence[i] = int.Parse(abs[i]);

            //欠席者をバイバイ
            for (int i = 0; i < absence.Length; i++)
            {
                CNumbers.Remove(absence[i]);
            }
        }

        public void ChemiIn()
        {
            int i;
            Console.Write("クラスの人数:");
            ClassCount = int.Parse(Console.ReadLine());
            today = int.Parse(DateTime.Today.ToString("dd"));
            int num = today;
            for (i = 0; i < ClassCount; i++)
            {
                CNumbers.Add(num);
                num += 10;
                if (num > ClassCount)
                {
                    num %= 10;
                    num++;
                }
            }
            Absence();
            //いる人たち
            i = 0;
            foreach (int n in CNumbers)
            {
                Console.Write(n + " ");
                i++;
                if (i % 10 == 0) Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("今日は{0}日", today);
            Console.WriteLine();
        }
    }
}
