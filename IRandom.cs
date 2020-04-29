using System;
using System.Collections.Generic;
using System.Text;

namespace Random_Generator
{
    public interface IRandom
    {
        public int randomInteger(int seed);
        public double randomDouble(int seed);
        public int randomIntWithRange(int min, int max, Random ran);
        public double randomDoubleWithRange(double min, double max, Random ran);
        public int[] generateList(int seed, int size);
        public double[] generateListDouble(int seed, int size);
    }
}
