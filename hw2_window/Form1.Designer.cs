namespace hw2_window {
    partial class Form1 {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent() {
            this.caculate = new System.Windows.Forms.Button();
            this.txt_total_house_price = new System.Windows.Forms.TextBox();
            this.txt_down_payment = new System.Windows.Forms.TextBox();
            this.total_house_price = new System.Windows.Forms.Label();
            this.down_payment = new System.Windows.Forms.Label();
            this.annual_interest_rate = new System.Windows.Forms.Label();
            this.loan_term = new System.Windows.Forms.Label();
            this.grace_period = new System.Windows.Forms.Label();
            this.txt_annual_interest_rate = new System.Windows.Forms.TextBox();
            this.txt_loan_term = new System.Windows.Forms.TextBox();
            this.txt_grace_period = new System.Windows.Forms.TextBox();
            this.input = new System.Windows.Forms.GroupBox();
            this.valid_txt_annual_interest_rate = new System.Windows.Forms.Label();
            this.valid_txt_down_payment = new System.Windows.Forms.Label();
            this.valid_txt_grace_period = new System.Windows.Forms.Label();
            this.valid_txt_loan_term = new System.Windows.Forms.Label();
            this.valid_txt_total_house_price = new System.Windows.Forms.Label();
            this.input_finish = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_monthly_payment = new System.Windows.Forms.Label();
            this.txt_loan_amount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loan_amount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.monthly_payment = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.input.SuspendLayout();
            this.output.SuspendLayout();
            this.SuspendLayout();
            // 
            // caculate
            // 
            this.caculate.BackColor = System.Drawing.Color.Bisque;
            this.caculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.caculate.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.caculate.Location = new System.Drawing.Point(656, 185);
            this.caculate.Name = "caculate";
            this.caculate.Size = new System.Drawing.Size(135, 75);
            this.caculate.TabIndex = 0;
            this.caculate.Text = "計算";
            this.caculate.UseVisualStyleBackColor = false;
            this.caculate.Click += new System.EventHandler(this.caculate_Click);
            // 
            // txt_total_house_price
            // 
            this.txt_total_house_price.Location = new System.Drawing.Point(319, 26);
            this.txt_total_house_price.Name = "txt_total_house_price";
            this.txt_total_house_price.Size = new System.Drawing.Size(292, 29);
            this.txt_total_house_price.TabIndex = 1;
            this.txt_total_house_price.TextChanged += new System.EventHandler(this.txt_total_house_price_TextChanged);
            this.txt_total_house_price.Leave += new System.EventHandler(this.txt_total_house_price_Leave);
            // 
            // txt_down_payment
            // 
            this.txt_down_payment.Location = new System.Drawing.Point(319, 82);
            this.txt_down_payment.Name = "txt_down_payment";
            this.txt_down_payment.Size = new System.Drawing.Size(292, 29);
            this.txt_down_payment.TabIndex = 2;
            this.txt_down_payment.TextChanged += new System.EventHandler(this.txt_down_payment_TextChanged);
            this.txt_down_payment.Leave += new System.EventHandler(this.txt_down_payment_Leave);
            // 
            // total_house_price
            // 
            this.total_house_price.AutoSize = true;
            this.total_house_price.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.total_house_price.Location = new System.Drawing.Point(43, 34);
            this.total_house_price.Name = "total_house_price";
            this.total_house_price.Size = new System.Drawing.Size(223, 21);
            this.total_house_price.TabIndex = 3;
            this.total_house_price.Text = "房屋總價 (Total House Price)";
            this.total_house_price.Click += new System.EventHandler(this.label1_Click);
            // 
            // down_payment
            // 
            this.down_payment.AutoSize = true;
            this.down_payment.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.down_payment.Location = new System.Drawing.Point(43, 95);
            this.down_payment.Name = "down_payment";
            this.down_payment.Size = new System.Drawing.Size(90, 21);
            this.down_payment.TabIndex = 4;
            this.down_payment.Text = "自備款比例";
            this.down_payment.Click += new System.EventHandler(this.label2_Click);
            // 
            // annual_interest_rate
            // 
            this.annual_interest_rate.AutoSize = true;
            this.annual_interest_rate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.annual_interest_rate.Location = new System.Drawing.Point(43, 149);
            this.annual_interest_rate.Name = "annual_interest_rate";
            this.annual_interest_rate.Size = new System.Drawing.Size(247, 21);
            this.annual_interest_rate.TabIndex = 5;
            this.annual_interest_rate.Text = "貸款利率 (Annual Interest Rate)";
            // 
            // loan_term
            // 
            this.loan_term.AutoSize = true;
            this.loan_term.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.loan_term.Location = new System.Drawing.Point(43, 204);
            this.loan_term.Name = "loan_term";
            this.loan_term.Size = new System.Drawing.Size(170, 21);
            this.loan_term.TabIndex = 6;
            this.loan_term.Text = "貸款年限 (Loan Term)";
            this.loan_term.Click += new System.EventHandler(this.label4_Click);
            // 
            // grace_period
            // 
            this.grace_period.AutoSize = true;
            this.grace_period.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grace_period.Location = new System.Drawing.Point(43, 258);
            this.grace_period.Name = "grace_period";
            this.grace_period.Size = new System.Drawing.Size(211, 21);
            this.grace_period.TabIndex = 7;
            this.grace_period.Text = "寬限期 (Grace Period, 選填)";
            this.grace_period.Click += new System.EventHandler(this.grace_period_Click);
            // 
            // txt_annual_interest_rate
            // 
            this.txt_annual_interest_rate.Location = new System.Drawing.Point(319, 138);
            this.txt_annual_interest_rate.Name = "txt_annual_interest_rate";
            this.txt_annual_interest_rate.Size = new System.Drawing.Size(292, 29);
            this.txt_annual_interest_rate.TabIndex = 8;
            this.txt_annual_interest_rate.Leave += new System.EventHandler(this.txt_annual_interest_rate_Leave);
            // 
            // txt_loan_term
            // 
            this.txt_loan_term.Location = new System.Drawing.Point(319, 194);
            this.txt_loan_term.Name = "txt_loan_term";
            this.txt_loan_term.Size = new System.Drawing.Size(292, 29);
            this.txt_loan_term.TabIndex = 9;
            this.txt_loan_term.Leave += new System.EventHandler(this.txt_loan_term_Leave);
            // 
            // txt_grace_period
            // 
            this.txt_grace_period.Location = new System.Drawing.Point(319, 250);
            this.txt_grace_period.Name = "txt_grace_period";
            this.txt_grace_period.Size = new System.Drawing.Size(292, 29);
            this.txt_grace_period.TabIndex = 10;
            this.txt_grace_period.Leave += new System.EventHandler(this.txt_grace_period_Leave);
            // 
            // input
            // 
            this.input.Controls.Add(this.valid_txt_annual_interest_rate);
            this.input.Controls.Add(this.valid_txt_down_payment);
            this.input.Controls.Add(this.valid_txt_grace_period);
            this.input.Controls.Add(this.valid_txt_loan_term);
            this.input.Controls.Add(this.valid_txt_total_house_price);
            this.input.Controls.Add(this.input_finish);
            this.input.Controls.Add(this.label15);
            this.input.Controls.Add(this.label14);
            this.input.Controls.Add(this.label13);
            this.input.Controls.Add(this.label12);
            this.input.Controls.Add(this.label11);
            this.input.Controls.Add(this.txt_grace_period);
            this.input.Controls.Add(this.txt_loan_term);
            this.input.Controls.Add(this.txt_annual_interest_rate);
            this.input.Controls.Add(this.grace_period);
            this.input.Controls.Add(this.loan_term);
            this.input.Controls.Add(this.annual_interest_rate);
            this.input.Controls.Add(this.down_payment);
            this.input.Controls.Add(this.total_house_price);
            this.input.Controls.Add(this.txt_down_payment);
            this.input.Controls.Add(this.txt_total_house_price);
            this.input.Controls.Add(this.caculate);
            this.input.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.input.Location = new System.Drawing.Point(60, 27);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(813, 336);
            this.input.TabIndex = 11;
            this.input.TabStop = false;
            this.input.Text = "輸入";
            this.input.Enter += new System.EventHandler(this.input_Enter);
            // 
            // valid_txt_annual_interest_rate
            // 
            this.valid_txt_annual_interest_rate.AutoSize = true;
            this.valid_txt_annual_interest_rate.Location = new System.Drawing.Point(315, 170);
            this.valid_txt_annual_interest_rate.Name = "valid_txt_annual_interest_rate";
            this.valid_txt_annual_interest_rate.Size = new System.Drawing.Size(86, 21);
            this.valid_txt_annual_interest_rate.TabIndex = 23;
            this.valid_txt_annual_interest_rate.Text = "                   ";
            // 
            // valid_txt_down_payment
            // 
            this.valid_txt_down_payment.AutoSize = true;
            this.valid_txt_down_payment.Location = new System.Drawing.Point(315, 114);
            this.valid_txt_down_payment.Name = "valid_txt_down_payment";
            this.valid_txt_down_payment.Size = new System.Drawing.Size(86, 21);
            this.valid_txt_down_payment.TabIndex = 22;
            this.valid_txt_down_payment.Text = "                   ";
            this.valid_txt_down_payment.Click += new System.EventHandler(this.valid_txt_down_payment_Click_1);
            // 
            // valid_txt_grace_period
            // 
            this.valid_txt_grace_period.AutoSize = true;
            this.valid_txt_grace_period.Location = new System.Drawing.Point(315, 282);
            this.valid_txt_grace_period.Name = "valid_txt_grace_period";
            this.valid_txt_grace_period.Size = new System.Drawing.Size(86, 21);
            this.valid_txt_grace_period.TabIndex = 21;
            this.valid_txt_grace_period.Text = "                   ";
            // 
            // valid_txt_loan_term
            // 
            this.valid_txt_loan_term.AutoSize = true;
            this.valid_txt_loan_term.Location = new System.Drawing.Point(315, 226);
            this.valid_txt_loan_term.Name = "valid_txt_loan_term";
            this.valid_txt_loan_term.Size = new System.Drawing.Size(86, 21);
            this.valid_txt_loan_term.TabIndex = 20;
            this.valid_txt_loan_term.Text = "                   ";
            this.valid_txt_loan_term.Click += new System.EventHandler(this.label17_Click);
            // 
            // valid_txt_total_house_price
            // 
            this.valid_txt_total_house_price.AutoSize = true;
            this.valid_txt_total_house_price.Location = new System.Drawing.Point(315, 58);
            this.valid_txt_total_house_price.Name = "valid_txt_total_house_price";
            this.valid_txt_total_house_price.Size = new System.Drawing.Size(86, 21);
            this.valid_txt_total_house_price.TabIndex = 17;
            this.valid_txt_total_house_price.Text = "                   ";
            this.valid_txt_total_house_price.Click += new System.EventHandler(this.label16_Click);
            // 
            // input_finish
            // 
            this.input_finish.BackColor = System.Drawing.Color.LimeGreen;
            this.input_finish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.input_finish.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.input_finish.Location = new System.Drawing.Point(656, 42);
            this.input_finish.Name = "input_finish";
            this.input_finish.Size = new System.Drawing.Size(135, 75);
            this.input_finish.TabIndex = 16;
            this.input_finish.Text = "輸入完成";
            this.input_finish.UseVisualStyleBackColor = false;
            this.input_finish.Click += new System.EventHandler(this.input_finish_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(577, 253);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 21);
            this.label15.TabIndex = 15;
            this.label15.Text = "年";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(577, 197);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 21);
            this.label14.TabIndex = 14;
            this.label14.Text = "年";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(579, 141);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 21);
            this.label13.TabIndex = 13;
            this.label13.Text = "%";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(579, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 21);
            this.label12.TabIndex = 12;
            this.label12.Text = "%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(561, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 21);
            this.label11.TabIndex = 11;
            this.label11.Text = "萬元";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // output
            // 
            this.output.Controls.Add(this.label10);
            this.output.Controls.Add(this.label9);
            this.output.Controls.Add(this.label8);
            this.output.Controls.Add(this.txt_monthly_payment);
            this.output.Controls.Add(this.txt_loan_amount);
            this.output.Controls.Add(this.label1);
            this.output.Controls.Add(this.loan_amount);
            this.output.Controls.Add(this.label2);
            this.output.Controls.Add(this.monthly_payment);
            this.output.Controls.Add(this.label3);
            this.output.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.output.Location = new System.Drawing.Point(60, 415);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(813, 286);
            this.output.TabIndex = 12;
            this.output.TabStop = false;
            this.output.Text = "輸出";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label10.Location = new System.Drawing.Point(319, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(244, 23);
            this.label10.TabIndex = 22;
            this.label10.Text = "                                                          ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label9.Location = new System.Drawing.Point(319, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(244, 23);
            this.label9.TabIndex = 21;
            this.label9.Text = "                                                          ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label8.Location = new System.Drawing.Point(319, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(244, 23);
            this.label8.TabIndex = 20;
            this.label8.Text = "                                                          ";
            // 
            // txt_monthly_payment
            // 
            this.txt_monthly_payment.AutoSize = true;
            this.txt_monthly_payment.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_monthly_payment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt_monthly_payment.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_monthly_payment.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_monthly_payment.Location = new System.Drawing.Point(319, 104);
            this.txt_monthly_payment.Name = "txt_monthly_payment";
            this.txt_monthly_payment.Size = new System.Drawing.Size(244, 23);
            this.txt_monthly_payment.TabIndex = 19;
            this.txt_monthly_payment.Text = "                                                          ";
            // 
            // txt_loan_amount
            // 
            this.txt_loan_amount.AutoSize = true;
            this.txt_loan_amount.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_loan_amount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt_loan_amount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_loan_amount.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_loan_amount.Location = new System.Drawing.Point(319, 65);
            this.txt_loan_amount.Name = "txt_loan_amount";
            this.txt_loan_amount.Size = new System.Drawing.Size(244, 23);
            this.txt_loan_amount.TabIndex = 18;
            this.txt_loan_amount.Text = "                                                          ";
            this.txt_loan_amount.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(43, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "總還款金額";
            // 
            // loan_amount
            // 
            this.loan_amount.AutoSize = true;
            this.loan_amount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.loan_amount.Location = new System.Drawing.Point(43, 62);
            this.loan_amount.Name = "loan_amount";
            this.loan_amount.Size = new System.Drawing.Size(90, 21);
            this.loan_amount.TabIndex = 13;
            this.loan_amount.Text = "貸款總金額";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(43, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "總利息支出";
            // 
            // monthly_payment
            // 
            this.monthly_payment.AutoSize = true;
            this.monthly_payment.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.monthly_payment.Location = new System.Drawing.Point(43, 101);
            this.monthly_payment.Name = "monthly_payment";
            this.monthly_payment.Size = new System.Drawing.Size(174, 21);
            this.monthly_payment.TabIndex = 14;
            this.monthly_payment.Text = "每月應繳金額 (本 + 息)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(43, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "首期利息 與 首期本金";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 773);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input);
            this.Name = "Form1";
            this.Text = "房貸計算器";
            this.input.ResumeLayout(false);
            this.input.PerformLayout();
            this.output.ResumeLayout(false);
            this.output.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button caculate;
        private System.Windows.Forms.TextBox txt_total_house_price;
        private System.Windows.Forms.TextBox txt_down_payment;
        private System.Windows.Forms.Label total_house_price;
        private System.Windows.Forms.Label down_payment;
        private System.Windows.Forms.Label annual_interest_rate;
        private System.Windows.Forms.Label loan_term;
        private System.Windows.Forms.Label grace_period;
        private System.Windows.Forms.TextBox txt_annual_interest_rate;
        private System.Windows.Forms.TextBox txt_loan_term;
        private System.Windows.Forms.TextBox txt_grace_period;
        private System.Windows.Forms.GroupBox input;
        private System.Windows.Forms.GroupBox output;
        private System.Windows.Forms.Label txt_loan_amount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label loan_amount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label monthly_payment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txt_monthly_payment;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button input_finish;
        private System.Windows.Forms.Label valid_txt_total_house_price;
        private System.Windows.Forms.Label valid_txt_grace_period;
        private System.Windows.Forms.Label valid_txt_loan_term;
        private System.Windows.Forms.Label valid_txt_down_payment;
        private System.Windows.Forms.Label valid_txt_annual_interest_rate;
    }
}

