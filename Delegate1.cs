using System.Data;
using System;
namespace CS2023
{
    static class Delegate1Test
    {
        static double[] Apply(double[] a, Function1 f)
        {
            var result = new double[a.Length];
            for (int i = 0; i < a.Length; i++) result[i] = f(a[i]);
            return result;
        }
        public static void Test()
        {
            double[] a = { 0.0, 0.5, 1.0 };
            double[] squares = Apply(a, (x) => x * x);
            Console.WriteLine(Helper.OutArray(squares));
            double[] sines = Apply(a, Math.Sin);
            Console.WriteLine(Helper.OutArray(sines));
            Multiplier m = new(2.0);
            double[] doubles = Apply(a, m.Multiply);
            Console.WriteLine(Helper.OutArray(doubles));
            doubles = Apply(a, (double x) => x * 2.0);
            Console.WriteLine(Helper.OutArray(doubles));
        }
    }
    class Delegate1
    {
    }
    delegate double Function1(double x);
    class Multiplier
    {
        double _factor;

        public Multiplier(double factor) => _factor = factor;

        public double Multiply(double x) => x * _factor;
    }
}