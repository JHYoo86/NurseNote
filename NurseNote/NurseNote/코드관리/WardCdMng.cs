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
    public partial class WardCdMng : Form
    {
        public WardCdMng()
        {
            InitializeComponent();
        }

        private void WardCdMng_Load(object sender, EventArgs e)
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
                ssList_Sheet1.RowCount = ssList_Sheet1.RowCount + 1;

                ssList_Sheet1.Cells[ssList_Sheet1.RowCount - 1, 0].Text = dt.Rows[i]["WARDCD"].ToString().Trim();
                ssList_Sheet1.Cells[ssList_Sheet1.RowCount - 1, 1].Text = dt.Rows[i]["WARDNAME"].ToString().Trim();
            }

            Cursor.Current = Cursors.Default;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string SQL = "";
            
            SQL += "DELETE FROM BWARDCD ";
            clsDB.ExecuteNonQuery(SQL);


            for (int i = 0; i < ssList_Sheet1.Rows.Count; i++)
            {
                if (ssList_Sheet1.Cells[i, 0].Text != "")
                {
                    SQL = "";
                    SQL += "INSERT INTO BWARDCD                             ";
                    SQL += "(                                               ";
                    SQL += "      WARDCD                                    ";
                    SQL += "    , WARDNAME                                  ";
                    SQL += ")                                               ";
                    SQL += "VALUES                                          ";
                    SQL += "(                                               ";
                    SQL += "      '" + ssList_Sheet1.Cells[i, 0].Text + "'  ";
                    SQL += "    , '" + ssList_Sheet1.Cells[i, 1].Text + "'  ";
                    SQL += ")                                               ";

                    clsDB.ExecuteNonQuery(SQL);
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string SQL = "";
            int rowIdx = ssList_Sheet1.ActiveRowIndex;

            if (rowIdx < 0) return;

            SQL += "DELETE FROM BWARDCD ";
            SQL += " WHERE WARDCD = '" + ssList_Sheet1.Cells[rowIdx, 0].Text + "'";

            clsDB.ExecuteNonQuery(SQL);

            BtnSearch.PerformClick();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ssList_Sheet1.RowCount = ssList_Sheet1.RowCount + 1;
        }

    }
}
