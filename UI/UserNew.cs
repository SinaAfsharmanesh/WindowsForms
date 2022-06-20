using WindowsForms.Model;

namespace WindowsForms.UI
{
    public partial class UserNew : Form
    {
        public UserNew()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User(textBox1.Text, textBox2.Text, textBox3.Text, dateTimePicker1.Value, textBox4.Text, textBox5.Text, true);
                user.Insert(user);
                MessageBox.Show("User added");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                throw;
            }
        }
    }
}
