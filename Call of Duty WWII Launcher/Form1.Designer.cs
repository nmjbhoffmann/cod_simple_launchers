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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // singleplayerButton
            // 
            this.singleplayerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.singleplayerButton.Location = new System.Drawing.Point(12, 13);
            this.singleplayerButton.Name = "singleplayerButton";
            this.singleplayerButton.Size = new System.Drawing.Size(75, 23);
            this.singleplayerButton.TabIndex = 0;
            this.singleplayerButton.Text = "Singleplayer";
            this.singleplayerButton.UseVisualStyleBackColor = true;
            this.singleplayerButton.Click += new System.EventHandler(this.singleplayerButton_Click);
            // 
            // multiplayerButton
            // 
            this.multiplayerButton.Location = new System.Drawing.Point(12, 42);
            this.multiplayerButton.Name = "multiplayerButton";
            this.multiplayerButton.Size = new System.Drawing.Size(156, 23);
            this.multiplayerButton.TabIndex = 1;
            this.multiplayerButton.Text = "Multiplayer";
            this.multiplayerButton.UseVisualStyleBackColor = true;
            this.multiplayerButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // zombiesButton
            // 
            this.zombiesButton.Location = new System.Drawing.Point(93, 12);
            this.zombiesButton.Name = "zombiesButton";
            this.zombiesButton.Size = new System.Drawing.Size(75, 23);
            this.zombiesButton.TabIndex = 2;
            this.zombiesButton.Text = "Zombies";
            this.zombiesButton.UseVisualStyleBackColor = true;
            this.zombiesButton.Click += new System.EventHandler(this.zombiesButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(55, 71);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(113, 20);
            this.NameTextBox.TabIndex = 3;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(178, 102);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTextBox);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button singleplayerButton;
        private System.Windows.Forms.Button multiplayerButton;
        private System.Windows.Forms.Button zombiesButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label1;
    }
}

