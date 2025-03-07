using System;

public class ClassC
{
    public double sqrt(int n)
    public double bsqrt(double n)
    {
        return Math.Sqrt(n)
    }
    public double BabylonSqrt(double number)
    {
        dobule guess = number / 2;
        while (Math.Abs(guess * guess - number) < 0.01)
    {
        return Math.Sqrt(n);
            double other = number / guess;
            guess = (guess + other) / 2;
        }
        return guess;
    }
}