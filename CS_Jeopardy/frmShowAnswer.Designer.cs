namespace CS_Jeopardy
{
    partial class frmShowAnswer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAnswertxtAnswer = new System.Windows.Forms.TextBox();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.lblPoint = new System.Windows.Forms.Label();
            this.btnTeam1 = new System.Windows.Forms.Button();
            this.btnTeam2 = new System.Windows.Forms.Button();
            this.btnTeam3 = new System.Windows.Forms.Button();
            this.btnCorrect = new System.Windows.Forms.Button();
            this.btnWrong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(209)))), ((int)(((byte)(99)))));
            this.label1.Location = new System.Drawing.Point(37, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Answer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(209)))), ((int)(((byte)(99)))));
            this.label2.Location = new System.Drawing.Point(37, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Question";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(209)))), ((int)(((byte)(99)))));
            this.label3.Location = new System.Drawing.Point(37, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Points";
            // 
            // txtAnswertxtAnswer
            // 
            this.txtAnswertxtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswertxtAnswer.Location = new System.Drawing.Point(116, 58);
            this.txtAnswertxtAnswer.Name = "txtAnswertxtAnswer";
            this.txtAnswertxtAnswer.Size = new System.Drawing.Size(510, 23);
            this.txtAnswertxtAnswer.TabIndex = 3;
            // 
            // txtQuestion
            // 
            this.txtQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.Location = new System.Drawing.Point(116, 106);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(510, 23);
            this.txtQuestion.TabIndex = 4;
            this.txtQuestion.Visible = false;
            // 
            // lblPoint
            // 
            this.lblPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(209)))), ((int)(((byte)(99)))));
            this.lblPoint.Location = new System.Drawing.Point(116, 16);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(100, 23);
            this.lblPoint.TabIndex = 5;
            this.lblPoint.Text = "label4";
            // 
            // btnTeam1
            // 
            this.btnTeam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeam1.Location = new System.Drawing.Point(116, 155);
            this.btnTeam1.Name = "btnTeam1";
            this.btnTeam1.Size = new System.Drawing.Size(67, 23);
            this.btnTeam1.TabIndex = 6;
            this.btnTeam1.Text = "Team &1";
            this.btnTeam1.UseVisualStyleBackColor = true;
            this.btnTeam1.Click += new System.EventHandler(this.btnTeam1_Click);
            // 
            // btnTeam2
            // 
            this.btnTeam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeam2.Location = new System.Drawing.Point(209, 155);
            this.btnTeam2.Name = "btnTeam2";
            this.btnTeam2.Size = new System.Drawing.Size(67, 23);
            this.btnTeam2.TabIndex = 7;
            this.btnTeam2.Text = "Team &2";
            this.btnTeam2.UseVisualStyleBackColor = true;
            this.btnTeam2.Click += new System.EventHandler(this.btnTeam2_Click);
            // 
            // btnTeam3
            // 
            this.btnTeam3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeam3.Location = new System.Drawing.Point(302, 155);
            this.btnTeam3.Name = "btnTeam3";
            this.btnTeam3.Size = new System.Drawing.Size(67, 23);
            this.btnTeam3.TabIndex = 8;
            this.btnTeam3.Text = "Team &3";
            this.btnTeam3.UseVisualStyleBackColor = true;
            this.btnTeam3.Click += new System.EventHandler(this.btnTeam3_Click);
            // 
            // btnCorrect
            // 
            this.btnCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrect.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnCorrect.Location = new System.Drawing.Point(445, 155);
            this.btnCorrect.Name = "btnCorrect";
            this.btnCorrect.Size = new System.Drawing.Size(75, 23);
            this.btnCorrect.TabIndex = 9;
            this.btnCorrect.Text = "&Correct";
            this.btnCorrect.UseVisualStyleBackColor = true;
            this.btnCorrect.Visible = false;
            this.btnCorrect.Click += new System.EventHandler(this.btnCorrect_Click);
            // 
            // btnWrong
            // 
            this.btnWrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWrong.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnWrong.Location = new System.Drawing.Point(551, 155);
            this.btnWrong.Name = "btnWrong";
            this.btnWrong.Size = new System.Drawing.Size(75, 23);
            this.btnWrong.TabIndex = 10;
            this.btnWrong.Text = "&Incorrect";
            this.btnWrong.UseVisualStyleBackColor = true;
            this.btnWrong.Visible = false;
            this.btnWrong.Click += new System.EventHandler(this.btnWrong_Click);
            // 
            // frmShowAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(671, 201);
            this.Controls.Add(this.btnWrong);
            this.Controls.Add(this.btnCorrect);
            this.Controls.Add(this.btnTeam3);
            this.Controls.Add(this.btnTeam2);
            this.Controls.Add(this.btnTeam1);
            this.Controls.Add(this.lblPoint);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.txtAnswertxtAnswer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmShowAnswer";
            this.Text = "frmShowAnswer";
            this.Load += new System.EventHandler(this.frmShowAnswer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAnswertxtAnswer;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.Button btnTeam1;
        private System.Windows.Forms.Button btnTeam2;
        private System.Windows.Forms.Button btnTeam3;
        private System.Windows.Forms.Button btnCorrect;
        private System.Windows.Forms.Button btnWrong;
    }
}