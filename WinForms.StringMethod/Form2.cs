using System;
using System.Windows.Forms;

namespace WinForms.StringMethod
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // รับค่าจาก TextBox
                double weight = double.Parse(txtWeight.Text); // น้ำหนัก
                double height = double.Parse(txtHeight.Text); // ส่วนสูง
                int age = int.Parse(txtAge.Text);             // อายุ

                // สูตรการคำนวณ BMR (ตัวอย่างใช้สูตรสำหรับเพศชาย)
                double bmr = 10 * weight + 6.25 * height - 5 * age + 5;

                // แสดงผลใน Label
                lblResult.Text = $"ค่า BMR ของคุณคือ: {bmr:F2} กิโลแคลอรี";

            }
            catch (Exception ex)
            {
                // กรณีเกิดข้อผิดพลาด
                MessageBox.Show("กรุณากรอกข้อมูลให้ถูกต้อง\n" + ex.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate2_Click(object sender, EventArgs e)
        {
            try
            {
                // รับค่าจาก TextBox
                double weight = double.Parse(txtWeight.Text); // น้ำหนัก
                double height = double.Parse(txtHeight.Text); // ส่วนสูง
                int age = int.Parse(txtAge.Text);             // อายุ

                // สูตรการคำนวณ BMR (ตัวอย่างใช้สูตรสำหรับเพศหญิง)
                double bmr = 10 * weight + 6.25 * height - 5 * age - 161;

                // แสดงผลใน Label
                lblResult.Text = $"ค่า BMR ของคุณคือ: {bmr:F2} กิโลแคลอรี";

            }
            catch (Exception ex)
            {
                // กรณีเกิดข้อผิดพลาด
                MessageBox.Show("กรุณากรอกข้อมูลให้ถูกต้อง\n" + ex.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // ดึงค่าฐานและความสูงจากช่องกรอก
                double baseValue = double.Parse(BaseTextBox.Text);
                double heightValue = double.Parse(HeightTextBox.Text);

                // คำนวณพื้นที่
                double area = 0.5 * baseValue * heightValue;

                // แสดงผลลัพธ์
                ResultLabel.Text = $"พื้นที่: {area:F2} หน่วย²";
            }
            catch (FormatException)
            {
                // แสดงข้อความข้อผิดพลาดเมื่อกรอกข้อมูลไม่ถูกต้อง
                MessageBox.Show("กรุณากรอกตัวเลขที่ถูกต้อง", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
    }
}
