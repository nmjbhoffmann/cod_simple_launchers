namespace Call_of_Duty_Modern_Warfare
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
            this.brnSingleplayer = new System.Windows.Forms.Button();
            this.btnMultiplayer = new System.Windows.Forms.Button();
            this.btnBots = new System.Windows.Forms.Button();
            this.btnZombies = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // brnSingleplayer
            // 
            this.brnSingleplayer.Location = new System.Drawing.Point(12, 12);
            this.brnSingleplayer.Name = "brnSingleplayer";
            this.brnSingleplayer.Size = new System.Drawing.Size(75, 23);
            this.brnSingleplayer.TabIndex = 0;
            this.brnSingleplayer.Text = "Singleplayer";
            this.brnSingleplayer.UseVisualStyleBackColor = true;
            this.brnSingleplayer.Click += new System.EventHandler(this.brnSingleplayer_Click);
            // 
            // btnMultiplayer
            // 
            this.btnMultiplayer.Location = new System.Drawing.Point(12, 41);
            this.btnMultiplayer.Name = "btnMultiplayer";
            this.btnMultiplayer.Size = new System.Drawing.Size(75, 23);
            this.btnMultiplayer.TabIndex = 1;
            this.btnMultiplayer.Text = "Multiplayer";
            this.btnMultiplayer.UseVisualStyleBackColor = true;
            this.btnMultiplayer.Click += new System.EventHandler(this.btnMultiplayer_Click);
            // 
            // btnBots
            // 
            this.btnBots.Location = new System.Drawing.Point(93, 12);
            this.btnBots.Name = "btnBots";
            this.btnBots.Size = new System.Drawing.Size(121, 23);
            this.btnBots.TabIndex = 2;
            this.btnBots.Text = "Multiplayer - Bots";
            this.btnBots.UseVisualStyleBackColor = true;
            this.btnBots.Click += new System.EventHandler(this.btnBots_Click);
            // 
            // btnZombies
            // 
            this.btnZombies.Location = new System.Drawing.Point(93, 41);
            this.btnZombies.Name = "btnZombies";
            this.btnZombies.Size = new System.Drawing.Size(121, 23);
            this.btnZombies.TabIndex = 3;
            this.btnZombies.Text = "Multiplayer - Zombies";
            this.btnZombies.UseVisualStyleBackColor = true;
            this.btnZombies.Click += new System.EventHandler(this.btnZombies_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnMultiplayer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 76);
            this.Controls.Add(this.btnZombies);
            this.Controls.Add(this.btnBots);
            this.Controls.Add(this.btnMultiplayer);
            this.Controls.Add(this.brnSingleplayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Call of Duty 4 Modern Warfare";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button brnSingleplayer;
        private System.Windows.Forms.Button btnMultiplayer;
        private System.Windows.Forms.Button btnBots;
        private System.Windows.Forms.Button btnZombies;
    }
}

