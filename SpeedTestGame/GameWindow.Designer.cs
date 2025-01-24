namespace SpeedTestGame
{
    partial class GameWindow
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
            this.exitGameButton = new System.Windows.Forms.Button();
            this.startGameButton = new System.Windows.Forms.Button();
            this.resetGameButton = new System.Windows.Forms.Button();
            this.redButton = new System.Windows.Forms.Button();
            this.greenButton = new System.Windows.Forms.Button();
            this.orangeButton = new System.Windows.Forms.Button();
            this.yellowButton = new System.Windows.Forms.Button();
            this.digitalCounter = new SpeedTestGame.DigitalCounterControl();
            this.SuspendLayout();
            // 
            // exitGameButton
            // 
            this.exitGameButton.Location = new System.Drawing.Point(12, 39);
            this.exitGameButton.Name = "exitGameButton";
            this.exitGameButton.Size = new System.Drawing.Size(159, 44);
            this.exitGameButton.TabIndex = 0;
            this.exitGameButton.Text = "EXIT";
            this.exitGameButton.UseVisualStyleBackColor = true;
            this.exitGameButton.Click += new System.EventHandler(this.OnExitGameButtonClicked);
            // 
            // startGameButton
            // 
            this.startGameButton.Location = new System.Drawing.Point(12, 89);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(159, 45);
            this.startGameButton.TabIndex = 3;
            this.startGameButton.Text = "Start game";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.OnStartGameButtonClicked);
            // 
            // resetGameButton
            // 
            this.resetGameButton.Location = new System.Drawing.Point(12, 140);
            this.resetGameButton.Name = "resetGameButton";
            this.resetGameButton.Size = new System.Drawing.Size(159, 42);
            this.resetGameButton.TabIndex = 4;
            this.resetGameButton.Text = "Reset game";
            this.resetGameButton.UseVisualStyleBackColor = true;
            this.resetGameButton.Visible = false;
            this.resetGameButton.Click += new System.EventHandler(this.OnResetGameButtonClicked);
            // 
            // redButton
            // 
            this.redButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.redButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.redButton.BackColor = System.Drawing.Color.Transparent;
            this.redButton.BackgroundImage = global::SpeedTestGame.Properties.Resources.RedButton;
            this.redButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.redButton.FlatAppearance.BorderSize = 0;
            this.redButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.redButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.redButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redButton.Location = new System.Drawing.Point(802, 849);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(149, 145);
            this.redButton.TabIndex = 6;
            this.redButton.UseVisualStyleBackColor = false;
            this.redButton.Click += new System.EventHandler(this.OnRedButtonClicked);
            // 
            // greenButton
            // 
            this.greenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.greenButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.greenButton.BackColor = System.Drawing.Color.Transparent;
            this.greenButton.BackgroundImage = global::SpeedTestGame.Properties.Resources.GreenButton;
            this.greenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.greenButton.FlatAppearance.BorderSize = 0;
            this.greenButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.greenButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.greenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.greenButton.Location = new System.Drawing.Point(990, 849);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(149, 145);
            this.greenButton.TabIndex = 7;
            this.greenButton.UseVisualStyleBackColor = false;
            this.greenButton.Click += new System.EventHandler(this.OnGreenButtonClicked);
            // 
            // orangeButton
            // 
            this.orangeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orangeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.orangeButton.BackColor = System.Drawing.Color.Transparent;
            this.orangeButton.BackgroundImage = global::SpeedTestGame.Properties.Resources.OrangeButton;
            this.orangeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.orangeButton.FlatAppearance.BorderSize = 0;
            this.orangeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.orangeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.orangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orangeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.orangeButton.Location = new System.Drawing.Point(1177, 849);
            this.orangeButton.Name = "orangeButton";
            this.orangeButton.Size = new System.Drawing.Size(149, 145);
            this.orangeButton.TabIndex = 8;
            this.orangeButton.UseVisualStyleBackColor = false;
            this.orangeButton.Click += new System.EventHandler(this.OnOrangeButtonClicked);
            // 
            // yellowButton
            // 
            this.yellowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yellowButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.yellowButton.BackColor = System.Drawing.Color.Transparent;
            this.yellowButton.BackgroundImage = global::SpeedTestGame.Properties.Resources.YellowButton;
            this.yellowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yellowButton.FlatAppearance.BorderSize = 0;
            this.yellowButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.yellowButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.yellowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yellowButton.Location = new System.Drawing.Point(613, 849);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(149, 145);
            this.yellowButton.TabIndex = 5;
            this.yellowButton.UseVisualStyleBackColor = false;
            this.yellowButton.Click += new System.EventHandler(this.OnYellowButtonClicked);
            // 
            // digitalCounter
            // 
            this.digitalCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.digitalCounter.BackColor = System.Drawing.Color.Black;
            this.digitalCounter.CounterValue = 0;
            this.digitalCounter.Location = new System.Drawing.Point(733, 690);
            this.digitalCounter.Name = "digitalCounter";
            this.digitalCounter.Size = new System.Drawing.Size(499, 142);
            this.digitalCounter.TabIndex = 0;
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::SpeedTestGame.Properties.Resources.NinjaBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.orangeButton);
            this.Controls.Add(this.greenButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.yellowButton);
            this.Controls.Add(this.resetGameButton);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.exitGameButton);
            this.Controls.Add(this.digitalCounter);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameWindow";
            this.Text = "Speed Test Game";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitGameButton;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Button resetGameButton;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Button orangeButton;
        private System.Windows.Forms.Button yellowButton;
        private DigitalCounterControl digitalCounter;
    }
}

