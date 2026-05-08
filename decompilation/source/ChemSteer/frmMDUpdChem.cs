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

internal class frmMDUpdChem : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("_chkQual_6")]
	private CheckBox __chkQual_6;

	[AccessedThroughProperty("_chkQual_5")]
	private CheckBox __chkQual_5;

	[AccessedThroughProperty("_chkQual_4")]
	private CheckBox __chkQual_4;

	[AccessedThroughProperty("txtOtherQualification")]
	private TextBox _txtOtherQualification;

	[AccessedThroughProperty("_chkQual_3")]
	private CheckBox __chkQual_3;

	[AccessedThroughProperty("_chkQual_2")]
	private CheckBox __chkQual_2;

	[AccessedThroughProperty("_chkQual_1")]
	private CheckBox __chkQual_1;

	[AccessedThroughProperty("_chkQual_0")]
	private CheckBox __chkQual_0;

	[AccessedThroughProperty("_optSolubility_0")]
	private RadioButton __optSolubility_0;

	[AccessedThroughProperty("_optSolubility_2")]
	private RadioButton __optSolubility_2;

	[AccessedThroughProperty("_optSolubility_1")]
	private RadioButton __optSolubility_1;

	[AccessedThroughProperty("txtMF")]
	private TextBox _txtMF;

	[AccessedThroughProperty("txtLT1000")]
	private TextBox _txtLT1000;

	[AccessedThroughProperty("txtLT500")]
	private TextBox _txtLT500;

	[AccessedThroughProperty("txtChemGenUse")]
	private TextBox _txtChemGenUse;

	[AccessedThroughProperty("txtPV")]
	private TextBox _txtPV;

	[AccessedThroughProperty("txtTradeNames")]
	private TextBox _txtTradeNames;

	[AccessedThroughProperty("txtChemCat")]
	private TextBox _txtChemCat;

	[AccessedThroughProperty("txtChemName")]
	private TextBox _txtChemName;

	[AccessedThroughProperty("txtPVi")]
	private TextBox _txtPVi;

	[AccessedThroughProperty("txtPVd")]
	private TextBox _txtPVd;

	[AccessedThroughProperty("txtCas")]
	private TextBox _txtCas;

	[AccessedThroughProperty("txtVP")]
	private TextBox _txtVP;

	[AccessedThroughProperty("txtMW")]
	private TextBox _txtMW;

	[AccessedThroughProperty("txtDen")]
	private TextBox _txtDen;

	[AccessedThroughProperty("txtSol")]
	private TextBox _txtSol;

	[AccessedThroughProperty("txtSolTemp")]
	private TextBox _txtSolTemp;

	[AccessedThroughProperty("txtDenTemp")]
	private TextBox _txtDenTemp;

	[AccessedThroughProperty("txtVPTemp")]
	private TextBox _txtVPTemp;

	[AccessedThroughProperty("_chkType_0")]
	private CheckBox __chkType_0;

	[AccessedThroughProperty("_chkType_1")]
	private CheckBox __chkType_1;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("cmdOk")]
	private Button _cmdOk;

	[AccessedThroughProperty("_Line1_12")]
	private Label __Line1_12;

	[AccessedThroughProperty("_Line1_11")]
	private Label __Line1_11;

	[AccessedThroughProperty("_Line1_10")]
	private Label __Line1_10;

	[AccessedThroughProperty("_Line1_9")]
	private Label __Line1_9;

	[AccessedThroughProperty("_Line1_8")]
	private Label __Line1_8;

	[AccessedThroughProperty("_Line1_5")]
	private Label __Line1_5;

	[AccessedThroughProperty("_Line1_3")]
	private Label __Line1_3;

	[AccessedThroughProperty("_Label1_41")]
	private Label __Label1_41;

	[AccessedThroughProperty("_Label1_6")]
	private Label __Label1_6;

	[AccessedThroughProperty("_Label1_5")]
	private Label __Label1_5;

	[AccessedThroughProperty("_Label1_3")]
	private Label __Label1_3;

	[AccessedThroughProperty("lblInstructions")]
	private Label _lblInstructions;

	[AccessedThroughProperty("_Label1_4")]
	private Label __Label1_4;

	[AccessedThroughProperty("_Label1_2")]
	private Label __Label1_2;

	[AccessedThroughProperty("_Label1_1")]
	private Label __Label1_1;

	[AccessedThroughProperty("_Label2_10")]
	private Label __Label2_10;

	[AccessedThroughProperty("_Label2_9")]
	private Label __Label2_9;

	[AccessedThroughProperty("_Label1_42")]
	private Label __Label1_42;

	[AccessedThroughProperty("_Label1_39")]
	private Label __Label1_39;

	[AccessedThroughProperty("_Label1_0")]
	private Label __Label1_0;

	[AccessedThroughProperty("_Label1_14")]
	private Label __Label1_14;

	[AccessedThroughProperty("_Label1_15")]
	private Label __Label1_15;

	[AccessedThroughProperty("_Label1_17")]
	private Label __Label1_17;

	[AccessedThroughProperty("_Label1_18")]
	private Label __Label1_18;

	[AccessedThroughProperty("_Label1_20")]
	private Label __Label1_20;

	[AccessedThroughProperty("_Label2_22")]
	private Label __Label2_22;

	[AccessedThroughProperty("_Label2_0")]
	private Label __Label2_0;

	[AccessedThroughProperty("_Label2_1")]
	private Label __Label2_1;

	[AccessedThroughProperty("_Label2_3")]
	private Label __Label2_3;

	[AccessedThroughProperty("_Label2_4")]
	private Label __Label2_4;

	[AccessedThroughProperty("_Label2_5")]
	private Label __Label2_5;

	[AccessedThroughProperty("_Label2_2")]
	private Label __Label2_2;

	[AccessedThroughProperty("_Label2_6")]
	private Label __Label2_6;

	[AccessedThroughProperty("_Label1_16")]
	private Label __Label1_16;

	[AccessedThroughProperty("Label1")]
	private LabelArray _Label1;

	[AccessedThroughProperty("Label2")]
	private LabelArray _Label2;

	[AccessedThroughProperty("Line1")]
	private LabelArray _Line1;

	[AccessedThroughProperty("chkQual")]
	private CheckBoxArray _chkQual;

	[AccessedThroughProperty("chkType")]
	private CheckBoxArray _chkType;

	[AccessedThroughProperty("optSolubility")]
	private RadioButtonArray _optSolubility;

	private static frmMDUpdChem m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	public virtual CheckBox _chkQual_6
	{
		[DebuggerNonUserCode]
		get
		{
			return __chkQual_6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__chkQual_6 = value;
		}
	}

	public virtual CheckBox _chkQual_5
	{
		[DebuggerNonUserCode]
		get
		{
			return __chkQual_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__chkQual_5 = value;
		}
	}

	public virtual CheckBox _chkQual_4
	{
		[DebuggerNonUserCode]
		get
		{
			return __chkQual_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__chkQual_4 = value;
		}
	}

	public virtual TextBox txtOtherQualification
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtOtherQualification;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtOtherQualification = value;
		}
	}

	public virtual CheckBox _chkQual_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __chkQual_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__chkQual_3 = value;
		}
	}

	public virtual CheckBox _chkQual_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __chkQual_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__chkQual_2 = value;
		}
	}

	public virtual CheckBox _chkQual_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __chkQual_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__chkQual_1 = value;
		}
	}

	public virtual CheckBox _chkQual_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __chkQual_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__chkQual_0 = value;
		}
	}

	public virtual RadioButton _optSolubility_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __optSolubility_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__optSolubility_0 = value;
		}
	}

	public virtual RadioButton _optSolubility_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __optSolubility_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__optSolubility_2 = value;
		}
	}

	public virtual RadioButton _optSolubility_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __optSolubility_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__optSolubility_1 = value;
		}
	}

	public virtual TextBox txtMF
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMF;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMF = value;
		}
	}

	public virtual TextBox txtLT1000
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtLT1000;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtLT1000 = value;
		}
	}

	public virtual TextBox txtLT500
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtLT500;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtLT500 = value;
		}
	}

	public virtual TextBox txtChemGenUse
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtChemGenUse;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtChemGenUse = value;
		}
	}

	public virtual TextBox txtPV
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtPV;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtPV_Leave;
			if (_txtPV != null)
			{
				((Control)_txtPV).Leave -= eventHandler;
			}
			_txtPV = value;
			if (_txtPV != null)
			{
				((Control)_txtPV).Leave += eventHandler;
			}
		}
	}

	public virtual TextBox txtTradeNames
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTradeNames;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtTradeNames = value;
		}
	}

	public virtual TextBox txtChemCat
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtChemCat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtChemCat = value;
		}
	}

	public virtual TextBox txtChemName
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtChemName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtChemName = value;
		}
	}

	public virtual TextBox txtPVi
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtPVi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtPVi_Leave;
			if (_txtPVi != null)
			{
				((Control)_txtPVi).Leave -= eventHandler;
			}
			_txtPVi = value;
			if (_txtPVi != null)
			{
				((Control)_txtPVi).Leave += eventHandler;
			}
		}
	}

	public virtual TextBox txtPVd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtPVd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtPVd_Leave;
			EventHandler eventHandler2 = txtPVd_TextChanged;
			if (_txtPVd != null)
			{
				((Control)_txtPVd).Leave -= eventHandler;
				((Control)_txtPVd).TextChanged -= eventHandler2;
			}
			_txtPVd = value;
			if (_txtPVd != null)
			{
				((Control)_txtPVd).Leave += eventHandler;
				((Control)_txtPVd).TextChanged += eventHandler2;
			}
		}
	}

	public virtual TextBox txtCas
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtCas;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtCas = value;
		}
	}

	public virtual TextBox txtVP
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtVP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtVP_Leave;
			if (_txtVP != null)
			{
				((Control)_txtVP).Leave -= eventHandler;
			}
			_txtVP = value;
			if (_txtVP != null)
			{
				((Control)_txtVP).Leave += eventHandler;
			}
		}
	}

	public virtual TextBox txtMW
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMW;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtMW_Leave;
			if (_txtMW != null)
			{
				((Control)_txtMW).Leave -= eventHandler;
			}
			_txtMW = value;
			if (_txtMW != null)
			{
				((Control)_txtMW).Leave += eventHandler;
			}
		}
	}

	public virtual TextBox txtDen
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDen;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtDen_Leave;
			if (_txtDen != null)
			{
				((Control)_txtDen).Leave -= eventHandler;
			}
			_txtDen = value;
			if (_txtDen != null)
			{
				((Control)_txtDen).Leave += eventHandler;
			}
		}
	}

	public virtual TextBox txtSol
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSol;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtSol_Leave;
			if (_txtSol != null)
			{
				((Control)_txtSol).Leave -= eventHandler;
			}
			_txtSol = value;
			if (_txtSol != null)
			{
				((Control)_txtSol).Leave += eventHandler;
			}
		}
	}

	public virtual TextBox txtSolTemp
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSolTemp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSolTemp = value;
		}
	}

	public virtual TextBox txtDenTemp
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDenTemp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDenTemp = value;
		}
	}

	public virtual TextBox txtVPTemp
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtVPTemp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtVPTemp = value;
		}
	}

	public virtual CheckBox _chkType_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __chkType_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__chkType_0 = value;
		}
	}

	public virtual CheckBox _chkType_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __chkType_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__chkType_1 = value;
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

	public virtual Label _Line1_11
	{
		[DebuggerNonUserCode]
		get
		{
			return __Line1_11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Line1_11 = value;
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

	public virtual Label _Line1_8
	{
		[DebuggerNonUserCode]
		get
		{
			return __Line1_8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Line1_8 = value;
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

	public virtual Label _Label1_41
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_41;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_41 = value;
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

	public virtual Label _Label2_10
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label2_10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label2_10 = value;
		}
	}

	public virtual Label _Label2_9
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label2_9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label2_9 = value;
		}
	}

	public virtual Label _Label1_42
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_42;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_42 = value;
		}
	}

	public virtual Label _Label1_39
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_39;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_39 = value;
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

	public virtual Label _Label1_14
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_14 = value;
		}
	}

	public virtual Label _Label1_15
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_15 = value;
		}
	}

	public virtual Label _Label1_17
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_17 = value;
		}
	}

	public virtual Label _Label1_18
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_18 = value;
		}
	}

	public virtual Label _Label1_20
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_20 = value;
		}
	}

	public virtual Label _Label2_22
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label2_22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label2_22 = value;
		}
	}

	public virtual Label _Label2_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label2_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label2_0 = value;
		}
	}

	public virtual Label _Label2_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label2_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label2_1 = value;
		}
	}

	public virtual Label _Label2_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label2_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label2_3 = value;
		}
	}

	public virtual Label _Label2_4
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label2_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label2_4 = value;
		}
	}

	public virtual Label _Label2_5
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label2_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label2_5 = value;
		}
	}

	public virtual Label _Label2_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label2_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label2_2 = value;
		}
	}

	public virtual Label _Label2_6
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label2_6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label2_6 = value;
		}
	}

	public virtual Label _Label1_16
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_16 = value;
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

	public virtual LabelArray Label2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label2 = value;
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

	public virtual CheckBoxArray chkQual
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkQual;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = chkQual_CheckStateChanged;
			if (_chkQual != null)
			{
				_chkQual.CheckStateChanged -= eventHandler;
			}
			_chkQual = value;
			if (_chkQual != null)
			{
				_chkQual.CheckStateChanged += eventHandler;
			}
		}
	}

	public virtual CheckBoxArray chkType
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkType;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkType = value;
		}
	}

	public virtual RadioButtonArray optSolubility
	{
		[DebuggerNonUserCode]
		get
		{
			return _optSolubility;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = optSolubility_CheckedChanged;
			if (_optSolubility != null)
			{
				_optSolubility.CheckedChanged -= eventHandler;
			}
			_optSolubility = value;
			if (_optSolubility != null)
			{
				_optSolubility.CheckedChanged += eventHandler;
			}
		}
	}

	public static frmMDUpdChem DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmMDUpdChem();
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

	public frmMDUpdChem()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		((Form)this).FormClosing += new FormClosingEventHandler(frmMDUpdChem_FormClosing);
		((Form)this).Load += frmMDUpdChem_Load;
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
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected O, but got Unknown
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Expected O, but got Unknown
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected O, but got Unknown
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected O, but got Unknown
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Expected O, but got Unknown
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Expected O, but got Unknown
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Expected O, but got Unknown
		//IL_0441: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Expected O, but got Unknown
		//IL_0535: Unknown result type (might be due to invalid IL or missing references)
		//IL_053f: Expected O, but got Unknown
		//IL_0629: Unknown result type (might be due to invalid IL or missing references)
		//IL_0633: Expected O, but got Unknown
		//IL_0737: Unknown result type (might be due to invalid IL or missing references)
		//IL_0741: Expected O, but got Unknown
		//IL_080b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0815: Expected O, but got Unknown
		//IL_08ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0909: Expected O, but got Unknown
		//IL_09f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fd: Expected O, but got Unknown
		//IL_0ae7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af1: Expected O, but got Unknown
		//IL_0bdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be5: Expected O, but got Unknown
		//IL_0cbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc8: Expected O, but got Unknown
		//IL_0db2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbc: Expected O, but got Unknown
		//IL_0eb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ebd: Expected O, but got Unknown
		//IL_0f83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8d: Expected O, but got Unknown
		//IL_1053: Unknown result type (might be due to invalid IL or missing references)
		//IL_105d: Expected O, but got Unknown
		//IL_1123: Unknown result type (might be due to invalid IL or missing references)
		//IL_112d: Expected O, but got Unknown
		//IL_1210: Unknown result type (might be due to invalid IL or missing references)
		//IL_121a: Expected O, but got Unknown
		//IL_12df: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e9: Expected O, but got Unknown
		//IL_13b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_13bc: Expected O, but got Unknown
		//IL_1485: Unknown result type (might be due to invalid IL or missing references)
		//IL_148f: Expected O, but got Unknown
		//IL_1558: Unknown result type (might be due to invalid IL or missing references)
		//IL_1562: Expected O, but got Unknown
		//IL_1628: Unknown result type (might be due to invalid IL or missing references)
		//IL_1632: Expected O, but got Unknown
		//IL_16f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1702: Expected O, but got Unknown
		//IL_17c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_17cf: Expected O, but got Unknown
		//IL_1895: Unknown result type (might be due to invalid IL or missing references)
		//IL_189f: Expected O, but got Unknown
		//IL_1965: Unknown result type (might be due to invalid IL or missing references)
		//IL_196f: Expected O, but got Unknown
		//IL_1a35: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a3f: Expected O, but got Unknown
		//IL_1b05: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b0f: Expected O, but got Unknown
		//IL_1bd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bdf: Expected O, but got Unknown
		//IL_1ca5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1caf: Expected O, but got Unknown
		//IL_1d68: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d72: Expected O, but got Unknown
		//IL_1e4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e58: Expected O, but got Unknown
		//IL_1f42: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f4c: Expected O, but got Unknown
		//IL_2016: Unknown result type (might be due to invalid IL or missing references)
		//IL_2020: Expected O, but got Unknown
		//IL_244e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2458: Expected O, but got Unknown
		//IL_2533: Unknown result type (might be due to invalid IL or missing references)
		//IL_253d: Expected O, but got Unknown
		//IL_261a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2624: Expected O, but got Unknown
		//IL_2701: Unknown result type (might be due to invalid IL or missing references)
		//IL_270b: Expected O, but got Unknown
		//IL_27e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_27ef: Expected O, but got Unknown
		//IL_28a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_28b1: Expected O, but got Unknown
		//IL_298a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2994: Expected O, but got Unknown
		//IL_2a6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a77: Expected O, but got Unknown
		//IL_2b50: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b5a: Expected O, but got Unknown
		//IL_2c2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c35: Expected O, but got Unknown
		//IL_2d06: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d10: Expected O, but got Unknown
		//IL_2dee: Unknown result type (might be due to invalid IL or missing references)
		//IL_2df8: Expected O, but got Unknown
		//IL_2ed6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ee0: Expected O, but got Unknown
		//IL_2fb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fc3: Expected O, but got Unknown
		//IL_30a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_30aa: Expected O, but got Unknown
		//IL_3188: Unknown result type (might be due to invalid IL or missing references)
		//IL_3192: Expected O, but got Unknown
		//IL_3270: Unknown result type (might be due to invalid IL or missing references)
		//IL_327a: Expected O, but got Unknown
		//IL_3358: Unknown result type (might be due to invalid IL or missing references)
		//IL_3362: Expected O, but got Unknown
		//IL_3440: Unknown result type (might be due to invalid IL or missing references)
		//IL_344a: Expected O, but got Unknown
		//IL_351b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3525: Expected O, but got Unknown
		//IL_35f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_35ff: Expected O, but got Unknown
		//IL_36cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_36d9: Expected O, but got Unknown
		//IL_37a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_37b3: Expected O, but got Unknown
		//IL_3883: Unknown result type (might be due to invalid IL or missing references)
		//IL_388d: Expected O, but got Unknown
		//IL_395d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3967: Expected O, but got Unknown
		//IL_3a37: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a41: Expected O, but got Unknown
		//IL_3b11: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b1b: Expected O, but got Unknown
		//IL_40d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_40e3: Expected O, but got Unknown
		//IL_40f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_4102: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMDUpdChem));
		ToolTip1 = new ToolTip(components);
		_chkQual_6 = new CheckBox();
		_chkQual_5 = new CheckBox();
		_chkQual_4 = new CheckBox();
		txtOtherQualification = new TextBox();
		_chkQual_3 = new CheckBox();
		_chkQual_2 = new CheckBox();
		_chkQual_1 = new CheckBox();
		_chkQual_0 = new CheckBox();
		_optSolubility_0 = new RadioButton();
		_optSolubility_2 = new RadioButton();
		_optSolubility_1 = new RadioButton();
		txtMF = new TextBox();
		txtLT1000 = new TextBox();
		txtLT500 = new TextBox();
		txtChemGenUse = new TextBox();
		txtPV = new TextBox();
		txtTradeNames = new TextBox();
		txtChemCat = new TextBox();
		txtChemName = new TextBox();
		txtPVi = new TextBox();
		txtPVd = new TextBox();
		txtCas = new TextBox();
		txtVP = new TextBox();
		txtMW = new TextBox();
		txtDen = new TextBox();
		txtSol = new TextBox();
		txtSolTemp = new TextBox();
		txtDenTemp = new TextBox();
		txtVPTemp = new TextBox();
		_chkType_0 = new CheckBox();
		_chkType_1 = new CheckBox();
		cmdCancel = new Button();
		cmdOk = new Button();
		_Line1_12 = new Label();
		_Line1_11 = new Label();
		_Line1_10 = new Label();
		_Line1_9 = new Label();
		_Line1_8 = new Label();
		_Line1_5 = new Label();
		_Line1_3 = new Label();
		_Label1_41 = new Label();
		_Label1_6 = new Label();
		_Label1_5 = new Label();
		_Label1_3 = new Label();
		lblInstructions = new Label();
		_Label1_4 = new Label();
		_Label1_2 = new Label();
		_Label1_1 = new Label();
		_Label2_10 = new Label();
		_Label2_9 = new Label();
		_Label1_42 = new Label();
		_Label1_39 = new Label();
		_Label1_0 = new Label();
		_Label1_14 = new Label();
		_Label1_15 = new Label();
		_Label1_17 = new Label();
		_Label1_18 = new Label();
		_Label1_20 = new Label();
		_Label2_22 = new Label();
		_Label2_0 = new Label();
		_Label2_1 = new Label();
		_Label2_3 = new Label();
		_Label2_4 = new Label();
		_Label2_5 = new Label();
		_Label2_2 = new Label();
		_Label2_6 = new Label();
		_Label1_16 = new Label();
		Label1 = new LabelArray(components);
		Label2 = new LabelArray(components);
		Line1 = new LabelArray(components);
		chkQual = new CheckBoxArray(components);
		chkType = new CheckBoxArray(components);
		optSolubility = new RadioButtonArray(components);
		((ISupportInitialize)Label1).BeginInit();
		((ISupportInitialize)Label2).BeginInit();
		((ISupportInitialize)Line1).BeginInit();
		((ISupportInitialize)chkQual).BeginInit();
		((ISupportInitialize)chkType).BeginInit();
		((ISupportInitialize)optSolubility).BeginInit();
		((Control)this).SuspendLayout();
		((ButtonBase)_chkQual_6).BackColor = SystemColors.Control;
		((Control)_chkQual_6).Cursor = Cursors.Default;
		((Control)_chkQual_6).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_chkQual_6).ForeColor = SystemColors.ControlText;
		chkQual.SetIndex(_chkQual_6, (short)6);
		CheckBox chkQual_ = _chkQual_6;
		Point location = new Point(488, 192);
		((Control)chkQual_).Location = location;
		((Control)_chkQual_6).Name = "_chkQual_6";
		((Control)_chkQual_6).RightToLeft = (RightToLeft)0;
		CheckBox chkQual_2 = _chkQual_6;
		Size size = new Size(89, 17);
		((Control)chkQual_2).Size = size;
		((Control)_chkQual_6).TabIndex = 15;
		((ButtonBase)_chkQual_6).Text = "Binding PV";
		((ButtonBase)_chkQual_6).UseVisualStyleBackColor = false;
		((Control)_chkQual_6).Visible = false;
		((ButtonBase)_chkQual_5).BackColor = SystemColors.Control;
		((Control)_chkQual_5).Cursor = Cursors.Default;
		((Control)_chkQual_5).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_chkQual_5).ForeColor = SystemColors.ControlText;
		chkQual.SetIndex(_chkQual_5, (short)5);
		CheckBox chkQual_3 = _chkQual_5;
		location = new Point(488, 168);
		((Control)chkQual_3).Location = location;
		((Control)_chkQual_5).Name = "_chkQual_5";
		((Control)_chkQual_5).RightToLeft = (RightToLeft)0;
		CheckBox chkQual_4 = _chkQual_5;
		size = new Size(89, 17);
		((Control)chkQual_4).Size = size;
		((Control)_chkQual_5).TabIndex = 13;
		((ButtonBase)_chkQual_5).Text = "P2REC-DR";
		((ButtonBase)_chkQual_5).UseVisualStyleBackColor = false;
		((Control)_chkQual_5).Visible = false;
		((ButtonBase)_chkQual_4).BackColor = SystemColors.Control;
		((Control)_chkQual_4).Cursor = Cursors.Default;
		((Control)_chkQual_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_chkQual_4).ForeColor = SystemColors.ControlText;
		chkQual.SetIndex(_chkQual_4, (short)4);
		CheckBox chkQual_5 = _chkQual_4;
		location = new Point(488, 144);
		((Control)chkQual_5).Location = location;
		((Control)_chkQual_4).Name = "_chkQual_4";
		((Control)_chkQual_4).RightToLeft = (RightToLeft)0;
		CheckBox chkQual_6 = _chkQual_4;
		size = new Size(89, 17);
		((Control)chkQual_6).Size = size;
		((Control)_chkQual_4).TabIndex = 11;
		((ButtonBase)_chkQual_4).Text = "P2REC";
		((ButtonBase)_chkQual_4).UseVisualStyleBackColor = false;
		((Control)_chkQual_4).Visible = false;
		txtOtherQualification.AcceptsReturn = true;
		((TextBoxBase)txtOtherQualification).BackColor = SystemColors.Control;
		((Control)txtOtherQualification).Cursor = Cursors.IBeam;
		((Control)txtOtherQualification).Enabled = false;
		((Control)txtOtherQualification).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtOtherQualification).ForeColor = SystemColors.WindowText;
		TextBox obj = txtOtherQualification;
		location = new Point(488, 216);
		((Control)obj).Location = location;
		((TextBoxBase)txtOtherQualification).MaxLength = 100;
		((Control)txtOtherQualification).Name = "txtOtherQualification";
		((Control)txtOtherQualification).RightToLeft = (RightToLeft)0;
		TextBox obj2 = txtOtherQualification;
		size = new Size(185, 20);
		((Control)obj2).Size = size;
		((Control)txtOtherQualification).TabIndex = 17;
		((Control)txtOtherQualification).Visible = false;
		((ButtonBase)_chkQual_3).BackColor = SystemColors.Control;
		((Control)_chkQual_3).Cursor = Cursors.Default;
		((Control)_chkQual_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_chkQual_3).ForeColor = SystemColors.ControlText;
		chkQual.SetIndex(_chkQual_3, (short)3);
		CheckBox chkQual_7 = _chkQual_3;
		location = new Point(576, 192);
		((Control)chkQual_7).Location = location;
		((Control)_chkQual_3).Name = "_chkQual_3";
		((Control)_chkQual_3).RightToLeft = (RightToLeft)0;
		CheckBox chkQual_8 = _chkQual_3;
		size = new Size(113, 17);
		((Control)chkQual_8).Size = size;
		((Control)_chkQual_3).TabIndex = 16;
		((ButtonBase)_chkQual_3).Text = "Other Qualification";
		((ButtonBase)_chkQual_3).UseVisualStyleBackColor = false;
		((Control)_chkQual_3).Visible = false;
		((ButtonBase)_chkQual_2).BackColor = SystemColors.Control;
		((Control)_chkQual_2).Cursor = Cursors.Default;
		((Control)_chkQual_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_chkQual_2).ForeColor = SystemColors.ControlText;
		chkQual.SetIndex(_chkQual_2, (short)2);
		CheckBox chkQual_9 = _chkQual_2;
		location = new Point(408, 144);
		((Control)chkQual_9).Location = location;
		((Control)_chkQual_2).Name = "_chkQual_2";
		((Control)_chkQual_2).RightToLeft = (RightToLeft)0;
		CheckBox chkQual_10 = _chkQual_2;
		size = new Size(89, 17);
		((Control)chkQual_10).Size = size;
		((Control)_chkQual_2).TabIndex = 14;
		((ButtonBase)_chkQual_2).Text = "C.O.S.";
		((ButtonBase)_chkQual_2).UseVisualStyleBackColor = false;
		((Control)_chkQual_2).Visible = false;
		((ButtonBase)_chkQual_1).BackColor = SystemColors.Control;
		((Control)_chkQual_1).Cursor = Cursors.Default;
		((Control)_chkQual_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_chkQual_1).ForeColor = SystemColors.ControlText;
		chkQual.SetIndex(_chkQual_1, (short)1);
		CheckBox chkQual_11 = _chkQual_1;
		location = new Point(624, 160);
		((Control)chkQual_11).Location = location;
		((Control)_chkQual_1).Name = "_chkQual_1";
		((Control)_chkQual_1).RightToLeft = (RightToLeft)0;
		CheckBox chkQual_12 = _chkQual_1;
		size = new Size(49, 17);
		((Control)chkQual_12).Size = size;
		((Control)_chkQual_1).TabIndex = 12;
		((ButtonBase)_chkQual_1).Text = "NX";
		((ButtonBase)_chkQual_1).UseVisualStyleBackColor = false;
		((Control)_chkQual_1).Visible = false;
		((ButtonBase)_chkQual_0).BackColor = SystemColors.Control;
		((Control)_chkQual_0).Cursor = Cursors.Default;
		((Control)_chkQual_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_chkQual_0).ForeColor = SystemColors.ControlText;
		chkQual.SetIndex(_chkQual_0, (short)0);
		CheckBox chkQual_13 = _chkQual_0;
		location = new Point(624, 144);
		((Control)chkQual_13).Location = location;
		((Control)_chkQual_0).Name = "_chkQual_0";
		((Control)_chkQual_0).RightToLeft = (RightToLeft)0;
		CheckBox chkQual_14 = _chkQual_0;
		size = new Size(49, 17);
		((Control)chkQual_14).Size = size;
		((Control)_chkQual_0).TabIndex = 10;
		((ButtonBase)_chkQual_0).Text = "YX";
		((ButtonBase)_chkQual_0).UseVisualStyleBackColor = false;
		((Control)_chkQual_0).Visible = false;
		((ButtonBase)_optSolubility_0).BackColor = SystemColors.Control;
		((Control)_optSolubility_0).Cursor = Cursors.Default;
		((Control)_optSolubility_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optSolubility_0).ForeColor = SystemColors.ControlText;
		optSolubility.SetIndex(_optSolubility_0, (short)0);
		RadioButton optSolubility_ = _optSolubility_0;
		location = new Point(192, 344);
		((Control)optSolubility_).Location = location;
		((Control)_optSolubility_0).Name = "_optSolubility_0";
		((Control)_optSolubility_0).RightToLeft = (RightToLeft)0;
		RadioButton optSolubility_2 = _optSolubility_0;
		size = new Size(25, 17);
		((Control)optSolubility_2).Size = size;
		((Control)_optSolubility_0).TabIndex = 25;
		_optSolubility_0.TabStop = true;
		((ButtonBase)_optSolubility_0).UseVisualStyleBackColor = false;
		((ButtonBase)_optSolubility_2).BackColor = SystemColors.Control;
		((Control)_optSolubility_2).Cursor = Cursors.Default;
		((Control)_optSolubility_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optSolubility_2).ForeColor = SystemColors.ControlText;
		optSolubility.SetIndex(_optSolubility_2, (short)2);
		RadioButton optSolubility_3 = _optSolubility_2;
		location = new Point(536, 344);
		((Control)optSolubility_3).Location = location;
		((Control)_optSolubility_2).Name = "_optSolubility_2";
		((Control)_optSolubility_2).RightToLeft = (RightToLeft)0;
		RadioButton optSolubility_4 = _optSolubility_2;
		size = new Size(121, 17);
		((Control)optSolubility_4).Size = size;
		((Control)_optSolubility_2).TabIndex = 29;
		_optSolubility_2.TabStop = true;
		((ButtonBase)_optSolubility_2).Text = "Reacts";
		((ButtonBase)_optSolubility_2).UseVisualStyleBackColor = false;
		((ButtonBase)_optSolubility_1).BackColor = SystemColors.Control;
		((Control)_optSolubility_1).Cursor = Cursors.Default;
		((Control)_optSolubility_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optSolubility_1).ForeColor = SystemColors.ControlText;
		optSolubility.SetIndex(_optSolubility_1, (short)1);
		RadioButton optSolubility_5 = _optSolubility_1;
		location = new Point(432, 344);
		((Control)optSolubility_5).Location = location;
		((Control)_optSolubility_1).Name = "_optSolubility_1";
		((Control)_optSolubility_1).RightToLeft = (RightToLeft)0;
		RadioButton optSolubility_6 = _optSolubility_1;
		size = new Size(89, 17);
		((Control)optSolubility_6).Size = size;
		((Control)_optSolubility_1).TabIndex = 28;
		_optSolubility_1.TabStop = true;
		((ButtonBase)_optSolubility_1).Text = "Dispersible";
		((ButtonBase)_optSolubility_1).UseVisualStyleBackColor = false;
		txtMF.AcceptsReturn = true;
		((TextBoxBase)txtMF).BackColor = Color.White;
		((Control)txtMF).Cursor = Cursors.IBeam;
		((Control)txtMF).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtMF).ForeColor = SystemColors.WindowText;
		TextBox obj3 = txtMF;
		location = new Point(360, 112);
		((Control)obj3).Location = location;
		((TextBoxBase)txtMF).MaxLength = 100;
		((Control)txtMF).Name = "txtMF";
		((Control)txtMF).RightToLeft = (RightToLeft)0;
		TextBox obj4 = txtMF;
		size = new Size(313, 20);
		((Control)obj4).Size = size;
		((Control)txtMF).TabIndex = 4;
		txtLT1000.AcceptsReturn = true;
		((TextBoxBase)txtLT1000).BackColor = Color.White;
		((Control)txtLT1000).Cursor = Cursors.IBeam;
		((Control)txtLT1000).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtLT1000).ForeColor = SystemColors.WindowText;
		TextBox obj5 = txtLT1000;
		location = new Point(512, 280);
		((Control)obj5).Location = location;
		((TextBoxBase)txtLT1000).MaxLength = 5;
		((Control)txtLT1000).Name = "txtLT1000";
		((Control)txtLT1000).RightToLeft = (RightToLeft)0;
		TextBox obj6 = txtLT1000;
		size = new Size(33, 20);
		((Control)obj6).Size = size;
		((Control)txtLT1000).TabIndex = 22;
		txtLT500.AcceptsReturn = true;
		((TextBoxBase)txtLT500).BackColor = Color.White;
		((Control)txtLT500).Cursor = Cursors.IBeam;
		((Control)txtLT500).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtLT500).ForeColor = SystemColors.WindowText;
		TextBox obj7 = txtLT500;
		location = new Point(408, 280);
		((Control)obj7).Location = location;
		((TextBoxBase)txtLT500).MaxLength = 5;
		((Control)txtLT500).Name = "txtLT500";
		((Control)txtLT500).RightToLeft = (RightToLeft)0;
		TextBox obj8 = txtLT500;
		size = new Size(33, 20);
		((Control)obj8).Size = size;
		((Control)txtLT500).TabIndex = 21;
		txtChemGenUse.AcceptsReturn = true;
		((TextBoxBase)txtChemGenUse).BackColor = Color.White;
		((Control)txtChemGenUse).Cursor = Cursors.IBeam;
		((Control)txtChemGenUse).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtChemGenUse).ForeColor = SystemColors.WindowText;
		TextBox obj9 = txtChemGenUse;
		location = new Point(128, 392);
		((Control)obj9).Location = location;
		((TextBoxBase)txtChemGenUse).MaxLength = 0;
		txtChemGenUse.Multiline = true;
		((Control)txtChemGenUse).Name = "txtChemGenUse";
		((Control)txtChemGenUse).RightToLeft = (RightToLeft)0;
		txtChemGenUse.ScrollBars = (ScrollBars)2;
		TextBox obj10 = txtChemGenUse;
		size = new Size(545, 43);
		((Control)obj10).Size = size;
		((Control)txtChemGenUse).TabIndex = 30;
		txtPV.AcceptsReturn = true;
		((TextBoxBase)txtPV).BackColor = Color.White;
		((Control)txtPV).Cursor = Cursors.IBeam;
		((Control)txtPV).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtPV).ForeColor = SystemColors.WindowText;
		TextBox obj11 = txtPV;
		location = new Point(256, 192);
		((Control)obj11).Location = location;
		((TextBoxBase)txtPV).MaxLength = 0;
		((Control)txtPV).Name = "txtPV";
		((Control)txtPV).RightToLeft = (RightToLeft)0;
		TextBox obj12 = txtPV;
		size = new Size(81, 20);
		((Control)obj12).Size = size;
		((Control)txtPV).TabIndex = 7;
		txtTradeNames.AcceptsReturn = true;
		((TextBoxBase)txtTradeNames).BackColor = Color.White;
		((Control)txtTradeNames).Cursor = Cursors.IBeam;
		((Control)txtTradeNames).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtTradeNames).ForeColor = SystemColors.WindowText;
		TextBox obj13 = txtTradeNames;
		location = new Point(144, 88);
		((Control)obj13).Location = location;
		((TextBoxBase)txtTradeNames).MaxLength = 255;
		((Control)txtTradeNames).Name = "txtTradeNames";
		((Control)txtTradeNames).RightToLeft = (RightToLeft)0;
		TextBox obj14 = txtTradeNames;
		size = new Size(529, 20);
		((Control)obj14).Size = size;
		((Control)txtTradeNames).TabIndex = 2;
		txtChemCat.AcceptsReturn = true;
		((TextBoxBase)txtChemCat).BackColor = Color.White;
		((Control)txtChemCat).Cursor = Cursors.IBeam;
		((Control)txtChemCat).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtChemCat).ForeColor = SystemColors.WindowText;
		TextBox obj15 = txtChemCat;
		location = new Point(144, 64);
		((Control)obj15).Location = location;
		((TextBoxBase)txtChemCat).MaxLength = 255;
		((Control)txtChemCat).Name = "txtChemCat";
		((Control)txtChemCat).RightToLeft = (RightToLeft)0;
		TextBox obj16 = txtChemCat;
		size = new Size(529, 20);
		((Control)obj16).Size = size;
		((Control)txtChemCat).TabIndex = 1;
		txtChemName.AcceptsReturn = true;
		((TextBoxBase)txtChemName).BackColor = Color.White;
		((Control)txtChemName).Cursor = Cursors.IBeam;
		((Control)txtChemName).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtChemName).ForeColor = SystemColors.WindowText;
		TextBox obj17 = txtChemName;
		location = new Point(144, 40);
		((Control)obj17).Location = location;
		((TextBoxBase)txtChemName).MaxLength = 255;
		((Control)txtChemName).Name = "txtChemName";
		((Control)txtChemName).RightToLeft = (RightToLeft)0;
		TextBox obj18 = txtChemName;
		size = new Size(529, 20);
		((Control)obj18).Size = size;
		((Control)txtChemName).TabIndex = 0;
		txtPVi.AcceptsReturn = true;
		((TextBoxBase)txtPVi).BackColor = Color.White;
		((Control)txtPVi).Cursor = Cursors.IBeam;
		((Control)txtPVi).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtPVi).ForeColor = SystemColors.WindowText;
		TextBox obj19 = txtPVi;
		location = new Point(256, 168);
		((Control)obj19).Location = location;
		((TextBoxBase)txtPVi).MaxLength = 9;
		((Control)txtPVi).Name = "txtPVi";
		((Control)txtPVi).RightToLeft = (RightToLeft)0;
		TextBox obj20 = txtPVi;
		size = new Size(81, 20);
		((Control)obj20).Size = size;
		((Control)txtPVi).TabIndex = 6;
		txtPVd.AcceptsReturn = true;
		((TextBoxBase)txtPVd).BackColor = Color.White;
		((Control)txtPVd).Cursor = Cursors.IBeam;
		((Control)txtPVd).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtPVd).ForeColor = SystemColors.WindowText;
		TextBox obj21 = txtPVd;
		location = new Point(256, 144);
		((Control)obj21).Location = location;
		((TextBoxBase)txtPVd).MaxLength = 9;
		((Control)txtPVd).Name = "txtPVd";
		((Control)txtPVd).RightToLeft = (RightToLeft)0;
		TextBox obj22 = txtPVd;
		size = new Size(81, 20);
		((Control)obj22).Size = size;
		((Control)txtPVd).TabIndex = 5;
		txtCas.AcceptsReturn = true;
		((TextBoxBase)txtCas).BackColor = Color.White;
		((Control)txtCas).Cursor = Cursors.IBeam;
		((Control)txtCas).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtCas).ForeColor = SystemColors.WindowText;
		TextBox obj23 = txtCas;
		location = new Point(144, 112);
		((Control)obj23).Location = location;
		((TextBoxBase)txtCas).MaxLength = 20;
		((Control)txtCas).Name = "txtCas";
		((Control)txtCas).RightToLeft = (RightToLeft)0;
		TextBox obj24 = txtCas;
		size = new Size(97, 20);
		((Control)obj24).Size = size;
		((Control)txtCas).TabIndex = 3;
		txtVP.AcceptsReturn = true;
		((TextBoxBase)txtVP).BackColor = Color.White;
		((Control)txtVP).Cursor = Cursors.IBeam;
		((Control)txtVP).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtVP).ForeColor = SystemColors.WindowText;
		TextBox obj25 = txtVP;
		location = new Point(208, 256);
		((Control)obj25).Location = location;
		((TextBoxBase)txtVP).MaxLength = 0;
		((Control)txtVP).Name = "txtVP";
		((Control)txtVP).RightToLeft = (RightToLeft)0;
		TextBox obj26 = txtVP;
		size = new Size(81, 20);
		((Control)obj26).Size = size;
		((Control)txtVP).TabIndex = 18;
		txtMW.AcceptsReturn = true;
		((TextBoxBase)txtMW).BackColor = Color.White;
		((Control)txtMW).Cursor = Cursors.IBeam;
		((Control)txtMW).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtMW).ForeColor = SystemColors.WindowText;
		TextBox obj27 = txtMW;
		location = new Point(208, 280);
		((Control)obj27).Location = location;
		((TextBoxBase)txtMW).MaxLength = 0;
		((Control)txtMW).Name = "txtMW";
		((Control)txtMW).RightToLeft = (RightToLeft)0;
		TextBox obj28 = txtMW;
		size = new Size(81, 20);
		((Control)obj28).Size = size;
		((Control)txtMW).TabIndex = 20;
		txtDen.AcceptsReturn = true;
		((TextBoxBase)txtDen).BackColor = Color.White;
		((Control)txtDen).Cursor = Cursors.IBeam;
		((Control)txtDen).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtDen).ForeColor = SystemColors.WindowText;
		TextBox obj29 = txtDen;
		location = new Point(208, 304);
		((Control)obj29).Location = location;
		((TextBoxBase)txtDen).MaxLength = 0;
		((Control)txtDen).Name = "txtDen";
		((Control)txtDen).RightToLeft = (RightToLeft)0;
		TextBox obj30 = txtDen;
		size = new Size(81, 20);
		((Control)obj30).Size = size;
		((Control)txtDen).TabIndex = 23;
		txtSol.AcceptsReturn = true;
		((TextBoxBase)txtSol).BackColor = Color.White;
		((Control)txtSol).Cursor = Cursors.IBeam;
		((Control)txtSol).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtSol).ForeColor = SystemColors.WindowText;
		TextBox obj31 = txtSol;
		location = new Point(224, 344);
		((Control)obj31).Location = location;
		((TextBoxBase)txtSol).MaxLength = 0;
		((Control)txtSol).Name = "txtSol";
		((Control)txtSol).RightToLeft = (RightToLeft)0;
		TextBox obj32 = txtSol;
		size = new Size(81, 20);
		((Control)obj32).Size = size;
		((Control)txtSol).TabIndex = 26;
		txtSolTemp.AcceptsReturn = true;
		((TextBoxBase)txtSolTemp).BackColor = Color.White;
		((Control)txtSolTemp).Cursor = Cursors.IBeam;
		((Control)txtSolTemp).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtSolTemp).ForeColor = SystemColors.WindowText;
		TextBox obj33 = txtSolTemp;
		location = new Point(352, 344);
		((Control)obj33).Location = location;
		((TextBoxBase)txtSolTemp).MaxLength = 5;
		((Control)txtSolTemp).Name = "txtSolTemp";
		((Control)txtSolTemp).RightToLeft = (RightToLeft)0;
		TextBox obj34 = txtSolTemp;
		size = new Size(33, 20);
		((Control)obj34).Size = size;
		((Control)txtSolTemp).TabIndex = 27;
		txtDenTemp.AcceptsReturn = true;
		((TextBoxBase)txtDenTemp).BackColor = Color.White;
		((Control)txtDenTemp).Cursor = Cursors.IBeam;
		((Control)txtDenTemp).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtDenTemp).ForeColor = SystemColors.WindowText;
		TextBox obj35 = txtDenTemp;
		location = new Point(352, 304);
		((Control)obj35).Location = location;
		((TextBoxBase)txtDenTemp).MaxLength = 5;
		((Control)txtDenTemp).Name = "txtDenTemp";
		((Control)txtDenTemp).RightToLeft = (RightToLeft)0;
		TextBox obj36 = txtDenTemp;
		size = new Size(33, 20);
		((Control)obj36).Size = size;
		((Control)txtDenTemp).TabIndex = 24;
		txtVPTemp.AcceptsReturn = true;
		((TextBoxBase)txtVPTemp).BackColor = Color.White;
		((Control)txtVPTemp).Cursor = Cursors.IBeam;
		((Control)txtVPTemp).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtVPTemp).ForeColor = SystemColors.WindowText;
		TextBox obj37 = txtVPTemp;
		location = new Point(336, 256);
		((Control)obj37).Location = location;
		((TextBoxBase)txtVPTemp).MaxLength = 5;
		((Control)txtVPTemp).Name = "txtVPTemp";
		((Control)txtVPTemp).RightToLeft = (RightToLeft)0;
		TextBox obj38 = txtVPTemp;
		size = new Size(33, 20);
		((Control)obj38).Size = size;
		((Control)txtVPTemp).TabIndex = 19;
		((ButtonBase)_chkType_0).BackColor = SystemColors.Control;
		((Control)_chkType_0).Cursor = Cursors.Default;
		((Control)_chkType_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_chkType_0).ForeColor = SystemColors.ControlText;
		chkType.SetIndex(_chkType_0, (short)0);
		CheckBox chkType_ = _chkType_0;
		location = new Point(152, 216);
		((Control)chkType_).Location = location;
		((Control)_chkType_0).Name = "_chkType_0";
		((Control)_chkType_0).RightToLeft = (RightToLeft)0;
		CheckBox chkType_2 = _chkType_0;
		size = new Size(97, 17);
		((Control)chkType_2).Size = size;
		((Control)_chkType_0).TabIndex = 8;
		((ButtonBase)_chkType_0).Text = "Manufacturing";
		((ButtonBase)_chkType_0).UseVisualStyleBackColor = false;
		((ButtonBase)_chkType_1).BackColor = SystemColors.Control;
		((Control)_chkType_1).Cursor = Cursors.Default;
		((Control)_chkType_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_chkType_1).ForeColor = SystemColors.ControlText;
		chkType.SetIndex(_chkType_1, (short)1);
		CheckBox chkType_3 = _chkType_1;
		location = new Point(256, 216);
		((Control)chkType_3).Location = location;
		((Control)_chkType_1).Name = "_chkType_1";
		((Control)_chkType_1).RightToLeft = (RightToLeft)0;
		CheckBox chkType_4 = _chkType_1;
		size = new Size(89, 17);
		((Control)chkType_4).Size = size;
		((Control)_chkType_1).TabIndex = 9;
		((ButtonBase)_chkType_1).Text = "Import";
		((ButtonBase)_chkType_1).UseVisualStyleBackColor = false;
		((ButtonBase)cmdCancel).BackColor = SystemColors.Control;
		((Control)cmdCancel).Cursor = Cursors.Default;
		cmdCancel.DialogResult = (DialogResult)2;
		((Control)cmdCancel).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCancel).ForeColor = SystemColors.ControlText;
		Button obj39 = cmdCancel;
		location = new Point(352, 464);
		((Control)obj39).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		((Control)cmdCancel).RightToLeft = (RightToLeft)0;
		Button obj40 = cmdCancel;
		size = new Size(81, 25);
		((Control)obj40).Size = size;
		((Control)cmdCancel).TabIndex = 32;
		((ButtonBase)cmdCancel).Text = "Cancel";
		((ButtonBase)cmdCancel).UseVisualStyleBackColor = false;
		((ButtonBase)cmdOk).BackColor = SystemColors.Control;
		((Control)cmdOk).Cursor = Cursors.Default;
		((Control)cmdOk).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdOk).ForeColor = SystemColors.ControlText;
		Button obj41 = cmdOk;
		location = new Point(256, 464);
		((Control)obj41).Location = location;
		((Control)cmdOk).Name = "cmdOk";
		((Control)cmdOk).RightToLeft = (RightToLeft)0;
		Button obj42 = cmdOk;
		size = new Size(81, 25);
		((Control)obj42).Size = size;
		((Control)cmdOk).TabIndex = 31;
		((ButtonBase)cmdOk).Text = "OK";
		((ButtonBase)cmdOk).UseVisualStyleBackColor = false;
		((Control)_Line1_12).BackColor = SystemColors.WindowText;
		Line1.SetIndex(_Line1_12, (short)12);
		Label line1_ = _Line1_12;
		location = new Point(16, 336);
		((Control)line1_).Location = location;
		((Control)_Line1_12).Name = "_Line1_12";
		Label line1_2 = _Line1_12;
		size = new Size(664, 1);
		((Control)line1_2).Size = size;
		((Control)_Line1_12).TabIndex = 33;
		((Control)_Line1_11).BackColor = SystemColors.WindowText;
		Line1.SetIndex(_Line1_11, (short)11);
		Label line1_3 = _Line1_11;
		location = new Point(680, 136);
		((Control)line1_3).Location = location;
		((Control)_Line1_11).Name = "_Line1_11";
		Label line1_4 = _Line1_11;
		size = new Size(1, 312);
		((Control)line1_4).Size = size;
		((Control)_Line1_11).TabIndex = 34;
		((Control)_Line1_10).BackColor = SystemColors.WindowText;
		Line1.SetIndex(_Line1_10, (short)10);
		Label line1_5 = _Line1_10;
		location = new Point(16, 136);
		((Control)line1_5).Location = location;
		((Control)_Line1_10).Name = "_Line1_10";
		Label line1_6 = _Line1_10;
		size = new Size(1, 312);
		((Control)line1_6).Size = size;
		((Control)_Line1_10).TabIndex = 35;
		((Control)_Line1_9).BackColor = SystemColors.WindowText;
		Line1.SetIndex(_Line1_9, (short)9);
		Label line1_7 = _Line1_9;
		location = new Point(16, 248);
		((Control)line1_7).Location = location;
		((Control)_Line1_9).Name = "_Line1_9";
		Label line1_8 = _Line1_9;
		size = new Size(664, 1);
		((Control)line1_8).Size = size;
		((Control)_Line1_9).TabIndex = 36;
		((Control)_Line1_8).BackColor = SystemColors.WindowText;
		Line1.SetIndex(_Line1_8, (short)8);
		Label line1_9 = _Line1_8;
		location = new Point(16, 136);
		((Control)line1_9).Location = location;
		((Control)_Line1_8).Name = "_Line1_8";
		Label line1_10 = _Line1_8;
		size = new Size(664, 1);
		((Control)line1_10).Size = size;
		((Control)_Line1_8).TabIndex = 37;
		((Control)_Line1_5).BackColor = SystemColors.WindowText;
		Line1.SetIndex(_Line1_5, (short)5);
		Label line1_11 = _Line1_5;
		location = new Point(16, 376);
		((Control)line1_11).Location = location;
		((Control)_Line1_5).Name = "_Line1_5";
		Label line1_12 = _Line1_5;
		size = new Size(664, 1);
		((Control)line1_12).Size = size;
		((Control)_Line1_5).TabIndex = 38;
		((Control)_Line1_3).BackColor = SystemColors.WindowText;
		Line1.SetIndex(_Line1_3, (short)3);
		Label line1_13 = _Line1_3;
		location = new Point(16, 448);
		((Control)line1_13).Location = location;
		((Control)_Line1_3).Name = "_Line1_3";
		Label line1_14 = _Line1_3;
		size = new Size(664, 1);
		((Control)line1_14).Size = size;
		((Control)_Line1_3).TabIndex = 39;
		((Control)_Label1_41).BackColor = SystemColors.Control;
		((Control)_Label1_41).Cursor = Cursors.Default;
		((Control)_Label1_41).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_41).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_41, (short)41);
		Label label1_ = _Label1_41;
		location = new Point(247, 112);
		((Control)label1_).Location = location;
		((Control)_Label1_41).Name = "_Label1_41";
		((Control)_Label1_41).RightToLeft = (RightToLeft)0;
		Label label1_2 = _Label1_41;
		size = new Size(106, 19);
		((Control)label1_2).Size = size;
		((Control)_Label1_41).TabIndex = 59;
		_Label1_41.Text = "Molecular Formula:";
		_Label1_41.TextAlign = (ContentAlignment)4;
		((Control)_Label1_6).BackColor = SystemColors.Control;
		((Control)_Label1_6).Cursor = Cursors.Default;
		((Control)_Label1_6).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_6).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_6, (short)6);
		Label label1_3 = _Label1_6;
		location = new Point(448, 280);
		((Control)label1_3).Location = location;
		((Control)_Label1_6).Name = "_Label1_6";
		((Control)_Label1_6).RightToLeft = (RightToLeft)0;
		Label label1_4 = _Label1_6;
		size = new Size(57, 19);
		((Control)label1_4).Size = size;
		((Control)_Label1_6).TabIndex = 58;
		_Label1_6.Text = "% < 1000:";
		_Label1_6.TextAlign = (ContentAlignment)4;
		((Control)_Label1_5).BackColor = SystemColors.Control;
		((Control)_Label1_5).Cursor = Cursors.Default;
		((Control)_Label1_5).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_5).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_5, (short)5);
		Label label1_5 = _Label1_5;
		location = new Point(344, 280);
		((Control)label1_5).Location = location;
		((Control)_Label1_5).Name = "_Label1_5";
		((Control)_Label1_5).RightToLeft = (RightToLeft)0;
		Label label1_6 = _Label1_5;
		size = new Size(57, 19);
		((Control)label1_6).Size = size;
		((Control)_Label1_5).TabIndex = 57;
		_Label1_5.Text = "% < 500:";
		_Label1_5.TextAlign = (ContentAlignment)4;
		((Control)_Label1_3).BackColor = SystemColors.Control;
		((Control)_Label1_3).Cursor = Cursors.Default;
		((Control)_Label1_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_3).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_3, (short)3);
		Label label1_7 = _Label1_3;
		location = new Point(24, 392);
		((Control)label1_7).Location = location;
		((Control)_Label1_3).Name = "_Label1_3";
		((Control)_Label1_3).RightToLeft = (RightToLeft)0;
		Label label1_8 = _Label1_3;
		size = new Size(97, 51);
		((Control)label1_8).Size = size;
		((Control)_Label1_3).TabIndex = 56;
		_Label1_3.Text = "General Description of End Use(s):";
		_Label1_3.TextAlign = (ContentAlignment)4;
		((Control)lblInstructions).BackColor = SystemColors.Control;
		((Control)lblInstructions).Cursor = Cursors.Default;
		((Control)lblInstructions).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblInstructions).ForeColor = SystemColors.ControlText;
		Label obj43 = lblInstructions;
		location = new Point(8, 8);
		((Control)obj43).Location = location;
		((Control)lblInstructions).Name = "lblInstructions";
		((Control)lblInstructions).RightToLeft = (RightToLeft)0;
		Label obj44 = lblInstructions;
		size = new Size(657, 25);
		((Control)obj44).Size = size;
		((Control)lblInstructions).TabIndex = 55;
		lblInstructions.Text = "xxx";
		((Control)_Label1_4).BackColor = SystemColors.Control;
		((Control)_Label1_4).Cursor = Cursors.Default;
		((Control)_Label1_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_4).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_4, (short)4);
		Label label1_9 = _Label1_4;
		location = new Point(8, 88);
		((Control)label1_9).Location = location;
		((Control)_Label1_4).Name = "_Label1_4";
		((Control)_Label1_4).RightToLeft = (RightToLeft)0;
		Label label1_10 = _Label1_4;
		size = new Size(129, 19);
		((Control)label1_10).Size = size;
		((Control)_Label1_4).TabIndex = 54;
		_Label1_4.Text = "Trade Name(s):";
		_Label1_4.TextAlign = (ContentAlignment)4;
		((Control)_Label1_2).BackColor = SystemColors.Control;
		((Control)_Label1_2).Cursor = Cursors.Default;
		((Control)_Label1_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_2).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_2, (short)2);
		Label label1_11 = _Label1_2;
		location = new Point(8, 64);
		((Control)label1_11).Location = location;
		((Control)_Label1_2).Name = "_Label1_2";
		((Control)_Label1_2).RightToLeft = (RightToLeft)0;
		Label label1_12 = _Label1_2;
		size = new Size(129, 19);
		((Control)label1_12).Size = size;
		((Control)_Label1_2).TabIndex = 53;
		_Label1_2.Text = "Chemical Category:";
		_Label1_2.TextAlign = (ContentAlignment)4;
		((Control)_Label1_1).BackColor = SystemColors.Control;
		((Control)_Label1_1).Cursor = Cursors.Default;
		((Control)_Label1_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_1).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_1, (short)1);
		Label label1_13 = _Label1_1;
		location = new Point(8, 40);
		((Control)label1_13).Location = location;
		((Control)_Label1_1).Name = "_Label1_1";
		((Control)_Label1_1).RightToLeft = (RightToLeft)0;
		Label label1_14 = _Label1_1;
		size = new Size(129, 19);
		((Control)label1_14).Size = size;
		((Control)_Label1_1).TabIndex = 52;
		_Label1_1.Text = "Chemical Name:";
		_Label1_1.TextAlign = (ContentAlignment)4;
		((Control)_Label2_10).BackColor = SystemColors.Control;
		((Control)_Label2_10).Cursor = Cursors.Default;
		((Control)_Label2_10).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label2_10).ForeColor = SystemColors.WindowText;
		Label2.SetIndex(_Label2_10, (short)10);
		Label label2_ = _Label2_10;
		location = new Point(344, 168);
		((Control)label2_).Location = location;
		((Control)_Label2_10).Name = "_Label2_10";
		((Control)_Label2_10).RightToLeft = (RightToLeft)0;
		Label label2_2 = _Label2_10;
		size = new Size(41, 19);
		((Control)label2_2).Size = size;
		((Control)_Label2_10).TabIndex = 51;
		_Label2_10.Text = " kg/yr";
		((Control)_Label2_9).BackColor = SystemColors.Control;
		((Control)_Label2_9).Cursor = Cursors.Default;
		((Control)_Label2_9).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label2_9).ForeColor = SystemColors.WindowText;
		Label2.SetIndex(_Label2_9, (short)9);
		Label label2_3 = _Label2_9;
		location = new Point(344, 144);
		((Control)label2_3).Location = location;
		((Control)_Label2_9).Name = "_Label2_9";
		((Control)_Label2_9).RightToLeft = (RightToLeft)0;
		Label label2_4 = _Label2_9;
		size = new Size(41, 19);
		((Control)label2_4).Size = size;
		((Control)_Label2_9).TabIndex = 50;
		_Label2_9.Text = " kg/yr";
		((Control)_Label1_42).BackColor = SystemColors.Control;
		((Control)_Label1_42).Cursor = Cursors.Default;
		((Control)_Label1_42).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_42).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_42, (short)42);
		Label label1_15 = _Label1_42;
		location = new Point(32, 168);
		((Control)label1_15).Location = location;
		((Control)_Label1_42).Name = "_Label1_42";
		((Control)_Label1_42).RightToLeft = (RightToLeft)0;
		Label label1_16 = _Label1_42;
		size = new Size(218, 19);
		((Control)label1_16).Size = size;
		((Control)_Label1_42).TabIndex = 49;
		_Label1_42.Text = "Imported Production Volume (PVi):";
		_Label1_42.TextAlign = (ContentAlignment)4;
		((Control)_Label1_39).BackColor = SystemColors.Control;
		((Control)_Label1_39).Cursor = Cursors.Default;
		((Control)_Label1_39).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_39).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_39, (short)39);
		Label label1_17 = _Label1_39;
		location = new Point(19, 144);
		((Control)label1_17).Location = location;
		((Control)_Label1_39).Name = "_Label1_39";
		((Control)_Label1_39).RightToLeft = (RightToLeft)0;
		Label label1_18 = _Label1_39;
		size = new Size(231, 19);
		((Control)label1_18).Size = size;
		((Control)_Label1_39).TabIndex = 48;
		_Label1_39.Text = "Domestic Production Volume (PVd):";
		_Label1_39.TextAlign = (ContentAlignment)4;
		((Control)_Label1_0).BackColor = SystemColors.Control;
		((Control)_Label1_0).Cursor = Cursors.Default;
		((Control)_Label1_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_0).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_0, (short)0);
		Label label1_19 = _Label1_0;
		location = new Point(8, 112);
		((Control)label1_19).Location = location;
		((Control)_Label1_0).Name = "_Label1_0";
		((Control)_Label1_0).RightToLeft = (RightToLeft)0;
		Label label1_20 = _Label1_0;
		size = new Size(129, 19);
		((Control)label1_20).Size = size;
		((Control)_Label1_0).TabIndex = 47;
		_Label1_0.Text = "Chemical CAS Number:";
		_Label1_0.TextAlign = (ContentAlignment)4;
		((Control)_Label1_14).BackColor = SystemColors.Control;
		((Control)_Label1_14).Cursor = Cursors.Default;
		((Control)_Label1_14).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_14).ForeColor = Color.Red;
		Label1.SetIndex(_Label1_14, (short)14);
		Label label1_21 = _Label1_14;
		location = new Point(8, 192);
		((Control)label1_21).Location = location;
		((Control)_Label1_14).Name = "_Label1_14";
		((Control)_Label1_14).RightToLeft = (RightToLeft)0;
		Label label1_22 = _Label1_14;
		size = new Size(241, 19);
		((Control)label1_22).Size = size;
		((Control)_Label1_14).TabIndex = 46;
		_Label1_14.Text = "Total Assessed Production Volume (PV):";
		_Label1_14.TextAlign = (ContentAlignment)4;
		((Control)_Label1_15).BackColor = SystemColors.Control;
		((Control)_Label1_15).Cursor = Cursors.Default;
		((Control)_Label1_15).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_15).ForeColor = Color.Red;
		Label1.SetIndex(_Label1_15, (short)15);
		Label label1_23 = _Label1_15;
		location = new Point(56, 256);
		((Control)label1_23).Location = location;
		((Control)_Label1_15).Name = "_Label1_15";
		((Control)_Label1_15).RightToLeft = (RightToLeft)0;
		Label label1_24 = _Label1_15;
		size = new Size(145, 19);
		((Control)label1_24).Size = size;
		((Control)_Label1_15).TabIndex = 45;
		_Label1_15.Text = "Vapor Pressure (VPchem):";
		_Label1_15.TextAlign = (ContentAlignment)4;
		((Control)_Label1_17).BackColor = SystemColors.Control;
		((Control)_Label1_17).Cursor = Cursors.Default;
		((Control)_Label1_17).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_17).ForeColor = Color.Red;
		Label1.SetIndex(_Label1_17, (short)17);
		Label label1_25 = _Label1_17;
		location = new Point(56, 280);
		((Control)label1_25).Location = location;
		((Control)_Label1_17).Name = "_Label1_17";
		((Control)_Label1_17).RightToLeft = (RightToLeft)0;
		Label label1_26 = _Label1_17;
		size = new Size(145, 19);
		((Control)label1_26).Size = size;
		((Control)_Label1_17).TabIndex = 44;
		_Label1_17.Text = "Molecular Weight (MW):";
		_Label1_17.TextAlign = (ContentAlignment)4;
		((Control)_Label1_18).BackColor = SystemColors.Control;
		((Control)_Label1_18).Cursor = Cursors.Default;
		((Control)_Label1_18).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_18).ForeColor = Color.Red;
		Label1.SetIndex(_Label1_18, (short)18);
		Label label1_27 = _Label1_18;
		location = new Point(48, 304);
		((Control)label1_27).Location = location;
		((Control)_Label1_18).Name = "_Label1_18";
		((Control)_Label1_18).RightToLeft = (RightToLeft)0;
		Label label1_28 = _Label1_18;
		size = new Size(153, 19);
		((Control)label1_28).Size = size;
		((Control)_Label1_18).TabIndex = 43;
		_Label1_18.Text = "Density (Dchem):";
		_Label1_18.TextAlign = (ContentAlignment)4;
		((Control)_Label1_20).BackColor = SystemColors.Control;
		((Control)_Label1_20).Cursor = Cursors.Default;
		((Control)_Label1_20).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_20).ForeColor = Color.Red;
		Label1.SetIndex(_Label1_20, (short)20);
		Label label1_29 = _Label1_20;
		location = new Point(24, 344);
		((Control)label1_29).Location = location;
		((Control)_Label1_20).Name = "_Label1_20";
		((Control)_Label1_20).RightToLeft = (RightToLeft)0;
		Label label1_30 = _Label1_20;
		size = new Size(153, 19);
		((Control)label1_30).Size = size;
		((Control)_Label1_20).TabIndex = 42;
		_Label1_20.Text = "Solubility in Water (WSchem):";
		_Label1_20.TextAlign = (ContentAlignment)4;
		((Control)_Label2_22).BackColor = SystemColors.Control;
		((Control)_Label2_22).Cursor = Cursors.Default;
		((Control)_Label2_22).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label2_22).ForeColor = SystemColors.WindowText;
		Label2.SetIndex(_Label2_22, (short)22);
		Label label2_5 = _Label2_22;
		location = new Point(344, 192);
		((Control)label2_5).Location = location;
		((Control)_Label2_22).Name = "_Label2_22";
		((Control)_Label2_22).RightToLeft = (RightToLeft)0;
		Label label2_6 = _Label2_22;
		size = new Size(41, 19);
		((Control)label2_6).Size = size;
		((Control)_Label2_22).TabIndex = 41;
		_Label2_22.Text = " kg/yr";
		((Control)_Label2_0).BackColor = SystemColors.Control;
		((Control)_Label2_0).Cursor = Cursors.Default;
		((Control)_Label2_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label2_0).ForeColor = SystemColors.WindowText;
		Label2.SetIndex(_Label2_0, (short)0);
		Label label2_7 = _Label2_0;
		location = new Point(296, 256);
		((Control)label2_7).Location = location;
		((Control)_Label2_0).Name = "_Label2_0";
		((Control)_Label2_0).RightToLeft = (RightToLeft)0;
		Label label2_8 = _Label2_0;
		size = new Size(41, 19);
		((Control)label2_8).Size = size;
		((Control)_Label2_0).TabIndex = 40;
		_Label2_0.Text = " torr at";
		((Control)_Label2_1).BackColor = SystemColors.Control;
		((Control)_Label2_1).Cursor = Cursors.Default;
		((Control)_Label2_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label2_1).ForeColor = SystemColors.WindowText;
		Label2.SetIndex(_Label2_1, (short)1);
		Label label2_9 = _Label2_1;
		location = new Point(296, 280);
		((Control)label2_9).Location = location;
		((Control)_Label2_1).Name = "_Label2_1";
		((Control)_Label2_1).RightToLeft = (RightToLeft)0;
		Label label2_10 = _Label2_1;
		size = new Size(41, 19);
		((Control)label2_10).Size = size;
		((Control)_Label2_1).TabIndex = 39;
		_Label2_1.Text = " g/mol";
		((Control)_Label2_3).BackColor = SystemColors.Control;
		((Control)_Label2_3).Cursor = Cursors.Default;
		((Control)_Label2_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label2_3).ForeColor = SystemColors.WindowText;
		Label2.SetIndex(_Label2_3, (short)3);
		Label label2_11 = _Label2_3;
		location = new Point(392, 344);
		((Control)label2_11).Location = location;
		((Control)_Label2_3).Name = "_Label2_3";
		((Control)_Label2_3).RightToLeft = (RightToLeft)0;
		Label label2_12 = _Label2_3;
		size = new Size(17, 19);
		((Control)label2_12).Size = size;
		((Control)_Label2_3).TabIndex = 38;
		_Label2_3.Text = " C";
		((Control)_Label2_4).BackColor = SystemColors.Control;
		((Control)_Label2_4).Cursor = Cursors.Default;
		((Control)_Label2_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label2_4).ForeColor = SystemColors.WindowText;
		Label2.SetIndex(_Label2_4, (short)4);
		Label label2_13 = _Label2_4;
		location = new Point(296, 304);
		((Control)label2_13).Location = location;
		((Control)_Label2_4).Name = "_Label2_4";
		((Control)_Label2_4).RightToLeft = (RightToLeft)0;
		Label label2_14 = _Label2_4;
		size = new Size(49, 19);
		((Control)label2_14).Size = size;
		((Control)_Label2_4).TabIndex = 37;
		_Label2_4.Text = " g/cm3 at";
		((Control)_Label2_5).BackColor = SystemColors.Control;
		((Control)_Label2_5).Cursor = Cursors.Default;
		((Control)_Label2_5).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label2_5).ForeColor = SystemColors.WindowText;
		Label2.SetIndex(_Label2_5, (short)5);
		Label label2_15 = _Label2_5;
		location = new Point(312, 344);
		((Control)label2_15).Location = location;
		((Control)_Label2_5).Name = "_Label2_5";
		((Control)_Label2_5).RightToLeft = (RightToLeft)0;
		Label label2_16 = _Label2_5;
		size = new Size(41, 19);
		((Control)label2_16).Size = size;
		((Control)_Label2_5).TabIndex = 36;
		_Label2_5.Text = " g/L at";
		((Control)_Label2_2).BackColor = SystemColors.Control;
		((Control)_Label2_2).Cursor = Cursors.Default;
		((Control)_Label2_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label2_2).ForeColor = SystemColors.WindowText;
		Label2.SetIndex(_Label2_2, (short)2);
		Label label2_17 = _Label2_2;
		location = new Point(392, 304);
		((Control)label2_17).Location = location;
		((Control)_Label2_2).Name = "_Label2_2";
		((Control)_Label2_2).RightToLeft = (RightToLeft)0;
		Label label2_18 = _Label2_2;
		size = new Size(17, 19);
		((Control)label2_18).Size = size;
		((Control)_Label2_2).TabIndex = 35;
		_Label2_2.Text = " C";
		((Control)_Label2_6).BackColor = SystemColors.Control;
		((Control)_Label2_6).Cursor = Cursors.Default;
		((Control)_Label2_6).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label2_6).ForeColor = SystemColors.WindowText;
		Label2.SetIndex(_Label2_6, (short)6);
		Label label2_19 = _Label2_6;
		location = new Point(376, 256);
		((Control)label2_19).Location = location;
		((Control)_Label2_6).Name = "_Label2_6";
		((Control)_Label2_6).RightToLeft = (RightToLeft)0;
		Label label2_20 = _Label2_6;
		size = new Size(17, 19);
		((Control)label2_20).Size = size;
		((Control)_Label2_6).TabIndex = 34;
		_Label2_6.Text = " C";
		((Control)_Label1_16).BackColor = SystemColors.Control;
		((Control)_Label1_16).Cursor = Cursors.Default;
		((Control)_Label1_16).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_16).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_16, (short)16);
		Label label1_31 = _Label1_16;
		location = new Point(48, 216);
		((Control)label1_31).Location = location;
		((Control)_Label1_16).Name = "_Label1_16";
		((Control)_Label1_16).RightToLeft = (RightToLeft)0;
		Label label1_32 = _Label1_16;
		size = new Size(89, 19);
		((Control)label1_32).Size = size;
		((Control)_Label1_16).TabIndex = 33;
		_Label1_16.Text = "Type of Notice:";
		_Label1_16.TextAlign = (ContentAlignment)4;
		size = new Size(5, 13);
		((Form)this).AutoScaleBaseSize = size;
		((Form)this).BackColor = SystemColors.Control;
		((Form)this).CancelButton = (IButtonControl)(object)cmdCancel;
		size = new Size(693, 499);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)_chkQual_6);
		((Control)this).Controls.Add((Control)(object)_chkQual_5);
		((Control)this).Controls.Add((Control)(object)_chkQual_4);
		((Control)this).Controls.Add((Control)(object)txtOtherQualification);
		((Control)this).Controls.Add((Control)(object)_chkQual_3);
		((Control)this).Controls.Add((Control)(object)_chkQual_2);
		((Control)this).Controls.Add((Control)(object)_chkQual_1);
		((Control)this).Controls.Add((Control)(object)_chkQual_0);
		((Control)this).Controls.Add((Control)(object)_optSolubility_0);
		((Control)this).Controls.Add((Control)(object)_optSolubility_2);
		((Control)this).Controls.Add((Control)(object)_optSolubility_1);
		((Control)this).Controls.Add((Control)(object)txtMF);
		((Control)this).Controls.Add((Control)(object)txtLT1000);
		((Control)this).Controls.Add((Control)(object)txtLT500);
		((Control)this).Controls.Add((Control)(object)txtChemGenUse);
		((Control)this).Controls.Add((Control)(object)txtPV);
		((Control)this).Controls.Add((Control)(object)txtTradeNames);
		((Control)this).Controls.Add((Control)(object)txtChemCat);
		((Control)this).Controls.Add((Control)(object)txtChemName);
		((Control)this).Controls.Add((Control)(object)txtPVi);
		((Control)this).Controls.Add((Control)(object)txtPVd);
		((Control)this).Controls.Add((Control)(object)txtCas);
		((Control)this).Controls.Add((Control)(object)txtVP);
		((Control)this).Controls.Add((Control)(object)txtMW);
		((Control)this).Controls.Add((Control)(object)txtDen);
		((Control)this).Controls.Add((Control)(object)txtSol);
		((Control)this).Controls.Add((Control)(object)txtSolTemp);
		((Control)this).Controls.Add((Control)(object)txtDenTemp);
		((Control)this).Controls.Add((Control)(object)txtVPTemp);
		((Control)this).Controls.Add((Control)(object)_chkType_0);
		((Control)this).Controls.Add((Control)(object)_chkType_1);
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)cmdOk);
		((Control)this).Controls.Add((Control)(object)_Line1_12);
		((Control)this).Controls.Add((Control)(object)_Line1_11);
		((Control)this).Controls.Add((Control)(object)_Line1_10);
		((Control)this).Controls.Add((Control)(object)_Line1_9);
		((Control)this).Controls.Add((Control)(object)_Line1_8);
		((Control)this).Controls.Add((Control)(object)_Line1_5);
		((Control)this).Controls.Add((Control)(object)_Line1_3);
		((Control)this).Controls.Add((Control)(object)_Label1_41);
		((Control)this).Controls.Add((Control)(object)_Label1_6);
		((Control)this).Controls.Add((Control)(object)_Label1_5);
		((Control)this).Controls.Add((Control)(object)_Label1_3);
		((Control)this).Controls.Add((Control)(object)lblInstructions);
		((Control)this).Controls.Add((Control)(object)_Label1_4);
		((Control)this).Controls.Add((Control)(object)_Label1_2);
		((Control)this).Controls.Add((Control)(object)_Label1_1);
		((Control)this).Controls.Add((Control)(object)_Label2_10);
		((Control)this).Controls.Add((Control)(object)_Label2_9);
		((Control)this).Controls.Add((Control)(object)_Label1_42);
		((Control)this).Controls.Add((Control)(object)_Label1_39);
		((Control)this).Controls.Add((Control)(object)_Label1_0);
		((Control)this).Controls.Add((Control)(object)_Label1_14);
		((Control)this).Controls.Add((Control)(object)_Label1_15);
		((Control)this).Controls.Add((Control)(object)_Label1_17);
		((Control)this).Controls.Add((Control)(object)_Label1_18);
		((Control)this).Controls.Add((Control)(object)_Label1_20);
		((Control)this).Controls.Add((Control)(object)_Label2_22);
		((Control)this).Controls.Add((Control)(object)_Label2_0);
		((Control)this).Controls.Add((Control)(object)_Label2_1);
		((Control)this).Controls.Add((Control)(object)_Label2_3);
		((Control)this).Controls.Add((Control)(object)_Label2_4);
		((Control)this).Controls.Add((Control)(object)_Label2_5);
		((Control)this).Controls.Add((Control)(object)_Label2_2);
		((Control)this).Controls.Add((Control)(object)_Label2_6);
		((Control)this).Controls.Add((Control)(object)_Label1_16);
		((Control)this).Cursor = Cursors.Default;
		((Control)this).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		location = new Point(250, 150);
		((Form)this).Location = location;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmMDUpdChem";
		((Control)this).RightToLeft = (RightToLeft)0;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Update Chemical Information";
		((ISupportInitialize)Label1).EndInit();
		((ISupportInitialize)Label2).EndInit();
		((ISupportInitialize)Line1).EndInit();
		((ISupportInitialize)chkQual).EndInit();
		((ISupportInitialize)chkType).EndInit();
		((ISupportInitialize)optSolubility).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
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
		command.Parameters.Append(command.CreateParameter("pID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, 3));
		Command command2 = command;
		object RecordsAffected = Missing.Value;
		object Parameters = Missing.Value;
		recordset = command2.Execute(out RecordsAffected, ref Parameters);
		command.Parameters.Delete("pID");
		lblInstructions.Text = Conversions.ToString(recordset.Fields[0].Value);
		recordset.Close();
		recordset = null;
		command = null;
		PopulateControls();
		return true;
	}

	private void frmMDUpdChem_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (!((Control)cmdOk).Focused & !((Control)cmdCancel).Focused)
		{
			((Control)cmdCancel).Focus();
			((CancelEventArgs)(object)e).Cancel = true;
		}
	}

	private void frmMDUpdChem_Load(object eventSender, EventArgs eventArgs)
	{
		SetUp();
	}

	private void PopulateControls()
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
					txtChemName.Text = frmMain.DefInstance.lblChemName.Text;
					txtChemCat.Text = frmMain.DefInstance.lblChemCat.Text;
					txtTradeNames.Text = frmMain.DefInstance.lblTradeNames.Text;
					txtCas.Text = frmMain.DefInstance.lblCas.Text;
					txtMF.Text = frmMain.DefInstance.lblMF.Text;
					txtPVi.Text = frmMain.DefInstance.lblPVi.Text;
					txtPVd.Text = frmMain.DefInstance.lblPVd.Text;
					txtPV.Text = frmMain.DefInstance.lblPV.Text;
					txtVP.Text = frmMain.DefInstance.lblVP.Text;
					txtMW.Text = frmMain.DefInstance.lblMW.Text;
					txtLT500.Text = frmMain.DefInstance.lblLT500.Text;
					txtLT1000.Text = frmMain.DefInstance.lblLT1000.Text;
					txtDen.Text = frmMain.DefInstance.lblDchem.Text;
					txtDenTemp.Text = frmMain.DefInstance.lblDchemTemp.Text;
					string text = frmMain.DefInstance.lblSol.Text;
					if (Operators.CompareString(text, "Dispersible", false) == 0)
					{
						optSolubility[(short)1].Checked = true;
					}
					else if (Operators.CompareString(text, "Reacts", false) == 0)
					{
						optSolubility[(short)2].Checked = true;
					}
					else
					{
						optSolubility[(short)0].Checked = true;
						txtSol.Text = frmMain.DefInstance.lblSol.Text;
						txtSolTemp.Text = frmMain.DefInstance.lblSolTemp.Text;
					}
					txtVPTemp.Text = frmMain.DefInstance.lblVPTemp.Text;
					if (Strings.InStr(frmMain.DefInstance.lblNoticeType.Text, "Manufacturing", (CompareMethod)0) > 0)
					{
						chkType[(short)0].CheckState = (CheckState)1;
					}
					if (Strings.InStr(frmMain.DefInstance.lblNoticeType.Text, "Import", (CompareMethod)0) > 0)
					{
						chkType[(short)1].CheckState = (CheckState)1;
					}
					txtChemGenUse.Text = frmMain.DefInstance.txtChemGenUse.Text;
					chkQual[(short)0].CheckState = (CheckState)Conversions.ToInteger(Interaction.IIf(Operators.CompareString(frmMain.DefInstance.lblChemQualYX.Text, "Yes", false) == 0, (object)(CheckState)1, (object)0));
					chkQual[(short)1].CheckState = (CheckState)Conversions.ToInteger(Interaction.IIf(Operators.CompareString(frmMain.DefInstance.lblChemQualNX.Text, "Yes", false) == 0, (object)(CheckState)1, (object)0));
					chkQual[(short)3].CheckState = (CheckState)Conversions.ToInteger(Interaction.IIf(Operators.CompareString(frmMain.DefInstance.lblChemQualOther.Text, "Yes", false) == 0, (object)(CheckState)1, (object)0));
					chkQual[(short)4].CheckState = (CheckState)Conversions.ToInteger(Interaction.IIf(Operators.CompareString(frmMain.DefInstance.lblChemQualP2Rec.Text, "Yes", false) == 0, (object)(CheckState)1, (object)0));
					chkQual[(short)5].CheckState = (CheckState)Conversions.ToInteger(Interaction.IIf(Operators.CompareString(frmMain.DefInstance.lblChemQualP2RecDR.Text, "Yes", false) == 0, (object)(CheckState)1, (object)0));
					txtOtherQualification.Text = frmMain.DefInstance.lblChemQualOtherDesc.Text;
					goto end_IL_0001;
				}
				case 1202:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						string Eobject = ((Control)this).Name;
						string Efunction = "PopulateControls";
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
				try0001_dispatch = 1202;
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

	private void UpdateFrmMain()
	{
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c37: Invalid comparison between Unknown and I4
		//IL_0c95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9b: Invalid comparison between Unknown and I4
		//IL_0c4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c51: Invalid comparison between Unknown and I4
		//IL_0d37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3d: Invalid comparison between Unknown and I4
		//IL_0d6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d75: Invalid comparison between Unknown and I4
		//IL_0da7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dad: Invalid comparison between Unknown and I4
		//IL_0ddf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de5: Invalid comparison between Unknown and I4
		//IL_0e17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1d: Invalid comparison between Unknown and I4
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
					Cursor.Current = Cursors.WaitCursor;
					frmMain.DefInstance.lblChemName.Text = txtChemName.Text;
					frmMain.DefInstance.lblChemCat.Text = txtChemCat.Text;
					frmMain.DefInstance.lblTradeNames.Text = txtTradeNames.Text;
					frmMain.DefInstance.lblCas.Text = txtCas.Text;
					frmMain.DefInstance.lblMF.Text = txtMF.Text;
					frmMain.DefInstance.lblPVi.Text = txtPVi.Text;
					frmMain.DefInstance.lblPVd.Text = txtPVd.Text;
					if (Operators.CompareString(txtPV.Text, "", false) == 0)
					{
						txtPV.Text = "0";
					}
					checked
					{
						if (Operators.CompareString(frmMain.DefInstance.lblPV.Text, txtPV.Text, false) != 0)
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
								float num7 = Conversions.ToSingle(Common.MyNullCheck0(frmMain.DefInstance.lblPV.Text));
								num7 = ((num7 != 0f) ? ((float)(Globals_Renamed.arOpPv[num4] / (double)num7)) : 1f);
								Globals_Renamed.arOpPv[num4] = Conversions.ToDouble(txtPV.Text) * (double)num7;
								short num8 = 0;
								short num9;
								do
								{
									if ((Globals_Renamed.arSubPVf[num8, num4] > 0f) & (Globals_Renamed.arSubOpID[num8, num4] > 0))
									{
										Globals_Renamed.arSubPvOp[num8, num4] = Conversions.ToDouble(txtPV.Text) * (double)Globals_Renamed.arSubPVf[num8, num4] / 100.0;
									}
									num8 = (short)unchecked(num8 + 1);
									num9 = num8;
									num6 = 9;
								}
								while (num9 <= num6);
								Globals_Renamed.arOpNeedsMassBalance[num4] = 1;
								num4 = (short)unchecked(num4 + 1);
							}
							Interaction.MsgBox((object)"Please update the Mass Balance Parameters (subtab 4a) for all of your operations before running models.", (MsgBoxStyle)48, (object)"Mass Balance Message");
						}
						frmMain.DefInstance.lblPV.Text = txtPV.Text;
						if (Operators.CompareString(frmMain.DefInstance.lblVP.Text, txtVP.Text, false) != 0)
						{
							frmMain.DefInstance.lblVP.Text = txtVP.Text;
							if (Versioned.IsNumeric((object)txtVP.Text))
							{
								short pID = 4;
								float pValue = Conversions.ToSingle(frmMain.DefInstance.lblVP.Text);
								short pVC = -1302;
								ChemStrX.RollDownhill(ref pID, ref pValue, ref pVC);
								short num10 = (short)(Globals_Renamed.intNumOps - 1);
								short num4 = 0;
								while (true)
								{
									short num11 = num4;
									short num6 = num10;
									if (num11 > num6)
									{
										break;
									}
									Globals_Renamed.arOpParms[4, num4] = Conversions.ToSingle(txtVP.Text);
									Globals_Renamed.arOpParms[121, num4] = Globals_Renamed.arOpParms[4, num4] * Globals_Renamed.arOpParms[118, num4];
									Globals_Renamed.arOpParms[122, num4] = Globals_Renamed.arOpParms[4, num4] * Globals_Renamed.arOpParms[119, num4];
									ChemStrX.SetVolatilityFlag(ref num4);
									object pOpIndex = num4;
									ChemStrX.resetInhRespClass(ref pOpIndex);
									num4 = Conversions.ToShort(pOpIndex);
									num4 = (short)unchecked(num4 + 1);
								}
								ChemStrX.CheckAVP();
							}
							frmMain.DefInstance.cmbRelOps.SelectedIndex = -1;
							frmMain.DefInstance.cmbExpOps.SelectedIndex = -1;
						}
						float[] array = new float[6];
						float[] array2 = new float[6];
						if (Operators.CompareString(frmMain.DefInstance.lblMW.Text, txtMW.Text, false) != 0)
						{
							frmMain.DefInstance.lblMW.Text = txtMW.Text;
							if (Versioned.IsNumeric((object)txtMW.Text))
							{
								short pVC = 5;
								float pValue = Conversions.ToSingle(frmMain.DefInstance.lblMW.Text);
								short pID = -1102;
								ChemStrX.RollDownhill(ref pVC, ref pValue, ref pID);
							}
							frmMain.DefInstance.cmbRelOps.SelectedIndex = -1;
							short num12 = (short)(Globals_Renamed.intNumExpModels - 1);
							short num4 = 0;
							while (true)
							{
								short num13 = num4;
								short num6 = num12;
								if (num13 > num6)
								{
									break;
								}
								if (Globals_Renamed.arExpModType[num4] == 46)
								{
									short num14 = 0;
									short num28;
									do
									{
										if (Globals_Renamed.arExpModParmsV[num14, 54, num4] == 0f)
										{
											float[,,] arExpModParmsV = Globals_Renamed.arExpModParmsV;
											short num15 = num14;
											short num16 = num4;
											float[,,] arExpModParmsV2 = Globals_Renamed.arExpModParmsV;
											int num17 = num14;
											int num18 = 67;
											int num19 = num4;
											object pOpIndex = arExpModParmsV2[num17, num18, num19];
											float[,,] arExpModParmsV3 = Globals_Renamed.arExpModParmsV;
											int num20 = num14;
											int num21 = 5;
											int num22 = num4;
											object pMW = arExpModParmsV3[num20, num21, num22];
											float[,,] arExpModParmsV4 = Globals_Renamed.arExpModParmsV;
											int num23 = num14;
											int num24 = 63;
											int num25 = num4;
											object pVm = arExpModParmsV4[num23, num24, num25];
											float[,,] arExpModParmsV5 = Globals_Renamed.arExpModParmsV;
											int num26 = num14;
											int num27 = 78;
											int Enumber = num4;
											object pYs = arExpModParmsV5[num26, num27, Enumber];
											string text = ChemStrX.CalcCm(ref pOpIndex, ref pMW, ref pVm, ref pYs);
											arExpModParmsV5[num26, num27, Enumber] = Conversions.ToSingle(pYs);
											arExpModParmsV4[num23, num24, num25] = Conversions.ToSingle(pVm);
											arExpModParmsV3[num20, num21, num22] = Conversions.ToSingle(pMW);
											arExpModParmsV2[num17, num18, num19] = Conversions.ToSingle(pOpIndex);
											arExpModParmsV[num15, 64, num16] = Conversions.ToSingle(text);
											frmMain.DefInstance.cmbExpOps.SelectedIndex = -1;
										}
										num14 = (short)unchecked(num14 + 1);
										num28 = num14;
										num6 = 1;
									}
									while (num28 <= num6);
								}
								num4 = (short)unchecked(num4 + 1);
							}
							short intNumOps = Globals_Renamed.intNumOps;
							num4 = 0;
							while (true)
							{
								short num29 = num4;
								short num6 = intNumOps;
								if (num29 > num6)
								{
									break;
								}
								short num8 = 0;
								short num34;
								do
								{
									if (Globals_Renamed.arOpSP[(short)unchecked(4 + num8), num4] == 3f)
									{
										short num14 = 0;
										short num30;
										do
										{
											array[num14] = Globals_Renamed.arOpSP[(short)unchecked(7 + num14) + num8 * 12, num4];
											array2[num14] = Globals_Renamed.arOpSP[(short)unchecked(12 + num14) + num8 * 12, num4];
											num14 = (short)unchecked(num14 + 1);
											num30 = num14;
											num6 = 4;
										}
										while (num30 <= num6);
										float[,] arOpParms = Globals_Renamed.arOpParms;
										short num31 = (short)unchecked(118 + num8);
										short num32 = num4;
										ref float y = ref Globals_Renamed.arOpParms[Conversions.ToInteger(Interaction.IIf(num8 == 0, (object)(short)11, (object)(short)10)), num4];
										float pValue = Conversions.ToSingle(frmMain.DefInstance.lblMW.Text);
										object pYs = array;
										object pVm = array2;
										float num33 = ChemStrX.CalcRaoultsFormula(ref y, ref pValue, ref pYs, ref pVm);
										array2 = (float[])pVm;
										array = (float[])pYs;
										arOpParms[num31, num32] = num33;
										Globals_Renamed.arOpSP[17 + num8 * 12, num4] = Globals_Renamed.arOpParms[(short)unchecked(118 + num8), num4];
										if (Versioned.IsNumeric((object)frmMain.DefInstance.lblVP.Text))
										{
											switch (num8)
											{
											case 0:
												Globals_Renamed.arOpParms[121, num4] = Globals_Renamed.arOpParms[118, num4] * Conversions.ToSingle(frmMain.DefInstance.lblVP.Text);
												break;
											case 1:
												Globals_Renamed.arOpParms[122, num4] = Globals_Renamed.arOpParms[119, num4] * Conversions.ToSingle(frmMain.DefInstance.lblVP.Text);
												break;
											case 2:
												Globals_Renamed.arOpParms[121, num4] = Globals_Renamed.arOpParms[120, num4] * Conversions.ToSingle(frmMain.DefInstance.lblVP.Text);
												break;
											}
										}
										if (num8 == 0 && Globals_Renamed.arOpParmsType[119, num4] == 1)
										{
											Globals_Renamed.arOpParms[119, num4] = Globals_Renamed.arOpParms[118, num4];
											Globals_Renamed.arOpParms[122, num4] = Globals_Renamed.arOpParms[121, num4];
										}
										ChemStrX.RollXprodSideways(ref num4, ref Globals_Renamed.arOpParms[119, num4]);
										Globals_Renamed.intOpIndex = num4;
										short pVC = (short)unchecked(118 + num8);
										ref float pValue2 = ref Globals_Renamed.arOpParms[(short)unchecked(118 + num8), num4];
										pYs = (short)(-1000);
										ChemStrX.RollDownhillOp(ref pVC, ref pValue2, ref pYs);
									}
									num8 = (short)unchecked(num8 + 1);
									num34 = num8;
									num6 = 2;
								}
								while (num34 <= num6);
								num4 = (short)unchecked(num4 + 1);
							}
						}
						if (Operators.CompareString(frmMain.DefInstance.lblLT500.Text, txtLT500.Text, false) != 0)
						{
							frmMain.DefInstance.lblLT500.Text = txtLT500.Text;
						}
						if (Operators.CompareString(frmMain.DefInstance.lblLT1000.Text, txtLT1000.Text, false) != 0)
						{
							frmMain.DefInstance.lblLT1000.Text = txtLT1000.Text;
						}
						if (Operators.CompareString(frmMain.DefInstance.lblDchem.Text, txtDen.Text, false) != 0)
						{
							if (Versioned.IsNumeric((object)txtDen.Text))
							{
								float pValue = Conversions.ToSingle(txtDen.Text);
								float pOldValue = Conversions.ToSingle(frmMain.DefInstance.lblDchem.Text);
								ChemStrX.RollDownhillDchem(ref pValue, ref pOldValue);
								frmMain.DefInstance.lblDchem.Text = txtDen.Text;
							}
							else
							{
								frmMain.DefInstance.lblDchem.Text = Conversions.ToString(0);
							}
							frmMain.DefInstance.cmbRelOps.SelectedIndex = -1;
						}
						frmMain.DefInstance.lblDchemTemp.Text = txtDenTemp.Text;
						if (optSolubility[(short)2].Checked)
						{
							frmMain.DefInstance.lblSol.Text = "Reacts";
							short pVC = 80;
							float pOldValue = 0f;
							short pID = -1104;
							ChemStrX.RollDownhill(ref pVC, ref pOldValue, ref pID);
							frmMain.DefInstance.lblSolTemp.Text = "";
							((Control)frmMain.DefInstance.Label2[(short)3]).Visible = false;
							((Control)frmMain.DefInstance.Label2[(short)5]).Visible = false;
							((Control)frmMain.DefInstance.lblSolTemp).Visible = false;
						}
						else if (optSolubility[(short)1].Checked)
						{
							frmMain.DefInstance.lblSol.Text = "Dispersible";
							short pVC = 80;
							float pOldValue = 0f;
							short pID = -1104;
							ChemStrX.RollDownhill(ref pVC, ref pOldValue, ref pID);
							frmMain.DefInstance.lblSolTemp.Text = "";
							((Control)frmMain.DefInstance.Label2[(short)3]).Visible = false;
							((Control)frmMain.DefInstance.Label2[(short)5]).Visible = false;
							((Control)frmMain.DefInstance.lblSolTemp).Visible = false;
						}
						else
						{
							frmMain.DefInstance.lblSol.Text = txtSol.Text;
							if (Versioned.IsNumeric((object)txtSol.Text))
							{
								short pVC = 80;
								float pOldValue = Conversions.ToSingle(frmMain.DefInstance.lblSol.Text);
								short pID = -1104;
								ChemStrX.RollDownhill(ref pVC, ref pOldValue, ref pID);
							}
							frmMain.DefInstance.lblSolTemp.Text = txtSolTemp.Text;
							((Control)frmMain.DefInstance.Label2[(short)3]).Visible = true;
							((Control)frmMain.DefInstance.Label2[(short)5]).Visible = true;
							((Control)frmMain.DefInstance.lblSolTemp).Visible = true;
						}
						frmMain.DefInstance.lblVPTemp.Text = txtVPTemp.Text;
					}
					if ((int)chkType[(short)0].CheckState == 1)
					{
						if ((int)chkType[(short)1].CheckState == 1)
						{
							frmMain.DefInstance.lblNoticeType.Text = "Manufacturing and Import";
						}
						else
						{
							frmMain.DefInstance.lblNoticeType.Text = "Manufacturing";
						}
					}
					else if ((int)chkType[(short)1].CheckState == 1)
					{
						frmMain.DefInstance.lblNoticeType.Text = "Import";
					}
					frmMain.DefInstance.txtChemGenUse.Text = txtChemGenUse.Text;
					frmMain.DefInstance.LoadMsfOpIP();
					frmMain.DefInstance.cmbRelOps.SelectedIndex = -1;
					if (Globals_Renamed.intNumOps > 0)
					{
						frmMain.DefInstance._lstSelOps_0.SelectedIndex = -1;
						frmMain.DefInstance._lstSelOps_0.SelectedIndex = 0;
					}
					frmMain.DefInstance.lblChemQualYX.Text = Conversions.ToString(Interaction.IIf((int)chkQual[(short)0].CheckState == 1, (object)"Yes", (object)"No"));
					frmMain.DefInstance.lblChemQualNX.Text = Conversions.ToString(Interaction.IIf((int)chkQual[(short)1].CheckState == 1, (object)"Yes", (object)"No"));
					frmMain.DefInstance.lblChemQualOther.Text = Conversions.ToString(Interaction.IIf((int)chkQual[(short)3].CheckState == 1, (object)"Yes", (object)"No"));
					frmMain.DefInstance.lblChemQualP2Rec.Text = Conversions.ToString(Interaction.IIf((int)chkQual[(short)4].CheckState == 1, (object)"Yes", (object)"No"));
					frmMain.DefInstance.lblChemQualP2RecDR.Text = Conversions.ToString(Interaction.IIf((int)chkQual[(short)5].CheckState == 1, (object)"Yes", (object)"No"));
					frmMain.DefInstance.lblChemQualOtherDesc.Text = txtOtherQualification.Text;
					Cursor.Current = Cursors.Default;
					goto end_IL_0001;
				case 3784:
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
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 3784;
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

	private void CalculatePV()
	{
		if (Versioned.IsNumeric((object)txtPVi.Text))
		{
			if (Versioned.IsNumeric((object)txtPVd.Text))
			{
				txtPV.Text = Conversions.ToString(Conversions.ToSingle(txtPVi.Text) + Conversions.ToSingle(txtPVd.Text));
			}
			else
			{
				txtPV.Text = txtPVi.Text;
			}
		}
		else if (Versioned.IsNumeric((object)txtPVd.Text))
		{
			txtPV.Text = txtPVd.Text;
		}
		else
		{
			txtPV.Text = "";
		}
	}

	private bool ValidData()
	{
		TextBox pTB = txtPVd;
		string pField = "Domestic PV";
		bool num = ChemStrX.VerifyNumericTextBox(ref pTB, ref pField);
		txtPVd = pTB;
		if (num)
		{
			pTB = txtPVi;
			pField = "Imported PV";
			bool num2 = ChemStrX.VerifyNumericTextBox(ref pTB, ref pField);
			txtPVi = pTB;
			if (num2)
			{
				pTB = txtPV;
				pField = "Total Assessed PV";
				bool num3 = ChemStrX.VerifyNumericTextBox(ref pTB, ref pField);
				txtPV = pTB;
				if (num3)
				{
					pTB = txtVP;
					pField = "Vapor Pressure";
					bool num4 = ChemStrX.VerifyNumericTextBox(ref pTB, ref pField);
					txtVP = pTB;
					if (num4)
					{
						pTB = txtVPTemp;
						pField = "Vapor Pressure Temperature";
						bool num5 = ChemStrX.VerifyNumericTextBox(ref pTB, ref pField);
						txtVPTemp = pTB;
						if (num5)
						{
							pTB = txtMW;
							pField = "Molecular Weight";
							bool num6 = ChemStrX.VerifyNumericTextBox(ref pTB, ref pField);
							txtMW = pTB;
							if (num6)
							{
								pTB = txtLT500;
								pField = "%<500";
								bool num7 = ChemStrX.VerifyNumericTextBox(ref pTB, ref pField);
								txtLT500 = pTB;
								if (num7)
								{
									pTB = txtLT1000;
									pField = "%<1000";
									bool num8 = ChemStrX.VerifyNumericTextBox(ref pTB, ref pField);
									txtLT1000 = pTB;
									if (num8)
									{
										pTB = txtDen;
										pField = "Density";
										bool num9 = ChemStrX.VerifyNumericTextBox(ref pTB, ref pField);
										txtDen = pTB;
										if (num9)
										{
											pTB = txtDenTemp;
											pField = "Density Temperature";
											bool num10 = ChemStrX.VerifyNumericTextBox(ref pTB, ref pField);
											txtDenTemp = pTB;
											if (num10)
											{
												pTB = txtSol;
												pField = "Solubility";
												bool num11 = ChemStrX.VerifyNumericTextBox(ref pTB, ref pField);
												txtSol = pTB;
												if (num11)
												{
													pTB = txtSolTemp;
													pField = "Solubility Temperature";
													bool num12 = ChemStrX.VerifyNumericTextBox(ref pTB, ref pField);
													txtSolTemp = pTB;
													if (num12)
													{
														return true;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
		bool result = default(bool);
		return result;
	}

	public void cmdOk_Click(object eventSender, EventArgs eventArgs)
	{
		if (ValidData())
		{
			UpdateFrmMain();
			((Form)this).Close();
			Globals_Renamed.gblIWasChanged = true;
		}
	}

	private void cmdCancel_Click(object eventSender, EventArgs eventArgs)
	{
		((Form)this).Close();
	}

	private void chkQual_CheckStateChanged(object eventSender, EventArgs eventArgs)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		short index = chkQual.GetIndex((CheckBox)eventSender);
		if (index == 3)
		{
			if ((int)chkQual[(short)3].CheckState == 1)
			{
				txtOtherQualification.Text = Conversions.ToString(((Control)txtOtherQualification).Tag);
				((Control)txtOtherQualification).Enabled = true;
				((TextBoxBase)txtOtherQualification).BackColor = Color.White;
			}
			else
			{
				((Control)txtOtherQualification).Tag = txtOtherQualification.Text;
				txtOtherQualification.Text = "";
				((Control)txtOtherQualification).Enabled = false;
				((TextBoxBase)txtOtherQualification).BackColor = ((Form)this).BackColor;
			}
		}
	}

	private void optSolubility_CheckedChanged(object eventSender, EventArgs eventArgs)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		if (Conversions.ToBoolean(NewLateBinding.LateGet(eventSender, (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			if (optSolubility.GetIndex((RadioButton)eventSender) == 0)
			{
				((Control)txtSol).Enabled = true;
				((TextBoxBase)txtSol).BackColor = Color.White;
			}
			else
			{
				txtSol.Text = "";
				txtSolTemp.Text = "";
				((Control)txtSol).Enabled = false;
				((TextBoxBase)txtSol).BackColor = ((Form)this).BackColor;
			}
			((Control)txtSolTemp).Enabled = ((Control)txtSol).Enabled;
			((TextBoxBase)txtSolTemp).BackColor = ((TextBoxBase)txtSol).BackColor;
		}
	}

	private void txtPVi_Leave(object eventSender, EventArgs eventArgs)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		txtPVi.Text = Strings.Trim(txtPVi.Text);
		if (Strings.Len(txtPVi.Text) > 0)
		{
			if (!Versioned.IsNumeric((object)txtPVi.Text))
			{
				Interaction.Beep();
				Interaction.MsgBox((object)"Please enter a valid number for imported PV.  If there is no imported PV, the imported PV field must be empty.", (MsgBoxStyle)64, (object)"Invalid Data");
				((TextBoxBase)txtPVi).SelectionStart = 0;
				((TextBoxBase)txtPVi).SelectionLength = Strings.Len(txtPVi.Text);
				((Control)txtPVi).Focus();
				return;
			}
			txtPVi.Text = Conversions.ToString(Conversions.ToDouble(txtPVi.Text));
		}
		CalculatePV();
	}

	private void txtDen_Leave(object eventSender, EventArgs eventArgs)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		txtDen.Text = Strings.Trim(txtDen.Text);
		if (Strings.Len(txtDen.Text) > 0)
		{
			if (!Versioned.IsNumeric((object)txtDen.Text))
			{
				Interaction.Beep();
				Interaction.MsgBox((object)"Please enter a valid number for Density.", (MsgBoxStyle)64, (object)"Invalid Data");
				((TextBoxBase)txtDen).SelectionStart = 0;
				((TextBoxBase)txtDen).SelectionLength = Strings.Len(txtDen.Text);
				((Control)txtDen).Focus();
			}
			else
			{
				txtDen.Text = Conversions.ToString(Conversions.ToSingle(txtDen.Text));
			}
		}
	}

	private void txtMW_Leave(object eventSender, EventArgs eventArgs)
	{
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		txtMW.Text = Strings.Trim(txtMW.Text);
		txtMW.Text = Strings.Left(txtMW.Text, 8);
		if (Strings.Len(txtMW.Text) > 0)
		{
			if (!Versioned.IsNumeric((object)txtMW.Text))
			{
				Interaction.Beep();
				Interaction.MsgBox((object)"Please enter a valid number for Molecular Weight.", (MsgBoxStyle)64, (object)"Invalid Data");
				((TextBoxBase)txtMW).SelectionStart = 0;
				((TextBoxBase)txtMW).SelectionLength = Strings.Len(txtMW.Text);
				((Control)txtMW).Focus();
			}
			else
			{
				txtMW.Text = Conversions.ToString(Conversions.ToSingle(txtMW.Text));
			}
		}
	}

	private void txtPV_Leave(object eventSender, EventArgs eventArgs)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		txtPV.Text = Strings.Trim(txtPV.Text);
		if (Strings.Len(txtPV.Text) > 0)
		{
			if (!Versioned.IsNumeric((object)txtPV.Text))
			{
				Interaction.Beep();
				Interaction.MsgBox((object)"Please enter a valid number for PV.", (MsgBoxStyle)64, (object)"Invalid Data");
				((TextBoxBase)txtPV).SelectionStart = 0;
				((TextBoxBase)txtPV).SelectionLength = Strings.Len(txtPV.Text);
				((Control)txtPV).Focus();
			}
			else
			{
				txtPV.Text = Conversions.ToString(Conversions.ToDouble(txtPV.Text));
			}
		}
	}

	private void txtPVd_Leave(object eventSender, EventArgs eventArgs)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		txtPVd.Text = Strings.Trim(txtPVd.Text);
		if (Strings.Len(txtPVd.Text) > 0)
		{
			if (!Versioned.IsNumeric((object)txtPVd.Text))
			{
				Interaction.Beep();
				Interaction.MsgBox((object)"Please enter a valid number for domestic PV.  If there is no domestic PV, the domestic PV field must be empty.", (MsgBoxStyle)64, (object)"Invalid Data");
				((TextBoxBase)txtPVd).SelectionStart = 0;
				((TextBoxBase)txtPVd).SelectionLength = Strings.Len(txtPVd.Text);
				((Control)txtPVd).Focus();
				return;
			}
			txtPVd.Text = Conversions.ToString(Conversions.ToDouble(txtPVd.Text));
		}
		CalculatePV();
	}

	private void txtSol_Leave(object eventSender, EventArgs eventArgs)
	{
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		txtSol.Text = Strings.Trim(txtSol.Text);
		txtSol.Text = Strings.Left(txtSol.Text, 8);
		if (Strings.Len(txtSol.Text) > 0)
		{
			if (!Versioned.IsNumeric((object)txtSol.Text))
			{
				Interaction.Beep();
				Interaction.MsgBox((object)"Please enter a valid number for Solubility.", (MsgBoxStyle)64, (object)"Invalid Data");
				((TextBoxBase)txtSol).SelectionStart = 0;
				((TextBoxBase)txtSol).SelectionLength = Strings.Len(txtSol.Text);
				((Control)txtSol).Focus();
			}
			else
			{
				txtSol.Text = Conversions.ToString(Conversions.ToSingle(txtSol.Text));
			}
		}
	}

	private void txtVP_Leave(object eventSender, EventArgs eventArgs)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		txtVP.Text = Strings.Trim(txtVP.Text);
		if (Strings.Len(txtVP.Text) > 0)
		{
			if (!Versioned.IsNumeric((object)txtVP.Text))
			{
				Interaction.Beep();
				Interaction.MsgBox((object)"Please enter a valid number for Vapor Pressure.", (MsgBoxStyle)64, (object)"Invalid Data");
				((TextBoxBase)txtVP).SelectionStart = 0;
				((TextBoxBase)txtVP).SelectionLength = Strings.Len(txtVP.Text);
				((Control)txtVP).Focus();
			}
			else
			{
				txtVP.Text = Conversions.ToString(Conversions.ToSingle(txtVP.Text));
			}
		}
	}

	private void txtPVd_TextChanged(object sender, EventArgs e)
	{
	}
}
