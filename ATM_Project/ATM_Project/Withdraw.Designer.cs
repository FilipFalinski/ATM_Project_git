
namespace ATM_Project
{
    partial class Withdraw
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Amount_txt = new System.Windows.Forms.TextBox();
            this.grnad_btn = new System.Windows.Forms.Button();
            this.fiveHundred_btn = new System.Windows.Forms.Button();
            this.twoHundred_btn = new System.Windows.Forms.Button();
            this.fifty_btn = new System.Windows.Forms.Button();
            this.hundred_btn = new System.Windows.Forms.Button();
            this.Twenty_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.withdraw_Btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Amount_txt);
            this.groupBox1.Controls.Add(this.grnad_btn);
            this.groupBox1.Controls.Add(this.fiveHundred_btn);
            this.groupBox1.Controls.Add(this.twoHundred_btn);
            this.groupBox1.Controls.Add(this.fifty_btn);
            this.groupBox1.Controls.Add(this.hundred_btn);
            this.groupBox1.Controls.Add(this.Twenty_btn);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 355);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cash";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Amount";
            // 
            // Amount_txt
            // 
            this.Amount_txt.Location = new System.Drawing.Point(306, 278);
            this.Amount_txt.Name = "Amount_txt";
            this.Amount_txt.Size = new System.Drawing.Size(158, 27);
            this.Amount_txt.TabIndex = 5;
            this.Amount_txt.TextChanged += new System.EventHandler(this.Amount_txt_TextChanged);
            // 
            // grnad_btn
            // 
            this.grnad_btn.Location = new System.Drawing.Point(565, 248);
            this.grnad_btn.Name = "grnad_btn";
            this.grnad_btn.Size = new System.Drawing.Size(128, 57);
            this.grnad_btn.TabIndex = 4;
            this.grnad_btn.Text = "1,000";
            this.grnad_btn.UseVisualStyleBackColor = true;
            this.grnad_btn.Click += new System.EventHandler(this.grnad_btn_Click);
            // 
            // fiveHundred_btn
            // 
            this.fiveHundred_btn.Location = new System.Drawing.Point(565, 147);
            this.fiveHundred_btn.Name = "fiveHundred_btn";
            this.fiveHundred_btn.Size = new System.Drawing.Size(128, 60);
            this.fiveHundred_btn.TabIndex = 3;
            this.fiveHundred_btn.Text = "500";
            this.fiveHundred_btn.UseVisualStyleBackColor = true;
            this.fiveHundred_btn.Click += new System.EventHandler(this.fiveHundred_btn_Click);
            // 
            // twoHundred_btn
            // 
            this.twoHundred_btn.Location = new System.Drawing.Point(565, 54);
            this.twoHundred_btn.Name = "twoHundred_btn";
            this.twoHundred_btn.Size = new System.Drawing.Size(128, 56);
            this.twoHundred_btn.TabIndex = 2;
            this.twoHundred_btn.Text = "200";
            this.twoHundred_btn.UseVisualStyleBackColor = true;
            this.twoHundred_btn.Click += new System.EventHandler(this.twoHundred_btn_Click);
            // 
            // fifty_btn
            // 
            this.fifty_btn.Location = new System.Drawing.Point(54, 147);
            this.fifty_btn.Name = "fifty_btn";
            this.fifty_btn.Size = new System.Drawing.Size(138, 60);
            this.fifty_btn.TabIndex = 1;
            this.fifty_btn.Text = "50";
            this.fifty_btn.UseVisualStyleBackColor = true;
            this.fifty_btn.Click += new System.EventHandler(this.fifty_btn_Click);
            // 
            // hundred_btn
            // 
            this.hundred_btn.Location = new System.Drawing.Point(54, 248);
            this.hundred_btn.Name = "hundred_btn";
            this.hundred_btn.Size = new System.Drawing.Size(138, 57);
            this.hundred_btn.TabIndex = 1;
            this.hundred_btn.Text = "100";
            this.hundred_btn.UseVisualStyleBackColor = true;
            this.hundred_btn.Click += new System.EventHandler(this.hundred_btn_Click);
            // 
            // Twenty_btn
            // 
            this.Twenty_btn.Location = new System.Drawing.Point(54, 54);
            this.Twenty_btn.Name = "Twenty_btn";
            this.Twenty_btn.Size = new System.Drawing.Size(138, 56);
            this.Twenty_btn.TabIndex = 0;
            this.Twenty_btn.Text = "20";
            this.Twenty_btn.UseVisualStyleBackColor = true;
            this.Twenty_btn.Click += new System.EventHandler(this.Twenty_btn_Click);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Location = new System.Drawing.Point(78, 386);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(138, 39);
            this.Cancel_btn.TabIndex = 5;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // withdraw_Btn
            // 
            this.withdraw_Btn.Location = new System.Drawing.Point(589, 386);
            this.withdraw_Btn.Name = "withdraw_Btn";
            this.withdraw_Btn.Size = new System.Drawing.Size(128, 39);
            this.withdraw_Btn.TabIndex = 6;
            this.withdraw_Btn.Text = "Confrim";
            this.withdraw_Btn.UseVisualStyleBackColor = true;
            this.withdraw_Btn.Click += new System.EventHandler(this.Confirm_btn_Click);
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.withdraw_Btn);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.groupBox1);
            this.Name = "Withdraw";
            this.Text = "Withdraw";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Amount_txt;
        private System.Windows.Forms.Button grnad_btn;
        private System.Windows.Forms.Button fiveHundred_btn;
        private System.Windows.Forms.Button twoHundred_btn;
        private System.Windows.Forms.Button fifty_btn;
        private System.Windows.Forms.Button hundred_btn;
        private System.Windows.Forms.Button Twenty_btn;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.Button withdraw_Btn;
    }
}

