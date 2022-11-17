using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Gym
{
    class Modify
    {
        public Modify()
        {
        }

        SqlCommand sqlCommand; //dung de truy van cac cau lenh CRUD
        SqlDataReader dataReader;//dung de doc du lieu trong Table

        public SqlDataReader GetDataReader()
        {
            return dataReader;
        }

        public List<TaiKhoan> TaiKhoans(string query) //check tai khoan
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();

            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();

                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                
                while (dataReader.Read())//doc du lieu theo tung dong
                {
                    taiKhoans.Add(new TaiKhoan(dataReader.GetString(0),dataReader.GetString(1)));
                }
                sqlConnection.Close();
            }
                return taiKhoans;
        }

        public void Command(string query)//dang ky tai khoan
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();//thuc thi cau truy van

                sqlConnection.Close();
            }
        } 
    }
}
