using System;

class Program
{
    static void Main(string[] args)
    {
        Population p1 = new Population(500, "p1");
        Population p2 = new Population(750, "p2");
        Population p3 = new Population(999, "p3");
        Population p4 = new Population(1000, "p4");
        Population p5 = new Population(1001, "p5");
        Population p6 = new Population(2000, "p6");
        p1.Simulate(20);
        p2.Simulate(20);
        p3.Simulate(20);
        p4.Simulate(20);
        p5.Simulate(20);
        p6.Simulate(20);

        Console.ReadKey();
    }
}

class Population
{
    public int Size;
    public string Name;
    public int Change;
    public int Month = 0;

    public Population (int s, string n)
    {
        Size = s;
        Name = n;
    }
        
    public void Simulate(int months)
    {
        Console.WriteLine($"Month {Month}: Population {Name} is starting out with population size {Size}.");
        for (int i = 0; i < months+1; i++)
        {
            if (Size <= 0)
            {
                Console.WriteLine($"Population {Name} is eradicated at month {Month}!");
                break;
            }
            Console.WriteLine(this.ToString());
            Change = (int)Math.Round(0.3 * Size - 300);
            Size += Change;
            Month++;
        }
    }

    public override string ToString()
    {
        return $"Month {Month}: Population {Name} has a size of {Size}";
    }
}