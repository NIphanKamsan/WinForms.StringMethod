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
            txtInputArray.Location = new Point(74, 433);
            txtInputArray.Margin = new Padding(3, 4, 3, 4);
            txtInputArray.Multiline = true;
            txtInputArray.Name = "txtInputArray";
            txtInputArray.Size = new Size(242, 80);
            txtInputArray.TabIndex = 0;
            // 
            // btnCalculateFor
            // 
            btnCalculateFor.Location = new Point(14, 133);
            btnCalculateFor.Margin = new Padding(3, 4, 3, 4);
            btnCalculateFor.Name = "btnCalculateFor";
            btnCalculateFor.Size = new Size(126, 167);
            btnCalculateFor.TabIndex = 1;
            btnCalculateFor.Text = "คำนวณแบบ For";
            btnCalculateFor.UseVisualStyleBackColor = true;
            btnCalculateFor.Click += btnCalculateFor_Click;
            // 
            // btnCalculateForeach
            // 
            btnCalculateForeach.Location = new Point(272, 133);
            btnCalculateForeach.Margin = new Padding(3, 4, 3, 4);
            btnCalculateForeach.Name = "btnCalculateForeach";
            btnCalculateForeach.Size = new Size(141, 167);
            btnCalculateForeach.TabIndex = 2;
            btnCalculateForeach.Text = "คำนวณแบบ Foreach";
            btnCalculateForeach.UseVisualStyleBackColor = true;
            btnCalculateForeach.Click += btnCalculateForeach_Click;
            // 
            // lblResultFor
            // 
            lblResultFor.AutoSize = true;
            lblResultFor.Location = new Point(35, 91);
            lblResultFor.Name = "lblResultFor";
            lblResultFor.Size = new Size(105, 20);
            lblResultFor.TabIndex = 3;
            lblResultFor.Text = "ผลลัพธ์แบบ For:";
            // 
            // lblResultForeach
            // 
            lblResultForeach.AutoSize = true;
            lblResultForeach.Location = new Point(277, 91);
            lblResultForeach.Name = "lblResultForeach";
            lblResultForeach.Size = new Size(136, 20);
            lblResultForeach.TabIndex = 4;
            lblResultForeach.Text = "ผลลัพธ์แบบ Foreach:";
            lblResultForeach.Click += lblResultForeach_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(141, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(150, 20);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "โปรแกรมคำนวณค่าเฉลี่ย";
            lblTitle.Click += label3_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(433, 600);
            Controls.Add(lblTitle);
            Controls.Add(lblResultForeach);
            Controls.Add(lblResultFor);
            Controls.Add(btnCalculateForeach);
            Controls.Add(btnCalculateFor);
            Controls.Add(txtInputArray);
            Margin = new Padding(3, 4, 3, 4);
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