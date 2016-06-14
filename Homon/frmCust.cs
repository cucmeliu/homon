using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Homon
{
	/// <summary>
	/// frmCust 的摘要说明。
	/// </summary>
	public class frmCust : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnCancle;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.DateTimePicker dtpBirthday;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmCust()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmCust));
			this.txtName = new System.Windows.Forms.TextBox();
			this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnCancle = new System.Windows.Forms.Button();
			this.btnOk = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(84, 56);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(152, 26);
			this.txtName.TabIndex = 0;
			this.txtName.Text = "";
			// 
			// dtpBirthday
			// 
			this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpBirthday.Location = new System.Drawing.Point(84, 100);
			this.dtpBirthday.Name = "dtpBirthday";
			this.dtpBirthday.Size = new System.Drawing.Size(152, 26);
			this.dtpBirthday.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "姓名";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "生日";
			// 
			// btnCancle
			// 
			this.btnCancle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancle.BackgroundImage")));
			this.btnCancle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCancle.Location = new System.Drawing.Point(144, 168);
			this.btnCancle.Name = "btnCancle";
			this.btnCancle.Size = new System.Drawing.Size(90, 28);
			this.btnCancle.TabIndex = 8;
			this.btnCancle.Text = "取消";
			this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
			// 
			// btnOk
			// 
			this.btnOk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOk.BackgroundImage")));
			this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnOk.Location = new System.Drawing.Point(48, 168);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(90, 28);
			this.btnOk.TabIndex = 7;
			this.btnOk.Text = "确定";
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// frmCust
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
			this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.ClientSize = new System.Drawing.Size(292, 214);
			this.Controls.Add(this.btnCancle);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dtpBirthday);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label2);
			this.Font = new System.Drawing.Font("宋体", 12F);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmCust";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "观察对象";
			this.Load += new System.EventHandler(this.frmCust_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmCust_Load(object sender, System.EventArgs e)
		{
		
		}

		private void btnOk_Click(object sender, System.EventArgs e)
		{
			string custname = this.txtName.Text.Trim();
			string custBirth = this.dtpBirthday.Value.ToShortDateString();
			string msg;

			bool addRst;

			if (!ClassComm.checkPriKey("CustomerList", "CustomerName", custname, "观察对象名"))
			{
				ClassComm.InfoMsg("此姓名已经存在！建议使用：\n"
					+ custname + "001 或 \n"
					+ custname + "2000");
				return;
			}
			addRst = addCust(custname, custBirth, out msg);
			ClassComm.InfoMsg(msg);	
			if (addRst)
			{
				this.Close();
			}
		}

		private bool addCust(string custName, string custBirth, out string msg)
		{
			msg = "";
			OleDbConnection conn = new System.Data.OleDb.OleDbConnection(ClassComm.ConnectionStr);
			OleDbCommand cmd = conn.CreateCommand();
			cmd.CommandText = "Insert into CustomerList Values('"
				+ custName + "','"
				+ custBirth
				+ "')";
			try
			{
				conn.Open();
				cmd.ExecuteNonQuery();
				msg = "新增观察对象成功！";
				return true;
			}
			catch
			{
				msg = "新增观察对象失败！";
				return false;
			}
			finally
			{
				conn.Close();
				cmd.Dispose();
			}
		}

		private void btnCancle_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void addCust(string userName, System.DateTime Birthdate)
		{
		}
	}
}
