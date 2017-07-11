﻿namespace SharpCalculator.TwoArgumentsCalculators
{
    public class SubstractionCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument - secondArgument;
        }
    }
}