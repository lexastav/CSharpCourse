using System;

namespace Slide01
{
	class Program
	{
		static void Main()
		{


		}
		static string RemoveWhiteSpace(string text)
        {
			int charInd = 0;
			while (char.IsWhiteSpace(text[charInd]))
			{
				if (charInd == text.Length - 1)
					return "";
				charInd++;
			}
			return text.Substring(charInd++);
		}
		static void PowOfTwo()
        {
			var input = Console.ReadLine();
			int pow = 0;
			int number = int.Parse(input);
			int result = 1;
			while (true)
			{
				result = (int)Math.Pow(2, pow);
				pow++;
				if (result > number)
					break;
			}
			Console.WriteLine(result);
		}
		static bool ShouldFire(bool enemyInFront, string enemyName, int robotHealth)
		{
			bool shouldFire = true;
			if (enemyInFront == true)
			{
				if (enemyName == "boss")
				{
					if (robotHealth < 50) shouldFire = false;
					if (robotHealth > 100) shouldFire = true;
				}
			}
			else
			{
				return false;
			}
			return shouldFire;
		}
		static bool ShouldFire2(bool enemyInFront, string enemyName, int robotHealth)
		{
			return enemyInFront && enemyName != "boss" || (enemyInFront && enemyName == "boss" && robotHealth > 49);
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