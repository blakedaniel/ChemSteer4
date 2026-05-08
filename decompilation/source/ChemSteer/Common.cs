using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ADODB;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ChemSteer;

[StandardModule]
internal sealed class Common
{
	public static Connection MyConn;

	public static Connection DataConn;

	public static Connection gssConn;

	public static Connection connGssTab3;

	public static string gblUserid;

	public static string gblSQL;

	public const string ApplName = "ChemSTEER";

	public const string ApplAcronym = "ChemSTEER";

	public const short EM_CANUNDO = 198;

	public const short EM_UNDO = 199;

	static Common()
	{
		Guid clsid = new Guid("00000514-0000-0010-8000-00AA006D2EA4");
		MyConn = (Connection)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		clsid = new Guid("00000514-0000-0010-8000-00AA006D2EA4");
		DataConn = (Connection)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		clsid = new Guid("00000514-0000-0010-8000-00AA006D2EA4");
		gssConn = (Connection)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		clsid = new Guid("00000514-0000-0010-8000-00AA006D2EA4");
		connGssTab3 = (Connection)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
	}

	[DllImport("user32", CharSet = CharSet.Ansi, EntryPoint = "SendMessageA", ExactSpelling = true, SetLastError = true)]
	public static extern int SendMessage(int hWnd, int wMsg, int wParam, ref int lParam);

	public static void LoadStateCombo(ref ComboBox pCombo)
	{
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		recordset.CursorLocation = CursorLocationEnum.adUseClient;
		recordset.Open("SELECT * FROM States", MyConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
		while (!recordset.EOF)
		{
			pCombo.Items.Add(RuntimeHelpers.GetObjectValue(recordset.Fields["StateCode"].Value));
			recordset.MoveNext();
		}
		recordset.Close();
		recordset = null;
	}

	public static void CommonErrHandler(ref string Eobject, ref string Efunction, ref int Enumber, ref string Edescription, ref bool Econtact)
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		Cursor.Current = Cursors.Default;
		Interaction.Beep();
		string text = "Error " + Conversions.ToString(Enumber) + " - " + Edescription;
		string text2 = ((!Econtact) ? text : (text + ".  Please contact Technical Support."));
		text = Strings.Left(text + "/" + Eobject + "/" + Efunction, 255);
		Interaction.MsgBox((object)text2, (MsgBoxStyle)48, (object)(Eobject + " / " + Efunction));
	}

	public static string TrtSingleQuotes(ref string work)
	{
		short num = 1;
		checked
		{
			do
			{
				num = (short)Strings.InStr(unchecked((int)num), work, "'", (CompareMethod)0);
				if (num == 0)
				{
					break;
				}
				work = Strings.Left(work, unchecked((int)num)) + Strings.Right(work, Strings.Len(work) - num + 1);
				num += 2;
			}
			while (num <= Strings.Len(work));
			return work;
		}
	}

	public static string TrtTrueFalse(ref bool Boo)
	{
		return Conversions.ToString(Interaction.IIf(Boo, (object)"True", (object)"False"));
	}

	public static string Cvt2YesNo(bool pBool)
	{
		if (pBool)
		{
			return "Yes";
		}
		return "No";
	}

	public static object MyNullCheck1(object DaData)
	{
		if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(DaData)))
		{
			return 1;
		}
		if (!Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(DaData)))
		{
			return 1;
		}
		return RuntimeHelpers.GetObjectValue(DaData);
	}

	public static object MyNullCheck0(object DaData)
	{
		if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(DaData)))
		{
			return 0;
		}
		if (!Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(DaData)))
		{
			return 0;
		}
		return RuntimeHelpers.GetObjectValue(DaData);
	}

	public static object MyNullCheck0Null(object DaData)
	{
		if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(DaData)))
		{
			return DBNull.Value;
		}
		if (Operators.ConditionalCompareObjectEqual(DaData, (object)"", false))
		{
			return DBNull.Value;
		}
		return RuntimeHelpers.GetObjectValue(DaData);
	}

	public static string MyNullCheck(object DaData)
	{
		if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(DaData)))
		{
			return "";
		}
		return Conversions.ToString(DaData);
	}

	public static string Stacker(ref string pWork, ref string pDelim, ref string pDesc, ref object pValue, ref object pYes)
	{
		if (Operators.ConditionalCompareObjectEqual(pValue, pYes, false))
		{
			if (Strings.Len(pWork) == 0)
			{
				return pDesc;
			}
			return pWork + pDelim + pDesc;
		}
		return pWork;
	}
}
