using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleSideScrollingGameNiceM
{
    public partial class frmScrollingGame : Form
    {
        // declaring global variables
        bool goLeft = false;
        bool goRight = false;
        bool jumping = false;
        bool hasKey = false;

        int jumpSpeed = 30;
        int force = 8;
        int score = 0;

        int playSpeed = 18;
        int backLeft = 8;



        public frmScrollingGame()
        {
            InitializeComponent();

        }



        private void frmSideScrollingGame_Load(object sender, EventArgs e)
        {

        }

        private void picPlatform2_Click(object sender, EventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            // move the player
            picPlayer.Top += jumpSpeed;

            // refreshing the player pic box
            picPlayer.Refresh();



            if ((jumping && force < 0))
            {
                // setting jumping to false
                jumping = false;
            }

            if (jumping)
            {
                jumpSpeed = -12;
                force -= 1;
            }

            else
            {
                jumpSpeed = 12;
            }

            // if go left is true and player left s greayer than 200 pixels then move the playe to the left
            if (goLeft && picPlayer.Left > 100)
            {
                // making the player stop on the left
                picPlayer.Left -= playSpeed;
            }

            // moving the player to right by adding to the players left
            if (goRight && picPlayer.Left + (picPlayer.Width + 100) < this.ClientSize.Width)
            {
                // this makes the picture box stop on the right of the form
                picPlayer.Left += playSpeed;
            }

            if (goRight && background.Left > -1353)
            {
                background.Left -= backLeft;
            }

            // the for loop checks to see the platforms and coins in the level when they are found it will move the items to the left
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "platform" || x is PictureBox && x.Tag == "coin" || x is PictureBox && x.Tag == "door" || x is PictureBox && x.Tag == " key")
                {
                    x.Left -= backLeft;
                }
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "Platform")
                {
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        force = 8;
                        picPlayer.Top = x.Top - picPlayer.Height;
                        jumpSpeed = 0;
                    }
                }

                if (x is PictureBox && x.Tag == "Coin")
                {
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        score++;
                    }
                }

            }
            // if the door collides with the door then the hasKey boolean is true
            if (picPlayer.Bounds.IntersectsWith(picDoor1.Bounds) && hasKey)
            {
                picDoor1.Image = Properties.Resources.door_closed3;

                // stopping the timer
                Timer.Stop();
                MessageBox.Show(" You completed the level!!");
            }

            // if player collides with the key picture box
            if (picPlayer.Bounds.IntersectsWith(picKey1.Bounds))
            {
                // then remove the key from the game
                this.Controls.Remove(picKey1);

                // change the has key boolean to true
                hasKey = true;
            }

            // this is where the player dies
            if (picPlayer.Top + picPlayer.Height > this.ClientSize.Height + 60)
            {
                //stopping the timer
                Timer.Stop();
                MessageBox.Show("You died!!!");
            }



        }

        

        private void keyisdown(object sender, KeyEventArgs e)
        {

            Console.WriteLine("***keyisdown called");

            // setting the booleans to be false
            if (e.KeyCode == Keys.Left)
            {
                Console.WriteLine("***Go left");
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                Console.WriteLine("***Go right");
                goRight = true;
            }
            if (e.KeyCode == Keys.Space && !jumping)
            {
                Console.WriteLine("***Jump");
                jumping = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            Console.WriteLine("*** keyisup called");
            // setting the booleans to be false
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Space && !jumping)
            {
                jumping = false;
            }
        }

        private void background_Click(object sender, EventArgs e)
        {

        }


}   }
