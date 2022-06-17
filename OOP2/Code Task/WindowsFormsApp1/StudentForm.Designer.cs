
namespace WindowsFormsApp1
{
    partial class StudentForm
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
            this.lbName = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.ListInfo = new System.Windows.Forms.ListBox();
            this.lbId = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lbCgpa = new System.Windows.Forms.Label();
            this.txtcgpa = new System.Windows.Forms.TextBox();
            this.txtprogram = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.lbProgram = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.btnClick = new System.Windows.Forms.Button();
            this.lbGender = new System.Windows.Forms.Label();
            this.chkAI = new System.Windows.Forms.CheckBox();
            this.chkSE = new System.Windows.Forms.CheckBox();
            this.btnTick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(30, 28);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(45, 17);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(97, 28);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 22);
            this.txtname.TabIndex = 1;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(98, 251);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // ListInfo
            // 
            this.ListInfo.FormattingEnabled = true;
            this.ListInfo.ItemHeight = 16;
            this.ListInfo.Location = new System.Drawing.Point(246, 28);
            this.ListInfo.Name = "ListInfo";
            this.ListInfo.Size = new System.Drawing.Size(120, 84);
            this.ListInfo.TabIndex = 3;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(30, 73);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(19, 17);
            this.lbId.TabIndex = 4;
            this.lbId.Text = "Id";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(97, 73);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 22);
            this.txtid.TabIndex = 5;
            // 
            // lbCgpa
            // 
            this.lbCgpa.AutoSize = true;
            this.lbCgpa.Location = new System.Drawing.Point(30, 109);
            this.lbCgpa.Name = "lbCgpa";
            this.lbCgpa.Size = new System.Drawing.Size(41, 17);
            this.lbCgpa.TabIndex = 6;
            this.lbCgpa.Text = "Cgpa";
            // 
            // txtcgpa
            // 
            this.txtcgpa.Location = new System.Drawing.Point(97, 109);
            this.txtcgpa.Multiline = true;
            this.txtcgpa.Name = "txtcgpa";
            this.txtcgpa.Size = new System.Drawing.Size(100, 22);
            this.txtcgpa.TabIndex = 7;
            // 
            // txtprogram
            // 
            this.txtprogram.Location = new System.Drawing.Point(98, 206);
            this.txtprogram.Multiline = true;
            this.txtprogram.Name = "txtprogram";
            this.txtprogram.Size = new System.Drawing.Size(100, 22);
            this.txtprogram.TabIndex = 8;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(97, 159);
            this.txtage.Multiline = true;
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(100, 22);
            this.txtage.TabIndex = 9;
            // 
            // lbProgram
            // 
            this.lbProgram.AutoSize = true;
            this.lbProgram.Location = new System.Drawing.Point(30, 206);
            this.lbProgram.Name = "lbProgram";
            this.lbProgram.Size = new System.Drawing.Size(62, 17);
            this.lbProgram.TabIndex = 10;
            this.lbProgram.Text = "Program";
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Location = new System.Drawing.Point(30, 159);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(33, 17);
            this.lbAge.TabIndex = 11;
            this.lbAge.Text = "Age";
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(237, 170);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(59, 21);
            this.rbtnMale.TabIndex = 12;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(237, 207);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(75, 21);
            this.rbtnFemale.TabIndex = 13;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(237, 251);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(75, 23);
            this.btnClick.TabIndex = 14;
            this.btnClick.Text = "Click";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(234, 137);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(56, 17);
            this.lbGender.TabIndex = 15;
            this.lbGender.Text = "Gender";
            // 
            // chkAI
            // 
            this.chkAI.AutoSize = true;
            this.chkAI.Location = new System.Drawing.Point(361, 171);
            this.chkAI.Name = "chkAI";
            this.chkAI.Size = new System.Drawing.Size(42, 21);
            this.chkAI.TabIndex = 16;
            this.chkAI.Text = "AI";
            this.chkAI.UseVisualStyleBackColor = true;
            // 
            // chkSE
            // 
            this.chkSE.AutoSize = true;
            this.chkSE.Location = new System.Drawing.Point(361, 208);
            this.chkSE.Name = "chkSE";
            this.chkSE.Size = new System.Drawing.Size(48, 21);
            this.chkSE.TabIndex = 17;
            this.chkSE.Text = "SE";
            this.chkSE.UseVisualStyleBackColor = true;
            // 
            // btnTick
            // 
            this.btnTick.Location = new System.Drawing.Point(361, 251);
            this.btnTick.Name = "btnTick";
            this.btnTick.Size = new System.Drawing.Size(75, 23);
            this.btnTick.TabIndex = 18;
            this.btnTick.Text = "Tick";
            this.btnTick.UseVisualStyleBackColor = true;
            this.btnTick.Click += new System.EventHandler(this.btnTick_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 366);
            this.Controls.Add(this.btnTick);
            this.Controls.Add(this.chkSE);
            this.Controls.Add(this.chkAI);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.rbtnFemale);
            this.Controls.Add(this.rbtnMale);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.lbProgram);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.txtprogram);
            this.Controls.Add(this.txtcgpa);
            this.Controls.Add(this.lbCgpa);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.ListInfo);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lbName);
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ListBox ListInfo;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lbCgpa;
        private System.Windows.Forms.TextBox txtcgpa;
        private System.Windows.Forms.TextBox txtprogram;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Label lbProgram;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.CheckBox chkAI;
        private System.Windows.Forms.CheckBox chkSE;
        private System.Windows.Forms.Button btnTick;
    }
}

