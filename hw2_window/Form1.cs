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

            if (valid_total_house_price && valid_down_payment && valid_annual_interest_rate && valid_loan_term && valid_grace_period) {
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
            int grace_period = int.Parse(txt_grace_period.Text);

            
        }

        private void grace_period_Click(object sender, EventArgs e) {

            
        }

        private void txt_total_house_price_TextChanged(object sender, EventArgs e) {
        }

        private void txt_total_house_price_Leave(object sender, EventArgs e) {  
            double total_price;
            bool valid_total_house_price = double.TryParse(txt_total_house_price.Text, out total_price);

            if (!string.IsNullOrWhiteSpace(txt_total_house_price.Text)) // 避免空白時就跳訊息
            {
                if (valid_total_house_price) {
                    if (total_price <= 0) {
                        MessageBox.Show("房屋價格須高於0。", "身高值錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else {
                    MessageBox.Show("請輸入有效的房屋價格。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txt_down_payment_Leave(object sender, EventArgs e) {
            double down_payment, total_price;
            bool valid_down_payment = double.TryParse(txt_down_payment.Text, out down_payment);
            total_price = double.Parse(txt_total_house_price.Text);

            if (!string.IsNullOrWhiteSpace(txt_total_house_price.Text)) { // 避免空白時就跳訊息
                if (valid_down_payment) {
                    if (down_payment < 0) {
                        MessageBox.Show("自備款須為非負數。", "自備款錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (down_payment > total_price) {
                        MessageBox.Show("自備款不能超過房屋價格。", "自備款錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else {
                    MessageBox.Show("請輸入有效的自備款。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            } 
                
        }

        private void txt_annual_interest_rate_Leave(object sender, EventArgs e) {
            double annual_interest_rate;
            bool valid_annual_interest_rate = double.TryParse(txt_annual_interest_rate.Text, out annual_interest_rate);
            if (!string.IsNullOrWhiteSpace(txt_annual_interest_rate.Text)) { // 避免空白時就跳訊息
                if (valid_annual_interest_rate) {
                    if (annual_interest_rate < 0) {
                        MessageBox.Show("年利率須為非負數。", "年利率錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else {
                    MessageBox.Show("請輸入有效的年利率。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            } 
        }

        private void txt_loan_term_Leave(object sender, EventArgs e) {
            int loan_term;
            bool valid_loan_term = int.TryParse(txt_loan_term.Text, out loan_term);
            if (!string.IsNullOrWhiteSpace(txt_loan_term.Text)) { // 避免空白時就跳訊息
                if (valid_loan_term) {
                    if (loan_term <= 0) {
                        MessageBox.Show("貸款年限須為正整數。", "貸款年限錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else {
                    MessageBox.Show("請輸入有效的貸款年限。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void txt_grace_period_Leave(object sender, EventArgs e) {
            int grace_period, loan_term;
            bool valid_grace_period = int.TryParse(txt_grace_period.Text, out grace_period);
            loan_term = int.Parse(txt_loan_term.Text);
            if (!string.IsNullOrWhiteSpace(txt_grace_period.Text)) { // 避免空白時就跳訊息
                if (valid_grace_period) {
                    if (grace_period < 0) {
                        MessageBox.Show("寬限期須為非負數。", "寬限期錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (grace_period >= loan_term) {
                        MessageBox.Show("寬限期不能大於或等於貸款年限。", "寬限期錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else {
                    MessageBox.Show("請輸入有效的寬限期。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void label6_Click(object sender, EventArgs e) {

        }

        private void label11_Click(object sender, EventArgs e) {

        }

        
    }
}
