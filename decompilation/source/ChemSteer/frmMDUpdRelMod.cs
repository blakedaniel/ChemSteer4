using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ADODB;
using AxMSFlexGridLib;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Compatibility.VB6;
using Microsoft.VisualBasic.CompilerServices;

namespace ChemSteer;

internal class frmMDUpdRelMod : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("_txtChar_1")]
	private TextBox __txtChar_1;

	[AccessedThroughProperty("_txtChar_0")]
	private TextBox __txtChar_0;

	[AccessedThroughProperty("_cmbChar_1")]
	private ComboBox __cmbChar_1;

	[AccessedThroughProperty("_chkOutputOn_1")]
	private CheckBox __chkOutputOn_1;

	[AccessedThroughProperty("_cmbChar_0")]
	private ComboBox __cmbChar_0;

	[AccessedThroughProperty("_chkOutputOn_0")]
	private CheckBox __chkOutputOn_0;

	[AccessedThroughProperty("cmbInput")]
	private ComboBox _cmbInput;

	[AccessedThroughProperty("txtEquation")]
	private TextBox _txtEquation;

	[AccessedThroughProperty("txtInput")]
	private TextBox _txtInput;

	[AccessedThroughProperty("txtBasis")]
	private TextBox _txtBasis;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("cmdOk")]
	private Button _cmdOk;

	[AccessedThroughProperty("msfRelParms")]
	private AxMSFlexGrid _msfRelParms;

	[AccessedThroughProperty("_Label1_4")]
	private Label __Label1_4;

	[AccessedThroughProperty("_Label1_5")]
	private Label __Label1_5;

	[AccessedThroughProperty("lblMechanism")]
	private Label _lblMechanism;

	[AccessedThroughProperty("_Label1_3")]
	private Label __Label1_3;

	[AccessedThroughProperty("_Label1_2")]
	private Label __Label1_2;

	[AccessedThroughProperty("lblModelName")]
	private Label _lblModelName;

	[AccessedThroughProperty("lblAct")]
	private Label _lblAct;

	[AccessedThroughProperty("_Label1_1")]
	private Label __Label1_1;

	[AccessedThroughProperty("_Label1_0")]
	private Label __Label1_0;

	[AccessedThroughProperty("lblInstructions")]
	private Label _lblInstructions;

	[AccessedThroughProperty("Label1")]
	private LabelArray _Label1;

	[AccessedThroughProperty("chkOutputOn")]
	private CheckBoxArray _chkOutputOn;

	[AccessedThroughProperty("cmbChar")]
	private ComboBoxArray _cmbChar;

	[AccessedThroughProperty("CachedIRERcomb1")]
	private CachedIRERcomb _CachedIRERcomb1;

	[AccessedThroughProperty("txtChar")]
	private TextBoxArray _txtChar;

	private static frmMDUpdRelMod m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	private short MyModelType;

	private float[,,] COFarRelModParmsV;

	private short iDualIndex;

	private short iColIndex;

	private const short col_ParmID = 0;

	private const short col_Name = 1;

	private const short col_Units = 10;

	private const short col_Type1 = 2;

	private const short col_Origin1 = 3;

	private const short col_Value1 = 4;

	private const short col_VC1 = 5;

	private const short col_Type2 = 6;

	private const short col_Origin2 = 7;

	private const short col_Value2 = 8;

	private const short col_VC2 = 9;

	private bool bAdjustMediaOfRelease;

	private short iMofParmID1;

	private short iMofParmID2;

	private short iMofRow1;

	private short iMofRow2;

	private object myMediaControlParm1;

	private object myMediaControlParm2;

	private bool bLoadingForm;

	public virtual TextBox _txtChar_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtChar_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtChar_1 = value;
		}
	}

	public virtual TextBox _txtChar_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtChar_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtChar_0 = value;
		}
	}

	public virtual ComboBox _cmbChar_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __cmbChar_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__cmbChar_1 = value;
		}
	}

	public virtual CheckBox _chkOutputOn_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __chkOutputOn_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__chkOutputOn_1 = value;
		}
	}

	public virtual ComboBox _cmbChar_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __cmbChar_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__cmbChar_0 = value;
		}
	}

	public virtual CheckBox _chkOutputOn_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __chkOutputOn_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__chkOutputOn_0 = value;
		}
	}

	public virtual ComboBox cmbInput
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbInput;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmbInput_Leave;
			EventHandler eventHandler2 = cmbInput_SelectedIndexChanged;
			if (_cmbInput != null)
			{
				((Control)_cmbInput).Leave -= eventHandler;
				_cmbInput.SelectedIndexChanged -= eventHandler2;
			}
			_cmbInput = value;
			if (_cmbInput != null)
			{
				((Control)_cmbInput).Leave += eventHandler;
				_cmbInput.SelectedIndexChanged += eventHandler2;
			}
		}
	}

	public virtual TextBox txtEquation
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtEquation;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtEquation_TextChanged;
			if (_txtEquation != null)
			{
				((Control)_txtEquation).TextChanged -= eventHandler;
			}
			_txtEquation = value;
			if (_txtEquation != null)
			{
				((Control)_txtEquation).TextChanged += eventHandler;
			}
		}
	}

	public virtual TextBox txtInput
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtInput;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtInput_Leave;
			EventHandler eventHandler2 = txtInput_Enter;
			EventHandler eventHandler3 = txtInput_TextChanged;
			if (_txtInput != null)
			{
				((Control)_txtInput).Leave -= eventHandler;
				((Control)_txtInput).Enter -= eventHandler2;
				((Control)_txtInput).TextChanged -= eventHandler3;
			}
			_txtInput = value;
			if (_txtInput != null)
			{
				((Control)_txtInput).Leave += eventHandler;
				((Control)_txtInput).Enter += eventHandler2;
				((Control)_txtInput).TextChanged += eventHandler3;
			}
		}
	}

	public virtual TextBox txtBasis
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtBasis;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtBasis_Leave;
			if (_txtBasis != null)
			{
				((Control)_txtBasis).Leave -= eventHandler;
			}
			_txtBasis = value;
			if (_txtBasis != null)
			{
				((Control)_txtBasis).Leave += eventHandler;
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

	public virtual AxMSFlexGrid msfRelParms
	{
		[DebuggerNonUserCode]
		get
		{
			return _msfRelParms;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = msfRelParms_Enter;
			EventHandler eventHandler2 = msfRelParms_ClickEvent;
			if (_msfRelParms != null)
			{
				((Control)_msfRelParms).Enter -= eventHandler;
				_msfRelParms.ClickEvent -= eventHandler2;
			}
			_msfRelParms = value;
			if (_msfRelParms != null)
			{
				((Control)_msfRelParms).Enter += eventHandler;
				_msfRelParms.ClickEvent += eventHandler2;
			}
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

	public virtual Label lblMechanism
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMechanism;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMechanism = value;
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

	public virtual Label lblModelName
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblModelName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblModelName = value;
		}
	}

	public virtual Label lblAct
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblAct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblAct = value;
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

	public virtual CheckBoxArray chkOutputOn
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkOutputOn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = chkOutputOn_CheckStateChanged;
			if (_chkOutputOn != null)
			{
				_chkOutputOn.CheckStateChanged -= eventHandler;
			}
			_chkOutputOn = value;
			if (_chkOutputOn != null)
			{
				_chkOutputOn.CheckStateChanged += eventHandler;
			}
		}
	}

	public virtual ComboBoxArray cmbChar
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbChar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmbChar_SelectedIndexChanged;
			if (_cmbChar != null)
			{
				_cmbChar.SelectedIndexChanged -= eventHandler;
			}
			_cmbChar = value;
			if (_cmbChar != null)
			{
				_cmbChar.SelectedIndexChanged += eventHandler;
			}
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

	public virtual TextBoxArray txtChar
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtChar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtChar = value;
		}
	}

	public static frmMDUpdRelMod DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmMDUpdRelMod();
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

	public frmMDUpdRelMod()
	{
		__ENCAddToList(this);
		COFarRelModParmsV = new float[2, 2, 2];
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
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected O, but got Unknown
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected O, but got Unknown
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Expected O, but got Unknown
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d5: Expected O, but got Unknown
		//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cb: Expected O, but got Unknown
		//IL_0689: Unknown result type (might be due to invalid IL or missing references)
		//IL_0693: Expected O, but got Unknown
		//IL_078b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0795: Expected O, but got Unknown
		//IL_0858: Unknown result type (might be due to invalid IL or missing references)
		//IL_0862: Expected O, but got Unknown
		//IL_095d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0967: Expected O, but got Unknown
		//IL_0a37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a41: Expected O, but got Unknown
		//IL_0b20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2a: Expected O, but got Unknown
		//IL_0bf4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfe: Expected O, but got Unknown
		//IL_0cd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cda: Expected O, but got Unknown
		//IL_0d3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d47: Expected O, but got Unknown
		//IL_0e13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1d: Expected O, but got Unknown
		//IL_0ef7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f01: Expected O, but got Unknown
		//IL_0fc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fcb: Expected O, but got Unknown
		//IL_10a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ae: Expected O, but got Unknown
		//IL_118a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1194: Expected O, but got Unknown
		//IL_124e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1258: Expected O, but got Unknown
		//IL_1312: Unknown result type (might be due to invalid IL or missing references)
		//IL_131c: Expected O, but got Unknown
		//IL_13f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_13fc: Expected O, but got Unknown
		//IL_14d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_14dc: Expected O, but got Unknown
		//IL_175f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1769: Expected O, but got Unknown
		//IL_177e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1788: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMDUpdRelMod));
		ToolTip1 = new ToolTip(components);
		_txtChar_1 = new TextBox();
		_txtChar_0 = new TextBox();
		_cmbChar_1 = new ComboBox();
		_chkOutputOn_1 = new CheckBox();
		_cmbChar_0 = new ComboBox();
		_chkOutputOn_0 = new CheckBox();
		cmbInput = new ComboBox();
		txtEquation = new TextBox();
		txtInput = new TextBox();
		txtBasis = new TextBox();
		cmdCancel = new Button();
		cmdOk = new Button();
		msfRelParms = new AxMSFlexGrid();
		_Label1_4 = new Label();
		_Label1_5 = new Label();
		lblMechanism = new Label();
		_Label1_3 = new Label();
		_Label1_2 = new Label();
		lblModelName = new Label();
		lblAct = new Label();
		_Label1_1 = new Label();
		_Label1_0 = new Label();
		lblInstructions = new Label();
		Label1 = new LabelArray(components);
		chkOutputOn = new CheckBoxArray(components);
		cmbChar = new ComboBoxArray(components);
		txtChar = new TextBoxArray(components);
		CachedIRERcomb1 = new CachedIRERcomb();
		((ISupportInitialize)msfRelParms).BeginInit();
		((ISupportInitialize)Label1).BeginInit();
		((ISupportInitialize)chkOutputOn).BeginInit();
		((ISupportInitialize)cmbChar).BeginInit();
		((ISupportInitialize)txtChar).BeginInit();
		((Control)this).SuspendLayout();
		_txtChar_1.AcceptsReturn = true;
		((TextBoxBase)_txtChar_1).BackColor = SystemColors.Window;
		((Control)_txtChar_1).Cursor = Cursors.IBeam;
		((Control)_txtChar_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtChar_1).ForeColor = SystemColors.WindowText;
		txtChar.SetIndex(_txtChar_1, (short)1);
		TextBox txtChar_ = _txtChar_1;
		Point location = new Point(608, 224);
		((Control)txtChar_).Location = location;
		((TextBoxBase)_txtChar_1).MaxLength = 25;
		((Control)_txtChar_1).Name = "_txtChar_1";
		((Control)_txtChar_1).RightToLeft = (RightToLeft)0;
		_txtChar_1.ScrollBars = (ScrollBars)2;
		TextBox txtChar_2 = _txtChar_1;
		Size size = new Size(169, 20);
		((Control)txtChar_2).Size = size;
		((Control)_txtChar_1).TabIndex = 6;
		_txtChar_0.AcceptsReturn = true;
		((TextBoxBase)_txtChar_0).BackColor = SystemColors.Window;
		((Control)_txtChar_0).Cursor = Cursors.IBeam;
		((Control)_txtChar_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtChar_0).ForeColor = SystemColors.WindowText;
		txtChar.SetIndex(_txtChar_0, (short)0);
		TextBox txtChar_3 = _txtChar_0;
		location = new Point(216, 224);
		((Control)txtChar_3).Location = location;
		((TextBoxBase)_txtChar_0).MaxLength = 25;
		((Control)_txtChar_0).Name = "_txtChar_0";
		((Control)_txtChar_0).RightToLeft = (RightToLeft)0;
		_txtChar_0.ScrollBars = (ScrollBars)2;
		TextBox txtChar_4 = _txtChar_0;
		size = new Size(169, 20);
		((Control)txtChar_4).Size = size;
		((Control)_txtChar_0).TabIndex = 3;
		_cmbChar_1.BackColor = SystemColors.Window;
		((Control)_cmbChar_1).Cursor = Cursors.Default;
		_cmbChar_1.DropDownStyle = (ComboBoxStyle)2;
		((Control)_cmbChar_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		_cmbChar_1.ForeColor = SystemColors.WindowText;
		cmbChar.SetIndex(_cmbChar_1, (short)1);
		ComboBox cmbChar_ = _cmbChar_1;
		location = new Point(416, 224);
		((Control)cmbChar_).Location = location;
		((Control)_cmbChar_1).Name = "_cmbChar_1";
		((Control)_cmbChar_1).RightToLeft = (RightToLeft)0;
		ComboBox cmbChar_2 = _cmbChar_1;
		size = new Size(185, 22);
		((Control)cmbChar_2).Size = size;
		((Control)_cmbChar_1).TabIndex = 5;
		((ButtonBase)_chkOutputOn_1).BackColor = SystemColors.Control;
		((Control)_chkOutputOn_1).Cursor = Cursors.Default;
		((Control)_chkOutputOn_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_chkOutputOn_1).ForeColor = SystemColors.ControlText;
		chkOutputOn.SetIndex(_chkOutputOn_1, (short)1);
		CheckBox chkOutputOn_ = _chkOutputOn_1;
		location = new Point(416, 200);
		((Control)chkOutputOn_).Location = location;
		((Control)_chkOutputOn_1).Name = "_chkOutputOn_1";
		((Control)_chkOutputOn_1).RightToLeft = (RightToLeft)0;
		CheckBox chkOutputOn_2 = _chkOutputOn_1;
		size = new Size(281, 25);
		((Control)chkOutputOn_2).Size = size;
		((Control)_chkOutputOn_1).TabIndex = 4;
		((ButtonBase)_chkOutputOn_1).Text = "Enable Model Parameters for Output 2";
		((ButtonBase)_chkOutputOn_1).UseVisualStyleBackColor = false;
		_cmbChar_0.BackColor = SystemColors.Window;
		((Control)_cmbChar_0).Cursor = Cursors.Default;
		_cmbChar_0.DropDownStyle = (ComboBoxStyle)2;
		((Control)_cmbChar_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		_cmbChar_0.ForeColor = SystemColors.WindowText;
		cmbChar.SetIndex(_cmbChar_0, (short)0);
		ComboBox cmbChar_3 = _cmbChar_0;
		location = new Point(32, 224);
		((Control)cmbChar_3).Location = location;
		((Control)_cmbChar_0).Name = "_cmbChar_0";
		((Control)_cmbChar_0).RightToLeft = (RightToLeft)0;
		ComboBox cmbChar_4 = _cmbChar_0;
		size = new Size(177, 22);
		((Control)cmbChar_4).Size = size;
		((Control)_cmbChar_0).TabIndex = 2;
		((ButtonBase)_chkOutputOn_0).BackColor = SystemColors.Control;
		((Control)_chkOutputOn_0).Cursor = Cursors.Default;
		((Control)_chkOutputOn_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_chkOutputOn_0).ForeColor = SystemColors.ControlText;
		chkOutputOn.SetIndex(_chkOutputOn_0, (short)0);
		CheckBox chkOutputOn_3 = _chkOutputOn_0;
		location = new Point(32, 200);
		((Control)chkOutputOn_3).Location = location;
		((Control)_chkOutputOn_0).Name = "_chkOutputOn_0";
		((Control)_chkOutputOn_0).RightToLeft = (RightToLeft)0;
		CheckBox chkOutputOn_4 = _chkOutputOn_0;
		size = new Size(273, 25);
		((Control)chkOutputOn_4).Size = size;
		((Control)_chkOutputOn_0).TabIndex = 1;
		((ButtonBase)_chkOutputOn_0).Text = "Enable Model Parameters for Output 1";
		((ButtonBase)_chkOutputOn_0).UseVisualStyleBackColor = false;
		cmbInput.BackColor = Color.FromArgb(255, 255, 192);
		((Control)cmbInput).Cursor = Cursors.Default;
		cmbInput.DropDownStyle = (ComboBoxStyle)2;
		((Control)cmbInput).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		cmbInput.ForeColor = SystemColors.WindowText;
		ComboBox obj = cmbInput;
		location = new Point(88, 536);
		((Control)obj).Location = location;
		((Control)cmbInput).Name = "cmbInput";
		((Control)cmbInput).RightToLeft = (RightToLeft)0;
		ComboBox obj2 = cmbInput;
		size = new Size(81, 22);
		((Control)obj2).Size = size;
		((Control)cmbInput).TabIndex = 11;
		((Control)cmbInput).Visible = false;
		txtEquation.AcceptsReturn = true;
		((TextBoxBase)txtEquation).BackColor = SystemColors.Window;
		((Control)txtEquation).Cursor = Cursors.IBeam;
		((Control)txtEquation).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtEquation).ForeColor = SystemColors.WindowText;
		TextBox obj3 = txtEquation;
		location = new Point(80, 136);
		((Control)obj3).Location = location;
		((TextBoxBase)txtEquation).MaxLength = 0;
		txtEquation.Multiline = true;
		((Control)txtEquation).Name = "txtEquation";
		((TextBoxBase)txtEquation).ReadOnly = true;
		((Control)txtEquation).RightToLeft = (RightToLeft)0;
		txtEquation.ScrollBars = (ScrollBars)2;
		TextBox obj4 = txtEquation;
		size = new Size(705, 33);
		((Control)obj4).Size = size;
		((Control)txtEquation).TabIndex = 0;
		txtInput.AcceptsReturn = true;
		((TextBoxBase)txtInput).BackColor = Color.FromArgb(255, 255, 192);
		((Control)txtInput).Cursor = Cursors.IBeam;
		((Control)txtInput).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtInput).ForeColor = SystemColors.WindowText;
		TextBox obj5 = txtInput;
		location = new Point(24, 536);
		((Control)obj5).Location = location;
		((TextBoxBase)txtInput).MaxLength = 0;
		((Control)txtInput).Name = "txtInput";
		((Control)txtInput).RightToLeft = (RightToLeft)0;
		TextBox obj6 = txtInput;
		size = new Size(41, 20);
		((Control)obj6).Size = size;
		((Control)txtInput).TabIndex = 12;
		((Control)txtInput).Visible = false;
		txtBasis.AcceptsReturn = true;
		((TextBoxBase)txtBasis).BackColor = SystemColors.Window;
		((Control)txtBasis).Cursor = Cursors.IBeam;
		((Control)txtBasis).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtBasis).ForeColor = SystemColors.WindowText;
		TextBox obj7 = txtBasis;
		location = new Point(80, 264);
		((Control)obj7).Location = location;
		((TextBoxBase)txtBasis).MaxLength = 0;
		txtBasis.Multiline = true;
		((Control)txtBasis).Name = "txtBasis";
		((Control)txtBasis).RightToLeft = (RightToLeft)0;
		txtBasis.ScrollBars = (ScrollBars)2;
		TextBox obj8 = txtBasis;
		size = new Size(705, 41);
		((Control)obj8).Size = size;
		((Control)txtBasis).TabIndex = 7;
		((ButtonBase)cmdCancel).BackColor = SystemColors.Control;
		((Control)cmdCancel).Cursor = Cursors.Default;
		cmdCancel.DialogResult = (DialogResult)2;
		((Control)cmdCancel).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCancel).ForeColor = SystemColors.ControlText;
		Button obj9 = cmdCancel;
		location = new Point(400, 512);
		((Control)obj9).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		((Control)cmdCancel).RightToLeft = (RightToLeft)0;
		Button obj10 = cmdCancel;
		size = new Size(81, 25);
		((Control)obj10).Size = size;
		((Control)cmdCancel).TabIndex = 10;
		((ButtonBase)cmdCancel).Text = "Cancel";
		((ButtonBase)cmdCancel).UseVisualStyleBackColor = false;
		((ButtonBase)cmdOk).BackColor = SystemColors.Control;
		((Control)cmdOk).Cursor = Cursors.Default;
		((Control)cmdOk).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdOk).ForeColor = SystemColors.ControlText;
		Button obj11 = cmdOk;
		location = new Point(304, 512);
		((Control)obj11).Location = location;
		((Control)cmdOk).Name = "cmdOk";
		((Control)cmdOk).RightToLeft = (RightToLeft)0;
		Button obj12 = cmdOk;
		size = new Size(81, 25);
		((Control)obj12).Size = size;
		((Control)cmdOk).TabIndex = 9;
		((ButtonBase)cmdOk).Text = "OK";
		((ButtonBase)cmdOk).UseVisualStyleBackColor = false;
		AxMSFlexGrid obj13 = msfRelParms;
		location = new Point(8, 328);
		((Control)obj13).Location = location;
		((Control)msfRelParms).Name = "msfRelParms";
		((AxHost)msfRelParms).OcxState = (State)componentResourceManager.GetObject("msfRelParms.OcxState");
		AxMSFlexGrid obj14 = msfRelParms;
		size = new Size(777, 177);
		((Control)obj14).Size = size;
		((Control)msfRelParms).TabIndex = 8;
		((Control)_Label1_4).BackColor = SystemColors.Control;
		((Control)_Label1_4).Cursor = Cursors.Default;
		((Control)_Label1_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_4).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_4, (short)4);
		Label label1_ = _Label1_4;
		location = new Point(8, 312);
		((Control)label1_).Location = location;
		((Control)_Label1_4).Name = "_Label1_4";
		((Control)_Label1_4).RightToLeft = (RightToLeft)0;
		Label label1_2 = _Label1_4;
		size = new Size(73, 17);
		((Control)label1_2).Size = size;
		((Control)_Label1_4).TabIndex = 22;
		_Label1_4.Text = "Parameters:";
		((Control)_Label1_5).BackColor = SystemColors.Control;
		((Control)_Label1_5).Cursor = Cursors.Default;
		((Control)_Label1_5).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_5).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_5, (short)5);
		Label label1_3 = _Label1_5;
		location = new Point(32, 264);
		((Control)label1_3).Location = location;
		((Control)_Label1_5).Name = "_Label1_5";
		((Control)_Label1_5).RightToLeft = (RightToLeft)0;
		Label label1_4 = _Label1_5;
		size = new Size(41, 17);
		((Control)label1_4).Size = size;
		((Control)_Label1_5).TabIndex = 21;
		_Label1_5.Text = "Basis:";
		_Label1_5.TextAlign = (ContentAlignment)4;
		((Control)lblMechanism).BackColor = SystemColors.Control;
		((Control)lblMechanism).Cursor = Cursors.Default;
		((Control)lblMechanism).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblMechanism).ForeColor = SystemColors.ControlText;
		Label obj15 = lblMechanism;
		location = new Point(160, 176);
		((Control)obj15).Location = location;
		((Control)lblMechanism).Name = "lblMechanism";
		((Control)lblMechanism).RightToLeft = (RightToLeft)0;
		Label obj16 = lblMechanism;
		size = new Size(625, 17);
		((Control)obj16).Size = size;
		((Control)lblMechanism).TabIndex = 20;
		lblMechanism.Text = "x";
		((Control)_Label1_3).BackColor = SystemColors.Control;
		((Control)_Label1_3).Cursor = Cursors.Default;
		((Control)_Label1_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_3).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_3, (short)3);
		Label label1_5 = _Label1_3;
		location = new Point(0, 136);
		((Control)label1_5).Location = location;
		((Control)_Label1_3).Name = "_Label1_3";
		((Control)_Label1_3).RightToLeft = (RightToLeft)0;
		Label label1_6 = _Label1_3;
		size = new Size(73, 33);
		((Control)label1_6).Size = size;
		((Control)_Label1_3).TabIndex = 19;
		_Label1_3.Text = "Model Equation:";
		_Label1_3.TextAlign = (ContentAlignment)4;
		((Control)_Label1_2).BackColor = SystemColors.Control;
		((Control)_Label1_2).Cursor = Cursors.Default;
		((Control)_Label1_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_2).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_2, (short)2);
		Label label1_7 = _Label1_2;
		location = new Point(0, 176);
		((Control)label1_7).Location = location;
		((Control)_Label1_2).Name = "_Label1_2";
		((Control)_Label1_2).RightToLeft = (RightToLeft)0;
		Label label1_8 = _Label1_2;
		size = new Size(145, 17);
		((Control)label1_8).Size = size;
		((Control)_Label1_2).TabIndex = 18;
		_Label1_2.Text = "Vapor Release Mechanism:";
		_Label1_2.TextAlign = (ContentAlignment)4;
		((Control)lblModelName).BackColor = SystemColors.Control;
		((Control)lblModelName).Cursor = Cursors.Default;
		((Control)lblModelName).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblModelName).ForeColor = SystemColors.ControlText;
		Label obj17 = lblModelName;
		location = new Point(80, 112);
		((Control)obj17).Location = location;
		((Control)lblModelName).Name = "lblModelName";
		((Control)lblModelName).RightToLeft = (RightToLeft)0;
		Label obj18 = lblModelName;
		size = new Size(713, 17);
		((Control)obj18).Size = size;
		((Control)lblModelName).TabIndex = 17;
		lblModelName.Text = "x";
		((Control)lblAct).BackColor = SystemColors.Control;
		((Control)lblAct).Cursor = Cursors.Default;
		((Control)lblAct).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblAct).ForeColor = SystemColors.ControlText;
		Label obj19 = lblAct;
		location = new Point(80, 96);
		((Control)obj19).Location = location;
		((Control)lblAct).Name = "lblAct";
		((Control)lblAct).RightToLeft = (RightToLeft)0;
		Label obj20 = lblAct;
		size = new Size(713, 17);
		((Control)obj20).Size = size;
		((Control)lblAct).TabIndex = 16;
		lblAct.Text = "x";
		((Control)_Label1_1).BackColor = SystemColors.Control;
		((Control)_Label1_1).Cursor = Cursors.Default;
		((Control)_Label1_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_1).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_1, (short)1);
		Label label1_9 = _Label1_1;
		location = new Point(0, 112);
		((Control)label1_9).Location = location;
		((Control)_Label1_1).Name = "_Label1_1";
		((Control)_Label1_1).RightToLeft = (RightToLeft)0;
		Label label1_10 = _Label1_1;
		size = new Size(73, 17);
		((Control)label1_10).Size = size;
		((Control)_Label1_1).TabIndex = 15;
		_Label1_1.Text = "Model:";
		_Label1_1.TextAlign = (ContentAlignment)4;
		((Control)_Label1_0).BackColor = SystemColors.Control;
		((Control)_Label1_0).Cursor = Cursors.Default;
		((Control)_Label1_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_0).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_0, (short)0);
		Label label1_11 = _Label1_0;
		location = new Point(0, 96);
		((Control)label1_11).Location = location;
		((Control)_Label1_0).Name = "_Label1_0";
		((Control)_Label1_0).RightToLeft = (RightToLeft)0;
		Label label1_12 = _Label1_0;
		size = new Size(73, 17);
		((Control)label1_12).Size = size;
		((Control)_Label1_0).TabIndex = 14;
		_Label1_0.Text = "Activity:";
		_Label1_0.TextAlign = (ContentAlignment)4;
		((Control)lblInstructions).BackColor = SystemColors.Control;
		((Control)lblInstructions).Cursor = Cursors.Default;
		((Control)lblInstructions).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblInstructions).ForeColor = SystemColors.ControlText;
		Label obj21 = lblInstructions;
		location = new Point(8, 8);
		((Control)obj21).Location = location;
		((Control)lblInstructions).Name = "lblInstructions";
		((Control)lblInstructions).RightToLeft = (RightToLeft)0;
		Label obj22 = lblInstructions;
		size = new Size(777, 81);
		((Control)obj22).Size = size;
		((Control)lblInstructions).TabIndex = 13;
		lblInstructions.Text = "xxx";
		size = new Size(5, 13);
		((Form)this).AutoScaleBaseSize = size;
		((Form)this).BackColor = SystemColors.Control;
		((Form)this).CancelButton = (IButtonControl)(object)cmdCancel;
		size = new Size(799, 559);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)_txtChar_1);
		((Control)this).Controls.Add((Control)(object)_txtChar_0);
		((Control)this).Controls.Add((Control)(object)_cmbChar_1);
		((Control)this).Controls.Add((Control)(object)_chkOutputOn_1);
		((Control)this).Controls.Add((Control)(object)_cmbChar_0);
		((Control)this).Controls.Add((Control)(object)_chkOutputOn_0);
		((Control)this).Controls.Add((Control)(object)cmbInput);
		((Control)this).Controls.Add((Control)(object)txtEquation);
		((Control)this).Controls.Add((Control)(object)txtInput);
		((Control)this).Controls.Add((Control)(object)txtBasis);
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)cmdOk);
		((Control)this).Controls.Add((Control)(object)msfRelParms);
		((Control)this).Controls.Add((Control)(object)_Label1_4);
		((Control)this).Controls.Add((Control)(object)_Label1_5);
		((Control)this).Controls.Add((Control)(object)lblMechanism);
		((Control)this).Controls.Add((Control)(object)_Label1_3);
		((Control)this).Controls.Add((Control)(object)_Label1_2);
		((Control)this).Controls.Add((Control)(object)lblModelName);
		((Control)this).Controls.Add((Control)(object)lblAct);
		((Control)this).Controls.Add((Control)(object)_Label1_1);
		((Control)this).Controls.Add((Control)(object)_Label1_0);
		((Control)this).Controls.Add((Control)(object)lblInstructions);
		((Control)this).Cursor = Cursors.Default;
		((Control)this).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		location = new Point(75, 100);
		((Form)this).Location = location;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmMDUpdRelMod";
		((Control)this).RightToLeft = (RightToLeft)0;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "View / Update Release Model Information";
		((ISupportInitialize)msfRelParms).EndInit();
		((ISupportInitialize)Label1).EndInit();
		((ISupportInitialize)chkOutputOn).EndInit();
		((ISupportInitialize)cmbChar).EndInit();
		((ISupportInitialize)txtChar).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private string getDstCntl(ref short pColToUse)
	{
		short num = checked((short)(msfRelParms.Rows - 1));
		short num2 = 1;
		while (true)
		{
			short num3 = num2;
			short num4 = num;
			if (num3 > num4)
			{
				break;
			}
			if (Conversions.ToDouble(msfRelParms[(int)num2, 0]) == 143.0)
			{
				return msfRelParms[(int)num2, (int)pColToUse];
			}
			checked
			{
				num2 = (short)unchecked(num2 + 1);
			}
		}
		return "Error, DstCntrl row not found";
	}

	private void resetDustModelBasis(ref string pOldDstCntl, ref string pNewDstCntl)
	{
		string text = ((Operators.CompareString(pOldDstCntl, "None", false) != 0) ? ("EPA/OPPT Solids Transfer Dust Loss Model. Dust emissions controlled by " + pOldDstCntl + ".") : "EPA/OPPT Solids Transfer Dust Loss Model. No dust controls are assumed as a worst case.");
		if (Operators.CompareString(txtBasis.Text, text, false) == 0)
		{
			if (Operators.CompareString(pNewDstCntl, "None", false) == 0)
			{
				txtBasis.Text = "EPA/OPPT Solids Transfer Dust Loss Model. No dust controls are assumed as a worst case.";
			}
			else
			{
				txtBasis.Text = "EPA/OPPT Solids Transfer Dust Loss Model. Dust emissions controlled by " + pNewDstCntl + ".";
			}
		}
	}

	private object ValidateTxtInput()
	{
		short pID = Conversions.ToShort(msfRelParms[Conversions.ToInteger(((Control)txtInput).Tag), 0]);
		TextBox val = txtInput;
		object pValue = val.Text;
		bool num = ChemStrX.ValidateParmInput(ref pID, ref pValue, ref MyModelType);
		val.Text = Conversions.ToString(pValue);
		if (!num)
		{
			((TextBoxBase)txtInput).SelectionStart = 0;
			((TextBoxBase)txtInput).SelectionLength = Strings.Len(txtInput.Text);
			((Control)txtInput).Focus();
			msfRelParms.Row = Conversions.ToInteger(((Control)txtInput).Tag);
			object result = default(object);
			return result;
		}
		return true;
	}

	private void chkOutputOn_CheckStateChanged(object eventSender, EventArgs eventArgs)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Invalid comparison between Unknown and I4
		short index = chkOutputOn.GetIndex((CheckBox)eventSender);
		if ((int)chkOutputOn[index].CheckState == 1)
		{
			((Control)cmbChar[index]).Enabled = true;
			if (cmbChar[index].SelectedIndex == -1)
			{
				cmbChar[index].SelectedIndex = 0;
			}
		}
		else
		{
			((Control)cmbChar[index]).Enabled = false;
		}
		short num = Conversions.ToShort(Interaction.IIf(index == 0, (object)(short)2, (object)(short)6));
		checked
		{
			short num2 = (short)(num + 2);
			short num3 = num;
			while (true)
			{
				short num4 = num3;
				short num5 = num2;
				if (num4 > num5)
				{
					break;
				}
				msfRelParms[unchecked((int)num3)] = Conversions.ToInteger(Interaction.IIf(((Control)cmbChar[index]).Enabled, (object)1300, (object)0));
				num3 = (short)unchecked(num3 + 1);
			}
		}
		if ((MyModelType == 53 && index == 1) & !bLoadingForm)
		{
			string pOldDstCntl;
			string pNewDstCntl;
			if ((int)chkOutputOn[(short)1].CheckState == 1)
			{
				short pColToUse = 4;
				pOldDstCntl = getDstCntl(ref pColToUse);
				pColToUse = 8;
				pNewDstCntl = getDstCntl(ref pColToUse);
			}
			else
			{
				short pColToUse = 8;
				pOldDstCntl = getDstCntl(ref pColToUse);
				pColToUse = 4;
				pNewDstCntl = getDstCntl(ref pColToUse);
			}
			if (Operators.CompareString(pOldDstCntl, pNewDstCntl, false) != 0)
			{
				resetDustModelBasis(ref pOldDstCntl, ref pNewDstCntl);
			}
		}
	}

	private void cmbChar_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		short index = cmbChar.GetIndex((ComboBox)eventSender);
		if (Operators.CompareString(Support.GetItemString((Control)(object)cmbChar[index], cmbChar[index].SelectedIndex), "User-Input", false) == 0)
		{
			((TextBoxBase)txtChar[index]).BackColor = Color.White;
			((TextBoxBase)txtChar[index]).ReadOnly = false;
		}
		else
		{
			txtChar[index].Text = "";
			((TextBoxBase)txtChar[index]).BackColor = ((Form)this).BackColor;
			((TextBoxBase)txtChar[index]).ReadOnly = true;
		}
	}

	private void cmbInput_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
	{
		((Control)cmbInput).Visible = false;
	}

	private void cmbInput_Leave(object eventSender, EventArgs eventArgs)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if (cmbInput.SelectedIndex == -1)
		{
			((Control)cmbInput).Visible = true;
			Interaction.MsgBox((object)"Please enter a selection.", (MsgBoxStyle)64, (object)"Invalid Input");
			((Control)cmbInput).Focus();
			return;
		}
		if (Operators.CompareString(msfRelParms[Conversions.ToInteger(((Control)cmbInput).Tag), (int)iColIndex], cmbInput.Text, false) != 0)
		{
			msfRelParms[Conversions.ToInteger(((Control)cmbInput).Tag), (int)iColIndex] = cmbInput.Text;
			checked
			{
				if (Operators.CompareString(cmbInput.Text, "Default", false) == 0)
				{
					short num = Conversions.ToShort(msfRelParms[msfRelParms.Row, 0]);
					short pActID = Globals_Renamed.arSelActType[frmMain.DefInstance.cmbRelActs.SelectedIndex, Globals_Renamed.intOpIndex];
					msfRelParms[msfRelParms.Row, iColIndex + 2] = ChemStrX.ShowInSciNot(ChemStrX.GetModelDefault(Globals_Renamed.arParmDS[num], num, ref MyModelType, ref pActID, ref Globals_Renamed.intModIndex, ref iDualIndex));
					msfRelParms[msfRelParms.Row, iColIndex + 1] = ChemStrX.SetVCLabel(ref Globals_Renamed.arParmDS[num]);
					if (Operators.CompareString(msfRelParms[msfRelParms.Row, iColIndex + 2], "-1", false) == 0)
					{
						msfRelParms[msfRelParms.Row, iColIndex + 2] = "0";
						msfRelParms[msfRelParms.Row, iColIndex + 1] = "User Specified";
					}
				}
				else
				{
					msfRelParms[msfRelParms.Row, iColIndex + 2] = "0";
					msfRelParms[msfRelParms.Row, iColIndex + 1] = "User-defined";
				}
			}
		}
		((Control)cmbInput).Visible = false;
	}

	private void cmdCancel_Click(object eventSender, EventArgs eventArgs)
	{
		((Form)this).Close();
	}

	private void cmdOk_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Invalid comparison between Unknown and I4
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0001_dispatch)
					{
					default:
					{
						ProjectData.ClearProjectError();
						num2 = 2;
						AxMSFlexGrid pGridCopy = msfRelParms;
						AxMSFlexGrid pGridTo = frmMain.DefInstance.msfRelParms;
						ChemStrX.CloneFlexGrid(ref pGridCopy, ref pGridTo);
						msfRelParms = pGridCopy;
						short z = (short)(Globals_Renamed.arExpModels[1, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1);
						short num3 = 0;
						short num4;
						short num5;
						do
						{
							Globals_Renamed.arRelModOutputOn[num3, Globals_Renamed.intModIndex] = Conversions.ToShort(Interaction.IIf(unchecked((int)chkOutputOn[num3].CheckState) == 1, (object)1, (object)0));
							if (Operators.CompareString(Support.GetItemString((Control)(object)cmbChar[num3], cmbChar[num3].SelectedIndex), "User-Input", false) == 0)
							{
								Globals_Renamed.arRelModChar[num3, Globals_Renamed.intModIndex] = txtChar[num3].Text;
							}
							else if (cmbChar[num3].SelectedIndex == -1)
							{
								Globals_Renamed.arRelModChar[num3, Globals_Renamed.intModIndex] = "";
							}
							else
							{
								Globals_Renamed.arRelModChar[num3, Globals_Renamed.intModIndex] = cmbChar[num3].Text;
							}
							num3 = (short)unchecked(num3 + 1);
							num4 = num3;
							num5 = 1;
						}
						while (num4 <= num5);
						short num6 = (short)(msfRelParms.Rows - 1);
						num3 = 1;
						while (true)
						{
							IL_0aaf:
							short num7 = num3;
							num5 = num6;
							if (num7 <= num5)
							{
								short pDualIndex = 0;
								while (true)
								{
									iColIndex = (short)(pDualIndex * 4 + 2);
									unchecked
									{
										short num8;
										switch (msfRelParms[(int)num3, (int)iColIndex])
										{
										case "Default":
											num8 = 1;
											break;
										case "Non-default":
											num8 = 3;
											break;
										case "Constant":
											num8 = 20;
											break;
										case "Model Output":
											num8 = 21;
											break;
										default:
											Interaction.MsgBox((object)"Unknown model parameter type encountered", (MsgBoxStyle)16, (object)null);
											goto end_IL_015d;
										}
										Globals_Renamed.arRelModParmsT[pDualIndex, Conversions.ToInteger(msfRelParms[(int)num3, 0]), Globals_Renamed.intModIndex] = num8;
										string text = msfRelParms[(int)num3, 0];
										if ((Operators.CompareString(text, Conversions.ToString(92), false) == 0 || Operators.CompareString(text, Conversions.ToString(9), false) == 0 || Operators.CompareString(text, Conversions.ToString(43), false) == 0 || Operators.CompareString(text, Conversions.ToString(45), false) == 0 || Operators.CompareString(text, Conversions.ToString(52), false) == 0) ? true : false)
										{
											if (Versioned.IsNumeric((object)msfRelParms[(int)num3, checked(iColIndex + 3)]))
											{
												Globals_Renamed.arRelModParmsVC[pDualIndex, Conversions.ToInteger(msfRelParms[(int)num3, 0]), Globals_Renamed.intModIndex] = Conversions.ToShort(msfRelParms[(int)num3, checked(iColIndex + 3)]);
											}
											Globals_Renamed.arRelModParmsV[pDualIndex, Conversions.ToInteger(msfRelParms[(int)num3, 0]), Globals_Renamed.intModIndex] = Conversions.ToSingle(msfRelParms[(int)num3, checked(iColIndex + 2)]);
										}
										else if (Operators.CompareString(text, Conversions.ToString(72), false) == 0)
										{
											Globals_Renamed.arRelModParmsVC[pDualIndex, 72, Globals_Renamed.intModIndex] = Conversions.ToShort(msfRelParms[(int)num3, checked(iColIndex + 3)]);
											Globals_Renamed.arRelModParmsV[pDualIndex, 72, Globals_Renamed.intModIndex] = Conversions.ToSingle(msfRelParms[(int)num3, checked(iColIndex + 2)]);
											GetParmDefaults.LinkFreq(ref z, ref pDualIndex);
										}
										else if (Operators.CompareString(text, Conversions.ToString(40), false) == 0)
										{
											Globals_Renamed.arRelModParmsVC[pDualIndex, 40, Globals_Renamed.intModIndex] = Conversions.ToShort(msfRelParms[(int)num3, checked(iColIndex + 3)]);
											Globals_Renamed.arRelModParmsV[pDualIndex, 40, Globals_Renamed.intModIndex] = Conversions.ToSingle(msfRelParms[(int)num3, checked(iColIndex + 2)]);
											GetParmDefaults.LinkX(ref z, ref pDualIndex);
										}
										else if (Operators.CompareString(text, Conversions.ToString(69), false) == 0)
										{
											Globals_Renamed.arRelModParmsV[pDualIndex, 69, Globals_Renamed.intModIndex] = Conversions.ToSingle(Common.MyNullCheck0(msfRelParms[(int)num3, checked(iColIndex + 2)]));
											if (Operators.CompareString(msfRelParms[(int)num3, checked(iColIndex + 1)], "User-defined", false) == 0)
											{
												Globals_Renamed.arRelModParmsVC[pDualIndex, 69, Globals_Renamed.intModIndex] = 999;
											}
											else
											{
												Globals_Renamed.arRelModParmsVC[pDualIndex, 69, Globals_Renamed.intModIndex] = Globals_Renamed.arParmDS[69];
											}
											GetParmDefaults.LinkVzCB(ref z, ref pDualIndex);
										}
										else if (Operators.CompareString(text, Conversions.ToString(31), false) == 0)
										{
											Globals_Renamed.arRelModParmsV[pDualIndex, 31, Globals_Renamed.intModIndex] = Conversions.ToSingle(Common.MyNullCheck0(msfRelParms[(int)num3, checked(iColIndex + 2)]));
											if (Operators.CompareString(msfRelParms[(int)num3, checked(iColIndex + 1)], "User-defined", false) == 0)
											{
												Globals_Renamed.arRelModParmsVC[pDualIndex, 31, Globals_Renamed.intModIndex] = 999;
											}
											else
											{
												Globals_Renamed.arRelModParmsVC[pDualIndex, 31, Globals_Renamed.intModIndex] = Globals_Renamed.arParmDS[31];
											}
											GetParmDefaults.LinkOHa(ref z, ref pDualIndex);
										}
										else if (Operators.CompareString(text, Conversions.ToString(4), false) == 0)
										{
											Globals_Renamed.arRelModParmsV[pDualIndex, 4, Globals_Renamed.intModIndex] = Conversions.ToSingle(Common.MyNullCheck0(msfRelParms[(int)num3, checked(iColIndex + 2)]));
											if (Operators.CompareString(msfRelParms[(int)num3, checked(iColIndex + 1)], "User-defined", false) == 0)
											{
												Globals_Renamed.arRelModParmsVC[pDualIndex, 4, Globals_Renamed.intModIndex] = 999;
											}
											else
											{
												Globals_Renamed.arRelModParmsVC[pDualIndex, 4, Globals_Renamed.intModIndex] = Globals_Renamed.arParmDS[4];
											}
											GetParmDefaults.LinkVP(ref z, ref pDualIndex);
										}
										else if (Operators.CompareString(text, Conversions.ToString(49), false) == 0)
										{
											Globals_Renamed.arRelModParmsV[pDualIndex, 49, Globals_Renamed.intModIndex] = Conversions.ToSingle(Common.MyNullCheck0(msfRelParms[(int)num3, checked(iColIndex + 2)]));
											if (Operators.CompareString(msfRelParms[(int)num3, checked(iColIndex + 1)], "User-defined", false) == 0)
											{
												Globals_Renamed.arRelModParmsVC[pDualIndex, 49, Globals_Renamed.intModIndex] = 999;
											}
											else
											{
												Globals_Renamed.arRelModParmsVC[pDualIndex, 49, Globals_Renamed.intModIndex] = Globals_Renamed.arParmDS[49];
											}
											Globals_Renamed.arRelModParmsV[pDualIndex, 50, Globals_Renamed.intModIndex] = Globals_Renamed.arRelModParmsV[pDualIndex, 49, Globals_Renamed.intModIndex];
											Globals_Renamed.arRelModParmsVC[pDualIndex, 50, Globals_Renamed.intModIndex] = Globals_Renamed.arRelModParmsVC[pDualIndex, 49, Globals_Renamed.intModIndex];
											GetParmDefaults.LinkGinput(ref z, ref pDualIndex);
										}
										else if (Operators.CompareString(text, Conversions.ToString(50), false) == 0)
										{
											Globals_Renamed.arRelModParmsV[pDualIndex, 50, Globals_Renamed.intModIndex] = Conversions.ToSingle(Common.MyNullCheck0(msfRelParms[(int)num3, checked(iColIndex + 2)]));
											if (Operators.CompareString(msfRelParms[(int)num3, checked(iColIndex + 1)], "User-defined", false) == 0)
											{
												Globals_Renamed.arRelModParmsVC[pDualIndex, 50, Globals_Renamed.intModIndex] = 999;
											}
											else
											{
												Globals_Renamed.arRelModParmsVC[pDualIndex, 50, Globals_Renamed.intModIndex] = Globals_Renamed.arParmDS[50];
											}
											GetParmDefaults.LinkGoutput(ref z, ref pDualIndex);
										}
										else if (Operators.CompareString(text, Conversions.ToString(142), false) == 0)
										{
											if (Versioned.IsNumeric((object)msfRelParms[(int)num3, checked(iColIndex + 3)]))
											{
												Globals_Renamed.arRelModParmsVC[pDualIndex, Conversions.ToInteger(msfRelParms[(int)num3, 0]), Globals_Renamed.intModIndex] = Conversions.ToShort(msfRelParms[(int)num3, checked(iColIndex + 3)]);
												Globals_Renamed.arOpParms[47, Globals_Renamed.intOpIndex] = Conversions.ToSingle(msfRelParms[(int)num3, checked(iColIndex + 3)]);
											}
											Globals_Renamed.arRelModParmsV[pDualIndex, Conversions.ToInteger(msfRelParms[(int)num3, 0]), Globals_Renamed.intModIndex] = Conversions.ToSingle(msfRelParms[(int)num3, checked(iColIndex + 2)]);
										}
										else if (Operators.CompareString(text, Conversions.ToString(143), false) == 0)
										{
											Globals_Renamed.arRelModParmsV[pDualIndex, 143, Globals_Renamed.intModIndex] = Conversions.ToSingle(msfRelParms[(int)num3, checked(iColIndex + 3)]);
										}
										else if (Operators.CompareString(text, Conversions.ToString(144), false) == 0)
										{
											Globals_Renamed.arRelModParmsV[pDualIndex, 144, Globals_Renamed.intModIndex] = Conversions.ToSingle(msfRelParms[(int)num3, checked(iColIndex + 2)]);
											Globals_Renamed.arRelModParmsVC[pDualIndex, 144, Globals_Renamed.intModIndex] = Conversions.ToShort(msfRelParms[(int)num3, checked(iColIndex + 3)]);
										}
										else
										{
											Globals_Renamed.arRelModParmsV[pDualIndex, Conversions.ToInteger(msfRelParms[(int)num3, 0]), Globals_Renamed.intModIndex] = Conversions.ToSingle(Common.MyNullCheck0(msfRelParms[(int)num3, checked(iColIndex + 2)]));
											if (Operators.CompareString(msfRelParms[(int)num3, checked(iColIndex + 1)], "User-defined", false) == 0)
											{
												Globals_Renamed.arRelModParmsVC[pDualIndex, Conversions.ToInteger(msfRelParms[(int)num3, 0]), Globals_Renamed.intModIndex] = 999;
											}
											else
											{
												Globals_Renamed.arRelModParmsVC[pDualIndex, Conversions.ToInteger(msfRelParms[(int)num3, 0]), Globals_Renamed.intModIndex] = Globals_Renamed.arParmDS[Conversions.ToInteger(msfRelParms[(int)num3, 0])];
											}
										}
									}
									pDualIndex = (short)unchecked(pDualIndex + 1);
									short num9 = pDualIndex;
									num5 = 1;
									if (num9 <= num5)
									{
										continue;
									}
									num3 = (short)unchecked(num3 + 1);
									goto IL_0aaf;
									continue;
									end_IL_015d:
									break;
								}
								break;
							}
							Globals_Renamed.arRelModBasis[Globals_Renamed.arRelModels[frmMain.DefInstance.lstRelModels.SelectedIndex, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1] = txtBasis.Text;
							if (Globals_Renamed.arRelModStatus[Globals_Renamed.intModIndex] > 0)
							{
								Globals_Renamed.arRelModStatus[Globals_Renamed.intModIndex] = 3;
							}
							unchecked
							{
								if (bAdjustMediaOfRelease)
								{
									if (Globals_Renamed.arRelModOutputOn[1, Globals_Renamed.intModIndex] == 1)
									{
										if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectNotEqual(myMediaControlParm1, (object)msfRelParms[(int)iMofRow1, 8], false), Operators.CompareObjectNotEqual(myMediaControlParm2, (object)msfRelParms[(int)iMofRow2, 8], false))))
										{
											flag = true;
										}
									}
									else if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectNotEqual(myMediaControlParm1, (object)msfRelParms[(int)iMofRow1, 4], false), Operators.CompareObjectNotEqual(myMediaControlParm2, (object)msfRelParms[(int)iMofRow2, 4], false))))
									{
										flag = true;
									}
								}
								if (flag)
								{
									object pMyModel = MyModelType;
									ChemStrX.Update_Rel_Media_Percentages(ref pMyModel);
								}
								frmMain.DefInstance.lstRelModels_SelectedIndexChanged(frmMain.DefInstance.lstRelModels, new EventArgs());
								frmMain.DefInstance.cmbExpOps.SelectedIndex = -1;
								Globals_Renamed.gblIWasChanged = true;
								((Form)this).Close();
								break;
							}
						}
						goto end_IL_0001;
					}
					case 3228:
						num = -1;
						switch (num2)
						{
						case 2:
						{
							string Eobject = ((Control)this).Name;
							string Efunction = "cmdOk_Click";
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
					goto IL_0cd6;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 3228;
				continue;
			}
			break;
			IL_0cd6:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public object SetUp()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		object obj = default(object);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
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
						bLoadingForm = true;
						command.ActiveConnection = Common.MyConn;
						command.CommandText = "pqryGetInstructions";
						command.CommandType = CommandTypeEnum.adCmdStoredProc;
						command.Parameters.Append(command.CreateParameter("pID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, 28));
						Command command2 = command;
						object RecordsAffected = Missing.Value;
						object Parameters = Missing.Value;
						recordset = command2.Execute(out RecordsAffected, ref Parameters);
						command.Parameters.Delete("pID");
						lblInstructions.Text = Conversions.ToString(recordset.Fields[0].Value);
						cmbChar[(short)0].Items.Clear();
						cmbChar[(short)1].Items.Clear();
						recordset.Close();
						recordset.CursorLocation = CursorLocationEnum.adUseClient;
						recordset.Open("SELECT * FROM qryListOfModelDescriptors", Common.MyConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
						while (!recordset.EOF)
						{
							if (Operators.ConditionalCompareObjectEqual(recordset.Fields[0].Value, (object)1, false))
							{
								cmbChar[(short)0].Items.Add(Operators.ConcatenateObject(recordset.Fields[1].Value, (object)" 1"));
								cmbChar[(short)1].Items.Add(Operators.ConcatenateObject(recordset.Fields[1].Value, (object)" 2"));
							}
							else
							{
								cmbChar[(short)0].Items.Add(RuntimeHelpers.GetObjectValue(recordset.Fields[1].Value));
								cmbChar[(short)1].Items.Add(RuntimeHelpers.GetObjectValue(recordset.Fields[1].Value));
							}
							recordset.MoveNext();
						}
						recordset.Close();
						AxMSFlexGrid pGridCopy = frmMain.DefInstance.msfRelParms;
						AxMSFlexGrid pGridTo = msfRelParms;
						ChemStrX.CloneFlexGrid(ref pGridCopy, ref pGridTo);
						msfRelParms = pGridTo;
						short num3 = (short)(msfRelParms.Cols - 1);
						short num4 = 0;
						short num6;
						while (true)
						{
							short num5 = num4;
							num6 = num3;
							if (num5 > num6)
							{
								break;
							}
							short num7 = (short)Strings.InStr(msfRelParms[0, unchecked((int)num4)], "\r", (CompareMethod)0);
							if (num7 > 0)
							{
								msfRelParms[0, unchecked((int)num4)] = Conversions.ToString(Operators.ConcatenateObject((object)Strings.Left(msfRelParms[0, unchecked((int)num4)], num7 - 1), Interaction.IIf(num4 < 6, (object)"1", (object)"2")));
							}
							num4 = (short)unchecked(num4 + 1);
						}
						COFarRelModParmsV = new float[3, 163, Globals_Renamed.intNumRelModels + 1];
						Parameters = Globals_Renamed.arRelModParmsV;
						RecordsAffected = COFarRelModParmsV;
						short pDim = 2;
						short pDim2 = 162;
						ChemStrX.Clone3DArray(ref Parameters, ref RecordsAffected, ref pDim, ref pDim2, ref Globals_Renamed.intNumRelModels);
						COFarRelModParmsV = (float[,,])RecordsAffected;
						Globals_Renamed.arRelModParmsV = (float[,,])Parameters;
						num4 = 2;
						short num8;
						do
						{
							msfRelParms[unchecked((int)num4)] = 0;
							num4 = (short)unchecked(num4 + 1);
							num8 = num4;
							num6 = 9;
						}
						while (num8 <= num6);
						command.ActiveConnection = Common.MyConn;
						command.CommandText = "pqryGetRelModel";
						command.CommandType = CommandTypeEnum.adCmdStoredProc;
						MyModelType = Globals_Renamed.arRelModType[Globals_Renamed.arRelModels[frmMain.DefInstance.lstRelModels.SelectedIndex, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1];
						command.Parameters.Append(command.CreateParameter("pRelModID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, MyModelType));
						Command command3 = command;
						Parameters = Missing.Value;
						RecordsAffected = Missing.Value;
						recordset = command3.Execute(out Parameters, ref RecordsAffected);
						command.Parameters.Delete("pRelModID");
						lblAct.Text = frmMain.DefInstance.cmbRelActs.Text;
						lblModelName.Text = Conversions.ToString(recordset.Fields["ModelName"].Value);
						txtEquation.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["Equation"].Value)), (object)"", RuntimeHelpers.GetObjectValue(recordset.Fields["Equation"].Value)));
						lblMechanism.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["Mechanism"].Value)), (object)"", RuntimeHelpers.GetObjectValue(recordset.Fields["Mechanism"].Value)));
						recordset.Close();
						txtBasis.Text = Globals_Renamed.arRelModBasis[Globals_Renamed.arRelModels[frmMain.DefInstance.lstRelModels.SelectedIndex, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1];
						num4 = 0;
						short num11;
						do
						{
							chkOutputOn[num4].CheckState = (CheckState)0;
							short num9 = (short)(cmbChar[num4].Items.Count - 1);
							short num7 = 0;
							while (true)
							{
								short num10 = num7;
								num6 = num9;
								if (num10 > num6)
								{
									break;
								}
								unchecked
								{
									if (Operators.CompareString(Support.GetItemString((Control)(object)cmbChar[num4], (int)num7), Globals_Renamed.arRelModChar[num4, Globals_Renamed.intModIndex], false) == 0)
									{
										cmbChar[num4].SelectedIndex = num7;
										break;
									}
									if (Operators.CompareString(Support.GetItemString((Control)(object)cmbChar[num4], (int)num7), "User-Input", false) == 0)
									{
										((Control)cmbChar[num4]).Tag = num7;
									}
								}
								num7 = (short)unchecked(num7 + 1);
							}
							if (cmbChar[num4].SelectedIndex == -1)
							{
								cmbChar[num4].SelectedIndex = Conversions.ToShort(((Control)cmbChar[num4]).Tag);
								txtChar[num4].Text = Globals_Renamed.arRelModChar[num4, Globals_Renamed.intModIndex];
							}
							if (Globals_Renamed.arRelModOutputOn[num4, Globals_Renamed.intModIndex] == 1)
							{
								chkOutputOn[num4].CheckState = (CheckState)1;
							}
							else
							{
								((Control)cmbChar[num4]).Enabled = false;
							}
							num4 = (short)unchecked(num4 + 1);
							num11 = num4;
							num6 = 1;
						}
						while (num11 <= num6);
						switch (MyModelType)
						{
						case 41:
						case 48:
							bAdjustMediaOfRelease = true;
							iMofParmID1 = 45;
							iMofParmID2 = 52;
							break;
						case 51:
						case 52:
							bAdjustMediaOfRelease = true;
							iMofParmID1 = 142;
							iMofParmID2 = 142;
							break;
						case 53:
							bAdjustMediaOfRelease = true;
							iMofParmID1 = 143;
							iMofParmID2 = 144;
							break;
						default:
							bAdjustMediaOfRelease = false;
							break;
						}
						if (bAdjustMediaOfRelease)
						{
							short num12 = (short)(msfRelParms.Rows - 1);
							num4 = 1;
							while (true)
							{
								short num13 = num4;
								num6 = num12;
								if (num13 > num6)
								{
									break;
								}
								unchecked
								{
									if (Conversions.ToDouble(msfRelParms[(int)num4, 0]) == (double)iMofParmID1)
									{
										iMofRow1 = num4;
										if (Globals_Renamed.arRelModOutputOn[1, Globals_Renamed.intModIndex] == 1)
										{
											myMediaControlParm1 = msfRelParms[(int)num4, 8];
										}
										else
										{
											myMediaControlParm1 = msfRelParms[(int)num4, 4];
										}
									}
									if (Conversions.ToDouble(msfRelParms[(int)num4, 0]) == (double)iMofParmID2)
									{
										iMofRow2 = num4;
										if (Globals_Renamed.arRelModOutputOn[1, Globals_Renamed.intModIndex] == 1)
										{
											myMediaControlParm2 = msfRelParms[(int)num4, 8];
										}
										else
										{
											myMediaControlParm2 = msfRelParms[(int)num4, 4];
										}
									}
								}
								num4 = (short)unchecked(num4 + 1);
							}
						}
						bLoadingForm = false;
						recordset = null;
						command = null;
						obj = true;
						goto end_IL_0001;
					}
					case 2325:
						num = -1;
						switch (num2)
						{
						case 2:
						{
							string Eobject = ((Control)this).Name;
							string Efunction = "SetUp";
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
			}
			catch (object obj2) when (obj2 is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0001_dispatch = 2325;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		object result = obj;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private void msfRelParms_ClickEvent(object eventSender, EventArgs eventArgs)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Invalid comparison between Unknown and I4
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_053f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f1: Invalid comparison between Unknown and I4
		//IL_07db: Unknown result type (might be due to invalid IL or missing references)
		//IL_0855: Unknown result type (might be due to invalid IL or missing references)
		//IL_0758: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f1: Unknown result type (might be due to invalid IL or missing references)
		if (msfRelParms.Row != msfRelParms.RowSel)
		{
			return;
		}
		switch (MyModelType)
		{
		case 12:
			Interaction.MsgBox((object)"Users are not allowed to change anything in the Cooling Tower Blowdown model. For more information, please see the ChemSTEER Users Guide.", (MsgBoxStyle)64, (object)"ChemSTEER");
			return;
		case 13:
			Interaction.MsgBox((object)"Users are not allowed to change anything in the Cooling Tower Windage model. For more information, please see the ChemSTEER Users Guide.", (MsgBoxStyle)64, (object)"ChemSTEER");
			return;
		case 14:
			Interaction.MsgBox((object)"Users are not allowed to change anything in the Cooling Tower Evaporative model. For more information, please see the ChemSTEER Users Guide.", (MsgBoxStyle)64, (object)"ChemSTEER");
			return;
		case 52:
		{
			string text2 = msfRelParms[msfRelParms.Row, 0];
			if ((Operators.CompareString(text2, Conversions.ToString(1), false) == 0 || Operators.CompareString(text2, Conversions.ToString(72), false) == 0 || Operators.CompareString(text2, Conversions.ToString(134), false) == 0 || Operators.CompareString(text2, Conversions.ToString(138), false) == 0 || Operators.CompareString(text2, Conversions.ToString(139), false) == 0 || Operators.CompareString(text2, Conversions.ToString(132), false) == 0) ? true : false)
			{
				Interaction.MsgBox((object)("Users are not allowed to change the " + Globals_Renamed.arParmNames[Conversions.ToInteger(msfRelParms[msfRelParms.Row, 0])] + " in the Electroplating Rinse Water model. For more information, please see the ChemSTEER Users Guide."), (MsgBoxStyle)64, (object)"ChemSTEER");
				return;
			}
			break;
		}
		case 51:
		{
			string text = msfRelParms[msfRelParms.Row, 0];
			if ((Operators.CompareString(text, Conversions.ToString(1), false) == 0 || Operators.CompareString(text, Conversions.ToString(133), false) == 0 || Operators.CompareString(text, Conversions.ToString(131), false) == 0) ? true : false)
			{
				Interaction.MsgBox((object)("Users are not allowed to change the " + Globals_Renamed.arParmNames[Conversions.ToInteger(msfRelParms[msfRelParms.Row, 0])] + " in the Electroplating Spent Bath model. For more information, please see the ChemSTEER Users Guide."), (MsgBoxStyle)64, (object)"ChemSTEER");
				return;
			}
			break;
		}
		}
		bool flag2 = default(bool);
		bool flag = default(bool);
		switch (msfRelParms.Col)
		{
		case 2:
			if ((int)chkOutputOn[(short)0].CheckState == 1)
			{
				iColIndex = 2;
				flag2 = true;
				iDualIndex = 0;
			}
			break;
		case 6:
			iColIndex = 6;
			flag2 = true;
			iDualIndex = 1;
			break;
		case 4:
			iColIndex = 2;
			flag = true;
			iDualIndex = 0;
			break;
		case 8:
			iColIndex = 6;
			flag = true;
			iDualIndex = 1;
			break;
		}
		checked
		{
			if (flag2)
			{
				string text3 = msfRelParms[msfRelParms.Row, unchecked((int)iColIndex)];
				if (Operators.CompareString(text3, "Default", false) != 0 && Operators.CompareString(text3, "Non-default", false) != 0)
				{
					return;
				}
				string text4 = msfRelParms[msfRelParms.Row, 0];
				if ((Operators.CompareString(text4, Conversions.ToString(9), false) == 0 || Operators.CompareString(text4, Conversions.ToString(92), false) == 0 || Operators.CompareString(text4, Conversions.ToString(72), false) == 0 || Operators.CompareString(text4, Conversions.ToString(40), false) == 0) ? true : false)
				{
					frmMDUpdAmtFreq defInstance = frmMDUpdAmtFreq.DefInstance;
					ref short myModelType = ref MyModelType;
					short pCallerID = 0;
					ref short pActID = ref Globals_Renamed.arSelActType[Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex];
					ref short pDualIndex = ref iDualIndex;
					AxMSFlexGrid pMsfParms = msfRelParms;
					bool num = defInstance.SetUp(ref myModelType, ref pCallerID, ref pActID, ref pDualIndex, ref pMsfParms);
					msfRelParms = pMsfParms;
					if (num)
					{
						((Form)frmMDUpdAmtFreq.DefInstance).ShowDialog();
					}
					else
					{
						((Form)frmMDUpdAmtFreq.DefInstance).Close();
					}
				}
				else if (Operators.CompareString(text4, Conversions.ToString(45), false) == 0 || Operators.CompareString(text4, Conversions.ToString(52), false) == 0)
				{
					frmMDUpdRelA10 defInstance2 = frmMDUpdRelA10.DefInstance;
					short pCallerID = 0;
					ref short myModelType2 = ref MyModelType;
					ref short pActID2 = ref Globals_Renamed.arSelActType[Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex];
					AxMSFlexGrid pMsfParms = msfRelParms;
					bool num2 = defInstance2.SetUp(ref pCallerID, ref myModelType2, ref pActID2, ref pMsfParms);
					msfRelParms = pMsfParms;
					if (num2)
					{
						((Form)frmMDUpdRelA10.DefInstance).ShowDialog();
					}
					else
					{
						((Form)frmMDUpdRelA10.DefInstance).Close();
					}
				}
				else if (Operators.CompareString(text4, Conversions.ToString(43), false) == 0 || Operators.CompareString(text4, Conversions.ToString(142), false) == 0)
				{
					frmMDUpdRelA10 defInstance3 = frmMDUpdRelA10.DefInstance;
					short pCallerID = 0;
					ref short myModelType3 = ref MyModelType;
					ref short pActID3 = ref Globals_Renamed.arSelActType[Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex];
					AxMSFlexGrid pMsfParms = msfRelParms;
					bool num3 = defInstance3.SetUp(ref pCallerID, ref myModelType3, ref pActID3, ref pMsfParms);
					msfRelParms = pMsfParms;
					if (num3)
					{
						((Form)frmMDUpdRelA10.DefInstance).ShowDialog();
					}
					else
					{
						((Form)frmMDUpdRelA10.DefInstance).Close();
					}
					if ((MyModelType == 48) | (MyModelType == 41))
					{
						COFarRelModParmsV[iDualIndex, 43, Globals_Renamed.intModIndex] = Conversions.ToSingle(msfRelParms[msfRelParms.Row, iColIndex + 2]);
						short num4 = (short)(msfRelParms.Rows - 1);
						short num5 = 1;
						while (true)
						{
							short num6 = num5;
							short num7 = num4;
							if (num6 <= num7)
							{
								if (Conversions.ToDouble(msfRelParms[unchecked((int)num5), 0]) == 74.0)
								{
									AxMSFlexGrid obj = msfRelParms;
									short num8 = num5;
									int num9 = iColIndex + 2;
									ref short pDualIndex2 = ref iDualIndex;
									object ParRelModParmsV = COFarRelModParmsV;
									float parmDefault = GetParmDefaults.GetParmDefault3105(ref Globals_Renamed.intModIndex, ref pDualIndex2, ref ParRelModParmsV);
									COFarRelModParmsV = (float[,,])ParRelModParmsV;
									obj[unchecked((int)num8), num9] = ChemStrX.ShowInSciNot(parmDefault);
									break;
								}
								num5 = (short)unchecked(num5 + 1);
								continue;
							}
							break;
						}
					}
					else if ((MyModelType == 51) | (MyModelType == 52))
					{
						COFarRelModParmsV[iDualIndex, 142, Globals_Renamed.intModIndex] = Conversions.ToSingle(msfRelParms[msfRelParms.Row, iColIndex + 2]);
					}
				}
				else if (Operators.CompareString(text4, Conversions.ToString(143), false) == 0 || Operators.CompareString(text4, Conversions.ToString(144), false) == 0)
				{
					short pColToUse = unchecked((short)(((int)chkOutputOn[(short)1].CheckState != 1) ? 4 : 8));
					string pOldDstCntl = getDstCntl(ref pColToUse);
					frmMDUpdRelA24 defInstance4 = frmMDUpdRelA24.DefInstance;
					ref short myModelType4 = ref MyModelType;
					short pCallerID = 0;
					ref short pActID4 = ref Globals_Renamed.arSelActType[Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex];
					ref short pDualIndex3 = ref iDualIndex;
					AxMSFlexGrid pMsfParms = msfRelParms;
					bool num10 = defInstance4.SetUp(ref myModelType4, ref pCallerID, ref pActID4, ref pDualIndex3, ref pMsfParms);
					msfRelParms = pMsfParms;
					if (num10)
					{
						((Form)frmMDUpdRelA24.DefInstance).ShowDialog();
						string pNewDstCntl = getDstCntl(ref pColToUse);
						if (Operators.CompareString(pOldDstCntl, pNewDstCntl, false) != 0)
						{
							resetDustModelBasis(ref pOldDstCntl, ref pNewDstCntl);
						}
					}
					else
					{
						((Form)frmMDUpdRelA24.DefInstance).Close();
					}
				}
				else if (Operators.CompareString(text4, Conversions.ToString(73), false) == 0)
				{
					frmMDUpdLF defInstance5 = frmMDUpdLF.DefInstance;
					short pCallerID = 0;
					if (defInstance5.SetUp(ref pCallerID, ref MyModelType, msfRelParms))
					{
						((Form)frmMDUpdLF.DefInstance).ShowDialog();
					}
					else
					{
						((Form)frmMDUpdLF.DefInstance).Close();
					}
				}
				else if (Operators.CompareString(text4, Conversions.ToString(26), false) == 0)
				{
					frmMDUpdD defInstance6 = frmMDUpdD.DefInstance;
					short pCallerID = 0;
					ref short myModelType5 = ref MyModelType;
					ref short pActID5 = ref Globals_Renamed.arSelActType[Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex];
					AxMSFlexGrid pMsfParms = msfRelParms;
					bool num11 = defInstance6.SetUp(ref pCallerID, ref myModelType5, ref pActID5, ref pMsfParms);
					msfRelParms = pMsfParms;
					if (num11)
					{
						((Form)frmMDUpdD.DefInstance).ShowDialog();
					}
					else
					{
						((Form)frmMDUpdD.DefInstance).Close();
					}
				}
				else if (Operators.CompareString(text4, Conversions.ToString(137), false) == 0 || Operators.CompareString(text4, Conversions.ToString(141), false) == 0)
				{
					frmMDUpdD defInstance7 = frmMDUpdD.DefInstance;
					short pCallerID = 0;
					ref short myModelType6 = ref MyModelType;
					ref short pActID6 = ref Globals_Renamed.arSelActType[Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex];
					AxMSFlexGrid pMsfParms = msfRelParms;
					bool num12 = defInstance7.SetUp(ref pCallerID, ref myModelType6, ref pActID6, ref pMsfParms);
					msfRelParms = pMsfParms;
					if (num12)
					{
						((Form)frmMDUpdD.DefInstance).ShowDialog();
						if (MyModelType != 51)
						{
							return;
						}
						COFarRelModParmsV[iDualIndex, Conversions.ToInteger(msfRelParms[msfRelParms.Row, 0]), Globals_Renamed.intModIndex] = Conversions.ToSingle(msfRelParms[msfRelParms.Row, iColIndex + 2]);
						short num13 = (short)(msfRelParms.Rows - 1);
						short num5 = 1;
						while (true)
						{
							short num14 = num5;
							short num7 = num13;
							if (num14 > num7)
							{
								break;
							}
							unchecked
							{
								if ((Operators.CompareString(msfRelParms[(int)num5, 0], msfRelParms[msfRelParms.Row, 0], false) != 0) & ((Conversions.ToDouble(msfRelParms[(int)num5, 0]) == 141.0) | (Conversions.ToDouble(msfRelParms[(int)num5, 0]) == 137.0)))
								{
									if (Operators.CompareString(msfRelParms[(int)num5, (int)iColIndex], msfRelParms[msfRelParms.Row, (int)iColIndex], false) != 0)
									{
										msfRelParms[(int)num5, (int)iColIndex] = msfRelParms[msfRelParms.Row, (int)iColIndex];
										msfRelParms[(int)num5, checked(iColIndex + 2)] = Conversions.ToString(ChemStrX.GetModelDefault(-1302, Conversions.ToShort(msfRelParms[(int)num5, 0]), ref MyModelType, ref Globals_Renamed.intActIndex, ref Globals_Renamed.intModIndex, ref iDualIndex));
										if (Operators.CompareString(msfRelParms[msfRelParms.Row, (int)iColIndex], "Default", false) == 0)
										{
											msfRelParms[(int)num5, checked(iColIndex + 2)] = Conversions.ToString(Globals_Renamed.gblMetaNonDefaults[0]);
										}
										else
										{
											msfRelParms[(int)num5, checked(iColIndex + 2)] = Conversions.ToString(Globals_Renamed.gblMetaNonDefaults[1]);
										}
									}
									break;
								}
							}
							num5 = (short)unchecked(num5 + 1);
						}
					}
					else
					{
						((Form)frmMDUpdD.DefInstance).Close();
					}
				}
				else
				{
					DoDefaultNonDefaultDropDownListBox();
				}
			}
			else if (flag & (Operators.CompareString(Strings.Left(msfRelParms[msfRelParms.Row, iColIndex + 1], 4), "User", false) == 0))
			{
				if (msfRelParms[msfRelParms.Row] & (msfRelParms.Row < msfRelParms.TopRow + 9))
				{
					((Control)txtInput).Left = (int)Math.Round(Support.TwipsToPixelsX(Support.PixelsToTwipsX((double)((Control)msfRelParms).Left) + (double)msfRelParms[msfRelParms.Col] + 50.0));
					((Control)txtInput).Top = (int)Math.Round(Support.TwipsToPixelsY(Support.PixelsToTwipsY((double)((Control)msfRelParms).Top) + (double)msfRelParms[msfRelParms.Row]));
					((Control)txtInput).Width = (int)Math.Round(Support.TwipsToPixelsX((double)msfRelParms[msfRelParms.Col]));
					txtInput.Text = msfRelParms[msfRelParms.Row, msfRelParms.Col];
					((Control)txtInput).Visible = true;
					((TextBoxBase)txtInput).SelectionStart = 0;
					((TextBoxBase)txtInput).SelectionLength = Strings.Len(txtInput.Text);
					((Control)txtInput).Focus();
				}
				else
				{
					((Control)txtInput).Visible = false;
				}
			}
		}
	}

	private void DoDefaultNonDefaultDropDownListBox()
	{
		checked
		{
			((Control)cmbInput).Left = (int)Math.Round(Support.TwipsToPixelsX(Support.PixelsToTwipsX((double)((Control)msfRelParms).Left) + (double)msfRelParms[msfRelParms.Col] + 50.0));
			((Control)cmbInput).Top = (int)Math.Round(Support.TwipsToPixelsY(Support.PixelsToTwipsY((double)((Control)msfRelParms).Top) + (double)msfRelParms[msfRelParms.Row]));
			((Control)cmbInput).Width = (int)Math.Round(Support.TwipsToPixelsX((double)msfRelParms[msfRelParms.Col]));
			cmbInput.Items.Clear();
			cmbInput.Items.Add((object)"Default");
			cmbInput.Items.Add((object)"Non-default");
			cmbInput.SelectedIndex = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(msfRelParms[msfRelParms.Row, 2], "Default", false) == 0, (object)0, (object)1));
			((Control)cmbInput).Tag = msfRelParms.Row;
			((Control)cmbInput).Visible = true;
			((Control)cmbInput).Focus();
		}
	}

	private void txtBasis_Leave(object eventSender, EventArgs eventArgs)
	{
		TextBox obj = txtBasis;
		TextBox val = txtBasis;
		string pText = val.Text;
		string text = ChemStrX.TrtLineBreak(ref pText);
		val.Text = pText;
		obj.Text = text;
	}

	private void txtInput_TextChanged(object eventSender, EventArgs eventArgs)
	{
		if (!((Control)txtInput).Visible || Strings.Len(txtInput.Text) <= 0 || !Versioned.IsNumeric((object)txtInput.Text) || Conversions.ToDouble(txtInput.Text) == 0.0 || !Conversions.ToBoolean(ValidateTxtInput()))
		{
			return;
		}
		checked
		{
			msfRelParms[msfRelParms.Row, iColIndex + 2] = txtInput.Text;
			string text = msfRelParms[msfRelParms.Row, 0];
			if (Operators.CompareString(text, Conversions.ToString(43), false) == 0)
			{
				COFarRelModParmsV[iDualIndex, Conversions.ToInteger(msfRelParms[msfRelParms.Row, 0]), Globals_Renamed.intModIndex] = Conversions.ToSingle(txtInput.Text);
				short num = (short)(msfRelParms.Rows - 1);
				short num2 = 1;
				while (true)
				{
					short num3 = num2;
					short num4 = num;
					if (num3 <= num4)
					{
						if (Conversions.ToDouble(msfRelParms[unchecked((int)num2), 0]) == 74.0)
						{
							AxMSFlexGrid obj = msfRelParms;
							short num5 = num2;
							int num6 = iColIndex + 2;
							ref short pDualIndex = ref iDualIndex;
							object ParRelModParmsV = COFarRelModParmsV;
							float parmDefault = GetParmDefaults.GetParmDefault3105(ref Globals_Renamed.intModIndex, ref pDualIndex, ref ParRelModParmsV);
							COFarRelModParmsV = (float[,,])ParRelModParmsV;
							obj[unchecked((int)num5), num6] = ChemStrX.ShowInSciNot(parmDefault);
							break;
						}
						num2 = (short)unchecked(num2 + 1);
						continue;
					}
					break;
				}
			}
			else
			{
				if (Operators.CompareString(text, Conversions.ToString(142), false) != 0)
				{
					return;
				}
				COFarRelModParmsV[iDualIndex, Conversions.ToInteger(msfRelParms[msfRelParms.Row, 0]), Globals_Renamed.intModIndex] = Conversions.ToSingle(txtInput.Text);
				short num7 = (short)(msfRelParms.Rows - 1);
				short num2 = 1;
				while (true)
				{
					short num8 = num2;
					short num4 = num7;
					if (num8 > num4)
					{
						break;
					}
					unchecked
					{
						if (Conversions.ToDouble(msfRelParms[(int)num2, 0]) == 74.0)
						{
							if (Operators.CompareString(msfRelParms[(int)num2, (int)iColIndex], "Default", false) == 0)
							{
								AxMSFlexGrid obj2 = msfRelParms;
								short num9 = num2;
								int num10 = checked(iColIndex + 2);
								ref short pDualIndex2 = ref iDualIndex;
								object ParRelModParmsV = COFarRelModParmsV;
								float parmDefault2 = GetParmDefaults.GetParmDefault3105(ref Globals_Renamed.intModIndex, ref pDualIndex2, ref ParRelModParmsV);
								COFarRelModParmsV = (float[,,])ParRelModParmsV;
								obj2[(int)num9, num10] = ChemStrX.ShowInSciNot(parmDefault2);
							}
							break;
						}
					}
					num2 = (short)unchecked(num2 + 1);
				}
			}
		}
	}

	private void txtInput_Enter(object eventSender, EventArgs eventArgs)
	{
		((TextBoxBase)txtInput).SelectionStart = 0;
		((TextBoxBase)txtInput).SelectionLength = Strings.Len(txtInput.Text);
		((Control)txtInput).Tag = msfRelParms.Row;
	}

	private void txtInput_Leave(object eventSender, EventArgs eventArgs)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		if (Strings.Len(txtInput.Text) == 0)
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Invalid number. All user specified parameters must be greater than zero.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
			((TextBoxBase)txtInput).SelectionStart = 0;
			((TextBoxBase)txtInput).SelectionLength = Strings.Len(txtInput.Text);
			((Control)txtInput).Focus();
		}
		else if (!Versioned.IsNumeric((object)txtInput.Text))
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Invalid number. All user specified parameters must be numeric values greater than or equal to zero.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
			((TextBoxBase)txtInput).SelectionStart = 0;
			((TextBoxBase)txtInput).SelectionLength = Strings.Len(txtInput.Text);
			((Control)txtInput).Focus();
		}
		else if (Conversions.ToBoolean(ValidateTxtInput()))
		{
			((Control)txtInput).Visible = false;
		}
	}

	private void txtEquation_TextChanged(object sender, EventArgs e)
	{
	}

	private void msfRelParms_Enter(object sender, EventArgs e)
	{
	}
}
