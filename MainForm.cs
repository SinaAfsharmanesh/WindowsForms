using WindowsForms.UI;
namespace WindowsForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnAddPrdct_Click(object sender, EventArgs e)
        {
            ListPrdct.Items.Add(TxtBoxAddPrdct.Text);
        }

        private void BtnShowCalc_Click(object sender, EventArgs e)
        {
            new Calc().Show();
        }


    }
}