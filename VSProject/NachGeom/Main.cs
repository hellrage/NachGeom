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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            string addedElem = "";
            DataTable testList = MySQLQuieries.GetTestList();
            addedElem+=testList.Rows[0].Field<string>("test_name");
            addedElem += " variant: " + testList.Rows[0].Field<int>("variant");
            comboBox1.Items.Add(addedElem);
            
        }
    }
}
