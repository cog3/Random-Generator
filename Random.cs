using System;

namespace Random_Generator
{

    namespace Random_Generator
    {
        class Random_Generator : IRandom
        {
            public int randomInteger(int seed)
            {
                Random ran = new Random(seed);
                return ran.Next();
            }
            public double randomDouble(int seed)
            {
                Random ran = new Random(seed);
                return ran.NextDouble();
            }
            public int randomIntWithRange(int min, int max, Random ran)
            {
                return ran.Next(min, max);
            }
            public double randomDoubleWithRange(double min, double max, Random ran)
            {
                return ran.NextDouble() * (max - min) + max;
            }
            public int[] generateList(int seed, int size)
            {
                Random randSeed = new Random(seed);
                int[] arr = new int[size];
                for (int i = 0; i < size; i++)
                {
                    arr[i] = randSeed.Next();
                }
                return arr;
            }
            public double[] generateListDouble(int seed, int size)
            {
                Random randSeed = new Random(seed);
                double[] arr = new double[size];
                for (int i = 0; i < size; i++)
                {
                    arr[i] = randSeed.NextDouble();
                }
                return arr;
            }
        }
    }
}
