using System;
using System.Collections;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Homon
{
	/// <summary>
	/// ClassComm 的摘要说明。
	/// </summary>
	public class ClassComm
	{
		public ClassComm()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}

		//
		public static string ConnectionStr
		{
			get { return frmLogin.connStr;}
//			set {connStr = value;}
		}

		/// <summary>
		/// 通过主键查找指定的字段
		/// </summary>
		/// <param name="tableName"> 表名 </param>
		/// <param name="pkField">主键字段名</param>
		/// <param name="pkValue">值</param>
		/// <param name="nameField">要返回的指定字段</param>
		/// <returns>指定字段的返回值</returns>
		public static string getIDName(string tableName, string pkField,
			string pkValue, string nameField)
		{
			pkValue = dealFieldStr(pkValue);
			System.Data.OleDb.OleDbConnection Conn =
				new System.Data.OleDb.OleDbConnection(ConnectionStr);

			System.Data.OleDb.OleDbCommand cmd = Conn.CreateCommand();
			cmd.CommandText = "Select " + nameField +" from " 
				+ tableName + " where " + pkField + " = '" + pkValue + "'";
			try
			{
				Conn.Open();				
				return cmd.ExecuteScalar().ToString();
			}
			catch
			{
				return null;
			}
			finally
			{
				Conn.Close();
				cmd.Dispose();
			}
		}
		
		/// <summary>
		/// 检查主键冲突 －－ 单主键情况(通过字符串传值)
		/// </summary>
		/// <param name="tableName"> 表名 </param>
		/// <param name="pk1"> 主键字段名 </param>
		/// <param name="pkStr1"> 侍查找的主键字段的值 </param>
		/// <param name="pkExp1"> 主键字段的中文名 </param>
		/// <returns>true:表中不存在此主键 false: 表中存在此主键</returns>
		public static bool checkPriKey(string tableName, 
			string pk1, string pkStr1, string pkExp1)
		{
			pkStr1 = dealFieldStr(pkStr1);
			System.Data.OleDb.OleDbConnection Conn = new System.Data.OleDb.OleDbConnection(ConnectionStr);
			System.Data.OleDb.OleDbCommand sc = Conn.CreateCommand();
			sc.CommandText = "Select count(*) from " 
				+ tableName + " where " + pk1 + " = '" + pkStr1
				+ "'";
			try
			{
				Conn.Open();
				if ((int)sc.ExecuteScalar() > 0)
				{//该主键已经存在
					return false;
				}
				else return true;											
			}
			catch
			{
				return false;
			}
			finally
			{
				Conn.Close();
				sc.Dispose();
			}
		}

		/// <summary>
		/// 处理sql字符里的单引号"'"
		/// </summary>
		/// <param name="FieldStr"> 输入的字符串 </param>
		/// <returns> 返回Sql语句实际应该处理的字符串</returns>
		public static string dealFieldStr(string FieldStr)
		{
			string rstStr="";
			int strLen = FieldStr.Length;
			for (int i=0; i<strLen; i++)
			{
				rstStr += FieldStr[i];
				if (FieldStr[i] == 39)
				{
					rstStr += "'";
				}
			}
			return rstStr;
		}

		/// <summary>
		/// 一般信息提示类消息
		/// </summary>
		/// <param name="msg"> 消息内容 </param>
		public static void InfoMsg(string msg)
		{
			MessageBox.Show(msg, "提示信息", MessageBoxButtons.OK,
				MessageBoxIcon.Information);
		}

	}

	class FittedCustomer
	{
		public struct PersonBirthday
		{
			public string PersonName;
			public DateTime Birthday;

			public PersonBirthday(string personName, DateTime birthday) 
			{
				PersonName = personName;
				Birthday = birthday;    
			}
		}

		#region 私有变量

		private const int cyclePhysical = 23;//12?
		private const int cycleEmotion  = 28;//14?
		private const int cycleWisdom	= 33;//15?

		private double minPhyRate = 0;
		private double maxPhyRate = 1;

		private double minEmoRate = 0;
		private double maxEmoRate = 1;

		private double minWisRate = 0;
		private double maxWisRate = 1;

		private DateTime searchDate = DateTime.Today;

		private PersonBirthday[] allCustomer;
		private ArrayList fitCustomer = new ArrayList();

		#endregion

		public FittedCustomer()
		{
			allCustomer = new PersonBirthday[custCount()];
			allCustomer.Initialize();
		}

		#region 属性

		public double MinPhysicalRate
		{
			get { return minPhyRate; }
			set { minPhyRate = value; }
		}
		
		public double MaxPhysicalRate
		{
			get { return maxPhyRate; }
			set { maxPhyRate = value; }
		}
		
		public double MinEmotionRate
		{
			get { return minEmoRate; }
			set { minEmoRate = value; }
		}
		
		public double MaxEmotionRate
		{
			get { return maxEmoRate; }
			set { maxEmoRate = value; }
		}
		
		public double MinWisdomRate
		{
			get { return minWisRate; }
			set { minWisRate = value; }
		}
		
		public double MaxWisdomRate
		{
			get { return maxWisRate; }
			set { maxWisRate = value; }
		}		

		public DateTime SearchDate
		{
			get { return searchDate; }
			set { searchDate = value; }
		}

		public ArrayList FitCustomer
		{
			get { return fitCustomer; }
		}

		#endregion

		#region 方法

		public void ResetParas()
		{
			minPhyRate = 0;
			maxPhyRate = 1;
			minEmoRate = 0;
			maxEmoRate = 1;
			minWisRate = 0;
			maxWisRate = 1;

			searchDate = DateTime.Today;
		}

		public void SetOK()
		{
			ResetArrays();
			LoadCustomer();
			LoadFitCustomer();
		}

		#endregion

		/// <summary>
		/// 
		/// </summary>
		/// <param name="birthDate"> 生日 </param>
		/// <param name="searchDate"> 查找的指定日期 </param>
		/// <param name="minFitRate"> 范围的下限 </param>
		/// <param name="maxFitRate"> 范围的上限 </param>
		/// <param name="CycleDay"> 周期的时间长（这样三个周期均可处理） </param>
		/// <returns></returns>
		private bool IsFitCustomer(DateTime birthDate, DateTime searchDate, double minFitRate, double maxFitRate, int CycleDay)
		{
			System.TimeSpan ts = searchDate - birthDate;
			int dayBetween = ts.Days;	//两个时间之间的天数
			dayBetween = dayBetween % CycleDay;	//周期剩下的天数
			double x = (double)dayBetween/(double)CycleDay;
			double y = Math.Sin((x*2-0.5)*3.1415926);
			if ((y>=minFitRate)&&(y<=maxFitRate))
			{
				return true;
			}
			return false;
		}

		private void ResetArrays()
		{			
			this.fitCustomer.Clear();
			allCustomer = new PersonBirthday[custCount()];
		}

		private void LoadFitCustomer()
		{
			
			foreach(PersonBirthday a in allCustomer)
			{
				if (a.PersonName != null)
				{
					if ((IsFitCustomer(a.Birthday, this.searchDate, minPhyRate, maxPhyRate, cyclePhysical))
						&& (IsFitCustomer(a.Birthday, this.searchDate, minEmoRate, maxEmoRate, cycleEmotion)) 
						&& (IsFitCustomer(a.Birthday, this.searchDate, minWisRate, maxWisRate, cycleWisdom)))
					{
						fitCustomer.Add(a.PersonName);
					}
				}
			}
		}

		private int custCount()
		{
			int cc;
			System.Data.OleDb.OleDbConnection Conn = new System.Data.OleDb.OleDbConnection(ClassComm.ConnectionStr);
			System.Data.OleDb.OleDbCommand sc = Conn.CreateCommand();
			sc.CommandText = "Select count(CustomerName) from CustomerList ";
			try
			{
				Conn.Open();
				cc = (int)sc.ExecuteScalar();
				return cc;
			}
			catch
			{
				return 0;
			}
			finally
			{
				Conn.Close();
				sc.Dispose();
			}
		}

		/// <summary>
		/// 所有的观察对象
		/// </summary>
		/// <returns></returns>
		private void LoadCustomer()
		{
			this.allCustomer.Initialize();//.Clear();
			int i=0;
			System.Data.OleDb.OleDbConnection Conn = new System.Data.OleDb.OleDbConnection(ClassComm.ConnectionStr);
			System.Data.OleDb.OleDbCommand sc = Conn.CreateCommand();
			sc.CommandText = "Select CustomerName, CustomerBirth from CustomerList ";
			OleDbDataReader myReader;
			try
			{
				Conn.Open();
				myReader = sc.ExecuteReader();
				if (myReader.HasRows)
				{
					while (myReader.Read())
					{
						if (i<allCustomer.Length)
						{
							allCustomer[i].PersonName = myReader.GetString(0);
							allCustomer[i].Birthday = myReader.GetDateTime(1);
							i++;
						}
					}					
				}
			}
			catch(System.Exception se)
			{
				throw se;
			}
			finally
			{
				sc.Dispose();
				Conn.Close();		
				
			}
			
		}

	}

	}
