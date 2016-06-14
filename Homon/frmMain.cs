using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;

namespace Homon
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class frmMain : System.Windows.Forms.Form
	{
		class SelectData
		{
			private DateTime selectDate;

			public SelectData()
			{
				this.selectDate = System.DateTime.Today;
			}
			public SelectData(DateTime sel)
			{
				this.selectDate = sel;
			}
			public int SelectYear
			{
				get {return selectDate.Year;}
			}
			public int SelectMonth
			{
				get {return selectDate.Month;}
			}
			public int SelectDay
			{
				get {return selectDate.Day;}
			}
			public DateTime SelectDate
			{
				get {return selectDate;}
				set {selectDate = value;}
			}
		}

		class BirthData
		{
			private DateTime birthday;

			public BirthData()
			{
				this.birthday = System.DateTime.Today;
			}
			public BirthData(DateTime birth)
			{
				this.birthday = birth;
			}
			public DateTime Birthday
			{
				get {return birthday;}
				set {birthday = value;}
			}

			public int BirthYear
			{
				get { return birthday.Year;}
			}
			public int BirthMonth
			{
				get {return birthday.Month;}
			}
			public int BirthDate
			{
				get {return birthday.Day;}
			}
		}


		private BirthData birthData;
		private SelectData selectData;
		private FittedCustomer fittedCustomer;

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem mnuUser;
		private System.Windows.Forms.MenuItem mnuCustomer;
		private System.Windows.Forms.MenuItem mnuExit;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnSel;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.NumericUpDown udMaxPhy;
		private System.Windows.Forms.NumericUpDown udMinPhy;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.NumericUpDown udMinEmo;
		private System.Windows.Forms.NumericUpDown udMaxEmo;
		private System.Windows.Forms.NumericUpDown udMinWis;
		private System.Windows.Forms.NumericUpDown udMaxWis;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmMain()
		{
			InitializeComponent();
		}

		public frmMain(string UserRight)
		{
			InitializeComponent();
			if (UserRight == "0")
			{
				this.mnuUser.Enabled = false;
			}

			birthData = new BirthData();
			selectData = new SelectData();
			fittedCustomer = new FittedCustomer();

		}

		protected override void OnPaint(PaintEventArgs e)
		{
			//这个月的一号,到生日的相差的日子.
			int byear,bmonth,bday;
			int year,month,day;

			byear=birthData.BirthYear;
			bmonth=birthData.BirthMonth;
			bday=birthData.BirthDate;

			
			year=selectData.SelectYear;
			month=selectData.SelectMonth;
			day=selectData.SelectDay;


			DateTime dt1=new DateTime(byear,bmonth,bday,1,1,1);
			DateTime dt2=new DateTime(year,month,1,1,1,1);
			DateTime dt3=new DateTime (year,month,day,1,1,1);



			;

			int x = this.GetDays(dt3,dt1);
			int y = this.GetDays(dt2,dt1);


			Debug.WriteLine(x%23);

			double x1 = Math.Sin((((double)(x%23)/23)*2-0.5)*3.1415926)*100;
			double x2 = Math.Sin((((double)(x%28)/28)*2-0.5)*3.1415926)*100;
			double x3 = Math.Sin((((double)(x%33)/33)*2-0.5)*3.1415926)*100;

			Debug.WriteLine(x.ToString()+"@"+x1.ToString()+":"+x1.ToString()+":"+x1.ToString());


			string str1,str2,str3;	
			string st = x1.ToString();
			if(x1.ToString().Length>=5)
			{
				
				str1 = x1.ToString().Substring(0,5)+"%";

			}
			else
			{
				str1 = x1.ToString()+"%";
			}
			if(x2.ToString().Length>=5)
			{
				str2 = x2.ToString().Substring(0,5)+"%";
			}
			else
			{
				str2 = x2.ToString()+"%";
			}
			if(x3.ToString().Length>=5)
			{
				str3 = x3.ToString().Substring(0,5)+"%";
			}
			else
			{
				str3 = x3.ToString()+"%";
			}
				
			

			Graphics dc = e.Graphics;
			Pen BluePen = new Pen(Color.Blue,1);
			Pen BlackPen = new Pen(Color.Black, 1);
			Pen BlackPen2 = new Pen(Color.WhiteSmoke, 2);
			Pen RedPen = new Pen(Color.Tomato,1);
			Pen pen1 = new Pen(Color.SeaGreen,1);
			Pen pen2 = new Pen(Color.Blue,1);
			Pen pen3 = new Pen(Color.Red,1);

			SolidBrush b1 = new SolidBrush(Color.SeaGreen);
			SolidBrush b2 = new SolidBrush(Color.Blue);
			SolidBrush b3 = new SolidBrush(Color.Red);

			SolidBrush b = new SolidBrush(Color.SaddleBrown);
			SolidBrush btitle = new SolidBrush(Color.Sienna);
			SolidBrush bl = new SolidBrush(Color.Maroon);

			dc.DrawRectangle(BlackPen2,100,150,455,300);

			
			dc.FillRectangle(b1,100,110,10,10);
			dc.FillRectangle(b2,200,110,10,10);
			dc.FillRectangle(b3,300,110,10,10);
			
			dc.DrawString("体力",new Font("宋体",10), b1 ,new RectangleF(115,110,40,40),StringFormat.GenericDefault);
			dc.DrawString("情绪",new Font("宋体",10), b2 ,new RectangleF(215,110,40,40),StringFormat.GenericDefault);
			dc.DrawString("智力",new Font("宋体",10), b3 ,new RectangleF(315,110,40,40),StringFormat.GenericDefault);
			
			dc.DrawString(str1,new Font("宋体",10), b1 ,new RectangleF(115,130,50,40),StringFormat.GenericDefault);
			dc.DrawString(str2,new Font("宋体",10), b2 ,new RectangleF(215,130,50,40),StringFormat.GenericDefault);
			dc.DrawString(str3,new Font("宋体",10), b3 ,new RectangleF(315,130,50,40),StringFormat.GenericDefault);
			

			dc.DrawString(year.ToString()+"年"+month.ToString()+"月",new Font("宋体",13), btitle ,new RectangleF(120,160,100,100),StringFormat.GenericDefault);
			if(month<12)
			dc.DrawString((month+1).ToString()+"月",new Font("宋体",13), btitle ,new RectangleF(420,160,100,100),StringFormat.GenericDefault);
			else
			dc.DrawString((1).ToString()+"月",new Font("宋体",13), btitle ,new RectangleF(420,160,100,100),StringFormat.GenericDefault);
			
	


			dc.DrawLine(BlackPen,new Point(100,300),new Point(1000,300));
			dc.DrawLine(BlackPen,new Point(100+10*(day-1),150),new Point(100+10*(day-1),450));
			int len=100;
			int high=300;
			int days=System.DateTime.DaysInMonth(year,month);

			for(int i=0; i<days;i++)
			{				
				dc.DrawLine(BlackPen,new Point(len,high+1),new Point(len,high-1));
				if(i%2==0)
				{
					dc.DrawString((i+1).ToString(),new Font("宋体",8),b,new RectangleF(len-5,high+2,20,20),StringFormat.GenericDefault);
				}
				len+=10;
			}
			for(int i=0; i<days;i++)
			{				
				dc.DrawLine(RedPen,new Point(len,high+1),new Point(len,high-1));
				if(i%2==0)
				{
					dc.DrawString((i+1).ToString(),new Font("宋体",8),b1,new RectangleF(len-5,high+2,20,20),StringFormat.GenericDefault);
				}
				len+=10;
			}

			int h=320;
			for(int i=20; i<=100;i+=20)
			{				
				dc.DrawLine(RedPen,new Point(100,h),new Point(100,h));
				dc.DrawString("-"+i.ToString()+"%",new Font("宋体",7),bl,new RectangleF(105,h,40,40),StringFormat.GenericDefault);
				h+=22;
			}

			
			int h1=280;
			for(int i=20; i<=100;i+=20)
			{				
				dc.DrawLine(RedPen,new Point(100,h1),new Point(100,h1));
				dc.DrawString(i.ToString()+"%",new Font("宋体",7),bl,new RectangleF(105,h1,40,40),StringFormat.GenericDefault);
				h1-=23;
			}
			

			

			
			for(int i=0;i<500;i++)
			{
				int xx=100+i;
				int yy=300+(int)( Math.Sin((((double)((0.1*i+y)%23)/23)*2+0.5)*3.1415926)*110);
				dc.DrawEllipse(pen1,xx,yy,2,2);
			}
			for(int i=0;i<500;i++)
			{
				int xx=100+i;
				int yy=300+(int)( Math.Sin((((double)((0.1*i+y)%28)/28)*2+0.5)*3.1415926)*110);
				dc.DrawEllipse(pen2,xx,yy,2,2);
			}
			for(int i=0;i<500;i++)
			{
				int xx=100+i;
				int yy=300+(int)( Math.Sin((((double)((0.1*i+y)%33)/33)*2+0.5)*3.1415926)*110);
				dc.DrawEllipse(pen3,xx,yy,2,2);
			}

			



			base.OnPaint (e);
		}

		
		private void DrawSin(Graphics dc ,PointF startP, float distance, float hight,Pen MyPen)
		{

			float level = startP.Y;
			PointF[] points;
			points=new PointF[16];
			points[0]=startP;
			points[1]=new PointF(distance/2+startP.X,level-hight);
			points[2]=new PointF(distance/2+startP.X,level+hight);


			
			for(int i=3;i<16;i++)
			{			
				float x,y;
				x=points[i-3].X;
				y=points[i-3].Y;
				points[i]=new PointF(x+distance,y);
			}
			dc.DrawBeziers(MyPen,points);
		}
		
		private int GetDays(System.DateTime dt1,System.DateTime dt2)
		{
			System.TimeSpan dt3 = dt1-dt2;

			return dt3.Days;
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmMain));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnSel = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.btnFind = new System.Windows.Forms.Button();
			this.txtName = new System.Windows.Forms.TextBox();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.mnuUser = new System.Windows.Forms.MenuItem();
			this.mnuCustomer = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.mnuExit = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnLoad = new System.Windows.Forms.Button();
			this.udMinPhy = new System.Windows.Forms.NumericUpDown();
			this.udMaxPhy = new System.Windows.Forms.NumericUpDown();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.udMinEmo = new System.Windows.Forms.NumericUpDown();
			this.udMaxEmo = new System.Windows.Forms.NumericUpDown();
			this.udMinWis = new System.Windows.Forms.NumericUpDown();
			this.udMaxWis = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.udMinPhy)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.udMaxPhy)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.udMinEmo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.udMaxEmo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.udMinWis)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.udMaxWis)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnSel);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.dateTimePicker1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.btnFind);
			this.groupBox1.Controls.Add(this.txtName);
			this.groupBox1.Location = new System.Drawing.Point(12, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(640, 56);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// btnSel
			// 
			this.btnSel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSel.Font = new System.Drawing.Font("宋体", 5F);
			this.btnSel.Location = new System.Drawing.Point(208, 24);
			this.btnSel.Name = "btnSel";
			this.btnSel.Size = new System.Drawing.Size(24, 24);
			this.btnSel.TabIndex = 5;
			this.btnSel.Text = "...";
			this.btnSel.Click += new System.EventHandler(this.btnSel_Click);
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(360, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 21);
			this.label2.TabIndex = 4;
			this.label2.Text = "查看日期";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CustomFormat = "yyyy年MM月dd日";
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker1.Location = new System.Drawing.Point(440, 24);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.ShowUpDown = true;
			this.dateTimePicker1.Size = new System.Drawing.Size(136, 26);
			this.dateTimePicker1.TabIndex = 3;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(20, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 21);
			this.label1.TabIndex = 2;
			this.label1.Text = "姓名";
			// 
			// btnFind
			// 
			this.btnFind.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFind.BackgroundImage")));
			this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnFind.ForeColor = System.Drawing.Color.Red;
			this.btnFind.Location = new System.Drawing.Point(236, 24);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(72, 24);
			this.btnFind.TabIndex = 1;
			this.btnFind.Text = "查找";
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(72, 24);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(136, 26);
			this.txtName.TabIndex = 0;
			this.txtName.Text = "";
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuItem6});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.mnuUser,
																					  this.mnuCustomer,
																					  this.menuItem4,
																					  this.mnuExit});
			this.menuItem1.Text = "系统(&S)";
			// 
			// mnuUser
			// 
			this.mnuUser.Index = 0;
			this.mnuUser.Text = "用户管理(&U)";
			this.mnuUser.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// mnuCustomer
			// 
			this.mnuCustomer.Index = 1;
			this.mnuCustomer.Text = "观察对象管理(&O)";
			this.mnuCustomer.Click += new System.EventHandler(this.menuItem3_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 2;
			this.menuItem4.Text = "-";
			// 
			// mnuExit
			// 
			this.mnuExit.Index = 3;
			this.mnuExit.Text = "退出系统(&E)";
			this.mnuExit.Click += new System.EventHandler(this.menuItem5_Click);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 1;
			this.menuItem6.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem7});
			this.menuItem6.Text = "帮助(&H)";
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 0;
			this.menuItem7.Text = "关于(&A)...";
			this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnLoad);
			this.panel1.Controls.Add(this.udMinPhy);
			this.panel1.Controls.Add(this.udMaxPhy);
			this.panel1.Controls.Add(this.listBox1);
			this.panel1.Controls.Add(this.udMinEmo);
			this.panel1.Controls.Add(this.udMaxEmo);
			this.panel1.Controls.Add(this.udMinWis);
			this.panel1.Controls.Add(this.udMaxWis);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Location = new System.Drawing.Point(556, 76);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(152, 404);
			this.panel1.TabIndex = 1;
			// 
			// btnLoad
			// 
			this.btnLoad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoad.BackgroundImage")));
			this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnLoad.ForeColor = System.Drawing.Color.Red;
			this.btnLoad.Location = new System.Drawing.Point(68, 136);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(64, 24);
			this.btnLoad.TabIndex = 0;
			this.btnLoad.Text = "找";
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// udMinPhy
			// 
			this.udMinPhy.ForeColor = System.Drawing.Color.Green;
			this.udMinPhy.Location = new System.Drawing.Point(24, 40);
			this.udMinPhy.Minimum = new System.Decimal(new int[] {
																	 100,
																	 0,
																	 0,
																	 -2147483648});
			this.udMinPhy.Name = "udMinPhy";
			this.udMinPhy.Size = new System.Drawing.Size(52, 26);
			this.udMinPhy.TabIndex = 3;
			this.udMinPhy.Value = new System.Decimal(new int[] {
																   100,
																   0,
																   0,
																   -2147483648});
			// 
			// udMaxPhy
			// 
			this.udMaxPhy.ForeColor = System.Drawing.Color.Green;
			this.udMaxPhy.Location = new System.Drawing.Point(92, 40);
			this.udMaxPhy.Minimum = new System.Decimal(new int[] {
																	 100,
																	 0,
																	 0,
																	 -2147483648});
			this.udMaxPhy.Name = "udMaxPhy";
			this.udMaxPhy.Size = new System.Drawing.Size(44, 26);
			this.udMaxPhy.TabIndex = 2;
			this.udMaxPhy.Value = new System.Decimal(new int[] {
																   100,
																   0,
																   0,
																   0});
			// 
			// listBox1
			// 
			this.listBox1.ItemHeight = 16;
			this.listBox1.Location = new System.Drawing.Point(8, 168);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(124, 212);
			this.listBox1.TabIndex = 2;
			this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
			// 
			// udMinEmo
			// 
			this.udMinEmo.ForeColor = System.Drawing.Color.Blue;
			this.udMinEmo.Location = new System.Drawing.Point(24, 72);
			this.udMinEmo.Minimum = new System.Decimal(new int[] {
																	 100,
																	 0,
																	 0,
																	 -2147483648});
			this.udMinEmo.Name = "udMinEmo";
			this.udMinEmo.Size = new System.Drawing.Size(52, 26);
			this.udMinEmo.TabIndex = 3;
			this.udMinEmo.Value = new System.Decimal(new int[] {
																   100,
																   0,
																   0,
																   -2147483648});
			// 
			// udMaxEmo
			// 
			this.udMaxEmo.ForeColor = System.Drawing.Color.Blue;
			this.udMaxEmo.Location = new System.Drawing.Point(92, 72);
			this.udMaxEmo.Minimum = new System.Decimal(new int[] {
																	 100,
																	 0,
																	 0,
																	 -2147483648});
			this.udMaxEmo.Name = "udMaxEmo";
			this.udMaxEmo.Size = new System.Drawing.Size(44, 26);
			this.udMaxEmo.TabIndex = 3;
			this.udMaxEmo.Value = new System.Decimal(new int[] {
																   100,
																   0,
																   0,
																   0});
			// 
			// udMinWis
			// 
			this.udMinWis.ForeColor = System.Drawing.Color.Red;
			this.udMinWis.Location = new System.Drawing.Point(24, 104);
			this.udMinWis.Minimum = new System.Decimal(new int[] {
																	 100,
																	 0,
																	 0,
																	 -2147483648});
			this.udMinWis.Name = "udMinWis";
			this.udMinWis.Size = new System.Drawing.Size(52, 26);
			this.udMinWis.TabIndex = 3;
			this.udMinWis.Value = new System.Decimal(new int[] {
																   100,
																   0,
																   0,
																   -2147483648});
			// 
			// udMaxWis
			// 
			this.udMaxWis.ForeColor = System.Drawing.Color.Red;
			this.udMaxWis.Location = new System.Drawing.Point(92, 104);
			this.udMaxWis.Minimum = new System.Decimal(new int[] {
																	 100,
																	 0,
																	 0,
																	 -2147483648});
			this.udMaxWis.Name = "udMaxWis";
			this.udMaxWis.Size = new System.Drawing.Size(44, 26);
			this.udMaxWis.TabIndex = 3;
			this.udMaxWis.Value = new System.Decimal(new int[] {
																   100,
																   0,
																   0,
																   0});
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.Color.Green;
			this.label3.Location = new System.Drawing.Point(72, 44);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(20, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "至";
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.Color.Blue;
			this.label4.Location = new System.Drawing.Point(72, 76);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(20, 16);
			this.label4.TabIndex = 2;
			this.label4.Text = "至";
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.Color.Red;
			this.label5.Location = new System.Drawing.Point(72, 108);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(20, 16);
			this.label5.TabIndex = 2;
			this.label5.Text = "至";
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.Color.Green;
			this.label6.Location = new System.Drawing.Point(4, 44);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(20, 16);
			this.label6.TabIndex = 2;
			this.label6.Text = "体";
			// 
			// label7
			// 
			this.label7.ForeColor = System.Drawing.Color.Blue;
			this.label7.Location = new System.Drawing.Point(4, 72);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(20, 16);
			this.label7.TabIndex = 2;
			this.label7.Text = "情";
			// 
			// label8
			// 
			this.label8.ForeColor = System.Drawing.Color.Red;
			this.label8.Location = new System.Drawing.Point(4, 104);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(20, 16);
			this.label8.TabIndex = 2;
			this.label8.Text = "智";
			// 
			// panel2
			// 
			this.panel2.Location = new System.Drawing.Point(0, 84);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(99, 400);
			this.panel2.TabIndex = 1;
			// 
			// frmMain
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
			this.BackColor = System.Drawing.Color.SkyBlue;
			this.ClientSize = new System.Drawing.Size(772, 474);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel2);
			this.Font = new System.Drawing.Font("宋体", 12F);
			this.ForeColor = System.Drawing.Color.OrangeRed;
			this.MaximizeBox = false;
			this.Menu = this.mainMenu1;
			this.MinimizeBox = false;
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "生命节律";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.Closed += new System.EventHandler(this.frmMain_Closed);
			this.groupBox1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.udMinPhy)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.udMaxPhy)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.udMinEmo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.udMaxEmo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.udMinWis)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.udMaxWis)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmMain_Closed(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void btnFind_Click(object sender, System.EventArgs e)
		{
			string msg;
			if (this.txtName.Text.Trim() == "")
			{
				ClassComm.InfoMsg("请输入观察对象！");
				return;
			}

			birthData.Birthday = System.Convert.ToDateTime(FindBirth(this.txtName.Text.Trim(), out msg));
			this.Refresh();
		}

		private void frmMain_Load(object sender, System.EventArgs e)
		{
			this.Refresh();
		}

		private string FindBirth(string custName, out string msg)
		{
			msg = "";
			string bir;
			bir = ClassComm.getIDName("CustomerList",
				"CustomerName", custName, "CustomerBirth");
			if (bir == null)
			{
				ClassComm.InfoMsg("查无此人，请重新选择！");
			}
			return bir;
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			DataFormUser frm = new DataFormUser();
			frm.ShowDialog();		
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			DataFormCust frm = new DataFormCust();
			frm.ShowDialog();		
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void dateTimePicker1_ValueChanged(object sender, System.EventArgs e)
		{
			this.selectData.SelectDate = this.dateTimePicker1.Value;
			this.Refresh();
		}

		private void menuItem7_Click(object sender, System.EventArgs e)
		{
			frmAbout frm = new frmAbout();
			frm.ShowDialog();
		}

		private void groupBox1_Enter(object sender, System.EventArgs e)
		{
		
		}

		private void btnSel_Click(object sender, System.EventArgs e)
		{
			frmSelCust frm = new frmSelCust();
			if ( frm.ShowDialog()==DialogResult.OK )
			{
				if (frm.SelectedName.Trim() != "")
				{
					this.txtName.Text = frm.SelectedName;
					btnFind.PerformClick();
				}
			}
		}

		private void btnLoad_Click(object sender, System.EventArgs e)
		{
			this.listBox1.Items.Clear();
			ArrayList a = new ArrayList();
			fittedCustomer.MinPhysicalRate = (double)(this.udMinPhy.Value)/100;
			fittedCustomer.MaxPhysicalRate = (double)(this.udMaxPhy.Value)/100;
			fittedCustomer.MinEmotionRate = (double)(this.udMinEmo.Value)/100;
			fittedCustomer.MaxEmotionRate = (double)(this.udMaxEmo.Value)/100;
			fittedCustomer.MinWisdomRate = (double)(this.udMinWis.Value)/100;
			fittedCustomer.MaxWisdomRate = (double)(this.udMaxWis.Value)/100;

			fittedCustomer.SetOK();
			a = fittedCustomer.FitCustomer;
			foreach(string b in a)
			{
				this.listBox1.Items.Add(b);
			}
			a.Clear();

		}

		private void listBox1_DoubleClick(object sender, System.EventArgs e)
		{
			string si = "";
			try
			{
				si = this.listBox1.SelectedItem.ToString();
			}
			catch
			{
			}
			if ( si.Trim() != "" )
			{
				this.txtName.Text =  si;
				btnFind.PerformClick();
			}
		}

	}
}
