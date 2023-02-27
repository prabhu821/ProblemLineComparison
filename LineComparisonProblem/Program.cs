namespace LineComparisonProblem;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome To Line Comparision Problem Statement");
        LineComparison lineComparison = new LineComparison(8, 6, 4, 2);
        lineComparison.CalculateLength();
    }
}