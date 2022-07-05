using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Text.Json;
using System.Text.Json.Serialization;
using WindowsForms.Services;

namespace WindowsForms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private string _connection;
        private string _dbName;
        private string _server;
        private string _trust;
        readonly Config _config = new ConfigurationBuilder()
            .SetBasePath(Environment.CurrentDirectory)
            .AddJsonFile("appsettings.json")
            .Build()
            .Get<Config>();

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //MAKE THE CONNECTION STRING 
            _server = textServer.Text;
            _dbName = textDbName.Text;
            if (checkBoxTrusted.Checked)
                _trust = "True";

            _connection = $"Server={_server};Database={_dbName};Trusted_Connection={_trust}";

            //TEST THE CONNECTION
            try
            {
                using SqlConnection conn = new SqlConnection(_config.appSetttings.ConnectonString);
                conn.Open();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //WRITE THE STRING INTO APPSETTINGS.JSON
            _config.appSetttings.ConnectonString = _connection;
            var jsonWriteOptions = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            jsonWriteOptions.Converters.Add(new JsonStringEnumConverter());

            var newJson = JsonSerializer.Serialize(_config, jsonWriteOptions);

            var appSettingsPath = Path.Combine("D:\\Visual Studio\\WindowsForms", "appsettings.json");
            File.WriteAllText(appSettingsPath, newJson);

            Dispose();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
