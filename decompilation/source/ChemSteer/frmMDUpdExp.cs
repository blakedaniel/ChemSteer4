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

internal class frmMDUpdExp : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("txtNumExpEstBasis")]
	private TextBox _txtNumExpEstBasis;

	[AccessedThroughProperty("txtNumExpEst")]
	private TextBox _txtNumExpEst;

	[AccessedThroughProperty("_cmbOption_4")]
	private ComboBox __cmbOption_4;

	[AccessedThroughProperty("_cmbOption_3")]
	private ComboBox __cmbOption_3;

	[AccessedThroughProperty("_cmbOption_2")]
	private ComboBox __cmbOption_2;

	[AccessedThroughProperty("_cmbOption_1")]
	private ComboBox __cmbOption_1;

	[AccessedThroughProperty("_cmbOption_0")]
	private ComboBox __cmbOption_0;

	[AccessedThroughProperty("txtNumExp")]
	private TextBox _txtNumExp;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("cmdOk")]
	private Button _cmdOk;

	[AccessedThroughProperty("_Label1_2")]
	private Label __Label1_2;

	[AccessedThroughProperty("_Label1_1")]
	private Label __Label1_1;

	[AccessedThroughProperty("_Label1_0")]
	private Label __Label1_0;

	[AccessedThroughProperty("lblInstructions")]
	private Label _lblInstructions;

	[AccessedThroughProperty("_Label1_45")]
	private Label __Label1_45;

	[AccessedThroughProperty("_Label1_46")]
	private Label __Label1_46;

	[AccessedThroughProperty("_Label1_47")]
	private Label __Label1_47;

	[AccessedThroughProperty("_lblGT100WorkersW1to10_48")]
	private Label __lblGT100WorkersW1to10_48;

	[AccessedThroughProperty("_Label1_49")]
	private Label __Label1_49;

	[AccessedThroughProperty("Label1")]
	private LabelArray _Label1;

	[AccessedThroughProperty("cmbOption")]
	private ComboBoxArray _cmbOption;

	[AccessedThroughProperty("lblGT100WorkersW1to10")]
	private LabelArray _lblGT100WorkersW1to10;

	private static frmMDUpdExp m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	public virtual TextBox txtNumExpEstBasis
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNumExpEstBasis;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtNumExpEstBasis_Enter;
			if (_txtNumExpEstBasis != null)
			{
				((Control)_txtNumExpEstBasis).Enter -= eventHandler;
			}
			_txtNumExpEstBasis = value;
			if (_txtNumExpEstBasis != null)
			{
				((Control)_txtNumExpEstBasis).Enter += eventHandler;
			}
		}
	}

	public virtual TextBox txtNumExpEst
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNumExpEst;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtNumExpEst_Leave;
			EventHandler eventHandler2 = txtNumExpEst_Enter;
			if (_txtNumExpEst != null)
			{
				((Control)_txtNumExpEst).Leave -= eventHandler;
				((Control)_txtNumExpEst).Enter -= eventHandler2;
			}
			_txtNumExpEst = value;
			if (_txtNumExpEst != null)
			{
				((Control)_txtNumExpEst).Leave += eventHandler;
				((Control)_txtNumExpEst).Enter += eventHandler2;
			}
		}
	}

	public virtual ComboBox _cmbOption_4
	{
		[DebuggerNonUserCode]
		get
		{
			return __cmbOption_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__cmbOption_4 = value;
		}
	}

	public virtual ComboBox _cmbOption_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __cmbOption_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__cmbOption_3 = value;
		}
	}

	public virtual ComboBox _cmbOption_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __cmbOption_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__cmbOption_2 = value;
		}
	}

	public virtual ComboBox _cmbOption_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __cmbOption_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__cmbOption_1 = value;
		}
	}

	public virtual ComboBox _cmbOption_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __cmbOption_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__cmbOption_0 = value;
		}
	}

	public virtual TextBox txtNumExp
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNumExp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNumExp = value;
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

	public virtual Label _Label1_45
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_45;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_45 = value;
		}
	}

	public virtual Label _Label1_46
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_46;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_46 = value;
		}
	}

	public virtual Label _Label1_47
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_47;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_47 = value;
		}
	}

	public virtual Label _lblGT100WorkersW1to10_48
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblGT100WorkersW1to10_48;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblGT100WorkersW1to10_48 = value;
		}
	}

	public virtual Label _Label1_49
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_49;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_49 = value;
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

	public virtual ComboBoxArray cmbOption
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbOption;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cmbOption = value;
		}
	}

	public virtual LabelArray lblGT100WorkersW1to10
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblGT100WorkersW1to10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblGT100WorkersW1to10 = value;
		}
	}

	public static frmMDUpdExp DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmMDUpdExp();
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

	public frmMDUpdExp()
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
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected O, but got Unknown
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected O, but got Unknown
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Expected O, but got Unknown
		//IL_0571: Unknown result type (might be due to invalid IL or missing references)
		//IL_057b: Expected O, but got Unknown
		//IL_0675: Unknown result type (might be due to invalid IL or missing references)
		//IL_067f: Expected O, but got Unknown
		//IL_0779: Unknown result type (might be due to invalid IL or missing references)
		//IL_0783: Expected O, but got Unknown
		//IL_087d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0887: Expected O, but got Unknown
		//IL_0956: Unknown result type (might be due to invalid IL or missing references)
		//IL_0960: Expected O, but got Unknown
		//IL_0a2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a34: Expected O, but got Unknown
		//IL_0afd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b07: Expected O, but got Unknown
		//IL_0be4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bee: Expected O, but got Unknown
		//IL_0cc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd2: Expected O, but got Unknown
		//IL_0dac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db6: Expected O, but got Unknown
		//IL_0e6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e78: Expected O, but got Unknown
		//IL_0f53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f5d: Expected O, but got Unknown
		//IL_103b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1045: Expected O, but got Unknown
		//IL_1123: Unknown result type (might be due to invalid IL or missing references)
		//IL_112d: Expected O, but got Unknown
		//IL_120a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1214: Expected O, but got Unknown
		//IL_1482: Unknown result type (might be due to invalid IL or missing references)
		//IL_148c: Expected O, but got Unknown
		//IL_14a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ab: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMDUpdExp));
		ToolTip1 = new ToolTip(components);
		txtNumExpEstBasis = new TextBox();
		txtNumExpEst = new TextBox();
		_cmbOption_4 = new ComboBox();
		_cmbOption_3 = new ComboBox();
		_cmbOption_2 = new ComboBox();
		_cmbOption_1 = new ComboBox();
		_cmbOption_0 = new ComboBox();
		txtNumExp = new TextBox();
		cmdCancel = new Button();
		cmdOk = new Button();
		_Label1_2 = new Label();
		_Label1_1 = new Label();
		_Label1_0 = new Label();
		lblInstructions = new Label();
		_Label1_45 = new Label();
		_Label1_46 = new Label();
		_Label1_47 = new Label();
		_lblGT100WorkersW1to10_48 = new Label();
		_Label1_49 = new Label();
		Label1 = new LabelArray(components);
		cmbOption = new ComboBoxArray(components);
		lblGT100WorkersW1to10 = new LabelArray(components);
		((ISupportInitialize)Label1).BeginInit();
		((ISupportInitialize)cmbOption).BeginInit();
		((ISupportInitialize)lblGT100WorkersW1to10).BeginInit();
		((Control)this).SuspendLayout();
		txtNumExpEstBasis.AcceptsReturn = true;
		((TextBoxBase)txtNumExpEstBasis).BackColor = SystemColors.InactiveBorder;
		((Control)txtNumExpEstBasis).Cursor = Cursors.IBeam;
		((Control)txtNumExpEstBasis).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtNumExpEstBasis).ForeColor = SystemColors.WindowText;
		TextBox obj = txtNumExpEstBasis;
		Point location = new Point(344, 144);
		((Control)obj).Location = location;
		((TextBoxBase)txtNumExpEstBasis).MaxLength = 0;
		txtNumExpEstBasis.Multiline = true;
		((Control)txtNumExpEstBasis).Name = "txtNumExpEstBasis";
		((Control)txtNumExpEstBasis).RightToLeft = (RightToLeft)0;
		txtNumExpEstBasis.ScrollBars = (ScrollBars)2;
		TextBox obj2 = txtNumExpEstBasis;
		Size size = new Size(273, 41);
		((Control)obj2).Size = size;
		((Control)txtNumExpEstBasis).TabIndex = 3;
		txtNumExpEst.AcceptsReturn = true;
		((TextBoxBase)txtNumExpEst).BackColor = SystemColors.Window;
		((Control)txtNumExpEst).Cursor = Cursors.IBeam;
		((Control)txtNumExpEst).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtNumExpEst).ForeColor = SystemColors.WindowText;
		TextBox obj3 = txtNumExpEst;
		location = new Point(344, 112);
		((Control)obj3).Location = location;
		((TextBoxBase)txtNumExpEst).MaxLength = 5;
		((Control)txtNumExpEst).Name = "txtNumExpEst";
		((Control)txtNumExpEst).RightToLeft = (RightToLeft)0;
		TextBox obj4 = txtNumExpEst;
		size = new Size(49, 20);
		((Control)obj4).Size = size;
		((Control)txtNumExpEst).TabIndex = 2;
		_cmbOption_4.BackColor = SystemColors.Window;
		((Control)_cmbOption_4).Cursor = Cursors.Default;
		_cmbOption_4.DropDownStyle = (ComboBoxStyle)2;
		((Control)_cmbOption_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		_cmbOption_4.ForeColor = SystemColors.WindowText;
		cmbOption.SetIndex(_cmbOption_4, (short)4);
		_cmbOption_4.Items.AddRange(new object[2] { "No", "Yes" });
		ComboBox cmbOption_ = _cmbOption_4;
		location = new Point(344, 48);
		((Control)cmbOption_).Location = location;
		((Control)_cmbOption_4).Name = "_cmbOption_4";
		((Control)_cmbOption_4).RightToLeft = (RightToLeft)0;
		ComboBox cmbOption_2 = _cmbOption_4;
		size = new Size(57, 22);
		((Control)cmbOption_2).Size = size;
		((Control)_cmbOption_4).TabIndex = 0;
		_cmbOption_3.BackColor = SystemColors.Window;
		((Control)_cmbOption_3).Cursor = Cursors.Default;
		_cmbOption_3.DropDownStyle = (ComboBoxStyle)2;
		((Control)_cmbOption_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		_cmbOption_3.ForeColor = SystemColors.WindowText;
		cmbOption.SetIndex(_cmbOption_3, (short)3);
		_cmbOption_3.Items.AddRange(new object[2] { "No", "Yes" });
		ComboBox cmbOption_3 = _cmbOption_3;
		location = new Point(344, 296);
		((Control)cmbOption_3).Location = location;
		((Control)_cmbOption_3).Name = "_cmbOption_3";
		((Control)_cmbOption_3).RightToLeft = (RightToLeft)0;
		ComboBox cmbOption_4 = _cmbOption_3;
		size = new Size(57, 22);
		((Control)cmbOption_4).Size = size;
		((Control)_cmbOption_3).TabIndex = 7;
		_cmbOption_2.BackColor = SystemColors.Window;
		((Control)_cmbOption_2).Cursor = Cursors.Default;
		_cmbOption_2.DropDownStyle = (ComboBoxStyle)2;
		((Control)_cmbOption_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		_cmbOption_2.ForeColor = SystemColors.WindowText;
		cmbOption.SetIndex(_cmbOption_2, (short)2);
		_cmbOption_2.Items.AddRange(new object[2] { "No", "Yes" });
		ComboBox cmbOption_5 = _cmbOption_2;
		location = new Point(344, 264);
		((Control)cmbOption_5).Location = location;
		((Control)_cmbOption_2).Name = "_cmbOption_2";
		((Control)_cmbOption_2).RightToLeft = (RightToLeft)0;
		ComboBox cmbOption_6 = _cmbOption_2;
		size = new Size(57, 22);
		((Control)cmbOption_6).Size = size;
		((Control)_cmbOption_2).TabIndex = 6;
		_cmbOption_1.BackColor = SystemColors.Window;
		((Control)_cmbOption_1).Cursor = Cursors.Default;
		_cmbOption_1.DropDownStyle = (ComboBoxStyle)2;
		((Control)_cmbOption_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		_cmbOption_1.ForeColor = SystemColors.WindowText;
		cmbOption.SetIndex(_cmbOption_1, (short)1);
		_cmbOption_1.Items.AddRange(new object[2] { "No", "Yes" });
		ComboBox cmbOption_7 = _cmbOption_1;
		location = new Point(344, 232);
		((Control)cmbOption_7).Location = location;
		((Control)_cmbOption_1).Name = "_cmbOption_1";
		((Control)_cmbOption_1).RightToLeft = (RightToLeft)0;
		ComboBox cmbOption_8 = _cmbOption_1;
		size = new Size(57, 22);
		((Control)cmbOption_8).Size = size;
		((Control)_cmbOption_1).TabIndex = 5;
		_cmbOption_0.BackColor = SystemColors.Window;
		((Control)_cmbOption_0).Cursor = Cursors.Default;
		_cmbOption_0.DropDownStyle = (ComboBoxStyle)2;
		((Control)_cmbOption_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		_cmbOption_0.ForeColor = SystemColors.WindowText;
		cmbOption.SetIndex(_cmbOption_0, (short)0);
		_cmbOption_0.Items.AddRange(new object[2] { "No", "Yes" });
		ComboBox cmbOption_9 = _cmbOption_0;
		location = new Point(344, 200);
		((Control)cmbOption_9).Location = location;
		((Control)_cmbOption_0).Name = "_cmbOption_0";
		((Control)_cmbOption_0).RightToLeft = (RightToLeft)0;
		ComboBox cmbOption_10 = _cmbOption_0;
		size = new Size(57, 22);
		((Control)cmbOption_10).Size = size;
		((Control)_cmbOption_0).TabIndex = 4;
		txtNumExp.AcceptsReturn = true;
		((TextBoxBase)txtNumExp).BackColor = SystemColors.InactiveBorder;
		((Control)txtNumExp).Cursor = Cursors.IBeam;
		((Control)txtNumExp).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtNumExp).ForeColor = SystemColors.WindowText;
		TextBox obj5 = txtNumExp;
		location = new Point(344, 80);
		((Control)obj5).Location = location;
		((TextBoxBase)txtNumExp).MaxLength = 5;
		((Control)txtNumExp).Name = "txtNumExp";
		((TextBoxBase)txtNumExp).ReadOnly = true;
		((Control)txtNumExp).RightToLeft = (RightToLeft)0;
		TextBox obj6 = txtNumExp;
		size = new Size(49, 20);
		((Control)obj6).Size = size;
		((Control)txtNumExp).TabIndex = 1;
		((ButtonBase)cmdCancel).BackColor = SystemColors.Control;
		((Control)cmdCancel).Cursor = Cursors.Default;
		cmdCancel.DialogResult = (DialogResult)2;
		((Control)cmdCancel).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCancel).ForeColor = SystemColors.ControlText;
		Button obj7 = cmdCancel;
		location = new Point(320, 336);
		((Control)obj7).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		((Control)cmdCancel).RightToLeft = (RightToLeft)0;
		Button obj8 = cmdCancel;
		size = new Size(81, 25);
		((Control)obj8).Size = size;
		((Control)cmdCancel).TabIndex = 9;
		((ButtonBase)cmdCancel).Text = "Cancel";
		((ButtonBase)cmdCancel).UseVisualStyleBackColor = false;
		((ButtonBase)cmdOk).BackColor = SystemColors.Control;
		((Control)cmdOk).Cursor = Cursors.Default;
		((Control)cmdOk).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdOk).ForeColor = SystemColors.ControlText;
		Button obj9 = cmdOk;
		location = new Point(224, 336);
		((Control)obj9).Location = location;
		((Control)cmdOk).Name = "cmdOk";
		((Control)cmdOk).RightToLeft = (RightToLeft)0;
		Button obj10 = cmdOk;
		size = new Size(81, 25);
		((Control)obj10).Size = size;
		((Control)cmdOk).TabIndex = 8;
		((ButtonBase)cmdOk).Text = "OK";
		((ButtonBase)cmdOk).UseVisualStyleBackColor = false;
		((Control)_Label1_2).BackColor = SystemColors.Control;
		((Control)_Label1_2).Cursor = Cursors.Default;
		((Control)_Label1_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_2).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_2, (short)2);
		Label label1_ = _Label1_2;
		location = new Point(96, 144);
		((Control)label1_).Location = location;
		((Control)_Label1_2).Name = "_Label1_2";
		((Control)_Label1_2).RightToLeft = (RightToLeft)0;
		Label label1_2 = _Label1_2;
		size = new Size(233, 19);
		((Control)label1_2).Size = size;
		((Control)_Label1_2).TabIndex = 18;
		_Label1_2.Text = "Basis:";
		_Label1_2.TextAlign = (ContentAlignment)4;
		((Control)_Label1_1).BackColor = SystemColors.Control;
		((Control)_Label1_1).Cursor = Cursors.Default;
		((Control)_Label1_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_1).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_1, (short)1);
		Label label1_3 = _Label1_1;
		location = new Point(72, 112);
		((Control)label1_3).Location = location;
		((Control)_Label1_1).Name = "_Label1_1";
		((Control)_Label1_1).RightToLeft = (RightToLeft)0;
		Label label1_4 = _Label1_1;
		size = new Size(257, 19);
		((Control)label1_4).Size = size;
		((Control)_Label1_1).TabIndex = 17;
		_Label1_1.Text = "Number of Workers Exposed (estimated): ";
		_Label1_1.TextAlign = (ContentAlignment)4;
		((Control)_Label1_0).BackColor = SystemColors.Control;
		((Control)_Label1_0).Cursor = Cursors.Default;
		((Control)_Label1_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_0).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_0, (short)0);
		Label label1_5 = _Label1_0;
		location = new Point(96, 48);
		((Control)label1_5).Location = location;
		((Control)_Label1_0).Name = "_Label1_0";
		((Control)_Label1_0).RightToLeft = (RightToLeft)0;
		Label label1_6 = _Label1_0;
		size = new Size(233, 19);
		((Control)label1_6).Size = size;
		((Control)_Label1_0).TabIndex = 16;
		_Label1_0.Text = "Exposure Based: ";
		_Label1_0.TextAlign = (ContentAlignment)4;
		((Control)lblInstructions).BackColor = SystemColors.Control;
		((Control)lblInstructions).Cursor = Cursors.Default;
		((Control)lblInstructions).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblInstructions).ForeColor = SystemColors.ControlText;
		Label obj11 = lblInstructions;
		location = new Point(0, 8);
		((Control)obj11).Location = location;
		((Control)lblInstructions).Name = "lblInstructions";
		((Control)lblInstructions).RightToLeft = (RightToLeft)0;
		Label obj12 = lblInstructions;
		size = new Size(409, 33);
		((Control)obj12).Size = size;
		((Control)lblInstructions).TabIndex = 15;
		lblInstructions.Text = "xxx";
		((Control)_Label1_45).BackColor = SystemColors.Control;
		((Control)_Label1_45).Cursor = Cursors.Default;
		((Control)_Label1_45).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_45).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_45, (short)45);
		Label label1_7 = _Label1_45;
		location = new Point(96, 80);
		((Control)label1_7).Location = location;
		((Control)_Label1_45).Name = "_Label1_45";
		((Control)_Label1_45).RightToLeft = (RightToLeft)0;
		Label label1_8 = _Label1_45;
		size = new Size(233, 19);
		((Control)label1_8).Size = size;
		((Control)_Label1_45).TabIndex = 14;
		_Label1_45.Text = "Number of Workers Exposed (default): ";
		_Label1_45.TextAlign = (ContentAlignment)4;
		((Control)_Label1_46).BackColor = SystemColors.Control;
		((Control)_Label1_46).Cursor = Cursors.Default;
		((Control)_Label1_46).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_46).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_46, (short)46);
		Label label1_9 = _Label1_46;
		location = new Point(96, 200);
		((Control)label1_9).Location = location;
		((Control)_Label1_46).Name = "_Label1_46";
		((Control)_Label1_46).RightToLeft = (RightToLeft)0;
		Label label1_10 = _Label1_46;
		size = new Size(233, 19);
		((Control)label1_10).Size = size;
		((Control)_Label1_46).TabIndex = 13;
		_Label1_46.Text = "> 1000 Workers: ";
		_Label1_46.TextAlign = (ContentAlignment)4;
		((Control)_Label1_47).BackColor = SystemColors.Control;
		((Control)_Label1_47).Cursor = Cursors.Default;
		((Control)_Label1_47).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_47).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_47, (short)47);
		Label label1_11 = _Label1_47;
		location = new Point(16, 232);
		((Control)label1_11).Location = location;
		((Control)_Label1_47).Name = "_Label1_47";
		((Control)_Label1_47).RightToLeft = (RightToLeft)0;
		Label label1_12 = _Label1_47;
		size = new Size(313, 19);
		((Control)label1_12).Size = size;
		((Control)_Label1_47).TabIndex = 12;
		_Label1_47.Text = ">100 Workers with >10 mg/day inhalation exposure: ";
		_Label1_47.TextAlign = (ContentAlignment)4;
		((Control)_lblGT100WorkersW1to10_48).BackColor = SystemColors.Control;
		((Control)_lblGT100WorkersW1to10_48).Cursor = Cursors.Default;
		((Control)_lblGT100WorkersW1to10_48).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblGT100WorkersW1to10_48).ForeColor = SystemColors.WindowText;
		lblGT100WorkersW1to10.SetIndex(_lblGT100WorkersW1to10_48, (short)48);
		Label lblGT100WorkersW1to10_ = _lblGT100WorkersW1to10_48;
		location = new Point(8, 264);
		((Control)lblGT100WorkersW1to10_).Location = location;
		((Control)_lblGT100WorkersW1to10_48).Name = "_lblGT100WorkersW1to10_48";
		((Control)_lblGT100WorkersW1to10_48).RightToLeft = (RightToLeft)0;
		Label lblGT100WorkersW1to10_2 = _lblGT100WorkersW1to10_48;
		size = new Size(321, 19);
		((Control)lblGT100WorkersW1to10_2).Size = size;
		((Control)_lblGT100WorkersW1to10_48).TabIndex = 11;
		_lblGT100WorkersW1to10_48.Text = ">100 Workers with 1-10 mg/day exposure for over >100 days/yr: ";
		_lblGT100WorkersW1to10_48.TextAlign = (ContentAlignment)4;
		((Control)_Label1_49).BackColor = SystemColors.Control;
		((Control)_Label1_49).Cursor = Cursors.Default;
		((Control)_Label1_49).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_49).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_49, (short)49);
		Label label1_13 = _Label1_49;
		location = new Point(24, 296);
		((Control)label1_13).Location = location;
		((Control)_Label1_49).Name = "_Label1_49";
		((Control)_Label1_49).RightToLeft = (RightToLeft)0;
		Label label1_14 = _Label1_49;
		size = new Size(305, 19);
		((Control)label1_14).Size = size;
		((Control)_Label1_49).TabIndex = 10;
		_Label1_49.Text = "Routine Dermal Contact for >250 workers over > 100 days/yr: ";
		_Label1_49.TextAlign = (ContentAlignment)4;
		((Form)this).AcceptButton = (IButtonControl)(object)cmdOk;
		size = new Size(5, 13);
		((Form)this).AutoScaleBaseSize = size;
		((Form)this).BackColor = SystemColors.Control;
		((Form)this).CancelButton = (IButtonControl)(object)cmdCancel;
		size = new Size(628, 367);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)txtNumExpEstBasis);
		((Control)this).Controls.Add((Control)(object)txtNumExpEst);
		((Control)this).Controls.Add((Control)(object)_cmbOption_4);
		((Control)this).Controls.Add((Control)(object)_cmbOption_3);
		((Control)this).Controls.Add((Control)(object)_cmbOption_2);
		((Control)this).Controls.Add((Control)(object)_cmbOption_1);
		((Control)this).Controls.Add((Control)(object)_cmbOption_0);
		((Control)this).Controls.Add((Control)(object)txtNumExp);
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)cmdOk);
		((Control)this).Controls.Add((Control)(object)_Label1_2);
		((Control)this).Controls.Add((Control)(object)_Label1_1);
		((Control)this).Controls.Add((Control)(object)_Label1_0);
		((Control)this).Controls.Add((Control)(object)lblInstructions);
		((Control)this).Controls.Add((Control)(object)_Label1_45);
		((Control)this).Controls.Add((Control)(object)_Label1_46);
		((Control)this).Controls.Add((Control)(object)_Label1_47);
		((Control)this).Controls.Add((Control)(object)_lblGT100WorkersW1to10_48);
		((Control)this).Controls.Add((Control)(object)_Label1_49);
		((Control)this).Cursor = Cursors.Default;
		((Control)this).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		location = new Point(250, 150);
		((Form)this).Location = location;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmMDUpdExp";
		((Control)this).RightToLeft = (RightToLeft)0;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Update Exposure-Based Criteria";
		((ISupportInitialize)Label1).EndInit();
		((ISupportInitialize)cmbOption).EndInit();
		((ISupportInitialize)lblGT100WorkersW1to10).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void cmdCancel_Click(object eventSender, EventArgs eventArgs)
	{
		((Form)this).Close();
	}

	private void cmdOk_Click(object eventSender, EventArgs eventArgs)
	{
		UpdateFrmMain();
		Globals_Renamed.gblIWasChanged = true;
		((Form)this).Close();
	}

	public object SetUp()
	{
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
		Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		command.ActiveConnection = Common.MyConn;
		command.CommandText = "pqryGetInstructions";
		command.CommandType = CommandTypeEnum.adCmdStoredProc;
		command.Parameters.Append(command.CreateParameter("pID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, 7));
		Command command2 = command;
		object RecordsAffected = Missing.Value;
		object Parameters = Missing.Value;
		recordset = command2.Execute(out RecordsAffected, ref Parameters);
		command.Parameters.Delete("pID");
		lblInstructions.Text = Conversions.ToString(recordset.Fields[0].Value);
		recordset.Close();
		recordset = null;
		command = null;
		txtNumExp.Text = frmMain.DefInstance.lblNumExp.Text;
		txtNumExpEst.Text = frmMain.DefInstance.lblNumExpEst.Text;
		if (Operators.ConditionalCompareObjectEqual(((Control)frmMain.DefInstance.txtNumExpEstBasis).Tag, (object)"1", false))
		{
			((Control)txtNumExpEstBasis).Enabled = true;
			((TextBoxBase)txtNumExpEstBasis).BackColor = Color.White;
		}
		txtNumExpEstBasis.Text = frmMain.DefInstance.txtNumExpEstBasis.Text;
		checked
		{
			short num = (short)(((BaseControlArray)cmbOption).Count() - 1);
			short num2 = 0;
			while (true)
			{
				short num3 = num2;
				short num4 = num;
				if (num3 > num4)
				{
					break;
				}
				if (Operators.CompareString(frmMain.DefInstance.lblNumWMet[num2].Text, "Yes", false) == 0)
				{
					cmbOption[num2].SelectedIndex = 1;
				}
				else
				{
					cmbOption[num2].SelectedIndex = 0;
				}
				num2 = (short)unchecked(num2 + 1);
			}
			return true;
		}
	}

	private void UpdateFrmMain()
	{
		frmMain.DefInstance.lblNumExp.Text = txtNumExp.Text;
		frmMain.DefInstance.lblNumExpEst.Text = txtNumExpEst.Text;
		frmMain.DefInstance.txtNumExpEstBasis.Text = txtNumExpEstBasis.Text;
		if (ColorTranslator.ToOle(((TextBoxBase)txtNumExpEstBasis).BackColor) == ColorTranslator.ToOle(Color.White))
		{
			((Control)frmMain.DefInstance.txtNumExpEstBasis).Tag = 1;
		}
		else
		{
			((Control)frmMain.DefInstance.txtNumExpEstBasis).Tag = 0;
		}
		checked
		{
			short num = (short)(((BaseControlArray)frmMain.DefInstance.lblNumWMet).Count() - 1);
			short num2 = 0;
			while (true)
			{
				short num3 = num2;
				short num4 = num;
				if (num3 > num4)
				{
					break;
				}
				frmMain.DefInstance.lblNumWMet[num2].Text = Conversions.ToString(Interaction.IIf(cmbOption[num2].SelectedIndex == 1, (object)"Yes", (object)"No"));
				num2 = (short)unchecked(num2 + 1);
			}
			ChemStrX.resetExpBasedCriteria();
		}
	}

	private void txtNumExpEst_Enter(object eventSender, EventArgs eventArgs)
	{
		((TextBoxBase)txtNumExpEstBasis).BackColor = Color.White;
	}

	private void txtNumExpEst_Leave(object eventSender, EventArgs eventArgs)
	{
		if (Versioned.IsNumeric((object)txtNumExpEst.Text))
		{
			if (Conversions.ToInteger(txtNumExpEst.Text) > 1000)
			{
				cmbOption[(short)0].SelectedIndex = 1;
			}
			else
			{
				cmbOption[(short)0].SelectedIndex = 0;
			}
		}
	}

	private void txtNumExpEstBasis_Enter(object eventSender, EventArgs eventArgs)
	{
		((TextBoxBase)txtNumExpEstBasis).BackColor = Color.White;
	}
}
