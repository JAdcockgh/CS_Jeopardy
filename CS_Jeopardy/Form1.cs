using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Jeopardy
{
    public partial class frm_Main : Form
    {
        int amount = 0;
        int dollars = 0;
        string btnLbl = "";

        //-- define the constants that will be used as indexes for the QnA array; this hsould make reading the array easier
        const int LVL = 0;
        const int CAT = 1;
        const int ANS = 2;
        const int ASK = 3;
        const int AMT = 4;
        const int DD  = 5;

        const int ROW = 0;
        const int COL = 1;

        string [, ,] strRnd1 = new string[6, 5, 6] 
        { //COLS
            { //ROWS
                //ELEMENTS
                { "1", "Kings", "He wanted to cut a baby in 1/2.", "Who is King Solomon?", "100", "0"}, 
                { "1", "Kings", "He was the last earthly King to rule.", "Who is King Zedekiah?", "200", "0"},
                { "1", "Kings", "He was the 1st King of the 10 tribe kingdom.", "Who is King Rehoboam?", "300", "0"},
                { "1", "Kings", "He stole Naboth's vineyard.", "Who is King Ahab?", "400", "0"},
                { "1", "Kings", "This 'King' was actually a Queen.", "Who is Queen Athaliah?", "500", "0"}
            },
            {
                { "1", "Cities", "The house of God", "What is Bethel?", "100", "0"},
                { "1", "Cities", "The unitentional manslayer would flee here.", "What is the city of refuge?", "200", "0"},
                { "1", "Cities", "Abram left here with Terah and Sarai.", "What is the city of Ur", "300", "0"},
                { "1", "Cities", "Jesus performed his first miracle here.", "What is the city of Cana?", "400", "0"},
                { "1", "Cities", "Samson visited a protitue in this city.", "What is the city of Gaza?", "500", "0"}
            },
            {
                { "1", "Books of the Bible", "This is the 3rd book of the Pentateuch", "What is the book of Levitcus?", "100", "0"},
                { "1", "Books of the Bible", "Here is where get 'a day for a year'.", "What is the book of Numbers?", "200", "0"},
                { "1", "Books of the Bible", "This book is the Bible's shortest.", "What is the 3rd letter of John", "300", "0"},
                { "1", "Books of the Bible", "This is also known as a dirge.", "What is the book of Lamentations?", "400", "0"},
                { "1", "Books of the Bible", "Here can be found a geneology of the Kings of Isreal and Judah.", "What is the book of 2 Chronicles?", "500", "0"}
            },
            {
                { "1", "People", "His father was the 1st King of united Israel.", "Who is Johnathan?", "100", "0"},
                { "1", "People", "He was David's Uncle and Chief of the Army'.", "Who is Joab?", "200", "0"},
                { "1", "People", "He died five years before the Noahachian flood.", "Who is Lamech?", "300", "0"},
                { "1", "People", "He replaced Judas Iscariot.", "Who is Mathias?", "400", "0"},
                { "1", "People", "He was an escaped slave who became a Chritian.", "Who is Onesimus?", "500", "0"}
            },
            {
                { "1", "Prophets", "He was drawn out of water", "Who is Moses?", "100", "0"},
                { "1", "Prophets", "This prophet was formerly a nipper of figs'.", "Who is Amos?", "200", "0"},
                { "1", "Prophets", "This prophet foretold someone coming greater than he.", "Who is John the baptist.", "300", "0"},
                { "1", "Prophets", "This prophet foretold Josiah's great campaign to cleanse the land.", "Who is the man of the true God?", "400", "0"},
                { "1", "Prophets", "This prophet foretold Paul's arrest and imprisonment in Jerusalem.", "Who is Agabus?", "500", "0"}
            },
            {
                { "1", "Principles", "This pnrinciple is why we don't smoke", "What is 1Cor 7:1?", "100", "0"},
                { "1", "Principles", "This principle is the identifying mark of Christ's disciples.'.", "What is John 13:35?", "200", "0"},
                { "1", "Principles", "This principle is why we do no ttake in blood.", "What is Acts 15:19", "300", "0"},
                { "1", "Principles", "This principle governs how we treat others.", "What is Matthew 7:12?", "400", "0"},
                { "1", "Principles", "This Bible principle sets the standard for a scriptural divorce.", "What is Mathew 19:9?", "500", "0"}
            }
        };

        string[] strAnswers = new string[] { };
        List<string> lstRnd1 = new List<string>();
        string[,,] aryRnd1 =
        {//-- ROW
            {//-- COL
                {//-- INDIVIUAL ELELMENTS
                    "1", "Kings", "He wanted to cut a baby in half", "Who is King Solomon?", "100", "0",
                    "1", "Kings", "He was the last earthly King to rule.", "Who is King Zedekiah?", "200", "0",
                    "1", "Kings", "He was the 1st King of the 10 ribe kingdom.", "Who is King Rehoboam?", "300", "0",
                    "1", "Kings", "He stole Naboth's vineyard.", "Who is King Ahab?", "400", "0",
                    "1", "Kings", "This 'King' was actually a Queen.", "Who is Queen Athaliah?", "500", "0"
                },

            }
        };

        public frm_Main()
        {
            
            InitializeComponent();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {//-- HOUSEKEEPING - to be done before the game gets underway
            int c = 0;                                                              //-- column
            int r = 0;                                                              //-- row

            string Lbl = "";                                                        //-- used to build the name field for the button pressed

            //-- loop through each row for each column
            for (c = 0;  c < 6; c++)
            {//-- row loop
                
                for (r = 0; r < 5; r++)
                {//-- column looping
                    //-- bulld the btn name so we can manipulate the contents
                    Lbl = "btnR" + r.ToString() + "C" + c.ToString();

                    //-- set the dollar amount in the box
                    this.Controls[Lbl].Text = "$" + strRnd1[c,r,AMT];

                    //-- enable the boxes (in case we are setting up round 2)
                    this.Controls[Lbl].Enabled = true;
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //-- quit the game
                Application.Exit();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //-- quit the game
            Application.Exit();
        }


        private void btnclicker(int col, int row)
        {//-- use this method to handle all of the buttons
         //-- housekeeping
         //-- ** CAUTION ** 
         //-- strRnd1 is COLUMN MAJOR array
            string box = "";
            int.TryParse(lblTotal.Text, out amount);
            box = "btnR" + row.ToString() + "C" + col.ToString();
            int.TryParse(strRnd1[col, row, AMT], out dollars);

            //-- fetch the answer for particualr cell
            this.Controls[box].Text = strRnd1[col, row, ANS];

            MessageBox.Show("Proceed", "Waiting...", MessageBoxButtons.OK);
            this.Controls[box].Text = strRnd1[col, row, ASK];

            var result = MessageBox.Show("Yes for correct, No for incorrect, cancel for timed out", "Scoring", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {//-- MC clicked OK
                amount = amount + dollars;
            }
            else 
            {//-- MC clicked NO - wrong answer
                amount = amount - dollars;
            }
            //-- we have a correct answer +, or an incorrect or timed out, -
            lblTotal.Text = amount.ToString();

            //-- disable the box to prevent clicking on it again
            this.Controls[box].Enabled = false;
        }


        private void btnC0R0_Click(object sender, EventArgs e)
        {//-- set up the parameters and pass them to the button handling routine.
            btnclicker(0, 0);
        }


        private void btnR1C0_Click(object sender, EventArgs e)
        {
            btnclicker(0, 1);

        }

        private void btnR2C0_Click(object sender, EventArgs e)
        {
            btnclicker(0, 2);
        }

        private void btnR3C0_Click(object sender, EventArgs e)
        {
            btnclicker(0, 3);
        }

        private void btnR4C0_Click(object sender, EventArgs e)
        {
            btnclicker(0, 4);
        }

        private void btnR0C1_Click(object sender, EventArgs e)
        {
            btnclicker(1, 0);

        }

        private void btnR1C1_Click(object sender, EventArgs e)
        {
            btnclicker(1, 1);

        }

        private void btnR2C1_Click(object sender, EventArgs e)
        {
            btnclicker(1, 2);

        }

        private void btnR3C1_Click(object sender, EventArgs e)
        {
            btnclicker(1, 3);

        }

        private void btnR4C1_Click(object sender, EventArgs e)
        {
            btnclicker(1, 4);

        }

        private void btnR0C2_Click(object sender, EventArgs e)
        {
            btnclicker(2, 0);

        }

        private void btnR1C2_Click(object sender, EventArgs e)
        {
            btnclicker(2, 1);

        }




        private void btnR4C2_Click(object sender, EventArgs e)
        {
            btnclicker(2, 4);

        }

         private void btnR2C2_Click(object sender, EventArgs e)
        {
            btnclicker(2, 2);

        }

        private void btnR3C2_Click(object sender, EventArgs e)
        {
            btnclicker(2, 3);

        }

        private void btnR1C3_Click(object sender, EventArgs e)
        {
            btnclicker(3, 1);

        }

        private void btnR0C3_Click(object sender, EventArgs e)
        {
            btnclicker(3, 0);

        }

        private void btnR2C3_Click(object sender, EventArgs e)
        {
            btnclicker(3, 2);

        }

        private void btnR3C3_Click(object sender, EventArgs e)
        {
            btnclicker(3, 3);

        }

        private void btnR4C3_Click(object sender, EventArgs e)
        {
            btnclicker(3, 4);
        }

        private void btnR0C4_Click(object sender, EventArgs e)
        {
            btnclicker(4, 0);
        }

        private void btnR1C4_Click(object sender, EventArgs e)
        {
            btnclicker(4, 1);
        }

        private void btnR2C4_Click(object sender, EventArgs e)
        {
            btnclicker(4, 2);
        }

        private void btnR3C4_Click(object sender, EventArgs e)
        {
            btnclicker(4, 3);
        }

        private void btnR4C4_Click(object sender, EventArgs e)
        {
            btnclicker(4, 4);
        }

        private void btnR0C5_Click(object sender, EventArgs e)
        {
            btnclicker(5, 0);
        }

        private void btnR1C5_Click(object sender, EventArgs e)
        {
            btnclicker(5, 1);
        }

        private void btnR2C5_Click(object sender, EventArgs e)
        {
            btnclicker(5, 2);
        }

        private void btnR3C5_Click(object sender, EventArgs e)
        {
            btnclicker(5, 3);
        }

        private void btnR4C5_Click(object sender, EventArgs e)
        {
            btnclicker(5, 4);
        }
    }
}
