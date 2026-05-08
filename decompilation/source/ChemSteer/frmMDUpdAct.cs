using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ADODB;
using AxMSComctlLib;
using AxMSFlexGridLib;
using MSComctlLib;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Compatibility.VB6;
using Microsoft.VisualBasic.CompilerServices;

namespace ChemSteer;

internal class frmMDUpdAct : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("cmdMoveDown")]
	private Button _cmdMoveDown;

	[AccessedThroughProperty("cmdMoveUp")]
	private Button _cmdMoveUp;

	[AccessedThroughProperty("cmdShow")]
	private Button _cmdShow;

	[AccessedThroughProperty("tvActs")]
	private AxTreeView _tvActs;

	[AccessedThroughProperty("txtInput")]
	private TextBox _txtInput;

	[AccessedThroughProperty("cmdRemove")]
	private Button _cmdRemove;

	[AccessedThroughProperty("cmdAdd")]
	private Button _cmdAdd;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("cmdOK")]
	private Button _cmdOK;

	[AccessedThroughProperty("msfSelActs")]
	private AxMSFlexGrid _msfSelActs;

	[AccessedThroughProperty("_Label1_0")]
	private Label __Label1_0;

	[AccessedThroughProperty("lblOperation")]
	private Label _lblOperation;

	[AccessedThroughProperty("lblInstructions")]
	private Label _lblInstructions;

	[AccessedThroughProperty("_Label1_1")]
	private Label __Label1_1;

	[AccessedThroughProperty("Label1")]
	private LabelArray _Label1;

	private static frmMDUpdAct m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	private float[,,] COFarContParms;

	private short[,,] COFarContParmTypes;

	private short[,,] COFarRelModels;

	private short[,,] COFarExpModels;

	private short COFintNumRelModels;

	private short COFintNumExpModels;

	private short[] COFarRelModType;

	private string[] COFarRelModBasis;

	private string[] COFarRelModNAICS;

	private short[] COFarRelModStatus;

	private short[,] COFarRelModOutputOn;

	private string[,] COFarRelModChar;

	private float[,] COFarRelModMedia;

	private float[,,] COFarRelModParmsV;

	private short[,,] COFarRelModParmsT;

	private short[,,] COFarRelModParmsVC;

	private float[,] COFarRelModDRR;

	private float[,] COFarRelModARR;

	private short[,] COFarRelModDOR;

	private short[] COFarExpModType;

	private string[] COFarExpModBasis;

	private short[,] COFarExpModOutputOn;

	private string[,] COFarExpModChar;

	private short[] COFarExpModChmSt;

	private short[] COFarExpModUncertainty;

	private short[] COFarExpModStatus;

	private float[,,] COFarExpModParmsV;

	private short[,,] COFarExpModParmsT;

	private short[,,] COFarExpModParmsVC;

	private float[,,] COFarExpModEst;

	private string[,] COFarExpModInhRC;

	private short iContTab;

	private short[] arTwins;

	public virtual Button cmdMoveDown
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdMoveDown;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdMoveDown_Click;
			if (_cmdMoveDown != null)
			{
				((Control)_cmdMoveDown).Click -= eventHandler;
			}
			_cmdMoveDown = value;
			if (_cmdMoveDown != null)
			{
				((Control)_cmdMoveDown).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdMoveUp
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdMoveUp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdMoveUp_Click;
			if (_cmdMoveUp != null)
			{
				((Control)_cmdMoveUp).Click -= eventHandler;
			}
			_cmdMoveUp = value;
			if (_cmdMoveUp != null)
			{
				((Control)_cmdMoveUp).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdShow
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdShow;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdShow_Click;
			if (_cmdShow != null)
			{
				((Control)_cmdShow).Click -= eventHandler;
			}
			_cmdShow = value;
			if (_cmdShow != null)
			{
				((Control)_cmdShow).Click += eventHandler;
			}
		}
	}

	public virtual AxTreeView tvActs
	{
		[DebuggerNonUserCode]
		get
		{
			return _tvActs;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = tvActs_DblClick;
			if (_tvActs != null)
			{
				_tvActs.DblClick -= eventHandler;
			}
			_tvActs = value;
			if (_tvActs != null)
			{
				_tvActs.DblClick += eventHandler;
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
			EventHandler eventHandler = txtInput_TextChanged;
			if (_txtInput != null)
			{
				((Control)_txtInput).TextChanged -= eventHandler;
			}
			_txtInput = value;
			if (_txtInput != null)
			{
				((Control)_txtInput).TextChanged += eventHandler;
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

	public virtual AxMSFlexGrid msfSelActs
	{
		[DebuggerNonUserCode]
		get
		{
			return _msfSelActs;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = msfSelActs_Enter;
			EventHandler eventHandler2 = msfSelActs_Scroll;
			EventHandler eventHandler3 = msfSelActs_DblClick;
			EventHandler eventHandler4 = msfSelActs_ClickEvent;
			if (_msfSelActs != null)
			{
				((Control)_msfSelActs).Enter -= eventHandler;
				_msfSelActs.Scroll -= eventHandler2;
				_msfSelActs.DblClick -= eventHandler3;
				_msfSelActs.ClickEvent -= eventHandler4;
			}
			_msfSelActs = value;
			if (_msfSelActs != null)
			{
				((Control)_msfSelActs).Enter += eventHandler;
				_msfSelActs.Scroll += eventHandler2;
				_msfSelActs.DblClick += eventHandler3;
				_msfSelActs.ClickEvent += eventHandler4;
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

	public virtual Label lblOperation
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblOperation;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblOperation = value;
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

	public static frmMDUpdAct DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmMDUpdAct();
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

	public frmMDUpdAct()
	{
		((Form)this).Load += frmMDUpdAct_Load;
		__ENCAddToList(this);
		COFarContParms = new float[2, 2, 2];
		COFarContParmTypes = new short[2, 2, 2];
		COFarRelModels = new short[2, 2, 2];
		COFarExpModels = new short[2, 2, 2];
		COFarRelModType = new short[2];
		COFarRelModBasis = new string[2];
		COFarRelModNAICS = new string[2];
		COFarRelModStatus = new short[2];
		COFarRelModOutputOn = new short[2, 2];
		COFarRelModChar = new string[2, 2];
		COFarRelModMedia = new float[2, 2];
		COFarRelModParmsV = new float[2, 2, 2];
		COFarRelModParmsT = new short[2, 2, 2];
		COFarRelModParmsVC = new short[2, 2, 2];
		COFarRelModDRR = new float[2, 2];
		COFarRelModARR = new float[2, 2];
		COFarRelModDOR = new short[2, 2];
		COFarExpModType = new short[2];
		COFarExpModBasis = new string[2];
		COFarExpModOutputOn = new short[2, 2];
		COFarExpModChar = new string[2, 2];
		COFarExpModChmSt = new short[2];
		COFarExpModUncertainty = new short[2];
		COFarExpModStatus = new short[2];
		COFarExpModParmsV = new float[2, 2, 2];
		COFarExpModParmsT = new short[2, 2, 2];
		COFarExpModParmsVC = new short[2, 2, 2];
		COFarExpModEst = new float[2, 2, 2];
		COFarExpModInhRC = new string[2, 2];
		arTwins = new short[201];
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
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected O, but got Unknown
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected O, but got Unknown
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_041f: Expected O, but got Unknown
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Expected O, but got Unknown
		//IL_056b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0575: Expected O, but got Unknown
		//IL_063e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0648: Expected O, but got Unknown
		//IL_0711: Unknown result type (might be due to invalid IL or missing references)
		//IL_071b: Expected O, but got Unknown
		//IL_07e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ee: Expected O, but got Unknown
		//IL_08bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c9: Expected O, but got Unknown
		//IL_0929: Unknown result type (might be due to invalid IL or missing references)
		//IL_0933: Expected O, but got Unknown
		//IL_09ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a09: Expected O, but got Unknown
		//IL_0ac0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aca: Expected O, but got Unknown
		//IL_0b85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8f: Expected O, but got Unknown
		//IL_0d93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9d: Expected O, but got Unknown
		//IL_0db2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbc: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMDUpdAct));
		ToolTip1 = new ToolTip(components);
		cmdMoveDown = new Button();
		cmdMoveUp = new Button();
		cmdShow = new Button();
		tvActs = new AxTreeView();
		txtInput = new TextBox();
		cmdRemove = new Button();
		cmdAdd = new Button();
		cmdCancel = new Button();
		cmdOK = new Button();
		msfSelActs = new AxMSFlexGrid();
		_Label1_0 = new Label();
		lblOperation = new Label();
		lblInstructions = new Label();
		_Label1_1 = new Label();
		Label1 = new LabelArray(components);
		((ISupportInitialize)tvActs).BeginInit();
		((ISupportInitialize)msfSelActs).BeginInit();
		((ISupportInitialize)Label1).BeginInit();
		((Control)this).SuspendLayout();
		((ButtonBase)cmdMoveDown).BackColor = SystemColors.Control;
		((Control)cmdMoveDown).Cursor = Cursors.Default;
		cmdMoveDown.DialogResult = (DialogResult)2;
		((Control)cmdMoveDown).Enabled = false;
		((Control)cmdMoveDown).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdMoveDown).ForeColor = SystemColors.ControlText;
		Button obj = cmdMoveDown;
		Point location = new Point(656, 352);
		((Control)obj).Location = location;
		((Control)cmdMoveDown).Name = "cmdMoveDown";
		((Control)cmdMoveDown).RightToLeft = (RightToLeft)0;
		Button obj2 = cmdMoveDown;
		Size size = new Size(81, 17);
		((Control)obj2).Size = size;
		((Control)cmdMoveDown).TabIndex = 13;
		((ButtonBase)cmdMoveDown).Text = "Move Down";
		((ButtonBase)cmdMoveDown).UseVisualStyleBackColor = false;
		((Control)cmdMoveDown).Visible = false;
		((ButtonBase)cmdMoveUp).BackColor = SystemColors.Control;
		((Control)cmdMoveUp).Cursor = Cursors.Default;
		((Control)cmdMoveUp).Enabled = false;
		((Control)cmdMoveUp).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdMoveUp).ForeColor = SystemColors.ControlText;
		Button obj3 = cmdMoveUp;
		location = new Point(576, 352);
		((Control)obj3).Location = location;
		((Control)cmdMoveUp).Name = "cmdMoveUp";
		((Control)cmdMoveUp).RightToLeft = (RightToLeft)0;
		Button obj4 = cmdMoveUp;
		size = new Size(81, 17);
		((Control)obj4).Size = size;
		((Control)cmdMoveUp).TabIndex = 12;
		((ButtonBase)cmdMoveUp).Text = "Move Up";
		((ButtonBase)cmdMoveUp).UseVisualStyleBackColor = false;
		((Control)cmdMoveUp).Visible = false;
		((ButtonBase)cmdShow).BackColor = SystemColors.Control;
		((Control)cmdShow).Cursor = Cursors.Default;
		((Control)cmdShow).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdShow).ForeColor = SystemColors.ControlText;
		Button obj5 = cmdShow;
		location = new Point(576, 8);
		((Control)obj5).Location = location;
		((Control)cmdShow).Name = "cmdShow";
		((Control)cmdShow).RightToLeft = (RightToLeft)0;
		Button obj6 = cmdShow;
		size = new Size(209, 25);
		((Control)obj6).Size = size;
		((Control)cmdShow).TabIndex = 11;
		((ButtonBase)cmdShow).Text = "&Show All Sources/Activities";
		((ButtonBase)cmdShow).UseVisualStyleBackColor = false;
		((Control)cmdShow).Visible = false;
		AxTreeView obj7 = tvActs;
		location = new Point(8, 48);
		((Control)obj7).Location = location;
		((Control)tvActs).Name = "tvActs";
		((AxHost)tvActs).OcxState = (State)componentResourceManager.GetObject("tvActs.OcxState");
		AxTreeView obj8 = tvActs;
		size = new Size(585, 209);
		((Control)obj8).Size = size;
		((Control)tvActs).TabIndex = 9;
		txtInput.AcceptsReturn = true;
		((TextBoxBase)txtInput).BackColor = Color.FromArgb(255, 255, 192);
		((Control)txtInput).Cursor = Cursors.IBeam;
		((Control)txtInput).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtInput).ForeColor = SystemColors.WindowText;
		TextBox obj9 = txtInput;
		location = new Point(8, 496);
		((Control)obj9).Location = location;
		((TextBoxBase)txtInput).MaxLength = 100;
		((Control)txtInput).Name = "txtInput";
		((Control)txtInput).RightToLeft = (RightToLeft)0;
		TextBox obj10 = txtInput;
		size = new Size(81, 20);
		((Control)obj10).Size = size;
		((Control)txtInput).TabIndex = 8;
		((Control)txtInput).Visible = false;
		((ButtonBase)cmdRemove).BackColor = SystemColors.Control;
		((Control)cmdRemove).Cursor = Cursors.Default;
		((Control)cmdRemove).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdRemove).ForeColor = SystemColors.ControlText;
		Button obj11 = cmdRemove;
		location = new Point(608, 88);
		((Control)obj11).Location = location;
		((Control)cmdRemove).Name = "cmdRemove";
		((Control)cmdRemove).RightToLeft = (RightToLeft)0;
		Button obj12 = cmdRemove;
		size = new Size(129, 25);
		((Control)obj12).Size = size;
		((Control)cmdRemove).TabIndex = 1;
		((ButtonBase)cmdRemove).Text = "&Remove from operation";
		((ButtonBase)cmdRemove).UseVisualStyleBackColor = false;
		((ButtonBase)cmdAdd).BackColor = SystemColors.Control;
		((Control)cmdAdd).Cursor = Cursors.Default;
		((Control)cmdAdd).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdAdd).ForeColor = SystemColors.ControlText;
		Button obj13 = cmdAdd;
		location = new Point(608, 56);
		((Control)obj13).Location = location;
		((Control)cmdAdd).Name = "cmdAdd";
		((Control)cmdAdd).RightToLeft = (RightToLeft)0;
		Button obj14 = cmdAdd;
		size = new Size(129, 25);
		((Control)obj14).Size = size;
		((Control)cmdAdd).TabIndex = 0;
		((ButtonBase)cmdAdd).Text = "&Add to operation";
		((ButtonBase)cmdAdd).UseVisualStyleBackColor = false;
		((ButtonBase)cmdCancel).BackColor = SystemColors.Control;
		((Control)cmdCancel).Cursor = Cursors.Default;
		((Control)cmdCancel).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCancel).ForeColor = SystemColors.ControlText;
		Button obj15 = cmdCancel;
		location = new Point(376, 496);
		((Control)obj15).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		((Control)cmdCancel).RightToLeft = (RightToLeft)0;
		Button obj16 = cmdCancel;
		size = new Size(81, 25);
		((Control)obj16).Size = size;
		((Control)cmdCancel).TabIndex = 3;
		((ButtonBase)cmdCancel).Text = "Cancel";
		((ButtonBase)cmdCancel).UseVisualStyleBackColor = false;
		((ButtonBase)cmdOK).BackColor = SystemColors.Control;
		((Control)cmdOK).Cursor = Cursors.Default;
		((Control)cmdOK).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdOK).ForeColor = SystemColors.ControlText;
		Button obj17 = cmdOK;
		location = new Point(280, 496);
		((Control)obj17).Location = location;
		((Control)cmdOK).Name = "cmdOK";
		((Control)cmdOK).RightToLeft = (RightToLeft)0;
		Button obj18 = cmdOK;
		size = new Size(81, 25);
		((Control)obj18).Size = size;
		((Control)cmdOK).TabIndex = 2;
		((ButtonBase)cmdOK).Text = "OK";
		((ButtonBase)cmdOK).UseVisualStyleBackColor = false;
		AxMSFlexGrid obj19 = msfSelActs;
		location = new Point(8, 368);
		((Control)obj19).Location = location;
		((Control)msfSelActs).Name = "msfSelActs";
		((AxHost)msfSelActs).OcxState = (State)componentResourceManager.GetObject("msfSelActs.OcxState");
		AxMSFlexGrid obj20 = msfSelActs;
		size = new Size(729, 113);
		((Control)obj20).Size = size;
		((Control)msfSelActs).TabIndex = 7;
		((Control)_Label1_0).BackColor = SystemColors.Control;
		((Control)_Label1_0).Cursor = Cursors.Default;
		((Control)_Label1_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_0).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_0, (short)0);
		Label label1_ = _Label1_0;
		location = new Point(8, 32);
		((Control)label1_).Location = location;
		((Control)_Label1_0).Name = "_Label1_0";
		((Control)_Label1_0).RightToLeft = (RightToLeft)0;
		Label label1_2 = _Label1_0;
		size = new Size(497, 17);
		((Control)label1_2).Size = size;
		((Control)_Label1_0).TabIndex = 10;
		_Label1_0.Text = "Double-click on the category of interest in the following list to view/ hide available sources/ activities:";
		((Control)lblOperation).BackColor = SystemColors.Control;
		((Control)lblOperation).Cursor = Cursors.Default;
		((Control)lblOperation).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)lblOperation).ForeColor = SystemColors.ControlText;
		Label obj21 = lblOperation;
		location = new Point(8, 8);
		((Control)obj21).Location = location;
		((Control)lblOperation).Name = "lblOperation";
		((Control)lblOperation).RightToLeft = (RightToLeft)0;
		Label obj22 = lblOperation;
		size = new Size(529, 17);
		((Control)obj22).Size = size;
		((Control)lblOperation).TabIndex = 6;
		lblOperation.Text = "x";
		((Control)lblInstructions).BackColor = SystemColors.Control;
		((Control)lblInstructions).Cursor = Cursors.Default;
		((Control)lblInstructions).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblInstructions).ForeColor = SystemColors.ControlText;
		Label obj23 = lblInstructions;
		location = new Point(8, 264);
		((Control)obj23).Location = location;
		((Control)lblInstructions).Name = "lblInstructions";
		((Control)lblInstructions).RightToLeft = (RightToLeft)0;
		Label obj24 = lblInstructions;
		size = new Size(721, 81);
		((Control)obj24).Size = size;
		((Control)lblInstructions).TabIndex = 5;
		lblInstructions.Text = "xxx";
		((Control)_Label1_1).BackColor = SystemColors.Control;
		((Control)_Label1_1).Cursor = Cursors.Default;
		((Control)_Label1_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_1).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_1, (short)1);
		Label label1_3 = _Label1_1;
		location = new Point(8, 352);
		((Control)label1_3).Location = location;
		((Control)_Label1_1).Name = "_Label1_1";
		((Control)_Label1_1).RightToLeft = (RightToLeft)0;
		Label label1_4 = _Label1_1;
		size = new Size(409, 17);
		((Control)label1_4).Size = size;
		((Control)_Label1_1).TabIndex = 4;
		_Label1_1.Text = "Sources/Activities that will be assessed in the operation:";
		((Form)this).AcceptButton = (IButtonControl)(object)cmdOK;
		size = new Size(5, 13);
		((Form)this).AutoScaleBaseSize = size;
		((Form)this).BackColor = SystemColors.Control;
		((Form)this).CancelButton = (IButtonControl)(object)cmdMoveDown;
		size = new Size(749, 536);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)cmdMoveDown);
		((Control)this).Controls.Add((Control)(object)cmdMoveUp);
		((Control)this).Controls.Add((Control)(object)cmdShow);
		((Control)this).Controls.Add((Control)(object)tvActs);
		((Control)this).Controls.Add((Control)(object)txtInput);
		((Control)this).Controls.Add((Control)(object)cmdRemove);
		((Control)this).Controls.Add((Control)(object)cmdAdd);
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)cmdOK);
		((Control)this).Controls.Add((Control)(object)msfSelActs);
		((Control)this).Controls.Add((Control)(object)_Label1_0);
		((Control)this).Controls.Add((Control)(object)lblOperation);
		((Control)this).Controls.Add((Control)(object)lblInstructions);
		((Control)this).Controls.Add((Control)(object)_Label1_1);
		((Control)this).Cursor = Cursors.Default;
		((Control)this).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		location = new Point(250, 150);
		((Form)this).Location = location;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmMDUpdAct";
		((Control)this).RightToLeft = (RightToLeft)0;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Update Operation Sources/Activities";
		((ISupportInitialize)tvActs).EndInit();
		((ISupportInitialize)msfSelActs).EndInit();
		((ISupportInitialize)Label1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void cmdCancel_Click(object eventSender, EventArgs eventArgs)
	{
		((Form)this).Close();
	}

	private void cmdAdd_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c5: Unknown result type (might be due to invalid IL or missing references)
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
						((Control)txtInput).Visible = false;
						if (Operators.CompareString(Strings.Left(((INode)tvActs.SelectedItem).Key, 3), "Act", false) != 0)
						{
							Interaction.MsgBox((object)"Please select the activity you wish to add to the operation by clicking on it.", (MsgBoxStyle)64, (object)"Invalid Request");
							goto end_IL_0001;
						}
						if (msfSelActs.Rows > 20)
						{
							Interaction.MsgBox((object)("You can only define " + Conversions.ToString(20) + " activities for a given operation."), (MsgBoxStyle)64, (object)"Invalid Request");
							goto end_IL_0001;
						}
						short num3 = (short)Strings.InStr(((INode)tvActs.SelectedItem).Key, "-", (CompareMethod)0);
						num3 = Conversions.ToShort(Strings.Mid(((INode)tvActs.SelectedItem).Key, num3 + 1));
						while (true)
						{
							command.ActiveConnection = Common.MyConn;
							command.CommandText = "pqryGetActivity";
							command.CommandType = CommandTypeEnum.adCmdStoredProc;
							command.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, num3));
							Command command2 = command;
							object RecordsAffected = Missing.Value;
							object Parameters = Missing.Value;
							recordset = command2.Execute(out RecordsAffected, ref Parameters);
							command.Parameters.Delete("pActID");
							string text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["RelActivity"].Value)), (object)0, RuntimeHelpers.GetObjectValue(recordset.Fields["RelActivity"].Value)), (object)1, false), (object)"Yes", (object)"No"));
							string text2 = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["ExpActivity"].Value)), (object)0, RuntimeHelpers.GetObjectValue(recordset.Fields["ExpActivity"].Value)), (object)1, false), (object)"Yes", (object)"No"));
							recordset.Close();
							command.ActiveConnection = Common.MyConn;
							command.CommandText = "pqryGetActContTab";
							command.CommandType = CommandTypeEnum.adCmdStoredProc;
							command.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, num3));
							Command command3 = command;
							Parameters = Missing.Value;
							RecordsAffected = Missing.Value;
							recordset = command3.Execute(out Parameters, ref RecordsAffected);
							command.Parameters.Delete("pActID");
							string text3 = (Versioned.IsNumeric((object)msfSelActs[1, 0]) ? Conversions.ToString(msfSelActs.Rows) : "1");
							msfSelActs.AddItem(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(Conversions.ToString(unchecked((int)num3)) + "\t"), recordset.Fields[2].Value), (object)'\t'), (object)text), (object)'\t'), (object)text2), (object)'\t'), (object)"Pending"), (object)'\t'), (object)"Pending"), (object)'\t'), (object)text3)));
							if (!Versioned.IsNumeric((object)msfSelActs[1, 0]))
							{
								msfSelActs.RemoveItem(1);
							}
							Globals_Renamed.intActIndex = (short)(msfSelActs.Rows - 2);
							COFarContParms = (float[,,])Utils.CopyArray((Array)COFarContParms, (Array)new float[16, 26, Globals_Renamed.intNumOps + 1]);
							COFarContParmTypes = (short[,,])Utils.CopyArray((Array)COFarContParmTypes, (Array)new short[16, 26, Globals_Renamed.intNumOps + 1]);
							if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields[0].Value)) && Operators.ConditionalCompareObjectGreater(recordset.Fields[0].Value, (object)0, false))
							{
								iContTab = Conversions.ToShort(recordset.Fields[0].Value);
								ref short pContTab = ref iContTab;
								short pActID = Conversions.ToShort(msfSelActs[msfSelActs.Rows - 1, 0]);
								Parameters = COFarContParms;
								RecordsAffected = Globals_Renamed.arOpParms;
								ChemStrX.ContDefaults(ref pContTab, ref pActID, ref Parameters, ref RecordsAffected);
								Globals_Renamed.arOpParms = (float[,])RecordsAffected;
								COFarContParms = (float[,,])Parameters;
								SetResetContParms();
							}
							recordset.Close();
							if (!unchecked(arTwins[num3] > 0 && !flag))
							{
								break;
							}
							flag = true;
							short num4 = (short)(msfSelActs.Rows - 1);
							short num5 = 1;
							while (true)
							{
								short num6 = num5;
								short num7 = num4;
								if (num6 > num7)
								{
									break;
								}
								if (Conversions.ToDouble(msfSelActs[unchecked((int)num5), 0]) == (double)arTwins[num3])
								{
									flag = false;
								}
								num5 = (short)unchecked(num5 + 1);
							}
							if (!flag)
							{
								break;
							}
							flag = true;
							num3 = arTwins[num3];
						}
						recordset = null;
						command = null;
						goto end_IL_0001;
					}
					case 1590:
						num = -1;
						switch (num2)
						{
						case 2:
						{
							if (Information.Err().Number == 91)
							{
								Interaction.MsgBox((object)"Please select a source/activity", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
								goto end_IL_0001;
							}
							string Eobject = ((Control)this).Name;
							string Efunction = "cmdAdd_Click";
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
				try0001_dispatch = 1590;
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

	private void cmdMoveDown_Click(object eventSender, EventArgs eventArgs)
	{
		checked
		{
			if (Versioned.IsNumeric((object)msfSelActs[msfSelActs.Row, 6]))
			{
				short num = Conversions.ToShort(msfSelActs[msfSelActs.Row, 6]);
				short num2 = (short)(msfSelActs.Rows - 1);
				short num3 = 1;
				while (true)
				{
					short num4 = num3;
					short num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					if (Conversions.ToShort(msfSelActs[unchecked((int)num3), 6]) == num + 1)
					{
						msfSelActs[unchecked((int)num3), 6] = Conversions.ToString(Conversions.ToShort(msfSelActs[unchecked((int)num3), 6]) - 1);
					}
					else if (Conversions.ToShort(msfSelActs[unchecked((int)num3), 6]) == num)
					{
						msfSelActs[unchecked((int)num3), 6] = Conversions.ToString(Conversions.ToShort(msfSelActs[unchecked((int)num3), 6]) + 1);
					}
					num3 = (short)unchecked(num3 + 1);
				}
			}
			if (Operators.CompareString(msfSelActs.Text, Conversions.ToString(msfSelActs.Rows - 1), false) == 0)
			{
				((Control)cmdMoveDown).Enabled = false;
			}
			((Control)msfSelActs).Focus();
		}
	}

	private void cmdMoveUp_Click(object eventSender, EventArgs eventArgs)
	{
		checked
		{
			if (Versioned.IsNumeric((object)msfSelActs[msfSelActs.Row, 6]))
			{
				short num = Conversions.ToShort(msfSelActs[msfSelActs.Row, 6]);
				short num2 = (short)(msfSelActs.Rows - 1);
				short num3 = 1;
				while (true)
				{
					short num4 = num3;
					short num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					if (Conversions.ToShort(msfSelActs[unchecked((int)num3), 6]) == num - 1)
					{
						msfSelActs[unchecked((int)num3), 6] = Conversions.ToString(Conversions.ToShort(msfSelActs[unchecked((int)num3), 6]) + 1);
					}
					else if (Conversions.ToShort(msfSelActs[unchecked((int)num3), 6]) == num)
					{
						msfSelActs[unchecked((int)num3), 6] = Conversions.ToString(Conversions.ToShort(msfSelActs[unchecked((int)num3), 6]) - 1);
					}
					num3 = (short)unchecked(num3 + 1);
				}
			}
			if (Operators.CompareString(msfSelActs.Text, "1", false) == 0)
			{
				((Control)cmdMoveUp).Enabled = false;
			}
			((Control)msfSelActs).Focus();
		}
	}

	private void cmdRemove_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Invalid comparison between Unknown and I4
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
		Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		((Control)txtInput).Visible = false;
		if (!Versioned.IsNumeric((object)msfSelActs[msfSelActs.Row, 0]) || (int)Interaction.MsgBox((object)("Are you sure you want to remove the " + msfSelActs[msfSelActs.Row, 1] + " activity from the " + lblOperation.Text + " operation?"), (MsgBoxStyle)36, (object)"Confirm Delete") != 6)
		{
			return;
		}
		checked
		{
			short num = (short)(msfSelActs.Row - 1);
			short num2 = Conversions.ToShort(msfSelActs[msfSelActs.Row, 6]);
			short num3 = Conversions.ToShort(msfSelActs[msfSelActs.Row, 0]);
			short num5;
			short num7;
			if (msfSelActs.Rows == 2)
			{
				short num4 = (short)(msfSelActs.Cols - 1);
				num5 = 0;
				while (true)
				{
					short num6 = num5;
					num7 = num4;
					if (num6 <= num7)
					{
						msfSelActs[1, unchecked((int)num5)] = "";
						num5 = (short)unchecked(num5 + 1);
						continue;
					}
					break;
				}
			}
			else
			{
				msfSelActs.RemoveItem(msfSelActs.Row);
			}
			num5 = num;
			while (true)
			{
				short num8 = num5;
				num7 = 24;
				if (num8 > num7)
				{
					break;
				}
				short num9 = 0;
				short num10;
				do
				{
					COFarRelModels[num9, num5, Globals_Renamed.intOpIndex] = COFarRelModels[num9, num5 + 1, Globals_Renamed.intOpIndex];
					num9 = (short)unchecked(num9 + 1);
					num10 = num9;
					num7 = 9;
				}
				while (num10 <= num7);
				num9 = 0;
				short num11;
				do
				{
					COFarContParms[num9, num5, Globals_Renamed.intOpIndex] = COFarContParms[num9, num5 + 1, Globals_Renamed.intOpIndex];
					COFarContParmTypes[num9, num5, Globals_Renamed.intOpIndex] = COFarContParmTypes[num9, num5 + 1, Globals_Renamed.intOpIndex];
					num9 = (short)unchecked(num9 + 1);
					num11 = num9;
					num7 = 15;
				}
				while (num11 <= num7);
				num9 = 0;
				short num12;
				do
				{
					COFarExpModels[num9, num5, Globals_Renamed.intOpIndex] = COFarExpModels[num9, num5 + 1, Globals_Renamed.intOpIndex];
					num9 = (short)unchecked(num9 + 1);
					num12 = num9;
					num7 = 1;
				}
				while (num12 <= num7);
				num5 = (short)unchecked(num5 + 1);
			}
			short num13 = (short)(msfSelActs.Rows - 1);
			num5 = 1;
			while (true)
			{
				short num14 = num5;
				num7 = num13;
				if (num14 > num7)
				{
					break;
				}
				if (unchecked(Versioned.IsNumeric((object)msfSelActs[(int)num5, 6]) && Conversions.ToShort(msfSelActs[(int)num5, 6]) > num2))
				{
					msfSelActs[unchecked((int)num5), 6] = Conversions.ToString(Conversions.ToShort(msfSelActs[unchecked((int)num5), 6]) - 1);
				}
				num5 = (short)unchecked(num5 + 1);
			}
			num5 = 0;
			short num15;
			do
			{
				COFarRelModels[num5, 24, Globals_Renamed.intOpIndex] = 0;
				num5 = (short)unchecked(num5 + 1);
				num15 = num5;
				num7 = 9;
			}
			while (num15 <= num7);
			num5 = 0;
			short num16;
			do
			{
				COFarExpModels[num5, 24, Globals_Renamed.intOpIndex] = 0;
				num5 = (short)unchecked(num5 + 1);
				num16 = num5;
				num7 = 1;
			}
			while (num16 <= num7);
			command.ActiveConnection = Common.MyConn;
			command.CommandText = "pqryGetActContTab";
			command.CommandType = CommandTypeEnum.adCmdStoredProc;
			command.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, num3));
			Command command2 = command;
			object RecordsAffected = Missing.Value;
			object Parameters = Missing.Value;
			recordset = command2.Execute(out RecordsAffected, ref Parameters);
			command.Parameters.Delete("pActID");
			if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields[0].Value)) && Operators.ConditionalCompareObjectGreater(recordset.Fields[0].Value, (object)0, false))
			{
				iContTab = Conversions.ToShort(recordset.Fields[0].Value);
				SetResetContParms();
			}
			recordset.Close();
			recordset = null;
			command = null;
		}
	}

	private void cmdShow_Click(object eventSender, EventArgs eventArgs)
	{
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
		Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		((INodes)tvActs.Nodes).Clear();
		if (Operators.CompareString(((ButtonBase)cmdShow).Text, "&Show All Activities", false) == 0)
		{
			recordset.CursorLocation = CursorLocationEnum.adUseClient;
			recordset.Open("SELECT * FROM qryListActCats", Common.MyConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
			((ButtonBase)cmdShow).Text = "&Show Only Most Likely Activities";
		}
		else
		{
			((ButtonBase)cmdShow).Text = "&Show All Activities";
			command.ActiveConnection = Common.MyConn;
			if (Globals_Renamed.arOpType[Support.GetItemData((Control)(object)frmMain.DefInstance._lstSelOps_0, frmMain.DefInstance._lstSelOps_0.SelectedIndex)] < 100)
			{
				command.CommandText = "pqryListMostLikelyActsUDO";
			}
			else
			{
				command.CommandText = "pqryListMostLikelyActsGSS";
			}
			command.CommandType = CommandTypeEnum.adCmdStoredProc;
			command.Parameters.Append(command.CreateParameter("pOpID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, Globals_Renamed.arOpType[Support.GetItemData((Control)(object)frmMain.DefInstance._lstSelOps_0, frmMain.DefInstance._lstSelOps_0.SelectedIndex)]));
			Command command2 = command;
			object RecordsAffected = Missing.Value;
			object Parameters = Missing.Value;
			recordset = command2.Execute(out RecordsAffected, ref Parameters);
			command.Parameters.Delete("pOpID");
		}
		string text = default(string);
		while (!recordset.EOF)
		{
			object value2;
			object value;
			object obj2;
			object obj;
			object Parameters;
			object RecordsAffected;
			Node val;
			if (Operators.ConditionalCompareObjectNotEqual((object)text, recordset.Fields[0].Value, false))
			{
				text = Conversions.ToString(recordset.Fields[0].Value);
				Nodes nodes = tvActs.Nodes;
				Parameters = Missing.Value;
				RecordsAffected = (object)(TreeRelationshipConstants)2;
				obj = Operators.ConcatenateObject((object)"Cat", recordset.Fields[3].Value);
				obj2 = recordset.Fields[0];
				value = Missing.Value;
				value2 = Missing.Value;
				val = ((INodes)nodes).Add(ref Parameters, ref RecordsAffected, ref obj, ref obj2, ref value, ref value2);
				string text2 = "";
			}
			Nodes nodes2 = tvActs.Nodes;
			value2 = Operators.ConcatenateObject((object)"Cat", recordset.Fields[3].Value);
			value = (object)(TreeRelationshipConstants)4;
			obj2 = Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Act", recordset.Fields[3].Value), (object)"-"), recordset.Fields[2].Value);
			obj = recordset.Fields[1];
			Parameters = Missing.Value;
			RecordsAffected = Missing.Value;
			val = ((INodes)nodes2).Add(ref value2, ref value, ref obj2, ref obj, ref Parameters, ref RecordsAffected);
			recordset.MoveNext();
		}
		recordset.Close();
		recordset = null;
		command = null;
	}

	private void frmMDUpdAct_Load(object eventSender, EventArgs eventArgs)
	{
		SetUp();
	}

	private void msfSelActs_ClickEvent(object eventSender, EventArgs eventArgs)
	{
		checked
		{
			if ((msfSelActs.Col > 0) & (msfSelActs.Col < 4) & (msfSelActs[msfSelActs.Row] > 0))
			{
				((Control)txtInput).Top = (int)Math.Round(Support.TwipsToPixelsY(Support.PixelsToTwipsY((double)((Control)msfSelActs).Top) + (double)msfSelActs[msfSelActs.Row]));
				((Control)txtInput).Left = (int)Math.Round(Support.TwipsToPixelsX(Support.PixelsToTwipsX((double)((Control)msfSelActs).Left) + (double)msfSelActs[msfSelActs.Col]));
				((Control)txtInput).Width = (int)Math.Round(Support.TwipsToPixelsX((double)msfSelActs[msfSelActs.Col]));
				((Control)txtInput).Visible = true;
				txtInput.Text = msfSelActs.Text;
				((Control)txtInput).Focus();
				((TextBoxBase)txtInput).SelectionLength = Strings.Len(txtInput.Text);
			}
			else
			{
				((Control)txtInput).Visible = false;
			}
			if ((msfSelActs.Col == 6) & (msfSelActs.Rows > 2))
			{
				if (Operators.CompareString(msfSelActs[msfSelActs.Row, 6], "1", false) == 0)
				{
					((Control)cmdMoveUp).Enabled = false;
				}
				else
				{
					((Control)cmdMoveUp).Enabled = true;
				}
				if (Operators.CompareString(msfSelActs[msfSelActs.Row, 6], Conversions.ToString(msfSelActs.Rows - 1), false) == 0)
				{
					((Control)cmdMoveDown).Enabled = false;
				}
				else
				{
					((Control)cmdMoveDown).Enabled = true;
				}
			}
			else
			{
				((Control)cmdMoveUp).Enabled = false;
				((Control)cmdMoveDown).Enabled = false;
			}
		}
	}

	private void msfSelActs_DblClick(object eventSender, EventArgs eventArgs)
	{
		cmdRemove_Click(cmdRemove, new EventArgs());
	}

	private void msfSelActs_Scroll(object eventSender, EventArgs eventArgs)
	{
		((Control)txtInput).Visible = false;
	}

	private void cmdOk_Click(object eventSender, EventArgs eventArgs)
	{
		checked
		{
			Globals_Renamed.arContParms = new float[16, 26, Globals_Renamed.intNumOps + 1];
			object pCopyArray = COFarContParms;
			object pToArray = Globals_Renamed.arContParms;
			short pDim = 15;
			short pDim2 = 25;
			ChemStrX.Clone3DArray(ref pCopyArray, ref pToArray, ref pDim, ref pDim2, ref Globals_Renamed.intNumOps);
			Globals_Renamed.arContParms = (float[,,])pToArray;
			COFarContParms = (float[,,])pCopyArray;
			Globals_Renamed.arContParmTypes = new short[16, 26, Globals_Renamed.intNumOps + 1];
			pToArray = COFarContParmTypes;
			pCopyArray = Globals_Renamed.arContParmTypes;
			pDim2 = 15;
			pDim = 25;
			ChemStrX.Clone3DArray(ref pToArray, ref pCopyArray, ref pDim2, ref pDim, ref Globals_Renamed.intNumOps);
			Globals_Renamed.arContParmTypes = (short[,,])pCopyArray;
			COFarContParmTypes = (short[,,])pToArray;
			Globals_Renamed.intNumRelModels = COFintNumRelModels;
			Globals_Renamed.arRelModels = new short[11, 26, Globals_Renamed.intNumOps + 1];
			Globals_Renamed.arRelModType = new short[COFintNumRelModels + 1];
			Globals_Renamed.arRelModBasis = new string[COFintNumRelModels + 1];
			Globals_Renamed.arRelModNAICS = new string[COFintNumRelModels + 1];
			Globals_Renamed.arRelModStatus = new short[COFintNumRelModels + 1];
			Globals_Renamed.arRelModOutputOn = new short[3, COFintNumRelModels + 1];
			Globals_Renamed.arRelModChar = new string[3, COFintNumRelModels + 1];
			Globals_Renamed.arRelModMedia = new float[19, COFintNumRelModels + 1];
			Globals_Renamed.arRelModParmsV = new float[3, 163, COFintNumRelModels + 1];
			Globals_Renamed.arRelModParmsT = new short[3, 163, COFintNumRelModels + 1];
			Globals_Renamed.arRelModParmsVC = new short[3, 163, COFintNumRelModels + 1];
			Globals_Renamed.arRelModDRR = new float[3, COFintNumRelModels + 1];
			Globals_Renamed.arRelModARR = new float[3, COFintNumRelModels + 1];
			Globals_Renamed.arRelModDOR = new short[3, COFintNumRelModels + 1];
			pToArray = COFarRelModels;
			pCopyArray = Globals_Renamed.arRelModels;
			pDim2 = 10;
			pDim = 25;
			ChemStrX.Clone3DArray(ref pToArray, ref pCopyArray, ref pDim2, ref pDim, ref Globals_Renamed.intNumOps);
			Globals_Renamed.arRelModels = (short[,,])pCopyArray;
			COFarRelModels = (short[,,])pToArray;
			pToArray = COFarRelModType;
			pCopyArray = Globals_Renamed.arRelModType;
			ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref COFintNumRelModels);
			Globals_Renamed.arRelModType = (short[])pCopyArray;
			COFarRelModType = (short[])pToArray;
			pToArray = COFarRelModBasis;
			pCopyArray = Globals_Renamed.arRelModBasis;
			ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref COFintNumRelModels);
			Globals_Renamed.arRelModBasis = (string[])pCopyArray;
			COFarRelModBasis = (string[])pToArray;
			pToArray = COFarRelModNAICS;
			pCopyArray = Globals_Renamed.arRelModNAICS;
			ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref COFintNumRelModels);
			Globals_Renamed.arRelModNAICS = (string[])pCopyArray;
			COFarRelModNAICS = (string[])pToArray;
			pToArray = COFarRelModStatus;
			pCopyArray = Globals_Renamed.arRelModStatus;
			ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref COFintNumRelModels);
			Globals_Renamed.arRelModStatus = (short[])pCopyArray;
			COFarRelModStatus = (short[])pToArray;
			pToArray = COFarRelModOutputOn;
			pCopyArray = Globals_Renamed.arRelModOutputOn;
			pDim2 = 2;
			ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref COFintNumRelModels);
			Globals_Renamed.arRelModOutputOn = (short[,])pCopyArray;
			COFarRelModOutputOn = (short[,])pToArray;
			pToArray = COFarRelModChar;
			pCopyArray = Globals_Renamed.arRelModChar;
			pDim2 = 2;
			ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref COFintNumRelModels);
			Globals_Renamed.arRelModChar = (string[,])pCopyArray;
			COFarRelModChar = (string[,])pToArray;
			pToArray = COFarRelModMedia;
			pCopyArray = Globals_Renamed.arRelModMedia;
			pDim2 = 18;
			ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref COFintNumRelModels);
			Globals_Renamed.arRelModMedia = (float[,])pCopyArray;
			COFarRelModMedia = (float[,])pToArray;
			pToArray = COFarRelModParmsV;
			pCopyArray = Globals_Renamed.arRelModParmsV;
			pDim2 = 2;
			pDim = 162;
			ChemStrX.Clone3DArray(ref pToArray, ref pCopyArray, ref pDim2, ref pDim, ref COFintNumRelModels);
			Globals_Renamed.arRelModParmsV = (float[,,])pCopyArray;
			COFarRelModParmsV = (float[,,])pToArray;
			pToArray = COFarRelModParmsT;
			pCopyArray = Globals_Renamed.arRelModParmsT;
			pDim2 = 2;
			pDim = 162;
			ChemStrX.Clone3DArray(ref pToArray, ref pCopyArray, ref pDim2, ref pDim, ref COFintNumRelModels);
			Globals_Renamed.arRelModParmsT = (short[,,])pCopyArray;
			COFarRelModParmsT = (short[,,])pToArray;
			pToArray = COFarRelModParmsVC;
			pCopyArray = Globals_Renamed.arRelModParmsVC;
			pDim2 = 2;
			pDim = 162;
			ChemStrX.Clone3DArray(ref pToArray, ref pCopyArray, ref pDim2, ref pDim, ref COFintNumRelModels);
			Globals_Renamed.arRelModParmsVC = (short[,,])pCopyArray;
			COFarRelModParmsVC = (short[,,])pToArray;
			pToArray = COFarRelModDRR;
			pCopyArray = Globals_Renamed.arRelModDRR;
			pDim2 = 2;
			ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref COFintNumRelModels);
			Globals_Renamed.arRelModDRR = (float[,])pCopyArray;
			COFarRelModDRR = (float[,])pToArray;
			pToArray = COFarRelModARR;
			pCopyArray = Globals_Renamed.arRelModARR;
			pDim2 = 2;
			ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref COFintNumRelModels);
			Globals_Renamed.arRelModARR = (float[,])pCopyArray;
			COFarRelModARR = (float[,])pToArray;
			pToArray = COFarRelModDOR;
			pCopyArray = Globals_Renamed.arRelModDOR;
			pDim2 = 2;
			ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref COFintNumRelModels);
			Globals_Renamed.arRelModDOR = (short[,])pCopyArray;
			COFarRelModDOR = (short[,])pToArray;
			Globals_Renamed.intNumExpModels = COFintNumExpModels;
			Globals_Renamed.arExpModels = new short[3, 26, Globals_Renamed.intNumOps + 1];
			pToArray = COFarExpModels;
			pCopyArray = Globals_Renamed.arExpModels;
			pDim2 = 2;
			pDim = 25;
			ChemStrX.Clone3DArray(ref pToArray, ref pCopyArray, ref pDim2, ref pDim, ref Globals_Renamed.intNumOps);
			Globals_Renamed.arExpModels = (short[,,])pCopyArray;
			COFarExpModels = (short[,,])pToArray;
			Globals_Renamed.arExpModType = new short[Globals_Renamed.intNumExpModels + 1];
			Globals_Renamed.arExpModBasis = new string[Globals_Renamed.intNumExpModels + 1];
			Globals_Renamed.arExpModOutputOn = new short[3, Globals_Renamed.intNumExpModels + 1];
			Globals_Renamed.arExpModChar = new string[3, Globals_Renamed.intNumExpModels + 1];
			Globals_Renamed.arExpModChmSt = new short[Globals_Renamed.intNumExpModels + 1];
			Globals_Renamed.arExpModUncertainty = new short[Globals_Renamed.intNumExpModels + 1];
			Globals_Renamed.arExpModStatus = new short[Globals_Renamed.intNumExpModels + 1];
			Globals_Renamed.arExpModParmsV = new float[3, 163, Globals_Renamed.intNumExpModels + 1];
			Globals_Renamed.arExpModParmsT = new short[3, 163, Globals_Renamed.intNumExpModels + 1];
			Globals_Renamed.arExpModParmsVC = new short[3, 163, Globals_Renamed.intNumExpModels + 1];
			Globals_Renamed.arExpModEst = new float[3, 19, Globals_Renamed.intNumExpModels + 1];
			Globals_Renamed.arExpModInhRC = new string[5, Globals_Renamed.intNumExpModels + 1];
			pToArray = COFarExpModType;
			pCopyArray = Globals_Renamed.arExpModType;
			ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref Globals_Renamed.intNumExpModels);
			Globals_Renamed.arExpModType = (short[])pCopyArray;
			COFarExpModType = (short[])pToArray;
			pToArray = COFarExpModOutputOn;
			pCopyArray = Globals_Renamed.arExpModOutputOn;
			pDim2 = 2;
			ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref Globals_Renamed.intNumExpModels);
			Globals_Renamed.arExpModOutputOn = (short[,])pCopyArray;
			COFarExpModOutputOn = (short[,])pToArray;
			pToArray = COFarExpModChar;
			pCopyArray = Globals_Renamed.arExpModChar;
			pDim2 = 2;
			ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref Globals_Renamed.intNumExpModels);
			Globals_Renamed.arExpModChar = (string[,])pCopyArray;
			COFarExpModChar = (string[,])pToArray;
			pToArray = COFarExpModBasis;
			pCopyArray = Globals_Renamed.arExpModBasis;
			ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref Globals_Renamed.intNumExpModels);
			Globals_Renamed.arExpModBasis = (string[])pCopyArray;
			COFarExpModBasis = (string[])pToArray;
			pToArray = COFarExpModChmSt;
			pCopyArray = Globals_Renamed.arExpModChmSt;
			ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref Globals_Renamed.intNumExpModels);
			Globals_Renamed.arExpModChmSt = (short[])pCopyArray;
			COFarExpModChmSt = (short[])pToArray;
			pToArray = COFarExpModUncertainty;
			pCopyArray = Globals_Renamed.arExpModUncertainty;
			ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref Globals_Renamed.intNumExpModels);
			Globals_Renamed.arExpModUncertainty = (short[])pCopyArray;
			COFarExpModUncertainty = (short[])pToArray;
			pToArray = COFarExpModStatus;
			pCopyArray = Globals_Renamed.arExpModStatus;
			ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref Globals_Renamed.intNumExpModels);
			Globals_Renamed.arExpModStatus = (short[])pCopyArray;
			COFarExpModStatus = (short[])pToArray;
			pToArray = COFarExpModParmsV;
			pCopyArray = Globals_Renamed.arExpModParmsV;
			pDim2 = 2;
			pDim = 162;
			ChemStrX.Clone3DArray(ref pToArray, ref pCopyArray, ref pDim2, ref pDim, ref Globals_Renamed.intNumExpModels);
			Globals_Renamed.arExpModParmsV = (float[,,])pCopyArray;
			COFarExpModParmsV = (float[,,])pToArray;
			pToArray = COFarExpModParmsT;
			pCopyArray = Globals_Renamed.arExpModParmsT;
			pDim2 = 2;
			pDim = 162;
			ChemStrX.Clone3DArray(ref pToArray, ref pCopyArray, ref pDim2, ref pDim, ref Globals_Renamed.intNumExpModels);
			Globals_Renamed.arExpModParmsT = (short[,,])pCopyArray;
			COFarExpModParmsT = (short[,,])pToArray;
			pToArray = COFarExpModParmsVC;
			pCopyArray = Globals_Renamed.arExpModParmsVC;
			pDim2 = 2;
			pDim = 162;
			ChemStrX.Clone3DArray(ref pToArray, ref pCopyArray, ref pDim2, ref pDim, ref Globals_Renamed.intNumExpModels);
			Globals_Renamed.arExpModParmsVC = (short[,,])pCopyArray;
			COFarExpModParmsVC = (short[,,])pToArray;
			pToArray = COFarExpModEst;
			pCopyArray = Globals_Renamed.arExpModEst;
			pDim2 = 2;
			pDim = 18;
			ChemStrX.Clone3DArray(ref pToArray, ref pCopyArray, ref pDim2, ref pDim, ref Globals_Renamed.intNumExpModels);
			Globals_Renamed.arExpModEst = (float[,,])pCopyArray;
			COFarExpModEst = (float[,,])pToArray;
			pToArray = COFarExpModInhRC;
			pCopyArray = Globals_Renamed.arExpModInhRC;
			pDim2 = 4;
			ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref Globals_Renamed.intNumExpModels);
			Globals_Renamed.arExpModInhRC = (string[,])pCopyArray;
			COFarExpModInhRC = (string[,])pToArray;
			AxMSFlexGrid pGridCopy = msfSelActs;
			AxMSFlexGrid pGridTo = frmMain.DefInstance.msfSelActs;
			ChemStrX.CloneFlexGrid(ref pGridCopy, ref pGridTo);
			msfSelActs = pGridCopy;
			frmMain.DefInstance.PopRelActs();
			frmMain.DefInstance.LoadOpCmbs();
			frmMain.DefInstance.PrimeContainerSubTab();
			Globals_Renamed.gblIWasChanged = true;
			((Form)this).Close();
		}
	}

	public object SetUp()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		string text = default(string);
		object obj3 = default(object);
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
					clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
					Recordset recordset2 = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
					Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					ProjectData.ClearProjectError();
					num2 = 2;
					AxMSFlexGrid pGridCopy = frmMain.DefInstance.msfSelActs;
					AxMSFlexGrid pGridTo = msfSelActs;
					ChemStrX.CloneFlexGrid(ref pGridCopy, ref pGridTo);
					msfSelActs = pGridTo;
					checked
					{
						COFarContParms = new float[16, 26, Globals_Renamed.intNumOps + 1];
						object pCopyArray = Globals_Renamed.arContParms;
						object pToArray = COFarContParms;
						short pDim = 15;
						short pDim2 = 25;
						ChemStrX.Clone3DArray(ref pCopyArray, ref pToArray, ref pDim, ref pDim2, ref Globals_Renamed.intNumOps);
						COFarContParms = (float[,,])pToArray;
						Globals_Renamed.arContParms = (float[,,])pCopyArray;
						COFarContParmTypes = new short[16, 26, Globals_Renamed.intNumOps + 1];
						pToArray = Globals_Renamed.arContParmTypes;
						pCopyArray = COFarContParmTypes;
						pDim2 = 15;
						pDim = (short)msfSelActs.Rows;
						ChemStrX.Clone3DArray(ref pToArray, ref pCopyArray, ref pDim2, ref pDim, ref Globals_Renamed.intNumOps);
						COFarContParmTypes = (short[,,])pCopyArray;
						Globals_Renamed.arContParmTypes = (short[,,])pToArray;
						COFintNumRelModels = Globals_Renamed.intNumRelModels;
						COFarRelModels = new short[11, 26, Globals_Renamed.intNumOps + 1];
						COFarRelModType = new short[COFintNumRelModels + 1];
						COFarRelModBasis = new string[COFintNumRelModels + 1];
						COFarRelModNAICS = new string[COFintNumRelModels + 1];
						COFarRelModStatus = new short[COFintNumRelModels + 1];
						COFarRelModOutputOn = new short[3, COFintNumRelModels + 1];
						COFarRelModChar = new string[3, COFintNumRelModels + 1];
						COFarRelModMedia = new float[19, COFintNumRelModels + 1];
						COFarRelModParmsV = new float[3, 163, COFintNumRelModels + 1];
						COFarRelModParmsT = new short[3, 163, COFintNumRelModels + 1];
						COFarRelModParmsVC = new short[3, 163, COFintNumRelModels + 1];
						COFarRelModDRR = new float[3, COFintNumRelModels + 1];
						COFarRelModARR = new float[3, COFintNumRelModels + 1];
						COFarRelModDOR = new short[3, COFintNumRelModels + 1];
						pToArray = Globals_Renamed.arRelModels;
						pCopyArray = COFarRelModels;
						pDim2 = 10;
						pDim = 25;
						ChemStrX.Clone3DArray(ref pToArray, ref pCopyArray, ref pDim2, ref pDim, ref Globals_Renamed.intNumOps);
						COFarRelModels = (short[,,])pCopyArray;
						Globals_Renamed.arRelModels = (short[,,])pToArray;
						pToArray = Globals_Renamed.arRelModType;
						pCopyArray = COFarRelModType;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref COFintNumRelModels);
						COFarRelModType = (short[])pCopyArray;
						Globals_Renamed.arRelModType = (short[])pToArray;
						pToArray = Globals_Renamed.arRelModBasis;
						pCopyArray = COFarRelModBasis;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref COFintNumRelModels);
						COFarRelModBasis = (string[])pCopyArray;
						Globals_Renamed.arRelModBasis = (string[])pToArray;
						pToArray = Globals_Renamed.arRelModNAICS;
						pCopyArray = COFarRelModNAICS;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref COFintNumRelModels);
						COFarRelModNAICS = (string[])pCopyArray;
						Globals_Renamed.arRelModNAICS = (string[])pToArray;
						pToArray = Globals_Renamed.arRelModStatus;
						pCopyArray = COFarRelModStatus;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref COFintNumRelModels);
						COFarRelModStatus = (short[])pCopyArray;
						Globals_Renamed.arRelModStatus = (short[])pToArray;
						pToArray = Globals_Renamed.arRelModOutputOn;
						pCopyArray = COFarRelModOutputOn;
						pDim2 = 2;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref COFintNumRelModels);
						COFarRelModOutputOn = (short[,])pCopyArray;
						Globals_Renamed.arRelModOutputOn = (short[,])pToArray;
						pToArray = Globals_Renamed.arRelModChar;
						pCopyArray = COFarRelModChar;
						pDim2 = 2;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref COFintNumRelModels);
						COFarRelModChar = (string[,])pCopyArray;
						Globals_Renamed.arRelModChar = (string[,])pToArray;
						pToArray = Globals_Renamed.arRelModMedia;
						pCopyArray = COFarRelModMedia;
						pDim2 = 18;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref COFintNumRelModels);
						COFarRelModMedia = (float[,])pCopyArray;
						Globals_Renamed.arRelModMedia = (float[,])pToArray;
						pToArray = Globals_Renamed.arRelModParmsV;
						pCopyArray = COFarRelModParmsV;
						pDim2 = 2;
						pDim = 162;
						ChemStrX.Clone3DArray(ref pToArray, ref pCopyArray, ref pDim2, ref pDim, ref COFintNumRelModels);
						COFarRelModParmsV = (float[,,])pCopyArray;
						Globals_Renamed.arRelModParmsV = (float[,,])pToArray;
						pToArray = Globals_Renamed.arRelModParmsT;
						pCopyArray = COFarRelModParmsT;
						pDim2 = 2;
						pDim = 162;
						ChemStrX.Clone3DArray(ref pToArray, ref pCopyArray, ref pDim2, ref pDim, ref COFintNumRelModels);
						COFarRelModParmsT = (short[,,])pCopyArray;
						Globals_Renamed.arRelModParmsT = (short[,,])pToArray;
						pToArray = Globals_Renamed.arRelModParmsVC;
						pCopyArray = COFarRelModParmsVC;
						pDim2 = 2;
						pDim = 162;
						ChemStrX.Clone3DArray(ref pToArray, ref pCopyArray, ref pDim2, ref pDim, ref COFintNumRelModels);
						COFarRelModParmsVC = (short[,,])pCopyArray;
						Globals_Renamed.arRelModParmsVC = (short[,,])pToArray;
						pToArray = Globals_Renamed.arRelModDRR;
						pCopyArray = COFarRelModDRR;
						pDim2 = 2;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref COFintNumRelModels);
						COFarRelModDRR = (float[,])pCopyArray;
						Globals_Renamed.arRelModDRR = (float[,])pToArray;
						pToArray = Globals_Renamed.arRelModARR;
						pCopyArray = COFarRelModARR;
						pDim2 = 2;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref COFintNumRelModels);
						COFarRelModARR = (float[,])pCopyArray;
						Globals_Renamed.arRelModARR = (float[,])pToArray;
						pToArray = Globals_Renamed.arRelModDOR;
						pCopyArray = COFarRelModDOR;
						pDim2 = 2;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref COFintNumRelModels);
						COFarRelModDOR = (short[,])pCopyArray;
						Globals_Renamed.arRelModDOR = (short[,])pToArray;
						COFarExpModels = new short[3, 26, Globals_Renamed.intNumOps + 1];
						COFintNumExpModels = Globals_Renamed.intNumExpModels;
						COFarExpModType = new short[COFintNumExpModels + 1];
						COFarExpModOutputOn = new short[3, COFintNumExpModels + 1];
						COFarExpModChar = new string[3, COFintNumExpModels + 1];
						COFarExpModBasis = new string[COFintNumExpModels + 1];
						COFarExpModChmSt = new short[COFintNumExpModels + 1];
						COFarExpModUncertainty = new short[COFintNumExpModels + 1];
						COFarExpModStatus = new short[COFintNumExpModels + 1];
						COFarExpModParmsV = new float[3, 163, COFintNumExpModels + 1];
						COFarExpModParmsT = new short[3, 163, COFintNumExpModels + 1];
						COFarExpModParmsVC = new short[3, 163, COFintNumExpModels + 1];
						COFarExpModEst = new float[3, 19, COFintNumExpModels + 1];
						COFarExpModInhRC = new string[5, COFintNumExpModels + 1];
						pToArray = Globals_Renamed.arExpModels;
						pCopyArray = COFarExpModels;
						pDim2 = 2;
						pDim = 25;
						ChemStrX.Clone3DArray(ref pToArray, ref pCopyArray, ref pDim2, ref pDim, ref Globals_Renamed.intNumOps);
						COFarExpModels = (short[,,])pCopyArray;
						Globals_Renamed.arExpModels = (short[,,])pToArray;
						pToArray = Globals_Renamed.arExpModType;
						pCopyArray = COFarExpModType;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref COFintNumExpModels);
						COFarExpModType = (short[])pCopyArray;
						Globals_Renamed.arExpModType = (short[])pToArray;
						pToArray = Globals_Renamed.arExpModOutputOn;
						pCopyArray = COFarExpModOutputOn;
						pDim2 = 2;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref COFintNumExpModels);
						COFarExpModOutputOn = (short[,])pCopyArray;
						Globals_Renamed.arExpModOutputOn = (short[,])pToArray;
						pToArray = Globals_Renamed.arExpModChar;
						pCopyArray = COFarExpModChar;
						pDim2 = 2;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref COFintNumExpModels);
						COFarExpModChar = (string[,])pCopyArray;
						Globals_Renamed.arExpModChar = (string[,])pToArray;
						pToArray = Globals_Renamed.arExpModBasis;
						pCopyArray = COFarExpModBasis;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref COFintNumExpModels);
						COFarExpModBasis = (string[])pCopyArray;
						Globals_Renamed.arExpModBasis = (string[])pToArray;
						pToArray = Globals_Renamed.arExpModChmSt;
						pCopyArray = COFarExpModChmSt;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref COFintNumExpModels);
						COFarExpModChmSt = (short[])pCopyArray;
						Globals_Renamed.arExpModChmSt = (short[])pToArray;
						pToArray = Globals_Renamed.arExpModUncertainty;
						pCopyArray = COFarExpModUncertainty;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref COFintNumExpModels);
						COFarExpModUncertainty = (short[])pCopyArray;
						Globals_Renamed.arExpModUncertainty = (short[])pToArray;
						pToArray = Globals_Renamed.arExpModStatus;
						pCopyArray = COFarExpModStatus;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref COFintNumExpModels);
						COFarExpModStatus = (short[])pCopyArray;
						Globals_Renamed.arExpModStatus = (short[])pToArray;
						pToArray = Globals_Renamed.arExpModParmsV;
						pCopyArray = COFarExpModParmsV;
						pDim2 = 2;
						pDim = 162;
						ChemStrX.Clone3DArray(ref pToArray, ref pCopyArray, ref pDim2, ref pDim, ref COFintNumExpModels);
						COFarExpModParmsV = (float[,,])pCopyArray;
						Globals_Renamed.arExpModParmsV = (float[,,])pToArray;
						pToArray = Globals_Renamed.arExpModParmsT;
						pCopyArray = COFarExpModParmsT;
						pDim2 = 2;
						pDim = 162;
						ChemStrX.Clone3DArray(ref pToArray, ref pCopyArray, ref pDim2, ref pDim, ref COFintNumExpModels);
						COFarExpModParmsT = (short[,,])pCopyArray;
						Globals_Renamed.arExpModParmsT = (short[,,])pToArray;
						pToArray = Globals_Renamed.arExpModParmsVC;
						pCopyArray = COFarExpModParmsVC;
						pDim2 = 2;
						pDim = 162;
						ChemStrX.Clone3DArray(ref pToArray, ref pCopyArray, ref pDim2, ref pDim, ref COFintNumExpModels);
						COFarExpModParmsVC = (short[,,])pCopyArray;
						Globals_Renamed.arExpModParmsVC = (short[,,])pToArray;
						pToArray = Globals_Renamed.arExpModEst;
						pCopyArray = COFarExpModEst;
						pDim2 = 2;
						pDim = 18;
						ChemStrX.Clone3DArray(ref pToArray, ref pCopyArray, ref pDim2, ref pDim, ref COFintNumExpModels);
						COFarExpModEst = (float[,,])pCopyArray;
						Globals_Renamed.arExpModEst = (float[,,])pToArray;
						pToArray = Globals_Renamed.arExpModInhRC;
						pCopyArray = COFarExpModInhRC;
						pDim2 = 4;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref COFintNumExpModels);
						COFarExpModInhRC = (string[,])pCopyArray;
						Globals_Renamed.arExpModInhRC = (string[,])pToArray;
						command.ActiveConnection = Common.MyConn;
						command.CommandText = "pqryGetInstructions";
						command.CommandType = CommandTypeEnum.adCmdStoredProc;
						command.Parameters.Append(command.CreateParameter("pID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, 2));
						Command command2 = command;
						pToArray = Missing.Value;
						pCopyArray = Missing.Value;
						recordset = command2.Execute(out pToArray, ref pCopyArray);
						command.Parameters.Delete("pID");
						lblInstructions.Text = Conversions.ToString(recordset.Fields[0].Value);
						recordset.Close();
						((Control)txtInput).Visible = false;
					}
					if (((INodes)tvActs.Nodes).Count == 0)
					{
						recordset.CursorLocation = CursorLocationEnum.adUseClient;
						recordset.Open("SELECT * FROM qryListActCats", Common.MyConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
						while (!recordset.EOF)
						{
							bool flag = Operators.ConditionalCompareObjectEqual(recordset.Fields[4].Value, (object)0, false);
							if (!flag)
							{
								recordset2.CursorLocation = CursorLocationEnum.adUseClient;
								recordset2.Open(Operators.ConcatenateObject((object)string.Concat("SELECT ActID FROM ListOfValidActivities WHERE OpID=" + Conversions.ToString((int)Globals_Renamed.arOpType[Globals_Renamed.intOpIndex]), " AND ActID="), recordset.Fields[2].Value), Common.MyConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
								flag = !recordset2.EOF;
								recordset2.Close();
							}
							if (flag)
							{
								object value2;
								object value;
								object objectValue;
								object obj;
								object pToArray;
								object pCopyArray;
								Node val3;
								if (Operators.ConditionalCompareObjectNotEqual((object)text, recordset.Fields[0].Value, false))
								{
									text = Conversions.ToString(recordset.Fields[0].Value);
									Nodes nodes = tvActs.Nodes;
									pToArray = Missing.Value;
									pCopyArray = (object)(TreeRelationshipConstants)2;
									obj = Operators.ConcatenateObject((object)"Cat", recordset.Fields[3].Value);
									Field field = recordset.Fields[0];
									objectValue = RuntimeHelpers.GetObjectValue(field.Value);
									value = Missing.Value;
									value2 = Missing.Value;
									Node obj2 = ((INodes)nodes).Add(ref pToArray, ref pCopyArray, ref obj, ref objectValue, ref value, ref value2);
									field.Value = RuntimeHelpers.GetObjectValue(objectValue);
									val3 = obj2;
									string text2 = "";
								}
								Nodes nodes2 = tvActs.Nodes;
								value2 = Operators.ConcatenateObject((object)"Cat", recordset.Fields[3].Value);
								value = (object)(TreeRelationshipConstants)4;
								objectValue = Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Act", recordset.Fields[3].Value), (object)"-"), recordset.Fields[2].Value);
								obj = recordset.Fields[1];
								pToArray = Missing.Value;
								pCopyArray = Missing.Value;
								val3 = ((INodes)nodes2).Add(ref value2, ref value, ref objectValue, ref obj, ref pToArray, ref pCopyArray);
								arTwins[Conversions.ToInteger(recordset.Fields[2].Value)] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields[5].Value)));
							}
							recordset.MoveNext();
						}
						recordset.Close();
						recordset = null;
						recordset2 = null;
						command = null;
					}
					lblOperation.Text = "Selected Operation: " + frmMain.DefInstance._lstSelOps_0.Text;
					obj3 = true;
					goto end_IL_0001;
				}
				case 3658:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						string Eobject = ((Control)this).Name;
						string Efunction = "Setup";
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
			catch (object obj4) when (obj4 is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj4);
				try0001_dispatch = 3658;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		object result = obj3;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private void tvActs_DblClick(object eventSender, EventArgs eventArgs)
	{
		if (Operators.CompareString(Strings.Left(((INode)tvActs.SelectedItem).Key, 3), "Cat", false) != 0)
		{
			cmdAdd_Click(cmdAdd, new EventArgs());
		}
	}

	private void txtInput_TextChanged(object eventSender, EventArgs eventArgs)
	{
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		if (msfSelActs.Col > 1)
		{
			string text = Strings.UCase(Strings.Left(txtInput.Text, 1));
			if (Operators.CompareString(text, "Y", false) == 0)
			{
				txtInput.Text = "Yes";
			}
			else
			{
				if (Operators.CompareString(text, "N", false) != 0)
				{
					Interaction.MsgBox((object)"Please enter Yes or No", (MsgBoxStyle)64, (object)"Invalid Input");
					return;
				}
				txtInput.Text = "No";
				msfSelActs[msfSelActs.Row, checked(msfSelActs.Col + 2)] = "Pending";
			}
		}
		msfSelActs.Text = txtInput.Text;
	}

	public short GetModelIndex(ref string pType)
	{
		checked
		{
			short num7 = default(short);
			if (Operators.CompareString(pType, "R", false) == 0)
			{
				short num = (short)(Globals_Renamed.intNumOps - 1);
				short num2 = 0;
				while (true)
				{
					short num3 = num2;
					short num4 = num;
					if (num3 > num4)
					{
						break;
					}
					short num5 = 0;
					short num9;
					do
					{
						short num6 = 0;
						short num8;
						do
						{
							if (COFarRelModels[num6, num5, num2] > num7)
							{
								num7 = COFarRelModels[num6, num5, num2];
							}
							num6 = (short)unchecked(num6 + 1);
							num8 = num6;
							num4 = 9;
						}
						while (num8 <= num4);
						num5 = (short)unchecked(num5 + 1);
						num9 = num5;
						num4 = 24;
					}
					while (num9 <= num4);
					num2 = (short)unchecked(num2 + 1);
				}
			}
			else
			{
				short num10 = (short)(Globals_Renamed.intNumOps - 1);
				short num2 = 0;
				while (true)
				{
					short num11 = num2;
					short num4 = num10;
					if (num11 > num4)
					{
						break;
					}
					short num5 = 0;
					short num13;
					do
					{
						short num6 = 0;
						short num12;
						do
						{
							if (COFarRelModels[num6, num5, num2] > num7)
							{
								num7 = COFarRelModels[num6, num5, num2];
							}
							num6 = (short)unchecked(num6 + 1);
							num12 = num6;
							num4 = 1;
						}
						while (num12 <= num4);
						num5 = (short)unchecked(num5 + 1);
						num13 = num5;
						num4 = 24;
					}
					while (num13 <= num4);
					num2 = (short)unchecked(num2 + 1);
				}
			}
			return (short)(num7 + 1);
		}
	}

	private void SetResetContParms()
	{
		float[] array = new float[4];
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
		Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		command.ActiveConnection = Common.MyConn;
		command.CommandText = "pqryGetActContTab";
		command.CommandType = CommandTypeEnum.adCmdStoredProc;
		array[1] = 0f;
		array[2] = 0f;
		array[3] = 0f;
		checked
		{
			short num = (short)(msfSelActs.Rows - 1);
			short num2 = 1;
			short num4;
			while (true)
			{
				short num3 = num2;
				num4 = num;
				if (num3 > num4)
				{
					break;
				}
				unchecked
				{
					if (Versioned.IsNumeric((object)msfSelActs[(int)num2, 0]))
					{
						command.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, msfSelActs[(int)num2, 0]));
						Command command2 = command;
						object RecordsAffected = Missing.Value;
						object Parameters = Missing.Value;
						recordset = command2.Execute(out RecordsAffected, ref Parameters);
						command.Parameters.Delete("pActID");
						if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields[0].Value)))
						{
							if (Operators.ConditionalCompareObjectEqual(recordset.Fields[0].Value, (object)iContTab, false))
							{
								array[Conversions.ToInteger(recordset.Fields[1].Value)] = array[Conversions.ToInteger(recordset.Fields[1].Value)] + 1f;
							}
							recordset.Close();
						}
					}
				}
				num2 = (short)unchecked(num2 + 1);
			}
			num2 = 1;
			short num5;
			do
			{
				if (array[num2] > 0f)
				{
					array[num2] = 1f / array[num2];
				}
				num2 = (short)unchecked(num2 + 1);
				num5 = num2;
				num4 = 3;
			}
			while (num5 <= num4);
			short num6 = (short)(msfSelActs.Rows - 1);
			num2 = 1;
			while (true)
			{
				short num7 = num2;
				num4 = num6;
				if (num7 > num4)
				{
					break;
				}
				if (Versioned.IsNumeric((object)msfSelActs[unchecked((int)num2), 0]))
				{
					command.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, msfSelActs[unchecked((int)num2), 0]));
					Command command3 = command;
					object Parameters = Missing.Value;
					object RecordsAffected = Missing.Value;
					recordset = command3.Execute(out Parameters, ref RecordsAffected);
					command.Parameters.Delete("pActID");
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields[0].Value)) && Operators.ConditionalCompareObjectEqual(recordset.Fields[0].Value, (object)iContTab, false))
					{
						COFarContParms[4, num2 - 1, Globals_Renamed.intOpIndex] = array[Conversions.ToInteger(recordset.Fields[1].Value)];
					}
					recordset.Close();
				}
				num2 = (short)unchecked(num2 + 1);
			}
			short num8 = (short)(msfSelActs.Rows - 1);
			num2 = 1;
			while (true)
			{
				short num9 = num2;
				num4 = num8;
				if (num9 > num4)
				{
					break;
				}
				if (Versioned.IsNumeric((object)msfSelActs[unchecked((int)num2), 0]))
				{
					float num10 = Globals_Renamed.arOpParms[1, Globals_Renamed.intOpIndex] * COFarContParms[2, num2 - 1, Globals_Renamed.intOpIndex] * COFarContParms[6, num2 - 1, Globals_Renamed.intOpIndex];
					if (num10 == 0f)
					{
						COFarContParms[8, num2 - 1, Globals_Renamed.intOpIndex] = 0f;
					}
					else
					{
						COFarContParms[8, num2 - 1, Globals_Renamed.intOpIndex] = (float)(Globals_Renamed.arOpPv[Globals_Renamed.intOpIndex] * (double)COFarContParms[4, num2 - 1, Globals_Renamed.intOpIndex] / (double)num10);
					}
					if ((Globals_Renamed.arOpBorC[Globals_Renamed.intOpIndex] == 1) & (Globals_Renamed.arOpParms[17, Globals_Renamed.intOpIndex] < 1f))
					{
						COFarContParms[9, num2 - 1, Globals_Renamed.intOpIndex] = Globals_Renamed.arOpParms[16, Globals_Renamed.intOpIndex];
					}
					else
					{
						COFarContParms[9, num2 - 1, Globals_Renamed.intOpIndex] = Globals_Renamed.arOpParms[2, Globals_Renamed.intOpIndex];
					}
					if (COFarContParms[9, num2 - 1, Globals_Renamed.intOpIndex] == 0f)
					{
						COFarContParms[10, num2 - 1, Globals_Renamed.intOpIndex] = 0f;
					}
					else
					{
						COFarContParms[10, num2 - 1, Globals_Renamed.intOpIndex] = COFarContParms[8, num2 - 1, Globals_Renamed.intOpIndex] / COFarContParms[9, num2 - 1, Globals_Renamed.intOpIndex];
					}
					if (COFarContParms[1, num2 - 1, Globals_Renamed.intOpIndex] == 0f)
					{
						COFarContParms[7, num2 - 1, Globals_Renamed.intOpIndex] = 0f;
					}
					else
					{
						COFarContParms[7, num2 - 1, Globals_Renamed.intOpIndex] = COFarContParms[10, num2 - 1, Globals_Renamed.intOpIndex] / COFarContParms[1, num2 - 1, Globals_Renamed.intOpIndex];
					}
					COFarContParms[11, num2 - 1, Globals_Renamed.intOpIndex] = COFarContParms[6, num2 - 1, Globals_Renamed.intOpIndex] * COFarContParms[2, num2 - 1, Globals_Renamed.intOpIndex];
					COFarContParms[12, num2 - 1, Globals_Renamed.intOpIndex] = COFarContParms[6, num2 - 1, Globals_Renamed.intOpIndex] * COFarContParms[2, num2 - 1, Globals_Renamed.intOpIndex] * COFarContParms[10, num2 - 1, Globals_Renamed.intOpIndex];
				}
				num2 = (short)unchecked(num2 + 1);
			}
			recordset = null;
			command = null;
		}
	}

	private void msfSelActs_Enter(object sender, EventArgs e)
	{
	}
}
