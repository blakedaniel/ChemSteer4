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

internal class frmMDCalcNS : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("_optNS_1")]
	private RadioButton __optNS_1;

	[AccessedThroughProperty("txtUserInput")]
	private TextBox _txtUserInput;

	[AccessedThroughProperty("_Label1_3")]
	private Label __Label1_3;

	[AccessedThroughProperty("_Frame2_1")]
	private GroupBox __Frame2_1;

	[AccessedThroughProperty("cmdCalc")]
	private Button _cmdCalc;

	[AccessedThroughProperty("txtAMOprod")]
	private TextBox _txtAMOprod;

	[AccessedThroughProperty("_optNS_0")]
	private RadioButton __optNS_0;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("lblNS")]
	private Label _lblNS;

	[AccessedThroughProperty("_Label1_4")]
	private Label __Label1_4;

	[AccessedThroughProperty("_Label1_2")]
	private Label __Label1_2;

	[AccessedThroughProperty("lblYprod")]
	private Label _lblYprod;

	[AccessedThroughProperty("_Label1_1")]
	private Label __Label1_1;

	[AccessedThroughProperty("lblPVop")]
	private Label _lblPVop;

	[AccessedThroughProperty("_Label1_0")]
	private Label __Label1_0;

	[AccessedThroughProperty("_Frame2_0")]
	private GroupBox __Frame2_0;

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

	[AccessedThroughProperty("Frame2")]
	private GroupBoxArray _Frame2;

	[AccessedThroughProperty("Label1")]
	private LabelArray _Label1;

	[AccessedThroughProperty("optNS")]
	private RadioButtonArray _optNS;

	private static frmMDCalcNS m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	public short iOptSelected;

	public virtual RadioButton _optNS_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __optNS_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _optNS_1_CheckedChanged;
			if (__optNS_1 != null)
			{
				__optNS_1.CheckedChanged -= eventHandler;
			}
			__optNS_1 = value;
			if (__optNS_1 != null)
			{
				__optNS_1.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual TextBox txtUserInput
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtUserInput;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtUserInput = value;
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

	public virtual GroupBox _Frame2_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __Frame2_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Frame2_1 = value;
		}
	}

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

	public virtual TextBox txtAMOprod
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtAMOprod;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtAMOprod = value;
		}
	}

	public virtual RadioButton _optNS_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __optNS_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _optNS_0_CheckedChanged;
			if (__optNS_0 != null)
			{
				__optNS_0.CheckedChanged -= eventHandler;
			}
			__optNS_0 = value;
			if (__optNS_0 != null)
			{
				__optNS_0.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual Label Label2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label2 = value;
		}
	}

	public virtual Label lblNS
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNS = value;
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

	public virtual Label lblYprod
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblYprod;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblYprod = value;
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

	public virtual Label lblPVop
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPVop;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPVop = value;
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

	public virtual GroupBox _Frame2_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __Frame2_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Frame2_0 = value;
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

	public virtual GroupBoxArray Frame2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Frame2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Frame2 = value;
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

	public virtual RadioButtonArray optNS
	{
		[DebuggerNonUserCode]
		get
		{
			return _optNS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = optNS_CheckedChanged;
			if (_optNS != null)
			{
				_optNS.CheckedChanged -= eventHandler;
			}
			_optNS = value;
			if (_optNS != null)
			{
				_optNS.CheckedChanged += eventHandler;
			}
		}
	}

	public static frmMDCalcNS DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmMDCalcNS();
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

	public frmMDCalcNS()
	{
		((Form)this).Load += frmMDCalcNS_Load;
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
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected O, but got Unknown
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Expected O, but got Unknown
		//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Expected O, but got Unknown
		//IL_0588: Unknown result type (might be due to invalid IL or missing references)
		//IL_0592: Expected O, but got Unknown
		//IL_075b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0765: Expected O, but got Unknown
		//IL_0841: Unknown result type (might be due to invalid IL or missing references)
		//IL_084b: Expected O, but got Unknown
		//IL_0924: Unknown result type (might be due to invalid IL or missing references)
		//IL_092e: Expected O, but got Unknown
		//IL_09e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ed: Expected O, but got Unknown
		//IL_0abf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac9: Expected O, but got Unknown
		//IL_0b92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9c: Expected O, but got Unknown
		//IL_0c44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4e: Expected O, but got Unknown
		//IL_0d28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d32: Expected O, but got Unknown
		//IL_0e19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e23: Expected O, but got Unknown
		//IL_0ecb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed5: Expected O, but got Unknown
		//IL_0fbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc6: Expected O, but got Unknown
		//IL_106e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1078: Expected O, but got Unknown
		//IL_1152: Unknown result type (might be due to invalid IL or missing references)
		//IL_115c: Expected O, but got Unknown
		//IL_1226: Unknown result type (might be due to invalid IL or missing references)
		//IL_1230: Expected O, but got Unknown
		//IL_1303: Unknown result type (might be due to invalid IL or missing references)
		//IL_130d: Expected O, but got Unknown
		//IL_13d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_13e1: Expected O, but got Unknown
		//IL_152f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1539: Expected O, but got Unknown
		//IL_154e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1558: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMDCalcNS));
		ToolTip1 = new ToolTip(components);
		Frame1 = new Panel();
		_Frame2_1 = new GroupBox();
		_optNS_1 = new RadioButton();
		txtUserInput = new TextBox();
		_Label1_3 = new Label();
		_Frame2_0 = new GroupBox();
		cmdCalc = new Button();
		txtAMOprod = new TextBox();
		_optNS_0 = new RadioButton();
		Label2 = new Label();
		lblNS = new Label();
		_Label1_4 = new Label();
		_Label1_2 = new Label();
		lblYprod = new Label();
		_Label1_1 = new Label();
		lblPVop = new Label();
		_Label1_0 = new Label();
		cmdRestore = new Button();
		cmdOk = new Button();
		cmdCancel = new Button();
		lblInstructions = new Label();
		Frame2 = new GroupBoxArray(components);
		Label1 = new LabelArray(components);
		optNS = new RadioButtonArray(components);
		((Control)Frame1).SuspendLayout();
		((Control)_Frame2_1).SuspendLayout();
		((Control)_Frame2_0).SuspendLayout();
		((ISupportInitialize)Frame2).BeginInit();
		((ISupportInitialize)Label1).BeginInit();
		((ISupportInitialize)optNS).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Frame1).BackColor = SystemColors.Control;
		((Control)Frame1).Controls.Add((Control)(object)_Frame2_1);
		((Control)Frame1).Controls.Add((Control)(object)_Frame2_0);
		((Control)Frame1).Cursor = Cursors.Default;
		((Control)Frame1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Frame1).ForeColor = SystemColors.ControlText;
		Panel frame = Frame1;
		Point location = new Point(8, 32);
		((Control)frame).Location = location;
		((Control)Frame1).Name = "Frame1";
		((Control)Frame1).RightToLeft = (RightToLeft)0;
		Panel frame2 = Frame1;
		Size size = new Size(481, 321);
		((Control)frame2).Size = size;
		((Control)Frame1).TabIndex = 12;
		((Control)_Frame2_1).BackColor = SystemColors.Control;
		((Control)_Frame2_1).Controls.Add((Control)(object)_optNS_1);
		((Control)_Frame2_1).Controls.Add((Control)(object)txtUserInput);
		((Control)_Frame2_1).Controls.Add((Control)(object)_Label1_3);
		((Control)_Frame2_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Frame2_1).ForeColor = SystemColors.ControlText;
		Frame2.SetIndex(_Frame2_1, (short)1);
		GroupBox frame2_ = _Frame2_1;
		location = new Point(8, 248);
		((Control)frame2_).Location = location;
		((Control)_Frame2_1).Name = "_Frame2_1";
		((Control)_Frame2_1).RightToLeft = (RightToLeft)0;
		GroupBox frame2_2 = _Frame2_1;
		size = new Size(465, 65);
		((Control)frame2_2).Size = size;
		((Control)_Frame2_1).TabIndex = 17;
		_Frame2_1.TabStop = false;
		_Frame2_1.Text = "NS = User input value";
		((ButtonBase)_optNS_1).BackColor = SystemColors.Control;
		((Control)_optNS_1).Cursor = Cursors.Default;
		((Control)_optNS_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optNS_1).ForeColor = SystemColors.ControlText;
		optNS.SetIndex(_optNS_1, (short)1);
		RadioButton optNS_ = _optNS_1;
		location = new Point(16, 24);
		((Control)optNS_).Location = location;
		((Control)_optNS_1).Name = "_optNS_1";
		((Control)_optNS_1).RightToLeft = (RightToLeft)0;
		RadioButton optNS_2 = _optNS_1;
		size = new Size(25, 17);
		((Control)optNS_2).Size = size;
		((Control)_optNS_1).TabIndex = 6;
		_optNS_1.TabStop = true;
		((ButtonBase)_optNS_1).UseVisualStyleBackColor = false;
		txtUserInput.AcceptsReturn = true;
		((TextBoxBase)txtUserInput).BackColor = SystemColors.Window;
		((Control)txtUserInput).Cursor = Cursors.IBeam;
		((Control)txtUserInput).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtUserInput).ForeColor = SystemColors.WindowText;
		TextBox obj = txtUserInput;
		location = new Point(360, 24);
		((Control)obj).Location = location;
		((TextBoxBase)txtUserInput).MaxLength = 0;
		((Control)txtUserInput).Name = "txtUserInput";
		((Control)txtUserInput).RightToLeft = (RightToLeft)0;
		TextBox obj2 = txtUserInput;
		size = new Size(89, 20);
		((Control)obj2).Size = size;
		((Control)txtUserInput).TabIndex = 7;
		((Control)_Label1_3).BackColor = SystemColors.Control;
		((Control)_Label1_3).Cursor = Cursors.Default;
		((Control)_Label1_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_3).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_3, (short)3);
		Label label1_ = _Label1_3;
		location = new Point(200, 24);
		((Control)label1_).Location = location;
		((Control)_Label1_3).Name = "_Label1_3";
		((Control)_Label1_3).RightToLeft = (RightToLeft)0;
		Label label1_2 = _Label1_3;
		size = new Size(153, 17);
		((Control)label1_2).Size = size;
		((Control)_Label1_3).TabIndex = 18;
		_Label1_3.Text = "NS, Number of sites: ";
		_Label1_3.TextAlign = (ContentAlignment)4;
		((Control)_Frame2_0).BackColor = SystemColors.Control;
		((Control)_Frame2_0).Controls.Add((Control)(object)cmdCalc);
		((Control)_Frame2_0).Controls.Add((Control)(object)txtAMOprod);
		((Control)_Frame2_0).Controls.Add((Control)(object)_optNS_0);
		((Control)_Frame2_0).Controls.Add((Control)(object)Label2);
		((Control)_Frame2_0).Controls.Add((Control)(object)lblNS);
		((Control)_Frame2_0).Controls.Add((Control)(object)_Label1_4);
		((Control)_Frame2_0).Controls.Add((Control)(object)_Label1_2);
		((Control)_Frame2_0).Controls.Add((Control)(object)lblYprod);
		((Control)_Frame2_0).Controls.Add((Control)(object)_Label1_1);
		((Control)_Frame2_0).Controls.Add((Control)(object)lblPVop);
		((Control)_Frame2_0).Controls.Add((Control)(object)_Label1_0);
		((Control)_Frame2_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Frame2_0).ForeColor = SystemColors.ControlText;
		Frame2.SetIndex(_Frame2_0, (short)0);
		GroupBox frame2_3 = _Frame2_0;
		location = new Point(8, 16);
		((Control)frame2_3).Location = location;
		((Control)_Frame2_0).Name = "_Frame2_0";
		((Control)_Frame2_0).RightToLeft = (RightToLeft)0;
		GroupBox frame2_4 = _Frame2_0;
		size = new Size(465, 217);
		((Control)frame2_4).Size = size;
		((Control)_Frame2_0).TabIndex = 13;
		_Frame2_0.TabStop = false;
		_Frame2_0.Text = "NS = PVop / Yprod / AMOprod";
		((ButtonBase)cmdCalc).BackColor = SystemColors.Control;
		((Control)cmdCalc).Cursor = Cursors.Default;
		((Control)cmdCalc).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCalc).ForeColor = SystemColors.ControlText;
		Button obj3 = cmdCalc;
		location = new Point(136, 128);
		((Control)obj3).Location = location;
		((Control)cmdCalc).Name = "cmdCalc";
		((Control)cmdCalc).RightToLeft = (RightToLeft)0;
		Button obj4 = cmdCalc;
		size = new Size(193, 25);
		((Control)obj4).Size = size;
		((Control)cmdCalc).TabIndex = 5;
		((ButtonBase)cmdCalc).Text = "&Calculate Number of Sites (NS)";
		((ButtonBase)cmdCalc).UseVisualStyleBackColor = false;
		txtAMOprod.AcceptsReturn = true;
		((TextBoxBase)txtAMOprod).BackColor = SystemColors.Window;
		((Control)txtAMOprod).Cursor = Cursors.IBeam;
		((Control)txtAMOprod).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtAMOprod).ForeColor = SystemColors.WindowText;
		TextBox obj5 = txtAMOprod;
		location = new Point(360, 72);
		((Control)obj5).Location = location;
		((TextBoxBase)txtAMOprod).MaxLength = 0;
		((Control)txtAMOprod).Name = "txtAMOprod";
		((Control)txtAMOprod).RightToLeft = (RightToLeft)0;
		TextBox obj6 = txtAMOprod;
		size = new Size(89, 20);
		((Control)obj6).Size = size;
		((Control)txtAMOprod).TabIndex = 3;
		((ButtonBase)_optNS_0).BackColor = SystemColors.Control;
		((Control)_optNS_0).Cursor = Cursors.Default;
		((Control)_optNS_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optNS_0).ForeColor = SystemColors.ControlText;
		optNS.SetIndex(_optNS_0, (short)0);
		RadioButton optNS_3 = _optNS_0;
		location = new Point(16, 40);
		((Control)optNS_3).Location = location;
		((Control)_optNS_0).Name = "_optNS_0";
		((Control)_optNS_0).RightToLeft = (RightToLeft)0;
		RadioButton optNS_4 = _optNS_0;
		size = new Size(25, 17);
		((Control)optNS_4).Size = size;
		((Control)_optNS_0).TabIndex = 0;
		_optNS_0.TabStop = true;
		((ButtonBase)_optNS_0).UseVisualStyleBackColor = false;
		((Control)Label2).BackColor = SystemColors.Control;
		((Control)Label2).Cursor = Cursors.Default;
		((Control)Label2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label2).ForeColor = SystemColors.ControlText;
		Label label = Label2;
		location = new Point(8, 168);
		((Control)label).Location = location;
		((Control)Label2).Name = "Label2";
		((Control)Label2).RightToLeft = (RightToLeft)0;
		Label label2 = Label2;
		size = new Size(449, 41);
		((Control)label2).Size = size;
		((Control)Label2).TabIndex = 20;
		Label2.Text = "Note: This option may only be selected if the fix box is checked for Yprod and its value preset on the Specify Mass Balance Input Parameters subtab.";
		((Control)lblNS).BackColor = SystemColors.Control;
		lblNS.BorderStyle = (BorderStyle)2;
		((Control)lblNS).Cursor = Cursors.Default;
		((Control)lblNS).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblNS).ForeColor = SystemColors.ControlText;
		Label obj7 = lblNS;
		location = new Point(360, 96);
		((Control)obj7).Location = location;
		((Control)lblNS).Name = "lblNS";
		((Control)lblNS).RightToLeft = (RightToLeft)0;
		Label obj8 = lblNS;
		size = new Size(89, 17);
		((Control)obj8).Size = size;
		((Control)lblNS).TabIndex = 4;
		((Control)_Label1_4).BackColor = SystemColors.Control;
		((Control)_Label1_4).Cursor = Cursors.Default;
		((Control)_Label1_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_4).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_4, (short)4);
		Label label1_3 = _Label1_4;
		location = new Point(40, 96);
		((Control)label1_3).Location = location;
		((Control)_Label1_4).Name = "_Label1_4";
		((Control)_Label1_4).RightToLeft = (RightToLeft)0;
		Label label1_4 = _Label1_4;
		size = new Size(313, 17);
		((Control)label1_4).Size = size;
		((Control)_Label1_4).TabIndex = 19;
		_Label1_4.Text = "NS, Number of sites: ";
		_Label1_4.TextAlign = (ContentAlignment)4;
		((Control)_Label1_2).BackColor = SystemColors.Control;
		((Control)_Label1_2).Cursor = Cursors.Default;
		((Control)_Label1_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_2).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_2, (short)2);
		Label label1_5 = _Label1_2;
		location = new Point(40, 72);
		((Control)label1_5).Location = location;
		((Control)_Label1_2).Name = "_Label1_2";
		((Control)_Label1_2).RightToLeft = (RightToLeft)0;
		Label label1_6 = _Label1_2;
		size = new Size(313, 17);
		((Control)label1_6).Size = size;
		((Control)_Label1_2).TabIndex = 16;
		_Label1_2.Text = "AMOprod, Annual mass of adhesive formulated per site: ";
		_Label1_2.TextAlign = (ContentAlignment)4;
		((Control)lblYprod).BackColor = SystemColors.Control;
		lblYprod.BorderStyle = (BorderStyle)2;
		((Control)lblYprod).Cursor = Cursors.Default;
		((Control)lblYprod).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblYprod).ForeColor = SystemColors.ControlText;
		Label obj9 = lblYprod;
		location = new Point(360, 48);
		((Control)obj9).Location = location;
		((Control)lblYprod).Name = "lblYprod";
		((Control)lblYprod).RightToLeft = (RightToLeft)0;
		Label obj10 = lblYprod;
		size = new Size(89, 17);
		((Control)obj10).Size = size;
		((Control)lblYprod).TabIndex = 2;
		((Control)_Label1_1).BackColor = SystemColors.Control;
		((Control)_Label1_1).Cursor = Cursors.Default;
		((Control)_Label1_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_1).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_1, (short)1);
		Label label1_7 = _Label1_1;
		location = new Point(40, 48);
		((Control)label1_7).Location = location;
		((Control)_Label1_1).Name = "_Label1_1";
		((Control)_Label1_1).RightToLeft = (RightToLeft)0;
		Label label1_8 = _Label1_1;
		size = new Size(313, 17);
		((Control)label1_8).Size = size;
		((Control)_Label1_1).TabIndex = 15;
		_Label1_1.Text = "Yprod, Weight fraction of chemical in adhesive formulation: ";
		_Label1_1.TextAlign = (ContentAlignment)4;
		((Control)lblPVop).BackColor = SystemColors.Control;
		lblPVop.BorderStyle = (BorderStyle)2;
		((Control)lblPVop).Cursor = Cursors.Default;
		((Control)lblPVop).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblPVop).ForeColor = SystemColors.ControlText;
		Label obj11 = lblPVop;
		location = new Point(360, 24);
		((Control)obj11).Location = location;
		((Control)lblPVop).Name = "lblPVop";
		((Control)lblPVop).RightToLeft = (RightToLeft)0;
		Label obj12 = lblPVop;
		size = new Size(89, 17);
		((Control)obj12).Size = size;
		((Control)lblPVop).TabIndex = 1;
		((Control)_Label1_0).BackColor = SystemColors.Control;
		((Control)_Label1_0).Cursor = Cursors.Default;
		((Control)_Label1_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_0).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_0, (short)0);
		Label label1_9 = _Label1_0;
		location = new Point(40, 24);
		((Control)label1_9).Location = location;
		((Control)_Label1_0).Name = "_Label1_0";
		((Control)_Label1_0).RightToLeft = (RightToLeft)0;
		Label label1_10 = _Label1_0;
		size = new Size(313, 17);
		((Control)label1_10).Size = size;
		((Control)_Label1_0).TabIndex = 14;
		_Label1_0.Text = "PVop, Total mass of chemical for all operation sites: ";
		_Label1_0.TextAlign = (ContentAlignment)4;
		((ButtonBase)cmdRestore).BackColor = SystemColors.Control;
		((Control)cmdRestore).Cursor = Cursors.Default;
		((Control)cmdRestore).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdRestore).ForeColor = SystemColors.ControlText;
		Button obj13 = cmdRestore;
		location = new Point(312, 360);
		((Control)obj13).Location = location;
		((Control)cmdRestore).Name = "cmdRestore";
		((Control)cmdRestore).RightToLeft = (RightToLeft)0;
		Button obj14 = cmdRestore;
		size = new Size(97, 25);
		((Control)obj14).Size = size;
		((Control)cmdRestore).TabIndex = 10;
		((ButtonBase)cmdRestore).Text = "&Restore Defaults";
		((ButtonBase)cmdRestore).UseVisualStyleBackColor = false;
		((ButtonBase)cmdOk).BackColor = SystemColors.Control;
		((Control)cmdOk).Cursor = Cursors.Default;
		((Control)cmdOk).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdOk).ForeColor = SystemColors.ControlText;
		Button obj15 = cmdOk;
		location = new Point(88, 360);
		((Control)obj15).Location = location;
		((Control)cmdOk).Name = "cmdOk";
		((Control)cmdOk).RightToLeft = (RightToLeft)0;
		Button obj16 = cmdOk;
		size = new Size(97, 25);
		((Control)obj16).Size = size;
		((Control)cmdOk).TabIndex = 8;
		((ButtonBase)cmdOk).Text = "OK";
		((ButtonBase)cmdOk).UseVisualStyleBackColor = false;
		((ButtonBase)cmdCancel).BackColor = SystemColors.Control;
		((Control)cmdCancel).Cursor = Cursors.Default;
		cmdCancel.DialogResult = (DialogResult)2;
		((Control)cmdCancel).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCancel).ForeColor = SystemColors.ControlText;
		Button obj17 = cmdCancel;
		location = new Point(200, 360);
		((Control)obj17).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		((Control)cmdCancel).RightToLeft = (RightToLeft)0;
		Button obj18 = cmdCancel;
		size = new Size(97, 25);
		((Control)obj18).Size = size;
		((Control)cmdCancel).TabIndex = 9;
		((ButtonBase)cmdCancel).Text = "Cancel";
		((ButtonBase)cmdCancel).UseVisualStyleBackColor = false;
		((Control)lblInstructions).BackColor = SystemColors.Control;
		((Control)lblInstructions).Cursor = Cursors.Default;
		((Control)lblInstructions).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblInstructions).ForeColor = SystemColors.ControlText;
		Label obj19 = lblInstructions;
		location = new Point(16, 16);
		((Control)obj19).Location = location;
		((Control)lblInstructions).Name = "lblInstructions";
		((Control)lblInstructions).RightToLeft = (RightToLeft)0;
		Label obj20 = lblInstructions;
		size = new Size(321, 17);
		((Control)obj20).Size = size;
		((Control)lblInstructions).TabIndex = 11;
		lblInstructions.Text = "Select a method for deriving Number of Sites";
		((Form)this).AcceptButton = (IButtonControl)(object)cmdOk;
		size = new Size(5, 13);
		((Form)this).AutoScaleBaseSize = size;
		((Form)this).BackColor = SystemColors.Control;
		((Form)this).CancelButton = (IButtonControl)(object)cmdCancel;
		size = new Size(496, 395);
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
		((Control)this).Name = "frmMDCalcNS";
		((Control)this).RightToLeft = (RightToLeft)0;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Calculate NS";
		((Control)Frame1).ResumeLayout(false);
		((Control)_Frame2_1).ResumeLayout(false);
		((Control)_Frame2_1).PerformLayout();
		((Control)_Frame2_0).ResumeLayout(false);
		((Control)_Frame2_0).PerformLayout();
		((ISupportInitialize)Frame2).EndInit();
		((ISupportInitialize)Label1).EndInit();
		((ISupportInitialize)optNS).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void cmdCalc_Click(object eventSender, EventArgs eventArgs)
	{
		if (ValidateOption1())
		{
			lblNS.Text = Conversions.ToString(checked((int)Math.Round(Conversions.ToDouble(lblPVop.Text) / Conversions.ToDouble(lblYprod.Text) / Conversions.ToDouble(txtAMOprod.Text))));
			if (Conversions.ToDouble(lblNS.Text) == 0.0)
			{
				lblNS.Text = Conversions.ToString(1);
			}
		}
	}

	private void cmdOk_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		if (_optNS_0.Checked)
		{
			if (!ValidateOption1())
			{
				return;
			}
			cmdCalc_Click(cmdCalc, new EventArgs());
			((Control)frmMDUpdOpIP.DefInstance._fraTab2_0).Controls["_txtKnowns_0"].Text = lblNS.Text;
		}
		else
		{
			if (!Versioned.IsNumeric((object)txtUserInput.Text))
			{
				Interaction.MsgBox((object)"Please enter a valid User-defined NS.", (MsgBoxStyle)64, (object)null);
				return;
			}
			((Control)frmMDUpdOpIP.DefInstance._fraTab2_0).Controls["_txtKnowns_0"].Text = txtUserInput.Text;
			txtAMOprod.Text = Conversions.ToString(0);
		}
		((Control)this).Tag = "";
		((Control)this).Hide();
	}

	private void cmdRestore_Click(object eventSender, EventArgs eventArgs)
	{
		txtAMOprod.Text = Conversions.ToString(500000);
		lblPVop.Text = Conversions.ToString(frmMDUpdOpIP.DefInstance.MyPvOp);
		lblYprod.Text = ((Control)frmMDUpdOpIP.DefInstance._fraTab2_0).Controls["_txtKnowns_3"].Text;
		_optNS_0.Checked = true;
		cmdCalc_Click(cmdCalc, new EventArgs());
	}

	private void cmdCancel_Click(object eventSender, EventArgs eventArgs)
	{
		((Control)this).Tag = "Cancel";
		((Control)this).Hide();
	}

	private void frmMDCalcNS_Load(object eventSender, EventArgs eventArgs)
	{
	}

	public bool SetUp(ref short pOption, ref float pAMOprod)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Invalid comparison between Unknown and I4
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
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
					ProjectData.ClearProjectError();
					num2 = 2;
					short num3 = pOption;
					if (((int)frmMDUpdOpIP.DefInstance.chkKnowns1[(short)3].CheckState == 0) | (Strings.Len(frmMDUpdOpIP.DefInstance.txtKnowns[(short)3].Text) == 0))
					{
						num3 = 1;
						((Control)optNS[(short)0]).Enabled = false;
					}
					if (num3 == 0)
					{
						lblPVop.Text = Conversions.ToString(frmMDUpdOpIP.DefInstance.MyPvOp);
						lblYprod.Text = ((Control)frmMDUpdOpIP.DefInstance._fraTab2_0).Controls["_txtKnowns_3"].Text;
						txtAMOprod.Text = ChemStrX.ShowZeroAsNull(pAMOprod);
						cmdCalc_Click(cmdCalc, new EventArgs());
					}
					else
					{
						txtUserInput.Text = ((Control)frmMDUpdOpIP.DefInstance._fraTab2_0).Controls["_txtKnowns_0"].Text;
					}
					((RadioButton)((Control)_Frame2_0).Controls["_optNS_" + Conversions.ToString((int)num3)]).Checked = true;
					flag = true;
					goto end_IL_0001;
				}
				case 409:
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
				try0001_dispatch = 409;
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

	private void optNS_CheckedChanged(object eventSender, EventArgs eventArgs)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		if (Conversions.ToBoolean(NewLateBinding.LateGet(eventSender, (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			if ((iOptSelected = optNS.GetIndex((RadioButton)eventSender)) == 0)
			{
				_optNS_1.Checked = false;
			}
			else
			{
				_optNS_0.Checked = false;
			}
		}
	}

	private bool ValidateOption1()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		if (!Versioned.IsNumeric((object)lblPVop.Text))
		{
			Interaction.MsgBox((object)"A valid PVop is required in order to use this calculation.", (MsgBoxStyle)64, (object)null);
		}
		else if (!Versioned.IsNumeric((object)lblYprod.Text))
		{
			Interaction.MsgBox((object)"A valid Yprod is required in order to use this calculation.", (MsgBoxStyle)64, (object)null);
		}
		else
		{
			if (Versioned.IsNumeric((object)txtAMOprod.Text))
			{
				return true;
			}
			Interaction.MsgBox((object)"A valid AMOprod is required in order to use this calculation.", (MsgBoxStyle)64, (object)null);
		}
		bool result = default(bool);
		return result;
	}

	private void checkChkNS(short index)
	{
		iOptSelected = index;
		if (index == 0)
		{
			_optNS_1.Checked = false;
		}
		else
		{
			_optNS_0.Checked = false;
		}
	}

	private void _optNS_0_CheckedChanged(object sender, EventArgs e)
	{
		if (_optNS_0.Checked)
		{
			checkChkNS(0);
		}
	}

	private void _optNS_1_CheckedChanged(object sender, EventArgs e)
	{
		if (_optNS_1.Checked)
		{
			checkChkNS(1);
		}
	}
}
