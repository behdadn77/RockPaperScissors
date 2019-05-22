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
        public Form1()
        {
            InitializeComponent();
        }
        enum RPS { rock, paper, scissors };
        Dictionary<RPS, Bitmap> rpsPicture = new Dictionary<RPS, Bitmap>()
        {
            {RPS.rock,new Bitmap(Properties.Resources.rock)},
            {RPS.paper,new Bitmap(Properties.Resources.paper)},
            {RPS.scissors,new Bitmap(Properties.Resources.scissors)},
        };
        Socket socketClient;
        Socket socketServer;
        Thread thread;
        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            buttonConnect.Text = "Waiting for connection...";
            buttonConnect.Enabled = false;
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse(textboxIP.Text), int.Parse(textboxPort.Text));
            try
            {
                if (radioHost.Checked)
                {
                    socketServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    socketServer.Bind(iPEndPoint);
                    socketServer.Listen(1);
                    socketClient = socketServer.Accept();
                }
                if (radioClient.Checked)
                {
                    socketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    socketClient.Connect(iPEndPoint);
                }
                buttonConnect.Text = "Connected";
                panelGame.Enabled = true;

            }
            catch (Exception)
            {
                MessageBox.Show("Connection Failed!");
                buttonConnect.Text = "Connect";
                buttonConnect.Enabled = true;
            }

            thread = new Thread(new ThreadStart(GetOppnentResult));
            thread.Start();
        }


        RPS? yourSelection = null;
        RPS? opponentSelection = null;
        private void GetOppnentResult()
        {
            try
            {
                byte[] b = new byte[4];
                while (true)
                {
                    if (socketClient.Receive(b) > 0)
                    {
                        this.Invoke(new Action(() =>
                        {
                            opponentSelection = (RPS)(BitConverter.ToInt32(b,0));
                            Result();
                        }));
                        //Thread.CurrentThread.Abort();
                    }
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }
        }

        private void UserSelected(RPS option)
        {
            yourSelection = option;
            pictureBoxYou.Image = rpsPicture[option];
            panelRPS.Enabled = false;
            if (socketClient != null)
            {
                socketClient.Send(BitConverter.GetBytes((int)option));
                Result();
            }
            else
            {
                MessageBox.Show("Connection Failed!");
            }
        }

        private void Result()
        {
            if (yourSelection != null && opponentSelection != null)
            {
                pictureBoxOpponent.Image = rpsPicture[(RPS)opponentSelection];
                if (yourSelection == opponentSelection)
                {
                    labelStatus.Text = "! TIE !";
                }
                else if (yourSelection == opponentSelection+1 || (yourSelection == RPS.rock && opponentSelection == RPS.scissors))
                {
                    labelStatus.Text = "! YOU WON !";
                }
                else
                {
                    labelStatus.Text = "! YOU LOST !";
                }
                buttonAgain.Visible = true;
                yourSelection = null;
                opponentSelection = null;
            }
        }

        private void ButtonAgain_Click(object sender, EventArgs e)
        {
            panelRPS.Enabled = true;
            pictureBoxOpponent.Image = null;
            pictureBoxYou.Image = null;
            labelStatus.Text = "";
            buttonAgain.Visible = false;
        }

        private void ButtonRock_Click(object sender, EventArgs e) => UserSelected(RPS.rock);

        private void ButtonPaper_Click(object sender, EventArgs e) => UserSelected(RPS.paper);

        private void ButtonScissors_Click(object sender, EventArgs e) => UserSelected(RPS.scissors);

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thread != null)
            {
                thread.Abort();
            }
            try
            {
                if (socketClient!=null)
                {
                    socketClient.Shutdown(SocketShutdown.Both);
                }
                if (socketServer!=null)
                {
                    socketServer.Shutdown(SocketShutdown.Both);
                }
            }
            catch (Exception)
            {

            }
        }

    }
}
