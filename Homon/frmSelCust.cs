using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Homon
{
	/// <summary>
	/// frmSelCust 的摘要说明。
	/// </summary>
	public class frmSelCust : System.Windows.Forms.Form
	{
		private string selectedName = null;

		private System.Windows.Forms.Button btnConfirm;
		private System.Windows.Forms.Button btnCancle;
		private System.Windows.Forms.ListBox listBoxCustomer;
		
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public string SelectedName
		{
			get { return selectedName;}
		}

		public frmSelCust()
		{
			InitializeComponent();
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmSelCust));
			this.listBoxCustomer = new System.Windows.Forms.ListBox();
			this.btnConfirm = new System.Windows.Forms.Button();
			this.btnCancle = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listBoxCustomer
			// 
			this.listBoxCustomer.Dock = System.Windows.Forms.DockStyle.Top;
			this.listBoxCustomer.ItemHeight = 16;
			this.listBoxCustomer.Items.AddRange(new object[] {
																 "我我我"});
			this.listBoxCustomer.Location = new System.Drawing.Point(0, 0);
			this.listBoxCustomer.Name = "listBoxCustomer";
			this.listBoxCustomer.Size = new System.Drawing.Size(174, 212);
			this.listBoxCustomer.Sorted = true;
			this.listBoxCustomer.TabIndex = 0;
			this.listBoxCustomer.DoubleClick += new System.EventHandler(this.listBoxCustomer_DoubleClick);
			// 
			// btnConfirm
			// 
			this.btnConfirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirm.BackgroundImage")));
			this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnConfirm.Location = new System.Drawing.Point(44, 224);
			this.btnConfirm.Name = "btnConfirm";
			this.btnConfirm.Size = new System.Drawing.Size(90, 28);
			this.btnConfirm.TabIndex = 1;
			this.btnConfirm.Text = "选定";
			this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
			// 
			// btnCancle
			// 
			this.btnCancle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancle.BackgroundImage")));
			this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCancle.Location = new System.Drawing.Point(44, 256);
			this.btnCancle.Name = "btnCancle";
			this.btnCancle.Size = new System.Drawing.Size(90, 28);
			this.btnCancle.TabIndex = 1;
			this.btnCancle.Text = "取消";
			this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
			// 
			// frmSelCust
			// 
			this.AcceptButton = this.btnConfirm;
			this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
			this.BackColor = System.Drawing.Color.SkyBlue;
			this.CancelButton = this.btnCancle;
			this.ClientSize = new System.Drawing.Size(174, 292);
			this.Controls.Add(this.btnConfirm);
			this.Controls.Add(this.listBoxCustomer);
			this.Controls.Add(this.btnCancle);
			this.Font = new System.Drawing.Font("宋体", 12F);
			this.ForeColor = System.Drawing.Color.OrangeRed;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSelCust";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "请选择";
			this.Load += new System.EventHandler(this.frmSelCust_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnConfirm_Click(object sender, System.EventArgs e)
		{
			this.selectedName = this.listBoxCustomer.SelectedItem.ToString();
			this.DialogResult = DialogResult.OK; 
			this.Close();
		}

		private void btnCancle_Click(object sender, System.EventArgs e)
		{
			this.selectedName = null;
			this.Close();		
		}

		private void frmSelCust_Load(object sender, System.EventArgs e)
		{
			this.listBoxCustomer.Items.Clear();
			ArrayList bb = loadCustomer();
			foreach (string aa in bb)
			{
				if (aa != null)
				{				
					this.listBoxCustomer.Items.Add(aa);
				}
			}
			this.listBoxCustomer.SelectedIndex = 0;
		
		}

		private ArrayList loadCustomer()
		{
			ArrayList aaa = new ArrayList();

			System.Data.OleDb.OleDbConnection Conn = new System.Data.OleDb.OleDbConnection(ClassComm.ConnectionStr);
			System.Data.OleDb.OleDbCommand sc = Conn.CreateCommand();
			sc.CommandText = "Select CustomerName from CustomerList ";
			try
			{
				Conn.Open();
				OleDbDataReader myReader = sc.ExecuteReader();
				if (myReader.HasRows)
				{
					while (myReader.Read())
					{
						aaa.Add(myReader.GetString(0));
					}					
				}
			}
			catch
			{
				aaa.Add(null);
			}
			return aaa;
			
		}

		private void listBoxCustomer_DoubleClick(object sender, System.EventArgs e)
		{
			this.btnConfirm.PerformClick();		
		}
	}
}
