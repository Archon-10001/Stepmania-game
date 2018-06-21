using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stepmania
{
    public partial class Form1 : Form
    {
        bool difficulteasy = false;
        bool difficultmedium = true;
        bool difficultryhard = false;

        bool hitable = true;
        bool hitable1 = true;
        bool hitable2 = true;
        bool hitable3 = true;

        int points = 0;
        int misses = 0;
        int num = 1;
        public Form1()
        {
            InitializeComponent();
            progressBar1.Minimum = 1;
            progressBar1.Maximum = 100;
            progressBar1.Value = 50;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            timer1.Start();
            timer2.Start();
        }

        //Functions for all difficulties speed at which notes fall is changed here.
        public void easydifficulty() {int num = 2; }
        public void mediumdifficulty() { int num = 5; }
        public void harddifficulty() { int num = 8; }

        public void move()
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + num);
            pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + num);
            pictureBox3.Location = new Point(pictureBox3.Location.X, pictureBox3.Location.Y + num);
            pictureBox4.Location = new Point(pictureBox4.Location.X, pictureBox4.Location.Y + num);
        }
        public void scorednote()
        {
            points++;
            try { progressBar1.Value++; } catch { }
        }
        private void missednote()
        {
            System.Media.SoundPlayer soundPlayerwronganswer = new System.Media.SoundPlayer(@"C:\Users\casey\source\repos\Stepmania\Stepmania\Resources\Wronganswer.wav");
            soundPlayerwronganswer.Play();
            try { progressBar1.Value--; } catch { }
            if (progressBar1.Value == 1)
            {
                Application.Exit();
            }
            misses++;
        }
        private void pictureboxresseting()
        {
            //Function that we ensure notes reset once falling below a certain point more is done to reset notes below.
            if (wall.Bounds.IntersectsWith(pictureBox1.Bounds))
            {

                pictureBox1.Location = new Point(12, 12);
                missednote();
            }
            if (wall.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                pictureBox2.Location = new Point(93, 12);
                missednote();
            }
            if (wall.Bounds.IntersectsWith(pictureBox3.Bounds))
            {

                pictureBox3.Location = new Point(173, 12);
                missednote();
            }
            if (wall.Bounds.IntersectsWith(pictureBox4.Bounds))
            {

                pictureBox4.Location = new Point(252, 12);
                missednote();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            move();
            label1.Text = Convert.ToString(points);
            label2.Text = Convert.ToString(misses);
            pictureboxresseting();
            if (difficulteasy == true)
            {
                easydifficulty();
            }
            if (difficultmedium == true)
            {
                mediumdifficulty();
            }
            if (difficultryhard == true)
            {
                harddifficulty();
            }
            
     
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            num++;
            label3.Text = Convert.ToString("Current speed:" + num + "!");
                       
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Functions to deal with key press events
            if (e.KeyCode == Keys.Q)
            {

                if (pictureBox1.Location.Y > button1.Location.Y)
                {
                    pictureBox1.Location = new Point(12, 12);
                    scorednote();
                }
                else
                {
                    hitable = false;
                    missednote();
                }
            }
            if (e.KeyCode == Keys.W)
            {
                if (pictureBox2.Location.Y > button1.Location.Y)
                {
                    pictureBox2.Location = new Point(93, 12);
                    scorednote();
                }
                else
                {
                    hitable1 = false;
                    missednote();
                }
            }
            if (e.KeyCode == Keys.O)
            {
                if (pictureBox3.Location.Y > button1.Location.Y)
                {
                    pictureBox3.Location = new Point(173, 12);
                    scorednote();
                }
                else
                {
                    hitable2 = false;
                    missednote();
                }
            }
            if (e.KeyCode == Keys.P)
            {
                if (pictureBox4.Location.Y > button1.Location.Y)
                {
                    pictureBox4.Location = new Point(252, 12);
                    scorednote();
                }
                else
                {
                    hitable3 = false;
                    missednote();
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                if (groupBox1.Visible == true)
                {
                    timer1.Start();
                    groupBox1.Visible = false;
                }
                else if(groupBox1.Visible == false)
                {
                    timer1.Stop();
                    groupBox1.Visible = true;
                }

            }
            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Btn_Easy_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_Medium_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_Hard_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This game is a stepmania knock off that was made by Casey Beresford!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Casey Beresford + Alastair Jones");
        }
    }
}
