/* Graeme Cook
 * February 24, 2021
 * A game about escaping/repairing a spaceship*/

//Pathing should be done, unless mistakes were made.
//To do: Media, GUI optimization, make green dissapear when its not an option


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
                    int chance = randGen.Next(1, 11);

                    if (chance <= 1) { scene = 96; }
                    else { scene = 1; }
                }

                else if (scene == 1) { scene = 97; }
                else if (scene == 3) { scene = 5; }
                else if (scene == 4) { scene = dead; }
                else if (scene == 5) { scene = dead; }
                else if (scene == 6) { scene = 7; }
                else if (scene == 7) { scene = dead; }
                else if (scene == 8) { scene = 9; }
                else if (scene == 9) { scene = dead; }
                else if (scene == 10) { scene = 12; }
                else if (scene == 11) { }
                else if (scene == 12) { scene = dead; }
                else if (scene == 13) { scene = 15; }
                else if (scene == 14)
                {
                    Random randGen = new Random();
                    int chance = randGen.Next(1, 21);
                    if (chance <= 5) { scene = 18; }

                    else { scene = 16; }
                }
                else if (scene == 15) { scene = 23; }
                else if (scene == 16) { scene = dead; }
                else if (scene == 17) { scene = 98; }
                else if (scene == 18) { scene = 23; }
                else if (scene == 19) { scene = 21; }
                else if (scene == 20) { scene = 19; }
                else if (scene == 21) { scene = 29; }
                else if (scene == 22) { }
                else if (scene == 23) { scene = 24; }
                else if (scene == 24) { scene = dead; }
                else if (scene == 25)
                {
                    Random randGen = new Random();
                    int chance = randGen.Next(1, 11);

                    if (chance <= 2) { scene = 27; }
                    else { scene = 28; }
                }
                else if (scene == 26) { scene = 99; }
                else if (scene == 27) { scene = 99; }
                else if (scene == 28) { scene = dead; }
                else if (scene == 29) { scene = 23; }
                else if (scene == 96) { scene = 0; }
                else if (scene == 97) { scene = 0; }
                else if (scene == 98) { scene = 0; }
                else if (scene == 99) { scene = 0; }
            }

            else if (e.KeyCode == Keys.B) //Blue button
            {
                if (scene == 0) { scene = 3; }
                else if (scene == 3) { scene = 4; }
                else if (scene == 5) { scene = 6; }
                else if (scene == 6) { scene = 8; }
                else if (scene == 8) { scene = 13; }
                else if (scene == 13) { scene = 14; }
                else if (scene == 14) { scene = 19; }
                else if (scene == 15) { scene = 20; }
                else if (scene == 18) { scene = 17; }
                else if (scene == 19) { scene = 23; }
                else if (scene == 20) { scene = 14; }
                else if (scene == 21) { scene = 23; }
                else if (scene == 23) { scene = 25; }
                else if (scene == 25) { scene = 26; }
                else if (scene == 29) { scene = 96; }
                else if (scene == 96) { Application.Exit(); }
                else if (scene == 97) { Application.Exit(); }
                else if (scene == 98) { Application.Exit(); }
                else if (scene == 99) { Application.Exit(); }
            } 

            else if (e.KeyCode == Keys.Space) //Green button
            {
                if (scene == 3) { scene = 6; }
                else if (scene == 8)
                {
                    scene = 10;

                    Random randGen = new Random();
                    int chance = randGen.Next(1, 11);

                    if (chance <= 4) { scene = 96; }
                    else { scene = 12; }
                }
            }

            switch (scene)
            {
                case 0:
                    greenButton.Visible = false;
                    blueButton.Visible = true;

                    storyOutput.Text = "You wake up with a concussion, it seems you were knocked out during the evacuations and are the last one remaining onboard the Screaming Firehawk.";
                    promptOutput.Text = "Do you want to attempt to leave the ship in the shuttle or stay and try to conduct repairs?";

                    redOutput.Text = "Escape (risky)";
                    blueOutput.Text = "Repair";
                    greenOutput.Text = "";

                    mainImage.Image = Properties.Resources.S0;

                    SoundPlayer player1 = new SoundPlayer(Properties.Resources.sound0);
                    player1.Play();

                    break;

                case 1:
                    greenButton.Visible = false;
                    blueButton.Visible = false;

                    storyOutput.Text = "You leave the ship only to realize the fuel tanks have been drained. The engine sputters out and you're left adrift.";
                    promptOutput.Text = "Press red to continue.";

                    redOutput.Text = "Next";
                    blueOutput.Text = "";
                    greenOutput.Text = "";

                    mainImage.Image = Properties.Resources.S1_12;

                    //SoundPlayer player2 = new SoundPlayer(Properties.Resources.sound1_12);
                    //player2.Play();

                    break;

                case 3:
                    greenButton.Visible = true;
                    blueButton.Visible = true;

                    storyOutput.Text = "You come to a crossroads in engineering; the PA blares on about a reactor issue, but the air is starting to feel thin...";
                    promptOutput.Text = "Will you go to reactor control, life support, or the power relay station first?";

                    redOutput.Text = "Life Support";
                    blueOutput.Text = "Power";
                    greenOutput.Text = "Reactor Control";

                    mainImage.Image = Properties.Resources.S3_15_19_20;

                    SoundPlayer player3 = new SoundPlayer(Properties.Resources.sound3);
                    player3.Play();

                    break;

                case 4:
                    greenButton.Visible = false;
                    blueButton.Visible = false;

                    storyOutput.Text = "The ongoing reactor issues have caused arcing electricity in the power conduits; you die in the power relay.";
                    promptOutput.Text = "Press red to continue.";

                    redOutput.Text = "Next";
                    blueOutput.Text = "";
                    greenOutput.Text = "";

                    mainImage.Image = Properties.Resources.S4;

                    SoundPlayer player4 = new SoundPlayer(Properties.Resources.sound4);
                    player4.Play();


                    break;

                case 5:
                    greenButton.Visible = false;
                    blueButton.Visible = true;

                    storyOutput.Text = "You arrive at the life support station and the interfaces are all dark. The ongoing power issues must be affecting the core systems...";
                    promptOutput.Text = "Move on to reactor control or the power relay?";

                    redOutput.Text = "Power";
                    blueOutput.Text = "Reactor Control";
                    greenOutput.Text = "";

                    mainImage.Image = Properties.Resources.S5;

                    break;

                case 6:
                    greenButton.Visible = false;
                    blueButton.Visible = true;

                    storyOutput.Text = "In reactor control, the panels are flashing erratically. What about? You don't know. One screen flashes 'core dump required' and a big red button prompts you.";
                    promptOutput.Text = "Do you want to push the button?";

                    redOutput.Text = "No";
                    blueOutput.Text = "Yes";
                    greenOutput.Text = "";

                    mainImage.Image = Properties.Resources.S6;

                    SoundPlayer player5 = new SoundPlayer(Properties.Resources.sound6);
                    player5.Play();

                    break;

                case 7:
                    greenButton.Visible = false;
                    blueButton.Visible = false;

                    storyOutput.Text = "Having left reactor control, you move on to life support. Before you can make it, the reactor goes critical and the ship is reduced to atoms: you are dead.";
                    promptOutput.Text = "Press red to continue.";

                    redOutput.Text = "Next";
                    blueOutput.Text = "";
                    greenOutput.Text = "";

                    mainImage.Image = Properties.Resources.S7;

                    //SoundPlayer player6 = new SoundPlayer(Properties.Resources.sound7_16);
                    //player6.Play();

                    break;

                case 8:
                    greenButton.Visible = true;
                    blueButton.Visible = true;

                    storyOutput.Text = "There's a blast of bright light as a ball of super-heated plasma is ejected out behind the ship; it seems you made a good choice coming here first. As you catch your breath you realize the air is getting thinner...";
                    promptOutput.Text = "Do you want to try to repair the life support systems, repair the power, or double back to the shuttle?";

                    redOutput.Text = "Power";
                    blueOutput.Text = "Life Support";
                    greenOutput.Text = "Go back to the shuttle (risky)";

                    mainImage.Image = Properties.Resources.S8;

                    break;

                case 9:
                    greenButton.Visible = false;
                    blueButton.Visible = false;

                    storyOutput.Text = "In power, you notice a faint blinking light in the corner. As you draw nearer, the air finally runs out and you suffocate.";
                    promptOutput.Text = "Press red to continue.";

                    redOutput.Text = "Next";
                    blueOutput.Text = "";
                    greenOutput.Text = "";

                    mainImage.Image = Properties.Resources.S9;

                    SoundPlayer player7 = new SoundPlayer(Properties.Resources.sound9);
                    player7.Play();

                    break;

                case 10:
                    greenButton.Visible = false;
                    blueButton.Visible = false;

                    storyOutput.Text = "On your way back to the shuttle, you pass the fuel depot and grab some fuel for the shuttle... that should help.";
                    promptOutput.Text = "Press red to continue.";

                    redOutput.Text = "Next";
                    blueOutput.Text = "";
                    greenOutput.Text = "";

                    mainImage.Image = Properties.Resources.S10;

                    //SoundPlayer player8 = new SoundPlayer(Properties.Resources.sound10);
                    //player8.Play();

                    break;

                case 12:
                    greenButton.Visible = false;
                    blueButton.Visible = false;

                    storyOutput.Text = "All seems well until the fuel you grabbed attempts to inject into the core... in your hypoxia you grabbed an empty fuel canister. You are left adrift.";
                    promptOutput.Text = "Press red to continue.";

                    redOutput.Text = "Next";
                    blueOutput.Text = "";
                    greenOutput.Text = "";

                    mainImage.Image = Properties.Resources.S1_12;

                    //SoundPlayer player9 = new SoundPlayer(Properties.Resources.sound1_12);
                    //player9.Play();

                    break;

                case 13:
                    greenButton.Visible = false;
                    blueButton.Visible = true;

                    storyOutput.Text = "In life support, you notice a circuit overload caused the air recyclers to shut down. A manual reset fixes things.";
                    promptOutput.Text = "Do you head to power, to hopefully complete the repairs, or do you begin to investigate what happened to the ship?";

                    redOutput.Text = "Investigate";
                    blueOutput.Text = "Go to power";
                    greenOutput.Text = "";

                    mainImage.Image = Properties.Resources.S13;

                    //SoundPlayer player10 = new SoundPlayer(Properties.Resources.sound13);
                    //player10.Play();

                    break;

                case 14:
                    greenButton.Visible = false;
                    blueButton.Visible = true;

                    storyOutput.Text = "The power grid seems to have automatically stabilized. Before you turn to leave, you notice a blinking light in the corner.";
                    promptOutput.Text = "Investigate the light or move on?";

                    redOutput.Text = "Investigate (risky)";
                    blueOutput.Text = "Move on";
                    greenOutput.Text = "";

                    mainImage.Image = Properties.Resources.S14;

                    break;

                case 15:
                    greenButton.Visible = false;
                    blueButton.Visible = true;

                    storyOutput.Text = "The emergency clearly stemmed from the ship's reactor. You could dig around engineering or the flight deck for clues...";
                    promptOutput.Text = "Head back to engineering or go up to the flight deck?";

                    redOutput.Text = "Flight deck";
                    blueOutput.Text = "Engineering";
                    greenOutput.Text = "";

                    mainImage.Image = Properties.Resources.S3_15_19_20;

                    break;

                case 16:
                    greenButton.Visible = false;
                    blueButton.Visible = false;

                    storyOutput.Text = "Before you can close the distance to even read the text on the blinking box, you are enveloped in an explosion. You are dead.";
                    promptOutput.Text = "Press red to continue.";

                    redOutput.Text = "Next";
                    blueOutput.Text = "";
                    greenOutput.Text = "";

                    mainImage.Image = Properties.Resources.S16;

                    //SoundPlayer player11 = new SoundPlayer(Properties.Resources.sound7_16);
                    //player11.Play();

                    break;

                case 17:
                    greenButton.Visible = false;
                    blueButton.Visible = false;

                    storyOutput.Text = "You manage to rig the bomb on a timer. With life support back on, you fill some oxygen tanks, then stop by the fuel depot, and take the shuttle. As you fly away, you see the explosion of the ship behind you.";
                    promptOutput.Text = "Press red to continue.";

                    redOutput.Text = "Next";
                    blueOutput.Text = "";
                    greenOutput.Text = "";

                    mainImage.Image = Properties.Resources.S17;

                    //SoundPlayer player12 = new SoundPlayer(Properties.Resources.sound17);
                    //player12.Play();

                    break;

                case 18:
                    greenButton.Visible = false;
                    blueButton.Visible = true;

                    storyOutput.Text = "As you close in, you're able to make out some text: 'MK III Proximity Detonated High Explosive'. A bomb!? This whole thing was a setup. Maybe the proximity sensor on this unit is broken?";
                    promptOutput.Text = "Do you want to rig the bomb to destroy the ship and escape on the shuttle, or leave it and hunt down the saboteur?";

                    redOutput.Text = "Hunt him down";
                    blueOutput.Text = "Sabotage and leave";
                    greenOutput.Text = "";

                    mainImage.Image = Properties.Resources.S18;

                    //SoundPlayer player13 = new SoundPlayer(Properties.Resources.sound18);
                    //player13.Play();

                    break;

                case 19:
                    greenButton.Visible = false;
                    blueButton.Visible = true;

                    storyOutput.Text = "You make your way out of the power room. The ship computer is talking about something wrong in the interior of the reactor that'll need to be mended for long term stability. At the same time, you want to know what happened to the ship.";
                    promptOutput.Text = "Do you head into the reactor or investigate the flight deck?";

                    redOutput.Text = "Enter the reactor";
                    blueOutput.Text = "Go to the flight deck";
                    greenOutput.Text = "";

                    mainImage.Image = Properties.Resources.S3_15_19_20;

                    SoundPlayer player14 = new SoundPlayer(Properties.Resources.sound19);
                    player14.Play();

                    break;

                case 20:
                    greenButton.Visible = false;
                    blueButton.Visible = true;

                    storyOutput.Text = "You wonder if you should head to the power relay, where you haven't gone yet, or back to the reactor.";
                    promptOutput.Text = "Reactor or power relay?";

                    redOutput.Text = "Reactor";
                    blueOutput.Text = "Power relay";
                    greenOutput.Text = "";

                    mainImage.Image = Properties.Resources.S3_15_19_20;

                    break;

                case 21:
                    blueButton.Visible = true;
                    greenButton.Visible = false;

                    storyOutput.Text = "You put on a radiation suit and enter the reactor. The power lines had been manually disconnected from the mass ejection mechanisms...";
                    promptOutput.Text = "Do you want to reconnect the mechanisms?";

                    redOutput.Text = "Yes";
                    blueOutput.Text = "No";
                    greenOutput.Text = "";

                    mainImage.Image = Properties.Resources.S21_29;

                    //SoundPlayer player15 = new SoundPlayer(Properties.Resources.sound21);
                    //player15.Play();

                    break;

                case 23:
                    greenButton.Visible = false;
                    blueButton.Visible = true;

                    storyOutput.Text = "The door of the lift opens on the flight deck. A dead security officer lies on the ground... he's been shot!";
                    promptOutput.Text = "Do you take their gun?";

                    redOutput.Text = "No, I don't want anyone to get hurt.";
                    blueOutput.Text = "Yes";
                    greenOutput.Text = "";

                    mainImage.Image = Properties.Resources.S23;

                    SoundPlayer player16 = new SoundPlayer(Properties.Resources.sound23);
                    player16.Play();

                    break;

                case 24:
                    greenButton.Visible = false;
                    blueButton.Visible = false;

                    storyOutput.Text = "You take a deep breathe and open the door to the Command Information Center. Standing at the main terminal is someone you don't recognize. Seeing you're unarmed, he shoots you. 'Guess I didn't get them all' is the last thing you hear.";
                    promptOutput.Text = "Press red to continue.";

                    redOutput.Text = "Next";
                    blueOutput.Text = "";
                    greenOutput.Text = "";

                    mainImage.Image = Properties.Resources.S24_28;

                    //SoundPlayer player17 = new SoundPlayer(Properties.Resources.sound24_26_28);
                    //player17.Play();

                    break;

                case 25:
                    greenButton.Visible = false;
                    blueButton.Visible = true;

                    storyOutput.Text = "You grab the gun. You take a deep breathe and open the door to the Command Information Center. Standing at the main terminal is someone you don't recognize.";
                    promptOutput.Text = "Kill or confront them?";

                    redOutput.Text = "Confront (risky)";
                    blueOutput.Text = "Kill";
                    greenOutput.Text = "";

                    mainImage.Image = Properties.Resources.S24_28;

                    break;

                case 26:
                    greenButton.Visible = false;
                    blueButton.Visible = false;

                    storyOutput.Text = "Before they can react, you fire twice at the saboteur, killing him. Congratulations, you've saved the ship!";
                    promptOutput.Text = "Press red to continue.";

                    redOutput.Text = "Next";
                    blueOutput.Text = "";
                    greenOutput.Text = "";

                    mainImage.Image = Properties.Resources.S24_28;

                    //SoundPlayer player18 = new SoundPlayer(Properties.Resources.sound24_26_28);
                    //player18.Play();

                    break;

                case 27:
                    greenButton.Visible = false;
                    blueButton.Visible = false;

                    storyOutput.Text = "You call out to the saboteur to surrender. Seeing you: gun drawn, they puts down their weapon and raise their hands. Congratulations, you've saved the ship honourably!";
                    promptOutput.Text = "Press red to continue.";

                    redOutput.Text = "Next";
                    blueOutput.Text = "";
                    greenOutput.Text = "";

                    mainImage.Image = Properties.Resources.S24_28;

                    break;

                case 28:
                    greenButton.Visible = false;
                    blueButton.Visible = false;

                    storyOutput.Text = "As you call out to the saboteur, they draw their weapon. You manage to hit them once, but it's not enough, they fire back and kill you.";
                    promptOutput.Text = "Press red to continue.";

                    redOutput.Text = "Next";
                    blueOutput.Text = "";
                    greenOutput.Text = "";

                    mainImage.Image = Properties.Resources.S24_28;

                    //SoundPlayer player19 = new SoundPlayer(Properties.Resources.sound24_26_28);
                    //player19.Play();

                    break;

                case 29:
                    greenButton.Visible = false;
                    blueButton.Visible = true;

                    storyOutput.Text = "You reconnect the reactor mechanisms. As full power is restored to the ship, the tertiary systems come online. If you remember correctly, power is now running to the shuttle; filling the backups.. you wonder what would have happened had you tried to take it earlier...";
                    promptOutput.Text = "Take the shuttle or investigate the flight deck?";

                    redOutput.Text = "Flight deck";
                    blueOutput.Text = "Shuttle";
                    greenOutput.Text = "";

                    mainImage.Image = Properties.Resources.S21_29;

                    //SoundPlayer player20 = new SoundPlayer(Properties.Resources.sound29);
                    //player20.Play();

                    break;

                case 96:
                    greenButton.Visible = false;
                    blueButton.Visible = true;

                    storyOutput.Text = "You made it out on the shuttle! Congratulations on escaping the Screaming Firehawk!";
                    promptOutput.Text = "Would you like to play again?";

                    redOutput.Text = "Yes";
                    blueOutput.Text = "No";
                    greenOutput.Text = "";

                    mainImage.Image = Properties.Resources.win;
                    break;

                case 97:
                    greenButton.Visible = false;
                    blueButton.Visible = true;

                    storyOutput.Text = "You're now just another number in the death toll of the Screaming Firehawk Incident.";
                    promptOutput.Text = "Would you like to play again?";

                    redOutput.Text = "Yes";
                    blueOutput.Text = "No";
                    greenOutput.Text = "";

                    mainImage.Image = Properties.Resources.dead;
                    break;

                case 98:
                    greenButton.Visible = false;
                    blueButton.Visible = true;

                    storyOutput.Text = "Congratulations! You found the secret ending and turned the saboteur's plan against him!";
                    promptOutput.Text = "Would you like to play again?";

                    redOutput.Text = "Yes";
                    blueOutput.Text = "No";
                    greenOutput.Text = "";

                    mainImage.Image = Properties.Resources.win;
                    break;

                case 99:
                    greenButton.Visible = false;
                    blueButton.Visible = true;

                    storyOutput.Text = "Congratulations! You completed the main story and retook the ship, try discovering the secret ending!";
                    promptOutput.Text = "Would you like to play again?";

                    redOutput.Text = "Yes";
                    blueOutput.Text = "No"; 
                    greenOutput.Text = "";

                    mainImage.Image = Properties.Resources.win;
                    break;
            }
        }
    }
}
