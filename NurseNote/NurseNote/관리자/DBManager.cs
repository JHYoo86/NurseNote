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
    public partial class DBManager : Form
    {
        public DBManager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsDB.createDB();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (clsDB.DBConnect() == true)
            {
                MessageBox.Show("연결성공!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clsDB.createTable();
        }
    }
}
