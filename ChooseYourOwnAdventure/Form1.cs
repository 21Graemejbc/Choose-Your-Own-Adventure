/* Graeme Cook
 * February 24, 2021
 * A game about escaping/repairing a spaceship*/

//Could do specific death messages, but unsure


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

namespace ChooseYourOwnAdventure
{
    public partial class Form1 : Form
    {
        int scene = 0;
        int dead = 97;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.M) //Red button
            {
                if (scene == 0)  
                {
                    Random randGen = new Random();
                    int chance = randGen.Next (1, 11);

                    if (chance <= 1) { scene = 96; }
                    else { scene = dead; }
                }

                else if (scene == 3)  { scene = 5; }
                else if (scene == 4)  { }
                else if (scene == 5)  { scene = dead; }
                else if (scene == 6)  { scene = dead; }
                else if (scene == 7)  { }
                else if (scene == 8)  { scene = dead; }
                else if (scene == 9)  { }
                else if (scene == 10) { }
                else if (scene == 11) { }
                else if (scene == 12) { }
                else if (scene == 13) { scene = 15; }
                else if (scene == 14) 
                {
                    Random randGen = new Random();
                    int chance = randGen.Next(1, 21);

                    if (chance <= 5) { scene = 18; }
                    else { scene = dead; }
                }
                else if (scene == 15) { scene = 23; }
                else if (scene == 16) { }
                else if (scene == 17) { }
                else if (scene == 18) { scene = 23; }
                else if (scene == 19) { scene = 21; }
                else if (scene == 20) { }
                else if (scene == 21) { scene = 29; }
                else if (scene == 22) { }
                else if (scene == 23) { }
                else if (scene == 24) { }
                else if (scene == 25) { }
                else if (scene == 26) { }
                else if (scene == 27) { }
                else if (scene == 28) { }
                else if (scene == 96) { scene = 0; }
                else if (scene == 97) { scene = 0; }
                else if (scene == 98) { scene = 0; }
                else if (scene == 99) { scene = 0; }
            }

            else if (e.KeyCode == Keys.B) //Blue button
            {
                if (scene == 0)       { scene = 3; }
                else if (scene == 3)  { scene = dead; }
                else if (scene == 4)  { }
                else if (scene == 5)  { scene = 6; }
                else if (scene == 6)  { scene = 8; }
                else if (scene == 7)  { }
                else if (scene == 8)  { scene = 13; }
                else if (scene == 9)  { }
                else if (scene == 10) { }
                else if (scene == 11) { }
                else if (scene == 12) { }
                else if (scene == 13) { scene = 14; }
                else if (scene == 14) { scene = 19; }
                else if (scene == 15) { scene = 20; }
                else if (scene == 16) { }
                else if (scene == 17) { }
                else if (scene == 18) { scene = 98; }
                else if (scene == 19) { scene = 23; }
                else if (scene == 20) { }
                else if (scene == 21) { scene = 23; }
                else if (scene == 22) { }
                else if (scene == 23) { }
                else if (scene == 24) { }
                else if (scene == 25) { }
                else if (scene == 26) { }
                else if (scene == 27) { }
                else if (scene == 28) { }
                else if (scene == 96) { Application.Exit(); }
                else if (scene == 97) { Application.Exit(); }
                else if (scene == 98) { Application.Exit(); }
                else if (scene == 99) { Application.Exit(); }
            }

            else if (e.KeyCode == Keys.Space) //Green button
            {
                if (scene == 0)       { }
                else if (scene == 3)  { scene = 6; }
                else if (scene == 4)  { }
                else if (scene == 5)  { }
                else if (scene == 6)  { }
                else if (scene == 7)  { }
                else if (scene == 8)  
                { 
                    scene = 10;

                    Random randGen = new Random();
                    int chance = randGen.Next(1, 11);

                    if (chance <= 4) { scene = 96; }
                    else { scene = dead; }
                }

                else if (scene == 9)  { }
                else if (scene == 10) { }
                else if (scene == 11) { }
                else if (scene == 12) { }
                else if (scene == 13) { }
                else if (scene == 14) { }
                else if (scene == 15) { }
                else if (scene == 16) { }
                else if (scene == 17) { }
                else if (scene == 18) { }
                else if (scene == 19) { }
                else if (scene == 20) { }
                else if (scene == 21) { }
                else if (scene == 22) { }
                else if (scene == 23) { }
                else if (scene == 24) { }
                else if (scene == 25) { }
                else if (scene == 26) { }
                else if (scene == 27) { }
                else if (scene == 28) { }
                else if (scene == 96) { }
                else if (scene == 97) { }
                else if (scene == 98) { }
                else if (scene == 99) { }
            }

            switch (scene)
            {
                case 0:
                    storyOutput.Text = "You wake up with a concussion, it seems you were knocked out during the evacuations and are the last one remaining onboard the Screaming Firehawk";
                    promptOutput.Text = "Do you want to attempt to leave the station in a shuttle? Or, try to conduct repairs?";

                    redOutput.Text = "Escape";
                    blueOutput.Text = "Repair";
                    greenOutput.Text = "";
                    break;

                case 3:
                    storyOutput.Text = "You come to a crossroads in engineering; the PA blares about a reactor issue, but the air is staring to feel thin as well...";
                    promptOutput.Text = "Will you go to reactor control, life support, or the power relay station first?";

                    redOutput.Text = "Life Support";
                    blueOutput.Text = "Power";
                    greenOutput.Text = "Reactor Control";
                    break;

                case 4:
                    //Output text
                    //Option texts
                    break;

                case 5:
                    storyOutput.Text = "You arrive at the life support station. The interfaces are dark. The ongoing power issues must be affecting the core systems.";
                    promptOutput.Text = "Move on to reactor control or the power relay?";

                    redOutput.Text = "Power";
                    blueOutput.Text = "Reactor Control";
                    greenOutput.Text = "";
                    break;

                case 6:
                    storyOutput.Text = "In reactor control, the panels are flashing erratically. What about? You don't know. One screen flashes 'core dump required' and a big red button prompts you.";
                    promptOutput.Text = "Do you want to push the button?";

                    redOutput.Text = "No";
                    blueOutput.Text = "Yes";
                    greenOutput.Text = "";
                    break;

                case 7:
                    //Output text
                    //Option texts
                    break;

                case 8:
                    storyOutput.Text = "There's a blast of bright light as a ball of super-heated plasma is ejected out behind the station; it seems you made a good choice coming here first. As you catch your breathe you realize the air is getting thinner...";
                    promptOutput.Text = "Next, do you want to try to repair the life support systems, repair the power, or double back to the shuttle?";

                    redOutput.Text = "Power";
                    blueOutput.Text = "Life Support";
                    greenOutput.Text = "Go back to the shuttle";
                    break;

                case 9:
                    //Output text
                    //Option texts
                    break;

                case 10:
                    storyOutput.Text = "On your way back to the shuttle, you pass the fuel depot and grab some fuel for the shuttle... that should help.";
                    promptOutput.Text = "";

                    redOutput.Text = "";
                    blueOutput.Text = "";
                    greenOutput.Text = "";

                    break;

                case 11:
                    //Output text
                    //Option texts
                    break;
                case 12:
                    //Output text
                    //Option texts
                    break;

                case 13:
                    storyOutput.Text = "In life support, you notice a circuit overload caused the air recyclers to shut down, a manual reset fixes things.";
                    promptOutput.Text = "Do you head to power, to hopefully complete the repairs or do you begin to investigate what happened to the ship?";

                    redOutput.Text = "Investigate";
                    blueOutput.Text = "Go to power";
                    greenOutput.Text = "";
                    break;

                case 14:
                    storyOutput.Text = "The power grid seems to have managed to automatically stabilized. Before you turn to leave, you notice a blinking light in the corner.";
                    promptOutput.Text = "Investigate the light or move on?";

                    redOutput.Text = "Investigate";
                    blueOutput.Text = "Move on"; 
                    greenOutput.Text = "";
                    break;

                case 15:
                    storyOutput.Text = "The emergency clearly stemmed from the ship's reactor. You could dig around engineering or the flight deck for clues...";
                    promptOutput.Text = "Head back to engineering or go up to the flight deck?";

                    redOutput.Text = "Go to the flight deck";
                    blueOutput.Text = "Back to engineering";
                    greenOutput.Text = "";
                    break;

                case 16:
                    //Output text
                    //Option texts
                    break;
                case 17:
                    //Output text
                    //Option texts
                    break;

                case 18:
                    storyOutput.Text = "As you close in, you're able to make out some text: 'MK III Proximity Detonated High Explosive'. A bomb!? This whole thing was a setup. Maybe the proximity sensor on this unit is broken?";
                    promptOutput.Text = "Do you want to rig the bomb to destroy the ship and escape on the shuttle, or leave it and hunt for the saboteur?";

                    redOutput.Text = "Hunt him down";
                    blueOutput.Text = "Sabotage & leave";
                    greenOutput.Text = "";
                    break;

                case 19:
                    storyOutput.Text = "You make your way back to the reactor. After digging around the central computer, you realize that something is wrong with the interior of the reactor that'll need to be mended for long-term stability.";
                    promptOutput.Text = "Do you head into the reactor? Or do you investigate the flight deck?";

                    redOutput.Text = "Enter the reactor";
                    blueOutput.Text = "Go to the flight deck";
                    greenOutput.Text = "";
                    break;

                case 20:
                    //Output text
                    //Option texts
                    break;

                case 21:
                    storyOutput.Text = "You put on a radiation suit and enter the reactor, some of the power had been manually disconnected from the mass ejection mechanisms...";
                    promptOutput.Text = "Do you want to reconnect the mechanisms?";

                    redOutput.Text = "Yes";
                    blueOutput.Text = "No";
                    greenOutput.Text = "";
                    break;

                case 22:
                    
                    break;

                case 23:
                    //Output text
                    //Option texts
                    break;
                case 24:
                    //Output text
                    //Option texts
                    break;
                case 25:
                    //Output text
                    //Option texts
                    break;
                case 26:
                    //Output text
                    //Option texts
                    break;
                case 27:
                    //Output text
                    //Option texts
                    break;
                case 28:
                    //Output text
                    //Option texts
                    break;

                case 96:
                    storyOutput.Text = "You made it out on the shuttle! Congratulations on escaping the Screaming Firehawk!";
                    promptOutput.Text = "Would you like to play again?";

                    redOutput.Text = "Yes";
                    blueOutput.Text = "No";
                    greenOutput.Text = "";
                    break;

                case 97:
                    storyOutput.Text = "You're now just another number in the death toll of the Screaming Firehawk Incident.";
                    promptOutput.Text = "Would you like to play again?";

                    redOutput.Text = "Yes";
                    blueOutput.Text = "No";
                    greenOutput.Text = "";
                    break;

                case 98:
                    storyOutput.Text = "Congratulations! You found the secret ending and turned the saboteur's plan against him!";
                    promptOutput.Text = "Would you like to play again?";

                    redOutput.Text = "Yes";
                    blueOutput.Text = "No";
                    greenOutput.Text = "";
                    break;

                case 99:
                    storyOutput.Text = "Congratulations! You completed the main story and retook the ship, try discovering the secret ending!";
                    promptOutput.Text = "Would you like to play again?";

                    redOutput.Text = "Yes";
                    blueOutput.Text = "No";
                    greenOutput.Text = "";
                    break;
            }
        }
    }
}
