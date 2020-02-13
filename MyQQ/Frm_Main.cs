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
using System.Media;

namespace MyQQ
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }
        int fromUserID; //存储消息发送者
        int freindHeadID;//存储发消息好友的头像ID
        int messageImageIndex = 0;//表示工具栏中消息图标的索引
        public static string nickName = "";//用户自己的昵称
        public static string strFlag = "[离线]";//存储用户的在线状态
        DataOperator dataOper = new DataOperator();

        // ShowInfo显示用户相关信息
        public void ShowInfo()
        {
            int headID = 0;
            //获取当前用户的昵称、头像
            string sql = "select NickName,HeadID,Sign from tb_User where ID=" + PublicClass.loginID + "";
            SqlDataReader dataReader = dataOper.GetDataReader(sql); //执行查询操作
            if (dataReader.Read())  //读取查询结果
            {
                if (!(dataReader["NickName"] is DBNull))//判断NickName 不为空
                {
                    nickName = dataReader["NickName"].ToString();//记录自己的昵称
                }
                headID = Convert.ToInt32(dataReader["HeadID"]);     //记录自己的头像ID
                txtSign.Text = dataReader["Sign"].ToString();       //显示个性签名
            }
            dataReader.Close(); //关闭读取器
            DataOperator.connection.Close();//关闭数据库连接
            this.Text = PublicClass.loginID.ToString(); //设置窗体标题为当前用户账号
            pboxHead.BackgroundImage = imglistHead.Images[headID];//显示用户头像
            lblName.Text = nickName + "(" + PublicClass.loginID + ")";//显示昵称及账号
             
        }

        //显示好友列表的方法
        private void ShowFriendList()
        {
            lvFriend.Items.Clear(); //清空原来的列表
            //定义查找好友的SQL语句
            string sql = "select FriendID,NickName,HeadID,Flag from tb_User,tb_Friend where tb_Friend.HostID = " + PublicClass.loginID + " and tb_User.ID = tb_Friend.FriendID";
            SqlDataReader dataReader = dataOper.GetDataReader(sql);//执行查询
            int i = lvFriend.Items.Count;          //记录添加到ListView 中的项索引
            while (dataReader.Read())                //循环添加好友列表
            {
                if (dataReader["Flag"].ToString() == "0")
                    strFlag = "[离线]";
                else
                    strFlag = "[在线]";
                string strTemp = dataReader["NickName"].ToString(); //记录好友昵称
                                                                    //对好友昵称进行处理
                string strFriendName = strTemp;
                if (strTemp.Length < 9)
                    strFriendName = strTemp.PadLeft(9, ' ');
                else
                    strFriendName = (strTemp.Substring(0, 2) + "...").PadLeft(9, ' ');
                //向ListView中添加项，Name：好友ID，值：昵称，要显示的头像
                lvFriend.Items.Add(dataReader["FriendID"].ToString(), strFriendName + strFlag,
                    (int)dataReader["HeadID"]);
                lvFriend.Items[i].Group = lvFriend.Groups[0]; //设置项的分组为我的好友
                i++;    //临时变量加1 
            }
            dataReader.Close();//关闭读取器
            DataOperator.connection.Close();//关闭数据库连接

        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            tsbtnMessageReading.Image = imglistMessage.Images[0];
            ShowInfo();
            ShowFriendList(); 
            
        }

        private void tsbtnInfo_Click(object sender, EventArgs e)
        {
            Frm_EditInfo frmInfo = new Frm_EditInfo();
            frmInfo.Show();

             
        }

        private void tsbtnSearchFriend_Click(object sender, EventArgs e)
        {
            Frm_AddFriend frmAddFriend = new Frm_AddFriend();
            frmAddFriend.Show();
        }

        private void tsbtnUpdateFriendList_Click(object sender, EventArgs e)
        {
            ShowFriendList();
        }

        private void tsbtnMessageReading_Click(object sender, EventArgs e)
        {
            tmAddFriend.Stop();
            messageImageIndex = 0;
            tsbtnMessageReading.Image = imglistMessage.Images[messageImageIndex];
            Frm_Remind frmRemind = new Frm_Remind();
            frmRemind.Show();
        }

        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确实要t出吗？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            
        }

        Frm_Chat frmChat;
        private void lvFriend_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvFriend.SelectedItems.Count>0)//判断是否有选中项
            {
                if (frmChat == null) //判断聊天窗体对象是否为空
                {
                    frmChat = new Frm_Chat();//创建聊天窗体对象
                    frmChat.friendID = Convert.ToInt32(lvFriend.SelectedItems[0].Name);//记录聊天的账号
                    frmChat.nickName = dataOper.GetDataSet("select NickName from tb_User where ID=" + frmChat.friendID).Tables[0].Rows[0][0].ToString();//记录昵称
                    frmChat.headID = Convert.ToInt32(dataOper.GetDataSet("select HeadID from tb_User where ID=" + frmChat.friendID).Tables[0].Rows[0][0]) + 1;//记录头像
                    frmChat.ShowDialog(); //以对话框显示聊天窗体对象
                    frmChat = null;//将聊天窗体对象设置为空
                }
                if(tmChat.Enabled == true)//如果聊天定时器处于可用状态
                {
                    tmChat.Stop();//停止聊天定时器
                    lvFriend.SelectedItems[0].ImageIndex = freindHeadID;//将选中项得头像显示为正常状态
                }
            }
        }
    }
}
