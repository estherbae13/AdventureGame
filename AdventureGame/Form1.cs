/*Esther Bae 
* Mr.T
* May 21, 2021
* Decision adventure game where the player can choose their decisions to make it out of the haunted house.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace AdventureGame
{
    public partial class Form1 : Form
    {
        //player page tracker
        int page = 1;

        //sound player
        SoundPlayer musicPlayer;

        //random generator + variable
        Random randGen = new Random();
        int randomdecision;

        public Form1()
        {
            InitializeComponent();

            //display orignal messages + options
            DisplayPage();

            //make opt 3 invis
            option3Button.Visible = false;
            option3Button.Enabled = false;

            //set background image
            imageBox.BackgroundImage = Properties.Resources.hauntedHouse;
            imageBox.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            //check page and flip to right page if opt 1 is chosen
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2) { page = 4; }
            else if (page == 3) { page = 17; }
            else if (page == 4) { page = 6; }
            else if (page == 5) { page = 12; }
            else if (page == 6) { page = 8; }
            else if (page == 7) { page = 1; }
            else if (page == 8) { page = 1; }
            else if (page == 9) { page = 10; }
            else if (page == 10) { page = 1; }
            else if (page == 11) { page = 1; }
            else if (page == 12) { page = 14; }
            else if (page == 13) { page = 1; }
            else if (page == 14) { page = 1; }
            else if (page == 15) { page = 1; }
            else if (page == 16) { page = 1; }
            else if (page == 17) { page = 1; }
            else if (page == 18) { page = 19; }
            else if (page == 19) { page = 1; }
            else if (page == 20) { page = 21; }
            else if (page == 21) { page = 1; }
            else if (page == 22) { page = 1; }
            else if (page == 23) { page = 1; }

            DisplayPage();
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            //check page and flip to right page if opt 2 is chosen
            if (page == 1)
            {
                page = 3;
            }
            else if (page == 2) { page = 5; }
            else if (page == 3) { page = 18; }
            else if (page == 4) { page = 7; }
            else if (page == 5) { page = 13; }
            else if (page == 6) { page = 9; }
            else if (page == 7) { page = 99; }
            else if (page == 8) { page = 99; }
            else if (page == 9) { page = 11; }
            else if (page == 10) { page = 99; }
            else if (page == 11) { page = 99; }
            else if (page == 12)
                //50/50 chance of survival through random generator
            {
                randomdecision = randGen.Next(1, 101);
                if (randomdecision > 50) { page = 15; }
                else { page = 16; }
            }
            else if (page == 13) { page = 99; }
            else if (page == 14) { page = 99; }
            else if (page == 15) { page = 99; }
            else if (page == 16) { page = 99; }
            else if (page == 17) { page = 99; }
            else if (page == 18) { page = 20; }
            else if (page == 19) { page = 99; }
            else if (page == 20) { page = 22; }
            else if (page == 21) { page = 99; }
            else if (page == 22) { page = 99; }
            else if (page == 23) { page = 99; }

            DisplayPage();
        }

        private void option3Button_Click(object sender, EventArgs e)
        {
            //enable third option
            if (page == 20) { page = 23; }

            DisplayPage();
        }

        public void DisplayPage()
        {
            switch (page)
            {
                //added sounds, images, and text to each page
                case 1:
                    musicPlayer = new SoundPlayer(Properties.Resources.scarySound);
                    musicPlayer.Play();

                    imageBox.BackgroundImage = Properties.Resources.hauntedHouse;
                    imageBox.BackgroundImageLayout = ImageLayout.Zoom;

                    outputLabel.Text = "You wake up in a haunted house. Explore or get out?";
                    option1Button.Text = "Explore";
                    option2Button.Text = "Get out";
                    break;
                case 2:
                    musicPlayer = new SoundPlayer(Properties.Resources.suspense);
                    musicPlayer.Play();

                    imageBox.BackgroundImage = Properties.Resources.stairs;
                    imageBox.BackgroundImageLayout = ImageLayout.Zoom;

                    outputLabel.Text = "You decide to walk up the creepy spiral staircase. " +
                        "Keep going up or stop at the second floor?";
                    option1Button.Text = "Stop at the second floor";
                    option2Button.Text = "Keep going up";
                    break;
                case 3:
                    musicPlayer = new SoundPlayer(Properties.Resources.doorKnocking);
                    musicPlayer.Play();

                    imageBox.BackgroundImage = Properties.Resources.Door;
                    imageBox.BackgroundImageLayout = ImageLayout.Zoom;

                    outputLabel.Text = "The front door is locked! Give up or keep looking for an exit?";
                    option1Button.Text = "Give up";
                    option2Button.Text = "Keep looking";
                    break;
                case 4:
                    musicPlayer = new SoundPlayer(Properties.Resources.creaking);
                    musicPlayer.Play();

                    imageBox.BackgroundImage = Properties.Resources.hallway;
                    imageBox.BackgroundImageLayout = ImageLayout.Zoom;

                    outputLabel.Text = "There is a library and a bedroom on the second floor. " +
                        "Go to the library or the bedroom?";
                    option1Button.Text = "Library";
                    option2Button.Text = "Bedroom";
                    break;
                case 5:
                    musicPlayer = new SoundPlayer(Properties.Resources.scarySound);
                    musicPlayer.Play();

                    imageBox.BackgroundImage = Properties.Resources.ladder;
                    imageBox.BackgroundImageLayout = ImageLayout.Zoom;

                    outputLabel.Text = "You find a ladder going to the attic. " +
                        "Go up the ladder or stay on the third floor?";
                    option1Button.Text = "Ladder";
                    option2Button.Text = "Stay on third floor";
                    break;
                case 6:
                    musicPlayer = new SoundPlayer(Properties.Resources.bookOpening);
                    musicPlayer.Play();

                    imageBox.BackgroundImage = Properties.Resources.library;
                    imageBox.BackgroundImageLayout = ImageLayout.Zoom;

                    outputLabel.Text = "A book opens on a desk. Look at the book or ignore it?";
                    option1Button.Text = "Look at book";
                    option2Button.Text = "Ignore it";
                    break;
                case 7:
                    musicPlayer = new SoundPlayer(Properties.Resources.fail);
                    musicPlayer.Play();

                    imageBox.BackgroundImage = Properties.Resources.youlose;
                    imageBox.BackgroundImageLayout = ImageLayout.Zoom;

                    outputLabel.Text = "The door slams shut and the room lights on fire! You lose. Play again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    break;
                case 8:
                    musicPlayer = new SoundPlayer(Properties.Resources.fail);
                    musicPlayer.Play();

                    imageBox.BackgroundImage = Properties.Resources.youlose;
                    imageBox.BackgroundImageLayout = ImageLayout.Zoom;

                    outputLabel.Text = "The book is cursed and you die when you touch it! You lose. Play again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    break;
                case 9:
                    musicPlayer = new SoundPlayer(Properties.Resources.waterDrops);
                    musicPlayer.Play();

                    imageBox.BackgroundImage = Properties.Resources.staircase;
                    imageBox.BackgroundImageLayout = ImageLayout.Zoom;

                    outputLabel.Text = "You ignore the book and instead pull out a random book on a bookshelf " +
                        "and a hidden staircase opens up. Go down the staircase or leave?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    break;
                case 10:
                    musicPlayer = new SoundPlayer(Properties.Resources.win);
                    musicPlayer.Play();

                    imageBox.BackgroundImage = Properties.Resources.youwin1;
                    imageBox.BackgroundImageLayout = ImageLayout.Zoom;

                    outputLabel.Text = "You walk down the staircase and walk down the long hallway " +
                        "and there is an exit. You made it out! You win! Play again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    break;
                case 11:
                    musicPlayer = new SoundPlayer(Properties.Resources.fail);
                    musicPlayer.Play();

                    imageBox.BackgroundImage = Properties.Resources.youlose;
                    imageBox.BackgroundImageLayout = ImageLayout.Zoom;

                    outputLabel.Text = "You turn to leave but the library door is gone and you are lost in " +
                        "a sea of bookshelves. You lose. Play again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    break;
                case 12:
                    musicPlayer = new SoundPlayer(Properties.Resources.creaking);
                    musicPlayer.Play();

                    imageBox.BackgroundImage = Properties.Resources.attic;
                    imageBox.BackgroundImageLayout = ImageLayout.Zoom;

                    outputLabel.Text = "There is an open window in the attic and an old parachute. " +
                        "Go back down or use parachute?";
                    option1Button.Text = "Go back down";
                    option2Button.Text = "Use parachute";
                    break;
                case 13:
                    musicPlayer = new SoundPlayer(Properties.Resources.fail);
                    musicPlayer.Play();

                    imageBox.BackgroundImage = Properties.Resources.youlose;
                    imageBox.BackgroundImageLayout = ImageLayout.Zoom;

                    outputLabel.Text = "The stairs disappear and ghosts come out of the walls. " +
                        "You lose. Play again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    break;
                case 14:
                    musicPlayer = new SoundPlayer(Properties.Resources.fail);
                    musicPlayer.Play();

                    imageBox.BackgroundImage = Properties.Resources.youlose;
                    imageBox.BackgroundImageLayout = ImageLayout.Zoom;

                    outputLabel.Text = "You go back down and ghosts attack you. You lose. Play again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    break;
                case 15:
                    musicPlayer = new SoundPlayer(Properties.Resources.fail);
                    musicPlayer.Play();

                    imageBox.BackgroundImage = Properties.Resources.youlose;
                    imageBox.BackgroundImageLayout = ImageLayout.Zoom;

                    outputLabel.Text = "The parachute doesn't work and you die. Play again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    break;
                case 16:
                    musicPlayer = new SoundPlayer(Properties.Resources.win);
                    musicPlayer.Play();

                    imageBox.BackgroundImage = Properties.Resources.youwin1;
                    imageBox.BackgroundImageLayout = ImageLayout.Zoom;

                    outputLabel.Text = "You made it out safely! Play again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    break;
                case 17:
                    musicPlayer = new SoundPlayer(Properties.Resources.fail);
                    musicPlayer.Play();

                    imageBox.BackgroundImage = Properties.Resources.youlose;
                    imageBox.BackgroundImageLayout = ImageLayout.Zoom;

                    outputLabel.Text = "You give up and lose all hope. Ghosts attack you. You lose! Play again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    break;
                case 18:
                    musicPlayer = new SoundPlayer(Properties.Resources.suspense);
                    musicPlayer.Play();

                    imageBox.BackgroundImage = Properties.Resources.hammer;
                    imageBox.BackgroundImageLayout = ImageLayout.Zoom;

                    outputLabel.Text = "You find an old hammer on the ground. Break open windows or the door?";
                    option1Button.Text = "Windows";
                    option2Button.Text = "Door";
                    break;
                case 19:
                    musicPlayer = new SoundPlayer(Properties.Resources.win);
                    musicPlayer.Play();

                    imageBox.BackgroundImage = Properties.Resources.youwin1;
                    imageBox.BackgroundImageLayout = ImageLayout.Zoom;

                    outputLabel.Text = "The windows easily break open and you make it out! You win! Play again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    break;
                case 20:
                    musicPlayer = new SoundPlayer(Properties.Resources.ghost);
                    musicPlayer.Play();

                    imageBox.BackgroundImage = Properties.Resources.ghost1;
                    imageBox.BackgroundImageLayout = ImageLayout.Zoom;

                    option3Button.Visible = true;
                    option3Button.Enabled = true;

                    outputLabel.Text = "The noise attracts ghosts! Run somewhere " +
                        "safe, fight the ghosts, or keep trying to break open the door?";
                    option1Button.Text = "Run somewhere";
                    option2Button.Text = "Fight the ghosts";
                    option3Button.Text = "Break open the door";
                    break;
                case 21:
                    musicPlayer = new SoundPlayer(Properties.Resources.win);
                    musicPlayer.Play();

                    imageBox.BackgroundImage = Properties.Resources.youwin1;
                    imageBox.BackgroundImageLayout = ImageLayout.Zoom;

                    //clear option 3 button because it isn't needed anymore
                    option3Button.Visible = false;
                    option3Button.Enabled = false;

                    outputLabel.Text = "You run for a while and find the back door and make your escape! " +
                        "Play again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    break;
                case 22:
                    musicPlayer = new SoundPlayer(Properties.Resources.fail);
                    musicPlayer.Play();

                    imageBox.BackgroundImage = Properties.Resources.youlose;
                    imageBox.BackgroundImageLayout = ImageLayout.Zoom;

                    //clear option 3 button because it isn't needed anymore
                    option3Button.Visible = false;
                    option3Button.Enabled = false;

                    outputLabel.Text = "You try to fight the ghosts but there's no way for you to win or escape. " +
                        "You lose! Play again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    break;
                case 23:
                    musicPlayer = new SoundPlayer(Properties.Resources.fail);
                    musicPlayer.Play();

                    imageBox.BackgroundImage = Properties.Resources.youlose;
                    imageBox.BackgroundImageLayout = ImageLayout.Zoom;

                    //clear option 3 button because it isn't needed anymore
                    option3Button.Visible = false;
                    option3Button.Enabled = false;

                    outputLabel.Text = "The door still doesn't break open and the ghosts attack you!. " +
                        "You lose. Play again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    break;
                case 99:
                    outputLabel.Text = "Thank you for playing!";
                    option1Button.Text = "";
                    option2Button.Text = "";

                    //clear everything except the output label
                    imageBox.Visible = false;
                    option1Button.Visible = false;
                    option1Button.Enabled = false;
                    option2Button.Visible = false;
                    option2Button.Enabled = false;

                    //automatically exits game if player does not want to play anymore
                    Refresh();
                    Thread.Sleep(3000);
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }
    }
}
