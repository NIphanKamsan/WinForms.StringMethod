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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // Form1
            // 
            Form1.BackColor = Color.LimeGreen;
            Form1.Location = new Point(41, 55);
            Form1.Name = "Form1";
            Form1.Size = new Size(147, 63);
            Form1.TabIndex = 0;
            Form1.Text = "Last name program";
            Form1.UseVisualStyleBackColor = false;
            Form1.Click += Form1_Click;
            // 
            // Form2
            // 
            Form2.BackColor = Color.Yellow;
            Form2.Location = new Point(41, 263);
            Form2.Name = "Form2";
            Form2.Size = new Size(147, 60);
            Form2.TabIndex = 1;
            Form2.Text = "Calculation";
            Form2.UseVisualStyleBackColor = false;
            Form2.Click += Form2_Click;
            // 
            // Form3
            // 
            Form3.BackColor = Color.Red;
            Form3.Location = new Point(41, 124);
            Form3.Name = "Form3";
            Form3.Size = new Size(147, 61);
            Form3.TabIndex = 2;
            Form3.Text = "Return Value Method";
            Form3.UseVisualStyleBackColor = false;
            Form3.Click += Form3_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(41, 192);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(147, 64);
            button1.TabIndex = 3;
            button1.Text = "Array";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 0);
            button2.Location = new Point(41, 330);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(147, 59);
            button2.TabIndex = 4;
            button2.Text = "Sort by";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(224, 411);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Form3);
            Controls.Add(Form2);
            Controls.Add(Form1);
            Name = "Form4";
            Text = "RUN.DB";
            Load += Form4_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Form1;
        private Button Form2;
        private Button Form3;
        private Button button1;
        private Button button2;
    }
}