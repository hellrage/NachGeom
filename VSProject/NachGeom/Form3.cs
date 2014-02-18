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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            dataGridView1.Rows.Add("Имя теста: ", pMain.currentTest.testName);
            dataGridView1.Rows.Add("Номер варианта: ", pMain.currentTest.Variant);
            dataGridView1.Rows.Add("Имя студента: ", pMain.studentName + pMain.studentSurname + pMain.studentFname);
            dataGridView1.Rows.Add("Группа: ", pMain.Group);
            dataGridView1.Rows.Add("Затраченное время: ", (DateTime.Now - pMain.testStart).ToString("hh':'mm':'ss"));
            dataGridView1.Rows.Add("Выбранные ответы: ", "d");
            dataGridView1.Rows.Add("Ошибки: ", pMain.currentTest.testName);
            dataGridView1.Rows.Add("Оценка: ", pMain.currentTest.testName);
        }
    }
}
