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

internal class frmMDUpdPS : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("_cmdReset_1")]
	private Button __cmdReset_1;

	[AccessedThroughProperty("_cmdReset_0")]
	private Button __cmdReset_0;

	[AccessedThroughProperty("_cmbPS_2")]
	private ComboBox __cmbPS_2;

	[AccessedThroughProperty("_txtPSOtherInfo_2")]
	private TextBox __txtPSOtherInfo_2;

	[AccessedThroughProperty("_txtPSOtherInfo_1")]
	private TextBox __txtPSOtherInfo_1;

	[AccessedThroughProperty("_txtPSOtherInfo_0")]
	private TextBox __txtPSOtherInfo_0;

	[AccessedThroughProperty("_cmbPS_1")]
	private ComboBox __cmbPS_1;

	[AccessedThroughProperty("_cmbPS_0")]
	private ComboBox __cmbPS_0;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("cmdOK")]
	private Button _cmdOK;

	[AccessedThroughProperty("_Label4_3")]
	private Label __Label4_3;

	[AccessedThroughProperty("_Label4_2")]
	private Label __Label4_2;

	[AccessedThroughProperty("_Label4_0")]
	private Label __Label4_0;

	[AccessedThroughProperty("lblInstructions")]
	private Label _lblInstructions;

	[AccessedThroughProperty("_Label4_1")]
	private Label __Label4_1;

	[AccessedThroughProperty("_Label4_6")]
	private Label __Label4_6;

	[AccessedThroughProperty("_cmdReset_2")]
	private Button __cmdReset_2;

	[AccessedThroughProperty("lblOp")]
	private Label _lblOp;

	private static frmMDUpdPS m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	public virtual Button _cmdReset_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __cmdReset_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdReset_Click;
			if (__cmdReset_1 != null)
			{
				((Control)__cmdReset_1).Click -= eventHandler;
			}
			__cmdReset_1 = value;
			if (__cmdReset_1 != null)
			{
				((Control)__cmdReset_1).Click += eventHandler;
			}
		}
	}

	public virtual Button _cmdReset_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __cmdReset_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdReset_Click;
			if (__cmdReset_0 != null)
			{
				((Control)__cmdReset_0).Click -= eventHandler;
			}
			__cmdReset_0 = value;
			if (__cmdReset_0 != null)
			{
				((Control)__cmdReset_0).Click += eventHandler;
			}
		}
	}

	public virtual ComboBox _cmbPS_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __cmbPS_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__cmbPS_2 = value;
		}
	}

	public virtual TextBox _txtPSOtherInfo_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtPSOtherInfo_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtPSOtherInfo_2 = value;
		}
	}

	public virtual TextBox _txtPSOtherInfo_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtPSOtherInfo_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtPSOtherInfo_1 = value;
		}
	}

	public virtual TextBox _txtPSOtherInfo_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtPSOtherInfo_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtPSOtherInfo_0 = value;
		}
	}

	public virtual ComboBox _cmbPS_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __cmbPS_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__cmbPS_1 = value;
		}
	}

	public virtual ComboBox _cmbPS_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __cmbPS_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__cmbPS_0 = value;
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

	public virtual Label _Label4_6
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label4_6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label4_6 = value;
		}
	}

	public virtual Button _cmdReset_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __cmdReset_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdReset_Click;
			if (__cmdReset_2 != null)
			{
				((Control)__cmdReset_2).Click -= eventHandler;
			}
			__cmdReset_2 = value;
			if (__cmdReset_2 != null)
			{
				((Control)__cmdReset_2).Click += eventHandler;
			}
		}
	}

	public virtual Label lblOp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblOp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblOp = value;
		}
	}

	public static frmMDUpdPS DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmMDUpdPS();
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

	public frmMDUpdPS()
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
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected O, but got Unknown
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected O, but got Unknown
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected O, but got Unknown
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Expected O, but got Unknown
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0566: Expected O, but got Unknown
		//IL_062f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0639: Expected O, but got Unknown
		//IL_06f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fb: Expected O, but got Unknown
		//IL_07a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b0: Expected O, but got Unknown
		//IL_087a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0884: Expected O, but got Unknown
		//IL_094e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0958: Expected O, but got Unknown
		//IL_0a22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2c: Expected O, but got Unknown
		//IL_0af6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b00: Expected O, but got Unknown
		//IL_0bbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc7: Expected O, but got Unknown
		//IL_0c80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8a: Expected O, but got Unknown
		//IL_0d53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5d: Expected O, but got Unknown
		//IL_0e24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2e: Expected O, but got Unknown
		//IL_0ee7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef1: Expected O, but got Unknown
		//IL_112b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1135: Expected O, but got Unknown
		//IL_114a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1154: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMDUpdPS));
		ToolTip1 = new ToolTip(components);
		_cmdReset_1 = new Button();
		_cmdReset_0 = new Button();
		_cmbPS_2 = new ComboBox();
		_txtPSOtherInfo_2 = new TextBox();
		_txtPSOtherInfo_1 = new TextBox();
		_txtPSOtherInfo_0 = new TextBox();
		_cmbPS_1 = new ComboBox();
		_cmbPS_0 = new ComboBox();
		cmdCancel = new Button();
		cmdOK = new Button();
		_Label4_3 = new Label();
		_Label4_2 = new Label();
		_Label4_0 = new Label();
		lblInstructions = new Label();
		_Label4_1 = new Label();
		_Label4_6 = new Label();
		lblOp = new Label();
		_cmdReset_2 = new Button();
		((Control)this).SuspendLayout();
		((ButtonBase)_cmdReset_1).BackColor = SystemColors.Control;
		((Control)_cmdReset_1).Cursor = Cursors.Default;
		((Control)_cmdReset_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_cmdReset_1).ForeColor = SystemColors.ControlText;
		Button cmdReset_ = _cmdReset_1;
		Point location = new Point(264, 160);
		((Control)cmdReset_).Location = location;
		((Control)_cmdReset_1).Name = "_cmdReset_1";
		((Control)_cmdReset_1).RightToLeft = (RightToLeft)0;
		Button cmdReset_2 = _cmdReset_1;
		Size size = new Size(49, 17);
		((Control)cmdReset_2).Size = size;
		((Control)_cmdReset_1).TabIndex = 4;
		((ButtonBase)_cmdReset_1).Text = "Reset";
		((ButtonBase)_cmdReset_1).UseVisualStyleBackColor = false;
		((ButtonBase)_cmdReset_0).BackColor = SystemColors.Control;
		((Control)_cmdReset_0).Cursor = Cursors.Default;
		((Control)_cmdReset_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_cmdReset_0).ForeColor = SystemColors.ControlText;
		Button cmdReset_3 = _cmdReset_0;
		location = new Point(264, 128);
		((Control)cmdReset_3).Location = location;
		((Control)_cmdReset_0).Name = "_cmdReset_0";
		((Control)_cmdReset_0).RightToLeft = (RightToLeft)0;
		Button cmdReset_4 = _cmdReset_0;
		size = new Size(49, 17);
		((Control)cmdReset_4).Size = size;
		((Control)_cmdReset_0).TabIndex = 1;
		((ButtonBase)_cmdReset_0).Text = "Reset";
		((ButtonBase)_cmdReset_0).UseVisualStyleBackColor = false;
		_cmbPS_2.BackColor = SystemColors.Window;
		((Control)_cmbPS_2).Cursor = Cursors.Default;
		_cmbPS_2.DropDownStyle = (ComboBoxStyle)2;
		((Control)_cmbPS_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		_cmbPS_2.ForeColor = SystemColors.WindowText;
		ComboBox cmbPS_ = _cmbPS_2;
		location = new Point(176, 192);
		((Control)cmbPS_).Location = location;
		((Control)_cmbPS_2).Name = "_cmbPS_2";
		((Control)_cmbPS_2).RightToLeft = (RightToLeft)0;
		ComboBox cmbPS_2 = _cmbPS_2;
		size = new Size(81, 22);
		((Control)cmbPS_2).Size = size;
		((Control)_cmbPS_2).TabIndex = 6;
		_txtPSOtherInfo_2.AcceptsReturn = true;
		((TextBoxBase)_txtPSOtherInfo_2).BackColor = SystemColors.Window;
		((Control)_txtPSOtherInfo_2).Cursor = Cursors.IBeam;
		((Control)_txtPSOtherInfo_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtPSOtherInfo_2).ForeColor = SystemColors.WindowText;
		TextBox txtPSOtherInfo_ = _txtPSOtherInfo_2;
		location = new Point(320, 192);
		((Control)txtPSOtherInfo_).Location = location;
		((TextBoxBase)_txtPSOtherInfo_2).MaxLength = 100;
		((Control)_txtPSOtherInfo_2).Name = "_txtPSOtherInfo_2";
		((Control)_txtPSOtherInfo_2).RightToLeft = (RightToLeft)0;
		TextBox txtPSOtherInfo_2 = _txtPSOtherInfo_2;
		size = new Size(337, 20);
		((Control)txtPSOtherInfo_2).Size = size;
		((Control)_txtPSOtherInfo_2).TabIndex = 8;
		_txtPSOtherInfo_1.AcceptsReturn = true;
		((TextBoxBase)_txtPSOtherInfo_1).BackColor = SystemColors.Window;
		((Control)_txtPSOtherInfo_1).Cursor = Cursors.IBeam;
		((Control)_txtPSOtherInfo_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtPSOtherInfo_1).ForeColor = SystemColors.WindowText;
		TextBox txtPSOtherInfo_3 = _txtPSOtherInfo_1;
		location = new Point(320, 160);
		((Control)txtPSOtherInfo_3).Location = location;
		((TextBoxBase)_txtPSOtherInfo_1).MaxLength = 100;
		((Control)_txtPSOtherInfo_1).Name = "_txtPSOtherInfo_1";
		((Control)_txtPSOtherInfo_1).RightToLeft = (RightToLeft)0;
		TextBox txtPSOtherInfo_4 = _txtPSOtherInfo_1;
		size = new Size(337, 20);
		((Control)txtPSOtherInfo_4).Size = size;
		((Control)_txtPSOtherInfo_1).TabIndex = 5;
		_txtPSOtherInfo_0.AcceptsReturn = true;
		((TextBoxBase)_txtPSOtherInfo_0).BackColor = SystemColors.Window;
		((Control)_txtPSOtherInfo_0).Cursor = Cursors.IBeam;
		((Control)_txtPSOtherInfo_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtPSOtherInfo_0).ForeColor = SystemColors.WindowText;
		TextBox txtPSOtherInfo_5 = _txtPSOtherInfo_0;
		location = new Point(320, 128);
		((Control)txtPSOtherInfo_5).Location = location;
		((TextBoxBase)_txtPSOtherInfo_0).MaxLength = 100;
		((Control)_txtPSOtherInfo_0).Name = "_txtPSOtherInfo_0";
		((Control)_txtPSOtherInfo_0).RightToLeft = (RightToLeft)0;
		TextBox txtPSOtherInfo_6 = _txtPSOtherInfo_0;
		size = new Size(337, 20);
		((Control)txtPSOtherInfo_6).Size = size;
		((Control)_txtPSOtherInfo_0).TabIndex = 2;
		_cmbPS_1.BackColor = SystemColors.Window;
		((Control)_cmbPS_1).Cursor = Cursors.Default;
		_cmbPS_1.DropDownStyle = (ComboBoxStyle)2;
		((Control)_cmbPS_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		_cmbPS_1.ForeColor = SystemColors.WindowText;
		ComboBox cmbPS_3 = _cmbPS_1;
		location = new Point(176, 160);
		((Control)cmbPS_3).Location = location;
		((Control)_cmbPS_1).Name = "_cmbPS_1";
		((Control)_cmbPS_1).RightToLeft = (RightToLeft)0;
		ComboBox cmbPS_4 = _cmbPS_1;
		size = new Size(81, 22);
		((Control)cmbPS_4).Size = size;
		((Control)_cmbPS_1).TabIndex = 3;
		_cmbPS_0.BackColor = SystemColors.Window;
		((Control)_cmbPS_0).Cursor = Cursors.Default;
		_cmbPS_0.DropDownStyle = (ComboBoxStyle)2;
		((Control)_cmbPS_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		_cmbPS_0.ForeColor = SystemColors.WindowText;
		ComboBox cmbPS_5 = _cmbPS_0;
		location = new Point(176, 128);
		((Control)cmbPS_5).Location = location;
		((Control)_cmbPS_0).Name = "_cmbPS_0";
		((Control)_cmbPS_0).RightToLeft = (RightToLeft)0;
		ComboBox cmbPS_6 = _cmbPS_0;
		size = new Size(81, 22);
		((Control)cmbPS_6).Size = size;
		((Control)_cmbPS_0).TabIndex = 0;
		((ButtonBase)cmdCancel).BackColor = SystemColors.Control;
		((Control)cmdCancel).Cursor = Cursors.Default;
		((Control)cmdCancel).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCancel).ForeColor = SystemColors.ControlText;
		Button obj = cmdCancel;
		location = new Point(312, 240);
		((Control)obj).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		((Control)cmdCancel).RightToLeft = (RightToLeft)0;
		Button obj2 = cmdCancel;
		size = new Size(81, 25);
		((Control)obj2).Size = size;
		((Control)cmdCancel).TabIndex = 10;
		((ButtonBase)cmdCancel).Text = "Cancel";
		((ButtonBase)cmdCancel).UseVisualStyleBackColor = false;
		((ButtonBase)cmdOK).BackColor = SystemColors.Control;
		((Control)cmdOK).Cursor = Cursors.Default;
		((Control)cmdOK).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdOK).ForeColor = SystemColors.ControlText;
		Button obj3 = cmdOK;
		location = new Point(216, 240);
		((Control)obj3).Location = location;
		((Control)cmdOK).Name = "cmdOK";
		((Control)cmdOK).RightToLeft = (RightToLeft)0;
		Button obj4 = cmdOK;
		size = new Size(81, 25);
		((Control)obj4).Size = size;
		((Control)cmdOK).TabIndex = 9;
		((ButtonBase)cmdOK).Text = "OK";
		((ButtonBase)cmdOK).UseVisualStyleBackColor = false;
		((Control)_Label4_3).BackColor = SystemColors.Control;
		((Control)_Label4_3).Cursor = Cursors.Default;
		((Control)_Label4_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_3).ForeColor = SystemColors.ControlText;
		Label label4_ = _Label4_3;
		location = new Point(16, 192);
		((Control)label4_).Location = location;
		((Control)_Label4_3).Name = "_Label4_3";
		((Control)_Label4_3).RightToLeft = (RightToLeft)0;
		Label label4_2 = _Label4_3;
		size = new Size(154, 17);
		((Control)label4_2).Size = size;
		((Control)_Label4_3).TabIndex = 17;
		_Label4_3.Text = "Chemical in the Operation:";
		_Label4_3.TextAlign = (ContentAlignment)4;
		((Control)_Label4_2).BackColor = SystemColors.Control;
		((Control)_Label4_2).Cursor = Cursors.Default;
		((Control)_Label4_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_2).ForeColor = SystemColors.ControlText;
		Label label4_3 = _Label4_2;
		location = new Point(16, 128);
		((Control)label4_3).Location = location;
		((Control)_Label4_2).Name = "_Label4_2";
		((Control)_Label4_2).RightToLeft = (RightToLeft)0;
		Label label4_4 = _Label4_2;
		size = new Size(154, 19);
		((Control)label4_4).Size = size;
		((Control)_Label4_2).TabIndex = 16;
		_Label4_2.Text = "Chemical into the Operation:";
		_Label4_2.TextAlign = (ContentAlignment)4;
		((Control)_Label4_0).BackColor = SystemColors.Control;
		((Control)_Label4_0).Cursor = Cursors.Default;
		((Control)_Label4_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_0).ForeColor = SystemColors.ControlText;
		Label label4_5 = _Label4_0;
		location = new Point(320, 104);
		((Control)label4_5).Location = location;
		((Control)_Label4_0).Name = "_Label4_0";
		((Control)_Label4_0).RightToLeft = (RightToLeft)0;
		Label label4_6 = _Label4_0;
		size = new Size(145, 17);
		((Control)label4_6).Size = size;
		((Control)_Label4_0).TabIndex = 15;
		_Label4_0.Text = "Other Information: ";
		((Control)lblInstructions).BackColor = SystemColors.Control;
		((Control)lblInstructions).Cursor = Cursors.Default;
		((Control)lblInstructions).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblInstructions).ForeColor = SystemColors.ControlText;
		Label obj5 = lblInstructions;
		location = new Point(8, 40);
		((Control)obj5).Location = location;
		((Control)lblInstructions).Name = "lblInstructions";
		((Control)lblInstructions).RightToLeft = (RightToLeft)0;
		Label obj6 = lblInstructions;
		size = new Size(641, 49);
		((Control)obj6).Size = size;
		((Control)lblInstructions).TabIndex = 14;
		lblInstructions.Text = "xxx";
		((Control)_Label4_1).BackColor = SystemColors.Control;
		((Control)_Label4_1).Cursor = Cursors.Default;
		((Control)_Label4_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_1).ForeColor = SystemColors.ControlText;
		Label label4_7 = _Label4_1;
		location = new Point(2, 160);
		((Control)label4_7).Location = location;
		((Control)_Label4_1).Name = "_Label4_1";
		((Control)_Label4_1).RightToLeft = (RightToLeft)0;
		Label label4_8 = _Label4_1;
		size = new Size(168, 17);
		((Control)label4_8).Size = size;
		((Control)_Label4_1).TabIndex = 13;
		_Label4_1.Text = "Chemical out of the Operation:";
		_Label4_1.TextAlign = (ContentAlignment)4;
		((Control)_Label4_6).BackColor = SystemColors.Control;
		((Control)_Label4_6).Cursor = Cursors.Default;
		((Control)_Label4_6).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_6).ForeColor = SystemColors.ControlText;
		Label label4_9 = _Label4_6;
		location = new Point(176, 104);
		((Control)label4_9).Location = location;
		((Control)_Label4_6).Name = "_Label4_6";
		((Control)_Label4_6).RightToLeft = (RightToLeft)0;
		Label label4_10 = _Label4_6;
		size = new Size(81, 17);
		((Control)label4_10).Size = size;
		((Control)_Label4_6).TabIndex = 12;
		_Label4_6.Text = "Physical State";
		_Label4_6.TextAlign = (ContentAlignment)2;
		((Control)lblOp).BackColor = SystemColors.Control;
		((Control)lblOp).Cursor = Cursors.Default;
		((Control)lblOp).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)lblOp).ForeColor = SystemColors.ControlText;
		Label obj7 = lblOp;
		location = new Point(8, 16);
		((Control)obj7).Location = location;
		((Control)lblOp).Name = "lblOp";
		((Control)lblOp).RightToLeft = (RightToLeft)0;
		Label obj8 = lblOp;
		size = new Size(417, 17);
		((Control)obj8).Size = size;
		((Control)lblOp).TabIndex = 11;
		lblOp.Text = "User-defined processing";
		((ButtonBase)_cmdReset_2).BackColor = SystemColors.Control;
		((Control)_cmdReset_2).Cursor = Cursors.Default;
		((Control)_cmdReset_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_cmdReset_2).ForeColor = SystemColors.ControlText;
		Button cmdReset_5 = _cmdReset_2;
		location = new Point(264, 194);
		((Control)cmdReset_5).Location = location;
		((Control)_cmdReset_2).Name = "_cmdReset_2";
		((Control)_cmdReset_2).RightToLeft = (RightToLeft)0;
		Button cmdReset_6 = _cmdReset_2;
		size = new Size(49, 17);
		((Control)cmdReset_6).Size = size;
		((Control)_cmdReset_2).TabIndex = 7;
		((ButtonBase)_cmdReset_2).Text = "Reset";
		((ButtonBase)_cmdReset_2).UseVisualStyleBackColor = false;
		((Form)this).AcceptButton = (IButtonControl)(object)cmdOK;
		size = new Size(5, 13);
		((Form)this).AutoScaleBaseSize = size;
		((Form)this).BackColor = SystemColors.Control;
		size = new Size(667, 286);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)_cmdReset_2);
		((Control)this).Controls.Add((Control)(object)_cmdReset_1);
		((Control)this).Controls.Add((Control)(object)_cmdReset_0);
		((Control)this).Controls.Add((Control)(object)_cmbPS_2);
		((Control)this).Controls.Add((Control)(object)_txtPSOtherInfo_2);
		((Control)this).Controls.Add((Control)(object)_txtPSOtherInfo_1);
		((Control)this).Controls.Add((Control)(object)_txtPSOtherInfo_0);
		((Control)this).Controls.Add((Control)(object)_cmbPS_1);
		((Control)this).Controls.Add((Control)(object)_cmbPS_0);
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)cmdOK);
		((Control)this).Controls.Add((Control)(object)_Label4_3);
		((Control)this).Controls.Add((Control)(object)_Label4_2);
		((Control)this).Controls.Add((Control)(object)_Label4_0);
		((Control)this).Controls.Add((Control)(object)lblInstructions);
		((Control)this).Controls.Add((Control)(object)_Label4_1);
		((Control)this).Controls.Add((Control)(object)_Label4_6);
		((Control)this).Controls.Add((Control)(object)lblOp);
		((Control)this).Cursor = Cursors.Default;
		((Control)this).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		location = new Point(250, 150);
		((Form)this).Location = location;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmMDUpdPS";
		((Control)this).RightToLeft = (RightToLeft)0;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Update Operation Physical State";
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public bool SetUp()
	{
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
		Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		command.ActiveConnection = Common.MyConn;
		command.CommandText = "pqryGetInstructions";
		command.CommandType = CommandTypeEnum.adCmdStoredProc;
		command.Parameters.Append(command.CreateParameter("pID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, 13));
		Command command2 = command;
		object RecordsAffected = Missing.Value;
		object Parameters = Missing.Value;
		recordset = command2.Execute(out RecordsAffected, ref Parameters);
		command.Parameters.Delete("pID");
		lblInstructions.Text = Conversions.ToString(recordset.Fields[0].Value);
		recordset.Close();
		recordset = null;
		command = null;
		PopulateControls();
		lblOp.Text = frmMain.DefInstance._lstSelOps_0.Text;
		return true;
	}

	private void cmdCancel_Click(object eventSender, EventArgs eventArgs)
	{
		((Form)this).Close();
	}

	private void cmdReset_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		object obj = NewLateBinding.LateGet(eventSender, (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null);
		if (Operators.ConditionalCompareObjectEqual(obj, (object)"_cmdReset_0", false))
		{
			_cmbPS_0.SelectedIndex = -1;
		}
		else if (Operators.ConditionalCompareObjectEqual(obj, (object)"_cmdReset_1", false))
		{
			_cmbPS_1.SelectedIndex = -1;
		}
		else if (Operators.ConditionalCompareObjectEqual(obj, (object)"_cmdReset_2", false))
		{
			_cmbPS_2.SelectedIndex = -1;
		}
		else
		{
			Interaction.MsgBox((object)"An error was detected in cmdReset_click, please contact Technical Support", (MsgBoxStyle)16, (object)"ChemSTEER Error");
		}
	}

	private void cmdOk_Click(object eventSender, EventArgs eventArgs)
	{
		UpdateFrmMain();
		Globals_Renamed.gblIWasChanged = true;
		((Form)this).Close();
	}

	private void PopulateControls()
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		_cmbPS_0.Items.Clear();
		_cmbPS_1.Items.Clear();
		_cmbPS_2.Items.Clear();
		recordset.CursorLocation = CursorLocationEnum.adUseClient;
		recordset.Open("SELECT * FROM ListOfPhyStates", Common.MyConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
		while (!recordset.EOF)
		{
			_cmbPS_0.Items.Add((object)new ListBoxItem(Conversions.ToString(recordset.Fields["PhyState"].Value), Conversions.ToInteger(recordset.Fields["PhyStateID"].Value)));
			_cmbPS_1.Items.Add((object)new ListBoxItem(Conversions.ToString(recordset.Fields["PhyState"].Value), Conversions.ToInteger(recordset.Fields["PhyStateID"].Value)));
			_cmbPS_2.Items.Add((object)new ListBoxItem(Conversions.ToString(recordset.Fields["PhyState"].Value), Conversions.ToInteger(recordset.Fields["PhyStateID"].Value)));
			recordset.MoveNext();
		}
		recordset.Close();
		recordset = null;
		checked
		{
			int num = _cmbPS_0.Items.Count - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				if (Operators.CompareString(Support.GetItemString((Control)(object)_cmbPS_0, num2), frmMain.DefInstance._lblPhyState_0.Text, false) == 0)
				{
					_cmbPS_0.SelectedIndex = num2;
					break;
				}
				num2++;
			}
			_txtPSOtherInfo_0.Text = frmMain.DefInstance._lblPhyStateOtherInfo_0.Text;
			int num5 = _cmbPS_1.Items.Count - 1;
			num2 = 0;
			while (true)
			{
				int num6 = num2;
				int num4 = num5;
				if (num6 > num4)
				{
					break;
				}
				if (Operators.CompareString(Support.GetItemString((Control)(object)_cmbPS_1, num2), frmMain.DefInstance._lblPhyState_1.Text, false) == 0)
				{
					_cmbPS_1.SelectedIndex = num2;
					break;
				}
				num2++;
			}
			_txtPSOtherInfo_1.Text = frmMain.DefInstance._lblPhyStateOtherInfo_1.Text;
			int num7 = _cmbPS_2.Items.Count - 1;
			num2 = 0;
			while (true)
			{
				int num8 = num2;
				int num4 = num7;
				if (num8 > num4)
				{
					break;
				}
				if (Operators.CompareString(Support.GetItemString((Control)(object)_cmbPS_2, num2), frmMain.DefInstance._lblPhyState_2.Text, false) == 0)
				{
					_cmbPS_2.SelectedIndex = num2;
					break;
				}
				num2++;
			}
			_txtPSOtherInfo_2.Text = frmMain.DefInstance._lblPhyStateOtherInfo_2.Text;
		}
	}

	private void UpdateFrmMain()
	{
		frmMain.DefInstance._lblPhyState_0.Text = _cmbPS_0.Text;
		frmMain.DefInstance._lblPhyStateOtherInfo_0.Text = _txtPSOtherInfo_0.Text;
		frmMain.DefInstance._lblPhyState_1.Text = _cmbPS_1.Text;
		frmMain.DefInstance._lblPhyStateOtherInfo_1.Text = _txtPSOtherInfo_1.Text;
		frmMain.DefInstance._lblPhyState_2.Text = _cmbPS_2.Text;
		frmMain.DefInstance._lblPhyStateOtherInfo_2.Text = _txtPSOtherInfo_2.Text;
		Globals_Renamed.arPSInto1[Globals_Renamed.intOpIndex] = _cmbPS_0.Text;
		Globals_Renamed.arPSInto2[Globals_Renamed.intOpIndex] = _txtPSOtherInfo_0.Text;
		Globals_Renamed.arPSOut1[Globals_Renamed.intOpIndex] = _cmbPS_1.Text;
		Globals_Renamed.arPSOut2[Globals_Renamed.intOpIndex] = _txtPSOtherInfo_1.Text;
		Globals_Renamed.arPSIn1[Globals_Renamed.intOpIndex] = _cmbPS_2.Text;
		Globals_Renamed.arPSIn2[Globals_Renamed.intOpIndex] = _txtPSOtherInfo_2.Text;
	}
}
