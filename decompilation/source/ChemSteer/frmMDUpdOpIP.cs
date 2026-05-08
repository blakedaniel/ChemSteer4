using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ADODB;
using AxMSComctlLib;
using MSComctlLib;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Compatibility.VB6;
using Microsoft.VisualBasic.CompilerServices;

namespace ChemSteer;

internal class frmMDUpdOpIP : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("cmdCalcDMxChem")]
	private Button _cmdCalcDMxChem;

	[AccessedThroughProperty("cmdCalcYprod")]
	private Button _cmdCalcYprod;

	[AccessedThroughProperty("cmdCalcNS")]
	private Button _cmdCalcNS;

	[AccessedThroughProperty("cmdRestoreDefaults")]
	private Button _cmdRestoreDefaults;

	[AccessedThroughProperty("cmdCalcXmoProd")]
	private Button _cmdCalcXmoProd;

	[AccessedThroughProperty("cmdCalcOthers")]
	private Button _cmdCalcOthers;

	[AccessedThroughProperty("_chkKnowns1_0")]
	private CheckBox __chkKnowns1_0;

	[AccessedThroughProperty("_chkKnowns1_1")]
	private CheckBox __chkKnowns1_1;

	[AccessedThroughProperty("_chkKnowns1_2")]
	private CheckBox __chkKnowns1_2;

	[AccessedThroughProperty("_txtKnowns_0")]
	private TextBox __txtKnowns_0;

	[AccessedThroughProperty("_chkKnowns1_4")]
	private CheckBox __chkKnowns1_4;

	[AccessedThroughProperty("_chkKnowns1_3")]
	private CheckBox __chkKnowns1_3;

	[AccessedThroughProperty("_txtKnowns_1")]
	private TextBox __txtKnowns_1;

	[AccessedThroughProperty("_txtKnowns_2")]
	private TextBox __txtKnowns_2;

	[AccessedThroughProperty("_txtKnowns_3")]
	private TextBox __txtKnowns_3;

	[AccessedThroughProperty("_txtKnowns_4")]
	private TextBox __txtKnowns_4;

	[AccessedThroughProperty("_Line1_3")]
	private Label __Line1_3;

	[AccessedThroughProperty("_Line1_2")]
	private Label __Line1_2;

	[AccessedThroughProperty("_Line1_9")]
	private Label __Line1_9;

	[AccessedThroughProperty("_Label1_1")]
	private Label __Label1_1;

	[AccessedThroughProperty("_Label1_0")]
	private Label __Label1_0;

	[AccessedThroughProperty("_Line1_6")]
	private Label __Line1_6;

	[AccessedThroughProperty("_Line1_10")]
	private Label __Line1_10;

	[AccessedThroughProperty("_fraTab2_0")]
	private GroupBox __fraTab2_0;

	[AccessedThroughProperty("cmdCalcDefaults")]
	private Button _cmdCalcDefaults;

	[AccessedThroughProperty("_txtOther_0")]
	private TextBox __txtOther_0;

	[AccessedThroughProperty("_txtOther_1")]
	private TextBox __txtOther_1;

	[AccessedThroughProperty("_txtOther_2")]
	private TextBox __txtOther_2;

	[AccessedThroughProperty("_cmdRecalc_0")]
	private Button __cmdRecalc_0;

	[AccessedThroughProperty("_chkOther_0")]
	private CheckBox __chkOther_0;

	[AccessedThroughProperty("_chkOther_1")]
	private CheckBox __chkOther_1;

	[AccessedThroughProperty("_chkOther_2")]
	private CheckBox __chkOther_2;

	[AccessedThroughProperty("_cmdRecalc_1")]
	private Button __cmdRecalc_1;

	[AccessedThroughProperty("_cmdRecalc_2")]
	private Button __cmdRecalc_2;

	[AccessedThroughProperty("_Label1_9")]
	private Label __Label1_9;

	[AccessedThroughProperty("_fraTab2_1")]
	private GroupBox __fraTab2_1;

	[AccessedThroughProperty("_lbl5PctError_0")]
	private Label __lbl5PctError_0;

	[AccessedThroughProperty("_lblInstructions_1")]
	private Label __lblInstructions_1;

	[AccessedThroughProperty("_fraStep_1")]
	private GroupBox __fraStep_1;

	[AccessedThroughProperty("_optInfOrEff_1")]
	private RadioButton __optInfOrEff_1;

	[AccessedThroughProperty("_optInfOrEff_0")]
	private RadioButton __optInfOrEff_0;

	[AccessedThroughProperty("_Frame1_1")]
	private Panel __Frame1_1;

	[AccessedThroughProperty("_optContOrBatch_1")]
	private RadioButton __optContOrBatch_1;

	[AccessedThroughProperty("_optContOrBatch_0")]
	private RadioButton __optContOrBatch_0;

	[AccessedThroughProperty("_Frame1_0")]
	private Panel __Frame1_0;

	[AccessedThroughProperty("_Line1_4")]
	private Label __Line1_4;

	[AccessedThroughProperty("lblMassBalMsg")]
	private Label _lblMassBalMsg;

	[AccessedThroughProperty("lblMyPVop")]
	private Label _lblMyPVop;

	[AccessedThroughProperty("_Line1_0")]
	private Label __Line1_0;

	[AccessedThroughProperty("_lblInstructions_2")]
	private Label __lblInstructions_2;

	[AccessedThroughProperty("_Line1_1")]
	private Label __Line1_1;

	[AccessedThroughProperty("_lblInstructions_0")]
	private Label __lblInstructions_0;

	[AccessedThroughProperty("_fraStep_0")]
	private GroupBox __fraStep_0;

	[AccessedThroughProperty("cmdBasis")]
	private Button _cmdBasis;

	[AccessedThroughProperty("cmdHelp")]
	private Button _cmdHelp;

	[AccessedThroughProperty("cmdFinish")]
	private Button _cmdFinish;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("_lblError_0")]
	private Label __lblError_0;

	[AccessedThroughProperty("_lblError_1")]
	private Label __lblError_1;

	[AccessedThroughProperty("_fraStep_3")]
	private GroupBox __fraStep_3;

	[AccessedThroughProperty("_txtOBatch1_2")]
	private TextBox __txtOBatch1_2;

	[AccessedThroughProperty("_txtOBatch1_0")]
	private TextBox __txtOBatch1_0;

	[AccessedThroughProperty("_txtOBatch1_1")]
	private TextBox __txtOBatch1_1;

	[AccessedThroughProperty("_lblInstructions_3")]
	private Label __lblInstructions_3;

	[AccessedThroughProperty("_Label1_11")]
	private Label __Label1_11;

	[AccessedThroughProperty("_Label1_7")]
	private Label __Label1_7;

	[AccessedThroughProperty("_Label1_8")]
	private Label __Label1_8;

	[AccessedThroughProperty("_fraTab3_0")]
	private GroupBox __fraTab3_0;

	[AccessedThroughProperty("cmdCalcBatchParms")]
	private Button _cmdCalcBatchParms;

	[AccessedThroughProperty("_cmdBatchRecalc_2")]
	private Button __cmdBatchRecalc_2;

	[AccessedThroughProperty("_chkOBatch2_0")]
	private CheckBox __chkOBatch2_0;

	[AccessedThroughProperty("_txtOBatch2_0")]
	private TextBox __txtOBatch2_0;

	[AccessedThroughProperty("_cmdBatchRecalc_0")]
	private Button __cmdBatchRecalc_0;

	[AccessedThroughProperty("_chkOBatch2_1")]
	private CheckBox __chkOBatch2_1;

	[AccessedThroughProperty("_txtOBatch2_1")]
	private TextBox __txtOBatch2_1;

	[AccessedThroughProperty("_cmdBatchRecalc_1")]
	private Button __cmdBatchRecalc_1;

	[AccessedThroughProperty("_chkOBatch2_2")]
	private CheckBox __chkOBatch2_2;

	[AccessedThroughProperty("_txtOBatch2_2")]
	private TextBox __txtOBatch2_2;

	[AccessedThroughProperty("txtOBatch3")]
	private TextBox _txtOBatch3;

	[AccessedThroughProperty("_lblInstructions_4")]
	private Label __lblInstructions_4;

	[AccessedThroughProperty("_Label1_10")]
	private Label __Label1_10;

	[AccessedThroughProperty("_fraTab3_1")]
	private GroupBox __fraTab3_1;

	[AccessedThroughProperty("_lbl5PctError_1")]
	private Label __lbl5PctError_1;

	[AccessedThroughProperty("_fraStep_2")]
	private GroupBox __fraStep_2;

	[AccessedThroughProperty("tabs")]
	private AxTabStrip _tabs;

	[AccessedThroughProperty("lblOp")]
	private Label _lblOp;

	[AccessedThroughProperty("Frame1")]
	private PanelArray _Frame1;

	[AccessedThroughProperty("Label1")]
	private LabelArray _Label1;

	[AccessedThroughProperty("Line1")]
	private LabelArray _Line1;

	[AccessedThroughProperty("chkKnowns1")]
	private CheckBoxArray _chkKnowns1;

	[AccessedThroughProperty("chkOBatch2")]
	private CheckBoxArray _chkOBatch2;

	[AccessedThroughProperty("chkOther")]
	private CheckBoxArray _chkOther;

	[AccessedThroughProperty("cmdBatchRecalc")]
	private ButtonArray _cmdBatchRecalc;

	[AccessedThroughProperty("cmdRecalc")]
	private ButtonArray _cmdRecalc;

	[AccessedThroughProperty("fraStep")]
	private GroupBoxArray _fraStep;

	[AccessedThroughProperty("fraTab2")]
	private GroupBoxArray _fraTab2;

	[AccessedThroughProperty("fraTab3")]
	private GroupBoxArray _fraTab3;

	[AccessedThroughProperty("lbl5PctError")]
	private LabelArray _lbl5PctError;

	[AccessedThroughProperty("lblError")]
	private LabelArray _lblError;

	[AccessedThroughProperty("lblInstructions")]
	private LabelArray _lblInstructions;

	[AccessedThroughProperty("optContOrBatch")]
	private RadioButtonArray _optContOrBatch;

	[AccessedThroughProperty("optInfOrEff")]
	private RadioButtonArray _optInfOrEff;

	[AccessedThroughProperty("txtKnowns")]
	private TextBoxArray _txtKnowns;

	[AccessedThroughProperty("txtOBatch1")]
	private TextBoxArray _txtOBatch1;

	[AccessedThroughProperty("txtOBatch2")]
	private TextBoxArray _txtOBatch2;

	[AccessedThroughProperty("txtOther")]
	private TextBoxArray _txtOther;

	private static frmMDUpdOpIP m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	private short step_Renamed;

	public double MyPvOp;

	private float sYprodFromPrevOp;

	private bool bSettingGroup4Defaults;

	private bool bFinishing;

	private bool bDontDisable;

	private bool bTab2Done;

	private int[] arMyMassBalDisc;

	private bool bEnableCmdCalcXmoProd;

	private bool bEnableCmdCalcNS;

	private bool bEnableCmdCalcYprod;

	public float sVcar;

	public float sDprod;

	public float sNcar;

	public float sVpaint;

	public float sVbatch;

	public float sDrm;

	public float sDVIppaint;

	public float sRRctw;

	public float sYctw;

	public float sHD;

	public float sDctw;

	public float sLFb;

	public float sLFw;

	public float sLFe;

	public float sDRRchem;

	public float sDMUchem;

	public short sYctwOption;

	public string sYctwOther;

	public short sRRctwOption;

	public float sYaddtv;

	public float sADMUaddtv;

	public float sDMIchem;

	public float sDMIrm;

	public float sYbath;

	public float sYrinse;

	public float sDbath;

	public float sDrinse;

	public float sVbath;

	public float sNbath;

	public float sFreqbath;

	public float sDVrinse;

	public float sRinseE;

	public float sADMUchem;

	public float sOD;

	public short iFixVbath;

	public short iFixDVRinse;

	public short iFixYrinse;

	public short iSequence;

	public bool bElecError;

	public bool bElecMBCheck;

	private float[,] COFarOpParms;

	private short[,] COFarOpParmsType;

	private short[,] COFarGssOptions;

	private string[,] COFarGssOther;

	private bool bGssDefaultsWereSet;

	public short pOption;

	public float pHMxChem;

	public float pHD;

	private bool bODMsgDisplayed;

	[SpecialName]
	private bool _0024STATIC_0024chkKnowns1_CheckStateChanged_002420211C1271_0024PreventRecursion;

	[SpecialName]
	private bool _0024STATIC_0024chkOBatch2_CheckStateChanged_002420211C1271_0024PreventRecursion;

	[SpecialName]
	private bool _0024STATIC_0024chkOther_CheckStateChanged_002420211C1271_0024PreventRecursion;

	[SpecialName]
	private bool _0024STATIC_0024checkChkKnowns_002420116_0024PreventRecursion;

	[SpecialName]
	private bool _0024STATIC_0024checkChkOther_002420116_0024PreventRecursion;

	[SpecialName]
	private bool _0024STATIC_0024checkChkOBatch_002420116_0024PreventRecursion;

	public virtual Button cmdCalcDMxChem
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdCalcDMxChem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdCalcDMxChem_Click;
			if (_cmdCalcDMxChem != null)
			{
				((Control)_cmdCalcDMxChem).Click -= eventHandler;
			}
			_cmdCalcDMxChem = value;
			if (_cmdCalcDMxChem != null)
			{
				((Control)_cmdCalcDMxChem).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdCalcYprod
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdCalcYprod;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdCalcYprod_Click;
			if (_cmdCalcYprod != null)
			{
				((Control)_cmdCalcYprod).Click -= eventHandler;
			}
			_cmdCalcYprod = value;
			if (_cmdCalcYprod != null)
			{
				((Control)_cmdCalcYprod).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdCalcNS
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdCalcNS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdCalcNS_Click;
			if (_cmdCalcNS != null)
			{
				((Control)_cmdCalcNS).Click -= eventHandler;
			}
			_cmdCalcNS = value;
			if (_cmdCalcNS != null)
			{
				((Control)_cmdCalcNS).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdRestoreDefaults
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdRestoreDefaults;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdRestoreDefaults_Click;
			if (_cmdRestoreDefaults != null)
			{
				((Control)_cmdRestoreDefaults).Click -= eventHandler;
			}
			_cmdRestoreDefaults = value;
			if (_cmdRestoreDefaults != null)
			{
				((Control)_cmdRestoreDefaults).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdCalcXmoProd
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdCalcXmoProd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdCalcXmoProd_Click;
			if (_cmdCalcXmoProd != null)
			{
				((Control)_cmdCalcXmoProd).Click -= eventHandler;
			}
			_cmdCalcXmoProd = value;
			if (_cmdCalcXmoProd != null)
			{
				((Control)_cmdCalcXmoProd).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdCalcOthers
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdCalcOthers;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdCalcOthers_Click;
			if (_cmdCalcOthers != null)
			{
				((Control)_cmdCalcOthers).Click -= eventHandler;
			}
			_cmdCalcOthers = value;
			if (_cmdCalcOthers != null)
			{
				((Control)_cmdCalcOthers).Click += eventHandler;
			}
		}
	}

	public virtual CheckBox _chkKnowns1_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __chkKnowns1_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _chkKnowns1_0_CheckStateChanged;
			if (__chkKnowns1_0 != null)
			{
				__chkKnowns1_0.CheckStateChanged -= eventHandler;
			}
			__chkKnowns1_0 = value;
			if (__chkKnowns1_0 != null)
			{
				__chkKnowns1_0.CheckStateChanged += eventHandler;
			}
		}
	}

	public virtual CheckBox _chkKnowns1_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __chkKnowns1_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _chkKnowns1_1_CheckStateChanged;
			if (__chkKnowns1_1 != null)
			{
				__chkKnowns1_1.CheckStateChanged -= eventHandler;
			}
			__chkKnowns1_1 = value;
			if (__chkKnowns1_1 != null)
			{
				__chkKnowns1_1.CheckStateChanged += eventHandler;
			}
		}
	}

	public virtual CheckBox _chkKnowns1_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __chkKnowns1_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _chkKnowns1_2_CheckStateChanged;
			if (__chkKnowns1_2 != null)
			{
				__chkKnowns1_2.CheckStateChanged -= eventHandler;
			}
			__chkKnowns1_2 = value;
			if (__chkKnowns1_2 != null)
			{
				__chkKnowns1_2.CheckStateChanged += eventHandler;
			}
		}
	}

	public virtual TextBox _txtKnowns_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtKnowns_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtKnowns_0 = value;
		}
	}

	public virtual CheckBox _chkKnowns1_4
	{
		[DebuggerNonUserCode]
		get
		{
			return __chkKnowns1_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _chkKnowns1_4_CheckStateChanged;
			if (__chkKnowns1_4 != null)
			{
				__chkKnowns1_4.CheckStateChanged -= eventHandler;
			}
			__chkKnowns1_4 = value;
			if (__chkKnowns1_4 != null)
			{
				__chkKnowns1_4.CheckStateChanged += eventHandler;
			}
		}
	}

	public virtual CheckBox _chkKnowns1_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __chkKnowns1_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _chkKnowns1_3_CheckStateChanged;
			if (__chkKnowns1_3 != null)
			{
				__chkKnowns1_3.CheckStateChanged -= eventHandler;
			}
			__chkKnowns1_3 = value;
			if (__chkKnowns1_3 != null)
			{
				__chkKnowns1_3.CheckStateChanged += eventHandler;
			}
		}
	}

	public virtual TextBox _txtKnowns_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtKnowns_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtKnowns_1 = value;
		}
	}

	public virtual TextBox _txtKnowns_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtKnowns_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtKnowns_2 = value;
		}
	}

	public virtual TextBox _txtKnowns_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtKnowns_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtKnowns_3 = value;
		}
	}

	public virtual TextBox _txtKnowns_4
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtKnowns_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtKnowns_4 = value;
		}
	}

	public virtual Label _Line1_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __Line1_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Line1_3 = value;
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

	public virtual Label _Line1_9
	{
		[DebuggerNonUserCode]
		get
		{
			return __Line1_9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Line1_9 = value;
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

	public virtual Label _Line1_6
	{
		[DebuggerNonUserCode]
		get
		{
			return __Line1_6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Line1_6 = value;
		}
	}

	public virtual Label _Line1_10
	{
		[DebuggerNonUserCode]
		get
		{
			return __Line1_10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Line1_10 = value;
		}
	}

	public virtual GroupBox _fraTab2_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraTab2_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraTab2_0 = value;
		}
	}

	public virtual Button cmdCalcDefaults
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdCalcDefaults;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdCalcDefaults_Click;
			if (_cmdCalcDefaults != null)
			{
				((Control)_cmdCalcDefaults).Click -= eventHandler;
			}
			_cmdCalcDefaults = value;
			if (_cmdCalcDefaults != null)
			{
				((Control)_cmdCalcDefaults).Click += eventHandler;
			}
		}
	}

	public virtual TextBox _txtOther_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtOther_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtOther_0 = value;
		}
	}

	public virtual TextBox _txtOther_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtOther_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtOther_1 = value;
		}
	}

	public virtual TextBox _txtOther_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtOther_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtOther_2 = value;
		}
	}

	public virtual Button _cmdRecalc_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __cmdRecalc_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _cmdRecalc_0_Click;
			if (__cmdRecalc_0 != null)
			{
				((Control)__cmdRecalc_0).Click -= eventHandler;
			}
			__cmdRecalc_0 = value;
			if (__cmdRecalc_0 != null)
			{
				((Control)__cmdRecalc_0).Click += eventHandler;
			}
		}
	}

	public virtual CheckBox _chkOther_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __chkOther_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _chkOther_0_CheckStateChanged;
			if (__chkOther_0 != null)
			{
				__chkOther_0.CheckStateChanged -= eventHandler;
			}
			__chkOther_0 = value;
			if (__chkOther_0 != null)
			{
				__chkOther_0.CheckStateChanged += eventHandler;
			}
		}
	}

	public virtual CheckBox _chkOther_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __chkOther_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _chkOther_1_CheckStateChanged;
			if (__chkOther_1 != null)
			{
				__chkOther_1.CheckStateChanged -= eventHandler;
			}
			__chkOther_1 = value;
			if (__chkOther_1 != null)
			{
				__chkOther_1.CheckStateChanged += eventHandler;
			}
		}
	}

	public virtual CheckBox _chkOther_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __chkOther_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _chkOther_2_CheckStateChanged;
			if (__chkOther_2 != null)
			{
				__chkOther_2.CheckStateChanged -= eventHandler;
			}
			__chkOther_2 = value;
			if (__chkOther_2 != null)
			{
				__chkOther_2.CheckStateChanged += eventHandler;
			}
		}
	}

	public virtual Button _cmdRecalc_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __cmdRecalc_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _cmdRecalc_1_Click;
			if (__cmdRecalc_1 != null)
			{
				((Control)__cmdRecalc_1).Click -= eventHandler;
			}
			__cmdRecalc_1 = value;
			if (__cmdRecalc_1 != null)
			{
				((Control)__cmdRecalc_1).Click += eventHandler;
			}
		}
	}

	public virtual Button _cmdRecalc_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __cmdRecalc_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _cmdRecalc_2_Click;
			if (__cmdRecalc_2 != null)
			{
				((Control)__cmdRecalc_2).Click -= eventHandler;
			}
			__cmdRecalc_2 = value;
			if (__cmdRecalc_2 != null)
			{
				((Control)__cmdRecalc_2).Click += eventHandler;
			}
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

	public virtual GroupBox _fraTab2_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraTab2_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraTab2_1 = value;
		}
	}

	public virtual Label _lbl5PctError_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __lbl5PctError_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lbl5PctError_0 = value;
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

	public virtual GroupBox _fraStep_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraStep_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraStep_1 = value;
		}
	}

	public virtual RadioButton _optInfOrEff_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __optInfOrEff_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _optInfOrEff_1_CheckedChanged;
			if (__optInfOrEff_1 != null)
			{
				__optInfOrEff_1.CheckedChanged -= eventHandler;
			}
			__optInfOrEff_1 = value;
			if (__optInfOrEff_1 != null)
			{
				__optInfOrEff_1.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual RadioButton _optInfOrEff_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __optInfOrEff_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _optInfOrEff_0_CheckedChanged;
			if (__optInfOrEff_0 != null)
			{
				__optInfOrEff_0.CheckedChanged -= eventHandler;
			}
			__optInfOrEff_0 = value;
			if (__optInfOrEff_0 != null)
			{
				__optInfOrEff_0.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual Panel _Frame1_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __Frame1_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Frame1_1 = value;
		}
	}

	public virtual RadioButton _optContOrBatch_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __optContOrBatch_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _optContOrBatch_1_CheckedChanged;
			if (__optContOrBatch_1 != null)
			{
				__optContOrBatch_1.CheckedChanged -= eventHandler;
			}
			__optContOrBatch_1 = value;
			if (__optContOrBatch_1 != null)
			{
				__optContOrBatch_1.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual RadioButton _optContOrBatch_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __optContOrBatch_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _optContOrBatch_0_CheckedChanged;
			if (__optContOrBatch_0 != null)
			{
				__optContOrBatch_0.CheckedChanged -= eventHandler;
			}
			__optContOrBatch_0 = value;
			if (__optContOrBatch_0 != null)
			{
				__optContOrBatch_0.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual Panel _Frame1_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __Frame1_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Frame1_0 = value;
		}
	}

	public virtual Label _Line1_4
	{
		[DebuggerNonUserCode]
		get
		{
			return __Line1_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Line1_4 = value;
		}
	}

	public virtual Label lblMassBalMsg
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMassBalMsg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMassBalMsg = value;
		}
	}

	public virtual Label lblMyPVop
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMyPVop;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMyPVop = value;
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

	public virtual Label _lblInstructions_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblInstructions_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblInstructions_2 = value;
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

	public virtual GroupBox _fraStep_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraStep_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraStep_0 = value;
		}
	}

	public virtual Button cmdBasis
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdBasis;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdBasis_Click;
			if (_cmdBasis != null)
			{
				((Control)_cmdBasis).Click -= eventHandler;
			}
			_cmdBasis = value;
			if (_cmdBasis != null)
			{
				((Control)_cmdBasis).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdHelp
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdHelp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cmdHelp = value;
		}
	}

	public virtual Button cmdFinish
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdFinish;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdFinish_Click;
			if (_cmdFinish != null)
			{
				((Control)_cmdFinish).Click -= eventHandler;
			}
			_cmdFinish = value;
			if (_cmdFinish != null)
			{
				((Control)_cmdFinish).Click += eventHandler;
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

	public virtual Label _lblError_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblError_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblError_0 = value;
		}
	}

	public virtual Label _lblError_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblError_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblError_1 = value;
		}
	}

	public virtual GroupBox _fraStep_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraStep_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraStep_3 = value;
		}
	}

	public virtual TextBox _txtOBatch1_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtOBatch1_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtOBatch1_2 = value;
		}
	}

	public virtual TextBox _txtOBatch1_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtOBatch1_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtOBatch1_0 = value;
		}
	}

	public virtual TextBox _txtOBatch1_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtOBatch1_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtOBatch1_1 = value;
		}
	}

	public virtual Label _lblInstructions_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblInstructions_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblInstructions_3 = value;
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

	public virtual GroupBox _fraTab3_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraTab3_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraTab3_0 = value;
		}
	}

	public virtual Button cmdCalcBatchParms
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdCalcBatchParms;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdCalcBatchParms_Click;
			if (_cmdCalcBatchParms != null)
			{
				((Control)_cmdCalcBatchParms).Click -= eventHandler;
			}
			_cmdCalcBatchParms = value;
			if (_cmdCalcBatchParms != null)
			{
				((Control)_cmdCalcBatchParms).Click += eventHandler;
			}
		}
	}

	public virtual Button _cmdBatchRecalc_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __cmdBatchRecalc_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _cmdBatchRecalc_2_Click;
			if (__cmdBatchRecalc_2 != null)
			{
				((Control)__cmdBatchRecalc_2).Click -= eventHandler;
			}
			__cmdBatchRecalc_2 = value;
			if (__cmdBatchRecalc_2 != null)
			{
				((Control)__cmdBatchRecalc_2).Click += eventHandler;
			}
		}
	}

	public virtual CheckBox _chkOBatch2_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __chkOBatch2_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _chkOBatch2_0_CheckStateChanged;
			if (__chkOBatch2_0 != null)
			{
				__chkOBatch2_0.CheckStateChanged -= eventHandler;
			}
			__chkOBatch2_0 = value;
			if (__chkOBatch2_0 != null)
			{
				__chkOBatch2_0.CheckStateChanged += eventHandler;
			}
		}
	}

	public virtual TextBox _txtOBatch2_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtOBatch2_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtOBatch2_0 = value;
		}
	}

	public virtual Button _cmdBatchRecalc_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __cmdBatchRecalc_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _cmdBatchRecalc_0_Click;
			if (__cmdBatchRecalc_0 != null)
			{
				((Control)__cmdBatchRecalc_0).Click -= eventHandler;
			}
			__cmdBatchRecalc_0 = value;
			if (__cmdBatchRecalc_0 != null)
			{
				((Control)__cmdBatchRecalc_0).Click += eventHandler;
			}
		}
	}

	public virtual CheckBox _chkOBatch2_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __chkOBatch2_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _chkOBatch2_1_CheckStateChanged;
			if (__chkOBatch2_1 != null)
			{
				__chkOBatch2_1.CheckStateChanged -= eventHandler;
			}
			__chkOBatch2_1 = value;
			if (__chkOBatch2_1 != null)
			{
				__chkOBatch2_1.CheckStateChanged += eventHandler;
			}
		}
	}

	public virtual TextBox _txtOBatch2_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtOBatch2_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtOBatch2_1 = value;
		}
	}

	public virtual Button _cmdBatchRecalc_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __cmdBatchRecalc_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _cmdBatchRecalc_1_Click;
			if (__cmdBatchRecalc_1 != null)
			{
				((Control)__cmdBatchRecalc_1).Click -= eventHandler;
			}
			__cmdBatchRecalc_1 = value;
			if (__cmdBatchRecalc_1 != null)
			{
				((Control)__cmdBatchRecalc_1).Click += eventHandler;
			}
		}
	}

	public virtual CheckBox _chkOBatch2_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __chkOBatch2_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _chkOBatch2_2_CheckStateChanged;
			if (__chkOBatch2_2 != null)
			{
				__chkOBatch2_2.CheckStateChanged -= eventHandler;
			}
			__chkOBatch2_2 = value;
			if (__chkOBatch2_2 != null)
			{
				__chkOBatch2_2.CheckStateChanged += eventHandler;
			}
		}
	}

	public virtual TextBox _txtOBatch2_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtOBatch2_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtOBatch2_2 = value;
		}
	}

	public virtual TextBox txtOBatch3
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtOBatch3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtOBatch3 = value;
		}
	}

	public virtual Label _lblInstructions_4
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblInstructions_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblInstructions_4 = value;
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

	public virtual GroupBox _fraTab3_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraTab3_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraTab3_1 = value;
		}
	}

	public virtual Label _lbl5PctError_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __lbl5PctError_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lbl5PctError_1 = value;
		}
	}

	public virtual GroupBox _fraStep_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraStep_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraStep_2 = value;
		}
	}

	public virtual AxTabStrip tabs
	{
		[DebuggerNonUserCode]
		get
		{
			return _tabs;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = tabs_ClickEvent;
			if (_tabs != null)
			{
				_tabs.ClickEvent -= eventHandler;
			}
			_tabs = value;
			if (_tabs != null)
			{
				_tabs.ClickEvent += eventHandler;
			}
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

	public virtual PanelArray Frame1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Frame1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Frame1 = value;
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

	public virtual CheckBoxArray chkKnowns1
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkKnowns1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = chkKnowns1_CheckStateChanged;
			if (_chkKnowns1 != null)
			{
				_chkKnowns1.CheckStateChanged -= eventHandler;
			}
			_chkKnowns1 = value;
			if (_chkKnowns1 != null)
			{
				_chkKnowns1.CheckStateChanged += eventHandler;
			}
		}
	}

	public virtual CheckBoxArray chkOBatch2
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkOBatch2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = chkOBatch2_CheckStateChanged;
			if (_chkOBatch2 != null)
			{
				_chkOBatch2.CheckStateChanged -= eventHandler;
			}
			_chkOBatch2 = value;
			if (_chkOBatch2 != null)
			{
				_chkOBatch2.CheckStateChanged += eventHandler;
			}
		}
	}

	public virtual CheckBoxArray chkOther
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkOther;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = chkOther_CheckStateChanged;
			if (_chkOther != null)
			{
				_chkOther.CheckStateChanged -= eventHandler;
			}
			_chkOther = value;
			if (_chkOther != null)
			{
				_chkOther.CheckStateChanged += eventHandler;
			}
		}
	}

	public virtual ButtonArray cmdBatchRecalc
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdBatchRecalc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdBatchRecalc_Click;
			if (_cmdBatchRecalc != null)
			{
				_cmdBatchRecalc.Click -= eventHandler;
			}
			_cmdBatchRecalc = value;
			if (_cmdBatchRecalc != null)
			{
				_cmdBatchRecalc.Click += eventHandler;
			}
		}
	}

	public virtual ButtonArray cmdRecalc
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdRecalc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdRecalc_Click;
			if (_cmdRecalc != null)
			{
				_cmdRecalc.Click -= eventHandler;
			}
			_cmdRecalc = value;
			if (_cmdRecalc != null)
			{
				_cmdRecalc.Click += eventHandler;
			}
		}
	}

	public virtual GroupBoxArray fraStep
	{
		[DebuggerNonUserCode]
		get
		{
			return _fraStep;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_fraStep = value;
		}
	}

	public virtual GroupBoxArray fraTab2
	{
		[DebuggerNonUserCode]
		get
		{
			return _fraTab2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_fraTab2 = value;
		}
	}

	public virtual GroupBoxArray fraTab3
	{
		[DebuggerNonUserCode]
		get
		{
			return _fraTab3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_fraTab3 = value;
		}
	}

	public virtual LabelArray lbl5PctError
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbl5PctError;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbl5PctError = value;
		}
	}

	public virtual LabelArray lblError
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblError;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblError = value;
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

	public virtual RadioButtonArray optContOrBatch
	{
		[DebuggerNonUserCode]
		get
		{
			return _optContOrBatch;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = optContOrBatch_CheckedChanged;
			if (_optContOrBatch != null)
			{
				_optContOrBatch.CheckedChanged -= eventHandler;
			}
			_optContOrBatch = value;
			if (_optContOrBatch != null)
			{
				_optContOrBatch.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual RadioButtonArray optInfOrEff
	{
		[DebuggerNonUserCode]
		get
		{
			return _optInfOrEff;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = optInfOrEff_CheckedChanged;
			if (_optInfOrEff != null)
			{
				_optInfOrEff.CheckedChanged -= eventHandler;
			}
			_optInfOrEff = value;
			if (_optInfOrEff != null)
			{
				_optInfOrEff.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual TextBoxArray txtKnowns
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtKnowns;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtKnowns_Leave;
			EventHandler eventHandler2 = txtKnowns_Enter;
			if (_txtKnowns != null)
			{
				_txtKnowns.Leave -= eventHandler;
				_txtKnowns.Enter -= eventHandler2;
			}
			_txtKnowns = value;
			if (_txtKnowns != null)
			{
				_txtKnowns.Leave += eventHandler;
				_txtKnowns.Enter += eventHandler2;
			}
		}
	}

	public virtual TextBoxArray txtOBatch1
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtOBatch1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtOBatch1_Leave;
			if (_txtOBatch1 != null)
			{
				_txtOBatch1.Leave -= eventHandler;
			}
			_txtOBatch1 = value;
			if (_txtOBatch1 != null)
			{
				_txtOBatch1.Leave += eventHandler;
			}
		}
	}

	public virtual TextBoxArray txtOBatch2
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtOBatch2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtOBatch2_Leave;
			EventHandler eventHandler2 = txtOBatch2_TextChanged;
			if (_txtOBatch2 != null)
			{
				_txtOBatch2.Leave -= eventHandler;
				_txtOBatch2.TextChanged -= eventHandler2;
			}
			_txtOBatch2 = value;
			if (_txtOBatch2 != null)
			{
				_txtOBatch2.Leave += eventHandler;
				_txtOBatch2.TextChanged += eventHandler2;
			}
		}
	}

	public virtual TextBoxArray txtOther
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtOther;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtOther_Leave;
			EventHandler eventHandler2 = txtOther_TextChanged;
			if (_txtOther != null)
			{
				_txtOther.Leave -= eventHandler;
				_txtOther.TextChanged -= eventHandler2;
			}
			_txtOther = value;
			if (_txtOther != null)
			{
				_txtOther.Leave += eventHandler;
				_txtOther.TextChanged += eventHandler2;
			}
		}
	}

	public static frmMDUpdOpIP DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmMDUpdOpIP();
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

	public frmMDUpdOpIP()
	{
		((Form)this).Load += frmMDUpdOpIP_Load;
		__ENCAddToList(this);
		arMyMassBalDisc = new int[3];
		COFarOpParms = new float[2, 2];
		COFarOpParmsType = new short[2, 2];
		COFarGssOptions = new short[2, 2];
		COFarGssOther = new string[2, 2];
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
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected O, but got Unknown
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Expected O, but got Unknown
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Expected O, but got Unknown
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected O, but got Unknown
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Expected O, but got Unknown
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected O, but got Unknown
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Expected O, but got Unknown
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Expected O, but got Unknown
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Expected O, but got Unknown
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Expected O, but got Unknown
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected O, but got Unknown
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected O, but got Unknown
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Expected O, but got Unknown
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Expected O, but got Unknown
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Expected O, but got Unknown
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Expected O, but got Unknown
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Expected O, but got Unknown
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Expected O, but got Unknown
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Expected O, but got Unknown
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Expected O, but got Unknown
		//IL_043c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Expected O, but got Unknown
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Expected O, but got Unknown
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		//IL_046a: Expected O, but got Unknown
		//IL_0472: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Expected O, but got Unknown
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Expected O, but got Unknown
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a0: Expected O, but got Unknown
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Expected O, but got Unknown
		//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c4: Expected O, but got Unknown
		//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Expected O, but got Unknown
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Expected O, but got Unknown
		//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fa: Expected O, but got Unknown
		//IL_0502: Unknown result type (might be due to invalid IL or missing references)
		//IL_050c: Expected O, but got Unknown
		//IL_0514: Unknown result type (might be due to invalid IL or missing references)
		//IL_051e: Expected O, but got Unknown
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_0530: Expected O, but got Unknown
		//IL_0538: Unknown result type (might be due to invalid IL or missing references)
		//IL_0542: Expected O, but got Unknown
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0554: Expected O, but got Unknown
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0566: Expected O, but got Unknown
		//IL_056e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0578: Expected O, but got Unknown
		//IL_0580: Unknown result type (might be due to invalid IL or missing references)
		//IL_058a: Expected O, but got Unknown
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_059c: Expected O, but got Unknown
		//IL_0798: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a2: Expected O, but got Unknown
		//IL_0a7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a84: Expected O, but got Unknown
		//IL_0b5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b66: Expected O, but got Unknown
		//IL_0c30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3a: Expected O, but got Unknown
		//IL_0d01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0b: Expected O, but got Unknown
		//IL_0dd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ddc: Expected O, but got Unknown
		//IL_0ea9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb3: Expected O, but got Unknown
		//IL_0f7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f84: Expected O, but got Unknown
		//IL_105b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1065: Expected O, but got Unknown
		//IL_1150: Unknown result type (might be due to invalid IL or missing references)
		//IL_115a: Expected O, but got Unknown
		//IL_1234: Unknown result type (might be due to invalid IL or missing references)
		//IL_123e: Expected O, but got Unknown
		//IL_1337: Unknown result type (might be due to invalid IL or missing references)
		//IL_1341: Expected O, but got Unknown
		//IL_1417: Unknown result type (might be due to invalid IL or missing references)
		//IL_1421: Expected O, but got Unknown
		//IL_14fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1505: Expected O, but got Unknown
		//IL_15fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1605: Expected O, but got Unknown
		//IL_16f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1701: Expected O, but got Unknown
		//IL_17f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1800: Expected O, but got Unknown
		//IL_18f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_18fc: Expected O, but got Unknown
		//IL_1b41: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b4b: Expected O, but got Unknown
		//IL_1c18: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c22: Expected O, but got Unknown
		//IL_1ecf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ed9: Expected O, but got Unknown
		//IL_1fa7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fb1: Expected O, but got Unknown
		//IL_209a: Unknown result type (might be due to invalid IL or missing references)
		//IL_20a4: Expected O, but got Unknown
		//IL_2196: Unknown result type (might be due to invalid IL or missing references)
		//IL_21a0: Expected O, but got Unknown
		//IL_2292: Unknown result type (might be due to invalid IL or missing references)
		//IL_229c: Expected O, but got Unknown
		//IL_2372: Unknown result type (might be due to invalid IL or missing references)
		//IL_237c: Expected O, but got Unknown
		//IL_2456: Unknown result type (might be due to invalid IL or missing references)
		//IL_2460: Expected O, but got Unknown
		//IL_253a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2544: Expected O, but got Unknown
		//IL_261e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2628: Expected O, but got Unknown
		//IL_2702: Unknown result type (might be due to invalid IL or missing references)
		//IL_270c: Expected O, but got Unknown
		//IL_27e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_27f0: Expected O, but got Unknown
		//IL_28ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_28d4: Expected O, but got Unknown
		//IL_29a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_29b2: Expected O, but got Unknown
		//IL_2a81: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a8b: Expected O, but got Unknown
		//IL_2c14: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c1e: Expected O, but got Unknown
		//IL_2d28: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d32: Expected O, but got Unknown
		//IL_2df1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dfb: Expected O, but got Unknown
		//IL_2ee0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2eea: Expected O, but got Unknown
		//IL_300e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3018: Expected O, but got Unknown
		//IL_30e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_30ef: Expected O, but got Unknown
		//IL_31d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_31df: Expected O, but got Unknown
		//IL_3350: Unknown result type (might be due to invalid IL or missing references)
		//IL_335a: Expected O, but got Unknown
		//IL_3417: Unknown result type (might be due to invalid IL or missing references)
		//IL_3421: Expected O, but got Unknown
		//IL_3556: Unknown result type (might be due to invalid IL or missing references)
		//IL_3560: Expected O, but got Unknown
		//IL_36a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_36b2: Expected O, but got Unknown
		//IL_377f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3789: Expected O, but got Unknown
		//IL_3853: Unknown result type (might be due to invalid IL or missing references)
		//IL_385d: Expected O, but got Unknown
		//IL_3927: Unknown result type (might be due to invalid IL or missing references)
		//IL_3931: Expected O, but got Unknown
		//IL_3a08: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a12: Expected O, but got Unknown
		//IL_3af9: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b03: Expected O, but got Unknown
		//IL_3bdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_3be5: Expected O, but got Unknown
		//IL_3ccc: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cd6: Expected O, but got Unknown
		//IL_3df1: Unknown result type (might be due to invalid IL or missing references)
		//IL_3dfb: Expected O, but got Unknown
		//IL_3f63: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f6d: Expected O, but got Unknown
		//IL_4065: Unknown result type (might be due to invalid IL or missing references)
		//IL_406f: Expected O, but got Unknown
		//IL_4151: Unknown result type (might be due to invalid IL or missing references)
		//IL_415b: Expected O, but got Unknown
		//IL_4230: Unknown result type (might be due to invalid IL or missing references)
		//IL_423a: Expected O, but got Unknown
		//IL_4302: Unknown result type (might be due to invalid IL or missing references)
		//IL_430c: Expected O, but got Unknown
		//IL_43d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_43e3: Expected O, but got Unknown
		//IL_44b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_44bb: Expected O, but got Unknown
		//IL_4588: Unknown result type (might be due to invalid IL or missing references)
		//IL_4592: Expected O, but got Unknown
		//IL_4779: Unknown result type (might be due to invalid IL or missing references)
		//IL_4783: Expected O, but got Unknown
		//IL_4862: Unknown result type (might be due to invalid IL or missing references)
		//IL_486c: Expected O, but got Unknown
		//IL_4939: Unknown result type (might be due to invalid IL or missing references)
		//IL_4943: Expected O, but got Unknown
		//IL_4a20: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a2a: Expected O, but got Unknown
		//IL_4b20: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b2a: Expected O, but got Unknown
		//IL_4bff: Unknown result type (might be due to invalid IL or missing references)
		//IL_4c09: Expected O, but got Unknown
		//IL_4ce2: Unknown result type (might be due to invalid IL or missing references)
		//IL_4cec: Expected O, but got Unknown
		//IL_4de2: Unknown result type (might be due to invalid IL or missing references)
		//IL_4dec: Expected O, but got Unknown
		//IL_4ec2: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ecc: Expected O, but got Unknown
		//IL_4fa6: Unknown result type (might be due to invalid IL or missing references)
		//IL_4fb0: Expected O, but got Unknown
		//IL_50a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_50b3: Expected O, but got Unknown
		//IL_51a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_51b2: Expected O, but got Unknown
		//IL_5278: Unknown result type (might be due to invalid IL or missing references)
		//IL_5282: Expected O, but got Unknown
		//IL_534f: Unknown result type (might be due to invalid IL or missing references)
		//IL_5359: Expected O, but got Unknown
		//IL_542a: Unknown result type (might be due to invalid IL or missing references)
		//IL_5434: Expected O, but got Unknown
		//IL_5508: Unknown result type (might be due to invalid IL or missing references)
		//IL_5512: Expected O, but got Unknown
		//IL_5576: Unknown result type (might be due to invalid IL or missing references)
		//IL_5580: Expected O, but got Unknown
		//IL_5726: Unknown result type (might be due to invalid IL or missing references)
		//IL_5730: Expected O, but got Unknown
		//IL_5745: Unknown result type (might be due to invalid IL or missing references)
		//IL_574f: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMDUpdOpIP));
		ToolTip1 = new ToolTip(components);
		_fraStep_1 = new GroupBox();
		_fraTab2_0 = new GroupBox();
		cmdCalcDMxChem = new Button();
		cmdCalcYprod = new Button();
		cmdCalcNS = new Button();
		cmdRestoreDefaults = new Button();
		cmdCalcXmoProd = new Button();
		cmdCalcOthers = new Button();
		_chkKnowns1_0 = new CheckBox();
		_chkKnowns1_1 = new CheckBox();
		_chkKnowns1_2 = new CheckBox();
		_txtKnowns_0 = new TextBox();
		_chkKnowns1_4 = new CheckBox();
		_chkKnowns1_3 = new CheckBox();
		_txtKnowns_1 = new TextBox();
		_txtKnowns_2 = new TextBox();
		_txtKnowns_3 = new TextBox();
		_txtKnowns_4 = new TextBox();
		_Line1_3 = new Label();
		_Line1_2 = new Label();
		_Line1_9 = new Label();
		_Label1_1 = new Label();
		_Label1_0 = new Label();
		_Line1_6 = new Label();
		_Line1_10 = new Label();
		_fraTab2_1 = new GroupBox();
		cmdCalcDefaults = new Button();
		_txtOther_0 = new TextBox();
		_txtOther_1 = new TextBox();
		_txtOther_2 = new TextBox();
		_cmdRecalc_0 = new Button();
		_chkOther_0 = new CheckBox();
		_chkOther_1 = new CheckBox();
		_chkOther_2 = new CheckBox();
		_cmdRecalc_1 = new Button();
		_cmdRecalc_2 = new Button();
		_Label1_9 = new Label();
		_lbl5PctError_0 = new Label();
		_lblInstructions_1 = new Label();
		_fraStep_0 = new GroupBox();
		_Frame1_1 = new Panel();
		_optInfOrEff_1 = new RadioButton();
		_optInfOrEff_0 = new RadioButton();
		_Frame1_0 = new Panel();
		_optContOrBatch_1 = new RadioButton();
		_optContOrBatch_0 = new RadioButton();
		_Line1_4 = new Label();
		lblMassBalMsg = new Label();
		lblMyPVop = new Label();
		_Line1_0 = new Label();
		_lblInstructions_2 = new Label();
		_Line1_1 = new Label();
		_lblInstructions_0 = new Label();
		cmdBasis = new Button();
		cmdHelp = new Button();
		cmdFinish = new Button();
		cmdCancel = new Button();
		_fraStep_3 = new GroupBox();
		_lblError_0 = new Label();
		_lblError_1 = new Label();
		_fraStep_2 = new GroupBox();
		_fraTab3_0 = new GroupBox();
		_txtOBatch1_2 = new TextBox();
		_txtOBatch1_0 = new TextBox();
		_txtOBatch1_1 = new TextBox();
		_lblInstructions_3 = new Label();
		_Label1_11 = new Label();
		_Label1_7 = new Label();
		_Label1_8 = new Label();
		_fraTab3_1 = new GroupBox();
		cmdCalcBatchParms = new Button();
		_cmdBatchRecalc_2 = new Button();
		_chkOBatch2_0 = new CheckBox();
		_txtOBatch2_0 = new TextBox();
		_cmdBatchRecalc_0 = new Button();
		_chkOBatch2_1 = new CheckBox();
		_txtOBatch2_1 = new TextBox();
		_cmdBatchRecalc_1 = new Button();
		_chkOBatch2_2 = new CheckBox();
		_txtOBatch2_2 = new TextBox();
		txtOBatch3 = new TextBox();
		_lblInstructions_4 = new Label();
		_Label1_10 = new Label();
		_lbl5PctError_1 = new Label();
		tabs = new AxTabStrip();
		lblOp = new Label();
		Frame1 = new PanelArray(components);
		Label1 = new LabelArray(components);
		Line1 = new LabelArray(components);
		chkKnowns1 = new CheckBoxArray(components);
		chkOBatch2 = new CheckBoxArray(components);
		chkOther = new CheckBoxArray(components);
		cmdBatchRecalc = new ButtonArray(components);
		cmdRecalc = new ButtonArray(components);
		fraStep = new GroupBoxArray(components);
		fraTab2 = new GroupBoxArray(components);
		fraTab3 = new GroupBoxArray(components);
		lbl5PctError = new LabelArray(components);
		lblError = new LabelArray(components);
		lblInstructions = new LabelArray(components);
		optContOrBatch = new RadioButtonArray(components);
		optInfOrEff = new RadioButtonArray(components);
		txtKnowns = new TextBoxArray(components);
		txtOBatch1 = new TextBoxArray(components);
		txtOBatch2 = new TextBoxArray(components);
		txtOther = new TextBoxArray(components);
		((Control)_fraStep_1).SuspendLayout();
		((Control)_fraTab2_0).SuspendLayout();
		((Control)_fraTab2_1).SuspendLayout();
		((Control)_fraStep_0).SuspendLayout();
		((Control)_Frame1_1).SuspendLayout();
		((Control)_Frame1_0).SuspendLayout();
		((Control)_fraStep_3).SuspendLayout();
		((Control)_fraStep_2).SuspendLayout();
		((Control)_fraTab3_0).SuspendLayout();
		((Control)_fraTab3_1).SuspendLayout();
		((ISupportInitialize)tabs).BeginInit();
		((ISupportInitialize)Frame1).BeginInit();
		((ISupportInitialize)Label1).BeginInit();
		((ISupportInitialize)Line1).BeginInit();
		((ISupportInitialize)chkKnowns1).BeginInit();
		((ISupportInitialize)chkOBatch2).BeginInit();
		((ISupportInitialize)chkOther).BeginInit();
		((ISupportInitialize)cmdBatchRecalc).BeginInit();
		((ISupportInitialize)cmdRecalc).BeginInit();
		((ISupportInitialize)fraStep).BeginInit();
		((ISupportInitialize)fraTab2).BeginInit();
		((ISupportInitialize)fraTab3).BeginInit();
		((ISupportInitialize)lbl5PctError).BeginInit();
		((ISupportInitialize)lblError).BeginInit();
		((ISupportInitialize)lblInstructions).BeginInit();
		((ISupportInitialize)optContOrBatch).BeginInit();
		((ISupportInitialize)optInfOrEff).BeginInit();
		((ISupportInitialize)txtKnowns).BeginInit();
		((ISupportInitialize)txtOBatch1).BeginInit();
		((ISupportInitialize)txtOBatch2).BeginInit();
		((ISupportInitialize)txtOther).BeginInit();
		((Control)this).SuspendLayout();
		((Control)_fraStep_1).BackColor = SystemColors.Control;
		((Control)_fraStep_1).Controls.Add((Control)(object)_fraTab2_0);
		((Control)_fraStep_1).Controls.Add((Control)(object)_fraTab2_1);
		((Control)_fraStep_1).Controls.Add((Control)(object)_lbl5PctError_0);
		((Control)_fraStep_1).Controls.Add((Control)(object)_lblInstructions_1);
		((Control)_fraStep_1).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_fraStep_1).ForeColor = SystemColors.ControlText;
		fraStep.SetIndex(_fraStep_1, (short)1);
		GroupBox fraStep_ = _fraStep_1;
		Point location = new Point(8, 48);
		((Control)fraStep_).Location = location;
		((Control)_fraStep_1).Name = "_fraStep_1";
		((Control)_fraStep_1).RightToLeft = (RightToLeft)0;
		GroupBox fraStep_2 = _fraStep_1;
		Size size = new Size(689, 457);
		((Control)fraStep_2).Size = size;
		((Control)_fraStep_1).TabIndex = 50;
		_fraStep_1.TabStop = false;
		((Control)_fraStep_1).Visible = false;
		((Control)_fraTab2_0).BackColor = SystemColors.Control;
		((Control)_fraTab2_0).Controls.Add((Control)(object)cmdCalcDMxChem);
		((Control)_fraTab2_0).Controls.Add((Control)(object)cmdCalcYprod);
		((Control)_fraTab2_0).Controls.Add((Control)(object)cmdCalcNS);
		((Control)_fraTab2_0).Controls.Add((Control)(object)cmdRestoreDefaults);
		((Control)_fraTab2_0).Controls.Add((Control)(object)cmdCalcXmoProd);
		((Control)_fraTab2_0).Controls.Add((Control)(object)cmdCalcOthers);
		((Control)_fraTab2_0).Controls.Add((Control)(object)_chkKnowns1_0);
		((Control)_fraTab2_0).Controls.Add((Control)(object)_chkKnowns1_1);
		((Control)_fraTab2_0).Controls.Add((Control)(object)_chkKnowns1_2);
		((Control)_fraTab2_0).Controls.Add((Control)(object)_txtKnowns_0);
		((Control)_fraTab2_0).Controls.Add((Control)(object)_chkKnowns1_4);
		((Control)_fraTab2_0).Controls.Add((Control)(object)_chkKnowns1_3);
		((Control)_fraTab2_0).Controls.Add((Control)(object)_txtKnowns_1);
		((Control)_fraTab2_0).Controls.Add((Control)(object)_txtKnowns_2);
		((Control)_fraTab2_0).Controls.Add((Control)(object)_txtKnowns_3);
		((Control)_fraTab2_0).Controls.Add((Control)(object)_txtKnowns_4);
		((Control)_fraTab2_0).Controls.Add((Control)(object)_Line1_3);
		((Control)_fraTab2_0).Controls.Add((Control)(object)_Line1_2);
		((Control)_fraTab2_0).Controls.Add((Control)(object)_Line1_9);
		((Control)_fraTab2_0).Controls.Add((Control)(object)_Label1_1);
		((Control)_fraTab2_0).Controls.Add((Control)(object)_Label1_0);
		((Control)_fraTab2_0).Controls.Add((Control)(object)_Line1_6);
		((Control)_fraTab2_0).Controls.Add((Control)(object)_Line1_10);
		((Control)_fraTab2_0).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_fraTab2_0).ForeColor = SystemColors.ControlText;
		fraTab2.SetIndex(_fraTab2_0, (short)0);
		GroupBox fraTab2_ = _fraTab2_0;
		location = new Point(0, 56);
		((Control)fraTab2_).Location = location;
		((Control)_fraTab2_0).Name = "_fraTab2_0";
		((Control)_fraTab2_0).RightToLeft = (RightToLeft)0;
		GroupBox fraTab2_2 = _fraTab2_0;
		size = new Size(689, 209);
		((Control)fraTab2_2).Size = size;
		((Control)_fraTab2_0).TabIndex = 63;
		_fraTab2_0.TabStop = false;
		((ButtonBase)cmdCalcDMxChem).BackColor = SystemColors.Control;
		((Control)cmdCalcDMxChem).Cursor = Cursors.Default;
		((Control)cmdCalcDMxChem).Enabled = false;
		((Control)cmdCalcDMxChem).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCalcDMxChem).ForeColor = SystemColors.ControlText;
		Button obj = cmdCalcDMxChem;
		location = new Point(616, 144);
		((Control)obj).Location = location;
		((Control)cmdCalcDMxChem).Name = "cmdCalcDMxChem";
		((Control)cmdCalcDMxChem).RightToLeft = (RightToLeft)0;
		Button obj2 = cmdCalcDMxChem;
		size = new Size(41, 19);
		((Control)obj2).Size = size;
		((Control)cmdCalcDMxChem).TabIndex = 77;
		((ButtonBase)cmdCalcDMxChem).Text = "&Calc";
		((ButtonBase)cmdCalcDMxChem).UseVisualStyleBackColor = false;
		((ButtonBase)cmdCalcYprod).BackColor = SystemColors.Control;
		((Control)cmdCalcYprod).Cursor = Cursors.Default;
		((Control)cmdCalcYprod).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCalcYprod).ForeColor = SystemColors.ControlText;
		Button obj3 = cmdCalcYprod;
		location = new Point(616, 88);
		((Control)obj3).Location = location;
		((Control)cmdCalcYprod).Name = "cmdCalcYprod";
		((Control)cmdCalcYprod).RightToLeft = (RightToLeft)0;
		Button obj4 = cmdCalcYprod;
		size = new Size(49, 19);
		((Control)obj4).Size = size;
		((Control)cmdCalcYprod).TabIndex = 19;
		((ButtonBase)cmdCalcYprod).Text = "&Defaults";
		((ButtonBase)cmdCalcYprod).UseVisualStyleBackColor = false;
		((ButtonBase)cmdCalcNS).BackColor = SystemColors.Control;
		((Control)cmdCalcNS).Cursor = Cursors.Default;
		((Control)cmdCalcNS).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCalcNS).ForeColor = SystemColors.ControlText;
		Button obj5 = cmdCalcNS;
		location = new Point(616, 32);
		((Control)obj5).Location = location;
		((Control)cmdCalcNS).Name = "cmdCalcNS";
		((Control)cmdCalcNS).RightToLeft = (RightToLeft)0;
		Button obj6 = cmdCalcNS;
		size = new Size(41, 19);
		((Control)obj6).Size = size;
		((Control)cmdCalcNS).TabIndex = 16;
		((ButtonBase)cmdCalcNS).Text = "&Calc";
		((ButtonBase)cmdCalcNS).UseVisualStyleBackColor = false;
		((ButtonBase)cmdRestoreDefaults).BackColor = SystemColors.Control;
		((Control)cmdRestoreDefaults).Cursor = Cursors.Default;
		((Control)cmdRestoreDefaults).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdRestoreDefaults).ForeColor = SystemColors.ControlText;
		Button obj7 = cmdRestoreDefaults;
		location = new Point(344, 176);
		((Control)obj7).Location = location;
		((Control)cmdRestoreDefaults).Name = "cmdRestoreDefaults";
		((Control)cmdRestoreDefaults).RightToLeft = (RightToLeft)0;
		Button obj8 = cmdRestoreDefaults;
		size = new Size(193, 25);
		((Control)obj8).Size = size;
		((Control)cmdRestoreDefaults).TabIndex = 24;
		((ButtonBase)cmdRestoreDefaults).Text = "&Restore Defaults";
		((ButtonBase)cmdRestoreDefaults).UseVisualStyleBackColor = false;
		((ButtonBase)cmdCalcXmoProd).BackColor = SystemColors.Control;
		((Control)cmdCalcXmoProd).Cursor = Cursors.Default;
		((Control)cmdCalcXmoProd).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCalcXmoProd).ForeColor = SystemColors.ControlText;
		Button obj9 = cmdCalcXmoProd;
		location = new Point(616, 112);
		((Control)obj9).Location = location;
		((Control)cmdCalcXmoProd).Name = "cmdCalcXmoProd";
		((Control)cmdCalcXmoProd).RightToLeft = (RightToLeft)0;
		Button obj10 = cmdCalcXmoProd;
		size = new Size(41, 19);
		((Control)obj10).Size = size;
		((Control)cmdCalcXmoProd).TabIndex = 21;
		((ButtonBase)cmdCalcXmoProd).Text = "&Calc";
		((ButtonBase)cmdCalcXmoProd).UseVisualStyleBackColor = false;
		((ButtonBase)cmdCalcOthers).BackColor = SystemColors.Control;
		((Control)cmdCalcOthers).Cursor = Cursors.Default;
		((Control)cmdCalcOthers).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCalcOthers).ForeColor = SystemColors.ControlText;
		Button obj11 = cmdCalcOthers;
		location = new Point(112, 176);
		((Control)obj11).Location = location;
		((Control)cmdCalcOthers).Name = "cmdCalcOthers";
		((Control)cmdCalcOthers).RightToLeft = (RightToLeft)0;
		Button obj12 = cmdCalcOthers;
		size = new Size(201, 25);
		((Control)obj12).Size = size;
		((Control)cmdCalcOthers).TabIndex = 23;
		((ButtonBase)cmdCalcOthers).Text = "&Calculate remaining two parameters";
		((ButtonBase)cmdCalcOthers).UseVisualStyleBackColor = false;
		((Control)cmdCalcOthers).Visible = false;
		((ButtonBase)_chkKnowns1_0).BackColor = SystemColors.Control;
		((Control)_chkKnowns1_0).Cursor = Cursors.Default;
		((Control)_chkKnowns1_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_chkKnowns1_0).ForeColor = SystemColors.ControlText;
		chkKnowns1.SetIndex(_chkKnowns1_0, (short)0);
		CheckBox chkKnowns1_ = _chkKnowns1_0;
		location = new Point(56, 32);
		((Control)chkKnowns1_).Location = location;
		((Control)_chkKnowns1_0).Name = "_chkKnowns1_0";
		((Control)_chkKnowns1_0).RightToLeft = (RightToLeft)0;
		CheckBox chkKnowns1_2 = _chkKnowns1_0;
		size = new Size(353, 17);
		((Control)chkKnowns1_2).Size = size;
		((Control)_chkKnowns1_0).TabIndex = 39;
		((Control)_chkKnowns1_0).Tag = "z";
		((ButtonBase)_chkKnowns1_0).Text = "NS: Number of Sites";
		((ButtonBase)_chkKnowns1_0).UseVisualStyleBackColor = false;
		((ButtonBase)_chkKnowns1_1).BackColor = SystemColors.Control;
		((Control)_chkKnowns1_1).Cursor = Cursors.Default;
		((Control)_chkKnowns1_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_chkKnowns1_1).ForeColor = SystemColors.ControlText;
		chkKnowns1.SetIndex(_chkKnowns1_1, (short)1);
		CheckBox chkKnowns1_3 = _chkKnowns1_1;
		location = new Point(56, 56);
		((Control)chkKnowns1_3).Location = location;
		((Control)_chkKnowns1_1).Name = "_chkKnowns1_1";
		((Control)_chkKnowns1_1).RightToLeft = (RightToLeft)0;
		CheckBox chkKnowns1_4 = _chkKnowns1_1;
		size = new Size(353, 17);
		((Control)chkKnowns1_4).Size = size;
		((Control)_chkKnowns1_1).TabIndex = 40;
		((ButtonBase)_chkKnowns1_1).Text = "OD: Operating Days";
		((ButtonBase)_chkKnowns1_1).UseVisualStyleBackColor = false;
		((ButtonBase)_chkKnowns1_2).BackColor = SystemColors.Control;
		((Control)_chkKnowns1_2).Cursor = Cursors.Default;
		((Control)_chkKnowns1_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_chkKnowns1_2).ForeColor = SystemColors.ControlText;
		chkKnowns1.SetIndex(_chkKnowns1_2, (short)2);
		CheckBox chkKnowns1_5 = _chkKnowns1_2;
		location = new Point(56, 144);
		((Control)chkKnowns1_5).Location = location;
		((Control)_chkKnowns1_2).Name = "_chkKnowns1_2";
		((Control)_chkKnowns1_2).RightToLeft = (RightToLeft)0;
		CheckBox chkKnowns1_6 = _chkKnowns1_2;
		size = new Size(450, 20);
		((Control)chkKnowns1_6).Size = size;
		((Control)_chkKnowns1_2).TabIndex = 43;
		((ButtonBase)_chkKnowns1_2).Text = "DMOchem: Daily mass output of chemical in product (kg/site-day)";
		((ButtonBase)_chkKnowns1_2).UseVisualStyleBackColor = false;
		_txtKnowns_0.AcceptsReturn = true;
		((TextBoxBase)_txtKnowns_0).BackColor = Color.FromArgb(192, 192, 192);
		((Control)_txtKnowns_0).Cursor = Cursors.IBeam;
		((Control)_txtKnowns_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtKnowns_0).ForeColor = SystemColors.WindowText;
		txtKnowns.SetIndex(_txtKnowns_0, (short)0);
		TextBox txtKnowns_ = _txtKnowns_0;
		location = new Point(512, 32);
		((Control)txtKnowns_).Location = location;
		((TextBoxBase)_txtKnowns_0).MaxLength = 0;
		((Control)_txtKnowns_0).Name = "_txtKnowns_0";
		((TextBoxBase)_txtKnowns_0).ReadOnly = true;
		((Control)_txtKnowns_0).RightToLeft = (RightToLeft)0;
		TextBox txtKnowns_2 = _txtKnowns_0;
		size = new Size(100, 20);
		((Control)txtKnowns_2).Size = size;
		((Control)_txtKnowns_0).TabIndex = 15;
		((ButtonBase)_chkKnowns1_4).BackColor = SystemColors.Control;
		((Control)_chkKnowns1_4).Cursor = Cursors.Default;
		((Control)_chkKnowns1_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_chkKnowns1_4).ForeColor = SystemColors.ControlText;
		chkKnowns1.SetIndex(_chkKnowns1_4, (short)4);
		CheckBox chkKnowns1_7 = _chkKnowns1_4;
		location = new Point(56, 112);
		((Control)chkKnowns1_7).Location = location;
		((Control)_chkKnowns1_4).Name = "_chkKnowns1_4";
		((Control)_chkKnowns1_4).RightToLeft = (RightToLeft)0;
		CheckBox chkKnowns1_8 = _chkKnowns1_4;
		size = new Size(433, 17);
		((Control)chkKnowns1_8).Size = size;
		((Control)_chkKnowns1_4).TabIndex = 42;
		((ButtonBase)_chkKnowns1_4).Text = "MOprod: Daily mass output of product (kg/site-day)";
		((ButtonBase)_chkKnowns1_4).UseVisualStyleBackColor = false;
		((ButtonBase)_chkKnowns1_3).BackColor = SystemColors.Control;
		((Control)_chkKnowns1_3).Cursor = Cursors.Default;
		((Control)_chkKnowns1_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_chkKnowns1_3).ForeColor = SystemColors.ControlText;
		chkKnowns1.SetIndex(_chkKnowns1_3, (short)3);
		CheckBox chkKnowns1_9 = _chkKnowns1_3;
		location = new Point(56, 88);
		((Control)chkKnowns1_9).Location = location;
		((Control)_chkKnowns1_3).Name = "_chkKnowns1_3";
		((Control)_chkKnowns1_3).RightToLeft = (RightToLeft)0;
		CheckBox chkKnowns1_10 = _chkKnowns1_3;
		size = new Size(433, 17);
		((Control)chkKnowns1_10).Size = size;
		((Control)_chkKnowns1_3).TabIndex = 41;
		((ButtonBase)_chkKnowns1_3).Text = "Yprod: Weight fraction of chemical in product (unitless)";
		((ButtonBase)_chkKnowns1_3).UseVisualStyleBackColor = false;
		_txtKnowns_1.AcceptsReturn = true;
		((TextBoxBase)_txtKnowns_1).BackColor = Color.FromArgb(192, 192, 192);
		((Control)_txtKnowns_1).Cursor = Cursors.IBeam;
		((Control)_txtKnowns_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtKnowns_1).ForeColor = SystemColors.WindowText;
		txtKnowns.SetIndex(_txtKnowns_1, (short)1);
		TextBox txtKnowns_3 = _txtKnowns_1;
		location = new Point(512, 56);
		((Control)txtKnowns_3).Location = location;
		((TextBoxBase)_txtKnowns_1).MaxLength = 0;
		((Control)_txtKnowns_1).Name = "_txtKnowns_1";
		((TextBoxBase)_txtKnowns_1).ReadOnly = true;
		((Control)_txtKnowns_1).RightToLeft = (RightToLeft)0;
		TextBox txtKnowns_4 = _txtKnowns_1;
		size = new Size(100, 20);
		((Control)txtKnowns_4).Size = size;
		((Control)_txtKnowns_1).TabIndex = 17;
		_txtKnowns_2.AcceptsReturn = true;
		((TextBoxBase)_txtKnowns_2).BackColor = Color.FromArgb(192, 192, 192);
		((Control)_txtKnowns_2).Cursor = Cursors.IBeam;
		((Control)_txtKnowns_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtKnowns_2).ForeColor = SystemColors.WindowText;
		txtKnowns.SetIndex(_txtKnowns_2, (short)2);
		TextBox txtKnowns_5 = _txtKnowns_2;
		location = new Point(512, 144);
		((Control)txtKnowns_5).Location = location;
		((TextBoxBase)_txtKnowns_2).MaxLength = 0;
		((Control)_txtKnowns_2).Name = "_txtKnowns_2";
		((TextBoxBase)_txtKnowns_2).ReadOnly = true;
		((Control)_txtKnowns_2).RightToLeft = (RightToLeft)0;
		TextBox txtKnowns_6 = _txtKnowns_2;
		size = new Size(100, 20);
		((Control)txtKnowns_6).Size = size;
		((Control)_txtKnowns_2).TabIndex = 22;
		_txtKnowns_3.AcceptsReturn = true;
		((TextBoxBase)_txtKnowns_3).BackColor = Color.FromArgb(192, 192, 192);
		((Control)_txtKnowns_3).Cursor = Cursors.IBeam;
		((Control)_txtKnowns_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtKnowns_3).ForeColor = SystemColors.WindowText;
		txtKnowns.SetIndex(_txtKnowns_3, (short)3);
		TextBox txtKnowns_7 = _txtKnowns_3;
		location = new Point(512, 88);
		((Control)txtKnowns_7).Location = location;
		((TextBoxBase)_txtKnowns_3).MaxLength = 0;
		((Control)_txtKnowns_3).Name = "_txtKnowns_3";
		((TextBoxBase)_txtKnowns_3).ReadOnly = true;
		((Control)_txtKnowns_3).RightToLeft = (RightToLeft)0;
		TextBox txtKnowns_8 = _txtKnowns_3;
		size = new Size(100, 20);
		((Control)txtKnowns_8).Size = size;
		((Control)_txtKnowns_3).TabIndex = 18;
		_txtKnowns_4.AcceptsReturn = true;
		((TextBoxBase)_txtKnowns_4).BackColor = Color.FromArgb(192, 192, 192);
		((Control)_txtKnowns_4).Cursor = Cursors.IBeam;
		((Control)_txtKnowns_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtKnowns_4).ForeColor = SystemColors.WindowText;
		txtKnowns.SetIndex(_txtKnowns_4, (short)4);
		TextBox txtKnowns_9 = _txtKnowns_4;
		location = new Point(512, 112);
		((Control)txtKnowns_9).Location = location;
		((TextBoxBase)_txtKnowns_4).MaxLength = 0;
		((Control)_txtKnowns_4).Name = "_txtKnowns_4";
		((TextBoxBase)_txtKnowns_4).ReadOnly = true;
		((Control)_txtKnowns_4).RightToLeft = (RightToLeft)0;
		TextBox txtKnowns_10 = _txtKnowns_4;
		size = new Size(100, 20);
		((Control)txtKnowns_10).Size = size;
		((Control)_txtKnowns_4).TabIndex = 20;
		((Control)_Line1_3).BackColor = SystemColors.WindowText;
		Line1.SetIndex(_Line1_3, (short)3);
		Label line1_ = _Line1_3;
		location = new Point(360, 80);
		((Control)line1_).Location = location;
		((Control)_Line1_3).Name = "_Line1_3";
		Label line1_2 = _Line1_3;
		size = new Size(256, 1);
		((Control)line1_2).Size = size;
		((Control)_Line1_3).TabIndex = 78;
		((Control)_Line1_2).BackColor = SystemColors.WindowText;
		Line1.SetIndex(_Line1_2, (short)2);
		Label line1_3 = _Line1_2;
		location = new Point(72, 80);
		((Control)line1_3).Location = location;
		((Control)_Line1_2).Name = "_Line1_2";
		Label line1_4 = _Line1_2;
		size = new Size(232, 1);
		((Control)line1_4).Size = size;
		((Control)_Line1_2).TabIndex = 79;
		((Control)_Line1_9).BackColor = SystemColors.WindowText;
		Line1.SetIndex(_Line1_9, (short)9);
		Label line1_5 = _Line1_9;
		location = new Point(360, 24);
		((Control)line1_5).Location = location;
		((Control)_Line1_9).Name = "_Line1_9";
		Label line1_6 = _Line1_9;
		size = new Size(256, 1);
		((Control)line1_6).Size = size;
		((Control)_Line1_9).TabIndex = 80;
		((Control)_Label1_1).BackColor = SystemColors.Control;
		((Control)_Label1_1).Cursor = Cursors.Default;
		((Control)_Label1_1).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_1).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_1, (short)1);
		Label label1_ = _Label1_1;
		location = new Point(312, 16);
		((Control)label1_).Location = location;
		((Control)_Label1_1).Name = "_Label1_1";
		((Control)_Label1_1).RightToLeft = (RightToLeft)0;
		Label label1_2 = _Label1_1;
		size = new Size(41, 17);
		((Control)label1_2).Size = size;
		((Control)_Label1_1).TabIndex = 66;
		_Label1_1.Text = "Pair 1";
		((Control)_Label1_0).BackColor = SystemColors.Control;
		((Control)_Label1_0).Cursor = Cursors.Default;
		((Control)_Label1_0).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_0).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_0, (short)0);
		Label label1_3 = _Label1_0;
		location = new Point(312, 72);
		((Control)label1_3).Location = location;
		((Control)_Label1_0).Name = "_Label1_0";
		((Control)_Label1_0).RightToLeft = (RightToLeft)0;
		Label label1_4 = _Label1_0;
		size = new Size(41, 17);
		((Control)label1_4).Size = size;
		((Control)_Label1_0).TabIndex = 65;
		_Label1_0.Text = "Pair 2";
		((Control)_Line1_6).BackColor = SystemColors.WindowText;
		Line1.SetIndex(_Line1_6, (short)6);
		Label line1_7 = _Line1_6;
		location = new Point(72, 136);
		((Control)line1_7).Location = location;
		((Control)_Line1_6).Name = "_Line1_6";
		Label line1_8 = _Line1_6;
		size = new Size(544, 1);
		((Control)line1_8).Size = size;
		((Control)_Line1_6).TabIndex = 81;
		((Control)_Line1_10).BackColor = SystemColors.WindowText;
		Line1.SetIndex(_Line1_10, (short)10);
		Label line1_9 = _Line1_10;
		location = new Point(72, 24);
		((Control)line1_9).Location = location;
		((Control)_Line1_10).Name = "_Line1_10";
		Label line1_10 = _Line1_10;
		size = new Size(232, 1);
		((Control)line1_10).Size = size;
		((Control)_Line1_10).TabIndex = 82;
		((Control)_fraTab2_1).BackColor = SystemColors.Control;
		((Control)_fraTab2_1).Controls.Add((Control)(object)cmdCalcDefaults);
		((Control)_fraTab2_1).Controls.Add((Control)(object)_txtOther_0);
		((Control)_fraTab2_1).Controls.Add((Control)(object)_txtOther_1);
		((Control)_fraTab2_1).Controls.Add((Control)(object)_txtOther_2);
		((Control)_fraTab2_1).Controls.Add((Control)(object)_cmdRecalc_0);
		((Control)_fraTab2_1).Controls.Add((Control)(object)_chkOther_0);
		((Control)_fraTab2_1).Controls.Add((Control)(object)_chkOther_1);
		((Control)_fraTab2_1).Controls.Add((Control)(object)_chkOther_2);
		((Control)_fraTab2_1).Controls.Add((Control)(object)_cmdRecalc_1);
		((Control)_fraTab2_1).Controls.Add((Control)(object)_cmdRecalc_2);
		((Control)_fraTab2_1).Controls.Add((Control)(object)_Label1_9);
		((Control)_fraTab2_1).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_fraTab2_1).ForeColor = SystemColors.ControlText;
		fraTab2.SetIndex(_fraTab2_1, (short)1);
		GroupBox fraTab2_3 = _fraTab2_1;
		location = new Point(0, 272);
		((Control)fraTab2_3).Location = location;
		((Control)_fraTab2_1).Name = "_fraTab2_1";
		((Control)_fraTab2_1).RightToLeft = (RightToLeft)0;
		GroupBox fraTab2_4 = _fraTab2_1;
		size = new Size(689, 161);
		((Control)fraTab2_4).Size = size;
		((Control)_fraTab2_1).TabIndex = 64;
		_fraTab2_1.TabStop = false;
		((ButtonBase)cmdCalcDefaults).BackColor = SystemColors.Control;
		((Control)cmdCalcDefaults).Cursor = Cursors.Default;
		((Control)cmdCalcDefaults).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCalcDefaults).ForeColor = SystemColors.ControlText;
		Button obj13 = cmdCalcDefaults;
		location = new Point(248, 132);
		((Control)obj13).Location = location;
		((Control)cmdCalcDefaults).Name = "cmdCalcDefaults";
		((Control)cmdCalcDefaults).RightToLeft = (RightToLeft)0;
		Button obj14 = cmdCalcDefaults;
		size = new Size(193, 25);
		((Control)obj14).Size = size;
		((Control)cmdCalcDefaults).TabIndex = 34;
		((ButtonBase)cmdCalcDefaults).Text = "&Calculate defaults";
		((ButtonBase)cmdCalcDefaults).UseVisualStyleBackColor = false;
		_txtOther_0.AcceptsReturn = true;
		((TextBoxBase)_txtOther_0).BackColor = Color.FromArgb(192, 192, 192);
		((Control)_txtOther_0).Cursor = Cursors.IBeam;
		((Control)_txtOther_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtOther_0).ForeColor = SystemColors.WindowText;
		txtOther.SetIndex(_txtOther_0, (short)0);
		TextBox txtOther_ = _txtOther_0;
		location = new Point(512, 109);
		((Control)txtOther_).Location = location;
		((TextBoxBase)_txtOther_0).MaxLength = 0;
		((Control)_txtOther_0).Name = "_txtOther_0";
		((TextBoxBase)_txtOther_0).ReadOnly = true;
		((Control)_txtOther_0).RightToLeft = (RightToLeft)0;
		TextBox txtOther_2 = _txtOther_0;
		size = new Size(105, 20);
		((Control)txtOther_2).Size = size;
		((Control)_txtOther_0).TabIndex = 32;
		_txtOther_1.AcceptsReturn = true;
		((TextBoxBase)_txtOther_1).BackColor = Color.FromArgb(192, 192, 192);
		((Control)_txtOther_1).Cursor = Cursors.IBeam;
		((Control)_txtOther_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtOther_1).ForeColor = SystemColors.WindowText;
		txtOther.SetIndex(_txtOther_1, (short)1);
		TextBox txtOther_3 = _txtOther_1;
		location = new Point(512, 61);
		((Control)txtOther_3).Location = location;
		((TextBoxBase)_txtOther_1).MaxLength = 0;
		((Control)_txtOther_1).Name = "_txtOther_1";
		((TextBoxBase)_txtOther_1).ReadOnly = true;
		((Control)_txtOther_1).RightToLeft = (RightToLeft)0;
		TextBox txtOther_4 = _txtOther_1;
		size = new Size(105, 20);
		((Control)txtOther_4).Size = size;
		((Control)_txtOther_1).TabIndex = 26;
		_txtOther_2.AcceptsReturn = true;
		((TextBoxBase)_txtOther_2).BackColor = Color.FromArgb(192, 192, 192);
		((Control)_txtOther_2).Cursor = Cursors.IBeam;
		((Control)_txtOther_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtOther_2).ForeColor = SystemColors.WindowText;
		txtOther.SetIndex(_txtOther_2, (short)2);
		TextBox txtOther_5 = _txtOther_2;
		location = new Point(512, 85);
		((Control)txtOther_5).Location = location;
		((TextBoxBase)_txtOther_2).MaxLength = 0;
		((Control)_txtOther_2).Name = "_txtOther_2";
		((TextBoxBase)_txtOther_2).ReadOnly = true;
		((Control)_txtOther_2).RightToLeft = (RightToLeft)0;
		TextBox txtOther_6 = _txtOther_2;
		size = new Size(105, 20);
		((Control)txtOther_6).Size = size;
		((Control)_txtOther_2).TabIndex = 29;
		((ButtonBase)_cmdRecalc_0).BackColor = SystemColors.Control;
		((Control)_cmdRecalc_0).Cursor = Cursors.Default;
		((Control)_cmdRecalc_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_cmdRecalc_0).ForeColor = SystemColors.ControlText;
		cmdRecalc.SetIndex(_cmdRecalc_0, (short)0);
		Button cmdRecalc_ = _cmdRecalc_0;
		location = new Point(624, 109);
		((Control)cmdRecalc_).Location = location;
		((Control)_cmdRecalc_0).Name = "_cmdRecalc_0";
		((Control)_cmdRecalc_0).RightToLeft = (RightToLeft)0;
		Button cmdRecalc_2 = _cmdRecalc_0;
		size = new Size(57, 19);
		((Control)cmdRecalc_2).Size = size;
		((Control)_cmdRecalc_0).TabIndex = 33;
		((ButtonBase)_cmdRecalc_0).Text = "&Recalc";
		((ButtonBase)_cmdRecalc_0).UseVisualStyleBackColor = false;
		((ButtonBase)_chkOther_0).BackColor = SystemColors.Control;
		((Control)_chkOther_0).Cursor = Cursors.Default;
		((Control)_chkOther_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_chkOther_0).ForeColor = SystemColors.ControlText;
		chkOther.SetIndex(_chkOther_0, (short)0);
		CheckBox chkOther_ = _chkOther_0;
		location = new Point(56, 109);
		((Control)chkOther_).Location = location;
		((Control)_chkOther_0).Name = "_chkOther_0";
		((Control)_chkOther_0).RightToLeft = (RightToLeft)0;
		CheckBox chkOther_2 = _chkOther_0;
		size = new Size(457, 17);
		((Control)chkOther_2).Size = size;
		((Control)_chkOther_0).TabIndex = 31;
		((ButtonBase)_chkOther_0).Text = "x";
		((ButtonBase)_chkOther_0).UseVisualStyleBackColor = false;
		((ButtonBase)_chkOther_1).BackColor = SystemColors.Control;
		((Control)_chkOther_1).Cursor = Cursors.Default;
		((Control)_chkOther_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_chkOther_1).ForeColor = SystemColors.ControlText;
		chkOther.SetIndex(_chkOther_1, (short)1);
		CheckBox chkOther_3 = _chkOther_1;
		location = new Point(56, 61);
		((Control)chkOther_3).Location = location;
		((Control)_chkOther_1).Name = "_chkOther_1";
		((Control)_chkOther_1).RightToLeft = (RightToLeft)0;
		CheckBox chkOther_4 = _chkOther_1;
		size = new Size(457, 17);
		((Control)chkOther_4).Size = size;
		((Control)_chkOther_1).TabIndex = 25;
		((ButtonBase)_chkOther_1).Text = "x";
		((ButtonBase)_chkOther_1).UseVisualStyleBackColor = false;
		((ButtonBase)_chkOther_2).BackColor = SystemColors.Control;
		((Control)_chkOther_2).Cursor = Cursors.Default;
		((Control)_chkOther_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_chkOther_2).ForeColor = SystemColors.ControlText;
		chkOther.SetIndex(_chkOther_2, (short)2);
		CheckBox chkOther_5 = _chkOther_2;
		location = new Point(56, 85);
		((Control)chkOther_5).Location = location;
		((Control)_chkOther_2).Name = "_chkOther_2";
		((Control)_chkOther_2).RightToLeft = (RightToLeft)0;
		CheckBox chkOther_6 = _chkOther_2;
		size = new Size(457, 17);
		((Control)chkOther_6).Size = size;
		((Control)_chkOther_2).TabIndex = 28;
		((ButtonBase)_chkOther_2).Text = "x";
		((ButtonBase)_chkOther_2).UseVisualStyleBackColor = false;
		((ButtonBase)_cmdRecalc_1).BackColor = SystemColors.Control;
		((Control)_cmdRecalc_1).Cursor = Cursors.Default;
		((Control)_cmdRecalc_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_cmdRecalc_1).ForeColor = SystemColors.ControlText;
		cmdRecalc.SetIndex(_cmdRecalc_1, (short)1);
		Button cmdRecalc_3 = _cmdRecalc_1;
		location = new Point(624, 61);
		((Control)cmdRecalc_3).Location = location;
		((Control)_cmdRecalc_1).Name = "_cmdRecalc_1";
		((Control)_cmdRecalc_1).RightToLeft = (RightToLeft)0;
		Button cmdRecalc_4 = _cmdRecalc_1;
		size = new Size(57, 19);
		((Control)cmdRecalc_4).Size = size;
		((Control)_cmdRecalc_1).TabIndex = 27;
		((ButtonBase)_cmdRecalc_1).Text = "&Recalc";
		((ButtonBase)_cmdRecalc_1).UseVisualStyleBackColor = false;
		((ButtonBase)_cmdRecalc_2).BackColor = SystemColors.Control;
		((Control)_cmdRecalc_2).Cursor = Cursors.Default;
		((Control)_cmdRecalc_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_cmdRecalc_2).ForeColor = SystemColors.ControlText;
		cmdRecalc.SetIndex(_cmdRecalc_2, (short)2);
		Button cmdRecalc_5 = _cmdRecalc_2;
		location = new Point(624, 85);
		((Control)cmdRecalc_5).Location = location;
		((Control)_cmdRecalc_2).Name = "_cmdRecalc_2";
		((Control)_cmdRecalc_2).RightToLeft = (RightToLeft)0;
		Button cmdRecalc_6 = _cmdRecalc_2;
		size = new Size(57, 19);
		((Control)cmdRecalc_6).Size = size;
		((Control)_cmdRecalc_2).TabIndex = 30;
		((ButtonBase)_cmdRecalc_2).Text = "&Recalc";
		((ButtonBase)_cmdRecalc_2).UseVisualStyleBackColor = false;
		((Control)_Label1_9).BackColor = SystemColors.Control;
		((Control)_Label1_9).Cursor = Cursors.Default;
		((Control)_Label1_9).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_9).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_9, (short)9);
		Label label1_5 = _Label1_9;
		location = new Point(16, 16);
		((Control)label1_5).Location = location;
		((Control)_Label1_9).Name = "_Label1_9";
		((Control)_Label1_9).RightToLeft = (RightToLeft)0;
		Label label1_6 = _Label1_9;
		size = new Size(665, 55);
		((Control)label1_6).Size = size;
		((Control)_Label1_9).TabIndex = 68;
		_Label1_9.Text = componentResourceManager.GetString("_Label1_9.Text");
		((Control)_lbl5PctError_0).BackColor = SystemColors.Control;
		((Control)_lbl5PctError_0).Cursor = Cursors.Default;
		((Control)_lbl5PctError_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lbl5PctError_0).ForeColor = SystemColors.ControlText;
		lbl5PctError.SetIndex(_lbl5PctError_0, (short)0);
		Label lbl5PctError_ = _lbl5PctError_0;
		location = new Point(8, 432);
		((Control)lbl5PctError_).Location = location;
		((Control)_lbl5PctError_0).Name = "_lbl5PctError_0";
		((Control)_lbl5PctError_0).RightToLeft = (RightToLeft)0;
		Label lbl5PctError_2 = _lbl5PctError_0;
		size = new Size(673, 33);
		((Control)lbl5PctError_2).Size = size;
		((Control)_lbl5PctError_0).TabIndex = 61;
		_lbl5PctError_0.Text = "x";
		((Control)_lblInstructions_1).BackColor = SystemColors.Control;
		((Control)_lblInstructions_1).Cursor = Cursors.Default;
		((Control)_lblInstructions_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblInstructions_1).ForeColor = SystemColors.ControlText;
		lblInstructions.SetIndex(_lblInstructions_1, (short)1);
		Label lblInstructions_ = _lblInstructions_1;
		location = new Point(8, 8);
		((Control)lblInstructions_).Location = location;
		((Control)_lblInstructions_1).Name = "_lblInstructions_1";
		((Control)_lblInstructions_1).RightToLeft = (RightToLeft)0;
		Label lblInstructions_2 = _lblInstructions_1;
		size = new Size(673, 57);
		((Control)lblInstructions_2).Size = size;
		((Control)_lblInstructions_1).TabIndex = 51;
		_lblInstructions_1.Text = "x";
		((Control)_fraStep_0).BackColor = SystemColors.Control;
		((Control)_fraStep_0).Controls.Add((Control)(object)_Frame1_1);
		((Control)_fraStep_0).Controls.Add((Control)(object)_Frame1_0);
		((Control)_fraStep_0).Controls.Add((Control)(object)_Line1_4);
		((Control)_fraStep_0).Controls.Add((Control)(object)lblMassBalMsg);
		((Control)_fraStep_0).Controls.Add((Control)(object)lblMyPVop);
		((Control)_fraStep_0).Controls.Add((Control)(object)_Line1_0);
		((Control)_fraStep_0).Controls.Add((Control)(object)_lblInstructions_2);
		((Control)_fraStep_0).Controls.Add((Control)(object)_Line1_1);
		((Control)_fraStep_0).Controls.Add((Control)(object)_lblInstructions_0);
		((Control)_fraStep_0).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_fraStep_0).ForeColor = SystemColors.ControlText;
		fraStep.SetIndex(_fraStep_0, (short)0);
		GroupBox fraStep_3 = _fraStep_0;
		location = new Point(8, 48);
		((Control)fraStep_3).Location = location;
		((Control)_fraStep_0).Name = "_fraStep_0";
		((Control)_fraStep_0).RightToLeft = (RightToLeft)0;
		GroupBox fraStep_4 = _fraStep_0;
		size = new Size(689, 441);
		((Control)fraStep_4).Size = size;
		((Control)_fraStep_0).TabIndex = 49;
		_fraStep_0.TabStop = false;
		_fraStep_0.Text = "Select type of operation and whether to use raw material or product";
		((Control)_Frame1_1).BackColor = SystemColors.Control;
		((Control)_Frame1_1).Controls.Add((Control)(object)_optInfOrEff_1);
		((Control)_Frame1_1).Controls.Add((Control)(object)_optInfOrEff_0);
		((Control)_Frame1_1).Cursor = Cursors.Default;
		((Control)_Frame1_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Frame1_1).ForeColor = SystemColors.ControlText;
		Frame1.SetIndex(_Frame1_1, (short)1);
		Panel frame1_ = _Frame1_1;
		location = new Point(16, 248);
		((Control)frame1_).Location = location;
		((Control)_Frame1_1).Name = "_Frame1_1";
		((Control)_Frame1_1).RightToLeft = (RightToLeft)0;
		Panel frame1_2 = _Frame1_1;
		size = new Size(537, 73);
		((Control)frame1_2).Size = size;
		((Control)_Frame1_1).TabIndex = 54;
		((ButtonBase)_optInfOrEff_1).BackColor = SystemColors.Control;
		((Control)_optInfOrEff_1).Cursor = Cursors.Default;
		((Control)_optInfOrEff_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optInfOrEff_1).ForeColor = SystemColors.ControlText;
		optInfOrEff.SetIndex(_optInfOrEff_1, (short)1);
		RadioButton optInfOrEff_ = _optInfOrEff_1;
		location = new Point(8, 40);
		((Control)optInfOrEff_).Location = location;
		((Control)_optInfOrEff_1).Name = "_optInfOrEff_1";
		((Control)_optInfOrEff_1).RightToLeft = (RightToLeft)0;
		RadioButton optInfOrEff_2 = _optInfOrEff_1;
		size = new Size(369, 21);
		((Control)optInfOrEff_2).Size = size;
		((Control)_optInfOrEff_1).TabIndex = 3;
		_optInfOrEff_1.TabStop = true;
		((ButtonBase)_optInfOrEff_1).Text = "Product";
		((ButtonBase)_optInfOrEff_1).UseVisualStyleBackColor = false;
		((ButtonBase)_optInfOrEff_0).BackColor = SystemColors.Control;
		((Control)_optInfOrEff_0).Cursor = Cursors.Default;
		((Control)_optInfOrEff_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optInfOrEff_0).ForeColor = SystemColors.ControlText;
		optInfOrEff.SetIndex(_optInfOrEff_0, (short)0);
		RadioButton optInfOrEff_3 = _optInfOrEff_0;
		location = new Point(8, 16);
		((Control)optInfOrEff_3).Location = location;
		((Control)_optInfOrEff_0).Name = "_optInfOrEff_0";
		((Control)_optInfOrEff_0).RightToLeft = (RightToLeft)0;
		RadioButton optInfOrEff_4 = _optInfOrEff_0;
		size = new Size(361, 21);
		((Control)optInfOrEff_4).Size = size;
		((Control)_optInfOrEff_0).TabIndex = 2;
		_optInfOrEff_0.TabStop = true;
		((Control)_optInfOrEff_0).Tag = "0";
		((ButtonBase)_optInfOrEff_0).Text = "Raw Material";
		((ButtonBase)_optInfOrEff_0).UseVisualStyleBackColor = false;
		((Control)_Frame1_0).BackColor = SystemColors.Control;
		((Control)_Frame1_0).Controls.Add((Control)(object)_optContOrBatch_1);
		((Control)_Frame1_0).Controls.Add((Control)(object)_optContOrBatch_0);
		((Control)_Frame1_0).Cursor = Cursors.Default;
		((Control)_Frame1_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Frame1_0).ForeColor = SystemColors.ControlText;
		Frame1.SetIndex(_Frame1_0, (short)0);
		Panel frame1_3 = _Frame1_0;
		location = new Point(16, 120);
		((Control)frame1_3).Location = location;
		((Control)_Frame1_0).Name = "_Frame1_0";
		((Control)_Frame1_0).RightToLeft = (RightToLeft)0;
		Panel frame1_4 = _Frame1_0;
		size = new Size(409, 73);
		((Control)frame1_4).Size = size;
		((Control)_Frame1_0).TabIndex = 53;
		_Frame1_0.Text = "Frame1";
		((ButtonBase)_optContOrBatch_1).BackColor = SystemColors.Control;
		((Control)_optContOrBatch_1).Cursor = Cursors.Default;
		((Control)_optContOrBatch_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optContOrBatch_1).ForeColor = SystemColors.ControlText;
		optContOrBatch.SetIndex(_optContOrBatch_1, (short)1);
		RadioButton optContOrBatch_ = _optContOrBatch_1;
		location = new Point(16, 24);
		((Control)optContOrBatch_).Location = location;
		((Control)_optContOrBatch_1).Name = "_optContOrBatch_1";
		((Control)_optContOrBatch_1).RightToLeft = (RightToLeft)0;
		RadioButton optContOrBatch_2 = _optContOrBatch_1;
		size = new Size(369, 21);
		((Control)optContOrBatch_2).Size = size;
		((Control)_optContOrBatch_1).TabIndex = 1;
		_optContOrBatch_1.TabStop = true;
		((ButtonBase)_optContOrBatch_1).Text = "Batch Operation";
		((ButtonBase)_optContOrBatch_1).UseVisualStyleBackColor = false;
		((ButtonBase)_optContOrBatch_0).BackColor = SystemColors.Control;
		((Control)_optContOrBatch_0).Cursor = Cursors.Default;
		((Control)_optContOrBatch_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optContOrBatch_0).ForeColor = SystemColors.ControlText;
		optContOrBatch.SetIndex(_optContOrBatch_0, (short)0);
		RadioButton optContOrBatch_3 = _optContOrBatch_0;
		location = new Point(16, 0);
		((Control)optContOrBatch_3).Location = location;
		((Control)_optContOrBatch_0).Name = "_optContOrBatch_0";
		((Control)_optContOrBatch_0).RightToLeft = (RightToLeft)0;
		RadioButton optContOrBatch_4 = _optContOrBatch_0;
		size = new Size(161, 21);
		((Control)optContOrBatch_4).Size = size;
		((Control)_optContOrBatch_0).TabIndex = 0;
		_optContOrBatch_0.TabStop = true;
		((Control)_optContOrBatch_0).Tag = "0";
		((ButtonBase)_optContOrBatch_0).Text = "Continuous operation";
		((ButtonBase)_optContOrBatch_0).UseVisualStyleBackColor = false;
		((Control)_Line1_4).BackColor = SystemColors.WindowText;
		Line1.SetIndex(_Line1_4, (short)4);
		Label line1_11 = _Line1_4;
		location = new Point(16, 328);
		((Control)line1_11).Location = location;
		((Control)_Line1_4).Name = "_Line1_4";
		Label line1_12 = _Line1_4;
		size = new Size(648, 1);
		((Control)line1_12).Size = size;
		((Control)_Line1_4).TabIndex = 55;
		((Control)lblMassBalMsg).BackColor = SystemColors.Control;
		((Control)lblMassBalMsg).Cursor = Cursors.Default;
		((Control)lblMassBalMsg).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblMassBalMsg).ForeColor = SystemColors.ControlText;
		Label obj15 = lblMassBalMsg;
		location = new Point(24, 344);
		((Control)obj15).Location = location;
		((Control)lblMassBalMsg).Name = "lblMassBalMsg";
		((Control)lblMassBalMsg).RightToLeft = (RightToLeft)0;
		Label obj16 = lblMassBalMsg;
		size = new Size(641, 81);
		((Control)obj16).Size = size;
		((Control)lblMassBalMsg).TabIndex = 76;
		lblMassBalMsg.Text = "xxx";
		((Control)lblMyPVop).BackColor = SystemColors.Control;
		((Control)lblMyPVop).Cursor = Cursors.Default;
		((Control)lblMyPVop).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)lblMyPVop).ForeColor = SystemColors.ControlText;
		Label obj17 = lblMyPVop;
		location = new Point(16, 24);
		((Control)obj17).Location = location;
		((Control)lblMyPVop).Name = "lblMyPVop";
		((Control)lblMyPVop).RightToLeft = (RightToLeft)0;
		Label obj18 = lblMyPVop;
		size = new Size(545, 17);
		((Control)obj18).Size = size;
		((Control)lblMyPVop).TabIndex = 56;
		lblMyPVop.Text = "This operation has a PVop of: ";
		((Control)_Line1_0).BackColor = SystemColors.WindowText;
		Line1.SetIndex(_Line1_0, (short)0);
		Label line1_13 = _Line1_0;
		location = new Point(16, 200);
		((Control)line1_13).Location = location;
		((Control)_Line1_0).Name = "_Line1_0";
		Label line1_14 = _Line1_0;
		size = new Size(656, 1);
		((Control)line1_14).Size = size;
		((Control)_Line1_0).TabIndex = 77;
		((Control)_lblInstructions_2).BackColor = SystemColors.Control;
		((Control)_lblInstructions_2).Cursor = Cursors.Default;
		((Control)_lblInstructions_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblInstructions_2).ForeColor = SystemColors.ControlText;
		lblInstructions.SetIndex(_lblInstructions_2, (short)2);
		Label lblInstructions_3 = _lblInstructions_2;
		location = new Point(16, 216);
		((Control)lblInstructions_3).Location = location;
		((Control)_lblInstructions_2).Name = "_lblInstructions_2";
		((Control)_lblInstructions_2).RightToLeft = (RightToLeft)0;
		Label lblInstructions_4 = _lblInstructions_2;
		size = new Size(665, 33);
		((Control)lblInstructions_4).Size = size;
		((Control)_lblInstructions_2).TabIndex = 55;
		_lblInstructions_2.Text = "xxx";
		((Control)_Line1_1).BackColor = SystemColors.WindowText;
		Line1.SetIndex(_Line1_1, (short)1);
		Label line1_15 = _Line1_1;
		location = new Point(16, 56);
		((Control)line1_15).Location = location;
		((Control)_Line1_1).Name = "_Line1_1";
		Label line1_16 = _Line1_1;
		size = new Size(656, 1);
		((Control)line1_16).Size = size;
		((Control)_Line1_1).TabIndex = 78;
		((Control)_lblInstructions_0).BackColor = SystemColors.Control;
		((Control)_lblInstructions_0).Cursor = Cursors.Default;
		((Control)_lblInstructions_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblInstructions_0).ForeColor = SystemColors.ControlText;
		lblInstructions.SetIndex(_lblInstructions_0, (short)0);
		Label lblInstructions_5 = _lblInstructions_0;
		location = new Point(16, 88);
		((Control)lblInstructions_5).Location = location;
		((Control)_lblInstructions_0).Name = "_lblInstructions_0";
		((Control)_lblInstructions_0).RightToLeft = (RightToLeft)0;
		Label lblInstructions_6 = _lblInstructions_0;
		size = new Size(665, 25);
		((Control)lblInstructions_6).Size = size;
		((Control)_lblInstructions_0).TabIndex = 52;
		_lblInstructions_0.Text = "xxx";
		((ButtonBase)cmdBasis).BackColor = SystemColors.Control;
		((Control)cmdBasis).Cursor = Cursors.Default;
		((Control)cmdBasis).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdBasis).ForeColor = SystemColors.ControlText;
		Button obj19 = cmdBasis;
		location = new Point(352, 512);
		((Control)obj19).Location = location;
		((Control)cmdBasis).Name = "cmdBasis";
		((Control)cmdBasis).RightToLeft = (RightToLeft)0;
		Button obj20 = cmdBasis;
		size = new Size(97, 25);
		((Control)obj20).Size = size;
		((Control)cmdBasis).TabIndex = 37;
		((ButtonBase)cmdBasis).Text = "&Basis";
		((ButtonBase)cmdBasis).UseVisualStyleBackColor = false;
		((ButtonBase)cmdHelp).BackColor = SystemColors.Control;
		((Control)cmdHelp).Cursor = Cursors.Default;
		((Control)cmdHelp).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdHelp).ForeColor = SystemColors.ControlText;
		Button obj21 = cmdHelp;
		location = new Point(456, 512);
		((Control)obj21).Location = location;
		((Control)cmdHelp).Name = "cmdHelp";
		((Control)cmdHelp).RightToLeft = (RightToLeft)0;
		Button obj22 = cmdHelp;
		size = new Size(97, 25);
		((Control)obj22).Size = size;
		((Control)cmdHelp).TabIndex = 38;
		((ButtonBase)cmdHelp).Text = "&Help";
		((ButtonBase)cmdHelp).UseVisualStyleBackColor = false;
		((ButtonBase)cmdFinish).BackColor = SystemColors.Control;
		((Control)cmdFinish).Cursor = Cursors.Default;
		((Control)cmdFinish).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdFinish).ForeColor = SystemColors.ControlText;
		Button obj23 = cmdFinish;
		location = new Point(144, 512);
		((Control)obj23).Location = location;
		((Control)cmdFinish).Name = "cmdFinish";
		((Control)cmdFinish).RightToLeft = (RightToLeft)0;
		Button obj24 = cmdFinish;
		size = new Size(97, 25);
		((Control)obj24).Size = size;
		((Control)cmdFinish).TabIndex = 35;
		((ButtonBase)cmdFinish).Text = "OK";
		((ButtonBase)cmdFinish).UseVisualStyleBackColor = false;
		((ButtonBase)cmdCancel).BackColor = SystemColors.Control;
		((Control)cmdCancel).Cursor = Cursors.Default;
		cmdCancel.DialogResult = (DialogResult)2;
		((Control)cmdCancel).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCancel).ForeColor = SystemColors.ControlText;
		Button obj25 = cmdCancel;
		location = new Point(248, 512);
		((Control)obj25).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		((Control)cmdCancel).RightToLeft = (RightToLeft)0;
		Button obj26 = cmdCancel;
		size = new Size(97, 25);
		((Control)obj26).Size = size;
		((Control)cmdCancel).TabIndex = 36;
		((ButtonBase)cmdCancel).Text = "Cancel";
		((ButtonBase)cmdCancel).UseVisualStyleBackColor = false;
		((Control)_fraStep_3).BackColor = SystemColors.Control;
		((Control)_fraStep_3).Controls.Add((Control)(object)_lblError_0);
		((Control)_fraStep_3).Controls.Add((Control)(object)_lblError_1);
		((Control)_fraStep_3).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_fraStep_3).ForeColor = SystemColors.ControlText;
		fraStep.SetIndex(_fraStep_3, (short)3);
		GroupBox fraStep_5 = _fraStep_3;
		location = new Point(8, 48);
		((Control)fraStep_5).Location = location;
		((Control)_fraStep_3).Name = "_fraStep_3";
		((Control)_fraStep_3).RightToLeft = (RightToLeft)0;
		GroupBox fraStep_6 = _fraStep_3;
		size = new Size(689, 449);
		((Control)fraStep_6).Size = size;
		((Control)_fraStep_3).TabIndex = 58;
		_fraStep_3.TabStop = false;
		((Control)_fraStep_3).Visible = false;
		((Control)_lblError_0).BackColor = SystemColors.Control;
		((Control)_lblError_0).Cursor = Cursors.Default;
		((Control)_lblError_0).Font = new Font("Arial", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_lblError_0).ForeColor = SystemColors.ControlText;
		lblError.SetIndex(_lblError_0, (short)0);
		Label lblError_ = _lblError_0;
		location = new Point(56, 112);
		((Control)lblError_).Location = location;
		((Control)_lblError_0).Name = "_lblError_0";
		((Control)_lblError_0).RightToLeft = (RightToLeft)0;
		Label lblError_2 = _lblError_0;
		size = new Size(561, 65);
		((Control)lblError_2).Size = size;
		((Control)_lblError_0).TabIndex = 59;
		_lblError_0.Text = "This tab is only valid for Batch Operations";
		_lblError_0.TextAlign = (ContentAlignment)2;
		((Control)_lblError_0).Visible = false;
		((Control)_lblError_1).BackColor = SystemColors.Control;
		((Control)_lblError_1).Cursor = Cursors.Default;
		((Control)_lblError_1).Font = new Font("Arial", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_lblError_1).ForeColor = SystemColors.ControlText;
		lblError.SetIndex(_lblError_1, (short)1);
		Label lblError_3 = _lblError_1;
		location = new Point(96, 96);
		((Control)lblError_3).Location = location;
		((Control)_lblError_1).Name = "_lblError_1";
		((Control)_lblError_1).RightToLeft = (RightToLeft)0;
		Label lblError_4 = _lblError_1;
		size = new Size(497, 113);
		((Control)lblError_4).Size = size;
		((Control)_lblError_1).TabIndex = 60;
		_lblError_1.Text = "You must specify the operation's Mass Balance parameters on the 'Specify Mass Balance Input Parameters' tab before selecting this 'Specify Other Batch Parameters' tab";
		_lblError_1.TextAlign = (ContentAlignment)2;
		((Control)_lblError_1).Visible = false;
		((Control)_fraStep_2).BackColor = SystemColors.Control;
		((Control)_fraStep_2).Controls.Add((Control)(object)_fraTab3_0);
		((Control)_fraStep_2).Controls.Add((Control)(object)_fraTab3_1);
		((Control)_fraStep_2).Controls.Add((Control)(object)_lbl5PctError_1);
		((Control)_fraStep_2).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_fraStep_2).ForeColor = SystemColors.ControlText;
		fraStep.SetIndex(_fraStep_2, (short)2);
		GroupBox fraStep_7 = _fraStep_2;
		location = new Point(8, 48);
		((Control)fraStep_7).Location = location;
		((Control)_fraStep_2).Name = "_fraStep_2";
		((Control)_fraStep_2).RightToLeft = (RightToLeft)0;
		GroupBox fraStep_8 = _fraStep_2;
		size = new Size(689, 449);
		((Control)fraStep_8).Size = size;
		((Control)_fraStep_2).TabIndex = 57;
		_fraStep_2.TabStop = false;
		((Control)_fraStep_2).Visible = false;
		((Control)_fraTab3_0).BackColor = SystemColors.Control;
		((Control)_fraTab3_0).Controls.Add((Control)(object)_txtOBatch1_2);
		((Control)_fraTab3_0).Controls.Add((Control)(object)_txtOBatch1_0);
		((Control)_fraTab3_0).Controls.Add((Control)(object)_txtOBatch1_1);
		((Control)_fraTab3_0).Controls.Add((Control)(object)_lblInstructions_3);
		((Control)_fraTab3_0).Controls.Add((Control)(object)_Label1_11);
		((Control)_fraTab3_0).Controls.Add((Control)(object)_Label1_7);
		((Control)_fraTab3_0).Controls.Add((Control)(object)_Label1_8);
		((Control)_fraTab3_0).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_fraTab3_0).ForeColor = SystemColors.ControlText;
		fraTab3.SetIndex(_fraTab3_0, (short)0);
		GroupBox fraTab3_ = _fraTab3_0;
		location = new Point(0, 32);
		((Control)fraTab3_).Location = location;
		((Control)_fraTab3_0).Name = "_fraTab3_0";
		((Control)_fraTab3_0).RightToLeft = (RightToLeft)0;
		GroupBox fraTab3_2 = _fraTab3_0;
		size = new Size(689, 153);
		((Control)fraTab3_2).Size = size;
		((Control)_fraTab3_0).TabIndex = 67;
		_fraTab3_0.TabStop = false;
		_fraTab3_0.Text = "Batch Frequency Parameters";
		_txtOBatch1_2.AcceptsReturn = true;
		((TextBoxBase)_txtOBatch1_2).BackColor = Color.FromArgb(192, 192, 192);
		((Control)_txtOBatch1_2).Cursor = Cursors.IBeam;
		((Control)_txtOBatch1_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtOBatch1_2).ForeColor = SystemColors.WindowText;
		txtOBatch1.SetIndex(_txtOBatch1_2, (short)2);
		TextBox txtOBatch1_ = _txtOBatch1_2;
		location = new Point(488, 72);
		((Control)txtOBatch1_).Location = location;
		((TextBoxBase)_txtOBatch1_2).MaxLength = 0;
		((Control)_txtOBatch1_2).Name = "_txtOBatch1_2";
		((TextBoxBase)_txtOBatch1_2).ReadOnly = true;
		((Control)_txtOBatch1_2).RightToLeft = (RightToLeft)0;
		TextBox txtOBatch1_2 = _txtOBatch1_2;
		size = new Size(49, 20);
		((Control)txtOBatch1_2).Size = size;
		((Control)_txtOBatch1_2).TabIndex = 4;
		_txtOBatch1_0.AcceptsReturn = true;
		((TextBoxBase)_txtOBatch1_0).BackColor = Color.White;
		((Control)_txtOBatch1_0).Cursor = Cursors.IBeam;
		((Control)_txtOBatch1_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtOBatch1_0).ForeColor = SystemColors.WindowText;
		txtOBatch1.SetIndex(_txtOBatch1_0, (short)0);
		TextBox txtOBatch1_3 = _txtOBatch1_0;
		location = new Point(488, 96);
		((Control)txtOBatch1_3).Location = location;
		((TextBoxBase)_txtOBatch1_0).MaxLength = 0;
		((Control)_txtOBatch1_0).Name = "_txtOBatch1_0";
		((Control)_txtOBatch1_0).RightToLeft = (RightToLeft)0;
		TextBox txtOBatch1_4 = _txtOBatch1_0;
		size = new Size(49, 20);
		((Control)txtOBatch1_4).Size = size;
		((Control)_txtOBatch1_0).TabIndex = 5;
		_txtOBatch1_1.AcceptsReturn = true;
		((TextBoxBase)_txtOBatch1_1).BackColor = Color.White;
		((Control)_txtOBatch1_1).Cursor = Cursors.IBeam;
		((Control)_txtOBatch1_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtOBatch1_1).ForeColor = SystemColors.WindowText;
		txtOBatch1.SetIndex(_txtOBatch1_1, (short)1);
		TextBox txtOBatch1_5 = _txtOBatch1_1;
		location = new Point(488, 120);
		((Control)txtOBatch1_5).Location = location;
		((TextBoxBase)_txtOBatch1_1).MaxLength = 0;
		((Control)_txtOBatch1_1).Name = "_txtOBatch1_1";
		((Control)_txtOBatch1_1).RightToLeft = (RightToLeft)0;
		TextBox txtOBatch1_6 = _txtOBatch1_1;
		size = new Size(49, 20);
		((Control)txtOBatch1_6).Size = size;
		((Control)_txtOBatch1_1).TabIndex = 6;
		((Control)_lblInstructions_3).BackColor = SystemColors.Control;
		((Control)_lblInstructions_3).Cursor = Cursors.Default;
		((Control)_lblInstructions_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblInstructions_3).ForeColor = SystemColors.ControlText;
		lblInstructions.SetIndex(_lblInstructions_3, (short)3);
		Label lblInstructions_7 = _lblInstructions_3;
		location = new Point(16, 24);
		((Control)lblInstructions_7).Location = location;
		((Control)_lblInstructions_3).Name = "_lblInstructions_3";
		((Control)_lblInstructions_3).RightToLeft = (RightToLeft)0;
		Label lblInstructions_8 = _lblInstructions_3;
		size = new Size(657, 41);
		((Control)lblInstructions_8).Size = size;
		((Control)_lblInstructions_3).TabIndex = 74;
		_lblInstructions_3.Text = "xxx";
		((Control)_Label1_11).BackColor = SystemColors.Control;
		((Control)_Label1_11).Cursor = Cursors.Default;
		((Control)_Label1_11).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_11).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_11, (short)11);
		Label label1_7 = _Label1_11;
		location = new Point(72, 72);
		((Control)label1_7).Location = location;
		((Control)_Label1_11).Name = "_Label1_11";
		((Control)_Label1_11).RightToLeft = (RightToLeft)0;
		Label label1_8 = _Label1_11;
		size = new Size(409, 17);
		((Control)label1_8).Size = size;
		((Control)_Label1_11).TabIndex = 71;
		_Label1_11.Text = "Nby: Number of batches/site-year (read-only)";
		((Control)_Label1_7).BackColor = SystemColors.Control;
		((Control)_Label1_7).Cursor = Cursors.Default;
		((Control)_Label1_7).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_7).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_7, (short)7);
		Label label1_9 = _Label1_7;
		location = new Point(72, 96);
		((Control)label1_9).Location = location;
		((Control)_Label1_7).Name = "_Label1_7";
		((Control)_Label1_7).RightToLeft = (RightToLeft)0;
		Label label1_10 = _Label1_7;
		size = new Size(409, 17);
		((Control)label1_10).Size = size;
		((Control)_Label1_7).TabIndex = 70;
		_Label1_7.Text = "HB: Hours per batch";
		((Control)_Label1_8).BackColor = SystemColors.Control;
		((Control)_Label1_8).Cursor = Cursors.Default;
		((Control)_Label1_8).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_8).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_8, (short)8);
		Label label1_11 = _Label1_8;
		location = new Point(72, 120);
		((Control)label1_11).Location = location;
		((Control)_Label1_8).Name = "_Label1_8";
		((Control)_Label1_8).RightToLeft = (RightToLeft)0;
		Label label1_12 = _Label1_8;
		size = new Size(409, 17);
		((Control)label1_12).Size = size;
		((Control)_Label1_8).TabIndex = 69;
		_Label1_8.Text = "ODmax: Maximum possible operating days per year";
		((Control)_fraTab3_1).BackColor = SystemColors.Control;
		((Control)_fraTab3_1).Controls.Add((Control)(object)cmdCalcBatchParms);
		((Control)_fraTab3_1).Controls.Add((Control)(object)_cmdBatchRecalc_2);
		((Control)_fraTab3_1).Controls.Add((Control)(object)_chkOBatch2_0);
		((Control)_fraTab3_1).Controls.Add((Control)(object)_txtOBatch2_0);
		((Control)_fraTab3_1).Controls.Add((Control)(object)_cmdBatchRecalc_0);
		((Control)_fraTab3_1).Controls.Add((Control)(object)_chkOBatch2_1);
		((Control)_fraTab3_1).Controls.Add((Control)(object)_txtOBatch2_1);
		((Control)_fraTab3_1).Controls.Add((Control)(object)_cmdBatchRecalc_1);
		((Control)_fraTab3_1).Controls.Add((Control)(object)_chkOBatch2_2);
		((Control)_fraTab3_1).Controls.Add((Control)(object)_txtOBatch2_2);
		((Control)_fraTab3_1).Controls.Add((Control)(object)txtOBatch3);
		((Control)_fraTab3_1).Controls.Add((Control)(object)_lblInstructions_4);
		((Control)_fraTab3_1).Controls.Add((Control)(object)_Label1_10);
		((Control)_fraTab3_1).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_fraTab3_1).ForeColor = SystemColors.ControlText;
		fraTab3.SetIndex(_fraTab3_1, (short)1);
		GroupBox fraTab3_3 = _fraTab3_1;
		location = new Point(0, 208);
		((Control)fraTab3_3).Location = location;
		((Control)_fraTab3_1).Name = "_fraTab3_1";
		((Control)_fraTab3_1).RightToLeft = (RightToLeft)0;
		GroupBox fraTab3_4 = _fraTab3_1;
		size = new Size(689, 243);
		((Control)fraTab3_4).Size = size;
		((Control)_fraTab3_1).TabIndex = 72;
		_fraTab3_1.TabStop = false;
		_fraTab3_1.Text = "Daily Batch Parameters Calculation";
		((ButtonBase)cmdCalcBatchParms).BackColor = SystemColors.Control;
		((Control)cmdCalcBatchParms).Cursor = Cursors.Default;
		((Control)cmdCalcBatchParms).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCalcBatchParms).ForeColor = SystemColors.ControlText;
		Button obj27 = cmdCalcBatchParms;
		location = new Point(256, 198);
		((Control)obj27).Location = location;
		((Control)cmdCalcBatchParms).Name = "cmdCalcBatchParms";
		((Control)cmdCalcBatchParms).RightToLeft = (RightToLeft)0;
		Button obj28 = cmdCalcBatchParms;
		size = new Size(169, 25);
		((Control)obj28).Size = size;
		((Control)cmdCalcBatchParms).TabIndex = 14;
		((ButtonBase)cmdCalcBatchParms).Text = "&Calculate Defaults";
		((ButtonBase)cmdCalcBatchParms).UseVisualStyleBackColor = false;
		((ButtonBase)_cmdBatchRecalc_2).BackColor = SystemColors.Control;
		((Control)_cmdBatchRecalc_2).Cursor = Cursors.Default;
		((Control)_cmdBatchRecalc_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_cmdBatchRecalc_2).ForeColor = SystemColors.ControlText;
		cmdBatchRecalc.SetIndex(_cmdBatchRecalc_2, (short)2);
		Button cmdBatchRecalc_ = _cmdBatchRecalc_2;
		location = new Point(536, 142);
		((Control)cmdBatchRecalc_).Location = location;
		((Control)_cmdBatchRecalc_2).Name = "_cmdBatchRecalc_2";
		((Control)_cmdBatchRecalc_2).RightToLeft = (RightToLeft)0;
		Button cmdBatchRecalc_2 = _cmdBatchRecalc_2;
		size = new Size(57, 19);
		((Control)cmdBatchRecalc_2).Size = size;
		((Control)_cmdBatchRecalc_2).TabIndex = 12;
		((ButtonBase)_cmdBatchRecalc_2).Text = "&Recalc";
		((ButtonBase)_cmdBatchRecalc_2).UseVisualStyleBackColor = false;
		((ButtonBase)_chkOBatch2_0).BackColor = SystemColors.Control;
		((Control)_chkOBatch2_0).Cursor = Cursors.Default;
		((Control)_chkOBatch2_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_chkOBatch2_0).ForeColor = SystemColors.ControlText;
		chkOBatch2.SetIndex(_chkOBatch2_0, (short)0);
		CheckBox chkOBatch2_ = _chkOBatch2_0;
		location = new Point(48, 94);
		((Control)chkOBatch2_).Location = location;
		((Control)_chkOBatch2_0).Name = "_chkOBatch2_0";
		((Control)_chkOBatch2_0).RightToLeft = (RightToLeft)0;
		CheckBox chkOBatch2_2 = _chkOBatch2_0;
		size = new Size(401, 17);
		((Control)chkOBatch2_2).Size = size;
		((Control)_chkOBatch2_0).TabIndex = 45;
		((ButtonBase)_chkOBatch2_0).Text = "Nbld: Number of batches per line per day";
		((ButtonBase)_chkOBatch2_0).UseVisualStyleBackColor = false;
		_txtOBatch2_0.AcceptsReturn = true;
		((TextBoxBase)_txtOBatch2_0).BackColor = Color.FromArgb(192, 192, 192);
		((Control)_txtOBatch2_0).Cursor = Cursors.IBeam;
		((Control)_txtOBatch2_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtOBatch2_0).ForeColor = SystemColors.WindowText;
		txtOBatch2.SetIndex(_txtOBatch2_0, (short)0);
		TextBox txtOBatch2_ = _txtOBatch2_0;
		location = new Point(480, 94);
		((Control)txtOBatch2_).Location = location;
		((TextBoxBase)_txtOBatch2_0).MaxLength = 0;
		((Control)_txtOBatch2_0).Name = "_txtOBatch2_0";
		((TextBoxBase)_txtOBatch2_0).ReadOnly = true;
		((Control)_txtOBatch2_0).RightToLeft = (RightToLeft)0;
		TextBox txtOBatch2_2 = _txtOBatch2_0;
		size = new Size(49, 20);
		((Control)txtOBatch2_2).Size = size;
		((Control)_txtOBatch2_0).TabIndex = 7;
		((ButtonBase)_cmdBatchRecalc_0).BackColor = SystemColors.Control;
		((Control)_cmdBatchRecalc_0).Cursor = Cursors.Default;
		((Control)_cmdBatchRecalc_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_cmdBatchRecalc_0).ForeColor = SystemColors.ControlText;
		cmdBatchRecalc.SetIndex(_cmdBatchRecalc_0, (short)0);
		Button cmdBatchRecalc_3 = _cmdBatchRecalc_0;
		location = new Point(536, 94);
		((Control)cmdBatchRecalc_3).Location = location;
		((Control)_cmdBatchRecalc_0).Name = "_cmdBatchRecalc_0";
		((Control)_cmdBatchRecalc_0).RightToLeft = (RightToLeft)0;
		Button cmdBatchRecalc_4 = _cmdBatchRecalc_0;
		size = new Size(57, 19);
		((Control)cmdBatchRecalc_4).Size = size;
		((Control)_cmdBatchRecalc_0).TabIndex = 8;
		((ButtonBase)_cmdBatchRecalc_0).Text = "&Recalc";
		((ButtonBase)_cmdBatchRecalc_0).UseVisualStyleBackColor = false;
		((ButtonBase)_chkOBatch2_1).BackColor = SystemColors.Control;
		((Control)_chkOBatch2_1).Cursor = Cursors.Default;
		((Control)_chkOBatch2_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_chkOBatch2_1).ForeColor = SystemColors.ControlText;
		chkOBatch2.SetIndex(_chkOBatch2_1, (short)1);
		CheckBox chkOBatch2_3 = _chkOBatch2_1;
		location = new Point(48, 118);
		((Control)chkOBatch2_3).Location = location;
		((Control)_chkOBatch2_1).Name = "_chkOBatch2_1";
		((Control)_chkOBatch2_1).RightToLeft = (RightToLeft)0;
		CheckBox chkOBatch2_4 = _chkOBatch2_1;
		size = new Size(401, 17);
		((Control)chkOBatch2_4).Size = size;
		((Control)_chkOBatch2_1).TabIndex = 46;
		((ButtonBase)_chkOBatch2_1).Text = "Ls: Processing lines per site";
		((ButtonBase)_chkOBatch2_1).UseVisualStyleBackColor = false;
		_txtOBatch2_1.AcceptsReturn = true;
		((TextBoxBase)_txtOBatch2_1).BackColor = Color.FromArgb(192, 192, 192);
		((Control)_txtOBatch2_1).Cursor = Cursors.IBeam;
		((Control)_txtOBatch2_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtOBatch2_1).ForeColor = SystemColors.WindowText;
		txtOBatch2.SetIndex(_txtOBatch2_1, (short)1);
		TextBox txtOBatch2_3 = _txtOBatch2_1;
		location = new Point(480, 118);
		((Control)txtOBatch2_3).Location = location;
		((TextBoxBase)_txtOBatch2_1).MaxLength = 0;
		((Control)_txtOBatch2_1).Name = "_txtOBatch2_1";
		((TextBoxBase)_txtOBatch2_1).ReadOnly = true;
		((Control)_txtOBatch2_1).RightToLeft = (RightToLeft)0;
		TextBox txtOBatch2_4 = _txtOBatch2_1;
		size = new Size(49, 20);
		((Control)txtOBatch2_4).Size = size;
		((Control)_txtOBatch2_1).TabIndex = 9;
		((ButtonBase)_cmdBatchRecalc_1).BackColor = SystemColors.Control;
		((Control)_cmdBatchRecalc_1).Cursor = Cursors.Default;
		((Control)_cmdBatchRecalc_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_cmdBatchRecalc_1).ForeColor = SystemColors.ControlText;
		cmdBatchRecalc.SetIndex(_cmdBatchRecalc_1, (short)1);
		Button cmdBatchRecalc_5 = _cmdBatchRecalc_1;
		location = new Point(536, 118);
		((Control)cmdBatchRecalc_5).Location = location;
		((Control)_cmdBatchRecalc_1).Name = "_cmdBatchRecalc_1";
		((Control)_cmdBatchRecalc_1).RightToLeft = (RightToLeft)0;
		Button cmdBatchRecalc_6 = _cmdBatchRecalc_1;
		size = new Size(57, 19);
		((Control)cmdBatchRecalc_6).Size = size;
		((Control)_cmdBatchRecalc_1).TabIndex = 10;
		((ButtonBase)_cmdBatchRecalc_1).Text = "&Recalc";
		((ButtonBase)_cmdBatchRecalc_1).UseVisualStyleBackColor = false;
		((ButtonBase)_chkOBatch2_2).BackColor = SystemColors.Control;
		((Control)_chkOBatch2_2).Cursor = Cursors.Default;
		((Control)_chkOBatch2_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_chkOBatch2_2).ForeColor = SystemColors.ControlText;
		chkOBatch2.SetIndex(_chkOBatch2_2, (short)2);
		CheckBox chkOBatch2_5 = _chkOBatch2_2;
		location = new Point(48, 142);
		((Control)chkOBatch2_5).Location = location;
		((Control)_chkOBatch2_2).Name = "_chkOBatch2_2";
		((Control)_chkOBatch2_2).RightToLeft = (RightToLeft)0;
		CheckBox chkOBatch2_6 = _chkOBatch2_2;
		size = new Size(401, 17);
		((Control)chkOBatch2_6).Size = size;
		((Control)_chkOBatch2_2).TabIndex = 47;
		((ButtonBase)_chkOBatch2_2).Text = "OD: Operating days per year";
		((ButtonBase)_chkOBatch2_2).UseVisualStyleBackColor = false;
		_txtOBatch2_2.AcceptsReturn = true;
		((TextBoxBase)_txtOBatch2_2).BackColor = Color.FromArgb(192, 192, 192);
		((Control)_txtOBatch2_2).Cursor = Cursors.IBeam;
		((Control)_txtOBatch2_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtOBatch2_2).ForeColor = SystemColors.WindowText;
		txtOBatch2.SetIndex(_txtOBatch2_2, (short)2);
		TextBox txtOBatch2_5 = _txtOBatch2_2;
		location = new Point(480, 142);
		((Control)txtOBatch2_5).Location = location;
		((TextBoxBase)_txtOBatch2_2).MaxLength = 0;
		((Control)_txtOBatch2_2).Name = "_txtOBatch2_2";
		((TextBoxBase)_txtOBatch2_2).ReadOnly = true;
		((Control)_txtOBatch2_2).RightToLeft = (RightToLeft)0;
		TextBox txtOBatch2_6 = _txtOBatch2_2;
		size = new Size(49, 20);
		((Control)txtOBatch2_6).Size = size;
		((Control)_txtOBatch2_2).TabIndex = 11;
		txtOBatch3.AcceptsReturn = true;
		((TextBoxBase)txtOBatch3).BackColor = Color.FromArgb(192, 192, 192);
		((Control)txtOBatch3).Cursor = Cursors.IBeam;
		((Control)txtOBatch3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtOBatch3).ForeColor = SystemColors.WindowText;
		TextBox obj29 = txtOBatch3;
		location = new Point(480, 166);
		((Control)obj29).Location = location;
		((TextBoxBase)txtOBatch3).MaxLength = 0;
		((Control)txtOBatch3).Name = "txtOBatch3";
		((TextBoxBase)txtOBatch3).ReadOnly = true;
		((Control)txtOBatch3).RightToLeft = (RightToLeft)0;
		TextBox obj30 = txtOBatch3;
		size = new Size(49, 20);
		((Control)obj30).Size = size;
		((Control)txtOBatch3).TabIndex = 13;
		((Control)_lblInstructions_4).BackColor = SystemColors.Control;
		((Control)_lblInstructions_4).Cursor = Cursors.Default;
		((Control)_lblInstructions_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblInstructions_4).ForeColor = SystemColors.ControlText;
		lblInstructions.SetIndex(_lblInstructions_4, (short)4);
		Label lblInstructions_9 = _lblInstructions_4;
		location = new Point(16, 24);
		((Control)lblInstructions_9).Location = location;
		((Control)_lblInstructions_4).Name = "_lblInstructions_4";
		((Control)_lblInstructions_4).RightToLeft = (RightToLeft)0;
		Label lblInstructions_10 = _lblInstructions_4;
		size = new Size(657, 67);
		((Control)lblInstructions_10).Size = size;
		((Control)_lblInstructions_4).TabIndex = 75;
		_lblInstructions_4.Text = "xxx";
		((Control)_Label1_10).BackColor = SystemColors.Control;
		((Control)_Label1_10).Cursor = Cursors.Default;
		((Control)_Label1_10).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_10).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_10, (short)10);
		Label label1_13 = _Label1_10;
		location = new Point(64, 174);
		((Control)label1_13).Location = location;
		((Control)_Label1_10).Name = "_Label1_10";
		((Control)_Label1_10).RightToLeft = (RightToLeft)0;
		Label label1_14 = _Label1_10;
		size = new Size(409, 17);
		((Control)label1_14).Size = size;
		((Control)_Label1_10).TabIndex = 73;
		_Label1_10.Text = "Nbd: Number of batches/site-day (Nbld x Ls)";
		((Control)_lbl5PctError_1).BackColor = SystemColors.Control;
		((Control)_lbl5PctError_1).Cursor = Cursors.Default;
		((Control)_lbl5PctError_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lbl5PctError_1).ForeColor = SystemColors.ControlText;
		lbl5PctError.SetIndex(_lbl5PctError_1, (short)1);
		Label lbl5PctError_3 = _lbl5PctError_1;
		location = new Point(8, 432);
		((Control)lbl5PctError_3).Location = location;
		((Control)_lbl5PctError_1).Name = "_lbl5PctError_1";
		((Control)_lbl5PctError_1).RightToLeft = (RightToLeft)0;
		Label lbl5PctError_4 = _lbl5PctError_1;
		size = new Size(673, 33);
		((Control)lbl5PctError_4).Size = size;
		((Control)_lbl5PctError_1).TabIndex = 62;
		_lbl5PctError_1.Text = "x";
		AxTabStrip obj31 = tabs;
		location = new Point(0, 24);
		((Control)obj31).Location = location;
		((Control)tabs).Name = "tabs";
		((AxHost)tabs).OcxState = (State)componentResourceManager.GetObject("tabs.OcxState");
		AxTabStrip obj32 = tabs;
		size = new Size(705, 521);
		((Control)obj32).Size = size;
		((Control)tabs).TabIndex = 44;
		((Control)lblOp).BackColor = SystemColors.Control;
		((Control)lblOp).Cursor = Cursors.Default;
		((Control)lblOp).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)lblOp).ForeColor = SystemColors.ControlText;
		Label obj33 = lblOp;
		location = new Point(8, 0);
		((Control)obj33).Location = location;
		((Control)lblOp).Name = "lblOp";
		((Control)lblOp).RightToLeft = (RightToLeft)0;
		Label obj34 = lblOp;
		size = new Size(577, 17);
		((Control)obj34).Size = size;
		((Control)lblOp).TabIndex = 48;
		lblOp.Text = "x";
		((Form)this).AcceptButton = (IButtonControl)(object)cmdFinish;
		size = new Size(5, 13);
		((Form)this).AutoScaleBaseSize = size;
		((Form)this).BackColor = SystemColors.Control;
		((Form)this).CancelButton = (IButtonControl)(object)cmdCancel;
		size = new Size(706, 544);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)cmdBasis);
		((Control)this).Controls.Add((Control)(object)cmdHelp);
		((Control)this).Controls.Add((Control)(object)cmdFinish);
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)lblOp);
		((Control)this).Controls.Add((Control)(object)_fraStep_1);
		((Control)this).Controls.Add((Control)(object)_fraStep_2);
		((Control)this).Controls.Add((Control)(object)_fraStep_3);
		((Control)this).Controls.Add((Control)(object)_fraStep_0);
		((Control)this).Controls.Add((Control)(object)tabs);
		((Control)this).Cursor = Cursors.Default;
		((Control)this).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		location = new Point(250, 150);
		((Form)this).Location = location;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmMDUpdOpIP";
		((Control)this).RightToLeft = (RightToLeft)0;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Update Operation Mass Accounting Parameters";
		((Control)_fraStep_1).ResumeLayout(false);
		((Control)_fraTab2_0).ResumeLayout(false);
		((Control)_fraTab2_0).PerformLayout();
		((Control)_fraTab2_1).ResumeLayout(false);
		((Control)_fraTab2_1).PerformLayout();
		((Control)_fraStep_0).ResumeLayout(false);
		((Control)_Frame1_1).ResumeLayout(false);
		((Control)_Frame1_0).ResumeLayout(false);
		((Control)_fraStep_3).ResumeLayout(false);
		((Control)_fraStep_2).ResumeLayout(false);
		((Control)_fraTab3_0).ResumeLayout(false);
		((Control)_fraTab3_0).PerformLayout();
		((Control)_fraTab3_1).ResumeLayout(false);
		((Control)_fraTab3_1).PerformLayout();
		((ISupportInitialize)tabs).EndInit();
		((ISupportInitialize)Frame1).EndInit();
		((ISupportInitialize)Label1).EndInit();
		((ISupportInitialize)Line1).EndInit();
		((ISupportInitialize)chkKnowns1).EndInit();
		((ISupportInitialize)chkOBatch2).EndInit();
		((ISupportInitialize)chkOther).EndInit();
		((ISupportInitialize)cmdBatchRecalc).EndInit();
		((ISupportInitialize)cmdRecalc).EndInit();
		((ISupportInitialize)fraStep).EndInit();
		((ISupportInitialize)fraTab2).EndInit();
		((ISupportInitialize)fraTab3).EndInit();
		((ISupportInitialize)lbl5PctError).EndInit();
		((ISupportInitialize)lblError).EndInit();
		((ISupportInitialize)lblInstructions).EndInit();
		((ISupportInitialize)optContOrBatch).EndInit();
		((ISupportInitialize)optInfOrEff).EndInit();
		((ISupportInitialize)txtKnowns).EndInit();
		((ISupportInitialize)txtOBatch1).EndInit();
		((ISupportInitialize)txtOBatch2).EndInit();
		((ISupportInitialize)txtOther).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public bool SetUp()
	{
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_063b: Unknown result type (might be due to invalid IL or missing references)
		//IL_130e: Unknown result type (might be due to invalid IL or missing references)
		//IL_133a: Unknown result type (might be due to invalid IL or missing references)
		//IL_13c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_136c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1398: Unknown result type (might be due to invalid IL or missing references)
		//IL_1731: Unknown result type (might be due to invalid IL or missing references)
		//IL_1736: Unknown result type (might be due to invalid IL or missing references)
		//IL_173c: Invalid comparison between Unknown and I4
		//IL_17c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_17cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_17d1: Invalid comparison between Unknown and I4
		//IL_1976: Unknown result type (might be due to invalid IL or missing references)
		//IL_197b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1981: Invalid comparison between Unknown and I4
		//IL_1b1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b22: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b28: Invalid comparison between Unknown and I4
		//IL_18cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_18d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_18d7: Invalid comparison between Unknown and I4
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
						COFarOpParms = new float[163, Globals_Renamed.intNumOps + 1];
						COFarOpParmsType = new short[163, Globals_Renamed.intNumOps + 1];
						((Control)_fraStep_0).Visible = true;
						((Control)_fraStep_1).Visible = false;
						((Control)_fraStep_2).Visible = false;
						((Control)_fraStep_3).Visible = false;
						bSettingGroup4Defaults = true;
						command.ActiveConnection = Common.MyConn;
						command.CommandText = "pqryGetInstructions";
						command.CommandType = CommandTypeEnum.adCmdStoredProc;
						short num3 = 0;
						short num4;
						object Parameters;
						object RecordsAffected;
						short num5;
						do
						{
							command.Parameters.Append(command.CreateParameter("pID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, num3 + 8));
							Command command2 = command;
							RecordsAffected = Missing.Value;
							Parameters = Missing.Value;
							recordset = command2.Execute(out RecordsAffected, ref Parameters);
							command.Parameters.Delete("pID");
							unchecked
							{
								if (num3 == 0 || num3 == 2)
								{
									((Control)_fraStep_0).Controls["_lblInstructions_" + Conversions.ToString((int)num3)].Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields[0].Value)), (object)"", RuntimeHelpers.GetObjectValue(recordset.Fields[0].Value)));
								}
								else
								{
									switch (num3)
									{
									case 1:
										((Control)_fraStep_1).Controls["_lblInstructions_" + Conversions.ToString((int)num3)].Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields[0].Value)), (object)"", RuntimeHelpers.GetObjectValue(recordset.Fields[0].Value)));
										break;
									case 3:
										((Control)_fraTab3_0).Controls["_lblInstructions_" + Conversions.ToString((int)num3)].Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields[0].Value)), (object)"", RuntimeHelpers.GetObjectValue(recordset.Fields[0].Value)));
										break;
									case 4:
										((Control)_fraTab3_1).Controls["_lblInstructions_" + Conversions.ToString((int)num3)].Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields[0].Value)), (object)"", RuntimeHelpers.GetObjectValue(recordset.Fields[0].Value)));
										break;
									}
								}
								recordset.Close();
							}
							num3 = (short)unchecked(num3 + 1);
							num4 = num3;
							num5 = 4;
						}
						while (num4 <= num5);
						unchecked
						{
							((RadioButton)((Control)_Frame1_0).Controls["_optContOrBatch_" + Conversions.ToString((int)Globals_Renamed.arOpBorC[Globals_Renamed.intOpIndex])]).Checked = true;
							((RadioButton)((Control)_Frame1_1).Controls["_optInfOrEff_" + Conversions.ToString((int)Globals_Renamed.arOpIoE[Globals_Renamed.intOpIndex])]).Checked = true;
							command.ActiveConnection = Common.MyConn;
							command.CommandText = "pqryGetInfEffLabelOverrides";
							command.CommandType = CommandTypeEnum.adCmdStoredProc;
							command.Parameters.Append(command.CreateParameter("pOpID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, Globals_Renamed.arOpType[Support.GetItemData((Control)(object)frmMain.DefInstance._lstSelOps_1, frmMain.DefInstance._lstSelOps_1.SelectedIndex)]));
							Command command3 = command;
							Parameters = Missing.Value;
							RecordsAffected = Missing.Value;
							recordset = command3.Execute(out Parameters, ref RecordsAffected);
							command.Parameters.Delete("pOpID");
						}
						if (!recordset.EOF)
						{
							num3 = 0;
							short num6;
							do
							{
								if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields[num3].Value)))
								{
									((Control)_Frame1_1).Controls["_optInfOrEff_" + Conversions.ToString(unchecked((int)num3))].Text = Conversions.ToString(recordset.Fields[num3].Value);
								}
								num3 = (short)unchecked(num3 + 1);
								num6 = num3;
								num5 = 1;
							}
							while (num6 <= num5);
							bEnableCmdCalcXmoProd = Operators.ConditionalCompareObjectEqual(recordset.Fields["EnableCmdCalcXmoProd"].Value, (object)1, false);
							bEnableCmdCalcNS = Operators.ConditionalCompareObjectEqual(recordset.Fields["EnableCmdCalcNS"].Value, (object)1, false);
							bEnableCmdCalcYprod = Operators.ConditionalCompareObjectEqual(recordset.Fields["EnableCmdCalcYprod"].Value, (object)1, false);
							if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["MassBalMsg"].Value)))
							{
								lblMassBalMsg.Text = "";
							}
							else
							{
								lblMassBalMsg.Text = Conversions.ToString(recordset.Fields["MassBalMsg"].Value);
							}
							recordset.Close();
						}
						((Control)cmdCalcXmoProd).Enabled = bEnableCmdCalcXmoProd & ((RadioButton)((Control)_Frame1_0).Controls["_optContOrBatch_" + Conversions.ToString(1)]).Checked;
						((Control)cmdCalcNS).Enabled = bEnableCmdCalcNS & ((RadioButton)((Control)_Frame1_0).Controls["_optContOrBatch_" + Conversions.ToString(1)]).Checked;
						((Control)cmdCalcYprod).Enabled = bEnableCmdCalcYprod & ((RadioButton)((Control)_Frame1_0).Controls["_optContOrBatch_" + Conversions.ToString(1)]).Checked;
						lblOp.Text = frmMain.DefInstance._lstSelOps_1.Text;
						_chkKnowns1_0.CheckState = (CheckState)Conversions.ToInteger(Interaction.IIf(Globals_Renamed.arOpParmsType[1, Globals_Renamed.intOpIndex] == 2, (object)(CheckState)1, (object)(CheckState)0));
						_txtKnowns_0.Text = ChemStrX.ShowZeroAsNull(Globals_Renamed.arOpParms[1, Globals_Renamed.intOpIndex]);
						if (Globals_Renamed.arOpBorC[Globals_Renamed.intOpIndex] == 0)
						{
							_chkKnowns1_1.CheckState = (CheckState)Conversions.ToInteger(Interaction.IIf(Globals_Renamed.arOpParmsType[2, Globals_Renamed.intOpIndex] == 2, (object)(CheckState)1, (object)(CheckState)0));
							_txtKnowns_1.Text = ChemStrX.ShowZeroAsNull(Globals_Renamed.arOpParms[2, Globals_Renamed.intOpIndex]);
							if (Globals_Renamed.arOpIoE[Globals_Renamed.intOpIndex] == 0)
							{
								_chkKnowns1_2.CheckState = (CheckState)Conversions.ToInteger(Interaction.IIf(Globals_Renamed.arOpParmsType[15, Globals_Renamed.intOpIndex] == 2, (object)(CheckState)1, (object)(CheckState)0));
								_txtKnowns_2.Text = ChemStrX.ShowZeroAsNull(Globals_Renamed.arOpParms[15, Globals_Renamed.intOpIndex]);
								_chkKnowns1_3.CheckState = (CheckState)Conversions.ToInteger(Interaction.IIf(Globals_Renamed.arOpParmsType[11, Globals_Renamed.intOpIndex] == 2, (object)(CheckState)1, (object)(CheckState)0));
								_txtKnowns_3.Text = ChemStrX.ShowZeroAsNull(Globals_Renamed.arOpParms[11, Globals_Renamed.intOpIndex]);
								_chkKnowns1_4.CheckState = (CheckState)Conversions.ToInteger(Interaction.IIf(Globals_Renamed.arOpParmsType[14, Globals_Renamed.intOpIndex] == 2, (object)(CheckState)1, (object)(CheckState)0));
								_txtKnowns_4.Text = ChemStrX.ShowZeroAsNull(Globals_Renamed.arOpParms[14, Globals_Renamed.intOpIndex]);
								if (Globals_Renamed.arOpParms[11, Globals_Renamed.intOpIndex] == 0f)
								{
									_txtOther_0.Text = ChemStrX.ShowZeroAsNull(Globals_Renamed.arOpParms[13, Globals_Renamed.intOpIndex]);
									_txtOther_1.Text = ChemStrX.ShowZeroAsNull(Globals_Renamed.arOpParms[10, Globals_Renamed.intOpIndex]);
									_txtOther_2.Text = ChemStrX.ShowZeroAsNull(Globals_Renamed.arOpParms[12, Globals_Renamed.intOpIndex]);
								}
								else
								{
									_txtOther_0.Text = Conversions.ToString(Globals_Renamed.arOpParms[13, Globals_Renamed.intOpIndex]);
									_txtOther_1.Text = Conversions.ToString(Globals_Renamed.arOpParms[10, Globals_Renamed.intOpIndex]);
									_txtOther_2.Text = Conversions.ToString(Globals_Renamed.arOpParms[12, Globals_Renamed.intOpIndex]);
								}
								_chkOther_0.CheckState = (CheckState)Conversions.ToInteger(Interaction.IIf(Globals_Renamed.arOpParmsType[13, Globals_Renamed.intOpIndex] == 2, (object)(CheckState)1, (object)(CheckState)0));
								_chkOther_1.CheckState = (CheckState)Conversions.ToInteger(Interaction.IIf(Globals_Renamed.arOpParmsType[10, Globals_Renamed.intOpIndex] == 2, (object)(CheckState)1, (object)(CheckState)0));
								_chkOther_2.CheckState = (CheckState)Conversions.ToInteger(Interaction.IIf(Globals_Renamed.arOpParmsType[12, Globals_Renamed.intOpIndex] == 2, (object)(CheckState)1, (object)(CheckState)0));
							}
							else
							{
								_chkKnowns1_2.CheckState = (CheckState)Conversions.ToInteger(Interaction.IIf(Globals_Renamed.arOpParmsType[13, Globals_Renamed.intOpIndex] == 2, (object)(CheckState)1, (object)(CheckState)0));
								_txtKnowns_2.Text = ChemStrX.ShowZeroAsNull(Globals_Renamed.arOpParms[13, Globals_Renamed.intOpIndex]);
								_chkKnowns1_3.CheckState = (CheckState)Conversions.ToInteger(Interaction.IIf(Globals_Renamed.arOpParmsType[10, Globals_Renamed.intOpIndex] == 2, (object)(CheckState)1, (object)(CheckState)0));
								_txtKnowns_3.Text = ChemStrX.ShowZeroAsNull(Globals_Renamed.arOpParms[10, Globals_Renamed.intOpIndex]);
								_chkKnowns1_4.CheckState = (CheckState)Conversions.ToInteger(Interaction.IIf(Globals_Renamed.arOpParmsType[12, Globals_Renamed.intOpIndex] == 2, (object)(CheckState)1, (object)(CheckState)0));
								_txtKnowns_4.Text = ChemStrX.ShowZeroAsNull(Globals_Renamed.arOpParms[12, Globals_Renamed.intOpIndex]);
								if (Globals_Renamed.arOpParms[10, Globals_Renamed.intOpIndex] == 0f)
								{
									_txtOther_0.Text = ChemStrX.ShowZeroAsNull(Globals_Renamed.arOpParms[15, Globals_Renamed.intOpIndex]);
									_txtOther_1.Text = ChemStrX.ShowZeroAsNull(Globals_Renamed.arOpParms[11, Globals_Renamed.intOpIndex]);
									_txtOther_2.Text = ChemStrX.ShowZeroAsNull(Globals_Renamed.arOpParms[14, Globals_Renamed.intOpIndex]);
								}
								else
								{
									_txtOther_0.Text = Conversions.ToString(Globals_Renamed.arOpParms[15, Globals_Renamed.intOpIndex]);
									_txtOther_1.Text = Conversions.ToString(Globals_Renamed.arOpParms[11, Globals_Renamed.intOpIndex]);
									_txtOther_2.Text = Conversions.ToString(Globals_Renamed.arOpParms[14, Globals_Renamed.intOpIndex]);
								}
								_chkOther_0.CheckState = (CheckState)Conversions.ToInteger(Interaction.IIf(Globals_Renamed.arOpParmsType[15, Globals_Renamed.intOpIndex] == 2, (object)(CheckState)1, (object)(CheckState)0));
								_chkOther_1.CheckState = (CheckState)Conversions.ToInteger(Interaction.IIf(Globals_Renamed.arOpParmsType[11, Globals_Renamed.intOpIndex] == 2, (object)(CheckState)1, (object)(CheckState)0));
								_chkOther_2.CheckState = (CheckState)Conversions.ToInteger(Interaction.IIf(Globals_Renamed.arOpParmsType[14, Globals_Renamed.intOpIndex] == 2, (object)(CheckState)1, (object)(CheckState)0));
							}
						}
						else
						{
							_chkKnowns1_1.CheckState = (CheckState)Conversions.ToInteger(Interaction.IIf(Globals_Renamed.arOpParmsType[16, Globals_Renamed.intOpIndex] == 2, (object)(CheckState)1, (object)(CheckState)0));
							_txtKnowns_1.Text = ChemStrX.ShowZeroAsNull(Globals_Renamed.arOpParms[16, Globals_Renamed.intOpIndex]);
							if (Globals_Renamed.arOpIoE[Globals_Renamed.intOpIndex] == 0)
							{
								_chkKnowns1_3.CheckState = (CheckState)Conversions.ToInteger(Interaction.IIf(Globals_Renamed.arOpParmsType[11, Globals_Renamed.intOpIndex] == 2, (object)(CheckState)1, (object)(CheckState)0));
								_txtKnowns_3.Text = ChemStrX.ShowZeroAsNull(Globals_Renamed.arOpParms[11, Globals_Renamed.intOpIndex]);
								_chkKnowns1_4.CheckState = (CheckState)Conversions.ToInteger(Interaction.IIf(Globals_Renamed.arOpParmsType[99, Globals_Renamed.intOpIndex] == 2, (object)(CheckState)1, (object)(CheckState)0));
								_txtKnowns_4.Text = ChemStrX.ShowZeroAsNull(Globals_Renamed.arOpParms[99, Globals_Renamed.intOpIndex]);
								_chkKnowns1_2.CheckState = (CheckState)Conversions.ToInteger(Interaction.IIf(Globals_Renamed.arOpParmsType[103, Globals_Renamed.intOpIndex] == 2, (object)(CheckState)1, (object)(CheckState)0));
								_txtKnowns_2.Text = ChemStrX.ShowZeroAsNull(Globals_Renamed.arOpParms[103, Globals_Renamed.intOpIndex]);
								if (Globals_Renamed.arOpParms[11, Globals_Renamed.intOpIndex] == 0f)
								{
									_txtOther_0.Text = ChemStrX.ShowZeroAsNull(Globals_Renamed.arOpParms[104, Globals_Renamed.intOpIndex]);
									_txtOther_1.Text = ChemStrX.ShowZeroAsNull(Globals_Renamed.arOpParms[10, Globals_Renamed.intOpIndex]);
									_txtOther_2.Text = ChemStrX.ShowZeroAsNull(Globals_Renamed.arOpParms[32, Globals_Renamed.intOpIndex]);
								}
								else
								{
									_txtOther_0.Text = Conversions.ToString(Globals_Renamed.arOpParms[104, Globals_Renamed.intOpIndex]);
									_txtOther_1.Text = Conversions.ToString(Globals_Renamed.arOpParms[10, Globals_Renamed.intOpIndex]);
									_txtOther_2.Text = Conversions.ToString(Globals_Renamed.arOpParms[32, Globals_Renamed.intOpIndex]);
								}
								_chkOther_0.CheckState = (CheckState)Conversions.ToInteger(Interaction.IIf(Globals_Renamed.arOpParmsType[104, Globals_Renamed.intOpIndex] == 2, (object)(CheckState)1, (object)(CheckState)0));
								_chkOther_1.CheckState = (CheckState)Conversions.ToInteger(Interaction.IIf(Globals_Renamed.arOpParmsType[10, Globals_Renamed.intOpIndex] == 2, (object)(CheckState)1, (object)(CheckState)0));
								_chkOther_2.CheckState = (CheckState)Conversions.ToInteger(Interaction.IIf(Globals_Renamed.arOpParmsType[32, Globals_Renamed.intOpIndex] == 2, (object)(CheckState)1, (object)(CheckState)0));
							}
							else
							{
								_chkKnowns1_3.CheckState = (CheckState)Conversions.ToInteger(Interaction.IIf(Globals_Renamed.arOpParmsType[10, Globals_Renamed.intOpIndex] == 2, (object)(CheckState)1, (object)(CheckState)0));
								_txtKnowns_3.Text = ChemStrX.ShowZeroAsNull(Globals_Renamed.arOpParms[10, Globals_Renamed.intOpIndex]);
								_chkKnowns1_4.CheckState = (CheckState)Conversions.ToInteger(Interaction.IIf(Globals_Renamed.arOpParmsType[32, Globals_Renamed.intOpIndex] == 2, (object)(CheckState)1, (object)(CheckState)0));
								_txtKnowns_4.Text = ChemStrX.ShowZeroAsNull(Globals_Renamed.arOpParms[32, Globals_Renamed.intOpIndex]);
								_chkKnowns1_2.CheckState = (CheckState)Conversions.ToInteger(Interaction.IIf(Globals_Renamed.arOpParmsType[104, Globals_Renamed.intOpIndex] == 2, (object)(CheckState)1, (object)(CheckState)0));
								_txtKnowns_2.Text = ChemStrX.ShowZeroAsNull(Globals_Renamed.arOpParms[104, Globals_Renamed.intOpIndex]);
								if (Globals_Renamed.arOpParms[10, Globals_Renamed.intOpIndex] == 0f)
								{
									_txtOther_0.Text = ChemStrX.ShowZeroAsNull(Globals_Renamed.arOpParms[103, Globals_Renamed.intOpIndex]);
									_txtOther_1.Text = ChemStrX.ShowZeroAsNull(Globals_Renamed.arOpParms[11, Globals_Renamed.intOpIndex]);
									_txtOther_2.Text = ChemStrX.ShowZeroAsNull(Globals_Renamed.arOpParms[99, Globals_Renamed.intOpIndex]);
								}
								else
								{
									_txtOther_0.Text = Conversions.ToString(Globals_Renamed.arOpParms[103, Globals_Renamed.intOpIndex]);
									_txtOther_1.Text = Conversions.ToString(Globals_Renamed.arOpParms[11, Globals_Renamed.intOpIndex]);
									_txtOther_2.Text = Conversions.ToString(Globals_Renamed.arOpParms[99, Globals_Renamed.intOpIndex]);
								}
								_chkOther_0.CheckState = (CheckState)Conversions.ToInteger(Interaction.IIf(Globals_Renamed.arOpParmsType[103, Globals_Renamed.intOpIndex] == 2, (object)(CheckState)1, (object)(CheckState)0));
								_chkOther_1.CheckState = (CheckState)Conversions.ToInteger(Interaction.IIf(Globals_Renamed.arOpParmsType[11, Globals_Renamed.intOpIndex] == 2, (object)(CheckState)1, (object)(CheckState)0));
								_chkOther_2.CheckState = (CheckState)Conversions.ToInteger(Interaction.IIf(Globals_Renamed.arOpParmsType[99, Globals_Renamed.intOpIndex] == 2, (object)(CheckState)1, (object)(CheckState)0));
							}
						}
						switch (Globals_Renamed.arOpType[Support.GetItemData((Control)(object)frmMain.DefInstance._lstSelOps_1, frmMain.DefInstance._lstSelOps_1.SelectedIndex)])
						{
						case 1:
							((Control)(RadioButton)((Control)_Frame1_1).Controls["_optInfOrEff_" + Conversions.ToString(0)]).Enabled = false;
							((Control)(RadioButton)((Control)_Frame1_1).Controls["_optInfOrEff_" + Conversions.ToString(1)]).Enabled = true;
							break;
						case 3:
							((Control)(RadioButton)((Control)_Frame1_1).Controls["_optInfOrEff_" + Conversions.ToString(0)]).Enabled = true;
							((Control)(RadioButton)((Control)_Frame1_1).Controls["_optInfOrEff_" + Conversions.ToString(1)]).Enabled = false;
							break;
						default:
							((Control)(RadioButton)((Control)_Frame1_1).Controls["_optInfOrEff_" + Conversions.ToString(0)]).Enabled = true;
							((Control)(RadioButton)((Control)_Frame1_1).Controls["_optInfOrEff_" + Conversions.ToString(1)]).Enabled = true;
							break;
						}
						SetLblDoingWhat();
						MyPvOp = Globals_Renamed.arOpPv[Globals_Renamed.intOpIndex];
						if (MyPvOp > 0.0)
						{
							lblMyPVop.Text = "This operation has a PVop of: " + Support.Format((object)MyPvOp, "###,###,###", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + " kg/yr";
						}
						else
						{
							lblMyPVop.Text = "This operation has a PVop of: Not Specified";
						}
						GetMyPredYprod();
						DefaultY();
						num3 = 0;
						short num7;
						do
						{
							arMyMassBalDisc[num3] = Globals_Renamed.arOpMassBalDisc[num3, Globals_Renamed.intOpIndex];
							if (arMyMassBalDisc[num3] > 5)
							{
								switch (num3)
								{
								case 0:
									_lbl5PctError_0.Text = "A mass balance discrepancy of " + Conversions.ToString(arMyMassBalDisc[num3]) + " percent exists based on current parameter values and relational equations.";
									break;
								case 1:
									_lbl5PctError_1.Text = "A mass balance discrepancy of " + Conversions.ToString(arMyMassBalDisc[num3]) + " percent exists based on current parameter values and relational equations.";
									break;
								}
							}
							num3 = (short)unchecked(num3 + 1);
							num7 = num3;
							num5 = 1;
						}
						while (num7 <= num5);
						bTab2Done = false;
						num3 = 0;
						short num8;
						do
						{
							if (Versioned.IsNumeric((object)((Control)_fraTab2_1).Controls["_txtOther_" + Conversions.ToString(unchecked((int)num3))].Text))
							{
								bTab2Done = true;
							}
							num3 = (short)unchecked(num3 + 1);
							num8 = num3;
							num5 = 2;
						}
						while (num8 <= num5);
						COFarGssOptions = new short[163, Globals_Renamed.intNumOps + 1];
						Parameters = Globals_Renamed.arGssOptions;
						RecordsAffected = COFarGssOptions;
						short pDim = 162;
						ChemStrX.Clone2DArray(ref Parameters, ref RecordsAffected, ref pDim, ref Globals_Renamed.intNumOps);
						COFarGssOptions = (short[,])RecordsAffected;
						Globals_Renamed.arGssOptions = (short[,])Parameters;
						COFarGssOther = new string[163, Globals_Renamed.intNumOps + 1];
						Parameters = Globals_Renamed.arGssOther;
						RecordsAffected = COFarGssOther;
						pDim = 162;
						ChemStrX.Clone2DArray(ref Parameters, ref RecordsAffected, ref pDim, ref Globals_Renamed.intNumOps);
						COFarGssOther = (string[,])RecordsAffected;
						Globals_Renamed.arGssOther = (string[,])Parameters;
						Parameters = Globals_Renamed.arOpParms;
						RecordsAffected = COFarOpParms;
						pDim = 162;
						ChemStrX.Clone2DArray(ref Parameters, ref RecordsAffected, ref pDim, ref Globals_Renamed.intNumOps);
						COFarOpParms = (float[,])RecordsAffected;
						Globals_Renamed.arOpParms = (float[,])Parameters;
						switch (Globals_Renamed.arOpType[Support.GetItemData((Control)(object)frmMain.DefInstance._lstSelOps_1, frmMain.DefInstance._lstSelOps_1.SelectedIndex)])
						{
						case 100:
						{
							sVcar = Globals_Renamed.arOpParms[21, Globals_Renamed.intOpIndex];
							sNcar = Globals_Renamed.arOpParms[25, Globals_Renamed.intOpIndex];
							sVpaint = Globals_Renamed.arOpParms[27, Globals_Renamed.intOpIndex];
							sDprod = Globals_Renamed.arOpParms[30, Globals_Renamed.intOpIndex];
							short num9 = 0;
							num3 = 0;
							short num13;
							do
							{
								if (unchecked((int)((CheckBox)((Control)_fraTab2_0).Controls["_chkKnowns1_" + Conversions.ToString((int)num3)]).CheckState) == 1)
								{
									num9++;
								}
								num3 = (short)unchecked(num3 + 1);
								num13 = num3;
								num5 = 4;
							}
							while (num13 <= num5);
							if (num9 == 0)
							{
								DoDefaultsGss100();
							}
							break;
						}
						case 101:
						{
							sDVIppaint = Globals_Renamed.arOpParms[116, Globals_Renamed.intOpIndex];
							sDrm = Globals_Renamed.arOpParms[29, Globals_Renamed.intOpIndex];
							short num9 = 0;
							num3 = 0;
							short num12;
							do
							{
								if (unchecked((int)((CheckBox)((Control)_fraTab2_0).Controls["_chkKnowns1_" + Conversions.ToString((int)num3)]).CheckState) == 1)
								{
									num9++;
								}
								num3 = (short)unchecked(num3 + 1);
								num12 = num3;
								num5 = 4;
							}
							while (num12 <= num5);
							if (num9 == 0)
							{
								float[,] cOFarOpParms = COFarOpParms;
								short intOpIndex = Globals_Renamed.intOpIndex;
								pDim = 101;
								short pParmID = 116;
								cOFarOpParms[116, intOpIndex] = ChemStrX.SetGSSParmDefault(ref pDim, ref pParmID);
								COFarOpParms[14, Globals_Renamed.intOpIndex] = COFarOpParms[116, Globals_Renamed.intOpIndex] * COFarOpParms[29, Globals_Renamed.intOpIndex];
								_txtKnowns_4.Text = Conversions.ToString(COFarOpParms[14, Globals_Renamed.intOpIndex]);
								DoDefaultsGss101();
								_chkKnowns1_4.CheckState = (CheckState)1;
							}
							break;
						}
						case 102:
						{
							short num9 = 0;
							short num14 = (short)(((BaseControlArray)chkKnowns1).Count() - 1);
							num3 = 0;
							while (true)
							{
								short num15 = num3;
								num5 = num14;
								if (num15 > num5)
								{
									break;
								}
								if (unchecked((int)((CheckBox)((Control)_fraTab2_0).Controls["_chkKnowns1_" + Conversions.ToString((int)num3)]).CheckState) == 1)
								{
									num9++;
								}
								num3 = (short)unchecked(num3 + 1);
							}
							if (num9 == 0)
							{
								DoDefaultsGss102();
							}
							sVbatch = Globals_Renamed.arOpParms[115, Globals_Renamed.intOpIndex];
							break;
						}
						case 103:
						{
							((ButtonBase)_optInfOrEff_1).Text = "Cooling Tower Additive Usage";
							((Control)_optContOrBatch_1).Enabled = false;
							((Control)_optInfOrEff_0).Enabled = false;
							short num9 = 0;
							num3 = 0;
							short num11;
							do
							{
								if (unchecked((int)((CheckBox)((Control)_fraTab2_0).Controls["_chkKnowns1_" + Conversions.ToString((int)num3)]).CheckState) == 1)
								{
									num9++;
								}
								num3 = (short)unchecked(num3 + 1);
								num11 = num3;
								num5 = 4;
							}
							while (num11 <= num5);
							if (num9 == 0)
							{
								DoDefaultsGss103();
							}
							sRRctw = Globals_Renamed.arOpParms[126, Globals_Renamed.intOpIndex];
							sYctw = Globals_Renamed.arOpParms[124, Globals_Renamed.intOpIndex];
							sHD = Globals_Renamed.arOpParms[35, Globals_Renamed.intOpIndex];
							sDctw = Globals_Renamed.arOpParms[125, Globals_Renamed.intOpIndex];
							sLFb = Globals_Renamed.arOpParms[127, Globals_Renamed.intOpIndex];
							sLFw = Globals_Renamed.arOpParms[128, Globals_Renamed.intOpIndex];
							sLFe = Globals_Renamed.arOpParms[129, Globals_Renamed.intOpIndex];
							if (Globals_Renamed.arOpParms[130, Globals_Renamed.intOpIndex] == 0f)
							{
								sDRRchem = sRRctw * sYctw * sHD * sDctw * 60f;
							}
							else
							{
								sDRRchem = Globals_Renamed.arOpParms[130, Globals_Renamed.intOpIndex];
							}
							break;
						}
						case 104:
						{
							((ButtonBase)_optInfOrEff_1).Text = "Electroplating Bath Additive Usage";
							((ButtonBase)cmdCalcOthers).Text = "&Calculate remaining parameters";
							_lblInstructions_1.Text = "Please specify at least one (maximum three) of the first five parameters.  ChemSTEER will calculate the remaining parameters for you.";
							short num9 = 0;
							num3 = 0;
							short num10;
							do
							{
								if (unchecked((int)((CheckBox)((Control)_fraTab2_0).Controls["_chkKnowns1_" + Conversions.ToString((int)num3)]).CheckState) == 1)
								{
									num9++;
								}
								num3 = (short)unchecked(num3 + 1);
								num10 = num3;
								num5 = 4;
							}
							while (num10 <= num5);
							if (num9 == 0)
							{
								DoDefaultsGss104();
								break;
							}
							sVbath = COFarOpParms[135, Globals_Renamed.intOpIndex];
							sNbath = COFarOpParms[136, Globals_Renamed.intOpIndex];
							sFreqbath = COFarOpParms[137, Globals_Renamed.intOpIndex];
							sDbath = COFarOpParms[133, Globals_Renamed.intOpIndex];
							sYbath = COFarOpParms[131, Globals_Renamed.intOpIndex];
							sDVrinse = COFarOpParms[138, Globals_Renamed.intOpIndex];
							sDrinse = COFarOpParms[134, Globals_Renamed.intOpIndex];
							sYrinse = COFarOpParms[132, Globals_Renamed.intOpIndex];
							sRinseE = COFarOpParms[139, Globals_Renamed.intOpIndex];
							sVbath = COFarOpParms[135, Globals_Renamed.intOpIndex];
							sDVrinse = COFarOpParms[138, Globals_Renamed.intOpIndex];
							iFixVbath = COFarGssOptions[135, Globals_Renamed.intOpIndex];
							iFixDVRinse = COFarGssOptions[138, Globals_Renamed.intOpIndex];
							iFixYrinse = COFarGssOptions[132, Globals_Renamed.intOpIndex];
							break;
						}
						}
						recordset = null;
						command = null;
						bSettingGroup4Defaults = false;
						flag = true;
						goto end_IL_0001;
					}
					case 7504:
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
				try0001_dispatch = 7504;
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

	private void chkKnowns1_CheckStateChanged(object eventSender, EventArgs eventArgs)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Invalid comparison between Unknown and I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Invalid comparison between Unknown and I4
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Unknown result type (might be due to invalid IL or missing references)
		short index = chkKnowns1.GetIndex((CheckBox)eventSender);
		if (0 == 0 || _0024STATIC_0024chkKnowns1_CheckStateChanged_002420211C1271_0024PreventRecursion)
		{
			return;
		}
		short num = 0;
		short num2;
		checked
		{
			short num3;
			short num4;
			do
			{
				if (unchecked((int)((CheckBox)((Control)_fraTab2_0).Controls["_chkKnowns1_" + Conversions.ToString((int)num)]).CheckState) == 1)
				{
					num2++;
				}
				num = (short)unchecked(num + 1);
				num3 = num;
				num4 = 4;
			}
			while (num3 <= num4);
			if (num2 > 3)
			{
				Interaction.Beep();
				Interaction.MsgBox((object)("It is invalid to select more than three of the parameters in the " + _fraTab2_0.Text + " group for user input. You may only select three of the parameters in this group for user input."), (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
				_0024STATIC_0024chkKnowns1_CheckStateChanged_002420211C1271_0024PreventRecursion = true;
				_0024STATIC_0024chkKnowns1_CheckStateChanged_002420211C1271_0024PreventRecursion = false;
			}
		}
		if (((num2 == 3) & (Globals_Renamed.arOpType[Globals_Renamed.intOpIndex] != 104)) && Operators.ConditionalCompareObjectEqual(ValidateChkKnowns(), (object)false, false))
		{
			_0024STATIC_0024chkKnowns1_CheckStateChanged_002420211C1271_0024PreventRecursion = true;
			((CheckBox)((Control)_fraTab2_0).Controls["_chkKnowns1_" + Conversions.ToString((int)num)]).CheckState = (CheckState)0;
			_0024STATIC_0024chkKnowns1_CheckStateChanged_002420211C1271_0024PreventRecursion = false;
		}
		if ((int)((CheckBox)((Control)_fraTab2_0).Controls["_chkKnowns1_" + Conversions.ToString((int)num)]).CheckState == 1)
		{
			((TextBoxBase)(TextBox)((Control)_fraTab2_0).Controls["_txtKnowns_" + Conversions.ToString((int)index)]).ReadOnly = false;
			((Control)_fraTab2_0).Controls["_txtKnowns_" + Conversions.ToString((int)index)].BackColor = Color.White;
			switch (Globals_Renamed.arOpType[Support.GetItemData((Control)(object)frmMain.DefInstance._lstSelOps_1, frmMain.DefInstance._lstSelOps_1.SelectedIndex)])
			{
			case 100:
				switch (index)
				{
				case 2:
					((Control)cmdCalcDMxChem).Enabled = optContOrBatch[(short)0].Checked;
					break;
				case 4:
					((Control)cmdCalcXmoProd).Enabled = bEnableCmdCalcXmoProd & optInfOrEff[(short)1].Checked & optContOrBatch[(short)0].Checked;
					break;
				case 3:
					break;
				}
				break;
			case 101:
			{
				short num6 = index;
				if (num6 == 4)
				{
					((Control)cmdCalcXmoProd).Enabled = bEnableCmdCalcXmoProd & optInfOrEff[(short)0].Checked & optContOrBatch[(short)0].Checked;
				}
				break;
			}
			case 102:
				switch (index)
				{
				case 0:
					((Control)cmdCalcNS).Enabled = bEnableCmdCalcNS & optInfOrEff[(short)1].Checked & optContOrBatch[(short)1].Checked;
					break;
				case 2:
					((Control)cmdCalcDMxChem).Enabled = optContOrBatch[(short)0].Checked;
					break;
				case 3:
					((Control)cmdCalcYprod).Enabled = bEnableCmdCalcYprod & optInfOrEff[(short)1].Checked & optContOrBatch[(short)1].Checked;
					break;
				case 4:
					((Control)cmdCalcXmoProd).Enabled = bEnableCmdCalcXmoProd & optInfOrEff[(short)1].Checked & optContOrBatch[(short)1].Checked;
					break;
				case 1:
					break;
				}
				break;
			case 103:
			{
				short num7 = index;
				if (num7 == 2)
				{
					((Control)cmdCalcDMxChem).Enabled = true;
					((TextBoxBase)(TextBox)((Control)_fraTab2_0).Controls["_txtKnowns_" + Conversions.ToString((int)index)]).ReadOnly = true;
					((Control)_fraTab2_0).Controls["_txtKnowns_" + Conversions.ToString((int)index)].BackColor = ((Form)this).BackColor;
				}
				break;
			}
			case 104:
			{
				short num5 = index;
				if (num5 == 2)
				{
					((Control)cmdCalcDMxChem).Enabled = true;
					((TextBoxBase)(TextBox)((Control)_fraTab2_0).Controls["_txtKnowns_" + Conversions.ToString((int)index)]).ReadOnly = true;
					((Control)_fraTab2_0).Controls["_txtKnowns_" + Conversions.ToString((int)index)].BackColor = ((Form)this).BackColor;
				}
				break;
			}
			default:
				if (index == 2)
				{
					((Control)cmdCalcDMxChem).Enabled = optContOrBatch[(short)0].Checked;
				}
				break;
			}
		}
		else
		{
			((TextBoxBase)(TextBox)((Control)_fraTab2_0).Controls["_txtKnowns_" + Conversions.ToString((int)index)]).ReadOnly = true;
			((Control)_fraTab2_0).Controls["_txtKnowns_" + Conversions.ToString((int)index)].BackColor = ((Form)this).BackColor;
			switch (index)
			{
			case 0:
				((Control)cmdCalcNS).Enabled = false;
				break;
			case 2:
				((Control)cmdCalcDMxChem).Enabled = false;
				break;
			case 3:
				((Control)cmdCalcYprod).Enabled = false;
				break;
			case 4:
				((Control)cmdCalcXmoProd).Enabled = false;
				break;
			case 1:
				break;
			}
		}
	}

	private void chkOBatch2_CheckStateChanged(object eventSender, EventArgs eventArgs)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Invalid comparison between Unknown and I4
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Invalid comparison between Unknown and I4
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		short index = chkOBatch2.GetIndex((CheckBox)eventSender);
		if (0 == 0 || _0024STATIC_0024chkOBatch2_CheckStateChanged_002420211C1271_0024PreventRecursion)
		{
			return;
		}
		short num5;
		checked
		{
			short num = (short)(((BaseControlArray)chkOBatch2).Count() - 1);
			short num2 = 0;
			while (true)
			{
				short num3 = num2;
				short num4 = num;
				if (num3 > num4)
				{
					break;
				}
				if (unchecked((int)chkOBatch2[num2].CheckState) == 1)
				{
					num5++;
				}
				num2 = (short)unchecked(num2 + 1);
			}
		}
		if (num5 == 3)
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"You can only update (check) two parameters in the second group. Please see the help system for more information.", (MsgBoxStyle)64, (object)"Invalid Operation");
			_0024STATIC_0024chkOBatch2_CheckStateChanged_002420211C1271_0024PreventRecursion = true;
			chkOBatch2[index].CheckState = (CheckState)0;
			_0024STATIC_0024chkOBatch2_CheckStateChanged_002420211C1271_0024PreventRecursion = false;
		}
		else if ((int)chkOBatch2[index].CheckState == 1)
		{
			((TextBoxBase)txtOBatch2[index]).ReadOnly = false;
			((TextBoxBase)txtOBatch2[index]).BackColor = Color.White;
			((Control)cmdBatchRecalc[index]).Enabled = false;
		}
		else
		{
			((TextBoxBase)txtOBatch2[index]).ReadOnly = true;
			((TextBoxBase)txtOBatch2[index]).BackColor = ((Form)this).BackColor;
			((Control)cmdBatchRecalc[index]).Enabled = true;
		}
	}

	private void chkOther_CheckStateChanged(object eventSender, EventArgs eventArgs)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Invalid comparison between Unknown and I4
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Invalid comparison between Unknown and I4
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		short index = chkOther.GetIndex((CheckBox)eventSender);
		if (0 == 0 || _0024STATIC_0024chkOther_CheckStateChanged_002420211C1271_0024PreventRecursion)
		{
			return;
		}
		short num5;
		checked
		{
			short num = (short)(((BaseControlArray)chkOther).Count() - 1);
			short num2 = 0;
			while (true)
			{
				short num3 = num2;
				short num4 = num;
				if (num3 > num4)
				{
					break;
				}
				if (unchecked((int)chkOther[num2].CheckState) == 1)
				{
					num5++;
				}
				num2 = (short)unchecked(num2 + 1);
			}
		}
		if (num5 == 3)
		{
			Interaction.Beep();
			Interaction.MsgBox((object)("You can only update (check) two parameters in the " + fraTab2[(short)1].Text + " group. Please see the help system for more information."), (MsgBoxStyle)64, (object)"Invalid Operation");
			_0024STATIC_0024chkOther_CheckStateChanged_002420211C1271_0024PreventRecursion = true;
			chkOther[index].CheckState = (CheckState)0;
			_0024STATIC_0024chkOther_CheckStateChanged_002420211C1271_0024PreventRecursion = false;
		}
		else if ((int)chkOther[index].CheckState == 1)
		{
			((TextBoxBase)txtOther[index]).ReadOnly = false;
			((TextBoxBase)txtOther[index]).BackColor = Color.White;
			((Control)cmdRecalc[index]).Enabled = false;
		}
		else
		{
			((TextBoxBase)txtOther[index]).ReadOnly = true;
			((TextBoxBase)txtOther[index]).BackColor = ((Form)this).BackColor;
			((Control)cmdRecalc[index]).Enabled = true;
		}
	}

	private void cmdBasis_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		frmGenericTextBox defInstance = frmGenericTextBox.DefInstance;
		string op = "";
		string[] arBasis = Globals_Renamed.arBasis;
		int intOpIndex = Globals_Renamed.intOpIndex;
		object value = arBasis[intOpIndex];
		bool num = defInstance.SetUp(ref op, ref value);
		arBasis[intOpIndex] = Conversions.ToString(value);
		if (num)
		{
			((Form)frmGenericTextBox.DefInstance).Text = "Basis";
			((Form)frmGenericTextBox.DefInstance).ShowDialog();
			if (Operators.ConditionalCompareObjectEqual(((Control)frmGenericTextBox.DefInstance).Tag, (object)"", false))
			{
				Globals_Renamed.arBasis[Globals_Renamed.intOpIndex] = frmGenericTextBox.DefInstance.txtStuff.Text;
			}
		}
		((Form)frmGenericTextBox.DefInstance).Close();
	}

	private void cmdBatchRecalc_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		short index = cmdBatchRecalc.GetIndex((Button)eventSender);
		if (0 == 0)
		{
			return;
		}
		short num = 0;
		short num2;
		short num3;
		do
		{
			((Control)_fraTab3_1).Controls["_chkOBatch2_" + Conversions.ToString((int)num)].Tag = "";
			checked
			{
				num = (short)unchecked(num + 1);
				num2 = num;
				num3 = 2;
			}
		}
		while (num2 <= num3);
		((Control)chkOBatch2[index]).Tag = "clicked";
		if (Versioned.IsNumeric((object)txtOBatch2[(short)0].Text) & Versioned.IsNumeric((object)txtOBatch2[(short)1].Text) & Versioned.IsNumeric((object)txtOBatch2[(short)2].Text))
		{
			switch (index)
			{
			case 0:
				txtOBatch2[(short)0].Text = ChemStrX.ShowInSciNot(Conversions.ToDouble(txtOBatch1[(short)2].Text) / Conversions.ToDouble(txtOBatch2[(short)2].Text) / Conversions.ToDouble(txtOBatch2[(short)1].Text));
				break;
			case 1:
			{
				TextBox obj2 = txtOBatch2[(short)1];
				double pValue = Conversions.ToDouble(txtOBatch1[(short)2].Text) / Conversions.ToDouble(txtOBatch2[(short)2].Text) / Conversions.ToDouble(txtOBatch2[(short)0].Text);
				string sAbbr = "Ls";
				short Index = 1;
				obj2.Text = Conversions.ToString(MyRoundIt(ref pValue, ref sAbbr, ref Index));
				break;
			}
			case 2:
			{
				TextBox obj = txtOBatch2[(short)2];
				double pValue = Conversions.ToDouble(txtOBatch1[(short)2].Text) / Conversions.ToDouble(txtOBatch2[(short)0].Text) / Conversions.ToDouble(txtOBatch2[(short)1].Text);
				string sAbbr = "OD";
				short Index = 1;
				obj.Text = Conversions.ToString(MyRoundIt(ref pValue, ref sAbbr, ref Index));
				ValODAndODMax();
				break;
			}
			}
			if (Conversions.ToDouble(txtOBatch2[(short)0].Text) > 24.0 / Conversions.ToDouble(txtOBatch1[(short)0].Text))
			{
				Interaction.Beep();
				Interaction.MsgBox((object)("Nbld must be less than or equal to 24 / HB, (" + ChemStrX.ShowInSciNot(24.0 / Conversions.ToDouble(txtOBatch1[(short)0].Text)) + ").  Please correct your parameters."), (MsgBoxStyle)64, (object)"Invalid Parameters");
			}
			else
			{
				ValODAndODMax();
			}
		}
	}

	private void cmdCalcBatchParms_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		bDontDisable = true;
		checked
		{
			if (Versioned.IsNumeric((object)_txtOBatch1_0.Text) & Versioned.IsNumeric((object)_txtOBatch1_1.Text) & Versioned.IsNumeric((object)_txtOBatch1_2.Text))
			{
				if ((Conversions.ToDouble(_txtOBatch1_0.Text) <= 24.0) & (Conversions.ToDouble(_txtOBatch1_2.Text) <= Conversions.ToDouble(_txtOBatch1_1.Text)))
				{
					_txtOBatch2_0.Text = "1";
					_txtOBatch2_1.Text = "1";
					TextBox txtOBatch2_ = _txtOBatch2_2;
					double pValue = Conversions.ToDouble(_txtKnowns_1.Text);
					string sAbbr = "OD";
					short Index = 1;
					txtOBatch2_.Text = Conversions.ToString(MyRoundIt(ref pValue, ref sAbbr, ref Index));
				}
				else if (Conversions.ToDouble(_txtOBatch1_0.Text) * Conversions.ToDouble(_txtOBatch1_2.Text) / 24.0 <= Conversions.ToDouble(_txtOBatch1_1.Text))
				{
					_txtOBatch2_1.Text = "1";
					TextBox txtOBatch2_2 = _txtOBatch2_2;
					double pValue = Conversions.ToDouble(_txtOBatch1_0.Text) * Conversions.ToDouble(_txtOBatch1_2.Text) / 24.0;
					string sAbbr = "OD";
					short Index = 1;
					txtOBatch2_2.Text = Conversions.ToString(MyRoundIt(ref pValue, ref sAbbr, ref Index));
					_txtOBatch2_0.Text = ChemStrX.ShowInSciNot(Conversions.ToDouble(_txtKnowns_1.Text) / Conversions.ToDouble(_txtOBatch2_2.Text));
				}
				else
				{
					object obj = Conversions.ToDouble(_txtOBatch1_0.Text) * Conversions.ToDouble(_txtOBatch1_2.Text) / 24.0;
					_txtOBatch2_1.Text = "1";
					Cursor.Current = Cursors.WaitCursor;
					while (!Operators.ConditionalCompareObjectLessEqual(Operators.DivideObject(obj, (object)Conversions.ToDouble(_txtOBatch2_1.Text)), (object)Conversions.ToDouble(_txtOBatch1_1.Text), false))
					{
						_txtOBatch2_1.Text = Conversions.ToString(Conversions.ToDouble(_txtOBatch2_1.Text) + 1.0);
					}
					Cursor.Current = Cursors.Default;
					TextBox txtOBatch2_3 = _txtOBatch2_2;
					double pValue = Conversions.ToDouble(_txtOBatch1_0.Text) * Conversions.ToDouble(_txtOBatch1_2.Text) / 24.0 / Conversions.ToDouble(_txtOBatch2_1.Text);
					string sAbbr = "OD";
					short Index = 1;
					txtOBatch2_3.Text = Conversions.ToString(MyRoundIt(ref pValue, ref sAbbr, ref Index));
					_txtOBatch2_0.Text = ChemStrX.ShowInSciNot(Conversions.ToDouble(_txtKnowns_1.Text) / Conversions.ToDouble(_txtOBatch2_2.Text) / Conversions.ToDouble(_txtOBatch2_1.Text));
				}
				short num = (short)(((BaseControlArray)chkOBatch2).Count() - 1);
				short num2 = 0;
				while (true)
				{
					short num3 = num2;
					short num4 = num;
					if (num3 > num4)
					{
						break;
					}
					((CheckBox)((Control)_fraTab3_1).Controls["_chkOBatch2_" + Conversions.ToString(unchecked((int)num2))]).CheckState = (CheckState)0;
					num2 = (short)unchecked(num2 + 1);
				}
			}
			bDontDisable = false;
		}
	}

	private void cmdCalcDefaults_Click(object eventSender, EventArgs eventArgs)
	{
		SetGroup4Default();
	}

	private void cmdCalcDMxChem_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		if (Globals_Renamed.arOpType[Globals_Renamed.intOpIndex] == 103)
		{
			pOption = COFarGssOptions[15, Globals_Renamed.intOpIndex];
			((Form)frmMDCalcXmoProd.DefInstance).ShowDialog();
			if (Operators.ConditionalCompareObjectEqual(((Control)frmMDCalcXmoProd.DefInstance).Tag, (object)"", false))
			{
				COFarGssOptions[15, Globals_Renamed.intOpIndex] = frmMDCalcXmoProd.DefInstance.iSelected;
				COFarGssOptions[124, Globals_Renamed.intOpIndex] = sYctwOption;
				COFarGssOptions[126, Globals_Renamed.intOpIndex] = sRRctwOption;
				if (sYctwOption == 3)
				{
					COFarGssOther[124, Globals_Renamed.intOpIndex] = sYctwOther;
				}
			}
			frmMDCalcXmoProd.DefInstance.iReCalcNS = 0;
			((Form)frmMDCalcXmoProd.DefInstance).Close();
		}
		else if (Globals_Renamed.arOpType[Globals_Renamed.intOpIndex] == 104)
		{
			pOption = COFarGssOptions[15, Globals_Renamed.intOpIndex];
			((Form)frmMDCalcXmoProd.DefInstance).ShowDialog();
			if (Operators.ConditionalCompareObjectEqual(((Control)frmMDCalcXmoProd.DefInstance).Tag, (object)"", false))
			{
				COFarGssOptions[135, Globals_Renamed.intOpIndex] = iFixVbath;
				COFarGssOptions[138, Globals_Renamed.intOpIndex] = iFixDVRinse;
				COFarGssOptions[132, Globals_Renamed.intOpIndex] = iFixYrinse;
			}
			else
			{
				short num = 0;
				short num2;
				short num3;
				do
				{
					((Control)_fraTab2_0).Controls["_txtKnowns_" + Conversions.ToString((int)num)].Text = Conversions.ToString(((Control)_fraTab2_0).Controls["_txtKnowns_" + Conversions.ToString((int)num)].Tag);
					checked
					{
						num = (short)unchecked(num + 1);
						num2 = num;
						num3 = 4;
					}
				}
				while (num2 <= num3);
				num = 0;
				short num4;
				do
				{
					((Control)_fraTab2_1).Controls["_txtOther_" + Conversions.ToString((int)num)].Text = Conversions.ToString(((Control)_fraTab2_1).Controls["_txtOther_" + Conversions.ToString((int)num)].Tag);
					checked
					{
						num = (short)unchecked(num + 1);
						num4 = num;
						num3 = 2;
					}
				}
				while (num4 <= num3);
				sVbath = Conversions.ToSingle(((Control)frmMDCalcXmoProd.DefInstance._txt104_0).Tag);
				sNbath = Conversions.ToSingle(((Control)frmMDCalcXmoProd.DefInstance._txt104_1).Tag);
				sFreqbath = Conversions.ToSingle(((Control)frmMDCalcXmoProd.DefInstance._txt104_2).Tag);
				sDbath = Conversions.ToSingle(((Control)frmMDCalcXmoProd.DefInstance._txt104_3).Tag);
				sYbath = Conversions.ToSingle(((Control)frmMDCalcXmoProd.DefInstance._txt104_4).Tag);
				txtKnowns[(short)1].Text = Conversions.ToString(((Control)frmMDCalcXmoProd.DefInstance._txt104_5).Tag);
				sDVrinse = Conversions.ToSingle(((Control)frmMDCalcXmoProd.DefInstance._txt104_6).Tag);
				sDrinse = Conversions.ToSingle(((Control)frmMDCalcXmoProd.DefInstance._txt104_7).Tag);
				sYrinse = Conversions.ToSingle(((Control)frmMDCalcXmoProd.DefInstance._txt104_8).Tag);
				sRinseE = Conversions.ToSingle(((Control)frmMDCalcXmoProd.DefInstance._txt104_9).Tag);
				txtKnowns[(short)2].Text = Conversions.ToString(((Control)frmMDCalcXmoProd.DefInstance._txt104_10).Tag);
				txtKnowns[(short)0].Text = Conversions.ToString(frmMDCalcXmoProd.DefInstance.sSaveNS);
				iFixVbath = Conversions.ToShort(((Control)frmMDCalcXmoProd.DefInstance._chkFix_0).Tag);
				iFixDVRinse = Conversions.ToShort(((Control)frmMDCalcXmoProd.DefInstance._chkFix_6).Tag);
				iFixYrinse = Conversions.ToShort(((Control)frmMDCalcXmoProd.DefInstance._chkFix_8).Tag);
				cmdCalcOthers_Click(cmdCalcOthers, new EventArgs());
			}
			((Form)frmMDCalcXmoProd.DefInstance).Close();
		}
		else
		{
			pHMxChem = COFarOpParms[34, Globals_Renamed.intOpIndex];
			pHD = COFarOpParms[35, Globals_Renamed.intOpIndex];
			((Form)frmMDCalcDMxChem.DefInstance).ShowDialog();
			if (Operators.ConditionalCompareObjectEqual(((Control)frmMDCalcDMxChem.DefInstance).Tag, (object)"", false))
			{
				_txtKnowns_2.Text = frmMDCalcDMxChem.DefInstance.lblDMxChem.Text;
				COFarOpParms[34, Globals_Renamed.intOpIndex] = Conversions.ToSingle(Common.MyNullCheck0(frmMDCalcDMxChem.DefInstance.txtHMxChem));
				COFarOpParms[35, Globals_Renamed.intOpIndex] = Conversions.ToSingle(Common.MyNullCheck0(frmMDCalcDMxChem.DefInstance.txtHD));
			}
			((Form)frmMDCalcDMxChem.DefInstance).Close();
		}
	}

	private void cmdCalcNS_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		if (frmMDCalcNS.DefInstance.SetUp(ref COFarGssOptions[1, Globals_Renamed.intOpIndex], ref COFarOpParms[114, Globals_Renamed.intOpIndex]))
		{
			((Form)frmMDCalcNS.DefInstance).ShowDialog();
			if (Operators.ConditionalCompareObjectEqual(((Control)frmMDCalcNS.DefInstance).Tag, (object)"", false))
			{
				COFarGssOptions[1, Globals_Renamed.intOpIndex] = frmMDCalcNS.DefInstance.iOptSelected;
				COFarOpParms[114, Globals_Renamed.intOpIndex] = Conversions.ToSingle(frmMDCalcNS.DefInstance.txtAMOprod.Text);
			}
		}
		((Form)frmMDCalcNS.DefInstance).Close();
	}

	public void cmdCalcOthers_Click(object eventSender, EventArgs eventArgs)
	{
		if (ValidateOthers())
		{
			bTab2Done = true;
			if (Globals_Renamed.arOpType[Globals_Renamed.intOpIndex] == 104)
			{
				CalcRest_GSS104();
			}
			else
			{
				CalcRest();
			}
		}
	}

	private void cmdCalcXmoProd_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		((Form)frmMDCalcXmoProd.DefInstance).ShowDialog();
		if (Operators.ConditionalCompareObjectEqual(((Control)frmMDCalcXmoProd.DefInstance).Tag, (object)"", false))
		{
			COFarGssOptions[14, Globals_Renamed.intOpIndex] = frmMDCalcXmoProd.DefInstance.iSelected;
		}
		((Form)frmMDCalcXmoProd.DefInstance).Close();
		((Component)(object)frmMDCalcXmoProd.DefInstance).Dispose();
	}

	private void cmdCalcYprod_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if (frmMDCalcYprod.DefInstance.SetUp(ref COFarGssOptions[10, Globals_Renamed.intOpIndex]))
		{
			((Form)frmMDCalcYprod.DefInstance).ShowDialog();
			if (Operators.ConditionalCompareObjectEqual(((Control)frmMDCalcYprod.DefInstance).Tag, (object)"", false))
			{
				COFarGssOptions[10, Globals_Renamed.intOpIndex] = frmMDCalcYprod.DefInstance.iOptSelected;
			}
		}
		((Form)frmMDCalcYprod.DefInstance).Close();
	}

	private void cmdCancel_Click(object eventSender, EventArgs eventArgs)
	{
		((Form)this).Close();
		((Component)(object)this).Dispose();
	}

	private void cmdFinish_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Invalid comparison between Unknown and I4
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		bODMsgDisplayed = false;
		short num = 0;
		short num2 = default(short);
		checked
		{
			short num3;
			short num4;
			do
			{
				if (unchecked((int)((CheckBox)((Control)_fraTab2_0).Controls["_chkKnowns1_" + Conversions.ToString((int)num)]).CheckState) == 1)
				{
					num2++;
				}
				num = (short)unchecked(num + 1);
				num3 = num;
				num4 = 4;
			}
			while (num3 <= num4);
			if (num2 == 3 && !ValidateOthers())
			{
				return;
			}
			num = 0;
			short num5;
			do
			{
				unchecked
				{
					if (!Versioned.IsNumeric((object)((Control)_fraTab2_0).Controls["_txtKnowns_" + Conversions.ToString((int)num)].Text))
					{
						((Control)_fraTab2_0).Controls["_txtKnowns_" + Conversions.ToString((int)num)].Text = "0";
					}
				}
				num = (short)unchecked(num + 1);
				num5 = num;
				num4 = 4;
			}
			while (num5 <= num4);
			if ((Conversions.ToDouble(_txtKnowns_3.Text) < 0.0) | (Conversions.ToDouble(_txtKnowns_3.Text) > 1.0))
			{
				Interaction.Beep();
				Interaction.MsgBox((object)("An invalid amount was calculated for " + ((ButtonBase)_chkKnowns1_3).Text + ". This value must be greater than zero and less than or equal to one. You will not be able to save your Mass Balance Input parameters until this is fixed."), (MsgBoxStyle)64, (object)"Invalid Amount");
				return;
			}
			if (((Strings.Len(_txtOther_1.Text) > 0) & (Strings.Len(_txtOther_1.Text) > 0)) && ((Conversions.ToDouble(_txtOther_1.Text) < 0.0) | (Conversions.ToDouble(_txtOther_1.Text) > 1.0)))
			{
				Interaction.Beep();
				Interaction.MsgBox((object)("An invalid amount was calculated for " + ((ButtonBase)_chkOther_1).Text + ". This value must be greater than or equal to zero and less than or equal to one. You will not be able to save your Mass Balance Input parameters until this is fixed."), (MsgBoxStyle)64, (object)"Invalid Amount");
				return;
			}
			bFinishing = true;
		}
		if (Globals_Renamed.arOpType[Globals_Renamed.intOpIndex] == 104 && (num2 > 0 || num2 < 4))
		{
			CalcRest_GSS104();
			if (bElecError)
			{
				return;
			}
		}
		else if (num2 == 3)
		{
			CalcRest();
			if (optContOrBatch[(short)1].Checked && !ValidateBatchParms())
			{
				return;
			}
		}
		if (Operators.CompareString(_txtKnowns_1.Text, "", false) != 0 && Conversions.ToBoolean(UpdateFrmMain()))
		{
			object pCopyArray = COFarGssOptions;
			object pToArray = Globals_Renamed.arGssOptions;
			short pDim = 162;
			ChemStrX.Clone2DArray(ref pCopyArray, ref pToArray, ref pDim, ref Globals_Renamed.intNumOps);
			Globals_Renamed.arGssOptions = (short[,])pToArray;
			COFarGssOptions = (short[,])pCopyArray;
			pToArray = COFarGssOther;
			pCopyArray = Globals_Renamed.arGssOther;
			pDim = 162;
			ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim, ref Globals_Renamed.intNumOps);
			Globals_Renamed.arGssOther = (string[,])pCopyArray;
			COFarGssOther = (string[,])pToArray;
			((Form)this).Close();
			((Component)(object)this).Dispose();
			Globals_Renamed.gblIWasChanged = true;
		}
		Globals_Renamed.arOpNeedsMassBalance[Globals_Renamed.intOpIndex] = 0;
	}

	private void cmdRecalc_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		switch (cmdRecalc.GetIndex((Button)eventSender))
		{
		case 0:
			if (Versioned.IsNumeric((object)_txtOther_1.Text) & Versioned.IsNumeric((object)_txtOther_2.Text))
			{
				_txtOther_0.Text = Conversions.ToString(Conversions.ToDouble(_txtOther_1.Text) * Conversions.ToDouble(_txtOther_2.Text));
			}
			else
			{
				_txtOther_0.Text = "0";
			}
			break;
		case 1:
			if (!(Versioned.IsNumeric((object)_txtOther_0.Text) & Versioned.IsNumeric((object)_txtOther_2.Text)))
			{
				break;
			}
			if (Conversions.ToDouble(_txtOther_2.Text) == 0.0)
			{
				_txtOther_1.Text = "0";
				break;
			}
			_txtOther_1.Text = ChemStrX.ShowInSciNot(Conversions.ToDouble(_txtOther_0.Text) / Conversions.ToDouble(_txtOther_2.Text));
			if (!((Conversions.ToDouble(_txtOther_1.Text) <= 0.0) | (Conversions.ToDouble(_txtOther_1.Text) > 1.0)))
			{
				break;
			}
			Interaction.Beep();
			Interaction.MsgBox((object)("An invalid amount was calculated for " + ((ButtonBase)_chkOther_1).Text + ". This value must be greater than zero and less than or equal to one. You will not be able to save your Mass Balance Input parameters until this is fixed."), (MsgBoxStyle)64, (object)"Invalid Amount");
			return;
		case 2:
			if (Versioned.IsNumeric((object)_txtOther_0.Text) & Versioned.IsNumeric((object)_txtOther_1.Text))
			{
				if (Conversions.ToDouble(_txtOther_1.Text) == 0.0)
				{
					_txtOther_2.Text = "0";
				}
				else
				{
					_txtOther_2.Text = ChemStrX.ShowInSciNot(Conversions.ToDouble(_txtOther_0.Text) / Conversions.ToDouble(_txtOther_1.Text));
				}
			}
			break;
		}
		if (Globals_Renamed.arOpType[Globals_Renamed.intOpIndex] == 2)
		{
			string text = "\r\n\r\n";
			if (Conversions.ToDouble(Common.MyNullCheck0(_txtOther_0.Text)) != Conversions.ToDouble(Common.MyNullCheck0(_txtKnowns_2.Text)))
			{
				Interaction.Beep();
				Interaction.MsgBox((object)("A discrepancy now exists between " + text + ((ButtonBase)_chkKnowns1_2).Text + text + " and " + text + ((ButtonBase)_chkOther_0).Text + "."), (MsgBoxStyle)64, (object)"Discrepancy Warning");
			}
		}
		((Control)cmdCalcOthers).Enabled = true;
	}

	private void cmdRestoreDefaults_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			short num = (short)(((BaseControlArray)chkKnowns1).Count() - 1);
			short num2 = 0;
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
					((CheckBox)((Control)_fraTab2_0).Controls["_chkKnowns1_" + Conversions.ToString((int)num2)]).CheckState = (CheckState)0;
					((Control)_fraTab2_0).Controls["_txtKnowns_" + Conversions.ToString((int)num2)].Text = "";
				}
				num2 = (short)unchecked(num2 + 1);
			}
			short num5 = (short)(((BaseControlArray)chkOther).Count() - 1);
			num2 = 0;
			while (true)
			{
				short num6 = num2;
				short num4 = num5;
				if (num6 > num4)
				{
					break;
				}
				unchecked
				{
					((CheckBox)((Control)_fraTab2_1).Controls["_chkOther_" + Conversions.ToString((int)num2)]).CheckState = (CheckState)0;
					((Control)_fraTab2_1).Controls["_txtOther_" + Conversions.ToString((int)num2)].Text = "";
				}
				num2 = (short)unchecked(num2 + 1);
			}
			DefaultY();
			switch (Globals_Renamed.arOpType[Globals_Renamed.intOpIndex])
			{
			case 100:
				if (optInfOrEff[(short)1].Checked & optContOrBatch[(short)0].Checked)
				{
					float[,] cOFarOpParms7 = this.COFarOpParms;
					short intOpIndex7 = Globals_Renamed.intOpIndex;
					short pParmID = 100;
					short pGSSID = 21;
					cOFarOpParms7[21, intOpIndex7] = ChemStrX.SetGSSParmDefault(ref pParmID, ref pGSSID);
					float[,] cOFarOpParms8 = this.COFarOpParms;
					short intOpIndex8 = Globals_Renamed.intOpIndex;
					pGSSID = 100;
					pParmID = 25;
					cOFarOpParms8[25, intOpIndex8] = ChemStrX.SetGSSParmDefault(ref pGSSID, ref pParmID);
					if (Strings.Len(frmMain.DefInstance.lblDchem.Text) > 0)
					{
						this.COFarOpParms[29, Globals_Renamed.intOpIndex] = Conversions.ToSingle(frmMain.DefInstance.lblDchem.Text);
						this.COFarOpParms[30, Globals_Renamed.intOpIndex] = Conversions.ToSingle(frmMain.DefInstance.lblDchem.Text);
					}
					else
					{
						this.COFarOpParms[29, Globals_Renamed.intOpIndex] = 0f;
						this.COFarOpParms[30, Globals_Renamed.intOpIndex] = 0f;
					}
					this.COFarOpParms[12, Globals_Renamed.intOpIndex] = this.COFarOpParms[21, Globals_Renamed.intOpIndex] * this.COFarOpParms[25, Globals_Renamed.intOpIndex] * this.COFarOpParms[30, Globals_Renamed.intOpIndex];
					_txtKnowns_4.Text = Conversions.ToString(this.COFarOpParms[12, Globals_Renamed.intOpIndex]);
					_chkKnowns1_4.CheckState = (CheckState)1;
					this.COFarOpParms[27, Globals_Renamed.intOpIndex] = 0f;
					sVcar = this.COFarOpParms[21, Globals_Renamed.intOpIndex];
					sNcar = this.COFarOpParms[25, Globals_Renamed.intOpIndex];
					sVpaint = this.COFarOpParms[27, Globals_Renamed.intOpIndex];
					sDprod = this.COFarOpParms[30, Globals_Renamed.intOpIndex];
					DoDefaultsGss100();
				}
				break;
			case 101:
				if (optInfOrEff[(short)0].Checked & optContOrBatch[(short)0].Checked)
				{
					float[,] cOFarOpParms9 = this.COFarOpParms;
					short intOpIndex9 = Globals_Renamed.intOpIndex;
					short pGSSID = 101;
					short pParmID = 2;
					cOFarOpParms9[2, intOpIndex9] = ChemStrX.SetGSSParmDefault(ref pGSSID, ref pParmID);
					_txtKnowns_1.Text = Conversions.ToString(this.COFarOpParms[2, Globals_Renamed.intOpIndex]);
					float[,] cOFarOpParms10 = this.COFarOpParms;
					short intOpIndex10 = Globals_Renamed.intOpIndex;
					pGSSID = 101;
					pParmID = 116;
					cOFarOpParms10[116, intOpIndex10] = ChemStrX.SetGSSParmDefault(ref pGSSID, ref pParmID);
					this.COFarOpParms[14, Globals_Renamed.intOpIndex] = this.COFarOpParms[116, Globals_Renamed.intOpIndex] * this.COFarOpParms[29, Globals_Renamed.intOpIndex];
					_txtKnowns_4.Text = Conversions.ToString(this.COFarOpParms[14, Globals_Renamed.intOpIndex]);
					_chkKnowns1_4.CheckState = (CheckState)1;
					sDVIppaint = this.COFarOpParms[116, Globals_Renamed.intOpIndex];
					sDrm = this.COFarOpParms[29, Globals_Renamed.intOpIndex];
					DoDefaultsGss101();
				}
				break;
			case 102:
				if (optInfOrEff[(short)1].Checked & optContOrBatch[(short)1].Checked)
				{
					DoDefaultsGss102();
				}
				break;
			case 103:
			{
				this.COFarOpParms[2, Globals_Renamed.intOpIndex] = 360f;
				float[,] cOFarOpParms = this.COFarOpParms;
				short intOpIndex = Globals_Renamed.intOpIndex;
				short pGSSID = 103;
				short pParmID = 124;
				cOFarOpParms[124, intOpIndex] = ChemStrX.SetGSSParmDefault(ref pGSSID, ref pParmID);
				float[,] cOFarOpParms2 = this.COFarOpParms;
				short intOpIndex2 = Globals_Renamed.intOpIndex;
				pGSSID = 103;
				pParmID = 125;
				cOFarOpParms2[125, intOpIndex2] = ChemStrX.SetGSSParmDefault(ref pGSSID, ref pParmID);
				float[,] cOFarOpParms3 = this.COFarOpParms;
				short intOpIndex3 = Globals_Renamed.intOpIndex;
				pGSSID = 103;
				pParmID = 126;
				cOFarOpParms3[126, intOpIndex3] = ChemStrX.SetGSSParmDefault(ref pGSSID, ref pParmID);
				float[,] cOFarOpParms4 = this.COFarOpParms;
				short intOpIndex4 = Globals_Renamed.intOpIndex;
				pGSSID = 103;
				pParmID = 127;
				cOFarOpParms4[127, intOpIndex4] = ChemStrX.SetGSSParmDefault(ref pGSSID, ref pParmID);
				float[,] cOFarOpParms5 = this.COFarOpParms;
				short intOpIndex5 = Globals_Renamed.intOpIndex;
				pGSSID = 103;
				pParmID = 128;
				cOFarOpParms5[128, intOpIndex5] = ChemStrX.SetGSSParmDefault(ref pGSSID, ref pParmID);
				float[,] cOFarOpParms6 = this.COFarOpParms;
				short intOpIndex6 = Globals_Renamed.intOpIndex;
				pGSSID = 103;
				pParmID = 129;
				cOFarOpParms6[129, intOpIndex6] = ChemStrX.SetGSSParmDefault(ref pGSSID, ref pParmID);
				this.COFarOpParms[35, Globals_Renamed.intOpIndex] = 24f;
				this.COFarOpParms[130, Globals_Renamed.intOpIndex] = Conversions.ToSingle(ChemStrX.ShowInSciNot(this.COFarOpParms[126, Globals_Renamed.intOpIndex] * this.COFarOpParms[124, Globals_Renamed.intOpIndex] * this.COFarOpParms[35, Globals_Renamed.intOpIndex] * this.COFarOpParms[125, Globals_Renamed.intOpIndex] * 60f));
				sRRctw = this.COFarOpParms[126, Globals_Renamed.intOpIndex];
				sYctw = this.COFarOpParms[124, Globals_Renamed.intOpIndex];
				sHD = this.COFarOpParms[35, Globals_Renamed.intOpIndex];
				sDctw = this.COFarOpParms[125, Globals_Renamed.intOpIndex];
				sLFb = this.COFarOpParms[127, Globals_Renamed.intOpIndex];
				sLFw = this.COFarOpParms[128, Globals_Renamed.intOpIndex];
				sLFe = this.COFarOpParms[129, Globals_Renamed.intOpIndex];
				sRRctwOption = 0;
				sYctwOption = 0;
				sYctwOther = "";
				DoDefaultsGss103();
				break;
			}
			case 104:
			{
				object COFarOpParms = this.COFarOpParms;
				ChemStrX.Reset_GSS_ElecBath(ref COFarOpParms, ref Globals_Renamed.intOpIndex);
				this.COFarOpParms = (float[,])COFarOpParms;
				sYbath = this.COFarOpParms[131, Globals_Renamed.intOpIndex];
				sYrinse = this.COFarOpParms[132, Globals_Renamed.intOpIndex];
				sDbath = this.COFarOpParms[133, Globals_Renamed.intOpIndex];
				sDrinse = this.COFarOpParms[134, Globals_Renamed.intOpIndex];
				sVbath = this.COFarOpParms[135, Globals_Renamed.intOpIndex];
				sNbath = this.COFarOpParms[136, Globals_Renamed.intOpIndex];
				sFreqbath = this.COFarOpParms[137, Globals_Renamed.intOpIndex];
				sDVrinse = this.COFarOpParms[138, Globals_Renamed.intOpIndex];
				sRinseE = this.COFarOpParms[139, Globals_Renamed.intOpIndex];
				iFixVbath = 0;
				iFixDVRinse = 0;
				iFixYrinse = 1;
				iSequence = 1;
				DoDefaultsGss104();
				break;
			}
			}
		}
	}

	private void frmMDUpdOpIP_Load(object eventSender, EventArgs eventArgs)
	{
		step_Renamed = 0;
		bFinishing = false;
		_lbl5PctError_0.Text = "";
		_lbl5PctError_1.Text = "";
		sYprodFromPrevOp = 0f;
		SetUp();
	}

	private void optContOrBatch_CheckedChanged(object eventSender, EventArgs eventArgs)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		if (!Conversions.ToBoolean(NewLateBinding.LateGet(eventSender, (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			return;
		}
		short index = optContOrBatch.GetIndex((RadioButton)eventSender);
		((Control)optContOrBatch[(short)0]).Tag = index;
		if (optContOrBatch[(short)1].Checked)
		{
			SetUpTab3();
		}
		else if (!bSettingGroup4Defaults)
		{
			txtKnowns[(short)1].Text = txtOBatch2[(short)2].Text;
		}
		if (!(bGssDefaultsWereSet & (Globals_Renamed.arOpType[Globals_Renamed.intOpIndex] >= 100)))
		{
			return;
		}
		checked
		{
			short num = (short)(((BaseControlArray)chkKnowns1).Count() - 1);
			short num2 = 0;
			while (true)
			{
				short num3 = num2;
				short num4 = num;
				if (num3 > num4)
				{
					break;
				}
				chkKnowns1[num2].CheckState = (CheckState)0;
				txtKnowns[num2].Text = "";
				num2 = (short)unchecked(num2 + 1);
			}
			short num5 = (short)(((BaseControlArray)chkOther).Count() - 1);
			num2 = 0;
			while (true)
			{
				short num6 = num2;
				short num4 = num5;
				if (num6 <= num4)
				{
					chkOther[num2].CheckState = (CheckState)0;
					txtOther[num2].Text = "";
					num2 = (short)unchecked(num2 + 1);
					continue;
				}
				break;
			}
		}
	}

	private void optInfOrEff_CheckedChanged(object eventSender, EventArgs eventArgs)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		if (0 == 0 || !Conversions.ToBoolean(NewLateBinding.LateGet(eventSender, (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			return;
		}
		short index = optInfOrEff.GetIndex((RadioButton)eventSender);
		((Control)optInfOrEff[(short)0]).Tag = index;
		if (bGssDefaultsWereSet & (Support.GetItemData((Control)(object)frmMain.DefInstance._lstSelOps_0, (int)Globals_Renamed.intOpIndex) >= 100))
		{
			checked
			{
				short num = (short)(((BaseControlArray)chkKnowns1).Count() - 1);
				short num2 = 0;
				while (true)
				{
					short num3 = num2;
					short num4 = num;
					if (num3 > num4)
					{
						break;
					}
					chkKnowns1[num2].CheckState = (CheckState)0;
					txtKnowns[num2].Text = "";
					num2 = (short)unchecked(num2 + 1);
				}
				short num5 = (short)(((BaseControlArray)chkOther).Count() - 1);
				num2 = 0;
				while (true)
				{
					short num6 = num2;
					short num4 = num5;
					if (num6 > num4)
					{
						break;
					}
					chkOther[num2].CheckState = (CheckState)0;
					txtOther[num2].Text = "";
					num2 = (short)unchecked(num2 + 1);
				}
			}
		}
		if (Support.GetItemData((Control)(object)frmMain.DefInstance._lstSelOps_1, (int)Globals_Renamed.intOpIndex) < 100)
		{
			txtKnowns[(short)3].Text = "";
			DefaultY();
		}
	}

	private void tabs_ClickEvent(object eventSender, EventArgs eventArgs)
	{
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Invalid comparison between Unknown and I4
		((Control)this).Controls["_fraStep_" + Conversions.ToString((int)step_Renamed)].Visible = false;
		if (step_Renamed == 0)
		{
			SetLblDoingWhat();
		}
		short count = ((ITabs)tabs.Tabs).Count;
		step_Renamed = 1;
		checked
		{
			while (true)
			{
				short num = step_Renamed;
				short num2 = count;
				if (num > num2)
				{
					break;
				}
				Tabs obj = tabs.Tabs;
				object obj2 = step_Renamed;
				if (((ITab)((ITabs)obj)[ref obj2]).Selected)
				{
					break;
				}
				step_Renamed = (short)unchecked(step_Renamed + 1);
			}
			step_Renamed--;
			switch (step_Renamed)
			{
			case 0:
				((Control)cmdCalcOthers).Visible = false;
				break;
			case 1:
				((Control)cmdCalcOthers).Visible = true;
				break;
			case 2:
			{
				((Control)cmdCalcOthers).Visible = false;
				if (!((RadioButton)((Control)_Frame1_0).Controls["_optContOrBatch_" + Conversions.ToString(1)]).Checked)
				{
					step_Renamed = 3;
					((Control)_lblError_0).Visible = true;
					((Control)_lblError_1).Visible = false;
					break;
				}
				if (!bTab2Done & !Versioned.IsNumeric((object)_txtKnowns_1.Text))
				{
					step_Renamed = 3;
					((Control)_lblError_0).Visible = false;
					((Control)_lblError_1).Visible = true;
					break;
				}
				_txtOBatch1_2.Text = _txtKnowns_1.Text;
				short num3 = (short)(((BaseControlArray)chkOBatch2).Count() - 1);
				short num4 = 0;
				bool flag = default(bool);
				while (true)
				{
					short num5 = num4;
					short num2 = num3;
					if (num5 > num2)
					{
						break;
					}
					if (unchecked((int)((CheckBox)((Control)_fraTab3_1).Controls["_chkOBatch2_" + Conversions.ToString((int)num4)]).CheckState) == 1)
					{
						flag = true;
						break;
					}
					num4 = (short)unchecked(num4 + 1);
				}
				if (!flag)
				{
					cmdCalcBatchParms_Click(cmdCalcBatchParms, new EventArgs());
				}
				break;
			}
			}
		}
		((Control)this).Controls["_fraStep_" + Conversions.ToString((int)step_Renamed)].Visible = true;
	}

	private void SetLblDoingWhat()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_079c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Invalid comparison between Unknown and I4
		//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Unknown result type (might be due to invalid IL or missing references)
		//IL_053b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0541: Invalid comparison between Unknown and I4
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
					if (((RadioButton)((Control)_Frame1_0).Controls["_optContOrBatch_" + Conversions.ToString(0)]).Checked)
					{
						((Control)cmdCalcDMxChem).Enabled = true;
						((ButtonBase)_chkKnowns1_1).Text = "OD: Total operating days per year at each site";
						if (((RadioButton)((Control)_Frame1_1).Controls["_optInfOrEff_" + Conversions.ToString(0)]).Checked)
						{
							_fraTab2_0.Text = "Continuous Operation; Using " + ((Control)_Frame1_1).Controls["_optInfOrEff_" + Conversions.ToString(0)].Text;
							_fraTab2_1.Text = "Continuous " + ((Control)_Frame1_1).Controls["_optInfOrEff_" + Conversions.ToString(1)].Text + " Parameters Calculation";
							CheckBox chkKnowns1_ = _chkKnowns1_2;
							ref short pOpID = ref Globals_Renamed.arOpType[Globals_Renamed.intOpIndex];
							short pParmID = 15;
							((ButtonBase)chkKnowns1_).Text = ChemStrX.GetParmLabels(ref pOpID, ref pParmID) + " " + Globals_Renamed.arParmUnits[15];
							CheckBox chkKnowns1_2 = _chkKnowns1_3;
							ref short pOpID2 = ref Globals_Renamed.arOpType[Globals_Renamed.intOpIndex];
							pParmID = 11;
							((ButtonBase)chkKnowns1_2).Text = ChemStrX.GetParmLabels(ref pOpID2, ref pParmID) + " (unitless)";
							CheckBox chkKnowns1_3 = _chkKnowns1_4;
							ref short pOpID3 = ref Globals_Renamed.arOpType[Globals_Renamed.intOpIndex];
							pParmID = 14;
							((ButtonBase)chkKnowns1_3).Text = ChemStrX.GetParmLabels(ref pOpID3, ref pParmID) + " " + Globals_Renamed.arParmUnits[14];
							switch (Globals_Renamed.arOpType[Globals_Renamed.intOpIndex])
							{
							case 101:
								((Control)cmdCalcXmoProd).Enabled = bEnableCmdCalcXmoProd & optContOrBatch[(short)0].Checked;
								break;
							case 103:
								((Control)cmdCalcDMxChem).Enabled = false;
								break;
							default:
								((Control)cmdCalcXmoProd).Enabled = false;
								((Control)cmdCalcNS).Enabled = false;
								((Control)cmdCalcYprod).Enabled = false;
								break;
							}
							CheckBox chkOther_ = _chkOther_0;
							ref short pOpID4 = ref Globals_Renamed.arOpType[Globals_Renamed.intOpIndex];
							pParmID = 13;
							((ButtonBase)chkOther_).Text = ChemStrX.GetParmLabels(ref pOpID4, ref pParmID) + " " + Globals_Renamed.arParmUnits[13];
							CheckBox chkOther_2 = _chkOther_1;
							ref short pOpID5 = ref Globals_Renamed.arOpType[Globals_Renamed.intOpIndex];
							pParmID = 10;
							((ButtonBase)chkOther_2).Text = ChemStrX.GetParmLabels(ref pOpID5, ref pParmID) + " (unitless)";
							CheckBox chkOther_3 = _chkOther_2;
							ref short pOpID6 = ref Globals_Renamed.arOpType[Globals_Renamed.intOpIndex];
							pParmID = 12;
							((ButtonBase)chkOther_3).Text = ChemStrX.GetParmLabels(ref pOpID6, ref pParmID) + " " + Globals_Renamed.arParmUnits[12];
						}
						else
						{
							_fraTab2_0.Text = "Continuous Operation; Using " + ((Control)_Frame1_1).Controls["_optInfOrEff_" + Conversions.ToString(1)].Text;
							_fraTab2_1.Text = "Continuous " + ((Control)_Frame1_1).Controls["_optInfOrEff_" + Conversions.ToString(0)].Text + " Parameters Calculation";
							CheckBox chkKnowns1_4 = _chkKnowns1_2;
							ref short pOpID7 = ref Globals_Renamed.arOpType[Globals_Renamed.intOpIndex];
							short pParmID = 13;
							((ButtonBase)chkKnowns1_4).Text = ChemStrX.GetParmLabels(ref pOpID7, ref pParmID) + " " + Globals_Renamed.arParmUnits[13];
							CheckBox chkKnowns1_5 = _chkKnowns1_3;
							ref short pOpID8 = ref Globals_Renamed.arOpType[Globals_Renamed.intOpIndex];
							pParmID = 10;
							((ButtonBase)chkKnowns1_5).Text = ChemStrX.GetParmLabels(ref pOpID8, ref pParmID) + " (unitless)";
							CheckBox chkKnowns1_6 = _chkKnowns1_4;
							ref short pOpID9 = ref Globals_Renamed.arOpType[Globals_Renamed.intOpIndex];
							pParmID = 12;
							((ButtonBase)chkKnowns1_6).Text = ChemStrX.GetParmLabels(ref pOpID9, ref pParmID) + " " + Globals_Renamed.arParmUnits[12];
							switch (Globals_Renamed.arOpType[Globals_Renamed.intOpIndex])
							{
							case 100:
								((Control)cmdCalcXmoProd).Enabled = bEnableCmdCalcXmoProd & ((RadioButton)((Control)_Frame1_0).Controls["_optContOrBatch_" + Conversions.ToString(0)]).Checked;
								((Control)cmdCalcDMxChem).Enabled = (int)_chkKnowns1_2.CheckState == 1;
								break;
							case 102:
								((Control)cmdCalcXmoProd).Enabled = bEnableCmdCalcXmoProd & ((RadioButton)((Control)_Frame1_0).Controls["_optContOrBatch_" + Conversions.ToString(1)]).Checked;
								((Control)cmdCalcNS).Enabled = bEnableCmdCalcNS & ((RadioButton)((Control)_Frame1_0).Controls["_optContOrBatch_" + Conversions.ToString(1)]).Checked;
								((Control)cmdCalcYprod).Enabled = bEnableCmdCalcYprod & ((RadioButton)((Control)_Frame1_0).Controls["_optContOrBatch_" + Conversions.ToString(1)]).Checked;
								break;
							case 103:
							case 104:
								((Control)cmdCalcDMxChem).Enabled = (int)_chkKnowns1_2.CheckState == 1;
								break;
							default:
								((Control)cmdCalcXmoProd).Enabled = false;
								((Control)cmdCalcNS).Enabled = false;
								((Control)cmdCalcYprod).Enabled = false;
								break;
							}
							CheckBox chkOther_4 = _chkOther_0;
							ref short pOpID10 = ref Globals_Renamed.arOpType[Globals_Renamed.intOpIndex];
							pParmID = 15;
							((ButtonBase)chkOther_4).Text = ChemStrX.GetParmLabels(ref pOpID10, ref pParmID) + " " + Globals_Renamed.arParmUnits[15];
							CheckBox chkOther_5 = _chkOther_1;
							ref short pOpID11 = ref Globals_Renamed.arOpType[Globals_Renamed.intOpIndex];
							pParmID = 11;
							((ButtonBase)chkOther_5).Text = ChemStrX.GetParmLabels(ref pOpID11, ref pParmID) + " (unitless)";
							CheckBox chkOther_6 = _chkOther_2;
							ref short pOpID12 = ref Globals_Renamed.arOpType[Globals_Renamed.intOpIndex];
							pParmID = 14;
							((ButtonBase)chkOther_6).Text = ChemStrX.GetParmLabels(ref pOpID12, ref pParmID) + " " + Globals_Renamed.arParmUnits[14];
						}
					}
					else
					{
						((Control)cmdCalcDMxChem).Enabled = false;
						((ButtonBase)_chkKnowns1_1).Text = Globals_Renamed.arParmNames[16];
						if (optInfOrEff[(short)0].Checked)
						{
							_fraTab2_0.Text = "Batch Operation; Using " + ((ButtonBase)optInfOrEff[(short)0]).Text;
							_fraTab2_1.Text = "Batch " + ((ButtonBase)optInfOrEff[(short)1]).Text + " Parameters Calculation";
							CheckBox obj = chkKnowns1[(short)2];
							ref short pOpID13 = ref Globals_Renamed.arOpType[Globals_Renamed.intOpIndex];
							short pParmID = 103;
							((ButtonBase)obj).Text = ChemStrX.GetParmLabels(ref pOpID13, ref pParmID) + " " + Globals_Renamed.arParmUnits[103];
							CheckBox obj2 = chkKnowns1[(short)3];
							ref short pOpID14 = ref Globals_Renamed.arOpType[Globals_Renamed.intOpIndex];
							pParmID = 11;
							((ButtonBase)obj2).Text = ChemStrX.GetParmLabels(ref pOpID14, ref pParmID) + " (unitless)";
							CheckBox obj3 = chkKnowns1[(short)4];
							ref short pOpID15 = ref Globals_Renamed.arOpType[Globals_Renamed.intOpIndex];
							pParmID = 99;
							((ButtonBase)obj3).Text = ChemStrX.GetParmLabels(ref pOpID15, ref pParmID) + " " + Globals_Renamed.arParmUnits[99];
							short num3 = Globals_Renamed.arOpType[Globals_Renamed.intOpIndex];
							if (num3 == 101)
							{
								((Control)cmdCalcXmoProd).Enabled = bEnableCmdCalcXmoProd & ((RadioButton)((Control)_Frame1_0).Controls["_optContOrBatch_" + Conversions.ToString(0)]).Checked;
							}
							else
							{
								((Control)cmdCalcXmoProd).Enabled = false;
								((Control)cmdCalcNS).Enabled = false;
								((Control)cmdCalcYprod).Enabled = false;
							}
							CheckBox chkOther_7 = _chkOther_0;
							ref short pOpID16 = ref Globals_Renamed.arOpType[Globals_Renamed.intOpIndex];
							pParmID = 104;
							((ButtonBase)chkOther_7).Text = ChemStrX.GetParmLabels(ref pOpID16, ref pParmID) + " " + Globals_Renamed.arParmUnits[104];
							CheckBox chkOther_8 = _chkOther_1;
							ref short pOpID17 = ref Globals_Renamed.arOpType[Globals_Renamed.intOpIndex];
							pParmID = 10;
							((ButtonBase)chkOther_8).Text = ChemStrX.GetParmLabels(ref pOpID17, ref pParmID) + " (unitless)";
							CheckBox chkOther_9 = _chkOther_2;
							ref short pOpID18 = ref Globals_Renamed.arOpType[Globals_Renamed.intOpIndex];
							pParmID = 32;
							((ButtonBase)chkOther_9).Text = ChemStrX.GetParmLabels(ref pOpID18, ref pParmID) + " " + Globals_Renamed.arParmUnits[32];
						}
						else
						{
							_fraTab2_0.Text = "Batch Operation; Using " + ((Control)_Frame1_1).Controls["_optInfOrEff_" + Conversions.ToString(1)].Text;
							_fraTab2_1.Text = "Batch " + ((Control)_Frame1_1).Controls["_optInfOrEff_" + Conversions.ToString(0)].Text + " Parameters Calculation";
							CheckBox chkKnowns1_7 = _chkKnowns1_2;
							ref short pOpID19 = ref Globals_Renamed.arOpType[Globals_Renamed.intOpIndex];
							short pParmID = 104;
							((ButtonBase)chkKnowns1_7).Text = ChemStrX.GetParmLabels(ref pOpID19, ref pParmID) + " " + Globals_Renamed.arParmUnits[104];
							CheckBox chkKnowns1_8 = _chkKnowns1_3;
							ref short pOpID20 = ref Globals_Renamed.arOpType[Globals_Renamed.intOpIndex];
							pParmID = 10;
							((ButtonBase)chkKnowns1_8).Text = ChemStrX.GetParmLabels(ref pOpID20, ref pParmID) + " (unitless)";
							CheckBox chkKnowns1_9 = _chkKnowns1_4;
							ref short pOpID21 = ref Globals_Renamed.arOpType[Globals_Renamed.intOpIndex];
							pParmID = 32;
							((ButtonBase)chkKnowns1_9).Text = ChemStrX.GetParmLabels(ref pOpID21, ref pParmID) + " " + Globals_Renamed.arParmUnits[32];
							switch (Globals_Renamed.arOpType[Globals_Renamed.intOpIndex])
							{
							case 100:
								((Control)cmdCalcXmoProd).Enabled = bEnableCmdCalcXmoProd & optContOrBatch[(short)0].Checked;
								break;
							case 102:
								((Control)cmdCalcXmoProd).Enabled = bEnableCmdCalcXmoProd & optContOrBatch[(short)1].Checked;
								((Control)cmdCalcNS).Enabled = bEnableCmdCalcNS & optContOrBatch[(short)1].Checked;
								((Control)cmdCalcYprod).Enabled = bEnableCmdCalcYprod & optContOrBatch[(short)1].Checked;
								break;
							default:
								((Control)cmdCalcXmoProd).Enabled = false;
								((Control)cmdCalcNS).Enabled = false;
								((Control)cmdCalcYprod).Enabled = false;
								break;
							}
							CheckBox chkOther_10 = _chkOther_0;
							ref short pOpID22 = ref Globals_Renamed.arOpType[Globals_Renamed.intOpIndex];
							pParmID = 103;
							((ButtonBase)chkOther_10).Text = ChemStrX.GetParmLabels(ref pOpID22, ref pParmID) + " " + Globals_Renamed.arParmUnits[103];
							CheckBox chkOther_11 = _chkOther_1;
							ref short pOpID23 = ref Globals_Renamed.arOpType[Globals_Renamed.intOpIndex];
							pParmID = 11;
							((ButtonBase)chkOther_11).Text = ChemStrX.GetParmLabels(ref pOpID23, ref pParmID) + " (unitless)";
							CheckBox chkOther_12 = _chkOther_2;
							ref short pOpID24 = ref Globals_Renamed.arOpType[Globals_Renamed.intOpIndex];
							pParmID = 99;
							((ButtonBase)chkOther_12).Text = ChemStrX.GetParmLabels(ref pOpID24, ref pParmID) + " " + Globals_Renamed.arParmUnits[99];
						}
					}
					_fraStep_2.Text = _fraStep_1.Text;
					_fraStep_3.Text = _fraStep_1.Text;
					goto end_IL_0001;
				case 2996:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						string Eobject = ((Control)this).Name;
						string Efunction = "SetLblDoingWhat";
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
				try0001_dispatch = 2996;
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

	public void CalcRest()
	{
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Invalid comparison between Unknown and I4
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Invalid comparison between Unknown and I4
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Invalid comparison between Unknown and I4
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Invalid comparison between Unknown and I4
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Invalid comparison between Unknown and I4
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Invalid comparison between Unknown and I4
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Invalid comparison between Unknown and I4
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0546: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Invalid comparison between Unknown and I4
		//IL_062d: Unknown result type (might be due to invalid IL or missing references)
		short num = 0;
		short num2;
		short num3;
		do
		{
			((Control)_fraTab2_0).Controls["_txtKnowns_" + Conversions.ToString((int)num)].Tag = ((Control)_fraTab2_0).Controls["_txtKnowns_" + Conversions.ToString((int)num)].Text;
			checked
			{
				num = (short)unchecked(num + 1);
				num2 = num;
				num3 = 4;
			}
		}
		while (num2 <= num3);
		_lbl5PctError_0.Text = "No mass balance discrepancy exists";
		if (((int)_chkKnowns1_0.CheckState == 1) & ((int)_chkKnowns1_1.CheckState == 1))
		{
			_txtKnowns_2.Text = ChemStrX.ShowInSciNot(MyPvOp / Conversions.ToDouble(_txtKnowns_0.Text) / Conversions.ToDouble(_txtKnowns_1.Text));
			if ((int)_chkKnowns1_3.CheckState == 1)
			{
				_txtKnowns_4.Text = ChemStrX.ShowInSciNot(Conversions.ToDouble(_txtKnowns_2.Text) / Conversions.ToDouble(_txtKnowns_3.Text));
			}
			else
			{
				_txtKnowns_3.Text = ChemStrX.ShowInSciNot(Conversions.ToDouble(_txtKnowns_2.Text) / Conversions.ToDouble(_txtKnowns_4.Text));
			}
		}
		else if (((int)_chkKnowns1_3.CheckState == 1) & ((int)_chkKnowns1_4.CheckState == 1))
		{
			_txtKnowns_2.Text = ChemStrX.ShowInSciNot(Conversions.ToDouble(_txtKnowns_3.Text) * Conversions.ToDouble(_txtKnowns_4.Text));
			if ((int)_chkKnowns1_0.CheckState == 1)
			{
				if (((RadioButton)((Control)_Frame1_0).Controls["_optContOrBatch_" + Conversions.ToString(0)]).Checked)
				{
					double pValue = MyPvOp / Conversions.ToDouble(_txtKnowns_0.Text) / Conversions.ToDouble(_txtKnowns_2.Text);
					TextBox txtKnowns_ = _txtKnowns_1;
					string sAbbr = "OD";
					short Index = 0;
					txtKnowns_.Text = Conversions.ToString(MyRoundIt(ref pValue, ref sAbbr, ref Index));
					if (Conversions.ToDouble(_txtKnowns_1.Text) > 365.0)
					{
						Interaction.MsgBox((object)"Using these parameters causes a derived Operation Days (OD) greater than 365 days, which is invalid. Please change your parameters and try again.", (MsgBoxStyle)64, (object)null);
						_txtKnowns_1.Text = "";
						return;
					}
				}
				else
				{
					TextBox txtKnowns_2 = _txtKnowns_1;
					double pValue2 = MyPvOp / Conversions.ToDouble(_txtKnowns_0.Text) / Conversions.ToDouble(_txtKnowns_2.Text);
					string sAbbr = "Nby";
					short Index = 0;
					txtKnowns_2.Text = Conversions.ToString(MyRoundIt(ref pValue2, ref sAbbr, ref Index));
				}
			}
			else
			{
				double pValue = MyPvOp / Conversions.ToDouble(_txtKnowns_1.Text) / Conversions.ToDouble(_txtKnowns_2.Text);
				if (frmMDCalcXmoProd.DefInstance.iReCalcNS == 1)
				{
					_txtKnowns_0.Text = Conversions.ToString(MassBalanceRoundUp(ref pValue));
				}
				else
				{
					TextBox txtKnowns_3 = _txtKnowns_0;
					string sAbbr = "NS";
					short Index = 0;
					txtKnowns_3.Text = Conversions.ToString(MyRoundIt(ref pValue, ref sAbbr, ref Index));
				}
			}
		}
		else
		{
			if ((int)_chkKnowns1_0.CheckState == 1)
			{
				if (((RadioButton)((Control)_Frame1_0).Controls["_optContOrBatch_" + Conversions.ToString(0)]).Checked)
				{
					double pValue = MyPvOp / Conversions.ToDouble(_txtKnowns_0.Text) / Conversions.ToDouble(_txtKnowns_2.Text);
					TextBox txtKnowns_4 = _txtKnowns_1;
					string sAbbr = "OD";
					short Index = 0;
					txtKnowns_4.Text = Conversions.ToString(MyRoundIt(ref pValue, ref sAbbr, ref Index));
					if (Conversions.ToDouble(_txtKnowns_1.Text) > 365.0)
					{
						Interaction.MsgBox((object)("An invalid OD has been calculated, (" + _txtKnowns_1.Text + "). Please fix the error before continuing."), (MsgBoxStyle)64, (object)"Invalid OD");
						_txtKnowns_1.Text = "";
						return;
					}
				}
				else
				{
					TextBox txtKnowns_5 = _txtKnowns_1;
					double pValue2 = MyPvOp / Conversions.ToDouble(_txtKnowns_0.Text) / Conversions.ToDouble(_txtKnowns_2.Text);
					string sAbbr = "Nby";
					short Index = 0;
					txtKnowns_5.Text = Conversions.ToString(MyRoundIt(ref pValue2, ref sAbbr, ref Index));
				}
			}
			else
			{
				double pValue = MyPvOp / Conversions.ToDouble(_txtKnowns_1.Text) / Conversions.ToDouble(_txtKnowns_2.Text);
				if (frmMDCalcXmoProd.DefInstance.iReCalcNS == 1)
				{
					_txtKnowns_0.Text = Conversions.ToString(MassBalanceRoundUp(ref pValue));
				}
				else
				{
					TextBox txtKnowns_6 = _txtKnowns_0;
					string sAbbr = "NS";
					short Index = 0;
					txtKnowns_6.Text = Conversions.ToString(MyRoundIt(ref pValue, ref sAbbr, ref Index));
				}
			}
			if ((int)_chkKnowns1_3.CheckState == 1)
			{
				_txtKnowns_4.Text = ChemStrX.ShowInSciNot(Conversions.ToDouble(_txtKnowns_2.Text) / Conversions.ToDouble(_txtKnowns_3.Text));
			}
			else
			{
				_txtKnowns_3.Text = ChemStrX.ShowInSciNot(Conversions.ToDouble(_txtKnowns_2.Text) / Conversions.ToDouble(_txtKnowns_4.Text));
			}
			if ((Conversions.ToDouble(_txtKnowns_3.Text) <= 0.0) | (Conversions.ToDouble(_txtKnowns_3.Text) > 1.0))
			{
				Interaction.Beep();
				Interaction.MsgBox((object)("An invalid amount was calculated for " + ((ButtonBase)_chkKnowns1_3).Text + ". This value must be greater than zero and less than or equal to one. You will not be able to save your Mass Balance Input parameters until this is fixed."), (MsgBoxStyle)64, (object)"Invalid Amount");
				return;
			}
		}
		_txtOBatch1_2.Text = _txtKnowns_1.Text;
		CalcRest2();
	}

	public void CalcRest_GSS104()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Invalid comparison between Unknown and I4
		//IL_0c18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1e: Invalid comparison between Unknown and I4
		//IL_0654: Unknown result type (might be due to invalid IL or missing references)
		//IL_065a: Invalid comparison between Unknown and I4
		//IL_0662: Unknown result type (might be due to invalid IL or missing references)
		//IL_0668: Invalid comparison between Unknown and I4
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Invalid comparison between Unknown and I4
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Invalid comparison between Unknown and I4
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Invalid comparison between Unknown and I4
		//IL_0c7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c84: Invalid comparison between Unknown and I4
		//IL_0714: Unknown result type (might be due to invalid IL or missing references)
		//IL_071a: Invalid comparison between Unknown and I4
		//IL_0722: Unknown result type (might be due to invalid IL or missing references)
		//IL_0728: Invalid comparison between Unknown and I4
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Invalid comparison between Unknown and I4
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Invalid comparison between Unknown and I4
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Invalid comparison between Unknown and I4
		//IL_0ce4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cea: Invalid comparison between Unknown and I4
		//IL_07cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d2: Invalid comparison between Unknown and I4
		//IL_07da: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e0: Invalid comparison between Unknown and I4
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Invalid comparison between Unknown and I4
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Invalid comparison between Unknown and I4
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Invalid comparison between Unknown and I4
		//IL_0d52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d58: Invalid comparison between Unknown and I4
		//IL_0885: Unknown result type (might be due to invalid IL or missing references)
		//IL_088b: Invalid comparison between Unknown and I4
		//IL_0893: Unknown result type (might be due to invalid IL or missing references)
		//IL_0899: Invalid comparison between Unknown and I4
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Invalid comparison between Unknown and I4
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Invalid comparison between Unknown and I4
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Invalid comparison between Unknown and I4
		//IL_0dc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dce: Invalid comparison between Unknown and I4
		//IL_0910: Unknown result type (might be due to invalid IL or missing references)
		//IL_0916: Invalid comparison between Unknown and I4
		//IL_091e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0924: Invalid comparison between Unknown and I4
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Invalid comparison between Unknown and I4
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e2: Invalid comparison between Unknown and I4
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Invalid comparison between Unknown and I4
		//IL_0995: Unknown result type (might be due to invalid IL or missing references)
		//IL_099b: Invalid comparison between Unknown and I4
		//IL_09a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a9: Invalid comparison between Unknown and I4
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Invalid comparison between Unknown and I4
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Invalid comparison between Unknown and I4
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_048f: Invalid comparison between Unknown and I4
		//IL_0a12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a18: Invalid comparison between Unknown and I4
		//IL_0a20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a26: Invalid comparison between Unknown and I4
		//IL_050c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0512: Invalid comparison between Unknown and I4
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0520: Invalid comparison between Unknown and I4
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_052f: Invalid comparison between Unknown and I4
		//IL_0a9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa4: Invalid comparison between Unknown and I4
		//IL_0aac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab2: Invalid comparison between Unknown and I4
		//IL_05a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05aa: Invalid comparison between Unknown and I4
		//IL_05b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Invalid comparison between Unknown and I4
		//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c7: Invalid comparison between Unknown and I4
		//IL_0b23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b29: Invalid comparison between Unknown and I4
		//IL_0b31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b37: Invalid comparison between Unknown and I4
		//IL_0634: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba3: Invalid comparison between Unknown and I4
		//IL_0bab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb1: Invalid comparison between Unknown and I4
		int try0001_dispatch = -1;
		int num2 = default(int);
		short num4 = default(short);
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
					short num3 = 0;
					checked
					{
						short num5;
						short num6;
						do
						{
							if (unchecked((int)((CheckBox)((Control)_fraTab2_0).Controls["_chkKnowns1_" + Conversions.ToString((int)num3)]).CheckState) == 1)
							{
								num4++;
							}
							num3 = (short)unchecked(num3 + 1);
							num5 = num3;
							num6 = 4;
						}
						while (num5 <= num6);
						_lbl5PctError_0.Text = "No mass balance discrepancy exists";
						arMyMassBalDisc[0] = 0;
						arMyMassBalDisc[1] = 0;
						bElecError = false;
						bElecMBCheck = false;
					}
					switch (num4)
					{
					case 0:
					{
						object arrEP = new object[8] { 1, 2, 2.2, 3, 4, 5, 6, 7 };
						bool Econtact = false;
						DoEPCalcs_GSS104(ref arrEP, ref Econtact);
						break;
					}
					case 3:
						bElecMBCheck = true;
						if (((int)_chkKnowns1_2.CheckState == 1) & ((int)_chkKnowns1_1.CheckState == 1) & ((int)_chkKnowns1_4.CheckState == 1))
						{
							object arrEP = new object[7] { 1, 2, 5.2, 4.2, 2, 6, 7 };
							bool Econtact = false;
							DoEPCalcs_GSS104(ref arrEP, ref Econtact);
							break;
						}
						if (((int)_chkKnowns1_2.CheckState == 1) & ((int)_chkKnowns1_1.CheckState == 1) & ((int)_chkKnowns1_3.CheckState == 1))
						{
							object arrEP = new object[6] { 1, 2, 5, 4.2, 6, 7 };
							bool Econtact = false;
							DoEPCalcs_GSS104(ref arrEP, ref Econtact);
							break;
						}
						if (((int)_chkKnowns1_2.CheckState == 1) & ((int)_chkKnowns1_0.CheckState == 1) & ((int)_chkKnowns1_4.CheckState == 1))
						{
							object arrEP = new object[6] { 1, 2.2, 5.2, 4.2, 6, 7 };
							bool Econtact = true;
							DoEPCalcs_GSS104(ref arrEP, ref Econtact);
							break;
						}
						if (((int)_chkKnowns1_2.CheckState == 1) & ((int)_chkKnowns1_0.CheckState == 1) & ((int)_chkKnowns1_3.CheckState == 1))
						{
							object arrEP = new object[6] { 1, 2.2, 5, 4.2, 6, 7 };
							bool Econtact = true;
							DoEPCalcs_GSS104(ref arrEP, ref Econtact);
							break;
						}
						if (((int)_chkKnowns1_3.CheckState == 1) & ((int)chkKnowns1[(short)4].CheckState == 1) & ((int)chkKnowns1[(short)1].CheckState == 1))
						{
							object arrEP = new object[5] { 5.3, 2, 4.2, 6, 7 };
							bool Econtact = false;
							DoEPCalcs_GSS104(ref arrEP, ref Econtact);
							break;
						}
						if (((int)_chkKnowns1_3.CheckState == 1) & ((int)_chkKnowns1_4.CheckState == 1) & ((int)_chkKnowns1_0.CheckState == 1))
						{
							object arrEP = new object[5] { 5.3, 2.2, 4.2, 6, 7 };
							bool Econtact = false;
							DoEPCalcs_GSS104(ref arrEP, ref Econtact);
							break;
						}
						if (((int)_chkKnowns1_0.CheckState == 1) & ((int)_chkKnowns1_1.CheckState == 1) & ((int)_chkKnowns1_4.CheckState == 1))
						{
							object arrEP = new object[5] { 3, 5.2, 4.2, 6, 7 };
							bool Econtact = false;
							DoEPCalcs_GSS104(ref arrEP, ref Econtact);
							break;
						}
						if (((int)_chkKnowns1_0.CheckState == 1) & ((int)_chkKnowns1_1.CheckState == 1) & ((int)_chkKnowns1_3.CheckState == 1))
						{
							object arrEP = new object[5] { 3, 5, 4.2, 6, 7 };
							bool Econtact = false;
							DoEPCalcs_GSS104(ref arrEP, ref Econtact);
							break;
						}
						Interaction.MsgBox((object)"You must specify at least one mass balance input parameters in the second pair. Please change your parameters and try again.", (MsgBoxStyle)64, (object)null);
						bElecError = true;
						goto end_IL_0001;
					case 2:
						if (((int)_chkKnowns1_4.CheckState == 1) & ((int)_chkKnowns1_2.CheckState == 1))
						{
							_txtKnowns_1.Text = Conversions.ToString(250);
							object arrEP = new object[7] { 1, 2, 2.2, 5.2, 4.2, 6, 7 };
							bool Econtact = true;
							DoEPCalcs_GSS104(ref arrEP, ref Econtact);
						}
						else if (((int)_chkKnowns1_3.CheckState == 1) & ((int)_chkKnowns1_2.CheckState == 1))
						{
							_txtKnowns_1.Text = Conversions.ToString(250);
							object arrEP = new object[7] { 1, 2, 2.2, 5, 4.2, 6, 7 };
							bool Econtact = true;
							DoEPCalcs_GSS104(ref arrEP, ref Econtact);
						}
						else if (((int)_chkKnowns1_3.CheckState == 1) & ((int)_chkKnowns1_4.CheckState == 1))
						{
							object arrEP = new object[1] { 5.3 };
							bool Econtact = false;
							DoEPCalcs_GSS104(ref arrEP, ref Econtact);
							arrEP = new object[5] { 2, 2.2, 4.2, 6, 7 };
							Econtact = false;
							DoEPCalcs_GSS104(ref arrEP, ref Econtact);
						}
						else if (((int)_chkKnowns1_1.CheckState == 1) & ((int)_chkKnowns1_2.CheckState == 1))
						{
							bElecMBCheck = true;
							object arrEP = new object[6] { 1, 2, 4, 5, 6, 7 };
							bool Econtact = false;
							DoEPCalcs_GSS104(ref arrEP, ref Econtact);
						}
						else if (((int)_chkKnowns1_1.CheckState == 1) & ((int)_chkKnowns1_4.CheckState == 1))
						{
							Condition3();
							object arrEP = new object[4] { 5.2, 4.2, 6, 7 };
							bool Econtact = false;
							DoEPCalcs_GSS104(ref arrEP, ref Econtact);
						}
						else if (((int)_chkKnowns1_1.CheckState == 1) & ((int)_chkKnowns1_3.CheckState == 1))
						{
							Condition3();
							object arrEP = new object[4] { 5, 4.2, 6, 7 };
							bool Econtact = false;
							DoEPCalcs_GSS104(ref arrEP, ref Econtact);
						}
						else if (((int)_chkKnowns1_0.CheckState == 1) & ((int)_chkKnowns1_2.CheckState == 1))
						{
							object arrEP = new object[6] { 1, 2.2, 4, 5, 6, 7 };
							bool Econtact = true;
							DoEPCalcs_GSS104(ref arrEP, ref Econtact);
						}
						else if (((int)_chkKnowns1_0.CheckState == 1) & ((int)_chkKnowns1_4.CheckState == 1))
						{
							Condition2();
							object arrEP = new object[4] { 5.2, 4.2, 6, 7 };
							bool Econtact = false;
							DoEPCalcs_GSS104(ref arrEP, ref Econtact);
						}
						else if (((int)_chkKnowns1_0.CheckState == 1) & ((int)_chkKnowns1_3.CheckState == 1))
						{
							Condition2();
							object arrEP = new object[4] { 4.2, 5, 6, 7 };
							bool Econtact = false;
							DoEPCalcs_GSS104(ref arrEP, ref Econtact);
						}
						else if (((int)_chkKnowns1_0.CheckState == 1) & ((int)_chkKnowns1_1.CheckState == 1))
						{
							object arrEP = new object[5] { 3, 4, 5, 6, 7 };
							bool Econtact = false;
							DoEPCalcs_GSS104(ref arrEP, ref Econtact);
						}
						break;
					case 1:
						if ((int)_chkKnowns1_0.CheckState == 1)
						{
							Condition2();
							object arrEP = new object[4] { 4, 5, 6, 7 };
							bool Econtact = false;
							DoEPCalcs_GSS104(ref arrEP, ref Econtact);
						}
						else if ((int)_chkKnowns1_1.CheckState == 1)
						{
							Condition3();
							object arrEP = new object[4] { 4, 5, 6, 7 };
							bool Econtact = false;
							DoEPCalcs_GSS104(ref arrEP, ref Econtact);
						}
						else if ((int)_chkKnowns1_3.CheckState == 1)
						{
							Condition3();
							object arrEP = new object[4] { 4.2, 5, 6, 7 };
							bool Econtact = false;
							DoEPCalcs_GSS104(ref arrEP, ref Econtact);
						}
						else if ((int)_chkKnowns1_4.CheckState == 1)
						{
							Condition3();
							object arrEP = new object[4] { 5.2, 4.2, 6, 7 };
							bool Econtact = false;
							DoEPCalcs_GSS104(ref arrEP, ref Econtact);
						}
						else if ((int)_chkKnowns1_2.CheckState == 1)
						{
							_txtKnowns_1.Text = Conversions.ToString(250);
							object arrEP = new object[7] { 1, 2, 2.2, 4, 5, 6, 7 };
							bool Econtact = true;
							DoEPCalcs_GSS104(ref arrEP, ref Econtact);
						}
						break;
					}
					if (!bElecError)
					{
						DoCalc104_Seq(ref iFixVbath, ref iFixDVRinse);
					}
					goto end_IL_0001;
				}
				case 3820:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						string Eobject = ((Control)this).Name;
						string Efunction = "CalcRest_GSS104";
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
				try0001_dispatch = 3820;
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

	private void Condition2()
	{
		double num = 0.0;
		_txtKnowns_1.Text = Conversions.ToString(1);
		if (iFixVbath == 0)
		{
			sVbath = 2500f;
		}
		if (iFixDVRinse == 0)
		{
			sDVrinse = 4932f;
		}
		object arrEP;
		bool bSkipSeq;
		while (true)
		{
			arrEP = new object[1] { 1 };
			bSkipSeq = false;
			DoEPCalcs_GSS104(ref arrEP, ref bSkipSeq);
			num = Conversions.ToDouble(_txtKnowns_2.Text) * Conversions.ToDouble(_txtKnowns_0.Text) * Conversions.ToDouble(_txtKnowns_1.Text);
			if ((num < MyPvOp) & (Conversions.ToDouble(_txtKnowns_1.Text) < 365.0))
			{
				_txtKnowns_1.Text = Conversions.ToString(Conversions.ToDouble(_txtKnowns_1.Text) + 1.0);
				continue;
			}
			break;
		}
		arrEP = new object[1] { 3 };
		bSkipSeq = false;
		DoEPCalcs_GSS104(ref arrEP, ref bSkipSeq);
		DoCalc104_Seq(ref iFixVbath, ref iFixDVRinse);
	}

	private void Condition3()
	{
		object arrEP = new object[4] { 1, 2, 2.2, 3 };
		bool bSkipSeq = false;
		DoEPCalcs_GSS104(ref arrEP, ref bSkipSeq);
		DoCalc104_Seq(ref iFixVbath, ref iFixDVRinse);
	}

	public int MassBalanceRoundUp(ref double pValue)
	{
		checked
		{
			short num = (short)Math.Round(Conversion.Int(pValue));
			if ((double)num == pValue)
			{
				return num;
			}
			return num + 1;
		}
	}

	private int MassBalanceRoundNS(ref double pValue)
	{
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			int num = (int)Math.Round(Conversion.Int(pValue));
			int num2 = ((!((num != 0) & (((double)num == pValue) | (pValue - 0.0001 <= (double)num)))) ? (num + 1) : num);
			if ((bElecMBCheck | (Strings.Len(arMyMassBalDisc[0]) == 0)) && pValue > 0.0)
			{
				num = (int)Math.Round(Math.Abs(((double)num2 / pValue - 1.0) * 100.0));
				if (num >= 5)
				{
					arMyMassBalDisc[0] = num;
					_lbl5PctError_0.Text = "A mass balance discrepancy of " + Conversions.ToString(num) + " percent due to rounding of NS exists based on current parameter values and relational equations. The calculated value was " + ChemStrX.ShowInSciNot(pValue) + " and the value after rounding was " + ChemStrX.ShowInSciNot(num2) + ".";
					Interaction.Beep();
					Interaction.MsgBox((object)_lbl5PctError_0.Text, (MsgBoxStyle)64, (object)"Mass Balance Discrepancy");
				}
				else
				{
					arMyMassBalDisc[0] = 0;
					_lbl5PctError_0.Text = "No mass balance discrepancy exists";
				}
			}
			return num2;
		}
	}

	public int MyRoundIt(ref double pValue, ref string sAbbr, ref short Index)
	{
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		int num = checked((int)Math.Round(pValue + 0.1));
		if (num == 0)
		{
			num = 1;
		}
		int num2 = num;
		if ((pValue > 0.0) & (Strings.Len(sAbbr) > 0))
		{
			num = checked((int)Math.Round(Math.Abs(((double)num2 / pValue - 1.0) * 100.0)));
			if (num >= 5)
			{
				arMyMassBalDisc[Index] = num;
				if (Index == 0)
				{
					((Control)_fraStep_1).Controls["_lbl5PctError_" + Conversions.ToString((int)Index)].Text = "A mass balance discrepancy of " + Conversions.ToString(num) + " percent due to rounding of " + sAbbr + " exists based on current parameter values and relational equations. The calculated value was " + ChemStrX.ShowInSciNot(pValue) + " and the value after rounding was " + ChemStrX.ShowInSciNot(num2) + ".";
				}
				else if (Index == 1)
				{
					((Control)_fraStep_2).Controls["_lbl5PctError_" + Conversions.ToString((int)Index)].Text = "A mass balance discrepancy of " + Conversions.ToString(num) + " percent due to rounding of " + sAbbr + " exists based on current parameter values and relational equations. The calculated value was " + ChemStrX.ShowInSciNot(pValue) + " and the value after rounding was " + ChemStrX.ShowInSciNot(num2) + ".";
				}
				Interaction.Beep();
				if (Index == 0)
				{
					Interaction.MsgBox((object)((Control)_fraStep_1).Controls["_lbl5PctError_" + Conversions.ToString((int)Index)].Text, (MsgBoxStyle)64, (object)"Mass Balance Discrepancy");
				}
				else if (Index == 1)
				{
					Interaction.MsgBox((object)((Control)_fraStep_2).Controls["_lbl5PctError_" + Conversions.ToString((int)Index)].Text, (MsgBoxStyle)64, (object)"Mass Balance Discrepancy");
				}
			}
			else
			{
				arMyMassBalDisc[Index] = 0;
				if (Index == 0)
				{
					((Control)_fraStep_1).Controls["_lbl5PctError_" + Conversions.ToString((int)Index)].Text = "No mass balance discrepancy exists";
				}
				else if (Index == 1)
				{
					((Control)_fraStep_2).Controls["_lbl5PctError_" + Conversions.ToString((int)Index)].Text = "No mass balance discrepancy exists";
				}
			}
		}
		return num2;
	}

	private object UpdateFrmMain()
	{
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Invalid comparison between Unknown and I4
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8b: Invalid comparison between Unknown and I4
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Invalid comparison between Unknown and I4
		//IL_0f43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f49: Invalid comparison between Unknown and I4
		//IL_0fca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd0: Invalid comparison between Unknown and I4
		//IL_1026: Unknown result type (might be due to invalid IL or missing references)
		//IL_102c: Invalid comparison between Unknown and I4
		//IL_0b52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b58: Invalid comparison between Unknown and I4
		//IL_0bd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdf: Invalid comparison between Unknown and I4
		//IL_0c35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3b: Invalid comparison between Unknown and I4
		//IL_0676: Unknown result type (might be due to invalid IL or missing references)
		//IL_067c: Invalid comparison between Unknown and I4
		//IL_06f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fd: Invalid comparison between Unknown and I4
		//IL_0778: Unknown result type (might be due to invalid IL or missing references)
		//IL_077e: Invalid comparison between Unknown and I4
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Invalid comparison between Unknown and I4
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Invalid comparison between Unknown and I4
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Invalid comparison between Unknown and I4
		//IL_110b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1111: Invalid comparison between Unknown and I4
		//IL_10bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c3: Invalid comparison between Unknown and I4
		//IL_0d1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d20: Invalid comparison between Unknown and I4
		//IL_0ccc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd2: Invalid comparison between Unknown and I4
		//IL_0854: Unknown result type (might be due to invalid IL or missing references)
		//IL_085a: Invalid comparison between Unknown and I4
		//IL_0806: Unknown result type (might be due to invalid IL or missing references)
		//IL_080c: Invalid comparison between Unknown and I4
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Invalid comparison between Unknown and I4
		//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Invalid comparison between Unknown and I4
		//IL_11f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f7: Invalid comparison between Unknown and I4
		//IL_11a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a9: Invalid comparison between Unknown and I4
		//IL_0e00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e06: Invalid comparison between Unknown and I4
		//IL_0db2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db8: Invalid comparison between Unknown and I4
		//IL_093a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0940: Invalid comparison between Unknown and I4
		//IL_08ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f2: Invalid comparison between Unknown and I4
		//IL_0511: Unknown result type (might be due to invalid IL or missing references)
		//IL_0517: Invalid comparison between Unknown and I4
		//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c9: Invalid comparison between Unknown and I4
		//IL_12d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_12dd: Invalid comparison between Unknown and I4
		//IL_1289: Unknown result type (might be due to invalid IL or missing references)
		//IL_128f: Invalid comparison between Unknown and I4
		//IL_0ee6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eec: Invalid comparison between Unknown and I4
		//IL_0e98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e9e: Invalid comparison between Unknown and I4
		//IL_0a20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a26: Invalid comparison between Unknown and I4
		//IL_09d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d8: Invalid comparison between Unknown and I4
		//IL_05f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fd: Invalid comparison between Unknown and I4
		//IL_05a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05af: Invalid comparison between Unknown and I4
		//IL_1446: Unknown result type (might be due to invalid IL or missing references)
		//IL_144c: Invalid comparison between Unknown and I4
		int try0001_dispatch = -1;
		int num2 = default(int);
		object obj = default(object);
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
					object pCopyArray = COFarOpParms;
					object pToArray = Globals_Renamed.arOpParms;
					short pDim = 162;
					ChemStrX.Clone2DArray(ref pCopyArray, ref pToArray, ref pDim, ref Globals_Renamed.intNumOps);
					Globals_Renamed.arOpParms = (float[,])pToArray;
					COFarOpParms = (float[,])pCopyArray;
					Globals_Renamed.arOpBorC[Globals_Renamed.intOpIndex] = Conversions.ToShort(((Control)_Frame1_0).Controls["_optContOrBatch_" + Conversions.ToString(0)].Tag);
					Globals_Renamed.arOpIoE[Globals_Renamed.intOpIndex] = Conversions.ToShort(((Control)_Frame1_1).Controls["_optInfOrEff_" + Conversions.ToString(0)].Tag);
					Globals_Renamed.arOpMassBalDisc[0, Globals_Renamed.intOpIndex] = arMyMassBalDisc[0];
					Globals_Renamed.arOpMassBalDisc[1, Globals_Renamed.intOpIndex] = arMyMassBalDisc[1];
					float pValue = Conversions.ToSingle(txtKnowns[(short)0].Text);
					Globals_Renamed.arOpParmsType[1, Globals_Renamed.intOpIndex] = Conversions.ToShort(Interaction.IIf((int)_chkKnowns1_0.CheckState == 1, (object)(short)2, (object)(short)1));
					Globals_Renamed.arOpParms[1, Globals_Renamed.intOpIndex] = pValue;
					pDim = 1;
					pToArray = (short)(-1000);
					ChemStrX.RollDownhillOp(ref pDim, ref pValue, ref pToArray);
					short num4;
					if (((RadioButton)((Control)_Frame1_0).Controls["_optContOrBatch_" + Conversions.ToString(0)]).Checked)
					{
						Globals_Renamed.arOpParmsType[2, Globals_Renamed.intOpIndex] = Conversions.ToShort(Interaction.IIf((int)_chkKnowns1_1.CheckState == 1, (object)(short)2, (object)(short)1));
						pValue = Conversions.ToSingle(_txtKnowns_1.Text);
						if (Globals_Renamed.arOpParms[2, Globals_Renamed.intOpIndex] != pValue)
						{
							Globals_Renamed.arOpParms[2, Globals_Renamed.intOpIndex] = pValue;
						}
						if (optInfOrEff[(short)0].Checked)
						{
							Globals_Renamed.arOpParms[15, Globals_Renamed.intOpIndex] = Conversions.ToSingle(_txtKnowns_2.Text);
							Globals_Renamed.arOpParmsType[15, Globals_Renamed.intOpIndex] = Conversions.ToShort(Interaction.IIf((int)_chkKnowns1_2.CheckState == 1, (object)(short)2, (object)(short)1));
							pDim = 15;
							ref float pValue2 = ref Globals_Renamed.arOpParms[15, Globals_Renamed.intOpIndex];
							pToArray = (short)(-1000);
							ChemStrX.RollDownhillOp(ref pDim, ref pValue2, ref pToArray);
							Globals_Renamed.arOpParms[11, Globals_Renamed.intOpIndex] = Conversions.ToSingle(_txtKnowns_3.Text);
							Globals_Renamed.arOpParmsType[11, Globals_Renamed.intOpIndex] = Conversions.ToShort(Interaction.IIf((int)_chkKnowns1_3.CheckState == 1, (object)(short)2, (object)(short)1));
							pDim = 11;
							ref float pValue3 = ref Globals_Renamed.arOpParms[11, Globals_Renamed.intOpIndex];
							pToArray = (short)(-1000);
							ChemStrX.RollDownhillOp(ref pDim, ref pValue3, ref pToArray);
							Globals_Renamed.arOpParms[14, Globals_Renamed.intOpIndex] = Conversions.ToSingle(_txtKnowns_4.Text);
							Globals_Renamed.arOpParmsType[14, Globals_Renamed.intOpIndex] = Conversions.ToShort(Interaction.IIf((int)_chkKnowns1_4.CheckState == 1, (object)(short)2, (object)(short)1));
							pDim = 14;
							ref float pValue4 = ref Globals_Renamed.arOpParms[14, Globals_Renamed.intOpIndex];
							pToArray = null;
							ChemStrX.RollDownhillOp(ref pDim, ref pValue4, ref pToArray);
							if (Versioned.IsNumeric((object)_txtOther_0.Text))
							{
								Globals_Renamed.arOpParms[13, Globals_Renamed.intOpIndex] = Conversions.ToSingle(_txtOther_0.Text);
								Globals_Renamed.arOpParmsType[13, Globals_Renamed.intOpIndex] = Conversions.ToShort(Interaction.IIf((int)_chkOther_0.CheckState == 1, (object)(short)2, (object)(short)1));
							}
							else
							{
								Globals_Renamed.arOpParms[13, Globals_Renamed.intOpIndex] = 0f;
								Globals_Renamed.arOpParmsType[13, Globals_Renamed.intOpIndex] = Conversions.ToShort(Interaction.IIf((int)_chkOther_0.CheckState == 1, (object)(short)2, (object)(short)1));
							}
							pDim = 13;
							ref float pValue5 = ref Globals_Renamed.arOpParms[13, Globals_Renamed.intOpIndex];
							pToArray = (short)(-1000);
							ChemStrX.RollDownhillOp(ref pDim, ref pValue5, ref pToArray);
							if (Versioned.IsNumeric((object)_txtOther_1.Text))
							{
								Globals_Renamed.arOpParms[10, Globals_Renamed.intOpIndex] = Conversions.ToSingle(_txtOther_1.Text);
								Globals_Renamed.arOpParmsType[10, Globals_Renamed.intOpIndex] = Conversions.ToShort(Interaction.IIf((int)_chkOther_1.CheckState == 1, (object)(short)2, (object)(short)1));
							}
							else
							{
								Globals_Renamed.arOpParms[10, Globals_Renamed.intOpIndex] = 0f;
								Globals_Renamed.arOpParmsType[10, Globals_Renamed.intOpIndex] = Conversions.ToShort(Interaction.IIf((int)_chkOther_1.CheckState == 1, (object)(short)2, (object)(short)1));
							}
							pDim = 10;
							ref float pValue6 = ref Globals_Renamed.arOpParms[10, Globals_Renamed.intOpIndex];
							pToArray = (short)(-1000);
							ChemStrX.RollDownhillOp(ref pDim, ref pValue6, ref pToArray);
							if (Versioned.IsNumeric((object)_txtOther_2.Text))
							{
								Globals_Renamed.arOpParms[12, Globals_Renamed.intOpIndex] = Conversions.ToSingle(_txtOther_2.Text);
								Globals_Renamed.arOpParmsType[12, Globals_Renamed.intOpIndex] = Conversions.ToShort(Interaction.IIf((int)_chkOther_2.CheckState == 1, (object)(short)2, (object)(short)1));
							}
							else
							{
								Globals_Renamed.arOpParms[12, Globals_Renamed.intOpIndex] = 0f;
								Globals_Renamed.arOpParmsType[12, Globals_Renamed.intOpIndex] = Conversions.ToShort(Interaction.IIf((int)_chkOther_2.CheckState == 1, (object)(short)2, (object)(short)1));
							}
							pDim = 12;
							ref float pValue7 = ref Globals_Renamed.arOpParms[12, Globals_Renamed.intOpIndex];
							pToArray = null;
							ChemStrX.RollDownhillOp(ref pDim, ref pValue7, ref pToArray);
						}
						else
						{
							Globals_Renamed.arOpParms[13, Globals_Renamed.intOpIndex] = Conversions.ToSingle(_txtKnowns_2.Text);
							Globals_Renamed.arOpParmsType[13, Globals_Renamed.intOpIndex] = Conversions.ToShort(Interaction.IIf((int)_chkKnowns1_2.CheckState == 1, (object)(short)2, (object)(short)1));
							pDim = 13;
							ref float pValue8 = ref Globals_Renamed.arOpParms[13, Globals_Renamed.intOpIndex];
							pToArray = (short)(-1000);
							ChemStrX.RollDownhillOp(ref pDim, ref pValue8, ref pToArray);
							Globals_Renamed.arOpParms[10, Globals_Renamed.intOpIndex] = Conversions.ToSingle(_txtKnowns_3.Text);
							Globals_Renamed.arOpParmsType[10, Globals_Renamed.intOpIndex] = Conversions.ToShort(Interaction.IIf((int)_chkKnowns1_3.CheckState == 1, (object)(short)2, (object)(short)1));
							pDim = 10;
							ref float pValue9 = ref Globals_Renamed.arOpParms[10, Globals_Renamed.intOpIndex];
							pToArray = (short)(-1000);
							ChemStrX.RollDownhillOp(ref pDim, ref pValue9, ref pToArray);
							Globals_Renamed.arOpParms[12, Globals_Renamed.intOpIndex] = Conversions.ToSingle(_txtKnowns_4.Text);
							Globals_Renamed.arOpParmsType[12, Globals_Renamed.intOpIndex] = Conversions.ToShort(Interaction.IIf((int)_chkKnowns1_4.CheckState == 1, (object)(short)2, (object)(short)1));
							pDim = 12;
							ref float pValue10 = ref Globals_Renamed.arOpParms[12, Globals_Renamed.intOpIndex];
							pToArray = null;
							ChemStrX.RollDownhillOp(ref pDim, ref pValue10, ref pToArray);
							if (Versioned.IsNumeric((object)_txtOther_0.Text))
							{
								Globals_Renamed.arOpParms[15, Globals_Renamed.intOpIndex] = Conversions.ToSingle(_txtOther_0.Text);
								Globals_Renamed.arOpParmsType[15, Globals_Renamed.intOpIndex] = Conversions.ToShort(Interaction.IIf((int)_chkOther_0.CheckState == 1, (object)(short)2, (object)(short)1));
							}
							else
							{
								Globals_Renamed.arOpParms[15, Globals_Renamed.intOpIndex] = 0f;
								Globals_Renamed.arOpParmsType[15, Globals_Renamed.intOpIndex] = Conversions.ToShort(Interaction.IIf((int)_chkOther_0.CheckState == 1, (object)(short)2, (object)(short)1));
							}
							pDim = 15;
							ref float pValue11 = ref Globals_Renamed.arOpParms[15, Globals_Renamed.intOpIndex];
							pToArray = (short)(-1000);
							ChemStrX.RollDownhillOp(ref pDim, ref pValue11, ref pToArray);
							if (Versioned.IsNumeric((object)_txtOther_1.Text))
							{
								Globals_Renamed.arOpParms[11, Globals_Renamed.intOpIndex] = Conversions.ToSingle(_txtOther_1.Text);
								Globals_Renamed.arOpParmsType[11, Globals_Renamed.intOpIndex] = Conversions.ToShort(Interaction.IIf((int)_chkOther_1.CheckState == 1, (object)(short)2, (object)(short)1));
							}
							else
							{
								Globals_Renamed.arOpParms[11, Globals_Renamed.intOpIndex] = 0f;
								Globals_Renamed.arOpParmsType[11, Globals_Renamed.intOpIndex] = Conversions.ToShort(Interaction.IIf((int)_chkOther_1.CheckState == 1, (object)(short)2, (object)(short)1));
							}
							pDim = 11;
							ref float pValue12 = ref Globals_Renamed.arOpParms[11, Globals_Renamed.intOpIndex];
							pToArray = (short)(-1000);
							ChemStrX.RollDownhillOp(ref pDim, ref pValue12, ref pToArray);
							if (Versioned.IsNumeric((object)_txtOther_2.Text))
							{
								Globals_Renamed.arOpParms[14, Globals_Renamed.intOpIndex] = Conversions.ToSingle(_txtOther_2.Text);
								Globals_Renamed.arOpParmsType[14, Globals_Renamed.intOpIndex] = Conversions.ToShort(Interaction.IIf((int)_chkOther_2.CheckState == 1, (object)(short)2, (object)(short)1));
							}
							else
							{
								Globals_Renamed.arOpParms[14, Globals_Renamed.intOpIndex] = 0f;
								Globals_Renamed.arOpParmsType[14, Globals_Renamed.intOpIndex] = Conversions.ToShort(Interaction.IIf((int)_chkOther_2.CheckState == 1, (object)(short)2, (object)(short)1));
							}
							pDim = 14;
							ref float pValue13 = ref Globals_Renamed.arOpParms[14, Globals_Renamed.intOpIndex];
							pToArray = null;
							ChemStrX.RollDownhillOp(ref pDim, ref pValue13, ref pToArray);
						}
					}
					else
					{
						Globals_Renamed.arOpParmsType[16, Globals_Renamed.intOpIndex] = Conversions.ToShort(Interaction.IIf((int)chkKnowns1[(short)1].CheckState == 1, (object)(short)2, (object)(short)1));
						pValue = Conversions.ToSingle(_txtKnowns_1.Text);
						if (Globals_Renamed.arOpParms[16, Globals_Renamed.intOpIndex] != pValue)
						{
							Globals_Renamed.arOpParms[16, Globals_Renamed.intOpIndex] = pValue;
							pDim = 16;
							pToArray = (short)(-1000);
							ChemStrX.RollDownhillOp(ref pDim, ref pValue, ref pToArray);
						}
						if (optInfOrEff[(short)0].Checked)
						{
							Globals_Renamed.arOpParms[11, Globals_Renamed.intOpIndex] = Conversions.ToSingle(_txtKnowns_3.Text);
							Globals_Renamed.arOpParmsType[11, Globals_Renamed.intOpIndex] = Conversions.ToShort(Interaction.IIf((int)_chkKnowns1_3.CheckState == 1, (object)(short)2, (object)(short)1));
							pDim = 11;
							ref float pValue14 = ref Globals_Renamed.arOpParms[11, Globals_Renamed.intOpIndex];
							pToArray = (short)(-1000);
							ChemStrX.RollDownhillOp(ref pDim, ref pValue14, ref pToArray);
							Globals_Renamed.arOpParms[99, Globals_Renamed.intOpIndex] = Conversions.ToSingle(_txtKnowns_4.Text);
							Globals_Renamed.arOpParmsType[99, Globals_Renamed.intOpIndex] = Conversions.ToShort(Interaction.IIf((int)chkKnowns1[(short)4].CheckState == 1, (object)(short)2, (object)(short)1));
							Globals_Renamed.arOpParms[103, Globals_Renamed.intOpIndex] = Conversions.ToSingle(_txtKnowns_2.Text);
							Globals_Renamed.arOpParmsType[103, Globals_Renamed.intOpIndex] = Conversions.ToShort(Interaction.IIf((int)chkKnowns1[(short)2].CheckState == 1, (object)(short)2, (object)(short)1));
							pDim = 103;
							ref float pValue15 = ref Globals_Renamed.arOpParms[103, Globals_Renamed.intOpIndex];
							pToArray = (short)(-1000);
							ChemStrX.RollDownhillOp(ref pDim, ref pValue15, ref pToArray);
							if (Versioned.IsNumeric((object)_txtOther_0.Text))
							{
								Globals_Renamed.arOpParms[104, Globals_Renamed.intOpIndex] = Conversions.ToSingle(_txtOther_0.Text);
								Globals_Renamed.arOpParmsType[104, Globals_Renamed.intOpIndex] = Conversions.ToShort(Interaction.IIf((int)_chkOther_0.CheckState == 1, (object)(short)2, (object)(short)1));
							}
							else
							{
								Globals_Renamed.arOpParms[104, Globals_Renamed.intOpIndex] = 0f;
								Globals_Renamed.arOpParmsType[104, Globals_Renamed.intOpIndex] = Conversions.ToShort(Interaction.IIf((int)_chkOther_0.CheckState == 1, (object)(short)2, (object)(short)1));
							}
							pDim = 104;
							ref float pValue16 = ref Globals_Renamed.arOpParms[104, Globals_Renamed.intOpIndex];
							pToArray = (short)(-1000);
							ChemStrX.RollDownhillOp(ref pDim, ref pValue16, ref pToArray);
							if (Versioned.IsNumeric((object)_txtOther_1.Text))
							{
								Globals_Renamed.arOpParms[10, Globals_Renamed.intOpIndex] = Conversions.ToSingle(_txtOther_1.Text);
								Globals_Renamed.arOpParmsType[10, Globals_Renamed.intOpIndex] = Conversions.ToShort(Interaction.IIf((int)_chkOther_1.CheckState == 1, (object)(short)2, (object)(short)1));
							}
							else
							{
								Globals_Renamed.arOpParms[10, Globals_Renamed.intOpIndex] = 0f;
								Globals_Renamed.arOpParmsType[10, Globals_Renamed.intOpIndex] = Conversions.ToShort(Interaction.IIf((int)_chkOther_1.CheckState == 1, (object)(short)2, (object)(short)1));
							}
							pDim = 10;
							ref float pValue17 = ref Globals_Renamed.arOpParms[10, Globals_Renamed.intOpIndex];
							pToArray = (short)(-1000);
							ChemStrX.RollDownhillOp(ref pDim, ref pValue17, ref pToArray);
							if (Versioned.IsNumeric((object)_txtOther_2.Text))
							{
								Globals_Renamed.arOpParms[32, Globals_Renamed.intOpIndex] = Conversions.ToSingle(_txtOther_2.Text);
								Globals_Renamed.arOpParmsType[32, Globals_Renamed.intOpIndex] = Conversions.ToShort(Interaction.IIf((int)_chkOther_2.CheckState == 1, (object)(short)2, (object)(short)1));
							}
							else
							{
								Globals_Renamed.arOpParms[32, Globals_Renamed.intOpIndex] = 0f;
								Globals_Renamed.arOpParmsType[32, Globals_Renamed.intOpIndex] = Conversions.ToShort(Interaction.IIf((int)_chkOther_2.CheckState == 1, (object)(short)2, (object)(short)1));
							}
						}
						else
						{
							Globals_Renamed.arOpParms[10, Globals_Renamed.intOpIndex] = Conversions.ToSingle(_txtKnowns_3.Text);
							Globals_Renamed.arOpParmsType[10, Globals_Renamed.intOpIndex] = Conversions.ToShort(Interaction.IIf((int)_chkKnowns1_3.CheckState == 1, (object)(short)2, (object)(short)1));
							pDim = 10;
							ref float pValue18 = ref Globals_Renamed.arOpParms[10, Globals_Renamed.intOpIndex];
							pToArray = (short)(-1000);
							ChemStrX.RollDownhillOp(ref pDim, ref pValue18, ref pToArray);
							Globals_Renamed.arOpParms[32, Globals_Renamed.intOpIndex] = Conversions.ToSingle(_txtKnowns_4.Text);
							Globals_Renamed.arOpParmsType[32, Globals_Renamed.intOpIndex] = Conversions.ToShort(Interaction.IIf((int)chkKnowns1[(short)4].CheckState == 1, (object)(short)2, (object)(short)1));
							Globals_Renamed.arOpParms[104, Globals_Renamed.intOpIndex] = Conversions.ToSingle(_txtKnowns_2.Text);
							Globals_Renamed.arOpParmsType[104, Globals_Renamed.intOpIndex] = Conversions.ToShort(Interaction.IIf((int)chkKnowns1[(short)2].CheckState == 1, (object)(short)2, (object)(short)1));
							pDim = 104;
							ref float pValue19 = ref Globals_Renamed.arOpParms[104, Globals_Renamed.intOpIndex];
							pToArray = (short)(-1000);
							ChemStrX.RollDownhillOp(ref pDim, ref pValue19, ref pToArray);
							if (Versioned.IsNumeric((object)_txtOther_0.Text))
							{
								Globals_Renamed.arOpParms[103, Globals_Renamed.intOpIndex] = Conversions.ToSingle(_txtOther_0.Text);
								Globals_Renamed.arOpParmsType[103, Globals_Renamed.intOpIndex] = Conversions.ToShort(Interaction.IIf((int)_chkOther_0.CheckState == 1, (object)(short)2, (object)(short)1));
							}
							else
							{
								Globals_Renamed.arOpParms[103, Globals_Renamed.intOpIndex] = 0f;
								Globals_Renamed.arOpParmsType[103, Globals_Renamed.intOpIndex] = Conversions.ToShort(Interaction.IIf((int)_chkOther_0.CheckState == 1, (object)(short)2, (object)(short)1));
							}
							pDim = 103;
							ref float pValue20 = ref Globals_Renamed.arOpParms[103, Globals_Renamed.intOpIndex];
							pToArray = (short)(-1000);
							ChemStrX.RollDownhillOp(ref pDim, ref pValue20, ref pToArray);
							if (Versioned.IsNumeric((object)_txtOther_1.Text))
							{
								Globals_Renamed.arOpParms[11, Globals_Renamed.intOpIndex] = Conversions.ToSingle(_txtOther_1.Text);
								Globals_Renamed.arOpParmsType[11, Globals_Renamed.intOpIndex] = Conversions.ToShort(Interaction.IIf((int)_chkOther_1.CheckState == 1, (object)(short)2, (object)(short)1));
							}
							else
							{
								Globals_Renamed.arOpParms[11, Globals_Renamed.intOpIndex] = 0f;
								Globals_Renamed.arOpParmsType[11, Globals_Renamed.intOpIndex] = Conversions.ToShort(Interaction.IIf((int)_chkOther_1.CheckState == 1, (object)(short)2, (object)(short)1));
							}
							pDim = 11;
							ref float pValue21 = ref Globals_Renamed.arOpParms[11, Globals_Renamed.intOpIndex];
							pToArray = (short)(-1000);
							ChemStrX.RollDownhillOp(ref pDim, ref pValue21, ref pToArray);
							if (Versioned.IsNumeric((object)_txtOther_2.Text))
							{
								Globals_Renamed.arOpParms[99, Globals_Renamed.intOpIndex] = Conversions.ToSingle(_txtOther_2.Text);
								Globals_Renamed.arOpParmsType[99, Globals_Renamed.intOpIndex] = Conversions.ToShort(Interaction.IIf((int)_chkOther_2.CheckState == 1, (object)(short)2, (object)(short)1));
							}
							else
							{
								Globals_Renamed.arOpParms[99, Globals_Renamed.intOpIndex] = 0f;
								Globals_Renamed.arOpParmsType[99, Globals_Renamed.intOpIndex] = Conversions.ToShort(Interaction.IIf((int)_chkOther_2.CheckState == 1, (object)(short)2, (object)(short)1));
							}
						}
						pDim = 99;
						ref float pValue22 = ref Globals_Renamed.arOpParms[99, Globals_Renamed.intOpIndex];
						pToArray = null;
						ChemStrX.RollDownhillOp(ref pDim, ref pValue22, ref pToArray);
						pDim = 32;
						ref float pValue23 = ref Globals_Renamed.arOpParms[32, Globals_Renamed.intOpIndex];
						pToArray = null;
						ChemStrX.RollDownhillOp(ref pDim, ref pValue23, ref pToArray);
						Globals_Renamed.arOpParms[101, Globals_Renamed.intOpIndex] = Conversions.ToSingle(Common.MyNullCheck0(txtOBatch1[(short)0].Text));
						Globals_Renamed.arOpParmsType[101, Globals_Renamed.intOpIndex] = 2;
						Globals_Renamed.arOpParms[18, Globals_Renamed.intOpIndex] = Conversions.ToSingle(Common.MyNullCheck0(txtOBatch1[(short)1].Text));
						Globals_Renamed.arOpParmsType[18, Globals_Renamed.intOpIndex] = 2;
						checked
						{
							short num3 = (short)(((BaseControlArray)txtOBatch2).Count() - 1);
							num4 = 0;
							while (true)
							{
								short num5 = num4;
								short num6 = num3;
								if (num5 > num6)
								{
									break;
								}
								short num7 = Conversions.ToShort(Interaction.Choose((double)(num4 + 1), new object[3]
								{
									(short)24,
									(short)102,
									(short)2
								}));
								Globals_Renamed.arOpParms[num7, Globals_Renamed.intOpIndex] = Conversions.ToSingle(Common.MyNullCheck0(txtOBatch2[num4].Text));
								if (unchecked((int)chkOBatch2[num4].CheckState) == 1)
								{
									Globals_Renamed.arOpParmsType[num7, Globals_Renamed.intOpIndex] = 2;
								}
								else if (Operators.ConditionalCompareObjectEqual(((Control)chkOBatch2[num4]).Tag, (object)"clicked", false))
								{
									Globals_Renamed.arOpParmsType[num7, Globals_Renamed.intOpIndex] = 4;
								}
								else
								{
									Globals_Renamed.arOpParmsType[num7, Globals_Renamed.intOpIndex] = 1;
								}
								num4 = (short)unchecked(num4 + 1);
							}
							Globals_Renamed.arOpParms[17, Globals_Renamed.intOpIndex] = Conversions.ToSingle(Common.MyNullCheck0(txtOBatch3.Text));
							Globals_Renamed.arOpParmsType[17, Globals_Renamed.intOpIndex] = 1;
							Globals_Renamed.arOpParms[107, Globals_Renamed.intOpIndex] = Globals_Renamed.arOpParms[103, Globals_Renamed.intOpIndex] * Globals_Renamed.arOpParms[17, Globals_Renamed.intOpIndex];
							Globals_Renamed.arOpParmsType[107, Globals_Renamed.intOpIndex] = 1;
							pDim = 107;
							ref float pValue24 = ref Globals_Renamed.arOpParms[107, Globals_Renamed.intOpIndex];
							pToArray = null;
							ChemStrX.RollDownhillOp(ref pDim, ref pValue24, ref pToArray);
							Globals_Renamed.arOpParms[106, Globals_Renamed.intOpIndex] = Globals_Renamed.arOpParms[104, Globals_Renamed.intOpIndex] * Globals_Renamed.arOpParms[17, Globals_Renamed.intOpIndex];
							Globals_Renamed.arOpParmsType[106, Globals_Renamed.intOpIndex] = 1;
							pDim = 106;
							ref float pValue25 = ref Globals_Renamed.arOpParms[106, Globals_Renamed.intOpIndex];
							pToArray = null;
							ChemStrX.RollDownhillOp(ref pDim, ref pValue25, ref pToArray);
							Globals_Renamed.arOpParms[109, Globals_Renamed.intOpIndex] = Globals_Renamed.arOpParms[103, Globals_Renamed.intOpIndex] * Globals_Renamed.arOpParms[102, Globals_Renamed.intOpIndex];
							Globals_Renamed.arOpParmsType[109, Globals_Renamed.intOpIndex] = 1;
							pDim = 109;
							ref float pValue26 = ref Globals_Renamed.arOpParms[109, Globals_Renamed.intOpIndex];
							pToArray = null;
							ChemStrX.RollDownhillOp(ref pDim, ref pValue26, ref pToArray);
							Globals_Renamed.arOpParms[108, Globals_Renamed.intOpIndex] = Globals_Renamed.arOpParms[104, Globals_Renamed.intOpIndex] * Globals_Renamed.arOpParms[102, Globals_Renamed.intOpIndex];
							Globals_Renamed.arOpParmsType[108, Globals_Renamed.intOpIndex] = 1;
							pDim = 108;
							ref float pValue27 = ref Globals_Renamed.arOpParms[108, Globals_Renamed.intOpIndex];
							pToArray = null;
							ChemStrX.RollDownhillOp(ref pDim, ref pValue27, ref pToArray);
							Globals_Renamed.arOpParms[83, Globals_Renamed.intOpIndex] = Globals_Renamed.arOpParms[99, Globals_Renamed.intOpIndex] * Globals_Renamed.arOpParms[17, Globals_Renamed.intOpIndex];
							Globals_Renamed.arOpParmsType[83, Globals_Renamed.intOpIndex] = 1;
							pDim = 83;
							ref float pValue28 = ref Globals_Renamed.arOpParms[83, Globals_Renamed.intOpIndex];
							pToArray = null;
							ChemStrX.RollDownhillOp(ref pDim, ref pValue28, ref pToArray);
							Globals_Renamed.arOpParms[85, Globals_Renamed.intOpIndex] = Globals_Renamed.arOpParms[32, Globals_Renamed.intOpIndex] * Globals_Renamed.arOpParms[17, Globals_Renamed.intOpIndex];
							Globals_Renamed.arOpParmsType[85, Globals_Renamed.intOpIndex] = 1;
							pDim = 85;
							ref float pValue29 = ref Globals_Renamed.arOpParms[85, Globals_Renamed.intOpIndex];
							pToArray = null;
							ChemStrX.RollDownhillOp(ref pDim, ref pValue29, ref pToArray);
							if (Globals_Renamed.arOpParms[102, Globals_Renamed.intOpIndex] == 0f)
							{
								Globals_Renamed.arOpParms[84, Globals_Renamed.intOpIndex] = 0f;
								Globals_Renamed.arOpParms[86, Globals_Renamed.intOpIndex] = 0f;
							}
							else
							{
								Globals_Renamed.arOpParms[84, Globals_Renamed.intOpIndex] = Globals_Renamed.arOpParms[99, Globals_Renamed.intOpIndex] * Globals_Renamed.arOpParms[17, Globals_Renamed.intOpIndex] / Globals_Renamed.arOpParms[102, Globals_Renamed.intOpIndex];
								Globals_Renamed.arOpParms[86, Globals_Renamed.intOpIndex] = Globals_Renamed.arOpParms[32, Globals_Renamed.intOpIndex] * Globals_Renamed.arOpParms[17, Globals_Renamed.intOpIndex] / Globals_Renamed.arOpParms[102, Globals_Renamed.intOpIndex];
								Globals_Renamed.arOpParmsType[84, Globals_Renamed.intOpIndex] = 1;
								Globals_Renamed.arOpParmsType[86, Globals_Renamed.intOpIndex] = 1;
							}
							pDim = 84;
							ref float pValue30 = ref Globals_Renamed.arOpParms[84, Globals_Renamed.intOpIndex];
							pToArray = null;
							ChemStrX.RollDownhillOp(ref pDim, ref pValue30, ref pToArray);
							pDim = 86;
							ref float pValue31 = ref Globals_Renamed.arOpParms[86, Globals_Renamed.intOpIndex];
							pToArray = null;
							ChemStrX.RollDownhillOp(ref pDim, ref pValue31, ref pToArray);
							Globals_Renamed.arOpParms[88, Globals_Renamed.intOpIndex] = Globals_Renamed.arOpParms[99, Globals_Renamed.intOpIndex] * Globals_Renamed.arOpParms[102, Globals_Renamed.intOpIndex];
							Globals_Renamed.arOpParmsType[88, Globals_Renamed.intOpIndex] = 1;
							pDim = 88;
							ref float pValue32 = ref Globals_Renamed.arOpParms[88, Globals_Renamed.intOpIndex];
							pToArray = null;
							ChemStrX.RollDownhillOp(ref pDim, ref pValue32, ref pToArray);
							Globals_Renamed.arOpParms[89, Globals_Renamed.intOpIndex] = Globals_Renamed.arOpParms[32, Globals_Renamed.intOpIndex] * Globals_Renamed.arOpParms[102, Globals_Renamed.intOpIndex];
							Globals_Renamed.arOpParmsType[89, Globals_Renamed.intOpIndex] = 1;
							pDim = 89;
							ref float pValue33 = ref Globals_Renamed.arOpParms[89, Globals_Renamed.intOpIndex];
							pToArray = null;
							ChemStrX.RollDownhillOp(ref pDim, ref pValue33, ref pToArray);
							Globals_Renamed.arOpParms[123, Globals_Renamed.intOpIndex] = Globals_Renamed.arOpParms[104, Globals_Renamed.intOpIndex] * Globals_Renamed.arOpParms[17, Globals_Renamed.intOpIndex] / Globals_Renamed.arOpParms[102, Globals_Renamed.intOpIndex];
							Globals_Renamed.arOpParmsType[123, Globals_Renamed.intOpIndex] = 1;
							pDim = 123;
							ref float pValue34 = ref Globals_Renamed.arOpParms[123, Globals_Renamed.intOpIndex];
							pToArray = null;
							ChemStrX.RollDownhillOp(ref pDim, ref pValue34, ref pToArray);
							Globals_Renamed.arOpParms[33, Globals_Renamed.intOpIndex] = Globals_Renamed.arOpParms[103, Globals_Renamed.intOpIndex] * Globals_Renamed.arOpParms[17, Globals_Renamed.intOpIndex] / Globals_Renamed.arOpParms[102, Globals_Renamed.intOpIndex];
							Globals_Renamed.arOpParmsType[33, Globals_Renamed.intOpIndex] = 1;
							pDim = 33;
							ref float pValue35 = ref Globals_Renamed.arOpParms[33, Globals_Renamed.intOpIndex];
							pToArray = null;
							ChemStrX.RollDownhillOp(ref pDim, ref pValue35, ref pToArray);
						}
					}
					pDim = 2;
					ref float pValue36 = ref Globals_Renamed.arOpParms[2, Globals_Renamed.intOpIndex];
					pToArray = (short)(-1000);
					ChemStrX.RollDownhillOp(ref pDim, ref pValue36, ref pToArray);
					ref double myPvOp = ref MyPvOp;
					RadioButton val3 = optContOrBatch[(short)1];
					bool Econtact = val3.Checked;
					ChemStrX.ResetContParms(ref Globals_Renamed.intOpIndex, ref myPvOp, ref Econtact);
					val3.Checked = Econtact;
					switch (Globals_Renamed.arOpType[Globals_Renamed.intOpIndex])
					{
					case 100:
						if (sVcar > 0f)
						{
							Globals_Renamed.arOpParms[21, Globals_Renamed.intOpIndex] = sVcar;
							Globals_Renamed.arOpParmsType[21, Globals_Renamed.intOpIndex] = 1;
							Globals_Renamed.arOpParms[25, Globals_Renamed.intOpIndex] = sNcar;
							Globals_Renamed.arOpParmsType[25, Globals_Renamed.intOpIndex] = 1;
							Globals_Renamed.arOpParms[30, Globals_Renamed.intOpIndex] = sDprod;
							Globals_Renamed.arOpParmsType[30, Globals_Renamed.intOpIndex] = 1;
						}
						else if (sVpaint > 0f)
						{
							Globals_Renamed.arOpParms[27, Globals_Renamed.intOpIndex] = sVpaint;
							Globals_Renamed.arOpParmsType[27, Globals_Renamed.intOpIndex] = 1;
							Globals_Renamed.arOpParms[30, Globals_Renamed.intOpIndex] = sDprod;
							Globals_Renamed.arOpParmsType[30, Globals_Renamed.intOpIndex] = 1;
						}
						break;
					case 101:
						Globals_Renamed.arOpParms[29, Globals_Renamed.intOpIndex] = sDrm;
						Globals_Renamed.arOpParms[116, Globals_Renamed.intOpIndex] = sDVIppaint;
						break;
					case 102:
						Globals_Renamed.arOpParms[115, Globals_Renamed.intOpIndex] = sVbatch;
						break;
					case 103:
					{
						Globals_Renamed.arOpParms[126, Globals_Renamed.intOpIndex] = sRRctw;
						Globals_Renamed.arOpParms[124, Globals_Renamed.intOpIndex] = sYctw;
						Globals_Renamed.arOpParms[35, Globals_Renamed.intOpIndex] = sHD;
						Globals_Renamed.arOpParms[125, Globals_Renamed.intOpIndex] = sDctw;
						Globals_Renamed.arOpParms[127, Globals_Renamed.intOpIndex] = sLFb;
						Globals_Renamed.arOpParms[128, Globals_Renamed.intOpIndex] = sLFw;
						Globals_Renamed.arOpParms[129, Globals_Renamed.intOpIndex] = sLFe;
						Globals_Renamed.arOpParms[130, Globals_Renamed.intOpIndex] = sDRRchem;
						pDim = 127;
						ref float pValue45 = ref Globals_Renamed.arOpParms[127, Globals_Renamed.intOpIndex];
						pToArray = null;
						ChemStrX.RollDownhillOp(ref pDim, ref pValue45, ref pToArray);
						pDim = 128;
						ref float pValue46 = ref Globals_Renamed.arOpParms[128, Globals_Renamed.intOpIndex];
						pToArray = null;
						ChemStrX.RollDownhillOp(ref pDim, ref pValue46, ref pToArray);
						pDim = 129;
						ref float pValue47 = ref Globals_Renamed.arOpParms[129, Globals_Renamed.intOpIndex];
						pToArray = null;
						ChemStrX.RollDownhillOp(ref pDim, ref pValue47, ref pToArray);
						pDim = 130;
						ref float pValue48 = ref Globals_Renamed.arOpParms[130, Globals_Renamed.intOpIndex];
						pToArray = null;
						ChemStrX.RollDownhillOp(ref pDim, ref pValue48, ref pToArray);
						Globals_Renamed.arOpParms[92, Globals_Renamed.intOpIndex] = sDRRchem;
						break;
					}
					case 104:
					{
						Globals_Renamed.arOpParms[131, Globals_Renamed.intOpIndex] = sYbath;
						Globals_Renamed.arOpParms[132, Globals_Renamed.intOpIndex] = sYrinse;
						Globals_Renamed.arOpParms[133, Globals_Renamed.intOpIndex] = sDbath;
						Globals_Renamed.arOpParms[134, Globals_Renamed.intOpIndex] = sDrinse;
						Globals_Renamed.arOpParms[135, Globals_Renamed.intOpIndex] = sVbath;
						Globals_Renamed.arOpParms[136, Globals_Renamed.intOpIndex] = sNbath;
						Globals_Renamed.arOpParms[137, Globals_Renamed.intOpIndex] = sFreqbath;
						Globals_Renamed.arOpParms[138, Globals_Renamed.intOpIndex] = sDVrinse;
						Globals_Renamed.arOpParms[139, Globals_Renamed.intOpIndex] = sRinseE;
						Globals_Renamed.arOpParms[141, Globals_Renamed.intOpIndex] = sVbath * sNbath;
						pDim = 141;
						ref float pValue37 = ref Globals_Renamed.arOpParms[141, Globals_Renamed.intOpIndex];
						pToArray = (short)(-1302);
						ChemStrX.RollDownhillOp(ref pDim, ref pValue37, ref pToArray);
						pDim = 133;
						ref float pValue38 = ref Globals_Renamed.arOpParms[133, Globals_Renamed.intOpIndex];
						pToArray = (short)(-1302);
						ChemStrX.RollDownhillOp(ref pDim, ref pValue38, ref pToArray);
						pDim = 131;
						ref float pValue39 = ref Globals_Renamed.arOpParms[131, Globals_Renamed.intOpIndex];
						pToArray = (short)(-1302);
						ChemStrX.RollDownhillOp(ref pDim, ref pValue39, ref pToArray);
						pDim = 138;
						ref float pValue40 = ref Globals_Renamed.arOpParms[138, Globals_Renamed.intOpIndex];
						pToArray = (short)(-1302);
						ChemStrX.RollDownhillOp(ref pDim, ref pValue40, ref pToArray);
						pDim = 132;
						ref float pValue41 = ref Globals_Renamed.arOpParms[132, Globals_Renamed.intOpIndex];
						pToArray = (short)(-1302);
						ChemStrX.RollDownhillOp(ref pDim, ref pValue41, ref pToArray);
						pDim = 134;
						ref float pValue42 = ref Globals_Renamed.arOpParms[134, Globals_Renamed.intOpIndex];
						pToArray = (short)(-1302);
						ChemStrX.RollDownhillOp(ref pDim, ref pValue42, ref pToArray);
						pDim = 137;
						ref float pValue43 = ref Globals_Renamed.arOpParms[137, Globals_Renamed.intOpIndex];
						pToArray = (short)(-1302);
						ChemStrX.RollDownhillOp(ref pDim, ref pValue43, ref pToArray);
						pDim = 139;
						ref float pValue44 = ref Globals_Renamed.arOpParms[139, Globals_Renamed.intOpIndex];
						pToArray = (short)(-1302);
						ChemStrX.RollDownhillOp(ref pDim, ref pValue44, ref pToArray);
						break;
					}
					}
					ChemStrX.ResetMetaDefaults();
					frmMain.DefInstance.LoadMsfOpIP();
					num4 = 0;
					checked
					{
						short num10;
						short num6;
						do
						{
							short num7 = 0;
							short num8;
							do
							{
								if (Globals_Renamed.arRelModels[num7, num4, Globals_Renamed.intOpIndex] > 0)
								{
									Globals_Renamed.arRelModStatus[Globals_Renamed.arRelModels[num7, num4, Globals_Renamed.intOpIndex] - 1] = 3;
								}
								num7 = (short)unchecked(num7 + 1);
								num8 = num7;
								num6 = 9;
							}
							while (num8 <= num6);
							num7 = 0;
							short num9;
							do
							{
								if (Globals_Renamed.arExpModels[num7, num4, Globals_Renamed.intOpIndex] > 0)
								{
									Globals_Renamed.arExpModStatus[Globals_Renamed.arExpModels[num7, num4, Globals_Renamed.intOpIndex] - 1] = 3;
								}
								num7 = (short)unchecked(num7 + 1);
								num9 = num7;
								num6 = 1;
							}
							while (num9 <= num6);
							num4 = (short)unchecked(num4 + 1);
							num10 = num4;
							num6 = 24;
						}
						while (num10 <= num6);
						frmMain.DefInstance.cmbRelOps.SelectedIndex = -1;
						frmMain.DefInstance.cmbExpOps.SelectedIndex = -1;
						obj = true;
						goto end_IL_0001;
					}
				}
				case 8605:
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
			catch (object obj2) when (obj2 is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0001_dispatch = 8605;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		object result = obj;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private void txtKnowns_Enter(object eventSender, EventArgs eventArgs)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		short index = txtKnowns.GetIndex((TextBox)eventSender);
	}

	private void txtKnowns_Leave(object eventSender, EventArgs eventArgs)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		short index = txtKnowns.GetIndex((TextBox)eventSender);
		if (Strings.Len(txtKnowns[index].Text) == 0 || ((TextBoxBase)txtKnowns[index]).ReadOnly)
		{
			return;
		}
		bool flag = default(bool);
		if (Versioned.IsNumeric((object)txtKnowns[index].Text))
		{
			switch (index)
			{
			case 0:
				if (Conversions.ToDouble(_txtKnowns_0.Text) * 1000.0 % 1000.0 == 0.0 && Conversions.ToDouble(txtKnowns[index].Text) > 0.0)
				{
					flag = true;
				}
				break;
			case 1:
				if (optContOrBatch[(short)0].Checked)
				{
					if ((Conversions.ToDouble(txtKnowns[index].Text) > 0.0) & (Conversions.ToDouble(txtKnowns[index].Text) <= 365.0))
					{
						flag = true;
					}
				}
				else if (Conversions.ToDouble(txtKnowns[index].Text) > 0.0)
				{
					flag = true;
				}
				break;
			case 3:
				if ((Conversions.ToDouble(txtKnowns[index].Text) > 0.0) & (Conversions.ToDouble(txtKnowns[index].Text) <= 1.0))
				{
					flag = true;
				}
				break;
			default:
				if (Conversions.ToDouble(txtKnowns[index].Text) > 0.0)
				{
					flag = true;
				}
				break;
			}
		}
		if (!flag)
		{
			Interaction.Beep();
			if (index == 3)
			{
				Interaction.MsgBox((object)"Please enter a number less then 1.", (MsgBoxStyle)64, (object)"Invalid Parameter");
			}
			else
			{
				Interaction.MsgBox((object)"Please enter a valid number", (MsgBoxStyle)64, (object)"Invalid Parameter");
			}
			((TextBoxBase)txtKnowns[index]).SelectionStart = 0;
			((TextBoxBase)txtKnowns[index]).SelectionLength = Strings.Len(txtKnowns[index].Text);
			((Control)txtKnowns[index]).Focus();
		}
	}

	private bool ValidateOthers()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I4
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Invalid comparison between Unknown and I4
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		short num = 0;
		checked
		{
			short num2 = default(short);
			short num3;
			short num4;
			do
			{
				if (unchecked((int)((CheckBox)((Control)_fraTab2_0).Controls["_chkKnowns1_" + Conversions.ToString((int)num)]).CheckState) == 1)
				{
					num2++;
				}
				num = (short)unchecked(num + 1);
				num3 = num;
				num4 = 4;
			}
			while (num3 <= num4);
			short num5 = Globals_Renamed.arOpType[Globals_Renamed.intOpIndex];
			if (num5 == 104)
			{
				if (num2 < 1)
				{
					Interaction.Beep();
					Interaction.MsgBox((object)"Please specify at least one Mass Balance Input Parameter.", (MsgBoxStyle)64, (object)"Required Information Missing");
				}
				else
				{
					if (num2 <= 3)
					{
						goto IL_011f;
					}
					Interaction.Beep();
					Interaction.MsgBox((object)"Please specify a maximum of three Mass Balance Input Parameters.", (MsgBoxStyle)64, (object)"Required Information Missing");
				}
			}
			else if (num2 != 3)
			{
				Interaction.Beep();
				Interaction.MsgBox((object)("Please specify exactly three Mass Balance Input Parameters in the " + fraTab2[(short)0].Text + " group."), (MsgBoxStyle)64, (object)"Required Information Missing");
			}
			else if (!Operators.ConditionalCompareObjectEqual(ValidateChkKnowns(), (object)false, false))
			{
				goto IL_011f;
			}
			goto IL_04c6;
		}
		IL_04c6:
		bool result = default(bool);
		return result;
		IL_011f:
		num = 0;
		while (true)
		{
			if ((int)((CheckBox)((Control)_fraTab2_0).Controls["_chkKnowns1_" + Conversions.ToString((int)num)]).CheckState == 1)
			{
				if (!Versioned.IsNumeric((object)((Control)_fraTab2_0).Controls["_txtKnowns_" + Conversions.ToString((int)num)].Text))
				{
					Interaction.Beep();
					Interaction.MsgBox((object)("Please specify a numeric value for " + ((Control)_fraTab2_0).Controls["_chkKnowns1_" + Conversions.ToString((int)num)].Text + " or uncheck it."), (MsgBoxStyle)64, (object)"Required Information Missing");
					break;
				}
				if ((num == 1) & (0 - (((RadioButton)((Control)_Frame1_0).Controls["_optContOrBatch_" + Conversions.ToString(1)]).Checked ? 1 : 0) == 1))
				{
					if ((Conversions.ToDouble(_txtKnowns_1.Text) < 1.0) | (Conversions.ToDouble(_txtKnowns_1.Text) > 365.0))
					{
						((TextBoxBase)_txtKnowns_1).SelectionStart = 0;
						((TextBoxBase)_txtKnowns_1).SelectionLength = Strings.Len(_txtKnowns_1.Text);
						((Control)_txtKnowns_1).Focus();
						Interaction.Beep();
						Interaction.MsgBox((object)("Please specify a valid value for " + ((ButtonBase)_chkKnowns1_1).Text + ".  This parameter must be between 1 and 365."), (MsgBoxStyle)64, (object)"Required Information Missing");
						break;
					}
				}
				else if (num == 3)
				{
					if ((Conversions.ToDouble(_txtKnowns_3.Text) < 0.0) | (Conversions.ToDouble(_txtKnowns_3.Text) > 1.0))
					{
						((TextBoxBase)_txtKnowns_3).SelectionStart = 0;
						((TextBoxBase)_txtKnowns_3).SelectionLength = Strings.Len(_txtKnowns_3.Text);
						((Control)_txtKnowns_3).Focus();
						Interaction.Beep();
						Interaction.MsgBox((object)("Please specify a valid value for " + ((ButtonBase)_chkKnowns1_3).Text + ".  This parameter must be between zero and one."), (MsgBoxStyle)64, (object)"Required Information Missing");
						break;
					}
				}
				else if (Conversions.ToDouble(((Control)_fraTab2_0).Controls["_txtKnowns_" + Conversions.ToString((int)num)].Text) <= 0.0)
				{
					((TextBoxBase)(TextBox)((Control)_fraTab2_0).Controls["_txtKnowns_" + Conversions.ToString((int)num)]).SelectionStart = 0;
					((TextBoxBase)(TextBox)((Control)_fraTab2_0).Controls["_txtKnowns_" + Conversions.ToString((int)num)]).SelectionLength = Strings.Len(((Control)_fraTab2_0).Controls["_txtKnowns_" + Conversions.ToString((int)num)].Text);
					((Control)_fraTab2_0).Controls["_txtKnowns_" + Conversions.ToString((int)num)].Focus();
					Interaction.Beep();
					Interaction.MsgBox((object)("Please specify a valid value for " + ((Control)_fraTab2_0).Controls["_chkKnowns1_" + Conversions.ToString((int)num)].Text + ".  This parameter must be greater than zero."), (MsgBoxStyle)64, (object)"Required Information Missing");
					break;
				}
			}
			checked
			{
				num = (short)unchecked(num + 1);
				short num6 = num;
				short num4 = 4;
				if (num6 > num4)
				{
					return true;
				}
			}
		}
		goto IL_04c6;
	}

	private void txtOBatch1_Leave(object eventSender, EventArgs eventArgs)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		short index = txtOBatch1.GetIndex((TextBox)eventSender);
		if (!Versioned.IsNumeric((object)txtOBatch1[index].Text))
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Please enter a valid number.", (MsgBoxStyle)64, (object)"Invalid Number");
			((TextBoxBase)txtOBatch1[index]).SelectionStart = 0;
			((TextBoxBase)txtOBatch1[index]).SelectionLength = Strings.Len(txtOBatch1[(short)0].Text);
			((Control)txtOBatch1[index]).Focus();
		}
		else if (index == 0)
		{
			if ((Conversions.ToDouble(txtOBatch1[(short)0].Text) <= 0.0) | (Conversions.ToDouble(txtOBatch1[(short)0].Text) > 8760.0))
			{
				Interaction.Beep();
				Interaction.MsgBox((object)"Please enter a valid HB: Hours per batch. This number must be greater than 0 and less than or equal to 8760, (24x365).", (MsgBoxStyle)64, (object)"Invalid Number");
				((TextBoxBase)txtOBatch1[(short)0]).SelectionStart = 0;
				((TextBoxBase)txtOBatch1[(short)0]).SelectionLength = Strings.Len(txtOBatch1[(short)0].Text);
				((Control)txtOBatch1[(short)0]).Focus();
			}
		}
		else if ((Conversions.ToDouble(txtOBatch1[(short)1].Text) < 1.0) | (Conversions.ToDouble(txtOBatch1[(short)1].Text) > 365.0) | (Strings.InStr(txtOBatch1[(short)1].Text, ".", (CompareMethod)0) > 0))
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Please enter a valid ODmax: Maximum number of operating days. This number must be an integer greater than or equal to one and less than or equal to 365.", (MsgBoxStyle)64, (object)"Invalid Number");
			((TextBoxBase)txtOBatch1[(short)1]).SelectionStart = 0;
			((TextBoxBase)txtOBatch1[(short)1]).SelectionLength = Strings.Len(txtOBatch1[(short)1].Text);
		}
	}

	private void txtOBatch2_TextChanged(object eventSender, EventArgs eventArgs)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		short index = txtOBatch2.GetIndex((TextBox)eventSender);
		bool flag = default(bool);
		if (Strings.Len(txtOBatch2[index].Text) > 0)
		{
			if (Operators.CompareString(txtOBatch2[index].Text, ".", false) == 0)
			{
				return;
			}
			if (!Versioned.IsNumeric((object)txtOBatch2[index].Text))
			{
				flag = true;
			}
		}
		if (flag & !bSettingGroup4Defaults)
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Please enter a valid number", (MsgBoxStyle)64, (object)"Invalid Number");
			((TextBoxBase)txtOBatch2[index]).SelectionStart = 0;
			((TextBoxBase)txtOBatch2[index]).SelectionLength = Strings.Len(txtOBatch2[index].Text);
			((Control)txtOBatch2[index]).Focus();
		}
		else if (index == 1 && Strings.InStr(txtOBatch2[(short)1].Text, ".", (CompareMethod)0) > 0)
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Please enter a valid Ls: Number of processing lines per site. This number must be an integer.", (MsgBoxStyle)64, (object)"Invalid Number");
			((TextBoxBase)txtOBatch2[(short)1]).SelectionStart = 0;
			((TextBoxBase)txtOBatch2[(short)1]).SelectionLength = Strings.Len(txtOBatch2[index].Text);
			((Control)txtOBatch2[(short)1]).Focus();
		}
		else if ((Versioned.IsNumeric((object)txtOBatch2[(short)0].Text) & Versioned.IsNumeric((object)txtOBatch2[(short)1].Text)) && ((Conversions.ToDouble(txtOBatch2[(short)0].Text) > 0.0) & (Conversions.ToDouble(txtOBatch2[(short)1].Text) > 0.0)))
		{
			txtOBatch3.Text = ChemStrX.ShowInSciNot(Conversions.ToDouble(txtOBatch2[(short)0].Text) * Conversions.ToDouble(txtOBatch2[(short)1].Text));
		}
	}

	private void txtOBatch2_Leave(object eventSender, EventArgs eventArgs)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		short index = txtOBatch2.GetIndex((TextBox)eventSender);
		bool flag = default(bool);
		if (Strings.Len(txtOBatch2[index].Text) > 0)
		{
			if (!Versioned.IsNumeric((object)txtOBatch2[index].Text))
			{
				flag = true;
			}
			else if (Conversions.ToDouble(txtOBatch2[index].Text) <= 0.0)
			{
				flag = true;
			}
		}
		if (flag)
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Please enter a valid number.", (MsgBoxStyle)64, (object)null);
			((TextBoxBase)txtOBatch2[index]).SelectionStart = 0;
			((TextBoxBase)txtOBatch2[index]).SelectionLength = Strings.Len(txtOBatch2[index].Text);
			((Control)txtOBatch2[index]).Focus();
		}
		if (index == 2)
		{
			ValODAndODMax();
		}
	}

	private void txtOther_TextChanged(object eventSender, EventArgs eventArgs)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		short index = txtOther.GetIndex((TextBox)eventSender);
	}

	private void SetGroup4Default()
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Invalid comparison between Unknown and I4
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num2 = default(int);
		short num7 = default(short);
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
						if (bFinishing)
						{
							goto end_IL_0001;
						}
						short num3 = (short)(((BaseControlArray)txtOther).Count() - 1);
						short num4 = 0;
						while (true)
						{
							short num5 = num4;
							short num6 = num3;
							if (num5 > num6)
							{
								break;
							}
							if (unchecked((int)((CheckBox)((Control)_fraTab2_1).Controls["_chkOther_" + Conversions.ToString((int)num4)]).CheckState) == 1)
							{
								num7++;
							}
							num4 = (short)unchecked(num4 + 1);
						}
						if (num7 > 0)
						{
							Interaction.Beep();
							Interaction.MsgBox((object)("The modification(s) you made to the Mass Balance Input parameters in " + _fraTab2_1.Text + " are being overlaid with the default values for this operation."), (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
						}
						bSettingGroup4Defaults = true;
						short num8 = Globals_Renamed.arOpType[Globals_Renamed.intOpIndex];
						if (num8 == 2)
						{
							if (((RadioButton)((Control)_Frame1_1).Controls["_optInfOrEff_" + Conversions.ToString(1)]).Checked)
							{
								if ((sYprodFromPrevOp > 0f) & Versioned.IsNumeric((object)_txtKnowns_2.Text))
								{
									_txtOther_0.Text = _txtKnowns_2.Text;
									_txtOther_1.Text = ChemStrX.ShowInSciNot(sYprodFromPrevOp);
									_txtOther_2.Text = ChemStrX.ShowInSciNot(Conversions.ToDouble(_txtOther_0.Text) / Conversions.ToDouble(_txtOther_1.Text));
								}
								else
								{
									_txtOther_0.Text = "0";
									_txtOther_1.Text = "0";
									_txtOther_2.Text = "0";
								}
							}
							else
							{
								_txtOther_0.Text = _txtKnowns_2.Text;
								_txtOther_1.Text = _txtKnowns_3.Text;
								_txtOther_2.Text = _txtKnowns_4.Text;
							}
						}
						else if (num8 == 100)
						{
							_txtOther_1.Text = ChemStrX.ShowInSciNot(sYprodFromPrevOp);
							_txtOther_0.Text = _txtKnowns_2.Text;
							if (Versioned.IsNumeric((object)_txtOther_0.Text) & Versioned.IsNumeric((object)_txtOther_1.Text))
							{
								if (Operators.CompareString(_txtOther_1.Text, "0", false) == 0)
								{
									_txtOther_2.Text = "0";
								}
								else
								{
									_txtOther_2.Text = ChemStrX.ShowInSciNot(Conversions.ToDouble(_txtOther_0.Text) / Conversions.ToDouble(_txtOther_1.Text));
								}
							}
						}
						else if (num8 == 101)
						{
							_txtOther_1.Text = _txtKnowns_3.Text;
							_txtOther_0.Text = _txtKnowns_2.Text;
							if (Versioned.IsNumeric((object)_txtOther_0.Text) & Versioned.IsNumeric((object)_txtOther_1.Text))
							{
								if (Operators.CompareString(_txtOther_1.Text, "0", false) == 0)
								{
									_txtOther_2.Text = "0";
								}
								else
								{
									_txtOther_2.Text = ChemStrX.ShowInSciNot(Conversions.ToDouble(_txtOther_0.Text) / Conversions.ToDouble(_txtOther_1.Text));
								}
							}
						}
						else if (num8 == 102)
						{
							_txtOther_1.Text = Conversions.ToString(sYprodFromPrevOp);
							_txtOther_0.Text = _txtKnowns_2.Text;
							if (Versioned.IsNumeric((object)_txtOther_1.Text) & (Operators.CompareString(_txtOther_1.Text, "0", false) != 0))
							{
								_txtOther_2.Text = ChemStrX.ShowInSciNot(Conversions.ToDouble(_txtOther_0.Text) / Conversions.ToDouble(_txtOther_1.Text));
							}
							else
							{
								_txtOther_2.Text = "0";
							}
						}
						else if (num8 == 103 || num8 == 104)
						{
							_txtOther_1.Text = ChemStrX.ShowInSciNot(_txtKnowns_3.Text);
							_txtOther_0.Text = _txtKnowns_2.Text;
							_txtOther_2.Text = Conversions.ToString(Conversions.ToDouble(_txtOther_0.Text) / Conversions.ToDouble(_txtOther_1.Text));
						}
						else
						{
							_txtOther_0.Text = "0";
							_txtOther_1.Text = "0";
							_txtOther_2.Text = "0";
						}
						_chkOther_0.CheckState = (CheckState)0;
						_chkOther_1.CheckState = (CheckState)0;
						_chkOther_2.CheckState = (CheckState)0;
						bSettingGroup4Defaults = false;
						goto end_IL_0001_2;
					}
					case 1485:
						num = -1;
						switch (num2)
						{
						case 2:
						{
							string Eobject = ((Control)this).Name;
							string Efunction = "SetGroup4Default";
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
					goto IL_0607;
				}
				end_IL_0001_2:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 1485;
				continue;
			}
			break;
			IL_0607:
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

	private void txtOther_Leave(object eventSender, EventArgs eventArgs)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		short index = txtOther.GetIndex((TextBox)eventSender);
		if (Strings.Len(txtOther[index].Text) == 0)
		{
			return;
		}
		bool flag = default(bool);
		if (((TextBoxBase)txtOther[index]).ReadOnly)
		{
			flag = true;
		}
		else if (Versioned.IsNumeric((object)txtOther[index].Text))
		{
			if (index == 1)
			{
				if ((Conversions.ToDouble(txtOther[index].Text) >= 0.0) & (Conversions.ToDouble(txtOther[index].Text) <= 1.0))
				{
					flag = true;
				}
			}
			else if (Conversions.ToDouble(txtOther[index].Text) >= 0.0)
			{
				flag = true;
			}
		}
		if (!flag)
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Please enter a valid number", (MsgBoxStyle)64, (object)"Invalid Parameter");
			((TextBoxBase)txtOther[index]).SelectionStart = 0;
			((TextBoxBase)txtOther[index]).SelectionLength = Strings.Len(txtOther[index].Text);
			((Control)txtOther[index]).Focus();
		}
	}

	private void SetUpTab3()
	{
		bDontDisable = true;
		checked
		{
			if (Globals_Renamed.arOpParms[101, Globals_Renamed.intOpIndex] == 0f)
			{
				if (Globals_Renamed.arOpType[Globals_Renamed.intOpIndex] == 102)
				{
					txtOBatch1[(short)0].Text = Conversions.ToString(8);
				}
				else
				{
					txtOBatch1[(short)0].Text = Conversions.ToString(24);
				}
				txtOBatch1[(short)1].Text = Conversions.ToString(365);
				txtOBatch1[(short)2].Text = _txtKnowns_1.Text;
				txtOBatch2[(short)0].Text = Conversions.ToString(1);
				txtOBatch2[(short)1].Text = Conversions.ToString(1);
				txtOBatch2[(short)2].Text = txtOBatch1[(short)2].Text;
				txtOBatch3.Text = Conversions.ToString(1);
			}
			else
			{
				txtOBatch1[(short)0].Text = Conversions.ToString(Globals_Renamed.arOpParms[101, Globals_Renamed.intOpIndex]);
				txtOBatch1[(short)1].Text = Conversions.ToString(Globals_Renamed.arOpParms[18, Globals_Renamed.intOpIndex]);
				txtOBatch1[(short)2].Text = Conversions.ToString(Globals_Renamed.arOpParms[16, Globals_Renamed.intOpIndex]);
				object obj = new object[3]
				{
					(short)24,
					(short)102,
					(short)2
				};
				short num = 0;
				short num3;
				short num4;
				do
				{
					short num2 = Conversions.ToShort(NewLateBinding.LateIndexGet(obj, new object[1] { num }, (string[])null));
					switch (Globals_Renamed.arOpParmsType[num2, Globals_Renamed.intOpIndex])
					{
					case 2:
						chkOBatch2[num].CheckState = (CheckState)1;
						((Control)chkOBatch2[num]).Tag = "";
						break;
					case 4:
						chkOBatch2[num].CheckState = (CheckState)0;
						((Control)chkOBatch2[num]).Tag = "clicked";
						break;
					default:
						chkOBatch2[num].CheckState = (CheckState)0;
						((Control)chkOBatch2[num]).Tag = "";
						break;
					}
					txtOBatch2[num].Text = Conversions.ToString(Globals_Renamed.arOpParms[num2, Globals_Renamed.intOpIndex]);
					num = (short)unchecked(num + 1);
					num3 = num;
					num4 = 2;
				}
				while (num3 <= num4);
				txtOBatch3.Text = Conversions.ToString(Globals_Renamed.arOpParms[17, Globals_Renamed.intOpIndex]);
			}
			bDontDisable = false;
		}
	}

	private object ValidateChkKnowns()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between Unknown and I4
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Invalid comparison between Unknown and I4
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		if (((int)_chkKnowns1_0.CheckState == 0) & ((int)chkKnowns1[(short)1].CheckState == 0))
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"You must specify at least one Mass Balance Input Parameter in the first pair.", (MsgBoxStyle)64, (object)"Required Information Missing");
		}
		else
		{
			if (!(((int)_chkKnowns1_3.CheckState == 0) & ((int)chkKnowns1[(short)4].CheckState == 0)))
			{
				return true;
			}
			Interaction.Beep();
			Interaction.MsgBox((object)"You must specify at least one Mass Balance Input Parameter in the second pair.", (MsgBoxStyle)64, (object)"Required Information Missing");
		}
		object result = default(object);
		return result;
	}

	private void GetMyPredYprod()
	{
		if (Globals_Renamed.arNoPre[Globals_Renamed.intOpIndex])
		{
			return;
		}
		checked
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
				short num6;
				do
				{
					if (Globals_Renamed.arSubOpID[num5, num2] - 1 == Globals_Renamed.intOpIndex)
					{
						sYprodFromPrevOp = Globals_Renamed.arOpParms[10, num2];
						return;
					}
					num5 = (short)unchecked(num5 + 1);
					num6 = num5;
					num4 = 9;
				}
				while (num6 <= num4);
				num2 = (short)unchecked(num2 + 1);
			}
		}
	}

	private bool ValidateBatchParms()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			short num = (short)(((BaseControlArray)txtOBatch2).Count() - 1);
			short num2 = 0;
			bool result = default(bool);
			while (true)
			{
				short num3 = num2;
				short num4 = num;
				if (num3 > num4)
				{
					break;
				}
				if (!Versioned.IsNumeric((object)txtOBatch2[num2].Text))
				{
					Interaction.Beep();
					Interaction.MsgBox((object)("The " + ((ButtonBase)chkOBatch2[num2]).Text + " is invalid. Please enter a valid, numeric value for this parameter, which is located on the third tab."), (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
					return result;
				}
				num2 = (short)unchecked(num2 + 1);
			}
			return ValODAndODMax();
		}
	}

	private void CalcRest2()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Invalid comparison between Unknown and I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Invalid comparison between Unknown and I4
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0422: Invalid comparison between Unknown and I4
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Invalid comparison between Unknown and I4
		short num = 0;
		checked
		{
			short num2 = (short)(((BaseControlArray)chkOther).Count() - 1);
			short num3 = 0;
			short num6 = default(short);
			while (true)
			{
				short num4 = num3;
				short num5 = num2;
				if (num4 > num5)
				{
					break;
				}
				if (unchecked((int)chkOther[num3].CheckState) == 1)
				{
					num++;
					num6 = num3;
				}
				num3 = (short)unchecked(num3 + 1);
			}
			switch (num)
			{
			case 0:
				cmdCalcDefaults_Click(cmdCalcDefaults, new EventArgs());
				break;
			case 1:
			{
				short num7 = 0;
				short num8 = (short)(((BaseControlArray)chkOther).Count() - 1);
				num3 = 0;
				short num10 = default(short);
				short num11 = default(short);
				while (true)
				{
					short num9 = num3;
					short num5 = num8;
					if (num9 > num5)
					{
						break;
					}
					if (unchecked((int)chkOther[num3].CheckState) == 0)
					{
						if (Conversions.ToBoolean(Operators.AndObject((object)(Operators.CompareString(txtOther[num3].Text, "", false) != 0), Operators.CompareObjectEqual((object)txtOther[num3].Text, ((Control)txtKnowns[(short)(num3 + 2)]).Tag, false))))
						{
							num7++;
							num10 = num3;
						}
						else
						{
							num11 = num3;
						}
					}
					num3 = (short)unchecked(num3 + 1);
				}
				switch (num7)
				{
				case 0:
					if (Globals_Renamed.arOpType[Globals_Renamed.intOpIndex] != 2)
					{
						break;
					}
					switch (num6)
					{
					case 1:
						if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(((Control)_txtKnowns_2).Tag, (object)"", false), Operators.CompareObjectEqual(((Control)_txtKnowns_2).Tag, (object)"0", false))))
						{
							_txtOther_0.Text = _txtKnowns_2.Text;
						}
						else
						{
							_txtOther_0.Text = Conversions.ToString(((Control)_txtKnowns_2).Tag);
						}
						cmdRecalc_Click(cmdRecalc[(short)2], new EventArgs());
						break;
					case 0:
						if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(((Control)_txtKnowns_3).Tag, (object)"", false), Operators.CompareObjectEqual(((Control)_txtKnowns_3).Tag, (object)"0", false))))
						{
							_txtOther_1.Text = _txtKnowns_3.Text;
						}
						else
						{
							_txtOther_1.Text = Conversions.ToString(((Control)_txtKnowns_3).Tag);
						}
						cmdRecalc_Click(cmdRecalc[(short)2], new EventArgs());
						break;
					default:
						if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(((Control)_txtKnowns_2).Tag, (object)"", false), Operators.CompareObjectEqual(((Control)_txtKnowns_2).Tag, (object)"0", false))))
						{
							_txtOther_0.Text = _txtKnowns_2.Text;
						}
						else
						{
							_txtOther_0.Text = Conversions.ToString(((Control)_txtKnowns_2).Tag);
						}
						cmdRecalc_Click(cmdRecalc[(short)1], new EventArgs());
						break;
					}
					break;
				case 1:
					txtOther[num10].Text = txtKnowns[(short)(num10 + 2)].Text;
					cmdRecalc_Click(cmdRecalc[num11], new EventArgs());
					break;
				case 2:
				{
					short num12 = (short)(((BaseControlArray)chkOther).Count() - 1);
					num3 = 0;
					while (true)
					{
						short num13 = num3;
						short num14 = num12;
						if (num13 > num14)
						{
							break;
						}
						if (unchecked((int)chkOther[num3].CheckState) == 0)
						{
							txtOther[num3].Text = Conversions.ToString(((Control)txtKnowns[(short)(num3 + 2)]).Tag);
						}
						num3 = (short)unchecked(num3 + 1);
					}
					break;
				}
				}
				break;
			}
			}
			num = 0;
			short num15 = (short)(((BaseControlArray)chkOBatch2).Count() - 1);
			num3 = 0;
			while (true)
			{
				short num16 = num3;
				short num14 = num15;
				if (num16 > num14)
				{
					break;
				}
				if (unchecked((int)chkOBatch2[num3].CheckState) == 1)
				{
					num++;
				}
				num3 = (short)unchecked(num3 + 1);
			}
			switch (num)
			{
			case 0:
				cmdCalcBatchParms_Click(cmdCalcBatchParms, new EventArgs());
				break;
			case 1:
				UpdateOBatchParms();
				break;
			}
		}
	}

	public void DoCalc104_Seq(ref short iCurrFixVBath, ref short iCurrFixDVRinse)
	{
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
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
					bElecError = false;
					if (Conversions.ToDouble(_txtKnowns_2.Text) > 0.0)
					{
						if ((iCurrFixVBath == 0) & (iCurrFixDVRinse == 0))
						{
							float pADMUchem = Conversions.ToSingle(_txtKnowns_2.Text);
							ref float pNbath = ref sNbath;
							ref float pFreqbath = ref sFreqbath;
							ref float pDbath = ref sDbath;
							ref float pYbath = ref sYbath;
							float pOD = Conversions.ToSingle(_txtKnowns_1.Text);
							sVbath = ChemStrX.Calc_Vbath_SeqA(ref pADMUchem, ref pNbath, ref pFreqbath, ref pDbath, ref pYbath, ref pOD, ref sDrinse, ref sYrinse, ref sRinseE);
							sDVrinse = ChemStrX.Calc_DVrinse_SeqA(ref sVbath, ref sNbath);
						}
						else if ((iCurrFixVBath == 1) & (iCurrFixDVRinse == 0))
						{
							float pOD = Conversions.ToSingle(_txtKnowns_2.Text);
							ref float pVbath = ref sVbath;
							ref float pNbath2 = ref sNbath;
							ref float pFreqbath2 = ref sFreqbath;
							ref float pDbath2 = ref sDbath;
							ref float pYbath2 = ref sYbath;
							float pADMUchem = Conversions.ToSingle(_txtKnowns_1.Text);
							double num3 = ChemStrX.Calc_DVrinse_SeqB(ref pOD, ref pVbath, ref pNbath2, ref pFreqbath2, ref pDbath2, ref pYbath2, ref pADMUchem, ref sDrinse, ref sYrinse, ref sRinseE);
							if (num3 < 0.0)
							{
								string text = "Parameters should be adjusted such that ADMUchem is increased and/or Vbath is decreased.";
								Interaction.MsgBox((object)text, (MsgBoxStyle)64, (object)null);
								sDVrinse = 0f;
								bElecError = true;
							}
							else
							{
								sDVrinse = (float)num3;
							}
						}
						else if ((iCurrFixVBath == 0) & (iCurrFixDVRinse == 1))
						{
							float pOD = Conversions.ToSingle(_txtKnowns_2.Text);
							ref float pDVrinse = ref sDVrinse;
							ref float pDrinse = ref sDrinse;
							ref float pYrinse = ref sYrinse;
							ref float pRinseE = ref sRinseE;
							ref float pNbath3 = ref sNbath;
							ref float pFreqbath3 = ref sFreqbath;
							ref float pDbath3 = ref sDbath;
							ref float pYbath3 = ref sYbath;
							float pADMUchem = Conversions.ToSingle(_txtKnowns_1.Text);
							double num3 = ChemStrX.Calc_Vbath_SeqC(ref pOD, ref pDVrinse, ref pDrinse, ref pYrinse, ref pRinseE, ref pNbath3, ref pFreqbath3, ref pDbath3, ref pYbath3, ref pADMUchem);
							if (num3 < 0.0)
							{
								string text = "Parameters should be adjusted such that ADMUchem is increased and/or DVrinse is decreased.";
								Interaction.MsgBox((object)text, (MsgBoxStyle)64, (object)null);
								sVbath = 0f;
								bElecError = true;
							}
							else
							{
								sVbath = (float)num3;
							}
						}
						else if ((iCurrFixVBath == 1) & (iCurrFixDVRinse == 1))
						{
							float pOD = Conversions.ToSingle(_txtKnowns_2.Text);
							ref float pVbath2 = ref sVbath;
							ref float pNbath4 = ref sNbath;
							ref float pFreqbath4 = ref sFreqbath;
							ref float pDbath4 = ref sDbath;
							ref float pYbath4 = ref sYbath;
							float pADMUchem = Conversions.ToSingle(_txtKnowns_1.Text);
							double num3 = ChemStrX.Calc_Yrinse_SeqD(ref pOD, ref pVbath2, ref pNbath4, ref pFreqbath4, ref pDbath4, ref pYbath4, ref pADMUchem, ref sDVrinse, ref sDrinse, ref sYrinse, ref sRinseE);
							if (Math.Abs(num3) > 0.05)
							{
								string text = "The fixed values of DVrinse and Vbath result in a mass balance discrepancy of greater than 5%.";
								Interaction.MsgBox((object)text, (MsgBoxStyle)64, (object)null);
								_lbl5PctError_0.Text = text;
								bElecError = true;
							}
						}
					}
					else
					{
						sVbath = 0f;
						sDVrinse = 0f;
					}
					goto end_IL_0001;
				case 863:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						string Eobject = ((Control)this).Name;
						string Efunction = "DoCalc104_Seq";
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
				try0001_dispatch = 863;
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

	private bool ValODAndODMax()
	{
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		if (Versioned.IsNumeric((object)txtOBatch2[(short)2].Text) & Versioned.IsNumeric((object)txtOBatch1[(short)1].Text))
		{
			if (!(Conversions.ToSingle(txtOBatch2[(short)2].Text) > Conversions.ToSingle(txtOBatch1[(short)1].Text)))
			{
				return true;
			}
			if (!bODMsgDisplayed)
			{
				bODMsgDisplayed = true;
				Interaction.Beep();
				Interaction.MsgBox((object)("OD, (" + txtOBatch2[(short)2].Text + ") is greater than ODmax, (" + txtOBatch1[(short)1].Text + "). This is invalid.  Please correct this error."), (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
			}
		}
		bool result = default(bool);
		return result;
	}

	private void checkChkKnowns(short index)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Invalid comparison between Unknown and I4
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Invalid comparison between Unknown and I4
		//IL_0638: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0518: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Unknown result type (might be due to invalid IL or missing references)
		//IL_0600: Unknown result type (might be due to invalid IL or missing references)
		if (_0024STATIC_0024checkChkKnowns_002420116_0024PreventRecursion)
		{
			return;
		}
		short num = 0;
		short num2 = default(short);
		checked
		{
			short num3;
			short num4;
			do
			{
				if (unchecked((int)((CheckBox)((Control)_fraTab2_0).Controls["_chkKnowns1_" + Conversions.ToString((int)num)]).CheckState) == 1)
				{
					num2++;
				}
				num = (short)unchecked(num + 1);
				num3 = num;
				num4 = 4;
			}
			while (num3 <= num4);
			if (num2 > 3)
			{
				Interaction.Beep();
				Interaction.MsgBox((object)("It is invalid to select more than three of the parameters in the " + _fraTab2_0.Text + " group for user input. You may only select three of the parameters in this group for user input."), (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
				_0024STATIC_0024checkChkKnowns_002420116_0024PreventRecursion = true;
				_0024STATIC_0024checkChkKnowns_002420116_0024PreventRecursion = false;
			}
		}
		if (((num2 == 3) & (Globals_Renamed.arOpType[Globals_Renamed.intOpIndex] != 104)) && Operators.ConditionalCompareObjectEqual(ValidateChkKnowns(), (object)false, false))
		{
			_0024STATIC_0024checkChkKnowns_002420116_0024PreventRecursion = true;
			((CheckBox)((Control)_fraTab2_0).Controls["_chkKnowns1_" + Conversions.ToString((int)index)]).CheckState = (CheckState)0;
			_0024STATIC_0024checkChkKnowns_002420116_0024PreventRecursion = false;
		}
		if ((int)((CheckBox)((Control)_fraTab2_0).Controls["_chkKnowns1_" + Conversions.ToString((int)index)]).CheckState == 1)
		{
			((TextBoxBase)(TextBox)((Control)_fraTab2_0).Controls["_txtKnowns_" + Conversions.ToString((int)index)]).ReadOnly = false;
			((Control)_fraTab2_0).Controls["_txtKnowns_" + Conversions.ToString((int)index)].BackColor = Color.White;
			switch (Globals_Renamed.arOpType[Support.GetItemData((Control)(object)frmMain.DefInstance._lstSelOps_1, frmMain.DefInstance._lstSelOps_1.SelectedIndex)])
			{
			case 100:
				switch (index)
				{
				case 2:
					((Control)cmdCalcDMxChem).Enabled = ((RadioButton)((Control)_Frame1_0).Controls["_optContOrBatch_" + Conversions.ToString(0)]).Checked;
					break;
				case 4:
					((Control)cmdCalcXmoProd).Enabled = bEnableCmdCalcXmoProd & ((RadioButton)((Control)_Frame1_1).Controls["_optInfOrEff_" + Conversions.ToString(1)]).Checked & ((RadioButton)((Control)_Frame1_0).Controls["_optContOrBatch_" + Conversions.ToString(0)]).Checked;
					break;
				case 3:
					break;
				}
				break;
			case 101:
			{
				short num6 = index;
				if (num6 == 4)
				{
					((Control)cmdCalcXmoProd).Enabled = bEnableCmdCalcXmoProd & ((RadioButton)((Control)_Frame1_1).Controls["_optInfOrEff_" + Conversions.ToString(0)]).Checked & ((RadioButton)((Control)_Frame1_0).Controls["_optContOrBatch_" + Conversions.ToString(0)]).Checked;
				}
				break;
			}
			case 102:
				switch (index)
				{
				case 0:
					((Control)cmdCalcNS).Enabled = bEnableCmdCalcNS & ((RadioButton)((Control)_Frame1_1).Controls["_optInfOrEff_" + Conversions.ToString(1)]).Checked & ((RadioButton)((Control)_Frame1_0).Controls["_optContOrBatch_" + Conversions.ToString(1)]).Checked;
					break;
				case 2:
					((Control)cmdCalcDMxChem).Enabled = ((RadioButton)((Control)_Frame1_0).Controls["_optContOrBatch_" + Conversions.ToString(0)]).Checked;
					break;
				case 3:
					((Control)cmdCalcYprod).Enabled = bEnableCmdCalcYprod & ((RadioButton)((Control)_Frame1_1).Controls["_optInfOrEff_" + Conversions.ToString(1)]).Checked & ((RadioButton)((Control)_Frame1_0).Controls["_optContOrBatch_" + Conversions.ToString(1)]).Checked;
					break;
				case 4:
					((Control)cmdCalcXmoProd).Enabled = bEnableCmdCalcXmoProd & ((RadioButton)((Control)_Frame1_1).Controls["_optInfOrEff_" + Conversions.ToString(1)]).Checked & ((RadioButton)((Control)_Frame1_0).Controls["_optContOrBatch_" + Conversions.ToString(1)]).Checked;
					break;
				case 1:
					break;
				}
				break;
			case 103:
			{
				short num7 = index;
				if (num7 == 2)
				{
					((Control)cmdCalcDMxChem).Enabled = true;
					((TextBoxBase)(TextBox)((Control)_fraTab2_0).Controls["_txtKnowns_" + Conversions.ToString((int)index)]).ReadOnly = true;
					((Control)_fraTab2_0).Controls["_txtKnowns_" + Conversions.ToString((int)index)].BackColor = ((Form)this).BackColor;
				}
				break;
			}
			case 104:
			{
				short num5 = index;
				if (num5 == 2)
				{
					((Control)cmdCalcDMxChem).Enabled = true;
					((TextBoxBase)(TextBox)((Control)_fraTab2_0).Controls["_txtKnowns_" + Conversions.ToString((int)index)]).ReadOnly = true;
					((Control)_fraTab2_0).Controls["_txtKnowns_" + Conversions.ToString((int)index)].BackColor = ((Form)this).BackColor;
				}
				break;
			}
			default:
				if (index == 2)
				{
					((Control)cmdCalcDMxChem).Enabled = ((RadioButton)((Control)_Frame1_0).Controls["_optContOrBatch_" + Conversions.ToString(0)]).Checked;
				}
				break;
			}
		}
		else
		{
			((TextBoxBase)(TextBox)((Control)_fraTab2_0).Controls["_txtKnowns_" + Conversions.ToString((int)index)]).ReadOnly = true;
			((Control)_fraTab2_0).Controls["_txtKnowns_" + Conversions.ToString((int)index)].BackColor = ((Form)this).BackColor;
			switch (index)
			{
			case 0:
				((Control)cmdCalcNS).Enabled = false;
				break;
			case 2:
				((Control)cmdCalcDMxChem).Enabled = false;
				break;
			case 3:
				((Control)cmdCalcYprod).Enabled = false;
				break;
			case 4:
				((Control)cmdCalcXmoProd).Enabled = false;
				break;
			case 1:
				break;
			}
		}
	}

	private void clickCmdRecalc(short index)
	{
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		switch (index)
		{
		case 0:
			if (Versioned.IsNumeric((object)_txtOther_1.Text) & Versioned.IsNumeric((object)_txtOther_2.Text))
			{
				_txtOther_0.Text = Conversions.ToString(Conversions.ToDouble(_txtOther_1.Text) * Conversions.ToDouble(_txtOther_2.Text));
			}
			else
			{
				_txtOther_0.Text = "0";
			}
			break;
		case 1:
			if (!(Versioned.IsNumeric((object)_txtOther_0.Text) & Versioned.IsNumeric((object)_txtOther_2.Text)))
			{
				break;
			}
			if (Conversions.ToDouble(_txtOther_2.Text) == 0.0)
			{
				_txtOther_1.Text = "0";
				break;
			}
			_txtOther_1.Text = ChemStrX.ShowInSciNot(Conversions.ToDouble(_txtOther_0.Text) / Conversions.ToDouble(_txtOther_2.Text));
			if (!((Conversions.ToDouble(_txtOther_1.Text) <= 0.0) | (Conversions.ToDouble(_txtOther_1.Text) > 1.0)))
			{
				break;
			}
			Interaction.Beep();
			Interaction.MsgBox((object)("An invalid amount was calculated for " + ((ButtonBase)_chkOther_1).Text + ". This value must be greater than zero and less than or equal to one. You will not be able to save your Mass Balance Input parameters until this is fixed."), (MsgBoxStyle)64, (object)"Invalid Amount");
			return;
		case 2:
			if (Versioned.IsNumeric((object)_txtOther_0.Text) & Versioned.IsNumeric((object)_txtOther_1.Text))
			{
				if (Conversions.ToDouble(_txtOther_1.Text) == 0.0)
				{
					_txtOther_2.Text = "0";
				}
				else
				{
					_txtOther_2.Text = ChemStrX.ShowInSciNot(Conversions.ToDouble(_txtOther_0.Text) / Conversions.ToDouble(_txtOther_1.Text));
				}
			}
			break;
		}
		if (Globals_Renamed.arOpType[Globals_Renamed.intOpIndex] == 2)
		{
			string text = "\r\n\r\n";
			if (Conversions.ToDouble(Common.MyNullCheck0(_txtOther_0.Text)) != Conversions.ToDouble(Common.MyNullCheck0(_txtKnowns_2.Text)))
			{
				Interaction.Beep();
				Interaction.MsgBox((object)("A discrepancy now exists between " + text + ((ButtonBase)_chkKnowns1_2).Text + text + " and " + text + ((ButtonBase)_chkOther_0).Text + "."), (MsgBoxStyle)64, (object)"Discrepancy Warning");
			}
		}
		((Control)cmdCalcOthers).Enabled = true;
	}

	private void clickCmdBatchRecalc(short index)
	{
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		short num = 0;
		short num2;
		short num3;
		do
		{
			((Control)_fraTab3_1).Controls["_chkOBatch2_" + Conversions.ToString((int)num)].Tag = "";
			checked
			{
				num = (short)unchecked(num + 1);
				num2 = num;
				num3 = 2;
			}
		}
		while (num2 <= num3);
		((Control)_fraTab3_1).Controls["_chkOBatch2_" + Conversions.ToString((int)index)].Tag = "clicked";
		if (Versioned.IsNumeric((object)_txtOBatch2_0.Text) & Versioned.IsNumeric((object)_txtOBatch2_1.Text) & Versioned.IsNumeric((object)_txtOBatch2_2.Text))
		{
			switch (index)
			{
			case 0:
				_txtOBatch2_0.Text = ChemStrX.ShowInSciNot(Conversions.ToDouble(_txtOBatch1_2.Text) / Conversions.ToDouble(_txtOBatch2_2.Text) / Conversions.ToDouble(_txtOBatch2_1.Text));
				break;
			case 1:
			{
				TextBox txtOBatch2_2 = _txtOBatch2_1;
				double pValue = Conversions.ToDouble(_txtOBatch1_2.Text) / Conversions.ToDouble(_txtOBatch2_2.Text) / Conversions.ToDouble(_txtOBatch2_0.Text);
				string sAbbr = "Ls";
				short Index = 1;
				txtOBatch2_2.Text = Conversions.ToString(MyRoundIt(ref pValue, ref sAbbr, ref Index));
				break;
			}
			case 2:
			{
				TextBox txtOBatch2_ = _txtOBatch2_2;
				double pValue = Conversions.ToDouble(_txtOBatch1_2.Text) / Conversions.ToDouble(_txtOBatch2_0.Text) / Conversions.ToDouble(_txtOBatch2_1.Text);
				string sAbbr = "OD";
				short Index = 1;
				txtOBatch2_.Text = Conversions.ToString(MyRoundIt(ref pValue, ref sAbbr, ref Index));
				ValODAndODMax();
				break;
			}
			}
			if (Conversions.ToDouble(_txtOBatch2_0.Text) > 24.0 / Conversions.ToDouble(_txtOBatch1_0.Text))
			{
				Interaction.Beep();
				Interaction.MsgBox((object)("Nbld must be less than or equal to 24 / HB, (" + ChemStrX.ShowInSciNot(24.0 / Conversions.ToDouble(txtOBatch1[(short)0].Text)) + ").  Please correct your parameters."), (MsgBoxStyle)64, (object)"Invalid Parameters");
			}
			else
			{
				ValODAndODMax();
			}
		}
	}

	private void clickOptContorBatch(short index)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		((Control)_Frame1_0).Controls["_optContOrBatch_" + Conversions.ToString(0)].Tag = index;
		if (((RadioButton)((Control)_Frame1_0).Controls["_optContOrBatch_" + Conversions.ToString(1)]).Checked)
		{
			SetUpTab3();
		}
		else if (!bSettingGroup4Defaults)
		{
			_txtKnowns_1.Text = _txtOBatch2_2.Text;
		}
		if (bGssDefaultsWereSet & (Globals_Renamed.arOpType[Globals_Renamed.intOpIndex] >= 100))
		{
			short num = 0;
			short num2;
			short num3;
			do
			{
				((CheckBox)((Control)_fraTab2_0).Controls["_chkKnowns1_" + Conversions.ToString((int)num)]).CheckState = (CheckState)0;
				((Control)_fraTab2_0).Controls["_txtKnowns_" + Conversions.ToString((int)num)].Text = "";
				checked
				{
					num = (short)unchecked(num + 1);
					num2 = num;
					num3 = 4;
				}
			}
			while (num2 <= num3);
			num = 0;
			short num4;
			do
			{
				((CheckBox)((Control)_fraTab2_1).Controls["_chkOther_" + Conversions.ToString((int)num)]).CheckState = (CheckState)0;
				((Control)_fraTab2_1).Controls["_txtOther_" + Conversions.ToString((int)num)].Text = "";
				checked
				{
					num = (short)unchecked(num + 1);
					num4 = num;
					num3 = 2;
				}
			}
			while (num4 <= num3);
		}
	}

	private void clickOptInfOrEff(short index)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		((Control)_Frame1_1).Controls["_optInfOrEff_" + Conversions.ToString(0)].Tag = index;
		if (bGssDefaultsWereSet & (Support.GetItemData((Control)(object)frmMain.DefInstance._lstSelOps_0, (int)Globals_Renamed.intOpIndex) >= 100))
		{
			short num = 0;
			short num2;
			short num3;
			do
			{
				((CheckBox)((Control)_fraTab2_0).Controls["_chkKnowns1_" + Conversions.ToString((int)num)]).CheckState = (CheckState)0;
				((Control)_fraTab2_0).Controls["_txtKnowns_" + Conversions.ToString((int)num)].Text = "";
				checked
				{
					num = (short)unchecked(num + 1);
					num2 = num;
					num3 = 4;
				}
			}
			while (num2 <= num3);
			num = 0;
			short num4;
			do
			{
				((CheckBox)((Control)_fraTab2_1).Controls["_chkOther_" + Conversions.ToString((int)num)]).CheckState = (CheckState)0;
				((Control)_fraTab2_1).Controls["_txtOther_" + Conversions.ToString((int)num)].Text = "";
				checked
				{
					num = (short)unchecked(num + 1);
					num4 = num;
					num3 = 2;
				}
			}
			while (num4 <= num3);
		}
		if (Support.GetItemData((Control)(object)frmMain.DefInstance._lstSelOps_1, (int)Globals_Renamed.intOpIndex) < 100)
		{
			_txtKnowns_3.Text = "";
			DefaultY();
		}
	}

	private void checkChkOther(short index)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Invalid comparison between Unknown and I4
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Invalid comparison between Unknown and I4
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		if (_0024STATIC_0024checkChkOther_002420116_0024PreventRecursion)
		{
			return;
		}
		short num = 0;
		short num2 = default(short);
		checked
		{
			short num3;
			short num4;
			do
			{
				if (unchecked((int)((CheckBox)((Control)_fraTab2_1).Controls["_chkOther_" + Conversions.ToString((int)num)]).CheckState) == 1)
				{
					num2++;
				}
				num = (short)unchecked(num + 1);
				num3 = num;
				num4 = 2;
			}
			while (num3 <= num4);
		}
		if (num2 == 3)
		{
			Interaction.Beep();
			Interaction.MsgBox((object)("You can only update (check) two parameters in the " + _fraTab2_1.Text + " group. Please see the help system for more information."), (MsgBoxStyle)64, (object)"Invalid Operation");
			_0024STATIC_0024checkChkOther_002420116_0024PreventRecursion = true;
			((CheckBox)((Control)_fraTab2_1).Controls["_chkOther_" + Conversions.ToString((int)index)]).CheckState = (CheckState)0;
			_0024STATIC_0024checkChkOther_002420116_0024PreventRecursion = false;
		}
		else if ((int)((CheckBox)((Control)_fraTab2_1).Controls["_chkOther_" + Conversions.ToString((int)index)]).CheckState == 1)
		{
			((TextBoxBase)(TextBox)((Control)_fraTab2_1).Controls["_txtOther_" + Conversions.ToString((int)index)]).ReadOnly = false;
			((Control)_fraTab2_1).Controls["_txtOther_" + Conversions.ToString((int)index)].BackColor = Color.White;
			((Control)_fraTab2_1).Controls["_cmdRecalc_" + Conversions.ToString((int)index)].Enabled = false;
		}
		else
		{
			((TextBoxBase)(TextBox)((Control)_fraTab2_1).Controls["_txtOther_" + Conversions.ToString((int)index)]).ReadOnly = true;
			((Control)_fraTab2_1).Controls["_txtOther_" + Conversions.ToString((int)index)].BackColor = ((Form)this).BackColor;
			((Control)_fraTab2_1).Controls["_cmdRecalc_" + Conversions.ToString((int)index)].Enabled = true;
		}
	}

	private void checkChkOBatch(short index)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Invalid comparison between Unknown and I4
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Invalid comparison between Unknown and I4
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		if (_0024STATIC_0024checkChkOBatch_002420116_0024PreventRecursion)
		{
			return;
		}
		short num = 0;
		short num2 = default(short);
		checked
		{
			short num3;
			short num4;
			do
			{
				if (unchecked((int)((CheckBox)((Control)_fraTab3_1).Controls["_chkOBatch2_" + Conversions.ToString((int)num)]).CheckState) == 1)
				{
					num2++;
				}
				num = (short)unchecked(num + 1);
				num3 = num;
				num4 = 2;
			}
			while (num3 <= num4);
		}
		if (num2 == 3)
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"You can only update (check) two parameters in the second group. Please see the help system for more information.", (MsgBoxStyle)64, (object)"Invalid Operation");
			_0024STATIC_0024checkChkOBatch_002420116_0024PreventRecursion = true;
			((CheckBox)((Control)_fraTab3_1).Controls["_chkOBatch2_" + Conversions.ToString((int)index)]).CheckState = (CheckState)0;
			_0024STATIC_0024checkChkOBatch_002420116_0024PreventRecursion = false;
		}
		else if ((int)((CheckBox)((Control)_fraTab3_1).Controls["_chkOBatch2_" + Conversions.ToString((int)index)]).CheckState == 1)
		{
			((TextBoxBase)(TextBox)((Control)_fraTab3_1).Controls["_txtOBatch2_" + Conversions.ToString((int)index)]).ReadOnly = false;
			((Control)_fraTab3_1).Controls["_txtOBatch2_" + Conversions.ToString((int)index)].BackColor = Color.White;
			((Control)_fraTab3_1).Controls["_cmdBatchRecalc_" + Conversions.ToString((int)index)].Enabled = false;
		}
		else
		{
			((TextBoxBase)(TextBox)((Control)_fraTab3_1).Controls["_txtOBatch2_" + Conversions.ToString((int)index)]).ReadOnly = true;
			((Control)_fraTab3_1).Controls["_txtOBatch2_" + Conversions.ToString((int)index)].BackColor = ((Form)this).BackColor;
			((Control)_fraTab3_1).Controls["_cmdBatchRecalc_" + Conversions.ToString((int)index)].Enabled = true;
		}
	}

	private void DefaultY()
	{
		if (optInfOrEff[(short)0].Checked & (sYprodFromPrevOp > 0f))
		{
			if (!Versioned.IsNumeric((object)_txtKnowns_3.Text))
			{
				_txtKnowns_3.Text = Conversions.ToString(sYprodFromPrevOp);
				bGssDefaultsWereSet = true;
			}
			else if (Conversions.ToDouble(_txtKnowns_3.Text) == 0.0)
			{
				_txtKnowns_3.Text = Conversions.ToString(sYprodFromPrevOp);
				bGssDefaultsWereSet = true;
			}
		}
		else if (sYprodFromPrevOp > 0f)
		{
			if (!Versioned.IsNumeric((object)_txtOther_1.Text))
			{
				_txtOther_1.Text = Conversions.ToString(sYprodFromPrevOp);
				bGssDefaultsWereSet = true;
			}
			else if (Conversions.ToDouble(_txtOther_1.Text) == 0.0)
			{
				_txtOther_1.Text = Conversions.ToString(sYprodFromPrevOp);
				bGssDefaultsWereSet = true;
			}
		}
	}

	private void DoDefaultsGss102()
	{
		bGssDefaultsWereSet = true;
		_chkKnowns1_0.CheckState = (CheckState)1;
		_chkKnowns1_3.CheckState = (CheckState)1;
		_chkKnowns1_4.CheckState = (CheckState)1;
		if ((Globals_Renamed.arOpParms[10, Globals_Renamed.intOpIndex] > sYprodFromPrevOp) & (sYprodFromPrevOp > 0f))
		{
			_txtKnowns_3.Text = Conversions.ToString(sYprodFromPrevOp);
		}
		else
		{
			_txtKnowns_3.Text = Conversions.ToString(Globals_Renamed.arOpParms[10, Globals_Renamed.intOpIndex]);
		}
		_txtKnowns_4.Text = Conversions.ToString(4000);
		COFarOpParms[114, Globals_Renamed.intOpIndex] = 500000f;
		if (MyPvOp == 0.0)
		{
			_txtKnowns_0.Text = Conversions.ToString(0);
		}
		else
		{
			TextBox txtKnowns_ = _txtKnowns_0;
			double pValue = MyPvOp / Conversions.ToDouble(_txtKnowns_3.Text) / (double)COFarOpParms[114, Globals_Renamed.intOpIndex];
			string sAbbr = "";
			short Index = 0;
			txtKnowns_.Text = Conversions.ToString(MyRoundIt(ref pValue, ref sAbbr, ref Index));
			cmdCalcOthers_Click(cmdCalcOthers, new EventArgs());
		}
		short num = 0;
		checked
		{
			short num2;
			short num3;
			do
			{
				COFarGssOptions[num, Globals_Renamed.intOpIndex] = 0;
				COFarGssOther[num, Globals_Renamed.intOpIndex] = "";
				num = (short)unchecked(num + 1);
				num2 = num;
				num3 = 161;
			}
			while (num2 <= num3);
			_txtOther_1.Text = Conversions.ToString(sYprodFromPrevOp);
			_txtOther_0.Text = _txtKnowns_2.Text;
			if (Versioned.IsNumeric((object)_txtOther_1.Text) & (Operators.CompareString(_txtOther_1.Text, "0", false) != 0))
			{
				_txtOther_2.Text = ChemStrX.ShowInSciNot(Conversions.ToDouble(_txtOther_0.Text) / Conversions.ToDouble(_txtOther_1.Text));
			}
		}
	}

	private void DoDefaultsGss101()
	{
		bGssDefaultsWereSet = true;
		chkKnowns1[(short)4].CheckState = (CheckState)1;
		if ((sYprodFromPrevOp > 0f) & Versioned.IsNumeric((object)_txtKnowns_4.Text))
		{
			_txtKnowns_3.Text = Conversions.ToString(sYprodFromPrevOp);
			chkKnowns1[(short)3].CheckState = (CheckState)1;
			_txtKnowns_2.Text = Conversions.ToString(Conversions.ToSingle(_txtKnowns_4.Text) * Conversions.ToSingle(_txtKnowns_3.Text));
			_txtOther_1.Text = _txtKnowns_3.Text;
			_txtOther_0.Text = _txtKnowns_2.Text;
			_txtOther_2.Text = Conversions.ToString(Conversions.ToDouble(_txtOther_0.Text) / Conversions.ToDouble(_txtOther_1.Text));
			if ((MyPvOp > (double)(Conversions.ToSingle(_txtKnowns_2.Text) * 170f)) & (Conversions.ToSingle(_txtKnowns_2.Text) > 0f))
			{
				TextBox txtKnowns_ = _txtKnowns_0;
				double pValue = MyPvOp / (double)Conversions.ToSingle(_txtKnowns_2.Text) / 170.0;
				txtKnowns_.Text = Conversions.ToString(ChemStrX.MyRoundUp(ref pValue));
			}
			else
			{
				_txtKnowns_0.Text = "1";
			}
			_chkKnowns1_0.CheckState = (CheckState)1;
			if (Conversions.ToSingle(_txtKnowns_2.Text) > 0f)
			{
				TextBox txtKnowns_2 = _txtKnowns_1;
				double pValue = MyPvOp / Conversions.ToDouble(_txtKnowns_0.Text) / Conversions.ToDouble(_txtKnowns_2.Text);
				string sAbbr = "OD";
				short Index = 0;
				txtKnowns_2.Text = Conversions.ToString(MyRoundIt(ref pValue, ref sAbbr, ref Index));
			}
			else
			{
				_txtKnowns_1.Text = "0";
			}
		}
	}

	private void DoDefaultsGss100()
	{
		chkKnowns1[(short)4].CheckState = (CheckState)1;
		if (!(sYprodFromPrevOp > 0f))
		{
			return;
		}
		_txtKnowns_3.Text = Conversions.ToString(sYprodFromPrevOp);
		chkKnowns1[(short)3].CheckState = (CheckState)1;
		if (Versioned.IsNumeric((object)_txtKnowns_4.Text) & Versioned.IsNumeric((object)_txtKnowns_3.Text))
		{
			_txtKnowns_2.Text = Conversions.ToString(Conversions.ToSingle(_txtKnowns_4.Text) * Conversions.ToSingle(_txtKnowns_3.Text));
		}
		else
		{
			_txtKnowns_2.Text = "";
		}
		_txtOther_1.Text = ChemStrX.ShowInSciNot(sYprodFromPrevOp);
		_txtOther_0.Text = _txtKnowns_2.Text;
		_txtOther_2.Text = Conversions.ToString(Conversions.ToDouble(_txtOther_0.Text) / Conversions.ToDouble(_txtOther_1.Text));
		if (Versioned.IsNumeric((object)_txtKnowns_2.Text))
		{
			if (MyPvOp > (double)(Conversions.ToSingle(_txtKnowns_2.Text) * 250f))
			{
				TextBox txtKnowns_ = _txtKnowns_0;
				double pValue = MyPvOp / (double)Conversions.ToSingle(_txtKnowns_2.Text) / 250.0;
				txtKnowns_.Text = Conversions.ToString(ChemStrX.MyRoundUp(ref pValue));
			}
			else
			{
				_txtKnowns_0.Text = "1";
			}
		}
		_chkKnowns1_0.CheckState = (CheckState)1;
		if (Versioned.IsNumeric((object)_txtKnowns_0.Text) & Versioned.IsNumeric((object)_txtKnowns_2.Text))
		{
			TextBox txtKnowns_2 = _txtKnowns_1;
			double pValue = MyPvOp / Conversions.ToDouble(_txtKnowns_0.Text) / Conversions.ToDouble(_txtKnowns_2.Text);
			string sAbbr = "OD";
			short Index = 0;
			txtKnowns_2.Text = Conversions.ToString(MyRoundIt(ref pValue, ref sAbbr, ref Index));
		}
	}

	private void DoDefaultsGss103()
	{
		if (!(MyPvOp > 0.0))
		{
			return;
		}
		COFarOpParms[11, Globals_Renamed.intOpIndex] = 1f;
		COFarOpParmsType[11, Globals_Renamed.intOpIndex] = 1;
		COFarOpParms[10, Globals_Renamed.intOpIndex] = COFarOpParms[11, Globals_Renamed.intOpIndex];
		COFarOpParmsType[10, Globals_Renamed.intOpIndex] = 1;
		float[,] cOFarOpParms = COFarOpParms;
		short intOpIndex = Globals_Renamed.intOpIndex;
		short pGSSID = 103;
		short pParmID = 124;
		cOFarOpParms[124, intOpIndex] = ChemStrX.SetGSSParmDefault(ref pGSSID, ref pParmID);
		COFarOpParmsType[124, Globals_Renamed.intOpIndex] = 1;
		float[,] cOFarOpParms2 = COFarOpParms;
		short intOpIndex2 = Globals_Renamed.intOpIndex;
		pParmID = 103;
		pGSSID = 125;
		cOFarOpParms2[125, intOpIndex2] = ChemStrX.SetGSSParmDefault(ref pParmID, ref pGSSID);
		COFarOpParmsType[125, Globals_Renamed.intOpIndex] = 1;
		float[,] cOFarOpParms3 = COFarOpParms;
		short intOpIndex3 = Globals_Renamed.intOpIndex;
		pParmID = 103;
		pGSSID = 126;
		cOFarOpParms3[126, intOpIndex3] = ChemStrX.SetGSSParmDefault(ref pParmID, ref pGSSID);
		COFarOpParmsType[126, Globals_Renamed.intOpIndex] = 1;
		float[,] cOFarOpParms4 = COFarOpParms;
		short intOpIndex4 = Globals_Renamed.intOpIndex;
		pParmID = 103;
		pGSSID = 127;
		cOFarOpParms4[127, intOpIndex4] = ChemStrX.SetGSSParmDefault(ref pParmID, ref pGSSID);
		COFarOpParmsType[127, Globals_Renamed.intOpIndex] = 1;
		float[,] cOFarOpParms5 = COFarOpParms;
		short intOpIndex5 = Globals_Renamed.intOpIndex;
		pParmID = 103;
		pGSSID = 128;
		cOFarOpParms5[128, intOpIndex5] = ChemStrX.SetGSSParmDefault(ref pParmID, ref pGSSID);
		COFarOpParmsType[128, Globals_Renamed.intOpIndex] = 1;
		float[,] cOFarOpParms6 = COFarOpParms;
		short intOpIndex6 = Globals_Renamed.intOpIndex;
		pParmID = 103;
		pGSSID = 129;
		cOFarOpParms6[129, intOpIndex6] = ChemStrX.SetGSSParmDefault(ref pParmID, ref pGSSID);
		COFarOpParmsType[129, Globals_Renamed.intOpIndex] = 1;
		COFarOpParms[35, Globals_Renamed.intOpIndex] = 24f;
		COFarOpParmsType[35, Globals_Renamed.intOpIndex] = 1;
		COFarOpParms[130, Globals_Renamed.intOpIndex] = COFarOpParms[126, Globals_Renamed.intOpIndex] * COFarOpParms[124, Globals_Renamed.intOpIndex] * COFarOpParms[35, Globals_Renamed.intOpIndex] * COFarOpParms[125, Globals_Renamed.intOpIndex] * 60f;
		COFarOpParmsType[130, Globals_Renamed.intOpIndex] = 1;
		COFarOpParms[13, Globals_Renamed.intOpIndex] = (COFarOpParms[127, Globals_Renamed.intOpIndex] + COFarOpParms[128, Globals_Renamed.intOpIndex] + COFarOpParms[129, Globals_Renamed.intOpIndex]) * COFarOpParms[130, Globals_Renamed.intOpIndex];
		COFarOpParmsType[13, Globals_Renamed.intOpIndex] = 1;
		COFarOpParms[12, Globals_Renamed.intOpIndex] = COFarOpParms[13, Globals_Renamed.intOpIndex] / COFarOpParms[10, Globals_Renamed.intOpIndex];
		COFarOpParmsType[12, Globals_Renamed.intOpIndex] = 1;
		COFarOpParms[14, Globals_Renamed.intOpIndex] = COFarOpParms[12, Globals_Renamed.intOpIndex];
		COFarOpParmsType[14, Globals_Renamed.intOpIndex] = 1;
		COFarOpParms[15, Globals_Renamed.intOpIndex] = COFarOpParms[13, Globals_Renamed.intOpIndex];
		COFarOpParmsType[15, Globals_Renamed.intOpIndex] = 1;
		COFarOpParms[2, Globals_Renamed.intOpIndex] = 360f;
		COFarOpParmsType[2, Globals_Renamed.intOpIndex] = 1;
		COFarOpParmsType[1, Globals_Renamed.intOpIndex] = 1;
		if (sYprodFromPrevOp > 0f)
		{
			_txtKnowns_3.Text = Conversions.ToString(sYprodFromPrevOp);
		}
		else
		{
			_txtKnowns_3.Text = Conversions.ToString(COFarOpParms[11, Globals_Renamed.intOpIndex]);
		}
		chkKnowns1[(short)3].CheckState = (CheckState)1;
		_txtKnowns_2.Text = ChemStrX.ShowInSciNot((COFarOpParms[127, Globals_Renamed.intOpIndex] + COFarOpParms[128, Globals_Renamed.intOpIndex] + COFarOpParms[129, Globals_Renamed.intOpIndex]) * COFarOpParms[130, Globals_Renamed.intOpIndex]);
		chkKnowns1[(short)2].CheckState = (CheckState)1;
		if (Versioned.IsNumeric((object)_txtKnowns_2.Text) & Versioned.IsNumeric((object)_txtKnowns_3.Text))
		{
			_txtKnowns_4.Text = ChemStrX.ShowInSciNot(Conversions.ToDouble(_txtKnowns_2.Text) / Conversions.ToDouble(_txtKnowns_3.Text));
		}
		_txtKnowns_1.Text = "360";
		_txtKnowns_0.Text = Conversions.ToString(Globals_Renamed.arOpParms[1, Globals_Renamed.intOpIndex]);
		_txtOther_1.Text = ChemStrX.ShowInSciNot(_txtKnowns_3.Text);
		_txtOther_0.Text = _txtKnowns_2.Text;
		_txtOther_2.Text = Conversions.ToString(Conversions.ToDouble(_txtOther_0.Text) / Conversions.ToDouble(_txtOther_1.Text));
		if (Versioned.IsNumeric((object)_txtKnowns_2.Text))
		{
			if (MyPvOp > (double)Conversions.ToSingle(_txtKnowns_2.Text) * Conversions.ToDouble(_txtKnowns_1.Text))
			{
				TextBox txtKnowns_ = _txtKnowns_0;
				double pValue = MyPvOp / ((double)Conversions.ToSingle(_txtKnowns_2.Text) * Conversions.ToDouble(_txtKnowns_1.Text));
				txtKnowns_.Text = Conversions.ToString(MassBalanceRoundUp(ref pValue));
			}
			else
			{
				_txtKnowns_0.Text = "1";
			}
		}
		_chkKnowns1_0.CheckState = (CheckState)1;
		if (Versioned.IsNumeric((object)_txtKnowns_0.Text) & Versioned.IsNumeric((object)_txtKnowns_2.Text))
		{
			TextBox txtKnowns_2 = _txtKnowns_1;
			double pValue = MyPvOp / Conversions.ToDouble(_txtKnowns_0.Text) / Conversions.ToDouble(_txtKnowns_2.Text);
			string sAbbr = "OD";
			pParmID = 0;
			txtKnowns_2.Text = Conversions.ToString(MyRoundIt(ref pValue, ref sAbbr, ref pParmID));
		}
	}

	private void DoDefaultsGss104()
	{
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
					ProjectData.ClearProjectError();
					num2 = 2;
					if (!(MyPvOp > 0.0))
					{
						goto end_IL_0001;
					}
					COFarOpParms[10, Globals_Renamed.intOpIndex] = sYprodFromPrevOp;
					COFarOpParmsType[10, Globals_Renamed.intOpIndex] = 1;
					float[,] cOFarOpParms = COFarOpParms;
					short intOpIndex = Globals_Renamed.intOpIndex;
					short pGSSID = 104;
					short pParmID = 2;
					cOFarOpParms[2, intOpIndex] = ChemStrX.SetGSSParmDefault2(ref pGSSID, ref pParmID);
					COFarOpParmsType[2, Globals_Renamed.intOpIndex] = 1;
					float[,] cOFarOpParms2 = COFarOpParms;
					short intOpIndex2 = Globals_Renamed.intOpIndex;
					pParmID = 104;
					pGSSID = 131;
					cOFarOpParms2[131, intOpIndex2] = ChemStrX.SetGSSParmDefault(ref pParmID, ref pGSSID);
					COFarOpParmsType[131, Globals_Renamed.intOpIndex] = 1;
					float[,] cOFarOpParms3 = COFarOpParms;
					short intOpIndex3 = Globals_Renamed.intOpIndex;
					pParmID = 104;
					pGSSID = 132;
					cOFarOpParms3[132, intOpIndex3] = ChemStrX.SetGSSParmDefault(ref pParmID, ref pGSSID);
					COFarOpParmsType[132, Globals_Renamed.intOpIndex] = 1;
					float[,] cOFarOpParms4 = COFarOpParms;
					short intOpIndex4 = Globals_Renamed.intOpIndex;
					pParmID = 104;
					pGSSID = 133;
					cOFarOpParms4[133, intOpIndex4] = ChemStrX.SetGSSParmDefault(ref pParmID, ref pGSSID);
					COFarOpParmsType[133, Globals_Renamed.intOpIndex] = 1;
					float[,] cOFarOpParms5 = COFarOpParms;
					short intOpIndex5 = Globals_Renamed.intOpIndex;
					pParmID = 104;
					pGSSID = 134;
					cOFarOpParms5[134, intOpIndex5] = ChemStrX.SetGSSParmDefault(ref pParmID, ref pGSSID);
					COFarOpParmsType[134, Globals_Renamed.intOpIndex] = 1;
					float[,] cOFarOpParms6 = COFarOpParms;
					short intOpIndex6 = Globals_Renamed.intOpIndex;
					pParmID = 104;
					pGSSID = 135;
					cOFarOpParms6[135, intOpIndex6] = ChemStrX.SetGSSParmDefault(ref pParmID, ref pGSSID);
					COFarOpParmsType[135, Globals_Renamed.intOpIndex] = 1;
					float[,] cOFarOpParms7 = COFarOpParms;
					short intOpIndex7 = Globals_Renamed.intOpIndex;
					pParmID = 104;
					pGSSID = 136;
					cOFarOpParms7[136, intOpIndex7] = ChemStrX.SetGSSParmDefault(ref pParmID, ref pGSSID);
					COFarOpParmsType[136, Globals_Renamed.intOpIndex] = 1;
					float[,] cOFarOpParms8 = COFarOpParms;
					short intOpIndex8 = Globals_Renamed.intOpIndex;
					pParmID = 104;
					pGSSID = 137;
					cOFarOpParms8[137, intOpIndex8] = ChemStrX.SetGSSParmDefault(ref pParmID, ref pGSSID);
					COFarOpParmsType[137, Globals_Renamed.intOpIndex] = 1;
					float[,] cOFarOpParms9 = COFarOpParms;
					short intOpIndex9 = Globals_Renamed.intOpIndex;
					pParmID = 104;
					pGSSID = 138;
					cOFarOpParms9[138, intOpIndex9] = ChemStrX.SetGSSParmDefault(ref pParmID, ref pGSSID);
					COFarOpParmsType[138, Globals_Renamed.intOpIndex] = 1;
					float[,] cOFarOpParms10 = COFarOpParms;
					short intOpIndex10 = Globals_Renamed.intOpIndex;
					pParmID = 104;
					pGSSID = 139;
					cOFarOpParms10[139, intOpIndex10] = ChemStrX.SetGSSParmDefault(ref pParmID, ref pGSSID);
					COFarOpParmsType[139, Globals_Renamed.intOpIndex] = 1;
					float[,] cOFarOpParms11 = COFarOpParms;
					short intOpIndex11 = Globals_Renamed.intOpIndex;
					pParmID = 104;
					pGSSID = 139;
					cOFarOpParms11[140, intOpIndex11] = ChemStrX.SetGSSParmDefault(ref pParmID, ref pGSSID);
					COFarOpParmsType[140, Globals_Renamed.intOpIndex] = 1;
					COFarOpParmsType[1, Globals_Renamed.intOpIndex] = 1;
					COFarOpParmsType[14, Globals_Renamed.intOpIndex] = 1;
					COFarOpParmsType[15, Globals_Renamed.intOpIndex] = 1;
					COFarOpParmsType[13, Globals_Renamed.intOpIndex] = 1;
					COFarOpParmsType[12, Globals_Renamed.intOpIndex] = 1;
					COFarOpParmsType[11, Globals_Renamed.intOpIndex] = 1;
					COFarOpParms[13, Globals_Renamed.intOpIndex] = (float)ChemStrX.Calc104_EP1(COFarOpParms[135, Globals_Renamed.intOpIndex], COFarOpParms[136, Globals_Renamed.intOpIndex], COFarOpParms[137, Globals_Renamed.intOpIndex], COFarOpParms[133, Globals_Renamed.intOpIndex], COFarOpParms[131, Globals_Renamed.intOpIndex], COFarOpParms[2, Globals_Renamed.intOpIndex], COFarOpParms[138, Globals_Renamed.intOpIndex], COFarOpParms[134, Globals_Renamed.intOpIndex], COFarOpParms[132, Globals_Renamed.intOpIndex], COFarOpParms[139, Globals_Renamed.intOpIndex]);
					double pValue = ChemStrX.Calc104_EP2(MyPvOp, COFarOpParms[2, Globals_Renamed.intOpIndex], COFarOpParms[13, Globals_Renamed.intOpIndex]);
					if (pValue < 1.0)
					{
						COFarOpParms[1, Globals_Renamed.intOpIndex] = 1f;
						float[,] cOFarOpParms12 = COFarOpParms;
						short intOpIndex12 = Globals_Renamed.intOpIndex;
						double pValue2 = ChemStrX.Calc104_EP2a(Globals_Renamed.arOpPv[Globals_Renamed.intOpIndex], COFarOpParms[1, Globals_Renamed.intOpIndex], COFarOpParms[13, Globals_Renamed.intOpIndex]);
						string Eobject = "";
						pParmID = 1;
						cOFarOpParms12[2, intOpIndex12] = MyRoundIt(ref pValue2, ref Eobject, ref pParmID);
					}
					else
					{
						pValue = DefInstance.MassBalanceRoundUp(ref pValue);
						COFarOpParms[1, Globals_Renamed.intOpIndex] = (float)pValue;
					}
					if (MyPvOp > 0.0)
					{
						COFarOpParms[13, Globals_Renamed.intOpIndex] = Conversions.ToSingle(ChemStrX.ShowInSciNot(ChemStrX.Calc104_EP3(Globals_Renamed.arOpPv[Globals_Renamed.intOpIndex], COFarOpParms[1, Globals_Renamed.intOpIndex], COFarOpParms[2, Globals_Renamed.intOpIndex])));
					}
					else
					{
						COFarOpParms[13, Globals_Renamed.intOpIndex] = 0f;
					}
					if ((Globals_Renamed.intNumOps > 1) & (sYprodFromPrevOp > 0f))
					{
						COFarOpParms[10, Globals_Renamed.intOpIndex] = ChemStrX.Calc104_EP4(Globals_Renamed.intOpIndex, sYprodFromPrevOp);
					}
					else
					{
						COFarOpParms[10, Globals_Renamed.intOpIndex] = 1f;
					}
					COFarOpParms[11, Globals_Renamed.intOpIndex] = COFarOpParms[10, Globals_Renamed.intOpIndex];
					COFarOpParms[12, Globals_Renamed.intOpIndex] = Conversions.ToSingle(ChemStrX.ShowInSciNot(ChemStrX.Calc104_EP5(COFarOpParms[13, Globals_Renamed.intOpIndex], COFarOpParms[10, Globals_Renamed.intOpIndex])));
					COFarOpParms[15, Globals_Renamed.intOpIndex] = COFarOpParms[13, Globals_Renamed.intOpIndex];
					COFarOpParms[14, Globals_Renamed.intOpIndex] = ChemStrX.Calc104_EP7(COFarOpParms[15, Globals_Renamed.intOpIndex], COFarOpParms[11, Globals_Renamed.intOpIndex]);
					_chkKnowns1_2.CheckState = (CheckState)0;
					_txtKnowns_2.Text = ChemStrX.ShowInSciNot(COFarOpParms[13, Globals_Renamed.intOpIndex]);
					_txtKnowns_4.Text = Conversions.ToString(COFarOpParms[12, Globals_Renamed.intOpIndex]);
					_txtKnowns_1.Text = Conversions.ToString(COFarOpParms[2, Globals_Renamed.intOpIndex]);
					_txtKnowns_0.Text = Conversions.ToString(COFarOpParms[1, Globals_Renamed.intOpIndex]);
					_txtKnowns_3.Text = Conversions.ToString(COFarOpParms[11, Globals_Renamed.intOpIndex]);
					_txtOther_1.Text = ChemStrX.ShowInSciNot(_txtKnowns_3.Text);
					_txtOther_0.Text = _txtKnowns_2.Text;
					_txtOther_2.Text = Conversions.ToString(Conversions.ToDouble(_txtOther_0.Text) / Conversions.ToDouble(_txtKnowns_3.Text));
					if (Versioned.IsNumeric((object)_txtKnowns_2.Text))
					{
						if (MyPvOp > (double)Conversions.ToSingle(_txtKnowns_2.Text) * Conversions.ToDouble(_txtKnowns_1.Text))
						{
							TextBox txtKnowns_ = _txtKnowns_0;
							double pValue2 = MyPvOp / ((double)Conversions.ToSingle(_txtKnowns_2.Text) * Conversions.ToDouble(_txtKnowns_1.Text));
							txtKnowns_.Text = Conversions.ToString(ChemStrX.MyRoundUp(ref pValue2));
						}
						else
						{
							_txtKnowns_0.Text = "1";
						}
					}
					iFixYrinse = 1;
					sVbath = COFarOpParms[135, Globals_Renamed.intOpIndex];
					sNbath = COFarOpParms[136, Globals_Renamed.intOpIndex];
					sFreqbath = COFarOpParms[137, Globals_Renamed.intOpIndex];
					sDbath = COFarOpParms[133, Globals_Renamed.intOpIndex];
					sYbath = COFarOpParms[131, Globals_Renamed.intOpIndex];
					sDVrinse = COFarOpParms[138, Globals_Renamed.intOpIndex];
					sDrinse = COFarOpParms[134, Globals_Renamed.intOpIndex];
					sYrinse = COFarOpParms[132, Globals_Renamed.intOpIndex];
					sRinseE = COFarOpParms[139, Globals_Renamed.intOpIndex];
					DoCalc104_Seq(ref iFixVbath, ref iFixDVRinse);
					sYaddtv = Conversions.ToSingle(_txtKnowns_3.Text);
					sDMIrm = Conversions.ToSingle(_txtOther_2.Text);
					sDMIchem = Conversions.ToSingle(_txtOther_0.Text);
					COFarOpParms[135, Globals_Renamed.intOpIndex] = sVbath;
					COFarOpParms[138, Globals_Renamed.intOpIndex] = sDVrinse;
					goto end_IL_0001;
				}
				case 2693:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						string Eobject = ((Control)this).Name;
						string Efunction = "DoDefaultsGss104";
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
				try0001_dispatch = 2693;
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

	private void DoEPCalcs_GSS104(ref object arrEP, [Optional][DefaultParameterValue(false)] ref bool bSkipSeq)
	{
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Invalid comparison between Unknown and I4
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Invalid comparison between Unknown and I4
		//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Invalid comparison between Unknown and I4
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Invalid comparison between Unknown and I4
		//IL_0558: Unknown result type (might be due to invalid IL or missing references)
		//IL_055e: Invalid comparison between Unknown and I4
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bb: Invalid comparison between Unknown and I4
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0704: Invalid comparison between Unknown and I4
		//IL_0418: Unknown result type (might be due to invalid IL or missing references)
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
					ProjectData.ClearProjectError();
					num2 = 2;
					float num3 = Conversions.ToSingle(_txtKnowns_1.Text);
					bool flag = false;
					while (true)
					{
						IL_001d:
						short num4 = checked((short)Information.UBound((Array)arrEP, 1));
						short num5 = 0;
						while (true)
						{
							short num6 = num5;
							short num7 = num4;
							if (num6 <= num7)
							{
								object obj = NewLateBinding.LateIndexGet(arrEP, new object[1] { num5 }, (string[])null);
								if (Operators.ConditionalCompareObjectEqual(obj, (object)1, false))
								{
									_txtKnowns_2.Text = ChemStrX.ShowInSciNot(ChemStrX.Calc104_EP1(sVbath, sNbath, sFreqbath, sDbath, sYbath, Conversions.ToSingle(_txtKnowns_1.Text), sDVrinse, sDrinse, sYrinse, sRinseE));
								}
								else if (Operators.ConditionalCompareObjectEqual(obj, (object)2, false))
								{
									if ((int)_chkKnowns1_0.CheckState == 0)
									{
										_txtKnowns_0.Text = Conversions.ToString(ChemStrX.Calc104_EP2(MyPvOp, Conversions.ToDouble(_txtKnowns_1.Text), Conversions.ToDouble(_txtKnowns_2.Text)));
										TextBox txtKnowns_ = _txtKnowns_0;
										double pValue = Conversions.ToDouble(_txtKnowns_0.Text);
										txtKnowns_.Text = Conversions.ToString(MassBalanceRoundNS(ref pValue));
									}
								}
								else if (Operators.ConditionalCompareObjectEqual(obj, (object)2.2, false))
								{
									if ((int)_chkKnowns1_0.CheckState == 1)
									{
										double pValue2 = ChemStrX.Calc104_EP2a(MyPvOp, Conversions.ToDouble(_txtKnowns_0.Text), Conversions.ToDouble(_txtKnowns_2.Text));
										if (arMyMassBalDisc[1] == 0)
										{
											TextBox txtKnowns_2 = _txtKnowns_1;
											string Eobject = "OD";
											short Index = 1;
											txtKnowns_2.Text = Conversions.ToString(MyRoundIt(ref pValue2, ref Eobject, ref Index));
										}
										else
										{
											TextBox txtKnowns_3 = _txtKnowns_1;
											string Eobject = "";
											short Index = 1;
											txtKnowns_3.Text = Conversions.ToString(MyRoundIt(ref pValue2, ref Eobject, ref Index));
										}
										if (Conversions.ToDouble(_txtKnowns_1.Text) > 365.0)
										{
											if (!((Control)frmMDCalcXmoProd.DefInstance).Visible)
											{
												Interaction.MsgBox((object)"Using these parameters causes a derived Operation Days (OD) greater than 365 days, which is invalid. Please change your parameters and try again.", (MsgBoxStyle)64, (object)null);
												_txtKnowns_1.Text = "";
												bElecError = true;
												bSkipSeq = true;
												break;
											}
											if (!flag)
											{
												Interaction.MsgBox((object)"Using these parameters causes a derived Operation Days (OD) greater than 365 days, which is invalid. OD is being set to 365 days for subsequent calculations.", (MsgBoxStyle)64, (object)null);
											}
											_txtKnowns_1.Text = "365";
											flag = true;
										}
									}
									else if (((ChemStrX.Calc104_EP2(MyPvOp, Conversions.ToDouble(_txtKnowns_1.Text), Conversions.ToDouble(_txtKnowns_2.Text)) != 1.0) & (Conversions.ToDouble(_txtKnowns_0.Text) == 1.0)) && (int)_chkKnowns1_1.CheckState == 0)
									{
										double pValue2 = ChemStrX.Calc104_EP2a(MyPvOp, Conversions.ToDouble(_txtKnowns_0.Text), Conversions.ToDouble(_txtKnowns_2.Text));
										if (arMyMassBalDisc[1] == 0)
										{
											TextBox txtKnowns_4 = _txtKnowns_1;
											string Eobject = "OD";
											short Index = 1;
											txtKnowns_4.Text = Conversions.ToString(MyRoundIt(ref pValue2, ref Eobject, ref Index));
										}
										else
										{
											TextBox txtKnowns_5 = _txtKnowns_1;
											string Eobject = "";
											short Index = 1;
											txtKnowns_5.Text = Conversions.ToString(MyRoundIt(ref pValue2, ref Eobject, ref Index));
										}
										if (Conversions.ToDouble(_txtKnowns_1.Text) > 365.0)
										{
											if (!((Control)frmMDCalcXmoProd.DefInstance).Visible)
											{
												Interaction.MsgBox((object)"Using these parameters causes a derived Operation Days (OD) greater than 365 days, which is invalid. Please change your parameters and try again.", (MsgBoxStyle)64, (object)null);
												_txtKnowns_1.Text = "";
												bElecError = true;
												bSkipSeq = true;
												break;
											}
											if (!flag)
											{
												Interaction.MsgBox((object)"Using these parameters causes a derived Operation Days (OD) greater than 365 days, which is invalid. OD is being set to 365 days for subsequent calculations.", (MsgBoxStyle)64, (object)null);
											}
											_txtKnowns_1.Text = "365";
											flag = true;
										}
									}
								}
								else if (Operators.ConditionalCompareObjectEqual(obj, (object)3, false))
								{
									_txtKnowns_2.Text = ChemStrX.ShowInSciNot(ChemStrX.Calc104_EP3(MyPvOp, Conversions.ToDouble(_txtKnowns_0.Text), Conversions.ToDouble(_txtKnowns_1.Text)));
								}
								else if (Operators.ConditionalCompareObjectEqual(obj, (object)4, false))
								{
									if ((int)_chkOther_1.CheckState == 1)
									{
										_txtKnowns_3.Text = _txtOther_1.Text;
									}
									else
									{
										_txtKnowns_3.Text = Conversions.ToString(ChemStrX.Calc104_EP4(Globals_Renamed.intNumOps, sYprodFromPrevOp));
									}
								}
								else if (Operators.ConditionalCompareObjectEqual(obj, (object)4.2, false))
								{
									if ((int)_chkOther_1.CheckState == 0)
									{
										_txtOther_1.Text = Conversions.ToString(ChemStrX.Calc104_EP4(Globals_Renamed.intNumOps, sYprodFromPrevOp));
									}
								}
								else if (Operators.ConditionalCompareObjectEqual(obj, (object)5, false))
								{
									_txtKnowns_4.Text = ChemStrX.ShowInSciNot(ChemStrX.Calc104_EP5(Conversions.ToDouble(_txtKnowns_2.Text), Conversions.ToDouble(_txtKnowns_3.Text)));
								}
								else if (Operators.ConditionalCompareObjectEqual(obj, (object)5.2, false))
								{
									_txtKnowns_3.Text = ChemStrX.ShowInSciNot(ChemStrX.Calc104_EP5(Conversions.ToDouble(_txtKnowns_2.Text), Conversions.ToDouble(_txtKnowns_4.Text)));
								}
								else if (Operators.ConditionalCompareObjectEqual(obj, (object)5.3, false))
								{
									_txtKnowns_2.Text = ChemStrX.ShowInSciNot(Conversions.ToDouble(_txtKnowns_4.Text) * Conversions.ToDouble(_txtKnowns_3.Text));
								}
								else if (Operators.ConditionalCompareObjectEqual(obj, (object)6, false))
								{
									if ((int)_chkOther_0.CheckState == 0)
									{
										_txtOther_0.Text = _txtKnowns_2.Text;
									}
								}
								else if (Operators.ConditionalCompareObjectEqual(obj, (object)7, false) && (int)_chkOther_2.CheckState == 0)
								{
									if ((Operators.CompareString(Common.MyNullCheck(_txtOther_1.Text), "", false) == 0) | (Operators.CompareString(_txtOther_1.Text, Conversions.ToString(0), false) == 0))
									{
										_txtOther_2.Text = Conversions.ToString(0);
									}
									else
									{
										_txtOther_2.Text = ChemStrX.ShowInSciNot(Conversions.ToDouble(_txtOther_0.Text) / Conversions.ToDouble(_txtOther_1.Text));
									}
								}
								checked
								{
									num5 = (short)unchecked(num5 + 1);
									continue;
								}
							}
							if ((double)num3 == Conversions.ToDouble(_txtKnowns_1.Text))
							{
								break;
							}
							num3 = Conversions.ToSingle(_txtKnowns_1.Text);
							if (!bSkipSeq)
							{
								DoCalc104_Seq(ref iFixVbath, ref iFixDVRinse);
							}
							if (bElecError)
							{
								break;
							}
							_txtKnowns_2.Text = ChemStrX.ShowInSciNot(ChemStrX.Calc104_EP1(sVbath, sNbath, sFreqbath, sDbath, sYbath, Conversions.ToDouble(_txtKnowns_1.Text), sDVrinse, sDrinse, sYrinse, sRinseE));
							goto IL_001d;
						}
						break;
					}
					goto end_IL_0001;
				}
				case 2281:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						string Eobject = ((Control)this).Name;
						string Efunction = "DoEPCalcs_GSS104";
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
			catch (object obj2) when (obj2 is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0001_dispatch = 2281;
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

	private void UpdateOBatchParms()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I4
		short num = 0;
		short num2;
		short num3;
		do
		{
			if (Conversions.ToBoolean(Operators.AndObject((object)((int)((CheckBox)((Control)_fraTab3_1).Controls["_chkOBatch2_" + Conversions.ToString((int)num)]).CheckState == 0), Operators.CompareObjectEqual(((Control)_fraTab3_1).Controls["_chkOBatch2_" + Conversions.ToString((int)num)].Tag, (object)"clicked", false))))
			{
				cmdBatchRecalc_Click(cmdBatchRecalc[num], new EventArgs());
				break;
			}
			checked
			{
				num = (short)unchecked(num + 1);
				num2 = num;
				num3 = 2;
			}
		}
		while (num2 <= num3);
	}

	private void _chkKnowns1_0_CheckStateChanged(object sender, EventArgs e)
	{
		checkChkKnowns(0);
	}

	private void _chkKnowns1_1_CheckStateChanged(object sender, EventArgs e)
	{
		checkChkKnowns(1);
	}

	private void _chkKnowns1_2_CheckStateChanged(object sender, EventArgs e)
	{
		checkChkKnowns(2);
	}

	private void _chkKnowns1_3_CheckStateChanged(object sender, EventArgs e)
	{
		checkChkKnowns(3);
	}

	private void _chkKnowns1_4_CheckStateChanged(object sender, EventArgs e)
	{
		checkChkKnowns(4);
	}

	private void _chkOBatch2_0_CheckStateChanged(object sender, EventArgs e)
	{
		checkChkOBatch(0);
	}

	private void _chkOBatch2_1_CheckStateChanged(object sender, EventArgs e)
	{
		checkChkOBatch(1);
	}

	private void _chkOBatch2_2_CheckStateChanged(object sender, EventArgs e)
	{
		checkChkOBatch(2);
	}

	private void _chkOther_0_CheckStateChanged(object sender, EventArgs e)
	{
		checkChkOther(0);
	}

	private void _chkOther_1_CheckStateChanged(object sender, EventArgs e)
	{
		checkChkOther(1);
	}

	private void _chkOther_2_CheckStateChanged(object sender, EventArgs e)
	{
		checkChkOther(2);
	}

	private void _cmdBatchRecalc_0_Click(object sender, EventArgs e)
	{
		clickCmdBatchRecalc(0);
	}

	private void _cmdBatchRecalc_1_Click(object sender, EventArgs e)
	{
		clickCmdBatchRecalc(1);
	}

	private void _cmdBatchRecalc_2_Click(object sender, EventArgs e)
	{
		clickCmdBatchRecalc(2);
	}

	private void _optContOrBatch_0_CheckedChanged(object sender, EventArgs e)
	{
		if (_optContOrBatch_0.Checked)
		{
			clickOptContorBatch(0);
		}
	}

	private void _optContOrBatch_1_CheckedChanged(object sender, EventArgs e)
	{
		if (_optContOrBatch_1.Checked)
		{
			clickOptContorBatch(1);
		}
	}

	private void _optInfOrEff_0_CheckedChanged(object sender, EventArgs e)
	{
		if (_optInfOrEff_0.Checked)
		{
			clickOptInfOrEff(0);
		}
	}

	private void _optInfOrEff_1_CheckedChanged(object sender, EventArgs e)
	{
		if (_optInfOrEff_1.Checked)
		{
			clickOptInfOrEff(1);
		}
	}

	private void _cmdRecalc_0_Click(object sender, EventArgs e)
	{
		clickCmdRecalc(0);
	}

	private void _cmdRecalc_1_Click(object sender, EventArgs e)
	{
		clickCmdRecalc(1);
	}

	private void _cmdRecalc_2_Click(object sender, EventArgs e)
	{
		clickCmdRecalc(2);
	}
}
