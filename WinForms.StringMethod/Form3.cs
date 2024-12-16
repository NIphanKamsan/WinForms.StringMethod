using System;
using System.Text;
using System.Windows.Forms;

namespace WinForms.StringMethod
{
    public partial class Form3 : Form
    {
        // Constructor: เรียกใช้งาน InitializeComponent เพื่อเตรียมส่วนประกอบในฟอร์ม
        public Form3()
        {
            InitializeComponent();
        }

        // Event handler สำหรับปุ่ม Pattern A
        private void btnPatternA_Click(object sender, EventArgs e)
        {
            int s = 0;
            string t = txt12.Text; // รับค่าจาก TextBox txt12

            // ตรวจสอบว่า txtSize มีค่าที่เป็นตัวเลขหรือไม่
            if (!int.TryParse(txtSize.Text, out s))
            {
                MessageBox.Show("Please input only number in size.", " !!! Error !!! ");
                return;
            }

            // แสดงผลลัพธ์จากฟังก์ชัน typeA ใน TextBox txtOutput
            txtOutput.Text = draw_triangle(t, s, "A");
        }

        // Event handler สำหรับปุ่ม Pattern B
        private void btnPatternB_Click(object sender, EventArgs e)
        {
            int s = 0;
            string t = txt12.Text; // รับค่าจาก TextBox txt12

            // ตรวจสอบว่า txtSize มีค่าที่เป็นตัวเลขหรือไม่
            if (!int.TryParse(txtSize.Text, out s))
            {
                MessageBox.Show("Please input only number in size.", " !!! Error !!! ");
                return;
            }

            // แสดงผลลัพธ์จากฟังก์ชัน typeB ใน TextBox txtOutput
            txtOutput.Text = draw_triangle(t,s,"B");
        }

        // Event handler สำหรับปุ่ม Pattern C
        private void btnPatternC_Click(object sender, EventArgs e)
        {
            int s = 0;
            string t = txt12.Text; // รับค่าจาก TextBox txt12

            // ตรวจสอบว่า txtSize มีค่าที่เป็นตัวเลขหรือไม่
            if (!int.TryParse(txtSize.Text, out s))
            {
                MessageBox.Show("Please input only number in size.", " !!! Error !!! ");
                return;
            }

            // แสดงผลลัพธ์จากฟังก์ชัน typeC ใน TextBox txtOutput
            txtOutput.Text = draw_triangle(t, s, "C");
        }

        // ฟังก์ชัน typeC: สร้างรูปแบบสามเหลี่ยมจากตัวอักษร
        string typeC(string letter, int size)
        {
            string result = "";
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    result += letter; // เพิ่มตัวอักษรตามลำดับ
                }
                result += Environment.NewLine; // ขึ้นบรรทัดใหม่
            }
            return result;
        }

        // ฟังก์ชัน typeB: สร้างกรอบที่มีตัวเลขอยู่ตรงกลาง
        string typeB(string text, int size)
        {
            string result = "";

            // แถวแรก (ขอบบน)
            for (int i = 0; i < 6; i++)
            {
                result += text;
            }
            result += Environment.NewLine;

            // แถวกลาง (มีตัวเลข)
            for (int i = 1; i <= size; i++)
            {
                result += text; // ขอบด้านซ้าย
                for (int j = 0; j < 4; j++)
                {
                    result += i.ToString(); // เพิ่มตัวเลขตามลำดับ
                }
                result += text; // ขอบด้านขวา
                result += Environment.NewLine;
            }

            // แถวสุดท้าย (ขอบล่าง)
            for (int i = 0; i < 6; i++)
            {
                result += text;
            }

            return result;
        }

        // ฟังก์ชัน typeA: สร้างกรอบสี่เหลี่ยม
        string typeA(string text, int size)
        {
            string result = "";

            // แถวบน
            for (int i = 0; i < size; i++)
            {
                result += text;
            }
            result += Environment.NewLine;

            // แถวกลาง (มีช่องว่างตรงกลาง)
            for (int i = 0; i < size - 2; i++)
            {
                result += text; // ขอบด้านซ้าย
                result += new string(' ', size * 2 - 3); // เพิ่มช่องว่างยืดหยุ่น
                result += text; // ขอบด้านขวา
                result += Environment.NewLine;
            }

            // แถวล่าง
            for (int i = 0; i < size; i++)
            {
                result += text;
            }

            return result;
        }

        string draw_triangle(string text, int size, string type) // เรียนใช้แบบสอง เขียนรวมฟังชันให้กระชับมากขึ้น
        {
            if (type == "A")
            {
                return typeA(text, size);
            }
            else if (type == "B")
            {
                return typeB(text, size);
            }
            else if (type == "C")
            {
                return typeC(text, size);
            }
            return "Error";
        }
        // Event handler สำหรับการโหลดฟอร์ม
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        // Event handler สำหรับการเปลี่ยนแปลงข้อความใน TextBox
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Event handler สำหรับการเปลี่ยนแปลงข้อความใน TextBox อื่น
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
