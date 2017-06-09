namespace EnglishQuiz
{
    partial class fQuiz
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
            this.pbQuestions = new System.Windows.Forms.ProgressBar();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.gbProgress = new System.Windows.Forms.GroupBox();
            this.rbAnswer1 = new System.Windows.Forms.RadioButton();
            this.rbAnswer2 = new System.Windows.Forms.RadioButton();
            this.rbAnswer3 = new System.Windows.Forms.RadioButton();
            this.rbAnswer4 = new System.Windows.Forms.RadioButton();
            this.gbQuestion = new System.Windows.Forms.GroupBox();
            this.gbAnswers = new System.Windows.Forms.GroupBox();
            this.gbProgress.SuspendLayout();
            this.gbQuestion.SuspendLayout();
            this.gbAnswers.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbQuestions
            // 
            this.pbQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbQuestions.Location = new System.Drawing.Point(3, 16);
            this.pbQuestions.Name = "pbQuestions";
            this.pbQuestions.Size = new System.Drawing.Size(515, 30);
            this.pbQuestions.TabIndex = 0;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblQuestion.Location = new System.Drawing.Point(6, 16);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(70, 26);
            this.lblQuestion.TabIndex = 3;
            this.lblQuestion.Text = "label2";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNext.Location = new System.Drawing.Point(12, 234);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(521, 45);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Dalej";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // gbProgress
            // 
            this.gbProgress.Controls.Add(this.pbQuestions);
            this.gbProgress.Location = new System.Drawing.Point(12, 12);
            this.gbProgress.Name = "gbProgress";
            this.gbProgress.Size = new System.Drawing.Size(521, 49);
            this.gbProgress.TabIndex = 5;
            this.gbProgress.TabStop = false;
            this.gbProgress.Text = "Postęp 1/10";
            // 
            // rbAnswer1
            // 
            this.rbAnswer1.AutoSize = true;
            this.rbAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbAnswer1.Location = new System.Drawing.Point(6, 19);
            this.rbAnswer1.Name = "rbAnswer1";
            this.rbAnswer1.Size = new System.Drawing.Size(153, 30);
            this.rbAnswer1.TabIndex = 6;
            this.rbAnswer1.TabStop = true;
            this.rbAnswer1.Text = "radioButton1";
            this.rbAnswer1.UseVisualStyleBackColor = true;
            // 
            // rbAnswer2
            // 
            this.rbAnswer2.AutoSize = true;
            this.rbAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbAnswer2.Location = new System.Drawing.Point(268, 19);
            this.rbAnswer2.Name = "rbAnswer2";
            this.rbAnswer2.Size = new System.Drawing.Size(153, 30);
            this.rbAnswer2.TabIndex = 7;
            this.rbAnswer2.TabStop = true;
            this.rbAnswer2.Text = "radioButton2";
            this.rbAnswer2.UseVisualStyleBackColor = true;
            // 
            // rbAnswer3
            // 
            this.rbAnswer3.AutoSize = true;
            this.rbAnswer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbAnswer3.Location = new System.Drawing.Point(6, 64);
            this.rbAnswer3.Name = "rbAnswer3";
            this.rbAnswer3.Size = new System.Drawing.Size(153, 30);
            this.rbAnswer3.TabIndex = 8;
            this.rbAnswer3.TabStop = true;
            this.rbAnswer3.Text = "radioButton3";
            this.rbAnswer3.UseVisualStyleBackColor = true;
            // 
            // rbAnswer4
            // 
            this.rbAnswer4.AutoSize = true;
            this.rbAnswer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbAnswer4.Location = new System.Drawing.Point(268, 64);
            this.rbAnswer4.Name = "rbAnswer4";
            this.rbAnswer4.Size = new System.Drawing.Size(153, 30);
            this.rbAnswer4.TabIndex = 9;
            this.rbAnswer4.TabStop = true;
            this.rbAnswer4.Text = "radioButton4";
            this.rbAnswer4.UseVisualStyleBackColor = true;
            // 
            // gbQuestion
            // 
            this.gbQuestion.Controls.Add(this.lblQuestion);
            this.gbQuestion.Location = new System.Drawing.Point(12, 67);
            this.gbQuestion.Name = "gbQuestion";
            this.gbQuestion.Size = new System.Drawing.Size(521, 55);
            this.gbQuestion.TabIndex = 10;
            this.gbQuestion.TabStop = false;
            this.gbQuestion.Text = "Pytanie";
            // 
            // gbAnswers
            // 
            this.gbAnswers.Controls.Add(this.rbAnswer1);
            this.gbAnswers.Controls.Add(this.rbAnswer2);
            this.gbAnswers.Controls.Add(this.rbAnswer4);
            this.gbAnswers.Controls.Add(this.rbAnswer3);
            this.gbAnswers.Location = new System.Drawing.Point(12, 128);
            this.gbAnswers.Name = "gbAnswers";
            this.gbAnswers.Size = new System.Drawing.Size(521, 100);
            this.gbAnswers.TabIndex = 11;
            this.gbAnswers.TabStop = false;
            this.gbAnswers.Text = "Odpowiedzi";
            // 
            // fQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 293);
            this.Controls.Add(this.gbAnswers);
            this.Controls.Add(this.gbQuestion);
            this.Controls.Add(this.gbProgress);
            this.Controls.Add(this.btnNext);
            this.Name = "fQuiz";
            this.Text = "fQuiz";
            this.Load += new System.EventHandler(this.fQuiz_Load);
            this.gbProgress.ResumeLayout(false);
            this.gbQuestion.ResumeLayout(false);
            this.gbQuestion.PerformLayout();
            this.gbAnswers.ResumeLayout(false);
            this.gbAnswers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbQuestions;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox gbProgress;
        private System.Windows.Forms.RadioButton rbAnswer1;
        private System.Windows.Forms.RadioButton rbAnswer2;
        private System.Windows.Forms.RadioButton rbAnswer3;
        private System.Windows.Forms.RadioButton rbAnswer4;
        private System.Windows.Forms.GroupBox gbQuestion;
        private System.Windows.Forms.GroupBox gbAnswers;
    }
}