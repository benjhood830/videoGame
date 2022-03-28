using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                int randValue = randGen.Next(1, 101);

                if(randValue < 99)
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
                page = 98;
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
            DisplayPage();
        }
        public void DisplayPage()
        {this.Text = page.ToString();

            switch(page)
            {
                case 1:
                    titleLabel.Text = "";
                    startButton.Visible = false;
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    descriptionLabel.Text = "It's another beautiful morning as the warmth of June seeps through the window.";
                    option1Label.Text = "Keep Sleeping";
                    option2Label.Text = "Wake up";
                    break;
                case 2:
                    descriptionLabel.Text = "It's now 10 am and your mother comes in FURIOUS.";
                    option1Label.Text = "Punch your mother";
                    option2Label.Text = "Run away";
                    break;
                case 3:
                    descriptionLabel.Text = "Your mother retaliates with sucker punching you in the face.";
                    option3Label.Text = "Continue";
                    option2Label.Text = "";
                    option1Label.Text = "";

                    option3Button.Visible = true;
                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    break;
                case 4:
                    descriptionLabel.Text = "Your father grabs you off the floor and wants to brings you to the hospital. ";
                    option1Label.Text = "Go with him";
                    option2Label.Text = "Don't go with him";
                    option3Label.Text = "";

                    option3Button.Visible = false;
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    break;
                case 5:
                    descriptionLabel.Text = "You finally reach an alley to hide in. You see a strange looking man in the alley hiding behind the dumpster. You decide to ignore him and run the other way down the alley.";
                    option3Label.Text = "Continue";
                    option2Label.Text = "";
                    option1Label.Text = "";

                    option3Button.Visible = true;
                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    break;
                case 6:
                    descriptionLabel.Text = "While arguing with you, your father hits a bump in the road and the car slides off the road into the gutter.";
                    option3Label.Text = "";
                    option2Label.Text = "";
                    option1Label.Text = "Continue";

                    option3Button.Visible = false;
                    option1Button.Visible = true;
                    option2Button.Visible = false;
                    break;
                case 7:
                    descriptionLabel.Text = "You leave your father for dead in the car wreck and walk to the hospital.";
                    option3Label.Text = "Continue";
                    option2Label.Text = "";
                    option1Label.Text = "";

                    option3Button.Visible = true;
                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    break;
                case 8:
                    descriptionLabel.Text = "Your mother forgives you and you get the rest of the day off school.";
                    option3Label.Text = "Continue";
                    option2Label.Text = "";
                    option1Label.Text = "";

                    option3Button.Visible = true;
                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    break;
                case 9:
                    descriptionLabel.Text = "There's a man hiding behind a dumpster in the alley. He pops out and takes a swing at you with a baseball bat.";
                    option3Label.Text = "";
                    option2Label.Text = "";
                    option1Label.Text = "Coninue";

                    option3Button.Visible = false;
                    option1Button.Visible = true;
                    option2Button.Visible = false;
                    break;
                case 10:
                    descriptionLabel.Text = "You barely make it out alive but manage to run back the way you came from and into the haunted house.";
                    option3Label.Text = "Continue";
                    option3Button.Visible = true;
                    break;
                case 11:
                    descriptionLabel.Text = "You try to enter the haunted house but the door is locked. You decide to leave and go back to your house.";
                    option3Label.Text = "Continue";
                    option3Button.Visible = true;
                    break;
                case 12:
                    descriptionLabel.Text = "You try to enter the haunted house but the door is locked. You decide to leave and go back to your house.";
                    option3Label.Text = "Continue";
                    option3Button.Visible = true;
                    break;
                case 13:
                    descriptionLabel.Text = "You can decide to leave them there to die, or put them in the car and take them to the hospital.";
                    option1Label.Text = "Take Them";
                    option2Label.Text = "Leave Them";
                    option3Label.Text = "";

                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option3Button.Visible = false;
                    break;
                case 14:
                    descriptionLabel.Text = "10 years later, you run out of money going to college and are forced to play guitar on the streets for money.";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    option3Label.Text = "Continue";

                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    option3Button.Visible = true;
                    break;
                case 15:
                    descriptionLabel.Text = "You begin to gain popularity of a couple of years playing. RBMG records discovers and online video of you playing and shows interest in you.";
                    option1Label.Text = "Sign With Them";
                    option2Label.Text = "";
                    option3Label.Text = "";

                    option1Button.Visible = true;
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 16:
                    descriptionLabel.Text = "You and RBMG release your debut album.";
                    option1Label.Text = "Continue";
                    option2Label.Text = "";
                    option3Label.Text = "";

                    option1Button.Visible = true;
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 17:
                    descriptionLabel.Text = "You continue your guitar playing on the streets for another 2 years. You finally save enough money to afford your own recording session.";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    option3Label.Text = "Continue";

                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    option3Button.Visible = true;
                    break;
                case 18:
                    descriptionLabel.Text = "Your song/songs went viral and you earn 1 million dollars and are able to purchase a house in Los Angeles.";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    option3Label.Text = "Continue";

                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    option3Button.Visible = true;
                    break;
                case 19:
                    descriptionLabel.Text = "After finished recording, you decide to publish your song.";
                    option1Label.Text = "Continue";
                    option2Label.Text = "";
                    option3Label.Text = "";

                    option1Button.Visible = true;
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 20:
                    descriptionLabel.Text = "With your remaining $50,000 you decide to gamble it all at a casino.";
                    option1Label.Text = "Continue";
                    option2Label.Text = "";
                    option3Label.Text = "";

                    option1Button.Visible = true;
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 21:
                    descriptionLabel.Text = "You lose all your money and overdose 10 days later.";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    option3Label.Text = "Continue";

                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    option3Button.Visible = true;
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
            else if (page ==18)
            {
                page = 20;
            }
            else if (page == 19)
            {
                page = 96;
            }
            DisplayPage();
        }
       
    }
}
