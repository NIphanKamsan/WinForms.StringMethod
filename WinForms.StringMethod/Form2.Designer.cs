namespace WinForms.StringMethod
{
    partial class Form2
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
            btnCalculate = new Button();
            txtWeight = new TextBox();
            txtHeight = new TextBox();
            txtAge = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblResult = new Label();
            label4 = new Label();
            btnCalculate2 = new Button();
            label3 = new Label();
            CalculateButton = new Button();
            BaseTextBox = new TextBox();
            HeightTextBox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            ResultLabel = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(154, 220);
            btnCalculate.Margin = new Padding(3, 2, 3, 2);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(137, 26);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "คำนวณค่า bmr ผู้ชาย";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(90, 79);
            txtWeight.Margin = new Padding(3, 2, 3, 2);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(110, 23);
            txtWeight.TabIndex = 1;
            txtWeight.TextChanged += txtWeight_TextChanged;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(90, 119);
            txtHeight.Margin = new Padding(3, 2, 3, 2);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(110, 23);
            txtHeight.TabIndex = 2;
            txtHeight.TextChanged += txtHeight_TextChanged;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(90, 159);
            txtAge.Margin = new Padding(3, 2, 3, 2);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(110, 23);
            txtAge.TabIndex = 3;
            txtAge.TextChanged += txtAge_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 142);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 4;
            label1.Text = "อายุ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 62);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 5;
            label2.Text = "น้ำหนัก";
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.FromArgb(224, 224, 224);
            lblResult.Location = new Point(67, 263);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(148, 47);
            lblResult.TabIndex = 6;
            lblResult.TextAlign = ContentAlignment.TopCenter;
            lblResult.Click += lblResult_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 101);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 7;
            label4.Text = "เซนติเมตร";
            // 
            // btnCalculate2
            // 
            btnCalculate2.Location = new Point(10, 220);
            btnCalculate2.Margin = new Padding(3, 2, 3, 2);
            btnCalculate2.Name = "btnCalculate2";
            btnCalculate2.Size = new Size(130, 26);
            btnCalculate2.TabIndex = 8;
            btnCalculate2.Text = "คำนวณค่า bmr ผู้หญิง";
            btnCalculate2.UseVisualStyleBackColor = true;
            btnCalculate2.Click += btnCalculate2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 28);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 9;
            label3.Text = "คำนวณ BMR";
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(516, 158);
            CalculateButton.Margin = new Padding(3, 2, 3, 2);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(178, 22);
            CalculateButton.TabIndex = 10;
            CalculateButton.Text = "คำนวณ พื้นที่สี่เหลี่ยมขนมเปียกปูน";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // BaseTextBox
            // 
            BaseTextBox.Location = new Point(550, 79);
            BaseTextBox.Margin = new Padding(3, 2, 3, 2);
            BaseTextBox.Name = "BaseTextBox";
            BaseTextBox.Size = new Size(110, 23);
            BaseTextBox.TabIndex = 11;
            // 
            // HeightTextBox
            // 
            HeightTextBox.Location = new Point(550, 119);
            HeightTextBox.Margin = new Padding(3, 2, 3, 2);
            HeightTextBox.Name = "HeightTextBox";
            HeightTextBox.Size = new Size(110, 23);
            HeightTextBox.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(550, 62);
            label5.Name = "label5";
            label5.Size = new Size(25, 15);
            label5.TabIndex = 13;
            label5.Text = "ฐาน";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(550, 102);
            label6.Name = "label6";
            label6.Size = new Size(21, 15);
            label6.TabIndex = 14;
            label6.Text = "สูง ";
            // 
            // ResultLabel
            // 
            ResultLabel.BackColor = Color.White;
            ResultLabel.Location = new Point(516, 197);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(178, 41);
            ResultLabel.TabIndex = 15;
            ResultLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(542, 28);
            label7.Name = "label7";
            label7.Size = new Size(122, 15);
            label7.TabIndex = 16;
            label7.Text = "พื้นที่สี่เหลี่ยมขนมเปียกปูน";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(823, 338);
            Controls.Add(label7);
            Controls.Add(ResultLabel);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(HeightTextBox);
            Controls.Add(BaseTextBox);
            Controls.Add(CalculateButton);
            Controls.Add(label3);
            Controls.Add(btnCalculate2);
            Controls.Add(label4);
            Controls.Add(lblResult);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAge);
            Controls.Add(txtHeight);
            Controls.Add(txtWeight);
            Controls.Add(btnCalculate);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            Text = "Calculation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private TextBox txtWeight;
        private TextBox txtHeight;
        private TextBox txtAge;
        private Label label1;
        private Label label2;
        private Label lblResult;
        private Label label4;
        private Button btnCalculate2;
        private Label label3;
        private Button CalculateButton;
        private TextBox BaseTextBox;
        private TextBox HeightTextBox;
        private Label label5;
        private Label label6;
        private Label ResultLabel;
        private Label label7;
    }
}