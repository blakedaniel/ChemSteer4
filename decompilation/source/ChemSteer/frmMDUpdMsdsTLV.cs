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

internal class frmMDUpdMsdsTLV : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("_txtInput_7")]
	private TextBox __txtInput_7;

	[AccessedThroughProperty("_txtInput_6")]
	private TextBox __txtInput_6;

	[AccessedThroughProperty("_txtInput_5")]
	private TextBox __txtInput_5;

	[AccessedThroughProperty("_txtInput_4")]
	private TextBox __txtInput_4;

	[AccessedThroughProperty("_txtInput_3")]
	private TextBox __txtInput_3;

	[AccessedThroughProperty("_txtInput_2")]
	private TextBox __txtInput_2;

	[AccessedThroughProperty("_txtInput_1")]
	private TextBox __txtInput_1;

	[AccessedThroughProperty("_txtInput_0")]
	private TextBox __txtInput_0;

	[AccessedThroughProperty("cmdOk")]
	private Button _cmdOk;

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

	[AccessedThroughProperty("_Label1_1")]
	private Label __Label1_1;

	[AccessedThroughProperty("_Label1_0")]
	private Label __Label1_0;

	[AccessedThroughProperty("_Label1_2")]
	private Label __Label1_2;

	[AccessedThroughProperty("_lblInstructions_1")]
	private Label __lblInstructions_1;

	[AccessedThroughProperty("fraUpdate")]
	private GroupBox _fraUpdate;

	[AccessedThroughProperty("cmdModify")]
	private Button _cmdModify;

	[AccessedThroughProperty("cmdClose")]
	private Button _cmdClose;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("cmdAdd")]
	private Button _cmdAdd;

	[AccessedThroughProperty("cmdRemove")]
	private Button _cmdRemove;

	[AccessedThroughProperty("msfTlv")]
	private AxMSFlexGrid _msfTlv;

	[AccessedThroughProperty("_lblInstructions_0")]
	private Label __lblInstructions_0;

	[AccessedThroughProperty("fraView")]
	private GroupBox _fraView;

	[AccessedThroughProperty("Label1")]
	private LabelArray _Label1;

	[AccessedThroughProperty("lblInstructions")]
	private LabelArray _lblInstructions;

	[AccessedThroughProperty("cmdCancelTwo")]
	private Button _cmdCancelTwo;

	[AccessedThroughProperty("txtInput")]
	private TextBoxArray _txtInput;

	private static frmMDUpdMsdsTLV m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	public virtual TextBox _txtInput_7
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtInput_7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtInput_7 = value;
		}
	}

	public virtual TextBox _txtInput_6
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtInput_6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtInput_6 = value;
		}
	}

	public virtual TextBox _txtInput_5
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtInput_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtInput_5 = value;
		}
	}

	public virtual TextBox _txtInput_4
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtInput_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtInput_4 = value;
		}
	}

	public virtual TextBox _txtInput_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtInput_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtInput_3 = value;
		}
	}

	public virtual TextBox _txtInput_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtInput_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtInput_2 = value;
		}
	}

	public virtual TextBox _txtInput_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtInput_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtInput_1 = value;
		}
	}

	public virtual TextBox _txtInput_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtInput_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtInput_0 = value;
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

	public virtual Button cmdRemove
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdRemove;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdRemove_Click;
			if (_cmdRemove != null)
			{
				((Control)_cmdRemove).Click -= eventHandler;
			}
			_cmdRemove = value;
			if (_cmdRemove != null)
			{
				((Control)_cmdRemove).Click += eventHandler;
			}
		}
	}

	public virtual AxMSFlexGrid msfTlv
	{
		[DebuggerNonUserCode]
		get
		{
			return _msfTlv;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_msfTlv = value;
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

	public virtual Button cmdCancelTwo
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdCancelTwo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdCancelTwo_Click;
			if (_cmdCancelTwo != null)
			{
				((Control)_cmdCancelTwo).Click -= eventHandler;
			}
			_cmdCancelTwo = value;
			if (_cmdCancelTwo != null)
			{
				((Control)_cmdCancelTwo).Click += eventHandler;
			}
		}
	}

	public virtual TextBoxArray txtInput
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
			_txtInput = value;
		}
	}

	public static frmMDUpdMsdsTLV DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmMDUpdMsdsTLV();
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

	public frmMDUpdMsdsTLV()
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
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected O, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Expected O, but got Unknown
		//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Expected O, but got Unknown
		//IL_058a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Expected O, but got Unknown
		//IL_066f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0679: Expected O, but got Unknown
		//IL_0754: Unknown result type (might be due to invalid IL or missing references)
		//IL_075e: Expected O, but got Unknown
		//IL_0839: Unknown result type (might be due to invalid IL or missing references)
		//IL_0843: Expected O, but got Unknown
		//IL_091b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0925: Expected O, but got Unknown
		//IL_09fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a07: Expected O, but got Unknown
		//IL_0adc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae6: Expected O, but got Unknown
		//IL_0bbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc5: Expected O, but got Unknown
		//IL_0c90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9a: Expected O, but got Unknown
		//IL_0d63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6d: Expected O, but got Unknown
		//IL_0e47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e51: Expected O, but got Unknown
		//IL_0f2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f35: Expected O, but got Unknown
		//IL_1012: Unknown result type (might be due to invalid IL or missing references)
		//IL_101c: Expected O, but got Unknown
		//IL_10f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1100: Expected O, but got Unknown
		//IL_11da: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e4: Expected O, but got Unknown
		//IL_12be: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c8: Expected O, but got Unknown
		//IL_139f: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a9: Expected O, but got Unknown
		//IL_1480: Unknown result type (might be due to invalid IL or missing references)
		//IL_148a: Expected O, but got Unknown
		//IL_15e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f1: Expected O, but got Unknown
		//IL_16a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_16b2: Expected O, but got Unknown
		//IL_177c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1786: Expected O, but got Unknown
		//IL_184d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1857: Expected O, but got Unknown
		//IL_1921: Unknown result type (might be due to invalid IL or missing references)
		//IL_192b: Expected O, but got Unknown
		//IL_19f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_19ff: Expected O, but got Unknown
		//IL_1acf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ad9: Expected O, but got Unknown
		//IL_1b3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b47: Expected O, but got Unknown
		//IL_1c58: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c62: Expected O, but got Unknown
		//IL_1c77: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c81: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMDUpdMsdsTLV));
		ToolTip1 = new ToolTip(components);
		fraUpdate = new GroupBox();
		cmdCancelTwo = new Button();
		_txtInput_7 = new TextBox();
		_txtInput_6 = new TextBox();
		_txtInput_5 = new TextBox();
		_txtInput_4 = new TextBox();
		_txtInput_3 = new TextBox();
		_txtInput_2 = new TextBox();
		_txtInput_1 = new TextBox();
		_txtInput_0 = new TextBox();
		cmdOk = new Button();
		_Label1_7 = new Label();
		_Label1_6 = new Label();
		_Label1_5 = new Label();
		_Label1_4 = new Label();
		_Label1_3 = new Label();
		_Label1_1 = new Label();
		_Label1_0 = new Label();
		_Label1_2 = new Label();
		_lblInstructions_1 = new Label();
		fraView = new GroupBox();
		cmdModify = new Button();
		cmdClose = new Button();
		cmdCancel = new Button();
		cmdAdd = new Button();
		cmdRemove = new Button();
		msfTlv = new AxMSFlexGrid();
		_lblInstructions_0 = new Label();
		Label1 = new LabelArray(components);
		lblInstructions = new LabelArray(components);
		txtInput = new TextBoxArray(components);
		((Control)fraUpdate).SuspendLayout();
		((Control)fraView).SuspendLayout();
		((ISupportInitialize)msfTlv).BeginInit();
		((ISupportInitialize)Label1).BeginInit();
		((ISupportInitialize)lblInstructions).BeginInit();
		((ISupportInitialize)txtInput).BeginInit();
		((Control)this).SuspendLayout();
		((Control)fraUpdate).BackColor = SystemColors.Control;
		((Control)fraUpdate).Controls.Add((Control)(object)cmdCancelTwo);
		((Control)fraUpdate).Controls.Add((Control)(object)_txtInput_7);
		((Control)fraUpdate).Controls.Add((Control)(object)_txtInput_6);
		((Control)fraUpdate).Controls.Add((Control)(object)_txtInput_5);
		((Control)fraUpdate).Controls.Add((Control)(object)_txtInput_4);
		((Control)fraUpdate).Controls.Add((Control)(object)_txtInput_3);
		((Control)fraUpdate).Controls.Add((Control)(object)_txtInput_2);
		((Control)fraUpdate).Controls.Add((Control)(object)_txtInput_1);
		((Control)fraUpdate).Controls.Add((Control)(object)_txtInput_0);
		((Control)fraUpdate).Controls.Add((Control)(object)cmdOk);
		((Control)fraUpdate).Controls.Add((Control)(object)_Label1_7);
		((Control)fraUpdate).Controls.Add((Control)(object)_Label1_6);
		((Control)fraUpdate).Controls.Add((Control)(object)_Label1_5);
		((Control)fraUpdate).Controls.Add((Control)(object)_Label1_4);
		((Control)fraUpdate).Controls.Add((Control)(object)_Label1_3);
		((Control)fraUpdate).Controls.Add((Control)(object)_Label1_1);
		((Control)fraUpdate).Controls.Add((Control)(object)_Label1_0);
		((Control)fraUpdate).Controls.Add((Control)(object)_Label1_2);
		((Control)fraUpdate).Controls.Add((Control)(object)_lblInstructions_1);
		((Control)fraUpdate).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)fraUpdate).ForeColor = SystemColors.ControlText;
		GroupBox obj = fraUpdate;
		Point location = new Point(8, 8);
		((Control)obj).Location = location;
		((Control)fraUpdate).Name = "fraUpdate";
		((Control)fraUpdate).RightToLeft = (RightToLeft)0;
		GroupBox obj2 = fraUpdate;
		Size size = new Size(545, 297);
		((Control)obj2).Size = size;
		((Control)fraUpdate).TabIndex = 18;
		fraUpdate.TabStop = false;
		((Control)fraUpdate).Visible = false;
		((ButtonBase)cmdCancelTwo).BackColor = SystemColors.Control;
		((Control)cmdCancelTwo).Cursor = Cursors.Default;
		((Control)cmdCancelTwo).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCancelTwo).ForeColor = SystemColors.ControlText;
		Button obj3 = cmdCancelTwo;
		location = new Point(281, 256);
		((Control)obj3).Location = location;
		((Control)cmdCancelTwo).Name = "cmdCancelTwo";
		((Control)cmdCancelTwo).RightToLeft = (RightToLeft)0;
		Button obj4 = cmdCancelTwo;
		size = new Size(81, 25);
		((Control)obj4).Size = size;
		((Control)cmdCancelTwo).TabIndex = 28;
		((ButtonBase)cmdCancelTwo).Text = "Cancel";
		((ButtonBase)cmdCancelTwo).UseVisualStyleBackColor = false;
		_txtInput_7.AcceptsReturn = true;
		((TextBoxBase)_txtInput_7).BackColor = SystemColors.Window;
		((Control)_txtInput_7).Cursor = Cursors.IBeam;
		((Control)_txtInput_7).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtInput_7).ForeColor = SystemColors.WindowText;
		txtInput.SetIndex(_txtInput_7, (short)7);
		TextBox txtInput_ = _txtInput_7;
		location = new Point(136, 168);
		((Control)txtInput_).Location = location;
		((TextBoxBase)_txtInput_7).MaxLength = 0;
		((Control)_txtInput_7).Name = "_txtInput_7";
		((Control)_txtInput_7).RightToLeft = (RightToLeft)0;
		TextBox txtInput_2 = _txtInput_7;
		size = new Size(393, 20);
		((Control)txtInput_2).Size = size;
		((Control)_txtInput_7).TabIndex = 5;
		_txtInput_6.AcceptsReturn = true;
		((TextBoxBase)_txtInput_6).BackColor = SystemColors.Window;
		((Control)_txtInput_6).Cursor = Cursors.IBeam;
		((Control)_txtInput_6).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtInput_6).ForeColor = SystemColors.WindowText;
		txtInput.SetIndex(_txtInput_6, (short)6);
		TextBox txtInput_3 = _txtInput_6;
		location = new Point(136, 216);
		((Control)txtInput_3).Location = location;
		((TextBoxBase)_txtInput_6).MaxLength = 0;
		((Control)_txtInput_6).Name = "_txtInput_6";
		((Control)_txtInput_6).RightToLeft = (RightToLeft)0;
		TextBox txtInput_4 = _txtInput_6;
		size = new Size(393, 20);
		((Control)txtInput_4).Size = size;
		((Control)_txtInput_6).TabIndex = 7;
		_txtInput_5.AcceptsReturn = true;
		((TextBoxBase)_txtInput_5).BackColor = SystemColors.Window;
		((Control)_txtInput_5).Cursor = Cursors.IBeam;
		((Control)_txtInput_5).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtInput_5).ForeColor = SystemColors.WindowText;
		txtInput.SetIndex(_txtInput_5, (short)5);
		TextBox txtInput_5 = _txtInput_5;
		location = new Point(136, 192);
		((Control)txtInput_5).Location = location;
		((TextBoxBase)_txtInput_5).MaxLength = 0;
		((Control)_txtInput_5).Name = "_txtInput_5";
		((Control)_txtInput_5).RightToLeft = (RightToLeft)0;
		TextBox txtInput_6 = _txtInput_5;
		size = new Size(393, 20);
		((Control)txtInput_6).Size = size;
		((Control)_txtInput_5).TabIndex = 6;
		_txtInput_4.AcceptsReturn = true;
		((TextBoxBase)_txtInput_4).BackColor = SystemColors.Window;
		((Control)_txtInput_4).Cursor = Cursors.IBeam;
		((Control)_txtInput_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtInput_4).ForeColor = SystemColors.WindowText;
		txtInput.SetIndex(_txtInput_4, (short)4);
		TextBox txtInput_7 = _txtInput_4;
		location = new Point(312, 136);
		((Control)txtInput_7).Location = location;
		((TextBoxBase)_txtInput_4).MaxLength = 0;
		((Control)_txtInput_4).Name = "_txtInput_4";
		((Control)_txtInput_4).RightToLeft = (RightToLeft)0;
		TextBox txtInput_8 = _txtInput_4;
		size = new Size(73, 20);
		((Control)txtInput_8).Size = size;
		((Control)_txtInput_4).TabIndex = 4;
		_txtInput_3.AcceptsReturn = true;
		((TextBoxBase)_txtInput_3).BackColor = SystemColors.Window;
		((Control)_txtInput_3).Cursor = Cursors.IBeam;
		((Control)_txtInput_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtInput_3).ForeColor = SystemColors.WindowText;
		txtInput.SetIndex(_txtInput_3, (short)3);
		TextBox txtInput_9 = _txtInput_3;
		location = new Point(136, 136);
		((Control)txtInput_9).Location = location;
		((TextBoxBase)_txtInput_3).MaxLength = 0;
		((Control)_txtInput_3).Name = "_txtInput_3";
		((Control)_txtInput_3).RightToLeft = (RightToLeft)0;
		TextBox txtInput_10 = _txtInput_3;
		size = new Size(97, 20);
		((Control)txtInput_10).Size = size;
		((Control)_txtInput_3).TabIndex = 3;
		_txtInput_2.AcceptsReturn = true;
		((TextBoxBase)_txtInput_2).BackColor = SystemColors.Window;
		((Control)_txtInput_2).Cursor = Cursors.IBeam;
		((Control)_txtInput_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtInput_2).ForeColor = SystemColors.WindowText;
		txtInput.SetIndex(_txtInput_2, (short)2);
		TextBox txtInput_11 = _txtInput_2;
		location = new Point(312, 104);
		((Control)txtInput_11).Location = location;
		((TextBoxBase)_txtInput_2).MaxLength = 0;
		((Control)_txtInput_2).Name = "_txtInput_2";
		((Control)_txtInput_2).RightToLeft = (RightToLeft)0;
		TextBox txtInput_12 = _txtInput_2;
		size = new Size(73, 20);
		((Control)txtInput_12).Size = size;
		((Control)_txtInput_2).TabIndex = 2;
		_txtInput_1.AcceptsReturn = true;
		((TextBoxBase)_txtInput_1).BackColor = SystemColors.Window;
		((Control)_txtInput_1).Cursor = Cursors.IBeam;
		((Control)_txtInput_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtInput_1).ForeColor = SystemColors.WindowText;
		txtInput.SetIndex(_txtInput_1, (short)1);
		TextBox txtInput_13 = _txtInput_1;
		location = new Point(136, 104);
		((Control)txtInput_13).Location = location;
		((TextBoxBase)_txtInput_1).MaxLength = 0;
		((Control)_txtInput_1).Name = "_txtInput_1";
		((Control)_txtInput_1).RightToLeft = (RightToLeft)0;
		TextBox txtInput_14 = _txtInput_1;
		size = new Size(97, 20);
		((Control)txtInput_14).Size = size;
		((Control)_txtInput_1).TabIndex = 1;
		_txtInput_0.AcceptsReturn = true;
		((TextBoxBase)_txtInput_0).BackColor = SystemColors.Window;
		((Control)_txtInput_0).Cursor = Cursors.IBeam;
		((Control)_txtInput_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtInput_0).ForeColor = SystemColors.WindowText;
		txtInput.SetIndex(_txtInput_0, (short)0);
		TextBox txtInput_15 = _txtInput_0;
		location = new Point(136, 72);
		((Control)txtInput_15).Location = location;
		((TextBoxBase)_txtInput_0).MaxLength = 0;
		((Control)_txtInput_0).Name = "_txtInput_0";
		((Control)_txtInput_0).RightToLeft = (RightToLeft)0;
		TextBox txtInput_16 = _txtInput_0;
		size = new Size(249, 20);
		((Control)txtInput_16).Size = size;
		((Control)_txtInput_0).TabIndex = 0;
		((ButtonBase)cmdOk).BackColor = SystemColors.Control;
		((Control)cmdOk).Cursor = Cursors.Default;
		((Control)cmdOk).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdOk).ForeColor = SystemColors.ControlText;
		Button obj5 = cmdOk;
		location = new Point(184, 256);
		((Control)obj5).Location = location;
		((Control)cmdOk).Name = "cmdOk";
		((Control)cmdOk).RightToLeft = (RightToLeft)0;
		Button obj6 = cmdOk;
		size = new Size(81, 25);
		((Control)obj6).Size = size;
		((Control)cmdOk).TabIndex = 8;
		((ButtonBase)cmdOk).Text = "Ok";
		((ButtonBase)cmdOk).UseVisualStyleBackColor = false;
		((Control)_Label1_7).BackColor = SystemColors.Control;
		((Control)_Label1_7).Cursor = Cursors.Default;
		((Control)_Label1_7).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_7).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_7, (short)7);
		Label label1_ = _Label1_7;
		location = new Point(16, 168);
		((Control)label1_).Location = location;
		((Control)_Label1_7).Name = "_Label1_7";
		((Control)_Label1_7).RightToLeft = (RightToLeft)0;
		Label label1_2 = _Label1_7;
		size = new Size(113, 17);
		((Control)label1_2).Size = size;
		((Control)_Label1_7).TabIndex = 27;
		_Label1_7.Text = "Exposure Limit Type: ";
		_Label1_7.TextAlign = (ContentAlignment)4;
		((Control)_Label1_6).BackColor = SystemColors.Control;
		((Control)_Label1_6).Cursor = Cursors.Default;
		((Control)_Label1_6).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_6).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_6, (short)6);
		Label label1_3 = _Label1_6;
		location = new Point(16, 216);
		((Control)label1_3).Location = location;
		((Control)_Label1_6).Name = "_Label1_6";
		((Control)_Label1_6).RightToLeft = (RightToLeft)0;
		Label label1_4 = _Label1_6;
		size = new Size(113, 17);
		((Control)label1_4).Size = size;
		((Control)_Label1_6).TabIndex = 26;
		_Label1_6.Text = "Type of Material: ";
		_Label1_6.TextAlign = (ContentAlignment)4;
		((Control)_Label1_5).BackColor = SystemColors.Control;
		((Control)_Label1_5).Cursor = Cursors.Default;
		((Control)_Label1_5).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_5).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_5, (short)5);
		Label label1_5 = _Label1_5;
		location = new Point(240, 136);
		((Control)label1_5).Location = location;
		((Control)_Label1_5).Name = "_Label1_5";
		((Control)_Label1_5).RightToLeft = (RightToLeft)0;
		Label label1_6 = _Label1_5;
		size = new Size(65, 17);
		((Control)label1_6).Size = size;
		((Control)_Label1_5).TabIndex = 25;
		_Label1_5.Text = "Units:";
		_Label1_5.TextAlign = (ContentAlignment)4;
		((Control)_Label1_4).BackColor = SystemColors.Control;
		((Control)_Label1_4).Cursor = Cursors.Default;
		((Control)_Label1_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_4).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_4, (short)4);
		Label label1_7 = _Label1_4;
		location = new Point(240, 104);
		((Control)label1_7).Location = location;
		((Control)_Label1_4).Name = "_Label1_4";
		((Control)_Label1_4).RightToLeft = (RightToLeft)0;
		Label label1_8 = _Label1_4;
		size = new Size(65, 17);
		((Control)label1_8).Size = size;
		((Control)_Label1_4).TabIndex = 24;
		_Label1_4.Text = "Units:";
		_Label1_4.TextAlign = (ContentAlignment)4;
		((Control)_Label1_3).BackColor = SystemColors.Control;
		((Control)_Label1_3).Cursor = Cursors.Default;
		((Control)_Label1_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_3).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_3, (short)3);
		Label label1_9 = _Label1_3;
		location = new Point(16, 192);
		((Control)label1_9).Location = location;
		((Control)_Label1_3).Name = "_Label1_3";
		((Control)_Label1_3).RightToLeft = (RightToLeft)0;
		Label label1_10 = _Label1_3;
		size = new Size(113, 17);
		((Control)label1_10).Size = size;
		((Control)_Label1_3).TabIndex = 23;
		_Label1_3.Text = "Reference:";
		_Label1_3.TextAlign = (ContentAlignment)4;
		((Control)_Label1_1).BackColor = SystemColors.Control;
		((Control)_Label1_1).Cursor = Cursors.Default;
		((Control)_Label1_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_1).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_1, (short)1);
		Label label1_11 = _Label1_1;
		location = new Point(16, 136);
		((Control)label1_11).Location = location;
		((Control)_Label1_1).Name = "_Label1_1";
		((Control)_Label1_1).RightToLeft = (RightToLeft)0;
		Label label1_12 = _Label1_1;
		size = new Size(113, 17);
		((Control)label1_12).Size = size;
		((Control)_Label1_1).TabIndex = 22;
		_Label1_1.Text = "Exposure Limit:";
		_Label1_1.TextAlign = (ContentAlignment)4;
		((Control)_Label1_0).BackColor = SystemColors.Control;
		((Control)_Label1_0).Cursor = Cursors.Default;
		((Control)_Label1_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_0).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_0, (short)0);
		Label label1_13 = _Label1_0;
		location = new Point(16, 104);
		((Control)label1_13).Location = location;
		((Control)_Label1_0).Name = "_Label1_0";
		((Control)_Label1_0).RightToLeft = (RightToLeft)0;
		Label label1_14 = _Label1_0;
		size = new Size(113, 17);
		((Control)label1_14).Size = size;
		((Control)_Label1_0).TabIndex = 21;
		_Label1_0.Text = "Concentration:";
		_Label1_0.TextAlign = (ContentAlignment)4;
		((Control)_Label1_2).BackColor = SystemColors.Control;
		((Control)_Label1_2).Cursor = Cursors.Default;
		((Control)_Label1_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_2).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_2, (short)2);
		Label label1_15 = _Label1_2;
		location = new Point(16, 72);
		((Control)label1_15).Location = location;
		((Control)_Label1_2).Name = "_Label1_2";
		((Control)_Label1_2).RightToLeft = (RightToLeft)0;
		Label label1_16 = _Label1_2;
		size = new Size(113, 17);
		((Control)label1_16).Size = size;
		((Control)_Label1_2).TabIndex = 20;
		_Label1_2.Text = "Material:";
		_Label1_2.TextAlign = (ContentAlignment)4;
		((Control)_lblInstructions_1).BackColor = SystemColors.Control;
		((Control)_lblInstructions_1).Cursor = Cursors.Default;
		((Control)_lblInstructions_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblInstructions_1).ForeColor = SystemColors.ControlText;
		lblInstructions.SetIndex(_lblInstructions_1, (short)1);
		Label lblInstructions_ = _lblInstructions_1;
		location = new Point(16, 24);
		((Control)lblInstructions_).Location = location;
		((Control)_lblInstructions_1).Name = "_lblInstructions_1";
		((Control)_lblInstructions_1).RightToLeft = (RightToLeft)0;
		Label lblInstructions_2 = _lblInstructions_1;
		size = new Size(521, 41);
		((Control)lblInstructions_2).Size = size;
		((Control)_lblInstructions_1).TabIndex = 19;
		_lblInstructions_1.Text = "xxx";
		((Control)fraView).BackColor = SystemColors.Control;
		((Control)fraView).Controls.Add((Control)(object)cmdModify);
		((Control)fraView).Controls.Add((Control)(object)cmdClose);
		((Control)fraView).Controls.Add((Control)(object)cmdCancel);
		((Control)fraView).Controls.Add((Control)(object)cmdAdd);
		((Control)fraView).Controls.Add((Control)(object)cmdRemove);
		((Control)fraView).Controls.Add((Control)(object)msfTlv);
		((Control)fraView).Controls.Add((Control)(object)_lblInstructions_0);
		((Control)fraView).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)fraView).ForeColor = SystemColors.ControlText;
		GroupBox obj7 = fraView;
		location = new Point(8, 8);
		((Control)obj7).Location = location;
		((Control)fraView).Name = "fraView";
		((Control)fraView).RightToLeft = (RightToLeft)0;
		GroupBox obj8 = fraView;
		size = new Size(545, 297);
		((Control)obj8).Size = size;
		((Control)fraView).TabIndex = 16;
		fraView.TabStop = false;
		((ButtonBase)cmdModify).BackColor = SystemColors.Control;
		((Control)cmdModify).Cursor = Cursors.Default;
		((Control)cmdModify).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdModify).ForeColor = SystemColors.ControlText;
		Button obj9 = cmdModify;
		location = new Point(232, 248);
		((Control)obj9).Location = location;
		((Control)cmdModify).Name = "cmdModify";
		((Control)cmdModify).RightToLeft = (RightToLeft)0;
		Button obj10 = cmdModify;
		size = new Size(81, 25);
		((Control)obj10).Size = size;
		((Control)cmdModify).TabIndex = 13;
		((ButtonBase)cmdModify).Text = "&Modify";
		((ButtonBase)cmdModify).UseVisualStyleBackColor = false;
		((ButtonBase)cmdClose).BackColor = SystemColors.Control;
		((Control)cmdClose).Cursor = Cursors.Default;
		((Control)cmdClose).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdClose).ForeColor = SystemColors.ControlText;
		Button obj11 = cmdClose;
		location = new Point(56, 248);
		((Control)obj11).Location = location;
		((Control)cmdClose).Name = "cmdClose";
		((Control)cmdClose).RightToLeft = (RightToLeft)0;
		Button obj12 = cmdClose;
		size = new Size(81, 25);
		((Control)obj12).Size = size;
		((Control)cmdClose).TabIndex = 11;
		((ButtonBase)cmdClose).Text = "Close";
		((ButtonBase)cmdClose).UseVisualStyleBackColor = false;
		((ButtonBase)cmdCancel).BackColor = SystemColors.Control;
		((Control)cmdCancel).Cursor = Cursors.Default;
		((Control)cmdCancel).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCancel).ForeColor = SystemColors.ControlText;
		Button obj13 = cmdCancel;
		location = new Point(408, 248);
		((Control)obj13).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		((Control)cmdCancel).RightToLeft = (RightToLeft)0;
		Button obj14 = cmdCancel;
		size = new Size(81, 25);
		((Control)obj14).Size = size;
		((Control)cmdCancel).TabIndex = 15;
		((ButtonBase)cmdCancel).Text = "Cancel";
		((ButtonBase)cmdCancel).UseVisualStyleBackColor = false;
		((ButtonBase)cmdAdd).BackColor = SystemColors.Control;
		((Control)cmdAdd).Cursor = Cursors.Default;
		((Control)cmdAdd).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdAdd).ForeColor = SystemColors.ControlText;
		Button obj15 = cmdAdd;
		location = new Point(144, 248);
		((Control)obj15).Location = location;
		((Control)cmdAdd).Name = "cmdAdd";
		((Control)cmdAdd).RightToLeft = (RightToLeft)0;
		Button obj16 = cmdAdd;
		size = new Size(81, 25);
		((Control)obj16).Size = size;
		((Control)cmdAdd).TabIndex = 12;
		((ButtonBase)cmdAdd).Text = "&Add";
		((ButtonBase)cmdAdd).UseVisualStyleBackColor = false;
		((ButtonBase)cmdRemove).BackColor = SystemColors.Control;
		((Control)cmdRemove).Cursor = Cursors.Default;
		((Control)cmdRemove).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdRemove).ForeColor = SystemColors.ControlText;
		Button obj17 = cmdRemove;
		location = new Point(320, 248);
		((Control)obj17).Location = location;
		((Control)cmdRemove).Name = "cmdRemove";
		((Control)cmdRemove).RightToLeft = (RightToLeft)0;
		Button obj18 = cmdRemove;
		size = new Size(81, 25);
		((Control)obj18).Size = size;
		((Control)cmdRemove).TabIndex = 14;
		((ButtonBase)cmdRemove).Text = "&Remove";
		((ButtonBase)cmdRemove).UseVisualStyleBackColor = false;
		AxMSFlexGrid obj19 = msfTlv;
		location = new Point(16, 72);
		((Control)obj19).Location = location;
		((Control)msfTlv).Name = "msfTlv";
		((AxHost)msfTlv).OcxState = (State)componentResourceManager.GetObject("msfTlv.OcxState");
		AxMSFlexGrid obj20 = msfTlv;
		size = new Size(513, 161);
		((Control)obj20).Size = size;
		((Control)msfTlv).TabIndex = 10;
		((Control)_lblInstructions_0).BackColor = SystemColors.Control;
		((Control)_lblInstructions_0).Cursor = Cursors.Default;
		((Control)_lblInstructions_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblInstructions_0).ForeColor = SystemColors.ControlText;
		lblInstructions.SetIndex(_lblInstructions_0, (short)0);
		Label lblInstructions_3 = _lblInstructions_0;
		location = new Point(16, 24);
		((Control)lblInstructions_3).Location = location;
		((Control)_lblInstructions_0).Name = "_lblInstructions_0";
		((Control)_lblInstructions_0).RightToLeft = (RightToLeft)0;
		Label lblInstructions_4 = _lblInstructions_0;
		size = new Size(521, 41);
		((Control)lblInstructions_4).Size = size;
		((Control)_lblInstructions_0).TabIndex = 17;
		_lblInstructions_0.Text = "xxx";
		size = new Size(5, 13);
		((Form)this).AutoScaleBaseSize = size;
		((Form)this).BackColor = SystemColors.Control;
		size = new Size(562, 319);
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
		((Control)this).Name = "frmMDUpdMsdsTLV";
		((Control)this).RightToLeft = (RightToLeft)0;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Update Exposure Limits";
		((Control)fraUpdate).ResumeLayout(false);
		((Control)fraUpdate).PerformLayout();
		((Control)fraView).ResumeLayout(false);
		((ISupportInitialize)msfTlv).EndInit();
		((ISupportInitialize)Label1).EndInit();
		((ISupportInitialize)lblInstructions).EndInit();
		((ISupportInitialize)txtInput).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void cmdAdd_Click(object eventSender, EventArgs eventArgs)
	{
		((Control)fraView).Visible = false;
		((Control)fraUpdate).Visible = true;
		((Form)this).Text = "Add Exposure Limit";
		checked
		{
			short num = (short)(((BaseControlArray)txtInput).Count() - 1);
			short num2 = 0;
			while (true)
			{
				short num3 = num2;
				short num4 = num;
				if (num3 <= num4)
				{
					txtInput[num2].Text = "";
					num2 = (short)unchecked(num2 + 1);
					continue;
				}
				break;
			}
		}
	}

	private void cmdCancel_Click(object eventSender, EventArgs eventArgs)
	{
		((Form)this).Close();
	}

	private void cmdClose_Click(object eventSender, EventArgs eventArgs)
	{
		UpdateFrmMain();
		((Form)this).Close();
	}

	private void cmdModify_Click(object eventSender, EventArgs eventArgs)
	{
		txtInput[(short)0].Text = msfTlv[msfTlv.Row, 0];
		txtInput[(short)5].Text = msfTlv[msfTlv.Row, 4];
		checked
		{
			short num = (short)Strings.InStr(1, msfTlv[msfTlv.Row, 1], " ", (CompareMethod)0);
			if (num > 1)
			{
				txtInput[(short)1].Text = Strings.Left(msfTlv[msfTlv.Row, 1], num - 1);
				txtInput[(short)2].Text = Strings.Mid(msfTlv[msfTlv.Row, 1], num + 1);
			}
			else
			{
				txtInput[(short)1].Text = "";
				txtInput[(short)2].Text = "";
			}
			num = (short)Strings.InStr(1, msfTlv[msfTlv.Row, 2], " ", (CompareMethod)0);
			if (num > 1)
			{
				txtInput[(short)3].Text = Strings.Left(msfTlv[msfTlv.Row, 2], num - 1);
				txtInput[(short)4].Text = Strings.Mid(msfTlv[msfTlv.Row, 2], num + 1);
			}
			else
			{
				txtInput[(short)3].Text = "";
				txtInput[(short)4].Text = "";
			}
			txtInput[(short)6].Text = msfTlv[msfTlv.Row, 5];
			txtInput[(short)7].Text = msfTlv[msfTlv.Row, 3];
			((Control)fraView).Visible = false;
			((Control)fraUpdate).Visible = true;
			((Form)this).Text = "Modify Exposure Limit";
		}
	}

	private void cmdOk_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (Strings.Len(txtInput[(short)0].Text) == 0)
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Please enter a material.  Material is a required field.", (MsgBoxStyle)64, (object)"Required Information Missing");
			((Control)txtInput[(short)0]).Focus();
			return;
		}
		TextBox pTB = txtInput[(short)1];
		string pField = "Concentration";
		if (!ChemStrX.VerifyNumericTextBox(ref pTB, ref pField))
		{
			return;
		}
		pTB = txtInput[(short)3];
		pField = "Exposure Limit";
		if (!ChemStrX.VerifyNumericTextBox(ref pTB, ref pField))
		{
			return;
		}
		if (Operators.CompareString(Strings.Left(((Form)this).Text, 3), "Add", false) == 0)
		{
			msfTlv.AddItem(txtInput[(short)0].Text + "\t" + txtInput[(short)1].Text + " " + txtInput[(short)2].Text + "\t" + txtInput[(short)3].Text + " " + txtInput[(short)4].Text + "\t" + txtInput[(short)7].Text + "\t" + txtInput[(short)5].Text + "\t" + txtInput[(short)6].Text);
			if (Operators.CompareString(msfTlv[1, 0], "", false) == 0)
			{
				msfTlv.RemoveItem(1);
			}
		}
		else
		{
			msfTlv[msfTlv.Row, 0] = txtInput[(short)0].Text;
			msfTlv[msfTlv.Row, 1] = txtInput[(short)1].Text + " " + txtInput[(short)2].Text;
			msfTlv[msfTlv.Row, 2] = txtInput[(short)3].Text + " " + txtInput[(short)4].Text;
			msfTlv[msfTlv.Row, 4] = txtInput[(short)5].Text;
			msfTlv[msfTlv.Row, 5] = txtInput[(short)6].Text;
			msfTlv[msfTlv.Row, 3] = txtInput[(short)7].Text;
		}
		((Control)fraView).Visible = true;
		((Control)fraUpdate).Visible = false;
		((Form)this).Text = "Update Exposure Limits";
		Globals_Renamed.gblIWasChanged = true;
	}

	private void cmdRemove_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Invalid comparison between Unknown and I4
		if (Operators.CompareString(msfTlv[msfTlv.Row, 0], "", false) == 0 || (int)Interaction.MsgBox((object)"Are you sure you want to delete the selected exposure limit?", (MsgBoxStyle)36, (object)"Confirm Delete") != 6)
		{
			return;
		}
		checked
		{
			if (msfTlv.Rows == 2)
			{
				short num = (short)(msfTlv.Cols - 1);
				short num2 = 0;
				while (true)
				{
					short num3 = num2;
					short num4 = num;
					if (num3 <= num4)
					{
						msfTlv[1, unchecked((int)num2)] = "";
						num2 = (short)unchecked(num2 + 1);
						continue;
					}
					break;
				}
			}
			else
			{
				msfTlv.RemoveItem(msfTlv.Row);
			}
			Globals_Renamed.gblIWasChanged = true;
		}
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
		short num = 0;
		checked
		{
			short num2;
			short num3;
			do
			{
				command.Parameters.Append(command.CreateParameter("pID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, num + 30));
				Command command2 = command;
				object RecordsAffected = Missing.Value;
				object Parameters = Missing.Value;
				recordset = command2.Execute(out RecordsAffected, ref Parameters);
				command.Parameters.Delete("pID");
				lblInstructions[num].Text = Conversions.ToString(recordset.Fields[0].Value);
				recordset.Close();
				num = (short)unchecked(num + 1);
				num2 = num;
				num3 = 1;
			}
			while (num2 <= num3);
			recordset = null;
			command = null;
			AxMSFlexGrid pGridCopy = frmMain.DefInstance.msfTlv;
			AxMSFlexGrid pGridTo = msfTlv;
			ChemStrX.CloneFlexGrid(ref pGridCopy, ref pGridTo);
			msfTlv = pGridTo;
			return true;
		}
	}

	private void UpdateFrmMain()
	{
		AxMSFlexGrid pGridCopy = msfTlv;
		AxMSFlexGrid pGridTo = frmMain.DefInstance.msfTlv;
		ChemStrX.CloneFlexGrid(ref pGridCopy, ref pGridTo);
		msfTlv = pGridCopy;
	}

	private void cmdCancelTwo_Click(object sender, EventArgs e)
	{
		((Control)fraView).Visible = true;
		((Control)fraUpdate).Visible = false;
		((Form)this).Text = "Update Exposure Limits";
	}
}
