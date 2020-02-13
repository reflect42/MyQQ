namespace MyQQ
{
    partial class Frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("好友列表", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("陌生人列表", System.Windows.Forms.HorizontalAlignment.Left);
            this.imglistHead = new System.Windows.Forms.ImageList(this.components);
            this.imglistSmallHead = new System.Windows.Forms.ImageList(this.components);
            this.imglistMessage = new System.Windows.Forms.ImageList(this.components);
            this.tmMessage = new System.Windows.Forms.Timer(this.components);
            this.tmAddFriend = new System.Windows.Forms.Timer(this.components);
            this.tmChat = new System.Windows.Forms.Timer(this.components);
            this.lblName = new System.Windows.Forms.Label();
            this.pboxMin = new System.Windows.Forms.PictureBox();
            this.pboxClose = new System.Windows.Forms.PictureBox();
            this.pboxHead = new System.Windows.Forms.PictureBox();
            this.lvFriend = new System.Windows.Forms.ListView();
            this.cmsFriendList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsMenuView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuDel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsOperation = new System.Windows.Forms.ToolStrip();
            this.tsbtnInfo = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSearchFriend = new System.Windows.Forms.ToolStripButton();
            this.tsbtnUpdateFriendList = new System.Windows.Forms.ToolStripButton();
            this.tsbtnMessageReading = new System.Windows.Forms.ToolStripButton();
            this.tsbtnExit = new System.Windows.Forms.ToolStripButton();
            this.txtSign = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxHead)).BeginInit();
            this.cmsFriendList.SuspendLayout();
            this.tsOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // imglistHead
            // 
            this.imglistHead.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglistHead.ImageStream")));
            this.imglistHead.TransparentColor = System.Drawing.Color.Transparent;
            this.imglistHead.Images.SetKeyName(0, "1.bmp");
            this.imglistHead.Images.SetKeyName(1, "2.bmp");
            this.imglistHead.Images.SetKeyName(2, "3.bmp");
            this.imglistHead.Images.SetKeyName(3, "4.bmp");
            this.imglistHead.Images.SetKeyName(4, "5.bmp");
            this.imglistHead.Images.SetKeyName(5, "6.bmp");
            this.imglistHead.Images.SetKeyName(6, "7.bmp");
            this.imglistHead.Images.SetKeyName(7, "8.bmp");
            this.imglistHead.Images.SetKeyName(8, "9.bmp");
            this.imglistHead.Images.SetKeyName(9, "10.bmp");
            this.imglistHead.Images.SetKeyName(10, "11.bmp");
            this.imglistHead.Images.SetKeyName(11, "12.bmp");
            this.imglistHead.Images.SetKeyName(12, "13.bmp");
            this.imglistHead.Images.SetKeyName(13, "14.bmp");
            this.imglistHead.Images.SetKeyName(14, "15.bmp");
            this.imglistHead.Images.SetKeyName(15, "16.bmp");
            this.imglistHead.Images.SetKeyName(16, "17.bmp");
            this.imglistHead.Images.SetKeyName(17, "18.bmp");
            this.imglistHead.Images.SetKeyName(18, "19.bmp");
            this.imglistHead.Images.SetKeyName(19, "20.bmp");
            this.imglistHead.Images.SetKeyName(20, "21.bmp");
            this.imglistHead.Images.SetKeyName(21, "22.bmp");
            this.imglistHead.Images.SetKeyName(22, "23.bmp");
            this.imglistHead.Images.SetKeyName(23, "24.bmp");
            this.imglistHead.Images.SetKeyName(24, "25.bmp");
            this.imglistHead.Images.SetKeyName(25, "26.bmp");
            this.imglistHead.Images.SetKeyName(26, "27.bmp");
            this.imglistHead.Images.SetKeyName(27, "28.bmp");
            this.imglistHead.Images.SetKeyName(28, "29.bmp");
            this.imglistHead.Images.SetKeyName(29, "30.bmp");
            this.imglistHead.Images.SetKeyName(30, "31.bmp");
            this.imglistHead.Images.SetKeyName(31, "32.bmp");
            this.imglistHead.Images.SetKeyName(32, "33.bmp");
            this.imglistHead.Images.SetKeyName(33, "34.bmp");
            this.imglistHead.Images.SetKeyName(34, "35.bmp");
            this.imglistHead.Images.SetKeyName(35, "36.bmp");
            this.imglistHead.Images.SetKeyName(36, "37.bmp");
            this.imglistHead.Images.SetKeyName(37, "38.bmp");
            this.imglistHead.Images.SetKeyName(38, "39.bmp");
            this.imglistHead.Images.SetKeyName(39, "40.bmp");
            this.imglistHead.Images.SetKeyName(40, "41.bmp");
            this.imglistHead.Images.SetKeyName(41, "42.bmp");
            this.imglistHead.Images.SetKeyName(42, "43.bmp");
            this.imglistHead.Images.SetKeyName(43, "44.bmp");
            this.imglistHead.Images.SetKeyName(44, "45.bmp");
            this.imglistHead.Images.SetKeyName(45, "46.bmp");
            this.imglistHead.Images.SetKeyName(46, "47.bmp");
            this.imglistHead.Images.SetKeyName(47, "48.bmp");
            this.imglistHead.Images.SetKeyName(48, "49.bmp");
            this.imglistHead.Images.SetKeyName(49, "50.bmp");
            this.imglistHead.Images.SetKeyName(50, "51.bmp");
            this.imglistHead.Images.SetKeyName(51, "52.bmp");
            this.imglistHead.Images.SetKeyName(52, "53.bmp");
            this.imglistHead.Images.SetKeyName(53, "54.bmp");
            this.imglistHead.Images.SetKeyName(54, "55.bmp");
            this.imglistHead.Images.SetKeyName(55, "56.bmp");
            this.imglistHead.Images.SetKeyName(56, "57.bmp");
            this.imglistHead.Images.SetKeyName(57, "58.bmp");
            this.imglistHead.Images.SetKeyName(58, "59.bmp");
            this.imglistHead.Images.SetKeyName(59, "60.bmp");
            this.imglistHead.Images.SetKeyName(60, "61.bmp");
            this.imglistHead.Images.SetKeyName(61, "62.bmp");
            this.imglistHead.Images.SetKeyName(62, "63.bmp");
            this.imglistHead.Images.SetKeyName(63, "64.bmp");
            this.imglistHead.Images.SetKeyName(64, "65.bmp");
            this.imglistHead.Images.SetKeyName(65, "66.bmp");
            this.imglistHead.Images.SetKeyName(66, "67.bmp");
            this.imglistHead.Images.SetKeyName(67, "68.bmp");
            this.imglistHead.Images.SetKeyName(68, "69.bmp");
            this.imglistHead.Images.SetKeyName(69, "70.bmp");
            this.imglistHead.Images.SetKeyName(70, "71.bmp");
            this.imglistHead.Images.SetKeyName(71, "72.bmp");
            this.imglistHead.Images.SetKeyName(72, "73.bmp");
            this.imglistHead.Images.SetKeyName(73, "74.bmp");
            this.imglistHead.Images.SetKeyName(74, "75.bmp");
            this.imglistHead.Images.SetKeyName(75, "76.bmp");
            this.imglistHead.Images.SetKeyName(76, "77.bmp");
            this.imglistHead.Images.SetKeyName(77, "78.bmp");
            this.imglistHead.Images.SetKeyName(78, "79.bmp");
            this.imglistHead.Images.SetKeyName(79, "80.bmp");
            this.imglistHead.Images.SetKeyName(80, "81.bmp");
            this.imglistHead.Images.SetKeyName(81, "82.bmp");
            this.imglistHead.Images.SetKeyName(82, "83.bmp");
            this.imglistHead.Images.SetKeyName(83, "84.bmp");
            this.imglistHead.Images.SetKeyName(84, "85.bmp");
            this.imglistHead.Images.SetKeyName(85, "86.bmp");
            this.imglistHead.Images.SetKeyName(86, "87.bmp");
            this.imglistHead.Images.SetKeyName(87, "88.bmp");
            this.imglistHead.Images.SetKeyName(88, "89.bmp");
            this.imglistHead.Images.SetKeyName(89, "90.bmp");
            this.imglistHead.Images.SetKeyName(90, "91.bmp");
            this.imglistHead.Images.SetKeyName(91, "92.bmp");
            this.imglistHead.Images.SetKeyName(92, "93.bmp");
            this.imglistHead.Images.SetKeyName(93, "94.bmp");
            this.imglistHead.Images.SetKeyName(94, "95.bmp");
            this.imglistHead.Images.SetKeyName(95, "96.bmp");
            this.imglistHead.Images.SetKeyName(96, "97.bmp");
            this.imglistHead.Images.SetKeyName(97, "98.bmp");
            this.imglistHead.Images.SetKeyName(98, "99.bmp");
            this.imglistHead.Images.SetKeyName(99, "100.bmp");
            this.imglistHead.Images.SetKeyName(100, "back.bmp");
            // 
            // imglistSmallHead
            // 
            this.imglistSmallHead.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglistSmallHead.ImageStream")));
            this.imglistSmallHead.TransparentColor = System.Drawing.Color.Transparent;
            this.imglistSmallHead.Images.SetKeyName(0, "1-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(1, "2-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(2, "3-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(3, "4-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(4, "5-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(5, "6-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(6, "7-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(7, "8-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(8, "9-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(9, "10-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(10, "11-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(11, "12-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(12, "13-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(13, "14-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(14, "15-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(15, "16-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(16, "17-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(17, "18-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(18, "19-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(19, "20-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(20, "21-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(21, "22-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(22, "23-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(23, "24-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(24, "25-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(25, "26-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(26, "27-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(27, "28-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(28, "29-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(29, "30-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(30, "31-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(31, "32-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(32, "33-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(33, "34-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(34, "35-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(35, "36-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(36, "37-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(37, "38-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(38, "39-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(39, "40-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(40, "41-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(41, "42-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(42, "43-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(43, "44-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(44, "45-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(45, "46-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(46, "47-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(47, "48-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(48, "49-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(49, "50-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(50, "51-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(51, "52-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(52, "53-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(53, "54-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(54, "55-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(55, "56-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(56, "57-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(57, "58-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(58, "59-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(59, "60-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(60, "61-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(61, "62-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(62, "63-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(63, "64-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(64, "65-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(65, "66-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(66, "67-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(67, "68-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(68, "69-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(69, "70-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(70, "71-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(71, "72-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(72, "73-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(73, "74-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(74, "75-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(75, "76-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(76, "77-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(77, "78-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(78, "79-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(79, "80-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(80, "81-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(81, "82-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(82, "83-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(83, "84-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(84, "85-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(85, "86-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(86, "87-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(87, "88-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(88, "89-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(89, "90-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(90, "91-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(91, "92-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(92, "93-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(93, "94-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(94, "95-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(95, "96-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(96, "97-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(97, "98-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(98, "99-1.bmp");
            this.imglistSmallHead.Images.SetKeyName(99, "100-1.bmp");
            // 
            // imglistMessage
            // 
            this.imglistMessage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglistMessage.ImageStream")));
            this.imglistMessage.TransparentColor = System.Drawing.Color.Transparent;
            this.imglistMessage.Images.SetKeyName(0, "info.png");
            this.imglistMessage.Images.SetKeyName(1, "Message.gif");
            // 
            // tmMessage
            // 
            this.tmMessage.Enabled = true;
            this.tmMessage.Interval = 2000;
            // 
            // tmAddFriend
            // 
            this.tmAddFriend.Interval = 1000;
            // 
            // tmChat
            // 
            this.tmChat.Interval = 500;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.Location = new System.Drawing.Point(81, 44);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 16);
            this.lblName.TabIndex = 0;
            // 
            // pboxMin
            // 
            this.pboxMin.BackColor = System.Drawing.Color.Transparent;
            this.pboxMin.Location = new System.Drawing.Point(221, 8);
            this.pboxMin.Name = "pboxMin";
            this.pboxMin.Size = new System.Drawing.Size(22, 18);
            this.pboxMin.TabIndex = 2;
            this.pboxMin.TabStop = false;
            // 
            // pboxClose
            // 
            this.pboxClose.BackColor = System.Drawing.Color.Transparent;
            this.pboxClose.Location = new System.Drawing.Point(250, 8);
            this.pboxClose.Name = "pboxClose";
            this.pboxClose.Size = new System.Drawing.Size(22, 18);
            this.pboxClose.TabIndex = 3;
            this.pboxClose.TabStop = false;
            // 
            // pboxHead
            // 
            this.pboxHead.BackColor = System.Drawing.Color.Transparent;
            this.pboxHead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxHead.Location = new System.Drawing.Point(6, 40);
            this.pboxHead.Name = "pboxHead";
            this.pboxHead.Size = new System.Drawing.Size(66, 66);
            this.pboxHead.TabIndex = 4;
            this.pboxHead.TabStop = false;
            // 
            // lvFriend
            // 
            this.lvFriend.BackColor = System.Drawing.Color.White;
            this.lvFriend.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvFriend.ContextMenuStrip = this.cmsFriendList;
            listViewGroup3.Header = "好友列表";
            listViewGroup3.Name = "listViewGroup1";
            listViewGroup4.Header = "陌生人列表";
            listViewGroup4.Name = "listViewGroup2";
            this.lvFriend.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup3,
            listViewGroup4});
            this.lvFriend.HideSelection = false;
            this.lvFriend.LabelWrap = false;
            this.lvFriend.LargeImageList = this.imglistHead;
            this.lvFriend.Location = new System.Drawing.Point(2, 174);
            this.lvFriend.MultiSelect = false;
            this.lvFriend.Name = "lvFriend";
            this.lvFriend.Size = new System.Drawing.Size(274, 436);
            this.lvFriend.SmallImageList = this.imglistSmallHead;
            this.lvFriend.StateImageList = this.imglistSmallHead;
            this.lvFriend.TabIndex = 5;
            this.lvFriend.UseCompatibleStateImageBehavior = false;
            this.lvFriend.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvFriend_MouseDoubleClick);
            // 
            // cmsFriendList
            // 
            this.cmsFriendList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuView,
            this.tsMenuAdd,
            this.tsMenuDel});
            this.cmsFriendList.Name = "contextMenuStrip1";
            this.cmsFriendList.Size = new System.Drawing.Size(125, 70);
            // 
            // tsMenuView
            // 
            this.tsMenuView.Name = "tsMenuView";
            this.tsMenuView.Size = new System.Drawing.Size(124, 22);
            this.tsMenuView.Text = "小头像";
            // 
            // tsMenuAdd
            // 
            this.tsMenuAdd.Name = "tsMenuAdd";
            this.tsMenuAdd.Size = new System.Drawing.Size(124, 22);
            this.tsMenuAdd.Text = "添加好友";
            this.tsMenuAdd.Visible = false;
            // 
            // tsMenuDel
            // 
            this.tsMenuDel.Name = "tsMenuDel";
            this.tsMenuDel.Size = new System.Drawing.Size(124, 22);
            this.tsMenuDel.Text = "删除";
            this.tsMenuDel.Visible = false;
            // 
            // tsOperation
            // 
            this.tsOperation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsOperation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnInfo,
            this.tsbtnSearchFriend,
            this.tsbtnUpdateFriendList,
            this.tsbtnMessageReading,
            this.tsbtnExit});
            this.tsOperation.Location = new System.Drawing.Point(0, 622);
            this.tsOperation.Name = "tsOperation";
            this.tsOperation.Size = new System.Drawing.Size(275, 25);
            this.tsOperation.TabIndex = 7;
            this.tsOperation.Text = "toolStrip1";
            // 
            // tsbtnInfo
            // 
            this.tsbtnInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnInfo.Image")));
            this.tsbtnInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnInfo.Name = "tsbtnInfo";
            this.tsbtnInfo.Size = new System.Drawing.Size(23, 22);
            this.tsbtnInfo.Text = "toolStripButton1";
            this.tsbtnInfo.Click += new System.EventHandler(this.tsbtnInfo_Click);
            // 
            // tsbtnSearchFriend
            // 
            this.tsbtnSearchFriend.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSearchFriend.Image")));
            this.tsbtnSearchFriend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSearchFriend.Name = "tsbtnSearchFriend";
            this.tsbtnSearchFriend.Size = new System.Drawing.Size(52, 22);
            this.tsbtnSearchFriend.Text = "查找";
            this.tsbtnSearchFriend.Click += new System.EventHandler(this.tsbtnSearchFriend_Click);
            // 
            // tsbtnUpdateFriendList
            // 
            this.tsbtnUpdateFriendList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnUpdateFriendList.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnUpdateFriendList.Image")));
            this.tsbtnUpdateFriendList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnUpdateFriendList.Name = "tsbtnUpdateFriendList";
            this.tsbtnUpdateFriendList.Size = new System.Drawing.Size(23, 22);
            this.tsbtnUpdateFriendList.Text = "toolStripButton1";
            this.tsbtnUpdateFriendList.Click += new System.EventHandler(this.tsbtnUpdateFriendList_Click);
            // 
            // tsbtnMessageReading
            // 
            this.tsbtnMessageReading.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnMessageReading.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnMessageReading.Image")));
            this.tsbtnMessageReading.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnMessageReading.Name = "tsbtnMessageReading";
            this.tsbtnMessageReading.Size = new System.Drawing.Size(23, 22);
            this.tsbtnMessageReading.Text = "toolStripButton1";
            this.tsbtnMessageReading.Click += new System.EventHandler(this.tsbtnMessageReading_Click);
            // 
            // tsbtnExit
            // 
            this.tsbtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnExit.Image")));
            this.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExit.Name = "tsbtnExit";
            this.tsbtnExit.Size = new System.Drawing.Size(23, 22);
            this.tsbtnExit.Text = "toolStripButton1";
            this.tsbtnExit.Click += new System.EventHandler(this.tsbtnExit_Click);
            // 
            // txtSign
            // 
            this.txtSign.AutoSize = true;
            this.txtSign.BackColor = System.Drawing.Color.Transparent;
            this.txtSign.Location = new System.Drawing.Point(78, 73);
            this.txtSign.Name = "txtSign";
            this.txtSign.Size = new System.Drawing.Size(0, 12);
            this.txtSign.TabIndex = 8;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(275, 647);
            this.Controls.Add(this.txtSign);
            this.Controls.Add(this.tsOperation);
            this.Controls.Add(this.lvFriend);
            this.Controls.Add(this.pboxHead);
            this.Controls.Add(this.pboxClose);
            this.Controls.Add(this.pboxMin);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(800, 5);
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Q友";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxHead)).EndInit();
            this.cmsFriendList.ResumeLayout(false);
            this.tsOperation.ResumeLayout(false);
            this.tsOperation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imglistHead;
        private System.Windows.Forms.ImageList imglistSmallHead;
        private System.Windows.Forms.ImageList imglistMessage;
        private System.Windows.Forms.Timer tmMessage;
        private System.Windows.Forms.Timer tmAddFriend;
        private System.Windows.Forms.Timer tmChat;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pboxMin;
        private System.Windows.Forms.PictureBox pboxClose;
        private System.Windows.Forms.PictureBox pboxHead;
        private System.Windows.Forms.ListView lvFriend;
        private System.Windows.Forms.ContextMenuStrip cmsFriendList;
        private System.Windows.Forms.ToolStripMenuItem tsMenuView;
        private System.Windows.Forms.ToolStripMenuItem tsMenuAdd;
        private System.Windows.Forms.ToolStripMenuItem tsMenuDel;
        private System.Windows.Forms.ToolStrip tsOperation;
        private System.Windows.Forms.ToolStripButton tsbtnInfo;
        private System.Windows.Forms.ToolStripButton tsbtnSearchFriend;
        private System.Windows.Forms.ToolStripButton tsbtnUpdateFriendList;
        private System.Windows.Forms.ToolStripButton tsbtnMessageReading;
        private System.Windows.Forms.ToolStripButton tsbtnExit;
        private System.Windows.Forms.Label txtSign;
    }
}