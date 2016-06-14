using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Homon
{
	/// <summary>
	/// frmCust ��ժҪ˵����
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
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmCust()
		{
			//
			// Windows ���������֧���������
			//
			InitializeComponent();

			//
			// TODO: �� InitializeComponent ���ú�����κι��캯������
			//
		}

		/// <summary>
		/// ������������ʹ�õ���Դ��
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

		#region Windows ������������ɵĴ���
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
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
			this.label1.Text = "����";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "����";
			// 
			// btnCancle
			// 
			this.btnCancle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancle.BackgroundImage")));
			this.btnCancle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCancle.Location = new System.Drawing.Point(144, 168);
			this.btnCancle.Name = "btnCancle";
			this.btnCancle.Size = new System.Drawing.Size(90, 28);
			this.btnCancle.TabIndex = 8;
			this.btnCancle.Text = "ȡ��";
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
			this.btnOk.Text = "ȷ��";
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
			this.Font = new System.Drawing.Font("����", 12F);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmCust";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "�۲����";
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

			if (!ClassComm.checkPriKey("CustomerList", "CustomerName", custname, "�۲������"))
			{
				ClassComm.InfoMsg("�������Ѿ����ڣ�����ʹ�ã�\n"
					+ custname + "001 �� \n"
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
				msg = "�����۲����ɹ���";
				return true;
			}
			catch
			{
				msg = "�����۲����ʧ�ܣ�";
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
