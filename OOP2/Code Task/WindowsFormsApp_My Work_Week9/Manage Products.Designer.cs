
namespace WindowsFormsApp_My_Work_Week9
{
    partial class Manageproducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manageproducts));
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.btnBc = new System.Windows.Forms.Button();
            this.chkAI = new System.Windows.Forms.CheckBox();
            this.chkSE = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(582, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 30);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 76);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Log In Successful";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(273, 145);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(59, 21);
            this.rbMale.TabIndex = 6;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(273, 201);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(75, 21);
            this.rbFemale.TabIndex = 7;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // btnBc
            // 
            this.btnBc.Location = new System.Drawing.Point(273, 264);
            this.btnBc.Name = "btnBc";
            this.btnBc.Size = new System.Drawing.Size(75, 23);
            this.btnBc.TabIndex = 8;
            this.btnBc.Text = "Click";
            this.btnBc.UseVisualStyleBackColor = true;
            this.btnBc.Click += new System.EventHandler(this.btnBc_Click);
            // 
            // chkAI
            // 
            this.chkAI.AutoSize = true;
            this.chkAI.Location = new System.Drawing.Point(433, 145);
            this.chkAI.Name = "chkAI";
            this.chkAI.Size = new System.Drawing.Size(42, 21);
            this.chkAI.TabIndex = 9;
            this.chkAI.Text = "AI";
            this.chkAI.UseVisualStyleBackColor = true;
            // 
            // chkSE
            // 
            this.chkSE.AutoSize = true;
            this.chkSE.Location = new System.Drawing.Point(433, 201);
            this.chkSE.Name = "chkSE";
            this.chkSE.Size = new System.Drawing.Size(48, 21);
            this.chkSE.TabIndex = 10;
            this.chkSE.Text = "SE";
            this.chkSE.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(414, 240);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 11;
            // 
            // Manageproducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.chkSE);
            this.Controls.Add(this.chkAI);
            this.Controls.Add(this.btnBc);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Name = "Manageproducts";
            this.Text = "Manage_Products";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Button btnBc;
        private System.Windows.Forms.CheckBox chkAI;
        private System.Windows.Forms.CheckBox chkSE;
        private System.Windows.Forms.ListBox listBox1;
    }
}