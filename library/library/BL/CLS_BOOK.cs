using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
namespace library.BL
{
    class CLS_BOOK
    {
        DAL.CLS_DAL DAL = new library.DAL.CLS_DAL();

        // method to load book 
        public DataTable LOAD()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADBOOK", pr);
            return dt;
        }

        // method load cat 
        public DataTable LOADCAT()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADCATCBO", pr);
            return dt;
        }

        public void Insert(string title, string author, string cat, string price, DateTime bdate, int rate, MemoryStream cover)
        {
            SqlParameter[] pr = new SqlParameter[7];
            pr[0] = new SqlParameter("title", title);
            pr[1] = new SqlParameter("author", author);
            pr[2] = new SqlParameter("cat", cat);
            pr[3] = new SqlParameter("price", price);
            pr[4] = new SqlParameter("bdate", bdate);
            pr[5] = new SqlParameter("rate", rate);
            pr[6] = new SqlParameter("cover", cover.ToArray());
            DAL.open();
            DAL.excute("PR_INSERTBOOK", pr);
            DAL.close();
        }

        // load data for edite 
        public DataTable LOADEDITE(int id )
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("id", id);
            DataTable dt = new DataTable();
            dt = DAL.read("PR_SELECTEDITE", pr);
            return dt;
        }

        // update book data 
        public void EDITE(string title, string author, string cat, string price, DateTime bdate, int rate, MemoryStream cover,int id)
        {
            SqlParameter[] pr = new SqlParameter[8];
            pr[0] = new SqlParameter("title", title);
            pr[1] = new SqlParameter("author", author);
            pr[2] = new SqlParameter("cat", cat);
            pr[3] = new SqlParameter("price", price);
            pr[4] = new SqlParameter("bdate", bdate);
            pr[5] = new SqlParameter("rate", rate);
            pr[6] = new SqlParameter("cover", cover.ToArray());
            pr[7] = new SqlParameter("id", id);
            DAL.open();
            DAL.excute("PR_EDITEBOOK", pr);
            DAL.close();
        }

        // delete data 
        public void Delete(int id)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("id", id);
            DAL.open();
            DAL.excute("PR_DELETEBOOK", pr);
            DAL.close();

        }

        public DataTable Search(string search)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("search", search);
            DataTable dt = new DataTable();
            dt = DAL.read("PR_SEARCHBOOK", pr);
            return dt;
        }
    }
}
