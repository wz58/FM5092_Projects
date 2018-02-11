using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// This class is about GUI, inputs and outputs
/// </summary>
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // The error providers for inputs.
        // When user input a wrong type of data, the program should ask user to enter a right one
        private void Form1_Load(object sender, EventArgs e)
        {
            // The error provider for underlying price text box
            errorProvider_S.SetIconAlignment(textBox_S, ErrorIconAlignment.MiddleRight);
            errorProvider_S.SetIconPadding(textBox_S, 3);

            // The error provider for strike price text box
            errorProvider_K.SetIconAlignment(textBox_K, ErrorIconAlignment.MiddleRight);
            errorProvider_K.SetIconPadding(textBox_K, 3);

            // The error provider for risk free rate text box
            errorProvider_r.SetIconAlignment(textBox_r, ErrorIconAlignment.MiddleRight);
            errorProvider_r.SetIconPadding(textBox_r, 3);

            // The error provider for tenor text box
            errorProvider_T.SetIconAlignment(textBox_T, ErrorIconAlignment.MiddleRight);
            errorProvider_T.SetIconPadding(textBox_T, 3);

            // The error provider for volatility text box
            errorProvider_sigma.SetIconAlignment(textBox_sigma, ErrorIconAlignment.MiddleRight);
            errorProvider_sigma.SetIconPadding(textBox_sigma, 3);

            // The error provider for steps text box
            errorProvider_N.SetIconAlignment(textBox_N, ErrorIconAlignment.MiddleRight);
            errorProvider_N.SetIconPadding(textBox_N, 3);

            // The error provider for trials text box
            errorProvider_trials.SetIconAlignment(textBox_trials, ErrorIconAlignment.MiddleRight);
            errorProvider_trials.SetIconPadding(textBox_trials, 3);
        }

        // The sentence that ask user to enter correct type of data for underlying price
        private void textBox_S_TextChanged(object sender, EventArgs e)
        {
            double num;
            if (!double.TryParse(textBox_S.Text, out num))
            {
                errorProvider_S.SetError(textBox_S, "Please enter a number");
            }
            else
            {
                errorProvider_S.SetError(textBox_S, "");
            }
            
        }

        // The sentence that ask user to enter correct type of data for strike price
        private void textBox_K_TextChanged(object sender, EventArgs e)
        {
            double num;
            if (!double.TryParse(textBox_K.Text, out num))
            {
                errorProvider_K.SetError(textBox_K, "Please enter a number");
            }
            else
            {
                errorProvider_K.SetError(textBox_K, "");
            }
        }

        // The sentence that ask user to enter correct type of data for risk free rate
        private void textBox_r_TextChanged(object sender, EventArgs e)
        {
            double num;
            if (!double.TryParse(textBox_r.Text, out num))
            {
                errorProvider_r.SetError(textBox_r, "Please enter a number");
            }
            else
            {
                errorProvider_r.SetError(textBox_r, "");
            }
        }

        // The sentence that ask user to enter correct type of data for tenor
        private void textBox_T_TextChanged(object sender, EventArgs e)
        {
            double num;
            if (!double.TryParse(textBox_r.Text, out num))
            {
                errorProvider_T.SetError(textBox_T, "Please enter a number");
            }
            else
            {
                errorProvider_T.SetError(textBox_T, "");
            }
        }

        // The sentence that ask user to enter correct type of data for volatility
        private void textBox_sigma_TextChanged(object sender, EventArgs e)
        {
            double num;
            if (!double.TryParse(textBox_sigma.Text, out num))
            {
                errorProvider_sigma.SetError(textBox_sigma, "Please enter a number");
            }
            else
            {
                errorProvider_sigma.SetError(textBox_sigma, "");
            }
        }

        // The sentence that ask user to enter correct type of data for steps
        private void textBox_N_TextChanged(object sender, EventArgs e)
        {
            double num;
            if (!double.TryParse(textBox_N.Text, out num))
            {
                errorProvider_N.SetError(textBox_N, "Please enter a number");
            }
            else
            {
                errorProvider_N.SetError(textBox_N, "");
            }
        }

        // The sentence that ask user to enter correct type of data for trials
        private void textBox_trials_TextChanged(object sender, EventArgs e)
        {
            double num;
            if (!double.TryParse(textBox_trials.Text, out num))
            {
                errorProvider_trials.SetError(textBox_trials, "Please enter a number");
            }
            else
            {
                errorProvider_trials.SetError(textBox_trials, "");
            }
        }


        private void btn_calculate_Click(object sender, EventArgs e)
        {
            // Define some variables for calculation
            double S0, K, r, T, sigma;
            int N, trials;

            // use tryparse to check whether the user enterd correct type of value for each text box
            if (double.TryParse(textBox_S.Text, out S0) && 
                double.TryParse(textBox_K.Text, out K) &&
                double.TryParse(textBox_r.Text, out r) &&
                double.TryParse(textBox_T.Text, out T) &&
                double.TryParse(textBox_sigma.Text, out sigma) &&
                int.TryParse(textBox_N.Text, out N) &&
                int.TryParse(textBox_trials.Text, out trials))
            {
                // if all the inputs are correct, do the following calculation
                // Calculating the European call option price and greeks
                if (radioButton_EuropeanCall.Checked)
                {
                    // Define the variables
                    bool isput = false;

                    // Create a instance for RandomGenerator class
                    RandomGenerator RG = new RandomGenerator();
                    double[,] RandomNormal1 = RG.RandomNormal(trials, N);

                    // Create a instance for Option class
                    Option opt1 = new Option();
                    EuroOption opt2 = new EuroOption();
                    double[,] sims = opt1.GetSimulations(S0, K, r, sigma, T, trials, N, RandomNormal1);

                    // Calculating and outputing the european call option price
                    label_OptionResult.Text = opt2.EUPrice(K, r, T, trials, N, RandomNormal1, sims, isput).ToString();

                    // Calculating and outputing the delta value for European call option
                    Greeks greek1 = new Greeks();
                    label_DeltaResult.Text = greek1.Delta(S0, K, r, sigma, T, N, trials, RandomNormal1, isput).ToString();

                    // Calculating and outputing the gamma value for European call option
                    label_GammaResult.Text = greek1.Gamma(S0, K, r, sigma, T, N, trials, RandomNormal1, isput).ToString();

                    // Calculating and outputing the vega value for European call option
                    label_VegaResult.Text = greek1.Vega(S0, K, r, sigma, T, N, trials, RandomNormal1, isput).ToString();

                    // Calculating and outputing the theta value for European call option
                    label_ThetaResult.Text = greek1.Theta(S0, K, r, sigma, T, N, trials, RandomNormal1, isput).ToString();

                    // Calculating and outputing the rho value for European call option
                    label_RhoResult.Text = greek1.Rho(S0, K, r, sigma, T, N, trials, RandomNormal1, isput).ToString();

                    // Calculating and outputing the SE value for European call option
                    label_SEResult.Text = greek1.SE(S0, K, r, sigma, T, N, trials, RandomNormal1, isput).ToString();

                }

                // Calculating the Euroean put option price and greeks
                else if (radioButton_EuropeanPut.Checked)
                {
                    // Define the variables
                    bool isput = true;

                    // Create a instance for RandomGenerator class
                    RandomGenerator RG = new RandomGenerator();
                    double[,] RandomNormal1 = RG.RandomNormal(trials, N);

                    // Create a instance for Option class
                    Option opt1 = new Option();
                    EuroOption opt2 = new EuroOption();
                    double[,] sims = opt1.GetSimulations(S0, K, r, sigma, T, trials, N, RandomNormal1);

                    // Calculating and outputing the european put option price
                    label_OptionResult.Text = opt2.EUPrice(K, r, T, trials, N, RandomNormal1, sims, isput).ToString();

                    // Calculating and outputing the delta value for European put option
                    Greeks greek1 = new Greeks();
                    label_DeltaResult.Text = greek1.Delta(S0, K, r, sigma, T, N, trials, RandomNormal1, isput).ToString();

                    // Calculating and outputing the gamma value for European put option
                    label_GammaResult.Text = greek1.Gamma(S0, K, r, sigma, T, N, trials, RandomNormal1, isput).ToString();

                    // Calculating and outputing the vega value for European put option
                    label_VegaResult.Text = greek1.Vega(S0, K, r, sigma, T, N, trials, RandomNormal1, isput).ToString();

                    // Calculating and outputing the theta value for European put option
                    label_ThetaResult.Text = greek1.Theta(S0, K, r, sigma, T, N, trials, RandomNormal1, isput).ToString();

                    // Calculating and outputing the rho value for European put option
                    label_RhoResult.Text = greek1.Rho(S0, K, r, sigma, T, N, trials, RandomNormal1, isput).ToString();

                    // Calculating and outputing the SE value for European put option
                    label_SEResult.Text = greek1.SE(S0, K, r, sigma, T, N, trials, RandomNormal1, isput).ToString();
                }

                // Calculating the American call option price and greeks
                else if (radioButton_AmericanCall.Checked)
                {
                    label_OptionResult.Text = "Sorry. Coming Soon!";
                }

                // Calculating the American put option price and greeks
                else if (radioButton_AmericanPut.Checked)
                {
                    label_OptionResult.Text = "Sorry. Coming Soon!";
                }
            }
            // Output the error message if the user inputs inpropriate data
            else
            {
                label_OptionResult.Text = "Error! Please check your inputs";
            }

        }
    }
}
