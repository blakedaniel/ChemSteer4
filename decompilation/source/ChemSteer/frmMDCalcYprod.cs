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

internal class frmMDCalcYprod : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("txtUserDefined")]
	private TextBox _txtUserDefined;

	[AccessedThroughProperty("_optYprod_8")]
	private RadioButton __optYprod_8;

	[AccessedThroughProperty("_optYprod_7")]
	private RadioButton __optYprod_7;

	[AccessedThroughProperty("_optYprod_6")]
	private RadioButton __optYprod_6;

	[AccessedThroughProperty("_optYprod_5")]
	private RadioButton __optYprod_5;

	[AccessedThroughProperty("_optYprod_4")]
	private RadioButton __optYprod_4;

	[AccessedThroughProperty("_optYprod_3")]
	private RadioButton __optYprod_3;

	[AccessedThroughProperty("_optYprod_2")]
	private RadioButton __optYprod_2;

	[AccessedThroughProperty("_optYprod_1")]
	private RadioButton __optYprod_1;

	[AccessedThroughProperty("_optYprod_0")]
	private RadioButton __optYprod_0;

	[AccessedThroughProperty("_Label1_7")]
	private Label __Label1_7;

	[AccessedThroughProperty("_Label1_6")]
	private Label __Label1_6;

	[AccessedThroughProperty("_Label1_5")]
	private Label __Label1_5;

	[AccessedThroughProperty("_Label1_4")]
	private Label __Label1_4;

	[AccessedThroughProperty("_Label1_3")]
	private Label __Label1_3;

	[AccessedThroughProperty("_Label1_2")]
	private Label __Label1_2;

	[AccessedThroughProperty("_Label1_1")]
	private Label __Label1_1;

	[AccessedThroughProperty("_Label1_0")]
	private Label __Label1_0;

	[AccessedThroughProperty("Frame1")]
	private Panel _Frame1;

	[AccessedThroughProperty("cmdRestore")]
	private Button _cmdRestore;

	[AccessedThroughProperty("cmdOk")]
	private Button _cmdOk;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("lblInstructions")]
	private Label _lblInstructions;

	[AccessedThroughProperty("Label1")]
	private LabelArray _Label1;

	[AccessedThroughProperty("optYprod")]
	private RadioButtonArray _optYprod;

	private static frmMDCalcYprod m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	public short iOptSelected;

	public virtual TextBox txtUserDefined
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtUserDefined;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtUserDefined_Leave;
			if (_txtUserDefined != null)
			{
				((Control)_txtUserDefined).Leave -= eventHandler;
			}
			_txtUserDefined = value;
			if (_txtUserDefined != null)
			{
				((Control)_txtUserDefined).Leave += eventHandler;
			}
		}
	}

	public virtual RadioButton _optYprod_8
	{
		[DebuggerNonUserCode]
		get
		{
			return __optYprod_8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _optYprod_8_CheckedChanged;
			if (__optYprod_8 != null)
			{
				__optYprod_8.CheckedChanged -= eventHandler;
			}
			__optYprod_8 = value;
			if (__optYprod_8 != null)
			{
				__optYprod_8.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual RadioButton _optYprod_7
	{
		[DebuggerNonUserCode]
		get
		{
			return __optYprod_7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _optYprod_7_CheckedChanged;
			if (__optYprod_7 != null)
			{
				__optYprod_7.CheckedChanged -= eventHandler;
			}
			__optYprod_7 = value;
			if (__optYprod_7 != null)
			{
				__optYprod_7.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual RadioButton _optYprod_6
	{
		[DebuggerNonUserCode]
		get
		{
			return __optYprod_6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _optYprod_6_CheckedChanged;
			if (__optYprod_6 != null)
			{
				__optYprod_6.CheckedChanged -= eventHandler;
			}
			__optYprod_6 = value;
			if (__optYprod_6 != null)
			{
				__optYprod_6.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual RadioButton _optYprod_5
	{
		[DebuggerNonUserCode]
		get
		{
			return __optYprod_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _optYprod_5_CheckedChanged;
			if (__optYprod_5 != null)
			{
				__optYprod_5.CheckedChanged -= eventHandler;
			}
			__optYprod_5 = value;
			if (__optYprod_5 != null)
			{
				__optYprod_5.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual RadioButton _optYprod_4
	{
		[DebuggerNonUserCode]
		get
		{
			return __optYprod_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _optYprod_4_CheckedChanged;
			if (__optYprod_4 != null)
			{
				__optYprod_4.CheckedChanged -= eventHandler;
			}
			__optYprod_4 = value;
			if (__optYprod_4 != null)
			{
				__optYprod_4.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual RadioButton _optYprod_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __optYprod_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _optYprod_3_CheckedChanged;
			if (__optYprod_3 != null)
			{
				__optYprod_3.CheckedChanged -= eventHandler;
			}
			__optYprod_3 = value;
			if (__optYprod_3 != null)
			{
				__optYprod_3.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual RadioButton _optYprod_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __optYprod_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _optYprod_2_CheckedChanged;
			if (__optYprod_2 != null)
			{
				__optYprod_2.CheckedChanged -= eventHandler;
			}
			__optYprod_2 = value;
			if (__optYprod_2 != null)
			{
				__optYprod_2.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual RadioButton _optYprod_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __optYprod_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _optYprod_1_CheckedChanged;
			if (__optYprod_1 != null)
			{
				__optYprod_1.CheckedChanged -= eventHandler;
			}
			__optYprod_1 = value;
			if (__optYprod_1 != null)
			{
				__optYprod_1.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual RadioButton _optYprod_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __optYprod_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _optYprod_0_CheckedChanged;
			if (__optYprod_0 != null)
			{
				__optYprod_0.CheckedChanged -= eventHandler;
			}
			__optYprod_0 = value;
			if (__optYprod_0 != null)
			{
				__optYprod_0.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual Label _Label1_7
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_7 = value;
		}
	}

	public virtual Label _Label1_6
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_6 = value;
		}
	}

	public virtual Label _Label1_5
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_5 = value;
		}
	}

	public virtual Label _Label1_4
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_4 = value;
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

	public virtual Label _Label1_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_1 = value;
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

	public virtual Panel Frame1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Frame1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Frame1 = value;
		}
	}

	public virtual Button cmdRestore
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdRestore;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdRestore_Click;
			if (_cmdRestore != null)
			{
				((Control)_cmdRestore).Click -= eventHandler;
			}
			_cmdRestore = value;
			if (_cmdRestore != null)
			{
				((Control)_cmdRestore).Click += eventHandler;
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

	public virtual RadioButtonArray optYprod
	{
		[DebuggerNonUserCode]
		get
		{
			return _optYprod;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = optYprod_CheckedChanged;
			if (_optYprod != null)
			{
				_optYprod.CheckedChanged -= eventHandler;
			}
			_optYprod = value;
			if (_optYprod != null)
			{
				_optYprod.CheckedChanged += eventHandler;
			}
		}
	}

	public static frmMDCalcYprod DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmMDCalcYprod();
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

	public frmMDCalcYprod()
	{
		((Form)this).Load += frmMDCalcYprod_Load;
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
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected O, but got Unknown
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Expected O, but got Unknown
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Expected O, but got Unknown
		//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Expected O, but got Unknown
		//IL_05d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05df: Expected O, but got Unknown
		//IL_06c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cf: Expected O, but got Unknown
		//IL_07b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bf: Expected O, but got Unknown
		//IL_08a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08af: Expected O, but got Unknown
		//IL_0992: Unknown result type (might be due to invalid IL or missing references)
		//IL_099c: Expected O, but got Unknown
		//IL_0a7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a89: Expected O, but got Unknown
		//IL_0b6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b76: Expected O, but got Unknown
		//IL_0c6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c74: Expected O, but got Unknown
		//IL_0d57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d61: Expected O, but got Unknown
		//IL_0e31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3b: Expected O, but got Unknown
		//IL_0f0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f15: Expected O, but got Unknown
		//IL_0fe5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fef: Expected O, but got Unknown
		//IL_10bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c9: Expected O, but got Unknown
		//IL_1196: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a0: Expected O, but got Unknown
		//IL_126d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1277: Expected O, but got Unknown
		//IL_1344: Unknown result type (might be due to invalid IL or missing references)
		//IL_134e: Expected O, but got Unknown
		//IL_141b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1425: Expected O, but got Unknown
		//IL_14ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_14f9: Expected O, but got Unknown
		//IL_15cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_15d7: Expected O, but got Unknown
		//IL_16a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ab: Expected O, but got Unknown
		//IL_17f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1802: Expected O, but got Unknown
		//IL_1817: Unknown result type (might be due to invalid IL or missing references)
		//IL_1821: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMDCalcYprod));
		ToolTip1 = new ToolTip(components);
		Frame1 = new Panel();
		txtUserDefined = new TextBox();
		_optYprod_8 = new RadioButton();
		_optYprod_7 = new RadioButton();
		_optYprod_6 = new RadioButton();
		_optYprod_5 = new RadioButton();
		_optYprod_4 = new RadioButton();
		_optYprod_3 = new RadioButton();
		_optYprod_2 = new RadioButton();
		_optYprod_1 = new RadioButton();
		_optYprod_0 = new RadioButton();
		_Label1_7 = new Label();
		_Label1_6 = new Label();
		_Label1_5 = new Label();
		_Label1_4 = new Label();
		_Label1_3 = new Label();
		_Label1_2 = new Label();
		_Label1_1 = new Label();
		_Label1_0 = new Label();
		cmdRestore = new Button();
		cmdOk = new Button();
		cmdCancel = new Button();
		lblInstructions = new Label();
		Label1 = new LabelArray(components);
		optYprod = new RadioButtonArray(components);
		((Control)Frame1).SuspendLayout();
		((ISupportInitialize)Label1).BeginInit();
		((ISupportInitialize)optYprod).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Frame1).BackColor = SystemColors.Control;
		((Control)Frame1).Controls.Add((Control)(object)txtUserDefined);
		((Control)Frame1).Controls.Add((Control)(object)_optYprod_8);
		((Control)Frame1).Controls.Add((Control)(object)_optYprod_7);
		((Control)Frame1).Controls.Add((Control)(object)_optYprod_6);
		((Control)Frame1).Controls.Add((Control)(object)_optYprod_5);
		((Control)Frame1).Controls.Add((Control)(object)_optYprod_4);
		((Control)Frame1).Controls.Add((Control)(object)_optYprod_3);
		((Control)Frame1).Controls.Add((Control)(object)_optYprod_2);
		((Control)Frame1).Controls.Add((Control)(object)_optYprod_1);
		((Control)Frame1).Controls.Add((Control)(object)_optYprod_0);
		((Control)Frame1).Controls.Add((Control)(object)_Label1_7);
		((Control)Frame1).Controls.Add((Control)(object)_Label1_6);
		((Control)Frame1).Controls.Add((Control)(object)_Label1_5);
		((Control)Frame1).Controls.Add((Control)(object)_Label1_4);
		((Control)Frame1).Controls.Add((Control)(object)_Label1_3);
		((Control)Frame1).Controls.Add((Control)(object)_Label1_2);
		((Control)Frame1).Controls.Add((Control)(object)_Label1_1);
		((Control)Frame1).Controls.Add((Control)(object)_Label1_0);
		((Control)Frame1).Cursor = Cursors.Default;
		((Control)Frame1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Frame1).ForeColor = SystemColors.ControlText;
		Panel frame = Frame1;
		Point location = new Point(8, 32);
		((Control)frame).Location = location;
		((Control)Frame1).Name = "Frame1";
		((Control)Frame1).RightToLeft = (RightToLeft)0;
		Panel frame2 = Frame1;
		Size size = new Size(337, 241);
		((Control)frame2).Size = size;
		((Control)Frame1).TabIndex = 14;
		txtUserDefined.AcceptsReturn = true;
		((TextBoxBase)txtUserDefined).BackColor = SystemColors.Window;
		((Control)txtUserDefined).Cursor = Cursors.IBeam;
		((Control)txtUserDefined).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtUserDefined).ForeColor = SystemColors.WindowText;
		TextBox obj = txtUserDefined;
		location = new Point(200, 16);
		((Control)obj).Location = location;
		((TextBoxBase)txtUserDefined).MaxLength = 0;
		((Control)txtUserDefined).Name = "txtUserDefined";
		((Control)txtUserDefined).RightToLeft = (RightToLeft)0;
		TextBox obj2 = txtUserDefined;
		size = new Size(41, 20);
		((Control)obj2).Size = size;
		((Control)txtUserDefined).TabIndex = 1;
		((ButtonBase)_optYprod_8).BackColor = SystemColors.Control;
		((Control)_optYprod_8).Cursor = Cursors.Default;
		((Control)_optYprod_8).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optYprod_8).ForeColor = SystemColors.ControlText;
		optYprod.SetIndex(_optYprod_8, (short)8);
		RadioButton optYprod_ = _optYprod_8;
		location = new Point(40, 208);
		((Control)optYprod_).Location = location;
		((Control)_optYprod_8).Name = "_optYprod_8";
		((Control)_optYprod_8).RightToLeft = (RightToLeft)0;
		RadioButton optYprod_2 = _optYprod_8;
		size = new Size(121, 17);
		((Control)optYprod_2).Size = size;
		((Control)_optYprod_8).TabIndex = 9;
		_optYprod_8.TabStop = true;
		((ButtonBase)_optYprod_8).Text = "Anti-oxidant";
		((ButtonBase)_optYprod_8).UseVisualStyleBackColor = false;
		((ButtonBase)_optYprod_7).BackColor = SystemColors.Control;
		((Control)_optYprod_7).Cursor = Cursors.Default;
		((Control)_optYprod_7).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optYprod_7).ForeColor = SystemColors.ControlText;
		optYprod.SetIndex(_optYprod_7, (short)7);
		RadioButton optYprod_3 = _optYprod_7;
		location = new Point(40, 184);
		((Control)optYprod_3).Location = location;
		((Control)_optYprod_7).Name = "_optYprod_7";
		((Control)_optYprod_7).RightToLeft = (RightToLeft)0;
		RadioButton optYprod_4 = _optYprod_7;
		size = new Size(121, 17);
		((Control)optYprod_4).Size = size;
		((Control)_optYprod_7).TabIndex = 8;
		_optYprod_7.TabStop = true;
		((ButtonBase)_optYprod_7).Text = "Preservative";
		((ButtonBase)_optYprod_7).UseVisualStyleBackColor = false;
		((ButtonBase)_optYprod_6).BackColor = SystemColors.Control;
		((Control)_optYprod_6).Cursor = Cursors.Default;
		((Control)_optYprod_6).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optYprod_6).ForeColor = SystemColors.ControlText;
		optYprod.SetIndex(_optYprod_6, (short)6);
		RadioButton optYprod_5 = _optYprod_6;
		location = new Point(40, 160);
		((Control)optYprod_5).Location = location;
		((Control)_optYprod_6).Name = "_optYprod_6";
		((Control)_optYprod_6).RightToLeft = (RightToLeft)0;
		RadioButton optYprod_6 = _optYprod_6;
		size = new Size(121, 17);
		((Control)optYprod_6).Size = size;
		((Control)_optYprod_6).TabIndex = 7;
		_optYprod_6.TabStop = true;
		((ButtonBase)_optYprod_6).Text = "Viscosity Control";
		((ButtonBase)_optYprod_6).UseVisualStyleBackColor = false;
		((ButtonBase)_optYprod_5).BackColor = SystemColors.Control;
		((Control)_optYprod_5).Cursor = Cursors.Default;
		((Control)_optYprod_5).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optYprod_5).ForeColor = SystemColors.ControlText;
		optYprod.SetIndex(_optYprod_5, (short)5);
		RadioButton optYprod_7 = _optYprod_5;
		location = new Point(40, 136);
		((Control)optYprod_7).Location = location;
		((Control)_optYprod_5).Name = "_optYprod_5";
		((Control)_optYprod_5).RightToLeft = (RightToLeft)0;
		RadioButton optYprod_8 = _optYprod_5;
		size = new Size(121, 17);
		((Control)optYprod_8).Size = size;
		((Control)_optYprod_5).TabIndex = 6;
		_optYprod_5.TabStop = true;
		((ButtonBase)_optYprod_5).Text = "Stabalizer";
		((ButtonBase)_optYprod_5).UseVisualStyleBackColor = false;
		((ButtonBase)_optYprod_4).BackColor = SystemColors.Control;
		((Control)_optYprod_4).Cursor = Cursors.Default;
		((Control)_optYprod_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optYprod_4).ForeColor = SystemColors.ControlText;
		optYprod.SetIndex(_optYprod_4, (short)4);
		RadioButton optYprod_9 = _optYprod_4;
		location = new Point(40, 112);
		((Control)optYprod_9).Location = location;
		((Control)_optYprod_4).Name = "_optYprod_4";
		((Control)_optYprod_4).RightToLeft = (RightToLeft)0;
		RadioButton optYprod_10 = _optYprod_4;
		size = new Size(121, 17);
		((Control)optYprod_10).Size = size;
		((Control)_optYprod_4).TabIndex = 5;
		_optYprod_4.TabStop = true;
		((ButtonBase)_optYprod_4).Text = "Plasticizer";
		((ButtonBase)_optYprod_4).UseVisualStyleBackColor = false;
		((ButtonBase)_optYprod_3).BackColor = SystemColors.Control;
		((Control)_optYprod_3).Cursor = Cursors.Default;
		((Control)_optYprod_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optYprod_3).ForeColor = SystemColors.ControlText;
		optYprod.SetIndex(_optYprod_3, (short)3);
		RadioButton optYprod_11 = _optYprod_3;
		location = new Point(40, 88);
		((Control)optYprod_11).Location = location;
		((Control)_optYprod_3).Name = "_optYprod_3";
		((Control)_optYprod_3).RightToLeft = (RightToLeft)0;
		RadioButton optYprod_12 = _optYprod_3;
		size = new Size(121, 17);
		((Control)optYprod_12).Size = size;
		((Control)_optYprod_3).TabIndex = 4;
		_optYprod_3.TabStop = true;
		((ButtonBase)_optYprod_3).Text = "Filler";
		((ButtonBase)_optYprod_3).UseVisualStyleBackColor = false;
		((ButtonBase)_optYprod_2).BackColor = SystemColors.Control;
		((Control)_optYprod_2).Cursor = Cursors.Default;
		((Control)_optYprod_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optYprod_2).ForeColor = SystemColors.ControlText;
		optYprod.SetIndex(_optYprod_2, (short)2);
		RadioButton optYprod_13 = _optYprod_2;
		location = new Point(40, 64);
		((Control)optYprod_13).Location = location;
		((Control)_optYprod_2).Name = "_optYprod_2";
		((Control)_optYprod_2).RightToLeft = (RightToLeft)0;
		RadioButton optYprod_14 = _optYprod_2;
		size = new Size(121, 17);
		((Control)optYprod_14).Size = size;
		((Control)_optYprod_2).TabIndex = 3;
		_optYprod_2.TabStop = true;
		((ButtonBase)_optYprod_2).Text = "Trackifier";
		((ButtonBase)_optYprod_2).UseVisualStyleBackColor = false;
		((ButtonBase)_optYprod_1).BackColor = SystemColors.Control;
		((Control)_optYprod_1).Cursor = Cursors.Default;
		((Control)_optYprod_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optYprod_1).ForeColor = SystemColors.ControlText;
		optYprod.SetIndex(_optYprod_1, (short)1);
		RadioButton optYprod_15 = _optYprod_1;
		location = new Point(40, 40);
		((Control)optYprod_15).Location = location;
		((Control)_optYprod_1).Name = "_optYprod_1";
		((Control)_optYprod_1).RightToLeft = (RightToLeft)0;
		RadioButton optYprod_16 = _optYprod_1;
		size = new Size(121, 17);
		((Control)optYprod_16).Size = size;
		((Control)_optYprod_1).TabIndex = 2;
		_optYprod_1.TabStop = true;
		((Control)_optYprod_1).Tag = ".33";
		((ButtonBase)_optYprod_1).Text = "Elastomer";
		((ButtonBase)_optYprod_1).UseVisualStyleBackColor = false;
		((ButtonBase)_optYprod_0).BackColor = SystemColors.Control;
		((Control)_optYprod_0).Cursor = Cursors.Default;
		((Control)_optYprod_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optYprod_0).ForeColor = SystemColors.ControlText;
		optYprod.SetIndex(_optYprod_0, (short)0);
		RadioButton optYprod_17 = _optYprod_0;
		location = new Point(40, 16);
		((Control)optYprod_17).Location = location;
		((Control)_optYprod_0).Name = "_optYprod_0";
		((Control)_optYprod_0).RightToLeft = (RightToLeft)0;
		RadioButton optYprod_18 = _optYprod_0;
		size = new Size(121, 17);
		((Control)optYprod_18).Size = size;
		((Control)_optYprod_0).TabIndex = 0;
		_optYprod_0.TabStop = true;
		((ButtonBase)_optYprod_0).Text = "User defined";
		((ButtonBase)_optYprod_0).UseVisualStyleBackColor = false;
		((Control)_Label1_7).BackColor = SystemColors.Control;
		((Control)_Label1_7).Cursor = Cursors.Default;
		((Control)_Label1_7).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_7).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_7, (short)7);
		Label label1_ = _Label1_7;
		location = new Point(208, 208);
		((Control)label1_).Location = location;
		((Control)_Label1_7).Name = "_Label1_7";
		((Control)_Label1_7).RightToLeft = (RightToLeft)0;
		Label label1_2 = _Label1_7;
		size = new Size(25, 17);
		((Control)label1_2).Size = size;
		((Control)_Label1_7).TabIndex = 22;
		_Label1_7.Text = "0.01";
		((Control)_Label1_6).BackColor = SystemColors.Control;
		((Control)_Label1_6).Cursor = Cursors.Default;
		((Control)_Label1_6).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_6).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_6, (short)6);
		Label label1_3 = _Label1_6;
		location = new Point(208, 184);
		((Control)label1_3).Location = location;
		((Control)_Label1_6).Name = "_Label1_6";
		((Control)_Label1_6).RightToLeft = (RightToLeft)0;
		Label label1_4 = _Label1_6;
		size = new Size(33, 17);
		((Control)label1_4).Size = size;
		((Control)_Label1_6).TabIndex = 21;
		_Label1_6.Text = "0.001";
		((Control)_Label1_5).BackColor = SystemColors.Control;
		((Control)_Label1_5).Cursor = Cursors.Default;
		((Control)_Label1_5).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_5).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_5, (short)5);
		Label label1_5 = _Label1_5;
		location = new Point(208, 160);
		((Control)label1_5).Location = location;
		((Control)_Label1_5).Name = "_Label1_5";
		((Control)_Label1_5).RightToLeft = (RightToLeft)0;
		Label label1_6 = _Label1_5;
		size = new Size(33, 17);
		((Control)label1_6).Size = size;
		((Control)_Label1_5).TabIndex = 20;
		_Label1_5.Text = "0.005";
		((Control)_Label1_4).BackColor = SystemColors.Control;
		((Control)_Label1_4).Cursor = Cursors.Default;
		((Control)_Label1_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_4).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_4, (short)4);
		Label label1_7 = _Label1_4;
		location = new Point(208, 136);
		((Control)label1_7).Location = location;
		((Control)_Label1_4).Name = "_Label1_4";
		((Control)_Label1_4).RightToLeft = (RightToLeft)0;
		Label label1_8 = _Label1_4;
		size = new Size(25, 17);
		((Control)label1_8).Size = size;
		((Control)_Label1_4).TabIndex = 19;
		_Label1_4.Text = "0.01";
		((Control)_Label1_3).BackColor = SystemColors.Control;
		((Control)_Label1_3).Cursor = Cursors.Default;
		((Control)_Label1_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_3).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_3, (short)3);
		Label label1_9 = _Label1_3;
		location = new Point(208, 112);
		((Control)label1_9).Location = location;
		((Control)_Label1_3).Name = "_Label1_3";
		((Control)_Label1_3).RightToLeft = (RightToLeft)0;
		Label label1_10 = _Label1_3;
		size = new Size(25, 17);
		((Control)label1_10).Size = size;
		((Control)_Label1_3).TabIndex = 18;
		_Label1_3.Text = "0.01";
		((Control)_Label1_2).BackColor = SystemColors.Control;
		((Control)_Label1_2).Cursor = Cursors.Default;
		((Control)_Label1_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_2).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_2, (short)2);
		Label label1_11 = _Label1_2;
		location = new Point(208, 88);
		((Control)label1_11).Location = location;
		((Control)_Label1_2).Name = "_Label1_2";
		((Control)_Label1_2).RightToLeft = (RightToLeft)0;
		Label label1_12 = _Label1_2;
		size = new Size(25, 17);
		((Control)label1_12).Size = size;
		((Control)_Label1_2).TabIndex = 17;
		_Label1_2.Text = "0.33";
		((Control)_Label1_1).BackColor = SystemColors.Control;
		((Control)_Label1_1).Cursor = Cursors.Default;
		((Control)_Label1_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_1).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_1, (short)1);
		Label label1_13 = _Label1_1;
		location = new Point(208, 64);
		((Control)label1_13).Location = location;
		((Control)_Label1_1).Name = "_Label1_1";
		((Control)_Label1_1).RightToLeft = (RightToLeft)0;
		Label label1_14 = _Label1_1;
		size = new Size(25, 17);
		((Control)label1_14).Size = size;
		((Control)_Label1_1).TabIndex = 16;
		_Label1_1.Text = "0.33";
		((Control)_Label1_0).BackColor = SystemColors.Control;
		((Control)_Label1_0).Cursor = Cursors.Default;
		((Control)_Label1_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_0).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_0, (short)0);
		Label label1_15 = _Label1_0;
		location = new Point(208, 40);
		((Control)label1_15).Location = location;
		((Control)_Label1_0).Name = "_Label1_0";
		((Control)_Label1_0).RightToLeft = (RightToLeft)0;
		Label label1_16 = _Label1_0;
		size = new Size(25, 17);
		((Control)label1_16).Size = size;
		((Control)_Label1_0).TabIndex = 15;
		_Label1_0.Text = "0.33";
		((ButtonBase)cmdRestore).BackColor = SystemColors.Control;
		((Control)cmdRestore).Cursor = Cursors.Default;
		((Control)cmdRestore).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdRestore).ForeColor = SystemColors.ControlText;
		Button obj3 = cmdRestore;
		location = new Point(240, 288);
		((Control)obj3).Location = location;
		((Control)cmdRestore).Name = "cmdRestore";
		((Control)cmdRestore).RightToLeft = (RightToLeft)0;
		Button obj4 = cmdRestore;
		size = new Size(97, 25);
		((Control)obj4).Size = size;
		((Control)cmdRestore).TabIndex = 12;
		((ButtonBase)cmdRestore).Text = "&Restore Defaults";
		((ButtonBase)cmdRestore).UseVisualStyleBackColor = false;
		((ButtonBase)cmdOk).BackColor = SystemColors.Control;
		((Control)cmdOk).Cursor = Cursors.Default;
		((Control)cmdOk).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdOk).ForeColor = SystemColors.ControlText;
		Button obj5 = cmdOk;
		location = new Point(16, 288);
		((Control)obj5).Location = location;
		((Control)cmdOk).Name = "cmdOk";
		((Control)cmdOk).RightToLeft = (RightToLeft)0;
		Button obj6 = cmdOk;
		size = new Size(97, 25);
		((Control)obj6).Size = size;
		((Control)cmdOk).TabIndex = 10;
		((ButtonBase)cmdOk).Text = "OK";
		((ButtonBase)cmdOk).UseVisualStyleBackColor = false;
		((ButtonBase)cmdCancel).BackColor = SystemColors.Control;
		((Control)cmdCancel).Cursor = Cursors.Default;
		cmdCancel.DialogResult = (DialogResult)2;
		((Control)cmdCancel).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCancel).ForeColor = SystemColors.ControlText;
		Button obj7 = cmdCancel;
		location = new Point(128, 288);
		((Control)obj7).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		((Control)cmdCancel).RightToLeft = (RightToLeft)0;
		Button obj8 = cmdCancel;
		size = new Size(97, 25);
		((Control)obj8).Size = size;
		((Control)cmdCancel).TabIndex = 11;
		((ButtonBase)cmdCancel).Text = "Cancel";
		((ButtonBase)cmdCancel).UseVisualStyleBackColor = false;
		((Control)lblInstructions).BackColor = SystemColors.Control;
		((Control)lblInstructions).Cursor = Cursors.Default;
		((Control)lblInstructions).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblInstructions).ForeColor = SystemColors.ControlText;
		Label obj9 = lblInstructions;
		location = new Point(8, 16);
		((Control)obj9).Location = location;
		((Control)lblInstructions).Name = "lblInstructions";
		((Control)lblInstructions).RightToLeft = (RightToLeft)0;
		Label obj10 = lblInstructions;
		size = new Size(321, 17);
		((Control)obj10).Size = size;
		((Control)lblInstructions).TabIndex = 13;
		lblInstructions.Text = "Select a new default for Yprod and press the OK button.";
		((Form)this).AcceptButton = (IButtonControl)(object)cmdOk;
		size = new Size(5, 13);
		((Form)this).AutoScaleBaseSize = size;
		((Form)this).BackColor = SystemColors.Control;
		((Form)this).CancelButton = (IButtonControl)(object)cmdCancel;
		size = new Size(353, 325);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Frame1);
		((Control)this).Controls.Add((Control)(object)cmdRestore);
		((Control)this).Controls.Add((Control)(object)cmdOk);
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)lblInstructions);
		((Control)this).Cursor = Cursors.Default;
		((Control)this).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		location = new Point(250, 150);
		((Form)this).Location = location;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmMDCalcYprod";
		((Control)this).RightToLeft = (RightToLeft)0;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Specify Default for Yprod";
		((Control)Frame1).ResumeLayout(false);
		((Control)Frame1).PerformLayout();
		((ISupportInitialize)Label1).EndInit();
		((ISupportInitialize)optYprod).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void cmdOk_Click(object eventSender, EventArgs eventArgs)
	{
		if (_optYprod_0.Checked)
		{
			((Control)frmMDUpdOpIP.DefInstance._fraTab2_0).Controls["_txtKnowns_3"].Text = txtUserDefined.Text;
		}
		else
		{
			((Control)frmMDUpdOpIP.DefInstance._fraTab2_0).Controls["_txtKnowns_3"].Text = Label1[checked((short)(iOptSelected - 1))].Text;
		}
		((Control)this).Tag = "";
		((Control)this).Hide();
	}

	private void cmdRestore_Click(object eventSender, EventArgs eventArgs)
	{
		txtUserDefined.Text = Conversions.ToString(0.33);
		_optYprod_0.Checked = true;
	}

	private void cmdCancel_Click(object eventSender, EventArgs eventArgs)
	{
		((Control)this).Tag = "Cancel";
		((Control)this).Hide();
	}

	private void frmMDCalcYprod_Load(object eventSender, EventArgs eventArgs)
	{
	}

	public bool SetUp(ref short pOption)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
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
					if (pOption == 0)
					{
						txtUserDefined.Text = ((Control)frmMDUpdOpIP.DefInstance._fraTab2_0).Controls["_txtKnowns_3"].Text;
					}
					((RadioButton)((Control)Frame1).Controls["_optYprod_" + Conversions.ToString((int)pOption)]).Checked = true;
					flag = true;
					goto end_IL_0001;
				case 209:
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
				try0001_dispatch = 209;
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

	private void chkOptYprod(short index)
	{
		iOptSelected = index;
	}

	private void optYprod_CheckedChanged(object eventSender, EventArgs eventArgs)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		if (Conversions.ToBoolean(NewLateBinding.LateGet(eventSender, (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			short index = optYprod.GetIndex((RadioButton)eventSender);
			iOptSelected = index;
		}
	}

	private void txtUserDefined_Leave(object eventSender, EventArgs eventArgs)
	{
		if (Strings.Len(txtUserDefined.Text) > 0)
		{
			short pID = 10;
			TextBox val = txtUserDefined;
			object pValue = val.Text;
			short pModType = 0;
			bool num = ChemStrX.ValidateParmInput(ref pID, ref pValue, ref pModType);
			val.Text = Conversions.ToString(pValue);
			if (!num)
			{
				((TextBoxBase)txtUserDefined).SelectionStart = 0;
				((TextBoxBase)txtUserDefined).SelectionLength = Strings.Len(txtUserDefined.Text);
				((Control)txtUserDefined).Focus();
			}
		}
	}

	private void _optYprod_0_CheckedChanged(object sender, EventArgs e)
	{
		if (_optYprod_0.Checked)
		{
			chkOptYprod(0);
		}
	}

	private void _optYprod_1_CheckedChanged(object sender, EventArgs e)
	{
		if (_optYprod_1.Checked)
		{
			chkOptYprod(1);
		}
	}

	private void _optYprod_2_CheckedChanged(object sender, EventArgs e)
	{
		if (_optYprod_2.Checked)
		{
			chkOptYprod(2);
		}
	}

	private void _optYprod_3_CheckedChanged(object sender, EventArgs e)
	{
		if (_optYprod_3.Checked)
		{
			chkOptYprod(3);
		}
	}

	private void _optYprod_4_CheckedChanged(object sender, EventArgs e)
	{
		if (_optYprod_4.Checked)
		{
			chkOptYprod(4);
		}
	}

	private void _optYprod_5_CheckedChanged(object sender, EventArgs e)
	{
		if (_optYprod_5.Checked)
		{
			chkOptYprod(5);
		}
	}

	private void _optYprod_6_CheckedChanged(object sender, EventArgs e)
	{
		if (_optYprod_6.Checked)
		{
			chkOptYprod(6);
		}
	}

	private void _optYprod_7_CheckedChanged(object sender, EventArgs e)
	{
		if (_optYprod_7.Checked)
		{
			chkOptYprod(7);
		}
	}

	private void _optYprod_8_CheckedChanged(object sender, EventArgs e)
	{
		if (_optYprod_8.Checked)
		{
			chkOptYprod(8);
		}
	}
}
