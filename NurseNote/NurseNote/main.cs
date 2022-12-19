using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NurseNote
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuDBManager_Click(object sender, EventArgs e)
        {
            DBManager DBManagerX = new DBManager();
            DBManagerX.ShowDialog();
        }

        private void mnuRegPat_Click(object sender, EventArgs e)
        {
            regPatient regPatientX = new regPatient();
            regPatientX.ShowDialog();
        }
    }
}
