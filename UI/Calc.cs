using WindowsForms.Model;

namespace WindowsForms.UI
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
        }

        private void BtnSum_Click(object sender, EventArgs e) => LabelShowRes.Text = Calculating(TxtBoxNum1.Text, TxtBoxNum2.Text, OP.Sum).ToString();

        private void BtnSub_Click(object sender, EventArgs e) => LabelShowRes.Text = Calculating(TxtBoxNum1.Text, TxtBoxNum2.Text, OP.Subtract).ToString();

        private void BtnMult_Click(object sender, EventArgs e) => LabelShowRes.Text = Calculating(TxtBoxNum1.Text, TxtBoxNum2.Text, OP.Multiply).ToString();

        private void BtnDiv_Click(object sender, EventArgs e) => LabelShowRes.Text = Calculating(TxtBoxNum1.Text, TxtBoxNum2.Text, OP.Divide).ToString();

        private double Calculating(string number1, string number2, OP op)
        {
            double num1 = Convert.ToDouble(number1);
            double num2 = Convert.ToDouble(number2);
            return op switch
            {
                (OP.Sum) => num1 + num2,
                (OP.Subtract) => num1 - num2,
                (OP.Divide) => num1 / num2,
                (OP.Multiply) => num1 * num2,
                _ => throw new NotImplementedException(),
            };
        }
    }
}
