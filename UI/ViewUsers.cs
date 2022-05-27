using static WindowsForms.DB.InternalDb;

namespace WindowsForms.UI;

public partial class ViewUsers : Form
{
    private int Id;

    public ViewUsers(int id = 0)
    {
        InitializeComponent();
        Id = id;
        label2.Text = UsersList[id].Id.ToString();
        label4.Text = UsersList[id].FirstName;
        label6.Text = UsersList[id].LastName;
        label8.Text = UsersList[id].Email;
        label10.Text = UsersList[id].Tel.ToString();
    }

    private void ViewUsers_Load(object sender, EventArgs e)
    {
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        UserEdit w = new(Id);
        w.ShowDialog();
        if (w.IsDisposed)
        {
            label2.Text = UsersList[Id].Id.ToString();
            label4.Text = UsersList[Id].FirstName;
            label6.Text = UsersList[Id].LastName;
            label8.Text = UsersList[Id].Email;
            label10.Text = UsersList[Id].Tel.ToString();
        }
    }

    private void bntDel_Click(object sender, EventArgs e)
    {
        if (Id != 0)
            DelUser(Id);
        if (Id == 1)
        {
            btnNext_Click(sender, e);
        }
        else
        {
            btnPrev_Click(sender, e);
        }
    }

    private void btnNew_Click(object sender, EventArgs e)
    {
        UserNew w = new();
        w.ShowDialog();
        if (w.IsDisposed)
        {
            btnLast_Click(sender, e);
        }
    }

    private void btnLast_Click(object sender, EventArgs e)
    {
        Id = UsersList.Count - 1;
        label2.Text = UsersList[Id].Id.ToString();
        label4.Text = UsersList[Id].FirstName;
        label6.Text = UsersList[Id].LastName;
        label8.Text = UsersList[Id].Email;
        label10.Text = UsersList[Id].Tel.ToString();
    }

    private void btnPrev_Click(object sender, EventArgs e)
    {
        if (Id > 1)
        {
            Id--;
            label2.Text = UsersList[Id].Id.ToString();
            label4.Text = UsersList[Id].FirstName;
            label6.Text = UsersList[Id].LastName;
            label8.Text = UsersList[Id].Email;
            label10.Text = UsersList[Id].Tel.ToString();
        }
    }

    private void btnNext_Click(object sender, EventArgs e)
    {
        if (Id != UsersList.Count - 1)
        {
            Id++;
            label2.Text = UsersList[Id].Id.ToString();
            label4.Text = UsersList[Id].FirstName;
            label6.Text = UsersList[Id].LastName;
            label8.Text = UsersList[Id].Email;
            label10.Text = UsersList[Id].Tel.ToString();
        }
    }


    private void btnFirst_Click(object sender, EventArgs e)
    {
        Id = 1;
        label2.Text = UsersList[Id].Id.ToString();
        label4.Text = UsersList[Id].FirstName;
        label6.Text = UsersList[Id].LastName;
        label8.Text = UsersList[Id].Email;
        label10.Text = UsersList[Id].Tel.ToString();
    }
}