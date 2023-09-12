using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace library.BL
{
    class CLS_CAT
    {
        DAL.CLS_DAL DAL = new library.DAL.CLS_DAL();
         
        // method to read CAt (load)
        public DataTable LOAD()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADCAT", pr);
            return dt;
        }


        public void Insert(string CAT_NAME)
        {
            SqlParameter [] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("CAT_NAME", CAT_NAME);
            DAL.open();
            DAL.excute("PR_ADDCAT", pr);
            DAL.close();
        }

        public void Update(string CAT_NAME , int id)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter("CAT_NAME", CAT_NAME);
            pr[1] = new SqlParameter("id", id);
            DAL.open();
            DAL.excute("PR_EDITECAT", pr);
            DAL.close();
        }

        public void Delete(int id)
        {
            SqlParameter[] pr = new SqlParameter[1];
             pr[0] = new SqlParameter("id", id);
            DAL.open();
            DAL.excute("PR_DELETECAT", pr);
            DAL.close();

        }


        public DataTable Search(string search)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("search", search);
            DataTable dt = new DataTable();
            dt = DAL.read("PR_SEARCHCAT", pr);
            return dt;
        }
    }
}
