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
        regPatMemo regPatMemoX = null;

        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            // 폼 타이틀
            clsPublic.setFormTitle(this);

            // 메인폼 로드
            regPatMemoX = new regPatMemo();
            pSubFormToControl(regPatMemoX, panel1);
        }

        private void pSubFormToControl(Form frm, Control pControl)
        {
            frm.Owner = this;
            frm.TopLevel = false;
            this.Controls.Add(frm);
            frm.Parent = pControl;
            frm.Text = "";
            frm.ControlBox = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Top = 0;
            frm.Left = 0;
            frm.WindowState = FormWindowState.Normal;
            frm.Height = pControl.Height;
            frm.Width = pControl.Width;
            //frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void pSubFormResize(Form frm, Control pControl)
        {
            frm.Height = pControl.Height;
            frm.Width = pControl.Width;
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

        private void 병실등록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            regInWard regInWardX = new regInWard();
            regInWardX.ShowDialog();
        }

        private void mnuRegPat_Click(object sender, EventArgs e)
        {
            regPatient regPatientX = new regPatient();
            regPatientX.ShowDialog();
        }

        private void main_Resize(object sender, EventArgs e)
        {
            pSubFormResize(regPatMemoX, panel1);
        }
    }
}
