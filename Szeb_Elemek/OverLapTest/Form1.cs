using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverLapTest
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        List<Meteor> meteors;
        List<Comets> comets;
        Player p;
        List<CommonEnemy> salad;
        List<Bullet> ammo;

        int Yspeed;
        int Xspeed;

        int PlayerSpeed;
        int enemyspeed;
        int ammospeed;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            p = new Player();

            ammo = new List<Bullet>();
            for (int i = 0; i < 1; i++)
            {
                Bullet b = new Bullet();
                ammo.Add(b);
            }

            SpawnEnemy();
            GenerateBG();



            Yspeed = 7;
            Xspeed = 6;

            PlayerSpeed = 5;
            enemyspeed = 5;
            ammospeed = 20;
        }

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

        private void Mukodj(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void HitEvent()
        {
            for (int i = 0; i < salad.Count; i++)
            {
                for (int j = 0; j < ammo.Count; j++)
                {
                    if (ammo[j].PosX >= salad[i].PosX && ammo[j].PosY >= salad[i].PosY && ammo[j].PosX < salad[i].PosX + 64 && ammo[j].PosY < salad[i].PosY + 64)
                    {
                        ammo[j].PosY = -10;
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

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            ImageAnimator.UpdateFrames();

            Graphics Met = e.Graphics;
            Graphics Com = e.Graphics;
            Graphics Play = e.Graphics;
            Graphics En = e.Graphics;
            Graphics Am = e.Graphics;
            

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

            for(int i = 0; i < ammo.Count; i++)
            {
                Am.DrawImage(ammo[i].BulletIMG, ammo[i].PosX, ammo[i].PosY, 16, 16);
            }

            Play.DrawImage(p.playerIMG, p.PosX, p.PosY, 32, 32);
        }

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

        private void Player_Left_Timer_Tick(object sender, EventArgs e)
        {
            if (p.PosX > 0)
            {
                p.PosX -= PlayerSpeed;
            }
        }

        private void Player_Rigth_Timer_Tick(object sender, EventArgs e)
        {
            if (p.PosX < 500)
            {
                p.PosX += PlayerSpeed;
            }
        }

        private void Player_Up_Timer_Tick(object sender, EventArgs e)
        {
            if (p.PosY > 0)
            {
                p.PosY -= PlayerSpeed;
            }
        }

        private void Player_Down_Timer_Tick(object sender, EventArgs e)
        {
            if (p.PosY < 500)
            {
                p.PosY += PlayerSpeed;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                Player_Rigth_Timer.Start();
            }
            if (e.KeyCode == Keys.Left)
            {
                Player_Left_Timer.Start();
            }
            if(e.KeyCode == Keys.Up)
            {
                Player_Up_Timer.Start();
            }
            if(e.KeyCode == Keys.Down)
            {
                Player_Down_Timer.Start();
            }
            if (e.KeyCode == Keys.Space)
            {
                Ammo_Move_Timer.Start();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Player_Rigth_Timer.Stop();
            Player_Left_Timer.Stop();
            Player_Up_Timer.Stop();
            Player_Down_Timer.Stop();
        }

        private void Enemy_Move_Timer_Tick(object sender, EventArgs e)
        {
            MoveEnemies();
        }

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

        private void Ammo_Move_Timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < ammo.Count; i++)
            {
                if (ammo[i].PosY > -100)
                {
                    ammo[i].PosY -= ammospeed;
                }
                else
                {
                    ammo[i].PosX = p.PosX + 9;
                    ammo[i].PosY = p.PosY;
                }
            }
        }
    }
}
