using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Choice_Sumamtive
{
    public partial class Form1 : Form
    {
        Random randGen = new Random();
        bool shots;
        string text;
        int scene = 1;
        string red;
        string blue;
     
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //setting the screen up
            buttonRed.Visible = true;
            buttonBlue.Visible = true;
            startButton.Visible = false;
            pictureBox.Visible = true;
            outputLabel.Visible = true;
            this.BackgroundImage = Properties.Resources.free_black_leather_vector;

              //display 
              text = "You are a beginner Wing-suit flyer, and have traveled to the Swiss alps to jump for the first time. However you stop at a bar first, and have a few drinks with your friends. All your friends buy you one drink of your choice for your first jump. Do you have them buy you beers or shots?";
            red = "Beer";
            blue = "Shots";
            pictureBox.BackgroundImage = Properties.Resources.shots;

            outputLabel.Text = text + "";
            buttonRed.Text = red + "";
            buttonBlue.Text = blue + "";
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            //switch scene statement 
            if (scene == 1)
            {
                shots = false;
                scene = 2;
            }
            else if (scene == 2)
            {
                scene = 3;
            }
            else if (scene == 3)
            {
                scene = 4;
            }
            else if (scene == 4)
            {
                scene = 20;
            }
            else if (scene == 20)
            {
                scene = 23;
            }
            else if (scene == 5)
            {
                scene = 7;
            }
            else if (scene == 8)
            {
                scene = 10;
            }
            else if (scene == 10)
            {
                scene = 18;
            }
            else if (scene == 11)
            {
                scene = 14;
            }
            else if (scene == 12)
            {
                scene = 16;
            }
            else if (scene == 6 || scene == 7 || scene == 13 || scene == 14 || scene == 15 || scene == 16 || scene == 17 || scene == 18 || scene == 19 || scene == 21 || scene == 22 || scene == 23 || scene == 24)
            {
                scene = 1;
            }

            //display
            ScreenMessages();
            outputLabel.Text = text + "";
            buttonRed.Text = red + "";
            buttonBlue.Text = blue + "";
        }

        private void buttonBlue_Click(object sender, EventArgs e)
        {
            //declares vairables
            int number70;
            int number60;
            number60 = randGen.Next(1, 10);
            number70 = randGen.Next(1, 10);

            //switch scene statment 
            if (scene == 1)
            {
                shots = true;
                scene = 2;
            }
            else if (scene == 2 || scene == 3)
            {
                if (number70 <= 3)
                {
                    scene = 6;
                }
                else
                {
                    scene = 5;
                }
            }
            else if (scene == 5)
            {
                scene = 8;
            }
            else if (scene == 8)
            {
                if (shots == true)
                {
                    scene = 11;
                }
                else
                {
                    scene = 12;
                }
            }
            else if (scene == 11)
            {
                scene = 13;
            }
            else if (scene == 12)
            {
                scene = 15;
            }
            else if (scene == 4)
            {
                scene = 19;
            }
            else if (scene == 20) {
                if (shots == true)
                {
                    if (number60 <= 4)
                    {
                        scene = 21;
                    }
                    else
                    {
                        scene = 22;
                    }
                }
                else
                {
                    scene = 22;
                }
            }
            else if (scene == 10)
            {
                scene = 17;
            }
            else if (scene == 6 || scene == 7 || scene == 13 || scene == 14 || scene == 15 || scene == 16 || scene == 17 || scene == 18 || scene == 19 || scene == 21 || scene == 22 || scene == 23 || scene == 24)
            {
                scene = 99;
            }
            // display
                ScreenMessages();
            outputLabel.Text = text + "";
            buttonRed.Text = red + "";
            buttonBlue.Text = blue + "";
        }

        public void ScreenMessages()
        {
            //display for each scene 
            switch (scene)
            {
                case 1:
                    text = "You are a beginner Wing-suit flyer, and have traveled to the Swiss alps to jump for the first time. However you stop at a bar first, and have a few drinks with your friends. All your friends buy you one drink of your choice for your first jump. Do you have them buy you beers or shots?";
                    red = "Beer";
                    blue = "Shots";
                    pictureBox.BackgroundImage = Properties.Resources.shots;
                    break;

                case 2:
                    text = "Your friends are all experienced jumpers, and are starting on the intermediate jumps. Do you join them on the intermediate jumps, or start on the beginner jumps?";
                    red = "Beginner Jumps";
                    blue = "Intermediate Jumps";
                    pictureBox.BackgroundImage = Properties.Resources.cliffstanding;
                    break;

                case 3:
                    text = "Your friends all start calling you chicken, and say you either go big or go home. Do you join them on the intermediate jumps?";
                    red = "Beginner Jumps";
                    blue = "Intermediate Jumps";
                    pictureBox.BackgroundImage = Properties.Resources.decide;
                    break;

                case 4:
                    text = "Disappointed you jump on the beginner jumps. You are a bit shaky at first, but are get the hang of it pretty quickly. Landing easily at the end, and stay there jumping all day. You meet up with your friends at the end of them day, and they tell you your friend had a accident. He had a accident on the intermediate jumps. Realizing what happened you debate whether to call the trip off, or to jump on the intermediate jumps yourself to see what he did wrong.";
                    red = "Go to the intemediate jumps";
                    blue = "Go Home";
                    pictureBox.BackgroundImage = Properties.Resources.swissJumping;
                    break;

                case 5:
                    text = "You glide through the air with ease, and a few of your friends start weaving in and out of the trees. Do you join them?";
                    red = "Yes";
                    blue = "No";
                    pictureBox.BackgroundImage = Properties.Resources.tree;
                    break;

                case 6:
                    text = "The jump is too high, and you pick up too much speed. Losing control, and pulling your shoot. You crash into a rock and die.";
                    red = "Play Again";
                    blue = "Quit";
                    pictureBox.BackgroundImage = Properties.Resources.hitsRock;
                    break;

                case 7:
                    text = "You glide your way over, and realize your mistake. You watch you friend lose his balance, and hit a tree. You then lose all concentration and nail a tree yourself?";
                    red = "Play Again";
                    blue = "Quit";
                    pictureBox.BackgroundImage = Properties.Resources.hitsTree;
                    break;

                case 8:
                    text = "You watch in horror as you friend loses balance and glides smack into a tree. You pull your shoot, and land at the nearest opening you find. Seeing a small town at the bottom of the hill. Do you go to help your friend, or call for help?";
                    red = "Go to the town";
                    blue = "Go to your friend";
                    pictureBox.BackgroundImage = Properties.Resources.gimmelwald;
                    break;

                case 10:
                    text = "You strip all your gear off and, run down the mountain to the nearest town house. You barge inside, and start to explain whats wrong. When they respond in German. Do you stay and try to explain, or find a new place that speaks english?";
                    red = "Stay and try to explain";
                    blue = "Find a different place";
                    pictureBox.BackgroundImage = Properties.Resources.germanHostel;
                    break;

                case 11:
                    text = "You strip off all your gear, and run up the mountain as fast as you can to find your friend. However, from the night before you have a hangover, and have gotten yourself lost. Do you keep looking, or go down to the town you saw before?";
                    red = "Go back to town";
                    blue = "Keep Looking";
                    pictureBox.BackgroundImage = Properties.Resources.forestTrail;
                    break;

                case 12:
                    text = "You come up on your friend, alive, but with most of his bones broken. Do you have him stay put, or try to bring back to town?";
                    red = "Take him back to town";
                    blue = "Leave him be";
                    pictureBox.BackgroundImage = Properties.Resources.stuckTree;
                    break;

                case 13:
                    text = "After hours of looking you come up on him, but were to late. You go back to town debating if you should even stay for the rest of your trip";
                    red = "Play Again";
                    blue = "Quit";
                    pictureBox.BackgroundImage = Properties.Resources.backTown;
                    break;

                case 14:
                    text = "You run back to towards the town. However, most of the day is gone, and when you ask for help. They say the must wait till morning because they can't see anything in the dark. The next day, they come back with the bad your friend didn't make it.";
                    red = "Play Again";
                    blue = "Quit";
                    pictureBox.BackgroundImage = Properties.Resources.englishHostel;
                    break;

                case 15:
                    text = "You wait around, but help doesn't come fast enough. And you seem him pass away.";
                    red = "Play Again";
                    blue = "Quit";
                    pictureBox.BackgroundImage = Properties.Resources.tookLong;
                    break;

                case 16:
                    text = "You prop him up onto your back, and drag him back to town. Where he somehow makes a full recovery.";
                    red = "Play Again";
                    blue = "Quit";
                    pictureBox.BackgroundImage = Properties.Resources.propBack;
                    break;

                case 17:
                    text = "You go the place next door and they say they must wait till morning because they can't see anything in the dark. The next day, they come back with the bad your friend didn't make it.";
                    red = "Play Again";
                    blue = "Quit";
                    pictureBox.BackgroundImage = Properties.Resources.englishHostel;
                    break;

                case 18:
                    text = "They don't understand you say, and you waste all time you had. Trying to explain to them. You friends find you and gave you the bad news.";
                    red = "Play Again";
                    blue = "Quit";
                    pictureBox.BackgroundImage = Properties.Resources.hanging;
                    break;

                case 19:
                    text = "You, sad for your friend just cut your trip short and go home";
                    red = "Play Again";
                    blue = "Quit";
                    pictureBox.BackgroundImage = Properties.Resources.airport;
                    break;

                case 20:
                    text = "The next day, you decide to see where he might have messed up on the jump. So early in the morning you get ready, and go to the intermediate jumps. There you line yourself up, and jump. Your friends told you a gust of wind took him too low to the ground, and he couldn't avoid some of the rocks. You feel a downward gust of wind come towards you. Do you let the wind take you, or open your arms?";
                    red = "Let the wind take you";
                    blue = "Open your arms";
                    button3.Visible = true;
                    button3.Text = "Pull shoot"; 
                    pictureBox.BackgroundImage = Properties.Resources.openClose;
                    break;

                case 21:
                    text = "From the shots from yesterday, you have a hangover. From the state your in, you move your arms, and the gust hits you. Sending you into the rocks below, dying.";
                    red = "Play Again";
                    blue = "Quit";
                    pictureBox.BackgroundImage = Properties.Resources.hitRocks2;
                    break;

                case 22:
                    text = "You oen your arms, and soar back to safety, and glide to the bottom. At the bottom you ask yourself. Is this sport for me?";
                    red = "Play Again";
                    blue = "Quit";
                    pictureBox.BackgroundImage = Properties.Resources.forMe;
                    break;

                case 23:
                    text = "The wind pushes you downwards towards the rocks, and you realize, now. What your friend did, and his mistake. An die";
                    red = "Play Again";
                    blue = "Quit";
                    pictureBox.BackgroundImage = Properties.Resources.hitRocks2;
                    break;

                case 24:
                    text = "You pull you shoot, but it gets caught it the bag, and you crash into the rocks.";
                    red = "Play Again";
                    blue = "Quit";
                    pictureBox.BackgroundImage = Properties.Resources.shootStuck;
                    break;

                case 99:
                    this.Close();
                    break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                scene = 24;
            // display
            ScreenMessages();
            outputLabel.Text = text + "";
            buttonRed.Text = red + "";
            buttonBlue.Text = blue + "";
            button3.Visible = false;
        }
    }
}
