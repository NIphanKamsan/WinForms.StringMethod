﻿using System;
using System.Collections.Generic;
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

            string result = " ";

            foreach (int a in arr)  // ใช้ int แทน string
            {
                result += a.ToString() + Environment.NewLine;  // เก็บผลลัพธ์ใน result
            }
            label1.Text = "น้อยไปมาก\n" + result;
        }

        void SortDescending(int[] arr)
        {
            Array.Sort(arr);  // เรียงลำดับจากไปมาก
            Array.Reverse(arr);  

            string result = " ";

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
            // ใช้ LINQ เพื่อกรองเฉพาะบรรทัดที่สามารถแปลงเป็นตัวเลขได้เท่านั้น
            int[] numbers = textBox1.Lines
                .Select(line =>
                {
                    int.TryParse(line, out var result);
                    return result;
                })
                .Where(n => n != 0)  // กรองค่าที่เป็น 0 ออก
                .ToArray();

            // เรียกใช้ฟังก์ชัน SortAscending
            SortAscending(numbers);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ใช้ LINQ เพื่อกรองเฉพาะบรรทัดที่สามารถแปลงเป็นตัวเลขได้เท่านั้น
            int[] numbers = textBox1.Lines
                .Select(line =>
                {
                    int.TryParse(line, out var result);
                    return result;
                })
                .Where(n => n != 0)  // กรองค่าที่เป็น 0 ออก
                .ToArray();

            // เรียกใช้ฟังก์ชัน SortDescending
            SortDescending(numbers);
        }
    }
}
