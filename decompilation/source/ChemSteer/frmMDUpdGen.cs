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

internal class frmMDUpdGen : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("txtConsCase")]
	private TextBox _txtConsCase;

	[AccessedThroughProperty("chkConsCase")]
	private CheckBox _chkConsCase;

	[AccessedThroughProperty("txtFiscalYear")]
	private TextBox _txtFiscalYear;

	[AccessedThroughProperty("txtContInfo")]
	private TextBox _txtContInfo;

	[AccessedThroughProperty("txtStatusOther")]
	private TextBox _txtStatusOther;

	[AccessedThroughProperty("txtAssessOther")]
	private TextBox _txtAssessOther;

	[AccessedThroughProperty("_txtAddr_1")]
	private TextBox __txtAddr_1;

	[AccessedThroughProperty("_txtEmail_1")]
	private TextBox __txtEmail_1;

	[AccessedThroughProperty("_txtPhone_1")]
	private TextBox __txtPhone_1;

	[AccessedThroughProperty("_txtAffil_1")]
	private TextBox __txtAffil_1;

	[AccessedThroughProperty("_txtName_1")]
	private TextBox __txtName_1;

	[AccessedThroughProperty("txtID")]
	private TextBox _txtID;

	[AccessedThroughProperty("txtCoName")]
	private TextBox _txtCoName;

	[AccessedThroughProperty("chkCBI")]
	private CheckBox _chkCBI;

	[AccessedThroughProperty("_txtAddr_0")]
	private TextBox __txtAddr_0;

	[AccessedThroughProperty("txtCity")]
	private TextBox _txtCity;

	[AccessedThroughProperty("cmbState")]
	private ComboBox _cmbState;

	[AccessedThroughProperty("txtZip")]
	private TextBox _txtZip;

	[AccessedThroughProperty("cmbAssessType")]
	private ComboBox _cmbAssessType;

	[AccessedThroughProperty("_txtName_0")]
	private TextBox __txtName_0;

	[AccessedThroughProperty("cmbStatus")]
	private ComboBox _cmbStatus;

	[AccessedThroughProperty("_txtAffil_0")]
	private TextBox __txtAffil_0;

	[AccessedThroughProperty("_txtPhone_0")]
	private TextBox __txtPhone_0;

	[AccessedThroughProperty("_txtEmail_0")]
	private TextBox __txtEmail_0;

	[AccessedThroughProperty("txtDate")]
	private TextBox _txtDate;

	[AccessedThroughProperty("cmdOk")]
	private Button _cmdOk;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("_Label1_2")]
	private Label __Label1_2;

	[AccessedThroughProperty("lblInstructions")]
	private Label _lblInstructions;

	[AccessedThroughProperty("_Line1_1")]
	private Label __Line1_1;

	[AccessedThroughProperty("_Label1_0")]
	private Label __Label1_0;

	[AccessedThroughProperty("_Label1_1")]
	private Label __Label1_1;

	[AccessedThroughProperty("_Label1_6")]
	private Label __Label1_6;

	[AccessedThroughProperty("_Label1_8")]
	private Label __Label1_8;

	[AccessedThroughProperty("_Label1_13")]
	private Label __Label1_13;

	[AccessedThroughProperty("_Label1_29")]
	private Label __Label1_29;

	[AccessedThroughProperty("_Label1_30")]
	private Label __Label1_30;

	[AccessedThroughProperty("_Label1_4")]
	private Label __Label1_4;

	[AccessedThroughProperty("_Label1_5")]
	private Label __Label1_5;

	[AccessedThroughProperty("_Label1_9")]
	private Label __Label1_9;

	[AccessedThroughProperty("_Line1_0")]
	private Label __Line1_0;

	[AccessedThroughProperty("_Label1_7")]
	private Label __Label1_7;

	[AccessedThroughProperty("_Label1_25")]
	private Label __Label1_25;

	[AccessedThroughProperty("_Label1_32")]
	private Label __Label1_32;

	[AccessedThroughProperty("_Label1_10")]
	private Label __Label1_10;

	[AccessedThroughProperty("_Line1_2")]
	private Label __Line1_2;

	[AccessedThroughProperty("_Label1_11")]
	private Label __Label1_11;

	[AccessedThroughProperty("Label1")]
	private LabelArray _Label1;

	[AccessedThroughProperty("Line1")]
	private LabelArray _Line1;

	[AccessedThroughProperty("txtAddr")]
	private TextBoxArray _txtAddr;

	[AccessedThroughProperty("txtAffil")]
	private TextBoxArray _txtAffil;

	[AccessedThroughProperty("txtEmail")]
	private TextBoxArray _txtEmail;

	[AccessedThroughProperty("txtName")]
	private TextBoxArray _txtName;

	[AccessedThroughProperty("txtPhone")]
	private TextBoxArray _txtPhone;

	private static frmMDUpdGen m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	private short[] arAssIDMustBe4Digits;

	public virtual TextBox txtConsCase
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtConsCase;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtConsCase = value;
		}
	}

	public virtual CheckBox chkConsCase
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkConsCase;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = chkConsCase_CheckStateChanged;
			if (_chkConsCase != null)
			{
				_chkConsCase.CheckStateChanged -= eventHandler;
			}
			_chkConsCase = value;
			if (_chkConsCase != null)
			{
				_chkConsCase.CheckStateChanged += eventHandler;
			}
		}
	}

	public virtual TextBox txtFiscalYear
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtFiscalYear;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtFiscalYear_Leave;
			if (_txtFiscalYear != null)
			{
				((Control)_txtFiscalYear).Leave -= eventHandler;
			}
			_txtFiscalYear = value;
			if (_txtFiscalYear != null)
			{
				((Control)_txtFiscalYear).Leave += eventHandler;
			}
		}
	}

	public virtual TextBox txtContInfo
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtContInfo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtContInfo = value;
		}
	}

	public virtual TextBox txtStatusOther
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtStatusOther;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtStatusOther = value;
		}
	}

	public virtual TextBox txtAssessOther
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtAssessOther;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtAssessOther = value;
		}
	}

	public virtual TextBox _txtAddr_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtAddr_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtAddr_1 = value;
		}
	}

	public virtual TextBox _txtEmail_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtEmail_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtEmail_1 = value;
		}
	}

	public virtual TextBox _txtPhone_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtPhone_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtPhone_1 = value;
		}
	}

	public virtual TextBox _txtAffil_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtAffil_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtAffil_1 = value;
		}
	}

	public virtual TextBox _txtName_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtName_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtName_1 = value;
		}
	}

	public virtual TextBox txtID
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtID;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtID = value;
		}
	}

	public virtual TextBox txtCoName
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtCoName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtCoName = value;
		}
	}

	public virtual CheckBox chkCBI
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkCBI;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkCBI = value;
		}
	}

	public virtual TextBox _txtAddr_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtAddr_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtAddr_0 = value;
		}
	}

	public virtual TextBox txtCity
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtCity;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtCity = value;
		}
	}

	public virtual ComboBox cmbState
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbState;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cmbState = value;
		}
	}

	public virtual TextBox txtZip
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtZip;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtZip = value;
		}
	}

	public virtual ComboBox cmbAssessType
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbAssessType;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmbAssessType_SelectedIndexChanged;
			if (_cmbAssessType != null)
			{
				_cmbAssessType.SelectedIndexChanged -= eventHandler;
			}
			_cmbAssessType = value;
			if (_cmbAssessType != null)
			{
				_cmbAssessType.SelectedIndexChanged += eventHandler;
			}
		}
	}

	public virtual TextBox _txtName_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtName_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtName_0 = value;
		}
	}

	public virtual ComboBox cmbStatus
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbStatus;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmbStatus_SelectedIndexChanged;
			if (_cmbStatus != null)
			{
				_cmbStatus.SelectedIndexChanged -= eventHandler;
			}
			_cmbStatus = value;
			if (_cmbStatus != null)
			{
				_cmbStatus.SelectedIndexChanged += eventHandler;
			}
		}
	}

	public virtual TextBox _txtAffil_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtAffil_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtAffil_0 = value;
		}
	}

	public virtual TextBox _txtPhone_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtPhone_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtPhone_0 = value;
		}
	}

	public virtual TextBox _txtEmail_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtEmail_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtEmail_0 = value;
		}
	}

	public virtual TextBox txtDate
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtDate_Leave;
			if (_txtDate != null)
			{
				((Control)_txtDate).Leave -= eventHandler;
			}
			_txtDate = value;
			if (_txtDate != null)
			{
				((Control)_txtDate).Leave += eventHandler;
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

	public virtual Label _Line1_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __Line1_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Line1_1 = value;
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

	public virtual Label _Label1_8
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_8 = value;
		}
	}

	public virtual Label _Label1_13
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_13 = value;
		}
	}

	public virtual Label _Label1_29
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_29;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_29 = value;
		}
	}

	public virtual Label _Label1_30
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_30;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_30 = value;
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

	public virtual Label _Label1_9
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_9 = value;
		}
	}

	public virtual Label _Line1_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __Line1_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Line1_0 = value;
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

	public virtual Label _Label1_25
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_25;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_25 = value;
		}
	}

	public virtual Label _Label1_32
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_32;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_32 = value;
		}
	}

	public virtual Label _Label1_10
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_10 = value;
		}
	}

	public virtual Label _Line1_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __Line1_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Line1_2 = value;
		}
	}

	public virtual Label _Label1_11
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_11 = value;
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

	public virtual LabelArray Line1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Line1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Line1 = value;
		}
	}

	public virtual TextBoxArray txtAddr
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtAddr;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtAddr = value;
		}
	}

	public virtual TextBoxArray txtAffil
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtAffil;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtAffil = value;
		}
	}

	public virtual TextBoxArray txtEmail
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtEmail;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtEmail = value;
		}
	}

	public virtual TextBoxArray txtName
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtName = value;
		}
	}

	public virtual TextBoxArray txtPhone
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtPhone;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtPhone = value;
		}
	}

	public static frmMDUpdGen DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmMDUpdGen();
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

	public frmMDUpdGen()
	{
		((Form)this).Load += frmMDUpdGen_Load;
		__ENCAddToList(this);
		arAssIDMustBe4Digits = new short[100];
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
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected O, but got Unknown
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected O, but got Unknown
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected O, but got Unknown
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected O, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected O, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected O, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected O, but got Unknown
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected O, but got Unknown
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected O, but got Unknown
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected O, but got Unknown
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected O, but got Unknown
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected O, but got Unknown
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected O, but got Unknown
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected O, but got Unknown
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected O, but got Unknown
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected O, but got Unknown
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected O, but got Unknown
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected O, but got Unknown
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Expected O, but got Unknown
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Expected O, but got Unknown
		//IL_0465: Unknown result type (might be due to invalid IL or missing references)
		//IL_046f: Expected O, but got Unknown
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_054f: Expected O, but got Unknown
		//IL_060e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0618: Expected O, but got Unknown
		//IL_06fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0705: Expected O, but got Unknown
		//IL_07d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e2: Expected O, but got Unknown
		//IL_08b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bf: Expected O, but got Unknown
		//IL_0999: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a3: Expected O, but got Unknown
		//IL_0a9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa4: Expected O, but got Unknown
		//IL_0b98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba2: Expected O, but got Unknown
		//IL_0c99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca3: Expected O, but got Unknown
		//IL_0d9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da4: Expected O, but got Unknown
		//IL_0e6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e74: Expected O, but got Unknown
		//IL_0f57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f61: Expected O, but got Unknown
		//IL_1038: Unknown result type (might be due to invalid IL or missing references)
		//IL_1042: Expected O, but got Unknown
		//IL_111c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1126: Expected O, but got Unknown
		//IL_11ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f7: Expected O, but got Unknown
		//IL_12ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b7: Expected O, but got Unknown
		//IL_137e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1388: Expected O, but got Unknown
		//IL_143d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1447: Expected O, but got Unknown
		//IL_153b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1545: Expected O, but got Unknown
		//IL_15fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1604: Expected O, but got Unknown
		//IL_16f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1702: Expected O, but got Unknown
		//IL_17f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_17fd: Expected O, but got Unknown
		//IL_18f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_18fb: Expected O, but got Unknown
		//IL_19b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_19be: Expected O, but got Unknown
		//IL_1a95: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a9f: Expected O, but got Unknown
		//IL_1b69: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b73: Expected O, but got Unknown
		//IL_1c4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c54: Expected O, but got Unknown
		//IL_1d86: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d90: Expected O, but got Unknown
		//IL_1e69: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e73: Expected O, but got Unknown
		//IL_1f4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f56: Expected O, but got Unknown
		//IL_202f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2039: Expected O, but got Unknown
		//IL_2113: Unknown result type (might be due to invalid IL or missing references)
		//IL_211d: Expected O, but got Unknown
		//IL_21f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_21ff: Expected O, but got Unknown
		//IL_22da: Unknown result type (might be due to invalid IL or missing references)
		//IL_22e4: Expected O, but got Unknown
		//IL_23c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_23cc: Expected O, but got Unknown
		//IL_24a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_24ad: Expected O, but got Unknown
		//IL_2586: Unknown result type (might be due to invalid IL or missing references)
		//IL_2590: Expected O, but got Unknown
		//IL_26e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_26ef: Expected O, but got Unknown
		//IL_27bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_27c9: Expected O, but got Unknown
		//IL_2896: Unknown result type (might be due to invalid IL or missing references)
		//IL_28a0: Expected O, but got Unknown
		//IL_297a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2984: Expected O, but got Unknown
		//IL_2ada: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ae4: Expected O, but got Unknown
		//IL_2f33: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f3d: Expected O, but got Unknown
		//IL_2f52: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f5c: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMDUpdGen));
		ToolTip1 = new ToolTip(components);
		txtConsCase = new TextBox();
		chkConsCase = new CheckBox();
		txtFiscalYear = new TextBox();
		txtContInfo = new TextBox();
		txtStatusOther = new TextBox();
		txtAssessOther = new TextBox();
		_txtAddr_1 = new TextBox();
		_txtEmail_1 = new TextBox();
		_txtPhone_1 = new TextBox();
		_txtAffil_1 = new TextBox();
		_txtName_1 = new TextBox();
		txtID = new TextBox();
		txtCoName = new TextBox();
		chkCBI = new CheckBox();
		_txtAddr_0 = new TextBox();
		txtCity = new TextBox();
		cmbState = new ComboBox();
		txtZip = new TextBox();
		cmbAssessType = new ComboBox();
		_txtName_0 = new TextBox();
		cmbStatus = new ComboBox();
		_txtAffil_0 = new TextBox();
		_txtPhone_0 = new TextBox();
		_txtEmail_0 = new TextBox();
		txtDate = new TextBox();
		cmdOk = new Button();
		cmdCancel = new Button();
		_Label1_2 = new Label();
		lblInstructions = new Label();
		_Line1_1 = new Label();
		_Label1_0 = new Label();
		_Label1_1 = new Label();
		_Label1_6 = new Label();
		_Label1_8 = new Label();
		_Label1_13 = new Label();
		_Label1_29 = new Label();
		_Label1_30 = new Label();
		_Label1_4 = new Label();
		_Label1_5 = new Label();
		_Label1_9 = new Label();
		_Line1_0 = new Label();
		_Label1_7 = new Label();
		_Label1_25 = new Label();
		_Label1_32 = new Label();
		_Label1_10 = new Label();
		_Line1_2 = new Label();
		_Label1_11 = new Label();
		Label1 = new LabelArray(components);
		Line1 = new LabelArray(components);
		txtAddr = new TextBoxArray(components);
		txtAffil = new TextBoxArray(components);
		txtEmail = new TextBoxArray(components);
		txtName = new TextBoxArray(components);
		txtPhone = new TextBoxArray(components);
		((ISupportInitialize)Label1).BeginInit();
		((ISupportInitialize)Line1).BeginInit();
		((ISupportInitialize)txtAddr).BeginInit();
		((ISupportInitialize)txtAffil).BeginInit();
		((ISupportInitialize)txtEmail).BeginInit();
		((ISupportInitialize)txtName).BeginInit();
		((ISupportInitialize)txtPhone).BeginInit();
		((Control)this).SuspendLayout();
		txtConsCase.AcceptsReturn = true;
		((TextBoxBase)txtConsCase).BackColor = SystemColors.Control;
		((Control)txtConsCase).Cursor = Cursors.IBeam;
		((Control)txtConsCase).Enabled = false;
		((Control)txtConsCase).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtConsCase).ForeColor = SystemColors.WindowText;
		TextBox obj = txtConsCase;
		Point location = new Point(472, 72);
		((Control)obj).Location = location;
		((TextBoxBase)txtConsCase).MaxLength = 0;
		txtConsCase.Multiline = true;
		((Control)txtConsCase).Name = "txtConsCase";
		((Control)txtConsCase).RightToLeft = (RightToLeft)0;
		txtConsCase.ScrollBars = (ScrollBars)2;
		TextBox obj2 = txtConsCase;
		Size size = new Size(193, 65);
		((Control)obj2).Size = size;
		((Control)txtConsCase).TabIndex = 7;
		((ButtonBase)chkConsCase).BackColor = SystemColors.Control;
		((Control)chkConsCase).Cursor = Cursors.Default;
		((Control)chkConsCase).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)chkConsCase).ForeColor = SystemColors.ControlText;
		CheckBox obj3 = chkConsCase;
		location = new Point(472, 56);
		((Control)obj3).Location = location;
		((Control)chkConsCase).Name = "chkConsCase";
		((Control)chkConsCase).RightToLeft = (RightToLeft)0;
		CheckBox obj4 = chkConsCase;
		size = new Size(129, 17);
		((Control)obj4).Size = size;
		((Control)chkConsCase).TabIndex = 6;
		((ButtonBase)chkConsCase).Text = "Consolidated Case";
		((ButtonBase)chkConsCase).UseVisualStyleBackColor = false;
		txtFiscalYear.AcceptsReturn = true;
		((TextBoxBase)txtFiscalYear).BackColor = Color.White;
		((Control)txtFiscalYear).Cursor = Cursors.IBeam;
		((Control)txtFiscalYear).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtFiscalYear).ForeColor = SystemColors.WindowText;
		TextBox obj5 = txtFiscalYear;
		location = new Point(120, 120);
		((Control)obj5).Location = location;
		((TextBoxBase)txtFiscalYear).MaxLength = 2;
		((Control)txtFiscalYear).Name = "txtFiscalYear";
		((Control)txtFiscalYear).RightToLeft = (RightToLeft)0;
		TextBox obj6 = txtFiscalYear;
		size = new Size(33, 20);
		((Control)obj6).Size = size;
		((Control)txtFiscalYear).TabIndex = 4;
		txtContInfo.AcceptsReturn = true;
		((TextBoxBase)txtContInfo).BackColor = Color.White;
		((Control)txtContInfo).Cursor = Cursors.IBeam;
		((Control)txtContInfo).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtContInfo).ForeColor = SystemColors.WindowText;
		TextBox obj7 = txtContInfo;
		location = new Point(336, 328);
		((Control)obj7).Location = location;
		((TextBoxBase)txtContInfo).MaxLength = 0;
		txtContInfo.Multiline = true;
		((Control)txtContInfo).Name = "txtContInfo";
		((Control)txtContInfo).RightToLeft = (RightToLeft)0;
		txtContInfo.ScrollBars = (ScrollBars)2;
		TextBox obj8 = txtContInfo;
		size = new Size(313, 97);
		((Control)obj8).Size = size;
		((Control)txtContInfo).TabIndex = 24;
		txtStatusOther.AcceptsReturn = true;
		((TextBoxBase)txtStatusOther).BackColor = Color.White;
		((Control)txtStatusOther).Cursor = Cursors.IBeam;
		((Control)txtStatusOther).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtStatusOther).ForeColor = SystemColors.WindowText;
		TextBox obj9 = txtStatusOther;
		location = new Point(304, 88);
		((Control)obj9).Location = location;
		((TextBoxBase)txtStatusOther).MaxLength = 30;
		((Control)txtStatusOther).Name = "txtStatusOther";
		((Control)txtStatusOther).RightToLeft = (RightToLeft)0;
		TextBox obj10 = txtStatusOther;
		size = new Size(153, 20);
		((Control)obj10).Size = size;
		((Control)txtStatusOther).TabIndex = 3;
		((Control)txtStatusOther).Visible = false;
		txtAssessOther.AcceptsReturn = true;
		((TextBoxBase)txtAssessOther).BackColor = Color.White;
		((Control)txtAssessOther).Cursor = Cursors.IBeam;
		((Control)txtAssessOther).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtAssessOther).ForeColor = SystemColors.WindowText;
		TextBox obj11 = txtAssessOther;
		location = new Point(304, 56);
		((Control)obj11).Location = location;
		((TextBoxBase)txtAssessOther).MaxLength = 30;
		((Control)txtAssessOther).Name = "txtAssessOther";
		((Control)txtAssessOther).RightToLeft = (RightToLeft)0;
		TextBox obj12 = txtAssessOther;
		size = new Size(153, 20);
		((Control)obj12).Size = size;
		((Control)txtAssessOther).TabIndex = 1;
		((Control)txtAssessOther).Visible = false;
		_txtAddr_1.AcceptsReturn = true;
		((TextBoxBase)_txtAddr_1).BackColor = Color.White;
		((Control)_txtAddr_1).Cursor = Cursors.IBeam;
		((Control)_txtAddr_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtAddr_1).ForeColor = SystemColors.WindowText;
		txtAddr.SetIndex(_txtAddr_1, (short)1);
		TextBox txtAddr_ = _txtAddr_1;
		location = new Point(104, 360);
		((Control)txtAddr_).Location = location;
		((TextBoxBase)_txtAddr_1).MaxLength = 50;
		((Control)_txtAddr_1).Name = "_txtAddr_1";
		((Control)_txtAddr_1).RightToLeft = (RightToLeft)0;
		TextBox txtAddr_2 = _txtAddr_1;
		size = new Size(217, 20);
		((Control)txtAddr_2).Size = size;
		((Control)_txtAddr_1).TabIndex = 20;
		_txtEmail_1.AcceptsReturn = true;
		((TextBoxBase)_txtEmail_1).BackColor = Color.White;
		((Control)_txtEmail_1).Cursor = Cursors.IBeam;
		((Control)_txtEmail_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtEmail_1).ForeColor = SystemColors.WindowText;
		txtEmail.SetIndex(_txtEmail_1, (short)1);
		TextBox txtEmail_ = _txtEmail_1;
		location = new Point(344, 272);
		((Control)txtEmail_).Location = location;
		((TextBoxBase)_txtEmail_1).MaxLength = 50;
		((Control)_txtEmail_1).Name = "_txtEmail_1";
		((Control)_txtEmail_1).RightToLeft = (RightToLeft)0;
		_txtEmail_1.ScrollBars = (ScrollBars)1;
		TextBox txtEmail_2 = _txtEmail_1;
		size = new Size(257, 20);
		((Control)txtEmail_2).Size = size;
		((Control)_txtEmail_1).TabIndex = 17;
		((TextBoxBase)_txtEmail_1).WordWrap = false;
		_txtPhone_1.AcceptsReturn = true;
		((TextBoxBase)_txtPhone_1).BackColor = Color.White;
		((Control)_txtPhone_1).Cursor = Cursors.IBeam;
		((Control)_txtPhone_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtPhone_1).ForeColor = SystemColors.WindowText;
		txtPhone.SetIndex(_txtPhone_1, (short)1);
		TextBox txtPhone_ = _txtPhone_1;
		location = new Point(344, 248);
		((Control)txtPhone_).Location = location;
		((TextBoxBase)_txtPhone_1).MaxLength = 20;
		((Control)_txtPhone_1).Name = "_txtPhone_1";
		((Control)_txtPhone_1).RightToLeft = (RightToLeft)0;
		_txtPhone_1.ScrollBars = (ScrollBars)1;
		TextBox txtPhone_2 = _txtPhone_1;
		size = new Size(121, 20);
		((Control)txtPhone_2).Size = size;
		((Control)_txtPhone_1).TabIndex = 16;
		((TextBoxBase)_txtPhone_1).WordWrap = false;
		_txtAffil_1.AcceptsReturn = true;
		((TextBoxBase)_txtAffil_1).BackColor = Color.White;
		((Control)_txtAffil_1).Cursor = Cursors.IBeam;
		((Control)_txtAffil_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtAffil_1).ForeColor = SystemColors.WindowText;
		txtAffil.SetIndex(_txtAffil_1, (short)1);
		TextBox txtAffil_ = _txtAffil_1;
		location = new Point(344, 224);
		((Control)txtAffil_).Location = location;
		((TextBoxBase)_txtAffil_1).MaxLength = 50;
		((Control)_txtAffil_1).Name = "_txtAffil_1";
		((Control)_txtAffil_1).RightToLeft = (RightToLeft)0;
		_txtAffil_1.ScrollBars = (ScrollBars)1;
		TextBox txtAffil_2 = _txtAffil_1;
		size = new Size(257, 20);
		((Control)txtAffil_2).Size = size;
		((Control)_txtAffil_1).TabIndex = 15;
		((TextBoxBase)_txtAffil_1).WordWrap = false;
		_txtName_1.AcceptsReturn = true;
		((TextBoxBase)_txtName_1).BackColor = Color.White;
		((Control)_txtName_1).Cursor = Cursors.IBeam;
		((Control)_txtName_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtName_1).ForeColor = SystemColors.WindowText;
		txtName.SetIndex(_txtName_1, (short)1);
		TextBox txtName_ = _txtName_1;
		location = new Point(344, 200);
		((Control)txtName_).Location = location;
		((TextBoxBase)_txtName_1).MaxLength = 50;
		((Control)_txtName_1).Name = "_txtName_1";
		((Control)_txtName_1).RightToLeft = (RightToLeft)0;
		_txtName_1.ScrollBars = (ScrollBars)1;
		TextBox txtName_2 = _txtName_1;
		size = new Size(257, 20);
		((Control)txtName_2).Size = size;
		((Control)_txtName_1).TabIndex = 14;
		((TextBoxBase)_txtName_1).WordWrap = false;
		txtID.AcceptsReturn = true;
		((TextBoxBase)txtID).BackColor = Color.White;
		((Control)txtID).Cursor = Cursors.IBeam;
		((Control)txtID).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtID).ForeColor = SystemColors.WindowText;
		TextBox obj13 = txtID;
		location = new Point(120, 152);
		((Control)obj13).Location = location;
		((TextBoxBase)txtID).MaxLength = 40;
		((Control)txtID).Name = "txtID";
		((Control)txtID).RightToLeft = (RightToLeft)0;
		TextBox obj14 = txtID;
		size = new Size(289, 20);
		((Control)obj14).Size = size;
		((Control)txtID).TabIndex = 5;
		txtCoName.AcceptsReturn = true;
		((TextBoxBase)txtCoName).BackColor = Color.White;
		((Control)txtCoName).Cursor = Cursors.IBeam;
		((Control)txtCoName).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtCoName).ForeColor = SystemColors.WindowText;
		TextBox obj15 = txtCoName;
		location = new Point(104, 312);
		((Control)obj15).Location = location;
		((TextBoxBase)txtCoName).MaxLength = 50;
		((Control)txtCoName).Name = "txtCoName";
		((Control)txtCoName).RightToLeft = (RightToLeft)0;
		txtCoName.ScrollBars = (ScrollBars)1;
		TextBox obj16 = txtCoName;
		size = new Size(217, 20);
		((Control)obj16).Size = size;
		((Control)txtCoName).TabIndex = 18;
		((TextBoxBase)txtCoName).WordWrap = false;
		((ButtonBase)chkCBI).BackColor = Color.FromArgb(255, 128, 128);
		((Control)chkCBI).Cursor = Cursors.Default;
		((Control)chkCBI).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)chkCBI).ForeColor = SystemColors.ControlText;
		CheckBox obj17 = chkCBI;
		location = new Point(592, 152);
		((Control)obj17).Location = location;
		((Control)chkCBI).Name = "chkCBI";
		((Control)chkCBI).RightToLeft = (RightToLeft)0;
		CheckBox obj18 = chkCBI;
		size = new Size(57, 17);
		((Control)obj18).Size = size;
		((Control)chkCBI).TabIndex = 9;
		((ButtonBase)chkCBI).Text = "CBI";
		((ButtonBase)chkCBI).UseVisualStyleBackColor = false;
		_txtAddr_0.AcceptsReturn = true;
		((TextBoxBase)_txtAddr_0).BackColor = Color.White;
		((Control)_txtAddr_0).Cursor = Cursors.IBeam;
		((Control)_txtAddr_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtAddr_0).ForeColor = SystemColors.WindowText;
		txtAddr.SetIndex(_txtAddr_0, (short)0);
		TextBox txtAddr_3 = _txtAddr_0;
		location = new Point(104, 336);
		((Control)txtAddr_3).Location = location;
		((TextBoxBase)_txtAddr_0).MaxLength = 50;
		((Control)_txtAddr_0).Name = "_txtAddr_0";
		((Control)_txtAddr_0).RightToLeft = (RightToLeft)0;
		TextBox txtAddr_4 = _txtAddr_0;
		size = new Size(217, 20);
		((Control)txtAddr_4).Size = size;
		((Control)_txtAddr_0).TabIndex = 19;
		txtCity.AcceptsReturn = true;
		((TextBoxBase)txtCity).BackColor = Color.White;
		((Control)txtCity).Cursor = Cursors.IBeam;
		((Control)txtCity).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtCity).ForeColor = SystemColors.WindowText;
		TextBox obj19 = txtCity;
		location = new Point(104, 384);
		((Control)obj19).Location = location;
		((TextBoxBase)txtCity).MaxLength = 50;
		((Control)txtCity).Name = "txtCity";
		((Control)txtCity).RightToLeft = (RightToLeft)0;
		TextBox obj20 = txtCity;
		size = new Size(217, 20);
		((Control)obj20).Size = size;
		((Control)txtCity).TabIndex = 21;
		cmbState.BackColor = SystemColors.Window;
		((Control)cmbState).Cursor = Cursors.Default;
		cmbState.DropDownStyle = (ComboBoxStyle)2;
		((Control)cmbState).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		cmbState.ForeColor = SystemColors.WindowText;
		ComboBox obj21 = cmbState;
		location = new Point(104, 408);
		((Control)obj21).Location = location;
		((Control)cmbState).Name = "cmbState";
		((Control)cmbState).RightToLeft = (RightToLeft)0;
		ComboBox obj22 = cmbState;
		size = new Size(49, 22);
		((Control)obj22).Size = size;
		((Control)cmbState).TabIndex = 22;
		txtZip.AcceptsReturn = true;
		((TextBoxBase)txtZip).BackColor = Color.White;
		((Control)txtZip).Cursor = Cursors.IBeam;
		((Control)txtZip).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtZip).ForeColor = SystemColors.WindowText;
		TextBox obj23 = txtZip;
		location = new Point(216, 408);
		((Control)obj23).Location = location;
		((TextBoxBase)txtZip).MaxLength = 10;
		((Control)txtZip).Name = "txtZip";
		((Control)txtZip).RightToLeft = (RightToLeft)0;
		TextBox obj24 = txtZip;
		size = new Size(73, 20);
		((Control)obj24).Size = size;
		((Control)txtZip).TabIndex = 23;
		cmbAssessType.BackColor = SystemColors.Window;
		((Control)cmbAssessType).Cursor = Cursors.Default;
		cmbAssessType.DropDownStyle = (ComboBoxStyle)2;
		((Control)cmbAssessType).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		cmbAssessType.ForeColor = SystemColors.WindowText;
		ComboBox obj25 = cmbAssessType;
		location = new Point(120, 56);
		((Control)obj25).Location = location;
		((Control)cmbAssessType).Name = "cmbAssessType";
		((Control)cmbAssessType).RightToLeft = (RightToLeft)0;
		ComboBox obj26 = cmbAssessType;
		size = new Size(177, 22);
		((Control)obj26).Size = size;
		((Control)cmbAssessType).TabIndex = 0;
		_txtName_0.AcceptsReturn = true;
		((TextBoxBase)_txtName_0).BackColor = Color.White;
		((Control)_txtName_0).Cursor = Cursors.IBeam;
		((Control)_txtName_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtName_0).ForeColor = SystemColors.WindowText;
		txtName.SetIndex(_txtName_0, (short)0);
		TextBox txtName_3 = _txtName_0;
		location = new Point(64, 200);
		((Control)txtName_3).Location = location;
		((TextBoxBase)_txtName_0).MaxLength = 50;
		((Control)_txtName_0).Name = "_txtName_0";
		((Control)_txtName_0).RightToLeft = (RightToLeft)0;
		_txtName_0.ScrollBars = (ScrollBars)1;
		TextBox txtName_4 = _txtName_0;
		size = new Size(265, 20);
		((Control)txtName_4).Size = size;
		((Control)_txtName_0).TabIndex = 10;
		((TextBoxBase)_txtName_0).WordWrap = false;
		cmbStatus.BackColor = SystemColors.Window;
		((Control)cmbStatus).Cursor = Cursors.Default;
		cmbStatus.DropDownStyle = (ComboBoxStyle)2;
		((Control)cmbStatus).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		cmbStatus.ForeColor = SystemColors.WindowText;
		ComboBox obj27 = cmbStatus;
		location = new Point(120, 88);
		((Control)obj27).Location = location;
		((Control)cmbStatus).Name = "cmbStatus";
		((Control)cmbStatus).RightToLeft = (RightToLeft)0;
		ComboBox obj28 = cmbStatus;
		size = new Size(177, 22);
		((Control)obj28).Size = size;
		((Control)cmbStatus).TabIndex = 2;
		_txtAffil_0.AcceptsReturn = true;
		((TextBoxBase)_txtAffil_0).BackColor = Color.White;
		((Control)_txtAffil_0).Cursor = Cursors.IBeam;
		((Control)_txtAffil_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtAffil_0).ForeColor = SystemColors.WindowText;
		txtAffil.SetIndex(_txtAffil_0, (short)0);
		TextBox txtAffil_3 = _txtAffil_0;
		location = new Point(64, 224);
		((Control)txtAffil_3).Location = location;
		((TextBoxBase)_txtAffil_0).MaxLength = 50;
		((Control)_txtAffil_0).Name = "_txtAffil_0";
		((Control)_txtAffil_0).RightToLeft = (RightToLeft)0;
		_txtAffil_0.ScrollBars = (ScrollBars)1;
		TextBox txtAffil_4 = _txtAffil_0;
		size = new Size(265, 20);
		((Control)txtAffil_4).Size = size;
		((Control)_txtAffil_0).TabIndex = 11;
		((TextBoxBase)_txtAffil_0).WordWrap = false;
		_txtPhone_0.AcceptsReturn = true;
		((TextBoxBase)_txtPhone_0).BackColor = Color.White;
		((Control)_txtPhone_0).Cursor = Cursors.IBeam;
		((Control)_txtPhone_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtPhone_0).ForeColor = SystemColors.WindowText;
		txtPhone.SetIndex(_txtPhone_0, (short)0);
		TextBox txtPhone_3 = _txtPhone_0;
		location = new Point(64, 248);
		((Control)txtPhone_3).Location = location;
		((TextBoxBase)_txtPhone_0).MaxLength = 20;
		((Control)_txtPhone_0).Name = "_txtPhone_0";
		((Control)_txtPhone_0).RightToLeft = (RightToLeft)0;
		_txtPhone_0.ScrollBars = (ScrollBars)1;
		TextBox txtPhone_4 = _txtPhone_0;
		size = new Size(121, 20);
		((Control)txtPhone_4).Size = size;
		((Control)_txtPhone_0).TabIndex = 12;
		((TextBoxBase)_txtPhone_0).WordWrap = false;
		_txtEmail_0.AcceptsReturn = true;
		((TextBoxBase)_txtEmail_0).BackColor = Color.White;
		((Control)_txtEmail_0).Cursor = Cursors.IBeam;
		((Control)_txtEmail_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtEmail_0).ForeColor = SystemColors.WindowText;
		txtEmail.SetIndex(_txtEmail_0, (short)0);
		TextBox txtEmail_3 = _txtEmail_0;
		location = new Point(64, 272);
		((Control)txtEmail_3).Location = location;
		((TextBoxBase)_txtEmail_0).MaxLength = 50;
		((Control)_txtEmail_0).Name = "_txtEmail_0";
		((Control)_txtEmail_0).RightToLeft = (RightToLeft)0;
		_txtEmail_0.ScrollBars = (ScrollBars)1;
		TextBox txtEmail_4 = _txtEmail_0;
		size = new Size(265, 20);
		((Control)txtEmail_4).Size = size;
		((Control)_txtEmail_0).TabIndex = 13;
		((TextBoxBase)_txtEmail_0).WordWrap = false;
		txtDate.AcceptsReturn = true;
		((TextBoxBase)txtDate).BackColor = Color.White;
		((Control)txtDate).Cursor = Cursors.IBeam;
		((Control)txtDate).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtDate).ForeColor = SystemColors.WindowText;
		TextBox obj29 = txtDate;
		location = new Point(472, 152);
		((Control)obj29).Location = location;
		((TextBoxBase)txtDate).MaxLength = 10;
		((Control)txtDate).Name = "txtDate";
		((Control)txtDate).RightToLeft = (RightToLeft)0;
		TextBox obj30 = txtDate;
		size = new Size(97, 20);
		((Control)obj30).Size = size;
		((Control)txtDate).TabIndex = 8;
		((ButtonBase)cmdOk).BackColor = SystemColors.Control;
		((Control)cmdOk).Cursor = Cursors.Default;
		((Control)cmdOk).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdOk).ForeColor = SystemColors.ControlText;
		Button obj31 = cmdOk;
		location = new Point(248, 440);
		((Control)obj31).Location = location;
		((Control)cmdOk).Name = "cmdOk";
		((Control)cmdOk).RightToLeft = (RightToLeft)0;
		Button obj32 = cmdOk;
		size = new Size(81, 25);
		((Control)obj32).Size = size;
		((Control)cmdOk).TabIndex = 25;
		((ButtonBase)cmdOk).Text = "OK";
		((ButtonBase)cmdOk).UseVisualStyleBackColor = false;
		((ButtonBase)cmdCancel).BackColor = SystemColors.Control;
		((Control)cmdCancel).Cursor = Cursors.Default;
		cmdCancel.DialogResult = (DialogResult)2;
		((Control)cmdCancel).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCancel).ForeColor = SystemColors.ControlText;
		Button obj33 = cmdCancel;
		location = new Point(344, 440);
		((Control)obj33).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		((Control)cmdCancel).RightToLeft = (RightToLeft)0;
		Button obj34 = cmdCancel;
		size = new Size(81, 25);
		((Control)obj34).Size = size;
		((Control)cmdCancel).TabIndex = 26;
		((ButtonBase)cmdCancel).Text = "Cancel";
		((ButtonBase)cmdCancel).UseVisualStyleBackColor = false;
		((Control)_Label1_2).BackColor = SystemColors.Control;
		((Control)_Label1_2).Cursor = Cursors.Default;
		((Control)_Label1_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_2).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_2, (short)2);
		Label label1_ = _Label1_2;
		location = new Point(16, 120);
		((Control)label1_).Location = location;
		((Control)_Label1_2).Name = "_Label1_2";
		((Control)_Label1_2).RightToLeft = (RightToLeft)0;
		Label label1_2 = _Label1_2;
		size = new Size(97, 19);
		((Control)label1_2).Size = size;
		((Control)_Label1_2).TabIndex = 43;
		_Label1_2.Text = "Fiscal Year (yy):";
		_Label1_2.TextAlign = (ContentAlignment)4;
		((Control)lblInstructions).BackColor = SystemColors.Control;
		((Control)lblInstructions).Cursor = Cursors.Default;
		((Control)lblInstructions).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblInstructions).ForeColor = SystemColors.ControlText;
		Label obj35 = lblInstructions;
		location = new Point(8, 8);
		((Control)obj35).Location = location;
		((Control)lblInstructions).Name = "lblInstructions";
		((Control)lblInstructions).RightToLeft = (RightToLeft)0;
		Label obj36 = lblInstructions;
		size = new Size(593, 33);
		((Control)obj36).Size = size;
		((Control)lblInstructions).TabIndex = 42;
		lblInstructions.Text = "xxx";
		((Control)_Line1_1).BackColor = SystemColors.WindowText;
		Line1.SetIndex(_Line1_1, (short)1);
		Label line1_ = _Line1_1;
		location = new Point(8, 192);
		((Control)line1_).Location = location;
		((Control)_Line1_1).Name = "_Line1_1";
		Label line1_2 = _Line1_1;
		size = new Size(648, 1);
		((Control)line1_2).Size = size;
		((Control)_Line1_1).TabIndex = 44;
		((Control)_Label1_0).BackColor = SystemColors.Control;
		((Control)_Label1_0).Cursor = Cursors.Default;
		((Control)_Label1_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_0).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_0, (short)0);
		Label label1_3 = _Label1_0;
		location = new Point(0, 152);
		((Control)label1_3).Location = location;
		((Control)_Label1_0).Name = "_Label1_0";
		((Control)_Label1_0).RightToLeft = (RightToLeft)0;
		Label label1_4 = _Label1_0;
		size = new Size(113, 19);
		((Control)label1_4).Size = size;
		((Control)_Label1_0).TabIndex = 41;
		_Label1_0.Text = "Assessment Identifier:";
		_Label1_0.TextAlign = (ContentAlignment)4;
		((Control)_Label1_1).BackColor = SystemColors.Control;
		((Control)_Label1_1).Cursor = Cursors.Default;
		((Control)_Label1_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_1).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_1, (short)1);
		Label label1_5 = _Label1_1;
		location = new Point(8, 312);
		((Control)label1_5).Location = location;
		((Control)_Label1_1).Name = "_Label1_1";
		((Control)_Label1_1).RightToLeft = (RightToLeft)0;
		Label label1_6 = _Label1_1;
		size = new Size(89, 19);
		((Control)label1_6).Size = size;
		((Control)_Label1_1).TabIndex = 40;
		_Label1_1.Text = "Company Name:";
		_Label1_1.TextAlign = (ContentAlignment)4;
		((Control)_Label1_6).BackColor = SystemColors.Control;
		((Control)_Label1_6).Cursor = Cursors.Default;
		((Control)_Label1_6).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_6).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_6, (short)6);
		Label label1_7 = _Label1_6;
		location = new Point(8, 336);
		((Control)label1_7).Location = location;
		((Control)_Label1_6).Name = "_Label1_6";
		((Control)_Label1_6).RightToLeft = (RightToLeft)0;
		Label label1_8 = _Label1_6;
		size = new Size(89, 19);
		((Control)label1_8).Size = size;
		((Control)_Label1_6).TabIndex = 39;
		_Label1_6.Text = "Street Address:";
		_Label1_6.TextAlign = (ContentAlignment)4;
		((Control)_Label1_8).BackColor = SystemColors.Control;
		((Control)_Label1_8).Cursor = Cursors.Default;
		((Control)_Label1_8).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_8).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_8, (short)8);
		Label label1_9 = _Label1_8;
		location = new Point(24, 384);
		((Control)label1_9).Location = location;
		((Control)_Label1_8).Name = "_Label1_8";
		((Control)_Label1_8).RightToLeft = (RightToLeft)0;
		Label label1_10 = _Label1_8;
		size = new Size(73, 19);
		((Control)label1_10).Size = size;
		((Control)_Label1_8).TabIndex = 38;
		_Label1_8.Text = "City:";
		_Label1_8.TextAlign = (ContentAlignment)4;
		((Control)_Label1_13).BackColor = SystemColors.Control;
		((Control)_Label1_13).Cursor = Cursors.Default;
		((Control)_Label1_13).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_13).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_13, (short)13);
		Label label1_11 = _Label1_13;
		location = new Point(16, 56);
		((Control)label1_11).Location = location;
		((Control)_Label1_13).Name = "_Label1_13";
		((Control)_Label1_13).RightToLeft = (RightToLeft)0;
		Label label1_12 = _Label1_13;
		size = new Size(97, 19);
		((Control)label1_12).Size = size;
		((Control)_Label1_13).TabIndex = 37;
		_Label1_13.Text = "Assessment Type:";
		_Label1_13.TextAlign = (ContentAlignment)4;
		((Control)_Label1_29).BackColor = SystemColors.Control;
		((Control)_Label1_29).Cursor = Cursors.Default;
		((Control)_Label1_29).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_29).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_29, (short)29);
		Label label1_13 = _Label1_29;
		location = new Point(40, 408);
		((Control)label1_13).Location = location;
		((Control)_Label1_29).Name = "_Label1_29";
		((Control)_Label1_29).RightToLeft = (RightToLeft)0;
		Label label1_14 = _Label1_29;
		size = new Size(57, 19);
		((Control)label1_14).Size = size;
		((Control)_Label1_29).TabIndex = 36;
		_Label1_29.Text = "State:";
		_Label1_29.TextAlign = (ContentAlignment)4;
		((Control)_Label1_30).BackColor = SystemColors.Control;
		((Control)_Label1_30).Cursor = Cursors.Default;
		((Control)_Label1_30).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_30).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_30, (short)30);
		Label label1_15 = _Label1_30;
		location = new Point(176, 408);
		((Control)label1_15).Location = location;
		((Control)_Label1_30).Name = "_Label1_30";
		((Control)_Label1_30).RightToLeft = (RightToLeft)0;
		Label label1_16 = _Label1_30;
		size = new Size(33, 19);
		((Control)label1_16).Size = size;
		((Control)_Label1_30).TabIndex = 35;
		_Label1_30.Text = "Zip:";
		_Label1_30.TextAlign = (ContentAlignment)4;
		((Control)_Label1_4).BackColor = SystemColors.Control;
		((Control)_Label1_4).Cursor = Cursors.Default;
		((Control)_Label1_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_4).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_4, (short)4);
		Label label1_17 = _Label1_4;
		location = new Point(56, 88);
		((Control)label1_17).Location = location;
		((Control)_Label1_4).Name = "_Label1_4";
		((Control)_Label1_4).RightToLeft = (RightToLeft)0;
		Label label1_18 = _Label1_4;
		size = new Size(57, 19);
		((Control)label1_18).Size = size;
		((Control)_Label1_4).TabIndex = 34;
		_Label1_4.Text = "Status:";
		_Label1_4.TextAlign = (ContentAlignment)4;
		((Control)_Label1_5).BackColor = SystemColors.Control;
		((Control)_Label1_5).Cursor = Cursors.Default;
		((Control)_Label1_5).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_5).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_5, (short)5);
		Label label1_19 = _Label1_5;
		location = new Point(8, 224);
		((Control)label1_19).Location = location;
		((Control)_Label1_5).Name = "_Label1_5";
		((Control)_Label1_5).RightToLeft = (RightToLeft)0;
		Label label1_20 = _Label1_5;
		size = new Size(49, 19);
		((Control)label1_20).Size = size;
		((Control)_Label1_5).TabIndex = 33;
		_Label1_5.Text = "Affiliation:";
		_Label1_5.TextAlign = (ContentAlignment)4;
		((Control)_Label1_9).BackColor = SystemColors.Control;
		((Control)_Label1_9).Cursor = Cursors.Default;
		((Control)_Label1_9).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_9).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_9, (short)9);
		Label label1_21 = _Label1_9;
		location = new Point(16, 248);
		((Control)label1_21).Location = location;
		((Control)_Label1_9).Name = "_Label1_9";
		((Control)_Label1_9).RightToLeft = (RightToLeft)0;
		Label label1_22 = _Label1_9;
		size = new Size(41, 19);
		((Control)label1_22).Size = size;
		((Control)_Label1_9).TabIndex = 32;
		_Label1_9.Text = "Phone:";
		_Label1_9.TextAlign = (ContentAlignment)4;
		((Control)_Line1_0).BackColor = SystemColors.WindowText;
		Line1.SetIndex(_Line1_0, (short)0);
		Label line1_3 = _Line1_0;
		location = new Point(8, 304);
		((Control)line1_3).Location = location;
		((Control)_Line1_0).Name = "_Line1_0";
		Label line1_4 = _Line1_0;
		size = new Size(648, 1);
		((Control)line1_4).Size = size;
		((Control)_Line1_0).TabIndex = 45;
		((Control)_Label1_7).BackColor = SystemColors.Control;
		((Control)_Label1_7).Cursor = Cursors.Default;
		((Control)_Label1_7).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_7).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_7, (short)7);
		Label label1_23 = _Label1_7;
		location = new Point(432, 152);
		((Control)label1_23).Location = location;
		((Control)_Label1_7).Name = "_Label1_7";
		((Control)_Label1_7).RightToLeft = (RightToLeft)0;
		Label label1_24 = _Label1_7;
		size = new Size(33, 19);
		((Control)label1_24).Size = size;
		((Control)_Label1_7).TabIndex = 31;
		_Label1_7.Text = "Date:";
		((Control)_Label1_25).BackColor = SystemColors.Control;
		((Control)_Label1_25).Cursor = Cursors.Default;
		((Control)_Label1_25).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_25).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_25, (short)25);
		Label label1_25 = _Label1_25;
		location = new Point(8, 176);
		((Control)label1_25).Location = location;
		((Control)_Label1_25).Name = "_Label1_25";
		((Control)_Label1_25).RightToLeft = (RightToLeft)0;
		Label label1_26 = _Label1_25;
		size = new Size(81, 19);
		((Control)label1_26).Size = size;
		((Control)_Label1_25).TabIndex = 30;
		_Label1_25.Text = "Assessors: ";
		((Control)_Label1_32).BackColor = SystemColors.Control;
		((Control)_Label1_32).Cursor = Cursors.Default;
		((Control)_Label1_32).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_32).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_32, (short)32);
		Label label1_27 = _Label1_32;
		location = new Point(8, 200);
		((Control)label1_27).Location = location;
		((Control)_Label1_32).Name = "_Label1_32";
		((Control)_Label1_32).RightToLeft = (RightToLeft)0;
		Label label1_28 = _Label1_32;
		size = new Size(49, 19);
		((Control)label1_28).Size = size;
		((Control)_Label1_32).TabIndex = 29;
		_Label1_32.Text = "Name:";
		_Label1_32.TextAlign = (ContentAlignment)4;
		((Control)_Label1_10).BackColor = SystemColors.Control;
		((Control)_Label1_10).Cursor = Cursors.Default;
		((Control)_Label1_10).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_10).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_10, (short)10);
		Label label1_29 = _Label1_10;
		location = new Point(16, 272);
		((Control)label1_29).Location = location;
		((Control)_Label1_10).Name = "_Label1_10";
		((Control)_Label1_10).RightToLeft = (RightToLeft)0;
		Label label1_30 = _Label1_10;
		size = new Size(41, 19);
		((Control)label1_30).Size = size;
		((Control)_Label1_10).TabIndex = 28;
		_Label1_10.Text = "Email:";
		_Label1_10.TextAlign = (ContentAlignment)4;
		((Control)_Line1_2).BackColor = SystemColors.WindowText;
		Line1.SetIndex(_Line1_2, (short)2);
		Label line1_5 = _Line1_2;
		location = new Point(336, 192);
		((Control)line1_5).Location = location;
		((Control)_Line1_2).Name = "_Line1_2";
		Label line1_6 = _Line1_2;
		size = new Size(1, 112);
		((Control)line1_6).Size = size;
		((Control)_Line1_2).TabIndex = 46;
		((Control)_Label1_11).BackColor = SystemColors.Control;
		((Control)_Label1_11).Cursor = Cursors.Default;
		((Control)_Label1_11).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_11).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_11, (short)11);
		Label label1_31 = _Label1_11;
		location = new Point(336, 312);
		((Control)label1_31).Location = location;
		((Control)_Label1_11).Name = "_Label1_11";
		((Control)_Label1_11).RightToLeft = (RightToLeft)0;
		Label label1_32 = _Label1_11;
		size = new Size(145, 19);
		((Control)label1_32).Size = size;
		((Control)_Label1_11).TabIndex = 27;
		_Label1_11.Text = "Contact Information: ";
		size = new Size(5, 13);
		((Form)this).AutoScaleBaseSize = size;
		((Form)this).BackColor = SystemColors.Control;
		((Form)this).CancelButton = (IButtonControl)(object)cmdCancel;
		size = new Size(672, 478);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)txtConsCase);
		((Control)this).Controls.Add((Control)(object)chkConsCase);
		((Control)this).Controls.Add((Control)(object)txtFiscalYear);
		((Control)this).Controls.Add((Control)(object)txtContInfo);
		((Control)this).Controls.Add((Control)(object)txtStatusOther);
		((Control)this).Controls.Add((Control)(object)txtAssessOther);
		((Control)this).Controls.Add((Control)(object)_txtAddr_1);
		((Control)this).Controls.Add((Control)(object)_txtEmail_1);
		((Control)this).Controls.Add((Control)(object)_txtPhone_1);
		((Control)this).Controls.Add((Control)(object)_txtAffil_1);
		((Control)this).Controls.Add((Control)(object)_txtName_1);
		((Control)this).Controls.Add((Control)(object)txtID);
		((Control)this).Controls.Add((Control)(object)txtCoName);
		((Control)this).Controls.Add((Control)(object)chkCBI);
		((Control)this).Controls.Add((Control)(object)_txtAddr_0);
		((Control)this).Controls.Add((Control)(object)txtCity);
		((Control)this).Controls.Add((Control)(object)cmbState);
		((Control)this).Controls.Add((Control)(object)txtZip);
		((Control)this).Controls.Add((Control)(object)cmbAssessType);
		((Control)this).Controls.Add((Control)(object)_txtName_0);
		((Control)this).Controls.Add((Control)(object)cmbStatus);
		((Control)this).Controls.Add((Control)(object)_txtAffil_0);
		((Control)this).Controls.Add((Control)(object)_txtPhone_0);
		((Control)this).Controls.Add((Control)(object)_txtEmail_0);
		((Control)this).Controls.Add((Control)(object)txtDate);
		((Control)this).Controls.Add((Control)(object)cmdOk);
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)_Label1_2);
		((Control)this).Controls.Add((Control)(object)lblInstructions);
		((Control)this).Controls.Add((Control)(object)_Line1_1);
		((Control)this).Controls.Add((Control)(object)_Label1_0);
		((Control)this).Controls.Add((Control)(object)_Label1_1);
		((Control)this).Controls.Add((Control)(object)_Label1_6);
		((Control)this).Controls.Add((Control)(object)_Label1_8);
		((Control)this).Controls.Add((Control)(object)_Label1_13);
		((Control)this).Controls.Add((Control)(object)_Label1_29);
		((Control)this).Controls.Add((Control)(object)_Label1_30);
		((Control)this).Controls.Add((Control)(object)_Label1_4);
		((Control)this).Controls.Add((Control)(object)_Label1_5);
		((Control)this).Controls.Add((Control)(object)_Label1_9);
		((Control)this).Controls.Add((Control)(object)_Line1_0);
		((Control)this).Controls.Add((Control)(object)_Label1_7);
		((Control)this).Controls.Add((Control)(object)_Label1_25);
		((Control)this).Controls.Add((Control)(object)_Label1_32);
		((Control)this).Controls.Add((Control)(object)_Label1_10);
		((Control)this).Controls.Add((Control)(object)_Line1_2);
		((Control)this).Controls.Add((Control)(object)_Label1_11);
		((Control)this).Cursor = Cursors.Default;
		((Control)this).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		location = new Point(250, 150);
		((Form)this).Location = location;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmMDUpdGen";
		((Control)this).RightToLeft = (RightToLeft)0;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Update General Information";
		((ISupportInitialize)Label1).EndInit();
		((ISupportInitialize)Line1).EndInit();
		((ISupportInitialize)txtAddr).EndInit();
		((ISupportInitialize)txtAffil).EndInit();
		((ISupportInitialize)txtEmail).EndInit();
		((ISupportInitialize)txtName).EndInit();
		((ISupportInitialize)txtPhone).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
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
					command.Parameters.Append(command.CreateParameter("pID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, 16));
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
					flag = true;
					goto end_IL_0001;
				}
				case 341:
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
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 341;
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

	private void chkConsCase_CheckStateChanged(object eventSender, EventArgs eventArgs)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		if ((int)chkConsCase.CheckState == 1)
		{
			((Control)txtConsCase).Enabled = true;
			((TextBoxBase)txtConsCase).BackColor = Color.White;
		}
		else
		{
			((Control)txtConsCase).Enabled = false;
			((TextBoxBase)txtConsCase).BackColor = ((Form)this).BackColor;
			txtConsCase.Text = "";
		}
	}

	private void cmdCancel_Click(object eventSender, EventArgs eventArgs)
	{
		((Form)this).Close();
	}

	private void cmbAssessType_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
	{
		if (cmbAssessType.SelectedIndex == -1)
		{
			((Control)txtAssessOther).Visible = false;
		}
		else if (Support.GetItemData((Control)(object)cmbAssessType, cmbAssessType.SelectedIndex) > 900)
		{
			((Control)txtAssessOther).Visible = true;
		}
		else
		{
			((Control)txtAssessOther).Visible = false;
		}
	}

	private void cmbStatus_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
	{
		if (Operators.CompareString(cmbStatus.Text, "Other", false) == 0)
		{
			((Control)txtStatusOther).Visible = true;
		}
		else
		{
			((Control)txtStatusOther).Visible = false;
		}
	}

	private void frmMDUpdGen_Load(object eventSender, EventArgs eventArgs)
	{
		LoadCombos();
		ComboBox pCombo = cmbState;
		Common.LoadStateCombo(ref pCombo);
		cmbState = pCombo;
		SetUp();
	}

	private void LoadCombos()
	{
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected O, but got Unknown
		int try0001_dispatch = -1;
		int num2 = default(int);
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
					ProjectData.ClearProjectError();
					num2 = 2;
					recordset.CursorLocation = CursorLocationEnum.adUseClient;
					recordset.Open("SELECT * FROM ListOfAssessTypes", Common.MyConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
					while (!recordset.EOF)
					{
						arAssIDMustBe4Digits[cmbAssessType.Items.Count] = Conversions.ToShort(recordset.Fields["AssIDMustBe4Digits"].Value);
						cmbAssessType.Items.Add((object)new ListBoxItem(Conversions.ToString(recordset.Fields["AssType"].Value), Conversions.ToInteger(recordset.Fields["AssTypeID"].Value)));
						recordset.MoveNext();
					}
					recordset.Close();
					recordset.Open("SELECT * FROM ListOfAssStatus", Common.MyConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
					while (!recordset.EOF)
					{
						cmbStatus.Items.Add((object)new ListBoxItem(Conversions.ToString(recordset.Fields["AssStatus"].Value), Conversions.ToInteger(recordset.Fields["AssStatusID"].Value)));
						recordset.MoveNext();
					}
					recordset.Close();
					recordset = null;
					goto end_IL_0001;
				}
				case 458:
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
				try0001_dispatch = 458;
				continue;
			}
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

	private void cmdOk_Click(object eventSender, EventArgs eventArgs)
	{
		if (UpdateFrmMain())
		{
			Globals_Renamed.gblIWasChanged = true;
			((Form)this).Close();
		}
	}

	private bool UpdateFrmMain()
	{
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Invalid comparison between Unknown and I4
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b1: Invalid comparison between Unknown and I4
		int try0001_dispatch = -1;
		int num2 = default(int);
		string text = default(string);
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
					if (cmbAssessType.SelectedIndex != -1 && arAssIDMustBe4Digits[cmbAssessType.SelectedIndex] == 1)
					{
						if ((Strings.Len(txtID.Text) > 4) | !Versioned.IsNumeric((object)txtID.Text) | (Strings.InStr(txtID.Text, ".", (CompareMethod)0) > 0))
						{
							Interaction.Beep();
							((TextBoxBase)txtID).SelectionStart = 0;
							((TextBoxBase)txtID).SelectionLength = Strings.Len(txtID.Text);
							((Control)txtID).Focus();
							Interaction.MsgBox((object)("When the Assessment Type is " + cmbAssessType.Text + ", the Assessment Identifier must be a four digit number. Please correct this error before continuing."), (MsgBoxStyle)64, (object)"Invalid Entry");
							goto end_IL_0001;
						}
						if (Strings.Len(txtID.Text) < 4)
						{
							txtID.Text = Strings.Right("000" + txtID.Text, 4);
						}
					}
					if (Strings.Len(txtFiscalYear.Text) > 0 && !Versioned.IsNumeric((object)txtFiscalYear.Text))
					{
						Interaction.Beep();
						((TextBoxBase)txtFiscalYear).SelectionStart = 0;
						((TextBoxBase)txtFiscalYear).SelectionLength = Strings.Len(txtFiscalYear.Text);
						((Control)txtFiscalYear).Focus();
						Interaction.MsgBox((object)"Please enter a valid Fiscal Year. Fiscal Year should be a two digit year, such as '03' for the year 2003.", (MsgBoxStyle)64, (object)"Invalid Entry");
						goto end_IL_0001;
					}
					if (Operators.CompareString(Strings.Left(cmbAssessType.Text, 5), "Other", false) == 0)
					{
						frmMain.DefInstance.lblAssessType.Text = cmbAssessType.Text + ": " + txtAssessOther.Text;
					}
					else
					{
						frmMain.DefInstance.lblAssessType.Text = cmbAssessType.Text;
					}
					if (cmbAssessType.SelectedIndex == -1)
					{
						((Control)frmMain.DefInstance.lblAssessType).Tag = 0;
					}
					else
					{
						((Control)frmMain.DefInstance.lblAssessType).Tag = Support.GetItemData((Control)(object)cmbAssessType, cmbAssessType.SelectedIndex);
						text = cmbAssessType.Text;
					}
					if (Operators.CompareString(cmbStatus.Text, "Other", false) == 0)
					{
						frmMain.DefInstance.lblStatus.Text = cmbStatus.Text + ": " + txtStatusOther.Text;
					}
					else
					{
						frmMain.DefInstance.lblStatus.Text = cmbStatus.Text;
					}
					if (cmbStatus.SelectedIndex == -1)
					{
						((Control)frmMain.DefInstance.lblStatus).Tag = 0;
					}
					else
					{
						((Control)frmMain.DefInstance.lblStatus).Tag = Support.GetItemData((Control)(object)cmbStatus, cmbStatus.SelectedIndex);
					}
					frmMain.DefInstance.lblID.Text = txtID.Text;
					frmMain.DefInstance.lblFiscalYear.Text = txtFiscalYear.Text;
					((Form)frmMain.DefInstance).Text = "ChemSTEER v3.2, " + text + txtFiscalYear.Text + "-" + txtID.Text;
					frmMain.DefInstance.lblDate.Text = txtDate.Text;
					frmMain.DefInstance.lblConsCase.Text = Conversions.ToString(Interaction.IIf((int)chkConsCase.CheckState == 1, (object)"Yes", (object)"No"));
					if (Strings.Len(txtConsCase.Text) > 100)
					{
						Interaction.Beep();
						Interaction.MsgBox((object)"Consolidated Case information can only be 100 characters. The information that exceeds this limitation is being truncated.", (MsgBoxStyle)64, (object)null);
						frmMain.DefInstance.txtConsCase.Text = Strings.Left(txtConsCase.Text, 100);
					}
					else
					{
						frmMain.DefInstance.txtConsCase.Text = txtConsCase.Text;
					}
					frmMain.DefInstance.lblCBI.Text = Conversions.ToString(Interaction.IIf((int)chkCBI.CheckState == 1, (object)"Yes", (object)"No"));
					short num3 = 0;
					checked
					{
						short num4;
						short num5;
						do
						{
							frmMain.DefInstance.lblName[num3].Text = txtName[num3].Text;
							frmMain.DefInstance.lblAff[num3].Text = txtAffil[num3].Text;
							frmMain.DefInstance.lblPhone[num3].Text = txtPhone[num3].Text;
							frmMain.DefInstance.lblEmail[num3].Text = txtEmail[num3].Text;
							frmMain.DefInstance.lblAddr[num3].Text = txtAddr[num3].Text;
							num3 = (short)unchecked(num3 + 1);
							num4 = num3;
							num5 = 1;
						}
						while (num4 <= num5);
						frmMain.DefInstance.lblCoName.Text = txtCoName.Text;
						frmMain.DefInstance.lblCity.Text = txtCity.Text;
						frmMain.DefInstance.lblState.Text = cmbState.Text;
						frmMain.DefInstance.lblZip.Text = txtZip.Text;
						frmMain.DefInstance.sContactInfoNotepad = txtContInfo.Text;
						flag = true;
						goto end_IL_0001;
					}
				}
				case 1679:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						string Eobject = ((Control)this).Name;
						string Efunction = "UpdateFrmMain";
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
				try0001_dispatch = 1679;
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

	private void PopulateControls()
	{
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
						short num5;
						short num7;
						if (Operators.CompareString(Strings.Left(frmMain.DefInstance.lblAssessType.Text, 5), "Other", false) == 0)
						{
							short num3 = (short)Strings.InStr(frmMain.DefInstance.lblAssessType.Text, ":", (CompareMethod)0);
							if (num3 > 0)
							{
								short num4 = (short)(cmbAssessType.Items.Count - 1);
								num5 = 0;
								while (true)
								{
									short num6 = num5;
									num7 = num4;
									if (num6 <= num7)
									{
										if (Operators.CompareString(Support.GetItemString((Control)(object)cmbAssessType, unchecked((int)num5)), Strings.Left(frmMain.DefInstance.lblAssessType.Text, num3 - 1), false) == 0)
										{
											cmbAssessType.SelectedIndex = num5;
											txtAssessOther.Text = Strings.Mid(frmMain.DefInstance.lblAssessType.Text, num3 + 2);
											break;
										}
										num5 = (short)unchecked(num5 + 1);
										continue;
									}
									break;
								}
							}
						}
						else
						{
							short num8 = (short)(cmbAssessType.Items.Count - 1);
							num5 = 0;
							while (true)
							{
								short num9 = num5;
								num7 = num8;
								if (num9 > num7)
								{
									break;
								}
								if (Operators.CompareString(Support.GetItemString((Control)(object)cmbAssessType, unchecked((int)num5)), frmMain.DefInstance.lblAssessType.Text, false) == 0)
								{
									cmbAssessType.SelectedIndex = num5;
									break;
								}
								num5 = (short)unchecked(num5 + 1);
							}
						}
						if (Operators.CompareString(Strings.Left(frmMain.DefInstance.lblStatus.Text, 5), "Other", false) == 0)
						{
							short num10 = (short)(cmbStatus.Items.Count - 1);
							num5 = 0;
							while (true)
							{
								short num11 = num5;
								num7 = num10;
								if (num11 <= num7)
								{
									if (Operators.CompareString(Support.GetItemString((Control)(object)cmbStatus, unchecked((int)num5)), "Other", false) == 0)
									{
										cmbStatus.SelectedIndex = num5;
										txtStatusOther.Text = Strings.Mid(frmMain.DefInstance.lblStatus.Text, 8);
										break;
									}
									num5 = (short)unchecked(num5 + 1);
									continue;
								}
								break;
							}
						}
						else
						{
							short num12 = (short)(cmbStatus.Items.Count - 1);
							num5 = 0;
							while (true)
							{
								short num13 = num5;
								num7 = num12;
								if (num13 > num7)
								{
									break;
								}
								if (Operators.CompareString(Support.GetItemString((Control)(object)cmbStatus, unchecked((int)num5)), frmMain.DefInstance.lblStatus.Text, false) == 0)
								{
									cmbStatus.SelectedIndex = num5;
									break;
								}
								num5 = (short)unchecked(num5 + 1);
							}
						}
						txtFiscalYear.Text = frmMain.DefInstance.lblFiscalYear.Text;
						txtID.Text = frmMain.DefInstance.lblID.Text;
						if (Information.IsDate((object)frmMain.DefInstance.lblDate.Text))
						{
							txtDate.Text = frmMain.DefInstance.lblDate.Text;
						}
						else
						{
							txtDate.Text = Strings.Format((object)DateAndTime.Now, Globals_Renamed.gblChemDateFormat);
						}
						chkConsCase.CheckState = (CheckState)Conversions.ToInteger(Interaction.IIf(Operators.CompareString(frmMain.DefInstance.lblConsCase.Text, "Yes", false) == 0, (object)(CheckState)1, (object)(CheckState)0));
						txtConsCase.Text = frmMain.DefInstance.txtConsCase.Text;
						chkCBI.CheckState = (CheckState)Conversions.ToInteger(Interaction.IIf(Operators.CompareString(frmMain.DefInstance.lblCBI.Text, "Yes", false) == 0, (object)(CheckState)1, (object)(CheckState)0));
						num5 = 0;
						short num14;
						do
						{
							txtName[num5].Text = frmMain.DefInstance.lblName[num5].Text;
							txtAffil[num5].Text = frmMain.DefInstance.lblAff[num5].Text;
							txtPhone[num5].Text = frmMain.DefInstance.lblPhone[num5].Text;
							txtEmail[num5].Text = frmMain.DefInstance.lblEmail[num5].Text;
							txtAddr[num5].Text = frmMain.DefInstance.lblAddr[num5].Text;
							num5 = (short)unchecked(num5 + 1);
							num14 = num5;
							num7 = 1;
						}
						while (num14 <= num7);
						txtCoName.Text = frmMain.DefInstance.lblCoName.Text;
						txtCity.Text = frmMain.DefInstance.lblCity.Text;
						short num15 = (short)(cmbState.Items.Count - 1);
						num5 = 0;
						while (true)
						{
							short num16 = num5;
							num7 = num15;
							if (num16 > num7)
							{
								break;
							}
							if (Operators.CompareString(Support.GetItemString((Control)(object)cmbState, unchecked((int)num5)), frmMain.DefInstance.lblState.Text, false) == 0)
							{
								cmbState.SelectedIndex = num5;
								break;
							}
							num5 = (short)unchecked(num5 + 1);
						}
						txtZip.Text = frmMain.DefInstance.lblZip.Text;
						txtContInfo.Text = frmMain.DefInstance.sContactInfoNotepad;
						goto end_IL_0001;
					}
					case 1419:
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
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 1419;
				continue;
			}
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

	private void txtDate_Leave(object eventSender, EventArgs eventArgs)
	{
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (Information.IsDate((object)txtDate.Text))
		{
			DateTime dateTime = Conversions.ToDate(txtDate.Text);
			txtDate.Text = Strings.Format((object)dateTime, Globals_Renamed.gblChemDateFormat);
		}
		if (Strings.Len(txtDate.Text) > 0 && !Information.IsDate((object)txtDate.Text))
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Please enter a valid date", (MsgBoxStyle)32, (object)"Invalid Date");
			((TextBoxBase)txtDate).SelectionStart = 0;
			((TextBoxBase)txtDate).SelectionLength = Strings.Len(txtDate.Text);
			((Control)txtDate).Focus();
		}
	}

	private void txtFiscalYear_Leave(object eventSender, EventArgs eventArgs)
	{
		if (Strings.Len(txtFiscalYear.Text) == 1)
		{
			txtFiscalYear.Text = "0" + txtFiscalYear.Text;
		}
	}
}
