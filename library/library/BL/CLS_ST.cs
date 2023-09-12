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
    class CLS_ST
    {
        DAL.CLS_DAL DAL = new library.DAL.CLS_DAL();
        // load student 
        public DataTable LOAD()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADST", pr);
            return dt;
        }

        // add student 
        public void Insert(string name, string stlocation, string phone, string email, string school, string dep, MemoryStream cover)
        {
            SqlParameter[] pr = new SqlParameter[7];
            pr[0] = new SqlParameter("name", name);
            pr[1] = new SqlParameter("stlocation", stlocation);
            pr[2] = new SqlParameter("phone", phone);
            pr[3] = new SqlParameter("email", email);
            pr[4] = new SqlParameter("school", school);
            pr[5] = new SqlParameter("dep", dep);
            pr[6] = new SqlParameter("cover", cover.ToArray());
            DAL.open();
            DAL.excute("PR_INSERTST", pr);
            DAL.close();
        }
        // load edite student 
        public DataTable LOADEDITE(int id)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("id", id);
            DataTable dt = new DataTable();
            dt = DAL.read("PR_SELECTEDITST", pr);
            return dt;
        }


        // update student 
        public void Edite(string name, string stlocation, string phone, string email, string school, string dep, MemoryStream cover , int id )
        {
            SqlParameter[] pr = new SqlParameter[8];
            pr[0] = new SqlParameter("name", name);
            pr[1] = new SqlParameter("stlocation", stlocation);
            pr[2] = new SqlParameter("phone", phone);
            pr[3] = new SqlParameter("email", email);
            pr[4] = new SqlParameter("school", school);
            pr[5] = new SqlParameter("dep", dep);
            pr[6] = new SqlParameter("cover", cover.ToArray());
            pr[7] = new SqlParameter("id", id);
            DAL.open();
            DAL.excute("PR_EDITEST", pr);
            DAL.close();
        }

        // delete student 
        public void Delete(int id)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("id", id);
            DAL.open();
            DAL.excute("PR_DELETEST", pr);
            DAL.close();

        }
        // search student
        public DataTable Search(string search)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("search", search);
            DataTable dt = new DataTable();
            dt = DAL.read("PR_SEARCHST", pr);
            return dt;
        }
    }
}
