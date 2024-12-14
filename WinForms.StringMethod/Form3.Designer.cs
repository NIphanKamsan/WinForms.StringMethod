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
            SuspendLayout();
            // 
            // btnPatternA
            // 
            btnPatternA.BackColor = Color.Lime;
            btnPatternA.Location = new Point(22, 29);
            btnPatternA.Name = "btnPatternA";
            btnPatternA.Size = new Size(75, 23);
            btnPatternA.TabIndex = 0;
            btnPatternA.Text = "Pattern A";
            btnPatternA.UseVisualStyleBackColor = false;
            btnPatternA.Click += btnPatternA_Click;
            // 
            // btnPatternB
            // 
            btnPatternB.BackColor = Color.Yellow;
            btnPatternB.Location = new Point(106, 29);
            btnPatternB.Name = "btnPatternB";
            btnPatternB.Size = new Size(75, 23);
            btnPatternB.TabIndex = 1;
            btnPatternB.Text = "Pattern B";
            btnPatternB.UseVisualStyleBackColor = false;
            btnPatternB.Click += btnPatternB_Click;
            // 
            // btnPatternC
            // 
            btnPatternC.BackColor = Color.Red;
            btnPatternC.Location = new Point(187, 29);
            btnPatternC.Name = "btnPatternC";
            btnPatternC.Size = new Size(75, 23);
            btnPatternC.TabIndex = 2;
            btnPatternC.Text = "Pattern C";
            btnPatternC.UseVisualStyleBackColor = false;
            btnPatternC.Click += btnPatternC_Click;
            // 
            // txtOutput
            // 
            txtOutput.BackColor = SystemColors.ScrollBar;
            txtOutput.Location = new Point(22, 70);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(240, 344);
            txtOutput.TabIndex = 5;
            txtOutput.TextChanged += txtOutput_TextChanged;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 450);
            Controls.Add(txtOutput);
            Controls.Add(btnPatternC);
            Controls.Add(btnPatternB);
            Controls.Add(btnPatternA);
            Name = "Form3";
            Text = "Return Value Method";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPatternA;
        private Button btnPatternB;
        private Button btnPatternC;
        private TextBox txtOutput;
    }
}