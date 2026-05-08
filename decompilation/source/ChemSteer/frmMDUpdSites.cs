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

internal class frmMDUpdSites : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("cmdClose")]
	private Button _cmdClose;

	[AccessedThroughProperty("cmdAdd")]
	private Button _cmdAdd;

	[AccessedThroughProperty("cmdModify")]
	private Button _cmdModify;

	[AccessedThroughProperty("cmdDelete")]
	private Button _cmdDelete;

	[AccessedThroughProperty("msfSites")]
	private AxMSFlexGrid _msfSites;

	[AccessedThroughProperty("lblInstructions")]
	private Label _lblInstructions;

	[AccessedThroughProperty("_Label4_11")]
	private Label __Label4_11;

	[AccessedThroughProperty("lblCounty")]
	private Label _lblCounty;

	[AccessedThroughProperty("lblZip")]
	private Label _lblZip;

	[AccessedThroughProperty("lblState")]
	private Label _lblState;

	[AccessedThroughProperty("lblCity")]
	private Label _lblCity;

	[AccessedThroughProperty("lblAddr")]
	private Label _lblAddr;

	[AccessedThroughProperty("lblName")]
	private Label _lblName;

	[AccessedThroughProperty("_Label4_10")]
	private Label __Label4_10;

	[AccessedThroughProperty("_Label4_9")]
	private Label __Label4_9;

	[AccessedThroughProperty("_Label4_8")]
	private Label __Label4_8;

	[AccessedThroughProperty("_Label4_7")]
	private Label __Label4_7;

	[AccessedThroughProperty("_Label4_3")]
	private Label __Label4_3;

	[AccessedThroughProperty("Line1")]
	private Label _Line1;

	[AccessedThroughProperty("_Label4_1")]
	private Label __Label4_1;

	[AccessedThroughProperty("fraView")]
	private GroupBox _fraView;

	[AccessedThroughProperty("txtCounty")]
	private TextBox _txtCounty;

	[AccessedThroughProperty("txtName")]
	private TextBox _txtName;

	[AccessedThroughProperty("txtAddr")]
	private TextBox _txtAddr;

	[AccessedThroughProperty("txtCity")]
	private TextBox _txtCity;

	[AccessedThroughProperty("txtZip")]
	private TextBox _txtZip;

	[AccessedThroughProperty("cmbState")]
	private ComboBox _cmbState;

	[AccessedThroughProperty("cmdOk")]
	private Button _cmdOk;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("_Label1_0")]
	private Label __Label1_0;

	[AccessedThroughProperty("_Label4_14")]
	private Label __Label4_14;

	[AccessedThroughProperty("_Label4_2")]
	private Label __Label4_2;

	[AccessedThroughProperty("_Label4_0")]
	private Label __Label4_0;

	[AccessedThroughProperty("_Label4_4")]
	private Label __Label4_4;

	[AccessedThroughProperty("_Label4_5")]
	private Label __Label4_5;

	[AccessedThroughProperty("_Label4_6")]
	private Label __Label4_6;

	[AccessedThroughProperty("fraUpdate")]
	private GroupBox _fraUpdate;

	[AccessedThroughProperty("Label1")]
	private LabelArray _Label1;

	[AccessedThroughProperty("Label4")]
	private LabelArray _Label4;

	private static frmMDUpdSites m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	public virtual Button cmdClose
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdClose;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdClose_Click;
			if (_cmdClose != null)
			{
				((Control)_cmdClose).Click -= eventHandler;
			}
			_cmdClose = value;
			if (_cmdClose != null)
			{
				((Control)_cmdClose).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdAdd
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdAdd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdAdd_Click;
			if (_cmdAdd != null)
			{
				((Control)_cmdAdd).Click -= eventHandler;
			}
			_cmdAdd = value;
			if (_cmdAdd != null)
			{
				((Control)_cmdAdd).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdModify
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdModify;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdModify_Click;
			if (_cmdModify != null)
			{
				((Control)_cmdModify).Click -= eventHandler;
			}
			_cmdModify = value;
			if (_cmdModify != null)
			{
				((Control)_cmdModify).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdDelete
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdDelete;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdDelete_Click;
			if (_cmdDelete != null)
			{
				((Control)_cmdDelete).Click -= eventHandler;
			}
			_cmdDelete = value;
			if (_cmdDelete != null)
			{
				((Control)_cmdDelete).Click += eventHandler;
			}
		}
	}

	public virtual AxMSFlexGrid msfSites
	{
		[DebuggerNonUserCode]
		get
		{
			return _msfSites;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = msfSites_RowColChange;
			EventHandler eventHandler2 = msfSites_ClickEvent;
			if (_msfSites != null)
			{
				_msfSites.RowColChange -= eventHandler;
				_msfSites.ClickEvent -= eventHandler2;
			}
			_msfSites = value;
			if (_msfSites != null)
			{
				_msfSites.RowColChange += eventHandler;
				_msfSites.ClickEvent += eventHandler2;
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

	public virtual Label _Label4_11
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label4_11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label4_11 = value;
		}
	}

	public virtual Label lblCounty
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblCounty;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblCounty = value;
		}
	}

	public virtual Label lblZip
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblZip;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblZip = value;
		}
	}

	public virtual Label lblState
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblState;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblState = value;
		}
	}

	public virtual Label lblCity
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblCity;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblCity = value;
		}
	}

	public virtual Label lblAddr
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblAddr;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblAddr = value;
		}
	}

	public virtual Label lblName
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblName = value;
		}
	}

	public virtual Label _Label4_10
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label4_10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label4_10 = value;
		}
	}

	public virtual Label _Label4_9
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label4_9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label4_9 = value;
		}
	}

	public virtual Label _Label4_8
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label4_8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label4_8 = value;
		}
	}

	public virtual Label _Label4_7
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label4_7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label4_7 = value;
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

	public virtual Label Line1
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

	public virtual GroupBox fraView
	{
		[DebuggerNonUserCode]
		get
		{
			return _fraView;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_fraView = value;
		}
	}

	public virtual TextBox txtCounty
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtCounty;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtCounty = value;
		}
	}

	public virtual TextBox txtName
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

	public virtual TextBox txtAddr
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

	public virtual Label _Label4_14
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label4_14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label4_14 = value;
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

	public virtual GroupBox fraUpdate
	{
		[DebuggerNonUserCode]
		get
		{
			return _fraUpdate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_fraUpdate = value;
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

	public virtual LabelArray Label4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label4 = value;
		}
	}

	public static frmMDUpdSites DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmMDUpdSites();
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

	public frmMDUpdSites()
	{
		((Form)this).Load += frmMDUpdSites_Load;
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
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected O, but got Unknown
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Expected O, but got Unknown
		//IL_0501: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Expected O, but got Unknown
		//IL_05d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05df: Expected O, but got Unknown
		//IL_06a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06af: Expected O, but got Unknown
		//IL_0776: Unknown result type (might be due to invalid IL or missing references)
		//IL_0780: Expected O, but got Unknown
		//IL_0850: Unknown result type (might be due to invalid IL or missing references)
		//IL_085a: Expected O, but got Unknown
		//IL_08bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c5: Expected O, but got Unknown
		//IL_097e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0988: Expected O, but got Unknown
		//IL_0a6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a79: Expected O, but got Unknown
		//IL_0b32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3c: Expected O, but got Unknown
		//IL_0bf5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bff: Expected O, but got Unknown
		//IL_0cb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbf: Expected O, but got Unknown
		//IL_0d78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d82: Expected O, but got Unknown
		//IL_0e3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e45: Expected O, but got Unknown
		//IL_0ef1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0efb: Expected O, but got Unknown
		//IL_0fd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fdf: Expected O, but got Unknown
		//IL_10b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c3: Expected O, but got Unknown
		//IL_119c: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a6: Expected O, but got Unknown
		//IL_127f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1289: Expected O, but got Unknown
		//IL_13cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d7: Expected O, but got Unknown
		//IL_15ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f6: Expected O, but got Unknown
		//IL_16c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d1: Expected O, but got Unknown
		//IL_1797: Unknown result type (might be due to invalid IL or missing references)
		//IL_17a1: Expected O, but got Unknown
		//IL_1864: Unknown result type (might be due to invalid IL or missing references)
		//IL_186e: Expected O, but got Unknown
		//IL_1934: Unknown result type (might be due to invalid IL or missing references)
		//IL_193e: Expected O, but got Unknown
		//IL_1a04: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a0e: Expected O, but got Unknown
		//IL_1ad1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1adb: Expected O, but got Unknown
		//IL_1b83: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b8d: Expected O, but got Unknown
		//IL_1c63: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c6d: Expected O, but got Unknown
		//IL_1d36: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d40: Expected O, but got Unknown
		//IL_1e0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e17: Expected O, but got Unknown
		//IL_1ef1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1efb: Expected O, but got Unknown
		//IL_1fd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fdb: Expected O, but got Unknown
		//IL_20b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_20be: Expected O, but got Unknown
		//IL_2197: Unknown result type (might be due to invalid IL or missing references)
		//IL_21a1: Expected O, but got Unknown
		//IL_227a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2284: Expected O, but got Unknown
		//IL_23bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_23c5: Expected O, but got Unknown
		//IL_23da: Unknown result type (might be due to invalid IL or missing references)
		//IL_23e4: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMDUpdSites));
		ToolTip1 = new ToolTip(components);
		fraView = new GroupBox();
		cmdClose = new Button();
		cmdAdd = new Button();
		cmdModify = new Button();
		cmdDelete = new Button();
		msfSites = new AxMSFlexGrid();
		lblInstructions = new Label();
		_Label4_11 = new Label();
		lblCounty = new Label();
		lblZip = new Label();
		lblState = new Label();
		lblCity = new Label();
		lblAddr = new Label();
		lblName = new Label();
		_Label4_10 = new Label();
		_Label4_9 = new Label();
		_Label4_8 = new Label();
		_Label4_7 = new Label();
		_Label4_3 = new Label();
		Line1 = new Label();
		_Label4_1 = new Label();
		fraUpdate = new GroupBox();
		txtCounty = new TextBox();
		txtName = new TextBox();
		txtAddr = new TextBox();
		txtCity = new TextBox();
		txtZip = new TextBox();
		cmbState = new ComboBox();
		cmdOk = new Button();
		cmdCancel = new Button();
		_Label1_0 = new Label();
		_Label4_14 = new Label();
		_Label4_2 = new Label();
		_Label4_0 = new Label();
		_Label4_4 = new Label();
		_Label4_5 = new Label();
		_Label4_6 = new Label();
		Label1 = new LabelArray(components);
		Label4 = new LabelArray(components);
		((Control)fraView).SuspendLayout();
		((ISupportInitialize)msfSites).BeginInit();
		((Control)fraUpdate).SuspendLayout();
		((ISupportInitialize)Label1).BeginInit();
		((ISupportInitialize)Label4).BeginInit();
		((Control)this).SuspendLayout();
		((Control)fraView).BackColor = SystemColors.Control;
		((Control)fraView).Controls.Add((Control)(object)cmdClose);
		((Control)fraView).Controls.Add((Control)(object)cmdAdd);
		((Control)fraView).Controls.Add((Control)(object)cmdModify);
		((Control)fraView).Controls.Add((Control)(object)cmdDelete);
		((Control)fraView).Controls.Add((Control)(object)msfSites);
		((Control)fraView).Controls.Add((Control)(object)lblInstructions);
		((Control)fraView).Controls.Add((Control)(object)_Label4_11);
		((Control)fraView).Controls.Add((Control)(object)lblCounty);
		((Control)fraView).Controls.Add((Control)(object)lblZip);
		((Control)fraView).Controls.Add((Control)(object)lblState);
		((Control)fraView).Controls.Add((Control)(object)lblCity);
		((Control)fraView).Controls.Add((Control)(object)lblAddr);
		((Control)fraView).Controls.Add((Control)(object)lblName);
		((Control)fraView).Controls.Add((Control)(object)_Label4_10);
		((Control)fraView).Controls.Add((Control)(object)_Label4_9);
		((Control)fraView).Controls.Add((Control)(object)_Label4_8);
		((Control)fraView).Controls.Add((Control)(object)_Label4_7);
		((Control)fraView).Controls.Add((Control)(object)_Label4_3);
		((Control)fraView).Controls.Add((Control)(object)Line1);
		((Control)fraView).Controls.Add((Control)(object)_Label4_1);
		((Control)fraView).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)fraView).ForeColor = SystemColors.ControlText;
		GroupBox obj = fraView;
		Point location = new Point(0, 0);
		((Control)obj).Location = location;
		((Control)fraView).Name = "fraView";
		((Control)fraView).RightToLeft = (RightToLeft)0;
		GroupBox obj2 = fraView;
		Size size = new Size(449, 345);
		((Control)obj2).Size = size;
		((Control)fraView).TabIndex = 12;
		fraView.TabStop = false;
		((ButtonBase)cmdClose).BackColor = SystemColors.Control;
		((Control)cmdClose).Cursor = Cursors.Default;
		((Control)cmdClose).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdClose).ForeColor = SystemColors.ControlText;
		Button obj3 = cmdClose;
		location = new Point(184, 304);
		((Control)obj3).Location = location;
		((Control)cmdClose).Name = "cmdClose";
		((Control)cmdClose).RightToLeft = (RightToLeft)0;
		Button obj4 = cmdClose;
		size = new Size(81, 25);
		((Control)obj4).Size = size;
		((Control)cmdClose).TabIndex = 11;
		((ButtonBase)cmdClose).Text = "&Close";
		((ButtonBase)cmdClose).UseVisualStyleBackColor = false;
		((ButtonBase)cmdAdd).BackColor = SystemColors.Control;
		((Control)cmdAdd).Cursor = Cursors.Default;
		((Control)cmdAdd).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdAdd).ForeColor = SystemColors.ControlText;
		Button obj5 = cmdAdd;
		location = new Point(352, 64);
		((Control)obj5).Location = location;
		((Control)cmdAdd).Name = "cmdAdd";
		((Control)cmdAdd).RightToLeft = (RightToLeft)0;
		Button obj6 = cmdAdd;
		size = new Size(81, 25);
		((Control)obj6).Size = size;
		((Control)cmdAdd).TabIndex = 8;
		((ButtonBase)cmdAdd).Text = "&Add";
		((ButtonBase)cmdAdd).UseVisualStyleBackColor = false;
		((ButtonBase)cmdModify).BackColor = SystemColors.Control;
		((Control)cmdModify).Cursor = Cursors.Default;
		((Control)cmdModify).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdModify).ForeColor = SystemColors.ControlText;
		Button obj7 = cmdModify;
		location = new Point(352, 96);
		((Control)obj7).Location = location;
		((Control)cmdModify).Name = "cmdModify";
		((Control)cmdModify).RightToLeft = (RightToLeft)0;
		Button obj8 = cmdModify;
		size = new Size(81, 25);
		((Control)obj8).Size = size;
		((Control)cmdModify).TabIndex = 9;
		((ButtonBase)cmdModify).Text = "&Modify";
		((ButtonBase)cmdModify).UseVisualStyleBackColor = false;
		((ButtonBase)cmdDelete).BackColor = SystemColors.Control;
		((Control)cmdDelete).Cursor = Cursors.Default;
		((Control)cmdDelete).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdDelete).ForeColor = SystemColors.ControlText;
		Button obj9 = cmdDelete;
		location = new Point(352, 128);
		((Control)obj9).Location = location;
		((Control)cmdDelete).Name = "cmdDelete";
		((Control)cmdDelete).RightToLeft = (RightToLeft)0;
		Button obj10 = cmdDelete;
		size = new Size(81, 25);
		((Control)obj10).Size = size;
		((Control)cmdDelete).TabIndex = 10;
		((ButtonBase)cmdDelete).Text = "&Delete";
		((ButtonBase)cmdDelete).UseVisualStyleBackColor = false;
		AxMSFlexGrid obj11 = msfSites;
		location = new Point(16, 72);
		((Control)obj11).Location = location;
		((Control)msfSites).Name = "msfSites";
		((AxHost)msfSites).OcxState = (State)componentResourceManager.GetObject("msfSites.OcxState");
		AxMSFlexGrid obj12 = msfSites;
		size = new Size(329, 73);
		((Control)obj12).Size = size;
		((Control)msfSites).TabIndex = 35;
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
		size = new Size(433, 33);
		((Control)obj14).Size = size;
		((Control)lblInstructions).TabIndex = 34;
		lblInstructions.Text = "xxx";
		((Control)_Label4_11).BackColor = SystemColors.Control;
		((Control)_Label4_11).Cursor = Cursors.Default;
		((Control)_Label4_11).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_11).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_11, (short)11);
		Label label4_ = _Label4_11;
		location = new Point(8, 272);
		((Control)label4_).Location = location;
		((Control)_Label4_11).Name = "_Label4_11";
		((Control)_Label4_11).RightToLeft = (RightToLeft)0;
		Label label4_2 = _Label4_11;
		size = new Size(65, 17);
		((Control)label4_2).Size = size;
		((Control)_Label4_11).TabIndex = 31;
		_Label4_11.Text = "County: ";
		_Label4_11.TextAlign = (ContentAlignment)4;
		((Control)lblCounty).BackColor = SystemColors.Control;
		lblCounty.BorderStyle = (BorderStyle)2;
		((Control)lblCounty).Cursor = Cursors.Default;
		((Control)lblCounty).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblCounty).ForeColor = SystemColors.ControlText;
		Label obj15 = lblCounty;
		location = new Point(72, 272);
		((Control)obj15).Location = location;
		((Control)lblCounty).Name = "lblCounty";
		((Control)lblCounty).RightToLeft = (RightToLeft)0;
		Label obj16 = lblCounty;
		size = new Size(369, 17);
		((Control)obj16).Size = size;
		((Control)lblCounty).TabIndex = 30;
		((Control)lblZip).BackColor = SystemColors.Control;
		lblZip.BorderStyle = (BorderStyle)2;
		((Control)lblZip).Cursor = Cursors.Default;
		((Control)lblZip).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblZip).ForeColor = SystemColors.ControlText;
		Label obj17 = lblZip;
		location = new Point(208, 248);
		((Control)obj17).Location = location;
		((Control)lblZip).Name = "lblZip";
		((Control)lblZip).RightToLeft = (RightToLeft)0;
		Label obj18 = lblZip;
		size = new Size(97, 17);
		((Control)obj18).Size = size;
		((Control)lblZip).TabIndex = 29;
		((Control)lblState).BackColor = SystemColors.Control;
		lblState.BorderStyle = (BorderStyle)2;
		((Control)lblState).Cursor = Cursors.Default;
		((Control)lblState).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblState).ForeColor = SystemColors.ControlText;
		Label obj19 = lblState;
		location = new Point(72, 248);
		((Control)obj19).Location = location;
		((Control)lblState).Name = "lblState";
		((Control)lblState).RightToLeft = (RightToLeft)0;
		Label obj20 = lblState;
		size = new Size(41, 17);
		((Control)obj20).Size = size;
		((Control)lblState).TabIndex = 28;
		((Control)lblCity).BackColor = SystemColors.Control;
		lblCity.BorderStyle = (BorderStyle)2;
		((Control)lblCity).Cursor = Cursors.Default;
		((Control)lblCity).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblCity).ForeColor = SystemColors.ControlText;
		Label obj21 = lblCity;
		location = new Point(72, 224);
		((Control)obj21).Location = location;
		((Control)lblCity).Name = "lblCity";
		((Control)lblCity).RightToLeft = (RightToLeft)0;
		Label obj22 = lblCity;
		size = new Size(369, 17);
		((Control)obj22).Size = size;
		((Control)lblCity).TabIndex = 27;
		((Control)lblAddr).BackColor = SystemColors.Control;
		lblAddr.BorderStyle = (BorderStyle)2;
		((Control)lblAddr).Cursor = Cursors.Default;
		((Control)lblAddr).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblAddr).ForeColor = SystemColors.ControlText;
		Label obj23 = lblAddr;
		location = new Point(72, 200);
		((Control)obj23).Location = location;
		((Control)lblAddr).Name = "lblAddr";
		((Control)lblAddr).RightToLeft = (RightToLeft)0;
		Label obj24 = lblAddr;
		size = new Size(369, 17);
		((Control)obj24).Size = size;
		((Control)lblAddr).TabIndex = 26;
		((Control)lblName).BackColor = SystemColors.Control;
		lblName.BorderStyle = (BorderStyle)2;
		((Control)lblName).Cursor = Cursors.Default;
		((Control)lblName).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblName).ForeColor = SystemColors.ControlText;
		Label obj25 = lblName;
		location = new Point(72, 176);
		((Control)obj25).Location = location;
		((Control)lblName).Name = "lblName";
		((Control)lblName).RightToLeft = (RightToLeft)0;
		Label obj26 = lblName;
		size = new Size(369, 17);
		((Control)obj26).Size = size;
		((Control)lblName).TabIndex = 25;
		((Control)_Label4_10).BackColor = SystemColors.Control;
		((Control)_Label4_10).Cursor = Cursors.Default;
		((Control)_Label4_10).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_10).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_10, (short)10);
		Label label4_3 = _Label4_10;
		location = new Point(8, 176);
		((Control)label4_3).Location = location;
		((Control)_Label4_10).Name = "_Label4_10";
		((Control)_Label4_10).RightToLeft = (RightToLeft)0;
		Label label4_4 = _Label4_10;
		size = new Size(65, 17);
		((Control)label4_4).Size = size;
		((Control)_Label4_10).TabIndex = 24;
		_Label4_10.Text = "Facility: ";
		_Label4_10.TextAlign = (ContentAlignment)4;
		((Control)_Label4_9).BackColor = SystemColors.Control;
		((Control)_Label4_9).Cursor = Cursors.Default;
		((Control)_Label4_9).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_9).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_9, (short)9);
		Label label4_5 = _Label4_9;
		location = new Point(8, 200);
		((Control)label4_5).Location = location;
		((Control)_Label4_9).Name = "_Label4_9";
		((Control)_Label4_9).RightToLeft = (RightToLeft)0;
		Label label4_6 = _Label4_9;
		size = new Size(65, 17);
		((Control)label4_6).Size = size;
		((Control)_Label4_9).TabIndex = 23;
		_Label4_9.Text = "Address: ";
		_Label4_9.TextAlign = (ContentAlignment)4;
		((Control)_Label4_8).BackColor = SystemColors.Control;
		((Control)_Label4_8).Cursor = Cursors.Default;
		((Control)_Label4_8).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_8).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_8, (short)8);
		Label label4_7 = _Label4_8;
		location = new Point(8, 224);
		((Control)label4_7).Location = location;
		((Control)_Label4_8).Name = "_Label4_8";
		((Control)_Label4_8).RightToLeft = (RightToLeft)0;
		Label label4_8 = _Label4_8;
		size = new Size(65, 17);
		((Control)label4_8).Size = size;
		((Control)_Label4_8).TabIndex = 22;
		_Label4_8.Text = "City: ";
		_Label4_8.TextAlign = (ContentAlignment)4;
		((Control)_Label4_7).BackColor = SystemColors.Control;
		((Control)_Label4_7).Cursor = Cursors.Default;
		((Control)_Label4_7).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_7).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_7, (short)7);
		Label label4_9 = _Label4_7;
		location = new Point(8, 248);
		((Control)label4_9).Location = location;
		((Control)_Label4_7).Name = "_Label4_7";
		((Control)_Label4_7).RightToLeft = (RightToLeft)0;
		Label label4_10 = _Label4_7;
		size = new Size(65, 17);
		((Control)label4_10).Size = size;
		((Control)_Label4_7).TabIndex = 21;
		_Label4_7.Text = "State: ";
		_Label4_7.TextAlign = (ContentAlignment)4;
		((Control)_Label4_3).BackColor = SystemColors.Control;
		((Control)_Label4_3).Cursor = Cursors.Default;
		((Control)_Label4_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_3).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_3, (short)3);
		Label label4_11 = _Label4_3;
		location = new Point(144, 248);
		((Control)label4_11).Location = location;
		((Control)_Label4_3).Name = "_Label4_3";
		((Control)_Label4_3).RightToLeft = (RightToLeft)0;
		Label label4_12 = _Label4_3;
		size = new Size(65, 17);
		((Control)label4_12).Size = size;
		((Control)_Label4_3).TabIndex = 20;
		_Label4_3.Text = "Zip: ";
		_Label4_3.TextAlign = (ContentAlignment)4;
		((Control)Line1).BackColor = SystemColors.WindowText;
		Label line = Line1;
		location = new Point(8, 160);
		((Control)line).Location = location;
		((Control)Line1).Name = "Line1";
		Label line2 = Line1;
		size = new Size(432, 1);
		((Control)line2).Size = size;
		((Control)Line1).TabIndex = 36;
		((Control)_Label4_1).BackColor = SystemColors.Control;
		((Control)_Label4_1).Cursor = Cursors.Default;
		((Control)_Label4_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_1).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_1, (short)1);
		Label label4_13 = _Label4_1;
		location = new Point(16, 56);
		((Control)label4_13).Location = location;
		((Control)_Label4_1).Name = "_Label4_1";
		((Control)_Label4_1).RightToLeft = (RightToLeft)0;
		Label label4_14 = _Label4_1;
		size = new Size(145, 17);
		((Control)label4_14).Size = size;
		((Control)_Label4_1).TabIndex = 13;
		_Label4_1.Text = "Facilities";
		((Control)fraUpdate).BackColor = SystemColors.Control;
		((Control)fraUpdate).Controls.Add((Control)(object)txtCounty);
		((Control)fraUpdate).Controls.Add((Control)(object)txtName);
		((Control)fraUpdate).Controls.Add((Control)(object)txtAddr);
		((Control)fraUpdate).Controls.Add((Control)(object)txtCity);
		((Control)fraUpdate).Controls.Add((Control)(object)txtZip);
		((Control)fraUpdate).Controls.Add((Control)(object)cmbState);
		((Control)fraUpdate).Controls.Add((Control)(object)cmdOk);
		((Control)fraUpdate).Controls.Add((Control)(object)cmdCancel);
		((Control)fraUpdate).Controls.Add((Control)(object)_Label1_0);
		((Control)fraUpdate).Controls.Add((Control)(object)_Label4_14);
		((Control)fraUpdate).Controls.Add((Control)(object)_Label4_2);
		((Control)fraUpdate).Controls.Add((Control)(object)_Label4_0);
		((Control)fraUpdate).Controls.Add((Control)(object)_Label4_4);
		((Control)fraUpdate).Controls.Add((Control)(object)_Label4_5);
		((Control)fraUpdate).Controls.Add((Control)(object)_Label4_6);
		((Control)fraUpdate).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)fraUpdate).ForeColor = SystemColors.ControlText;
		GroupBox obj27 = fraUpdate;
		location = new Point(0, 0);
		((Control)obj27).Location = location;
		((Control)fraUpdate).Name = "fraUpdate";
		((Control)fraUpdate).RightToLeft = (RightToLeft)0;
		GroupBox obj28 = fraUpdate;
		size = new Size(449, 345);
		((Control)obj28).Size = size;
		((Control)fraUpdate).TabIndex = 14;
		fraUpdate.TabStop = false;
		((Control)fraUpdate).Visible = false;
		txtCounty.AcceptsReturn = true;
		((TextBoxBase)txtCounty).BackColor = SystemColors.Window;
		((Control)txtCounty).Cursor = Cursors.IBeam;
		((Control)txtCounty).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtCounty).ForeColor = SystemColors.WindowText;
		TextBox obj29 = txtCounty;
		location = new Point(72, 224);
		((Control)obj29).Location = location;
		((TextBoxBase)txtCounty).MaxLength = 100;
		((Control)txtCounty).Name = "txtCounty";
		((Control)txtCounty).RightToLeft = (RightToLeft)0;
		TextBox obj30 = txtCounty;
		size = new Size(369, 20);
		((Control)obj30).Size = size;
		((Control)txtCounty).TabIndex = 5;
		txtName.AcceptsReturn = true;
		((TextBoxBase)txtName).BackColor = SystemColors.Window;
		((Control)txtName).Cursor = Cursors.IBeam;
		((Control)txtName).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtName).ForeColor = SystemColors.WindowText;
		TextBox obj31 = txtName;
		location = new Point(72, 104);
		((Control)obj31).Location = location;
		((TextBoxBase)txtName).MaxLength = 100;
		((Control)txtName).Name = "txtName";
		((Control)txtName).RightToLeft = (RightToLeft)0;
		TextBox obj32 = txtName;
		size = new Size(369, 20);
		((Control)obj32).Size = size;
		((Control)txtName).TabIndex = 0;
		txtAddr.AcceptsReturn = true;
		((TextBoxBase)txtAddr).BackColor = SystemColors.Window;
		((Control)txtAddr).Cursor = Cursors.IBeam;
		((Control)txtAddr).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtAddr).ForeColor = SystemColors.WindowText;
		TextBox obj33 = txtAddr;
		location = new Point(72, 128);
		((Control)obj33).Location = location;
		((TextBoxBase)txtAddr).MaxLength = 100;
		((Control)txtAddr).Name = "txtAddr";
		((Control)txtAddr).RightToLeft = (RightToLeft)0;
		TextBox obj34 = txtAddr;
		size = new Size(369, 20);
		((Control)obj34).Size = size;
		((Control)txtAddr).TabIndex = 1;
		txtCity.AcceptsReturn = true;
		((TextBoxBase)txtCity).BackColor = SystemColors.Window;
		((Control)txtCity).Cursor = Cursors.IBeam;
		((Control)txtCity).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtCity).ForeColor = SystemColors.WindowText;
		TextBox obj35 = txtCity;
		location = new Point(72, 152);
		((Control)obj35).Location = location;
		((TextBoxBase)txtCity).MaxLength = 100;
		((Control)txtCity).Name = "txtCity";
		((Control)txtCity).RightToLeft = (RightToLeft)0;
		TextBox obj36 = txtCity;
		size = new Size(369, 20);
		((Control)obj36).Size = size;
		((Control)txtCity).TabIndex = 2;
		txtZip.AcceptsReturn = true;
		((TextBoxBase)txtZip).BackColor = SystemColors.Window;
		((Control)txtZip).Cursor = Cursors.IBeam;
		((Control)txtZip).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtZip).ForeColor = SystemColors.WindowText;
		TextBox obj37 = txtZip;
		location = new Point(72, 200);
		((Control)obj37).Location = location;
		((TextBoxBase)txtZip).MaxLength = 10;
		((Control)txtZip).Name = "txtZip";
		((Control)txtZip).RightToLeft = (RightToLeft)0;
		TextBox obj38 = txtZip;
		size = new Size(105, 20);
		((Control)obj38).Size = size;
		((Control)txtZip).TabIndex = 4;
		cmbState.BackColor = SystemColors.Window;
		((Control)cmbState).Cursor = Cursors.Default;
		cmbState.DropDownStyle = (ComboBoxStyle)2;
		((Control)cmbState).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		cmbState.ForeColor = SystemColors.WindowText;
		ComboBox obj39 = cmbState;
		location = new Point(72, 176);
		((Control)obj39).Location = location;
		((Control)cmbState).Name = "cmbState";
		((Control)cmbState).RightToLeft = (RightToLeft)0;
		ComboBox obj40 = cmbState;
		size = new Size(57, 22);
		((Control)obj40).Size = size;
		((Control)cmbState).TabIndex = 3;
		((ButtonBase)cmdOk).BackColor = SystemColors.Control;
		((Control)cmdOk).Cursor = Cursors.Default;
		((Control)cmdOk).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdOk).ForeColor = SystemColors.ControlText;
		Button obj41 = cmdOk;
		location = new Point(136, 272);
		((Control)obj41).Location = location;
		((Control)cmdOk).Name = "cmdOk";
		((Control)cmdOk).RightToLeft = (RightToLeft)0;
		Button obj42 = cmdOk;
		size = new Size(81, 25);
		((Control)obj42).Size = size;
		((Control)cmdOk).TabIndex = 6;
		((ButtonBase)cmdOk).Text = "OK";
		((ButtonBase)cmdOk).UseVisualStyleBackColor = false;
		((ButtonBase)cmdCancel).BackColor = SystemColors.Control;
		((Control)cmdCancel).Cursor = Cursors.Default;
		cmdCancel.DialogResult = (DialogResult)2;
		((Control)cmdCancel).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCancel).ForeColor = SystemColors.ControlText;
		Button obj43 = cmdCancel;
		location = new Point(232, 272);
		((Control)obj43).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		((Control)cmdCancel).RightToLeft = (RightToLeft)0;
		Button obj44 = cmdCancel;
		size = new Size(81, 25);
		((Control)obj44).Size = size;
		((Control)cmdCancel).TabIndex = 7;
		((ButtonBase)cmdCancel).Text = "Cancel";
		((ButtonBase)cmdCancel).UseVisualStyleBackColor = false;
		((Control)_Label1_0).BackColor = SystemColors.Control;
		((Control)_Label1_0).Cursor = Cursors.Default;
		((Control)_Label1_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_0).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_0, (short)0);
		Label label1_ = _Label1_0;
		location = new Point(16, 32);
		((Control)label1_).Location = location;
		((Control)_Label1_0).Name = "_Label1_0";
		((Control)_Label1_0).RightToLeft = (RightToLeft)0;
		Label label1_2 = _Label1_0;
		size = new Size(425, 33);
		((Control)label1_2).Size = size;
		((Control)_Label1_0).TabIndex = 33;
		_Label1_0.Text = "Add or modify the site information below, then press OK to save this information to the database.";
		((Control)_Label4_14).BackColor = SystemColors.Control;
		((Control)_Label4_14).Cursor = Cursors.Default;
		((Control)_Label4_14).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_14).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_14, (short)14);
		Label label4_15 = _Label4_14;
		location = new Point(8, 224);
		((Control)label4_15).Location = location;
		((Control)_Label4_14).Name = "_Label4_14";
		((Control)_Label4_14).RightToLeft = (RightToLeft)0;
		Label label4_16 = _Label4_14;
		size = new Size(65, 17);
		((Control)label4_16).Size = size;
		((Control)_Label4_14).TabIndex = 32;
		_Label4_14.Text = "County: ";
		_Label4_14.TextAlign = (ContentAlignment)4;
		((Control)_Label4_2).BackColor = SystemColors.Control;
		((Control)_Label4_2).Cursor = Cursors.Default;
		((Control)_Label4_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_2).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_2, (short)2);
		Label label4_17 = _Label4_2;
		location = new Point(8, 104);
		((Control)label4_17).Location = location;
		((Control)_Label4_2).Name = "_Label4_2";
		((Control)_Label4_2).RightToLeft = (RightToLeft)0;
		Label label4_18 = _Label4_2;
		size = new Size(65, 17);
		((Control)label4_18).Size = size;
		((Control)_Label4_2).TabIndex = 19;
		_Label4_2.Text = "Facility: ";
		_Label4_2.TextAlign = (ContentAlignment)4;
		((Control)_Label4_0).BackColor = SystemColors.Control;
		((Control)_Label4_0).Cursor = Cursors.Default;
		((Control)_Label4_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_0).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_0, (short)0);
		Label label4_19 = _Label4_0;
		location = new Point(8, 128);
		((Control)label4_19).Location = location;
		((Control)_Label4_0).Name = "_Label4_0";
		((Control)_Label4_0).RightToLeft = (RightToLeft)0;
		Label label4_20 = _Label4_0;
		size = new Size(65, 17);
		((Control)label4_20).Size = size;
		((Control)_Label4_0).TabIndex = 18;
		_Label4_0.Text = "Address: ";
		_Label4_0.TextAlign = (ContentAlignment)4;
		((Control)_Label4_4).BackColor = SystemColors.Control;
		((Control)_Label4_4).Cursor = Cursors.Default;
		((Control)_Label4_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_4).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_4, (short)4);
		Label label4_21 = _Label4_4;
		location = new Point(8, 152);
		((Control)label4_21).Location = location;
		((Control)_Label4_4).Name = "_Label4_4";
		((Control)_Label4_4).RightToLeft = (RightToLeft)0;
		Label label4_22 = _Label4_4;
		size = new Size(65, 17);
		((Control)label4_22).Size = size;
		((Control)_Label4_4).TabIndex = 17;
		_Label4_4.Text = "City: ";
		_Label4_4.TextAlign = (ContentAlignment)4;
		((Control)_Label4_5).BackColor = SystemColors.Control;
		((Control)_Label4_5).Cursor = Cursors.Default;
		((Control)_Label4_5).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_5).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_5, (short)5);
		Label label4_23 = _Label4_5;
		location = new Point(8, 176);
		((Control)label4_23).Location = location;
		((Control)_Label4_5).Name = "_Label4_5";
		((Control)_Label4_5).RightToLeft = (RightToLeft)0;
		Label label4_24 = _Label4_5;
		size = new Size(65, 17);
		((Control)label4_24).Size = size;
		((Control)_Label4_5).TabIndex = 16;
		_Label4_5.Text = "State: ";
		_Label4_5.TextAlign = (ContentAlignment)4;
		((Control)_Label4_6).BackColor = SystemColors.Control;
		((Control)_Label4_6).Cursor = Cursors.Default;
		((Control)_Label4_6).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_6).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_6, (short)6);
		Label label4_25 = _Label4_6;
		location = new Point(8, 200);
		((Control)label4_25).Location = location;
		((Control)_Label4_6).Name = "_Label4_6";
		((Control)_Label4_6).RightToLeft = (RightToLeft)0;
		Label label4_26 = _Label4_6;
		size = new Size(65, 17);
		((Control)label4_26).Size = size;
		((Control)_Label4_6).TabIndex = 15;
		_Label4_6.Text = "Zip: ";
		_Label4_6.TextAlign = (ContentAlignment)4;
		((Form)this).AcceptButton = (IButtonControl)(object)cmdOk;
		size = new Size(5, 13);
		((Form)this).AutoScaleBaseSize = size;
		((Form)this).BackColor = SystemColors.Control;
		((Form)this).CancelButton = (IButtonControl)(object)cmdCancel;
		size = new Size(449, 344);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)fraUpdate);
		((Control)this).Controls.Add((Control)(object)fraView);
		((Control)this).Cursor = Cursors.Default;
		((Control)this).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		location = new Point(250, 150);
		((Form)this).Location = location;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmMDUpdSites";
		((Control)this).RightToLeft = (RightToLeft)0;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Update the operation's site information";
		((Control)fraView).ResumeLayout(false);
		((ISupportInitialize)msfSites).EndInit();
		((Control)fraUpdate).ResumeLayout(false);
		((Control)fraUpdate).PerformLayout();
		((ISupportInitialize)Label1).EndInit();
		((ISupportInitialize)Label4).EndInit();
		((Control)this).ResumeLayout(false);
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
						command.ActiveConnection = Common.MyConn;
						command.CommandText = "pqryGetInstructions";
						command.CommandType = CommandTypeEnum.adCmdStoredProc;
						command.Parameters.Append(command.CreateParameter("pID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, 26));
						Command command2 = command;
						object RecordsAffected = Missing.Value;
						object Parameters = Missing.Value;
						recordset = command2.Execute(out RecordsAffected, ref Parameters);
						command.Parameters.Delete("pID");
						lblInstructions.Text = Conversions.ToString(recordset.Fields[0].Value);
						recordset.Close();
						msfSites.Rows = frmMain.DefInstance.msfSites.Rows - 1;
						object obj = new object[6] { 4500, 0, 0, 0, 0, 0 };
						short num3 = (short)(frmMain.DefInstance.msfSites.Cols - 1);
						short num4 = 0;
						while (true)
						{
							short num5 = num4;
							short num6 = num3;
							if (num5 > num6)
							{
								break;
							}
							msfSites[unchecked((int)num4)] = Conversions.ToInteger(NewLateBinding.LateIndexGet(obj, new object[1] { num4 }, (string[])null));
							short num7 = (short)(frmMain.DefInstance.msfSites.Rows - 1);
							short num8 = 1;
							while (true)
							{
								short num9 = num8;
								num6 = num7;
								if (num9 > num6)
								{
									break;
								}
								msfSites[num8 - 1, unchecked((int)num4)] = unchecked(frmMain.DefInstance.msfSites[(int)num8, (int)num4]);
								num8 = (short)unchecked(num8 + 1);
							}
							num4 = (short)unchecked(num4 + 1);
						}
						if (msfSites.Rows > 0)
						{
							msfSites.Row = 0;
							PrimeLabels();
						}
						recordset = null;
						command = null;
						flag = true;
						goto end_IL_0001;
					}
					case 664:
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
			catch (object obj2) when (obj2 is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0001_dispatch = 664;
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

	private void cmdAdd_Click(object eventSender, EventArgs eventArgs)
	{
		((Form)this).Text = "Add facility to operation";
		txtName.Text = "unknown site(s)";
		txtAddr.Text = "";
		txtCity.Text = "";
		cmbState.SelectedIndex = -1;
		txtZip.Text = "";
		txtCounty.Text = "";
		((Form)this).AcceptButton = (IButtonControl)(object)cmdOk;
		((Control)fraView).Visible = false;
		((Control)fraUpdate).Visible = true;
	}

	private void cmdCancel_Click(object eventSender, EventArgs eventArgs)
	{
		((Form)this).Text = "Update the operation's site information";
		((Form)this).AcceptButton = (IButtonControl)(object)cmdClose;
		((Control)fraUpdate).Visible = false;
		((Control)fraView).Visible = true;
	}

	private void cmdClose_Click(object eventSender, EventArgs eventArgs)
	{
		checked
		{
			frmMain.DefInstance.msfSites.Rows = msfSites.Rows + 1;
			short num = (short)(msfSites.Rows - 1);
			short num2 = 0;
			while (true)
			{
				short num3 = num2;
				short num4 = num;
				if (num3 > num4)
				{
					break;
				}
				short num5 = (short)(msfSites.Cols - 1);
				short num6 = 0;
				while (true)
				{
					short num7 = num6;
					num4 = num5;
					if (num7 > num4)
					{
						break;
					}
					frmMain.DefInstance.msfSites[num2 + 1, unchecked((int)num6)] = unchecked(msfSites[(int)num2, (int)num6]);
					num6 = (short)unchecked(num6 + 1);
				}
				unchecked
				{
					Globals_Renamed.arOSName[num2, Globals_Renamed.intOpIndex] = msfSites[(int)num2, 0];
					Globals_Renamed.arOSAddr[num2, Globals_Renamed.intOpIndex] = msfSites[(int)num2, 1];
					Globals_Renamed.arOSCity[num2, Globals_Renamed.intOpIndex] = msfSites[(int)num2, 2];
					Globals_Renamed.arOSState[num2, Globals_Renamed.intOpIndex] = msfSites[(int)num2, 3];
					Globals_Renamed.arOSZip[num2, Globals_Renamed.intOpIndex] = msfSites[(int)num2, 4];
					Globals_Renamed.arOSCty[num2, Globals_Renamed.intOpIndex] = msfSites[(int)num2, 5];
				}
				num2 = (short)unchecked(num2 + 1);
			}
			num2 = (short)msfSites.Rows;
			while (true)
			{
				short num8 = num2;
				short num4 = 99;
				if (num8 > num4)
				{
					break;
				}
				Globals_Renamed.arOSName[num2, Globals_Renamed.intOpIndex] = "";
				Globals_Renamed.arOSAddr[num2, Globals_Renamed.intOpIndex] = "";
				Globals_Renamed.arOSCity[num2, Globals_Renamed.intOpIndex] = "";
				Globals_Renamed.arOSState[num2, Globals_Renamed.intOpIndex] = "";
				Globals_Renamed.arOSZip[num2, Globals_Renamed.intOpIndex] = "";
				Globals_Renamed.arOSCty[num2, Globals_Renamed.intOpIndex] = "";
				num2 = (short)unchecked(num2 + 1);
			}
			((Form)this).Close();
		}
	}

	private void cmdDelete_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Invalid comparison between Unknown and I4
		if (msfSites.Rows <= 0 || (int)Interaction.MsgBox((object)("Are you sure you want to delete the " + msfSites[msfSites.Row, 0] + " facility?"), (MsgBoxStyle)36, (object)"Confirm Delete") != 6)
		{
			return;
		}
		checked
		{
			if (msfSites.Rows == 1)
			{
				short num = (short)(msfSites.Cols - 1);
				short num2 = 0;
				while (true)
				{
					short num3 = num2;
					short num4 = num;
					if (num3 <= num4)
					{
						msfSites[0, unchecked((int)num2)] = "";
						num2 = (short)unchecked(num2 + 1);
						continue;
					}
					break;
				}
			}
			else
			{
				msfSites.RemoveItem(msfSites.Row);
			}
			PrimeLabels();
			Globals_Renamed.gblIWasChanged = true;
		}
	}

	private void cmdModify_Click(object eventSender, EventArgs eventArgs)
	{
		txtName.Text = lblName.Text;
		txtAddr.Text = lblAddr.Text;
		txtCity.Text = lblCity.Text;
		cmbState.SelectedIndex = -1;
		checked
		{
			short num = (short)(cmbState.Items.Count - 1);
			short num2 = 0;
			while (true)
			{
				short num3 = num2;
				short num4 = num;
				if (num3 > num4)
				{
					break;
				}
				if (Operators.CompareString(Support.GetItemString((Control)(object)cmbState, unchecked((int)num2)), lblState.Text, false) == 0)
				{
					cmbState.SelectedIndex = num2;
					break;
				}
				num2 = (short)unchecked(num2 + 1);
			}
			txtZip.Text = lblZip.Text;
			txtCounty.Text = lblCounty.Text;
			((Form)this).Text = "Modify facility information";
			((Form)this).AcceptButton = (IButtonControl)(object)cmdOk;
			((Control)fraView).Visible = false;
			((Control)fraUpdate).Visible = true;
		}
	}

	private void cmdOk_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		if (Strings.Len(txtName.Text) == 0)
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Please enter a facility name.  A facility name is required.", (MsgBoxStyle)64, (object)"Missing required information");
			((Control)txtName).Focus();
			return;
		}
		lblName.Text = txtName.Text;
		lblAddr.Text = txtAddr.Text;
		lblCity.Text = txtCity.Text;
		lblState.Text = cmbState.Text;
		lblZip.Text = txtZip.Text;
		lblCounty.Text = txtCounty.Text;
		if (Operators.CompareString(Strings.Left(((Form)this).Text, 3), "Add", false) == 0)
		{
			if (msfSites.Rows == 1)
			{
				if (Operators.CompareString(msfSites[0, 0], "", false) == 0)
				{
					msfSites[msfSites.Row, 0] = lblName.Text;
					msfSites[msfSites.Row, 1] = lblAddr.Text;
					msfSites[msfSites.Row, 2] = lblCity.Text;
					msfSites[msfSites.Row, 3] = lblState.Text;
					msfSites[msfSites.Row, 4] = lblZip.Text;
					msfSites[msfSites.Row, 5] = lblCounty.Text;
				}
				else
				{
					msfSites.AddItem(lblName.Text + "\t" + lblAddr.Text + "\t" + lblCity.Text + "\t" + lblState.Text + "\t" + lblZip.Text + "\t" + lblCounty.Text);
				}
			}
			else
			{
				msfSites.AddItem(lblName.Text + "\t" + lblAddr.Text + "\t" + lblCity.Text + "\t" + lblState.Text + "\t" + lblZip.Text + "\t" + lblCounty.Text);
			}
		}
		else
		{
			msfSites[msfSites.Row, 0] = lblName.Text;
			msfSites[msfSites.Row, 1] = lblAddr.Text;
			msfSites[msfSites.Row, 2] = lblCity.Text;
			msfSites[msfSites.Row, 3] = lblState.Text;
			msfSites[msfSites.Row, 4] = lblZip.Text;
			msfSites[msfSites.Row, 5] = lblCounty.Text;
		}
		((Form)this).Text = "Update the operation's site information";
		((Form)this).AcceptButton = (IButtonControl)(object)cmdClose;
		((Control)fraUpdate).Visible = false;
		((Control)fraView).Visible = true;
		Globals_Renamed.gblIWasChanged = true;
	}

	private void frmMDUpdSites_Load(object eventSender, EventArgs eventArgs)
	{
		ComboBox pCombo = cmbState;
		Common.LoadStateCombo(ref pCombo);
		cmbState = pCombo;
	}

	private void msfSites_ClickEvent(object eventSender, EventArgs eventArgs)
	{
		PrimeLabels();
	}

	private void msfSites_RowColChange(object eventSender, EventArgs eventArgs)
	{
		PrimeLabels();
	}

	private void PrimeLabels()
	{
		lblName.Text = msfSites[msfSites.Row, 0];
		lblAddr.Text = msfSites[msfSites.Row, 1];
		lblCity.Text = msfSites[msfSites.Row, 2];
		lblState.Text = msfSites[msfSites.Row, 3];
		lblZip.Text = msfSites[msfSites.Row, 4];
		lblCounty.Text = msfSites[msfSites.Row, 5];
	}
}
