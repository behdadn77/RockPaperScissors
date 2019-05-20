using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        Socket socketClient;
        public Form1()
        {
            InitializeComponent();
        }
        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse(textboxIP.Text), int.Parse(textboxPort.Text));
            if (radioHost.Checked)
            {
                Socket socketServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socketServer.Bind(iPEndPoint);
                socketServer.Listen(1);
                socketClient = socketServer.Accept();
            }
            if (radioClient.Checked)
            {
                socketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socketClient.Connect(iPEndPoint);
            }
            Thread thread = new Thread(new ThreadStart(GetOppnentResult));
            thread.Start();
        }


        RPS? yourSelection=null;
        RPS? opponentSelection=null;
        private void GetOppnentResult()
        {
            try
            {
                byte[] b = new byte[1];
                while (true)
                {
                    int r = socketClient.Receive(b);
                    if (r > 0)
                    {
                        this.Invoke(new Action(() =>
                        {
                            opponentSelection = (RPS)b[0];
                            Result();
                        }));
                        Thread.CurrentThread.Abort();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UserSelected(RPS option)
        {
            yourSelection = option;
            pictureBoxYou.Image = rpsPicture[option];
            panelRPS.Enabled = false;
            socketClient.Send(new byte[1] { Convert.ToByte(option) });
            Result();
        }

        private void Result()
        {
            if (yourSelection!=null&&opponentSelection!=null)
            {
                MessageBox.Show(opponentSelection.ToString());
            }
        }

        enum RPS { rock, paper, scissors };
        Dictionary<RPS, Bitmap> rpsPicture = new Dictionary<RPS, Bitmap>()
        {
            {RPS.rock,new Bitmap(Properties.Resources.rock)},
            {RPS.paper,new Bitmap(Properties.Resources.paper)},
            {RPS.scissors,new Bitmap(Properties.Resources.scissors)},
        };

        private void ButtonRock_Click(object sender, EventArgs e) => UserSelected(RPS.rock);

        private void ButtonPaper_Click(object sender, EventArgs e) => UserSelected(RPS.paper);

        private void ButtonScissors_Click(object sender, EventArgs e) => UserSelected(RPS.scissors);

    }
}
