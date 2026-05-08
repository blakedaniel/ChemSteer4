using System;
using System.Data.OleDb;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ADODB;
using ChemSteer.My;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ChemSteer;

[StandardModule]
internal sealed class crDriver
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static object _DialogResult;

	private static object DialogResult
	{
		[DebuggerNonUserCode]
		get
		{
			return _DialogResult;
		}
		[DebuggerNonUserCode]
		set
		{
			_DialogResult = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public static void doContRpt(int index)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
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
					OleDbDataAdapter val = new OleDbDataAdapter();
					Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
					Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					recordset.CursorLocation = CursorLocationEnum.adUseClient;
					ProjectData.ClearProjectError();
					num2 = 2;
					ReportDocument val2 = new ReportDocument();
					string text = Application.StartupPath + "\\reports\\ContRpt.rpt";
					if (Globals_Renamed.gblDataVersion < Globals_Renamed.gblCurrentDV)
					{
						Interaction.MsgBox((object)"You have opened an assessment that was last saved in a previous version of ChemSTEER. You will need to do a Save Assessment As before running reports.", (MsgBoxStyle)64, (object)"Version Warning");
						goto end_IL_0001;
					}
					if ((Strings.Len(Globals_Renamed.gblDBName) == 0) | Globals_Renamed.gblIWasChanged)
					{
						Interaction.Beep();
						Interaction.MsgBox((object)"Please save the current assessment before running a report.", (MsgBoxStyle)64, (object)"Invalid Request");
						goto end_IL_0001;
					}
					val2.Load(text);
					val2.DataSourceConnections[0].SetConnection("", Globals_Renamed.gblDBName, false);
					val2.RecordSelectionFormula = "{prhContRpt.AssessID}=" + Conversions.ToString((int)Globals_Renamed.gblAssessID);
					if (index == 0)
					{
						MyProject.Forms.frmCRViewer.CrystalReportViewer1.ReportSource = val2;
						((Form)MyProject.Forms.frmCRViewer).Text = "Contact Report";
						((Control)MyProject.Forms.frmCRViewer).Show();
						goto end_IL_0001;
					}
					SaveFileDialog val3 = new SaveFileDialog();
					SaveFileDialog val4 = val3;
					((FileDialog)val4).Title = "Select a folder and file name for your Contact report";
					((FileDialog)val4).DefaultExt = "RTF";
					((FileDialog)val4).CheckFileExists = false;
					((FileDialog)val4).FileName = "*.rtf";
					((FileDialog)val4).Filter = "RTF Files (*.RTF)|*.RTF|Text Files (*.TXT)|*.TXT|PDF Files (*.PDF)|*.PDF";
					val4 = null;
					object objectValue = RuntimeHelpers.GetObjectValue(DialogResult);
					objectValue = ((CommonDialog)val3).ShowDialog();
					if (!Operators.ConditionalCompareObjectNotEqual(objectValue, (object)(DialogResult)1, false))
					{
						string text2 = Strings.LCase(Strings.Right(((FileDialog)val3).FileName, 3));
						int num3 = ((Operators.CompareString(text2, "pdf", false) == 0) ? 5 : ((Operators.CompareString(text2, "rtf", false) != 0) ? 9 : 2));
						val2.ExportToDisk((ExportFormatType)num3, ((FileDialog)val3).FileName);
						Interaction.MsgBox((object)"The Contact report has been saved to disk", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
					}
					goto end_IL_0001;
				}
				case 683:
					num = -1;
					switch (num2)
					{
					case 2:
						Interaction.MsgBox((object)(Conversions.ToString(Information.Err().Number) + ": " + Information.Err().Description + "; " + Information.Err().GetException().InnerException.Message), (MsgBoxStyle)1, (object)"bombing");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 683;
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

	public static void doIrerRpt(frmMain pForm, int index)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Invalid comparison between Unknown and I4
		//IL_0b15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1c: Expected O, but got Unknown
		//IL_0b6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1c: Unknown result type (might be due to invalid IL or missing references)
		string pWork = "";
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		ReportDocument val = new ReportDocument();
		recordset.CursorLocation = CursorLocationEnum.adUseClient;
		if (Globals_Renamed.gblDataVersion < Globals_Renamed.gblCurrentDV)
		{
			Interaction.MsgBox((object)"You have opened an assessment that was last saved in a previous version of ChemSTEER. You will need to do a Save Assessment As before running reports.", (MsgBoxStyle)64, (object)"Version Warning");
		}
		else if ((Strings.Len(Globals_Renamed.gblDBName) == 0) | Globals_Renamed.gblIWasChanged)
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Please save the current assessment before running a report.", (MsgBoxStyle)64, (object)"Invalid Request");
		}
		else
		{
			if (!ChemStrX.chkModelsRun())
			{
				return;
			}
			string text;
			if (((Strings.Len(pForm.lblOccExpRating.Text) == 0) | (Operators.CompareString(pForm.lblConsUse.Text, "", false) == 0)) && index == 1)
			{
				Interaction.Beep();
				text = (((Strings.Len(pForm.lblOccExpRating.Text) == 0) & (Operators.CompareString(pForm.lblConsUse.Text, "", false) == 0)) ? "an Occupational Exposure Rating or a Consumer Use Indicator" : ((Strings.Len(pForm.lblOccExpRating.Text) != 0) ? "Consumer Use Indicator" : "an Occupational Exposure Rating"));
				if ((int)Interaction.MsgBox((object)("Your assessment currently does not have " + text + " specified. Are you sure you want to continue?"), (MsgBoxStyle)36, (object)"Missing Information") == 7)
				{
					return;
				}
			}
			text = "";
			recordset.Open("SELECT * FROM SAT WHERE AssessID=" + Conversions.ToString((int)Globals_Renamed.gblAssessID), Common.DataConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
			string pDelim = ", ";
			string pDesc = "Dermal";
			Field field = recordset.Fields["Dermal"];
			object pValue = RuntimeHelpers.GetObjectValue(field.Value);
			object pYes = 1;
			string text2 = Common.Stacker(ref text, ref pDelim, ref pDesc, ref pValue, ref pYes);
			field.Value = RuntimeHelpers.GetObjectValue(pValue);
			text = text2;
			pDesc = ", ";
			pDelim = "Drinking Water";
			field = recordset.Fields["DW"];
			pYes = RuntimeHelpers.GetObjectValue(field.Value);
			pValue = 1;
			string text3 = Common.Stacker(ref text, ref pDesc, ref pDelim, ref pYes, ref pValue);
			field.Value = RuntimeHelpers.GetObjectValue(pYes);
			text = text3;
			pDesc = ", ";
			pDelim = "Inhalation";
			field = recordset.Fields["Inh"];
			pYes = RuntimeHelpers.GetObjectValue(field.Value);
			pValue = 1;
			string text4 = Common.Stacker(ref text, ref pDesc, ref pDelim, ref pYes, ref pValue);
			field.Value = RuntimeHelpers.GetObjectValue(pYes);
			text = text4;
			pDesc = ", ";
			pDelim = "Not Required";
			field = recordset.Fields["NR"];
			pYes = RuntimeHelpers.GetObjectValue(field.Value);
			pValue = 1;
			string text5 = Common.Stacker(ref text, ref pDesc, ref pDelim, ref pYes, ref pValue);
			field.Value = RuntimeHelpers.GetObjectValue(pYes);
			text = text5;
			Field field2;
			if (Strings.Len(RuntimeHelpers.GetObjectValue(recordset.Fields["OtherReqDesc"].Value)) > 0)
			{
				pDesc = ", ";
				field = recordset.Fields["OtherReqDesc"];
				pDelim = Conversions.ToString(field.Value);
				field2 = recordset.Fields["OtherReq"];
				pYes = RuntimeHelpers.GetObjectValue(field2.Value);
				pValue = 1;
				string text6 = Common.Stacker(ref text, ref pDesc, ref pDelim, ref pYes, ref pValue);
				field2.Value = RuntimeHelpers.GetObjectValue(pYes);
				field.Value = pDelim;
				text = text6;
			}
			else
			{
				pDesc = ", ";
				pDelim = "Other";
				field2 = recordset.Fields["OtherReq"];
				pYes = RuntimeHelpers.GetObjectValue(field2.Value);
				pValue = 1;
				string text7 = Common.Stacker(ref text, ref pDesc, ref pDelim, ref pYes, ref pValue);
				field2.Value = RuntimeHelpers.GetObjectValue(pYes);
				text = text7;
			}
			string text8 = ((!Operators.ConditionalCompareObjectEqual(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["HealthXPYesNo"].Value)), (object)0, false)) ? "" : "No ");
			if (Strings.Len(RuntimeHelpers.GetObjectValue(recordset.Fields["HealthXPDesc"].Value)) > 0)
			{
				pDesc = ", ";
				pDelim = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("XB Testing (" + text8), recordset.Fields["HealthXPDesc"].Value), (object)")"));
				field2 = recordset.Fields["HealthXP"];
				pYes = RuntimeHelpers.GetObjectValue(field2.Value);
				pValue = 1;
				string text9 = Common.Stacker(ref text, ref pDesc, ref pDelim, ref pYes, ref pValue);
				field2.Value = RuntimeHelpers.GetObjectValue(pYes);
				text = text9;
			}
			else
			{
				pDesc = ", ";
				pDelim = "XB Testing";
				field2 = recordset.Fields["HealthXP"];
				pYes = RuntimeHelpers.GetObjectValue(field2.Value);
				pValue = 1;
				string text10 = Common.Stacker(ref text, ref pDesc, ref pDelim, ref pYes, ref pValue);
				field2.Value = RuntimeHelpers.GetObjectValue(pYes);
				text = text10;
			}
			if (Strings.Len(RuntimeHelpers.GetObjectValue(recordset.Fields["cc"].Value)) > 0)
			{
				pDesc = ", ";
				pDelim = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Water (", recordset.Fields["cc"].Value), (object)")"));
				field2 = recordset.Fields["EcoW"];
				pYes = RuntimeHelpers.GetObjectValue(field2.Value);
				pValue = 1;
				string text11 = Common.Stacker(ref pWork, ref pDesc, ref pDelim, ref pYes, ref pValue);
				field2.Value = RuntimeHelpers.GetObjectValue(pYes);
				pWork = text11;
			}
			else
			{
				pDesc = ", ";
				pDelim = "Water";
				field2 = recordset.Fields["EcoW"];
				pYes = RuntimeHelpers.GetObjectValue(field2.Value);
				pValue = 1;
				string text12 = Common.Stacker(ref pWork, ref pDesc, ref pDelim, ref pYes, ref pValue);
				field2.Value = RuntimeHelpers.GetObjectValue(pYes);
				pWork = text12;
			}
			pDesc = ", ";
			pDelim = "Air";
			field2 = recordset.Fields["EcoA"];
			pYes = RuntimeHelpers.GetObjectValue(field2.Value);
			pValue = 1;
			string text13 = Common.Stacker(ref pWork, ref pDesc, ref pDelim, ref pYes, ref pValue);
			field2.Value = RuntimeHelpers.GetObjectValue(pYes);
			pWork = text13;
			pDesc = ", ";
			pDelim = "Landfill";
			field2 = recordset.Fields["EcoL"];
			pYes = RuntimeHelpers.GetObjectValue(field2.Value);
			pValue = 1;
			string text14 = Common.Stacker(ref pWork, ref pDesc, ref pDelim, ref pYes, ref pValue);
			field2.Value = RuntimeHelpers.GetObjectValue(pYes);
			pWork = text14;
			pDesc = ", ";
			pDelim = "Not Required";
			field2 = recordset.Fields["EcoNR"];
			pYes = RuntimeHelpers.GetObjectValue(field2.Value);
			pValue = 1;
			string text15 = Common.Stacker(ref pWork, ref pDesc, ref pDelim, ref pYes, ref pValue);
			field2.Value = RuntimeHelpers.GetObjectValue(pYes);
			pWork = text15;
			if (Strings.Len(RuntimeHelpers.GetObjectValue(recordset.Fields["EcoODesc"].Value)) > 0)
			{
				pDesc = ", ";
				field2 = recordset.Fields["EcoODesc"];
				pDelim = Conversions.ToString(field2.Value);
				field = recordset.Fields["EcoO"];
				pYes = RuntimeHelpers.GetObjectValue(field.Value);
				pValue = 1;
				string text16 = Common.Stacker(ref pWork, ref pDesc, ref pDelim, ref pYes, ref pValue);
				field.Value = RuntimeHelpers.GetObjectValue(pYes);
				field2.Value = pDelim;
				pWork = text16;
			}
			else
			{
				pDesc = ", ";
				pDelim = "Other";
				field2 = recordset.Fields["EcoO"];
				pYes = RuntimeHelpers.GetObjectValue(field2.Value);
				pValue = 1;
				string text17 = Common.Stacker(ref pWork, ref pDesc, ref pDelim, ref pYes, ref pValue);
				field2.Value = RuntimeHelpers.GetObjectValue(pYes);
				pWork = text17;
			}
			text8 = ((!Operators.ConditionalCompareObjectEqual(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["EcoXPYesNo"].Value)), (object)0, false)) ? "" : "No ");
			if (Strings.Len(RuntimeHelpers.GetObjectValue(recordset.Fields["EcoXPDesc"].Value)) > 0)
			{
				pDesc = ", ";
				pDelim = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("XB Testing (" + text8), recordset.Fields["EcoXPDesc"].Value), (object)")"));
				field2 = recordset.Fields["EcoXP"];
				pYes = RuntimeHelpers.GetObjectValue(field2.Value);
				pValue = 1;
				string text18 = Common.Stacker(ref pWork, ref pDesc, ref pDelim, ref pYes, ref pValue);
				field2.Value = RuntimeHelpers.GetObjectValue(pYes);
				pWork = text18;
			}
			else
			{
				pDesc = ", ";
				pDelim = "XB Testing";
				field2 = recordset.Fields["EcoXP"];
				pYes = RuntimeHelpers.GetObjectValue(field2.Value);
				pValue = 1;
				string text19 = Common.Stacker(ref pWork, ref pDesc, ref pDelim, ref pYes, ref pValue);
				field2.Value = RuntimeHelpers.GetObjectValue(pYes);
				pWork = text19;
			}
			recordset.Close();
			string text20;
			int num;
			if (index < 2)
			{
				text20 = Application.StartupPath + "\\reports\\FullIrer.rpt";
				num = 10;
			}
			else
			{
				text20 = Application.StartupPath + "\\reports\\IrerComb.rpt";
				num = 11;
			}
			val.Load(text20);
			val.DataSourceConnections[0].SetConnection("", Globals_Renamed.gblDBName, false);
			int num2 = num;
			int num3 = 0;
			while (true)
			{
				int num4 = num3;
				int num5 = num2;
				if (num4 > num5)
				{
					break;
				}
				val.Subreports[num3].DataSourceConnections[0].SetConnection("", Globals_Renamed.gblDBName, false);
				num3 = checked(num3 + 1);
			}
			val.RecordSelectionFormula = "{prhOperations.AssessID}=" + Conversions.ToString((int)Globals_Renamed.gblAssessID);
			val.DataDefinition.FormulaFields["HRQ"].Text = "\"" + text + "\"";
			val.DataDefinition.FormulaFields["ERQ"].Text = "\"" + pWork + "\"";
			if (index == 0 || index == 2)
			{
				MyProject.Forms.frmCRViewer.CrystalReportViewer1.ReportSource = val;
				((Form)MyProject.Forms.frmCRViewer).Text = "IRER Report";
				((Control)MyProject.Forms.frmCRViewer).Show();
			}
			else
			{
				SaveFileDialog val2 = new SaveFileDialog();
				SaveFileDialog val3 = val2;
				((FileDialog)val3).Title = "Select a folder and file name for your IRER report";
				((FileDialog)val3).DefaultExt = "RTF";
				((FileDialog)val3).CheckFileExists = false;
				((FileDialog)val3).FileName = "*.rtf";
				((FileDialog)val3).Filter = "RTF Files (*.RTF)|*.RTF|Text Files (*.TXT)|*.TXT|PDF Files (*.PDF)|*.PDF";
				val3 = null;
				object objectValue = RuntimeHelpers.GetObjectValue(DialogResult);
				objectValue = ((CommonDialog)val2).ShowDialog();
				if (Operators.ConditionalCompareObjectNotEqual(objectValue, (object)(DialogResult)1, false))
				{
					return;
				}
				string text21 = Strings.LCase(Strings.Right(((FileDialog)val2).FileName, 3));
				int num6 = ((Operators.CompareString(text21, "pdf", false) == 0) ? 5 : ((Operators.CompareString(text21, "rtf", false) != 0) ? 9 : 2));
				Cursor.Current = Cursors.WaitCursor;
				val.ExportToDisk((ExportFormatType)num6, ((FileDialog)val2).FileName);
				Cursor.Current = Cursors.Default;
				Interaction.MsgBox((object)"The IRER report has been saved to disk", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
			}
			recordset = null;
		}
	}
}
