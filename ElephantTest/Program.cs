internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

class Elephant
{
    public int earsize;
    public string name;

    public void WhoAmI()
    {
        Console.WriteLine("My name is " + name + ".");
        Console.WriteLine("My ears are " + earsize + " inches tall.");
    }
}