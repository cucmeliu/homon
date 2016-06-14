using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Homon
{
	/// <summary>
	/// DataFormUser ��ժҪ˵����
	/// </summary>
	public class DataFormUser : System.Windows.Forms.Form
	{
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private Homon.dsUser objdsUser;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Label lblUserName;
		private System.Windows.Forms.Label lblUserPwd;
		private System.Windows.Forms.TextBox editUserName;
		private System.Windows.Forms.TextBox editUserPwd;
		private System.Windows.Forms.Label lblUserRight;
		private System.Windows.Forms.TextBox editUserRight;
		private System.Windows.Forms.Button btnNavFirst;
		private System.Windows.Forms.Button btnNavPrev;
		private System.Windows.Forms.Label lblNavLocation;
		private System.Windows.Forms.Button btnNavNext;
		private System.Windows.Forms.Button btnLast;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.ComboBox cbbRight;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;

		public DataFormUser()
		{
			//
			// Windows ���������֧���������
			//
			InitializeComponent();
			this.oleDbConnection1.ConnectionString = ClassComm.ConnectionStr;

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(DataFormUser));
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.objdsUser = new Homon.dsUser();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.lblUserName = new System.Windows.Forms.Label();
			this.lblUserPwd = new System.Windows.Forms.Label();
			this.editUserName = new System.Windows.Forms.TextBox();
			this.editUserPwd = new System.Windows.Forms.TextBox();
			this.lblUserRight = new System.Windows.Forms.Label();
			this.editUserRight = new System.Windows.Forms.TextBox();
			this.btnNavFirst = new System.Windows.Forms.Button();
			this.btnNavPrev = new System.Windows.Forms.Button();
			this.lblNavLocation = new System.Windows.Forms.Label();
			this.btnNavNext = new System.Windows.Forms.Button();
			this.btnLast = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.cbbRight = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.objdsUser)).BeginInit();
			this.SuspendLayout();
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT UserName, UserPwd, UserRight FROM UserRight";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=0;Jet OLEDB:Database Password=;Data Source=""C:\Practice\Homon\Homon\bin\Debug\Homo.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO UserRight(UserName, UserPwd, UserRight) VALUES (?, ?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("UserName", System.Data.OleDb.OleDbType.VarWChar, 50, "UserName"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("UserPwd", System.Data.OleDb.OleDbType.VarWChar, 50, "UserPwd"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("UserRight", System.Data.OleDb.OleDbType.VarWChar, 2, "UserRight"));
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = "UPDATE UserRight SET UserName = ?, UserPwd = ?, UserRight = ? WHERE (UserName = ?" +
				") AND (UserPwd = ? OR ? IS NULL AND UserPwd IS NULL) AND (UserRight = ? OR ? IS " +
				"NULL AND UserRight IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("UserName", System.Data.OleDb.OleDbType.VarWChar, 50, "UserName"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("UserPwd", System.Data.OleDb.OleDbType.VarWChar, 50, "UserPwd"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("UserRight", System.Data.OleDb.OleDbType.VarWChar, 2, "UserRight"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_UserName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UserName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_UserPwd", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UserPwd", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_UserPwd1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UserPwd", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_UserRight", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UserRight", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_UserRight1", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UserRight", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = "DELETE FROM UserRight WHERE (UserName = ?) AND (UserPwd = ? OR ? IS NULL AND User" +
				"Pwd IS NULL) AND (UserRight = ? OR ? IS NULL AND UserRight IS NULL)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_UserName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UserName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_UserPwd", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UserPwd", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_UserPwd1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UserPwd", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_UserRight", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UserRight", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_UserRight1", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UserRight", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
			this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "UserRight", new System.Data.Common.DataColumnMapping[] {
																																																					 new System.Data.Common.DataColumnMapping("UserName", "UserName"),
																																																					 new System.Data.Common.DataColumnMapping("UserPwd", "UserPwd"),
																																																					 new System.Data.Common.DataColumnMapping("UserRight", "UserRight")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// objdsUser
			// 
			this.objdsUser.DataSetName = "dsUser";
			this.objdsUser.Locale = new System.Globalization.CultureInfo("zh-CN");
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnUpdate.Location = new System.Drawing.Point(288, 76);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(90, 28);
			this.btnUpdate.TabIndex = 2;
			this.btnUpdate.Text = "����(&S)";
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// lblUserName
			// 
			this.lblUserName.Location = new System.Drawing.Point(16, 24);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.Size = new System.Drawing.Size(68, 23);
			this.lblUserName.TabIndex = 3;
			this.lblUserName.Text = "�û���";
			// 
			// lblUserPwd
			// 
			this.lblUserPwd.Location = new System.Drawing.Point(16, 60);
			this.lblUserPwd.Name = "lblUserPwd";
			this.lblUserPwd.Size = new System.Drawing.Size(68, 23);
			this.lblUserPwd.TabIndex = 4;
			this.lblUserPwd.Text = "����";
			// 
			// editUserName
			// 
			this.editUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.objdsUser, "UserRight.UserName"));
			this.editUserName.Enabled = false;
			this.editUserName.Location = new System.Drawing.Point(84, 20);
			this.editUserName.Name = "editUserName";
			this.editUserName.Size = new System.Drawing.Size(176, 26);
			this.editUserName.TabIndex = 8;
			this.editUserName.Text = "";
			// 
			// editUserPwd
			// 
			this.editUserPwd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.objdsUser, "UserRight.UserPwd"));
			this.editUserPwd.Location = new System.Drawing.Point(84, 57);
			this.editUserPwd.Name = "editUserPwd";
			this.editUserPwd.PasswordChar = '*';
			this.editUserPwd.Size = new System.Drawing.Size(176, 26);
			this.editUserPwd.TabIndex = 9;
			this.editUserPwd.Text = "";
			// 
			// lblUserRight
			// 
			this.lblUserRight.Location = new System.Drawing.Point(16, 97);
			this.lblUserRight.Name = "lblUserRight";
			this.lblUserRight.Size = new System.Drawing.Size(68, 23);
			this.lblUserRight.TabIndex = 7;
			this.lblUserRight.Text = "Ȩ��";
			// 
			// editUserRight
			// 
			this.editUserRight.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.objdsUser, "UserRight.UserRight"));
			this.editUserRight.Location = new System.Drawing.Point(112, 20);
			this.editUserRight.Name = "editUserRight";
			this.editUserRight.Size = new System.Drawing.Size(96, 26);
			this.editUserRight.TabIndex = 8;
			this.editUserRight.TabStop = false;
			this.editUserRight.Text = "";
			this.editUserRight.TextChanged += new System.EventHandler(this.editUserRight_TextChanged);
			// 
			// btnNavFirst
			// 
			this.btnNavFirst.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNavFirst.BackgroundImage")));
			this.btnNavFirst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnNavFirst.Location = new System.Drawing.Point(20, 140);
			this.btnNavFirst.Name = "btnNavFirst";
			this.btnNavFirst.Size = new System.Drawing.Size(40, 23);
			this.btnNavFirst.TabIndex = 4;
			this.btnNavFirst.Text = "<<";
			this.btnNavFirst.Click += new System.EventHandler(this.btnNavFirst_Click);
			// 
			// btnNavPrev
			// 
			this.btnNavPrev.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNavPrev.BackgroundImage")));
			this.btnNavPrev.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnNavPrev.Location = new System.Drawing.Point(60, 140);
			this.btnNavPrev.Name = "btnNavPrev";
			this.btnNavPrev.Size = new System.Drawing.Size(35, 23);
			this.btnNavPrev.TabIndex = 5;
			this.btnNavPrev.Text = "<";
			this.btnNavPrev.Click += new System.EventHandler(this.btnNavPrev_Click);
			// 
			// lblNavLocation
			// 
			this.lblNavLocation.BackColor = System.Drawing.Color.White;
			this.lblNavLocation.Location = new System.Drawing.Point(96, 140);
			this.lblNavLocation.Name = "lblNavLocation";
			this.lblNavLocation.Size = new System.Drawing.Size(95, 23);
			this.lblNavLocation.TabIndex = 11;
			this.lblNavLocation.Text = "�޼�¼";
			this.lblNavLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnNavNext
			// 
			this.btnNavNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNavNext.BackgroundImage")));
			this.btnNavNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnNavNext.Location = new System.Drawing.Point(188, 140);
			this.btnNavNext.Name = "btnNavNext";
			this.btnNavNext.Size = new System.Drawing.Size(35, 23);
			this.btnNavNext.TabIndex = 6;
			this.btnNavNext.Text = ">";
			this.btnNavNext.Click += new System.EventHandler(this.btnNavNext_Click);
			// 
			// btnLast
			// 
			this.btnLast.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLast.BackgroundImage")));
			this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnLast.Location = new System.Drawing.Point(224, 140);
			this.btnLast.Name = "btnLast";
			this.btnLast.Size = new System.Drawing.Size(40, 23);
			this.btnLast.TabIndex = 7;
			this.btnLast.Text = ">>";
			this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnAdd.Location = new System.Drawing.Point(288, 20);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(90, 28);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "���(&A)";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnDelete.Location = new System.Drawing.Point(288, 48);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(90, 28);
			this.btnDelete.TabIndex = 1;
			this.btnDelete.Text = "ɾ��(&D)";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCancel.Location = new System.Drawing.Point(288, 104);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(90, 28);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "�ر�(&C)";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// cbbRight
			// 
			this.cbbRight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbRight.Items.AddRange(new object[] {
														  "��ͨ�û�",
														  "����Ա"});
			this.cbbRight.Location = new System.Drawing.Point(84, 96);
			this.cbbRight.Name = "cbbRight";
			this.cbbRight.Size = new System.Drawing.Size(180, 24);
			this.cbbRight.TabIndex = 10;
			this.cbbRight.SelectedIndexChanged += new System.EventHandler(this.cbbRight_SelectedIndexChanged);
			// 
			// DataFormUser
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
			this.BackColor = System.Drawing.Color.SkyBlue;
			this.ClientSize = new System.Drawing.Size(388, 172);
			this.Controls.Add(this.cbbRight);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.lblUserName);
			this.Controls.Add(this.lblUserPwd);
			this.Controls.Add(this.editUserName);
			this.Controls.Add(this.editUserPwd);
			this.Controls.Add(this.editUserRight);
			this.Controls.Add(this.lblUserRight);
			this.Controls.Add(this.btnNavFirst);
			this.Controls.Add(this.btnNavPrev);
			this.Controls.Add(this.lblNavLocation);
			this.Controls.Add(this.btnNavNext);
			this.Controls.Add(this.btnLast);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnCancel);
			this.Font = new System.Drawing.Font("����", 12F);
			this.ForeColor = System.Drawing.Color.OrangeRed;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DataFormUser";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "�û�����";
			this.Load += new System.EventHandler(this.DataFormUser_Load);
			((System.ComponentModel.ISupportInitialize)(this.objdsUser)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion



		public void FillDataSet(Homon.dsUser dataSet)
		{
			// ��������ݼ�ǰ�ر�Լ����顣
			// ������������������ݼ������ÿ���
			// ��֮��������
			dataSet.EnforceConstraints = false;
			try 
			{
				// �����ӡ�
				this.oleDbConnection1.Open();
				// ����ͨ�� OleDbDataAdapter1 ������ݼ���
				this.oleDbDataAdapter1.Fill(dataSet);
			}
			catch (System.Exception fillException) 
			{
				// �ڴ˴���Ӵ�������롣
				throw fillException;
			}
			finally 
			{
				// ���´�Լ����顣
				dataSet.EnforceConstraints = true;
				// �����Ƿ��������쳣���ر����ӡ�
				this.oleDbConnection1.Close();
			}

		}

		public void UpdateDataSource(Homon.dsUser ChangedRows)
		{
			try 
			{
				// ���й���ĸ���ʱ��ֻ��Ҫ��������Դ���ɡ�
				if ((ChangedRows != null)) 
				{
					// �����ӡ�
					this.oleDbConnection1.Open();
					// ���Ը�������Դ��
					oleDbDataAdapter1.Update(ChangedRows);
				}
			}
			catch (System.Exception updateException) 
			{
				// �ڴ˴���Ӵ�������롣
				throw updateException;
			}
			finally 
			{
				// �����Ƿ��������쳣���ر����ӡ�
				this.oleDbConnection1.Close();
			}

		}

		public void LoadDataSet()
		{
			// ����һ�������ݼ��Ա���� FillDataSet ���÷��صļ�¼��
			// ʹ����һ����ʱ���ݼ���������Ϊ������е����ݼ�
			// ��Ҫ���°����ݰ󶨡�
			Homon.dsUser objDataSetTemp;
			objDataSetTemp = new Homon.dsUser();
			try 
			{
				// ���������ʱ���ݼ���
				this.FillDataSet(objDataSetTemp);
			}
			catch (System.Exception eFillDataSet) 
			{
				// �ڴ˴���Ӵ�������롣
				throw eFillDataSet;
			}
			try 
			{
				// ������ݼ��еľɼ�¼��
				objdsUser.Clear();
				// ����¼�ϲ��������ݼ��С�
				objdsUser.Merge(objDataSetTemp);
			}
			catch (System.Exception eLoadMerge) 
			{
				// �ڴ˴���Ӵ�������롣
				throw eLoadMerge;
			}

			this.editUserName.Enabled = false;

		}

		public void UpdateDataSet()
		{
			// ����һ�������ݼ�������������ݼ������ĸ��ġ�
			Homon.dsUser objDataSetChanges = new Homon.dsUser();
			// ֹͣ��ǰ���κα༭��
			this.BindingContext[objdsUser,"UserRight"].EndCurrentEdit();
			// ��ȡ�������ݼ������ĸ��ġ�
			objDataSetChanges = ((Homon.dsUser)(objdsUser.GetChanges()));
			// ����Ƿ������κθ��ġ�
			if ((objDataSetChanges != null)) 
			{
				try 
				{
					// ��Ҫ��һЩ���ģ����Գ���ͨ������ update ����
					// �ʹ������ݼ��Լ��κβ�������������Դ��
					this.UpdateDataSource(objDataSetChanges);
					objdsUser.Merge(objDataSetChanges);
					objdsUser.AcceptChanges();
				}
				catch (System.Exception eUpdate) 
				{
					// �ڴ˴���Ӵ�������롣
					throw eUpdate;
				}
				// ��Ӵ����Լ�鷵�ص����ݼ����Ƿ����κο����ѱ�
				// ���뵽�ж�������еĴ���
			}

		}

		private void btnCancelAll_Click(object sender, System.EventArgs e)
		{
			this.objdsUser.RejectChanges();

		}

		private void objdsUser_PositionChanged()
		{
			this.lblNavLocation.Text = ((((this.BindingContext[objdsUser,"UserRight"].Position + 1)).ToString() + " �� ") 
				+ this.BindingContext[objdsUser,"UserRight"].Count.ToString());

		}

		private void btnNavNext_Click(object sender, System.EventArgs e)
		{
			this.BindingContext[objdsUser,"UserRight"].Position = (this.BindingContext[objdsUser,"UserRight"].Position + 1);
			this.objdsUser_PositionChanged();

		}

		private void btnNavPrev_Click(object sender, System.EventArgs e)
		{
			this.BindingContext[objdsUser,"UserRight"].Position = (this.BindingContext[objdsUser,"UserRight"].Position - 1);
			this.objdsUser_PositionChanged();

		}

		private void btnLast_Click(object sender, System.EventArgs e)
		{
			this.BindingContext[objdsUser,"UserRight"].Position = (this.objdsUser.Tables["UserRight"].Rows.Count - 1);
			this.objdsUser_PositionChanged();

		}

		private void btnNavFirst_Click(object sender, System.EventArgs e)
		{
			this.BindingContext[objdsUser,"UserRight"].Position = 0;
			this.objdsUser_PositionChanged();

		}

		private void btnUpdate_Click(object sender, System.EventArgs e)
		{
			try 
			{
				// ���Ը�������Դ��
				this.UpdateDataSet();
				ClassComm.InfoMsg("����ɹ���");
			}
			catch//(System.Exception eUpdate) 
			{
				// �ڴ˴���Ӵ�������롣
				// ��ʾ������Ϣ(�����)��
//				System.Windows.Forms.MessageBox.Show(eUpdate.Message);	
				ClassComm.InfoMsg("�û����Ѿ����ڣ�");
				this.editUserRight.Focus();
			}
			this.LoadDataSet();
			this.objdsUser_PositionChanged();

		}

		private void btnAdd_Click(object sender, System.EventArgs e)
		{

			try 
			{
				// �����ǰ�༭����
				this.objdsUser.UserRight.UserRightColumn.DefaultValue = 0;
				this.BindingContext[objdsUser,"UserRight"].EndCurrentEdit();
				this.BindingContext[objdsUser,"UserRight"].AddNew();

				this.editUserName.Enabled = true;
				this.editUserRight.Text = "0";
				this.editUserName.Focus();
			}
			catch (System.Exception eEndEdit) 
			{
				System.Windows.Forms.MessageBox.Show(eEndEdit.Message);
			}
			this.objdsUser_PositionChanged();

		}

		private void btnDelete_Click(object sender, System.EventArgs e)
		{
			if ((this.BindingContext[objdsUser,"UserRight"].Count > 0)) 
			{
				if (MessageBox.Show("���Ҫɾ��������¼��","��ʾ",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
				{
					this.BindingContext[objdsUser,"UserRight"].RemoveAt(this.BindingContext[objdsUser,"UserRight"].Position);
					try
					{
						this.UpdateDataSet();
					}
					catch
					{
						ClassComm.InfoMsg("ɾ��ʱ������ȷ���Ƿ��������");
					}
					this.LoadDataSet();
					this.objdsUser_PositionChanged();
				}
			}
			else
			{
				ClassComm.InfoMsg("û�м�¼��ɾ��");
			}

		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
//			this.BindingContext[objdsUser,"UserRight"].CancelCurrentEdit();
//			this.objdsUser_PositionChanged();
			this.Close();

		}

		private void DataFormUser_Load(object sender, System.EventArgs e)
		{
			try 
			{
				// ���Լ������ݼ���
				this.LoadDataSet();
			}
			catch (System.Exception eLoad) 
			{
				// �ڴ˴���Ӵ�������롣
				// ��ʾ������Ϣ(�����)��
				System.Windows.Forms.MessageBox.Show(eLoad.Message);
			}
			this.objdsUser_PositionChanged();
		}

		private void cbbRight_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this.editUserRight.Text = this.cbbRight.SelectedIndex.ToString();
		}

		private void editUserRight_TextChanged(object sender, System.EventArgs e)
		{
			byte i;
			try
			{
				i = System.Convert.ToByte(this.editUserRight.Text.Trim());
			}
			catch
			{
				i = 0;
			}
			cbbRight.SelectedIndex = i;
		}
	}
}
