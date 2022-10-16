using System;

namespace Task
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var class1 = new Class1();
            var class2 = new Class2();

            Func<int, int, int> func = class1.Pow;

            var predicate = class2.Calc(func, 3, 2);
            var res = predicate.Invoke(2);

            class1.Action.Invoke(res);

            // class1.Action.Invoke(class2.Calc(func, 3, 2).Invoke(2));
        }

        public static void Show(bool item)
        {
            Console.WriteLine(item);
        }
    }
}
