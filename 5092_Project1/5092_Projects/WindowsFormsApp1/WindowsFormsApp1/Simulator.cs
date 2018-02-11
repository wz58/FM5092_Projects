
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// This class is used to get the simulations
/// </summary>
namespace WindowsFormsApp1
{
    class Simulator
    {
        // This function is used to create an 2-D array to store the simulations
        public double[,] Simulations(double S0, double r, double sigma, double T, int N, int trials, double[,] RandomNormal1)
        {
            // Define variables
            double t = T / N;

            // The first column of this matrix should be underlying price
            double[,] Simulations = new double[trials, N + 1];
            for (int a = 0; a < trials; a++)
            {
                Simulations[a, 0] = S0;
            }

            for (int a = 0; a < trials; a++)
            {
                for (int b = 1; b < N; b++)
                {
                    Simulations[a, b] = Simulations[a, b - 1] * Math.Exp((r - sigma * sigma / 2) * (T / N) + sigma * Math.Sqrt(T / N) * RandomNormal1[a, b - 1]);
                }
            }
            return Simulations;
        }
    }

}

