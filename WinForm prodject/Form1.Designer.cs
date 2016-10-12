namespace WinForm_prodject
{
    partial class Form1
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
            this.btnEducation = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tbxEducation = new System.Windows.Forms.TextBox();
            this.tbxExperience = new System.Windows.Forms.TextBox();
            this.tbxKnowlege = new System.Windows.Forms.TextBox();
            this.BtnExperience = new System.Windows.Forms.Button();
            this.BtnKnowlege = new System.Windows.Forms.Button();
            this.BtnAddEducation = new System.Windows.Forms.Button();
            this.btnAddExperience = new System.Windows.Forms.Button();
            this.BtnAddKnowlege = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEducation
            // 
            this.btnEducation.Location = new System.Drawing.Point(12, 12);
            this.btnEducation.Name = "btnEducation";
            this.btnEducation.Size = new System.Drawing.Size(75, 23);
            this.btnEducation.TabIndex = 0;
            this.btnEducation.Text = "Visa studier";
            this.btnEducation.UseVisualStyleBackColor = true;
            this.btnEducation.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(237, 186);
            this.listBox1.TabIndex = 1;
            // 
            // tbxEducation
            // 
            this.tbxEducation.Location = new System.Drawing.Point(12, 261);
            this.tbxEducation.Name = "tbxEducation";
            this.tbxEducation.Size = new System.Drawing.Size(100, 20);
            this.tbxEducation.TabIndex = 2;
            // 
            // tbxExperience
            // 
            this.tbxExperience.Location = new System.Drawing.Point(12, 305);
            this.tbxExperience.Name = "tbxExperience";
            this.tbxExperience.Size = new System.Drawing.Size(100, 20);
            this.tbxExperience.TabIndex = 3;
            // 
            // tbxKnowlege
            // 
            this.tbxKnowlege.Location = new System.Drawing.Point(12, 350);
            this.tbxKnowlege.Name = "tbxKnowlege";
            this.tbxKnowlege.Size = new System.Drawing.Size(100, 20);
            this.tbxKnowlege.TabIndex = 4;
            // 
            // BtnExperience
            // 
            this.BtnExperience.Location = new System.Drawing.Point(93, 12);
            this.BtnExperience.Name = "BtnExperience";
            this.BtnExperience.Size = new System.Drawing.Size(75, 23);
            this.BtnExperience.TabIndex = 5;
            this.BtnExperience.Text = "erfatenheter";
            this.BtnExperience.UseVisualStyleBackColor = true;
            this.BtnExperience.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnKnowlege
            // 
            this.BtnKnowlege.Location = new System.Drawing.Point(174, 12);
            this.BtnKnowlege.Name = "BtnKnowlege";
            this.BtnKnowlege.Size = new System.Drawing.Size(75, 23);
            this.BtnKnowlege.TabIndex = 6;
            this.BtnKnowlege.Text = "IT-kunskaper";
            this.BtnKnowlege.UseVisualStyleBackColor = true;
            this.BtnKnowlege.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnAddEducation
            // 
            this.BtnAddEducation.Location = new System.Drawing.Point(156, 252);
            this.BtnAddEducation.Name = "BtnAddEducation";
            this.BtnAddEducation.Size = new System.Drawing.Size(93, 37);
            this.BtnAddEducation.TabIndex = 7;
            this.BtnAddEducation.Text = "lägg till Sudie plats";
            this.BtnAddEducation.UseVisualStyleBackColor = true;
            this.BtnAddEducation.Click += new System.EventHandler(this.BtnAddEducation_Click);
            // 
            // btnAddExperience
            // 
            this.btnAddExperience.Location = new System.Drawing.Point(156, 295);
            this.btnAddExperience.Name = "btnAddExperience";
            this.btnAddExperience.Size = new System.Drawing.Size(93, 39);
            this.btnAddExperience.TabIndex = 8;
            this.btnAddExperience.Text = "lägg till erfarenheter";
            this.btnAddExperience.UseVisualStyleBackColor = true;
            this.btnAddExperience.Click += new System.EventHandler(this.btnAddExperience_Click);
            // 
            // BtnAddKnowlege
            // 
            this.BtnAddKnowlege.Location = new System.Drawing.Point(156, 341);
            this.BtnAddKnowlege.Name = "BtnAddKnowlege";
            this.BtnAddKnowlege.Size = new System.Drawing.Size(93, 37);
            this.BtnAddKnowlege.TabIndex = 9;
            this.BtnAddKnowlege.Text = "lägg till IT-kunskaper";
            this.BtnAddKnowlege.UseVisualStyleBackColor = true;
            this.BtnAddKnowlege.Click += new System.EventHandler(this.BtnAddKnowlege_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 395);
            this.Controls.Add(this.BtnAddKnowlege);
            this.Controls.Add(this.btnAddExperience);
            this.Controls.Add(this.BtnAddEducation);
            this.Controls.Add(this.BtnKnowlege);
            this.Controls.Add(this.BtnExperience);
            this.Controls.Add(this.tbxKnowlege);
            this.Controls.Add(this.tbxExperience);
            this.Controls.Add(this.tbxEducation);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnEducation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEducation;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tbxEducation;
        private System.Windows.Forms.TextBox tbxExperience;
        private System.Windows.Forms.TextBox tbxKnowlege;
        private System.Windows.Forms.Button BtnExperience;
        private System.Windows.Forms.Button BtnKnowlege;
        private System.Windows.Forms.Button BtnAddEducation;
        private System.Windows.Forms.Button btnAddExperience;
        private System.Windows.Forms.Button BtnAddKnowlege;
    }
}

