using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Homon
{
	/// <summary>
	/// DataFormCust 的摘要说明。
	/// </summary>
	public class DataFormCust : System.Windows.Forms.Form
	{
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private Homon.dsCust objdsCust;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Label lblCustomerBirth;
		private System.Windows.Forms.Label lblCustomerName;
		private System.Windows.Forms.TextBox editCustomerName;
		private System.Windows.Forms.Button btnNavFirst;
		private System.Windows.Forms.Button btnNavPrev;
		private System.Windows.Forms.Label lblNavLocation;
		private System.Windows.Forms.Button btnNavNext;
		private System.Windows.Forms.Button btnLast;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.TextBox txtBirth;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public DataFormCust()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();
			this.oleDbConnection1.ConnectionString = ClassComm.ConnectionStr;
			

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(DataFormCust));
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.objdsCust = new Homon.dsCust();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.lblCustomerBirth = new System.Windows.Forms.Label();
			this.lblCustomerName = new System.Windows.Forms.Label();
			this.editCustomerName = new System.Windows.Forms.TextBox();
			this.btnNavFirst = new System.Windows.Forms.Button();
			this.btnNavPrev = new System.Windows.Forms.Button();
			this.lblNavLocation = new System.Windows.Forms.Label();
			this.btnNavNext = new System.Windows.Forms.Button();
			this.btnLast = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.txtBirth = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.objdsCust)).BeginInit();
			this.SuspendLayout();
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT CustomerBirth, CustomerName FROM CustomerList";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=0;Jet OLEDB:Database Password=;Data Source=""C:\Practice\Homon\Homon\bin\Debug\Homo.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO CustomerList(CustomerBirth, CustomerName) VALUES (?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("CustomerBirth", System.Data.OleDb.OleDbType.DBDate, 0, "CustomerBirth"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("CustomerName", System.Data.OleDb.OleDbType.VarWChar, 50, "CustomerName"));
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = "UPDATE CustomerList SET CustomerBirth = ?, CustomerName = ? WHERE (CustomerName =" +
				" ?) AND (CustomerBirth = ? OR ? IS NULL AND CustomerBirth IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("CustomerBirth", System.Data.OleDb.OleDbType.DBDate, 0, "CustomerBirth"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("CustomerName", System.Data.OleDb.OleDbType.VarWChar, 50, "CustomerName"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CustomerName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CustomerName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CustomerBirth", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CustomerBirth", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CustomerBirth1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CustomerBirth", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = "DELETE FROM CustomerList WHERE (CustomerName = ?) AND (CustomerBirth = ? OR ? IS " +
				"NULL AND CustomerBirth IS NULL)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CustomerName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CustomerName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CustomerBirth", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CustomerBirth", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CustomerBirth1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CustomerBirth", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
			this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "CustomerList", new System.Data.Common.DataColumnMapping[] {
																																																						new System.Data.Common.DataColumnMapping("CustomerBirth", "CustomerBirth"),
																																																						new System.Data.Common.DataColumnMapping("CustomerName", "CustomerName")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// objdsCust
			// 
			this.objdsCust.DataSetName = "dsCust";
			this.objdsCust.Locale = new System.Globalization.CultureInfo("zh-CN");
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnUpdate.Location = new System.Drawing.Point(288, 76);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(90, 28);
			this.btnUpdate.TabIndex = 2;
			this.btnUpdate.Text = "保存(&U)";
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// lblCustomerBirth
			// 
			this.lblCustomerBirth.Location = new System.Drawing.Point(16, 71);
			this.lblCustomerBirth.Name = "lblCustomerBirth";
			this.lblCustomerBirth.Size = new System.Drawing.Size(68, 23);
			this.lblCustomerBirth.TabIndex = 3;
			this.lblCustomerBirth.Text = "生日";
			// 
			// lblCustomerName
			// 
			this.lblCustomerName.Location = new System.Drawing.Point(16, 24);
			this.lblCustomerName.Name = "lblCustomerName";
			this.lblCustomerName.Size = new System.Drawing.Size(68, 23);
			this.lblCustomerName.TabIndex = 5;
			this.lblCustomerName.Text = "姓名";
			// 
			// editCustomerName
			// 
			this.editCustomerName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.objdsCust, "CustomerList.CustomerName"));
			this.editCustomerName.Enabled = false;
			this.editCustomerName.Location = new System.Drawing.Point(84, 20);
			this.editCustomerName.Name = "editCustomerName";
			this.editCustomerName.Size = new System.Drawing.Size(176, 26);
			this.editCustomerName.TabIndex = 8;
			this.editCustomerName.Text = "";
			// 
			// btnNavFirst
			// 
			this.btnNavFirst.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNavFirst.BackgroundImage")));
			this.btnNavFirst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnNavFirst.Location = new System.Drawing.Point(12, 116);
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
			this.btnNavPrev.Location = new System.Drawing.Point(52, 116);
			this.btnNavPrev.Name = "btnNavPrev";
			this.btnNavPrev.Size = new System.Drawing.Size(35, 23);
			this.btnNavPrev.TabIndex = 5;
			this.btnNavPrev.Text = "<";
			this.btnNavPrev.Click += new System.EventHandler(this.btnNavPrev_Click);
			// 
			// lblNavLocation
			// 
			this.lblNavLocation.BackColor = System.Drawing.Color.White;
			this.lblNavLocation.ForeColor = System.Drawing.Color.OrangeRed;
			this.lblNavLocation.Location = new System.Drawing.Point(84, 116);
			this.lblNavLocation.Name = "lblNavLocation";
			this.lblNavLocation.Size = new System.Drawing.Size(95, 23);
			this.lblNavLocation.TabIndex = 9;
			this.lblNavLocation.Text = "无记录";
			this.lblNavLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnNavNext
			// 
			this.btnNavNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNavNext.BackgroundImage")));
			this.btnNavNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnNavNext.Location = new System.Drawing.Point(180, 116);
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
			this.btnLast.Location = new System.Drawing.Point(216, 116);
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
			this.btnAdd.Text = "添加(&A)";
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
			this.btnDelete.Text = "删除(&D)";
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
			this.btnCancel.Text = "关闭(&C)";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(84, 68);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(176, 26);
			this.dateTimePicker1.TabIndex = 9;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// txtBirth
			// 
			this.txtBirth.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.objdsCust, "CustomerList.CustomerBirth"));
			this.txtBirth.Location = new System.Drawing.Point(168, 68);
			this.txtBirth.Name = "txtBirth";
			this.txtBirth.Size = new System.Drawing.Size(76, 26);
			this.txtBirth.TabIndex = 10;
			this.txtBirth.Text = "textBox1";
			this.txtBirth.TextChanged += new System.EventHandler(this.txtBirth_TextChanged);
			// 
			// DataFormCust
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
			this.BackColor = System.Drawing.Color.SkyBlue;
			this.ClientSize = new System.Drawing.Size(390, 152);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.lblCustomerBirth);
			this.Controls.Add(this.lblCustomerName);
			this.Controls.Add(this.editCustomerName);
			this.Controls.Add(this.btnNavFirst);
			this.Controls.Add(this.btnNavPrev);
			this.Controls.Add(this.lblNavLocation);
			this.Controls.Add(this.btnNavNext);
			this.Controls.Add(this.btnLast);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.txtBirth);
			this.Font = new System.Drawing.Font("宋体", 12F);
			this.ForeColor = System.Drawing.Color.OrangeRed;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DataFormCust";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "观察对象管理";
			this.Load += new System.EventHandler(this.DataFormCust_Load);
			((System.ComponentModel.ISupportInitialize)(this.objdsCust)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		public void FillDataSet(Homon.dsCust dataSet)
		{
			// 在填充数据集前关闭约束检查。
			// 这允许适配器填充数据集而不用考虑
			// 表之间的依赖项。
			dataSet.EnforceConstraints = false;
			try 
			{
				// 打开连接。
				this.oleDbConnection1.Open();
				// 尝试通过 OleDbDataAdapter1 填充数据集。
				this.oleDbDataAdapter1.Fill(dataSet);
			}
			catch (System.Exception fillException) 
			{
				// 在此处添加错误处理代码。
				throw fillException;
			}
			finally 
			{
				// 重新打开约束检查。
				dataSet.EnforceConstraints = true;
				// 无论是否引发了异常都关闭连接。
				this.oleDbConnection1.Close();
			}

		}

		public void UpdateDataSource(Homon.dsCust ChangedRows)
		{
			try 
			{
				// 在有挂起的更改时，只需要更新数据源即可。
				if ((ChangedRows != null)) 
				{
					// 打开连接。
					this.oleDbConnection1.Open();
					// 尝试更新数据源。
					oleDbDataAdapter1.Update(ChangedRows);
				}
			}
			catch (System.Exception updateException) 
			{
				// 在此处添加错误处理代码。
				throw updateException;
			}
			finally 
			{
				// 无论是否引发了异常都关闭连接。
				this.oleDbConnection1.Close();
			}

		}

		public void LoadDataSet()
		{
			// 创建一个新数据集以保存从 FillDataSet 调用返回的记录。
			// 使用了一个临时数据集，这是因为填充现有的数据集
			// 需要重新绑定数据绑定。
			Homon.dsCust objDataSetTemp;
			objDataSetTemp = new Homon.dsCust();
			try 
			{
				// 尝试填充临时数据集。
				this.FillDataSet(objDataSetTemp);
			}
			catch (System.Exception eFillDataSet) 
			{
				// 在此处添加错误处理代码。
				throw eFillDataSet;
			}
			try 
			{
				// 清空数据集中的旧记录。
				objdsCust.Clear();
				// 将记录合并到主数据集中。
				objdsCust.Merge(objDataSetTemp);
			}
			catch (System.Exception eLoadMerge) 
			{
				// 在此处添加错误处理代码。
				throw eLoadMerge;
			}
			this.editCustomerName.Enabled = false;

		}

		public void UpdateDataSet()
		{
			// 创建一个新数据集来保存对主数据集所做的更改。
			Homon.dsCust objDataSetChanges = new Homon.dsCust();
			// 停止当前的任何编辑。
			this.BindingContext[objdsCust,"CustomerList"].EndCurrentEdit();
			// 获取对主数据集所做的更改。
			objDataSetChanges = ((Homon.dsCust)(objdsCust.GetChanges()));
			// 检查是否做了任何更改。
			if ((objDataSetChanges != null)) 
			{
				try 
				{
					// 需要做一些更改，所以尝试通过调用 update 方法
					// 和传递数据集以及任何参数来更新数据源。
					this.UpdateDataSource(objDataSetChanges);
					objdsCust.Merge(objDataSetChanges);
					objdsCust.AcceptChanges();
				}
				catch (System.Exception eUpdate) 
				{
					// 在此处添加错误处理代码。
					throw eUpdate;
				}
				// 添加代码以检查返回的数据集中是否有任何可能已被
				// 推入到行对象错误中的错误。
			}

		}

		private void btnCancelAll_Click(object sender, System.EventArgs e)
		{
			this.objdsCust.RejectChanges();

		}

		private void objdsCust_PositionChanged()
		{
			this.lblNavLocation.Text = ((((this.BindingContext[objdsCust,"CustomerList"].Position + 1)).ToString() + " 的 ") 
				+ this.BindingContext[objdsCust,"CustomerList"].Count.ToString());

		}

		private void btnNavNext_Click(object sender, System.EventArgs e)
		{
			this.BindingContext[objdsCust,"CustomerList"].Position = (this.BindingContext[objdsCust,"CustomerList"].Position + 1);
			this.objdsCust_PositionChanged();

		}

		private void btnNavPrev_Click(object sender, System.EventArgs e)
		{
			this.BindingContext[objdsCust,"CustomerList"].Position = (this.BindingContext[objdsCust,"CustomerList"].Position - 1);
			this.objdsCust_PositionChanged();

		}

		private void btnLast_Click(object sender, System.EventArgs e)
		{
			this.BindingContext[objdsCust,"CustomerList"].Position = (this.objdsCust.Tables["CustomerList"].Rows.Count - 1);
			this.objdsCust_PositionChanged();

		}

		private void btnNavFirst_Click(object sender, System.EventArgs e)
		{
			this.BindingContext[objdsCust,"CustomerList"].Position = 0;
			this.objdsCust_PositionChanged();

		}

		private void btnUpdate_Click(object sender, System.EventArgs e)
		{
			string custname = this.editCustomerName.Text.Trim();
			try 
			{
				// 尝试更新数据源。
				this.UpdateDataSet();
				ClassComm.InfoMsg("保存成功！");
			}
			catch //(System.Exception eUpdate) 
			{
				// 在此处添加错误处理代码。
				// 显示错误信息(如果有)。
//				System.Windows.Forms.MessageBox.Show(eUpdate.Message);
				ClassComm.InfoMsg("此姓名已经存在！建议使用：\n"
					+ "\t" + custname + "001 或 \n"
					+ "\t" + custname + "2000");
				this.editCustomerName.Focus();
			}
			this.LoadDataSet();
			this.objdsCust_PositionChanged();

		}

		private void btnAdd_Click(object sender, System.EventArgs e)
		{

			try 
			{
				this.objdsCust.CustomerList.CustomerBirthColumn.DefaultValue = System.DateTime.Today;
				// 清除当前编辑内容
				this.BindingContext[objdsCust,"CustomerList"].EndCurrentEdit();
				this.BindingContext[objdsCust,"CustomerList"].AddNew();
			
				this.editCustomerName.Enabled = true;
				this.editCustomerName.Focus();
				this.dateTimePicker1.Value = System.DateTime.Today;
			}
			catch (System.Exception eEndEdit) 
			{
				System.Windows.Forms.MessageBox.Show(eEndEdit.Message);
			}
			this.objdsCust_PositionChanged();

		}

		private void btnDelete_Click(object sender, System.EventArgs e)
		{
			if ((this.BindingContext[objdsCust,"CustomerList"].Count > 0)) 
			{
				if (MessageBox.Show("真的要删除这条记录吗？","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
				{
					this.BindingContext[objdsCust,"CustomerList"].RemoveAt(this.BindingContext[objdsCust,"CustomerList"].Position);
					try
					{
						this.UpdateDataSet();						
					}
					catch
					{
						ClassComm.InfoMsg("删除时出错，请确认是否操作错误！");
					}
					this.LoadDataSet();
					this.objdsCust_PositionChanged();
				}
			}
			else
			{
				ClassComm.InfoMsg("没有记录可删！");
			}

		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
//			this.BindingContext[objdsCust,"CustomerList"].CancelCurrentEdit();
//			this.objdsCust_PositionChanged();
			this.Close();

		}

		private void DataFormCust_Load(object sender, System.EventArgs e)
		{
			try 
			{
				// 尝试加载数据集。
				this.LoadDataSet();
			}
			catch (System.Exception eLoad) 
			{
				// 在此处添加错误处理代码。
				// 显示错误信息(如果有)。
				System.Windows.Forms.MessageBox.Show(eLoad.Message);
			}
			this.objdsCust_PositionChanged();
		}

		private void txtBirth_TextChanged(object sender, System.EventArgs e)
		{
			try
			{
				this.dateTimePicker1.Value = System.DateTime.Parse(this.txtBirth.Text);
			}
			catch
			{
				this.dateTimePicker1.Value = System.DateTime.Today;
			}
		}

		private void dateTimePicker1_ValueChanged(object sender, System.EventArgs e)
		{
			this.txtBirth.Text = this.dateTimePicker1.Value.ToShortDateString();
		}
	}
}
