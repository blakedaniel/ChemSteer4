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

internal class frmMDUpdPD : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("txtSearch")]
	private TextBox _txtSearch;

	[AccessedThroughProperty("cmdSearch")]
	private Button _cmdSearch;

	[AccessedThroughProperty("lstSelected")]
	private ListBox _lstSelected;

	[AccessedThroughProperty("lstAvailable")]
	private ListBox _lstAvailable;

	[AccessedThroughProperty("cmdSelect")]
	private Button _cmdSelect;

	[AccessedThroughProperty("cmdDeselect")]
	private Button _cmdDeselect;

	[AccessedThroughProperty("cmdClose")]
	private Button _cmdClose;

	[AccessedThroughProperty("_Label4_4")]
	private Label __Label4_4;

	[AccessedThroughProperty("_Label4_2")]
	private Label __Label4_2;

	[AccessedThroughProperty("_Label4_1")]
	private Label __Label4_1;

	[AccessedThroughProperty("_lblInstructions_1")]
	private Label __lblInstructions_1;

	[AccessedThroughProperty("fraNAICS")]
	private GroupBox _fraNAICS;

	[AccessedThroughProperty("cmdOk")]
	private Button _cmdOk;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("txtPD")]
	private TextBox _txtPD;

	[AccessedThroughProperty("cmdAdd")]
	private Button _cmdAdd;

	[AccessedThroughProperty("msfNaics")]
	private AxMSFlexGrid _msfNaics;

	[AccessedThroughProperty("_Label4_3")]
	private Label __Label4_3;

	[AccessedThroughProperty("_Label4_0")]
	private Label __Label4_0;

	[AccessedThroughProperty("_lblInstructions_0")]
	private Label __lblInstructions_0;

	[AccessedThroughProperty("fraMain")]
	private GroupBox _fraMain;

	[AccessedThroughProperty("lblOp")]
	private Label _lblOp;

	[AccessedThroughProperty("Label4")]
	private LabelArray _Label4;

	[AccessedThroughProperty("lblInstructions")]
	private LabelArray _lblInstructions;

	private static frmMDUpdPD m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	public virtual TextBox txtSearch
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSearch;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSearch = value;
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

	public virtual ListBox lstSelected
	{
		[DebuggerNonUserCode]
		get
		{
			return _lstSelected;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = lstSelected_DoubleClick;
			if (_lstSelected != null)
			{
				((Control)_lstSelected).DoubleClick -= eventHandler;
			}
			_lstSelected = value;
			if (_lstSelected != null)
			{
				((Control)_lstSelected).DoubleClick += eventHandler;
			}
		}
	}

	public virtual ListBox lstAvailable
	{
		[DebuggerNonUserCode]
		get
		{
			return _lstAvailable;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = lstAvailable_DoubleClick;
			if (_lstAvailable != null)
			{
				((Control)_lstAvailable).DoubleClick -= eventHandler;
			}
			_lstAvailable = value;
			if (_lstAvailable != null)
			{
				((Control)_lstAvailable).DoubleClick += eventHandler;
			}
		}
	}

	public virtual Button cmdSelect
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdSelect;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdSelect_Click;
			if (_cmdSelect != null)
			{
				((Control)_cmdSelect).Click -= eventHandler;
			}
			_cmdSelect = value;
			if (_cmdSelect != null)
			{
				((Control)_cmdSelect).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdDeselect
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdDeselect;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdDeselect_Click;
			if (_cmdDeselect != null)
			{
				((Control)_cmdDeselect).Click -= eventHandler;
			}
			_cmdDeselect = value;
			if (_cmdDeselect != null)
			{
				((Control)_cmdDeselect).Click += eventHandler;
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

	public virtual GroupBox fraNAICS
	{
		[DebuggerNonUserCode]
		get
		{
			return _fraNAICS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_fraNAICS = value;
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

	public virtual TextBox txtPD
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtPD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtPD = value;
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

	public virtual AxMSFlexGrid msfNaics
	{
		[DebuggerNonUserCode]
		get
		{
			return _msfNaics;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_msfNaics = value;
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

	public virtual GroupBox fraMain
	{
		[DebuggerNonUserCode]
		get
		{
			return _fraMain;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_fraMain = value;
		}
	}

	public virtual Label lblOp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblOp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblOp = value;
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

	public static frmMDUpdPD DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmMDUpdPD();
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

	public frmMDUpdPD()
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
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected O, but got Unknown
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected O, but got Unknown
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Expected O, but got Unknown
		//IL_0466: Unknown result type (might be due to invalid IL or missing references)
		//IL_0470: Expected O, but got Unknown
		//IL_0536: Unknown result type (might be due to invalid IL or missing references)
		//IL_0540: Expected O, but got Unknown
		//IL_0606: Unknown result type (might be due to invalid IL or missing references)
		//IL_0610: Expected O, but got Unknown
		//IL_06d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dd: Expected O, but got Unknown
		//IL_07a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b0: Expected O, but got Unknown
		//IL_0879: Unknown result type (might be due to invalid IL or missing references)
		//IL_0883: Expected O, but got Unknown
		//IL_094c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0956: Expected O, but got Unknown
		//IL_0a20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2a: Expected O, but got Unknown
		//IL_0af7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b01: Expected O, but got Unknown
		//IL_0bd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdb: Expected O, but got Unknown
		//IL_0d4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d59: Expected O, but got Unknown
		//IL_0e11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1b: Expected O, but got Unknown
		//IL_0ef2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0efc: Expected O, but got Unknown
		//IL_0fd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fdd: Expected O, but got Unknown
		//IL_10ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b8: Expected O, but got Unknown
		//IL_1183: Unknown result type (might be due to invalid IL or missing references)
		//IL_118d: Expected O, but got Unknown
		//IL_11f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_11fb: Expected O, but got Unknown
		//IL_12c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d1: Expected O, but got Unknown
		//IL_13a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_13aa: Expected O, but got Unknown
		//IL_1476: Unknown result type (might be due to invalid IL or missing references)
		//IL_1480: Expected O, but got Unknown
		//IL_159c: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a6: Expected O, but got Unknown
		//IL_15bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_15c5: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMDUpdPD));
		ToolTip1 = new ToolTip(components);
		fraNAICS = new GroupBox();
		txtSearch = new TextBox();
		cmdSearch = new Button();
		lstSelected = new ListBox();
		lstAvailable = new ListBox();
		cmdSelect = new Button();
		cmdDeselect = new Button();
		cmdClose = new Button();
		_Label4_4 = new Label();
		_Label4_2 = new Label();
		_Label4_1 = new Label();
		_lblInstructions_1 = new Label();
		fraMain = new GroupBox();
		cmdOk = new Button();
		cmdCancel = new Button();
		txtPD = new TextBox();
		cmdAdd = new Button();
		msfNaics = new AxMSFlexGrid();
		_Label4_3 = new Label();
		_Label4_0 = new Label();
		_lblInstructions_0 = new Label();
		lblOp = new Label();
		Label4 = new LabelArray(components);
		lblInstructions = new LabelArray(components);
		((Control)fraNAICS).SuspendLayout();
		((Control)fraMain).SuspendLayout();
		((ISupportInitialize)msfNaics).BeginInit();
		((ISupportInitialize)Label4).BeginInit();
		((ISupportInitialize)lblInstructions).BeginInit();
		((Control)this).SuspendLayout();
		((Control)fraNAICS).BackColor = SystemColors.Control;
		((Control)fraNAICS).Controls.Add((Control)(object)txtSearch);
		((Control)fraNAICS).Controls.Add((Control)(object)cmdSearch);
		((Control)fraNAICS).Controls.Add((Control)(object)lstSelected);
		((Control)fraNAICS).Controls.Add((Control)(object)lstAvailable);
		((Control)fraNAICS).Controls.Add((Control)(object)cmdSelect);
		((Control)fraNAICS).Controls.Add((Control)(object)cmdDeselect);
		((Control)fraNAICS).Controls.Add((Control)(object)cmdClose);
		((Control)fraNAICS).Controls.Add((Control)(object)_Label4_4);
		((Control)fraNAICS).Controls.Add((Control)(object)_Label4_2);
		((Control)fraNAICS).Controls.Add((Control)(object)_Label4_1);
		((Control)fraNAICS).Controls.Add((Control)(object)_lblInstructions_1);
		((Control)fraNAICS).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)fraNAICS).ForeColor = SystemColors.ControlText;
		GroupBox obj = fraNAICS;
		Point location = new Point(0, 32);
		((Control)obj).Location = location;
		((Control)fraNAICS).Name = "fraNAICS";
		((Control)fraNAICS).RightToLeft = (RightToLeft)0;
		GroupBox obj2 = fraNAICS;
		Size size = new Size(481, 385);
		((Control)obj2).Size = size;
		((Control)fraNAICS).TabIndex = 16;
		fraNAICS.TabStop = false;
		((Control)fraNAICS).Visible = false;
		txtSearch.AcceptsReturn = true;
		((TextBoxBase)txtSearch).BackColor = SystemColors.Window;
		((Control)txtSearch).Cursor = Cursors.IBeam;
		((Control)txtSearch).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtSearch).ForeColor = SystemColors.WindowText;
		TextBox obj3 = txtSearch;
		location = new Point(80, 72);
		((Control)obj3).Location = location;
		((TextBoxBase)txtSearch).MaxLength = 20;
		((Control)txtSearch).Name = "txtSearch";
		((Control)txtSearch).RightToLeft = (RightToLeft)0;
		txtSearch.ScrollBars = (ScrollBars)2;
		TextBox obj4 = txtSearch;
		size = new Size(137, 20);
		((Control)obj4).Size = size;
		((Control)txtSearch).TabIndex = 0;
		((ButtonBase)cmdSearch).BackColor = SystemColors.Control;
		((Control)cmdSearch).Cursor = Cursors.Default;
		((Control)cmdSearch).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdSearch).ForeColor = SystemColors.ControlText;
		Button obj5 = cmdSearch;
		location = new Point(232, 72);
		((Control)obj5).Location = location;
		((Control)cmdSearch).Name = "cmdSearch";
		((Control)cmdSearch).RightToLeft = (RightToLeft)0;
		Button obj6 = cmdSearch;
		size = new Size(81, 25);
		((Control)obj6).Size = size;
		((Control)cmdSearch).TabIndex = 1;
		((ButtonBase)cmdSearch).Text = "Search";
		((ButtonBase)cmdSearch).UseVisualStyleBackColor = false;
		lstSelected.BackColor = SystemColors.Window;
		((Control)lstSelected).Cursor = Cursors.Default;
		lstSelected.Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		lstSelected.ForeColor = SystemColors.WindowText;
		lstSelected.ItemHeight = 14;
		ListBox obj7 = lstSelected;
		location = new Point(16, 256);
		((Control)obj7).Location = location;
		((Control)lstSelected).Name = "lstSelected";
		lstSelected.RightToLeft = (RightToLeft)0;
		ListBox obj8 = lstSelected;
		size = new Size(457, 60);
		((Control)obj8).Size = size;
		lstSelected.Sorted = true;
		((Control)lstSelected).TabIndex = 5;
		lstAvailable.BackColor = SystemColors.Window;
		((Control)lstAvailable).Cursor = Cursors.Default;
		lstAvailable.Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		lstAvailable.ForeColor = SystemColors.WindowText;
		lstAvailable.ItemHeight = 14;
		ListBox obj9 = lstAvailable;
		location = new Point(16, 120);
		((Control)obj9).Location = location;
		((Control)lstAvailable).Name = "lstAvailable";
		lstAvailable.RightToLeft = (RightToLeft)0;
		ListBox obj10 = lstAvailable;
		size = new Size(457, 60);
		((Control)obj10).Size = size;
		lstAvailable.Sorted = true;
		((Control)lstAvailable).TabIndex = 2;
		((ButtonBase)cmdSelect).BackColor = SystemColors.Control;
		((Control)cmdSelect).Cursor = Cursors.Default;
		((Control)cmdSelect).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdSelect).ForeColor = SystemColors.ControlText;
		Button obj11 = cmdSelect;
		location = new Point(160, 208);
		((Control)obj11).Location = location;
		((Control)cmdSelect).Name = "cmdSelect";
		((Control)cmdSelect).RightToLeft = (RightToLeft)0;
		Button obj12 = cmdSelect;
		size = new Size(81, 25);
		((Control)obj12).Size = size;
		((Control)cmdSelect).TabIndex = 3;
		((ButtonBase)cmdSelect).Text = "&Select";
		((ButtonBase)cmdSelect).UseVisualStyleBackColor = false;
		((ButtonBase)cmdDeselect).BackColor = SystemColors.Control;
		((Control)cmdDeselect).Cursor = Cursors.Default;
		((Control)cmdDeselect).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdDeselect).ForeColor = SystemColors.ControlText;
		Button obj13 = cmdDeselect;
		location = new Point(256, 208);
		((Control)obj13).Location = location;
		((Control)cmdDeselect).Name = "cmdDeselect";
		((Control)cmdDeselect).RightToLeft = (RightToLeft)0;
		Button obj14 = cmdDeselect;
		size = new Size(81, 25);
		((Control)obj14).Size = size;
		((Control)cmdDeselect).TabIndex = 4;
		((ButtonBase)cmdDeselect).Text = "&Deselect";
		((ButtonBase)cmdDeselect).UseVisualStyleBackColor = false;
		((ButtonBase)cmdClose).BackColor = SystemColors.Control;
		((Control)cmdClose).Cursor = Cursors.Default;
		((Control)cmdClose).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdClose).ForeColor = SystemColors.ControlText;
		Button obj15 = cmdClose;
		location = new Point(200, 344);
		((Control)obj15).Location = location;
		((Control)cmdClose).Name = "cmdClose";
		((Control)cmdClose).RightToLeft = (RightToLeft)0;
		Button obj16 = cmdClose;
		size = new Size(81, 25);
		((Control)obj16).Size = size;
		((Control)cmdClose).TabIndex = 6;
		((ButtonBase)cmdClose).Text = "&Close";
		((ButtonBase)cmdClose).UseVisualStyleBackColor = false;
		((Control)_Label4_4).BackColor = SystemColors.Control;
		((Control)_Label4_4).Cursor = Cursors.Default;
		((Control)_Label4_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_4).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_4, (short)4);
		Label label4_ = _Label4_4;
		location = new Point(16, 72);
		((Control)label4_).Location = location;
		((Control)_Label4_4).Name = "_Label4_4";
		((Control)_Label4_4).RightToLeft = (RightToLeft)0;
		Label label4_2 = _Label4_4;
		size = new Size(65, 17);
		((Control)label4_2).Size = size;
		((Control)_Label4_4).TabIndex = 21;
		_Label4_4.Text = "Search for:";
		((Control)_Label4_2).BackColor = SystemColors.Control;
		((Control)_Label4_2).Cursor = Cursors.Default;
		((Control)_Label4_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_2).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_2, (short)2);
		Label label4_3 = _Label4_2;
		location = new Point(16, 104);
		((Control)label4_3).Location = location;
		((Control)_Label4_2).Name = "_Label4_2";
		((Control)_Label4_2).RightToLeft = (RightToLeft)0;
		Label label4_4 = _Label4_2;
		size = new Size(281, 17);
		((Control)label4_4).Size = size;
		((Control)_Label4_2).TabIndex = 19;
		_Label4_2.Text = "Available NAICS not already selected";
		((Control)_Label4_1).BackColor = SystemColors.Control;
		((Control)_Label4_1).Cursor = Cursors.Default;
		((Control)_Label4_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_1).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_1, (short)1);
		Label label4_5 = _Label4_1;
		location = new Point(16, 240);
		((Control)label4_5).Location = location;
		((Control)_Label4_1).Name = "_Label4_1";
		((Control)_Label4_1).RightToLeft = (RightToLeft)0;
		Label label4_6 = _Label4_1;
		size = new Size(281, 17);
		((Control)label4_6).Size = size;
		((Control)_Label4_1).TabIndex = 18;
		_Label4_1.Text = "Selected NAICS";
		((Control)_lblInstructions_1).BackColor = SystemColors.Control;
		((Control)_lblInstructions_1).Cursor = Cursors.Default;
		((Control)_lblInstructions_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblInstructions_1).ForeColor = SystemColors.ControlText;
		lblInstructions.SetIndex(_lblInstructions_1, (short)1);
		Label lblInstructions_ = _lblInstructions_1;
		location = new Point(16, 16);
		((Control)lblInstructions_).Location = location;
		((Control)_lblInstructions_1).Name = "_lblInstructions_1";
		((Control)_lblInstructions_1).RightToLeft = (RightToLeft)0;
		Label lblInstructions_2 = _lblInstructions_1;
		size = new Size(457, 49);
		((Control)lblInstructions_2).Size = size;
		((Control)_lblInstructions_1).TabIndex = 17;
		_lblInstructions_1.Text = "xxx";
		((Control)fraMain).BackColor = SystemColors.Control;
		((Control)fraMain).Controls.Add((Control)(object)cmdOk);
		((Control)fraMain).Controls.Add((Control)(object)cmdCancel);
		((Control)fraMain).Controls.Add((Control)(object)txtPD);
		((Control)fraMain).Controls.Add((Control)(object)cmdAdd);
		((Control)fraMain).Controls.Add((Control)(object)msfNaics);
		((Control)fraMain).Controls.Add((Control)(object)_Label4_3);
		((Control)fraMain).Controls.Add((Control)(object)_Label4_0);
		((Control)fraMain).Controls.Add((Control)(object)_lblInstructions_0);
		((Control)fraMain).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)fraMain).ForeColor = SystemColors.ControlText;
		GroupBox obj17 = fraMain;
		location = new Point(0, 32);
		((Control)obj17).Location = location;
		((Control)fraMain).Name = "fraMain";
		((Control)fraMain).RightToLeft = (RightToLeft)0;
		GroupBox obj18 = fraMain;
		size = new Size(481, 385);
		((Control)obj18).Size = size;
		((Control)fraMain).TabIndex = 12;
		fraMain.TabStop = false;
		((ButtonBase)cmdOk).BackColor = SystemColors.Control;
		((Control)cmdOk).Cursor = Cursors.Default;
		((Control)cmdOk).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdOk).ForeColor = SystemColors.ControlText;
		Button obj19 = cmdOk;
		location = new Point(152, 344);
		((Control)obj19).Location = location;
		((Control)cmdOk).Name = "cmdOk";
		((Control)cmdOk).RightToLeft = (RightToLeft)0;
		Button obj20 = cmdOk;
		size = new Size(81, 25);
		((Control)obj20).Size = size;
		((Control)cmdOk).TabIndex = 9;
		((ButtonBase)cmdOk).Text = "OK";
		((ButtonBase)cmdOk).UseVisualStyleBackColor = false;
		((ButtonBase)cmdCancel).BackColor = SystemColors.Control;
		((Control)cmdCancel).Cursor = Cursors.Default;
		cmdCancel.DialogResult = (DialogResult)2;
		((Control)cmdCancel).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCancel).ForeColor = SystemColors.ControlText;
		Button obj21 = cmdCancel;
		location = new Point(248, 344);
		((Control)obj21).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		((Control)cmdCancel).RightToLeft = (RightToLeft)0;
		Button obj22 = cmdCancel;
		size = new Size(81, 25);
		((Control)obj22).Size = size;
		((Control)cmdCancel).TabIndex = 10;
		((ButtonBase)cmdCancel).Text = "Cancel";
		((ButtonBase)cmdCancel).UseVisualStyleBackColor = false;
		txtPD.AcceptsReturn = true;
		((TextBoxBase)txtPD).BackColor = SystemColors.Window;
		((Control)txtPD).Cursor = Cursors.IBeam;
		((Control)txtPD).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtPD).ForeColor = SystemColors.WindowText;
		TextBox obj23 = txtPD;
		location = new Point(8, 256);
		((Control)obj23).Location = location;
		((TextBoxBase)txtPD).MaxLength = 0;
		txtPD.Multiline = true;
		((Control)txtPD).Name = "txtPD";
		((Control)txtPD).RightToLeft = (RightToLeft)0;
		txtPD.ScrollBars = (ScrollBars)2;
		TextBox obj24 = txtPD;
		size = new Size(457, 67);
		((Control)obj24).Size = size;
		((Control)txtPD).TabIndex = 8;
		((ButtonBase)cmdAdd).BackColor = SystemColors.Control;
		((Control)cmdAdd).Cursor = Cursors.Default;
		((Control)cmdAdd).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdAdd).ForeColor = SystemColors.ControlText;
		Button obj25 = cmdAdd;
		location = new Point(392, 120);
		((Control)obj25).Location = location;
		((Control)cmdAdd).Name = "cmdAdd";
		((Control)cmdAdd).RightToLeft = (RightToLeft)0;
		Button obj26 = cmdAdd;
		size = new Size(81, 57);
		((Control)obj26).Size = size;
		((Control)cmdAdd).TabIndex = 7;
		((ButtonBase)cmdAdd).Text = "&Add / Remove NAICS";
		((ButtonBase)cmdAdd).UseVisualStyleBackColor = false;
		AxMSFlexGrid obj27 = msfNaics;
		location = new Point(8, 80);
		((Control)obj27).Location = location;
		((Control)msfNaics).Name = "msfNaics";
		((AxHost)msfNaics).OcxState = (State)componentResourceManager.GetObject("msfNaics.OcxState");
		AxMSFlexGrid obj28 = msfNaics;
		size = new Size(369, 137);
		((Control)obj28).Size = size;
		((Control)msfNaics).TabIndex = 13;
		((Control)_Label4_3).BackColor = SystemColors.Control;
		((Control)_Label4_3).Cursor = Cursors.Default;
		((Control)_Label4_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_3).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_3, (short)3);
		Label label4_7 = _Label4_3;
		location = new Point(8, 64);
		((Control)label4_7).Location = location;
		((Control)_Label4_3).Name = "_Label4_3";
		((Control)_Label4_3).RightToLeft = (RightToLeft)0;
		Label label4_8 = _Label4_3;
		size = new Size(281, 17);
		((Control)label4_8).Size = size;
		((Control)_Label4_3).TabIndex = 20;
		_Label4_3.Text = "NAICS codes associated with the operation";
		((Control)_Label4_0).BackColor = SystemColors.Control;
		((Control)_Label4_0).Cursor = Cursors.Default;
		((Control)_Label4_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_0).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_0, (short)0);
		Label label4_9 = _Label4_0;
		location = new Point(8, 240);
		((Control)label4_9).Location = location;
		((Control)_Label4_0).Name = "_Label4_0";
		((Control)_Label4_0).RightToLeft = (RightToLeft)0;
		Label label4_10 = _Label4_0;
		size = new Size(281, 17);
		((Control)label4_10).Size = size;
		((Control)_Label4_0).TabIndex = 15;
		_Label4_0.Text = "Process Description:";
		((Control)_lblInstructions_0).BackColor = SystemColors.Control;
		((Control)_lblInstructions_0).Cursor = Cursors.Default;
		((Control)_lblInstructions_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblInstructions_0).ForeColor = SystemColors.ControlText;
		lblInstructions.SetIndex(_lblInstructions_0, (short)0);
		Label lblInstructions_3 = _lblInstructions_0;
		location = new Point(8, 16);
		((Control)lblInstructions_3).Location = location;
		((Control)_lblInstructions_0).Name = "_lblInstructions_0";
		((Control)_lblInstructions_0).RightToLeft = (RightToLeft)0;
		Label lblInstructions_4 = _lblInstructions_0;
		size = new Size(417, 33);
		((Control)lblInstructions_4).Size = size;
		((Control)_lblInstructions_0).TabIndex = 14;
		_lblInstructions_0.Text = "xxx";
		((Control)lblOp).BackColor = SystemColors.Control;
		((Control)lblOp).Cursor = Cursors.Default;
		((Control)lblOp).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)lblOp).ForeColor = SystemColors.ControlText;
		Label obj29 = lblOp;
		location = new Point(8, 16);
		((Control)obj29).Location = location;
		((Control)lblOp).Name = "lblOp";
		((Control)lblOp).RightToLeft = (RightToLeft)0;
		Label obj30 = lblOp;
		size = new Size(441, 17);
		((Control)obj30).Size = size;
		((Control)lblOp).TabIndex = 11;
		lblOp.Text = "User-defined processing";
		size = new Size(5, 13);
		((Form)this).AutoScaleBaseSize = size;
		((Form)this).BackColor = SystemColors.Control;
		((Form)this).CancelButton = (IButtonControl)(object)cmdCancel;
		size = new Size(481, 421);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)fraNAICS);
		((Control)this).Controls.Add((Control)(object)fraMain);
		((Control)this).Controls.Add((Control)(object)lblOp);
		((Control)this).Cursor = Cursors.Default;
		((Control)this).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		location = new Point(250, 150);
		((Form)this).Location = location;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmMDUpdPD";
		((Control)this).RightToLeft = (RightToLeft)0;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Update Operation Description";
		((Control)fraNAICS).ResumeLayout(false);
		((Control)fraNAICS).PerformLayout();
		((Control)fraMain).ResumeLayout(false);
		((Control)fraMain).PerformLayout();
		((ISupportInitialize)msfNaics).EndInit();
		((ISupportInitialize)Label4).EndInit();
		((ISupportInitialize)lblInstructions).EndInit();
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
						short num3 = 0;
						short num4;
						short num5;
						do
						{
							command.Parameters.Append(command.CreateParameter("pID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, num3 + 21));
							Command command2 = command;
							object RecordsAffected = Missing.Value;
							object Parameters = Missing.Value;
							recordset = command2.Execute(out RecordsAffected, ref Parameters);
							command.Parameters.Delete("pID");
							lblInstructions[num3].Text = Conversions.ToString(recordset.Fields[0].Value);
							recordset.Close();
							num3 = (short)unchecked(num3 + 1);
							num4 = num3;
							num5 = 1;
						}
						while (num4 <= num5);
						recordset = null;
						command = null;
						lblOp.Text = frmMain.DefInstance._lstSelOps_0.Text;
						msfNaics.Rows = frmMain.DefInstance.msfNaics.Rows;
						short num6 = (short)(frmMain.DefInstance.msfNaics.Rows - 1);
						num3 = 0;
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
								msfNaics[(int)num3, 0] = frmMain.DefInstance.msfNaics[(int)num3, 0];
								msfNaics[(int)num3, 1] = frmMain.DefInstance.msfNaics[(int)num3, 1];
							}
							num3 = (short)unchecked(num3 + 1);
						}
						msfNaics[0] = 1000;
						msfNaics[1] = 3700;
						txtPD.Text = frmMain.DefInstance.txtPD.Text;
						flag = true;
						goto end_IL_0001;
					}
					case 581:
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
				try0001_dispatch = 581;
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
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		Cursor.Current = Cursors.WaitCursor;
		lstSelected.Items.Clear();
		lstAvailable.Items.Clear();
		txtSearch.Text = "";
		recordset.CursorLocation = CursorLocationEnum.adUseClient;
		recordset.Open("SELECT * FROM NAICS ORDER BY NAICS", Common.MyConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
		while (!recordset.EOF)
		{
			lstAvailable.Items.Add((object)new ListBoxItem(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(recordset.Fields["NAICS"].Value, (object)" - "), recordset.Fields["NaicsDesc"].Value)), Conversions.ToInteger(recordset.Fields["NaicsID"].Value)));
			recordset.MoveNext();
		}
		recordset.Close();
		recordset = null;
		checked
		{
			short num = (short)(msfNaics.Rows - 1);
			short num2 = 1;
			while (true)
			{
				short num3 = num2;
				short num4 = num;
				if (num3 > num4)
				{
					break;
				}
				string text = unchecked(Strings.Trim(msfNaics[(int)num2, 0]) + " - " + Strings.Trim(msfNaics[(int)num2, 1]));
				short num5 = (short)(lstAvailable.Items.Count - 1);
				short num6 = 0;
				while (true)
				{
					short num7 = num6;
					num4 = num5;
					if (num7 > num4)
					{
						break;
					}
					if (Operators.CompareString(Support.GetItemString((Control)(object)lstAvailable, unchecked((int)num6)), text, false) == 0)
					{
						lstAvailable.SelectedIndex = num6;
						cmdSelect_Click(cmdSelect, new EventArgs());
						break;
					}
					num6 = (short)unchecked(num6 + 1);
				}
				num2 = (short)unchecked(num2 + 1);
			}
			((Control)fraMain).Visible = false;
			((Control)fraNAICS).Visible = true;
			Cursor.Current = Cursors.Default;
		}
	}

	private void cmdCancel_Click(object eventSender, EventArgs eventArgs)
	{
		((Form)this).Close();
	}

	private void cmdClose_Click(object eventSender, EventArgs eventArgs)
	{
		checked
		{
			msfNaics.Rows = lstSelected.Items.Count + 1;
			short num = (short)(lstSelected.Items.Count - 1);
			short num2 = 0;
			while (true)
			{
				short num3 = num2;
				short num4 = num;
				if (num3 > num4)
				{
					break;
				}
				short num5 = (short)Strings.InStr(Support.GetItemString((Control)(object)lstSelected, unchecked((int)num2)), "-", (CompareMethod)0);
				if (num5 > 0)
				{
					msfNaics[num2 + 1, 0] = Strings.Left(Support.GetItemString((Control)(object)lstSelected, unchecked((int)num2)), num5 - 1);
					msfNaics[num2 + 1, 1] = Strings.Mid(Support.GetItemString((Control)(object)lstSelected, unchecked((int)num2)), num5 + 1);
				}
				num2 = (short)unchecked(num2 + 1);
			}
			((Control)fraNAICS).Visible = false;
			((Control)fraMain).Visible = true;
		}
	}

	private void cmdDeselect_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		if (lstSelected.SelectedIndex > -1)
		{
			lstAvailable.Items.Add((object)new ListBoxItem(lstSelected.Text, Support.GetItemData((Control)(object)lstSelected, lstSelected.SelectedIndex)));
			lstSelected.Items.RemoveAt(lstSelected.SelectedIndex);
		}
	}

	private void cmdSearch_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		int try0001_dispatch = -1;
		int num2 = default(int);
		string text = default(string);
		string text2 = default(string);
		string text3 = default(string);
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
						ProjectData.ClearProjectError();
						num2 = 2;
						Cursor.Current = Cursors.WaitCursor;
						lstAvailable.Items.Clear();
						short num3 = (short)(lstSelected.Items.Count - 1);
						short num4 = 0;
						while (true)
						{
							short num5 = num4;
							short num6 = num3;
							if (num5 > num6)
							{
								break;
							}
							text = text + text2 + Conversions.ToString(Support.GetItemData((Control)(object)lstSelected, unchecked((int)num4)));
							text2 = ",";
							text3 = " AND ";
							num4 = (short)unchecked(num4 + 1);
						}
						if (Strings.Len(text) > 0)
						{
							text = " NOT naicsid in(" + text + ")";
						}
						if (Strings.Len(txtSearch.Text) == 0)
						{
							if (Strings.Len(text) > 0)
							{
								text = "WHERE " + text;
							}
						}
						else
						{
							string[] array = new string[5] { "WHERE naicsdesc like ('%", null, null, null, null };
							TextBox val3 = txtSearch;
							string Eobject = val3.Text;
							string text4 = Common.TrtSingleQuotes(ref Eobject);
							val3.Text = Eobject;
							array[1] = text4;
							array[2] = "%') ";
							array[3] = text3;
							array[4] = text;
							text = string.Concat(array);
						}
						recordset.CursorLocation = CursorLocationEnum.adUseClient;
						string source = "SELECT * FROM NAICS " + text + " ORDER BY NAICS";
						recordset.Open(source, Common.MyConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
						if (recordset.EOF)
						{
							Interaction.Beep();
							Interaction.MsgBox((object)"No NAICS codes met your search criteria.", (MsgBoxStyle)64, (object)"NAICS Search");
						}
						else
						{
							while (!recordset.EOF)
							{
								lstAvailable.Items.Add((object)new ListBoxItem(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(recordset.Fields["NAICS"].Value, (object)" - "), recordset.Fields["NaicsDesc"].Value)), Conversions.ToInteger(recordset.Fields["NaicsID"].Value)));
								recordset.MoveNext();
							}
						}
						recordset.Close();
						Cursor.Current = Cursors.Default;
						goto end_IL_0001;
					}
					case 682:
						num = -1;
						switch (num2)
						{
						case 2:
						{
							string Eobject = ((Control)this).Name;
							string Efunction = "cmdSearch_Click";
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
				try0001_dispatch = 682;
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

	private void cmdSelect_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		if (lstAvailable.SelectedIndex > -1)
		{
			lstSelected.Items.Add((object)new ListBoxItem(lstAvailable.Text, Support.GetItemData((Control)(object)lstAvailable, lstAvailable.SelectedIndex)));
			lstAvailable.Items.RemoveAt(lstAvailable.SelectedIndex);
		}
	}

	private void cmdOk_Click(object eventSender, EventArgs eventArgs)
	{
		frmMain.DefInstance.msfNaics.Rows = msfNaics.Rows;
		checked
		{
			short num = (short)(msfNaics.Rows - 1);
			short num2 = 1;
			while (true)
			{
				short num3 = num2;
				short num4 = num;
				if (num3 > num4)
				{
					break;
				}
				unchecked
				{
					frmMain.DefInstance.msfNaics[(int)num2, 0] = msfNaics[(int)num2, 0];
					frmMain.DefInstance.msfNaics[(int)num2, 1] = msfNaics[(int)num2, 1];
					Globals_Renamed.arNaics1[checked(num2 - 1), Globals_Renamed.intOpIndex] = msfNaics[(int)num2, 0];
					Globals_Renamed.arNaics2[checked(num2 - 1), Globals_Renamed.intOpIndex] = msfNaics[(int)num2, 1];
				}
				num2 = (short)unchecked(num2 + 1);
			}
			num2 = (short)(msfNaics.Rows - 1);
			while (true)
			{
				short num5 = num2;
				short num4 = 99;
				if (num5 > num4)
				{
					break;
				}
				Globals_Renamed.arNaics1[num2, Globals_Renamed.intOpIndex] = "";
				Globals_Renamed.arNaics2[num2, Globals_Renamed.intOpIndex] = "";
				num2 = (short)unchecked(num2 + 1);
			}
			frmMain.DefInstance.txtPD.Text = txtPD.Text;
			Globals_Renamed.arPDesc[Globals_Renamed.intOpIndex] = txtPD.Text;
			Globals_Renamed.gblIWasChanged = true;
			((Form)this).Close();
		}
	}

	private void lstAvailable_DoubleClick(object eventSender, EventArgs eventArgs)
	{
		cmdSelect_Click(cmdSelect, new EventArgs());
	}

	private void lstSelected_DoubleClick(object eventSender, EventArgs eventArgs)
	{
		cmdDeselect_Click(cmdDeselect, new EventArgs());
	}
}
