using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ADODB;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ChemSteer;

[DesignerGenerated]
public class frmMDDeleteGSS : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("cmdClose")]
	private Button _cmdClose;

	[AccessedThroughProperty("lstGSS")]
	private ListBox _lstGSS;

	[AccessedThroughProperty("cmdDelete")]
	private Button _cmdDelete;

	[AccessedThroughProperty("lblTab2Instructions")]
	private Label _lblTab2Instructions;

	public virtual Button cmdClose
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdClose;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdClose_Click;
			if (_cmdClose != null)
			{
				((Control)_cmdClose).Click -= eventHandler;
			}
			_cmdClose = value;
			if (_cmdClose != null)
			{
				((Control)_cmdClose).Click += eventHandler;
			}
		}
	}

	public virtual ListBox lstGSS
	{
		[DebuggerNonUserCode]
		get
		{
			return _lstGSS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lstGSS = value;
		}
	}

	public virtual Button cmdDelete
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdDelete;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdDelete_Click;
			if (_cmdDelete != null)
			{
				((Control)_cmdDelete).Click -= eventHandler;
			}
			_cmdDelete = value;
			if (_cmdDelete != null)
			{
				((Control)_cmdDelete).Click += eventHandler;
			}
		}
	}

	public virtual Label lblTab2Instructions
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTab2Instructions;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTab2Instructions = value;
		}
	}

	[DebuggerNonUserCode]
	public frmMDDeleteGSS()
	{
		((Form)this).Load += frmMDDeleteGSS_Load;
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
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected O, but got Unknown
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected O, but got Unknown
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMDDeleteGSS));
		cmdClose = new Button();
		lstGSS = new ListBox();
		cmdDelete = new Button();
		lblTab2Instructions = new Label();
		((Control)this).SuspendLayout();
		((ButtonBase)cmdClose).BackColor = SystemColors.Control;
		((Control)cmdClose).Cursor = Cursors.Default;
		cmdClose.DialogResult = (DialogResult)2;
		((Control)cmdClose).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdClose).ForeColor = SystemColors.ControlText;
		Button obj = cmdClose;
		Point location = new Point(339, 211);
		((Control)obj).Location = location;
		((Control)cmdClose).Name = "cmdClose";
		((Control)cmdClose).RightToLeft = (RightToLeft)0;
		Button obj2 = cmdClose;
		Size size = new Size(81, 25);
		((Control)obj2).Size = size;
		((Control)cmdClose).TabIndex = 15;
		((ButtonBase)cmdClose).Text = "Close";
		((ButtonBase)cmdClose).UseVisualStyleBackColor = false;
		lstGSS.BackColor = Color.White;
		((Control)lstGSS).Cursor = Cursors.Default;
		lstGSS.Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		lstGSS.ForeColor = SystemColors.WindowText;
		lstGSS.ItemHeight = 14;
		ListBox obj3 = lstGSS;
		location = new Point(12, 47);
		((Control)obj3).Location = location;
		((Control)lstGSS).Name = "lstGSS";
		lstGSS.RightToLeft = (RightToLeft)0;
		ListBox obj4 = lstGSS;
		size = new Size(630, 144);
		((Control)obj4).Size = size;
		((Control)lstGSS).TabIndex = 16;
		((ButtonBase)cmdDelete).BackColor = SystemColors.Control;
		((Control)cmdDelete).Cursor = Cursors.Default;
		((Control)cmdDelete).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdDelete).ForeColor = SystemColors.ControlText;
		Button obj5 = cmdDelete;
		location = new Point(243, 211);
		((Control)obj5).Location = location;
		((Control)cmdDelete).Name = "cmdDelete";
		((Control)cmdDelete).RightToLeft = (RightToLeft)0;
		Button obj6 = cmdDelete;
		size = new Size(81, 25);
		((Control)obj6).Size = size;
		((Control)cmdDelete).TabIndex = 14;
		((ButtonBase)cmdDelete).Text = "Delete";
		((ButtonBase)cmdDelete).UseVisualStyleBackColor = false;
		((Control)lblTab2Instructions).BackColor = SystemColors.Control;
		((Control)lblTab2Instructions).Cursor = Cursors.Default;
		((Control)lblTab2Instructions).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblTab2Instructions).ForeColor = SystemColors.ControlText;
		Label obj7 = lblTab2Instructions;
		location = new Point(12, 9);
		((Control)obj7).Location = location;
		((Control)lblTab2Instructions).Name = "lblTab2Instructions";
		((Control)lblTab2Instructions).RightToLeft = (RightToLeft)0;
		Label obj8 = lblTab2Instructions;
		size = new Size(630, 35);
		((Control)obj8).Size = size;
		((Control)lblTab2Instructions).TabIndex = 17;
		lblTab2Instructions.Text = "As an authorized user, you can use this form to delete existing scenarios from the Generic Scenario Database. Simply highlight the generic scenario you with to delete and the select the Delete button.";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(659, 261);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)cmdClose);
		((Control)this).Controls.Add((Control)(object)lstGSS);
		((Control)this).Controls.Add((Control)(object)cmdDelete);
		((Control)this).Controls.Add((Control)(object)lblTab2Instructions);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Control)this).Name = "frmMDDeleteGSS";
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Delete Generic Scenario Operation";
		((Control)this).ResumeLayout(false);
	}

	private void frmMDDeleteGSS_Load(object sender, EventArgs e)
	{
		loadScenarios();
	}

	private void loadScenarios()
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
					ProjectData.ClearProjectError();
					num2 = 2;
					lstGSS.Items.Clear();
					Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
					Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					recordset.CursorLocation = CursorLocationEnum.adUseClient;
					recordset.Open("SELECT * FROM qryListGSS", Common.gssConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
					while (!recordset.EOF)
					{
						lstGSS.Items.Add(RuntimeHelpers.GetObjectValue(recordset.Fields["OpName"].Value));
						recordset.MoveNext();
					}
					recordset.Close();
					recordset = null;
					goto end_IL_0001;
				}
				case 263:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						string Eobject = ((Control)this).Name;
						string Efunction = "loadScenarios";
						ErrObject val = Information.Err();
						int Enumber = val.Number;
						ErrObject val2 = Information.Err();
						string Edescription = val2.Description;
						bool Econtact = true;
						Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
						val2.Description = Edescription;
						val.Number = Enumber;
						((Control)this).Name = Eobject;
						goto end_IL_0001;
					}
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 263;
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

	private void cmdClose_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void cmdDelete_Click(object sender, EventArgs e)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Invalid comparison between Unknown and I4
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		if (lstGSS.SelectedIndex == -1)
		{
			Interaction.MsgBox((object)"Please highlight the Generic Scenario you wish to delete.", (MsgBoxStyle)0, (object)"No Generic Scenario Selected");
		}
		else if ((int)Interaction.MsgBox((object)("Are you sure you want to delete " + lstGSS.Text + "?"), (MsgBoxStyle)4, (object)"Delete Generic Scenario Operation") == 6 && DBFuncs.deleteGSS(lstGSS.SelectedItem.ToString()))
		{
			loadScenarios();
			Interaction.MsgBox((object)"The scenario has been deleted.", (MsgBoxStyle)0, (object)"Delete Generic Scenario");
		}
	}
}
