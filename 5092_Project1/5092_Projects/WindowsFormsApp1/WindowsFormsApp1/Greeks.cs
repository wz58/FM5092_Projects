using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// This class is used to calculate the greeks and standard error
/// </summary>
namespace WindowsFormsApp1 
{
    class Greeks
    {
        Option opt1 = new Option();
        EuroOption opt2 = new EuroOption();


        // The function used to calculate the Delta
        public double Delta(double S0, double K, double r, double sigma, double T, int N, int trials, double[,] RandomNormal1, bool isput)
        {
            // Define the variables for calculating the delta value
            double dS0 = S0 * 0.001;
            double S0a = S0 + dS0;
            double S0m = S0 - dS0;

            // Using new underlying value to make the simulation
            double[,] Delta_sims1 = opt1.GetSimulations(S0a, K, r, sigma, T, trials, N, RandomNormal1);
            double[,] Delta_sims2 = opt1.GetSimulations(S0m, K, r, sigma, T, trials, N, RandomNormal1);

            // Using the new simulation to calculate the option price
            double Delta_p1 = opt2.EUPrice(K, r, T, trials, N, RandomNormal1, Delta_sims1, isput);
            double Delta_p2 = opt2.EUPrice(K, r, T, trials, N, RandomNormal1, Delta_sims2, isput);

            // Calculating the delta value
            double Delta = (Delta_p1 - Delta_p2) / 2 * dS0;

            return Delta * 100;
        }

        // The function to calculate gamma value
        public double Gamma(double S0, double K, double r, double sigma, double T, int N, int trials, double[,] RandomNormal1, bool isput)
        {
            // Define the variables for calculating the gamma value
            double dS0 = S0 * 0.001;
            double S0a = S0 + dS0;
            double S0m = S0 - dS0;

            // Using new underlying value to make the simulation 
            double[,] Gamma_sims1 = opt1.GetSimulations(S0a, K, r, sigma, T, trials, N, RandomNormal1);
            double[,] Gamma_sims2 = opt1.GetSimulations(S0m, K, r, sigma, T, trials, N, RandomNormal1);
            double[,] Gamma_sims3 = opt1.GetSimulations(S0, K, r, sigma, T, trials, N, RandomNormal1);

            // Using the new simulation to calculate the option price
            double Gamma_p1 = opt2.EUPrice(K, r, T, trials, N, RandomNormal1, Gamma_sims1, isput);
            double Gamma_p2 = opt2.EUPrice(K, r, T, trials, N, RandomNormal1, Gamma_sims2, isput);
            double Gamma_p3 = opt2.EUPrice(K, r, T, trials, N, RandomNormal1, Gamma_sims3, isput);

            // Calculate the gamma value
            double Gamma = (Gamma_p1 - 2 * Gamma_p3 + Gamma_p2) / Math.Pow(dS0, 2);

            return Gamma;

        }

        // The function to calculate vega value 
        public double Vega(double S0, double K, double r, double sigma, double T, int N, int trials, double[,] RandomNormal1, bool isput)
        {
            // Define the variables for calculating the vega value
            double dsigma = sigma * 0.001;
            double sigmaa = sigma + dsigma;
            double sigmam = sigma - dsigma;

            // Using new sigma value to make the simulation
            double[,] Vega_sims1 = opt1.GetSimulations(S0, K, r, sigmaa, T, trials, N, RandomNormal1);
            double[,] Vega_sims2 = opt1.GetSimulations(S0, K, r, sigmam, T, trials, N, RandomNormal1);

            // Using the new simulation to calculate the option price
            double Vega_p1 = opt2.EUPrice(K, r, T, trials, N, RandomNormal1, Vega_sims1, isput);
            double Vega_p2 = opt2.EUPrice(K, r, T, trials, N, RandomNormal1, Vega_sims2, isput);

            // Calculate the vega value
            double Vega = (Vega_p1 - Vega_p2) / (2 * dsigma);

            return Vega;

        }

        // The function to calculate theta value 
        public double Theta(double S0, double K, double r, double sigma, double T, int N, int trials, double[,] RandomNormal1, bool isput)
        {
            // Define the variables for calculating the theta value
            double dT = T * 0.001;
            double Tm = T - dT;

            // Using new sigma value to make the simulation
            double[,] Theta_sims1 = opt1.GetSimulations(S0, K, r, sigma, Tm, trials, N, RandomNormal1);
            double[,] Theta_sims2 = opt1.GetSimulations(S0, K, r, sigma, T, trials, N, RandomNormal1);

            // Using the new simulation to calculate the option price
            double Theta_p1 = opt2.EUPrice(K, r, Tm, trials, N, RandomNormal1, Theta_sims1, isput);
            double Theta_p2 = opt2.EUPrice(K, r, T, trials, N, RandomNormal1, Theta_sims2, isput);

            // Calculate the theta value
            double Theta = (Theta_p1 - Theta_p2) / dT;

            return Theta;

        }

        // The function to calculate rho value 
        public double Rho(double S0, double K, double r, double sigma, double T, int N, int trials, double[,] RandomNormal1, bool isput)
        {
            // Define the variables for calculating the rho value
            double dr = r * 0.001;
            double ra = r + dr;
            double rm = r - dr;

            // Using new sigma value to make the simulation
            double[,] Rho_sims1 = opt1.GetSimulations(S0, K, ra, sigma, T, trials, N, RandomNormal1);
            double[,] Rho_sims2 = opt1.GetSimulations(S0, K, rm, sigma, T, trials, N, RandomNormal1);

            // Using the new simulation to calculate the option price
            double Rho_p1 = opt2.EUPrice(K, ra, T, trials, N, RandomNormal1, Rho_sims1, isput);
            double Rho_p2 = opt2.EUPrice(K, rm, T, trials, N, RandomNormal1, Rho_sims2, isput);

            // Calculate the theta value
            double Rho = (Rho_p1 - Rho_p2) / (2 * dr);

            return Rho;

        }
        // The function to calculate standard error value 
        public double SE(double S0, double K, double r, double sigma, double T, int N, int trials, double[,] RandomNormal1, bool isput)
        {
            // Define the variables for calculating the standard error value
            double sums = 0;
            double[,] sims = opt1.GetSimulations(S0, K, r, sigma, T, trials, N, RandomNormal1);
            double EUPrice = opt2.EUPrice(K, r, T, trials, N, RandomNormal1, sims, isput);

            for (int a = 0; a < trials; a++)
            {
                sums = sums + Math.Pow((sims[a, N] * Math.Exp(-r * T) - EUPrice), 2);
            }

            double SD = Math.Sqrt(sums / (trials - 1));
            return SD / Math.Sqrt(trials);
        }
        
    }
}
