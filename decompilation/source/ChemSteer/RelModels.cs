using System;
using System.Windows.Forms;
using ADODB;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ChemSteer;

[StandardModule]
internal sealed class RelModels
{
	private static bool blnDR;

	private static bool blnAR;

	private static bool blnFreq;

	private static bool blnDRcb;

	private static bool blnARcb;

	private static string strParm;

	private static string strmissingvars;

	private static string strmissingvarsintro;

	private static bool blnparm;

	private static string strdivisionbyzerovars;

	private static string strdivisionbyzero;

	private static string strmodeltext;

	private static string strmodeltext1;

	private static string strmodeltext2;

	private static string strFreqcheck;

	private static string strPVopcheck;

	private static bool RelRinseWater(ref short pOpID, ref short pActID)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					if (Globals_Renamed.arParmValues[72] > 365f)
					{
						Interaction.MsgBox((object)strFreqcheck, (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[2] = Globals_Renamed.arParmValues[72];
					Globals_Renamed.arOutput[1] = (float)((double)Globals_Renamed.arParmValues[138] * 3.78 * (double)Globals_Renamed.arParmValues[132] * (double)Globals_Renamed.arParmValues[134] * (double)(1f - Globals_Renamed.arParmValues[139]));
					Globals_Renamed.arOutput[3] = Globals_Renamed.arOutput[1] * Globals_Renamed.arOutput[2] * Globals_Renamed.arParmValues[1];
					if ((double)Globals_Renamed.arOutput[3] > Globals_Renamed.arOpPv[pOpID])
					{
						Interaction.MsgBox((object)strPVopcheck, (MsgBoxStyle)64, (object)strmodeltext);
					}
					flag = true;
					break;
				case 313:
					num = -1;
					switch (num2)
					{
					case 2:
						break;
					default:
						goto end_IL_0001_2;
					}
					break;
				}
				if (Information.Err().Number != 0)
				{
					Cursor.Current = Cursors.Default;
					Interaction.MsgBox((object)("Error " + Conversions.ToString(Information.Err().Number) + " - " + Information.Err().Description), (MsgBoxStyle)64, (object)"Runtime Error");
				}
				break;
				end_IL_0001_2:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 313;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static bool RunReleaseModels(ref short pOpID, ref short pActID, ref short pmodId, ref short pDualID)
	{
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset2 = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		recordset.CursorLocation = CursorLocationEnum.adUseClient;
		recordset.Open("SELECT ModelName FROM ListOfModels WHERE ModelID=" + Conversions.ToString((int)pmodId), Common.MyConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
		strmodeltext1 = Conversions.ToString(recordset.Fields[0].Value);
		recordset.Close();
		recordset2.CursorLocation = CursorLocationEnum.adUseClient;
		recordset2.Open("SELECT ActName FROM ListOfActivities WHERE ActID=" + Conversions.ToString((int)pActID), Common.MyConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
		strmodeltext2 = Conversions.ToString(recordset2.Fields[0].Value);
		recordset2.Close();
		strmodeltext = strmodeltext1 + " (" + strmodeltext2 + ")";
		strmissingvars = "";
		strmissingvarsintro = "In order for ChemSTEER to use the " + strmodeltext + " to calculate releases, you need to specify the following variable(s) on the View/Update Model Information Button on the Releases Tab:\r\n\r\n";
		strdivisionbyzerovars = "";
		strdivisionbyzero = "In order for ChemSTEER to use the " + strmodeltext + " to calculate releases, you need to supply non-zero values for the following variable(s) on the View/Update Model Information Button on the Releases Tab:\r\n\r\n";
		strFreqcheck = "Frequency exceeds 365";
		if (Globals_Renamed.gblDoEasyModels)
		{
			strPVopcheck = "The annual release for this model exceeds the volume estimated for this operation. Note that this does not apply to models run directly from the splash screen (advanced users).";
		}
		else
		{
			strPVopcheck = "The annual release for this model exceeds the volume estimated for this operation";
		}
		Cursor.Current = Cursors.WaitCursor;
		bool flag = default(bool);
		switch (pmodId)
		{
		case 7:
			flag = RelAp42(ref pOpID, ref pActID);
			break;
		case 9:
			flag = RelPenetration(ref pOpID, ref pActID);
			break;
		case 8:
			flag = RelMassTransfer(ref pOpID, ref pActID);
			break;
		case 39:
			flag = RelResidual(ref pOpID, ref pActID);
			break;
		case 41:
		case 48:
			flag = RelResidualLFautos(ref pOpID, ref pActID);
			break;
		case 1:
		case 2:
		case 3:
		case 4:
		case 5:
		case 6:
		case 12:
		case 13:
		case 14:
			flag = RelResidualLFnoUD(ref pOpID, ref pActID);
			break;
		case 42:
			flag = RelWaterSat(ref pOpID, ref pActID);
			break;
		case 43:
			flag = RelUserG(ref pOpID, ref pActID);
			break;
		case 51:
			flag = RelSpentBath(ref pOpID, ref pActID);
			break;
		case 52:
			flag = RelRinseWater(ref pOpID, ref pActID);
			break;
		case 53:
			flag = RelDustModel(ref pOpID, ref pActID);
			break;
		}
		Cursor.Current = Cursors.Default;
		bool result = flag;
		recordset = null;
		recordset2 = null;
		return result;
	}

	private static bool RelAp42(ref short pOpID, ref short pActID)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					if (Globals_Renamed.arParmValues[72] > 365f)
					{
						Interaction.MsgBox((object)strFreqcheck, (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[2] = Globals_Renamed.arParmValues[72];
					string text = "gcT";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[8], ref strdivisionbyzerovars);
					text = "gcR";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[6], ref strdivisionbyzerovars);
					if (Operators.CompareString(strdivisionbyzerovars, "", false) != 0)
					{
						Interaction.MsgBox((object)(strdivisionbyzero + strdivisionbyzerovars), (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arParmValues[50] = (float)((double)(Globals_Renamed.arParmValues[22] * Globals_Renamed.arParmValues[5]) * ((double)Globals_Renamed.arParmValues[19] * 3785.4) * (double)Globals_Renamed.arParmValues[23] * (double)Globals_Renamed.arParmValues[4] * (double)Globals_Renamed.arParmValues[40] / (double)(Globals_Renamed.arParmValues[8] * Globals_Renamed.arParmValues[6] * 3600f * 760f));
					Globals_Renamed.arParmValid[50] = true;
					Globals_Renamed.arOutput[1] = Globals_Renamed.arParmValues[50] * 3600f * Globals_Renamed.arParmValues[31] / 1000f;
					Globals_Renamed.arOutput[3] = Globals_Renamed.arOutput[1] * Globals_Renamed.arOutput[2] * Globals_Renamed.arParmValues[1];
					if ((double)Globals_Renamed.arOutput[3] > Globals_Renamed.arOpPv[pOpID])
					{
						Interaction.MsgBox((object)strPVopcheck, (MsgBoxStyle)64, (object)strmodeltext);
					}
					flag = true;
					goto end_IL_0001;
				}
				case 516:
					num = -1;
					switch (num2)
					{
					case 2:
						if (Information.Err().Number != 0)
						{
							Cursor.Current = Cursors.Default;
							Interaction.MsgBox((object)("Error " + Conversions.ToString(Information.Err().Number) + " - " + Information.Err().Description), (MsgBoxStyle)64, (object)"Runtime Error");
						}
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 516;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private static void missing_required_parameter(ref string strParm, ref bool blnparm, ref string strmissingvars)
	{
		double num = Conversion.Val(strParm);
		checked
		{
			if (num == 94.0)
			{
				if (!blnparm)
				{
					Globals_Renamed.arParmValues[(int)Math.Round(Globals_Renamed.arParmValues[72])] = 0f;
					Globals_Renamed.arOutput[2] = 0f;
				}
			}
			else if (num == 95.0)
			{
				if (!blnparm)
				{
					Globals_Renamed.arParmValues[(int)Math.Round(Globals_Renamed.arParmValues[72])] = 52f;
					Globals_Renamed.arOutput[2] = 52f;
				}
			}
			else if (num == 96.0)
			{
				if (!blnparm)
				{
					Globals_Renamed.arParmValues[(int)Math.Round(Globals_Renamed.arParmValues[72])] = 12f;
					Globals_Renamed.arOutput[2] = 12f;
				}
			}
			else if (num == 97.0)
			{
				if (!blnparm)
				{
					Globals_Renamed.arParmValues[(int)Math.Round(Globals_Renamed.arParmValues[72])] = 4f;
					Globals_Renamed.arOutput[2] = 4f;
				}
			}
			else if (num == 98.0)
			{
				if (!blnparm)
				{
					Globals_Renamed.arParmValues[(int)Math.Round(Globals_Renamed.arParmValues[72])] = 1f;
					Globals_Renamed.arOutput[2] = 1f;
				}
			}
			else if (((num >= 1.0 && num <= 1000.0) ? true : false) && !blnparm)
			{
				strmissingvars = strmissingvars + Globals_Renamed.arParmNames[Conversions.ToInteger(strParm)] + "\r\n";
			}
			switch (strParm)
			{
			case "amountpercontainer":
				if (!blnparm)
				{
					strmissingvars = strmissingvars + Globals_Renamed.arParmNames[30] + "; or " + Globals_Renamed.arParmNames[11] + " and " + Globals_Renamed.arParmNames[9] + " and " + Globals_Renamed.arParmNames[19] + " so that mass of chemical per container can be calculated.\r\n";
				}
				break;
			case "containersperyear":
				if (!blnparm)
				{
					strmissingvars = strmissingvars + Globals_Renamed.arParmNames[100] + "; or " + Globals_Renamed.arParmNames[16] + " or " + Globals_Renamed.arParmNames[2] + " so that containers/site-yr can be calculated.\r\n";
				}
				break;
			case "Nbd":
				if (!blnparm)
				{
					strmissingvars = strmissingvars + Globals_Renamed.arParmNames[17] + "\r\n";
				}
				break;
			case "DMOchem":
				if (!blnparm)
				{
					strmissingvars = strmissingvars + Globals_Renamed.arParmNames[13] + "\r\n";
				}
				break;
			case "fc":
				if (!blnparm)
				{
					strmissingvars = strmissingvars + Globals_Renamed.arParmNames[20] + "\r\n";
				}
				break;
			case "Yprod":
				if (!blnparm)
				{
					strmissingvars = strmissingvars + Globals_Renamed.arParmNames[10] + "\r\n";
				}
				break;
			case "Dm":
				if (!blnparm)
				{
					strmissingvars = strmissingvars + Globals_Renamed.arParmNames[9] + "\r\n";
				}
				break;
			case "OD":
				if (!blnparm)
				{
					strmissingvars = strmissingvars + Globals_Renamed.arParmNames[2] + "\r\n";
				}
				break;
			case "MBchem":
				if (!blnparm)
				{
					strmissingvars = strmissingvars + Globals_Renamed.arParmNames[18] + "\r\n";
				}
				break;
			case "Nby":
				if (!blnparm)
				{
					strmissingvars = strmissingvars + Globals_Renamed.arParmNames[16] + "\r\n";
				}
				break;
			case "MW":
				if (!blnparm)
				{
					strmissingvars = strmissingvars + Globals_Renamed.arParmNames[5] + "\r\n";
				}
				break;
			case "VP":
				if (!blnparm)
				{
					strmissingvars = strmissingvars + Globals_Renamed.arParmNames[4] + "\r\n";
				}
				break;
			case "T":
				if (!blnparm)
				{
					strmissingvars = strmissingvars + Globals_Renamed.arParmNames[8] + "\r\n";
				}
				break;
			case "R":
				if (!blnparm)
				{
					strmissingvars = strmissingvars + Globals_Renamed.arParmNames[6] + "\r\n";
				}
				break;
			case "DMIchem":
				if (!blnparm)
				{
					strmissingvars = strmissingvars + Globals_Renamed.arParmNames[15] + "\r\n";
				}
				break;
			case "Yrm":
				if (!blnparm)
				{
					strmissingvars = strmissingvars + Globals_Renamed.arParmNames[11] + "\r\n";
				}
				break;
			case "vzcb":
				if (!blnparm)
				{
					strmissingvars = strmissingvars + Globals_Renamed.arParmNames[69] + "\r\n";
				}
				break;
			case "dCB":
				if (!blnparm)
				{
					strmissingvars = strmissingvars + Globals_Renamed.arParmNames[26] + "\r\n";
				}
				break;
			case "dRE":
				if (!blnparm)
				{
					strmissingvars = strmissingvars + Globals_Renamed.arParmNames[25] + "\r\n";
				}
				break;
			case "P":
				if (!blnparm)
				{
					strmissingvars = strmissingvars + Globals_Renamed.arParmNames[7] + "\r\n";
				}
				break;
			case "Vc":
				if (!blnparm)
				{
					strmissingvars = strmissingvars + Globals_Renamed.arParmNames[19] + "\r\n";
				}
				break;
			case "NS":
				if (!blnparm)
				{
					strmissingvars = strmissingvars + Globals_Renamed.arParmNames[1] + "\r\n";
				}
				break;
			case "LF":
				if (!blnparm)
				{
					strmissingvars = strmissingvars + Globals_Renamed.arParmNames[33] + "\r\n";
				}
				break;
			case "fCB":
				if (!blnparm)
				{
					strmissingvars = strmissingvars + Globals_Renamed.arParmNames[22] + "\r\n";
				}
				break;
			case "fRE":
				if (!blnparm)
				{
					strmissingvars = strmissingvars + Globals_Renamed.arParmNames[21] + "\r\n";
				}
				break;
			case "rCB":
				if (!blnparm)
				{
					strmissingvars = strmissingvars + Globals_Renamed.arParmNames[24] + "\r\n";
				}
				break;
			case "rRE":
				if (!blnparm)
				{
					strmissingvars = strmissingvars + Globals_Renamed.arParmNames[23] + "\r\n";
				}
				break;
			case "Freq":
				if (!blnparm)
				{
					strmissingvars = strmissingvars + Globals_Renamed.arParmNames[72] + "\r\n";
				}
				break;
			case "DRcb":
				if (!blnparm)
				{
					strmissingvars = strmissingvars + Globals_Renamed.arParmNames[71] + "\r\n";
				}
				break;
			case "DRre":
				if (!blnparm)
				{
					strmissingvars = strmissingvars + Globals_Renamed.arParmNames[70] + "\r\n";
				}
				break;
			case "ARcb":
				if (!blnparm)
				{
					strmissingvars = strmissingvars + Globals_Renamed.arParmNames[74] + "\r\n";
				}
				break;
			case "ARre":
				if (!blnparm)
				{
					strmissingvars = strmissingvars + Globals_Renamed.arParmNames[73] + "\r\n";
				}
				break;
			}
		}
	}

	private static bool RelPenetration(ref short pOpID, ref short pActID)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					if (Globals_Renamed.arParmValues[72] > 365f)
					{
						Interaction.MsgBox((object)strFreqcheck, (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[2] = Globals_Renamed.arParmValues[72];
					if (Globals_Renamed.arParmValues[69] > 100f)
					{
						Interaction.MsgBox((object)"Note: This model is most appropriate for air speeds less than or equal to 100 ft/min. For air speeds greater than 100 ft/min, you should select and use the EPA/OPPT Mass Transfer Model to estimate the vapor generation rate.", (MsgBoxStyle)64, (object)"Model Validity Error");
					}
					Globals_Renamed.arParmValues[28] = (float)(Math.Pow(Globals_Renamed.arParmValues[26], 2.0) * 3.14159265359 / 4.0);
					Globals_Renamed.arParmValid[28] = true;
					string text = "gcMW";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[5], ref strdivisionbyzerovars);
					text = "gcT";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[8], ref strdivisionbyzerovars);
					text = "gcdCB";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[26], ref strdivisionbyzerovars);
					text = "gcP";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[7], ref strdivisionbyzerovars);
					if (Operators.CompareString(strdivisionbyzerovars, "", false) != 0)
					{
						Interaction.MsgBox((object)(strdivisionbyzero + strdivisionbyzerovars), (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arParmValues[50] = (float)(8.24E-08 * Math.Pow(Globals_Renamed.arParmValues[5], 0.835) * (double)Globals_Renamed.arParmValues[4] * (double)Globals_Renamed.arParmValues[40] * Math.Pow(1.0 / 29.0 + (double)(1f / Globals_Renamed.arParmValues[5]), 0.25) * Math.Pow(Globals_Renamed.arParmValues[69], 0.5) * (Math.Pow(Globals_Renamed.arParmValues[26], 2.0) * 3.14159265359 / 4.0) / (Math.Pow(Globals_Renamed.arParmValues[8], 0.05) * Math.Pow(Globals_Renamed.arParmValues[26], 0.5) * Math.Pow(Globals_Renamed.arParmValues[7], 0.5)));
					Globals_Renamed.arParmValid[50] = true;
					Globals_Renamed.arOutput[1] = Globals_Renamed.arParmValues[50] * 3600f * Globals_Renamed.arParmValues[31] / 1000f;
					Globals_Renamed.arOutput[3] = Globals_Renamed.arOutput[1] * Globals_Renamed.arOutput[2] * Globals_Renamed.arParmValues[1];
					if ((double)Globals_Renamed.arOutput[3] > Globals_Renamed.arOpPv[pOpID])
					{
						Interaction.MsgBox((object)strPVopcheck, (MsgBoxStyle)64, (object)strmodeltext);
					}
					flag = true;
					goto end_IL_0001;
				}
				case 811:
					num = -1;
					switch (num2)
					{
					case 2:
						if (Information.Err().Number != 0)
						{
							Cursor.Current = Cursors.Default;
							Interaction.MsgBox((object)("Error " + Conversions.ToString(Information.Err().Number) + " - " + Information.Err().Description), (MsgBoxStyle)64, (object)"Runtime Error");
						}
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 811;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private static bool RelMassTransfer(ref short pOpID, ref short pActID)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					if (Globals_Renamed.arParmValues[72] > 365f)
					{
						Interaction.MsgBox((object)strFreqcheck, (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[2] = Globals_Renamed.arParmValues[72];
					if (Globals_Renamed.arParmValues[69] <= 100f)
					{
						Interaction.MsgBox((object)"Note: This model is most appropriate for air speeds greater than 100 ft/min. For air speeds less than or equal to 100 ft/min, you should select and use the EPA/OPPT Penetration Model to estimate the vapor generation rate.", (MsgBoxStyle)64, (object)"Model Validity Error");
					}
					Globals_Renamed.arParmValues[28] = (float)(Math.Pow(Globals_Renamed.arParmValues[26], 2.0) * 3.14159265359 / 4.0);
					Globals_Renamed.arParmValid[28] = true;
					string text = "gcMW";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[5], ref strdivisionbyzerovars);
					text = "gcT";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[8], ref strdivisionbyzerovars);
					text = "gcdCB";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[26], ref strdivisionbyzerovars);
					if (Operators.CompareString(strdivisionbyzerovars, "", false) != 0)
					{
						Interaction.MsgBox((object)(strdivisionbyzero + strdivisionbyzerovars), (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arParmValues[50] = (float)(1.93E-07 * Math.Pow(Globals_Renamed.arParmValues[5], 0.78) * (double)Globals_Renamed.arParmValues[4] * (double)Globals_Renamed.arParmValues[40] * Math.Pow(1.0 / 29.0 + (double)(1f / Globals_Renamed.arParmValues[5]), 0.33) * Math.Pow(Globals_Renamed.arParmValues[69], 0.78) * (Math.Pow(Globals_Renamed.arParmValues[26], 2.0) * 3.14159265359 / 4.0) / (Math.Pow(Globals_Renamed.arParmValues[8], 0.4) * Math.Pow(Globals_Renamed.arParmValues[26], 0.11) * Math.Pow(Math.Pow(Globals_Renamed.arParmValues[8], 0.5) - 5.87, 2.0 / 3.0)));
					Globals_Renamed.arParmValid[50] = true;
					Globals_Renamed.arOutput[1] = Globals_Renamed.arParmValues[50] * 3600f * Globals_Renamed.arParmValues[31] / 1000f;
					Globals_Renamed.arOutput[3] = Globals_Renamed.arOutput[1] * Globals_Renamed.arOutput[2] * Globals_Renamed.arParmValues[1];
					if ((double)Globals_Renamed.arOutput[3] > Globals_Renamed.arOpPv[pOpID])
					{
						Interaction.MsgBox((object)strPVopcheck, (MsgBoxStyle)64, (object)strmodeltext);
					}
					flag = true;
					goto end_IL_0001;
				}
				case 808:
					num = -1;
					switch (num2)
					{
					case 2:
						if (Information.Err().Number != 0)
						{
							Cursor.Current = Cursors.Default;
							Interaction.MsgBox((object)("Error " + Conversions.ToString(Information.Err().Number) + " - " + Information.Err().Description), (MsgBoxStyle)64, (object)"Runtime Error");
						}
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 808;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private static bool RelResidual(ref short pOpID, ref short pActID)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					if (Globals_Renamed.arParmValues[72] > 365f)
					{
						Interaction.MsgBox((object)strFreqcheck, (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[2] = Globals_Renamed.arParmValues[72];
					Globals_Renamed.arOutput[1] = Globals_Renamed.arParmValues[92] * Globals_Renamed.arParmValues[117];
					Globals_Renamed.arOutput[3] = Globals_Renamed.arOutput[1] * Globals_Renamed.arOutput[2] * Globals_Renamed.arParmValues[1];
					if ((double)Globals_Renamed.arOutput[3] > Globals_Renamed.arOpPv[pOpID])
					{
						Interaction.MsgBox((object)strPVopcheck, (MsgBoxStyle)64, (object)strmodeltext);
					}
					flag = true;
					break;
				case 262:
					num = -1;
					switch (num2)
					{
					case 2:
						break;
					default:
						goto end_IL_0001_2;
					}
					break;
				}
				if (Information.Err().Number != 0)
				{
					Cursor.Current = Cursors.Default;
					Interaction.MsgBox((object)("Error " + Conversions.ToString(Information.Err().Number) + " - " + Information.Err().Description), (MsgBoxStyle)64, (object)"Runtime Error");
				}
				break;
				end_IL_0001_2:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 262;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private static bool RelResidualLFautos(ref short pOpID, ref short pActID)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					if (Globals_Renamed.arParmValues[72] > 365f)
					{
						Interaction.MsgBox((object)strFreqcheck, (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[2] = Globals_Renamed.arParmValues[72];
					Globals_Renamed.arOutput[1] = Globals_Renamed.arParmValues[92] * Globals_Renamed.arParmValues[74];
					Globals_Renamed.arOutput[3] = Globals_Renamed.arOutput[1] * Globals_Renamed.arOutput[2] * Globals_Renamed.arParmValues[1];
					if ((double)Globals_Renamed.arOutput[3] > Globals_Renamed.arOpPv[pOpID])
					{
						Interaction.MsgBox((object)strPVopcheck, (MsgBoxStyle)64, (object)strmodeltext);
					}
					flag = true;
					break;
				case 262:
					num = -1;
					switch (num2)
					{
					case 2:
						break;
					default:
						goto end_IL_0001_2;
					}
					break;
				}
				if (Information.Err().Number != 0)
				{
					Cursor.Current = Cursors.Default;
					Interaction.MsgBox((object)("Error " + Conversions.ToString(Information.Err().Number) + " - " + Information.Err().Description), (MsgBoxStyle)64, (object)"Runtime Error");
				}
				break;
				end_IL_0001_2:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 262;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private static bool RelResidualLFnoUD(ref short pOpID, ref short pActID)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					if (Globals_Renamed.arParmValues[72] > 365f)
					{
						Interaction.MsgBox((object)strFreqcheck, (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[2] = Globals_Renamed.arParmValues[72];
					Globals_Renamed.arOutput[1] = Globals_Renamed.arParmValues[92] * Globals_Renamed.arParmValues[73];
					Globals_Renamed.arOutput[3] = Globals_Renamed.arOutput[1] * Globals_Renamed.arOutput[2] * Globals_Renamed.arParmValues[1];
					if ((double)Globals_Renamed.arOutput[3] > Globals_Renamed.arOpPv[pOpID])
					{
						Interaction.MsgBox((object)strPVopcheck, (MsgBoxStyle)64, (object)strmodeltext);
					}
					flag = true;
					break;
				case 262:
					num = -1;
					switch (num2)
					{
					case 2:
						break;
					default:
						goto end_IL_0001_2;
					}
					break;
				}
				if (Information.Err().Number != 0)
				{
					Cursor.Current = Cursors.Default;
					Interaction.MsgBox((object)("Error " + Conversions.ToString(Information.Err().Number) + " - " + Information.Err().Description), (MsgBoxStyle)64, (object)"Runtime Error");
				}
				break;
				end_IL_0001_2:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 262;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private static bool RelDustModel(ref short pOpID, ref short pActID)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					if (Globals_Renamed.arParmValues[72] > 365f)
					{
						Interaction.MsgBox((object)strFreqcheck, (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[2] = Globals_Renamed.arParmValues[72];
					Globals_Renamed.arOutput[1] = Globals_Renamed.arParmValues[92] * Globals_Renamed.arParmValues[73];
					Globals_Renamed.arOutput[3] = Globals_Renamed.arOutput[1] * Globals_Renamed.arOutput[2] * Globals_Renamed.arParmValues[1];
					if ((double)Globals_Renamed.arOutput[3] > Globals_Renamed.arOpPv[pOpID])
					{
						Interaction.MsgBox((object)strPVopcheck, (MsgBoxStyle)64, (object)strmodeltext);
					}
					flag = true;
					break;
				case 262:
					num = -1;
					switch (num2)
					{
					case 2:
						break;
					default:
						goto end_IL_0001_2;
					}
					break;
				}
				if (Information.Err().Number != 0)
				{
					Cursor.Current = Cursors.Default;
					Interaction.MsgBox((object)("Error " + Conversions.ToString(Information.Err().Number) + " - " + Information.Err().Description), (MsgBoxStyle)64, (object)"Runtime Error");
				}
				break;
				end_IL_0001_2:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 262;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private static void division_by_zero(ref string strParm, ref float sngValue, ref string strdivisionbyzerovars)
	{
		switch (strParm)
		{
		case "gcMCchem":
			if (sngValue == 0f)
			{
				strdivisionbyzerovars = strdivisionbyzerovars + Globals_Renamed.arParmNames[30] + "\r\n";
			}
			break;
		case "gcrCB":
			if (sngValue == 0f)
			{
				strdivisionbyzerovars = strdivisionbyzerovars + Globals_Renamed.arParmNames[24] + "\r\n";
			}
			break;
		case "gcrRE":
			if (sngValue == 0f)
			{
				strdivisionbyzerovars = strdivisionbyzerovars + Globals_Renamed.arParmNames[23] + "\r\n";
			}
			break;
		case "gcdCB":
			if (sngValue == 0f)
			{
				strdivisionbyzerovars = strdivisionbyzerovars + Globals_Renamed.arParmNames[26] + "\r\n";
			}
			break;
		case "gcdRE":
			if (sngValue == 0f)
			{
				strdivisionbyzerovars = strdivisionbyzerovars + Globals_Renamed.arParmNames[25] + "\r\n";
			}
			break;
		case "gcT":
			if (sngValue == 0f)
			{
				strdivisionbyzerovars = strdivisionbyzerovars + Globals_Renamed.arParmNames[8] + "\r\n";
			}
			break;
		case "gcMW":
			if (sngValue == 0f)
			{
				strdivisionbyzerovars = strdivisionbyzerovars + Globals_Renamed.arParmNames[5] + "\r\n";
			}
			break;
		case "gcR":
			if (sngValue == 0f)
			{
				strdivisionbyzerovars = strdivisionbyzerovars + Globals_Renamed.arParmNames[6] + "\r\n";
			}
			break;
		case "gcP":
			if (sngValue == 0f)
			{
				strdivisionbyzerovars = strdivisionbyzerovars + Globals_Renamed.arParmNames[7] + "\r\n";
			}
			break;
		case "gcFreq":
			if (sngValue == 0f)
			{
				strdivisionbyzerovars = strdivisionbyzerovars + Globals_Renamed.arParmNames[72] + "\r\n";
			}
			break;
		case "gcNS":
			if (sngValue == 0f)
			{
				strdivisionbyzerovars = strdivisionbyzerovars + Globals_Renamed.arParmNames[1] + "\r\n";
			}
			break;
		case "gcDRcb":
			if (sngValue == 0f)
			{
				strdivisionbyzerovars = strdivisionbyzerovars + Globals_Renamed.arParmNames[71] + "\r\n";
			}
			break;
		case "gcDRre":
			if (sngValue == 0f)
			{
				strdivisionbyzerovars = strdivisionbyzerovars + Globals_Renamed.arParmNames[70] + "\r\n";
			}
			break;
		case "gcPC":
			if (sngValue == 0f)
			{
				strdivisionbyzerovars = strdivisionbyzerovars + Globals_Renamed.arParmNames[29] + "\r\n";
			}
			break;
		}
	}

	private static bool RelKnown(ref short pOpID, ref short pActID)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0001_dispatch)
					{
					default:
					{
						ProjectData.ClearProjectError();
						num2 = 2;
						string text = "NS";
						missing_required_parameter(ref text, ref Globals_Renamed.arParmValid[1], ref strmissingvars);
						if (Operators.CompareString(strmissingvars, "", false) != 0)
						{
							Interaction.MsgBox((object)(strmissingvarsintro + strmissingvars), (MsgBoxStyle)64, (object)strmodeltext);
							goto end_IL_0001;
						}
						if (!blnDR)
						{
							text = Conversions.ToString(Globals_Renamed.arParmValues[92]);
							missing_required_parameter(ref text, ref Globals_Renamed.arParmValid[(int)Math.Round(Globals_Renamed.arParmValues[92])], ref strmissingvars);
							if (Operators.CompareString(strmissingvars, "", false) != 0)
							{
								Interaction.MsgBox((object)(strmissingvarsintro + strmissingvars), (MsgBoxStyle)64, (object)strmodeltext);
								goto end_IL_0001;
							}
							Globals_Renamed.arOutput[1] = Globals_Renamed.arParmValues[(int)Math.Round(Globals_Renamed.arParmValues[92])];
						}
						if (!blnDRcb)
						{
							text = Conversions.ToString(Globals_Renamed.arParmValues[92]);
							missing_required_parameter(ref text, ref Globals_Renamed.arParmValid[(int)Math.Round(Globals_Renamed.arParmValues[92])], ref strmissingvars);
							if (Operators.CompareString(strmissingvars, "", false) != 0)
							{
								Interaction.MsgBox((object)(strmissingvarsintro + strmissingvars), (MsgBoxStyle)64, (object)strmodeltext);
								goto end_IL_0001;
							}
							Globals_Renamed.arOutput[1] = Globals_Renamed.arParmValues[(int)Math.Round(Globals_Renamed.arParmValues[92])];
						}
						if (!blnFreq)
						{
							if (!Globals_Renamed.arParmValid[(int)Math.Round(Globals_Renamed.arParmValues[72])])
							{
								text = Conversions.ToString(Globals_Renamed.arParmValues[72]);
								missing_required_parameter(ref text, ref Globals_Renamed.arParmValid[(int)Math.Round(Globals_Renamed.arParmValues[72])], ref strmissingvars);
								if (Operators.CompareString(strmissingvars, "", false) != 0)
								{
									Interaction.MsgBox((object)(strmissingvarsintro + strmissingvars), (MsgBoxStyle)64, (object)strmodeltext);
									goto end_IL_0001;
								}
							}
							else
							{
								Globals_Renamed.arOutput[2] = Globals_Renamed.arParmValues[(int)Math.Round(Globals_Renamed.arParmValues[72])];
							}
						}
						if (!blnAR)
						{
							Globals_Renamed.arOutput[3] = Globals_Renamed.arOutput[1] * Globals_Renamed.arOutput[2] * Globals_Renamed.arParmValues[1];
						}
						flag = true;
						break;
					}
					case 756:
						num = -1;
						switch (num2)
						{
						case 2:
							break;
						default:
							goto end_IL_0001_2;
						}
						break;
					}
					if (Information.Err().Number != 0)
					{
						Cursor.Current = Cursors.Default;
						Interaction.MsgBox((object)("Error " + Conversions.ToString(Information.Err().Number) + " - " + Information.Err().Description), (MsgBoxStyle)64, (object)"Runtime Error");
					}
					break;
				}
				end_IL_0001_2:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 756;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private static bool RelWaterSat(ref short pOpID, ref short pActID)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					if (Globals_Renamed.arParmValues[72] > 365f)
					{
						Interaction.MsgBox((object)strFreqcheck, (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[2] = Globals_Renamed.arParmValues[72];
					Globals_Renamed.arOutput[1] = Globals_Renamed.arParmValues[92] * Globals_Renamed.arParmValues[80] * Globals_Renamed.arParmValues[79] / 1000f;
					Globals_Renamed.arOutput[3] = Globals_Renamed.arOutput[1] * Globals_Renamed.arOutput[2] * Globals_Renamed.arParmValues[1];
					if ((double)Globals_Renamed.arOutput[3] > Globals_Renamed.arOpPv[pOpID])
					{
						Interaction.MsgBox((object)strPVopcheck, (MsgBoxStyle)64, (object)strmodeltext);
					}
					flag = true;
					break;
				case 277:
					num = -1;
					switch (num2)
					{
					case 2:
						break;
					default:
						goto end_IL_0001_2;
					}
					break;
				}
				if (Information.Err().Number != 0)
				{
					Cursor.Current = Cursors.Default;
					Interaction.MsgBox((object)("Error " + Conversions.ToString(Information.Err().Number) + " - " + Information.Err().Description), (MsgBoxStyle)64, (object)"Runtime Error");
				}
				break;
				end_IL_0001_2:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 277;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private static bool RelSpentBath(ref short pOpID, ref short pActID)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					if (Globals_Renamed.arParmValues[137] > 365f)
					{
						Interaction.MsgBox((object)strFreqcheck, (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[2] = Globals_Renamed.arParmValues[137];
					Globals_Renamed.arOutput[1] = (float)((double)Globals_Renamed.arParmValues[141] * 3.78 * (double)Globals_Renamed.arParmValues[131] * (double)Globals_Renamed.arParmValues[133]);
					Globals_Renamed.arOutput[3] = Globals_Renamed.arOutput[1] * Globals_Renamed.arOutput[2] * Globals_Renamed.arParmValues[1];
					if ((double)Globals_Renamed.arOutput[3] > Globals_Renamed.arOpPv[pOpID])
					{
						Interaction.MsgBox((object)strPVopcheck, (MsgBoxStyle)64, (object)strmodeltext);
					}
					flag = true;
					break;
				case 300:
					num = -1;
					switch (num2)
					{
					case 2:
						break;
					default:
						goto end_IL_0001_2;
					}
					break;
				}
				if (Information.Err().Number != 0)
				{
					Cursor.Current = Cursors.Default;
					Interaction.MsgBox((object)("Error " + Conversions.ToString(Information.Err().Number) + " - " + Information.Err().Description), (MsgBoxStyle)64, (object)"Runtime Error");
				}
				break;
				end_IL_0001_2:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 300;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private static bool RelUserG(ref short pOpID, ref short pActID)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					if (Globals_Renamed.arParmValues[72] > 365f)
					{
						Interaction.MsgBox((object)strFreqcheck, (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[2] = Globals_Renamed.arParmValues[72];
					Globals_Renamed.arOutput[1] = Globals_Renamed.arParmValues[49] * 3600f * Globals_Renamed.arParmValues[31] / 1000f;
					Globals_Renamed.arOutput[3] = Globals_Renamed.arOutput[1] * Globals_Renamed.arOutput[2] * Globals_Renamed.arParmValues[1];
					Globals_Renamed.arParmValues[50] = Globals_Renamed.arParmValues[49];
					Globals_Renamed.arParmValid[50] = true;
					if ((double)Globals_Renamed.arOutput[3] > Globals_Renamed.arOpPv[pOpID])
					{
						Interaction.MsgBox((object)strPVopcheck, (MsgBoxStyle)64, (object)strmodeltext);
					}
					flag = true;
					goto end_IL_0001;
				case 305:
					num = -1;
					switch (num2)
					{
					case 2:
						if (Information.Err().Number != 0)
						{
							Cursor.Current = Cursors.Default;
							Interaction.MsgBox((object)("Error " + Conversions.ToString(Information.Err().Number) + " - " + Information.Err().Description), (MsgBoxStyle)64, (object)"Runtime Error");
						}
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 305;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}
}
