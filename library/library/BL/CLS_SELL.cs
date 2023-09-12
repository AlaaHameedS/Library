using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace library.BL
{
    class CLS_SELL
    {
        DAL.CLS_DAL DAL = new library.DAL.CLS_DAL();
        public DataTable LOAD()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADSELL", pr);
            return dt;
        }
        // load book
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
        public void Insert(string stname, string btitle,  int price, DateTime bdate)
        {
            SqlParameter[] pr = new SqlParameter[4];
            pr[0] = new SqlParameter("stname", stname);
            pr[1] = new SqlParameter("btitle", btitle);
            pr[2] = new SqlParameter("price", price);
            pr[3] = new SqlParameter("bdate", bdate);
            DAL.open();
            DAL.excute("INSERTSELL", pr);
            DAL.close();
        }

        //update
        public void EDITE(string stname, string btitle, int price, DateTime bdate,int id)
        {
            SqlParameter[] pr = new SqlParameter[5];
            pr[0] = new SqlParameter("stname", stname);
            pr[1] = new SqlParameter("btitle", btitle);
            pr[2] = new SqlParameter("price", price);
            pr[3] = new SqlParameter("bdate", bdate);
            pr[4] = new SqlParameter("id", id);
            DAL.open();
            DAL.excute("PR_EDITESELL", pr);
            DAL.close();
        }


        public void Delete(int id)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("id", id);
            DAL.open();
            DAL.excute("PR_DELETESELL", pr);
            DAL.close();

        }

        public DataTable Search(string search)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("search", search);
            DataTable dt = new DataTable();
            dt = DAL.read("PR_SEARCHSELL", pr);
            return dt;
        }
    }
}
