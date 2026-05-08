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

internal class frmMDUpdExpMod : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private short GC_USER_INPUT;

	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("chkUncertainty")]
	private CheckBox _chkUncertainty;

	[AccessedThroughProperty("_cmbChar_0")]
	private ComboBox __cmbChar_0;

	[AccessedThroughProperty("_cmbChar_1")]
	private ComboBox __cmbChar_1;

	[AccessedThroughProperty("_txtChar_0")]
	private TextBox __txtChar_0;

	[AccessedThroughProperty("_txtChar_1")]
	private TextBox __txtChar_1;

	[AccessedThroughProperty("cmbInput")]
	private ComboBox _cmbInput;

	[AccessedThroughProperty("txtEquation")]
	private TextBox _txtEquation;

	[AccessedThroughProperty("cmbChemState")]
	private ComboBox _cmbChemState;

	[AccessedThroughProperty("txtInput")]
	private TextBox _txtInput;

	[AccessedThroughProperty("txtBasis")]
	private TextBox _txtBasis;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("cmdOk")]
	private Button _cmdOk;

	[AccessedThroughProperty("msfExpParms")]
	private AxMSFlexGrid _msfExpParms;

	[AccessedThroughProperty("_chkOutputOn_0")]
	private CheckBox __chkOutputOn_0;

	[AccessedThroughProperty("_chkOutputOn_1")]
	private CheckBox __chkOutputOn_1;

	[AccessedThroughProperty("_lblCmCvOption_1")]
	private Label __lblCmCvOption_1;

	[AccessedThroughProperty("_Label1_4")]
	private Label __Label1_4;

	[AccessedThroughProperty("_lblCmCvOption_0")]
	private Label __lblCmCvOption_0;

	[AccessedThroughProperty("_Label1_6")]
	private Label __Label1_6;

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

	[AccessedThroughProperty("lblCmCvOption")]
	private LabelArray _lblCmCvOption;

	[AccessedThroughProperty("CachedIRERcomb1")]
	private CachedIRERcomb _CachedIRERcomb1;

	[AccessedThroughProperty("txtChar")]
	private TextBoxArray _txtChar;

	private static frmMDUpdExpMod m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	private short myType;

	private short MyModelType;

	public short intOtherModelIndex;

	private short iDualIndex;

	private short iColIndex;

	private short iYsRow;

	private short iYpelRow;

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

	public virtual CheckBox chkUncertainty
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkUncertainty;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkUncertainty = value;
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
			_txtEquation = value;
		}
	}

	public virtual ComboBox cmbChemState
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbChemState;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cmbChemState = value;
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

	public virtual AxMSFlexGrid msfExpParms
	{
		[DebuggerNonUserCode]
		get
		{
			return _msfExpParms;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = msfExpParms_Enter;
			EventHandler eventHandler2 = msfExpParms_Scroll;
			EventHandler eventHandler3 = msfExpParms_ClickEvent;
			if (_msfExpParms != null)
			{
				((Control)_msfExpParms).Enter -= eventHandler;
				_msfExpParms.Scroll -= eventHandler2;
				_msfExpParms.ClickEvent -= eventHandler3;
			}
			_msfExpParms = value;
			if (_msfExpParms != null)
			{
				((Control)_msfExpParms).Enter += eventHandler;
				_msfExpParms.Scroll += eventHandler2;
				_msfExpParms.ClickEvent += eventHandler3;
			}
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

	public virtual Label _lblCmCvOption_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblCmCvOption_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblCmCvOption_1 = value;
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

	public virtual Label _lblCmCvOption_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblCmCvOption_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblCmCvOption_0 = value;
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

	public virtual LabelArray lblCmCvOption
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblCmCvOption;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblCmCvOption = value;
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

	public static frmMDUpdExpMod DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmMDUpdExpMod();
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

	public frmMDUpdExpMod()
	{
		((Form)this).Load += frmMDUpdExpMod_Load;
		__ENCAddToList(this);
		GC_USER_INPUT = 17;
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
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected O, but got Unknown
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected O, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected O, but got Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected O, but got Unknown
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected O, but got Unknown
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected O, but got Unknown
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Expected O, but got Unknown
		//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0503: Expected O, but got Unknown
		//IL_05ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f7: Expected O, but got Unknown
		//IL_06f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fa: Expected O, but got Unknown
		//IL_07bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c7: Expected O, but got Unknown
		//IL_08c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ca: Expected O, but got Unknown
		//IL_0991: Unknown result type (might be due to invalid IL or missing references)
		//IL_099b: Expected O, but got Unknown
		//IL_0a6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a78: Expected O, but got Unknown
		//IL_0b57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b61: Expected O, but got Unknown
		//IL_0c2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c34: Expected O, but got Unknown
		//IL_0d05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0f: Expected O, but got Unknown
		//IL_0d72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7c: Expected O, but got Unknown
		//IL_0e58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e62: Expected O, but got Unknown
		//IL_0f51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f5b: Expected O, but got Unknown
		//IL_1027: Unknown result type (might be due to invalid IL or missing references)
		//IL_1031: Expected O, but got Unknown
		//IL_110c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1116: Expected O, but got Unknown
		//IL_11e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ec: Expected O, but got Unknown
		//IL_12c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_12cf: Expected O, but got Unknown
		//IL_13a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_13b3: Expected O, but got Unknown
		//IL_1473: Unknown result type (might be due to invalid IL or missing references)
		//IL_147d: Expected O, but got Unknown
		//IL_1557: Unknown result type (might be due to invalid IL or missing references)
		//IL_1561: Expected O, but got Unknown
		//IL_163a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1644: Expected O, but got Unknown
		//IL_16fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1708: Expected O, but got Unknown
		//IL_17c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_17cc: Expected O, but got Unknown
		//IL_18a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_18ac: Expected O, but got Unknown
		//IL_1982: Unknown result type (might be due to invalid IL or missing references)
		//IL_198c: Expected O, but got Unknown
		//IL_1c50: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c5a: Expected O, but got Unknown
		//IL_1c6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c79: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMDUpdExpMod));
		ToolTip1 = new ToolTip(components);
		chkUncertainty = new CheckBox();
		_cmbChar_0 = new ComboBox();
		_cmbChar_1 = new ComboBox();
		_txtChar_0 = new TextBox();
		_txtChar_1 = new TextBox();
		cmbInput = new ComboBox();
		txtEquation = new TextBox();
		cmbChemState = new ComboBox();
		txtInput = new TextBox();
		txtBasis = new TextBox();
		cmdCancel = new Button();
		cmdOk = new Button();
		msfExpParms = new AxMSFlexGrid();
		_chkOutputOn_0 = new CheckBox();
		_chkOutputOn_1 = new CheckBox();
		_lblCmCvOption_1 = new Label();
		_Label1_4 = new Label();
		_lblCmCvOption_0 = new Label();
		_Label1_6 = new Label();
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
		lblCmCvOption = new LabelArray(components);
		txtChar = new TextBoxArray(components);
		CachedIRERcomb1 = new CachedIRERcomb();
		((ISupportInitialize)msfExpParms).BeginInit();
		((ISupportInitialize)Label1).BeginInit();
		((ISupportInitialize)chkOutputOn).BeginInit();
		((ISupportInitialize)cmbChar).BeginInit();
		((ISupportInitialize)lblCmCvOption).BeginInit();
		((ISupportInitialize)txtChar).BeginInit();
		((Control)this).SuspendLayout();
		((ButtonBase)chkUncertainty).BackColor = SystemColors.Control;
		((Control)chkUncertainty).Cursor = Cursors.Default;
		((Control)chkUncertainty).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)chkUncertainty).ForeColor = SystemColors.ControlText;
		CheckBox obj = chkUncertainty;
		Point location = new Point(296, 216);
		((Control)obj).Location = location;
		((Control)chkUncertainty).Name = "chkUncertainty";
		((Control)chkUncertainty).RightToLeft = (RightToLeft)0;
		CheckBox obj2 = chkUncertainty;
		Size size = new Size(481, 25);
		((Control)obj2).Size = size;
		((Control)chkUncertainty).TabIndex = 27;
		((ButtonBase)chkUncertainty).Text = "Uncertainty (estimate based on model, regulatory limit, or data not specific to industry?)";
		((ButtonBase)chkUncertainty).UseVisualStyleBackColor = false;
		_cmbChar_0.BackColor = SystemColors.Window;
		((Control)_cmbChar_0).Cursor = Cursors.Default;
		_cmbChar_0.DropDownStyle = (ComboBoxStyle)2;
		((Control)_cmbChar_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		_cmbChar_0.ForeColor = SystemColors.WindowText;
		cmbChar.SetIndex(_cmbChar_0, (short)0);
		ComboBox cmbChar_ = _cmbChar_0;
		location = new Point(8, 272);
		((Control)cmbChar_).Location = location;
		((Control)_cmbChar_0).Name = "_cmbChar_0";
		((Control)_cmbChar_0).RightToLeft = (RightToLeft)0;
		ComboBox cmbChar_2 = _cmbChar_0;
		size = new Size(177, 22);
		((Control)cmbChar_2).Size = size;
		((Control)_cmbChar_0).TabIndex = 23;
		_cmbChar_1.BackColor = SystemColors.Window;
		((Control)_cmbChar_1).Cursor = Cursors.Default;
		_cmbChar_1.DropDownStyle = (ComboBoxStyle)2;
		((Control)_cmbChar_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		_cmbChar_1.ForeColor = SystemColors.WindowText;
		cmbChar.SetIndex(_cmbChar_1, (short)1);
		ComboBox cmbChar_3 = _cmbChar_1;
		location = new Point(408, 272);
		((Control)cmbChar_3).Location = location;
		((Control)_cmbChar_1).Name = "_cmbChar_1";
		((Control)_cmbChar_1).RightToLeft = (RightToLeft)0;
		ComboBox cmbChar_4 = _cmbChar_1;
		size = new Size(185, 22);
		((Control)cmbChar_4).Size = size;
		((Control)_cmbChar_1).TabIndex = 21;
		_txtChar_0.AcceptsReturn = true;
		((TextBoxBase)_txtChar_0).BackColor = SystemColors.Window;
		((Control)_txtChar_0).Cursor = Cursors.IBeam;
		((Control)_txtChar_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtChar_0).ForeColor = SystemColors.WindowText;
		txtChar.SetIndex(_txtChar_0, (short)0);
		TextBox txtChar_ = _txtChar_0;
		location = new Point(192, 272);
		((Control)txtChar_).Location = location;
		((TextBoxBase)_txtChar_0).MaxLength = 25;
		((Control)_txtChar_0).Name = "_txtChar_0";
		((Control)_txtChar_0).RightToLeft = (RightToLeft)0;
		_txtChar_0.ScrollBars = (ScrollBars)2;
		TextBox txtChar_2 = _txtChar_0;
		size = new Size(145, 20);
		((Control)txtChar_2).Size = size;
		((Control)_txtChar_0).TabIndex = 20;
		_txtChar_1.AcceptsReturn = true;
		((TextBoxBase)_txtChar_1).BackColor = SystemColors.Window;
		((Control)_txtChar_1).Cursor = Cursors.IBeam;
		((Control)_txtChar_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtChar_1).ForeColor = SystemColors.WindowText;
		txtChar.SetIndex(_txtChar_1, (short)1);
		TextBox txtChar_3 = _txtChar_1;
		location = new Point(600, 272);
		((Control)txtChar_3).Location = location;
		((TextBoxBase)_txtChar_1).MaxLength = 25;
		((Control)_txtChar_1).Name = "_txtChar_1";
		((Control)_txtChar_1).RightToLeft = (RightToLeft)0;
		_txtChar_1.ScrollBars = (ScrollBars)2;
		TextBox txtChar_4 = _txtChar_1;
		size = new Size(145, 20);
		((Control)txtChar_4).Size = size;
		((Control)_txtChar_1).TabIndex = 19;
		cmbInput.BackColor = Color.FromArgb(255, 255, 192);
		((Control)cmbInput).Cursor = Cursors.Default;
		cmbInput.DropDownStyle = (ComboBoxStyle)2;
		((Control)cmbInput).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		cmbInput.ForeColor = SystemColors.WindowText;
		ComboBox obj3 = cmbInput;
		location = new Point(64, 568);
		((Control)obj3).Location = location;
		((Control)cmbInput).Name = "cmbInput";
		((Control)cmbInput).RightToLeft = (RightToLeft)0;
		ComboBox obj4 = cmbInput;
		size = new Size(81, 22);
		((Control)obj4).Size = size;
		((Control)cmbInput).TabIndex = 17;
		((Control)cmbInput).Visible = false;
		txtEquation.AcceptsReturn = true;
		((TextBoxBase)txtEquation).BackColor = SystemColors.Window;
		((Control)txtEquation).Cursor = Cursors.IBeam;
		((Control)txtEquation).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtEquation).ForeColor = SystemColors.WindowText;
		TextBox obj5 = txtEquation;
		location = new Point(80, 136);
		((Control)obj5).Location = location;
		((TextBoxBase)txtEquation).MaxLength = 0;
		txtEquation.Multiline = true;
		((Control)txtEquation).Name = "txtEquation";
		((TextBoxBase)txtEquation).ReadOnly = true;
		((Control)txtEquation).RightToLeft = (RightToLeft)0;
		txtEquation.ScrollBars = (ScrollBars)2;
		TextBox obj6 = txtEquation;
		size = new Size(705, 46);
		((Control)obj6).Size = size;
		((Control)txtEquation).TabIndex = 0;
		((Control)txtEquation).TabStop = false;
		cmbChemState.BackColor = SystemColors.Window;
		((Control)cmbChemState).Cursor = Cursors.Default;
		cmbChemState.DropDownStyle = (ComboBoxStyle)2;
		((Control)cmbChemState).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		cmbChemState.ForeColor = SystemColors.WindowText;
		ComboBox obj7 = cmbChemState;
		location = new Point(96, 216);
		((Control)obj7).Location = location;
		((Control)cmbChemState).Name = "cmbChemState";
		((Control)cmbChemState).RightToLeft = (RightToLeft)0;
		ComboBox obj8 = cmbChemState;
		size = new Size(129, 22);
		((Control)obj8).Size = size;
		((Control)cmbChemState).TabIndex = 1;
		txtInput.AcceptsReturn = true;
		((TextBoxBase)txtInput).BackColor = Color.FromArgb(255, 255, 192);
		((Control)txtInput).Cursor = Cursors.IBeam;
		((Control)txtInput).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtInput).ForeColor = SystemColors.WindowText;
		TextBox obj9 = txtInput;
		location = new Point(160, 568);
		((Control)obj9).Location = location;
		((TextBoxBase)txtInput).MaxLength = 0;
		((Control)txtInput).Name = "txtInput";
		((Control)txtInput).RightToLeft = (RightToLeft)0;
		TextBox obj10 = txtInput;
		size = new Size(41, 20);
		((Control)obj10).Size = size;
		((Control)txtInput).TabIndex = 15;
		((Control)txtInput).Visible = false;
		txtBasis.AcceptsReturn = true;
		((TextBoxBase)txtBasis).BackColor = SystemColors.Window;
		((Control)txtBasis).Cursor = Cursors.IBeam;
		((Control)txtBasis).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtBasis).ForeColor = SystemColors.WindowText;
		TextBox obj11 = txtBasis;
		location = new Point(72, 312);
		((Control)obj11).Location = location;
		((TextBoxBase)txtBasis).MaxLength = 0;
		txtBasis.Multiline = true;
		((Control)txtBasis).Name = "txtBasis";
		((Control)txtBasis).RightToLeft = (RightToLeft)0;
		txtBasis.ScrollBars = (ScrollBars)2;
		TextBox obj12 = txtBasis;
		size = new Size(705, 41);
		((Control)obj12).Size = size;
		((Control)txtBasis).TabIndex = 2;
		((ButtonBase)cmdCancel).BackColor = SystemColors.Control;
		((Control)cmdCancel).Cursor = Cursors.Default;
		cmdCancel.DialogResult = (DialogResult)2;
		((Control)cmdCancel).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCancel).ForeColor = SystemColors.ControlText;
		Button obj13 = cmdCancel;
		location = new Point(400, 512);
		((Control)obj13).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		((Control)cmdCancel).RightToLeft = (RightToLeft)0;
		Button obj14 = cmdCancel;
		size = new Size(81, 25);
		((Control)obj14).Size = size;
		((Control)cmdCancel).TabIndex = 5;
		((ButtonBase)cmdCancel).Text = "Cancel";
		((ButtonBase)cmdCancel).UseVisualStyleBackColor = false;
		((ButtonBase)cmdOk).BackColor = SystemColors.Control;
		((Control)cmdOk).Cursor = Cursors.Default;
		((Control)cmdOk).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdOk).ForeColor = SystemColors.ControlText;
		Button obj15 = cmdOk;
		location = new Point(304, 512);
		((Control)obj15).Location = location;
		((Control)cmdOk).Name = "cmdOk";
		((Control)cmdOk).RightToLeft = (RightToLeft)0;
		Button obj16 = cmdOk;
		size = new Size(81, 25);
		((Control)obj16).Size = size;
		((Control)cmdOk).TabIndex = 4;
		((ButtonBase)cmdOk).Text = "OK";
		((ButtonBase)cmdOk).UseVisualStyleBackColor = false;
		AxMSFlexGrid obj17 = msfExpParms;
		location = new Point(8, 376);
		((Control)obj17).Location = location;
		((Control)msfExpParms).Name = "msfExpParms";
		((AxHost)msfExpParms).OcxState = (State)componentResourceManager.GetObject("msfExpParms.OcxState");
		AxMSFlexGrid obj18 = msfExpParms;
		size = new Size(777, 129);
		((Control)obj18).Size = size;
		((Control)msfExpParms).TabIndex = 3;
		((ButtonBase)_chkOutputOn_0).BackColor = SystemColors.Control;
		((Control)_chkOutputOn_0).Cursor = Cursors.Default;
		((Control)_chkOutputOn_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_chkOutputOn_0).ForeColor = SystemColors.ControlText;
		chkOutputOn.SetIndex(_chkOutputOn_0, (short)0);
		CheckBox chkOutputOn_ = _chkOutputOn_0;
		location = new Point(8, 248);
		((Control)chkOutputOn_).Location = location;
		((Control)_chkOutputOn_0).Name = "_chkOutputOn_0";
		((Control)_chkOutputOn_0).RightToLeft = (RightToLeft)0;
		CheckBox chkOutputOn_2 = _chkOutputOn_0;
		size = new Size(265, 25);
		((Control)chkOutputOn_2).Size = size;
		((Control)_chkOutputOn_0).TabIndex = 24;
		((ButtonBase)_chkOutputOn_0).Text = "Enable Model Parameters for Output 1";
		((ButtonBase)_chkOutputOn_0).UseVisualStyleBackColor = false;
		((ButtonBase)_chkOutputOn_1).BackColor = SystemColors.Control;
		((Control)_chkOutputOn_1).Cursor = Cursors.Default;
		((Control)_chkOutputOn_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_chkOutputOn_1).ForeColor = SystemColors.ControlText;
		chkOutputOn.SetIndex(_chkOutputOn_1, (short)1);
		CheckBox chkOutputOn_3 = _chkOutputOn_1;
		location = new Point(408, 248);
		((Control)chkOutputOn_3).Location = location;
		((Control)_chkOutputOn_1).Name = "_chkOutputOn_1";
		((Control)_chkOutputOn_1).RightToLeft = (RightToLeft)0;
		CheckBox chkOutputOn_4 = _chkOutputOn_1;
		size = new Size(257, 25);
		((Control)chkOutputOn_4).Size = size;
		((Control)_chkOutputOn_1).TabIndex = 22;
		((ButtonBase)_chkOutputOn_1).Text = "Enable Model Parameters for Output 2";
		((ButtonBase)_chkOutputOn_1).UseVisualStyleBackColor = false;
		((Control)_lblCmCvOption_1).BackColor = Color.FromArgb(255, 128, 255);
		((Control)_lblCmCvOption_1).Cursor = Cursors.Default;
		((Control)_lblCmCvOption_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblCmCvOption_1).ForeColor = SystemColors.ControlText;
		lblCmCvOption.SetIndex(_lblCmCvOption_1, (short)1);
		Label lblCmCvOption_ = _lblCmCvOption_1;
		location = new Point(584, 568);
		((Control)lblCmCvOption_).Location = location;
		((Control)_lblCmCvOption_1).Name = "_lblCmCvOption_1";
		((Control)_lblCmCvOption_1).RightToLeft = (RightToLeft)0;
		Label lblCmCvOption_2 = _lblCmCvOption_1;
		size = new Size(41, 17);
		((Control)lblCmCvOption_2).Size = size;
		((Control)_lblCmCvOption_1).TabIndex = 26;
		((Control)_lblCmCvOption_1).Visible = false;
		((Control)_Label1_4).BackColor = SystemColors.Control;
		((Control)_Label1_4).Cursor = Cursors.Default;
		((Control)_Label1_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_4).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_4, (short)4);
		Label label1_ = _Label1_4;
		location = new Point(8, 360);
		((Control)label1_).Location = location;
		((Control)_Label1_4).Name = "_Label1_4";
		((Control)_Label1_4).RightToLeft = (RightToLeft)0;
		Label label1_2 = _Label1_4;
		size = new Size(97, 17);
		((Control)label1_2).Size = size;
		((Control)_Label1_4).TabIndex = 25;
		_Label1_4.Text = "Parameters:";
		((Control)_lblCmCvOption_0).BackColor = Color.FromArgb(255, 128, 255);
		((Control)_lblCmCvOption_0).Cursor = Cursors.Default;
		((Control)_lblCmCvOption_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblCmCvOption_0).ForeColor = SystemColors.ControlText;
		lblCmCvOption.SetIndex(_lblCmCvOption_0, (short)0);
		Label lblCmCvOption_3 = _lblCmCvOption_0;
		location = new Point(520, 568);
		((Control)lblCmCvOption_3).Location = location;
		((Control)_lblCmCvOption_0).Name = "_lblCmCvOption_0";
		((Control)_lblCmCvOption_0).RightToLeft = (RightToLeft)0;
		Label lblCmCvOption_4 = _lblCmCvOption_0;
		size = new Size(41, 17);
		((Control)lblCmCvOption_4).Size = size;
		((Control)_lblCmCvOption_0).TabIndex = 18;
		((Control)_lblCmCvOption_0).Visible = false;
		((Control)_Label1_6).BackColor = SystemColors.Control;
		((Control)_Label1_6).Cursor = Cursors.Default;
		((Control)_Label1_6).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_6).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_6, (short)6);
		Label label1_3 = _Label1_6;
		location = new Point(0, 216);
		((Control)label1_3).Location = location;
		((Control)_Label1_6).Name = "_Label1_6";
		((Control)_Label1_6).RightToLeft = (RightToLeft)0;
		Label label1_4 = _Label1_6;
		size = new Size(89, 17);
		((Control)label1_4).Size = size;
		((Control)_Label1_6).TabIndex = 16;
		_Label1_6.Text = "Chemical State: ";
		_Label1_6.TextAlign = (ContentAlignment)4;
		((Control)_Label1_5).BackColor = SystemColors.Control;
		((Control)_Label1_5).Cursor = Cursors.Default;
		((Control)_Label1_5).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_5).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_5, (short)5);
		Label label1_5 = _Label1_5;
		location = new Point(16, 312);
		((Control)label1_5).Location = location;
		((Control)_Label1_5).Name = "_Label1_5";
		((Control)_Label1_5).RightToLeft = (RightToLeft)0;
		Label label1_6 = _Label1_5;
		size = new Size(41, 17);
		((Control)label1_6).Size = size;
		((Control)_Label1_5).TabIndex = 14;
		_Label1_5.Text = "Basis:";
		_Label1_5.TextAlign = (ContentAlignment)4;
		((Control)lblMechanism).BackColor = SystemColors.Control;
		((Control)lblMechanism).Cursor = Cursors.Default;
		((Control)lblMechanism).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblMechanism).ForeColor = SystemColors.ControlText;
		Label obj19 = lblMechanism;
		location = new Point(136, 185);
		((Control)obj19).Location = location;
		((Control)lblMechanism).Name = "lblMechanism";
		((Control)lblMechanism).RightToLeft = (RightToLeft)0;
		Label obj20 = lblMechanism;
		size = new Size(649, 17);
		((Control)obj20).Size = size;
		((Control)lblMechanism).TabIndex = 13;
		lblMechanism.Text = "x";
		((Control)_Label1_3).BackColor = SystemColors.Control;
		((Control)_Label1_3).Cursor = Cursors.Default;
		((Control)_Label1_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_3).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_3, (short)3);
		Label label1_7 = _Label1_3;
		location = new Point(16, 136);
		((Control)label1_7).Location = location;
		((Control)_Label1_3).Name = "_Label1_3";
		((Control)_Label1_3).RightToLeft = (RightToLeft)0;
		Label label1_8 = _Label1_3;
		size = new Size(57, 33);
		((Control)label1_8).Size = size;
		((Control)_Label1_3).TabIndex = 12;
		_Label1_3.Text = "Model Equation:";
		_Label1_3.TextAlign = (ContentAlignment)4;
		((Control)_Label1_2).BackColor = SystemColors.Control;
		((Control)_Label1_2).Cursor = Cursors.Default;
		((Control)_Label1_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_2).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_2, (short)2);
		Label label1_9 = _Label1_2;
		location = new Point(8, 185);
		((Control)label1_9).Location = location;
		((Control)_Label1_2).Name = "_Label1_2";
		((Control)_Label1_2).RightToLeft = (RightToLeft)0;
		Label label1_10 = _Label1_2;
		size = new Size(113, 25);
		((Control)label1_10).Size = size;
		((Control)_Label1_2).TabIndex = 11;
		_Label1_2.Text = "Potential Route / Form(s) of Exposure:";
		_Label1_2.TextAlign = (ContentAlignment)4;
		((Control)lblModelName).BackColor = SystemColors.Control;
		((Control)lblModelName).Cursor = Cursors.Default;
		((Control)lblModelName).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblModelName).ForeColor = SystemColors.ControlText;
		Label obj21 = lblModelName;
		location = new Point(80, 112);
		((Control)obj21).Location = location;
		((Control)lblModelName).Name = "lblModelName";
		((Control)lblModelName).RightToLeft = (RightToLeft)0;
		Label obj22 = lblModelName;
		size = new Size(713, 17);
		((Control)obj22).Size = size;
		((Control)lblModelName).TabIndex = 10;
		lblModelName.Text = "x";
		((Control)lblAct).BackColor = SystemColors.Control;
		((Control)lblAct).Cursor = Cursors.Default;
		((Control)lblAct).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblAct).ForeColor = SystemColors.ControlText;
		Label obj23 = lblAct;
		location = new Point(80, 96);
		((Control)obj23).Location = location;
		((Control)lblAct).Name = "lblAct";
		((Control)lblAct).RightToLeft = (RightToLeft)0;
		Label obj24 = lblAct;
		size = new Size(705, 17);
		((Control)obj24).Size = size;
		((Control)lblAct).TabIndex = 9;
		lblAct.Text = "x";
		((Control)_Label1_1).BackColor = SystemColors.Control;
		((Control)_Label1_1).Cursor = Cursors.Default;
		((Control)_Label1_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_1).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_1, (short)1);
		Label label1_11 = _Label1_1;
		location = new Point(16, 112);
		((Control)label1_11).Location = location;
		((Control)_Label1_1).Name = "_Label1_1";
		((Control)_Label1_1).RightToLeft = (RightToLeft)0;
		Label label1_12 = _Label1_1;
		size = new Size(57, 17);
		((Control)label1_12).Size = size;
		((Control)_Label1_1).TabIndex = 8;
		_Label1_1.Text = "Model:";
		_Label1_1.TextAlign = (ContentAlignment)4;
		((Control)_Label1_0).BackColor = SystemColors.Control;
		((Control)_Label1_0).Cursor = Cursors.Default;
		((Control)_Label1_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_0).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_0, (short)0);
		Label label1_13 = _Label1_0;
		location = new Point(16, 96);
		((Control)label1_13).Location = location;
		((Control)_Label1_0).Name = "_Label1_0";
		((Control)_Label1_0).RightToLeft = (RightToLeft)0;
		Label label1_14 = _Label1_0;
		size = new Size(57, 17);
		((Control)label1_14).Size = size;
		((Control)_Label1_0).TabIndex = 7;
		_Label1_0.Text = "Activity:";
		_Label1_0.TextAlign = (ContentAlignment)4;
		((Control)lblInstructions).BackColor = SystemColors.Control;
		((Control)lblInstructions).Cursor = Cursors.Default;
		((Control)lblInstructions).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblInstructions).ForeColor = SystemColors.ControlText;
		Label obj25 = lblInstructions;
		location = new Point(8, 8);
		((Control)obj25).Location = location;
		((Control)lblInstructions).Name = "lblInstructions";
		((Control)lblInstructions).RightToLeft = (RightToLeft)0;
		Label obj26 = lblInstructions;
		size = new Size(777, 81);
		((Control)obj26).Size = size;
		((Control)lblInstructions).TabIndex = 6;
		lblInstructions.Text = "xxx";
		size = new Size(5, 13);
		((Form)this).AutoScaleBaseSize = size;
		((Form)this).CancelButton = (IButtonControl)(object)cmdCancel;
		size = new Size(794, 552);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)chkUncertainty);
		((Control)this).Controls.Add((Control)(object)_cmbChar_0);
		((Control)this).Controls.Add((Control)(object)_cmbChar_1);
		((Control)this).Controls.Add((Control)(object)_txtChar_0);
		((Control)this).Controls.Add((Control)(object)_txtChar_1);
		((Control)this).Controls.Add((Control)(object)cmbInput);
		((Control)this).Controls.Add((Control)(object)txtEquation);
		((Control)this).Controls.Add((Control)(object)cmbChemState);
		((Control)this).Controls.Add((Control)(object)txtInput);
		((Control)this).Controls.Add((Control)(object)txtBasis);
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)cmdOk);
		((Control)this).Controls.Add((Control)(object)msfExpParms);
		((Control)this).Controls.Add((Control)(object)_chkOutputOn_0);
		((Control)this).Controls.Add((Control)(object)_chkOutputOn_1);
		((Control)this).Controls.Add((Control)(object)_lblCmCvOption_1);
		((Control)this).Controls.Add((Control)(object)_Label1_4);
		((Control)this).Controls.Add((Control)(object)_lblCmCvOption_0);
		((Control)this).Controls.Add((Control)(object)_Label1_6);
		((Control)this).Controls.Add((Control)(object)_Label1_5);
		((Control)this).Controls.Add((Control)(object)lblMechanism);
		((Control)this).Controls.Add((Control)(object)_Label1_3);
		((Control)this).Controls.Add((Control)(object)_Label1_2);
		((Control)this).Controls.Add((Control)(object)lblModelName);
		((Control)this).Controls.Add((Control)(object)lblAct);
		((Control)this).Controls.Add((Control)(object)_Label1_1);
		((Control)this).Controls.Add((Control)(object)_Label1_0);
		((Control)this).Controls.Add((Control)(object)lblInstructions);
		((Control)this).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		location = new Point(250, 150);
		((Form)this).Location = location;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmMDUpdExpMod";
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "View / Update Exposure Model Information";
		((ISupportInitialize)msfExpParms).EndInit();
		((ISupportInitialize)Label1).EndInit();
		((ISupportInitialize)chkOutputOn).EndInit();
		((ISupportInitialize)cmbChar).EndInit();
		((ISupportInitialize)lblCmCvOption).EndInit();
		((ISupportInitialize)txtChar).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void chkOutputOn_CheckStateChanged(object eventSender, EventArgs eventArgs)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
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
				if (num4 <= num5)
				{
					msfExpParms[unchecked((int)num3)] = Conversions.ToInteger(Interaction.IIf(((Control)cmbChar[index]).Enabled, (object)1300, (object)0));
					num3 = (short)unchecked(num3 + 1);
					continue;
				}
				break;
			}
		}
	}

	private void cmbChar_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		short index = cmbChar.GetIndex((ComboBox)eventSender);
		if (cmbChar[index].SelectedIndex == GC_USER_INPUT)
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
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		if (cmbInput.SelectedIndex == -1)
		{
			((Control)cmbInput).Visible = true;
			Interaction.MsgBox((object)"Please enter a selection.", (MsgBoxStyle)64, (object)"Invalid Input");
			((Control)cmbInput).Focus();
			return;
		}
		bool flag = default(bool);
		if (msfExpParms.Col == 2)
		{
			iColIndex = 2;
			flag = true;
		}
		else if (msfExpParms.Col == 6)
		{
			iColIndex = 6;
			flag = true;
		}
		if (flag & (Operators.CompareString(msfExpParms[Conversions.ToInteger(((Control)cmbInput).Tag), (int)iColIndex], cmbInput.Text, false) != 0))
		{
			msfExpParms[Conversions.ToInteger(((Control)cmbInput).Tag), (int)iColIndex] = cmbInput.Text;
			string text;
			checked
			{
				if (Operators.CompareString(cmbInput.Text, "Default", false) == 0)
				{
					if (Conversions.ToDouble(msfExpParms[Conversions.ToInteger(((Control)cmbInput).Tag), 0]) == 113.0)
					{
						msfExpParms[Conversions.ToInteger(((Control)cmbInput).Tag), iColIndex + 2] = Conversions.ToString(MyRecalcYsNonMetaDefault());
						msfExpParms[msfExpParms.Row, iColIndex + 1] = "Model Parm";
					}
					else if (Conversions.ToDouble(msfExpParms[Conversions.ToInteger(((Control)cmbInput).Tag), 0]) == 96.0)
					{
						DefaultYpelWhenYpelDefaultReselected();
						msfExpParms[msfExpParms.Row, iColIndex + 1] = "Model Parm";
					}
					else
					{
						short num = Conversions.ToShort(msfExpParms[msfExpParms.Row, 0]);
						short pActID = Globals_Renamed.arSelActType[frmMain.DefInstance.cmbExpActs.SelectedIndex, Globals_Renamed.intOpIndex];
						msfExpParms[msfExpParms.Row, iColIndex + 2] = Conversions.ToString(ChemStrX.GetModelDefault(Globals_Renamed.arParmDS[num], num, ref MyModelType, ref pActID, ref Globals_Renamed.intModIndex, ref iDualIndex));
						if (Conversions.ToDouble(msfExpParms[msfExpParms.Row, iColIndex + 2]) == -1.0)
						{
							msfExpParms[msfExpParms.Row, iColIndex + 2] = Conversions.ToString(0);
						}
						msfExpParms[msfExpParms.Row, iColIndex + 1] = ChemStrX.SetVCLabel(ref Globals_Renamed.arParmDS[num]);
					}
				}
				else
				{
					msfExpParms[msfExpParms.Row, iColIndex + 2] = "0";
					msfExpParms[msfExpParms.Row, iColIndex + 1] = "User Specified";
				}
				text = msfExpParms[msfExpParms.Row, 0];
			}
			if ((Operators.CompareString(text, Conversions.ToString(5), false) == 0 || Operators.CompareString(text, Conversions.ToString(63), false) == 0 || Operators.CompareString(text, Conversions.ToString(78), false) == 0) ? true : false)
			{
				CheckCm();
			}
			else if ((Operators.CompareString(text, Conversions.ToString(68), false) == 0 || Operators.CompareString(text, Conversions.ToString(59), false) == 0) && ((iYsRow > 0) & (Operators.CompareString(msfExpParms[(int)iYsRow, (int)iColIndex], "Default", false) == 0)))
			{
				msfExpParms[(int)iYsRow, checked(iColIndex + 2)] = Conversions.ToString(MyRecalcYsNonMetaDefault());
			}
		}
		((Control)cmbInput).Visible = false;
	}

	private void cmdCancel_Click(object eventSender, EventArgs eventArgs)
	{
		((Control)this).Tag = "Cancel";
		((Control)this).Hide();
	}

	private void frmMDUpdExpMod_Load(object eventSender, EventArgs eventArgs)
	{
	}

	private void cmdOk_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_09fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a00: Invalid comparison between Unknown and I4
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7d: Invalid comparison between Unknown and I4
		int try0001_dispatch = -1;
		int num2 = default(int);
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
						switch (MyModelType)
						{
						case 21:
						case 23:
						case 24:
						case 45:
						case 47:
							if (!Validate_AT())
							{
								goto end_IL_0001;
							}
							break;
						case 25:
						case 26:
						case 27:
						case 28:
						case 29:
						case 44:
							if (!Validate_AT())
							{
								goto end_IL_0001;
							}
							break;
						case 22:
						case 46:
						case 54:
							if (Validate_AT() && Validate_BW())
							{
								break;
							}
							goto end_IL_0001_2;
						}
						if (myType == 0)
						{
							AxMSFlexGrid pGridCopy = msfExpParms;
							frmMain defInstance = frmMain.DefInstance;
							AxMSFlexGrid pGridTo = defInstance._msfExpParms_0;
							ChemStrX.CloneFlexGrid(ref pGridCopy, ref pGridTo);
							defInstance._msfExpParms_0 = pGridTo;
							msfExpParms = pGridCopy;
						}
						else
						{
							AxMSFlexGrid pGridTo = msfExpParms;
							frmMain defInstance = frmMain.DefInstance;
							AxMSFlexGrid pGridCopy = defInstance._msfExpParms_1;
							ChemStrX.CloneFlexGrid(ref pGridTo, ref pGridCopy);
							defInstance._msfExpParms_1 = pGridCopy;
							msfExpParms = pGridTo;
						}
						short num3 = (short)(msfExpParms.Rows - 1);
						short num4 = 1;
						while (true)
						{
							IL_0958:
							short num5 = num4;
							short num6 = num3;
							short num7;
							if (num5 <= num6)
							{
								num7 = 0;
								while (true)
								{
									iColIndex = (short)(2 + num7 * 4);
									unchecked
									{
										short num8;
										switch (msfExpParms[(int)num4, (int)iColIndex])
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
											goto end_IL_0198;
										}
										Globals_Renamed.arExpModParmsT[num7, Conversions.ToInteger(msfExpParms[(int)num4, 0]), Globals_Renamed.intModIndex] = num8;
										string text = msfExpParms[(int)num4, 0];
										if ((Operators.CompareString(text, Conversions.ToString(92), false) == 0 || Operators.CompareString(text, Conversions.ToString(76), false) == 0 || Operators.CompareString(text, Conversions.ToString(77), false) == 0 || Operators.CompareString(text, Conversions.ToString(78), false) == 0 || Operators.CompareString(text, Conversions.ToString(61), false) == 0 || Operators.CompareString(text, Conversions.ToString(59), false) == 0) ? true : false)
										{
											Globals_Renamed.arExpModParmsVC[num7, Conversions.ToInteger(msfExpParms[(int)num4, 0]), Globals_Renamed.intModIndex] = Conversions.ToShort(msfExpParms[(int)num4, checked(iColIndex + 3)]);
											Globals_Renamed.arExpModParmsV[num7, Conversions.ToInteger(msfExpParms[(int)num4, 0]), Globals_Renamed.intModIndex] = Conversions.ToSingle(msfExpParms[(int)num4, checked(iColIndex + 2)]);
										}
										else if (Operators.CompareString(text, Conversions.ToString(40), false) == 0 || Operators.CompareString(text, Conversions.ToString(75), false) == 0)
										{
											if (Conversions.ToDouble(msfExpParms[(int)num4, checked(iColIndex + 3)]) == -123.0)
											{
												Globals_Renamed.arExpModParmsVC[num7, Conversions.ToInteger(msfExpParms[(int)num4, 0]), Globals_Renamed.intModIndex] = 998;
											}
											else
											{
												Globals_Renamed.arExpModParmsVC[num7, Conversions.ToInteger(msfExpParms[(int)num4, 0]), Globals_Renamed.intModIndex] = Conversions.ToShort(msfExpParms[(int)num4, checked(iColIndex + 3)]);
											}
											Globals_Renamed.arExpModParmsV[num7, Conversions.ToInteger(msfExpParms[(int)num4, 0]), Globals_Renamed.intModIndex] = Conversions.ToSingle(msfExpParms[(int)num4, checked(iColIndex + 2)]);
										}
										else if (Operators.CompareString(text, Conversions.ToString(91), false) == 0)
										{
											Globals_Renamed.arExpModParmsV[num7, Conversions.ToInteger(msfExpParms[(int)num4, 0]), Globals_Renamed.intModIndex] = Conversions.ToSingle(Common.MyNullCheck0(msfExpParms[(int)num4, checked(iColIndex + 2)]));
											if (Operators.CompareString(msfExpParms[(int)num4, checked(iColIndex + 1)], "User-defined", false) == 0)
											{
												Globals_Renamed.arExpModParmsVC[num7, Conversions.ToInteger(msfExpParms[(int)num4, 0]), Globals_Renamed.intModIndex] = 999;
												if (intOtherModelIndex >= 0 && Globals_Renamed.arExpModParmsT[num7, Conversions.ToInteger(msfExpParms[(int)num4, 0]), intOtherModelIndex] != 0)
												{
													Globals_Renamed.arExpModParmsT[num7, Conversions.ToInteger(msfExpParms[(int)num4, 0]), intOtherModelIndex] = num8;
													Globals_Renamed.arExpModParmsV[num7, Conversions.ToInteger(msfExpParms[(int)num4, 0]), intOtherModelIndex] = Globals_Renamed.arExpModParmsV[num7, Conversions.ToInteger(msfExpParms[(int)num4, 0]), Globals_Renamed.intModIndex];
													Globals_Renamed.arExpModParmsVC[num7, Conversions.ToInteger(msfExpParms[(int)num4, 0]), intOtherModelIndex] = 999;
												}
											}
											else
											{
												Globals_Renamed.arExpModParmsVC[num7, Conversions.ToInteger(msfExpParms[(int)num4, 0]), Globals_Renamed.intModIndex] = Globals_Renamed.arParmDS[Conversions.ToInteger(msfExpParms[(int)num4, 0])];
												if (intOtherModelIndex >= 0 && Globals_Renamed.arExpModParmsT[num7, Conversions.ToInteger(msfExpParms[(int)num4, 0]), intOtherModelIndex] != 0)
												{
													Globals_Renamed.arExpModParmsT[num7, Conversions.ToInteger(msfExpParms[(int)num4, 0]), intOtherModelIndex] = num8;
													Globals_Renamed.arExpModParmsV[num7, Conversions.ToInteger(msfExpParms[(int)num4, 0]), intOtherModelIndex] = Globals_Renamed.arExpModParmsV[num7, Conversions.ToInteger(msfExpParms[(int)num4, 0]), Globals_Renamed.intModIndex];
													Globals_Renamed.arExpModParmsVC[num7, Conversions.ToInteger(msfExpParms[(int)num4, 0]), intOtherModelIndex] = 999;
												}
											}
										}
										else if (Operators.CompareString(text, Conversions.ToString(57), false) == 0)
										{
											if (Conversions.ToDouble(msfExpParms[(int)num4, checked(iColIndex + 3)]) > 0.0)
											{
												Globals_Renamed.arExpModParmsV[num7, Conversions.ToInteger(msfExpParms[(int)num4, 0]), Globals_Renamed.intModIndex] = Conversions.ToSingle(msfExpParms[(int)num4, checked(iColIndex + 3)]);
											}
										}
										else if (Operators.CompareString(text, Conversions.ToString(67), false) == 0)
										{
											Globals_Renamed.arExpModParmsV[num7, Conversions.ToInteger(msfExpParms[(int)num4, 0]), Globals_Renamed.intModIndex] = Conversions.ToSingle(Common.MyNullCheck0(msfExpParms[(int)num4, checked(iColIndex + 2)]));
										}
										else if (Operators.CompareString(text, Conversions.ToString(153), false) == 0 || Operators.CompareString(text, Conversions.ToString(154), false) == 0)
										{
											Globals_Renamed.arExpModParmsV[num7, Conversions.ToInteger(msfExpParms[(int)num4, 0]), Globals_Renamed.intModIndex] = Conversions.ToSingle(Common.MyNullCheck0(msfExpParms[(int)num4, checked(iColIndex + 2)]));
										}
										else
										{
											Globals_Renamed.arExpModParmsV[num7, Conversions.ToInteger(msfExpParms[(int)num4, 0]), Globals_Renamed.intModIndex] = Conversions.ToSingle(Common.MyNullCheck0(msfExpParms[(int)num4, checked(iColIndex + 2)]));
											if (Operators.CompareString(msfExpParms[(int)num4, (int)iColIndex], "User-defined", false) == 0)
											{
												Globals_Renamed.arExpModParmsVC[num7, Conversions.ToInteger(msfExpParms[(int)num4, 0]), Globals_Renamed.intModIndex] = 999;
											}
											else
											{
												Globals_Renamed.arExpModParmsVC[num7, Conversions.ToInteger(msfExpParms[(int)num4, 0]), Globals_Renamed.intModIndex] = Globals_Renamed.arParmDS[Conversions.ToInteger(msfExpParms[(int)num4, 0])];
											}
										}
									}
									num7 = (short)unchecked(num7 + 1);
									short num9 = num7;
									num6 = 1;
									if (num9 <= num6)
									{
										continue;
									}
									num4 = (short)unchecked(num4 + 1);
									goto IL_0958;
									continue;
									end_IL_0198:
									break;
								}
								break;
							}
							Globals_Renamed.arExpModBasis[Globals_Renamed.arExpModels[myType, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1] = txtBasis.Text;
							if (Globals_Renamed.arExpModStatus[Globals_Renamed.arExpModels[myType, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1] > 0)
							{
								Globals_Renamed.arExpModStatus[Globals_Renamed.arExpModels[myType, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1] = 3;
							}
							num4 = 0;
							short num10;
							do
							{
								Globals_Renamed.arExpModOutputOn[num4, Globals_Renamed.intModIndex] = Conversions.ToShort(Interaction.IIf(unchecked((int)chkOutputOn[num4].CheckState) == 1, (object)1, (object)0));
								int selectedIndex = cmbChar[num4].SelectedIndex;
								if (selectedIndex == -1)
								{
									Globals_Renamed.arExpModChar[num4, Globals_Renamed.intModIndex] = "";
								}
								else if (selectedIndex == GC_USER_INPUT)
								{
									Globals_Renamed.arExpModChar[num4, Globals_Renamed.intModIndex] = txtChar[num4].Text;
								}
								else
								{
									Globals_Renamed.arExpModChar[num4, Globals_Renamed.intModIndex] = cmbChar[num4].Text;
								}
								num4 = (short)unchecked(num4 + 1);
								num10 = num4;
								num6 = 1;
							}
							while (num10 <= num6);
							if (cmbChemState.SelectedIndex == -1)
							{
								Globals_Renamed.arExpModChmSt[Globals_Renamed.arExpModels[myType, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1] = 0;
							}
							else
							{
								Globals_Renamed.arExpModChmSt[Globals_Renamed.arExpModels[myType, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1] = (short)Support.GetItemData((Control)(object)cmbChemState, cmbChemState.SelectedIndex);
							}
							object pOpIndex = Globals_Renamed.intOpIndex;
							ChemStrX.resetInhRespClass(ref pOpIndex);
							Globals_Renamed.intOpIndex = Conversions.ToShort(pOpIndex);
							Globals_Renamed.arExpModUncertainty[Globals_Renamed.arExpModels[myType, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1] = Conversions.ToShort(Interaction.IIf(unchecked((int)chkUncertainty.CheckState) == 1, (object)(short)1, (object)0));
							num7 = 0;
							short num11;
							do
							{
								if (Versioned.IsNumeric((object)lblCmCvOption[num7].Text))
								{
									Globals_Renamed.arExpModParmsV[num7, 54, Globals_Renamed.intModIndex] = Conversions.ToShort(lblCmCvOption[num7].Text);
									Globals_Renamed.arExpModParmsT[num7, 54, Globals_Renamed.intModIndex] = 2;
								}
								num7 = (short)unchecked(num7 + 1);
								num11 = num7;
								num6 = 1;
							}
							while (num11 <= num6);
							frmMain defInstance2 = frmMain.DefInstance;
							short pModel = 0;
							defInstance2.LoadExpParms(ref pModel);
							frmMain defInstance3 = frmMain.DefInstance;
							pModel = 1;
							defInstance3.LoadExpParms(ref pModel);
							Globals_Renamed.gblIWasChanged = true;
							((Control)this).Tag = "";
							((Control)this).Hide();
							break;
						}
						goto end_IL_0001_2;
					}
					case 3233:
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
							goto end_IL_0001_2;
						}
						}
						break;
					}
					goto IL_0cdb;
				}
				end_IL_0001_2:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 3233;
				continue;
			}
			break;
			IL_0cdb:
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

	public bool SetUp(ref short pModel)
	{
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Expected O, but got Unknown
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
						Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
						Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
						Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						ProjectData.ClearProjectError();
						num2 = 2;
						myType = pModel;
						MyModelType = Globals_Renamed.arExpModType[Globals_Renamed.arExpModels[pModel, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1];
						if (pModel == 0)
						{
							intOtherModelIndex = (short)(Globals_Renamed.arExpModels[1, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1);
							((Control)chkUncertainty).Visible = false;
						}
						else
						{
							intOtherModelIndex = (short)(Globals_Renamed.arExpModels[0, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1);
						}
						command.ActiveConnection = Common.MyConn;
						command.CommandText = "pqryGetInstructions";
						command.CommandType = CommandTypeEnum.adCmdStoredProc;
						command.Parameters.Append(command.CreateParameter("pID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, 29));
						Command command2 = command;
						object RecordsAffected = Missing.Value;
						object Parameters = Missing.Value;
						recordset = command2.Execute(out RecordsAffected, ref Parameters);
						command.Parameters.Delete("pID");
						lblInstructions.Text = Conversions.ToString(recordset.Fields[0].Value);
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
						if (myType == 0)
						{
							frmMain defInstance = frmMain.DefInstance;
							AxMSFlexGrid pGridCopy = defInstance._msfExpParms_0;
							AxMSFlexGrid pGridTo = msfExpParms;
							ChemStrX.CloneFlexGrid(ref pGridCopy, ref pGridTo);
							msfExpParms = pGridTo;
							defInstance._msfExpParms_0 = pGridCopy;
						}
						else
						{
							frmMain defInstance = frmMain.DefInstance;
							AxMSFlexGrid pGridTo = defInstance._msfExpParms_1;
							AxMSFlexGrid pGridCopy = msfExpParms;
							ChemStrX.CloneFlexGrid(ref pGridTo, ref pGridCopy);
							msfExpParms = pGridCopy;
							defInstance._msfExpParms_1 = pGridTo;
						}
						short num3 = 2;
						short num4;
						short num5;
						do
						{
							msfExpParms[unchecked((int)num3)] = 0;
							num3 = (short)unchecked(num3 + 1);
							num4 = num3;
							num5 = 9;
						}
						while (num4 <= num5);
						short num6 = (short)(msfExpParms.Rows - 1);
						num3 = 1;
						while (true)
						{
							short num7 = num3;
							num5 = num6;
							if (num7 > num5)
							{
								break;
							}
							unchecked
							{
								if ((Conversions.ToDouble(msfExpParms[(int)num3, 0]) == 113.0) | (Conversions.ToDouble(msfExpParms[(int)num3, 0]) == 78.0))
								{
									iYsRow = num3;
								}
								else if (Conversions.ToDouble(msfExpParms[(int)num3, 0]) == 96.0)
								{
									iYpelRow = num3;
								}
							}
							num3 = (short)unchecked(num3 + 1);
						}
						if (Globals_Renamed.arExpModChmSt[Globals_Renamed.arExpModels[myType, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1] > 10)
						{
							recordset.Open("SELECT * FROM qryListChemStatesD", Common.MyConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
						}
						else
						{
							recordset.Open("SELECT * FROM qryListChemStatesI", Common.MyConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
						}
						while (!recordset.EOF)
						{
							cmbChemState.Items.Add((object)new ListBoxItem(Conversions.ToString(recordset.Fields[1].Value), Conversions.ToInteger(recordset.Fields[0].Value)));
							recordset.MoveNext();
						}
						recordset.Close();
						if (Globals_Renamed.arExpModUncertainty[Globals_Renamed.arExpModels[myType, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1] == 1)
						{
							chkUncertainty.CheckState = (CheckState)1;
						}
						lblAct.Text = frmMain.DefInstance.cmbExpActs.Text;
						if (Globals_Renamed.arExpModels[myType, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] > 0)
						{
							command.CommandText = "pqryGetRelModel";
							command.CommandType = CommandTypeEnum.adCmdStoredProc;
							command.Parameters.Append(command.CreateParameter("pRelModID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, Globals_Renamed.arExpModType[Globals_Renamed.arExpModels[myType, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1]));
							Command command3 = command;
							Parameters = Missing.Value;
							RecordsAffected = Missing.Value;
							recordset = command3.Execute(out Parameters, ref RecordsAffected);
							command.Parameters.Delete("pRelModID");
							lblModelName.Text = Conversions.ToString(recordset.Fields["ModelName"].Value);
							txtEquation.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["Equation"].Value));
							lblMechanism.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["Mechanism"].Value));
							txtBasis.Text = Globals_Renamed.arExpModBasis[Globals_Renamed.arExpModels[myType, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1];
							short num8 = (short)(cmbChemState.Items.Count - 1);
							num3 = 0;
							while (true)
							{
								short num9 = num3;
								num5 = num8;
								if (num9 > num5)
								{
									break;
								}
								if (Support.GetItemData((Control)(object)cmbChemState, unchecked((int)num3)) == Globals_Renamed.arExpModChmSt[Globals_Renamed.arExpModels[myType, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1])
								{
									cmbChemState.SelectedIndex = num3;
									break;
								}
								num3 = (short)unchecked(num3 + 1);
							}
							recordset.Close();
							recordset = null;
							command = null;
						}
						else
						{
							lblModelName.Text = "None specified";
							txtEquation.Text = "n/a";
							lblMechanism.Text = "n/a";
						}
						num3 = 0;
						short num13;
						do
						{
							short num10 = (short)(cmbChar[num3].Items.Count - 1);
							short num11 = 0;
							while (true)
							{
								short num12 = num11;
								num5 = num10;
								if (num12 > num5)
								{
									break;
								}
								if (Operators.CompareString(Support.GetItemString((Control)(object)cmbChar[num3], unchecked((int)num11)), Globals_Renamed.arExpModChar[num3, Globals_Renamed.intModIndex], false) == 0)
								{
									cmbChar[num3].SelectedIndex = num11;
									break;
								}
								num11 = (short)unchecked(num11 + 1);
							}
							if (cmbChar[num3].SelectedIndex == -1)
							{
								cmbChar[num3].SelectedIndex = GC_USER_INPUT;
								txtChar[num3].Text = Globals_Renamed.arExpModChar[num3, Globals_Renamed.intModIndex];
							}
							if (Globals_Renamed.arExpModOutputOn[num3, Globals_Renamed.intModIndex] == 1)
							{
								chkOutputOn[num3].CheckState = (CheckState)1;
							}
							else
							{
								((Control)cmbChar[num3]).Enabled = false;
							}
							num3 = (short)unchecked(num3 + 1);
							num13 = num3;
							num5 = 1;
						}
						while (num13 <= num5);
						flag = true;
						goto end_IL_0001;
					}
					case 2221:
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
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 2221;
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

	private void msfExpParms_ClickEvent(object eventSender, EventArgs eventArgs)
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Invalid comparison between Unknown and I4
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Invalid comparison between Unknown and I4
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Invalid comparison between Unknown and I4
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0585: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_0606: Unknown result type (might be due to invalid IL or missing references)
		if (msfExpParms.Row != msfExpParms.RowSel)
		{
			return;
		}
		bool flag2 = default(bool);
		bool flag = default(bool);
		switch (msfExpParms.Col)
		{
		case 2:
			if ((int)chkOutputOn[(short)0].CheckState != 1)
			{
				return;
			}
			flag2 = true;
			iColIndex = 2;
			iDualIndex = 0;
			break;
		case 4:
			if ((int)chkOutputOn[(short)0].CheckState != 1)
			{
				return;
			}
			flag = true;
			iColIndex = 2;
			iDualIndex = 0;
			break;
		case 6:
			if ((int)chkOutputOn[(short)1].CheckState != 1)
			{
				return;
			}
			flag2 = true;
			iColIndex = 6;
			iDualIndex = 1;
			break;
		case 8:
			if ((int)chkOutputOn[(short)1].CheckState != 1)
			{
				return;
			}
			flag = true;
			iColIndex = 6;
			iDualIndex = 1;
			break;
		}
		checked
		{
			if (flag2)
			{
				string text = msfExpParms[msfExpParms.Row, unchecked((int)iColIndex)];
				if (Operators.CompareString(text, "Default", false) != 0 && Operators.CompareString(text, "Non-default", false) != 0)
				{
					return;
				}
				string text2 = msfExpParms[msfExpParms.Row, 0];
				if ((Operators.CompareString(text2, Conversions.ToString(92), false) == 0 || Operators.CompareString(text2, Conversions.ToString(75), false) == 0 || Operators.CompareString(text2, Conversions.ToString(76), false) == 0 || Operators.CompareString(text2, Conversions.ToString(77), false) == 0 || Operators.CompareString(text2, Conversions.ToString(78), false) == 0 || Operators.CompareString(text2, Conversions.ToString(61), false) == 0 || Operators.CompareString(text2, Conversions.ToString(59), false) == 0 || Operators.CompareString(text2, Conversions.ToString(40), false) == 0) ? true : false)
				{
					frmMDUpdAmtFreq defInstance = frmMDUpdAmtFreq.DefInstance;
					ref short myModelType = ref MyModelType;
					short pCallerID = 1;
					ref short pActID = ref Globals_Renamed.arSelActType[Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex];
					short pDualIndex = Conversions.ToShort(Interaction.IIf(iColIndex == 2, (object)0, (object)1));
					AxMSFlexGrid pMsfParms = msfExpParms;
					bool num = defInstance.SetUp(ref myModelType, ref pCallerID, ref pActID, ref pDualIndex, ref pMsfParms);
					msfExpParms = pMsfParms;
					if (num)
					{
						((Form)frmMDUpdAmtFreq.DefInstance).ShowDialog();
						object pNewYs = msfExpParms[msfExpParms.Row, iColIndex + 2];
						DefaultYpelWhenYsChanges(ref pNewYs);
						if ((Conversions.ToDouble(msfExpParms[msfExpParms.Row, 0]) == 59.0) & ((MyModelType == 18) | (MyModelType == 49) | (MyModelType == 50)))
						{
							msfExpParms[unchecked((int)iYsRow), iColIndex + 2] = Conversions.ToString(MyRecalcYsNonMetaDefault());
						}
					}
					else
					{
						((Form)frmMDUpdAmtFreq.DefInstance).Close();
					}
				}
				else if ((Operators.CompareString(text2, Conversions.ToString(57), false) == 0 || Operators.CompareString(text2, Conversions.ToString(145), false) == 0 || Operators.CompareString(text2, Conversions.ToString(146), false) == 0) ? true : false)
				{
					frmMDUpdRelA10 defInstance2 = frmMDUpdRelA10.DefInstance;
					short pDualIndex = 1;
					ref short myModelType2 = ref MyModelType;
					ref short pActID2 = ref Globals_Renamed.arSelActType[Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex];
					AxMSFlexGrid pMsfParms = msfExpParms;
					bool num2 = defInstance2.SetUp(ref pDualIndex, ref myModelType2, ref pActID2, ref pMsfParms);
					msfExpParms = pMsfParms;
					if (num2)
					{
						((Form)frmMDUpdRelA10.DefInstance).ShowDialog();
					}
					else
					{
						((Form)frmMDUpdRelA10.DefInstance).Close();
					}
				}
				else if ((Operators.CompareString(text2, Conversions.ToString(67), false) == 0 || Operators.CompareString(text2, Conversions.ToString(64), false) == 0 || Operators.CompareString(text2, Conversions.ToString(65), false) == 0) ? true : false)
				{
					short num3 = 0;
					short num4;
					short num5;
					do
					{
						if (!Versioned.IsNumeric((object)lblCmCvOption[num3].Text))
						{
							lblCmCvOption[num3].Text = Conversions.ToString(Globals_Renamed.arExpModParmsV[num3, 54, Globals_Renamed.intModIndex]);
						}
						num3 = (short)unchecked(num3 + 1);
						num4 = num3;
						num5 = 1;
					}
					while (num4 <= num5);
					frmUpdCmCv defInstance3 = frmUpdCmCv.DefInstance;
					short pDualIndex = Conversions.ToShort(Interaction.IIf(msfExpParms.Col == 2, (object)0, (object)1));
					if (defInstance3.SetUp(ref pDualIndex, ref MyModelType))
					{
						((Form)frmUpdCmCv.DefInstance).ShowDialog();
					}
					else
					{
						((Form)frmUpdCmCv.DefInstance).Close();
					}
				}
				else if (Operators.CompareString(text2, Conversions.ToString(81), false) == 0 || Operators.CompareString(text2, Conversions.ToString(37), false) == 0)
				{
					frmMDUpdLF defInstance4 = frmMDUpdLF.DefInstance;
					short pDualIndex = 1;
					if (defInstance4.SetUp(ref pDualIndex, ref MyModelType, msfExpParms))
					{
						((Form)frmMDUpdLF.DefInstance).ShowDialog();
					}
					else
					{
						((Form)frmMDUpdLF.DefInstance).Close();
					}
				}
				else if (Operators.CompareString(text2, Conversions.ToString(55), false) == 0 || Operators.CompareString(text2, Conversions.ToString(56), false) == 0)
				{
					frmMDUpdD defInstance5 = frmMDUpdD.DefInstance;
					short pDualIndex = 1;
					ref short myModelType3 = ref MyModelType;
					short pCallerID = 0;
					AxMSFlexGrid pMsfParms = msfExpParms;
					bool num6 = defInstance5.SetUp(ref pDualIndex, ref myModelType3, ref pCallerID, ref pMsfParms);
					msfExpParms = pMsfParms;
					if (num6)
					{
						((Form)frmMDUpdD.DefInstance).ShowDialog();
					}
					else
					{
						((Form)frmMDUpdD.DefInstance).Close();
					}
				}
				else
				{
					((Control)cmbInput).Left = (int)Math.Round(Support.TwipsToPixelsX(Support.PixelsToTwipsX((double)((Control)msfExpParms).Left) + (double)msfExpParms[msfExpParms.Col] + 50.0));
					((Control)cmbInput).Top = (int)Math.Round(Support.TwipsToPixelsY(Support.PixelsToTwipsY((double)((Control)msfExpParms).Top) + (double)msfExpParms[msfExpParms.Row]));
					((Control)cmbInput).Width = (int)Math.Round(Support.TwipsToPixelsX((double)msfExpParms[msfExpParms.Col]));
					cmbInput.Items.Clear();
					cmbInput.Items.Add((object)"Default");
					cmbInput.Items.Add((object)"Non-default");
					cmbInput.SelectedIndex = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(msfExpParms[msfExpParms.Row, unchecked((int)iColIndex)], "Default", false) == 0, (object)0, (object)1));
					((Control)cmbInput).Tag = msfExpParms.Row;
					((Control)cmbInput).Visible = true;
					((Control)cmbInput).Focus();
				}
			}
			else if (flag & ((Operators.CompareString(msfExpParms[msfExpParms.Row, iColIndex + 1], "User Specified", false) == 0) | (Operators.CompareString(msfExpParms[msfExpParms.Row, iColIndex + 1], "User-defined", false) == 0)))
			{
				if (msfExpParms[msfExpParms.Row] & (msfExpParms.Row < msfExpParms.TopRow + 6))
				{
					((Control)txtInput).Left = (int)Math.Round(Support.TwipsToPixelsX(Support.PixelsToTwipsX((double)((Control)msfExpParms).Left) + (double)msfExpParms[msfExpParms.Col] + 50.0));
					((Control)txtInput).Top = (int)Math.Round(Support.TwipsToPixelsY(Support.PixelsToTwipsY((double)((Control)msfExpParms).Top) + (double)msfExpParms[msfExpParms.Row]));
					((Control)txtInput).Width = (int)Math.Round(Support.TwipsToPixelsX((double)msfExpParms[msfExpParms.Col]));
					txtInput.Text = msfExpParms[msfExpParms.Row, msfExpParms.Col];
					((Control)txtInput).Tag = msfExpParms.Row;
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

	private object ValidateTxtInput()
	{
		if (Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(((Control)txtInput).Tag)))
		{
			short pID = Conversions.ToShort(msfExpParms[Conversions.ToInteger(((Control)txtInput).Tag), 0]);
			TextBox val = txtInput;
			object pValue = val.Text;
			bool num = ChemStrX.ValidateParmInput(ref pID, ref pValue, ref MyModelType);
			val.Text = Conversions.ToString(pValue);
			if (num)
			{
				return true;
			}
			((TextBoxBase)txtInput).SelectionStart = 0;
			((TextBoxBase)txtInput).SelectionLength = Strings.Len(txtInput.Text);
			((Control)txtInput).Focus();
			msfExpParms.Row = Conversions.ToInteger(((Control)txtInput).Tag);
		}
		object result = default(object);
		return result;
	}

	private void msfExpParms_Scroll(object eventSender, EventArgs eventArgs)
	{
		if (((Control)txtInput).Visible)
		{
			txtInput_Leave(txtInput, new EventArgs());
		}
		else if (((Control)cmbInput).Visible)
		{
			cmbInput_Leave(cmbInput, new EventArgs());
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
		if (!((Control)txtInput).Visible)
		{
			return;
		}
		if (Strings.Len(txtInput.Text) > 0)
		{
			if (Versioned.IsNumeric((object)txtInput.Text) & ((Operators.CompareString(txtInput.Text, "0", false) != 0) & (Operators.CompareString(txtInput.Text, "0.", false) != 0)))
			{
				if (Conversions.ToBoolean(ValidateTxtInput()))
				{
					msfExpParms[msfExpParms.Row, checked(iColIndex + 2)] = txtInput.Text;
					TextBox val = txtInput;
					object pNewYs = val.Text;
					DefaultYpelWhenYsChanges(ref pNewYs);
					val.Text = Conversions.ToString(pNewYs);
					string text = msfExpParms[msfExpParms.Row, 0];
					if (Operators.CompareString(text, Conversions.ToString(67), false) == 0)
					{
						MyRecalcCm();
					}
					else if (Operators.CompareString(text, Conversions.ToString(59), false) == 0 || Operators.CompareString(text, Conversions.ToString(68), false) == 0)
					{
						if ((iYsRow > 0) & (Operators.CompareString(msfExpParms[(int)iYsRow, (int)iColIndex], "Default", false) == 0))
						{
							msfExpParms[(int)iYsRow, checked(iColIndex + 2)] = Conversions.ToString(MyRecalcYsNonMetaDefault());
						}
					}
					else if (Operators.CompareString(text, Conversions.ToString(78), false) == 0 && ((iYpelRow > 0) & (MyModelType == 45) & (Operators.CompareString(msfExpParms[(int)iYpelRow, (int)iColIndex], "Default", false) == 0)))
					{
						msfExpParms[(int)iYpelRow, checked(iColIndex + 2)] = Conversions.ToString(MyRecalcYpel());
					}
				}
			}
			else
			{
				msfExpParms[msfExpParms.Row, checked(iColIndex + 2)] = Conversions.ToString(0);
			}
		}
		CheckCm();
	}

	private void txtInput_Enter(object eventSender, EventArgs eventArgs)
	{
		((TextBoxBase)txtInput).SelectionStart = 0;
		((TextBoxBase)txtInput).SelectionLength = Strings.Len(txtInput.Text);
		((Control)txtInput).Tag = msfExpParms.Row;
	}

	private void txtInput_Leave(object eventSender, EventArgs eventArgs)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		if (Strings.Len(txtInput.Text) == 0)
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Invalid number. All user specified parameters must be greater than zero.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
			((TextBoxBase)txtInput).SelectionStart = 0;
			((TextBoxBase)txtInput).SelectionLength = Strings.Len(txtInput.Text);
		}
		else if (!Versioned.IsNumeric((object)txtInput.Text))
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Invalid number. All user specified parameters must be greater than zero.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
			((TextBoxBase)txtInput).SelectionStart = 0;
			((TextBoxBase)txtInput).SelectionLength = Strings.Len(txtInput.Text);
		}
		else if (Conversions.ToBoolean(ValidateTxtInput()))
		{
			((Control)txtInput).Visible = false;
		}
	}

	private bool Validate_AT()
	{
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		float[] array = new float[4];
		float[] array2 = new float[4];
		short num = checked((short)(msfExpParms.Rows - 1));
		short num2 = 1;
		while (true)
		{
			short num3 = num2;
			short num4 = num;
			if (num3 > num4)
			{
				break;
			}
			if (Versioned.IsNumeric((object)msfExpParms[(int)num2, 0]))
			{
				string text = msfExpParms[(int)num2, 0];
				if (Operators.CompareString(text, Conversions.ToString(41), false) == 0)
				{
					array[0] = Conversions.ToSingle(msfExpParms[(int)num2, 4]);
					array2[0] = Conversions.ToSingle(msfExpParms[(int)num2, 8]);
				}
				else if (Operators.CompareString(text, Conversions.ToString(47), false) == 0)
				{
					array[1] = Conversions.ToSingle(msfExpParms[(int)num2, 4]);
					array2[1] = Conversions.ToSingle(msfExpParms[(int)num2, 8]);
				}
				else if (Operators.CompareString(text, Conversions.ToString(48), false) == 0)
				{
					array[2] = Conversions.ToSingle(msfExpParms[(int)num2, 4]);
					array2[2] = Conversions.ToSingle(msfExpParms[(int)num2, 8]);
				}
			}
			checked
			{
				num2 = (short)unchecked(num2 + 1);
			}
		}
		if (array[0] > array[1])
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"{OUTPUT1} EY must be less than or equal to AT.  Please correct your parameters.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
		}
		else if (array2[0] > array2[1])
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"{OUTPUT2} EY must be less than or equal to AT.  Please correct your parameters.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
		}
		else if (array[1] > array[2])
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"{OUTPUT1} AT must be less than or equal to ATc.  Please correct your parameters.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
		}
		else
		{
			if (!(array2[1] > array2[2]))
			{
				return true;
			}
			Interaction.Beep();
			Interaction.MsgBox((object)"{OUTPUT2} AT must be less than or equal to ATc.  Please correct your parameters.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
		}
		bool result = default(bool);
		return result;
	}

	private bool Validate_BW()
	{
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		float[] array = new float[3];
		float[] array2 = new float[3];
		short num = checked((short)(msfExpParms.Rows - 1));
		short num2 = 1;
		while (true)
		{
			short num3 = num2;
			short num4 = num;
			if (num3 > num4)
			{
				break;
			}
			if (Versioned.IsNumeric((object)msfExpParms[(int)num2, 0]))
			{
				string text = msfExpParms[(int)num2, 0];
				if (Operators.CompareString(text, Conversions.ToString(42), false) == 0)
				{
					array[0] = Conversions.ToSingle(msfExpParms[(int)num2, 4]);
					array2[0] = Conversions.ToSingle(msfExpParms[(int)num2, 8]);
				}
				else if (Operators.CompareString(text, Conversions.ToString(48), false) == 0)
				{
					array[1] = Conversions.ToSingle(msfExpParms[(int)num2, 4]);
					array2[1] = Conversions.ToSingle(msfExpParms[(int)num2, 8]);
				}
			}
			checked
			{
				num2 = (short)unchecked(num2 + 1);
			}
		}
		if (array[0] > array[1])
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"{OUTPUT1} BW must be less than or equal to ATc.  Please correct your parameters.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
		}
		else
		{
			if (!(array2[0] > array2[1]))
			{
				return true;
			}
			Interaction.Beep();
			Interaction.MsgBox((object)"{OUTPUT2} BW must be less than or equal to ATc.  Please correct your parameters.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
		}
		bool result = default(bool);
		return result;
	}

	private void DefaultYpelWhenYsChanges(ref object pNewYs)
	{
		if (!((MyModelType == 45) & (Conversions.ToDouble(msfExpParms[msfExpParms.Row, 0]) == 78.0) & Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(pNewYs))))
		{
			return;
		}
		checked
		{
			short num = (short)(msfExpParms.Rows - 1);
			short num2 = 1;
			while (true)
			{
				short num3 = num2;
				short num4 = num;
				if (num3 <= num4)
				{
					if (unchecked(Conversions.ToDouble(msfExpParms[(int)num2, 0]) == 96.0 && Operators.CompareString(msfExpParms[(int)num2, msfExpParms.Col], "Default", false) == 0))
					{
						msfExpParms[unchecked((int)num2), msfExpParms.Col + 2] = Conversions.ToString(Operators.SubtractObject((object)1, pNewYs));
					}
					num2 = (short)unchecked(num2 + 1);
					continue;
				}
				break;
			}
		}
	}

	private void DefaultYpelWhenYpelDefaultReselected()
	{
		if ((MyModelType == 45) & (Conversions.ToDouble(msfExpParms[msfExpParms.Row, 0]) == 96.0))
		{
			msfExpParms[msfExpParms.Row, checked(msfExpParms.Col + 2)] = Conversions.ToString(1.0 - Conversions.ToDouble(msfExpParms[(int)iYsRow, checked(msfExpParms.Col + 2)]));
		}
	}

	private void CheckCm()
	{
		if (MyModelType != 46 || !((Conversions.ToDouble(msfExpParms[msfExpParms.Row, 0]) == 5.0) | (Conversions.ToDouble(msfExpParms[msfExpParms.Row, 0]) == 63.0) | (Conversions.ToDouble(msfExpParms[msfExpParms.Row, 0]) == 78.0)))
		{
			return;
		}
		short num = 0;
		checked
		{
			string text2 = default(string);
			string text3 = default(string);
			string text4 = default(string);
			string text5 = default(string);
			short num7 = default(short);
			short num9;
			short num6;
			do
			{
				if (!Versioned.IsNumeric((object)lblCmCvOption[num].Text))
				{
					lblCmCvOption[num].Text = Conversions.ToString(Globals_Renamed.arExpModParmsV[num, 54, Globals_Renamed.intModIndex]);
				}
				if (Operators.CompareString(lblCmCvOption[num].Text, "0", false) == 0)
				{
					short num2 = Conversions.ToShort(Interaction.IIf(num == 0, (object)(short)4, (object)(short)8));
					short num3 = (short)(msfExpParms.Rows - 1);
					short num4 = 0;
					while (true)
					{
						short num5 = num4;
						num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						unchecked
						{
							string text = msfExpParms[(int)num4, 0];
							if (Operators.CompareString(text, Conversions.ToString(5), false) == 0)
							{
								text2 = msfExpParms[(int)num4, (int)num2];
							}
							else if (Operators.CompareString(text, Conversions.ToString(63), false) == 0)
							{
								text3 = msfExpParms[(int)num4, (int)num2];
							}
							else if (Operators.CompareString(text, Conversions.ToString(78), false) == 0)
							{
								text4 = msfExpParms[(int)num4, (int)num2];
							}
							else if (Operators.CompareString(text, Conversions.ToString(67), false) == 0)
							{
								text5 = msfExpParms[(int)num4, (int)num2];
							}
							else if (Operators.CompareString(text, Conversions.ToString(64), false) == 0)
							{
								num7 = num4;
							}
						}
						num4 = (short)unchecked(num4 + 1);
					}
					AxMSFlexGrid obj = msfExpParms;
					short num8 = num7;
					object pCv = text5;
					object pMW = text2;
					object pVm = text3;
					object pYs = text4;
					string text6 = ChemStrX.CalcCm(ref pCv, ref pMW, ref pVm, ref pYs);
					text4 = Conversions.ToString(pYs);
					text3 = Conversions.ToString(pVm);
					text2 = Conversions.ToString(pMW);
					text5 = Conversions.ToString(pCv);
					unchecked(obj[(int)num8, (int)num2]) = text6;
				}
				num = (short)unchecked(num + 1);
				num9 = num;
				num6 = 1;
			}
			while (num9 <= num6);
		}
	}

	private void MyRecalcCm()
	{
		short num = checked((short)(msfExpParms.Rows - 1));
		short num2 = 1;
		short num9 = default(short);
		float num8 = default(float);
		float num7 = default(float);
		float num6 = default(float);
		float num5 = default(float);
		while (true)
		{
			short num3 = num2;
			short num4 = num;
			if (num3 > num4)
			{
				break;
			}
			string text = msfExpParms[(int)num2, 0];
			if (Operators.CompareString(text, Conversions.ToString(67), false) == 0)
			{
				num5 = Conversions.ToSingle(msfExpParms[(int)num2, msfExpParms.Col]);
			}
			else if (Operators.CompareString(text, Conversions.ToString(5), false) == 0)
			{
				num6 = Conversions.ToSingle(msfExpParms[(int)num2, msfExpParms.Col]);
			}
			else if (Operators.CompareString(text, Conversions.ToString(63), false) == 0)
			{
				num7 = Conversions.ToSingle(msfExpParms[(int)num2, msfExpParms.Col]);
			}
			else if (Operators.CompareString(text, Conversions.ToString(78), false) == 0)
			{
				num8 = Conversions.ToSingle(msfExpParms[(int)num2, msfExpParms.Col]);
			}
			else if (Operators.CompareString(text, Conversions.ToString(64), false) == 0)
			{
				num9 = num2;
			}
			checked
			{
				num2 = (short)unchecked(num2 + 1);
			}
		}
		AxMSFlexGrid obj = msfExpParms;
		short num10 = num9;
		int col = msfExpParms.Col;
		object pCv = num5;
		object pMW = num6;
		object pVm = num7;
		object pYs = num8;
		string text2 = ChemStrX.CalcCm(ref pCv, ref pMW, ref pVm, ref pYs);
		num8 = Conversions.ToSingle(pYs);
		num7 = Conversions.ToSingle(pVm);
		num6 = Conversions.ToSingle(pMW);
		num5 = Conversions.ToSingle(pCv);
		obj[(int)num10, col] = text2;
	}

	private float MyRecalcYsNonMetaDefault()
	{
		checked
		{
			short num = (short)(msfExpParms.Rows - 1);
			short num2 = 1;
			float pYmist = default(float);
			float pYsf = default(float);
			while (true)
			{
				short num3 = num2;
				short num4 = num;
				if (num3 > num4)
				{
					break;
				}
				string text = msfExpParms[unchecked((int)num2), 0];
				if (Operators.CompareString(text, Conversions.ToString(59), false) == 0)
				{
					pYmist = Conversions.ToSingle(msfExpParms[unchecked((int)num2), iColIndex + 2]);
				}
				else if (Operators.CompareString(text, Conversions.ToString(68), false) == 0)
				{
					pYsf = Conversions.ToSingle(msfExpParms[unchecked((int)num2), iColIndex + 2]);
				}
				num2 = (short)unchecked(num2 + 1);
			}
			return GetParmDefaults.GetParmDefault3122Guts(ref pYsf, ref pYmist);
		}
	}

	private float MyRecalcYpel()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num2 = default(int);
		float num4 = default(float);
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
						short num3 = (short)(Globals_Renamed.arExpModels[myType, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1);
						if (num3 == -1)
						{
							Interaction.Beep();
							Interaction.MsgBox((object)"Error in MyRecalcYpel in frmMDUpdExpMod. Please save your assessment as a new assessment and contact Technical Support.", (MsgBoxStyle)64, (object)"Fatal ChemSTEER Error");
						}
						else
						{
							num4 = (float)(1.0 - Conversions.ToDouble(msfExpParms[msfExpParms.Row, iColIndex + 2]));
						}
						goto end_IL_0001;
					}
					case 232:
						num = -1;
						switch (num2)
						{
						case 2:
						{
							string Eobject = ((Control)this).Name;
							string Efunction = "MyRecalcYpel";
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
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 232;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		float result = num4;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private void msfExpParms_Enter(object sender, EventArgs e)
	{
	}
}
