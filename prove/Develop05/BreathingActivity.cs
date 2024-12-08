public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        int[] breatheInDurations = { 2, 4, 4, 4 };
        int[] breatheOutDurations = { 3, 6, 6, 6 };

        int i = 0;
        while (DateTime.Now < endTime && i < breatheInDurations.Length)
        {
            Console.Write("\nBreathe in...");
            ShowCountDown(breatheInDurations[i]);

            Console.WriteLine();
            Console.Write("Breathe out...");
            ShowCountDown(breatheOutDurations[i]);
            if (DateTime.Now >= endTime) break;

            Console.WriteLine();
            i++;
        }
        Console.WriteLine();
        DisplayEndingMessage();
        Console.Clear();
    }
}
