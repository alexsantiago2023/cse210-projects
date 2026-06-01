using System.Net.Security;
using System.Reflection.Metadata;

class Program
{
    public static void Main(string[] args)
    {
        //Console.WriteLine("Hello world");

        Person me = new Person("Alex", "Santiago", 22, 180);
        Console.WriteLine(me.GetPersonInfo());

        Police officer = new Police("gun", "Robert", "Hales", 45, 230);
        Console.WriteLine(officer.GetPoliceManInfo());
    }
}