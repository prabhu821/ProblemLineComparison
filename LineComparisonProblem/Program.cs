namespace LineComparisonProblem;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome To Line Comparision Problem Statement");
        LineComparison lineComparison = new LineComparison(8, 6, 4, 2);
        lineComparison.CalculateLength();

        LineComparison calculateLength1 = new LineComparison(1, 2, 3, 4);
        double lenght1 = calculateLength1.Calculate();
        LineComparison calculateLength2 = new LineComparison(1, 3, 3, 4);
        double lenght2 = calculateLength2.Calculate();

        if (lenght1.Equals(lenght2))
            Console.WriteLine("Both lines are equal");
        else
            Console.WriteLine("Both Lines are not equal");
    }
}