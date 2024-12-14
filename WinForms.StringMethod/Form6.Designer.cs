namespace WinForms.StringMethod
{
    partial class Form6
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
            label1 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(255, 192, 128);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(22, 352);
            label1.Name = "label1";
            label1.Size = new Size(231, 67);
            label1.TabIndex = 7;
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 192, 128);
            textBox1.Location = new Point(22, 230);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 84);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(172, 103);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 57);
            button2.TabIndex = 5;
            button2.Text = "เรียงมากไปน้อย";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Cyan;
            button1.Location = new Point(23, 103);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 57);
            button1.TabIndex = 4;
            button1.Text = "เรียงน้อยไปมาก";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(265, 450);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form6";
            Text = "Form6";
            Load += Form6_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button2;
        private Button button1;
    }
}