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

        private void 진료과코드관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeptCdMng DeptCdMngX = new DeptCdMng();
            DeptCdMngX.ShowDialog();
        }

        private void 진료의코드관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrCdMng DrCdMngX = new DrCdMng();
            DrCdMngX.ShowDialog();
        }

        private void 병동코드관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WardCdMng WardCdMngX = new WardCdMng();
            WardCdMngX.ShowDialog();
        }

        private void 병실코드관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomCdMng RoomCdMngX = new RoomCdMng();
            RoomCdMngX.ShowDialog();
        }
    }
}
