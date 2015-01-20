namespace Polynomial
{
    partial class Polynomial
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
            this.Intro_label = new System.Windows.Forms.Label();
            this.Choose_polynomial = new System.Windows.Forms.Label();
            this.Polynomial_list = new System.Windows.Forms.ListBox();
            this.x_value = new System.Windows.Forms.Label();
            this.x_value_input = new System.Windows.Forms.TextBox();
            this.Evaluate = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Intro_label
            // 
            this.Intro_label.AutoSize = true;
            this.Intro_label.Location = new System.Drawing.Point(28, 26);
            this.Intro_label.Name = "Intro_label";
            this.Intro_label.Size = new System.Drawing.Size(253, 13);
            this.Intro_label.TabIndex = 0;
            this.Intro_label.Text = "This program evaulates a polynomial for a variable x.";
            // 
            // Choose_polynomial
            // 
            this.Choose_polynomial.AutoSize = true;
            this.Choose_polynomial.Location = new System.Drawing.Point(31, 72);
            this.Choose_polynomial.Name = "Choose_polynomial";
            this.Choose_polynomial.Size = new System.Drawing.Size(107, 13);
            this.Choose_polynomial.TabIndex = 1;
            this.Choose_polynomial.Text = "Choose a polynomial:";
            // 
            // Polynomial_list
            // 
            this.Polynomial_list.FormattingEnabled = true;
            this.Polynomial_list.Location = new System.Drawing.Point(145, 72);
            this.Polynomial_list.Name = "Polynomial_list";
            this.Polynomial_list.Size = new System.Drawing.Size(155, 56);
            this.Polynomial_list.TabIndex = 2;
            this.Polynomial_list.SelectedIndexChanged += new System.EventHandler(this.Polynomial_list_SelectedIndexChanged);
            // 
            // x_value
            // 
            this.x_value.AutoSize = true;
            this.x_value.Location = new System.Drawing.Point(34, 145);
            this.x_value.Name = "x_value";
            this.x_value.Size = new System.Drawing.Size(96, 13);
            this.x_value.TabIndex = 3;
            this.x_value.Text = "Enter a value for x:";
            // 
            // x_value_input
            // 
            this.x_value_input.Location = new System.Drawing.Point(145, 145);
            this.x_value_input.Name = "x_value_input";
            this.x_value_input.Size = new System.Drawing.Size(100, 20);
            this.x_value_input.TabIndex = 4;
            this.x_value_input.TextChanged += new System.EventHandler(this.x_value_input_TextChanged);
            // 
            // Evaluate
            // 
            this.Evaluate.Location = new System.Drawing.Point(37, 194);
            this.Evaluate.Name = "Evaluate";
            this.Evaluate.Size = new System.Drawing.Size(75, 23);
            this.Evaluate.TabIndex = 5;
            this.Evaluate.Text = "Evaluate";
            this.Evaluate.UseVisualStyleBackColor = true;
            this.Evaluate.Click += new System.EventHandler(this.Evaluate_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(225, 237);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(142, 262);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 13);
            this.Result.TabIndex = 7;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(142, 199);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(37, 13);
            this.ResultLabel.TabIndex = 8;
            this.ResultLabel.Text = "Result";
            // 
            // Polynomial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 280);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Evaluate);
            this.Controls.Add(this.x_value_input);
            this.Controls.Add(this.x_value);
            this.Controls.Add(this.Polynomial_list);
            this.Controls.Add(this.Choose_polynomial);
            this.Controls.Add(this.Intro_label);
            this.Name = "Polynomial";
            this.Text = "Polynomial evaluation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Intro_label;
        private System.Windows.Forms.Label Choose_polynomial;
        private System.Windows.Forms.ListBox Polynomial_list;
        private System.Windows.Forms.Label x_value;
        private System.Windows.Forms.TextBox x_value_input;
        private System.Windows.Forms.Button Evaluate;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label ResultLabel;
    }
}

