class Breathing : BaseActivity
{
    public Breathing (string description) : base("Breathing", description)
    {
        
    }

    public void RunActivity()
    {
        StartActivity();
        RunCountDown("Breathe in", 4);
        RunCountDown("Breathe out", 4);
    }
}