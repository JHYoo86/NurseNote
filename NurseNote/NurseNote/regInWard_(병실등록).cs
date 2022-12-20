using NurseNote.classes;
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
    public partial class regInWard : Form
    {
        public regInWard()
        {
            InitializeComponent();
        }

        private void regInWard_Load(object sender, EventArgs e)
        {
            setCboWARDCD();
            setCboMEDDEPTCD();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtPTNO.Text = "";
            TxtPTNAME.Text = "";
            CboWARDCD.Text = "";
            CboROOMCD.Text = "";
            CboMEDDEPTCD.Text = "";
            CboMEDDRCD.Text = "";
            DtpFRDATE.Value = DateTime.Now;
            DtpOPDATE.Value = DateTime.Now;
        }

        private void setCboWARDCD()
        {
            int i = 0;
            DataTable dt = null;
            CboWARDCD.Items.Clear();
            CboWARDCD.Items.Add("");
            Cursor.Current = Cursors.WaitCursor;

            dt = clsFunction.FindAll_BWARDCD();
            if (dt == null)
            {
                MessageBox.Show(new Form() { TopMost = true }, "조회중 문제가 발생했습니다");
                Cursor.Current = Cursors.Default;
                return;
            }

            if (dt.Rows.Count == 0)
            {
                dt.Dispose();
                dt = null;
                Cursor.Current = Cursors.Default;
                return;
            }

            for (i = 0; i < dt.Rows.Count; i++)
            {
                CboWARDCD.Items.Add(dt.Rows[i]["WARDNAME"].ToString().Trim());
            }

            Cursor.Current = Cursors.Default;
        }

        private void setCboROOMCD(string strWardCd)
        {
            int i = 0;
            DataTable dt = null;
            CboROOMCD.Items.Clear();
            CboROOMCD.Items.Add("");
            Cursor.Current = Cursors.WaitCursor;

            dt = clsFunction.FindAll_BROOMCD(strWardCd);
            if (dt == null)
            {
                MessageBox.Show(new Form() { TopMost = true }, "조회중 문제가 발생했습니다");
                Cursor.Current = Cursors.Default;
                return;
            }

            if (dt.Rows.Count == 0)
            {
                dt.Dispose();
                dt = null;
                Cursor.Current = Cursors.Default;
                return;
            }

            for (i = 0; i < dt.Rows.Count; i++)
            {
                CboROOMCD.Items.Add(dt.Rows[i]["ROOMCD"].ToString().Trim());
            }

            Cursor.Current = Cursors.Default;
        }

        private void setCboMEDDEPTCD()
        {
            int i = 0;
            DataTable dt = null;
            CboMEDDEPTCD.Items.Clear();
            CboMEDDEPTCD.Items.Add("");
            Cursor.Current = Cursors.WaitCursor;

            dt = clsFunction.FindAll_BMEDDEPTCD();
            if (dt == null)
            {
                MessageBox.Show(new Form() { TopMost = true }, "조회중 문제가 발생했습니다");
                Cursor.Current = Cursors.Default;
                return;
            }

            if (dt.Rows.Count == 0)
            {
                dt.Dispose();
                dt = null;
                Cursor.Current = Cursors.Default;
                return;
            }

            for (i = 0; i < dt.Rows.Count; i++)
            {
                CboMEDDEPTCD.Items.Add(string.Concat(dt.Rows[i]["MEDDEPTCD"].ToString().Trim(), ".", dt.Rows[i]["MEDDEPTNAME"].ToString().Trim()));
            }

            Cursor.Current = Cursors.Default;
        }

        private void setCboMEDDRCD(string strDeptCd)
        {
            int i = 0;
            DataTable dt = null;
            CboMEDDRCD.Items.Clear();
            CboMEDDRCD.Items.Add("");
            Cursor.Current = Cursors.WaitCursor;

            dt = clsFunction.FindAll_BMEDDRCD(strDeptCd);
            if (dt == null)
            {
                MessageBox.Show(new Form() { TopMost = true }, "조회중 문제가 발생했습니다");
                Cursor.Current = Cursors.Default;
                return;
            }

            if (dt.Rows.Count == 0)
            {
                dt.Dispose();
                dt = null;
                Cursor.Current = Cursors.Default;
                return;
            }

            for (i = 0; i < dt.Rows.Count; i++)
            {
                CboMEDDRCD.Items.Add(string.Concat(dt.Rows[i]["MEDDRCD"].ToString().Trim(), ".", dt.Rows[i]["MEDDRNAME"].ToString().Trim()));
            }

            Cursor.Current = Cursors.Default;
        }

        private void CboWARDCD_SelectedIndexChanged(object sender, EventArgs e)
        {
            CboROOMCD.Items.Clear();
            if (CboWARDCD.Text == "")
            {
                return;
            }

            string strWardCd = CboWARDCD.Text.Substring(0, 1);
            setCboROOMCD(strWardCd);
        }

        private void CboMEDDEPTCD_SelectedIndexChanged(object sender, EventArgs e)
        {
            CboMEDDRCD.Items.Clear();
            if (CboMEDDEPTCD.Text == "")
            {
                return;
            }

            string strDeptCd = CboMEDDEPTCD.Text.Split('.')[0];
            setCboMEDDRCD(strDeptCd);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
