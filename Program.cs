using System;
using static System.Net.Mime.MediaTypeNames;

namespace Task
{

    public delegate void Func(string str);

    internal class Program
    {
        public static void Main()
        {
            Console.Write("Enter string: ");

            var str = Console.ReadLine();
            MyClass cls = new MyClass();
            Func funcDell = new Func(cls.Space);
            Func funcDell2 = new Func(cls.Reverse);


            Run run = new Run();
            run.runFunc(funcDell, str);
            run.runFunc(funcDell2, str);

        }



        public class MyClass
        {
            public void Space(string str)
            {
                str.Select(x => x.ToString()).ToArray();
                foreach (var item in str)
                {
                    Console.Write(item.ToString());
                    Console.Write('_');
                }
            }

            public void Reverse(string str)
            {
                str.Select(x => x.ToString()).ToArray();
                for (int i = str.Length - 1; i >= 0; i--)
                {
                    Console.Write(str[i]);
                }
            }
        }


        public class Run
        {
            public void runFunc(Func func, string str)
            {
                func(str);
            }
        }

    }

}




