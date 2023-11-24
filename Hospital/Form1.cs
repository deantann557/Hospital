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

namespace Hospital
{
    public partial class Form1 : Form
    {
        int page = 1;
        public Form1()
        {
            InitializeComponent();
            outputLabel.Text = "You wake up in a hospital room with no memories";
            option1Label.Text = "Leave the room";
            option2Label.Text = "stay in the room";
            pictureBox.Image = Properties.Resources.Abandoned_hospitals;
        }

        private void option1_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 5;
            }
            else if (page == 2)
            {
                Random ranGen = new Random();
                int randValue = ranGen.Next(1, 101);

                if (randValue > 50)
                {
                    page = 3;
                }
                else
                {
                    page = 4;
                }
            }
            else if (page == 3)
            {
                page = 1;
            }
            else if (page == 4)
            {
                page = 5;
            }
            else if (page == 5)
            {
                page = 7;
            }
            else if (page == 6)
            {
                page = 7;
            }
            else if (page == 7)
            {
                page = 11;
            }
            else if (page == 8)
            {
                page = 9;
            }
            else if (page == 9)
            {
                page = 1;
            }
            else if (page == 10)
            {
                page = 1;
            }
            else if (page == 11)
            {
                page = 13;
            }
            else if (page == 12)
            {
                page = 1;
            }
            else if (page == 13)
            {
                page = 14;
            }
            else if (page == 14)
            {
                page = 1;
            }
            else if (page == 15)
            {
                page = 1;
            }


            switch (page)
            {
                case 1:
                    outputLabel.Text = "You wake up in a hospital room with no memories";
                    option1Label.Text = "Leave the room";
                    option2Label.Text = "stay in the room";
                    pictureBox.Image = Properties.Resources.Abandoned_hospitals;
                    break;
                case 2:
                    outputLabel.Text = "You stay in the room, find food";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    break;
                case 3:
                    outputLabel.Text = "The food poisens you  \n Do you play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 4:
                    outputLabel.Text = "The food is stale. \nwhat now?";
                    option1Label.Text = "Leave the room?";
                    option2Label.Text = "Stay inside";
                    break;
                case 5:
                    outputLabel.Text = "Youre in a long empty hallway with doors along it.\n Check the doors or go to the end of the hall?";
                    option1Label.Text = "Hallway";
                    option2Label.Text = "Doors";
                    pictureBox.Image = Properties.Resources.hallway;
                    break;
                case 6:
                    outputLabel.Text = "All the doors are locked or cant be opened. now what? ";
                    option1Label.Text = "check hallway?";
                    option2Label.Text = "Try doors again";
                    break;
                case 7:
                    outputLabel.Text = "You walk to the end end of the hallway \nThe hallway splits to the left and the right";
                    option1Label.Text = "Left";
                    option2Label.Text = "Right";
                    break;
                case 8:
                    outputLabel.Text = "you see an elevator and a set of stairs \n which do you use?";
                    option1Label.Text = "Elevator";
                    option2Label.Text = "Stairs";
                    break;
                case 9:
                    outputLabel.Text = "You use the elevator and it falls down the shaft killing you. \nplay again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox.Image = Properties.Resources.eleavator;
                    break;
                case 10:
                    outputLabel.Text = "You use the stairs and they crumble under you \n Do you play again";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox.Image = Properties.Resources.stairway;
                    break;
                case 11:
                    outputLabel.Text = "You go left and see cracks along the ground as you continue the floor collepses under you bringing down to the floor below \nYou see some one down there. Call out to them? ";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox.Image = Properties.Resources.collapsedfloor;
                    break;
                case 12:
                    outputLabel.Text = "You start to walk away but trip and they come after you. \n Do you play again";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox.Image = Properties.Resources.manRunning;
                    break;
                case 13:
                    outputLabel.Text = "You call out to them they then start chasing you aggressively. \n Do you fight back?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox.Image = Properties.Resources.manRunning;
                    break;
                case 14:
                    outputLabel.Text = "They are much stronger than you. \n Do you play again";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox.Image = Properties.Resources.manRunning;
                    break;
                case 15:
                    outputLabel.Text = "You turn around to run and go through an exit. You win. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox.Image = Properties.Resources.exit;
                    break;
                case 99:

                    outputLabel.Text = "Thank you for playing";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    Refresh();
                    Thread.Sleep(2000);
                    Close();
                    break;
                default:
                    break;

            }
        }

        private void option2_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 1;
            }
            else if (page == 3)
            {
                page = 99;
            }
            else if (page == 4)
            {
                page = 1;
            }
            else if (page == 5)
            {
                page = 6;
            }
            else if (page == 6)
            {
                page = 6;
            }
            else if (page == 7)
            {
                page = 8;
            }
            else if (page == 8)
            {
                page = 10;
            }
            else if (page == 9)
            {
                page = 99;
            }
            else if (page == 10)
            {
                page = 99;
            }
            else if (page == 11)
            {
                page = 12;
            }
            else if (page == 12)
            {
                page = 99;
            }
            else if (page == 13)
            {
                page = 15;
            }
            else if (page == 14)
            {
                page = 99;
            }
            else if (page == 15)
            {
                page = 99;
            }
            switch (page)
            {
                case 1:
                    outputLabel.Text = "You wake up in a hospital room with no memories";
                    option1Label.Text = "Leave the room";
                    option2Label.Text = "stay in the room";
                    pictureBox.Image = Properties.Resources.Abandoned_hospitals;
                    break;
                case 2:
                    outputLabel.Text = "You stay in the room, find food?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    break;
                case 3:
                    outputLabel.Text = "The food poisens you  \n Do you play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 4:
                    outputLabel.Text = "The food is stale. \nwhat now?";
                    option1Label.Text = "Leave the room?";
                    option2Label.Text = "Stay inside";
                    break;
                case 5:
                    outputLabel.Text = "Youre in a long empty hallway with doors along it.\n Check the doors or go to the end of the hall?";
                    option1Label.Text = "Hallway";
                    option2Label.Text = "Doors";
                    pictureBox.Image = Properties.Resources.hallway;
                    break;
                case 6:
                    outputLabel.Text = "All the doors are locked or can't be opened.\n now what? ";
                    option1Label.Text = "check hallway?";
                    option2Label.Text = "Check doors again?";
                    break;
                case 7:
                    outputLabel.Text = "You walk to the end end of the hallway \nThe hallway splits to the left and the right";
                    option1Label.Text = "Left";
                    option2Label.Text = "Right";
                    break;
                case 8:
                    outputLabel.Text = "you see an elevator and a set of stairs \n which do you use?";
                    option1Label.Text = "Elevator";
                    option2Label.Text = "Stairs";
                    break;
                case 9:
                    outputLabel.Text = "You use the elevator and it falls down the shaft killing you. \nplay again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox.Image = Properties.Resources.eleavator;
                    break;
                case 10:
                    outputLabel.Text = "You use the stairs and they crumble under you \n Do you play again";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox.Image = Properties.Resources.stairway;
                    break;
                case 11:
                    outputLabel.Text = "You go left and see cracks along the ground as you continue the floor collepses under you bringing down to the floor below \nYou see some one down there. Call out to them? ";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox.Image = Properties.Resources.collapsedfloor;
                    break;
                case 12:
                    outputLabel.Text = "You start to walk away but trip and they come after you. \n Do you play again";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox.Image = Properties.Resources.manRunning;
                    break;
                case 13:
                    outputLabel.Text = "You call out to them they then start chasing you aggressively. \n Do you fight back?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox.Image = Properties.Resources.manRunning;
                    break;
                case 14:
                    outputLabel.Text = "They are much stronger than you. \n Do you play again";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox.Image = Properties.Resources.manRunning;
                    break;
                case 15:
                    outputLabel.Text = "You turn around to run and go through an exit. You win. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox.Image = Properties.Resources.exit;
                    break;
                case 99:

                    outputLabel.Text = "Thank you for playing";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    Refresh();
                    Thread.Sleep(2000);
                    Close();
                    break;
                default:
                    break;
            }
        }
    }
}
