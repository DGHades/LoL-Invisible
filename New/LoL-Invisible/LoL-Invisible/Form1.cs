using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ObjectClass;
using PoniLCU;
using System.Collections.Specialized;
using System.Text;
using static PoniLCU.LeagueClient;

namespace LoL_Invisible
{
    public partial class Form1 : Form
    {
        private LeagueClient leagueClient;
        private Root? _Root;
        private bool _ClientConnected;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConnectClient();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            ConnectClient();
        }

        private async void btn_offline_Click(object sender, EventArgs e)
        {
            GetData();

            if (_Root == null)
                return;

            _Root.availability = "offline";

            SendData();
        }

        private async void btn_online_Click(object sender, EventArgs e)
        {
            GetData();

            if (_Root == null)
                return;

            _Root.availability = "chat";

            SendData();
        }

        private async void GetData()
        {
            string data = await leagueClient.Request(requestMethod.GET, "/lol-chat/v1/me");
            _Root = JsonConvert.DeserializeObject<Root>(data);
        }

        private async void SendData()
        {
            string body = JsonConvert.SerializeObject(_Root);
            await leagueClient.Request(requestMethod.PUT, "/lol-chat/v1/me", body);
        }

        private void ConnectClient()
        {
            if (_ClientConnected)
                return;

            leagueClient = new LeagueClient(credentials.cmd);
            if (leagueClient != null)
            {
                txt_connection.BackColor = Color.Green;
                txt_connection.Text = "Connection Successfull";
                _ClientConnected = true;
            }
            else
            {
                txt_connection.BackColor = Color.Red;
                txt_connection.Text = "Connection Unsuccessfull";
            }
        }
    }
}