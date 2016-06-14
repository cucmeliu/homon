using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Homon
{
	/// <summary>
	/// frmUser ��ժҪ˵����
	/// </summary>
	public class frmUser : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.ComboBox cbbRight;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPsw;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancle;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmUser()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmUser));
			this.txtName = new System.Windows.Forms.TextBox();
			this.cbbRight = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPsw = new System.Windows.Forms.TextBox();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancle = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(104, 48);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(152, 26);
			this.txtName.TabIndex = 0;
			this.txtName.Text = "";
			// 
			// cbbRight
			// 
			this.cbbRight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbRight.Items.AddRange(new object[] {
														  "��ͨȨ��",
														  "����Ա"});
			this.cbbRight.Location = new System.Drawing.Point(104, 132);
			this.cbbRight.Name = "cbbRight";
			this.cbbRight.Size = new System.Drawing.Size(152, 24);
			this.cbbRight.TabIndex = 2;
			this.cbbRight.SelectedIndexChanged += new System.EventHandler(this.cbbRight_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(40, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "�û���";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(40, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "����";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(40, 128);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Ȩ��";
			// 
			// txtPsw
			// 
			this.txtPsw.Location = new System.Drawing.Point(104, 88);
			this.txtPsw.Name = "txtPsw";
			this.txtPsw.PasswordChar = '*';
			this.txtPsw.Size = new System.Drawing.Size(152, 26);
			this.txtPsw.TabIndex = 4;
			this.txtPsw.Text = "";
			// 
			// btnOk
			// 
			this.btnOk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOk.BackgroundImage")));
			this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnOk.Location = new System.Drawing.Point(53, 180);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(90, 28);
			this.btnOk.TabIndex = 5;
			this.btnOk.Text = "ȷ��";
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnCancle
			// 
			this.btnCancle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancle.BackgroundImage")));
			this.btnCancle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCancle.Location = new System.Drawing.Point(149, 180);
			this.btnCancle.Name = "btnCancle";
			this.btnCancle.Size = new System.Drawing.Size(90, 28);
			this.btnCancle.TabIndex = 6;
			this.btnCancle.Text = "ȡ��";
			this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
			// 
			// frmUser
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
			this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.ClientSize = new System.Drawing.Size(292, 226);
			this.Controls.Add(this.btnCancle);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.txtPsw);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cbbRight);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Font = new System.Drawing.Font("����", 12F);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmUser";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "�û�Ȩ���趨";
			this.Load += new System.EventHandler(this.frmUser_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmUser_Load(object sender, System.EventArgs e)
		{
			this.cbbRight.SelectedIndex = 0;
		}

		private void btnOk_Click(object sender, System.EventArgs e)
		{
			string usrname = this.txtName.Text.Trim();
			string usrpsw  = this.txtPsw.Text.Trim();
			string usrRight= this.cbbRight.SelectedIndex.ToString();
			string msg;
			bool addRst;

			if (!ClassComm.checkPriKey("UserRight", "UserName", usrname, "�û���"))
			{
				ClassComm.InfoMsg("�û����Ѿ����ڣ�");
				return;
			}
			addRst = addUser(usrname, usrpsw, usrRight, out msg);
			ClassComm.InfoMsg(msg);	
			if (addRst)
			{
				this.Close();
			}
				
		}

		private void btnCancle_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void cbbRight_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}

		private bool addUser(string usrName, string usrPsw, string usrRight, out string msg)
		{
			msg = "";
			OleDbConnection conn = new System.Data.OleDb.OleDbConnection(ClassComm.ConnectionStr);
			OleDbCommand cmd = conn.CreateCommand();
			cmd.CommandText = "Insert into UserRight Values('"
				+ usrName + "','"
				+ usrPsw  + "','"
				+ usrRight.ToString()
				+ "')";
			try
			{
				conn.Open();
				cmd.ExecuteNonQuery();
				msg = "�����û��ɹ���";
				return true;
			}
			catch
			{
				msg = "�����û�ʧ�ܣ�";
				return false;
			}
			finally
			{
				conn.Close();
				cmd.Dispose();
			}
		}
	}
}
