using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseNote.classes
{
    public class clsFunction
    {

        public static DataTable FindAll_BPT()
        {
            string SQL = "";
            
            SQL = "SELECT * FROM BPT";

            return clsDB.GetDataTable(SQL);
        }

        public static DataTable FindAll_BMEDDEPTCD()
        {
            string SQL = "";

            SQL = "SELECT * FROM BMEDDEPTCD";

            return clsDB.GetDataTable(SQL);
        }

        public static DataTable FindAll_BMEDDRCD(string strMedDeptCd)
        {
            string SQL = "";

            SQL = "SELECT * FROM BMEDDRCD";
            if (!strMedDeptCd.Equals(string.Empty))
            {
                SQL += " WHERE MEDDEPTCD = '" + strMedDeptCd + "'";
            }
            SQL += "ORDER BY MEDDEPTCD, MEDDRCD ";

            return clsDB.GetDataTable(SQL);
        }

        public static DataTable FindAll_BWARDCD()
        {
            string SQL = "";

            SQL = "SELECT * FROM BWARDCD";

            return clsDB.GetDataTable(SQL);
        }

        public static DataTable FindAll_BROOMCD(string strWardCd)
        {
            string SQL = "";

            SQL = "SELECT * FROM BROOMCD";
            if (!strWardCd.Equals(string.Empty))
            {
                SQL += " WHERE WARDCD = '" + strWardCd + "'";
            }
            SQL += "ORDER BY WARDCD, ROOMCD ";

            return clsDB.GetDataTable(SQL);
        }
    }
}
