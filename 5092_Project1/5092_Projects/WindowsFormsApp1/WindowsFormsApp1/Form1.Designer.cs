namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox_S = new System.Windows.Forms.TextBox();
            this.label_S = new System.Windows.Forms.Label();
            this.textBox_K = new System.Windows.Forms.TextBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.errorProvider_S = new System.Windows.Forms.ErrorProvider(this.components);
            this.label_K = new System.Windows.Forms.Label();
            this.errorProvider_K = new System.Windows.Forms.ErrorProvider(this.components);
            this.label_r = new System.Windows.Forms.Label();
            this.textBox_r = new System.Windows.Forms.TextBox();
            this.errorProvider_r = new System.Windows.Forms.ErrorProvider(this.components);
            this.label_T = new System.Windows.Forms.Label();
            this.textBox_T = new System.Windows.Forms.TextBox();
            this.errorProvider_T = new System.Windows.Forms.ErrorProvider(this.components);
            this.label_sigma = new System.Windows.Forms.Label();
            this.textBox_sigma = new System.Windows.Forms.TextBox();
            this.errorProvider_sigma = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBox_N = new System.Windows.Forms.TextBox();
            this.label_N = new System.Windows.Forms.Label();
            this.errorProvider_N = new System.Windows.Forms.ErrorProvider(this.components);
            this.label_trials = new System.Windows.Forms.Label();
            this.textBox_trials = new System.Windows.Forms.TextBox();
            this.errorProvider_trials = new System.Windows.Forms.ErrorProvider(this.components);
            this.radioButton_EuropeanCall = new System.Windows.Forms.RadioButton();
            this.radioButton_AmericanCall = new System.Windows.Forms.RadioButton();
            this.radioButton_EuropeanPut = new System.Windows.Forms.RadioButton();
            this.radioButton_AmericanPut = new System.Windows.Forms.RadioButton();
            this.label_optionPrice = new System.Windows.Forms.Label();
            this.label_OptionResult = new System.Windows.Forms.Label();
            this.label_Delta = new System.Windows.Forms.Label();
            this.label_DeltaResult = new System.Windows.Forms.Label();
            this.label_Gamma = new System.Windows.Forms.Label();
            this.label_GammaResult = new System.Windows.Forms.Label();
            this.label_Vega = new System.Windows.Forms.Label();
            this.label_VegaResult = new System.Windows.Forms.Label();
            this.label_Theta = new System.Windows.Forms.Label();
            this.label_ThetaResult = new System.Windows.Forms.Label();
            this.label_Rho = new System.Windows.Forms.Label();
            this.label_RhoResult = new System.Windows.Forms.Label();
            this.label_SE = new System.Windows.Forms.Label();
            this.label_SEResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_S)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_K)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_r)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_T)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_sigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_N)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_trials)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_S
            // 
            this.textBox_S.Location = new System.Drawing.Point(232, 32);
            this.textBox_S.Name = "textBox_S";
            this.textBox_S.Size = new System.Drawing.Size(100, 22);
            this.textBox_S.TabIndex = 0;
            this.textBox_S.TextChanged += new System.EventHandler(this.textBox_S_TextChanged);
            // 
            // label_S
            // 
            this.label_S.AutoSize = true;
            this.label_S.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_S.Location = new System.Drawing.Point(23, 35);
            this.label_S.Name = "label_S";
            this.label_S.Size = new System.Drawing.Size(173, 19);
            this.label_S.TabIndex = 1;
            this.label_S.Text = "Underlying Price (S):";
            this.label_S.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox_K
            // 
            this.textBox_K.Location = new System.Drawing.Point(232, 81);
            this.textBox_K.Name = "textBox_K";
            this.textBox_K.Size = new System.Drawing.Size(100, 22);
            this.textBox_K.TabIndex = 2;
            this.textBox_K.TextChanged += new System.EventHandler(this.textBox_K_TextChanged);
            // 
            // btn_calculate
            // 
            this.btn_calculate.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calculate.Location = new System.Drawing.Point(665, 420);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(166, 90);
            this.btn_calculate.TabIndex = 3;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // errorProvider_S
            // 
            this.errorProvider_S.ContainerControl = this;
            // 
            // label_K
            // 
            this.label_K.AutoSize = true;
            this.label_K.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_K.Location = new System.Drawing.Point(61, 84);
            this.label_K.Name = "label_K";
            this.label_K.Size = new System.Drawing.Size(135, 19);
            this.label_K.TabIndex = 4;
            this.label_K.Text = "Strike Price (K):";
            // 
            // errorProvider_K
            // 
            this.errorProvider_K.ContainerControl = this;
            // 
            // label_r
            // 
            this.label_r.AutoSize = true;
            this.label_r.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_r.Location = new System.Drawing.Point(42, 132);
            this.label_r.Name = "label_r";
            this.label_r.Size = new System.Drawing.Size(154, 19);
            this.label_r.TabIndex = 5;
            this.label_r.Text = "Risk Free Rate (r):";
            // 
            // textBox_r
            // 
            this.textBox_r.Location = new System.Drawing.Point(232, 132);
            this.textBox_r.Name = "textBox_r";
            this.textBox_r.Size = new System.Drawing.Size(100, 22);
            this.textBox_r.TabIndex = 6;
            this.textBox_r.TextChanged += new System.EventHandler(this.textBox_r_TextChanged);
            // 
            // errorProvider_r
            // 
            this.errorProvider_r.ContainerControl = this;
            // 
            // label_T
            // 
            this.label_T.AutoSize = true;
            this.label_T.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_T.Location = new System.Drawing.Point(109, 180);
            this.label_T.Name = "label_T";
            this.label_T.Size = new System.Drawing.Size(87, 19);
            this.label_T.TabIndex = 7;
            this.label_T.Text = "Tenor (T):";
            // 
            // textBox_T
            // 
            this.textBox_T.Location = new System.Drawing.Point(232, 178);
            this.textBox_T.Name = "textBox_T";
            this.textBox_T.Size = new System.Drawing.Size(100, 22);
            this.textBox_T.TabIndex = 8;
            this.textBox_T.TextChanged += new System.EventHandler(this.textBox_T_TextChanged);
            // 
            // errorProvider_T
            // 
            this.errorProvider_T.ContainerControl = this;
            // 
            // label_sigma
            // 
            this.label_sigma.AutoSize = true;
            this.label_sigma.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sigma.Location = new System.Drawing.Point(52, 228);
            this.label_sigma.Name = "label_sigma";
            this.label_sigma.Size = new System.Drawing.Size(144, 19);
            this.label_sigma.TabIndex = 9;
            this.label_sigma.Text = "Volatility (sigma):";
            // 
            // textBox_sigma
            // 
            this.textBox_sigma.Location = new System.Drawing.Point(232, 228);
            this.textBox_sigma.Name = "textBox_sigma";
            this.textBox_sigma.Size = new System.Drawing.Size(100, 22);
            this.textBox_sigma.TabIndex = 10;
            this.textBox_sigma.TextChanged += new System.EventHandler(this.textBox_sigma_TextChanged);
            // 
            // errorProvider_sigma
            // 
            this.errorProvider_sigma.ContainerControl = this;
            // 
            // textBox_N
            // 
            this.textBox_N.Location = new System.Drawing.Point(232, 278);
            this.textBox_N.Name = "textBox_N";
            this.textBox_N.Size = new System.Drawing.Size(100, 22);
            this.textBox_N.TabIndex = 11;
            this.textBox_N.TextChanged += new System.EventHandler(this.textBox_N_TextChanged);
            // 
            // label_N
            // 
            this.label_N.AutoSize = true;
            this.label_N.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_N.Location = new System.Drawing.Point(107, 278);
            this.label_N.Name = "label_N";
            this.label_N.Size = new System.Drawing.Size(89, 19);
            this.label_N.TabIndex = 12;
            this.label_N.Text = "Steps (N):";
            // 
            // errorProvider_N
            // 
            this.errorProvider_N.ContainerControl = this;
            // 
            // label_trials
            // 
            this.label_trials.AutoSize = true;
            this.label_trials.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_trials.Location = new System.Drawing.Point(139, 328);
            this.label_trials.Name = "label_trials";
            this.label_trials.Size = new System.Drawing.Size(57, 19);
            this.label_trials.TabIndex = 13;
            this.label_trials.Text = "Trials:";
            // 
            // textBox_trials
            // 
            this.textBox_trials.Location = new System.Drawing.Point(232, 324);
            this.textBox_trials.Name = "textBox_trials";
            this.textBox_trials.Size = new System.Drawing.Size(100, 22);
            this.textBox_trials.TabIndex = 14;
            this.textBox_trials.TextChanged += new System.EventHandler(this.textBox_trials_TextChanged);
            // 
            // errorProvider_trials
            // 
            this.errorProvider_trials.ContainerControl = this;
            // 
            // radioButton_EuropeanCall
            // 
            this.radioButton_EuropeanCall.AutoSize = true;
            this.radioButton_EuropeanCall.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_EuropeanCall.Location = new System.Drawing.Point(46, 401);
            this.radioButton_EuropeanCall.Name = "radioButton_EuropeanCall";
            this.radioButton_EuropeanCall.Size = new System.Drawing.Size(198, 23);
            this.radioButton_EuropeanCall.TabIndex = 15;
            this.radioButton_EuropeanCall.TabStop = true;
            this.radioButton_EuropeanCall.Text = "European Call Option";
            this.radioButton_EuropeanCall.UseVisualStyleBackColor = true;
            // 
            // radioButton_AmericanCall
            // 
            this.radioButton_AmericanCall.AutoSize = true;
            this.radioButton_AmericanCall.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_AmericanCall.Location = new System.Drawing.Point(46, 457);
            this.radioButton_AmericanCall.Name = "radioButton_AmericanCall";
            this.radioButton_AmericanCall.Size = new System.Drawing.Size(195, 23);
            this.radioButton_AmericanCall.TabIndex = 16;
            this.radioButton_AmericanCall.TabStop = true;
            this.radioButton_AmericanCall.Text = "American Call Option";
            this.radioButton_AmericanCall.UseVisualStyleBackColor = true;
            // 
            // radioButton_EuropeanPut
            // 
            this.radioButton_EuropeanPut.AutoSize = true;
            this.radioButton_EuropeanPut.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_EuropeanPut.Location = new System.Drawing.Point(290, 401);
            this.radioButton_EuropeanPut.Name = "radioButton_EuropeanPut";
            this.radioButton_EuropeanPut.Size = new System.Drawing.Size(196, 23);
            this.radioButton_EuropeanPut.TabIndex = 17;
            this.radioButton_EuropeanPut.TabStop = true;
            this.radioButton_EuropeanPut.Text = "European Put Option";
            this.radioButton_EuropeanPut.UseVisualStyleBackColor = true;
            // 
            // radioButton_AmericanPut
            // 
            this.radioButton_AmericanPut.AutoSize = true;
            this.radioButton_AmericanPut.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_AmericanPut.Location = new System.Drawing.Point(290, 457);
            this.radioButton_AmericanPut.Name = "radioButton_AmericanPut";
            this.radioButton_AmericanPut.Size = new System.Drawing.Size(193, 23);
            this.radioButton_AmericanPut.TabIndex = 18;
            this.radioButton_AmericanPut.TabStop = true;
            this.radioButton_AmericanPut.Text = "American Put Option";
            this.radioButton_AmericanPut.UseVisualStyleBackColor = true;
            // 
            // label_optionPrice
            // 
            this.label_optionPrice.AutoSize = true;
            this.label_optionPrice.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_optionPrice.Location = new System.Drawing.Point(415, 35);
            this.label_optionPrice.Name = "label_optionPrice";
            this.label_optionPrice.Size = new System.Drawing.Size(113, 19);
            this.label_optionPrice.TabIndex = 19;
            this.label_optionPrice.Text = "Option Price:";
            // 
            // label_OptionResult
            // 
            this.label_OptionResult.AutoSize = true;
            this.label_OptionResult.Location = new System.Drawing.Point(556, 35);
            this.label_OptionResult.Name = "label_OptionResult";
            this.label_OptionResult.Size = new System.Drawing.Size(86, 17);
            this.label_OptionResult.TabIndex = 20;
            this.label_OptionResult.Text = "Option Price";
            // 
            // label_Delta
            // 
            this.label_Delta.AutoSize = true;
            this.label_Delta.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Delta.Location = new System.Drawing.Point(426, 84);
            this.label_Delta.Name = "label_Delta";
            this.label_Delta.Size = new System.Drawing.Size(102, 19);
            this.label_Delta.TabIndex = 21;
            this.label_Delta.Text = "Delta Value:";
            // 
            // label_DeltaResult
            // 
            this.label_DeltaResult.AutoSize = true;
            this.label_DeltaResult.Location = new System.Drawing.Point(559, 85);
            this.label_DeltaResult.Name = "label_DeltaResult";
            this.label_DeltaResult.Size = new System.Drawing.Size(81, 17);
            this.label_DeltaResult.TabIndex = 22;
            this.label_DeltaResult.Text = "Delta Value";
            // 
            // label_Gamma
            // 
            this.label_Gamma.AutoSize = true;
            this.label_Gamma.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Gamma.Location = new System.Drawing.Point(407, 132);
            this.label_Gamma.Name = "label_Gamma";
            this.label_Gamma.Size = new System.Drawing.Size(121, 19);
            this.label_Gamma.TabIndex = 23;
            this.label_Gamma.Text = "Gamma Value:";
            // 
            // label_GammaResult
            // 
            this.label_GammaResult.AutoSize = true;
            this.label_GammaResult.Location = new System.Drawing.Point(559, 132);
            this.label_GammaResult.Name = "label_GammaResult";
            this.label_GammaResult.Size = new System.Drawing.Size(97, 17);
            this.label_GammaResult.TabIndex = 24;
            this.label_GammaResult.Text = "Gamma Value";
            // 
            // label_Vega
            // 
            this.label_Vega.AutoSize = true;
            this.label_Vega.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Vega.Location = new System.Drawing.Point(426, 178);
            this.label_Vega.Name = "label_Vega";
            this.label_Vega.Size = new System.Drawing.Size(100, 19);
            this.label_Vega.TabIndex = 25;
            this.label_Vega.Text = "Vega Value:";
            // 
            // label_VegaResult
            // 
            this.label_VegaResult.AutoSize = true;
            this.label_VegaResult.Location = new System.Drawing.Point(561, 178);
            this.label_VegaResult.Name = "label_VegaResult";
            this.label_VegaResult.Size = new System.Drawing.Size(81, 17);
            this.label_VegaResult.TabIndex = 26;
            this.label_VegaResult.Text = "Vega Value";
            // 
            // label_Theta
            // 
            this.label_Theta.AutoSize = true;
            this.label_Theta.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Theta.Location = new System.Drawing.Point(422, 228);
            this.label_Theta.Name = "label_Theta";
            this.label_Theta.Size = new System.Drawing.Size(106, 19);
            this.label_Theta.TabIndex = 27;
            this.label_Theta.Text = "Theta Value:";
            // 
            // label_ThetaResult
            // 
            this.label_ThetaResult.AutoSize = true;
            this.label_ThetaResult.Location = new System.Drawing.Point(559, 229);
            this.label_ThetaResult.Name = "label_ThetaResult";
            this.label_ThetaResult.Size = new System.Drawing.Size(85, 17);
            this.label_ThetaResult.TabIndex = 28;
            this.label_ThetaResult.Text = "Theta Value";
            // 
            // label_Rho
            // 
            this.label_Rho.AutoSize = true;
            this.label_Rho.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Rho.Location = new System.Drawing.Point(434, 278);
            this.label_Rho.Name = "label_Rho";
            this.label_Rho.Size = new System.Drawing.Size(94, 19);
            this.label_Rho.TabIndex = 29;
            this.label_Rho.Text = "Rho Value:";
            // 
            // label_RhoResult
            // 
            this.label_RhoResult.AutoSize = true;
            this.label_RhoResult.Location = new System.Drawing.Point(562, 279);
            this.label_RhoResult.Name = "label_RhoResult";
            this.label_RhoResult.Size = new System.Drawing.Size(74, 17);
            this.label_RhoResult.TabIndex = 30;
            this.label_RhoResult.Text = "Rho Value";
            // 
            // label_SE
            // 
            this.label_SE.AutoSize = true;
            this.label_SE.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SE.Location = new System.Drawing.Point(491, 324);
            this.label_SE.Name = "label_SE";
            this.label_SE.Size = new System.Drawing.Size(37, 19);
            this.label_SE.TabIndex = 31;
            this.label_SE.Text = "SE:";
            // 
            // label_SEResult
            // 
            this.label_SEResult.AutoSize = true;
            this.label_SEResult.Location = new System.Drawing.Point(565, 324);
            this.label_SEResult.Name = "label_SEResult";
            this.label_SEResult.Size = new System.Drawing.Size(66, 17);
            this.label_SEResult.TabIndex = 32;
            this.label_SEResult.Text = "SE Value";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 538);
            this.Controls.Add(this.label_SEResult);
            this.Controls.Add(this.label_SE);
            this.Controls.Add(this.label_RhoResult);
            this.Controls.Add(this.label_Rho);
            this.Controls.Add(this.label_ThetaResult);
            this.Controls.Add(this.label_Theta);
            this.Controls.Add(this.label_VegaResult);
            this.Controls.Add(this.label_Vega);
            this.Controls.Add(this.label_GammaResult);
            this.Controls.Add(this.label_Gamma);
            this.Controls.Add(this.label_DeltaResult);
            this.Controls.Add(this.label_Delta);
            this.Controls.Add(this.label_OptionResult);
            this.Controls.Add(this.label_optionPrice);
            this.Controls.Add(this.radioButton_AmericanPut);
            this.Controls.Add(this.radioButton_EuropeanPut);
            this.Controls.Add(this.radioButton_AmericanCall);
            this.Controls.Add(this.radioButton_EuropeanCall);
            this.Controls.Add(this.textBox_trials);
            this.Controls.Add(this.label_trials);
            this.Controls.Add(this.label_N);
            this.Controls.Add(this.textBox_N);
            this.Controls.Add(this.textBox_sigma);
            this.Controls.Add(this.label_sigma);
            this.Controls.Add(this.textBox_T);
            this.Controls.Add(this.label_T);
            this.Controls.Add(this.textBox_r);
            this.Controls.Add(this.label_r);
            this.Controls.Add(this.label_K);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.textBox_K);
            this.Controls.Add(this.label_S);
            this.Controls.Add(this.textBox_S);
            this.Name = "Form1";
            this.Text = "Optoin Price Calculator 1.0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_S)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_K)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_r)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_T)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_sigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_N)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_trials)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_S;
        private System.Windows.Forms.Label label_S;
        private System.Windows.Forms.TextBox textBox_K;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.ErrorProvider errorProvider_S;
        private System.Windows.Forms.Label label_K;
        private System.Windows.Forms.ErrorProvider errorProvider_K;
        private System.Windows.Forms.Label label_r;
        private System.Windows.Forms.TextBox textBox_r;
        private System.Windows.Forms.ErrorProvider errorProvider_r;
        private System.Windows.Forms.TextBox textBox_T;
        private System.Windows.Forms.Label label_T;
        private System.Windows.Forms.ErrorProvider errorProvider_T;
        private System.Windows.Forms.TextBox textBox_sigma;
        private System.Windows.Forms.Label label_sigma;
        private System.Windows.Forms.ErrorProvider errorProvider_sigma;
        private System.Windows.Forms.Label label_N;
        private System.Windows.Forms.TextBox textBox_N;
        private System.Windows.Forms.ErrorProvider errorProvider_N;
        private System.Windows.Forms.TextBox textBox_trials;
        private System.Windows.Forms.Label label_trials;
        private System.Windows.Forms.ErrorProvider errorProvider_trials;
        private System.Windows.Forms.RadioButton radioButton_AmericanPut;
        private System.Windows.Forms.RadioButton radioButton_EuropeanPut;
        private System.Windows.Forms.RadioButton radioButton_AmericanCall;
        private System.Windows.Forms.RadioButton radioButton_EuropeanCall;
        private System.Windows.Forms.Label label_OptionResult;
        private System.Windows.Forms.Label label_optionPrice;
        private System.Windows.Forms.Label label_DeltaResult;
        private System.Windows.Forms.Label label_Delta;
        private System.Windows.Forms.Label label_GammaResult;
        private System.Windows.Forms.Label label_Gamma;
        private System.Windows.Forms.Label label_VegaResult;
        private System.Windows.Forms.Label label_Vega;
        private System.Windows.Forms.Label label_ThetaResult;
        private System.Windows.Forms.Label label_Theta;
        private System.Windows.Forms.Label label_RhoResult;
        private System.Windows.Forms.Label label_Rho;
        private System.Windows.Forms.Label label_SEResult;
        private System.Windows.Forms.Label label_SE;
    }
}

