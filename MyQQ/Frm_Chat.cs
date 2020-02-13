using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyQQ
{
    public partial class Frm_Chat : Form
    {
        public Frm_Chat()
        {
            InitializeComponent();
        }

        public int friendID = 0; //用户账户
        public string nickName; //昵称
        public int headID;      //头像
        DataOperator dataOper = new DataOperator();
        private void SetMessage(string messageID)
        {
            string[] messageIDs = messageID.Split('_');//分割出每个消息ID
            string sql = "update tb_Message set MessageSetate = 1 where ID=";//定义更新SQL语句
            foreach (string id in messageIDs) //遍历所有消息ID
            {
                if (id != "")
                {
                    sql += id;//设置更新条件
                    int result = dataOper.ExecSQLResult(sql);//执行数据表更新操作
                }
            }
        }

        private void ShowMessage()
        {
            string messageID = "";//消息ID组成的字符串
            string message;//消息内容
            string messageTime;//消息发送时间
            string sql = "select ID,Message,MessageTime from tb_Message where FromUserID =" + friendID + "and ToUserID=" + PublicClass.loginID + "and MessageTypeID=1 and MessageState=0";
            SqlDataReader datareader = dataOper.GetDataReader(sql);
            //循环将消息添加到窗体上
            while (datareader.Read())
            {
                messageID += datareader["ID"] + "_";//消息ID
                message = datareader["Message"].ToString();//消息
                //消息的发送时间
                messageTime = Convert.ToDateTime(datareader["MessageTime"]).ToString();
                //设置消息显示格式
                rtxtMessage.Text += "\n" + nickName + " " + messageTime + "\n " + message + "";
            }
            DataOperator.connection.Close();//关闭数据库连接
            if (messageID.Length >1) //判断是否存在消息
            {
                messageID.Remove(messageID.Length - 1);//去掉最后的连接符
                SetMessage(messageID);//将显示的消息设置为已读
            }
          
        }

        private void Frm_Chat_Load(object sender, EventArgs e)
        {
            this.Text="与\""+nickName+ "\"聊天中";
            pboxHead.Image = imglistHead.Images[headID -1 ];
            lblFriend.Text = string.Format("{0}{1}", nickName, friendID);
            rtxtMessage.ScrollToCaret();

        }

        private void tmShowMessage_Tick(object sender, EventArgs e)
        {
            ShowMessage();//显示所有未读消息

        }
    }
}
