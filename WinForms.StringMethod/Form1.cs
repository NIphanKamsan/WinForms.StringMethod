namespace WinForms.StringMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fullname = "", firstname = "", lastname = "", title = "";
            int x = 0;
            // ใช้คำสั่ง StartsWith เพื่อตรวจสอบว่า fullname เริ่มต้นด้วยคำใด
            fullname = txtFullname.Text.Trim();

            if (fullname.StartsWith("นางสาว"))
            {
                x = 6;
                title = fullname.Substring(0, x);
            }
            else if (fullname.StartsWith("นาง") || fullname.StartsWith("นาย"))
            {
                x = 3;
                title = fullname.Substring(0, x);
            }
            else if (fullname.StartsWith("เด็กชาย"))
            {
                x = 7;
                title = fullname.Substring(0, x);
            }
            else if (fullname.StartsWith("เด็กหญิง"))
            {
                x = 8;
                title = fullname.Substring(0, x);
            }
            else if (fullname.StartsWith("ร้อยตำรวจตรี"))
            {
                x = 13;
                title = fullname.Substring(0, x);
            }
            else if (fullname.StartsWith("ดาบตำรวจ"))
            {
                x = 9;
                title = fullname.Substring(0, x);
            }
            else if (fullname.StartsWith("หม่อมราชวงศ์"))
            {
                x = 12;
                title = fullname.Substring(0, x);
            }
            else if (fullname.StartsWith("ผู้ช่วยศาสตราจารย์"))
            {
                x = 18;
                title = fullname.Substring(0, x);
            }
            else if (fullname.StartsWith("ดอกเตอร์"))
            {
                x = 8;
                title = fullname.Substring(0, x);
            }
            else if (fullname.StartsWith("ด.ช"))
            {
                x = 3;
                title = fullname.Substring(0, x);
            }
            else if (fullname.StartsWith("น.ส"))
            {
                x = 3;
                title = fullname.Substring(0, x);
            }
            else if (fullname.StartsWith("ด.ญ"))
            {
                x = 3;
                title = fullname.Substring(0, x);
            }
            else if (fullname.StartsWith("ร.ต.ต."))
            {
                x = 6;
                title = fullname.Substring(0, x);
            }
            else if (fullname.StartsWith("มรว."))
            {
                x = 4;
                title = fullname.Substring(0, x);
            }
            else if (fullname.StartsWith("ผศ."))
            {
                x = 3;
                title = fullname.Substring(0, x);
            }
            else if (fullname.StartsWith("ดร."))
            {
                x = 3;
                title = fullname.Substring(0, x);
            }
            else
            {
                x = fullname.LastIndexOf('.') + 1;
                title = fullname.Substring(0, x);
            }

            fullname = fullname.Substring(x).Trim();


            //ค้นหาตำแหน่งของช่องว่าง (IndexOf(' ')) เพื่อแยกชื่อและนามสกุล
            x = fullname.IndexOf(' ');
            firstname = fullname.Substring(0, x).Trim();
            lastname = fullname.Substring(x).Trim();

            txtTitle.Text = title;
            txtFirstName.Text = firstname;
            txtLastName.Text = lastname;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtFullname.Text = " เด็กหญิงอชิเขต บุญมาต้า ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtFullname.Text = " ร้อยตำรวจตรีวรรณ จันเสา ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtFullname.Text = " ดอกเตอร์อชิเขต บุญมาต้า ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtFullname.Text = " ดาบตำรวจอชิเขต บุญมาต้า ";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtFullname.Text = " หม่อมราชวงศ์อชิเขต บุญมาต้า ";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtFullname.Text = " เด็กชาย.อชิเขต บุญมาต้า ";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtFullname.Text = " มรว.อชิเขต บุญมาต้า ";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtFullname.Text = " ผศ.อชิเขต บุญมาต้า ";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtFullname.Text = " นางสาวอชิเขต บุญมาต้า ";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtFullname.Text = " นายอชิเขต บุญมาต้า ";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtFullname.Text = " ด.ญอชิเขต บุญมาต้า ";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtFullname.Text = " ด.ชอชิเขต บุญมาต้า ";
        }
    }
}
