class Menu
{
    public void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Start Breathing Activity");
        Console.WriteLine("  2. Start Reflecting Activity");
        Console.WriteLine("  3. Start Listing Activity");
        Console.WriteLine("  4. Quit");
        Console.Write("Select a choice from the menu: ");
        int input = int.Parse(Console.ReadLine());

        if (input == 1)
        {
            Breathing myBreathing = new Breathing("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
            myBreathing.RunActivity();
        } else if (input == 2)
        {
            Reflecting myReflecting = new Reflecting("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
            myReflecting.RunActivty();
        } else if (input == 3)
        {
            Listing myListing = new Listing("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            myListing.RunActivity();
        } else if (input == 4)
        {
            return;
        }
    }
}