using RoboCriaPlanilha.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboCriaPlanilha
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void BtnGerarExcel_Click(object sender, EventArgs e)
        {
            ExcelService excelService = new ExcelService();

            excelService.GeraExcel();
        }
    }
}
