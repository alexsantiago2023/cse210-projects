class Program
{
    public static void Main(string[] args)
    {
        //Console.WriteLine("Hello World");

        Circle myCircle = new Circle();
        myCircle.SetRadius(10);
        Console.WriteLine(myCircle.GetArea());
    }
}