using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public SoundPlayer _soundPlayer;
        public Form1()
        {
            InitializeComponent();
            over.Visible = false;
            _soundPlayer = new SoundPlayer(@"back.wav");
            _soundPlayer.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
            ob(gamespeed);
            gameover();
            coins(gamespeed);
            coinvalues();
        }

        void gameover() {
            if (car.Bounds.IntersectsWith(ob1.Bounds)) {
                timer1.Enabled = false;
                over.Visible = true;
                _soundPlayer.Stop();
            }
            if (car.Bounds.IntersectsWith(ob2.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
                _soundPlayer.Stop();
            }
            if (car.Bounds.IntersectsWith(ob3.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
                _soundPlayer.Stop();
            }
        }

        void coinvalues() {
            if (car.Bounds.IntersectsWith(coin1.Bounds))
            {  coinvalue++;
               point.Text = "Point=" + coinvalue.ToString();
               x = ran.Next(44, 200);
               coin1.Location = new Point(x, 0);

            }

            if (car.Bounds.IntersectsWith(coin2.Bounds))
            {
                coinvalue++;
                point.Text = "Point=" + coinvalue.ToString();
                x = ran.Next(44, 200);
                coin2.Location = new Point(x, 0);

            }

            if (car.Bounds.IntersectsWith(coin3.Bounds))
            {
                coinvalue++;
                point.Text = "Point=" + coinvalue.ToString();
                x = ran.Next(44, 200);
                coin3.Location = new Point(x, 0);

            }

            if (car.Bounds.IntersectsWith(coin4.Bounds))
            {
                coinvalue++;
                point.Text = "Point=" + coinvalue.ToString();
                x = ran.Next(8, 200);
                coin4.Location = new Point(x, 0);
            }

        }


        Random ran = new Random();
        int x, y;
        int coinvalue = 0;
        void ob(int speed)
        {
            if (ob1.Top >= 500)
            {
                x = ran.Next(50, 200);
                ob1.Location = new Point(x, 0);

            }
            else { ob1.Top += speed; }

            if (ob2.Top >= 500)
            {
                x = ran.Next(100,300);
                ob2.Location = new Point(x, 0);
            }
            else { ob2.Top += speed; }

            if (ob3.Top >= 500)
            {
                x = ran.Next(140, 335);
                ob3.Location = new Point(x, 0);
            }
            else { ob3.Top += speed; }

        }

        void coins(int speed)
        {
            if (coin1.Top >= 500)
            {
                x = ran.Next(60, 140);
                coin1.Location = new Point(x, 0);
            }
            else { coin1.Top += speed; }
            if (coin2.Top >= 500)
            {
                x = ran.Next(55, 200);
                coin2.Location = new Point(x, 0);
            }
            else { coin2.Top += speed; }
            if (coin3.Top >= 500)
            {
                x = ran.Next(150,334);
                coin3.Location = new Point(x, 0);
            }
            else { coin3.Top += speed; }
            if (coin4.Top >= 500)
            {
                x = ran.Next(200,330);
                coin4.Location = new Point(x, 0);
            }
            else { coin4.Top += speed; }


        }


        void moveline(int speed)
        {
            

            if (pictureBox1.Top >= 500)
            { pictureBox1.Top = 0; }
            else { pictureBox1.Top += speed; }

            if (pictureBox2.Top >= 500)
            { pictureBox2.Top = 0; }
            else { pictureBox2.Top += speed; }

            if (pictureBox3.Top >= 500)
            { pictureBox3.Top = 0; }
            else { pictureBox3.Top += speed; }

            if (pictureBox4.Top >= 500)
            { pictureBox4.Top = 0; }
            else { pictureBox4.Top += speed; }

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
      
        int gamespeed = 0;
        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (car.Left >44)
                {car.Left += -10;}
            }
            if (e.KeyCode == Keys.Right)
            {
                if (car.Right < 340)
                {car.Left += 10;}
            }

            if (e.KeyCode == Keys.Up) {
                if (gamespeed < 20) {
                    gamespeed++;
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (gamespeed >2)
                {
                    gamespeed--;
                }
            }
        }
    }
}
