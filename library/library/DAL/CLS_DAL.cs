using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace library.DAL
{
    class CLS_DAL
    {
        SqlConnection con ;

        public CLS_DAL ()
        {
            con = new SqlConnection(@"Data Source =.; Initial Catalog = DBLIBM; Integrated Security = True");
            
        }

        //Method to open SQL CON

        public void open()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

        }


        //Method to close SQL CON
        public void close()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

        }

        // method to raed sql 

        public DataTable read(string store , SqlParameter[] pr)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = store;
            if(pr != null)
            {
                cmd.Parameters.AddRange(pr);
            }

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }



        // method to exicute sql  (insert,update , delete)

        public void excute(string store, SqlParameter[] pr)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = store;
            if (pr != null)
            {
                cmd.Parameters.AddRange(pr);
            }
            cmd.ExecuteNonQuery();

        }

    }
}
