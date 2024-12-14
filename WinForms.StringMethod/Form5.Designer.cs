namespace WinForms.StringMethod
{
    partial class Form5
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
            txtInputArray = new TextBox();
            btnCalculateFor = new Button();
            btnCalculateForeach = new Button();
            lblResultFor = new Label();
            lblResultForeach = new Label();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // txtInputArray
            // 
            txtInputArray.Location = new Point(65, 325);
            txtInputArray.Multiline = true;
            txtInputArray.Name = "txtInputArray";
            txtInputArray.Size = new Size(212, 61);
            txtInputArray.TabIndex = 0;
            // 
            // btnCalculateFor
            // 
            btnCalculateFor.Location = new Point(12, 100);
            btnCalculateFor.Name = "btnCalculateFor";
            btnCalculateFor.Size = new Size(110, 125);
            btnCalculateFor.TabIndex = 1;
            btnCalculateFor.Text = "คำนวณแบบ For";
            btnCalculateFor.UseVisualStyleBackColor = true;
            btnCalculateFor.Click += btnCalculateFor_Click;
            // 
            // btnCalculateForeach
            // 
            btnCalculateForeach.Location = new Point(227, 100);
            btnCalculateForeach.Name = "btnCalculateForeach";
            btnCalculateForeach.Size = new Size(123, 125);
            btnCalculateForeach.TabIndex = 2;
            btnCalculateForeach.Text = "คำนวณแบบ Foreach";
            btnCalculateForeach.UseVisualStyleBackColor = true;
            btnCalculateForeach.Click += btnCalculateForeach_Click;
            // 
            // lblResultFor
            // 
            lblResultFor.AutoSize = true;
            lblResultFor.Location = new Point(27, 68);
            lblResultFor.Name = "lblResultFor";
            lblResultFor.Size = new Size(83, 15);
            lblResultFor.TabIndex = 3;
            lblResultFor.Text = "ผลลัพธ์แบบ For:";
            // 
            // lblResultForeach
            // 
            lblResultForeach.AutoSize = true;
            lblResultForeach.Location = new Point(242, 68);
            lblResultForeach.Name = "lblResultForeach";
            lblResultForeach.Size = new Size(108, 15);
            lblResultForeach.TabIndex = 4;
            lblResultForeach.Text = "ผลลัพธ์แบบ Foreach:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(123, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(118, 15);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "โปรแกรมคำนวณค่าเฉลี่ย";
            lblTitle.Click += label3_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(379, 450);
            Controls.Add(lblTitle);
            Controls.Add(lblResultForeach);
            Controls.Add(lblResultFor);
            Controls.Add(btnCalculateForeach);
            Controls.Add(btnCalculateFor);
            Controls.Add(txtInputArray);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInputArray;
        private Button btnCalculateFor;
        private Button btnCalculateForeach;
        private Label lblResultFor;
        private Label lblResultForeach;
        private Label lblTitle;
    }
}