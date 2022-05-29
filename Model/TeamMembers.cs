using WindowsForms.Services;


namespace WindowsForms.Model
{
    public class TeamMembers
    {
        public enum Teams
        {
            Esteghlal,
            Presepolis
        }
        public TeamMembers(string firstname, string lastname, DateTime dob, bool vip, Teams team)
        {
            FirstName = firstname;
            LastName = lastname;
            DOB = dob;
            VIP = vip;
            Team = team;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public DateTime DOB { get; }
        public bool VIP { get; }
        public Teams Team { get; }

        public string GetMemberDetail()
        {
            string vip = "";
            if (VIP)
                vip = "✨";
            return string.Format("{0} {1} {2} {3}", vip, FirstName, LastName, DOB.Miladi_Jalali());
        }
    }
}
