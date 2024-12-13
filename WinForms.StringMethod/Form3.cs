using System;
using System.Text;
using System.Windows.Forms;

namespace WinForms.StringMethod
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnPatternA_Click(object sender, EventArgs e)
        {
            txtOutput.Text = GeneratePatternA();
        }

        private void btnPatternB_Click(object sender, EventArgs e)
        {
            txtOutput.Text = GeneratePatternB();
        }

        private void btnPatternC_Click(object sender, EventArgs e)
        {
            txtOutput.Text = GeneratePatternC();
        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {
            // Optional: Add logic here if needed
        }

        private string GeneratePatternA()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("XXXXXXXXXX");
            sb.AppendLine("X        X");
            sb.AppendLine("X        X");
            sb.AppendLine("XXXXXXXXXX");
            return sb.ToString();
        }

        private string GeneratePatternB()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("X 1 1 1 1 X");
            sb.AppendLine("X 2 2 2 2 X");
            sb.AppendLine("X 3 3 3 3 X");
            sb.AppendLine("X 4 4 4 4 X");
            sb.AppendLine("X X X X X X");
            return sb.ToString();
        }

        private string GeneratePatternC()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= 5; i++)
            {
                sb.AppendLine(new string('#', i));
            }
            return sb.ToString();
        }
    }
}