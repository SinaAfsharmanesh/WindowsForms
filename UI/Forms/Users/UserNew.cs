using WindowsForms.Model;
using WindowsForms.Services;

namespace WindowsForms.UI
{
    public partial class UserNew : Form
    {
        public UserNew()
        {
            InitializeComponent();
        }
        Repo repo = Repo.Instance;
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            repo.Add(new User(textBox1.Text, textBox2.Text, textBox3.Text, dateTimePicker1.Value, textBox4.Text, textBox5.Text, true));
            Dispose();
        }
    }
}
