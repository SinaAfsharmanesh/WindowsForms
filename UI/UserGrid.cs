using WindowsForms.Model;
using static WindowsForms.InternalDB.Users;

namespace WindowsForms.UI
{
    public partial class UserGrid : Form
    {
        public UserGrid()
        {
            InitializeComponent();
        }

        private void refresh()
        {
            User.Read();
            dataGridView1.DataSource = UsersList;
            dataGridView1.Refresh();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void dataGridView1_Delete(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.OwningColumn.Name != "Delete") { return; }

            new User().Delete(Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value));
            refresh();
            MessageBox.Show("User Deleted");
        }

        private void dataGridView1_Edit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.OwningColumn.Name != "Edit") { return; }

            UserEdit w = new(UsersList!.Find(x => x!.Id == Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value)));
            w.ShowDialog();

            if (w.IsDisposed)
                refresh();
        }
    }
}
