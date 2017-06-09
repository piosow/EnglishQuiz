namespace EnglishQuiz
{
    partial class fMain
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
            this.txtNick = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bStart = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.lbCategories = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj nick:";
            // 
            // txtNick
            // 
            this.txtNick.Location = new System.Drawing.Point(15, 25);
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(203, 20);
            this.txtNick.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wybierz kategorię:";
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(12, 177);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(206, 23);
            this.bStart.TabIndex = 4;
            this.bStart.Text = "R O Z P O C Z N I J";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(12, 206);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(206, 23);
            this.bExit.TabIndex = 5;
            this.bExit.Text = "Wyjdź";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // lbCategories
            // 
            this.lbCategories.FormattingEnabled = true;
            this.lbCategories.Location = new System.Drawing.Point(12, 74);
            this.lbCategories.Name = "lbCategories";
            this.lbCategories.Size = new System.Drawing.Size(206, 95);
            this.lbCategories.TabIndex = 6;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(230, 240);
            this.ControlBox = false;
            this.Controls.Add(this.lbCategories);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNick);
            this.Controls.Add(this.label1);
            this.Name = "fMain";
            this.ShowIcon = false;
            this.Text = "EnglishQuiz";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.ListBox lbCategories;
    }
}

