using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingGame
{
    public partial class Form1 : Form
    {

        int roadSpeed;
        int trafficSpeed;
        int playerSpeed = 12;
        int score;
        int carImage;

        Random rand = new Random();
        Random carPosiotion = new Random();

        bool goLeft, goRight;

        public Form1()
        {
            InitializeComponent();
            ResetGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                goLeft = true;

            }
            if(e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;

            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {

            txtScore.Text = "Score: " + score;
            score++;

            if (goLeft == true && player.Left > 5) //collision
            {
                player.Left -= playerSpeed;
            }
            if (goRight == true && player.Left < 300)
            {
                player.Left += playerSpeed;
            }

            RoadTrack1.Top += roadSpeed;
            RoadTrack2.Top += roadSpeed;

            if (RoadTrack2.Top > 441)
            {
                RoadTrack2.Top = -411;

            }
            if (RoadTrack1.Top > 441)
            {
                RoadTrack1.Top = -441;
            }

            npc1.Top += trafficSpeed;
            npc2.Top += trafficSpeed;

            if (npc1.Top > 442)
            {
                changeNPCcars(npc1);
            }
            if (npc2.Top > 442)
            {
                changeNPCcars(npc2);
            }
            if (player.Bounds.IntersectsWith(npc1.Bounds) || player.Bounds.IntersectsWith(npc2.Bounds))
            {
                gameOver();
            }

            if (score > 40 && score < 500)
            {
                award.Image = Properties.Resources.bronze;
            }

            if (score > 500 && score < 5000)
            {
                award.Image = Properties.Resources.silver;
                roadSpeed = 18;
                trafficSpeed = 18;
            }

            if (score > 5000)
            {
                award.Image = Properties.Resources.gold;
                trafficSpeed = 21;
                roadSpeed = 21;
            }

        }

        private void changeNPCcars(PictureBox tempCar)
        {

            carImage = rand.Next(1,9);

            switch (carImage)
            {
                case 1:
                    tempCar.Image = Properties.Resources.ambulance;
                    break;
                case 2:
                    tempCar.Image = Properties.Resources.carGreen;
                    break;
                case 3:
                    tempCar.Image = Properties.Resources.carOrange;
                    break;
                case 4:
                    tempCar.Image = Properties.Resources.carPink;
                    break;
                case 5:
                    tempCar.Image = Properties.Resources.CarRed;
                    break;
                case 6:
                    tempCar.Image = Properties.Resources.carGrey;
                        break;
                case 7:
                    tempCar.Image = Properties.Resources.carYellow;
                    break;
                case 8:
                    tempCar.Image = Properties.Resources.TruckBlue;
                    break;
                case 9:
                    tempCar.Image = Properties.Resources.TruckWhite;
                    break;

            }

            tempCar.Top = carPosiotion.Next(100, 400) * -1;

            if((string)tempCar.Tag == "CarLeft")
            {
                tempCar.Left = carPosiotion.Next(5, 191);
            }

            if((string)tempCar.Tag == "CarRight")
            {
                tempCar.Left = carPosiotion.Next(250, 300);
            }

        }

        private void gameOver()
        {
            playSound();
            gameTimer.Stop();
            explosion.Visible = true;

            player.Controls.Add(explosion);
            explosion.Location = new Point(-8, 5);

            explosion.BackColor = Color.Transparent;

            award.Visible = true;
            award.BringToFront();

            buttonStart.Enabled = true;
        }

        private void ResetGame()
        {
            buttonStart.Enabled = false;
            explosion.Visible = false;
            award.Visible = false;
            goLeft = false;
            goRight = false;
            score = 0;
            award.Image = Properties.Resources.bronze;

            roadSpeed = 12;
            trafficSpeed = 15;

            npc1.Top = carPosiotion.Next(200, 449) *-1; //19,194
            npc1.Left = carPosiotion.Next(19, 194);

            npc2.Top = carPosiotion.Next(200,449)*-1;
            npc2.Left = carPosiotion.Next(267, 423);


            gameTimer.Start();

        }

        private void restartGame(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void playSound()
        {
            System.Media.SoundPlayer playerCrash = new System.Media.SoundPlayer(Properties.Resources.hit);
            playerCrash.Play();
        }
    }
}
