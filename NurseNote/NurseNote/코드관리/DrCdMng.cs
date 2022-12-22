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
    public partial class DrCdMng : Form
    {
        public DrCdMng()
        {
            InitializeComponent();
        }

        private void DrCdMng_Load(object sender, EventArgs e)
        {
            // 폼 타이틀
            clsPublic.setFormTitle(this);

            BtnSearch.PerformClick();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            int i = 0;
            DataTable dt = null;
            ssList_Sheet1.RowCount = 0;
            ssList2_Sheet1.RowCount = 0;

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
                ssList_Sheet1.RowCount = ssList_Sheet1.RowCount + 1;

                ssList_Sheet1.Cells[ssList_Sheet1.RowCount - 1, 0].Text = dt.Rows[i]["MEDDEPTCD"].ToString().Trim();
                ssList_Sheet1.Cells[ssList_Sheet1.RowCount - 1, 1].Text = dt.Rows[i]["MEDDEPTNAME"].ToString().Trim();
            }
        }

        private void ssList_SelectionChanged(object sender, FarPoint.Win.Spread.SelectionChangedEventArgs e)
        {
            int i = 0;
            DataTable dt = null;

            int rowIdx = ssList_Sheet1.ActiveRowIndex;

            if (rowIdx < 0) return;

            ssList2_Sheet1.RowCount = 0;
            string strDeptCd = ssList_Sheet1.Cells[rowIdx, 0].Text;

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
                ssList2_Sheet1.RowCount = ssList2_Sheet1.RowCount + 1;

                ssList2_Sheet1.Cells[ssList2_Sheet1.RowCount - 1, 0].Text = dt.Rows[i]["MEDDRCD"].ToString().Trim();
                ssList2_Sheet1.Cells[ssList2_Sheet1.RowCount - 1, 1].Text = dt.Rows[i]["MEDDRNAME"].ToString().Trim();
                ssList2_Sheet1.Cells[ssList2_Sheet1.RowCount - 1, 2].Text = dt.Rows[i]["MEDDEPTCD"].ToString().Trim();
            }

            Cursor.Current = Cursors.Default;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string SQL = "";
            int rowIdx = ssList_Sheet1.ActiveRowIndex;

            if (rowIdx < 0) return;

            string strDeptCd = ssList_Sheet1.Cells[rowIdx, 0].Text;

            SQL += "DELETE FROM BMEDDRCD ";
            SQL += " WHERE MEDDEPTCD = '" + strDeptCd + "'";
            clsDB.ExecuteNonQuery(SQL);


            for (int i = 0; i < ssList2_Sheet1.Rows.Count; i++)
            {
                if (ssList2_Sheet1.Cells[i, 0].Text != "")
                {
                    SQL = "";
                    SQL += "INSERT INTO BMEDDRCD                            ";
                    SQL += "(                                               ";
                    SQL += "      MEDDEPTCD                                 ";
                    SQL += "    , MEDDRCD                                   ";
                    SQL += "    , MEDDRNAME                                 ";
                    SQL += ")                                               ";
                    SQL += "VALUES                                          ";
                    SQL += "(                                               ";
                    SQL += "      '" + ssList2_Sheet1.Cells[i, 2].Text + "' ";
                    SQL += "    , '" + ssList2_Sheet1.Cells[i, 0].Text + "' ";
                    SQL += "    , '" + ssList2_Sheet1.Cells[i, 1].Text + "' ";
                    SQL += ")                                               ";

                    clsDB.ExecuteNonQuery(SQL);
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string SQL = "";
            int rowIdx = ssList2_Sheet1.ActiveRowIndex;

            if (rowIdx < 0) return;

            SQL += "DELETE FROM BMEDDRCD ";
            SQL += " WHERE MEDDEPTCD = '" + ssList2_Sheet1.Cells[rowIdx, 2].Text + "'";
            SQL += "   AND MEDDRCD = '" + ssList2_Sheet1.Cells[rowIdx, 0].Text + "'";

            clsDB.ExecuteNonQuery(SQL);

            BtnSearch.PerformClick();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int rowIdx = ssList_Sheet1.ActiveRowIndex;

            if (rowIdx < 0) return;

            string strDeptCd = ssList_Sheet1.Cells[rowIdx, 0].Text;

            ssList2_Sheet1.RowCount = ssList2_Sheet1.RowCount + 1;
            ssList2_Sheet1.Cells[ssList2_Sheet1.RowCount - 1, 2].Text = strDeptCd;
        }
    }
}
