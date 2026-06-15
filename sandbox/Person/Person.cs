abstract class Person
{
    private string _firstName;
    private string _lastName;
    private int _age;
    private int _weight;
    public Person(string firstName, string lastName, int age, int weight)
    {
        _firstName = firstName;
        _lastName = lastName;
        SetAge(age);
        SetWeight(weight);
    }

    public virtual string GetPersonInfo()
    {
        return $"Name: {_firstName} {_lastName}, Age: {_age}, Weight: {_weight}";
    }

    public void ChangeWeight(int update)
    {
        SetWeight(_weight += update);
    }

    public void SetAge(int age)
    {
        _age = age;
        if (age < 0 || age > 115)
        {
            _age = 0;
            Console.WriteLine("Incorrect age");
        }
    }

    public void SetWeight(int weight)
    {
        _weight = weight;
        if (weight < 20 || weight > 300)
        {
            _weight = 0;
            Console.WriteLine("Incorrect weight");
        }
    }

    public abstract double GetSalary();
}