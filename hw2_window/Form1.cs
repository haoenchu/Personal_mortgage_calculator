using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw2_window {
    public partial class Form1 : Form {


        public Form1() {
            InitializeComponent();
            caculate.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void input_Enter(object sender, EventArgs e) {

        }

        private void input_finish_Click(object sender, EventArgs e) {
            double total_price, down_payment, annual_interest_rate;
            int loan_term, grace_period;
            bool valid_total_house_price = double.TryParse(txt_total_house_price.Text, out total_price);
            bool valid_down_payment = double.TryParse(txt_down_payment.Text, out down_payment);
            bool valid_annual_interest_rate = double.TryParse(txt_annual_interest_rate.Text, out annual_interest_rate);
            bool valid_loan_term = int.TryParse(txt_loan_term.Text, out loan_term);
            bool valid_grace_period = int.TryParse(txt_grace_period.Text, out grace_period);

            if (string.IsNullOrWhiteSpace(txt_grace_period.Text))
            {
                grace_period = 0;
                valid_grace_period = true;  
            }
            else
            {
                valid_grace_period = int.TryParse(txt_grace_period.Text, out grace_period);
            }

            if (valid_total_house_price && valid_down_payment && valid_annual_interest_rate && valid_loan_term && valid_grace_period
                && !valid_txt_total_house_price.Visible  && !valid_txt_annual_interest_rate.Visible && !valid_txt_down_payment.Visible && !valid_txt_loan_term.Visible && !valid_txt_grace_period.Visible ) {
                caculate.Enabled = true;
            }
            else {
                MessageBox.Show("請確保所有輸入欄位都填寫正確。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                caculate.Enabled = false;
                
            }
        }
        private void caculate_Click(object sender, EventArgs e) {

            double total_price = double.Parse(txt_total_house_price.Text);
            double down_payment = double.Parse(txt_down_payment.Text);
            double annual_interest_rate = double.Parse(txt_annual_interest_rate.Text);
            int loan_term = int.Parse(txt_loan_term.Text);
            int grace_period;
            if (string.IsNullOrWhiteSpace(txt_grace_period.Text))
            {
                grace_period = 0;
                

            }
            else
            {
                grace_period = int.Parse(txt_grace_period.Text);
            }

            double loan_amount = total_price * (1 - down_payment / 100);
            double monthly_interest_rate = annual_interest_rate / 100 / 12;

            double first_monthly_payment = loan_amount * monthly_interest_rate;
            double monthly_payment = (loan_amount + first_monthly_payment) * monthly_interest_rate / (1 - Math.Pow(1 + monthly_interest_rate, -(loan_term - grace_period) * 12)); ;
           



            double principal_paid = monthly_payment - first_monthly_payment ;
            double total_repayment = monthly_payment * (loan_term - grace_period) * 12;
            double whole_interest_paid = total_repayment - loan_amount;


            txt_loan_amount.ForeColor = Color.Red;
            txt_loan_amount.Text = loan_amount.ToString("F2") + "萬元";


        }

        private void grace_period_Click(object sender, EventArgs e) {

            
        }

        private void txt_total_house_price_TextChanged(object sender, EventArgs e) {
        }

        private void txt_total_house_price_Leave(object sender, EventArgs e) {  
            double total_price;
            bool valid_total_house_price = double.TryParse(txt_total_house_price.Text, out total_price);
            valid_txt_total_house_price.ForeColor = Color.Red;

            if (!valid_total_house_price)
            {
                valid_txt_total_house_price.Text = "請輸入有效的房屋價格。";
                valid_txt_total_house_price.Visible = true;
                return;

            }
            else if (total_price < 0)
            {
                valid_txt_total_house_price.Text = "房屋價格不能低於0。";
                valid_txt_total_house_price.Visible = true;
                return;
            }
            valid_txt_total_house_price.Text = "";
            valid_txt_total_house_price.Visible = false;    


                
         
        }

        private void txt_down_payment_Leave(object sender, EventArgs e) {
            double down_payment, total_price;
            bool valid_down_payment = double.TryParse(txt_down_payment.Text, out down_payment);
            bool valid_total_house_price = double.TryParse(txt_total_house_price.Text, out total_price);
            valid_txt_down_payment.ForeColor = Color.Red;

            if (!valid_total_house_price)
            {
                valid_txt_down_payment.Text = "請先輸入有效的房屋價格。";
                valid_txt_down_payment.Visible = true;
                return; // 先確保房屋價格有效，再檢查頭期款
            }
            if (!valid_down_payment)
            {
                valid_txt_down_payment.Text = "請輸入有效的頭期款。";
                valid_txt_down_payment.Visible = true;
                return;
            }
            else if (down_payment < 0 || down_payment > 100)
            {
                valid_txt_down_payment.Text = "請輸入有效的區間。";
                valid_txt_down_payment.Visible = true;
                return;
            }
            valid_txt_down_payment.Text = "";
            valid_txt_down_payment.Visible = false;


        }

        private void txt_annual_interest_rate_Leave(object sender, EventArgs e) {
            double annual_interest_rate;
            bool valid_annual_interest_rate = double.TryParse(txt_annual_interest_rate.Text, out annual_interest_rate);
            valid_txt_annual_interest_rate.ForeColor = Color.Red;

            if (!valid_annual_interest_rate)
            {
                valid_txt_annual_interest_rate.Text = "請輸入有效的年利率。";
                valid_txt_annual_interest_rate.Visible = true;
                return;
            }
            else if (annual_interest_rate < 0 || annual_interest_rate > 100)
            {
                valid_txt_annual_interest_rate.Text = "請輸入有效的區間。";
                valid_txt_annual_interest_rate.Visible = true;
                return;
            }

            valid_txt_annual_interest_rate.Text = "";
            valid_txt_annual_interest_rate.Visible = false;

        }

        private void txt_loan_term_Leave(object sender, EventArgs e) {
            int loan_term;
            bool valid_loan_term = int.TryParse(txt_loan_term.Text, out loan_term);
            
            if (!valid_loan_term)
            {
                valid_txt_loan_term.Text = "請輸入有效的貸款年限。";
                valid_txt_loan_term.ForeColor = Color.Red;
                valid_txt_loan_term.Visible = true;
                return;
            }
            else if (loan_term <= 0)
            {
                valid_txt_loan_term.Text = "貸款年限必須大於0。";
                valid_txt_loan_term.ForeColor = Color.Red;
                valid_txt_loan_term.Visible = true;
                return;
            }
            valid_txt_loan_term.Text = "";
            valid_txt_loan_term.Visible = false;
            
        }

        private void txt_grace_period_Leave(object sender, EventArgs e) {
            int grace_period, loan_term;
            bool valid_grace_period = int.TryParse(txt_grace_period.Text, out grace_period);
            bool valid_loan_term = int.TryParse(txt_loan_term.Text, out loan_term);

            if (!valid_loan_term)
            {
                valid_txt_grace_period.Text = "請先輸入有效的貸款年限。";
                valid_txt_grace_period.ForeColor = Color.Red;
                valid_txt_grace_period.Visible = true;
                return; // 先確保貸款年限有效，再檢查寬限期
            }

            if (!string.IsNullOrWhiteSpace(txt_grace_period.Text))
            {
                if (!valid_grace_period)
                {
                    valid_txt_grace_period.Text = "請輸入有效的寬限期。";
                    valid_txt_grace_period.ForeColor = Color.Red;
                    valid_txt_grace_period.Visible = true;
                    return;
                }
                else if (grace_period < 0)
                {
                    valid_txt_grace_period.Text = "寬限期不能為負數。";
                    valid_txt_grace_period.ForeColor = Color.Red;
                    valid_txt_grace_period.Visible = true;
                    return;
                }
                else if (grace_period >= loan_term)
                {
                    valid_txt_grace_period.Text = "寬限期必須小於貸款年限。";
                    valid_txt_grace_period.ForeColor = Color.Red;
                    valid_txt_grace_period.Visible = true;
                    return;
                }
            }
            valid_txt_grace_period.Text = "";
            valid_txt_grace_period.Visible = false;

        }

        private void label6_Click(object sender, EventArgs e) {

        }

        private void label11_Click(object sender, EventArgs e) {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void valid_txt_down_payment_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click_1(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void valid_txt_down_payment_Click_1(object sender, EventArgs e)
        {

        }

        private void txt_down_payment_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
