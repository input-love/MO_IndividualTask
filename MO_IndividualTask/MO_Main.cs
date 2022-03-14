using System;

namespace MO_IndividualTask
{
    internal class MO_Main
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Dichotomy:");
			Search dichotomy = new Dichotomy();
			dichotomy.Max(0, 10, 0.5, 1);

			Console.WriteLine("GoldenRatio:");
			Search goldenRatio = new GoldenRatio();
			goldenRatio.Min(0, 10, 0.5, 1);
		}
	}
}
