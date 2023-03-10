internal class Program
{
    private static void Main(string[] args)
    {
        Elephant lucinda = new Elephant() { name = "Lucinda", earsize = 33 };
        Elephant lloyd = new Elephant() { name = "Lloyd", earsize = 40 };
        Console.WriteLine("Press 1 for " + lloyd.name + ", 2 for " + lucinda.name + ", 3 to swap, or Q to quit:");

        while (true)
        {
            char input = Console.ReadKey(true).KeyChar;
            Console.WriteLine("You pressed " + input);
            if (input == '1')
            {
                Console.WriteLine("Calling lloyd.WhoAmI()");
                lloyd.WhoAmI();
            }
            else if (input == '2')
            {
                Console.WriteLine("Calling lucinda.WhoAmI()");
                lucinda.WhoAmI();
            }
            else if (input == '3')
            {
                Elephant holder;
                holder = lloyd;
                lloyd = lucinda;
                lucinda = holder;
                Console.WriteLine("References have been swapped.");
            }
            // example of reference changing an object without working through other reference
            else if (input == '4')
            {
                lloyd = lucinda;
                lloyd.earsize += 4321;
                lloyd.WhoAmI();
            }
            else if (input == '5')
            {
                lucinda.SpeakTo(lloyd, "Wassup, Lloyd!");
            }
            else if (input == 'q' || input == 'Q') return;
            else Console.WriteLine("Not a valid input.");
            Console.WriteLine();
        }
    }
}

class Elephant
{
    public int earsize;
    public string? name;

    public void WhoAmI()
    {
        Console.WriteLine("My name is " + name + ".");
        Console.WriteLine("My ears are " + earsize + " inches tall.");
    }
    // method to hear a message
    public void HearMessage(string message, Elephant whosaidit)
    {
        Console.WriteLine(name + " received a message");
        Console.WriteLine(whosaidit.name + " said this: " + message);
    }
    // method to speak a message
    public void SpeakTo(Elephant talkto, string message)
    {
        talkto.HearMessage(message, this);
    }
}