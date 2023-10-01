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
			UpTimer = new System.Windows.Forms.Timer(components);
			DownTimer = new System.Windows.Forms.Timer(components);
			timer1 = new System.Windows.Forms.Timer(components);
			AmmokMK = new System.Windows.Forms.Timer(components);
			AttackSpeed = new System.Windows.Forms.Timer(components);
			AttackSpeedAlapra = new System.Windows.Forms.Timer(components);
			OpacityReset = new System.Windows.Forms.Timer(components);
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
			Player.Location = new Point(297, 533);
			Player.Margin = new Padding(0);
			Player.Name = "Player";
			Player.Size = new Size(57, 67);
			Player.SizeMode = PictureBoxSizeMode.Zoom;
			Player.TabIndex = 0;
			Player.TabStop = false;
			Player.Visible = false;
			Player.Paint += paintevent;
			// 
			// LeftTimer
			// 
			LeftTimer.Interval = 1;
			LeftTimer.Tick += LeftTimer_Tick;
			// 
			// RigthTimer
			// 
			RigthTimer.Interval = 1;
			RigthTimer.Tick += RigthTimer_Tick;
			// 
			// AmmoMove
			// 
			AmmoMove.Enabled = true;
			AmmoMove.Interval = 1;
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
			Title.Location = new Point(95, 155);
			Title.Margin = new Padding(114, 0, 114, 0);
			Title.MinimumSize = new Size(457, 133);
			Title.Name = "Title";
			Title.Size = new Size(534, 133);
			Title.TabIndex = 3;
			Title.Text = "SpaceShooter";
			Title.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// Start
			// 
			Start.BackColor = Color.Transparent;
			Start.BackgroundImage = (Image)resources.GetObject("Start.BackgroundImage");
			Start.Image = (Image)resources.GetObject("Start.Image");
			Start.Location = new Point(247, 275);
			Start.Margin = new Padding(3, 4, 3, 4);
			Start.Name = "Start";
			Start.Size = new Size(139, 120);
			Start.SizeMode = PictureBoxSizeMode.CenterImage;
			Start.TabIndex = 4;
			Start.TabStop = false;
			Start.Click += Start_Click;
			// 
			// exit
			// 
			exit.Image = (Image)resources.GetObject("exit.Image");
			exit.Location = new Point(270, 403);
			exit.Margin = new Padding(3, 4, 3, 4);
			exit.Name = "exit";
			exit.Size = new Size(117, 145);
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
			Game_over.Location = new Point(111, 137);
			Game_over.MinimumSize = new Size(457, 133);
			Game_over.Name = "Game_over";
			Game_over.Size = new Size(457, 133);
			Game_over.TabIndex = 6;
			Game_over.Text = "Game Over";
			Game_over.TextAlign = ContentAlignment.MiddleCenter;
			Game_over.Visible = false;
			// 
			// ScoreSing
			// 
			ScoreSing.AutoSize = true;
			ScoreSing.ForeColor = Color.Yellow;
			ScoreSing.Location = new Point(599, 12);
			ScoreSing.Name = "ScoreSing";
			ScoreSing.Size = new Size(46, 20);
			ScoreSing.TabIndex = 7;
			ScoreSing.Text = "Score";
			ScoreSing.Visible = false;
			// 
			// score
			// 
			score.AutoSize = true;
			score.BackColor = Color.Transparent;
			score.ForeColor = Color.Yellow;
			score.Location = new Point(639, 12);
			score.Name = "score";
			score.Size = new Size(17, 20);
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
			LevelCom.Location = new Point(56, 156);
			LevelCom.Name = "LevelCom";
			LevelCom.Size = new Size(636, 106);
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
			Restart.Location = new Point(270, 313);
			Restart.Margin = new Padding(0);
			Restart.Name = "Restart";
			Restart.Size = new Size(114, 67);
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
			nextlevel.Location = new Point(272, 313);
			nextlevel.Margin = new Padding(3, 4, 3, 4);
			nextlevel.Name = "nextlevel";
			nextlevel.Size = new Size(114, 67);
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
			Level.Location = new Point(14, 12);
			Level.Name = "Level";
			Level.Size = new Size(52, 20);
			Level.TabIndex = 12;
			Level.Text = "Levels:";
			Level.Visible = false;
			// 
			// Lv
			// 
			Lv.AutoSize = true;
			Lv.ForeColor = Color.Red;
			Lv.Location = new Point(56, 12);
			Lv.Name = "Lv";
			Lv.Size = new Size(17, 20);
			Lv.TabIndex = 13;
			Lv.Text = "1";
			Lv.Visible = false;
			// 
			// HpBar
			// 
			HpBar.BackColor = Color.Transparent;
			HpBar.Location = new Point(14, 36);
			HpBar.Margin = new Padding(3, 4, 3, 4);
			HpBar.Name = "HpBar";
			HpBar.Size = new Size(114, 67);
			HpBar.TabIndex = 14;
			HpBar.TabStop = false;
			HpBar.Visible = false;
			// 
			// UpTimer
			// 
			UpTimer.Interval = 1;
			UpTimer.Tick += UpTimer_Tick;
			// 
			// DownTimer
			// 
			DownTimer.Interval = 1;
			DownTimer.Tick += DownTimer_Tick;
			// 
			// timer1
			// 
			timer1.Enabled = true;
			timer1.Interval = 20;
			// 
			// AmmokMK
			// 
			AmmokMK.Enabled = true;
			AmmokMK.Interval = 20;
			AmmokMK.Tick += AmmokMK_Tick;
			// 
			// AttackSpeed
			// 
			AttackSpeed.Interval = 1;
			AttackSpeed.Tick += AttackSpeed_Tick;
			// 
			// AttackSpeedAlapra
			// 
			AttackSpeedAlapra.Interval = 499;
			AttackSpeedAlapra.Tick += AttackSpeedAlapra_Tick;
			// 
			// OpacityReset
			// 
			OpacityReset.Interval = 1;
			OpacityReset.Tick += OpacityReset_Tick;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Black;
			ClientSize = new Size(665, 604);
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
			Margin = new Padding(3, 4, 3, 4);
			MaximumSize = new Size(683, 651);
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
		private System.Windows.Forms.Timer UpTimer;
		private System.Windows.Forms.Timer DownTimer;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Timer AmmokMK;
		private System.Windows.Forms.Timer AttackSpeed;
		private System.Windows.Forms.Timer AttackSpeedAlapra;
		private System.Windows.Forms.Timer OpacityReset;
	}
}