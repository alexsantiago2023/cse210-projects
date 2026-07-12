class Menu
{
    public void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Welcome to the Wyld\n");
        Console.WriteLine("Choose your hero:         --         Health     --     Attack    --    Starting Gold");
        Console.WriteLine("1. Sir Orion Eladrius III (Knight)     30                9                   20");
        Console.WriteLine("2. Arcanius Valadriel (Mage)           15                15                  35");
        Console.WriteLine("3. Helveth Elyon (Archer)              20                12                  17");
        int input = int.Parse(Console.ReadLine());

        if (input == 1)
        {
            Knight knight = new Knight("Eladrius");
            knight.TakeTurn();
        }
        else if (input == 2)
        {

        }
    }
}