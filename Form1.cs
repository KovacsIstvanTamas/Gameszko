using System.Drawing.Printing;
using WMPLib;

namespace Gameszko
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer gameMedia;
        WindowsMediaPlayer shootMedia;
        WindowsMediaPlayer enemyDieMedia;
        WindowsMediaPlayer playerDieMedia;

        PictureBox[] stars;
        int backgroundspeed;

        int playerspeed;

        PictureBox[] ammo;
        int ammospeed;

        PictureBox[] enemies;
        int enemyspeed;

        Image Hp3;
        Image Hp2;
        Image Hp1;
        Image Hp0;

        Image enemy1;
        Image enemy2;

        Random rnd;

        int scores;
        int levels;
        int Pl;

        public Form1()
        {
            InitializeComponent();
            StopTimers();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundspeed = 4;
            playerspeed = 4;
            enemyspeed = 4;
            ammospeed = 20;
            scores = 0;
            levels = 1;
            Pl = 3;

            ammo = new PictureBox[3];

            Hp3 = Image.FromFile("asserts\\FallingMeteor.gif");


            Image meteor = Image.FromFile("asserts\\FallingMeteor.gif");

            Image ammos = Image.FromFile(@"asserts\testammo.png");

            enemy1 = Image.FromFile("asserts\\E1.gif");
            enemy2 = Image.FromFile("asserts\\SzemGolyó.gif");

            GenEnemey(enemy1, enemy2);
            PlHp();



            for (int i = 0; i < ammo.Length; i++)
            {
                ammo[i] = new PictureBox();
                ammo[i].Size = new Size(8, 8);
                ammo[i].Image = ammos;
                ammo[i].SizeMode = PictureBoxSizeMode.Zoom;
                ammo[i].BorderStyle = BorderStyle.None;
                this.Controls.Add(ammo[i]);
            }

            gameMedia = new WindowsMediaPlayer();
            shootMedia = new WindowsMediaPlayer();
            enemyDieMedia = new WindowsMediaPlayer();
            playerDieMedia = new WindowsMediaPlayer();

            //Load songs
            gameMedia.URL = "songs\\GameSongs.mp3";
            shootMedia.URL = "songs\\ShootSongs.mp3";
            enemyDieMedia.URL = "songs\\EnemyDie.mp3";
            playerDieMedia.URL = "songs\\PlayerDie.mp3";

            //Setup songs
            gameMedia.settings.setMode("loop", true);
            gameMedia.settings.volume = 6;
            shootMedia.settings.volume = 0;
            enemyDieMedia.settings.volume = 0;
            playerDieMedia.settings.volume = 0;

            stars = new PictureBox[15];
            rnd = new Random();

            for (int i = 0; i < stars.Length; i++)
            {
                stars[i] = new PictureBox();
                stars[i].BorderStyle = BorderStyle.None;
                stars[i].Location = new Point(rnd.Next(20, 500), rnd.Next(-10, 400));
                if (i % 2 == 1)
                {
                    //stars[i].Size = new Size(2, 2);
                    stars[i].Image = meteor;
                    stars[i].SizeMode = PictureBoxSizeMode.Zoom;
                    stars[i].BackColor = Color.Transparent;
                }
                else
                {
                    stars[i].Size = new Size(3, 3);
                    stars[i].BackColor = Color.DarkGray;
                }

                this.Controls.Add(stars[i]);
            }

            gameMedia.controls.play();
        }

        private void PlHp()
        {
            if (Pl == 3)
            {
                HpBar.Image = Hp3;
            }
        }

        private void GenEnemey(Image enemy1, Image enemy2)
        {
            enemies = new PictureBox[10];

            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i] = new PictureBox();
                enemies[i].Size = new Size(40, 40);
                enemies[i].SizeMode = PictureBoxSizeMode.Zoom;
                enemies[i].BorderStyle = BorderStyle.None;
                enemies[i].Visible = false;
                this.Controls.Add(enemies[i]);
                enemies[i].Location = new Point((i + 1) * 50, -50);
            }

            if (levels == 1)
            {
                for (int i = 0; i < enemies.Length; i++)
                {
                    enemies[i].Image = enemy1;
                }
            }
            else  //if (levels == 2)
            {
                for (int i = 0; i < enemies.Length; i++)
                {
                    enemies[i].Image = enemy2;
                }
            }
        }



        private void BG_Timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < stars.Length / 2; i++)
            {
                stars[i].Top += backgroundspeed;

                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }
            }

            for (int i = stars.Length / 2; i < stars.Length; i++)
            {
                stars[i].Top += backgroundspeed - 2;

                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }
            }
        }

        private void LeftTimer_Tick(object sender, EventArgs e)
        {
            if (Player.Left > 0)
            {
                Player.Left -= playerspeed;
            }

        }

        private void RigthTimer_Tick(object sender, EventArgs e)
        {
            if (Player.Right < 600)
            {
                Player.Left += playerspeed;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                RigthTimer.Start();
            }
            if (e.KeyCode == Keys.Left)
            {
                LeftTimer.Start();
            }
            if (e.KeyCode == Keys.Space)
            {
                AmmoMove.Start();
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            RigthTimer.Stop();
            LeftTimer.Stop();

        }

        private void AmmoMove_Tick(object sender, EventArgs e)
        {
            shootMedia.settings.volume = 1;
            shootMedia.controls.play();
            for (int i = 0; i < ammo.Length; i++)
            {
                if (ammo[i].Top > 0)
                {
                    ammo[i].Visible = true;
                    ammo[i].Top -= ammospeed;
                    EnemyHit();
                }
                else
                {
                    ammo[i].Visible = false;
                    ammo[i].Location = new Point(Player.Location.X + 20, Player.Location.Y - i * 30);
                }
            }
        }

        private void MoveEnemy_Tick(object sender, EventArgs e)
        {
            MoveEnemies(enemies, enemyspeed);
        }

        private void MoveEnemies(PictureBox[] array, int speed)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i].Visible = true;
                array[i].Top += speed;

                if (array[i].Top > this.Height)
                {
                    array[i].Location = new Point((i + 1) * 50, -200);
                }
            }
        }
        private void EnemyHit()
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                for (int j = 0; j < ammo.Length; j++)
                {
                    if (ammo[j].Bounds.IntersectsWith(enemies[i].Bounds))
                    {
                        ammo[j].Visible = false;
                        ammo[j].Location = new Point(Player.Location.X + 20, Player.Location.Y);
                        enemyDieMedia.settings.volume = 6;
                        enemyDieMedia.controls.play();
                        enemies[i].Location = new Point((i + 1) * 50, -100);
                        scores++;
                        score.Text = Convert.ToString(scores);
                    }
                }

                if (scores >= 50)
                {
                    LelvelComp();
                }

                if (Player.Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    if (Pl < 1)
                    {
                        playerDieMedia.settings.volume = 30;
                        playerDieMedia.controls.play();
                        Player.Visible = false;
                        GameOver("");
                    }
                    else
                    {
                        Pl--;
                    }

                }

            }
        }

        private void LelvelComp()
        {
            LevelCom.Visible = true;
            nextlevel.Visible = true;
            scores = 0;
            levels++;
            StopTimers();
        }

        private void GameOver(String str)
        {
            gameMedia.controls.stop();
            Game_over.Visible = true;
            Restart.Visible = true;
            exit.Visible = true;
            scores = 0;
            StopTimers();
        }

        private void StopTimers()
        {
            BG_Timer.Stop();
            MoveEnemy.Stop();
            AmmoMove.Stop();
        }

        private void StartTimers()
        {
            BG_Timer.Start();
            MoveEnemy.Start();
            AmmoMove.Start();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Player.Visible = true;
            Title.Visible = false;
            ScoreSing.Visible = true;
            score.Visible = true;
            Level.Visible = true;
            Lv.Visible = true;
            Start.Visible = false;
            exit.Visible = false;
            StartTimers();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            gameMedia.controls.play();
            Player.Visible = true;
            Game_over.Visible = false;
            exit.Visible = false;
            Restart.Visible = false;
            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i].Location = new Point((i + 1) * 50, -50);
            }
            StartTimers();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void nextlevel_Click(object sender, EventArgs e)
        {
            nextlevel.Visible = false;
            LevelCom.Visible = false;
            Lv.Text = Convert.ToString(levels);
            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i].Location = new Point((i + 1) * 50, -50);
            }
            GenEnemey(enemy1, enemy2);
            StartTimers();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}