namespace Read_onlyAutoProperties_Init_OnlyProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj1 = new MyClass { x = 1 };
            Console.WriteLine($"x:{obj1.x},y: {obj1.y}"); //x:1,y:20
            //obj.x = 10; //error
            //obj.y = 20; //error
            MyClass obj2 = new MyClass();
            Console.WriteLine($"x:{obj2.x},y: {obj2.y}"); //x:10,y:20
            MyClass obj3 = new MyClass(30, 50);
            Console.WriteLine($"x:{obj3.x},y:{obj3.y}"); //x:30,y:50
            Console.ReadLine();
        }
    }
}
