using WindowsForms.Model;
namespace WindowsForms.UI
{
    public partial class Teams : Form
    {

        public Teams()
        {
            InitializeComponent();
        }


        private void Teams_Load(object sender, EventArgs e)
        {
            ListTeams.DataSource = Enum.GetValues(typeof(TeamMembers.Teams)).Cast<TeamMembers.Teams>().ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var member = new TeamMembers(txtBoxFirstName.Text, txtBoxLastName.Text, DOBPick.Value, checkVip.Checked, Enum.Parse<TeamMembers.Teams>(ListTeams.Text));
            if (member.Team == 0)
            {
                listBoxBlue.Items.Add(member.GetMemberDetail());
            }
            else
            {
                ListBoxRed.Items.Add(member.GetMemberDetail());
            }
        }
    }
}
