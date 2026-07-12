public class Player : Character
{
    protected int _gold;
    protected int _xp;
    protected string _weapon;

    public virtual void TakeTurn()
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("1. Attack your enemy");
        Console.WriteLine("2. Drink health potion");
        int input = int.Parse(Console.ReadLine());

        if (input == 1)
        {
            Attack();
        }
    }

    public override void Attack()
    {
        Console.WriteLine($"{_name} swings his sword.");
    }

    public void ViewInventory()
    {
        Console.WriteLine("You have:");
        Console.WriteLine($"{_weapon} (common)");
        Console.WriteLine($"{_gold} gold");
        Console.WriteLine($"{_xp} experience");
    }
}
