using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Collections;

namespace Oro2
{
    public partial class Form1 : Form
    {
        public bool bedroom_start = false;
        public bool up_hallway = false;
        public bool dresser = false;
        public bool downstairs = false;
        public bool den = false;
        public bool frontdoor = false;
        public bool sidedoor = false;
        public bool barn = false;
        public bool road = false;
        public bool bedroom_return = false;
        public bool bedroom_back = false;
        public bool basement = false;
        public bool sleep = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            story.Text = "Press 'enter' to start the game";
            world.Image = Image.FromFile("world/title.jpg");
            bedroom_start = true;
            SoundPlayer intro = new SoundPlayer("music/Back_to_Where_Ive_Gone_2.wav");
            intro.PlayLooping();
        }
        private void input_TextChanged(object sender, EventArgs e)
        {
        }
        private void input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click_1((object)sender, (EventArgs)e);
            }
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            //------------------------------------------------------------------------------------------
            if (bedroom_start == true)
            {
                world.Image = Image.FromFile("world/wakeup.jpg");
                story.Text = "I am reluctant to open my eyes, and let the sunlight in." + Environment.NewLine + Environment.NewLine + "Though it was dreamless, I had slept fitfully." + Environment.NewLine + Environment.NewLine + "Finally, when I can't will myself back to sleep, I look towards the ceiling first, and room second." + Environment.NewLine + Environment.NewLine + "It is thinly decorated. Besides the dresser on the wall opposite to the bed, a drawer ajar, there is not much to the room." + Environment.NewLine + Environment.NewLine + "I know something is off, yet it is just as familiar as it is foreign. It's not easily described, and in my drowsy state, I'm at a loss for words." + Environment.NewLine + Environment.NewLine + "This encourages me to pull myself from the covers, so that I can get a better look at my surroundings.";
                story.Text += Environment.NewLine + Environment.NewLine + "this is a test";
                if (input.Text == "go to sleep" || input.Text == "go to bed" || input.Text == "sleep")
                {
                    sleep = true;
                    bedroom_start = false;
                    up_hallway = false;
                    dresser = false;
                    downstairs = false;
                    den = false;
                    frontdoor = false;
                    sidedoor = false;
                    barn = false;
                    road = false;
                    bedroom_return = false;
                    bedroom_back = false;
                    basement = false;
                    story.Anchor = AnchorStyles.None;
                    story.Location = new Point(world.Location.X, world.Location.Y + 430);
                    story.Size = new Size(860, 130);
                    button1_Click_1((object)sender, (EventArgs)e);
                }
                if (input.Text == "open dresser" || input.Text == "go to dresser" || input.Text == "examine dresser"
                    || input.Text == "e dresser" || input.Text == "walk to dresser" || input.Text == "go dresser")
                {
                    dresser = true;
                    bedroom_start = false;
                    up_hallway = false;
                    downstairs = false;
                    den = false;
                    frontdoor = false;
                    sidedoor = false;
                    barn = false;
                    road = false;
                    bedroom_return = false;
                    bedroom_back = false;
                    basement = false;
                    sleep = false;
                    story.Anchor = AnchorStyles.None;
                    story.Location = new Point(world.Location.X, world.Location.Y + 430);
                    story.Size = new Size(860, 130);
                    button1_Click_1((object)sender, (EventArgs)e);
                }
                if (input.Text == "go to hallway" || input.Text == "go hallway" || input.Text == "enter hallway" 
                    || input.Text == "leave room" || input.Text == "exit" || input.Text == "forward"
                    || input.Text == "f")
                {
                    up_hallway = true;
                    bedroom_start = false;
                    dresser = false;
                    downstairs = false;
                    den = false;
                    frontdoor = false;
                    sidedoor = false;
                    barn = false;
                    road = false;
                    bedroom_return = false;
                    bedroom_back = false;
                    basement = false;
                    sleep = false;
                    story.Anchor = AnchorStyles.None;
                    story.Location = new Point(world.Location.X, world.Location.Y + 430);
                    story.Size = new Size(860, 130);
                    button1_Click_1((object)sender, (EventArgs)e);
                }
                input.Clear();
            }
            //------------------------------------------------------------------------------------------
            if (dresser == true)
            {
                world.Image = Image.FromFile("world/dresser.jpg");
                story.Text = "I go to the dresser, and carefully pull the drawer the rest of the way open." + Environment.NewLine + Environment.NewLine + "Inside, it is filled with letters, and papers. I lift out the one that catches my eye first. It is addressed to me, and it is from my mother." + Environment.NewLine + Environment.NewLine + "As I read it, I become more aware of my surroundings. It's short, wishing me well, and apologizing for my loss." + Environment.NewLine + Environment.NewLine + "Loss?" + Environment.NewLine + Environment.NewLine + "I swallow thickly, and replace the paper, feeling numb. The surroundings are unfamiliar, yet this letter is mine. I leaf through the papers below it, and find the same. It's hard to convince myself this is a coincidence.";
                if (input.Text == "close dresser" || input.Text == "exit dresser" || input.Text == "leave dresser"
                    || input.Text == "leave" || input.Text == "exit" || input.Text == "back" || input.Text == "go back")
                {
                    bedroom_back = true;
                    up_hallway = false;
                    dresser = false;
                    downstairs = false;
                    den = false;
                    frontdoor = false;
                    sidedoor = false;
                    barn = false;
                    road = false;
                    bedroom_return = false;
                    bedroom_start = false;
                    basement = false;
                    sleep = false;
                    story.Anchor = AnchorStyles.None;
                    story.Location = new Point(world.Location.X, world.Location.Y + 430);
                    story.Size = new Size(860, 130);
                    button1_Click_1((object)sender, (EventArgs)e);
                }
                if (input.Text == "go to hallway" || input.Text == "enter hallway" || input.Text == "leave room")
                {
                    up_hallway = true;
                    bedroom_start = false;
                    dresser = false;
                    downstairs = false;
                    den = false;
                    frontdoor = false;
                    sidedoor = false;
                    barn = false;
                    road = false;
                    bedroom_return = false;
                    bedroom_back = false;
                    basement = false;
                    sleep = false;
                    story.Anchor = AnchorStyles.None;
                    story.Location = new Point(world.Location.X, world.Location.Y + 430);
                    story.Size = new Size(860, 130);
                    button1_Click_1((object)sender, (EventArgs)e);
                }
                input.Clear();
            }
            //------------------------------------------------------------------------------------------
            if (up_hallway == true)
            {
                world.Image = Image.FromFile("world/fadetoblack.jpg");
                story.Text = "I step into the hallway. It is, I think, just like any other hallway. Yet I hesitate to explore further. The space feels tight and confined; the light spilling in from the window overlooking the stairs offers me no comfort." + Environment.NewLine + Environment.NewLine + "I move to it. The curiosity that fuels me to reach for the doorknob is morbid, and when it does not budge, I feel that I have lost something. Though the framework is the same, the color is different; a soft, pastel color. Vaguely, I wonder, did the room beyond belong to a child? The familiarity unsettles me." + Environment.NewLine + Environment.NewLine + "I pause." + Environment.NewLine + Environment.NewLine + "I move to it. The curiosity that fuels me to reach for the doorknob is morbid, and when it does not budge, I feel that I have lost something. I touch the wood of the door, feeling the grain. Though the framework is the same, the color is different; a soft, pastel color. Vaguely, I wonder, did the room beyond belong to a child? The familiarity unsettles me." + Environment.NewLine + Environment.NewLine + "A man built this door, and my mind strains to put a name and a face to him - to the children he built the door for." + Environment.NewLine + Environment.NewLine + "I should go.";
                story.Anchor = AnchorStyles.None;
                story.Location = new Point(world.Location.X, world.Location.Y);
                story.Size = new Size(860, 555);
                if (input.Text == "go to bedroom" || input.Text == "enter bedroom")
                {
                    bedroom_back = true;
                    bedroom_start = false;
                    up_hallway = false;
                    dresser = false;
                    downstairs = false;
                    den = false;
                    frontdoor = false;
                    sidedoor = false;
                    barn = false;
                    road = false;
                    bedroom_return = false;
                    basement = false;
                    sleep = false;
                    story.Anchor = AnchorStyles.None;
                    story.Location = new Point(world.Location.X, world.Location.Y + 430);
                    story.Size = new Size(860, 130);
                    button1_Click_1((object)sender, (EventArgs)e);

                }
                if (input.Text == "go downstairs" || input.Text == "go down")
                {
                    downstairs = true;
                    bedroom_start = false;
                    up_hallway = false;
                    dresser = false;
                    den = false;
                    frontdoor = false;
                    sidedoor = false;
                    barn = false;
                    road = false;
                    bedroom_return = false;
                    bedroom_back = false;
                    basement = false;
                    sleep = false;
                    story.Anchor = AnchorStyles.None;
                    story.Location = new Point(world.Location.X, world.Location.Y + 430);
                    story.Size = new Size(860, 130);
                    button1_Click_1((object)sender, (EventArgs)e);
                }
                input.Clear();
            }
            //------------------------------------------------------------------------------------------
            if (downstairs == true)
            {
                world.Image = Image.FromFile("world/fadetoblack.jpg");
                story.Text = "Standing at the foot of the stairs, I can see an entry way to a den, and one into the kitchen. In front of me there is a door." + Environment.NewLine + Environment.NewLine + "I stop to admire the stained glass and the way its colors play across the floor, and me.";
                story.Anchor = AnchorStyles.None;
                story.Location = new Point(world.Location.X, world.Location.Y);
                story.Size = new Size(860, 555);
                if (input.Text == "go to hallway" || input.Text == "go upstairs" || input.Text == "go up")
                {
                    up_hallway = true;
                    bedroom_start = false;
                    dresser = false;
                    downstairs = false;
                    den = false;
                    frontdoor = false;
                    sidedoor = false;
                    barn = false;
                    road = false;
                    bedroom_return = false;
                    bedroom_back = false;
                    basement = false;
                    sleep = false;
                    story.Anchor = AnchorStyles.None;
                    story.Location = new Point(world.Location.X, world.Location.Y + 430);
                    story.Size = new Size(860, 130);
                    button1_Click_1((object)sender, (EventArgs)e);
                }
                if (input.Text == "go to den" || input.Text == "enter den" || input.Text == "go to livingroom" || input.Text == "enter livingroom")
                {
                    den = true;
                    bedroom_start = false;
                    up_hallway = false;
                    dresser = false;
                    downstairs = false;
                    frontdoor = false;
                    sidedoor = false;
                    barn = false;
                    road = false;
                    bedroom_return = false;
                    bedroom_back = false;
                    basement = false;
                    sleep = false;
                    story.Anchor = AnchorStyles.None;
                    story.Location = new Point(world.Location.X, world.Location.Y + 430);
                    story.Size = new Size(860, 130);
                    button1_Click_1((object)sender, (EventArgs)e);
                }
                if (input.Text == "open side door" || input.Text == "enter side door" || input.Text == "open door" || input.Text == "examine door")
                {
                    sidedoor = true;
                    bedroom_start = false;
                    up_hallway = false;
                    dresser = false;
                    downstairs = false;
                    den = false;
                    frontdoor = false;
                    barn = false;
                    road = false;
                    bedroom_return = false;
                    bedroom_back = false;
                    basement = false;
                    sleep = false;
                    story.Anchor = AnchorStyles.None;
                    story.Location = new Point(world.Location.X, world.Location.Y + 430);
                    story.Size = new Size(860, 130);
                    button1_Click_1((object)sender, (EventArgs)e);
                }
                input.Clear();
            }
            //------------------------------------------------------------------------------------------
            if (den == true)
            {
                world.Image = Image.FromFile("world/fadetoblack.jpg");
                story.Text = "The den is an open and well lit space. I don't mind being here, and would go so far as to say that it is a comfortable and inviting place." + Environment.NewLine + Environment.NewLine + "Color dances across the hardwood floor, reds, blues, and all of the colors in between that children like." + Environment.NewLine + Environment.NewLine + "I think of my own children, with some inexplicable sadness. The moment passes, but the emotion stays with me, in the back of my mind." + Environment.NewLine + Environment.NewLine + "From where I stand, I can see a basement door, almost too old to be a part of this house, and a stocked kitchen; lit by the light of the screen door I imagine leads to the yard." + Environment.NewLine + Environment.NewLine + "The house is beautiful, would be beautiful, if I didn't carry this constant feeling of anxiety and mistrust." + Environment.NewLine + Environment.NewLine + "I pause, does that make sense?" + Environment.NewLine + Environment.NewLine + "It is, after all, just a house. It's the people who live in it that make it what it is.";
                story.Anchor = AnchorStyles.None;
                story.Location = new Point(world.Location.X, world.Location.Y);
                story.Size = new Size(860, 555);
                if (input.Text == "stairway" || input.Text == "go back" || input.Text == "leave room" || input.Text == "go to stairs" || input.Text == "leave den")
                {
                    downstairs = true;
                    bedroom_start = false;
                    up_hallway = false;
                    dresser = false;
                    den = false;
                    frontdoor = false;
                    sidedoor = false;
                    barn = false;
                    road = false;
                    bedroom_return = false;
                    bedroom_back = false;
                    basement = false;
                    sleep = false;
                    story.Anchor = AnchorStyles.None;
                    story.Location = new Point(world.Location.X, world.Location.Y + 430);
                    story.Size = new Size(860, 130);
                    button1_Click_1((object)sender, (EventArgs)e);
                }
                if (input.Text == "open front door" || input.Text == "leave house" || input.Text == "examine front door"
                    || input.Text == "open door" || input.Text == "examine frontdoor" || input.Text == "open frontdoor" || input.Text == "go outside")
                {
                    frontdoor = true;
                    bedroom_start = false;
                    up_hallway = false;
                    dresser = false;
                    downstairs = false;
                    den = false;
                    sidedoor = false;
                    barn = false;
                    road = false;
                    bedroom_return = false;
                    bedroom_back = false;
                    basement = false;
                    sleep = false;
                    story.Anchor = AnchorStyles.None;
                    story.Location = new Point(world.Location.X, world.Location.Y + 430);
                    story.Size = new Size(860, 130);
                    button1_Click_1((object)sender, (EventArgs)e);
                }
                if (input.Text == "enter basement" || input.Text == "go to basement" || input.Text == "go downstairs" || input.Text == "go down")
                {
                    basement = true;
                    bedroom_start = false;
                    up_hallway = false;
                    dresser = false;
                    downstairs = false;
                    den = false;
                    frontdoor = false;
                    sidedoor = false;
                    barn = false;
                    road = false;
                    bedroom_return = false;
                    bedroom_back = false;
                    sleep = false;
                    story.Anchor = AnchorStyles.None;
                    story.Location = new Point(world.Location.X, world.Location.Y + 430);
                    story.Size = new Size(860, 130);
                    button1_Click_1((object)sender, (EventArgs)e);
                }
                input.Clear();
            }
            //------------------------------------------------------------------------------------------
            if (sidedoor == true)
            {
                world.Image = Image.FromFile("world/outside.jpg");
                story.Text = "The breeze that blows past me as I step out onto the porch and stand in it's shade rejuvenates me. As I look out over the yard, I see very little that stands out to me." + Environment.NewLine + Environment.NewLine + "The only defining feature is the barn, which stands alone and looms over the rest of the yard." + Environment.NewLine + Environment.NewLine + "To me, there has always been something unsettling about barns.";
                if (input.Text == "go back" || input.Text == "go inside" || input.Text == "close door" || input.Text == "enter house")
                {
                    downstairs = true;
                    bedroom_start = false;
                    up_hallway = false;
                    dresser = false;
                    den = false;
                    frontdoor = false;
                    sidedoor = false;
                    barn = false;
                    road = false;
                    bedroom_return = false;
                    bedroom_back = false;
                    basement = false;
                    sleep = false;
                    story.Anchor = AnchorStyles.None;
                    story.Location = new Point(world.Location.X, world.Location.Y + 430);
                    story.Size = new Size(860, 130);
                    button1_Click_1((object)sender, (EventArgs)e);
                }
                if (input.Text == "go to barn" || input.Text == "walk to barn" || input.Text == "enter barn" || input.Text == "examine barn")
                {
                    barn = true;
                    bedroom_start = false;
                    up_hallway = false;
                    dresser = false;
                    downstairs = false;
                    den = false;
                    frontdoor = false;
                    sidedoor = false;
                    road = false;
                    bedroom_return = false;
                    bedroom_back = false;
                    basement = false;
                    sleep = false;
                    story.Anchor = AnchorStyles.None;
                    story.Location = new Point(world.Location.X, world.Location.Y + 430);
                    story.Size = new Size(860, 130);
                    button1_Click_1((object)sender, (EventArgs)e);
                }
                input.Clear();
            }
            //------------------------------------------------------------------------------------------
            if (frontdoor == true)
            {
                world.Image = Image.FromFile("world/frontdoor.jpg");
                story.Text = "It's odd, I think, that I do not remember the front of the house. How else did I get here?" + Environment.NewLine + Environment.NewLine + "There is nothing memorable about it, though. There the yard, encircled by a gate, and beyond that there is field, which folds into the forest, and is divided by the road leading up to the house." + Environment.NewLine + Environment.NewLine + "There is nothing pleasing about the expansiveness of my surroundings." + Environment.NewLine + Environment.NewLine + "It only excels at making my lonesomeness more pronounced.";
                if (input.Text == "go back" || input.Text == "enter den" || input.Text == "go to den"
                    || input.Text == "close door" || input.Text == "enter house" || input.Text == "go to livingroom"
                    || input.Text == "enter livingroom")
                {
                    den = true;
                    bedroom_start = false;
                    up_hallway = false;
                    dresser = false;
                    downstairs = false;
                    frontdoor = false;
                    sidedoor = false;
                    barn = false;
                    road = false;
                    bedroom_return = false;
                    bedroom_back = false;
                    basement = false;
                    sleep = false;
                    story.Anchor = AnchorStyles.None;
                    story.Location = new Point(world.Location.X, world.Location.Y + 430);
                    story.Size = new Size(860, 130);
                    button1_Click_1((object)sender, (EventArgs)e);
                }
                if (input.Text == "go to road" || input.Text == "walk to road" || input.Text == "walk down road" || input.Text == "examine road")
                {
                    road = true;
                    bedroom_start = false;
                    up_hallway = false;
                    dresser = false;
                    downstairs = false;
                    den = false;
                    frontdoor = false;
                    sidedoor = false;
                    barn = false;
                    bedroom_return = false;
                    bedroom_back = false;
                    basement = false;
                    sleep = false;
                    story.Anchor = AnchorStyles.None;
                    story.Location = new Point(world.Location.X, world.Location.Y + 430);
                    story.Size = new Size(860, 130);
                    button1_Click_1((object)sender, (EventArgs)e);
                }
                input.Clear();
            }
            //------------------------------------------------------------------------------------------
            if (barn == true)
            {
                world.Image = Image.FromFile("world/fadetoblack.jpg");
                story.Text = "Out of curiosity, I go to the barn doors, I try to pull them open but they will not budge." + Environment.NewLine + Environment.NewLine + "Still, I can put my curiosity to rest. I don't need to know what's in there.";
                story.Anchor = AnchorStyles.None;
                story.Location = new Point(world.Location.X, world.Location.Y);
                story.Size = new Size(860, 555);
                if (input.Text == "return to house" || input.Text == "back to house" || input.Text == "walk to house" || input.Text == "leave barn" || input.Text == "exit barn")
                {
                    sidedoor = true;
                    bedroom_start = false;
                    up_hallway = false;
                    dresser = false;
                    downstairs = false;
                    den = false;
                    frontdoor = false;
                    barn = false;
                    road = false;
                    bedroom_return = false;
                    bedroom_back = false;
                    basement = false;
                    sleep = false;
                    story.Anchor = AnchorStyles.None;
                    story.Location = new Point(world.Location.X, world.Location.Y + 430);
                    story.Size = new Size(860, 130);
                    button1_Click_1((object)sender, (EventArgs)e);
                }
                input.Clear();
            }
            //------------------------------------------------------------------------------------------
            if (basement == true)
            {
                world.Image = Image.FromFile("world/basement.jpg");
                story.Text = "I open the door, and I discover another staircase. This one leads deeper into the house." + Environment.NewLine + Environment.NewLine + "Down." + Environment.NewLine + Environment.NewLine + "The word is a knot in my throat and sinks in my gut. It is unfathomably dark, and to my mind, the stairwell, receding into the blackness, gapes up at me like a hungry maw. " + Environment.NewLine + Environment.NewLine + "I take a step onto the first stair; it bends and groans beneath my weight. That is enough to discourage me from going further. I shut the door quickly, and feel better off for it.";
                if (input.Text == "leave basement" || input.Text == "go up" || input.Text == "enter den" || input.Text == "enter livingroom")
                {
                    den = true;
                    bedroom_start = false;
                    up_hallway = false;
                    dresser = false;
                    downstairs = false;
                    frontdoor = false;
                    sidedoor = false;
                    barn = false;
                    road = false;
                    bedroom_return = false;
                    bedroom_back = false;
                    basement = false;
                    sleep = false;
                    story.Anchor = AnchorStyles.None;
                    story.Location = new Point(world.Location.X, world.Location.Y + 430);
                    story.Size = new Size(860, 130);
                    button1_Click_1((object)sender, (EventArgs)e);
                }
                input.Clear();
            }
            //------------------------------------------------------------------------------------------
            if (road == true)
            {
                world.Image = Image.FromFile("world/road.jpg");
                story.Text = "Despite my better judgement, I pause to look at the house after I have passed through it's front gate. There is no resistance in the way it opens; I didn't expect there to be, but it is still a weight off my mind." + Environment.NewLine + Environment.NewLine + "It is my first real look at the place, and it looks harmless - as a house should." + Environment.NewLine + Environment.NewLine + "I do not spend much time looking at it, because there is not much time to waste. In any given direction that I look, there is nothing but field and woods for miles, this is the only road leading to and from this place." + Environment.NewLine + Environment.NewLine + "It isn't a very well traveled road, either. Weeds and grass have began to push through the dirt in places." + Environment.NewLine + Environment.NewLine + "The walk is peaceful, the sun breaking through the foliage above feels nice on my face, and the sound of wildlife comforting. Aside from my own thoughts, I've had little else to distract me. " + Environment.NewLine + Environment.NewLine + "The enjoyment is short-lived, and I slow to a stop." + Environment.NewLine + Environment.NewLine + "There is a fork in the road." + Environment.NewLine + Environment.NewLine + "The paths look identical, but it is not hard for me to decide which path to take." + Environment.NewLine + Environment.NewLine + "I continue with confidence, to the... ";
                if (input.Text == "go left" || input.Text == "left" || input.Text == "go right" || input.Text == "right")
                {
                    bedroom_return = true;
                    bedroom_start = false;
                    up_hallway = false;
                    dresser = false;
                    downstairs = false;
                    den = false;
                    frontdoor = false;
                    sidedoor = false;
                    barn = false;
                    road = false;
                    bedroom_back = false;
                    basement = false;
                    sleep = false;
                    story.Anchor = AnchorStyles.None;
                    story.Location = new Point(world.Location.X, world.Location.Y + 430);
                    story.Size = new Size(860, 130);
                    button1_Click_1((object)sender, (EventArgs)e);
                }
                if (input.Text == "go to front door" || input.Text == "back to house" || input.Text == "go to house")
                {
                    frontdoor = true;
                    bedroom_start = false;
                    up_hallway = false;
                    dresser = false;
                    downstairs = false;
                    den = false;
                    sidedoor = false;
                    barn = false;
                    road = false;
                    bedroom_return = false;
                    bedroom_back = false;
                    basement = false;
                    sleep = false;
                    story.Anchor = AnchorStyles.None;
                    story.Location = new Point(world.Location.X, world.Location.Y + 430);
                    story.Size = new Size(860, 130);
                    button1_Click_1((object)sender, (EventArgs)e);
                }
                input.Clear();
            }
            //------------------------------------------------------------------------------------------
            if (bedroom_return == true)
            {
                world.Image = Image.FromFile("world/back_room.jpg");
                story.Text = "I pause at the window; I can see the road from where I stand." + Environment.NewLine + Environment.NewLine + "When I try to recall how I ended up here, there is nothing. The road is the last thing I remember." + Environment.NewLine + Environment.NewLine + "Maybe that path led no where.";
                if (input.Text == "open dresser" || input.Text == "examine dresser")
                {
                    dresser = true;
                    bedroom_start = false;
                    up_hallway = false;
                    downstairs = false;
                    den = false;
                    frontdoor = false;
                    sidedoor = false;
                    barn = false;
                    road = false;
                    bedroom_return = false;
                    bedroom_back = false;
                    basement = false;
                    sleep = false;
                    story.Anchor = AnchorStyles.None;
                    story.Location = new Point(world.Location.X, world.Location.Y + 430);
                    story.Size = new Size(860, 130);
                    button1_Click_1((object)sender, (EventArgs)e);
                }
                if (input.Text == "go to hallway" || input.Text == "enter hallway" || input.Text == "leave room")
                {
                    up_hallway = true;
                    bedroom_start = false;
                    dresser = false;
                    downstairs = false;
                    den = false;
                    frontdoor = false;
                    sidedoor = false;
                    barn = false;
                    road = false;
                    bedroom_return = false;
                    bedroom_back = false;
                    basement = false;
                    sleep = false;
                    button1_Click_1((object)sender, (EventArgs)e);
                    story.Anchor = AnchorStyles.None;
                    story.Location = new Point(world.Location.X, world.Location.Y + 430);
                    story.Size = new Size(860, 130);
                }
                if (input.Text == "bed" || input.Text == "go to sleep" || input.Text == "sleep")
                {
                    sleep = true;
                    bedroom_start = false;
                    up_hallway = false;
                    dresser = false;
                    downstairs = false;
                    den = false;
                    frontdoor = false;
                    sidedoor = false;
                    barn = false;
                    road = false;
                    bedroom_return = false;
                    bedroom_back = false;
                    basement = false;
                    story.Anchor = AnchorStyles.None;
                    story.Location = new Point(world.Location.X, world.Location.Y + 430);
                    story.Size = new Size(860, 130);
                    button1_Click_1((object)sender, (EventArgs)e);
                }
                input.Clear();
            }
            //-------------------------------------------------------------------
            if (bedroom_back == true)
            {
                world.Image = Image.FromFile("world/back_room.jpg");
                story.Text = "I return to bedroom. There is something safe about this room.";
                if (input.Text == "open dresser" || input.Text == "examine dresser")
                {
                    dresser = true;
                    bedroom_start = false;
                    up_hallway = false;
                    downstairs = false;
                    den = false;
                    frontdoor = false;
                    sidedoor = false;
                    barn = false;
                    road = false;
                    bedroom_return = false;
                    bedroom_back = false;
                    basement = false;
                    sleep = false;
                    story.Anchor = AnchorStyles.None;
                    story.Location = new Point(world.Location.X, world.Location.Y + 430);
                    story.Size = new Size(860, 130);
                    button1_Click_1((object)sender, (EventArgs)e);
                }
                if (input.Text == "go to hallway" || input.Text == "enter hallway" || input.Text == "leave room")
                {
                    up_hallway = true;
                    bedroom_start = false;
                    dresser = false;
                    downstairs = false;
                    den = false;
                    frontdoor = false;
                    sidedoor = false;
                    barn = false;
                    road = false;
                    bedroom_return = false;
                    bedroom_back = false;
                    basement = false;
                    sleep = false;
                    story.Anchor = AnchorStyles.None;
                    story.Location = new Point(world.Location.X, world.Location.Y + 430);
                    story.Size = new Size(860, 130);
                    button1_Click_1((object)sender, (EventArgs)e);
                }
                if (input.Text == "go to bed" || input.Text == "bed" || input.Text == "go to sleep" || input.Text == "sleep")
                {
                    sleep = true;
                    bedroom_start = false;
                    up_hallway = false;
                    dresser = false;
                    downstairs = false;
                    den = false;
                    frontdoor = false;
                    sidedoor = false;
                    barn = false;
                    road = false;
                    bedroom_return = false;
                    bedroom_back = false;
                    basement = false;
                    story.Anchor = AnchorStyles.None;
                    story.Location = new Point(world.Location.X, world.Location.Y + 430);
                    story.Size = new Size(860, 130);
                    button1_Click_1((object)sender, (EventArgs)e);
                }
                input.Clear();
            }
            //--------------------------------------------------------------------------------
            if (sleep == true)
            {
                story.Anchor = AnchorStyles.None;
                story.Location = new Point(world.Location.X, world.Location.Y);
                story.Size = new Size(860, 555);
                story.Text = "I resign myself to sleep; with a bone deep ache in my body, and fatigue setting in on my mind, I slide into the sheets, take my hair down, and cast my eyes towards the darkening ceiling." + Environment.NewLine + Environment.NewLine + "It is not without some fear that I close my eyes, and even as sleep begins to overtake me, I cling to the strong feeling of loss that hangs over me, and the faceless thoughts of my family." + Environment.NewLine + Environment.NewLine + "Today led nowhere";
                world.Image = Image.FromFile("world/fadetoblack.jpg");
                bedroom_start = true;
                up_hallway = false;
                dresser = false;
                downstairs = false;
                den = false;
                frontdoor = false;
                sidedoor = false;
                barn = false;
                road = false;
                bedroom_return = false;
                bedroom_back = false;
                basement = false;
                sleep = false;
                story.Anchor = AnchorStyles.None;
                story.Location = new Point(world.Location.X, world.Location.Y + 430);
                story.Size = new Size(860, 130);
                MessageBox.Show("Maybe tomorrow will be better...");
            }
        }
    }
}
