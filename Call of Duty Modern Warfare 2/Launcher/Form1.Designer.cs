namespace Launcher
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSingleplayer = new System.Windows.Forms.Button();
            this.btnMultiplayer = new System.Windows.Forms.Button();
            this.btnCoop = new System.Windows.Forms.Button();
            this.hostIP = new System.Windows.Forms.TextBox();
            this.SaveIP = new System.Windows.Forms.Button();
            this.GetMyIP = new System.Windows.Forms.Button();
            this.playerName = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 42);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(67, 13);
            label2.TabIndex = 8;
            label2.Text = "Player Name";
            label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnSingleplayer
            // 
            this.btnSingleplayer.Location = new System.Drawing.Point(15, 76);
            this.btnSingleplayer.Name = "btnSingleplayer";
            this.btnSingleplayer.Size = new System.Drawing.Size(83, 23);
            this.btnSingleplayer.TabIndex = 0;
            this.btnSingleplayer.Text = "Singleplayer";
            this.btnSingleplayer.UseVisualStyleBackColor = true;
            this.btnSingleplayer.Click += new System.EventHandler(this.btnSingleplayer_Click);
            // 
            // btnMultiplayer
            // 
            this.btnMultiplayer.Location = new System.Drawing.Point(101, 76);
            this.btnMultiplayer.Name = "btnMultiplayer";
            this.btnMultiplayer.Size = new System.Drawing.Size(83, 23);
            this.btnMultiplayer.TabIndex = 1;
            this.btnMultiplayer.Text = "Multiplayer";
            this.btnMultiplayer.UseVisualStyleBackColor = true;
            this.btnMultiplayer.Click += new System.EventHandler(this.btnMultiplayer_Click);
            // 
            // btnCoop
            // 
            this.btnCoop.Location = new System.Drawing.Point(188, 76);
            this.btnCoop.Name = "btnCoop";
            this.btnCoop.Size = new System.Drawing.Size(83, 23);
            this.btnCoop.TabIndex = 3;
            this.btnCoop.Text = "Spec Ops Coop";
            this.btnCoop.UseVisualStyleBackColor = true;
            this.btnCoop.Click += new System.EventHandler(this.btnCoop_Click);
            // 
            // hostIP
            // 
            this.hostIP.Location = new System.Drawing.Point(85, 10);
            this.hostIP.Name = "hostIP";
            this.hostIP.Size = new System.Drawing.Size(104, 20);
            this.hostIP.TabIndex = 4;
            this.hostIP.TextChanged += new System.EventHandler(this.hostIP_TextChanged);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(37, 13);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(42, 13);
            label1.TabIndex = 5;
            label1.Text = "Host IP";
            // 
            // SaveIP
            // 
            this.SaveIP.Location = new System.Drawing.Point(195, 39);
            this.SaveIP.Name = "SaveIP";
            this.SaveIP.Size = new System.Drawing.Size(76, 23);
            this.SaveIP.TabIndex = 6;
            this.SaveIP.Text = "Save";
            this.SaveIP.UseVisualStyleBackColor = true;
            this.SaveIP.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // GetMyIP
            // 
            this.GetMyIP.Location = new System.Drawing.Point(195, 8);
            this.GetMyIP.Name = "GetMyIP";
            this.GetMyIP.Size = new System.Drawing.Size(75, 23);
            this.GetMyIP.TabIndex = 7;
            this.GetMyIP.Text = "I\'m Hosting";
            this.GetMyIP.UseVisualStyleBackColor = true;
            this.GetMyIP.Click += new System.EventHandler(this.GetMyIP_Click);
            // 
            // playerName
            // 
            this.playerName.Location = new System.Drawing.Point(85, 39);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(103, 20);
            this.playerName.TabIndex = 9;
            this.playerName.TextChanged += new System.EventHandler(this.playerName_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 118);
            this.Controls.Add(this.playerName);
            this.Controls.Add(label2);
            this.Controls.Add(this.GetMyIP);
            this.Controls.Add(this.SaveIP);
            this.Controls.Add(label1);
            this.Controls.Add(this.hostIP);
            this.Controls.Add(this.btnCoop);
            this.Controls.Add(this.btnMultiplayer);
            this.Controls.Add(this.btnSingleplayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Call of Duty Modern Warfare 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSingleplayer;
        private System.Windows.Forms.Button btnMultiplayer;
        private System.Windows.Forms.Button btnCoop;
        private System.Windows.Forms.TextBox hostIP;
        private System.Windows.Forms.Button SaveIP;
        private System.Windows.Forms.Button GetMyIP;
        private System.Windows.Forms.TextBox playerName;
    }
}

