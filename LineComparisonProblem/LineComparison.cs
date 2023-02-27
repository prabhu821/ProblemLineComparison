using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem;

public class LineComparison
{
    int x1, x2, y1, y2;
    public LineComparison(int x1, int x2, int y1, int y2)
    {
        this.x1 = x1;
        this.x2 = x2;
        this.y1 = y1;
        this.y2 = y2;
    }
    public void CalculateLength()
    {
        double length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        Console.WriteLine("Length :- " + length);
        Console.WriteLine("\n");
    }
    public double Calculate()
    {
        double length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        Console.WriteLine("Length of lines: " + length);
        return length;
    }
}
