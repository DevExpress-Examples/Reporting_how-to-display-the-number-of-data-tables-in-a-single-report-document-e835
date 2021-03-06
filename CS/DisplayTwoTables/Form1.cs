using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace DisplayTwoTables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EmployeesAndProducts report = new EmployeesAndProducts();
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreviewDialog();
            this.Close();
        }
    }
}