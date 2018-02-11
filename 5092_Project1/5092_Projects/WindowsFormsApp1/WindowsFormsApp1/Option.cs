using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
///  This class is working as a option pricing method
/// </summary>
namespace WindowsFormsApp1
{
    public class Option
    {


        Simulator Simulator1 = new Simulator();

        // This function is used to get the simulations and store it in sim
        public double[,] GetSimulations(double S0, double K, double r, double sigma, double T, int trials, int N, double[,] RandomNormal1)
        {
            double[,] sim;
            sim = Simulator1.Simulations(S0, r, sigma, T, N, trials, RandomNormal1);
            return sim;
        }
    }


    public class EuroOption : Option
    {

        // This function is used to calculate option price
        public double EUPrice(double K, double r, double T, int trials, int N, double[,] RandomNormal1, double[,] sims, bool isput)
        {
            // Define variables
            double sum = 0;
            
            for (int a = 0; a < trials; a++)
            {
                if (isput == false)
                {
                    sum += Math.Max(sims[a, N - 1] - K, 0);
                }
                else
                {
                    sum += Math.Max(K - sims[a, N - 1], 0);
                }
            }
            return (sum / trials) * Math.Exp(-r * T);
        }

    }
}
