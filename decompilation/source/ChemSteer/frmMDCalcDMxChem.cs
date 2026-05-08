using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Compatibility.VB6;
using Microsoft.VisualBasic.CompilerServices;

namespace ChemSteer;

internal class frmMDCalcDMxChem : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("cmdCalc")]
	private Button _cmdCalc;

	[AccessedThroughProperty("txtHMxChem")]
	private TextBox _txtHMxChem;

	[AccessedThroughProperty("txtHD")]
	private TextBox _txtHD;

	[AccessedThroughProperty("cmdOk")]
	private Button _cmdOk;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("lblInstructions")]
	private Label _lblInstructions;

	[AccessedThroughProperty("_Label1_2")]
	private Label __Label1_2;

	[AccessedThroughProperty("_Label1_3")]
	private Label __Label1_3;

	[AccessedThroughProperty("lblDMxChem")]
	private Label _lblDMxChem;

	[AccessedThroughProperty("_Label1_0")]
	private Label __Label1_0;

	[AccessedThroughProperty("Label1")]
	private LabelArray _Label1;

	private static frmMDCalcDMxChem m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	private short iMyGSS;

	public short iSelected;

	public virtual Button cmdCalc
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdCalc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdCalc_Click;
			if (_cmdCalc != null)
			{
				((Control)_cmdCalc).Click -= eventHandler;
			}
			_cmdCalc = value;
			if (_cmdCalc != null)
			{
				((Control)_cmdCalc).Click += eventHandler;
			}
		}
	}

	public virtual TextBox txtHMxChem
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtHMxChem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtHMxChem_TextChanged;
			if (_txtHMxChem != null)
			{
				((Control)_txtHMxChem).TextChanged -= eventHandler;
			}
			_txtHMxChem = value;
			if (_txtHMxChem != null)
			{
				((Control)_txtHMxChem).TextChanged += eventHandler;
			}
		}
	}

	public virtual TextBox txtHD
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtHD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtHD_TextChanged;
			if (_txtHD != null)
			{
				((Control)_txtHD).TextChanged -= eventHandler;
			}
			_txtHD = value;
			if (_txtHD != null)
			{
				((Control)_txtHD).TextChanged += eventHandler;
			}
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

	public virtual Label lblInstructions
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblInstructions;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblInstructions = value;
		}
	}

	public virtual Label _Label1_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_2 = value;
		}
	}

	public virtual Label _Label1_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_3 = value;
		}
	}

	public virtual Label lblDMxChem
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDMxChem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDMxChem = value;
		}
	}

	public virtual Label _Label1_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_0 = value;
		}
	}

	public virtual LabelArray Label1
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

	public static frmMDCalcDMxChem DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmMDCalcDMxChem();
				m_InitializingDefInstance = false;
			}
			return m_vb6FormDefInstance;
		}
		set
		{
			m_vb6FormDefInstance = value;
		}
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

	public frmMDCalcDMxChem()
	{
		((Form)this).Load += frmMDCalcDMxChem_Load;
		__ENCAddToList(this);
		if (m_vb6FormDefInstance == null)
		{
			if (m_InitializingDefInstance)
			{
				m_vb6FormDefInstance = this;
			}
			else
			{
				try
				{
					if ((object)Assembly.GetExecutingAssembly().EntryPoint.DeclaringType == ((object)this).GetType())
					{
						m_vb6FormDefInstance = this;
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
		InitializeComponent();
	}

	protected override void Dispose(bool Disposing)
	{
		if (Disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(Disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected O, but got Unknown
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_0451: Expected O, but got Unknown
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0524: Expected O, but got Unknown
		//IL_05dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e7: Expected O, but got Unknown
		//IL_06c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ca: Expected O, but got Unknown
		//IL_07b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ba: Expected O, but got Unknown
		//IL_0862: Unknown result type (might be due to invalid IL or missing references)
		//IL_086c: Expected O, but got Unknown
		//IL_0a25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2f: Expected O, but got Unknown
		//IL_0a44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4e: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMDCalcDMxChem));
		ToolTip1 = new ToolTip(components);
		cmdCalc = new Button();
		txtHMxChem = new TextBox();
		txtHD = new TextBox();
		cmdOk = new Button();
		cmdCancel = new Button();
		lblInstructions = new Label();
		_Label1_2 = new Label();
		_Label1_3 = new Label();
		lblDMxChem = new Label();
		_Label1_0 = new Label();
		Label1 = new LabelArray(components);
		((ISupportInitialize)Label1).BeginInit();
		((Control)this).SuspendLayout();
		((ButtonBase)cmdCalc).BackColor = SystemColors.Control;
		((Control)cmdCalc).Cursor = Cursors.Default;
		((Control)cmdCalc).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCalc).ForeColor = SystemColors.ControlText;
		Button obj = cmdCalc;
		Point location = new Point(205, 151);
		((Control)obj).Location = location;
		((Control)cmdCalc).Name = "cmdCalc";
		((Control)cmdCalc).RightToLeft = (RightToLeft)0;
		Button obj2 = cmdCalc;
		Size size = new Size(97, 25);
		((Control)obj2).Size = size;
		((Control)cmdCalc).TabIndex = 4;
		((ButtonBase)cmdCalc).Text = "&Calculate";
		((ButtonBase)cmdCalc).UseVisualStyleBackColor = false;
		txtHMxChem.AcceptsReturn = true;
		((TextBoxBase)txtHMxChem).BackColor = Color.White;
		((Control)txtHMxChem).Cursor = Cursors.IBeam;
		((Control)txtHMxChem).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtHMxChem).ForeColor = SystemColors.WindowText;
		TextBox obj3 = txtHMxChem;
		location = new Point(421, 56);
		((Control)obj3).Location = location;
		((TextBoxBase)txtHMxChem).MaxLength = 0;
		((Control)txtHMxChem).Name = "txtHMxChem";
		((Control)txtHMxChem).RightToLeft = (RightToLeft)0;
		TextBox obj4 = txtHMxChem;
		size = new Size(73, 20);
		((Control)obj4).Size = size;
		((Control)txtHMxChem).TabIndex = 3;
		txtHD.AcceptsReturn = true;
		((TextBoxBase)txtHD).BackColor = Color.White;
		((Control)txtHD).Cursor = Cursors.IBeam;
		((Control)txtHD).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtHD).ForeColor = SystemColors.WindowText;
		TextBox obj5 = txtHD;
		location = new Point(421, 88);
		((Control)obj5).Location = location;
		((TextBoxBase)txtHD).MaxLength = 0;
		((Control)txtHD).Name = "txtHD";
		((Control)txtHD).RightToLeft = (RightToLeft)0;
		TextBox obj6 = txtHD;
		size = new Size(73, 20);
		((Control)obj6).Size = size;
		((Control)txtHD).TabIndex = 2;
		((ButtonBase)cmdOk).BackColor = SystemColors.Control;
		((Control)cmdOk).Cursor = Cursors.Default;
		((Control)cmdOk).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdOk).ForeColor = SystemColors.ControlText;
		Button obj7 = cmdOk;
		location = new Point(101, 151);
		((Control)obj7).Location = location;
		((Control)cmdOk).Name = "cmdOk";
		((Control)cmdOk).RightToLeft = (RightToLeft)0;
		Button obj8 = cmdOk;
		size = new Size(97, 25);
		((Control)obj8).Size = size;
		((Control)cmdOk).TabIndex = 0;
		((ButtonBase)cmdOk).Text = "OK";
		((ButtonBase)cmdOk).UseVisualStyleBackColor = false;
		((ButtonBase)cmdCancel).BackColor = SystemColors.Control;
		((Control)cmdCancel).Cursor = Cursors.Default;
		cmdCancel.DialogResult = (DialogResult)2;
		((Control)cmdCancel).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCancel).ForeColor = SystemColors.ControlText;
		Button obj9 = cmdCancel;
		location = new Point(309, 151);
		((Control)obj9).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		((Control)cmdCancel).RightToLeft = (RightToLeft)0;
		Button obj10 = cmdCancel;
		size = new Size(97, 25);
		((Control)obj10).Size = size;
		((Control)cmdCancel).TabIndex = 1;
		((ButtonBase)cmdCancel).Text = "Cancel";
		((ButtonBase)cmdCancel).UseVisualStyleBackColor = false;
		((Control)lblInstructions).BackColor = SystemColors.Control;
		((Control)lblInstructions).Cursor = Cursors.Default;
		((Control)lblInstructions).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblInstructions).ForeColor = SystemColors.ControlText;
		Label obj11 = lblInstructions;
		location = new Point(16, 8);
		((Control)obj11).Location = location;
		((Control)lblInstructions).Name = "lblInstructions";
		((Control)lblInstructions).RightToLeft = (RightToLeft)0;
		Label obj12 = lblInstructions;
		size = new Size(478, 41);
		((Control)obj12).Size = size;
		((Control)lblInstructions).TabIndex = 9;
		lblInstructions.Text = "x";
		((Control)_Label1_2).BackColor = SystemColors.Control;
		((Control)_Label1_2).Cursor = Cursors.Default;
		((Control)_Label1_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_2).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_2, (short)2);
		Label label1_ = _Label1_2;
		location = new Point(126, 56);
		((Control)label1_).Location = location;
		((Control)_Label1_2).Name = "_Label1_2";
		((Control)_Label1_2).RightToLeft = (RightToLeft)0;
		Label label1_2 = _Label1_2;
		size = new Size(289, 17);
		((Control)label1_2).Size = size;
		((Control)_Label1_2).TabIndex = 8;
		_Label1_2.Text = "HMxChem (kg/hr): ";
		_Label1_2.TextAlign = (ContentAlignment)4;
		((Control)_Label1_3).BackColor = SystemColors.Control;
		((Control)_Label1_3).Cursor = Cursors.Default;
		((Control)_Label1_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_3).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_3, (short)3);
		Label label1_3 = _Label1_3;
		location = new Point(86, 88);
		((Control)label1_3).Location = location;
		((Control)_Label1_3).Name = "_Label1_3";
		((Control)_Label1_3).RightToLeft = (RightToLeft)0;
		Label label1_4 = _Label1_3;
		size = new Size(329, 17);
		((Control)label1_4).Size = size;
		((Control)_Label1_3).TabIndex = 7;
		_Label1_3.Text = "HD (hr/day): ";
		_Label1_3.TextAlign = (ContentAlignment)4;
		((Control)lblDMxChem).BackColor = SystemColors.Control;
		lblDMxChem.BorderStyle = (BorderStyle)2;
		((Control)lblDMxChem).Cursor = Cursors.Default;
		((Control)lblDMxChem).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblDMxChem).ForeColor = SystemColors.ControlText;
		Label obj13 = lblDMxChem;
		location = new Point(421, 120);
		((Control)obj13).Location = location;
		((Control)lblDMxChem).Name = "lblDMxChem";
		((Control)lblDMxChem).RightToLeft = (RightToLeft)0;
		Label obj14 = lblDMxChem;
		size = new Size(73, 17);
		((Control)obj14).Size = size;
		((Control)lblDMxChem).TabIndex = 6;
		((Control)_Label1_0).BackColor = SystemColors.Control;
		((Control)_Label1_0).Cursor = Cursors.Default;
		((Control)_Label1_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_0).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_0, (short)0);
		Label label1_5 = _Label1_0;
		location = new Point(2, 120);
		((Control)label1_5).Location = location;
		((Control)_Label1_0).Name = "_Label1_0";
		((Control)_Label1_0).RightToLeft = (RightToLeft)0;
		Label label1_6 = _Label1_0;
		size = new Size(413, 17);
		((Control)label1_6).Size = size;
		((Control)_Label1_0).TabIndex = 5;
		_Label1_0.Text = "x";
		_Label1_0.TextAlign = (ContentAlignment)4;
		size = new Size(5, 13);
		((Form)this).AutoScaleBaseSize = size;
		((Form)this).BackColor = SystemColors.Control;
		((Form)this).CancelButton = (IButtonControl)(object)cmdCancel;
		size = new Size(506, 188);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)cmdCalc);
		((Control)this).Controls.Add((Control)(object)txtHMxChem);
		((Control)this).Controls.Add((Control)(object)txtHD);
		((Control)this).Controls.Add((Control)(object)cmdOk);
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)lblInstructions);
		((Control)this).Controls.Add((Control)(object)_Label1_2);
		((Control)this).Controls.Add((Control)(object)_Label1_3);
		((Control)this).Controls.Add((Control)(object)lblDMxChem);
		((Control)this).Controls.Add((Control)(object)_Label1_0);
		((Control)this).Cursor = Cursors.Default;
		((Control)this).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		location = new Point(250, 150);
		((Form)this).Location = location;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmMDCalcDMxChem";
		((Control)this).RightToLeft = (RightToLeft)0;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((ISupportInitialize)Label1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void cmdCalc_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		if (Versioned.IsNumeric((object)txtHMxChem.Text) & Versioned.IsNumeric((object)txtHD.Text))
		{
			lblDMxChem.Text = Conversions.ToString(Conversions.ToDouble(txtHMxChem.Text) * Conversions.ToDouble(txtHD.Text));
			((Control)cmdOk).Enabled = true;
		}
		else
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Enter valid numbers for both input fields", (MsgBoxStyle)0, (object)"Invalid input data");
			lblDMxChem.Text = "";
		}
	}

	private void cmdCancel_Click(object eventSender, EventArgs eventArgs)
	{
		((Control)this).Tag = "Cancel";
		((Control)this).Hide();
	}

	private void cmdOk_Click(object eventSender, EventArgs eventArgs)
	{
		((Control)this).Hide();
	}

	private void frmMDCalcDMxChem_Load(object eventSender, EventArgs eventArgs)
	{
		float pHMxChem = frmMDUpdOpIP.DefInstance.pHMxChem;
		float pHD = frmMDUpdOpIP.DefInstance.pHD;
		SetUp(ref pHMxChem, ref pHD);
	}

	public bool SetUp(ref float pHMxChem, ref float pHD)
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
					ProjectData.ClearProjectError();
					num2 = 2;
					((Form)this).Text = "Calculate " + ((Control)frmMDUpdOpIP.DefInstance._fraTab2_0).Controls["_chkKnowns1_2"].Text;
					Label1[(short)0].Text = ((Control)frmMDUpdOpIP.DefInstance._fraTab2_0).Controls["_chkKnowns1_2"].Text;
					lblInstructions.Text = "View or change " + ((Control)frmMDUpdOpIP.DefInstance._fraTab2_0).Controls["_chkKnowns1_2"].Text + " by entering or updating the fields below, and then pressing the Calculate button.";
					txtHMxChem.Text = Conversions.ToString(pHMxChem);
					txtHD.Text = Conversions.ToString(pHD);
					lblDMxChem.Text = Common.MyNullCheck(((Control)frmMDUpdOpIP.DefInstance._fraTab2_0).Controls["_txtKnowns_2"].Text);
					Label1[(short)2].Text = Strings.Left(Label1[(short)2].Text, 2) + Strings.Mid(((Control)frmMDUpdOpIP.DefInstance._fraTab2_0).Controls["_chkKnowns1_2"].Text, 3, 1) + Strings.Mid(Label1[(short)2].Text, 4);
					flag = true;
					goto end_IL_0001;
				case 453:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						string Eobject = ((Control)this).Name;
						string Efunction = "Setup";
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
				try0001_dispatch = 453;
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

	private void txtHD_TextChanged(object eventSender, EventArgs eventArgs)
	{
		((Control)cmdOk).Enabled = false;
		short pID = 35;
		TextBox val = txtHD;
		object pValue = val.Text;
		short pModType = 0;
		ChemStrX.ValidateParmInput(ref pID, ref pValue, ref pModType);
		val.Text = Conversions.ToString(pValue);
	}

	private void txtHMxChem_TextChanged(object eventSender, EventArgs eventArgs)
	{
		((Control)cmdOk).Enabled = false;
	}
}
