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

internal class frmMDUpdContRpts : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("_cmdAdd_1")]
	private Button __cmdAdd_1;

	[AccessedThroughProperty("txtViewAA")]
	private TextBox _txtViewAA;

	[AccessedThroughProperty("txtViewNotes")]
	private TextBox _txtViewNotes;

	[AccessedThroughProperty("msfContacts")]
	private AxMSFlexGrid _msfContacts;

	[AccessedThroughProperty("cmdDelete")]
	private Button _cmdDelete;

	[AccessedThroughProperty("cmdModify")]
	private Button _cmdModify;

	[AccessedThroughProperty("_cmdAdd_0")]
	private Button __cmdAdd_0;

	[AccessedThroughProperty("cmdClose")]
	private Button _cmdClose;

	[AccessedThroughProperty("_Label4_10")]
	private Label __Label4_10;

	[AccessedThroughProperty("_Label4_9")]
	private Label __Label4_9;

	[AccessedThroughProperty("_lblInstructions_0")]
	private Label __lblInstructions_0;

	[AccessedThroughProperty("fraView")]
	private GroupBox _fraView;

	[AccessedThroughProperty("txtAA")]
	private TextBox _txtAA;

	[AccessedThroughProperty("chkCBI")]
	private CheckBox _chkCBI;

	[AccessedThroughProperty("txtNotes")]
	private TextBox _txtNotes;

	[AccessedThroughProperty("_txtAff_1")]
	private TextBox __txtAff_1;

	[AccessedThroughProperty("_txtAff_0")]
	private TextBox __txtAff_0;

	[AccessedThroughProperty("txtCallBy")]
	private TextBox _txtCallBy;

	[AccessedThroughProperty("txtPhone")]
	private TextBox _txtPhone;

	[AccessedThroughProperty("txtCallTo")]
	private TextBox _txtCallTo;

	[AccessedThroughProperty("txtTime")]
	private TextBox _txtTime;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("txtDate")]
	private TextBox _txtDate;

	[AccessedThroughProperty("cmdOk")]
	private Button _cmdOk;

	[AccessedThroughProperty("_Label4_8")]
	private Label __Label4_8;

	[AccessedThroughProperty("_lblInstructions_1")]
	private Label __lblInstructions_1;

	[AccessedThroughProperty("_Label4_7")]
	private Label __Label4_7;

	[AccessedThroughProperty("_Label4_6")]
	private Label __Label4_6;

	[AccessedThroughProperty("_Label4_5")]
	private Label __Label4_5;

	[AccessedThroughProperty("_Label4_4")]
	private Label __Label4_4;

	[AccessedThroughProperty("_Label4_1")]
	private Label __Label4_1;

	[AccessedThroughProperty("_Label4_0")]
	private Label __Label4_0;

	[AccessedThroughProperty("_Label4_2")]
	private Label __Label4_2;

	[AccessedThroughProperty("_Label4_3")]
	private Label __Label4_3;

	[AccessedThroughProperty("fraUpdate")]
	private GroupBox _fraUpdate;

	[AccessedThroughProperty("Label4")]
	private LabelArray _Label4;

	[AccessedThroughProperty("cmdAdd")]
	private ButtonArray _cmdAdd;

	[AccessedThroughProperty("lblInstructions")]
	private LabelArray _lblInstructions;

	[AccessedThroughProperty("txtAff")]
	private TextBoxArray _txtAff;

	private static frmMDUpdContRpts m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	private bool bDoingAdd;

	public virtual Button _cmdAdd_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __cmdAdd_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__cmdAdd_1 = value;
		}
	}

	public virtual TextBox txtViewAA
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtViewAA;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtViewAA = value;
		}
	}

	public virtual TextBox txtViewNotes
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtViewNotes;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtViewNotes = value;
		}
	}

	public virtual AxMSFlexGrid msfContacts
	{
		[DebuggerNonUserCode]
		get
		{
			return _msfContacts;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = msfContacts_ClickEvent;
			if (_msfContacts != null)
			{
				_msfContacts.ClickEvent -= eventHandler;
			}
			_msfContacts = value;
			if (_msfContacts != null)
			{
				_msfContacts.ClickEvent += eventHandler;
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

	public virtual Button _cmdAdd_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __cmdAdd_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__cmdAdd_0 = value;
		}
	}

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

	public virtual TextBox txtAA
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtAA;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtAA = value;
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

	public virtual TextBox txtNotes
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNotes;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNotes = value;
		}
	}

	public virtual TextBox _txtAff_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtAff_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtAff_1 = value;
		}
	}

	public virtual TextBox _txtAff_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtAff_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtAff_0 = value;
		}
	}

	public virtual TextBox txtCallBy
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtCallBy;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtCallBy = value;
		}
	}

	public virtual TextBox txtPhone
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

	public virtual TextBox txtCallTo
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtCallTo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtCallTo = value;
		}
	}

	public virtual TextBox txtTime
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTime;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTime = value;
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

	public virtual Label _lblInstructions_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblInstructions_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblInstructions_1 = value;
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

	public virtual ButtonArray cmdAdd
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
				_cmdAdd.Click -= eventHandler;
			}
			_cmdAdd = value;
			if (_cmdAdd != null)
			{
				_cmdAdd.Click += eventHandler;
			}
		}
	}

	public virtual LabelArray lblInstructions
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

	public virtual TextBoxArray txtAff
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtAff;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtAff = value;
		}
	}

	public static frmMDUpdContRpts DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmMDUpdContRpts();
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

	public frmMDUpdContRpts()
	{
		((Form)this).Load += frmMDUpdContRpts_Load;
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
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected O, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected O, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected O, but got Unknown
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected O, but got Unknown
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Expected O, but got Unknown
		//IL_0558: Unknown result type (might be due to invalid IL or missing references)
		//IL_0562: Expected O, but got Unknown
		//IL_0669: Unknown result type (might be due to invalid IL or missing references)
		//IL_0673: Expected O, but got Unknown
		//IL_0767: Unknown result type (might be due to invalid IL or missing references)
		//IL_0771: Expected O, but got Unknown
		//IL_07d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07de: Expected O, but got Unknown
		//IL_08a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b1: Expected O, but got Unknown
		//IL_097a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0984: Expected O, but got Unknown
		//IL_0a60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6a: Expected O, but got Unknown
		//IL_0b30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3a: Expected O, but got Unknown
		//IL_0c0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c14: Expected O, but got Unknown
		//IL_0ce1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ceb: Expected O, but got Unknown
		//IL_0fa1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fab: Expected O, but got Unknown
		//IL_107c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1086: Expected O, but got Unknown
		//IL_116c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1176: Expected O, but got Unknown
		//IL_1247: Unknown result type (might be due to invalid IL or missing references)
		//IL_1251: Expected O, but got Unknown
		//IL_1338: Unknown result type (might be due to invalid IL or missing references)
		//IL_1342: Expected O, but got Unknown
		//IL_1429: Unknown result type (might be due to invalid IL or missing references)
		//IL_1433: Expected O, but got Unknown
		//IL_1517: Unknown result type (might be due to invalid IL or missing references)
		//IL_1521: Expected O, but got Unknown
		//IL_15f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_15ff: Expected O, but got Unknown
		//IL_16cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d9: Expected O, but got Unknown
		//IL_17aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_17b4: Expected O, but got Unknown
		//IL_1885: Unknown result type (might be due to invalid IL or missing references)
		//IL_188f: Expected O, but got Unknown
		//IL_1966: Unknown result type (might be due to invalid IL or missing references)
		//IL_1970: Expected O, but got Unknown
		//IL_1a34: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a3e: Expected O, but got Unknown
		//IL_1b08: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b12: Expected O, but got Unknown
		//IL_1be2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bec: Expected O, but got Unknown
		//IL_1cb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cc3: Expected O, but got Unknown
		//IL_1d90: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d9a: Expected O, but got Unknown
		//IL_1e74: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e7e: Expected O, but got Unknown
		//IL_1f58: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f62: Expected O, but got Unknown
		//IL_203c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2046: Expected O, but got Unknown
		//IL_211c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2126: Expected O, but got Unknown
		//IL_21fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2207: Expected O, but got Unknown
		//IL_22e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_22eb: Expected O, but got Unknown
		//IL_2416: Unknown result type (might be due to invalid IL or missing references)
		//IL_2420: Expected O, but got Unknown
		//IL_2435: Unknown result type (might be due to invalid IL or missing references)
		//IL_243f: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMDUpdContRpts));
		ToolTip1 = new ToolTip(components);
		fraView = new GroupBox();
		_cmdAdd_1 = new Button();
		txtViewAA = new TextBox();
		txtViewNotes = new TextBox();
		msfContacts = new AxMSFlexGrid();
		cmdDelete = new Button();
		cmdModify = new Button();
		_cmdAdd_0 = new Button();
		cmdClose = new Button();
		_Label4_10 = new Label();
		_Label4_9 = new Label();
		_lblInstructions_0 = new Label();
		fraUpdate = new GroupBox();
		txtAA = new TextBox();
		chkCBI = new CheckBox();
		txtNotes = new TextBox();
		_txtAff_1 = new TextBox();
		_txtAff_0 = new TextBox();
		txtCallBy = new TextBox();
		txtPhone = new TextBox();
		txtCallTo = new TextBox();
		txtTime = new TextBox();
		cmdCancel = new Button();
		txtDate = new TextBox();
		cmdOk = new Button();
		_Label4_8 = new Label();
		_lblInstructions_1 = new Label();
		_Label4_7 = new Label();
		_Label4_6 = new Label();
		_Label4_5 = new Label();
		_Label4_4 = new Label();
		_Label4_1 = new Label();
		_Label4_0 = new Label();
		_Label4_2 = new Label();
		_Label4_3 = new Label();
		Label4 = new LabelArray(components);
		cmdAdd = new ButtonArray(components);
		lblInstructions = new LabelArray(components);
		txtAff = new TextBoxArray(components);
		((Control)fraView).SuspendLayout();
		((ISupportInitialize)msfContacts).BeginInit();
		((Control)fraUpdate).SuspendLayout();
		((ISupportInitialize)Label4).BeginInit();
		((ISupportInitialize)cmdAdd).BeginInit();
		((ISupportInitialize)lblInstructions).BeginInit();
		((ISupportInitialize)txtAff).BeginInit();
		((Control)this).SuspendLayout();
		((Control)fraView).BackColor = SystemColors.Control;
		((Control)fraView).Controls.Add((Control)(object)_cmdAdd_1);
		((Control)fraView).Controls.Add((Control)(object)txtViewAA);
		((Control)fraView).Controls.Add((Control)(object)txtViewNotes);
		((Control)fraView).Controls.Add((Control)(object)msfContacts);
		((Control)fraView).Controls.Add((Control)(object)cmdDelete);
		((Control)fraView).Controls.Add((Control)(object)cmdModify);
		((Control)fraView).Controls.Add((Control)(object)_cmdAdd_0);
		((Control)fraView).Controls.Add((Control)(object)cmdClose);
		((Control)fraView).Controls.Add((Control)(object)_Label4_10);
		((Control)fraView).Controls.Add((Control)(object)_Label4_9);
		((Control)fraView).Controls.Add((Control)(object)_lblInstructions_0);
		((Control)fraView).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)fraView).ForeColor = SystemColors.ControlText;
		GroupBox obj = fraView;
		Point location = new Point(0, 0);
		((Control)obj).Location = location;
		((Control)fraView).Name = "fraView";
		((Control)fraView).RightToLeft = (RightToLeft)0;
		GroupBox obj2 = fraView;
		Size size = new Size(609, 525);
		((Control)obj2).Size = size;
		((Control)fraView).TabIndex = 19;
		fraView.TabStop = false;
		((ButtonBase)_cmdAdd_1).BackColor = SystemColors.Control;
		((Control)_cmdAdd_1).Cursor = Cursors.Default;
		((Control)_cmdAdd_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_cmdAdd_1).ForeColor = SystemColors.ControlText;
		cmdAdd.SetIndex(_cmdAdd_1, (short)1);
		Button cmdAdd_ = _cmdAdd_1;
		location = new Point(256, 488);
		((Control)cmdAdd_).Location = location;
		((Control)_cmdAdd_1).Name = "_cmdAdd_1";
		((Control)_cmdAdd_1).RightToLeft = (RightToLeft)0;
		Button cmdAdd_2 = _cmdAdd_1;
		size = new Size(81, 25);
		((Control)cmdAdd_2).Size = size;
		((Control)_cmdAdd_1).TabIndex = 5;
		((ButtonBase)_cmdAdd_1).Text = "Co&py / Add";
		((ButtonBase)_cmdAdd_1).UseVisualStyleBackColor = false;
		txtViewAA.AcceptsReturn = true;
		((TextBoxBase)txtViewAA).BackColor = Color.FromArgb(192, 192, 192);
		((Control)txtViewAA).Cursor = Cursors.IBeam;
		((Control)txtViewAA).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtViewAA).ForeColor = SystemColors.WindowText;
		TextBox obj3 = txtViewAA;
		location = new Point(8, 448);
		((Control)obj3).Location = location;
		((TextBoxBase)txtViewAA).MaxLength = 0;
		txtViewAA.Multiline = true;
		((Control)txtViewAA).Name = "txtViewAA";
		((TextBoxBase)txtViewAA).ReadOnly = true;
		((Control)txtViewAA).RightToLeft = (RightToLeft)0;
		txtViewAA.ScrollBars = (ScrollBars)2;
		TextBox obj4 = txtViewAA;
		size = new Size(585, 27);
		((Control)obj4).Size = size;
		((Control)txtViewAA).TabIndex = 2;
		((Control)txtViewAA).TabStop = false;
		txtViewNotes.AcceptsReturn = true;
		((TextBoxBase)txtViewNotes).BackColor = Color.FromArgb(192, 192, 192);
		((Control)txtViewNotes).Cursor = Cursors.IBeam;
		((Control)txtViewNotes).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtViewNotes).ForeColor = SystemColors.WindowText;
		TextBox obj5 = txtViewNotes;
		location = new Point(8, 240);
		((Control)obj5).Location = location;
		((TextBoxBase)txtViewNotes).MaxLength = 0;
		txtViewNotes.Multiline = true;
		((Control)txtViewNotes).Name = "txtViewNotes";
		((TextBoxBase)txtViewNotes).ReadOnly = true;
		((Control)txtViewNotes).RightToLeft = (RightToLeft)0;
		txtViewNotes.ScrollBars = (ScrollBars)2;
		TextBox obj6 = txtViewNotes;
		size = new Size(585, 179);
		((Control)obj6).Size = size;
		((Control)txtViewNotes).TabIndex = 1;
		((Control)txtViewNotes).TabStop = false;
		AxMSFlexGrid obj7 = msfContacts;
		location = new Point(16, 72);
		((Control)obj7).Location = location;
		((Control)msfContacts).Name = "msfContacts";
		((AxHost)msfContacts).OcxState = (State)componentResourceManager.GetObject("msfContacts.OcxState");
		AxMSFlexGrid obj8 = msfContacts;
		size = new Size(585, 129);
		((Control)obj8).Size = size;
		((Control)msfContacts).TabIndex = 0;
		((ButtonBase)cmdDelete).BackColor = SystemColors.Control;
		((Control)cmdDelete).Cursor = Cursors.Default;
		((Control)cmdDelete).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdDelete).ForeColor = SystemColors.ControlText;
		Button obj9 = cmdDelete;
		location = new Point(432, 488);
		((Control)obj9).Location = location;
		((Control)cmdDelete).Name = "cmdDelete";
		((Control)cmdDelete).RightToLeft = (RightToLeft)0;
		Button obj10 = cmdDelete;
		size = new Size(81, 25);
		((Control)obj10).Size = size;
		((Control)cmdDelete).TabIndex = 7;
		((ButtonBase)cmdDelete).Text = "&Delete";
		((ButtonBase)cmdDelete).UseVisualStyleBackColor = false;
		((ButtonBase)cmdModify).BackColor = SystemColors.Control;
		((Control)cmdModify).Cursor = Cursors.Default;
		((Control)cmdModify).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdModify).ForeColor = SystemColors.ControlText;
		Button obj11 = cmdModify;
		location = new Point(344, 488);
		((Control)obj11).Location = location;
		((Control)cmdModify).Name = "cmdModify";
		((Control)cmdModify).RightToLeft = (RightToLeft)0;
		Button obj12 = cmdModify;
		size = new Size(81, 25);
		((Control)obj12).Size = size;
		((Control)cmdModify).TabIndex = 6;
		((ButtonBase)cmdModify).Text = "&Modify";
		((ButtonBase)cmdModify).UseVisualStyleBackColor = false;
		((ButtonBase)_cmdAdd_0).BackColor = SystemColors.Control;
		((Control)_cmdAdd_0).Cursor = Cursors.Default;
		((Control)_cmdAdd_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_cmdAdd_0).ForeColor = SystemColors.ControlText;
		cmdAdd.SetIndex(_cmdAdd_0, (short)0);
		Button cmdAdd_3 = _cmdAdd_0;
		location = new Point(168, 488);
		((Control)cmdAdd_3).Location = location;
		((Control)_cmdAdd_0).Name = "_cmdAdd_0";
		((Control)_cmdAdd_0).RightToLeft = (RightToLeft)0;
		Button cmdAdd_4 = _cmdAdd_0;
		size = new Size(81, 25);
		((Control)cmdAdd_4).Size = size;
		((Control)_cmdAdd_0).TabIndex = 4;
		((ButtonBase)_cmdAdd_0).Text = "&Add";
		((ButtonBase)_cmdAdd_0).UseVisualStyleBackColor = false;
		((ButtonBase)cmdClose).BackColor = SystemColors.Control;
		((Control)cmdClose).Cursor = Cursors.Default;
		((Control)cmdClose).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdClose).ForeColor = SystemColors.ControlText;
		Button obj13 = cmdClose;
		location = new Point(80, 488);
		((Control)obj13).Location = location;
		((Control)cmdClose).Name = "cmdClose";
		((Control)cmdClose).RightToLeft = (RightToLeft)0;
		Button obj14 = cmdClose;
		size = new Size(81, 25);
		((Control)obj14).Size = size;
		((Control)cmdClose).TabIndex = 3;
		((ButtonBase)cmdClose).Text = "&Close";
		((ButtonBase)cmdClose).UseVisualStyleBackColor = false;
		((Control)_Label4_10).BackColor = SystemColors.Control;
		((Control)_Label4_10).Cursor = Cursors.Default;
		((Control)_Label4_10).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_10).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_10, (short)10);
		Label label4_ = _Label4_10;
		location = new Point(8, 432);
		((Control)label4_).Location = location;
		((Control)_Label4_10).Name = "_Label4_10";
		((Control)_Label4_10).RightToLeft = (RightToLeft)0;
		Label label4_2 = _Label4_10;
		size = new Size(191, 19);
		((Control)label4_2).Size = size;
		((Control)_Label4_10).TabIndex = 34;
		_Label4_10.Text = "Applicable Assessments:";
		((Control)_Label4_9).BackColor = SystemColors.Control;
		((Control)_Label4_9).Cursor = Cursors.Default;
		((Control)_Label4_9).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_9).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_9, (short)9);
		Label label4_3 = _Label4_9;
		location = new Point(8, 224);
		((Control)label4_3).Location = location;
		((Control)_Label4_9).Name = "_Label4_9";
		((Control)_Label4_9).RightToLeft = (RightToLeft)0;
		Label label4_4 = _Label4_9;
		size = new Size(41, 17);
		((Control)label4_4).Size = size;
		((Control)_Label4_9).TabIndex = 33;
		_Label4_9.Text = "Notes: ";
		((Control)_lblInstructions_0).BackColor = SystemColors.Control;
		((Control)_lblInstructions_0).Cursor = Cursors.Default;
		((Control)_lblInstructions_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblInstructions_0).ForeColor = SystemColors.ControlText;
		lblInstructions.SetIndex(_lblInstructions_0, (short)0);
		Label lblInstructions_ = _lblInstructions_0;
		location = new Point(16, 16);
		((Control)lblInstructions_).Location = location;
		((Control)_lblInstructions_0).Name = "_lblInstructions_0";
		((Control)_lblInstructions_0).RightToLeft = (RightToLeft)0;
		Label lblInstructions_2 = _lblInstructions_0;
		size = new Size(585, 41);
		((Control)lblInstructions_2).Size = size;
		((Control)_lblInstructions_0).TabIndex = 29;
		_lblInstructions_0.Text = "xxx";
		((Control)fraUpdate).BackColor = SystemColors.Control;
		((Control)fraUpdate).Controls.Add((Control)(object)txtAA);
		((Control)fraUpdate).Controls.Add((Control)(object)chkCBI);
		((Control)fraUpdate).Controls.Add((Control)(object)txtNotes);
		((Control)fraUpdate).Controls.Add((Control)(object)_txtAff_1);
		((Control)fraUpdate).Controls.Add((Control)(object)_txtAff_0);
		((Control)fraUpdate).Controls.Add((Control)(object)txtCallBy);
		((Control)fraUpdate).Controls.Add((Control)(object)txtPhone);
		((Control)fraUpdate).Controls.Add((Control)(object)txtCallTo);
		((Control)fraUpdate).Controls.Add((Control)(object)txtTime);
		((Control)fraUpdate).Controls.Add((Control)(object)cmdCancel);
		((Control)fraUpdate).Controls.Add((Control)(object)txtDate);
		((Control)fraUpdate).Controls.Add((Control)(object)cmdOk);
		((Control)fraUpdate).Controls.Add((Control)(object)_Label4_8);
		((Control)fraUpdate).Controls.Add((Control)(object)_lblInstructions_1);
		((Control)fraUpdate).Controls.Add((Control)(object)_Label4_7);
		((Control)fraUpdate).Controls.Add((Control)(object)_Label4_6);
		((Control)fraUpdate).Controls.Add((Control)(object)_Label4_5);
		((Control)fraUpdate).Controls.Add((Control)(object)_Label4_4);
		((Control)fraUpdate).Controls.Add((Control)(object)_Label4_1);
		((Control)fraUpdate).Controls.Add((Control)(object)_Label4_0);
		((Control)fraUpdate).Controls.Add((Control)(object)_Label4_2);
		((Control)fraUpdate).Controls.Add((Control)(object)_Label4_3);
		((Control)fraUpdate).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)fraUpdate).ForeColor = SystemColors.ControlText;
		GroupBox obj15 = fraUpdate;
		location = new Point(0, 0);
		((Control)obj15).Location = location;
		((Control)fraUpdate).Name = "fraUpdate";
		((Control)fraUpdate).RightToLeft = (RightToLeft)0;
		GroupBox obj16 = fraUpdate;
		size = new Size(609, 521);
		((Control)obj16).Size = size;
		((Control)fraUpdate).TabIndex = 20;
		fraUpdate.TabStop = false;
		((Control)fraUpdate).Visible = false;
		txtAA.AcceptsReturn = true;
		((TextBoxBase)txtAA).BackColor = SystemColors.Window;
		((Control)txtAA).Cursor = Cursors.IBeam;
		((Control)txtAA).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtAA).ForeColor = SystemColors.WindowText;
		TextBox obj17 = txtAA;
		location = new Point(16, 376);
		((Control)obj17).Location = location;
		((TextBoxBase)txtAA).MaxLength = 32000;
		txtAA.Multiline = true;
		((Control)txtAA).Name = "txtAA";
		((Control)txtAA).RightToLeft = (RightToLeft)0;
		txtAA.ScrollBars = (ScrollBars)2;
		TextBox obj18 = txtAA;
		size = new Size(577, 75);
		((Control)obj18).Size = size;
		((Control)txtAA).TabIndex = 16;
		((ButtonBase)chkCBI).BackColor = Color.FromArgb(255, 128, 128);
		((Control)chkCBI).Cursor = Cursors.Default;
		((Control)chkCBI).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)chkCBI).ForeColor = SystemColors.WindowText;
		CheckBox obj19 = chkCBI;
		location = new Point(16, 72);
		((Control)obj19).Location = location;
		((Control)chkCBI).Name = "chkCBI";
		((Control)chkCBI).RightToLeft = (RightToLeft)0;
		CheckBox obj20 = chkCBI;
		size = new Size(49, 17);
		((Control)obj20).Size = size;
		((Control)chkCBI).TabIndex = 31;
		((ButtonBase)chkCBI).Text = "CBI";
		((ButtonBase)chkCBI).UseVisualStyleBackColor = false;
		txtNotes.AcceptsReturn = true;
		((TextBoxBase)txtNotes).BackColor = SystemColors.Window;
		((Control)txtNotes).Cursor = Cursors.IBeam;
		((Control)txtNotes).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtNotes).ForeColor = SystemColors.WindowText;
		TextBox obj21 = txtNotes;
		location = new Point(16, 168);
		((Control)obj21).Location = location;
		((TextBoxBase)txtNotes).MaxLength = 32000;
		txtNotes.Multiline = true;
		((Control)txtNotes).Name = "txtNotes";
		((Control)txtNotes).RightToLeft = (RightToLeft)0;
		txtNotes.ScrollBars = (ScrollBars)2;
		TextBox obj22 = txtNotes;
		size = new Size(577, 163);
		((Control)obj22).Size = size;
		((Control)txtNotes).TabIndex = 15;
		_txtAff_1.AcceptsReturn = true;
		((TextBoxBase)_txtAff_1).BackColor = SystemColors.Window;
		((Control)_txtAff_1).Cursor = Cursors.IBeam;
		((Control)_txtAff_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtAff_1).ForeColor = SystemColors.WindowText;
		txtAff.SetIndex(_txtAff_1, (short)1);
		TextBox txtAff_ = _txtAff_1;
		location = new Point(384, 120);
		((Control)txtAff_).Location = location;
		((TextBoxBase)_txtAff_1).MaxLength = 50;
		((Control)_txtAff_1).Name = "_txtAff_1";
		((Control)_txtAff_1).RightToLeft = (RightToLeft)0;
		_txtAff_1.ScrollBars = (ScrollBars)2;
		TextBox txtAff_2 = _txtAff_1;
		size = new Size(209, 20);
		((Control)txtAff_2).Size = size;
		((Control)_txtAff_1).TabIndex = 14;
		_txtAff_0.AcceptsReturn = true;
		((TextBoxBase)_txtAff_0).BackColor = SystemColors.Window;
		((Control)_txtAff_0).Cursor = Cursors.IBeam;
		((Control)_txtAff_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtAff_0).ForeColor = SystemColors.WindowText;
		txtAff.SetIndex(_txtAff_0, (short)0);
		TextBox txtAff_3 = _txtAff_0;
		location = new Point(96, 120);
		((Control)txtAff_3).Location = location;
		((TextBoxBase)_txtAff_0).MaxLength = 50;
		((Control)_txtAff_0).Name = "_txtAff_0";
		((Control)_txtAff_0).RightToLeft = (RightToLeft)0;
		_txtAff_0.ScrollBars = (ScrollBars)2;
		TextBox txtAff_4 = _txtAff_0;
		size = new Size(209, 20);
		((Control)txtAff_4).Size = size;
		((Control)_txtAff_0).TabIndex = 10;
		txtCallBy.AcceptsReturn = true;
		((TextBoxBase)txtCallBy).BackColor = SystemColors.Window;
		((Control)txtCallBy).Cursor = Cursors.IBeam;
		((Control)txtCallBy).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtCallBy).ForeColor = SystemColors.WindowText;
		TextBox obj23 = txtCallBy;
		location = new Point(384, 96);
		((Control)obj23).Location = location;
		((TextBoxBase)txtCallBy).MaxLength = 50;
		((Control)txtCallBy).Name = "txtCallBy";
		((Control)txtCallBy).RightToLeft = (RightToLeft)0;
		txtCallBy.ScrollBars = (ScrollBars)2;
		TextBox obj24 = txtCallBy;
		size = new Size(209, 20);
		((Control)obj24).Size = size;
		((Control)txtCallBy).TabIndex = 13;
		txtPhone.AcceptsReturn = true;
		((TextBoxBase)txtPhone).BackColor = SystemColors.Window;
		((Control)txtPhone).Cursor = Cursors.IBeam;
		((Control)txtPhone).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtPhone).ForeColor = SystemColors.WindowText;
		TextBox obj25 = txtPhone;
		location = new Point(184, 72);
		((Control)obj25).Location = location;
		((TextBoxBase)txtPhone).MaxLength = 50;
		((Control)txtPhone).Name = "txtPhone";
		((Control)txtPhone).RightToLeft = (RightToLeft)0;
		txtPhone.ScrollBars = (ScrollBars)2;
		TextBox obj26 = txtPhone;
		size = new Size(121, 20);
		((Control)obj26).Size = size;
		((Control)txtPhone).TabIndex = 8;
		txtCallTo.AcceptsReturn = true;
		((TextBoxBase)txtCallTo).BackColor = SystemColors.Window;
		((Control)txtCallTo).Cursor = Cursors.IBeam;
		((Control)txtCallTo).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtCallTo).ForeColor = SystemColors.WindowText;
		TextBox obj27 = txtCallTo;
		location = new Point(96, 96);
		((Control)obj27).Location = location;
		((TextBoxBase)txtCallTo).MaxLength = 50;
		((Control)txtCallTo).Name = "txtCallTo";
		((Control)txtCallTo).RightToLeft = (RightToLeft)0;
		txtCallTo.ScrollBars = (ScrollBars)2;
		TextBox obj28 = txtCallTo;
		size = new Size(209, 20);
		((Control)obj28).Size = size;
		((Control)txtCallTo).TabIndex = 9;
		txtTime.AcceptsReturn = true;
		((TextBoxBase)txtTime).BackColor = SystemColors.Window;
		((Control)txtTime).Cursor = Cursors.IBeam;
		((Control)txtTime).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtTime).ForeColor = SystemColors.WindowText;
		TextBox obj29 = txtTime;
		location = new Point(520, 72);
		((Control)obj29).Location = location;
		((TextBoxBase)txtTime).MaxLength = 12;
		((Control)txtTime).Name = "txtTime";
		((Control)txtTime).RightToLeft = (RightToLeft)0;
		txtTime.ScrollBars = (ScrollBars)2;
		TextBox obj30 = txtTime;
		size = new Size(73, 20);
		((Control)obj30).Size = size;
		((Control)txtTime).TabIndex = 12;
		((ButtonBase)cmdCancel).BackColor = SystemColors.Control;
		((Control)cmdCancel).Cursor = Cursors.Default;
		cmdCancel.DialogResult = (DialogResult)2;
		((Control)cmdCancel).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCancel).ForeColor = SystemColors.ControlText;
		Button obj31 = cmdCancel;
		location = new Point(312, 464);
		((Control)obj31).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		((Control)cmdCancel).RightToLeft = (RightToLeft)0;
		Button obj32 = cmdCancel;
		size = new Size(81, 25);
		((Control)obj32).Size = size;
		((Control)cmdCancel).TabIndex = 18;
		((ButtonBase)cmdCancel).Text = "Cancel";
		((ButtonBase)cmdCancel).UseVisualStyleBackColor = false;
		txtDate.AcceptsReturn = true;
		((TextBoxBase)txtDate).BackColor = SystemColors.Window;
		((Control)txtDate).Cursor = Cursors.IBeam;
		((Control)txtDate).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtDate).ForeColor = SystemColors.WindowText;
		TextBox obj33 = txtDate;
		location = new Point(384, 72);
		((Control)obj33).Location = location;
		((TextBoxBase)txtDate).MaxLength = 50;
		((Control)txtDate).Name = "txtDate";
		((Control)txtDate).RightToLeft = (RightToLeft)0;
		txtDate.ScrollBars = (ScrollBars)2;
		TextBox obj34 = txtDate;
		size = new Size(73, 20);
		((Control)obj34).Size = size;
		((Control)txtDate).TabIndex = 11;
		((ButtonBase)cmdOk).BackColor = SystemColors.Control;
		((Control)cmdOk).Cursor = Cursors.Default;
		((Control)cmdOk).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdOk).ForeColor = SystemColors.ControlText;
		Button obj35 = cmdOk;
		location = new Point(216, 464);
		((Control)obj35).Location = location;
		((Control)cmdOk).Name = "cmdOk";
		((Control)cmdOk).RightToLeft = (RightToLeft)0;
		Button obj36 = cmdOk;
		size = new Size(81, 25);
		((Control)obj36).Size = size;
		((Control)cmdOk).TabIndex = 17;
		((ButtonBase)cmdOk).Text = "OK";
		((ButtonBase)cmdOk).UseVisualStyleBackColor = false;
		((Control)_Label4_8).BackColor = SystemColors.Control;
		((Control)_Label4_8).Cursor = Cursors.Default;
		((Control)_Label4_8).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_8).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_8, (short)8);
		Label label4_5 = _Label4_8;
		location = new Point(16, 360);
		((Control)label4_5).Location = location;
		((Control)_Label4_8).Name = "_Label4_8";
		((Control)_Label4_8).RightToLeft = (RightToLeft)0;
		Label label4_6 = _Label4_8;
		size = new Size(233, 13);
		((Control)label4_6).Size = size;
		((Control)_Label4_8).TabIndex = 32;
		_Label4_8.Text = "Applicable Assessments:";
		((Control)_lblInstructions_1).BackColor = SystemColors.Control;
		((Control)_lblInstructions_1).Cursor = Cursors.Default;
		((Control)_lblInstructions_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblInstructions_1).ForeColor = SystemColors.ControlText;
		lblInstructions.SetIndex(_lblInstructions_1, (short)1);
		Label lblInstructions_3 = _lblInstructions_1;
		location = new Point(16, 24);
		((Control)lblInstructions_3).Location = location;
		((Control)_lblInstructions_1).Name = "_lblInstructions_1";
		((Control)_lblInstructions_1).RightToLeft = (RightToLeft)0;
		Label lblInstructions_4 = _lblInstructions_1;
		size = new Size(577, 33);
		((Control)lblInstructions_4).Size = size;
		((Control)_lblInstructions_1).TabIndex = 30;
		_lblInstructions_1.Text = "xxx";
		((Control)_Label4_7).BackColor = SystemColors.Control;
		((Control)_Label4_7).Cursor = Cursors.Default;
		((Control)_Label4_7).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_7).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_7, (short)7);
		Label label4_7 = _Label4_7;
		location = new Point(16, 152);
		((Control)label4_7).Location = location;
		((Control)_Label4_7).Name = "_Label4_7";
		((Control)_Label4_7).RightToLeft = (RightToLeft)0;
		Label label4_8 = _Label4_7;
		size = new Size(41, 17);
		((Control)label4_8).Size = size;
		((Control)_Label4_7).TabIndex = 28;
		_Label4_7.Text = "Notes: ";
		((Control)_Label4_6).BackColor = SystemColors.Control;
		((Control)_Label4_6).Cursor = Cursors.Default;
		((Control)_Label4_6).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_6).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_6, (short)6);
		Label label4_9 = _Label4_6;
		location = new Point(320, 120);
		((Control)label4_9).Location = location;
		((Control)_Label4_6).Name = "_Label4_6";
		((Control)_Label4_6).RightToLeft = (RightToLeft)0;
		Label label4_10 = _Label4_6;
		size = new Size(57, 17);
		((Control)label4_10).Size = size;
		((Control)_Label4_6).TabIndex = 27;
		_Label4_6.Text = "Affiliation: ";
		_Label4_6.TextAlign = (ContentAlignment)4;
		((Control)_Label4_5).BackColor = SystemColors.Control;
		((Control)_Label4_5).Cursor = Cursors.Default;
		((Control)_Label4_5).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_5).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_5, (short)5);
		Label label4_11 = _Label4_5;
		location = new Point(312, 96);
		((Control)label4_11).Location = location;
		((Control)_Label4_5).Name = "_Label4_5";
		((Control)_Label4_5).RightToLeft = (RightToLeft)0;
		Label label4_12 = _Label4_5;
		size = new Size(65, 17);
		((Control)label4_12).Size = size;
		((Control)_Label4_5).TabIndex = 26;
		_Label4_5.Text = "Called By:";
		_Label4_5.TextAlign = (ContentAlignment)4;
		((Control)_Label4_4).BackColor = SystemColors.Control;
		((Control)_Label4_4).Cursor = Cursors.Default;
		((Control)_Label4_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_4).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_4, (short)4);
		Label label4_13 = _Label4_4;
		location = new Point(128, 72);
		((Control)label4_13).Location = location;
		((Control)_Label4_4).Name = "_Label4_4";
		((Control)_Label4_4).RightToLeft = (RightToLeft)0;
		Label label4_14 = _Label4_4;
		size = new Size(49, 17);
		((Control)label4_14).Size = size;
		((Control)_Label4_4).TabIndex = 25;
		_Label4_4.Text = "Phone:";
		_Label4_4.TextAlign = (ContentAlignment)4;
		((Control)_Label4_1).BackColor = SystemColors.Control;
		((Control)_Label4_1).Cursor = Cursors.Default;
		((Control)_Label4_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_1).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_1, (short)1);
		Label label4_15 = _Label4_1;
		location = new Point(8, 120);
		((Control)label4_15).Location = location;
		((Control)_Label4_1).Name = "_Label4_1";
		((Control)_Label4_1).RightToLeft = (RightToLeft)0;
		Label label4_16 = _Label4_1;
		size = new Size(81, 17);
		((Control)label4_16).Size = size;
		((Control)_Label4_1).TabIndex = 24;
		_Label4_1.Text = "Affiliation:";
		_Label4_1.TextAlign = (ContentAlignment)4;
		((Control)_Label4_0).BackColor = SystemColors.Control;
		((Control)_Label4_0).Cursor = Cursors.Default;
		((Control)_Label4_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_0).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_0, (short)0);
		Label label4_17 = _Label4_0;
		location = new Point(16, 96);
		((Control)label4_17).Location = location;
		((Control)_Label4_0).Name = "_Label4_0";
		((Control)_Label4_0).RightToLeft = (RightToLeft)0;
		Label label4_18 = _Label4_0;
		size = new Size(65, 17);
		((Control)label4_18).Size = size;
		((Control)_Label4_0).TabIndex = 23;
		_Label4_0.Text = "Call To:";
		_Label4_0.TextAlign = (ContentAlignment)4;
		((Control)_Label4_2).BackColor = SystemColors.Control;
		((Control)_Label4_2).Cursor = Cursors.Default;
		((Control)_Label4_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_2).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_2, (short)2);
		Label label4_19 = _Label4_2;
		location = new Point(456, 72);
		((Control)label4_19).Location = location;
		((Control)_Label4_2).Name = "_Label4_2";
		((Control)_Label4_2).RightToLeft = (RightToLeft)0;
		Label label4_20 = _Label4_2;
		size = new Size(57, 17);
		((Control)label4_20).Size = size;
		((Control)_Label4_2).TabIndex = 22;
		_Label4_2.Text = "Call Time:";
		_Label4_2.TextAlign = (ContentAlignment)4;
		((Control)_Label4_3).BackColor = SystemColors.Control;
		((Control)_Label4_3).Cursor = Cursors.Default;
		((Control)_Label4_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_3).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_3, (short)3);
		Label label4_21 = _Label4_3;
		location = new Point(320, 72);
		((Control)label4_21).Location = location;
		((Control)_Label4_3).Name = "_Label4_3";
		((Control)_Label4_3).RightToLeft = (RightToLeft)0;
		Label label4_22 = _Label4_3;
		size = new Size(57, 17);
		((Control)label4_22).Size = size;
		((Control)_Label4_3).TabIndex = 21;
		_Label4_3.Text = "Call Date:";
		_Label4_3.TextAlign = (ContentAlignment)4;
		size = new Size(5, 13);
		((Form)this).AutoScaleBaseSize = size;
		((Form)this).BackColor = SystemColors.Control;
		((Form)this).CancelButton = (IButtonControl)(object)cmdCancel;
		size = new Size(642, 527);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)fraUpdate);
		((Control)this).Controls.Add((Control)(object)fraView);
		((Control)this).Cursor = Cursors.Default;
		((Control)this).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		location = new Point(250, 125);
		((Form)this).Location = location;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmMDUpdContRpts";
		((Control)this).RightToLeft = (RightToLeft)0;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "View/Update Contact Reports";
		((Control)fraView).ResumeLayout(false);
		((Control)fraView).PerformLayout();
		((ISupportInitialize)msfContacts).EndInit();
		((Control)fraUpdate).ResumeLayout(false);
		((Control)fraUpdate).PerformLayout();
		((ISupportInitialize)Label4).EndInit();
		((ISupportInitialize)cmdAdd).EndInit();
		((ISupportInitialize)lblInstructions).EndInit();
		((ISupportInitialize)txtAff).EndInit();
		((Control)this).ResumeLayout(false);
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
		command.Parameters.Append(command.CreateParameter("pID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, 5));
		Command command2 = command;
		object RecordsAffected = Missing.Value;
		object Parameters = Missing.Value;
		recordset = command2.Execute(out RecordsAffected, ref Parameters);
		command.Parameters.Delete("pID");
		lblInstructions[(short)0].Text = Conversions.ToString(recordset.Fields[0].Value);
		recordset.Close();
		command.Parameters.Append(command.CreateParameter("pID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, 27));
		Command command3 = command;
		Parameters = Missing.Value;
		RecordsAffected = Missing.Value;
		recordset = command3.Execute(out Parameters, ref RecordsAffected);
		command.Parameters.Delete("pID");
		lblInstructions[(short)1].Text = Conversions.ToString(recordset.Fields[0].Value);
		recordset.Close();
		recordset = null;
		command = null;
		txtViewNotes.Text = "";
		txtViewAA.Text = "";
		AxMSFlexGrid pGridCopy = frmMain.DefInstance.msfContacts;
		AxMSFlexGrid pGridTo = msfContacts;
		ChemStrX.CloneFlexGrid(ref pGridCopy, ref pGridTo);
		msfContacts = pGridTo;
		msfContacts[0, 0] = "CBI";
		msfContacts[0, 1] = "Call Date";
		msfContacts[0, 2] = "Call Time";
		msfContacts[0, 3] = "Call To";
		msfContacts[0, 4] = "Affiliation";
		msfContacts[0, 5] = "Phone";
		msfContacts[0, 6] = "Called By";
		msfContacts[0, 7] = "Affiliation";
		msfContacts[0] = 400;
		msfContacts[1] = 950;
		msfContacts[2] = 750;
		msfContacts[3] = 1400;
		msfContacts[4] = 1200;
		msfContacts[5] = 1300;
		msfContacts[6] = 1400;
		msfContacts[7] = 1200;
		msfContacts[8] = 0;
		msfContacts[9] = 0;
		return true;
	}

	private void cmdAdd_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		short index = cmdAdd.GetIndex((Button)eventSender);
		object obj = "\r\n";
		bDoingAdd = true;
		((Form)this).Text = "Add Contact Report";
		chkCBI.CheckState = (CheckState)1;
		txtDate.Text = Strings.Format((object)DateAndTime.Now, Globals_Renamed.gblChemDateFormat);
		txtTime.Text = "";
		if (msfContacts.Row == 0 || index == 0)
		{
			txtCallTo.Text = "";
			txtAff[(short)0].Text = "";
			txtPhone.Text = "";
			txtCallBy.Text = "";
			txtAff[(short)1].Text = "";
		}
		else
		{
			txtCallTo.Text = msfContacts[msfContacts.Row, 3];
			txtAff[(short)0].Text = msfContacts[msfContacts.Row, 4];
			txtPhone.Text = msfContacts[msfContacts.Row, 5];
			txtCallBy.Text = msfContacts[msfContacts.Row, 6];
			txtAff[(short)1].Text = msfContacts[msfContacts.Row, 7];
		}
		txtNotes.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Q1: ", obj), (object)"A1: "), obj), obj), (object)"Q2: "), obj), (object)"A2: "), obj), obj), (object)"Q3: "), obj), (object)"A3: "), obj), obj), (object)"Q4: "), obj), (object)"A4: "));
		txtAA.Text = "";
		((Control)fraView).Visible = false;
		((Control)fraUpdate).Visible = true;
	}

	private void cmdCancel_Click(object eventSender, EventArgs eventArgs)
	{
		((Control)fraUpdate).Visible = false;
		((Control)fraView).Visible = true;
		((Form)this).Text = "View/Update Contact Reports";
	}

	private void cmdClose_Click(object eventSender, EventArgs eventArgs)
	{
		if (msfContacts.Rows == 1)
		{
			frmMain.DefInstance.lblNumCR.Text = Conversions.ToString(0);
		}
		else if (Operators.CompareString(msfContacts[1, 1], "", false) == 0)
		{
			frmMain.DefInstance.lblNumCR.Text = Conversions.ToString(0);
		}
		else
		{
			frmMain.DefInstance.lblNumCR.Text = Conversions.ToString(checked(msfContacts.Rows - 1));
		}
		AxMSFlexGrid pGridCopy = msfContacts;
		AxMSFlexGrid pGridTo = frmMain.DefInstance.msfContacts;
		ChemStrX.CloneFlexGrid(ref pGridCopy, ref pGridTo);
		msfContacts = pGridCopy;
		((Form)this).Close();
	}

	private void cmdDelete_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between Unknown and I4
		if ((int)Interaction.MsgBox((object)"Are you sure you want to delete the Contact Report?", (MsgBoxStyle)36, (object)"Confirm Delete") != 6)
		{
			return;
		}
		checked
		{
			if (msfContacts.Rows == 2)
			{
				short num = (short)(msfContacts.Cols - 1);
				short num2 = 0;
				while (true)
				{
					short num3 = num2;
					short num4 = num;
					if (num3 <= num4)
					{
						msfContacts[1, unchecked((int)num2)] = "";
						num2 = (short)unchecked(num2 + 1);
						continue;
					}
					break;
				}
			}
			else
			{
				msfContacts.RemoveItem(msfContacts.Row);
			}
			Globals_Renamed.gblIWasChanged = true;
			txtViewNotes.Text = msfContacts[msfContacts.Row, 8];
			txtViewAA.Text = msfContacts[msfContacts.Row, 9];
		}
	}

	private void cmdModify_Click(object eventSender, EventArgs eventArgs)
	{
		((Form)this).Text = "Modify Contact Report";
		bDoingAdd = false;
		chkCBI.CheckState = (CheckState)Conversions.ToInteger(Interaction.IIf(Operators.CompareString(msfContacts[msfContacts.Row, 0], "Yes", false) == 0, (object)(CheckState)1, (object)(CheckState)0));
		txtDate.Text = msfContacts[msfContacts.Row, 1];
		txtTime.Text = msfContacts[msfContacts.Row, 2];
		txtCallTo.Text = msfContacts[msfContacts.Row, 3];
		txtAff[(short)0].Text = msfContacts[msfContacts.Row, 4];
		txtPhone.Text = msfContacts[msfContacts.Row, 5];
		txtCallBy.Text = msfContacts[msfContacts.Row, 6];
		txtAff[(short)1].Text = msfContacts[msfContacts.Row, 7];
		txtNotes.Text = msfContacts[msfContacts.Row, 8];
		txtAA.Text = msfContacts[msfContacts.Row, 9];
		((Control)fraView).Visible = false;
		((Control)fraUpdate).Visible = true;
	}

	private void cmdOk_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Invalid comparison between Unknown and I4
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Invalid comparison between Unknown and I4
		if (!Information.IsDate((object)txtDate.Text))
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Please enter the date of the call.  The date field is required and must be in the format of MM/DD/YYYY. Put the time of the call in the time field.", (MsgBoxStyle)64, (object)"Required Data Missing");
			((Control)txtDate).Focus();
			return;
		}
		if (bDoingAdd)
		{
			AxMSFlexGrid obj = msfContacts;
			object obj2 = Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Interaction.IIf((int)chkCBI.CheckState == 1, (object)"Yes", (object)"No"), (object)'\t'), (object)txtDate.Text), (object)'\t'), (object)txtTime.Text), (object)'\t'), (object)txtCallTo.Text), (object)'\t'), (object)txtAff[(short)0].Text), (object)'\t'), (object)txtPhone.Text), (object)'\t'), (object)txtCallBy.Text), (object)'\t'), (object)txtAff[(short)1].Text), (object)'\t');
			TextBox val = txtNotes;
			string pText = val.Text;
			string text = ChemStrX.TrtLineBreak(ref pText);
			val.Text = pText;
			object obj3 = Operators.ConcatenateObject(Operators.ConcatenateObject(obj2, (object)text), (object)'\t');
			TextBox val2 = txtAA;
			string pText2 = val2.Text;
			string text2 = ChemStrX.TrtLineBreak(ref pText2);
			val2.Text = pText2;
			obj.AddItem(Conversions.ToString(Operators.ConcatenateObject(obj3, (object)text2)));
			if (Operators.CompareString(msfContacts[1, 1], "", false) == 0)
			{
				msfContacts.RemoveItem(1);
			}
			TextBox obj4 = txtViewNotes;
			val = txtNotes;
			pText = val.Text;
			string text3 = ChemStrX.TrtLineBreak(ref pText);
			val.Text = pText;
			obj4.Text = text3;
			TextBox obj5 = txtViewAA;
			val = txtAA;
			pText = val.Text;
			string text4 = ChemStrX.TrtLineBreak(ref pText);
			val.Text = pText;
			obj5.Text = text4;
		}
		else
		{
			msfContacts[msfContacts.Row, 0] = Conversions.ToString(Interaction.IIf((int)chkCBI.CheckState == 1, (object)"Yes", (object)"No"));
			msfContacts[msfContacts.Row, 1] = txtDate.Text;
			msfContacts[msfContacts.Row, 2] = txtTime.Text;
			msfContacts[msfContacts.Row, 3] = txtCallTo.Text;
			msfContacts[msfContacts.Row, 4] = txtAff[(short)0].Text;
			msfContacts[msfContacts.Row, 5] = txtPhone.Text;
			msfContacts[msfContacts.Row, 6] = txtCallBy.Text;
			msfContacts[msfContacts.Row, 7] = txtAff[(short)1].Text;
			AxMSFlexGrid obj6 = msfContacts;
			int row = msfContacts.Row;
			TextBox val = txtNotes;
			string pText = val.Text;
			string text5 = ChemStrX.TrtLineBreak(ref pText);
			val.Text = pText;
			obj6[row, 8] = text5;
			AxMSFlexGrid obj7 = msfContacts;
			int row2 = msfContacts.Row;
			val = txtAA;
			pText = val.Text;
			string text6 = ChemStrX.TrtLineBreak(ref pText);
			val.Text = pText;
			obj7[row2, 9] = text6;
			txtViewNotes.Text = txtNotes.Text;
			txtViewAA.Text = txtAA.Text;
		}
		((Control)fraUpdate).Visible = false;
		((Control)fraView).Visible = true;
		((Form)this).Text = "View/Update Contact Reports";
		Globals_Renamed.gblIWasChanged = true;
	}

	private void frmMDUpdContRpts_Load(object eventSender, EventArgs eventArgs)
	{
		SetUp();
	}

	private void msfContacts_ClickEvent(object eventSender, EventArgs eventArgs)
	{
		txtViewNotes.Text = msfContacts[msfContacts.Row, 8];
		txtViewAA.Text = msfContacts[msfContacts.Row, 9];
	}

	private void txtDate_Leave(object eventSender, EventArgs eventArgs)
	{
		if (Information.IsDate((object)txtDate.Text))
		{
			DateTime dateTime = Conversions.ToDate(txtDate.Text);
			txtDate.Text = Strings.Format((object)dateTime, Globals_Renamed.gblChemDateFormat);
		}
	}
}
