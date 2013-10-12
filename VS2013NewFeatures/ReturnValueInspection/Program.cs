using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnValueInspection
{
    class Program
    {
        private static void Main(string[] args)
        {
            //以下の2行にブレークポイントを置く
            //ブレークしたらStepIn(F11)する
            Method1(); 
            int y = Method2(); 
        }

        static void Method1()
        {
            //StepOut(F10)を2回押して、メソッドの最後に移動
            int result = Multiply(FourTimes(Five()), Six());
            //自動変数Viewで返り値が確認できる
        }

        static int Method2()
        {
            return Five();
        }

        static int Multiply(int x, int y)
        {
            return x * y;
        }

        static int FourTimes(int x)
        {
            return 4 * x;
        }

        static int Five()
        {
            return 5;
        }

        static int Six()
        {
            return 6;
        }
    }
}
