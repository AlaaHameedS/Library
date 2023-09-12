using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace library.BL
{
    class CLS_USER
    {
        DAL.CLS_DAL DAL = new library.DAL.CLS_DAL();
        public DataTable LOAD()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADUSER", pr);
            return dt;
        }

        public void Insert(string cname, string cuser, string cpassword,string cprem, string cstate)
        {
            SqlParameter[] pr = new SqlParameter[5];
            pr[0] = new SqlParameter("cname", cname);
            pr[1] = new SqlParameter("cuser", cuser);
            pr[2] = new SqlParameter("cpassword", cpassword);
            pr[3] = new SqlParameter("cprem", cprem);
            pr[4] = new SqlParameter("cstate", cstate);
            DAL.open();
            DAL.excute("PR_INSERTUSER", pr);
            DAL.close();
        }

        public void EDITE(string cname, string cuser, string cpassword, string cprem, int id)
        {
            SqlParameter[] pr = new SqlParameter[5];
            pr[0] = new SqlParameter("cname", cname);
            pr[1] = new SqlParameter("cuser", cuser);
            pr[2] = new SqlParameter("cpassword", cpassword);
            pr[3] = new SqlParameter("cprem", cprem);
            pr[4] = new SqlParameter("id", id);
            DAL.open();
            DAL.excute("PR_EDITEUSER", pr);
            DAL.close();
        }

        public DataTable LOADEDITE(int id)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("id", id);
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADEDITEUSER", pr);
            return dt;
        }

        public void Delete(int id)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("id", id);
            DAL.open();
            DAL.excute("PR_DELETEUSER", pr);
            DAL.close();

        }

        public void LOGOUT()
        {
            SqlParameter[] pr = null;
            DAL.open();
            DAL.excute("PR_LOGOUT", pr);
            DAL.close();
        }

        public DataTable LOGIN(string cuser , string cpassword)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter("cuser", cuser);
            pr[1] = new SqlParameter("cpassword", cpassword);
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOGIN", pr);
            return dt;
        }

        public void UPDATELOGIN(string cuser, string cpassword)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter("cuser", cuser);
            pr[1] = new SqlParameter("cpassword", cpassword);
            DAL.open();
            DAL.excute("PL_UPDATELOGIN", pr);
            DAL.close();
        }
        // load data for start 
        public DataTable STARTLOAD()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_START", pr);
            return dt;
        }

    }
}
