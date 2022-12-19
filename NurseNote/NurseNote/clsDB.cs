using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NurseNote
{
    public static class clsDB
    {
        private static SQLiteConnection conn = null;

        public static string getDBDirectory()
        {
            // Database 지정할 경로
            string ExecutablePath = Path.GetDirectoryName(Application.ExecutablePath);
            // Database 지정할 경로 + Database 이름
            string DBDirectory = String.Format(@"{0}\{1}", ExecutablePath, "Database");

            return DBDirectory;
        }

        public static string getDBFile()
        {
            // Database 이름
            string DBFileName = "sqlite.db";
            // Database 지정할 경로
            string ExecutablePath = Path.GetDirectoryName(Application.ExecutablePath);
            // Database 지정할 경로 + Database 이름
            string DBFile = String.Format(@"{0}\{1}\{2}", ExecutablePath, "Database", DBFileName);

            return DBFile;
        }

        public static void createDB()
        {
            try
            {
                string DBFile = getDBFile();
                string DirPath = getDBDirectory();

                // 디렉토리 체크 및 생성
                DirectoryInfo di = new DirectoryInfo(DirPath);
                if (di.Exists == false)
                {
                    di.Create();
                }
                 
                // sqlite.db가 해당 경로 폴더 안에 있는지 체크
                if (!System.IO.File.Exists(DBFile))
                {
                    SQLiteConnection.CreateFile(DBFile);
                }
            }
            catch (Exception ex)
            {

            }
        }

        public static void createTable()
        {
            try
            {
                if (conn == null)
                {
                    DBConnect();
                }

                using (SQLiteCommand sqliteCommand = new SQLiteCommand(conn))
                {
                    // BPT
                    sqliteCommand.CommandText = @"CREATE TABLE BPT
                                                  (
                                                      PTNO  TEXT,
                                                      PTNAME    TEXT,
                                                      SSNO1 INTEGER,
                                                      SSNO2 INTEGER,
                                                      PRIMARY KEY(PTNO)
                                                  )";
                    sqliteCommand.ExecuteNonQuery();

                    // INWARD
                    sqliteCommand.CommandText = @"CREATE TABLE INWARD
                                                  (
                                                      PTNO  TEXT,
                                                      FRDATE    TEXT,
                                                      ENDDATE   TEXT,
                                                      WARDCD    TEXT,
                                                      ROOMCD    INTEGER,
                                                      MEDDEPTCD TEXT,
                                                      MEDDRCD   TEXT,
                                                      OPDATE    TEXT,
                                                      PRIMARY KEY(PTNO, FRDATE)
                                                  )";
                    sqliteCommand.ExecuteNonQuery();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);

                conn = null;
            }
        }

        public static bool DBConnect()
        {
            try
            {
                string DBFile = getDBFile();
                // DB정보 
                string constring = string.Format("Data Source={0};", DBFile);

                conn = new SQLiteConnection(constring);

                conn.Open();
                return true;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                conn = null;
                return false;
            }
        }

        public static void DisDBConnect()
        {
            try
            {
                conn.Close();
                conn.Dispose();
                conn = null;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        public static DataTable GetDataTable(string SQL)
        {
            DataTable dt = null;
            try
            {
                if (conn == null)
                {
                    DBConnect();
                }

                SQLiteCommand cmd = new SQLiteCommand(SQL, conn);
                SQLiteDataReader rdr = cmd.ExecuteReader();

                dt = new DataTable();
                dt.Load(rdr);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                DisDBConnect();
            }
        }

        public static bool ExecuteNonQuery(string SQL)
        {
            try
            {
                if (conn == null)
                {
                    DBConnect();
                }

                SQLiteCommand cmd = new SQLiteCommand(SQL, conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd = null;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                DisDBConnect();
            }
        }
    }
}
