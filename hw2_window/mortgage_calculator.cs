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
using System.Windows.Forms.DataVisualization.Charting;

namespace hw2_window {
    public partial class mortgage_calculator : Form {


        public mortgage_calculator() {
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
            return;
        }
        private void caculate_Click(object sender, EventArgs e) {

            double total_price = double.Parse(txt_total_house_price.Text) * 10000; ;
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

            double loan_amount = total_price * (1 - down_payment / 100); // 貸款總金額
            double monthly_rate = annual_interest_rate / 100 / 12;// 月利率
            int total_months = loan_term * 12; // 總期數
            int grace_months = grace_period * 12; // 寬限期期數
            int repayment_months = total_months - grace_months; // 實際還本金期數

            //計算每月應繳金額
            double monthly_payment = 0;
            if (monthly_rate > 0)
            {
                monthly_payment = (loan_amount * monthly_rate * Math.Pow(1 + monthly_rate, repayment_months))
                                 / (Math.Pow(1 + monthly_rate, repayment_months) - 1);
            }
            else
            {
                monthly_payment = loan_amount / repayment_months;
            }

            //首期計算
            double first_monthly_interest = loan_amount * monthly_rate; // 首期利息
            double first_principal = (grace_months > 0) ? 0 : (monthly_payment - first_monthly_interest); // 首期本金

            //總計支出計算
            double total_repayment = (grace_months * first_monthly_interest) + (repayment_months * monthly_payment);
            double total_interest = total_repayment - loan_amount;

            // 6. 輸出結果 (格式化為千分位)
            txt_loan_amount.Text = loan_amount.ToString("N0");
            txt_monthly_payment.Text = (grace_months > 0)
                ? $"寬限期: {first_monthly_interest:N0}\n之後: {monthly_payment:N0}"
                : monthly_payment.ToString("N0");
            txt_first_interest.Text = first_monthly_interest.ToString("N0");
            txt_first_principal_paid.Text = first_principal.ToString("N0");
            txt_total_interest_paid.Text = total_interest.ToString("N0");
            txt_total_repayment.Text = total_repayment.ToString("N0");

            //圖表
            // 1. 清除舊資料
            chartMortgage.Series.Clear();
            chartMortgage.Titles.Clear();

            // 2. 建立新的數列 (Series)
            Series series = new Series("MortgageRet");
            series.ChartType = SeriesChartType.Pie; // 設定為圓餅圖
            series["PieLabelStyle"] = "Outside"; // 標籤顯示在圓餅外
            series.IsValueShownAsLabel = true;    // 顯示數值
            

            // 3. 加入數據點 (本金 vs 利息)
            // 注意：這裡傳入的是數值，標籤設為 "本金" 與 "利息"
            DataPoint p1 = new DataPoint(0, loan_amount);
            p1.LegendText = "貸款本金";
            p1.Label = $"本金: {loan_amount:N0}";
            p1.Color = Color.LightSkyBlue;

            DataPoint p2 = new DataPoint(0, total_interest);
            p2.LegendText = "總利息支出";
            p2.Label = $"利息: {total_interest:N0}";
            p2.Color = Color.Salmon;

            series.Points.Add(p1);
            series.Points.Add(p2);

            // 4. 將數列加入 Chart 並美化
            chartMortgage.Series.Add(series);
            chartMortgage.Titles.Add("還款總額比例圖");
            chartMortgage.Legends[0].Enabled = true; // 顯示圖例
            chartMortgage.Visible = true;

            caculate.Enabled = false;
            return;
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
            return;


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
            return;
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
            return;
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
            return;
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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void loan_amount_Click(object sender, EventArgs e)
        {

        }

        private void valid_txt_grace_period_Click(object sender, EventArgs e)
        {

        }

        private void txt_annual_interest_rate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_loan_term_TextChanged(object sender, EventArgs e)
        {

        }

        private void valid_txt_annual_interest_rate_Click(object sender, EventArgs e)
        {

        }

        private void txt_grace_period_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void annual_interest_rate_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void monthly_payment_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_monthly_payment_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
