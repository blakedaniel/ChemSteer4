using System;
using System.Windows.Forms;
using ADODB;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ChemSteer;

[StandardModule]
internal sealed class ExpModels
{
	private static string strParm;

	private static string strmissingvars;

	private static string strmissingvarsintro;

	private static bool blnparm;

	private static string strdivisionbyzerovars;

	private static string strdivisionbyzero;

	private static string strmodeltext;

	private static string strmodeltext1;

	private static string strmodeltext2;

	private static bool blnICB;

	private static bool blnIRE;

	private static bool blnILADDCB;

	private static bool blnILADDRE;

	private static bool blnIADDCB;

	private static bool blnIADDRE;

	private static bool blnIAPDRCB;

	private static bool blnIAPDRRE;

	private static bool blnDLADDCB;

	private static bool blnDLADDRE;

	private static bool blnDADDCB;

	private static bool blnDADDRE;

	private static bool blnDAPDRCB;

	private static bool blnDAPDRRE;

	private static bool blnDexpCB;

	private static bool blnDexpRE;

	private static double dblmi;

	private static double dblmiOne;

	private static double dblmiTwo;

	private static double dblk1;

	private static double dblk2;

	private static double dblk3;

	private static double dblk4;

	private static double dblk5;

	private static double dbllambda1;

	private static double dbllambda2;

	private static double dblY;

	private static double dblZ;

	public static bool RunExposureModels(ref short pOpID, ref short pActID, ref short pmodId, ref short pDualID)
	{
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		recordset.CursorLocation = CursorLocationEnum.adUseClient;
		recordset.Open("SELECT ModelName FROM ListOfModels WHERE ModelID=" + Conversions.ToString((int)pmodId), Common.MyConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
		strmodeltext1 = Conversions.ToString(recordset.Fields[0].Value);
		recordset.Close();
		clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset2 = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		recordset2.CursorLocation = CursorLocationEnum.adUseClient;
		recordset2.Open("SELECT ActName FROM ListOfActivities WHERE ActID=" + Conversions.ToString((int)pActID), Common.MyConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
		strmodeltext2 = Conversions.ToString(recordset2.Fields[0].Value);
		recordset2.Close();
		strmodeltext = strmodeltext1 + " (" + strmodeltext2 + ")";
		strmissingvars = "";
		strmissingvarsintro = "In order for ChemSTEER to use the " + strmodeltext + " to calculate exposures, you need to specify the following variable(s) on the View/Update Model Information Button on the Exposures Tab:\r\n\r\n";
		strdivisionbyzerovars = "";
		strdivisionbyzero = "In order for ChemSTEER to use the " + strmodeltext + " to calculate exposures, you need to supply non-zero values for the following variable(s) on the View/Update Model Information Button on the Exposures Tab:\r\n\r\n";
		Cursor.Current = Cursors.WaitCursor;
		bool flag = default(bool);
		switch (pmodId)
		{
		case 21:
			flag = ExpSmallVolumeHandling(ref pOpID, ref pActID);
			break;
		case 22:
			flag = ExpMassBalance(ref pOpID, ref pActID);
			break;
		case 23:
			flag = ExpOSHAPELpart(ref pOpID, ref pActID);
			break;
		case 45:
			flag = ExpOSHAPELvapor(ref pOpID, ref pActID);
			break;
		case 24:
		case 47:
			flag = ExpOSHAPELLimiting(ref pOpID, ref pActID);
			break;
		case 25:
		case 26:
		case 27:
		case 28:
		case 29:
			flag = ExpDerLiquidModel(ref pOpID, ref pActID, ref pmodId);
			break;
		case 44:
			flag = ExpUserDerLiquidModel(ref pOpID, ref pActID, ref pmodId);
			break;
		case 18:
			flag = ExpRollCoating(ref pOpID, ref pActID);
			break;
		case 46:
			flag = ExpUserInhalation(ref pOpID, ref pActID);
			break;
		case 49:
		case 50:
			flag = ExpAuto(ref pOpID, ref pActID);
			break;
		case 40:
			flag = ExpAutoPoly(ref pOpID, ref pActID);
			break;
		case 54:
			flag = ExpNearFarField(ref pOpID, ref pActID, ref pDualID);
			break;
		}
		Cursor.Current = Cursors.Default;
		bool result = flag;
		recordset = null;
		recordset2 = null;
		return result;
	}

	private static bool ExpSmallVolumeHandling(ref short pOpID, ref short pActID)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
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
					if (Globals_Renamed.arParmValues[61] > 54f)
					{
						Interaction.MsgBox((object)"Please select an option for which AH <= 54 kg/site/day", (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[4] = Globals_Renamed.arParmValues[81] * Globals_Renamed.arParmValues[61] * Globals_Renamed.arParmValues[78] * Globals_Renamed.arParmValues[82];
					string text = "gcBW";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[42], ref strdivisionbyzerovars);
					text = "gcATc";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[48], ref strdivisionbyzerovars);
					if (Operators.CompareString(strdivisionbyzerovars, "", false) != 0)
					{
						Interaction.MsgBox((object)(strdivisionbyzero + strdivisionbyzerovars), (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[5] = Globals_Renamed.arOutput[4] * Globals_Renamed.arParmValues[75] * Globals_Renamed.arParmValues[41] / (Globals_Renamed.arParmValues[42] * Globals_Renamed.arParmValues[48] * 365f);
					text = "gcBW";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[42], ref strdivisionbyzerovars);
					text = "gcAT";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[47], ref strdivisionbyzerovars);
					if (Operators.CompareString(strdivisionbyzerovars, "", false) != 0)
					{
						Interaction.MsgBox((object)(strdivisionbyzero + strdivisionbyzerovars), (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[6] = Globals_Renamed.arOutput[4] * Globals_Renamed.arParmValues[75] * Globals_Renamed.arParmValues[41] / (Globals_Renamed.arParmValues[42] * Globals_Renamed.arParmValues[47] * 365f);
					text = "gcBW";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[42], ref strdivisionbyzerovars);
					if (Operators.CompareString(strdivisionbyzerovars, "", false) != 0)
					{
						Interaction.MsgBox((object)(strdivisionbyzero + strdivisionbyzerovars), (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[7] = Globals_Renamed.arOutput[4] / Globals_Renamed.arParmValues[42];
					flag = true;
					goto end_IL_0001;
				}
				case 674:
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
				try0001_dispatch = 674;
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

	private static bool ExpOSHAPELLimiting(ref short pOpID, ref short pActID)
	{
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
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
					Globals_Renamed.arParmValues[65] = Globals_Renamed.arParmValues[70] * Globals_Renamed.arParmValues[78];
					Globals_Renamed.arParmValid[65] = true;
					Globals_Renamed.arOutput[4] = Globals_Renamed.arParmValues[65] * Globals_Renamed.arParmValues[44] * Globals_Renamed.arParmValues[71];
					string text = "gcBW";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[42], ref strdivisionbyzerovars);
					text = "gcATc";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[48], ref strdivisionbyzerovars);
					if (Operators.CompareString(strdivisionbyzerovars, "", false) != 0)
					{
						Interaction.MsgBox((object)(strdivisionbyzero + strdivisionbyzerovars), (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[5] = Globals_Renamed.arOutput[4] * Globals_Renamed.arParmValues[75] * Globals_Renamed.arParmValues[41] / (Globals_Renamed.arParmValues[42] * Globals_Renamed.arParmValues[48] * 365f);
					text = "gcBW";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[42], ref strdivisionbyzerovars);
					text = "gcAT";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[47], ref strdivisionbyzerovars);
					if (Operators.CompareString(strdivisionbyzerovars, "", false) != 0)
					{
						Interaction.MsgBox((object)(strdivisionbyzero + strdivisionbyzerovars), (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[6] = Globals_Renamed.arOutput[4] * Globals_Renamed.arParmValues[75] * Globals_Renamed.arParmValues[41] / (Globals_Renamed.arParmValues[42] * Globals_Renamed.arParmValues[47] * 365f);
					text = "gcBW";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[42], ref strdivisionbyzerovars);
					if (Operators.CompareString(strdivisionbyzerovars, "", false) != 0)
					{
						Interaction.MsgBox((object)(strdivisionbyzero + strdivisionbyzerovars), (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[7] = Globals_Renamed.arOutput[4] / Globals_Renamed.arParmValues[42];
					flag = true;
					goto end_IL_0001;
				}
				case 653:
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
				try0001_dispatch = 653;
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

	private static bool ExpMassBalance(ref short pOpID, ref short pActID)
	{
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_050c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
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
					string text;
					if (Globals_Renamed.arParmValues[50] == 0f)
					{
						text = "G";
						missing_required_parameter(ref text, ref Globals_Renamed.arParmValid[50], ref strmissingvars);
						if (Operators.CompareString(strmissingvars, "", false) != 0)
						{
							Interaction.MsgBox((object)(strmissingvarsintro + strmissingvars), (MsgBoxStyle)64, (object)strmodeltext);
							goto end_IL_0001;
						}
					}
					text = "gcMW";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[5], ref strdivisionbyzerovars);
					text = "gcQcb";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[53], ref strdivisionbyzerovars);
					text = "gckcb";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[51], ref strdivisionbyzerovars);
					if (Operators.CompareString(strdivisionbyzerovars, "", false) != 0)
					{
						Interaction.MsgBox((object)(strdivisionbyzero + strdivisionbyzerovars), (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					dblmiOne = 170000f * Globals_Renamed.arParmValues[8] * Globals_Renamed.arParmValues[50] / (Globals_Renamed.arParmValues[5] * Globals_Renamed.arParmValues[53] * Globals_Renamed.arParmValues[51]);
					dblmiTwo = 1000000f * Globals_Renamed.arParmValues[40] * Globals_Renamed.arParmValues[4] / 760f;
					dblmi = dblmiOne;
					if (dblmiTwo < dblmi)
					{
						dblmi = dblmiTwo;
					}
					Globals_Renamed.arParmValues[66] = (float)dblmi;
					Globals_Renamed.arParmValid[66] = true;
					text = "gcVm";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[63], ref strdivisionbyzerovars);
					if (Operators.CompareString(strdivisionbyzerovars, "", false) != 0)
					{
						Interaction.MsgBox((object)(strdivisionbyzero + strdivisionbyzerovars), (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arParmValues[65] = Globals_Renamed.arParmValues[66] * Globals_Renamed.arParmValues[5] / Globals_Renamed.arParmValues[63];
					Globals_Renamed.arParmValid[65] = true;
					text = "hCB";
					missing_required_parameter(ref text, ref Globals_Renamed.arParmValid[46], ref strmissingvars);
					text = "b";
					missing_required_parameter(ref text, ref Globals_Renamed.arParmValid[44], ref strmissingvars);
					if (Operators.CompareString(strmissingvars, "", false) != 0)
					{
						Interaction.MsgBox((object)(strmissingvarsintro + strmissingvars), (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[4] = Globals_Renamed.arParmValues[65] * Globals_Renamed.arParmValues[44] * Globals_Renamed.arParmValues[46];
					text = "gcBW";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[42], ref strdivisionbyzerovars);
					text = "gcATc";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[48], ref strdivisionbyzerovars);
					if (Operators.CompareString(strdivisionbyzerovars, "", false) != 0)
					{
						Interaction.MsgBox((object)(strdivisionbyzero + strdivisionbyzerovars), (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[5] = Globals_Renamed.arOutput[4] * Globals_Renamed.arParmValues[75] * Globals_Renamed.arParmValues[41] / (Globals_Renamed.arParmValues[42] * Globals_Renamed.arParmValues[48] * 365f);
					text = "gcBW";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[42], ref strdivisionbyzerovars);
					text = "gcAT";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[47], ref strdivisionbyzerovars);
					if (Operators.CompareString(strdivisionbyzerovars, "", false) != 0)
					{
						Interaction.MsgBox((object)(strdivisionbyzero + strdivisionbyzerovars), (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[6] = Globals_Renamed.arOutput[4] * Globals_Renamed.arParmValues[75] * Globals_Renamed.arParmValues[41] / (Globals_Renamed.arParmValues[42] * Globals_Renamed.arParmValues[47] * 365f);
					text = "gcBW";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[42], ref strdivisionbyzerovars);
					if (Operators.CompareString(strdivisionbyzerovars, "", false) != 0)
					{
						Interaction.MsgBox((object)(strdivisionbyzero + strdivisionbyzerovars), (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[7] = Globals_Renamed.arOutput[4] / Globals_Renamed.arParmValues[42];
					flag = true;
					goto end_IL_0001;
				}
				case 1301:
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
				try0001_dispatch = 1301;
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

	private static bool ExpNearFarField(ref short pOpID, ref short pActID, ref short pDualID)
	{
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_090e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0745: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0890: Unknown result type (might be due to invalid IL or missing references)
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
					string text;
					if (Globals_Renamed.arParmValues[50] == 0f)
					{
						text = "G";
						missing_required_parameter(ref text, ref Globals_Renamed.arParmValid[50], ref strmissingvars);
						if (Operators.CompareString(strmissingvars, "", false) != 0)
						{
							Interaction.MsgBox((object)(strmissingvarsintro + strmissingvars), (MsgBoxStyle)64, (object)strmodeltext);
							goto end_IL_0001;
						}
					}
					text = "Aer";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[146], ref strdivisionbyzerovars);
					if (Operators.CompareString(strdivisionbyzerovars, "", false) != 0)
					{
						Interaction.MsgBox((object)(strdivisionbyzero + strdivisionbyzerovars), (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					text = "Vff";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[145], ref strdivisionbyzerovars);
					if (Operators.CompareString(strdivisionbyzerovars, "", false) != 0)
					{
						Interaction.MsgBox((object)(strdivisionbyzero + strdivisionbyzerovars), (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[13] = Globals_Renamed.arParmValues[148] * Globals_Renamed.arParmValues[149] * Globals_Renamed.arParmValues[150];
					Globals_Renamed.arOutput[14] = 2f * (Globals_Renamed.arParmValues[148] * Globals_Renamed.arParmValues[150]) + 2f * (Globals_Renamed.arParmValues[149] * Globals_Renamed.arParmValues[150]) + Globals_Renamed.arParmValues[148] * Globals_Renamed.arParmValues[149];
					Globals_Renamed.arOutput[15] = (float)(0.5 * (double)Globals_Renamed.arOutput[14] * (double)Globals_Renamed.arParmValues[147]);
					Globals_Renamed.arOutput[16] = Globals_Renamed.arParmValues[145] * Globals_Renamed.arParmValues[146];
					dblY = (Globals_Renamed.arOutput[15] * Globals_Renamed.arParmValues[145] + Globals_Renamed.arOutput[13] * (Globals_Renamed.arOutput[15] + Globals_Renamed.arOutput[16])) / (Globals_Renamed.arOutput[13] * Globals_Renamed.arParmValues[145]);
					dblZ = 4f * Globals_Renamed.arOutput[15] * Globals_Renamed.arOutput[16] / Globals_Renamed.arOutput[13] / Globals_Renamed.arParmValues[145];
					dbllambda1 = 0.5 * (0.0 - dblY + Math.Pow(Math.Pow(dblY, 2.0) - dblZ, 0.5));
					dbllambda2 = 0.5 * (0.0 - dblY - Math.Pow(Math.Pow(dblY, 2.0) - dblZ, 0.5));
					dblk1 = 1f / (Globals_Renamed.arOutput[15] / (Globals_Renamed.arOutput[15] + Globals_Renamed.arOutput[16]) * Globals_Renamed.arOutput[16]);
					dblk2 = ((double)(Globals_Renamed.arOutput[15] * Globals_Renamed.arOutput[16]) + dbllambda2 * (double)Globals_Renamed.arOutput[13] * (double)(Globals_Renamed.arOutput[15] + Globals_Renamed.arOutput[16])) / ((double)(Globals_Renamed.arOutput[15] * Globals_Renamed.arOutput[16] * Globals_Renamed.arOutput[13]) * (dbllambda1 - dbllambda2));
					dblk3 = ((double)(Globals_Renamed.arOutput[15] * Globals_Renamed.arOutput[16]) + dbllambda1 * (double)Globals_Renamed.arOutput[13] * (double)(Globals_Renamed.arOutput[15] + Globals_Renamed.arOutput[16])) / ((double)(Globals_Renamed.arOutput[15] * Globals_Renamed.arOutput[16] * Globals_Renamed.arOutput[13]) * (dbllambda1 - dbllambda2));
					dblk4 = (dbllambda1 * (double)Globals_Renamed.arOutput[13] + (double)Globals_Renamed.arOutput[15]) / (double)Globals_Renamed.arOutput[15] * dblk2;
					dblk5 = (dbllambda2 * (double)Globals_Renamed.arOutput[13] + (double)Globals_Renamed.arOutput[15]) / (double)Globals_Renamed.arOutput[15] * dblk3;
					Globals_Renamed.arParmValues[153] = (float)(((double)(Globals_Renamed.arParmValues[50] * 3600000f) * (dblk1 * (double)Globals_Renamed.arParmValues[46] + dblk2 * Math.Exp(dbllambda1 * (double)Globals_Renamed.arParmValues[46]) / dbllambda1 - dblk3 * Math.Exp(dbllambda2 * (double)Globals_Renamed.arParmValues[46]) / dbllambda2) - ((double)(Globals_Renamed.arParmValues[50] * 3600000f) * dblk2 / dbllambda1 - dblk3 / dbllambda2)) / (double)Globals_Renamed.arParmValues[46]);
					Globals_Renamed.arParmValues[154] = (float)(((double)(Globals_Renamed.arParmValues[50] * 3600000f) * ((double)(Globals_Renamed.arParmValues[46] / Globals_Renamed.arOutput[16]) + dblk4 * Math.Exp(dbllambda1 * (double)Globals_Renamed.arParmValues[46]) / dbllambda1 - dblk5 * Math.Exp(dbllambda2 * (double)Globals_Renamed.arParmValues[46]) / dbllambda2) - ((double)(Globals_Renamed.arParmValues[50] * 3600000f) * dblk4 / dbllambda1 - dblk5 / dbllambda2)) / (double)Globals_Renamed.arParmValues[46]);
					Globals_Renamed.arParmValid[153] = true;
					Globals_Renamed.arParmValid[154] = true;
					if ((Globals_Renamed.arParmValues[54] == 153f) | (Globals_Renamed.arParmValues[54] == 154f))
					{
						Globals_Renamed.arParmValues[64] = Globals_Renamed.arParmValues[checked((int)Math.Round(Globals_Renamed.arParmValues[54]))];
					}
					else if (pDualID == 0)
					{
						Globals_Renamed.arParmValues[64] = Globals_Renamed.arParmValues[153];
					}
					else
					{
						Globals_Renamed.arParmValues[64] = Globals_Renamed.arParmValues[154];
					}
					Globals_Renamed.arParmValid[64] = true;
					Globals_Renamed.arParmValidSave[64] = false;
					text = "hCB";
					missing_required_parameter(ref text, ref Globals_Renamed.arParmValid[46], ref strmissingvars);
					text = "b";
					missing_required_parameter(ref text, ref Globals_Renamed.arParmValid[44], ref strmissingvars);
					if (Operators.CompareString(strmissingvars, "", false) != 0)
					{
						Interaction.MsgBox((object)(strmissingvarsintro + strmissingvars), (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[4] = Globals_Renamed.arParmValues[64] * Globals_Renamed.arParmValues[44] * Globals_Renamed.arParmValues[46];
					text = "gcBW";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[42], ref strdivisionbyzerovars);
					text = "gcAT";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[47], ref strdivisionbyzerovars);
					if (Operators.CompareString(strdivisionbyzerovars, "", false) != 0)
					{
						Interaction.MsgBox((object)(strdivisionbyzero + strdivisionbyzerovars), (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[5] = Globals_Renamed.arOutput[4] * Globals_Renamed.arParmValues[75] * Globals_Renamed.arParmValues[41] / (Globals_Renamed.arParmValues[42] * Globals_Renamed.arParmValues[48] * 365f);
					text = "gcBW";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[42], ref strdivisionbyzerovars);
					text = "gcAT";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[47], ref strdivisionbyzerovars);
					if (Operators.CompareString(strdivisionbyzerovars, "", false) != 0)
					{
						Interaction.MsgBox((object)(strdivisionbyzero + strdivisionbyzerovars), (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[6] = Globals_Renamed.arOutput[4] * Globals_Renamed.arParmValues[75] * Globals_Renamed.arParmValues[41] / (Globals_Renamed.arParmValues[42] * Globals_Renamed.arParmValues[47] * 365f);
					text = "gcBW";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[42], ref strdivisionbyzerovars);
					if (Operators.CompareString(strdivisionbyzerovars, "", false) != 0)
					{
						Interaction.MsgBox((object)(strdivisionbyzero + strdivisionbyzerovars), (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[7] = Globals_Renamed.arOutput[4] / Globals_Renamed.arParmValues[42];
					flag = true;
					goto end_IL_0001;
				}
				case 2327:
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
				try0001_dispatch = 2327;
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

	private static bool ExpDerLiquidModel(ref short pOpID, ref short pActID, ref short pmodId)
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
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
					if ((pmodId != 28) & (pmodId != 29))
					{
						Globals_Renamed.arParmValues[58] = Globals_Renamed.arParmValues[36] * Globals_Renamed.arParmValues[37];
					}
					Globals_Renamed.arOutput[8] = Globals_Renamed.arParmValues[58] * Globals_Renamed.arParmValues[77] * Globals_Renamed.arParmValues[60];
					string text = "gcBW";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[42], ref strdivisionbyzerovars);
					text = "gcATc";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[48], ref strdivisionbyzerovars);
					if (Operators.CompareString(strdivisionbyzerovars, "", false) != 0)
					{
						Interaction.MsgBox((object)(strdivisionbyzero + strdivisionbyzerovars), (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[9] = Globals_Renamed.arOutput[8] * Globals_Renamed.arParmValues[75] * Globals_Renamed.arParmValues[41] / (Globals_Renamed.arParmValues[42] * Globals_Renamed.arParmValues[48] * 365f);
					text = "gcBW";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[42], ref strdivisionbyzerovars);
					text = "gcATc";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[47], ref strdivisionbyzerovars);
					if (Operators.CompareString(strdivisionbyzerovars, "", false) != 0)
					{
						Interaction.MsgBox((object)(strdivisionbyzero + strdivisionbyzerovars), (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[10] = Globals_Renamed.arOutput[8] * Globals_Renamed.arParmValues[75] * Globals_Renamed.arParmValues[41] / (Globals_Renamed.arParmValues[42] * Globals_Renamed.arParmValues[47] * 365f);
					text = "gcBW";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[42], ref strdivisionbyzerovars);
					if (Operators.CompareString(strdivisionbyzerovars, "", false) != 0)
					{
						Interaction.MsgBox((object)(strdivisionbyzero + strdivisionbyzerovars), (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[11] = Globals_Renamed.arOutput[8] / Globals_Renamed.arParmValues[42];
					flag = true;
					goto end_IL_0001;
				}
				case 673:
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
				try0001_dispatch = 673;
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

	private static bool ExpUserDerLiquidModel(ref short pOpID, ref short pActID, ref short pmodId)
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
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
					Globals_Renamed.arParmValues[58] = Globals_Renamed.arParmValues[55] * Globals_Renamed.arParmValues[56];
					Globals_Renamed.arOutput[8] = Globals_Renamed.arParmValues[58] * Globals_Renamed.arParmValues[77] * Globals_Renamed.arParmValues[60];
					string text = "gcBW";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[42], ref strdivisionbyzerovars);
					text = "gcATc";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[48], ref strdivisionbyzerovars);
					if (Operators.CompareString(strdivisionbyzerovars, "", false) != 0)
					{
						Interaction.MsgBox((object)(strdivisionbyzero + strdivisionbyzerovars), (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[9] = Globals_Renamed.arOutput[8] * Globals_Renamed.arParmValues[75] * Globals_Renamed.arParmValues[41] / (Globals_Renamed.arParmValues[42] * Globals_Renamed.arParmValues[48] * 365f);
					text = "gcBW";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[42], ref strdivisionbyzerovars);
					text = "gcATc";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[47], ref strdivisionbyzerovars);
					if (Operators.CompareString(strdivisionbyzerovars, "", false) != 0)
					{
						Interaction.MsgBox((object)(strdivisionbyzero + strdivisionbyzerovars), (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[10] = Globals_Renamed.arOutput[8] * Globals_Renamed.arParmValues[75] * Globals_Renamed.arParmValues[41] / (Globals_Renamed.arParmValues[42] * Globals_Renamed.arParmValues[47] * 365f);
					text = "gcBW";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[42], ref strdivisionbyzerovars);
					if (Operators.CompareString(strdivisionbyzerovars, "", false) != 0)
					{
						Interaction.MsgBox((object)(strdivisionbyzero + strdivisionbyzerovars), (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[11] = Globals_Renamed.arOutput[8] / Globals_Renamed.arParmValues[42];
					flag = true;
					goto end_IL_0001;
				}
				case 647:
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
				try0001_dispatch = 647;
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
		switch (strParm)
		{
		case "VFF":
			if (!blnparm)
			{
				strmissingvars = strmissingvars + Globals_Renamed.arParmNames[43] + "\r\n";
			}
			break;
		case "Wf":
			if (!blnparm)
			{
				strmissingvars = strmissingvars + Globals_Renamed.arParmNames[43] + "\r\n";
			}
			break;
		case "ED":
			if (!blnparm)
			{
				strmissingvars = strmissingvars + Globals_Renamed.arParmNames[40] + "\r\n";
			}
			break;
		case "Ck":
			if (!blnparm)
			{
				strmissingvars = strmissingvars + Globals_Renamed.arParmNames[62] + "\r\n";
			}
			break;
		case "b":
			if (!blnparm)
			{
				strmissingvars = strmissingvars + Globals_Renamed.arParmNames[44] + "\r\n";
			}
			break;
		case "hCB":
			if (!blnparm)
			{
				strmissingvars = strmissingvars + Globals_Renamed.arParmNames[46] + "\r\n";
			}
			break;
		case "hRE":
			if (!blnparm)
			{
				strmissingvars = strmissingvars + Globals_Renamed.arParmNames[50] + "\r\n";
			}
			break;
		case "S":
			if (!blnparm)
			{
				strmissingvars = strmissingvars + Globals_Renamed.arParmNames[55] + "\r\n";
			}
			break;
		case "QuCB":
			if (!blnparm)
			{
				strmissingvars = strmissingvars + Globals_Renamed.arParmNames[56] + "\r\n";
			}
			break;
		case "QuRE":
			if (!blnparm)
			{
				strmissingvars = strmissingvars + Globals_Renamed.arParmNames[57] + "\r\n";
			}
			break;
		case "MW":
			if (!blnparm)
			{
				strmissingvars = strmissingvars + Globals_Renamed.arParmNames[5] + "\r\n";
			}
			break;
		case "T":
			if (!blnparm)
			{
				strmissingvars = strmissingvars + Globals_Renamed.arParmNames[8] + "\r\n";
			}
			break;
		case "G":
			if (!blnparm)
			{
				strmissingvars += "Vapor Generation Rate: user can input G on the Releases Tab by selecting the User-defined Vapor Generation Rate Model or can calculate G on the Releases Tab by selecting the EPA/OPPT Mass Transfer Model, EPA/OPPT Penetration Model, or the EPA/OAQPS AP-42 Loading Model\r\n";
			}
			break;
		case "Qcb":
			if (!blnparm)
			{
				strmissingvars = strmissingvars + Globals_Renamed.arParmNames[53] + "\r\n";
			}
			break;
		case "Qre":
			if (!blnparm)
			{
				strmissingvars = strmissingvars + Globals_Renamed.arParmNames[54] + "\r\n";
			}
			break;
		case "Y":
			if (!blnparm)
			{
				strmissingvars = strmissingvars + Globals_Renamed.arParmNames[41] + "\r\n";
			}
			break;
		case "BW":
			if (!blnparm)
			{
				strmissingvars = strmissingvars + Globals_Renamed.arParmNames[42] + "\r\n";
			}
			break;
		case "AT":
			if (!blnparm)
			{
				strmissingvars = strmissingvars + Globals_Renamed.arParmNames[47] + "\r\n";
			}
			break;
		case "ATc":
			if (!blnparm)
			{
				strmissingvars = strmissingvars + Globals_Renamed.arParmNames[48] + "\r\n";
			}
			break;
		case "FT":
			if (!blnparm)
			{
				strmissingvars = strmissingvars + Globals_Renamed.arParmNames[60] + "\r\n";
			}
			break;
		}
	}

	private static void division_by_zero(ref string strParm, ref float sngValue, ref string strdivisionbyzerovars)
	{
		string text = strParm;
		if (Operators.CompareString(text, "gcYpel", false) == 0)
		{
			if (sngValue == 0f)
			{
				strdivisionbyzerovars = strdivisionbyzerovars + Globals_Renamed.arParmNames[96] + "\r\n";
			}
			return;
		}
		if (Operators.CompareString(text, "gcVPpel", false) == 0)
		{
			if (sngValue == 0f)
			{
				strdivisionbyzerovars = strdivisionbyzerovars + Globals_Renamed.arParmNames[95] + "\r\n";
			}
			return;
		}
		if (Operators.CompareString(text, "gcMW", false) == 0)
		{
			if (sngValue == 0f)
			{
				strdivisionbyzerovars = strdivisionbyzerovars + Globals_Renamed.arParmNames[5] + "\r\n";
			}
			return;
		}
		switch (text)
		{
		case "gcMWpel":
			if (sngValue == 0f)
			{
				strdivisionbyzerovars = strdivisionbyzerovars + Globals_Renamed.arParmNames[97] + "\r\n";
			}
			break;
		case "gcBW":
			if (sngValue == 0f)
			{
				strdivisionbyzerovars = strdivisionbyzerovars + Globals_Renamed.arParmNames[42] + "\r\n";
			}
			break;
		case "gcATc":
			if (sngValue == 0f)
			{
				strdivisionbyzerovars = strdivisionbyzerovars + Globals_Renamed.arParmNames[48] + "\r\n";
			}
			break;
		case "gcAT":
			if (sngValue == 0f)
			{
				strdivisionbyzerovars = strdivisionbyzerovars + Globals_Renamed.arParmNames[47] + "\r\n";
			}
			break;
		case "gcMW":
			if (sngValue == 0f)
			{
				strdivisionbyzerovars = strdivisionbyzerovars + Globals_Renamed.arParmNames[5] + "\r\n";
			}
			break;
		case "Qcb":
			if (sngValue == 0f)
			{
				strdivisionbyzerovars = strdivisionbyzerovars + Globals_Renamed.arParmNames[53] + "\r\n";
			}
			break;
		case "Qre":
			if (sngValue == 0f)
			{
				strdivisionbyzerovars = strdivisionbyzerovars + Globals_Renamed.arParmNames[54] + "\r\n";
			}
			break;
		case "kCB":
			if (sngValue == 0f)
			{
				strdivisionbyzerovars = strdivisionbyzerovars + Globals_Renamed.arParmNames[51] + "\r\n";
			}
			break;
		case "kRE":
			if (sngValue == 0f)
			{
				strdivisionbyzerovars = strdivisionbyzerovars + Globals_Renamed.arParmNames[52] + "\r\n";
			}
			break;
		case "Vm":
			if (sngValue == 0f)
			{
				strdivisionbyzerovars = strdivisionbyzerovars + Globals_Renamed.arParmNames[63] + "\r\n";
			}
			break;
		case "Vff":
			if (sngValue == 0f)
			{
				strdivisionbyzerovars = strdivisionbyzerovars + Globals_Renamed.arParmNames[145] + "\r\n";
			}
			break;
		case "Aer":
			if (sngValue == 0f)
			{
				strdivisionbyzerovars = strdivisionbyzerovars + Globals_Renamed.arParmNames[146] + "\r\n";
			}
			break;
		}
	}

	private static bool ExpRollCoating(ref short pOpID, ref short pActID)
	{
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
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
					Globals_Renamed.arParmValues[65] = Globals_Renamed.arParmValues[57] * Globals_Renamed.arParmValues[113];
					Globals_Renamed.arParmValid[65] = true;
					Globals_Renamed.arOutput[4] = Globals_Renamed.arParmValues[65] * Globals_Renamed.arParmValues[44] * Globals_Renamed.arParmValues[46];
					string text = "gcBW";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[42], ref strdivisionbyzerovars);
					text = "gcATc";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[48], ref strdivisionbyzerovars);
					if (Operators.CompareString(strdivisionbyzerovars, "", false) != 0)
					{
						Interaction.MsgBox((object)(strdivisionbyzero + strdivisionbyzerovars), (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[5] = Globals_Renamed.arOutput[4] * Globals_Renamed.arParmValues[75] * Globals_Renamed.arParmValues[41] / (Globals_Renamed.arParmValues[42] * Globals_Renamed.arParmValues[48] * 365f);
					text = "gcBW";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[42], ref strdivisionbyzerovars);
					text = "gcAT";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[47], ref strdivisionbyzerovars);
					if (Operators.CompareString(strdivisionbyzerovars, "", false) != 0)
					{
						Interaction.MsgBox((object)(strdivisionbyzero + strdivisionbyzerovars), (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[6] = Globals_Renamed.arOutput[4] * Globals_Renamed.arParmValues[75] * Globals_Renamed.arParmValues[41] / (Globals_Renamed.arParmValues[42] * Globals_Renamed.arParmValues[47] * 365f);
					text = "gcBW";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[42], ref strdivisionbyzerovars);
					if (Operators.CompareString(strdivisionbyzerovars, "", false) != 0)
					{
						Interaction.MsgBox((object)(strdivisionbyzero + strdivisionbyzerovars), (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[7] = Globals_Renamed.arOutput[4] / Globals_Renamed.arParmValues[42];
					flag = true;
					goto end_IL_0001;
				}
				case 653:
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
				try0001_dispatch = 653;
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

	private static bool ExpUserInhalation(ref short pOpID, ref short pActID)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
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
					Globals_Renamed.arParmValues[65] = Globals_Renamed.arParmValues[64];
					Globals_Renamed.arParmValid[65] = true;
					string text = "hCB";
					missing_required_parameter(ref text, ref Globals_Renamed.arParmValid[46], ref strmissingvars);
					text = "b";
					missing_required_parameter(ref text, ref Globals_Renamed.arParmValid[44], ref strmissingvars);
					if (Operators.CompareString(strmissingvars, "", false) != 0)
					{
						Interaction.MsgBox((object)(strmissingvarsintro + strmissingvars), (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[4] = Globals_Renamed.arParmValues[65] * Globals_Renamed.arParmValues[44] * Globals_Renamed.arParmValues[46];
					text = "gcBW";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[42], ref strdivisionbyzerovars);
					text = "gcATc";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[48], ref strdivisionbyzerovars);
					if (Operators.CompareString(strdivisionbyzerovars, "", false) != 0)
					{
						Interaction.MsgBox((object)(strdivisionbyzero + strdivisionbyzerovars), (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[5] = Globals_Renamed.arOutput[4] * Globals_Renamed.arParmValues[75] * Globals_Renamed.arParmValues[41] / (Globals_Renamed.arParmValues[42] * Globals_Renamed.arParmValues[48] * 365f);
					text = "gcBW";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[42], ref strdivisionbyzerovars);
					text = "gcAT";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[47], ref strdivisionbyzerovars);
					if (Operators.CompareString(strdivisionbyzerovars, "", false) != 0)
					{
						Interaction.MsgBox((object)(strdivisionbyzero + strdivisionbyzerovars), (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[6] = Globals_Renamed.arOutput[4] * Globals_Renamed.arParmValues[75] * Globals_Renamed.arParmValues[41] / (Globals_Renamed.arParmValues[42] * Globals_Renamed.arParmValues[47] * 365f);
					text = "gcBW";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[42], ref strdivisionbyzerovars);
					if (Operators.CompareString(strdivisionbyzerovars, "", false) != 0)
					{
						Interaction.MsgBox((object)(strdivisionbyzero + strdivisionbyzerovars), (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[7] = Globals_Renamed.arOutput[4] / Globals_Renamed.arParmValues[42];
					flag = true;
					goto end_IL_0001;
				}
				case 769:
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
				try0001_dispatch = 769;
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

	private static bool ExpOSHAPELpart(ref short pOpID, ref short pActID)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
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
					string text = "gcYpel";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[96], ref strdivisionbyzerovars);
					if (Operators.CompareString(strdivisionbyzerovars, "", false) != 0)
					{
						Interaction.MsgBox((object)(strdivisionbyzero + strdivisionbyzerovars), (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arParmValues[65] = Globals_Renamed.arParmValues[62] * Globals_Renamed.arParmValues[78] / Globals_Renamed.arParmValues[96];
					Globals_Renamed.arParmValid[65] = true;
					Globals_Renamed.arOutput[4] = Globals_Renamed.arParmValues[65] * Globals_Renamed.arParmValues[44] * Globals_Renamed.arParmValues[46];
					text = "gcBW";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[42], ref strdivisionbyzerovars);
					text = "gcATc";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[48], ref strdivisionbyzerovars);
					if (Operators.CompareString(strdivisionbyzerovars, "", false) != 0)
					{
						Interaction.MsgBox((object)(strdivisionbyzero + strdivisionbyzerovars), (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[5] = Globals_Renamed.arOutput[4] * Globals_Renamed.arParmValues[75] * Globals_Renamed.arParmValues[41] / (Globals_Renamed.arParmValues[42] * Globals_Renamed.arParmValues[48] * 365f);
					text = "gcBW";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[42], ref strdivisionbyzerovars);
					text = "gcAT";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[47], ref strdivisionbyzerovars);
					if (Operators.CompareString(strdivisionbyzerovars, "", false) != 0)
					{
						Interaction.MsgBox((object)(strdivisionbyzero + strdivisionbyzerovars), (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[6] = Globals_Renamed.arOutput[4] * Globals_Renamed.arParmValues[75] * Globals_Renamed.arParmValues[41] / (Globals_Renamed.arParmValues[42] * Globals_Renamed.arParmValues[47] * 365f);
					text = "gcBW";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[42], ref strdivisionbyzerovars);
					if (Operators.CompareString(strdivisionbyzerovars, "", false) != 0)
					{
						Interaction.MsgBox((object)(strdivisionbyzero + strdivisionbyzerovars), (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[7] = Globals_Renamed.arOutput[4] / Globals_Renamed.arParmValues[42];
					flag = true;
					goto end_IL_0001;
				}
				case 756:
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

	private static bool ExpOSHAPELvapor(ref short pOpID, ref short pActID)
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
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
					string text = "gcYpel";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[96], ref strdivisionbyzerovars);
					text = "gcVPpel";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[95], ref strdivisionbyzerovars);
					text = "gcMW";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[5], ref strdivisionbyzerovars);
					text = "gcMWpel";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[97], ref strdivisionbyzerovars);
					if (Operators.CompareString(strdivisionbyzerovars, "", false) != 0)
					{
						Interaction.MsgBox((object)(strdivisionbyzero + strdivisionbyzerovars), (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					dblmiOne = Globals_Renamed.arParmValues[90] * Globals_Renamed.arParmValues[4] * Globals_Renamed.arParmValues[78] / Globals_Renamed.arParmValues[5] / (Globals_Renamed.arParmValues[95] * Globals_Renamed.arParmValues[96] / Globals_Renamed.arParmValues[97]);
					dblmiTwo = 1000000f * Globals_Renamed.arParmValues[40] * Globals_Renamed.arParmValues[4] / 760f;
					dblmi = dblmiOne;
					if (dblmiTwo < dblmi)
					{
						dblmi = dblmiTwo;
					}
					Globals_Renamed.arParmValues[66] = (float)dblmi;
					Globals_Renamed.arParmValid[66] = true;
					text = "gcVm";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[63], ref strdivisionbyzerovars);
					if (Operators.CompareString(strdivisionbyzerovars, "", false) != 0)
					{
						Interaction.MsgBox((object)(strdivisionbyzero + strdivisionbyzerovars), (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arParmValues[65] = Globals_Renamed.arParmValues[66] * Globals_Renamed.arParmValues[5] / Globals_Renamed.arParmValues[63];
					Globals_Renamed.arParmValid[65] = true;
					Globals_Renamed.arOutput[4] = Globals_Renamed.arParmValues[65] * Globals_Renamed.arParmValues[44] * Globals_Renamed.arParmValues[46];
					text = "gcBW";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[42], ref strdivisionbyzerovars);
					text = "gcATc";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[48], ref strdivisionbyzerovars);
					if (Operators.CompareString(strdivisionbyzerovars, "", false) != 0)
					{
						Interaction.MsgBox((object)(strdivisionbyzero + strdivisionbyzerovars), (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[5] = Globals_Renamed.arOutput[4] * Globals_Renamed.arParmValues[75] * Globals_Renamed.arParmValues[41] / (Globals_Renamed.arParmValues[42] * Globals_Renamed.arParmValues[48] * 365f);
					text = "gcBW";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[42], ref strdivisionbyzerovars);
					text = "gcAT";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[47], ref strdivisionbyzerovars);
					if (Operators.CompareString(strdivisionbyzerovars, "", false) != 0)
					{
						Interaction.MsgBox((object)(strdivisionbyzero + strdivisionbyzerovars), (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[6] = Globals_Renamed.arOutput[4] * Globals_Renamed.arParmValues[75] * Globals_Renamed.arParmValues[41] / (Globals_Renamed.arParmValues[42] * Globals_Renamed.arParmValues[47] * 365f);
					text = "gcBW";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[42], ref strdivisionbyzerovars);
					if (Operators.CompareString(strdivisionbyzerovars, "", false) != 0)
					{
						Interaction.MsgBox((object)(strdivisionbyzero + strdivisionbyzerovars), (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[7] = Globals_Renamed.arOutput[4] / Globals_Renamed.arParmValues[42];
					flag = true;
					goto end_IL_0001;
				}
				case 1103:
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
				try0001_dispatch = 1103;
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

	private static bool ExpAuto(ref short pOpID, ref short pActID)
	{
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
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
					Globals_Renamed.arParmValues[0] = Globals_Renamed.arParmValues[113];
					Globals_Renamed.arParmValid[0] = true;
					Globals_Renamed.arParmValues[65] = Globals_Renamed.arParmValues[57] * Globals_Renamed.arParmValues[0];
					Globals_Renamed.arParmValid[65] = true;
					Globals_Renamed.arOutput[4] = Globals_Renamed.arParmValues[65] * Globals_Renamed.arParmValues[44] * Globals_Renamed.arParmValues[46];
					string text = "gcBW";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[42], ref strdivisionbyzerovars);
					text = "gcATc";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[48], ref strdivisionbyzerovars);
					if (Operators.CompareString(strdivisionbyzerovars, "", false) != 0)
					{
						Interaction.MsgBox((object)(strdivisionbyzero + strdivisionbyzerovars), (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[5] = Globals_Renamed.arOutput[4] * Globals_Renamed.arParmValues[75] * Globals_Renamed.arParmValues[41] / (Globals_Renamed.arParmValues[42] * Globals_Renamed.arParmValues[48] * 365f);
					text = "gcBW";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[42], ref strdivisionbyzerovars);
					text = "gcAT";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[47], ref strdivisionbyzerovars);
					if (Operators.CompareString(strdivisionbyzerovars, "", false) != 0)
					{
						Interaction.MsgBox((object)(strdivisionbyzero + strdivisionbyzerovars), (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[6] = Globals_Renamed.arOutput[4] * Globals_Renamed.arParmValues[75] * Globals_Renamed.arParmValues[41] / (Globals_Renamed.arParmValues[42] * Globals_Renamed.arParmValues[47] * 365f);
					text = "gcBW";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[42], ref strdivisionbyzerovars);
					if (Operators.CompareString(strdivisionbyzerovars, "", false) != 0)
					{
						Interaction.MsgBox((object)(strdivisionbyzero + strdivisionbyzerovars), (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[7] = Globals_Renamed.arOutput[4] / Globals_Renamed.arParmValues[42];
					flag = true;
					goto end_IL_0001;
				}
				case 675:
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
				try0001_dispatch = 675;
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

	private static bool ExpAutoPoly(ref short pOpID, ref short pActID)
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
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
					Globals_Renamed.arParmValues[65] = Globals_Renamed.arParmValues[57];
					Globals_Renamed.arParmValid[65] = true;
					Globals_Renamed.arOutput[4] = Globals_Renamed.arParmValues[65] * Globals_Renamed.arParmValues[44] * Globals_Renamed.arParmValues[46];
					string text = "gcBW";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[42], ref strdivisionbyzerovars);
					text = "gcATc";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[48], ref strdivisionbyzerovars);
					if (Operators.CompareString(strdivisionbyzerovars, "", false) != 0)
					{
						Interaction.MsgBox((object)(strdivisionbyzero + strdivisionbyzerovars), (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[5] = Globals_Renamed.arOutput[4] * Globals_Renamed.arParmValues[75] * Globals_Renamed.arParmValues[41] / (Globals_Renamed.arParmValues[42] * Globals_Renamed.arParmValues[48] * 365f);
					text = "gcBW";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[42], ref strdivisionbyzerovars);
					text = "gcAT";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[47], ref strdivisionbyzerovars);
					if (Operators.CompareString(strdivisionbyzerovars, "", false) != 0)
					{
						Interaction.MsgBox((object)(strdivisionbyzero + strdivisionbyzerovars), (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[6] = Globals_Renamed.arOutput[4] * Globals_Renamed.arParmValues[75] * Globals_Renamed.arParmValues[41] / (Globals_Renamed.arParmValues[42] * Globals_Renamed.arParmValues[47] * 365f);
					text = "gcBW";
					division_by_zero(ref text, ref Globals_Renamed.arParmValues[42], ref strdivisionbyzerovars);
					if (Operators.CompareString(strdivisionbyzerovars, "", false) != 0)
					{
						Interaction.MsgBox((object)(strdivisionbyzero + strdivisionbyzerovars), (MsgBoxStyle)64, (object)strmodeltext);
						goto end_IL_0001;
					}
					Globals_Renamed.arOutput[7] = Globals_Renamed.arOutput[4] / Globals_Renamed.arParmValues[42];
					flag = true;
					goto end_IL_0001;
				}
				case 644:
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
				try0001_dispatch = 644;
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
