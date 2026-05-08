using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ADODB;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Compatibility.VB6;
using Microsoft.VisualBasic.CompilerServices;

namespace ChemSteer;

[DesignerGenerated]
public class frmSelectEasyModel : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("cmdOk")]
	private Button _cmdOk;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("lstModels")]
	private ListBox _lstModels;

	[AccessedThroughProperty("lblTab1Instructions")]
	private Label _lblTab1Instructions;

	[AccessedThroughProperty("chkDermalModels")]
	private CheckBox _chkDermalModels;

	[AccessedThroughProperty("chkReleaseModels")]
	private CheckBox _chkReleaseModels;

	[AccessedThroughProperty("chkInhalationModels")]
	private CheckBox _chkInhalationModels;

	[AccessedThroughProperty("cmdHelp")]
	private Button _cmdHelp;

	public virtual Button cmdOk
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdOk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdOk_Click;
			if (_cmdOk != null)
			{
				((Control)_cmdOk).Click -= eventHandler;
			}
			_cmdOk = value;
			if (_cmdOk != null)
			{
				((Control)_cmdOk).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdCancel
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdCancel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdCancel_Click;
			if (_cmdCancel != null)
			{
				((Control)_cmdCancel).Click -= eventHandler;
			}
			_cmdCancel = value;
			if (_cmdCancel != null)
			{
				((Control)_cmdCancel).Click += eventHandler;
			}
		}
	}

	public virtual ListBox lstModels
	{
		[DebuggerNonUserCode]
		get
		{
			return _lstModels;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = lstModels_SelectedIndexChanged;
			if (_lstModels != null)
			{
				((Control)_lstModels).DoubleClick -= eventHandler;
			}
			_lstModels = value;
			if (_lstModels != null)
			{
				((Control)_lstModels).DoubleClick += eventHandler;
			}
		}
	}

	public virtual Label lblTab1Instructions
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTab1Instructions;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTab1Instructions = value;
		}
	}

	internal virtual CheckBox chkDermalModels
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkDermalModels;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = chkDermalModels_CheckedChanged;
			if (_chkDermalModels != null)
			{
				_chkDermalModels.CheckedChanged -= eventHandler;
			}
			_chkDermalModels = value;
			if (_chkDermalModels != null)
			{
				_chkDermalModels.CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual CheckBox chkReleaseModels
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkReleaseModels;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = chkReleaseModels_CheckedChanged;
			if (_chkReleaseModels != null)
			{
				_chkReleaseModels.CheckedChanged -= eventHandler;
			}
			_chkReleaseModels = value;
			if (_chkReleaseModels != null)
			{
				_chkReleaseModels.CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual CheckBox chkInhalationModels
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkInhalationModels;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = chkInhalationModels_CheckedChanged;
			if (_chkInhalationModels != null)
			{
				_chkInhalationModels.CheckedChanged -= eventHandler;
			}
			_chkInhalationModels = value;
			if (_chkInhalationModels != null)
			{
				_chkInhalationModels.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual Button cmdHelp
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdHelp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdHelp_Click;
			if (_cmdHelp != null)
			{
				((Control)_cmdHelp).Click -= eventHandler;
			}
			_cmdHelp = value;
			if (_cmdHelp != null)
			{
				((Control)_cmdHelp).Click += eventHandler;
			}
		}
	}

	[DebuggerNonUserCode]
	public frmSelectEasyModel()
	{
		((Form)this).Load += frmSelectEasyModel_Load;
		__ENCAddToList(this);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Expected O, but got Unknown
		//IL_0575: Unknown result type (might be due to invalid IL or missing references)
		//IL_057f: Expected O, but got Unknown
		//IL_06ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f8: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmSelectEasyModel));
		cmdOk = new Button();
		cmdCancel = new Button();
		lstModels = new ListBox();
		lblTab1Instructions = new Label();
		chkDermalModels = new CheckBox();
		chkReleaseModels = new CheckBox();
		chkInhalationModels = new CheckBox();
		cmdHelp = new Button();
		((Control)this).SuspendLayout();
		((ButtonBase)cmdOk).BackColor = SystemColors.Control;
		((Control)cmdOk).Cursor = Cursors.Default;
		((Control)cmdOk).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdOk).ForeColor = SystemColors.ControlText;
		Button obj = cmdOk;
		Point location = new Point(194, 348);
		((Control)obj).Location = location;
		((Control)cmdOk).Name = "cmdOk";
		((Control)cmdOk).RightToLeft = (RightToLeft)0;
		Button obj2 = cmdOk;
		Size size = new Size(97, 25);
		((Control)obj2).Size = size;
		((Control)cmdOk).TabIndex = 3;
		((ButtonBase)cmdOk).Text = "OK";
		((ButtonBase)cmdOk).UseVisualStyleBackColor = false;
		((ButtonBase)cmdCancel).BackColor = SystemColors.Control;
		((Control)cmdCancel).Cursor = Cursors.Default;
		cmdCancel.DialogResult = (DialogResult)2;
		((Control)cmdCancel).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCancel).ForeColor = SystemColors.ControlText;
		Button obj3 = cmdCancel;
		location = new Point(314, 348);
		((Control)obj3).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		((Control)cmdCancel).RightToLeft = (RightToLeft)0;
		Button obj4 = cmdCancel;
		size = new Size(97, 25);
		((Control)obj4).Size = size;
		((Control)cmdCancel).TabIndex = 4;
		((ButtonBase)cmdCancel).Text = "Cancel";
		((ButtonBase)cmdCancel).UseVisualStyleBackColor = false;
		lstModels.BackColor = Color.White;
		((Control)lstModels).Cursor = Cursors.Default;
		lstModels.Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		lstModels.ForeColor = SystemColors.WindowText;
		lstModels.ItemHeight = 14;
		ListBox obj5 = lstModels;
		location = new Point(15, 77);
		((Control)obj5).Location = location;
		((Control)lstModels).Name = "lstModels";
		lstModels.RightToLeft = (RightToLeft)0;
		ListBox obj6 = lstModels;
		size = new Size(689, 256);
		((Control)obj6).Size = size;
		((Control)lstModels).TabIndex = 19;
		((Control)lstModels).TabStop = false;
		((Control)lblTab1Instructions).BackColor = SystemColors.Control;
		((Control)lblTab1Instructions).Cursor = Cursors.Default;
		((Control)lblTab1Instructions).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblTab1Instructions).ForeColor = SystemColors.ControlText;
		Label obj7 = lblTab1Instructions;
		location = new Point(12, 9);
		((Control)obj7).Location = location;
		((Control)lblTab1Instructions).Name = "lblTab1Instructions";
		((Control)lblTab1Instructions).RightToLeft = (RightToLeft)0;
		Label obj8 = lblTab1Instructions;
		size = new Size(689, 36);
		((Control)obj8).Size = size;
		((Control)lblTab1Instructions).TabIndex = 20;
		lblTab1Instructions.Text = "Select a model to run.  You can only select one model. If you have changed your mind and do not want to run a model, select the Cancel button and you will be taken to the regular ChemSTEER screen.";
		((ButtonBase)chkDermalModels).AutoSize = true;
		CheckBox obj9 = chkDermalModels;
		location = new Point(205, 48);
		((Control)obj9).Location = location;
		((Control)chkDermalModels).Name = "chkDermalModels";
		CheckBox obj10 = chkDermalModels;
		size = new Size(143, 17);
		((Control)obj10).Size = size;
		((Control)chkDermalModels).TabIndex = 1;
		((ButtonBase)chkDermalModels).Text = "Dermal Exposure Models";
		((ButtonBase)chkDermalModels).UseVisualStyleBackColor = true;
		((ButtonBase)chkReleaseModels).AutoSize = true;
		CheckBox obj11 = chkReleaseModels;
		location = new Point(15, 48);
		((Control)obj11).Location = location;
		((Control)chkReleaseModels).Name = "chkReleaseModels";
		CheckBox obj12 = chkReleaseModels;
		size = new Size(102, 17);
		((Control)obj12).Size = size;
		((Control)chkReleaseModels).TabIndex = 0;
		((ButtonBase)chkReleaseModels).Text = "Release Models";
		((ButtonBase)chkReleaseModels).UseVisualStyleBackColor = true;
		((ButtonBase)chkInhalationModels).AutoSize = true;
		CheckBox obj13 = chkInhalationModels;
		location = new Point(394, 48);
		((Control)obj13).Location = location;
		((Control)chkInhalationModels).Name = "chkInhalationModels";
		CheckBox obj14 = chkInhalationModels;
		size = new Size(156, 17);
		((Control)obj14).Size = size;
		((Control)chkInhalationModels).TabIndex = 2;
		((ButtonBase)chkInhalationModels).Text = "Inhalation Exposure Models";
		((ButtonBase)chkInhalationModels).UseVisualStyleBackColor = true;
		((ButtonBase)cmdHelp).BackColor = SystemColors.Control;
		((Control)cmdHelp).Cursor = Cursors.Default;
		((Control)cmdHelp).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdHelp).ForeColor = SystemColors.ControlText;
		Button obj15 = cmdHelp;
		location = new Point(428, 348);
		((Control)obj15).Location = location;
		((Control)cmdHelp).Name = "cmdHelp";
		((Control)cmdHelp).RightToLeft = (RightToLeft)0;
		Button obj16 = cmdHelp;
		size = new Size(97, 25);
		((Control)obj16).Size = size;
		((Control)cmdHelp).TabIndex = 21;
		((ButtonBase)cmdHelp).Text = "Help";
		((ButtonBase)cmdHelp).UseVisualStyleBackColor = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(717, 395);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)cmdHelp);
		((Control)this).Controls.Add((Control)(object)chkInhalationModels);
		((Control)this).Controls.Add((Control)(object)chkReleaseModels);
		((Control)this).Controls.Add((Control)(object)chkDermalModels);
		((Control)this).Controls.Add((Control)(object)lstModels);
		((Control)this).Controls.Add((Control)(object)lblTab1Instructions);
		((Control)this).Controls.Add((Control)(object)cmdOk);
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Control)this).Name = "frmSelectEasyModel";
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Select a model";
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void frmSelectEasyModel_Load(object sender, EventArgs e)
	{
		chkReleaseModels.Checked = true;
	}

	private void cmdCancel_Click(object sender, EventArgs e)
	{
		lstModels.ClearSelected();
		((Form)this).Close();
	}

	private void cmdOk_Click(object sender, EventArgs e)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		if (lstModels.SelectedIndex == -1)
		{
			Interaction.MsgBox((object)"Please select the model you wish to run. If you have changed your mind, select the Cancel button and you will be taken to ChemSTEER.", (MsgBoxStyle)0, (object)null);
			return;
		}
		addDummyOperation();
		checked
		{
			if (chkReleaseModels.Checked)
			{
				ChemStrX.redimReleaseModelArrays(1, 1, bPreserve: false);
				short pModType = (short)Support.GetItemData((Control)(object)lstModels, lstModels.SelectedIndex);
				short pModNum = 0;
				ChemStrX.AddRelModel(ref pModType, ref pModNum);
				Globals_Renamed.arSelActRaDMP[1, Globals_Renamed.intOpIndex] = 9;
				int num = 0;
				int num5;
				int num4;
				do
				{
					int num2 = 1;
					int num3;
					do
					{
						if ((Globals_Renamed.arRelModParmsT[num, num2, 0] == 1) & (Globals_Renamed.arRelModParmsV[num, num2, 0] == 0f))
						{
							Globals_Renamed.arRelModParmsT[num, num2, 0] = 3;
							Globals_Renamed.arRelModParmsVC[num, num2, 0] = 999;
						}
						num2++;
						num3 = num2;
						num4 = 162;
					}
					while (num3 <= num4);
					num++;
					num5 = num;
					num4 = 1;
				}
				while (num5 <= num4);
			}
			else
			{
				ChemStrX.redimExposureModelArrays(1, 1, bPreserve: false);
				if (chkDermalModels.Checked)
				{
					short pModNum = (short)Support.GetItemData((Control)(object)lstModels, lstModels.SelectedIndex);
					short pModType = 0;
					ChemStrX.AddExpModel(ref pModNum, ref pModType);
					Globals_Renamed.arSelActEaDMP[0, Globals_Renamed.intOpIndex] = 9;
				}
				else
				{
					short pModNum = (short)Support.GetItemData((Control)(object)lstModels, lstModels.SelectedIndex);
					short pModType = 1;
					ChemStrX.AddExpModel(ref pModNum, ref pModType);
					Globals_Renamed.arSelActEaDMP[1, Globals_Renamed.intOpIndex] = 9;
				}
				int num = 0;
				int num7;
				int num4;
				do
				{
					int num2 = 1;
					int num6;
					do
					{
						if ((Globals_Renamed.arExpModParmsT[num, num2, 0] == 1) & (Globals_Renamed.arExpModParmsV[num, num2, 0] == 0f) & !unchecked(Support.GetItemData((Control)(object)lstModels, lstModels.SelectedIndex) == 54 && num2 == 64))
						{
							Globals_Renamed.arExpModParmsT[num, num2, 0] = 3;
							Globals_Renamed.arExpModParmsVC[num, num2, 0] = 999;
						}
						num2++;
						num6 = num2;
						num4 = 162;
					}
					while (num6 <= num4);
					num++;
					num7 = num;
					num4 = 1;
				}
				while (num7 <= num4);
			}
			((Form)this).Close();
		}
	}

	private void addDummyOperation()
	{
		Globals_Renamed.intNumOps = 1;
		Globals_Renamed.arOpName[0] = "Run Models";
		Globals_Renamed.arOpNeedsMassBalance[0] = 0;
		Globals_Renamed.arOpBorC[0] = 1;
		Globals_Renamed.arOpIoE[0] = 0;
		Globals_Renamed.arOpType[0] = 0;
		Globals_Renamed.arSelActs[0, 0] = "Run Models";
		Globals_Renamed.arSelActType[0, 0] = 80;
		Globals_Renamed.arSelActRa[0, 0] = true;
		Globals_Renamed.arSelActEa[0, 0] = true;
		Globals_Renamed.arActOrder[0, 0] = 1;
		Globals_Renamed.arNoPre[0] = true;
	}

	private void chkReleaseModels_CheckedChanged(object sender, EventArgs e)
	{
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		if (chkReleaseModels.Checked)
		{
			Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
			Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
			chkDermalModels.Checked = false;
			chkInhalationModels.Checked = false;
			lstModels.Items.Clear();
			recordset.CursorLocation = CursorLocationEnum.adUseClient;
			recordset.Open("SELECT * FROM qryListOfRelModels WHERE MODELID NOT IN (12,13,14,51,52)", Common.MyConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
			while (!recordset.EOF)
			{
				lstModels.Items.Add((object)new ListBoxItem(Conversions.ToString(recordset.Fields[1].Value), Conversions.ToInteger(recordset.Fields[0].Value)));
				recordset.MoveNext();
			}
			recordset.Close();
		}
	}

	private void chkDermalModels_CheckedChanged(object sender, EventArgs e)
	{
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		if (chkDermalModels.Checked)
		{
			Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
			Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
			chkReleaseModels.Checked = false;
			chkInhalationModels.Checked = false;
			lstModels.Items.Clear();
			recordset.CursorLocation = CursorLocationEnum.adUseClient;
			recordset.Open("SELECT * FROM qryListOfDExpModels", Common.MyConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
			while (!recordset.EOF)
			{
				lstModels.Items.Add((object)new ListBoxItem(Conversions.ToString(recordset.Fields[1].Value), Conversions.ToInteger(recordset.Fields[0].Value)));
				recordset.MoveNext();
			}
			recordset.Close();
		}
	}

	private void chkInhalationModels_CheckedChanged(object sender, EventArgs e)
	{
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		if (chkInhalationModels.Checked)
		{
			Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
			Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
			chkReleaseModels.Checked = false;
			chkDermalModels.Checked = false;
			lstModels.Items.Clear();
			recordset.CursorLocation = CursorLocationEnum.adUseClient;
			recordset.Open("SELECT * FROM qryListOfIExpModels", Common.MyConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
			while (!recordset.EOF)
			{
				lstModels.Items.Add((object)new ListBoxItem(Conversions.ToString(recordset.Fields[1].Value), Conversions.ToInteger(recordset.Fields[0].Value)));
				recordset.MoveNext();
			}
			recordset.Close();
		}
	}

	private void cmdHelp_Click(object sender, EventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
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
					ProjectData.ClearProjectError();
					num2 = 2;
					Process.Start(Application.StartupPath + "/help/chemsteer.pdf");
					goto end_IL_0001;
				case 54:
					num = -1;
					switch (num2)
					{
					case 2:
						Interaction.MsgBox((object)"There was a problem displaying the ChemSTEER User Guide. Please verify that you have Adobe's PDF Reader software installed on your computer.", (MsgBoxStyle)64, (object)"Error Viewing ChemSTEER User Guide");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 54;
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

	private void lstModels_SelectedIndexChanged(object sender, EventArgs e)
	{
		cmdOk_Click(cmdOk, new EventArgs());
	}
}
