namespace Hello_World_Extra_Credit
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
            this.insertText = new System.Windows.Forms.Button();
            this.displayText = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // insertText
            // 
            this.insertText.Location = new System.Drawing.Point(36, 15);
            this.insertText.Name = "insertText";
            this.insertText.Size = new System.Drawing.Size(75, 23);
            this.insertText.TabIndex = 0;
            this.insertText.Text = "Press me";
            this.insertText.UseVisualStyleBackColor = true;
            this.insertText.Click += new System.EventHandler(this.button1_Click);
            // 
            // displayText
            // 
            this.displayText.Font = new System.Drawing.Font("MS Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayText.Location = new System.Drawing.Point(36, 55);
            this.displayText.Multiline = true;
            this.displayText.Name = "displayText";
            this.displayText.Size = new System.Drawing.Size(236, 147);
            this.displayText.TabIndex = 1;
            this.displayText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.displayText);
            this.Controls.Add(this.insertText);
            this.Name = "Form1";
            this.Text = "Hello World Extra Credit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button insertText;
        private System.Windows.Forms.TextBox displayText;
        private System.Windows.Forms.Button button2;
    }
}

