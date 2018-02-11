
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// This class is used to get the random variables
/// </summary>
namespace WindowsFormsApp1

{
    public class RandomGenerator
    {

        // Generate a random variables matrix
        Random rnd = new Random();

        public double[,] RandomNormal(int trials, int N)
        {
            // Create an array to store random variables
            double[,] RandNormal = new double[trials, N];

            for (int a = 0; a < trials; a++)
            {
                for (int b = 0; b < N; b++)
                {
                    RandNormal[a, b] = PolarRejection(rnd);
                }
            }
            return RandNormal;
        }

        // Using Polar Rejection Method to create normal random matrix
        static double PolarRejection(Random rnd)
        {
            // Define some varirables
            double w, x1, x2, PR1;
            do
            {
                // Generate two uniform random values between 0 and 1

                x1 = 1.0 - 2 * rnd.NextDouble();
                x2 = 1.0 - 2 * rnd.NextDouble();
                w = Math.Pow(x1, 2) + Math.Pow(x2, 2);
            }
            while (w > 1);
            {

                double c = Math.Sqrt(-2 * Math.Log(w) / w);
                PR1 = c * x1;

            }
            return PR1;
        }

    }
}
