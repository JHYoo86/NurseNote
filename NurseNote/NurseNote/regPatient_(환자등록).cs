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
    public partial class regPatient : Form
    {
        public regPatient()
        {
            InitializeComponent();
        }

        private void regPatient_Load(object sender, EventArgs e)
        {

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtPTNO.Text = string.Empty;
            TxtPTNAME.Text = string.Empty;
            TxtSSNO1.Text = string.Empty;
            TxtSSNO2.Text = string.Empty;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            int i = 0;
            string SQL = "";
            DataTable dt = null;
            ssList_Sheet1.RowCount = 0;

            Cursor.Current = Cursors.WaitCursor;

            SQL = "SELECT * FROM BPT";
            dt = clsDB.GetDataTable(SQL);

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
                ssList_Sheet1.Cells[ssList_Sheet1.RowCount - 1, 2].Text = dt.Rows[i]["SSNO1"].ToString().Trim();
                ssList_Sheet1.Cells[ssList_Sheet1.RowCount - 1, 3].Text = dt.Rows[i]["SSNO2"].ToString().Trim();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string SQL = "";
            SQL += "INSERT INTO BPT                 ";
            SQL += "(                               ";
            SQL += "      PTNO                      ";
            SQL += "    , PTNAME                    ";
            SQL += "    , SSNO1                     ";
            SQL += "    , SSNO2                     ";
            SQL += ")                               ";
            SQL += "VALUES                          ";
            SQL += "(                               ";
            SQL += "      '" + TxtPTNO.Text + "'    ";
            SQL += "    , '" + TxtPTNAME.Text + "'  ";
            SQL += "    , '" + TxtSSNO1.Text + "'   ";
            SQL += "    , '" + TxtSSNO2.Text + "'   ";
            SQL += ")                               ";

            clsDB.ExecuteNonQuery(SQL);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string SQL = "";
            SQL += "DELETE FROM BPT                         ";
            SQL += " WHERE PTNO = '" + TxtPTNO.Text + "'    ";
            
            clsDB.ExecuteNonQuery(SQL);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
