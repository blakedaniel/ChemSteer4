using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using ADODB;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ChemSteer;

[StandardModule]
internal sealed class GetParmDefaults
{
	public static float GetParmDefault3103(ref short pModIndex, ref short pDualIndex)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		if (Globals_Renamed.arExpModParmsVC[pDualIndex, 78, pModIndex] == 0)
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"An unknown error has occured. The Ys origin has not been set so Ypel can't be derived. Please verify that Ypel is correct, and if need be, correct it's value by entering a user specified value. Please contact Technical Support to inform them of this problem.", (MsgBoxStyle)64, (object)"Error");
			return 0f;
		}
		if (Globals_Renamed.arExpModParmsVC[pDualIndex, 78, pModIndex] == 94)
		{
			return 1f - Globals_Renamed.arContParms[2, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex];
		}
		return 1f - Globals_Renamed.arOpParms[Globals_Renamed.arExpModParmsVC[pDualIndex, 78, pModIndex], Globals_Renamed.intOpIndex];
	}

	public static float GetParmDefault3105(ref short pModelIndex, ref short pDualIndex, ref object ParRelModParmsV)
	{
		return Conversions.ToSingle(Operators.SubtractObject((object)1, NewLateBinding.LateIndexGet(ParRelModParmsV, new object[3]
		{
			pDualIndex,
			(short)43,
			pModelIndex
		}, (string[])null)));
	}

	public static short GetParmDefault2104(ref short pActID)
	{
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
		Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		command.ActiveConnection = Common.MyConn;
		command.CommandText = "pqryGetActContTab";
		command.CommandType = CommandTypeEnum.adCmdStoredProc;
		command.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, pActID));
		Command command2 = command;
		object RecordsAffected = Missing.Value;
		object Parameters = Missing.Value;
		recordset = command2.Execute(out RecordsAffected, ref Parameters);
		command.Parameters.Delete("pActID");
		short num;
		if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields[0].Value)))
		{
			if (Globals_Renamed.arOpBorC[Globals_Renamed.intOpIndex] == 1)
			{
				if (Globals_Renamed.arOpParms[17, Globals_Renamed.intOpIndex] < 1f)
				{
					num = 16;
					Globals_Renamed.gblNumMetaNonDefaults = 1;
					Globals_Renamed.gblMetaNonDefaults = new object[1] { (short)2 };
				}
				else
				{
					num = 2;
					Globals_Renamed.gblNumMetaNonDefaults = 1;
					Globals_Renamed.gblMetaNonDefaults = new object[1] { (short)16 };
				}
			}
			else
			{
				num = 2;
				Globals_Renamed.gblNumMetaNonDefaults = 0;
			}
		}
		else if (Globals_Renamed.arOpBorC[Globals_Renamed.intOpIndex] == 1)
		{
			num = 93;
			Globals_Renamed.gblNumMetaNonDefaults = 2;
			Globals_Renamed.gblMetaNonDefaults = new object[2]
			{
				(short)2,
				(short)16
			};
		}
		else
		{
			num = 93;
			Globals_Renamed.gblNumMetaNonDefaults = 1;
			Globals_Renamed.gblMetaNonDefaults = new object[1] { (short)2 };
		}
		recordset.Close();
		if (num == 93)
		{
			if (Globals_Renamed.arContParms[9, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] > 250f)
			{
				num = 98;
			}
		}
		else if (Globals_Renamed.arOpParms[num, Globals_Renamed.intOpIndex] > 250f)
		{
			num = 98;
		}
		num = checked((short)(-num));
		recordset = null;
		command = null;
		return num;
	}

	public static float GetParmDefault2105(ref short pActID, ref short pModIndex, ref short pDualIndex)
	{
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
		Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		command.ActiveConnection = Common.MyConn;
		command.CommandText = "pqryGetActContTab";
		command.CommandType = CommandTypeEnum.adCmdStoredProc;
		command.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, pActID));
		Command command2 = command;
		object RecordsAffected = Missing.Value;
		object Parameters = Missing.Value;
		recordset = command2.Execute(out RecordsAffected, ref Parameters);
		command.Parameters.Delete("pActID");
		short pParmID = 72;
		short num = ChemStrX.FindAssocRelModelIndex(ref pParmID);
		checked
		{
			float result;
			if (num == -1)
			{
				if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields[0].Value)))
				{
					if (Globals_Renamed.arOpBorC[Globals_Renamed.intOpIndex] == 1)
					{
						if (Globals_Renamed.arOpParms[17, Globals_Renamed.intOpIndex] < 1f)
						{
							pParmID = 16;
							short pValueID = 98;
							result = -ChemStrX.ParmCheckOp(ref pParmID, ref pValueID);
							Globals_Renamed.gblNumMetaNonDefaults = 1;
							Globals_Renamed.gblMetaNonDefaults = new object[1] { (short)2 };
						}
						else
						{
							short pValueID = 2;
							pParmID = 98;
							result = -ChemStrX.ParmCheckOp(ref pValueID, ref pParmID);
							Globals_Renamed.gblNumMetaNonDefaults = 1;
							Globals_Renamed.gblMetaNonDefaults = new object[1] { (short)16 };
						}
					}
					else
					{
						short pValueID = 2;
						pParmID = 98;
						result = -ChemStrX.ParmCheckOp(ref pValueID, ref pParmID);
						Globals_Renamed.gblNumMetaNonDefaults = 0;
					}
				}
				else if (Globals_Renamed.arOpBorC[Globals_Renamed.intOpIndex] == 1)
				{
					short pValueID = 9;
					pParmID = 98;
					short pReturnID = 93;
					result = -ChemStrX.ParmCheckCont(ref pValueID, ref pParmID, ref pReturnID);
					Globals_Renamed.gblNumMetaNonDefaults = 2;
					Globals_Renamed.gblMetaNonDefaults = new object[2]
					{
						(short)2,
						(short)16
					};
				}
				else
				{
					short pReturnID = 9;
					short pValueID = 98;
					pParmID = 93;
					result = -ChemStrX.ParmCheckCont(ref pReturnID, ref pValueID, ref pParmID);
					Globals_Renamed.gblNumMetaNonDefaults = 1;
					Globals_Renamed.gblMetaNonDefaults = new object[1] { (short)2 };
				}
			}
			else
			{
				result = ((Globals_Renamed.arRelModParmsVC[pDualIndex, 72, num] == 999) ? ((Globals_Renamed.arRelModOutputOn[pDualIndex, num] == 1) ? Globals_Renamed.arRelModParmsV[pDualIndex, 72, num] : ((pDualIndex != 0) ? Globals_Renamed.arRelModParmsV[0, 72, num] : Globals_Renamed.arRelModParmsV[1, 72, num])) : ((!(Globals_Renamed.arRelModParmsV[pDualIndex, Globals_Renamed.arRelModParmsVC[pDualIndex, 72, num], num] > 250f)) ? Globals_Renamed.arRelModParmsV[pDualIndex, Globals_Renamed.arRelModParmsVC[pDualIndex, 72, num], num] : (-98f)));
				if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields[0].Value)))
				{
					if (Globals_Renamed.arOpBorC[Globals_Renamed.intOpIndex] == 1)
					{
						Globals_Renamed.gblNumMetaNonDefaults = 2;
						Globals_Renamed.gblMetaNonDefaults = new object[2]
						{
							(short)2,
							(short)16
						};
					}
					else
					{
						Globals_Renamed.gblNumMetaNonDefaults = 1;
						Globals_Renamed.gblMetaNonDefaults = new object[1] { (short)2 };
					}
				}
				else if (Globals_Renamed.arOpBorC[Globals_Renamed.intOpIndex] == 1)
				{
					Globals_Renamed.gblNumMetaNonDefaults = 3;
					Globals_Renamed.gblMetaNonDefaults = new object[3]
					{
						(short)2,
						(short)93,
						(short)16
					};
				}
				else
				{
					Globals_Renamed.gblNumMetaNonDefaults = 2;
					Globals_Renamed.gblMetaNonDefaults = new object[2]
					{
						(short)2,
						(short)93
					};
				}
			}
			recordset.Close();
			recordset = null;
			command = null;
			return result;
		}
	}

	public static float GetParmDefault3101(ref short pActID, ref short pDualIndex)
	{
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
		Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		short pParmID = 69;
		short num = ChemStrX.FindAssocRelModelIndex(ref pParmID);
		string text;
		if (num == -1)
		{
			text = "indoor";
		}
		else
		{
			switch (Globals_Renamed.arRelModType[num])
			{
			case 7:
			{
				command.ActiveConnection = Common.MyConn;
				command.CommandText = "pqryGetActContTab";
				command.CommandType = CommandTypeEnum.adCmdStoredProc;
				command.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, pActID));
				Command command2 = command;
				object RecordsAffected = Missing.Value;
				object Parameters = Missing.Value;
				recordset = command2.Execute(out RecordsAffected, ref Parameters);
				command.Parameters.Delete("pActID");
				Type? typeFromHandle = typeof(Strings);
				object[] array = new object[1];
				Field field = recordset.Fields[2];
				array[0] = RuntimeHelpers.GetObjectValue(field.Value);
				object[] array2 = array;
				bool[] array3 = new bool[1] { true };
				object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "LCase", array2, (string[])null, (Type[])null, array3);
				if (array3[0])
				{
					field.Value = RuntimeHelpers.GetObjectValue(array2[0]);
				}
				bool num2 = Strings.InStr(Conversions.ToString(obj), "rail cars", (CompareMethod)0) > 0;
				Type? typeFromHandle2 = typeof(Strings);
				object[] array4 = new object[1];
				Field field2 = recordset.Fields[2];
				array4[0] = RuntimeHelpers.GetObjectValue(field2.Value);
				object[] array5 = array4;
				bool[] array6 = new bool[1] { true };
				object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle2, "LCase", array5, (string[])null, (Type[])null, array6);
				if (array6[0])
				{
					field2.Value = RuntimeHelpers.GetObjectValue(array5[0]);
				}
				text = ((!(num2 | (Strings.InStr(Conversions.ToString(obj2), "tank trucks", (CompareMethod)0) > 0))) ? "indoor" : "outdoor");
				recordset.Close();
				break;
			}
			case 8:
				text = "outdoor";
				break;
			default:
				text = "indoor";
				break;
			}
		}
		string text2 = text;
		double num4 = default(double);
		if (Operators.CompareString(text2, "outdoor", false) == 0)
		{
			if (pDualIndex != 0)
			{
				short num3 = ((Globals_Renamed.arRelModOutputOn[pDualIndex, num] == 1) ? pDualIndex : ((pDualIndex == 0) ? ((short)1) : ((short)0)));
				num4 = ((Globals_Renamed.arRelModParmsT[num3, 69, num] <= 0) ? 132000.0 : ((double)(Globals_Renamed.arRelModParmsV[num3, 69, num] * 300f)));
			}
			else
			{
				num4 = 237600.0;
			}
		}
		else if (Operators.CompareString(text2, "indoor", false) == 0)
		{
			num4 = ((pDualIndex != 0) ? 500.0 : 3000.0);
		}
		float result = (float)num4;
		recordset = null;
		command = null;
		return result;
	}

	public static float GetParmDefault3106(ref short pDualIndex)
	{
		if (pDualIndex == 0)
		{
			return 0.5f;
		}
		return 0.1f;
	}

	public static float GetParmDefault3108()
	{
		return Conversions.ToSingle(Common.MyNullCheck0(frmMain.DefInstance.lblVP.Text));
	}

	public static float GetParmDefault3109(ref short pDualIndex)
	{
		short pParmID = 4;
		float num = ChemStrX.FindAssocRelModelValue(ref pParmID, ref pDualIndex);
		if (num > 0f)
		{
			return num;
		}
		return Conversions.ToSingle(Common.MyNullCheck0(frmMain.DefInstance.lblVP.Text));
	}

	public static float GetParmDefault3110(ref short pDualIndex)
	{
		if (pDualIndex == 0)
		{
			Globals_Renamed.gblNumMetaNonDefaults = 2;
			Globals_Renamed.gblMetaNonDefaults = new object[2] { 0.0007, 0.02 };
			Globals_Renamed.gblMetaNonDefaultCaps = new object[2] { "Central Tendency", "High End" };
			return 0.0007f;
		}
		Globals_Renamed.gblNumMetaNonDefaults = 2;
		Globals_Renamed.gblMetaNonDefaults = new object[2] { 0.002, 0.0007 };
		Globals_Renamed.gblMetaNonDefaultCaps = new object[2] { "High End", "Central Tendency" };
		return 0.002f;
	}

	public static float GetParmDefault3113(ref short pDualIndex)
	{
		if (pDualIndex == 0)
		{
			Globals_Renamed.gblNumMetaNonDefaults = 2;
			Globals_Renamed.gblMetaNonDefaults = new object[2] { 0.003, 0.006 };
			Globals_Renamed.gblMetaNonDefaultCaps = new object[2] { "Central Tendency", "High End" };
			return 0.003f;
		}
		Globals_Renamed.gblNumMetaNonDefaults = 2;
		Globals_Renamed.gblMetaNonDefaults = new object[2] { 0.006, 0.003 };
		Globals_Renamed.gblMetaNonDefaultCaps = new object[2] { "High End", "Central Tendency" };
		return 0.006f;
	}

	public static float GetParmDefault3114()
	{
		Globals_Renamed.gblNumMetaNonDefaults = 1;
		Globals_Renamed.gblMetaNonDefaults = new object[1] { 0.01 };
		Globals_Renamed.gblMetaNonDefaultCaps = new object[1] { "not characterized" };
		return 0.01f;
	}

	public static float GetParmDefault3128()
	{
		Globals_Renamed.gblNumMetaNonDefaults = 1;
		Globals_Renamed.gblMetaNonDefaults = new object[1] { 0.005 };
		Globals_Renamed.gblMetaNonDefaultCaps = new object[1] { "Conservative" };
		return 0.005f;
	}

	public static float GetParmDefault3115()
	{
		Globals_Renamed.gblNumMetaNonDefaults = 1;
		Globals_Renamed.gblMetaNonDefaults = new object[1] { 0.02 };
		Globals_Renamed.gblMetaNonDefaultCaps = new object[1] { "Conservative" };
		return 0.02f;
	}

	public static float GetParmDefault3112(ref short pDualIndex)
	{
		if (pDualIndex == 0)
		{
			Globals_Renamed.gblNumMetaNonDefaults = 3;
			Globals_Renamed.gblMetaNonDefaults = new object[3] { 0.002, 0.01, 0.0007 };
			Globals_Renamed.gblMetaNonDefaultCaps = new object[3] { "High End to Bounding for gravity drain", "Conservative for pumping", "Central Tendency for gravity drain" };
			return 0.002f;
		}
		Globals_Renamed.gblNumMetaNonDefaults = 3;
		Globals_Renamed.gblMetaNonDefaults = new object[3] { 0.01, 0.002, 0.0007 };
		Globals_Renamed.gblMetaNonDefaultCaps = new object[3] { "Conservative for pumping", "High End to Bounding for gravity drain", "Central Tendency for gravity drain" };
		return 0.01f;
	}

	public static float GetParmDefault3111(ref short pDualIndex)
	{
		if (pDualIndex == 0)
		{
			Globals_Renamed.gblNumMetaNonDefaults = 4;
			Globals_Renamed.gblMetaNonDefaults = new object[4] { 0.025, 0.03, 0.006, 0.003 };
			Globals_Renamed.gblMetaNonDefaultCaps = new object[4] { "Central Tendency for pumping", "High End for pumping", "High End for pouring", "Central Tendency for pouring" };
			return 0.025f;
		}
		Globals_Renamed.gblNumMetaNonDefaults = 4;
		Globals_Renamed.gblMetaNonDefaults = new object[4] { 0.03, 0.025, 0.006, 0.003 };
		Globals_Renamed.gblMetaNonDefaultCaps = new object[4] { "High End for pumping", "Central Tendency for pumping", "High End for pouring", "Central Tendency for pouring" };
		return 0.03f;
	}

	public static short GetParmDefault2106(ref short pActID)
	{
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
		Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		command.ActiveConnection = Common.MyConn;
		command.CommandText = "pqryGetActContTab";
		command.CommandType = CommandTypeEnum.adCmdStoredProc;
		command.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, pActID));
		Command command2 = command;
		object RecordsAffected = Missing.Value;
		object Parameters = Missing.Value;
		recordset = command2.Execute(out RecordsAffected, ref Parameters);
		command.Parameters.Delete("pActID");
		short result;
		if (Strings.InStr(Conversions.ToString(recordset.Fields[2].Value), "Solid", (CompareMethod)0) > 0)
		{
			if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields[0].Value)))
			{
				if (Strings.InStr(Conversions.ToString(recordset.Fields[2].Value), "Raw Material", (CompareMethod)0) > 0)
				{
					result = 11;
					Globals_Renamed.gblNumMetaNonDefaults = 1;
					Globals_Renamed.gblMetaNonDefaults = new object[1] { (short)10 };
				}
				else if (Strings.InStr(Conversions.ToString(recordset.Fields[2].Value), "Product", (CompareMethod)0) > 0)
				{
					result = 10;
					Globals_Renamed.gblNumMetaNonDefaults = 1;
					Globals_Renamed.gblMetaNonDefaults = new object[1] { (short)11 };
				}
				else if (Globals_Renamed.arOpType[Globals_Renamed.intOpIndex] == 1)
				{
					result = 10;
					Globals_Renamed.gblNumMetaNonDefaults = 1;
					Globals_Renamed.gblMetaNonDefaults = new object[1] { (short)11 };
				}
				else
				{
					result = 11;
					Globals_Renamed.gblNumMetaNonDefaults = 1;
					Globals_Renamed.gblMetaNonDefaults = new object[1] { (short)10 };
				}
			}
			else
			{
				result = 94;
				Globals_Renamed.gblNumMetaNonDefaults = 2;
				Globals_Renamed.gblMetaNonDefaults = new object[2]
				{
					(short)11,
					(short)10
				};
			}
		}
		else
		{
			result = 999;
			if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields[0].Value)))
			{
				Globals_Renamed.gblNumMetaNonDefaults = 2;
				Globals_Renamed.gblMetaNonDefaults = new object[2]
				{
					(short)11,
					(short)10
				};
			}
			else
			{
				Globals_Renamed.gblNumMetaNonDefaults = 3;
				Globals_Renamed.gblMetaNonDefaults = new object[3]
				{
					(short)94,
					(short)11,
					(short)10
				};
			}
		}
		recordset.Close();
		recordset = null;
		command = null;
		return result;
	}

	public static short GetParmDefault2111(ref short pActID)
	{
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
		Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		command.ActiveConnection = Common.MyConn;
		command.CommandText = "pqryGetActContTab";
		command.CommandType = CommandTypeEnum.adCmdStoredProc;
		command.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, pActID));
		Command command2 = command;
		object RecordsAffected = Missing.Value;
		object Parameters = Missing.Value;
		recordset = command2.Execute(out RecordsAffected, ref Parameters);
		command.Parameters.Delete("pActID");
		if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields[0].Value)))
		{
			Globals_Renamed.gblNumMetaNonDefaults = 2;
			Globals_Renamed.gblMetaNonDefaults = new object[2]
			{
				(short)11,
				(short)10
			};
		}
		else
		{
			Globals_Renamed.gblNumMetaNonDefaults = 3;
			Globals_Renamed.gblMetaNonDefaults = new object[3]
			{
				(short)11,
				(short)10,
				(short)94
			};
		}
		recordset.Close();
		recordset = null;
		command = null;
		return 39;
	}

	public static float GetParmDefault2112(ref short pActID)
	{
		if (pActID == 96)
		{
			return 0.5f;
		}
		return 15f;
	}

	public static float GetParmDefault2113(ref short pActID)
	{
		if (pActID == 96)
		{
			return 0.25f;
		}
		return 1f;
	}

	public static short GetParmDefault1107()
	{
		short result = 130;
		Globals_Renamed.gblNumMetaNonDefaults = 0;
		return result;
	}

	public static float GetParmDefault3124()
	{
		return Globals_Renamed.arOpParms[128, Globals_Renamed.intOpIndex];
	}

	public static float GetParmDefault3125()
	{
		return Globals_Renamed.arOpParms[129, Globals_Renamed.intOpIndex];
	}

	public static short GetParmDefault3126()
	{
		short result = checked((short)Math.Round(Globals_Renamed.arOpParms[137, Globals_Renamed.intOpIndex]));
		Globals_Renamed.gblMetaNonDefaultCaps = new object[2] { "FreqBath", "Freqbath x Nbath" };
		Globals_Renamed.gblMetaNonDefaults = new object[2]
		{
			Globals_Renamed.arOpParms[137, Globals_Renamed.intOpIndex],
			Globals_Renamed.arOpParms[137, Globals_Renamed.intOpIndex] * Globals_Renamed.arOpParms[136, Globals_Renamed.intOpIndex]
		};
		Globals_Renamed.gblNumMetaNonDefaults = 2;
		return result;
	}

	public static short GetParmDefault3127()
	{
		short result = checked((short)Math.Round(Globals_Renamed.arOpParms[135, Globals_Renamed.intOpIndex] * Globals_Renamed.arOpParms[136, Globals_Renamed.intOpIndex]));
		Globals_Renamed.gblMetaNonDefaultCaps = new object[2] { "Vbath x Nbath", "Vbath" };
		Globals_Renamed.gblMetaNonDefaults = new object[2]
		{
			Globals_Renamed.arOpParms[135, Globals_Renamed.intOpIndex] * Globals_Renamed.arOpParms[136, Globals_Renamed.intOpIndex],
			Globals_Renamed.arOpParms[135, Globals_Renamed.intOpIndex]
		};
		Globals_Renamed.gblNumMetaNonDefaults = 2;
		return result;
	}

	public static float GetParmDefault3123()
	{
		return Globals_Renamed.arOpParms[127, Globals_Renamed.intOpIndex];
	}

	public static short GetParmDefault1110()
	{
		short result = 2;
		Globals_Renamed.gblNumMetaNonDefaults = 0;
		return result;
	}

	public static short GetParmDefault1106(ref short pActID)
	{
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
		Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		command.ActiveConnection = Common.MyConn;
		command.CommandText = "pqryGetActContTab";
		command.CommandType = CommandTypeEnum.adCmdStoredProc;
		command.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, pActID));
		Command command2 = command;
		object RecordsAffected = Missing.Value;
		object Parameters = Missing.Value;
		recordset = command2.Execute(out RecordsAffected, ref Parameters);
		command.Parameters.Delete("pActID");
		short result;
		if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields[0].Value)))
		{
			if (Globals_Renamed.arOpBorC[Globals_Renamed.intOpIndex] == 1)
			{
				if (Globals_Renamed.arOpParms[17, Globals_Renamed.intOpIndex] < 1f)
				{
					result = (short)((Globals_Renamed.arOpType[Globals_Renamed.intOpIndex] != 1) ? 99 : 32);
					Globals_Renamed.gblNumMetaNonDefaults = 3;
					Globals_Renamed.gblMetaNonDefaults = new object[3]
					{
						(short)99,
						(short)88,
						(short)89
					};
				}
				else
				{
					result = (short)((Globals_Renamed.arOpType[Globals_Renamed.intOpIndex] != 1) ? 83 : 85);
					Globals_Renamed.gblNumMetaNonDefaults = 5;
					Globals_Renamed.gblMetaNonDefaults = new object[5]
					{
						(short)99,
						(short)32,
						(short)85,
						(short)84,
						(short)86
					};
				}
			}
			else if (Globals_Renamed.arOpType[Globals_Renamed.intOpIndex] == 1)
			{
				result = 13;
				Globals_Renamed.gblNumMetaNonDefaults = 1;
				Globals_Renamed.gblMetaNonDefaults = new object[1] { (short)15 };
			}
			else
			{
				result = 15;
				Globals_Renamed.gblNumMetaNonDefaults = 1;
				Globals_Renamed.gblMetaNonDefaults = new object[1] { (short)13 };
			}
		}
		else if (Globals_Renamed.arOpBorC[Globals_Renamed.intOpIndex] == 1)
		{
			result = (short)((!(Globals_Renamed.arContParms[10, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] < 1f)) ? 87 : 110);
			Globals_Renamed.gblNumMetaNonDefaults = 9;
			Globals_Renamed.gblMetaNonDefaults = new object[9]
			{
				(short)99,
				(short)32,
				(short)85,
				(short)84,
				(short)86,
				(short)110,
				(short)88,
				(short)89,
				(short)83
			};
		}
		else
		{
			result = (short)((!(Globals_Renamed.arContParms[10, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] < 1f)) ? 87 : 110);
			Globals_Renamed.gblNumMetaNonDefaults = 3;
			Globals_Renamed.gblMetaNonDefaults = new object[3]
			{
				(short)110,
				(short)14,
				(short)12
			};
		}
		recordset = null;
		command = null;
		return result;
	}

	public static short GetParmDefault1112(ref short pActID)
	{
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
		Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		command.ActiveConnection = Common.MyConn;
		command.CommandText = "pqryGetActContTab";
		command.CommandType = CommandTypeEnum.adCmdStoredProc;
		command.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, pActID));
		Command command2 = command;
		object RecordsAffected = Missing.Value;
		object Parameters = Missing.Value;
		recordset = command2.Execute(out RecordsAffected, ref Parameters);
		command.Parameters.Delete("pActID");
		checked
		{
			short num = (short)Strings.InStr(Conversions.ToString(recordset.Fields[2].Value), "Raw Material", (CompareMethod)0);
			short result;
			if (num > 0)
			{
				result = 118;
				Globals_Renamed.gblNumMetaNonDefaults = 2;
				Globals_Renamed.gblMetaNonDefaults = new object[2]
				{
					(short)119,
					(short)120
				};
			}
			else
			{
				num = (short)Strings.InStr(Conversions.ToString(recordset.Fields[2].Value), "Product", (CompareMethod)0);
				if (num > 0)
				{
					result = 119;
					Globals_Renamed.gblNumMetaNonDefaults = 2;
					Globals_Renamed.gblMetaNonDefaults = new object[2]
					{
						(short)118,
						(short)120
					};
				}
				else
				{
					num = (short)Strings.InStr(Conversions.ToString(recordset.Fields[2].Value), "Other", (CompareMethod)0);
					if (num > 0)
					{
						result = 120;
						Globals_Renamed.gblNumMetaNonDefaults = 2;
						Globals_Renamed.gblMetaNonDefaults = new object[2]
						{
							(short)118,
							(short)119
						};
					}
					else if (Globals_Renamed.arOpType[Globals_Renamed.intOpIndex] == 1)
					{
						result = 119;
						Globals_Renamed.gblNumMetaNonDefaults = 2;
						Globals_Renamed.gblMetaNonDefaults = new object[2]
						{
							(short)118,
							(short)120
						};
					}
					else
					{
						result = 118;
						Globals_Renamed.gblNumMetaNonDefaults = 2;
						Globals_Renamed.gblMetaNonDefaults = new object[2]
						{
							(short)119,
							(short)120
						};
					}
				}
			}
			recordset.Close();
			recordset = null;
			command = null;
			return result;
		}
	}

	public static float GetParmDefault1111(ref short pActID, ref short pDualIndex)
	{
		short pParmID = 40;
		short num = ChemStrX.FindAssocRelModelIndex(ref pParmID);
		float result;
		if (num == -1)
		{
			result = checked(-GetParmDefault1112(ref pActID));
		}
		else
		{
			short num2 = ((Globals_Renamed.arRelModOutputOn[pDualIndex, num] == 1) ? pDualIndex : ((pDualIndex == 0) ? ((short)1) : ((short)0)));
			result = ((Globals_Renamed.arRelModParmsVC[num2, 40, num] != 999) ? Globals_Renamed.arRelModParmsV[num2, Globals_Renamed.arRelModParmsVC[num2, 40, num], num] : Globals_Renamed.arRelModParmsV[num2, 40, num]);
			Globals_Renamed.gblNumMetaNonDefaults = 3;
			Globals_Renamed.gblMetaNonDefaults = new object[3]
			{
				(short)118,
				(short)119,
				(short)120
			};
		}
		return result;
	}

	public static float GetParmDefault1108(ref short pActID)
	{
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
		Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		command.ActiveConnection = Common.MyConn;
		command.CommandText = "pqryGetActContTab";
		command.CommandType = CommandTypeEnum.adCmdStoredProc;
		command.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, pActID));
		Command command2 = command;
		object RecordsAffected = Missing.Value;
		object Parameters = Missing.Value;
		recordset = command2.Execute(out RecordsAffected, ref Parameters);
		command.Parameters.Delete("pActID");
		float result;
		if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields[0].Value)))
		{
			short num = pActID;
			result = ((num == 27) ? 4f : (((num == 28 || num == 1 || num == 55 || num == 56) ? true : false) ? 1f : ((num == 29) ? 0.5f : ((!(Globals_Renamed.arOpParms[101, Globals_Renamed.intOpIndex] * Globals_Renamed.arOpParms[17, Globals_Renamed.intOpIndex] > 24f)) ? 8f : (Globals_Renamed.arOpParms[101, Globals_Renamed.intOpIndex] * Globals_Renamed.arOpParms[17, Globals_Renamed.intOpIndex])))));
		}
		else
		{
			result = Globals_Renamed.arContParms[7, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex];
		}
		recordset = null;
		command = null;
		return result;
	}

	public static short GetParmDefault2102(ref short pActID)
	{
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
		Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		command.ActiveConnection = Common.MyConn;
		command.CommandText = "pqryGetActContTab";
		command.CommandType = CommandTypeEnum.adCmdStoredProc;
		command.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, pActID));
		Command command2 = command;
		object RecordsAffected = Missing.Value;
		object Parameters = Missing.Value;
		recordset = command2.Execute(out RecordsAffected, ref Parameters);
		command.Parameters.Delete("pActID");
		short result;
		if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields[0].Value)))
		{
			if (Globals_Renamed.arOpBorC[Globals_Renamed.intOpIndex] == 0)
			{
				if (Globals_Renamed.arOpType[Globals_Renamed.intOpIndex] == 1)
				{
					result = 13;
					Globals_Renamed.gblNumMetaNonDefaults = 1;
					Globals_Renamed.gblMetaNonDefaults = new object[1] { (short)14 };
				}
				else
				{
					result = 14;
					Globals_Renamed.gblNumMetaNonDefaults = 1;
					Globals_Renamed.gblMetaNonDefaults = new object[1] { (short)12 };
				}
			}
			else if (Globals_Renamed.arOpParms[17, Globals_Renamed.intOpIndex] < 1f)
			{
				if (Globals_Renamed.arOpType[Globals_Renamed.intOpIndex] == 1)
				{
					result = 32;
					Globals_Renamed.gblNumMetaNonDefaults = 3;
					Globals_Renamed.gblMetaNonDefaults = new object[3]
					{
						(short)99,
						(short)88,
						(short)89
					};
				}
				else
				{
					result = 99;
					Globals_Renamed.gblNumMetaNonDefaults = 3;
					Globals_Renamed.gblMetaNonDefaults = new object[3]
					{
						(short)32,
						(short)88,
						(short)89
					};
				}
			}
			else if (Globals_Renamed.arOpType[Globals_Renamed.intOpIndex] == 1)
			{
				result = 85;
				Globals_Renamed.gblNumMetaNonDefaults = 5;
				Globals_Renamed.gblMetaNonDefaults = new object[5]
				{
					(short)99,
					(short)83,
					(short)86,
					(short)32,
					(short)84
				};
			}
			else
			{
				result = 83;
				Globals_Renamed.gblNumMetaNonDefaults = 5;
				Globals_Renamed.gblMetaNonDefaults = new object[5]
				{
					(short)99,
					(short)84,
					(short)86,
					(short)32,
					(short)85
				};
			}
		}
		else
		{
			result = 87;
			if (Globals_Renamed.arOpBorC[Globals_Renamed.intOpIndex] == 1)
			{
				Globals_Renamed.gblNumMetaNonDefaults = 8;
				Globals_Renamed.gblMetaNonDefaults = new object[8]
				{
					(short)99,
					(short)84,
					(short)86,
					(short)32,
					(short)85,
					(short)88,
					(short)89,
					(short)83
				};
			}
			else
			{
				Globals_Renamed.gblNumMetaNonDefaults = 2;
				Globals_Renamed.gblMetaNonDefaults = new object[2]
				{
					(short)14,
					(short)12
				};
			}
		}
		recordset.Close();
		recordset = null;
		command = null;
		return result;
	}

	public static short GetParmDefault2103(ref short pActID)
	{
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
		Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		command.ActiveConnection = Common.MyConn;
		command.CommandText = "pqryGetActContTab";
		command.CommandType = CommandTypeEnum.adCmdStoredProc;
		command.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, pActID));
		Command command2 = command;
		object RecordsAffected = Missing.Value;
		object Parameters = Missing.Value;
		recordset = command2.Execute(out RecordsAffected, ref Parameters);
		command.Parameters.Delete("pActID");
		short num;
		if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields[0].Value)))
		{
			if (Globals_Renamed.arOpBorC[Globals_Renamed.intOpIndex] == 1)
			{
				if (Globals_Renamed.arOpParms[17, Globals_Renamed.intOpIndex] < 1f)
				{
					short pParmID = 16;
					short pValueID = 98;
					num = ChemStrX.ParmCheckOp(ref pParmID, ref pValueID);
					Globals_Renamed.gblNumMetaNonDefaults = 1;
					Globals_Renamed.gblMetaNonDefaults = new object[1] { (short)2 };
				}
				else
				{
					short pValueID = 2;
					short pParmID = 98;
					num = ChemStrX.ParmCheckOp(ref pValueID, ref pParmID);
					Globals_Renamed.gblNumMetaNonDefaults = 1;
					Globals_Renamed.gblMetaNonDefaults = new object[1] { (short)16 };
				}
			}
			else
			{
				short pValueID = 2;
				short pParmID = 98;
				num = ChemStrX.ParmCheckOp(ref pValueID, ref pParmID);
				Globals_Renamed.gblNumMetaNonDefaults = 0;
			}
		}
		else if (Globals_Renamed.arOpBorC[Globals_Renamed.intOpIndex] == 1)
		{
			short pValueID = 9;
			short pParmID = 98;
			short pReturnID = 93;
			num = ChemStrX.ParmCheckCont(ref pValueID, ref pParmID, ref pReturnID);
			Globals_Renamed.gblNumMetaNonDefaults = 2;
			Globals_Renamed.gblMetaNonDefaults = new object[2]
			{
				(short)2,
				(short)16
			};
		}
		else
		{
			short pReturnID = 9;
			short pValueID = 98;
			short pParmID = 93;
			num = ChemStrX.ParmCheckCont(ref pReturnID, ref pValueID, ref pParmID);
			Globals_Renamed.gblNumMetaNonDefaults = 1;
			Globals_Renamed.gblMetaNonDefaults = new object[1] { (short)2 };
		}
		recordset.Close();
		recordset = null;
		command = null;
		return checked((short)(-num));
	}

	public static short GetParmDefault2107(ref short pActID)
	{
		short num;
		if (Globals_Renamed.arOpBorC[Globals_Renamed.intOpIndex] == 1)
		{
			if (Globals_Renamed.arOpParms[17, Globals_Renamed.intOpIndex] < 1f)
			{
				short pParmID = 16;
				short pValueID = 98;
				num = ChemStrX.ParmCheckOp(ref pParmID, ref pValueID);
				Globals_Renamed.gblNumMetaNonDefaults = 1;
				Globals_Renamed.gblMetaNonDefaults = new object[1] { (short)2 };
			}
			else
			{
				short pValueID = 2;
				short pParmID = 98;
				num = ChemStrX.ParmCheckOp(ref pValueID, ref pParmID);
				Globals_Renamed.gblNumMetaNonDefaults = 1;
				Globals_Renamed.gblMetaNonDefaults = new object[1] { (short)16 };
			}
		}
		else
		{
			short pValueID = 2;
			short pParmID = 98;
			num = ChemStrX.ParmCheckOp(ref pValueID, ref pParmID);
			Globals_Renamed.gblNumMetaNonDefaults = 0;
		}
		return checked((short)(-num));
	}

	public static short GetParmDefault2110()
	{
		checked
		{
			short result;
			if (Globals_Renamed.arOpBorC[Globals_Renamed.intOpIndex] == 1)
			{
				if (Globals_Renamed.arOpParms[17, Globals_Renamed.intOpIndex] < 1f)
				{
					short pParmID = 16;
					short pValueID = 98;
					result = (short)(-ChemStrX.ParmCheckOp(ref pParmID, ref pValueID));
					Globals_Renamed.gblNumMetaNonDefaults = 1;
					Globals_Renamed.gblMetaNonDefaults = new object[1] { (short)2 };
				}
				else
				{
					short pValueID = 2;
					short pParmID = 98;
					result = (short)(-ChemStrX.ParmCheckOp(ref pValueID, ref pParmID));
					Globals_Renamed.gblNumMetaNonDefaults = 1;
					Globals_Renamed.gblMetaNonDefaults = new object[1] { (short)16 };
				}
			}
			else
			{
				short pValueID = 2;
				short pParmID = 98;
				result = (short)(-ChemStrX.ParmCheckOp(ref pValueID, ref pParmID));
				Globals_Renamed.gblNumMetaNonDefaults = 0;
			}
			return result;
		}
	}

	public static float GetParmDefault1103(ref short pID, ref short pActID, ref short pActIndex, ref short pModIndex, ref short pDualIndex)
	{
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
		Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		float result = default(float);
		switch (pID)
		{
		case 28:
			result = (float)((double)(Globals_Renamed.arRelModParmsV[pDualIndex, 26, pModIndex] * Globals_Renamed.arRelModParmsV[pDualIndex, 26, pModIndex]) * 3.14159265359 / 4.0);
			break;
		case 31:
		{
			command.ActiveConnection = Common.MyConn;
			command.CommandText = "pqryGetActContTab";
			command.CommandType = CommandTypeEnum.adCmdStoredProc;
			command.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, pActID));
			Command command2 = command;
			object RecordsAffected = Missing.Value;
			object Parameters = Missing.Value;
			recordset = command2.Execute(out RecordsAffected, ref Parameters);
			command.Parameters.Delete("pActID");
			if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields[0].Value)))
			{
				short num = pActID;
				result = ((num == 27) ? 4f : (((num == 28 || num == 1 || num == 55 || num == 56) ? true : false) ? 1f : ((num == 29) ? 0.5f : ((!((Globals_Renamed.arOpBorC[Globals_Renamed.intOpIndex] == 1) & (Globals_Renamed.arOpParms[101, Globals_Renamed.intOpIndex] * Globals_Renamed.arOpParms[17, Globals_Renamed.intOpIndex] < 24f))) ? 24f : (Globals_Renamed.arOpParms[101, Globals_Renamed.intOpIndex] * Globals_Renamed.arOpParms[17, Globals_Renamed.intOpIndex])))));
			}
			else
			{
				result = Globals_Renamed.arContParms[7, pActIndex, Globals_Renamed.intOpIndex];
			}
			recordset = null;
			command = null;
			break;
		}
		}
		return result;
	}

	public static short GetParmDefault3102(ref short pActID, ref short pModelType)
	{
		if ((pActID == 89) | (pActID == 90) | (pActID == 96))
		{
			switch (Globals_Renamed.arOpType[Globals_Renamed.intOpIndex])
			{
			case 100:
				return 17;
			case 101:
				return 3;
			case 104:
				return 20;
			default:
				switch (pModelType)
				{
				case 49:
					return 17;
				case 40:
				case 50:
					return 3;
				default:
					return 1;
				}
			}
		}
		switch (pModelType)
		{
		case 49:
			return 17;
		case 40:
		case 50:
			return 3;
		default:
			return 1;
		}
	}

	public static short GetParmDefault2108(ref short pActID)
	{
		short result;
		switch (Globals_Renamed.arOpType[Globals_Renamed.intOpIndex])
		{
		case 100:
			result = 10;
			Globals_Renamed.gblNumMetaNonDefaults = 1;
			Globals_Renamed.gblMetaNonDefaults = new object[1] { (short)11 };
			break;
		case 101:
			result = 10;
			Globals_Renamed.gblNumMetaNonDefaults = 1;
			Globals_Renamed.gblMetaNonDefaults = new object[1] { (short)11 };
			break;
		default:
			result = 10;
			Globals_Renamed.gblNumMetaNonDefaults = 1;
			Globals_Renamed.gblMetaNonDefaults = new object[1] { (short)11 };
			break;
		}
		return result;
	}

	public static short GetParmDefault2101(ref short pActID)
	{
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
		Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		command.ActiveConnection = Common.MyConn;
		command.CommandText = "pqryGetActContTab";
		command.CommandType = CommandTypeEnum.adCmdStoredProc;
		command.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, pActID));
		Command command2 = command;
		object RecordsAffected = Missing.Value;
		object Parameters = Missing.Value;
		recordset = command2.Execute(out RecordsAffected, ref Parameters);
		command.Parameters.Delete("pActID");
		short result;
		if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields[0].Value)))
		{
			if (Strings.InStr(Conversions.ToString(recordset.Fields[2].Value), "Raw Material", (CompareMethod)0) > 0)
			{
				result = 11;
				Globals_Renamed.gblNumMetaNonDefaults = 1;
				Globals_Renamed.gblMetaNonDefaults = new object[1] { (short)10 };
			}
			else if (Strings.InStr(Conversions.ToString(recordset.Fields[2].Value), "Product", (CompareMethod)0) > 0)
			{
				result = 10;
				Globals_Renamed.gblNumMetaNonDefaults = 1;
				Globals_Renamed.gblMetaNonDefaults = new object[1] { (short)11 };
			}
			else if (Globals_Renamed.arOpType[Globals_Renamed.intOpIndex] == 1)
			{
				result = 10;
				Globals_Renamed.gblNumMetaNonDefaults = 1;
				Globals_Renamed.gblMetaNonDefaults = new object[1] { (short)11 };
			}
			else
			{
				result = 11;
				Globals_Renamed.gblNumMetaNonDefaults = 1;
				Globals_Renamed.gblMetaNonDefaults = new object[1] { (short)10 };
			}
		}
		else
		{
			result = 94;
			Globals_Renamed.gblNumMetaNonDefaults = 2;
			Globals_Renamed.gblMetaNonDefaults = new object[2]
			{
				(short)11,
				(short)10
			};
		}
		recordset.Close();
		recordset = null;
		command = null;
		return result;
	}

	public static short GetParmDefault1102(ref short pActID)
	{
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
		Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		command.ActiveConnection = Common.MyConn;
		command.CommandText = "pqryGetActContTab";
		command.CommandType = CommandTypeEnum.adCmdStoredProc;
		command.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, pActID));
		Command command2 = command;
		object RecordsAffected = Missing.Value;
		object Parameters = Missing.Value;
		recordset = command2.Execute(out RecordsAffected, ref Parameters);
		command.Parameters.Delete("pActID");
		short result;
		if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields[0].Value)))
		{
			if (Globals_Renamed.arOpBorC[Globals_Renamed.intOpIndex] == 1)
			{
				if (Globals_Renamed.arOpParms[17, Globals_Renamed.intOpIndex] < 1f)
				{
					result = 16;
					Globals_Renamed.gblNumMetaNonDefaults = 1;
					Globals_Renamed.gblMetaNonDefaults = new object[1] { (short)2 };
				}
				else
				{
					result = 2;
					Globals_Renamed.gblNumMetaNonDefaults = 1;
					Globals_Renamed.gblMetaNonDefaults = new object[1] { (short)16 };
				}
			}
			else
			{
				result = 2;
				Globals_Renamed.gblNumMetaNonDefaults = 0;
			}
		}
		else if (Globals_Renamed.arOpBorC[Globals_Renamed.intOpIndex] == 1)
		{
			result = (short)((!(Globals_Renamed.arContParms[10, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] < 1f)) ? 93 : 105);
			Globals_Renamed.gblNumMetaNonDefaults = 2;
			Globals_Renamed.gblMetaNonDefaults = new object[2]
			{
				(short)2,
				(short)16
			};
		}
		else
		{
			result = (short)((!(Globals_Renamed.arContParms[10, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] < 1f)) ? 93 : 105);
			Globals_Renamed.gblNumMetaNonDefaults = 1;
			Globals_Renamed.gblMetaNonDefaults = new object[1] { (short)2 };
		}
		recordset.Close();
		recordset = null;
		command = null;
		return result;
	}

	public static short GetParmDefault1105(ref short pActID)
	{
		short result;
		if (Globals_Renamed.arOpBorC[Globals_Renamed.intOpIndex] == 1)
		{
			if (Globals_Renamed.arOpParms[17, Globals_Renamed.intOpIndex] < 1f)
			{
				result = 16;
				Globals_Renamed.gblNumMetaNonDefaults = 1;
				Globals_Renamed.gblMetaNonDefaults = new object[1] { (short)2 };
			}
			else
			{
				result = 2;
				Globals_Renamed.gblNumMetaNonDefaults = 1;
				Globals_Renamed.gblMetaNonDefaults = new object[1] { (short)16 };
			}
		}
		else
		{
			result = 2;
			Globals_Renamed.gblNumMetaNonDefaults = 0;
		}
		return result;
	}

	public static short GetParmDefault1104(ref short pActID)
	{
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
		Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		command.ActiveConnection = Common.MyConn;
		command.CommandText = "pqryGetActContTab";
		command.CommandType = CommandTypeEnum.adCmdStoredProc;
		command.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, pActID));
		Command command2 = command;
		object RecordsAffected = Missing.Value;
		object Parameters = Missing.Value;
		recordset = command2.Execute(out RecordsAffected, ref Parameters);
		command.Parameters.Delete("pActID");
		short result;
		if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields[0].Value)))
		{
			if (Globals_Renamed.arOpBorC[Globals_Renamed.intOpIndex] == 1)
			{
				if (Globals_Renamed.arOpParms[17, Globals_Renamed.intOpIndex] < 1f)
				{
					result = 16;
					Globals_Renamed.gblNumMetaNonDefaults = 1;
					Globals_Renamed.gblMetaNonDefaults = new object[1] { (short)2 };
				}
				else
				{
					result = 2;
					Globals_Renamed.gblNumMetaNonDefaults = 1;
					Globals_Renamed.gblMetaNonDefaults = new object[1] { (short)16 };
				}
			}
			else
			{
				result = 2;
				Globals_Renamed.gblNumMetaNonDefaults = 0;
			}
		}
		else if (Globals_Renamed.arOpBorC[Globals_Renamed.intOpIndex] == 1)
		{
			result = 93;
			Globals_Renamed.gblNumMetaNonDefaults = 3;
			Globals_Renamed.gblMetaNonDefaults = new object[3]
			{
				(short)2,
				(short)16,
				(short)105
			};
		}
		else
		{
			result = 93;
			Globals_Renamed.gblNumMetaNonDefaults = 2;
			Globals_Renamed.gblMetaNonDefaults = new object[2]
			{
				(short)2,
				(short)105
			};
		}
		recordset.Close();
		recordset = null;
		command = null;
		return result;
	}

	public static short GetParmDefault1115(ref short pActID)
	{
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
		Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		command.ActiveConnection = Common.MyConn;
		command.CommandText = "pqryGetActContTab";
		command.CommandType = CommandTypeEnum.adCmdStoredProc;
		command.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, pActID));
		Command command2 = command;
		object RecordsAffected = Missing.Value;
		object Parameters = Missing.Value;
		recordset = command2.Execute(out RecordsAffected, ref Parameters);
		command.Parameters.Delete("pActID");
		short result;
		if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields[0].Value)))
		{
			result = 0;
			Globals_Renamed.gblNumMetaNonDefaults = 0;
		}
		else if (Globals_Renamed.arOpBorC[Globals_Renamed.intOpIndex] == 1)
		{
			result = 93;
			Globals_Renamed.gblNumMetaNonDefaults = 2;
			Globals_Renamed.gblMetaNonDefaults = new object[2]
			{
				(short)2,
				(short)16
			};
		}
		else
		{
			result = 93;
			Globals_Renamed.gblNumMetaNonDefaults = 1;
			Globals_Renamed.gblMetaNonDefaults = new object[1] { (short)2 };
		}
		recordset.Close();
		recordset = null;
		command = null;
		return result;
	}

	public static short GetParmDefault1101(ref short pActID)
	{
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
		Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		command.ActiveConnection = Common.MyConn;
		command.CommandText = "pqryGetActContTab";
		command.CommandType = CommandTypeEnum.adCmdStoredProc;
		command.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, pActID));
		Command command2 = command;
		object RecordsAffected = Missing.Value;
		object Parameters = Missing.Value;
		recordset = command2.Execute(out RecordsAffected, ref Parameters);
		command.Parameters.Delete("pActID");
		short result;
		if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields[0].Value)))
		{
			if (Globals_Renamed.arOpBorC[Globals_Renamed.intOpIndex] == 1)
			{
				if (Globals_Renamed.arOpParms[17, Globals_Renamed.intOpIndex] < 1f)
				{
					if (Globals_Renamed.arOpType[Globals_Renamed.intOpIndex] == 1)
					{
						result = 104;
						Globals_Renamed.gblNumMetaNonDefaults = 3;
						Globals_Renamed.gblMetaNonDefaults = new object[3]
						{
							(short)103,
							(short)109,
							(short)108
						};
					}
					else
					{
						result = 103;
						Globals_Renamed.gblNumMetaNonDefaults = 3;
						Globals_Renamed.gblMetaNonDefaults = new object[3]
						{
							(short)103,
							(short)109,
							(short)108
						};
					}
				}
				else if (Globals_Renamed.arOpType[Globals_Renamed.intOpIndex] == 1)
				{
					result = 106;
					Globals_Renamed.gblNumMetaNonDefaults = 5;
					Globals_Renamed.gblMetaNonDefaults = new object[5]
					{
						(short)103,
						(short)104,
						(short)107,
						(short)33,
						(short)123
					};
				}
				else
				{
					result = 107;
					Globals_Renamed.gblNumMetaNonDefaults = 5;
					Globals_Renamed.gblMetaNonDefaults = new object[5]
					{
						(short)103,
						(short)104,
						(short)106,
						(short)33,
						(short)123
					};
				}
			}
			else if (Globals_Renamed.arOpType[Globals_Renamed.intOpIndex] == 1)
			{
				result = 13;
				Globals_Renamed.gblNumMetaNonDefaults = 1;
				Globals_Renamed.gblMetaNonDefaults = new object[1] { (short)15 };
			}
			else
			{
				result = 15;
				Globals_Renamed.gblNumMetaNonDefaults = 1;
				Globals_Renamed.gblMetaNonDefaults = new object[1] { (short)13 };
			}
		}
		else if (Globals_Renamed.arOpBorC[Globals_Renamed.intOpIndex] == 1)
		{
			if (Globals_Renamed.arContParms[10, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] < 1f)
			{
				result = 111;
				Globals_Renamed.gblNumMetaNonDefaults = 9;
				Globals_Renamed.gblMetaNonDefaults = new object[9]
				{
					(short)103,
					(short)104,
					(short)106,
					(short)33,
					(short)123,
					(short)110,
					(short)109,
					(short)108,
					(short)107
				};
			}
			else
			{
				result = 112;
				Globals_Renamed.gblNumMetaNonDefaults = 10;
				Globals_Renamed.gblMetaNonDefaults = new object[10]
				{
					(short)103,
					(short)104,
					(short)106,
					(short)33,
					(short)123,
					(short)110,
					(short)109,
					(short)108,
					(short)107,
					(short)111
				};
			}
		}
		else if (Globals_Renamed.arContParms[10, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] < 1f)
		{
			result = 111;
			Globals_Renamed.gblNumMetaNonDefaults = 3;
			Globals_Renamed.gblMetaNonDefaults = new object[3]
			{
				(short)110,
				(short)15,
				(short)13
			};
		}
		else
		{
			result = 112;
			Globals_Renamed.gblNumMetaNonDefaults = 4;
			Globals_Renamed.gblMetaNonDefaults = new object[4]
			{
				(short)110,
				(short)15,
				(short)13,
				(short)111
			};
		}
		recordset.Close();
		recordset = null;
		command = null;
		return result;
	}

	public static short GetParmDefault1114(ref short pActID)
	{
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
		Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		command.ActiveConnection = Common.MyConn;
		command.CommandText = "pqryGetActContTab";
		command.CommandType = CommandTypeEnum.adCmdStoredProc;
		command.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, pActID));
		Command command2 = command;
		object RecordsAffected = Missing.Value;
		object Parameters = Missing.Value;
		recordset = command2.Execute(out RecordsAffected, ref Parameters);
		command.Parameters.Delete("pActID");
		short result;
		if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields[0].Value)))
		{
			result = 0;
			Globals_Renamed.gblNumMetaNonDefaults = 0;
			Globals_Renamed.gblMetaNonDefaults = new object[0];
		}
		else
		{
			result = 112;
			if (Globals_Renamed.arOpBorC[Globals_Renamed.intOpIndex] == 1)
			{
				if (Globals_Renamed.arContParms[10, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] < 1f)
				{
					Globals_Renamed.gblNumMetaNonDefaults = 9;
					Globals_Renamed.gblMetaNonDefaults = new object[9]
					{
						(short)110,
						(short)103,
						(short)104,
						(short)109,
						(short)108,
						(short)107,
						(short)106,
						(short)33,
						(short)123
					};
				}
				else
				{
					Globals_Renamed.gblNumMetaNonDefaults = 10;
					Globals_Renamed.gblMetaNonDefaults = new object[10]
					{
						(short)110,
						(short)111,
						(short)103,
						(short)104,
						(short)109,
						(short)108,
						(short)107,
						(short)106,
						(short)33,
						(short)123
					};
				}
			}
			else
			{
				Globals_Renamed.gblNumMetaNonDefaults = 4;
				Globals_Renamed.gblMetaNonDefaults = new object[4]
				{
					(short)110,
					(short)111,
					(short)15,
					(short)13
				};
			}
		}
		recordset.Close();
		recordset = null;
		command = null;
		return result;
	}

	public static short GetParmDefault2109(ref short pModType, ref short pDualID)
	{
		switch (pModType)
		{
		case 49:
			if (Globals_Renamed.arOpSP[1, Globals_Renamed.intOpIndex] == 1f)
			{
				return 1;
			}
			return 2;
		case 40:
			if (Globals_Renamed.arOpSP[1, Globals_Renamed.intOpIndex] == 1f)
			{
				return 3;
			}
			return 4;
		case 50:
			return 4;
		default:
		{
			short result = default(short);
			return result;
		}
		}
	}

	public static float GetParmDefault3107(ref short pID, ref short pDualID, ref short pModType)
	{
		switch (pID)
		{
		case 43:
			if (Globals_Renamed.arOpSP[1, Globals_Renamed.intOpIndex] == 0f)
			{
				if (pDualID == 0)
				{
					return 0.65f;
				}
				return 0.2f;
			}
			if (Globals_Renamed.arOpSP[1, Globals_Renamed.intOpIndex] == 1f)
			{
				return 0.65f;
			}
			return 0.2f;
		case 45:
			return 0.96f;
		case 52:
			if (pModType == 48)
			{
				if (pDualID == 0)
				{
					return 1f;
				}
				return 0.9f;
			}
			return 1f;
		case 57:
			if (Globals_Renamed.arOpParms[3, Globals_Renamed.intOpIndex] == 1f)
			{
				if (Globals_Renamed.arOpParms[1, Globals_Renamed.intOpIndex] == 1f)
				{
					return 1.9f;
				}
				return 2.3f;
			}
			return 15f;
		case 142:
			if (Globals_Renamed.arOpSP[47, Globals_Renamed.intOpIndex] == 1f)
			{
				return 0.5f;
			}
			return 0.97f;
		default:
		{
			float result = default(float);
			return result;
		}
		}
	}

	public static short GetParmDefault1109(ref short pActID)
	{
		short result;
		if (Globals_Renamed.arOpBorC[Globals_Renamed.intOpIndex] == 1)
		{
			if (Globals_Renamed.arOpParms[17, Globals_Renamed.intOpIndex] < 1f)
			{
				if (Globals_Renamed.arOpIoE[Globals_Renamed.intOpIndex] == 0)
				{
					result = 103;
					Globals_Renamed.gblNumMetaNonDefaults = 3;
					Globals_Renamed.gblMetaNonDefaults = new object[3]
					{
						(short)104,
						(short)109,
						(short)108
					};
				}
				else
				{
					result = 104;
					Globals_Renamed.gblNumMetaNonDefaults = 3;
					Globals_Renamed.gblMetaNonDefaults = new object[3]
					{
						(short)103,
						(short)109,
						(short)108
					};
				}
			}
			else if (Globals_Renamed.arOpIoE[Globals_Renamed.intOpIndex] == 0)
			{
				result = 107;
				Globals_Renamed.gblNumMetaNonDefaults = 5;
				Globals_Renamed.gblMetaNonDefaults = new object[5]
				{
					(short)103,
					(short)104,
					(short)106,
					(short)33,
					(short)123
				};
			}
			else
			{
				result = 106;
				Globals_Renamed.gblNumMetaNonDefaults = 5;
				Globals_Renamed.gblMetaNonDefaults = new object[5]
				{
					(short)103,
					(short)104,
					(short)107,
					(short)33,
					(short)123
				};
			}
		}
		else if (Globals_Renamed.arOpIoE[Globals_Renamed.intOpIndex] == 0)
		{
			result = 15;
			Globals_Renamed.gblNumMetaNonDefaults = 1;
			Globals_Renamed.gblMetaNonDefaults = new object[1] { (short)13 };
		}
		else
		{
			result = 13;
			Globals_Renamed.gblNumMetaNonDefaults = 1;
			Globals_Renamed.gblMetaNonDefaults = new object[1] { (short)15 };
		}
		return result;
	}

	public static float GetParmDefault3104(ref short pActID, ref short pDualIndex)
	{
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
		Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		command.ActiveConnection = Common.MyConn;
		command.CommandText = "pqryGetActContTab";
		command.CommandType = CommandTypeEnum.adCmdStoredProc;
		command.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, pActID));
		Command command2 = command;
		object RecordsAffected = Missing.Value;
		object Parameters = Missing.Value;
		recordset = command2.Execute(out RecordsAffected, ref Parameters);
		command.Parameters.Delete("pActID");
		short pParmID = 31;
		float num = ChemStrX.FindAssocRelModelValue(ref pParmID, ref pDualIndex);
		float result;
		if (num > 0f)
		{
			result = Conversions.ToSingle(Interaction.IIf(num > 8f, (object)8, (object)num));
		}
		else if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields[0].Value)))
		{
			result = ((!(Globals_Renamed.arContParms[7, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] < 8f)) ? 8f : Globals_Renamed.arContParms[7, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex]);
		}
		else
		{
			Type? typeFromHandle = typeof(Strings);
			object[] array = new object[1];
			Field field = recordset.Fields[2];
			array[0] = RuntimeHelpers.GetObjectValue(field.Value);
			object[] array2 = array;
			bool[] array3 = new bool[1] { true };
			object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "LCase", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				field.Value = RuntimeHelpers.GetObjectValue(array2[0]);
			}
			result = ((Strings.InStr(Conversions.ToString(obj), "sampling", (CompareMethod)0) > 0) ? 1f : (pActID switch
			{
				27 => 4f, 
				28 => 1f, 
				29 => 0.5f, 
				_ => 8f, 
			}));
		}
		recordset.Close();
		recordset = null;
		command = null;
		return result;
	}

	public static void LinkFreq(ref short z, ref short pDualIndex)
	{
		checked
		{
			if (z != -1 && ((Globals_Renamed.arExpModType[z] == 22) | (Globals_Renamed.arExpModType[z] == 46) | (Globals_Renamed.arExpModType[z] == 45)) && Globals_Renamed.arExpModParmsT[pDualIndex, 75, z] == 1)
			{
				Globals_Renamed.arExpModParmsV[pDualIndex, 75, z] = GetParmDefault2105(ref Globals_Renamed.arSelActType[Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex], ref Globals_Renamed.arExpModType[Globals_Renamed.arExpModels[1, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1], ref pDualIndex);
				if (Globals_Renamed.arExpModParmsV[pDualIndex, 75, z] < 0f)
				{
					Globals_Renamed.arExpModParmsVC[pDualIndex, 75, z] = (short)Math.Round(Math.Abs(Globals_Renamed.arExpModParmsV[pDualIndex, 75, z]));
					Globals_Renamed.arExpModParmsV[pDualIndex, 75, z] = 0f;
				}
			}
		}
	}

	public static void LinkGinput(ref short z, ref short pDualIndex)
	{
		short pParmID = 72;
		short num = ChemStrX.FindAssocRelModelIndex(ref pParmID);
		if (num > -1 && z != -1 && ((Globals_Renamed.arExpModType[z] == 22) | (Globals_Renamed.arExpModType[z] == 54)))
		{
			if (Globals_Renamed.arRelModOutputOn[pDualIndex, Globals_Renamed.intModIndex] == 1)
			{
				Globals_Renamed.arExpModParmsV[pDualIndex, 50, z] = Globals_Renamed.arRelModParmsV[pDualIndex, 49, Globals_Renamed.intModIndex];
			}
			else if (pDualIndex == 0)
			{
				Globals_Renamed.arExpModParmsV[pDualIndex, 50, z] = Globals_Renamed.arRelModParmsV[1, 49, Globals_Renamed.intModIndex];
			}
			else
			{
				Globals_Renamed.arExpModParmsV[pDualIndex, 50, z] = Globals_Renamed.arRelModParmsV[0, 49, Globals_Renamed.intModIndex];
			}
		}
	}

	public static void LinkGoutput(ref short z, ref short pDualIndex)
	{
		short pParmID = 72;
		short num = ChemStrX.FindAssocRelModelIndex(ref pParmID);
		if (num > -1 && z != -1 && ((Globals_Renamed.arExpModType[z] == 22) | (Globals_Renamed.arExpModType[z] == 54)))
		{
			if (Globals_Renamed.arRelModOutputOn[pDualIndex, Globals_Renamed.intModIndex] == 1)
			{
				Globals_Renamed.arExpModParmsV[pDualIndex, 50, z] = Globals_Renamed.arRelModParmsV[pDualIndex, 50, Globals_Renamed.intModIndex];
			}
			else if (pDualIndex == 0)
			{
				Globals_Renamed.arExpModParmsV[pDualIndex, 50, z] = Globals_Renamed.arRelModParmsV[1, 50, Globals_Renamed.intModIndex];
			}
			else
			{
				Globals_Renamed.arExpModParmsV[pDualIndex, 50, z] = Globals_Renamed.arRelModParmsV[0, 50, Globals_Renamed.intModIndex];
			}
		}
	}

	public static void LinkX(ref short z, ref short pDualIndex)
	{
		if (z != -1 && ((Globals_Renamed.arExpModType[z] == 22) | (Globals_Renamed.arExpModType[z] == 45)) && Globals_Renamed.arExpModParmsT[pDualIndex, 40, z] == 1)
		{
			Globals_Renamed.arExpModParmsV[pDualIndex, 40, z] = GetParmDefault1111(ref Globals_Renamed.arSelActType[Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex], ref pDualIndex);
			if (Globals_Renamed.arExpModParmsV[pDualIndex, 40, z] < 0f)
			{
				Globals_Renamed.arExpModParmsVC[pDualIndex, 40, z] = checked((short)Math.Round(Math.Abs(Globals_Renamed.arExpModParmsV[pDualIndex, 40, z])));
			}
			else
			{
				Globals_Renamed.arExpModParmsVC[pDualIndex, 40, z] = 998;
			}
		}
	}

	public static void LinkVzCB(ref short z, ref short pDualIndex)
	{
		checked
		{
			if (z != -1 && Globals_Renamed.arExpModType[z] == 22 && Globals_Renamed.arExpModParmsT[pDualIndex, 53, Globals_Renamed.arExpModels[1, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1] == 1)
			{
				Globals_Renamed.arExpModParmsV[pDualIndex, 53, Globals_Renamed.arExpModels[1, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1] = GetParmDefault3101(ref Globals_Renamed.arSelActType[Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex], ref pDualIndex);
			}
		}
	}

	public static void LinkOHa(ref short z, ref short pDualIndex)
	{
		checked
		{
			if (z != -1 && ((Globals_Renamed.arExpModType[z] == 22) | (Globals_Renamed.arExpModType[z] == 46) | (Globals_Renamed.arExpModType[z] == 54)) && Globals_Renamed.arExpModParmsT[pDualIndex, 46, Globals_Renamed.arExpModels[1, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1] == 1)
			{
				Globals_Renamed.arExpModParmsV[pDualIndex, 46, Globals_Renamed.arExpModels[1, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1] = GetParmDefault3104(ref Globals_Renamed.arSelActType[Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex], ref pDualIndex);
			}
		}
	}

	public static void LinkVP(ref short z, ref short pDualIndex)
	{
		checked
		{
			if (z != -1 && ((Globals_Renamed.arExpModType[z] == 22) | (Globals_Renamed.arExpModType[z] == 45)) && Globals_Renamed.arExpModParmsT[pDualIndex, 4, Globals_Renamed.arExpModels[1, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1] == 1)
			{
				Globals_Renamed.arExpModParmsV[pDualIndex, 4, Globals_Renamed.arExpModels[1, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1] = GetParmDefault3109(ref pDualIndex);
			}
		}
	}

	public static float GetParmDefault3116(ref short pActID, ref short pDualIndex)
	{
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
		Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		Globals_Renamed.gblNumMetaNonDefaults = 1;
		command.ActiveConnection = Common.MyConn;
		command.CommandText = "pqryGetActContTab";
		command.CommandType = CommandTypeEnum.adCmdStoredProc;
		command.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, pActID));
		Command command2 = command;
		object RecordsAffected = Missing.Value;
		object Parameters = Missing.Value;
		recordset = command2.Execute(out RecordsAffected, ref Parameters);
		command.Parameters.Delete("pActID");
		float num;
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields[0].Value)))
		{
			num = ((!(Globals_Renamed.arContParms[3, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] < 5000f)) ? 7.6f : 5.08f);
		}
		else
		{
			short num2 = pActID;
			if (num2 == 27)
			{
				num = 92f;
			}
			else if (num2 == 28)
			{
				num = 92f;
			}
			else if (num2 == 29)
			{
				num = 92f;
			}
			else
			{
				if ((num2 != 1 && num2 != 55 && num2 != 56) || 1 == 0)
				{
					num = -1f;
					Globals_Renamed.gblMetaNonDefaults = new object[1] { 0 };
					Globals_Renamed.gblMetaNonDefaultCaps = new object[1] { "Model" };
					goto IL_02d5;
				}
				if (pDualIndex == 0)
				{
					Globals_Renamed.gblNumMetaNonDefaults = 2;
					Globals_Renamed.gblMetaNonDefaults = new object[2] { 2.5, 10 };
					Globals_Renamed.gblMetaNonDefaultCaps = new object[2] { "Typical", "Worst Case" };
					num = 2.5f;
				}
				else
				{
					Globals_Renamed.gblNumMetaNonDefaults = 2;
					Globals_Renamed.gblMetaNonDefaults = new object[2] { 10, 2.5 };
					Globals_Renamed.gblMetaNonDefaultCaps = new object[2] { "Worst Case", "Typical" };
					num = 10f;
				}
			}
		}
		if (Globals_Renamed.gblNumMetaNonDefaults == 1)
		{
			Globals_Renamed.gblMetaNonDefaults = new object[1] { num };
			Globals_Renamed.gblMetaNonDefaultCaps = new object[1] { "Model" };
		}
		recordset.Close();
		recordset = null;
		command = null;
		goto IL_02d5;
		IL_02d5:
		return num;
	}

	public static float GetParmDefault3118(ref short pDualIndex)
	{
		if (pDualIndex == 0)
		{
			Globals_Renamed.gblMetaNonDefaults = new object[2] { 0.0477, 0.161 };
			Globals_Renamed.gblMetaNonDefaultCaps = new object[2] { "Typical", "Worst Case" };
		}
		else
		{
			Globals_Renamed.gblMetaNonDefaults = new object[2] { 0.161, 0.0477 };
			Globals_Renamed.gblMetaNonDefaultCaps = new object[2] { "Worst Case", "Typical" };
		}
		Globals_Renamed.gblNumMetaNonDefaults = 2;
		return Conversions.ToSingle(Globals_Renamed.gblMetaNonDefaults[0]);
	}

	public static float GetParmDefault3122(ref short pModIndex, ref short pDualID)
	{
		float pYmist = ((Globals_Renamed.arExpModParmsVC[pDualID, 59, pModIndex] == 999) ? Globals_Renamed.arExpModParmsV[pDualID, 59, pModIndex] : ((Globals_Renamed.arExpModParmsV[pDualID, Globals_Renamed.arExpModParmsVC[pDualID, 59, pModIndex], pModIndex] != 0f) ? Globals_Renamed.arExpModParmsV[pDualID, Globals_Renamed.arExpModParmsVC[pDualID, 59, pModIndex], pModIndex] : Globals_Renamed.arOpParms[Globals_Renamed.arExpModParmsVC[pDualID, 59, pModIndex], Globals_Renamed.intOpIndex]));
		return GetParmDefault3122Guts(ref Globals_Renamed.arExpModParmsV[pDualID, 68, pModIndex], ref pYmist);
	}

	public static float GetParmDefault3122Guts(ref float pYsf, ref float pYmist)
	{
		if (pYsf > 0f)
		{
			float num = pYmist / pYsf;
			return Conversions.ToSingle(Interaction.IIf(num < 1f, (object)ChemStrX.ShowInSciNot(num), (object)1));
		}
		return 1f;
	}

	public static float GetParmDefault3121(ref short pDualIndex)
	{
		if (pDualIndex == 0)
		{
			return 1f;
		}
		return 2f;
	}

	public static float GetParmDefault3120(ref short pDualIndex)
	{
		if (pDualIndex == 0)
		{
			Globals_Renamed.gblMetaNonDefaults = new object[2] { 535, 1070 };
			Globals_Renamed.gblMetaNonDefaultCaps = new object[2] { "Low, one hand", "High, two hands" };
		}
		else
		{
			Globals_Renamed.gblMetaNonDefaults = new object[2] { 1070, 535 };
			Globals_Renamed.gblMetaNonDefaultCaps = new object[2] { "High, two hands", "Low, one hand" };
		}
		Globals_Renamed.gblNumMetaNonDefaults = 2;
		return Conversions.ToSingle(Globals_Renamed.gblMetaNonDefaults[0]);
	}

	public static float GetParmDefault3119(ref short pModType, ref short pDualIndex)
	{
		switch (pModType)
		{
		case 25:
		case 26:
		case 44:
			Globals_Renamed.gblNumMetaNonDefaults = 2;
			if (pDualIndex == 0)
			{
				Globals_Renamed.gblMetaNonDefaults = new object[2] { 0.7, 2.1 };
				Globals_Renamed.gblMetaNonDefaultCaps = new object[2] { "Low", "High" };
			}
			else
			{
				Globals_Renamed.gblMetaNonDefaults = new object[2] { 2.1, 0.7 };
				Globals_Renamed.gblMetaNonDefaultCaps = new object[2] { "High", "Low" };
			}
			break;
		case 27:
			Globals_Renamed.gblNumMetaNonDefaults = 2;
			if (pDualIndex == 0)
			{
				Globals_Renamed.gblMetaNonDefaults = new object[2] { 1.3, 10.3 };
				Globals_Renamed.gblMetaNonDefaultCaps = new object[2] { "Low", "High" };
			}
			else
			{
				Globals_Renamed.gblMetaNonDefaults = new object[2] { 10.3, 1.3 };
				Globals_Renamed.gblMetaNonDefaultCaps = new object[2] { "High", "Low" };
			}
			break;
		}
		return Conversions.ToSingle(Globals_Renamed.gblMetaNonDefaults[0]);
	}

	public static float GetParmDefault3117(ref short pActID, ref short pDualIndex)
	{
		switch (pActID)
		{
		case 3:
		case 4:
		case 5:
		case 6:
		case 11:
		case 12:
		case 13:
		case 14:
		case 19:
		case 20:
		case 21:
		case 22:
		case 61:
		case 62:
		case 63:
		case 64:
			return Conversions.ToSingle(Interaction.IIf(pDualIndex == 0, (object)0.5, (object)1));
		default:
			return 1f;
		}
	}
}
