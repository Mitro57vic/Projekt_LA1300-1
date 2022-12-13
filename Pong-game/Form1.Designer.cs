namespace Pong_game
{
    partial class Pong
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PlayerBar = new System.Windows.Forms.PictureBox();
            this.ComBar = new System.Windows.Forms.PictureBox();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.PlayerScoreLabel = new System.Windows.Forms.Label();
            this.ComScoreLabel = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerBar
            // 
            this.PlayerBar.BackColor = System.Drawing.Color.Lime;
            this.PlayerBar.Location = new System.Drawing.Point(14, 209);
            this.PlayerBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PlayerBar.Name = "PlayerBar";
            this.PlayerBar.Size = new System.Drawing.Size(24, 152);
            this.PlayerBar.TabIndex = 0;
            this.PlayerBar.TabStop = false;
            // 
            // ComBar
            // 
            this.ComBar.BackColor = System.Drawing.Color.Lime;
            this.ComBar.Location = new System.Drawing.Point(877, 209);
            this.ComBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComBar.Name = "ComBar";
            this.ComBar.Size = new System.Drawing.Size(24, 152);
            this.ComBar.TabIndex = 1;
            this.ComBar.TabStop = false;
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.Lime;
            this.Ball.Location = new System.Drawing.Point(445, 271);
            this.Ball.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(22, 25);
            this.Ball.TabIndex = 2;
            this.Ball.TabStop = false;
            // 
            // PlayerScoreLabel
            // 
            this.PlayerScoreLabel.AutoSize = true;
            this.PlayerScoreLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PlayerScoreLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PlayerScoreLabel.Location = new System.Drawing.Point(267, 12);
            this.PlayerScoreLabel.Name = "PlayerScoreLabel";
            this.PlayerScoreLabel.Size = new System.Drawing.Size(29, 32);
            this.PlayerScoreLabel.TabIndex = 3;
            this.PlayerScoreLabel.Text = "0";
            // 
            // ComScoreLabel
            // 
            this.ComScoreLabel.AutoSize = true;
            this.ComScoreLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ComScoreLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ComScoreLabel.Location = new System.Drawing.Point(621, 12);
            this.ComScoreLabel.Name = "ComScoreLabel";
            this.ComScoreLabel.Size = new System.Drawing.Size(29, 32);
            this.ComScoreLabel.TabIndex = 4;
            this.ComScoreLabel.Text = "0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.timerTick);
            // 
            // Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(914, 601);
            this.Controls.Add(this.ComScoreLabel);
            this.Controls.Add(this.PlayerScoreLabel);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.ComBar);
            this.Controls.Add(this.PlayerBar);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Pong";
            this.Text = "Pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox Playewr;
        private PictureBox PlayerBar;
        private PictureBox ComBar;
        private PictureBox Ball;
        private Label PlayerScoreLabel;
        private Label ComScoreLabel;
        private System.Windows.Forms.Timer gameTimer;
    }
}