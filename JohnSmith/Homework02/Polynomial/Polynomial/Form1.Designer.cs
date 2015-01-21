namespace Polynomial
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_dataentry = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_evaluate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbox_result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "3x^3 - 5x^2 + 6";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtbox_dataentry
            // 
            this.txtbox_dataentry.Location = new System.Drawing.Point(41, 38);
            this.txtbox_dataentry.Name = "txtbox_dataentry";
            this.txtbox_dataentry.Size = new System.Drawing.Size(100, 20);
            this.txtbox_dataentry.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "enter a value for x";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_evaluate
            // 
            this.btn_evaluate.Location = new System.Drawing.Point(56, 64);
            this.btn_evaluate.Name = "btn_evaluate";
            this.btn_evaluate.Size = new System.Drawing.Size(75, 23);
            this.btn_evaluate.TabIndex = 3;
            this.btn_evaluate.Text = "evaluate";
            this.btn_evaluate.UseVisualStyleBackColor = true;
            this.btn_evaluate.Click += new System.EventHandler(this.btn_evaluate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "result:";
            // 
            // txtbox_result
            // 
            this.txtbox_result.Location = new System.Drawing.Point(41, 117);
            this.txtbox_result.Name = "txtbox_result";
            this.txtbox_result.ReadOnly = true;
            this.txtbox_result.Size = new System.Drawing.Size(100, 20);
            this.txtbox_result.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 155);
            this.Controls.Add(this.txtbox_result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_evaluate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbox_dataentry);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Polynomial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_dataentry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_evaluate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbox_result;
    }
}

