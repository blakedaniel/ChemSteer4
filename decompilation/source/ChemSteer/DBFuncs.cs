using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ADODB;
using AxMSFlexGridLib;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Compatibility.VB6;
using Microsoft.VisualBasic.CompilerServices;

namespace ChemSteer;

[StandardModule]
internal sealed class DBFuncs
{
	public const short gblDbVersion4 = 4;

	public const short gblDbVersion5 = 5;

	public const short gblDbVersion6 = 6;

	public const short gblDbVersion7 = 7;

	public const short gblDbVersion8 = 8;

	public const short gblDbVersion9 = 9;

	public const short gbldbversion10 = 10;

	public const short gbldbversion11 = 11;

	public const short gbldbversion12 = 12;

	public const short gblDbVersion14 = 14;

	private static int x;

	private static int intScenarioID;

	public static bool saveGSS(int pOpIndex, string pGssName, string pPDFName)
	{
		int try0001_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		string pGssName2 = default(string);
		bool flag = default(bool);
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
				switch (try0001_dispatch)
				{
				default:
					num = 1;
					x = pOpIndex;
					goto IL_000a;
				case 295:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 2:
							break;
						case 1:
							goto IL_00e5;
						default:
							goto end_IL_0001;
						}
						goto IL_006b;
					}
					IL_003b:
					num = 4;
					if (GSS_Save_Ops(pGssName2, pPDFName))
					{
						goto IL_004b;
					}
					goto IL_005e;
					IL_004b:
					num = 5;
					GSS_Save_Rel();
					goto IL_0054;
					IL_0033:
					ProjectData.ClearProjectError();
					num3 = 2;
					goto IL_003b;
					IL_00e5:
					num4 = num2 + 1;
					goto IL_00e9;
					IL_006b:
					num = 10;
					Eobject = "DBFuncs.Bas";
					Efunction = "saveGSS";
					val = Information.Err();
					Enumber = val.Number;
					val2 = Information.Err();
					Edescription = val2.Description;
					Econtact = true;
					Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
					val2.Description = Edescription;
					val.Number = Enumber;
					goto IL_00c2;
					IL_00c2:
					num = 11;
					ProjectData.ClearProjectError();
					if (num2 == 0)
					{
						throw ProjectData.CreateProjectError(-2146828268);
					}
					num4 = num2;
					goto IL_00e9;
					IL_0054:
					num = 6;
					GSS_Save_Exp();
					goto IL_005e;
					IL_005e:
					num = 8;
					flag = true;
					goto end_IL_0001_2;
					IL_00e9:
					num2 = 0;
					switch (num4)
					{
					case 1:
						break;
					case 2:
						goto IL_000a;
					case 3:
						goto IL_0033;
					case 4:
						goto IL_003b;
					case 5:
						goto IL_004b;
					case 6:
						goto IL_0054;
					case 7:
					case 8:
						goto IL_005e;
					case 10:
						goto IL_006b;
					case 11:
						goto IL_00c2;
					default:
						goto end_IL_0001;
					case 9:
					case 12:
						goto end_IL_0001_2;
					}
					goto default;
					IL_000a:
					num = 2;
					pGssName2 = Strings.Replace(Strings.Replace(pGssName, "'", " ", 1, -1, (CompareMethod)0), "\"", " ", 1, -1, (CompareMethod)0);
					goto IL_0033;
					end_IL_0001:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 295;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_2:
			break;
		}
		bool result = flag;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static bool deleteGSS(string pGssName)
	{
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
					Guid clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
					Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					command.ActiveConnection = Common.gssConn;
					command.CommandText = "DELETE * FROM OPERATIONS WHERE OpName = '" + pGssName + "'";
					command.CommandType = CommandTypeEnum.adCmdText;
					object RecordsAffected = Missing.Value;
					object Parameters = Missing.Value;
					command.Execute(out RecordsAffected, ref Parameters);
					flag = true;
					goto end_IL_0001;
				}
				case 204:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						string Eobject = "DBFuncs.Bas";
						string Efunction = "deleteGSS";
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
				try0001_dispatch = 204;
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

	public static bool renameGSS(string pOldGssName, string pNewGssName)
	{
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
					Guid clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
					Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					string text = Strings.Replace(Strings.Replace(pNewGssName, "'", " ", 1, -1, (CompareMethod)0), "\"", " ", 1, -1, (CompareMethod)0);
					command.ActiveConnection = Common.gssConn;
					command.CommandText = "UPDATE OPERATIONS SET OpName = '" + text + "' WHERE OpName = '" + pOldGssName + "'";
					command.CommandType = CommandTypeEnum.adCmdText;
					object RecordsAffected = Missing.Value;
					object Parameters = Missing.Value;
					command.Execute(out RecordsAffected, ref Parameters);
					flag = true;
					goto end_IL_0001;
				}
				case 284:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						string Eobject = "DBFuncs.Bas";
						string Efunction = "renameGSS";
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
				try0001_dispatch = 284;
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

	private static bool GSS_Save_Ops(string pGssName, string pPDFName)
	{
		int try0001_dispatch = -1;
		int num = default(int);
		Recordset recordset = default(Recordset);
		int num2 = default(int);
		int num3 = default(int);
		bool flag = default(bool);
		short num5 = default(short);
		short num11 = default(short);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					int num4;
					Guid clsid;
					short num6;
					short num8;
					short num9;
					short num10;
					short num12;
					short num13;
					short num14;
					short num7;
					Command command;
					switch (try0001_dispatch)
					{
					default:
						num = 1;
						clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
						recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						goto IL_0023;
					case 4474:
						{
							num2 = num;
							switch ((num3 <= -2) ? 1 : num3)
							{
							case 2:
							case 3:
								break;
							case 1:
								goto IL_0f54;
							default:
								goto end_IL_0001;
							}
							break;
						}
						IL_007c:
						num = 8;
						recordset.Delete();
						goto IL_0087;
						IL_0087:
						num = 9;
						recordset.MoveFirst();
						goto IL_0093;
						IL_0ede:
						num = 130;
						flag = true;
						goto end_IL_0001_2;
						IL_0f54:
						num4 = unchecked(num2 + 1);
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0023;
						case 3:
							goto IL_0045;
						case 4:
							goto IL_004d;
						case 5:
							goto IL_0058;
						case 8:
							goto IL_007c;
						case 9:
							goto IL_0087;
						case 6:
						case 7:
						case 10:
							goto IL_0093;
						case 11:
							goto IL_00a5;
						case 12:
							goto IL_00ba;
						case 13:
							goto IL_00e4;
						case 14:
							goto IL_00ff;
						case 15:
							goto IL_0129;
						case 16:
							goto IL_014e;
						case 17:
							goto IL_0173;
						case 18:
							goto IL_0198;
						case 19:
							goto IL_01bd;
						case 20:
							goto IL_01e2;
						case 21:
							goto IL_0207;
						case 22:
							goto IL_022c;
						case 23:
							goto IL_0256;
						case 24:
							goto IL_0280;
						case 25:
							goto IL_02aa;
						case 26:
							goto IL_02b3;
						case 27:
							goto IL_02e2;
						case 28:
							goto IL_0311;
						case 29:
							goto IL_0340;
						case 30:
							goto IL_036f;
						case 31:
							goto IL_0377;
						case 32:
							goto IL_039c;
						case 33:
							goto IL_03c1;
						case 34:
							goto IL_03e6;
						case 35:
							goto IL_040b;
						case 36:
							goto IL_0430;
						case 37:
							goto IL_0455;
						case 38:
							goto IL_047f;
						case 39:
							goto IL_04ae;
						case 40:
							goto IL_04dd;
						case 41:
							goto IL_050c;
						case 42:
							goto IL_0536;
						case 43:
							goto IL_0551;
						case 44:
							goto IL_0566;
						case 45:
							goto IL_0571;
						case 46:
							goto IL_0594;
						case 47:
							goto IL_05b7;
						case 48:
							goto IL_05c2;
						case 49:
							goto IL_05e9;
						case 50:
							goto IL_05ef;
						case 51:
							goto IL_0614;
						case 52:
							goto IL_0629;
						case 53:
							goto IL_064d;
						case 54:
							goto IL_066d;
						case 55:
							goto IL_0697;
						case 56:
						case 57:
							goto IL_06ad;
						case 58:
							goto IL_06c3;
						case 59:
							goto IL_06ce;
						case 60:
							goto IL_06f5;
						case 61:
							goto IL_06fb;
						case 62:
							goto IL_071b;
						case 63:
							goto IL_0730;
						case 64:
							goto IL_0754;
						case 65:
							goto IL_0774;
						case 66:
							goto IL_079e;
						case 67:
							goto IL_07cd;
						case 68:
							goto IL_07fc;
						case 69:
							goto IL_082b;
						case 70:
							goto IL_085a;
						case 71:
							goto IL_0889;
						case 72:
							goto IL_08b8;
						case 73:
							goto IL_08e8;
						case 74:
							goto IL_0918;
						case 75:
							goto IL_0948;
						case 76:
							goto IL_0972;
						case 77:
							goto IL_09a1;
						case 78:
						case 79:
							goto IL_09b7;
						case 80:
							goto IL_09cd;
						case 81:
							goto IL_09d8;
						case 82:
							goto IL_09ff;
						case 83:
							goto IL_0a05;
						case 84:
							goto IL_0a1a;
						case 85:
							goto IL_0a3e;
						case 86:
							goto IL_0a5e;
						case 87:
							goto IL_0a8d;
						case 88:
							goto IL_0abc;
						case 89:
							goto IL_0ad1;
						case 90:
							goto IL_0aea;
						case 91:
							goto IL_0af0;
						case 92:
							goto IL_0b14;
						case 93:
							goto IL_0b29;
						case 94:
							goto IL_0b4d;
						case 95:
							goto IL_0b73;
						case 96:
							goto IL_0ba2;
						case 97:
							goto IL_0bd1;
						case 98:
						case 99:
							goto IL_0be7;
						case 100:
							goto IL_0bfd;
						case 101:
							goto IL_0c08;
						case 102:
							goto IL_0c2f;
						case 103:
							goto IL_0c35;
						case 104:
							goto IL_0c3c;
						case 105:
							goto IL_0c62;
						case 106:
							goto IL_0c77;
						case 107:
							goto IL_0c9b;
						case 108:
							goto IL_0cbb;
						case 109:
							goto IL_0cdc;
						case 110:
							goto IL_0d0d;
						case 111:
							goto IL_0d3e;
						case 112:
						case 113:
							goto IL_0d54;
						case 114:
							goto IL_0d6d;
						case 115:
							goto IL_0d83;
						case 116:
							goto IL_0d8e;
						case 117:
							goto IL_0db5;
						case 118:
							goto IL_0dbb;
						case 119:
							goto IL_0ddb;
						case 120:
							goto IL_0df0;
						case 121:
							goto IL_0e14;
						case 122:
							goto IL_0e34;
						case 123:
							goto IL_0e63;
						case 124:
							goto IL_0e92;
						case 125:
						case 126:
							goto IL_0ea8;
						case 127:
							goto IL_0ec1;
						case 128:
							goto IL_0ecc;
						case 129:
							goto IL_0ed5;
						case 130:
							goto IL_0ede;
						case 132:
							goto end_IL_0001_3;
						default:
							goto end_IL_0001;
						case 131:
						case 133:
							goto end_IL_0001_2;
						}
						goto default;
						IL_0023:
						num = 2;
						clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
						command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						goto IL_0045;
						IL_0045:
						ProjectData.ClearProjectError();
						num3 = 2;
						goto IL_004d;
						IL_004d:
						num = 4;
						recordset.CursorLocation = CursorLocationEnum.adUseServer;
						goto IL_0058;
						IL_0058:
						num = 5;
						recordset.Open("SELECT * FROM Operations WHERE OpName='" + pGssName + "'", Common.gssConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
						goto IL_0093;
						IL_0093:
						num = 7;
						if (!recordset.EOF)
						{
							goto IL_007c;
						}
						goto IL_00a5;
						IL_00a5:
						num = 11;
						recordset.AddNew(Missing.Value, Missing.Value);
						goto IL_00ba;
						IL_00ba:
						num = 12;
						recordset.Fields["OpID"].Value = Globals_Renamed.arOpType[x];
						goto IL_00e4;
						IL_00e4:
						num = 13;
						recordset.Fields["OpName"].Value = pGssName;
						goto IL_00ff;
						IL_00ff:
						num = 14;
						recordset.Fields["PVop"].Value = Globals_Renamed.arOpPv[x];
						goto IL_0129;
						IL_0129:
						num = 15;
						recordset.Fields["ProcessDesc"].Value = Globals_Renamed.arPDesc[x];
						goto IL_014e;
						IL_014e:
						num = 16;
						recordset.Fields["PSInto"].Value = Globals_Renamed.arPSInto1[x];
						goto IL_0173;
						IL_0173:
						num = 17;
						recordset.Fields["PSIntoOther"].Value = Globals_Renamed.arPSInto2[x];
						goto IL_0198;
						IL_0198:
						num = 18;
						recordset.Fields["PSOut"].Value = Globals_Renamed.arPSOut1[x];
						goto IL_01bd;
						IL_01bd:
						num = 19;
						recordset.Fields["PSOutOther"].Value = Globals_Renamed.arPSOut2[x];
						goto IL_01e2;
						IL_01e2:
						num = 20;
						recordset.Fields["PSIn"].Value = Globals_Renamed.arPSIn1[x];
						goto IL_0207;
						IL_0207:
						num = 21;
						recordset.Fields["PSInOther"].Value = Globals_Renamed.arPSIn2[x];
						goto IL_022c;
						IL_022c:
						num = 22;
						recordset.Fields["NoPrev"].Value = Globals_Renamed.arNoPre[x];
						goto IL_0256;
						IL_0256:
						num = 23;
						recordset.Fields["OpType"].Value = Globals_Renamed.arOpBorC[x];
						goto IL_0280;
						IL_0280:
						num = 24;
						recordset.Fields["IoE"].Value = Globals_Renamed.arOpIoE[x];
						goto IL_02aa;
						IL_02aa:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_02b3;
						IL_02b3:
						num = 26;
						recordset.Fields["OpNumWorkers"].Value = Globals_Renamed.arMiscOpParms[0, x];
						goto IL_02e2;
						IL_02e2:
						num = 27;
						recordset.Fields["NumWorkersExpDaysPerYear"].Value = Globals_Renamed.arMiscOpParms[1, x];
						goto IL_0311;
						IL_0311:
						num = 28;
						recordset.Fields["MassBalDisc1"].Value = Globals_Renamed.arOpMassBalDisc[0, x];
						goto IL_0340;
						IL_0340:
						num = 29;
						recordset.Fields["MassBalDisc2"].Value = Globals_Renamed.arOpMassBalDisc[1, x];
						goto IL_036f;
						IL_036f:
						ProjectData.ClearProjectError();
						num3 = 3;
						goto IL_0377;
						IL_0377:
						num = 31;
						recordset.Fields["Basis"].Value = Globals_Renamed.arBasis[x];
						goto IL_039c;
						IL_039c:
						num = 32;
						recordset.Fields["WaterRelBasis"].Value = Globals_Renamed.arWaterBasis[x];
						goto IL_03c1;
						IL_03c1:
						num = 33;
						recordset.Fields["InhExpBasis"].Value = Globals_Renamed.arInhalationBasis[x];
						goto IL_03e6;
						IL_03e6:
						num = 34;
						recordset.Fields["AddNotesRelSummary"].Value = Globals_Renamed.arRelAddNotes[x];
						goto IL_040b;
						IL_040b:
						num = 35;
						recordset.Fields["AddNotesExpSummary"].Value = Globals_Renamed.arExpAddNotes[x];
						goto IL_0430;
						IL_0430:
						num = 36;
						recordset.Fields["DerExpBasis"].Value = Globals_Renamed.arDermalBasis[x];
						goto IL_0455;
						IL_0455:
						num = 37;
						recordset.Fields["OpOrder"].Value = Globals_Renamed.arOpOrder[x];
						goto IL_047f;
						IL_047f:
						num = 38;
						recordset.Fields["NWdefault"].Value = Globals_Renamed.arOpNumWorkers[0, x];
						goto IL_04ae;
						IL_04ae:
						num = 39;
						recordset.Fields["NWestimated"].Value = Globals_Renamed.arOpNumWorkers[1, x];
						goto IL_04dd;
						IL_04dd:
						num = 40;
						recordset.Fields["NWbasis"].Value = Globals_Renamed.arOpNumWorkersBasis[x] + " ";
						goto IL_050c;
						IL_050c:
						num = 41;
						recordset.Fields["NWbasisEnabled"].Value = Globals_Renamed.arOpNumWorkersBasisEnabled[x];
						goto IL_0536;
						IL_0536:
						num = 42;
						recordset.Fields["GSS_PDF"].Value = pPDFName;
						goto IL_0551;
						IL_0551:
						num = 43;
						recordset.Update(Missing.Value, Missing.Value);
						goto IL_0566;
						IL_0566:
						num = 44;
						recordset.Close();
						goto IL_0571;
						IL_0571:
						num = 45;
						recordset.Open("SELECT ScenarioID FROM Operations WHERE OpName='" + pGssName + "'", Common.gssConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
						goto IL_0594;
						IL_0594:
						num = 46;
						intScenarioID = Conversions.ToInteger(recordset.Fields["ScenarioID"].Value);
						goto IL_05b7;
						IL_05b7:
						num = 47;
						recordset.Close();
						goto IL_05c2;
						IL_05c2:
						num = 48;
						recordset.Open("SELECT * FROM OpNaics WHERE ScenarioID=" + Conversions.ToString(intScenarioID), Common.gssConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
						goto IL_05e9;
						IL_05e9:
						num = 49;
						num5 = 0;
						goto IL_05ef;
						IL_05ef:
						num = 50;
						if (Strings.Len(Globals_Renamed.arNaics1[num5, x]) > 0)
						{
							goto IL_0614;
						}
						goto IL_06ad;
						IL_0614:
						num = 51;
						recordset.AddNew(Missing.Value, Missing.Value);
						goto IL_0629;
						IL_0629:
						num = 52;
						recordset.Fields["ScenarioID"].Value = intScenarioID;
						goto IL_064d;
						IL_064d:
						num = 53;
						recordset.Fields["NaicsIndex"].Value = num5;
						goto IL_066d;
						IL_066d:
						num = 54;
						recordset.Fields["NAICS"].Value = Globals_Renamed.arNaics1[num5, x];
						goto IL_0697;
						IL_0697:
						num = 55;
						recordset.Update(Missing.Value, Missing.Value);
						goto IL_06ad;
						IL_06ad:
						num = 57;
						num5 = (short)unchecked(num5 + 1);
						num6 = num5;
						num7 = 99;
						if (num6 <= num7)
						{
							goto IL_05ef;
						}
						goto IL_06c3;
						IL_06c3:
						num = 58;
						recordset.Close();
						goto IL_06ce;
						IL_06ce:
						num = 59;
						recordset.Open("SELECT * FROM Activities WHERE ScenarioID=" + Conversions.ToString(intScenarioID), Common.gssConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
						goto IL_06f5;
						IL_06f5:
						num = 60;
						num5 = 0;
						goto IL_06fb;
						IL_06fb:
						num = 61;
						if (Globals_Renamed.arSelActType[num5, x] > 0)
						{
							goto IL_071b;
						}
						goto IL_09b7;
						IL_071b:
						num = 62;
						recordset.AddNew(Missing.Value, Missing.Value);
						goto IL_0730;
						IL_0730:
						num = 63;
						recordset.Fields["ScenarioID"].Value = intScenarioID;
						goto IL_0754;
						IL_0754:
						num = 64;
						recordset.Fields["ScenActID"].Value = num5;
						goto IL_0774;
						IL_0774:
						num = 65;
						recordset.Fields["ActName"].Value = Globals_Renamed.arSelActs[num5, x];
						goto IL_079e;
						IL_079e:
						num = 66;
						recordset.Fields["ActID"].Value = Globals_Renamed.arSelActType[num5, x];
						goto IL_07cd;
						IL_07cd:
						num = 67;
						recordset.Fields["DoRel"].Value = Globals_Renamed.arSelActRa[num5, x];
						goto IL_07fc;
						IL_07fc:
						num = 68;
						recordset.Fields["DoExp"].Value = Globals_Renamed.arSelActEa[num5, x];
						goto IL_082b;
						IL_082b:
						num = 69;
						recordset.Fields["DidRel"].Value = Globals_Renamed.arSelActRaDMP[num5, x];
						goto IL_085a;
						IL_085a:
						num = 70;
						recordset.Fields["DidExp"].Value = Globals_Renamed.arSelActEaDMP[num5, x];
						goto IL_0889;
						IL_0889:
						num = 71;
						recordset.Fields["Volatile"].Value = Globals_Renamed.arSelActVolatile[num5, x];
						goto IL_08b8;
						IL_08b8:
						num = 72;
						recordset.Fields["NW_NS"].Value = Globals_Renamed.arActNumWorkers[0, num5, x];
						goto IL_08e8;
						IL_08e8:
						num = 73;
						recordset.Fields["NW_NWexp"].Value = Globals_Renamed.arActNumWorkers[1, num5, x];
						goto IL_0918;
						IL_0918:
						num = 74;
						recordset.Fields["NW_NSxNWexp"].Value = Globals_Renamed.arActNumWorkers[2, num5, x];
						goto IL_0948;
						IL_0948:
						num = 75;
						recordset.Fields["NW_Route"].Value = Globals_Renamed.arActNW_Route[num5, x];
						goto IL_0972;
						IL_0972:
						num = 76;
						recordset.Fields["ActOrder"].Value = Globals_Renamed.arActOrder[num5, x];
						goto IL_09a1;
						IL_09a1:
						num = 77;
						recordset.Update(Missing.Value, Missing.Value);
						goto IL_09b7;
						IL_09b7:
						num = 79;
						num5 = (short)unchecked(num5 + 1);
						num8 = num5;
						num7 = 24;
						if (num8 <= num7)
						{
							goto IL_06fb;
						}
						goto IL_09cd;
						IL_09cd:
						num = 80;
						recordset.Close();
						goto IL_09d8;
						IL_09d8:
						num = 81;
						recordset.Open("SELECT * FROM OpParms WHERE ScenarioID=" + Conversions.ToString(intScenarioID), Common.gssConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
						goto IL_09ff;
						IL_09ff:
						num = 82;
						num5 = 0;
						goto IL_0a05;
						IL_0a05:
						num = 83;
						recordset.AddNew(Missing.Value, Missing.Value);
						goto IL_0a1a;
						IL_0a1a:
						num = 84;
						recordset.Fields["ScenarioID"].Value = intScenarioID;
						goto IL_0a3e;
						IL_0a3e:
						num = 85;
						recordset.Fields["ParmID"].Value = num5;
						goto IL_0a5e;
						IL_0a5e:
						num = 86;
						recordset.Fields["ParmValue"].Value = Globals_Renamed.arOpParms[num5, x];
						goto IL_0a8d;
						IL_0a8d:
						num = 87;
						recordset.Fields["ParmType"].Value = Globals_Renamed.arOpParmsType[num5, x];
						goto IL_0abc;
						IL_0abc:
						num = 88;
						recordset.Update(Missing.Value, Missing.Value);
						goto IL_0ad1;
						IL_0ad1:
						num = 89;
						num5 = (short)unchecked(num5 + 1);
						num9 = num5;
						num7 = 161;
						if (num9 <= num7)
						{
							goto IL_0a05;
						}
						goto IL_0aea;
						IL_0aea:
						num = 90;
						num5 = 0;
						goto IL_0af0;
						IL_0af0:
						num = 91;
						if (Globals_Renamed.arOpSP[num5, x] > 0f)
						{
							goto IL_0b14;
						}
						goto IL_0be7;
						IL_0b14:
						num = 92;
						recordset.AddNew(Missing.Value, Missing.Value);
						goto IL_0b29;
						IL_0b29:
						num = 93;
						recordset.Fields["ScenarioID"].Value = intScenarioID;
						goto IL_0b4d;
						IL_0b4d:
						num = 94;
						recordset.Fields["ParmID"].Value = num5 + 1000;
						goto IL_0b73;
						IL_0b73:
						num = 95;
						recordset.Fields["ParmValue"].Value = Globals_Renamed.arOpSP[num5, x];
						goto IL_0ba2;
						IL_0ba2:
						num = 96;
						recordset.Fields["ParmType"].Value = Globals_Renamed.arOpSPType[num5, x];
						goto IL_0bd1;
						IL_0bd1:
						num = 97;
						recordset.Update(Missing.Value, Missing.Value);
						goto IL_0be7;
						IL_0be7:
						num = 99;
						num5 = (short)unchecked(num5 + 1);
						num10 = num5;
						num7 = 47;
						if (num10 <= num7)
						{
							goto IL_0af0;
						}
						goto IL_0bfd;
						IL_0bfd:
						num = 100;
						recordset.Close();
						goto IL_0c08;
						IL_0c08:
						num = 101;
						recordset.Open("SELECT * FROM ActContParms WHERE ScenarioID=" + Conversions.ToString(intScenarioID), Common.gssConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
						goto IL_0c2f;
						IL_0c2f:
						num = 102;
						num5 = 0;
						goto IL_0c35;
						IL_0c35:
						num = 103;
						num11 = 0;
						goto IL_0c3c;
						IL_0c3c:
						num = 104;
						if (Globals_Renamed.arContParms[num11, num5, x] > 0f)
						{
							goto IL_0c62;
						}
						goto IL_0d54;
						IL_0c62:
						num = 105;
						recordset.AddNew(Missing.Value, Missing.Value);
						goto IL_0c77;
						IL_0c77:
						num = 106;
						recordset.Fields["ScenarioID"].Value = intScenarioID;
						goto IL_0c9b;
						IL_0c9b:
						num = 107;
						recordset.Fields["ScenActID"].Value = num5;
						goto IL_0cbb;
						IL_0cbb:
						num = 108;
						recordset.Fields["ParmID"].Value = num11;
						goto IL_0cdc;
						IL_0cdc:
						num = 109;
						recordset.Fields["ParmValue"].Value = Globals_Renamed.arContParms[num11, num5, x];
						goto IL_0d0d;
						IL_0d0d:
						num = 110;
						recordset.Fields["ParmType"].Value = Globals_Renamed.arContParmTypes[num11, num5, x];
						goto IL_0d3e;
						IL_0d3e:
						num = 111;
						recordset.Update(Missing.Value, Missing.Value);
						goto IL_0d54;
						IL_0d54:
						num = 113;
						num11 = (short)unchecked(num11 + 1);
						num12 = num11;
						num7 = 14;
						if (num12 <= num7)
						{
							goto IL_0c3c;
						}
						goto IL_0d6d;
						IL_0d6d:
						num = 114;
						num5 = (short)unchecked(num5 + 1);
						num13 = num5;
						num7 = 24;
						if (num13 <= num7)
						{
							goto IL_0c35;
						}
						goto IL_0d83;
						IL_0d83:
						num = 115;
						recordset.Close();
						goto IL_0d8e;
						IL_0d8e:
						num = 116;
						recordset.Open("SELECT * FROM GSSOptions WHERE ScenarioID=" + Conversions.ToString(intScenarioID), Common.gssConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
						goto IL_0db5;
						IL_0db5:
						num = 117;
						num5 = 0;
						goto IL_0dbb;
						IL_0dbb:
						num = 118;
						if (Globals_Renamed.arGssOptions[num5, x] > 0)
						{
							goto IL_0ddb;
						}
						goto IL_0ea8;
						IL_0ddb:
						num = 119;
						recordset.AddNew(Missing.Value, Missing.Value);
						goto IL_0df0;
						IL_0df0:
						num = 120;
						recordset.Fields["ScenarioID"].Value = intScenarioID;
						goto IL_0e14;
						IL_0e14:
						num = 121;
						recordset.Fields["ParmID"].Value = num5;
						goto IL_0e34;
						IL_0e34:
						num = 122;
						recordset.Fields["OptionValue"].Value = Globals_Renamed.arGssOptions[num5, x];
						goto IL_0e63;
						IL_0e63:
						num = 123;
						recordset.Fields["Other"].Value = Common.MyNullCheck(Globals_Renamed.arGssOther[num5, x]);
						goto IL_0e92;
						IL_0e92:
						num = 124;
						recordset.Update(Missing.Value, Missing.Value);
						goto IL_0ea8;
						IL_0ea8:
						num = 126;
						num5 = (short)unchecked(num5 + 1);
						num14 = num5;
						num7 = 161;
						if (num14 <= num7)
						{
							goto IL_0dbb;
						}
						goto IL_0ec1;
						IL_0ec1:
						num = 127;
						recordset.Close();
						goto IL_0ecc;
						IL_0ecc:
						num = 128;
						recordset = null;
						goto IL_0ed5;
						IL_0ed5:
						num = 129;
						command = null;
						goto IL_0ede;
						end_IL_0001_3:
						break;
					}
					num = 132;
					string Eobject = "DBFuncs.Bas";
					string Efunction = "GSS_Save_Ops";
					ErrObject val = Information.Err();
					int Enumber = val.Number;
					ErrObject val2 = Information.Err();
					string Edescription = val2.Description;
					bool Econtact = true;
					Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
					val2.Description = Edescription;
					val.Number = Enumber;
					break;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 4474;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_2:
			break;
		}
		bool result = flag;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private static bool GSS_Save_Rel()
	{
		//IL_076c: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
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
						clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
						Recordset recordset2 = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
						Recordset recordset3 = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						ProjectData.ClearProjectError();
						num2 = 2;
						recordset.CursorLocation = CursorLocationEnum.adUseServer;
						recordset.Open("SELECT * FROM ActRelModels WHERE ScenarioID=" + Conversions.ToString(intScenarioID), Common.gssConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
						recordset2.CursorLocation = CursorLocationEnum.adUseServer;
						recordset2.Open("SELECT * FROM ActRelModParms WHERE RelParmsAN=0", Common.gssConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
						recordset3.CursorLocation = CursorLocationEnum.adUseServer;
						recordset3.Open("SELECT * FROM ActRelModMedia WHERE ScenarioID=" + Conversions.ToString(intScenarioID), Common.gssConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
						short num3 = 0;
						short num19;
						short num15;
						do
						{
							short num4 = 0;
							short num18;
							do
							{
								if ((Globals_Renamed.arSelActType[num3, x] > 0) & (Globals_Renamed.arRelModels[num4, num3, x] > 0) & Globals_Renamed.arSelActRa[num3, x])
								{
									Globals_Renamed.intModIndex = (short)(Globals_Renamed.arRelModels[num4, num3, x] - 1);
									recordset.AddNew(Missing.Value, Missing.Value);
									recordset.Fields["ScenarioID"].Value = intScenarioID;
									recordset.Fields["ScenActID"].Value = num3;
									recordset.Fields["RelModID"].Value = num4;
									recordset.Fields["ModelID"].Value = Globals_Renamed.arRelModType[Globals_Renamed.intModIndex];
									int num5 = Conversions.ToInteger(recordset.Fields["RelParmsAN"].Value);
									recordset.Fields["DailyRelCB"].Value = Globals_Renamed.arRelModDRR[1, Globals_Renamed.intModIndex];
									recordset.Fields["DailyRelRE"].Value = Globals_Renamed.arRelModDRR[0, Globals_Renamed.intModIndex];
									recordset.Fields["AnnRelCB"].Value = Globals_Renamed.arRelModARR[1, Globals_Renamed.intModIndex];
									recordset.Fields["AnnRelRE"].Value = Globals_Renamed.arRelModARR[0, Globals_Renamed.intModIndex];
									Field field = recordset.Fields["DailyRel2_SN"];
									float[,] arRelModDRR = Globals_Renamed.arRelModDRR;
									float[,] array = arRelModDRR;
									int num6 = 1;
									int num7 = num6;
									int Enumber = Globals_Renamed.intModIndex;
									object pValue = array[num7, Enumber];
									string value = ChemStrX.ShowInSciNot1digit(ref pValue);
									arRelModDRR[num6, Enumber] = Conversions.ToSingle(pValue);
									field.Value = value;
									Field field2 = recordset.Fields["DailyRel1_SN"];
									arRelModDRR = Globals_Renamed.arRelModDRR;
									float[,] array2 = arRelModDRR;
									Enumber = 0;
									int num8 = Enumber;
									num6 = Globals_Renamed.intModIndex;
									pValue = array2[num8, num6];
									string value2 = ChemStrX.ShowInSciNot1digit(ref pValue);
									arRelModDRR[Enumber, num6] = Conversions.ToSingle(pValue);
									field2.Value = value2;
									Field field3 = recordset.Fields["AnnRel2_SN"];
									arRelModDRR = Globals_Renamed.arRelModARR;
									float[,] array3 = arRelModDRR;
									Enumber = 1;
									int num9 = Enumber;
									num6 = Globals_Renamed.intModIndex;
									pValue = array3[num9, num6];
									string value3 = ChemStrX.ShowInSciNot1digit(ref pValue);
									arRelModDRR[Enumber, num6] = Conversions.ToSingle(pValue);
									field3.Value = value3;
									Field field4 = recordset.Fields["AnnRel1_SN"];
									arRelModDRR = Globals_Renamed.arRelModARR;
									float[,] array4 = arRelModDRR;
									Enumber = 0;
									int num10 = Enumber;
									num6 = Globals_Renamed.intModIndex;
									pValue = array4[num10, num6];
									string value4 = ChemStrX.ShowInSciNot1digit(ref pValue);
									arRelModDRR[Enumber, num6] = Conversions.ToSingle(pValue);
									field4.Value = value4;
									recordset.Fields["RelDays"].Value = Globals_Renamed.arRelModDOR[0, Globals_Renamed.intModIndex];
									recordset.Fields["RelDays2"].Value = Globals_Renamed.arRelModDOR[1, Globals_Renamed.intModIndex];
									recordset.Fields["Basis"].Value = Globals_Renamed.arRelModBasis[Globals_Renamed.intModIndex];
									recordset.Fields["NAICS"].Value = Globals_Renamed.arRelModNAICS[Globals_Renamed.intModIndex];
									recordset.Fields["ModelStatus"].Value = Globals_Renamed.arRelModStatus[Globals_Renamed.intModIndex];
									recordset.Fields["OutputOn1"].Value = Globals_Renamed.arRelModOutputOn[0, Globals_Renamed.intModIndex];
									recordset.Fields["Char1"].Value = Globals_Renamed.arRelModChar[0, Globals_Renamed.intModIndex];
									recordset.Fields["OutputOn2"].Value = Globals_Renamed.arRelModOutputOn[1, Globals_Renamed.intModIndex];
									recordset.Fields["Char2"].Value = Globals_Renamed.arRelModChar[1, Globals_Renamed.intModIndex];
									recordset.Update(Missing.Value, Missing.Value);
									short num11 = 0;
									short num16;
									short num12;
									do
									{
										num12 = 1;
										short num14;
										do
										{
											if (Globals_Renamed.arRelModParmsT[num11, num12, Globals_Renamed.intModIndex] > 0)
											{
												recordset2.AddNew(Missing.Value, Missing.Value);
												recordset2.Fields["RelParmsAN"].Value = num5;
												recordset2.Fields["OutputID"].Value = num11;
												recordset2.Fields["ParmID"].Value = num12;
												short num13 = num12;
												if ((num13 == 92 || num13 == 72 || num13 == 9) ? true : false)
												{
													if (Globals_Renamed.arRelModParmsVC[num11, num12, Globals_Renamed.intModIndex] == 999)
													{
														recordset2.Fields["ParmValue"].Value = Globals_Renamed.arRelModParmsV[num11, num12, Globals_Renamed.intModIndex];
													}
													else if (Globals_Renamed.arRelModParmsVC[num11, num12, Globals_Renamed.intModIndex] > 0)
													{
														recordset2.Fields["ParmValue"].Value = Globals_Renamed.arRelModParmsV[num11, Globals_Renamed.arRelModParmsVC[num11, num12, Globals_Renamed.intModIndex], Globals_Renamed.intModIndex];
													}
													else if (Globals_Renamed.arRelModType[Globals_Renamed.intModIndex] == 53)
													{
														recordset2.Fields["ParmValue"].Value = Globals_Renamed.arRelModParmsV[num11, Globals_Renamed.arRelModParmsVC[num11, num12, Globals_Renamed.intModIndex], Globals_Renamed.intModIndex];
													}
													else
													{
														recordset2.Fields["ParmValue"].Value = Globals_Renamed.arRelModParmsVC[num11, num12, Globals_Renamed.intModIndex];
														if (!flag)
														{
															flag = true;
															Interaction.Beep();
															Interaction.MsgBox((object)"An error occured while saving the release data in the assessment. The assessment was not completely saved. Please contact Technical Support.", (MsgBoxStyle)16, (object)null);
														}
													}
												}
												else
												{
													recordset2.Fields["ParmValue"].Value = Globals_Renamed.arRelModParmsV[num11, num12, Globals_Renamed.intModIndex];
												}
												recordset2.Fields["ParmType"].Value = Globals_Renamed.arRelModParmsT[num11, num12, Globals_Renamed.intModIndex];
												recordset2.Fields["ParmVC"].Value = Globals_Renamed.arRelModParmsVC[num11, num12, Globals_Renamed.intModIndex];
												recordset2.Update(Missing.Value, Missing.Value);
											}
											num12 = (short)unchecked(num12 + 1);
											num14 = num12;
											num15 = 162;
										}
										while (num14 <= num15);
										num11 = (short)unchecked(num11 + 1);
										num16 = num11;
										num15 = 1;
									}
									while (num16 <= num15);
									num12 = 0;
									short num17;
									do
									{
										if (Globals_Renamed.arRelModMedia[num12, Globals_Renamed.intModIndex] > 0f)
										{
											recordset3.AddNew(Missing.Value, Missing.Value);
											recordset3.Fields["ScenarioID"].Value = intScenarioID;
											recordset3.Fields["ScenActID"].Value = num3;
											recordset3.Fields["RelModID"].Value = num4;
											recordset3.Fields["MediaID"].Value = num12;
											recordset3.Fields["Pct"].Value = Globals_Renamed.arRelModMedia[num12, Globals_Renamed.intModIndex];
											recordset3.Update(Missing.Value, Missing.Value);
										}
										num12 = (short)unchecked(num12 + 1);
										num17 = num12;
										num15 = 17;
									}
									while (num17 <= num15);
								}
								num4 = (short)unchecked(num4 + 1);
								num18 = num4;
								num15 = 9;
							}
							while (num18 <= num15);
							num3 = (short)unchecked(num3 + 1);
							num19 = num3;
							num15 = 24;
						}
						while (num19 <= num15);
						recordset.Close();
						recordset2.Close();
						recordset3.Close();
						recordset = null;
						recordset2 = null;
						recordset3 = null;
						flag2 = true;
						goto end_IL_0001;
					}
					case 2533:
						num = -1;
						switch (num2)
						{
						case 2:
						{
							string Eobject = "DBFuncs.Bas";
							string Efunction = "GSS_Save_Rel";
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
					goto IL_0a1f;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 2533;
				continue;
			}
			break;
			IL_0a1f:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		bool result = flag2;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private static bool GSS_Save_Exp()
	{
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b8: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num2 = default(int);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
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
						clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
						Recordset recordset2 = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						ProjectData.ClearProjectError();
						num2 = 2;
						recordset.CursorLocation = CursorLocationEnum.adUseServer;
						recordset.Open("SELECT * FROM ActExpModels WHERE ScenarioID=" + Conversions.ToString(intScenarioID), Common.gssConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
						recordset2.CursorLocation = CursorLocationEnum.adUseClient;
						recordset2.Open("SELECT * FROM ActExpModParms WHERE ExpParmsAN=0", Common.gssConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
						short num3 = 0;
						short num12;
						short num9;
						do
						{
							bool flag = false;
							short num4 = 0;
							short num11;
							do
							{
								if ((Globals_Renamed.arSelActType[num3, x] > 0) & (Globals_Renamed.arExpModels[num4, num3, x] > 0))
								{
									Globals_Renamed.intModIndex = (short)(Globals_Renamed.arExpModels[num4, num3, x] - 1);
									if (Globals_Renamed.intModIndex > Information.UBound((Array)Globals_Renamed.arExpModType, 1))
									{
										Interaction.MsgBox((object)"intModIndex is greater then UBound(arExpModType)", (MsgBoxStyle)0, (object)null);
									}
									else if (Globals_Renamed.arExpModType[Globals_Renamed.intModIndex] > 0)
									{
										flag = true;
										recordset.AddNew(Missing.Value, Missing.Value);
										recordset.Fields["ScenarioID"].Value = intScenarioID;
										recordset.Fields["ScenActID"].Value = num3;
										recordset.Fields["ExplModID"].Value = num4;
										recordset.Fields["ModelID"].Value = Globals_Renamed.arExpModType[Globals_Renamed.intModIndex];
										int num5 = Conversions.ToInteger(recordset.Fields["ExpParmsAN"].Value);
										recordset.Fields["OutputOn1"].Value = Globals_Renamed.arExpModOutputOn[0, Globals_Renamed.intModIndex];
										recordset.Fields["OutputOn2"].Value = Globals_Renamed.arExpModOutputOn[1, Globals_Renamed.intModIndex];
										recordset.Fields["Char1"].Value = Globals_Renamed.arExpModChar[0, Globals_Renamed.intModIndex];
										recordset.Fields["Char2"].Value = Globals_Renamed.arExpModChar[1, Globals_Renamed.intModIndex];
										recordset.Fields["Basis"].Value = Globals_Renamed.arExpModBasis[Globals_Renamed.intModIndex];
										recordset.Fields["ChemStateID"].Value = Globals_Renamed.arExpModChmSt[Globals_Renamed.intModIndex];
										recordset.Fields["inhUncertainty"].Value = Globals_Renamed.arExpModUncertainty[Globals_Renamed.intModIndex];
										recordset.Fields["ModelStatus"].Value = Globals_Renamed.arExpModStatus[Globals_Renamed.intModIndex];
										if (num4 == 1)
										{
											recordset.Fields["InhClass"].Value = Globals_Renamed.arExpModInhRC[0, Globals_Renamed.intModIndex];
											recordset.Fields["InhClassNotes"].Value = Globals_Renamed.arExpModInhRC[1, Globals_Renamed.intModIndex];
											recordset.Fields["InhClassExpLevel"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(Globals_Renamed.arExpModInhRC[2, Globals_Renamed.intModIndex], "Yes", false) == 0, (object)1, (object)0));
											if (Operators.CompareString(frmMain.DefInstance.lblSATHR.Text, "", false) == 0)
											{
												recordset.Fields["InhClassHazRating"].Value = DBNull.Value;
												recordset.Fields["InhClassInhMon"].Value = DBNull.Value;
											}
											else
											{
												recordset.Fields["InhClassHazRating"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(Globals_Renamed.arExpModInhRC[3, Globals_Renamed.intModIndex], "Yes", false) == 0, (object)1, (object)0));
												if (Operators.CompareString(Globals_Renamed.arExpModInhRC[4, Globals_Renamed.intModIndex], "No", false) == 0)
												{
													recordset.Fields["InhClassInhMon"].Value = 0;
												}
												else if (Operators.CompareString(Globals_Renamed.arExpModInhRC[4, Globals_Renamed.intModIndex], "", false) == 0)
												{
													recordset.Fields["InhClassInhMon"].Value = DBNull.Value;
												}
												else
												{
													recordset.Fields["InhClassInhMon"].Value = 1;
												}
											}
										}
										recordset.Update(Missing.Value, Missing.Value);
										short num6 = 0;
										short num10;
										do
										{
											short num7 = 1;
											short num8;
											do
											{
												if (Globals_Renamed.arExpModParmsT[num6, num7, Globals_Renamed.intModIndex] > 0)
												{
													recordset2.AddNew(Missing.Value, Missing.Value);
													recordset2.Fields["ExpParmsAN"].Value = num5;
													recordset2.Fields["OutputID"].Value = num6;
													recordset2.Fields["ParmID"].Value = num7;
													switch (num7)
													{
													case 59:
													case 61:
													case 75:
													case 76:
													case 77:
													case 78:
													case 92:
														if (Globals_Renamed.arExpModParmsVC[num6, num7, Globals_Renamed.intModIndex] == 999)
														{
															recordset2.Fields["ParmValue"].Value = Globals_Renamed.arExpModParmsV[num6, num7, Globals_Renamed.intModIndex];
															break;
														}
														if (Globals_Renamed.arExpModParmsVC[num6, num7, Globals_Renamed.intModIndex] == 998)
														{
															recordset2.Fields["ParmValue"].Value = Globals_Renamed.arExpModParmsV[num6, num7, Globals_Renamed.intModIndex];
															break;
														}
														if ((Globals_Renamed.arExpModParmsVC[num6, num7, Globals_Renamed.intModIndex] > 0) & (Globals_Renamed.arExpModParmsVC[num6, num7, Globals_Renamed.intModIndex] < 162))
														{
															recordset2.Fields["ParmValue"].Value = Globals_Renamed.arExpModParmsV[num6, Globals_Renamed.arExpModParmsVC[num6, num7, Globals_Renamed.intModIndex], Globals_Renamed.intModIndex];
															break;
														}
														recordset2.Fields["ParmValue"].Value = Globals_Renamed.arExpModParmsVC[num6, num7, Globals_Renamed.intModIndex];
														if (!flag2)
														{
															flag2 = true;
															Interaction.Beep();
															Interaction.MsgBox((object)"An error occured while saving the exposure data in the assessment. The assessment was not completely saved. Please contact Technical Support.", (MsgBoxStyle)16, (object)null);
														}
														break;
													default:
														recordset2.Fields["ParmValue"].Value = Globals_Renamed.arExpModParmsV[num6, num7, Globals_Renamed.intModIndex];
														break;
													}
													recordset2.Fields["ParmType"].Value = Globals_Renamed.arExpModParmsT[num6, num7, Globals_Renamed.intModIndex];
													recordset2.Fields["ParmVC"].Value = Globals_Renamed.arExpModParmsVC[num6, num7, Globals_Renamed.intModIndex];
													recordset2.Update(Missing.Value, Missing.Value);
												}
												num7 = (short)unchecked(num7 + 1);
												num8 = num7;
												num9 = 162;
											}
											while (num8 <= num9);
											num6 = (short)unchecked(num6 + 1);
											num10 = num6;
											num9 = 1;
										}
										while (num10 <= num9);
									}
								}
								num4 = (short)unchecked(num4 + 1);
								num11 = num4;
								num9 = 1;
							}
							while (num11 <= num9);
							num3 = (short)unchecked(num3 + 1);
							num12 = num3;
							num9 = 24;
						}
						while (num12 <= num9);
						recordset.Close();
						recordset2.Close();
						recordset = null;
						recordset2 = null;
						flag3 = true;
						goto end_IL_0001;
					}
					case 2350:
						num = -1;
						switch (num2)
						{
						case 2:
						{
							string Eobject = "DBFuncs.Bas";
							string Efunction = "GSS_Save_Exp";
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
				try0001_dispatch = 2350;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		bool result = flag3;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static bool OpenDB()
	{
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
						if (!Open_GenInfo())
						{
							string parea = "General Information";
							CommonErrorMessage(parea);
							goto end_IL_0001;
						}
						if (!Open_ContRpts())
						{
							string parea = "Contact Reports";
							CommonErrorMessage(parea);
							goto end_IL_0001;
						}
						if (!Open_Chemicals())
						{
							string parea = "Chemical Information";
							CommonErrorMessage(parea);
							goto end_IL_0001;
						}
						if (!Open_Ops())
						{
							string parea = "Operations Information";
							CommonErrorMessage(parea);
							goto end_IL_0001;
						}
						if (!Open_Rel())
						{
							string parea = "Release Information";
							CommonErrorMessage(parea);
							goto end_IL_0001;
						}
						if (!Open_Exp())
						{
							string parea = "Exposure Information";
							CommonErrorMessage(parea);
							goto end_IL_0001;
						}
						if (Operators.ConditionalCompareObjectEqual(Open_OtherData(), (object)false, false))
						{
							string parea = "Other Data";
							CommonErrorMessage(parea);
							goto end_IL_0001;
						}
						ProjectData.ClearProjectError();
						num2 = 2;
						if (Globals_Renamed.intNumOps > 0)
						{
							frmMain.DefInstance._lstSelOps_0.SelectedIndex = 0;
							frmMain.DefInstance._lstSelOps_1.SelectedIndex = 0;
							frmMain.DefInstance.LoadOpCmbs();
						}
						string[] array = new string[6];
						frmMain defInstance = frmMain.DefInstance;
						if (Globals_Renamed.gblDataVersion < 11)
						{
							short num3 = 0;
							short num4;
							short num5;
							do
							{
								array[num3] = defInstance.lblNumWMet[num3].Text;
								num3 = (short)unchecked(num3 + 1);
								num4 = num3;
								num5 = 4;
							}
							while (num4 <= num5);
							array[5] = defInstance.lblExpBasedCriteria.Text;
							string parea = defInstance.lblNumExpEst.Text;
							ChemStrX.setDefaultExpFlags();
							if (Operators.CompareString(defInstance.lblNumWMet[(short)4].Text, "Yes", false) == 0)
							{
								num3 = 0;
								short num6;
								do
								{
									defInstance.lblNumWMet[num3].Text = array[num3];
									num3 = (short)unchecked(num3 + 1);
									num6 = num3;
									num5 = 4;
								}
								while (num6 <= num5);
								defInstance.lblExpBasedCriteria.Text = array[5];
								defInstance.lblNumExpEst.Text = parea;
							}
						}
						defInstance = null;
						flag = true;
						goto end_IL_0001;
					}
					case 644:
						num = -1;
						switch (num2)
						{
						case 2:
						{
							string Eobject = "DBFuncs.Bas";
							string Efunction = "OpenDB";
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

	private static void CommonErrorMessage(string parea)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		Interaction.Beep();
		Interaction.MsgBox((object)("A serious error has occured while trying to open an existing assessment. The error occured while trying to access " + parea + " data. Please do not attempt to use this assessment. It is possibly corrupt. Please contact technical support."), (MsgBoxStyle)16, (object)"Possible Corrupt Assessment");
		Interaction.MsgBox((object)("A serious error has occured while trying to open an existing assessment. The error occured while trying to access " + parea + " data. Please do not attempt to use this assessment. It is possibly corrupt. Please contact technical support."), (MsgBoxStyle)16, (object)"Possible Corrupt Assessment");
		Interaction.MsgBox((object)("A serious error has occured while trying to open an existing assessment. The error occured while trying to access " + parea + " data. Please do not attempt to use this assessment. It is possibly corrupt. Please contact technical support."), (MsgBoxStyle)16, (object)"Possible Corrupt Assessment");
		frmMain.DefInstance._lstSelOps_0.Items.Clear();
	}

	private static bool Open_GenInfo()
	{
		int try0001_dispatch = -1;
		int num = default(int);
		Recordset recordset = default(Recordset);
		int num2 = default(int);
		int num3 = default(int);
		bool flag = default(bool);
		frmMain frmMain2 = default(frmMain);
		string text = default(string);
		string text2 = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				string Eobject;
				string Efunction;
				ErrObject val;
				int Enumber;
				ErrObject val2;
				string Edescription;
				bool Econtact;
				int num4;
				switch (try0001_dispatch)
				{
				default:
				{
					num = 1;
					Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
					recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					goto IL_0023;
				}
				case 6709:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 2:
							break;
						case 1:
							goto IL_1753;
						default:
							goto end_IL_0001;
						}
						goto IL_16d1;
					}
					IL_16a9:
					num = 174;
					flag = true;
					goto IL_16b2;
					IL_16b2:
					num = 175;
					recordset.Close();
					goto IL_16c0;
					IL_16a6:
					frmMain2 = null;
					goto IL_16a9;
					IL_16d1:
					num = 178;
					Eobject = "DBFuncs.Bas";
					Efunction = "Open_GenInfo";
					val = Information.Err();
					Enumber = val.Number;
					val2 = Information.Err();
					Edescription = val2.Description;
					Econtact = true;
					Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
					val2.Description = Edescription;
					val.Number = Enumber;
					goto IL_172d;
					IL_172d:
					num = 179;
					ProjectData.ClearProjectError();
					if (num2 == 0)
					{
						throw ProjectData.CreateProjectError(-2146828268);
					}
					goto IL_1753;
					IL_16c0:
					num = 176;
					recordset = null;
					goto end_IL_0001_2;
					IL_1753:
					num4 = num2 + 1;
					num2 = 0;
					switch (num4)
					{
					case 1:
						break;
					case 2:
						goto IL_0023;
					case 3:
						goto IL_002c;
					case 4:
						goto IL_0034;
					case 5:
						goto IL_003f;
					case 6:
						goto IL_0053;
					case 7:
						goto IL_006a;
					case 8:
						goto IL_007c;
					case 9:
					case 10:
						goto IL_00a1;
					case 11:
					case 12:
						goto IL_00ad;
					case 13:
						goto IL_00d4;
					case 14:
						goto IL_00df;
					case 15:
						goto IL_010f;
					case 16:
						goto IL_013f;
					case 17:
						goto IL_016f;
					case 18:
						goto IL_0198;
					case 20:
						goto IL_01b0;
					case 21:
						goto IL_01b5;
					case 19:
					case 22:
					case 23:
						goto IL_020a;
					case 24:
						goto IL_022e;
					case 25:
						goto IL_025e;
					case 26:
						goto IL_028e;
					case 27:
						goto IL_02c4;
					case 28:
						goto IL_02fa;
					case 29:
						goto IL_032a;
					case 30:
						goto IL_035a;
					case 31:
						goto IL_038a;
					case 32:
						goto IL_03b4;
					case 33:
						goto IL_03ee;
					case 34:
					case 35:
						goto IL_0424;
					case 36:
						goto IL_0498;
					case 37:
						goto IL_04c8;
					case 38:
						goto IL_04fe;
					case 39:
						goto IL_0534;
					case 40:
						goto IL_056a;
					case 41:
						goto IL_05a0;
					case 42:
						goto IL_05d6;
					case 43:
						goto IL_060c;
					case 44:
						goto IL_0642;
					case 45:
						goto IL_0678;
					case 46:
						goto IL_06a8;
					case 47:
						goto IL_06d8;
					case 48:
						goto IL_0712;
					case 49:
					case 50:
						goto IL_0748;
					case 51:
						goto IL_0778;
					case 52:
						goto IL_07a8;
					case 53:
						goto IL_07c0;
					case 54:
						goto IL_07f0;
					case 55:
						goto IL_0866;
					case 56:
						goto IL_088f;
					case 58:
						goto IL_08cc;
					case 59:
						goto IL_08d1;
					case 62:
						goto IL_08e6;
					case 63:
						goto IL_08eb;
					case 57:
					case 60:
					case 61:
					case 64:
					case 65:
						goto IL_0902;
					case 66:
						goto IL_0932;
					case 67:
						goto IL_0988;
					case 68:
						goto IL_09de;
					case 69:
						goto IL_0a34;
					case 70:
						goto IL_0a8a;
					case 71:
						goto IL_0ae0;
					case 72:
						goto IL_0af6;
					case 74:
						goto IL_0b28;
					case 75:
						goto IL_0b2d;
					case 73:
					case 76:
					case 77:
						goto IL_0b38;
					case 78:
						goto IL_0b51;
					case 79:
						goto IL_0b86;
					case 80:
						goto IL_0bbb;
					case 81:
						goto IL_0beb;
					case 83:
						goto IL_0c20;
					case 84:
						goto IL_0c25;
					case 85:
						goto IL_0c5a;
					case 86:
						goto IL_0c71;
					case 87:
						goto IL_0c9e;
					case 88:
						goto IL_0cf4;
					case 89:
						goto IL_0d4a;
					case 90:
						goto IL_0da0;
					case 91:
						goto IL_0df6;
					case 93:
						goto IL_0e2d;
					case 94:
						goto IL_0e32;
					case 82:
					case 92:
					case 95:
					case 96:
					case 97:
						goto IL_0e51;
					case 98:
						goto IL_0ea1;
					case 99:
						goto IL_0ef1;
					case 100:
						goto IL_0f21;
					case 101:
						goto IL_0f51;
					case 102:
						goto IL_0f7a;
					case 104:
						goto IL_0f95;
					case 105:
						goto IL_0fc0;
					case 107:
						goto IL_0fd8;
					case 108:
						goto IL_1003;
					case 110:
						goto IL_101b;
					case 111:
						goto IL_1020;
					case 103:
					case 106:
					case 109:
					case 112:
					case 113:
						goto IL_1037;
					case 114:
						goto IL_1067;
					case 115:
						goto IL_109e;
					case 117:
						goto IL_10bc;
					case 118:
						goto IL_10c1;
					case 116:
					case 119:
					case 120:
						goto IL_10f3;
					case 121:
						goto IL_112a;
					case 123:
						goto IL_1148;
					case 124:
						goto IL_114d;
					case 122:
					case 125:
					case 126:
						goto IL_117f;
					case 127:
						goto IL_11b6;
					case 129:
						goto IL_11d4;
					case 130:
						goto IL_11dc;
					case 128:
					case 131:
					case 132:
						goto IL_1211;
					case 133:
						goto IL_1247;
					case 134:
						goto IL_127d;
					case 135:
						goto IL_1295;
					case 136:
						goto IL_12cb;
					case 138:
						goto IL_1303;
					case 139:
						goto IL_130b;
					case 137:
					case 140:
					case 141:
						goto IL_1328;
					case 142:
						goto IL_1358;
					case 143:
						goto IL_1388;
					case 144:
						goto IL_13b3;
					case 145:
						goto IL_13de;
					case 146:
						goto IL_1407;
					case 147:
						goto IL_1415;
					case 148:
						goto IL_1441;
					case 149:
						goto IL_1457;
					case 150:
					case 151:
						goto IL_148c;
					case 152:
						goto IL_14b5;
					case 153:
					case 154:
					case 155:
						goto IL_14e2;
					case 156:
						goto IL_150b;
					case 157:
						goto IL_1534;
					case 159:
						goto IL_1568;
					case 160:
						goto IL_1570;
					case 161:
						goto IL_157e;
					case 162:
						goto IL_15aa;
					case 163:
						goto IL_15c0;
					case 158:
					case 164:
					case 165:
					case 166:
					case 167:
						goto IL_15f7;
					case 168:
						goto IL_1618;
					case 170:
						goto IL_162e;
					case 171:
						goto IL_1636;
					case 169:
					case 172:
					case 173:
						goto IL_16a6;
					case 174:
						goto IL_16a9;
					case 175:
						goto IL_16b2;
					case 176:
						goto IL_16c0;
					case 178:
						goto IL_16d1;
					case 179:
						goto IL_172d;
					default:
						goto end_IL_0001;
					case 177:
					case 180:
						goto end_IL_0001_2;
					}
					goto default;
					IL_0023:
					num = 2;
					text = "Unknown";
					goto IL_002c;
					IL_002c:
					ProjectData.ClearProjectError();
					num3 = 2;
					goto IL_0034;
					IL_0034:
					num = 4;
					recordset.CursorLocation = CursorLocationEnum.adUseClient;
					goto IL_003f;
					IL_003f:
					num = 5;
					if (Globals_Renamed.gblAssessID != 1)
					{
						goto IL_0053;
					}
					goto IL_00ad;
					IL_0053:
					num = 6;
					recordset.Open("SELECT crDate FROM Assessments WHERE AssessID=1", Common.DataConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
					goto IL_006a;
					IL_006a:
					num = 7;
					if (!recordset.EOF)
					{
						goto IL_007c;
					}
					goto IL_00a1;
					IL_007c:
					num = 8;
					text = Strings.FormatDateTime(Conversions.ToDate(recordset.Fields["crDate"].Value), (DateFormat)2);
					goto IL_00a1;
					IL_00a1:
					num = 10;
					recordset.Close();
					goto IL_00ad;
					IL_00ad:
					num = 12;
					recordset.Open("SELECT * FROM Assessments WHERE AssessID=" + Conversions.ToString((int)Globals_Renamed.gblAssessID), Common.DataConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
					goto IL_00d4;
					IL_00d4:
					num = 13;
					frmMain2 = frmMain.DefInstance;
					goto IL_00df;
					IL_00df:
					num = 14;
					frmMain2.lblID.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["EPAIDNumber"].Value));
					goto IL_010f;
					IL_010f:
					num = 15;
					((Control)frmMain2.lblAssessType).Tag = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["AssessType"].Value));
					goto IL_013f;
					IL_013f:
					num = 16;
					frmMain2.lblFiscalYear.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["FiscalYear"].Value));
					goto IL_016f;
					IL_016f:
					num = 17;
					if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["CBI"].Value)))
					{
						goto IL_0198;
					}
					goto IL_01b0;
					IL_0198:
					num = 18;
					frmMain2.lblCBI.Text = "No";
					goto IL_020a;
					IL_01b0:
					num = 20;
					goto IL_01b5;
					IL_01b5:
					num = 21;
					frmMain2.lblCBI.Text = Conversions.ToString(Interaction.IIf(Conversions.ToDouble(Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["CBI"].Value))) == 1.0, (object)"Yes", (object)"No"));
					goto IL_020a;
					IL_020a:
					num = 23;
					text2 = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["TypeOther"].Value));
					goto IL_022e;
					IL_022e:
					num = 24;
					((Control)frmMain2.lblStatus).Tag = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["AssessStatus"].Value));
					goto IL_025e;
					IL_025e:
					num = 25;
					frmMain2.lblCoName.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["Company"].Value));
					goto IL_028e;
					IL_028e:
					num = 26;
					frmMain2.lblAddr[(short)0].Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["Address1"].Value));
					goto IL_02c4;
					IL_02c4:
					num = 27;
					frmMain2.lblAddr[(short)1].Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["Address2"].Value));
					goto IL_02fa;
					IL_02fa:
					num = 28;
					frmMain2.lblCity.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["City"].Value));
					goto IL_032a;
					IL_032a:
					num = 29;
					frmMain2.lblState.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["State"].Value));
					goto IL_035a;
					IL_035a:
					num = 30;
					frmMain2.lblZip.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["Zip"].Value));
					goto IL_038a;
					IL_038a:
					num = 31;
					frmMain2.sContactInfoNotepad = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["ContactInfo"].Value));
					goto IL_03b4;
					IL_03b4:
					num = 32;
					if (Operators.CompareString(Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["SubmissionDate"].Value)), "", false) != 0)
					{
						goto IL_03ee;
					}
					goto IL_0424;
					IL_03ee:
					num = 33;
					frmMain2.lblDate.Text = Strings.Format(RuntimeHelpers.GetObjectValue(recordset.Fields["SubmissionDate"].Value), Globals_Renamed.gblChemDateFormat);
					goto IL_0424;
					IL_0424:
					num = 35;
					frmMain2.lblConsCase.Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["ConsolidatedCase"].Value)), (object)"0", RuntimeHelpers.GetObjectValue(recordset.Fields["ConsolidatedCase"].Value)), (object)1, false), (object)"Yes", (object)"No"));
					goto IL_0498;
					IL_0498:
					num = 36;
					frmMain2.txtConsCase.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["ConsolidatedCaseText"].Value));
					goto IL_04c8;
					IL_04c8:
					num = 37;
					frmMain2.lblName[(short)0].Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["Assessor1"].Value));
					goto IL_04fe;
					IL_04fe:
					num = 38;
					frmMain2.lblAff[(short)0].Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["Assessor1Aff"].Value));
					goto IL_0534;
					IL_0534:
					num = 39;
					frmMain2.lblPhone[(short)0].Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["Assessor1Phone"].Value));
					goto IL_056a;
					IL_056a:
					num = 40;
					frmMain2.lblEmail[(short)0].Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["Assessor1Email"].Value));
					goto IL_05a0;
					IL_05a0:
					num = 41;
					frmMain2.lblName[(short)1].Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["Assessor2"].Value));
					goto IL_05d6;
					IL_05d6:
					num = 42;
					frmMain2.lblAff[(short)1].Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["Assessor2Aff"].Value));
					goto IL_060c;
					IL_060c:
					num = 43;
					frmMain2.lblPhone[(short)1].Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["Assessor2Phone"].Value));
					goto IL_0642;
					IL_0642:
					num = 44;
					frmMain2.lblEmail[(short)1].Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["Assessor2Email"].Value));
					goto IL_0678;
					IL_0678:
					num = 45;
					frmMain2.lblNumCR.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["NumContRpts"].Value));
					goto IL_06a8;
					IL_06a8:
					num = 46;
					frmMain2.txtRevNotes.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["AssessNotepad"].Value));
					goto IL_06d8;
					IL_06d8:
					num = 47;
					if (Operators.CompareString(Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["CRSSdate"].Value)), "", false) != 0)
					{
						goto IL_0712;
					}
					goto IL_0748;
					IL_0712:
					num = 48;
					frmMain2.lblCRSSdate.Text = Strings.Format(RuntimeHelpers.GetObjectValue(recordset.Fields["CRSSdate"].Value), Globals_Renamed.gblChemDateFormat);
					goto IL_0748;
					IL_0748:
					num = 50;
					frmMain2.txtMiscCRSSinfo.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["MiscCRSSinfo"].Value));
					goto IL_0778;
					IL_0778:
					num = 51;
					frmMain2.txtP2Cons.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["P2considerations"].Value));
					goto IL_07a8;
					IL_07a8:
					num = 52;
					if (Globals_Renamed.gblDataVersion >= 6)
					{
						goto IL_07c0;
					}
					goto IL_08e6;
					IL_07c0:
					num = 53;
					frmMain2.txtP2Rec.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["P2considerations"].Value));
					goto IL_07f0;
					IL_07f0:
					num = 54;
					frmMain2.chkp2rec.CheckState = (CheckState)Conversions.ToInteger(Interaction.IIf(Operators.ConditionalCompareObjectEqual(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["P2Rec"].Value)), (object)"0", RuntimeHelpers.GetObjectValue(recordset.Fields["P2Rec"].Value)), (object)1, false), (object)(CheckState)1, (object)(CheckState)0));
					goto IL_0866;
					IL_0866:
					num = 55;
					if (Information.IsDate(RuntimeHelpers.GetObjectValue(recordset.Fields["crDate"].Value)))
					{
						goto IL_088f;
					}
					goto IL_08cc;
					IL_088f:
					num = 56;
					frmMain2.lblAssessmentVersion.Text = Strings.FormatDateTime(Conversions.ToDate(recordset.Fields["crDate"].Value), (DateFormat)2) + " version";
					goto IL_0902;
					IL_08cc:
					num = 58;
					goto IL_08d1;
					IL_08d1:
					num = 59;
					frmMain2.lblAssessmentVersion.Text = text;
					goto IL_0902;
					IL_08e6:
					num = 62;
					goto IL_08eb;
					IL_08eb:
					num = 63;
					frmMain2.lblAssessmentVersion.Text = "Pre May 3rd, 2004 version";
					goto IL_0902;
					IL_0902:
					num = 65;
					frmMain2.txtAssumps.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["Assumptions"].Value));
					goto IL_0932;
					IL_0932:
					num = 66;
					frmMain2.lblNumWMet[(short)0].Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["NumWorkersCriteria"].Value)), (object)1, false), (object)"Yes", (object)"No"));
					goto IL_0988;
					IL_0988:
					num = 67;
					frmMain2.lblNumWMet[(short)1].Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["GT100WGT10"].Value)), (object)1, false), (object)"Yes", (object)"No"));
					goto IL_09de;
					IL_09de:
					num = 68;
					frmMain2.lblNumWMet[(short)2].Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["GT100W1to10"].Value)), (object)1, false), (object)"Yes", (object)"No"));
					goto IL_0a34;
					IL_0a34:
					num = 69;
					frmMain2.lblNumWMet[(short)3].Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["RoutineDermalGT250"].Value)), (object)1, false), (object)"Yes", (object)"No"));
					goto IL_0a8a;
					IL_0a8a:
					num = 70;
					frmMain2.lblNumWMet[(short)4].Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["ExpBased"].Value)), (object)1, false), (object)"Yes", (object)"No"));
					goto IL_0ae0;
					IL_0ae0:
					num = 71;
					if (Globals_Renamed.gblDataVersion >= 12)
					{
						goto IL_0af6;
					}
					goto IL_0b28;
					IL_0af6:
					num = 72;
					frmMain2.lblExpBasedCriteria.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["NumExpBasedCriteria"].Value));
					goto IL_0b38;
					IL_0b28:
					num = 74;
					goto IL_0b2d;
					IL_0b2d:
					num = 75;
					ChemStrX.resetExpBasedCriteria();
					goto IL_0b38;
					IL_0b38:
					num = 77;
					if (Globals_Renamed.gblDataVersion >= 11)
					{
						goto IL_0b51;
					}
					goto IL_0c20;
					IL_0b51:
					num = 78;
					frmMain2.lblNumExp.Text = Conversions.ToString(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["NumWorkersExposed"].Value)));
					goto IL_0b86;
					IL_0b86:
					num = 79;
					frmMain2.lblNumExpEst.Text = Conversions.ToString(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["NumWorkersExpEst"].Value)));
					goto IL_0bbb;
					IL_0bbb:
					num = 80;
					frmMain2.txtNumExpEstBasis.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["NumWorkersExpEstBasis"].Value));
					goto IL_0beb;
					IL_0beb:
					num = 81;
					((Control)frmMain2.txtNumExpEstBasis).Tag = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["NumWorkersExpEstEnabled"].Value));
					goto IL_0e51;
					IL_0c20:
					num = 83;
					goto IL_0c25;
					IL_0c25:
					num = 84;
					frmMain2.lblNumExp.Text = Conversions.ToString(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["NumWorkersExposed"].Value)));
					goto IL_0c5a;
					IL_0c5a:
					num = 85;
					((Control)frmMain2.txtNumExpEstBasis).Tag = 0;
					goto IL_0c71;
					IL_0c71:
					num = 86;
					if (Operators.CompareString(frmMain2.lblNumWMet[(short)4].Text, "Yes", false) == 0)
					{
						goto IL_0c9e;
					}
					goto IL_0e2d;
					IL_0c9e:
					num = 87;
					frmMain2.lblNumWMet[(short)0].Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["NumWorkersCriteria"].Value)), (object)1, false), (object)"Yes", (object)"No"));
					goto IL_0cf4;
					IL_0cf4:
					num = 88;
					frmMain2.lblNumWMet[(short)1].Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["GT100WGT10"].Value)), (object)1, false), (object)"Yes", (object)"No"));
					goto IL_0d4a;
					IL_0d4a:
					num = 89;
					frmMain2.lblNumWMet[(short)2].Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["GT100W1to10"].Value)), (object)1, false), (object)"Yes", (object)"No"));
					goto IL_0da0;
					IL_0da0:
					num = 90;
					frmMain2.lblNumWMet[(short)3].Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["RoutineDermalGT250"].Value)), (object)1, false), (object)"Yes", (object)"No"));
					goto IL_0df6;
					IL_0df6:
					num = 91;
					frmMain2.lblNumExpEst.Text = Conversions.ToString(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["NumWorkersExposed"].Value)));
					goto IL_0e51;
					IL_0e2d:
					num = 93;
					goto IL_0e32;
					IL_0e32:
					num = 94;
					frmMain2.lblNumExpEst.Text = frmMain2.lblNumExp.Text;
					goto IL_0e51;
					IL_0e51:
					num = 97;
					frmMain2.lblMsdsInc.Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["MSDSInc"].Value)), (object)1, false), (object)"Yes", (object)"No"));
					goto IL_0ea1;
					IL_0ea1:
					num = 98;
					frmMain2.lblMsdsLab.Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["LabelInc"].Value)), (object)1, false), (object)"Yes", (object)"No"));
					goto IL_0ef1;
					IL_0ef1:
					num = 99;
					frmMain2.txtOtherUses.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["otherUses"].Value));
					goto IL_0f21;
					IL_0f21:
					num = 100;
					frmMain2.lblOccExpRating.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["OccExpRating"].Value));
					goto IL_0f51;
					IL_0f51:
					num = 101;
					if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["ConsUse"].Value)))
					{
						goto IL_0f7a;
					}
					goto IL_0f95;
					IL_0f7a:
					num = 102;
					frmMain2.lblConsUse.Text = "";
					goto IL_1037;
					IL_0f95:
					num = 104;
					if (Operators.ConditionalCompareObjectEqual(recordset.Fields["ConsUse"].Value, (object)1, false))
					{
						goto IL_0fc0;
					}
					goto IL_0fd8;
					IL_0fc0:
					num = 105;
					frmMain2.lblConsUse.Text = "Yes";
					goto IL_1037;
					IL_0fd8:
					num = 107;
					if (Operators.ConditionalCompareObjectEqual(recordset.Fields["ConsUse"].Value, (object)0, false))
					{
						goto IL_1003;
					}
					goto IL_101b;
					IL_1003:
					num = 108;
					frmMain2.lblConsUse.Text = "No";
					goto IL_1037;
					IL_101b:
					num = 110;
					goto IL_1020;
					IL_1020:
					num = 111;
					frmMain2.lblConsUse.Text = "";
					goto IL_1037;
					IL_1037:
					num = 113;
					frmMain2.lblStatus.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["StatusOther"].Value));
					goto IL_1067;
					IL_1067:
					num = 114;
					if (Operators.CompareString(Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["MSDS_GenEq"].Value)), "", false) == 0)
					{
						goto IL_109e;
					}
					goto IL_10bc;
					IL_109e:
					num = 115;
					frmMain2.txtMsds[(short)0].Text = Globals_Renamed.gblMsdsGE;
					goto IL_10f3;
					IL_10bc:
					num = 117;
					goto IL_10c1;
					IL_10c1:
					num = 118;
					frmMain2.txtMsds[(short)0].Text = Conversions.ToString(recordset.Fields["MSDS_GenEq"].Value);
					goto IL_10f3;
					IL_10f3:
					num = 120;
					if (Operators.CompareString(Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["MSDS_Resp"].Value)), "", false) == 0)
					{
						goto IL_112a;
					}
					goto IL_1148;
					IL_112a:
					num = 121;
					frmMain2.txtMsds[(short)1].Text = Globals_Renamed.gblMsdsResp;
					goto IL_117f;
					IL_1148:
					num = 123;
					goto IL_114d;
					IL_114d:
					num = 124;
					frmMain2.txtMsds[(short)1].Text = Conversions.ToString(recordset.Fields["MSDS_Resp"].Value);
					goto IL_117f;
					IL_117f:
					num = 126;
					if (Operators.CompareString(Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["MSDS_HE"].Value)), "", false) == 0)
					{
						goto IL_11b6;
					}
					goto IL_11d4;
					IL_11b6:
					num = 127;
					frmMain2.txtMsds[(short)2].Text = Globals_Renamed.gblMsdsHE;
					goto IL_1211;
					IL_11d4:
					num = 129;
					goto IL_11dc;
					IL_11dc:
					num = 130;
					frmMain2.txtMsds[(short)2].Text = Conversions.ToString(recordset.Fields["MSDS_HE"].Value);
					goto IL_1211;
					IL_1211:
					num = 132;
					frmMain.DefInstance.lblAVPlow.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["VPlow"].Value));
					goto IL_1247;
					IL_1247:
					num = 133;
					frmMain.DefInstance.lblAVPhigh.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["VPhigh"].Value));
					goto IL_127d;
					IL_127d:
					num = 134;
					if (Globals_Renamed.gblDataVersion >= 5)
					{
						goto IL_1295;
					}
					goto IL_1303;
					IL_1295:
					num = 135;
					frmMain.DefInstance.lblLastSaved.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["LastSaved"].Value));
					goto IL_12cb;
					IL_12cb:
					num = 136;
					frmMain.DefInstance.txtLVEPPE.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["LVE_PPE"].Value));
					goto IL_1328;
					IL_1303:
					num = 138;
					goto IL_130b;
					IL_130b:
					num = 139;
					frmMain.DefInstance.lblLastSaved.Text = "Unknown";
					goto IL_1328;
					IL_1328:
					num = 141;
					Globals_Renamed.gblPreviousType = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["AssessType"].Value)));
					goto IL_1358;
					IL_1358:
					num = 142;
					Globals_Renamed.gblPreviousStatus = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["AssessStatus"].Value)));
					goto IL_1388;
					IL_1388:
					num = 143;
					Globals_Renamed.gblPreviousID = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["EPAIDNumber"].Value));
					goto IL_13b3;
					IL_13b3:
					num = 144;
					Globals_Renamed.gblPreviousYear = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["FiscalYear"].Value));
					goto IL_13de;
					IL_13de:
					num = 145;
					if (Strings.Len(RuntimeHelpers.GetObjectValue(((Control)frmMain2.lblAssessType).Tag)) > 0)
					{
						goto IL_1407;
					}
					goto IL_14e2;
					IL_1407:
					num = 146;
					recordset.Close();
					goto IL_1415;
					IL_1415:
					num = 147;
					recordset.Open(Operators.ConcatenateObject((object)"SELECT AssType FROM ListOfAssessTypes WHERE AssTypeID=", ((Control)frmMain2.lblAssessType).Tag), Common.MyConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
					goto IL_1441;
					IL_1441:
					num = 148;
					if (!recordset.EOF)
					{
						goto IL_1457;
					}
					goto IL_148c;
					IL_1457:
					num = 149;
					frmMain2.lblAssessType.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields[0].Value));
					goto IL_148c;
					IL_148c:
					num = 151;
					if (Conversions.ToDouble(((Control)frmMain2.lblAssessType).Tag) > 900.0)
					{
						goto IL_14b5;
					}
					goto IL_14e2;
					IL_14b5:
					num = 152;
					frmMain2.lblAssessType.Text = frmMain2.lblAssessType.Text + ": " + text2;
					goto IL_14e2;
					IL_14e2:
					num = 155;
					if (Strings.Len(RuntimeHelpers.GetObjectValue(((Control)frmMain2.lblStatus).Tag)) > 0)
					{
						goto IL_150b;
					}
					goto IL_15f7;
					IL_150b:
					num = 156;
					if (Conversions.ToDouble(((Control)frmMain2.lblStatus).Tag) > 900.0)
					{
						goto IL_1534;
					}
					goto IL_1568;
					IL_1534:
					num = 157;
					frmMain2.lblStatus.Text = "Other: " + Common.MyNullCheck(frmMain2.lblStatus.Text);
					goto IL_15f7;
					IL_1568:
					num = 159;
					goto IL_1570;
					IL_1570:
					num = 160;
					recordset.Close();
					goto IL_157e;
					IL_157e:
					num = 161;
					recordset.Open(Operators.ConcatenateObject((object)"SELECT AssStatus FROM ListOfAssStatus WHERE AssStatusID=", ((Control)frmMain2.lblStatus).Tag), Common.MyConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
					goto IL_15aa;
					IL_15aa:
					num = 162;
					if (!recordset.EOF)
					{
						goto IL_15c0;
					}
					goto IL_15f7;
					IL_15c0:
					num = 163;
					frmMain2.lblStatus.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields[0].Value));
					goto IL_15f7;
					IL_15f7:
					num = 167;
					if (Strings.Len(frmMain2.lblID.Text) == 0)
					{
						goto IL_1618;
					}
					goto IL_162e;
					IL_1618:
					num = 168;
					((Form)frmMain2).Text = "ChemSTEER v3.2, Unnamed Assessment";
					goto IL_16a6;
					IL_162e:
					num = 170;
					goto IL_1636;
					IL_1636:
					num = 171;
					((Form)frmMain2).Text = "ChemSTEER v3.2, " + frmMain2.lblAssessType.Text + " " + frmMain2.lblFiscalYear.Text + "-" + frmMain2.lblID.Text;
					goto IL_16a6;
					end_IL_0001:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 6709;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_2:
			break;
		}
		bool result = flag;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private static bool Open_Ops()
	{
		int try0001_dispatch = -1;
		int num = default(int);
		Recordset recordset = default(Recordset);
		int num2 = default(int);
		int num3 = default(int);
		short num4 = default(short);
		Recordset recordset2 = default(Recordset);
		bool flag = default(bool);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					string Eobject;
					string Efunction;
					ErrObject val;
					int Enumber;
					ErrObject val2;
					string Edescription;
					bool Econtact;
					int num5;
					Guid clsid;
					switch (try0001_dispatch)
					{
					default:
						num = 1;
						clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
						recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						goto IL_0023;
					case 10419:
						{
							num2 = num;
							switch ((num3 <= -2) ? 1 : num3)
							{
							case 2:
								break;
							case 1:
								goto IL_2261;
							default:
								goto end_IL_0001;
							}
							goto IL_21df;
						}
						IL_0c57:
						num = 205;
						Globals_Renamed.arOpNeedsMassBalance[num4] = Conversions.ToShort(Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["OpGssimport"].Value)));
						goto IL_0c8a;
						IL_0c8a:
						num = 207;
						num4++;
						goto IL_0c96;
						IL_0c3e:
						num = 204;
						if (Globals_Renamed.gblDataVersion >= 14)
						{
							goto IL_0c57;
						}
						goto IL_0c8a;
						IL_21df:
						num = 398;
						Eobject = "DBFuncs.Bas";
						Efunction = "Open_Ops";
						val = Information.Err();
						Enumber = val.Number;
						val2 = Information.Err();
						Edescription = val2.Description;
						Econtact = true;
						Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
						val2.Description = Edescription;
						val.Number = Enumber;
						goto IL_223b;
						IL_223b:
						num = 399;
						ProjectData.ClearProjectError();
						if (num2 == 0)
						{
							throw ProjectData.CreateProjectError(-2146828268);
						}
						goto IL_2261;
						IL_0c96:
						num = 208;
						recordset.MoveNext();
						goto IL_0ca5;
						IL_2261:
						num5 = unchecked(num2 + 1);
						num2 = 0;
						switch (num5)
						{
						case 1:
							break;
						case 2:
							goto IL_0023;
						case 3:
							goto IL_0045;
						case 4:
							goto IL_004d;
						case 5:
						case 7:
							goto IL_005b;
						case 8:
						case 10:
							goto IL_0069;
						case 11:
						case 13:
							goto IL_007c;
						case 14:
						case 16:
							goto IL_008b;
						case 17:
						case 19:
							goto IL_009a;
						case 20:
						case 22:
							goto IL_00a9;
						case 23:
						case 25:
							goto IL_00b9;
						case 26:
						case 28:
							goto IL_00c8;
						case 29:
						case 31:
							goto IL_00d7;
						case 32:
						case 34:
							goto IL_00e6;
						case 35:
						case 37:
							goto IL_00f5;
						case 38:
						case 40:
							goto IL_0104;
						case 41:
						case 43:
							goto IL_0113;
						case 44:
						case 46:
							goto IL_0122;
						case 47:
						case 49:
							goto IL_0131;
						case 50:
						case 52:
							goto IL_0140;
						case 53:
						case 55:
							goto IL_014f;
						case 56:
						case 58:
							goto IL_015e;
						case 59:
						case 61:
							goto IL_016d;
						case 62:
						case 64:
							goto IL_017c;
						case 65:
						case 67:
							goto IL_018c;
						case 68:
						case 70:
							goto IL_019c;
						case 71:
						case 73:
							goto IL_01ab;
						case 74:
						case 76:
							goto IL_01ba;
						case 77:
						case 79:
							goto IL_01c9;
						case 80:
						case 82:
							goto IL_01d8;
						case 83:
							goto IL_01e4;
						case 84:
							goto IL_0210;
						case 87:
							goto IL_021b;
						case 88:
						case 90:
							goto IL_0242;
						case 91:
						case 93:
							goto IL_0269;
						case 94:
						case 96:
							goto IL_0290;
						case 97:
						case 99:
							goto IL_02b7;
						case 100:
						case 102:
							goto IL_02de;
						case 103:
						case 105:
							goto IL_0305;
						case 106:
						case 108:
							goto IL_032d;
						case 109:
						case 111:
							goto IL_0354;
						case 112:
						case 114:
							goto IL_037b;
						case 115:
						case 117:
							goto IL_03a2;
						case 118:
						case 120:
							goto IL_03c9;
						case 121:
						case 123:
							goto IL_03f0;
						case 124:
						case 126:
							goto IL_0417;
						case 127:
						case 129:
							goto IL_043e;
						case 130:
						case 132:
							goto IL_0468;
						case 133:
						case 135:
							goto IL_0492;
						case 136:
						case 138:
							goto IL_04bc;
						case 139:
						case 141:
							goto IL_04e6;
						case 142:
						case 144:
							goto IL_0510;
						case 145:
						case 147:
							goto IL_053a;
						case 148:
						case 150:
							goto IL_0565;
						case 151:
						case 153:
							goto IL_0590;
						case 154:
						case 156:
							goto IL_05ba;
						case 157:
						case 159:
							goto IL_05e4;
						case 160:
						case 162:
							goto IL_060e;
						case 163:
						case 165:
							goto IL_0638;
						case 166:
							goto IL_066a;
						case 167:
							goto IL_0698;
						case 168:
							goto IL_06c6;
						case 169:
							goto IL_06f4;
						case 170:
							goto IL_0722;
						case 171:
							goto IL_0750;
						case 172:
							goto IL_077e;
						case 173:
							goto IL_07ac;
						case 174:
							goto IL_0803;
						case 175:
							goto IL_0835;
						case 176:
							goto IL_0867;
						case 177:
							goto IL_0895;
						case 178:
							goto IL_08c7;
						case 179:
							goto IL_08fe;
						case 180:
							goto IL_0935;
						case 181:
							goto IL_096c;
						case 182:
							goto IL_09a3;
						case 183:
							goto IL_09d1;
						case 184:
							goto IL_09ec;
						case 185:
							goto IL_0a1a;
						case 186:
							goto IL_0a48;
						case 187:
							goto IL_0a63;
						case 188:
							goto IL_0a91;
						case 189:
							goto IL_0abf;
						case 190:
							goto IL_0ad7;
						case 191:
						case 192:
						case 193:
						case 194:
							goto IL_0b08;
						case 195:
							goto IL_0b24;
						case 196:
							goto IL_0b56;
						case 197:
							goto IL_0b8d;
						case 198:
							goto IL_0bc4;
						case 199:
							goto IL_0bf2;
						case 201:
							goto IL_0c26;
						case 202:
							goto IL_0c2e;
						case 200:
						case 203:
						case 204:
							goto IL_0c3e;
						case 205:
							goto IL_0c57;
						case 206:
						case 207:
							goto IL_0c8a;
						case 208:
							goto IL_0c96;
						case 85:
						case 86:
						case 209:
							goto IL_0ca5;
						case 210:
							goto IL_0cbb;
						case 211:
							goto IL_0cc8;
						case 212:
							goto IL_0cd6;
						case 213:
						case 215:
							goto IL_0cf0;
						case 216:
						case 218:
							goto IL_0d0a;
						case 219:
							goto IL_0d34;
						case 220:
							goto IL_0d43;
						case 223:
							goto IL_0d63;
						case 224:
							goto IL_0dc7;
						case 225:
							goto IL_0dd5;
						case 226:
							goto IL_0e18;
						case 227:
							goto IL_0e2b;
						case 229:
							goto IL_0e77;
						case 230:
							goto IL_0e7f;
						case 228:
						case 231:
						case 232:
							goto IL_0ee4;
						case 221:
						case 222:
						case 233:
							goto IL_0ef3;
						case 234:
							goto IL_0f0c;
						case 235:
							goto IL_0f1a;
						case 236:
							goto IL_0f28;
						case 237:
						case 239:
							goto IL_0f42;
						case 240:
						case 242:
							goto IL_0f5c;
						case 243:
						case 245:
							goto IL_0f76;
						case 246:
						case 248:
							goto IL_0f90;
						case 249:
						case 251:
							goto IL_0faa;
						case 252:
						case 254:
							goto IL_0fc4;
						case 257:
							goto IL_0ff3;
						case 258:
							goto IL_1057;
						case 259:
							goto IL_10bb;
						case 260:
							goto IL_111f;
						case 261:
							goto IL_1183;
						case 262:
							goto IL_11e7;
						case 263:
							goto IL_124b;
						case 255:
						case 256:
						case 264:
							goto IL_125a;
						case 265:
							goto IL_1273;
						case 266:
							goto IL_1281;
						case 267:
						case 269:
							goto IL_129b;
						case 270:
						case 272:
							goto IL_12b5;
						case 273:
						case 275:
							goto IL_12cf;
						case 276:
						case 278:
							goto IL_12e9;
						case 279:
						case 281:
							goto IL_1303;
						case 282:
						case 284:
							goto IL_131d;
						case 285:
						case 287:
							goto IL_1337;
						case 288:
						case 290:
							goto IL_1352;
						case 291:
						case 293:
							goto IL_136c;
						case 294:
						case 296:
							goto IL_1386;
						case 299:
							goto IL_13b5;
						case 300:
							goto IL_1419;
						case 301:
							goto IL_1482;
						case 302:
							goto IL_14eb;
						case 303:
							goto IL_1554;
						case 304:
							goto IL_15bd;
						case 305:
							goto IL_1626;
						case 306:
							goto IL_168f;
						case 307:
							goto IL_16ab;
						case 308:
							goto IL_1715;
						case 309:
							goto IL_177f;
						case 310:
							goto IL_17e9;
						case 311:
						case 312:
							goto IL_184e;
						case 313:
							goto IL_1867;
						case 315:
							goto IL_18d2;
						case 316:
							goto IL_18da;
						case 314:
						case 317:
						case 318:
							goto IL_194f;
						case 297:
						case 298:
						case 319:
							goto IL_195e;
						case 320:
							goto IL_1977;
						case 321:
							goto IL_1985;
						case 322:
						case 324:
							goto IL_199f;
						case 325:
						case 327:
							goto IL_19b9;
						case 328:
						case 330:
							goto IL_19d3;
						case 333:
							goto IL_1a02;
						case 334:
							goto IL_1a6b;
						case 335:
							goto IL_1ad4;
						case 336:
							goto IL_1b3d;
						case 331:
						case 332:
						case 337:
							goto IL_1b4c;
						case 338:
							goto IL_1b65;
						case 339:
							goto IL_1b73;
						case 340:
						case 342:
							goto IL_1b90;
						case 343:
						case 345:
							goto IL_1bad;
						case 346:
						case 348:
							goto IL_1bdb;
						case 349:
						case 351:
							goto IL_1c09;
						case 354:
							goto IL_1c38;
						case 355:
							goto IL_1c6d;
						case 356:
							goto IL_1cd6;
						case 358:
							goto IL_1d44;
						case 359:
							goto IL_1d4c;
						case 360:
							goto IL_1dc4;
						case 357:
						case 361:
						case 362:
							goto IL_1e3d;
						case 352:
						case 353:
						case 363:
							goto IL_1e4c;
						case 364:
							goto IL_1e65;
						case 365:
							goto IL_1e73;
						case 366:
						case 368:
							goto IL_1e8f;
						case 369:
						case 371:
							goto IL_1eab;
						case 374:
							goto IL_1eda;
						case 375:
							goto IL_1f5d;
						case 376:
							goto IL_1fe0;
						case 372:
						case 373:
						case 377:
							goto IL_1fef;
						case 378:
							goto IL_2008;
						case 379:
							goto IL_2016;
						case 380:
						case 382:
							goto IL_2047;
						case 383:
						case 385:
							goto IL_2078;
						case 388:
							goto IL_20a7;
						case 389:
							goto IL_2110;
						case 390:
							goto IL_2174;
						case 386:
						case 387:
						case 391:
							goto IL_2183;
						case 392:
							goto IL_219c;
						case 393:
							goto IL_21aa;
						case 394:
							goto IL_21b3;
						case 395:
							goto IL_21bc;
						case 396:
							goto IL_21ce;
						case 398:
							goto IL_21df;
						case 399:
							goto IL_223b;
						default:
							goto end_IL_0001;
						case 397:
						case 400:
							goto end_IL_0001_2;
						}
						goto default;
						IL_0023:
						num = 2;
						clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
						recordset2 = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						goto IL_0045;
						IL_0045:
						ProjectData.ClearProjectError();
						num3 = 2;
						goto IL_004d;
						IL_004d:
						num = 4;
						Globals_Renamed.arOpPv = new double[2];
						goto IL_005b;
						IL_005b:
						num = 7;
						Globals_Renamed.arPDesc = new string[2];
						goto IL_0069;
						IL_0069:
						num = 10;
						Globals_Renamed.arBasis = new string[num4 + 1 + 1];
						goto IL_007c;
						IL_007c:
						num = 13;
						Globals_Renamed.arWaterBasis = new string[2];
						goto IL_008b;
						IL_008b:
						num = 16;
						Globals_Renamed.arRelAddNotes = new string[2];
						goto IL_009a;
						IL_009a:
						num = 19;
						Globals_Renamed.arExpAddNotes = new string[2];
						goto IL_00a9;
						IL_00a9:
						num = 22;
						Globals_Renamed.arOpNumWorkers = new long[3, 2];
						goto IL_00b9;
						IL_00b9:
						num = 25;
						Globals_Renamed.arOpNumWorkersBasis = new string[2];
						goto IL_00c8;
						IL_00c8:
						num = 28;
						Globals_Renamed.arOpNumWorkersBasisEnabled = new short[2];
						goto IL_00d7;
						IL_00d7:
						num = 31;
						Globals_Renamed.arInhalationBasis = new string[2];
						goto IL_00e6;
						IL_00e6:
						num = 34;
						Globals_Renamed.arDermalBasis = new string[2];
						goto IL_00f5;
						IL_00f5:
						num = 37;
						Globals_Renamed.arPSInto1 = new string[2];
						goto IL_0104;
						IL_0104:
						num = 40;
						Globals_Renamed.arPSInto2 = new string[2];
						goto IL_0113;
						IL_0113:
						num = 43;
						Globals_Renamed.arPSOut1 = new string[2];
						goto IL_0122;
						IL_0122:
						num = 46;
						Globals_Renamed.arPSOut2 = new string[2];
						goto IL_0131;
						IL_0131:
						num = 49;
						Globals_Renamed.arPSIn1 = new string[2];
						goto IL_0140;
						IL_0140:
						num = 52;
						Globals_Renamed.arPSIn2 = new string[2];
						goto IL_014f;
						IL_014f:
						num = 55;
						Globals_Renamed.arNoPre = new bool[2];
						goto IL_015e;
						IL_015e:
						num = 58;
						Globals_Renamed.arOpBorC = new short[2];
						goto IL_016d;
						IL_016d:
						num = 61;
						Globals_Renamed.arOpIoE = new short[2];
						goto IL_017c;
						IL_017c:
						num = 64;
						Globals_Renamed.arOpMassBalDisc = new int[3, 2];
						goto IL_018c;
						IL_018c:
						num = 67;
						Globals_Renamed.arMiscOpParms = new float[3, 2];
						goto IL_019c;
						IL_019c:
						num = 70;
						Globals_Renamed.arOpType = new short[2];
						goto IL_01ab;
						IL_01ab:
						num = 73;
						Globals_Renamed.arOpOrder = new short[2];
						goto IL_01ba;
						IL_01ba:
						num = 76;
						Globals_Renamed.arOpName = new string[2];
						goto IL_01c9;
						IL_01c9:
						num = 79;
						Globals_Renamed.arOpNeedsMassBalance = new short[2];
						goto IL_01d8;
						IL_01d8:
						num = 82;
						recordset.CursorLocation = CursorLocationEnum.adUseClient;
						goto IL_01e4;
						IL_01e4:
						num = 83;
						recordset.Open("SELECT * FROM Operations WHERE AssessID=" + Conversions.ToString(unchecked((int)Globals_Renamed.gblAssessID)) + " ORDER BY AssOpID", Common.DataConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
						goto IL_0210;
						IL_0210:
						num = 84;
						num4 = 0;
						goto IL_0ca5;
						IL_0ca5:
						num = 86;
						if (!recordset.EOF)
						{
							goto IL_021b;
						}
						goto IL_0cbb;
						IL_0cbb:
						num = 210;
						Globals_Renamed.intNumOps = num4;
						goto IL_0cc8;
						IL_0cc8:
						num = 211;
						recordset.Close();
						goto IL_0cd6;
						IL_0cd6:
						num = 212;
						Globals_Renamed.arNaics1 = new string[100, Globals_Renamed.intNumOps + 1];
						goto IL_0cf0;
						IL_0cf0:
						num = 215;
						Globals_Renamed.arNaics2 = new string[100, Globals_Renamed.intNumOps + 1];
						goto IL_0d0a;
						IL_0d0a:
						num = 218;
						recordset.Open("SELECT * FROM OpNaics WHERE AssessID=" + Conversions.ToString(unchecked((int)Globals_Renamed.gblAssessID)), Common.DataConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
						goto IL_0d34;
						IL_0d34:
						num = 219;
						recordset2.CursorLocation = CursorLocationEnum.adUseClient;
						goto IL_0d43;
						IL_0d43:
						num = 220;
						recordset2.Open("Select naics, naicsdesc FROM NAICS", Common.MyConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
						goto IL_0ef3;
						IL_0ef3:
						num = 222;
						if (!recordset.EOF)
						{
							goto IL_0d63;
						}
						goto IL_0f0c;
						IL_0f0c:
						num = 234;
						recordset.Close();
						goto IL_0f1a;
						IL_0f1a:
						num = 235;
						recordset2.Close();
						goto IL_0f28;
						IL_0f28:
						num = 236;
						Globals_Renamed.arOSName = new string[100, Globals_Renamed.intNumOps + 1];
						goto IL_0f42;
						IL_0f42:
						num = 239;
						Globals_Renamed.arOSAddr = new string[100, Globals_Renamed.intNumOps + 1];
						goto IL_0f5c;
						IL_0f5c:
						num = 242;
						Globals_Renamed.arOSCity = new string[100, Globals_Renamed.intNumOps + 1];
						goto IL_0f76;
						IL_0f76:
						num = 245;
						Globals_Renamed.arOSState = new string[100, Globals_Renamed.intNumOps + 1];
						goto IL_0f90;
						IL_0f90:
						num = 248;
						Globals_Renamed.arOSZip = new string[100, Globals_Renamed.intNumOps + 1];
						goto IL_0faa;
						IL_0faa:
						num = 251;
						Globals_Renamed.arOSCty = new string[100, Globals_Renamed.intNumOps + 1];
						goto IL_0fc4;
						IL_0fc4:
						num = 254;
						recordset.Open("SELECT * FROM OpSites WHERE AssessID=" + Conversions.ToString(unchecked((int)Globals_Renamed.gblAssessID)), Common.DataConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
						goto IL_125a;
						IL_125a:
						num = 256;
						if (!recordset.EOF)
						{
							goto IL_0ff3;
						}
						goto IL_1273;
						IL_1273:
						num = 265;
						recordset.Close();
						goto IL_1281;
						IL_1281:
						num = 266;
						Globals_Renamed.arSelActs = new string[26, Globals_Renamed.intNumOps + 1];
						goto IL_129b;
						IL_129b:
						num = 269;
						Globals_Renamed.arSelActType = new short[26, Globals_Renamed.intNumOps + 1];
						goto IL_12b5;
						IL_12b5:
						num = 272;
						Globals_Renamed.arSelActRa = new bool[26, Globals_Renamed.intNumOps + 1];
						goto IL_12cf;
						IL_12cf:
						num = 275;
						Globals_Renamed.arSelActEa = new bool[26, Globals_Renamed.intNumOps + 1];
						goto IL_12e9;
						IL_12e9:
						num = 278;
						Globals_Renamed.arSelActRaDMP = new short[26, Globals_Renamed.intNumOps + 1];
						goto IL_1303;
						IL_1303:
						num = 281;
						Globals_Renamed.arSelActEaDMP = new short[26, Globals_Renamed.intNumOps + 1];
						goto IL_131d;
						IL_131d:
						num = 284;
						Globals_Renamed.arSelActVolatile = new short[26, Globals_Renamed.intNumOps + 1];
						goto IL_1337;
						IL_1337:
						num = 287;
						Globals_Renamed.arActNumWorkers = new long[4, 26, Globals_Renamed.intNumOps + 1];
						goto IL_1352;
						IL_1352:
						num = 290;
						Globals_Renamed.arActNW_Route = new string[26, Globals_Renamed.intNumOps + 1];
						goto IL_136c;
						IL_136c:
						num = 293;
						Globals_Renamed.arActOrder = new short[26, Globals_Renamed.intNumOps + 1];
						goto IL_1386;
						IL_1386:
						num = 296;
						recordset.Open("SELECT * FROM Activities WHERE AssessID=" + Conversions.ToString(unchecked((int)Globals_Renamed.gblAssessID)), Common.DataConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
						goto IL_195e;
						IL_195e:
						num = 298;
						if (!recordset.EOF)
						{
							goto IL_13b5;
						}
						goto IL_1977;
						IL_1977:
						num = 320;
						recordset.Close();
						goto IL_1985;
						IL_1985:
						num = 321;
						Globals_Renamed.arSubOpID = new short[11, Globals_Renamed.intNumOps + 1];
						goto IL_199f;
						IL_199f:
						num = 324;
						Globals_Renamed.arSubPVf = new float[11, Globals_Renamed.intNumOps + 1];
						goto IL_19b9;
						IL_19b9:
						num = 327;
						Globals_Renamed.arSubPvOp = new double[11, Globals_Renamed.intNumOps + 1];
						goto IL_19d3;
						IL_19d3:
						num = 330;
						recordset.Open("SELECT * FROM OpRel WHERE AssessID=" + Conversions.ToString(unchecked((int)Globals_Renamed.gblAssessID)), Common.DataConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
						goto IL_1b4c;
						IL_1b4c:
						num = 332;
						if (!recordset.EOF)
						{
							goto IL_1a02;
						}
						goto IL_1b65;
						IL_1b65:
						num = 338;
						recordset.Close();
						goto IL_1b73;
						IL_1b73:
						num = 339;
						Globals_Renamed.arOpParms = new float[163, Globals_Renamed.intNumOps + 1];
						goto IL_1b90;
						IL_1b90:
						num = 342;
						Globals_Renamed.arOpParmsType = new short[163, Globals_Renamed.intNumOps + 1];
						goto IL_1bad;
						IL_1bad:
						num = 345;
						Globals_Renamed.arOpSP = (float[,])Utils.CopyArray((Array)Globals_Renamed.arOpSP, (Array)new float[49, Globals_Renamed.intNumOps + 1]);
						goto IL_1bdb;
						IL_1bdb:
						num = 348;
						Globals_Renamed.arOpSPType = (short[,])Utils.CopyArray((Array)Globals_Renamed.arOpSPType, (Array)new short[49, Globals_Renamed.intNumOps + 1]);
						goto IL_1c09;
						IL_1c09:
						num = 351;
						recordset.Open("SELECT * FROM OpParms WHERE AssessID=" + Conversions.ToString(unchecked((int)Globals_Renamed.gblAssessID)), Common.DataConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
						goto IL_1e4c;
						IL_1e4c:
						num = 353;
						if (!recordset.EOF)
						{
							goto IL_1c38;
						}
						goto IL_1e65;
						IL_1e65:
						num = 364;
						recordset.Close();
						goto IL_1e73;
						IL_1e73:
						num = 365;
						Globals_Renamed.arContParms = new float[16, 26, Globals_Renamed.intNumOps + 1];
						goto IL_1e8f;
						IL_1e8f:
						num = 368;
						Globals_Renamed.arContParmTypes = new short[16, 26, Globals_Renamed.intNumOps + 1];
						goto IL_1eab;
						IL_1eab:
						num = 371;
						recordset.Open("SELECT * FROM ActContParms WHERE AssessID=" + Conversions.ToString(unchecked((int)Globals_Renamed.gblAssessID)), Common.DataConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
						goto IL_1fef;
						IL_1fef:
						num = 373;
						if (!recordset.EOF)
						{
							goto IL_1eda;
						}
						goto IL_2008;
						IL_2008:
						num = 378;
						recordset.Close();
						goto IL_2016;
						IL_2016:
						num = 379;
						Globals_Renamed.arGssOptions = (short[,])Utils.CopyArray((Array)Globals_Renamed.arGssOptions, (Array)new short[163, Globals_Renamed.intNumOps + 1]);
						goto IL_2047;
						IL_2047:
						num = 382;
						Globals_Renamed.arGssOther = (string[,])Utils.CopyArray((Array)Globals_Renamed.arGssOther, (Array)new string[163, Globals_Renamed.intNumOps + 1]);
						goto IL_2078;
						IL_2078:
						num = 385;
						recordset.Open("SELECT * FROM GSSOptions WHERE AssessID=" + Conversions.ToString(unchecked((int)Globals_Renamed.gblAssessID)), Common.DataConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
						goto IL_2183;
						IL_2183:
						num = 387;
						if (!recordset.EOF)
						{
							goto IL_20a7;
						}
						goto IL_219c;
						IL_219c:
						num = 392;
						recordset.Close();
						goto IL_21aa;
						IL_21aa:
						num = 393;
						recordset = null;
						goto IL_21b3;
						IL_21b3:
						num = 394;
						recordset2 = null;
						goto IL_21bc;
						IL_21bc:
						num = 395;
						frmMain.DefInstance.LoadLstSelOps();
						goto IL_21ce;
						IL_21ce:
						num = 396;
						flag = true;
						goto end_IL_0001_2;
						IL_20a7:
						num = 388;
						Globals_Renamed.arGssOptions[Conversions.ToInteger(recordset.Fields["ParmID"].Value), Conversions.ToInteger(recordset.Fields["AssOpID"].Value)] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["OptionValue"].Value)));
						goto IL_2110;
						IL_2110:
						num = 389;
						Globals_Renamed.arGssOther[Conversions.ToInteger(recordset.Fields["ParmID"].Value), Conversions.ToInteger(recordset.Fields["AssOpID"].Value)] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["Other"].Value));
						goto IL_2174;
						IL_2174:
						num = 390;
						recordset.MoveNext();
						goto IL_2183;
						IL_1eda:
						num = 374;
						Globals_Renamed.arContParms[Conversions.ToInteger(recordset.Fields["ParmID"].Value), Conversions.ToInteger(recordset.Fields["AssActID"].Value), Conversions.ToInteger(recordset.Fields["AssOpID"].Value)] = Conversions.ToSingle(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["ParmValue"].Value)));
						goto IL_1f5d;
						IL_1f5d:
						num = 375;
						Globals_Renamed.arContParmTypes[Conversions.ToInteger(recordset.Fields["ParmID"].Value), Conversions.ToInteger(recordset.Fields["AssActID"].Value), Conversions.ToInteger(recordset.Fields["AssOpID"].Value)] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["ParmType"].Value)));
						goto IL_1fe0;
						IL_1fe0:
						num = 376;
						recordset.MoveNext();
						goto IL_1fef;
						IL_1c38:
						num = 354;
						if (Operators.ConditionalCompareObjectLess(recordset.Fields["ParmID"].Value, (object)1000, false))
						{
							goto IL_1c6d;
						}
						goto IL_1d44;
						IL_1c6d:
						num = 355;
						Globals_Renamed.arOpParms[Conversions.ToInteger(recordset.Fields["ParmID"].Value), Conversions.ToInteger(recordset.Fields["AssOpID"].Value)] = Conversions.ToSingle(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["ParmValue"].Value)));
						goto IL_1cd6;
						IL_1cd6:
						num = 356;
						Globals_Renamed.arOpParmsType[Conversions.ToInteger(recordset.Fields["ParmID"].Value), Conversions.ToInteger(recordset.Fields["AssOpID"].Value)] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["ParmType"].Value)));
						goto IL_1e3d;
						IL_1d44:
						num = 358;
						goto IL_1d4c;
						IL_1d4c:
						num = 359;
						Globals_Renamed.arOpSP[Conversions.ToInteger(Operators.SubtractObject(recordset.Fields["ParmID"].Value, (object)1000)), Conversions.ToInteger(recordset.Fields["AssOpID"].Value)] = Conversions.ToSingle(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["ParmValue"].Value)));
						goto IL_1dc4;
						IL_1dc4:
						num = 360;
						Globals_Renamed.arOpSPType[Conversions.ToInteger(Operators.SubtractObject(recordset.Fields["ParmID"].Value, (object)1000)), Conversions.ToInteger(recordset.Fields["AssOpID"].Value)] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["ParmType"].Value)));
						goto IL_1e3d;
						IL_1e3d:
						num = 362;
						recordset.MoveNext();
						goto IL_1e4c;
						IL_1a02:
						num = 333;
						Globals_Renamed.arSubOpID[Conversions.ToInteger(recordset.Fields["RelID"].Value), Conversions.ToInteger(recordset.Fields["AssOpID"].Value)] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["Child"].Value)));
						goto IL_1a6b;
						IL_1a6b:
						num = 334;
						Globals_Renamed.arSubPVf[Conversions.ToInteger(recordset.Fields["RelID"].Value), Conversions.ToInteger(recordset.Fields["AssOpID"].Value)] = Conversions.ToSingle(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["ChildPVf"].Value)));
						goto IL_1ad4;
						IL_1ad4:
						num = 335;
						Globals_Renamed.arSubPvOp[Conversions.ToInteger(recordset.Fields["RelID"].Value), Conversions.ToInteger(recordset.Fields["AssOpID"].Value)] = Conversions.ToDouble(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["ChildPVop"].Value)));
						goto IL_1b3d;
						IL_1b3d:
						num = 336;
						recordset.MoveNext();
						goto IL_1b4c;
						IL_13b5:
						num = 299;
						Globals_Renamed.arSelActs[Conversions.ToInteger(recordset.Fields["AssActID"].Value), Conversions.ToInteger(recordset.Fields["AssOpID"].Value)] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["ActName"].Value));
						goto IL_1419;
						IL_1419:
						num = 300;
						Globals_Renamed.arSelActType[Conversions.ToInteger(recordset.Fields["AssActID"].Value), Conversions.ToInteger(recordset.Fields["AssOpID"].Value)] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["ActID"].Value)));
						goto IL_1482;
						IL_1482:
						num = 301;
						Globals_Renamed.arSelActRa[Conversions.ToInteger(recordset.Fields["AssActID"].Value), Conversions.ToInteger(recordset.Fields["AssOpID"].Value)] = Conversions.ToBoolean(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["DoRel"].Value)));
						goto IL_14eb;
						IL_14eb:
						num = 302;
						Globals_Renamed.arSelActEa[Conversions.ToInteger(recordset.Fields["AssActID"].Value), Conversions.ToInteger(recordset.Fields["AssOpID"].Value)] = Conversions.ToBoolean(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["DoExp"].Value)));
						goto IL_1554;
						IL_1554:
						num = 303;
						Globals_Renamed.arSelActRaDMP[Conversions.ToInteger(recordset.Fields["AssActID"].Value), Conversions.ToInteger(recordset.Fields["AssOpID"].Value)] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["DidRel"].Value)));
						goto IL_15bd;
						IL_15bd:
						num = 304;
						Globals_Renamed.arSelActEaDMP[Conversions.ToInteger(recordset.Fields["AssActID"].Value), Conversions.ToInteger(recordset.Fields["AssOpID"].Value)] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["DidExp"].Value)));
						goto IL_1626;
						IL_1626:
						num = 305;
						Globals_Renamed.arSelActVolatile[Conversions.ToInteger(recordset.Fields["AssActID"].Value), Conversions.ToInteger(recordset.Fields["AssOpID"].Value)] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["Volatile"].Value)));
						goto IL_168f;
						IL_168f:
						num = 306;
						if (Globals_Renamed.gblDataVersion >= 9)
						{
							goto IL_16ab;
						}
						goto IL_184e;
						IL_16ab:
						num = 307;
						Globals_Renamed.arActNumWorkers[0, Conversions.ToInteger(recordset.Fields["AssActID"].Value), Conversions.ToInteger(recordset.Fields["AssOpID"].Value)] = Conversions.ToLong(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["NW_NS"].Value)));
						goto IL_1715;
						IL_1715:
						num = 308;
						Globals_Renamed.arActNumWorkers[1, Conversions.ToInteger(recordset.Fields["AssActID"].Value), Conversions.ToInteger(recordset.Fields["AssOpID"].Value)] = Conversions.ToLong(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["NW_NWexp"].Value)));
						goto IL_177f;
						IL_177f:
						num = 309;
						Globals_Renamed.arActNumWorkers[2, Conversions.ToInteger(recordset.Fields["AssActID"].Value), Conversions.ToInteger(recordset.Fields["AssOpID"].Value)] = Conversions.ToLong(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["NW_NSxNWexp"].Value)));
						goto IL_17e9;
						IL_17e9:
						num = 310;
						Globals_Renamed.arActNW_Route[Conversions.ToInteger(recordset.Fields["AssActID"].Value), Conversions.ToInteger(recordset.Fields["AssOpID"].Value)] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["NW_Route"].Value));
						goto IL_184e;
						IL_184e:
						num = 312;
						if (Globals_Renamed.gblDataVersion >= 11)
						{
							goto IL_1867;
						}
						goto IL_18d2;
						IL_1867:
						num = 313;
						Globals_Renamed.arActOrder[Conversions.ToInteger(recordset.Fields["AssActID"].Value), Conversions.ToInteger(recordset.Fields["AssOpID"].Value)] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["ActOrder"].Value)));
						goto IL_194f;
						IL_18d2:
						num = 315;
						goto IL_18da;
						IL_18da:
						num = 316;
						Globals_Renamed.arActOrder[Conversions.ToInteger(recordset.Fields["AssActID"].Value), Conversions.ToInteger(recordset.Fields["AssOpID"].Value)] = Conversions.ToShort(Operators.AddObject(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["AssActID"].Value)), (object)1));
						goto IL_194f;
						IL_194f:
						num = 318;
						recordset.MoveNext();
						goto IL_195e;
						IL_0ff3:
						num = 257;
						Globals_Renamed.arOSName[Conversions.ToInteger(recordset.Fields["FacID"].Value), Conversions.ToInteger(recordset.Fields["AssOpID"].Value)] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["FacName"].Value));
						goto IL_1057;
						IL_1057:
						num = 258;
						Globals_Renamed.arOSAddr[Conversions.ToInteger(recordset.Fields["FacID"].Value), Conversions.ToInteger(recordset.Fields["AssOpID"].Value)] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["FacAddr1"].Value));
						goto IL_10bb;
						IL_10bb:
						num = 259;
						Globals_Renamed.arOSCity[Conversions.ToInteger(recordset.Fields["FacID"].Value), Conversions.ToInteger(recordset.Fields["AssOpID"].Value)] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["FacCity"].Value));
						goto IL_111f;
						IL_111f:
						num = 260;
						Globals_Renamed.arOSState[Conversions.ToInteger(recordset.Fields["FacID"].Value), Conversions.ToInteger(recordset.Fields["AssOpID"].Value)] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["FacState"].Value));
						goto IL_1183;
						IL_1183:
						num = 261;
						Globals_Renamed.arOSZip[Conversions.ToInteger(recordset.Fields["FacID"].Value), Conversions.ToInteger(recordset.Fields["AssOpID"].Value)] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["FacZip"].Value));
						goto IL_11e7;
						IL_11e7:
						num = 262;
						Globals_Renamed.arOSCty[Conversions.ToInteger(recordset.Fields["FacID"].Value), Conversions.ToInteger(recordset.Fields["AssOpID"].Value)] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["FacCounty"].Value));
						goto IL_124b;
						IL_124b:
						num = 263;
						recordset.MoveNext();
						goto IL_125a;
						IL_0d63:
						num = 223;
						Globals_Renamed.arNaics1[Conversions.ToInteger(recordset.Fields["NaicsIndex"].Value), Conversions.ToInteger(recordset.Fields["AssOpID"].Value)] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["NAICS"].Value));
						goto IL_0dc7;
						IL_0dc7:
						num = 224;
						recordset2.MoveFirst();
						goto IL_0dd5;
						IL_0dd5:
						num = 225;
						recordset2.Find(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"naics='", recordset.Fields["NAICS"].Value), (object)"'")), 0, SearchDirectionEnum.adSearchForward, Missing.Value);
						goto IL_0e18;
						IL_0e18:
						num = 226;
						if (recordset2.EOF)
						{
							goto IL_0e2b;
						}
						goto IL_0e77;
						IL_0e2b:
						num = 227;
						Globals_Renamed.arNaics2[Conversions.ToInteger(recordset.Fields["NaicsIndex"].Value), Conversions.ToInteger(recordset.Fields["AssOpID"].Value)] = "Error - Not found";
						goto IL_0ee4;
						IL_0e77:
						num = 229;
						goto IL_0e7f;
						IL_0e7f:
						num = 230;
						Globals_Renamed.arNaics2[Conversions.ToInteger(recordset.Fields["NaicsIndex"].Value), Conversions.ToInteger(recordset.Fields["AssOpID"].Value)] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["NaicsDesc"].Value));
						goto IL_0ee4;
						IL_0ee4:
						num = 232;
						recordset.MoveNext();
						goto IL_0ef3;
						IL_021b:
						num = 87;
						Globals_Renamed.arOpPv = (double[])Utils.CopyArray((Array)Globals_Renamed.arOpPv, (Array)new double[num4 + 1 + 1]);
						goto IL_0242;
						IL_0242:
						num = 90;
						Globals_Renamed.arPDesc = (string[])Utils.CopyArray((Array)Globals_Renamed.arPDesc, (Array)new string[num4 + 1 + 1]);
						goto IL_0269;
						IL_0269:
						num = 93;
						Globals_Renamed.arBasis = (string[])Utils.CopyArray((Array)Globals_Renamed.arBasis, (Array)new string[num4 + 1 + 1]);
						goto IL_0290;
						IL_0290:
						num = 96;
						Globals_Renamed.arWaterBasis = (string[])Utils.CopyArray((Array)Globals_Renamed.arWaterBasis, (Array)new string[num4 + 1 + 1]);
						goto IL_02b7;
						IL_02b7:
						num = 99;
						Globals_Renamed.arRelAddNotes = (string[])Utils.CopyArray((Array)Globals_Renamed.arRelAddNotes, (Array)new string[num4 + 1 + 1]);
						goto IL_02de;
						IL_02de:
						num = 102;
						Globals_Renamed.arExpAddNotes = (string[])Utils.CopyArray((Array)Globals_Renamed.arExpAddNotes, (Array)new string[num4 + 1 + 1]);
						goto IL_0305;
						IL_0305:
						num = 105;
						Globals_Renamed.arOpNumWorkers = (long[,])Utils.CopyArray((Array)Globals_Renamed.arOpNumWorkers, (Array)new long[3, num4 + 1 + 1]);
						goto IL_032d;
						IL_032d:
						num = 108;
						Globals_Renamed.arOpNumWorkersBasis = (string[])Utils.CopyArray((Array)Globals_Renamed.arOpNumWorkersBasis, (Array)new string[num4 + 1 + 1]);
						goto IL_0354;
						IL_0354:
						num = 111;
						Globals_Renamed.arOpNumWorkersBasisEnabled = (short[])Utils.CopyArray((Array)Globals_Renamed.arOpNumWorkersBasisEnabled, (Array)new short[num4 + 1 + 1]);
						goto IL_037b;
						IL_037b:
						num = 114;
						Globals_Renamed.arInhalationBasis = (string[])Utils.CopyArray((Array)Globals_Renamed.arInhalationBasis, (Array)new string[num4 + 1 + 1]);
						goto IL_03a2;
						IL_03a2:
						num = 117;
						Globals_Renamed.arDermalBasis = (string[])Utils.CopyArray((Array)Globals_Renamed.arDermalBasis, (Array)new string[num4 + 1 + 1]);
						goto IL_03c9;
						IL_03c9:
						num = 120;
						Globals_Renamed.arPSInto1 = (string[])Utils.CopyArray((Array)Globals_Renamed.arPSInto1, (Array)new string[num4 + 1 + 1]);
						goto IL_03f0;
						IL_03f0:
						num = 123;
						Globals_Renamed.arPSInto2 = (string[])Utils.CopyArray((Array)Globals_Renamed.arPSInto2, (Array)new string[num4 + 1 + 1]);
						goto IL_0417;
						IL_0417:
						num = 126;
						Globals_Renamed.arPSOut1 = (string[])Utils.CopyArray((Array)Globals_Renamed.arPSOut1, (Array)new string[num4 + 1 + 1]);
						goto IL_043e;
						IL_043e:
						num = 129;
						Globals_Renamed.arPSOut2 = (string[])Utils.CopyArray((Array)Globals_Renamed.arPSOut2, (Array)new string[num4 + 1 + 1]);
						goto IL_0468;
						IL_0468:
						num = 132;
						Globals_Renamed.arPSIn1 = (string[])Utils.CopyArray((Array)Globals_Renamed.arPSIn1, (Array)new string[num4 + 1 + 1]);
						goto IL_0492;
						IL_0492:
						num = 135;
						Globals_Renamed.arPSIn2 = (string[])Utils.CopyArray((Array)Globals_Renamed.arPSIn2, (Array)new string[num4 + 1 + 1]);
						goto IL_04bc;
						IL_04bc:
						num = 138;
						Globals_Renamed.arNoPre = (bool[])Utils.CopyArray((Array)Globals_Renamed.arNoPre, (Array)new bool[num4 + 1 + 1]);
						goto IL_04e6;
						IL_04e6:
						num = 141;
						Globals_Renamed.arOpBorC = (short[])Utils.CopyArray((Array)Globals_Renamed.arOpBorC, (Array)new short[num4 + 1 + 1]);
						goto IL_0510;
						IL_0510:
						num = 144;
						Globals_Renamed.arOpIoE = (short[])Utils.CopyArray((Array)Globals_Renamed.arOpIoE, (Array)new short[num4 + 1 + 1]);
						goto IL_053a;
						IL_053a:
						num = 147;
						Globals_Renamed.arOpMassBalDisc = (int[,])Utils.CopyArray((Array)Globals_Renamed.arOpMassBalDisc, (Array)new int[3, num4 + 1 + 1]);
						goto IL_0565;
						IL_0565:
						num = 150;
						Globals_Renamed.arMiscOpParms = (float[,])Utils.CopyArray((Array)Globals_Renamed.arMiscOpParms, (Array)new float[3, num4 + 1 + 1]);
						goto IL_0590;
						IL_0590:
						num = 153;
						Globals_Renamed.arOpType = (short[])Utils.CopyArray((Array)Globals_Renamed.arOpType, (Array)new short[num4 + 1 + 1]);
						goto IL_05ba;
						IL_05ba:
						num = 156;
						Globals_Renamed.arOpOrder = (short[])Utils.CopyArray((Array)Globals_Renamed.arOpOrder, (Array)new short[num4 + 1 + 1]);
						goto IL_05e4;
						IL_05e4:
						num = 159;
						Globals_Renamed.arOpName = (string[])Utils.CopyArray((Array)Globals_Renamed.arOpName, (Array)new string[num4 + 1 + 1]);
						goto IL_060e;
						IL_060e:
						num = 162;
						Globals_Renamed.arOpNeedsMassBalance = (short[])Utils.CopyArray((Array)Globals_Renamed.arOpNeedsMassBalance, (Array)new short[num4 + 1 + 1]);
						goto IL_0638;
						IL_0638:
						num = 165;
						Globals_Renamed.arOpPv[num4] = Conversions.ToDouble(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["PVop"].Value)));
						goto IL_066a;
						IL_066a:
						num = 166;
						Globals_Renamed.arPDesc[num4] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["ProcessDesc"].Value));
						goto IL_0698;
						IL_0698:
						num = 167;
						Globals_Renamed.arPSInto1[num4] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["PSInto"].Value));
						goto IL_06c6;
						IL_06c6:
						num = 168;
						Globals_Renamed.arPSInto2[num4] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["PSIntoOther"].Value));
						goto IL_06f4;
						IL_06f4:
						num = 169;
						Globals_Renamed.arPSOut1[num4] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["PSOut"].Value));
						goto IL_0722;
						IL_0722:
						num = 170;
						Globals_Renamed.arPSOut2[num4] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["PSOutOther"].Value));
						goto IL_0750;
						IL_0750:
						num = 171;
						Globals_Renamed.arPSIn1[num4] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["PSIn"].Value));
						goto IL_077e;
						IL_077e:
						num = 172;
						Globals_Renamed.arPSIn2[num4] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["PSInOther"].Value));
						goto IL_07ac;
						IL_07ac:
						num = 173;
						Globals_Renamed.arNoPre[num4] = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["NoPrev"].Value)), (object)false, RuntimeHelpers.GetObjectValue(recordset.Fields["NoPrev"].Value)));
						goto IL_0803;
						IL_0803:
						num = 174;
						Globals_Renamed.arOpBorC[num4] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["OpType"].Value)));
						goto IL_0835;
						IL_0835:
						num = 175;
						Globals_Renamed.arOpIoE[num4] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["IoE"].Value)));
						goto IL_0867;
						IL_0867:
						num = 176;
						Globals_Renamed.arOpName[num4] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["OpName"].Value));
						goto IL_0895;
						IL_0895:
						num = 177;
						Globals_Renamed.arOpType[num4] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["OpID"].Value)));
						goto IL_08c7;
						IL_08c7:
						num = 178;
						Globals_Renamed.arOpMassBalDisc[0, num4] = Conversions.ToInteger(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["MassBalDisc1"].Value)));
						goto IL_08fe;
						IL_08fe:
						num = 179;
						Globals_Renamed.arOpMassBalDisc[1, num4] = Conversions.ToInteger(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["MassBalDisc2"].Value)));
						goto IL_0935;
						IL_0935:
						num = 180;
						Globals_Renamed.arMiscOpParms[0, num4] = Conversions.ToSingle(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["OpNumWorkers"].Value)));
						goto IL_096c;
						IL_096c:
						num = 181;
						Globals_Renamed.arMiscOpParms[1, num4] = Conversions.ToSingle(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["NumWorkersExpDaysPerYear"].Value)));
						goto IL_09a3;
						IL_09a3:
						num = 182;
						Globals_Renamed.arBasis[num4] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["Basis"].Value));
						goto IL_09d1;
						IL_09d1:
						num = 183;
						if (Globals_Renamed.gblDataVersion >= 5)
						{
							goto IL_09ec;
						}
						goto IL_0b08;
						IL_09ec:
						num = 184;
						Globals_Renamed.arWaterBasis[num4] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["WaterRelBasis"].Value));
						goto IL_0a1a;
						IL_0a1a:
						num = 185;
						Globals_Renamed.arInhalationBasis[num4] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["InhExpBasis"].Value));
						goto IL_0a48;
						IL_0a48:
						num = 186;
						if (Globals_Renamed.gblDataVersion >= 6)
						{
							goto IL_0a63;
						}
						goto IL_0b08;
						IL_0a63:
						num = 187;
						Globals_Renamed.arRelAddNotes[num4] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["AddNotesRelSummary"].Value));
						goto IL_0a91;
						IL_0a91:
						num = 188;
						Globals_Renamed.arExpAddNotes[num4] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["AddNotesExpSummary"].Value));
						goto IL_0abf;
						IL_0abf:
						num = 189;
						if (Globals_Renamed.gblDataVersion >= 8)
						{
							goto IL_0ad7;
						}
						goto IL_0b08;
						IL_0ad7:
						num = 190;
						Globals_Renamed.arDermalBasis[num4] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["DerExpBasis"].Value));
						goto IL_0b08;
						IL_0b08:
						num = 194;
						if (Globals_Renamed.gblDataVersion >= 9)
						{
							goto IL_0b24;
						}
						goto IL_0c26;
						IL_0b24:
						num = 195;
						Globals_Renamed.arOpOrder[num4] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["OpOrder"].Value)));
						goto IL_0b56;
						IL_0b56:
						num = 196;
						Globals_Renamed.arOpNumWorkers[0, num4] = Conversions.ToLong(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["NWdefault"].Value)));
						goto IL_0b8d;
						IL_0b8d:
						num = 197;
						Globals_Renamed.arOpNumWorkers[1, num4] = Conversions.ToLong(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["NWestimated"].Value)));
						goto IL_0bc4;
						IL_0bc4:
						num = 198;
						Globals_Renamed.arOpNumWorkersBasis[num4] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["NWbasis"].Value));
						goto IL_0bf2;
						IL_0bf2:
						num = 199;
						Globals_Renamed.arOpNumWorkersBasisEnabled[num4] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["NWbasisEnabled"].Value)));
						goto IL_0c3e;
						IL_0c26:
						num = 201;
						goto IL_0c2e;
						IL_0c2e:
						num = 202;
						Globals_Renamed.arOpOrder[num4] = num4;
						goto IL_0c3e;
						end_IL_0001:
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 10419;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_2:
			break;
		}
		bool result = flag;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private static bool Open_Chemicals()
	{
		int try0001_dispatch = -1;
		int num = default(int);
		Recordset recordset = default(Recordset);
		int num2 = default(int);
		int num3 = default(int);
		frmMain frmMain2 = default(frmMain);
		bool flag = default(bool);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				string Eobject;
				string Efunction;
				ErrObject val;
				int Enumber;
				ErrObject val2;
				string Edescription;
				bool Econtact;
				int num4;
				switch (try0001_dispatch)
				{
				default:
				{
					num = 1;
					Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
					recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					goto IL_0022;
				}
				case 3007:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 2:
							break;
						case 1:
							goto IL_0ab5;
						default:
							goto end_IL_0001;
						}
						goto IL_0a39;
					}
					IL_0a1a:
					num = 56;
					recordset.Close();
					goto IL_0a25;
					IL_0a25:
					num = 57;
					recordset = null;
					goto IL_0a2b;
					IL_0a16:
					frmMain2 = null;
					goto IL_0a1a;
					IL_0a39:
					num = 60;
					Eobject = "DBFuncs.Bas";
					Efunction = "Open_Chemicals";
					val = Information.Err();
					Enumber = val.Number;
					val2 = Information.Err();
					Edescription = val2.Description;
					Econtact = true;
					Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
					val2.Description = Edescription;
					val.Number = Enumber;
					goto IL_0a92;
					IL_0a92:
					num = 61;
					ProjectData.ClearProjectError();
					if (num2 == 0)
					{
						throw ProjectData.CreateProjectError(-2146828268);
					}
					goto IL_0ab5;
					IL_0a2b:
					num = 58;
					flag = true;
					goto end_IL_0001_2;
					IL_0ab5:
					num4 = num2 + 1;
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
						goto IL_005b;
					case 6:
						goto IL_0070;
					case 7:
						goto IL_007a;
					case 8:
						goto IL_00a9;
					case 9:
						goto IL_00d8;
					case 10:
						goto IL_0108;
					case 11:
						goto IL_0138;
					case 12:
						goto IL_0168;
					case 13:
						goto IL_01c1;
					case 14:
						goto IL_021a;
					case 15:
						goto IL_0273;
					case 16:
						goto IL_02cc;
					case 17:
						goto IL_0325;
					case 18:
						goto IL_037e;
					case 19:
						goto IL_03d7;
					case 20:
						goto IL_0430;
					case 21:
						goto IL_0460;
					case 22:
						goto IL_049f;
					case 24:
						goto IL_04b3;
					case 25:
						goto IL_04b8;
					case 23:
					case 26:
					case 27:
						goto IL_04cb;
					case 28:
						goto IL_0529;
					case 29:
						goto IL_054c;
					case 30:
						goto IL_056f;
					case 31:
						goto IL_05cd;
					case 32:
						goto IL_062b;
					case 33:
						goto IL_065b;
					case 34:
						goto IL_06b9;
					case 35:
						goto IL_0717;
					case 36:
						goto IL_072c;
					case 38:
						goto IL_075e;
					case 39:
						goto IL_0763;
					case 37:
					case 40:
					case 41:
						goto IL_0794;
					case 42:
						goto IL_07ac;
					case 43:
						goto IL_07fc;
					case 44:
						goto IL_084c;
					case 45:
						goto IL_089c;
					case 46:
						goto IL_08ec;
					case 47:
						goto IL_091c;
					case 48:
					case 49:
						goto IL_096d;
					case 50:
						goto IL_0985;
					case 51:
						goto IL_09b5;
					case 52:
						goto IL_09e5;
					case 53:
					case 54:
						goto IL_0a16;
					case 55:
					case 56:
						goto IL_0a1a;
					case 57:
						goto IL_0a25;
					case 58:
						goto IL_0a2b;
					case 60:
						goto IL_0a39;
					case 61:
						goto IL_0a92;
					default:
						goto end_IL_0001;
					case 59:
					case 62:
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
					IL_0035:
					num = 4;
					recordset.Open("SELECT * FROM Chemicals WHERE AssessID=" + Conversions.ToString((int)Globals_Renamed.gblAssessID), Common.DataConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
					goto IL_005b;
					IL_005b:
					num = 5;
					if (!recordset.EOF)
					{
						goto IL_0070;
					}
					goto IL_0a1a;
					IL_0070:
					num = 6;
					frmMain2 = frmMain.DefInstance;
					goto IL_007a;
					IL_007a:
					num = 7;
					frmMain2.lblChemName.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["ChemicalName"].Value));
					goto IL_00a9;
					IL_00a9:
					num = 8;
					frmMain2.lblCas.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["CASNumber"].Value));
					goto IL_00d8;
					IL_00d8:
					num = 9;
					frmMain2.lblChemCat.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["ChemCat"].Value));
					goto IL_0108;
					IL_0108:
					num = 10;
					frmMain2.lblTradeNames.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["TradeNames"].Value));
					goto IL_0138;
					IL_0138:
					num = 11;
					frmMain2.lblMF.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["MolFormula"].Value));
					goto IL_0168;
					IL_0168:
					num = 12;
					frmMain2.lblPVi.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["PVi"].Value)), (object)"", RuntimeHelpers.GetObjectValue(recordset.Fields["PVi"].Value)));
					goto IL_01c1;
					IL_01c1:
					num = 13;
					frmMain2.lblPVd.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["PVd"].Value)), (object)"", RuntimeHelpers.GetObjectValue(recordset.Fields["PVd"].Value)));
					goto IL_021a;
					IL_021a:
					num = 14;
					frmMain2.lblPV.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["PV"].Value)), (object)"", RuntimeHelpers.GetObjectValue(recordset.Fields["PV"].Value)));
					goto IL_0273;
					IL_0273:
					num = 15;
					frmMain2.lblVP.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["VP"].Value)), (object)"", RuntimeHelpers.GetObjectValue(recordset.Fields["VP"].Value)));
					goto IL_02cc;
					IL_02cc:
					num = 16;
					frmMain2.lblVPTemp.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["VPTemp"].Value)), (object)"", RuntimeHelpers.GetObjectValue(recordset.Fields["VPTemp"].Value)));
					goto IL_0325;
					IL_0325:
					num = 17;
					frmMain2.lblMW.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["mw"].Value)), (object)"", RuntimeHelpers.GetObjectValue(recordset.Fields["mw"].Value)));
					goto IL_037e;
					IL_037e:
					num = 18;
					frmMain2.lblDchem.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["DChem"].Value)), (object)"0", RuntimeHelpers.GetObjectValue(recordset.Fields["DChem"].Value)));
					goto IL_03d7;
					IL_03d7:
					num = 19;
					frmMain2.lblDchemTemp.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["DChemTemp"].Value)), (object)"", RuntimeHelpers.GetObjectValue(recordset.Fields["DChemTemp"].Value)));
					goto IL_0430;
					IL_0430:
					num = 20;
					frmMain2.lblSol.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["Solubility"].Value));
					goto IL_0460;
					IL_0460:
					num = 21;
					if ((Operators.CompareString(frmMain2.lblSol.Text, "Dispersible", false) == 0) | (Operators.CompareString(frmMain2.lblSol.Text, "Reacts", false) == 0))
					{
						goto IL_049f;
					}
					goto IL_04b3;
					IL_049f:
					num = 22;
					((Control)frmMain2.lblSolTemp).Visible = false;
					goto IL_04cb;
					IL_04b3:
					num = 24;
					goto IL_04b8;
					IL_04b8:
					num = 25;
					((Control)frmMain2.lblSolTemp).Visible = true;
					goto IL_04cb;
					IL_04cb:
					num = 27;
					frmMain2.lblSolTemp.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["SolTemp"].Value)), (object)"", (object)Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["SolTemp"].Value))));
					goto IL_0529;
					IL_0529:
					num = 28;
					((Control)frmMain2.Label2[(short)3]).Visible = ((Control)frmMain2.lblSolTemp).Visible;
					goto IL_054c;
					IL_054c:
					num = 29;
					((Control)frmMain2.Label2[(short)5]).Visible = ((Control)frmMain2.lblSolTemp).Visible;
					goto IL_056f;
					IL_056f:
					num = 30;
					frmMain2.lblMP.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["MP"].Value)), (object)"", (object)Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["MP"].Value))));
					goto IL_05cd;
					IL_05cd:
					num = 31;
					frmMain2.lblBP.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["BP"].Value)), (object)"", (object)Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["BP"].Value))));
					goto IL_062b;
					IL_062b:
					num = 32;
					frmMain2.lblNoticeType.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["TypeOfNotice"].Value));
					goto IL_065b;
					IL_065b:
					num = 33;
					frmMain2.lblLT500.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["Lt500"].Value)), (object)"", (object)Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["Lt500"].Value))));
					goto IL_06b9;
					IL_06b9:
					num = 34;
					frmMain2.lblLT1000.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["Lt1000"].Value)), (object)"", (object)Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["Lt1000"].Value))));
					goto IL_0717;
					IL_0717:
					num = 35;
					if (Globals_Renamed.gblDataVersion >= 5)
					{
						goto IL_072c;
					}
					goto IL_075e;
					IL_072c:
					num = 36;
					frmMain2.txtChemGenUse.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["EndUseMemo"].Value));
					goto IL_0794;
					IL_075e:
					num = 38;
					goto IL_0763;
					IL_0763:
					num = 39;
					frmMain2.txtChemGenUse.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["EndUse"].Value));
					goto IL_0794;
					IL_0794:
					num = 41;
					if (Globals_Renamed.gblDataVersion >= 5)
					{
						goto IL_07ac;
					}
					goto IL_096d;
					IL_07ac:
					num = 42;
					frmMain2.lblChemQualYX.Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["QualifierYX"].Value)), (object)1, false), (object)"Yes", (object)"No"));
					goto IL_07fc;
					IL_07fc:
					num = 43;
					frmMain2.lblChemQualNX.Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["QualifierNX"].Value)), (object)1, false), (object)"Yes", (object)"No"));
					goto IL_084c;
					IL_084c:
					num = 44;
					frmMain2.lblCOS.Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["QualifierCOS"].Value)), (object)1, false), (object)"Yes", (object)"No"));
					goto IL_089c;
					IL_089c:
					num = 45;
					frmMain2.lblChemQualOther.Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["QualifierOther"].Value)), (object)1, false), (object)"Yes", (object)"No"));
					goto IL_08ec;
					IL_08ec:
					num = 46;
					frmMain2.lblChemQualOtherDesc.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["QualifierOtherDesc"].Value));
					goto IL_091c;
					IL_091c:
					num = 47;
					frmMain2.lblBindingPV.Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["QualifierBindingPV"].Value)), (object)1, false), (object)"Yes", (object)"No"));
					goto IL_096d;
					IL_096d:
					num = 49;
					if (Globals_Renamed.gblDataVersion >= 6)
					{
						goto IL_0985;
					}
					goto IL_0a16;
					IL_0985:
					num = 50;
					frmMain2.lblTotalSubPV.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["SubPV"].Value));
					goto IL_09b5;
					IL_09b5:
					num = 51;
					frmMain2.lblImportedSubPV.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["SubPVi"].Value));
					goto IL_09e5;
					IL_09e5:
					num = 52;
					frmMain2.lblDomesticSubPV.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["SubPVd"].Value));
					goto IL_0a16;
					end_IL_0001:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 3007;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_2:
			break;
		}
		bool result = flag;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private static bool Save_Rel()
	{
		//IL_0894: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
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
					clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
					Recordset recordset2 = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
					Recordset recordset3 = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
					Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					ProjectData.ClearProjectError();
					num2 = 2;
					command.ActiveConnection = Common.DataConn;
					command.CommandText = "pqryDeleteRelModMedia";
					command.CommandType = CommandTypeEnum.adCmdStoredProc;
					command.Parameters.Append(command.CreateParameter("pAssessID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, Globals_Renamed.gblAssessID));
					Command command2 = command;
					object RecordsAffected = Missing.Value;
					object Parameters = Missing.Value;
					command2.Execute(out RecordsAffected, ref Parameters);
					command.Parameters.Delete("pAssessID");
					command.ActiveConnection = Common.DataConn;
					command.CommandText = "pqryDeleteRelModels";
					command.CommandType = CommandTypeEnum.adCmdStoredProc;
					command.Parameters.Append(command.CreateParameter("pAssessID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, Globals_Renamed.gblAssessID));
					Command command3 = command;
					Parameters = Missing.Value;
					RecordsAffected = Missing.Value;
					command3.Execute(out Parameters, ref RecordsAffected);
					command.Parameters.Delete("pAssessID");
					recordset.CursorLocation = CursorLocationEnum.adUseServer;
					recordset.Open("SELECT * FROM ActRelModels WHERE AssessID=" + Conversions.ToString((int)Globals_Renamed.gblAssessID), Common.DataConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
					recordset2.CursorLocation = CursorLocationEnum.adUseServer;
					recordset2.Open("SELECT * FROM ActRelModParms WHERE RelParmsAN=0", Common.DataConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
					recordset3.CursorLocation = CursorLocationEnum.adUseServer;
					recordset3.Open("SELECT * FROM ActRelModMedia WHERE AssessID=" + Conversions.ToString((int)Globals_Renamed.gblAssessID), Common.DataConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
					frmMain defInstance = frmMain.DefInstance;
					checked
					{
						short num3 = (short)(Globals_Renamed.intNumOps - 1);
						short num4 = 0;
						while (true)
						{
							short num5 = num4;
							short num6 = num3;
							if (num5 > num6)
							{
								break;
							}
							short num7 = 0;
							short num22;
							do
							{
								short num8 = 0;
								short num21;
								do
								{
									if ((Globals_Renamed.arSelActType[num7, num4] > 0) & (Globals_Renamed.arRelModels[num8, num7, num4] > 0) & Globals_Renamed.arSelActRa[num7, num4])
									{
										Globals_Renamed.intModIndex = (short)(Globals_Renamed.arRelModels[num8, num7, num4] - 1);
										recordset.AddNew(Missing.Value, Missing.Value);
										recordset.Fields["AssessID"].Value = Globals_Renamed.gblAssessID;
										recordset.Fields["AssOpID"].Value = num4;
										recordset.Fields["AssActID"].Value = num7;
										recordset.Fields["RelModID"].Value = num8;
										recordset.Fields["ModelID"].Value = Globals_Renamed.arRelModType[Globals_Renamed.intModIndex];
										int num9 = Conversions.ToInteger(recordset.Fields["RelParmsAN"].Value);
										recordset.Fields["DailyRelCB"].Value = Globals_Renamed.arRelModDRR[1, Globals_Renamed.intModIndex];
										recordset.Fields["DailyRelRE"].Value = Globals_Renamed.arRelModDRR[0, Globals_Renamed.intModIndex];
										recordset.Fields["AnnRelCB"].Value = Globals_Renamed.arRelModARR[1, Globals_Renamed.intModIndex];
										recordset.Fields["AnnRelRE"].Value = Globals_Renamed.arRelModARR[0, Globals_Renamed.intModIndex];
										Field field = recordset.Fields["DailyRel2_SN"];
										float[,] arRelModDRR = Globals_Renamed.arRelModDRR;
										float[,] array = arRelModDRR;
										int num10 = 1;
										int num11 = num10;
										int Enumber = Globals_Renamed.intModIndex;
										Parameters = array[num11, Enumber];
										string value = ChemStrX.ShowInSciNot1digit(ref Parameters);
										arRelModDRR[num10, Enumber] = Conversions.ToSingle(Parameters);
										field.Value = value;
										Field field2 = recordset.Fields["DailyRel1_SN"];
										arRelModDRR = Globals_Renamed.arRelModDRR;
										float[,] array2 = arRelModDRR;
										Enumber = 0;
										int num12 = Enumber;
										num10 = Globals_Renamed.intModIndex;
										Parameters = array2[num12, num10];
										string value2 = ChemStrX.ShowInSciNot1digit(ref Parameters);
										arRelModDRR[Enumber, num10] = Conversions.ToSingle(Parameters);
										field2.Value = value2;
										Field field3 = recordset.Fields["AnnRel2_SN"];
										arRelModDRR = Globals_Renamed.arRelModARR;
										float[,] array3 = arRelModDRR;
										Enumber = 1;
										int num13 = Enumber;
										num10 = Globals_Renamed.intModIndex;
										Parameters = array3[num13, num10];
										string value3 = ChemStrX.ShowInSciNot1digit(ref Parameters);
										arRelModDRR[Enumber, num10] = Conversions.ToSingle(Parameters);
										field3.Value = value3;
										Field field4 = recordset.Fields["AnnRel1_SN"];
										arRelModDRR = Globals_Renamed.arRelModARR;
										float[,] array4 = arRelModDRR;
										Enumber = 0;
										int num14 = Enumber;
										num10 = Globals_Renamed.intModIndex;
										Parameters = array4[num14, num10];
										string value4 = ChemStrX.ShowInSciNot1digit(ref Parameters);
										arRelModDRR[Enumber, num10] = Conversions.ToSingle(Parameters);
										field4.Value = value4;
										recordset.Fields["RelDays"].Value = Globals_Renamed.arRelModDOR[0, Globals_Renamed.intModIndex];
										recordset.Fields["RelDays2"].Value = Globals_Renamed.arRelModDOR[1, Globals_Renamed.intModIndex];
										recordset.Fields["Basis"].Value = Globals_Renamed.arRelModBasis[Globals_Renamed.intModIndex];
										recordset.Fields["NAICS"].Value = Globals_Renamed.arRelModNAICS[Globals_Renamed.intModIndex];
										recordset.Fields["ModelStatus"].Value = Globals_Renamed.arRelModStatus[Globals_Renamed.intModIndex];
										recordset.Fields["OutputOn1"].Value = Globals_Renamed.arRelModOutputOn[0, Globals_Renamed.intModIndex];
										recordset.Fields["Char1"].Value = Globals_Renamed.arRelModChar[0, Globals_Renamed.intModIndex];
										recordset.Fields["OutputOn2"].Value = Globals_Renamed.arRelModOutputOn[1, Globals_Renamed.intModIndex];
										recordset.Fields["Char2"].Value = Globals_Renamed.arRelModChar[1, Globals_Renamed.intModIndex];
										recordset.Update(Missing.Value, Missing.Value);
										short num15 = 0;
										short num19;
										short num16;
										do
										{
											num16 = 1;
											short num18;
											do
											{
												if (Globals_Renamed.arRelModParmsT[num15, num16, Globals_Renamed.intModIndex] > 0)
												{
													recordset2.AddNew(Missing.Value, Missing.Value);
													recordset2.Fields["RelParmsAN"].Value = num9;
													recordset2.Fields["OutputID"].Value = num15;
													recordset2.Fields["ParmID"].Value = num16;
													short num17 = num16;
													if ((num17 == 92 || num17 == 72 || num17 == 9) ? true : false)
													{
														if (Globals_Renamed.arRelModParmsVC[num15, num16, Globals_Renamed.intModIndex] == 999)
														{
															recordset2.Fields["ParmValue"].Value = Globals_Renamed.arRelModParmsV[num15, num16, Globals_Renamed.intModIndex];
														}
														else if (Globals_Renamed.arRelModParmsVC[num15, num16, Globals_Renamed.intModIndex] > 0)
														{
															recordset2.Fields["ParmValue"].Value = Globals_Renamed.arRelModParmsV[num15, Globals_Renamed.arRelModParmsVC[num15, num16, Globals_Renamed.intModIndex], Globals_Renamed.intModIndex];
														}
														else if (Globals_Renamed.arRelModType[Globals_Renamed.intModIndex] == 53)
														{
															recordset2.Fields["ParmValue"].Value = Globals_Renamed.arRelModParmsV[num15, Globals_Renamed.arRelModParmsVC[num15, num16, Globals_Renamed.intModIndex], Globals_Renamed.intModIndex];
														}
														else
														{
															recordset2.Fields["ParmValue"].Value = Globals_Renamed.arRelModParmsVC[num15, num16, Globals_Renamed.intModIndex];
															if (!flag)
															{
																flag = true;
																Interaction.Beep();
																Interaction.MsgBox((object)"An error occured while saving the release data in the assessment. The assessment was not completely saved. Please contact Technical Support.", (MsgBoxStyle)16, (object)null);
															}
														}
													}
													else
													{
														recordset2.Fields["ParmValue"].Value = Globals_Renamed.arRelModParmsV[num15, num16, Globals_Renamed.intModIndex];
													}
													recordset2.Fields["ParmType"].Value = Globals_Renamed.arRelModParmsT[num15, num16, Globals_Renamed.intModIndex];
													recordset2.Fields["ParmVC"].Value = Globals_Renamed.arRelModParmsVC[num15, num16, Globals_Renamed.intModIndex];
													recordset2.Update(Missing.Value, Missing.Value);
												}
												num16 = (short)unchecked(num16 + 1);
												num18 = num16;
												num6 = 162;
											}
											while (num18 <= num6);
											num15 = (short)unchecked(num15 + 1);
											num19 = num15;
											num6 = 1;
										}
										while (num19 <= num6);
										num16 = 0;
										short num20;
										do
										{
											if (Globals_Renamed.arRelModMedia[num16, Globals_Renamed.intModIndex] > 0f)
											{
												recordset3.AddNew(Missing.Value, Missing.Value);
												recordset3.Fields["AssessID"].Value = Globals_Renamed.gblAssessID;
												recordset3.Fields["AssOpID"].Value = num4;
												recordset3.Fields["AssActID"].Value = num7;
												recordset3.Fields["RelModID"].Value = num8;
												recordset3.Fields["MediaID"].Value = num16;
												recordset3.Fields["Pct"].Value = Globals_Renamed.arRelModMedia[num16, Globals_Renamed.intModIndex];
												recordset3.Update(Missing.Value, Missing.Value);
											}
											num16 = (short)unchecked(num16 + 1);
											num20 = num16;
											num6 = 17;
										}
										while (num20 <= num6);
									}
									num8 = (short)unchecked(num8 + 1);
									num21 = num8;
									num6 = 9;
								}
								while (num21 <= num6);
								num7 = (short)unchecked(num7 + 1);
								num22 = num7;
								num6 = 24;
							}
							while (num22 <= num6);
							num4 = (short)unchecked(num4 + 1);
						}
						defInstance = null;
						recordset.Close();
						recordset2.Close();
						recordset3.Close();
						recordset = null;
						recordset2 = null;
						recordset3 = null;
						command = null;
						flag2 = true;
						goto end_IL_0001;
					}
				}
				case 2886:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						string Eobject = "DBFuncs.Bas";
						string Efunction = "Save_Rel";
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
				goto IL_0b80;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 2886;
				continue;
			}
			break;
			IL_0b80:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		bool result = flag2;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private static bool Open_ContRpts()
	{
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
					Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
					Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					ProjectData.ClearProjectError();
					num2 = 2;
					recordset.CursorLocation = CursorLocationEnum.adUseClient;
					recordset.Open("SELECT * FROM ContactRpts WHERE AssessID=" + Conversions.ToString((int)Globals_Renamed.gblAssessID), Common.DataConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
					frmMain defInstance = frmMain.DefInstance;
					frmMain frmMain2 = defInstance;
					AxMSFlexGrid pmsfGrid = frmMain2.msfContacts;
					ChemStrX.MyMSfClear(ref pmsfGrid);
					frmMain2.msfContacts = pmsfGrid;
					defInstance.msfContacts.Rows = 2;
					while (!recordset.EOF)
					{
						string text = ((!Information.IsDate(RuntimeHelpers.GetObjectValue(recordset.Fields["ContDate"].Value))) ? "" : Strings.Format(RuntimeHelpers.GetObjectValue(recordset.Fields["ContDate"].Value), Globals_Renamed.gblChemDateFormat));
						defInstance.msfContacts.AddItem(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Interaction.IIf(Conversions.ToBoolean(Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["CBI"].Value))), (object)"Yes", (object)"No"), (object)'\t'), (object)text), (object)'\t'), recordset.Fields["ContTime"].Value), (object)'\t'), recordset.Fields["CallTo"].Value), (object)'\t'), recordset.Fields["CallToAff"].Value), (object)'\t'), recordset.Fields["Phone"].Value), (object)'\t'), recordset.Fields["CallFrom"].Value), (object)'\t'), recordset.Fields["CallFromAff"].Value), (object)'\t'), (object)Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["ContNotes"].Value))), (object)'\t'), recordset.Fields["ContAppAssess"].Value)));
						recordset.MoveNext();
					}
					if (defInstance.msfContacts.Rows > 2)
					{
						defInstance.msfContacts.RemoveItem(1);
					}
					defInstance = null;
					recordset.Close();
					recordset = null;
					flag = true;
					goto end_IL_0001;
				}
				case 796:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						string Eobject = "DBFuncs.Bas";
						string Efunction = "Open_ContRpts";
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
				try0001_dispatch = 796;
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

	private static bool Open_Exp()
	{
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
						Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
						Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
						Recordset recordset2 = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						ProjectData.ClearProjectError();
						num2 = 2;
						recordset.CursorLocation = CursorLocationEnum.adUseClient;
						recordset2.CursorLocation = CursorLocationEnum.adUseClient;
						Globals_Renamed.arExpModType = new short[2];
						Globals_Renamed.arExpModEst = new float[3, 19, 2];
						Globals_Renamed.arExpModOutputOn = new short[3, 2];
						Globals_Renamed.arExpModChar = new string[3, Globals_Renamed.intModIndex + 1 + 1];
						Globals_Renamed.arExpModBasis = new string[Globals_Renamed.intModIndex + 1 + 1];
						Globals_Renamed.arExpModChmSt = new short[Globals_Renamed.intModIndex + 1 + 1];
						Globals_Renamed.arExpModUncertainty = new short[Globals_Renamed.intModIndex + 1 + 1];
						Globals_Renamed.arExpModStatus = new short[Globals_Renamed.intModIndex + 1 + 1];
						Globals_Renamed.arExpModParmsV = new float[3, 163, 2];
						Globals_Renamed.arExpModParmsT = new short[3, 163, 2];
						Globals_Renamed.arExpModParmsVC = new short[3, 163, 2];
						Globals_Renamed.arExpModInhRC = new string[5, 2];
						Globals_Renamed.intModIndex = 0;
						Globals_Renamed.intNumExpModels = 0;
						Globals_Renamed.arExpModels = new short[3, 26, Globals_Renamed.intNumOps + 1];
						recordset.Open("SELECT * FROM ActExpModels WHERE AssessID=" + Conversions.ToString(unchecked((int)Globals_Renamed.gblAssessID)), Common.DataConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
						while (!recordset.EOF)
						{
							Globals_Renamed.arExpModels[Conversions.ToInteger(recordset.Fields["ExplModID"].Value), Conversions.ToInteger(recordset.Fields["AssActID"].Value), Conversions.ToInteger(recordset.Fields["AssOpID"].Value)] = (short)(Globals_Renamed.intModIndex + 1);
							Globals_Renamed.arExpModType = (short[])Utils.CopyArray((Array)Globals_Renamed.arExpModType, (Array)new short[Globals_Renamed.intModIndex + 1 + 1]);
							Globals_Renamed.arExpModEst = (float[,,])Utils.CopyArray((Array)Globals_Renamed.arExpModEst, (Array)new float[3, 19, Globals_Renamed.intModIndex + 1 + 1]);
							Globals_Renamed.arExpModOutputOn = (short[,])Utils.CopyArray((Array)Globals_Renamed.arExpModOutputOn, (Array)new short[3, Globals_Renamed.intModIndex + 1 + 1]);
							Globals_Renamed.arExpModChar = (string[,])Utils.CopyArray((Array)Globals_Renamed.arExpModChar, (Array)new string[3, Globals_Renamed.intModIndex + 1 + 1]);
							Globals_Renamed.arExpModBasis = (string[])Utils.CopyArray((Array)Globals_Renamed.arExpModBasis, (Array)new string[Globals_Renamed.intModIndex + 1 + 1]);
							Globals_Renamed.arExpModChmSt = (short[])Utils.CopyArray((Array)Globals_Renamed.arExpModChmSt, (Array)new short[Globals_Renamed.intModIndex + 1 + 1]);
							Globals_Renamed.arExpModUncertainty = (short[])Utils.CopyArray((Array)Globals_Renamed.arExpModUncertainty, (Array)new short[Globals_Renamed.intModIndex + 1 + 1]);
							Globals_Renamed.arExpModStatus = (short[])Utils.CopyArray((Array)Globals_Renamed.arExpModStatus, (Array)new short[Globals_Renamed.intModIndex + 1 + 1]);
							Globals_Renamed.arExpModParmsV = (float[,,])Utils.CopyArray((Array)Globals_Renamed.arExpModParmsV, (Array)new float[3, 163, Globals_Renamed.intModIndex + 1 + 1]);
							Globals_Renamed.arExpModParmsT = (short[,,])Utils.CopyArray((Array)Globals_Renamed.arExpModParmsT, (Array)new short[3, 163, Globals_Renamed.intModIndex + 1 + 1]);
							Globals_Renamed.arExpModParmsVC = (short[,,])Utils.CopyArray((Array)Globals_Renamed.arExpModParmsVC, (Array)new short[3, 163, Globals_Renamed.intModIndex + 1 + 1]);
							Globals_Renamed.arExpModInhRC = (string[,])Utils.CopyArray((Array)Globals_Renamed.arExpModInhRC, (Array)new string[5, Globals_Renamed.intModIndex + 1 + 1]);
							Globals_Renamed.arExpModType[Globals_Renamed.intModIndex] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["ModelID"].Value)));
							Globals_Renamed.arExpModOutputOn[0, Globals_Renamed.intModIndex] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["OutputOn1"].Value)));
							Globals_Renamed.arExpModOutputOn[1, Globals_Renamed.intModIndex] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["OutputOn2"].Value)));
							Globals_Renamed.arExpModChar[0, Globals_Renamed.intModIndex] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["Char1"].Value));
							Globals_Renamed.arExpModChar[1, Globals_Renamed.intModIndex] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["Char2"].Value));
							Globals_Renamed.arExpModBasis[Globals_Renamed.intModIndex] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["Basis"].Value));
							Globals_Renamed.arExpModChmSt[Globals_Renamed.intModIndex] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["ChemStateID"].Value)));
							if (Globals_Renamed.gblDataVersion >= 5)
							{
								Globals_Renamed.arExpModUncertainty[Globals_Renamed.intModIndex] = Conversions.ToShort(Common.MyNullCheck1(RuntimeHelpers.GetObjectValue(recordset.Fields["inhUncertainty"].Value)));
							}
							else
							{
								Globals_Renamed.arExpModUncertainty[Globals_Renamed.intModIndex] = 1;
							}
							Globals_Renamed.arExpModStatus[Globals_Renamed.intModIndex] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["ModelStatus"].Value)));
							recordset2.Open(Operators.ConcatenateObject((object)"SELECT * FROM ActExpModParms WHERE ExpParmsAN=", recordset.Fields["ExpParmsAN"].Value), Common.DataConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
							while (!recordset2.EOF)
							{
								Globals_Renamed.arExpModParmsV[Conversions.ToInteger(recordset2.Fields["OutputID"].Value), Conversions.ToInteger(recordset2.Fields["ParmID"].Value), Globals_Renamed.intModIndex] = Conversions.ToSingle(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["ParmValue"].Value)));
								Globals_Renamed.arExpModParmsT[Conversions.ToInteger(recordset2.Fields["OutputID"].Value), Conversions.ToInteger(recordset2.Fields["ParmID"].Value), Globals_Renamed.intModIndex] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["ParmType"].Value)));
								Globals_Renamed.arExpModParmsVC[Conversions.ToInteger(recordset2.Fields["OutputID"].Value), Conversions.ToInteger(recordset2.Fields["ParmID"].Value), Globals_Renamed.intModIndex] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["ParmVC"].Value)));
								recordset2.MoveNext();
							}
							recordset2.Close();
							recordset2.Open(Operators.ConcatenateObject((object)"SELECT * FROM ActExpModEst WHERE ExpParmsAN=", recordset.Fields["ExpParmsAN"].Value), Common.DataConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
							while (!recordset2.EOF)
							{
								Globals_Renamed.arExpModEst[Conversions.ToInteger(recordset2.Fields["OutputID"].Value), 2, Globals_Renamed.intModIndex] = Conversions.ToSingle(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["Freq"].Value)));
								short num3 = 4;
								short num4;
								short num5;
								do
								{
									Globals_Renamed.arExpModEst[Conversions.ToInteger(recordset2.Fields["OutputID"].Value), num3, Globals_Renamed.intModIndex] = Conversions.ToSingle(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields[num3 - 1].Value)));
									num3 = (short)unchecked(num3 + 1);
									num4 = num3;
									num5 = 7;
								}
								while (num4 <= num5);
								num3 = 8;
								short num6;
								do
								{
									Globals_Renamed.arExpModEst[Conversions.ToInteger(recordset2.Fields["OutputID"].Value), num3, Globals_Renamed.intModIndex] = Conversions.ToSingle(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields[num3 + 3].Value)));
									num3 = (short)unchecked(num3 + 1);
									num6 = num3;
									num5 = 11;
								}
								while (num6 <= num5);
								Globals_Renamed.arExpModEst[Conversions.ToInteger(recordset2.Fields["OutputID"].Value), 12, Globals_Renamed.intModIndex] = Conversions.ToSingle(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["NSxNWexp"].Value)));
								recordset2.MoveNext();
							}
							if (Globals_Renamed.gblDataVersion >= 12)
							{
								Globals_Renamed.arExpModInhRC[0, Globals_Renamed.intModIndex] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["InhClass"].Value));
								Globals_Renamed.arExpModInhRC[1, Globals_Renamed.intModIndex] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["InhClassNotes"].Value));
								if (recordset.Fields["InhClassExpLevel"].Value == DBNull.Value)
								{
									Globals_Renamed.arExpModInhRC[2, Globals_Renamed.intModIndex] = "";
								}
								else
								{
									Globals_Renamed.arExpModInhRC[2, Globals_Renamed.intModIndex] = Conversions.ToString(Interaction.IIf(Conversions.ToDouble(Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["InhClassExpLevel"].Value))) == 1.0, (object)"Yes", (object)"No"));
								}
								if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["InhClassHazRating"].Value)))
								{
									Globals_Renamed.arExpModInhRC[3, Globals_Renamed.intModIndex] = "";
									Globals_Renamed.arExpModInhRC[4, Globals_Renamed.intModIndex] = "";
								}
								else
								{
									Globals_Renamed.arExpModInhRC[3, Globals_Renamed.intModIndex] = Conversions.ToString(Interaction.IIf(Conversions.ToDouble(Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["InhClassHazRating"].Value))) == 1.0, (object)"Yes", (object)"No"));
									if (Operators.ConditionalCompareObjectEqual(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["InhClassInhMon"].Value)), (object)1, false))
									{
										Globals_Renamed.arExpModInhRC[4, Globals_Renamed.intModIndex] = "Yes (both criteria met)";
									}
									else if (Operators.ConditionalCompareObjectEqual(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["InhClassInhMon"].Value)), (object)0, false))
									{
										Globals_Renamed.arExpModInhRC[4, Globals_Renamed.intModIndex] = "No";
									}
									else
									{
										Globals_Renamed.arExpModInhRC[4, Globals_Renamed.intModIndex] = "";
									}
								}
							}
							else
							{
								Field field = recordset.Fields["AssOpID"];
								object pOpIndex = RuntimeHelpers.GetObjectValue(field.Value);
								ChemStrX.resetInhRespClass(ref pOpIndex);
								field.Value = RuntimeHelpers.GetObjectValue(pOpIndex);
							}
							recordset2.Close();
							recordset.MoveNext();
							Globals_Renamed.intModIndex++;
							Globals_Renamed.intNumExpModels++;
						}
						recordset.Close();
						recordset2 = null;
						recordset = null;
						flag = true;
						goto end_IL_0001;
					}
					case 3145:
						num = -1;
						switch (num2)
						{
						case 2:
						{
							string Eobject = "DBFuncs.Bas";
							string Efunction = "Open_Exp";
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
				try0001_dispatch = 3145;
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

	private static bool Open_Rel()
	{
		int try0001_dispatch = -1;
		int num = default(int);
		Recordset recordset2 = default(Recordset);
		int num2 = default(int);
		int num3 = default(int);
		Recordset recordset = default(Recordset);
		bool flag = default(bool);
		string source = default(string);
		short num5 = default(short);
		float num6 = default(float);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					string Eobject;
					string Efunction;
					ErrObject val;
					int Enumber;
					ErrObject val2;
					string Edescription;
					bool Econtact;
					int num4;
					Guid clsid;
					short num7;
					short num8;
					switch (try0001_dispatch)
					{
					default:
						num = 1;
						clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
						recordset2 = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						goto IL_0023;
					case 3959:
						{
							num2 = num;
							switch ((num3 <= -2) ? 1 : num3)
							{
							case 2:
								break;
							case 1:
								goto IL_0d05;
							default:
								goto end_IL_0001;
							}
							goto IL_0c83;
						}
						IL_07c6:
						num = 110;
						Globals_Renamed.arRelModParmsT[Conversions.ToInteger(recordset.Fields["OutputID"].Value), Conversions.ToInteger(recordset.Fields["ParmID"].Value), Globals_Renamed.intNumRelModels] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["ParmType"].Value)));
						goto IL_0831;
						IL_0831:
						num = 111;
						Globals_Renamed.arRelModParmsVC[Conversions.ToInteger(recordset.Fields["OutputID"].Value), Conversions.ToInteger(recordset.Fields["ParmID"].Value), Globals_Renamed.intNumRelModels] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["ParmVC"].Value)));
						goto IL_089c;
						IL_075b:
						num = 109;
						Globals_Renamed.arRelModParmsV[Conversions.ToInteger(recordset.Fields["OutputID"].Value), Conversions.ToInteger(recordset.Fields["ParmID"].Value), Globals_Renamed.intNumRelModels] = Conversions.ToSingle(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["ParmValue"].Value)));
						goto IL_07c6;
						IL_0c83:
						num = 150;
						Eobject = "DBFuncs.Bas";
						Efunction = "Open_Rel";
						val = Information.Err();
						Enumber = val.Number;
						val2 = Information.Err();
						Edescription = val2.Description;
						Econtact = true;
						Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
						val2.Description = Edescription;
						val.Number = Enumber;
						goto IL_0cdf;
						IL_0cdf:
						num = 151;
						ProjectData.ClearProjectError();
						if (num2 == 0)
						{
							throw ProjectData.CreateProjectError(-2146828268);
						}
						goto IL_0d05;
						IL_089c:
						num = 112;
						recordset.MoveNext();
						goto IL_08a8;
						IL_0d05:
						num4 = unchecked(num2 + 1);
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0023;
						case 3:
							goto IL_0045;
						case 4:
							goto IL_004d;
						case 5:
						case 7:
							goto IL_005b;
						case 8:
						case 10:
							goto IL_006a;
						case 11:
						case 13:
							goto IL_007a;
						case 14:
						case 16:
							goto IL_008a;
						case 17:
						case 19:
							goto IL_009b;
						case 20:
						case 22:
							goto IL_00aa;
						case 23:
						case 25:
							goto IL_00b9;
						case 26:
						case 28:
							goto IL_00c8;
						case 29:
						case 31:
							goto IL_00d8;
						case 32:
						case 34:
							goto IL_00e8;
						case 35:
						case 37:
							goto IL_00fd;
						case 38:
						case 40:
							goto IL_0112;
						case 41:
						case 43:
							goto IL_0127;
						case 44:
							goto IL_0131;
						case 45:
						case 47:
							goto IL_014a;
						case 48:
							goto IL_0156;
						case 51:
							goto IL_0182;
						case 52:
							goto IL_01e6;
						case 53:
						case 55:
							goto IL_0211;
						case 56:
						case 58:
							goto IL_023d;
						case 59:
						case 61:
							goto IL_0269;
						case 62:
						case 64:
							goto IL_0295;
						case 65:
						case 67:
							goto IL_02c2;
						case 68:
						case 70:
							goto IL_02ed;
						case 71:
						case 73:
							goto IL_0318;
						case 74:
						case 76:
							goto IL_0343;
						case 77:
						case 79:
							goto IL_036f;
						case 80:
						case 82:
							goto IL_039b;
						case 83:
						case 85:
							goto IL_03cc;
						case 86:
						case 88:
							goto IL_03fd;
						case 89:
						case 91:
							goto IL_042e;
						case 92:
							goto IL_0461;
						case 93:
							goto IL_0499;
						case 94:
							goto IL_04d1;
						case 95:
							goto IL_0509;
						case 96:
							goto IL_0541;
						case 97:
							goto IL_0579;
						case 98:
							goto IL_05b1;
						case 99:
							goto IL_05e0;
						case 100:
							goto IL_060f;
						case 101:
							goto IL_0642;
						case 102:
							goto IL_067a;
						case 103:
							goto IL_06ad;
						case 104:
							goto IL_06e5;
						case 105:
							goto IL_0718;
						case 106:
							goto IL_0724;
						case 109:
							goto IL_075b;
						case 110:
							goto IL_07c6;
						case 111:
							goto IL_0831;
						case 112:
							goto IL_089c;
						case 107:
						case 108:
						case 113:
							goto IL_08a8;
						case 114:
							goto IL_08be;
						case 115:
							goto IL_08c9;
						case 116:
							goto IL_08e1;
						case 117:
							goto IL_08ed;
						case 118:
							goto IL_0978;
						case 119:
							goto IL_098d;
						case 120:
							goto IL_0993;
						case 121:
							goto IL_099e;
						case 122:
							goto IL_09b1;
						case 123:
							goto IL_09dc;
						case 124:
							goto IL_0a06;
						case 125:
						case 126:
						case 127:
							goto IL_0a13;
						case 128:
							goto IL_0a29;
						case 129:
							goto IL_0a42;
						case 131:
							goto IL_0a55;
						case 132:
							goto IL_0a5d;
						case 133:
							goto IL_0a98;
						case 134:
							goto IL_0ad4;
						case 135:
							goto IL_0b0f;
						case 136:
							goto IL_0b4b;
						case 137:
							goto IL_0b87;
						case 138:
							goto IL_0bc3;
						case 139:
							goto IL_0bdb;
						case 130:
						case 140:
						case 141:
						case 142:
							goto IL_0c19;
						case 143:
							goto IL_0c27;
						case 49:
						case 50:
						case 144:
							goto IL_0c3c;
						case 145:
							goto IL_0c52;
						case 146:
							goto IL_0c60;
						case 147:
							goto IL_0c69;
						case 148:
							goto IL_0c72;
						case 150:
							goto IL_0c83;
						case 151:
							goto IL_0cdf;
						default:
							goto end_IL_0001;
						case 149:
						case 152:
							goto end_IL_0001_2;
						}
						goto default;
						IL_0023:
						num = 2;
						clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
						recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						goto IL_0045;
						IL_0045:
						ProjectData.ClearProjectError();
						num3 = 2;
						goto IL_004d;
						IL_004d:
						num = 4;
						Globals_Renamed.arRelModType = new short[2];
						goto IL_005b;
						IL_005b:
						num = 7;
						Globals_Renamed.arRelModDRR = new float[3, 2];
						goto IL_006a;
						IL_006a:
						num = 10;
						Globals_Renamed.arRelModARR = new float[3, 2];
						goto IL_007a;
						IL_007a:
						num = 13;
						Globals_Renamed.arRelModDOR = new short[3, 2];
						goto IL_008a;
						IL_008a:
						num = 16;
						Globals_Renamed.arRelModMedia = new float[19, 2];
						goto IL_009b;
						IL_009b:
						num = 19;
						Globals_Renamed.arRelModBasis = new string[2];
						goto IL_00aa;
						IL_00aa:
						num = 22;
						Globals_Renamed.arRelModNAICS = new string[2];
						goto IL_00b9;
						IL_00b9:
						num = 25;
						Globals_Renamed.arRelModStatus = new short[2];
						goto IL_00c8;
						IL_00c8:
						num = 28;
						Globals_Renamed.arRelModOutputOn = new short[3, 2];
						goto IL_00d8;
						IL_00d8:
						num = 31;
						Globals_Renamed.arRelModChar = new string[3, 2];
						goto IL_00e8;
						IL_00e8:
						num = 34;
						Globals_Renamed.arRelModParmsV = new float[3, 163, 2];
						goto IL_00fd;
						IL_00fd:
						num = 37;
						Globals_Renamed.arRelModParmsT = new short[3, 163, 2];
						goto IL_0112;
						IL_0112:
						num = 40;
						Globals_Renamed.arRelModParmsVC = new short[3, 163, 2];
						goto IL_0127;
						IL_0127:
						num = 43;
						Globals_Renamed.intNumRelModels = 0;
						goto IL_0131;
						IL_0131:
						num = 44;
						Globals_Renamed.arRelModels = new short[11, 26, Globals_Renamed.intNumOps + 1];
						goto IL_014a;
						IL_014a:
						num = 47;
						recordset2.CursorLocation = CursorLocationEnum.adUseClient;
						goto IL_0156;
						IL_0156:
						num = 48;
						recordset2.Open("SELECT * FROM ActRelModels WHERE AssessID=" + Conversions.ToString(unchecked((int)Globals_Renamed.gblAssessID)), Common.DataConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
						goto IL_0c3c;
						IL_0c3c:
						num = 50;
						if (!recordset2.EOF)
						{
							goto IL_0182;
						}
						goto IL_0c52;
						IL_0c52:
						num = 145;
						recordset2.Close();
						goto IL_0c60;
						IL_0c60:
						num = 146;
						recordset = null;
						goto IL_0c69;
						IL_0c69:
						num = 147;
						recordset2 = null;
						goto IL_0c72;
						IL_0c72:
						num = 148;
						flag = true;
						goto end_IL_0001_2;
						IL_0182:
						num = 51;
						Globals_Renamed.arRelModels[Conversions.ToInteger(recordset2.Fields["RelModID"].Value), Conversions.ToInteger(recordset2.Fields["AssActID"].Value), Conversions.ToInteger(recordset2.Fields["AssOpID"].Value)] = (short)(Globals_Renamed.intNumRelModels + 1);
						goto IL_01e6;
						IL_01e6:
						num = 52;
						Globals_Renamed.arRelModType = (short[])Utils.CopyArray((Array)Globals_Renamed.arRelModType, (Array)new short[Globals_Renamed.intNumRelModels + 1 + 1]);
						goto IL_0211;
						IL_0211:
						num = 55;
						Globals_Renamed.arRelModDRR = (float[,])Utils.CopyArray((Array)Globals_Renamed.arRelModDRR, (Array)new float[3, Globals_Renamed.intNumRelModels + 1 + 1]);
						goto IL_023d;
						IL_023d:
						num = 58;
						Globals_Renamed.arRelModARR = (float[,])Utils.CopyArray((Array)Globals_Renamed.arRelModARR, (Array)new float[3, Globals_Renamed.intNumRelModels + 1 + 1]);
						goto IL_0269;
						IL_0269:
						num = 61;
						Globals_Renamed.arRelModDOR = (short[,])Utils.CopyArray((Array)Globals_Renamed.arRelModDOR, (Array)new short[3, Globals_Renamed.intNumRelModels + 1 + 1]);
						goto IL_0295;
						IL_0295:
						num = 64;
						Globals_Renamed.arRelModMedia = (float[,])Utils.CopyArray((Array)Globals_Renamed.arRelModMedia, (Array)new float[19, Globals_Renamed.intNumRelModels + 1 + 1]);
						goto IL_02c2;
						IL_02c2:
						num = 67;
						Globals_Renamed.arRelModBasis = (string[])Utils.CopyArray((Array)Globals_Renamed.arRelModBasis, (Array)new string[Globals_Renamed.intNumRelModels + 1 + 1]);
						goto IL_02ed;
						IL_02ed:
						num = 70;
						Globals_Renamed.arRelModNAICS = (string[])Utils.CopyArray((Array)Globals_Renamed.arRelModNAICS, (Array)new string[Globals_Renamed.intNumRelModels + 1 + 1]);
						goto IL_0318;
						IL_0318:
						num = 73;
						Globals_Renamed.arRelModStatus = (short[])Utils.CopyArray((Array)Globals_Renamed.arRelModStatus, (Array)new short[Globals_Renamed.intNumRelModels + 1 + 1]);
						goto IL_0343;
						IL_0343:
						num = 76;
						Globals_Renamed.arRelModOutputOn = (short[,])Utils.CopyArray((Array)Globals_Renamed.arRelModOutputOn, (Array)new short[3, Globals_Renamed.intNumRelModels + 1 + 1]);
						goto IL_036f;
						IL_036f:
						num = 79;
						Globals_Renamed.arRelModChar = (string[,])Utils.CopyArray((Array)Globals_Renamed.arRelModChar, (Array)new string[3, Globals_Renamed.intNumRelModels + 1 + 1]);
						goto IL_039b;
						IL_039b:
						num = 82;
						Globals_Renamed.arRelModParmsV = (float[,,])Utils.CopyArray((Array)Globals_Renamed.arRelModParmsV, (Array)new float[3, 163, Globals_Renamed.intNumRelModels + 1 + 1]);
						goto IL_03cc;
						IL_03cc:
						num = 85;
						Globals_Renamed.arRelModParmsT = (short[,,])Utils.CopyArray((Array)Globals_Renamed.arRelModParmsT, (Array)new short[3, 163, Globals_Renamed.intNumRelModels + 1 + 1]);
						goto IL_03fd;
						IL_03fd:
						num = 88;
						Globals_Renamed.arRelModParmsVC = (short[,,])Utils.CopyArray((Array)Globals_Renamed.arRelModParmsVC, (Array)new short[3, 163, Globals_Renamed.intNumRelModels + 1 + 1]);
						goto IL_042e;
						IL_042e:
						num = 91;
						Globals_Renamed.arRelModType[Globals_Renamed.intNumRelModels] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["ModelID"].Value)));
						goto IL_0461;
						IL_0461:
						num = 92;
						Globals_Renamed.arRelModDRR[0, Globals_Renamed.intNumRelModels] = Conversions.ToSingle(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["DailyRelRE"].Value)));
						goto IL_0499;
						IL_0499:
						num = 93;
						Globals_Renamed.arRelModARR[0, Globals_Renamed.intNumRelModels] = Conversions.ToSingle(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["AnnRelRE"].Value)));
						goto IL_04d1;
						IL_04d1:
						num = 94;
						Globals_Renamed.arRelModDOR[0, Globals_Renamed.intNumRelModels] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["RelDays"].Value)));
						goto IL_0509;
						IL_0509:
						num = 95;
						Globals_Renamed.arRelModDRR[1, Globals_Renamed.intNumRelModels] = Conversions.ToSingle(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["DailyRelCB"].Value)));
						goto IL_0541;
						IL_0541:
						num = 96;
						Globals_Renamed.arRelModARR[1, Globals_Renamed.intNumRelModels] = Conversions.ToSingle(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["AnnRelCB"].Value)));
						goto IL_0579;
						IL_0579:
						num = 97;
						Globals_Renamed.arRelModDOR[1, Globals_Renamed.intNumRelModels] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["RelDays2"].Value)));
						goto IL_05b1;
						IL_05b1:
						num = 98;
						Globals_Renamed.arRelModBasis[Globals_Renamed.intNumRelModels] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["Basis"].Value));
						goto IL_05e0;
						IL_05e0:
						num = 99;
						Globals_Renamed.arRelModNAICS[Globals_Renamed.intNumRelModels] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["NAICS"].Value));
						goto IL_060f;
						IL_060f:
						num = 100;
						Globals_Renamed.arRelModStatus[Globals_Renamed.intNumRelModels] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["ModelStatus"].Value)));
						goto IL_0642;
						IL_0642:
						num = 101;
						Globals_Renamed.arRelModOutputOn[0, Globals_Renamed.intNumRelModels] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["OutputOn1"].Value)));
						goto IL_067a;
						IL_067a:
						num = 102;
						Globals_Renamed.arRelModChar[0, Globals_Renamed.intNumRelModels] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["Char1"].Value));
						goto IL_06ad;
						IL_06ad:
						num = 103;
						Globals_Renamed.arRelModOutputOn[1, Globals_Renamed.intNumRelModels] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["OutputOn2"].Value)));
						goto IL_06e5;
						IL_06e5:
						num = 104;
						Globals_Renamed.arRelModChar[1, Globals_Renamed.intNumRelModels] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["Char2"].Value));
						goto IL_0718;
						IL_0718:
						num = 105;
						recordset.CursorLocation = CursorLocationEnum.adUseClient;
						goto IL_0724;
						IL_0724:
						num = 106;
						recordset.Open(Operators.ConcatenateObject((object)"SELECT * FROM ActRelModParms WHERE RelParmsAN=", recordset2.Fields["RelParmsAN"].Value), Common.DataConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
						goto IL_08a8;
						IL_08a8:
						num = 108;
						if (!recordset.EOF)
						{
							goto IL_075b;
						}
						goto IL_08be;
						IL_08be:
						num = 114;
						recordset.Close();
						goto IL_08c9;
						IL_08c9:
						num = 115;
						if (Globals_Renamed.gblDataVersion >= 3)
						{
							goto IL_08e1;
						}
						goto IL_0a55;
						IL_08e1:
						num = 116;
						recordset.CursorLocation = CursorLocationEnum.adUseClient;
						goto IL_08ed;
						IL_08ed:
						num = 117;
						source = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat("SELECT MediaID, Pct FROM ActRelModMedia WHERE AssessID=" + Conversions.ToString(unchecked((int)Globals_Renamed.gblAssessID)), " AND AssOpID="), recordset2.Fields["AssOpID"].Value), (object)" AND AssActID="), recordset2.Fields["AssActID"].Value), (object)" AND RelModID="), recordset2.Fields["RelModID"].Value));
						goto IL_0978;
						IL_0978:
						num = 118;
						recordset.Open(source, Common.DataConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
						goto IL_098d;
						IL_098d:
						num = 119;
						num5 = 0;
						goto IL_0993;
						IL_0993:
						num = 120;
						num6 = 0f;
						goto IL_099e;
						IL_099e:
						num = 121;
						if (!recordset.EOF)
						{
							goto IL_09b1;
						}
						goto IL_0a13;
						IL_09b1:
						num = 122;
						if (Operators.ConditionalCompareObjectEqual((object)num5, recordset.Fields["MediaID"].Value, false))
						{
							goto IL_09dc;
						}
						goto IL_0a13;
						IL_09dc:
						num = 123;
						num6 = Conversions.ToSingle(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["Pct"].Value)));
						goto IL_0a06;
						IL_0a06:
						num = 124;
						recordset.MoveNext();
						goto IL_0a13;
						IL_0a13:
						num = 127;
						Globals_Renamed.arRelModMedia[num5, Globals_Renamed.intNumRelModels] = num6;
						goto IL_0a29;
						IL_0a29:
						num = 128;
						num5 = (short)unchecked(num5 + 1);
						num7 = num5;
						num8 = 17;
						if (num7 <= num8)
						{
							goto IL_0993;
						}
						goto IL_0a42;
						IL_0a42:
						num = 129;
						recordset.Close();
						goto IL_0c19;
						IL_0a55:
						num = 131;
						goto IL_0a5d;
						IL_0a5d:
						num = 132;
						Globals_Renamed.arRelModMedia[0, Globals_Renamed.intNumRelModels] = Conversions.ToSingle(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["AirPct"].Value)));
						goto IL_0a98;
						IL_0a98:
						num = 133;
						Globals_Renamed.arRelModMedia[13, Globals_Renamed.intNumRelModels] = Conversions.ToSingle(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["WaterPct"].Value)));
						goto IL_0ad4;
						IL_0ad4:
						num = 134;
						Globals_Renamed.arRelModMedia[7, Globals_Renamed.intNumRelModels] = Conversions.ToSingle(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["LFPct"].Value)));
						goto IL_0b0f;
						IL_0b0f:
						num = 135;
						Globals_Renamed.arRelModMedia[11, Globals_Renamed.intNumRelModels] = Conversions.ToSingle(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["IncPct"].Value)));
						goto IL_0b4b;
						IL_0b4b:
						num = 136;
						Globals_Renamed.arRelModMedia[16, Globals_Renamed.intNumRelModels] = Conversions.ToSingle(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["OtherPct"].Value)));
						goto IL_0b87;
						IL_0b87:
						num = 137;
						Globals_Renamed.arRelModMedia[15, Globals_Renamed.intNumRelModels] = Conversions.ToSingle(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["DestPct"].Value)));
						goto IL_0bc3;
						IL_0bc3:
						num = 138;
						if (Globals_Renamed.gblDataVersion >= 2)
						{
							goto IL_0bdb;
						}
						goto IL_0c19;
						IL_0bdb:
						num = 139;
						Globals_Renamed.arRelModMedia[14, Globals_Renamed.intNumRelModels] = Conversions.ToSingle(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["DeepPct"].Value)));
						goto IL_0c19;
						IL_0c19:
						num = 142;
						recordset2.MoveNext();
						goto IL_0c27;
						IL_0c27:
						num = 143;
						Globals_Renamed.intNumRelModels++;
						goto IL_0c3c;
						end_IL_0001:
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 3959;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_2:
			break;
		}
		bool result = flag;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private static object Save_OtherData()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		object obj = default(object);
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
					frmMain defInstance = frmMain.DefInstance;
					command.ActiveConnection = Common.DataConn;
					command.CommandText = "pqryDeleteMsdsExpLimits";
					command.CommandType = CommandTypeEnum.adCmdStoredProc;
					command.Parameters.Append(command.CreateParameter("pAssessID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, Globals_Renamed.gblAssessID));
					Command command2 = command;
					object RecordsAffected = Missing.Value;
					object Parameters = Missing.Value;
					command2.Execute(out RecordsAffected, ref Parameters);
					command.Parameters.Delete("pAssessID");
					recordset.CursorLocation = CursorLocationEnum.adUseServer;
					recordset.Open("SELECT * FROM MSDS_ExpLimits WHERE AssessID=" + Conversions.ToString((int)Globals_Renamed.gblAssessID), Common.DataConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
					short num3 = checked((short)(defInstance.msfTlv.Rows - 1));
					short num4 = 1;
					while (true)
					{
						short num5 = num4;
						short num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						recordset.AddNew(Missing.Value, Missing.Value);
						recordset.Fields["AssessID"].Value = Globals_Renamed.gblAssessID;
						recordset.Fields["RowID"].Value = num4;
						recordset.Fields["Material"].Value = defInstance.msfTlv[(int)num4, 0];
						recordset.Fields["Concentration"].Value = defInstance.msfTlv[(int)num4, 1];
						recordset.Fields["ExpLimit"].Value = defInstance.msfTlv[(int)num4, 2];
						recordset.Fields["Reference"].Value = defInstance.msfTlv[(int)num4, 4];
						recordset.Fields["TypeOfMaterial"].Value = defInstance.msfTlv[(int)num4, 5];
						recordset.Fields["ExpLimitType"].Value = defInstance.msfTlv[(int)num4, 3];
						recordset.Update(Missing.Value, Missing.Value);
						checked
						{
							num4 = (short)unchecked(num4 + 1);
						}
					}
					recordset.Close();
					recordset.Open("SELECT * FROM SAT WHERE AssessID=" + Conversions.ToString((int)Globals_Renamed.gblAssessID), Common.DataConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
					if (recordset.EOF)
					{
						recordset.AddNew(Missing.Value, Missing.Value);
						recordset.Fields["AssessID"].Value = Globals_Renamed.gblAssessID;
					}
					recordset.Fields["SATdate"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDate((object)defInstance.lblSATdate.Text), (object)defInstance.lblSATdate.Text, (object)DBNull.Value));
					recordset.Fields["RelatedCases"].Value = defInstance.txtSatRelatedCases.Text;
					recordset.Fields["AddPBTinfo"].Value = defInstance.txtSatAddPBTinfo.Text;
					recordset.Fields["HRating"].Value = defInstance.lblSATHR.Text;
					recordset.Fields["ERating"].Value = defInstance.lblSATER.Text;
					recordset.Fields["PRate"].Value = defInstance.lblSatPR.Text;
					recordset.Fields["BRate"].Value = defInstance.lblSatBR.Text;
					recordset.Fields["TRate"].Value = defInstance.lblSatTR.Text;
					recordset.Fields["Dermal"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(defInstance.lblSatHReq[(short)0].Text, "Yes", false) == 0, (object)1, (object)0));
					recordset.Fields["DW"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(defInstance.lblSatHReq[(short)1].Text, "Yes", false) == 0, (object)1, (object)0));
					recordset.Fields["Inh"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(defInstance.lblSatHReq[(short)2].Text, "Yes", false) == 0, (object)1, (object)0));
					recordset.Fields["NR"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(defInstance.lblSatHReq[(short)3].Text, "Yes", false) == 0, (object)1, (object)0));
					recordset.Fields["OtherReq"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(defInstance.lblSatHReq[(short)4].Text, "Yes", false) == 0, (object)1, (object)0));
					recordset.Fields["OtherReqDesc"].Value = Strings.Left(defInstance.lblSatHReq[(short)6].Text, 255);
					recordset.Fields["HealthXP"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(defInstance.lblSatHReq[(short)5].Text, "Yes", false) == 0, (object)1, (object)0));
					if (Operators.CompareString(defInstance.lblSatHReq[(short)8].Text, "Yes", false) == 0)
					{
						recordset.Fields["HealthXPYesNo"].Value = 1;
					}
					else if (Operators.CompareString(defInstance.lblSatHReq[(short)8].Text, "No", false) == 0)
					{
						recordset.Fields["HealthXPYesNo"].Value = 0;
					}
					else
					{
						recordset.Fields["HealthXPYesNo"].Value = DBNull.Value;
					}
					recordset.Fields["HealthXPDesc"].Value = defInstance.lblSatHReq[(short)7].Text;
					recordset.Fields["EcoW"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(defInstance.lblSatEReq[(short)0].Text, "Yes", false) == 0, (object)1, (object)0));
					recordset.Fields["EcoA"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(defInstance.lblSatEReq[(short)1].Text, "Yes", false) == 0, (object)1, (object)0));
					recordset.Fields["EcoL"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(defInstance.lblSatEReq[(short)2].Text, "Yes", false) == 0, (object)1, (object)0));
					recordset.Fields["EcoNR"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(defInstance.lblSatEReq[(short)3].Text, "Yes", false) == 0, (object)1, (object)0));
					recordset.Fields["EcoO"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(defInstance.lblSatEReq[(short)4].Text, "Yes", false) == 0, (object)1, (object)0));
					recordset.Fields["EcoODesc"].Value = defInstance.lblSatEReq[(short)6].Text;
					recordset.Fields["EcoXP"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(defInstance.lblSatEReq[(short)5].Text, "Yes", false) == 0, (object)1, (object)0));
					if (Operators.CompareString(defInstance.lblSatEReq[(short)8].Text, "Yes", false) == 0)
					{
						recordset.Fields["EcoXPYesNo"].Value = 1;
					}
					else if (Operators.CompareString(defInstance.lblSatEReq[(short)8].Text, "No", false) == 0)
					{
						recordset.Fields["EcoXPYesNo"].Value = 0;
					}
					else
					{
						recordset.Fields["EcoXPYesNo"].Value = DBNull.Value;
					}
					recordset.Fields["EcoXPDesc"].Value = defInstance.lblSatEReq[(short)7].Text;
					recordset.Fields["cc"].Value = Common.MyNullCheck(defInstance.lblCC.Text);
					recordset.Fields["M2G"].Value = defInstance.lblSatM2G.Text;
					recordset.Fields["M2GDesc"].Value = Strings.Left(defInstance.lblSatM2GOther.Text, 255);
					recordset.Update(Missing.Value, Missing.Value);
					recordset.Close();
					defInstance = null;
					recordset = null;
					command = null;
					obj = true;
					goto end_IL_0001;
				}
				case 2657:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						string Eobject = "DBFuncs.Bas";
						string Efunction = "Save_OtherData";
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
			catch (object obj2) when (obj2 is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0001_dispatch = 2657;
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

	private static object Open_OtherData()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		object obj = default(object);
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
					recordset.Open("SELECT * FROM MSDS_ExpLimits WHERE AssessID=" + Conversions.ToString((int)Globals_Renamed.gblAssessID), Common.DataConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
					frmMain defInstance = frmMain.DefInstance;
					defInstance.msfTlv.Rows = 2;
					while (!recordset.EOF)
					{
						defInstance.msfTlv.AddItem(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(recordset.Fields["Material"].Value, (object)'\t'), recordset.Fields["Concentration"].Value), (object)'\t'), recordset.Fields["ExpLimit"].Value), (object)'\t'), recordset.Fields["ExpLimitType"].Value), (object)'\t'), recordset.Fields["Reference"].Value), (object)'\t'), recordset.Fields["TypeOfMaterial"].Value)));
						recordset.MoveNext();
					}
					recordset.Close();
					if (defInstance.msfTlv.Rows > 2)
					{
						defInstance.msfTlv.RemoveItem(1);
					}
					recordset.Open("SELECT * FROM SAT WHERE AssessID=" + Conversions.ToString((int)Globals_Renamed.gblAssessID), Common.DataConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
					if (!recordset.EOF)
					{
						if (Information.IsDate(RuntimeHelpers.GetObjectValue(recordset.Fields["SATdate"].Value)))
						{
							defInstance.lblSATdate.Text = Strings.Format(RuntimeHelpers.GetObjectValue(recordset.Fields["SATdate"].Value), Globals_Renamed.gblChemDateFormat);
						}
						else
						{
							defInstance.lblSATdate.Text = "";
						}
						defInstance.txtSatRelatedCases.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["RelatedCases"].Value));
						defInstance.txtSatAddPBTinfo.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["AddPBTinfo"].Value));
						defInstance.lblSATHR.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["HRating"].Value));
						defInstance.lblSATER.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["ERating"].Value));
						defInstance.lblSatPR.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["PRate"].Value));
						defInstance.lblSatBR.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["BRate"].Value));
						defInstance.lblSatTR.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["TRate"].Value));
						defInstance.lblSatHReq[(short)0].Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["Dermal"].Value)), (object)1, false), (object)"Yes", (object)"No"));
						defInstance.lblSatHReq[(short)1].Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["DW"].Value)), (object)1, false), (object)"Yes", (object)"No"));
						defInstance.lblSatHReq[(short)2].Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["Inh"].Value)), (object)1, false), (object)"Yes", (object)"No"));
						defInstance.lblSatHReq[(short)3].Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["NR"].Value)), (object)1, false), (object)"Yes", (object)"No"));
						defInstance.lblSatHReq[(short)4].Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["OtherReq"].Value)), (object)1, false), (object)"Yes", (object)"No"));
						defInstance.lblSatHReq[(short)6].Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["OtherReqDesc"].Value));
						defInstance.lblSatEReq[(short)0].Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["EcoW"].Value)), (object)1, false), (object)"Yes", (object)"No"));
						defInstance.lblSatEReq[(short)1].Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["EcoA"].Value)), (object)1, false), (object)"Yes", (object)"No"));
						defInstance.lblSatEReq[(short)2].Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["EcoL"].Value)), (object)1, false), (object)"Yes", (object)"No"));
						defInstance.lblSatEReq[(short)3].Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["EcoNR"].Value)), (object)1, false), (object)"Yes", (object)"No"));
						defInstance.lblSatEReq[(short)4].Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["EcoO"].Value)), (object)1, false), (object)"Yes", (object)"No"));
						defInstance.lblSatEReq[(short)6].Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["EcoODesc"].Value));
						defInstance.lblSatM2G.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["M2G"].Value));
						defInstance.lblSatM2GOther.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["M2GDesc"].Value));
						if (Globals_Renamed.gblDataVersion >= 5)
						{
							defInstance.lblSatHReq[(short)5].Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["HealthXP"].Value)), (object)1, false), (object)"Yes", (object)"No"));
							defInstance.lblSatHReq[(short)7].Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["HealthXPDesc"].Value));
							defInstance.lblSatEReq[(short)5].Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["EcoXP"].Value)), (object)1, false), (object)"Yes", (object)"No"));
							defInstance.lblSatEReq[(short)7].Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["EcoXPDesc"].Value));
							defInstance.lblCC.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["cc"].Value));
							if (Globals_Renamed.gblDataVersion >= 6)
							{
								if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["HealthXPYesNo"].Value)))
								{
									defInstance.lblSatHReq[(short)8].Text = "";
								}
								else if (Operators.ConditionalCompareObjectEqual(recordset.Fields["HealthXPYesNo"].Value, (object)1, false))
								{
									defInstance.lblSatHReq[(short)8].Text = "Yes";
								}
								else if (Operators.ConditionalCompareObjectEqual(recordset.Fields["HealthXPYesNo"].Value, (object)0, false))
								{
									defInstance.lblSatHReq[(short)8].Text = "No";
								}
								else
								{
									defInstance.lblSatHReq[(short)8].Text = "";
								}
								if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["EcoXPYesNo"].Value)))
								{
									defInstance.lblSatEReq[(short)8].Text = "";
								}
								else if (Operators.ConditionalCompareObjectEqual(recordset.Fields["EcoXPYesNo"].Value, (object)1, false))
								{
									defInstance.lblSatEReq[(short)8].Text = "Yes";
								}
								else if (Operators.ConditionalCompareObjectEqual(recordset.Fields["EcoXPYesNo"].Value, (object)0, false))
								{
									defInstance.lblSatEReq[(short)8].Text = "No";
								}
								else
								{
									defInstance.lblSatEReq[(short)8].Text = "";
								}
							}
						}
						((Control)frmMain.DefInstance.lblCC).Visible = Operators.CompareString(frmMain.DefInstance.lblSatEReq[(short)0].Text, "Yes", false) == 0;
						((Control)frmMain.DefInstance.lblSatEReq[(short)6]).Visible = Operators.CompareString(frmMain.DefInstance.lblSatEReq[(short)4].Text, "Yes", false) == 0;
					}
					recordset.Close();
					defInstance = null;
					recordset = null;
					obj = true;
					goto end_IL_0001;
				}
				case 2900:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						string Eobject = "DBFuncs.Bas";
						string Efunction = "Open_OtherData";
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
			catch (object obj2) when (obj2 is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0001_dispatch = 2900;
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

	private static object Save_ContRpts()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		object obj = default(object);
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
					recordset.CursorLocation = CursorLocationEnum.adUseServer;
					recordset.Open("SELECT * FROM ContactRpts WHERE AssessID=" + Conversions.ToString((int)Globals_Renamed.gblAssessID), Common.DataConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
					while (!recordset.EOF)
					{
						recordset.Delete();
						recordset.MoveFirst();
					}
					frmMain defInstance = frmMain.DefInstance;
					short num3 = checked((short)(defInstance.msfContacts.Rows - 1));
					short num4 = 1;
					while (true)
					{
						short num5 = num4;
						short num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						if (true)
						{
							recordset.AddNew(Missing.Value, Missing.Value);
							recordset.Fields["AssessID"].Value = Globals_Renamed.gblAssessID;
							recordset.Fields["CBI"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(defInstance.msfContacts[(int)num4, 0], "Yes", false) == 0, (object)true, (object)false));
							if (Information.IsDate((object)defInstance.msfContacts[(int)num4, 1]))
							{
								recordset.Fields["ContDate"].Value = defInstance.msfContacts[(int)num4, 1];
							}
							recordset.Fields["ContTime"].Value = defInstance.msfContacts[(int)num4, 2];
							recordset.Fields["CallTo"].Value = defInstance.msfContacts[(int)num4, 3];
							recordset.Fields["CallToAff"].Value = defInstance.msfContacts[(int)num4, 4];
							recordset.Fields["Phone"].Value = defInstance.msfContacts[(int)num4, 5];
							recordset.Fields["CallFrom"].Value = defInstance.msfContacts[(int)num4, 6];
							recordset.Fields["CallFromAff"].Value = defInstance.msfContacts[(int)num4, 7];
							recordset.Fields["ContNotes"].Value = defInstance.msfContacts[(int)num4, 8];
							recordset.Fields["ContAppAssess"].Value = defInstance.msfContacts[(int)num4, 9];
							recordset.Update(Missing.Value, Missing.Value);
						}
						checked
						{
							num4 = (short)unchecked(num4 + 1);
						}
					}
					defInstance = null;
					recordset.Close();
					recordset = null;
					obj = true;
					goto end_IL_0001;
				}
				case 778:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						string Eobject = "DBFuncs.Bas";
						string Efunction = "Save_ContRpts";
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
			catch (object obj2) when (obj2 is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0001_dispatch = 778;
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

	private static bool Save_Irer()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		short num26 = default(short);
		short num27 = default(short);
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
					Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
					Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
					Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					short[,] array = new short[3, 100];
					float[,] array2 = new float[3, 100];
					float[,] array3 = new float[3, 100];
					float[,] array4 = new float[3, 100];
					string[,] array5 = new string[3, 100];
					string[] array6 = new string[100];
					string[] array7 = new string[100];
					string[] array8 = new string[100];
					string[] array9 = new string[19];
					short[] array10 = new short[19];
					float[] array11 = new float[3];
					short[] array12 = new short[100];
					short[] array13 = new short[100];
					ProjectData.ClearProjectError();
					num2 = 2;
					recordset.CursorLocation = CursorLocationEnum.adUseClient;
					recordset.Open("SELECT * FROM ListOfMedia ORDER BY SortID", Common.MyConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
					while (!recordset.EOF)
					{
						array9[Conversions.ToInteger(recordset.Fields["MediaID"].Value)] = Conversions.ToString(recordset.Fields["media"].Value);
						array10[Conversions.ToInteger(recordset.Fields["MediaID"].Value)] = Conversions.ToShort(recordset.Fields["SortID"].Value);
						recordset.MoveNext();
					}
					recordset.Close();
					command.ActiveConnection = Common.DataConn;
					command.CommandText = "pQryDeleteIrerRels";
					command.CommandType = CommandTypeEnum.adCmdStoredProc;
					command.Parameters.Append(command.CreateParameter("pAssessID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, Globals_Renamed.gblAssessID));
					Command command2 = command;
					object RecordsAffected = Missing.Value;
					object Parameters = Missing.Value;
					command2.Execute(out RecordsAffected, ref Parameters);
					command.Parameters.Delete("pAssessID");
					recordset.CursorLocation = CursorLocationEnum.adUseServer;
					recordset.Open("SELECT * FROM IrerRels WHERE AssessID=" + Conversions.ToString((int)Globals_Renamed.gblAssessID), Common.DataConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
					checked
					{
						short num3 = (short)(frmMain.DefInstance._lstSelOps_0.Items.Count - 1);
						short num4 = 0;
						while (true)
						{
							short num5 = num4;
							short num6 = num3;
							if (num5 > num6)
							{
								break;
							}
							float num7 = 0f;
							short num8 = 0;
							short num31;
							do
							{
								short num9 = 0;
								short num12;
								do
								{
									short num10 = 0;
									short num11;
									do
									{
										array[num10, num9] = 0;
										array2[num10, num9] = 0f;
										array3[num10, num9] = 0f;
										num10 = (short)unchecked(num10 + 1);
										num11 = num10;
										num6 = 1;
									}
									while (num11 <= num6);
									array6[num9] = "";
									array7[num9] = "";
									array8[num9] = "'";
									num9 = (short)unchecked(num9 + 1);
									num12 = num9;
									num6 = 99;
								}
								while (num12 <= num6);
								short num13 = 0;
								short num14 = 1;
								string text = "";
								short num15 = 0;
								short num30;
								do
								{
									short num16 = 0;
									short num29;
									do
									{
										if ((Globals_Renamed.arRelModels[num16, num15, num4] > 0) & Globals_Renamed.arSelActRa[num15, num4])
										{
											short num17 = (short)(Globals_Renamed.arRelModels[num16, num15, num4] - 1);
											if (Globals_Renamed.arRelModMedia[num8, num17] > 0f)
											{
												array6[num13] = Globals_Renamed.arRelModBasis[num17];
												array7[num13] = Globals_Renamed.arSelActs[num15, num4];
												array8[num13] = Globals_Renamed.arRelModNAICS[num17];
												array12[num13] = Globals_Renamed.arRelModType[num17];
												array13[num13] = num17;
												num14 = 1;
												if (Globals_Renamed.arRelModOutputOn[0, num17] == 1)
												{
													if (Globals_Renamed.arRelModOutputOn[1, num17] == 1)
													{
														array[0, num13] = Globals_Renamed.arRelModDOR[0, num17];
														array2[0, num13] = Globals_Renamed.arRelModDRR[0, num17] * Globals_Renamed.arRelModMedia[num8, num17] / 100f;
														array5[0, num13] = Globals_Renamed.arRelModChar[0, num17];
														array[1, num13] = Globals_Renamed.arRelModDOR[1, num17];
														array2[1, num13] = Globals_Renamed.arRelModDRR[1, num17] * Globals_Renamed.arRelModMedia[num8, num17] / 100f;
														array5[1, num13] = Globals_Renamed.arRelModChar[1, num17];
														num14 = 2;
														num13++;
													}
													else
													{
														array[0, num13] = Globals_Renamed.arRelModDOR[0, num17];
														array2[0, num13] = Globals_Renamed.arRelModDRR[0, num17] * Globals_Renamed.arRelModMedia[num8, num17] / 100f;
														array5[0, num13] = Globals_Renamed.arRelModChar[0, num17];
														num13++;
													}
												}
												else if (Globals_Renamed.arRelModOutputOn[1, num17] == 1)
												{
													array[1, num13] = Globals_Renamed.arRelModDOR[1, num17];
													array2[1, num13] = Globals_Renamed.arRelModDRR[1, num17] * Globals_Renamed.arRelModMedia[num8, num17] / 100f;
													array5[1, num13] = Globals_Renamed.arRelModChar[1, num17];
													num13++;
												}
											}
										}
										if (num13 > 0)
										{
											short num10 = 0;
											array11[0] = 0f;
											array11[1] = 0f;
											num9 = 0;
											while (true)
											{
												short num18 = 366;
												short num19 = (short)(num13 - 1);
												short num20 = 0;
												while (true)
												{
													short num21 = num20;
													num6 = num19;
													if (num21 > num6)
													{
														break;
													}
													if ((array[num9, num20] < num18) & (array[num9, num20] > 0))
													{
														num18 = array[num9, num20];
													}
													num20 = (short)unchecked(num20 + 1);
												}
												if (num18 != 366)
												{
													float num22 = 0f;
													float num23 = 0f;
													string text2 = "";
													string text3 = "";
													string text4 = "";
													text = "";
													string value = "";
													short num24 = (short)(num13 - 1);
													num20 = 0;
													while (true)
													{
														short num25 = num20;
														num6 = num24;
														if (num25 > num6)
														{
															break;
														}
														if (array[num9, num20] > 0)
														{
															array[num9, num20] = (short)unchecked(array[num9, num20] - num18);
															num22 += array2[num9, num20];
															text2 = text2 + text + array6[num20];
															text3 = text3 + text + array7[num20];
															text4 = text4 + text + array8[num20];
															text = "; ";
															value = array5[num9, num20];
															num26 = array12[num20];
															num27 = array13[num20];
														}
														num20 = (short)unchecked(num20 + 1);
													}
													array11[num9] = (float)num18 * num22 * Globals_Renamed.arRelModParmsV[num9, 1, num27];
													if (array11[1] >= array11[0])
													{
														num7 -= array11[0];
													}
													num7 += array11[num9];
													recordset.AddNew(Missing.Value, Missing.Value);
													recordset.Fields["AssessID"].Value = Globals_Renamed.gblAssessID;
													recordset.Fields["AssOpID"].Value = num4;
													recordset.Fields["ActSort"].Value = num15;
													recordset.Fields["ModSort"].Value = num26;
													recordset.Fields["OpName"].Value = Support.GetItemString((Control)(object)frmMain.DefInstance._lstSelOps_0, unchecked((int)num4));
													recordset.Fields["media"].Value = array9[num8];
													recordset.Fields["NAICS"].Value = text4;
													recordset.Fields["MediaSort"].Value = array10[num8];
													switch (num14)
													{
													case 2:
														recordset.Fields["dualID"].Value = num10 + 1;
														break;
													case 1:
														recordset.Fields["dualID"].Value = num10;
														break;
													default:
														recordset.Fields["dualID"].Value = 0;
														break;
													}
													recordset.Fields["Acts"].Value = text3;
													recordset.Fields["Basis"].Value = text2;
													Field field = recordset.Fields["DRR"];
													Parameters = num22;
													string value2 = ChemStrX.ShowInSciNot1digit(ref Parameters);
													num22 = Conversions.ToSingle(Parameters);
													field.Value = value2;
													Field field2 = recordset.Fields["ARRSite"];
													Parameters = num22 * (float)num18;
													field2.Value = ChemStrX.ShowInSciNot1digit(ref Parameters);
													Field field3 = recordset.Fields["arr"];
													Parameters = (float)num18 * num22 * Globals_Renamed.arRelModParmsV[num9, 1, num27];
													field3.Value = ChemStrX.ShowInSciNot1digit(ref Parameters);
													recordset.Fields["DOR"].Value = num18;
													recordset.Fields["Output"].Value = value;
													recordset.Fields["NS"].Value = Globals_Renamed.arRelModParmsV[num9, 1, num27];
													recordset.Update(Missing.Value, Missing.Value);
													num10++;
												}
												else
												{
													num9 = (short)unchecked(num9 + 1);
													short num28 = num9;
													num6 = 1;
													if (num28 > num6)
													{
														break;
													}
												}
											}
										}
										num16 = (short)unchecked(num16 + 1);
										num29 = num16;
										num6 = 9;
									}
									while (num29 <= num6);
									num15 = (short)unchecked(num15 + 1);
									num30 = num15;
									num6 = 24;
								}
								while (num30 <= num6);
								num8 = (short)unchecked(num8 + 1);
								num31 = num8;
								num6 = 17;
							}
							while (num31 <= num6);
							if (num7 > 0f)
							{
								recordset.AddNew(Missing.Value, Missing.Value);
								recordset.Fields["AssessID"].Value = Globals_Renamed.gblAssessID;
								recordset.Fields["AssOpID"].Value = num4;
								recordset.Fields["ActSort"].Value = 99;
								recordset.Fields["ModSort"].Value = 99;
								recordset.Fields["OpName"].Value = Support.GetItemString((Control)(object)frmMain.DefInstance._lstSelOps_0, unchecked((int)num4));
								recordset.Fields["media"].Value = "RELEASE TOTAL";
								recordset.Fields["MediaSort"].Value = 99;
								recordset.Fields["dualID"].Value = 3;
								Field field4 = recordset.Fields["arr"];
								Parameters = num7;
								string value3 = ChemStrX.ShowInSciNot1digit(ref Parameters);
								num7 = Conversions.ToSingle(Parameters);
								field4.Value = value3;
								recordset.Fields["DOR"].Value = 99;
								recordset.Update(Missing.Value, Missing.Value);
							}
							num4 = (short)unchecked(num4 + 1);
						}
						recordset.Close();
						recordset = null;
						command = null;
						flag = true;
						goto end_IL_0001;
					}
				}
				case 3096:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						string Eobject = "DBFuncs.Bas";
						string Efunction = "Save_Irer";
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
				try0001_dispatch = 3096;
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

	private static object Save_Ops()
	{
		int try0001_dispatch = -1;
		int num = default(int);
		Recordset recordset = default(Recordset);
		int num2 = default(int);
		int num3 = default(int);
		short num4 = default(short);
		Command command = default(Command);
		short num6 = default(short);
		short num9 = default(short);
		short num11 = default(short);
		short num13 = default(short);
		short num15 = default(short);
		short num17 = default(short);
		short num19 = default(short);
		short num21 = default(short);
		short num22 = default(short);
		object obj = default(object);
		short num25 = default(short);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					string Eobject;
					string Efunction;
					ErrObject val;
					int Enumber;
					ErrObject val2;
					string Edescription;
					bool Econtact;
					int num5;
					Guid clsid;
					Command command2;
					short num7;
					short num10;
					short num12;
					short num14;
					short num16;
					short num18;
					short num20;
					Command command3;
					object Parameters;
					object RecordsAffected;
					short num23;
					short num24;
					frmMain defInstance;
					short num26;
					short num27;
					short num28;
					short num29;
					short num30;
					short num31;
					short num32;
					short num33;
					short num8;
					switch (try0001_dispatch)
					{
					default:
						num = 1;
						clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
						recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						goto IL_0023;
					case 6667:
						{
							num2 = num;
							switch ((num3 <= -2) ? 1 : num3)
							{
							case 2:
							case 3:
								break;
							case 1:
								goto IL_16b1;
							default:
								goto end_IL_0001;
							}
							goto IL_162f;
						}
						IL_05f9:
						num = 54;
						num4 = (short)unchecked(num4 + 1);
						goto IL_0603;
						IL_0104:
						num = 14;
						recordset.Delete();
						goto IL_0110;
						IL_05e4:
						num = 53;
						recordset.Update(Missing.Value, Missing.Value);
						goto IL_05f9;
						IL_162f:
						num = 208;
						Eobject = "DBFuncs.Bas";
						Efunction = "Save_Ops";
						val = Information.Err();
						Enumber = val.Number;
						val2 = Information.Err();
						Edescription = val2.Description;
						Econtact = true;
						Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
						val2.Description = Edescription;
						val.Number = Enumber;
						goto IL_168b;
						IL_168b:
						num = 209;
						ProjectData.ClearProjectError();
						if (num2 == 0)
						{
							throw ProjectData.CreateProjectError(-2146828268);
						}
						goto IL_16b1;
						IL_0110:
						num = 15;
						recordset.MoveFirst();
						goto IL_011c;
						IL_16b1:
						num5 = unchecked(num2 + 1);
						num2 = 0;
						switch (num5)
						{
						case 1:
							break;
						case 2:
							goto IL_0023;
						case 3:
							goto IL_0045;
						case 4:
							goto IL_004d;
						case 5:
							goto IL_005c;
						case 6:
							goto IL_006b;
						case 7:
							goto IL_0076;
						case 8:
							goto IL_009d;
						case 9:
							goto IL_00ba;
						case 10:
							goto IL_00cf;
						case 11:
							goto IL_00db;
						case 14:
							goto IL_0104;
						case 15:
							goto IL_0110;
						case 12:
						case 13:
						case 16:
							goto IL_011c;
						case 17:
							goto IL_012f;
						case 18:
							goto IL_013a;
						case 19:
							goto IL_014f;
						case 20:
							goto IL_0164;
						case 21:
							goto IL_0188;
						case 22:
							goto IL_01a8;
						case 23:
							goto IL_01ce;
						case 24:
							goto IL_01f4;
						case 25:
							goto IL_0215;
						case 26:
							goto IL_023b;
						case 27:
							goto IL_025c;
						case 28:
							goto IL_027d;
						case 29:
							goto IL_029e;
						case 30:
							goto IL_02bf;
						case 31:
							goto IL_02e0;
						case 32:
							goto IL_0301;
						case 33:
							goto IL_0322;
						case 34:
							goto IL_0348;
						case 35:
							goto IL_036e;
						case 36:
							goto IL_0394;
						case 37:
							goto IL_039d;
						case 38:
							goto IL_03c8;
						case 39:
							goto IL_03f3;
						case 40:
							goto IL_041e;
						case 41:
							goto IL_0426;
						case 42:
							goto IL_0451;
						case 43:
							goto IL_0472;
						case 44:
							goto IL_0493;
						case 45:
							goto IL_04b4;
						case 46:
							goto IL_04d5;
						case 47:
							goto IL_0500;
						case 48:
							goto IL_052b;
						case 49:
							goto IL_0556;
						case 50:
							goto IL_057c;
						case 51:
							goto IL_059d;
						case 52:
							goto IL_05be;
						case 53:
							goto IL_05e4;
						case 54:
							goto IL_05f9;
						case 55:
							goto IL_060f;
						case 56:
							goto IL_061a;
						case 57:
							goto IL_0641;
						case 58:
							goto IL_0656;
						case 59:
							goto IL_065d;
						case 60:
							goto IL_067f;
						case 61:
							goto IL_0694;
						case 62:
							goto IL_06b8;
						case 63:
							goto IL_06d8;
						case 64:
							goto IL_06f9;
						case 65:
							goto IL_0720;
						case 66:
						case 67:
							goto IL_0736;
						case 68:
							goto IL_074f;
						case 69:
							goto IL_0765;
						case 70:
							goto IL_0770;
						case 71:
							goto IL_0797;
						case 72:
							goto IL_07ac;
						case 73:
							goto IL_07b3;
						case 74:
							goto IL_07d5;
						case 75:
							goto IL_07ea;
						case 76:
							goto IL_080e;
						case 77:
							goto IL_082e;
						case 78:
							goto IL_084f;
						case 79:
							goto IL_0876;
						case 80:
							goto IL_089d;
						case 81:
							goto IL_08c4;
						case 82:
							goto IL_08eb;
						case 83:
							goto IL_0912;
						case 84:
							goto IL_0939;
						case 85:
						case 86:
							goto IL_094f;
						case 87:
							goto IL_0968;
						case 88:
							goto IL_097e;
						case 89:
							goto IL_0989;
						case 90:
							goto IL_09b0;
						case 91:
							goto IL_09c5;
						case 92:
							goto IL_09cc;
						case 93:
							goto IL_09e9;
						case 94:
							goto IL_09fe;
						case 95:
							goto IL_0a22;
						case 96:
							goto IL_0a42;
						case 97:
							goto IL_0a63;
						case 98:
							goto IL_0a8a;
						case 99:
							goto IL_0ab6;
						case 100:
							goto IL_0ae2;
						case 101:
							goto IL_0b0e;
						case 102:
							goto IL_0b3a;
						case 103:
							goto IL_0b66;
						case 104:
							goto IL_0b92;
						case 105:
							goto IL_0bbf;
						case 106:
							goto IL_0bec;
						case 107:
							goto IL_0c19;
						case 108:
							goto IL_0c40;
						case 109:
							goto IL_0c6c;
						case 110:
						case 111:
							goto IL_0c82;
						case 112:
							goto IL_0c9b;
						case 113:
							goto IL_0cb1;
						case 114:
							goto IL_0cbc;
						case 115:
							goto IL_0ce3;
						case 116:
							goto IL_0cf8;
						case 117:
							goto IL_0cff;
						case 118:
							goto IL_0d21;
						case 119:
							goto IL_0d36;
						case 120:
							goto IL_0d5a;
						case 121:
							goto IL_0d7a;
						case 122:
							goto IL_0d9b;
						case 123:
							goto IL_0dc7;
						case 124:
							goto IL_0df3;
						case 125:
							goto IL_0e1f;
						case 126:
						case 127:
							goto IL_0e35;
						case 128:
							goto IL_0e4e;
						case 129:
							goto IL_0e67;
						case 130:
							goto IL_0e75;
						case 133:
							goto IL_0ea1;
						case 134:
							goto IL_0eb0;
						case 131:
						case 132:
						case 135:
							goto IL_0ebf;
						case 136:
							goto IL_0ed5;
						case 137:
							goto IL_0eed;
						case 138:
							goto IL_0ef7;
						case 139:
							goto IL_0f0f;
						case 140:
							goto IL_0f36;
						case 141:
							goto IL_0f59;
						case 142:
							goto IL_0f7d;
						case 143:
							goto IL_0fac;
						case 144:
							goto IL_0fdb;
						case 145:
							goto IL_0ff3;
						case 146:
							goto IL_1012;
						case 147:
							goto IL_101c;
						case 148:
							goto IL_1040;
						case 149:
							goto IL_1058;
						case 150:
							goto IL_107f;
						case 151:
							goto IL_10a2;
						case 152:
							goto IL_10cc;
						case 153:
							goto IL_10fb;
						case 154:
							goto IL_112a;
						case 155:
						case 156:
							goto IL_1143;
						case 157:
							goto IL_115f;
						case 158:
							goto IL_1178;
						case 159:
							goto IL_1186;
						case 162:
							goto IL_11b2;
						case 163:
							goto IL_11c1;
						case 160:
						case 161:
						case 164:
							goto IL_11d0;
						case 165:
							goto IL_11e6;
						case 166:
							goto IL_11fe;
						case 167:
							goto IL_1208;
						case 168:
							goto IL_1212;
						case 169:
							goto IL_1238;
						case 170:
							goto IL_1250;
						case 171:
							goto IL_1277;
						case 172:
							goto IL_129a;
						case 173:
							goto IL_12be;
						case 174:
							goto IL_12e2;
						case 175:
							goto IL_1313;
						case 176:
							goto IL_1344;
						case 177:
						case 178:
							goto IL_135d;
						case 179:
							goto IL_1379;
						case 180:
							goto IL_1395;
						case 181:
							goto IL_13ae;
						case 182:
							goto IL_13bc;
						case 183:
							goto IL_13cf;
						case 184:
							goto IL_13e2;
						case 185:
							goto IL_13f1;
						case 186:
							goto IL_141c;
						case 187:
							goto IL_143d;
						case 188:
							goto IL_1455;
						case 189:
							goto IL_147f;
						case 190:
							goto IL_1489;
						case 191:
							goto IL_14a1;
						case 192:
							goto IL_14c1;
						case 193:
							goto IL_14d9;
						case 194:
							goto IL_1500;
						case 195:
							goto IL_1523;
						case 196:
							goto IL_1547;
						case 197:
							goto IL_1576;
						case 198:
							goto IL_15a5;
						case 199:
						case 200:
							goto IL_15be;
						case 201:
							goto IL_15d7;
						case 202:
							goto IL_15f6;
						case 203:
							goto IL_1604;
						case 204:
							goto IL_1607;
						case 205:
							goto IL_1610;
						case 206:
							goto IL_1619;
						case 208:
							goto IL_162f;
						case 209:
							goto IL_168b;
						default:
							goto end_IL_0001;
						case 207:
						case 210:
							goto end_IL_0001_2;
						}
						goto default;
						IL_0023:
						num = 2;
						clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
						command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						goto IL_0045;
						IL_0045:
						ProjectData.ClearProjectError();
						num3 = 2;
						goto IL_004d;
						IL_004d:
						num = 4;
						command.ActiveConnection = Common.DataConn;
						goto IL_005c;
						IL_005c:
						num = 5;
						command.CommandText = "pqryDeleteOps";
						goto IL_006b;
						IL_006b:
						num = 6;
						command.CommandType = CommandTypeEnum.adCmdStoredProc;
						goto IL_0076;
						IL_0076:
						num = 7;
						command.Parameters.Append(command.CreateParameter("pAssessID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, Globals_Renamed.gblAssessID));
						goto IL_009d;
						IL_009d:
						num = 8;
						command2 = command;
						RecordsAffected = Missing.Value;
						Parameters = Missing.Value;
						command2.Execute(out RecordsAffected, ref Parameters);
						goto IL_00ba;
						IL_00ba:
						num = 9;
						command.Parameters.Delete("pAssessID");
						goto IL_00cf;
						IL_00cf:
						num = 10;
						recordset.CursorLocation = CursorLocationEnum.adUseServer;
						goto IL_00db;
						IL_00db:
						num = 11;
						recordset.Open("SELECT * FROM Operations WHERE AssessID=" + Conversions.ToString(unchecked((int)Globals_Renamed.gblAssessID)), Common.DataConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
						goto IL_011c;
						IL_011c:
						num = 13;
						if (!recordset.EOF)
						{
							goto IL_0104;
						}
						goto IL_012f;
						IL_012f:
						num = 17;
						defInstance = frmMain.DefInstance;
						goto IL_013a;
						IL_013a:
						num = 18;
						num6 = (short)(Globals_Renamed.intNumOps - 1);
						num4 = 0;
						goto IL_0603;
						IL_0603:
						num7 = num4;
						num8 = num6;
						if (num7 <= num8)
						{
							goto IL_014f;
						}
						goto IL_060f;
						IL_060f:
						num = 55;
						recordset.Close();
						goto IL_061a;
						IL_061a:
						num = 56;
						recordset.Open("SELECT * FROM OpNaics WHERE AssessID=" + Conversions.ToString(unchecked((int)Globals_Renamed.gblAssessID)), Common.DataConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
						goto IL_0641;
						IL_0641:
						num = 57;
						num9 = (short)(Globals_Renamed.intNumOps - 1);
						num4 = 0;
						goto IL_0759;
						IL_0759:
						num10 = num4;
						num8 = num9;
						if (num10 <= num8)
						{
							goto IL_0656;
						}
						goto IL_0765;
						IL_0765:
						num = 69;
						recordset.Close();
						goto IL_0770;
						IL_0770:
						num = 70;
						recordset.Open("SELECT * FROM OpSites WHERE AssessID=" + Conversions.ToString(unchecked((int)Globals_Renamed.gblAssessID)), Common.DataConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
						goto IL_0797;
						IL_0797:
						num = 71;
						num11 = (short)(Globals_Renamed.intNumOps - 1);
						num4 = 0;
						goto IL_0972;
						IL_0972:
						num12 = num4;
						num8 = num11;
						if (num12 <= num8)
						{
							goto IL_07ac;
						}
						goto IL_097e;
						IL_097e:
						num = 88;
						recordset.Close();
						goto IL_0989;
						IL_0989:
						num = 89;
						recordset.Open("SELECT * FROM Activities WHERE AssessID=" + Conversions.ToString(unchecked((int)Globals_Renamed.gblAssessID)), Common.DataConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
						goto IL_09b0;
						IL_09b0:
						num = 90;
						num13 = (short)(Globals_Renamed.intNumOps - 1);
						num4 = 0;
						goto IL_0ca5;
						IL_0ca5:
						num14 = num4;
						num8 = num13;
						if (num14 <= num8)
						{
							goto IL_09c5;
						}
						goto IL_0cb1;
						IL_0cb1:
						num = 113;
						recordset.Close();
						goto IL_0cbc;
						IL_0cbc:
						num = 114;
						recordset.Open("SELECT * FROM OpRel WHERE AssessID=" + Conversions.ToString(unchecked((int)Globals_Renamed.gblAssessID)), Common.DataConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
						goto IL_0ce3;
						IL_0ce3:
						num = 115;
						num15 = (short)(Globals_Renamed.intNumOps - 1);
						num4 = 0;
						goto IL_0e5b;
						IL_0e5b:
						num16 = num4;
						num8 = num15;
						if (num16 <= num8)
						{
							goto IL_0cf8;
						}
						goto IL_0e67;
						IL_0e67:
						num = 129;
						recordset.Close();
						goto IL_0e75;
						IL_0e75:
						num = 130;
						recordset.Open("SELECT * FROM OpParms WHERE AssessID=" + Conversions.ToString(unchecked((int)Globals_Renamed.gblAssessID)), Common.DataConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
						goto IL_0ebf;
						IL_0ebf:
						num = 132;
						if (!recordset.EOF)
						{
							goto IL_0ea1;
						}
						goto IL_0ed5;
						IL_0ed5:
						num = 136;
						num17 = (short)(Globals_Renamed.intNumOps - 1);
						num4 = 0;
						goto IL_116c;
						IL_116c:
						num18 = num4;
						num8 = num17;
						if (num18 <= num8)
						{
							goto IL_0eed;
						}
						goto IL_1178;
						IL_1178:
						num = 158;
						recordset.Close();
						goto IL_1186;
						IL_1186:
						num = 159;
						recordset.Open("SELECT * FROM ActContParms WHERE AssessID=" + Conversions.ToString(unchecked((int)Globals_Renamed.gblAssessID)), Common.DataConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
						goto IL_11d0;
						IL_11d0:
						num = 161;
						if (!recordset.EOF)
						{
							goto IL_11b2;
						}
						goto IL_11e6;
						IL_11e6:
						num = 165;
						num19 = (short)(Globals_Renamed.intNumOps - 1);
						num4 = 0;
						goto IL_13a2;
						IL_13a2:
						num20 = num4;
						num8 = num19;
						if (num20 <= num8)
						{
							goto IL_11fe;
						}
						goto IL_13ae;
						IL_13ae:
						num = 181;
						recordset.Close();
						goto IL_13bc;
						IL_13bc:
						num = 182;
						command.ActiveConnection = Common.DataConn;
						goto IL_13cf;
						IL_13cf:
						num = 183;
						command.CommandText = "pqryDeleteGSSOptions";
						goto IL_13e2;
						IL_13e2:
						num = 184;
						command.CommandType = CommandTypeEnum.adCmdStoredProc;
						goto IL_13f1;
						IL_13f1:
						num = 185;
						command.Parameters.Append(command.CreateParameter("pAssessID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, Globals_Renamed.gblAssessID));
						goto IL_141c;
						IL_141c:
						num = 186;
						command3 = command;
						Parameters = Missing.Value;
						RecordsAffected = Missing.Value;
						command3.Execute(out Parameters, ref RecordsAffected);
						goto IL_143d;
						IL_143d:
						num = 187;
						command.Parameters.Delete("pAssessID");
						goto IL_1455;
						IL_1455:
						num = 188;
						recordset.Open("SELECT * FROM GSSOptions WHERE AssessID=" + Conversions.ToString(unchecked((int)Globals_Renamed.gblAssessID)), Common.DataConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
						goto IL_147f;
						IL_147f:
						num = 189;
						num21 = 0;
						goto IL_1489;
						IL_1489:
						num = 190;
						num22 = (short)(Globals_Renamed.intNumOps - 1);
						num4 = 0;
						goto IL_15cb;
						IL_15cb:
						num23 = num4;
						num8 = num22;
						if (num23 <= num8)
						{
							goto IL_14a1;
						}
						goto IL_15d7;
						IL_15d7:
						num = 201;
						num21 = (short)unchecked(num21 + 1);
						num24 = num21;
						num8 = 161;
						if (num24 <= num8)
						{
							goto IL_1489;
						}
						goto IL_15f6;
						IL_15f6:
						num = 202;
						recordset.Close();
						goto IL_1604;
						IL_1604:
						defInstance = null;
						goto IL_1607;
						IL_1607:
						num = 204;
						recordset = null;
						goto IL_1610;
						IL_1610:
						num = 205;
						command = null;
						goto IL_1619;
						IL_1619:
						num = 206;
						obj = true;
						goto end_IL_0001_2;
						IL_14a1:
						num = 191;
						if (Globals_Renamed.arGssOptions[num21, num4] > 0)
						{
							goto IL_14c1;
						}
						goto IL_15be;
						IL_14c1:
						num = 192;
						recordset.AddNew(Missing.Value, Missing.Value);
						goto IL_14d9;
						IL_14d9:
						num = 193;
						recordset.Fields["AssessID"].Value = Globals_Renamed.gblAssessID;
						goto IL_1500;
						IL_1500:
						num = 194;
						recordset.Fields["AssOpID"].Value = num4;
						goto IL_1523;
						IL_1523:
						num = 195;
						recordset.Fields["ParmID"].Value = num21;
						goto IL_1547;
						IL_1547:
						num = 196;
						recordset.Fields["OptionValue"].Value = Globals_Renamed.arGssOptions[num21, num4];
						goto IL_1576;
						IL_1576:
						num = 197;
						recordset.Fields["Other"].Value = Common.MyNullCheck(Globals_Renamed.arGssOther[num21, num4]);
						goto IL_15a5;
						IL_15a5:
						num = 198;
						recordset.Update(Missing.Value, Missing.Value);
						goto IL_15be;
						IL_15be:
						num = 200;
						num4 = (short)unchecked(num4 + 1);
						goto IL_15cb;
						IL_11fe:
						num = 166;
						num21 = 0;
						goto IL_1208;
						IL_1208:
						num = 167;
						num25 = 0;
						goto IL_1212;
						IL_1212:
						num = 168;
						if (Globals_Renamed.arContParms[num25, num21, num4] > 0f)
						{
							goto IL_1238;
						}
						goto IL_135d;
						IL_1238:
						num = 169;
						recordset.AddNew(Missing.Value, Missing.Value);
						goto IL_1250;
						IL_1250:
						num = 170;
						recordset.Fields["AssessID"].Value = Globals_Renamed.gblAssessID;
						goto IL_1277;
						IL_1277:
						num = 171;
						recordset.Fields["AssOpID"].Value = num4;
						goto IL_129a;
						IL_129a:
						num = 172;
						recordset.Fields["AssActID"].Value = num21;
						goto IL_12be;
						IL_12be:
						num = 173;
						recordset.Fields["ParmID"].Value = num25;
						goto IL_12e2;
						IL_12e2:
						num = 174;
						recordset.Fields["ParmValue"].Value = Globals_Renamed.arContParms[num25, num21, num4];
						goto IL_1313;
						IL_1313:
						num = 175;
						recordset.Fields["ParmType"].Value = Globals_Renamed.arContParmTypes[num25, num21, num4];
						goto IL_1344;
						IL_1344:
						num = 176;
						recordset.Update(Missing.Value, Missing.Value);
						goto IL_135d;
						IL_135d:
						num = 178;
						num25 = (short)unchecked(num25 + 1);
						num26 = num25;
						num8 = 14;
						if (num26 <= num8)
						{
							goto IL_1212;
						}
						goto IL_1379;
						IL_1379:
						num = 179;
						num21 = (short)unchecked(num21 + 1);
						num27 = num21;
						num8 = 24;
						if (num27 <= num8)
						{
							goto IL_1208;
						}
						goto IL_1395;
						IL_1395:
						num = 180;
						num4 = (short)unchecked(num4 + 1);
						goto IL_13a2;
						IL_11b2:
						num = 162;
						recordset.Delete();
						goto IL_11c1;
						IL_11c1:
						num = 163;
						recordset.MoveFirst();
						goto IL_11d0;
						IL_0eed:
						num = 137;
						num21 = 0;
						goto IL_0ef7;
						IL_0ef7:
						num = 138;
						recordset.AddNew(Missing.Value, Missing.Value);
						goto IL_0f0f;
						IL_0f0f:
						num = 139;
						recordset.Fields["AssessID"].Value = Globals_Renamed.gblAssessID;
						goto IL_0f36;
						IL_0f36:
						num = 140;
						recordset.Fields["AssOpID"].Value = num4;
						goto IL_0f59;
						IL_0f59:
						num = 141;
						recordset.Fields["ParmID"].Value = num21;
						goto IL_0f7d;
						IL_0f7d:
						num = 142;
						recordset.Fields["ParmValue"].Value = Globals_Renamed.arOpParms[num21, num4];
						goto IL_0fac;
						IL_0fac:
						num = 143;
						recordset.Fields["ParmType"].Value = Globals_Renamed.arOpParmsType[num21, num4];
						goto IL_0fdb;
						IL_0fdb:
						num = 144;
						recordset.Update(Missing.Value, Missing.Value);
						goto IL_0ff3;
						IL_0ff3:
						num = 145;
						num21 = (short)unchecked(num21 + 1);
						num28 = num21;
						num8 = 161;
						if (num28 <= num8)
						{
							goto IL_0ef7;
						}
						goto IL_1012;
						IL_1012:
						num = 146;
						num21 = 0;
						goto IL_101c;
						IL_101c:
						num = 147;
						if (Globals_Renamed.arOpSP[num21, num4] > 0f)
						{
							goto IL_1040;
						}
						goto IL_1143;
						IL_1040:
						num = 148;
						recordset.AddNew(Missing.Value, Missing.Value);
						goto IL_1058;
						IL_1058:
						num = 149;
						recordset.Fields["AssessID"].Value = Globals_Renamed.gblAssessID;
						goto IL_107f;
						IL_107f:
						num = 150;
						recordset.Fields["AssOpID"].Value = num4;
						goto IL_10a2;
						IL_10a2:
						num = 151;
						recordset.Fields["ParmID"].Value = num21 + 1000;
						goto IL_10cc;
						IL_10cc:
						num = 152;
						recordset.Fields["ParmValue"].Value = Globals_Renamed.arOpSP[num21, num4];
						goto IL_10fb;
						IL_10fb:
						num = 153;
						recordset.Fields["ParmType"].Value = Globals_Renamed.arOpSPType[num21, num4];
						goto IL_112a;
						IL_112a:
						num = 154;
						recordset.Update(Missing.Value, Missing.Value);
						goto IL_1143;
						IL_1143:
						num = 156;
						num21 = (short)unchecked(num21 + 1);
						num29 = num21;
						num8 = 47;
						if (num29 <= num8)
						{
							goto IL_101c;
						}
						goto IL_115f;
						IL_115f:
						num = 157;
						num4 = (short)unchecked(num4 + 1);
						goto IL_116c;
						IL_0ea1:
						num = 133;
						recordset.Delete();
						goto IL_0eb0;
						IL_0eb0:
						num = 134;
						recordset.MoveFirst();
						goto IL_0ebf;
						IL_0cf8:
						num = 116;
						num21 = 0;
						goto IL_0cff;
						IL_0cff:
						num = 117;
						if (Strings.Len(Globals_Renamed.arSubOpID[num21, num4]) > 0)
						{
							goto IL_0d21;
						}
						goto IL_0e35;
						IL_0d21:
						num = 118;
						recordset.AddNew(Missing.Value, Missing.Value);
						goto IL_0d36;
						IL_0d36:
						num = 119;
						recordset.Fields["AssessID"].Value = Globals_Renamed.gblAssessID;
						goto IL_0d5a;
						IL_0d5a:
						num = 120;
						recordset.Fields["AssOpID"].Value = num4;
						goto IL_0d7a;
						IL_0d7a:
						num = 121;
						recordset.Fields["RelID"].Value = num21;
						goto IL_0d9b;
						IL_0d9b:
						num = 122;
						recordset.Fields["Child"].Value = Globals_Renamed.arSubOpID[num21, num4];
						goto IL_0dc7;
						IL_0dc7:
						num = 123;
						recordset.Fields["ChildPVf"].Value = Globals_Renamed.arSubPVf[num21, num4];
						goto IL_0df3;
						IL_0df3:
						num = 124;
						recordset.Fields["ChildPVop"].Value = Globals_Renamed.arSubPvOp[num21, num4];
						goto IL_0e1f;
						IL_0e1f:
						num = 125;
						recordset.Update(Missing.Value, Missing.Value);
						goto IL_0e35;
						IL_0e35:
						num = 127;
						num21 = (short)unchecked(num21 + 1);
						num30 = num21;
						num8 = 9;
						if (num30 <= num8)
						{
							goto IL_0cff;
						}
						goto IL_0e4e;
						IL_0e4e:
						num = 128;
						num4 = (short)unchecked(num4 + 1);
						goto IL_0e5b;
						IL_09c5:
						num = 91;
						num21 = 0;
						goto IL_09cc;
						IL_09cc:
						num = 92;
						if (Globals_Renamed.arSelActType[num21, num4] > 0)
						{
							goto IL_09e9;
						}
						goto IL_0c82;
						IL_09e9:
						num = 93;
						recordset.AddNew(Missing.Value, Missing.Value);
						goto IL_09fe;
						IL_09fe:
						num = 94;
						recordset.Fields["AssessID"].Value = Globals_Renamed.gblAssessID;
						goto IL_0a22;
						IL_0a22:
						num = 95;
						recordset.Fields["AssOpID"].Value = num4;
						goto IL_0a42;
						IL_0a42:
						num = 96;
						recordset.Fields["AssActID"].Value = num21;
						goto IL_0a63;
						IL_0a63:
						num = 97;
						recordset.Fields["ActName"].Value = Globals_Renamed.arSelActs[num21, num4];
						goto IL_0a8a;
						IL_0a8a:
						num = 98;
						recordset.Fields["ActID"].Value = Globals_Renamed.arSelActType[num21, num4];
						goto IL_0ab6;
						IL_0ab6:
						num = 99;
						recordset.Fields["DoRel"].Value = Globals_Renamed.arSelActRa[num21, num4];
						goto IL_0ae2;
						IL_0ae2:
						num = 100;
						recordset.Fields["DoExp"].Value = Globals_Renamed.arSelActEa[num21, num4];
						goto IL_0b0e;
						IL_0b0e:
						num = 101;
						recordset.Fields["DidRel"].Value = Globals_Renamed.arSelActRaDMP[num21, num4];
						goto IL_0b3a;
						IL_0b3a:
						num = 102;
						recordset.Fields["DidExp"].Value = Globals_Renamed.arSelActEaDMP[num21, num4];
						goto IL_0b66;
						IL_0b66:
						num = 103;
						recordset.Fields["Volatile"].Value = Globals_Renamed.arSelActVolatile[num21, num4];
						goto IL_0b92;
						IL_0b92:
						num = 104;
						recordset.Fields["NW_NS"].Value = Globals_Renamed.arActNumWorkers[0, num21, num4];
						goto IL_0bbf;
						IL_0bbf:
						num = 105;
						recordset.Fields["NW_NWexp"].Value = Globals_Renamed.arActNumWorkers[1, num21, num4];
						goto IL_0bec;
						IL_0bec:
						num = 106;
						recordset.Fields["NW_NSxNWexp"].Value = Globals_Renamed.arActNumWorkers[2, num21, num4];
						goto IL_0c19;
						IL_0c19:
						num = 107;
						recordset.Fields["NW_Route"].Value = Globals_Renamed.arActNW_Route[num21, num4];
						goto IL_0c40;
						IL_0c40:
						num = 108;
						recordset.Fields["ActOrder"].Value = Globals_Renamed.arActOrder[num21, num4];
						goto IL_0c6c;
						IL_0c6c:
						num = 109;
						recordset.Update(Missing.Value, Missing.Value);
						goto IL_0c82;
						IL_0c82:
						num = 111;
						num21 = (short)unchecked(num21 + 1);
						num31 = num21;
						num8 = 24;
						if (num31 <= num8)
						{
							goto IL_09cc;
						}
						goto IL_0c9b;
						IL_0c9b:
						num = 112;
						num4 = (short)unchecked(num4 + 1);
						goto IL_0ca5;
						IL_07ac:
						num = 72;
						num21 = 0;
						goto IL_07b3;
						IL_07b3:
						num = 73;
						if (Strings.Len(Globals_Renamed.arOSName[num21, num4]) > 0)
						{
							goto IL_07d5;
						}
						goto IL_094f;
						IL_07d5:
						num = 74;
						recordset.AddNew(Missing.Value, Missing.Value);
						goto IL_07ea;
						IL_07ea:
						num = 75;
						recordset.Fields["AssessID"].Value = Globals_Renamed.gblAssessID;
						goto IL_080e;
						IL_080e:
						num = 76;
						recordset.Fields["AssOpID"].Value = num4;
						goto IL_082e;
						IL_082e:
						num = 77;
						recordset.Fields["FacID"].Value = num21;
						goto IL_084f;
						IL_084f:
						num = 78;
						recordset.Fields["FacName"].Value = Globals_Renamed.arOSName[num21, num4];
						goto IL_0876;
						IL_0876:
						num = 79;
						recordset.Fields["FacAddr1"].Value = Globals_Renamed.arOSAddr[num21, num4];
						goto IL_089d;
						IL_089d:
						num = 80;
						recordset.Fields["FacCity"].Value = Globals_Renamed.arOSCity[num21, num4];
						goto IL_08c4;
						IL_08c4:
						num = 81;
						recordset.Fields["FacState"].Value = Globals_Renamed.arOSState[num21, num4];
						goto IL_08eb;
						IL_08eb:
						num = 82;
						recordset.Fields["FacZip"].Value = Globals_Renamed.arOSZip[num21, num4];
						goto IL_0912;
						IL_0912:
						num = 83;
						recordset.Fields["FacCounty"].Value = Globals_Renamed.arOSCty[num21, num4];
						goto IL_0939;
						IL_0939:
						num = 84;
						recordset.Update(Missing.Value, Missing.Value);
						goto IL_094f;
						IL_094f:
						num = 86;
						num21 = (short)unchecked(num21 + 1);
						num32 = num21;
						num8 = 99;
						if (num32 <= num8)
						{
							goto IL_07b3;
						}
						goto IL_0968;
						IL_0968:
						num = 87;
						num4 = (short)unchecked(num4 + 1);
						goto IL_0972;
						IL_0656:
						num = 58;
						num21 = 0;
						goto IL_065d;
						IL_065d:
						num = 59;
						if (Strings.Len(Globals_Renamed.arNaics1[num21, num4]) > 0)
						{
							goto IL_067f;
						}
						goto IL_0736;
						IL_067f:
						num = 60;
						recordset.AddNew(Missing.Value, Missing.Value);
						goto IL_0694;
						IL_0694:
						num = 61;
						recordset.Fields["AssessID"].Value = Globals_Renamed.gblAssessID;
						goto IL_06b8;
						IL_06b8:
						num = 62;
						recordset.Fields["AssOpID"].Value = num4;
						goto IL_06d8;
						IL_06d8:
						num = 63;
						recordset.Fields["NaicsIndex"].Value = num21;
						goto IL_06f9;
						IL_06f9:
						num = 64;
						recordset.Fields["NAICS"].Value = Globals_Renamed.arNaics1[num21, num4];
						goto IL_0720;
						IL_0720:
						num = 65;
						recordset.Update(Missing.Value, Missing.Value);
						goto IL_0736;
						IL_0736:
						num = 67;
						num21 = (short)unchecked(num21 + 1);
						num33 = num21;
						num8 = 99;
						if (num33 <= num8)
						{
							goto IL_065d;
						}
						goto IL_074f;
						IL_074f:
						num = 68;
						num4 = (short)unchecked(num4 + 1);
						goto IL_0759;
						IL_014f:
						num = 19;
						recordset.AddNew(Missing.Value, Missing.Value);
						goto IL_0164;
						IL_0164:
						num = 20;
						recordset.Fields["AssessID"].Value = Globals_Renamed.gblAssessID;
						goto IL_0188;
						IL_0188:
						num = 21;
						recordset.Fields["AssOpID"].Value = num4;
						goto IL_01a8;
						IL_01a8:
						num = 22;
						recordset.Fields["OpOrder"].Value = Globals_Renamed.arOpOrder[num4];
						goto IL_01ce;
						IL_01ce:
						num = 23;
						recordset.Fields["OpID"].Value = Globals_Renamed.arOpType[num4];
						goto IL_01f4;
						IL_01f4:
						num = 24;
						recordset.Fields["OpName"].Value = Globals_Renamed.arOpName[num4];
						goto IL_0215;
						IL_0215:
						num = 25;
						recordset.Fields["PVop"].Value = Globals_Renamed.arOpPv[num4];
						goto IL_023b;
						IL_023b:
						num = 26;
						recordset.Fields["ProcessDesc"].Value = Globals_Renamed.arPDesc[num4];
						goto IL_025c;
						IL_025c:
						num = 27;
						recordset.Fields["PSInto"].Value = Globals_Renamed.arPSInto1[num4];
						goto IL_027d;
						IL_027d:
						num = 28;
						recordset.Fields["PSIntoOther"].Value = Globals_Renamed.arPSInto2[num4];
						goto IL_029e;
						IL_029e:
						num = 29;
						recordset.Fields["PSOut"].Value = Globals_Renamed.arPSOut1[num4];
						goto IL_02bf;
						IL_02bf:
						num = 30;
						recordset.Fields["PSOutOther"].Value = Globals_Renamed.arPSOut2[num4];
						goto IL_02e0;
						IL_02e0:
						num = 31;
						recordset.Fields["PSIn"].Value = Globals_Renamed.arPSIn1[num4];
						goto IL_0301;
						IL_0301:
						num = 32;
						recordset.Fields["PSInOther"].Value = Globals_Renamed.arPSIn2[num4];
						goto IL_0322;
						IL_0322:
						num = 33;
						recordset.Fields["NoPrev"].Value = Globals_Renamed.arNoPre[num4];
						goto IL_0348;
						IL_0348:
						num = 34;
						recordset.Fields["OpType"].Value = Globals_Renamed.arOpBorC[num4];
						goto IL_036e;
						IL_036e:
						num = 35;
						recordset.Fields["IoE"].Value = Globals_Renamed.arOpIoE[num4];
						goto IL_0394;
						IL_0394:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_039d;
						IL_039d:
						num = 37;
						recordset.Fields["MassBalDisc1"].Value = Globals_Renamed.arOpMassBalDisc[0, num4];
						goto IL_03c8;
						IL_03c8:
						num = 38;
						recordset.Fields["MassBalDisc2"].Value = Globals_Renamed.arOpMassBalDisc[1, num4];
						goto IL_03f3;
						IL_03f3:
						num = 39;
						recordset.Fields["OpNumWorkers"].Value = Globals_Renamed.arMiscOpParms[0, num4];
						goto IL_041e;
						IL_041e:
						ProjectData.ClearProjectError();
						num3 = 3;
						goto IL_0426;
						IL_0426:
						num = 41;
						recordset.Fields["NumWorkersExpDaysPerYear"].Value = Globals_Renamed.arMiscOpParms[1, num4];
						goto IL_0451;
						IL_0451:
						num = 42;
						recordset.Fields["Basis"].Value = Globals_Renamed.arBasis[num4];
						goto IL_0472;
						IL_0472:
						num = 43;
						recordset.Fields["WaterRelBasis"].Value = Globals_Renamed.arWaterBasis[num4];
						goto IL_0493;
						IL_0493:
						num = 44;
						recordset.Fields["AddNotesRelSummary"].Value = Globals_Renamed.arRelAddNotes[num4];
						goto IL_04b4;
						IL_04b4:
						num = 45;
						recordset.Fields["AddNotesExpSummary"].Value = Globals_Renamed.arExpAddNotes[num4];
						goto IL_04d5;
						IL_04d5:
						num = 46;
						recordset.Fields["NWdefault"].Value = Globals_Renamed.arOpNumWorkers[0, num4];
						goto IL_0500;
						IL_0500:
						num = 47;
						recordset.Fields["NWestimated"].Value = Globals_Renamed.arOpNumWorkers[1, num4];
						goto IL_052b;
						IL_052b:
						num = 48;
						recordset.Fields["NWbasis"].Value = Globals_Renamed.arOpNumWorkersBasis[num4] + " ";
						goto IL_0556;
						IL_0556:
						num = 49;
						recordset.Fields["NWbasisEnabled"].Value = Globals_Renamed.arOpNumWorkersBasisEnabled[num4];
						goto IL_057c;
						IL_057c:
						num = 50;
						recordset.Fields["InhExpBasis"].Value = Globals_Renamed.arInhalationBasis[num4];
						goto IL_059d;
						IL_059d:
						num = 51;
						recordset.Fields["DerExpBasis"].Value = Globals_Renamed.arDermalBasis[num4];
						goto IL_05be;
						IL_05be:
						num = 52;
						recordset.Fields["OpGssImport"].Value = Globals_Renamed.arOpNeedsMassBalance[num4];
						goto IL_05e4;
						end_IL_0001:
						break;
					}
				}
			}
			catch (object obj2) when (obj2 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0001_dispatch = 6667;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_2:
			break;
		}
		object result = obj;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private static bool Save_Exp()
	{
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0872: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num2 = default(int);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
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
					clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
					Recordset recordset2 = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
					Recordset recordset3 = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
					Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					ProjectData.ClearProjectError();
					num2 = 2;
					command.ActiveConnection = Common.DataConn;
					command.CommandText = "pqryDeleteExpModels";
					command.CommandType = CommandTypeEnum.adCmdStoredProc;
					command.Parameters.Append(command.CreateParameter("pAssessID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, Globals_Renamed.gblAssessID));
					Command command2 = command;
					object RecordsAffected = Missing.Value;
					object Parameters = Missing.Value;
					command2.Execute(out RecordsAffected, ref Parameters);
					command.Parameters.Delete("pAssessID");
					recordset.CursorLocation = CursorLocationEnum.adUseServer;
					recordset.Open("SELECT * FROM ActExpModels WHERE AssessID=" + Conversions.ToString((int)Globals_Renamed.gblAssessID), Common.DataConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
					recordset2.CursorLocation = CursorLocationEnum.adUseClient;
					recordset2.Open("SELECT * FROM ActExpModParms WHERE ExpParmsAN=0", Common.DataConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
					recordset3.CursorLocation = CursorLocationEnum.adUseClient;
					recordset3.Open("SELECT * FROM ActExpModEst WHERE ExpParmsAN=0", Common.DataConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
					frmMain defInstance = frmMain.DefInstance;
					checked
					{
						short num3 = (short)(Globals_Renamed.intNumOps - 1);
						short num4 = 0;
						while (true)
						{
							short num5 = num4;
							short num6 = num3;
							if (num5 > num6)
							{
								break;
							}
							short num7 = 0;
							short num23;
							do
							{
								bool flag = false;
								short num8 = 0;
								short num22;
								do
								{
									if ((Globals_Renamed.arSelActType[num7, num4] > 0) & (Globals_Renamed.arExpModels[num8, num7, num4] > 0))
									{
										Globals_Renamed.intModIndex = (short)(Globals_Renamed.arExpModels[num8, num7, num4] - 1);
										if (Globals_Renamed.intModIndex > Information.UBound((Array)Globals_Renamed.arExpModType, 1))
										{
											Interaction.MsgBox((object)"intModIndex is greater then UBound(arExpModType)", (MsgBoxStyle)0, (object)null);
										}
										else if (Globals_Renamed.arExpModType[Globals_Renamed.intModIndex] > 0)
										{
											flag = true;
											recordset.AddNew(Missing.Value, Missing.Value);
											recordset.Fields["AssessID"].Value = Globals_Renamed.gblAssessID;
											recordset.Fields["AssOpID"].Value = num4;
											recordset.Fields["AssActID"].Value = num7;
											recordset.Fields["ExplModID"].Value = num8;
											recordset.Fields["ModelID"].Value = Globals_Renamed.arExpModType[Globals_Renamed.intModIndex];
											int num9 = Conversions.ToInteger(recordset.Fields["ExpParmsAN"].Value);
											recordset.Fields["OutputOn1"].Value = Globals_Renamed.arExpModOutputOn[0, Globals_Renamed.intModIndex];
											recordset.Fields["OutputOn2"].Value = Globals_Renamed.arExpModOutputOn[1, Globals_Renamed.intModIndex];
											recordset.Fields["Char1"].Value = Globals_Renamed.arExpModChar[0, Globals_Renamed.intModIndex];
											recordset.Fields["Char2"].Value = Globals_Renamed.arExpModChar[1, Globals_Renamed.intModIndex];
											recordset.Fields["Basis"].Value = Globals_Renamed.arExpModBasis[Globals_Renamed.intModIndex];
											recordset.Fields["ChemStateID"].Value = Globals_Renamed.arExpModChmSt[Globals_Renamed.intModIndex];
											recordset.Fields["inhUncertainty"].Value = Globals_Renamed.arExpModUncertainty[Globals_Renamed.intModIndex];
											recordset.Fields["ModelStatus"].Value = Globals_Renamed.arExpModStatus[Globals_Renamed.intModIndex];
											if (num8 == 1)
											{
												recordset.Fields["InhClass"].Value = Globals_Renamed.arExpModInhRC[0, Globals_Renamed.intModIndex];
												recordset.Fields["InhClassNotes"].Value = Globals_Renamed.arExpModInhRC[1, Globals_Renamed.intModIndex];
												recordset.Fields["InhClassExpLevel"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(Globals_Renamed.arExpModInhRC[2, Globals_Renamed.intModIndex], "Yes", false) == 0, (object)1, (object)0));
												if (Operators.CompareString(frmMain.DefInstance.lblSATHR.Text, "", false) == 0)
												{
													recordset.Fields["InhClassHazRating"].Value = 0;
													recordset.Fields["InhClassInhMon"].Value = 0;
												}
												else
												{
													recordset.Fields["InhClassHazRating"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(Globals_Renamed.arExpModInhRC[3, Globals_Renamed.intModIndex], "Yes", false) == 0, (object)1, (object)0));
													if (Operators.CompareString(Globals_Renamed.arExpModInhRC[4, Globals_Renamed.intModIndex], "Yes", false) == 0)
													{
														recordset.Fields["InhClassInhMon"].Value = 1;
													}
													else
													{
														recordset.Fields["InhClassInhMon"].Value = 0;
													}
												}
											}
											recordset.Update(Missing.Value, Missing.Value);
											short num10 = 0;
											short num21;
											do
											{
												short num11 = 1;
												short num12;
												do
												{
													if (Globals_Renamed.arExpModParmsT[num10, num11, Globals_Renamed.intModIndex] > 0)
													{
														recordset2.AddNew(Missing.Value, Missing.Value);
														recordset2.Fields["ExpParmsAN"].Value = num9;
														recordset2.Fields["OutputID"].Value = num10;
														recordset2.Fields["ParmID"].Value = num11;
														switch (num11)
														{
														case 59:
														case 61:
														case 75:
														case 76:
														case 77:
														case 78:
														case 92:
															if (Globals_Renamed.arExpModParmsVC[num10, num11, Globals_Renamed.intModIndex] == 999)
															{
																recordset2.Fields["ParmValue"].Value = Globals_Renamed.arExpModParmsV[num10, num11, Globals_Renamed.intModIndex];
																break;
															}
															if (Globals_Renamed.arExpModParmsVC[num10, num11, Globals_Renamed.intModIndex] == 998)
															{
																recordset2.Fields["ParmValue"].Value = Globals_Renamed.arExpModParmsV[num10, num11, Globals_Renamed.intModIndex];
																break;
															}
															if ((Globals_Renamed.arExpModParmsVC[num10, num11, Globals_Renamed.intModIndex] > 0) & (Globals_Renamed.arExpModParmsVC[num10, num11, Globals_Renamed.intModIndex] < 162))
															{
																recordset2.Fields["ParmValue"].Value = Globals_Renamed.arExpModParmsV[num10, Globals_Renamed.arExpModParmsVC[num10, num11, Globals_Renamed.intModIndex], Globals_Renamed.intModIndex];
																break;
															}
															recordset2.Fields["ParmValue"].Value = Globals_Renamed.arExpModParmsVC[num10, num11, Globals_Renamed.intModIndex];
															if (!flag2)
															{
																flag2 = true;
																Interaction.Beep();
																Interaction.MsgBox((object)"An error occured while saving the exposure data in the assessment. The assessment was not completely saved. Please contact Technical Support.", (MsgBoxStyle)16, (object)null);
															}
															break;
														default:
															recordset2.Fields["ParmValue"].Value = Globals_Renamed.arExpModParmsV[num10, num11, Globals_Renamed.intModIndex];
															break;
														}
														recordset2.Fields["ParmType"].Value = Globals_Renamed.arExpModParmsT[num10, num11, Globals_Renamed.intModIndex];
														recordset2.Fields["ParmVC"].Value = Globals_Renamed.arExpModParmsVC[num10, num11, Globals_Renamed.intModIndex];
														recordset2.Update(Missing.Value, Missing.Value);
													}
													num11 = (short)unchecked(num11 + 1);
													num12 = num11;
													num6 = 162;
												}
												while (num12 <= num6);
												if (Globals_Renamed.arExpModOutputOn[num10, Globals_Renamed.intModIndex] == 1)
												{
													recordset3.AddNew(Missing.Value, Missing.Value);
													recordset3.Fields["ExpParmsAN"].Value = num9;
													recordset3.Fields["OutputID"].Value = num10;
													recordset3.Fields["Freq"].Value = Globals_Renamed.arExpModEst[num10, 2, Globals_Renamed.intModIndex];
													num11 = 4;
													short num17;
													do
													{
														recordset3.Fields[num11 - 1].Value = Globals_Renamed.arExpModEst[num10, num11, Globals_Renamed.intModIndex];
														Field field = recordset3.Fields[num11 + 3];
														float[,,] arExpModEst = Globals_Renamed.arExpModEst;
														float[,,] array = arExpModEst;
														int num13 = num10;
														int num14 = num13;
														int num15 = num11;
														int num16 = num15;
														int Enumber = Globals_Renamed.intModIndex;
														Parameters = array[num14, num16, Enumber];
														string value = ChemStrX.ShowInSciNot1digit(ref Parameters);
														arExpModEst[num13, num15, Enumber] = Conversions.ToSingle(Parameters);
														field.Value = value;
														num11 = (short)unchecked(num11 + 1);
														num17 = num11;
														num6 = 7;
													}
													while (num17 <= num6);
													num11 = 8;
													short num20;
													do
													{
														recordset3.Fields[num11 + 3].Value = Globals_Renamed.arExpModEst[num10, num11, Globals_Renamed.intModIndex];
														Field field2 = recordset3.Fields[num11 + 7];
														float[,,] arExpModEst = Globals_Renamed.arExpModEst;
														float[,,] array2 = arExpModEst;
														int Enumber = num10;
														int num18 = Enumber;
														int num15 = num11;
														int num19 = num15;
														int num13 = Globals_Renamed.intModIndex;
														Parameters = array2[num18, num19, num13];
														string value2 = ChemStrX.ShowInSciNot1digit(ref Parameters);
														arExpModEst[Enumber, num15, num13] = Conversions.ToSingle(Parameters);
														field2.Value = value2;
														num11 = (short)unchecked(num11 + 1);
														num20 = num11;
														num6 = 11;
													}
													while (num20 <= num6);
													recordset3.Fields["NSxNWexp"].Value = Globals_Renamed.arExpModEst[num10, 12, Globals_Renamed.intModIndex];
													recordset3.Update(Missing.Value, Missing.Value);
												}
												num10 = (short)unchecked(num10 + 1);
												num21 = num10;
												num6 = 1;
											}
											while (num21 <= num6);
										}
									}
									num8 = (short)unchecked(num8 + 1);
									num22 = num8;
									num6 = 1;
								}
								while (num22 <= num6);
								num7 = (short)unchecked(num7 + 1);
								num23 = num7;
								num6 = 24;
							}
							while (num23 <= num6);
							num4 = (short)unchecked(num4 + 1);
						}
						defInstance = null;
						recordset.Close();
						recordset2.Close();
						recordset = null;
						recordset2 = null;
						recordset3 = null;
						command = null;
						flag3 = true;
						goto end_IL_0001;
					}
				}
				case 3110:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						string Eobject = "DBFuncs.Bas";
						string Efunction = "Save_Exp";
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
				try0001_dispatch = 3110;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		bool result = flag3;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private static object Save_Chemicals()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		object obj = default(object);
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
					recordset.CursorLocation = CursorLocationEnum.adUseServer;
					recordset.Open("SELECT * FROM Chemicals WHERE AssessID=" + Conversions.ToString((int)Globals_Renamed.gblAssessID), Common.DataConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
					if (recordset.EOF)
					{
						recordset.AddNew(Missing.Value, Missing.Value);
						recordset.Fields["AssessID"].Value = Globals_Renamed.gblAssessID;
					}
					frmMain defInstance = frmMain.DefInstance;
					recordset.Fields["ChemicalName"].Value = defInstance.lblChemName.Text;
					recordset.Fields["CASNumber"].Value = defInstance.lblCas.Text;
					recordset.Fields["ChemCat"].Value = defInstance.lblChemCat.Text;
					recordset.Fields["TradeNames"].Value = defInstance.lblTradeNames.Text;
					recordset.Fields["MolFormula"].Value = defInstance.lblMF.Text;
					recordset.Fields["PVi"].Value = RuntimeHelpers.GetObjectValue(Common.MyNullCheck0Null(defInstance.lblPVi.Text));
					recordset.Fields["PVd"].Value = RuntimeHelpers.GetObjectValue(Common.MyNullCheck0Null(defInstance.lblPVd.Text));
					recordset.Fields["PV"].Value = RuntimeHelpers.GetObjectValue(Common.MyNullCheck0Null(defInstance.lblPV.Text));
					if (Versioned.IsNumeric((object)defInstance.lblPV.Text))
					{
						Field field = recordset.Fields["PVformatted"];
						Label lblPV = defInstance.lblPV;
						object pValue = lblPV.Text;
						string value = ChemStrX.ShowInSciNotPV(ref pValue);
						lblPV.Text = Conversions.ToString(pValue);
						field.Value = value;
					}
					else
					{
						recordset.Fields["PVformatted"].Value = "";
					}
					recordset.Fields["VP"].Value = RuntimeHelpers.GetObjectValue(Common.MyNullCheck0Null(defInstance.lblVP.Text));
					if (Versioned.IsNumeric((object)defInstance.lblVP.Text))
					{
						Field field2 = recordset.Fields["VPformatted"];
						object pValue = RuntimeHelpers.GetObjectValue(Common.MyNullCheck0(defInstance.lblVP.Text));
						field2.Value = ChemStrX.ShowInSciNot1digit(ref pValue);
					}
					else
					{
						recordset.Fields["VPformatted"].Value = "";
					}
					recordset.Fields["VPTemp"].Value = RuntimeHelpers.GetObjectValue(Common.MyNullCheck0Null(defInstance.lblVPTemp.Text));
					recordset.Fields["mw"].Value = RuntimeHelpers.GetObjectValue(Common.MyNullCheck0Null(defInstance.lblMW.Text));
					recordset.Fields["DChem"].Value = RuntimeHelpers.GetObjectValue(Common.MyNullCheck0Null(defInstance.lblDchem.Text));
					recordset.Fields["DChemTemp"].Value = RuntimeHelpers.GetObjectValue(Common.MyNullCheck0Null(defInstance.lblDchemTemp.Text));
					recordset.Fields["Solubility"].Value = defInstance.lblSol.Text;
					recordset.Fields["SolTemp"].Value = RuntimeHelpers.GetObjectValue(Common.MyNullCheck0Null(defInstance.lblSolTemp.Text));
					recordset.Fields["MP"].Value = RuntimeHelpers.GetObjectValue(Common.MyNullCheck0Null(defInstance.lblMP.Text));
					recordset.Fields["BP"].Value = RuntimeHelpers.GetObjectValue(Common.MyNullCheck0Null(defInstance.lblBP.Text));
					recordset.Fields["TypeOfNotice"].Value = defInstance.lblNoticeType.Text;
					recordset.Fields["Lt500"].Value = RuntimeHelpers.GetObjectValue(Common.MyNullCheck0Null(defInstance.lblLT500.Text));
					recordset.Fields["Lt1000"].Value = RuntimeHelpers.GetObjectValue(Common.MyNullCheck0Null(defInstance.lblLT1000.Text));
					recordset.Fields["EndUseMemo"].Value = defInstance.txtChemGenUse.Text;
					recordset.Fields["QualifierYX"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(defInstance.lblChemQualYX.Text, "Yes", false) == 0, (object)1, (object)0));
					recordset.Fields["QualifierNX"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(defInstance.lblChemQualNX.Text, "Yes", false) == 0, (object)1, (object)0));
					recordset.Fields["QualifierOther"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(defInstance.lblChemQualOther.Text, "Yes", false) == 0, (object)1, (object)0));
					recordset.Fields["QualifierOtherDesc"].Value = Common.MyNullCheck(defInstance.lblChemQualOtherDesc.Text);
					recordset.Fields["QualifierBindingPV"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(defInstance.lblBindingPV.Text, "Yes", false) == 0, (object)1, (object)0));
					recordset.Fields["SubPV"].Value = RuntimeHelpers.GetObjectValue(Common.MyNullCheck0(defInstance.lblTotalSubPV.Text));
					recordset.Fields["SubPVi"].Value = RuntimeHelpers.GetObjectValue(Common.MyNullCheck0(defInstance.lblImportedSubPV.Text));
					recordset.Fields["SubPVd"].Value = RuntimeHelpers.GetObjectValue(Common.MyNullCheck0(defInstance.lblDomesticSubPV.Text));
					if (Versioned.IsNumeric((object)defInstance.lblTotalSubPV.Text))
					{
						Field field3 = recordset.Fields["SubPVformatted"];
						Label lblPV = defInstance.lblTotalSubPV;
						object pValue = lblPV.Text;
						string value2 = ChemStrX.ShowInSciNotPV(ref pValue);
						lblPV.Text = Conversions.ToString(pValue);
						field3.Value = value2;
					}
					else
					{
						recordset.Fields["SubPVformatted"].Value = "";
					}
					recordset.Fields["QualifierCOS"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(defInstance.lblCOS.Text, "Yes", false) == 0, (object)1, (object)0));
					recordset.Update(Missing.Value, Missing.Value);
					defInstance = null;
					recordset.Close();
					recordset = null;
					obj = true;
					goto end_IL_0001;
				}
				case 1989:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						string Eobject = "DBFuncs.Bas";
						string Efunction = "Save_Chemicals";
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
			catch (object obj2) when (obj2 is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0001_dispatch = 1989;
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

	public static bool SaveDB()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
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
					if (!Save_GenInfo())
					{
						Interaction.MsgBox((object)"An error was encountered while saving General Information in the assessment. Please contact technical support.", (MsgBoxStyle)16, (object)"Assessment was not successfully saved!");
						goto end_IL_0001;
					}
					if (Operators.ConditionalCompareObjectEqual(Save_ContRpts(), (object)false, false))
					{
						Interaction.MsgBox((object)"An error was encountered while saving Contact Reports in the assessment. Please contact technical support.", (MsgBoxStyle)16, (object)"Assessment was not successfully saved!");
						goto end_IL_0001;
					}
					if (Operators.ConditionalCompareObjectEqual(Save_Chemicals(), (object)false, false))
					{
						Interaction.MsgBox((object)"An error was encountered while saving Chemical Information in the assessment. Please contact technical support.", (MsgBoxStyle)16, (object)"Assessment was not successfully saved!");
						goto end_IL_0001;
					}
					if (Operators.ConditionalCompareObjectEqual(Save_Ops(), (object)false, false))
					{
						Interaction.MsgBox((object)"An error was encountered while saving Operation Information in the assessment. Please contact technical support.", (MsgBoxStyle)16, (object)"Assessment was not successfully saved!");
						goto end_IL_0001;
					}
					if (!Save_Rel())
					{
						Interaction.MsgBox((object)"An error was encountered while saving Release Information in the assessment. Please contact technical support.", (MsgBoxStyle)16, (object)"Assessment was not successfully saved!");
						goto end_IL_0001;
					}
					if (!Save_Exp())
					{
						Interaction.MsgBox((object)"An error was encountered while saving Exposure Information in the assessment. Please contact technical support.", (MsgBoxStyle)16, (object)"Assessment was not successfully saved!");
						goto end_IL_0001;
					}
					if (Operators.ConditionalCompareObjectEqual(Save_OtherData(), (object)false, false))
					{
						Interaction.MsgBox((object)"An error was encountered while saving Other Information in the assessment. Please contact technical support.", (MsgBoxStyle)16, (object)"Assessment was not successfully saved!");
						goto end_IL_0001;
					}
					if (!Save_Irer())
					{
						Interaction.MsgBox((object)"An error was encountered while saving IRER Report Information in the assessment. Please contact technical support.", (MsgBoxStyle)16, (object)"Assessment was not successfully saved!");
						goto end_IL_0001;
					}
					if (!Save_RevisionHistory())
					{
						Interaction.MsgBox((object)"An error was encountered while saving Revision History Information in the assessment. Please contact technical support.", (MsgBoxStyle)16, (object)"Assessment was not successfully saved!");
						goto end_IL_0001;
					}
					Globals_Renamed.gblIWasChanged = false;
					flag = true;
					goto end_IL_0001;
				case 517:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						string Eobject = "DBFuncs.Bas";
						string Efunction = "SaveDB";
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
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private static bool Save_GenInfo()
	{
		//IL_0610: Unknown result type (might be due to invalid IL or missing references)
		//IL_0616: Invalid comparison between Unknown and I4
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0695: Invalid comparison between Unknown and I4
		//IL_092d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0933: Invalid comparison between Unknown and I4
		int try0001_dispatch = -1;
		int num = default(int);
		Recordset recordset = default(Recordset);
		int num2 = default(int);
		int num3 = default(int);
		frmMain frmMain2 = default(frmMain);
		bool flag = default(bool);
		Command command = default(Command);
		short num5 = default(short);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				string Eobject;
				string Efunction;
				ErrObject val;
				int Enumber;
				ErrObject val2;
				string Edescription;
				bool Econtact;
				int num4;
				Guid clsid;
				Command command2;
				object RecordsAffected;
				object Parameters;
				switch (try0001_dispatch)
				{
				default:
					num = 1;
					clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
					recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					goto IL_0023;
				case 5320:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 2:
							break;
						case 1:
							goto IL_1246;
						default:
							goto end_IL_0001;
						}
						goto IL_11c4;
					}
					IL_11a7:
					frmMain2 = null;
					goto IL_11aa;
					IL_11aa:
					num = 151;
					recordset = null;
					goto IL_11b3;
					IL_118f:
					num = 149;
					Globals_Renamed.gblPreviousYear = frmMain2.lblFiscalYear.Text;
					goto IL_11a7;
					IL_11c4:
					num = 154;
					Eobject = "DBFuncs.Bas";
					Efunction = "Save_GenInfo";
					val = Information.Err();
					Enumber = val.Number;
					val2 = Information.Err();
					Edescription = val2.Description;
					Econtact = true;
					Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
					val2.Description = Edescription;
					val.Number = Enumber;
					goto IL_1220;
					IL_1220:
					num = 155;
					ProjectData.ClearProjectError();
					if (num2 == 0)
					{
						throw ProjectData.CreateProjectError(-2146828268);
					}
					goto IL_1246;
					IL_11b3:
					num = 152;
					flag = true;
					goto end_IL_0001_2;
					IL_1246:
					num4 = num2 + 1;
					num2 = 0;
					switch (num4)
					{
					case 1:
						break;
					case 2:
						goto IL_0023;
					case 3:
						goto IL_002b;
					case 4:
						goto IL_0036;
					case 5:
						goto IL_005c;
					case 6:
						goto IL_006e;
					case 7:
						goto IL_0078;
					case 8:
						goto IL_009b;
					case 9:
						goto IL_00ab;
					case 10:
						goto IL_00bc;
					case 11:
						goto IL_00c9;
					case 12:
						goto IL_00e8;
					case 13:
						goto IL_0100;
					case 14:
						goto IL_0123;
					case 15:
					case 16:
						goto IL_0148;
					case 17:
						goto IL_0153;
					case 18:
						goto IL_0177;
					case 19:
						goto IL_01a2;
					case 20:
						goto IL_01ec;
					case 21:
						goto IL_0236;
					case 22:
						goto IL_0261;
					case 23:
						goto IL_0296;
					case 24:
						goto IL_02c9;
					case 25:
						goto IL_02e6;
					case 26:
						goto IL_02f4;
					case 28:
						goto IL_0324;
					case 29:
						goto IL_0329;
					case 32:
						goto IL_034b;
					case 33:
						goto IL_0350;
					case 27:
					case 30:
					case 31:
					case 34:
					case 35:
						goto IL_0370;
					case 36:
						goto IL_03a5;
					case 37:
						goto IL_03d5;
					case 39:
						goto IL_0403;
					case 40:
						goto IL_0408;
					case 38:
					case 41:
					case 42:
						goto IL_0428;
					case 43:
						goto IL_044e;
					case 44:
						goto IL_0474;
					case 45:
						goto IL_04a0;
					case 46:
						goto IL_04cc;
					case 47:
						goto IL_04f2;
					case 48:
						goto IL_0518;
					case 49:
						goto IL_053e;
					case 50:
						goto IL_055f;
					case 51:
						goto IL_057d;
					case 52:
						goto IL_05b0;
					case 54:
						goto IL_05db;
					case 55:
						goto IL_05e0;
					case 56:
						goto IL_05ea;
					case 57:
						goto IL_061e;
					case 58:
					case 59:
						goto IL_0644;
					case 62:
						goto IL_0670;
					case 63:
						goto IL_0675;
					case 64:
						goto IL_067f;
					case 65:
						goto IL_069d;
					case 66:
						goto IL_06c2;
					case 68:
						goto IL_06ea;
					case 69:
						goto IL_06ef;
					case 53:
					case 60:
					case 61:
					case 67:
					case 70:
					case 71:
					case 72:
						goto IL_0710;
					case 73:
						goto IL_073c;
					case 74:
						goto IL_0768;
					case 75:
						goto IL_0794;
					case 76:
						goto IL_07c0;
					case 77:
						goto IL_07ec;
					case 78:
						goto IL_0818;
					case 79:
						goto IL_0844;
					case 80:
						goto IL_0870;
					case 81:
						goto IL_08a0;
					case 82:
						goto IL_08c6;
					case 83:
						goto IL_08ec;
					case 84:
						goto IL_0912;
					case 85:
						goto IL_0951;
					case 86:
						goto IL_0977;
					case 87:
						goto IL_09a7;
					case 88:
						goto IL_09d7;
					case 89:
						goto IL_0a02;
					case 90:
						goto IL_0a37;
					case 91:
						goto IL_0a87;
					case 92:
						goto IL_0ad7;
					case 93:
						goto IL_0b27;
					case 94:
						goto IL_0b77;
					case 95:
						goto IL_0bc7;
					case 96:
						goto IL_0be2;
					case 98:
						goto IL_0c14;
					case 99:
						goto IL_0c19;
					case 97:
					case 100:
					case 101:
						goto IL_0c3a;
					case 102:
						goto IL_0c84;
					case 103:
						goto IL_0cce;
					case 104:
						goto IL_0d14;
					case 105:
						goto IL_0d38;
					case 107:
						goto IL_0d59;
					case 108:
						goto IL_0d5e;
					case 106:
					case 109:
					case 110:
						goto IL_0d85;
					case 111:
						goto IL_0dab;
					case 112:
						goto IL_0dd1;
					case 113:
						goto IL_0df5;
					case 115:
						goto IL_0e17;
					case 116:
						goto IL_0e3b;
					case 118:
						goto IL_0e5d;
					case 119:
						goto IL_0e62;
					case 114:
					case 117:
					case 120:
					case 121:
						goto IL_0e82;
					case 122:
						goto IL_0eac;
					case 124:
						goto IL_0ecd;
					case 125:
						goto IL_0ed2;
					case 123:
					case 126:
					case 127:
						goto IL_0eff;
					case 128:
						goto IL_0f29;
					case 130:
						goto IL_0f4d;
					case 131:
						goto IL_0f55;
					case 129:
					case 132:
					case 133:
						goto IL_0f85;
					case 134:
						goto IL_0fb2;
					case 136:
						goto IL_0fd6;
					case 137:
						goto IL_0fde;
					case 135:
					case 138:
					case 139:
						goto IL_100e;
					case 140:
						goto IL_1044;
					case 141:
						goto IL_107a;
					case 142:
						goto IL_10a1;
					case 143:
						goto IL_10d2;
					case 144:
						goto IL_1103;
					case 145:
						goto IL_111b;
					case 146:
						goto IL_1129;
					case 147:
						goto IL_1150;
					case 148:
						goto IL_1177;
					case 149:
						goto IL_118f;
					case 150:
						goto IL_11a7;
					case 151:
						goto IL_11aa;
					case 152:
						goto IL_11b3;
					case 154:
						goto IL_11c4;
					case 155:
						goto IL_1220;
					default:
						goto end_IL_0001;
					case 153:
					case 156:
						goto end_IL_0001_2;
					}
					goto default;
					IL_0023:
					ProjectData.ClearProjectError();
					num3 = 2;
					goto IL_002b;
					IL_002b:
					num = 3;
					recordset.CursorLocation = CursorLocationEnum.adUseServer;
					goto IL_0036;
					IL_0036:
					num = 4;
					recordset.Open("SELECT * FROM Assessments WHERE AssessID=" + Conversions.ToString((int)Globals_Renamed.gblAssessID), Common.DataConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
					goto IL_005c;
					IL_005c:
					num = 5;
					if (recordset.EOF)
					{
						goto IL_006e;
					}
					goto IL_0148;
					IL_006e:
					num = 6;
					recordset.Close();
					goto IL_0078;
					IL_0078:
					num = 7;
					clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
					command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					goto IL_009b;
					IL_009b:
					num = 8;
					command.ActiveConnection = Common.DataConn;
					goto IL_00ab;
					IL_00ab:
					num = 9;
					command.CommandText = "INSERT INTO ASSESSMENTS (EPAIDNumber) VALUES('_')";
					goto IL_00bc;
					IL_00bc:
					num = 10;
					command.CommandType = CommandTypeEnum.adCmdText;
					goto IL_00c9;
					IL_00c9:
					num = 11;
					command2 = command;
					RecordsAffected = Missing.Value;
					Parameters = Missing.Value;
					command2.Execute(out RecordsAffected, ref Parameters);
					goto IL_00e8;
					IL_00e8:
					num = 12;
					recordset.Open("SELECT * FROM Assessments WHERE EPAIDNumber='_'", Common.DataConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
					goto IL_0100;
					IL_0100:
					num = 13;
					Globals_Renamed.gblAssessID = Conversions.ToShort(recordset.Fields["AssessID"].Value);
					goto IL_0123;
					IL_0123:
					num = 14;
					recordset.Fields["crDate"].Value = Globals_Renamed.gblCRdate;
					goto IL_0148;
					IL_0148:
					num = 16;
					frmMain2 = frmMain.DefInstance;
					goto IL_0153;
					IL_0153:
					num = 17;
					recordset.Fields["crDate"].Value = Globals_Renamed.gblCRdate;
					goto IL_0177;
					IL_0177:
					num = 18;
					recordset.Fields["EPAIDNumber"].Value = Common.MyNullCheck(frmMain2.lblID.Text);
					goto IL_01a2;
					IL_01a2:
					num = 19;
					recordset.Fields["CBI"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(frmMain2.lblCBI.Text, "Yes", false) == 0, (object)1, (object)0));
					goto IL_01ec;
					IL_01ec:
					num = 20;
					recordset.Fields["ConsolidatedCase"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(frmMain2.lblConsCase.Text, "Yes", false) == 0, (object)1, (object)0));
					goto IL_0236;
					IL_0236:
					num = 21;
					recordset.Fields["ConsolidatedCaseText"].Value = Common.MyNullCheck(frmMain2.txtConsCase.Text);
					goto IL_0261;
					IL_0261:
					num = 22;
					recordset.Fields["AssessType"].Value = RuntimeHelpers.GetObjectValue(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(((Control)frmMain2.lblAssessType).Tag)));
					goto IL_0296;
					IL_0296:
					num = 23;
					if (Operators.ConditionalCompareObjectGreater(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(((Control)frmMain2.lblAssessType).Tag)), (object)900, false))
					{
						goto IL_02c9;
					}
					goto IL_034b;
					IL_02c9:
					num = 24;
					num5 = checked((short)Strings.InStr(frmMain2.lblAssessType.Text, ":", (CompareMethod)0));
					goto IL_02e6;
					IL_02e6:
					num = 25;
					if (num5 > 0)
					{
						goto IL_02f4;
					}
					goto IL_0324;
					IL_02f4:
					num = 26;
					recordset.Fields["TypeOther"].Value = Strings.Mid(frmMain2.lblAssessType.Text, checked(num5 + 2));
					goto IL_0370;
					IL_0324:
					num = 28;
					goto IL_0329;
					IL_0329:
					num = 29;
					recordset.Fields["TypeOther"].Value = "";
					goto IL_0370;
					IL_034b:
					num = 32;
					goto IL_0350;
					IL_0350:
					num = 33;
					recordset.Fields["TypeOther"].Value = "";
					goto IL_0370;
					IL_0370:
					num = 35;
					recordset.Fields["AssessStatus"].Value = RuntimeHelpers.GetObjectValue(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(((Control)frmMain2.lblStatus).Tag)));
					goto IL_03a5;
					IL_03a5:
					num = 36;
					if (Operators.ConditionalCompareObjectGreater(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(((Control)frmMain2.lblStatus).Tag)), (object)900, false))
					{
						goto IL_03d5;
					}
					goto IL_0403;
					IL_03d5:
					num = 37;
					recordset.Fields["StatusOther"].Value = Strings.Mid(frmMain2.lblStatus.Text, 8);
					goto IL_0428;
					IL_0403:
					num = 39;
					goto IL_0408;
					IL_0408:
					num = 40;
					recordset.Fields["StatusOther"].Value = "";
					goto IL_0428;
					IL_0428:
					num = 42;
					recordset.Fields["FiscalYear"].Value = frmMain2.lblFiscalYear.Text;
					goto IL_044e;
					IL_044e:
					num = 43;
					recordset.Fields["Company"].Value = frmMain2.lblCoName.Text;
					goto IL_0474;
					IL_0474:
					num = 44;
					recordset.Fields["Address1"].Value = frmMain2.lblAddr[(short)0].Text;
					goto IL_04a0;
					IL_04a0:
					num = 45;
					recordset.Fields["Address2"].Value = frmMain2.lblAddr[(short)1].Text;
					goto IL_04cc;
					IL_04cc:
					num = 46;
					recordset.Fields["City"].Value = frmMain2.lblCity.Text;
					goto IL_04f2;
					IL_04f2:
					num = 47;
					recordset.Fields["State"].Value = frmMain2.lblState.Text;
					goto IL_0518;
					IL_0518:
					num = 48;
					recordset.Fields["Zip"].Value = frmMain2.lblZip.Text;
					goto IL_053e;
					IL_053e:
					num = 49;
					recordset.Fields["ContactInfo"].Value = frmMain2.sContactInfoNotepad;
					goto IL_055f;
					IL_055f:
					num = 50;
					if (Information.IsDate((object)frmMain2.lblDate.Text))
					{
						goto IL_057d;
					}
					goto IL_0670;
					IL_057d:
					num = 51;
					if (Operators.CompareString(frmMain2.lblDate.Text, Strings.Format((object)DateAndTime.Today, Globals_Renamed.gblChemDateFormat), false) == 0)
					{
						goto IL_05b0;
					}
					goto IL_05db;
					IL_05b0:
					num = 52;
					recordset.Fields["SubmissionDate"].Value = frmMain2.lblDate.Text;
					goto IL_0710;
					IL_05db:
					num = 54;
					goto IL_05e0;
					IL_05e0:
					num = 55;
					Interaction.Beep();
					goto IL_05ea;
					IL_05ea:
					num = 56;
					if ((int)Interaction.MsgBox((object)("The Assessment Date (" + frmMain2.lblDate.Text + ") is not equal to today's date. Would you like ChemSTEER to use today's date?"), (MsgBoxStyle)36, (object)"Do you want to use today's date") == 6)
					{
						goto IL_061e;
					}
					goto IL_0644;
					IL_061e:
					num = 57;
					frmMain2.lblDate.Text = Strings.Format((object)DateAndTime.Today, Globals_Renamed.gblChemDateFormat);
					goto IL_0644;
					IL_0644:
					num = 59;
					recordset.Fields["SubmissionDate"].Value = frmMain2.lblDate.Text;
					goto IL_0710;
					IL_0670:
					num = 62;
					goto IL_0675;
					IL_0675:
					num = 63;
					Interaction.Beep();
					goto IL_067f;
					IL_067f:
					num = 64;
					if ((int)Interaction.MsgBox((object)"There is no Assessment Date specified for the Assessment. Would you like ChemSTEER to use today's date?", (MsgBoxStyle)36, (object)"Do you want to use today's date") == 6)
					{
						goto IL_069d;
					}
					goto IL_06ea;
					IL_069d:
					num = 65;
					frmMain2.lblDate.Text = Strings.Format((object)DateAndTime.Today, Globals_Renamed.gblChemDateFormat);
					goto IL_06c2;
					IL_06c2:
					num = 66;
					recordset.Fields["SubmissionDate"].Value = frmMain2.lblDate.Text;
					goto IL_0710;
					IL_06ea:
					num = 68;
					goto IL_06ef;
					IL_06ef:
					num = 69;
					recordset.Fields["SubmissionDate"].Value = DBNull.Value;
					goto IL_0710;
					IL_0710:
					num = 72;
					recordset.Fields["Assessor1"].Value = frmMain2.lblName[(short)0].Text;
					goto IL_073c;
					IL_073c:
					num = 73;
					recordset.Fields["Assessor1Aff"].Value = frmMain2.lblAff[(short)0].Text;
					goto IL_0768;
					IL_0768:
					num = 74;
					recordset.Fields["Assessor1Phone"].Value = frmMain2.lblPhone[(short)0].Text;
					goto IL_0794;
					IL_0794:
					num = 75;
					recordset.Fields["Assessor1Email"].Value = frmMain2.lblEmail[(short)0].Text;
					goto IL_07c0;
					IL_07c0:
					num = 76;
					recordset.Fields["Assessor2"].Value = frmMain2.lblName[(short)1].Text;
					goto IL_07ec;
					IL_07ec:
					num = 77;
					recordset.Fields["Assessor2Aff"].Value = frmMain2.lblAff[(short)1].Text;
					goto IL_0818;
					IL_0818:
					num = 78;
					recordset.Fields["Assessor2Phone"].Value = frmMain2.lblPhone[(short)1].Text;
					goto IL_0844;
					IL_0844:
					num = 79;
					recordset.Fields["Assessor2Email"].Value = frmMain2.lblEmail[(short)1].Text;
					goto IL_0870;
					IL_0870:
					num = 80;
					recordset.Fields["NumContRpts"].Value = RuntimeHelpers.GetObjectValue(Common.MyNullCheck0(frmMain2.lblNumCR.Text));
					goto IL_08a0;
					IL_08a0:
					num = 81;
					recordset.Fields["AssessNotepad"].Value = frmMain2.txtRevNotes.Text;
					goto IL_08c6;
					IL_08c6:
					num = 82;
					recordset.Fields["P2considerations"].Value = frmMain2.txtP2Cons.Text;
					goto IL_08ec;
					IL_08ec:
					num = 83;
					recordset.Fields["P2recNotes"].Value = frmMain2.txtP2Rec.Text;
					goto IL_0912;
					IL_0912:
					num = 84;
					recordset.Fields["P2Rec"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf((int)frmMain2.chkp2rec.CheckState == 1, (object)1, (object)0));
					goto IL_0951;
					IL_0951:
					num = 85;
					recordset.Fields["Assumptions"].Value = frmMain2.txtAssumps.Text;
					goto IL_0977;
					IL_0977:
					num = 86;
					recordset.Fields["NumWorkersExposed"].Value = RuntimeHelpers.GetObjectValue(Common.MyNullCheck0(frmMain2.lblNumExp.Text));
					goto IL_09a7;
					IL_09a7:
					num = 87;
					recordset.Fields["NumWorkersExpEst"].Value = RuntimeHelpers.GetObjectValue(Common.MyNullCheck0(frmMain2.lblNumExpEst.Text));
					goto IL_09d7;
					IL_09d7:
					num = 88;
					recordset.Fields["NumWorkersExpEstBasis"].Value = Common.MyNullCheck(frmMain2.txtNumExpEstBasis.Text);
					goto IL_0a02;
					IL_0a02:
					num = 89;
					recordset.Fields["NumWorkersExpEstEnabled"].Value = RuntimeHelpers.GetObjectValue(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(((Control)frmMain2.txtNumExpEstBasis).Tag)));
					goto IL_0a37;
					IL_0a37:
					num = 90;
					recordset.Fields["NumWorkersCriteria"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(frmMain2.lblNumWMet[(short)0].Text, "Yes", false) == 0, (object)1, (object)0));
					goto IL_0a87;
					IL_0a87:
					num = 91;
					recordset.Fields["GT100WGT10"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(frmMain2.lblNumWMet[(short)1].Text, "Yes", false) == 0, (object)1, (object)0));
					goto IL_0ad7;
					IL_0ad7:
					num = 92;
					recordset.Fields["GT100W1to10"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(frmMain2.lblNumWMet[(short)2].Text, "Yes", false) == 0, (object)1, (object)0));
					goto IL_0b27;
					IL_0b27:
					num = 93;
					recordset.Fields["RoutineDermalGT250"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(frmMain2.lblNumWMet[(short)3].Text, "Yes", false) == 0, (object)1, (object)0));
					goto IL_0b77;
					IL_0b77:
					num = 94;
					recordset.Fields["ExpBased"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(frmMain2.lblNumWMet[(short)4].Text, "Yes", false) == 0, (object)1, (object)0));
					goto IL_0bc7;
					IL_0bc7:
					num = 95;
					if (Versioned.IsNumeric((object)frmMain2.lblExpBasedCriteria.Text))
					{
						goto IL_0be2;
					}
					goto IL_0c14;
					IL_0be2:
					num = 96;
					recordset.Fields["NumExpBasedCriteria"].Value = Conversions.ToShort(frmMain2.lblExpBasedCriteria.Text);
					goto IL_0c3a;
					IL_0c14:
					num = 98;
					goto IL_0c19;
					IL_0c19:
					num = 99;
					recordset.Fields["NumExpBasedCriteria"].Value = 0;
					goto IL_0c3a;
					IL_0c3a:
					num = 101;
					recordset.Fields["MSDSInc"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(frmMain2.lblMsdsInc.Text, "Yes", false) == 0, (object)1, (object)0));
					goto IL_0c84;
					IL_0c84:
					num = 102;
					recordset.Fields["LabelInc"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(frmMain2.lblMsdsLab.Text, "Yes", false) == 0, (object)1, (object)0));
					goto IL_0cce;
					IL_0cce:
					num = 103;
					recordset.Fields["CRSSdate"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDate((object)frmMain2.lblCRSSdate.Text), (object)frmMain2.lblCRSSdate.Text, (object)DBNull.Value));
					goto IL_0d14;
					IL_0d14:
					num = 104;
					if (Operators.CompareString(frmMain2.txtMiscCRSSinfo.Text, "Neat:   Mfg:   Proc/Form:   End Use:   ", false) == 0)
					{
						goto IL_0d38;
					}
					goto IL_0d59;
					IL_0d38:
					num = 105;
					recordset.Fields["MiscCRSSInfo"].Value = "";
					goto IL_0d85;
					IL_0d59:
					num = 107;
					goto IL_0d5e;
					IL_0d5e:
					num = 108;
					recordset.Fields["MiscCRSSInfo"].Value = frmMain2.txtMiscCRSSinfo.Text;
					goto IL_0d85;
					IL_0d85:
					num = 110;
					recordset.Fields["otherUses"].Value = frmMain2.txtOtherUses.Text;
					goto IL_0dab;
					IL_0dab:
					num = 111;
					recordset.Fields["OccExpRating"].Value = frmMain2.lblOccExpRating.Text;
					goto IL_0dd1;
					IL_0dd1:
					num = 112;
					if (Operators.CompareString(frmMain2.lblConsUse.Text, "Yes", false) == 0)
					{
						goto IL_0df5;
					}
					goto IL_0e17;
					IL_0df5:
					num = 113;
					recordset.Fields["ConsUse"].Value = 1;
					goto IL_0e82;
					IL_0e17:
					num = 115;
					if (Operators.CompareString(frmMain2.lblConsUse.Text, "No", false) == 0)
					{
						goto IL_0e3b;
					}
					goto IL_0e5d;
					IL_0e3b:
					num = 116;
					recordset.Fields["ConsUse"].Value = 0;
					goto IL_0e82;
					IL_0e5d:
					num = 118;
					goto IL_0e62;
					IL_0e62:
					num = 119;
					recordset.Fields["ConsUse"].Value = DBNull.Value;
					goto IL_0e82;
					IL_0e82:
					num = 121;
					if (Operators.CompareString(frmMain2.txtMsds[(short)0].Text, Globals_Renamed.gblMsdsGE, false) == 0)
					{
						goto IL_0eac;
					}
					goto IL_0ecd;
					IL_0eac:
					num = 122;
					recordset.Fields["MSDS_GenEq"].Value = "";
					goto IL_0eff;
					IL_0ecd:
					num = 124;
					goto IL_0ed2;
					IL_0ed2:
					num = 125;
					recordset.Fields["MSDS_GenEq"].Value = frmMain2.txtMsds[(short)0].Text;
					goto IL_0eff;
					IL_0eff:
					num = 127;
					if (Operators.CompareString(frmMain2.txtMsds[(short)1].Text, Globals_Renamed.gblMsdsResp, false) == 0)
					{
						goto IL_0f29;
					}
					goto IL_0f4d;
					IL_0f29:
					num = 128;
					recordset.Fields["MSDS_Resp"].Value = "";
					goto IL_0f85;
					IL_0f4d:
					num = 130;
					goto IL_0f55;
					IL_0f55:
					num = 131;
					recordset.Fields["MSDS_Resp"].Value = frmMain2.txtMsds[(short)1].Text;
					goto IL_0f85;
					IL_0f85:
					num = 133;
					if (Operators.CompareString(frmMain2.txtMsds[(short)2].Text, Globals_Renamed.gblMsdsHE, false) == 0)
					{
						goto IL_0fb2;
					}
					goto IL_0fd6;
					IL_0fb2:
					num = 134;
					recordset.Fields["MSDS_HE"].Value = "";
					goto IL_100e;
					IL_0fd6:
					num = 136;
					goto IL_0fde;
					IL_0fde:
					num = 137;
					recordset.Fields["MSDS_HE"].Value = frmMain2.txtMsds[(short)2].Text;
					goto IL_100e;
					IL_100e:
					num = 139;
					recordset.Fields["VPlow"].Value = RuntimeHelpers.GetObjectValue(Common.MyNullCheck0(frmMain.DefInstance.lblAVPlow.Text));
					goto IL_1044;
					IL_1044:
					num = 140;
					recordset.Fields["VPhigh"].Value = RuntimeHelpers.GetObjectValue(Common.MyNullCheck0(frmMain.DefInstance.lblAVPhigh.Text));
					goto IL_107a;
					IL_107a:
					num = 141;
					recordset.Fields["LastSaved"].Value = DateAndTime.Now;
					goto IL_10a1;
					IL_10a1:
					num = 142;
					frmMain.DefInstance.lblLastSaved.Text = Conversions.ToString(recordset.Fields["LastSaved"].Value);
					goto IL_10d2;
					IL_10d2:
					num = 143;
					recordset.Fields["LVE_PPE"].Value = Common.MyNullCheck(frmMain.DefInstance.txtLVEPPE.Text);
					goto IL_1103;
					IL_1103:
					num = 144;
					recordset.Update(Missing.Value, Missing.Value);
					goto IL_111b;
					IL_111b:
					num = 145;
					recordset.Close();
					goto IL_1129;
					IL_1129:
					num = 146;
					Globals_Renamed.gblPreviousType = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(((Control)frmMain2.lblAssessType).Tag)));
					goto IL_1150;
					IL_1150:
					num = 147;
					Globals_Renamed.gblPreviousStatus = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(((Control)frmMain2.lblStatus).Tag)));
					goto IL_1177;
					IL_1177:
					num = 148;
					Globals_Renamed.gblPreviousID = frmMain2.lblID.Text;
					goto IL_118f;
					end_IL_0001:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 5320;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_2:
			break;
		}
		bool result = flag;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static bool AssessmentIdentifiersChanged()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
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
					if (Globals_Renamed.gblAssessID != 0)
					{
						if (Operators.ConditionalCompareObjectNotEqual((object)Globals_Renamed.gblPreviousType, Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(((Control)frmMain.DefInstance.lblAssessType).Tag)), false))
						{
							flag = true;
						}
						if (Operators.ConditionalCompareObjectNotEqual((object)Globals_Renamed.gblPreviousStatus, Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(((Control)frmMain.DefInstance.lblStatus).Tag)), false))
						{
							flag = true;
						}
						if (Operators.CompareString(Globals_Renamed.gblPreviousYear, frmMain.DefInstance.lblFiscalYear.Text, false) != 0)
						{
							flag = true;
						}
						if (Operators.CompareString(Globals_Renamed.gblPreviousID, frmMain.DefInstance.lblID.Text, false) != 0)
						{
							flag = true;
						}
					}
					flag2 = flag;
					goto end_IL_0001;
				case 307:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						string Eobject = "DBFuncs.Bas";
						string Efunction = "AssessmentIdentifiersChanged";
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
				try0001_dispatch = 307;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		bool result = flag2;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static short DupAssessmentCheck()
	{
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num2 = default(int);
		short num3 = default(short);
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
					string text2;
					string text;
					if (Strings.Len(RuntimeHelpers.GetObjectValue(((Control)frmMain.DefInstance.lblAssessType).Tag)) > 0)
					{
						text = Conversions.ToString(Operators.ConcatenateObject((object)"AssessType=", ((Control)frmMain.DefInstance.lblAssessType).Tag));
						text2 = " AND ";
					}
					else
					{
						text = "isnull(AssessType)";
						text2 = " AND ";
					}
					if (Strings.Len(RuntimeHelpers.GetObjectValue(((Control)frmMain.DefInstance.lblStatus).Tag)) > 0)
					{
						text = Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(text + text2, "AssessStatus="), ((Control)frmMain.DefInstance.lblStatus).Tag));
						text2 = " AND ";
					}
					else
					{
						text = text + text2 + "isnull(AssessStatus)";
					}
					if (Strings.Len(frmMain.DefInstance.lblFiscalYear.Text) > 0)
					{
						text = text + text2 + "FiscalYear='" + frmMain.DefInstance.lblFiscalYear.Text + "'";
						text2 = " AND ";
					}
					else
					{
						text = text + text2 + "FiscalYear=''";
						text2 = " AND ";
					}
					if (Strings.Len(frmMain.DefInstance.lblID.Text) > 0)
					{
						string[] array = new string[5] { text, text2, "EPAIDNumber='", null, null };
						string[] array2 = array;
						string Eobject = frmMain.DefInstance.lblID.Text;
						array2[3] = Common.TrtSingleQuotes(ref Eobject);
						array[4] = "'";
						text = string.Concat(array);
						text2 = " AND ";
					}
					else
					{
						text = text + text2 + "EPAIDNumber=''";
						text2 = " AND ";
					}
					if (Strings.Len(text) > 0)
					{
						text = " WHERE " + text;
					}
					text = "SELECT AssessID FROM Assessments" + text;
					recordset.CursorLocation = CursorLocationEnum.adUseClient;
					recordset.Open(text, Common.DataConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
					num3 = (short)((!recordset.EOF) ? Conversions.ToShort(recordset.Fields[0].Value) : (-1));
					recordset.Close();
					recordset = null;
					goto end_IL_0001;
				}
				case 764:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						if (Information.Err().Number == 3061)
						{
							Cursor.Current = Cursors.Default;
							Interaction.Beep();
							Interaction.MsgBox((object)"The database you are trying to save the assessment into is an old version of the database that does not include the Tron table. You cannot use this database. Please select another. If you feel you received this message in error, please contact Technical Support.", (MsgBoxStyle)64, (object)"Invalid Database");
							goto end_IL_0001;
						}
						string Eobject = "DBFuncs.Bas";
						string Efunction = "DupAssessmentCheck";
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
				try0001_dispatch = 764;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		short result = num3;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static string CreateDefaultFileName()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		string text4 = default(string);
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
						object obj = new object[9] { ":", "\\", "/", "*", "?", '"', "<", ">", "|" };
						string text = frmMain.DefInstance.lblAssessType.Text;
						short num3 = 0;
						while (true)
						{
							short num4 = (short)Strings.InStr(text, Conversions.ToString(NewLateBinding.LateIndexGet(obj, new object[1] { num3 }, (string[])null)), (CompareMethod)0);
							switch (num4)
							{
							case 1:
								text = Strings.Mid(text, num4 + 1);
								break;
							default:
								text = Strings.Left(text, num4 - 1) + Strings.Mid(text, num4 + 1);
								break;
							case 0:
							{
								num3 = (short)unchecked(num3 + 1);
								short num5 = num3;
								short num6 = 8;
								if (num5 <= num6)
								{
									break;
								}
								string text2 = text;
								text = frmMain.DefInstance.lblStatus.Text;
								num3 = 0;
								while (true)
								{
									num4 = (short)Strings.InStr(text, Conversions.ToString(NewLateBinding.LateIndexGet(obj, new object[1] { num3 }, (string[])null)), (CompareMethod)0);
									switch (num4)
									{
									case 1:
										text = Strings.Mid(text, num4 + 1);
										break;
									default:
										text = Strings.Left(text, num4 - 1) + Strings.Mid(text, num4 + 1);
										break;
									case 0:
									{
										num3 = (short)unchecked(num3 + 1);
										short num7 = num3;
										num6 = 8;
										if (num7 <= num6)
										{
											break;
										}
										string text3 = text;
										text = frmMain.DefInstance.lblID.Text;
										num3 = 0;
										while (true)
										{
											num4 = (short)Strings.InStr(text, Conversions.ToString(NewLateBinding.LateIndexGet(obj, new object[1] { num3 }, (string[])null)), (CompareMethod)0);
											switch (num4)
											{
											case 1:
												text = Strings.Mid(text, num4 + 1);
												break;
											default:
												text = Strings.Left(text, num4 - 1) + Strings.Mid(text, num4 + 1);
												break;
											case 0:
											{
												num3 = (short)unchecked(num3 + 1);
												short num8 = num3;
												num6 = 8;
												if (num8 <= num6)
												{
													break;
												}
												if (Strings.Len(text3) > 0)
												{
													text3 = " (" + text3 + ")";
												}
												text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(string.Concat(text2 + frmMain.DefInstance.lblFiscalYear.Text, "-"), text), Interaction.IIf(Operators.CompareString(frmMain.DefInstance.lblConsCase.Text, "Yes", false) == 0, (object)"C", (object)"")), (object)text3));
												text4 = ((Operators.CompareString(text, "-", false) != 0) ? text : "*.mdb");
												goto end_IL_0001;
											}
											}
										}
									}
									}
								}
							}
							}
						}
					}
					case 848:
						num = -1;
						switch (num2)
						{
						case 2:
						{
							string Eobject = "DBFuncs.Bas";
							string Efunction = "CreateDefaultFileName";
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
				try0001_dispatch = 848;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		string result = text4;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private static bool Save_RevisionHistory()
	{
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
						Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
						Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						ProjectData.ClearProjectError();
						num2 = 2;
						recordset.CursorLocation = CursorLocationEnum.adUseServer;
						recordset.Open("SELECT * FROM RevisionHistory WHERE RevisionID=0", Common.DataConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
						recordset.AddNew(Missing.Value, Missing.Value);
						recordset.Fields["AssessID"].Value = Globals_Renamed.gblAssessID;
						recordset.Fields["EPAIDNumber"].Value = Common.MyNullCheck(frmMain.DefInstance.lblID.Text);
						recordset.Fields["CBI"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(frmMain.DefInstance.lblCBI.Text, "Yes", false) == 0, (object)1, (object)0));
						recordset.Fields["AssessType"].Value = RuntimeHelpers.GetObjectValue(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(((Control)frmMain.DefInstance.lblAssessType).Tag)));
						short num3;
						if (Operators.ConditionalCompareObjectGreater(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(((Control)frmMain.DefInstance.lblAssessType).Tag)), (object)900, false))
						{
							num3 = (short)Strings.InStr(frmMain.DefInstance.lblAssessType.Text, ":", (CompareMethod)0);
							if (num3 > 0)
							{
								recordset.Fields["TypeOther"].Value = Strings.Mid(frmMain.DefInstance.lblAssessType.Text, num3 + 2);
							}
							else
							{
								recordset.Fields["TypeOther"].Value = "";
							}
						}
						else
						{
							recordset.Fields["TypeOther"].Value = "";
						}
						recordset.Fields["AssessStatus"].Value = RuntimeHelpers.GetObjectValue(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(((Control)frmMain.DefInstance.lblStatus).Tag)));
						if (Operators.ConditionalCompareObjectGreater(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(((Control)frmMain.DefInstance.lblStatus).Tag)), (object)900, false))
						{
							recordset.Fields["StatusOther"].Value = Strings.Mid(frmMain.DefInstance.lblStatus.Text, 8);
						}
						else
						{
							recordset.Fields["StatusOther"].Value = "";
						}
						recordset.Fields["FiscalYear"].Value = frmMain.DefInstance.lblFiscalYear.Text;
						recordset.Fields["VPlow"].Value = RuntimeHelpers.GetObjectValue(Common.MyNullCheck0(frmMain.DefInstance.lblAVPlow.Text));
						recordset.Fields["VPhigh"].Value = RuntimeHelpers.GetObjectValue(Common.MyNullCheck0(frmMain.DefInstance.lblAVPhigh.Text));
						recordset.Fields["NumberOfOps"].Value = Globals_Renamed.intNumOps;
						short num4 = 0;
						short num5 = (short)(Globals_Renamed.intNumOps - 1);
						num3 = 0;
						while (true)
						{
							short num6 = num3;
							short num7 = num5;
							if (num6 > num7)
							{
								break;
							}
							short num8 = 0;
							short num9;
							do
							{
								if (Globals_Renamed.arSelActType[num8, num3] > 0)
								{
									num4++;
								}
								num8 = (short)unchecked(num8 + 1);
								num9 = num8;
								num7 = 24;
							}
							while (num9 <= num7);
							num3 = (short)unchecked(num3 + 1);
						}
						recordset.Fields["NumberOfActs"].Value = num4;
						recordset.Fields["SavedOn"].Value = DateAndTime.Now;
						recordset.Update(Missing.Value, Missing.Value);
						recordset.Close();
						recordset = null;
						flag = true;
						goto end_IL_0001;
					}
					case 1075:
						num = -1;
						switch (num2)
						{
						case 2:
						{
							string Eobject = "DBFuncs.Bas";
							string Efunction = "Save_RevisionHistory";
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
				try0001_dispatch = 1075;
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
