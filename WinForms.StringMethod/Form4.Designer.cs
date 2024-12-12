namespace WinForms.StringMethod
{
    partial class Form4
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
            Form1 = new Button();
            Form2 = new Button();
            Form3 = new Button();
            SuspendLayout();
            // 
            // Form1
            // 
            Form1.BackColor = Color.FromArgb(0, 192, 192);
            Form1.Location = new Point(324, 72);
            Form1.Name = "Form1";
            Form1.Size = new Size(114, 46);
            Form1.TabIndex = 0;
            Form1.Text = "Form1 29";
            Form1.UseVisualStyleBackColor = false;
            Form1.Click += Form1_Click;
            // 
            // Form2
            // 
            Form2.BackColor = Color.Cyan;
            Form2.Location = new Point(324, 150);
            Form2.Name = "Form2";
            Form2.Size = new Size(114, 47);
            Form2.TabIndex = 1;
            Form2.Text = "Form2 30";
            Form2.UseVisualStyleBackColor = false;
            Form2.Click += Form2_Click;
            // 
            // Form3
            // 
            Form3.BackColor = Color.MediumTurquoise;
            Form3.Location = new Point(324, 238);
            Form3.Name = "Form3";
            Form3.Size = new Size(114, 47);
            Form3.TabIndex = 2;
            Form3.Text = "Form3 31";
            Form3.UseVisualStyleBackColor = false;
            Form3.Click += Form3_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Form3);
            Controls.Add(Form2);
            Controls.Add(Form1);
            Name = "Form4";
            Text = "RUN.DB";
            ResumeLayout(false);
        }

        #endregion

        private Button Form1;
        private Button Form2;
        private Button Form3;
    }
}