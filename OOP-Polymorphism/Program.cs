namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape p = new Circle();
            p.Display();
            p.Draw();
            //p.Print();
            Console.WriteLine("==============");
            p = new Rectangle();
            p.Display();
            p.Draw();
            p.Print();
            Console.WriteLine("==============");
            Rectangle p1 = new Rectangle();
            p1.Print();

        }
    }
}
