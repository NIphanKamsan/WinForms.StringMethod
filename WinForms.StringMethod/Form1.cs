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
            else
            {
                x = fullname.LastIndexOf('.') + 1;
                title = fullname.Substring(0, x);
            }
            //หาตำแหน่งของ จุด (.)
            fullname = fullname.Substring(x).Trim();


            //MessageBox.Show(title + "\n" + fullname);
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
    }
}
