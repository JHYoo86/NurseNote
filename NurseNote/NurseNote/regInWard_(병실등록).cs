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
            // 폼 타이틀
            clsPublic.setFormTitle(this);

            // 병동 세팅
            setCboWARDCD();
            // 진료과 세팅
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

        /// <summary>
        /// 병동 콤보박스 세팅
        /// </summary>
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
        
        /// <summary>
        /// 병실 콤보박스 세팅
        /// </summary>
        /// <param name="strWardCd"></param>
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

        /// <summary>
        /// 진료과 콤보박스 세팅
        /// </summary>
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

        /// <summary>
        /// 진료의 콤보박스 세팅
        /// </summary>
        /// <param name="strDeptCd"></param>
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
            int i = 0;
            string SQL = "";
            DataTable dt = null;
            ssList_Sheet1.RowCount = 0;

            Cursor.Current = Cursors.WaitCursor;

            SQL = "";
            SQL += "SELECT B.PTNO                       ";
	        SQL += "     , B.PTNAME                     ";
	        SQL += "     , W.FRDATE                     ";
	        SQL += "     , W.ENDDATE                    ";
	        SQL += "     , W.WARDCD                     ";
	        SQL += "     , W.ROOMCD                     ";
	        SQL += "     , W.OPDATE                     ";
	        SQL += "     , W.MEDDEPTCD                  ";
	        SQL += "     , D.MEDDEPTNAME                ";
	        SQL += "     , W.MEDDRCD                    ";
	        SQL += "     , U.MEDDRNAME                  ";
            SQL += "  FROM BPT B                        ";
            SQL += " LEFT OUTER JOIN INWARD W           ";
            SQL += "    ON B.PTNO = W.PTNO              ";
            SQL += " LEFT OUTER JOIN BMEDDEPTCD D       ";
            SQL += "    ON W.MEDDEPTCD = D.MEDDEPTCD    ";
            SQL += " LEFT OUTER JOIN BMEDDRCD U         ";
            SQL += "    ON W.MEDDEPTCD = U.MEDDEPTCD    ";
            SQL += "   AND W.MEDDRCD = U.MEDDRCD        ";

            dt =  clsDB.GetDataTable(SQL);

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
                ssList_Sheet1.RowCount = ssList_Sheet1.RowCount + 1;

                ssList_Sheet1.Cells[ssList_Sheet1.RowCount - 1, 0].Text = dt.Rows[i]["PTNO"].ToString().Trim();
                ssList_Sheet1.Cells[ssList_Sheet1.RowCount - 1, 1].Text = dt.Rows[i]["PTNAME"].ToString().Trim();
                ssList_Sheet1.Cells[ssList_Sheet1.RowCount - 1, 2].Text = dt.Rows[i]["FRDATE"].ToString().Trim();
                ssList_Sheet1.Cells[ssList_Sheet1.RowCount - 1, 3].Text = dt.Rows[i]["OPDATE"].ToString().Trim();
                ssList_Sheet1.Cells[ssList_Sheet1.RowCount - 1, 4].Text = dt.Rows[i]["WARDCD"].ToString().Trim();
                ssList_Sheet1.Cells[ssList_Sheet1.RowCount - 1, 5].Text = dt.Rows[i]["ROOMCD"].ToString().Trim();
                ssList_Sheet1.Cells[ssList_Sheet1.RowCount - 1, 6].Text = dt.Rows[i]["MEDDEPTCD"].ToString().Trim();
                ssList_Sheet1.Cells[ssList_Sheet1.RowCount - 1, 7].Text = dt.Rows[i]["MEDDEPTNAME"].ToString().Trim();
                ssList_Sheet1.Cells[ssList_Sheet1.RowCount - 1, 8].Text = dt.Rows[i]["MEDDRCD"].ToString().Trim();
                ssList_Sheet1.Cells[ssList_Sheet1.RowCount - 1, 9].Text = dt.Rows[i]["MEDDRNAME"].ToString().Trim();
            }

            Cursor.Current = Cursors.Default;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }

        private void ssList_SelectionChanged(object sender, FarPoint.Win.Spread.SelectionChangedEventArgs e)
        {
            int rowIdx = ssList_Sheet1.ActiveRowIndex;

            if (rowIdx < 0) return;

            TxtPTNO.Text = ssList_Sheet1.Cells[rowIdx, 0].Text;
            TxtPTNAME.Text = ssList_Sheet1.Cells[rowIdx, 1].Text;
            CboWARDCD.Text = ssList_Sheet1.Cells[rowIdx, 4].Text;
            CboROOMCD.Text = ssList_Sheet1.Cells[rowIdx, 5].Text;
            CboMEDDEPTCD.Text = ssList_Sheet1.Cells[rowIdx, 6].Text;
            CboMEDDRCD.Text = ssList_Sheet1.Cells[rowIdx, 8].Text;
            if (ssList_Sheet1.Cells[rowIdx, 2].Text != "")
            {
                DtpFRDATE.Value = Convert.ToDateTime(ssList_Sheet1.Cells[rowIdx, 2].Text);
            }
            if (ssList_Sheet1.Cells[rowIdx, 3].Text != "")
            {
                DtpOPDATE.Value = Convert.ToDateTime(ssList_Sheet1.Cells[rowIdx, 3].Text);
            }
        }
    }
}
