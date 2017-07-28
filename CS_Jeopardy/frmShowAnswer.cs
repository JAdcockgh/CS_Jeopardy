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
    public partial class frmShowAnswer : Form
    {
        public frmShowAnswer()
        {
            InitializeComponent();
        }

        private void btnTeam1_Click(object sender, EventArgs e)
        {//-- disable the other two team buttons, make the correct and incorrect buttons visible and start the 20 second timer
            //-- prevent other teams from inadvertantly getting the points
            btnTeam2.Enabled = false;
            btnTeam3.Enabled = false;
            btnCorrect.Visible = true;
            btnWrong.Visible = true;
            frm_Main.intTeamNum = 0;


            //-- question has been given - show the correct question
            txtQuestion.Visible = true;
        }

        private void btnTeam2_Click(object sender, EventArgs e)
        {//-- disable the other two team buttons, make the correct and incorrect buttons visible and start the 20 second timer
            //-- prevent other teams from inadvertantly getting the points
            btnTeam1.Enabled = false;
            btnTeam3.Enabled = false;
            btnCorrect.Visible = true;
            btnWrong.Visible = true;
            frm_Main.intTeamNum = 1;

            //-- question has been given - show the correct question
            txtQuestion.Visible = true;
        }

        private void btnTeam3_Click(object sender, EventArgs e)
        {//-- disable the other two team buttons, make the correct and incorrect buttons visible and start the 20 second timer
            //-- prevent other teams from inadvertantly getting the points
            btnTeam1.Enabled = false;
            btnTeam2.Enabled = false;
            btnCorrect.Visible = true;
            btnWrong.Visible = true;
            frm_Main.intTeamNum = 2;
            
            //-- question has been given - show the correct question
            txtQuestion.Visible = true;
        }

        private void btnCorrect_Click(object sender, EventArgs e)
        {//-- signal a correct anaswer and close the form
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnWrong_Click(object sender, EventArgs e)
        {//-- signal a INCORRECT anaswer and close the form
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void frmShowAnswer_Load(object sender, EventArgs e)
        {
            if (frm_Main.blnFlag)
            {//-- in test mode
                lblPoint.Text = "500";
                txtAnswertxtAnswer.Text = "Ecclesisastes 13:12";
                txtQuestion.Text = "What is the purpose if life?";
            }
            else
            {//-- actual game time answer/question
                lblPoint.Text = frm_Main.strRnd1[frm_Main.intCol, frm_Main.intRow, frm_Main.AMT];
                txtAnswertxtAnswer.Text = frm_Main.strRnd1[frm_Main.intCol, frm_Main.intRow, frm_Main.ANS];
                txtQuestion.Text = frm_Main.strRnd1[frm_Main.intCol, frm_Main.intRow, frm_Main.ASK];
            }

        }
    }
}
