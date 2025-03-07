namespace ocp;

class Program
{
    static void Main(string[] args)
    {
        Employee e1 = new Employee(101, "ravi");
        Employee e2 = new Employee(102, "mahesh");
        Console.WriteLine(e1);
        Console.WriteLine(e2);
    }
}
