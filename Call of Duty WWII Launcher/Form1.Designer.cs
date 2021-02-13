namespace Call_of_Duty_WWII_Launcher
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
            this.singleplayerButton = new System.Windows.Forms.Button();
            this.multiplayerButton = new System.Windows.Forms.Button();
            this.zombiesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // singleplayerButton
            // 
            this.singleplayerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.singleplayerButton.Location = new System.Drawing.Point(12, 12);
            this.singleplayerButton.Name = "singleplayerButton";
            this.singleplayerButton.Size = new System.Drawing.Size(75, 23);
            this.singleplayerButton.TabIndex = 0;
            this.singleplayerButton.Text = "Singleplayer";
            this.singleplayerButton.UseVisualStyleBackColor = true;
            this.singleplayerButton.Click += new System.EventHandler(this.singleplayerButton_Click);
            // 
            // multiplayerButton
            // 
            this.multiplayerButton.Location = new System.Drawing.Point(94, 13);
            this.multiplayerButton.Name = "multiplayerButton";
            this.multiplayerButton.Size = new System.Drawing.Size(75, 23);
            this.multiplayerButton.TabIndex = 1;
            this.multiplayerButton.Text = "Multiplayer";
            this.multiplayerButton.UseVisualStyleBackColor = true;
            this.multiplayerButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // zombiesButton
            // 
            this.zombiesButton.Location = new System.Drawing.Point(176, 13);
            this.zombiesButton.Name = "zombiesButton";
            this.zombiesButton.Size = new System.Drawing.Size(75, 23);
            this.zombiesButton.TabIndex = 2;
            this.zombiesButton.Text = "Zombies";
            this.zombiesButton.UseVisualStyleBackColor = true;
            this.zombiesButton.Click += new System.EventHandler(this.zombiesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 45);
            this.Controls.Add(this.zombiesButton);
            this.Controls.Add(this.multiplayerButton);
            this.Controls.Add(this.singleplayerButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Call of Duty WWII Launcher";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button singleplayerButton;
        private System.Windows.Forms.Button multiplayerButton;
        private System.Windows.Forms.Button zombiesButton;
    }
}

