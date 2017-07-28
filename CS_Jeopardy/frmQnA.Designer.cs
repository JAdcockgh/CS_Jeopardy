namespace CS_Jeopardy
{
    partial class frmQnA
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
            this.lblQnA = new System.Windows.Forms.Label();
            this.btnCorrect = new System.Windows.Forms.Button();
            this.btnWrong = new System.Windows.Forms.Button();
            this.btnNoTime = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQnA
            // 
            this.lblQnA.AutoSize = true;
            this.lblQnA.Location = new System.Drawing.Point(40, 28);
            this.lblQnA.Name = "lblQnA";
            this.lblQnA.Size = new System.Drawing.Size(35, 13);
            this.lblQnA.TabIndex = 0;
            this.lblQnA.Text = "label1";
            // 
            // btnCorrect
            // 
            this.btnCorrect.BackColor = System.Drawing.Color.LightGreen;
            this.btnCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrect.Location = new System.Drawing.Point(27, 195);
            this.btnCorrect.Name = "btnCorrect";
            this.btnCorrect.Size = new System.Drawing.Size(95, 34);
            this.btnCorrect.TabIndex = 1;
            this.btnCorrect.Text = "Correct";
            this.btnCorrect.UseVisualStyleBackColor = false;
            // 
            // btnWrong
            // 
            this.btnWrong.BackColor = System.Drawing.Color.Tomato;
            this.btnWrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWrong.Location = new System.Drawing.Point(170, 195);
            this.btnWrong.Name = "btnWrong";
            this.btnWrong.Size = new System.Drawing.Size(95, 34);
            this.btnWrong.TabIndex = 2;
            this.btnWrong.Text = "Incorrect";
            this.btnWrong.UseVisualStyleBackColor = false;
            // 
            // btnNoTime
            // 
            this.btnNoTime.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnNoTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoTime.Location = new System.Drawing.Point(313, 195);
            this.btnNoTime.Name = "btnNoTime";
            this.btnNoTime.Size = new System.Drawing.Size(95, 34);
            this.btnNoTime.TabIndex = 3;
            this.btnNoTime.Text = "Out of Time";
            this.btnNoTime.UseVisualStyleBackColor = false;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(180, 147);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // frmQnA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 241);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnNoTime);
            this.Controls.Add(this.btnWrong);
            this.Controls.Add(this.btnCorrect);
            this.Controls.Add(this.lblQnA);
            this.Name = "frmQnA";
            this.Text = "Answer to the question";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQnA;
        private System.Windows.Forms.Button btnCorrect;
        private System.Windows.Forms.Button btnWrong;
        private System.Windows.Forms.Button btnNoTime;
        private System.Windows.Forms.Button btnOK;
    }
}