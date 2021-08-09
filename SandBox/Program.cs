using System;

namespace Slide01
{
	class Program
	{
		static void Main()
		{
		
        }

		private static string GetMinX(int a, int b, int c)
		{

			if (a > 0 || (a == 0 & b == 0 & c == 0) || (a == 0 & b == 0 & c == 2))
			{
				double x = (-1 * b / (2.0 * a));
				return (x).ToString();
			}
			else
			{
				return "Impossible";
			}
		}
		static double GetDescriminant(double a, double b, double c)
        {
			return b * b - 4 * a * c;
        }
		static double GetFirstRoot(double a, double b, double c)
        {
			var discrimenant = GetDescriminant(a, b, c);
			var squareRoot = Math.Sqrt(discrimenant);
			return (-b - squareRoot) / (2 * a);
        }


	}
}