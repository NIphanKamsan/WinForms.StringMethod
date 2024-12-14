﻿using System;
using System.Linq;
using System.Windows.Forms;

namespace WinForms.StringMethod
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // ไม่ต้องการโค้ดสำหรับ Label นี้ สามารถลบทิ้งได้หากไม่ใช้
        }

        private void btnCalculateFor_Click(object sender, EventArgs e)
        {
            try
            {
                // อ่านข้อมูลจาก TextBox และแปลงเป็น Array
                string input = txtInputArray.Text.Trim(); // ตัดช่องว่างหัวท้าย
                if (string.IsNullOrEmpty(input))
                {
                    MessageBox.Show("กรุณากรอกข้อมูลตัวเลขคั่นด้วยเครื่องหมาย ','", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string[] inputArray = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                int[] numbers = inputArray.Select(n => int.Parse(n.Trim())).ToArray(); // แปลงเป็น int พร้อมตัดช่องว่าง

                // คำนวณผลรวมและค่าเฉลี่ยแบบ For
                int sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }

                double average = (double)sum / numbers.Length;

                // แสดงผลลัพธ์ใน Label
                lblResultFor.Text = $"ผลลัพธ์แบบ For: {average:F2}"; // แสดงทศนิยม 2 ตำแหน่ง
            }
            catch (FormatException)
            {
                MessageBox.Show("ข้อมูลไม่ถูกต้อง กรุณากรอกเฉพาะตัวเลขและคั่นด้วย ','", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"เกิดข้อผิดพลาด: {ex.Message}", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalculateForeach_Click(object sender, EventArgs e)
        {
            try
            {
                // อ่านข้อมูลจาก TextBox และแปลงเป็น Array
                string input = txtInputArray.Text.Trim();
                if (string.IsNullOrEmpty(input))
                {
                    MessageBox.Show("กรุณากรอกข้อมูลตัวเลขคั่นด้วยเครื่องหมาย ','", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string[] inputArray = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                int[] numbers = inputArray.Select(n => int.Parse(n.Trim())).ToArray();

                // คำนวณผลรวมและค่าเฉลี่ยแบบ Foreach
                int sum = 0;
                foreach (int number in numbers)
                {
                    sum += number;
                }

                double average = (double)sum / numbers.Length;

                // แสดงผลลัพธ์ใน Label
                lblResultForeach.Text = $"ผลลัพธ์แบบ Foreach: {average:F2}"; // แสดงทศนิยม 2 ตำแหน่ง
            }
            catch (FormatException)
            {
                MessageBox.Show("ข้อมูลไม่ถูกต้อง กรุณากรอกเฉพาะตัวเลขและคั่นด้วย ','", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"เกิดข้อผิดพลาด: {ex.Message}", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
    