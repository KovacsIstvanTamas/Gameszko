﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;


namespace OverLapTest
{

    public partial class Main : Form
    {

        Random rand = new Random();
        List<Meteor> meteors;
        List<Comets> comets;
        Player p;
        List<CommonEnemy> salad;
        List<Bullet> ammo;
        ShopItems shopsButton;




		Image SrtImg;
        Image ExitImg;

        int srt;

        int flagbul = 0;

        int Yspeed;
        int Xspeed;

        int PlayerSpeed;
        int enemyspeed;
        int ammospeed;

        	WindowsMediaPlayer gameMedia;
		WindowsMediaPlayer shootMedia;
		WindowsMediaPlayer enemyDieMedia;
		WindowsMediaPlayer playerDieMedia;
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

			gameMedia = new WindowsMediaPlayer();
			shootMedia = new WindowsMediaPlayer();
			enemyDieMedia = new WindowsMediaPlayer();
			playerDieMedia = new WindowsMediaPlayer();

			//Load songs
			gameMedia.URL = "C:\\Users\\Karl\\source\\repos\\Gameszkoa\\songs\\GameSongs.mp3";
			shootMedia.URL = "C:\\Users\\Karl\\source\\repos\\Gameszkoa\\songs\\Gunshot_Sound_Effect.mp3";
			enemyDieMedia.URL = "C:\\Users\\Karl\\source\\repos\\Gameszkoa\\songs\\EnemyDie.mp3";
			playerDieMedia.URL = "C:\\Users\\Karl\\source\\repos\\Gameszkoa\\songs\\PlayerDie.mp3";

			//Setup songs
			gameMedia.settings.setMode("loop", true);
			gameMedia.settings.volume = 6;
			shootMedia.settings.volume = 0;
			enemyDieMedia.settings.volume = 0;
			playerDieMedia.settings.volume = 0;
			srt = 0;

            p = new Player();
            shopsButton = new ShopItems();

			ammo = new List<Bullet>();



			SpawnEnemy();
            GenerateBG();
            StartButtonAnime();

            SrtImg = Image.FromFile("asserts\\StartButton.gif"); ;
            ExitImg = Image.FromFile("asserts\\ExitButton.png"); ;


            Yspeed = 2;
            Xspeed = 1;

            PlayerSpeed = 5;
            enemyspeed = 3;
            ammospeed = 15;
        }

        private void StartButtonAnime()
        {
            ImageAnimator.Animate(SrtImg, this.Mukodj);
        }

        //Háttér elemek generálása is animálása
        private void GenerateBG()
        {
            meteors = new List<Meteor>();
            for (int i = 0; i < 5; i++)
            {
                Meteor me = new Meteor();
                meteors.Add(me);
            }

            comets = new List<Comets>();
            for (int i = 0; i < 5; i++)
            {
                Comets com = new Comets();
                comets.Add(com);
            }

            for (int i = 0; i < meteors.Count; i++)
            {
                ImageAnimator.Animate(meteors[i].metor, this.Mukodj);
            }

            for (int i = 0; i < comets.Count; i++)
            {
                ImageAnimator.Animate(comets[i].comet, this.Mukodj);
            }
        }

        //Enemy generálása is animálása
        private void SpawnEnemy()
        {
            salad = new List<CommonEnemy>();
            for (int i = 0; i < 10; i++)
            {
                CommonEnemy fill = new CommonEnemy((i + 1) * 50);
                salad.Add(fill);
            }

            for (int i = 0; i < salad.Count; i++)
            {
                ImageAnimator.Animate(salad[i].ComEnemy, this.Mukodj);
            }
        }

        //Animálás
        private void Mukodj(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        //Találat event
        private void HitEvent()
        {
            for (int i = 0; i < salad.Count; i++)
            {
                for (int j = 0; j < ammo.Count; j++)
                {
                    if (ammo[j].PosX >= salad[i].PosX && ammo[j].PosY >= salad[i].PosY && ammo[j].PosX < salad[i].PosX + 64 && ammo[j].PosY < salad[i].PosY + 64)
                    {
                        ammo[j].PosY = -200;
                        salad[i].PosX = rand.Next(0, 500);
                        salad[i].PosY = -75;
                    }
                }
                

                if (p.PosX >= salad[i].PosX && p.PosY >= salad[i].PosY && p.PosX < salad[i].PosX + 64 && p.PosY < salad[i].PosY + 64)
                {
                    salad[i].PosX = rand.Next(0, 500);
                    salad[i].PosY = -30;
                    p.HP -= 1;
                    if(p.HP == 0)
                    {
                        Close();
                    }
                }
            }
        }

        //Rajzolás
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            ImageAnimator.UpdateFrames();

            Graphics Met = e.Graphics;
            Graphics Com = e.Graphics;
            Graphics Play = e.Graphics;
            Graphics En = e.Graphics;
            Graphics Am = e.Graphics;
            Graphics Start = e.Graphics;
            Graphics Exit = e.Graphics;
            Graphics ShopBut = e.Graphics;
            
            if(srt == 0)
            {
                ShopBut.DrawImage(shopsButton.ShopButton, 100, 300, 128, 128);
                Start.DrawImage(SrtImg, 160, 200, 256, 256);
                Exit.DrawImage(ExitImg, 170, 320, 256, 256);
            }
            else
            {
                for (int i = 0; i < meteors.Count; i++)
                {
                    Met.DrawImage(meteors[i].metor, meteors[i].PosX, meteors[i].PosY, 64, 64);
                }

                for (int i = 0; i < comets.Count; i++)
                {
                    Com.DrawImage(comets[i].comet, comets[i].PosX, comets[i].PosY, 64, 64);
                }

                for (int i = 0; i < salad.Count; i++)
                {
                    if (salad[i].PosX < 500)
                    {
                        En.DrawImage(salad[i].ComEnemy, salad[i].PosX, salad[i].PosY, 64, 64);
                    }
                }

				for (int i = 0; i < ammo.Count; i++)
                {
                    Am.DrawImage(ammo[i].BulletIMG, ammo[i].PosX, ammo[i].PosY, 16, 16);
                }

                Play.DrawImage(p.playerIMG, p.PosX, p.PosY, 32, 32);
            }

            
        }

        //Hátér elemek mozgatása
        private void Bg_Timer_Tick(object sender, EventArgs e)
        {

            for (int i = 0; i < meteors.Count; i++)
            {
                meteors[i].PosY += Yspeed;

                if (meteors[i].PosY > 600)
                {
                    meteors[i].PosY = rand.Next(-50, -20); ;
                    meteors[i].PosX = rand.Next(20, 500);
                }
            }

            for (int i = 0; i < comets.Count; i++)
            {
                comets[i].PosY += Yspeed;
                comets[i].PosX -= Xspeed;

                if (comets[i].PosY > 600)
                {
                    comets[i].PosY = rand.Next(-50, -20); ;
                    comets[i].PosX = rand.Next(20, 500);
                }

                if (comets[i].PosX < -100)
                {
                    comets[i].PosX = 600;
                }
            }


            this.Invalidate();
        }

        //Player mozgatás
        private void Player_Left_Timer_Tick(object sender, EventArgs e)
        {
            if (p.PosX > 0)
            {
                p.PosX -= PlayerSpeed;
            }
        }

        //Player mozgatás
        private void Player_Rigth_Timer_Tick(object sender, EventArgs e)
        {
            if (p.PosX < 500)
            {
                p.PosX += PlayerSpeed;
            }
        }

        //Player mozgatás
        private void Player_Up_Timer_Tick(object sender, EventArgs e)
        {
            if (p.PosY > 0)
            {
                p.PosY -= PlayerSpeed;
            }
        }

        //Player mozgatás
        private void Player_Down_Timer_Tick(object sender, EventArgs e)
        {
            if (p.PosY < 500)
            {
                p.PosY += PlayerSpeed;
            }
        }

        //Gomblenyomás
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
			{
				Player_Left_Timer.Stop();
				Player_Rigth_Timer.Start();
            }
            if (e.KeyCode == Keys.Left)
			{
				Player_Rigth_Timer.Stop();
				Player_Left_Timer.Start();
            }
            if(e.KeyCode == Keys.Up)
			{
				Player_Down_Timer.Stop();
				Player_Up_Timer.Start();
            } 
            if(e.KeyCode == Keys.Down)
            {
				Player_Up_Timer.Stop();
				Player_Down_Timer.Start();
            }
            if (e.KeyCode == Keys.Space)
            {
				AttackSpeed.Start();
			}
		}

        //Gombfelengefés
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
			if (e.KeyCode == Keys.Right)
			{
				Player_Rigth_Timer.Stop();
  
			}
			if (e.KeyCode == Keys.Left)
			{
				Player_Left_Timer.Stop();

			}
			if (e.KeyCode == Keys.Down)
			{
				Player_Down_Timer.Stop();
			}
			if (e.KeyCode == Keys.Up)
			{
				Player_Up_Timer.Stop();
			}

			if (e.KeyCode == Keys.Space)
			{
				AttackSpeed.Stop();
				AttackSpeedAlapra.Start();
			}
		}

        //Enemy timer
        private void Enemy_Move_Timer_Tick(object sender, EventArgs e)
        {
            MoveEnemies();
        }

        //Enemy mozgatása
        private void MoveEnemies()
        {
            for (int i = 0; i < salad.Count; i++)
            {
                salad[i].PosY += enemyspeed;

                if (salad[i].PosY > 550)
                {
                    salad[i].PosX = (i + 1) * 50;
                    salad[i].PosY = -50;
                }
            }
        }

        private void Hit_Timer_Tick(object sender, EventArgs e)
        {
            HitEvent();
        }

        //Ammo mozgatás
        private void Ammo_Move_Timer_Tick(object sender, EventArgs e)
        {
			List<Bullet> ammokToRemove = new List<Bullet>();

			for (int i = 0; i < ammo.Count; i++)
            {
                if (ammo[i].PosY > -100)
                {
                    ammo[i].PosY -= ammospeed;
                }
                else
                {
                    ammo[i].PosX = p.PosX + 9;
					ammokToRemove.Add(ammo[i]);
				}
			}
			foreach (Bullet ammoToRemove in ammokToRemove)
			{
				ammo.Remove(ammoToRemove);
			}




		}

		//Start
		private void GameStart()
		{

			label1.Visible = false;
            Bg_Timer.Start();
            Enemy_Move_Timer.Start();
            Hit_Timer.Start();

			AttackSpeed.Stop();
			Ammo_Move_Timer.Start();
		}


		//Kattintás
		private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            MouseEventArgs mouse = (MouseEventArgs)e;

            if (mouse.X >= 261 && mouse.Y >= 318 && mouse.X < 261 + 75 && mouse.Y < 318 + 23)
            {
                srt = 1;
                GameStart();
            }

            if (mouse.X >= 256 && mouse.Y >= 428 && mouse.X < 256 + 75 && mouse.Y < 428 + 23)
            {
                Close();
            }

            if (mouse.X >= 100 && mouse.Y >= 310 && mouse.X < 100 + 64 && mouse.Y < 310 + 64)
            {
                Shop S = new Shop() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                label1.Visible = false;
                S.FormBorderStyle = FormBorderStyle.None;
                this.Controls.Add(S);
                S.Show();
            }

        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

		private void AttackSpeed_Tick(object sender, EventArgs e)
		{

			shootMedia = new WindowsMediaPlayer();
			shootMedia.URL = "C:\\Users\\Karl\\source\\repos\\Gameszkoa\\songs\\Gunshot_Sound_Effect.mp3";
			shootMedia.settings.volume = 3;
			shootMedia.controls.play();

			AttackSpeed.Interval = 500;
			Bullet basd = new Bullet();
			basd.PosX = p.PosX + 9;
			basd.PosY = p.PosY + 10;
			ammo.Add(basd);

		}

		private void AttackSpeedAlapra_Tick(object sender, EventArgs e)
		{
			AttackSpeed.Interval = 1;
			AttackSpeedAlapra.Stop();
		}
	}
}
