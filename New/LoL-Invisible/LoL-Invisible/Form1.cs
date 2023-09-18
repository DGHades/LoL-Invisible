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
        private EStatus _CurrentStatus;
        private bool _Moving = false;
        private Point _Offset;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConnectClient();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            _Moving = true;
            _Offset = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_Moving)
            {
                Point newlocation = this.Location;
                newlocation.X += e.X - _Offset.X;
                newlocation.Y += e.Y - _Offset.Y;
                this.Location = newlocation;
            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (_Moving)
            {
                _Moving = false;
            }
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
            UpdateStatus();
            SendData();
        }

        private void btn_away_Click(object sender, EventArgs e)
        {
            GetData();

            if (_Root == null)
                return;

            _Root.availability = "away";
            UpdateStatus();
            SendData();
        }

        private async void btn_online_Click(object sender, EventArgs e)
        {
            GetData();

            if (_Root == null)
                return;

            _Root.availability = "chat";
            UpdateStatus();
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
                GetData();
                UpdateStatus();
            }
            else
            {
                txt_connection.BackColor = Color.Red;
                txt_connection.Text = "Connection Unsuccessfull";
            }
        }

        private void UpdateStatus()
        {
            if (_Root == null)
                return;

            if (_Root.availability == "chat")
                _CurrentStatus = EStatus.CHAT;
            else if (_Root.availability == "away")
                _CurrentStatus = EStatus.AWAY;
            else if (_Root.availability == "offline")
                _CurrentStatus = EStatus.OFFLINE;

            UpdateHUD();
        }

        private void UpdateHUD()
        {
            switch (_CurrentStatus)
            {
                case EStatus.OFFLINE:
                    txt_currentStatus.BackColor = Color.DarkGray;
                    break;
                case EStatus.AWAY:
                    txt_currentStatus.BackColor = Color.Red;
                    break;
                case EStatus.CHAT:
                    txt_currentStatus.BackColor = Color.Green;
                    break;
                default:
                    break;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}