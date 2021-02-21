namespace Call_of_Duty_Advanced_Warfare_Launcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.PlayerIdBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PlayerNameBox = new System.Windows.Forms.TextBox();
            this.playlistTextbox = new System.Windows.Forms.TextBox();
            this.PlaylistUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Multiplayer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Singleplayer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(324, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Exo Zombies";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(220, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Exo Co-op";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // PlayerIdBox
            // 
            this.PlayerIdBox.Location = new System.Drawing.Point(71, 48);
            this.PlayerIdBox.Name = "PlayerIdBox";
            this.PlayerIdBox.Size = new System.Drawing.Size(121, 20);
            this.PlayerIdBox.TabIndex = 4;
            this.PlayerIdBox.TextChanged += new System.EventHandler(this.PlayerIdBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Player ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Player Name:";
            // 
            // PlayerNameBox
            // 
            this.PlayerNameBox.Location = new System.Drawing.Point(301, 48);
            this.PlayerNameBox.Name = "PlayerNameBox";
            this.PlayerNameBox.Size = new System.Drawing.Size(121, 20);
            this.PlayerNameBox.TabIndex = 7;
            this.PlayerNameBox.TextChanged += new System.EventHandler(this.PlayerNameBox_TextChanged);
            // 
            // playlistTextbox
            // 
            this.playlistTextbox.AcceptsReturn = true;
            this.playlistTextbox.AcceptsTab = true;
            this.playlistTextbox.Location = new System.Drawing.Point(15, 82);
            this.playlistTextbox.MaxLength = 1223000;
            this.playlistTextbox.Multiline = true;
            this.playlistTextbox.Name = "playlistTextbox";
            this.playlistTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.playlistTextbox.Size = new System.Drawing.Size(407, 302);
            this.playlistTextbox.TabIndex = 4;
            this.playlistTextbox.WordWrap = false;
            this.playlistTextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PlaylistUpdate
            // 
            this.PlaylistUpdate.Location = new System.Drawing.Point(301, 391);
            this.PlaylistUpdate.Name = "PlaylistUpdate";
            this.PlaylistUpdate.Size = new System.Drawing.Size(120, 23);
            this.PlaylistUpdate.TabIndex = 9;
            this.PlaylistUpdate.Text = "Update Playlist File";
            this.PlaylistUpdate.UseVisualStyleBackColor = true;
            this.PlaylistUpdate.Click += new System.EventHandler(this.PlaylistUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 431);
            this.Controls.Add(this.PlaylistUpdate);
            this.Controls.Add(this.playlistTextbox);
            this.Controls.Add(this.PlayerNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlayerIdBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Call of Duty Advanced Warfare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox PlayerIdBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PlayerNameBox;
        private System.Windows.Forms.TextBox playlistTextbox;
        private System.Windows.Forms.Button PlaylistUpdate;
    }
}

