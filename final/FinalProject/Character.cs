public class Character
{
    protected int _health;
    protected string _name;

    protected int _attackDamage;

    public virtual void Attack()
    {
        Console.WriteLine("Character attacks.");
    }

    public virtual void TakeDamage()
    {
        
    }
}