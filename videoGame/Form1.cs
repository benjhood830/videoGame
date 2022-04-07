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

// "descriptionLabel" is the name od the label to ouput the current situation
//option 1 = red
// option 2 = blue
namespace videoGame
{
    public partial class videoGame : Form
    {
        int page = 1;
        Random randGen = new Random();   
        public videoGame()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // method that displays page
            page = 1;
            DisplayPage();
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            /// Check what page we are currently on, and then flip
            /// to the page you need to go to if you selected option 1

            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 3;
            }
            else if (page == 3)
            {
                page = 6;
            }
            else if (page == 6)
            {
                //only 5% chance
                int randValue = randGen.Next(1, 101);

                if(randValue < 5)
                {
                    page = 7;
                }
                else
                {
                    page = 96;
                }
            }
            else if (page ==4)
            {
                page = 6;
            }
            else if (page == 26)
            {
                page = 96;
            }
            else if (page == 39)
            {
                page = 11;
            }
            else if (page == 9)
            {
                int randValue = randGen.Next(1, 101);

                if(randValue > 50)
                {
                    page = 10;
                }
                else
                {
                    page = 96;
                }
            }
            else if (page == 13)
            {
                page = 25;
            }
            else if (page == 16)
            {
                int randValue = randGen.Next(1, 101);

                if (randValue < 60)
                {
                    page = 17;
                }
                else
                {
                    page = 18;
                }
            }
            else if (page == 19)
            {
                int randValue = randGen.Next(1, 101);

                if(randValue < 90)
                {
                    page = 96;
                }
                else
                {
                    page = 99;
                }
            }
            else if (page == 20)
            {
                int randValue = randGen.Next(1, 101);
                if (randValue > 90)
                {
                    page = 99;
                }
                else
                {
                    page = 96;
                }
            }
            else if (page == 29)
            {
                page = 96;
            }
            else if (page == 96)
            {
                page = 1;
            }
            else if (page == 97)
            {
                page = 1;
            }
            else if (page == 15)
            {
                page = 16;
            }
            DisplayPage();
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 29;
            }
            else if (page == 29)
            {
                page = 96;
            }
            else if (page == 2)
            {
                page = 5;
            }
            else if (page == 26)
            {
                page = 96;
            }
            else if (page == 4)
            {
                page = 39;
            }
            else if (page == 39)
            {
                page = 9;
            }
            else if (page == 13)
            {
                page = 14;
            }
            else if (page == 15)
            {
                page = 16;
            }
            else if (page == 19)
            {
                page = 21;
            }
            else if (page == 96)
            {
                page = 98;
            }
            else if (page == 97)
            {
                page = 98;
            }
            DisplayPage();
        }
        public void DisplayPage()
        {this.Text = page.ToString();

            switch(page)
            {
                //properties for my pages
                case 1:
                    titleLabel.Text = "";
                    startButton.Visible = false;
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option3Button.Visible = true;
                    descriptionLabel.Text = "It's another beautiful morning as the warmth of June seeps through the window.";
                    option1Label.Text = "Keep Sleeping";
                    option2Label.Text = "Wake up";
                    option3Label.Text = "Die";
                    imageBox.BackgroundImage = Properties.Resources.sunrise;
                    SoundPlayer birds = new SoundPlayer(Properties.Resources.Bird);
                    break;
                case 2:
                    descriptionLabel.Text = "It's now 10 am and your mother comes in FURIOUS.";
                    option1Label.Text = "Punch your mother";
                    option2Label.Text = "Run away";
                    imageBox.BackgroundImage = Properties.Resources.mad_mom;
                    break;
                case 3:
                    descriptionLabel.Text = "Your mother retaliates with sucker punching you in the face.";
                    option3Label.Text = "Continue";
                    option2Label.Text = "";
                    option1Label.Text = "";

                    option3Button.Visible = true;
                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    imageBox.BackgroundImage = Properties.Resources.punch;
                    break;
                case 4:
                    descriptionLabel.Text = "Your father grabs you off the floor and wants to brings you to the hospital. ";
                    option1Label.Text = "Go with him";
                    option2Label.Text = "Don't go with him";
                    option3Label.Text = "";

                    option3Button.Visible = false;
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    imageBox.BackgroundImage = Properties.Resources.hospital;
                    break;
                case 5:
                    descriptionLabel.Text = "You finally reach an alley to hide in. You see a strange looking man in the alley hiding behind the dumpster. You decide to ignore him and run the other way down the alley.";
                    option3Label.Text = "Continue";
                    option2Label.Text = "";
                    option1Label.Text = "";

                    option3Button.Visible = true;
                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    imageBox.BackgroundImage = Properties.Resources.alley;
                    break;
                case 6:
                    descriptionLabel.Text = "While arguing with you, your father hits a bump in the road and the car slides off the road into the gutter.";
                    option3Label.Text = "";
                    option2Label.Text = "";
                    option1Label.Text = "Continue";

                    option3Button.Visible = false;
                    option1Button.Visible = true;
                    option2Button.Visible = false;
                    imageBox.BackgroundImage = Properties.Resources.pot_hole;
                    break;
                case 7:
                    descriptionLabel.Text = "You leave your father for dead in the car wreck and walk to the hospital.";
                    option3Label.Text = "Continue";
                    option2Label.Text = "";
                    option1Label.Text = "";

                    option3Button.Visible = true;
                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    imageBox.BackgroundImage = Properties.Resources.crash_car;
                    break;
                case 8:
                    descriptionLabel.Text = "Your mother forgives you and you get the rest of the day off school.";
                    option3Label.Text = "Continue";
                    option2Label.Text = "";
                    option1Label.Text = "";

                    option3Button.Visible = true;
                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    imageBox.BackgroundImage = Properties.Resources.happy_mom;
                    break;
                case 9:
                    descriptionLabel.Text = "There's a man hiding behind a dumpster in the alley. He pops out and takes a swing at you with a baseball bat.";
                    option3Label.Text = "";
                    option2Label.Text = "";
                    option1Label.Text = "Continue";

                    option3Button.Visible = false;
                    option1Button.Visible = true;
                    option2Button.Visible = false;
                    imageBox.BackgroundImage = Properties.Resources.alley;
                    break;
                case 10:
                    descriptionLabel.Text = "You barely make it out alive but manage to run back the way you came from and into the haunted house.";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    option3Label.Text = "Continue";
                    option3Button.Visible = true;
                    option2Button.Visible = false; 
                    option1Button.Visible = false;
                    imageBox.BackgroundImage = Properties.Resources.haunted_house;
                    break;
                case 11:
                    descriptionLabel.Text = "You try to enter the haunted house but the door is locked. You decide to leave and go back to your house.";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    option3Label.Text = "Continue";
                    option3Button.Visible = true;
                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    imageBox.BackgroundImage = Properties.Resources.haunted_house;
                    SoundPlayer Crows = new SoundPlayer(Properties.Resources.Crows);
                    break;
                case 12:
                    descriptionLabel.Text = "When you come home you find the front door broken into and your mom and dad injured on the kitchen floor.";
                    option3Label.Text = "Continue";
                    option3Button.Visible = true;
                    imageBox.BackgroundImage = Properties.Resources.broken_house;
                    break;
                case 13:
                    descriptionLabel.Text = "You can decide to leave them there to die, or put them in the car and take them to the hospital.";
                    option1Label.Text = "Take Them";
                    option2Label.Text = "Leave Them";
                    option3Label.Text = "";

                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option3Button.Visible = false;
                    imageBox.BackgroundImage = Properties.Resources.hospital;
                    break;
                case 14:
                    descriptionLabel.Text = "10 years later, you run out of money while going to college and are forced to play guitar on the streets for money.";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    option3Label.Text = "Continue";

                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    option3Button.Visible = true;
                    imageBox.BackgroundImage = Properties.Resources.guitar;
                    break;
                case 15:
                    descriptionLabel.Text = "You begin to gain popularity of a couple of years playing. RBMG records discovers and online video of you playing and shows interest in you.";
                    option1Label.Text = "Sign With Them";
                    option2Label.Text = "";
                    option3Label.Text = "";

                    option1Button.Visible = true;
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    imageBox.BackgroundImage = Properties.Resources.RBMG;
                    break;
                case 16:
                    descriptionLabel.Text = "You and RBMG release your debut album.";
                    option1Label.Text = "Continue";
                    option2Label.Text = "";
                    option3Label.Text = "";

                    option1Button.Visible = true;
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    imageBox.BackgroundImage = Properties.Resources.RBMG;
                    break;
                case 17:
                    descriptionLabel.Text = "You continue your guitar playing on the streets for another 2 years. You finally save enough money to afford your own recording session.";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    option3Label.Text = "Continue";

                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    option3Button.Visible = true;
                    imageBox.BackgroundImage = Properties.Resources.guitar;
                    break;
                case 18:
                    descriptionLabel.Text = "Your song/songs went viral and you earn 1 million dollars and are able to purchase a house in Los Angeles.";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    option3Label.Text = "Continue";

                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    option3Button.Visible = true;
                    imageBox.BackgroundImage = Properties.Resources.nicer_house;
                    break;
                case 19:
                    descriptionLabel.Text = "After finished recording, you decide to publish your song.";
                    option1Label.Text = "Continue";
                    option2Label.Text = "";
                    option3Label.Text = "";

                    option1Button.Visible = true;
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    imageBox.BackgroundImage = Properties.Resources.song_gif;
                    break;
                case 20:
                    descriptionLabel.Text = "With your remaining $50,000 you decide to gamble it all at a casino.";
                    option1Label.Text = "Continue";
                    option2Label.Text = "";
                    option3Label.Text = "";

                    option1Button.Visible = true;
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    imageBox.BackgroundImage = Properties.Resources.casino_gaming;
                    break;
                case 21:
                    descriptionLabel.Text = "You lose all your money and overdose 10 days later.";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    option3Label.Text = "Continue";

                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    option3Button.Visible = true;
                    imageBox.BackgroundImage = Properties.Resources.overdoes;
                    break;
                case 22:
                    descriptionLabel.Text = "You live in luxury for the rest of your life.";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    option3Label.Text = "Continue";

                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    option3Button.Visible = true;
                    imageBox.BackgroundImage = Properties.Resources.moey;
                    break;
                case 23:
                    descriptionLabel.Text = "You live in luxury for the rest of your life, living a wealthy but unhappy life.";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    option3Label.Text = "Continue";

                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    option3Button.Visible = true;
                    imageBox.BackgroundImage = Properties.Resources.moey;
                    break;
                case 24:
                    descriptionLabel.Text = "A week later, your parents have recovered from their injuries.";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    option3Label.Text = "Continue";

                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    option3Button.Visible = true;
                    imageBox.BackgroundImage = Properties.Resources.hospital;
                    break;
                case 25:
                    descriptionLabel.Text = "Your parents disown you and you die.";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    option3Label.Text = "Continue";

                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    option3Button.Visible = true;
                    imageBox.BackgroundImage = Properties.Resources.die;
                    break;
                case 26:
                    descriptionLabel.Text = "You come to a hill and a lake. You can either climb the hill or swim across the lake for safety.";
                    option1Label.Text = "Swim";
                    option2Label.Text = "Climb";
                    option3Label.Text = "";

                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option3Button.Visible = false;
                    imageBox.BackgroundImage = Properties.Resources.hill4;
                    SoundPlayer Bird = new SoundPlayer(Properties.Resources.Bird);
                    break;
                case 27:
                    descriptionLabel.Text = "You fall backwards down the hill and split your head open.";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    option3Label.Text = "Continue";

                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    option3Button.Visible = true;
                    imageBox.BackgroundImage = Properties.Resources.die;
                    break;
                case 28:
                    descriptionLabel.Text = "You don't know how to swim so you drown.";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    option3Label.Text = "Continue";

                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    option3Button.Visible = true;
                    imageBox.BackgroundImage = Properties.Resources.die;
                    break;
                case 29:
                    descriptionLabel.Text = "On your way to school, you walk by your school bully.";
                    option1Label.Text = "Run";
                    option2Label.Text = "Fight";
                    option3Label.Text = "";

                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option3Button.Visible = false;
                    imageBox.BackgroundImage = Properties.Resources.bully;
                    break;
                case 30:
                    descriptionLabel.Text = "The bully quickly demolishes you to a puddle.";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    option3Label.Text = "Continue";

                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    option3Button.Visible = true;
                    imageBox.BackgroundImage = Properties.Resources.die;
                    break;
                case 39:
                    descriptionLabel.Text = "You decide to not go with your dad and run away from home. You keep running until your reach a fork in the road. To the left is a dark alley. To the right is a haunted house.";
                    option1Label.Text = "Right";
                    option2Label.Text = "Left";
                    option3Label.Text = "";

                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option3Button.Visible = false;
                    imageBox.BackgroundImage = Properties.Resources.fork;
                    break;
                case 96:
                    descriptionLabel.Text = "You unfortuntely passed away. Would you like to play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";

                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option3Button.Visible = false;
                    imageBox.BackgroundImage = Properties.Resources.die;
                    break;
                case 97:
                    descriptionLabel.Text = "Would you like to play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";

                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option3Button.Visible = false;
                    imageBox.BackgroundImage = Properties.Resources.play_again;
                    break;
                case 98:
                    descriptionLabel.Text = "Thank you for playing!";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    option3Label.Text = "";

                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    imageBox.BackgroundImage = Properties.Resources.thank_you;
                    Refresh();                   
                    Thread.Sleep(3000);
                    this.Close();
                    break;
                case 99:
                    descriptionLabel.Text = "You live a wealthy and happy rest of your life. Congradulations!";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    option3Label.Text = "";

                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    imageBox.BackgroundImage = Properties.Resources.moey;
                    Refresh();
                    Thread.Sleep(3000);
                    page = 96;
                    break;


            }


        }

        private void option3Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 96;
            }
            else if (page == 3) 
            {
                page = 4;
            }
            else if (page == 5) 
            {
                page = 26;
            }
            else if (page == 7)
            {
                page = 8;
            }
            else if (page == 8)
            {
                page = 99;
            }
            else if (page == 10)
            {
                page = 11;
            }
            else if (page == 17)
            {
                page = 19;
            }
            else if (page == 18)
            {
                page = 20;
            }
            else if (page == 19)
            {
                page = 96;
            }
            else if (page == 22)
            {
                page  = 99;
            }
            else if (page == 24)
            {
                page = 25;
            }
            else if (page == 25)
            {
                page = 96;
            }
            else if (page == 27)
            {
                page = 96;
            }
            else if (page == 28)
            {
                page = 96;
            }
            else if (page == 30)
            {
                page = 96;
            }
            else if(page == 39)
            {
                page = 96;
            }
            else if(page == 11)
            {
                page = 12;
            }
            else if(page == 12)
            {
                page = 13;
            }
            else if(page == 14)
            {
                page = 15;
            }
            DisplayPage();
        }
       
    }
}
