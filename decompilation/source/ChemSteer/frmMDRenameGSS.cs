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
public class frmMDRenameGSS : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("cmdClose")]
	private Button _cmdClose;

	[AccessedThroughProperty("cmdRename")]
	private Button _cmdRename;

	[AccessedThroughProperty("lstGSS")]
	private ListBox _lstGSS;

	[AccessedThroughProperty("lblTab2Instructions")]
	private Label _lblTab2Instructions;

	[AccessedThroughProperty("cmdOk")]
	private Button _cmdOk;

	[AccessedThroughProperty("txtNewName")]
	private TextBox _txtNewName;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

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

	public virtual Button cmdRename
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdRename;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdRename_Click;
			if (_cmdRename != null)
			{
				((Control)_cmdRename).Click -= eventHandler;
			}
			_cmdRename = value;
			if (_cmdRename != null)
			{
				((Control)_cmdRename).Click += eventHandler;
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
			EventHandler eventHandler = lstGSS_SelectedIndexChanged;
			if (_lstGSS != null)
			{
				_lstGSS.SelectedIndexChanged -= eventHandler;
			}
			_lstGSS = value;
			if (_lstGSS != null)
			{
				_lstGSS.SelectedIndexChanged += eventHandler;
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
			_cmdOk = value;
		}
	}

	internal virtual TextBox txtNewName
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNewName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNewName = value;
		}
	}

	public virtual Label Label1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label1 = value;
		}
	}

	[DebuggerNonUserCode]
	public frmMDRenameGSS()
	{
		((Form)this).Load += frmMDRenameGSS_Load_1;
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
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected O, but got Unknown
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Expected O, but got Unknown
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected O, but got Unknown
		//IL_0510: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Expected O, but got Unknown
		//IL_0660: Unknown result type (might be due to invalid IL or missing references)
		//IL_066a: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMDRenameGSS));
		cmdClose = new Button();
		cmdRename = new Button();
		lstGSS = new ListBox();
		lblTab2Instructions = new Label();
		cmdOk = new Button();
		txtNewName = new TextBox();
		Label1 = new Label();
		((Control)this).SuspendLayout();
		((ButtonBase)cmdClose).BackColor = SystemColors.Control;
		((Control)cmdClose).Cursor = Cursors.Default;
		cmdClose.DialogResult = (DialogResult)2;
		((Control)cmdClose).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdClose).ForeColor = SystemColors.ControlText;
		Button obj = cmdClose;
		Point location = new Point(338, 333);
		((Control)obj).Location = location;
		((Control)cmdClose).Name = "cmdClose";
		((Control)cmdClose).RightToLeft = (RightToLeft)0;
		Button obj2 = cmdClose;
		Size size = new Size(81, 25);
		((Control)obj2).Size = size;
		((Control)cmdClose).TabIndex = 14;
		((ButtonBase)cmdClose).Text = "Close";
		((ButtonBase)cmdClose).UseVisualStyleBackColor = false;
		((ButtonBase)cmdRename).BackColor = SystemColors.Control;
		((Control)cmdRename).Cursor = Cursors.Default;
		((Control)cmdRename).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdRename).ForeColor = SystemColors.ControlText;
		Button obj3 = cmdRename;
		location = new Point(242, 333);
		((Control)obj3).Location = location;
		((Control)cmdRename).Name = "cmdRename";
		((Control)cmdRename).RightToLeft = (RightToLeft)0;
		Button obj4 = cmdRename;
		size = new Size(81, 25);
		((Control)obj4).Size = size;
		((Control)cmdRename).TabIndex = 13;
		((ButtonBase)cmdRename).Text = "Rename";
		((ButtonBase)cmdRename).UseVisualStyleBackColor = false;
		lstGSS.BackColor = Color.White;
		((Control)lstGSS).Cursor = Cursors.Default;
		lstGSS.Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		lstGSS.ForeColor = SystemColors.WindowText;
		lstGSS.ItemHeight = 14;
		ListBox obj5 = lstGSS;
		location = new Point(12, 47);
		((Control)obj5).Location = location;
		((Control)lstGSS).Name = "lstGSS";
		lstGSS.RightToLeft = (RightToLeft)0;
		ListBox obj6 = lstGSS;
		size = new Size(627, 214);
		((Control)obj6).Size = size;
		((Control)lstGSS).TabIndex = 15;
		((Control)lblTab2Instructions).BackColor = SystemColors.Control;
		((Control)lblTab2Instructions).Cursor = Cursors.Default;
		((Control)lblTab2Instructions).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblTab2Instructions).ForeColor = SystemColors.ControlText;
		Label obj7 = lblTab2Instructions;
		location = new Point(18, 9);
		((Control)obj7).Location = location;
		((Control)lblTab2Instructions).Name = "lblTab2Instructions";
		((Control)lblTab2Instructions).RightToLeft = (RightToLeft)0;
		Label obj8 = lblTab2Instructions;
		size = new Size(630, 35);
		((Control)obj8).Size = size;
		((Control)lblTab2Instructions).TabIndex = 18;
		lblTab2Instructions.Text = componentResourceManager.GetString("lblTab2Instructions.Text");
		((ButtonBase)cmdOk).BackColor = SystemColors.Control;
		((Control)cmdOk).Cursor = Cursors.Default;
		((Control)cmdOk).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdOk).ForeColor = SystemColors.ControlText;
		Button obj9 = cmdOk;
		location = new Point(242, 333);
		((Control)obj9).Location = location;
		((Control)cmdOk).Name = "cmdOk";
		((Control)cmdOk).RightToLeft = (RightToLeft)0;
		Button obj10 = cmdOk;
		size = new Size(81, 25);
		((Control)obj10).Size = size;
		((Control)cmdOk).TabIndex = 13;
		((ButtonBase)cmdOk).Text = "Rename";
		((ButtonBase)cmdOk).UseVisualStyleBackColor = false;
		TextBox obj11 = txtNewName;
		location = new Point(12, 291);
		((Control)obj11).Location = location;
		((Control)txtNewName).Name = "txtNewName";
		TextBox obj12 = txtNewName;
		size = new Size(627, 20);
		((Control)obj12).Size = size;
		((Control)txtNewName).TabIndex = 19;
		((Control)Label1).BackColor = SystemColors.Control;
		((Control)Label1).Cursor = Cursors.Default;
		((Control)Label1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label1).ForeColor = SystemColors.ControlText;
		Label label = Label1;
		location = new Point(12, 275);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		((Control)Label1).RightToLeft = (RightToLeft)0;
		Label label2 = Label1;
		size = new Size(630, 13);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 20;
		Label1.Text = "New Name:";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(664, 377);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Label1);
		((Control)this).Controls.Add((Control)(object)txtNewName);
		((Control)this).Controls.Add((Control)(object)lblTab2Instructions);
		((Control)this).Controls.Add((Control)(object)cmdClose);
		((Control)this).Controls.Add((Control)(object)cmdRename);
		((Control)this).Controls.Add((Control)(object)lstGSS);
		((Form)this).FormBorderStyle = (FormBorderStyle)1;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Control)this).Name = "frmMDRenameGSS";
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Rename Generic Scenario Operation";
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void frmMDRenameGSS_Load_1(object sender, EventArgs e)
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

	private void cmdRename_Click(object sender, EventArgs e)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		if (lstGSS.SelectedIndex == -1)
		{
			Interaction.MsgBox((object)"Please highlight the Generic Scenario you wish to rename.", (MsgBoxStyle)0, (object)"No Generic Scenario Selected");
		}
		else if (Operators.CompareString(txtNewName.Text, "", false) == 0)
		{
			Interaction.MsgBox((object)"Please enter a new name for the selected Generic Scenario.", (MsgBoxStyle)0, (object)"No New Name Generic Scenario");
		}
		else if (DBFuncs.renameGSS(lstGSS.Text, txtNewName.Text))
		{
			loadScenarios();
			txtNewName.Text = "";
			Interaction.MsgBox((object)"The scenario has been renamed.", (MsgBoxStyle)0, (object)"Rename Generic Scenario");
		}
	}

	private void lstGSS_SelectedIndexChanged(object sender, EventArgs e)
	{
		txtNewName.Text = lstGSS.Text;
	}
}
