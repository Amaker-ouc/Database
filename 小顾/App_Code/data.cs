using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// data 的摘要说明
/// </summary>
public class data
{
    static string str = @"server=SUPERPC;Integrated Security=SSPI;database=Restaurant;";
        public static DataTable DataTable(string select)
        {
            using (SqlConnection conn = new SqlConnection(str))
            {
                DataTable dt = new DataTable();
                {
                    conn.Open();//打开
                    SqlDataAdapter da = new SqlDataAdapter(select, conn);
                    da.Fill(dt);//进行填充
                }
                return dt;//返回这个数据集
                
            }

        }
        public static void OperateLine(string SQL)
        {
            using (SqlConnection conn = new SqlConnection(str))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(SQL, conn);
                cmd.ExecuteNonQuery();
            }
        }

  
}