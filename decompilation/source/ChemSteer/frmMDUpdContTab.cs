using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ADODB;
using AxMSComctlLib;
using MSComctlLib;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ChemSteer;

internal class frmMDUpdContTab : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("cmdRestore")]
	private Button _cmdRestore;

	[AccessedThroughProperty("cmdBasis")]
	private Button _cmdBasis;

	[AccessedThroughProperty("CancelButton_Renamed")]
	private Button _CancelButton_Renamed;

	[AccessedThroughProperty("OKButton")]
	private Button _OKButton;

	[AccessedThroughProperty("cmdCalcOthers")]
	private Button _cmdCalcOthers;

	[AccessedThroughProperty("_chkContParms_4")]
	private CheckBox __chkContParms_4;

	[AccessedThroughProperty("txtOHa")]
	private TextBox _txtOHa;

	[AccessedThroughProperty("_chkContParms_3")]
	private CheckBox __chkContParms_3;

	[AccessedThroughProperty("txtR")]
	private TextBox _txtR;

	[AccessedThroughProperty("_chkContParms_2")]
	private CheckBox __chkContParms_2;

	[AccessedThroughProperty("txtNcd")]
	private TextBox _txtNcd;

	[AccessedThroughProperty("_chkContParms_1")]
	private CheckBox __chkContParms_1;

	[AccessedThroughProperty("txtODa")]
	private TextBox _txtODa;

	[AccessedThroughProperty("_chkContParms_0")]
	private CheckBox __chkContParms_0;

	[AccessedThroughProperty("txtNcy")]
	private TextBox _txtNcy;

	[AccessedThroughProperty("lbl5PctError")]
	private Label _lbl5PctError;

	[AccessedThroughProperty("lblOD")]
	private Label _lblOD;

	[AccessedThroughProperty("_Line1_3")]
	private Label __Line1_3;

	[AccessedThroughProperty("_Label1_10")]
	private Label __Label1_10;

	[AccessedThroughProperty("_Line1_2")]
	private Label __Line1_2;

	[AccessedThroughProperty("_Line1_1")]
	private Label __Line1_1;

	[AccessedThroughProperty("_Label1_9")]
	private Label __Label1_9;

	[AccessedThroughProperty("_Line1_0")]
	private Label __Line1_0;

	[AccessedThroughProperty("_Line1_5")]
	private Label __Line1_5;

	[AccessedThroughProperty("_Label1_3")]
	private Label __Label1_3;

	[AccessedThroughProperty("_Line1_12")]
	private Label __Line1_12;

	[AccessedThroughProperty("_Label1_8")]
	private Label __Label1_8;

	[AccessedThroughProperty("_lblSelAct_0")]
	private Label __lblSelAct_0;

	[AccessedThroughProperty("_lblInstructions_1")]
	private Label __lblInstructions_1;

	[AccessedThroughProperty("_fraStep_1")]
	private GroupBox __fraStep_1;

	[AccessedThroughProperty("_optMci_1")]
	private RadioButton __optMci_1;

	[AccessedThroughProperty("_optMci_0")]
	private RadioButton __optMci_0;

	[AccessedThroughProperty("txtMCi")]
	private TextBox _txtMCi;

	[AccessedThroughProperty("txtDi")]
	private TextBox _txtDi;

	[AccessedThroughProperty("txtVc")]
	private TextBox _txtVc;

	[AccessedThroughProperty("txtYi")]
	private TextBox _txtYi;

	[AccessedThroughProperty("txtFc")]
	private TextBox _txtFc;

	[AccessedThroughProperty("lblDrmDprod")]
	private Label _lblDrmDprod;

	[AccessedThroughProperty("lblSumFc")]
	private Label _lblSumFc;

	[AccessedThroughProperty("lblYrmYprod")]
	private Label _lblYrmYprod;

	[AccessedThroughProperty("_lblSelAct_1")]
	private Label __lblSelAct_1;

	[AccessedThroughProperty("_Label1_13")]
	private Label __Label1_13;

	[AccessedThroughProperty("_Label1_12")]
	private Label __Label1_12;

	[AccessedThroughProperty("_Label1_11")]
	private Label __Label1_11;

	[AccessedThroughProperty("_Label1_2")]
	private Label __Label1_2;

	[AccessedThroughProperty("_Label1_1")]
	private Label __Label1_1;

	[AccessedThroughProperty("_Label1_0")]
	private Label __Label1_0;

	[AccessedThroughProperty("_Label1_6")]
	private Label __Label1_6;

	[AccessedThroughProperty("_Label1_5")]
	private Label __Label1_5;

	[AccessedThroughProperty("_lblInstructions_0")]
	private Label __lblInstructions_0;

	[AccessedThroughProperty("_fraStep_0")]
	private GroupBox __fraStep_0;

	[AccessedThroughProperty("tabs")]
	private AxTabStrip _tabs;

	private static frmMDUpdContTab m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	private short step_Renamed;

	private short iContTab;

	private bool bErrorDontLoseFocus;

	private float sngCalcNcyFromTab1;

	private short MyActID;

	[SpecialName]
	private bool _0024STATIC_0024chkContParms_CheckStateChanged_002420211C1271_0024PreventRecursion;

	public virtual Button cmdRestore
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdRestore;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdRestore_Click;
			if (_cmdRestore != null)
			{
				((Control)_cmdRestore).Click -= eventHandler;
			}
			_cmdRestore = value;
			if (_cmdRestore != null)
			{
				((Control)_cmdRestore).Click += eventHandler;
			}
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

	public virtual Button CancelButton_Renamed
	{
		[DebuggerNonUserCode]
		get
		{
			return _CancelButton_Renamed;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = CancelButton_Renamed_Click;
			if (_CancelButton_Renamed != null)
			{
				((Control)_CancelButton_Renamed).Click -= eventHandler;
			}
			_CancelButton_Renamed = value;
			if (_CancelButton_Renamed != null)
			{
				((Control)_CancelButton_Renamed).Click += eventHandler;
			}
		}
	}

	public virtual Button OKButton
	{
		[DebuggerNonUserCode]
		get
		{
			return _OKButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = OKButton_Click;
			if (_OKButton != null)
			{
				((Control)_OKButton).Click -= eventHandler;
			}
			_OKButton = value;
			if (_OKButton != null)
			{
				((Control)_OKButton).Click += eventHandler;
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

	public virtual CheckBox _chkContParms_4
	{
		[DebuggerNonUserCode]
		get
		{
			return __chkContParms_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = chkContParms_CheckStateChanged;
			if (__chkContParms_4 != null)
			{
				__chkContParms_4.CheckStateChanged -= eventHandler;
			}
			__chkContParms_4 = value;
			if (__chkContParms_4 != null)
			{
				__chkContParms_4.CheckStateChanged += eventHandler;
			}
		}
	}

	public virtual TextBox txtOHa
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtOHa;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtOHa_Leave;
			EventHandler eventHandler2 = txtOHa_Enter;
			if (_txtOHa != null)
			{
				((Control)_txtOHa).Leave -= eventHandler;
				((Control)_txtOHa).Enter -= eventHandler2;
			}
			_txtOHa = value;
			if (_txtOHa != null)
			{
				((Control)_txtOHa).Leave += eventHandler;
				((Control)_txtOHa).Enter += eventHandler2;
			}
		}
	}

	public virtual CheckBox _chkContParms_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __chkContParms_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = chkContParms_CheckStateChanged;
			if (__chkContParms_3 != null)
			{
				__chkContParms_3.CheckStateChanged -= eventHandler;
			}
			__chkContParms_3 = value;
			if (__chkContParms_3 != null)
			{
				__chkContParms_3.CheckStateChanged += eventHandler;
			}
		}
	}

	public virtual TextBox txtR
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtR_Leave;
			if (_txtR != null)
			{
				((Control)_txtR).Leave -= eventHandler;
			}
			_txtR = value;
			if (_txtR != null)
			{
				((Control)_txtR).Leave += eventHandler;
			}
		}
	}

	public virtual CheckBox _chkContParms_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __chkContParms_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = chkContParms_CheckStateChanged;
			if (__chkContParms_2 != null)
			{
				__chkContParms_2.CheckStateChanged -= eventHandler;
			}
			__chkContParms_2 = value;
			if (__chkContParms_2 != null)
			{
				__chkContParms_2.CheckStateChanged += eventHandler;
			}
		}
	}

	public virtual TextBox txtNcd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNcd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtNcd_Leave;
			EventHandler eventHandler2 = txtNcd_Enter;
			if (_txtNcd != null)
			{
				((Control)_txtNcd).Leave -= eventHandler;
				((Control)_txtNcd).Enter -= eventHandler2;
			}
			_txtNcd = value;
			if (_txtNcd != null)
			{
				((Control)_txtNcd).Leave += eventHandler;
				((Control)_txtNcd).Enter += eventHandler2;
			}
		}
	}

	public virtual CheckBox _chkContParms_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __chkContParms_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = chkContParms_CheckStateChanged;
			if (__chkContParms_1 != null)
			{
				__chkContParms_1.CheckStateChanged -= eventHandler;
			}
			__chkContParms_1 = value;
			if (__chkContParms_1 != null)
			{
				__chkContParms_1.CheckStateChanged += eventHandler;
			}
		}
	}

	public virtual TextBox txtODa
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtODa;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtODa_Leave;
			EventHandler eventHandler2 = txtODa_Enter;
			if (_txtODa != null)
			{
				((Control)_txtODa).Leave -= eventHandler;
				((Control)_txtODa).Enter -= eventHandler2;
			}
			_txtODa = value;
			if (_txtODa != null)
			{
				((Control)_txtODa).Leave += eventHandler;
				((Control)_txtODa).Enter += eventHandler2;
			}
		}
	}

	public virtual CheckBox _chkContParms_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __chkContParms_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = chkContParms_CheckStateChanged;
			if (__chkContParms_0 != null)
			{
				__chkContParms_0.CheckStateChanged -= eventHandler;
			}
			__chkContParms_0 = value;
			if (__chkContParms_0 != null)
			{
				__chkContParms_0.CheckStateChanged += eventHandler;
			}
		}
	}

	public virtual TextBox txtNcy
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNcy;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtNcy_Leave;
			EventHandler eventHandler2 = txtNcy_Enter;
			if (_txtNcy != null)
			{
				((Control)_txtNcy).Leave -= eventHandler;
				((Control)_txtNcy).Enter -= eventHandler2;
			}
			_txtNcy = value;
			if (_txtNcy != null)
			{
				((Control)_txtNcy).Leave += eventHandler;
				((Control)_txtNcy).Enter += eventHandler2;
			}
		}
	}

	public virtual Label lbl5PctError
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

	public virtual Label lblOD
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblOD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblOD = value;
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

	public virtual Label _Line1_5
	{
		[DebuggerNonUserCode]
		get
		{
			return __Line1_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Line1_5 = value;
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

	public virtual Label _Line1_12
	{
		[DebuggerNonUserCode]
		get
		{
			return __Line1_12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Line1_12 = value;
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

	public virtual Label _lblSelAct_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblSelAct_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblSelAct_0 = value;
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

	public virtual RadioButton _optMci_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __optMci_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = optMci_CheckedChanged;
			if (__optMci_1 != null)
			{
				__optMci_1.CheckedChanged -= eventHandler;
			}
			__optMci_1 = value;
			if (__optMci_1 != null)
			{
				__optMci_1.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual RadioButton _optMci_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __optMci_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = optMci_CheckedChanged;
			if (__optMci_0 != null)
			{
				__optMci_0.CheckedChanged -= eventHandler;
			}
			__optMci_0 = value;
			if (__optMci_0 != null)
			{
				__optMci_0.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual TextBox txtMCi
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMCi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtMCi_Leave;
			if (_txtMCi != null)
			{
				((Control)_txtMCi).Leave -= eventHandler;
			}
			_txtMCi = value;
			if (_txtMCi != null)
			{
				((Control)_txtMCi).Leave += eventHandler;
			}
		}
	}

	public virtual TextBox txtDi
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtDi_Leave;
			if (_txtDi != null)
			{
				((Control)_txtDi).Leave -= eventHandler;
			}
			_txtDi = value;
			if (_txtDi != null)
			{
				((Control)_txtDi).Leave += eventHandler;
			}
		}
	}

	public virtual TextBox txtVc
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtVc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtvc_Leave;
			if (_txtVc != null)
			{
				((Control)_txtVc).Leave -= eventHandler;
			}
			_txtVc = value;
			if (_txtVc != null)
			{
				((Control)_txtVc).Leave += eventHandler;
			}
		}
	}

	public virtual TextBox txtYi
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtYi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtYi_Leave;
			EventHandler eventHandler2 = txtYi_TextChanged;
			if (_txtYi != null)
			{
				((Control)_txtYi).Leave -= eventHandler;
				((Control)_txtYi).TextChanged -= eventHandler2;
			}
			_txtYi = value;
			if (_txtYi != null)
			{
				((Control)_txtYi).Leave += eventHandler;
				((Control)_txtYi).TextChanged += eventHandler2;
			}
		}
	}

	public virtual TextBox txtFc
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtFc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtFc_Leave;
			if (_txtFc != null)
			{
				((Control)_txtFc).Leave -= eventHandler;
			}
			_txtFc = value;
			if (_txtFc != null)
			{
				((Control)_txtFc).Leave += eventHandler;
			}
		}
	}

	public virtual Label lblDrmDprod
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDrmDprod;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDrmDprod = value;
		}
	}

	public virtual Label lblSumFc
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSumFc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSumFc = value;
		}
	}

	public virtual Label lblYrmYprod
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblYrmYprod;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblYrmYprod = value;
		}
	}

	public virtual Label _lblSelAct_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblSelAct_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblSelAct_1 = value;
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

	public virtual Label _Label1_12
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_12 = value;
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

	public static frmMDUpdContTab DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmMDUpdContTab();
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

	public frmMDUpdContTab()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		((Form)this).FormClosing += new FormClosingEventHandler(frmMDUpdContTab_FormClosing);
		((Form)this).Load += frmMDUpdContTab_Load;
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
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected O, but got Unknown
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected O, but got Unknown
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bc: Expected O, but got Unknown
		//IL_0586: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Expected O, but got Unknown
		//IL_0885: Unknown result type (might be due to invalid IL or missing references)
		//IL_088f: Expected O, but got Unknown
		//IL_0954: Unknown result type (might be due to invalid IL or missing references)
		//IL_095e: Expected O, but got Unknown
		//IL_0a2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a35: Expected O, but got Unknown
		//IL_0b0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b16: Expected O, but got Unknown
		//IL_0bdc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be6: Expected O, but got Unknown
		//IL_0cbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc7: Expected O, but got Unknown
		//IL_0d8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d97: Expected O, but got Unknown
		//IL_0e6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e78: Expected O, but got Unknown
		//IL_0f3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f48: Expected O, but got Unknown
		//IL_101f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1029: Expected O, but got Unknown
		//IL_10ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f9: Expected O, but got Unknown
		//IL_11d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_11da: Expected O, but got Unknown
		//IL_12a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_12aa: Expected O, but got Unknown
		//IL_1374: Unknown result type (might be due to invalid IL or missing references)
		//IL_137e: Expected O, but got Unknown
		//IL_1491: Unknown result type (might be due to invalid IL or missing references)
		//IL_149b: Expected O, but got Unknown
		//IL_1638: Unknown result type (might be due to invalid IL or missing references)
		//IL_1642: Expected O, but got Unknown
		//IL_17df: Unknown result type (might be due to invalid IL or missing references)
		//IL_17e9: Expected O, but got Unknown
		//IL_191e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1928: Expected O, but got Unknown
		//IL_19e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_19ef: Expected O, but got Unknown
		//IL_1aa9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ab3: Expected O, but got Unknown
		//IL_1d28: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d32: Expected O, but got Unknown
		//IL_1dea: Unknown result type (might be due to invalid IL or missing references)
		//IL_1df4: Expected O, but got Unknown
		//IL_1ed7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ee1: Expected O, but got Unknown
		//IL_1fc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fcb: Expected O, but got Unknown
		//IL_209d: Unknown result type (might be due to invalid IL or missing references)
		//IL_20a7: Expected O, but got Unknown
		//IL_216c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2176: Expected O, but got Unknown
		//IL_223b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2245: Expected O, but got Unknown
		//IL_230b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2315: Expected O, but got Unknown
		//IL_23da: Unknown result type (might be due to invalid IL or missing references)
		//IL_23e4: Expected O, but got Unknown
		//IL_249d: Unknown result type (might be due to invalid IL or missing references)
		//IL_24a7: Expected O, but got Unknown
		//IL_255f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2569: Expected O, but got Unknown
		//IL_2614: Unknown result type (might be due to invalid IL or missing references)
		//IL_261e: Expected O, but got Unknown
		//IL_26d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_26e2: Expected O, but got Unknown
		//IL_279f: Unknown result type (might be due to invalid IL or missing references)
		//IL_27a9: Expected O, but got Unknown
		//IL_2866: Unknown result type (might be due to invalid IL or missing references)
		//IL_2870: Expected O, but got Unknown
		//IL_292d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2937: Expected O, but got Unknown
		//IL_29f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_29fe: Expected O, but got Unknown
		//IL_2abb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ac5: Expected O, but got Unknown
		//IL_2b82: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b8c: Expected O, but got Unknown
		//IL_2c49: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c53: Expected O, but got Unknown
		//IL_2d10: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d1a: Expected O, but got Unknown
		//IL_2dd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2de2: Expected O, but got Unknown
		//IL_2ee6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ef0: Expected O, but got Unknown
		//IL_2f05: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f0f: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMDUpdContTab));
		ToolTip1 = new ToolTip(components);
		cmdRestore = new Button();
		cmdBasis = new Button();
		CancelButton_Renamed = new Button();
		OKButton = new Button();
		_fraStep_1 = new GroupBox();
		cmdCalcOthers = new Button();
		_chkContParms_4 = new CheckBox();
		txtOHa = new TextBox();
		_chkContParms_3 = new CheckBox();
		txtR = new TextBox();
		_chkContParms_2 = new CheckBox();
		txtNcd = new TextBox();
		_chkContParms_1 = new CheckBox();
		txtODa = new TextBox();
		_chkContParms_0 = new CheckBox();
		txtNcy = new TextBox();
		lbl5PctError = new Label();
		lblOD = new Label();
		_Line1_3 = new Label();
		_Label1_10 = new Label();
		_Line1_2 = new Label();
		_Line1_1 = new Label();
		_Label1_9 = new Label();
		_Line1_0 = new Label();
		_Line1_5 = new Label();
		_Label1_3 = new Label();
		_Line1_12 = new Label();
		_Label1_8 = new Label();
		_lblSelAct_0 = new Label();
		_lblInstructions_1 = new Label();
		_fraStep_0 = new GroupBox();
		_optMci_1 = new RadioButton();
		_optMci_0 = new RadioButton();
		txtMCi = new TextBox();
		txtDi = new TextBox();
		txtVc = new TextBox();
		txtYi = new TextBox();
		txtFc = new TextBox();
		lblDrmDprod = new Label();
		lblSumFc = new Label();
		lblYrmYprod = new Label();
		_lblSelAct_1 = new Label();
		_Label1_13 = new Label();
		_Label1_12 = new Label();
		_Label1_11 = new Label();
		_Label1_2 = new Label();
		_Label1_1 = new Label();
		_Label1_0 = new Label();
		_Label1_6 = new Label();
		_Label1_5 = new Label();
		_lblInstructions_0 = new Label();
		tabs = new AxTabStrip();
		((Control)_fraStep_1).SuspendLayout();
		((Control)_fraStep_0).SuspendLayout();
		((ISupportInitialize)tabs).BeginInit();
		((Control)this).SuspendLayout();
		((ButtonBase)cmdRestore).BackColor = SystemColors.Control;
		((Control)cmdRestore).Cursor = Cursors.Default;
		((Control)cmdRestore).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdRestore).ForeColor = SystemColors.ControlText;
		Button obj = cmdRestore;
		Point location = new Point(296, 472);
		((Control)obj).Location = location;
		((Control)cmdRestore).Name = "cmdRestore";
		((Control)cmdRestore).RightToLeft = (RightToLeft)0;
		Button obj2 = cmdRestore;
		Size size = new Size(97, 25);
		((Control)obj2).Size = size;
		((Control)cmdRestore).TabIndex = 43;
		((ButtonBase)cmdRestore).Text = "&Restore Defaults";
		((ButtonBase)cmdRestore).UseVisualStyleBackColor = false;
		((ButtonBase)cmdBasis).BackColor = SystemColors.Control;
		((Control)cmdBasis).Cursor = Cursors.Default;
		((Control)cmdBasis).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdBasis).ForeColor = SystemColors.ControlText;
		Button obj3 = cmdBasis;
		location = new Point(192, 472);
		((Control)obj3).Location = location;
		((Control)cmdBasis).Name = "cmdBasis";
		((Control)cmdBasis).RightToLeft = (RightToLeft)0;
		Button obj4 = cmdBasis;
		size = new Size(97, 25);
		((Control)obj4).Size = size;
		((Control)cmdBasis).TabIndex = 42;
		((ButtonBase)cmdBasis).Text = "&Basis";
		((ButtonBase)cmdBasis).UseVisualStyleBackColor = false;
		((ButtonBase)CancelButton_Renamed).BackColor = SystemColors.Control;
		((Control)CancelButton_Renamed).Cursor = Cursors.Default;
		CancelButton_Renamed.DialogResult = (DialogResult)2;
		((Control)CancelButton_Renamed).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)CancelButton_Renamed).ForeColor = SystemColors.ControlText;
		Button cancelButton_Renamed = CancelButton_Renamed;
		location = new Point(400, 472);
		((Control)cancelButton_Renamed).Location = location;
		((Control)CancelButton_Renamed).Name = "CancelButton_Renamed";
		((Control)CancelButton_Renamed).RightToLeft = (RightToLeft)0;
		Button cancelButton_Renamed2 = CancelButton_Renamed;
		size = new Size(97, 25);
		((Control)cancelButton_Renamed2).Size = size;
		((Control)CancelButton_Renamed).TabIndex = 44;
		((ButtonBase)CancelButton_Renamed).Text = "Cancel";
		((ButtonBase)CancelButton_Renamed).UseVisualStyleBackColor = false;
		((ButtonBase)OKButton).BackColor = SystemColors.Control;
		((Control)OKButton).Cursor = Cursors.Default;
		((Control)OKButton).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)OKButton).ForeColor = SystemColors.ControlText;
		Button oKButton = OKButton;
		location = new Point(88, 472);
		((Control)oKButton).Location = location;
		((Control)OKButton).Name = "OKButton";
		((Control)OKButton).RightToLeft = (RightToLeft)0;
		Button oKButton2 = OKButton;
		size = new Size(97, 25);
		((Control)oKButton2).Size = size;
		((Control)OKButton).TabIndex = 41;
		((ButtonBase)OKButton).Text = "OK";
		((ButtonBase)OKButton).UseVisualStyleBackColor = false;
		((Control)_fraStep_1).BackColor = SystemColors.Control;
		((Control)_fraStep_1).Controls.Add((Control)(object)cmdCalcOthers);
		((Control)_fraStep_1).Controls.Add((Control)(object)_chkContParms_4);
		((Control)_fraStep_1).Controls.Add((Control)(object)txtOHa);
		((Control)_fraStep_1).Controls.Add((Control)(object)_chkContParms_3);
		((Control)_fraStep_1).Controls.Add((Control)(object)txtR);
		((Control)_fraStep_1).Controls.Add((Control)(object)_chkContParms_2);
		((Control)_fraStep_1).Controls.Add((Control)(object)txtNcd);
		((Control)_fraStep_1).Controls.Add((Control)(object)_chkContParms_1);
		((Control)_fraStep_1).Controls.Add((Control)(object)txtODa);
		((Control)_fraStep_1).Controls.Add((Control)(object)_chkContParms_0);
		((Control)_fraStep_1).Controls.Add((Control)(object)txtNcy);
		((Control)_fraStep_1).Controls.Add((Control)(object)lbl5PctError);
		((Control)_fraStep_1).Controls.Add((Control)(object)lblOD);
		((Control)_fraStep_1).Controls.Add((Control)(object)_Line1_3);
		((Control)_fraStep_1).Controls.Add((Control)(object)_Label1_10);
		((Control)_fraStep_1).Controls.Add((Control)(object)_Line1_2);
		((Control)_fraStep_1).Controls.Add((Control)(object)_Line1_1);
		((Control)_fraStep_1).Controls.Add((Control)(object)_Label1_9);
		((Control)_fraStep_1).Controls.Add((Control)(object)_Line1_0);
		((Control)_fraStep_1).Controls.Add((Control)(object)_Line1_5);
		((Control)_fraStep_1).Controls.Add((Control)(object)_Label1_3);
		((Control)_fraStep_1).Controls.Add((Control)(object)_Line1_12);
		((Control)_fraStep_1).Controls.Add((Control)(object)_Label1_8);
		((Control)_fraStep_1).Controls.Add((Control)(object)_lblSelAct_0);
		((Control)_fraStep_1).Controls.Add((Control)(object)_lblInstructions_1);
		((Control)_fraStep_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_fraStep_1).ForeColor = SystemColors.ControlText;
		GroupBox fraStep_ = _fraStep_1;
		location = new Point(8, 32);
		((Control)fraStep_).Location = location;
		((Control)_fraStep_1).Name = "_fraStep_1";
		((Control)_fraStep_1).RightToLeft = (RightToLeft)0;
		GroupBox fraStep_2 = _fraStep_1;
		size = new Size(577, 473);
		((Control)fraStep_2).Size = size;
		((Control)_fraStep_1).TabIndex = 23;
		_fraStep_1.TabStop = false;
		((Control)_fraStep_1).Visible = false;
		((ButtonBase)cmdCalcOthers).BackColor = SystemColors.Control;
		((Control)cmdCalcOthers).Cursor = Cursors.Default;
		((Control)cmdCalcOthers).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCalcOthers).ForeColor = SystemColors.ControlText;
		Button obj5 = cmdCalcOthers;
		location = new Point(192, 360);
		((Control)obj5).Location = location;
		((Control)cmdCalcOthers).Name = "cmdCalcOthers";
		((Control)cmdCalcOthers).RightToLeft = (RightToLeft)0;
		Button obj6 = cmdCalcOthers;
		size = new Size(193, 25);
		((Control)obj6).Size = size;
		((Control)cmdCalcOthers).TabIndex = 20;
		((ButtonBase)cmdCalcOthers).Text = "&Calculate remaining two parameters";
		((ButtonBase)cmdCalcOthers).UseVisualStyleBackColor = false;
		((ButtonBase)_chkContParms_4).BackColor = SystemColors.Control;
		((Control)_chkContParms_4).Cursor = Cursors.Default;
		((Control)_chkContParms_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_chkContParms_4).ForeColor = SystemColors.ControlText;
		CheckBox chkContParms_ = _chkContParms_4;
		location = new Point(16, 328);
		((Control)chkContParms_).Location = location;
		((Control)_chkContParms_4).Name = "_chkContParms_4";
		((Control)_chkContParms_4).RightToLeft = (RightToLeft)0;
		CheckBox chkContParms_2 = _chkContParms_4;
		size = new Size(449, 17);
		((Control)chkContParms_2).Size = size;
		((Control)_chkContParms_4).TabIndex = 18;
		((ButtonBase)_chkContParms_4).Text = "OHa (hours/day):";
		((ButtonBase)_chkContParms_4).UseVisualStyleBackColor = false;
		txtOHa.AcceptsReturn = true;
		((TextBoxBase)txtOHa).BackColor = SystemColors.Control;
		((Control)txtOHa).Cursor = Cursors.IBeam;
		((Control)txtOHa).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtOHa).ForeColor = SystemColors.WindowText;
		TextBox obj7 = txtOHa;
		location = new Point(488, 328);
		((Control)obj7).Location = location;
		((TextBoxBase)txtOHa).MaxLength = 0;
		((Control)txtOHa).Name = "txtOHa";
		((TextBoxBase)txtOHa).ReadOnly = true;
		((Control)txtOHa).RightToLeft = (RightToLeft)0;
		TextBox obj8 = txtOHa;
		size = new Size(73, 20);
		((Control)obj8).Size = size;
		((Control)txtOHa).TabIndex = 19;
		((ButtonBase)_chkContParms_3).BackColor = SystemColors.Control;
		((Control)_chkContParms_3).Cursor = Cursors.Default;
		((Control)_chkContParms_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_chkContParms_3).ForeColor = SystemColors.ControlText;
		CheckBox chkContParms_3 = _chkContParms_3;
		location = new Point(16, 304);
		((Control)chkContParms_3).Location = location;
		((Control)_chkContParms_3).Name = "_chkContParms_3";
		((Control)_chkContParms_3).RightToLeft = (RightToLeft)0;
		CheckBox chkContParms_4 = _chkContParms_3;
		size = new Size(449, 17);
		((Control)chkContParms_4).Size = size;
		((Control)_chkContParms_3).TabIndex = 16;
		((ButtonBase)_chkContParms_3).Text = "r (containers/hour): unloading/loading rate";
		((ButtonBase)_chkContParms_3).UseVisualStyleBackColor = false;
		txtR.AcceptsReturn = true;
		((TextBoxBase)txtR).BackColor = SystemColors.Control;
		((Control)txtR).Cursor = Cursors.IBeam;
		((Control)txtR).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtR).ForeColor = SystemColors.WindowText;
		TextBox obj9 = txtR;
		location = new Point(488, 304);
		((Control)obj9).Location = location;
		((TextBoxBase)txtR).MaxLength = 0;
		((Control)txtR).Name = "txtR";
		((TextBoxBase)txtR).ReadOnly = true;
		((Control)txtR).RightToLeft = (RightToLeft)0;
		TextBox obj10 = txtR;
		size = new Size(73, 20);
		((Control)obj10).Size = size;
		((Control)txtR).TabIndex = 17;
		((ButtonBase)_chkContParms_2).BackColor = SystemColors.Control;
		((Control)_chkContParms_2).Cursor = Cursors.Default;
		((Control)_chkContParms_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_chkContParms_2).ForeColor = SystemColors.ControlText;
		CheckBox chkContParms_5 = _chkContParms_2;
		location = new Point(16, 256);
		((Control)chkContParms_5).Location = location;
		((Control)_chkContParms_2).Name = "_chkContParms_2";
		((Control)_chkContParms_2).RightToLeft = (RightToLeft)0;
		CheckBox chkContParms_6 = _chkContParms_2;
		size = new Size(449, 17);
		((Control)chkContParms_6).Size = size;
		((Control)_chkContParms_2).TabIndex = 14;
		((ButtonBase)_chkContParms_2).Text = "Ncd (containers/site-day):";
		((ButtonBase)_chkContParms_2).UseVisualStyleBackColor = false;
		txtNcd.AcceptsReturn = true;
		((TextBoxBase)txtNcd).BackColor = SystemColors.Control;
		((Control)txtNcd).Cursor = Cursors.IBeam;
		((Control)txtNcd).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtNcd).ForeColor = SystemColors.WindowText;
		TextBox obj11 = txtNcd;
		location = new Point(488, 256);
		((Control)obj11).Location = location;
		((TextBoxBase)txtNcd).MaxLength = 0;
		((Control)txtNcd).Name = "txtNcd";
		((TextBoxBase)txtNcd).ReadOnly = true;
		((Control)txtNcd).RightToLeft = (RightToLeft)0;
		TextBox obj12 = txtNcd;
		size = new Size(73, 20);
		((Control)obj12).Size = size;
		((Control)txtNcd).TabIndex = 15;
		((ButtonBase)_chkContParms_1).BackColor = SystemColors.Control;
		((Control)_chkContParms_1).Cursor = Cursors.Default;
		((Control)_chkContParms_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_chkContParms_1).ForeColor = SystemColors.ControlText;
		CheckBox chkContParms_7 = _chkContParms_1;
		location = new Point(16, 208);
		((Control)chkContParms_7).Location = location;
		((Control)_chkContParms_1).Name = "_chkContParms_1";
		((Control)_chkContParms_1).RightToLeft = (RightToLeft)0;
		CheckBox chkContParms_8 = _chkContParms_1;
		size = new Size(449, 17);
		((Control)chkContParms_8).Size = size;
		((Control)_chkContParms_1).TabIndex = 12;
		((ButtonBase)_chkContParms_1).Text = "ODa (days/yr): days/year for the activity";
		((ButtonBase)_chkContParms_1).UseVisualStyleBackColor = false;
		txtODa.AcceptsReturn = true;
		((TextBoxBase)txtODa).BackColor = SystemColors.Control;
		((Control)txtODa).Cursor = Cursors.IBeam;
		((Control)txtODa).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtODa).ForeColor = SystemColors.WindowText;
		TextBox obj13 = txtODa;
		location = new Point(488, 208);
		((Control)obj13).Location = location;
		((TextBoxBase)txtODa).MaxLength = 0;
		((Control)txtODa).Name = "txtODa";
		((TextBoxBase)txtODa).ReadOnly = true;
		((Control)txtODa).RightToLeft = (RightToLeft)0;
		TextBox obj14 = txtODa;
		size = new Size(73, 20);
		((Control)obj14).Size = size;
		((Control)txtODa).TabIndex = 13;
		((ButtonBase)_chkContParms_0).BackColor = SystemColors.Control;
		((Control)_chkContParms_0).Cursor = Cursors.Default;
		((Control)_chkContParms_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_chkContParms_0).ForeColor = SystemColors.ControlText;
		CheckBox chkContParms_9 = _chkContParms_0;
		location = new Point(16, 184);
		((Control)chkContParms_9).Location = location;
		((Control)_chkContParms_0).Name = "_chkContParms_0";
		((Control)_chkContParms_0).RightToLeft = (RightToLeft)0;
		CheckBox chkContParms_10 = _chkContParms_0;
		size = new Size(449, 17);
		((Control)chkContParms_10).Size = size;
		((Control)_chkContParms_0).TabIndex = 10;
		((ButtonBase)_chkContParms_0).Text = "Ncy: Number of containers per site per year (containers/site-year)";
		((ButtonBase)_chkContParms_0).UseVisualStyleBackColor = false;
		txtNcy.AcceptsReturn = true;
		((TextBoxBase)txtNcy).BackColor = SystemColors.Control;
		((Control)txtNcy).Cursor = Cursors.IBeam;
		((Control)txtNcy).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtNcy).ForeColor = SystemColors.WindowText;
		TextBox obj15 = txtNcy;
		location = new Point(488, 184);
		((Control)obj15).Location = location;
		((TextBoxBase)txtNcy).MaxLength = 0;
		((Control)txtNcy).Name = "txtNcy";
		((TextBoxBase)txtNcy).ReadOnly = true;
		((Control)txtNcy).RightToLeft = (RightToLeft)0;
		TextBox obj16 = txtNcy;
		size = new Size(73, 20);
		((Control)obj16).Size = size;
		((Control)txtNcy).TabIndex = 11;
		((Control)lbl5PctError).BackColor = SystemColors.Control;
		((Control)lbl5PctError).Cursor = Cursors.Default;
		((Control)lbl5PctError).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lbl5PctError).ForeColor = SystemColors.ControlText;
		Label obj17 = lbl5PctError;
		location = new Point(16, 400);
		((Control)obj17).Location = location;
		((Control)lbl5PctError).Name = "lbl5PctError";
		((Control)lbl5PctError).RightToLeft = (RightToLeft)0;
		Label obj18 = lbl5PctError;
		size = new Size(545, 33);
		((Control)obj18).Size = size;
		((Control)lbl5PctError).TabIndex = 40;
		lbl5PctError.Text = "x";
		((Control)lblOD).BackColor = SystemColors.Control;
		lblOD.BorderStyle = (BorderStyle)2;
		((Control)lblOD).Cursor = Cursors.Default;
		((Control)lblOD).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblOD).ForeColor = SystemColors.ControlText;
		Label obj19 = lblOD;
		location = new Point(488, 136);
		((Control)obj19).Location = location;
		((Control)lblOD).Name = "lblOD";
		((Control)lblOD).RightToLeft = (RightToLeft)0;
		Label obj20 = lblOD;
		size = new Size(73, 17);
		((Control)obj20).Size = size;
		((Control)lblOD).TabIndex = 2;
		((Control)_Line1_3).BackColor = SystemColors.WindowText;
		Label line1_ = _Line1_3;
		location = new Point(16, 288);
		((Control)line1_).Location = location;
		((Control)_Line1_3).Name = "_Line1_3";
		Label line1_2 = _Line1_3;
		size = new Size(232, 1);
		((Control)line1_2).Size = size;
		((Control)_Line1_3).TabIndex = 41;
		((Control)_Label1_10).BackColor = SystemColors.Control;
		((Control)_Label1_10).Cursor = Cursors.Default;
		((Control)_Label1_10).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_10).ForeColor = SystemColors.ControlText;
		Label label1_ = _Label1_10;
		location = new Point(256, 280);
		((Control)label1_).Location = location;
		((Control)_Label1_10).Name = "_Label1_10";
		((Control)_Label1_10).RightToLeft = (RightToLeft)0;
		Label label1_2 = _Label1_10;
		size = new Size(73, 17);
		((Control)label1_2).Size = size;
		((Control)_Label1_10).TabIndex = 35;
		_Label1_10.Text = "Third Group";
		_Label1_10.TextAlign = (ContentAlignment)2;
		((Control)_Line1_2).BackColor = SystemColors.WindowText;
		Label line1_3 = _Line1_2;
		location = new Point(344, 288);
		((Control)line1_3).Location = location;
		((Control)_Line1_2).Name = "_Line1_2";
		Label line1_4 = _Line1_2;
		size = new Size(216, 1);
		((Control)line1_4).Size = size;
		((Control)_Line1_2).TabIndex = 42;
		((Control)_Line1_1).BackColor = SystemColors.WindowText;
		Label line1_5 = _Line1_1;
		location = new Point(16, 240);
		((Control)line1_5).Location = location;
		((Control)_Line1_1).Name = "_Line1_1";
		Label line1_6 = _Line1_1;
		size = new Size(232, 1);
		((Control)line1_6).Size = size;
		((Control)_Line1_1).TabIndex = 43;
		((Control)_Label1_9).BackColor = SystemColors.Control;
		((Control)_Label1_9).Cursor = Cursors.Default;
		((Control)_Label1_9).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_9).ForeColor = SystemColors.ControlText;
		Label label1_3 = _Label1_9;
		location = new Point(256, 232);
		((Control)label1_3).Location = location;
		((Control)_Label1_9).Name = "_Label1_9";
		((Control)_Label1_9).RightToLeft = (RightToLeft)0;
		Label label1_4 = _Label1_9;
		size = new Size(82, 21);
		((Control)label1_4).Size = size;
		((Control)_Label1_9).TabIndex = 34;
		_Label1_9.Text = "Second Group";
		_Label1_9.TextAlign = (ContentAlignment)2;
		((Control)_Line1_0).BackColor = SystemColors.WindowText;
		Label line1_7 = _Line1_0;
		location = new Point(344, 240);
		((Control)line1_7).Location = location;
		((Control)_Line1_0).Name = "_Line1_0";
		Label line1_8 = _Line1_0;
		size = new Size(216, 1);
		((Control)line1_8).Size = size;
		((Control)_Line1_0).TabIndex = 44;
		((Control)_Line1_5).BackColor = SystemColors.WindowText;
		Label line1_9 = _Line1_5;
		location = new Point(16, 168);
		((Control)line1_9).Location = location;
		((Control)_Line1_5).Name = "_Line1_5";
		Label line1_10 = _Line1_5;
		size = new Size(232, 1);
		((Control)line1_10).Size = size;
		((Control)_Line1_5).TabIndex = 45;
		((Control)_Label1_3).BackColor = SystemColors.Control;
		((Control)_Label1_3).Cursor = Cursors.Default;
		((Control)_Label1_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_3).ForeColor = SystemColors.ControlText;
		Label label1_5 = _Label1_3;
		location = new Point(256, 160);
		((Control)label1_5).Location = location;
		((Control)_Label1_3).Name = "_Label1_3";
		((Control)_Label1_3).RightToLeft = (RightToLeft)0;
		Label label1_6 = _Label1_3;
		size = new Size(73, 17);
		((Control)label1_6).Size = size;
		((Control)_Label1_3).TabIndex = 33;
		_Label1_3.Text = "First Group";
		_Label1_3.TextAlign = (ContentAlignment)2;
		((Control)_Line1_12).BackColor = SystemColors.WindowText;
		Label line1_11 = _Line1_12;
		location = new Point(344, 168);
		((Control)line1_11).Location = location;
		((Control)_Line1_12).Name = "_Line1_12";
		Label line1_12 = _Line1_12;
		size = new Size(216, 1);
		((Control)line1_12).Size = size;
		((Control)_Line1_12).TabIndex = 46;
		((Control)_Label1_8).BackColor = SystemColors.Control;
		((Control)_Label1_8).Cursor = Cursors.Default;
		((Control)_Label1_8).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_8).ForeColor = SystemColors.ControlText;
		Label label1_7 = _Label1_8;
		location = new Point(40, 136);
		((Control)label1_7).Location = location;
		((Control)_Label1_8).Name = "_Label1_8";
		((Control)_Label1_8).RightToLeft = (RightToLeft)0;
		Label label1_8 = _Label1_8;
		size = new Size(425, 17);
		((Control)label1_8).Size = size;
		((Control)_Label1_8).TabIndex = 32;
		_Label1_8.Text = " OD: Number of Operating Days";
		((Control)_lblSelAct_0).BackColor = SystemColors.Control;
		((Control)_lblSelAct_0).Cursor = Cursors.Default;
		((Control)_lblSelAct_0).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_lblSelAct_0).ForeColor = SystemColors.ControlText;
		Label lblSelAct_ = _lblSelAct_0;
		location = new Point(16, 24);
		((Control)lblSelAct_).Location = location;
		((Control)_lblSelAct_0).Name = "_lblSelAct_0";
		((Control)_lblSelAct_0).RightToLeft = (RightToLeft)0;
		Label lblSelAct_2 = _lblSelAct_0;
		size = new Size(545, 17);
		((Control)lblSelAct_2).Size = size;
		((Control)_lblSelAct_0).TabIndex = 26;
		_lblSelAct_0.Text = "s";
		((Control)_lblInstructions_1).BackColor = SystemColors.Control;
		((Control)_lblInstructions_1).Cursor = Cursors.Default;
		((Control)_lblInstructions_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblInstructions_1).ForeColor = SystemColors.ControlText;
		Label lblInstructions_ = _lblInstructions_1;
		location = new Point(16, 56);
		((Control)lblInstructions_).Location = location;
		((Control)_lblInstructions_1).Name = "_lblInstructions_1";
		((Control)_lblInstructions_1).RightToLeft = (RightToLeft)0;
		Label lblInstructions_2 = _lblInstructions_1;
		size = new Size(545, 73);
		((Control)lblInstructions_2).Size = size;
		((Control)_lblInstructions_1).TabIndex = 24;
		_lblInstructions_1.Text = "xxx";
		((Control)_fraStep_0).BackColor = SystemColors.Control;
		((Control)_fraStep_0).Controls.Add((Control)(object)_optMci_1);
		((Control)_fraStep_0).Controls.Add((Control)(object)_optMci_0);
		((Control)_fraStep_0).Controls.Add((Control)(object)txtMCi);
		((Control)_fraStep_0).Controls.Add((Control)(object)txtDi);
		((Control)_fraStep_0).Controls.Add((Control)(object)txtVc);
		((Control)_fraStep_0).Controls.Add((Control)(object)txtYi);
		((Control)_fraStep_0).Controls.Add((Control)(object)txtFc);
		((Control)_fraStep_0).Controls.Add((Control)(object)lblDrmDprod);
		((Control)_fraStep_0).Controls.Add((Control)(object)lblSumFc);
		((Control)_fraStep_0).Controls.Add((Control)(object)lblYrmYprod);
		((Control)_fraStep_0).Controls.Add((Control)(object)_lblSelAct_1);
		((Control)_fraStep_0).Controls.Add((Control)(object)_Label1_13);
		((Control)_fraStep_0).Controls.Add((Control)(object)_Label1_12);
		((Control)_fraStep_0).Controls.Add((Control)(object)_Label1_11);
		((Control)_fraStep_0).Controls.Add((Control)(object)_Label1_2);
		((Control)_fraStep_0).Controls.Add((Control)(object)_Label1_1);
		((Control)_fraStep_0).Controls.Add((Control)(object)_Label1_0);
		((Control)_fraStep_0).Controls.Add((Control)(object)_Label1_6);
		((Control)_fraStep_0).Controls.Add((Control)(object)_Label1_5);
		((Control)_fraStep_0).Controls.Add((Control)(object)_lblInstructions_0);
		((Control)_fraStep_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_fraStep_0).ForeColor = SystemColors.ControlText;
		GroupBox fraStep_3 = _fraStep_0;
		location = new Point(8, 32);
		((Control)fraStep_3).Location = location;
		((Control)_fraStep_0).Name = "_fraStep_0";
		((Control)_fraStep_0).RightToLeft = (RightToLeft)0;
		GroupBox fraStep_4 = _fraStep_0;
		size = new Size(577, 473);
		((Control)fraStep_4).Size = size;
		((Control)_fraStep_0).TabIndex = 21;
		_fraStep_0.TabStop = false;
		((ButtonBase)_optMci_1).BackColor = SystemColors.Control;
		((Control)_optMci_1).Cursor = Cursors.Default;
		((Control)_optMci_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optMci_1).ForeColor = SystemColors.ControlText;
		RadioButton optMci_ = _optMci_1;
		location = new Point(32, 296);
		((Control)optMci_).Location = location;
		((Control)_optMci_1).Name = "_optMci_1";
		((Control)_optMci_1).RightToLeft = (RightToLeft)0;
		RadioButton optMci_2 = _optMci_1;
		size = new Size(417, 17);
		((Control)optMci_2).Size = size;
		((Control)_optMci_1).TabIndex = 7;
		_optMci_1.TabStop = true;
		((ButtonBase)_optMci_1).Text = "Specify MCi directly and derive Vc";
		((ButtonBase)_optMci_1).UseVisualStyleBackColor = false;
		((ButtonBase)_optMci_0).BackColor = SystemColors.Control;
		_optMci_0.Checked = true;
		((Control)_optMci_0).Cursor = Cursors.Default;
		((Control)_optMci_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optMci_0).ForeColor = SystemColors.ControlText;
		RadioButton optMci_3 = _optMci_0;
		location = new Point(32, 248);
		((Control)optMci_3).Location = location;
		((Control)_optMci_0).Name = "_optMci_0";
		((Control)_optMci_0).RightToLeft = (RightToLeft)0;
		RadioButton optMci_4 = _optMci_0;
		size = new Size(97, 17);
		((Control)optMci_4).Size = size;
		((Control)_optMci_0).TabIndex = 5;
		_optMci_0.TabStop = true;
		((ButtonBase)_optMci_0).Text = "Derive MCi";
		((ButtonBase)_optMci_0).UseVisualStyleBackColor = false;
		txtMCi.AcceptsReturn = true;
		((TextBoxBase)txtMCi).BackColor = SystemColors.Control;
		((Control)txtMCi).Cursor = Cursors.IBeam;
		((Control)txtMCi).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtMCi).ForeColor = SystemColors.WindowText;
		TextBox obj21 = txtMCi;
		location = new Point(480, 312);
		((Control)obj21).Location = location;
		((TextBoxBase)txtMCi).MaxLength = 0;
		((Control)txtMCi).Name = "txtMCi";
		((TextBoxBase)txtMCi).ReadOnly = true;
		((Control)txtMCi).RightToLeft = (RightToLeft)0;
		TextBox obj22 = txtMCi;
		size = new Size(73, 20);
		((Control)obj22).Size = size;
		((Control)txtMCi).TabIndex = 8;
		txtDi.AcceptsReturn = true;
		((TextBoxBase)txtDi).BackColor = Color.White;
		((Control)txtDi).Cursor = Cursors.IBeam;
		((Control)txtDi).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtDi).ForeColor = SystemColors.WindowText;
		TextBox obj23 = txtDi;
		location = new Point(480, 224);
		((Control)obj23).Location = location;
		((TextBoxBase)txtDi).MaxLength = 0;
		((Control)txtDi).Name = "txtDi";
		((Control)txtDi).RightToLeft = (RightToLeft)0;
		TextBox obj24 = txtDi;
		size = new Size(73, 20);
		((Control)obj24).Size = size;
		((Control)txtDi).TabIndex = 4;
		txtVc.AcceptsReturn = true;
		((TextBoxBase)txtVc).BackColor = Color.White;
		((Control)txtVc).Cursor = Cursors.IBeam;
		((Control)txtVc).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtVc).ForeColor = SystemColors.WindowText;
		TextBox obj25 = txtVc;
		location = new Point(480, 272);
		((Control)obj25).Location = location;
		((TextBoxBase)txtVc).MaxLength = 0;
		((Control)txtVc).Name = "txtVc";
		((Control)txtVc).RightToLeft = (RightToLeft)0;
		TextBox obj26 = txtVc;
		size = new Size(73, 20);
		((Control)obj26).Size = size;
		((Control)txtVc).TabIndex = 6;
		txtYi.AcceptsReturn = true;
		((TextBoxBase)txtYi).BackColor = Color.White;
		((Control)txtYi).Cursor = Cursors.IBeam;
		((Control)txtYi).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtYi).ForeColor = SystemColors.WindowText;
		TextBox obj27 = txtYi;
		location = new Point(480, 352);
		((Control)obj27).Location = location;
		((TextBoxBase)txtYi).MaxLength = 0;
		((Control)txtYi).Name = "txtYi";
		((Control)txtYi).RightToLeft = (RightToLeft)0;
		TextBox obj28 = txtYi;
		size = new Size(73, 20);
		((Control)obj28).Size = size;
		((Control)txtYi).TabIndex = 9;
		txtFc.AcceptsReturn = true;
		((TextBoxBase)txtFc).BackColor = Color.White;
		((Control)txtFc).Cursor = Cursors.IBeam;
		((Control)txtFc).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtFc).ForeColor = SystemColors.WindowText;
		TextBox obj29 = txtFc;
		location = new Point(480, 200);
		((Control)obj29).Location = location;
		((TextBoxBase)txtFc).MaxLength = 0;
		((Control)txtFc).Name = "txtFc";
		((Control)txtFc).RightToLeft = (RightToLeft)0;
		TextBox obj30 = txtFc;
		size = new Size(73, 20);
		((Control)obj30).Size = size;
		((Control)txtFc).TabIndex = 3;
		((Control)lblDrmDprod).BackColor = SystemColors.Control;
		lblDrmDprod.BorderStyle = (BorderStyle)2;
		((Control)lblDrmDprod).Cursor = Cursors.Default;
		((Control)lblDrmDprod).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblDrmDprod).ForeColor = SystemColors.ControlText;
		Label obj31 = lblDrmDprod;
		location = new Point(480, 176);
		((Control)obj31).Location = location;
		((Control)lblDrmDprod).Name = "lblDrmDprod";
		((Control)lblDrmDprod).RightToLeft = (RightToLeft)0;
		Label obj32 = lblDrmDprod;
		size = new Size(73, 17);
		((Control)obj32).Size = size;
		((Control)lblDrmDprod).TabIndex = 45;
		((Control)lblSumFc).BackColor = SystemColors.Control;
		lblSumFc.BorderStyle = (BorderStyle)2;
		((Control)lblSumFc).Cursor = Cursors.Default;
		((Control)lblSumFc).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblSumFc).ForeColor = SystemColors.ControlText;
		Label obj33 = lblSumFc;
		location = new Point(480, 152);
		((Control)obj33).Location = location;
		((Control)lblSumFc).Name = "lblSumFc";
		((Control)lblSumFc).RightToLeft = (RightToLeft)0;
		Label obj34 = lblSumFc;
		size = new Size(73, 17);
		((Control)obj34).Size = size;
		((Control)lblSumFc).TabIndex = 1;
		((Control)lblYrmYprod).BackColor = SystemColors.Control;
		lblYrmYprod.BorderStyle = (BorderStyle)2;
		((Control)lblYrmYprod).Cursor = Cursors.Default;
		((Control)lblYrmYprod).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblYrmYprod).ForeColor = SystemColors.ControlText;
		Label obj35 = lblYrmYprod;
		location = new Point(480, 128);
		((Control)obj35).Location = location;
		((Control)lblYrmYprod).Name = "lblYrmYprod";
		((Control)lblYrmYprod).RightToLeft = (RightToLeft)0;
		Label obj36 = lblYrmYprod;
		size = new Size(73, 17);
		((Control)obj36).Size = size;
		((Control)lblYrmYprod).TabIndex = 0;
		((Control)_lblSelAct_1).BackColor = SystemColors.Control;
		((Control)_lblSelAct_1).Cursor = Cursors.Default;
		((Control)_lblSelAct_1).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_lblSelAct_1).ForeColor = SystemColors.ControlText;
		Label lblSelAct_3 = _lblSelAct_1;
		location = new Point(16, 24);
		((Control)lblSelAct_3).Location = location;
		((Control)_lblSelAct_1).Name = "_lblSelAct_1";
		((Control)_lblSelAct_1).RightToLeft = (RightToLeft)0;
		Label lblSelAct_4 = _lblSelAct_1;
		size = new Size(545, 17);
		((Control)lblSelAct_4).Size = size;
		((Control)_lblSelAct_1).TabIndex = 39;
		_lblSelAct_1.Text = "s";
		((Control)_Label1_13).BackColor = SystemColors.Control;
		((Control)_Label1_13).Cursor = Cursors.Default;
		((Control)_Label1_13).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_13).ForeColor = SystemColors.ControlText;
		Label label1_9 = _Label1_13;
		location = new Point(80, 320);
		((Control)label1_9).Location = location;
		((Control)_Label1_13).Name = "_Label1_13";
		((Control)_Label1_13).RightToLeft = (RightToLeft)0;
		Label label1_10 = _Label1_13;
		size = new Size(345, 17);
		((Control)label1_10).Size = size;
		((Control)_Label1_13).TabIndex = 38;
		_Label1_13.Text = "MCi: Mass Capacity of container (kg/container)";
		((Control)_Label1_12).BackColor = SystemColors.Control;
		((Control)_Label1_12).Cursor = Cursors.Default;
		((Control)_Label1_12).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_12).ForeColor = SystemColors.ControlText;
		Label label1_11 = _Label1_12;
		location = new Point(32, 224);
		((Control)label1_11).Location = location;
		((Control)_Label1_12).Name = "_Label1_12";
		((Control)_Label1_12).RightToLeft = (RightToLeft)0;
		Label label1_12 = _Label1_12;
		size = new Size(305, 17);
		((Control)label1_12).Size = size;
		((Control)_Label1_12).TabIndex = 37;
		_Label1_12.Text = "Di: Density of i (kg/L)";
		((Control)_Label1_11).BackColor = SystemColors.Control;
		((Control)_Label1_11).Cursor = Cursors.Default;
		((Control)_Label1_11).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_11).ForeColor = SystemColors.ControlText;
		Label label1_13 = _Label1_11;
		location = new Point(72, 272);
		((Control)label1_13).Location = location;
		((Control)_Label1_11).Name = "_Label1_11";
		((Control)_Label1_11).RightToLeft = (RightToLeft)0;
		Label label1_14 = _Label1_11;
		size = new Size(393, 17);
		((Control)label1_14).Size = size;
		((Control)_Label1_11).TabIndex = 36;
		_Label1_11.Text = "Vc: Volume Capacity of container (gal)";
		((Control)_Label1_2).BackColor = SystemColors.Control;
		((Control)_Label1_2).Cursor = Cursors.Default;
		((Control)_Label1_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_2).ForeColor = SystemColors.ControlText;
		Label label1_15 = _Label1_2;
		location = new Point(32, 176);
		((Control)label1_15).Location = location;
		((Control)_Label1_2).Name = "_Label1_2";
		((Control)_Label1_2).RightToLeft = (RightToLeft)0;
		Label label1_16 = _Label1_2;
		size = new Size(425, 17);
		((Control)label1_16).Size = size;
		((Control)_Label1_2).TabIndex = 31;
		_Label1_2.Text = " Drm: Density of Raw Material (kg/L)";
		((Control)_Label1_1).BackColor = SystemColors.Control;
		((Control)_Label1_1).Cursor = Cursors.Default;
		((Control)_Label1_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_1).ForeColor = SystemColors.ControlText;
		Label label1_17 = _Label1_1;
		location = new Point(32, 152);
		((Control)label1_17).Location = location;
		((Control)_Label1_1).Name = "_Label1_1";
		((Control)_Label1_1).RightToLeft = (RightToLeft)0;
		Label label1_18 = _Label1_1;
		size = new Size(425, 17);
		((Control)label1_18).Size = size;
		((Control)_Label1_1).TabIndex = 30;
		_Label1_1.Text = " Sum of fc (unitless)";
		((Control)_Label1_0).BackColor = SystemColors.Control;
		((Control)_Label1_0).Cursor = Cursors.Default;
		((Control)_Label1_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_0).ForeColor = SystemColors.ControlText;
		Label label1_19 = _Label1_0;
		location = new Point(32, 128);
		((Control)label1_19).Location = location;
		((Control)_Label1_0).Name = "_Label1_0";
		((Control)_Label1_0).RightToLeft = (RightToLeft)0;
		Label label1_20 = _Label1_0;
		size = new Size(425, 17);
		((Control)label1_20).Size = size;
		((Control)_Label1_0).TabIndex = 29;
		_Label1_0.Text = " Yrm: Weight Fraction of Chemical in Raw Material (unitless)";
		((Control)_Label1_6).BackColor = SystemColors.Control;
		((Control)_Label1_6).Cursor = Cursors.Default;
		((Control)_Label1_6).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_6).ForeColor = SystemColors.ControlText;
		Label label1_21 = _Label1_6;
		location = new Point(32, 352);
		((Control)label1_21).Location = location;
		((Control)_Label1_6).Name = "_Label1_6";
		((Control)_Label1_6).RightToLeft = (RightToLeft)0;
		Label label1_22 = _Label1_6;
		size = new Size(409, 17);
		((Control)label1_22).Size = size;
		((Control)_Label1_6).TabIndex = 28;
		_Label1_6.Text = " Yi: Weight fraction of chemical in i (unitless)";
		((Control)_Label1_5).BackColor = SystemColors.Control;
		((Control)_Label1_5).Cursor = Cursors.Default;
		((Control)_Label1_5).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_5).ForeColor = SystemColors.ControlText;
		Label label1_23 = _Label1_5;
		location = new Point(32, 200);
		((Control)label1_23).Location = location;
		((Control)_Label1_5).Name = "_Label1_5";
		((Control)_Label1_5).RightToLeft = (RightToLeft)0;
		Label label1_24 = _Label1_5;
		size = new Size(425, 17);
		((Control)label1_24).Size = size;
		((Control)_Label1_5).TabIndex = 27;
		_Label1_5.Text = " fc: Fraction of total volume shipped in this container (unitless)";
		((Control)_lblInstructions_0).BackColor = SystemColors.Control;
		((Control)_lblInstructions_0).Cursor = Cursors.Default;
		((Control)_lblInstructions_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblInstructions_0).ForeColor = SystemColors.ControlText;
		Label lblInstructions_3 = _lblInstructions_0;
		location = new Point(16, 56);
		((Control)lblInstructions_3).Location = location;
		((Control)_lblInstructions_0).Name = "_lblInstructions_0";
		((Control)_lblInstructions_0).RightToLeft = (RightToLeft)0;
		Label lblInstructions_4 = _lblInstructions_0;
		size = new Size(545, 65);
		((Control)lblInstructions_4).Size = size;
		((Control)_lblInstructions_0).TabIndex = 25;
		_lblInstructions_0.Text = "xxx";
		AxTabStrip obj37 = tabs;
		location = new Point(0, 8);
		((Control)obj37).Location = location;
		((Control)tabs).Name = "tabs";
		((AxHost)tabs).OcxState = (State)componentResourceManager.GetObject("tabs.OcxState");
		AxTabStrip obj38 = tabs;
		size = new Size(593, 505);
		((Control)obj38).Size = size;
		((Control)tabs).TabIndex = 22;
		((Form)this).AcceptButton = (IButtonControl)(object)OKButton;
		size = new Size(5, 13);
		((Form)this).AutoScaleBaseSize = size;
		((Form)this).CancelButton = (IButtonControl)(object)CancelButton_Renamed;
		size = new Size(594, 512);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)cmdRestore);
		((Control)this).Controls.Add((Control)(object)cmdBasis);
		((Control)this).Controls.Add((Control)(object)CancelButton_Renamed);
		((Control)this).Controls.Add((Control)(object)OKButton);
		((Control)this).Controls.Add((Control)(object)_fraStep_1);
		((Control)this).Controls.Add((Control)(object)_fraStep_0);
		((Control)this).Controls.Add((Control)(object)tabs);
		((Control)this).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		location = new Point(250, 150);
		((Form)this).Location = location;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmMDUpdContTab";
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Container Parameters";
		((Control)_fraStep_1).ResumeLayout(false);
		((Control)_fraStep_1).PerformLayout();
		((Control)_fraStep_0).ResumeLayout(false);
		((Control)_fraStep_0).PerformLayout();
		((ISupportInitialize)tabs).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void ContDefaultsAndSetResetContParms1()
	{
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
		Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		if (iContTab == 1)
		{
			txtYi.Text = ChemStrX.ShowInSciNot(Globals_Renamed.arOpParms[10, Globals_Renamed.intOpIndex]);
			txtDi.Text = ChemStrX.ShowInSciNot(Globals_Renamed.arOpParms[30, Globals_Renamed.intOpIndex]);
		}
		else
		{
			txtYi.Text = ChemStrX.ShowInSciNot(Globals_Renamed.arOpParms[11, Globals_Renamed.intOpIndex]);
			txtDi.Text = ChemStrX.ShowInSciNot(Globals_Renamed.arOpParms[29, Globals_Renamed.intOpIndex]);
		}
		command.ActiveConnection = Common.MyConn;
		command.CommandText = "pqryGetParmDefault";
		command.CommandType = CommandTypeEnum.adCmdStoredProc;
		command.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, MyActID));
		command.Parameters.Append(command.CreateParameter("pModelID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, 0));
		command.Parameters.Append(command.CreateParameter("pParmID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, (short)19));
		Command command2 = command;
		object RecordsAffected = Missing.Value;
		object Parameters = Missing.Value;
		recordset = command2.Execute(out RecordsAffected, ref Parameters);
		command.Parameters.Delete("pActID");
		command.Parameters.Delete("pModelID");
		command.Parameters.Delete("pParmID");
		if (recordset.EOF)
		{
			txtVc.Text = "";
		}
		else
		{
			txtVc.Text = Conversions.ToString(recordset.Fields[0].Value);
		}
		recordset.Close();
		if (Versioned.IsNumeric((object)txtVc.Text) & Versioned.IsNumeric((object)txtDi.Text))
		{
			txtMCi.Text = ChemStrX.ShowInSciNot(Conversions.ToDouble(txtVc.Text) * Conversions.ToDouble(txtDi.Text) * 3.785);
		}
		else
		{
			txtMCi.Text = "";
		}
		command.ActiveConnection = Common.MyConn;
		command.CommandText = "pqryGetActContTab";
		command.CommandType = CommandTypeEnum.adCmdStoredProc;
		command.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, MyActID));
		Command command3 = command;
		Parameters = Missing.Value;
		RecordsAffected = Missing.Value;
		recordset = command3.Execute(out Parameters, ref RecordsAffected);
		command.Parameters.Delete("pActID");
		short num = Conversions.ToShort(recordset.Fields[1].Value);
		recordset.Close();
		float num2 = 0f;
		short num3 = 0;
		checked
		{
			short num4;
			short num5;
			do
			{
				if (Globals_Renamed.arSelActType[num3, Globals_Renamed.intOpIndex] > 0)
				{
					command.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, Globals_Renamed.arSelActType[num3, Globals_Renamed.intOpIndex]));
					Command command4 = command;
					Parameters = Missing.Value;
					RecordsAffected = Missing.Value;
					recordset = command4.Execute(out Parameters, ref RecordsAffected);
					command.Parameters.Delete("pActID");
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields[0].Value)) & !Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields[1].Value)))
					{
						if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(recordset.Fields[0].Value, (object)(iContTab + 1), false), Operators.CompareObjectEqual(recordset.Fields[1].Value, (object)num, false))))
						{
							num2 += 1f;
						}
						recordset.Close();
					}
				}
				num3 = (short)unchecked(num3 + 1);
				num4 = num3;
				num5 = 24;
			}
			while (num4 <= num5);
			txtFc.Text = Conversions.ToString(1f / num2);
			recordset = null;
			command = null;
		}
	}

	private void ContDefaultsAndSetResetContParms2()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Invalid comparison between Unknown and I4
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Invalid comparison between Unknown and I4
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
		Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		if ((int)_chkContParms_0.CheckState == 0)
		{
			if (Versioned.IsNumeric((object)txtYi.Text) & Versioned.IsNumeric((object)txtMCi.Text))
			{
				float num = (float)((double)Globals_Renamed.arOpParms[1, Globals_Renamed.intOpIndex] * Conversions.ToDouble(txtYi.Text) * Conversions.ToDouble(txtMCi.Text));
				if (num == 0f)
				{
					txtNcy.Text = Conversions.ToString(0);
				}
				else
				{
					txtNcy.Text = ChemStrX.ShowInSciNot(Globals_Renamed.arOpPv[Globals_Renamed.intOpIndex] * Conversions.ToDouble(txtFc.Text) / (double)num);
				}
			}
			else
			{
				txtNcy.Text = Conversions.ToString(0);
			}
		}
		if ((int)_chkContParms_3.CheckState == 0)
		{
			command.ActiveConnection = Common.MyConn;
			command.CommandText = "pqryGetParmDefault";
			command.CommandType = CommandTypeEnum.adCmdStoredProc;
			command.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, MyActID));
			command.Parameters.Append(command.CreateParameter("pModelID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, 0));
			command.Parameters.Append(command.CreateParameter("pParmID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, (short)23));
			Command command2 = command;
			object RecordsAffected = Missing.Value;
			object Parameters = Missing.Value;
			recordset = command2.Execute(out RecordsAffected, ref Parameters);
			command.Parameters.Delete("pActID");
			command.Parameters.Delete("pModelID");
			command.Parameters.Delete("pParmID");
			if (recordset.EOF)
			{
				txtR.Text = "";
			}
			else
			{
				txtR.Text = Conversions.ToString(recordset.Fields[0].Value);
			}
			recordset.Close();
		}
		if ((Globals_Renamed.arOpBorC[Globals_Renamed.intOpIndex] == 1) & (Globals_Renamed.arOpParms[17, Globals_Renamed.intOpIndex] < 1f))
		{
			txtODa.Text = Conversions.ToString(Globals_Renamed.arOpParms[16, Globals_Renamed.intOpIndex]);
		}
		else
		{
			txtODa.Text = Conversions.ToString(Globals_Renamed.arOpParms[2, Globals_Renamed.intOpIndex]);
		}
		if (Versioned.IsNumeric((object)txtR.Text))
		{
			if (Conversions.ToDouble(txtODa.Text) == 0.0)
			{
				txtNcd.Text = Conversions.ToString(0);
			}
			else
			{
				txtNcd.Text = ChemStrX.ShowInSciNot(Conversions.ToDouble(txtNcy.Text) / Conversions.ToDouble(txtODa.Text));
			}
			txtNcd.Text = Conversions.ToString(0);
		}
		if (Versioned.IsNumeric((object)txtR.Text))
		{
			if (Conversions.ToDouble(txtR.Text) == 0.0)
			{
				txtOHa.Text = Conversions.ToString(0);
			}
			else
			{
				txtOHa.Text = ChemStrX.ShowInSciNot(Conversions.ToDouble(txtNcd.Text) / Conversions.ToDouble(txtR.Text));
			}
		}
		else
		{
			txtOHa.Text = Conversions.ToString(0);
		}
		_optMci_0.Checked = true;
		_chkContParms_0.CheckState = (CheckState)0;
		_chkContParms_1.CheckState = (CheckState)0;
		_chkContParms_2.CheckState = (CheckState)0;
		_chkContParms_3.CheckState = (CheckState)0;
		_chkContParms_4.CheckState = (CheckState)0;
		recordset = null;
		command = null;
	}

	private void CancelButton_Renamed_Click(object eventSender, EventArgs eventArgs)
	{
		((Form)this).Close();
	}

	private void chkContParms_CheckStateChanged(object eventSender, EventArgs eventArgs)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Invalid comparison between Unknown and I4
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Invalid comparison between Unknown and I4
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Invalid comparison between Unknown and I4
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Invalid comparison between Unknown and I4
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Invalid comparison between Unknown and I4
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Invalid comparison between Unknown and I4
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Invalid comparison between Unknown and I4
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Invalid comparison between Unknown and I4
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		int num = Conversions.ToInteger(Strings.Mid(Conversions.ToString(NewLateBinding.LateGet(eventSender, (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null)), 15));
		if (_0024STATIC_0024chkContParms_CheckStateChanged_002420211C1271_0024PreventRecursion)
		{
			return;
		}
		short num2 = default(short);
		foreach (Control control in ((Control)this).Controls)
		{
			Control val = control;
			if (Operators.CompareString(Strings.Mid(val.Name, 1, 14), "_chkContParms_", false) == 0 && (int)((CheckBox)val).CheckState == 1)
			{
				num2 = checked((short)(num2 + 1));
			}
		}
		if (num2 > 3)
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"You are allowed to only directly update three parameters on this tab.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
			_0024STATIC_0024chkContParms_CheckStateChanged_002420211C1271_0024PreventRecursion = true;
			((CheckBox)eventSender).CheckState = (CheckState)0;
			_0024STATIC_0024chkContParms_CheckStateChanged_002420211C1271_0024PreventRecursion = false;
			return;
		}
		if (((int)_chkContParms_0.CheckState == 1) & ((int)_chkContParms_1.CheckState == 1) & ((int)_chkContParms_2.CheckState == 1))
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"You are allowed to only directly update two of the parameters in the first two groups.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
			_0024STATIC_0024chkContParms_CheckStateChanged_002420211C1271_0024PreventRecursion = true;
			((CheckBox)eventSender).CheckState = (CheckState)0;
			_0024STATIC_0024chkContParms_CheckStateChanged_002420211C1271_0024PreventRecursion = false;
			return;
		}
		if (((int)_chkContParms_2.CheckState == 1) & ((int)_chkContParms_3.CheckState == 1) & ((int)_chkContParms_4.CheckState == 1))
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"You are allowed to only directly update two of the parameters in the last two groups.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
			_0024STATIC_0024chkContParms_CheckStateChanged_002420211C1271_0024PreventRecursion = true;
			((CheckBox)eventSender).CheckState = (CheckState)0;
			_0024STATIC_0024chkContParms_CheckStateChanged_002420211C1271_0024PreventRecursion = false;
			return;
		}
		bool readOnly;
		float num3;
		if ((int)((CheckBox)eventSender).CheckState == 1)
		{
			readOnly = false;
			num3 = ColorTranslator.ToOle(Color.White);
		}
		else
		{
			readOnly = true;
			num3 = ColorTranslator.ToOle(((Form)this).BackColor);
		}
		checked
		{
			switch (num)
			{
			case 0:
				((TextBoxBase)txtNcy).ReadOnly = readOnly;
				((TextBoxBase)txtNcy).BackColor = ColorTranslator.FromOle((int)Math.Round(num3));
				break;
			case 1:
				((TextBoxBase)txtODa).ReadOnly = readOnly;
				((TextBoxBase)txtODa).BackColor = ColorTranslator.FromOle((int)Math.Round(num3));
				break;
			case 2:
				((TextBoxBase)txtNcd).ReadOnly = readOnly;
				((TextBoxBase)txtNcd).BackColor = ColorTranslator.FromOle((int)Math.Round(num3));
				break;
			case 3:
				((TextBoxBase)txtR).ReadOnly = readOnly;
				((TextBoxBase)txtR).BackColor = ColorTranslator.FromOle((int)Math.Round(num3));
				break;
			case 4:
				((TextBoxBase)txtOHa).ReadOnly = readOnly;
				((TextBoxBase)txtOHa).BackColor = ColorTranslator.FromOle((int)Math.Round(num3));
				break;
			}
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

	private void cmdCalcOthers_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Invalid comparison between Unknown and I4
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Invalid comparison between Unknown and I4
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Invalid comparison between Unknown and I4
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Invalid comparison between Unknown and I4
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Invalid comparison between Unknown and I4
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_043e: Invalid comparison between Unknown and I4
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_044d: Invalid comparison between Unknown and I4
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0540: Unknown result type (might be due to invalid IL or missing references)
		//IL_0546: Invalid comparison between Unknown and I4
		//IL_054e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0554: Invalid comparison between Unknown and I4
		//IL_055d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Invalid comparison between Unknown and I4
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0664: Unknown result type (might be due to invalid IL or missing references)
		//IL_066a: Invalid comparison between Unknown and I4
		//IL_0672: Unknown result type (might be due to invalid IL or missing references)
		//IL_0678: Invalid comparison between Unknown and I4
		//IL_0681: Unknown result type (might be due to invalid IL or missing references)
		//IL_0687: Invalid comparison between Unknown and I4
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0788: Unknown result type (might be due to invalid IL or missing references)
		//IL_078e: Invalid comparison between Unknown and I4
		//IL_0796: Unknown result type (might be due to invalid IL or missing references)
		//IL_079c: Invalid comparison between Unknown and I4
		//IL_07a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ab: Invalid comparison between Unknown and I4
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b2: Invalid comparison between Unknown and I4
		//IL_08ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c0: Invalid comparison between Unknown and I4
		//IL_08c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cf: Invalid comparison between Unknown and I4
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c8: Invalid comparison between Unknown and I4
		//IL_09d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d6: Invalid comparison between Unknown and I4
		//IL_09df: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e5: Invalid comparison between Unknown and I4
		//IL_0ad8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ade: Invalid comparison between Unknown and I4
		//IL_0ae6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aec: Invalid comparison between Unknown and I4
		//IL_0af5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afb: Invalid comparison between Unknown and I4
		//IL_0e16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd4: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num2 = default(int);
		short num3 = default(short);
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
					((Control)txtOHa).Tag = txtOHa.Text;
					((Control)txtODa).Tag = txtODa.Text;
					((Control)txtNcd).Tag = txtNcd.Text;
					((Control)cmdCalcOthers).Tag = "Failed";
					IEnumerator enumerator = ((Control)_fraStep_1).Controls.GetEnumerator();
					while (true)
					{
						if (enumerator.MoveNext())
						{
							Control val3 = (Control)enumerator.Current;
							if (Operators.CompareString(Strings.Mid(val3.Name, 1, 14), "_chkContParms_", false) != 0 || (int)((CheckBox)val3).CheckState != 1)
							{
								continue;
							}
							string text = Strings.Mid(val3.Name, 15, 1);
							if (Operators.CompareString(text, Conversions.ToString(0), false) == 0)
							{
								if (!Versioned.IsNumeric((object)txtNcy.Text))
								{
									Interaction.Beep();
									Interaction.MsgBox((object)"Please enter a valid Ncy", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
									((Control)txtNcy).Focus();
									break;
								}
							}
							else if (Operators.CompareString(text, Conversions.ToString(1), false) == 0)
							{
								if (!Versioned.IsNumeric((object)txtODa.Text))
								{
									Interaction.Beep();
									Interaction.MsgBox((object)"Please enter a valid ODa", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
									((Control)txtODa).Focus();
									break;
								}
							}
							else if (Operators.CompareString(text, Conversions.ToString(2), false) == 0)
							{
								if (!Versioned.IsNumeric((object)txtNcd.Text))
								{
									Interaction.Beep();
									Interaction.MsgBox((object)"Please enter a valid Ncd", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
									((Control)txtNcd).Focus();
									break;
								}
							}
							else if (Operators.CompareString(text, Conversions.ToString(3), false) == 0)
							{
								if (!Versioned.IsNumeric((object)txtR.Text))
								{
									Interaction.Beep();
									Interaction.MsgBox((object)"Please enter a valid r", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
									((Control)txtR).Focus();
									break;
								}
							}
							else if (Operators.CompareString(text, Conversions.ToString(4), false) == 0 && !Versioned.IsNumeric((object)txtOHa.Text))
							{
								Interaction.Beep();
								Interaction.MsgBox((object)"Please enter a valid OHa", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
								((Control)txtOHa).Focus();
								break;
							}
							num3 = checked((short)(num3 + 1));
							continue;
						}
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
						if (num3 != 3)
						{
							Interaction.Beep();
							Interaction.MsgBox((object)"Please select exactly three parameters on the Verify/Select Container Parameters by Source/Activity tab. The other two parameters will be derived from the three parameters you select.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
							break;
						}
						if (((int)_chkContParms_0.CheckState == 1) & ((int)_chkContParms_1.CheckState == 1) & ((int)_chkContParms_3.CheckState == 1))
						{
							if (Operators.ConditionalCompareObjectNotEqual(Common.MyNullCheck0(txtODa.Text), (object)0, false))
							{
								txtNcd.Text = ChemStrX.ShowInSciNot(Conversions.ToDouble(txtNcy.Text) / Conversions.ToDouble(txtODa.Text));
							}
							else
							{
								txtNcd.Text = "";
							}
							if (Operators.ConditionalCompareObjectNotEqual(Common.MyNullCheck0(txtR.Text), (object)0, false))
							{
								txtOHa.Text = ChemStrX.ShowInSciNot(Conversions.ToDouble(txtNcd.Text) / Conversions.ToDouble(txtR.Text));
							}
							else
							{
								txtOHa.Text = "";
							}
						}
						else if (((int)_chkContParms_0.CheckState == 1) & ((int)_chkContParms_1.CheckState == 1) & ((int)_chkContParms_4.CheckState == 1))
						{
							if (Operators.ConditionalCompareObjectNotEqual(Common.MyNullCheck0(txtODa.Text), (object)0, false))
							{
								txtNcd.Text = ChemStrX.ShowInSciNot(Conversions.ToDouble(txtNcy.Text) / Conversions.ToDouble(txtODa.Text));
							}
							else
							{
								txtNcd.Text = "";
							}
							if (Operators.ConditionalCompareObjectNotEqual(Common.MyNullCheck0(txtOHa.Text), (object)0, false))
							{
								txtR.Text = ChemStrX.ShowInSciNot(Conversions.ToDouble(txtNcd.Text) / Conversions.ToDouble(txtOHa.Text));
							}
							else
							{
								txtR.Text = "";
							}
						}
						else if (((int)_chkContParms_0.CheckState == 1) & ((int)_chkContParms_2.CheckState == 1) & ((int)_chkContParms_3.CheckState == 1))
						{
							if (Operators.ConditionalCompareObjectNotEqual(Common.MyNullCheck0(txtNcd.Text), (object)0, false))
							{
								TextBox obj = txtODa;
								double pValue = Conversions.ToDouble(txtNcy.Text) / Conversions.ToDouble(txtNcd.Text);
								string Eobject = "ODa";
								obj.Text = Conversions.ToString(MyRoundIt(ref pValue, ref Eobject));
							}
							else
							{
								txtODa.Text = "";
							}
							if (Operators.ConditionalCompareObjectNotEqual(Common.MyNullCheck0(txtR.Text), (object)0, false))
							{
								txtOHa.Text = ChemStrX.ShowInSciNot(Conversions.ToDouble(txtNcd.Text) / Conversions.ToDouble(txtR.Text));
							}
							else
							{
								txtOHa.Text = "";
							}
						}
						else if (((int)_chkContParms_0.CheckState == 1) & ((int)_chkContParms_2.CheckState == 1) & ((int)_chkContParms_4.CheckState == 1))
						{
							if (Operators.ConditionalCompareObjectNotEqual(Common.MyNullCheck0(txtNcd.Text), (object)0, false))
							{
								TextBox obj2 = txtODa;
								double pValue = Conversions.ToDouble(txtNcy.Text) / Conversions.ToDouble(txtNcd.Text);
								string Eobject = "ODa";
								obj2.Text = Conversions.ToString(MyRoundIt(ref pValue, ref Eobject));
							}
							else
							{
								txtODa.Text = "";
							}
							if (Operators.ConditionalCompareObjectNotEqual(Common.MyNullCheck0(txtOHa.Text), (object)0, false))
							{
								txtR.Text = ChemStrX.ShowInSciNot(Conversions.ToDouble(txtNcd.Text) / Conversions.ToDouble(txtOHa.Text));
							}
							else
							{
								txtR.Text = "";
							}
						}
						else if (((int)_chkContParms_0.CheckState == 1) & ((int)_chkContParms_3.CheckState == 1) & ((int)_chkContParms_4.CheckState == 1))
						{
							if (Operators.ConditionalCompareObjectNotEqual(Common.MyNullCheck0(txtOHa.Text), (object)0, false))
							{
								txtNcd.Text = ChemStrX.ShowInSciNot(Conversions.ToDouble(txtR.Text) * Conversions.ToDouble(txtOHa.Text));
							}
							else
							{
								txtNcd.Text = "";
							}
							if (Operators.ConditionalCompareObjectNotEqual(Common.MyNullCheck0(txtNcd.Text), (object)0, false))
							{
								TextBox obj3 = txtODa;
								double pValue = Conversions.ToDouble(txtNcy.Text) / Conversions.ToDouble(txtNcd.Text);
								string Eobject = "ODa";
								obj3.Text = Conversions.ToString(MyRoundIt(ref pValue, ref Eobject));
							}
							else
							{
								txtODa.Text = "";
							}
						}
						else if (((int)_chkContParms_1.CheckState == 1) & ((int)_chkContParms_2.CheckState == 1) & ((int)_chkContParms_3.CheckState == 1))
						{
							if (Operators.ConditionalCompareObjectNotEqual(Common.MyNullCheck0(txtNcd.Text), (object)0, false))
							{
								txtNcy.Text = ChemStrX.ShowInSciNot(Conversions.ToDouble(txtODa.Text) * Conversions.ToDouble(txtNcd.Text));
							}
							else
							{
								txtNcy.Text = "";
							}
							if (Operators.ConditionalCompareObjectNotEqual(Common.MyNullCheck0(txtR.Text), (object)0, false))
							{
								txtOHa.Text = ChemStrX.ShowInSciNot(Conversions.ToDouble(txtNcd.Text) / Conversions.ToDouble(txtR.Text));
							}
							else
							{
								txtOHa.Text = "";
							}
						}
						else if (((int)_chkContParms_1.CheckState == 1) & ((int)_chkContParms_2.CheckState == 1) & ((int)_chkContParms_4.CheckState == 1))
						{
							if (Operators.ConditionalCompareObjectNotEqual(Common.MyNullCheck0(txtNcd.Text), (object)0, false))
							{
								txtNcy.Text = ChemStrX.ShowInSciNot(Conversions.ToDouble(txtODa.Text) * Conversions.ToDouble(txtNcd.Text));
							}
							else
							{
								txtNcy.Text = "";
							}
							if (Operators.ConditionalCompareObjectNotEqual(Common.MyNullCheck0(txtOHa.Text), (object)0, false))
							{
								txtR.Text = ChemStrX.ShowInSciNot(Conversions.ToDouble(txtNcd.Text) / Conversions.ToDouble(txtOHa.Text));
							}
							else
							{
								txtR.Text = "";
							}
						}
						else if (((int)_chkContParms_1.CheckState == 1) & ((int)_chkContParms_3.CheckState == 1) & ((int)_chkContParms_4.CheckState == 1))
						{
							if (Operators.ConditionalCompareObjectNotEqual(Common.MyNullCheck0(txtOHa.Text), (object)0, false))
							{
								txtNcd.Text = ChemStrX.ShowInSciNot(Conversions.ToDouble(txtR.Text) * Conversions.ToDouble(txtOHa.Text));
							}
							else
							{
								txtNcd.Text = "";
							}
							if (Operators.ConditionalCompareObjectNotEqual(Common.MyNullCheck0(txtNcd.Text), (object)0, false))
							{
								txtNcy.Text = ChemStrX.ShowInSciNot(Conversions.ToDouble(txtODa.Text) * Conversions.ToDouble(txtNcd.Text));
							}
							else
							{
								txtNcy.Text = "";
							}
						}
						if (Versioned.IsNumeric((object)txtNcd.Text) & Versioned.IsNumeric((object)txtNcy.Text) & Versioned.IsNumeric((object)txtOHa.Text) & Versioned.IsNumeric((object)txtR.Text) & Versioned.IsNumeric((object)txtODa.Text))
						{
							if (Conversions.ToSingle(txtNcd.Text) > Conversions.ToSingle(txtNcy.Text))
							{
								Interaction.Beep();
								Interaction.MsgBox((object)"Ncd is greater than Ncy, which is not valid.  Please correct this error.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
								txtNcd.Text = "";
							}
							if (Conversions.ToSingle(txtODa.Text) > 365f)
							{
								Interaction.Beep();
								Interaction.MsgBox((object)("An invalid ODa of " + txtODa.Text + " has been calculated. ODa must be less than or equal to 365. ODa is calculated by dividing Ncy by Ncd.  Please correct this error."), (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
								txtODa.Text = "";
							}
							if (Conversions.ToSingle(txtOHa.Text) > 24f)
							{
								Interaction.Beep();
								Interaction.MsgBox((object)("An invalid OHa of " + txtOHa.Text + " has been calculated. OHa must be less than or equal to 24. OHa is calculated by dividing Ncd by r.  Please correct this error."), (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
								txtOHa.Text = "";
							}
							if (sngCalcNcyFromTab1 > 0f)
							{
								int num4 = checked((int)Math.Round(Math.Abs((sngCalcNcyFromTab1 / Conversions.ToSingle(txtNcy.Text) - 1f) * 100f)));
								if (num4 > 5)
								{
									lbl5PctError.Text = "A mass accounting discrepancy of " + Conversions.ToString(num4) + " percent exists based on current parameter values and relational equations.";
									Interaction.Beep();
									Interaction.MsgBox((object)lbl5PctError.Text, (MsgBoxStyle)64, (object)"Mass Accounting Discrepancy");
								}
								else
								{
									lbl5PctError.Text = "No mass accounting discrepancy exists";
								}
							}
							((Control)cmdCalcOthers).Tag = "";
						}
						else
						{
							Interaction.Beep();
							Interaction.MsgBox((object)"One or more of the five container parameters above is invalid. Blanks are not allowed. Please try again, this time a little more carefully please.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
						}
						break;
					}
					goto end_IL_0001;
				}
				case 3718:
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
			catch (object obj4) when (obj4 is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj4);
				try0001_dispatch = 3718;
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

	private void cmdRestore_Click(object eventSender, EventArgs eventArgs)
	{
		_chkContParms_0.CheckState = (CheckState)0;
		_chkContParms_1.CheckState = (CheckState)0;
		_chkContParms_2.CheckState = (CheckState)0;
		_chkContParms_3.CheckState = (CheckState)0;
		_chkContParms_4.CheckState = (CheckState)0;
		if (step_Renamed == 0)
		{
			ContDefaultsAndSetResetContParms1();
		}
		ContDefaultsAndSetResetContParms2();
	}

	private void frmMDUpdContTab_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (Conversions.ToBoolean(Operators.OrObject((object)(!(((Control)OKButton).Focused | ((Control)CancelButton_Renamed).Focused)), Operators.CompareObjectEqual(((Control)cmdCalcOthers).Tag, (object)"Failed", false))))
		{
			((Control)OKButton).Focus();
			((CancelEventArgs)(object)e).Cancel = true;
		}
	}

	private void frmMDUpdContTab_Load(object eventSender, EventArgs eventArgs)
	{
		lbl5PctError.Text = "";
		sngCalcNcyFromTab1 = 0f;
	}

	private void OKButton_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Invalid comparison between Unknown and I4
		//IL_044a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Expected O, but got Unknown
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Invalid comparison between Unknown and I4
		int try0001_dispatch = -1;
		int num2 = default(int);
		short num3 = default(short);
		short num4 = default(short);
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
						IEnumerator enumerator = ((Control)_fraStep_1).Controls.GetEnumerator();
						while (enumerator.MoveNext())
						{
							Control val3 = (Control)enumerator.Current;
							if (Operators.CompareString(Strings.Mid(val3.Name, 1, 14), "_chkContParms_", false) == 0 && unchecked((int)((CheckBox)val3).CheckState) == 1)
							{
								num3++;
							}
						}
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
						if (num3 > 0)
						{
							cmdCalcOthers_Click(cmdCalcOthers, new EventArgs());
							if (Operators.ConditionalCompareObjectEqual(((Control)cmdCalcOthers).Tag, (object)"Failed", false))
							{
								goto end_IL_0001;
							}
						}
						if (Strings.Len(txtVc.Text) == 0)
						{
							Globals_Renamed.arContParms[3, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] = 0f;
						}
						else
						{
							Globals_Renamed.arContParms[3, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] = Conversions.ToSingle(txtVc.Text);
						}
						short pID = 19;
						ref float pValue = ref Globals_Renamed.arContParms[3, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex];
						short pVC = -1203;
						ChemStrX.RollDownhillAct(ref pID, ref pValue, ref pVC);
						if (Strings.Len(txtDi.Text) == 0)
						{
							Globals_Renamed.arContParms[5, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] = 0f;
						}
						else
						{
							Globals_Renamed.arContParms[5, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] = Conversions.ToSingle(txtDi.Text);
						}
						Globals_Renamed.arContParms[6, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] = Conversions.ToSingle(Common.MyNullCheck0(txtMCi.Text));
						pVC = 110;
						ref float pValue2 = ref Globals_Renamed.arContParms[6, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex];
						pID = -1206;
						ChemStrX.RollDownhillAct(ref pVC, ref pValue2, ref pID);
						Globals_Renamed.arContParms[9, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] = Conversions.ToSingle(Common.MyNullCheck0(txtODa.Text));
						pVC = 93;
						ref float pValue3 = ref Globals_Renamed.arContParms[9, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex];
						pID = -1209;
						ChemStrX.RollDownhillAct(ref pVC, ref pValue3, ref pID);
						Globals_Renamed.arContParms[8, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] = Conversions.ToSingle(Common.MyNullCheck0(txtNcy.Text));
						pVC = 105;
						ref float pValue4 = ref Globals_Renamed.arContParms[8, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex];
						pID = -1208;
						ChemStrX.RollDownhillAct(ref pVC, ref pValue4, ref pID);
						Globals_Renamed.arContParms[10, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] = Conversions.ToSingle(Common.MyNullCheck0(txtNcd.Text));
						Globals_Renamed.arContParms[1, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] = Conversions.ToSingle(Common.MyNullCheck0(txtR.Text));
						pVC = 23;
						ref float pValue5 = ref Globals_Renamed.arContParms[1, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex];
						pID = -1201;
						ChemStrX.RollDownhillAct(ref pVC, ref pValue5, ref pID);
						Globals_Renamed.arContParms[7, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] = Conversions.ToSingle(Common.MyNullCheck0(txtOHa.Text));
						pVC = 31;
						ref float pValue6 = ref Globals_Renamed.arContParms[7, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex];
						pID = -1302;
						ChemStrX.RollDownhillAct(ref pVC, ref pValue6, ref pID);
						pVC = 46;
						ref float pValue7 = ref Globals_Renamed.arContParms[7, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex];
						pID = -1302;
						ChemStrX.RollDownhillAct(ref pVC, ref pValue7, ref pID);
						Globals_Renamed.arContParms[4, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] = Conversions.ToSingle(Common.MyNullCheck0(txtFc.Text));
						Globals_Renamed.arContParms[2, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] = Conversions.ToSingle(Common.MyNullCheck0(txtYi.Text));
						pVC = 94;
						ref float pValue8 = ref Globals_Renamed.arContParms[2, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex];
						pID = -1202;
						ChemStrX.RollDownhillAct(ref pVC, ref pValue8, ref pID);
						IEnumerator enumerator2 = ((Control)_fraStep_1).Controls.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							Control val3 = (Control)enumerator2.Current;
							if (Operators.CompareString(Strings.Mid(val3.Name, 1, 14), "_chkContParms_", false) == 0)
							{
								num3 = Conversions.ToShort(Interaction.Choose((double)(num4 + 1), new object[5]
								{
									(short)8,
									(short)9,
									(short)10,
									(short)1,
									(short)7
								}));
								if (unchecked((int)((CheckBox)val3).CheckState) == 1)
								{
									Globals_Renamed.arContParmTypes[num3, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] = 2;
								}
								else
								{
									Globals_Renamed.arContParmTypes[num3, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] = 1;
								}
							}
						}
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
						Globals_Renamed.arContParms[11, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] = Globals_Renamed.arContParms[6, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] * Globals_Renamed.arContParms[2, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex];
						pVC = 111;
						ref float pValue9 = ref Globals_Renamed.arContParms[11, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex];
						pID = -999;
						ChemStrX.RollDownhillAct(ref pVC, ref pValue9, ref pID);
						Globals_Renamed.arContParms[12, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] = Globals_Renamed.arContParms[6, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] * Globals_Renamed.arContParms[2, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] * Globals_Renamed.arContParms[10, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex];
						pVC = 112;
						ref float pValue10 = ref Globals_Renamed.arContParms[12, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex];
						pID = -999;
						ChemStrX.RollDownhillAct(ref pVC, ref pValue10, ref pID);
						Globals_Renamed.arContParms[13, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] = Globals_Renamed.arContParms[6, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] * Globals_Renamed.arContParms[10, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex];
						pVC = 87;
						ref float pValue11 = ref Globals_Renamed.arContParms[13, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex];
						pID = -999;
						ChemStrX.RollDownhillAct(ref pVC, ref pValue11, ref pID);
						ChemStrX.ResetMetaDefaults();
						num3 = 0;
						short num5;
						short num6;
						do
						{
							if (Globals_Renamed.arRelModels[num3, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] > 0)
							{
								Globals_Renamed.arRelModStatus[Globals_Renamed.arRelModels[num3, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1] = 3;
							}
							num3 = (short)unchecked(num3 + 1);
							num5 = num3;
							num6 = 9;
						}
						while (num5 <= num6);
						num3 = 0;
						short num7;
						do
						{
							if (Globals_Renamed.arExpModels[num3, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] > 0)
							{
								Globals_Renamed.arExpModStatus[Globals_Renamed.arExpModels[num3, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1] = 3;
							}
							num3 = (short)unchecked(num3 + 1);
							num7 = num3;
							num6 = 1;
						}
						while (num7 <= num6);
						frmMain.DefInstance.cmbRelOps.SelectedIndex = -1;
						frmMain.DefInstance.cmbExpOps.SelectedIndex = -1;
						Globals_Renamed.gblIWasChanged = true;
						((Form)this).Close();
						goto end_IL_0001;
					}
					case 2003:
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
				try0001_dispatch = 2003;
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

	private int MyRoundIt(ref double pValue, ref string sAbbr)
	{
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			int num = (int)Math.Round(pValue);
			if (num == 0)
			{
				num = 1;
			}
			int num2 = num;
			if (pValue > 0.0)
			{
				num = (int)Math.Round(Math.Abs(((double)num2 / pValue - 1.0) * 100.0));
				if (num >= 5)
				{
					lbl5PctError.Text = "A mass accounting discrepancy of " + Conversions.ToString(num) + " percent due to rounding of " + sAbbr + " exists based on current parameter values and relational equations. The calculated value was " + ChemStrX.ShowInSciNot(pValue) + " and the value after rounding was " + ChemStrX.ShowInSciNot(num2) + ".";
					Interaction.Beep();
					Interaction.MsgBox((object)lbl5PctError.Text, (MsgBoxStyle)64, (object)"Mass Accounting Discrepancy");
				}
				else
				{
					lbl5PctError.Text = "No mass accounting discrepancy exists";
				}
			}
			return num2;
		}
	}

	public bool SetUp(ref short pContTab, ref short pShowTab, ref short pActID)
	{
		//IL_0785: Unknown result type (might be due to invalid IL or missing references)
		//IL_078b: Expected O, but got Unknown
		//IL_0824: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num2 = default(int);
		short num3 = default(short);
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
						((Control)_fraStep_0).Visible = true;
						((Control)_fraStep_1).Visible = false;
						MyActID = pActID;
						step_Renamed = 99;
						command.ActiveConnection = Common.MyConn;
						command.CommandText = "pqryGetInstructions";
						command.CommandType = CommandTypeEnum.adCmdStoredProc;
						command.Parameters.Append(command.CreateParameter("pID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, 14));
						Command command2 = command;
						object RecordsAffected = Missing.Value;
						object Parameters = Missing.Value;
						recordset = command2.Execute(out RecordsAffected, ref Parameters);
						command.Parameters.Delete("pID");
						_lblInstructions_0.Text = Conversions.ToString(recordset.Fields[0].Value);
						recordset.Close();
						command.Parameters.Append(command.CreateParameter("pID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, 15));
						Command command3 = command;
						Parameters = Missing.Value;
						RecordsAffected = Missing.Value;
						recordset = command3.Execute(out Parameters, ref RecordsAffected);
						command.Parameters.Delete("pID");
						_lblInstructions_1.Text = Conversions.ToString(recordset.Fields[0].Value);
						recordset.Close();
						recordset = null;
						command = null;
						iContTab = (short)(pContTab - 1);
						switch (iContTab)
						{
						case 0:
							_lblSelAct_0.Text = frmMain.DefInstance._msfCont_0[frmMain.DefInstance._msfCont_0.Row, 1];
							break;
						case 1:
							_lblSelAct_0.Text = frmMain.DefInstance._msfCont_1[frmMain.DefInstance._msfCont_1.Row, 1];
							break;
						case 2:
							_lblSelAct_0.Text = frmMain.DefInstance._msfCont_2[frmMain.DefInstance._msfCont_2.Row, 1];
							break;
						case 3:
							_lblSelAct_0.Text = frmMain.DefInstance._msfCont_3[frmMain.DefInstance._msfCont_3.Row, 1];
							break;
						}
						_lblSelAct_1.Text = _lblSelAct_0.Text;
						lblOD.Text = Conversions.ToString(Globals_Renamed.arOpParms[2, Globals_Renamed.intOpIndex]);
						lblSumFc.Text = Strings.Mid(frmMain.DefInstance.lblContSumFC[iContTab].Text, 13);
						switch (iContTab)
						{
						case 0:
							lblYrmYprod.Text = Conversions.ToString(Globals_Renamed.arOpParms[11, Globals_Renamed.intOpIndex]);
							if (Globals_Renamed.arContParms[14, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] == 0f)
							{
								lblDrmDprod.Text = Conversions.ToString(Globals_Renamed.arOpParms[29, Globals_Renamed.intOpIndex]);
							}
							else
							{
								lblDrmDprod.Text = Conversions.ToString(Globals_Renamed.arContParms[14, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex]);
							}
							break;
						case 1:
						{
							lblYrmYprod.Text = Conversions.ToString(Globals_Renamed.arOpParms[10, Globals_Renamed.intOpIndex]);
							_Label1_0.Text = " Yprod: Weight Fraction of Chemical in Product (unitless)";
							_Label1_2.Text = " Dprod: Density of Product (kg/L)";
							if (Globals_Renamed.arContParms[14, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] == 0f)
							{
								lblDrmDprod.Text = Conversions.ToString(Globals_Renamed.arOpParms[29, Globals_Renamed.intOpIndex]);
							}
							else
							{
								lblDrmDprod.Text = Conversions.ToString(Globals_Renamed.arContParms[14, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex]);
							}
							Tabs obj2 = tabs.Tabs;
							Parameters = 1;
							((ITab)((ITabs)obj2)[ref Parameters]).Caption = "Verify/Select Container Parameters for Product";
							break;
						}
						case 2:
						{
							lblYrmYprod.Text = Conversions.ToString(Globals_Renamed.arOpParms[11, Globals_Renamed.intOpIndex]);
							((Control)_Label1_2).Visible = false;
							((Control)lblDrmDprod).Visible = false;
							Tabs obj = tabs.Tabs;
							Parameters = 1;
							((ITab)((ITabs)obj)[ref Parameters]).Caption = "Verify/Select Container Parameters for Other Material";
							break;
						}
						}
						if (Globals_Renamed.arContParms[3, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] > 0f)
						{
							txtVc.Text = ChemStrX.ShowInSciNot(Globals_Renamed.arContParms[3, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex]);
						}
						if (Globals_Renamed.arContParms[5, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] > 0f)
						{
							txtDi.Text = ChemStrX.ShowInSciNot(Globals_Renamed.arContParms[5, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex]);
						}
						else if (iContTab != 2)
						{
							txtDi.Text = Conversions.ToString(GetMyPredDprod());
						}
						txtMCi.Text = ChemStrX.ShowZeroAsNull(ChemStrX.ShowInSciNot(Globals_Renamed.arContParms[6, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex]));
						if (Globals_Renamed.arContParms[6, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] > 0f && Globals_Renamed.arContParms[5, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] == 0f)
						{
							_optMci_1.Checked = true;
						}
						txtODa.Text = ChemStrX.ShowZeroAsNull(ChemStrX.ShowInSciNot(Globals_Renamed.arContParms[9, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex]));
						txtNcd.Text = ChemStrX.ShowZeroAsNull(ChemStrX.ShowInSciNot(Globals_Renamed.arContParms[10, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex]));
						txtR.Text = ChemStrX.ShowZeroAsNull(ChemStrX.ShowInSciNot(Globals_Renamed.arContParms[1, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex]));
						txtOHa.Text = ChemStrX.ShowZeroAsNull(ChemStrX.ShowInSciNot(Globals_Renamed.arContParms[7, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex]));
						txtFc.Text = ChemStrX.ShowZeroAsNull(ChemStrX.ShowInSciNot(Globals_Renamed.arContParms[4, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex]));
						txtYi.Text = ChemStrX.ShowZeroAsNull(ChemStrX.ShowInSciNot(Globals_Renamed.arContParms[2, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex]));
						txtNcy.Text = ChemStrX.ShowZeroAsNull(ChemStrX.ShowInSciNot(Globals_Renamed.arContParms[8, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex]));
						IEnumerator enumerator = ((Control)this).Controls.GetEnumerator();
						while (enumerator.MoveNext())
						{
							Control val3 = (Control)enumerator.Current;
							if (Operators.CompareString(Strings.Mid(val3.Name, 1, 14), "_chkContParms_", false) == 0)
							{
								short num4 = Conversions.ToShort(Interaction.Choose((double)(num3 + 1), new object[5]
								{
									(short)8,
									(short)9,
									(short)10,
									(short)1,
									(short)7
								}));
								if (Globals_Renamed.arContParmTypes[num4, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] == 2)
								{
									((CheckBox)val3).CheckState = (CheckState)1;
								}
							}
						}
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
						step_Renamed = 0;
						if (pShowTab == 2)
						{
							Tabs obj3 = tabs.Tabs;
							Parameters = 2;
							((ITab)((ITabs)obj3)[ref Parameters]).Selected = true;
						}
						flag = true;
						goto end_IL_0001;
					}
					case 2307:
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
			catch (object obj4) when (obj4 is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj4);
				try0001_dispatch = 2307;
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

	private void optMci_CheckedChanged(object eventSender, EventArgs eventArgs)
	{
		if (!Conversions.ToBoolean(NewLateBinding.LateGet(eventSender, (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			return;
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(eventSender, (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"_optMci_0", false))
		{
			((TextBoxBase)txtMCi).ReadOnly = true;
			((TextBoxBase)txtMCi).BackColor = ((Form)this).BackColor;
			((TextBoxBase)txtVc).ReadOnly = false;
			((TextBoxBase)txtVc).BackColor = Color.White;
			TextBox pTextBox = txtVc;
			object obj = ValidateNumberGT0(ref pTextBox);
			txtVc = pTextBox;
			TextBox pTextBox2 = txtDi;
			object obj2 = ValidateNumberGT0(ref pTextBox2);
			txtDi = pTextBox2;
			if (Conversions.ToBoolean(Operators.AndObject(obj, obj2)))
			{
				CalcMci();
			}
		}
		else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(eventSender, (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"_optMci_1", false))
		{
			((TextBoxBase)txtMCi).ReadOnly = false;
			((TextBoxBase)txtMCi).BackColor = Color.White;
			((TextBoxBase)txtVc).ReadOnly = true;
			((TextBoxBase)txtVc).BackColor = ((Form)this).BackColor;
			TextBox pTextBox2 = txtMCi;
			object obj3 = ValidateNumberGT0(ref pTextBox2);
			txtMCi = pTextBox2;
			TextBox pTextBox = txtDi;
			object obj4 = ValidateNumberGT0(ref pTextBox);
			txtDi = pTextBox;
			if (Conversions.ToBoolean(Operators.AndObject(obj3, obj4)))
			{
				CalcVc();
			}
		}
	}

	private void tabs_ClickEvent(object eventSender, EventArgs eventArgs)
	{
		((Control)_fraStep_0).Visible = false;
		((Control)_fraStep_1).Visible = false;
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
			if (step_Renamed == 0)
			{
				((Control)_fraStep_0).Visible = true;
			}
			else
			{
				((Control)_fraStep_1).Visible = true;
			}
		}
	}

	private void txtDi_Leave(object eventSender, EventArgs eventArgs)
	{
		if (_optMci_0.Checked)
		{
			CalcMci();
		}
		else
		{
			CalcVc();
		}
	}

	private void txtFc_Leave(object eventSender, EventArgs eventArgs)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		if (!((Strings.Len(txtFc.Text) > 0) & (Operators.CompareString(txtFc.Text, ".", false) != 0)))
		{
			return;
		}
		if (!Versioned.IsNumeric((object)txtFc.Text))
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Please enter a valid number.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
		}
		else
		{
			if (!((Conversions.ToDouble(txtFc.Text) < 0.0) | (Conversions.ToDouble(txtFc.Text) > 1.0)))
			{
				CalcNcy();
				return;
			}
			Interaction.Beep();
			Interaction.MsgBox((object)"Please enter a valid number.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
		}
		((TextBoxBase)txtFc).SelectionStart = 0;
		((TextBoxBase)txtFc).SelectionLength = Strings.Len(txtFc.Text);
		((Control)txtFc).Focus();
	}

	private void txtMCi_Leave(object eventSender, EventArgs eventArgs)
	{
		object obj = _optMci_1.Checked;
		TextBox pTextBox = txtMCi;
		object obj2 = ValidateNumberGT0(ref pTextBox);
		txtMCi = pTextBox;
		if (Conversions.ToBoolean(Operators.AndObject(obj, obj2)))
		{
			CalcVc();
			CalcNcy();
		}
	}

	private void txtNcd_Enter(object eventSender, EventArgs eventArgs)
	{
		bErrorDontLoseFocus = false;
	}

	private void txtNcd_Leave(object eventSender, EventArgs eventArgs)
	{
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (!bErrorDontLoseFocus && !((TextBoxBase)txtNcd).ReadOnly)
		{
			TextBox pTextBox = txtNcd;
			object obj = ValidateNumberGT0(ref pTextBox);
			txtNcd = pTextBox;
			if (Conversions.ToBoolean(obj) && Versioned.IsNumeric((object)txtNcy.Text) && Conversions.ToSingle(txtNcd.Text) > Conversions.ToSingle(txtNcy.Text))
			{
				Interaction.Beep();
				Interaction.MsgBox((object)"Ncd must be less than or equal to Ncy.  Please enter a valid Ncy.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
				((TextBoxBase)txtNcd).SelectionStart = 0;
				((TextBoxBase)txtNcd).SelectionLength = Strings.Len(txtNcd.Text);
				bErrorDontLoseFocus = true;
				((Control)txtNcd).Focus();
			}
		}
	}

	private void txtNcy_Enter(object eventSender, EventArgs eventArgs)
	{
		bErrorDontLoseFocus = false;
	}

	private void txtNcy_Leave(object eventSender, EventArgs eventArgs)
	{
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		if (bErrorDontLoseFocus || ((TextBoxBase)txtNcy).ReadOnly)
		{
			return;
		}
		TextBox pTextBox = txtNcy;
		object obj = ValidateNumberGT0(ref pTextBox);
		txtNcy = pTextBox;
		if (!Conversions.ToBoolean(obj) || !Versioned.IsNumeric((object)txtNcd.Text))
		{
			return;
		}
		if (Conversions.ToSingle(txtNcd.Text) > Conversions.ToSingle(txtNcy.Text))
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Ncd must be less than or equal to Ncy.  Please enter a valid Ncy.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
			((TextBoxBase)txtNcy).SelectionStart = 0;
			((TextBoxBase)txtNcy).SelectionLength = Strings.Len(txtNcy.Text);
			bErrorDontLoseFocus = true;
			((Control)txtNcy).Focus();
		}
		else if (Versioned.IsNumeric((object)txtMCi.Text) & Versioned.IsNumeric((object)txtYi.Text) & Versioned.IsNumeric((object)txtFc.Text) & (Globals_Renamed.arOpParms[1, Globals_Renamed.intOpIndex] > 0f) & (Globals_Renamed.arOpPv[Globals_Renamed.intOpIndex] > 0.0))
		{
			float num = (float)(Globals_Renamed.arOpPv[Globals_Renamed.intOpIndex] * Conversions.ToDouble(txtFc.Text) / ((double)Globals_Renamed.arOpParms[1, Globals_Renamed.intOpIndex] * Conversions.ToDouble(txtYi.Text) * Conversions.ToDouble(txtMCi.Text)));
			int num2 = checked((int)Math.Round(Math.Abs(Conversions.ToDouble(txtNcy.Text) / (double)num - 1.0) * 100.0));
			if (num2 > 5)
			{
				lbl5PctError.Text = "A mass accounting discrepancy of " + Conversions.ToString(num2) + " percent exists based on current parameter values and relational equations. The calculated value for Ncy was " + ChemStrX.ShowInSciNot(num) + ".";
				Interaction.Beep();
				Interaction.MsgBox((object)lbl5PctError.Text, (MsgBoxStyle)64, (object)"Mass Accounting Discrepancy");
			}
			else
			{
				lbl5PctError.Text = "No mass accounting discrepancy exists";
			}
		}
	}

	private void txtODa_Enter(object eventSender, EventArgs eventArgs)
	{
		bErrorDontLoseFocus = false;
	}

	private void txtODa_Leave(object eventSender, EventArgs eventArgs)
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		if (!bErrorDontLoseFocus && !((TextBoxBase)txtODa).ReadOnly)
		{
			TextBox pTextBox = txtODa;
			object obj = ValidateNumberGT0(ref pTextBox);
			txtODa = pTextBox;
			if (Conversions.ToBoolean(obj) && ((Conversions.ToSingle(txtODa.Text) > 365f) | (Strings.InStr(txtODa.Text, ".", (CompareMethod)0) > 0)))
			{
				Interaction.Beep();
				Interaction.MsgBox((object)"ODa must be an integer less than or equal to 365. Please enter a valid number.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
				((TextBoxBase)txtODa).SelectionStart = 0;
				((TextBoxBase)txtODa).SelectionLength = Strings.Len(txtODa.Text);
				bErrorDontLoseFocus = true;
				((Control)txtODa).Focus();
			}
		}
	}

	private void txtOHa_Enter(object eventSender, EventArgs eventArgs)
	{
		bErrorDontLoseFocus = false;
	}

	private void txtOHa_Leave(object eventSender, EventArgs eventArgs)
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		if (!bErrorDontLoseFocus && !((TextBoxBase)txtOHa).ReadOnly)
		{
			TextBox pTextBox = txtOHa;
			object obj = ValidateNumberGT0(ref pTextBox);
			txtOHa = pTextBox;
			if (Conversions.ToBoolean(obj) && Conversions.ToDouble(txtOHa.Text) > 24.0)
			{
				Interaction.Beep();
				Interaction.MsgBox((object)"OHa must be less than or equal to 24. Please enter a valid number.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
				((TextBoxBase)txtOHa).SelectionStart = 0;
				((TextBoxBase)txtOHa).SelectionLength = Strings.Len(txtOHa.Text);
				bErrorDontLoseFocus = true;
				((Control)txtOHa).Focus();
			}
		}
	}

	private void txtR_Leave(object eventSender, EventArgs eventArgs)
	{
		if (!bErrorDontLoseFocus && !((TextBoxBase)txtR).ReadOnly)
		{
			TextBox pTextBox = txtR;
			ValidateNumberGT0(ref pTextBox);
			txtR = pTextBox;
		}
	}

	private float GetMyPredDprod()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		float num8 = default(float);
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
						if (Globals_Renamed.arNoPre[Globals_Renamed.intOpIndex])
						{
							goto end_IL_0001;
						}
						short num3 = (short)(Globals_Renamed.intNumOps - 1);
						short num4 = 0;
						while (true)
						{
							IL_0071:
							short num5 = num4;
							short num6 = num3;
							if (num5 > num6)
							{
								break;
							}
							short num7 = 0;
							while (true)
							{
								if (Globals_Renamed.arSubOpID[num7, num4] - 1 == Globals_Renamed.intOpIndex)
								{
									num8 = Globals_Renamed.arOpParms[30, num4];
									break;
								}
								num7 = (short)unchecked(num7 + 1);
								short num9 = num7;
								num6 = 9;
								if (num9 <= num6)
								{
									continue;
								}
								num4 = (short)unchecked(num4 + 1);
								goto IL_0071;
							}
							break;
						}
						goto end_IL_0001;
					}
					case 227:
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
				try0001_dispatch = 227;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		float result = num8;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private void txtvc_Leave(object eventSender, EventArgs eventArgs)
	{
		object obj = _optMci_0.Checked;
		TextBox pTextBox = txtVc;
		object obj2 = ValidateNumberGT0(ref pTextBox);
		txtVc = pTextBox;
		if (Conversions.ToBoolean(Operators.AndObject(obj, obj2)))
		{
			CalcMci();
		}
	}

	private void CalcVc()
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
					ProjectData.ClearProjectError();
					num2 = 2;
					if (Versioned.IsNumeric((object)txtDi.Text) & Versioned.IsNumeric((object)txtMCi.Text))
					{
						txtVc.Text = ChemStrX.ShowInSciNot(Conversions.ToDouble(txtMCi.Text) / Conversions.ToDouble(txtDi.Text) / 3.785);
					}
					else if (step_Renamed != 99)
					{
						txtVc.Text = "";
					}
					CalcNcy();
					goto end_IL_0001;
				case 256:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						string Eobject = ((Control)this).Name;
						string Efunction = "CalcVc";
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
				try0001_dispatch = 256;
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

	private void CalcMci()
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
					ProjectData.ClearProjectError();
					num2 = 2;
					if (Versioned.IsNumeric((object)txtDi.Text) & Versioned.IsNumeric((object)txtVc.Text))
					{
						txtMCi.Text = ChemStrX.ShowInSciNot(Conversions.ToDouble(txtVc.Text) * Conversions.ToDouble(txtDi.Text) * 3.785);
					}
					else if (step_Renamed != 99)
					{
						txtMCi.Text = "";
					}
					CalcNcy();
					goto end_IL_0001;
				case 256:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						string Eobject = ((Control)this).Name;
						string Efunction = "CalcMci";
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
				try0001_dispatch = 256;
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

	private void CalcNcy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Invalid comparison between Unknown and I4
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Invalid comparison between Unknown and I4
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
					if ((int)_chkContParms_0.CheckState == 1)
					{
						goto end_IL_0001;
					}
					if (Versioned.IsNumeric((object)txtMCi.Text) & Versioned.IsNumeric((object)txtYi.Text) & Versioned.IsNumeric((object)txtFc.Text) & (Globals_Renamed.arOpParms[1, Globals_Renamed.intOpIndex] > 0f))
					{
						if ((Conversions.ToDouble(txtMCi.Text) > 0.0) & (Conversions.ToDouble(txtYi.Text) > 0.0))
						{
							sngCalcNcyFromTab1 = Conversions.ToSingle(ChemStrX.ShowInSciNot(Globals_Renamed.arOpPv[Globals_Renamed.intOpIndex] * Conversions.ToDouble(txtFc.Text) / ((double)Globals_Renamed.arOpParms[1, Globals_Renamed.intOpIndex] * Conversions.ToDouble(txtYi.Text) * Conversions.ToDouble(txtMCi.Text))));
							txtNcy.Text = Conversions.ToString(sngCalcNcyFromTab1);
						}
						else
						{
							sngCalcNcyFromTab1 = 0f;
							txtNcy.Text = "";
						}
						if (Versioned.IsNumeric((object)txtNcy.Text) & Versioned.IsNumeric((object)txtODa.Text) & ((int)_chkContParms_2.CheckState == 0))
						{
							txtNcd.Text = ChemStrX.ShowInSciNot(Conversions.ToDouble(txtNcy.Text) / Conversions.ToDouble(txtODa.Text));
							if (Versioned.IsNumeric((object)txtR.Text) & ((int)_chkContParms_4.CheckState == 0))
							{
								txtOHa.Text = ChemStrX.ShowInSciNot(Conversions.ToDouble(txtNcd.Text) / Conversions.ToDouble(txtR.Text));
							}
						}
					}
					else if (step_Renamed != 99)
					{
						txtNcy.Text = "";
						txtNcd.Text = "";
						txtOHa.Text = "";
					}
					goto end_IL_0001;
				case 710:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						string Eobject = ((Control)this).Name;
						string Efunction = "CalcNcy";
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
				try0001_dispatch = 710;
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

	private void txtYi_TextChanged(object eventSender, EventArgs eventArgs)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		if (!((Strings.Len(txtYi.Text) > 0) & (Operators.CompareString(txtYi.Text, ".", false) != 0)))
		{
			return;
		}
		if (!Versioned.IsNumeric((object)txtYi.Text))
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Please enter a valid number.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
		}
		else
		{
			if (!((Conversions.ToDouble(txtYi.Text) < 0.0) | (Conversions.ToDouble(txtYi.Text) > 1.0)))
			{
				return;
			}
			Interaction.Beep();
			Interaction.MsgBox((object)"Please enter a valid number.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
		}
		((TextBoxBase)txtYi).SelectionStart = 0;
		((TextBoxBase)txtYi).SelectionLength = Strings.Len(txtYi.Text);
		((Control)txtYi).Focus();
	}

	private object ValidateNumberGT0(ref TextBox pTextBox)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
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
					ProjectData.ClearProjectError();
					num2 = 2;
					if (Strings.Len(pTextBox.Text) <= 0)
					{
						goto end_IL_0001;
					}
					if (!Versioned.IsNumeric((object)pTextBox.Text))
					{
						Interaction.Beep();
						Interaction.MsgBox((object)"Please enter a valid number.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
					}
					else
					{
						if (!(Conversions.ToDouble(pTextBox.Text) <= 0.0))
						{
							obj = true;
							goto end_IL_0001;
						}
						Interaction.Beep();
						Interaction.MsgBox((object)"Please enter a valid number.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
					}
					((TextBoxBase)pTextBox).SelectionStart = 0;
					((TextBoxBase)pTextBox).SelectionLength = Strings.Len(pTextBox.Text);
					((Control)pTextBox).Focus();
					goto end_IL_0001;
				case 290:
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
			catch (object obj2) when (obj2 is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0001_dispatch = 290;
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

	private void txtYi_Leave(object eventSender, EventArgs eventArgs)
	{
		CalcNcy();
	}
}
