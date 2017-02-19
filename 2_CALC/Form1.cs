using System;
using System.Windows.Forms;

namespace _2_CALC
{
    public partial class calculator : Form
    {
        private double firstNumber = 0;
        private string sign = "";

        public calculator()
        {
            InitializeComponent();
        }
        
        private void bt_Digit(object sender, EventArgs e)
        {            
           if (txtResult.Text != "0" && sign == "")
               txtResult.Text += (sender as Button).Text; 
           else
               txtResult.Text = (sender as Button).Text; 
        }

        private void bt_C(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void bt_Sign(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtResult.Text);
            sign = (sender as Button).Text;
        }

        private void bt_Dot(object sender, EventArgs e)
        {
            if (!txtResult.Text.Contains(","))
                txtResult.Text += ",";
        }

        private void bt_Equal(object sender, EventArgs e)
        {
            double doubleNumber = Convert.ToDouble(txtResult.Text);
            switch (sign)
            {
                case "+":
                    txtResult.Text = (firstNumber + doubleNumber).ToString();
                    break;
                case "-":
                    txtResult.Text = (firstNumber - doubleNumber).ToString();
                    break;
                case "/":
                    if(doubleNumber != 0)
                        txtResult.Text = (firstNumber / doubleNumber).ToString();
                    else
                        MessageBox.Show("Nie dziel przez 0!", "Błąd");
                    break;
                case "*":
                    txtResult.Text = (firstNumber * doubleNumber).ToString();
                    break;
            }

            sign = "";
            firstNumber = Convert.ToDouble(txtResult.Text);
        }
    }
}
