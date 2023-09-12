using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace library.BL
{

   
    class CLS_BOR
    {
        DAL.CLS_DAL DAL = new DAL.CLS_DAL();

        public DataTable LOAD()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADBOR", pr);
            return dt;
        }

        public DataTable LOADBOOK()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADBOOKFORSELL", pr);
            return dt;
        }
        // load student

        public DataTable LOADSTUDENT()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADSTFORSELL", pr);
            return dt;
        }


        //insert 
        public void Insert(string stname, string btitle, DateTime bdate1, DateTime bdate2, int price )
        {
            SqlParameter[] pr = new SqlParameter[5];
            pr[0] = new SqlParameter("stname", stname);
            pr[1] = new SqlParameter("btitle", btitle);
            pr[2] = new SqlParameter("bdate1", bdate1);
            pr[3] = new SqlParameter("bdate2", bdate2);
            pr[4] = new SqlParameter("price", price);
            DAL.open();
            DAL.excute("PR_INSERTBOR", pr);
            DAL.close();
        }

        public void EDITE(string stname, string btitle, DateTime bdate1, DateTime bdate2, int price,int id)
        {
            SqlParameter[] pr = new SqlParameter[6];
            pr[0] = new SqlParameter("stname", stname);
            pr[1] = new SqlParameter("btitle", btitle);
            pr[2] = new SqlParameter("bdate1", bdate1);
            pr[3] = new SqlParameter("bdate2", bdate2);
            pr[4] = new SqlParameter("price", price);
            pr[5] = new SqlParameter("id", id);
            DAL.open();
            DAL.excute("PR_EDITEBOR", pr);
            DAL.close();
        }

        public void Delete(int id)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("id", id);
            DAL.open();
            DAL.excute("PR_DELETEBOR", pr);
            DAL.close();

        }

        public DataTable Search(string search)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("search", search);
            DataTable dt = new DataTable();
            dt = DAL.read("PR_SEARCHBOR", pr);
            return dt;
        }
    }
}
