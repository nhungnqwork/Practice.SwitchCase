using QuanLyTiemNet.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemNet
{
    public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get { if (instance == null) ; instance = new TableDAO(); return instance; }
            private set => instance = value;
        }
        private TableDAO() { }

        public static int TableWidth = 100;
        public static int TableHeight = 100;
        public static int ScreenWidth = 35;
        public static int ScreenHeight = 35;

        #region TableList

        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from TableNet");

            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }
            return tableList;
        }
        public List<Table> LoadTableFilm()
        {
            List<Table> tableList = new List<Table>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from TableFilm");

            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }
            return tableList;
        }

        #endregion

    }
}
