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

namespace NurseNote.코드관리
{
    public partial class RoomCdMng : Form
    {
        public RoomCdMng()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            int i = 0;
            DataTable dt = null;
            ssList_Sheet1.RowCount = 0;
            ssList2_Sheet1.RowCount = 0;

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

        private void ssList_SelectionChanged(object sender, FarPoint.Win.Spread.SelectionChangedEventArgs e)
        {
            int i = 0;
            DataTable dt = null;

            int rowIdx = ssList_Sheet1.ActiveRowIndex;

            if (rowIdx < 0) return;
                        
            ssList2_Sheet1.RowCount = 0;
            string strWardCd = ssList_Sheet1.Cells[rowIdx, 0].Text;

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
                ssList2_Sheet1.RowCount = ssList2_Sheet1.RowCount + 1;

                ssList2_Sheet1.Cells[ssList2_Sheet1.RowCount - 1, 0].Text = dt.Rows[i]["ROOMCD"].ToString().Trim();
                ssList2_Sheet1.Cells[ssList2_Sheet1.RowCount - 1, 1].Text = dt.Rows[i]["ROOMNAME"].ToString().Trim();
            }

            Cursor.Current = Cursors.Default;
        }
    }
}
