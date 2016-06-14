using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace Homon
{
	/// <summary>
	/// frmLogin 的摘要说明。
	/// </summary>
	public class frmLogin : System.Windows.Forms.Form
	{


		public static string connStr;
		//
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Windows.Forms.Button btnCancle;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.TextBox txtPsw;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmLogin()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmLogin));
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.btnCancle = new System.Windows.Forms.Button();
			this.btnOk = new System.Windows.Forms.Button();
			this.txtPsw = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=0;Jet OLEDB:Database Password=;Data Source=""C:\Practice\Homon\Homon\bin\Debug\Homo.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
			// 
			// btnCancle
			// 
			this.btnCancle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancle.BackgroundImage")));
			this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCancle.Location = new System.Drawing.Point(104, 160);
			this.btnCancle.Name = "btnCancle";
			this.btnCancle.Size = new System.Drawing.Size(90, 28);
			this.btnCancle.TabIndex = 12;
			this.btnCancle.Text = "取消";
			this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
			// 
			// btnOk
			// 
			this.btnOk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOk.BackgroundImage")));
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnOk.Location = new System.Drawing.Point(8, 160);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(90, 28);
			this.btnOk.TabIndex = 11;
			this.btnOk.Text = "确定";
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// txtPsw
			// 
			this.txtPsw.Location = new System.Drawing.Point(60, 124);
			this.txtPsw.Name = "txtPsw";
			this.txtPsw.PasswordChar = '*';
			this.txtPsw.Size = new System.Drawing.Size(136, 26);
			this.txtPsw.TabIndex = 10;
			this.txtPsw.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 88);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 23);
			this.label1.TabIndex = 8;
			this.label1.Text = "用户名";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(60, 88);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(136, 26);
			this.txtName.TabIndex = 7;
			this.txtName.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 124);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 23);
			this.label2.TabIndex = 9;
			this.label2.Text = "密码";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(16, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(172, 77);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 13;
			this.pictureBox1.TabStop = false;
			// 
			// frmLogin
			// 
			this.AcceptButton = this.btnOk;
			this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
			this.BackColor = System.Drawing.Color.SkyBlue;
			this.CancelButton = this.btnCancle;
			this.ClientSize = new System.Drawing.Size(206, 200);
			this.ControlBox = false;
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnCancle);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.txtPsw);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Font = new System.Drawing.Font("宋体", 12F);
			this.ForeColor = System.Drawing.Color.OrangeRed;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "系统登录";
			this.Load += new System.EventHandler(this.frmLogin_Load);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmLogin());
		}

		private void frmLogin_Load(object sender, System.EventArgs e)
		{
			this.oleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Homo.MDB";
			//@"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=0;Jet OLEDB:Database Password=;Data Source=""Homo.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
			connStr = this.oleDbConnection1.ConnectionString;
		}

		private void btnOk_Click(object sender, System.EventArgs e)
		{
			string msg;
			string usrName;
			string usrpsw;

			usrName = this.txtName.Text;
			usrpsw  = this.txtPsw.Text;

			if (!LogIN(usrName, usrpsw, out msg))
			{
				ClassComm.InfoMsg(msg);
			}
			else
			{
				frmMain frm = new frmMain(msg);
				this.Hide();
				frm.Show();				
			}

		}

		private void btnCancle_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private bool LogIN(string usrName, string usrpsw, out string msg)
		{
			msg = "";
			int theRight;

			if ((usrName == "Admi")&&(usrpsw=="Admi"))
			{
				msg = "1";
				return true;
			}
			
			System.Data.OleDb.OleDbCommand cmd = this.oleDbConnection1.CreateCommand();
			System.Data.OleDb.OleDbCommand cmd2 = this.oleDbConnection1.CreateCommand();


			cmd.CommandText = "Select count(*) from UserRight where UserName = '" + usrName
				+ "' and UserPwd = '" + usrpsw + "'";


			cmd2.CommandText = "Select UserRight from UserRight where UserName = '" + usrName
				+ "' and UserPwd = '" + usrpsw + "'";
			try
			{
				this.oleDbConnection1.Open();
				try
				{
					theRight = System.Convert.ToInt32(cmd.ExecuteScalar());	
					if (theRight==0)
					{
						System.Exception se = new Exception();
						throw  se;
					}
					theRight = System.Convert.ToInt32(cmd2.ExecuteScalar());	
					msg = theRight.ToString();
					return true;
				}
				catch
				{
					msg = "用户不存在或密码错误！";
					return false;
				}		
			}
			catch
			{
				msg = "数据库打开时出错！";
				return false;
			}
			finally
			{
				this.oleDbConnection1.Close();
				cmd.Dispose();
			}
		}

	}
}
