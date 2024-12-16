namespace WinForms.StringMethod
{
    partial class Form3
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
            btnPatternA = new Button();
            btnPatternB = new Button();
            btnPatternC = new Button();
            txtOutput = new TextBox();
            txtSize = new TextBox();
            txt12 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnPatternA
            // 
            btnPatternA.BackColor = Color.Lime;
            btnPatternA.Location = new Point(25, 13);
            btnPatternA.Margin = new Padding(3, 4, 3, 4);
            btnPatternA.Name = "btnPatternA";
            btnPatternA.Size = new Size(86, 31);
            btnPatternA.TabIndex = 0;
            btnPatternA.Text = "Pattern A";
            btnPatternA.UseVisualStyleBackColor = false;
            btnPatternA.Click += btnPatternA_Click;
            // 
            // btnPatternB
            // 
            btnPatternB.BackColor = Color.Yellow;
            btnPatternB.Location = new Point(117, 13);
            btnPatternB.Margin = new Padding(3, 4, 3, 4);
            btnPatternB.Name = "btnPatternB";
            btnPatternB.Size = new Size(86, 31);
            btnPatternB.TabIndex = 1;
            btnPatternB.Text = "Pattern B";
            btnPatternB.UseVisualStyleBackColor = false;
            btnPatternB.Click += btnPatternB_Click;
            // 
            // btnPatternC
            // 
            btnPatternC.BackColor = Color.Red;
            btnPatternC.Location = new Point(213, 13);
            btnPatternC.Margin = new Padding(3, 4, 3, 4);
            btnPatternC.Name = "btnPatternC";
            btnPatternC.Size = new Size(86, 31);
            btnPatternC.TabIndex = 2;
            btnPatternC.Text = "Pattern C";
            btnPatternC.UseVisualStyleBackColor = false;
            btnPatternC.Click += btnPatternC_Click;
            // 
            // txtOutput
            // 
            txtOutput.BackColor = SystemColors.ScrollBar;
            txtOutput.Location = new Point(25, 114);
            txtOutput.Margin = new Padding(3, 4, 3, 4);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(274, 457);
            txtOutput.TabIndex = 5;
            // 
            // txtSize
            // 
            txtSize.Location = new Point(174, 80);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(125, 27);
            txtSize.TabIndex = 7;
            txtSize.TextChanged += textBox2_TextChanged;
            // 
            // txt12
            // 
            txt12.Location = new Point(25, 80);
            txt12.Name = "txt12";
            txt12.Size = new Size(125, 27);
            txt12.TabIndex = 8;
            txt12.TextChanged += textBox1_TextChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 48);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 9;
            label1.Text = "ตัวอักษร";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(227, 48);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 10;
            label2.Text = "ขนาด";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 600);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt12);
            Controls.Add(txtSize);
            Controls.Add(txtOutput);
            Controls.Add(btnPatternC);
            Controls.Add(btnPatternB);
            Controls.Add(btnPatternA);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form3";
            Text = "Return Value Method";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPatternA;
        private Button btnPatternB;
        private Button btnPatternC;
        private TextBox txtOutput;
        private TextBox txtSize;
        private TextBox txt12;
        private Label label1;
        private Label label2;
    }
}