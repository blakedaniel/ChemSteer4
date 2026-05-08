using System;
using System.Collections;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ADODB;
using AxMSFlexGridLib;
using ChemSteer.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Compatibility.VB6;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace ChemSteer;

[StandardModule]
internal sealed class ChemStrX
{
	[SpecialName]
	private static float _0024STATIC_0024ValidateParmInput_0024032106101C106_0024PrevPvalue;

	public static object redimReleaseModelArrays(short pNumOps, short pNumRelModels, bool bPreserve)
	{
		checked
		{
			Globals_Renamed.arRelModels = new short[11, 26, pNumOps + 1];
			Globals_Renamed.arRelModType = new short[pNumRelModels + 1];
			Globals_Renamed.arRelModBasis = new string[pNumRelModels + 1];
			Globals_Renamed.arRelModNAICS = new string[pNumRelModels + 1];
			Globals_Renamed.arRelModStatus = new short[pNumRelModels + 1];
			Globals_Renamed.arRelModOutputOn = new short[3, pNumRelModels + 1];
			Globals_Renamed.arRelModChar = new string[3, pNumRelModels + 1];
			Globals_Renamed.arRelModMedia = new float[19, pNumRelModels + 1];
			Globals_Renamed.arRelModParmsV = new float[3, 163, pNumRelModels + 1];
			Globals_Renamed.arRelModParmsT = new short[3, 163, pNumRelModels + 1];
			Globals_Renamed.arRelModParmsVC = new short[3, 163, pNumRelModels + 1];
			Globals_Renamed.arRelModDRR = new float[3, pNumRelModels + 1];
			Globals_Renamed.arRelModARR = new float[3, pNumRelModels + 1];
			Globals_Renamed.arRelModDOR = new short[3, pNumRelModels + 1];
			object result = default(object);
			return result;
		}
	}

	public static object redimExposureModelArrays(short pNumOps, short pNumExpModels, bool bPreserve)
	{
		checked
		{
			Globals_Renamed.arExpModels = new short[3, 26, pNumOps + 1];
			Globals_Renamed.arExpModType = new short[pNumExpModels + 1];
			Globals_Renamed.arExpModOutputOn = new short[3, pNumExpModels + 1];
			Globals_Renamed.arExpModChar = new string[3, pNumExpModels + 1];
			Globals_Renamed.arExpModBasis = new string[pNumExpModels + 1];
			Globals_Renamed.arExpModChmSt = new short[pNumExpModels + 1];
			Globals_Renamed.arExpModUncertainty = new short[pNumExpModels + 1];
			Globals_Renamed.arExpModStatus = new short[pNumExpModels + 1];
			Globals_Renamed.arExpModParmsV = new float[3, 163, pNumExpModels + 1];
			Globals_Renamed.arExpModParmsT = new short[3, 163, pNumExpModels + 1];
			Globals_Renamed.arExpModParmsVC = new short[3, 163, pNumExpModels + 1];
			Globals_Renamed.arExpModEst = new float[3, 19, pNumExpModels + 1];
			Globals_Renamed.arExpModInhRC = new string[5, pNumExpModels + 1];
			object result = default(object);
			return result;
		}
	}

	public static bool addDermalModelToArrays(int pModelType)
	{
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
		Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		Globals_Renamed.intModIndex = Globals_Renamed.intNumExpModels;
		checked
		{
			Globals_Renamed.intNumExpModels++;
			Globals_Renamed.arExpModels[0, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] = Globals_Renamed.intNumExpModels;
			Globals_Renamed.arExpModType = (short[])Utils.CopyArray((Array)Globals_Renamed.arExpModType, (Array)new short[Globals_Renamed.intNumExpModels + 1]);
			Globals_Renamed.arExpModOutputOn = (short[,])Utils.CopyArray((Array)Globals_Renamed.arExpModOutputOn, (Array)new short[3, Globals_Renamed.intNumExpModels + 1]);
			Globals_Renamed.arExpModChar = (string[,])Utils.CopyArray((Array)Globals_Renamed.arExpModChar, (Array)new string[3, Globals_Renamed.intNumExpModels + 1]);
			Globals_Renamed.arExpModBasis = (string[])Utils.CopyArray((Array)Globals_Renamed.arExpModBasis, (Array)new string[Globals_Renamed.intNumExpModels + 1]);
			Globals_Renamed.arExpModChmSt = (short[])Utils.CopyArray((Array)Globals_Renamed.arExpModChmSt, (Array)new short[Globals_Renamed.intNumExpModels + 1]);
			Globals_Renamed.arExpModUncertainty = (short[])Utils.CopyArray((Array)Globals_Renamed.arExpModUncertainty, (Array)new short[Globals_Renamed.intNumExpModels + 1]);
			Globals_Renamed.arExpModStatus = (short[])Utils.CopyArray((Array)Globals_Renamed.arExpModStatus, (Array)new short[Globals_Renamed.intNumExpModels + 1]);
			Globals_Renamed.arExpModParmsV = (float[,,])Utils.CopyArray((Array)Globals_Renamed.arExpModParmsV, (Array)new float[3, 163, Globals_Renamed.intNumExpModels + 1]);
			Globals_Renamed.arExpModParmsT = (short[,,])Utils.CopyArray((Array)Globals_Renamed.arExpModParmsT, (Array)new short[3, 163, Globals_Renamed.intNumExpModels + 1]);
			Globals_Renamed.arExpModParmsVC = (short[,,])Utils.CopyArray((Array)Globals_Renamed.arExpModParmsVC, (Array)new short[3, 163, Globals_Renamed.intNumExpModels + 1]);
			Globals_Renamed.arExpModEst = (float[,,])Utils.CopyArray((Array)Globals_Renamed.arExpModEst, (Array)new float[3, 19, Globals_Renamed.intNumExpModels + 1]);
			Globals_Renamed.arExpModInhRC = (string[,])Utils.CopyArray((Array)Globals_Renamed.arExpModInhRC, (Array)new string[5, Globals_Renamed.intNumExpModels + 1]);
			Globals_Renamed.arExpModType[Globals_Renamed.intNumExpModels - 1] = (short)pModelType;
			command.ActiveConnection = Common.MyConn;
			command.CommandText = "pqryGetRelModel";
			command.CommandType = CommandTypeEnum.adCmdStoredProc;
			command.Parameters.Append(command.CreateParameter("pRelModID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, pModelType));
			object RecordsAffected = Missing.Value;
			object Parameters = Missing.Value;
			recordset = command.Execute(out RecordsAffected, ref Parameters);
			command.Parameters.Delete("pRelModID");
			Globals_Renamed.arExpModChmSt[Globals_Renamed.intModIndex] = (short)SetChemStateID(ref Globals_Renamed.arExpModType[Globals_Renamed.intModIndex], Conversions.ToInteger(recordset.Fields["ChemStateID"].Value));
			Globals_Renamed.arExpModUncertainty[Globals_Renamed.intModIndex] = 0;
			Globals_Renamed.arExpModStatus[Globals_Renamed.intModIndex] = 0;
			Globals_Renamed.arExpModOutputOn[0, Globals_Renamed.intModIndex] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["OutputOn1"].Value)));
			Globals_Renamed.arExpModOutputOn[1, Globals_Renamed.intModIndex] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["OutputOn2"].Value)));
			Globals_Renamed.arExpModChar[0, Globals_Renamed.intModIndex] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["Char1"].Value));
			Globals_Renamed.arExpModChar[1, Globals_Renamed.intModIndex] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["Char2"].Value));
			Globals_Renamed.arExpModBasis[Globals_Renamed.intModIndex] = Conversions.ToString(recordset.Fields["Basis"].Value);
			recordset.Close();
			short num = 0;
			short num2;
			short num3;
			do
			{
				if (Operators.CompareString(Globals_Renamed.arExpModChar[num, Globals_Renamed.intModIndex], "Output", false) == 0)
				{
					Globals_Renamed.arExpModChar[num, Globals_Renamed.intModIndex] = "Output " + Conversions.ToString(num + 1);
				}
				num = (short)unchecked(num + 1);
				num2 = num;
				num3 = 1;
			}
			while (num2 <= num3);
			short pModType = (short)pModelType;
			short pModNum = 0;
			AddExpModel(ref pModType, ref pModNum);
			pModelType = pModType;
			return true;
		}
	}

	public static bool addInhalationModelToArrays(int pModelType)
	{
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
		Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		Globals_Renamed.intModIndex = Globals_Renamed.intNumExpModels;
		checked
		{
			Globals_Renamed.intNumExpModels++;
			Globals_Renamed.arExpModels[1, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] = Globals_Renamed.intNumExpModels;
			Globals_Renamed.arExpModType = (short[])Utils.CopyArray((Array)Globals_Renamed.arExpModType, (Array)new short[Globals_Renamed.intNumExpModels + 1]);
			Globals_Renamed.arExpModOutputOn = (short[,])Utils.CopyArray((Array)Globals_Renamed.arExpModOutputOn, (Array)new short[3, Globals_Renamed.intNumExpModels + 1]);
			Globals_Renamed.arExpModChar = (string[,])Utils.CopyArray((Array)Globals_Renamed.arExpModChar, (Array)new string[3, Globals_Renamed.intNumExpModels + 1]);
			Globals_Renamed.arExpModBasis = (string[])Utils.CopyArray((Array)Globals_Renamed.arExpModBasis, (Array)new string[Globals_Renamed.intNumExpModels + 1]);
			Globals_Renamed.arExpModChmSt = (short[])Utils.CopyArray((Array)Globals_Renamed.arExpModChmSt, (Array)new short[Globals_Renamed.intNumExpModels + 1]);
			Globals_Renamed.arExpModUncertainty = (short[])Utils.CopyArray((Array)Globals_Renamed.arExpModUncertainty, (Array)new short[Globals_Renamed.intNumExpModels + 1]);
			Globals_Renamed.arExpModStatus = (short[])Utils.CopyArray((Array)Globals_Renamed.arExpModStatus, (Array)new short[Globals_Renamed.intNumExpModels + 1]);
			Globals_Renamed.arExpModParmsV = (float[,,])Utils.CopyArray((Array)Globals_Renamed.arExpModParmsV, (Array)new float[3, 163, Globals_Renamed.intNumExpModels + 1]);
			Globals_Renamed.arExpModParmsT = (short[,,])Utils.CopyArray((Array)Globals_Renamed.arExpModParmsT, (Array)new short[3, 163, Globals_Renamed.intNumExpModels + 1]);
			Globals_Renamed.arExpModParmsVC = (short[,,])Utils.CopyArray((Array)Globals_Renamed.arExpModParmsVC, (Array)new short[3, 163, Globals_Renamed.intNumExpModels + 1]);
			Globals_Renamed.arExpModEst = (float[,,])Utils.CopyArray((Array)Globals_Renamed.arExpModEst, (Array)new float[3, 19, Globals_Renamed.intNumExpModels + 1]);
			Globals_Renamed.arExpModInhRC = (string[,])Utils.CopyArray((Array)Globals_Renamed.arExpModInhRC, (Array)new string[5, Globals_Renamed.intNumExpModels + 1]);
			Globals_Renamed.arExpModType[Globals_Renamed.intNumExpModels - 1] = (short)pModelType;
			command.ActiveConnection = Common.MyConn;
			command.CommandText = "pqryGetRelModel";
			command.CommandType = CommandTypeEnum.adCmdStoredProc;
			command.Parameters.Append(command.CreateParameter("pRelModID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, pModelType));
			object RecordsAffected = Missing.Value;
			object Parameters = Missing.Value;
			recordset = command.Execute(out RecordsAffected, ref Parameters);
			command.Parameters.Delete("pRelModID");
			Globals_Renamed.arExpModChmSt[Globals_Renamed.intModIndex] = (short)SetChemStateID(ref Globals_Renamed.arExpModType[Globals_Renamed.intModIndex], Conversions.ToInteger(recordset.Fields["ChemStateID"].Value));
			Globals_Renamed.arExpModUncertainty[Globals_Renamed.intModIndex] = 1;
			Globals_Renamed.arExpModStatus[Globals_Renamed.intModIndex] = 0;
			Globals_Renamed.arExpModOutputOn[0, Globals_Renamed.intModIndex] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["OutputOn1"].Value)));
			Globals_Renamed.arExpModOutputOn[1, Globals_Renamed.intModIndex] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["OutputOn2"].Value)));
			Globals_Renamed.arExpModChar[0, Globals_Renamed.intModIndex] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["Char1"].Value));
			Globals_Renamed.arExpModChar[1, Globals_Renamed.intModIndex] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["Char2"].Value));
			Globals_Renamed.arExpModBasis[Globals_Renamed.intModIndex] = Conversions.ToString(recordset.Fields["Basis"].Value);
			recordset.Close();
			short num = 0;
			short num2;
			short num3;
			do
			{
				if (Operators.CompareString(Globals_Renamed.arExpModChar[num, Globals_Renamed.intModIndex], "Output", false) == 0)
				{
					Globals_Renamed.arExpModChar[num, Globals_Renamed.intModIndex] = "Output " + Conversions.ToString(num + 1);
				}
				num = (short)unchecked(num + 1);
				num2 = num;
				num3 = 1;
			}
			while (num2 <= num3);
			short pModType = (short)pModelType;
			short pModNum = 1;
			AddExpModel(ref pModType, ref pModNum);
			pModelType = pModType;
			return true;
		}
	}

	public static bool addReleaseModelToArrays(int pModelType)
	{
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
		Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		Globals_Renamed.intModIndex = Globals_Renamed.intNumRelModels;
		checked
		{
			Globals_Renamed.intNumRelModels++;
			Globals_Renamed.arRelModType = (short[])Utils.CopyArray((Array)Globals_Renamed.arRelModType, (Array)new short[Globals_Renamed.intNumRelModels + 1]);
			Globals_Renamed.arRelModBasis = (string[])Utils.CopyArray((Array)Globals_Renamed.arRelModBasis, (Array)new string[Globals_Renamed.intNumRelModels + 1]);
			Globals_Renamed.arRelModNAICS = (string[])Utils.CopyArray((Array)Globals_Renamed.arRelModNAICS, (Array)new string[Globals_Renamed.intNumRelModels + 1]);
			Globals_Renamed.arRelModStatus = (short[])Utils.CopyArray((Array)Globals_Renamed.arRelModStatus, (Array)new short[Globals_Renamed.intNumRelModels + 1]);
			Globals_Renamed.arRelModOutputOn = (short[,])Utils.CopyArray((Array)Globals_Renamed.arRelModOutputOn, (Array)new short[3, Globals_Renamed.intNumRelModels + 1]);
			Globals_Renamed.arRelModChar = (string[,])Utils.CopyArray((Array)Globals_Renamed.arRelModChar, (Array)new string[3, Globals_Renamed.intNumRelModels + 1]);
			Globals_Renamed.arRelModMedia = (float[,])Utils.CopyArray((Array)Globals_Renamed.arRelModMedia, (Array)new float[19, Globals_Renamed.intNumRelModels + 1]);
			Globals_Renamed.arRelModParmsV = (float[,,])Utils.CopyArray((Array)Globals_Renamed.arRelModParmsV, (Array)new float[3, 163, Globals_Renamed.intNumRelModels + 1]);
			Globals_Renamed.arRelModParmsT = (short[,,])Utils.CopyArray((Array)Globals_Renamed.arRelModParmsT, (Array)new short[3, 163, Globals_Renamed.intNumRelModels + 1]);
			Globals_Renamed.arRelModParmsVC = (short[,,])Utils.CopyArray((Array)Globals_Renamed.arRelModParmsVC, (Array)new short[3, 163, Globals_Renamed.intNumRelModels + 1]);
			Globals_Renamed.arRelModDRR = (float[,])Utils.CopyArray((Array)Globals_Renamed.arRelModDRR, (Array)new float[3, Globals_Renamed.intNumRelModels + 1]);
			Globals_Renamed.arRelModARR = (float[,])Utils.CopyArray((Array)Globals_Renamed.arRelModARR, (Array)new float[3, Globals_Renamed.intNumRelModels + 1]);
			Globals_Renamed.arRelModDOR = (short[,])Utils.CopyArray((Array)Globals_Renamed.arRelModDOR, (Array)new short[3, Globals_Renamed.intNumRelModels + 1]);
			command.ActiveConnection = Common.MyConn;
			command.CommandText = "pqryGetRelModel";
			command.CommandType = CommandTypeEnum.adCmdStoredProc;
			command.Parameters.Append(command.CreateParameter("pRelModID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, pModelType));
			Command command2 = command;
			object RecordsAffected = Missing.Value;
			object Parameters = Missing.Value;
			recordset = command2.Execute(out RecordsAffected, ref Parameters);
			command.Parameters.Delete("pRelModID");
			Globals_Renamed.arRelModType[Globals_Renamed.intNumRelModels - 1] = (short)pModelType;
			Globals_Renamed.arRelModBasis[Globals_Renamed.intNumRelModels - 1] = Conversions.ToString(recordset.Fields["Basis"].Value);
			Globals_Renamed.arRelModOutputOn[0, Globals_Renamed.intNumRelModels - 1] = Conversions.ToShort(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["OutputOn1"].Value)), (object)0, RuntimeHelpers.GetObjectValue(recordset.Fields["OutputOn1"].Value)));
			Globals_Renamed.arRelModChar[0, Globals_Renamed.intNumRelModels - 1] = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["Char1"].Value)), (object)"", RuntimeHelpers.GetObjectValue(recordset.Fields["Char1"].Value)));
			Globals_Renamed.arRelModOutputOn[1, Globals_Renamed.intNumRelModels - 1] = Conversions.ToShort(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["OutputOn2"].Value)), (object)0, RuntimeHelpers.GetObjectValue(recordset.Fields["OutputOn2"].Value)));
			Globals_Renamed.arRelModChar[1, Globals_Renamed.intNumRelModels - 1] = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["Char2"].Value)), (object)"", RuntimeHelpers.GetObjectValue(recordset.Fields["Char2"].Value)));
			Globals_Renamed.arRelModels[Globals_Renamed.intNumRelModels - 1, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] = Globals_Renamed.intNumRelModels;
			command.ActiveConnection = Common.MyConn;
			command.CommandText = "pqryGetMediaDefaults";
			command.CommandType = CommandTypeEnum.adCmdStoredProc;
			command.Parameters.Append(command.CreateParameter("pRelModID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, pModelType));
			Command command3 = command;
			Parameters = Missing.Value;
			RecordsAffected = Missing.Value;
			recordset = command3.Execute(out Parameters, ref RecordsAffected);
			command.Parameters.Delete("pRelModID");
			if (recordset.RecordCount > 0)
			{
				recordset.MoveFirst();
				while (!recordset.EOF)
				{
					Globals_Renamed.arRelModMedia[Conversions.ToInteger(recordset.Fields["MediaID"].Value), Globals_Renamed.intNumRelModels - 1] = Conversions.ToSingle(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["Pct"].Value)), (object)0, RuntimeHelpers.GetObjectValue(recordset.Fields["Pct"].Value)));
					recordset.MoveNext();
				}
			}
			recordset.Close();
			recordset = null;
			command = null;
			return true;
		}
	}

	public static short AddEModels(ref short pActIndex)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		short num9 = default(short);
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
					Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
					Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
					Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					short[] array = new short[3];
					ProjectData.ClearProjectError();
					num2 = 2;
					command.ActiveConnection = Common.MyConn;
					command.CommandText = "pqryGetActivity";
					command.CommandType = CommandTypeEnum.adCmdStoredProc;
					command.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, Globals_Renamed.arSelActType[pActIndex, Globals_Renamed.intOpIndex]));
					Command command2 = command;
					object RecordsAffected = Missing.Value;
					object Parameters = Missing.Value;
					recordset = command2.Execute(out RecordsAffected, ref Parameters);
					command.Parameters.Delete("pActID");
					array[0] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["DefaultDrmModel"].Value)));
					array[1] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["DefaultInhModel"].Value)));
					if (Strings.InStr(Conversions.ToString(recordset.Fields[1].Value), "Product", (CompareMethod)0) > 0)
					{
						flag = true;
					}
					else if ((Strings.InStr(Conversions.ToString(recordset.Fields[1].Value), "Raw Material", (CompareMethod)0) == 0) & (Globals_Renamed.arOpType[Globals_Renamed.intOpIndex] == 1))
					{
						flag = true;
					}
					short num3 = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["ContTab"].Value)));
					recordset.Close();
					Globals_Renamed.intActIndex = pActIndex;
					short num4 = 9;
					short pModNum = 0;
					short num7;
					short num8;
					do
					{
						if (array[pModNum] < -1000)
						{
							short num5 = array[pModNum];
							if (num5 == -1001)
							{
								double num6 = ((num3 <= 0) ? 0.0 : ((double)Globals_Renamed.arContParms[13, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex]));
								if (num6 == 0.0)
								{
									num6 = ((Globals_Renamed.arOpBorC[Globals_Renamed.intOpIndex] == 1) ? ((Globals_Renamed.arOpParms[17, Globals_Renamed.intOpIndex] < 1f) ? ((Globals_Renamed.arOpType[Globals_Renamed.intOpIndex] != 1) ? ((double)Globals_Renamed.arOpParms[99, Globals_Renamed.intOpIndex]) : ((double)Globals_Renamed.arOpParms[32, Globals_Renamed.intOpIndex])) : ((Globals_Renamed.arOpType[Globals_Renamed.intOpIndex] != 1) ? ((double)(Globals_Renamed.arOpParms[17, Globals_Renamed.intOpIndex] * Globals_Renamed.arOpParms[99, Globals_Renamed.intOpIndex])) : ((double)(Globals_Renamed.arOpParms[17, Globals_Renamed.intOpIndex] * Globals_Renamed.arOpParms[32, Globals_Renamed.intOpIndex])))) : ((Globals_Renamed.arOpType[Globals_Renamed.intOpIndex] != 1) ? ((double)Globals_Renamed.arOpParms[14, Globals_Renamed.intOpIndex]) : ((double)Globals_Renamed.arOpParms[12, Globals_Renamed.intOpIndex])));
								}
								if (num6 <= 54.0 && num6 != 0.0)
								{
									array[pModNum] = 21;
								}
								else
								{
									array[pModNum] = 24;
								}
							}
						}
						else if (array[pModNum] < 0)
						{
							num4 = Conversions.ToShort(Interaction.IIf(num4 == 9, (object)(short)2, (object)num4));
							if (flag)
							{
								if (!((Conversions.ToDouble(frmMain.DefInstance.lblAVPlow.Text) <= (double)Globals_Renamed.arOpParms[122, Globals_Renamed.intOpIndex]) & ((double)Globals_Renamed.arOpParms[122, Globals_Renamed.intOpIndex] <= Conversions.ToDouble(frmMain.DefInstance.lblAVPhigh.Text))))
								{
									break;
								}
								array[pModNum] = Math.Abs(array[pModNum]);
								num4 = 1;
							}
							else
							{
								if (!((Conversions.ToDouble(frmMain.DefInstance.lblAVPlow.Text) <= (double)Globals_Renamed.arOpParms[121, Globals_Renamed.intOpIndex]) & ((double)Globals_Renamed.arOpParms[121, Globals_Renamed.intOpIndex] <= Conversions.ToDouble(frmMain.DefInstance.lblAVPhigh.Text))))
								{
									break;
								}
								array[pModNum] = Math.Abs(array[pModNum]);
								num4 = 1;
							}
						}
						if (array[pModNum] > 0)
						{
							AddExpModel(ref array[pModNum], ref pModNum);
							SetOER();
						}
						checked
						{
							pModNum = (short)unchecked(pModNum + 1);
							num7 = pModNum;
							num8 = 1;
						}
					}
					while (num7 <= num8);
					recordset = null;
					command = null;
					pModNum = Globals_Renamed.intModIndex;
					short pParmID = 50;
					Globals_Renamed.intModIndex = FindAssocRelModelIndex(ref pParmID);
					if (Globals_Renamed.intModIndex != -1)
					{
						RefreshAllLinks();
					}
					Globals_Renamed.intModIndex = pModNum;
					num9 = num4;
					goto end_IL_0001;
				}
				case 1439:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						string Eobject = "ChemStrB";
						string Efunction = "AddEModels";
						ErrObject val = Information.Err();
						int Enumber = val.Number;
						ErrObject val2 = Information.Err();
						string Edescription = val2.Description;
						bool Econtact = true;
						Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
						val2.Description = Edescription;
						val.Number = Enumber;
						goto end_IL_0001;
					}
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 1439;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		short result = num9;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static short AddRModels(ref short pActIndex)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		short num8 = default(short);
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
						Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
						Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
						Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						short[] array = new short[4];
						ProjectData.ClearProjectError();
						num2 = 2;
						command.ActiveConnection = Common.MyConn;
						command.CommandText = "pqryGetActivity";
						command.CommandType = CommandTypeEnum.adCmdStoredProc;
						command.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, Globals_Renamed.arSelActType[pActIndex, Globals_Renamed.intOpIndex]));
						Command command2 = command;
						object RecordsAffected = Missing.Value;
						object Parameters = Missing.Value;
						recordset = command2.Execute(out RecordsAffected, ref Parameters);
						command.Parameters.Delete("pActID");
						array[0] = Conversions.ToShort(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["DefaultRelModel"].Value)), (object)0, RuntimeHelpers.GetObjectValue(recordset.Fields["DefaultRelModel"].Value)));
						array[1] = Conversions.ToShort(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["DefaultRelModel2"].Value)), (object)0, RuntimeHelpers.GetObjectValue(recordset.Fields["DefaultRelModel2"].Value)));
						array[2] = Conversions.ToShort(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["DefaultRelModel3"].Value)), (object)0, RuntimeHelpers.GetObjectValue(recordset.Fields["DefaultRelModel3"].Value)));
						short num3 = Conversions.ToShort(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["ContTab"].Value)), (object)0, RuntimeHelpers.GetObjectValue(recordset.Fields["ContTab"].Value)));
						if (Strings.InStr(Conversions.ToString(recordset.Fields[1].Value), "Product", (CompareMethod)0) > 0)
						{
							flag = true;
						}
						recordset.Close();
						Globals_Renamed.intActIndex = pActIndex;
						short num4 = 9;
						short pModNum = 0;
						short num6;
						short num7;
						do
						{
							if (array[pModNum] < 0)
							{
								num4 = Conversions.ToShort(Interaction.IIf(num4 == 9, (object)(short)2, (object)num4));
								if (!Versioned.IsNumeric((object)frmMain.DefInstance.lblVP.Text))
								{
									break;
								}
								short num5 = array[pModNum];
								if (num5 == -14)
								{
									if (Operators.CompareString(frmMain.DefInstance.lblVP.Text, frmMain.DefInstance.lblAVPlow.Text, false) < 0)
									{
										break;
									}
									array[pModNum] = Math.Abs(array[pModNum]);
									num4 = 1;
								}
								else if (flag)
								{
									if (!((Conversions.ToDouble(frmMain.DefInstance.lblAVPlow.Text) <= (double)Globals_Renamed.arOpParms[122, Globals_Renamed.intOpIndex]) & ((double)Globals_Renamed.arOpParms[122, Globals_Renamed.intOpIndex] <= Conversions.ToDouble(frmMain.DefInstance.lblAVPhigh.Text))))
									{
										break;
									}
									array[pModNum] = Math.Abs(array[pModNum]);
									num4 = 1;
								}
								else
								{
									if (!((Conversions.ToDouble(frmMain.DefInstance.lblAVPlow.Text) <= (double)Globals_Renamed.arOpParms[121, Globals_Renamed.intOpIndex]) & ((double)Globals_Renamed.arOpParms[121, Globals_Renamed.intOpIndex] <= Conversions.ToDouble(frmMain.DefInstance.lblAVPhigh.Text))))
									{
										break;
									}
									array[pModNum] = Math.Abs(array[pModNum]);
									num4 = 1;
								}
							}
							if (array[pModNum] > 0)
							{
								AddRelModel(ref array[pModNum], ref pModNum);
							}
							pModNum = (short)unchecked(pModNum + 1);
							num6 = pModNum;
							num7 = 2;
						}
						while (num6 <= num7);
						recordset = null;
						command = null;
						num8 = num4;
						goto end_IL_0001;
					}
					case 1171:
						num = -1;
						switch (num2)
						{
						case 2:
						{
							string Eobject = "ChemStrB";
							string Efunction = "AddRModels";
							ErrObject val = Information.Err();
							int Enumber = val.Number;
							ErrObject val2 = Information.Err();
							string Edescription = val2.Description;
							bool Econtact = true;
							Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
							val2.Description = Edescription;
							val.Number = Enumber;
							goto end_IL_0001;
						}
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 1171;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		short result = num8;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static float Calc_DVrinse_SeqB(ref float pADMUchem, ref float pVbath, ref float pNbath, ref float pFreqbath, ref float pDbath, ref float pYbath, ref float pOD, ref float pDrinse, ref float pYrinse, ref float pRinseE)
	{
		return (float)(Conversions.ToDouble(ShowInSciNot((double)pADMUchem - (double)(pVbath * pNbath * pFreqbath * pDbath) * 3.78 * (double)pYbath / (double)pOD)) / ((double)pDrinse * 3.78 * (double)pYrinse * (double)(1f - pRinseE)));
	}

	public static float Calc_Vbath_SeqA(ref float pADMUchem, ref float pNbath, ref float pFreqbath, ref float pDbath, ref float pYbath, ref float pOD, ref float pDrinse, ref float pYrinse, ref float pRinseE)
	{
		return Conversions.ToSingle(ShowInSciNot((double)pADMUchem / ((double)(pNbath * pFreqbath * pDbath) * 3.78 * (double)pYbath / (double)pOD + 0.6576 * (double)pNbath * (double)pDrinse * 3.78 * (double)pYrinse * (double)(1f - pRinseE))));
	}

	public static float Calc_DVrinse_SeqA(ref float pVbath, ref float pNbath)
	{
		return Conversions.ToSingle(ShowInSciNot(0.6576 * (double)pVbath * (double)pNbath));
	}

	public static float Calc_Vbath_SeqC(ref float pADMUchem, ref float pDVrinse, ref float pDrinse, ref float pYrinse, ref float pRinseE, ref float pNbath, ref float pFreqbath, ref float pDbath, ref float pYbath, ref float pOD)
	{
		return Conversions.ToSingle(ShowInSciNot(((double)pADMUchem - (double)(pDVrinse * pDrinse) * 3.78 * (double)pYrinse * (double)(1f - pRinseE)) / ((double)(pNbath * pFreqbath * pDbath) * 3.78 * (double)pYbath / (double)pOD)));
	}

	public static float Calc_Yrinse_SeqD(ref float pADMUchem, ref float pVbath, ref float pNbath, ref float pFreqbath, ref float pDbath, ref float pYbath, ref float pOD, ref float pDVrinse, ref float pDrinse, ref float pYrinse, ref float pRinseE)
	{
		float num = (float)((double)(pVbath * pNbath * pFreqbath * pDbath) * 3.78 * (double)pYbath / (double)pOD);
		float num2 = (float)((double)(pDVrinse * pDrinse) * 3.78 * (double)pYrinse * (double)(1f - pRinseE));
		return (pADMUchem - (num + num2)) / pADMUchem;
	}

	public static string Cvt2DMPLabels(ref short pNum)
	{
		return pNum switch
		{
			0 => "Pending", 
			1 => "Cond Models Added", 
			2 => "No Cond Models Added", 
			9 => "No Conditional Models", 
			_ => "Error", 
		};
	}

	private static void PopParmsArraysR(ref short pActID, ref short pmodId)
	{
		int try0001_dispatch = -1;
		int num = default(int);
		Recordset recordset = default(Recordset);
		int num2 = default(int);
		int num3 = default(int);
		string text = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				int num4;
				string Eobject;
				string Efunction;
				ErrObject val;
				int Enumber;
				ErrObject val2;
				string Edescription;
				bool Econtact;
				short pModIndex;
				short pPcat;
				switch (try0001_dispatch)
				{
				default:
				{
					num = 1;
					Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
					recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					goto IL_0022;
				}
				case 365:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 2:
							break;
						case 1:
							goto IL_012b;
						default:
							goto end_IL_0001;
						}
						goto IL_00af;
					}
					IL_0058:
					num = 5;
					text = Conversions.ToString(recordset.Fields[0].Value);
					goto IL_0077;
					IL_0077:
					num = 6;
					recordset.Close();
					goto IL_0081;
					IL_0035:
					num = 4;
					recordset.Open("SELECT PCat FROM ListOfModels WHERE ModelID=" + Conversions.ToString((int)pmodId), Common.MyConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
					goto IL_0058;
					IL_012b:
					num4 = num2 + 1;
					goto IL_012f;
					IL_00af:
					num = 10;
					Eobject = "ChemStrB";
					Efunction = "PopParmsArraysR";
					val = Information.Err();
					Enumber = val.Number;
					val2 = Information.Err();
					Edescription = val2.Description;
					Econtact = true;
					Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
					val2.Description = Edescription;
					val.Number = Enumber;
					goto IL_0108;
					IL_0108:
					num = 11;
					ProjectData.ClearProjectError();
					if (num2 == 0)
					{
						throw ProjectData.CreateProjectError(-2146828268);
					}
					num4 = num2;
					goto IL_012f;
					IL_0081:
					num = 7;
					recordset = null;
					goto IL_0086;
					IL_0086:
					num = 8;
					pModIndex = checked((short)(Globals_Renamed.intNumRelModels - 1));
					pPcat = Conversions.ToShort(text);
					SetRelModelDefaults(ref pmodId, ref pModIndex, ref pActID, ref pPcat);
					goto end_IL_0001_2;
					IL_012f:
					num2 = 0;
					switch (num4)
					{
					case 1:
						break;
					case 2:
						goto IL_0022;
					case 3:
						goto IL_002a;
					case 4:
						goto IL_0035;
					case 5:
						goto IL_0058;
					case 6:
						goto IL_0077;
					case 7:
						goto IL_0081;
					case 8:
						goto IL_0086;
					case 10:
						goto IL_00af;
					case 11:
						goto IL_0108;
					default:
						goto end_IL_0001;
					case 9:
					case 12:
						goto end_IL_0001_2;
					}
					goto default;
					IL_0022:
					ProjectData.ClearProjectError();
					num3 = 2;
					goto IL_002a;
					IL_002a:
					num = 3;
					recordset.CursorLocation = CursorLocationEnum.adUseClient;
					goto IL_0035;
					end_IL_0001:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 365;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void PopParmsArraysD(ref short pActID, ref short pmodId)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
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
					Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
					Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					ProjectData.ClearProjectError();
					num2 = 2;
					recordset.CursorLocation = CursorLocationEnum.adUseClient;
					recordset.Open("SELECT pCat FROM ListOfModels WHERE ModelID=" + Conversions.ToString((int)pmodId), Common.MyConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
					string text = Conversions.ToString(recordset.Fields[0].Value);
					recordset.Close();
					recordset = null;
					short pPcat = Conversions.ToShort(text);
					SetExpModelDefaults(ref pmodId, ref Globals_Renamed.intModIndex, ref pActID, ref pPcat);
					goto end_IL_0001;
				}
				case 234:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						string Eobject = "ChemStrB";
						string Efunction = "PopParmsArraysD";
						ErrObject val = Information.Err();
						int Enumber = val.Number;
						ErrObject val2 = Information.Err();
						string Edescription = val2.Description;
						bool Econtact = true;
						Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
						val2.Description = Edescription;
						val.Number = Enumber;
						goto end_IL_0001;
					}
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 234;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static int MyRoundUp(ref double pValue)
	{
		int num = checked((int)Math.Round(pValue + 0.1));
		if (num == 0)
		{
			num = 1;
		}
		return num;
	}

	[STAThread]
	public static void Main()
	{
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num4 = default(int);
		int num6 = default(int);
		frmSplash frmSplash2 = default(frmSplash);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				int num5;
				int num7;
				int num8;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 2;
					goto IL_0009;
				case 571:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 2:
						case 3:
							break;
						case 1:
							goto IL_01c9;
						default:
							goto end_IL_0001;
						}
						break;
					}
					IL_0127:
					num = 19;
					Application.OpenForms[num4].Close();
					goto IL_013c;
					IL_013c:
					num = 20;
					num4 = checked(num4 + 1);
					goto IL_0145;
					IL_0145:
					num5 = num4;
					num7 = num6;
					if (num5 <= num7)
					{
						goto IL_0127;
					}
					goto IL_014e;
					IL_01c9:
					num8 = num2 + 1;
					num2 = 0;
					switch (num8)
					{
					case 1:
						break;
					case 2:
						goto IL_0009;
					case 3:
						goto IL_002f;
					case 4:
						goto IL_0051;
					case 5:
						goto IL_006f;
					case 6:
						goto IL_0091;
					case 7:
						goto IL_00af;
					case 8:
						goto IL_00b8;
					case 9:
						goto IL_00c2;
					case 10:
						goto IL_00cd;
					case 13:
						goto IL_00d9;
					case 14:
						goto IL_00e1;
					case 15:
						goto IL_00eb;
					case 16:
						goto IL_00fa;
					case 17:
						goto IL_0109;
					case 18:
						goto IL_0112;
					case 19:
						goto IL_0127;
					case 20:
						goto IL_013c;
					case 11:
					case 12:
					case 21:
						goto IL_014e;
					case 23:
						goto end_IL_0001_2;
					default:
						goto end_IL_0001;
					case 22:
					case 24:
						goto end_IL_0001_3;
					}
					goto default;
					IL_0009:
					num = 2;
					Globals_Renamed.gblAuthorizedUser = ((ServerComputer)MyProject.Computer).FileSystem.FileExists(Application.StartupPath + "\\authorized.epa");
					goto IL_002f;
					IL_002f:
					num = 3;
					Common.MyConn.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Application.StartupPath + "\\ChmSteer.epa";
					goto IL_0051;
					IL_0051:
					num = 4;
					Common.MyConn.Open();
					goto IL_006f;
					IL_006f:
					num = 5;
					Common.gssConn.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Application.StartupPath + "\\scenarios.epa";
					goto IL_0091;
					IL_0091:
					num = 6;
					Common.gssConn.Open();
					goto IL_00af;
					IL_00af:
					num = 7;
					frmSplash2 = new frmSplash();
					goto IL_00b8;
					IL_00b8:
					num = 8;
					Application.Run((Form)(object)frmSplash2);
					goto IL_00c2;
					IL_00c2:
					num = 9;
					((Component)(object)frmSplash2).Dispose();
					goto IL_00cd;
					IL_00cd:
					num = 10;
					Globals_Renamed.gblOpenMainAgain = true;
					goto IL_014e;
					IL_014e:
					num = 12;
					if (!Globals_Renamed.gblOpenMainAgain)
					{
						goto end_IL_0001_3;
					}
					goto IL_00d9;
					IL_00d9:
					ProjectData.ClearProjectError();
					num3 = 3;
					goto IL_00e1;
					IL_00e1:
					num = 14;
					Globals_Renamed.gblOpenMainAgain = false;
					goto IL_00eb;
					IL_00eb:
					num = 15;
					((Form)frmMain.DefInstance).ShowDialog();
					goto IL_00fa;
					IL_00fa:
					num = 16;
					((Component)(object)frmMain.DefInstance).Dispose();
					goto IL_0109;
					IL_0109:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0112;
					IL_0112:
					num = 18;
					num6 = checked(((ReadOnlyCollectionBase)(object)Application.OpenForms).Count - 1);
					num4 = 0;
					goto IL_0145;
					end_IL_0001_2:
					break;
				}
				num = 23;
				string Eobject = "ChemStrB.Bas";
				string Efunction = "Main";
				ErrObject val = Information.Err();
				int Enumber = val.Number;
				ErrObject val2 = Information.Err();
				string Edescription = val2.Description;
				bool Econtact = true;
				Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
				val2.Description = Edescription;
				val.Number = Enumber;
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 571;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void resetExpBasedCriteria()
	{
		frmMain defInstance = frmMain.DefInstance;
		short num;
		checked
		{
			if (Operators.CompareString(defInstance.lblNumWMet[(short)4].Text, "Yes", false) == 0)
			{
				num = ((Operators.CompareString(defInstance.lblNumWMet[(short)0].Text, "Yes", false) == 0) ? ((short)1) : ((short)0));
				if (Operators.CompareString(defInstance.lblNumWMet[(short)1].Text, "Yes", false) == 0)
				{
					num++;
				}
				if ((Operators.CompareString(defInstance.lblNumWMet[(short)2].Text, "Yes", false) == 0) | (Operators.CompareString(defInstance.lblNumWMet[(short)3].Text, "Yes", false) == 0))
				{
					num++;
				}
			}
			else
			{
				num = 0;
			}
		}
		defInstance.lblExpBasedCriteria.Text = Conversions.ToString((int)num);
		Globals_Renamed.gblIWasChanged = true;
		defInstance = null;
	}

	public static void resetInhRespClass(ref object pOpIndex)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
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
						short num3 = 0;
						short num5;
						short num6;
						do
						{
							if (Globals_Renamed.arExpModels[1, num3, Conversions.ToInteger(pOpIndex)] > 0)
							{
								short num4 = (short)(Globals_Renamed.arExpModels[1, num3, Conversions.ToInteger(pOpIndex)] - 1);
								string text = Conversions.ToString(Operators.ConcatenateObject((object)(trtChemState(ref Globals_Renamed.arExpModChmSt[num4]) + " "), Interaction.IIf(Globals_Renamed.arSelActVolatile[num3, Conversions.ToInteger(pOpIndex)] == 0, (object)"(non-volatile)", (object)"(volatile)")));
								switch (Globals_Renamed.arExpModChmSt[num4])
								{
								case 3:
									Globals_Renamed.arExpModInhRC[0, num4] = text + " (Class I)";
									Globals_Renamed.arExpModInhRC[1, num4] = "NOTE: The respirator class is: I. Particulate (including solid or liquid droplets).";
									break;
								case 1:
									Globals_Renamed.arExpModInhRC[0, num4] = text + " (Class II)";
									Globals_Renamed.arExpModInhRC[1, num4] = "NOTE: The respirator class is: II. Gas/vapor (all substances in the gas form).";
									break;
								case 2:
								case 4:
									if (Globals_Renamed.arSelActVolatile[num3, Conversions.ToInteger(pOpIndex)] == 0)
									{
										Globals_Renamed.arExpModInhRC[0, num4] = text + " (Class I)";
										Globals_Renamed.arExpModInhRC[1, num4] = "NOTE: The respirator class is: I. Particulate (including solid or liquid droplets).";
									}
									else
									{
										Globals_Renamed.arExpModInhRC[0, num4] = text + " (Class III)";
										Globals_Renamed.arExpModInhRC[1, num4] = "NOTE: The respirator class is: III. Combination Gas/Vapor and Particulate (gas and liquid/solid physical forms are both present).";
									}
									break;
								default:
									Globals_Renamed.arExpModInhRC[0, num4] = "Error";
									Globals_Renamed.arExpModInhRC[1, num4] = "Error";
									break;
								}
								if ((Globals_Renamed.arExpModEst[0, 4, num4] > 1f) | (Globals_Renamed.arExpModEst[1, 4, num4] > 1f))
								{
									Globals_Renamed.arExpModInhRC[2, num4] = "Yes";
								}
								else
								{
									Globals_Renamed.arExpModInhRC[2, num4] = "No";
								}
								string text2 = frmMain.DefInstance.lblSATHR.Text;
								switch (text2)
								{
								case "2":
								case "2-3":
								case "3":
									if (true)
									{
										Globals_Renamed.arExpModInhRC[3, num4] = "Yes";
										break;
									}
									goto default;
								default:
									if (Operators.CompareString(text2, "", false) == 0)
									{
										Globals_Renamed.arExpModInhRC[3, num4] = "";
									}
									else
									{
										Globals_Renamed.arExpModInhRC[3, num4] = "No";
									}
									break;
								}
								if (Operators.CompareString(Globals_Renamed.arExpModInhRC[3, num4], "", false) == 0)
								{
									Globals_Renamed.arExpModInhRC[4, num4] = "";
								}
								else if ((Globals_Renamed.arExpModUncertainty[num4] == 1) & ((Operators.CompareString(Globals_Renamed.arExpModInhRC[2, num4], "Yes", false) == 0) | (Operators.CompareString(Globals_Renamed.arExpModInhRC[3, num4], "Yes", false) == 0)))
								{
									Globals_Renamed.arExpModInhRC[4, num4] = "Yes (both criteria met)";
								}
								else
								{
									Globals_Renamed.arExpModInhRC[4, num4] = "No";
								}
							}
							num3 = (short)unchecked(num3 + 1);
							num5 = num3;
							num6 = 24;
						}
						while (num5 <= num6);
						goto end_IL_0001;
					}
					case 940:
						num = -1;
						switch (num2)
						{
						case 2:
						{
							string Eobject = "ChemStrB.vb";
							string Efunction = "resetInhRespClass";
							ErrObject val = Information.Err();
							int Enumber = val.Number;
							ErrObject val2 = Information.Err();
							string Edescription = val2.Description;
							bool Econtact = true;
							Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
							val2.Description = Edescription;
							val.Number = Enumber;
							goto end_IL_0001;
						}
						}
						break;
					}
					goto IL_03e6;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 940;
				continue;
			}
			break;
			IL_03e6:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void SetCheck(ref string pValue, ref CheckBox pCheck)
	{
		if (Operators.CompareString(pValue, "Yes", false) == 0)
		{
			pCheck.CheckState = (CheckState)1;
		}
		else
		{
			pCheck.CheckState = (CheckState)0;
		}
	}

	public static void SetCombo(ref string pValue, ref ComboBox pCombo)
	{
		checked
		{
			short num = (short)(pCombo.Items.Count - 1);
			short num2 = 0;
			while (true)
			{
				short num3 = num2;
				short num4 = num;
				if (num3 <= num4)
				{
					if (Operators.CompareString(Support.GetItemString((Control)(object)pCombo, unchecked((int)num2)), pValue, false) == 0)
					{
						pCombo.SelectedIndex = num2;
						break;
					}
					num2 = (short)unchecked(num2 + 1);
					continue;
				}
				break;
			}
		}
	}

	public static string trtChemState(ref short pID)
	{
		return pID switch
		{
			1 => "Vapor", 
			2 => "Mist", 
			3 => "Particulate", 
			4 => "Aerosol", 
			11 => "Liquid", 
			12 => "Solid", 
			_ => "Error", 
		};
	}

	public static bool VerifyNumericTextBox(ref TextBox pTB, ref string pField)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if ((Strings.Len(pTB.Text) > 0) & !Versioned.IsNumeric((object)pTB.Text))
		{
			Interaction.Beep();
			((TextBoxBase)pTB).SelectionStart = 0;
			((TextBoxBase)pTB).SelectionLength = Strings.Len(pTB.Text);
			((Control)pTB).Focus();
			Interaction.MsgBox((object)("Please enter a valid " + pField + ".  This field is not required, but when it is specified, it must be numeric."), (MsgBoxStyle)64, (object)"Invalid Input");
			bool result = default(bool);
			return result;
		}
		return true;
	}

	public static bool VerifyReqNumericTextBox(ref TextBox pTB, ref string pField)
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		if (Versioned.IsNumeric((object)pTB.Text))
		{
			return true;
		}
		string text = ((Operators.CompareString(Strings.Right(pField, 1), ":", false) != 0) ? pField : Strings.Left(pField, checked(Strings.Len(pField) - 1)));
		Interaction.Beep();
		((TextBoxBase)pTB).SelectionStart = 0;
		((TextBoxBase)pTB).SelectionLength = Strings.Len(pTB.Text);
		((Control)pTB).Focus();
		Interaction.MsgBox((object)("Please enter a valid " + text + ".  This field is required and it must be numeric."), (MsgBoxStyle)64, (object)"Invalid Input");
		bool result = default(bool);
		return result;
	}

	public static void CloneFlexGrid(ref AxMSFlexGrid pGridCopy, ref AxMSFlexGrid pGridTo)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
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
						pGridTo.Rows = pGridCopy.Rows;
						pGridTo.Cols = pGridCopy.Cols;
						short num3 = (short)(pGridTo.Cols - 1);
						short num4 = 0;
						while (true)
						{
							short num5 = num4;
							short num6 = num3;
							if (num5 > num6)
							{
								break;
							}
							short num7 = (short)(pGridTo.Rows - 1);
							short num8 = 0;
							while (true)
							{
								short num9 = num8;
								num6 = num7;
								if (num9 > num6)
								{
									break;
								}
								unchecked
								{
									pGridTo[(int)num8, (int)num4] = pGridCopy[(int)num8, (int)num4];
								}
								num8 = (short)unchecked(num8 + 1);
							}
							unchecked
							{
								pGridTo[(int)num4] = pGridCopy[(int)num4];
								pGridTo[(int)num4] = pGridCopy[(int)num4];
							}
							num4 = (short)unchecked(num4 + 1);
						}
						pGridTo.FixedCols = pGridCopy.FixedCols;
						goto end_IL_0001;
					}
					case 260:
						num = -1;
						switch (num2)
						{
						case 2:
						{
							string Eobject = "ChemStrBas.Bas";
							string Efunction = "CloneFlexGrid";
							ErrObject val = Information.Err();
							int Enumber = val.Number;
							ErrObject val2 = Information.Err();
							string Edescription = val2.Description;
							bool Econtact = true;
							Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
							val2.Description = Edescription;
							val.Number = Enumber;
							goto end_IL_0001;
						}
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 260;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void SetComboBox(ref ComboBox pCombo, ref string pValue)
	{
		checked
		{
			short num = (short)(pCombo.Items.Count - 1);
			short num2 = 0;
			while (true)
			{
				short num3 = num2;
				short num4 = num;
				if (num3 > num4)
				{
					break;
				}
				if (Operators.CompareString(Support.GetItemString((Control)(object)pCombo, unchecked((int)num2)), pValue, false) == 0)
				{
					pCombo.SelectedIndex = num2;
					return;
				}
				num2 = (short)unchecked(num2 + 1);
			}
			pCombo.SelectedIndex = -1;
		}
	}

	public static void Clone3DArray(ref object pCopyArray, ref object pToArray, ref short pDim1, ref short pDim2, ref short pDim3)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
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
						short num3 = pDim1;
						short num4 = 0;
						while (true)
						{
							short num5 = num4;
							short num6 = num3;
							if (num5 > num6)
							{
								break;
							}
							short num7 = pDim2;
							short num8 = 0;
							while (true)
							{
								short num9 = num8;
								num6 = num7;
								if (num9 > num6)
								{
									break;
								}
								short num10 = pDim3;
								short num11 = 0;
								while (true)
								{
									short num12 = num11;
									num6 = num10;
									if (num12 > num6)
									{
										break;
									}
									NewLateBinding.LateIndexSet(pToArray, new object[4]
									{
										num4,
										num8,
										num11,
										RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(pCopyArray, new object[3] { num4, num8, num11 }, (string[])null))
									}, (string[])null);
									num11 = (short)unchecked(num11 + 1);
								}
								num8 = (short)unchecked(num8 + 1);
							}
							num4 = (short)unchecked(num4 + 1);
						}
						goto end_IL_0001;
					}
					case 297:
						num = -1;
						switch (num2)
						{
						case 2:
						{
							string Eobject = "ChemStrBas.Bas";
							string Efunction = "Clone3DArray";
							ErrObject val = Information.Err();
							int Enumber = val.Number;
							ErrObject val2 = Information.Err();
							string Edescription = val2.Description;
							bool Econtact = true;
							Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
							val2.Description = Edescription;
							val.Number = Enumber;
							goto end_IL_0001;
						}
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 297;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void Clone2DArray(ref object pCopyArray, ref object pToArray, ref short pDim1, ref short pDim2)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
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
						short num3 = pDim1;
						short num4 = 0;
						while (true)
						{
							short num5 = num4;
							short num6 = num3;
							if (num5 > num6)
							{
								break;
							}
							short num7 = pDim2;
							short num8 = 0;
							while (true)
							{
								short num9 = num8;
								num6 = num7;
								if (num9 > num6)
								{
									break;
								}
								NewLateBinding.LateIndexSet(pToArray, new object[3]
								{
									num4,
									num8,
									RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(pCopyArray, new object[2] { num4, num8 }, (string[])null))
								}, (string[])null);
								num8 = (short)unchecked(num8 + 1);
							}
							num4 = (short)unchecked(num4 + 1);
						}
						goto end_IL_0001;
					}
					case 237:
						num = -1;
						switch (num2)
						{
						case 2:
						{
							string Eobject = "ChemStrBas.Bas";
							string Efunction = "Clone2DArray";
							ErrObject val = Information.Err();
							int Enumber = val.Number;
							ErrObject val2 = Information.Err();
							string Edescription = val2.Description;
							bool Econtact = true;
							Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
							val2.Description = Edescription;
							val.Number = Enumber;
							goto end_IL_0001;
						}
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 237;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void Clone1DArray(ref object pCopyArray, ref object pToArray, ref short pDim1)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
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
						short num3 = pDim1;
						short num4 = 0;
						while (true)
						{
							short num5 = num4;
							short num6 = num3;
							if (num5 <= num6)
							{
								NewLateBinding.LateIndexSet(pToArray, new object[2]
								{
									num4,
									RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(pCopyArray, new object[1] { num4 }, (string[])null))
								}, (string[])null);
								num4 = (short)unchecked(num4 + 1);
								continue;
							}
							break;
						}
						goto end_IL_0001;
					}
					case 187:
						num = -1;
						switch (num2)
						{
						case 2:
						{
							string Eobject = "ChemStrBas.Bas";
							string Efunction = "Clone1DArray";
							ErrObject val = Information.Err();
							int Enumber = val.Number;
							ErrObject val2 = Information.Err();
							string Edescription = val2.Description;
							bool Econtact = true;
							Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
							val2.Description = Edescription;
							val.Number = Enumber;
							goto end_IL_0001;
						}
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 187;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static float ResetParmDefault(ref short pParmID, ref short pModType, ref short pActID, ref short pDualIndex, ref object pParmsV, ref short pModIndex)
	{
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num2 = default(int);
		short num3 = default(short);
		float num5 = default(float);
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
					Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
					Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
					Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
					Command command2 = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					ProjectData.ClearProjectError();
					num2 = 2;
					command.ActiveConnection = Common.MyConn;
					command.CommandText = "pqryGetParmDefault";
					command.CommandType = CommandTypeEnum.adCmdStoredProc;
					command.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, 0));
					command.Parameters.Append(command.CreateParameter("pModelID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, pModType));
					command.Parameters.Append(command.CreateParameter("pParmID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, pParmID));
					Command command3 = command;
					object RecordsAffected = Missing.Value;
					object Parameters = Missing.Value;
					recordset = command3.Execute(out RecordsAffected, ref Parameters);
					if (recordset.EOF)
					{
						recordset.Close();
						command2.ActiveConnection = Common.MyConn;
						command2.CommandText = "pqryGetParmDefault";
						command2.CommandType = CommandTypeEnum.adCmdStoredProc;
						command2.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, 0));
						command2.Parameters.Append(command.CreateParameter("pModelID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, 0));
						command2.Parameters.Append(command.CreateParameter("pParmID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, pParmID));
						Command command4 = command2;
						Parameters = Missing.Value;
						RecordsAffected = Missing.Value;
						recordset = command4.Execute(out Parameters, ref RecordsAffected);
						if (recordset.EOF)
						{
							Interaction.Beep();
							Interaction.MsgBox((object)("Database error in ChemStrB.ResetParmDefault, missing ParmDefault for Parm " + Globals_Renamed.arParmNames[pParmID] + ". Please take extra caution in ensuring the value of this parameter is correct."), (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
							Interaction.Beep();
						}
						else
						{
							num3 = Conversions.ToShort(recordset.Fields[0].Value);
						}
						command2 = null;
					}
					else
					{
						num3 = Conversions.ToShort(recordset.Fields[0].Value);
					}
					recordset.Close();
					recordset = null;
					command = null;
					short num4 = num3;
					switch (num4)
					{
					case -1101:
						num5 = GetParmDefaults.GetParmDefault1101(ref pActID);
						break;
					case -1102:
						num5 = GetParmDefaults.GetParmDefault1102(ref pActID);
						break;
					case -1104:
						num5 = GetParmDefaults.GetParmDefault1104(ref pActID);
						break;
					case -1105:
						num5 = GetParmDefaults.GetParmDefault1105(ref pActID);
						break;
					case -1106:
						num5 = GetParmDefaults.GetParmDefault1106(ref pActID);
						break;
					default:
						switch (num4)
						{
						case -1106:
							num5 = GetParmDefaults.GetParmDefault1106(ref pActID);
							break;
						case -1107:
							num5 = GetParmDefaults.GetParmDefault1107();
							break;
						case -1109:
							num5 = GetParmDefaults.GetParmDefault1109(ref pActID);
							break;
						case -1110:
							num5 = GetParmDefaults.GetParmDefault1110();
							break;
						case -1111:
							num5 = GetParmDefaults.GetParmDefault1111(ref pActID, ref pDualIndex);
							break;
						case -1112:
							num5 = GetParmDefaults.GetParmDefault1112(ref pActID);
							break;
						case -1114:
							num5 = GetParmDefaults.GetParmDefault1114(ref pActID);
							break;
						case -1115:
							num5 = GetParmDefaults.GetParmDefault1115(ref pActID);
							break;
						case -2101:
							num5 = GetParmDefaults.GetParmDefault2101(ref pActID);
							break;
						case -2102:
							num5 = GetParmDefaults.GetParmDefault2102(ref pActID);
							break;
						case -2103:
							num5 = GetParmDefaults.GetParmDefault2103(ref pActID);
							break;
						case -2104:
							num5 = GetParmDefaults.GetParmDefault2104(ref pActID);
							break;
						case -2105:
						{
							short pModIndex2 = -1;
							num5 = GetParmDefaults.GetParmDefault2105(ref pActID, ref pModIndex2, ref pDualIndex);
							break;
						}
						case -2106:
							num5 = GetParmDefaults.GetParmDefault2106(ref pActID);
							break;
						case -2107:
							num5 = GetParmDefaults.GetParmDefault2107(ref pActID);
							break;
						case -2108:
							num5 = GetParmDefaults.GetParmDefault2108(ref pActID);
							break;
						case -2109:
							num5 = GetParmDefaults.GetParmDefault2109(ref pModType, ref pDualIndex);
							break;
						case -2110:
							num5 = GetParmDefaults.GetParmDefault2110();
							break;
						case -2111:
							num5 = GetParmDefaults.GetParmDefault2111(ref pActID);
							break;
						case -3103:
						{
							short pModIndex2 = 0;
							num5 = GetParmDefaults.GetParmDefault3103(ref pModIndex2, ref pDualIndex);
							break;
						}
						case -3110:
							num5 = GetParmDefaults.GetParmDefault3110(ref pDualIndex);
							break;
						case -3111:
							num5 = GetParmDefaults.GetParmDefault3111(ref pDualIndex);
							break;
						case -3112:
							num5 = GetParmDefaults.GetParmDefault3112(ref pDualIndex);
							break;
						case -3113:
							num5 = GetParmDefaults.GetParmDefault3113(ref pDualIndex);
							break;
						case -3114:
							num5 = GetParmDefaults.GetParmDefault3114();
							break;
						case -3115:
							num5 = GetParmDefaults.GetParmDefault3115();
							break;
						case -3121:
							num5 = GetParmDefaults.GetParmDefault3121(ref pDualIndex);
							break;
						case -3122:
							num5 = GetParmDefaults.GetParmDefault3122(ref pModIndex, ref pDualIndex);
							break;
						case -3123:
							num5 = GetParmDefaults.GetParmDefault3123();
							break;
						case -3124:
							num5 = GetParmDefaults.GetParmDefault3124();
							break;
						case -3125:
							num5 = GetParmDefaults.GetParmDefault3125();
							break;
						case -3126:
							num5 = GetParmDefaults.GetParmDefault3126();
							break;
						case -3128:
							num5 = GetParmDefaults.GetParmDefault3128();
							break;
						default:
							num5 = num3;
							break;
						}
						break;
					}
					goto end_IL_0001;
				}
				case 1760:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						string Eobject = "ChemSteer.Bas";
						string Efunction = "ResetParmDefault";
						ErrObject val = Information.Err();
						int Enumber = val.Number;
						ErrObject val2 = Information.Err();
						string Edescription = val2.Description;
						bool Econtact = true;
						Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
						val2.Description = Edescription;
						val.Number = Enumber;
						goto end_IL_0001;
					}
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 1760;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		float result = num5;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static bool ValidateParmInput(ref short pID, ref object pValue, [Optional][DefaultParameterValue(0)] ref short pModType)
	{
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0534: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_056d: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		short num = pID;
		if ((num == 44 || num == 51 || num == 53 || num == 126 || num == 125 || num == 124 || num == 35 || num == 131 || num == 139) ? true : false)
		{
			if (!(Conversions.ToDouble(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(pValue))) <= 0.0))
			{
				goto IL_00f1;
			}
			Interaction.Beep();
			Interaction.MsgBox((object)("Invalid number. " + Globals_Renamed.arParmNames[pID] + " must be greater than zero."), (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
		}
		else
		{
			if (!(Conversions.ToDouble(pValue) < 0.0))
			{
				goto IL_00f1;
			}
			Interaction.Beep();
			Interaction.MsgBox((object)("Invalid number. " + Globals_Renamed.arParmNames[pID] + " must be greater than or equal to zero."), (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
		}
		goto IL_05e0;
		IL_00f1:
		switch (pID)
		{
		case 61:
			if (Conversions.ToBoolean(Operators.AndObject((object)(pModType == 21), Operators.CompareObjectGreater(pValue, (object)54, false))))
			{
				Interaction.Beep();
				Interaction.MsgBox((object)"The model should be used for Amounts <= 54 kg/site-day.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
				break;
			}
			goto default;
		case 92:
			if (pModType == 21 && Operators.ConditionalCompareObjectGreater(pValue, (object)54, false))
			{
				Interaction.Beep();
				Interaction.MsgBox((object)"The Small Volume Handling Inhalation Model should only be used for Amounts less than 54 kg/site-day.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
			}
			goto default;
		case 44:
			if (Operators.ConditionalCompareObjectGreater(pValue, (object)7.9, false))
			{
				Interaction.Beep();
				Interaction.MsgBox((object)(Globals_Renamed.arParmNames[pID] + " must be greater than or equal to zero and less than or equal to 7.9. Please correct this parameter."), (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
				break;
			}
			goto default;
		case 72:
		case 75:
		case 105:
			if (Operators.ConditionalCompareObjectGreater(pValue, (object)365, false))
			{
				Interaction.Beep();
				Interaction.MsgBox((object)"Frequency must be less than 365.  Please enter a valid Frequency.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
				break;
			}
			goto default;
		case 60:
			if (Strings.InStr(Conversions.ToString(pValue), ".", (CompareMethod)0) > 0)
			{
				Interaction.Beep();
				Interaction.MsgBox((object)"Frequency of events must be an integer. Please correct this parameter.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
				break;
			}
			if (Operators.ConditionalCompareObjectGreater(pValue, (object)1, false))
			{
				Interaction.Beep();
				Interaction.MsgBox((object)"The value of FT should not exceed 1 unless the chemical assessed is highly volatile or has a high rate of absorption. See the Note on FT in the Help System topic for any dermal model for more information on this issue.", (MsgBoxStyle)64, (object)"Parm Validation");
				_0024STATIC_0024ValidateParmInput_0024032106101C106_0024PrevPvalue = Conversions.ToSingle(pValue);
			}
			goto default;
		case 35:
		case 46:
			if (Operators.ConditionalCompareObjectGreater(pValue, (object)24, false))
			{
				Interaction.Beep();
				Interaction.MsgBox((object)(Globals_Renamed.arParmNames[pID] + " must be greater than or equal to zero and less than or equal to 24. Please correct this parameter."), (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
				break;
			}
			goto default;
		case 40:
		case 43:
		case 51:
		case 117:
		case 118:
		case 119:
		case 120:
		case 127:
		case 128:
		case 129:
		case 131:
		case 139:
		case 142:
			if (Operators.ConditionalCompareObjectGreater(pValue, (object)1, false))
			{
				Interaction.Beep();
				Interaction.MsgBox((object)(Globals_Renamed.arParmNames[pID] + " must be greater than or equal to zero and less than or equal to 1. Please correct this parameter."), (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
				break;
			}
			goto default;
		case 82:
			if (Operators.ConditionalCompareObjectGreaterEqual(pValue, (object)3, false))
			{
				Interaction.Beep();
				Interaction.MsgBox((object)"Shifts must be less than 3.  Please correct this parameter.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
				break;
			}
			goto default;
		case 9:
		case 10:
		case 59:
		case 68:
		case 76:
		case 77:
		case 78:
		case 96:
		case 113:
		case 124:
			if (Operators.ConditionalCompareObjectGreater(pValue, (object)1, false))
			{
				Interaction.Beep();
				Interaction.MsgBox((object)"Weight Fraction must be less than or equal to 1.  Please enter a valid Weight Fraction.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
				break;
			}
			goto default;
		case 144:
			if (Operators.ConditionalCompareObjectGreater(pValue, (object)1, false))
			{
				Interaction.Beep();
				Interaction.MsgBox((object)"Solids Removal Efficiency must be less than or equal to 1.  Please enter a valid value.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
				break;
			}
			goto default;
		default:
			return true;
		}
		goto IL_05e0;
		IL_05e0:
		bool result = default(bool);
		return result;
	}

	public static float GetModelDefault(short pDS, short pParmID, ref short pModType, ref short pActID, ref short pModelIndex, ref short pDualIndex)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		float num3 = default(float);
		float num4 = default(float);
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
					Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
					Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
					Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					if (pDS == -1000)
					{
						num3 = Globals_Renamed.arOpParms[pParmID, Globals_Renamed.intOpIndex];
					}
					else if (pDS > -1299 && pDS < -1200)
					{
						checked
						{
							num3 = Globals_Renamed.arContParms[Math.Abs((short)unchecked(pDS - -1200)), Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex];
						}
					}
					else if ((pDS == -1101) & Versioned.IsNumeric((object)frmMain.DefInstance.lblVP.Text))
					{
						num3 = Conversions.ToSingle(frmMain.DefInstance.lblVP.Text);
					}
					else if ((pDS == -1102) & Versioned.IsNumeric((object)frmMain.DefInstance.lblMW.Text))
					{
						num3 = Conversions.ToSingle(frmMain.DefInstance.lblMW.Text);
					}
					else if ((pDS == -1103) & Versioned.IsNumeric((object)frmMain.DefInstance.lblDchem.Text))
					{
						num3 = Conversions.ToSingle(frmMain.DefInstance.lblDchem.Text);
					}
					else if ((pDS == -1104) & Versioned.IsNumeric((object)frmMain.DefInstance.lblSol.Text))
					{
						num3 = Conversions.ToSingle(frmMain.DefInstance.lblSol.Text);
					}
					else if (pDS == 999)
					{
						num3 = 0f;
					}
					else
					{
						command.ActiveConnection = Common.MyConn;
						command.CommandText = "pqryGetParmDefault";
						command.CommandType = CommandTypeEnum.adCmdStoredProc;
						if (pDS == -1300)
						{
							command.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, 0));
							command.Parameters.Append(command.CreateParameter("pModelID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, 0));
							command.Parameters.Append(command.CreateParameter("pParmID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, pParmID));
							Command command2 = command;
							object RecordsAffected = Missing.Value;
							object Parameters = Missing.Value;
							recordset = command2.Execute(out RecordsAffected, ref Parameters);
							if (!recordset.EOF)
							{
								num4 = Conversions.ToSingle(recordset.Fields[0].Value);
							}
							recordset.Close();
						}
						else if (pDS == -1302)
						{
							command.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, 0));
							command.Parameters.Append(command.CreateParameter("pModelID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, pModType));
							command.Parameters.Append(command.CreateParameter("pParmID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, pParmID));
							Command command3 = command;
							object Parameters = Missing.Value;
							object RecordsAffected = Missing.Value;
							recordset = command3.Execute(out Parameters, ref RecordsAffected);
							if (!recordset.EOF)
							{
								num4 = Conversions.ToSingle(recordset.Fields[0].Value);
							}
							recordset.Close();
						}
						else
						{
							if (pDS != -1301)
							{
								goto end_IL_0001;
							}
							command.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, pActID));
							command.Parameters.Append(command.CreateParameter("pModelID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, 0));
							command.Parameters.Append(command.CreateParameter("pParmID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, pParmID));
							Command command4 = command;
							object Parameters = Missing.Value;
							object RecordsAffected = Missing.Value;
							recordset = command4.Execute(out Parameters, ref RecordsAffected);
							if (!recordset.EOF)
							{
								num4 = Conversions.ToSingle(recordset.Fields[0].Value);
							}
							recordset.Close();
						}
						command.Parameters.Delete("pActID");
						command.Parameters.Delete("pModelID");
						command.Parameters.Delete("pParmID");
						switch (pParmID)
						{
						case 4:
						case 9:
						case 22:
						case 26:
						case 31:
						case 37:
						case 40:
						case 43:
						case 45:
						case 46:
						case 51:
						case 52:
						case 53:
						case 55:
						case 56:
						case 57:
						case 59:
						case 61:
						case 62:
						case 72:
						case 73:
						case 74:
						case 75:
						case 76:
						case 77:
						case 78:
						case 81:
						case 91:
						case 92:
						case 96:
						case 113:
						case 137:
						case 141:
						case 142:
						{
							float num5 = num4;
							if (num5 == -1101f)
							{
								num3 = GetParmDefaults.GetParmDefault1101(ref pActID);
							}
							else if (num5 == -1102f)
							{
								num3 = GetParmDefaults.GetParmDefault1102(ref pActID);
							}
							else if (num5 == -1103f)
							{
								num3 = GetParmDefaults.GetParmDefault1103(ref pParmID, ref pActID, ref Globals_Renamed.intActIndex, ref pModelIndex, ref pDualIndex);
							}
							else if (num5 == -1104f)
							{
								num3 = GetParmDefaults.GetParmDefault1104(ref pActID);
							}
							else if (num5 == -1105f)
							{
								num3 = GetParmDefaults.GetParmDefault1105(ref pActID);
							}
							else if (num5 == -1106f)
							{
								num3 = GetParmDefaults.GetParmDefault1106(ref pActID);
							}
							else if (num5 == -1107f)
							{
								num3 = GetParmDefaults.GetParmDefault1107();
							}
							else if (num5 == -1108f)
							{
								num3 = GetParmDefaults.GetParmDefault1108(ref pActID);
							}
							else if (num5 == -1109f)
							{
								num3 = GetParmDefaults.GetParmDefault1109(ref pActID);
							}
							else if (num5 == -1110f)
							{
								num3 = GetParmDefaults.GetParmDefault1110();
							}
							else if (num5 == -1111f)
							{
								num3 = GetParmDefaults.GetParmDefault1111(ref pActID, ref pDualIndex);
							}
							else if (num5 == -1112f)
							{
								num3 = GetParmDefaults.GetParmDefault1112(ref pActID);
							}
							else if (num5 == -1114f)
							{
								num3 = GetParmDefaults.GetParmDefault1114(ref pActID);
							}
							else if (num5 == -1115f)
							{
								num3 = GetParmDefaults.GetParmDefault1115(ref pActID);
							}
							else if (num5 == -2101f)
							{
								num3 = GetParmDefaults.GetParmDefault2101(ref pActID);
							}
							else if (num5 == -2102f)
							{
								num3 = GetParmDefaults.GetParmDefault2102(ref pActID);
							}
							else if (num5 == -2103f)
							{
								num3 = GetParmDefaults.GetParmDefault2103(ref pActID);
							}
							else if (num5 == -2104f)
							{
								num3 = GetParmDefaults.GetParmDefault2104(ref pActID);
							}
							else if (num5 == -2105f)
							{
								num3 = GetParmDefaults.GetParmDefault2105(ref pActID, ref pModelIndex, ref pDualIndex);
							}
							else if (num5 == -2106f)
							{
								num3 = GetParmDefaults.GetParmDefault2106(ref pActID);
							}
							else if (num5 == -2107f)
							{
								num3 = GetParmDefaults.GetParmDefault2107(ref pActID);
							}
							else if (num5 == -2108f)
							{
								num3 = GetParmDefaults.GetParmDefault2108(ref pActID);
							}
							else if (num5 == -2109f)
							{
								num3 = GetParmDefaults.GetParmDefault2109(ref pModType, ref pDualIndex);
							}
							else if (num5 == -2110f)
							{
								num3 = GetParmDefaults.GetParmDefault2110();
							}
							else if (num5 == -2111f)
							{
								num3 = GetParmDefaults.GetParmDefault2111(ref pActID);
							}
							else if (num5 == -2112f)
							{
								num3 = GetParmDefaults.GetParmDefault2112(ref pActID);
							}
							else if (num5 == -2113f)
							{
								num3 = GetParmDefaults.GetParmDefault2113(ref pActID);
							}
							else if (num5 == -3101f)
							{
								num3 = GetParmDefaults.GetParmDefault3101(ref pActID, ref pDualIndex);
							}
							else if (num5 == -3102f)
							{
								num3 = GetParmDefaults.GetParmDefault3102(ref pActID, ref pModType);
							}
							else if (num5 == -3103f)
							{
								num3 = GetParmDefaults.GetParmDefault3103(ref pModelIndex, ref pDualIndex);
							}
							else if (num5 == -3104f)
							{
								num3 = GetParmDefaults.GetParmDefault3104(ref pActID, ref pDualIndex);
							}
							else if (num5 == -3105f)
							{
								object Parameters = Globals_Renamed.arRelModParmsV;
								float parmDefault = GetParmDefaults.GetParmDefault3105(ref pModelIndex, ref pDualIndex, ref Parameters);
								Globals_Renamed.arRelModParmsV = (float[,,])Parameters;
								num3 = parmDefault;
							}
							else if (num5 == -3106f)
							{
								num3 = GetParmDefaults.GetParmDefault3106(ref pDualIndex);
							}
							else if (num5 == -3107f)
							{
								num3 = GetParmDefaults.GetParmDefault3107(ref pParmID, ref pDualIndex, ref pModType);
							}
							else if (num5 == -3108f)
							{
								num3 = GetParmDefaults.GetParmDefault3108();
							}
							else if (num5 == -3109f)
							{
								num3 = GetParmDefaults.GetParmDefault3109(ref pDualIndex);
							}
							else if (num5 == -3110f)
							{
								num3 = GetParmDefaults.GetParmDefault3110(ref pDualIndex);
							}
							else if (num5 == -3111f)
							{
								num3 = GetParmDefaults.GetParmDefault3111(ref pDualIndex);
							}
							else if (num5 == -3112f)
							{
								num3 = GetParmDefaults.GetParmDefault3112(ref pDualIndex);
							}
							else if (num5 == -3113f)
							{
								num3 = GetParmDefaults.GetParmDefault3113(ref pDualIndex);
							}
							else if (num5 == -3114f)
							{
								num3 = GetParmDefaults.GetParmDefault3114();
							}
							else if (num5 == -3115f)
							{
								num3 = GetParmDefaults.GetParmDefault3115();
							}
							else if (num5 == -3116f)
							{
								num3 = GetParmDefaults.GetParmDefault3116(ref pActID, ref pDualIndex);
							}
							else if (num5 == -3117f)
							{
								num3 = GetParmDefaults.GetParmDefault3117(ref pActID, ref pDualIndex);
							}
							else if (num5 == -3118f)
							{
								num3 = GetParmDefaults.GetParmDefault3118(ref pDualIndex);
							}
							else if (num5 == -3119f)
							{
								num3 = GetParmDefaults.GetParmDefault3119(ref pModType, ref pDualIndex);
							}
							else if (num5 == -3120f)
							{
								num3 = GetParmDefaults.GetParmDefault3120(ref pDualIndex);
							}
							else if (num5 == -3121f)
							{
								num3 = GetParmDefaults.GetParmDefault3121(ref pDualIndex);
							}
							else if (num5 == -3122f)
							{
								num3 = GetParmDefaults.GetParmDefault3122(ref pModelIndex, ref pDualIndex);
							}
							else if (num5 == -3123f)
							{
								num3 = GetParmDefaults.GetParmDefault3123();
							}
							else if (num5 == -3124f)
							{
								num3 = GetParmDefaults.GetParmDefault3124();
							}
							else if (num5 == -3125f)
							{
								num3 = GetParmDefaults.GetParmDefault3125();
							}
							else if (num5 == -3126f)
							{
								num3 = GetParmDefaults.GetParmDefault3126();
							}
							else if (num5 == -3127f)
							{
								num3 = GetParmDefaults.GetParmDefault3127();
							}
							else if (num5 == -3128f)
							{
								num3 = GetParmDefaults.GetParmDefault3128();
							}
							else if (num5 != -3130f && num5 != -3131f)
							{
								num3 = num4;
							}
							break;
						}
						case 131:
						case 132:
						case 133:
						case 134:
						case 138:
						case 139:
							num3 = Globals_Renamed.arOpParms[pParmID, Globals_Renamed.intOpIndex];
							break;
						default:
							num3 = num4;
							break;
						}
					}
					recordset = null;
					command = null;
					goto end_IL_0001;
				}
				case 3472:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						string Eobject = "ChemStrBas.Bas";
						string Efunction = "GetModelDefault";
						ErrObject val = Information.Err();
						int Enumber = val.Number;
						ErrObject val2 = Information.Err();
						string Edescription = val2.Description;
						bool Econtact = true;
						Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
						val2.Description = Edescription;
						val.Number = Enumber;
						goto end_IL_0001;
					}
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 3472;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		float result = num3;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static void SetExpModelDefaults(ref short pModType, ref short pModIndex, ref short pActID, ref short pPcat)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
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
					Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
					Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
					Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					bool[] array = new bool[5];
					ProjectData.ClearProjectError();
					num2 = 2;
					recordset.CursorLocation = CursorLocationEnum.adUseClient;
					recordset.Open("SELECT * FROM qryGetParms" + Strings.Right("0" + Conversions.ToString((int)pPcat), 2), Common.MyConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
					checked
					{
						short num4;
						while (!recordset.EOF)
						{
							if (Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(recordset.Fields["DefaultSource"].Value)))
							{
								object value = recordset.Fields["ParmID"].Value;
								if (Operators.ConditionalCompareObjectEqual(value, (object)(short)61, false))
								{
									short pDualIndex = 0;
									short num3;
									do
									{
										Globals_Renamed.arExpModParmsVC[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = (short)Math.Round(GetModelDefault(Conversions.ToShort(recordset.Fields["DefaultSource"].Value), Conversions.ToShort(recordset.Fields["ParmID"].Value), ref pModType, ref pActID, ref pModIndex, ref pDualIndex));
										Globals_Renamed.arExpModParmsV[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = 0f;
										Globals_Renamed.arExpModParmsT[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = Conversions.ToShort(recordset.Fields["Type"].Value);
										pDualIndex = (short)unchecked(pDualIndex + 1);
										num3 = pDualIndex;
										num4 = 1;
									}
									while (num3 <= num4);
									array[0] = true;
								}
								else if (Operators.ConditionalCompareObjectEqual(value, (object)(short)75, false))
								{
									short pDualIndex = 0;
									short num5;
									do
									{
										Globals_Renamed.arExpModParmsV[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = GetModelDefault(Conversions.ToShort(recordset.Fields["DefaultSource"].Value), Conversions.ToShort(recordset.Fields["ParmID"].Value), ref pModType, ref pActID, ref pModIndex, ref pDualIndex);
										if (Globals_Renamed.arExpModParmsV[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] < 0f)
										{
											Globals_Renamed.arExpModParmsVC[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = (short)Math.Round(Math.Abs(Globals_Renamed.arExpModParmsV[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex]));
											Globals_Renamed.arExpModParmsV[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = 0f;
										}
										else
										{
											Globals_Renamed.arExpModParmsVC[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = 998;
										}
										Globals_Renamed.arExpModParmsT[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = Conversions.ToShort(recordset.Fields["Type"].Value);
										pDualIndex = (short)unchecked(pDualIndex + 1);
										num5 = pDualIndex;
										num4 = 1;
									}
									while (num5 <= num4);
									array[1] = true;
								}
								else if (Conversions.ToBoolean((Conversions.ToBoolean(Operators.CompareObjectEqual(value, (object)(short)77, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(value, (object)(short)76, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(value, (object)(short)59, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(value, (object)(short)78, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(value, (object)(short)94, false))) ? ((object)true) : ((object)false)))
								{
									short pDualIndex = 0;
									short num6;
									do
									{
										Globals_Renamed.arExpModParmsVC[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = (short)Math.Round(GetModelDefault(Conversions.ToShort(recordset.Fields["DefaultSource"].Value), Conversions.ToShort(recordset.Fields["ParmID"].Value), ref pModType, ref pActID, ref pModIndex, ref pDualIndex));
										Globals_Renamed.arExpModParmsV[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = 0f;
										Globals_Renamed.arExpModParmsT[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = Conversions.ToShort(recordset.Fields["Type"].Value);
										pDualIndex = (short)unchecked(pDualIndex + 1);
										num6 = pDualIndex;
										num4 = 1;
									}
									while (num6 <= num4);
									array[2] = true;
								}
								else if (Operators.ConditionalCompareObjectEqual(value, (object)(short)40, false))
								{
									short pDualIndex = 0;
									short num7;
									do
									{
										Globals_Renamed.arExpModParmsV[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = GetModelDefault(Conversions.ToShort(recordset.Fields["DefaultSource"].Value), Conversions.ToShort(recordset.Fields["ParmID"].Value), ref pModType, ref pActID, ref pModIndex, ref pDualIndex);
										if (Globals_Renamed.arExpModParmsV[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] < 0f)
										{
											Globals_Renamed.arExpModParmsVC[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = (short)Math.Round(Math.Abs(Globals_Renamed.arExpModParmsV[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex]));
											Globals_Renamed.arExpModParmsV[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = 0f;
										}
										else
										{
											Globals_Renamed.arExpModParmsVC[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = 998;
										}
										Globals_Renamed.arExpModParmsT[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = Conversions.ToShort(recordset.Fields["Type"].Value);
										pDualIndex = (short)unchecked(pDualIndex + 1);
										num7 = pDualIndex;
										num4 = 1;
									}
									while (num7 <= num4);
									array[3] = true;
								}
								else if (Operators.ConditionalCompareObjectEqual(value, (object)(short)64, false))
								{
									if (pModType == 54)
									{
										short pDualIndex = 0;
										short num8;
										do
										{
											Globals_Renamed.arExpModParmsV[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = GetModelDefault(Conversions.ToShort(recordset.Fields["DefaultSource"].Value), Conversions.ToShort(recordset.Fields["ParmID"].Value), ref pModType, ref pActID, ref pModIndex, ref pDualIndex);
											Globals_Renamed.arExpModParmsT[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = Conversions.ToShort(recordset.Fields["Type"].Value);
											if ((Globals_Renamed.arExpModParmsV[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] == -1f) & (Globals_Renamed.arExpModParmsT[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] == 1))
											{
												Globals_Renamed.arExpModParmsVC[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = 999;
												Globals_Renamed.arExpModParmsV[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = 0f;
											}
											else
											{
												Globals_Renamed.arExpModParmsVC[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = Conversions.ToShort(recordset.Fields["DefaultSource"].Value);
											}
											pDualIndex = (short)unchecked(pDualIndex + 1);
											num8 = pDualIndex;
											num4 = 1;
										}
										while (num8 <= num4);
									}
									else
									{
										short pDualIndex = 0;
										short num9;
										do
										{
											Globals_Renamed.arExpModParmsV[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = GetModelDefault(Conversions.ToShort(recordset.Fields["DefaultSource"].Value), Conversions.ToShort(recordset.Fields["ParmID"].Value), ref pModType, ref pActID, ref pModIndex, ref pDualIndex);
											Globals_Renamed.arExpModParmsT[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = Conversions.ToShort(recordset.Fields["Type"].Value);
											if ((Globals_Renamed.arExpModParmsV[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] == -1f) & (Globals_Renamed.arExpModParmsT[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] == 1))
											{
												Globals_Renamed.arExpModParmsVC[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = 999;
												Globals_Renamed.arExpModParmsV[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = 0f;
											}
											else
											{
												Globals_Renamed.arExpModParmsVC[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = Conversions.ToShort(recordset.Fields["DefaultSource"].Value);
											}
											pDualIndex = (short)unchecked(pDualIndex + 1);
											num9 = pDualIndex;
											num4 = 1;
										}
										while (num9 <= num4);
									}
								}
								else
								{
									short pDualIndex = 0;
									short num10;
									do
									{
										Globals_Renamed.arExpModParmsV[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = GetModelDefault(Conversions.ToShort(recordset.Fields["DefaultSource"].Value), Conversions.ToShort(recordset.Fields["ParmID"].Value), ref pModType, ref pActID, ref pModIndex, ref pDualIndex);
										Globals_Renamed.arExpModParmsT[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = Conversions.ToShort(recordset.Fields["Type"].Value);
										if ((Globals_Renamed.arExpModParmsV[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] == -1f) & (Globals_Renamed.arExpModParmsT[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] == 1))
										{
											Globals_Renamed.arExpModParmsVC[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = 999;
											Globals_Renamed.arExpModParmsV[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = 0f;
										}
										else
										{
											Globals_Renamed.arExpModParmsVC[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = Conversions.ToShort(recordset.Fields["DefaultSource"].Value);
										}
										pDualIndex = (short)unchecked(pDualIndex + 1);
										num10 = pDualIndex;
										num4 = 1;
									}
									while (num10 <= num4);
								}
							}
							recordset.MoveNext();
						}
						recordset.Close();
						command.ActiveConnection = Common.MyConn;
						command.CommandText = "pqryGetSubParms";
						command.CommandType = CommandTypeEnum.adCmdStoredProc;
						short num11 = 0;
						short num13;
						do
						{
							if (array[num11])
							{
								command.Parameters.Append(command.CreateParameter("pSubCode", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, num11 + 140));
								Command command2 = command;
								object RecordsAffected = Missing.Value;
								object Parameters = Missing.Value;
								recordset = command2.Execute(out RecordsAffected, ref Parameters);
								command.Parameters.Delete("pSubCode");
								while (!recordset.EOF)
								{
									short pDualIndex = 0;
									short num12;
									do
									{
										Globals_Renamed.arExpModParmsV[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = GetModelDefault(Conversions.ToShort(recordset.Fields["DefaultSource"].Value), Conversions.ToShort(recordset.Fields["ParmID"].Value), ref pModType, ref pActID, ref pModIndex, ref pDualIndex);
										Globals_Renamed.arExpModParmsT[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = Conversions.ToShort(recordset.Fields["Type"].Value);
										if ((Globals_Renamed.arExpModParmsV[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] == -1f) & (Globals_Renamed.arExpModParmsT[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] == 1))
										{
											Globals_Renamed.arExpModParmsVC[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = 999;
											Globals_Renamed.arExpModParmsV[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = 0f;
										}
										else
										{
											Globals_Renamed.arExpModParmsVC[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = Conversions.ToShort(recordset.Fields["DefaultSource"].Value);
										}
										pDualIndex = (short)unchecked(pDualIndex + 1);
										num12 = pDualIndex;
										num4 = 1;
									}
									while (num12 <= num4);
									recordset.MoveNext();
								}
								recordset.Close();
							}
							num11 = (short)unchecked(num11 + 1);
							num13 = num11;
							num4 = 3;
						}
						while (num13 <= num4);
						recordset = null;
						command = null;
						goto end_IL_0001;
					}
				}
				case 3893:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						string Eobject = "ChemStrBas.Bas";
						string Efunction = "SetExpModelDefaults";
						ErrObject val = Information.Err();
						int Enumber = val.Number;
						ErrObject val2 = Information.Err();
						string Edescription = val2.Description;
						bool Econtact = true;
						Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
						val2.Description = Edescription;
						val.Number = Enumber;
						goto end_IL_0001;
					}
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 3893;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void SetRelModelDefaults(ref short pModType, ref short pModIndex, ref short pActID, ref short pPcat)
	{
		int try0001_dispatch = -1;
		int num = default(int);
		Recordset recordset = default(Recordset);
		int num2 = default(int);
		int num3 = default(int);
		short pDualIndex = default(short);
		Recordset recordset2 = default(Recordset);
		Command command = default(Command);
		bool[] array = default(bool[]);
		short z = default(short);
		short num7 = default(short);
		object value = default(object);
		object value2 = default(object);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					int num4;
					string Eobject;
					string Efunction;
					ErrObject val;
					int Enumber;
					ErrObject val2;
					string Edescription;
					bool Econtact;
					short num5;
					Guid clsid;
					Command command2;
					object RecordsAffected;
					object Parameters;
					short num8;
					short num9;
					short pDualIndex2;
					short num10;
					short num11;
					short num12;
					short num13;
					short num6;
					switch (try0001_dispatch)
					{
					default:
						num = 1;
						clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
						recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						goto IL_0023;
					case 3972:
						{
							num2 = num;
							switch ((num3 <= -2) ? 1 : num3)
							{
							case 2:
								break;
							case 1:
								goto IL_0d66;
							default:
								goto end_IL_0001;
							}
							goto IL_0ce4;
						}
						IL_0744:
						num = 55;
						goto IL_0749;
						IL_0749:
						num = 56;
						Globals_Renamed.arRelModParmsVC[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = Conversions.ToShort(recordset.Fields["DefaultSource"].Value);
						goto IL_078f;
						IL_0712:
						num = 53;
						Globals_Renamed.arRelModParmsV[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = 0f;
						goto IL_078f;
						IL_0d66:
						num4 = unchecked(num2 + 1);
						goto IL_0d6a;
						IL_0ce4:
						num = 129;
						Eobject = "ChemStrBas.Bas";
						Efunction = "SetModelDefaults";
						val = Information.Err();
						Enumber = val.Number;
						val2 = Information.Err();
						Edescription = val2.Description;
						Econtact = true;
						Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
						val2.Description = Edescription;
						val.Number = Enumber;
						goto IL_0d40;
						IL_0d40:
						num = 130;
						ProjectData.ClearProjectError();
						if (num2 == 0)
						{
							throw ProjectData.CreateProjectError(-2146828268);
						}
						num4 = num2;
						goto IL_0d6a;
						IL_078f:
						num = 58;
						pDualIndex = (short)unchecked(pDualIndex + 1);
						num5 = pDualIndex;
						num6 = 1;
						if (num5 <= num6)
						{
							goto IL_05d1;
						}
						goto IL_07a6;
						IL_07a6:
						num = 61;
						recordset.MoveNext();
						goto IL_07b2;
						IL_0d6a:
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0023;
						case 3:
							goto IL_0046;
						case 4:
							goto IL_0068;
						case 5:
							goto IL_0072;
						case 6:
							goto IL_007a;
						case 7:
							goto IL_0097;
						case 8:
							goto IL_00a2;
						case 11:
							goto IL_00da;
						case 12:
							goto IL_0106;
						case 14:
						case 15:
							goto IL_0122;
						case 16:
							goto IL_013f;
						case 17:
							goto IL_0145;
						case 18:
							goto IL_01b5;
						case 19:
							goto IL_01e5;
						case 20:
							goto IL_022a;
						case 21:
							goto IL_023f;
						case 23:
							goto IL_024c;
						case 24:
							goto IL_0269;
						case 25:
							goto IL_026f;
						case 26:
							goto IL_02df;
						case 27:
							goto IL_030f;
						case 28:
							goto IL_0354;
						case 29:
							goto IL_0369;
						case 31:
							goto IL_0376;
						case 32:
							goto IL_0393;
						case 33:
							goto IL_0399;
						case 34:
							goto IL_0409;
						case 35:
							goto IL_0439;
						case 36:
							goto IL_047e;
						case 37:
							goto IL_0493;
						case 39:
							goto IL_04a0;
						case 40:
							goto IL_04bd;
						case 41:
							goto IL_04c3;
						case 42:
							goto IL_0533;
						case 43:
							goto IL_0563;
						case 44:
							goto IL_05a8;
						case 45:
							goto IL_05bd;
						case 47:
						case 48:
							goto IL_05cb;
						case 49:
							goto IL_05d1;
						case 50:
							goto IL_063a;
						case 51:
							goto IL_067f;
						case 52:
							goto IL_06e2;
						case 53:
							goto IL_0712;
						case 55:
							goto IL_0744;
						case 56:
							goto IL_0749;
						case 54:
						case 57:
						case 58:
							goto IL_078f;
						case 13:
						case 22:
						case 30:
						case 38:
						case 46:
						case 59:
						case 60:
						case 61:
							goto IL_07a6;
						case 9:
						case 10:
						case 62:
							goto IL_07b2;
						case 63:
							goto IL_07c8;
						case 64:
							goto IL_07d8;
						case 65:
							goto IL_07e8;
						case 66:
							goto IL_07f4;
						case 67:
							goto IL_07fb;
						case 68:
							goto IL_080c;
						case 69:
							goto IL_0837;
						case 70:
							goto IL_0856;
						case 73:
							goto IL_0870;
						case 74:
							goto IL_0876;
						case 75:
							goto IL_08e2;
						case 76:
							goto IL_0929;
						case 77:
							goto IL_098e;
						case 78:
							goto IL_09bf;
						case 80:
							goto IL_09f2;
						case 81:
							goto IL_09f7;
						case 79:
						case 82:
						case 83:
							goto IL_0a3f;
						case 84:
							goto IL_0a54;
						case 71:
						case 72:
						case 85:
							goto IL_0a61;
						case 86:
							goto IL_0a78;
						case 87:
						case 88:
							goto IL_0a85;
						case 89:
							goto IL_0a9d;
						case 92:
							goto IL_0aad;
						case 93:
							goto IL_0ad9;
						case 95:
						case 96:
							goto IL_0af5;
						case 97:
							goto IL_0b0f;
						case 98:
							goto IL_0b20;
						case 99:
							goto IL_0b31;
						case 101:
							goto IL_0b4b;
						case 102:
							goto IL_0b65;
						case 103:
							goto IL_0b76;
						case 104:
							goto IL_0b87;
						case 106:
							goto IL_0ba1;
						case 107:
							goto IL_0bbb;
						case 108:
							goto IL_0bcc;
						case 109:
							goto IL_0bdd;
						case 111:
							goto IL_0bf7;
						case 112:
							goto IL_0c11;
						case 113:
							goto IL_0c22;
						case 114:
							goto IL_0c33;
						case 116:
							goto IL_0c4a;
						case 117:
							goto IL_0c63;
						case 118:
							goto IL_0c74;
						case 119:
							goto IL_0c85;
						case 94:
						case 100:
						case 105:
						case 110:
						case 115:
						case 120:
						case 121:
						case 122:
							goto IL_0c9c;
						case 90:
						case 91:
						case 123:
							goto IL_0ca8;
						case 124:
							goto IL_0cbe;
						case 125:
							goto IL_0cc9;
						case 126:
							goto IL_0ccf;
						case 127:
							goto IL_0cd6;
						case 129:
							goto IL_0ce4;
						case 130:
							goto IL_0d40;
						default:
							goto end_IL_0001;
						case 128:
						case 131:
							goto end_IL_0001_2;
						}
						goto default;
						IL_0023:
						num = 2;
						clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
						recordset2 = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						goto IL_0046;
						IL_0046:
						num = 3;
						clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
						command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						goto IL_0068;
						IL_0068:
						num = 4;
						array = new bool[5];
						goto IL_0072;
						IL_0072:
						ProjectData.ClearProjectError();
						num3 = 2;
						goto IL_007a;
						IL_007a:
						num = 6;
						z = (short)(Globals_Renamed.arExpModels[1, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1);
						goto IL_0097;
						IL_0097:
						num = 7;
						recordset.CursorLocation = CursorLocationEnum.adUseClient;
						goto IL_00a2;
						IL_00a2:
						num = 8;
						recordset.Open("SELECT * FROM qryGetParms" + Strings.Right("0" + Conversions.ToString(unchecked((int)pPcat)), 2), Common.MyConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
						goto IL_07b2;
						IL_07b2:
						num = 10;
						if (!recordset.EOF)
						{
							goto IL_00da;
						}
						goto IL_07c8;
						IL_07c8:
						num = 63;
						command.ActiveConnection = Common.MyConn;
						goto IL_07d8;
						IL_07d8:
						num = 64;
						command.CommandText = "pqryGetSubParms";
						goto IL_07e8;
						IL_07e8:
						num = 65;
						command.CommandType = CommandTypeEnum.adCmdStoredProc;
						goto IL_07f4;
						IL_07f4:
						num = 66;
						num7 = 0;
						goto IL_07fb;
						IL_07fb:
						num = 67;
						if (array[num7])
						{
							goto IL_080c;
						}
						goto IL_0a85;
						IL_080c:
						num = 68;
						command.Parameters.Append(command.CreateParameter("pSubCode", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, num7 + 140));
						goto IL_0837;
						IL_0837:
						num = 69;
						command2 = command;
						RecordsAffected = Missing.Value;
						Parameters = Missing.Value;
						recordset2 = command2.Execute(out RecordsAffected, ref Parameters);
						goto IL_0856;
						IL_0856:
						num = 70;
						command.Parameters.Delete("pSubCode");
						goto IL_0a61;
						IL_0a61:
						num = 72;
						if (!recordset2.EOF)
						{
							goto IL_0870;
						}
						goto IL_0a78;
						IL_0a78:
						num = 86;
						recordset2.Close();
						goto IL_0a85;
						IL_0870:
						num = 73;
						pDualIndex = 0;
						goto IL_0876;
						IL_0876:
						num = 74;
						Globals_Renamed.arRelModParmsV[pDualIndex, Conversions.ToInteger(recordset2.Fields["ParmID"].Value), pModIndex] = GetModelDefault(Conversions.ToShort(recordset2.Fields["DefaultSource"].Value), Conversions.ToShort(recordset2.Fields["ParmID"].Value), ref pModType, ref pActID, ref pModIndex, ref pDualIndex);
						goto IL_08e2;
						IL_08e2:
						num = 75;
						Globals_Renamed.arRelModParmsT[pDualIndex, Conversions.ToInteger(recordset2.Fields["ParmID"].Value), pModIndex] = Conversions.ToShort(recordset2.Fields["Type"].Value);
						goto IL_0929;
						IL_0929:
						num = 76;
						if ((Globals_Renamed.arRelModParmsV[pDualIndex, Conversions.ToInteger(recordset2.Fields["ParmID"].Value), pModIndex] == -1f) & (Globals_Renamed.arRelModParmsT[pDualIndex, Conversions.ToInteger(recordset2.Fields["ParmID"].Value), pModIndex] == 1))
						{
							goto IL_098e;
						}
						goto IL_09f2;
						IL_098e:
						num = 77;
						Globals_Renamed.arRelModParmsVC[pDualIndex, Conversions.ToInteger(recordset2.Fields["ParmID"].Value), pModIndex] = 999;
						goto IL_09bf;
						IL_09bf:
						num = 78;
						Globals_Renamed.arRelModParmsV[pDualIndex, Conversions.ToInteger(recordset2.Fields["ParmID"].Value), pModIndex] = 0f;
						goto IL_0a3f;
						IL_09f2:
						num = 80;
						goto IL_09f7;
						IL_09f7:
						num = 81;
						Globals_Renamed.arRelModParmsVC[pDualIndex, Conversions.ToInteger(recordset2.Fields["ParmID"].Value), pModIndex] = Conversions.ToShort(recordset2.Fields["DefaultSource"].Value);
						goto IL_0a3f;
						IL_0a3f:
						num = 83;
						pDualIndex = (short)unchecked(pDualIndex + 1);
						num8 = pDualIndex;
						num6 = 1;
						if (num8 <= num6)
						{
							goto IL_0876;
						}
						goto IL_0a54;
						IL_0a54:
						num = 84;
						recordset2.MoveNext();
						goto IL_0a61;
						IL_0a85:
						num = 88;
						num7 = (short)unchecked(num7 + 1);
						num9 = num7;
						num6 = 3;
						if (num9 <= num6)
						{
							goto IL_07fb;
						}
						goto IL_0a9d;
						IL_0a9d:
						num = 89;
						recordset.MoveFirst();
						goto IL_0ca8;
						IL_0ca8:
						num = 91;
						if (!recordset.EOF)
						{
							goto IL_0aad;
						}
						goto IL_0cbe;
						IL_0cbe:
						num = 124;
						recordset.Close();
						goto IL_0cc9;
						IL_0cc9:
						num = 125;
						recordset = null;
						goto IL_0ccf;
						IL_0ccf:
						num = 126;
						recordset2 = null;
						goto IL_0cd6;
						IL_0cd6:
						num = 127;
						command = null;
						goto end_IL_0001_2;
						IL_0aad:
						num = 92;
						if (Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(recordset.Fields["DefaultSource"].Value)))
						{
							goto IL_0ad9;
						}
						goto IL_0c9c;
						IL_0ad9:
						num = 93;
						value = recordset.Fields["ParmID"].Value;
						goto IL_0af5;
						IL_0af5:
						num = 96;
						if (Operators.ConditionalCompareObjectEqual(value, (object)(short)72, false))
						{
							goto IL_0b0f;
						}
						goto IL_0b4b;
						IL_0b0f:
						num = 97;
						pDualIndex2 = 0;
						GetParmDefaults.LinkFreq(ref z, ref pDualIndex2);
						goto IL_0b20;
						IL_0b20:
						num = 98;
						pDualIndex2 = 1;
						GetParmDefaults.LinkFreq(ref z, ref pDualIndex2);
						goto IL_0b31;
						IL_0b31:
						num = 99;
						frmMain.DefInstance.cmbExpOps.SelectedIndex = -1;
						goto IL_0c9c;
						IL_0b4b:
						num = 101;
						if (Operators.ConditionalCompareObjectEqual(value, (object)(short)40, false))
						{
							goto IL_0b65;
						}
						goto IL_0ba1;
						IL_0b65:
						num = 102;
						pDualIndex2 = 0;
						GetParmDefaults.LinkX(ref z, ref pDualIndex2);
						goto IL_0b76;
						IL_0b76:
						num = 103;
						pDualIndex2 = 1;
						GetParmDefaults.LinkX(ref z, ref pDualIndex2);
						goto IL_0b87;
						IL_0b87:
						num = 104;
						frmMain.DefInstance.cmbExpOps.SelectedIndex = -1;
						goto IL_0c9c;
						IL_0ba1:
						num = 106;
						if (Operators.ConditionalCompareObjectEqual(value, (object)(short)69, false))
						{
							goto IL_0bbb;
						}
						goto IL_0bf7;
						IL_0bbb:
						num = 107;
						pDualIndex2 = 0;
						GetParmDefaults.LinkVzCB(ref z, ref pDualIndex2);
						goto IL_0bcc;
						IL_0bcc:
						num = 108;
						pDualIndex2 = 1;
						GetParmDefaults.LinkVzCB(ref z, ref pDualIndex2);
						goto IL_0bdd;
						IL_0bdd:
						num = 109;
						frmMain.DefInstance.cmbExpOps.SelectedIndex = -1;
						goto IL_0c9c;
						IL_0bf7:
						num = 111;
						if (Operators.ConditionalCompareObjectEqual(value, (object)(short)31, false))
						{
							goto IL_0c11;
						}
						goto IL_0c4a;
						IL_0c11:
						num = 112;
						pDualIndex2 = 0;
						GetParmDefaults.LinkOHa(ref z, ref pDualIndex2);
						goto IL_0c22;
						IL_0c22:
						num = 113;
						pDualIndex2 = 1;
						GetParmDefaults.LinkOHa(ref z, ref pDualIndex2);
						goto IL_0c33;
						IL_0c33:
						num = 114;
						frmMain.DefInstance.cmbExpOps.SelectedIndex = -1;
						goto IL_0c9c;
						IL_0c4a:
						num = 116;
						if (Operators.ConditionalCompareObjectEqual(value, (object)(short)4, false))
						{
							goto IL_0c63;
						}
						goto IL_0c9c;
						IL_0c63:
						num = 117;
						pDualIndex2 = 0;
						GetParmDefaults.LinkVP(ref z, ref pDualIndex2);
						goto IL_0c74;
						IL_0c74:
						num = 118;
						pDualIndex2 = 1;
						GetParmDefaults.LinkVP(ref z, ref pDualIndex2);
						goto IL_0c85;
						IL_0c85:
						num = 119;
						frmMain.DefInstance.cmbExpOps.SelectedIndex = -1;
						goto IL_0c9c;
						IL_0c9c:
						num = 122;
						recordset.MoveNext();
						goto IL_0ca8;
						IL_00da:
						num = 11;
						if (Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(recordset.Fields["DefaultSource"].Value)))
						{
							goto IL_0106;
						}
						goto IL_07a6;
						IL_0106:
						num = 12;
						value2 = recordset.Fields["ParmID"].Value;
						goto IL_0122;
						IL_0122:
						num = 15;
						if (Operators.ConditionalCompareObjectEqual(value2, (object)(short)92, false))
						{
							goto IL_013f;
						}
						goto IL_024c;
						IL_013f:
						num = 16;
						pDualIndex = 0;
						goto IL_0145;
						IL_0145:
						num = 17;
						Globals_Renamed.arRelModParmsVC[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = (short)Math.Round(GetModelDefault(Conversions.ToShort(recordset.Fields["DefaultSource"].Value), Conversions.ToShort(recordset.Fields["ParmID"].Value), ref pModType, ref pActID, ref pModIndex, ref pDualIndex));
						goto IL_01b5;
						IL_01b5:
						num = 18;
						Globals_Renamed.arRelModParmsV[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = 0f;
						goto IL_01e5;
						IL_01e5:
						num = 19;
						Globals_Renamed.arRelModParmsT[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = Conversions.ToShort(recordset.Fields["Type"].Value);
						goto IL_022a;
						IL_022a:
						num = 20;
						pDualIndex = (short)unchecked(pDualIndex + 1);
						num10 = pDualIndex;
						num6 = 1;
						if (num10 <= num6)
						{
							goto IL_0145;
						}
						goto IL_023f;
						IL_023f:
						num = 21;
						array[0] = true;
						goto IL_07a6;
						IL_024c:
						num = 23;
						if (Operators.ConditionalCompareObjectEqual(value2, (object)(short)72, false))
						{
							goto IL_0269;
						}
						goto IL_0376;
						IL_0269:
						num = 24;
						pDualIndex = 0;
						goto IL_026f;
						IL_026f:
						num = 25;
						Globals_Renamed.arRelModParmsVC[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = (short)Math.Round(GetModelDefault(Conversions.ToShort(recordset.Fields["DefaultSource"].Value), Conversions.ToShort(recordset.Fields["ParmID"].Value), ref pModType, ref pActID, ref pModIndex, ref pDualIndex));
						goto IL_02df;
						IL_02df:
						num = 26;
						Globals_Renamed.arRelModParmsV[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = 0f;
						goto IL_030f;
						IL_030f:
						num = 27;
						Globals_Renamed.arRelModParmsT[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = Conversions.ToShort(recordset.Fields["Type"].Value);
						goto IL_0354;
						IL_0354:
						num = 28;
						pDualIndex = (short)unchecked(pDualIndex + 1);
						num11 = pDualIndex;
						num6 = 1;
						if (num11 <= num6)
						{
							goto IL_026f;
						}
						goto IL_0369;
						IL_0369:
						num = 29;
						array[1] = true;
						goto IL_07a6;
						IL_0376:
						num = 31;
						if (Operators.ConditionalCompareObjectEqual(value2, (object)(short)9, false))
						{
							goto IL_0393;
						}
						goto IL_04a0;
						IL_0393:
						num = 32;
						pDualIndex = 0;
						goto IL_0399;
						IL_0399:
						num = 33;
						Globals_Renamed.arRelModParmsVC[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = (short)Math.Round(GetModelDefault(Conversions.ToShort(recordset.Fields["DefaultSource"].Value), Conversions.ToShort(recordset.Fields["ParmID"].Value), ref pModType, ref pActID, ref pModIndex, ref pDualIndex));
						goto IL_0409;
						IL_0409:
						num = 34;
						Globals_Renamed.arRelModParmsV[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = 0f;
						goto IL_0439;
						IL_0439:
						num = 35;
						Globals_Renamed.arRelModParmsT[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = Conversions.ToShort(recordset.Fields["Type"].Value);
						goto IL_047e;
						IL_047e:
						num = 36;
						pDualIndex = (short)unchecked(pDualIndex + 1);
						num12 = pDualIndex;
						num6 = 1;
						if (num12 <= num6)
						{
							goto IL_0399;
						}
						goto IL_0493;
						IL_0493:
						num = 37;
						array[2] = true;
						goto IL_07a6;
						IL_04a0:
						num = 39;
						if (Operators.ConditionalCompareObjectEqual(value2, (object)(short)40, false))
						{
							goto IL_04bd;
						}
						goto IL_05cb;
						IL_04bd:
						num = 40;
						pDualIndex = 0;
						goto IL_04c3;
						IL_04c3:
						num = 41;
						Globals_Renamed.arRelModParmsVC[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = (short)Math.Round(GetModelDefault(Conversions.ToShort(recordset.Fields["DefaultSource"].Value), Conversions.ToShort(recordset.Fields["ParmID"].Value), ref pModType, ref pActID, ref pModIndex, ref pDualIndex));
						goto IL_0533;
						IL_0533:
						num = 42;
						Globals_Renamed.arRelModParmsV[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = 0f;
						goto IL_0563;
						IL_0563:
						num = 43;
						Globals_Renamed.arRelModParmsT[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = Conversions.ToShort(recordset.Fields["Type"].Value);
						goto IL_05a8;
						IL_05a8:
						num = 44;
						pDualIndex = (short)unchecked(pDualIndex + 1);
						num13 = pDualIndex;
						num6 = 1;
						if (num13 <= num6)
						{
							goto IL_04c3;
						}
						goto IL_05bd;
						IL_05bd:
						num = 45;
						array[3] = true;
						goto IL_07a6;
						IL_05cb:
						num = 48;
						pDualIndex = 0;
						goto IL_05d1;
						IL_05d1:
						num = 49;
						Globals_Renamed.arRelModParmsV[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = GetModelDefault(Conversions.ToShort(recordset.Fields["DefaultSource"].Value), Conversions.ToShort(recordset.Fields["ParmID"].Value), ref pModType, ref pActID, ref pModIndex, ref pDualIndex);
						goto IL_063a;
						IL_063a:
						num = 50;
						Globals_Renamed.arRelModParmsT[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = Conversions.ToShort(recordset.Fields["Type"].Value);
						goto IL_067f;
						IL_067f:
						num = 51;
						if ((Globals_Renamed.arRelModParmsV[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] == -1f) & (Globals_Renamed.arRelModParmsT[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] == 1))
						{
							goto IL_06e2;
						}
						goto IL_0744;
						IL_06e2:
						num = 52;
						Globals_Renamed.arRelModParmsVC[pDualIndex, Conversions.ToInteger(recordset.Fields["ParmID"].Value), pModIndex] = 999;
						goto IL_0712;
						end_IL_0001:
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 3972;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static float SetGSSParmDefault(ref short pGSSID, ref short pParmID)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		float num3 = default(float);
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
					Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
					Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
					Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					ProjectData.ClearProjectError();
					num2 = 2;
					switch (pGSSID)
					{
					case 100:
					case 101:
					case 103:
					case 104:
					{
						command.ActiveConnection = Common.MyConn;
						command.CommandText = "pqryGetParmDefault";
						command.CommandType = CommandTypeEnum.adCmdStoredProc;
						command.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, 0));
						command.Parameters.Append(command.CreateParameter("pModelID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, 0));
						command.Parameters.Append(command.CreateParameter("pParmID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, pParmID));
						Command command2 = command;
						object RecordsAffected = Missing.Value;
						object Parameters = Missing.Value;
						recordset = command2.Execute(out RecordsAffected, ref Parameters);
						command.Parameters.Delete("pActID");
						command.Parameters.Delete("pModelID");
						command.Parameters.Delete("pParmID");
						if (!recordset.EOF)
						{
							num3 = Conversions.ToSingle(recordset.Fields[0].Value);
						}
						recordset.Close();
						recordset = null;
						command = null;
						break;
					}
					}
					goto end_IL_0001;
				}
				case 467:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						string Eobject = "ChemStrBas.Bas";
						string Efunction = "SetGSSParmDefault";
						ErrObject val = Information.Err();
						int Enumber = val.Number;
						ErrObject val2 = Information.Err();
						string Edescription = val2.Description;
						bool Econtact = true;
						Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
						val2.Description = Edescription;
						val.Number = Enumber;
						goto end_IL_0001;
					}
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 467;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		float result = num3;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static float SetGSSParmDefault2(ref short pGSSID, ref short pParmID)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		float num3 = default(float);
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
					Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
					Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
					Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					ProjectData.ClearProjectError();
					num2 = 2;
					switch (pGSSID)
					{
					case 100:
					case 101:
					case 103:
					case 104:
					{
						command.ActiveConnection = Common.MyConn;
						command.CommandText = "pqryGetParmDefaultGSS";
						command.CommandType = CommandTypeEnum.adCmdStoredProc;
						command.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, 0));
						command.Parameters.Append(command.CreateParameter("pModelID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, 0));
						command.Parameters.Append(command.CreateParameter("pParmID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, pParmID));
						command.Parameters.Append(command.CreateParameter("pGSSID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, pGSSID));
						Command command2 = command;
						object RecordsAffected = Missing.Value;
						object Parameters = Missing.Value;
						recordset = command2.Execute(out RecordsAffected, ref Parameters);
						command.Parameters.Delete("pActID");
						command.Parameters.Delete("pModelID");
						command.Parameters.Delete("pParmID");
						command.Parameters.Delete("pGSSID");
						if (!recordset.EOF)
						{
							num3 = Conversions.ToSingle(recordset.Fields[0].Value);
						}
						recordset.Close();
						recordset = null;
						command = null;
						break;
					}
					}
					goto end_IL_0001;
				}
				case 517:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						string Eobject = "ChemStrBas.Bas";
						string Efunction = "SetGSSParmDefault2";
						ErrObject val = Information.Err();
						int Enumber = val.Number;
						ErrObject val2 = Information.Err();
						string Edescription = val2.Description;
						bool Econtact = true;
						Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
						val2.Description = Edescription;
						val.Number = Enumber;
						goto end_IL_0001;
					}
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 517;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		float result = num3;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static void MyMSfClear(ref AxMSFlexGrid pmsfGrid)
	{
		pmsfGrid.Rows = 2;
		checked
		{
			short num = (short)(pmsfGrid.Cols - 1);
			short num2 = 0;
			while (true)
			{
				short num3 = num2;
				short num4 = num;
				if (num3 <= num4)
				{
					pmsfGrid[1, unchecked((int)num2)] = "";
					num2 = (short)unchecked(num2 + 1);
					continue;
				}
				break;
			}
		}
	}

	public static object GrabUpdatesFromModels(ref object pArrayV, ref object pArrayT, ref short pDualID)
	{
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		object obj = default(object);
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
						short num3 = 1;
						short num4;
						short num5;
						do
						{
							if (num3 == 50 && Globals_Renamed.arParmValues[num3] > 0f && !Globals_Renamed.arParmValid[num3])
							{
								Globals_Renamed.arParmValid[num3] = true;
							}
							if (Globals_Renamed.arParmValid[num3] != Globals_Renamed.arParmValidSave[num3])
							{
								if (!Globals_Renamed.arParmValidSave[num3])
								{
									NewLateBinding.LateIndexSet(pArrayV, new object[4]
									{
										pDualID,
										num3,
										Globals_Renamed.intModIndex,
										Globals_Renamed.arParmValues[num3]
									}, (string[])null);
									flag = true;
								}
								else
								{
									Interaction.MsgBox((object)"program error - GrabUpdatesFromModels.  Please contact technical support.", (MsgBoxStyle)0, (object)null);
								}
							}
							num3 = (short)unchecked(num3 + 1);
							num4 = num3;
							num5 = 162;
						}
						while (num4 <= num5);
						obj = flag;
						goto end_IL_0001;
					}
					case 321:
						num = -1;
						switch (num2)
						{
						case 2:
						{
							string Eobject = "ChemStrBas.Bas";
							string Efunction = "GrabUpdatesFromModels";
							ErrObject val = Information.Err();
							int Enumber = val.Number;
							ErrObject val2 = Information.Err();
							string Edescription = val2.Description;
							bool Econtact = true;
							Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
							val2.Description = Edescription;
							val.Number = Enumber;
							goto end_IL_0001;
						}
						}
						break;
					}
				}
			}
			catch (object obj2) when (obj2 is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0001_dispatch = 321;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		object result = obj;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static void SetArParmValid(ref short x, ref object pArrayT, ref short pDualID)
	{
		object obj = NewLateBinding.LateIndexGet(pArrayT, new object[3]
		{
			pDualID,
			x,
			Globals_Renamed.intModIndex
		}, (string[])null);
		if (Conversions.ToBoolean((Conversions.ToBoolean(Operators.CompareObjectEqual(obj, (object)(short)1, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(obj, (object)(short)2, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(obj, (object)(short)3, false))) ? ((object)true) : ((object)false)))
		{
			Globals_Renamed.arParmValid[x] = true;
		}
		else
		{
			Globals_Renamed.arParmValid[x] = false;
		}
	}

	public static void GetReleaseParms(ref short pModel, ref short pDualID)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
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
						object obj;
						short num3;
						short num8;
						if ((pModel == 22) | (pModel == 54))
						{
							obj = new object[2]
							{
								(short)49,
								(short)50
							};
							num3 = 0;
							short num7;
							do
							{
								short num4 = Conversions.ToShort(NewLateBinding.LateIndexGet(obj, new object[1] { num3 }, (string[])null));
								if (!Globals_Renamed.arParmValid[num4])
								{
									short pParmID = 49;
									short num5 = FindAssocRelModelIndex(ref pParmID);
									if (num5 != -1)
									{
										short num6 = ((Globals_Renamed.arRelModOutputOn[pDualID, num5] == 1) ? pDualID : ((pDualID == 0) ? ((short)1) : ((short)0)));
										if ((num4 == 50) & (Globals_Renamed.arRelModParmsV[num6, num4, num5] == 0f))
										{
											num4 = 49;
										}
										Globals_Renamed.arParmValid[num4] = true;
										Globals_Renamed.arParmValues[num4] = Globals_Renamed.arRelModParmsV[num6, num4, num5];
									}
								}
								num3 = (short)unchecked(num3 + 1);
								num7 = num3;
								num8 = 1;
							}
							while (num7 <= num8);
						}
						if (pModel != 22)
						{
							goto end_IL_0001;
						}
						obj = new object[1] { (short)31 };
						num3 = 0;
						short num11;
						do
						{
							short num4 = Conversions.ToShort(NewLateBinding.LateIndexGet(obj, new object[1] { num3 }, (string[])null));
							if (!Globals_Renamed.arParmValid[num4 + 14])
							{
								short num9 = 0;
								short num10;
								do
								{
									if (Globals_Renamed.arRelModels[num9, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] > 0)
									{
										short num5 = (short)(Globals_Renamed.arRelModels[num9, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1);
										Globals_Renamed.arParmValid[num4 + 14] = true;
										Globals_Renamed.arParmValues[num4 + 14] = Globals_Renamed.arRelModParmsV[pDualID, num4, num5];
									}
									num9 = (short)unchecked(num9 + 1);
									num10 = num9;
									num8 = 9;
								}
								while (num10 <= num8);
							}
							num3 = (short)unchecked(num3 + 1);
							num11 = num3;
							num8 = 0;
						}
						while (num11 <= num8);
						goto end_IL_0001;
					}
					case 608:
						num = -1;
						switch (num2)
						{
						case 2:
						{
							string Eobject = "ChemStrBas.Bas";
							string Efunction = "GetReleaseParms";
							ErrObject val = Information.Err();
							int Enumber = val.Number;
							ErrObject val2 = Information.Err();
							string Edescription = val2.Description;
							bool Econtact = true;
							Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
							val2.Description = Edescription;
							val.Number = Enumber;
							goto end_IL_0001;
						}
						}
						break;
					}
				}
			}
			catch (object obj2) when (obj2 is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0001_dispatch = 608;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static string SetOpParmType(ref short pParmType)
	{
		return pParmType switch
		{
			1 => "Default", 
			3 => "Non-default", 
			2 => "User Specified", 
			4 => "Derived", 
			9 => "Not Available", 
			0 => "Unspecified", 
			_ => "Unknown (" + Conversions.ToString((int)pParmType) + ")", 
		};
	}

	public static void RollDownhill(ref short pID, ref float pValue, ref short pVC)
	{
		short num = 0;
		checked
		{
			short num8;
			short num5;
			do
			{
				short num2 = (short)(Globals_Renamed.intNumRelModels - 1);
				short num3 = 0;
				while (true)
				{
					short num4 = num3;
					num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					if ((Globals_Renamed.arRelModParmsVC[num, pID, num3] == pVC) & (Globals_Renamed.arRelModParmsT[num, pID, num3] == 1))
					{
						Globals_Renamed.arRelModParmsV[num, pID, num3] = pValue;
					}
					num3 = (short)unchecked(num3 + 1);
				}
				short num6 = (short)(Globals_Renamed.intNumExpModels - 1);
				num3 = 0;
				while (true)
				{
					short num7 = num3;
					num5 = num6;
					if (num7 > num5)
					{
						break;
					}
					if ((Globals_Renamed.arExpModParmsVC[num, pID, num3] == pVC) & (Globals_Renamed.arExpModParmsT[num, pID, num3] == 1))
					{
						Globals_Renamed.arExpModParmsV[num, pID, num3] = pValue;
					}
					num3 = (short)unchecked(num3 + 1);
				}
				num = (short)unchecked(num + 1);
				num8 = num;
				num5 = 1;
			}
			while (num8 <= num5);
		}
	}

	public static void RollDownhillDchem(ref float pNewValue, ref float pOldValue)
	{
		checked
		{
			short num = (short)(Globals_Renamed.intNumOps - 1);
			short pOp = 0;
			while (true)
			{
				short num2 = pOp;
				short num3 = num;
				if (num2 <= num3)
				{
					RolldownhillDrm(ref pOp, ref pNewValue, ref pOldValue);
					RolldownhillDprod(ref pOp, ref pNewValue, ref pOldValue);
					if (Globals_Renamed.arOpParms[29, pOp] == pOldValue)
					{
						Globals_Renamed.arOpParms[29, pOp] = pNewValue;
					}
					if (Globals_Renamed.arOpParms[30, pOp] == pOldValue)
					{
						Globals_Renamed.arOpParms[30, pOp] = pNewValue;
					}
					ref double pMyPvOp = ref Globals_Renamed.arOpPv[pOp];
					bool pBatch = Globals_Renamed.arOpBorC[pOp] == 1;
					ResetContParms(ref pOp, ref pMyPvOp, ref pBatch);
					pOp = (short)unchecked(pOp + 1);
					continue;
				}
				break;
			}
		}
	}

	public static void RollDownhillOp(ref short pID, ref float pValue, [Optional][DefaultParameterValue(null)] ref object pVC)
	{
		short num = 0;
		checked
		{
			short num13;
			short num6;
			do
			{
				short num2 = 0;
				short num8;
				do
				{
					if (Globals_Renamed.arRelModels[num2, num, Globals_Renamed.intOpIndex] > 0)
					{
						short num3 = (short)(Globals_Renamed.arRelModels[num2, num, Globals_Renamed.intOpIndex] - 1);
						if (Information.IsNothing(RuntimeHelpers.GetObjectValue(pVC)))
						{
							short num4 = 0;
							short num5;
							do
							{
								Globals_Renamed.arRelModParmsV[num4, pID, num3] = pValue;
								Globals_Renamed.arRelModParmsT[num4, pID, num3] = 1;
								num4 = (short)unchecked(num4 + 1);
								num5 = num4;
								num6 = 1;
							}
							while (num5 <= num6);
						}
						else
						{
							short num4 = 0;
							short num7;
							do
							{
								if (Operators.ConditionalCompareObjectEqual((object)Globals_Renamed.arRelModParmsVC[num4, pID, num3], pVC, false))
								{
									Globals_Renamed.arRelModParmsV[num4, pID, num3] = pValue;
								}
								num4 = (short)unchecked(num4 + 1);
								num7 = num4;
								num6 = 1;
							}
							while (num7 <= num6);
						}
					}
					num2 = (short)unchecked(num2 + 1);
					num8 = num2;
					num6 = 9;
				}
				while (num8 <= num6);
				num2 = 0;
				short num11;
				do
				{
					if (Globals_Renamed.arExpModels[num2, num, Globals_Renamed.intOpIndex] > 0)
					{
						short num3 = (short)(Globals_Renamed.arExpModels[num2, num, Globals_Renamed.intOpIndex] - 1);
						if (Information.IsNothing(RuntimeHelpers.GetObjectValue(pVC)))
						{
							short num4 = 0;
							short num9;
							do
							{
								Globals_Renamed.arExpModParmsV[num4, pID, num3] = pValue;
								Globals_Renamed.arExpModParmsT[num4, pID, num3] = 1;
								num4 = (short)unchecked(num4 + 1);
								num9 = num4;
								num6 = 1;
							}
							while (num9 <= num6);
						}
						else
						{
							short num4 = 0;
							short num10;
							do
							{
								if (Operators.ConditionalCompareObjectEqual((object)Globals_Renamed.arExpModParmsVC[num4, pID, num3], pVC, false))
								{
									Globals_Renamed.arExpModParmsV[num4, pID, num3] = pValue;
								}
								num4 = (short)unchecked(num4 + 1);
								num10 = num4;
								num6 = 1;
							}
							while (num10 <= num6);
						}
					}
					num2 = (short)unchecked(num2 + 1);
					num11 = num2;
					num6 = 1;
				}
				while (num11 <= num6);
				switch (pID)
				{
				case 118:
				case 119:
				case 120:
				{
					num2 = (short)(Globals_Renamed.arExpModels[1, num, Globals_Renamed.intOpIndex] - 1);
					if (num2 < 0)
					{
						break;
					}
					short num4 = 0;
					short num12;
					do
					{
						if (Globals_Renamed.arExpModParmsVC[num4, 40, num2] == 998)
						{
							Globals_Renamed.arExpModParmsV[num4, 40, num2] = pValue;
						}
						num4 = (short)unchecked(num4 + 1);
						num12 = num4;
						num6 = 1;
					}
					while (num12 <= num6);
					break;
				}
				}
				num = (short)unchecked(num + 1);
				num13 = num;
				num6 = 24;
			}
			while (num13 <= num6);
		}
	}

	public static void RollDownhillAct(ref short pID, ref float pValue, ref short pVC)
	{
		short num = 0;
		checked
		{
			short num6;
			short num5;
			do
			{
				if (Globals_Renamed.arRelModels[num, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] > 0)
				{
					short num2 = (short)(Globals_Renamed.arRelModels[num, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1);
					short num3 = 0;
					short num4;
					do
					{
						if ((Globals_Renamed.arRelModParmsVC[num3, pID, num2] == pVC) | (pVC == -999))
						{
							Globals_Renamed.arRelModParmsV[num3, pID, num2] = pValue;
						}
						num3 = (short)unchecked(num3 + 1);
						num4 = num3;
						num5 = 1;
					}
					while (num4 <= num5);
				}
				num = (short)unchecked(num + 1);
				num6 = num;
				num5 = 9;
			}
			while (num6 <= num5);
			num = 0;
			short num8;
			do
			{
				if (Globals_Renamed.arExpModels[num, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] > 0)
				{
					short num2 = (short)(Globals_Renamed.arExpModels[num, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1);
					short num3 = 0;
					short num7;
					do
					{
						if ((Globals_Renamed.arExpModParmsVC[num3, pID, num2] == pVC) | (pVC == -999))
						{
							Globals_Renamed.arExpModParmsV[num3, pID, num2] = pValue;
						}
						num3 = (short)unchecked(num3 + 1);
						num7 = num3;
						num5 = 1;
					}
					while (num7 <= num5);
				}
				num = (short)unchecked(num + 1);
				num8 = num;
				num5 = 1;
			}
			while (num8 <= num5);
		}
	}

	public static void ContDefaults(ref short pContTab, ref short pActID, ref object pContParms, ref object parOpParms)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
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
					Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
					Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
					Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					ProjectData.ClearProjectError();
					num2 = 2;
					if (pContTab == 2)
					{
						NewLateBinding.LateIndexSet(pContParms, new object[4]
						{
							(short)2,
							Globals_Renamed.intActIndex,
							Globals_Renamed.intOpIndex,
							RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(parOpParms, new object[2]
							{
								(short)10,
								Globals_Renamed.intOpIndex
							}, (string[])null))
						}, (string[])null);
						NewLateBinding.LateIndexSet(pContParms, new object[4]
						{
							(short)5,
							Globals_Renamed.intActIndex,
							Globals_Renamed.intOpIndex,
							RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(parOpParms, new object[2]
							{
								(short)30,
								Globals_Renamed.intOpIndex
							}, (string[])null))
						}, (string[])null);
					}
					else
					{
						NewLateBinding.LateIndexSet(pContParms, new object[4]
						{
							(short)2,
							Globals_Renamed.intActIndex,
							Globals_Renamed.intOpIndex,
							RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(parOpParms, new object[2]
							{
								(short)11,
								Globals_Renamed.intOpIndex
							}, (string[])null))
						}, (string[])null);
						NewLateBinding.LateIndexSet(pContParms, new object[4]
						{
							(short)5,
							Globals_Renamed.intActIndex,
							Globals_Renamed.intOpIndex,
							RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(parOpParms, new object[2]
							{
								(short)29,
								Globals_Renamed.intOpIndex
							}, (string[])null))
						}, (string[])null);
					}
					command.ActiveConnection = Common.MyConn;
					command.CommandText = "pqryGetParmDefault";
					command.CommandType = CommandTypeEnum.adCmdStoredProc;
					command.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, pActID));
					command.Parameters.Append(command.CreateParameter("pModelID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, 0));
					command.Parameters.Append(command.CreateParameter("pParmID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, (short)19));
					Command command2 = command;
					object RecordsAffected = Missing.Value;
					object Parameters = Missing.Value;
					recordset = command2.Execute(out RecordsAffected, ref Parameters);
					if (!recordset.EOF)
					{
						NewLateBinding.LateIndexSet(pContParms, new object[4]
						{
							(short)3,
							Globals_Renamed.intActIndex,
							Globals_Renamed.intOpIndex,
							RuntimeHelpers.GetObjectValue(recordset.Fields[0].Value)
						}, (string[])null);
					}
					recordset.Close();
					command.Parameters["pParmID"].Value = (short)23;
					command.ActiveConnection = Common.MyConn;
					command.CommandText = "pqryGetParmDefault";
					command.CommandType = CommandTypeEnum.adCmdStoredProc;
					Command command3 = command;
					Parameters = Missing.Value;
					RecordsAffected = Missing.Value;
					recordset = command3.Execute(out Parameters, ref RecordsAffected);
					command.Parameters.Delete("pParmID");
					if (!recordset.EOF)
					{
						NewLateBinding.LateIndexSet(pContParms, new object[4]
						{
							(short)1,
							Globals_Renamed.intActIndex,
							Globals_Renamed.intOpIndex,
							RuntimeHelpers.GetObjectValue(recordset.Fields[0].Value)
						}, (string[])null);
					}
					recordset.Close();
					NewLateBinding.LateIndexSet(pContParms, new object[4]
					{
						(short)6,
						Globals_Renamed.intActIndex,
						Globals_Renamed.intOpIndex,
						Operators.MultiplyObject(Operators.MultiplyObject(NewLateBinding.LateIndexGet(pContParms, new object[3]
						{
							(short)3,
							Globals_Renamed.intActIndex,
							Globals_Renamed.intOpIndex
						}, (string[])null), NewLateBinding.LateIndexGet(pContParms, new object[3]
						{
							(short)5,
							Globals_Renamed.intActIndex,
							Globals_Renamed.intOpIndex
						}, (string[])null)), (object)3.785)
					}, (string[])null);
					recordset = null;
					command = null;
					goto end_IL_0001;
				}
				case 1319:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						string Eobject = "ChemStrB";
						string Efunction = "ContDefaults";
						ErrObject val = Information.Err();
						int Enumber = val.Number;
						ErrObject val2 = Information.Err();
						string Edescription = val2.Description;
						bool Econtact = true;
						Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
						val2.Description = Edescription;
						val.Number = Enumber;
						goto end_IL_0001;
					}
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 1319;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static string ShowInSciNot1digit(ref object pValue)
	{
		if (Operators.ConditionalCompareObjectEqual(pValue, (object)0, false))
		{
			return "0.0E+0";
		}
		if (Operators.ConditionalCompareObjectGreaterEqual(pValue, (object)100000000, false))
		{
			return Support.Format((object)((double)Conversions.ToInteger(Operators.DivideObject(pValue, (object)10000000)) / 10.0), "###,##0.0", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + "E+8";
		}
		if (Operators.ConditionalCompareObjectGreaterEqual(pValue, (object)10000000, false))
		{
			return Support.Format((object)((double)Conversions.ToInteger(Operators.DivideObject(pValue, (object)1000000)) / 10.0), "0.0", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + "E+7";
		}
		if (Operators.ConditionalCompareObjectGreaterEqual(pValue, (object)1000000, false))
		{
			return Support.Format((object)((double)Conversions.ToInteger(Operators.DivideObject(pValue, (object)100000)) / 10.0), "0.0", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + "E+6";
		}
		if (Operators.ConditionalCompareObjectGreaterEqual(pValue, (object)100000, false))
		{
			return Support.Format((object)((double)Conversions.ToInteger(Operators.DivideObject(pValue, (object)10000)) / 10.0), "0.0", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + "E+5";
		}
		if (Operators.ConditionalCompareObjectGreaterEqual(pValue, (object)10000, false))
		{
			return Support.Format((object)((double)Conversions.ToInteger(Operators.DivideObject(pValue, (object)1000)) / 10.0), "0.0", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + "E+4";
		}
		if (Operators.ConditionalCompareObjectGreaterEqual(pValue, (object)1000, false))
		{
			return Support.Format((object)((double)Conversions.ToInteger(Operators.DivideObject(pValue, (object)100)) / 10.0), "0.0", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + "E+3";
		}
		if (Operators.ConditionalCompareObjectGreaterEqual(pValue, (object)100, false))
		{
			return Support.Format((object)((double)Conversions.ToInteger(Operators.DivideObject(pValue, (object)10)) / 10.0), "0.0", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + "E+2";
		}
		if (Operators.ConditionalCompareObjectGreaterEqual(pValue, (object)10, false))
		{
			return Support.Format((object)((double)Conversions.ToInteger(pValue) / 10.0), "0.0", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + "E+1";
		}
		if (Operators.ConditionalCompareObjectGreaterEqual(pValue, (object)1, false))
		{
			return Support.Format((object)((double)Conversions.ToInteger(Operators.MultiplyObject(pValue, (object)10)) / 10.0), "0.0", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + "E+0";
		}
		if (Operators.ConditionalCompareObjectGreaterEqual(pValue, (object)0.1, false))
		{
			return Support.Format((object)((double)Conversions.ToInteger(Operators.MultiplyObject(pValue, (object)100)) / 10.0), "0.0", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + "E-1";
		}
		if (Operators.ConditionalCompareObjectGreaterEqual(pValue, (object)0.01, false))
		{
			return Support.Format((object)((double)Conversions.ToInteger(Operators.MultiplyObject(pValue, (object)1000)) / 10.0), "0.0", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + "E-2";
		}
		if (Operators.ConditionalCompareObjectGreaterEqual(pValue, (object)0.001, false))
		{
			return Support.Format((object)((double)Conversions.ToInteger(Operators.MultiplyObject(pValue, (object)10000)) / 10.0), "0.0", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + "E-3";
		}
		if (Operators.ConditionalCompareObjectGreaterEqual(pValue, (object)0.0001, false))
		{
			return Support.Format((object)((double)Conversions.ToInteger(Operators.MultiplyObject(pValue, (object)100000)) / 10.0), "0.0", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + "E-4";
		}
		if (Operators.ConditionalCompareObjectGreaterEqual(pValue, (object)1E-05, false))
		{
			return Support.Format((object)((double)Conversions.ToInteger(Operators.MultiplyObject(pValue, (object)1000000)) / 10.0), "0.0", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + "E-5";
		}
		if (Operators.ConditionalCompareObjectGreaterEqual(pValue, (object)1E-06, false))
		{
			return Support.Format((object)((double)Conversions.ToInteger(Operators.MultiplyObject(pValue, (object)10000000.0)) / 10.0), "0.0", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + "E-6";
		}
		if (Operators.ConditionalCompareObjectGreaterEqual(pValue, (object)1E-07, false))
		{
			return Support.Format((object)((double)Conversions.ToInteger(Operators.MultiplyObject(pValue, (object)100000000.0)) / 10.0), "0.0", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + "E-7";
		}
		if (Operators.ConditionalCompareObjectGreaterEqual(pValue, (object)1E-08, false))
		{
			return Support.Format((object)((double)Conversions.ToInteger(Operators.MultiplyObject(pValue, (object)1000000000.0)) / 10.0), "0.0", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + "E-8";
		}
		if (Operators.ConditionalCompareObjectGreaterEqual(pValue, (object)1E-09, false))
		{
			return Support.Format((object)((double)Conversions.ToInteger(Operators.MultiplyObject(pValue, (object)10000000000.0)) / 10.0), "0.0", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + "E-9";
		}
		if (Operators.ConditionalCompareObjectGreaterEqual(pValue, (object)1E-10, false))
		{
			return Support.Format((object)((double)Conversions.ToInteger(Operators.MultiplyObject(pValue, (object)100000000000.0)) / 10.0), "0.0", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + "E-10";
		}
		if (Operators.ConditionalCompareObjectGreaterEqual(pValue, (object)1E-11, false))
		{
			return Support.Format((object)((double)Conversions.ToInteger(Operators.MultiplyObject(pValue, (object)1000000000000.0)) / 10.0), "0.0", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + "E-11";
		}
		if (Operators.ConditionalCompareObjectGreaterEqual(pValue, (object)1E-12, false))
		{
			return Support.Format((object)((double)Conversions.ToInteger(Operators.MultiplyObject(pValue, (object)10000000000000.0)) / 10.0), "0.0", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + "E-12";
		}
		if (Operators.ConditionalCompareObjectGreaterEqual(pValue, (object)1E-13, false))
		{
			return Support.Format((object)((double)Conversions.ToInteger(Operators.MultiplyObject(pValue, (object)100000000000000.0)) / 10.0), "0.0", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + "E-13";
		}
		if (Operators.ConditionalCompareObjectGreaterEqual(pValue, (object)1E-14, false))
		{
			return Support.Format((object)((double)Conversions.ToInteger(Operators.MultiplyObject(pValue, (object)1000000000000000.0)) / 10.0), "0.0", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + "E-14";
		}
		if (Operators.ConditionalCompareObjectGreaterEqual(pValue, (object)1E-15, false))
		{
			return Support.Format((object)((double)Conversions.ToInteger(Operators.MultiplyObject(pValue, (object)10000000000000000.0)) / 10.0), "0.0", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + " E-15";
		}
		return Conversions.ToString(pValue);
	}

	public static string ShowInSciNotPV(ref object pValue)
	{
		if (Operators.ConditionalCompareObjectEqual(pValue, (object)0, false))
		{
			return "0";
		}
		if (Operators.ConditionalCompareObjectGreaterEqual(pValue, (object)1, false))
		{
			return Support.Format(RuntimeHelpers.GetObjectValue(pValue), "###,##0", (FirstDayOfWeek)1, (FirstWeekOfYear)1);
		}
		if (Operators.ConditionalCompareObjectGreaterEqual(pValue, (object)0.1, false))
		{
			return Support.Format((object)((double)Conversions.ToInteger(Operators.MultiplyObject(pValue, (object)100)) / 10.0), "0.0", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + "E-1";
		}
		if (Operators.ConditionalCompareObjectGreaterEqual(pValue, (object)0.01, false))
		{
			return Support.Format((object)((double)Conversions.ToInteger(Operators.MultiplyObject(pValue, (object)1000)) / 10.0), "0.0", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + "E-2";
		}
		if (Operators.ConditionalCompareObjectGreaterEqual(pValue, (object)0.001, false))
		{
			return Support.Format((object)((double)Conversions.ToInteger(Operators.MultiplyObject(pValue, (object)10000)) / 10.0), "0.0", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + "E-3";
		}
		if (Operators.ConditionalCompareObjectGreaterEqual(pValue, (object)0.0001, false))
		{
			return Support.Format((object)((double)Conversions.ToInteger(Operators.MultiplyObject(pValue, (object)100000)) / 10.0), "0.0", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + "E-4";
		}
		if (Operators.ConditionalCompareObjectGreaterEqual(pValue, (object)1E-05, false))
		{
			return Support.Format((object)((double)Conversions.ToInteger(Operators.MultiplyObject(pValue, (object)1000000)) / 10.0), "0.0", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + "E-5";
		}
		if (Operators.ConditionalCompareObjectGreaterEqual(pValue, (object)1E-06, false))
		{
			return Support.Format((object)((double)Conversions.ToInteger(Operators.MultiplyObject(pValue, (object)10000000.0)) / 10.0), "0.0", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + "E-6";
		}
		if (Operators.ConditionalCompareObjectGreaterEqual(pValue, (object)1E-07, false))
		{
			return Support.Format((object)((double)Conversions.ToInteger(Operators.MultiplyObject(pValue, (object)100000000.0)) / 10.0), "0.0", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + "E-7";
		}
		if (Operators.ConditionalCompareObjectGreaterEqual(pValue, (object)1E-08, false))
		{
			return Support.Format((object)((double)Conversions.ToInteger(Operators.MultiplyObject(pValue, (object)1000000000.0)) / 10.0), "0.0", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + "E-8";
		}
		if (Operators.ConditionalCompareObjectGreaterEqual(pValue, (object)1E-09, false))
		{
			return Support.Format((object)((double)Conversions.ToInteger(Operators.MultiplyObject(pValue, (object)10000000000.0)) / 10.0), "0.0", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + "E-9";
		}
		if (Operators.ConditionalCompareObjectGreaterEqual(pValue, (object)1E-10, false))
		{
			return Support.Format((object)((double)Conversions.ToInteger(Operators.MultiplyObject(pValue, (object)100000000000.0)) / 10.0), "0.0", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + "E-10";
		}
		if (Operators.ConditionalCompareObjectGreaterEqual(pValue, (object)1E-11, false))
		{
			return Support.Format((object)((double)Conversions.ToInteger(Operators.MultiplyObject(pValue, (object)1000000000000.0)) / 10.0), "0.0", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + "E-11";
		}
		if (Operators.ConditionalCompareObjectGreaterEqual(pValue, (object)1E-12, false))
		{
			return Support.Format((object)((double)Conversions.ToInteger(Operators.MultiplyObject(pValue, (object)10000000000000.0)) / 10.0), "0.0", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + "E-12";
		}
		if (Operators.ConditionalCompareObjectGreaterEqual(pValue, (object)1E-13, false))
		{
			return Support.Format((object)((double)Conversions.ToInteger(Operators.MultiplyObject(pValue, (object)100000000000000.0)) / 10.0), "0.0", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + "E-13";
		}
		if (Operators.ConditionalCompareObjectGreaterEqual(pValue, (object)1E-14, false))
		{
			return Support.Format((object)((double)Conversions.ToInteger(Operators.MultiplyObject(pValue, (object)1000000000000000.0)) / 10.0), "0.0", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + "E-14";
		}
		if (Operators.ConditionalCompareObjectGreaterEqual(pValue, (object)1E-15, false))
		{
			return Support.Format((object)((double)Conversions.ToInteger(Operators.MultiplyObject(pValue, (object)10000000000000000.0)) / 10.0), "0.0", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + " E-15";
		}
		return Conversions.ToString(pValue);
	}

	public static string ShowInSciNot(object pObject)
	{
		checked
		{
			string text;
			if (!Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(pObject)))
			{
				text = "";
			}
			else
			{
				double num = Conversions.ToDouble(pObject);
				if (num >= 100.0)
				{
					text = Support.Format((object)num, "###,##0.##", (FirstDayOfWeek)1, (FirstWeekOfYear)1);
					if (Operators.CompareString(Strings.Right(text, 1), ".", false) == 0)
					{
						text = Strings.Left(text, Strings.Len(text) - 1);
					}
				}
				else if (!(num >= 0.1))
				{
					text = ((num >= 0.01) ? Support.Format((object)((double)(int)Math.Round(num * 1000.0) / 1000.0), "0.###", (FirstDayOfWeek)1, (FirstWeekOfYear)1) : ((num >= 0.001) ? (Support.Format((object)((double)(int)Math.Round(num * 10000000.0) / 10000.0), "#.0000", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + "E-03") : ((num >= 0.0001) ? (Support.Format((object)((double)(int)Math.Round(num * 100000000.0) / 10000.0), "#.0000", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + "E-04") : ((num >= 1E-05) ? (Support.Format((object)((double)(int)Math.Round(num * 1000000000.0) / 10000.0), "#.0000", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + "E-05") : ((num >= 1E-06) ? (Support.Format((object)((double)(int)Math.Round(num * 10000000000.0) / 10000.0), "#.0000", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + "E-06") : ((num >= 1E-07) ? (Support.Format((object)((double)(int)Math.Round(num * 100000000000.0) / 10000.0), "#.0000", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + "E-07") : ((num >= 1E-08) ? (Support.Format((object)((double)(int)Math.Round(num * 1000000000000.0) / 10000.0), "#.0000", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + "E-08") : ((num >= 1E-09) ? (Support.Format((object)((double)(int)Math.Round(num * 10000000000000.0) / 10000.0), "#.0000", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + "E-09") : ((num >= 1E-10) ? (Support.Format((object)((double)(int)Math.Round(num * 100000000000000.0) / 10000.0), "#.0000", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + "E-10") : ((num >= 1E-11) ? (Support.Format((object)((double)(int)Math.Round(num * 1000000000000000.0) / 10000.0), "#.0000", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + "E-11") : ((num >= 1E-12) ? (Support.Format((object)((double)(int)Math.Round(num * 10000000000000000.0) / 10000.0), "#.0000", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + "E-12") : ((num >= 1E-13) ? (Support.Format((object)((double)(int)Math.Round(num * 1E+17) / 10000.0), "#.0000", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + "E-13") : ((!(num >= 1E-14)) ? Conversions.ToString(num) : (Support.Format((object)((double)(int)Math.Round(num * 1E+18) / 10000.0), "#.0000", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + "E-14"))))))))))))));
				}
				else
				{
					text = Support.Format((object)((double)(int)Math.Round(num * 10000.0) / 10000.0), "###,##0.####", (FirstDayOfWeek)1, (FirstWeekOfYear)1);
					if (Operators.CompareString(Strings.Right(text, 1), ".", false) == 0)
					{
						text = Strings.Left(text, Strings.Len(text) - 1);
					}
				}
			}
			return text;
		}
	}

	public static string ShowZeroAsNull(object pValue)
	{
		if (!Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(pValue)))
		{
			return "";
		}
		if (Operators.ConditionalCompareObjectEqual(pValue, (object)0, false))
		{
			return "";
		}
		return Conversions.ToString(pValue);
	}

	public static string SetVCLabel(ref short pVC)
	{
		short num = pVC;
		switch (num)
		{
		case -1000:
			return "Mass Parm";
		case -1104:
		case -1103:
		case -1102:
		case -1101:
			if (true)
			{
				return "Chem Parm";
			}
			break;
		}
		if ((num >= -1299 && num <= -1200) ? true : false)
		{
			return "Cont Parm";
		}
		if ((num == -1300 || num == -1301 || num == -1302 || num == 1300) ? true : false)
		{
			return "Model Parm";
		}
		return num switch
		{
			999 => "User Specified", 
			-1 => "Model Parm", 
			_ => "Unknown: " + Conversions.ToString((int)pVC), 
		};
	}

	public static string GetParmAcronym(ref short pParmID)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		short num5 = default(short);
		string text = default(string);
		string parmLabels = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 156:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0001;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_0022;
						case 4:
							goto IL_0033;
						case 5:
							goto IL_0040;
						case 7:
							goto IL_0047;
						case 8:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 6:
						case 9:
						case 10:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0033:
					num = 4;
					if (num5 == 0)
					{
						goto IL_0040;
					}
					goto IL_0047;
					IL_0040:
					num = 5;
					text = parmLabels;
					goto end_IL_0001_3;
					IL_0022:
					num = 3;
					num5 = checked((short)Strings.InStr(parmLabels, ":", (CompareMethod)0));
					goto IL_0033;
					IL_0047:
					num = 7;
					break;
					IL_0009:
					num = 2;
					parmLabels = GetParmLabels(ref Globals_Renamed.arOpType[Globals_Renamed.intOpIndex], ref pParmID);
					goto IL_0022;
					end_IL_0001_2:
					break;
				}
				num = 8;
				text = Strings.Left(parmLabels, checked(num5 - 1));
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 156;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		string result = text;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static void ResetMetaDefaults()
	{
		object obj = new object[13]
		{
			(short)92,
			(short)72,
			(short)9,
			(short)75,
			(short)76,
			(short)77,
			(short)78,
			(short)61,
			(short)59,
			(short)40,
			(short)57,
			(short)73,
			(short)113
		};
		short num = 0;
		checked
		{
			short num20;
			short num10;
			do
			{
				short num2 = 0;
				short num11;
				do
				{
					if (Globals_Renamed.arRelModels[num2, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] > 0)
					{
						Globals_Renamed.intModIndex = (short)(Globals_Renamed.arRelModels[num2, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1);
						short pDualIndex = 0;
						short num9;
						do
						{
							if (Globals_Renamed.arRelModParmsT[pDualIndex, Conversions.ToInteger(NewLateBinding.LateIndexGet(obj, new object[1] { num }, (string[])null)), Globals_Renamed.intModIndex] == 1)
							{
								if (num >= 11)
								{
									float[,,] arRelModParmsV = Globals_Renamed.arRelModParmsV;
									short num3 = pDualIndex;
									int num4 = Conversions.ToInteger(NewLateBinding.LateIndexGet(obj, new object[1] { num }, (string[])null));
									short intModIndex = Globals_Renamed.intModIndex;
									short pParmID = Conversions.ToShort(NewLateBinding.LateIndexGet(obj, new object[1] { num }, (string[])null));
									ref short pModType = ref Globals_Renamed.arRelModType[Globals_Renamed.intModIndex];
									ref short pActID = ref Globals_Renamed.arSelActType[Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex];
									object pParmsV = Globals_Renamed.arRelModParmsV;
									float num5 = ResetParmDefault(ref pParmID, ref pModType, ref pActID, ref pDualIndex, ref pParmsV, ref Globals_Renamed.intModIndex);
									Globals_Renamed.arRelModParmsV = (float[,,])pParmsV;
									arRelModParmsV[num3, num4, intModIndex] = num5;
								}
								else
								{
									short[,,] arRelModParmsVC = Globals_Renamed.arRelModParmsVC;
									short num6 = pDualIndex;
									int num7 = Conversions.ToInteger(NewLateBinding.LateIndexGet(obj, new object[1] { num }, (string[])null));
									short intModIndex2 = Globals_Renamed.intModIndex;
									short pParmID = Conversions.ToShort(NewLateBinding.LateIndexGet(obj, new object[1] { num }, (string[])null));
									ref short pModType2 = ref Globals_Renamed.arRelModType[Globals_Renamed.intModIndex];
									ref short pActID2 = ref Globals_Renamed.arSelActType[Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex];
									object pParmsV = Globals_Renamed.arRelModParmsV;
									float num8 = ResetParmDefault(ref pParmID, ref pModType2, ref pActID2, ref pDualIndex, ref pParmsV, ref Globals_Renamed.intModIndex);
									Globals_Renamed.arRelModParmsV = (float[,,])pParmsV;
									arRelModParmsVC[num6, num7, intModIndex2] = (short)Math.Round(num8);
								}
							}
							pDualIndex = (short)unchecked(pDualIndex + 1);
							num9 = pDualIndex;
							num10 = 1;
						}
						while (num9 <= num10);
					}
					num2 = (short)unchecked(num2 + 1);
					num11 = num2;
					num10 = 10;
				}
				while (num11 <= num10);
				num2 = 0;
				short num19;
				do
				{
					if (Globals_Renamed.arExpModels[num2, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] > 0)
					{
						Globals_Renamed.intModIndex = (short)(Globals_Renamed.arExpModels[num2, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1);
						short pDualIndex = 0;
						short num18;
						do
						{
							if (Globals_Renamed.arExpModParmsT[pDualIndex, Conversions.ToInteger(NewLateBinding.LateIndexGet(obj, new object[1] { num }, (string[])null)), Globals_Renamed.intModIndex] == 1)
							{
								if (num == 12)
								{
									float[,,] arExpModParmsV = Globals_Renamed.arExpModParmsV;
									short num12 = pDualIndex;
									int num13 = Conversions.ToInteger(NewLateBinding.LateIndexGet(obj, new object[1] { num }, (string[])null));
									short intModIndex3 = Globals_Renamed.intModIndex;
									short pParmID = Conversions.ToShort(NewLateBinding.LateIndexGet(obj, new object[1] { num }, (string[])null));
									ref short pModType3 = ref Globals_Renamed.arExpModType[Globals_Renamed.intModIndex];
									ref short pActID3 = ref Globals_Renamed.arSelActType[Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex];
									object pParmsV = Globals_Renamed.arExpModParmsV;
									float num14 = ResetParmDefault(ref pParmID, ref pModType3, ref pActID3, ref pDualIndex, ref pParmsV, ref Globals_Renamed.intModIndex);
									Globals_Renamed.arExpModParmsV = (float[,,])pParmsV;
									arExpModParmsV[num12, num13, intModIndex3] = num14;
								}
								else
								{
									short[,,] arExpModParmsVC = Globals_Renamed.arExpModParmsVC;
									short num15 = pDualIndex;
									int num16 = Conversions.ToInteger(NewLateBinding.LateIndexGet(obj, new object[1] { num }, (string[])null));
									short intModIndex4 = Globals_Renamed.intModIndex;
									short pParmID = Conversions.ToShort(NewLateBinding.LateIndexGet(obj, new object[1] { num }, (string[])null));
									ref short pModType4 = ref Globals_Renamed.arExpModType[Globals_Renamed.intModIndex];
									ref short pActID4 = ref Globals_Renamed.arSelActType[Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex];
									object pParmsV = Globals_Renamed.arExpModParmsV;
									float num17 = ResetParmDefault(ref pParmID, ref pModType4, ref pActID4, ref pDualIndex, ref pParmsV, ref Globals_Renamed.intModIndex);
									Globals_Renamed.arExpModParmsV = (float[,,])pParmsV;
									arExpModParmsVC[num15, num16, intModIndex4] = (short)Math.Round(num17);
								}
								if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateIndexGet(obj, new object[1] { num }, (string[])null), (object)(short)75, false), (object)(Globals_Renamed.arExpModParmsVC[pDualIndex, Conversions.ToInteger(NewLateBinding.LateIndexGet(obj, new object[1] { num }, (string[])null)), Globals_Renamed.intModIndex] < 0))))
								{
									Globals_Renamed.arExpModParmsV[pDualIndex, Conversions.ToInteger(NewLateBinding.LateIndexGet(obj, new object[1] { num }, (string[])null)), Globals_Renamed.intModIndex] = 0f;
									Globals_Renamed.arExpModParmsVC[pDualIndex, Conversions.ToInteger(NewLateBinding.LateIndexGet(obj, new object[1] { num }, (string[])null)), Globals_Renamed.intModIndex] = Math.Abs(Globals_Renamed.arExpModParmsVC[pDualIndex, Conversions.ToInteger(NewLateBinding.LateIndexGet(obj, new object[1] { num }, (string[])null)), Globals_Renamed.intModIndex]);
								}
								else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet(obj, new object[1] { num }, (string[])null), (object)(short)75, false))
								{
									Globals_Renamed.arExpModParmsV[pDualIndex, Conversions.ToInteger(NewLateBinding.LateIndexGet(obj, new object[1] { num }, (string[])null)), Globals_Renamed.intModIndex] = Globals_Renamed.arExpModParmsVC[pDualIndex, Conversions.ToInteger(NewLateBinding.LateIndexGet(obj, new object[1] { num }, (string[])null)), Globals_Renamed.intModIndex];
									Globals_Renamed.arExpModParmsVC[pDualIndex, Conversions.ToInteger(NewLateBinding.LateIndexGet(obj, new object[1] { num }, (string[])null)), Globals_Renamed.intModIndex] = 998;
								}
								else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet(obj, new object[1] { num }, (string[])null), (object)(short)40, false))
								{
									Globals_Renamed.arExpModParmsVC[pDualIndex, Conversions.ToInteger(NewLateBinding.LateIndexGet(obj, new object[1] { num }, (string[])null)), Globals_Renamed.intModIndex] = 998;
								}
								else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet(obj, new object[1] { num }, (string[])null), (object)(short)57, false))
								{
									Globals_Renamed.arExpModParmsV[pDualIndex, Conversions.ToInteger(NewLateBinding.LateIndexGet(obj, new object[1] { num }, (string[])null)), Globals_Renamed.intModIndex] = Globals_Renamed.arExpModParmsVC[pDualIndex, Conversions.ToInteger(NewLateBinding.LateIndexGet(obj, new object[1] { num }, (string[])null)), Globals_Renamed.intModIndex];
									Globals_Renamed.arExpModParmsVC[pDualIndex, Conversions.ToInteger(NewLateBinding.LateIndexGet(obj, new object[1] { num }, (string[])null)), Globals_Renamed.intModIndex] = -1302;
								}
							}
							if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject((object)(Globals_Renamed.arExpModType[Globals_Renamed.intModIndex] == 45), Operators.CompareObjectEqual(NewLateBinding.LateIndexGet(obj, new object[1] { num }, (string[])null), (object)(short)78, false)), (object)(Globals_Renamed.arExpModParmsT[pDualIndex, 96, Globals_Renamed.intModIndex] == 1))))
							{
								Globals_Renamed.arExpModParmsV[pDualIndex, 96, Globals_Renamed.intModIndex] = GetParmDefaults.GetParmDefault3103(ref Globals_Renamed.intModIndex, ref pDualIndex);
							}
							pDualIndex = (short)unchecked(pDualIndex + 1);
							num18 = pDualIndex;
							num10 = 1;
						}
						while (num18 <= num10);
					}
					num2 = (short)unchecked(num2 + 1);
					num19 = num2;
					num10 = 1;
				}
				while (num19 <= num10);
				num = (short)unchecked(num + 1);
				num20 = num;
				num10 = 12;
			}
			while (num20 <= num10);
		}
	}

	public static string GetParmLabels(ref short pOpID, ref short pParmID)
	{
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
		Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		string result;
		if (pOpID >= 100)
		{
			command.ActiveConnection = Common.MyConn;
			command.CommandText = "pqryGetParmLabelOverrides";
			command.CommandType = CommandTypeEnum.adCmdStoredProc;
			command.Parameters.Append(command.CreateParameter("pOpID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, pOpID));
			command.Parameters.Append(command.CreateParameter("pParmID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, pParmID));
			Command command2 = command;
			object RecordsAffected = Missing.Value;
			object Parameters = Missing.Value;
			recordset = command2.Execute(out RecordsAffected, ref Parameters);
			command.Parameters.Delete("pOpID");
			command.Parameters.Delete("pParmID");
			result = ((!recordset.EOF) ? Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(recordset.Fields[1].Value, (object)": "), recordset.Fields[0].Value)) : Globals_Renamed.arParmNames[pParmID]);
			recordset.Close();
			recordset = null;
			command = null;
		}
		else
		{
			result = Globals_Renamed.arParmNames[pParmID];
		}
		return result;
	}

	public static void UpdateAnyExpLinks(ref short pModIndex)
	{
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num2 = default(int);
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
						short num3 = Globals_Renamed.arRelModType[Globals_Renamed.intModIndex];
						if ((num3 != 7 && num3 != 8 && num3 != 9 && num3 != 43) || 1 == 0 || Globals_Renamed.arExpModels[1, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] <= 0)
						{
							goto end_IL_0001;
						}
						short num4 = (short)(Globals_Renamed.arExpModels[1, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1);
						if (!((Globals_Renamed.arExpModType[num4] == 22) | (Globals_Renamed.arExpModType[num4] == 54)))
						{
							goto end_IL_0001;
						}
						if ((Globals_Renamed.arRelModOutputOn[0, Globals_Renamed.intModIndex] == 0) & (Globals_Renamed.arRelModOutputOn[1, Globals_Renamed.intModIndex] == 1))
						{
							short num5 = 0;
							short num6;
							short num7;
							do
							{
								Globals_Renamed.arExpModParmsV[num5, 49, num4] = Globals_Renamed.arRelModParmsV[1, 50, Globals_Renamed.intModIndex];
								Globals_Renamed.arExpModParmsV[num5, 50, num4] = Globals_Renamed.arRelModParmsV[1, 50, Globals_Renamed.intModIndex];
								num5 = (short)unchecked(num5 + 1);
								num6 = num5;
								num7 = 1;
							}
							while (num6 <= num7);
						}
						else if ((Globals_Renamed.arRelModOutputOn[0, Globals_Renamed.intModIndex] == 1) & (Globals_Renamed.arRelModOutputOn[1, Globals_Renamed.intModIndex] == 0))
						{
							short num5 = 0;
							short num8;
							short num7;
							do
							{
								Globals_Renamed.arExpModParmsV[num5, 49, num4] = Globals_Renamed.arRelModParmsV[0, 50, Globals_Renamed.intModIndex];
								Globals_Renamed.arExpModParmsV[num5, 50, num4] = Globals_Renamed.arRelModParmsV[0, 50, Globals_Renamed.intModIndex];
								num5 = (short)unchecked(num5 + 1);
								num8 = num5;
								num7 = 1;
							}
							while (num8 <= num7);
						}
						else
						{
							short num5 = 0;
							short num9;
							short num7;
							do
							{
								Globals_Renamed.arExpModParmsV[num5, 49, num4] = Globals_Renamed.arRelModParmsV[num5, 50, Globals_Renamed.intModIndex];
								Globals_Renamed.arExpModParmsV[num5, 50, num4] = Globals_Renamed.arRelModParmsV[num5, 50, Globals_Renamed.intModIndex];
								num5 = (short)unchecked(num5 + 1);
								num9 = num5;
								num7 = 1;
							}
							while (num9 <= num7);
						}
						goto end_IL_0001_2;
					}
					case 515:
						num = -1;
						switch (num2)
						{
						case 2:
							Interaction.MsgBox((object)"Error in UpdateAnyExpLinks, please contact Technical Support", (MsgBoxStyle)64, (object)"Error");
							goto end_IL_0001_2;
						}
						break;
					}
					goto IL_023d;
				}
				end_IL_0001_2:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 515;
				continue;
			}
			break;
			IL_023d:
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void ResetContParms(ref short pOpIndex, ref double pMyPvOp, ref bool pBatch)
	{
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
		Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		command.ActiveConnection = Common.MyConn;
		command.CommandText = "pqryGetActContTab";
		command.CommandType = CommandTypeEnum.adCmdStoredProc;
		short num = 0;
		checked
		{
			short num6;
			short num5;
			do
			{
				if (Globals_Renamed.arSelActType[num, pOpIndex] > 0)
				{
					Globals_Renamed.intOpIndex = pOpIndex;
					Globals_Renamed.intActIndex = num;
					command.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, Globals_Renamed.arSelActType[num, pOpIndex]));
					Command command2 = command;
					object RecordsAffected = Missing.Value;
					object Parameters = Missing.Value;
					recordset = command2.Execute(out RecordsAffected, ref Parameters);
					command.Parameters.Delete("pActID");
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields[0].Value)))
					{
						if (Operators.ConditionalCompareObjectEqual(recordset.Fields[0].Value, (object)2, false))
						{
							Globals_Renamed.arContParms[2, num, pOpIndex] = Globals_Renamed.arOpParms[10, pOpIndex];
						}
						else
						{
							Globals_Renamed.arContParms[2, num, pOpIndex] = Globals_Renamed.arOpParms[11, pOpIndex];
						}
					}
					recordset.Close();
					short pID = 94;
					ref float pValue = ref Globals_Renamed.arContParms[2, num, pOpIndex];
					short pVC = -1202;
					RollDownhillAct(ref pID, ref pValue, ref pVC);
					if (Globals_Renamed.arContParmTypes[8, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] != 2)
					{
						float num2 = Globals_Renamed.arOpParms[1, pOpIndex] * Globals_Renamed.arContParms[2, num, pOpIndex] * Globals_Renamed.arContParms[6, num, pOpIndex];
						if (num2 == 0f)
						{
							Globals_Renamed.arContParms[8, num, pOpIndex] = 0f;
						}
						else
						{
							Globals_Renamed.arContParms[8, num, pOpIndex] = (float)(pMyPvOp * (double)Globals_Renamed.arContParms[4, num, pOpIndex] / (double)num2);
						}
						pVC = 105;
						ref float pValue2 = ref Globals_Renamed.arContParms[8, num, pOpIndex];
						pID = -1208;
						RollDownhillAct(ref pVC, ref pValue2, ref pID);
					}
					if (Globals_Renamed.arContParmTypes[9, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] != 2)
					{
						if (pBatch & (Globals_Renamed.arOpParms[17, pOpIndex] < 1f))
						{
							Globals_Renamed.arContParms[9, num, pOpIndex] = Globals_Renamed.arOpParms[16, pOpIndex];
						}
						else
						{
							Globals_Renamed.arContParms[9, num, pOpIndex] = Globals_Renamed.arOpParms[2, pOpIndex];
						}
						pVC = 93;
						ref float pValue3 = ref Globals_Renamed.arContParms[9, num, pOpIndex];
						pID = -1209;
						RollDownhillAct(ref pVC, ref pValue3, ref pID);
					}
					if (Globals_Renamed.arContParmTypes[10, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] != 2)
					{
						if (Globals_Renamed.arContParms[9, num, pOpIndex] == 0f)
						{
							Globals_Renamed.arContParms[10, num, pOpIndex] = 0f;
						}
						else
						{
							Globals_Renamed.arContParms[10, num, pOpIndex] = Globals_Renamed.arContParms[8, num, pOpIndex] / Globals_Renamed.arContParms[9, num, pOpIndex];
						}
					}
					if (Globals_Renamed.arContParmTypes[7, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] != 2)
					{
						if (Globals_Renamed.arContParms[1, num, pOpIndex] == 0f)
						{
							Globals_Renamed.arContParms[7, num, pOpIndex] = 0f;
						}
						else
						{
							Globals_Renamed.arContParms[7, num, pOpIndex] = Globals_Renamed.arContParms[10, num, pOpIndex] / Globals_Renamed.arContParms[1, num, pOpIndex];
							pVC = 31;
							ref float pValue4 = ref Globals_Renamed.arContParms[7, num, pOpIndex];
							pID = -999;
							RollDownhillAct(ref pVC, ref pValue4, ref pID);
							short z = (short)(Globals_Renamed.arExpModels[1, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1);
							if (z > -1)
							{
								short num3 = Globals_Renamed.arExpModType[z];
								if ((num3 == 22 || num3 == 46 || num3 == 45) ? true : false)
								{
									short pDualIndex = 0;
									short num4;
									do
									{
										GetParmDefaults.LinkOHa(ref z, ref pDualIndex);
										pDualIndex = (short)unchecked(pDualIndex + 1);
										num4 = pDualIndex;
										num5 = 1;
									}
									while (num4 <= num5);
								}
							}
						}
					}
					Globals_Renamed.arContParms[11, num, pOpIndex] = Globals_Renamed.arContParms[6, num, pOpIndex] * Globals_Renamed.arContParms[2, num, pOpIndex];
					pVC = 111;
					ref float pValue5 = ref Globals_Renamed.arContParms[11, num, pOpIndex];
					pID = -1211;
					RollDownhillAct(ref pVC, ref pValue5, ref pID);
					Globals_Renamed.arContParms[12, num, pOpIndex] = Globals_Renamed.arContParms[6, num, pOpIndex] * Globals_Renamed.arContParms[2, num, pOpIndex] * Globals_Renamed.arContParms[10, num, pOpIndex];
					pVC = 112;
					ref float pValue6 = ref Globals_Renamed.arContParms[12, num, pOpIndex];
					pID = -1212;
					RollDownhillAct(ref pVC, ref pValue6, ref pID);
					Globals_Renamed.arContParms[13, num, pOpIndex] = Globals_Renamed.arContParms[6, num, pOpIndex] * Globals_Renamed.arContParms[10, num, pOpIndex];
					pVC = 87;
					ref float pValue7 = ref Globals_Renamed.arContParms[13, num, pOpIndex];
					pID = -1213;
					RollDownhillAct(ref pVC, ref pValue7, ref pID);
					ResetMetaDefaults();
				}
				num = (short)unchecked(num + 1);
				num6 = num;
				num5 = 24;
			}
			while (num6 <= num5);
			recordset = null;
			command = null;
		}
	}

	public static void CleanOutActArrays(ref short opindex, ref object ParSelActs, ref object ParSelActType, ref object ParSelActRa, ref object ParSelActEa, ref object ParSelActRaDMP, ref object ParSelActEaDMP, ref object ParSelActVolatile, ref object ParActNumWorkers, ref object parActNW_Route, ref object parActOrder)
	{
		short num = 0;
		checked
		{
			short num2;
			short num3;
			do
			{
				NewLateBinding.LateIndexSet(ParSelActs, new object[3] { num, opindex, "" }, (string[])null);
				NewLateBinding.LateIndexSet(ParSelActType, new object[3] { num, opindex, 0 }, (string[])null);
				NewLateBinding.LateIndexSet(ParSelActRa, new object[3] { num, opindex, false }, (string[])null);
				NewLateBinding.LateIndexSet(ParSelActEa, new object[3] { num, opindex, false }, (string[])null);
				NewLateBinding.LateIndexSet(ParSelActRaDMP, new object[3] { num, opindex, 0 }, (string[])null);
				NewLateBinding.LateIndexSet(ParSelActEaDMP, new object[3] { num, opindex, 0 }, (string[])null);
				NewLateBinding.LateIndexSet(ParSelActVolatile, new object[3] { num, opindex, 0 }, (string[])null);
				NewLateBinding.LateIndexSet(ParActNumWorkers, new object[4] { 0, num, opindex, 0 }, (string[])null);
				NewLateBinding.LateIndexSet(ParActNumWorkers, new object[4] { 1, num, opindex, 0 }, (string[])null);
				NewLateBinding.LateIndexSet(ParActNumWorkers, new object[4] { 2, num, opindex, 0 }, (string[])null);
				NewLateBinding.LateIndexSet(parActNW_Route, new object[3] { num, opindex, "" }, (string[])null);
				NewLateBinding.LateIndexSet(parActOrder, new object[3] { num, opindex, 0 }, (string[])null);
				num = (short)unchecked(num + 1);
				num2 = num;
				num3 = 24;
			}
			while (num2 <= num3);
		}
	}

	public static float GetXrmDefault(ref short pIntNumOps, ref bool pFirstOp, ref short pOpNumber, ref object arOpParms, ref object pArSubOpID)
	{
		if (pFirstOp)
		{
			return 1f;
		}
		return Conversions.ToSingle(NewLateBinding.LateIndexGet(arOpParms, new object[2]
		{
			(short)119,
			GetMyPred(ref pIntNumOps, ref pOpNumber, ref pArSubOpID)
		}, (string[])null));
	}

	public static bool CheckAVP()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			short num = (short)(Globals_Renamed.intNumOps - 1);
			short num2 = 0;
			while (true)
			{
				short num3 = num2;
				short num4 = num;
				if (num3 > num4)
				{
					break;
				}
				short num5 = 0;
				short num6;
				do
				{
					if (((Globals_Renamed.arSelActRaDMP[num5, num2] == 1) | (Globals_Renamed.arSelActRaDMP[num5, num2] == 2)) && CheckAVPSub(ref Globals_Renamed.arSelActType[num5, num2], ref Globals_Renamed.arSelActRaDMP[num5, num2]))
					{
						Interaction.MsgBox((object)"The default release and exposure models have already been defaulted for the previous adjusted vapor pressure (AVP) and AVP range. You may need to manually adjust your models based on the new VPchem, VP, correction factor, or AVP range.", (MsgBoxStyle)64, (object)"Warning");
						return true;
					}
					num5 = (short)unchecked(num5 + 1);
					num6 = num5;
					num4 = 24;
				}
				while (num6 <= num4);
				num5 = 0;
				short num7;
				do
				{
					if (((Globals_Renamed.arSelActEaDMP[num5, num2] == 1) | (Globals_Renamed.arSelActEaDMP[num5, num2] == 2)) && CheckAVPSub(ref Globals_Renamed.arSelActType[num5, num2], ref Globals_Renamed.arSelActEaDMP[num5, num2]))
					{
						Interaction.MsgBox((object)"The default release and exposure models have already been defaulted for the previous adjusted vapor pressure (AVP) and AVP range. You may need to manually adjust your models based on the new VPchem, VP, correction factor, or AVP range.", (MsgBoxStyle)64, (object)"Warning");
						return true;
					}
					num5 = (short)unchecked(num5 + 1);
					num7 = num5;
					num4 = 1;
				}
				while (num7 <= num4);
				num2 = (short)unchecked(num2 + 1);
			}
			bool result = default(bool);
			return result;
		}
	}

	public static bool CheckAVPSub(ref short pActID, ref short pPrevDMP)
	{
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
		Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		command.ActiveConnection = Common.MyConn;
		command.CommandText = "pqryGetActivity";
		command.CommandType = CommandTypeEnum.adCmdStoredProc;
		command.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, pActID));
		Command command2 = command;
		object RecordsAffected = Missing.Value;
		object Parameters = Missing.Value;
		recordset = command2.Execute(out RecordsAffected, ref Parameters);
		command.Parameters.Delete("pActID");
		bool flag = default(bool);
		if (Strings.InStr(Conversions.ToString(recordset.Fields[1].Value), "Product", (CompareMethod)0) > 0)
		{
			flag = true;
		}
		recordset.Close();
		if (flag)
		{
			if ((Conversions.ToSingle(frmMain.DefInstance.lblAVPlow.Text) <= Globals_Renamed.arOpParms[122, Globals_Renamed.intOpIndex]) & (Globals_Renamed.arOpParms[122, Globals_Renamed.intOpIndex] <= Conversions.ToSingle(frmMain.DefInstance.lblAVPhigh.Text)))
			{
				if (pPrevDMP == 2)
				{
					return true;
				}
			}
			else if (pPrevDMP == 1)
			{
				return true;
			}
		}
		else if ((Conversions.ToSingle(frmMain.DefInstance.lblAVPlow.Text) <= Globals_Renamed.arOpParms[121, Globals_Renamed.intOpIndex]) & (Globals_Renamed.arOpParms[121, Globals_Renamed.intOpIndex] <= Conversions.ToSingle(frmMain.DefInstance.lblAVPhigh.Text)))
		{
			if (pPrevDMP == 2)
			{
				return true;
			}
		}
		else if (pPrevDMP == 1)
		{
			return true;
		}
		recordset = null;
		command = null;
		bool result = default(bool);
		return result;
	}

	public static string TrtOpSPValues(ref short pParmID, ref short pValue)
	{
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		switch (pParmID)
		{
		case 1:
			if (pValue == 1)
			{
				return "HVLP Gun";
			}
			if (pValue == 2)
			{
				return "Conventional Gun";
			}
			return "Unspecified";
		case 2:
			if (pValue == 1)
			{
				return "Waterwash";
			}
			if (pValue == 2)
			{
				return "Dry Filter";
			}
			return "Unspecified";
		case 3:
			if (pValue == 1)
			{
				return "Downdraft";
			}
			if (pValue == 2)
			{
				return "Crossdraft";
			}
			return "Unspecified";
		case 47:
			if (pValue == 2)
			{
				return "Suspended Solids";
			}
			if (pValue == 1)
			{
				return "Organic Compounds";
			}
			return "Unspecified";
		default:
			Interaction.MsgBox((object)("Error in TrtOpSPValues: " + Conversions.ToString((int)pParmID) + ", " + Conversions.ToString((int)pValue)), (MsgBoxStyle)64, (object)"Please contact Technical Support");
			return "Error";
		}
	}

	public static string GetVCLabel(ref short pParmID, ref float pValue, ref short pModelType)
	{
		switch (pParmID)
		{
		case 43:
			if (pValue == 0.65f)
			{
				return "HVLP Gun";
			}
			if (pValue == 0.2f)
			{
				return "Conv Gun";
			}
			return "Unspecified";
		case 45:
			if (pValue == 0.96f)
			{
				return "Waterwash / Dry Filter";
			}
			return "Unspecified";
		case 52:
			if (pValue == 0.9f)
			{
				return "Waterwash";
			}
			if (pValue == 1f)
			{
				return "Dry Filter";
			}
			return "Unspecified";
		case 57:
		{
			if (pModelType == 18)
			{
				if (pValue == 1f)
				{
					return "Low end of range";
				}
				return "High end of range";
			}
			if (pModelType == 50)
			{
				float num2 = pValue;
				if (num2 == 1f)
				{
					return "Typical/Downdraft";
				}
				if (num2 == 2f)
				{
					return "High-End/Downdraft";
				}
				if (num2 == 3f)
				{
					return "Typical/Crossdraft";
				}
				if (num2 == 4f)
				{
					return "High-End/Crossdraft";
				}
				return "Error";
			}
			float num3 = pValue;
			if (num3 == 1f)
			{
				return "HVLP/Downdraft";
			}
			if (num3 == 2f)
			{
				return "Conv/Downdraft";
			}
			if (num3 == 3f)
			{
				return "HVLP/Crossdraft";
			}
			if (num3 == 4f)
			{
				return "Conv/Crossdraft";
			}
			return "Error";
		}
		case 142:
			if ((double)pValue == 0.97)
			{
				return "Suspended Solids";
			}
			if ((double)pValue == 0.5)
			{
				return "Organic Compounds";
			}
			return "User Specified";
		case 137:
			return "Mass Parm";
		case 141:
			return "Mass Parm";
		case 143:
		{
			float num = pValue;
			if (num == 1f || num == -1302f)
			{
				return "None";
			}
			if (num == 2f)
			{
				return "Mechanical collector/cyclone (low end; conservative)";
			}
			if (num == 3f)
			{
				return "Mechanical collector/cyclone (high end)";
			}
			if (num == 4f)
			{
				return "Fabric filter/baghouse (conservative)";
			}
			if (num == 5f)
			{
				return "Wet scrubber (low end; conservative)";
			}
			if (num == 6f)
			{
				return "Wet scrubber (high end)";
			}
			if (num == 7f)
			{
				return "User Specified";
			}
			return "DstCntrl Error (" + Conversions.ToString(pValue) + ")";
		}
		case 64:
		{
			if (pValue == 153f)
			{
				return "Near-Field";
			}
			if (pValue == 154f)
			{
				return "Far-Field";
			}
			if (pModelType == 0)
			{
				return "Near-Field";
			}
			if (pModelType == 1)
			{
				return "Far-Field";
			}
			string result = default(string);
			return result;
		}
		default:
			return "Error";
		}
	}

	public static float FindAssocRelModelValue(ref short pParmID, ref short pDualIndex)
	{
		short num = 9;
		checked
		{
			short num4;
			short num5;
			do
			{
				if (Globals_Renamed.arRelModels[num, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] > 0)
				{
					short num2 = (short)(Globals_Renamed.arRelModels[num, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1);
					short num3 = Globals_Renamed.arRelModType[num2];
					if ((num3 == 7 || num3 == 8 || num3 == 9 || num3 == 43) && true && Globals_Renamed.arRelModParmsT[pDualIndex, pParmID, num2] > 0)
					{
						if (Globals_Renamed.arRelModOutputOn[pDualIndex, num2] == 1)
						{
							return Globals_Renamed.arRelModParmsV[pDualIndex, pParmID, num2];
						}
						if (pDualIndex == 0)
						{
							return Globals_Renamed.arRelModParmsV[1, pParmID, num2];
						}
						return Globals_Renamed.arRelModParmsV[0, pParmID, num2];
					}
				}
				num = (short)unchecked(num + -1);
				num4 = num;
				num5 = 0;
			}
			while (num4 >= num5);
			num = 9;
			short num6;
			do
			{
				if (Globals_Renamed.arRelModels[num, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] > 0)
				{
					short num2 = (short)(Globals_Renamed.arRelModels[num, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1);
					if (Globals_Renamed.arRelModParmsT[pDualIndex, pParmID, num2] > 0)
					{
						if (Globals_Renamed.arRelModOutputOn[pDualIndex, num2] == 1)
						{
							return Globals_Renamed.arRelModParmsV[pDualIndex, pParmID, num2];
						}
						if (pDualIndex == 0)
						{
							return Globals_Renamed.arRelModParmsV[1, pParmID, num2];
						}
						return Globals_Renamed.arRelModParmsV[0, pParmID, num2];
					}
				}
				num = (short)unchecked(num + -1);
				num6 = num;
				num5 = 0;
			}
			while (num6 >= num5);
			return -1f;
		}
	}

	public static short FindAssocRelModelIndex(ref short pParmID)
	{
		short num = 9;
		checked
		{
			short num4;
			short num5;
			do
			{
				if (Globals_Renamed.arRelModels[num, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] > 0)
				{
					short num2 = (short)(Globals_Renamed.arRelModels[num, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1);
					if (Globals_Renamed.arRelModParmsT[0, pParmID, num2] > 0)
					{
						short num3 = Globals_Renamed.arRelModType[num2];
						if ((num3 == 7 || num3 == 8 || num3 == 9 || num3 == 43) ? true : false)
						{
							return num2;
						}
					}
				}
				num = (short)unchecked(num + -1);
				num4 = num;
				num5 = 0;
			}
			while (num4 >= num5);
			num = 9;
			short num7;
			do
			{
				if (Globals_Renamed.arRelModels[num, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] > 0)
				{
					short num2 = (short)(Globals_Renamed.arRelModels[num, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1);
					if (Globals_Renamed.arRelModParmsT[0, pParmID, num2] > 0)
					{
						short num6 = num2;
					}
				}
				num = (short)unchecked(num + -1);
				num7 = num;
				num5 = 0;
			}
			while (num7 >= num5);
			return -1;
		}
	}

	public static void AddRelModel(ref short pModType, ref short pModNum)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
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
						Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
						Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
						Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						ProjectData.ClearProjectError();
						num2 = 2;
						Globals_Renamed.gblIWasChanged = true;
						command.ActiveConnection = Common.MyConn;
						command.CommandText = "pqryGetRelModel";
						command.CommandType = CommandTypeEnum.adCmdStoredProc;
						command.Parameters.Append(command.CreateParameter("pRelModID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, pModType));
						Command command2 = command;
						object RecordsAffected = Missing.Value;
						object Parameters = Missing.Value;
						recordset = command2.Execute(out RecordsAffected, ref Parameters);
						command.Parameters.Delete("pRelModID");
						Globals_Renamed.intModIndex = Globals_Renamed.intNumRelModels;
						Globals_Renamed.intNumRelModels++;
						if ((pModNum == 0) & (Operators.CompareString(Globals_Renamed.arWaterBasis[Globals_Renamed.intOpIndex], "", false) == 0))
						{
							Globals_Renamed.arWaterBasis[Globals_Renamed.intOpIndex] = "IRER Note: The daily releases listed for any source below may coincide with daily releases from the other sources to the same medium. ";
						}
						Globals_Renamed.arRelModType = (short[])Utils.CopyArray((Array)Globals_Renamed.arRelModType, (Array)new short[Globals_Renamed.intNumRelModels + 1]);
						Globals_Renamed.arRelModBasis = (string[])Utils.CopyArray((Array)Globals_Renamed.arRelModBasis, (Array)new string[Globals_Renamed.intNumRelModels + 1]);
						Globals_Renamed.arRelModNAICS = (string[])Utils.CopyArray((Array)Globals_Renamed.arRelModNAICS, (Array)new string[Globals_Renamed.intNumRelModels + 1]);
						Globals_Renamed.arRelModStatus = (short[])Utils.CopyArray((Array)Globals_Renamed.arRelModStatus, (Array)new short[Globals_Renamed.intNumRelModels + 1]);
						Globals_Renamed.arRelModOutputOn = (short[,])Utils.CopyArray((Array)Globals_Renamed.arRelModOutputOn, (Array)new short[3, Globals_Renamed.intNumRelModels + 1]);
						Globals_Renamed.arRelModChar = (string[,])Utils.CopyArray((Array)Globals_Renamed.arRelModChar, (Array)new string[3, Globals_Renamed.intNumRelModels + 1]);
						Globals_Renamed.arRelModMedia = (float[,])Utils.CopyArray((Array)Globals_Renamed.arRelModMedia, (Array)new float[19, Globals_Renamed.intNumRelModels + 1]);
						Globals_Renamed.arRelModParmsV = (float[,,])Utils.CopyArray((Array)Globals_Renamed.arRelModParmsV, (Array)new float[3, 163, Globals_Renamed.intNumRelModels + 1]);
						Globals_Renamed.arRelModParmsT = (short[,,])Utils.CopyArray((Array)Globals_Renamed.arRelModParmsT, (Array)new short[3, 163, Globals_Renamed.intNumRelModels + 1]);
						Globals_Renamed.arRelModParmsVC = (short[,,])Utils.CopyArray((Array)Globals_Renamed.arRelModParmsVC, (Array)new short[3, 163, Globals_Renamed.intNumRelModels + 1]);
						Globals_Renamed.arRelModDRR = (float[,])Utils.CopyArray((Array)Globals_Renamed.arRelModDRR, (Array)new float[3, Globals_Renamed.intNumRelModels + 1]);
						Globals_Renamed.arRelModARR = (float[,])Utils.CopyArray((Array)Globals_Renamed.arRelModARR, (Array)new float[3, Globals_Renamed.intNumRelModels + 1]);
						Globals_Renamed.arRelModDOR = (short[,])Utils.CopyArray((Array)Globals_Renamed.arRelModDOR, (Array)new short[3, Globals_Renamed.intNumRelModels + 1]);
						Globals_Renamed.arRelModType[Globals_Renamed.intModIndex] = pModType;
						Globals_Renamed.arRelModBasis[Globals_Renamed.intModIndex] = Conversions.ToString(recordset.Fields["Basis"].Value);
						Globals_Renamed.arRelModOutputOn[0, Globals_Renamed.intModIndex] = Conversions.ToShort(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["OutputOn1"].Value)), (object)0, RuntimeHelpers.GetObjectValue(recordset.Fields["OutputOn1"].Value)));
						Globals_Renamed.arRelModOutputOn[1, Globals_Renamed.intModIndex] = Conversions.ToShort(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["OutputOn2"].Value)), (object)0, RuntimeHelpers.GetObjectValue(recordset.Fields["OutputOn2"].Value)));
						Globals_Renamed.arRelModChar[0, Globals_Renamed.intModIndex] = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["Char1"].Value)), (object)"", RuntimeHelpers.GetObjectValue(recordset.Fields["Char1"].Value)));
						Globals_Renamed.arRelModChar[1, Globals_Renamed.intModIndex] = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["Char2"].Value)), (object)"", RuntimeHelpers.GetObjectValue(recordset.Fields["Char2"].Value)));
						short num3 = 0;
						short num4;
						short num5;
						do
						{
							if (Globals_Renamed.arRelModOutputOn[num3, Globals_Renamed.intModIndex] < 0)
							{
								Globals_Renamed.arRelModOutputOn[num3, Globals_Renamed.intModIndex] = ConditionalOutputEnablement(ref Globals_Renamed.arRelModOutputOn[num3, Globals_Renamed.intModIndex]);
							}
							if (Operators.CompareString(Globals_Renamed.arRelModChar[num3, Globals_Renamed.intModIndex], "Output", false) == 0)
							{
								Globals_Renamed.arRelModChar[num3, Globals_Renamed.intModIndex] = "Output " + Conversions.ToString(num3 + 1);
							}
							num3 = (short)unchecked(num3 + 1);
							num4 = num3;
							num5 = 1;
						}
						while (num4 <= num5);
						Globals_Renamed.arRelModels[pModNum, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] = Globals_Renamed.intNumRelModels;
						PopParmsArraysR(ref Globals_Renamed.arSelActType[Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex], ref pModType);
						if ((pModType == 9) & ((Globals_Renamed.arSelActType[Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] == 1) | (Globals_Renamed.arSelActType[Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] == 55) | (Globals_Renamed.arSelActType[Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] == 56)))
						{
							num3 = 0;
							short num7;
							do
							{
								float num6 = Globals_Renamed.arRelModParmsV[num3, 26, Globals_Renamed.intModIndex];
								if (num6 == 10f)
								{
									Globals_Renamed.arRelModChar[num3, Globals_Renamed.intModIndex] = "Worst Case";
								}
								else if (num6 == 2.5f)
								{
									Globals_Renamed.arRelModChar[num3, Globals_Renamed.intModIndex] = "Typical";
								}
								num3 = (short)unchecked(num3 + 1);
								num7 = num3;
								num5 = 1;
							}
							while (num7 <= num5);
						}
						recordset.Close();
						command.ActiveConnection = Common.MyConn;
						command.CommandText = "pqryGetMediaDefaults";
						command.CommandType = CommandTypeEnum.adCmdStoredProc;
						command.Parameters.Append(command.CreateParameter("pRelModID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, pModType));
						Command command3 = command;
						Parameters = Missing.Value;
						RecordsAffected = Missing.Value;
						recordset = command3.Execute(out Parameters, ref RecordsAffected);
						command.Parameters.Delete("pRelModID");
						while (!recordset.EOF)
						{
							Globals_Renamed.arRelModMedia[Conversions.ToInteger(recordset.Fields["MediaID"].Value), Globals_Renamed.intModIndex] = Conversions.ToSingle(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["Pct"].Value)), (object)0, RuntimeHelpers.GetObjectValue(recordset.Fields["Pct"].Value)));
							recordset.MoveNext();
						}
						recordset.Close();
						recordset = null;
						command = null;
						goto end_IL_0001;
					}
					case 1943:
						num = -1;
						switch (num2)
						{
						case 2:
						{
							string Eobject = "ChemStrB";
							string Efunction = "AddRelModel";
							ErrObject val = Information.Err();
							int Enumber = val.Number;
							ErrObject val2 = Information.Err();
							string Edescription = val2.Description;
							bool Econtact = true;
							Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
							val2.Description = Edescription;
							val.Number = Enumber;
							goto end_IL_0001;
						}
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 1943;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static double Calc104_EP1(double pVbath, double pNbath, double pFreqbath, double pDbath, double pYbath, double pOD, double pDVrinse, double pDrinse, double pYrinse, double pRinseE)
	{
		if (pOD == 0.0)
		{
			return 0.0;
		}
		return pVbath * pNbath * pFreqbath * pDbath * 3.78 * pYbath / pOD + pDVrinse * pDrinse * 3.78 * pYrinse * (1.0 - pRinseE);
	}

	public static double Calc104_EP2(double pPVop, double pOD, double pADMUchem)
	{
		if (pPVop == 0.0 || pOD == 0.0 || pADMUchem == 0.0)
		{
			return 0.0;
		}
		return pPVop / pOD / pADMUchem;
	}

	public static void Reset_GSS_ElecBath(ref object COFarOpParms, ref short pOpID)
	{
		object obj = COFarOpParms;
		object[] array = new object[3]
		{
			(short)2,
			pOpID,
			null
		};
		object[] array2 = array;
		short pGSSID = 104;
		short pParmID = 2;
		array2[2] = SetGSSParmDefault2(ref pGSSID, ref pParmID);
		NewLateBinding.LateIndexSet(obj, array, (string[])null);
		object obj2 = COFarOpParms;
		array = new object[3]
		{
			(short)131,
			pOpID,
			null
		};
		object[] array3 = array;
		pParmID = 104;
		pGSSID = 131;
		array3[2] = SetGSSParmDefault(ref pParmID, ref pGSSID);
		NewLateBinding.LateIndexSet(obj2, array, (string[])null);
		object obj3 = COFarOpParms;
		array = new object[3]
		{
			(short)132,
			pOpID,
			null
		};
		object[] array4 = array;
		pParmID = 104;
		pGSSID = 132;
		array4[2] = SetGSSParmDefault(ref pParmID, ref pGSSID);
		NewLateBinding.LateIndexSet(obj3, array, (string[])null);
		object obj4 = COFarOpParms;
		array = new object[3]
		{
			(short)133,
			pOpID,
			null
		};
		object[] array5 = array;
		pParmID = 104;
		pGSSID = 133;
		array5[2] = SetGSSParmDefault(ref pParmID, ref pGSSID);
		NewLateBinding.LateIndexSet(obj4, array, (string[])null);
		object obj5 = COFarOpParms;
		array = new object[3]
		{
			(short)134,
			pOpID,
			null
		};
		object[] array6 = array;
		pParmID = 104;
		pGSSID = 134;
		array6[2] = SetGSSParmDefault(ref pParmID, ref pGSSID);
		NewLateBinding.LateIndexSet(obj5, array, (string[])null);
		object obj6 = COFarOpParms;
		array = new object[3]
		{
			(short)135,
			pOpID,
			null
		};
		object[] array7 = array;
		pParmID = 104;
		pGSSID = 135;
		array7[2] = SetGSSParmDefault(ref pParmID, ref pGSSID);
		NewLateBinding.LateIndexSet(obj6, array, (string[])null);
		object obj7 = COFarOpParms;
		array = new object[3]
		{
			(short)136,
			pOpID,
			null
		};
		object[] array8 = array;
		pParmID = 104;
		pGSSID = 136;
		array8[2] = SetGSSParmDefault(ref pParmID, ref pGSSID);
		NewLateBinding.LateIndexSet(obj7, array, (string[])null);
		object obj8 = COFarOpParms;
		array = new object[3]
		{
			(short)137,
			pOpID,
			null
		};
		object[] array9 = array;
		pParmID = 104;
		pGSSID = 137;
		array9[2] = SetGSSParmDefault(ref pParmID, ref pGSSID);
		NewLateBinding.LateIndexSet(obj8, array, (string[])null);
		object obj9 = COFarOpParms;
		array = new object[3]
		{
			(short)138,
			pOpID,
			null
		};
		object[] array10 = array;
		pParmID = 104;
		pGSSID = 138;
		array10[2] = SetGSSParmDefault(ref pParmID, ref pGSSID);
		NewLateBinding.LateIndexSet(obj9, array, (string[])null);
		object obj10 = COFarOpParms;
		array = new object[3]
		{
			(short)139,
			pOpID,
			null
		};
		object[] array11 = array;
		pParmID = 104;
		pGSSID = 139;
		array11[2] = SetGSSParmDefault(ref pParmID, ref pGSSID);
		NewLateBinding.LateIndexSet(obj10, array, (string[])null);
		NewLateBinding.LateIndexSet(COFarOpParms, new object[3]
		{
			(short)13,
			pOpID,
			Calc104_EP1(Conversions.ToDouble(NewLateBinding.LateIndexGet(COFarOpParms, new object[2]
			{
				(short)135,
				pOpID
			}, (string[])null)), Conversions.ToDouble(NewLateBinding.LateIndexGet(COFarOpParms, new object[2]
			{
				(short)136,
				pOpID
			}, (string[])null)), Conversions.ToDouble(NewLateBinding.LateIndexGet(COFarOpParms, new object[2]
			{
				(short)137,
				pOpID
			}, (string[])null)), Conversions.ToDouble(NewLateBinding.LateIndexGet(COFarOpParms, new object[2]
			{
				(short)133,
				pOpID
			}, (string[])null)), Conversions.ToDouble(NewLateBinding.LateIndexGet(COFarOpParms, new object[2]
			{
				(short)131,
				pOpID
			}, (string[])null)), Conversions.ToDouble(NewLateBinding.LateIndexGet(COFarOpParms, new object[2]
			{
				(short)2,
				pOpID
			}, (string[])null)), Conversions.ToDouble(NewLateBinding.LateIndexGet(COFarOpParms, new object[2]
			{
				(short)138,
				pOpID
			}, (string[])null)), Conversions.ToDouble(NewLateBinding.LateIndexGet(COFarOpParms, new object[2]
			{
				(short)134,
				pOpID
			}, (string[])null)), Conversions.ToDouble(NewLateBinding.LateIndexGet(COFarOpParms, new object[2]
			{
				(short)132,
				pOpID
			}, (string[])null)), Conversions.ToDouble(NewLateBinding.LateIndexGet(COFarOpParms, new object[2]
			{
				(short)139,
				pOpID
			}, (string[])null)))
		}, (string[])null);
		NewLateBinding.LateIndexSet(COFarOpParms, new object[3]
		{
			(short)1,
			pOpID,
			Calc104_EP2(frmMDUpdOpIP.DefInstance.MyPvOp, Conversions.ToDouble(NewLateBinding.LateIndexGet(COFarOpParms, new object[2]
			{
				(short)2,
				pOpID
			}, (string[])null)), Conversions.ToDouble(NewLateBinding.LateIndexGet(COFarOpParms, new object[2]
			{
				(short)13,
				pOpID
			}, (string[])null)))
		}, (string[])null);
		if (Operators.ConditionalCompareObjectLess(NewLateBinding.LateIndexGet(COFarOpParms, new object[2]
		{
			(short)1,
			pOpID
		}, (string[])null), (object)1, false))
		{
			NewLateBinding.LateIndexSet(COFarOpParms, new object[3]
			{
				(short)1,
				pOpID,
				1
			}, (string[])null);
			NewLateBinding.LateIndexSet(COFarOpParms, new object[3]
			{
				(short)2,
				pOpID,
				Calc104_EP2a(frmMDUpdOpIP.DefInstance.MyPvOp, Conversions.ToDouble(NewLateBinding.LateIndexGet(COFarOpParms, new object[2]
				{
					(short)1,
					pOpID
				}, (string[])null)), Conversions.ToDouble(NewLateBinding.LateIndexGet(COFarOpParms, new object[2]
				{
					(short)13,
					pOpID
				}, (string[])null)))
			}, (string[])null);
		}
		NewLateBinding.LateIndexSet(COFarOpParms, new object[3]
		{
			(short)13,
			pOpID,
			Calc104_EP3(frmMDUpdOpIP.DefInstance.MyPvOp, Conversions.ToDouble(NewLateBinding.LateIndexGet(COFarOpParms, new object[2]
			{
				(short)1,
				pOpID
			}, (string[])null)), Conversions.ToDouble(NewLateBinding.LateIndexGet(COFarOpParms, new object[2]
			{
				(short)2,
				pOpID
			}, (string[])null)))
		}, (string[])null);
		if (pOpID > 0)
		{
			NewLateBinding.LateIndexSet(COFarOpParms, new object[3]
			{
				(short)10,
				pOpID,
				checked(Calc104_EP4(pOpID + 1, Conversions.ToDouble(NewLateBinding.LateIndexGet(COFarOpParms, new object[2]
				{
					(short)10,
					pOpID - 1
				}, (string[])null))))
			}, (string[])null);
		}
		else
		{
			NewLateBinding.LateIndexSet(COFarOpParms, new object[3]
			{
				(short)10,
				pOpID,
				1
			}, (string[])null);
		}
		NewLateBinding.LateIndexSet(COFarOpParms, new object[3]
		{
			(short)11,
			pOpID,
			RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(COFarOpParms, new object[2]
			{
				(short)10,
				pOpID
			}, (string[])null))
		}, (string[])null);
		NewLateBinding.LateIndexSet(COFarOpParms, new object[3]
		{
			(short)12,
			pOpID,
			Calc104_EP5(Conversions.ToDouble(NewLateBinding.LateIndexGet(COFarOpParms, new object[2]
			{
				(short)13,
				pOpID
			}, (string[])null)), Conversions.ToDouble(NewLateBinding.LateIndexGet(COFarOpParms, new object[2]
			{
				(short)10,
				pOpID
			}, (string[])null)))
		}, (string[])null);
		NewLateBinding.LateIndexSet(COFarOpParms, new object[3]
		{
			(short)15,
			pOpID,
			RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(COFarOpParms, new object[2]
			{
				(short)13,
				pOpID
			}, (string[])null))
		}, (string[])null);
		NewLateBinding.LateIndexSet(COFarOpParms, new object[3]
		{
			(short)14,
			pOpID,
			Calc104_EP7(Conversions.ToDouble(NewLateBinding.LateIndexGet(COFarOpParms, new object[2]
			{
				(short)15,
				pOpID
			}, (string[])null)), Conversions.ToDouble(NewLateBinding.LateIndexGet(COFarOpParms, new object[2]
			{
				(short)11,
				pOpID
			}, (string[])null)))
		}, (string[])null);
	}

	public static float Calc104_EP2a(double pPVop, double pNS, double pADMUchem)
	{
		if (pPVop == 0.0 || pNS == 0.0 || pADMUchem == 0.0)
		{
			return 0f;
		}
		return (float)(pPVop / pNS / pADMUchem);
	}

	public static float Calc104_EP3(double pPVop, double pNS, double pOD)
	{
		if (pPVop == 0.0 || pNS == 0.0 || pOD == 0.0)
		{
			return 0f;
		}
		return (float)(pPVop / pNS / pOD);
	}

	public static float Calc104_EP4(double pNumOps, double pPrevYprod)
	{
		if (pNumOps > 0.0 && pPrevYprod > 0.0)
		{
			return (float)pPrevYprod;
		}
		return 1f;
	}

	public static float Calc104_EP5(double pADMUchem, double pYaddtv)
	{
		return (float)(pADMUchem / pYaddtv);
	}

	public static float Calc104_EP7(double pDMIchem, double pYrm)
	{
		return (float)(pDMIchem / pYrm);
	}

	public static void AddExpModel(ref short pModType, ref short pModNum)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
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
						Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
						Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
						Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						ProjectData.ClearProjectError();
						num2 = 2;
						Globals_Renamed.gblIWasChanged = true;
						Globals_Renamed.intModIndex = Globals_Renamed.intNumExpModels;
						Globals_Renamed.intNumExpModels++;
						command.ActiveConnection = Common.MyConn;
						command.CommandText = "pqryGetRelModel";
						command.CommandType = CommandTypeEnum.adCmdStoredProc;
						command.Parameters.Append(command.CreateParameter("pRelModID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, pModType));
						Command command2 = command;
						object RecordsAffected = Missing.Value;
						object Parameters = Missing.Value;
						recordset = command2.Execute(out RecordsAffected, ref Parameters);
						command.Parameters.Delete("pRelModID");
						Globals_Renamed.arExpModType = (short[])Utils.CopyArray((Array)Globals_Renamed.arExpModType, (Array)new short[Globals_Renamed.intNumExpModels + 1]);
						Globals_Renamed.arExpModOutputOn = (short[,])Utils.CopyArray((Array)Globals_Renamed.arExpModOutputOn, (Array)new short[3, Globals_Renamed.intNumExpModels + 1]);
						Globals_Renamed.arExpModChar = (string[,])Utils.CopyArray((Array)Globals_Renamed.arExpModChar, (Array)new string[3, Globals_Renamed.intNumExpModels + 1]);
						Globals_Renamed.arExpModBasis = (string[])Utils.CopyArray((Array)Globals_Renamed.arExpModBasis, (Array)new string[Globals_Renamed.intNumExpModels + 1]);
						Globals_Renamed.arExpModChmSt = (short[])Utils.CopyArray((Array)Globals_Renamed.arExpModChmSt, (Array)new short[Globals_Renamed.intNumExpModels + 1]);
						Globals_Renamed.arExpModUncertainty = (short[])Utils.CopyArray((Array)Globals_Renamed.arExpModUncertainty, (Array)new short[Globals_Renamed.intNumExpModels + 1]);
						Globals_Renamed.arExpModStatus = (short[])Utils.CopyArray((Array)Globals_Renamed.arExpModStatus, (Array)new short[Globals_Renamed.intNumExpModels + 1]);
						Globals_Renamed.arExpModChmSt[Globals_Renamed.intModIndex] = (short)SetChemStateID(ref pModType, Conversions.ToInteger(recordset.Fields["ChemStateID"].Value));
						Globals_Renamed.arExpModUncertainty[Globals_Renamed.intModIndex] = 1;
						Globals_Renamed.arExpModParmsV = (float[,,])Utils.CopyArray((Array)Globals_Renamed.arExpModParmsV, (Array)new float[3, 163, Globals_Renamed.intNumExpModels + 1]);
						Globals_Renamed.arExpModParmsT = (short[,,])Utils.CopyArray((Array)Globals_Renamed.arExpModParmsT, (Array)new short[3, 163, Globals_Renamed.intNumExpModels + 1]);
						Globals_Renamed.arExpModParmsVC = (short[,,])Utils.CopyArray((Array)Globals_Renamed.arExpModParmsVC, (Array)new short[3, 163, Globals_Renamed.intNumExpModels + 1]);
						Globals_Renamed.arExpModEst = (float[,,])Utils.CopyArray((Array)Globals_Renamed.arExpModEst, (Array)new float[3, 19, Globals_Renamed.intNumExpModels + 1]);
						Globals_Renamed.arExpModInhRC = (string[,])Utils.CopyArray((Array)Globals_Renamed.arExpModInhRC, (Array)new string[5, Globals_Renamed.intNumExpModels + 1]);
						Globals_Renamed.arExpModType[Globals_Renamed.intModIndex] = pModType;
						Globals_Renamed.arExpModBasis[Globals_Renamed.intModIndex] = Conversions.ToString(recordset.Fields["Basis"].Value);
						short num3 = 0;
						short num4;
						short num5;
						do
						{
							Globals_Renamed.arExpModOutputOn[num3, Globals_Renamed.intModIndex] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["OutputOn" + Conversions.ToString(num3 + 1)].Value)));
							Globals_Renamed.arExpModChar[num3, Globals_Renamed.intModIndex] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["Char" + Conversions.ToString(num3 + 1)].Value));
							if (Operators.CompareString(Globals_Renamed.arExpModChar[num3, Globals_Renamed.intModIndex], "Output", false) == 0)
							{
								Globals_Renamed.arExpModChar[num3, Globals_Renamed.intModIndex] = "Output " + Conversions.ToString(num3 + 1);
							}
							num3 = (short)unchecked(num3 + 1);
							num4 = num3;
							num5 = 1;
						}
						while (num4 <= num5);
						Globals_Renamed.arExpModels[pModNum, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] = Globals_Renamed.intNumExpModels;
						PopParmsArraysD(ref Globals_Renamed.arSelActType[Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex], ref pModType);
						recordset.Close();
						recordset = null;
						command = null;
						goto end_IL_0001;
					}
					case 1156:
						num = -1;
						switch (num2)
						{
						case 2:
						{
							string Eobject = "ChemStrB";
							string Efunction = "AddExpModel";
							ErrObject val = Information.Err();
							int Enumber = val.Number;
							ErrObject val2 = Information.Err();
							string Edescription = val2.Description;
							bool Econtact = true;
							Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
							val2.Description = Edescription;
							val.Number = Enumber;
							goto end_IL_0001;
						}
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 1156;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static short ParmCheckOp(ref short pParmID, ref short pValueID)
	{
		if (Globals_Renamed.arOpParms[pParmID, Globals_Renamed.intOpIndex] > Globals_Renamed.arOpParms[pValueID, Globals_Renamed.intOpIndex])
		{
			return pValueID;
		}
		return pParmID;
	}

	public static short ParmCheckCont(ref short pParmID, ref short pValueID, ref short pReturnID)
	{
		if (Globals_Renamed.arContParms[pParmID, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] > Globals_Renamed.arOpParms[pValueID, Globals_Renamed.intOpIndex])
		{
			return pValueID;
		}
		return pReturnID;
	}

	public static void RollXprodSideways(ref short pOpID, ref float pValue)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
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
						short num3 = 0;
						while (Globals_Renamed.arSubOpID[num3, pOpID] > 0)
						{
							short pOpID2 = (short)(Globals_Renamed.arSubOpID[num3, pOpID] - 1);
							if (Globals_Renamed.arOpParmsType[118, pOpID2] == 1)
							{
								Globals_Renamed.arOpParms[118, pOpID2] = pValue;
								if (Versioned.IsNumeric((object)frmMain.DefInstance.lblVP.Text))
								{
									Globals_Renamed.arOpParms[121, pOpID2] = pValue * Conversions.ToSingle(frmMain.DefInstance.lblVP.Text);
								}
								if (Globals_Renamed.arOpParmsType[119, pOpID2] == 1)
								{
									Globals_Renamed.arOpParms[119, pOpID2] = pValue;
									if (Versioned.IsNumeric((object)frmMain.DefInstance.lblVP.Text))
									{
										Globals_Renamed.arOpParms[122, pOpID2] = pValue * Conversions.ToSingle(frmMain.DefInstance.lblVP.Text);
									}
								}
								if (Globals_Renamed.arOpParmsType[120, pOpID2] == 1)
								{
									Globals_Renamed.arOpParms[120, pOpID2] = pValue;
								}
							}
							RollXprodSideways(ref pOpID2, ref pValue);
							num3 = (short)unchecked(num3 + 1);
							short num4 = num3;
							short num5 = 9;
							if (num4 > num5)
							{
								break;
							}
						}
						goto end_IL_0001;
					}
					case 423:
						num = -1;
						switch (num2)
						{
						case 2:
						{
							string Eobject = "ChemStrB.vb";
							string Efunction = "RollXprodSideways";
							ErrObject val = Information.Err();
							int Enumber = val.Number;
							ErrObject val2 = Information.Err();
							string Edescription = val2.Description;
							bool Econtact = true;
							Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
							val2.Description = Edescription;
							val.Number = Enumber;
							goto end_IL_0001;
						}
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 423;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static short GetMyPred(ref short pIntNumOps, ref short pOpID, ref object pArSubOpID)
	{
		checked
		{
			short num = (short)(pIntNumOps - 1);
			short num2 = 0;
			while (true)
			{
				short num3 = num2;
				short num4 = num;
				if (num3 > num4)
				{
					break;
				}
				short num5 = 0;
				short num6;
				do
				{
					if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet(pArSubOpID, new object[2] { num5, num2 }, (string[])null), (object)pOpID, false))
					{
						return num2;
					}
					num5 = (short)unchecked(num5 + 1);
					num6 = num5;
					num4 = 9;
				}
				while (num6 <= num4);
				num2 = (short)unchecked(num2 + 1);
			}
			Interaction.Beep();
			short result = default(short);
			return result;
		}
	}

	public static float ConvertKcKCodeToValue(ref float pID, ref short pDualID, ref short pModelID)
	{
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
		Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		command.ActiveConnection = Common.MyConn;
		command.CommandText = "pqryGetKCkValue";
		command.CommandType = CommandTypeEnum.adCmdStoredProc;
		command.Parameters.Append(command.CreateParameter("pModelID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, pModelID));
		command.Parameters.Append(command.CreateParameter("pDualID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, pDualID));
		command.Parameters.Append(command.CreateParameter("pLabelID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, pID));
		Command command2 = command;
		object RecordsAffected = Missing.Value;
		object Parameters = Missing.Value;
		recordset = command2.Execute(out RecordsAffected, ref Parameters);
		command.Parameters.Delete("pModelID");
		command.Parameters.Delete("pDualID");
		command.Parameters.Delete("pLabelID");
		float result;
		if (recordset.EOF)
		{
			Interaction.Beep();
			Interaction.MsgBox((object)("Error in ConvertKcKCodeToValue, please contact technical support. Code is " + Conversions.ToString(pID)), (MsgBoxStyle)16, (object)"Error");
			result = -1f;
		}
		else
		{
			result = Conversions.ToSingle(recordset.Fields[0].Value);
		}
		recordset.Close();
		recordset = null;
		command = null;
		return result;
	}

	public static void Update_Rel_Media_Percentages(ref object pMyModel)
	{
		short num;
		if (Globals_Renamed.arRelModOutputOn[1, Globals_Renamed.intModIndex] == 1)
		{
			num = 1;
		}
		else
		{
			if (Globals_Renamed.arRelModOutputOn[0, Globals_Renamed.intModIndex] != 1)
			{
				if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(pMyModel, (object)(short)48, false), Operators.CompareObjectEqual(pMyModel, (object)(short)41, false))))
				{
					Globals_Renamed.arRelModMedia[0, Globals_Renamed.intModIndex] = 0f;
					Globals_Renamed.arRelModMedia[13, Globals_Renamed.intModIndex] = 0f;
					Globals_Renamed.arRelModMedia[11, Globals_Renamed.intModIndex] = 0f;
				}
				else if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(pMyModel, (object)(short)51, false), Operators.CompareObjectEqual(pMyModel, (object)(short)52, false))))
				{
					Globals_Renamed.arRelModMedia[13, Globals_Renamed.intModIndex] = 0f;
					Globals_Renamed.arRelModMedia[8, Globals_Renamed.intModIndex] = 0f;
				}
				return;
			}
			num = 0;
		}
		checked
		{
			if (Operators.ConditionalCompareObjectEqual(pMyModel, (object)(short)48, false))
			{
				short num2 = 0;
				short num3;
				short num4;
				do
				{
					Globals_Renamed.arRelModMedia[num2, Globals_Renamed.intModIndex] = 0f;
					num2 = (short)unchecked(num2 + 1);
					num3 = num2;
					num4 = 17;
				}
				while (num3 <= num4);
				Globals_Renamed.arRelModMedia[0, Globals_Renamed.intModIndex] = (float)(Math.Round(1f - Globals_Renamed.arRelModParmsV[num, 45, Globals_Renamed.intModIndex], 4) * 100.0);
				Globals_Renamed.arRelModMedia[13, Globals_Renamed.intModIndex] = (float)(Math.Round(Globals_Renamed.arRelModParmsV[num, 45, Globals_Renamed.intModIndex] * (1f - Globals_Renamed.arRelModParmsV[num, 52, Globals_Renamed.intModIndex]), 4) * 100.0);
				Globals_Renamed.arRelModMedia[11, Globals_Renamed.intModIndex] = (float)(Math.Round(Globals_Renamed.arRelModParmsV[num, 45, Globals_Renamed.intModIndex] * Globals_Renamed.arRelModParmsV[num, 52, Globals_Renamed.intModIndex], 4) * 100.0);
			}
			else if (Operators.ConditionalCompareObjectEqual(pMyModel, (object)(short)41, false))
			{
				short num2 = 0;
				short num5;
				short num4;
				do
				{
					Globals_Renamed.arRelModMedia[num2, Globals_Renamed.intModIndex] = 0f;
					num2 = (short)unchecked(num2 + 1);
					num5 = num2;
					num4 = 17;
				}
				while (num5 <= num4);
				if (Globals_Renamed.arRelModParmsV[num, 52, Globals_Renamed.intModIndex] == 0.9f)
				{
					Globals_Renamed.arRelModMedia[0, Globals_Renamed.intModIndex] = (float)(Math.Round(1f - Globals_Renamed.arRelModParmsV[num, 45, Globals_Renamed.intModIndex], 4) * 100.0);
					Globals_Renamed.arRelModMedia[13, Globals_Renamed.intModIndex] = (float)(Math.Round(Globals_Renamed.arRelModParmsV[num, 45, Globals_Renamed.intModIndex] * (1f - Globals_Renamed.arRelModParmsV[num, 52, Globals_Renamed.intModIndex]), 4) * 100.0);
					Globals_Renamed.arRelModMedia[11, Globals_Renamed.intModIndex] = (float)(Math.Round(Globals_Renamed.arRelModParmsV[num, 45, Globals_Renamed.intModIndex] * Globals_Renamed.arRelModParmsV[num, 52, Globals_Renamed.intModIndex], 4) * 100.0);
				}
				else
				{
					Globals_Renamed.arRelModMedia[0, Globals_Renamed.intModIndex] = (float)(Math.Round(1f - Globals_Renamed.arRelModParmsV[num, 45, Globals_Renamed.intModIndex], 4) * 100.0);
					Globals_Renamed.arRelModMedia[13, Globals_Renamed.intModIndex] = (float)(Math.Round(Globals_Renamed.arRelModParmsV[num, 45, Globals_Renamed.intModIndex] * (1f - Globals_Renamed.arRelModParmsV[num, 52, Globals_Renamed.intModIndex]), 4) * 100.0);
					Globals_Renamed.arRelModMedia[8, Globals_Renamed.intModIndex] = (float)(Math.Round(Globals_Renamed.arRelModParmsV[num, 45, Globals_Renamed.intModIndex] * Globals_Renamed.arRelModParmsV[num, 52, Globals_Renamed.intModIndex], 4) * 100.0);
				}
			}
			else if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(pMyModel, (object)(short)51, false), Operators.CompareObjectEqual(pMyModel, (object)(short)52, false))))
			{
				short num2 = 0;
				short num6;
				short num4;
				do
				{
					Globals_Renamed.arRelModMedia[num2, Globals_Renamed.intModIndex] = 0f;
					num2 = (short)unchecked(num2 + 1);
					num6 = num2;
					num4 = 17;
				}
				while (num6 <= num4);
				Globals_Renamed.arRelModMedia[13, Globals_Renamed.intModIndex] = (short)Math.Round((1f - Globals_Renamed.arRelModParmsV[num, 142, Globals_Renamed.intModIndex]) * 100f);
				Globals_Renamed.arRelModMedia[8, Globals_Renamed.intModIndex] = Globals_Renamed.arRelModParmsV[num, 142, Globals_Renamed.intModIndex] * 100f;
			}
			else
			{
				if (!Operators.ConditionalCompareObjectEqual(pMyModel, (object)(short)53, false))
				{
					return;
				}
				short num2 = 0;
				short num7;
				short num4;
				do
				{
					Globals_Renamed.arRelModMedia[num2, Globals_Renamed.intModIndex] = 0f;
					num2 = (short)unchecked(num2 + 1);
					num7 = num2;
					num4 = 17;
				}
				while (num7 <= num4);
				float num8 = Globals_Renamed.arRelModParmsV[num, 143, Globals_Renamed.intModIndex];
				if (num8 == 1f)
				{
					Globals_Renamed.arRelModMedia[3, Globals_Renamed.intModIndex] = 100f;
				}
				else if (num8 == -1302f)
				{
					if (Globals_Renamed.arRelModParmsVC[num, 144, Globals_Renamed.intModIndex] == 999)
					{
						Globals_Renamed.arRelModMedia[9, Globals_Renamed.intModIndex] = Globals_Renamed.arRelModParmsV[num, 144, Globals_Renamed.intModIndex] * 100f;
						Globals_Renamed.arRelModMedia[5, Globals_Renamed.intModIndex] = (float)((double)(short)Math.Round((1f - Globals_Renamed.arRelModParmsV[num, 144, Globals_Renamed.intModIndex]) * 1000f) / 10.0);
					}
					else
					{
						Globals_Renamed.arRelModMedia[3, Globals_Renamed.intModIndex] = 100f;
					}
				}
				else if ((num8 == 2f || num8 == 3f || num8 == 4f) ? true : false)
				{
					Globals_Renamed.arRelModMedia[8, Globals_Renamed.intModIndex] = Globals_Renamed.arRelModParmsV[num, 144, Globals_Renamed.intModIndex] * 100f;
					Globals_Renamed.arRelModMedia[5, Globals_Renamed.intModIndex] = (float)((double)(short)Math.Round((1f - Globals_Renamed.arRelModParmsV[num, 144, Globals_Renamed.intModIndex]) * 1000f) / 10.0);
				}
				else
				{
					Globals_Renamed.arRelModMedia[9, Globals_Renamed.intModIndex] = Globals_Renamed.arRelModParmsV[num, 144, Globals_Renamed.intModIndex] * 100f;
					Globals_Renamed.arRelModMedia[5, Globals_Renamed.intModIndex] = (float)((double)(short)Math.Round((1f - Globals_Renamed.arRelModParmsV[num, 144, Globals_Renamed.intModIndex]) * 1000f) / 10.0);
				}
			}
		}
	}

	public static void RefreshAllLinks()
	{
		checked
		{
			short z = (short)(Globals_Renamed.arExpModels[1, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1);
			if (z <= -1)
			{
				return;
			}
			short num = Globals_Renamed.arExpModType[z];
			if ((num == 22 || num == 46 || num == 45 || num == 54) ? true : false)
			{
				short pDualIndex = 0;
				short num2;
				short num3;
				do
				{
					GetParmDefaults.LinkFreq(ref z, ref pDualIndex);
					GetParmDefaults.LinkX(ref z, ref pDualIndex);
					GetParmDefaults.LinkVzCB(ref z, ref pDualIndex);
					GetParmDefaults.LinkOHa(ref z, ref pDualIndex);
					GetParmDefaults.LinkVP(ref z, ref pDualIndex);
					GetParmDefaults.LinkGinput(ref z, ref pDualIndex);
					GetParmDefaults.LinkGoutput(ref z, ref pDualIndex);
					pDualIndex = (short)unchecked(pDualIndex + 1);
					num2 = pDualIndex;
					num3 = 1;
				}
				while (num2 <= num3);
			}
		}
	}

	public static string CalcCm(ref object pCv, ref object pMW, ref object pVm, ref object pYs)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		string text = default(string);
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
					text = ((!(Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(pCv)) & Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(pMW)) & Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(pVm)) & Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(pYs)))) ? "0" : ((!Operators.ConditionalCompareObjectEqual(pVm, (object)0, false)) ? ShowInSciNot(Operators.MultiplyObject(Operators.DivideObject(Operators.MultiplyObject(pCv, pMW), pVm), pYs)) : "0"));
					goto end_IL_0001;
				case 225:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						string Eobject = "ChemStrBas.Bas";
						string Efunction = "CalcCm";
						ErrObject val = Information.Err();
						int Enumber = val.Number;
						ErrObject val2 = Information.Err();
						string Edescription = val2.Description;
						bool Econtact = true;
						Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
						val2.Description = Edescription;
						val.Number = Enumber;
						goto end_IL_0001;
					}
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 225;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		string result = text;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static string TrtLineBreak(ref string pText)
	{
		return pText;
	}

	public static float CalcRaoultsFormula(ref float Y, ref float mw, ref object arYa, ref object arMWa)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		float num8 = default(float);
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
						float num3 = Y / mw;
						float num4 = num3;
						short num5 = 0;
						short num6;
						short num7;
						do
						{
							if ((Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(arMWa, new object[1] { num5 }, (string[])null))) & Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(arYa, new object[1] { num5 }, (string[])null)))) && Conversions.ToSingle(NewLateBinding.LateIndexGet(arMWa, new object[1] { num5 }, (string[])null)) != 0f)
							{
								num3 += Conversions.ToSingle(NewLateBinding.LateIndexGet(arYa, new object[1] { num5 }, (string[])null)) / Conversions.ToSingle(NewLateBinding.LateIndexGet(arMWa, new object[1] { num5 }, (string[])null));
							}
							num5 = (short)unchecked(num5 + 1);
							num6 = num5;
							num7 = 4;
						}
						while (num6 <= num7);
						num8 = ((num3 != 0f) ? (num4 / num3) : 0f);
						goto end_IL_0001;
					}
					case 368:
						num = -1;
						switch (num2)
						{
						case 2:
						{
							string Eobject = "ChemStrB.Bas";
							string Efunction = "CalcRaoultsFormula";
							ErrObject val = Information.Err();
							int Enumber = val.Number;
							ErrObject val2 = Information.Err();
							string Edescription = val2.Description;
							bool Econtact = true;
							Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
							val2.Description = Edescription;
							val.Number = Enumber;
							goto end_IL_0001;
						}
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 368;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		float result = num8;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private static short ConditionalOutputEnablement(ref short pLogicID)
	{
		short num = Globals_Renamed.arSelActType[Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex];
		if ((num == 1 || num == 55 || num == 56) ? true : false)
		{
			return 1;
		}
		return 0;
	}

	public static void RolldownhillDrm(ref short pOp, ref float pNewValue, ref float pOldValue)
	{
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
		Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		command.ActiveConnection = Common.MyConn;
		command.CommandText = "pqryGetActContTab";
		command.CommandType = CommandTypeEnum.adCmdStoredProc;
		short num = 0;
		checked
		{
			short num10;
			short num6;
			do
			{
				if ((Globals_Renamed.arContParms[5, num, pOp] == pOldValue) & (Globals_Renamed.arSelActType[num, pOp] > 0))
				{
					command.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, Globals_Renamed.arSelActType[num, pOp]));
					Command command2 = command;
					object RecordsAffected = Missing.Value;
					object Parameters = Missing.Value;
					recordset = command2.Execute(out RecordsAffected, ref Parameters);
					command.Parameters.Delete("pActID");
					if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(recordset.Fields[0].Value, (object)(short)1, false), Operators.CompareObjectEqual(recordset.Fields[0].Value, (object)(short)3, false))))
					{
						Globals_Renamed.arContParms[5, num, pOp] = pNewValue;
						Globals_Renamed.arContParms[6, num, pOp] = (float)((double)(Globals_Renamed.arContParms[3, num, pOp] * Globals_Renamed.arContParms[5, num, pOp]) * 3.785);
						short pID = 110;
						ref float pValue = ref Globals_Renamed.arContParms[6, num, pOp];
						short pVC = -1206;
						RollDownhillAct(ref pID, ref pValue, ref pVC);
						short num2 = 0;
						short num7;
						do
						{
							if (Globals_Renamed.arRelModels[num2, num, pOp] > 0)
							{
								short num3 = (short)(Globals_Renamed.arRelModels[num2, num, pOp] - 1);
								short num4 = 0;
								short num5;
								do
								{
									if (Globals_Renamed.arRelModParmsV[num4, 100, num3] == pOldValue)
									{
										Globals_Renamed.arRelModParmsV[num4, 100, num3] = pNewValue;
									}
									num4 = (short)unchecked(num4 + 1);
									num5 = num4;
									num6 = 1;
								}
								while (num5 <= num6);
							}
							num2 = (short)unchecked(num2 + 1);
							num7 = num2;
							num6 = 9;
						}
						while (num7 <= num6);
						num2 = 0;
						short num9;
						do
						{
							if (Globals_Renamed.arExpModels[num2, num, pOp] > 0)
							{
								short num3 = (short)(Globals_Renamed.arExpModels[num2, num, pOp] - 1);
								short num4 = 0;
								short num8;
								do
								{
									if (Globals_Renamed.arExpModParmsV[num4, 100, num3] == pOldValue)
									{
										Globals_Renamed.arExpModParmsV[num4, 100, num3] = pNewValue;
									}
									num4 = (short)unchecked(num4 + 1);
									num8 = num4;
									num6 = 1;
								}
								while (num8 <= num6);
							}
							num2 = (short)unchecked(num2 + 1);
							num9 = num2;
							num6 = 1;
						}
						while (num9 <= num6);
					}
					recordset.Close();
					recordset = null;
				}
				num = (short)unchecked(num + 1);
				num10 = num;
				num6 = 24;
			}
			while (num10 <= num6);
			command = null;
		}
	}

	public static void RolldownhillDprod(ref short pOp, ref float pNewValue, ref float pOldValue)
	{
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
		Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		short num = 0;
		checked
		{
			short num10;
			short num6;
			do
			{
				command.ActiveConnection = Common.MyConn;
				command.CommandText = "pqryGetActContTab";
				command.CommandType = CommandTypeEnum.adCmdStoredProc;
				if ((Globals_Renamed.arContParms[5, num, pOp] == pOldValue) & (Globals_Renamed.arSelActType[num, pOp] > 0))
				{
					command.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, Globals_Renamed.arSelActType[num, pOp]));
					Command command2 = command;
					object RecordsAffected = Missing.Value;
					object Parameters = Missing.Value;
					recordset = command2.Execute(out RecordsAffected, ref Parameters);
					command.Parameters.Delete("pActID");
					if (Operators.ConditionalCompareObjectEqual(recordset.Fields[0].Value, (object)(short)2, false))
					{
						Globals_Renamed.arContParms[5, num, pOp] = pNewValue;
						Globals_Renamed.arContParms[6, num, pOp] = (float)((double)(Globals_Renamed.arContParms[3, num, pOp] * Globals_Renamed.arContParms[5, num, pOp]) * 3.785);
						short pID = 110;
						ref float pValue = ref Globals_Renamed.arContParms[6, num, pOp];
						short pVC = -1206;
						RollDownhillAct(ref pID, ref pValue, ref pVC);
						short num2 = 0;
						short num7;
						do
						{
							if (Globals_Renamed.arRelModels[num2, num, pOp] > 0)
							{
								short num3 = (short)(Globals_Renamed.arRelModels[num2, num, pOp] - 1);
								short num4 = 0;
								short num5;
								do
								{
									if (Globals_Renamed.arRelModParmsV[num4, 100, num3] == pOldValue)
									{
										Globals_Renamed.arRelModParmsV[num4, 100, num3] = pNewValue;
									}
									num4 = (short)unchecked(num4 + 1);
									num5 = num4;
									num6 = 1;
								}
								while (num5 <= num6);
							}
							num2 = (short)unchecked(num2 + 1);
							num7 = num2;
							num6 = 9;
						}
						while (num7 <= num6);
						num2 = 0;
						short num9;
						do
						{
							if (Globals_Renamed.arExpModels[num2, num, pOp] > 0)
							{
								short num3 = (short)(Globals_Renamed.arExpModels[num2, num, pOp] - 1);
								short num4 = 0;
								short num8;
								do
								{
									if (Globals_Renamed.arExpModParmsV[num4, 100, num3] == pOldValue)
									{
										Globals_Renamed.arExpModParmsV[num4, 100, num3] = pNewValue;
									}
									num4 = (short)unchecked(num4 + 1);
									num8 = num4;
									num6 = 1;
								}
								while (num8 <= num6);
							}
							num2 = (short)unchecked(num2 + 1);
							num9 = num2;
							num6 = 1;
						}
						while (num9 <= num6);
					}
					recordset.Close();
					recordset = null;
				}
				num = (short)unchecked(num + 1);
				num10 = num;
				num6 = 24;
			}
			while (num10 <= num6);
			command = null;
		}
	}

	public static string GetModelStatus(ref short iModStatus)
	{
		return "Model Status: " + iModStatus switch
		{
			0 => "Model never run", 
			1 => "Model was unsuccessful", 
			2 => "Model was successfully run", 
			3 => "Model parameters have changed, please re-run the models", 
			_ => "Error in GetModelStatus - unknown status code. Please contact Technical Support.", 
		};
	}

	public static bool SetVolatilityFlag(ref short pOpIndex)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		short num3 = default(short);
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
						Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
						Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
						Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						ProjectData.ClearProjectError();
						num2 = 2;
						if (Versioned.IsNumeric((object)frmMain.DefInstance.lblVP.Text))
						{
							command.ActiveConnection = Common.MyConn;
							command.CommandText = "pqryGetActivity";
							command.CommandType = CommandTypeEnum.adCmdStoredProc;
							num3 = 0;
							short num4;
							short num5;
							do
							{
								if (Globals_Renamed.arSelActType[num3, pOpIndex] > 0)
								{
									command.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, Globals_Renamed.arSelActType[num3, pOpIndex]));
									Command command2 = command;
									object RecordsAffected = Missing.Value;
									object Parameters = Missing.Value;
									recordset = command2.Execute(out RecordsAffected, ref Parameters);
									command.Parameters.Delete("pActID");
									if (Strings.InStr(Conversions.ToString(recordset.Fields[1].Value), "Product", (CompareMethod)0) > 0)
									{
										if (Conversions.ToDouble(frmMain.DefInstance.lblAVPlow.Text) <= (double)Globals_Renamed.arOpParms[122, Globals_Renamed.intOpIndex])
										{
											Globals_Renamed.arSelActVolatile[num3, pOpIndex] = 1;
										}
										else
										{
											Globals_Renamed.arSelActVolatile[num3, pOpIndex] = 0;
										}
									}
									else if (Conversions.ToDouble(frmMain.DefInstance.lblAVPlow.Text) <= (double)Globals_Renamed.arOpParms[121, Globals_Renamed.intOpIndex])
									{
										Globals_Renamed.arSelActVolatile[num3, pOpIndex] = 1;
									}
									else
									{
										Globals_Renamed.arSelActVolatile[num3, pOpIndex] = 0;
									}
									recordset.Close();
									recordset = null;
								}
								else
								{
									Globals_Renamed.arSelActVolatile[num3, pOpIndex] = 0;
								}
								num3 = (short)unchecked(num3 + 1);
								num4 = num3;
								num5 = 24;
							}
							while (num4 <= num5);
							command = null;
						}
						else
						{
							Globals_Renamed.arSelActVolatile[num3, pOpIndex] = 0;
						}
						goto end_IL_0001;
					}
					case 619:
						num = -1;
						switch (num2)
						{
						case 2:
						{
							string Eobject = "ChemStrB.vb";
							string Efunction = "SetVolatilityFlag";
							ErrObject val = Information.Err();
							int Enumber = val.Number;
							ErrObject val2 = Information.Err();
							string Edescription = val2.Description;
							bool Econtact = true;
							Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
							val2.Description = Edescription;
							val.Number = Enumber;
							goto end_IL_0001;
						}
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 619;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		bool result = default(bool);
		return result;
	}

	public static int SetChemStateID(ref short pModelID, int pChemStateID)
	{
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
		Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		if (pModelID == 46)
		{
			command.ActiveConnection = Common.MyConn;
			command.CommandText = "pqryGetActContTab";
			command.CommandType = CommandTypeEnum.adCmdStoredProc;
			command.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, Globals_Renamed.arSelActType[Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex]));
			Command command2 = command;
			object RecordsAffected = Missing.Value;
			object Parameters = Missing.Value;
			recordset = command2.Execute(out RecordsAffected, ref Parameters);
			command.Parameters.Delete("pActID");
			float num = ((Strings.InStr(Conversions.ToString(recordset.Fields[2].Value), "Raw Material", (CompareMethod)0) > 0) ? Globals_Renamed.arOpParms[121, Globals_Renamed.intOpIndex] : ((Strings.InStr(Conversions.ToString(recordset.Fields[2].Value), "Product", (CompareMethod)0) > 0) ? Globals_Renamed.arOpParms[122, Globals_Renamed.intOpIndex] : ((Globals_Renamed.arOpType[Globals_Renamed.intOpIndex] != 1) ? Globals_Renamed.arOpParms[121, Globals_Renamed.intOpIndex] : Globals_Renamed.arOpParms[122, Globals_Renamed.intOpIndex])));
			recordset.Close();
			recordset = null;
			command = null;
			if (num < Conversions.ToSingle(frmMain.DefInstance.lblAVPlow.Text))
			{
				return 2;
			}
			return pChemStateID;
		}
		return pChemStateID;
	}

	public static void SetOER()
	{
		float[] array = new float[3];
		long num = 0L;
		bool flag = default(bool);
		checked
		{
			short num2 = (short)(Globals_Renamed.intNumOps - 1);
			short num3 = 0;
			while (true)
			{
				short num4 = num3;
				short num5 = num2;
				if (num4 > num5)
				{
					break;
				}
				num += Globals_Renamed.arOpNumWorkers[1, num3];
				short num6 = 0;
				short num12;
				do
				{
					if (Globals_Renamed.arSelActEa[num6, num3])
					{
						short num7 = 0;
						short num11;
						do
						{
							if (Globals_Renamed.arExpModels[num7, num6, num3] > 0)
							{
								flag = true;
								short num8 = 0;
								short num10;
								do
								{
									short num9 = Conversions.ToShort(Interaction.IIf(num7 == 0, (object)8, (object)4));
									if (Globals_Renamed.arExpModEst[num8, num9, Globals_Renamed.arExpModels[num7, num6, num3] - 1] > array[num7])
									{
										array[num7] = Globals_Renamed.arExpModEst[num8, num9, Globals_Renamed.arExpModels[num7, num6, num3] - 1];
									}
									num8 = (short)unchecked(num8 + 1);
									num10 = num8;
									num5 = 1;
								}
								while (num10 <= num5);
							}
							num7 = (short)unchecked(num7 + 1);
							num11 = num7;
							num5 = 1;
						}
						while (num11 <= num5);
					}
					num6 = (short)unchecked(num6 + 1);
					num12 = num6;
					num5 = 24;
				}
				while (num12 <= num5);
				num3 = (short)unchecked(num3 + 1);
			}
		}
		string text = ((!flag) ? ((!((Operators.CompareString(frmMain.DefInstance.lblSatHReq[(short)0].Text, "Yes", false) == 0) | (Operators.CompareString(frmMain.DefInstance.lblSatHReq[(short)2].Text, "Yes", false) == 0))) ? "NR" : "0-1") : ((((array[0] == 0f) & (array[1] == 0f)) || num == 0) ? "0-1" : ((array[1] == 0f) ? "1" : ((array[1] < 1f) ? "1-2" : ((!(array[1] <= 10f)) ? "2-3" : "2")))));
		string text2 = default(string);
		if ((Operators.CompareString(text, "NR", false) != 0) & (Operators.CompareString(text, "0-1", false) != 0))
		{
			text2 = ((num < 10) ? "A" : ((num < 100) ? "B" : ((num >= 1000) ? "D" : "C")));
		}
		frmMain.DefInstance.lblOccExpRating.Text = text + text2;
	}

	public static void DeriveNWdefault()
	{
		long[] array = new long[3];
		long[] array2 = new long[3];
		long[] array3 = new long[3];
		bool[] array4 = new bool[3];
		Globals_Renamed.arOpNumWorkers[0, Globals_Renamed.intOpIndex] = 0L;
		short num = 0;
		checked
		{
			short num9;
			short num4;
			do
			{
				if (Strings.Len(Globals_Renamed.arSelActs[num, Globals_Renamed.intOpIndex]) > 0)
				{
					short num2 = 0;
					short num3;
					do
					{
						array[num2] = 0L;
						array2[num2] = 0L;
						array3[num2] = 0L;
						num2 = (short)unchecked(num2 + 1);
						num3 = num2;
						num4 = 1;
					}
					while (num3 <= num4);
					short num5 = 0;
					short num8;
					do
					{
						if (Globals_Renamed.arExpModels[num5, num, Globals_Renamed.intOpIndex] > 0)
						{
							int num6 = Globals_Renamed.arExpModels[num5, num, Globals_Renamed.intOpIndex] - 1;
							num2 = 0;
							short num7;
							do
							{
								if (Globals_Renamed.arExpModOutputOn[num2, num6] == 1 && Globals_Renamed.arExpModParmsV[num2, 1, num6] * Globals_Renamed.arExpModParmsV[num2, 91, num6] > (float)array3[num5])
								{
									array[num5] = (long)Math.Round(Globals_Renamed.arExpModParmsV[num2, 1, num6]);
									array2[num5] = (long)Math.Round(Globals_Renamed.arExpModParmsV[num2, 91, num6]);
									array3[num5] = (long)Math.Round(Globals_Renamed.arExpModParmsV[num2, 1, num6] * Globals_Renamed.arExpModParmsV[num2, 91, num6]);
								}
								num2 = (short)unchecked(num2 + 1);
								num7 = num2;
								num4 = 1;
							}
							while (num7 <= num4);
						}
						num5 = (short)unchecked(num5 + 1);
						num8 = num5;
						num4 = 1;
					}
					while (num8 <= num4);
					if (array3[0] == array3[1])
					{
						Globals_Renamed.arActNW_Route[num, Globals_Renamed.intOpIndex] = "Inhalation and Dermal";
						num2 = 0;
					}
					else if (array3[0] > array3[1])
					{
						Globals_Renamed.arActNW_Route[num, Globals_Renamed.intOpIndex] = "Dermal";
						num2 = 0;
					}
					else
					{
						Globals_Renamed.arActNW_Route[num, Globals_Renamed.intOpIndex] = "Inhalation";
						num2 = 1;
					}
					Globals_Renamed.arActNumWorkers[0, num, Globals_Renamed.intOpIndex] = array[num2];
					Globals_Renamed.arActNumWorkers[1, num, Globals_Renamed.intOpIndex] = array2[num2];
					Globals_Renamed.arActNumWorkers[2, num, Globals_Renamed.intOpIndex] = array3[num2];
					Globals_Renamed.arOpNumWorkers[0, Globals_Renamed.intOpIndex] = Globals_Renamed.arOpNumWorkers[0, Globals_Renamed.intOpIndex] + array3[num2];
				}
				num = (short)unchecked(num + 1);
				num9 = num;
				num4 = 24;
			}
			while (num9 <= num4);
			if (Globals_Renamed.arOpNumWorkers[1, Globals_Renamed.intOpIndex] != Globals_Renamed.arOpNumWorkers[0, Globals_Renamed.intOpIndex])
			{
				Globals_Renamed.arOpNumWorkersBasisEnabled[Globals_Renamed.intOpIndex] = 0;
			}
			SetOER();
		}
	}

	public static bool chkModelsRun()
	{
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			bool result;
			if (Globals_Renamed.gblDoEasyModels)
			{
				result = true;
			}
			else
			{
				Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
				Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
				clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
				Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
				bool[,] array = new bool[2, 2];
				short num = 0;
				string text = "";
				array = new bool[3, Globals_Renamed.intNumOps + 1];
				command.ActiveConnection = Common.MyConn;
				command.CommandText = "pqryGetExpModel";
				command.CommandType = CommandTypeEnum.adCmdStoredProc;
				short num2 = (short)(Globals_Renamed.intNumOps - 1);
				short num3 = 0;
				while (true)
				{
					short num4 = num3;
					short num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					short num6 = 0;
					short num10;
					do
					{
						short num7 = 0;
						short num8;
						do
						{
							if (Globals_Renamed.arRelModels[num7, num6, num3] > 0 && Globals_Renamed.arRelModStatus[Globals_Renamed.arRelModels[num7, num6, num3] - 1] != 2)
							{
								num++;
								array[0, num3] = true;
								command.Parameters.Append(command.CreateParameter("pRelModID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, Globals_Renamed.arRelModType[Globals_Renamed.arRelModels[num7, num6, num3] - 1]));
								Command command2 = command;
								object RecordsAffected = Missing.Value;
								object Parameters = Missing.Value;
								recordset = command2.Execute(out RecordsAffected, ref Parameters);
								command.Parameters.Delete("pRelModID");
								text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(string.Concat(string.Concat(text + Globals_Renamed.arOpName[num3], " / "), Globals_Renamed.arSelActs[num6, num3]), " / "), recordset.Fields[3].Value), (object)'\r'), (object)'\n'));
								recordset.Close();
							}
							num7 = (short)unchecked(num7 + 1);
							num8 = num7;
							num5 = 10;
						}
						while (num8 <= num5);
						num7 = 0;
						short num9;
						do
						{
							if (Globals_Renamed.arExpModels[num7, num6, num3] > 0 && Globals_Renamed.arExpModStatus[Globals_Renamed.arExpModels[num7, num6, num3] - 1] != 2)
							{
								num++;
								array[1, num3] = true;
								command.Parameters.Append(command.CreateParameter("pRelModID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, Globals_Renamed.arExpModType[Globals_Renamed.arExpModels[num7, num6, num3] - 1]));
								Command command3 = command;
								object Parameters = Missing.Value;
								object RecordsAffected = Missing.Value;
								recordset = command3.Execute(out Parameters, ref RecordsAffected);
								command.Parameters.Delete("pRelModID");
								text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(string.Concat(string.Concat(text + Globals_Renamed.arOpName[num3], " / "), Globals_Renamed.arSelActs[num6, num3]), " / "), recordset.Fields[3].Value), (object)'\r'), (object)'\n'));
								recordset.Close();
							}
							num7 = (short)unchecked(num7 + 1);
							num9 = num7;
							num5 = 1;
						}
						while (num9 <= num5);
						num6 = (short)unchecked(num6 + 1);
						num10 = num6;
						num5 = 25;
					}
					while (num10 <= num5);
					num3 = (short)unchecked(num3 + 1);
				}
				bool flag = default(bool);
				if (num > 0)
				{
					frmModelsToBeRun frmModelsToBeRun2 = new frmModelsToBeRun();
					frmModelsToBeRun2.txtMessage.Text = text;
					((Form)frmModelsToBeRun2).ShowDialog();
					object tag = ((Control)frmModelsToBeRun2).Tag;
					if (Operators.ConditionalCompareObjectEqual(tag, (object)"RunAll", false))
					{
						Globals_Renamed.gblIWasChanged = true;
						short num6 = Globals_Renamed.intOpIndex;
						short num11 = (short)(Globals_Renamed.intNumOps - 1);
						num3 = 0;
						while (true)
						{
							short num12 = num3;
							short num5 = num11;
							if (num12 > num5)
							{
								break;
							}
							Globals_Renamed.intOpIndex = num3;
							if (array[0, num3])
							{
								RunRelModels();
							}
							if (array[1, num3])
							{
								RunExpModels();
								frmMain obj = MyProject.Forms.frmMain;
								short pModel = 0;
								obj.LoadExpParms(ref pModel);
								frmMain obj2 = MyProject.Forms.frmMain;
								pModel = 1;
								obj2.LoadExpParms(ref pModel);
								DeriveNWdefault();
								setDefaultExpFlags();
								object Parameters = Globals_Renamed.intOpIndex;
								resetInhRespClass(ref Parameters);
								Globals_Renamed.intOpIndex = Conversions.ToShort(Parameters);
							}
							num3 = (short)unchecked(num3 + 1);
						}
						Globals_Renamed.intOpIndex = num6;
						flag = true;
						frmMain.DefInstance.cmbRelOps.SelectedIndex = -1;
						frmMain.DefInstance.cmbExpOps.SelectedIndex = -1;
					}
					else if (Operators.ConditionalCompareObjectEqual(tag, (object)"Continue", false))
					{
						flag = true;
					}
					else if (Operators.ConditionalCompareObjectEqual(tag, (object)"Cancel", false))
					{
						flag = false;
					}
					((Form)frmModelsToBeRun2).Close();
					((Component)(object)frmModelsToBeRun2).Dispose();
				}
				else
				{
					flag = true;
				}
				result = flag;
				recordset = null;
				command = null;
			}
			return result;
		}
	}

	public static bool RunExpModels()
	{
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		short intActIndex = Globals_Renamed.intActIndex;
		short num = 1;
		checked
		{
			bool result = default(bool);
			short num13;
			short num5;
			do
			{
				short num2 = 0;
				short num12;
				do
				{
					if (Globals_Renamed.arActOrder[num2, Globals_Renamed.intOpIndex] == num)
					{
						Globals_Renamed.intActIndex = num2;
						short num3 = 0;
						short num11;
						do
						{
							if (Globals_Renamed.arExpModels[num3, num2, Globals_Renamed.intOpIndex] > 0)
							{
								Globals_Renamed.intModIndex = (short)(Globals_Renamed.arExpModels[num3, num2, Globals_Renamed.intOpIndex] - 1);
								short pDualID = 0;
								short num10;
								do
								{
									if ((Globals_Renamed.arExpModType[Globals_Renamed.intModIndex] > 0) & (Globals_Renamed.arExpModOutputOn[pDualID, Globals_Renamed.intModIndex] == 1))
									{
										short x = 1;
										short num4;
										object pArrayT;
										do
										{
											pArrayT = Globals_Renamed.arExpModParmsT;
											SetArParmValid(ref x, ref pArrayT, ref pDualID);
											Globals_Renamed.arExpModParmsT = (short[,,])pArrayT;
											Globals_Renamed.arParmValidSave[x] = Globals_Renamed.arParmValid[x];
											switch (x)
											{
											case 40:
											case 59:
											case 61:
											case 75:
											case 76:
											case 77:
											case 78:
											case 92:
												if (Globals_Renamed.arExpModParmsVC[pDualID, x, Globals_Renamed.intModIndex] == 999)
												{
													Globals_Renamed.arParmValues[x] = Globals_Renamed.arExpModParmsV[pDualID, x, Globals_Renamed.intModIndex];
												}
												else if (Globals_Renamed.arExpModParmsVC[pDualID, x, Globals_Renamed.intModIndex] == -123)
												{
													Interaction.MsgBox((object)("Linking Error: parm " + Conversions.ToString(unchecked((int)x)) + " is -123"), (MsgBoxStyle)0, (object)null);
												}
												else if (Globals_Renamed.arExpModParmsVC[pDualID, x, Globals_Renamed.intModIndex] == 998)
												{
													Globals_Renamed.arParmValues[x] = Globals_Renamed.arExpModParmsV[pDualID, x, Globals_Renamed.intModIndex];
												}
												else
												{
													Globals_Renamed.arParmValues[x] = Globals_Renamed.arExpModParmsV[pDualID, Globals_Renamed.arExpModParmsVC[pDualID, x, Globals_Renamed.intModIndex], Globals_Renamed.intModIndex];
												}
												break;
											case 57:
												if (Globals_Renamed.arExpModParmsV[pDualID, x, Globals_Renamed.intModIndex] > 0f)
												{
													Globals_Renamed.arParmValues[x] = ConvertKcKCodeToValue(ref Globals_Renamed.arExpModParmsV[pDualID, x, Globals_Renamed.intModIndex], ref pDualID, ref Globals_Renamed.arExpModType[Globals_Renamed.intModIndex]);
												}
												else
												{
													Globals_Renamed.arParmValues[x] = 0f;
												}
												break;
											default:
												Globals_Renamed.arParmValues[x] = Globals_Renamed.arExpModParmsV[pDualID, x, Globals_Renamed.intModIndex];
												break;
											}
											x = (short)unchecked(x + 1);
											num4 = x;
											num5 = 162;
										}
										while (num4 <= num5);
										GetReleaseParms(ref Globals_Renamed.arExpModType[Globals_Renamed.intModIndex], ref pDualID);
										if (!ExpModels.RunExposureModels(ref Globals_Renamed.intOpIndex, ref Globals_Renamed.arSelActType[num2, Globals_Renamed.intOpIndex], ref Globals_Renamed.arExpModType[Globals_Renamed.intModIndex], ref pDualID))
										{
											Globals_Renamed.intActIndex = intActIndex;
											Globals_Renamed.arExpModStatus[Globals_Renamed.intModIndex] = 1;
											return result;
										}
										Globals_Renamed.arExpModEst[pDualID, 2, Globals_Renamed.intModIndex] = Globals_Renamed.arParmValues[75];
										Globals_Renamed.arExpModEst[pDualID, 12, Globals_Renamed.intModIndex] = Globals_Renamed.arParmValues[1] * Globals_Renamed.arParmValues[91];
										if (num3 == 0)
										{
											x = 8;
											short num6;
											do
											{
												Globals_Renamed.arExpModEst[pDualID, x, Globals_Renamed.intModIndex] = Globals_Renamed.arOutput[x];
												x = (short)unchecked(x + 1);
												num6 = x;
												num5 = 11;
											}
											while (num6 <= num5);
										}
										else
										{
											x = 4;
											short num7;
											do
											{
												Globals_Renamed.arExpModEst[pDualID, x, Globals_Renamed.intModIndex] = Globals_Renamed.arOutput[x];
												x = (short)unchecked(x + 1);
												num7 = x;
												num5 = 7;
											}
											while (num7 <= num5);
										}
										pArrayT = Globals_Renamed.arExpModParmsV;
										object pArrayT2 = Globals_Renamed.arExpModParmsT;
										GrabUpdatesFromModels(ref pArrayT, ref pArrayT2, ref pDualID);
										Globals_Renamed.arExpModParmsT = (short[,,])pArrayT2;
										Globals_Renamed.arExpModParmsV = (float[,,])pArrayT;
									}
									else
									{
										Globals_Renamed.arExpModEst[pDualID, 2, Globals_Renamed.intModIndex] = 0f;
										Globals_Renamed.arExpModEst[pDualID, 12, Globals_Renamed.intModIndex] = 0f;
										if (num3 == 0)
										{
											short x = 8;
											short num8;
											do
											{
												Globals_Renamed.arExpModEst[pDualID, x, Globals_Renamed.intModIndex] = 0f;
												x = (short)unchecked(x + 1);
												num8 = x;
												num5 = 11;
											}
											while (num8 <= num5);
										}
										else
										{
											short x = 4;
											short num9;
											do
											{
												Globals_Renamed.arExpModEst[pDualID, x, Globals_Renamed.intModIndex] = 0f;
												x = (short)unchecked(x + 1);
												num9 = x;
												num5 = 7;
											}
											while (num9 <= num5);
										}
									}
									Globals_Renamed.arExpModStatus[Globals_Renamed.intModIndex] = 2;
									pDualID = (short)unchecked(pDualID + 1);
									num10 = pDualID;
									num5 = 1;
								}
								while (num10 <= num5);
							}
							num3 = (short)unchecked(num3 + 1);
							num11 = num3;
							num5 = 1;
						}
						while (num11 <= num5);
					}
					num2 = (short)unchecked(num2 + 1);
					num12 = num2;
					num5 = 24;
				}
				while (num12 <= num5);
				num = (short)unchecked(num + 1);
				num13 = num;
				num5 = 25;
			}
			while (num13 <= num5);
			Globals_Renamed.intActIndex = intActIndex;
			return true;
		}
	}

	public static bool RunRelModels()
	{
		short num = 1;
		checked
		{
			bool result = default(bool);
			short num9;
			short num5;
			do
			{
				short num2 = 0;
				short num8;
				do
				{
					if (Globals_Renamed.arActOrder[num2, Globals_Renamed.intOpIndex] == num)
					{
						Globals_Renamed.intActIndex = num2;
						short pModIndex = 0;
						short num7;
						do
						{
							if (Globals_Renamed.arRelModels[pModIndex, num2, Globals_Renamed.intOpIndex] > 0)
							{
								Globals_Renamed.intModIndex = (short)(Globals_Renamed.arRelModels[pModIndex, num2, Globals_Renamed.intOpIndex] - 1);
								short pDualID = 0;
								short num6;
								do
								{
									if (Globals_Renamed.arRelModOutputOn[pDualID, Globals_Renamed.intModIndex] == 1)
									{
										short x = 1;
										short num4;
										object pArrayT;
										do
										{
											pArrayT = Globals_Renamed.arRelModParmsT;
											SetArParmValid(ref x, ref pArrayT, ref pDualID);
											Globals_Renamed.arRelModParmsT = (short[,,])pArrayT;
											Globals_Renamed.arParmValidSave[x] = Globals_Renamed.arParmValid[x];
											short num3 = x;
											if ((num3 == 92 || num3 == 72 || num3 == 9 || num3 == 40) ? true : false)
											{
												if (Globals_Renamed.arRelModParmsVC[pDualID, x, Globals_Renamed.intModIndex] == 999)
												{
													Globals_Renamed.arParmValues[x] = Globals_Renamed.arRelModParmsV[pDualID, x, Globals_Renamed.intModIndex];
												}
												else
												{
													Globals_Renamed.arParmValues[x] = Globals_Renamed.arRelModParmsV[pDualID, Globals_Renamed.arRelModParmsVC[pDualID, x, Globals_Renamed.intModIndex], Globals_Renamed.intModIndex];
												}
											}
											else
											{
												Globals_Renamed.arParmValues[x] = Globals_Renamed.arRelModParmsV[pDualID, x, Globals_Renamed.intModIndex];
											}
											x = (short)unchecked(x + 1);
											num4 = x;
											num5 = 162;
										}
										while (num4 <= num5);
										Globals_Renamed.arOutput[1] = 0f;
										Globals_Renamed.arOutput[3] = 0f;
										Globals_Renamed.arOutput[2] = 0f;
										if (!RelModels.RunReleaseModels(ref Globals_Renamed.intOpIndex, ref Globals_Renamed.arSelActType[num2, Globals_Renamed.intOpIndex], ref Globals_Renamed.arRelModType[Globals_Renamed.intModIndex], ref pDualID))
										{
											Globals_Renamed.arRelModStatus[Globals_Renamed.intModIndex] = 1;
											return result;
										}
										Globals_Renamed.arRelModDRR[pDualID, Globals_Renamed.intModIndex] = Globals_Renamed.arOutput[1];
										Globals_Renamed.arRelModARR[pDualID, Globals_Renamed.intModIndex] = Globals_Renamed.arOutput[3];
										Globals_Renamed.arRelModDOR[pDualID, Globals_Renamed.intModIndex] = (short)Math.Round(Globals_Renamed.arOutput[2]);
										pArrayT = Globals_Renamed.arRelModParmsV;
										object pArrayT2 = Globals_Renamed.arRelModParmsT;
										GrabUpdatesFromModels(ref pArrayT, ref pArrayT2, ref pDualID);
										Globals_Renamed.arRelModParmsT = (short[,,])pArrayT2;
										Globals_Renamed.arRelModParmsV = (float[,,])pArrayT;
										UpdateAnyExpLinks(ref pModIndex);
										Globals_Renamed.arRelModStatus[Globals_Renamed.intModIndex] = 2;
									}
									else
									{
										Globals_Renamed.arRelModDRR[pDualID, Globals_Renamed.intModIndex] = 0f;
										Globals_Renamed.arRelModARR[pDualID, Globals_Renamed.intModIndex] = 0f;
										Globals_Renamed.arRelModDOR[pDualID, Globals_Renamed.intModIndex] = 0;
									}
									pDualID = (short)unchecked(pDualID + 1);
									num6 = pDualID;
									num5 = 1;
								}
								while (num6 <= num5);
							}
							pModIndex = (short)unchecked(pModIndex + 1);
							num7 = pModIndex;
							num5 = 9;
						}
						while (num7 <= num5);
					}
					num2 = (short)unchecked(num2 + 1);
					num8 = num2;
					num5 = 24;
				}
				while (num8 <= num5);
				num = (short)unchecked(num + 1);
				num9 = num;
				num5 = 25;
			}
			while (num9 <= num5);
			return true;
		}
	}

	public static void setDefaultExpFlags()
	{
		checked
		{
			short num = (short)(Globals_Renamed.intNumOps - 1);
			short num2 = 0;
			long num5 = default(long);
			long num10 = default(long);
			long num15 = default(long);
			long num16 = default(long);
			while (true)
			{
				short num3 = num2;
				short num4 = num;
				if (num3 > num4)
				{
					break;
				}
				num5 += Globals_Renamed.arOpNumWorkers[1, num2];
				short num6 = 0;
				short num17;
				do
				{
					if (Globals_Renamed.arExpModels[0, num6, num2] > 0)
					{
						short num7 = (short)(Globals_Renamed.arExpModels[0, num6, num2] - 1);
						long num8 = 0L;
						long num9 = 0L;
						if (Globals_Renamed.arExpModOutputOn[0, num7] == 1 && Globals_Renamed.arExpModEst[0, 2, num7] > 100f)
						{
							num8 = (long)Math.Round(Globals_Renamed.arExpModEst[0, 12, num7]);
						}
						if (Globals_Renamed.arExpModOutputOn[1, num7] == 1 && Globals_Renamed.arExpModEst[1, 2, num7] > 100f)
						{
							num9 = (long)Math.Round(Globals_Renamed.arExpModEst[1, 12, num7]);
						}
						num10 = ((num8 <= num9) ? (num10 + num9) : (num10 + num8));
					}
					if (Globals_Renamed.arExpModels[1, num6, num2] > 0)
					{
						short num7 = (short)(Globals_Renamed.arExpModels[1, num6, num2] - 1);
						long num11 = 0L;
						long num12 = 0L;
						double num13;
						if (Globals_Renamed.arExpModOutputOn[0, num7] == 1)
						{
							num13 = Globals_Renamed.arExpModEst[0, 4, num7];
							num11 = (long)Math.Round(Globals_Renamed.arExpModEst[0, 12, num7]);
						}
						else
						{
							num13 = 0.0;
						}
						double num14;
						if (Globals_Renamed.arExpModOutputOn[1, num7] == 1)
						{
							num14 = Globals_Renamed.arExpModEst[1, 4, num7];
							num12 = (long)Math.Round(Globals_Renamed.arExpModEst[1, 12, num7]);
						}
						else
						{
							num14 = 0.0;
						}
						if (unchecked(num13 > 10.0 && num14 > 10.0))
						{
							num15 = ((num11 <= num12) ? (num15 + num11) : (num15 + num11));
						}
						else if (unchecked(num13 > 10.0 && num14 > 1.0))
						{
							num15 += num11;
							num16 += num12;
						}
						else if (unchecked(num13 > 1.0 && num14 > 10.0))
						{
							num16 += num11;
							num15 += num12;
						}
						else if (num13 > 10.0)
						{
							num15 += num11;
						}
						else if (num14 > 10.0)
						{
							num15 += num12;
						}
						else if (unchecked(num13 > 1.0 && num14 > 1.0))
						{
							num16 = ((num11 <= num12) ? (num16 + num12) : (num16 + num11));
						}
						else if (num13 > 1.0)
						{
							num16 += num11;
						}
						else if (num14 > 1.0)
						{
							num16 += num12;
						}
					}
					num6 = (short)unchecked(num6 + 1);
					num17 = num6;
					num4 = 24;
				}
				while (num17 <= num4);
				num2 = (short)unchecked(num2 + 1);
			}
			frmMain defInstance = frmMain.DefInstance;
			defInstance.lblNumExp.Text = Conversions.ToString(num5);
			if ((double)Conversions.ToInteger(Common.MyNullCheck0(defInstance.lblNumExpEst)) != Conversions.ToDouble(Conversions.ToString(num5)))
			{
				defInstance.lblNumExpEst.Text = Conversions.ToString(num5);
				((Control)defInstance.txtNumExpEstBasis).Tag = 0;
			}
			if (num5 > 1000)
			{
				defInstance.lblNumWMet[(short)0].Text = "Yes";
			}
			else
			{
				defInstance.lblNumWMet[(short)0].Text = "No";
			}
			if (num15 > 100)
			{
				defInstance.lblNumWMet[(short)1].Text = "Yes";
			}
			else
			{
				defInstance.lblNumWMet[(short)1].Text = "No";
			}
			if (num16 > 100)
			{
				defInstance.lblNumWMet[(short)2].Text = "Yes";
			}
			else
			{
				defInstance.lblNumWMet[(short)2].Text = "No";
			}
			if (num10 > 250)
			{
				defInstance.lblNumWMet[(short)3].Text = "Yes";
			}
			else
			{
				defInstance.lblNumWMet[(short)3].Text = "No";
			}
			resetExpBasedCriteria();
			defInstance = null;
		}
	}
}
