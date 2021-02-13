namespace Call_of_Duty_World_at_War_Launcher
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
            this.btnSingleplayer = new System.Windows.Forms.Button();
            this.btnMultiplayer = new System.Windows.Forms.Button();
            this.btnOpenModFolder = new System.Windows.Forms.Button();
            this.btnBots = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSingleplayer
            // 
            this.btnSingleplayer.Location = new System.Drawing.Point(12, 12);
            this.btnSingleplayer.Name = "btnSingleplayer";
            this.btnSingleplayer.Size = new System.Drawing.Size(108, 23);
            this.btnSingleplayer.TabIndex = 0;
            this.btnSingleplayer.Text = "Singleplayer/ Co-op";
            this.btnSingleplayer.UseVisualStyleBackColor = true;
            this.btnSingleplayer.Click += new System.EventHandler(this.btnSingleplayer_Click);
            // 
            // btnMultiplayer
            // 
            this.btnMultiplayer.Location = new System.Drawing.Point(12, 41);
            this.btnMultiplayer.Name = "btnMultiplayer";
            this.btnMultiplayer.Size = new System.Drawing.Size(108, 23);
            this.btnMultiplayer.TabIndex = 1;
            this.btnMultiplayer.Text = "Multiplayer";
            this.btnMultiplayer.UseVisualStyleBackColor = true;
            this.btnMultiplayer.Click += new System.EventHandler(this.btnMultiplayer_Click);
            // 
            // btnOpenModFolder
            // 
            this.btnOpenModFolder.Location = new System.Drawing.Point(126, 12);
            this.btnOpenModFolder.Name = "btnOpenModFolder";
            this.btnOpenModFolder.Size = new System.Drawing.Size(108, 23);
            this.btnOpenModFolder.TabIndex = 2;
            this.btnOpenModFolder.Text = "Open Data Folder";
            this.btnOpenModFolder.UseVisualStyleBackColor = true;
            this.btnOpenModFolder.Click += new System.EventHandler(this.btnOpenModFolder_Click);
            // 
            // btnBots
            // 
            this.btnBots.Location = new System.Drawing.Point(126, 41);
            this.btnBots.Name = "btnBots";
            this.btnBots.Size = new System.Drawing.Size(108, 23);
            this.btnBots.TabIndex = 3;
            this.btnBots.Text = "Multiplayer - Bots";
            this.btnBots.UseVisualStyleBackColor = true;
            this.btnBots.Click += new System.EventHandler(this.btnBots_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSingleplayer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 77);
            this.Controls.Add(this.btnBots);
            this.Controls.Add(this.btnOpenModFolder);
            this.Controls.Add(this.btnMultiplayer);
            this.Controls.Add(this.btnSingleplayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Call of Duty World at War";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSingleplayer;
        private System.Windows.Forms.Button btnMultiplayer;
        private System.Windows.Forms.Button btnOpenModFolder;
        private System.Windows.Forms.Button btnBots;
    }
}

