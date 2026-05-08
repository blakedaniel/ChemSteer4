using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ADODB;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Compatibility.VB6;
using Microsoft.VisualBasic.CompilerServices;

namespace ChemSteer;

internal class frmMDUpdMsdsGE : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("chkMSDSLab")]
	private CheckBox _chkMSDSLab;

	[AccessedThroughProperty("chkMSDSInc")]
	private CheckBox _chkMSDSInc;

	[AccessedThroughProperty("_txtMsds_0")]
	private TextBox __txtMsds_0;

	[AccessedThroughProperty("_txtMsds_1")]
	private TextBox __txtMsds_1;

	[AccessedThroughProperty("_txtMsds_2")]
	private TextBox __txtMsds_2;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("cmdClose")]
	private Button _cmdClose;

	[AccessedThroughProperty("_Label1_98")]
	private Label __Label1_98;

	[AccessedThroughProperty("_Label1_75")]
	private Label __Label1_75;

	[AccessedThroughProperty("_Label1_76")]
	private Label __Label1_76;

	[AccessedThroughProperty("lblInstructions")]
	private Label _lblInstructions;

	[AccessedThroughProperty("Label1")]
	private LabelArray _Label1;

	[AccessedThroughProperty("txtMsds")]
	private TextBoxArray _txtMsds;

	private static frmMDUpdMsdsGE m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	public virtual CheckBox chkMSDSLab
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkMSDSLab;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkMSDSLab = value;
		}
	}

	public virtual CheckBox chkMSDSInc
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkMSDSInc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkMSDSInc = value;
		}
	}

	public virtual TextBox _txtMsds_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtMsds_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtMsds_0 = value;
		}
	}

	public virtual TextBox _txtMsds_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtMsds_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtMsds_1 = value;
		}
	}

	public virtual TextBox _txtMsds_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtMsds_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtMsds_2 = value;
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

	public virtual Label _Label1_98
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_98;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_98 = value;
		}
	}

	public virtual Label _Label1_75
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_75;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_75 = value;
		}
	}

	public virtual Label _Label1_76
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_76;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_76 = value;
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

	public virtual TextBoxArray txtMsds
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMsds;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			EventHandler eventHandler = txtMsds_Leave;
			KeyEventHandler val = new KeyEventHandler(txtMsds_KeyDown);
			if (_txtMsds != null)
			{
				_txtMsds.Leave -= eventHandler;
				_txtMsds.KeyDown -= val;
			}
			_txtMsds = value;
			if (_txtMsds != null)
			{
				_txtMsds.Leave += eventHandler;
				_txtMsds.KeyDown += val;
			}
		}
	}

	public static frmMDUpdMsdsGE DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmMDUpdMsdsGE();
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

	public frmMDUpdMsdsGE()
	{
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
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected O, but got Unknown
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Expected O, but got Unknown
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Expected O, but got Unknown
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04db: Expected O, but got Unknown
		//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cd: Expected O, but got Unknown
		//IL_0696: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a0: Expected O, but got Unknown
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_0773: Expected O, but got Unknown
		//IL_084a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0854: Expected O, but got Unknown
		//IL_092b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0935: Expected O, but got Unknown
		//IL_0a0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a18: Expected O, but got Unknown
		//IL_0bb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc0: Expected O, but got Unknown
		//IL_0bd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdf: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMDUpdMsdsGE));
		ToolTip1 = new ToolTip(components);
		chkMSDSLab = new CheckBox();
		chkMSDSInc = new CheckBox();
		_txtMsds_0 = new TextBox();
		_txtMsds_1 = new TextBox();
		_txtMsds_2 = new TextBox();
		cmdCancel = new Button();
		cmdClose = new Button();
		_Label1_98 = new Label();
		_Label1_75 = new Label();
		_Label1_76 = new Label();
		lblInstructions = new Label();
		Label1 = new LabelArray(components);
		txtMsds = new TextBoxArray(components);
		((ISupportInitialize)Label1).BeginInit();
		((ISupportInitialize)txtMsds).BeginInit();
		((Control)this).SuspendLayout();
		((ButtonBase)chkMSDSLab).BackColor = SystemColors.Control;
		((Control)chkMSDSLab).Cursor = Cursors.Default;
		((Control)chkMSDSLab).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)chkMSDSLab).ForeColor = SystemColors.ControlText;
		CheckBox obj = chkMSDSLab;
		Point location = new Point(304, 40);
		((Control)obj).Location = location;
		((Control)chkMSDSLab).Name = "chkMSDSLab";
		((Control)chkMSDSLab).RightToLeft = (RightToLeft)0;
		CheckBox obj2 = chkMSDSLab;
		Size size = new Size(113, 17);
		((Control)obj2).Size = size;
		((Control)chkMSDSLab).TabIndex = 7;
		((ButtonBase)chkMSDSLab).Text = "Label Included";
		((ButtonBase)chkMSDSLab).UseVisualStyleBackColor = false;
		((ButtonBase)chkMSDSInc).BackColor = SystemColors.Control;
		((Control)chkMSDSInc).Cursor = Cursors.Default;
		((Control)chkMSDSInc).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)chkMSDSInc).ForeColor = SystemColors.ControlText;
		CheckBox obj3 = chkMSDSInc;
		location = new Point(128, 40);
		((Control)obj3).Location = location;
		((Control)chkMSDSInc).Name = "chkMSDSInc";
		((Control)chkMSDSInc).RightToLeft = (RightToLeft)0;
		CheckBox obj4 = chkMSDSInc;
		size = new Size(145, 17);
		((Control)obj4).Size = size;
		((Control)chkMSDSInc).TabIndex = 6;
		((ButtonBase)chkMSDSInc).Text = "MSDS Included";
		((ButtonBase)chkMSDSInc).UseVisualStyleBackColor = false;
		_txtMsds_0.AcceptsReturn = true;
		((TextBoxBase)_txtMsds_0).BackColor = Color.White;
		((Control)_txtMsds_0).Cursor = Cursors.IBeam;
		((Control)_txtMsds_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtMsds_0).ForeColor = SystemColors.WindowText;
		txtMsds.SetIndex(_txtMsds_0, (short)0);
		TextBox txtMsds_ = _txtMsds_0;
		location = new Point(128, 72);
		((Control)txtMsds_).Location = location;
		((TextBoxBase)_txtMsds_0).MaxLength = 0;
		_txtMsds_0.Multiline = true;
		((Control)_txtMsds_0).Name = "_txtMsds_0";
		((Control)_txtMsds_0).RightToLeft = (RightToLeft)0;
		_txtMsds_0.ScrollBars = (ScrollBars)2;
		TextBox txtMsds_2 = _txtMsds_0;
		size = new Size(417, 41);
		((Control)txtMsds_2).Size = size;
		((Control)_txtMsds_0).TabIndex = 5;
		_txtMsds_1.AcceptsReturn = true;
		((TextBoxBase)_txtMsds_1).BackColor = Color.White;
		((Control)_txtMsds_1).Cursor = Cursors.IBeam;
		((Control)_txtMsds_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtMsds_1).ForeColor = SystemColors.WindowText;
		txtMsds.SetIndex(_txtMsds_1, (short)1);
		TextBox txtMsds_3 = _txtMsds_1;
		location = new Point(128, 120);
		((Control)txtMsds_3).Location = location;
		((TextBoxBase)_txtMsds_1).MaxLength = 0;
		_txtMsds_1.Multiline = true;
		((Control)_txtMsds_1).Name = "_txtMsds_1";
		((Control)_txtMsds_1).RightToLeft = (RightToLeft)0;
		_txtMsds_1.ScrollBars = (ScrollBars)2;
		TextBox txtMsds_4 = _txtMsds_1;
		size = new Size(417, 41);
		((Control)txtMsds_4).Size = size;
		((Control)_txtMsds_1).TabIndex = 4;
		_txtMsds_2.AcceptsReturn = true;
		((TextBoxBase)_txtMsds_2).BackColor = Color.White;
		((Control)_txtMsds_2).Cursor = Cursors.IBeam;
		((Control)_txtMsds_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtMsds_2).ForeColor = SystemColors.WindowText;
		txtMsds.SetIndex(_txtMsds_2, (short)2);
		TextBox txtMsds_5 = _txtMsds_2;
		location = new Point(128, 168);
		((Control)txtMsds_5).Location = location;
		((TextBoxBase)_txtMsds_2).MaxLength = 0;
		_txtMsds_2.Multiline = true;
		((Control)_txtMsds_2).Name = "_txtMsds_2";
		((Control)_txtMsds_2).RightToLeft = (RightToLeft)0;
		_txtMsds_2.ScrollBars = (ScrollBars)2;
		TextBox txtMsds_6 = _txtMsds_2;
		size = new Size(417, 41);
		((Control)txtMsds_6).Size = size;
		((Control)_txtMsds_2).TabIndex = 3;
		((ButtonBase)cmdCancel).BackColor = SystemColors.Control;
		((Control)cmdCancel).Cursor = Cursors.Default;
		((Control)cmdCancel).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCancel).ForeColor = SystemColors.ControlText;
		Button obj5 = cmdCancel;
		location = new Point(288, 224);
		((Control)obj5).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		((Control)cmdCancel).RightToLeft = (RightToLeft)0;
		Button obj6 = cmdCancel;
		size = new Size(81, 25);
		((Control)obj6).Size = size;
		((Control)cmdCancel).TabIndex = 1;
		((ButtonBase)cmdCancel).Text = "Cancel";
		((ButtonBase)cmdCancel).UseVisualStyleBackColor = false;
		((ButtonBase)cmdClose).BackColor = SystemColors.Control;
		((Control)cmdClose).Cursor = Cursors.Default;
		((Control)cmdClose).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdClose).ForeColor = SystemColors.ControlText;
		Button obj7 = cmdClose;
		location = new Point(192, 224);
		((Control)obj7).Location = location;
		((Control)cmdClose).Name = "cmdClose";
		((Control)cmdClose).RightToLeft = (RightToLeft)0;
		Button obj8 = cmdClose;
		size = new Size(81, 25);
		((Control)obj8).Size = size;
		((Control)cmdClose).TabIndex = 0;
		((ButtonBase)cmdClose).Text = "Ok";
		((ButtonBase)cmdClose).UseVisualStyleBackColor = false;
		((Control)_Label1_98).BackColor = SystemColors.Control;
		((Control)_Label1_98).Cursor = Cursors.Default;
		((Control)_Label1_98).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_98).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_98, (short)98);
		Label label1_ = _Label1_98;
		location = new Point(8, 72);
		((Control)label1_).Location = location;
		((Control)_Label1_98).Name = "_Label1_98";
		((Control)_Label1_98).RightToLeft = (RightToLeft)0;
		Label label1_2 = _Label1_98;
		size = new Size(113, 17);
		((Control)label1_2).Size = size;
		((Control)_Label1_98).TabIndex = 10;
		_Label1_98.Text = "General Equipment:";
		_Label1_98.TextAlign = (ContentAlignment)4;
		((Control)_Label1_75).BackColor = SystemColors.Control;
		((Control)_Label1_75).Cursor = Cursors.Default;
		((Control)_Label1_75).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_75).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_75, (short)75);
		Label label1_3 = _Label1_75;
		location = new Point(8, 120);
		((Control)label1_3).Location = location;
		((Control)_Label1_75).Name = "_Label1_75";
		((Control)_Label1_75).RightToLeft = (RightToLeft)0;
		Label label1_4 = _Label1_75;
		size = new Size(113, 17);
		((Control)label1_4).Size = size;
		((Control)_Label1_75).TabIndex = 9;
		_Label1_75.Text = "Respirator:";
		_Label1_75.TextAlign = (ContentAlignment)4;
		((Control)_Label1_76).BackColor = SystemColors.Control;
		((Control)_Label1_76).Cursor = Cursors.Default;
		((Control)_Label1_76).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_76).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_76, (short)76);
		Label label1_5 = _Label1_76;
		location = new Point(8, 168);
		((Control)label1_5).Location = location;
		((Control)_Label1_76).Name = "_Label1_76";
		((Control)_Label1_76).RightToLeft = (RightToLeft)0;
		Label label1_6 = _Label1_76;
		size = new Size(113, 17);
		((Control)label1_6).Size = size;
		((Control)_Label1_76).TabIndex = 8;
		_Label1_76.Text = "Health Effects:";
		_Label1_76.TextAlign = (ContentAlignment)4;
		((Control)lblInstructions).BackColor = SystemColors.Control;
		((Control)lblInstructions).Cursor = Cursors.Default;
		((Control)lblInstructions).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblInstructions).ForeColor = SystemColors.ControlText;
		Label obj9 = lblInstructions;
		location = new Point(16, 8);
		((Control)obj9).Location = location;
		((Control)lblInstructions).Name = "lblInstructions";
		((Control)lblInstructions).RightToLeft = (RightToLeft)0;
		Label obj10 = lblInstructions;
		size = new Size(529, 25);
		((Control)obj10).Size = size;
		((Control)lblInstructions).TabIndex = 2;
		lblInstructions.Text = "xxx";
		size = new Size(5, 13);
		((Form)this).AutoScaleBaseSize = size;
		((Form)this).BackColor = SystemColors.Control;
		size = new Size(560, 265);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)chkMSDSLab);
		((Control)this).Controls.Add((Control)(object)chkMSDSInc);
		((Control)this).Controls.Add((Control)(object)_txtMsds_0);
		((Control)this).Controls.Add((Control)(object)_txtMsds_1);
		((Control)this).Controls.Add((Control)(object)_txtMsds_2);
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)cmdClose);
		((Control)this).Controls.Add((Control)(object)_Label1_98);
		((Control)this).Controls.Add((Control)(object)_Label1_75);
		((Control)this).Controls.Add((Control)(object)_Label1_76);
		((Control)this).Controls.Add((Control)(object)lblInstructions);
		((Control)this).Cursor = Cursors.Default;
		((Control)this).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		location = new Point(250, 150);
		((Form)this).Location = location;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmMDUpdMsdsGE";
		((Control)this).RightToLeft = (RightToLeft)0;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Update MSDS Requirements";
		((ISupportInitialize)Label1).EndInit();
		((ISupportInitialize)txtMsds).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void cmdCancel_Click(object eventSender, EventArgs eventArgs)
	{
		((Form)this).Close();
	}

	private void cmdClose_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Invalid comparison between Unknown and I4
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Invalid comparison between Unknown and I4
		frmMain.DefInstance.txtMsds[(short)0].Text = txtMsds[(short)0].Text;
		frmMain.DefInstance.txtMsds[(short)1].Text = txtMsds[(short)1].Text;
		frmMain.DefInstance.txtMsds[(short)2].Text = txtMsds[(short)2].Text;
		frmMain.DefInstance.lblMsdsInc.Text = Conversions.ToString(Interaction.IIf((int)chkMSDSInc.CheckState == 1, (object)"Yes", (object)"No"));
		frmMain.DefInstance.lblMsdsLab.Text = Conversions.ToString(Interaction.IIf((int)chkMSDSLab.CheckState == 1, (object)"Yes", (object)"No"));
		Globals_Renamed.gblIWasChanged = true;
		((Form)this).Close();
	}

	public bool SetUp()
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
					clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
					Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					ProjectData.ClearProjectError();
					num2 = 2;
					command.ActiveConnection = Common.MyConn;
					command.CommandText = "pqryGetInstructions";
					command.CommandType = CommandTypeEnum.adCmdStoredProc;
					command.Parameters.Append(command.CreateParameter("pID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, 32));
					Command command2 = command;
					object RecordsAffected = Missing.Value;
					object Parameters = Missing.Value;
					recordset = command2.Execute(out RecordsAffected, ref Parameters);
					command.Parameters.Delete("pID");
					lblInstructions.Text = Conversions.ToString(recordset.Fields[0].Value);
					recordset.Close();
					txtMsds[(short)0].Text = frmMain.DefInstance.txtMsds[(short)0].Text;
					txtMsds[(short)1].Text = frmMain.DefInstance.txtMsds[(short)1].Text;
					txtMsds[(short)2].Text = frmMain.DefInstance.txtMsds[(short)2].Text;
					chkMSDSInc.CheckState = (CheckState)Conversions.ToInteger(Interaction.IIf(Operators.CompareString(frmMain.DefInstance.lblMsdsInc.Text, "Yes", false) == 0, (object)(CheckState)1, (object)(CheckState)0));
					chkMSDSLab.CheckState = (CheckState)Conversions.ToInteger(Interaction.IIf(Operators.CompareString(frmMain.DefInstance.lblMsdsLab.Text, "Yes", false) == 0, (object)(CheckState)1, (object)(CheckState)0));
					flag = true;
					recordset = null;
					command = null;
					goto end_IL_0001;
				}
				case 577:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						string Eobject = ((Control)this).Name;
						string Efunction = "";
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
				try0001_dispatch = 577;
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

	private void txtMsds_KeyDown(object eventSender, KeyEventArgs eventArgs)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		checked
		{
			short num = (short)eventArgs.KeyCode;
			short num2 = (short)unchecked(eventArgs.KeyData / 65536);
			short index = txtMsds.GetIndex((TextBox)eventSender);
			chkMSDSInc.CheckState = (CheckState)1;
		}
	}

	private void txtMsds_Leave(object eventSender, EventArgs eventArgs)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		short index = txtMsds.GetIndex((TextBox)eventSender);
		TextBox obj = txtMsds[index];
		TextBox val = txtMsds[index];
		string pText = val.Text;
		string text = ChemStrX.TrtLineBreak(ref pText);
		val.Text = pText;
		obj.Text = text;
	}
}
