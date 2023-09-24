namespace Gameszko
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BG_Timer = new System.Windows.Forms.Timer(components);
            Player = new PictureBox();
            LeftTimer = new System.Windows.Forms.Timer(components);
            RigthTimer = new System.Windows.Forms.Timer(components);
            AmmoMove = new System.Windows.Forms.Timer(components);
            MoveEnemy = new System.Windows.Forms.Timer(components);
            Title = new Label();
            Start = new PictureBox();
            exit = new PictureBox();
            Game_over = new Label();
            ScoreSing = new Label();
            score = new Label();
            LevelCom = new Label();
            Restart = new PictureBox();
            nextlevel = new PictureBox();
            Level = new Label();
            Lv = new Label();
            HpBar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Start).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Restart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nextlevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HpBar).BeginInit();
            SuspendLayout();
            // 
            // BG_Timer
            // 
            BG_Timer.Enabled = true;
            BG_Timer.Tick += BG_Timer_Tick;
            // 
            // Player
            // 
            Player.BackColor = Color.Transparent;
            Player.BackgroundImageLayout = ImageLayout.None;
            Player.Image = (Image)resources.GetObject("Player.Image");
            Player.Location = new Point(260, 400);
            Player.Margin = new Padding(0);
            Player.Name = "Player";
            Player.Size = new Size(50, 50);
            Player.SizeMode = PictureBoxSizeMode.Zoom;
            Player.TabIndex = 0;
            Player.TabStop = false;
            Player.Visible = false;
            // 
            // LeftTimer
            // 
            LeftTimer.Interval = 5;
            LeftTimer.Tick += LeftTimer_Tick;
            // 
            // RigthTimer
            // 
            RigthTimer.Interval = 5;
            RigthTimer.Tick += RigthTimer_Tick;
            // 
            // AmmoMove
            // 
            AmmoMove.Interval = 50;
            AmmoMove.Tick += AmmoMove_Tick;
            // 
            // MoveEnemy
            // 
            MoveEnemy.Enabled = true;
            MoveEnemy.Tick += MoveEnemy_Tick;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.BackColor = Color.Transparent;
            Title.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            Title.ForeColor = Color.Blue;
            Title.Location = new Point(83, 116);
            Title.Margin = new Padding(100, 0, 100, 0);
            Title.MinimumSize = new Size(400, 100);
            Title.Name = "Title";
            Title.Size = new Size(428, 100);
            Title.TabIndex = 3;
            Title.Text = "SpaceShooter";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Start
            // 
            Start.BackColor = Color.Transparent;
            Start.BackgroundImage = (Image)resources.GetObject("Start.BackgroundImage");
            Start.Image = (Image)resources.GetObject("Start.Image");
            Start.Location = new Point(216, 206);
            Start.Name = "Start";
            Start.Size = new Size(122, 90);
            Start.SizeMode = PictureBoxSizeMode.CenterImage;
            Start.TabIndex = 4;
            Start.TabStop = false;
            Start.Click += Start_Click;
            // 
            // exit
            // 
            exit.Image = (Image)resources.GetObject("exit.Image");
            exit.Location = new Point(236, 302);
            exit.Name = "exit";
            exit.Size = new Size(102, 109);
            exit.SizeMode = PictureBoxSizeMode.CenterImage;
            exit.TabIndex = 5;
            exit.TabStop = false;
            exit.Click += exit_Click;
            // 
            // Game_over
            // 
            Game_over.AutoSize = true;
            Game_over.BackColor = Color.Transparent;
            Game_over.FlatStyle = FlatStyle.Flat;
            Game_over.Font = new Font("Mongolian Baiti", 38.25F, FontStyle.Bold, GraphicsUnit.Point);
            Game_over.ForeColor = Color.Red;
            Game_over.Location = new Point(97, 103);
            Game_over.MinimumSize = new Size(400, 100);
            Game_over.Name = "Game_over";
            Game_over.Size = new Size(400, 100);
            Game_over.TabIndex = 6;
            Game_over.Text = "Game Over";
            Game_over.TextAlign = ContentAlignment.MiddleCenter;
            Game_over.Visible = false;
            // 
            // ScoreSing
            // 
            ScoreSing.AutoSize = true;
            ScoreSing.ForeColor = Color.Yellow;
            ScoreSing.Location = new Point(524, 9);
            ScoreSing.Name = "ScoreSing";
            ScoreSing.Size = new Size(36, 15);
            ScoreSing.TabIndex = 7;
            ScoreSing.Text = "Score";
            ScoreSing.Visible = false;
            // 
            // score
            // 
            score.AutoSize = true;
            score.BackColor = Color.Transparent;
            score.ForeColor = Color.Yellow;
            score.Location = new Point(559, 9);
            score.Name = "score";
            score.Size = new Size(13, 15);
            score.TabIndex = 8;
            score.Text = "0";
            score.Visible = false;
            // 
            // LevelCom
            // 
            LevelCom.AutoSize = true;
            LevelCom.BackColor = Color.Transparent;
            LevelCom.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            LevelCom.ForeColor = Color.FromArgb(0, 0, 192);
            LevelCom.Location = new Point(49, 117);
            LevelCom.Name = "LevelCom";
            LevelCom.Size = new Size(511, 86);
            LevelCom.TabIndex = 9;
            LevelCom.Text = "Level Completed";
            LevelCom.TextAlign = ContentAlignment.MiddleCenter;
            LevelCom.Visible = false;
            LevelCom.Click += label5_Click;
            // 
            // Restart
            // 
            Restart.BackColor = Color.Transparent;
            Restart.Image = (Image)resources.GetObject("Restart.Image");
            Restart.Location = new Point(236, 235);
            Restart.Margin = new Padding(0);
            Restart.Name = "Restart";
            Restart.Size = new Size(100, 50);
            Restart.SizeMode = PictureBoxSizeMode.Zoom;
            Restart.TabIndex = 10;
            Restart.TabStop = false;
            Restart.Visible = false;
            Restart.Click += Restart_Click;
            // 
            // nextlevel
            // 
            nextlevel.BackColor = Color.Transparent;
            nextlevel.Image = (Image)resources.GetObject("nextlevel.Image");
            nextlevel.Location = new Point(238, 235);
            nextlevel.Name = "nextlevel";
            nextlevel.Size = new Size(100, 50);
            nextlevel.SizeMode = PictureBoxSizeMode.CenterImage;
            nextlevel.TabIndex = 11;
            nextlevel.TabStop = false;
            nextlevel.Visible = false;
            nextlevel.Click += nextlevel_Click;
            // 
            // Level
            // 
            Level.AutoSize = true;
            Level.BackColor = Color.Transparent;
            Level.ForeColor = Color.Red;
            Level.Location = new Point(12, 9);
            Level.Name = "Level";
            Level.Size = new Size(42, 15);
            Level.TabIndex = 12;
            Level.Text = "Levels:";
            Level.Visible = false;
            // 
            // Lv
            // 
            Lv.AutoSize = true;
            Lv.ForeColor = Color.Red;
            Lv.Location = new Point(49, 9);
            Lv.Name = "Lv";
            Lv.Size = new Size(13, 15);
            Lv.TabIndex = 13;
            Lv.Text = "1";
            Lv.Visible = false;
            // 
            // HpBar
            // 
            HpBar.BackColor = Color.Transparent;
            HpBar.Location = new Point(12, 27);
            HpBar.Name = "HpBar";
            HpBar.Size = new Size(100, 50);
            HpBar.TabIndex = 14;
            HpBar.TabStop = false;
            HpBar.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(584, 461);
            Controls.Add(HpBar);
            Controls.Add(Lv);
            Controls.Add(Level);
            Controls.Add(nextlevel);
            Controls.Add(Restart);
            Controls.Add(LevelCom);
            Controls.Add(score);
            Controls.Add(ScoreSing);
            Controls.Add(Game_over);
            Controls.Add(exit);
            Controls.Add(Start);
            Controls.Add(Title);
            Controls.Add(Player);
            MaximumSize = new Size(600, 500);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)Player).EndInit();
            ((System.ComponentModel.ISupportInitialize)Start).EndInit();
            ((System.ComponentModel.ISupportInitialize)exit).EndInit();
            ((System.ComponentModel.ISupportInitialize)Restart).EndInit();
            ((System.ComponentModel.ISupportInitialize)nextlevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)HpBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer BG_Timer;
        private PictureBox Player;
        private System.Windows.Forms.Timer LeftTimer;
        private System.Windows.Forms.Timer RigthTimer;
        private System.Windows.Forms.Timer AmmoMove;
        private System.Windows.Forms.Timer MoveEnemy;
        private Label Title;
        private PictureBox Start;
        private PictureBox exit;
        private Label Game_over;
        private Label ScoreSing;
        private Label score;
        private Label LevelCom;
        private PictureBox Restart;
        private PictureBox nextlevel;
        private Label Level;
        private Label Lv;
        private PictureBox HpBar;
    }
}