using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using IRemoteEMS;

namespace CRemoteEMS
{
    public class CRemote:MarshalByRefObject,IRemote
    {
        public void insert(string in_cmd)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            conn.ConnectionString = "Data Source=.;Initial Catalog=ems;Integrated Security=True";
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = in_cmd;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void delete(string del_cmd)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            conn.ConnectionString = "Data Source=.;Initial Catalog=ems;Integrated Security=True";
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = del_cmd;
            cmd.ExecuteNonQuery();
            conn.Close();
        } 
        public void update(string up_cmd)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            conn.ConnectionString = "Data Source=.;Initial Catalog=ems;Integrated Security=True";
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = up_cmd;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public DataTable select(string sel_cmd)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            conn.ConnectionString = "Data Source=.;Initial Catalog=ems;Integrated Security=True";
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = sel_cmd;
            SqlDataAdapter ad = new SqlDataAdapter();
            ad.SelectCommand = cmd;
            DataSet ds = new DataSet();
            ad.Fill(ds);
            DataTable dt = ds.Tables[0];
            return dt;
        }
    }
}
