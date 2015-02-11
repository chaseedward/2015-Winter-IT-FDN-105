namespace HW5_Davey
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
            this.Balance = new System.Windows.Forms.Button();
            this.BalanceBox = new System.Windows.Forms.TextBox();
            this.WithdrawlBox = new System.Windows.Forms.TextBox();
            this.DepositBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Balance
            // 
            this.Balance.Location = new System.Drawing.Point(334, 139);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(236, 39);
            this.Balance.TabIndex = 0;
            this.Balance.Text = "Click for Account Balance";
            this.Balance.UseVisualStyleBackColor = true;
            this.Balance.Click += new System.EventHandler(this.Balance_Click);
            // 
            // BalanceBox
            // 
            this.BalanceBox.Location = new System.Drawing.Point(144, 192);
            this.BalanceBox.Name = "BalanceBox";
            this.BalanceBox.Size = new System.Drawing.Size(100, 26);
            this.BalanceBox.TabIndex = 1;
            // 
            // WithdrawlBox
            // 
            this.WithdrawlBox.Location = new System.Drawing.Point(144, 133);
            this.WithdrawlBox.Name = "WithdrawlBox";
            this.WithdrawlBox.Size = new System.Drawing.Size(100, 26);
            this.WithdrawlBox.TabIndex = 2;
            this.WithdrawlBox.TextChanged += new System.EventHandler(this.WithdrawlBox_TextChanged);
            // 
            // DepositBox
            // 
            this.DepositBox.Location = new System.Drawing.Point(144, 83);
            this.DepositBox.Name = "DepositBox";
            this.DepositBox.Size = new System.Drawing.Size(100, 26);
            this.DepositBox.TabIndex = 3;
            this.DepositBox.TextChanged += new System.EventHandler(this.DepositBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Account Balance:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Withdrawl:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Deposit :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 388);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DepositBox);
            this.Controls.Add(this.WithdrawlBox);
            this.Controls.Add(this.BalanceBox);
            this.Controls.Add(this.Balance);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Balance;
        private System.Windows.Forms.TextBox BalanceBox;
        private System.Windows.Forms.TextBox WithdrawlBox;
        private System.Windows.Forms.TextBox DepositBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

