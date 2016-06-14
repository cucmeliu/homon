using System;
using System.Collections;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Homon
{
	/// <summary>
	/// ClassComm ��ժҪ˵����
	/// </summary>
	public class ClassComm
	{
		public ClassComm()
		{
			//
			// TODO: �ڴ˴���ӹ��캯���߼�
			//
		}

		//
		public static string ConnectionStr
		{
			get { return frmLogin.connStr;}
//			set {connStr = value;}
		}

		/// <summary>
		/// ͨ����������ָ�����ֶ�
		/// </summary>
		/// <param name="tableName"> ���� </param>
		/// <param name="pkField">�����ֶ���</param>
		/// <param name="pkValue">ֵ</param>
		/// <param name="nameField">Ҫ���ص�ָ���ֶ�</param>
		/// <returns>ָ���ֶεķ���ֵ</returns>
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
		/// ���������ͻ ���� ���������(ͨ���ַ�����ֵ)
		/// </summary>
		/// <param name="tableName"> ���� </param>
		/// <param name="pk1"> �����ֶ��� </param>
		/// <param name="pkStr1"> �̲��ҵ������ֶε�ֵ </param>
		/// <param name="pkExp1"> �����ֶε������� </param>
		/// <returns>true:���в����ڴ����� false: ���д��ڴ�����</returns>
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
				{//�������Ѿ�����
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
		/// ����sql�ַ���ĵ�����"'"
		/// </summary>
		/// <param name="FieldStr"> ������ַ��� </param>
		/// <returns> ����Sql���ʵ��Ӧ�ô�����ַ���</returns>
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
		/// һ����Ϣ��ʾ����Ϣ
		/// </summary>
		/// <param name="msg"> ��Ϣ���� </param>
		public static void InfoMsg(string msg)
		{
			MessageBox.Show(msg, "��ʾ��Ϣ", MessageBoxButtons.OK,
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

		#region ˽�б���

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

		#region ����

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

		#region ����

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
		/// <param name="birthDate"> ���� </param>
		/// <param name="searchDate"> ���ҵ�ָ������ </param>
		/// <param name="minFitRate"> ��Χ������ </param>
		/// <param name="maxFitRate"> ��Χ������ </param>
		/// <param name="CycleDay"> ���ڵ�ʱ�䳤�������������ھ��ɴ��� </param>
		/// <returns></returns>
		private bool IsFitCustomer(DateTime birthDate, DateTime searchDate, double minFitRate, double maxFitRate, int CycleDay)
		{
			System.TimeSpan ts = searchDate - birthDate;
			int dayBetween = ts.Days;	//����ʱ��֮�������
			dayBetween = dayBetween % CycleDay;	//����ʣ�µ�����
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
		/// ���еĹ۲����
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
