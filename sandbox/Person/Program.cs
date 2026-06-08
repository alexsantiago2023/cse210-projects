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

        Doctor doc = new Doctor("PhD", "Sam", "Altman", 66, 175);
        Console.WriteLine(doc.GetDoctorInfo());

        officer.ChangeWeight(10);
        doc.ChangeWeight(25);
        Console.WriteLine(officer.GetPoliceManInfo());
        Console.WriteLine(doc.GetDoctorInfo());
    }
}