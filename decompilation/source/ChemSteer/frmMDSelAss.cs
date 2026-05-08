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

internal class frmMDSelAss : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("fraCRSS")]
	private GroupBox _fraCRSS;

	[AccessedThroughProperty("dgvMultiCRSS")]
	private DataGridView _dgvMultiCRSS;

	[AccessedThroughProperty("EPAIDNumberCRSS")]
	private DataGridViewTextBoxColumn _EPAIDNumberCRSS;

	[AccessedThroughProperty("_lblInstructions_0")]
	private Label __lblInstructions_0;

	[AccessedThroughProperty("fraAssess")]
	private Panel _fraAssess;

	[AccessedThroughProperty("dgvMultiAss")]
	private DataGridView _dgvMultiAss;

	[AccessedThroughProperty("AssessID")]
	private DataGridViewTextBoxColumn _AssessID;

	[AccessedThroughProperty("MyType")]
	private DataGridViewTextBoxColumn _MyType;

	[AccessedThroughProperty("FiscalYear")]
	private DataGridViewTextBoxColumn _FiscalYear;

	[AccessedThroughProperty("EPAIDNumber")]
	private DataGridViewTextBoxColumn _EPAIDNumber;

	[AccessedThroughProperty("MyCC")]
	private DataGridViewTextBoxColumn _MyCC;

	[AccessedThroughProperty("MyStatus")]
	private DataGridViewTextBoxColumn _MyStatus;

	[AccessedThroughProperty("SubmissionDate")]
	private DataGridViewTextBoxColumn _SubmissionDate;

	[AccessedThroughProperty("cmdSearch")]
	private Button _cmdSearch;

	[AccessedThroughProperty("cmdOK")]
	private Button _cmdOK;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("fraShow")]
	private Panel _fraShow;

	[AccessedThroughProperty("fraSearch")]
	private GroupBox _fraSearch;

	[AccessedThroughProperty("cmbAssType")]
	private ComboBox _cmbAssType;

	[AccessedThroughProperty("_cmdReset_1")]
	private Button __cmdReset_1;

	[AccessedThroughProperty("_cmdReset_0")]
	private Button __cmdReset_0;

	[AccessedThroughProperty("cmbAssStatus")]
	private ComboBox _cmbAssStatus;

	[AccessedThroughProperty("txtToDate")]
	private TextBox _txtToDate;

	[AccessedThroughProperty("txtAssID")]
	private TextBox _txtAssID;

	[AccessedThroughProperty("txtFromDate")]
	private TextBox _txtFromDate;

	[AccessedThroughProperty("_Label1_4")]
	private Label __Label1_4;

	[AccessedThroughProperty("_Label1_3")]
	private Label __Label1_3;

	[AccessedThroughProperty("_Label1_1")]
	private Label __Label1_1;

	[AccessedThroughProperty("_Label1_2")]
	private Label __Label1_2;

	[AccessedThroughProperty("_Label1_0")]
	private Label __Label1_0;

	public ToolTip ToolTip1;

	private static frmMDSelAss m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	private Recordset AllRowsRS;

	private string strSort;

	private string MyOp;

	public virtual GroupBox fraCRSS
	{
		[DebuggerNonUserCode]
		get
		{
			return _fraCRSS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_fraCRSS = value;
		}
	}

	internal virtual DataGridView dgvMultiCRSS
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvMultiCRSS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvMultiCRSS = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn EPAIDNumberCRSS
	{
		[DebuggerNonUserCode]
		get
		{
			return _EPAIDNumberCRSS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_EPAIDNumberCRSS = value;
		}
	}

	public virtual Label _lblInstructions_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblInstructions_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblInstructions_0 = value;
		}
	}

	public virtual Panel fraAssess
	{
		[DebuggerNonUserCode]
		get
		{
			return _fraAssess;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_fraAssess = value;
		}
	}

	internal virtual DataGridView dgvMultiAss
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvMultiAss;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvMultiAss = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn AssessID
	{
		[DebuggerNonUserCode]
		get
		{
			return _AssessID;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_AssessID = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn MyType
	{
		[DebuggerNonUserCode]
		get
		{
			return _MyType;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_MyType = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn FiscalYear
	{
		[DebuggerNonUserCode]
		get
		{
			return _FiscalYear;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_FiscalYear = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn EPAIDNumber
	{
		[DebuggerNonUserCode]
		get
		{
			return _EPAIDNumber;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_EPAIDNumber = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn MyCC
	{
		[DebuggerNonUserCode]
		get
		{
			return _MyCC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_MyCC = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn MyStatus
	{
		[DebuggerNonUserCode]
		get
		{
			return _MyStatus;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_MyStatus = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn SubmissionDate
	{
		[DebuggerNonUserCode]
		get
		{
			return _SubmissionDate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SubmissionDate = value;
		}
	}

	public virtual Button cmdSearch
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdSearch;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdSearch_Click;
			if (_cmdSearch != null)
			{
				((Control)_cmdSearch).Click -= eventHandler;
			}
			_cmdSearch = value;
			if (_cmdSearch != null)
			{
				((Control)_cmdSearch).Click += eventHandler;
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

	public virtual Panel fraShow
	{
		[DebuggerNonUserCode]
		get
		{
			return _fraShow;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_fraShow = value;
		}
	}

	public virtual GroupBox fraSearch
	{
		[DebuggerNonUserCode]
		get
		{
			return _fraSearch;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_fraSearch = value;
		}
	}

	public virtual ComboBox cmbAssType
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbAssType;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cmbAssType = value;
		}
	}

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
			EventHandler eventHandler = cmdReset1_Click;
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
			EventHandler eventHandler = cmdReset0_Click;
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

	public virtual ComboBox cmbAssStatus
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbAssStatus;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cmbAssStatus = value;
		}
	}

	public virtual TextBox txtToDate
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtToDate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtToDate = value;
		}
	}

	public virtual TextBox txtAssID
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtAssID;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtAssID = value;
		}
	}

	public virtual TextBox txtFromDate
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtFromDate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtFromDate = value;
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

	public static frmMDSelAss DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmMDSelAss();
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

	public frmMDSelAss()
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
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected O, but got Unknown
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected O, but got Unknown
		//IL_04c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Expected O, but got Unknown
		//IL_07a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ae: Expected O, but got Unknown
		//IL_0870: Unknown result type (might be due to invalid IL or missing references)
		//IL_087a: Expected O, but got Unknown
		//IL_0940: Unknown result type (might be due to invalid IL or missing references)
		//IL_094a: Expected O, but got Unknown
		//IL_0a9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa8: Expected O, but got Unknown
		//IL_0c57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c61: Expected O, but got Unknown
		//IL_0d34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3e: Expected O, but got Unknown
		//IL_0de9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df3: Expected O, but got Unknown
		//IL_0eb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec3: Expected O, but got Unknown
		//IL_0f96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa0: Expected O, but got Unknown
		//IL_1058: Unknown result type (might be due to invalid IL or missing references)
		//IL_1062: Expected O, but got Unknown
		//IL_1125: Unknown result type (might be due to invalid IL or missing references)
		//IL_112f: Expected O, but got Unknown
		//IL_11f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_11fb: Expected O, but got Unknown
		//IL_12b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12bb: Expected O, but got Unknown
		//IL_1382: Unknown result type (might be due to invalid IL or missing references)
		//IL_138c: Expected O, but got Unknown
		//IL_1453: Unknown result type (might be due to invalid IL or missing references)
		//IL_145d: Expected O, but got Unknown
		//IL_1517: Unknown result type (might be due to invalid IL or missing references)
		//IL_1521: Expected O, but got Unknown
		//IL_15e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f2: Expected O, but got Unknown
		//IL_16d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_16dd: Expected O, but got Unknown
		//IL_16f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_16fc: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMDSelAss));
		ToolTip1 = new ToolTip(components);
		fraCRSS = new GroupBox();
		dgvMultiCRSS = new DataGridView();
		EPAIDNumberCRSS = new DataGridViewTextBoxColumn();
		_lblInstructions_0 = new Label();
		fraAssess = new Panel();
		dgvMultiAss = new DataGridView();
		AssessID = new DataGridViewTextBoxColumn();
		MyType = new DataGridViewTextBoxColumn();
		FiscalYear = new DataGridViewTextBoxColumn();
		EPAIDNumber = new DataGridViewTextBoxColumn();
		MyCC = new DataGridViewTextBoxColumn();
		MyStatus = new DataGridViewTextBoxColumn();
		SubmissionDate = new DataGridViewTextBoxColumn();
		cmdSearch = new Button();
		cmdOK = new Button();
		cmdCancel = new Button();
		fraShow = new Panel();
		fraSearch = new GroupBox();
		cmbAssType = new ComboBox();
		_cmdReset_1 = new Button();
		_cmdReset_0 = new Button();
		cmbAssStatus = new ComboBox();
		txtToDate = new TextBox();
		txtAssID = new TextBox();
		txtFromDate = new TextBox();
		_Label1_4 = new Label();
		_Label1_3 = new Label();
		_Label1_1 = new Label();
		_Label1_2 = new Label();
		_Label1_0 = new Label();
		((Control)fraCRSS).SuspendLayout();
		((ISupportInitialize)dgvMultiCRSS).BeginInit();
		((Control)fraAssess).SuspendLayout();
		((ISupportInitialize)dgvMultiAss).BeginInit();
		((Control)fraShow).SuspendLayout();
		((Control)fraSearch).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)fraCRSS).BackColor = SystemColors.Control;
		((Control)fraCRSS).Controls.Add((Control)(object)dgvMultiCRSS);
		((Control)fraCRSS).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)fraCRSS).ForeColor = SystemColors.ControlText;
		GroupBox obj = fraCRSS;
		Point location = new Point(28, 52);
		((Control)obj).Location = location;
		((Control)fraCRSS).Name = "fraCRSS";
		((Control)fraCRSS).RightToLeft = (RightToLeft)0;
		GroupBox obj2 = fraCRSS;
		Size size = new Size(811, 338);
		((Control)obj2).Size = size;
		((Control)fraCRSS).TabIndex = 22;
		fraCRSS.TabStop = false;
		dgvMultiCRSS.AllowUserToAddRows = false;
		dgvMultiCRSS.AllowUserToDeleteRows = false;
		dgvMultiCRSS.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		dgvMultiCRSS.Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[1] { (DataGridViewColumn)EPAIDNumberCRSS });
		DataGridView obj3 = dgvMultiCRSS;
		location = new Point(19, 36);
		((Control)obj3).Location = location;
		dgvMultiCRSS.MultiSelect = false;
		((Control)dgvMultiCRSS).Name = "dgvMultiCRSS";
		DataGridView obj4 = dgvMultiCRSS;
		size = new Size(735, 286);
		((Control)obj4).Size = size;
		((Control)dgvMultiCRSS).TabIndex = 23;
		((DataGridViewColumn)EPAIDNumberCRSS).HeaderText = "EPA Identification Number";
		((DataGridViewColumn)EPAIDNumberCRSS).Name = "EPAIDNumberCRSS";
		((DataGridViewColumn)EPAIDNumberCRSS).ReadOnly = true;
		((DataGridViewColumn)EPAIDNumberCRSS).Width = 600;
		((Control)_lblInstructions_0).BackColor = SystemColors.Control;
		((Control)_lblInstructions_0).Cursor = Cursors.Default;
		((Control)_lblInstructions_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblInstructions_0).ForeColor = SystemColors.ControlText;
		Label lblInstructions_ = _lblInstructions_0;
		location = new Point(8, 16);
		((Control)lblInstructions_).Location = location;
		((Control)_lblInstructions_0).Name = "_lblInstructions_0";
		((Control)_lblInstructions_0).RightToLeft = (RightToLeft)0;
		Label lblInstructions_2 = _lblInstructions_0;
		size = new Size(665, 33);
		((Control)lblInstructions_2).Size = size;
		((Control)_lblInstructions_0).TabIndex = 10;
		_lblInstructions_0.Text = "xxx";
		((Control)fraAssess).BackColor = SystemColors.Control;
		((Control)fraAssess).Controls.Add((Control)(object)dgvMultiAss);
		((Control)fraAssess).Controls.Add((Control)(object)cmdSearch);
		((Control)fraAssess).Cursor = Cursors.Default;
		((Control)fraAssess).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)fraAssess).ForeColor = SystemColors.ControlText;
		Panel obj5 = fraAssess;
		location = new Point(220, 471);
		((Control)obj5).Location = location;
		((Control)fraAssess).Name = "fraAssess";
		((Control)fraAssess).RightToLeft = (RightToLeft)0;
		Panel obj6 = fraAssess;
		size = new Size(144, 77);
		((Control)obj6).Size = size;
		((Control)fraAssess).TabIndex = 18;
		dgvMultiAss.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		dgvMultiAss.Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[7]
		{
			(DataGridViewColumn)AssessID,
			(DataGridViewColumn)MyType,
			(DataGridViewColumn)FiscalYear,
			(DataGridViewColumn)EPAIDNumber,
			(DataGridViewColumn)MyCC,
			(DataGridViewColumn)MyStatus,
			(DataGridViewColumn)SubmissionDate
		});
		((Control)dgvMultiAss).Cursor = Cursors.IBeam;
		DataGridView obj7 = dgvMultiAss;
		location = new Point(3, 33);
		((Control)obj7).Location = location;
		((Control)dgvMultiAss).Name = "dgvMultiAss";
		DataGridView obj8 = dgvMultiAss;
		size = new Size(809, 275);
		((Control)obj8).Size = size;
		((Control)dgvMultiAss).TabIndex = 21;
		((DataGridViewColumn)AssessID).HeaderText = "AssessID";
		((DataGridViewColumn)AssessID).Name = "AssessID";
		((DataGridViewColumn)AssessID).Visible = false;
		((DataGridViewColumn)MyType).HeaderText = "Type";
		((DataGridViewColumn)MyType).Name = "MyType";
		((DataGridViewColumn)MyType).ReadOnly = true;
		((DataGridViewColumn)FiscalYear).HeaderText = "Fiscal Year";
		((DataGridViewColumn)FiscalYear).Name = "FiscalYear";
		((DataGridViewColumn)FiscalYear).ReadOnly = true;
		((DataGridViewColumn)EPAIDNumber).HeaderText = "Identifier";
		((DataGridViewColumn)EPAIDNumber).Name = "EPAIDNumber";
		((DataGridViewColumn)EPAIDNumber).ReadOnly = true;
		((DataGridViewColumn)MyCC).HeaderText = "Consolidate Case";
		((DataGridViewColumn)MyCC).Name = "MyCC";
		((DataGridViewColumn)MyCC).ReadOnly = true;
		((DataGridViewColumn)MyStatus).HeaderText = "Status";
		((DataGridViewColumn)MyStatus).Name = "MyStatus";
		((DataGridViewColumn)MyStatus).ReadOnly = true;
		((DataGridViewColumn)SubmissionDate).HeaderText = "Date";
		((DataGridViewColumn)SubmissionDate).Name = "SubmissionDate";
		((DataGridViewColumn)SubmissionDate).ReadOnly = true;
		((ButtonBase)cmdSearch).BackColor = SystemColors.Control;
		((Control)cmdSearch).Cursor = Cursors.Default;
		((Control)cmdSearch).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdSearch).ForeColor = SystemColors.ControlText;
		Button obj9 = cmdSearch;
		location = new Point(0, 0);
		((Control)obj9).Location = location;
		((Control)cmdSearch).Name = "cmdSearch";
		((Control)cmdSearch).RightToLeft = (RightToLeft)0;
		Button obj10 = cmdSearch;
		size = new Size(81, 25);
		((Control)obj10).Size = size;
		((Control)cmdSearch).TabIndex = 19;
		((ButtonBase)cmdSearch).Text = "&Search";
		((ButtonBase)cmdSearch).UseVisualStyleBackColor = false;
		((ButtonBase)cmdOK).BackColor = SystemColors.Control;
		((Control)cmdOK).Cursor = Cursors.Default;
		((Control)cmdOK).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdOK).ForeColor = SystemColors.ControlText;
		Button obj11 = cmdOK;
		location = new Point(40, 396);
		((Control)obj11).Location = location;
		((Control)cmdOK).Name = "cmdOK";
		((Control)cmdOK).RightToLeft = (RightToLeft)0;
		Button obj12 = cmdOK;
		size = new Size(81, 25);
		((Control)obj12).Size = size;
		((Control)cmdOK).TabIndex = 7;
		((ButtonBase)cmdOK).Text = "&Open";
		((ButtonBase)cmdOK).UseVisualStyleBackColor = false;
		((ButtonBase)cmdCancel).BackColor = SystemColors.Control;
		((Control)cmdCancel).Cursor = Cursors.Default;
		((Control)cmdCancel).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCancel).ForeColor = SystemColors.ControlText;
		Button obj13 = cmdCancel;
		location = new Point(140, 396);
		((Control)obj13).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		((Control)cmdCancel).RightToLeft = (RightToLeft)0;
		Button obj14 = cmdCancel;
		size = new Size(81, 25);
		((Control)obj14).Size = size;
		((Control)cmdCancel).TabIndex = 23;
		((ButtonBase)cmdCancel).Text = "&Cancel";
		((ButtonBase)cmdCancel).UseVisualStyleBackColor = false;
		((Control)fraShow).BackColor = SystemColors.Control;
		((Control)fraShow).Controls.Add((Control)(object)fraSearch);
		((Control)fraShow).Controls.Add((Control)(object)cmdCancel);
		((Control)fraShow).Controls.Add((Control)(object)cmdOK);
		((Control)fraShow).Controls.Add((Control)(object)fraAssess);
		((Control)fraShow).Controls.Add((Control)(object)_lblInstructions_0);
		((Control)fraShow).Controls.Add((Control)(object)fraCRSS);
		((Control)fraShow).Cursor = Cursors.Default;
		((Control)fraShow).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)fraShow).ForeColor = SystemColors.ControlText;
		Panel obj15 = fraShow;
		location = new Point(21, 12);
		((Control)obj15).Location = location;
		((Control)fraShow).Name = "fraShow";
		((Control)fraShow).RightToLeft = (RightToLeft)0;
		Panel obj16 = fraShow;
		size = new Size(881, 444);
		((Control)obj16).Size = size;
		((Control)fraShow).TabIndex = 9;
		((Control)fraSearch).BackColor = SystemColors.Control;
		((Control)fraSearch).Controls.Add((Control)(object)cmbAssType);
		((Control)fraSearch).Controls.Add((Control)(object)_cmdReset_1);
		((Control)fraSearch).Controls.Add((Control)(object)_cmdReset_0);
		((Control)fraSearch).Controls.Add((Control)(object)cmbAssStatus);
		((Control)fraSearch).Controls.Add((Control)(object)txtToDate);
		((Control)fraSearch).Controls.Add((Control)(object)txtAssID);
		((Control)fraSearch).Controls.Add((Control)(object)txtFromDate);
		((Control)fraSearch).Controls.Add((Control)(object)_Label1_4);
		((Control)fraSearch).Controls.Add((Control)(object)_Label1_3);
		((Control)fraSearch).Controls.Add((Control)(object)_Label1_1);
		((Control)fraSearch).Controls.Add((Control)(object)_Label1_2);
		((Control)fraSearch).Controls.Add((Control)(object)_Label1_0);
		((Control)fraSearch).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)fraSearch).ForeColor = SystemColors.ControlText;
		GroupBox obj17 = fraSearch;
		location = new Point(28, 471);
		((Control)obj17).Location = location;
		((Control)fraSearch).Name = "fraSearch";
		((Control)fraSearch).RightToLeft = (RightToLeft)0;
		GroupBox obj18 = fraSearch;
		size = new Size(138, 46);
		((Control)obj18).Size = size;
		((Control)fraSearch).TabIndex = 12;
		fraSearch.TabStop = false;
		((Control)fraSearch).Visible = false;
		cmbAssType.BackColor = SystemColors.Window;
		((Control)cmbAssType).Cursor = Cursors.Default;
		cmbAssType.DropDownStyle = (ComboBoxStyle)2;
		((Control)cmbAssType).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		cmbAssType.ForeColor = SystemColors.WindowText;
		ComboBox obj19 = cmbAssType;
		location = new Point(230, 80);
		((Control)obj19).Location = location;
		((Control)cmbAssType).Name = "cmbAssType";
		((Control)cmbAssType).RightToLeft = (RightToLeft)0;
		ComboBox obj20 = cmbAssType;
		size = new Size(209, 22);
		((Control)obj20).Size = size;
		((Control)cmbAssType).TabIndex = 3;
		((ButtonBase)_cmdReset_1).BackColor = SystemColors.Control;
		((Control)_cmdReset_1).Cursor = Cursors.Default;
		((Control)_cmdReset_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_cmdReset_1).ForeColor = SystemColors.ControlText;
		Button cmdReset_ = _cmdReset_1;
		location = new Point(446, 112);
		((Control)cmdReset_).Location = location;
		((Control)_cmdReset_1).Name = "_cmdReset_1";
		((Control)_cmdReset_1).RightToLeft = (RightToLeft)0;
		Button cmdReset_2 = _cmdReset_1;
		size = new Size(65, 19);
		((Control)cmdReset_2).Size = size;
		((Control)_cmdReset_1).TabIndex = 6;
		((ButtonBase)_cmdReset_1).Text = "Reset";
		((ButtonBase)_cmdReset_1).UseVisualStyleBackColor = false;
		((ButtonBase)_cmdReset_0).BackColor = SystemColors.Control;
		((Control)_cmdReset_0).Cursor = Cursors.Default;
		((Control)_cmdReset_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_cmdReset_0).ForeColor = SystemColors.ControlText;
		Button cmdReset_3 = _cmdReset_0;
		location = new Point(446, 80);
		((Control)cmdReset_3).Location = location;
		((Control)_cmdReset_0).Name = "_cmdReset_0";
		((Control)_cmdReset_0).RightToLeft = (RightToLeft)0;
		Button cmdReset_4 = _cmdReset_0;
		size = new Size(65, 19);
		((Control)cmdReset_4).Size = size;
		((Control)_cmdReset_0).TabIndex = 4;
		((ButtonBase)_cmdReset_0).Text = "Reset";
		((ButtonBase)_cmdReset_0).UseVisualStyleBackColor = false;
		cmbAssStatus.BackColor = SystemColors.Window;
		((Control)cmbAssStatus).Cursor = Cursors.Default;
		cmbAssStatus.DropDownStyle = (ComboBoxStyle)2;
		((Control)cmbAssStatus).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		cmbAssStatus.ForeColor = SystemColors.WindowText;
		ComboBox obj21 = cmbAssStatus;
		location = new Point(230, 112);
		((Control)obj21).Location = location;
		((Control)cmbAssStatus).Name = "cmbAssStatus";
		((Control)cmbAssStatus).RightToLeft = (RightToLeft)0;
		ComboBox obj22 = cmbAssStatus;
		size = new Size(209, 22);
		((Control)obj22).Size = size;
		((Control)cmbAssStatus).TabIndex = 5;
		txtToDate.AcceptsReturn = true;
		((TextBoxBase)txtToDate).BackColor = SystemColors.Window;
		((Control)txtToDate).Cursor = Cursors.IBeam;
		((Control)txtToDate).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtToDate).ForeColor = SystemColors.WindowText;
		TextBox obj23 = txtToDate;
		location = new Point(342, 48);
		((Control)obj23).Location = location;
		((TextBoxBase)txtToDate).MaxLength = 10;
		((Control)txtToDate).Name = "txtToDate";
		((Control)txtToDate).RightToLeft = (RightToLeft)0;
		TextBox obj24 = txtToDate;
		size = new Size(89, 20);
		((Control)obj24).Size = size;
		((Control)txtToDate).TabIndex = 2;
		txtAssID.AcceptsReturn = true;
		((TextBoxBase)txtAssID).BackColor = SystemColors.Window;
		((Control)txtAssID).Cursor = Cursors.IBeam;
		((Control)txtAssID).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtAssID).ForeColor = SystemColors.WindowText;
		TextBox obj25 = txtAssID;
		location = new Point(230, 16);
		((Control)obj25).Location = location;
		((TextBoxBase)txtAssID).MaxLength = 0;
		((Control)txtAssID).Name = "txtAssID";
		((Control)txtAssID).RightToLeft = (RightToLeft)0;
		TextBox obj26 = txtAssID;
		size = new Size(113, 20);
		((Control)obj26).Size = size;
		((Control)txtAssID).TabIndex = 0;
		txtFromDate.AcceptsReturn = true;
		((TextBoxBase)txtFromDate).BackColor = SystemColors.Window;
		((Control)txtFromDate).Cursor = Cursors.IBeam;
		((Control)txtFromDate).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtFromDate).ForeColor = SystemColors.WindowText;
		TextBox obj27 = txtFromDate;
		location = new Point(230, 48);
		((Control)obj27).Location = location;
		((TextBoxBase)txtFromDate).MaxLength = 10;
		((Control)txtFromDate).Name = "txtFromDate";
		((Control)txtFromDate).RightToLeft = (RightToLeft)0;
		TextBox obj28 = txtFromDate;
		size = new Size(89, 20);
		((Control)obj28).Size = size;
		((Control)txtFromDate).TabIndex = 1;
		((Control)_Label1_4).BackColor = SystemColors.Control;
		((Control)_Label1_4).Cursor = Cursors.Default;
		((Control)_Label1_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_4).ForeColor = SystemColors.ControlText;
		Label label1_ = _Label1_4;
		location = new Point(30, 112);
		((Control)label1_).Location = location;
		((Control)_Label1_4).Name = "_Label1_4";
		((Control)_Label1_4).RightToLeft = (RightToLeft)0;
		Label label1_2 = _Label1_4;
		size = new Size(193, 17);
		((Control)label1_2).Size = size;
		((Control)_Label1_4).TabIndex = 17;
		_Label1_4.Text = "Assessment Status: ";
		_Label1_4.TextAlign = (ContentAlignment)4;
		((Control)_Label1_3).BackColor = SystemColors.Control;
		((Control)_Label1_3).Cursor = Cursors.Default;
		((Control)_Label1_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_3).ForeColor = SystemColors.ControlText;
		Label label1_3 = _Label1_3;
		location = new Point(30, 80);
		((Control)label1_3).Location = location;
		((Control)_Label1_3).Name = "_Label1_3";
		((Control)_Label1_3).RightToLeft = (RightToLeft)0;
		Label label1_4 = _Label1_3;
		size = new Size(193, 17);
		((Control)label1_4).Size = size;
		((Control)_Label1_3).TabIndex = 16;
		_Label1_3.Text = "Assessment Type: ";
		_Label1_3.TextAlign = (ContentAlignment)4;
		((Control)_Label1_1).BackColor = SystemColors.Control;
		((Control)_Label1_1).Cursor = Cursors.Default;
		((Control)_Label1_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_1).ForeColor = SystemColors.ControlText;
		Label label1_5 = _Label1_1;
		location = new Point(326, 48);
		((Control)label1_5).Location = location;
		((Control)_Label1_1).Name = "_Label1_1";
		((Control)_Label1_1).RightToLeft = (RightToLeft)0;
		Label label1_6 = _Label1_1;
		size = new Size(25, 17);
		((Control)label1_6).Size = size;
		((Control)_Label1_1).TabIndex = 15;
		_Label1_1.Text = "to";
		((Control)_Label1_2).BackColor = SystemColors.Control;
		((Control)_Label1_2).Cursor = Cursors.Default;
		((Control)_Label1_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_2).ForeColor = SystemColors.ControlText;
		Label label1_7 = _Label1_2;
		location = new Point(30, 16);
		((Control)label1_7).Location = location;
		((Control)_Label1_2).Name = "_Label1_2";
		((Control)_Label1_2).RightToLeft = (RightToLeft)0;
		Label label1_8 = _Label1_2;
		size = new Size(193, 17);
		((Control)label1_8).Size = size;
		((Control)_Label1_2).TabIndex = 13;
		_Label1_2.Text = "Assessment ID:";
		_Label1_2.TextAlign = (ContentAlignment)4;
		((Control)_Label1_0).BackColor = SystemColors.Control;
		((Control)_Label1_0).Cursor = Cursors.Default;
		((Control)_Label1_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_0).ForeColor = SystemColors.ControlText;
		Label label1_9 = _Label1_0;
		location = new Point(30, 48);
		((Control)label1_9).Location = location;
		((Control)_Label1_0).Name = "_Label1_0";
		((Control)_Label1_0).RightToLeft = (RightToLeft)0;
		Label label1_10 = _Label1_0;
		size = new Size(193, 17);
		((Control)label1_10).Size = size;
		((Control)_Label1_0).TabIndex = 12;
		_Label1_0.Text = "Date Range:";
		_Label1_0.TextAlign = (ContentAlignment)4;
		size = new Size(5, 13);
		((Form)this).AutoScaleBaseSize = size;
		size = new Size(928, 476);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)fraShow);
		((Control)this).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		location = new Point(250, 150);
		((Form)this).Location = location;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmMDSelAss";
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Select Assessment";
		((Control)fraCRSS).ResumeLayout(false);
		((ISupportInitialize)dgvMultiCRSS).EndInit();
		((Control)fraAssess).ResumeLayout(false);
		((ISupportInitialize)dgvMultiAss).EndInit();
		((Control)fraShow).ResumeLayout(false);
		((Control)fraSearch).ResumeLayout(false);
		((Control)fraSearch).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	public bool SetUp(Recordset pRS, ref string pOp)
	{
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b0: Expected O, but got Unknown
		//IL_0533: Unknown result type (might be due to invalid IL or missing references)
		//IL_053d: Expected O, but got Unknown
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
		Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		MyOp = pOp;
		command.ActiveConnection = Common.MyConn;
		command.CommandText = "pqryGetInstructions";
		command.CommandType = CommandTypeEnum.adCmdStoredProc;
		int num = MyOp switch
		{
			"O" => 39, 
			"IOp" => 49, 
			"D" => 42, 
			_ => 47, 
		};
		command.Parameters.Append(command.CreateParameter("pID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, num));
		Command command2 = command;
		object RecordsAffected = Missing.Value;
		object Parameters = Missing.Value;
		recordset = command2.Execute(out RecordsAffected, ref Parameters);
		command.Parameters.Delete("pID");
		if (Operators.CompareString(MyOp, "IOp", false) == 0)
		{
			_lblInstructions_0.Text = Strings.Replace(Conversions.ToString(recordset.Fields["Instructions"].Value), "XXX", Interaction.GetSetting("ChemSteer", "Options", "LastDatabaseUsedToImportOperation", "Unknown file. ERROR"), 1, -1, (CompareMethod)0);
		}
		else
		{
			_lblInstructions_0.Text = Conversions.ToString(recordset.Fields["Instructions"].Value);
		}
		recordset.Close();
		command.Parameters.Append(command.CreateParameter("pID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, 40));
		Command command3 = command;
		Parameters = Missing.Value;
		RecordsAffected = Missing.Value;
		recordset = command3.Execute(out Parameters, ref RecordsAffected);
		command.Parameters.Delete("pID");
		_lblInstructions_0.Text = Conversions.ToString(recordset.Fields["Instructions"].Value);
		recordset.Close();
		if ((Operators.CompareString(MyOp, "I", false) == 0) | (Operators.CompareString(MyOp, "V", false) == 0))
		{
			if (Operators.CompareString(MyOp, "I", false) == 0)
			{
				((ButtonBase)cmdOK).Text = "&Import";
			}
			else
			{
				((ButtonBase)cmdOK).Text = "&View";
			}
			((Control)_fraCRSS).Visible = true;
			((Control)_fraAssess).Visible = false;
			((Control)_fraSearch).Visible = false;
			AllRowsRS = pRS;
			dgvMultiCRSS.Rows.Clear();
			while (!AllRowsRS.EOF)
			{
				dgvMultiCRSS.Rows.Add(new object[1] { RuntimeHelpers.GetObjectValue(AllRowsRS.Fields["PMN number"].Value) });
				AllRowsRS.MoveNext();
			}
		}
		else
		{
			((Control)fraAssess).Left = ((Control)fraCRSS).Left;
			((Control)fraAssess).Top = ((Control)fraCRSS).Top;
			((Control)fraAssess).Height = ((Control)fraCRSS).Height;
			((Control)fraAssess).Width = ((Control)fraCRSS).Width;
			if (Operators.CompareString(MyOp, "D", false) == 0)
			{
				((ButtonBase)cmdOK).Text = "&Delete";
			}
			else if (Operators.CompareString(MyOp, "O", false) == 0)
			{
				((ButtonBase)cmdOK).Text = "&Open";
			}
			else
			{
				((Control)cmdSearch).Visible = false;
				((ButtonBase)cmdOK).Text = "&Select";
			}
			((Control)_fraAssess).Visible = true;
			((Control)_fraCRSS).Visible = false;
			((Control)_fraSearch).Visible = false;
			recordset.CursorLocation = CursorLocationEnum.adUseClient;
			recordset.Open("SELECT * FROM ListOfAssessTypes", Common.MyConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
			while (!recordset.EOF)
			{
				cmbAssType.Items.Add((object)new ListBoxItem(Conversions.ToString(recordset.Fields["AssType"].Value), Conversions.ToInteger(recordset.Fields["AssTypeID"].Value)));
				recordset.MoveNext();
			}
			recordset.Close();
			recordset.CursorLocation = CursorLocationEnum.adUseClient;
			recordset.Open("SELECT * FROM ListOfAssStatus", Common.MyConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
			while (!recordset.EOF)
			{
				cmbAssStatus.Items.Add((object)new ListBoxItem(Conversions.ToString(recordset.Fields["AssStatus"].Value), Conversions.ToInteger(recordset.Fields["AssStatusID"].Value)));
				recordset.MoveNext();
			}
			recordset.Close();
			AllRowsRS = pRS;
			AllRowsRS.Sort = "MyType, EPAIDNumber, MyStatus, SubmissionDate";
			dgvMultiAss.Rows.Clear();
			while (!AllRowsRS.EOF)
			{
				string text = Conversions.ToDate(AllRowsRS.Fields["SubmissionDate"].Value).ToString("d");
				dgvMultiAss.Rows.Add(new object[7]
				{
					RuntimeHelpers.GetObjectValue(AllRowsRS.Fields["AssessID"].Value),
					RuntimeHelpers.GetObjectValue(AllRowsRS.Fields["MyType"].Value),
					RuntimeHelpers.GetObjectValue(AllRowsRS.Fields["FiscalYear"].Value),
					RuntimeHelpers.GetObjectValue(AllRowsRS.Fields["EPAIDNumber"].Value),
					RuntimeHelpers.GetObjectValue(AllRowsRS.Fields["MyCC"].Value),
					RuntimeHelpers.GetObjectValue(AllRowsRS.Fields["myStatus"].Value),
					text
				});
				AllRowsRS.MoveNext();
			}
			dgvMultiAss.Columns[0].Visible = false;
			recordset = null;
			command = null;
		}
		return true;
	}

	private void cmdCancel_Click(object eventSender, EventArgs eventArgs)
	{
		if (((Control)_fraSearch).Visible)
		{
			((Control)_fraAssess).Visible = true;
			((Control)_fraSearch).Visible = false;
			if (Operators.CompareString(MyOp, "D", false) == 0)
			{
				((ButtonBase)cmdOK).Text = "&Delete";
			}
			else if (Operators.CompareString(MyOp, "O", false) == 0)
			{
				((ButtonBase)cmdOK).Text = "&Open";
			}
			else
			{
				((ButtonBase)cmdOK).Text = "&Select";
			}
		}
		else
		{
			if ((Operators.CompareString(MyOp, "I", false) == 0) | (Operators.CompareString(MyOp, "V", false) == 0))
			{
				((Control)this).Tag = "Cancel";
			}
			else if (Operators.CompareString(MyOp, "O", false) == 0)
			{
				Globals_Renamed.gblAssessID = 0;
			}
			((Form)this).Close();
		}
	}

	private void cmdReset0_Click(object eventSender, EventArgs eventArgs)
	{
		cmbAssType.SelectedIndex = -1;
	}

	private void cmdReset1_Click(object eventSender, EventArgs eventArgs)
	{
		cmbAssStatus.SelectedIndex = -1;
	}

	private void cmdSearch_Click(object eventSender, EventArgs eventArgs)
	{
		((Control)_fraSearch).Top = ((Control)_fraAssess).Top;
		((Control)_fraSearch).Left = ((Control)_fraAssess).Left;
		((Control)_fraSearch).Height = ((Control)_fraAssess).Height;
		((Control)_fraSearch).Width = ((Control)_fraAssess).Width;
		((Control)_fraSearch).Visible = true;
		((Control)_fraAssess).Visible = false;
		((ButtonBase)cmdOK).Text = "&Search";
	}

	private void cmdOk_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Invalid comparison between Unknown and I4
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
					ProjectData.ClearProjectError();
					num2 = 2;
					if (((Control)_fraSearch).Visible)
					{
						string text = Conversions.ToString(BuildWhere());
						if (Operators.CompareString(text, "error", false) == 0)
						{
							Interaction.MsgBox((object)"An error occurred while performing the search. Please contact Technical Support.", (MsgBoxStyle)48, (object)"Search Error");
							goto end_IL_0001;
						}
						AllRowsRS.Filter = text;
						dgvMultiAss.Rows.Clear();
						while (!AllRowsRS.EOF)
						{
							dgvMultiAss.Rows.Add(new object[7]
							{
								RuntimeHelpers.GetObjectValue(AllRowsRS.Fields["AssessID"].Value),
								RuntimeHelpers.GetObjectValue(AllRowsRS.Fields["MyType"].Value),
								RuntimeHelpers.GetObjectValue(AllRowsRS.Fields["FiscalYear"].Value),
								RuntimeHelpers.GetObjectValue(AllRowsRS.Fields["EPAIDNumber"].Value),
								RuntimeHelpers.GetObjectValue(AllRowsRS.Fields["MyCC"].Value),
								RuntimeHelpers.GetObjectValue(AllRowsRS.Fields["myStatus"].Value),
								RuntimeHelpers.GetObjectValue(AllRowsRS.Fields["SubmissionDate"].Value)
							});
							AllRowsRS.MoveNext();
						}
						((Control)fraSearch).Visible = false;
						((Control)fraAssess).Visible = true;
						if (Operators.CompareString(MyOp, "D", false) == 0)
						{
							((ButtonBase)cmdOK).Text = "&Delete";
						}
						else
						{
							((ButtonBase)cmdOK).Text = "&Open";
						}
						goto end_IL_0001;
					}
					if ((Operators.CompareString(MyOp, "I", false) == 0) | (Operators.CompareString(MyOp, "V", false) == 0))
					{
						checked
						{
							int num3 = ((BaseCollection)dgvMultiCRSS.SelectedCells).Count - 1;
							int num4 = 0;
							while (true)
							{
								int num5 = num4;
								int num6 = num3;
								if (num5 <= num6)
								{
									frmMain.DefInstance.sCRSSid = Conversions.ToString(dgvMultiCRSS.SelectedCells[num4].Value);
									num4++;
									continue;
								}
								break;
							}
						}
					}
					else
					{
						if (Operators.CompareString(MyOp, "D", false) == 0 && (int)Interaction.MsgBox((object)"Are you sure you want to delete this assessment?", (MsgBoxStyle)36, (object)"Confirm Delete") == 7)
						{
							goto end_IL_0001;
						}
						if (Operators.CompareString(MyOp, "IOp", false) == 0)
						{
							Globals_Renamed.gblImportAssessID = Conversions.ToInteger(dgvMultiAss.CurrentRow.Cells[0].Value);
						}
						else
						{
							Globals_Renamed.gblAssessID = Conversions.ToShort(dgvMultiAss.CurrentRow.Cells[0].Value);
						}
					}
					((Form)this).Close();
					goto end_IL_0001;
				case 936:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						string Eobject = ((Control)this).Name;
						string Efunction = "cmdOK_click";
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
				try0001_dispatch = 936;
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

	private object BuildWhere()
	{
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		string text = default(string);
		string text2 = default(string);
		if (Strings.Len(txtAssID.Text) > 0)
		{
			text = "EPAIDNumber Like '%" + txtAssID.Text + "%'";
			text2 = " AND ";
		}
		if ((Strings.Len(txtFromDate.Text) > 0) | (Strings.Len(txtToDate.Text) > 0))
		{
			if (!(Information.IsDate((object)txtFromDate.Text) & Information.IsDate((object)txtToDate.Text)))
			{
				Interaction.Beep();
				Interaction.MsgBox((object)"Please enter a valid date range", (MsgBoxStyle)64, (object)"Invalid Date Range");
				return "error";
			}
			text = text + text2 + " SubmissionDate >= #" + txtFromDate.Text + "# AND SubmissionDate <= #" + txtToDate.Text + "#";
			text2 = " AND ";
		}
		if (cmbAssStatus.SelectedIndex != -1)
		{
			text = text + text2 + " AssStatusID=" + Conversions.ToString(Support.GetItemData((Control)(object)cmbAssStatus, cmbAssStatus.SelectedIndex));
			text2 = " AND ";
		}
		if (cmbAssType.SelectedIndex != -1)
		{
			text = text + text2 + " AssTypeID=" + Conversions.ToString(Support.GetItemData((Control)(object)cmbAssType, cmbAssType.SelectedIndex));
			text2 = " AND ";
		}
		if (Operators.CompareString(text, "", false) == 0)
		{
			text = " AssTypeID <> -1";
		}
		return text;
	}
}
