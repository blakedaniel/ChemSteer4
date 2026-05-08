using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ADODB;
using AxMSDBGrid;
using Microsoft.VisualBasic.CompilerServices;

namespace ChemSteer;

internal class frmViewCRSS : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("cmdClose")]
	private Button _cmdClose;

	[AccessedThroughProperty("PMNnumber")]
	private DataGridViewTextBoxColumn _PMNnumber;

	[AccessedThroughProperty("Chemist")]
	private DataGridViewTextBoxColumn _Chemist;

	[AccessedThroughProperty("Submitter")]
	private DataGridViewTextBoxColumn _Submitter;

	[AccessedThroughProperty("ChemicalName")]
	private DataGridViewTextBoxColumn _ChemicalName;

	[AccessedThroughProperty("TradeName")]
	private DataGridViewTextBoxColumn _TradeName;

	[AccessedThroughProperty("ExposureBased")]
	private DataGridViewTextBoxColumn _ExposureBased;

	[AccessedThroughProperty("CASNumber")]
	private DataGridViewTextBoxColumn _CASNumber;

	[AccessedThroughProperty("Molecular")]
	private DataGridViewTextBoxColumn _Molecular;

	[AccessedThroughProperty("MolWeight")]
	private DataGridViewTextBoxColumn _MolWeight;

	[AccessedThroughProperty("MWValueType")]
	private DataGridViewTextBoxColumn _MWValueType;

	[AccessedThroughProperty("WtPercent500")]
	private DataGridViewTextBoxColumn _WtPercent500;

	[AccessedThroughProperty("WtPercent1000")]
	private DataGridViewTextBoxColumn _WtPercent1000;

	[AccessedThroughProperty("InitialPV")]
	private DataGridViewTextBoxColumn _InitialPV;

	[AccessedThroughProperty("MaxPV")]
	private DataGridViewTextBoxColumn _MaxPV;

	[AccessedThroughProperty("Manuf")]
	private DataGridViewTextBoxColumn _Manuf;

	[AccessedThroughProperty("Import")]
	private DataGridViewTextBoxColumn _Import;

	[AccessedThroughProperty("Neat")]
	private DataGridViewTextBoxColumn _Neat;

	[AccessedThroughProperty("Process")]
	private DataGridViewTextBoxColumn _Process;

	[AccessedThroughProperty("Manufacture")]
	private DataGridViewTextBoxColumn _Manufacture;

	[AccessedThroughProperty("EndUse")]
	private DataGridViewTextBoxColumn _EndUse;

	[AccessedThroughProperty("ConsumerUse")]
	private DataGridViewTextBoxColumn _ConsumerUse;

	[AccessedThroughProperty("BPest")]
	private DataGridViewTextBoxColumn _BPest;

	[AccessedThroughProperty("VPest")]
	private DataGridViewTextBoxColumn _VPest;

	[AccessedThroughProperty("WaterSolubEst")]
	private DataGridViewTextBoxColumn _WaterSolubEst;

	[AccessedThroughProperty("LogP")]
	private DataGridViewTextBoxColumn _LogP;

	[AccessedThroughProperty("SC1")]
	private DataGridViewTextBoxColumn _SC1;

	[AccessedThroughProperty("SC2")]
	private DataGridViewTextBoxColumn _SC2;

	[AccessedThroughProperty("SC3")]
	private DataGridViewTextBoxColumn _SC3;

	[AccessedThroughProperty("SC4")]
	private DataGridViewTextBoxColumn _SC4;

	[AccessedThroughProperty("SC5")]
	private DataGridViewTextBoxColumn _SC5;

	[AccessedThroughProperty("SC6")]
	private DataGridViewTextBoxColumn _SC6;

	[AccessedThroughProperty("SC7")]
	private DataGridViewTextBoxColumn _SC7;

	[AccessedThroughProperty("Mer1")]
	private DataGridViewTextBoxColumn _Mer1;

	[AccessedThroughProperty("Mer2")]
	private DataGridViewTextBoxColumn _Mer2;

	[AccessedThroughProperty("Mer3")]
	private DataGridViewTextBoxColumn _Mer3;

	[AccessedThroughProperty("Mer4")]
	private DataGridViewTextBoxColumn _Mer4;

	[AccessedThroughProperty("Mer5")]
	private DataGridViewTextBoxColumn _Mer5;

	[AccessedThroughProperty("Mer6")]
	private DataGridViewTextBoxColumn _Mer6;

	[AccessedThroughProperty("Mer7")]
	private DataGridViewTextBoxColumn _Mer7;

	[AccessedThroughProperty("USE")]
	private DataGridViewTextBoxColumn _USE;

	[AccessedThroughProperty("AddnlInfo")]
	private DataGridViewTextBoxColumn _AddnlInfo;

	[AccessedThroughProperty("MP")]
	private DataGridViewTextBoxColumn _MP;

	[AccessedThroughProperty("MPest")]
	private DataGridViewTextBoxColumn _MPest;

	[AccessedThroughProperty("VP")]
	private DataGridViewTextBoxColumn _VP;

	[AccessedThroughProperty("WaterSolub")]
	private DataGridViewTextBoxColumn _WaterSolub;

	[AccessedThroughProperty("BPPressure")]
	private DataGridViewTextBoxColumn _BPPressure;

	[AccessedThroughProperty("OtherUses")]
	private DataGridViewTextBoxColumn _OtherUses;

	[AccessedThroughProperty("AddlChemInfo")]
	private DataGridViewTextBoxColumn _AddlChemInfo;

	[AccessedThroughProperty("RevisionDate")]
	private DataGridViewTextBoxColumn _RevisionDate;

	[AccessedThroughProperty("SC8")]
	private DataGridViewTextBoxColumn _SC8;

	[AccessedThroughProperty("SC9")]
	private DataGridViewTextBoxColumn _SC9;

	[AccessedThroughProperty("SC10")]
	private DataGridViewTextBoxColumn _SC10;

	[AccessedThroughProperty("Mer8")]
	private DataGridViewTextBoxColumn _Mer8;

	[AccessedThroughProperty("Mer9")]
	private DataGridViewTextBoxColumn _Mer9;

	[AccessedThroughProperty("Mer10")]
	private DataGridViewTextBoxColumn _Mer10;

	[AccessedThroughProperty("CRSSdate")]
	private DataGridViewTextBoxColumn _CRSSdate;

	[AccessedThroughProperty("BindOption")]
	private DataGridViewTextBoxColumn _BindOption;

	[AccessedThroughProperty("LogPest")]
	private DataGridViewTextBoxColumn _LogPest;

	[AccessedThroughProperty("SClogP")]
	private DataGridViewTextBoxColumn _SClogP;

	[AccessedThroughProperty("MerLogP")]
	private DataGridViewTextBoxColumn _MerLogP;

	[AccessedThroughProperty("BP")]
	private DataGridViewTextBoxColumn _BP;

	[AccessedThroughProperty("TSnumber")]
	private DataGridViewTextBoxColumn _TSnumber;

	[AccessedThroughProperty("RxnDescription")]
	private DataGridViewTextBoxColumn _RxnDescription;

	[AccessedThroughProperty("P2concerns")]
	private DataGridViewTextBoxColumn _P2concerns;

	[AccessedThroughProperty("dgvCRSS")]
	private DataGridView _dgvCRSS;

	private static frmViewCRSS m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	private object[] arPELREL;

	private short currChem;

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

	internal virtual DataGridViewTextBoxColumn PMNnumber
	{
		[DebuggerNonUserCode]
		get
		{
			return _PMNnumber;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PMNnumber = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Chemist
	{
		[DebuggerNonUserCode]
		get
		{
			return _Chemist;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Chemist = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Submitter
	{
		[DebuggerNonUserCode]
		get
		{
			return _Submitter;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Submitter = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn ChemicalName
	{
		[DebuggerNonUserCode]
		get
		{
			return _ChemicalName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ChemicalName = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn TradeName
	{
		[DebuggerNonUserCode]
		get
		{
			return _TradeName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TradeName = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn ExposureBased
	{
		[DebuggerNonUserCode]
		get
		{
			return _ExposureBased;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ExposureBased = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn CASNumber
	{
		[DebuggerNonUserCode]
		get
		{
			return _CASNumber;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CASNumber = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Molecular
	{
		[DebuggerNonUserCode]
		get
		{
			return _Molecular;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Molecular = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn MolWeight
	{
		[DebuggerNonUserCode]
		get
		{
			return _MolWeight;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_MolWeight = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn MWValueType
	{
		[DebuggerNonUserCode]
		get
		{
			return _MWValueType;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_MWValueType = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn WtPercent500
	{
		[DebuggerNonUserCode]
		get
		{
			return _WtPercent500;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_WtPercent500 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn WtPercent1000
	{
		[DebuggerNonUserCode]
		get
		{
			return _WtPercent1000;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_WtPercent1000 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn InitialPV
	{
		[DebuggerNonUserCode]
		get
		{
			return _InitialPV;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_InitialPV = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn MaxPV
	{
		[DebuggerNonUserCode]
		get
		{
			return _MaxPV;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_MaxPV = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Manuf
	{
		[DebuggerNonUserCode]
		get
		{
			return _Manuf;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Manuf = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Import
	{
		[DebuggerNonUserCode]
		get
		{
			return _Import;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Import = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Neat
	{
		[DebuggerNonUserCode]
		get
		{
			return _Neat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Neat = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Process
	{
		[DebuggerNonUserCode]
		get
		{
			return _Process;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Process = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Manufacture
	{
		[DebuggerNonUserCode]
		get
		{
			return _Manufacture;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Manufacture = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn EndUse
	{
		[DebuggerNonUserCode]
		get
		{
			return _EndUse;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_EndUse = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn ConsumerUse
	{
		[DebuggerNonUserCode]
		get
		{
			return _ConsumerUse;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ConsumerUse = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn BPest
	{
		[DebuggerNonUserCode]
		get
		{
			return _BPest;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BPest = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn VPest
	{
		[DebuggerNonUserCode]
		get
		{
			return _VPest;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_VPest = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn WaterSolubEst
	{
		[DebuggerNonUserCode]
		get
		{
			return _WaterSolubEst;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_WaterSolubEst = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn LogP
	{
		[DebuggerNonUserCode]
		get
		{
			return _LogP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LogP = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn SC1
	{
		[DebuggerNonUserCode]
		get
		{
			return _SC1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SC1 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn SC2
	{
		[DebuggerNonUserCode]
		get
		{
			return _SC2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SC2 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn SC3
	{
		[DebuggerNonUserCode]
		get
		{
			return _SC3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SC3 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn SC4
	{
		[DebuggerNonUserCode]
		get
		{
			return _SC4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SC4 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn SC5
	{
		[DebuggerNonUserCode]
		get
		{
			return _SC5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SC5 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn SC6
	{
		[DebuggerNonUserCode]
		get
		{
			return _SC6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SC6 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn SC7
	{
		[DebuggerNonUserCode]
		get
		{
			return _SC7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SC7 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Mer1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Mer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Mer1 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Mer2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Mer2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Mer2 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Mer3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Mer3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Mer3 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Mer4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Mer4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Mer4 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Mer5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Mer5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Mer5 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Mer6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Mer6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Mer6 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Mer7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Mer7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Mer7 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn USE
	{
		[DebuggerNonUserCode]
		get
		{
			return _USE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_USE = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn AddnlInfo
	{
		[DebuggerNonUserCode]
		get
		{
			return _AddnlInfo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_AddnlInfo = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn MP
	{
		[DebuggerNonUserCode]
		get
		{
			return _MP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_MP = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn MPest
	{
		[DebuggerNonUserCode]
		get
		{
			return _MPest;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_MPest = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn VP
	{
		[DebuggerNonUserCode]
		get
		{
			return _VP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_VP = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn WaterSolub
	{
		[DebuggerNonUserCode]
		get
		{
			return _WaterSolub;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_WaterSolub = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn BPPressure
	{
		[DebuggerNonUserCode]
		get
		{
			return _BPPressure;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BPPressure = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn OtherUses
	{
		[DebuggerNonUserCode]
		get
		{
			return _OtherUses;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_OtherUses = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn AddlChemInfo
	{
		[DebuggerNonUserCode]
		get
		{
			return _AddlChemInfo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_AddlChemInfo = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn RevisionDate
	{
		[DebuggerNonUserCode]
		get
		{
			return _RevisionDate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RevisionDate = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn SC8
	{
		[DebuggerNonUserCode]
		get
		{
			return _SC8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SC8 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn SC9
	{
		[DebuggerNonUserCode]
		get
		{
			return _SC9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SC9 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn SC10
	{
		[DebuggerNonUserCode]
		get
		{
			return _SC10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SC10 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Mer8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Mer8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Mer8 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Mer9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Mer9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Mer9 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Mer10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Mer10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Mer10 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn CRSSdate
	{
		[DebuggerNonUserCode]
		get
		{
			return _CRSSdate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CRSSdate = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn BindOption
	{
		[DebuggerNonUserCode]
		get
		{
			return _BindOption;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BindOption = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn LogPest
	{
		[DebuggerNonUserCode]
		get
		{
			return _LogPest;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LogPest = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn SClogP
	{
		[DebuggerNonUserCode]
		get
		{
			return _SClogP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SClogP = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn MerLogP
	{
		[DebuggerNonUserCode]
		get
		{
			return _MerLogP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_MerLogP = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn BP
	{
		[DebuggerNonUserCode]
		get
		{
			return _BP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BP = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn TSnumber
	{
		[DebuggerNonUserCode]
		get
		{
			return _TSnumber;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TSnumber = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn RxnDescription
	{
		[DebuggerNonUserCode]
		get
		{
			return _RxnDescription;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RxnDescription = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn P2concerns
	{
		[DebuggerNonUserCode]
		get
		{
			return _P2concerns;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_P2concerns = value;
		}
	}

	internal virtual DataGridView dgvCRSS
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvCRSS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			DataGridViewCellEventHandler val = new DataGridViewCellEventHandler(dgvCRSS_CellContentClick);
			if (_dgvCRSS != null)
			{
				_dgvCRSS.CellContentClick -= val;
			}
			_dgvCRSS = value;
			if (_dgvCRSS != null)
			{
				_dgvCRSS.CellContentClick += val;
			}
		}
	}

	public static frmViewCRSS DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmViewCRSS();
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

	public frmViewCRSS()
	{
		((Form)this).Load += frmViewCRSS_Load;
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
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected O, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected O, but got Unknown
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected O, but got Unknown
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected O, but got Unknown
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected O, but got Unknown
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected O, but got Unknown
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected O, but got Unknown
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected O, but got Unknown
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected O, but got Unknown
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Expected O, but got Unknown
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected O, but got Unknown
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected O, but got Unknown
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Expected O, but got Unknown
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected O, but got Unknown
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected O, but got Unknown
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected O, but got Unknown
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected O, but got Unknown
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Expected O, but got Unknown
		//IL_1083: Unknown result type (might be due to invalid IL or missing references)
		//IL_108d: Expected O, but got Unknown
		//IL_10a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ac: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmViewCRSS));
		ToolTip1 = new ToolTip(components);
		cmdClose = new Button();
		dgvCRSS = new DataGridView();
		PMNnumber = new DataGridViewTextBoxColumn();
		Chemist = new DataGridViewTextBoxColumn();
		Submitter = new DataGridViewTextBoxColumn();
		ChemicalName = new DataGridViewTextBoxColumn();
		TradeName = new DataGridViewTextBoxColumn();
		ExposureBased = new DataGridViewTextBoxColumn();
		CASNumber = new DataGridViewTextBoxColumn();
		Molecular = new DataGridViewTextBoxColumn();
		MolWeight = new DataGridViewTextBoxColumn();
		MWValueType = new DataGridViewTextBoxColumn();
		WtPercent500 = new DataGridViewTextBoxColumn();
		WtPercent1000 = new DataGridViewTextBoxColumn();
		InitialPV = new DataGridViewTextBoxColumn();
		MaxPV = new DataGridViewTextBoxColumn();
		Manuf = new DataGridViewTextBoxColumn();
		Import = new DataGridViewTextBoxColumn();
		Neat = new DataGridViewTextBoxColumn();
		Process = new DataGridViewTextBoxColumn();
		Manufacture = new DataGridViewTextBoxColumn();
		EndUse = new DataGridViewTextBoxColumn();
		ConsumerUse = new DataGridViewTextBoxColumn();
		BPest = new DataGridViewTextBoxColumn();
		VPest = new DataGridViewTextBoxColumn();
		WaterSolubEst = new DataGridViewTextBoxColumn();
		LogP = new DataGridViewTextBoxColumn();
		SC1 = new DataGridViewTextBoxColumn();
		SC2 = new DataGridViewTextBoxColumn();
		SC3 = new DataGridViewTextBoxColumn();
		SC4 = new DataGridViewTextBoxColumn();
		SC5 = new DataGridViewTextBoxColumn();
		SC6 = new DataGridViewTextBoxColumn();
		SC7 = new DataGridViewTextBoxColumn();
		Mer1 = new DataGridViewTextBoxColumn();
		Mer2 = new DataGridViewTextBoxColumn();
		Mer3 = new DataGridViewTextBoxColumn();
		Mer4 = new DataGridViewTextBoxColumn();
		Mer5 = new DataGridViewTextBoxColumn();
		Mer6 = new DataGridViewTextBoxColumn();
		Mer7 = new DataGridViewTextBoxColumn();
		USE = new DataGridViewTextBoxColumn();
		AddnlInfo = new DataGridViewTextBoxColumn();
		MP = new DataGridViewTextBoxColumn();
		MPest = new DataGridViewTextBoxColumn();
		VP = new DataGridViewTextBoxColumn();
		WaterSolub = new DataGridViewTextBoxColumn();
		BPPressure = new DataGridViewTextBoxColumn();
		OtherUses = new DataGridViewTextBoxColumn();
		AddlChemInfo = new DataGridViewTextBoxColumn();
		RevisionDate = new DataGridViewTextBoxColumn();
		SC8 = new DataGridViewTextBoxColumn();
		SC9 = new DataGridViewTextBoxColumn();
		SC10 = new DataGridViewTextBoxColumn();
		Mer8 = new DataGridViewTextBoxColumn();
		Mer9 = new DataGridViewTextBoxColumn();
		Mer10 = new DataGridViewTextBoxColumn();
		CRSSdate = new DataGridViewTextBoxColumn();
		BindOption = new DataGridViewTextBoxColumn();
		LogPest = new DataGridViewTextBoxColumn();
		SClogP = new DataGridViewTextBoxColumn();
		MerLogP = new DataGridViewTextBoxColumn();
		BP = new DataGridViewTextBoxColumn();
		TSnumber = new DataGridViewTextBoxColumn();
		RxnDescription = new DataGridViewTextBoxColumn();
		P2concerns = new DataGridViewTextBoxColumn();
		((ISupportInitialize)dgvCRSS).BeginInit();
		((Control)this).SuspendLayout();
		((ButtonBase)cmdClose).BackColor = SystemColors.Control;
		((Control)cmdClose).Cursor = Cursors.Default;
		((Control)cmdClose).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdClose).ForeColor = SystemColors.ControlText;
		Button obj = cmdClose;
		Point location = new Point(320, 272);
		((Control)obj).Location = location;
		((Control)cmdClose).Name = "cmdClose";
		((Control)cmdClose).RightToLeft = (RightToLeft)0;
		Button obj2 = cmdClose;
		Size size = new Size(89, 25);
		((Control)obj2).Size = size;
		((Control)cmdClose).TabIndex = 1;
		((ButtonBase)cmdClose).Text = "&Close Window";
		((ButtonBase)cmdClose).UseVisualStyleBackColor = false;
		dgvCRSS.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		dgvCRSS.Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[64]
		{
			(DataGridViewColumn)PMNnumber,
			(DataGridViewColumn)Chemist,
			(DataGridViewColumn)Submitter,
			(DataGridViewColumn)ChemicalName,
			(DataGridViewColumn)TradeName,
			(DataGridViewColumn)ExposureBased,
			(DataGridViewColumn)CASNumber,
			(DataGridViewColumn)Molecular,
			(DataGridViewColumn)MolWeight,
			(DataGridViewColumn)MWValueType,
			(DataGridViewColumn)WtPercent500,
			(DataGridViewColumn)WtPercent1000,
			(DataGridViewColumn)InitialPV,
			(DataGridViewColumn)MaxPV,
			(DataGridViewColumn)Manuf,
			(DataGridViewColumn)Import,
			(DataGridViewColumn)Neat,
			(DataGridViewColumn)Process,
			(DataGridViewColumn)Manufacture,
			(DataGridViewColumn)EndUse,
			(DataGridViewColumn)ConsumerUse,
			(DataGridViewColumn)BPest,
			(DataGridViewColumn)VPest,
			(DataGridViewColumn)WaterSolubEst,
			(DataGridViewColumn)LogP,
			(DataGridViewColumn)SC1,
			(DataGridViewColumn)SC2,
			(DataGridViewColumn)SC3,
			(DataGridViewColumn)SC4,
			(DataGridViewColumn)SC5,
			(DataGridViewColumn)SC6,
			(DataGridViewColumn)SC7,
			(DataGridViewColumn)Mer1,
			(DataGridViewColumn)Mer2,
			(DataGridViewColumn)Mer3,
			(DataGridViewColumn)Mer4,
			(DataGridViewColumn)Mer5,
			(DataGridViewColumn)Mer6,
			(DataGridViewColumn)Mer7,
			(DataGridViewColumn)USE,
			(DataGridViewColumn)AddnlInfo,
			(DataGridViewColumn)MP,
			(DataGridViewColumn)MPest,
			(DataGridViewColumn)VP,
			(DataGridViewColumn)WaterSolub,
			(DataGridViewColumn)BPPressure,
			(DataGridViewColumn)OtherUses,
			(DataGridViewColumn)AddlChemInfo,
			(DataGridViewColumn)RevisionDate,
			(DataGridViewColumn)SC8,
			(DataGridViewColumn)SC9,
			(DataGridViewColumn)SC10,
			(DataGridViewColumn)Mer8,
			(DataGridViewColumn)Mer9,
			(DataGridViewColumn)Mer10,
			(DataGridViewColumn)CRSSdate,
			(DataGridViewColumn)BindOption,
			(DataGridViewColumn)LogPest,
			(DataGridViewColumn)SClogP,
			(DataGridViewColumn)MerLogP,
			(DataGridViewColumn)BP,
			(DataGridViewColumn)TSnumber,
			(DataGridViewColumn)RxnDescription,
			(DataGridViewColumn)P2concerns
		});
		DataGridView obj3 = dgvCRSS;
		location = new Point(12, 24);
		((Control)obj3).Location = location;
		((Control)dgvCRSS).Name = "dgvCRSS";
		DataGridView obj4 = dgvCRSS;
		size = new Size(1235, 242);
		((Control)obj4).Size = size;
		((Control)dgvCRSS).TabIndex = 2;
		((DataGridViewColumn)PMNnumber).HeaderText = "PMN Number";
		((DataGridViewColumn)PMNnumber).Name = "PMNnumber";
		((DataGridViewColumn)Chemist).HeaderText = "Chemist";
		((DataGridViewColumn)Chemist).Name = "Chemist";
		((DataGridViewColumn)Submitter).HeaderText = "Submitter";
		((DataGridViewColumn)Submitter).Name = "Submitter";
		((DataGridViewColumn)ChemicalName).HeaderText = "Chemical Name";
		((DataGridViewColumn)ChemicalName).Name = "ChemicalName";
		((DataGridViewColumn)TradeName).HeaderText = "Trade Name";
		((DataGridViewColumn)TradeName).Name = "TradeName";
		((DataGridViewColumn)ExposureBased).HeaderText = "Exposure Based";
		((DataGridViewColumn)ExposureBased).Name = "ExposureBased";
		((DataGridViewColumn)CASNumber).HeaderText = "CAS Number";
		((DataGridViewColumn)CASNumber).Name = "CASNumber";
		((DataGridViewColumn)Molecular).HeaderText = "Molecular Formula";
		((DataGridViewColumn)Molecular).Name = "Molecular";
		((DataGridViewColumn)MolWeight).HeaderText = "Mol Weight";
		((DataGridViewColumn)MolWeight).Name = "MolWeight";
		((DataGridViewColumn)MWValueType).HeaderText = "MW Value Type";
		((DataGridViewColumn)MWValueType).Name = "MWValueType";
		((DataGridViewColumn)WtPercent500).HeaderText = "Wt Percent 500";
		((DataGridViewColumn)WtPercent500).Name = "WtPercent500";
		((DataGridViewColumn)WtPercent1000).HeaderText = "Wt Percent 1000";
		((DataGridViewColumn)WtPercent1000).Name = "WtPercent1000";
		((DataGridViewColumn)InitialPV).HeaderText = "Initial PV";
		((DataGridViewColumn)InitialPV).Name = "InitialPV";
		((DataGridViewColumn)MaxPV).HeaderText = "Max PV";
		((DataGridViewColumn)MaxPV).Name = "MaxPV";
		((DataGridViewColumn)Manuf).HeaderText = "Manuf";
		((DataGridViewColumn)Manuf).Name = "Manuf";
		((DataGridViewColumn)Import).HeaderText = "Import";
		((DataGridViewColumn)Import).Name = "Import";
		((DataGridViewColumn)Neat).HeaderText = "Neat";
		((DataGridViewColumn)Neat).Name = "Neat";
		((DataGridViewColumn)Process).HeaderText = "Process";
		((DataGridViewColumn)Process).Name = "Process";
		((DataGridViewColumn)Manufacture).HeaderText = "Manufacture";
		((DataGridViewColumn)Manufacture).Name = "Manufacture";
		((DataGridViewColumn)EndUse).HeaderText = "End Use";
		((DataGridViewColumn)EndUse).Name = "EndUse";
		((DataGridViewColumn)ConsumerUse).HeaderText = "Consumer Use";
		((DataGridViewColumn)ConsumerUse).Name = "ConsumerUse";
		((DataGridViewColumn)BPest).HeaderText = "BP Est";
		((DataGridViewColumn)BPest).Name = "BPest";
		((DataGridViewColumn)VPest).HeaderText = "VP Est";
		((DataGridViewColumn)VPest).Name = "VPest";
		((DataGridViewColumn)WaterSolubEst).HeaderText = "Water Solub Est";
		((DataGridViewColumn)WaterSolubEst).Name = "WaterSolubEst";
		((DataGridViewColumn)LogP).HeaderText = "Log P";
		((DataGridViewColumn)LogP).Name = "LogP";
		((DataGridViewColumn)SC1).HeaderText = "S/C 1";
		((DataGridViewColumn)SC1).Name = "SC1";
		((DataGridViewColumn)SC2).HeaderText = "S/C 2";
		((DataGridViewColumn)SC2).Name = "SC2";
		((DataGridViewColumn)SC3).HeaderText = "S/C 3";
		((DataGridViewColumn)SC3).Name = "SC3";
		((DataGridViewColumn)SC4).HeaderText = "S/C 4";
		((DataGridViewColumn)SC4).Name = "SC4";
		((DataGridViewColumn)SC5).HeaderText = "S/C 5";
		((DataGridViewColumn)SC5).Name = "SC5";
		((DataGridViewColumn)SC6).HeaderText = "S/C 6";
		((DataGridViewColumn)SC6).Name = "SC6";
		((DataGridViewColumn)SC7).HeaderText = "S/C 7";
		((DataGridViewColumn)SC7).Name = "SC7";
		((DataGridViewColumn)Mer1).HeaderText = "Mer 1";
		((DataGridViewColumn)Mer1).Name = "Mer1";
		((DataGridViewColumn)Mer2).HeaderText = "Mer 2";
		((DataGridViewColumn)Mer2).Name = "Mer2";
		((DataGridViewColumn)Mer3).HeaderText = "Mer 3";
		((DataGridViewColumn)Mer3).Name = "Mer3";
		((DataGridViewColumn)Mer4).HeaderText = "Mer 4";
		((DataGridViewColumn)Mer4).Name = "Mer4";
		((DataGridViewColumn)Mer5).HeaderText = "Mer 5";
		((DataGridViewColumn)Mer5).Name = "Mer5";
		((DataGridViewColumn)Mer6).HeaderText = "Mer 6";
		((DataGridViewColumn)Mer6).Name = "Mer6";
		((DataGridViewColumn)Mer7).HeaderText = "Mer 7";
		((DataGridViewColumn)Mer7).Name = "Mer7";
		((DataGridViewColumn)USE).HeaderText = "USE";
		((DataGridViewColumn)USE).Name = "USE";
		((DataGridViewColumn)AddnlInfo).HeaderText = "Additional Info";
		((DataGridViewColumn)AddnlInfo).Name = "AddnlInfo";
		((DataGridViewColumn)MP).HeaderText = "MP";
		((DataGridViewColumn)MP).Name = "MP";
		((DataGridViewColumn)MPest).HeaderText = "MP est";
		((DataGridViewColumn)MPest).Name = "MPest";
		((DataGridViewColumn)VP).HeaderText = "VP";
		((DataGridViewColumn)VP).Name = "VP";
		((DataGridViewColumn)WaterSolub).HeaderText = "Water Solub";
		((DataGridViewColumn)WaterSolub).Name = "WaterSolub";
		((DataGridViewColumn)BPPressure).HeaderText = "BP Pressure";
		((DataGridViewColumn)BPPressure).Name = "BPPressure";
		((DataGridViewColumn)OtherUses).HeaderText = "Other Uses";
		((DataGridViewColumn)OtherUses).Name = "OtherUses";
		((DataGridViewColumn)AddlChemInfo).HeaderText = "Addl Chem Info";
		((DataGridViewColumn)AddlChemInfo).Name = "AddlChemInfo";
		((DataGridViewColumn)RevisionDate).HeaderText = "Revision Date";
		((DataGridViewColumn)RevisionDate).Name = "RevisionDate";
		((DataGridViewColumn)SC8).HeaderText = "S/C 8";
		((DataGridViewColumn)SC8).Name = "SC8";
		((DataGridViewColumn)SC9).HeaderText = "S/C 9";
		((DataGridViewColumn)SC9).Name = "SC9";
		((DataGridViewColumn)SC10).HeaderText = "S/C 10";
		((DataGridViewColumn)SC10).Name = "SC10";
		((DataGridViewColumn)Mer8).HeaderText = "Mer 8";
		((DataGridViewColumn)Mer8).Name = "Mer8";
		((DataGridViewColumn)Mer9).HeaderText = "Mer 9";
		((DataGridViewColumn)Mer9).Name = "Mer9";
		((DataGridViewColumn)Mer10).HeaderText = "Mer 10";
		((DataGridViewColumn)Mer10).Name = "Mer10";
		((DataGridViewColumn)CRSSdate).HeaderText = "CRSS Date";
		((DataGridViewColumn)CRSSdate).Name = "CRSSdate";
		((DataGridViewColumn)BindOption).HeaderText = "Bind Option";
		((DataGridViewColumn)BindOption).Name = "BindOption";
		((DataGridViewColumn)LogPest).HeaderText = "Log P Est";
		((DataGridViewColumn)LogPest).Name = "LogPest";
		((DataGridViewColumn)SClogP).HeaderText = "S/C log P";
		((DataGridViewColumn)SClogP).Name = "SClogP";
		((DataGridViewColumn)MerLogP).HeaderText = "Mer Log P";
		((DataGridViewColumn)MerLogP).Name = "MerLogP";
		((DataGridViewColumn)BP).HeaderText = "BP";
		((DataGridViewColumn)BP).Name = "BP";
		((DataGridViewColumn)TSnumber).HeaderText = "TS Number";
		((DataGridViewColumn)TSnumber).Name = "TSnumber";
		((DataGridViewColumn)RxnDescription).HeaderText = "Rxn Description";
		((DataGridViewColumn)RxnDescription).Name = "RxnDescription";
		((DataGridViewColumn)P2concerns).HeaderText = "P2 Concerns";
		((DataGridViewColumn)P2concerns).Name = "P2concerns";
		size = new Size(5, 13);
		((Form)this).AutoScaleBaseSize = size;
		size = new Size(1259, 315);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)dgvCRSS);
		((Control)this).Controls.Add((Control)(object)cmdClose);
		((Control)this).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		location = new Point(10, 150);
		((Form)this).Location = location;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmViewCRSS";
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "View CRSS Report";
		((ISupportInitialize)dgvCRSS).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public bool SetUp(Connection conn, ref string sEPAID)
	{
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		recordset.CursorLocation = CursorLocationEnum.adUseClient;
		recordset.Open("SELECT * FROM Chemsteer WHERE [PMN number]='" + sEPAID + "'", conn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
		dgvCRSS.Rows.Clear();
		while (!recordset.EOF)
		{
			dgvCRSS.Rows.Add(new object[64]
			{
				RuntimeHelpers.GetObjectValue(recordset.Fields["PMN number"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["Chemist"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["Submitter"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["chemical name"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["Trade name"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["Exposure based"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["CAS number"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["Molecular Formula"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["Mol weight"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["MW Value type"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["Wt percent 500"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["Wt Percent 1000"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["Initial PV"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["Max PV"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["Manuf"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["Import"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["Neat"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["Process"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["Manufacture"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["End Use"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["Consumer Use"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["BP est"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["VP est"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["Water solub est"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["Log P"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["S/C 1"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["S/C 2"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["S/C 3"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["S/C 4"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["S/C 5"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["S/C 6"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["S/C 7"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["Mer 1"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["Mer 2"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["Mer 3"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["Mer 4"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["Mer 5"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["Mer 6"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["Mer 7"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["USE"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["addnl info"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["MP"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["MP est"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["VP"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["Water solub"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["BP pressure"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["Other uses"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["addl chem info"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["revision date"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["S/C 8"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["S/C 9"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["S/C 10"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["Mer 8"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["Mer 9"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["Mer 10"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["CRSS date"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["Bind option"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["Log P est"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["S/C log P"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["Mer Log P"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["BP"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["TS number"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["Rxn description"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["P2 concerns"].Value)
			});
			recordset.MoveNext();
		}
		recordset.Close();
		return true;
	}

	private void cmdClose_Click(object eventSender, EventArgs eventArgs)
	{
		((Form)this).Close();
	}

	private void frmViewCRSS_Load(object eventSender, EventArgs eventArgs)
	{
	}

	private void dbgCRSS_AfterColUpdate(object sender, DBGridEvents_AfterColUpdateEvent e)
	{
	}

	private void dgvCRSS_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}
}
