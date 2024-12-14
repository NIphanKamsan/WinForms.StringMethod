using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.StringMethod
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        void SortAscending(int[] arr)
        {
            Array.Sort(arr);  // เรียงลำดับจากน้อยไปมาก
            //return arr;

            string result = "";


            foreach (int a in arr)  // ใช้ int แทน string
            {

                result += a.ToString() + Environment.NewLine;  // เก็บผลลัพธ์ใน result
            }
            label1.Text = "น้อยไปมาก\n" + result;
        }

        void SortDescending(int[] arr)
        {
            Array.Sort(arr);  // เรียงลำดับจากน้อยไปมาก
            Array.Reverse(arr);  // กลับลำดับเพื่อให้เป็นการเรียงจากมากไปน้อย
            //return arr;

            string result = "";


            foreach (int a in arr)  // ใช้ int แทน string
            {

                result += a.ToString() + Environment.NewLine;  // เก็บผลลัพธ์ใน result
            }
            label1.Text = "มากไปน้อย\n" + result;
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] numbers = textBox1.Lines.Select(line => int.TryParse(line, out var result) ? result : 0).ToArray();
            SortAscending(numbers);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] numbers = textBox1.Lines.Select(line => int.TryParse(line, out var result) ? result : 0).ToArray();
            SortDescending(numbers);
        }
    }
}
