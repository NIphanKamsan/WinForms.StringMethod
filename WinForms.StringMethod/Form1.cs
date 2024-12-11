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
    }
}
