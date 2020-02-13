using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MyQQ
{
    class DataOperator
    {
        private static string connString = "Data Source=DESKTOP-07NRAE7\\SQLEXPRESS;Database=db_MyQQ;UID=sa;Pwd=123456;";
        public static SqlConnection connection = new SqlConnection(connString);

        //返回结果中的第一行第一列
        public int ExecSQL(string sql)
        {
            SqlCommand command = new SqlCommand(sql, connection);   //指定要执行的SQL语句
            if (connection.State == ConnectionState.Closed)         //如果当前数据连接处于关闭状态
                connection.Open();                                  //那就打开它
            int num = Convert.ToInt32(command.ExecuteScalar());     //执行查询
            connection.Close();                                     //关闭数据库连接
            return num;                                             //返回结果中的第一行第一列
        }

        //返回受影响的行数
        public int ExecSQLResult(string sql)
        {
            SqlCommand command = new SqlCommand(sql, connection);//指定要执行的SQL语句
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            int result = command.ExecuteNonQuery();   //执行SQL语句 返回受影响的行数
            connection.Close();//执行完毕后关闭数据库连接
            return result;//返回受影响的行数
        }

        public DataSet GetDataSet(string sql)
        {
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, connection);//指定要执行的SQL语句
            DataSet ds = new DataSet();//创建数据集对象
            sqlda.Fill(ds);//填充数据集
            return ds;      //返回数据集
        }

        public SqlDataReader GetDataReader(string sql)
        {
            SqlCommand command = new SqlCommand(sql, connection);//指定要执行的QL语句
            connection.Open();//打开数据库连接
            SqlDataReader datareader = command.ExecuteReader();//生成SqlDataReader
            return datareader;//返回SqlDataReader
        }
    }
}
