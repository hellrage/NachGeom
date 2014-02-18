using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        DataTable testList = MySQLQuieries.GetTestList();


        public Form1()
        {
            InitializeComponent();
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;

            
            FillTestNames();
        }

        private void FillTestNames()
        {
            //string addedElem = "";
            //foreach (DataRow dr in testList.Rows)
            //{
            //    if (dr.Field<string>("test_name") != addedElem)
            //    {
            //        addedElem = dr.Field<string>("test_name");
            //        comboBox1.Items.Add(addedElem);
            //    }
            //}

            comboBox1.Items.Add("Тест 1");
            comboBox1.Items.Add("Тест 2");
            comboBox1.Items.Add("Тест 3");
        }

        private void FillVariants()
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Тест 1":
                    comboBox2.Items.Add("Вариант 1");
                    comboBox2.Items.Add("Вариант 2");
                    comboBox2.Items.Add("Вариант 3");
                    break;
                case "Тест 2":
                    comboBox2.Items.Add("Вариант 4");
                    comboBox2.Items.Add("Вариант 5");
                    comboBox2.Items.Add("Вариант 6");
                    break;
                case "Тест 3":
                    comboBox2.Items.Add("Вариант 7");
                    comboBox2.Items.Add("Вариант 8");
                    comboBox2.Items.Add("Вариант 9");
                    break;
                default:
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                button2.Enabled = true;
            else
                button2.Enabled = false;
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            FillVariants();
            comboBox2.Enabled = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            using (Form2 form2 = new Form2())
            {
                form2.ShowDialog();
            }
        }
    }
}
