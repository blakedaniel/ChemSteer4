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

internal class frmMDUpdOps : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("cmdMoveDown")]
	private Button _cmdMoveDown;

	[AccessedThroughProperty("cmdMoveUp")]
	private Button _cmdMoveUp;

	[AccessedThroughProperty("txtRename")]
	private TextBox _txtRename;

	[AccessedThroughProperty("msfSelOps")]
	private AxMSFlexGrid _msfSelOps;

	[AccessedThroughProperty("cmdRemove")]
	private Button _cmdRemove;

	[AccessedThroughProperty("cmdAdd")]
	private Button _cmdAdd;

	[AccessedThroughProperty("lstOps")]
	private ListBox _lstOps;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("cmdOk")]
	private Button _cmdOk;

	[AccessedThroughProperty("lblTab1Instructions")]
	private Label _lblTab1Instructions;

	[AccessedThroughProperty("_Label1_1")]
	private Label __Label1_1;

	[AccessedThroughProperty("_Label1_0")]
	private Label __Label1_0;

	[AccessedThroughProperty("tabOps")]
	private TabControl _tabOps;

	[AccessedThroughProperty("TabPage1")]
	private TabPage _TabPage1;

	[AccessedThroughProperty("TabPage2")]
	private TabPage _TabPage2;

	[AccessedThroughProperty("TabPage3")]
	private TabPage _TabPage3;

	[AccessedThroughProperty("lstGSS")]
	private ListBox _lstGSS;

	[AccessedThroughProperty("lblTab2Instructions")]
	private Label _lblTab2Instructions;

	[AccessedThroughProperty("lstImport")]
	private ListBox _lstImport;

	[AccessedThroughProperty("lblTab3Instructions")]
	private Label _lblTab3Instructions;

	[AccessedThroughProperty("cmdGssHelp")]
	private Button _cmdGssHelp;

	[AccessedThroughProperty("cmdSelectDifferentDB")]
	private Button _cmdSelectDifferentDB;

	[AccessedThroughProperty("Label1")]
	private LabelArray _Label1;

	private static frmMDUpdOps m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	private short COFintNumOps;

	private bool bChangedOrder;

	private bool[] COFarNoPre;

	private float[] COFarOpPV;

	private short[,] COFarSubOpID;

	private short[,] COFarSubPVf;

	private float[,] COFarSubPvOp;

	private string[,] COFarSelActs;

	private short[,] COFarSelActType;

	private bool[,] COFarSelActRa;

	private bool[,] COFarSelActEa;

	private short[,] COFarSelActRaDMP;

	private short[,] COFarSelActEaDMP;

	private short[,] COFarSelActVolatile;

	private int[,,] COFarActNumWorkers;

	private string[,] COFarActNW_Route;

	private short[,] COFarActOrder;

	private float[,] COFarOpParms;

	private short[,] COFarOpParmsType;

	private float[,,] COFarContParms;

	private short[,,] COFarContParmTypes;

	private short[] COFarOpBorC;

	private short[] COFarOpIoE;

	private short[,] COFarOpMassBalDisc;

	private float[,] COFarOpSP;

	private short[,] COFarOpSPType;

	private string[] COFarOpName;

	private short[] COFarOpNeedsMassBalance;

	private short[] COFarOpType;

	private short[] COFarOpOrder;

	private string[] COFarPSInto1;

	private string[] COFarPSInto2;

	private string[] COFarPSOut1;

	private string[] COFarPSOut2;

	private string[] COFarPSIn1;

	private string[] COFarPSIn2;

	private string[] COFarPDesc;

	private string[,] COFarNaics1;

	private string[,] COFarNaics2;

	private float[,] COFarMiscOpParms;

	private short[,] COFarGssOptions;

	private string[,] COFarGssOther;

	private string[] COFarBasis;

	private string[] COFarWaterBasis;

	private string[] COFarRelAddNotes;

	private string[] COFarExpAddNotes;

	private int[,] COFarOpNumWorkers;

	private string[] COFarOpNumWorkersBasis;

	private short[] COFarOpNumWorkersBasisEnabled;

	private string[] COFarInhalationBasis;

	private string[] COFarDermalBasis;

	private string[,] COFarOSName;

	private string[,] COFarOSAddr;

	private string[,] COFarOSCity;

	private string[,] COFarOSState;

	private string[,] COFarOSZip;

	private string[,] COFarOSCty;

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

	private short[,] COFarExpModOutputOn;

	private string[,] COFarExpModChar;

	private string[] COFarExpModBasis;

	private short[] COFarExpModChmSt;

	private short[] COFarExpModUncertainty;

	private short[] COFarExpModStatus;

	private float[,,] COFarExpModParmsV;

	private short[,,] COFarExpModParmsT;

	private short[,,] COFarExpModParmsVC;

	private float[,,] COFarExpModEst;

	private string[,] COFarExpModInhRC;

	private short iContTab;

	private object[] arGSS_PDF;

	private int newindex;

	private int importDataVersion;

	private bool bDidImport;

	private bool bWipeOutAllRelationships;

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

	public virtual TextBox txtRename
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtRename;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtRename_Leave;
			if (_txtRename != null)
			{
				((Control)_txtRename).Leave -= eventHandler;
			}
			_txtRename = value;
			if (_txtRename != null)
			{
				((Control)_txtRename).Leave += eventHandler;
			}
		}
	}

	public virtual AxMSFlexGrid msfSelOps
	{
		[DebuggerNonUserCode]
		get
		{
			return _msfSelOps;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = msfSelOps_Scroll;
			EventHandler eventHandler2 = msfSelOps_DblClick;
			EventHandler eventHandler3 = msfSelOps_ClickEvent;
			if (_msfSelOps != null)
			{
				_msfSelOps.Scroll -= eventHandler;
				_msfSelOps.DblClick -= eventHandler2;
				_msfSelOps.ClickEvent -= eventHandler3;
			}
			_msfSelOps = value;
			if (_msfSelOps != null)
			{
				_msfSelOps.Scroll += eventHandler;
				_msfSelOps.DblClick += eventHandler2;
				_msfSelOps.ClickEvent += eventHandler3;
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

	public virtual ListBox lstOps
	{
		[DebuggerNonUserCode]
		get
		{
			return _lstOps;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = lstOps_DoubleClick;
			if (_lstOps != null)
			{
				((Control)_lstOps).DoubleClick -= eventHandler;
			}
			_lstOps = value;
			if (_lstOps != null)
			{
				((Control)_lstOps).DoubleClick += eventHandler;
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

	public virtual Label lblTab1Instructions
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTab1Instructions;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTab1Instructions = value;
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

	internal virtual TabControl tabOps
	{
		[DebuggerNonUserCode]
		get
		{
			return _tabOps;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tabOps = value;
		}
	}

	internal virtual TabPage TabPage1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage1 = value;
		}
	}

	internal virtual TabPage TabPage2
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage2 = value;
		}
	}

	internal virtual TabPage TabPage3
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage3 = value;
		}
	}

	public virtual ListBox lstGSS
	{
		[DebuggerNonUserCode]
		get
		{
			return _lstGSS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = lstGSS_DoubleClick;
			if (_lstGSS != null)
			{
				((Control)_lstGSS).DoubleClick -= eventHandler;
			}
			_lstGSS = value;
			if (_lstGSS != null)
			{
				((Control)_lstGSS).DoubleClick += eventHandler;
			}
		}
	}

	public virtual Label lblTab2Instructions
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTab2Instructions;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTab2Instructions = value;
		}
	}

	public virtual ListBox lstImport
	{
		[DebuggerNonUserCode]
		get
		{
			return _lstImport;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = lstImport_DoubleClick;
			if (_lstImport != null)
			{
				((Control)_lstImport).DoubleClick -= eventHandler;
			}
			_lstImport = value;
			if (_lstImport != null)
			{
				((Control)_lstImport).DoubleClick += eventHandler;
			}
		}
	}

	public virtual Label lblTab3Instructions
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTab3Instructions;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTab3Instructions = value;
		}
	}

	public virtual Button cmdGssHelp
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdGssHelp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdGssHelp_Click;
			if (_cmdGssHelp != null)
			{
				((Control)_cmdGssHelp).Click -= eventHandler;
			}
			_cmdGssHelp = value;
			if (_cmdGssHelp != null)
			{
				((Control)_cmdGssHelp).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdSelectDifferentDB
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdSelectDifferentDB;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdSelectDifferentDB_Click;
			if (_cmdSelectDifferentDB != null)
			{
				((Control)_cmdSelectDifferentDB).Click -= eventHandler;
			}
			_cmdSelectDifferentDB = value;
			if (_cmdSelectDifferentDB != null)
			{
				((Control)_cmdSelectDifferentDB).Click += eventHandler;
			}
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

	public static frmMDUpdOps DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmMDUpdOps();
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

	public frmMDUpdOps()
	{
		((Form)this).Load += frmMDUpdOps_Load;
		__ENCAddToList(this);
		COFarNoPre = new bool[2];
		COFarOpPV = new float[2];
		COFarSubOpID = new short[2, 2];
		COFarSubPVf = new short[2, 2];
		COFarSubPvOp = new float[2, 2];
		COFarSelActs = new string[2, 2];
		COFarSelActType = new short[2, 2];
		COFarSelActRa = new bool[2, 2];
		COFarSelActEa = new bool[2, 2];
		COFarSelActRaDMP = new short[2, 2];
		COFarSelActEaDMP = new short[2, 2];
		COFarSelActVolatile = new short[2, 2];
		COFarActNumWorkers = new int[2, 2, 2];
		COFarActNW_Route = new string[2, 2];
		COFarActOrder = new short[2, 2];
		COFarOpParms = new float[2, 2];
		COFarOpParmsType = new short[2, 2];
		COFarContParms = new float[2, 2, 2];
		COFarContParmTypes = new short[2, 2, 2];
		COFarOpBorC = new short[2];
		COFarOpIoE = new short[2];
		COFarOpMassBalDisc = new short[2, 2];
		COFarOpSP = new float[2, 2];
		COFarOpSPType = new short[2, 2];
		COFarOpName = new string[2];
		COFarOpNeedsMassBalance = new short[2];
		COFarOpType = new short[2];
		COFarOpOrder = new short[2];
		COFarPSInto1 = new string[2];
		COFarPSInto2 = new string[2];
		COFarPSOut1 = new string[2];
		COFarPSOut2 = new string[2];
		COFarPSIn1 = new string[2];
		COFarPSIn2 = new string[2];
		COFarPDesc = new string[2];
		COFarNaics1 = new string[2, 2];
		COFarNaics2 = new string[2, 2];
		COFarMiscOpParms = new float[2, 2];
		COFarGssOptions = new short[2, 2];
		COFarGssOther = new string[2, 2];
		COFarBasis = new string[2];
		COFarWaterBasis = new string[2];
		COFarRelAddNotes = new string[2];
		COFarExpAddNotes = new string[2];
		COFarOpNumWorkers = new int[2, 2];
		COFarOpNumWorkersBasis = new string[2];
		COFarOpNumWorkersBasisEnabled = new short[2];
		COFarInhalationBasis = new string[2];
		COFarDermalBasis = new string[2];
		COFarOSName = new string[2, 2];
		COFarOSAddr = new string[2, 2];
		COFarOSCity = new string[2, 2];
		COFarOSState = new string[2, 2];
		COFarOSZip = new string[2, 2];
		COFarOSCty = new string[2, 2];
		COFarRelModels = new short[2, 2, 2];
		COFarExpModels = new short[2, 2, 2];
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
		COFarExpModOutputOn = new short[2, 2];
		COFarExpModChar = new string[2, 2];
		COFarExpModBasis = new string[2];
		COFarExpModChmSt = new short[2];
		COFarExpModUncertainty = new short[2];
		COFarExpModStatus = new short[2];
		COFarExpModParmsV = new float[2, 2, 2];
		COFarExpModParmsT = new short[2, 2, 2];
		COFarExpModParmsVC = new short[2, 2, 2];
		COFarExpModEst = new float[2, 2, 2];
		COFarExpModInhRC = new string[2, 2];
		arGSS_PDF = new object[2];
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
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected O, but got Unknown
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected O, but got Unknown
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected O, but got Unknown
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Expected O, but got Unknown
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Expected O, but got Unknown
		//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bb: Expected O, but got Unknown
		//IL_0684: Unknown result type (might be due to invalid IL or missing references)
		//IL_068e: Expected O, but got Unknown
		//IL_0751: Unknown result type (might be due to invalid IL or missing references)
		//IL_075b: Expected O, but got Unknown
		//IL_0824: Unknown result type (might be due to invalid IL or missing references)
		//IL_082e: Expected O, but got Unknown
		//IL_08f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0901: Expected O, but got Unknown
		//IL_09be: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c8: Expected O, but got Unknown
		//IL_0a98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa2: Expected O, but got Unknown
		//IL_0c58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dad: Expected O, but got Unknown
		//IL_0e74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7e: Expected O, but got Unknown
		//IL_0f35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3f: Expected O, but got Unknown
		//IL_10b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_10bf: Expected O, but got Unknown
		//IL_1186: Unknown result type (might be due to invalid IL or missing references)
		//IL_1190: Expected O, but got Unknown
		//IL_1246: Unknown result type (might be due to invalid IL or missing references)
		//IL_1250: Expected O, but got Unknown
		//IL_140a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1414: Expected O, but got Unknown
		//IL_1429: Unknown result type (might be due to invalid IL or missing references)
		//IL_1433: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMDUpdOps));
		ToolTip1 = new ToolTip(components);
		cmdMoveDown = new Button();
		cmdMoveUp = new Button();
		txtRename = new TextBox();
		msfSelOps = new AxMSFlexGrid();
		cmdRemove = new Button();
		cmdAdd = new Button();
		lstOps = new ListBox();
		cmdCancel = new Button();
		cmdOk = new Button();
		lblTab1Instructions = new Label();
		_Label1_1 = new Label();
		_Label1_0 = new Label();
		Label1 = new LabelArray(components);
		tabOps = new TabControl();
		TabPage1 = new TabPage();
		TabPage2 = new TabPage();
		cmdGssHelp = new Button();
		lstGSS = new ListBox();
		lblTab2Instructions = new Label();
		TabPage3 = new TabPage();
		cmdSelectDifferentDB = new Button();
		lstImport = new ListBox();
		lblTab3Instructions = new Label();
		((ISupportInitialize)msfSelOps).BeginInit();
		((ISupportInitialize)Label1).BeginInit();
		((Control)tabOps).SuspendLayout();
		((Control)TabPage1).SuspendLayout();
		((Control)TabPage2).SuspendLayout();
		((Control)TabPage3).SuspendLayout();
		((Control)this).SuspendLayout();
		((ButtonBase)cmdMoveDown).BackColor = SystemColors.Control;
		((Control)cmdMoveDown).Cursor = Cursors.Default;
		((Control)cmdMoveDown).Enabled = false;
		((Control)cmdMoveDown).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdMoveDown).ForeColor = SystemColors.ControlText;
		Button obj = cmdMoveDown;
		Point location = new Point(647, 375);
		((Control)obj).Location = location;
		((Control)cmdMoveDown).Name = "cmdMoveDown";
		((Control)cmdMoveDown).RightToLeft = (RightToLeft)0;
		Button obj2 = cmdMoveDown;
		Size size = new Size(57, 49);
		((Control)obj2).Size = size;
		((Control)cmdMoveDown).TabIndex = 6;
		((ButtonBase)cmdMoveDown).Text = "Move &Down";
		((ButtonBase)cmdMoveDown).UseVisualStyleBackColor = false;
		((ButtonBase)cmdMoveUp).BackColor = SystemColors.Control;
		((Control)cmdMoveUp).Cursor = Cursors.Default;
		((Control)cmdMoveUp).Enabled = false;
		((Control)cmdMoveUp).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdMoveUp).ForeColor = SystemColors.ControlText;
		Button obj3 = cmdMoveUp;
		location = new Point(647, 320);
		((Control)obj3).Location = location;
		((Control)cmdMoveUp).Name = "cmdMoveUp";
		((Control)cmdMoveUp).RightToLeft = (RightToLeft)0;
		Button obj4 = cmdMoveUp;
		size = new Size(57, 49);
		((Control)obj4).Size = size;
		((Control)cmdMoveUp).TabIndex = 5;
		((ButtonBase)cmdMoveUp).Text = "Move &Up";
		((ButtonBase)cmdMoveUp).UseVisualStyleBackColor = false;
		txtRename.AcceptsReturn = true;
		((TextBoxBase)txtRename).BackColor = Color.White;
		((Control)txtRename).Cursor = Cursors.IBeam;
		((Control)txtRename).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtRename).ForeColor = SystemColors.WindowText;
		TextBox obj5 = txtRename;
		location = new Point(240, 471);
		((Control)obj5).Location = location;
		((TextBoxBase)txtRename).MaxLength = 100;
		((Control)txtRename).Name = "txtRename";
		((Control)txtRename).RightToLeft = (RightToLeft)0;
		TextBox obj6 = txtRename;
		size = new Size(417, 20);
		((Control)obj6).Size = size;
		((Control)txtRename).TabIndex = 4;
		((Control)txtRename).Visible = false;
		AxMSFlexGrid obj7 = msfSelOps;
		location = new Point(16, 320);
		((Control)obj7).Location = location;
		((Control)msfSelOps).Name = "msfSelOps";
		((AxHost)msfSelOps).OcxState = (State)componentResourceManager.GetObject("msfSelOps.OcxState");
		AxMSFlexGrid obj8 = msfSelOps;
		size = new Size(625, 105);
		((Control)obj8).Size = size;
		((Control)msfSelOps).TabIndex = 3;
		((ButtonBase)cmdRemove).BackColor = SystemColors.Control;
		((Control)cmdRemove).Cursor = Cursors.Default;
		((Control)cmdRemove).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdRemove).ForeColor = SystemColors.ControlText;
		Button obj9 = cmdRemove;
		location = new Point(373, 272);
		((Control)obj9).Location = location;
		((Control)cmdRemove).Name = "cmdRemove";
		((Control)cmdRemove).RightToLeft = (RightToLeft)0;
		Button obj10 = cmdRemove;
		size = new Size(113, 25);
		((Control)obj10).Size = size;
		((Control)cmdRemove).TabIndex = 2;
		((ButtonBase)cmdRemove).Text = "&Remove from list";
		((ButtonBase)cmdRemove).UseVisualStyleBackColor = false;
		((ButtonBase)cmdAdd).BackColor = SystemColors.Control;
		((Control)cmdAdd).Cursor = Cursors.Default;
		((Control)cmdAdd).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdAdd).ForeColor = SystemColors.ControlText;
		Button obj11 = cmdAdd;
		location = new Point(240, 272);
		((Control)obj11).Location = location;
		((Control)cmdAdd).Name = "cmdAdd";
		((Control)cmdAdd).RightToLeft = (RightToLeft)0;
		Button obj12 = cmdAdd;
		size = new Size(113, 25);
		((Control)obj12).Size = size;
		((Control)cmdAdd).TabIndex = 1;
		((ButtonBase)cmdAdd).Text = "&Add to list";
		((ButtonBase)cmdAdd).UseVisualStyleBackColor = false;
		lstOps.BackColor = Color.White;
		((Control)lstOps).Cursor = Cursors.Default;
		lstOps.Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		lstOps.ForeColor = SystemColors.WindowText;
		lstOps.ItemHeight = 14;
		ListBox obj13 = lstOps;
		location = new Point(12, 13);
		((Control)obj13).Location = location;
		((Control)lstOps).Name = "lstOps";
		lstOps.RightToLeft = (RightToLeft)0;
		ListBox obj14 = lstOps;
		size = new Size(689, 60);
		((Control)obj14).Size = size;
		((Control)lstOps).TabIndex = 0;
		((ButtonBase)cmdCancel).BackColor = SystemColors.Control;
		((Control)cmdCancel).Cursor = Cursors.Default;
		cmdCancel.DialogResult = (DialogResult)2;
		((Control)cmdCancel).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCancel).ForeColor = SystemColors.ControlText;
		Button obj15 = cmdCancel;
		location = new Point(373, 440);
		((Control)obj15).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		((Control)cmdCancel).RightToLeft = (RightToLeft)0;
		Button obj16 = cmdCancel;
		size = new Size(81, 25);
		((Control)obj16).Size = size;
		((Control)cmdCancel).TabIndex = 8;
		((ButtonBase)cmdCancel).Text = "Cancel";
		((ButtonBase)cmdCancel).UseVisualStyleBackColor = false;
		((ButtonBase)cmdOk).BackColor = SystemColors.Control;
		((Control)cmdOk).Cursor = Cursors.Default;
		((Control)cmdOk).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdOk).ForeColor = SystemColors.ControlText;
		Button obj17 = cmdOk;
		location = new Point(277, 440);
		((Control)obj17).Location = location;
		((Control)cmdOk).Name = "cmdOk";
		((Control)cmdOk).RightToLeft = (RightToLeft)0;
		Button obj18 = cmdOk;
		size = new Size(81, 25);
		((Control)obj18).Size = size;
		((Control)cmdOk).TabIndex = 7;
		((ButtonBase)cmdOk).Text = "OK";
		((ButtonBase)cmdOk).UseVisualStyleBackColor = false;
		((Control)lblTab1Instructions).BackColor = SystemColors.Control;
		((Control)lblTab1Instructions).Cursor = Cursors.Default;
		((Control)lblTab1Instructions).Font = new Font("Arial", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblTab1Instructions).ForeColor = SystemColors.ControlText;
		Label obj19 = lblTab1Instructions;
		location = new Point(12, 85);
		((Control)obj19).Location = location;
		((Control)lblTab1Instructions).Name = "lblTab1Instructions";
		((Control)lblTab1Instructions).RightToLeft = (RightToLeft)0;
		Label obj20 = lblTab1Instructions;
		size = new Size(689, 129);
		((Control)obj20).Size = size;
		((Control)lblTab1Instructions).TabIndex = 11;
		lblTab1Instructions.Text = "xxx";
		((Control)_Label1_1).BackColor = SystemColors.Control;
		((Control)_Label1_1).Cursor = Cursors.Default;
		((Control)_Label1_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_1).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_1, (short)1);
		Label label1_ = _Label1_1;
		location = new Point(16, 304);
		((Control)label1_).Location = location;
		((Control)_Label1_1).Name = "_Label1_1";
		((Control)_Label1_1).RightToLeft = (RightToLeft)0;
		Label label1_2 = _Label1_1;
		size = new Size(185, 17);
		((Control)label1_2).Size = size;
		((Control)_Label1_1).TabIndex = 10;
		_Label1_1.Text = "Selected Operations:";
		((Control)_Label1_0).BackColor = SystemColors.Control;
		((Control)_Label1_0).Cursor = Cursors.Default;
		((Control)_Label1_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_0).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_0, (short)0);
		Label label1_3 = _Label1_0;
		location = new Point(8, 16);
		((Control)label1_3).Location = location;
		((Control)_Label1_0).Name = "_Label1_0";
		((Control)_Label1_0).RightToLeft = (RightToLeft)0;
		Label label1_4 = _Label1_0;
		size = new Size(129, 17);
		((Control)label1_4).Size = size;
		((Control)_Label1_0).TabIndex = 9;
		_Label1_0.Text = "Available Operations:";
		((Control)tabOps).Controls.Add((Control)(object)TabPage1);
		((Control)tabOps).Controls.Add((Control)(object)TabPage2);
		((Control)tabOps).Controls.Add((Control)(object)TabPage3);
		TabControl obj21 = tabOps;
		location = new Point(0, 0);
		((Control)obj21).Location = location;
		((Control)tabOps).Name = "tabOps";
		tabOps.SelectedIndex = 0;
		TabControl obj22 = tabOps;
		size = new Size(729, 259);
		((Control)obj22).Size = size;
		((Control)tabOps).TabIndex = 46;
		TabPage1.BackColor = SystemColors.Control;
		((Control)TabPage1).Controls.Add((Control)(object)lstOps);
		((Control)TabPage1).Controls.Add((Control)(object)lblTab1Instructions);
		TabPage tabPage = TabPage1;
		location = new Point(4, 23);
		tabPage.Location = location;
		((Control)TabPage1).Name = "TabPage1";
		TabPage tabPage2 = TabPage1;
		Padding padding = default(Padding);
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage2).Padding = padding;
		TabPage tabPage3 = TabPage1;
		size = new Size(721, 232);
		((Control)tabPage3).Size = size;
		TabPage1.TabIndex = 0;
		TabPage1.Text = "User Defined Operations";
		((Control)TabPage2).Controls.Add((Control)(object)cmdGssHelp);
		((Control)TabPage2).Controls.Add((Control)(object)lstGSS);
		((Control)TabPage2).Controls.Add((Control)(object)lblTab2Instructions);
		TabPage tabPage4 = TabPage2;
		location = new Point(4, 23);
		tabPage4.Location = location;
		((Control)TabPage2).Name = "TabPage2";
		TabPage tabPage5 = TabPage2;
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage5).Padding = padding;
		TabPage tabPage6 = TabPage2;
		size = new Size(721, 232);
		((Control)tabPage6).Size = size;
		TabPage2.TabIndex = 1;
		TabPage2.Text = "Generic Scenario Operations";
		TabPage2.UseVisualStyleBackColor = true;
		((ButtonBase)cmdGssHelp).BackColor = SystemColors.Control;
		((Control)cmdGssHelp).Cursor = Cursors.Default;
		((Control)cmdGssHelp).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdGssHelp).ForeColor = SystemColors.ControlText;
		Button obj23 = cmdGssHelp;
		location = new Point(633, 13);
		((Control)obj23).Location = location;
		((Control)cmdGssHelp).Name = "cmdGssHelp";
		((Control)cmdGssHelp).RightToLeft = (RightToLeft)0;
		Button obj24 = cmdGssHelp;
		size = new Size(78, 60);
		((Control)obj24).Size = size;
		((Control)cmdGssHelp).TabIndex = 47;
		((ButtonBase)cmdGssHelp).Text = "Generic Scenario &Help";
		((ButtonBase)cmdGssHelp).UseVisualStyleBackColor = false;
		lstGSS.BackColor = Color.White;
		((Control)lstGSS).Cursor = Cursors.Default;
		lstGSS.Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		lstGSS.ForeColor = SystemColors.WindowText;
		lstGSS.ItemHeight = 14;
		ListBox obj25 = lstGSS;
		location = new Point(12, 13);
		((Control)obj25).Location = location;
		((Control)lstGSS).Name = "lstGSS";
		lstGSS.RightToLeft = (RightToLeft)0;
		ListBox obj26 = lstGSS;
		size = new Size(615, 60);
		((Control)obj26).Size = size;
		((Control)lstGSS).TabIndex = 12;
		((Control)lblTab2Instructions).BackColor = SystemColors.Control;
		((Control)lblTab2Instructions).Cursor = Cursors.Default;
		((Control)lblTab2Instructions).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblTab2Instructions).ForeColor = SystemColors.ControlText;
		Label obj27 = lblTab2Instructions;
		location = new Point(12, 85);
		((Control)obj27).Location = location;
		((Control)lblTab2Instructions).Name = "lblTab2Instructions";
		((Control)lblTab2Instructions).RightToLeft = (RightToLeft)0;
		Label obj28 = lblTab2Instructions;
		size = new Size(688, 129);
		((Control)obj28).Size = size;
		((Control)lblTab2Instructions).TabIndex = 13;
		lblTab2Instructions.Text = "xxx";
		((Control)TabPage3).Controls.Add((Control)(object)cmdSelectDifferentDB);
		((Control)TabPage3).Controls.Add((Control)(object)lstImport);
		((Control)TabPage3).Controls.Add((Control)(object)lblTab3Instructions);
		TabPage tabPage7 = TabPage3;
		location = new Point(4, 23);
		tabPage7.Location = location;
		((Control)TabPage3).Name = "TabPage3";
		TabPage tabPage8 = TabPage3;
		size = new Size(721, 232);
		((Control)tabPage8).Size = size;
		TabPage3.TabIndex = 2;
		TabPage3.Text = "Import Operation";
		TabPage3.UseVisualStyleBackColor = true;
		((ButtonBase)cmdSelectDifferentDB).BackColor = SystemColors.Control;
		((Control)cmdSelectDifferentDB).Cursor = Cursors.Default;
		((Control)cmdSelectDifferentDB).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdSelectDifferentDB).ForeColor = SystemColors.ControlText;
		Button obj29 = cmdSelectDifferentDB;
		location = new Point(632, 13);
		((Control)obj29).Location = location;
		((Control)cmdSelectDifferentDB).Name = "cmdSelectDifferentDB";
		((Control)cmdSelectDifferentDB).RightToLeft = (RightToLeft)0;
		Button obj30 = cmdSelectDifferentDB;
		size = new Size(79, 60);
		((Control)obj30).Size = size;
		((Control)cmdSelectDifferentDB).TabIndex = 48;
		((ButtonBase)cmdSelectDifferentDB).Text = "Select assessment database";
		((ButtonBase)cmdSelectDifferentDB).UseVisualStyleBackColor = false;
		lstImport.BackColor = Color.White;
		((Control)lstImport).Cursor = Cursors.Default;
		lstImport.Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		lstImport.ForeColor = SystemColors.WindowText;
		lstImport.ItemHeight = 14;
		ListBox obj31 = lstImport;
		location = new Point(8, 13);
		((Control)obj31).Location = location;
		((Control)lstImport).Name = "lstImport";
		lstImport.RightToLeft = (RightToLeft)0;
		ListBox obj32 = lstImport;
		size = new Size(617, 60);
		((Control)obj32).Size = size;
		((Control)lstImport).TabIndex = 12;
		((Control)lblTab3Instructions).BackColor = SystemColors.Control;
		((Control)lblTab3Instructions).Cursor = Cursors.Default;
		((Control)lblTab3Instructions).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblTab3Instructions).ForeColor = SystemColors.ControlText;
		Label obj33 = lblTab3Instructions;
		location = new Point(12, 89);
		((Control)obj33).Location = location;
		((Control)lblTab3Instructions).Name = "lblTab3Instructions";
		((Control)lblTab3Instructions).RightToLeft = (RightToLeft)0;
		Label obj34 = lblTab3Instructions;
		size = new Size(688, 125);
		((Control)obj34).Size = size;
		((Control)lblTab3Instructions).TabIndex = 13;
		lblTab3Instructions.Text = "xxx";
		((Form)this).AcceptButton = (IButtonControl)(object)cmdOk;
		size = new Size(5, 13);
		((Form)this).AutoScaleBaseSize = size;
		((Form)this).BackColor = SystemColors.Control;
		((Form)this).CancelButton = (IButtonControl)(object)cmdCancel;
		size = new Size(727, 481);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)tabOps);
		((Control)this).Controls.Add((Control)(object)cmdMoveDown);
		((Control)this).Controls.Add((Control)(object)cmdMoveUp);
		((Control)this).Controls.Add((Control)(object)txtRename);
		((Control)this).Controls.Add((Control)(object)msfSelOps);
		((Control)this).Controls.Add((Control)(object)cmdRemove);
		((Control)this).Controls.Add((Control)(object)cmdAdd);
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)cmdOk);
		((Control)this).Controls.Add((Control)(object)_Label1_1);
		((Control)this).Controls.Add((Control)(object)_Label1_0);
		((Control)this).Cursor = Cursors.Default;
		((Control)this).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		location = new Point(250, 150);
		((Form)this).Location = location;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmMDUpdOps";
		((Control)this).RightToLeft = (RightToLeft)0;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Add / Update Operations";
		((ISupportInitialize)msfSelOps).EndInit();
		((ISupportInitialize)Label1).EndInit();
		((Control)tabOps).ResumeLayout(false);
		((Control)TabPage1).ResumeLayout(false);
		((Control)TabPage2).ResumeLayout(false);
		((Control)TabPage3).ResumeLayout(false);
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
						COFarSelActs = new string[26, Globals_Renamed.intNumOps + 1];
						COFarSelActType = new short[26, Globals_Renamed.intNumOps + 1];
						COFarSelActRa = new bool[26, Globals_Renamed.intNumOps + 1];
						COFarSelActEa = new bool[26, Globals_Renamed.intNumOps + 1];
						COFarSelActRaDMP = new short[26, Globals_Renamed.intNumOps + 1];
						COFarSelActEaDMP = new short[26, Globals_Renamed.intNumOps + 1];
						COFarSelActVolatile = new short[26, Globals_Renamed.intNumOps + 1];
						COFarActNumWorkers = new int[4, 26, Globals_Renamed.intNumOps + 1];
						COFarActNW_Route = new string[26, Globals_Renamed.intNumOps + 1];
						COFarActOrder = new short[26, Globals_Renamed.intNumOps + 1];
						COFarOpParms = new float[163, Globals_Renamed.intNumOps + 1];
						COFarOpParmsType = new short[163, Globals_Renamed.intNumOps + 1];
						COFarContParms = new float[16, 26, Globals_Renamed.intNumOps + 1];
						COFarContParmTypes = new short[16, 26, Globals_Renamed.intNumOps + 1];
						COFarOpBorC = new short[Globals_Renamed.intNumOps + 1];
						COFarOpIoE = new short[Globals_Renamed.intNumOps + 1];
						COFarOpMassBalDisc = new short[3, Globals_Renamed.intNumOps + 1];
						COFarOpSP = new float[49, Globals_Renamed.intNumOps + 1];
						COFarOpSPType = new short[49, Globals_Renamed.intNumOps + 1];
						COFarOpName = new string[Globals_Renamed.intNumOps + 1];
						COFarOpNeedsMassBalance = new short[Globals_Renamed.intNumOps + 1];
						COFarOpType = new short[Globals_Renamed.intNumOps + 1];
						COFarOpOrder = new short[Globals_Renamed.intNumOps + 1];
						COFarPSInto1 = new string[Globals_Renamed.intNumOps + 1];
						COFarPSInto2 = new string[Globals_Renamed.intNumOps + 1];
						COFarPSOut1 = new string[Globals_Renamed.intNumOps + 1];
						COFarPSOut2 = new string[Globals_Renamed.intNumOps + 1];
						COFarPSIn1 = new string[Globals_Renamed.intNumOps + 1];
						COFarPSIn2 = new string[Globals_Renamed.intNumOps + 1];
						COFarPDesc = new string[Globals_Renamed.intNumOps + 1];
						COFarBasis = new string[Globals_Renamed.intNumOps + 1];
						COFarWaterBasis = new string[Globals_Renamed.intNumOps + 1];
						COFarRelAddNotes = new string[Globals_Renamed.intNumOps + 1];
						COFarExpAddNotes = new string[Globals_Renamed.intNumOps + 1];
						COFarOpNumWorkers = new int[3, Globals_Renamed.intNumOps + 1];
						COFarOpNumWorkersBasis = new string[Globals_Renamed.intNumOps + 1];
						COFarOpNumWorkersBasisEnabled = new short[Globals_Renamed.intNumOps + 1];
						COFarInhalationBasis = new string[Globals_Renamed.intNumOps + 1];
						COFarDermalBasis = new string[Globals_Renamed.intNumOps + 1];
						COFarNaics1 = new string[100, Globals_Renamed.intNumOps + 1];
						COFarNaics2 = new string[100, Globals_Renamed.intNumOps + 1];
						COFarMiscOpParms = new float[3, Globals_Renamed.intNumOps + 1];
						COFarGssOptions = new short[163, Globals_Renamed.intNumOps + 1];
						COFarGssOther = new string[163, Globals_Renamed.intNumOps + 1];
						COFarOSName = new string[100, Globals_Renamed.intNumOps + 1];
						COFarOSAddr = new string[100, Globals_Renamed.intNumOps + 1];
						COFarOSCity = new string[100, Globals_Renamed.intNumOps + 1];
						COFarOSState = new string[100, Globals_Renamed.intNumOps + 1];
						COFarOSZip = new string[100, Globals_Renamed.intNumOps + 1];
						COFarOSCty = new string[100, Globals_Renamed.intNumOps + 1];
						COFarRelModels = new short[11, 26, Globals_Renamed.intNumOps + 1];
						COFarExpModels = new short[3, 26, Globals_Renamed.intNumOps + 1];
						object pCopyArray = Globals_Renamed.arSelActs;
						object pToArray = COFarSelActs;
						short pDim = 25;
						ChemStrX.Clone2DArray(ref pCopyArray, ref pToArray, ref pDim, ref Globals_Renamed.intNumOps);
						COFarSelActs = (string[,])pToArray;
						Globals_Renamed.arSelActs = (string[,])pCopyArray;
						pToArray = Globals_Renamed.arSelActType;
						pCopyArray = COFarSelActType;
						pDim = 25;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim, ref Globals_Renamed.intNumOps);
						COFarSelActType = (short[,])pCopyArray;
						Globals_Renamed.arSelActType = (short[,])pToArray;
						pToArray = Globals_Renamed.arSelActRa;
						pCopyArray = COFarSelActRa;
						pDim = 25;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim, ref Globals_Renamed.intNumOps);
						COFarSelActRa = (bool[,])pCopyArray;
						Globals_Renamed.arSelActRa = (bool[,])pToArray;
						pToArray = Globals_Renamed.arSelActEa;
						pCopyArray = COFarSelActEa;
						pDim = 25;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim, ref Globals_Renamed.intNumOps);
						COFarSelActEa = (bool[,])pCopyArray;
						Globals_Renamed.arSelActEa = (bool[,])pToArray;
						pToArray = Globals_Renamed.arSelActRaDMP;
						pCopyArray = COFarSelActRaDMP;
						pDim = 25;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim, ref Globals_Renamed.intNumOps);
						COFarSelActRaDMP = (short[,])pCopyArray;
						Globals_Renamed.arSelActRaDMP = (short[,])pToArray;
						pToArray = Globals_Renamed.arSelActEaDMP;
						pCopyArray = COFarSelActEaDMP;
						pDim = 25;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim, ref Globals_Renamed.intNumOps);
						COFarSelActEaDMP = (short[,])pCopyArray;
						Globals_Renamed.arSelActEaDMP = (short[,])pToArray;
						pToArray = Globals_Renamed.arSelActVolatile;
						pCopyArray = COFarSelActVolatile;
						pDim = 25;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim, ref Globals_Renamed.intNumOps);
						COFarSelActVolatile = (short[,])pCopyArray;
						Globals_Renamed.arSelActVolatile = (short[,])pToArray;
						pToArray = Globals_Renamed.arActNumWorkers;
						pCopyArray = COFarActNumWorkers;
						pDim = 3;
						short pDim2 = 25;
						ChemStrX.Clone3DArray(ref pToArray, ref pCopyArray, ref pDim, ref pDim2, ref Globals_Renamed.intNumOps);
						COFarActNumWorkers = (int[,,])pCopyArray;
						Globals_Renamed.arActNumWorkers = (long[,,])pToArray;
						pToArray = Globals_Renamed.arActNW_Route;
						pCopyArray = COFarActNW_Route;
						pDim2 = 25;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref Globals_Renamed.intNumOps);
						COFarActNW_Route = (string[,])pCopyArray;
						Globals_Renamed.arActNW_Route = (string[,])pToArray;
						pToArray = Globals_Renamed.arOpParms;
						pCopyArray = COFarOpParms;
						pDim2 = 162;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref Globals_Renamed.intNumOps);
						COFarOpParms = (float[,])pCopyArray;
						Globals_Renamed.arOpParms = (float[,])pToArray;
						pToArray = Globals_Renamed.arOpParmsType;
						pCopyArray = COFarOpParmsType;
						pDim2 = 162;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref Globals_Renamed.intNumOps);
						COFarOpParmsType = (short[,])pCopyArray;
						Globals_Renamed.arOpParmsType = (short[,])pToArray;
						pToArray = Globals_Renamed.arOpBorC;
						pCopyArray = COFarOpBorC;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref Globals_Renamed.intNumOps);
						COFarOpBorC = (short[])pCopyArray;
						Globals_Renamed.arOpBorC = (short[])pToArray;
						pToArray = Globals_Renamed.arOpIoE;
						pCopyArray = COFarOpIoE;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref Globals_Renamed.intNumOps);
						COFarOpIoE = (short[])pCopyArray;
						Globals_Renamed.arOpIoE = (short[])pToArray;
						pToArray = Globals_Renamed.arOpMassBalDisc;
						pCopyArray = COFarOpMassBalDisc;
						pDim2 = 2;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref Globals_Renamed.intNumOps);
						COFarOpMassBalDisc = (short[,])pCopyArray;
						Globals_Renamed.arOpMassBalDisc = (int[,])pToArray;
						pToArray = Globals_Renamed.arOpSP;
						pCopyArray = COFarOpSP;
						pDim2 = 48;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref Globals_Renamed.intNumOps);
						COFarOpSP = (float[,])pCopyArray;
						Globals_Renamed.arOpSP = (float[,])pToArray;
						pToArray = Globals_Renamed.arOpSPType;
						pCopyArray = COFarOpSPType;
						pDim2 = 48;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref Globals_Renamed.intNumOps);
						COFarOpSPType = (short[,])pCopyArray;
						Globals_Renamed.arOpSPType = (short[,])pToArray;
						pToArray = Globals_Renamed.arActOrder;
						pCopyArray = COFarActOrder;
						pDim2 = 25;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref Globals_Renamed.intNumOps);
						COFarActOrder = (short[,])pCopyArray;
						Globals_Renamed.arActOrder = (short[,])pToArray;
						pToArray = Globals_Renamed.arOpName;
						pCopyArray = COFarOpName;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref Globals_Renamed.intNumOps);
						COFarOpName = (string[])pCopyArray;
						Globals_Renamed.arOpName = (string[])pToArray;
						pToArray = Globals_Renamed.arOpNeedsMassBalance;
						pCopyArray = COFarOpNeedsMassBalance;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref Globals_Renamed.intNumOps);
						COFarOpNeedsMassBalance = (short[])pCopyArray;
						Globals_Renamed.arOpNeedsMassBalance = (short[])pToArray;
						pToArray = Globals_Renamed.arOpType;
						pCopyArray = COFarOpType;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref Globals_Renamed.intNumOps);
						COFarOpType = (short[])pCopyArray;
						Globals_Renamed.arOpType = (short[])pToArray;
						pToArray = Globals_Renamed.arOpOrder;
						pCopyArray = COFarOpOrder;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref Globals_Renamed.intNumOps);
						COFarOpOrder = (short[])pCopyArray;
						Globals_Renamed.arOpOrder = (short[])pToArray;
						pToArray = Globals_Renamed.arContParms;
						pCopyArray = COFarContParms;
						pDim2 = 15;
						pDim = 25;
						ChemStrX.Clone3DArray(ref pToArray, ref pCopyArray, ref pDim2, ref pDim, ref Globals_Renamed.intNumOps);
						COFarContParms = (float[,,])pCopyArray;
						Globals_Renamed.arContParms = (float[,,])pToArray;
						pToArray = Globals_Renamed.arContParmTypes;
						pCopyArray = COFarContParmTypes;
						pDim2 = 15;
						pDim = 25;
						ChemStrX.Clone3DArray(ref pToArray, ref pCopyArray, ref pDim2, ref pDim, ref Globals_Renamed.intNumOps);
						COFarContParmTypes = (short[,,])pCopyArray;
						Globals_Renamed.arContParmTypes = (short[,,])pToArray;
						pToArray = Globals_Renamed.arNaics1;
						pCopyArray = COFarNaics1;
						pDim2 = 99;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref Globals_Renamed.intNumOps);
						COFarNaics1 = (string[,])pCopyArray;
						Globals_Renamed.arNaics1 = (string[,])pToArray;
						pToArray = Globals_Renamed.arNaics2;
						pCopyArray = COFarNaics2;
						pDim2 = 99;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref Globals_Renamed.intNumOps);
						COFarNaics2 = (string[,])pCopyArray;
						Globals_Renamed.arNaics2 = (string[,])pToArray;
						pToArray = Globals_Renamed.arOSName;
						pCopyArray = COFarOSName;
						pDim2 = 99;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref Globals_Renamed.intNumOps);
						COFarOSName = (string[,])pCopyArray;
						Globals_Renamed.arOSName = (string[,])pToArray;
						pToArray = Globals_Renamed.arOSAddr;
						pCopyArray = COFarOSAddr;
						pDim2 = 99;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref Globals_Renamed.intNumOps);
						COFarOSAddr = (string[,])pCopyArray;
						Globals_Renamed.arOSAddr = (string[,])pToArray;
						pToArray = Globals_Renamed.arOSCity;
						pCopyArray = COFarOSCity;
						pDim2 = 99;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref Globals_Renamed.intNumOps);
						COFarOSCity = (string[,])pCopyArray;
						Globals_Renamed.arOSCity = (string[,])pToArray;
						pToArray = Globals_Renamed.arOSState;
						pCopyArray = COFarOSState;
						pDim2 = 99;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref Globals_Renamed.intNumOps);
						COFarOSState = (string[,])pCopyArray;
						Globals_Renamed.arOSState = (string[,])pToArray;
						pToArray = Globals_Renamed.arOSZip;
						pCopyArray = COFarOSZip;
						pDim2 = 99;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref Globals_Renamed.intNumOps);
						COFarOSZip = (string[,])pCopyArray;
						Globals_Renamed.arOSZip = (string[,])pToArray;
						pToArray = Globals_Renamed.arOSCty;
						pCopyArray = COFarOSCty;
						pDim2 = 99;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref Globals_Renamed.intNumOps);
						COFarOSCty = (string[,])pCopyArray;
						Globals_Renamed.arOSCty = (string[,])pToArray;
						pToArray = Globals_Renamed.arMiscOpParms;
						pCopyArray = COFarMiscOpParms;
						pDim2 = 2;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref Globals_Renamed.intNumOps);
						COFarMiscOpParms = (float[,])pCopyArray;
						Globals_Renamed.arMiscOpParms = (float[,])pToArray;
						pToArray = Globals_Renamed.arPSInto1;
						pCopyArray = COFarPSInto1;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref Globals_Renamed.intNumOps);
						COFarPSInto1 = (string[])pCopyArray;
						Globals_Renamed.arPSInto1 = (string[])pToArray;
						pToArray = Globals_Renamed.arPSInto2;
						pCopyArray = COFarPSInto2;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref Globals_Renamed.intNumOps);
						COFarPSInto2 = (string[])pCopyArray;
						Globals_Renamed.arPSInto2 = (string[])pToArray;
						pToArray = Globals_Renamed.arPSOut1;
						pCopyArray = COFarPSOut1;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref Globals_Renamed.intNumOps);
						COFarPSOut1 = (string[])pCopyArray;
						Globals_Renamed.arPSOut1 = (string[])pToArray;
						pToArray = Globals_Renamed.arPSOut2;
						pCopyArray = COFarPSOut2;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref Globals_Renamed.intNumOps);
						COFarPSOut2 = (string[])pCopyArray;
						Globals_Renamed.arPSOut2 = (string[])pToArray;
						pToArray = Globals_Renamed.arPSIn1;
						pCopyArray = COFarPSIn1;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref Globals_Renamed.intNumOps);
						COFarPSIn1 = (string[])pCopyArray;
						Globals_Renamed.arPSIn1 = (string[])pToArray;
						pToArray = Globals_Renamed.arPSIn2;
						pCopyArray = COFarPSIn2;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref Globals_Renamed.intNumOps);
						COFarPSIn2 = (string[])pCopyArray;
						Globals_Renamed.arPSIn2 = (string[])pToArray;
						pToArray = Globals_Renamed.arPDesc;
						pCopyArray = COFarPDesc;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref Globals_Renamed.intNumOps);
						COFarPDesc = (string[])pCopyArray;
						Globals_Renamed.arPDesc = (string[])pToArray;
						pToArray = Globals_Renamed.arBasis;
						pCopyArray = COFarBasis;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref Globals_Renamed.intNumOps);
						COFarBasis = (string[])pCopyArray;
						Globals_Renamed.arBasis = (string[])pToArray;
						pToArray = Globals_Renamed.arWaterBasis;
						pCopyArray = COFarWaterBasis;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref Globals_Renamed.intNumOps);
						COFarWaterBasis = (string[])pCopyArray;
						Globals_Renamed.arWaterBasis = (string[])pToArray;
						pToArray = Globals_Renamed.arRelAddNotes;
						pCopyArray = COFarRelAddNotes;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref Globals_Renamed.intNumOps);
						COFarRelAddNotes = (string[])pCopyArray;
						Globals_Renamed.arRelAddNotes = (string[])pToArray;
						pToArray = Globals_Renamed.arExpAddNotes;
						pCopyArray = COFarExpAddNotes;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref Globals_Renamed.intNumOps);
						COFarExpAddNotes = (string[])pCopyArray;
						Globals_Renamed.arExpAddNotes = (string[])pToArray;
						pToArray = Globals_Renamed.arOpNumWorkers;
						pCopyArray = COFarOpNumWorkers;
						pDim2 = 2;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref Globals_Renamed.intNumOps);
						COFarOpNumWorkers = (int[,])pCopyArray;
						Globals_Renamed.arOpNumWorkers = (long[,])pToArray;
						pToArray = Globals_Renamed.arOpNumWorkersBasis;
						pCopyArray = COFarOpNumWorkersBasis;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref Globals_Renamed.intNumOps);
						COFarOpNumWorkersBasis = (string[])pCopyArray;
						Globals_Renamed.arOpNumWorkersBasis = (string[])pToArray;
						pToArray = Globals_Renamed.arOpNumWorkersBasisEnabled;
						pCopyArray = COFarOpNumWorkersBasisEnabled;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref Globals_Renamed.intNumOps);
						COFarOpNumWorkersBasisEnabled = (short[])pCopyArray;
						Globals_Renamed.arOpNumWorkersBasisEnabled = (short[])pToArray;
						pToArray = Globals_Renamed.arInhalationBasis;
						pCopyArray = COFarInhalationBasis;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref Globals_Renamed.intNumOps);
						COFarInhalationBasis = (string[])pCopyArray;
						Globals_Renamed.arInhalationBasis = (string[])pToArray;
						pToArray = Globals_Renamed.arDermalBasis;
						pCopyArray = COFarDermalBasis;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref Globals_Renamed.intNumOps);
						COFarDermalBasis = (string[])pCopyArray;
						Globals_Renamed.arDermalBasis = (string[])pToArray;
						pToArray = Globals_Renamed.arGssOptions;
						pCopyArray = COFarGssOptions;
						pDim2 = 162;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref Globals_Renamed.intNumOps);
						COFarGssOptions = (short[,])pCopyArray;
						Globals_Renamed.arGssOptions = (short[,])pToArray;
						pToArray = Globals_Renamed.arGssOther;
						pCopyArray = COFarGssOther;
						pDim2 = 162;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref Globals_Renamed.intNumOps);
						COFarGssOther = (string[,])pCopyArray;
						Globals_Renamed.arGssOther = (string[,])pToArray;
						command.ActiveConnection = Common.MyConn;
						command.CommandText = "pqryGetInstructions";
						command.CommandType = CommandTypeEnum.adCmdStoredProc;
						command.Parameters.Append(command.CreateParameter("pID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, 19));
						Command command2 = command;
						pToArray = Missing.Value;
						pCopyArray = Missing.Value;
						recordset = command2.Execute(out pToArray, ref pCopyArray);
						command.Parameters.Delete("pID");
						lblTab1Instructions.Text = Conversions.ToString(recordset.Fields[0].Value);
						command.Parameters.Append(command.CreateParameter("pID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, 50));
						Command command3 = command;
						pToArray = Missing.Value;
						pCopyArray = Missing.Value;
						recordset = command3.Execute(out pToArray, ref pCopyArray);
						command.Parameters.Delete("pID");
						lblTab2Instructions.Text = Conversions.ToString(recordset.Fields[0].Value);
						command.Parameters.Append(command.CreateParameter("pID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, 51));
						Command command4 = command;
						pToArray = Missing.Value;
						pCopyArray = Missing.Value;
						recordset = command4.Execute(out pToArray, ref pCopyArray);
						command.Parameters.Delete("pID");
						lblTab3Instructions.Text = Conversions.ToString(recordset.Fields[0].Value);
						recordset.Close();
						if (Globals_Renamed.intNumOps == 0)
						{
							msfSelOps.AddItem("");
						}
						else
						{
							short num3 = (short)(Globals_Renamed.intNumOps - 1);
							short num4 = 0;
							while (true)
							{
								short num5 = num4;
								short num6 = num3;
								if (num5 > num6)
								{
									break;
								}
								msfSelOps.AddItem(unchecked(Conversions.ToString((int)Globals_Renamed.arOpType[Support.GetItemData((Control)(object)frmMain.DefInstance._lstSelOps_0, (int)num4)]) + "\t" + Conversions.ToString(Support.GetItemData((Control)(object)frmMain.DefInstance._lstSelOps_0, (int)num4)) + "\t" + Support.GetItemString((Control)(object)frmMain.DefInstance._lstSelOps_0, (int)num4)));
								num4 = (short)unchecked(num4 + 1);
							}
						}
						COFintNumOps = Globals_Renamed.intNumOps;
						pToArray = Globals_Renamed.arRelModels;
						pCopyArray = COFarRelModels;
						pDim2 = 10;
						pDim = 25;
						ChemStrX.Clone3DArray(ref pToArray, ref pCopyArray, ref pDim2, ref pDim, ref COFintNumOps);
						COFarRelModels = (short[,,])pCopyArray;
						Globals_Renamed.arRelModels = (short[,,])pToArray;
						pToArray = Globals_Renamed.arExpModels;
						pCopyArray = COFarExpModels;
						pDim2 = 2;
						pDim = 25;
						ChemStrX.Clone3DArray(ref pToArray, ref pCopyArray, ref pDim2, ref pDim, ref COFintNumOps);
						COFarExpModels = (short[,,])pCopyArray;
						Globals_Renamed.arExpModels = (short[,,])pToArray;
						COFintNumRelModels = Globals_Renamed.intNumRelModels;
						COFintNumExpModels = Globals_Renamed.intNumExpModels;
						COFarNoPre = new bool[COFintNumOps + 1];
						COFarOpPV = new float[COFintNumOps + 1];
						COFarSubOpID = new short[11, COFintNumOps + 1];
						COFarSubPVf = new short[11, COFintNumOps + 1];
						COFarSubPvOp = new float[11, COFintNumOps + 1];
						pToArray = Globals_Renamed.arNoPre;
						pCopyArray = COFarNoPre;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref COFintNumOps);
						COFarNoPre = (bool[])pCopyArray;
						Globals_Renamed.arNoPre = (bool[])pToArray;
						pToArray = Globals_Renamed.arOpPv;
						pCopyArray = COFarOpPV;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref COFintNumOps);
						COFarOpPV = (float[])pCopyArray;
						Globals_Renamed.arOpPv = (double[])pToArray;
						pToArray = Globals_Renamed.arSubOpID;
						pCopyArray = COFarSubOpID;
						pDim2 = 10;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref COFintNumOps);
						COFarSubOpID = (short[,])pCopyArray;
						Globals_Renamed.arSubOpID = (short[,])pToArray;
						pToArray = Globals_Renamed.arSubPVf;
						pCopyArray = COFarSubPVf;
						pDim2 = 10;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref COFintNumOps);
						COFarSubPVf = (short[,])pCopyArray;
						Globals_Renamed.arSubPVf = (float[,])pToArray;
						pToArray = Globals_Renamed.arSubPvOp;
						pCopyArray = COFarSubPvOp;
						pDim2 = 10;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref COFintNumOps);
						COFarSubPvOp = (float[,])pCopyArray;
						Globals_Renamed.arSubPvOp = (double[,])pToArray;
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
						recordset = null;
						command = null;
						flag = true;
						goto end_IL_0001;
					}
					case 7428:
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
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 7428;
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

	private void frmMDUpdOps_Load(object eventSender, EventArgs eventArgs)
	{
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		recordset.CursorLocation = CursorLocationEnum.adUseClient;
		recordset.Open("SELECT * FROM qryListOfOperations WHERE OpID < 100", Common.MyConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
		while (!recordset.EOF)
		{
			newindex = lstOps.Items.Add(RuntimeHelpers.GetObjectValue(recordset.Fields["OpName"].Value));
			if (Operators.ConditionalCompareObjectEqual(recordset.Fields["OpStatus"].Value, (object)1, false))
			{
				Support.SetItemData((Control)(object)lstOps, newindex, Conversions.ToInteger(recordset.Fields["OpID"].Value));
			}
			recordset.MoveNext();
		}
		recordset.Close();
		bChangedOrder = false;
		recordset.Open("SELECT * FROM qryListGSS", Common.gssConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
		while (!recordset.EOF)
		{
			newindex = lstGSS.Items.Add(RuntimeHelpers.GetObjectValue(recordset.Fields["OpName"].Value));
			Support.SetItemData((Control)(object)lstGSS, newindex, Conversions.ToInteger(recordset.Fields["OpID"].Value));
			arGSS_PDF = (object[])Utils.CopyArray((Array)arGSS_PDF, (Array)new object[checked(newindex + 1)]);
			arGSS_PDF[newindex] = RuntimeHelpers.GetObjectValue(recordset.Fields["GSS_PDF"].Value);
			recordset.MoveNext();
		}
		recordset.Close();
		recordset = null;
		msfSelOps[0] = 1;
		msfSelOps[1] = 1;
		msfSelOps[2] = 6100;
		msfSelOps[2] = 0;
	}

	private void cmdOk_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_1b3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b07: Unknown result type (might be due to invalid IL or missing references)
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
						Cursor.Current = Cursors.WaitCursor;
						ProjectData.ClearProjectError();
						num2 = 2;
						Globals_Renamed.intNumOps = COFintNumOps;
						Globals_Renamed.arNoPre = new bool[Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arOpPv = new double[Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arSubOpID = new short[11, Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arSubPVf = new float[11, Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arSubPvOp = new double[11, Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arSelActs = new string[26, Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arSelActType = new short[26, Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arSelActRa = new bool[26, Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arSelActEa = new bool[26, Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arSelActRaDMP = new short[26, Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arSelActEaDMP = new short[26, Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arSelActVolatile = new short[26, Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arActNumWorkers = new long[4, 26, Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arActNW_Route = new string[26, Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arActOrder = new short[26, Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arPSInto1 = new string[Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arPSInto2 = new string[Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arPSOut1 = new string[Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arPSOut2 = new string[Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arPSIn1 = new string[Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arPSIn2 = new string[Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arPDesc = new string[Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arBasis = new string[Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arWaterBasis = new string[Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arRelAddNotes = new string[Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arExpAddNotes = new string[Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arOpNumWorkers = new long[3, Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arOpNumWorkersBasis = new string[Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arOpNumWorkersBasisEnabled = new short[Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arInhalationBasis = new string[Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arDermalBasis = new string[Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arNaics1 = new string[100, Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arNaics2 = new string[100, Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arMiscOpParms = new float[3, Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arGssOptions = new short[163, Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arGssOther = new string[163, Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arOSName = new string[100, Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arOSAddr = new string[100, Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arOSCity = new string[100, Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arOSState = new string[100, Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arOSZip = new string[100, Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arOSCty = new string[100, Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arOpParms = new float[163, Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arOpParmsType = new short[163, Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arContParms = new float[16, 26, Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arContParmTypes = new short[16, 26, Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arOpBorC = new short[Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arOpIoE = new short[Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arOpMassBalDisc = new int[3, Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arOpSP = new float[49, Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arOpSPType = new short[49, Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arOpName = new string[Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arOpNeedsMassBalance = new short[Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arOpType = new short[Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arOpOrder = new short[Globals_Renamed.intNumOps + 1];
						object pCopyArray = COFarOpNeedsMassBalance;
						object pToArray = Globals_Renamed.arOpNeedsMassBalance;
						ChemStrX.Clone1DArray(ref pCopyArray, ref pToArray, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arOpNeedsMassBalance = (short[])pToArray;
						COFarOpNeedsMassBalance = (short[])pCopyArray;
						pToArray = COFarOpParms;
						pCopyArray = Globals_Renamed.arOpParms;
						short pDim = 162;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arOpParms = (float[,])pCopyArray;
						COFarOpParms = (float[,])pToArray;
						pToArray = COFarOpParmsType;
						pCopyArray = Globals_Renamed.arOpParmsType;
						pDim = 162;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arOpParmsType = (short[,])pCopyArray;
						COFarOpParmsType = (short[,])pToArray;
						pToArray = COFarOpBorC;
						pCopyArray = Globals_Renamed.arOpBorC;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arOpBorC = (short[])pCopyArray;
						COFarOpBorC = (short[])pToArray;
						pToArray = COFarOpIoE;
						pCopyArray = Globals_Renamed.arOpIoE;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arOpIoE = (short[])pCopyArray;
						COFarOpIoE = (short[])pToArray;
						pToArray = COFarOpMassBalDisc;
						pCopyArray = Globals_Renamed.arOpMassBalDisc;
						pDim = 2;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arOpMassBalDisc = (int[,])pCopyArray;
						COFarOpMassBalDisc = (short[,])pToArray;
						pToArray = COFarOpSP;
						pCopyArray = Globals_Renamed.arOpSP;
						pDim = 48;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arOpSP = (float[,])pCopyArray;
						COFarOpSP = (float[,])pToArray;
						pToArray = COFarOpSPType;
						pCopyArray = Globals_Renamed.arOpSPType;
						pDim = 48;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arOpSPType = (short[,])pCopyArray;
						COFarOpSPType = (short[,])pToArray;
						pToArray = COFarContParms;
						pCopyArray = Globals_Renamed.arContParms;
						pDim = 15;
						short pDim2 = 25;
						ChemStrX.Clone3DArray(ref pToArray, ref pCopyArray, ref pDim, ref pDim2, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arContParms = (float[,,])pCopyArray;
						COFarContParms = (float[,,])pToArray;
						pToArray = COFarContParmTypes;
						pCopyArray = Globals_Renamed.arContParmTypes;
						pDim2 = 15;
						pDim = 25;
						ChemStrX.Clone3DArray(ref pToArray, ref pCopyArray, ref pDim2, ref pDim, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arContParmTypes = (short[,,])pCopyArray;
						COFarContParmTypes = (short[,,])pToArray;
						pToArray = COFarNoPre;
						pCopyArray = Globals_Renamed.arNoPre;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arNoPre = (bool[])pCopyArray;
						COFarNoPre = (bool[])pToArray;
						pToArray = COFarOpPV;
						pCopyArray = Globals_Renamed.arOpPv;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arOpPv = (double[])pCopyArray;
						COFarOpPV = (float[])pToArray;
						pToArray = COFarSubOpID;
						pCopyArray = Globals_Renamed.arSubOpID;
						pDim2 = 10;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arSubOpID = (short[,])pCopyArray;
						COFarSubOpID = (short[,])pToArray;
						pToArray = COFarSubPVf;
						pCopyArray = Globals_Renamed.arSubPVf;
						pDim2 = 10;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arSubPVf = (float[,])pCopyArray;
						COFarSubPVf = (short[,])pToArray;
						pToArray = COFarSubPvOp;
						pCopyArray = Globals_Renamed.arSubPvOp;
						pDim2 = 10;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arSubPvOp = (double[,])pCopyArray;
						COFarSubPvOp = (float[,])pToArray;
						pToArray = COFarSelActs;
						pCopyArray = Globals_Renamed.arSelActs;
						pDim2 = 25;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arSelActs = (string[,])pCopyArray;
						COFarSelActs = (string[,])pToArray;
						pToArray = COFarSelActType;
						pCopyArray = Globals_Renamed.arSelActType;
						pDim2 = 25;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arSelActType = (short[,])pCopyArray;
						COFarSelActType = (short[,])pToArray;
						pToArray = COFarSelActRa;
						pCopyArray = Globals_Renamed.arSelActRa;
						pDim2 = 25;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arSelActRa = (bool[,])pCopyArray;
						COFarSelActRa = (bool[,])pToArray;
						pToArray = COFarSelActEa;
						pCopyArray = Globals_Renamed.arSelActEa;
						pDim2 = 25;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arSelActEa = (bool[,])pCopyArray;
						COFarSelActEa = (bool[,])pToArray;
						pToArray = COFarSelActRaDMP;
						pCopyArray = Globals_Renamed.arSelActRaDMP;
						pDim2 = 25;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arSelActRaDMP = (short[,])pCopyArray;
						COFarSelActRaDMP = (short[,])pToArray;
						pToArray = COFarSelActEaDMP;
						pCopyArray = Globals_Renamed.arSelActEaDMP;
						pDim2 = 25;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arSelActEaDMP = (short[,])pCopyArray;
						COFarSelActEaDMP = (short[,])pToArray;
						pToArray = COFarSelActVolatile;
						pCopyArray = Globals_Renamed.arSelActVolatile;
						pDim2 = 25;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arSelActVolatile = (short[,])pCopyArray;
						COFarSelActVolatile = (short[,])pToArray;
						pToArray = COFarActNumWorkers;
						pCopyArray = Globals_Renamed.arActNumWorkers;
						pDim2 = 3;
						pDim = 25;
						ChemStrX.Clone3DArray(ref pToArray, ref pCopyArray, ref pDim2, ref pDim, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arActNumWorkers = (long[,,])pCopyArray;
						COFarActNumWorkers = (int[,,])pToArray;
						pToArray = COFarActNW_Route;
						pCopyArray = Globals_Renamed.arActNW_Route;
						pDim2 = 25;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arActNW_Route = (string[,])pCopyArray;
						COFarActNW_Route = (string[,])pToArray;
						pToArray = COFarActOrder;
						pCopyArray = Globals_Renamed.arActOrder;
						pDim2 = 25;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arActOrder = (short[,])pCopyArray;
						COFarActOrder = (short[,])pToArray;
						pToArray = COFarNaics1;
						pCopyArray = Globals_Renamed.arNaics1;
						pDim2 = 99;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arNaics1 = (string[,])pCopyArray;
						COFarNaics1 = (string[,])pToArray;
						pToArray = COFarNaics2;
						pCopyArray = Globals_Renamed.arNaics2;
						pDim2 = 99;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arNaics2 = (string[,])pCopyArray;
						COFarNaics2 = (string[,])pToArray;
						pToArray = COFarOSName;
						pCopyArray = Globals_Renamed.arOSName;
						pDim2 = 99;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arOSName = (string[,])pCopyArray;
						COFarOSName = (string[,])pToArray;
						pToArray = COFarOSAddr;
						pCopyArray = Globals_Renamed.arOSAddr;
						pDim2 = 99;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arOSAddr = (string[,])pCopyArray;
						COFarOSAddr = (string[,])pToArray;
						pToArray = COFarOSCity;
						pCopyArray = Globals_Renamed.arOSCity;
						pDim2 = 99;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arOSCity = (string[,])pCopyArray;
						COFarOSCity = (string[,])pToArray;
						pToArray = COFarOSState;
						pCopyArray = Globals_Renamed.arOSState;
						pDim2 = 99;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arOSState = (string[,])pCopyArray;
						COFarOSState = (string[,])pToArray;
						pToArray = COFarOSZip;
						pCopyArray = Globals_Renamed.arOSZip;
						pDim2 = 99;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arOSZip = (string[,])pCopyArray;
						COFarOSZip = (string[,])pToArray;
						pToArray = COFarOSCty;
						pCopyArray = Globals_Renamed.arOSCty;
						pDim2 = 99;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arOSCty = (string[,])pCopyArray;
						COFarOSCty = (string[,])pToArray;
						pToArray = COFarMiscOpParms;
						pCopyArray = Globals_Renamed.arMiscOpParms;
						pDim2 = 2;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arMiscOpParms = (float[,])pCopyArray;
						COFarMiscOpParms = (float[,])pToArray;
						pToArray = COFarPSInto1;
						pCopyArray = Globals_Renamed.arPSInto1;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arPSInto1 = (string[])pCopyArray;
						COFarPSInto1 = (string[])pToArray;
						pToArray = COFarPSInto2;
						pCopyArray = Globals_Renamed.arPSInto2;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arPSInto2 = (string[])pCopyArray;
						COFarPSInto2 = (string[])pToArray;
						pToArray = COFarPSOut1;
						pCopyArray = Globals_Renamed.arPSOut1;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arPSOut1 = (string[])pCopyArray;
						COFarPSOut1 = (string[])pToArray;
						pToArray = COFarPSOut2;
						pCopyArray = Globals_Renamed.arPSOut2;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arPSOut2 = (string[])pCopyArray;
						COFarPSOut2 = (string[])pToArray;
						pToArray = COFarPSIn1;
						pCopyArray = Globals_Renamed.arPSIn1;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arPSIn1 = (string[])pCopyArray;
						COFarPSIn1 = (string[])pToArray;
						pToArray = COFarPSIn2;
						pCopyArray = Globals_Renamed.arPSIn2;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arPSIn2 = (string[])pCopyArray;
						COFarPSIn2 = (string[])pToArray;
						pToArray = COFarPDesc;
						pCopyArray = Globals_Renamed.arPDesc;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arPDesc = (string[])pCopyArray;
						COFarPDesc = (string[])pToArray;
						pToArray = COFarBasis;
						pCopyArray = Globals_Renamed.arBasis;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arBasis = (string[])pCopyArray;
						COFarBasis = (string[])pToArray;
						pToArray = COFarWaterBasis;
						pCopyArray = Globals_Renamed.arWaterBasis;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arWaterBasis = (string[])pCopyArray;
						COFarWaterBasis = (string[])pToArray;
						pToArray = COFarRelAddNotes;
						pCopyArray = Globals_Renamed.arRelAddNotes;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arRelAddNotes = (string[])pCopyArray;
						COFarRelAddNotes = (string[])pToArray;
						pToArray = COFarExpAddNotes;
						pCopyArray = Globals_Renamed.arExpAddNotes;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arExpAddNotes = (string[])pCopyArray;
						COFarExpAddNotes = (string[])pToArray;
						pToArray = COFarOpNumWorkersBasis;
						pCopyArray = Globals_Renamed.arOpNumWorkersBasis;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arOpNumWorkersBasis = (string[])pCopyArray;
						COFarOpNumWorkersBasis = (string[])pToArray;
						pToArray = COFarOpNumWorkersBasisEnabled;
						pCopyArray = Globals_Renamed.arOpNumWorkersBasisEnabled;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arOpNumWorkersBasisEnabled = (short[])pCopyArray;
						COFarOpNumWorkersBasisEnabled = (short[])pToArray;
						pToArray = COFarOpNumWorkers;
						pCopyArray = Globals_Renamed.arOpNumWorkers;
						pDim2 = 2;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arOpNumWorkers = (long[,])pCopyArray;
						COFarOpNumWorkers = (int[,])pToArray;
						pToArray = COFarInhalationBasis;
						pCopyArray = Globals_Renamed.arInhalationBasis;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arInhalationBasis = (string[])pCopyArray;
						COFarInhalationBasis = (string[])pToArray;
						pToArray = COFarDermalBasis;
						pCopyArray = Globals_Renamed.arDermalBasis;
						ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arDermalBasis = (string[])pCopyArray;
						COFarDermalBasis = (string[])pToArray;
						short num3 = (short)(msfSelOps.Rows - 1);
						short num4 = 0;
						while (true)
						{
							short num5 = num4;
							short num6 = num3;
							if (num5 > num6)
							{
								break;
							}
							unchecked
							{
								if (Operators.CompareString(msfSelOps[(int)num4, 0], "", false) != 0)
								{
									short num7 = Conversions.ToShort(msfSelOps[(int)num4, 1]);
									Globals_Renamed.arOpName[num7] = msfSelOps[(int)num4, 2];
									Globals_Renamed.arOpType[num7] = Conversions.ToShort(msfSelOps[(int)num4, 0]);
									Globals_Renamed.arOpOrder[num7] = num4;
								}
							}
							num4 = (short)unchecked(num4 + 1);
						}
						pToArray = COFarGssOptions;
						pCopyArray = Globals_Renamed.arGssOptions;
						pDim2 = 162;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arGssOptions = (short[,])pCopyArray;
						COFarGssOptions = (short[,])pToArray;
						pToArray = COFarGssOther;
						pCopyArray = Globals_Renamed.arGssOther;
						pDim2 = 162;
						ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arGssOther = (string[,])pCopyArray;
						COFarGssOther = (string[,])pToArray;
						Globals_Renamed.arRelModels = new short[11, 26, Globals_Renamed.intNumOps + 1];
						Globals_Renamed.arExpModels = new short[3, 26, Globals_Renamed.intNumOps + 1];
						pToArray = COFarRelModels;
						pCopyArray = Globals_Renamed.arRelModels;
						pDim2 = 10;
						pDim = 25;
						ChemStrX.Clone3DArray(ref pToArray, ref pCopyArray, ref pDim2, ref pDim, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arRelModels = (short[,,])pCopyArray;
						COFarRelModels = (short[,,])pToArray;
						pToArray = COFarExpModels;
						pCopyArray = Globals_Renamed.arExpModels;
						pDim2 = 2;
						pDim = 25;
						ChemStrX.Clone3DArray(ref pToArray, ref pCopyArray, ref pDim2, ref pDim, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arExpModels = (short[,,])pCopyArray;
						COFarExpModels = (short[,,])pToArray;
						Globals_Renamed.arContParms = new float[16, 26, Globals_Renamed.intNumOps + 1];
						pToArray = COFarContParms;
						pCopyArray = Globals_Renamed.arContParms;
						pDim2 = 15;
						pDim = 25;
						ChemStrX.Clone3DArray(ref pToArray, ref pCopyArray, ref pDim2, ref pDim, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arContParms = (float[,,])pCopyArray;
						COFarContParms = (float[,,])pToArray;
						Globals_Renamed.arContParmTypes = new short[16, 26, Globals_Renamed.intNumOps + 1];
						pToArray = COFarContParmTypes;
						pCopyArray = Globals_Renamed.arContParmTypes;
						pDim2 = 15;
						pDim = 25;
						ChemStrX.Clone3DArray(ref pToArray, ref pCopyArray, ref pDim2, ref pDim, ref Globals_Renamed.intNumOps);
						Globals_Renamed.arContParmTypes = (short[,,])pCopyArray;
						COFarContParmTypes = (short[,,])pToArray;
						Globals_Renamed.intNumRelModels = COFintNumRelModels;
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
						Globals_Renamed.arExpModType = new short[Globals_Renamed.intNumExpModels + 1];
						Globals_Renamed.arExpModOutputOn = new short[3, Globals_Renamed.intNumExpModels + 1];
						Globals_Renamed.arExpModChar = new string[3, Globals_Renamed.intNumExpModels + 1];
						Globals_Renamed.arExpModBasis = new string[Globals_Renamed.intNumExpModels + 1];
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
						frmMain.DefInstance.LoadLstSelOps();
						if (frmMain.DefInstance._lstSelOps_0.Items.Count > 0)
						{
							frmMain.DefInstance._lstSelOps_0.SelectedIndex = 0;
							frmMain.DefInstance._lstSelOps_1.SelectedIndex = 0;
							frmMain.DefInstance.LoadMsfSubOps();
							frmMain.DefInstance.LoadOpCmbs();
						}
						else
						{
							frmMain.DefInstance.AllOpsDeleted();
						}
						if (Globals_Renamed.intNumOps > 1)
						{
							bool flag = false;
							short num8 = (short)(Globals_Renamed.intNumOps - 1);
							num4 = 0;
							while (true)
							{
								short num9 = num4;
								short num6 = num8;
								if (num9 > num6)
								{
									break;
								}
								if (Globals_Renamed.arNoPre[num4])
								{
									flag = true;
									break;
								}
								num4 = (short)unchecked(num4 + 1);
							}
							if (!flag)
							{
								Interaction.MsgBox((object)"You do not have an operation designated as the 'first' operation in the chemical process. The first operation you add has this designation set by default. However, if you delete this operation later, you can wind up with a situation where no operations have this designation, which is invalid. To manually indicate which operation is 'first', Update Relationships and check the No Preceding Operations' checkbox on the Update Relationships screen.", (MsgBoxStyle)48, (object)"Missing First Operation Designation");
							}
						}
						Globals_Renamed.gblIWasChanged = true;
						((Form)this).Close();
						Cursor.Current = Cursors.Default;
						if (bChangedOrder)
						{
							Interaction.MsgBox((object)"You have modified the display of operations, you should return to the Relationships tab to also modify relationships (if appropriate).", (MsgBoxStyle)64, (object)"Relationships Warning");
						}
						if (bDidImport)
						{
							Interaction.MsgBox((object)"Please update Mass Balance Parameters (subtab 4a) for this operation before running models or saving this assessment.", (MsgBoxStyle)48, (object)"Mass Balance Message");
						}
						goto end_IL_0001;
					}
					case 7118:
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
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 7118;
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

	private void cmdCancel_Click(object eventSender, EventArgs eventArgs)
	{
		((Form)this).Close();
	}

	private void cmdAdd_Click(object eventSender, EventArgs eventArgs)
	{
		addOperation();
	}

	private void addOperation()
	{
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num = default(int);
		Recordset recordset = default(Recordset);
		int num2 = default(int);
		int num3 = default(int);
		short num4 = default(short);
		short num5 = default(short);
		Recordset recordset2 = default(Recordset);
		Command command = default(Command);
		string text = default(string);
		short num9 = default(short);
		short num10 = default(short);
		short num11 = default(short);
		string source = default(string);
		short num24 = default(short);
		short pContTab = default(short);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					string Eobject;
					string Efunction;
					ErrObject val;
					int Enumber;
					ErrObject val2;
					string Edescription;
					bool Econtact;
					int num6;
					Guid clsid;
					short num7;
					object ParSelActs;
					object ParSelActType;
					object ParSelActRa;
					object ParSelActEa;
					object ParSelActRaDMP;
					object ParSelActEaDMP;
					object ParSelActVolatile;
					object ParActNumWorkers;
					Command command2;
					Command command3;
					Command command4;
					Command command5;
					float[,] cOFarOpParms;
					int num12;
					ref short cOFintNumOps;
					ref bool pFirstOp;
					ref short cOFintNumOps2;
					float xrmDefault;
					object obj;
					float[,] cOFarOpParms2;
					int num13;
					float[,] cOFarOpParms3;
					int num14;
					float[,] cOFarOpParms4;
					int num15;
					float[,] cOFarOpParms5;
					int num16;
					float[,] cOFarOpParms6;
					int num17;
					float[,] cOFarOpParms7;
					int num18;
					float[,] cOFarOpParms8;
					int num19;
					float[,] cOFarOpParms9;
					int num20;
					float[,] cOFarOpParms10;
					int num21;
					float[,] cOFarOpParms11;
					int num22;
					float[,] cOFarOpParms12;
					int num23;
					short pGSSID;
					short opindex;
					Command command6;
					short num25;
					short num8;
					Command command7;
					Command command8;
					ref short pActID;
					object parActOrder;
					object parActNW_Route;
					switch (try0001_dispatch)
					{
					default:
						num = 1;
						clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
						recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						goto IL_0024;
					case 20608:
						{
							num2 = num;
							switch ((num3 <= -2) ? 1 : num3)
							{
							case 2:
							case 3:
								break;
							case 1:
								goto IL_45ae;
							default:
								goto end_IL_0001;
							}
							goto IL_4522;
						}
						IL_20b9:
						num = 379;
						num4++;
						goto IL_20c5;
						IL_20c5:
						num = 380;
						recordset.MoveNext();
						goto IL_20d5;
						IL_2082:
						num = 378;
						COFarSelActType[num4, COFintNumOps - 1] = Conversions.ToShort(recordset.Fields[0].Value);
						goto IL_20b9;
						IL_4522:
						num = 686;
						Eobject = ((Control)this).Name;
						Efunction = "addOperation";
						val = Information.Err();
						Enumber = val.Number;
						val2 = Information.Err();
						Edescription = val2.Description;
						Econtact = true;
						Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
						val2.Description = Edescription;
						val.Number = Enumber;
						((Control)this).Name = Eobject;
						goto IL_4588;
						IL_4588:
						num = 687;
						ProjectData.ClearProjectError();
						if (num2 == 0)
						{
							throw ProjectData.CreateProjectError(-2146828268);
						}
						goto IL_45ae;
						IL_020b:
						num = 32;
						num5 = (short)unchecked(num5 + -1);
						goto IL_0217;
						IL_45ae:
						num6 = unchecked(num2 + 1);
						num2 = 0;
						switch (num6)
						{
						case 1:
							break;
						case 2:
							goto IL_0024;
						case 3:
							goto IL_0047;
						case 4:
							goto IL_0069;
						case 5:
							goto IL_0071;
						case 6:
							goto IL_007b;
						case 8:
						case 10:
							goto IL_00a5;
						case 12:
						case 13:
							goto IL_00c4;
						case 14:
							goto IL_00e7;
						case 15:
							goto IL_00f1;
						case 17:
						case 18:
							goto IL_010e;
						case 19:
							goto IL_0127;
						case 20:
							goto IL_014a;
						case 21:
							goto IL_0183;
						case 22:
							goto IL_01ae;
						case 24:
							goto IL_01bb;
						case 25:
							goto IL_01c0;
						case 26:
							goto IL_01df;
						case 27:
							goto IL_01f3;
						case 30:
						case 31:
						case 32:
							goto IL_020b;
						case 23:
						case 28:
						case 29:
						case 33:
							goto IL_0223;
						case 35:
						case 36:
							goto IL_02ae;
						case 38:
						case 39:
							goto IL_02cd;
						case 40:
							goto IL_02d8;
						case 42:
						case 43:
							goto IL_0359;
						case 45:
						case 46:
							goto IL_0378;
						case 7:
						case 34:
						case 41:
						case 47:
						case 48:
							goto IL_0384;
						case 49:
							goto IL_0397;
						case 50:
						case 52:
							goto IL_03c3;
						case 53:
						case 55:
							goto IL_03ef;
						case 56:
						case 58:
							goto IL_041d;
						case 59:
						case 61:
							goto IL_044b;
						case 62:
						case 64:
							goto IL_0479;
						case 65:
							goto IL_048c;
						case 67:
							goto IL_049b;
						case 68:
							goto IL_04a0;
						case 66:
						case 69:
						case 70:
							goto IL_04bf;
						case 71:
							goto IL_04e0;
						case 72:
							goto IL_04f3;
						case 74:
							goto IL_0518;
						case 75:
							goto IL_051d;
						case 76:
							goto IL_053f;
						case 77:
							goto IL_0566;
						case 80:
							goto IL_05b6;
						case 81:
							goto IL_05bb;
						case 82:
							goto IL_05d8;
						case 73:
						case 78:
						case 79:
						case 83:
						case 84:
							goto IL_05f2;
						case 85:
						case 87:
							goto IL_0620;
						case 88:
						case 90:
							goto IL_064e;
						case 91:
						case 93:
							goto IL_067c;
						case 94:
						case 96:
							goto IL_06aa;
						case 97:
						case 99:
							goto IL_06d8;
						case 100:
						case 102:
							goto IL_0706;
						case 103:
						case 105:
							goto IL_0734;
						case 106:
						case 108:
							goto IL_0763;
						case 109:
						case 111:
							goto IL_0791;
						case 112:
						case 114:
							goto IL_07bf;
						case 115:
							goto IL_08bc;
						case 116:
						case 118:
							goto IL_08e8;
						case 119:
						case 121:
							goto IL_0914;
						case 122:
						case 124:
							goto IL_0940;
						case 125:
						case 127:
							goto IL_096c;
						case 128:
						case 130:
							goto IL_0998;
						case 131:
						case 133:
							goto IL_09c7;
						case 134:
						case 136:
							goto IL_09f6;
						case 137:
						case 139:
							goto IL_0a25;
						case 140:
						case 142:
							goto IL_0a54;
						case 143:
						case 145:
							goto IL_0a83;
						case 146:
						case 148:
							goto IL_0ab2;
						case 149:
						case 151:
							goto IL_0ae2;
						case 152:
						case 154:
							goto IL_0b11;
						case 155:
						case 157:
							goto IL_0b40;
						case 158:
						case 160:
							goto IL_0b6f;
						case 161:
						case 163:
							goto IL_0b9e;
						case 164:
						case 166:
							goto IL_0bcf;
						case 167:
						case 169:
							goto IL_0c00;
						case 170:
						case 172:
							goto IL_0c30;
						case 173:
						case 175:
							goto IL_0c64;
						case 176:
						case 178:
							goto IL_0c98;
						case 179:
						case 181:
							goto IL_0cc9;
						case 182:
						case 184:
							goto IL_0cfa;
						case 185:
						case 187:
							goto IL_0d2b;
						case 188:
						case 190:
							goto IL_0d5c;
						case 191:
						case 193:
							goto IL_0d8d;
						case 194:
						case 196:
							goto IL_0dbe;
						case 197:
						case 199:
							goto IL_0df2;
						case 200:
						case 202:
							goto IL_0e26;
						case 203:
						case 205:
							goto IL_0e59;
						case 206:
						case 208:
							goto IL_0e8c;
						case 209:
						case 211:
							goto IL_0ebb;
						case 212:
						case 214:
							goto IL_0eea;
						case 215:
						case 217:
							goto IL_0f19;
						case 218:
						case 220:
							goto IL_0f48;
						case 221:
						case 223:
							goto IL_0f77;
						case 224:
						case 226:
							goto IL_0fa6;
						case 227:
						case 229:
							goto IL_0fd6;
						case 230:
						case 232:
							goto IL_1007;
						case 233:
						case 235:
							goto IL_1038;
						case 236:
						case 238:
							goto IL_106b;
						case 239:
						case 241:
							goto IL_109d;
						case 242:
							goto IL_10c4;
						case 243:
							goto IL_10f4;
						case 244:
							goto IL_1111;
						case 245:
							goto IL_1141;
						case 246:
						case 247:
							goto IL_115f;
						case 249:
						case 251:
							goto IL_118d;
						case 252:
							goto IL_11c1;
						case 253:
							goto IL_11ee;
						case 254:
							goto IL_120d;
						case 255:
							goto IL_1220;
						case 256:
							goto IL_1233;
						case 257:
							goto IL_1242;
						case 258:
							goto IL_127e;
						case 259:
							goto IL_12a0;
						case 260:
							goto IL_12b8;
						case 261:
							goto IL_12e9;
						case 262:
							goto IL_131a;
						case 263:
							goto IL_136d;
						case 264:
							goto IL_13ce;
						case 265:
							goto IL_13dd;
						case 266:
							goto IL_13f7;
						case 267:
							goto IL_140a;
						case 268:
							goto IL_1419;
						case 269:
						case 270:
						case 279:
						case 289:
						case 290:
							goto IL_1424;
						case 271:
							goto IL_143b;
						case 272:
							goto IL_1450;
						case 273:
							goto IL_146e;
						case 274:
							goto IL_14a4;
						case 275:
							goto IL_14c6;
						case 276:
							goto IL_14de;
						case 277:
							goto IL_1515;
						case 280:
							goto IL_152f;
						case 281:
							goto IL_1537;
						case 282:
							goto IL_155e;
						case 283:
							goto IL_1594;
						case 284:
							goto IL_15b6;
						case 285:
							goto IL_15ce;
						case 286:
							goto IL_1605;
						case 287:
							goto IL_1614;
						case 288:
							goto IL_1628;
						case 278:
						case 291:
						case 292:
							goto IL_163d;
						case 293:
							goto IL_165e;
						case 294:
							goto IL_167f;
						case 295:
							goto IL_16ed;
						case 296:
							goto IL_170a;
						case 297:
							goto IL_173b;
						case 298:
							goto IL_1758;
						case 299:
							goto IL_1789;
						case 300:
							goto IL_17a6;
						case 301:
							goto IL_17ca;
						case 302:
							goto IL_1810;
						case 303:
							goto IL_1856;
						case 304:
							goto IL_1873;
						case 305:
						case 306:
							goto IL_1891;
						case 307:
							goto IL_18b2;
						case 308:
							goto IL_18e2;
						case 309:
						case 310:
						case 311:
							goto IL_1905;
						case 312:
							goto IL_1913;
						case 314:
						case 316:
							goto IL_1957;
						case 317:
							goto IL_1984;
						case 318:
							goto IL_19b1;
						case 319:
							goto IL_1a0e;
						case 320:
							goto IL_1a2b;
						case 321:
							goto IL_1a4b;
						case 322:
							goto IL_1a6b;
						case 323:
							goto IL_1a8b;
						case 324:
							goto IL_1aa7;
						case 325:
							goto IL_1ac3;
						case 326:
							goto IL_1adf;
						case 328:
						case 329:
							goto IL_1b06;
						case 330:
							goto IL_1b33;
						case 331:
							goto IL_1b50;
						case 332:
							goto IL_1b7b;
						case 333:
							goto IL_1b97;
						case 334:
							goto IL_1bde;
						case 335:
							goto IL_1bfb;
						case 336:
							goto IL_1c1b;
						case 337:
							goto IL_1c3b;
						case 338:
							goto IL_1c5b;
						case 339:
							goto IL_1c77;
						case 340:
							goto IL_1c93;
						case 341:
							goto IL_1caf;
						case 343:
						case 344:
							goto IL_1cd6;
						case 345:
							goto IL_1cf7;
						case 346:
							goto IL_1d14;
						case 347:
							goto IL_1d35;
						case 348:
							goto IL_1d52;
						case 349:
							goto IL_1d73;
						case 350:
							goto IL_1d90;
						case 352:
						case 353:
							goto IL_1db2;
						case 354:
							goto IL_1dcf;
						case 355:
							goto IL_1df0;
						case 356:
							goto IL_1e1d;
						case 357:
							goto IL_1e4a;
						case 358:
							goto IL_1e6b;
						case 359:
							goto IL_1e98;
						case 360:
							goto IL_1ec5;
						case 361:
							goto IL_1ef8;
						case 363:
						case 364:
							goto IL_1f31;
						case 365:
							goto IL_1f64;
						case 366:
							goto IL_1f84;
						case 367:
							goto IL_1fa5;
						case 368:
							goto IL_1fc2;
						case 313:
						case 327:
						case 342:
						case 351:
						case 362:
						case 369:
						case 370:
							goto IL_1fe4;
						case 371:
							goto IL_1fed;
						case 372:
							goto IL_2000;
						case 373:
							goto IL_2013;
						case 374:
							goto IL_2022;
						case 375:
							goto IL_205e;
						case 378:
							goto IL_2082;
						case 379:
							goto IL_20b9;
						case 380:
							goto IL_20c5;
						case 376:
						case 377:
						case 381:
							goto IL_20d5;
						case 382:
							goto IL_20ec;
						case 383:
							goto IL_20fb;
						case 384:
							goto IL_2113;
						case 385:
							goto IL_2127;
						case 386:
							goto IL_213c;
						case 387:
							goto IL_214f;
						case 388:
							goto IL_2162;
						case 389:
							goto IL_2171;
						case 390:
							goto IL_21ac;
						case 391:
							goto IL_21ce;
						case 392:
							goto IL_2205;
						case 393:
							goto IL_2243;
						case 394:
							goto IL_2281;
						case 395:
							goto IL_2290;
						case 396:
							goto IL_22a8;
						case 397:
							goto IL_22c9;
						case 398:
							goto IL_22dc;
						case 399:
							goto IL_22ef;
						case 400:
							goto IL_22fe;
						case 401:
							goto IL_2339;
						case 402:
							goto IL_235b;
						case 403:
							goto IL_238f;
						case 404:
							goto IL_23c2;
						case 405:
							goto IL_23e6;
						case 406:
							goto IL_23fb;
						case 407:
							goto IL_2409;
						case 408:
							goto IL_245b;
						case 409:
							goto IL_2482;
						case 410:
						case 411:
						case 412:
						case 413:
							goto IL_24a7;
						case 414:
							goto IL_24b6;
						case 415:
							goto IL_24ce;
						case 416:
						case 417:
							goto IL_24eb;
						case 418:
							goto IL_24f5;
						case 420:
						case 421:
							goto IL_2504;
						case 422:
							goto IL_2516;
						case 423:
							goto IL_253d;
						case 424:
							goto IL_2564;
						case 425:
							goto IL_257d;
						case 426:
							goto IL_258e;
						case 427:
							goto IL_259e;
						case 428:
							goto IL_25cd;
						case 429:
							goto IL_25fe;
						case 430:
							goto IL_262f;
						case 431:
							goto IL_2660;
						case 432:
							goto IL_2691;
						case 433:
							goto IL_26c2;
						case 434:
							goto IL_26f3;
						case 435:
							goto IL_2724;
						case 436:
							goto IL_2759;
						case 437:
							goto IL_278e;
						case 438:
							goto IL_27c8;
						case 439:
							goto IL_2802;
						case 440:
							goto IL_283c;
						case 441:
							goto IL_2876;
						case 442:
							goto IL_287e;
						case 443:
							goto IL_28af;
						case 444:
							goto IL_28e0;
						case 445:
							goto IL_2911;
						case 446:
							goto IL_2942;
						case 447:
							goto IL_2973;
						case 448:
							goto IL_29a4;
						case 449:
							goto IL_29d9;
						case 450:
							goto IL_2a13;
						case 451:
							goto IL_2a4d;
						case 452:
							goto IL_2a7e;
						case 453:
							goto IL_2ab3;
						case 454:
							goto IL_2ad6;
						case 455:
							goto IL_2ae5;
						case 456:
							goto IL_2b0c;
						case 457:
							goto IL_2b26;
						case 458:
							goto IL_2b39;
						case 459:
							goto IL_2b4c;
						case 462:
							goto IL_2b60;
						case 463:
							goto IL_2baa;
						case 464:
							goto IL_2be6;
						case 465:
							goto IL_2c08;
						case 466:
							goto IL_2c20;
						case 467:
							goto IL_2c6a;
						case 468:
							goto IL_2c79;
						case 460:
						case 461:
						case 469:
							goto IL_2c89;
						case 470:
						case 471:
							goto IL_2ca4;
						case 472:
							goto IL_2cb3;
						case 475:
							goto IL_2cdf;
						case 476:
							goto IL_2d03;
						case 477:
							goto IL_2d34;
						case 478:
							goto IL_2d65;
						case 479:
							goto IL_2d96;
						case 480:
							goto IL_2dc7;
						case 481:
							goto IL_2df8;
						case 482:
							goto IL_2e29;
						case 483:
							goto IL_2e64;
						case 484:
							goto IL_2ea0;
						case 485:
							goto IL_2edc;
						case 486:
							goto IL_2f18;
						case 487:
							goto IL_2f4e;
						case 488:
							goto IL_2f89;
						case 473:
						case 474:
						case 489:
							goto IL_2f99;
						case 490:
							goto IL_2fb3;
						case 491:
							goto IL_2fc2;
						case 494:
							goto IL_2fee;
						case 495:
							goto IL_3012;
						case 496:
							goto IL_3028;
						case 497:
							goto IL_3059;
						case 499:
							goto IL_308c;
						case 500:
							goto IL_3094;
						case 501:
							goto IL_30cb;
						case 498:
						case 502:
						case 503:
							goto IL_3103;
						case 492:
						case 493:
						case 504:
							goto IL_3113;
						case 505:
							goto IL_312d;
						case 506:
							goto IL_313c;
						case 509:
							goto IL_3168;
						case 510:
							goto IL_318c;
						case 511:
							goto IL_31b0;
						case 512:
							goto IL_31e3;
						case 513:
							goto IL_3216;
						case 507:
						case 508:
						case 514:
							goto IL_3226;
						case 515:
							goto IL_3240;
						case 516:
							goto IL_324f;
						case 519:
							goto IL_327b;
						case 520:
							goto IL_329f;
						case 521:
							goto IL_32d0;
						case 522:
							goto IL_3301;
						case 517:
						case 518:
						case 523:
							goto IL_3311;
						case 524:
							goto IL_332b;
						case 525:
							goto IL_333a;
						case 528:
							goto IL_3366;
						case 529:
						case 531:
							goto IL_3397;
						case 532:
						case 534:
							goto IL_33c8;
						case 535:
						case 537:
							goto IL_33f9;
						case 538:
						case 540:
							goto IL_342a;
						case 541:
						case 543:
							goto IL_345c;
						case 544:
						case 546:
							goto IL_348e;
						case 547:
						case 549:
							goto IL_34c1;
						case 550:
						case 552:
							goto IL_34f8;
						case 553:
						case 555:
							goto IL_352f;
						case 556:
						case 558:
							goto IL_3566;
						case 559:
						case 561:
							goto IL_3598;
						case 562:
						case 564:
							goto IL_35ca;
						case 565:
						case 567:
							goto IL_35fc;
						case 568:
							goto IL_3620;
						case 569:
							goto IL_3644;
						case 570:
							goto IL_3665;
						case 571:
							goto IL_3694;
						case 572:
							goto IL_36c9;
						case 573:
							goto IL_36fe;
						case 574:
							goto IL_3713;
						case 575:
							goto IL_3751;
						case 576:
							goto IL_378a;
						case 577:
							goto IL_37c8;
						case 578:
							goto IL_3801;
						case 581:
							goto IL_383d;
						case 582:
							goto IL_38b0;
						case 583:
							goto IL_3923;
						case 584:
							goto IL_3996;
						case 579:
						case 580:
						case 585:
							goto IL_39a6;
						case 586:
							goto IL_39c0;
						case 587:
							goto IL_39cf;
						case 588:
							goto IL_3a37;
						case 591:
							goto IL_3a52;
						case 592:
							goto IL_3aaa;
						case 589:
						case 590:
						case 593:
							goto IL_3aba;
						case 594:
							goto IL_3ad1;
						case 595:
							goto IL_3ae0;
						case 596:
							goto IL_3aef;
						case 526:
						case 527:
						case 597:
							goto IL_3b06;
						case 598:
							goto IL_3b20;
						case 599:
							goto IL_3b2f;
						case 602:
							goto IL_3b5b;
						case 603:
							goto IL_3bae;
						case 604:
						case 606:
							goto IL_3bdf;
						case 607:
						case 609:
							goto IL_3c13;
						case 610:
						case 612:
							goto IL_3c45;
						case 613:
						case 615:
							goto IL_3c77;
						case 616:
						case 618:
							goto IL_3ca8;
						case 619:
						case 621:
							goto IL_3cd9;
						case 622:
						case 624:
							goto IL_3d0a;
						case 625:
						case 627:
							goto IL_3d3b;
						case 628:
						case 630:
							goto IL_3d72;
						case 631:
						case 633:
							goto IL_3da9;
						case 634:
						case 636:
							goto IL_3de0;
						case 637:
						case 639:
							goto IL_3e12;
						case 640:
							goto IL_3e4b;
						case 641:
							goto IL_3e89;
						case 642:
							goto IL_3ec7;
						case 643:
							goto IL_3f00;
						case 644:
							goto IL_3f39;
						case 645:
							goto IL_3f6e;
						case 646:
							goto IL_3fa7;
						case 647:
							goto IL_3fe0;
						case 648:
							goto IL_3ff5;
						case 649:
							goto IL_402e;
						case 650:
							goto IL_4067;
						case 651:
							goto IL_40c0;
						case 652:
							goto IL_4119;
						case 653:
							goto IL_4152;
						case 655:
							goto IL_4172;
						case 656:
							goto IL_41ab;
						case 658:
							goto IL_41cb;
						case 659:
							goto IL_41d3;
						case 654:
						case 657:
						case 660:
						case 661:
							goto IL_41f2;
						case 664:
							goto IL_422e;
						case 665:
							goto IL_42a1;
						case 666:
							goto IL_4314;
						case 667:
							goto IL_4387;
						case 662:
						case 663:
						case 668:
							goto IL_4397;
						case 669:
							goto IL_43b1;
						case 670:
							goto IL_43c0;
						case 671:
							goto IL_43d6;
						case 600:
						case 601:
						case 672:
							goto IL_43e6;
						case 673:
							goto IL_4400;
						case 674:
							goto IL_440f;
						case 675:
							goto IL_4419;
						case 677:
						case 678:
							goto IL_4428;
						case 679:
							goto IL_445e;
						case 248:
						case 419:
						case 676:
						case 680:
						case 681:
						case 682:
							goto IL_44e3;
						case 683:
							goto IL_4505;
						case 686:
							goto IL_4522;
						case 687:
							goto IL_4588;
						default:
							goto end_IL_0001;
						case 11:
						case 16:
						case 37:
						case 44:
						case 684:
						case 685:
						case 688:
							goto end_IL_0001_2;
						}
						goto default;
						IL_0024:
						num = 2;
						clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
						recordset2 = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						goto IL_0047;
						IL_0047:
						num = 3;
						clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
						command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						goto IL_0069;
						IL_0069:
						ProjectData.ClearProjectError();
						num3 = 2;
						goto IL_0071;
						IL_0071:
						num = 5;
						text = "";
						goto IL_007b;
						IL_007b:
						num = 6;
						switch (tabOps.SelectedIndex)
						{
						case 0:
							break;
						case 1:
							goto IL_02ae;
						case 2:
							goto IL_0359;
						default:
							goto IL_0384;
						}
						goto IL_00a5;
						IL_0359:
						num = 43;
						if (lstImport.SelectedIndex == -1)
						{
							goto end_IL_0001_2;
						}
						goto IL_0378;
						IL_0378:
						num = 46;
						bDidImport = true;
						goto IL_0384;
						IL_02ae:
						num = 36;
						if (lstGSS.SelectedIndex == -1)
						{
							goto end_IL_0001_2;
						}
						goto IL_02cd;
						IL_02cd:
						num = 39;
						bDidImport = true;
						goto IL_02d8;
						IL_02d8:
						num = 40;
						msfSelOps.AddItem(Conversions.ToString(Support.GetItemData((Control)(object)lstGSS, lstGSS.SelectedIndex)) + "\t" + Conversions.ToString(unchecked((int)COFintNumOps)) + "\t" + Support.GetItemString((Control)(object)lstGSS, lstGSS.SelectedIndex));
						goto IL_0384;
						IL_00a5:
						num = 10;
						if (lstOps.SelectedIndex == -1)
						{
							goto end_IL_0001_2;
						}
						goto IL_00c4;
						IL_00c4:
						num = 13;
						if (Support.GetItemData((Control)(object)lstOps, lstOps.SelectedIndex) == 0)
						{
							goto IL_00e7;
						}
						goto IL_010e;
						IL_00e7:
						num = 14;
						Interaction.Beep();
						goto IL_00f1;
						IL_00f1:
						num = 15;
						Interaction.MsgBox((object)"This generic scenario is not currently functioning.", (MsgBoxStyle)64, (object)"Invalid Selection");
						goto end_IL_0001_2;
						IL_010e:
						num = 18;
						num5 = (short)(msfSelOps.Rows - 1);
						goto IL_0217;
						IL_0217:
						num7 = num5;
						num8 = 0;
						if (num7 >= num8)
						{
							goto IL_0127;
						}
						goto IL_0223;
						IL_0127:
						num = 19;
						if (Strings.Len(msfSelOps[unchecked((int)num5), 1]) > 0)
						{
							goto IL_014a;
						}
						goto IL_020b;
						IL_014a:
						num = 20;
						if (Conversions.ToDouble(msfSelOps[unchecked((int)num5), 0]) == (double)Support.GetItemData((Control)(object)lstOps, lstOps.SelectedIndex))
						{
							goto IL_0183;
						}
						goto IL_020b;
						IL_0183:
						num = 21;
						if (!Versioned.IsNumeric((object)Strings.Trim(Strings.Right(msfSelOps[unchecked((int)num5), 2], 2))))
						{
							goto IL_01ae;
						}
						goto IL_01bb;
						IL_01ae:
						num = 22;
						text = " 2";
						goto IL_0223;
						IL_01bb:
						num = 24;
						goto IL_01c0;
						IL_01c0:
						num = 25;
						text = Strings.Trim(Strings.Right(msfSelOps[unchecked((int)num5), 2], 2));
						goto IL_01df;
						IL_01df:
						num = 26;
						text = Conversions.ToString(Conversions.ToShort(text) + 1);
						goto IL_01f3;
						IL_01f3:
						num = 27;
						text = " " + text;
						goto IL_0223;
						IL_0223:
						num = 33;
						msfSelOps.AddItem(Conversions.ToString(Support.GetItemData((Control)(object)lstOps, lstOps.SelectedIndex)) + "\t" + Conversions.ToString(unchecked((int)COFintNumOps)) + "\t" + Support.GetItemString((Control)(object)lstOps, lstOps.SelectedIndex) + text);
						goto IL_0384;
						IL_0384:
						num = 48;
						COFintNumOps++;
						goto IL_0397;
						IL_0397:
						num = 49;
						COFarNoPre = (bool[])Utils.CopyArray((Array)COFarNoPre, (Array)new bool[COFintNumOps + 1]);
						goto IL_03c3;
						IL_03c3:
						num = 52;
						COFarOpPV = (float[])Utils.CopyArray((Array)COFarOpPV, (Array)new float[COFintNumOps + 1]);
						goto IL_03ef;
						IL_03ef:
						num = 55;
						COFarSubOpID = (short[,])Utils.CopyArray((Array)COFarSubOpID, (Array)new short[11, COFintNumOps + 1]);
						goto IL_041d;
						IL_041d:
						num = 58;
						COFarSubPVf = (short[,])Utils.CopyArray((Array)COFarSubPVf, (Array)new short[11, COFintNumOps + 1]);
						goto IL_044b;
						IL_044b:
						num = 61;
						COFarSubPvOp = (float[,])Utils.CopyArray((Array)COFarSubPvOp, (Array)new float[11, COFintNumOps + 1]);
						goto IL_0479;
						IL_0479:
						num = 64;
						if (COFintNumOps == 1)
						{
							goto IL_048c;
						}
						goto IL_049b;
						IL_048c:
						num = 65;
						COFarNoPre[0] = true;
						goto IL_04bf;
						IL_049b:
						num = 67;
						goto IL_04a0;
						IL_04a0:
						num = 68;
						COFarSubOpID[0, COFintNumOps - 2] = COFintNumOps;
						goto IL_04bf;
						IL_04bf:
						num = 70;
						if (Versioned.IsNumeric((object)frmMain.DefInstance.lblPV.Text))
						{
							goto IL_04e0;
						}
						goto IL_05b6;
						IL_04e0:
						num = 71;
						if (COFintNumOps == 1)
						{
							goto IL_04f3;
						}
						goto IL_0518;
						IL_04f3:
						num = 72;
						COFarOpPV[0] = Conversions.ToSingle(frmMain.DefInstance.lblPV.Text);
						goto IL_05f2;
						IL_0518:
						num = 74;
						goto IL_051d;
						IL_051d:
						num = 75;
						COFarOpPV[COFintNumOps - 1] = COFarOpPV[COFintNumOps - 2];
						goto IL_053f;
						IL_053f:
						num = 76;
						COFarSubPvOp[0, COFintNumOps - 2] = COFarOpPV[COFintNumOps - 2];
						goto IL_0566;
						IL_0566:
						num = 77;
						COFarSubPVf[0, COFintNumOps - 2] = (short)Math.Round((double)COFarOpPV[COFintNumOps - 2] / Conversions.ToDouble(frmMain.DefInstance.lblPV.Text) * 100.0);
						goto IL_05f2;
						IL_05b6:
						num = 80;
						goto IL_05bb;
						IL_05bb:
						num = 81;
						COFarSubPvOp[0, COFintNumOps - 1] = 0f;
						goto IL_05d8;
						IL_05d8:
						num = 82;
						COFarSubPVf[0, COFintNumOps - 1] = 0;
						goto IL_05f2;
						IL_05f2:
						num = 84;
						COFarSelActs = (string[,])Utils.CopyArray((Array)COFarSelActs, (Array)new string[26, COFintNumOps + 1]);
						goto IL_0620;
						IL_0620:
						num = 87;
						COFarSelActType = (short[,])Utils.CopyArray((Array)COFarSelActType, (Array)new short[26, COFintNumOps + 1]);
						goto IL_064e;
						IL_064e:
						num = 90;
						COFarSelActRa = (bool[,])Utils.CopyArray((Array)COFarSelActRa, (Array)new bool[26, COFintNumOps + 1]);
						goto IL_067c;
						IL_067c:
						num = 93;
						COFarSelActEa = (bool[,])Utils.CopyArray((Array)COFarSelActEa, (Array)new bool[26, COFintNumOps + 1]);
						goto IL_06aa;
						IL_06aa:
						num = 96;
						COFarSelActRaDMP = (short[,])Utils.CopyArray((Array)COFarSelActRaDMP, (Array)new short[26, COFintNumOps + 1]);
						goto IL_06d8;
						IL_06d8:
						num = 99;
						COFarSelActEaDMP = (short[,])Utils.CopyArray((Array)COFarSelActEaDMP, (Array)new short[26, COFintNumOps + 1]);
						goto IL_0706;
						IL_0706:
						num = 102;
						COFarSelActVolatile = (short[,])Utils.CopyArray((Array)COFarSelActVolatile, (Array)new short[26, COFintNumOps + 1]);
						goto IL_0734;
						IL_0734:
						num = 105;
						COFarActNumWorkers = (int[,,])Utils.CopyArray((Array)COFarActNumWorkers, (Array)new int[4, 26, COFintNumOps + 1]);
						goto IL_0763;
						IL_0763:
						num = 108;
						COFarActNW_Route = (string[,])Utils.CopyArray((Array)COFarActNW_Route, (Array)new string[26, COFintNumOps + 1]);
						goto IL_0791;
						IL_0791:
						num = 111;
						COFarActOrder = (short[,])Utils.CopyArray((Array)COFarActOrder, (Array)new short[26, COFintNumOps + 1]);
						goto IL_07bf;
						IL_07bf:
						num = 114;
						opindex = (short)(COFintNumOps - 1);
						ParSelActs = COFarSelActs;
						ParSelActType = COFarSelActType;
						ParSelActRa = COFarSelActRa;
						ParSelActEa = COFarSelActEa;
						ParSelActRaDMP = COFarSelActRaDMP;
						ParSelActEaDMP = COFarSelActEaDMP;
						ParSelActVolatile = COFarSelActVolatile;
						ParActNumWorkers = COFarActNumWorkers;
						parActNW_Route = COFarActNW_Route;
						parActOrder = COFarActOrder;
						ChemStrX.CleanOutActArrays(ref opindex, ref ParSelActs, ref ParSelActType, ref ParSelActRa, ref ParSelActEa, ref ParSelActRaDMP, ref ParSelActEaDMP, ref ParSelActVolatile, ref ParActNumWorkers, ref parActNW_Route, ref parActOrder);
						COFarActOrder = (short[,])parActOrder;
						COFarActNW_Route = (string[,])parActNW_Route;
						COFarActNumWorkers = (int[,,])ParActNumWorkers;
						COFarSelActVolatile = (short[,])ParSelActVolatile;
						COFarSelActEaDMP = (short[,])ParSelActEaDMP;
						COFarSelActRaDMP = (short[,])ParSelActRaDMP;
						COFarSelActEa = (bool[,])ParSelActEa;
						COFarSelActRa = (bool[,])ParSelActRa;
						COFarSelActType = (short[,])ParSelActType;
						COFarSelActs = (string[,])ParSelActs;
						goto IL_08bc;
						IL_08bc:
						num = 115;
						COFarPSInto1 = (string[])Utils.CopyArray((Array)COFarPSInto1, (Array)new string[COFintNumOps + 1]);
						goto IL_08e8;
						IL_08e8:
						num = 118;
						COFarPSInto2 = (string[])Utils.CopyArray((Array)COFarPSInto2, (Array)new string[COFintNumOps + 1]);
						goto IL_0914;
						IL_0914:
						num = 121;
						COFarPSOut1 = (string[])Utils.CopyArray((Array)COFarPSOut1, (Array)new string[COFintNumOps + 1]);
						goto IL_0940;
						IL_0940:
						num = 124;
						COFarPSOut2 = (string[])Utils.CopyArray((Array)COFarPSOut2, (Array)new string[COFintNumOps + 1]);
						goto IL_096c;
						IL_096c:
						num = 127;
						COFarPSIn1 = (string[])Utils.CopyArray((Array)COFarPSIn1, (Array)new string[COFintNumOps + 1]);
						goto IL_0998;
						IL_0998:
						num = 130;
						COFarPSIn2 = (string[])Utils.CopyArray((Array)COFarPSIn2, (Array)new string[COFintNumOps + 1]);
						goto IL_09c7;
						IL_09c7:
						num = 133;
						COFarPDesc = (string[])Utils.CopyArray((Array)COFarPDesc, (Array)new string[COFintNumOps + 1]);
						goto IL_09f6;
						IL_09f6:
						num = 136;
						COFarBasis = (string[])Utils.CopyArray((Array)COFarBasis, (Array)new string[COFintNumOps + 1]);
						goto IL_0a25;
						IL_0a25:
						num = 139;
						COFarWaterBasis = (string[])Utils.CopyArray((Array)COFarWaterBasis, (Array)new string[COFintNumOps + 1]);
						goto IL_0a54;
						IL_0a54:
						num = 142;
						COFarRelAddNotes = (string[])Utils.CopyArray((Array)COFarRelAddNotes, (Array)new string[COFintNumOps + 1]);
						goto IL_0a83;
						IL_0a83:
						num = 145;
						COFarExpAddNotes = (string[])Utils.CopyArray((Array)COFarExpAddNotes, (Array)new string[COFintNumOps + 1]);
						goto IL_0ab2;
						IL_0ab2:
						num = 148;
						COFarOpNumWorkers = (int[,])Utils.CopyArray((Array)COFarOpNumWorkers, (Array)new int[3, COFintNumOps + 1]);
						goto IL_0ae2;
						IL_0ae2:
						num = 151;
						COFarOpNumWorkersBasis = (string[])Utils.CopyArray((Array)COFarOpNumWorkersBasis, (Array)new string[COFintNumOps + 1]);
						goto IL_0b11;
						IL_0b11:
						num = 154;
						COFarOpNumWorkersBasisEnabled = (short[])Utils.CopyArray((Array)COFarOpNumWorkersBasisEnabled, (Array)new short[COFintNumOps + 1]);
						goto IL_0b40;
						IL_0b40:
						num = 157;
						COFarInhalationBasis = (string[])Utils.CopyArray((Array)COFarInhalationBasis, (Array)new string[COFintNumOps + 1]);
						goto IL_0b6f;
						IL_0b6f:
						num = 160;
						COFarDermalBasis = (string[])Utils.CopyArray((Array)COFarDermalBasis, (Array)new string[COFintNumOps + 1]);
						goto IL_0b9e;
						IL_0b9e:
						num = 163;
						COFarNaics1 = (string[,])Utils.CopyArray((Array)COFarNaics1, (Array)new string[100, COFintNumOps + 1]);
						goto IL_0bcf;
						IL_0bcf:
						num = 166;
						COFarNaics2 = (string[,])Utils.CopyArray((Array)COFarNaics2, (Array)new string[100, COFintNumOps + 1]);
						goto IL_0c00;
						IL_0c00:
						num = 169;
						COFarMiscOpParms = (float[,])Utils.CopyArray((Array)COFarMiscOpParms, (Array)new float[3, COFintNumOps + 1]);
						goto IL_0c30;
						IL_0c30:
						num = 172;
						COFarGssOptions = (short[,])Utils.CopyArray((Array)COFarGssOptions, (Array)new short[163, COFintNumOps + 1]);
						goto IL_0c64;
						IL_0c64:
						num = 175;
						COFarGssOther = (string[,])Utils.CopyArray((Array)COFarGssOther, (Array)new string[163, COFintNumOps + 1]);
						goto IL_0c98;
						IL_0c98:
						num = 178;
						COFarOSName = (string[,])Utils.CopyArray((Array)COFarOSName, (Array)new string[100, COFintNumOps + 1]);
						goto IL_0cc9;
						IL_0cc9:
						num = 181;
						COFarOSAddr = (string[,])Utils.CopyArray((Array)COFarOSAddr, (Array)new string[100, COFintNumOps + 1]);
						goto IL_0cfa;
						IL_0cfa:
						num = 184;
						COFarOSCity = (string[,])Utils.CopyArray((Array)COFarOSCity, (Array)new string[100, COFintNumOps + 1]);
						goto IL_0d2b;
						IL_0d2b:
						num = 187;
						COFarOSState = (string[,])Utils.CopyArray((Array)COFarOSState, (Array)new string[100, COFintNumOps + 1]);
						goto IL_0d5c;
						IL_0d5c:
						num = 190;
						COFarOSZip = (string[,])Utils.CopyArray((Array)COFarOSZip, (Array)new string[100, COFintNumOps + 1]);
						goto IL_0d8d;
						IL_0d8d:
						num = 193;
						COFarOSCty = (string[,])Utils.CopyArray((Array)COFarOSCty, (Array)new string[100, COFintNumOps + 1]);
						goto IL_0dbe;
						IL_0dbe:
						num = 196;
						COFarOpParms = (float[,])Utils.CopyArray((Array)COFarOpParms, (Array)new float[163, COFintNumOps + 1]);
						goto IL_0df2;
						IL_0df2:
						num = 199;
						COFarOpParmsType = (short[,])Utils.CopyArray((Array)COFarOpParmsType, (Array)new short[163, COFintNumOps + 1]);
						goto IL_0e26;
						IL_0e26:
						num = 202;
						COFarContParms = (float[,,])Utils.CopyArray((Array)COFarContParms, (Array)new float[16, 26, COFintNumOps + 1]);
						goto IL_0e59;
						IL_0e59:
						num = 205;
						COFarContParmTypes = (short[,,])Utils.CopyArray((Array)COFarContParmTypes, (Array)new short[16, 26, COFintNumOps + 1]);
						goto IL_0e8c;
						IL_0e8c:
						num = 208;
						COFarOpBorC = (short[])Utils.CopyArray((Array)COFarOpBorC, (Array)new short[COFintNumOps + 1]);
						goto IL_0ebb;
						IL_0ebb:
						num = 211;
						COFarOpIoE = (short[])Utils.CopyArray((Array)COFarOpIoE, (Array)new short[COFintNumOps + 1]);
						goto IL_0eea;
						IL_0eea:
						num = 214;
						COFarOpName = (string[])Utils.CopyArray((Array)COFarOpName, (Array)new string[COFintNumOps + 1]);
						goto IL_0f19;
						IL_0f19:
						num = 217;
						COFarOpNeedsMassBalance = (short[])Utils.CopyArray((Array)COFarOpNeedsMassBalance, (Array)new short[COFintNumOps + 1]);
						goto IL_0f48;
						IL_0f48:
						num = 220;
						COFarOpType = (short[])Utils.CopyArray((Array)COFarOpType, (Array)new short[COFintNumOps + 1]);
						goto IL_0f77;
						IL_0f77:
						num = 223;
						COFarOpOrder = (short[])Utils.CopyArray((Array)COFarOpOrder, (Array)new short[COFintNumOps + 1]);
						goto IL_0fa6;
						IL_0fa6:
						num = 226;
						COFarOpMassBalDisc = (short[,])Utils.CopyArray((Array)COFarOpMassBalDisc, (Array)new short[3, COFintNumOps + 1]);
						goto IL_0fd6;
						IL_0fd6:
						num = 229;
						COFarOpSP = (float[,])Utils.CopyArray((Array)COFarOpSP, (Array)new float[49, COFintNumOps + 1]);
						goto IL_1007;
						IL_1007:
						num = 232;
						COFarOpSPType = (short[,])Utils.CopyArray((Array)COFarOpSPType, (Array)new short[49, COFintNumOps + 1]);
						goto IL_1038;
						IL_1038:
						num = 235;
						COFarRelModels = (short[,,])Utils.CopyArray((Array)COFarRelModels, (Array)new short[11, 26, COFintNumOps + 1]);
						goto IL_106b;
						IL_106b:
						num = 238;
						COFarExpModels = (short[,,])Utils.CopyArray((Array)COFarExpModels, (Array)new short[3, 26, COFintNumOps + 1]);
						goto IL_109d;
						IL_109d:
						num = 241;
						if (Strings.Len(frmMain.DefInstance.lblDchem.Text) > 0)
						{
							goto IL_10c4;
						}
						goto IL_115f;
						IL_10c4:
						num = 242;
						COFarOpParms[29, COFintNumOps - 1] = Conversions.ToSingle(frmMain.DefInstance.lblDchem.Text);
						goto IL_10f4;
						IL_10f4:
						num = 243;
						COFarOpParmsType[29, COFintNumOps - 1] = 1;
						goto IL_1111;
						IL_1111:
						num = 244;
						COFarOpParms[30, COFintNumOps - 1] = Conversions.ToSingle(frmMain.DefInstance.lblDchem.Text);
						goto IL_1141;
						IL_1141:
						num = 245;
						COFarOpParmsType[30, COFintNumOps - 1] = 1;
						goto IL_115f;
						IL_115f:
						num = 247;
						switch (tabOps.SelectedIndex)
						{
						case 0:
							break;
						case 1:
							goto IL_2504;
						case 2:
							goto IL_4428;
						default:
							goto IL_44e3;
						}
						goto IL_118d;
						IL_4428:
						num = 678;
						if (importPreviouslySavedAssessment(Common.connGssTab3, Conversions.ToString(Support.GetItemData((Control)(object)lstImport, lstImport.SelectedIndex))))
						{
							goto IL_445e;
						}
						goto IL_44e3;
						IL_445e:
						num = 679;
						msfSelOps.AddItem(Conversions.ToString(unchecked((int)COFarOpType[checked(COFintNumOps - 1)])) + "\t" + Conversions.ToString(COFintNumOps - 1) + "\t" + Support.GetItemString((Control)(object)lstImport, lstImport.SelectedIndex) + text);
						goto IL_44e3;
						IL_2504:
						num = 421;
						num5 = (short)(COFintNumOps - 1);
						goto IL_2516;
						IL_2516:
						num = 422;
						COFarOpName[num5] = Support.GetItemString((Control)(object)lstGSS, lstGSS.SelectedIndex);
						goto IL_253d;
						IL_253d:
						num = 423;
						COFarOpType[num5] = (short)Support.GetItemData((Control)(object)lstGSS, lstGSS.SelectedIndex);
						goto IL_2564;
						IL_2564:
						num = 424;
						COFarOpOrder[num5] = (short)(COFintNumOps - 1);
						goto IL_257d;
						IL_257d:
						num = 425;
						COFarOpNeedsMassBalance[num5] = 1;
						goto IL_258e;
						IL_258e:
						num = 426;
						recordset.CursorLocation = CursorLocationEnum.adUseServer;
						goto IL_259e;
						IL_259e:
						num = 427;
						recordset.Open("SELECT * FROM Operations WHERE OpName='" + COFarOpName[num5] + "'", Common.gssConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
						goto IL_25cd;
						IL_25cd:
						num = 428;
						COFarPDesc[num5] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["ProcessDesc"].Value));
						goto IL_25fe;
						IL_25fe:
						num = 429;
						COFarPSInto1[num5] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["PSInto"].Value));
						goto IL_262f;
						IL_262f:
						num = 430;
						COFarPSInto2[num5] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["PSIntoOther"].Value));
						goto IL_2660;
						IL_2660:
						num = 431;
						COFarPSOut1[num5] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["PSOut"].Value));
						goto IL_2691;
						IL_2691:
						num = 432;
						COFarPSOut2[num5] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["PSOutOther"].Value));
						goto IL_26c2;
						IL_26c2:
						num = 433;
						COFarPSIn1[num5] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["PSIn"].Value));
						goto IL_26f3;
						IL_26f3:
						num = 434;
						COFarPSIn2[num5] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["PSInOther"].Value));
						goto IL_2724;
						IL_2724:
						num = 435;
						COFarOpBorC[num5] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["OpType"].Value)));
						goto IL_2759;
						IL_2759:
						num = 436;
						COFarOpIoE[num5] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["IoE"].Value)));
						goto IL_278e;
						IL_278e:
						num = 437;
						COFarMiscOpParms[0, num5] = Conversions.ToSingle(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["OpNumWorkers"].Value)));
						goto IL_27c8;
						IL_27c8:
						num = 438;
						COFarMiscOpParms[1, num5] = Conversions.ToSingle(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["NumWorkersExpDaysPerYear"].Value)));
						goto IL_2802;
						IL_2802:
						num = 439;
						COFarOpMassBalDisc[0, num5] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["MassBalDisc1"].Value)));
						goto IL_283c;
						IL_283c:
						num = 440;
						COFarOpMassBalDisc[1, num5] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["MassBalDisc2"].Value)));
						goto IL_2876;
						IL_2876:
						ProjectData.ClearProjectError();
						num3 = 3;
						goto IL_287e;
						IL_287e:
						num = 442;
						COFarBasis[num5] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["Basis"].Value));
						goto IL_28af;
						IL_28af:
						num = 443;
						COFarWaterBasis[num5] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["WaterRelBasis"].Value));
						goto IL_28e0;
						IL_28e0:
						num = 444;
						COFarInhalationBasis[num5] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["InhExpBasis"].Value));
						goto IL_2911;
						IL_2911:
						num = 445;
						COFarRelAddNotes[num5] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["AddNotesRelSummary"].Value));
						goto IL_2942;
						IL_2942:
						num = 446;
						COFarExpAddNotes[num5] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["AddNotesExpSummary"].Value));
						goto IL_2973;
						IL_2973:
						num = 447;
						COFarDermalBasis[num5] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["DerExpBasis"].Value));
						goto IL_29a4;
						IL_29a4:
						num = 448;
						COFarOpOrder[num5] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["OpOrder"].Value)));
						goto IL_29d9;
						IL_29d9:
						num = 449;
						COFarOpNumWorkers[0, num5] = Conversions.ToInteger(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["NWdefault"].Value)));
						goto IL_2a13;
						IL_2a13:
						num = 450;
						COFarOpNumWorkers[1, num5] = Conversions.ToInteger(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["NWestimated"].Value)));
						goto IL_2a4d;
						IL_2a4d:
						num = 451;
						COFarOpNumWorkersBasis[num5] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["NWbasis"].Value));
						goto IL_2a7e;
						IL_2a7e:
						num = 452;
						COFarOpNumWorkersBasisEnabled[num5] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["NWbasisEnabled"].Value)));
						goto IL_2ab3;
						IL_2ab3:
						num = 453;
						num9 = Conversions.ToShort(recordset.Fields["ScenarioID"].Value);
						goto IL_2ad6;
						IL_2ad6:
						num = 454;
						recordset.Close();
						goto IL_2ae5;
						IL_2ae5:
						num = 455;
						recordset.Open("SELECT * FROM OpNaics WHERE ScenarioID=" + Conversions.ToString(unchecked((int)num9)), Common.gssConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
						goto IL_2b0c;
						IL_2b0c:
						num = 456;
						if (!recordset.EOF)
						{
							goto IL_2b26;
						}
						goto IL_2ca4;
						IL_2b26:
						num = 457;
						command.ActiveConnection = Common.MyConn;
						goto IL_2b39;
						IL_2b39:
						num = 458;
						command.CommandText = "pqryGetNaicsDesc";
						goto IL_2b4c;
						IL_2b4c:
						num = 459;
						command.CommandType = CommandTypeEnum.adCmdStoredProc;
						goto IL_2c89;
						IL_2c89:
						num = 461;
						if (!recordset.EOF)
						{
							goto IL_2b60;
						}
						goto IL_2ca4;
						IL_2b60:
						num = 462;
						COFarNaics1[Conversions.ToInteger(recordset.Fields["NaicsIndex"].Value), num5] = Conversions.ToString(recordset.Fields["NAICS"].Value);
						goto IL_2baa;
						IL_2baa:
						num = 463;
						command.Parameters.Append(command.CreateParameter("pID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, RuntimeHelpers.GetObjectValue(recordset.Fields["NAICS"].Value)));
						goto IL_2be6;
						IL_2be6:
						num = 464;
						command2 = command;
						parActOrder = Missing.Value;
						parActNW_Route = Missing.Value;
						recordset2 = command2.Execute(out parActOrder, ref parActNW_Route);
						goto IL_2c08;
						IL_2c08:
						num = 465;
						command.Parameters.Delete("pID");
						goto IL_2c20;
						IL_2c20:
						num = 466;
						COFarNaics2[Conversions.ToInteger(recordset.Fields["NaicsIndex"].Value), num5] = Conversions.ToString(recordset2.Fields["NaicsDesc"].Value);
						goto IL_2c6a;
						IL_2c6a:
						num = 467;
						recordset2.Close();
						goto IL_2c79;
						IL_2c79:
						num = 468;
						recordset.MoveNext();
						goto IL_2c89;
						IL_2ca4:
						num = 471;
						recordset.Close();
						goto IL_2cb3;
						IL_2cb3:
						num = 472;
						recordset.Open("SELECT * FROM Activities WHERE ScenarioID=" + Conversions.ToString(unchecked((int)num9)), Common.gssConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
						goto IL_2f99;
						IL_2f99:
						num = 474;
						if (!recordset.EOF)
						{
							goto IL_2cdf;
						}
						goto IL_2fb3;
						IL_2fb3:
						num = 490;
						recordset.Close();
						goto IL_2fc2;
						IL_2fc2:
						num = 491;
						recordset.Open("SELECT * FROM OpParms WHERE ScenarioID=" + Conversions.ToString(unchecked((int)num9)), Common.gssConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
						goto IL_3113;
						IL_3113:
						num = 493;
						if (!recordset.EOF)
						{
							goto IL_2fee;
						}
						goto IL_312d;
						IL_312d:
						num = 505;
						recordset.Close();
						goto IL_313c;
						IL_313c:
						num = 506;
						recordset.Open("SELECT * FROM ActContParms WHERE ScenarioID=" + Conversions.ToString(unchecked((int)num9)), Common.gssConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
						goto IL_3226;
						IL_3226:
						num = 508;
						if (!recordset.EOF)
						{
							goto IL_3168;
						}
						goto IL_3240;
						IL_3240:
						num = 515;
						recordset.Close();
						goto IL_324f;
						IL_324f:
						num = 516;
						recordset.Open("SELECT * FROM GSSOptions WHERE ScenarioID=" + Conversions.ToString(unchecked((int)num9)), Common.gssConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
						goto IL_3311;
						IL_3311:
						num = 518;
						if (!recordset.EOF)
						{
							goto IL_327b;
						}
						goto IL_332b;
						IL_332b:
						num = 524;
						recordset.Close();
						goto IL_333a;
						IL_333a:
						num = 525;
						recordset.Open("SELECT * FROM ActRelModels WHERE ScenarioID=" + Conversions.ToString(unchecked((int)num9)), Common.gssConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
						goto IL_3b06;
						IL_3b06:
						num = 527;
						if (!recordset.EOF)
						{
							goto IL_3366;
						}
						goto IL_3b20;
						IL_3b20:
						num = 598;
						recordset.Close();
						goto IL_3b2f;
						IL_3b2f:
						num = 599;
						recordset.Open("SELECT * FROM ActExpModels WHERE ScenarioID=" + Conversions.ToString(unchecked((int)num9)), Common.gssConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
						goto IL_43e6;
						IL_43e6:
						num = 601;
						if (!recordset.EOF)
						{
							goto IL_3b5b;
						}
						goto IL_4400;
						IL_4400:
						num = 673;
						recordset.Close();
						goto IL_440f;
						IL_440f:
						num = 674;
						recordset = null;
						goto IL_4419;
						IL_4419:
						num = 675;
						command = null;
						goto IL_44e3;
						IL_3b5b:
						num = 602;
						COFarExpModels[Conversions.ToInteger(recordset.Fields["ExplModID"].Value), Conversions.ToInteger(recordset.Fields["ScenActID"].Value), num5] = (short)(COFintNumExpModels + 1);
						goto IL_3bae;
						IL_3bae:
						num = 603;
						COFarExpModType = (short[])Utils.CopyArray((Array)COFarExpModType, (Array)new short[COFintNumExpModels + 1 + 1]);
						goto IL_3bdf;
						IL_3bdf:
						num = 606;
						COFarExpModEst = (float[,,])Utils.CopyArray((Array)COFarExpModEst, (Array)new float[3, 19, COFintNumExpModels + 1 + 1]);
						goto IL_3c13;
						IL_3c13:
						num = 609;
						COFarExpModOutputOn = (short[,])Utils.CopyArray((Array)COFarExpModOutputOn, (Array)new short[3, COFintNumExpModels + 1 + 1]);
						goto IL_3c45;
						IL_3c45:
						num = 612;
						COFarExpModChar = (string[,])Utils.CopyArray((Array)COFarExpModChar, (Array)new string[3, COFintNumExpModels + 1 + 1]);
						goto IL_3c77;
						IL_3c77:
						num = 615;
						COFarExpModBasis = (string[])Utils.CopyArray((Array)COFarExpModBasis, (Array)new string[COFintNumExpModels + 1 + 1]);
						goto IL_3ca8;
						IL_3ca8:
						num = 618;
						COFarExpModChmSt = (short[])Utils.CopyArray((Array)COFarExpModChmSt, (Array)new short[COFintNumExpModels + 1 + 1]);
						goto IL_3cd9;
						IL_3cd9:
						num = 621;
						COFarExpModUncertainty = (short[])Utils.CopyArray((Array)COFarExpModUncertainty, (Array)new short[COFintNumExpModels + 1 + 1]);
						goto IL_3d0a;
						IL_3d0a:
						num = 624;
						COFarExpModStatus = (short[])Utils.CopyArray((Array)COFarExpModStatus, (Array)new short[COFintNumExpModels + 1 + 1]);
						goto IL_3d3b;
						IL_3d3b:
						num = 627;
						COFarExpModParmsV = (float[,,])Utils.CopyArray((Array)COFarExpModParmsV, (Array)new float[3, 163, COFintNumExpModels + 1 + 1]);
						goto IL_3d72;
						IL_3d72:
						num = 630;
						COFarExpModParmsT = (short[,,])Utils.CopyArray((Array)COFarExpModParmsT, (Array)new short[3, 163, COFintNumExpModels + 1 + 1]);
						goto IL_3da9;
						IL_3da9:
						num = 633;
						COFarExpModParmsVC = (short[,,])Utils.CopyArray((Array)COFarExpModParmsVC, (Array)new short[3, 163, COFintNumExpModels + 1 + 1]);
						goto IL_3de0;
						IL_3de0:
						num = 636;
						COFarExpModInhRC = (string[,])Utils.CopyArray((Array)COFarExpModInhRC, (Array)new string[5, COFintNumExpModels + 1 + 1]);
						goto IL_3e12;
						IL_3e12:
						num = 639;
						COFarExpModType[COFintNumExpModels] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["ModelID"].Value)));
						goto IL_3e4b;
						IL_3e4b:
						num = 640;
						COFarExpModOutputOn[0, COFintNumExpModels] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["OutputOn1"].Value)));
						goto IL_3e89;
						IL_3e89:
						num = 641;
						COFarExpModOutputOn[1, COFintNumExpModels] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["OutputOn2"].Value)));
						goto IL_3ec7;
						IL_3ec7:
						num = 642;
						COFarExpModChar[0, COFintNumExpModels] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["Char1"].Value));
						goto IL_3f00;
						IL_3f00:
						num = 643;
						COFarExpModChar[1, COFintNumExpModels] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["Char2"].Value));
						goto IL_3f39;
						IL_3f39:
						num = 644;
						COFarExpModBasis[COFintNumExpModels] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["Basis"].Value));
						goto IL_3f6e;
						IL_3f6e:
						num = 645;
						COFarExpModChmSt[COFintNumExpModels] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["ChemStateID"].Value)));
						goto IL_3fa7;
						IL_3fa7:
						num = 646;
						COFarExpModUncertainty[COFintNumExpModels] = Conversions.ToShort(Common.MyNullCheck1(RuntimeHelpers.GetObjectValue(recordset.Fields["inhUncertainty"].Value)));
						goto IL_3fe0;
						IL_3fe0:
						num = 647;
						COFarExpModStatus[COFintNumExpModels] = 0;
						goto IL_3ff5;
						IL_3ff5:
						num = 648;
						COFarExpModInhRC[0, COFintNumExpModels] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["InhClass"].Value));
						goto IL_402e;
						IL_402e:
						num = 649;
						COFarExpModInhRC[1, COFintNumExpModels] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["InhClassNotes"].Value));
						goto IL_4067;
						IL_4067:
						num = 650;
						COFarExpModInhRC[2, COFintNumExpModels] = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["InhClassExpLevel"].Value)), (object)1, false), (object)"Yes", (object)"No"));
						goto IL_40c0;
						IL_40c0:
						num = 651;
						COFarExpModInhRC[3, COFintNumExpModels] = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["InhClassHazRating"].Value)), (object)1, false), (object)"Yes", (object)"No"));
						goto IL_4119;
						IL_4119:
						num = 652;
						if (Operators.ConditionalCompareObjectEqual(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["InhClassInhMon"].Value)), (object)1, false))
						{
							goto IL_4152;
						}
						goto IL_4172;
						IL_4152:
						num = 653;
						COFarExpModInhRC[4, COFintNumExpModels] = "Yes (both criteria met)";
						goto IL_41f2;
						IL_4172:
						num = 655;
						if (Operators.ConditionalCompareObjectEqual(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["InhClassInhMon"].Value)), (object)0, false))
						{
							goto IL_41ab;
						}
						goto IL_41cb;
						IL_41ab:
						num = 656;
						COFarExpModInhRC[4, COFintNumExpModels] = "No";
						goto IL_41f2;
						IL_41cb:
						num = 658;
						goto IL_41d3;
						IL_41d3:
						num = 659;
						COFarExpModInhRC[4, COFintNumExpModels] = "";
						goto IL_41f2;
						IL_41f2:
						num = 661;
						recordset2.Open(Operators.ConcatenateObject((object)"SELECT * FROM ActExpModParms WHERE ExpParmsAN=", recordset.Fields["ExpParmsAN"].Value), Common.gssConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
						goto IL_4397;
						IL_4397:
						num = 663;
						if (!recordset2.EOF)
						{
							goto IL_422e;
						}
						goto IL_43b1;
						IL_43b1:
						num = 669;
						recordset2.Close();
						goto IL_43c0;
						IL_43c0:
						num = 670;
						COFintNumExpModels++;
						goto IL_43d6;
						IL_43d6:
						num = 671;
						recordset.MoveNext();
						goto IL_43e6;
						IL_422e:
						num = 664;
						COFarExpModParmsV[Conversions.ToInteger(recordset2.Fields["OutputID"].Value), Conversions.ToInteger(recordset2.Fields["ParmID"].Value), COFintNumExpModels] = Conversions.ToSingle(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["ParmValue"].Value)));
						goto IL_42a1;
						IL_42a1:
						num = 665;
						COFarExpModParmsT[Conversions.ToInteger(recordset2.Fields["OutputID"].Value), Conversions.ToInteger(recordset2.Fields["ParmID"].Value), COFintNumExpModels] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["ParmType"].Value)));
						goto IL_4314;
						IL_4314:
						num = 666;
						COFarExpModParmsVC[Conversions.ToInteger(recordset2.Fields["OutputID"].Value), Conversions.ToInteger(recordset2.Fields["ParmID"].Value), COFintNumExpModels] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["ParmVC"].Value)));
						goto IL_4387;
						IL_4387:
						num = 667;
						recordset2.MoveNext();
						goto IL_4397;
						IL_3366:
						num = 528;
						COFarRelModType = (short[])Utils.CopyArray((Array)COFarRelModType, (Array)new short[COFintNumRelModels + 1 + 1]);
						goto IL_3397;
						IL_3397:
						num = 531;
						COFarRelModBasis = (string[])Utils.CopyArray((Array)COFarRelModBasis, (Array)new string[COFintNumRelModels + 1 + 1]);
						goto IL_33c8;
						IL_33c8:
						num = 534;
						COFarRelModNAICS = (string[])Utils.CopyArray((Array)COFarRelModNAICS, (Array)new string[COFintNumRelModels + 1 + 1]);
						goto IL_33f9;
						IL_33f9:
						num = 537;
						COFarRelModStatus = (short[])Utils.CopyArray((Array)COFarRelModStatus, (Array)new short[COFintNumRelModels + 1 + 1]);
						goto IL_342a;
						IL_342a:
						num = 540;
						COFarRelModOutputOn = (short[,])Utils.CopyArray((Array)COFarRelModOutputOn, (Array)new short[3, COFintNumRelModels + 1 + 1]);
						goto IL_345c;
						IL_345c:
						num = 543;
						COFarRelModChar = (string[,])Utils.CopyArray((Array)COFarRelModChar, (Array)new string[3, COFintNumRelModels + 1 + 1]);
						goto IL_348e;
						IL_348e:
						num = 546;
						COFarRelModMedia = (float[,])Utils.CopyArray((Array)COFarRelModMedia, (Array)new float[19, COFintNumRelModels + 1 + 1]);
						goto IL_34c1;
						IL_34c1:
						num = 549;
						COFarRelModParmsV = (float[,,])Utils.CopyArray((Array)COFarRelModParmsV, (Array)new float[3, 163, COFintNumRelModels + 1 + 1]);
						goto IL_34f8;
						IL_34f8:
						num = 552;
						COFarRelModParmsT = (short[,,])Utils.CopyArray((Array)COFarRelModParmsT, (Array)new short[3, 163, COFintNumRelModels + 1 + 1]);
						goto IL_352f;
						IL_352f:
						num = 555;
						COFarRelModParmsVC = (short[,,])Utils.CopyArray((Array)COFarRelModParmsVC, (Array)new short[3, 163, COFintNumRelModels + 1 + 1]);
						goto IL_3566;
						IL_3566:
						num = 558;
						COFarRelModDRR = (float[,])Utils.CopyArray((Array)COFarRelModDRR, (Array)new float[3, COFintNumRelModels + 1 + 1]);
						goto IL_3598;
						IL_3598:
						num = 561;
						COFarRelModARR = (float[,])Utils.CopyArray((Array)COFarRelModARR, (Array)new float[3, COFintNumRelModels + 1 + 1]);
						goto IL_35ca;
						IL_35ca:
						num = 564;
						COFarRelModDOR = (short[,])Utils.CopyArray((Array)COFarRelModDOR, (Array)new short[3, COFintNumRelModels + 1 + 1]);
						goto IL_35fc;
						IL_35fc:
						num = 567;
						num10 = Conversions.ToShort(recordset.Fields["ScenActID"].Value);
						goto IL_3620;
						IL_3620:
						num = 568;
						num11 = Conversions.ToShort(recordset.Fields["RelModID"].Value);
						goto IL_3644;
						IL_3644:
						num = 569;
						COFarRelModels[num11, num10, num5] = (short)(COFintNumRelModels + 1);
						goto IL_3665;
						IL_3665:
						num = 570;
						COFarRelModType[COFintNumRelModels] = Conversions.ToShort(recordset.Fields["ModelID"].Value);
						goto IL_3694;
						IL_3694:
						num = 571;
						COFarRelModBasis[COFintNumRelModels] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["Basis"].Value));
						goto IL_36c9;
						IL_36c9:
						num = 572;
						COFarRelModNAICS[COFintNumRelModels] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["NAICS"].Value));
						goto IL_36fe;
						IL_36fe:
						num = 573;
						COFarRelModStatus[COFintNumRelModels] = 0;
						goto IL_3713;
						IL_3713:
						num = 574;
						COFarRelModOutputOn[0, COFintNumRelModels] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["OutputOn1"].Value)));
						goto IL_3751;
						IL_3751:
						num = 575;
						COFarRelModChar[0, COFintNumRelModels] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["Char1"].Value));
						goto IL_378a;
						IL_378a:
						num = 576;
						COFarRelModOutputOn[1, COFintNumRelModels] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["OutputOn2"].Value)));
						goto IL_37c8;
						IL_37c8:
						num = 577;
						COFarRelModChar[1, COFintNumRelModels] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["Char2"].Value));
						goto IL_3801;
						IL_3801:
						num = 578;
						recordset2.Open(Operators.ConcatenateObject((object)"SELECT * FROM ActRelModParms WHERE RelParmsAN=", recordset.Fields["RelParmsAN"].Value), Common.gssConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
						goto IL_39a6;
						IL_39a6:
						num = 580;
						if (!recordset2.EOF)
						{
							goto IL_383d;
						}
						goto IL_39c0;
						IL_39c0:
						num = 586;
						recordset2.Close();
						goto IL_39cf;
						IL_39cf:
						num = 587;
						source = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat("SELECT MediaID, Pct FROM ActRelModMedia WHERE scenarioID=" + Conversions.ToString(unchecked((int)num9)), " AND ScenActID="), recordset.Fields["ScenActID"].Value), (object)" AND RelModID="), recordset.Fields["RelModID"].Value));
						goto IL_3a37;
						IL_3a37:
						num = 588;
						recordset2.Open(source, Common.gssConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
						goto IL_3aba;
						IL_3aba:
						num = 590;
						if (!recordset2.EOF)
						{
							goto IL_3a52;
						}
						goto IL_3ad1;
						IL_3ad1:
						num = 594;
						recordset2.Close();
						goto IL_3ae0;
						IL_3ae0:
						num = 595;
						recordset.MoveNext();
						goto IL_3aef;
						IL_3aef:
						num = 596;
						COFintNumRelModels++;
						goto IL_3b06;
						IL_3a52:
						num = 591;
						COFarRelModMedia[Conversions.ToInteger(recordset2.Fields["MediaID"].Value), COFintNumRelModels] = Conversions.ToSingle(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["Pct"].Value)));
						goto IL_3aaa;
						IL_3aaa:
						num = 592;
						recordset2.MoveNext();
						goto IL_3aba;
						IL_383d:
						num = 581;
						COFarRelModParmsV[Conversions.ToInteger(recordset2.Fields["OutputID"].Value), Conversions.ToInteger(recordset2.Fields["ParmID"].Value), COFintNumRelModels] = Conversions.ToSingle(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["ParmValue"].Value)));
						goto IL_38b0;
						IL_38b0:
						num = 582;
						COFarRelModParmsT[Conversions.ToInteger(recordset2.Fields["OutputID"].Value), Conversions.ToInteger(recordset2.Fields["ParmID"].Value), COFintNumRelModels] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["ParmType"].Value)));
						goto IL_3923;
						IL_3923:
						num = 583;
						COFarRelModParmsVC[Conversions.ToInteger(recordset2.Fields["OutputID"].Value), Conversions.ToInteger(recordset2.Fields["ParmID"].Value), COFintNumRelModels] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["ParmVC"].Value)));
						goto IL_3996;
						IL_3996:
						num = 584;
						recordset2.MoveNext();
						goto IL_39a6;
						IL_327b:
						num = 519;
						num10 = Conversions.ToShort(recordset.Fields["ParmID"].Value);
						goto IL_329f;
						IL_329f:
						num = 520;
						COFarGssOptions[num10, num5] = Conversions.ToShort(recordset.Fields["OptionValue"].Value);
						goto IL_32d0;
						IL_32d0:
						num = 521;
						COFarGssOther[num10, num5] = Conversions.ToString(recordset.Fields["Other"].Value);
						goto IL_3301;
						IL_3301:
						num = 522;
						recordset.MoveNext();
						goto IL_3311;
						IL_3168:
						num = 509;
						num10 = Conversions.ToShort(recordset.Fields["ScenActID"].Value);
						goto IL_318c;
						IL_318c:
						num = 510;
						num11 = Conversions.ToShort(recordset.Fields["ParmID"].Value);
						goto IL_31b0;
						IL_31b0:
						num = 511;
						COFarContParms[num11, num10, num5] = Conversions.ToSingle(recordset.Fields["ParmValue"].Value);
						goto IL_31e3;
						IL_31e3:
						num = 512;
						COFarContParmTypes[num11, num10, num5] = Conversions.ToShort(recordset.Fields["ParmType"].Value);
						goto IL_3216;
						IL_3216:
						num = 513;
						recordset.MoveNext();
						goto IL_3226;
						IL_2fee:
						num = 494;
						num10 = Conversions.ToShort(recordset.Fields["ParmID"].Value);
						goto IL_3012;
						IL_3012:
						num = 495;
						if (num10 < 1000)
						{
							goto IL_3028;
						}
						goto IL_308c;
						IL_3028:
						num = 496;
						COFarOpParms[num10, num5] = Conversions.ToSingle(recordset.Fields["ParmValue"].Value);
						goto IL_3059;
						IL_3059:
						num = 497;
						COFarOpParmsType[num10, num5] = Conversions.ToShort(recordset.Fields["ParmType"].Value);
						goto IL_3103;
						IL_308c:
						num = 499;
						goto IL_3094;
						IL_3094:
						num = 500;
						COFarOpSP[num10 - 1000, num5] = Conversions.ToSingle(recordset.Fields["ParmValue"].Value);
						goto IL_30cb;
						IL_30cb:
						num = 501;
						COFarOpSPType[num10 - 1000, num5] = Conversions.ToShort(recordset.Fields["ParmType"].Value);
						goto IL_3103;
						IL_3103:
						num = 503;
						recordset.MoveNext();
						goto IL_3113;
						IL_2cdf:
						num = 475;
						num10 = Conversions.ToShort(recordset.Fields["ScenActID"].Value);
						goto IL_2d03;
						IL_2d03:
						num = 476;
						COFarSelActs[num10, num5] = Conversions.ToString(recordset.Fields["ActName"].Value);
						goto IL_2d34;
						IL_2d34:
						num = 477;
						COFarSelActType[num10, num5] = Conversions.ToShort(recordset.Fields["ActID"].Value);
						goto IL_2d65;
						IL_2d65:
						num = 478;
						COFarSelActRa[num10, num5] = Conversions.ToBoolean(recordset.Fields["DoRel"].Value);
						goto IL_2d96;
						IL_2d96:
						num = 479;
						COFarSelActEa[num10, num5] = Conversions.ToBoolean(recordset.Fields["DoExp"].Value);
						goto IL_2dc7;
						IL_2dc7:
						num = 480;
						COFarSelActRaDMP[num10, num5] = Conversions.ToShort(recordset.Fields["DidRel"].Value);
						goto IL_2df8;
						IL_2df8:
						num = 481;
						COFarSelActEaDMP[num10, num5] = Conversions.ToShort(recordset.Fields["DidExp"].Value);
						goto IL_2e29;
						IL_2e29:
						num = 482;
						COFarSelActVolatile[num10, num5] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["Volatile"].Value)));
						goto IL_2e64;
						IL_2e64:
						num = 483;
						COFarActNumWorkers[0, num10, num5] = Conversions.ToInteger(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["NW_NS"].Value)));
						goto IL_2ea0;
						IL_2ea0:
						num = 484;
						COFarActNumWorkers[1, num10, num5] = Conversions.ToInteger(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["NW_NWexp"].Value)));
						goto IL_2edc;
						IL_2edc:
						num = 485;
						COFarActNumWorkers[2, num10, num5] = Conversions.ToInteger(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["NW_NSxNWexp"].Value)));
						goto IL_2f18;
						IL_2f18:
						num = 486;
						COFarActNW_Route[num10, num5] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["NW_Route"].Value));
						goto IL_2f4e;
						IL_2f4e:
						num = 487;
						COFarActOrder[num10, num5] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["ActOrder"].Value)));
						goto IL_2f89;
						IL_2f89:
						num = 488;
						recordset.MoveNext();
						goto IL_2f99;
						IL_118d:
						num = 251;
						COFarOpName[COFintNumOps - 1] = Support.GetItemString((Control)(object)lstOps, lstOps.SelectedIndex) + text;
						goto IL_11c1;
						IL_11c1:
						num = 252;
						COFarOpType[COFintNumOps - 1] = (short)Support.GetItemData((Control)(object)lstOps, lstOps.SelectedIndex);
						goto IL_11ee;
						IL_11ee:
						num = 253;
						COFarOpOrder[COFintNumOps - 1] = (short)(COFintNumOps - 1);
						goto IL_120d;
						IL_120d:
						num = 254;
						command.ActiveConnection = Common.MyConn;
						goto IL_1220;
						IL_1220:
						num = 255;
						command.CommandText = "pqryGetOpDefaults";
						goto IL_1233;
						IL_1233:
						num = 256;
						command.CommandType = CommandTypeEnum.adCmdStoredProc;
						goto IL_1242;
						IL_1242:
						num = 257;
						command.Parameters.Append(command.CreateParameter("pOpID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, Support.GetItemData((Control)(object)lstOps, lstOps.SelectedIndex)));
						goto IL_127e;
						IL_127e:
						num = 258;
						command3 = command;
						parActOrder = Missing.Value;
						parActNW_Route = Missing.Value;
						recordset = command3.Execute(out parActOrder, ref parActNW_Route);
						goto IL_12a0;
						IL_12a0:
						num = 259;
						command.Parameters.Delete("pOpID");
						goto IL_12b8;
						IL_12b8:
						num = 260;
						COFarOpBorC[COFintNumOps - 1] = Conversions.ToShort(recordset.Fields["BatchOrCont"].Value);
						goto IL_12e9;
						IL_12e9:
						num = 261;
						COFarOpIoE[COFintNumOps - 1] = Conversions.ToShort(recordset.Fields["InfOrEff"].Value);
						goto IL_131a;
						IL_131a:
						num = 262;
						text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["DefaultNAICS"].Value)), (object)"", RuntimeHelpers.GetObjectValue(recordset.Fields["DefaultNAICS"].Value)));
						goto IL_136d;
						IL_136d:
						num = 263;
						COFarPDesc[COFintNumOps - 1] = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["DefaultProcDesc"].Value)), (object)"", RuntimeHelpers.GetObjectValue(recordset.Fields["DefaultProcDesc"].Value)));
						goto IL_13ce;
						IL_13ce:
						num = 264;
						recordset.Close();
						goto IL_13dd;
						IL_13dd:
						num = 265;
						if (Strings.Len(text) > 0)
						{
							goto IL_13f7;
						}
						goto IL_163d;
						IL_13f7:
						num = 266;
						command.CommandText = "pqryGetNaicsDesc";
						goto IL_140a;
						IL_140a:
						num = 267;
						command.CommandType = CommandTypeEnum.adCmdStoredProc;
						goto IL_1419;
						IL_1419:
						num = 268;
						num5 = 0;
						goto IL_1424;
						IL_1424:
						num = 270;
						num10 = (short)Strings.InStr(text, ",", (CompareMethod)0);
						goto IL_143b;
						IL_143b:
						num = 271;
						if (num10 == 0)
						{
							goto IL_1450;
						}
						goto IL_152f;
						IL_1450:
						num = 272;
						COFarNaics1[num5, COFintNumOps - 1] = text;
						goto IL_146e;
						IL_146e:
						num = 273;
						command.Parameters.Append(command.CreateParameter("pID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, COFarNaics1[num5, COFintNumOps - 1]));
						goto IL_14a4;
						IL_14a4:
						num = 274;
						command4 = command;
						parActOrder = Missing.Value;
						parActNW_Route = Missing.Value;
						recordset = command4.Execute(out parActOrder, ref parActNW_Route);
						goto IL_14c6;
						IL_14c6:
						num = 275;
						command.Parameters.Delete("pID");
						goto IL_14de;
						IL_14de:
						num = 276;
						COFarNaics2[num5, COFintNumOps - 1] = Conversions.ToString(recordset.Fields["NaicsDesc"].Value);
						goto IL_1515;
						IL_1515:
						num = 277;
						recordset.Close();
						goto IL_163d;
						IL_152f:
						num = 280;
						goto IL_1537;
						IL_1537:
						num = 281;
						COFarNaics1[num5, COFintNumOps - 1] = Strings.Left(text, num10 - 1);
						goto IL_155e;
						IL_155e:
						num = 282;
						command.Parameters.Append(command.CreateParameter("pID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, COFarNaics1[num5, COFintNumOps - 1]));
						goto IL_1594;
						IL_1594:
						num = 283;
						command5 = command;
						parActOrder = Missing.Value;
						parActNW_Route = Missing.Value;
						recordset = command5.Execute(out parActOrder, ref parActNW_Route);
						goto IL_15b6;
						IL_15b6:
						num = 284;
						command.Parameters.Delete("pID");
						goto IL_15ce;
						IL_15ce:
						num = 285;
						COFarNaics2[num5, COFintNumOps - 1] = Conversions.ToString(recordset.Fields["NaicsDesc"].Value);
						goto IL_1605;
						IL_1605:
						num = 286;
						recordset.Close();
						goto IL_1614;
						IL_1614:
						num = 287;
						text = Strings.Mid(text, num10 + 1);
						goto IL_1628;
						IL_1628:
						num = 288;
						num5++;
						goto IL_1424;
						IL_163d:
						num = 292;
						COFarOpParms[98, COFintNumOps - 1] = 250f;
						goto IL_165e;
						IL_165e:
						num = 293;
						COFarOpParms[39, COFintNumOps - 1] = 1f;
						goto IL_167f;
						IL_167f:
						num = 294;
						cOFarOpParms = COFarOpParms;
						num12 = COFintNumOps - 1;
						cOFintNumOps = ref COFintNumOps;
						pFirstOp = ref COFarNoPre[COFintNumOps - 1];
						cOFintNumOps2 = ref COFintNumOps;
						parActOrder = COFarOpParms;
						parActNW_Route = COFarSubOpID;
						xrmDefault = ChemStrX.GetXrmDefault(ref cOFintNumOps, ref pFirstOp, ref cOFintNumOps2, ref parActOrder, ref parActNW_Route);
						COFarSubOpID = (short[,])parActNW_Route;
						COFarOpParms = (float[,])parActOrder;
						cOFarOpParms[118, num12] = xrmDefault;
						goto IL_16ed;
						IL_16ed:
						num = 295;
						COFarOpParmsType[118, COFintNumOps - 1] = 1;
						goto IL_170a;
						IL_170a:
						num = 296;
						COFarOpParms[119, COFintNumOps - 1] = COFarOpParms[118, COFintNumOps - 1];
						goto IL_173b;
						IL_173b:
						num = 297;
						COFarOpParmsType[119, COFintNumOps - 1] = 1;
						goto IL_1758;
						IL_1758:
						num = 298;
						COFarOpParms[120, COFintNumOps - 1] = COFarOpParms[118, COFintNumOps - 1];
						goto IL_1789;
						IL_1789:
						num = 299;
						COFarOpParmsType[120, COFintNumOps - 1] = 1;
						goto IL_17a6;
						IL_17a6:
						num = 300;
						if (Versioned.IsNumeric((object)frmMain.DefInstance.lblVP.Text))
						{
							goto IL_17ca;
						}
						goto IL_1891;
						IL_17ca:
						num = 301;
						COFarOpParms[121, COFintNumOps - 1] = COFarOpParms[118, COFintNumOps - 1] * Conversions.ToSingle(frmMain.DefInstance.lblVP.Text);
						goto IL_1810;
						IL_1810:
						num = 302;
						COFarOpParms[122, COFintNumOps - 1] = COFarOpParms[119, COFintNumOps - 1] * Conversions.ToSingle(frmMain.DefInstance.lblVP.Text);
						goto IL_1856;
						IL_1856:
						num = 303;
						COFarOpParmsType[121, COFintNumOps - 1] = 4;
						goto IL_1873;
						IL_1873:
						num = 304;
						COFarOpParmsType[122, COFintNumOps - 1] = 4;
						goto IL_1891;
						IL_1891:
						num = 306;
						if (Versioned.IsNumeric((object)frmMain.DefInstance.lblVP.Text))
						{
							goto IL_18b2;
						}
						goto IL_1905;
						IL_18b2:
						num = 307;
						if ((double)Conversions.ToSingle(frmMain.DefInstance.lblVP.Text) >= 0.001)
						{
							goto IL_18e2;
						}
						goto IL_1905;
						IL_18e2:
						num = 308;
						COFarOpSP[44, COFintNumOps - 1] = 1f;
						goto IL_1905;
						IL_1905:
						num = 311;
						obj = "\r\n";
						goto IL_1913;
						IL_1913:
						num = 312;
						switch (Support.GetItemData((Control)(object)lstOps, lstOps.SelectedIndex))
						{
						case 100:
							break;
						case 101:
							goto IL_1b06;
						case 102:
							goto IL_1cd6;
						case 103:
							goto IL_1db2;
						case 104:
							goto IL_1f31;
						default:
							goto IL_1fe4;
						}
						goto IL_1957;
						IL_1f31:
						num = 364;
						cOFarOpParms2 = COFarOpParms;
						num13 = COFintNumOps - 1;
						pGSSID = 104;
						opindex = 142;
						cOFarOpParms2[142, num13] = ChemStrX.SetGSSParmDefault(ref pGSSID, ref opindex);
						goto IL_1f64;
						IL_1f64:
						num = 365;
						COFarOpParmsType[142, COFintNumOps - 1] = 1;
						goto IL_1f84;
						IL_1f84:
						num = 366;
						COFarOpSP[47, COFintNumOps - 1] = 1f;
						goto IL_1fa5;
						IL_1fa5:
						num = 367;
						COFarOpSPType[47, COFintNumOps - 1] = 1;
						goto IL_1fc2;
						IL_1fc2:
						num = 368;
						COFarOpSP[46, COFintNumOps - 1] = 1f;
						goto IL_1fe4;
						IL_1db2:
						num = 353;
						COFarOpParmsType[92, COFintNumOps - 1] = 1;
						goto IL_1dcf;
						IL_1dcf:
						num = 354;
						COFarOpSP[45, COFintNumOps - 1] = 1f;
						goto IL_1df0;
						IL_1df0:
						num = 355;
						cOFarOpParms3 = COFarOpParms;
						num14 = COFintNumOps - 1;
						pGSSID = 103;
						opindex = 126;
						cOFarOpParms3[126, num14] = ChemStrX.SetGSSParmDefault(ref pGSSID, ref opindex);
						goto IL_1e1d;
						IL_1e1d:
						num = 356;
						cOFarOpParms4 = COFarOpParms;
						num15 = COFintNumOps - 1;
						pGSSID = 103;
						opindex = 124;
						cOFarOpParms4[124, num15] = ChemStrX.SetGSSParmDefault(ref pGSSID, ref opindex);
						goto IL_1e4a;
						IL_1e4a:
						num = 357;
						COFarOpParms[35, COFintNumOps - 1] = 24f;
						goto IL_1e6b;
						IL_1e6b:
						num = 358;
						cOFarOpParms5 = COFarOpParms;
						num16 = COFintNumOps - 1;
						pGSSID = 103;
						opindex = 125;
						cOFarOpParms5[125, num16] = ChemStrX.SetGSSParmDefault(ref pGSSID, ref opindex);
						goto IL_1e98;
						IL_1e98:
						num = 359;
						cOFarOpParms6 = COFarOpParms;
						num17 = COFintNumOps - 1;
						pGSSID = 103;
						opindex = 127;
						cOFarOpParms6[127, num17] = ChemStrX.SetGSSParmDefault(ref pGSSID, ref opindex);
						goto IL_1ec5;
						IL_1ec5:
						num = 360;
						cOFarOpParms7 = COFarOpParms;
						num18 = COFintNumOps - 1;
						pGSSID = 103;
						opindex = 128;
						cOFarOpParms7[128, num18] = ChemStrX.SetGSSParmDefault(ref pGSSID, ref opindex);
						goto IL_1ef8;
						IL_1ef8:
						num = 361;
						cOFarOpParms8 = COFarOpParms;
						num19 = COFintNumOps - 1;
						pGSSID = 103;
						opindex = 129;
						cOFarOpParms8[129, num19] = ChemStrX.SetGSSParmDefault(ref pGSSID, ref opindex);
						goto IL_1fe4;
						IL_1cd6:
						num = 344;
						COFarOpParms[10, COFintNumOps - 1] = 0.33f;
						goto IL_1cf7;
						IL_1cf7:
						num = 345;
						COFarOpParmsType[10, COFintNumOps - 1] = 1;
						goto IL_1d14;
						IL_1d14:
						num = 346;
						COFarOpParms[32, COFintNumOps - 1] = 4000f;
						goto IL_1d35;
						IL_1d35:
						num = 347;
						COFarOpParmsType[32, COFintNumOps - 1] = 1;
						goto IL_1d52;
						IL_1d52:
						num = 348;
						COFarOpParms[114, COFintNumOps - 1] = 500000f;
						goto IL_1d73;
						IL_1d73:
						num = 349;
						COFarOpParmsType[114, COFintNumOps - 1] = 1;
						goto IL_1d90;
						IL_1d90:
						num = 350;
						COFarOpParmsType[1, COFintNumOps - 1] = 1;
						goto IL_1fe4;
						IL_1b06:
						num = 329;
						cOFarOpParms9 = COFarOpParms;
						num20 = COFintNumOps - 1;
						pGSSID = 101;
						opindex = 116;
						cOFarOpParms9[116, num20] = ChemStrX.SetGSSParmDefault(ref pGSSID, ref opindex);
						goto IL_1b33;
						IL_1b33:
						num = 330;
						COFarOpParmsType[116, COFintNumOps - 1] = 1;
						goto IL_1b50;
						IL_1b50:
						num = 331;
						cOFarOpParms10 = COFarOpParms;
						num21 = COFintNumOps - 1;
						pGSSID = 101;
						opindex = 2;
						cOFarOpParms10[2, num21] = ChemStrX.SetGSSParmDefault(ref pGSSID, ref opindex);
						goto IL_1b7b;
						IL_1b7b:
						num = 332;
						COFarOpParmsType[2, COFintNumOps - 1] = 1;
						goto IL_1b97;
						IL_1b97:
						num = 333;
						COFarOpParms[14, COFintNumOps - 1] = COFarOpParms[116, COFintNumOps - 1] * COFarOpParms[29, COFintNumOps - 1];
						goto IL_1bde;
						IL_1bde:
						num = 334;
						COFarOpParmsType[14, COFintNumOps - 1] = 1;
						goto IL_1bfb;
						IL_1bfb:
						num = 335;
						COFarOpSP[1, COFintNumOps - 1] = 2f;
						goto IL_1c1b;
						IL_1c1b:
						num = 336;
						COFarOpSP[2, COFintNumOps - 1] = 2f;
						goto IL_1c3b;
						IL_1c3b:
						num = 337;
						COFarOpSP[3, COFintNumOps - 1] = 2f;
						goto IL_1c5b;
						IL_1c5b:
						num = 338;
						COFarOpSPType[1, COFintNumOps - 1] = 1;
						goto IL_1c77;
						IL_1c77:
						num = 339;
						COFarOpSPType[2, COFintNumOps - 1] = 1;
						goto IL_1c93;
						IL_1c93:
						num = 340;
						COFarOpSPType[3, COFintNumOps - 1] = 1;
						goto IL_1caf;
						IL_1caf:
						num = 341;
						COFarOpSP[43, COFintNumOps - 1] = 1f;
						goto IL_1fe4;
						IL_1957:
						num = 316;
						cOFarOpParms11 = COFarOpParms;
						num22 = COFintNumOps - 1;
						opindex = 100;
						pGSSID = 21;
						cOFarOpParms11[21, num22] = ChemStrX.SetGSSParmDefault(ref opindex, ref pGSSID);
						goto IL_1984;
						IL_1984:
						num = 317;
						cOFarOpParms12 = COFarOpParms;
						num23 = COFintNumOps - 1;
						pGSSID = 100;
						opindex = 25;
						cOFarOpParms12[25, num23] = ChemStrX.SetGSSParmDefault(ref pGSSID, ref opindex);
						goto IL_19b1;
						IL_19b1:
						num = 318;
						COFarOpParms[12, COFintNumOps - 1] = COFarOpParms[21, COFintNumOps - 1] * COFarOpParms[25, COFintNumOps - 1] * COFarOpParms[30, COFintNumOps - 1];
						goto IL_1a0e;
						IL_1a0e:
						num = 319;
						COFarOpParmsType[12, COFintNumOps - 1] = 1;
						goto IL_1a2b;
						IL_1a2b:
						num = 320;
						COFarOpSP[1, COFintNumOps - 1] = 2f;
						goto IL_1a4b;
						IL_1a4b:
						num = 321;
						COFarOpSP[2, COFintNumOps - 1] = 1f;
						goto IL_1a6b;
						IL_1a6b:
						num = 322;
						COFarOpSP[3, COFintNumOps - 1] = 1f;
						goto IL_1a8b;
						IL_1a8b:
						num = 323;
						COFarOpSPType[1, COFintNumOps - 1] = 1;
						goto IL_1aa7;
						IL_1aa7:
						num = 324;
						COFarOpSPType[2, COFintNumOps - 1] = 1;
						goto IL_1ac3;
						IL_1ac3:
						num = 325;
						COFarOpSPType[3, COFintNumOps - 1] = 1;
						goto IL_1adf;
						IL_1adf:
						num = 326;
						COFarOpSP[43, COFintNumOps - 1] = 1f;
						goto IL_1fe4;
						IL_1fe4:
						num = 370;
						num4 = 0;
						goto IL_1fed;
						IL_1fed:
						num = 371;
						command.ActiveConnection = Common.MyConn;
						goto IL_2000;
						IL_2000:
						num = 372;
						command.CommandText = "pqryAutoSelectActs";
						goto IL_2013;
						IL_2013:
						num = 373;
						command.CommandType = CommandTypeEnum.adCmdStoredProc;
						goto IL_2022;
						IL_2022:
						num = 374;
						command.Parameters.Append(command.CreateParameter("pOpID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, Support.GetItemData((Control)(object)lstOps, lstOps.SelectedIndex)));
						goto IL_205e;
						IL_205e:
						num = 375;
						command6 = command;
						parActOrder = Missing.Value;
						parActNW_Route = Missing.Value;
						recordset = command6.Execute(out parActOrder, ref parActNW_Route);
						goto IL_20d5;
						IL_20d5:
						num = 377;
						if (!recordset.EOF)
						{
							goto IL_2082;
						}
						goto IL_20ec;
						IL_20ec:
						num = 382;
						recordset.Close();
						goto IL_20fb;
						IL_20fb:
						num = 383;
						command.Parameters.Delete("pOpID");
						goto IL_2113;
						IL_2113:
						num = 384;
						if (num4 > 0)
						{
							goto IL_2127;
						}
						goto IL_24eb;
						IL_2127:
						num = 385;
						num24 = (short)(num4 - 1);
						num10 = 0;
						goto IL_24dd;
						IL_24dd:
						num25 = num10;
						num8 = num24;
						if (num25 <= num8)
						{
							goto IL_213c;
						}
						goto IL_24eb;
						IL_213c:
						num = 386;
						command.ActiveConnection = Common.MyConn;
						goto IL_214f;
						IL_214f:
						num = 387;
						command.CommandText = "pqryGetActivity";
						goto IL_2162;
						IL_2162:
						num = 388;
						command.CommandType = CommandTypeEnum.adCmdStoredProc;
						goto IL_2171;
						IL_2171:
						num = 389;
						command.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, COFarSelActType[num10, COFintNumOps - 1]));
						goto IL_21ac;
						IL_21ac:
						num = 390;
						command7 = command;
						parActOrder = Missing.Value;
						parActNW_Route = Missing.Value;
						recordset = command7.Execute(out parActOrder, ref parActNW_Route);
						goto IL_21ce;
						IL_21ce:
						num = 391;
						COFarSelActs[num10, COFintNumOps - 1] = Conversions.ToString(recordset.Fields["ActName"].Value);
						goto IL_2205;
						IL_2205:
						num = 392;
						COFarSelActRa[num10, COFintNumOps - 1] = Operators.ConditionalCompareObjectEqual(recordset.Fields["RelActivity"].Value, (object)1, false);
						goto IL_2243;
						IL_2243:
						num = 393;
						COFarSelActEa[num10, COFintNumOps - 1] = Operators.ConditionalCompareObjectEqual(recordset.Fields["ExpActivity"].Value, (object)1, false);
						goto IL_2281;
						IL_2281:
						num = 394;
						recordset.Close();
						goto IL_2290;
						IL_2290:
						num = 395;
						command.Parameters.Delete("pActID");
						goto IL_22a8;
						IL_22a8:
						num = 396;
						COFarActOrder[num10, COFintNumOps - 1] = (short)(num10 + 1);
						goto IL_22c9;
						IL_22c9:
						num = 397;
						command.ActiveConnection = Common.MyConn;
						goto IL_22dc;
						IL_22dc:
						num = 398;
						command.CommandText = "pqryGetActContTab";
						goto IL_22ef;
						IL_22ef:
						num = 399;
						command.CommandType = CommandTypeEnum.adCmdStoredProc;
						goto IL_22fe;
						IL_22fe:
						num = 400;
						command.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, COFarSelActType[num10, COFintNumOps - 1]));
						goto IL_2339;
						IL_2339:
						num = 401;
						command8 = command;
						parActOrder = Missing.Value;
						parActNW_Route = Missing.Value;
						recordset = command8.Execute(out parActOrder, ref parActNW_Route);
						goto IL_235b;
						IL_235b:
						num = 402;
						if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields[0].Value)))
						{
							goto IL_238f;
						}
						goto IL_24a7;
						IL_238f:
						num = 403;
						if (Operators.ConditionalCompareObjectGreater(recordset.Fields[0].Value, (object)0, false))
						{
							goto IL_23c2;
						}
						goto IL_24a7;
						IL_23c2:
						num = 404;
						pContTab = Conversions.ToShort(recordset.Fields[0].Value);
						goto IL_23e6;
						IL_23e6:
						num = 405;
						Globals_Renamed.intOpIndex = (short)(COFintNumOps - 1);
						goto IL_23fb;
						IL_23fb:
						num = 406;
						Globals_Renamed.intActIndex = num10;
						goto IL_2409;
						IL_2409:
						num = 407;
						pActID = ref COFarSelActType[num10, COFintNumOps - 1];
						parActOrder = COFarContParms;
						parActNW_Route = COFarOpParms;
						ChemStrX.ContDefaults(ref pContTab, ref pActID, ref parActOrder, ref parActNW_Route);
						COFarOpParms = (float[,])parActNW_Route;
						COFarContParms = (float[,,])parActOrder;
						goto IL_245b;
						IL_245b:
						num = 408;
						if (Support.GetItemData((Control)(object)lstOps, lstOps.SelectedIndex) == 102)
						{
							goto IL_2482;
						}
						goto IL_24a7;
						IL_2482:
						num = 409;
						COFarContParms[4, num10, COFintNumOps - 1] = 1f;
						goto IL_24a7;
						IL_24a7:
						num = 413;
						recordset.Close();
						goto IL_24b6;
						IL_24b6:
						num = 414;
						command.Parameters.Delete("pActID");
						goto IL_24ce;
						IL_24ce:
						num = 415;
						num10 = (short)unchecked(num10 + 1);
						goto IL_24dd;
						IL_24eb:
						num = 417;
						recordset = null;
						goto IL_24f5;
						IL_24f5:
						num = 418;
						command = null;
						goto IL_44e3;
						IL_44e3:
						num = 682;
						if (Strings.Len(msfSelOps[0, 0]) != 0)
						{
							goto end_IL_0001_2;
						}
						goto IL_4505;
						IL_4505:
						num = 683;
						msfSelOps.RemoveItem(0);
						goto end_IL_0001_2;
						end_IL_0001:
						break;
					}
				}
			}
			catch (object obj2) when (obj2 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0001_dispatch = 20608;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void lstGSS_DoubleClick(object sender, EventArgs e)
	{
		addOperation();
	}

	private void lstImport_DoubleClick(object sender, EventArgs e)
	{
		addOperation();
	}

	private void cmdGssHelp_Click(object sender, EventArgs e)
	{
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
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
					if (lstGSS.SelectedIndex <= -1)
					{
						goto end_IL_0001;
					}
					if (Operators.ConditionalCompareObjectEqual(arGSS_PDF[lstGSS.SelectedIndex], (object)"", false))
					{
						Interaction.MsgBox((object)"The selected GSS operation does not have a help file associated with it.", (MsgBoxStyle)0, (object)"GSS Help");
						goto end_IL_0001;
					}
					ProjectData.ClearProjectError();
					num2 = 2;
					string text = Conversions.ToString(arGSS_PDF[lstGSS.SelectedIndex]);
					if (Operators.CompareString(Strings.LCase(Strings.Mid(text, 1, 6)), "\\help\\", false) == 0)
					{
						text = Application.StartupPath + text;
					}
					Process.Start(text);
					goto end_IL_0001;
				}
				case 230:
					num = -1;
					switch (num2)
					{
					case 2:
						Interaction.MsgBox((object)("There was a problem displaying the GSS Help file. The error that was encountered was: " + Information.Err().Description), (MsgBoxStyle)16, (object)("GSS Help Error (" + Conversions.ToString(Information.Err().Number) + ")"));
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 230;
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

	private bool importPreviouslySavedAssessment(Connection importConn, string pAssOpID)
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
					ProjectData.ClearProjectError();
					num2 = 2;
					ImportOp(importConn, pAssOpID);
					importRels(importConn, pAssOpID);
					importExps(importConn, pAssOpID);
					flag = true;
					goto end_IL_0001;
				case 128:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						string Eobject = "frmMDUpdOps.vb";
						string Efunction = "importPreviouslySavedAssessment";
						ErrObject val = Information.Err();
						int Enumber = val.Number;
						ErrObject val2 = Information.Err();
						string Edescription = val2.Description;
						bool Econtact = true;
						Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
						val2.Description = Edescription;
						val.Number = Enumber;
						goto end_IL_0001;
					}
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 128;
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

	private void cmdSelectDifferentDB_Click(object sender, EventArgs e)
	{
		openAssessmentDatabaseToImport();
	}

	private bool openAssessmentDatabaseToImport()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num2 = default(int);
		OpenFileDialog val = default(OpenFileDialog);
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
					val = new OpenFileDialog();
					OpenFileDialog val4 = val;
					((FileDialog)val4).Title = "Select the ChemSTEER database from which you wish to import an operation";
					((FileDialog)val4).DefaultExt = "MDB";
					((FileDialog)val4).FileName = "*.mdb";
					((FileDialog)val4).Filter = "Access Databases (*.MDB)|*.MDB";
					val4 = null;
					object obj = ((Form)this).DialogResult;
					obj = ((CommonDialog)val).ShowDialog();
					if (!Operators.ConditionalCompareObjectEqual(obj, (object)(DialogResult)1, false))
					{
						goto end_IL_0001;
					}
					Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
					Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					int num3 = 0;
					if (Common.connGssTab3.State == 1)
					{
						Common.connGssTab3.Close();
					}
					Common.connGssTab3.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + ((FileDialog)val).FileName;
					Common.connGssTab3.Open();
					clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
					recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					recordset.CursorLocation = CursorLocationEnum.adUseClient;
					recordset.Open("SELECT dataVersion, crVersion, crDate FROM Tron", Common.connGssTab3, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
					if ((Information.Err().Number > 0) | recordset.EOF)
					{
						Interaction.MsgBox((object)"Database error, the Tron table is missing or invalid. Please contact Technical Support.", (MsgBoxStyle)16, (object)"Critical Database Error");
						importDataVersion = 1;
					}
					else
					{
						importDataVersion = Conversions.ToInteger(recordset.Fields["dataVersion"].Value);
					}
					recordset.Close();
					recordset.CursorLocation = CursorLocationEnum.adUseClient;
					recordset.Open("SELECT * FROM qryOpen", Common.connGssTab3, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
					if (!recordset.EOF)
					{
						recordset.MoveLast();
						recordset.MoveFirst();
					}
					switch (recordset.RecordCount)
					{
					case 0:
						recordset.Close();
						Interaction.MsgBox((object)"The database you selected does not have any assessments.  Please select another database.", (MsgBoxStyle)64, (object)"Invalid Database");
						goto end_IL_0001;
					case 1:
						Globals_Renamed.gblImportAssessID = Conversions.ToInteger(recordset.Fields[0].Value);
						break;
					default:
					{
						frmMDSelAss defInstance = frmMDSelAss.DefInstance;
						Recordset pRS = recordset;
						string Eobject = "IOp";
						if (defInstance.SetUp(pRS, ref Eobject))
						{
							((Form)frmMDSelAss.DefInstance).ShowDialog();
						}
						else
						{
							((Form)frmMDSelAss.DefInstance).Close();
							Globals_Renamed.gblImportAssessID = 0;
						}
						if (Globals_Renamed.gblImportAssessID != 0)
						{
							break;
						}
						recordset.Close();
						goto end_IL_0001;
					}
					}
					recordset.Close();
					lstImport.Items.Clear();
					clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
					Recordset recordset2 = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					recordset2.CursorLocation = CursorLocationEnum.adUseClient;
					recordset2.Open("SELECT * FROM Operations WHERE AssessID=" + Conversions.ToString(Globals_Renamed.gblImportAssessID), Common.connGssTab3, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
					while (!recordset2.EOF)
					{
						newindex = lstImport.Items.Add(RuntimeHelpers.GetObjectValue(recordset2.Fields["OpName"].Value));
						Support.SetItemData((Control)(object)lstImport, newindex, Conversions.ToInteger(recordset2.Fields["AssOpID"].Value));
						recordset2.MoveNext();
					}
					recordset2.Close();
					recordset2 = null;
					flag = true;
					Cursor.Current = Cursors.WaitCursor;
					goto end_IL_0001;
				}
				case 1084:
					num = -1;
					switch (num2)
					{
					case 2:
						if (Information.Err().Number == 3051)
						{
							Interaction.MsgBox((object)("The assessment you tried to open is in a Read-only database. ChemSTEER requires that the database be updateable.\r\rPlease remove the Read-only attribute by right clicking on the database " + ((FileDialog)val).FileName + " in Windows Explorer and select Properties, then Attributes, and click the Read-only Attribute to remove the Read-only check mark.  Note that it may be necessary to move the database to an updateable media (e.g., local hard drive or network drive); files located on CD-R media are Read-only by definition and are not updateable."), (MsgBoxStyle)64, (object)"Invalid Request");
						}
						else if (Information.Err().Number != 53)
						{
							string Eobject = ((Control)this).Name;
							string Efunction = "openAssessmentDatabaseToImport";
							ErrObject val2 = Information.Err();
							int Enumber = val2.Number;
							ErrObject val3 = Information.Err();
							string Edescription = val3.Description;
							bool Econtact = true;
							Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
							val3.Description = Edescription;
							val2.Number = Enumber;
							((Control)this).Name = Eobject;
						}
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj2) when (obj2 is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0001_dispatch = 1084;
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

	private bool ImportOp(Connection importConn, string pAssOpID)
	{
		int try0001_dispatch = -1;
		int num = default(int);
		Recordset recordset = default(Recordset);
		int num2 = default(int);
		int num3 = default(int);
		short num4 = default(short);
		Recordset recordset2 = default(Recordset);
		Command command = default(Command);
		bool flag = default(bool);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				string Eobject;
				string Efunction;
				ErrObject val;
				int Enumber;
				ErrObject val2;
				string Edescription;
				bool Econtact;
				int num5;
				Guid clsid;
				Command command2;
				object RecordsAffected;
				object Parameters;
				switch (try0001_dispatch)
				{
				default:
					num = 1;
					clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
					recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					goto IL_0023;
				case 4654:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 2:
							break;
						case 1:
							goto IL_1040;
						default:
							goto end_IL_0001;
						}
						goto IL_0fc4;
					}
					IL_0b0a:
					num = 77;
					goto IL_0b0f;
					IL_0b0f:
					num = 78;
					COFarActOrder[Conversions.ToInteger(recordset.Fields["AssActID"].Value), num4] = Conversions.ToShort(Operators.AddObject(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["AssActID"].Value)), (object)1));
					goto IL_0b6a;
					IL_0ab9:
					num = 75;
					COFarActOrder[Conversions.ToInteger(recordset.Fields["AssActID"].Value), num4] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["ActOrder"].Value)));
					goto IL_0b6a;
					IL_0fc4:
					num = 117;
					Eobject = "frmMDUpdOps.vb";
					Efunction = "importOp";
					val = Information.Err();
					Enumber = val.Number;
					val2 = Information.Err();
					Edescription = val2.Description;
					Econtact = true;
					Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
					val2.Description = Edescription;
					val.Number = Enumber;
					goto IL_101d;
					IL_101d:
					num = 118;
					ProjectData.ClearProjectError();
					if (num2 == 0)
					{
						throw ProjectData.CreateProjectError(-2146828268);
					}
					goto IL_1040;
					IL_0b6a:
					num = 80;
					recordset.MoveNext();
					goto IL_0b76;
					IL_1040:
					num5 = num2 + 1;
					num2 = 0;
					switch (num5)
					{
					case 1:
						break;
					case 2:
						goto IL_0023;
					case 3:
						goto IL_0045;
					case 4:
						goto IL_0067;
					case 5:
						goto IL_006f;
					case 6:
						goto IL_007d;
					case 7:
						goto IL_0088;
					case 8:
						goto IL_00d8;
					case 9:
						goto IL_0104;
					case 10:
						goto IL_0131;
					case 11:
						goto IL_015e;
					case 12:
						goto IL_018b;
					case 13:
						goto IL_01b8;
					case 14:
						goto IL_01e5;
					case 15:
						goto IL_0212;
					case 16:
						goto IL_0243;
					case 17:
						goto IL_0274;
					case 18:
						goto IL_02a1;
					case 19:
						goto IL_02d2;
					case 20:
						goto IL_02e0;
					case 21:
						goto IL_0316;
					case 22:
						goto IL_034c;
					case 23:
						goto IL_0382;
					case 24:
						goto IL_03b8;
					case 25:
						goto IL_03e5;
					case 26:
						goto IL_03fe;
					case 27:
						goto IL_042b;
					case 28:
						goto IL_0458;
					case 29:
						goto IL_0471;
					case 30:
						goto IL_049e;
					case 31:
						goto IL_04cb;
					case 32:
						goto IL_04e1;
					case 33:
					case 34:
					case 35:
					case 36:
						goto IL_0511;
					case 37:
						goto IL_0527;
					case 38:
					case 39:
						goto IL_0555;
					case 40:
						goto IL_0560;
					case 41:
						goto IL_056f;
					case 42:
						goto IL_0598;
					case 43:
						goto IL_05ae;
					case 44:
						goto IL_05be;
					case 45:
						goto IL_05ce;
					case 48:
						goto IL_05df;
					case 49:
						goto IL_0624;
					case 50:
						goto IL_065c;
					case 51:
						goto IL_067a;
					case 52:
						goto IL_068f;
					case 53:
						goto IL_06c2;
					case 54:
						goto IL_06cd;
					case 46:
					case 47:
					case 55:
						goto IL_06d9;
					case 56:
					case 57:
						goto IL_06f0;
					case 58:
						goto IL_06fb;
					case 61:
						goto IL_0729;
					case 62:
						goto IL_0773;
					case 63:
						goto IL_07c2;
					case 64:
						goto IL_0811;
					case 65:
						goto IL_0860;
					case 66:
						goto IL_08af;
					case 67:
						goto IL_08fe;
					case 68:
						goto IL_094d;
					case 69:
						goto IL_0967;
					case 70:
						goto IL_09b7;
					case 71:
						goto IL_0a07;
					case 72:
						goto IL_0a57;
					case 73:
					case 74:
						goto IL_0aa2;
					case 75:
						goto IL_0ab9;
					case 77:
						goto IL_0b0a;
					case 78:
						goto IL_0b0f;
					case 76:
					case 79:
					case 80:
						goto IL_0b6a;
					case 59:
					case 60:
					case 81:
						goto IL_0b76;
					case 82:
						goto IL_0b8c;
					case 83:
						goto IL_0b97;
					case 86:
						goto IL_0bc5;
					case 87:
						goto IL_0bf7;
					case 88:
						goto IL_0c46;
					case 90:
						goto IL_0c9a;
					case 91:
						goto IL_0c9f;
					case 92:
						goto IL_0cfd;
					case 89:
					case 93:
					case 94:
						goto IL_0d5c;
					case 84:
					case 85:
					case 95:
						goto IL_0d68;
					case 96:
						goto IL_0d7e;
					case 97:
						goto IL_0d89;
					case 100:
						goto IL_0db7;
					case 101:
						goto IL_0e20;
					case 102:
						goto IL_0e89;
					case 98:
					case 99:
					case 103:
						goto IL_0e95;
					case 104:
						goto IL_0eab;
					case 105:
						goto IL_0eb6;
					case 108:
						goto IL_0ee4;
					case 109:
						goto IL_0f33;
					case 110:
						goto IL_0f7d;
					case 106:
					case 107:
					case 111:
						goto IL_0f89;
					case 112:
						goto IL_0f9f;
					case 113:
						goto IL_0faa;
					case 114:
						goto IL_0fb0;
					case 115:
						goto IL_0fb6;
					case 117:
						goto IL_0fc4;
					case 118:
						goto IL_101d;
					default:
						goto end_IL_0001;
					case 116:
					case 119:
						goto end_IL_0001_2;
					}
					goto default;
					IL_0023:
					num = 2;
					clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
					recordset2 = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					goto IL_0045;
					IL_0045:
					num = 3;
					clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
					command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					goto IL_0067;
					IL_0067:
					ProjectData.ClearProjectError();
					num3 = 2;
					goto IL_006f;
					IL_006f:
					num = 5;
					num4 = checked((short)(COFintNumOps - 1));
					goto IL_007d;
					IL_007d:
					num = 6;
					recordset.CursorLocation = CursorLocationEnum.adUseClient;
					goto IL_0088;
					IL_0088:
					num = 7;
					recordset.Open("SELECT * FROM Operations WHERE AssessID=" + Conversions.ToString(Globals_Renamed.gblImportAssessID) + " AND AssOpID=" + pAssOpID + " ORDER BY AssOpID", importConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
					goto IL_00d8;
					IL_00d8:
					num = 8;
					COFarPDesc[num4] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["ProcessDesc"].Value));
					goto IL_0104;
					IL_0104:
					num = 9;
					COFarPSInto1[num4] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["PSInto"].Value));
					goto IL_0131;
					IL_0131:
					num = 10;
					COFarPSInto2[num4] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["PSIntoOther"].Value));
					goto IL_015e;
					IL_015e:
					num = 11;
					COFarPSOut1[num4] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["PSOut"].Value));
					goto IL_018b;
					IL_018b:
					num = 12;
					COFarPSOut2[num4] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["PSOutOther"].Value));
					goto IL_01b8;
					IL_01b8:
					num = 13;
					COFarPSIn1[num4] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["PSIn"].Value));
					goto IL_01e5;
					IL_01e5:
					num = 14;
					COFarPSIn2[num4] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["PSInOther"].Value));
					goto IL_0212;
					IL_0212:
					num = 15;
					COFarOpBorC[num4] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["OpType"].Value)));
					goto IL_0243;
					IL_0243:
					num = 16;
					COFarOpIoE[num4] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["IoE"].Value)));
					goto IL_0274;
					IL_0274:
					num = 17;
					COFarOpName[num4] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["OpName"].Value));
					goto IL_02a1;
					IL_02a1:
					num = 18;
					COFarOpType[num4] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["OpID"].Value)));
					goto IL_02d2;
					IL_02d2:
					num = 19;
					COFarOpNeedsMassBalance[num4] = 1;
					goto IL_02e0;
					IL_02e0:
					num = 20;
					COFarOpMassBalDisc[0, num4] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["MassBalDisc1"].Value)));
					goto IL_0316;
					IL_0316:
					num = 21;
					COFarOpMassBalDisc[1, num4] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["MassBalDisc2"].Value)));
					goto IL_034c;
					IL_034c:
					num = 22;
					COFarMiscOpParms[0, num4] = Conversions.ToSingle(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["OpNumWorkers"].Value)));
					goto IL_0382;
					IL_0382:
					num = 23;
					COFarMiscOpParms[1, num4] = Conversions.ToSingle(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["NumWorkersExpDaysPerYear"].Value)));
					goto IL_03b8;
					IL_03b8:
					num = 24;
					COFarBasis[num4] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["Basis"].Value));
					goto IL_03e5;
					IL_03e5:
					num = 25;
					if (importDataVersion >= 5)
					{
						goto IL_03fe;
					}
					goto IL_0511;
					IL_03fe:
					num = 26;
					COFarWaterBasis[num4] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["WaterRelBasis"].Value));
					goto IL_042b;
					IL_042b:
					num = 27;
					COFarInhalationBasis[num4] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["InhExpBasis"].Value));
					goto IL_0458;
					IL_0458:
					num = 28;
					if (importDataVersion >= 6)
					{
						goto IL_0471;
					}
					goto IL_0511;
					IL_0471:
					num = 29;
					COFarRelAddNotes[num4] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["AddNotesRelSummary"].Value));
					goto IL_049e;
					IL_049e:
					num = 30;
					COFarExpAddNotes[num4] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["AddNotesExpSummary"].Value));
					goto IL_04cb;
					IL_04cb:
					num = 31;
					if (importDataVersion >= 8)
					{
						goto IL_04e1;
					}
					goto IL_0511;
					IL_04e1:
					num = 32;
					COFarDermalBasis[num4] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["DerExpBasis"].Value));
					goto IL_0511;
					IL_0511:
					num = 36;
					if (Globals_Renamed.gblDataVersion >= 9)
					{
						goto IL_0527;
					}
					goto IL_0555;
					IL_0527:
					num = 37;
					COFarOpNumWorkersBasis[num4] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["NWbasis"].Value));
					goto IL_0555;
					IL_0555:
					num = 39;
					recordset.Close();
					goto IL_0560;
					IL_0560:
					num = 40;
					COFarOpOrder[num4] = num4;
					goto IL_056f;
					IL_056f:
					num = 41;
					recordset.Open("SELECT * FROM OpNaics WHERE AssessID=" + Conversions.ToString(Globals_Renamed.gblImportAssessID) + " AND AssOpID=" + pAssOpID, importConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
					goto IL_0598;
					IL_0598:
					num = 42;
					if (!recordset.EOF)
					{
						goto IL_05ae;
					}
					goto IL_06f0;
					IL_05ae:
					num = 43;
					command.ActiveConnection = Common.MyConn;
					goto IL_05be;
					IL_05be:
					num = 44;
					command.CommandText = "pqryGetNaicsDesc";
					goto IL_05ce;
					IL_05ce:
					num = 45;
					command.CommandType = CommandTypeEnum.adCmdStoredProc;
					goto IL_06d9;
					IL_06d9:
					num = 47;
					if (!recordset.EOF)
					{
						goto IL_05df;
					}
					goto IL_06f0;
					IL_05df:
					num = 48;
					COFarNaics1[Conversions.ToInteger(recordset.Fields["NaicsIndex"].Value), num4] = Conversions.ToString(recordset.Fields["NAICS"].Value);
					goto IL_0624;
					IL_0624:
					num = 49;
					command.Parameters.Append(command.CreateParameter("pID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, RuntimeHelpers.GetObjectValue(recordset.Fields["NAICS"].Value)));
					goto IL_065c;
					IL_065c:
					num = 50;
					command2 = command;
					RecordsAffected = Missing.Value;
					Parameters = Missing.Value;
					recordset2 = command2.Execute(out RecordsAffected, ref Parameters);
					goto IL_067a;
					IL_067a:
					num = 51;
					command.Parameters.Delete("pID");
					goto IL_068f;
					IL_068f:
					num = 52;
					COFarNaics2[num4, checked(COFintNumOps - 1)] = Conversions.ToString(recordset2.Fields["NaicsDesc"].Value);
					goto IL_06c2;
					IL_06c2:
					num = 53;
					recordset2.Close();
					goto IL_06cd;
					IL_06cd:
					num = 54;
					recordset.MoveNext();
					goto IL_06d9;
					IL_06f0:
					num = 57;
					recordset.Close();
					goto IL_06fb;
					IL_06fb:
					num = 58;
					recordset.Open("SELECT * FROM Activities WHERE AssessID=" + Conversions.ToString(Globals_Renamed.gblImportAssessID) + " AND AssOpID=" + pAssOpID, importConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
					goto IL_0b76;
					IL_0b76:
					num = 60;
					if (!recordset.EOF)
					{
						goto IL_0729;
					}
					goto IL_0b8c;
					IL_0b8c:
					num = 82;
					recordset.Close();
					goto IL_0b97;
					IL_0b97:
					num = 83;
					recordset.Open("SELECT * FROM OpParms WHERE AssessID=" + Conversions.ToString(Globals_Renamed.gblImportAssessID) + " AND AssOpID=" + pAssOpID, importConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
					goto IL_0d68;
					IL_0d68:
					num = 85;
					if (!recordset.EOF)
					{
						goto IL_0bc5;
					}
					goto IL_0d7e;
					IL_0d7e:
					num = 96;
					recordset.Close();
					goto IL_0d89;
					IL_0d89:
					num = 97;
					recordset.Open("SELECT * FROM ActContParms WHERE AssessID=" + Conversions.ToString(Globals_Renamed.gblImportAssessID) + " AND AssOpID=" + pAssOpID, importConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
					goto IL_0e95;
					IL_0e95:
					num = 99;
					if (!recordset.EOF)
					{
						goto IL_0db7;
					}
					goto IL_0eab;
					IL_0eab:
					num = 104;
					recordset.Close();
					goto IL_0eb6;
					IL_0eb6:
					num = 105;
					recordset.Open("SELECT * FROM GSSOptions WHERE AssessID=" + Conversions.ToString(Globals_Renamed.gblImportAssessID) + " AND AssOpID=" + pAssOpID, importConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
					goto IL_0f89;
					IL_0f89:
					num = 107;
					if (!recordset.EOF)
					{
						goto IL_0ee4;
					}
					goto IL_0f9f;
					IL_0f9f:
					num = 112;
					recordset.Close();
					goto IL_0faa;
					IL_0faa:
					num = 113;
					recordset = null;
					goto IL_0fb0;
					IL_0fb0:
					num = 114;
					recordset2 = null;
					goto IL_0fb6;
					IL_0fb6:
					num = 115;
					flag = true;
					goto end_IL_0001_2;
					IL_0ee4:
					num = 108;
					COFarGssOptions[Conversions.ToInteger(recordset.Fields["ParmID"].Value), num4] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["OptionValue"].Value)));
					goto IL_0f33;
					IL_0f33:
					num = 109;
					COFarGssOther[Conversions.ToInteger(recordset.Fields["ParmID"].Value), num4] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["Other"].Value));
					goto IL_0f7d;
					IL_0f7d:
					num = 110;
					recordset.MoveNext();
					goto IL_0f89;
					IL_0db7:
					num = 100;
					COFarContParms[Conversions.ToInteger(recordset.Fields["ParmID"].Value), Conversions.ToInteger(recordset.Fields["AssActID"].Value), num4] = Conversions.ToSingle(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["ParmValue"].Value)));
					goto IL_0e20;
					IL_0e20:
					num = 101;
					COFarContParmTypes[Conversions.ToInteger(recordset.Fields["ParmID"].Value), Conversions.ToInteger(recordset.Fields["AssActID"].Value), num4] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["ParmType"].Value)));
					goto IL_0e89;
					IL_0e89:
					num = 102;
					recordset.MoveNext();
					goto IL_0e95;
					IL_0bc5:
					num = 86;
					if (Operators.ConditionalCompareObjectLess(recordset.Fields["ParmID"].Value, (object)1000, false))
					{
						goto IL_0bf7;
					}
					goto IL_0c9a;
					IL_0bf7:
					num = 87;
					COFarOpParms[Conversions.ToInteger(recordset.Fields["ParmID"].Value), num4] = Conversions.ToSingle(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["ParmValue"].Value)));
					goto IL_0c46;
					IL_0c46:
					num = 88;
					COFarOpParmsType[Conversions.ToInteger(recordset.Fields["ParmID"].Value), num4] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["ParmType"].Value)));
					goto IL_0d5c;
					IL_0c9a:
					num = 90;
					goto IL_0c9f;
					IL_0c9f:
					num = 91;
					COFarOpSP[Conversions.ToInteger(Operators.SubtractObject(recordset.Fields["ParmID"].Value, (object)1000)), num4] = Conversions.ToSingle(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["ParmValue"].Value)));
					goto IL_0cfd;
					IL_0cfd:
					num = 92;
					COFarOpSPType[Conversions.ToInteger(Operators.SubtractObject(recordset.Fields["ParmID"].Value, (object)1000)), num4] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["ParmType"].Value)));
					goto IL_0d5c;
					IL_0d5c:
					num = 94;
					recordset.MoveNext();
					goto IL_0d68;
					IL_0729:
					num = 61;
					COFarSelActs[Conversions.ToInteger(recordset.Fields["AssActID"].Value), num4] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["ActName"].Value));
					goto IL_0773;
					IL_0773:
					num = 62;
					COFarSelActType[Conversions.ToInteger(recordset.Fields["AssActID"].Value), num4] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["ActID"].Value)));
					goto IL_07c2;
					IL_07c2:
					num = 63;
					COFarSelActRa[Conversions.ToInteger(recordset.Fields["AssActID"].Value), num4] = Conversions.ToBoolean(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["DoRel"].Value)));
					goto IL_0811;
					IL_0811:
					num = 64;
					COFarSelActEa[Conversions.ToInteger(recordset.Fields["AssActID"].Value), num4] = Conversions.ToBoolean(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["DoExp"].Value)));
					goto IL_0860;
					IL_0860:
					num = 65;
					COFarSelActRaDMP[Conversions.ToInteger(recordset.Fields["AssActID"].Value), num4] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["DidRel"].Value)));
					goto IL_08af;
					IL_08af:
					num = 66;
					COFarSelActEaDMP[Conversions.ToInteger(recordset.Fields["AssActID"].Value), num4] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["DidExp"].Value)));
					goto IL_08fe;
					IL_08fe:
					num = 67;
					COFarSelActVolatile[Conversions.ToInteger(recordset.Fields["AssActID"].Value), num4] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["Volatile"].Value)));
					goto IL_094d;
					IL_094d:
					num = 68;
					if (importDataVersion >= 9)
					{
						goto IL_0967;
					}
					goto IL_0aa2;
					IL_0967:
					num = 69;
					COFarActNumWorkers[0, Conversions.ToInteger(recordset.Fields["AssActID"].Value), num4] = Conversions.ToInteger(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["NW_NS"].Value)));
					goto IL_09b7;
					IL_09b7:
					num = 70;
					COFarActNumWorkers[1, Conversions.ToInteger(recordset.Fields["AssActID"].Value), num4] = Conversions.ToInteger(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["NW_NWexp"].Value)));
					goto IL_0a07;
					IL_0a07:
					num = 71;
					COFarActNumWorkers[2, Conversions.ToInteger(recordset.Fields["AssActID"].Value), num4] = Conversions.ToInteger(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["NW_NSxNWexp"].Value)));
					goto IL_0a57;
					IL_0a57:
					num = 72;
					COFarActNW_Route[Conversions.ToInteger(recordset.Fields["AssActID"].Value), num4] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["NW_Route"].Value));
					goto IL_0aa2;
					IL_0aa2:
					num = 74;
					if (importDataVersion >= 11)
					{
						goto IL_0ab9;
					}
					goto IL_0b0a;
					end_IL_0001:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 4654;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_2:
			break;
		}
		bool result = flag;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private bool importRels(Connection importConn, string pAssOpID)
	{
		int try0001_dispatch = -1;
		int num = default(int);
		Recordset recordset2 = default(Recordset);
		int num2 = default(int);
		int num3 = default(int);
		Recordset recordset = default(Recordset);
		bool flag = default(bool);
		string source = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					string Eobject;
					string Efunction;
					ErrObject val;
					int Enumber;
					ErrObject val2;
					string Edescription;
					bool Econtact;
					int num4;
					Guid clsid;
					switch (try0001_dispatch)
					{
					default:
						num = 1;
						clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
						recordset2 = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						goto IL_0023;
					case 3187:
						{
							num2 = num;
							switch ((num3 <= -2) ? 1 : num3)
							{
							case 2:
								break;
							case 1:
								goto IL_0ab9;
							default:
								goto end_IL_0001;
							}
							goto IL_0a3d;
						}
						IL_05a8:
						num = 64;
						COFarRelModParmsT[Conversions.ToInteger(recordset.Fields["OutputID"].Value), Conversions.ToInteger(recordset.Fields["ParmID"].Value), COFintNumRelModels] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["ParmType"].Value)));
						goto IL_0615;
						IL_0615:
						num = 65;
						COFarRelModParmsVC[Conversions.ToInteger(recordset.Fields["OutputID"].Value), Conversions.ToInteger(recordset.Fields["ParmID"].Value), COFintNumRelModels] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["ParmVC"].Value)));
						goto IL_0682;
						IL_053b:
						num = 63;
						COFarRelModParmsV[Conversions.ToInteger(recordset.Fields["OutputID"].Value), Conversions.ToInteger(recordset.Fields["ParmID"].Value), COFintNumRelModels] = Conversions.ToSingle(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["ParmValue"].Value)));
						goto IL_05a8;
						IL_0a3d:
						num = 104;
						Eobject = "frmMDUpdOps.vb";
						Efunction = "ImportRel";
						val = Information.Err();
						Enumber = val.Number;
						val2 = Information.Err();
						Edescription = val2.Description;
						Econtact = true;
						Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
						val2.Description = Edescription;
						val.Number = Enumber;
						goto IL_0a96;
						IL_0a96:
						num = 105;
						ProjectData.ClearProjectError();
						if (num2 == 0)
						{
							throw ProjectData.CreateProjectError(-2146828268);
						}
						goto IL_0ab9;
						IL_0682:
						num = 66;
						recordset.MoveNext();
						goto IL_068e;
						IL_0ab9:
						num4 = unchecked(num2 + 1);
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0023;
						case 3:
							goto IL_0045;
						case 4:
							goto IL_004d;
						case 5:
						case 7:
							goto IL_007a;
						case 8:
							goto IL_0085;
						case 11:
							goto IL_00b2;
						case 12:
							goto IL_0106;
						case 13:
						case 15:
							goto IL_0134;
						case 16:
						case 18:
							goto IL_0163;
						case 19:
						case 21:
							goto IL_0192;
						case 22:
						case 24:
							goto IL_01c1;
						case 25:
						case 27:
							goto IL_01f1;
						case 28:
						case 30:
							goto IL_021f;
						case 31:
						case 33:
							goto IL_024d;
						case 34:
						case 36:
							goto IL_027b;
						case 37:
						case 39:
							goto IL_02aa;
						case 40:
						case 42:
							goto IL_02d9;
						case 43:
						case 45:
							goto IL_030d;
						case 46:
						case 48:
							goto IL_0341;
						case 49:
						case 51:
							goto IL_0375;
						case 52:
							goto IL_03aa;
						case 53:
							goto IL_03db;
						case 54:
							goto IL_040c;
						case 55:
							goto IL_041e;
						case 56:
							goto IL_0458;
						case 57:
							goto IL_048d;
						case 58:
							goto IL_04c7;
						case 59:
							goto IL_04fc;
						case 60:
							goto IL_0508;
						case 63:
							goto IL_053b;
						case 64:
							goto IL_05a8;
						case 65:
							goto IL_0615;
						case 66:
							goto IL_0682;
						case 61:
						case 62:
						case 67:
							goto IL_068e;
						case 68:
							goto IL_06a4;
						case 69:
							goto IL_06af;
						case 70:
							goto IL_06c8;
						case 71:
							goto IL_06d4;
						case 72:
							goto IL_075f;
						case 73:
							goto IL_0770;
						case 74:
							goto IL_0780;
						case 76:
							goto IL_07a1;
						case 79:
							goto IL_07a8;
						case 80:
							goto IL_07fb;
						case 77:
						case 78:
						case 81:
							goto IL_0807;
						case 82:
							goto IL_081a;
						case 85:
							goto IL_082b;
						case 86:
							goto IL_0830;
						case 87:
							goto IL_086a;
						case 88:
							goto IL_08a5;
						case 89:
							goto IL_08df;
						case 90:
							goto IL_091a;
						case 91:
							goto IL_0955;
						case 92:
							goto IL_0990;
						case 93:
							goto IL_09a6;
						case 75:
						case 83:
						case 84:
						case 94:
						case 95:
						case 96:
							goto IL_09e3;
						case 97:
							goto IL_09ee;
						case 9:
						case 10:
						case 98:
							goto IL_0a02;
						case 99:
							goto IL_0a18;
						case 100:
							goto IL_0a23;
						case 101:
							goto IL_0a29;
						case 102:
							goto IL_0a2f;
						case 104:
							goto IL_0a3d;
						case 105:
							goto IL_0a96;
						default:
							goto end_IL_0001;
						case 103:
						case 106:
							goto end_IL_0001_2;
						}
						goto default;
						IL_0023:
						num = 2;
						clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
						recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						goto IL_0045;
						IL_0045:
						ProjectData.ClearProjectError();
						num3 = 2;
						goto IL_004d;
						IL_004d:
						num = 4;
						Globals_Renamed.arRelModels = (short[,,])Utils.CopyArray((Array)Globals_Renamed.arRelModels, (Array)new short[11, 26, COFintNumOps + 1]);
						goto IL_007a;
						IL_007a:
						num = 7;
						recordset2.CursorLocation = CursorLocationEnum.adUseClient;
						goto IL_0085;
						IL_0085:
						num = 8;
						recordset2.Open("SELECT * FROM ActRelModels WHERE AssessID=" + Conversions.ToString(Globals_Renamed.gblImportAssessID) + " AND AssOpID=" + pAssOpID, importConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
						goto IL_0a02;
						IL_0a02:
						num = 10;
						if (!recordset2.EOF)
						{
							goto IL_00b2;
						}
						goto IL_0a18;
						IL_0a18:
						num = 99;
						recordset2.Close();
						goto IL_0a23;
						IL_0a23:
						num = 100;
						recordset = null;
						goto IL_0a29;
						IL_0a29:
						num = 101;
						recordset2 = null;
						goto IL_0a2f;
						IL_0a2f:
						num = 102;
						flag = true;
						goto end_IL_0001_2;
						IL_00b2:
						num = 11;
						COFarRelModels[Conversions.ToInteger(recordset2.Fields["RelModID"].Value), Conversions.ToInteger(recordset2.Fields["AssActID"].Value), COFintNumOps - 1] = (short)(COFintNumRelModels + 1);
						goto IL_0106;
						IL_0106:
						num = 12;
						COFarRelModType = (short[])Utils.CopyArray((Array)COFarRelModType, (Array)new short[COFintNumRelModels + 1 + 1]);
						goto IL_0134;
						IL_0134:
						num = 15;
						COFarRelModDRR = (float[,])Utils.CopyArray((Array)COFarRelModDRR, (Array)new float[3, COFintNumRelModels + 1 + 1]);
						goto IL_0163;
						IL_0163:
						num = 18;
						COFarRelModARR = (float[,])Utils.CopyArray((Array)COFarRelModARR, (Array)new float[3, COFintNumRelModels + 1 + 1]);
						goto IL_0192;
						IL_0192:
						num = 21;
						COFarRelModDOR = (short[,])Utils.CopyArray((Array)COFarRelModDOR, (Array)new short[3, COFintNumRelModels + 1 + 1]);
						goto IL_01c1;
						IL_01c1:
						num = 24;
						COFarRelModMedia = (float[,])Utils.CopyArray((Array)COFarRelModMedia, (Array)new float[19, COFintNumRelModels + 1 + 1]);
						goto IL_01f1;
						IL_01f1:
						num = 27;
						COFarRelModBasis = (string[])Utils.CopyArray((Array)COFarRelModBasis, (Array)new string[COFintNumRelModels + 1 + 1]);
						goto IL_021f;
						IL_021f:
						num = 30;
						COFarRelModNAICS = (string[])Utils.CopyArray((Array)COFarRelModNAICS, (Array)new string[COFintNumRelModels + 1 + 1]);
						goto IL_024d;
						IL_024d:
						num = 33;
						COFarRelModStatus = (short[])Utils.CopyArray((Array)COFarRelModStatus, (Array)new short[COFintNumRelModels + 1 + 1]);
						goto IL_027b;
						IL_027b:
						num = 36;
						COFarRelModOutputOn = (short[,])Utils.CopyArray((Array)COFarRelModOutputOn, (Array)new short[3, COFintNumRelModels + 1 + 1]);
						goto IL_02aa;
						IL_02aa:
						num = 39;
						COFarRelModChar = (string[,])Utils.CopyArray((Array)COFarRelModChar, (Array)new string[3, COFintNumRelModels + 1 + 1]);
						goto IL_02d9;
						IL_02d9:
						num = 42;
						COFarRelModParmsV = (float[,,])Utils.CopyArray((Array)COFarRelModParmsV, (Array)new float[3, 163, COFintNumRelModels + 1 + 1]);
						goto IL_030d;
						IL_030d:
						num = 45;
						COFarRelModParmsT = (short[,,])Utils.CopyArray((Array)COFarRelModParmsT, (Array)new short[3, 163, COFintNumRelModels + 1 + 1]);
						goto IL_0341;
						IL_0341:
						num = 48;
						COFarRelModParmsVC = (short[,,])Utils.CopyArray((Array)COFarRelModParmsVC, (Array)new short[3, 163, COFintNumRelModels + 1 + 1]);
						goto IL_0375;
						IL_0375:
						num = 51;
						COFarRelModType[COFintNumRelModels] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["ModelID"].Value)));
						goto IL_03aa;
						IL_03aa:
						num = 52;
						COFarRelModBasis[COFintNumRelModels] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["Basis"].Value));
						goto IL_03db;
						IL_03db:
						num = 53;
						COFarRelModNAICS[COFintNumRelModels] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["NAICS"].Value));
						goto IL_040c;
						IL_040c:
						num = 54;
						COFarRelModStatus[COFintNumRelModels] = 0;
						goto IL_041e;
						IL_041e:
						num = 55;
						COFarRelModOutputOn[0, COFintNumRelModels] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["OutputOn1"].Value)));
						goto IL_0458;
						IL_0458:
						num = 56;
						COFarRelModChar[0, COFintNumRelModels] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["Char1"].Value));
						goto IL_048d;
						IL_048d:
						num = 57;
						COFarRelModOutputOn[1, COFintNumRelModels] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["OutputOn2"].Value)));
						goto IL_04c7;
						IL_04c7:
						num = 58;
						COFarRelModChar[1, COFintNumRelModels] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["Char2"].Value));
						goto IL_04fc;
						IL_04fc:
						num = 59;
						recordset.CursorLocation = CursorLocationEnum.adUseClient;
						goto IL_0508;
						IL_0508:
						num = 60;
						recordset.Open(Operators.ConcatenateObject((object)"SELECT * FROM ActRelModParms WHERE RelParmsAN=", recordset2.Fields["RelParmsAN"].Value), importConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
						goto IL_068e;
						IL_068e:
						num = 62;
						if (!recordset.EOF)
						{
							goto IL_053b;
						}
						goto IL_06a4;
						IL_06a4:
						num = 68;
						recordset.Close();
						goto IL_06af;
						IL_06af:
						num = 69;
						if (importDataVersion >= 3)
						{
							goto IL_06c8;
						}
						goto IL_082b;
						IL_06c8:
						num = 70;
						recordset.CursorLocation = CursorLocationEnum.adUseClient;
						goto IL_06d4;
						IL_06d4:
						num = 71;
						source = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat("SELECT MediaID, Pct FROM ActRelModMedia WHERE AssessID=" + Conversions.ToString(Globals_Renamed.gblImportAssessID), " AND AssOpID="), recordset2.Fields["AssOpID"].Value), (object)" AND AssActID="), recordset2.Fields["AssActID"].Value), (object)" AND RelModID="), recordset2.Fields["RelModID"].Value));
						goto IL_075f;
						IL_075f:
						num = 72;
						recordset.Open(source, importConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
						goto IL_0770;
						IL_0770:
						num = 73;
						if (recordset.EOF)
						{
							goto IL_0780;
						}
						goto IL_07a1;
						IL_0780:
						num = 74;
						COFarRelModMedia[13, COFintNumRelModels] = 100f;
						goto IL_09e3;
						IL_07a1:
						num = 76;
						goto IL_0807;
						IL_0807:
						num = 78;
						if (!recordset.EOF)
						{
							goto IL_07a8;
						}
						goto IL_081a;
						IL_081a:
						num = 82;
						recordset.Close();
						goto IL_09e3;
						IL_07a8:
						num = 79;
						COFarRelModMedia[Conversions.ToInteger(recordset.Fields["MediaID"].Value), COFintNumRelModels] = Conversions.ToSingle(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["Pct"].Value)));
						goto IL_07fb;
						IL_07fb:
						num = 80;
						recordset.MoveNext();
						goto IL_0807;
						IL_082b:
						num = 85;
						goto IL_0830;
						IL_0830:
						num = 86;
						COFarRelModMedia[0, COFintNumRelModels] = Conversions.ToSingle(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["AirPct"].Value)));
						goto IL_086a;
						IL_086a:
						num = 87;
						COFarRelModMedia[13, COFintNumRelModels] = Conversions.ToSingle(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["WaterPct"].Value)));
						goto IL_08a5;
						IL_08a5:
						num = 88;
						COFarRelModMedia[7, COFintNumRelModels] = Conversions.ToSingle(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["LFPct"].Value)));
						goto IL_08df;
						IL_08df:
						num = 89;
						COFarRelModMedia[11, COFintNumRelModels] = Conversions.ToSingle(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["IncPct"].Value)));
						goto IL_091a;
						IL_091a:
						num = 90;
						COFarRelModMedia[16, COFintNumRelModels] = Conversions.ToSingle(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["OtherPct"].Value)));
						goto IL_0955;
						IL_0955:
						num = 91;
						COFarRelModMedia[15, COFintNumRelModels] = Conversions.ToSingle(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["DestPct"].Value)));
						goto IL_0990;
						IL_0990:
						num = 92;
						if (importDataVersion >= 2)
						{
							goto IL_09a6;
						}
						goto IL_09e3;
						IL_09a6:
						num = 93;
						COFarRelModMedia[14, COFintNumRelModels] = Conversions.ToSingle(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["DeepPct"].Value)));
						goto IL_09e3;
						IL_09e3:
						num = 96;
						recordset2.MoveNext();
						goto IL_09ee;
						IL_09ee:
						num = 97;
						COFintNumRelModels++;
						goto IL_0a02;
						end_IL_0001:
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 3187;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_2:
			break;
		}
		bool result = flag;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private bool importExps(Connection importConn, string pAssOpID)
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
						clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
						Recordset recordset2 = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						ProjectData.ClearProjectError();
						num2 = 2;
						recordset.CursorLocation = CursorLocationEnum.adUseClient;
						recordset2.CursorLocation = CursorLocationEnum.adUseClient;
						COFarExpModels = (short[,,])Utils.CopyArray((Array)COFarExpModels, (Array)new short[3, 26, COFintNumOps + 1]);
						recordset.Open("SELECT * FROM ActExpModels WHERE AssessID=" + Conversions.ToString(Globals_Renamed.gblImportAssessID) + " AND AssOpID=" + pAssOpID, importConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
						while (!recordset.EOF)
						{
							COFarExpModels[Conversions.ToInteger(recordset.Fields["ExplModID"].Value), Conversions.ToInteger(recordset.Fields["AssActID"].Value), COFintNumOps - 1] = (short)(COFintNumExpModels + 1);
							COFarExpModType = (short[])Utils.CopyArray((Array)COFarExpModType, (Array)new short[COFintNumExpModels + 1 + 1]);
							COFarExpModEst = (float[,,])Utils.CopyArray((Array)COFarExpModEst, (Array)new float[3, 19, COFintNumExpModels + 1 + 1]);
							COFarExpModOutputOn = (short[,])Utils.CopyArray((Array)COFarExpModOutputOn, (Array)new short[3, COFintNumExpModels + 1 + 1]);
							COFarExpModChar = (string[,])Utils.CopyArray((Array)COFarExpModChar, (Array)new string[3, COFintNumExpModels + 1 + 1]);
							COFarExpModBasis = (string[])Utils.CopyArray((Array)COFarExpModBasis, (Array)new string[COFintNumExpModels + 1 + 1]);
							COFarExpModChmSt = (short[])Utils.CopyArray((Array)COFarExpModChmSt, (Array)new short[COFintNumExpModels + 1 + 1]);
							COFarExpModUncertainty = (short[])Utils.CopyArray((Array)COFarExpModUncertainty, (Array)new short[COFintNumExpModels + 1 + 1]);
							COFarExpModStatus = (short[])Utils.CopyArray((Array)COFarExpModStatus, (Array)new short[COFintNumExpModels + 1 + 1]);
							COFarExpModParmsV = (float[,,])Utils.CopyArray((Array)COFarExpModParmsV, (Array)new float[3, 163, COFintNumExpModels + 1 + 1]);
							COFarExpModParmsT = (short[,,])Utils.CopyArray((Array)COFarExpModParmsT, (Array)new short[3, 163, COFintNumExpModels + 1 + 1]);
							COFarExpModParmsVC = (short[,,])Utils.CopyArray((Array)COFarExpModParmsVC, (Array)new short[3, 163, COFintNumExpModels + 1 + 1]);
							COFarExpModInhRC = (string[,])Utils.CopyArray((Array)COFarExpModInhRC, (Array)new string[5, COFintNumExpModels + 1 + 1]);
							COFarExpModType[COFintNumExpModels] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["ModelID"].Value)));
							COFarExpModOutputOn[0, COFintNumExpModels] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["OutputOn1"].Value)));
							COFarExpModOutputOn[1, COFintNumExpModels] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["OutputOn2"].Value)));
							COFarExpModChar[0, COFintNumExpModels] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["Char1"].Value));
							COFarExpModChar[1, COFintNumExpModels] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["Char2"].Value));
							COFarExpModBasis[COFintNumExpModels] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["Basis"].Value));
							COFarExpModChmSt[COFintNumExpModels] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["ChemStateID"].Value)));
							if (importDataVersion >= 5)
							{
								COFarExpModUncertainty[COFintNumExpModels] = Conversions.ToShort(Common.MyNullCheck1(RuntimeHelpers.GetObjectValue(recordset.Fields["inhUncertainty"].Value)));
							}
							else
							{
								COFarExpModUncertainty[COFintNumExpModels] = 1;
							}
							COFarExpModStatus[COFintNumExpModels] = 0;
							if (importDataVersion >= 12)
							{
								COFarExpModInhRC[0, COFintNumExpModels] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["InhClass"].Value));
								COFarExpModInhRC[1, COFintNumExpModels] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["InhClassNotes"].Value));
								if (recordset.Fields["InhClassExpLevel"].Value == DBNull.Value)
								{
									COFarExpModInhRC[2, COFintNumExpModels] = "";
								}
								else
								{
									COFarExpModInhRC[2, COFintNumExpModels] = Conversions.ToString(Interaction.IIf(Conversions.ToDouble(Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["InhClassExpLevel"].Value))) == 1.0, (object)"Yes", (object)"No"));
								}
								if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["InhClassHazRating"].Value)))
								{
									COFarExpModInhRC[3, COFintNumExpModels] = "";
									COFarExpModInhRC[4, COFintNumExpModels] = "";
								}
								else
								{
									COFarExpModInhRC[3, COFintNumExpModels] = Conversions.ToString(Interaction.IIf(Conversions.ToDouble(Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["InhClassHazRating"].Value))) == 1.0, (object)"Yes", (object)"No"));
									if (Operators.ConditionalCompareObjectEqual(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["InhClassInhMon"].Value)), (object)1, false))
									{
										COFarExpModInhRC[4, COFintNumExpModels] = "Yes (both criteria met)";
									}
									else if (Operators.ConditionalCompareObjectEqual(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["InhClassInhMon"].Value)), (object)0, false))
									{
										COFarExpModInhRC[4, COFintNumExpModels] = "No";
									}
									else
									{
										COFarExpModInhRC[4, COFintNumExpModels] = "";
									}
								}
							}
							else
							{
								Field field = recordset.Fields["AssOpID"];
								short pOpIndex = Conversions.ToShort(field.Value);
								resetInhRespClassForImport(ref pOpIndex);
								field.Value = pOpIndex;
							}
							recordset2.Open(Operators.ConcatenateObject((object)"SELECT * FROM ActExpModParms WHERE ExpParmsAN=", recordset.Fields["ExpParmsAN"].Value), importConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
							while (!recordset2.EOF)
							{
								COFarExpModParmsV[Conversions.ToInteger(recordset2.Fields["OutputID"].Value), Conversions.ToInteger(recordset2.Fields["ParmID"].Value), COFintNumExpModels] = Conversions.ToSingle(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["ParmValue"].Value)));
								COFarExpModParmsT[Conversions.ToInteger(recordset2.Fields["OutputID"].Value), Conversions.ToInteger(recordset2.Fields["ParmID"].Value), COFintNumExpModels] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["ParmType"].Value)));
								COFarExpModParmsVC[Conversions.ToInteger(recordset2.Fields["OutputID"].Value), Conversions.ToInteger(recordset2.Fields["ParmID"].Value), COFintNumExpModels] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["ParmVC"].Value)));
								recordset2.MoveNext();
							}
							recordset2.Close();
							recordset.MoveNext();
							COFintNumExpModels++;
						}
						recordset.Close();
						recordset2 = null;
						recordset = null;
						flag = true;
						goto end_IL_0001;
					}
					case 2446:
						num = -1;
						switch (num2)
						{
						case 2:
						{
							string Eobject = "frmMDUpdOps.vb";
							string Efunction = "ImportExp";
							ErrObject val = Information.Err();
							int Enumber = val.Number;
							ErrObject val2 = Information.Err();
							string Edescription = val2.Description;
							bool Econtact = true;
							Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
							val2.Description = Edescription;
							val.Number = Enumber;
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
				try0001_dispatch = 2446;
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

	public void resetInhRespClassForImport(ref short pOpIndex)
	{
		short num = 0;
		checked
		{
			short num3;
			short num4;
			do
			{
				if (COFarExpModels[1, num, pOpIndex] > 0)
				{
					short num2 = (short)(COFarExpModels[1, num, pOpIndex] - 1);
					string text = Conversions.ToString(Operators.ConcatenateObject((object)(ChemStrX.trtChemState(ref COFarExpModChmSt[num2]) + " "), Interaction.IIf(COFarSelActVolatile[num, pOpIndex] == 0, (object)"(non-volatile)", (object)"(volatile)")));
					switch (COFarExpModChmSt[num2])
					{
					case 3:
						COFarExpModInhRC[0, num2] = text + " (Class I)";
						COFarExpModInhRC[1, num2] = "NOTE: The respirator class is: I. Particulate (including solid or liquid droplets).";
						break;
					case 1:
						COFarExpModInhRC[0, num2] = text + " (Class II)";
						COFarExpModInhRC[1, num2] = "NOTE: The respirator class is: II. Gas/vapor (all substances in the gas form).";
						break;
					case 2:
					case 4:
						if (COFarSelActVolatile[num, pOpIndex] == 0)
						{
							COFarExpModInhRC[0, num2] = text + " (Class I)";
							COFarExpModInhRC[1, num2] = "NOTE: The respirator class is: I. Particulate (including solid or liquid droplets).";
						}
						else
						{
							COFarExpModInhRC[0, num2] = text + " (Class III)";
							COFarExpModInhRC[1, num2] = "NOTE: The respirator class is: III. Combination Gas/Vapor and Particulate (gas and liquid/solid physical forms are both present).";
						}
						break;
					default:
						COFarExpModInhRC[0, num2] = "Error";
						COFarExpModInhRC[1, num2] = "Error";
						break;
					}
					if ((COFarExpModEst[0, 4, num2] > 1f) | (COFarExpModEst[1, 4, num2] > 1f))
					{
						COFarExpModInhRC[2, num2] = "Yes";
					}
					else
					{
						COFarExpModInhRC[2, num2] = "No";
					}
					string text2 = frmMain.DefInstance.lblSATHR.Text;
					switch (text2)
					{
					case "2":
					case "2-3":
					case "3":
						if (true)
						{
							COFarExpModInhRC[3, num2] = "Yes";
							break;
						}
						goto default;
					default:
						if (Operators.CompareString(text2, "", false) == 0)
						{
							COFarExpModInhRC[3, num2] = "";
						}
						else
						{
							COFarExpModInhRC[3, num2] = "No";
						}
						break;
					}
					if (Operators.CompareString(COFarExpModInhRC[3, num2], "", false) == 0)
					{
						COFarExpModInhRC[4, num2] = "";
					}
					else if ((COFarExpModUncertainty[num2] == 1) & ((Operators.CompareString(COFarExpModInhRC[2, num2], "Yes", false) == 0) | (Operators.CompareString(COFarExpModInhRC[3, num2], "Yes", false) == 0)))
					{
						COFarExpModInhRC[4, num2] = "Yes (both criteria met)";
					}
					else
					{
						COFarExpModInhRC[4, num2] = "No";
					}
				}
				num = (short)unchecked(num + 1);
				num3 = num;
				num4 = 24;
			}
			while (num3 <= num4);
		}
	}

	private void cmdMoveDown_Click(object eventSender, EventArgs eventArgs)
	{
		checked
		{
			if (msfSelOps.Row < msfSelOps.Rows - 1)
			{
				short num = (short)(msfSelOps.Cols - 1);
				short num2 = 0;
				while (true)
				{
					short num3 = num2;
					short num4 = num;
					if (num3 > num4)
					{
						break;
					}
					string text = msfSelOps[msfSelOps.Row + 1, unchecked((int)num2)];
					unchecked
					{
						msfSelOps[checked(msfSelOps.Row + 1), (int)num2] = msfSelOps[msfSelOps.Row, (int)num2];
						msfSelOps[msfSelOps.Row, (int)num2] = text;
					}
					num2 = (short)unchecked(num2 + 1);
				}
				msfSelOps.RowSel = msfSelOps.Row;
				bChangedOrder = true;
			}
			((Control)cmdMoveUp).Enabled = false;
			((Control)cmdMoveDown).Enabled = false;
		}
	}

	private void cmdMoveUp_Click(object eventSender, EventArgs eventArgs)
	{
		if (msfSelOps.Row >= 1)
		{
			short num = checked((short)(msfSelOps.Cols - 1));
			short num2 = 0;
			while (true)
			{
				short num3 = num2;
				short num4 = num;
				if (num3 > num4)
				{
					break;
				}
				string text = msfSelOps[checked(msfSelOps.Row - 1), (int)num2];
				msfSelOps[checked(msfSelOps.Row - 1), (int)num2] = msfSelOps[msfSelOps.Row, (int)num2];
				msfSelOps[msfSelOps.Row, (int)num2] = text;
				checked
				{
					num2 = (short)unchecked(num2 + 1);
				}
			}
			bChangedOrder = true;
		}
		((Control)cmdMoveUp).Enabled = false;
		((Control)cmdMoveDown).Enabled = false;
	}

	private void cmdRemove_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Invalid comparison between Unknown and I4
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Invalid comparison between Unknown and I4
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Invalid comparison between Unknown and I4
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Invalid comparison between Unknown and I4
		int try0001_dispatch = -1;
		int num2 = default(int);
		short parentOp = default(short);
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
						short num3 = 0;
						short num4 = -1;
						ProjectData.ClearProjectError();
						num2 = 2;
						short num5 = Conversions.ToShort(msfSelOps[msfSelOps.Row, 1]);
						if (Strings.Len(msfSelOps[msfSelOps.Row, 0]) == 0)
						{
							goto end_IL_0001;
						}
						short num6 = (short)(COFintNumOps - 1);
						short num7 = 0;
						short num9;
						while (true)
						{
							short num8 = num7;
							num9 = num6;
							if (num8 > num9)
							{
								break;
							}
							if (COFarNoPre[num7])
							{
								num3++;
								parentOp = num7;
							}
							num7 = (short)unchecked(num7 + 1);
						}
						unchecked
						{
							if (COFarNoPre[num5])
							{
								if (num3 > 1)
								{
									if ((int)Interaction.MsgBox((object)("Are you sure you want to remove the " + msfSelOps[msfSelOps.Row, 2] + " operation from the assessment?\r\n\r\nIf you remove this operation from the assessment, all of the information associated with this operation will be removed from the assessment.\r\n\r\nIn addition, this operation is specified as one of multiple 'first' operations (no preceding operations). To maintain a valid assessment, all existing relationships must be removed. If you wish to maintain existing relationships, cancel from the 'Add/Update Operations' window and ensure that there is only one operation designated as the 'first' operation."), (MsgBoxStyle)36, (object)"Confirm Delete") == 7)
									{
										goto end_IL_0001;
									}
								}
								else if (COFarSubOpID[1, num5] > 0)
								{
									if ((int)Interaction.MsgBox((object)("Are you sure you want to remove the " + msfSelOps[msfSelOps.Row, 2] + " operation from the assessment?\r\n\r\nIf you remove this operation from the assessment, all of the information associated with this operation will be removed from the assessment.\r\n\r\nIn addition, this operation is specified as the 'first' operation (no preceding operations), but has multiple 'child' operations. Therefore, all relationships must be removed to maintain a valid assessment. If you wish to maintain existing relationships, cancel from the 'Add/Update Operations' window and first adjust the relationships to designate a new operation as the 'first' operation."), (MsgBoxStyle)36, (object)"Confirm Delete") == 7)
									{
										goto end_IL_0001;
									}
								}
								else if ((int)Interaction.MsgBox((object)("Are you sure you want to remove the " + msfSelOps[msfSelOps.Row, 2] + " operation from the assessment?\r\n\r\nIf you remove this operation from the assessment, all of the information associated with this operation will be removed from the assessment."), (MsgBoxStyle)36, (object)"Confirm Delete") == 7)
								{
									goto end_IL_0001;
								}
							}
							else if ((int)Interaction.MsgBox((object)("Are you sure you want to remove the " + msfSelOps[msfSelOps.Row, 2] + " operation from the assessment?\r\n\r\nIf you remove this operation from the assessment, all of the information associated with this operation will be removed from the assessment."), (MsgBoxStyle)36, (object)"Confirm Delete") == 7)
							{
								goto end_IL_0001;
							}
							if (COFintNumOps <= 2)
							{
								bWipeOutAllRelationships = true;
							}
							else if (COFarNoPre[num5])
							{
								if (COFarSubOpID[1, num5] == 0)
								{
									bWipeOutAllRelationships = false;
									num4 = COFarSubOpID[0, num5];
								}
								else
								{
									bWipeOutAllRelationships = true;
								}
							}
							else if (num3 != 1)
							{
								bWipeOutAllRelationships = true;
							}
							else
							{
								bWipeOutAllRelationships = false;
							}
							num7 = 0;
						}
						short num22;
						do
						{
							short num10 = 0;
							short num21;
							do
							{
								if (COFarRelModels[num10, num7, num5] > 0)
								{
									short num11 = (short)(COFarRelModels[num10, num7, num5] - 1);
									short num12 = (short)(COFintNumRelModels - 1);
									short num13 = 0;
									while (true)
									{
										short num14 = num13;
										num9 = num12;
										if (num14 > num9)
										{
											break;
										}
										COFarRelModType[num11] = 0;
										COFarRelModBasis[num11] = "";
										COFarRelModNAICS[num11] = "";
										COFarRelModStatus[num11] = 0;
										COFarRelModOutputOn[0, num11] = 0;
										COFarRelModOutputOn[1, num11] = 0;
										COFarRelModChar[0, num11] = "";
										COFarRelModChar[1, num11] = "";
										short num15 = 0;
										short num16;
										do
										{
											COFarRelModDRR[num15, num11] = 0f;
											COFarRelModARR[num15, num11] = 0f;
											COFarRelModDOR[num15, num11] = 0;
											num15 = (short)unchecked(num15 + 1);
											num16 = num15;
											num9 = 1;
										}
										while (num16 <= num9);
										num15 = 0;
										short num17;
										do
										{
											COFarRelModMedia[num15, num11] = 0f;
											num15 = (short)unchecked(num15 + 1);
											num17 = num15;
											num9 = 18;
										}
										while (num17 <= num9);
										short num18 = 0;
										short num20;
										do
										{
											num15 = 0;
											short num19;
											do
											{
												COFarRelModParmsV[num18, num15, num11] = 0f;
												COFarRelModParmsT[num18, num15, num11] = 0;
												COFarRelModParmsVC[num18, num15, num11] = 0;
												num15 = (short)unchecked(num15 + 1);
												num19 = num15;
												num9 = 162;
											}
											while (num19 <= num9);
											num18 = (short)unchecked(num18 + 1);
											num20 = num18;
											num9 = 1;
										}
										while (num20 <= num9);
										num13 = (short)unchecked(num13 + 1);
									}
									COFarRelModels[num10, num7, num5] = 0;
								}
								num10 = (short)unchecked(num10 + 1);
								num21 = num10;
								num9 = 9;
							}
							while (num21 <= num9);
							num7 = (short)unchecked(num7 + 1);
							num22 = num7;
							num9 = 24;
						}
						while (num22 <= num9);
						num7 = 0;
						short num30;
						do
						{
							short num10 = 0;
							short num29;
							do
							{
								if (COFarExpModels[num10, num7, num5] > 0)
								{
									short num11 = (short)(COFarExpModels[num10, num7, num5] - 1);
									short num23 = (short)(COFintNumExpModels - 1);
									short num13 = 0;
									while (true)
									{
										short num24 = num13;
										num9 = num23;
										if (num24 > num9)
										{
											break;
										}
										COFarExpModType[num11] = 0;
										COFarExpModOutputOn[0, num11] = 0;
										COFarExpModOutputOn[1, num11] = 0;
										COFarExpModChar[0, num11] = "";
										COFarExpModChar[1, num11] = "";
										COFarExpModBasis[num11] = "";
										COFarExpModChmSt[num11] = 0;
										COFarExpModUncertainty[num11] = 0;
										COFarExpModStatus[num11] = 0;
										short num18 = 0;
										short num27;
										short num15;
										do
										{
											num15 = 0;
											short num25;
											do
											{
												COFarExpModParmsV[num18, num15, num11] = 0f;
												COFarExpModParmsT[num18, num15, num11] = 0;
												COFarExpModParmsVC[num18, num15, num11] = 0;
												num15 = (short)unchecked(num15 + 1);
												num25 = num15;
												num9 = 162;
											}
											while (num25 <= num9);
											num15 = 0;
											short num26;
											do
											{
												COFarExpModEst[num18, num15, num11] = 0f;
												num15 = (short)unchecked(num15 + 1);
												num26 = num15;
												num9 = 18;
											}
											while (num26 <= num9);
											num18 = (short)unchecked(num18 + 1);
											num27 = num18;
											num9 = 1;
										}
										while (num27 <= num9);
										num15 = 0;
										short num28;
										do
										{
											COFarExpModInhRC[num15, num11] = "";
											num15 = (short)unchecked(num15 + 1);
											num28 = num15;
											num9 = 4;
										}
										while (num28 <= num9);
										num13 = (short)unchecked(num13 + 1);
									}
									COFarExpModels[num10, num7, num5] = 0;
								}
								num10 = (short)unchecked(num10 + 1);
								num29 = num10;
								num9 = 1;
							}
							while (num29 <= num9);
							num7 = (short)unchecked(num7 + 1);
							num30 = num7;
							num9 = 24;
						}
						while (num30 <= num9);
						short num31 = (short)(COFintNumOps - 2);
						num7 = num5;
						while (true)
						{
							short num32 = num7;
							num9 = num31;
							if (num32 > num9)
							{
								break;
							}
							COFarOpPV[num7] = COFarOpPV[num7 + 1];
							short num10 = 0;
							short num34;
							do
							{
								COFarSelActs[num10, num7] = COFarSelActs[num10, num7 + 1];
								COFarSelActType[num10, num7] = COFarSelActType[num10, num7 + 1];
								COFarSelActRa[num10, num7] = COFarSelActRa[num10, num7 + 1];
								COFarSelActEa[num10, num7] = COFarSelActEa[num10, num7 + 1];
								COFarSelActRaDMP[num10, num7] = COFarSelActRaDMP[num10, num7 + 1];
								COFarSelActEaDMP[num10, num7] = COFarSelActEaDMP[num10, num7 + 1];
								COFarSelActVolatile[num10, num7] = COFarSelActVolatile[num10, num7 + 1];
								COFarActNumWorkers[0, num10, num7] = COFarActNumWorkers[0, num10, num7 + 1];
								COFarActNumWorkers[1, num10, num7] = COFarActNumWorkers[1, num10, num7 + 1];
								COFarActNumWorkers[2, num10, num7] = COFarActNumWorkers[2, num10, num7 + 1];
								COFarActNW_Route[num10, num7] = COFarActNW_Route[num10, num7 + 1];
								COFarActOrder[num10, num7] = COFarActOrder[num10, num7 + 1];
								COFarNaics1[num10, num7] = COFarNaics1[num10, num7 + 1];
								COFarNaics2[num10, num7] = COFarNaics2[num10, num7 + 1];
								COFarOSName[num10, num7] = COFarOSName[num10, num7 + 1];
								COFarOSAddr[num10, num7] = COFarOSAddr[num10, num7 + 1];
								COFarOSCity[num10, num7] = COFarOSCity[num10, num7 + 1];
								COFarOSState[num10, num7] = COFarOSState[num10, num7 + 1];
								COFarOSZip[num10, num7] = COFarOSZip[num10, num7 + 1];
								COFarOSCty[num10, num7] = COFarOSCty[num10, num7 + 1];
								short num15 = 0;
								short num33;
								do
								{
									COFarRelModels[num15, num10, num7] = COFarRelModels[num15, num10, num7 + 1];
									num15 = (short)unchecked(num15 + 1);
									num33 = num15;
									num9 = 10;
								}
								while (num33 <= num9);
								COFarExpModels[0, num10, num7] = COFarExpModels[0, num10, num7 + 1];
								COFarExpModels[1, num10, num7] = COFarExpModels[1, num10, num7 + 1];
								num10 = (short)unchecked(num10 + 1);
								num34 = num10;
								num9 = 25;
							}
							while (num34 <= num9);
							COFarMiscOpParms[0, num7] = COFarMiscOpParms[0, num7 + 1];
							COFarMiscOpParms[1, num7] = COFarMiscOpParms[1, num7 + 1];
							num10 = 0;
							short num35;
							do
							{
								COFarGssOptions[num10, num7] = COFarGssOptions[num10, num7 + 1];
								COFarGssOther[num10, num7] = COFarGssOther[num10, num7 + 1];
								num10 = (short)unchecked(num10 + 1);
								num35 = num10;
								num9 = 161;
							}
							while (num35 <= num9);
							COFarPSInto2[num7] = COFarPSInto2[num7 + 1];
							COFarPSInto2[num7] = COFarPSInto2[num7 + 1];
							COFarPSOut1[num7] = COFarPSOut1[num7 + 1];
							COFarPSOut2[num7] = COFarPSOut2[num7 + 1];
							COFarPSIn1[num7] = COFarPSIn1[num7 + 1];
							COFarPSIn2[num7] = COFarPSIn2[num7 + 1];
							COFarPDesc[num7] = COFarPDesc[num7 + 1];
							COFarBasis[num7] = COFarBasis[num7 + 1];
							COFarWaterBasis[num7] = COFarWaterBasis[num7 + 1];
							COFarRelAddNotes[num7] = COFarRelAddNotes[num7 + 1];
							COFarExpAddNotes[num7] = COFarExpAddNotes[num7 + 1];
							COFarOpNumWorkers[0, num7] = COFarOpNumWorkers[0, num7 + 1];
							COFarOpNumWorkers[1, num7] = COFarOpNumWorkers[1, num7 + 1];
							COFarOpNumWorkersBasis[num7] = COFarOpNumWorkersBasis[num7 + 1];
							COFarOpNumWorkersBasisEnabled[num7] = COFarOpNumWorkersBasisEnabled[num7 + 1];
							COFarInhalationBasis[num7] = COFarInhalationBasis[num7 + 1];
							COFarDermalBasis[num7] = COFarDermalBasis[num7 + 1];
							COFarOpBorC[num7] = COFarOpBorC[num7 + 1];
							COFarOpIoE[num7] = COFarOpIoE[num7 + 1];
							COFarOpMassBalDisc[0, num7] = COFarOpMassBalDisc[0, num7 + 1];
							COFarOpMassBalDisc[1, num7] = COFarOpMassBalDisc[1, num7 + 1];
							COFarOpName[num7] = COFarOpName[num7 + 1];
							COFarOpNeedsMassBalance[num7] = COFarOpNeedsMassBalance[num7 + 1];
							COFarOpType[num7] = COFarOpType[num7 + 1];
							COFarOpOrder[num7] = COFarOpOrder[num7 + 1];
							num10 = 0;
							short num36;
							do
							{
								COFarOpSP[num10, num7] = COFarOpSP[num10, num7 + 1];
								COFarOpSPType[num10, num7] = COFarOpSPType[num10, num7 + 1];
								num10 = (short)unchecked(num10 + 1);
								num36 = num10;
								num9 = 47;
							}
							while (num36 <= num9);
							short num37 = 0;
							short num38;
							do
							{
								COFarOpParms[num37, num7] = COFarOpParms[num37, num7 + 1];
								COFarOpParmsType[num37, num7] = COFarOpParmsType[num37, num7 + 1];
								num37 = (short)unchecked(num37 + 1);
								num38 = num37;
								num9 = 162;
							}
							while (num38 <= num9);
							num7 = (short)unchecked(num7 + 1);
						}
						if (!bWipeOutAllRelationships)
						{
							findAndAdoptTheChildren(parentOp, num5);
						}
						if (bWipeOutAllRelationships)
						{
							short num39 = (short)(COFintNumOps - 1);
							num7 = 0;
							while (true)
							{
								short num40 = num7;
								num9 = num39;
								if (num40 <= num9)
								{
									short num10 = 0;
									short num41;
									do
									{
										COFarSubOpID[num10, num7] = 0;
										COFarSubPVf[num10, num7] = 0;
										COFarSubPvOp[num10, num7] = 0f;
										num10 = (short)unchecked(num10 + 1);
										num41 = num10;
										num9 = 9;
									}
									while (num41 <= num9);
									num7 = (short)unchecked(num7 + 1);
									continue;
								}
								break;
							}
						}
						else
						{
							short num42 = (short)(COFintNumOps - 1);
							num7 = num5;
							while (true)
							{
								short num43 = num7;
								num9 = num42;
								if (num43 > num9)
								{
									break;
								}
								short num10 = 0;
								short num44;
								do
								{
									COFarSubOpID[num10, num7] = COFarSubOpID[num10, num7 + 1];
									COFarSubPVf[num10, num7] = COFarSubPVf[num10, num7 + 1];
									COFarSubPvOp[num10, num7] = COFarSubPvOp[num10, num7 + 1];
									num10 = (short)unchecked(num10 + 1);
									num44 = num10;
									num9 = 9;
								}
								while (num44 <= num9);
								num7 = (short)unchecked(num7 + 1);
							}
							short num45 = (short)(COFintNumOps - 2);
							num7 = 0;
							while (true)
							{
								short num46 = num7;
								num9 = num45;
								if (num46 > num9)
								{
									break;
								}
								short num10 = 0;
								short num47;
								do
								{
									if (COFarSubOpID[num10, num7] > num5)
									{
										COFarSubOpID[num10, num7]--;
									}
									num10 = (short)unchecked(num10 + 1);
									num47 = num10;
									num9 = 9;
								}
								while (num47 <= num9);
								num7 = (short)unchecked(num7 + 1);
							}
						}
						if (num4 != -1)
						{
							COFarNoPre[num4 - 1] = true;
						}
						short num48 = (short)(COFintNumOps - 2);
						num7 = num5;
						while (true)
						{
							short num49 = num7;
							num9 = num48;
							if (num49 > num9)
							{
								break;
							}
							COFarNoPre[num7] = COFarNoPre[num7 + 1];
							num7 = (short)unchecked(num7 + 1);
						}
						short num50 = (short)(COFintNumOps - 1);
						short num51 = (short)(COFintNumOps - 1);
						num7 = num50;
						while (true)
						{
							short num52 = num7;
							num9 = num51;
							if (num52 > num9)
							{
								break;
							}
							COFarNoPre[num7] = false;
							COFarOpPV[num7] = 0f;
							short num10 = 0;
							short num53;
							do
							{
								COFarSubOpID[num10, num7] = 0;
								COFarSubPVf[num10, num7] = 0;
								COFarSubPvOp[num10, num7] = 0f;
								num10 = (short)unchecked(num10 + 1);
								num53 = num10;
								num9 = 9;
							}
							while (num53 <= num9);
							num10 = 0;
							short num55;
							do
							{
								COFarSelActs[num10, num7] = "";
								COFarSelActType[num10, num7] = 0;
								COFarSelActRa[num10, num7] = false;
								COFarSelActEa[num10, num7] = false;
								COFarSelActRaDMP[num10, num7] = 0;
								COFarSelActEaDMP[num10, num7] = 0;
								COFarSelActVolatile[num10, num7] = 0;
								COFarActNumWorkers[0, num10, num7] = 0;
								COFarActNumWorkers[1, num10, num7] = 0;
								COFarActNumWorkers[2, num10, num7] = 0;
								COFarActNW_Route[num10, num7] = "";
								COFarActOrder[num10, num7] = 0;
								COFarNaics1[num10, num7] = "";
								COFarNaics2[num10, num7] = "";
								COFarOSName[num10, num7] = "";
								COFarOSAddr[num10, num7] = "";
								COFarOSCity[num10, num7] = "";
								COFarOSState[num10, num7] = "";
								COFarOSZip[num10, num7] = "";
								COFarOSCty[num10, num7] = "";
								short num15 = 0;
								short num54;
								do
								{
									COFarRelModels[num15, num10, num7] = 0;
									num15 = (short)unchecked(num15 + 1);
									num54 = num15;
									num9 = 10;
								}
								while (num54 <= num9);
								COFarExpModels[0, num10, num7] = 0;
								COFarExpModels[1, num10, num7] = 0;
								num10 = (short)unchecked(num10 + 1);
								num55 = num10;
								num9 = 25;
							}
							while (num55 <= num9);
							COFarMiscOpParms[0, num7] = 0f;
							COFarMiscOpParms[1, num7] = 0f;
							num10 = 0;
							short num56;
							do
							{
								COFarGssOptions[num10, num7] = 0;
								COFarGssOther[num10, num7] = Conversions.ToString(0);
								num10 = (short)unchecked(num10 + 1);
								num56 = num10;
								num9 = 161;
							}
							while (num56 <= num9);
							COFarPSInto2[num7] = "";
							COFarPSInto2[num7] = "";
							COFarPSOut1[num7] = "";
							COFarPSOut2[num7] = "";
							COFarPSIn1[num7] = "";
							COFarPSIn2[num7] = "";
							COFarPDesc[num7] = "";
							COFarBasis[num7] = "";
							COFarWaterBasis[num7] = "";
							COFarRelAddNotes[num7] = "";
							COFarExpAddNotes[num7] = "";
							COFarOpNumWorkers[0, num7] = 0;
							COFarOpNumWorkers[1, num7] = 0;
							COFarOpNumWorkersBasis[num7] = "";
							COFarOpNumWorkersBasisEnabled[num7] = 0;
							COFarInhalationBasis[num7] = "";
							COFarDermalBasis[num7] = "";
							COFarOpBorC[num7] = 0;
							COFarOpIoE[num7] = 0;
							COFarOpMassBalDisc[0, num7] = 0;
							COFarOpMassBalDisc[1, num7] = 0;
							COFarOpName[num7] = "";
							COFarOpNeedsMassBalance[num7] = 0;
							COFarOpType[num7] = 0;
							COFarOpOrder[num7] = 0;
							num10 = 0;
							short num57;
							do
							{
								COFarOpSP[num10, num7] = 0f;
								COFarOpSPType[num10, num7] = 0;
								num10 = (short)unchecked(num10 + 1);
								num57 = num10;
								num9 = 47;
							}
							while (num57 <= num9);
							short num37 = 0;
							short num58;
							do
							{
								COFarOpParms[num37, num7] = 0f;
								COFarOpParmsType[num37, num7] = 0;
								num37 = (short)unchecked(num37 + 1);
								num58 = num37;
								num9 = 162;
							}
							while (num58 <= num9);
							num7 = (short)unchecked(num7 + 1);
						}
						COFintNumOps--;
						if (msfSelOps.Rows == 1)
						{
							msfSelOps.AddItem("");
						}
						msfSelOps.RemoveItem(msfSelOps.Row);
						if (COFintNumOps <= 0)
						{
							goto end_IL_0001;
						}
						short num59 = (short)(msfSelOps.Rows - 1);
						num7 = 0;
						while (true)
						{
							short num60 = num7;
							num9 = num59;
							if (num60 <= num9)
							{
								unchecked
								{
									if (Conversions.ToDouble(msfSelOps[(int)num7, 1]) > (double)num5)
									{
										msfSelOps[(int)num7, 1] = Conversions.ToString(Conversions.ToDouble(msfSelOps[(int)num7, 1]) - 1.0);
									}
								}
								num7 = (short)unchecked(num7 + 1);
								continue;
							}
							break;
						}
						goto end_IL_0001;
					}
					case 5228:
						num = -1;
						switch (num2)
						{
						case 2:
						{
							string Eobject = "frmMDUpdOps.vb";
							string Efunction = "cmdRemove_click";
							ErrObject val = Information.Err();
							int Enumber = val.Number;
							ErrObject val2 = Information.Err();
							string Edescription = val2.Description;
							bool Econtact = true;
							Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
							val2.Description = Edescription;
							val.Number = Enumber;
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
				try0001_dispatch = 5228;
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

	private void findAndAdoptTheChildren(short parentOp, short OpRemoved)
	{
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		int num = -1;
		short num2 = 0;
		checked
		{
			short num3;
			short num4;
			do
			{
				if (COFarSubOpID[num2, parentOp] == OpRemoved + 1)
				{
					num = num2;
					break;
				}
				if (COFarSubOpID[num2, parentOp] > 0)
				{
					findAndAdoptTheChildren((short)(COFarSubOpID[num2, parentOp] - 1), OpRemoved);
					num2 = (short)unchecked(num2 + 1);
					num3 = num2;
					num4 = 9;
					continue;
				}
				break;
			}
			while (num3 <= num4);
			if (num == -1)
			{
				return;
			}
			short num5 = 0;
			num2 = 0;
			while (COFarSubOpID[num2, parentOp] != 0)
			{
				num5++;
				num2 = (short)unchecked(num2 + 1);
				short num6 = num2;
				num4 = 9;
				if (num6 > num4)
				{
					break;
				}
			}
			short num7 = 0;
			num2 = 0;
			while (COFarSubOpID[num2, OpRemoved] != 0)
			{
				num7++;
				num2 = (short)unchecked(num2 + 1);
				short num8 = num2;
				num4 = 9;
				if (num8 > num4)
				{
					break;
				}
			}
			if (num5 - 1 + num7 > 10)
			{
				Interaction.MsgBox((object)(unchecked("The operation being deleted has " + Conversions.ToString((int)num7) + " subsequent operations. It's parent already has " + Conversions.ToString((int)num5)) + " subsequent operations. Having the partner 'adopt' the subsequent operations of the operation being deleted would exceed the maximum number of subsequent operations allowed. Therefore all relationships in the assessment are being deleted. If you want to avoid this deletion, cancel the current update and first delete all of the relationships associated with the operation you wish to delete."), (MsgBoxStyle)0, (object)null);
				bWipeOutAllRelationships = true;
				return;
			}
			short num9 = (short)num;
			short num10 = (short)(num5 - 1);
			num2 = num9;
			while (true)
			{
				short num11 = num2;
				num4 = num10;
				if (num11 > num4)
				{
					break;
				}
				COFarSubOpID[num2, parentOp] = COFarSubOpID[num2 + 1, parentOp];
				COFarSubPVf[num2, parentOp] = COFarSubPVf[num2 + 1, parentOp];
				COFarSubPvOp[num2, parentOp] = COFarSubPvOp[num2 + 1, parentOp];
				num2 = (short)unchecked(num2 + 1);
			}
			num5--;
			short num12 = (short)(num7 - 1);
			num2 = 0;
			while (true)
			{
				short num13 = num2;
				num4 = num12;
				if (num13 <= num4)
				{
					COFarSubOpID[(short)unchecked(num2 + num5), parentOp] = COFarSubOpID[num2, OpRemoved];
					COFarSubPVf[(short)unchecked(num2 + num5), parentOp] = COFarSubPVf[num2, OpRemoved];
					COFarSubPvOp[(short)unchecked(num2 + num5), parentOp] = COFarSubPvOp[num2, OpRemoved];
					num2 = (short)unchecked(num2 + 1);
					continue;
				}
				break;
			}
		}
	}

	private void lstOps_DoubleClick(object eventSender, EventArgs eventArgs)
	{
		cmdAdd_Click(cmdAdd, new EventArgs());
	}

	private void msfSelOps_ClickEvent(object eventSender, EventArgs eventArgs)
	{
		checked
		{
			if (Strings.Len(msfSelOps[msfSelOps.Row, 0]) != 0 && msfSelOps.Col == 2)
			{
				((Control)txtRename).Top = (int)Math.Round(Support.TwipsToPixelsY(Support.PixelsToTwipsY((double)((Control)msfSelOps).Top) + (double)msfSelOps[msfSelOps.Row]));
				((Control)txtRename).Left = (int)Math.Round(Support.TwipsToPixelsX(Support.PixelsToTwipsX((double)((Control)msfSelOps).Left) + 50.0));
				if (msfSelOps.Rows > 5)
				{
					((Control)txtRename).Width = (int)Math.Round(Support.TwipsToPixelsX((double)(msfSelOps[2] - 150)));
				}
				else
				{
					((Control)txtRename).Width = (int)Math.Round(Support.TwipsToPixelsX((double)msfSelOps[2]));
				}
				txtRename.Text = msfSelOps[msfSelOps.Row, 2];
				((Control)txtRename).Tag = msfSelOps.Row;
				((Control)txtRename).Visible = true;
				((TextBoxBase)txtRename).SelectionStart = 0;
				((TextBoxBase)txtRename).SelectionLength = Strings.Len(txtRename.Text);
				((Control)txtRename).Focus();
				((Control)cmdMoveUp).Enabled = true;
				((Control)cmdMoveDown).Enabled = true;
			}
		}
	}

	private void msfSelOps_DblClick(object eventSender, EventArgs eventArgs)
	{
		cmdRemove_Click(cmdRemove, new EventArgs());
	}

	private void msfSelOps_Scroll(object eventSender, EventArgs eventArgs)
	{
		((Control)txtRename).Visible = false;
	}

	private void txtRename_Leave(object eventSender, EventArgs eventArgs)
	{
		msfSelOps[Conversions.ToInteger(((Control)txtRename).Tag), 2] = txtRename.Text;
		txtRename.Text = "";
		((Control)txtRename).Visible = false;
	}

	private void AddGSS_ElecBathDefaults()
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
						float[,] cOFarOpParms = COFarOpParms;
						int num3 = COFintNumOps - 1;
						short pGSSID = 104;
						short pParmID = 2;
						cOFarOpParms[2, num3] = ChemStrX.SetGSSParmDefault2(ref pGSSID, ref pParmID);
						COFarOpParmsType[2, COFintNumOps - 1] = 1;
						float[,] cOFarOpParms2 = COFarOpParms;
						int num4 = COFintNumOps - 1;
						pParmID = 104;
						pGSSID = 131;
						cOFarOpParms2[131, num4] = ChemStrX.SetGSSParmDefault(ref pParmID, ref pGSSID);
						COFarOpParmsType[131, COFintNumOps - 1] = 1;
						float[,] cOFarOpParms3 = COFarOpParms;
						int num5 = COFintNumOps - 1;
						pParmID = 104;
						pGSSID = 132;
						cOFarOpParms3[132, num5] = ChemStrX.SetGSSParmDefault(ref pParmID, ref pGSSID);
						COFarOpParmsType[132, COFintNumOps - 1] = 1;
						float[,] cOFarOpParms4 = COFarOpParms;
						int num6 = COFintNumOps - 1;
						pParmID = 104;
						pGSSID = 133;
						cOFarOpParms4[133, num6] = ChemStrX.SetGSSParmDefault(ref pParmID, ref pGSSID);
						COFarOpParmsType[133, COFintNumOps - 1] = 1;
						float[,] cOFarOpParms5 = COFarOpParms;
						int num7 = COFintNumOps - 1;
						pParmID = 104;
						pGSSID = 134;
						cOFarOpParms5[134, num7] = ChemStrX.SetGSSParmDefault(ref pParmID, ref pGSSID);
						COFarOpParmsType[134, COFintNumOps - 1] = 1;
						float[,] cOFarOpParms6 = COFarOpParms;
						int num8 = COFintNumOps - 1;
						pParmID = 104;
						pGSSID = 135;
						cOFarOpParms6[135, num8] = ChemStrX.SetGSSParmDefault(ref pParmID, ref pGSSID);
						COFarOpParmsType[135, COFintNumOps - 1] = 1;
						float[,] cOFarOpParms7 = COFarOpParms;
						int num9 = COFintNumOps - 1;
						pParmID = 104;
						pGSSID = 136;
						cOFarOpParms7[136, num9] = ChemStrX.SetGSSParmDefault(ref pParmID, ref pGSSID);
						COFarOpParmsType[136, COFintNumOps - 1] = 1;
						float[,] cOFarOpParms8 = COFarOpParms;
						int num10 = COFintNumOps - 1;
						pParmID = 104;
						pGSSID = 137;
						cOFarOpParms8[137, num10] = ChemStrX.SetGSSParmDefault(ref pParmID, ref pGSSID);
						COFarOpParmsType[137, COFintNumOps - 1] = 1;
						float[,] cOFarOpParms9 = COFarOpParms;
						int num11 = COFintNumOps - 1;
						pParmID = 104;
						pGSSID = 138;
						cOFarOpParms9[138, num11] = ChemStrX.SetGSSParmDefault(ref pParmID, ref pGSSID);
						COFarOpParmsType[138, COFintNumOps - 1] = 1;
						float[,] cOFarOpParms10 = COFarOpParms;
						int num12 = COFintNumOps - 1;
						pParmID = 104;
						pGSSID = 139;
						cOFarOpParms10[139, num12] = ChemStrX.SetGSSParmDefault(ref pParmID, ref pGSSID);
						COFarOpParmsType[139, COFintNumOps - 1] = 1;
						float[,] cOFarOpParms11 = COFarOpParms;
						int num13 = COFintNumOps - 1;
						pParmID = 104;
						pGSSID = 139;
						cOFarOpParms11[140, num13] = ChemStrX.SetGSSParmDefault(ref pParmID, ref pGSSID);
						COFarOpParmsType[140, COFintNumOps - 1] = 1;
						float[,] cOFarOpParms12 = COFarOpParms;
						int num14 = COFintNumOps - 1;
						pParmID = 104;
						pGSSID = 142;
						cOFarOpParms12[142, num14] = ChemStrX.SetGSSParmDefault(ref pParmID, ref pGSSID);
						COFarOpParmsType[142, COFintNumOps - 1] = 1;
						COFarOpParmsType[1, COFintNumOps - 1] = 1;
						COFarOpParmsType[14, COFintNumOps - 1] = 1;
						COFarOpParmsType[15, COFintNumOps - 1] = 1;
						COFarOpParmsType[13, COFintNumOps - 1] = 1;
						COFarOpParmsType[12, COFintNumOps - 1] = 1;
						COFarOpParmsType[11, COFintNumOps - 1] = 1;
						COFarOpParmsType[10, COFintNumOps - 1] = 1;
						COFarOpSP[47, COFintNumOps - 1] = 1f;
						COFarOpSPType[47, COFintNumOps - 1] = 1;
						COFarOpSP[46, COFintNumOps - 1] = 1f;
						COFarOpParms[13, COFintNumOps - 1] = (float)ChemStrX.Calc104_EP1(COFarOpParms[135, COFintNumOps - 1], COFarOpParms[136, COFintNumOps - 1], COFarOpParms[137, COFintNumOps - 1], COFarOpParms[133, COFintNumOps - 1], COFarOpParms[131, COFintNumOps - 1], COFarOpParms[2, COFintNumOps - 1], COFarOpParms[138, COFintNumOps - 1], COFarOpParms[134, COFintNumOps - 1], COFarOpParms[132, COFintNumOps - 1], COFarOpParms[139, COFintNumOps - 1]);
						double pValue = ChemStrX.Calc104_EP2(COFarOpPV[COFintNumOps - 1], COFarOpParms[2, COFintNumOps - 1], COFarOpParms[13, COFintNumOps - 1]);
						if (pValue < 1.0)
						{
							COFarOpParms[1, COFintNumOps - 1] = 1f;
							COFarOpParms[2, COFintNumOps - 1] = ChemStrX.Calc104_EP2a(COFarOpPV[COFintNumOps - 1], COFarOpParms[1, COFintNumOps - 1], COFarOpParms[13, COFintNumOps - 1]);
						}
						else
						{
							pValue = frmMDUpdOpIP.DefInstance.MassBalanceRoundUp(ref pValue);
							COFarOpParms[1, COFintNumOps - 1] = (float)pValue;
						}
						if (COFarOpPV[COFintNumOps - 1] > 0f)
						{
							COFarOpParms[13, COFintNumOps - 1] = ChemStrX.Calc104_EP3(COFarOpPV[COFintNumOps - 1], COFarOpParms[1, COFintNumOps - 1], COFarOpParms[2, COFintNumOps - 1]);
						}
						else
						{
							COFarOpParms[13, COFintNumOps - 1] = 0f;
						}
						if (COFintNumOps > 1)
						{
							COFarOpParms[10, COFintNumOps - 1] = ChemStrX.Calc104_EP4(COFintNumOps - 1, COFarOpParms[10, COFintNumOps - 2]);
						}
						else
						{
							COFarOpParms[10, COFintNumOps - 1] = 1f;
						}
						COFarOpParms[11, COFintNumOps - 1] = COFarOpParms[10, COFintNumOps - 1];
						COFarOpParms[12, COFintNumOps - 1] = ChemStrX.Calc104_EP5(COFarOpParms[13, COFintNumOps - 1], COFarOpParms[10, COFintNumOps - 1]);
						COFarOpParms[15, COFintNumOps - 1] = COFarOpParms[13, COFintNumOps - 1];
						COFarOpParms[14, COFintNumOps - 1] = ChemStrX.Calc104_EP7(COFarOpParms[15, COFintNumOps - 1], COFarOpParms[11, COFintNumOps - 1]);
						goto end_IL_0001;
					}
					case 2104:
						num = -1;
						switch (num2)
						{
						case 2:
						{
							string Eobject = ((Control)this).Name;
							string Efunction = "AddGSS_ElecBathDefaults";
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
				try0001_dispatch = 2104;
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
}
