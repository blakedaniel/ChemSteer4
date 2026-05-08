using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ChemSteer;

internal class frmUpdCmCv : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("txtCm")]
	private TextBox _txtCm;

	[AccessedThroughProperty("_optCm_1")]
	private RadioButton __optCm_1;

	[AccessedThroughProperty("_optCm_0")]
	private RadioButton __optCm_0;

	[AccessedThroughProperty("txtCv")]
	private TextBox _txtCv;

	[AccessedThroughProperty("lblYs")]
	private Label _lblYs;

	[AccessedThroughProperty("_lblX_5")]
	private Label __lblX_5;

	[AccessedThroughProperty("lblVm")]
	private Label _lblVm;

	[AccessedThroughProperty("lblMW")]
	private Label _lblMW;

	[AccessedThroughProperty("_lblX_4")]
	private Label __lblX_4;

	[AccessedThroughProperty("_lblX_3")]
	private Label __lblX_3;

	[AccessedThroughProperty("_lblX_2")]
	private Label __lblX_2;

	[AccessedThroughProperty("lblCM")]
	private Label _lblCM;

	[AccessedThroughProperty("_lblX_1")]
	private Label __lblX_1;

	[AccessedThroughProperty("_lblX_0")]
	private Label __lblX_0;

	[AccessedThroughProperty("fra_UserDefI")]
	private GroupBox _fra_UserDefI;

	[AccessedThroughProperty("fra_NearFarI")]
	private GroupBox _fra_NearFarI;

	[AccessedThroughProperty("_optCm_NF_1")]
	private RadioButton __optCm_NF_1;

	[AccessedThroughProperty("_optCm_NF_0")]
	private RadioButton __optCm_NF_0;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("cmdOK")]
	private Button _cmdOK;

	[AccessedThroughProperty("lblCff")]
	private Label _lblCff;

	[AccessedThroughProperty("lblCnf")]
	private Label _lblCnf;

	[AccessedThroughProperty("CachedIRERcomb1")]
	private CachedIRERcomb _CachedIRERcomb1;

	[AccessedThroughProperty("lblInstructions")]
	private Label _lblInstructions;

	private static frmUpdCmCv m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	private short iCmRow;

	private short iCvRow;

	private short iOption;

	private bool bLoadingForm;

	private short iDualIndex;

	private short iModelType;

	public virtual TextBox txtCm
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtCm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtCm_TextChanged;
			if (_txtCm != null)
			{
				((Control)_txtCm).TextChanged -= eventHandler;
			}
			_txtCm = value;
			if (_txtCm != null)
			{
				((Control)_txtCm).TextChanged += eventHandler;
			}
		}
	}

	public virtual RadioButton _optCm_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __optCm_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = optCm_CheckedChanged;
			if (__optCm_1 != null)
			{
				__optCm_1.CheckedChanged -= eventHandler;
			}
			__optCm_1 = value;
			if (__optCm_1 != null)
			{
				__optCm_1.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual RadioButton _optCm_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __optCm_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = optCm_CheckedChanged;
			if (__optCm_0 != null)
			{
				__optCm_0.CheckedChanged -= eventHandler;
			}
			__optCm_0 = value;
			if (__optCm_0 != null)
			{
				__optCm_0.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual TextBox txtCv
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtCv;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtCv_TextChanged;
			if (_txtCv != null)
			{
				((Control)_txtCv).TextChanged -= eventHandler;
			}
			_txtCv = value;
			if (_txtCv != null)
			{
				((Control)_txtCv).TextChanged += eventHandler;
			}
		}
	}

	public virtual Label lblYs
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblYs;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblYs = value;
		}
	}

	public virtual Label _lblX_5
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblX_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblX_5 = value;
		}
	}

	public virtual Label lblVm
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblVm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblVm = value;
		}
	}

	public virtual Label lblMW
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMW;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMW = value;
		}
	}

	public virtual Label _lblX_4
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblX_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblX_4 = value;
		}
	}

	public virtual Label _lblX_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblX_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblX_3 = value;
		}
	}

	public virtual Label _lblX_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblX_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblX_2 = value;
		}
	}

	public virtual Label lblCM
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblCM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblCM = value;
		}
	}

	public virtual Label _lblX_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblX_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblX_1 = value;
		}
	}

	public virtual Label _lblX_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblX_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblX_0 = value;
		}
	}

	internal virtual GroupBox fra_UserDefI
	{
		[DebuggerNonUserCode]
		get
		{
			return _fra_UserDefI;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_fra_UserDefI = value;
		}
	}

	internal virtual GroupBox fra_NearFarI
	{
		[DebuggerNonUserCode]
		get
		{
			return _fra_NearFarI;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_fra_NearFarI = value;
		}
	}

	public virtual RadioButton _optCm_NF_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __optCm_NF_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__optCm_NF_1 = value;
		}
	}

	public virtual RadioButton _optCm_NF_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __optCm_NF_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _optCm_NF_0_CheckedChanged;
			if (__optCm_NF_0 != null)
			{
				__optCm_NF_0.CheckedChanged -= eventHandler;
			}
			__optCm_NF_0 = value;
			if (__optCm_NF_0 != null)
			{
				__optCm_NF_0.CheckedChanged += eventHandler;
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
			EventHandler eventHandler = cmdCancel_Click1;
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
			EventHandler eventHandler = cmdOK_Click1;
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

	public virtual Label lblCff
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblCff;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblCff = value;
		}
	}

	public virtual Label lblCnf
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblCnf;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblCnf = value;
		}
	}

	internal virtual CachedIRERcomb CachedIRERcomb1
	{
		[DebuggerNonUserCode]
		get
		{
			return _CachedIRERcomb1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CachedIRERcomb1 = value;
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

	public static frmUpdCmCv DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmUpdCmCv();
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

	public frmUpdCmCv()
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
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected O, but got Unknown
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected O, but got Unknown
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Expected O, but got Unknown
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_0510: Expected O, but got Unknown
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c3: Expected O, but got Unknown
		//IL_068a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0694: Expected O, but got Unknown
		//IL_074a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0754: Expected O, but got Unknown
		//IL_07fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0807: Expected O, but got Unknown
		//IL_08c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ce: Expected O, but got Unknown
		//IL_098b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0995: Expected O, but got Unknown
		//IL_0a5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a66: Expected O, but got Unknown
		//IL_0b12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1c: Expected O, but got Unknown
		//IL_0bd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdf: Expected O, but got Unknown
		//IL_0c98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca2: Expected O, but got Unknown
		//IL_0fcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd5: Expected O, but got Unknown
		//IL_1098: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a2: Expected O, but got Unknown
		//IL_1165: Unknown result type (might be due to invalid IL or missing references)
		//IL_116f: Expected O, but got Unknown
		//IL_1242: Unknown result type (might be due to invalid IL or missing references)
		//IL_124c: Expected O, but got Unknown
		//IL_131f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1329: Expected O, but got Unknown
		//IL_13f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_13fd: Expected O, but got Unknown
		//IL_1541: Unknown result type (might be due to invalid IL or missing references)
		//IL_154b: Expected O, but got Unknown
		//IL_1560: Unknown result type (might be due to invalid IL or missing references)
		//IL_156a: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmUpdCmCv));
		ToolTip1 = new ToolTip(components);
		txtCm = new TextBox();
		_optCm_1 = new RadioButton();
		_optCm_0 = new RadioButton();
		txtCv = new TextBox();
		lblYs = new Label();
		_lblX_5 = new Label();
		lblVm = new Label();
		lblMW = new Label();
		_lblX_4 = new Label();
		_lblX_3 = new Label();
		_lblX_2 = new Label();
		lblCM = new Label();
		_lblX_1 = new Label();
		_lblX_0 = new Label();
		lblInstructions = new Label();
		fra_UserDefI = new GroupBox();
		fra_NearFarI = new GroupBox();
		lblCff = new Label();
		lblCnf = new Label();
		_optCm_NF_0 = new RadioButton();
		_optCm_NF_1 = new RadioButton();
		cmdCancel = new Button();
		cmdOK = new Button();
		CachedIRERcomb1 = new CachedIRERcomb();
		((Control)fra_UserDefI).SuspendLayout();
		((Control)fra_NearFarI).SuspendLayout();
		((Control)this).SuspendLayout();
		txtCm.AcceptsReturn = true;
		((TextBoxBase)txtCm).BackColor = SystemColors.Window;
		((Control)txtCm).Cursor = Cursors.IBeam;
		((Control)txtCm).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtCm).ForeColor = SystemColors.WindowText;
		TextBox obj = txtCm;
		Point location = new Point(450, 195);
		((Control)obj).Location = location;
		((TextBoxBase)txtCm).MaxLength = 0;
		((Control)txtCm).Name = "txtCm";
		((Control)txtCm).RightToLeft = (RightToLeft)0;
		TextBox obj2 = txtCm;
		Size size = new Size(73, 20);
		((Control)obj2).Size = size;
		((Control)txtCm).TabIndex = 3;
		((ButtonBase)_optCm_1).BackColor = SystemColors.Control;
		((Control)_optCm_1).Cursor = Cursors.Default;
		((Control)_optCm_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optCm_1).ForeColor = SystemColors.ControlText;
		RadioButton optCm_ = _optCm_1;
		location = new Point(14, 171);
		((Control)optCm_).Location = location;
		((Control)_optCm_1).Name = "_optCm_1";
		((Control)_optCm_1).RightToLeft = (RightToLeft)0;
		RadioButton optCm_2 = _optCm_1;
		size = new Size(433, 17);
		((Control)optCm_2).Size = size;
		((Control)_optCm_1).TabIndex = 2;
		_optCm_1.TabStop = true;
		((ButtonBase)_optCm_1).Text = "Enter the Mass Concentration of Chemical in Air";
		((ButtonBase)_optCm_1).UseVisualStyleBackColor = false;
		((ButtonBase)_optCm_0).BackColor = SystemColors.Control;
		((Control)_optCm_0).Cursor = Cursors.Default;
		((Control)_optCm_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optCm_0).ForeColor = SystemColors.ControlText;
		RadioButton optCm_3 = _optCm_0;
		location = new Point(14, 16);
		((Control)optCm_3).Location = location;
		((Control)_optCm_0).Name = "_optCm_0";
		((Control)_optCm_0).RightToLeft = (RightToLeft)0;
		RadioButton optCm_4 = _optCm_0;
		size = new Size(601, 27);
		((Control)optCm_4).Size = size;
		((Control)_optCm_0).TabIndex = 0;
		_optCm_0.TabStop = true;
		((ButtonBase)_optCm_0).Text = "Calculate the Mass Concentration of Chemical in Air from the Volume Concentration in Air: Cm = Cv x MW / Vm x Ys";
		((ButtonBase)_optCm_0).UseVisualStyleBackColor = false;
		txtCv.AcceptsReturn = true;
		((TextBoxBase)txtCv).BackColor = SystemColors.Window;
		((Control)txtCv).Cursor = Cursors.IBeam;
		((Control)txtCv).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtCv).ForeColor = SystemColors.WindowText;
		TextBox obj3 = txtCv;
		location = new Point(426, 43);
		((Control)obj3).Location = location;
		((TextBoxBase)txtCv).MaxLength = 0;
		((Control)txtCv).Name = "txtCv";
		((Control)txtCv).RightToLeft = (RightToLeft)0;
		TextBox obj4 = txtCv;
		size = new Size(73, 20);
		((Control)obj4).Size = size;
		((Control)txtCv).TabIndex = 1;
		((Control)lblYs).BackColor = SystemColors.Control;
		lblYs.BorderStyle = (BorderStyle)2;
		((Control)lblYs).Cursor = Cursors.Default;
		((Control)lblYs).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblYs).ForeColor = SystemColors.ControlText;
		Label obj5 = lblYs;
		location = new Point(426, 115);
		((Control)obj5).Location = location;
		((Control)lblYs).Name = "lblYs";
		((Control)lblYs).RightToLeft = (RightToLeft)0;
		Label obj6 = lblYs;
		size = new Size(73, 17);
		((Control)obj6).Size = size;
		((Control)lblYs).TabIndex = 16;
		((Control)_lblX_5).BackColor = SystemColors.Control;
		((Control)_lblX_5).Cursor = Cursors.Default;
		((Control)_lblX_5).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblX_5).ForeColor = SystemColors.ControlText;
		Label lblX_ = _lblX_5;
		location = new Point(70, 115);
		((Control)lblX_).Location = location;
		((Control)_lblX_5).Name = "_lblX_5";
		((Control)_lblX_5).RightToLeft = (RightToLeft)0;
		Label lblX_2 = _lblX_5;
		size = new Size(300, 17);
		((Control)lblX_2).Size = size;
		((Control)_lblX_5).TabIndex = 15;
		_lblX_5.Text = "Ys, Weight fraction of Chemical in mixture";
		((Control)lblVm).BackColor = SystemColors.Control;
		lblVm.BorderStyle = (BorderStyle)2;
		((Control)lblVm).Cursor = Cursors.Default;
		((Control)lblVm).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblVm).ForeColor = SystemColors.ControlText;
		Label obj7 = lblVm;
		location = new Point(426, 91);
		((Control)obj7).Location = location;
		((Control)lblVm).Name = "lblVm";
		((Control)lblVm).RightToLeft = (RightToLeft)0;
		Label obj8 = lblVm;
		size = new Size(73, 17);
		((Control)obj8).Size = size;
		((Control)lblVm).TabIndex = 14;
		((Control)lblMW).BackColor = SystemColors.Control;
		lblMW.BorderStyle = (BorderStyle)2;
		((Control)lblMW).Cursor = Cursors.Default;
		((Control)lblMW).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblMW).ForeColor = SystemColors.ControlText;
		Label obj9 = lblMW;
		location = new Point(426, 67);
		((Control)obj9).Location = location;
		((Control)lblMW).Name = "lblMW";
		((Control)lblMW).RightToLeft = (RightToLeft)0;
		Label obj10 = lblMW;
		size = new Size(73, 17);
		((Control)obj10).Size = size;
		((Control)lblMW).TabIndex = 13;
		((Control)_lblX_4).BackColor = SystemColors.Control;
		((Control)_lblX_4).Cursor = Cursors.Default;
		((Control)_lblX_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblX_4).ForeColor = SystemColors.ControlText;
		Label lblX_3 = _lblX_4;
		location = new Point(70, 195);
		((Control)lblX_3).Location = location;
		((Control)_lblX_4).Name = "_lblX_4";
		((Control)_lblX_4).RightToLeft = (RightToLeft)0;
		Label lblX_4 = _lblX_4;
		size = new Size(300, 17);
		((Control)lblX_4).Size = size;
		((Control)_lblX_4).TabIndex = 12;
		_lblX_4.Text = "Cm, Mass Concentration of Chemical in Air (mg/m3): ";
		((Control)_lblX_3).BackColor = SystemColors.Control;
		((Control)_lblX_3).Cursor = Cursors.Default;
		((Control)_lblX_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblX_3).ForeColor = SystemColors.ControlText;
		Label lblX_5 = _lblX_3;
		location = new Point(70, 139);
		((Control)lblX_5).Location = location;
		((Control)_lblX_3).Name = "_lblX_3";
		((Control)_lblX_3).RightToLeft = (RightToLeft)0;
		Label lblX_6 = _lblX_3;
		size = new Size(300, 17);
		((Control)lblX_6).Size = size;
		((Control)_lblX_3).TabIndex = 11;
		_lblX_3.Text = "Cm, Mass Concentration of Chemical in Air (mg/m3): ";
		((Control)_lblX_2).BackColor = SystemColors.Control;
		((Control)_lblX_2).Cursor = Cursors.Default;
		((Control)_lblX_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblX_2).ForeColor = SystemColors.ControlText;
		Label lblX_7 = _lblX_2;
		location = new Point(70, 91);
		((Control)lblX_7).Location = location;
		((Control)_lblX_2).Name = "_lblX_2";
		((Control)_lblX_2).RightToLeft = (RightToLeft)0;
		Label lblX_8 = _lblX_2;
		size = new Size(300, 17);
		((Control)lblX_8).Size = size;
		((Control)_lblX_2).TabIndex = 10;
		_lblX_2.Text = "Vm, Molar Volume (L/mol): ";
		((Control)lblCM).BackColor = SystemColors.Control;
		lblCM.BorderStyle = (BorderStyle)2;
		((Control)lblCM).Cursor = Cursors.Default;
		((Control)lblCM).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblCM).ForeColor = SystemColors.ControlText;
		Label obj11 = lblCM;
		location = new Point(450, 139);
		((Control)obj11).Location = location;
		((Control)lblCM).Name = "lblCM";
		((Control)lblCM).RightToLeft = (RightToLeft)0;
		Label obj12 = lblCM;
		size = new Size(73, 17);
		((Control)obj12).Size = size;
		((Control)lblCM).TabIndex = 9;
		((Control)_lblX_1).BackColor = SystemColors.Control;
		((Control)_lblX_1).Cursor = Cursors.Default;
		((Control)_lblX_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblX_1).ForeColor = SystemColors.ControlText;
		Label lblX_9 = _lblX_1;
		location = new Point(70, 43);
		((Control)lblX_9).Location = location;
		((Control)_lblX_1).Name = "_lblX_1";
		((Control)_lblX_1).RightToLeft = (RightToLeft)0;
		Label lblX_10 = _lblX_1;
		size = new Size(300, 17);
		((Control)lblX_10).Size = size;
		((Control)_lblX_1).TabIndex = 8;
		_lblX_1.Text = "Cv, Volume Concentration in Air (ppm): ";
		((Control)_lblX_0).BackColor = SystemColors.Control;
		((Control)_lblX_0).Cursor = Cursors.Default;
		((Control)_lblX_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblX_0).ForeColor = SystemColors.ControlText;
		Label lblX_11 = _lblX_0;
		location = new Point(70, 67);
		((Control)lblX_11).Location = location;
		((Control)_lblX_0).Name = "_lblX_0";
		((Control)_lblX_0).RightToLeft = (RightToLeft)0;
		Label lblX_12 = _lblX_0;
		size = new Size(300, 17);
		((Control)lblX_12).Size = size;
		((Control)_lblX_0).TabIndex = 7;
		_lblX_0.Text = "MW, Molecular Weight (daltons): ";
		((Control)lblInstructions).BackColor = SystemColors.Control;
		((Control)lblInstructions).Cursor = Cursors.Default;
		((Control)lblInstructions).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblInstructions).ForeColor = SystemColors.ControlText;
		Label obj13 = lblInstructions;
		location = new Point(8, 16);
		((Control)obj13).Location = location;
		((Control)lblInstructions).Name = "lblInstructions";
		((Control)lblInstructions).RightToLeft = (RightToLeft)0;
		Label obj14 = lblInstructions;
		size = new Size(553, 33);
		((Control)obj14).Size = size;
		((Control)lblInstructions).TabIndex = 6;
		lblInstructions.Text = "You may use this window to update the Mass Concentration of Chemical in Air (Cm) for this model";
		((Control)fra_UserDefI).Controls.Add((Control)(object)txtCm);
		((Control)fra_UserDefI).Controls.Add((Control)(object)_optCm_1);
		((Control)fra_UserDefI).Controls.Add((Control)(object)txtCv);
		((Control)fra_UserDefI).Controls.Add((Control)(object)lblYs);
		((Control)fra_UserDefI).Controls.Add((Control)(object)_lblX_5);
		((Control)fra_UserDefI).Controls.Add((Control)(object)lblVm);
		((Control)fra_UserDefI).Controls.Add((Control)(object)lblMW);
		((Control)fra_UserDefI).Controls.Add((Control)(object)_lblX_4);
		((Control)fra_UserDefI).Controls.Add((Control)(object)_lblX_3);
		((Control)fra_UserDefI).Controls.Add((Control)(object)_lblX_2);
		((Control)fra_UserDefI).Controls.Add((Control)(object)lblCM);
		((Control)fra_UserDefI).Controls.Add((Control)(object)_lblX_1);
		((Control)fra_UserDefI).Controls.Add((Control)(object)_lblX_0);
		((Control)fra_UserDefI).Controls.Add((Control)(object)_optCm_0);
		GroupBox obj15 = fra_UserDefI;
		location = new Point(11, 48);
		((Control)obj15).Location = location;
		((Control)fra_UserDefI).Name = "fra_UserDefI";
		GroupBox obj16 = fra_UserDefI;
		size = new Size(614, 235);
		((Control)obj16).Size = size;
		((Control)fra_UserDefI).TabIndex = 17;
		fra_UserDefI.TabStop = false;
		((Control)fra_NearFarI).Controls.Add((Control)(object)lblCff);
		((Control)fra_NearFarI).Controls.Add((Control)(object)lblCnf);
		((Control)fra_NearFarI).Controls.Add((Control)(object)_optCm_NF_0);
		((Control)fra_NearFarI).Controls.Add((Control)(object)_optCm_NF_1);
		GroupBox obj17 = fra_NearFarI;
		location = new Point(5, 48);
		((Control)obj17).Location = location;
		((Control)fra_NearFarI).Name = "fra_NearFarI";
		GroupBox obj18 = fra_NearFarI;
		size = new Size(614, 84);
		((Control)obj18).Size = size;
		((Control)fra_NearFarI).TabIndex = 18;
		fra_NearFarI.TabStop = false;
		((Control)lblCff).BackColor = SystemColors.Control;
		lblCff.BorderStyle = (BorderStyle)2;
		((Control)lblCff).Cursor = Cursors.Default;
		((Control)lblCff).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblCff).ForeColor = SystemColors.ControlText;
		Label obj19 = lblCff;
		location = new Point(326, 53);
		((Control)obj19).Location = location;
		((Control)lblCff).Name = "lblCff";
		((Control)lblCff).RightToLeft = (RightToLeft)0;
		Label obj20 = lblCff;
		size = new Size(73, 17);
		((Control)obj20).Size = size;
		((Control)lblCff).TabIndex = 11;
		((Control)lblCff).Visible = false;
		((Control)lblCnf).BackColor = SystemColors.Control;
		lblCnf.BorderStyle = (BorderStyle)2;
		((Control)lblCnf).Cursor = Cursors.Default;
		((Control)lblCnf).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblCnf).ForeColor = SystemColors.ControlText;
		Label obj21 = lblCnf;
		location = new Point(326, 26);
		((Control)obj21).Location = location;
		((Control)lblCnf).Name = "lblCnf";
		((Control)lblCnf).RightToLeft = (RightToLeft)0;
		Label obj22 = lblCnf;
		size = new Size(73, 17);
		((Control)obj22).Size = size;
		((Control)lblCnf).TabIndex = 10;
		((Control)lblCnf).Visible = false;
		((Control)_optCm_NF_0).AllowDrop = true;
		((ButtonBase)_optCm_NF_0).BackColor = SystemColors.Control;
		((Control)_optCm_NF_0).Cursor = Cursors.Default;
		((Control)_optCm_NF_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optCm_NF_0).ForeColor = SystemColors.ControlText;
		RadioButton optCm_NF_ = _optCm_NF_0;
		location = new Point(14, 16);
		((Control)optCm_NF_).Location = location;
		((Control)_optCm_NF_0).Name = "_optCm_NF_0";
		((Control)_optCm_NF_0).RightToLeft = (RightToLeft)0;
		RadioButton optCm_NF_2 = _optCm_NF_0;
		size = new Size(464, 27);
		((Control)optCm_NF_2).Size = size;
		((Control)_optCm_NF_0).TabIndex = 0;
		_optCm_NF_0.TabStop = true;
		((ButtonBase)_optCm_NF_0).Text = "Near-Field (mg/m3)";
		((ButtonBase)_optCm_NF_0).UseVisualStyleBackColor = false;
		((ButtonBase)_optCm_NF_1).BackColor = SystemColors.Control;
		((Control)_optCm_NF_1).Cursor = Cursors.Default;
		((Control)_optCm_NF_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optCm_NF_1).ForeColor = SystemColors.ControlText;
		RadioButton optCm_NF_3 = _optCm_NF_1;
		location = new Point(14, 53);
		((Control)optCm_NF_3).Location = location;
		((Control)_optCm_NF_1).Name = "_optCm_NF_1";
		((Control)_optCm_NF_1).RightToLeft = (RightToLeft)0;
		RadioButton optCm_NF_4 = _optCm_NF_1;
		size = new Size(433, 17);
		((Control)optCm_NF_4).Size = size;
		((Control)_optCm_NF_1).TabIndex = 2;
		_optCm_NF_1.TabStop = true;
		((ButtonBase)_optCm_NF_1).Text = "Far-Field (mg/m3)";
		((ButtonBase)_optCm_NF_1).UseVisualStyleBackColor = false;
		((ButtonBase)cmdCancel).BackColor = SystemColors.Control;
		((Control)cmdCancel).Cursor = Cursors.Default;
		((Control)cmdCancel).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCancel).ForeColor = SystemColors.ControlText;
		Button obj23 = cmdCancel;
		location = new Point(331, 291);
		((Control)obj23).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		((Control)cmdCancel).RightToLeft = (RightToLeft)0;
		Button obj24 = cmdCancel;
		size = new Size(89, 25);
		((Control)obj24).Size = size;
		((Control)cmdCancel).TabIndex = 20;
		((ButtonBase)cmdCancel).Text = "Cancel";
		((ButtonBase)cmdCancel).UseVisualStyleBackColor = false;
		((ButtonBase)cmdOK).BackColor = SystemColors.Control;
		((Control)cmdOK).Cursor = Cursors.Default;
		((Control)cmdOK).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdOK).ForeColor = SystemColors.ControlText;
		Button obj25 = cmdOK;
		location = new Point(215, 291);
		((Control)obj25).Location = location;
		((Control)cmdOK).Name = "cmdOK";
		((Control)cmdOK).RightToLeft = (RightToLeft)0;
		Button obj26 = cmdOK;
		size = new Size(89, 25);
		((Control)obj26).Size = size;
		((Control)cmdOK).TabIndex = 19;
		((ButtonBase)cmdOK).Text = "OK";
		((ButtonBase)cmdOK).UseVisualStyleBackColor = false;
		size = new Size(5, 13);
		((Form)this).AutoScaleBaseSize = size;
		((Form)this).BackColor = SystemColors.Control;
		size = new Size(635, 324);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)cmdOK);
		((Control)this).Controls.Add((Control)(object)fra_NearFarI);
		((Control)this).Controls.Add((Control)(object)fra_UserDefI);
		((Control)this).Controls.Add((Control)(object)lblInstructions);
		((Control)this).Cursor = Cursors.Default;
		((Control)this).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		location = new Point(250, 150);
		((Form)this).Location = location;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmUpdCmCv";
		((Control)this).RightToLeft = (RightToLeft)0;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Mass Concentration of Chemical in Air (Cm) Calculation Screen";
		((Control)fra_UserDefI).ResumeLayout(false);
		((Control)fra_UserDefI).PerformLayout();
		((Control)fra_NearFarI).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	public bool SetUp(ref short pDualIndex, ref short pModType)
	{
		bLoadingForm = true;
		iDualIndex = pDualIndex;
		iModelType = pModType;
		checked
		{
			if (iModelType == 54)
			{
				((Control)fra_UserDefI).Visible = false;
				((Control)cmdOK).Top = 170;
				((Control)cmdCancel).Top = 170;
				((Control)this).Height = 230;
				((Form)this).Text = "Near-Field/Far-Field Mass Concentration of Chemical in Air (Cm) Selection";
				lblInstructions.Text = "Please select whether you would like to use the Near-Field or Far-Field Mass Concentration of Chemical in Air (Cm):";
				((Control)fra_NearFarI).Visible = true;
				((Control)fra_NearFarI).BringToFront();
				if (Conversions.ToDouble(frmMDUpdExpMod.DefInstance.lblCmCvOption[iDualIndex].Text) == 154.0)
				{
					_optCm_NF_1.Checked = true;
				}
				else if (Conversions.ToDouble(frmMDUpdExpMod.DefInstance.lblCmCvOption[iDualIndex].Text) == 153.0)
				{
					_optCm_NF_0.Checked = true;
				}
				else if (iDualIndex == 0)
				{
					_optCm_NF_0.Checked = true;
				}
				else
				{
					_optCm_NF_1.Checked = true;
				}
				short num = (short)(frmMDUpdExpMod.DefInstance.msfExpParms.Rows - 1);
				short num2 = 0;
				while (true)
				{
					short num3 = num2;
					short num4 = num;
					if (num3 <= num4)
					{
						string text = frmMDUpdExpMod.DefInstance.msfExpParms[unchecked((int)num2), 0];
						if (Operators.CompareString(text, Conversions.ToString(153), false) == 0)
						{
							lblCnf.Text = frmMDUpdExpMod.DefInstance.msfExpParms[unchecked((int)num2), frmMDUpdExpMod.DefInstance.msfExpParms.Col + 2];
						}
						else if (Operators.CompareString(text, Conversions.ToString(154), false) == 0)
						{
							lblCff.Text = frmMDUpdExpMod.DefInstance.msfExpParms[unchecked((int)num2), frmMDUpdExpMod.DefInstance.msfExpParms.Col + 2];
						}
						else if (Operators.CompareString(text, Conversions.ToString(64), false) == 0)
						{
							iCmRow = num2;
						}
						num2 = (short)unchecked(num2 + 1);
						continue;
					}
					break;
				}
			}
			else
			{
				((Control)fra_NearFarI).Visible = false;
				((Form)this).Text = "Mass Concentration of Chemical in Air (Cm) Calculation Screen";
				((Control)this).Height = 352;
				((Control)cmdOK).Top = 289;
				((Control)cmdCancel).Top = 289;
				lblInstructions.Text = "You may use this window to update the Mass Concentration of Chemical in Air (Cm) for this model";
				((Control)fra_UserDefI).Visible = true;
				((Control)fra_UserDefI).BringToFront();
				short num5 = (short)(frmMDUpdExpMod.DefInstance.msfExpParms.Rows - 1);
				short num2 = 0;
				while (true)
				{
					short num6 = num2;
					short num4 = num5;
					if (num6 > num4)
					{
						break;
					}
					string text2 = frmMDUpdExpMod.DefInstance.msfExpParms[unchecked((int)num2), 0];
					if (Operators.CompareString(text2, Conversions.ToString(67), false) == 0)
					{
						txtCv.Text = frmMDUpdExpMod.DefInstance.msfExpParms[unchecked((int)num2), frmMDUpdExpMod.DefInstance.msfExpParms.Col + 2];
						iCvRow = num2;
					}
					else if (Operators.CompareString(text2, Conversions.ToString(5), false) == 0)
					{
						lblMW.Text = frmMDUpdExpMod.DefInstance.msfExpParms[unchecked((int)num2), frmMDUpdExpMod.DefInstance.msfExpParms.Col + 2];
					}
					else if (Operators.CompareString(text2, Conversions.ToString(63), false) == 0)
					{
						lblVm.Text = frmMDUpdExpMod.DefInstance.msfExpParms[unchecked((int)num2), frmMDUpdExpMod.DefInstance.msfExpParms.Col + 2];
					}
					else if (Operators.CompareString(text2, Conversions.ToString(78), false) == 0)
					{
						lblYs.Text = frmMDUpdExpMod.DefInstance.msfExpParms[unchecked((int)num2), frmMDUpdExpMod.DefInstance.msfExpParms.Col + 2];
					}
					else if (Operators.CompareString(text2, Conversions.ToString(64), false) == 0)
					{
						txtCm.Text = frmMDUpdExpMod.DefInstance.msfExpParms[unchecked((int)num2), frmMDUpdExpMod.DefInstance.msfExpParms.Col + 2];
						iCmRow = num2;
					}
					num2 = (short)unchecked(num2 + 1);
				}
				if (iDualIndex == 0)
				{
					if (Conversions.ToInteger(frmMDUpdExpMod.DefInstance._lblCmCvOption_0.Text) == 0)
					{
						_optCm_0.Checked = true;
					}
					else
					{
						_optCm_1.Checked = true;
					}
				}
				else if (Conversions.ToInteger(frmMDUpdExpMod.DefInstance._lblCmCvOption_1.Text) == 0)
				{
					_optCm_0.Checked = true;
				}
				else
				{
					_optCm_1.Checked = true;
				}
			}
			bLoadingForm = false;
			return true;
		}
	}

	private void optCm_CheckedChanged(object eventSender, EventArgs eventArgs)
	{
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		if (!Conversions.ToBoolean(NewLateBinding.LateGet(eventSender, (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			return;
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(eventSender, (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"_optCm_0", false))
		{
			iOption = 0;
			txtCm.Text = "";
			((Control)txtCm).Enabled = false;
			((Control)txtCv).Enabled = true;
			((TextBoxBase)txtCm).BackColor = ((Form)this).BackColor;
			((TextBoxBase)txtCv).BackColor = Color.White;
			Label obj = lblCM;
			object pCv = txtCv;
			object pMW = lblMW;
			object pVm = lblVm;
			object pYs = lblYs;
			string text = ChemStrX.CalcCm(ref pCv, ref pMW, ref pVm, ref pYs);
			lblYs = (Label)pYs;
			lblVm = (Label)pVm;
			lblMW = (Label)pMW;
			txtCv = (TextBox)pCv;
			obj.Text = text;
			if ((Operators.CompareString(lblCM.Text, "0", false) == 0) & (Operators.CompareString(lblVm.Text, "0", false) == 0))
			{
				lblCM.Text = "";
			}
		}
		else
		{
			iOption = 1;
			bLoadingForm = true;
			txtCv.Text = "0";
			bLoadingForm = false;
			lblCM.Text = "";
			((Control)txtCm).Enabled = true;
			((Control)txtCv).Enabled = false;
			((TextBoxBase)txtCm).BackColor = Color.White;
			((TextBoxBase)txtCv).BackColor = ((Form)this).BackColor;
		}
	}

	private void txtCm_TextChanged(object eventSender, EventArgs eventArgs)
	{
		if (Strings.Len(txtCm.Text) > 0 && Versioned.IsNumeric((object)txtCm.Text))
		{
			short pID = 64;
			TextBox val = txtCm;
			object pValue = val.Text;
			short pModType = 0;
			ChemStrX.ValidateParmInput(ref pID, ref pValue, ref pModType);
			val.Text = Conversions.ToString(pValue);
		}
	}

	private void txtCv_TextChanged(object eventSender, EventArgs eventArgs)
	{
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		lblCM.Text = "";
		if (Strings.Len(txtCv.Text) <= 0)
		{
			return;
		}
		if (Versioned.IsNumeric((object)txtCv.Text))
		{
			if ((Operators.CompareString(lblVm.Text, "0", false) == 0) | (Operators.CompareString(lblVm.Text, "", false) == 0))
			{
				if (!bLoadingForm)
				{
					Interaction.Beep();
					Interaction.MsgBox((object)"Please specify a Vm value before attempting to derive Cm using this option", (MsgBoxStyle)64, (object)"Required Information Missiong");
				}
				return;
			}
			short pID = 67;
			TextBox val = txtCv;
			object pValue = val.Text;
			short pModType = 0;
			bool num = ChemStrX.ValidateParmInput(ref pID, ref pValue, ref pModType);
			val.Text = Conversions.ToString(pValue);
			if (num)
			{
				Label obj = lblCM;
				TextBox val2 = txtCv;
				object pCv = val2.Text;
				Label val3 = lblMW;
				object pMW = val3.Text;
				Label val4 = lblVm;
				object pVm = val4.Text;
				Label val5 = lblYs;
				object pYs = val5.Text;
				string text = ChemStrX.CalcCm(ref pCv, ref pMW, ref pVm, ref pYs);
				val5.Text = Conversions.ToString(pYs);
				val4.Text = Conversions.ToString(pVm);
				val3.Text = Conversions.ToString(pMW);
				val2.Text = Conversions.ToString(pCv);
				obj.Text = text;
			}
		}
		else if (!bLoadingForm)
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Please enter a valid, numeric Cv.", (MsgBoxStyle)64, (object)"Invalid Input");
		}
	}

	private void cmdOK_Click1(object sender, EventArgs e)
	{
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		if (iModelType == 54)
		{
			if (_optCm_NF_1.Checked)
			{
				frmMDUpdExpMod.DefInstance.msfExpParms[(int)iCmRow, checked(frmMDUpdExpMod.DefInstance.msfExpParms.Col + 2)] = lblCff.Text;
				frmMDUpdExpMod.DefInstance.msfExpParms[(int)iCmRow, checked(frmMDUpdExpMod.DefInstance.msfExpParms.Col + 1)] = "Far-Field";
				frmMDUpdExpMod.DefInstance.lblCmCvOption[iDualIndex].Text = Conversions.ToString(154);
			}
			else
			{
				frmMDUpdExpMod.DefInstance.msfExpParms[(int)iCmRow, checked(frmMDUpdExpMod.DefInstance.msfExpParms.Col + 2)] = lblCnf.Text;
				frmMDUpdExpMod.DefInstance.msfExpParms[(int)iCmRow, checked(frmMDUpdExpMod.DefInstance.msfExpParms.Col + 1)] = "Near-Field";
				frmMDUpdExpMod.DefInstance.lblCmCvOption[iDualIndex].Text = Conversions.ToString(153);
			}
		}
		else
		{
			if (_optCm_0.Checked)
			{
				if (!Versioned.IsNumeric((object)lblCM.Text))
				{
					Interaction.Beep();
					Interaction.MsgBox((object)"Please enter a valid Cm or switch Cm options", (MsgBoxStyle)64, (object)"Invalid Input");
					return;
				}
				short pID = 64;
				Label val = lblCM;
				object pValue = val.Text;
				short pModType = 0;
				bool num = ChemStrX.ValidateParmInput(ref pID, ref pValue, ref pModType);
				val.Text = Conversions.ToString(pValue);
				if (!num)
				{
					return;
				}
				frmMDUpdExpMod.DefInstance.msfExpParms[(int)iCmRow, checked(frmMDUpdExpMod.DefInstance.msfExpParms.Col + 2)] = lblCM.Text;
				frmMDUpdExpMod.DefInstance.msfExpParms[(int)iCmRow, checked(frmMDUpdExpMod.DefInstance.msfExpParms.Col + 1)] = "Model Parm";
				frmMDUpdExpMod.DefInstance.msfExpParms[(int)iCmRow, frmMDUpdExpMod.DefInstance.msfExpParms.Col] = "Default";
			}
			else
			{
				if (!Versioned.IsNumeric((object)txtCm.Text))
				{
					Interaction.Beep();
					Interaction.MsgBox((object)"Please enter a valid Cm or switch Cm options", (MsgBoxStyle)64, (object)"Invalid Input");
					return;
				}
				short pModType = 64;
				TextBox val2 = txtCm;
				object pValue = val2.Text;
				short pID = 0;
				bool num2 = ChemStrX.ValidateParmInput(ref pModType, ref pValue, ref pID);
				val2.Text = Conversions.ToString(pValue);
				if (!num2)
				{
					return;
				}
				frmMDUpdExpMod.DefInstance.msfExpParms[(int)iCmRow, checked(frmMDUpdExpMod.DefInstance.msfExpParms.Col + 2)] = txtCm.Text;
				frmMDUpdExpMod.DefInstance.msfExpParms[(int)iCmRow, checked(frmMDUpdExpMod.DefInstance.msfExpParms.Col + 1)] = "User-defined";
				frmMDUpdExpMod.DefInstance.msfExpParms[(int)iCmRow, frmMDUpdExpMod.DefInstance.msfExpParms.Col] = "Non-default";
			}
			frmMDUpdExpMod.DefInstance.msfExpParms[(int)iCvRow, checked(frmMDUpdExpMod.DefInstance.msfExpParms.Col + 2)] = txtCv.Text;
			frmMDUpdExpMod.DefInstance.lblCmCvOption[iDualIndex].Text = Conversions.ToString((int)iOption);
		}
		((Form)this).Close();
	}

	private void cmdCancel_Click1(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void _optCm_NF_0_CheckedChanged(object sender, EventArgs e)
	{
	}
}
