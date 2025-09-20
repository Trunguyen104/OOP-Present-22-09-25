namespace OOP_Interface_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            MySample obj = new MySample();
            obj.Display();
            //obj.Print(); //Error

            //Default Implement Method
            ISample.Print();
            ISample sample = obj;
            str = sample.GetString("Jack");
            Console.WriteLine(str);
        }
    }
}
