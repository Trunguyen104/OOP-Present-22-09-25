namespace ExtensionMethod
{
    static class Utils
    {
        public static int Add(int a, int b) { return a + b; }

        public static int Sub(this int a, int b) { return a - b; }
        //public static int Increase(this int a)
        //{
        //    return a + 1;
        //}

        //public static string ToUpperFirst(this string str)
        //{
        //    return char.ToUpper(str[0]) + str.Substring(1);
        //}

    }
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3, y = 2;
            int r = Utils.Add(x, y);
            Console.WriteLine("{0}+{1}={2}", x, y, r);
            r = x.Sub(y);
            Console.WriteLine($"{x}-{y}={r}");

            ////Ex1
            //r = x.Increase(); // Utils.Increase(x);
            //Console.WriteLine(r);

            ////Ex2
            //string name = "prn212";
            //Console.WriteLine(name.ToUpperFirst());
            //// <=> Utils.ToUpperFirst(name
            Console.ReadLine();
        }
    }
}
