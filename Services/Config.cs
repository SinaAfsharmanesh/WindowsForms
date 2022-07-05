namespace WindowsForms.Services
{
    public class Config
    {
        private AppSetttings appsetttings = new AppSetttings();

        public class AppSetttings
        {
            public string ConnectonString { set; get; } = "";
        }

        public AppSetttings appSetttings
        {
            get => appsetttings;
            set => appsetttings = value;
        }
    }
}
