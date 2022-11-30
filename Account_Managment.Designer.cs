
namespace ATM_Project
{
    partial class Account_Managment
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
            this.back_btn = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.withdraw_btn = new System.Windows.Forms.Button();
            this.balance_btn = new System.Windows.Forms.Button();
            this.lodge_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(38, 386);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(125, 52);
            this.back_btn.TabIndex = 0;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.Location = new System.Drawing.Point(644, 386);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(123, 52);
            this.logout_btn.TabIndex = 1;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.withdraw_btn);
            this.groupBox1.Controls.Add(this.balance_btn);
            this.groupBox1.Controls.Add(this.lodge_btn);
            this.groupBox1.Location = new System.Drawing.Point(38, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 368);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // withdraw_btn
            // 
            this.withdraw_btn.Location = new System.Drawing.Point(437, 242);
            this.withdraw_btn.Name = "withdraw_btn";
            this.withdraw_btn.Size = new System.Drawing.Size(268, 60);
            this.withdraw_btn.TabIndex = 6;
            this.withdraw_btn.Text = "Withdraw";
            this.withdraw_btn.UseVisualStyleBackColor = true;
            this.withdraw_btn.Click += new System.EventHandler(this.withdraw_btn_Click);
            // 
            // balance_btn
            // 
            this.balance_btn.Location = new System.Drawing.Point(437, 162);
            this.balance_btn.Name = "balance_btn";
            this.balance_btn.Size = new System.Drawing.Size(268, 62);
            this.balance_btn.TabIndex = 7;
            this.balance_btn.Text = "Check Balance";
            this.balance_btn.UseVisualStyleBackColor = true;
            this.balance_btn.Click += new System.EventHandler(this.balance_btn_Click);
            // 
            // lodge_btn
            // 
            this.lodge_btn.Location = new System.Drawing.Point(437, 79);
            this.lodge_btn.Name = "lodge_btn";
            this.lodge_btn.Size = new System.Drawing.Size(268, 63);
            this.lodge_btn.TabIndex = 8;
            this.lodge_btn.Text = "Lodgements";
            this.lodge_btn.UseVisualStyleBackColor = true;
            this.lodge_btn.Click += new System.EventHandler(this.lodge_btn_Click);
            // 
            // Account_Managment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.back_btn);
            this.Name = "Account_Managment";
            this.Text = "Account_Managment";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button withdraw_btn;
        private System.Windows.Forms.Button balance_btn;
        private System.Windows.Forms.Button lodge_btn;
    }
}