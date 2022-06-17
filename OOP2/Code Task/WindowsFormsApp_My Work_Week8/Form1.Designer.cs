
namespace WindowsFormsApp_My_Work_Week8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnClick = new System.Windows.Forms.Button();
            this.lbNumber1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.lb1Result = new System.Windows.Forms.Label();
            this.btnClick1 = new System.Windows.Forms.Button();
            this.btClick2 = new System.Windows.Forms.Button();
            this.btClick3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(12, 233);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(82, 30);
            this.btnClick.TabIndex = 0;
            this.btnClick.Text = "Add";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // lbNumber1
            // 
            this.lbNumber1.AutoSize = true;
            this.lbNumber1.Location = new System.Drawing.Point(90, 72);
            this.lbNumber1.Name = "lbNumber1";
            this.lbNumber1.Size = new System.Drawing.Size(66, 17);
            this.lbNumber1.TabIndex = 1;
            this.lbNumber1.Text = "Number1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number2";
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(206, 69);
            this.txtNumber1.Multiline = true;
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(106, 29);
            this.txtNumber1.TabIndex = 3;
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(206, 118);
            this.txtNumber2.Multiline = true;
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(106, 29);
            this.txtNumber2.TabIndex = 4;
            // 
            // lb1Result
            // 
            this.lb1Result.AutoSize = true;
            this.lb1Result.Location = new System.Drawing.Point(229, 171);
            this.lb1Result.Name = "lb1Result";
            this.lb1Result.Size = new System.Drawing.Size(48, 17);
            this.lb1Result.TabIndex = 5;
            this.lb1Result.Text = "Result";
            // 
            // btnClick1
            // 
            this.btnClick1.Location = new System.Drawing.Point(109, 233);
            this.btnClick1.Name = "btnClick1";
            this.btnClick1.Size = new System.Drawing.Size(82, 30);
            this.btnClick1.TabIndex = 6;
            this.btnClick1.Text = "Subtract";
            this.btnClick1.UseVisualStyleBackColor = true;
            this.btnClick1.Click += new System.EventHandler(this.btnClick1_Click);
            // 
            // btClick2
            // 
            this.btClick2.Location = new System.Drawing.Point(206, 233);
            this.btClick2.Name = "btClick2";
            this.btClick2.Size = new System.Drawing.Size(82, 30);
            this.btClick2.TabIndex = 7;
            this.btClick2.Text = "Multiply";
            this.btClick2.UseVisualStyleBackColor = true;
            this.btClick2.Click += new System.EventHandler(this.btClick2_Click);
            // 
            // btClick3
            // 
            this.btClick3.Location = new System.Drawing.Point(304, 233);
            this.btClick3.Name = "btClick3";
            this.btClick3.Size = new System.Drawing.Size(82, 30);
            this.btClick3.TabIndex = 8;
            this.btClick3.Text = "Divide";
            this.btClick3.UseVisualStyleBackColor = true;
            this.btClick3.Click += new System.EventHandler(this.btClick3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(577, 371);
            this.Controls.Add(this.btClick3);
            this.Controls.Add(this.btClick2);
            this.Controls.Add(this.btnClick1);
            this.Controls.Add(this.lb1Result);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNumber1);
            this.Controls.Add(this.btnClick);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Label lbNumber1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.Label lb1Result;
        private System.Windows.Forms.Button btnClick1;
        private System.Windows.Forms.Button btClick2;
        private System.Windows.Forms.Button btClick3;
    }
}

