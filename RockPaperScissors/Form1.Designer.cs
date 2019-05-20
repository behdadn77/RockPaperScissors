namespace RockPaperScissors
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioHost = new System.Windows.Forms.RadioButton();
            this.radioClient = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxIP = new System.Windows.Forms.TextBox();
            this.textboxPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.panelGame = new System.Windows.Forms.Panel();
            this.panelRPS = new System.Windows.Forms.Panel();
            this.buttonScissors = new System.Windows.Forms.Button();
            this.buttonPaper = new System.Windows.Forms.Button();
            this.buttonRock = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxOpponent = new System.Windows.Forms.PictureBox();
            this.pictureBoxYou = new System.Windows.Forms.PictureBox();
            this.buttonAgain = new System.Windows.Forms.Button();
            this.panelGame.SuspendLayout();
            this.panelRPS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpponent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYou)).BeginInit();
            this.SuspendLayout();
            // 
            // radioHost
            // 
            this.radioHost.AutoSize = true;
            this.radioHost.Checked = true;
            this.radioHost.Location = new System.Drawing.Point(13, 8);
            this.radioHost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioHost.Name = "radioHost";
            this.radioHost.Size = new System.Drawing.Size(61, 24);
            this.radioHost.TabIndex = 0;
            this.radioHost.TabStop = true;
            this.radioHost.Text = "Host";
            this.radioHost.UseVisualStyleBackColor = true;
            // 
            // radioClient
            // 
            this.radioClient.AutoSize = true;
            this.radioClient.Location = new System.Drawing.Point(82, 8);
            this.radioClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioClient.Name = "radioClient";
            this.radioClient.Size = new System.Drawing.Size(67, 24);
            this.radioClient.TabIndex = 1;
            this.radioClient.Text = "Client";
            this.radioClient.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP Address:";
            // 
            // textboxIP
            // 
            this.textboxIP.Location = new System.Drawing.Point(253, 7);
            this.textboxIP.Name = "textboxIP";
            this.textboxIP.Size = new System.Drawing.Size(120, 26);
            this.textboxIP.TabIndex = 3;
            this.textboxIP.Text = "127.0.0.1";
            // 
            // textboxPort
            // 
            this.textboxPort.Location = new System.Drawing.Point(427, 7);
            this.textboxPort.Name = "textboxPort";
            this.textboxPort.Size = new System.Drawing.Size(78, 26);
            this.textboxPort.TabIndex = 5;
            this.textboxPort.Text = "8080";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port:";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(5, 39);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(500, 38);
            this.buttonConnect.TabIndex = 6;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // panelGame
            // 
            this.panelGame.Controls.Add(this.panelRPS);
            this.panelGame.Controls.Add(this.labelStatus);
            this.panelGame.Controls.Add(this.label4);
            this.panelGame.Controls.Add(this.label3);
            this.panelGame.Controls.Add(this.pictureBoxOpponent);
            this.panelGame.Controls.Add(this.pictureBoxYou);
            this.panelGame.Enabled = false;
            this.panelGame.Location = new System.Drawing.Point(5, 83);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(500, 381);
            this.panelGame.TabIndex = 7;
            // 
            // panelRPS
            // 
            this.panelRPS.Controls.Add(this.buttonScissors);
            this.panelRPS.Controls.Add(this.buttonPaper);
            this.panelRPS.Controls.Add(this.buttonRock);
            this.panelRPS.Location = new System.Drawing.Point(0, 297);
            this.panelRPS.Name = "panelRPS";
            this.panelRPS.Size = new System.Drawing.Size(500, 85);
            this.panelRPS.TabIndex = 22;
            // 
            // buttonScissors
            // 
            this.buttonScissors.Location = new System.Drawing.Point(348, 8);
            this.buttonScissors.Name = "buttonScissors";
            this.buttonScissors.Size = new System.Drawing.Size(144, 68);
            this.buttonScissors.TabIndex = 15;
            this.buttonScissors.Text = "Scissors";
            this.buttonScissors.UseVisualStyleBackColor = true;
            this.buttonScissors.Click += new System.EventHandler(this.ButtonScissors_Click);
            // 
            // buttonPaper
            // 
            this.buttonPaper.Location = new System.Drawing.Point(180, 8);
            this.buttonPaper.Name = "buttonPaper";
            this.buttonPaper.Size = new System.Drawing.Size(144, 68);
            this.buttonPaper.TabIndex = 14;
            this.buttonPaper.Text = "Paper";
            this.buttonPaper.UseVisualStyleBackColor = true;
            this.buttonPaper.Click += new System.EventHandler(this.ButtonPaper_Click);
            // 
            // buttonRock
            // 
            this.buttonRock.Location = new System.Drawing.Point(7, 8);
            this.buttonRock.Name = "buttonRock";
            this.buttonRock.Size = new System.Drawing.Size(144, 68);
            this.buttonRock.TabIndex = 13;
            this.buttonRock.Text = "Rock";
            this.buttonRock.UseVisualStyleBackColor = true;
            this.buttonRock.Click += new System.EventHandler(this.ButtonRock_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelStatus.Location = new System.Drawing.Point(0, -1);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(497, 93);
            this.labelStatus.TabIndex = 21;
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Opponent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "You";
            // 
            // pictureBoxOpponent
            // 
            this.pictureBoxOpponent.Location = new System.Drawing.Point(262, 105);
            this.pictureBoxOpponent.Name = "pictureBoxOpponent";
            this.pictureBoxOpponent.Size = new System.Drawing.Size(235, 144);
            this.pictureBoxOpponent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOpponent.TabIndex = 18;
            this.pictureBoxOpponent.TabStop = false;
            // 
            // pictureBoxYou
            // 
            this.pictureBoxYou.Location = new System.Drawing.Point(0, 105);
            this.pictureBoxYou.Name = "pictureBoxYou";
            this.pictureBoxYou.Size = new System.Drawing.Size(235, 144);
            this.pictureBoxYou.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxYou.TabIndex = 17;
            this.pictureBoxYou.TabStop = false;
            // 
            // buttonAgain
            // 
            this.buttonAgain.Location = new System.Drawing.Point(13, 471);
            this.buttonAgain.Name = "buttonAgain";
            this.buttonAgain.Size = new System.Drawing.Size(484, 29);
            this.buttonAgain.TabIndex = 8;
            this.buttonAgain.Text = "Play again!";
            this.buttonAgain.UseVisualStyleBackColor = true;
            this.buttonAgain.Visible = false;
            this.buttonAgain.Click += new System.EventHandler(this.ButtonAgain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 512);
            this.Controls.Add(this.buttonAgain);
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.textboxPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textboxIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioClient);
            this.Controls.Add(this.radioHost);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panelGame.ResumeLayout(false);
            this.panelGame.PerformLayout();
            this.panelRPS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpponent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYou)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioHost;
        private System.Windows.Forms.RadioButton radioClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxIP;
        private System.Windows.Forms.TextBox textboxPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.Panel panelRPS;
        private System.Windows.Forms.Button buttonScissors;
        private System.Windows.Forms.Button buttonPaper;
        private System.Windows.Forms.Button buttonRock;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxOpponent;
        private System.Windows.Forms.PictureBox pictureBoxYou;
        private System.Windows.Forms.Button buttonAgain;
    }
}

