
namespace ATMProject
{
    partial class frmDashBoard
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
            this.BtnBalance = new System.Windows.Forms.Button();
            this.bntWithdraw = new System.Windows.Forms.Button();
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.BtnDeposit = new System.Windows.Forms.Button();
            this.Account_Managment_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnBalance
            // 
            this.BtnBalance.Location = new System.Drawing.Point(733, 178);
            this.BtnBalance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnBalance.Name = "BtnBalance";
            this.BtnBalance.Size = new System.Drawing.Size(195, 88);
            this.BtnBalance.TabIndex = 0;
            this.BtnBalance.Text = "Check Balance";
            this.BtnBalance.UseVisualStyleBackColor = true;
            this.BtnBalance.Click += new System.EventHandler(this.BtnBalance_Click);
            // 
            // bntWithdraw
            // 
            this.bntWithdraw.Location = new System.Drawing.Point(48, 178);
            this.bntWithdraw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bntWithdraw.Name = "bntWithdraw";
            this.bntWithdraw.Size = new System.Drawing.Size(195, 88);
            this.bntWithdraw.TabIndex = 1;
            this.bntWithdraw.Text = "Withdraw";
            this.bntWithdraw.UseVisualStyleBackColor = true;
            this.bntWithdraw.Click += new System.EventHandler(this.bntWithdraw_Click);
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.Location = new System.Drawing.Point(733, 432);
            this.BtnLogOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(195, 88);
            this.BtnLogOut.TabIndex = 2;
            this.BtnLogOut.Text = "LogOut";
            this.BtnLogOut.UseVisualStyleBackColor = true;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // BtnDeposit
            // 
            this.BtnDeposit.Location = new System.Drawing.Point(48, 432);
            this.BtnDeposit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnDeposit.Name = "BtnDeposit";
            this.BtnDeposit.Size = new System.Drawing.Size(195, 88);
            this.BtnDeposit.TabIndex = 3;
            this.BtnDeposit.Text = "Deposit";
            this.BtnDeposit.UseVisualStyleBackColor = true;
            this.BtnDeposit.Click += new System.EventHandler(this.BtnDeposit_Click);
            // 
            // Account_Managment_Btn
            // 
            this.Account_Managment_Btn.Location = new System.Drawing.Point(401, 309);
            this.Account_Managment_Btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Account_Managment_Btn.Name = "Account_Managment_Btn";
            this.Account_Managment_Btn.Size = new System.Drawing.Size(195, 88);
            this.Account_Managment_Btn.TabIndex = 4;
            this.Account_Managment_Btn.Text = "Account Managment";
            this.Account_Managment_Btn.UseVisualStyleBackColor = true;
            this.Account_Managment_Btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1067, 692);
            this.Controls.Add(this.Account_Managment_Btn);
            this.Controls.Add(this.BtnDeposit);
            this.Controls.Add(this.BtnLogOut);
            this.Controls.Add(this.bntWithdraw);
            this.Controls.Add(this.BtnBalance);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDashBoard";
            this.Text = "DashBoard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnBalance;
        private System.Windows.Forms.Button bntWithdraw;
        private System.Windows.Forms.Button BtnLogOut;
        private System.Windows.Forms.Button BtnDeposit;
        private System.Windows.Forms.Button Account_Managment_Btn;
    }
}

