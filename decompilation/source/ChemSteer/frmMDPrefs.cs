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
using Microsoft.VisualBasic.CompilerServices;

namespace ChemSteer;

internal class frmMDPrefs : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("_Label4_2")]
	private Label __Label4_2;

	[AccessedThroughProperty("_lblDefaultDBName_0")]
	private Label __lblDefaultDBName_0;

	[AccessedThroughProperty("_frmWhatAmIDoing_0")]
	private Panel __frmWhatAmIDoing_0;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("cmdOK")]
	private Button _cmdOK;

	[AccessedThroughProperty("_cmdBrowse_0")]
	private Button __cmdBrowse_0;

	[AccessedThroughProperty("_frmWhatAmIDoing_1")]
	private Panel __frmWhatAmIDoing_1;

	[AccessedThroughProperty("cmdRestoreVP")]
	private Button _cmdRestoreVP;

	[AccessedThroughProperty("txtVPhigh")]
	private TextBox _txtVPhigh;

	[AccessedThroughProperty("txtVPlow")]
	private TextBox _txtVPlow;

	[AccessedThroughProperty("_Label4_4")]
	private Label __Label4_4;

	[AccessedThroughProperty("_Label4_3")]
	private Label __Label4_3;

	[AccessedThroughProperty("_Label4_1")]
	private Label __Label4_1;

	[AccessedThroughProperty("_Label4_0")]
	private Label __Label4_0;

	[AccessedThroughProperty("_Label4_5")]
	private Label __Label4_5;

	[AccessedThroughProperty("_lblDefaultDBName_1")]
	private Label __lblDefaultDBName_1;

	[AccessedThroughProperty("_cmdBrowse_1")]
	private Button __cmdBrowse_1;

	[AccessedThroughProperty("_frmWhatAmIDoing_2")]
	private Panel __frmWhatAmIDoing_2;

	[AccessedThroughProperty("lblInstructions")]
	private Label _lblInstructions;

	private static frmMDPrefs m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	private short WhatAmIDoing;

	private const short DBdefault = 0;

	private const short VPrange = 1;

	private const short DBCRSSdefault = 2;

	public short iSelected;

	public virtual Label _Label4_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label4_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label4_2 = value;
		}
	}

	public virtual Label _lblDefaultDBName_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblDefaultDBName_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblDefaultDBName_0 = value;
		}
	}

	public virtual Panel _frmWhatAmIDoing_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __frmWhatAmIDoing_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__frmWhatAmIDoing_0 = value;
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

	public virtual Button cmdOK
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdOK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdOk_Click;
			if (_cmdOK != null)
			{
				((Control)_cmdOK).Click -= eventHandler;
			}
			_cmdOK = value;
			if (_cmdOK != null)
			{
				((Control)_cmdOK).Click += eventHandler;
			}
		}
	}

	public virtual Button _cmdBrowse_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __cmdBrowse_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _cmdBrowse_0_Click;
			if (__cmdBrowse_0 != null)
			{
				((Control)__cmdBrowse_0).Click -= eventHandler;
			}
			__cmdBrowse_0 = value;
			if (__cmdBrowse_0 != null)
			{
				((Control)__cmdBrowse_0).Click += eventHandler;
			}
		}
	}

	public virtual Panel _frmWhatAmIDoing_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __frmWhatAmIDoing_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__frmWhatAmIDoing_1 = value;
		}
	}

	public virtual Button cmdRestoreVP
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdRestoreVP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cmdRestoreVP = value;
		}
	}

	public virtual TextBox txtVPhigh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtVPhigh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtVPhigh = value;
		}
	}

	public virtual TextBox txtVPlow
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtVPlow;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtVPlow = value;
		}
	}

	public virtual Label _Label4_4
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label4_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label4_4 = value;
		}
	}

	public virtual Label _Label4_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label4_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label4_3 = value;
		}
	}

	public virtual Label _Label4_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label4_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label4_1 = value;
		}
	}

	public virtual Label _Label4_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label4_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label4_0 = value;
		}
	}

	public virtual Label _Label4_5
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label4_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label4_5 = value;
		}
	}

	public virtual Label _lblDefaultDBName_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblDefaultDBName_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblDefaultDBName_1 = value;
		}
	}

	public virtual Button _cmdBrowse_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __cmdBrowse_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _cmdBrowse_1_Click;
			if (__cmdBrowse_1 != null)
			{
				((Control)__cmdBrowse_1).Click -= eventHandler;
			}
			__cmdBrowse_1 = value;
			if (__cmdBrowse_1 != null)
			{
				((Control)__cmdBrowse_1).Click += eventHandler;
			}
		}
	}

	public virtual Panel _frmWhatAmIDoing_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __frmWhatAmIDoing_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			PaintEventHandler val = new PaintEventHandler(_frmWhatAmIDoing_2_Paint);
			if (__frmWhatAmIDoing_2 != null)
			{
				((Control)__frmWhatAmIDoing_2).Paint -= val;
			}
			__frmWhatAmIDoing_2 = value;
			if (__frmWhatAmIDoing_2 != null)
			{
				((Control)__frmWhatAmIDoing_2).Paint += val;
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

	public static frmMDPrefs DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmMDPrefs();
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

	public frmMDPrefs()
	{
		((Form)this).Load += frmMDPrefs_Load;
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
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected O, but got Unknown
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected O, but got Unknown
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Expected O, but got Unknown
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d2: Expected O, but got Unknown
		//IL_0595: Unknown result type (might be due to invalid IL or missing references)
		//IL_059f: Expected O, but got Unknown
		//IL_0655: Unknown result type (might be due to invalid IL or missing references)
		//IL_065f: Expected O, but got Unknown
		//IL_0719: Unknown result type (might be due to invalid IL or missing references)
		//IL_0723: Expected O, but got Unknown
		//IL_07dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e7: Expected O, but got Unknown
		//IL_08ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b8: Expected O, but got Unknown
		//IL_097e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0988: Expected O, but got Unknown
		//IL_0a4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a55: Expected O, but got Unknown
		//IL_0b17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b21: Expected O, but got Unknown
		//IL_0bda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be4: Expected O, but got Unknown
		//IL_0cad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb7: Expected O, but got Unknown
		//IL_0d80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8a: Expected O, but got Unknown
		//IL_0e41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4b: Expected O, but got Unknown
		//IL_0f11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f1b: Expected O, but got Unknown
		//IL_0fd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe2: Expected O, but got Unknown
		//IL_10eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f5: Expected O, but got Unknown
		//IL_1219: Unknown result type (might be due to invalid IL or missing references)
		//IL_1223: Expected O, but got Unknown
		//IL_1238: Unknown result type (might be due to invalid IL or missing references)
		//IL_1242: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMDPrefs));
		ToolTip1 = new ToolTip(components);
		_frmWhatAmIDoing_0 = new Panel();
		_frmWhatAmIDoing_1 = new Panel();
		cmdRestoreVP = new Button();
		txtVPhigh = new TextBox();
		txtVPlow = new TextBox();
		_Label4_4 = new Label();
		_Label4_3 = new Label();
		_Label4_1 = new Label();
		_Label4_0 = new Label();
		_cmdBrowse_0 = new Button();
		_Label4_2 = new Label();
		_lblDefaultDBName_0 = new Label();
		cmdCancel = new Button();
		cmdOK = new Button();
		lblInstructions = new Label();
		_Label4_5 = new Label();
		_lblDefaultDBName_1 = new Label();
		_cmdBrowse_1 = new Button();
		_frmWhatAmIDoing_2 = new Panel();
		((Control)_frmWhatAmIDoing_0).SuspendLayout();
		((Control)_frmWhatAmIDoing_1).SuspendLayout();
		((Control)_frmWhatAmIDoing_2).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)_frmWhatAmIDoing_0).BackColor = SystemColors.Control;
		((Control)_frmWhatAmIDoing_0).Controls.Add((Control)(object)_frmWhatAmIDoing_1);
		((Control)_frmWhatAmIDoing_0).Controls.Add((Control)(object)_cmdBrowse_0);
		((Control)_frmWhatAmIDoing_0).Controls.Add((Control)(object)_Label4_2);
		((Control)_frmWhatAmIDoing_0).Controls.Add((Control)(object)_lblDefaultDBName_0);
		((Control)_frmWhatAmIDoing_0).Cursor = Cursors.Default;
		((Control)_frmWhatAmIDoing_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_frmWhatAmIDoing_0).ForeColor = SystemColors.ControlText;
		Panel frmWhatAmIDoing_ = _frmWhatAmIDoing_0;
		Point location = new Point(3, 59);
		((Control)frmWhatAmIDoing_).Location = location;
		((Control)_frmWhatAmIDoing_0).Name = "_frmWhatAmIDoing_0";
		((Control)_frmWhatAmIDoing_0).RightToLeft = (RightToLeft)0;
		Panel frmWhatAmIDoing_2 = _frmWhatAmIDoing_0;
		Size size = new Size(601, 97);
		((Control)frmWhatAmIDoing_2).Size = size;
		((Control)_frmWhatAmIDoing_0).TabIndex = 3;
		((Control)_frmWhatAmIDoing_0).Visible = false;
		((Control)_frmWhatAmIDoing_1).BackColor = SystemColors.Control;
		((Control)_frmWhatAmIDoing_1).Controls.Add((Control)(object)cmdRestoreVP);
		((Control)_frmWhatAmIDoing_1).Controls.Add((Control)(object)txtVPhigh);
		((Control)_frmWhatAmIDoing_1).Controls.Add((Control)(object)txtVPlow);
		((Control)_frmWhatAmIDoing_1).Controls.Add((Control)(object)_Label4_4);
		((Control)_frmWhatAmIDoing_1).Controls.Add((Control)(object)_Label4_3);
		((Control)_frmWhatAmIDoing_1).Controls.Add((Control)(object)_Label4_1);
		((Control)_frmWhatAmIDoing_1).Controls.Add((Control)(object)_Label4_0);
		((Control)_frmWhatAmIDoing_1).Cursor = Cursors.Default;
		((Control)_frmWhatAmIDoing_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_frmWhatAmIDoing_1).ForeColor = SystemColors.ControlText;
		Panel frmWhatAmIDoing_3 = _frmWhatAmIDoing_1;
		location = new Point(5, 6);
		((Control)frmWhatAmIDoing_3).Location = location;
		((Control)_frmWhatAmIDoing_1).Name = "_frmWhatAmIDoing_1";
		((Control)_frmWhatAmIDoing_1).RightToLeft = (RightToLeft)0;
		Panel frmWhatAmIDoing_4 = _frmWhatAmIDoing_1;
		size = new Size(601, 97);
		((Control)frmWhatAmIDoing_4).Size = size;
		((Control)_frmWhatAmIDoing_1).TabIndex = 16;
		((Control)_frmWhatAmIDoing_1).Visible = false;
		((ButtonBase)cmdRestoreVP).BackColor = SystemColors.Control;
		((Control)cmdRestoreVP).Cursor = Cursors.Default;
		((Control)cmdRestoreVP).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdRestoreVP).ForeColor = SystemColors.ControlText;
		Button obj = cmdRestoreVP;
		location = new Point(344, 24);
		((Control)obj).Location = location;
		((Control)cmdRestoreVP).Name = "cmdRestoreVP";
		((Control)cmdRestoreVP).RightToLeft = (RightToLeft)0;
		Button obj2 = cmdRestoreVP;
		size = new Size(113, 25);
		((Control)obj2).Size = size;
		((Control)cmdRestoreVP).TabIndex = 14;
		((ButtonBase)cmdRestoreVP).Text = "Restore Defaults";
		((ButtonBase)cmdRestoreVP).UseVisualStyleBackColor = false;
		txtVPhigh.AcceptsReturn = true;
		((TextBoxBase)txtVPhigh).BackColor = SystemColors.Window;
		((Control)txtVPhigh).Cursor = Cursors.IBeam;
		((Control)txtVPhigh).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtVPhigh).ForeColor = SystemColors.WindowText;
		TextBox obj3 = txtVPhigh;
		location = new Point(248, 40);
		((Control)obj3).Location = location;
		((TextBoxBase)txtVPhigh).MaxLength = 8;
		((Control)txtVPhigh).Name = "txtVPhigh";
		((Control)txtVPhigh).RightToLeft = (RightToLeft)0;
		TextBox obj4 = txtVPhigh;
		size = new Size(57, 20);
		((Control)obj4).Size = size;
		((Control)txtVPhigh).TabIndex = 11;
		txtVPlow.AcceptsReturn = true;
		((TextBoxBase)txtVPlow).BackColor = SystemColors.Window;
		((Control)txtVPlow).Cursor = Cursors.IBeam;
		((Control)txtVPlow).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtVPlow).ForeColor = SystemColors.WindowText;
		TextBox obj5 = txtVPlow;
		location = new Point(248, 16);
		((Control)obj5).Location = location;
		((TextBoxBase)txtVPlow).MaxLength = 8;
		((Control)txtVPlow).Name = "txtVPlow";
		((Control)txtVPlow).RightToLeft = (RightToLeft)0;
		TextBox obj6 = txtVPlow;
		size = new Size(57, 20);
		((Control)obj6).Size = size;
		((Control)txtVPlow).TabIndex = 10;
		((Control)_Label4_4).BackColor = SystemColors.Control;
		((Control)_Label4_4).Cursor = Cursors.Default;
		((Control)_Label4_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_4).ForeColor = SystemColors.ControlText;
		Label label4_ = _Label4_4;
		location = new Point(312, 40);
		((Control)label4_).Location = location;
		((Control)_Label4_4).Name = "_Label4_4";
		((Control)_Label4_4).RightToLeft = (RightToLeft)0;
		Label label4_2 = _Label4_4;
		size = new Size(33, 17);
		((Control)label4_2).Size = size;
		((Control)_Label4_4).TabIndex = 13;
		_Label4_4.Text = "torr";
		((Control)_Label4_3).BackColor = SystemColors.Control;
		((Control)_Label4_3).Cursor = Cursors.Default;
		((Control)_Label4_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_3).ForeColor = SystemColors.ControlText;
		Label label4_3 = _Label4_3;
		location = new Point(312, 16);
		((Control)label4_3).Location = location;
		((Control)_Label4_3).Name = "_Label4_3";
		((Control)_Label4_3).RightToLeft = (RightToLeft)0;
		Label label4_4 = _Label4_3;
		size = new Size(33, 17);
		((Control)label4_4).Size = size;
		((Control)_Label4_3).TabIndex = 12;
		_Label4_3.Text = "torr";
		((Control)_Label4_1).BackColor = SystemColors.Control;
		((Control)_Label4_1).Cursor = Cursors.Default;
		((Control)_Label4_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_1).ForeColor = SystemColors.ControlText;
		Label label4_5 = _Label4_1;
		location = new Point(136, 40);
		((Control)label4_5).Location = location;
		((Control)_Label4_1).Name = "_Label4_1";
		((Control)_Label4_1).RightToLeft = (RightToLeft)0;
		Label label4_6 = _Label4_1;
		size = new Size(97, 17);
		((Control)label4_6).Size = size;
		((Control)_Label4_1).TabIndex = 9;
		_Label4_1.Text = "AVPhigh: ";
		_Label4_1.TextAlign = (ContentAlignment)4;
		((Control)_Label4_0).BackColor = SystemColors.Control;
		((Control)_Label4_0).Cursor = Cursors.Default;
		((Control)_Label4_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_0).ForeColor = SystemColors.ControlText;
		Label label4_7 = _Label4_0;
		location = new Point(136, 16);
		((Control)label4_7).Location = location;
		((Control)_Label4_0).Name = "_Label4_0";
		((Control)_Label4_0).RightToLeft = (RightToLeft)0;
		Label label4_8 = _Label4_0;
		size = new Size(97, 17);
		((Control)label4_8).Size = size;
		((Control)_Label4_0).TabIndex = 8;
		_Label4_0.Text = "AVPlow: ";
		_Label4_0.TextAlign = (ContentAlignment)4;
		((ButtonBase)_cmdBrowse_0).BackColor = SystemColors.Control;
		((Control)_cmdBrowse_0).Cursor = Cursors.Default;
		((Control)_cmdBrowse_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_cmdBrowse_0).ForeColor = SystemColors.ControlText;
		Button cmdBrowse_ = _cmdBrowse_0;
		location = new Point(16, 32);
		((Control)cmdBrowse_).Location = location;
		((Control)_cmdBrowse_0).Name = "_cmdBrowse_0";
		((Control)_cmdBrowse_0).RightToLeft = (RightToLeft)0;
		Button cmdBrowse_2 = _cmdBrowse_0;
		size = new Size(81, 19);
		((Control)cmdBrowse_2).Size = size;
		((Control)_cmdBrowse_0).TabIndex = 4;
		((ButtonBase)_cmdBrowse_0).Text = "Browse";
		((ButtonBase)_cmdBrowse_0).UseVisualStyleBackColor = false;
		((Control)_Label4_2).BackColor = SystemColors.Control;
		((Control)_Label4_2).Cursor = Cursors.Default;
		((Control)_Label4_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_2).ForeColor = SystemColors.ControlText;
		Label label4_9 = _Label4_2;
		location = new Point(8, 16);
		((Control)label4_9).Location = location;
		((Control)_Label4_2).Name = "_Label4_2";
		((Control)_Label4_2).RightToLeft = (RightToLeft)0;
		Label label4_10 = _Label4_2;
		size = new Size(97, 17);
		((Control)label4_10).Size = size;
		((Control)_Label4_2).TabIndex = 6;
		_Label4_2.Text = "Default database: ";
		_Label4_2.TextAlign = (ContentAlignment)4;
		((Control)_lblDefaultDBName_0).BackColor = SystemColors.Control;
		((Control)_lblDefaultDBName_0).Cursor = Cursors.Default;
		((Control)_lblDefaultDBName_0).Font = new Font("Arial", 8.25f, (FontStyle)4, (GraphicsUnit)3, (byte)0);
		((Control)_lblDefaultDBName_0).ForeColor = SystemColors.ControlText;
		Label lblDefaultDBName_ = _lblDefaultDBName_0;
		location = new Point(112, 16);
		((Control)lblDefaultDBName_).Location = location;
		((Control)_lblDefaultDBName_0).Name = "_lblDefaultDBName_0";
		((Control)_lblDefaultDBName_0).RightToLeft = (RightToLeft)0;
		Label lblDefaultDBName_2 = _lblDefaultDBName_0;
		size = new Size(489, 57);
		((Control)lblDefaultDBName_2).Size = size;
		((Control)_lblDefaultDBName_0).TabIndex = 5;
		_lblDefaultDBName_0.Text = "x";
		((ButtonBase)cmdCancel).BackColor = SystemColors.Control;
		((Control)cmdCancel).Cursor = Cursors.Default;
		((Control)cmdCancel).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCancel).ForeColor = SystemColors.ControlText;
		Button obj7 = cmdCancel;
		location = new Point(312, 168);
		((Control)obj7).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		((Control)cmdCancel).RightToLeft = (RightToLeft)0;
		Button obj8 = cmdCancel;
		size = new Size(81, 25);
		((Control)obj8).Size = size;
		((Control)cmdCancel).TabIndex = 1;
		((ButtonBase)cmdCancel).Text = "Cancel";
		((ButtonBase)cmdCancel).UseVisualStyleBackColor = false;
		((ButtonBase)cmdOK).BackColor = SystemColors.Control;
		((Control)cmdOK).Cursor = Cursors.Default;
		((Control)cmdOK).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdOK).ForeColor = SystemColors.ControlText;
		Button obj9 = cmdOK;
		location = new Point(216, 168);
		((Control)obj9).Location = location;
		((Control)cmdOK).Name = "cmdOK";
		((Control)cmdOK).RightToLeft = (RightToLeft)0;
		Button obj10 = cmdOK;
		size = new Size(81, 25);
		((Control)obj10).Size = size;
		((Control)cmdOK).TabIndex = 0;
		((ButtonBase)cmdOK).Text = "OK";
		((ButtonBase)cmdOK).UseVisualStyleBackColor = false;
		((Control)lblInstructions).BackColor = SystemColors.Control;
		((Control)lblInstructions).Cursor = Cursors.Default;
		((Control)lblInstructions).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblInstructions).ForeColor = SystemColors.ControlText;
		Label obj11 = lblInstructions;
		location = new Point(8, 8);
		((Control)obj11).Location = location;
		((Control)lblInstructions).Name = "lblInstructions";
		((Control)lblInstructions).RightToLeft = (RightToLeft)0;
		Label obj12 = lblInstructions;
		size = new Size(593, 49);
		((Control)obj12).Size = size;
		((Control)lblInstructions).TabIndex = 2;
		lblInstructions.Text = "xxx";
		((Control)_Label4_5).BackColor = SystemColors.Control;
		((Control)_Label4_5).Cursor = Cursors.Default;
		((Control)_Label4_5).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_5).ForeColor = SystemColors.ControlText;
		Label label4_11 = _Label4_5;
		location = new Point(6, 16);
		((Control)label4_11).Location = location;
		((Control)_Label4_5).Name = "_Label4_5";
		((Control)_Label4_5).RightToLeft = (RightToLeft)0;
		Label label4_12 = _Label4_5;
		size = new Size(131, 20);
		((Control)label4_12).Size = size;
		((Control)_Label4_5).TabIndex = 17;
		_Label4_5.Text = "Default CRSS database: ";
		_Label4_5.TextAlign = (ContentAlignment)4;
		((Control)_lblDefaultDBName_1).BackColor = SystemColors.Control;
		((Control)_lblDefaultDBName_1).Cursor = Cursors.Default;
		((Control)_lblDefaultDBName_1).Font = new Font("Arial", 8.25f, (FontStyle)4, (GraphicsUnit)3, (byte)0);
		((Control)_lblDefaultDBName_1).ForeColor = SystemColors.ControlText;
		Label lblDefaultDBName_3 = _lblDefaultDBName_1;
		location = new Point(136, 16);
		((Control)lblDefaultDBName_3).Location = location;
		((Control)_lblDefaultDBName_1).Name = "_lblDefaultDBName_1";
		((Control)_lblDefaultDBName_1).RightToLeft = (RightToLeft)0;
		Label lblDefaultDBName_4 = _lblDefaultDBName_1;
		size = new Size(465, 57);
		((Control)lblDefaultDBName_4).Size = size;
		((Control)_lblDefaultDBName_1).TabIndex = 18;
		_lblDefaultDBName_1.Text = "x";
		((ButtonBase)_cmdBrowse_1).BackColor = SystemColors.Control;
		((Control)_cmdBrowse_1).Cursor = Cursors.Default;
		((Control)_cmdBrowse_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_cmdBrowse_1).ForeColor = SystemColors.ControlText;
		Button cmdBrowse_3 = _cmdBrowse_1;
		location = new Point(16, 35);
		((Control)cmdBrowse_3).Location = location;
		((Control)_cmdBrowse_1).Name = "_cmdBrowse_1";
		((Control)_cmdBrowse_1).RightToLeft = (RightToLeft)0;
		Button cmdBrowse_4 = _cmdBrowse_1;
		size = new Size(81, 25);
		((Control)cmdBrowse_4).Size = size;
		((Control)_cmdBrowse_1).TabIndex = 16;
		((ButtonBase)_cmdBrowse_1).Text = "Browse";
		((ButtonBase)_cmdBrowse_1).UseVisualStyleBackColor = false;
		((Control)_frmWhatAmIDoing_2).BackColor = SystemColors.Control;
		((Control)_frmWhatAmIDoing_2).Controls.Add((Control)(object)_cmdBrowse_1);
		((Control)_frmWhatAmIDoing_2).Controls.Add((Control)(object)_lblDefaultDBName_1);
		((Control)_frmWhatAmIDoing_2).Controls.Add((Control)(object)_Label4_5);
		((Control)_frmWhatAmIDoing_2).Cursor = Cursors.Default;
		((Control)_frmWhatAmIDoing_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_frmWhatAmIDoing_2).ForeColor = SystemColors.ControlText;
		Panel frmWhatAmIDoing_5 = _frmWhatAmIDoing_2;
		location = new Point(0, 62);
		((Control)frmWhatAmIDoing_5).Location = location;
		((Control)_frmWhatAmIDoing_2).Name = "_frmWhatAmIDoing_2";
		((Control)_frmWhatAmIDoing_2).RightToLeft = (RightToLeft)0;
		Panel frmWhatAmIDoing_6 = _frmWhatAmIDoing_2;
		size = new Size(601, 97);
		((Control)frmWhatAmIDoing_6).Size = size;
		((Control)_frmWhatAmIDoing_2).TabIndex = 15;
		((Control)_frmWhatAmIDoing_2).Visible = false;
		((Form)this).AcceptButton = (IButtonControl)(object)cmdOK;
		size = new Size(5, 13);
		((Form)this).AutoScaleBaseSize = size;
		size = new Size(665, 245);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)_frmWhatAmIDoing_2);
		((Control)this).Controls.Add((Control)(object)_frmWhatAmIDoing_0);
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)cmdOK);
		((Control)this).Controls.Add((Control)(object)lblInstructions);
		((Control)this).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		location = new Point(250, 150);
		((Form)this).Location = location;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmMDPrefs";
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Preferences";
		((Control)_frmWhatAmIDoing_0).ResumeLayout(false);
		((Control)_frmWhatAmIDoing_1).ResumeLayout(false);
		((Control)_frmWhatAmIDoing_1).PerformLayout();
		((Control)_frmWhatAmIDoing_2).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	public bool SetUp(ref short iWhatAmIDoing)
	{
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
		Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		((Control)_frmWhatAmIDoing_0).Parent = (Control)(object)this;
		((Control)_frmWhatAmIDoing_1).Parent = (Control)(object)this;
		((Control)_frmWhatAmIDoing_1).Top = 59;
		((Control)_frmWhatAmIDoing_2).Parent = (Control)(object)this;
		WhatAmIDoing = iWhatAmIDoing;
		if (WhatAmIDoing == 0)
		{
			((Control)_frmWhatAmIDoing_0).Visible = true;
			((Control)_frmWhatAmIDoing_0).BringToFront();
			((Control)_frmWhatAmIDoing_1).Visible = false;
			((Control)_frmWhatAmIDoing_2).Visible = false;
			((Control)_frmWhatAmIDoing_1).SendToBack();
			((Control)_frmWhatAmIDoing_2).SendToBack();
		}
		else if (WhatAmIDoing == 1)
		{
			((Control)_frmWhatAmIDoing_1).Visible = true;
			((Control)_frmWhatAmIDoing_1).BringToFront();
			((Control)_frmWhatAmIDoing_0).Visible = false;
			((Control)_frmWhatAmIDoing_2).Visible = false;
			((Control)_frmWhatAmIDoing_0).SendToBack();
			((Control)_frmWhatAmIDoing_2).SendToBack();
		}
		else if (WhatAmIDoing == 2)
		{
			((Control)_frmWhatAmIDoing_2).Visible = true;
			((Control)_frmWhatAmIDoing_2).BringToFront();
			((Control)_frmWhatAmIDoing_0).Visible = false;
			((Control)_frmWhatAmIDoing_1).Visible = false;
			((Control)_frmWhatAmIDoing_0).SendToBack();
			((Control)_frmWhatAmIDoing_1).SendToBack();
		}
		command.ActiveConnection = Common.MyConn;
		command.CommandText = "pqryGetInstructions";
		command.CommandType = CommandTypeEnum.adCmdStoredProc;
		switch (WhatAmIDoing)
		{
		case 0:
			_lblDefaultDBName_0.Text = Interaction.GetSetting("ChemSteer", "Options", "DefaultDBN", "None Specified");
			command.Parameters.Append(command.CreateParameter("pID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, 45));
			break;
		case 1:
			txtVPlow.Text = Interaction.GetSetting("ChemSteer", "Options", "VPlow", "0.001");
			txtVPhigh.Text = Interaction.GetSetting("ChemSteer", "Options", "VPhigh", "35");
			command.Parameters.Append(command.CreateParameter("pID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, 38));
			break;
		case 2:
			_lblDefaultDBName_1.Text = Interaction.GetSetting("ChemSteer", "Options", "DefaultCRSSDBN", "None Specified");
			if (Operators.CompareString(_lblDefaultDBName_1.Text, "", false) == 0)
			{
				_lblDefaultDBName_1.Text = "None specified";
			}
			command.Parameters.Append(command.CreateParameter("pID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, 46));
			break;
		}
		Command command2 = command;
		object RecordsAffected = Missing.Value;
		object Parameters = Missing.Value;
		recordset = command2.Execute(out RecordsAffected, ref Parameters);
		command.Parameters.Delete("pID");
		lblInstructions.Text = Conversions.ToString(recordset.Fields[0].Value);
		recordset.Close();
		recordset = null;
		command = null;
		return true;
	}

	private void cmdBrowseClick()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Invalid comparison between Unknown and I4
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		OpenFileDialog val = default(OpenFileDialog);
		OpenFileDialog val2 = default(OpenFileDialog);
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
				case 351:
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
							goto IL_0012;
						case 4:
							goto IL_0017;
						case 5:
							goto IL_0029;
						case 7:
							goto IL_003a;
						case 8:
							goto IL_003e;
						case 9:
							goto IL_004d;
						case 6:
						case 10:
						case 11:
							goto IL_0072;
						case 12:
							goto IL_0082;
						case 13:
							goto IL_0092;
						case 14:
							goto IL_0094;
						case 15:
							goto IL_00a7;
						case 16:
							goto IL_00ba;
						case 18:
							goto IL_00d2;
						case 19:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 17:
						case 20:
						case 21:
						case 22:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_00a7:
					num = 15;
					if (WhatAmIDoing == 0)
					{
						goto IL_00ba;
					}
					goto IL_00d2;
					IL_00ba:
					num = 16;
					_lblDefaultDBName_0.Text = ((FileDialog)val).FileName;
					goto end_IL_0001_3;
					IL_0094:
					num = 14;
					if ((int)((CommonDialog)val).ShowDialog() != 1)
					{
						goto end_IL_0001_3;
					}
					goto IL_00a7;
					IL_00d2:
					num = 18;
					break;
					IL_0009:
					num = 2;
					val = new OpenFileDialog();
					goto IL_0012;
					IL_0012:
					num = 3;
					val2 = val;
					goto IL_0017;
					IL_0017:
					num = 4;
					if (WhatAmIDoing == 0)
					{
						goto IL_0029;
					}
					goto IL_003a;
					IL_0029:
					num = 5;
					((FileDialog)val2).Title = "Select the ChemSTEER database you wish to make your default database";
					goto IL_0072;
					IL_003a:
					num = 7;
					goto IL_003e;
					IL_003e:
					num = 8;
					((FileDialog)val2).Title = "Select the CRSS database you wish to make your default database";
					goto IL_004d;
					IL_004d:
					num = 9;
					((FileDialog)val2).InitialDirectory = Interaction.GetSetting("ChemSteer", "Options", "DefaultCRSSPath", "j:\\process\\initchem\\");
					goto IL_0072;
					IL_0072:
					num = 11;
					((FileDialog)val2).FileName = "*.mdb";
					goto IL_0082;
					IL_0082:
					num = 12;
					((FileDialog)val2).Filter = "Access Databases (*.MDB)|*.MDB";
					goto IL_0092;
					IL_0092:
					val2 = null;
					goto IL_0094;
					end_IL_0001_2:
					break;
				}
				num = 19;
				_lblDefaultDBName_1.Text = ((FileDialog)val).FileName;
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 351;
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

	private void cmdCancel_Click(object eventSender, EventArgs eventArgs)
	{
		((Form)this).Close();
	}

	private void cmdRestoreVP_Click(object eventSender, EventArgs eventArgs)
	{
		txtVPlow.Text = "0.001";
		txtVPhigh.Text = "35";
	}

	private void frmMDPrefs_Load(object eventSender, EventArgs eventArgs)
	{
	}

	private void cmdOk_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		switch (WhatAmIDoing)
		{
		case 0:
			Interaction.SaveSetting("ChemSteer", "Options", "DefaultDBN", _lblDefaultDBName_0.Text);
			break;
		case 1:
			if (Versioned.IsNumeric((object)txtVPlow.Text) & Versioned.IsNumeric((object)txtVPhigh.Text))
			{
				Interaction.SaveSetting("ChemSteer", "Options", "VPlow", txtVPlow.Text);
				Interaction.SaveSetting("ChemSteer", "Options", "VPhigh", txtVPhigh.Text);
				break;
			}
			Interaction.Beep();
			Interaction.MsgBox((object)"Please enter a valid VP range", (MsgBoxStyle)0, (object)null);
			return;
		case 2:
			Interaction.SaveSetting("ChemSteer", "Options", "DefaultCRSSDBN", _lblDefaultDBName_1.Text);
			Interaction.SaveSetting("ChemSteer", "Options", "DefaultCRSSPath", FileSystem.CurDir(Conversions.ToChar(_lblDefaultDBName_1.Text)));
			break;
		}
		((Form)this).Close();
	}

	private void _frmWhatAmIDoing_2_Paint(object sender, PaintEventArgs e)
	{
	}

	private void _cmdBrowse_0_Click(object sender, EventArgs e)
	{
		cmdBrowseClick();
	}

	private void _cmdBrowse_1_Click(object sender, EventArgs e)
	{
		cmdBrowseClick();
	}

	private void CheckoptMassParm(short index)
	{
		iSelected = index;
		short num = 0;
		checked
		{
			short num2;
			short num3;
			do
			{
				if (num == index)
				{
				}
				num = (short)unchecked(num + 1);
				num2 = num;
				num3 = 1;
			}
			while (num2 <= num3);
		}
	}
}
