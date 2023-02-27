namespace LineComparisonProblem;

public class Program
{
    static void Main(string[] args)
    {
        //UC1
        Console.WriteLine("Welcome To Line Comparision Problem Statement");
        LineComparison lineComparison = new LineComparison(8, 6, 4, 2);
        lineComparison.CalculateLength();

        //UC2
        LineComparison calculateLength1 = new LineComparison(1, 2, 3, 4);
        double lenght1 = calculateLength1.Calculate();
        LineComparison calculateLength2 = new LineComparison(1, 3, 3, 4);
        double lenght2 = calculateLength2.Calculate();

        if (lenght1.Equals(lenght2))
            Console.WriteLine("Both lines are equal");
        else
            Console.WriteLine("Both Lines are not equal");
        Console.WriteLine("\n");

        //UC3
        LineComparison lineCompare3 = new LineComparison(1, 4, 1, 4);
        double lenght3 = lineCompare3.Calculate();
        LineComparison lineCompare4 = new LineComparison(1, 3, 2, 4);
        double lenght4 = lineCompare4.Calculate();

        if (lenght3.CompareTo(lenght4) == 0)
        {
            Console.WriteLine("Line 1 and Line 2 both are equal");
            return;
        }
        if (lenght3.CompareTo(lenght4) > 0)
            Console.WriteLine("Line 1 is greate than Line 2");
        else
            Console.WriteLine("Line 2 is greater than Line 1");
    }
}