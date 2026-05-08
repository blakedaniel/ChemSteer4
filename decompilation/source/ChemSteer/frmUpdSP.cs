using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Compatibility.VB6;
using Microsoft.VisualBasic.CompilerServices;

namespace ChemSteer;

internal class frmUpdSP : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("_fraAuto_4")]
	private Panel __fraAuto_4;

	[AccessedThroughProperty("_optOverSprayCntlType_2")]
	private RadioButton __optOverSprayCntlType_2;

	[AccessedThroughProperty("_optOverSprayCntlType_3")]
	private RadioButton __optOverSprayCntlType_3;

	[AccessedThroughProperty("_Label4_17")]
	private Label __Label4_17;

	[AccessedThroughProperty("_fraAuto_3")]
	private Panel __fraAuto_3;

	[AccessedThroughProperty("_optBoothVentType_2")]
	private RadioButton __optBoothVentType_2;

	[AccessedThroughProperty("_optBoothVentType_3")]
	private RadioButton __optBoothVentType_3;

	[AccessedThroughProperty("_Label4_19")]
	private Label __Label4_19;

	[AccessedThroughProperty("_fraAuto_5")]
	private Panel __fraAuto_5;

	[AccessedThroughProperty("_optElecAddType_0")]
	private RadioButton __optElecAddType_0;

	[AccessedThroughProperty("_optElecAddType_1")]
	private RadioButton __optElecAddType_1;

	[AccessedThroughProperty("_Label4_18")]
	private Label __Label4_18;

	[AccessedThroughProperty("_fraWhatAmIDoing_2")]
	private GroupBox __fraWhatAmIDoing_2;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("cmdOK")]
	private Button _cmdOK;

	[AccessedThroughProperty("cmdCalcX")]
	private Button _cmdCalcX;

	[AccessedThroughProperty("_txtXya_4")]
	private TextBox __txtXya_4;

	[AccessedThroughProperty("_txtXya_3")]
	private TextBox __txtXya_3;

	[AccessedThroughProperty("_txtXya_2")]
	private TextBox __txtXya_2;

	[AccessedThroughProperty("_txtXya_1")]
	private TextBox __txtXya_1;

	[AccessedThroughProperty("_txtXya_0")]
	private TextBox __txtXya_0;

	[AccessedThroughProperty("_txtXmwa_4")]
	private TextBox __txtXmwa_4;

	[AccessedThroughProperty("_txtXmwa_3")]
	private TextBox __txtXmwa_3;

	[AccessedThroughProperty("_txtXmwa_2")]
	private TextBox __txtXmwa_2;

	[AccessedThroughProperty("_txtXmwa_1")]
	private TextBox __txtXmwa_1;

	[AccessedThroughProperty("_txtXmwa_0")]
	private TextBox __txtXmwa_0;

	[AccessedThroughProperty("_optX_4")]
	private RadioButton __optX_4;

	[AccessedThroughProperty("_optX_3")]
	private RadioButton __optX_3;

	[AccessedThroughProperty("_optX_2")]
	private RadioButton __optX_2;

	[AccessedThroughProperty("_optX_1")]
	private RadioButton __optX_1;

	[AccessedThroughProperty("_optX_0")]
	private RadioButton __optX_0;

	[AccessedThroughProperty("txtXuserdef")]
	private TextBox _txtXuserdef;

	[AccessedThroughProperty("_lblX_3")]
	private Label __lblX_3;

	[AccessedThroughProperty("_lblX_2")]
	private Label __lblX_2;

	[AccessedThroughProperty("_lblX_1")]
	private Label __lblX_1;

	[AccessedThroughProperty("_lblX_0")]
	private Label __lblX_0;

	[AccessedThroughProperty("_Line1_1")]
	private Label __Line1_1;

	[AccessedThroughProperty("lblY")]
	private Label _lblY;

	[AccessedThroughProperty("_Line1_4")]
	private Label __Line1_4;

	[AccessedThroughProperty("lblMW")]
	private Label _lblMW;

	[AccessedThroughProperty("_Line1_11")]
	private Label __Line1_11;

	[AccessedThroughProperty("_Line1_10")]
	private Label __Line1_10;

	[AccessedThroughProperty("_Line1_9")]
	private Label __Line1_9;

	[AccessedThroughProperty("_Line1_8")]
	private Label __Line1_8;

	[AccessedThroughProperty("_Line1_7")]
	private Label __Line1_7;

	[AccessedThroughProperty("_Line1_3")]
	private Label __Line1_3;

	[AccessedThroughProperty("_Label4_14")]
	private Label __Label4_14;

	[AccessedThroughProperty("_Label4_13")]
	private Label __Label4_13;

	[AccessedThroughProperty("_Label4_12")]
	private Label __Label4_12;

	[AccessedThroughProperty("_Label4_11")]
	private Label __Label4_11;

	[AccessedThroughProperty("_Label4_10")]
	private Label __Label4_10;

	[AccessedThroughProperty("_Label4_9")]
	private Label __Label4_9;

	[AccessedThroughProperty("_Label4_8")]
	private Label __Label4_8;

	[AccessedThroughProperty("_Label4_7")]
	private Label __Label4_7;

	[AccessedThroughProperty("_Label4_6")]
	private Label __Label4_6;

	[AccessedThroughProperty("_Label4_4")]
	private Label __Label4_4;

	[AccessedThroughProperty("_Line1_6")]
	private Label __Line1_6;

	[AccessedThroughProperty("_Label4_1")]
	private Label __Label4_1;

	[AccessedThroughProperty("_Line1_5")]
	private Label __Line1_5;

	[AccessedThroughProperty("_Label4_5")]
	private Label __Label4_5;

	[AccessedThroughProperty("_Line1_2")]
	private Label __Line1_2;

	[AccessedThroughProperty("_Line1_0")]
	private Label __Line1_0;

	[AccessedThroughProperty("_Label4_3")]
	private Label __Label4_3;

	[AccessedThroughProperty("_Label4_0")]
	private Label __Label4_0;

	[AccessedThroughProperty("_fraWhatAmIDoing_1")]
	private GroupBox __fraWhatAmIDoing_1;

	[AccessedThroughProperty("_optOverSprayCntlType_0")]
	private RadioButton __optOverSprayCntlType_0;

	[AccessedThroughProperty("_optOverSprayCntlType_1")]
	private RadioButton __optOverSprayCntlType_1;

	[AccessedThroughProperty("_Label4_15")]
	private Label __Label4_15;

	[AccessedThroughProperty("_fraAuto_1")]
	private Panel __fraAuto_1;

	[AccessedThroughProperty("_optSprayGunType_0")]
	private RadioButton __optSprayGunType_0;

	[AccessedThroughProperty("_optSprayGunType_1")]
	private RadioButton __optSprayGunType_1;

	[AccessedThroughProperty("_Label4_2")]
	private Label __Label4_2;

	[AccessedThroughProperty("_fraAuto_0")]
	private Panel __fraAuto_0;

	[AccessedThroughProperty("_optBoothVentType_0")]
	private RadioButton __optBoothVentType_0;

	[AccessedThroughProperty("_optBoothVentType_1")]
	private RadioButton __optBoothVentType_1;

	[AccessedThroughProperty("_Label4_16")]
	private Label __Label4_16;

	[AccessedThroughProperty("_fraAuto_2")]
	private Panel __fraAuto_2;

	[AccessedThroughProperty("_fraWhatAmIDoing_0")]
	private GroupBox __fraWhatAmIDoing_0;

	[AccessedThroughProperty("lblInstructions")]
	private Label _lblInstructions;

	[AccessedThroughProperty("Label4")]
	private LabelArray _Label4;

	[AccessedThroughProperty("Line1")]
	private LabelArray _Line1;

	[AccessedThroughProperty("fraAuto")]
	private PanelArray _fraAuto;

	[AccessedThroughProperty("fraWhatAmIDoing")]
	private GroupBoxArray _fraWhatAmIDoing;

	[AccessedThroughProperty("lblX")]
	private LabelArray _lblX;

	[AccessedThroughProperty("optBoothVentType")]
	private RadioButtonArray _optBoothVentType;

	[AccessedThroughProperty("optElecAddType")]
	private RadioButtonArray _optElecAddType;

	[AccessedThroughProperty("optOverSprayCntlType")]
	private RadioButtonArray _optOverSprayCntlType;

	[AccessedThroughProperty("optSprayGunType")]
	private RadioButtonArray _optSprayGunType;

	[AccessedThroughProperty("optX")]
	private RadioButtonArray _optX;

	[AccessedThroughProperty("txtXmwa")]
	private TextBoxArray _txtXmwa;

	[AccessedThroughProperty("txtXya")]
	private TextBoxArray _txtXya;

	private static frmUpdSP m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	private short WhatAmIDoing;

	private short iWhoAmI;

	private string sWhoAmI;

	private short iXOption;

	private short iStartOfMyWork;

	private short iWhereMyOption;

	private short iSGType;

	private short iOSType;

	private short iBVType;

	private short iEAType;

	public virtual Panel _fraAuto_4
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraAuto_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraAuto_4 = value;
		}
	}

	public virtual RadioButton _optOverSprayCntlType_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __optOverSprayCntlType_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__optOverSprayCntlType_2 = value;
		}
	}

	public virtual RadioButton _optOverSprayCntlType_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __optOverSprayCntlType_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__optOverSprayCntlType_3 = value;
		}
	}

	public virtual Label _Label4_17
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label4_17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label4_17 = value;
		}
	}

	public virtual Panel _fraAuto_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraAuto_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraAuto_3 = value;
		}
	}

	public virtual RadioButton _optBoothVentType_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __optBoothVentType_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__optBoothVentType_2 = value;
		}
	}

	public virtual RadioButton _optBoothVentType_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __optBoothVentType_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__optBoothVentType_3 = value;
		}
	}

	public virtual Label _Label4_19
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label4_19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label4_19 = value;
		}
	}

	public virtual Panel _fraAuto_5
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraAuto_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraAuto_5 = value;
		}
	}

	public virtual RadioButton _optElecAddType_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __optElecAddType_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__optElecAddType_0 = value;
		}
	}

	public virtual RadioButton _optElecAddType_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __optElecAddType_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__optElecAddType_1 = value;
		}
	}

	public virtual Label _Label4_18
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label4_18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label4_18 = value;
		}
	}

	public virtual GroupBox _fraWhatAmIDoing_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraWhatAmIDoing_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraWhatAmIDoing_2 = value;
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

	public virtual Button cmdCalcX
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdCalcX;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdCalcX_Click;
			if (_cmdCalcX != null)
			{
				((Control)_cmdCalcX).Click -= eventHandler;
			}
			_cmdCalcX = value;
			if (_cmdCalcX != null)
			{
				((Control)_cmdCalcX).Click += eventHandler;
			}
		}
	}

	public virtual TextBox _txtXya_4
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtXya_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtXya_4 = value;
		}
	}

	public virtual TextBox _txtXya_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtXya_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtXya_3 = value;
		}
	}

	public virtual TextBox _txtXya_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtXya_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtXya_2 = value;
		}
	}

	public virtual TextBox _txtXya_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtXya_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtXya_1 = value;
		}
	}

	public virtual TextBox _txtXya_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtXya_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtXya_0 = value;
		}
	}

	public virtual TextBox _txtXmwa_4
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtXmwa_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtXmwa_4 = value;
		}
	}

	public virtual TextBox _txtXmwa_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtXmwa_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtXmwa_3 = value;
		}
	}

	public virtual TextBox _txtXmwa_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtXmwa_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtXmwa_2 = value;
		}
	}

	public virtual TextBox _txtXmwa_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtXmwa_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtXmwa_1 = value;
		}
	}

	public virtual TextBox _txtXmwa_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtXmwa_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtXmwa_0 = value;
		}
	}

	public virtual RadioButton _optX_4
	{
		[DebuggerNonUserCode]
		get
		{
			return __optX_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__optX_4 = value;
		}
	}

	public virtual RadioButton _optX_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __optX_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__optX_3 = value;
		}
	}

	public virtual RadioButton _optX_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __optX_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__optX_2 = value;
		}
	}

	public virtual RadioButton _optX_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __optX_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__optX_1 = value;
		}
	}

	public virtual RadioButton _optX_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __optX_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__optX_0 = value;
		}
	}

	public virtual TextBox txtXuserdef
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtXuserdef;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtXuserdef_Leave;
			if (_txtXuserdef != null)
			{
				((Control)_txtXuserdef).Leave -= eventHandler;
			}
			_txtXuserdef = value;
			if (_txtXuserdef != null)
			{
				((Control)_txtXuserdef).Leave += eventHandler;
			}
		}
	}

	public virtual Label _lblX_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblX_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblX_3 = value;
		}
	}

	public virtual Label _lblX_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblX_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblX_2 = value;
		}
	}

	public virtual Label _lblX_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblX_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblX_1 = value;
		}
	}

	public virtual Label _lblX_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblX_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblX_0 = value;
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

	public virtual Label lblY
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblY;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblY = value;
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

	public virtual Label lblMW
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMW;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMW = value;
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

	public virtual Label _Line1_7
	{
		[DebuggerNonUserCode]
		get
		{
			return __Line1_7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Line1_7 = value;
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

	public virtual Label _Label4_13
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label4_13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label4_13 = value;
		}
	}

	public virtual Label _Label4_12
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label4_12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label4_12 = value;
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

	public virtual GroupBox _fraWhatAmIDoing_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraWhatAmIDoing_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraWhatAmIDoing_1 = value;
		}
	}

	public virtual RadioButton _optOverSprayCntlType_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __optOverSprayCntlType_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__optOverSprayCntlType_0 = value;
		}
	}

	public virtual RadioButton _optOverSprayCntlType_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __optOverSprayCntlType_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__optOverSprayCntlType_1 = value;
		}
	}

	public virtual Label _Label4_15
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label4_15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label4_15 = value;
		}
	}

	public virtual Panel _fraAuto_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraAuto_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraAuto_1 = value;
		}
	}

	public virtual RadioButton _optSprayGunType_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __optSprayGunType_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__optSprayGunType_0 = value;
		}
	}

	public virtual RadioButton _optSprayGunType_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __optSprayGunType_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__optSprayGunType_1 = value;
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

	public virtual Panel _fraAuto_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraAuto_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraAuto_0 = value;
		}
	}

	public virtual RadioButton _optBoothVentType_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __optBoothVentType_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__optBoothVentType_0 = value;
		}
	}

	public virtual RadioButton _optBoothVentType_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __optBoothVentType_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__optBoothVentType_1 = value;
		}
	}

	public virtual Label _Label4_16
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label4_16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label4_16 = value;
		}
	}

	public virtual Panel _fraAuto_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraAuto_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraAuto_2 = value;
		}
	}

	public virtual GroupBox _fraWhatAmIDoing_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraWhatAmIDoing_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraWhatAmIDoing_0 = value;
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

	public virtual PanelArray fraAuto
	{
		[DebuggerNonUserCode]
		get
		{
			return _fraAuto;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_fraAuto = value;
		}
	}

	public virtual GroupBoxArray fraWhatAmIDoing
	{
		[DebuggerNonUserCode]
		get
		{
			return _fraWhatAmIDoing;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_fraWhatAmIDoing = value;
		}
	}

	public virtual LabelArray lblX
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblX;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblX = value;
		}
	}

	public virtual RadioButtonArray optBoothVentType
	{
		[DebuggerNonUserCode]
		get
		{
			return _optBoothVentType;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = optBoothVentType_CheckedChanged;
			if (_optBoothVentType != null)
			{
				_optBoothVentType.CheckedChanged -= eventHandler;
			}
			_optBoothVentType = value;
			if (_optBoothVentType != null)
			{
				_optBoothVentType.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual RadioButtonArray optElecAddType
	{
		[DebuggerNonUserCode]
		get
		{
			return _optElecAddType;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = optElecAddType_CheckedChanged;
			if (_optElecAddType != null)
			{
				_optElecAddType.CheckedChanged -= eventHandler;
			}
			_optElecAddType = value;
			if (_optElecAddType != null)
			{
				_optElecAddType.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual RadioButtonArray optOverSprayCntlType
	{
		[DebuggerNonUserCode]
		get
		{
			return _optOverSprayCntlType;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = optOverSprayCntlType_CheckedChanged;
			if (_optOverSprayCntlType != null)
			{
				_optOverSprayCntlType.CheckedChanged -= eventHandler;
			}
			_optOverSprayCntlType = value;
			if (_optOverSprayCntlType != null)
			{
				_optOverSprayCntlType.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual RadioButtonArray optSprayGunType
	{
		[DebuggerNonUserCode]
		get
		{
			return _optSprayGunType;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = optSprayGunType_CheckedChanged;
			if (_optSprayGunType != null)
			{
				_optSprayGunType.CheckedChanged -= eventHandler;
			}
			_optSprayGunType = value;
			if (_optSprayGunType != null)
			{
				_optSprayGunType.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual RadioButtonArray optX
	{
		[DebuggerNonUserCode]
		get
		{
			return _optX;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = optX_CheckedChanged;
			if (_optX != null)
			{
				_optX.CheckedChanged -= eventHandler;
			}
			_optX = value;
			if (_optX != null)
			{
				_optX.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual TextBoxArray txtXmwa
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtXmwa;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtXmwa_Leave;
			if (_txtXmwa != null)
			{
				_txtXmwa.Leave -= eventHandler;
			}
			_txtXmwa = value;
			if (_txtXmwa != null)
			{
				_txtXmwa.Leave += eventHandler;
			}
		}
	}

	public virtual TextBoxArray txtXya
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtXya;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtXya_Leave;
			if (_txtXya != null)
			{
				_txtXya.Leave -= eventHandler;
			}
			_txtXya = value;
			if (_txtXya != null)
			{
				_txtXya.Leave += eventHandler;
			}
		}
	}

	public static frmUpdSP DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmUpdSP();
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

	public frmUpdSP()
	{
		((Form)this).Load += frmUpdSP_Load;
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
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Expected O, but got Unknown
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Expected O, but got Unknown
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Expected O, but got Unknown
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Expected O, but got Unknown
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Expected O, but got Unknown
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Expected O, but got Unknown
		//IL_0466: Unknown result type (might be due to invalid IL or missing references)
		//IL_0470: Expected O, but got Unknown
		//IL_0478: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Expected O, but got Unknown
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Expected O, but got Unknown
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Expected O, but got Unknown
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Expected O, but got Unknown
		//IL_065e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0668: Expected O, but got Unknown
		//IL_0741: Unknown result type (might be due to invalid IL or missing references)
		//IL_074b: Expected O, but got Unknown
		//IL_0852: Unknown result type (might be due to invalid IL or missing references)
		//IL_085c: Expected O, but got Unknown
		//IL_0928: Unknown result type (might be due to invalid IL or missing references)
		//IL_0932: Expected O, but got Unknown
		//IL_0a1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a26: Expected O, but got Unknown
		//IL_0b10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1a: Expected O, but got Unknown
		//IL_0c39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c43: Expected O, but got Unknown
		//IL_0d12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1c: Expected O, but got Unknown
		//IL_0e06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e10: Expected O, but got Unknown
		//IL_0efa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f04: Expected O, but got Unknown
		//IL_0fde: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe8: Expected O, but got Unknown
		//IL_10d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_10dc: Expected O, but got Unknown
		//IL_11c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d0: Expected O, but got Unknown
		//IL_12ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b5: Expected O, but got Unknown
		//IL_137f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1389: Expected O, but got Unknown
		//IL_18a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_18b2: Expected O, but got Unknown
		//IL_1998: Unknown result type (might be due to invalid IL or missing references)
		//IL_19a2: Expected O, but got Unknown
		//IL_1a79: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a83: Expected O, but got Unknown
		//IL_1b5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b66: Expected O, but got Unknown
		//IL_1c3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c49: Expected O, but got Unknown
		//IL_1d22: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d2c: Expected O, but got Unknown
		//IL_1e04: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e0e: Expected O, but got Unknown
		//IL_1ee6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ef0: Expected O, but got Unknown
		//IL_1fc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fd3: Expected O, but got Unknown
		//IL_20ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_20b6: Expected O, but got Unknown
		//IL_218f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2199: Expected O, but got Unknown
		//IL_2271: Unknown result type (might be due to invalid IL or missing references)
		//IL_227b: Expected O, but got Unknown
		//IL_2346: Unknown result type (might be due to invalid IL or missing references)
		//IL_2350: Expected O, but got Unknown
		//IL_243a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2444: Expected O, but got Unknown
		//IL_252a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2534: Expected O, but got Unknown
		//IL_261a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2624: Expected O, but got Unknown
		//IL_270a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2714: Expected O, but got Unknown
		//IL_2814: Unknown result type (might be due to invalid IL or missing references)
		//IL_281e: Expected O, but got Unknown
		//IL_28d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_28e1: Expected O, but got Unknown
		//IL_29b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_29bb: Expected O, but got Unknown
		//IL_2a8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a95: Expected O, but got Unknown
		//IL_2b62: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b6c: Expected O, but got Unknown
		//IL_2cb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cbe: Expected O, but got Unknown
		//IL_2df6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e00: Expected O, but got Unknown
		//IL_3193: Unknown result type (might be due to invalid IL or missing references)
		//IL_319d: Expected O, but got Unknown
		//IL_327b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3285: Expected O, but got Unknown
		//IL_3363: Unknown result type (might be due to invalid IL or missing references)
		//IL_336d: Expected O, but got Unknown
		//IL_344b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3455: Expected O, but got Unknown
		//IL_3533: Unknown result type (might be due to invalid IL or missing references)
		//IL_353d: Expected O, but got Unknown
		//IL_361b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3625: Expected O, but got Unknown
		//IL_36f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_36fd: Expected O, but got Unknown
		//IL_37ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_37d4: Expected O, but got Unknown
		//IL_38a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_38ab: Expected O, but got Unknown
		//IL_3978: Unknown result type (might be due to invalid IL or missing references)
		//IL_3982: Expected O, but got Unknown
		//IL_3ac7: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ad1: Expected O, but got Unknown
		//IL_3c27: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c31: Expected O, but got Unknown
		//IL_3deb: Unknown result type (might be due to invalid IL or missing references)
		//IL_3df5: Expected O, but got Unknown
		//IL_3ed0: Unknown result type (might be due to invalid IL or missing references)
		//IL_3eda: Expected O, but got Unknown
		//IL_3fdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_3fe5: Expected O, but got Unknown
		//IL_4103: Unknown result type (might be due to invalid IL or missing references)
		//IL_410d: Expected O, but got Unknown
		//IL_41d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_41e3: Expected O, but got Unknown
		//IL_42cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_42d7: Expected O, but got Unknown
		//IL_43c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_43cb: Expected O, but got Unknown
		//IL_44ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_44f4: Expected O, but got Unknown
		//IL_45b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_45ba: Expected O, but got Unknown
		//IL_46a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_46ab: Expected O, but got Unknown
		//IL_4792: Unknown result type (might be due to invalid IL or missing references)
		//IL_479c: Expected O, but got Unknown
		//IL_48ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_48c4: Expected O, but got Unknown
		//IL_4993: Unknown result type (might be due to invalid IL or missing references)
		//IL_499d: Expected O, but got Unknown
		//IL_4a87: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a91: Expected O, but got Unknown
		//IL_4b7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b85: Expected O, but got Unknown
		//IL_4c60: Unknown result type (might be due to invalid IL or missing references)
		//IL_4c6a: Expected O, but got Unknown
		//IL_4dbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_4dc7: Expected O, but got Unknown
		//IL_4ddc: Unknown result type (might be due to invalid IL or missing references)
		//IL_4de6: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmUpdSP));
		ToolTip1 = new ToolTip(components);
		_fraWhatAmIDoing_2 = new GroupBox();
		_fraAuto_4 = new Panel();
		_fraAuto_3 = new Panel();
		_optOverSprayCntlType_2 = new RadioButton();
		_optOverSprayCntlType_3 = new RadioButton();
		_Label4_17 = new Label();
		_fraAuto_5 = new Panel();
		_optBoothVentType_2 = new RadioButton();
		_optBoothVentType_3 = new RadioButton();
		_Label4_19 = new Label();
		_optElecAddType_0 = new RadioButton();
		_optElecAddType_1 = new RadioButton();
		_Label4_18 = new Label();
		cmdCancel = new Button();
		cmdOK = new Button();
		_fraWhatAmIDoing_1 = new GroupBox();
		cmdCalcX = new Button();
		_txtXya_4 = new TextBox();
		_txtXya_3 = new TextBox();
		_txtXya_2 = new TextBox();
		_txtXya_1 = new TextBox();
		_txtXya_0 = new TextBox();
		_txtXmwa_4 = new TextBox();
		_txtXmwa_3 = new TextBox();
		_txtXmwa_2 = new TextBox();
		_txtXmwa_1 = new TextBox();
		_txtXmwa_0 = new TextBox();
		_optX_4 = new RadioButton();
		_optX_3 = new RadioButton();
		_optX_2 = new RadioButton();
		_optX_1 = new RadioButton();
		_optX_0 = new RadioButton();
		txtXuserdef = new TextBox();
		_lblX_3 = new Label();
		_lblX_2 = new Label();
		_lblX_1 = new Label();
		_lblX_0 = new Label();
		_Line1_1 = new Label();
		lblY = new Label();
		_Line1_4 = new Label();
		lblMW = new Label();
		_Line1_11 = new Label();
		_Line1_10 = new Label();
		_Line1_9 = new Label();
		_Line1_8 = new Label();
		_Line1_7 = new Label();
		_Line1_3 = new Label();
		_Label4_14 = new Label();
		_Label4_13 = new Label();
		_Label4_12 = new Label();
		_Label4_11 = new Label();
		_Label4_10 = new Label();
		_Label4_9 = new Label();
		_Label4_8 = new Label();
		_Label4_7 = new Label();
		_Label4_6 = new Label();
		_Label4_4 = new Label();
		_Line1_6 = new Label();
		_Label4_1 = new Label();
		_Line1_5 = new Label();
		_Label4_5 = new Label();
		_Line1_2 = new Label();
		_Line1_0 = new Label();
		_Label4_3 = new Label();
		_Label4_0 = new Label();
		_fraWhatAmIDoing_0 = new GroupBox();
		_fraAuto_1 = new Panel();
		_optOverSprayCntlType_0 = new RadioButton();
		_optOverSprayCntlType_1 = new RadioButton();
		_Label4_15 = new Label();
		_fraAuto_0 = new Panel();
		_optSprayGunType_0 = new RadioButton();
		_optSprayGunType_1 = new RadioButton();
		_Label4_2 = new Label();
		_fraAuto_2 = new Panel();
		_optBoothVentType_0 = new RadioButton();
		_optBoothVentType_1 = new RadioButton();
		_Label4_16 = new Label();
		lblInstructions = new Label();
		Label4 = new LabelArray(components);
		Line1 = new LabelArray(components);
		fraAuto = new PanelArray(components);
		fraWhatAmIDoing = new GroupBoxArray(components);
		lblX = new LabelArray(components);
		optBoothVentType = new RadioButtonArray(components);
		optElecAddType = new RadioButtonArray(components);
		optOverSprayCntlType = new RadioButtonArray(components);
		optSprayGunType = new RadioButtonArray(components);
		optX = new RadioButtonArray(components);
		txtXmwa = new TextBoxArray(components);
		txtXya = new TextBoxArray(components);
		((Control)_fraWhatAmIDoing_2).SuspendLayout();
		((Control)_fraAuto_3).SuspendLayout();
		((Control)_fraAuto_5).SuspendLayout();
		((Control)_fraWhatAmIDoing_1).SuspendLayout();
		((Control)_fraWhatAmIDoing_0).SuspendLayout();
		((Control)_fraAuto_1).SuspendLayout();
		((Control)_fraAuto_0).SuspendLayout();
		((Control)_fraAuto_2).SuspendLayout();
		((ISupportInitialize)Label4).BeginInit();
		((ISupportInitialize)Line1).BeginInit();
		((ISupportInitialize)fraAuto).BeginInit();
		((ISupportInitialize)fraWhatAmIDoing).BeginInit();
		((ISupportInitialize)lblX).BeginInit();
		((ISupportInitialize)optBoothVentType).BeginInit();
		((ISupportInitialize)optElecAddType).BeginInit();
		((ISupportInitialize)optOverSprayCntlType).BeginInit();
		((ISupportInitialize)optSprayGunType).BeginInit();
		((ISupportInitialize)optX).BeginInit();
		((ISupportInitialize)txtXmwa).BeginInit();
		((ISupportInitialize)txtXya).BeginInit();
		((Control)this).SuspendLayout();
		((Control)_fraWhatAmIDoing_2).BackColor = SystemColors.Control;
		((Control)_fraWhatAmIDoing_2).Controls.Add((Control)(object)_fraAuto_4);
		((Control)_fraWhatAmIDoing_2).Controls.Add((Control)(object)_fraAuto_3);
		((Control)_fraWhatAmIDoing_2).Controls.Add((Control)(object)_fraAuto_5);
		((Control)_fraWhatAmIDoing_2).Controls.Add((Control)(object)_optElecAddType_0);
		((Control)_fraWhatAmIDoing_2).Controls.Add((Control)(object)_optElecAddType_1);
		((Control)_fraWhatAmIDoing_2).Controls.Add((Control)(object)_Label4_18);
		((Control)_fraWhatAmIDoing_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_fraWhatAmIDoing_2).ForeColor = SystemColors.ControlText;
		fraWhatAmIDoing.SetIndex(_fraWhatAmIDoing_2, (short)2);
		GroupBox fraWhatAmIDoing_ = _fraWhatAmIDoing_2;
		Point location = new Point(16, 48);
		((Control)fraWhatAmIDoing_).Location = location;
		((Control)_fraWhatAmIDoing_2).Name = "_fraWhatAmIDoing_2";
		((Control)_fraWhatAmIDoing_2).RightToLeft = (RightToLeft)0;
		GroupBox fraWhatAmIDoing_2 = _fraWhatAmIDoing_2;
		Size size = new Size(591, 289);
		((Control)fraWhatAmIDoing_2).Size = size;
		((Control)_fraWhatAmIDoing_2).TabIndex = 54;
		_fraWhatAmIDoing_2.TabStop = false;
		((Control)_fraWhatAmIDoing_2).Visible = false;
		((Control)_fraAuto_4).BackColor = SystemColors.Control;
		((Control)_fraAuto_4).Cursor = Cursors.Default;
		((Control)_fraAuto_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_fraAuto_4).ForeColor = SystemColors.ControlText;
		fraAuto.SetIndex(_fraAuto_4, (short)4);
		Panel fraAuto_ = _fraAuto_4;
		location = new Point(432, 192);
		((Control)fraAuto_).Location = location;
		((Control)_fraAuto_4).Name = "_fraAuto_4";
		((Control)_fraAuto_4).RightToLeft = (RightToLeft)0;
		Panel fraAuto_2 = _fraAuto_4;
		size = new Size(409, 73);
		((Control)fraAuto_2).Size = size;
		((Control)_fraAuto_4).TabIndex = 65;
		((Control)_fraAuto_3).BackColor = SystemColors.Control;
		((Control)_fraAuto_3).Controls.Add((Control)(object)_optOverSprayCntlType_2);
		((Control)_fraAuto_3).Controls.Add((Control)(object)_optOverSprayCntlType_3);
		((Control)_fraAuto_3).Controls.Add((Control)(object)_Label4_17);
		((Control)_fraAuto_3).Cursor = Cursors.Default;
		((Control)_fraAuto_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_fraAuto_3).ForeColor = SystemColors.ControlText;
		fraAuto.SetIndex(_fraAuto_3, (short)3);
		Panel fraAuto_3 = _fraAuto_3;
		location = new Point(432, 112);
		((Control)fraAuto_3).Location = location;
		((Control)_fraAuto_3).Name = "_fraAuto_3";
		((Control)_fraAuto_3).RightToLeft = (RightToLeft)0;
		Panel fraAuto_4 = _fraAuto_3;
		size = new Size(409, 73);
		((Control)fraAuto_4).Size = size;
		((Control)_fraAuto_3).TabIndex = 61;
		((Control)_fraAuto_3).Visible = false;
		((ButtonBase)_optOverSprayCntlType_2).BackColor = SystemColors.Control;
		((Control)_optOverSprayCntlType_2).Cursor = Cursors.Default;
		((Control)_optOverSprayCntlType_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optOverSprayCntlType_2).ForeColor = SystemColors.ControlText;
		optOverSprayCntlType.SetIndex(_optOverSprayCntlType_2, (short)2);
		RadioButton optOverSprayCntlType_ = _optOverSprayCntlType_2;
		location = new Point(176, 16);
		((Control)optOverSprayCntlType_).Location = location;
		((Control)_optOverSprayCntlType_2).Name = "_optOverSprayCntlType_2";
		((Control)_optOverSprayCntlType_2).RightToLeft = (RightToLeft)0;
		RadioButton optOverSprayCntlType_2 = _optOverSprayCntlType_2;
		size = new Size(177, 17);
		((Control)optOverSprayCntlType_2).Size = size;
		((Control)_optOverSprayCntlType_2).TabIndex = 63;
		_optOverSprayCntlType_2.TabStop = true;
		((ButtonBase)_optOverSprayCntlType_2).Text = "Waterwash";
		((ButtonBase)_optOverSprayCntlType_2).UseVisualStyleBackColor = false;
		((ButtonBase)_optOverSprayCntlType_3).BackColor = SystemColors.Control;
		((Control)_optOverSprayCntlType_3).Cursor = Cursors.Default;
		((Control)_optOverSprayCntlType_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optOverSprayCntlType_3).ForeColor = SystemColors.ControlText;
		optOverSprayCntlType.SetIndex(_optOverSprayCntlType_3, (short)3);
		RadioButton optOverSprayCntlType_3 = _optOverSprayCntlType_3;
		location = new Point(176, 40);
		((Control)optOverSprayCntlType_3).Location = location;
		((Control)_optOverSprayCntlType_3).Name = "_optOverSprayCntlType_3";
		((Control)_optOverSprayCntlType_3).RightToLeft = (RightToLeft)0;
		RadioButton optOverSprayCntlType_4 = _optOverSprayCntlType_3;
		size = new Size(177, 17);
		((Control)optOverSprayCntlType_4).Size = size;
		((Control)_optOverSprayCntlType_3).TabIndex = 62;
		_optOverSprayCntlType_3.TabStop = true;
		((ButtonBase)_optOverSprayCntlType_3).Text = "Dry Filter";
		((ButtonBase)_optOverSprayCntlType_3).UseVisualStyleBackColor = false;
		((Control)_Label4_17).BackColor = SystemColors.Control;
		((Control)_Label4_17).Cursor = Cursors.Default;
		((Control)_Label4_17).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_17).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_17, (short)17);
		Label label4_ = _Label4_17;
		location = new Point(8, 16);
		((Control)label4_).Location = location;
		((Control)_Label4_17).Name = "_Label4_17";
		((Control)_Label4_17).RightToLeft = (RightToLeft)0;
		Label label4_2 = _Label4_17;
		size = new Size(153, 17);
		((Control)label4_2).Size = size;
		((Control)_Label4_17).TabIndex = 64;
		_Label4_17.Text = "Overspray Control Type:";
		_Label4_17.TextAlign = (ContentAlignment)4;
		((Control)_fraAuto_5).BackColor = SystemColors.Control;
		((Control)_fraAuto_5).Controls.Add((Control)(object)_optBoothVentType_2);
		((Control)_fraAuto_5).Controls.Add((Control)(object)_optBoothVentType_3);
		((Control)_fraAuto_5).Controls.Add((Control)(object)_Label4_19);
		((Control)_fraAuto_5).Cursor = Cursors.Default;
		((Control)_fraAuto_5).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_fraAuto_5).ForeColor = SystemColors.ControlText;
		fraAuto.SetIndex(_fraAuto_5, (short)5);
		Panel fraAuto_5 = _fraAuto_5;
		location = new Point(440, 168);
		((Control)fraAuto_5).Location = location;
		((Control)_fraAuto_5).Name = "_fraAuto_5";
		((Control)_fraAuto_5).RightToLeft = (RightToLeft)0;
		Panel fraAuto_6 = _fraAuto_5;
		size = new Size(409, 73);
		((Control)fraAuto_6).Size = size;
		((Control)_fraAuto_5).TabIndex = 57;
		((Control)_fraAuto_5).Visible = false;
		((ButtonBase)_optBoothVentType_2).BackColor = SystemColors.Control;
		((Control)_optBoothVentType_2).Cursor = Cursors.Default;
		((Control)_optBoothVentType_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optBoothVentType_2).ForeColor = SystemColors.ControlText;
		optBoothVentType.SetIndex(_optBoothVentType_2, (short)2);
		RadioButton optBoothVentType_ = _optBoothVentType_2;
		location = new Point(176, 24);
		((Control)optBoothVentType_).Location = location;
		((Control)_optBoothVentType_2).Name = "_optBoothVentType_2";
		((Control)_optBoothVentType_2).RightToLeft = (RightToLeft)0;
		RadioButton optBoothVentType_2 = _optBoothVentType_2;
		size = new Size(177, 17);
		((Control)optBoothVentType_2).Size = size;
		((Control)_optBoothVentType_2).TabIndex = 59;
		_optBoothVentType_2.TabStop = true;
		((ButtonBase)_optBoothVentType_2).Text = "Downdraft";
		((ButtonBase)_optBoothVentType_2).UseVisualStyleBackColor = false;
		((ButtonBase)_optBoothVentType_3).BackColor = SystemColors.Control;
		((Control)_optBoothVentType_3).Cursor = Cursors.Default;
		((Control)_optBoothVentType_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optBoothVentType_3).ForeColor = SystemColors.ControlText;
		optBoothVentType.SetIndex(_optBoothVentType_3, (short)3);
		RadioButton optBoothVentType_3 = _optBoothVentType_3;
		location = new Point(176, 48);
		((Control)optBoothVentType_3).Location = location;
		((Control)_optBoothVentType_3).Name = "_optBoothVentType_3";
		((Control)_optBoothVentType_3).RightToLeft = (RightToLeft)0;
		RadioButton optBoothVentType_4 = _optBoothVentType_3;
		size = new Size(177, 17);
		((Control)optBoothVentType_4).Size = size;
		((Control)_optBoothVentType_3).TabIndex = 58;
		_optBoothVentType_3.TabStop = true;
		((ButtonBase)_optBoothVentType_3).Text = "Crossdraft";
		((ButtonBase)_optBoothVentType_3).UseVisualStyleBackColor = false;
		((Control)_Label4_19).BackColor = SystemColors.Control;
		((Control)_Label4_19).Cursor = Cursors.Default;
		((Control)_Label4_19).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_19).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_19, (short)19);
		Label label4_3 = _Label4_19;
		location = new Point(0, 24);
		((Control)label4_3).Location = location;
		((Control)_Label4_19).Name = "_Label4_19";
		((Control)_Label4_19).RightToLeft = (RightToLeft)0;
		Label label4_4 = _Label4_19;
		size = new Size(153, 17);
		((Control)label4_4).Size = size;
		((Control)_Label4_19).TabIndex = 60;
		_Label4_19.Text = "Booth Vent Type:";
		_Label4_19.TextAlign = (ContentAlignment)4;
		((ButtonBase)_optElecAddType_0).BackColor = SystemColors.Control;
		((Control)_optElecAddType_0).Cursor = Cursors.Default;
		((Control)_optElecAddType_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optElecAddType_0).ForeColor = SystemColors.ControlText;
		optElecAddType.SetIndex(_optElecAddType_0, (short)0);
		RadioButton optElecAddType_ = _optElecAddType_0;
		location = new Point(216, 88);
		((Control)optElecAddType_).Location = location;
		((Control)_optElecAddType_0).Name = "_optElecAddType_0";
		((Control)_optElecAddType_0).RightToLeft = (RightToLeft)0;
		RadioButton optElecAddType_2 = _optElecAddType_0;
		size = new Size(169, 33);
		((Control)optElecAddType_2).Size = size;
		((Control)_optElecAddType_0).TabIndex = 56;
		_optElecAddType_0.TabStop = true;
		((ButtonBase)_optElecAddType_0).Text = "Organic Compounds";
		((ButtonBase)_optElecAddType_0).UseVisualStyleBackColor = false;
		((ButtonBase)_optElecAddType_1).BackColor = SystemColors.Control;
		((Control)_optElecAddType_1).Cursor = Cursors.Default;
		((Control)_optElecAddType_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optElecAddType_1).ForeColor = SystemColors.ControlText;
		optElecAddType.SetIndex(_optElecAddType_1, (short)1);
		RadioButton optElecAddType_3 = _optElecAddType_1;
		location = new Point(216, 120);
		((Control)optElecAddType_3).Location = location;
		((Control)_optElecAddType_1).Name = "_optElecAddType_1";
		((Control)_optElecAddType_1).RightToLeft = (RightToLeft)0;
		RadioButton optElecAddType_4 = _optElecAddType_1;
		size = new Size(225, 33);
		((Control)optElecAddType_4).Size = size;
		((Control)_optElecAddType_1).TabIndex = 55;
		_optElecAddType_1.TabStop = true;
		((ButtonBase)_optElecAddType_1).Text = "Suspended Solids";
		((ButtonBase)_optElecAddType_1).UseVisualStyleBackColor = false;
		((Control)_Label4_18).BackColor = SystemColors.Control;
		((Control)_Label4_18).Cursor = Cursors.Default;
		((Control)_Label4_18).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_18).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_18, (short)18);
		Label label4_5 = _Label4_18;
		location = new Point(48, 96);
		((Control)label4_5).Location = location;
		((Control)_Label4_18).Name = "_Label4_18";
		((Control)_Label4_18).RightToLeft = (RightToLeft)0;
		Label label4_6 = _Label4_18;
		size = new Size(153, 17);
		((Control)label4_6).Size = size;
		((Control)_Label4_18).TabIndex = 66;
		_Label4_18.Text = "Electroplating Additive Type:";
		_Label4_18.TextAlign = (ContentAlignment)4;
		((ButtonBase)cmdCancel).BackColor = SystemColors.Control;
		((Control)cmdCancel).Cursor = Cursors.Default;
		((Control)cmdCancel).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCancel).ForeColor = SystemColors.ControlText;
		Button obj = cmdCancel;
		location = new Point(312, 355);
		((Control)obj).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		((Control)cmdCancel).RightToLeft = (RightToLeft)0;
		Button obj2 = cmdCancel;
		size = new Size(89, 20);
		((Control)obj2).Size = size;
		((Control)cmdCancel).TabIndex = 18;
		((ButtonBase)cmdCancel).Text = "Cancel";
		((ButtonBase)cmdCancel).UseVisualStyleBackColor = false;
		((ButtonBase)cmdOK).BackColor = SystemColors.Control;
		((Control)cmdOK).Cursor = Cursors.Default;
		((Control)cmdOK).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdOK).ForeColor = SystemColors.ControlText;
		Button obj3 = cmdOK;
		location = new Point(208, 355);
		((Control)obj3).Location = location;
		((Control)cmdOK).Name = "cmdOK";
		((Control)cmdOK).RightToLeft = (RightToLeft)0;
		Button obj4 = cmdOK;
		size = new Size(89, 20);
		((Control)obj4).Size = size;
		((Control)cmdOK).TabIndex = 0;
		((ButtonBase)cmdOK).Text = "OK";
		((ButtonBase)cmdOK).UseVisualStyleBackColor = false;
		((Control)_fraWhatAmIDoing_1).BackColor = SystemColors.Control;
		((Control)_fraWhatAmIDoing_1).Controls.Add((Control)(object)cmdCalcX);
		((Control)_fraWhatAmIDoing_1).Controls.Add((Control)(object)_txtXya_4);
		((Control)_fraWhatAmIDoing_1).Controls.Add((Control)(object)_txtXya_3);
		((Control)_fraWhatAmIDoing_1).Controls.Add((Control)(object)_txtXya_2);
		((Control)_fraWhatAmIDoing_1).Controls.Add((Control)(object)_txtXya_1);
		((Control)_fraWhatAmIDoing_1).Controls.Add((Control)(object)_txtXya_0);
		((Control)_fraWhatAmIDoing_1).Controls.Add((Control)(object)_txtXmwa_4);
		((Control)_fraWhatAmIDoing_1).Controls.Add((Control)(object)_txtXmwa_3);
		((Control)_fraWhatAmIDoing_1).Controls.Add((Control)(object)_txtXmwa_2);
		((Control)_fraWhatAmIDoing_1).Controls.Add((Control)(object)_txtXmwa_1);
		((Control)_fraWhatAmIDoing_1).Controls.Add((Control)(object)_txtXmwa_0);
		((Control)_fraWhatAmIDoing_1).Controls.Add((Control)(object)_optX_4);
		((Control)_fraWhatAmIDoing_1).Controls.Add((Control)(object)_optX_3);
		((Control)_fraWhatAmIDoing_1).Controls.Add((Control)(object)_optX_2);
		((Control)_fraWhatAmIDoing_1).Controls.Add((Control)(object)_optX_1);
		((Control)_fraWhatAmIDoing_1).Controls.Add((Control)(object)_optX_0);
		((Control)_fraWhatAmIDoing_1).Controls.Add((Control)(object)txtXuserdef);
		((Control)_fraWhatAmIDoing_1).Controls.Add((Control)(object)_lblX_3);
		((Control)_fraWhatAmIDoing_1).Controls.Add((Control)(object)_lblX_2);
		((Control)_fraWhatAmIDoing_1).Controls.Add((Control)(object)_lblX_1);
		((Control)_fraWhatAmIDoing_1).Controls.Add((Control)(object)_lblX_0);
		((Control)_fraWhatAmIDoing_1).Controls.Add((Control)(object)_Line1_1);
		((Control)_fraWhatAmIDoing_1).Controls.Add((Control)(object)lblY);
		((Control)_fraWhatAmIDoing_1).Controls.Add((Control)(object)_Line1_4);
		((Control)_fraWhatAmIDoing_1).Controls.Add((Control)(object)lblMW);
		((Control)_fraWhatAmIDoing_1).Controls.Add((Control)(object)_Line1_11);
		((Control)_fraWhatAmIDoing_1).Controls.Add((Control)(object)_Line1_10);
		((Control)_fraWhatAmIDoing_1).Controls.Add((Control)(object)_Line1_9);
		((Control)_fraWhatAmIDoing_1).Controls.Add((Control)(object)_Line1_8);
		((Control)_fraWhatAmIDoing_1).Controls.Add((Control)(object)_Line1_7);
		((Control)_fraWhatAmIDoing_1).Controls.Add((Control)(object)_Line1_3);
		((Control)_fraWhatAmIDoing_1).Controls.Add((Control)(object)_Label4_14);
		((Control)_fraWhatAmIDoing_1).Controls.Add((Control)(object)_Label4_13);
		((Control)_fraWhatAmIDoing_1).Controls.Add((Control)(object)_Label4_12);
		((Control)_fraWhatAmIDoing_1).Controls.Add((Control)(object)_Label4_11);
		((Control)_fraWhatAmIDoing_1).Controls.Add((Control)(object)_Label4_10);
		((Control)_fraWhatAmIDoing_1).Controls.Add((Control)(object)_Label4_9);
		((Control)_fraWhatAmIDoing_1).Controls.Add((Control)(object)_Label4_8);
		((Control)_fraWhatAmIDoing_1).Controls.Add((Control)(object)_Label4_7);
		((Control)_fraWhatAmIDoing_1).Controls.Add((Control)(object)_Label4_6);
		((Control)_fraWhatAmIDoing_1).Controls.Add((Control)(object)_Label4_4);
		((Control)_fraWhatAmIDoing_1).Controls.Add((Control)(object)_Line1_6);
		((Control)_fraWhatAmIDoing_1).Controls.Add((Control)(object)_Label4_1);
		((Control)_fraWhatAmIDoing_1).Controls.Add((Control)(object)_Line1_5);
		((Control)_fraWhatAmIDoing_1).Controls.Add((Control)(object)_Label4_5);
		((Control)_fraWhatAmIDoing_1).Controls.Add((Control)(object)_Line1_2);
		((Control)_fraWhatAmIDoing_1).Controls.Add((Control)(object)_Line1_0);
		((Control)_fraWhatAmIDoing_1).Controls.Add((Control)(object)_Label4_3);
		((Control)_fraWhatAmIDoing_1).Controls.Add((Control)(object)_Label4_0);
		((Control)_fraWhatAmIDoing_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_fraWhatAmIDoing_1).ForeColor = SystemColors.ControlText;
		fraWhatAmIDoing.SetIndex(_fraWhatAmIDoing_1, (short)1);
		GroupBox fraWhatAmIDoing_3 = _fraWhatAmIDoing_1;
		location = new Point(16, 48);
		((Control)fraWhatAmIDoing_3).Location = location;
		((Control)_fraWhatAmIDoing_1).Name = "_fraWhatAmIDoing_1";
		((Control)_fraWhatAmIDoing_1).RightToLeft = (RightToLeft)0;
		GroupBox fraWhatAmIDoing_4 = _fraWhatAmIDoing_1;
		size = new Size(582, 289);
		((Control)fraWhatAmIDoing_4).Size = size;
		((Control)_fraWhatAmIDoing_1).TabIndex = 19;
		_fraWhatAmIDoing_1.TabStop = false;
		((Control)_fraWhatAmIDoing_1).Visible = false;
		((ButtonBase)cmdCalcX).BackColor = SystemColors.Control;
		((Control)cmdCalcX).Cursor = Cursors.Default;
		((Control)cmdCalcX).Enabled = false;
		((Control)cmdCalcX).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCalcX).ForeColor = SystemColors.ControlText;
		Button obj5 = cmdCalcX;
		location = new Point(253, 216);
		((Control)obj5).Location = location;
		((Control)cmdCalcX).Name = "cmdCalcX";
		((Control)cmdCalcX).RightToLeft = (RightToLeft)0;
		Button obj6 = cmdCalcX;
		size = new Size(89, 25);
		((Control)obj6).Size = size;
		((Control)cmdCalcX).TabIndex = 15;
		((ButtonBase)cmdCalcX).Text = "Calculate";
		((ButtonBase)cmdCalcX).UseVisualStyleBackColor = false;
		_txtXya_4.AcceptsReturn = true;
		((TextBoxBase)_txtXya_4).BackColor = SystemColors.Window;
		((Control)_txtXya_4).Cursor = Cursors.IBeam;
		((Control)_txtXya_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtXya_4).ForeColor = SystemColors.WindowText;
		txtXya.SetIndex(_txtXya_4, (short)4);
		TextBox txtXya_ = _txtXya_4;
		location = new Point(477, 186);
		((Control)txtXya_).Location = location;
		((TextBoxBase)_txtXya_4).MaxLength = 5;
		((Control)_txtXya_4).Name = "_txtXya_4";
		((Control)_txtXya_4).RightToLeft = (RightToLeft)0;
		TextBox txtXya_2 = _txtXya_4;
		size = new Size(41, 20);
		((Control)txtXya_2).Size = size;
		((Control)_txtXya_4).TabIndex = 14;
		_txtXya_3.AcceptsReturn = true;
		((TextBoxBase)_txtXya_3).BackColor = SystemColors.Window;
		((Control)_txtXya_3).Cursor = Cursors.IBeam;
		((Control)_txtXya_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtXya_3).ForeColor = SystemColors.WindowText;
		txtXya.SetIndex(_txtXya_3, (short)3);
		TextBox txtXya_3 = _txtXya_3;
		location = new Point(421, 186);
		((Control)txtXya_3).Location = location;
		((TextBoxBase)_txtXya_3).MaxLength = 5;
		((Control)_txtXya_3).Name = "_txtXya_3";
		((Control)_txtXya_3).RightToLeft = (RightToLeft)0;
		TextBox txtXya_4 = _txtXya_3;
		size = new Size(41, 20);
		((Control)txtXya_4).Size = size;
		((Control)_txtXya_3).TabIndex = 12;
		_txtXya_2.AcceptsReturn = true;
		((TextBoxBase)_txtXya_2).BackColor = SystemColors.Window;
		((Control)_txtXya_2).Cursor = Cursors.IBeam;
		((Control)_txtXya_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtXya_2).ForeColor = SystemColors.WindowText;
		txtXya.SetIndex(_txtXya_2, (short)2);
		TextBox txtXya_5 = _txtXya_2;
		location = new Point(365, 186);
		((Control)txtXya_5).Location = location;
		((TextBoxBase)_txtXya_2).MaxLength = 5;
		((Control)_txtXya_2).Name = "_txtXya_2";
		((Control)_txtXya_2).RightToLeft = (RightToLeft)0;
		TextBox txtXya_6 = _txtXya_2;
		size = new Size(41, 20);
		((Control)txtXya_6).Size = size;
		((Control)_txtXya_2).TabIndex = 10;
		_txtXya_1.AcceptsReturn = true;
		((TextBoxBase)_txtXya_1).BackColor = SystemColors.Window;
		((Control)_txtXya_1).Cursor = Cursors.IBeam;
		((Control)_txtXya_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtXya_1).ForeColor = SystemColors.WindowText;
		txtXya.SetIndex(_txtXya_1, (short)1);
		TextBox txtXya_7 = _txtXya_1;
		location = new Point(309, 186);
		((Control)txtXya_7).Location = location;
		((TextBoxBase)_txtXya_1).MaxLength = 5;
		((Control)_txtXya_1).Name = "_txtXya_1";
		((Control)_txtXya_1).RightToLeft = (RightToLeft)0;
		TextBox txtXya_8 = _txtXya_1;
		size = new Size(41, 20);
		((Control)txtXya_8).Size = size;
		((Control)_txtXya_1).TabIndex = 8;
		_txtXya_0.AcceptsReturn = true;
		((TextBoxBase)_txtXya_0).BackColor = SystemColors.Window;
		((Control)_txtXya_0).Cursor = Cursors.IBeam;
		((Control)_txtXya_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtXya_0).ForeColor = SystemColors.WindowText;
		txtXya.SetIndex(_txtXya_0, (short)0);
		TextBox txtXya_9 = _txtXya_0;
		location = new Point(253, 186);
		((Control)txtXya_9).Location = location;
		((TextBoxBase)_txtXya_0).MaxLength = 5;
		((Control)_txtXya_0).Name = "_txtXya_0";
		((Control)_txtXya_0).RightToLeft = (RightToLeft)0;
		TextBox txtXya_10 = _txtXya_0;
		size = new Size(41, 20);
		((Control)txtXya_10).Size = size;
		((Control)_txtXya_0).TabIndex = 6;
		_txtXmwa_4.AcceptsReturn = true;
		((TextBoxBase)_txtXmwa_4).BackColor = SystemColors.Window;
		((Control)_txtXmwa_4).Cursor = Cursors.IBeam;
		((Control)_txtXmwa_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtXmwa_4).ForeColor = SystemColors.WindowText;
		txtXmwa.SetIndex(_txtXmwa_4, (short)4);
		TextBox txtXmwa_ = _txtXmwa_4;
		location = new Point(477, 163);
		((Control)txtXmwa_).Location = location;
		((TextBoxBase)_txtXmwa_4).MaxLength = 5;
		((Control)_txtXmwa_4).Name = "_txtXmwa_4";
		((Control)_txtXmwa_4).RightToLeft = (RightToLeft)0;
		TextBox txtXmwa_2 = _txtXmwa_4;
		size = new Size(41, 20);
		((Control)txtXmwa_2).Size = size;
		((Control)_txtXmwa_4).TabIndex = 13;
		_txtXmwa_3.AcceptsReturn = true;
		((TextBoxBase)_txtXmwa_3).BackColor = SystemColors.Window;
		((Control)_txtXmwa_3).Cursor = Cursors.IBeam;
		((Control)_txtXmwa_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtXmwa_3).ForeColor = SystemColors.WindowText;
		txtXmwa.SetIndex(_txtXmwa_3, (short)3);
		TextBox txtXmwa_3 = _txtXmwa_3;
		location = new Point(421, 163);
		((Control)txtXmwa_3).Location = location;
		((TextBoxBase)_txtXmwa_3).MaxLength = 5;
		((Control)_txtXmwa_3).Name = "_txtXmwa_3";
		((Control)_txtXmwa_3).RightToLeft = (RightToLeft)0;
		TextBox txtXmwa_4 = _txtXmwa_3;
		size = new Size(41, 20);
		((Control)txtXmwa_4).Size = size;
		((Control)_txtXmwa_3).TabIndex = 11;
		_txtXmwa_2.AcceptsReturn = true;
		((TextBoxBase)_txtXmwa_2).BackColor = SystemColors.Window;
		((Control)_txtXmwa_2).Cursor = Cursors.IBeam;
		((Control)_txtXmwa_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtXmwa_2).ForeColor = SystemColors.WindowText;
		txtXmwa.SetIndex(_txtXmwa_2, (short)2);
		TextBox txtXmwa_5 = _txtXmwa_2;
		location = new Point(365, 163);
		((Control)txtXmwa_5).Location = location;
		((TextBoxBase)_txtXmwa_2).MaxLength = 5;
		((Control)_txtXmwa_2).Name = "_txtXmwa_2";
		((Control)_txtXmwa_2).RightToLeft = (RightToLeft)0;
		TextBox txtXmwa_6 = _txtXmwa_2;
		size = new Size(41, 20);
		((Control)txtXmwa_6).Size = size;
		((Control)_txtXmwa_2).TabIndex = 9;
		_txtXmwa_1.AcceptsReturn = true;
		((TextBoxBase)_txtXmwa_1).BackColor = SystemColors.Window;
		((Control)_txtXmwa_1).Cursor = Cursors.IBeam;
		((Control)_txtXmwa_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtXmwa_1).ForeColor = SystemColors.WindowText;
		txtXmwa.SetIndex(_txtXmwa_1, (short)1);
		TextBox txtXmwa_7 = _txtXmwa_1;
		location = new Point(309, 163);
		((Control)txtXmwa_7).Location = location;
		((TextBoxBase)_txtXmwa_1).MaxLength = 5;
		((Control)_txtXmwa_1).Name = "_txtXmwa_1";
		((Control)_txtXmwa_1).RightToLeft = (RightToLeft)0;
		TextBox txtXmwa_8 = _txtXmwa_1;
		size = new Size(41, 20);
		((Control)txtXmwa_8).Size = size;
		((Control)_txtXmwa_1).TabIndex = 7;
		_txtXmwa_0.AcceptsReturn = true;
		((TextBoxBase)_txtXmwa_0).BackColor = SystemColors.Window;
		((Control)_txtXmwa_0).Cursor = Cursors.IBeam;
		((Control)_txtXmwa_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtXmwa_0).ForeColor = SystemColors.WindowText;
		txtXmwa.SetIndex(_txtXmwa_0, (short)0);
		TextBox txtXmwa_9 = _txtXmwa_0;
		location = new Point(253, 163);
		((Control)txtXmwa_9).Location = location;
		((TextBoxBase)_txtXmwa_0).MaxLength = 5;
		((Control)_txtXmwa_0).Name = "_txtXmwa_0";
		((Control)_txtXmwa_0).RightToLeft = (RightToLeft)0;
		TextBox txtXmwa_10 = _txtXmwa_0;
		size = new Size(41, 20);
		((Control)txtXmwa_10).Size = size;
		((Control)_txtXmwa_0).TabIndex = 5;
		((ButtonBase)_optX_4).BackColor = SystemColors.Control;
		((Control)_optX_4).Cursor = Cursors.Default;
		((Control)_optX_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optX_4).ForeColor = SystemColors.ControlText;
		optX.SetIndex(_optX_4, (short)4);
		RadioButton optX_ = _optX_4;
		location = new Point(16, 256);
		((Control)optX_).Location = location;
		((Control)_optX_4).Name = "_optX_4";
		((Control)_optX_4).RightToLeft = (RightToLeft)0;
		RadioButton optX_2 = _optX_4;
		size = new Size(145, 17);
		((Control)optX_2).Size = size;
		((Control)_optX_4).TabIndex = 16;
		_optX_4.TabStop = true;
		((ButtonBase)_optX_4).Text = "Use User-defined Default:";
		((ButtonBase)_optX_4).UseVisualStyleBackColor = false;
		((ButtonBase)_optX_3).BackColor = SystemColors.Control;
		((Control)_optX_3).Cursor = Cursors.Default;
		((Control)_optX_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optX_3).ForeColor = SystemColors.ControlText;
		optX.SetIndex(_optX_3, (short)3);
		RadioButton optX_3 = _optX_3;
		location = new Point(16, 96);
		((Control)optX_3).Location = location;
		((Control)_optX_3).Name = "_optX_3";
		((Control)_optX_3).RightToLeft = (RightToLeft)0;
		RadioButton optX_4 = _optX_3;
		size = new Size(273, 17);
		((Control)optX_4).Size = size;
		((Control)_optX_3).TabIndex = 4;
		_optX_3.TabStop = true;
		((ButtonBase)_optX_3).Text = "Use Raoult's Law to calculate the mole fraction:";
		((ButtonBase)_optX_3).UseVisualStyleBackColor = false;
		((ButtonBase)_optX_2).BackColor = SystemColors.Control;
		((Control)_optX_2).Cursor = Cursors.Default;
		((Control)_optX_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optX_2).ForeColor = SystemColors.ControlText;
		optX.SetIndex(_optX_2, (short)2);
		RadioButton optX_5 = _optX_2;
		location = new Point(16, 72);
		((Control)optX_5).Location = location;
		((Control)_optX_2).Name = "_optX_2";
		((Control)_optX_2).RightToLeft = (RightToLeft)0;
		RadioButton optX_6 = _optX_2;
		size = new Size(273, 17);
		((Control)optX_6).Size = size;
		((Control)_optX_2).TabIndex = 3;
		_optX_2.TabStop = true;
		((ButtonBase)_optX_2).Text = "Use the weight fraction to approximate mole fraction:";
		((ButtonBase)_optX_2).UseVisualStyleBackColor = false;
		((ButtonBase)_optX_1).BackColor = SystemColors.Control;
		((Control)_optX_1).Cursor = Cursors.Default;
		((Control)_optX_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optX_1).ForeColor = SystemColors.ControlText;
		optX.SetIndex(_optX_1, (short)1);
		RadioButton optX_7 = _optX_1;
		location = new Point(16, 48);
		((Control)optX_7).Location = location;
		((Control)_optX_1).Name = "_optX_1";
		((Control)_optX_1).RightToLeft = (RightToLeft)0;
		RadioButton optX_8 = _optX_1;
		size = new Size(273, 17);
		((Control)optX_8).Size = size;
		((Control)_optX_1).TabIndex = 2;
		_optX_1.TabStop = true;
		((ButtonBase)_optX_1).Text = "Use vapor pressure of the pure chemical:";
		((ButtonBase)_optX_1).UseVisualStyleBackColor = false;
		((ButtonBase)_optX_0).BackColor = SystemColors.Control;
		((Control)_optX_0).Cursor = Cursors.Default;
		((Control)_optX_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optX_0).ForeColor = SystemColors.ControlText;
		optX.SetIndex(_optX_0, (short)0);
		RadioButton optX_9 = _optX_0;
		location = new Point(16, 24);
		((Control)optX_9).Location = location;
		((Control)_optX_0).Name = "_optX_0";
		((Control)_optX_0).RightToLeft = (RightToLeft)0;
		RadioButton optX_10 = _optX_0;
		size = new Size(153, 17);
		((Control)optX_10).Size = size;
		((Control)_optX_0).TabIndex = 1;
		_optX_0.TabStop = true;
		((ButtonBase)_optX_0).Text = "Use ChemSTEER default:";
		((ButtonBase)_optX_0).UseVisualStyleBackColor = false;
		txtXuserdef.AcceptsReturn = true;
		((TextBoxBase)txtXuserdef).BackColor = SystemColors.Window;
		((Control)txtXuserdef).Cursor = Cursors.IBeam;
		((Control)txtXuserdef).Enabled = false;
		((Control)txtXuserdef).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtXuserdef).ForeColor = SystemColors.WindowText;
		TextBox obj7 = txtXuserdef;
		location = new Point(344, 256);
		((Control)obj7).Location = location;
		((TextBoxBase)txtXuserdef).MaxLength = 5;
		((Control)txtXuserdef).Name = "txtXuserdef";
		((Control)txtXuserdef).RightToLeft = (RightToLeft)0;
		TextBox obj8 = txtXuserdef;
		size = new Size(41, 20);
		((Control)obj8).Size = size;
		((Control)txtXuserdef).TabIndex = 17;
		((Control)_lblX_3).BackColor = SystemColors.Control;
		((Control)_lblX_3).Cursor = Cursors.Default;
		((Control)_lblX_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblX_3).ForeColor = SystemColors.ControlText;
		lblX.SetIndex(_lblX_3, (short)3);
		Label lblX_ = _lblX_3;
		location = new Point(412, 216);
		((Control)lblX_).Location = location;
		((Control)_lblX_3).Name = "_lblX_3";
		((Control)_lblX_3).RightToLeft = (RightToLeft)0;
		Label lblX_2 = _lblX_3;
		size = new Size(113, 17);
		((Control)lblX_2).Size = size;
		((Control)_lblX_3).TabIndex = 41;
		_lblX_3.Text = "Xother = 12.34";
		((Control)_lblX_2).BackColor = SystemColors.Control;
		((Control)_lblX_2).Cursor = Cursors.Default;
		((Control)_lblX_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblX_2).ForeColor = SystemColors.ControlText;
		lblX.SetIndex(_lblX_2, (short)2);
		Label lblX_3 = _lblX_2;
		location = new Point(336, 72);
		((Control)lblX_3).Location = location;
		((Control)_lblX_2).Name = "_lblX_2";
		((Control)_lblX_2).RightToLeft = (RightToLeft)0;
		Label lblX_4 = _lblX_2;
		size = new Size(129, 17);
		((Control)lblX_4).Size = size;
		((Control)_lblX_2).TabIndex = 40;
		_lblX_2.Text = "x";
		((Control)_lblX_1).BackColor = SystemColors.Control;
		((Control)_lblX_1).Cursor = Cursors.Default;
		((Control)_lblX_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblX_1).ForeColor = SystemColors.ControlText;
		lblX.SetIndex(_lblX_1, (short)1);
		Label lblX_5 = _lblX_1;
		location = new Point(336, 48);
		((Control)lblX_5).Location = location;
		((Control)_lblX_1).Name = "_lblX_1";
		((Control)_lblX_1).RightToLeft = (RightToLeft)0;
		Label lblX_6 = _lblX_1;
		size = new Size(121, 17);
		((Control)lblX_6).Size = size;
		((Control)_lblX_1).TabIndex = 39;
		_lblX_1.Text = "x";
		((Control)_lblX_0).BackColor = SystemColors.Control;
		((Control)_lblX_0).Cursor = Cursors.Default;
		((Control)_lblX_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblX_0).ForeColor = SystemColors.ControlText;
		lblX.SetIndex(_lblX_0, (short)0);
		Label lblX_7 = _lblX_0;
		location = new Point(336, 24);
		((Control)lblX_7).Location = location;
		((Control)_lblX_0).Name = "_lblX_0";
		((Control)_lblX_0).RightToLeft = (RightToLeft)0;
		Label lblX_8 = _lblX_0;
		size = new Size(121, 17);
		((Control)lblX_8).Size = size;
		((Control)_lblX_0).TabIndex = 38;
		_lblX_0.Text = "x";
		((Control)_Line1_1).BackColor = SystemColors.WindowText;
		Line1.SetIndex(_Line1_1, (short)1);
		Label line1_ = _Line1_1;
		location = new Point(49, 207);
		((Control)line1_).Location = location;
		((Control)_Line1_1).Name = "_Line1_1";
		Label line1_2 = _Line1_1;
		size = new Size(476, 1);
		((Control)line1_2).Size = size;
		((Control)_Line1_1).TabIndex = 42;
		((Control)lblY).BackColor = SystemColors.Control;
		((Control)lblY).Cursor = Cursors.Default;
		((Control)lblY).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblY).ForeColor = SystemColors.ControlText;
		Label obj9 = lblY;
		location = new Point(197, 191);
		((Control)obj9).Location = location;
		((Control)lblY).Name = "lblY";
		((Control)lblY).RightToLeft = (RightToLeft)0;
		Label obj10 = lblY;
		size = new Size(41, 17);
		((Control)obj10).Size = size;
		((Control)lblY).TabIndex = 37;
		lblY.Text = "Y";
		((Control)_Line1_4).BackColor = SystemColors.WindowText;
		Line1.SetIndex(_Line1_4, (short)4);
		Label line1_3 = _Line1_4;
		location = new Point(49, 183);
		((Control)line1_3).Location = location;
		((Control)_Line1_4).Name = "_Line1_4";
		Label line1_4 = _Line1_4;
		size = new Size(476, 1);
		((Control)line1_4).Size = size;
		((Control)_Line1_4).TabIndex = 43;
		((Control)lblMW).BackColor = SystemColors.Control;
		((Control)lblMW).Cursor = Cursors.Default;
		((Control)lblMW).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblMW).ForeColor = SystemColors.ControlText;
		Label obj11 = lblMW;
		location = new Point(197, 167);
		((Control)obj11).Location = location;
		((Control)lblMW).Name = "lblMW";
		((Control)lblMW).RightToLeft = (RightToLeft)0;
		Label obj12 = lblMW;
		size = new Size(41, 17);
		((Control)obj12).Size = size;
		((Control)lblMW).TabIndex = 36;
		lblMW.Text = "MW";
		((Control)_Line1_11).BackColor = SystemColors.WindowText;
		Line1.SetIndex(_Line1_11, (short)11);
		Label line1_5 = _Line1_11;
		location = new Point(469, 119);
		((Control)line1_5).Location = location;
		((Control)_Line1_11).Name = "_Line1_11";
		Label line1_6 = _Line1_11;
		size = new Size(1, 88);
		((Control)line1_6).Size = size;
		((Control)_Line1_11).TabIndex = 44;
		((Control)_Line1_10).BackColor = SystemColors.WindowText;
		Line1.SetIndex(_Line1_10, (short)10);
		Label line1_7 = _Line1_10;
		location = new Point(413, 119);
		((Control)line1_7).Location = location;
		((Control)_Line1_10).Name = "_Line1_10";
		Label line1_8 = _Line1_10;
		size = new Size(1, 88);
		((Control)line1_8).Size = size;
		((Control)_Line1_10).TabIndex = 45;
		((Control)_Line1_9).BackColor = SystemColors.WindowText;
		Line1.SetIndex(_Line1_9, (short)9);
		Label line1_9 = _Line1_9;
		location = new Point(357, 119);
		((Control)line1_9).Location = location;
		((Control)_Line1_9).Name = "_Line1_9";
		Label line1_10 = _Line1_9;
		size = new Size(1, 88);
		((Control)line1_10).Size = size;
		((Control)_Line1_9).TabIndex = 46;
		((Control)_Line1_8).BackColor = SystemColors.WindowText;
		Line1.SetIndex(_Line1_8, (short)8);
		Label line1_11 = _Line1_8;
		location = new Point(301, 119);
		((Control)line1_11).Location = location;
		((Control)_Line1_8).Name = "_Line1_8";
		Label line1_12 = _Line1_8;
		size = new Size(1, 88);
		((Control)line1_12).Size = size;
		((Control)_Line1_8).TabIndex = 47;
		((Control)_Line1_7).BackColor = SystemColors.WindowText;
		Line1.SetIndex(_Line1_7, (short)7);
		Label line1_13 = _Line1_7;
		location = new Point(525, 119);
		((Control)line1_13).Location = location;
		((Control)_Line1_7).Name = "_Line1_7";
		Label line1_14 = _Line1_7;
		size = new Size(1, 88);
		((Control)line1_14).Size = size;
		((Control)_Line1_7).TabIndex = 48;
		((Control)_Line1_3).BackColor = SystemColors.WindowText;
		Line1.SetIndex(_Line1_3, (short)3);
		Label line1_15 = _Line1_3;
		location = new Point(49, 159);
		((Control)line1_15).Location = location;
		((Control)_Line1_3).Name = "_Line1_3";
		Label line1_16 = _Line1_3;
		size = new Size(476, 1);
		((Control)line1_16).Size = size;
		((Control)_Line1_3).TabIndex = 49;
		((Control)_Label4_14).BackColor = SystemColors.Control;
		((Control)_Label4_14).Cursor = Cursors.Default;
		((Control)_Label4_14).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_14).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_14, (short)14);
		Label label4_7 = _Label4_14;
		location = new Point(477, 143);
		((Control)label4_7).Location = location;
		((Control)_Label4_14).Name = "_Label4_14";
		((Control)_Label4_14).RightToLeft = (RightToLeft)0;
		Label label4_8 = _Label4_14;
		size = new Size(49, 17);
		((Control)label4_8).Size = size;
		((Control)_Label4_14).TabIndex = 35;
		_Label4_14.Text = "5";
		_Label4_14.TextAlign = (ContentAlignment)2;
		((Control)_Label4_13).BackColor = SystemColors.Control;
		((Control)_Label4_13).Cursor = Cursors.Default;
		((Control)_Label4_13).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_13).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_13, (short)13);
		Label label4_9 = _Label4_13;
		location = new Point(421, 143);
		((Control)label4_9).Location = location;
		((Control)_Label4_13).Name = "_Label4_13";
		((Control)_Label4_13).RightToLeft = (RightToLeft)0;
		Label label4_10 = _Label4_13;
		size = new Size(49, 17);
		((Control)label4_10).Size = size;
		((Control)_Label4_13).TabIndex = 34;
		_Label4_13.Text = "4";
		_Label4_13.TextAlign = (ContentAlignment)2;
		((Control)_Label4_12).BackColor = SystemColors.Control;
		((Control)_Label4_12).Cursor = Cursors.Default;
		((Control)_Label4_12).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_12).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_12, (short)12);
		Label label4_11 = _Label4_12;
		location = new Point(365, 143);
		((Control)label4_11).Location = location;
		((Control)_Label4_12).Name = "_Label4_12";
		((Control)_Label4_12).RightToLeft = (RightToLeft)0;
		Label label4_12 = _Label4_12;
		size = new Size(49, 17);
		((Control)label4_12).Size = size;
		((Control)_Label4_12).TabIndex = 33;
		_Label4_12.Text = "3";
		_Label4_12.TextAlign = (ContentAlignment)2;
		((Control)_Label4_11).BackColor = SystemColors.Control;
		((Control)_Label4_11).Cursor = Cursors.Default;
		((Control)_Label4_11).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_11).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_11, (short)11);
		Label label4_13 = _Label4_11;
		location = new Point(309, 143);
		((Control)label4_13).Location = location;
		((Control)_Label4_11).Name = "_Label4_11";
		((Control)_Label4_11).RightToLeft = (RightToLeft)0;
		Label label4_14 = _Label4_11;
		size = new Size(49, 17);
		((Control)label4_14).Size = size;
		((Control)_Label4_11).TabIndex = 32;
		_Label4_11.Text = "2";
		_Label4_11.TextAlign = (ContentAlignment)2;
		((Control)_Label4_10).BackColor = SystemColors.Control;
		((Control)_Label4_10).Cursor = Cursors.Default;
		((Control)_Label4_10).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_10).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_10, (short)10);
		Label label4_15 = _Label4_10;
		location = new Point(253, 143);
		((Control)label4_15).Location = location;
		((Control)_Label4_10).Name = "_Label4_10";
		((Control)_Label4_10).RightToLeft = (RightToLeft)0;
		Label label4_16 = _Label4_10;
		size = new Size(49, 17);
		((Control)label4_16).Size = size;
		((Control)_Label4_10).TabIndex = 31;
		_Label4_10.Text = "1";
		_Label4_10.TextAlign = (ContentAlignment)2;
		((Control)_Label4_9).BackColor = SystemColors.Control;
		((Control)_Label4_9).Cursor = Cursors.Default;
		((Control)_Label4_9).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_9).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_9, (short)9);
		Label label4_17 = _Label4_9;
		location = new Point(477, 127);
		((Control)label4_17).Location = location;
		((Control)_Label4_9).Name = "_Label4_9";
		((Control)_Label4_9).RightToLeft = (RightToLeft)0;
		Label label4_18 = _Label4_9;
		size = new Size(49, 17);
		((Control)label4_18).Size = size;
		((Control)_Label4_9).TabIndex = 30;
		_Label4_9.Text = "chemical";
		((Control)_Label4_8).BackColor = SystemColors.Control;
		((Control)_Label4_8).Cursor = Cursors.Default;
		((Control)_Label4_8).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_8).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_8, (short)8);
		Label label4_19 = _Label4_8;
		location = new Point(421, 127);
		((Control)label4_19).Location = location;
		((Control)_Label4_8).Name = "_Label4_8";
		((Control)_Label4_8).RightToLeft = (RightToLeft)0;
		Label label4_20 = _Label4_8;
		size = new Size(49, 17);
		((Control)label4_20).Size = size;
		((Control)_Label4_8).TabIndex = 29;
		_Label4_8.Text = "chemical";
		((Control)_Label4_7).BackColor = SystemColors.Control;
		((Control)_Label4_7).Cursor = Cursors.Default;
		((Control)_Label4_7).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_7).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_7, (short)7);
		Label label4_21 = _Label4_7;
		location = new Point(365, 127);
		((Control)label4_21).Location = location;
		((Control)_Label4_7).Name = "_Label4_7";
		((Control)_Label4_7).RightToLeft = (RightToLeft)0;
		Label label4_22 = _Label4_7;
		size = new Size(49, 17);
		((Control)label4_22).Size = size;
		((Control)_Label4_7).TabIndex = 28;
		_Label4_7.Text = "chemical";
		((Control)_Label4_6).BackColor = SystemColors.Control;
		((Control)_Label4_6).Cursor = Cursors.Default;
		((Control)_Label4_6).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_6).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_6, (short)6);
		Label label4_23 = _Label4_6;
		location = new Point(309, 127);
		((Control)label4_23).Location = location;
		((Control)_Label4_6).Name = "_Label4_6";
		((Control)_Label4_6).RightToLeft = (RightToLeft)0;
		Label label4_24 = _Label4_6;
		size = new Size(49, 17);
		((Control)label4_24).Size = size;
		((Control)_Label4_6).TabIndex = 27;
		_Label4_6.Text = "chemical";
		((Control)_Label4_4).BackColor = SystemColors.Control;
		((Control)_Label4_4).Cursor = Cursors.Default;
		((Control)_Label4_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_4).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_4, (short)4);
		Label label4_25 = _Label4_4;
		location = new Point(253, 127);
		((Control)label4_25).Location = location;
		((Control)_Label4_4).Name = "_Label4_4";
		((Control)_Label4_4).RightToLeft = (RightToLeft)0;
		Label label4_26 = _Label4_4;
		size = new Size(49, 17);
		((Control)label4_26).Size = size;
		((Control)_Label4_4).TabIndex = 26;
		_Label4_4.Text = "chemical";
		((Control)_Line1_6).BackColor = SystemColors.WindowText;
		Line1.SetIndex(_Line1_6, (short)6);
		Label line1_17 = _Line1_6;
		location = new Point(245, 119);
		((Control)line1_17).Location = location;
		((Control)_Line1_6).Name = "_Line1_6";
		Label line1_18 = _Line1_6;
		size = new Size(1, 88);
		((Control)line1_18).Size = size;
		((Control)_Line1_6).TabIndex = 50;
		((Control)_Label4_1).BackColor = SystemColors.Control;
		((Control)_Label4_1).Cursor = Cursors.Default;
		((Control)_Label4_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_1).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_1, (short)1);
		Label label4_27 = _Label4_1;
		location = new Point(153, 142);
		((Control)label4_27).Location = location;
		((Control)_Label4_1).Name = "_Label4_1";
		((Control)_Label4_1).RightToLeft = (RightToLeft)0;
		Label label4_28 = _Label4_1;
		size = new Size(93, 17);
		((Control)label4_28).Size = size;
		((Control)_Label4_1).TabIndex = 25;
		_Label4_1.Text = "chemical";
		_Label4_1.TextAlign = (ContentAlignment)32;
		((Control)_Line1_5).BackColor = SystemColors.WindowText;
		Line1.SetIndex(_Line1_5, (short)5);
		Label line1_19 = _Line1_5;
		location = new Point(150, 120);
		((Control)line1_19).Location = location;
		((Control)_Line1_5).Name = "_Line1_5";
		Label line1_20 = _Line1_5;
		size = new Size(1, 88);
		((Control)line1_20).Size = size;
		((Control)_Line1_5).TabIndex = 51;
		((Control)_Label4_5).BackColor = SystemColors.Control;
		((Control)_Label4_5).Cursor = Cursors.Default;
		((Control)_Label4_5).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_5).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_5, (short)5);
		Label label4_29 = _Label4_5;
		location = new Point(55, 164);
		((Control)label4_29).Location = location;
		((Control)_Label4_5).Name = "_Label4_5";
		((Control)_Label4_5).RightToLeft = (RightToLeft)0;
		Label label4_30 = _Label4_5;
		size = new Size(89, 17);
		((Control)label4_30).Size = size;
		((Control)_Label4_5).TabIndex = 24;
		_Label4_5.Text = "Molecular Weight";
		((Control)_Line1_2).BackColor = SystemColors.WindowText;
		Line1.SetIndex(_Line1_2, (short)2);
		Label line1_21 = _Line1_2;
		location = new Point(48, 118);
		((Control)line1_21).Location = location;
		((Control)_Line1_2).Name = "_Line1_2";
		Label line1_22 = _Line1_2;
		size = new Size(1, 88);
		((Control)line1_22).Size = size;
		((Control)_Line1_2).TabIndex = 52;
		((Control)_Line1_0).BackColor = SystemColors.WindowText;
		Line1.SetIndex(_Line1_0, (short)0);
		Label line1_23 = _Line1_0;
		location = new Point(49, 119);
		((Control)line1_23).Location = location;
		((Control)_Line1_0).Name = "_Line1_0";
		Label line1_24 = _Line1_0;
		size = new Size(476, 1);
		((Control)line1_24).Size = size;
		((Control)_Line1_0).TabIndex = 53;
		((Control)_Label4_3).BackColor = SystemColors.Control;
		((Control)_Label4_3).Cursor = Cursors.Default;
		((Control)_Label4_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_3).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_3, (short)3);
		Label label4_31 = _Label4_3;
		location = new Point(153, 127);
		((Control)label4_31).Location = location;
		((Control)_Label4_3).Name = "_Label4_3";
		((Control)_Label4_3).RightToLeft = (RightToLeft)0;
		Label label4_32 = _Label4_3;
		size = new Size(93, 17);
		((Control)label4_32).Size = size;
		((Control)_Label4_3).TabIndex = 21;
		_Label4_3.Text = "assessed";
		_Label4_3.TextAlign = (ContentAlignment)32;
		((Control)_Label4_0).BackColor = SystemColors.Control;
		((Control)_Label4_0).Cursor = Cursors.Default;
		((Control)_Label4_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_0).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_0, (short)0);
		Label label4_33 = _Label4_0;
		location = new Point(55, 189);
		((Control)label4_33).Location = location;
		((Control)_Label4_0).Name = "_Label4_0";
		((Control)_Label4_0).RightToLeft = (RightToLeft)0;
		Label label4_34 = _Label4_0;
		size = new Size(81, 17);
		((Control)label4_34).Size = size;
		((Control)_Label4_0).TabIndex = 20;
		_Label4_0.Text = "Weight Fraction";
		((Control)_fraWhatAmIDoing_0).BackColor = SystemColors.Control;
		((Control)_fraWhatAmIDoing_0).Controls.Add((Control)(object)_fraAuto_1);
		((Control)_fraWhatAmIDoing_0).Controls.Add((Control)(object)_fraAuto_0);
		((Control)_fraWhatAmIDoing_0).Controls.Add((Control)(object)_fraAuto_2);
		((Control)_fraWhatAmIDoing_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_fraWhatAmIDoing_0).ForeColor = SystemColors.ControlText;
		fraWhatAmIDoing.SetIndex(_fraWhatAmIDoing_0, (short)0);
		GroupBox fraWhatAmIDoing_5 = _fraWhatAmIDoing_0;
		location = new Point(16, 48);
		((Control)fraWhatAmIDoing_5).Location = location;
		((Control)_fraWhatAmIDoing_0).Name = "_fraWhatAmIDoing_0";
		((Control)_fraWhatAmIDoing_0).RightToLeft = (RightToLeft)0;
		GroupBox fraWhatAmIDoing_6 = _fraWhatAmIDoing_0;
		size = new Size(591, 289);
		((Control)fraWhatAmIDoing_6).Size = size;
		((Control)_fraWhatAmIDoing_0).TabIndex = 22;
		_fraWhatAmIDoing_0.TabStop = false;
		((Control)_fraWhatAmIDoing_0).Visible = false;
		((Control)_fraAuto_1).BackColor = SystemColors.Control;
		((Control)_fraAuto_1).Controls.Add((Control)(object)_optOverSprayCntlType_0);
		((Control)_fraAuto_1).Controls.Add((Control)(object)_optOverSprayCntlType_1);
		((Control)_fraAuto_1).Controls.Add((Control)(object)_Label4_15);
		((Control)_fraAuto_1).Cursor = Cursors.Default;
		((Control)_fraAuto_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_fraAuto_1).ForeColor = SystemColors.ControlText;
		fraAuto.SetIndex(_fraAuto_1, (short)1);
		Panel fraAuto_7 = _fraAuto_1;
		location = new Point(440, 96);
		((Control)fraAuto_7).Location = location;
		((Control)_fraAuto_1).Name = "_fraAuto_1";
		((Control)_fraAuto_1).RightToLeft = (RightToLeft)0;
		Panel fraAuto_8 = _fraAuto_1;
		size = new Size(409, 73);
		((Control)fraAuto_8).Size = size;
		((Control)_fraAuto_1).TabIndex = 47;
		((Control)_fraAuto_1).Visible = false;
		((ButtonBase)_optOverSprayCntlType_0).BackColor = SystemColors.Control;
		((Control)_optOverSprayCntlType_0).Cursor = Cursors.Default;
		((Control)_optOverSprayCntlType_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optOverSprayCntlType_0).ForeColor = SystemColors.ControlText;
		optOverSprayCntlType.SetIndex(_optOverSprayCntlType_0, (short)0);
		RadioButton optOverSprayCntlType_5 = _optOverSprayCntlType_0;
		location = new Point(176, 16);
		((Control)optOverSprayCntlType_5).Location = location;
		((Control)_optOverSprayCntlType_0).Name = "_optOverSprayCntlType_0";
		((Control)_optOverSprayCntlType_0).RightToLeft = (RightToLeft)0;
		RadioButton optOverSprayCntlType_6 = _optOverSprayCntlType_0;
		size = new Size(177, 17);
		((Control)optOverSprayCntlType_6).Size = size;
		((Control)_optOverSprayCntlType_0).TabIndex = 50;
		_optOverSprayCntlType_0.TabStop = true;
		((ButtonBase)_optOverSprayCntlType_0).Text = "Waterwash";
		((ButtonBase)_optOverSprayCntlType_0).UseVisualStyleBackColor = false;
		((ButtonBase)_optOverSprayCntlType_1).BackColor = SystemColors.Control;
		((Control)_optOverSprayCntlType_1).Cursor = Cursors.Default;
		((Control)_optOverSprayCntlType_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optOverSprayCntlType_1).ForeColor = SystemColors.ControlText;
		optOverSprayCntlType.SetIndex(_optOverSprayCntlType_1, (short)1);
		RadioButton optOverSprayCntlType_7 = _optOverSprayCntlType_1;
		location = new Point(176, 40);
		((Control)optOverSprayCntlType_7).Location = location;
		((Control)_optOverSprayCntlType_1).Name = "_optOverSprayCntlType_1";
		((Control)_optOverSprayCntlType_1).RightToLeft = (RightToLeft)0;
		RadioButton optOverSprayCntlType_8 = _optOverSprayCntlType_1;
		size = new Size(177, 17);
		((Control)optOverSprayCntlType_8).Size = size;
		((Control)_optOverSprayCntlType_1).TabIndex = 48;
		_optOverSprayCntlType_1.TabStop = true;
		((ButtonBase)_optOverSprayCntlType_1).Text = "Dry Filter";
		((ButtonBase)_optOverSprayCntlType_1).UseVisualStyleBackColor = false;
		((Control)_Label4_15).BackColor = SystemColors.Control;
		((Control)_Label4_15).Cursor = Cursors.Default;
		((Control)_Label4_15).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_15).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_15, (short)15);
		Label label4_35 = _Label4_15;
		location = new Point(8, 16);
		((Control)label4_35).Location = location;
		((Control)_Label4_15).Name = "_Label4_15";
		((Control)_Label4_15).RightToLeft = (RightToLeft)0;
		Label label4_36 = _Label4_15;
		size = new Size(153, 17);
		((Control)label4_36).Size = size;
		((Control)_Label4_15).TabIndex = 49;
		_Label4_15.Text = "Overspray Control Type:";
		_Label4_15.TextAlign = (ContentAlignment)4;
		((Control)_fraAuto_0).BackColor = SystemColors.Control;
		((Control)_fraAuto_0).Controls.Add((Control)(object)_optSprayGunType_0);
		((Control)_fraAuto_0).Controls.Add((Control)(object)_optSprayGunType_1);
		((Control)_fraAuto_0).Controls.Add((Control)(object)_Label4_2);
		((Control)_fraAuto_0).Cursor = Cursors.Default;
		((Control)_fraAuto_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_fraAuto_0).ForeColor = SystemColors.ControlText;
		fraAuto.SetIndex(_fraAuto_0, (short)0);
		Panel fraAuto_9 = _fraAuto_0;
		location = new Point(24, 88);
		((Control)fraAuto_9).Location = location;
		((Control)_fraAuto_0).Name = "_fraAuto_0";
		((Control)_fraAuto_0).RightToLeft = (RightToLeft)0;
		Panel fraAuto_10 = _fraAuto_0;
		size = new Size(409, 73);
		((Control)fraAuto_10).Size = size;
		((Control)_fraAuto_0).TabIndex = 46;
		((ButtonBase)_optSprayGunType_0).BackColor = SystemColors.Control;
		((Control)_optSprayGunType_0).Cursor = Cursors.Default;
		((Control)_optSprayGunType_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optSprayGunType_0).ForeColor = SystemColors.ControlText;
		optSprayGunType.SetIndex(_optSprayGunType_0, (short)0);
		RadioButton optSprayGunType_ = _optSprayGunType_0;
		location = new Point(176, 16);
		((Control)optSprayGunType_).Location = location;
		((Control)_optSprayGunType_0).Name = "_optSprayGunType_0";
		((Control)_optSprayGunType_0).RightToLeft = (RightToLeft)0;
		RadioButton optSprayGunType_2 = _optSprayGunType_0;
		size = new Size(81, 17);
		((Control)optSprayGunType_2).Size = size;
		((Control)_optSprayGunType_0).TabIndex = 52;
		_optSprayGunType_0.TabStop = true;
		((ButtonBase)_optSprayGunType_0).Text = "HVLP";
		((ButtonBase)_optSprayGunType_0).UseVisualStyleBackColor = false;
		((ButtonBase)_optSprayGunType_1).BackColor = SystemColors.Control;
		((Control)_optSprayGunType_1).Cursor = Cursors.Default;
		((Control)_optSprayGunType_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optSprayGunType_1).ForeColor = SystemColors.ControlText;
		optSprayGunType.SetIndex(_optSprayGunType_1, (short)1);
		RadioButton optSprayGunType_3 = _optSprayGunType_1;
		location = new Point(176, 40);
		((Control)optSprayGunType_3).Location = location;
		((Control)_optSprayGunType_1).Name = "_optSprayGunType_1";
		((Control)_optSprayGunType_1).RightToLeft = (RightToLeft)0;
		RadioButton optSprayGunType_4 = _optSprayGunType_1;
		size = new Size(105, 13);
		((Control)optSprayGunType_4).Size = size;
		((Control)_optSprayGunType_1).TabIndex = 51;
		_optSprayGunType_1.TabStop = true;
		((ButtonBase)_optSprayGunType_1).Text = "Conventional";
		((ButtonBase)_optSprayGunType_1).UseVisualStyleBackColor = false;
		((Control)_Label4_2).BackColor = SystemColors.Control;
		((Control)_Label4_2).Cursor = Cursors.Default;
		((Control)_Label4_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_2).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_2, (short)2);
		Label label4_37 = _Label4_2;
		location = new Point(8, 16);
		((Control)label4_37).Location = location;
		((Control)_Label4_2).Name = "_Label4_2";
		((Control)_Label4_2).RightToLeft = (RightToLeft)0;
		Label label4_38 = _Label4_2;
		size = new Size(153, 17);
		((Control)label4_38).Size = size;
		((Control)_Label4_2).TabIndex = 53;
		_Label4_2.Text = "Spray Gun Type:";
		_Label4_2.TextAlign = (ContentAlignment)4;
		((Control)_fraAuto_2).BackColor = SystemColors.Control;
		((Control)_fraAuto_2).Controls.Add((Control)(object)_optBoothVentType_0);
		((Control)_fraAuto_2).Controls.Add((Control)(object)_optBoothVentType_1);
		((Control)_fraAuto_2).Controls.Add((Control)(object)_Label4_16);
		((Control)_fraAuto_2).Cursor = Cursors.Default;
		((Control)_fraAuto_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_fraAuto_2).ForeColor = SystemColors.ControlText;
		fraAuto.SetIndex(_fraAuto_2, (short)2);
		Panel fraAuto_11 = _fraAuto_2;
		location = new Point(440, 168);
		((Control)fraAuto_11).Location = location;
		((Control)_fraAuto_2).Name = "_fraAuto_2";
		((Control)_fraAuto_2).RightToLeft = (RightToLeft)0;
		Panel fraAuto_12 = _fraAuto_2;
		size = new Size(409, 73);
		((Control)fraAuto_12).Size = size;
		((Control)_fraAuto_2).TabIndex = 42;
		((Control)_fraAuto_2).Visible = false;
		((ButtonBase)_optBoothVentType_0).BackColor = SystemColors.Control;
		((Control)_optBoothVentType_0).Cursor = Cursors.Default;
		((Control)_optBoothVentType_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optBoothVentType_0).ForeColor = SystemColors.ControlText;
		optBoothVentType.SetIndex(_optBoothVentType_0, (short)0);
		RadioButton optBoothVentType_5 = _optBoothVentType_0;
		location = new Point(176, 24);
		((Control)optBoothVentType_5).Location = location;
		((Control)_optBoothVentType_0).Name = "_optBoothVentType_0";
		((Control)_optBoothVentType_0).RightToLeft = (RightToLeft)0;
		RadioButton optBoothVentType_6 = _optBoothVentType_0;
		size = new Size(177, 17);
		((Control)optBoothVentType_6).Size = size;
		((Control)_optBoothVentType_0).TabIndex = 44;
		_optBoothVentType_0.TabStop = true;
		((ButtonBase)_optBoothVentType_0).Text = "Downdraft";
		((ButtonBase)_optBoothVentType_0).UseVisualStyleBackColor = false;
		((ButtonBase)_optBoothVentType_1).BackColor = SystemColors.Control;
		((Control)_optBoothVentType_1).Cursor = Cursors.Default;
		((Control)_optBoothVentType_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optBoothVentType_1).ForeColor = SystemColors.ControlText;
		optBoothVentType.SetIndex(_optBoothVentType_1, (short)1);
		RadioButton optBoothVentType_7 = _optBoothVentType_1;
		location = new Point(176, 48);
		((Control)optBoothVentType_7).Location = location;
		((Control)_optBoothVentType_1).Name = "_optBoothVentType_1";
		((Control)_optBoothVentType_1).RightToLeft = (RightToLeft)0;
		RadioButton optBoothVentType_8 = _optBoothVentType_1;
		size = new Size(177, 17);
		((Control)optBoothVentType_8).Size = size;
		((Control)_optBoothVentType_1).TabIndex = 43;
		_optBoothVentType_1.TabStop = true;
		((ButtonBase)_optBoothVentType_1).Text = "Crossdraft";
		((ButtonBase)_optBoothVentType_1).UseVisualStyleBackColor = false;
		((Control)_Label4_16).BackColor = SystemColors.Control;
		((Control)_Label4_16).Cursor = Cursors.Default;
		((Control)_Label4_16).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_16).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_16, (short)16);
		Label label4_39 = _Label4_16;
		location = new Point(16, 24);
		((Control)label4_39).Location = location;
		((Control)_Label4_16).Name = "_Label4_16";
		((Control)_Label4_16).RightToLeft = (RightToLeft)0;
		Label label4_40 = _Label4_16;
		size = new Size(153, 17);
		((Control)label4_40).Size = size;
		((Control)_Label4_16).TabIndex = 45;
		_Label4_16.Text = "Booth Vent Type:";
		_Label4_16.TextAlign = (ContentAlignment)4;
		((Control)lblInstructions).BackColor = SystemColors.Control;
		((Control)lblInstructions).Cursor = Cursors.Default;
		((Control)lblInstructions).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblInstructions).ForeColor = SystemColors.ControlText;
		Label obj13 = lblInstructions;
		location = new Point(16, 16);
		((Control)obj13).Location = location;
		((Control)lblInstructions).Name = "lblInstructions";
		((Control)lblInstructions).RightToLeft = (RightToLeft)0;
		Label obj14 = lblInstructions;
		size = new Size(393, 33);
		((Control)obj14).Size = size;
		((Control)lblInstructions).TabIndex = 23;
		lblInstructions.Text = "lblInstruction";
		((Form)this).AcceptButton = (IButtonControl)(object)cmdOK;
		size = new Size(5, 13);
		((Form)this).AutoScaleBaseSize = size;
		((Form)this).BackColor = SystemColors.Control;
		size = new Size(616, 419);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)cmdOK);
		((Control)this).Controls.Add((Control)(object)lblInstructions);
		((Control)this).Controls.Add((Control)(object)_fraWhatAmIDoing_1);
		((Control)this).Controls.Add((Control)(object)_fraWhatAmIDoing_0);
		((Control)this).Controls.Add((Control)(object)_fraWhatAmIDoing_2);
		((Control)this).Cursor = Cursors.Default;
		((Control)this).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		location = new Point(250, 150);
		((Form)this).Location = location;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmUpdSP";
		((Control)this).RightToLeft = (RightToLeft)0;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Update Shared Parameter";
		((Control)_fraWhatAmIDoing_2).ResumeLayout(false);
		((Control)_fraAuto_3).ResumeLayout(false);
		((Control)_fraAuto_5).ResumeLayout(false);
		((Control)_fraWhatAmIDoing_1).ResumeLayout(false);
		((Control)_fraWhatAmIDoing_1).PerformLayout();
		((Control)_fraWhatAmIDoing_0).ResumeLayout(false);
		((Control)_fraAuto_1).ResumeLayout(false);
		((Control)_fraAuto_0).ResumeLayout(false);
		((Control)_fraAuto_2).ResumeLayout(false);
		((ISupportInitialize)Label4).EndInit();
		((ISupportInitialize)Line1).EndInit();
		((ISupportInitialize)fraAuto).EndInit();
		((ISupportInitialize)fraWhatAmIDoing).EndInit();
		((ISupportInitialize)lblX).EndInit();
		((ISupportInitialize)optBoothVentType).EndInit();
		((ISupportInitialize)optElecAddType).EndInit();
		((ISupportInitialize)optOverSprayCntlType).EndInit();
		((ISupportInitialize)optSprayGunType).EndInit();
		((ISupportInitialize)optX).EndInit();
		((ISupportInitialize)txtXmwa).EndInit();
		((ISupportInitialize)txtXya).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public bool SetUp(ref short pWhatAmIDoing, ref short pID)
	{
		WhatAmIDoing = pWhatAmIDoing;
		iWhoAmI = pID;
		checked
		{
			((Control)fraWhatAmIDoing[(short)(WhatAmIDoing - 1)]).Visible = true;
			switch (WhatAmIDoing)
			{
			case 1:
			{
				sWhoAmI = "Auto Stuff";
				lblInstructions.Text = "Update the Automotive Spray Coating Model Factors below";
				float num2 = Globals_Renamed.arOpSP[1, Globals_Renamed.intOpIndex];
				if (num2 == 1f)
				{
					optSprayGunType[(short)0].Checked = true;
				}
				else if (num2 == 2f)
				{
					optSprayGunType[(short)1].Checked = true;
				}
				float num3 = Globals_Renamed.arOpSP[2, Globals_Renamed.intOpIndex];
				if (num3 == 1f)
				{
					optOverSprayCntlType[(short)0].Checked = true;
				}
				else if (num3 == 2f)
				{
					optOverSprayCntlType[(short)1].Checked = true;
				}
				float num4 = Globals_Renamed.arOpSP[3, Globals_Renamed.intOpIndex];
				if (num4 == 1f)
				{
					optBoothVentType[(short)0].Checked = true;
				}
				else if (num4 == 2f)
				{
					optBoothVentType[(short)1].Checked = true;
				}
				break;
			}
			case 2:
			{
				sWhoAmI = ChemStrX.GetParmAcronym(ref iWhoAmI);
				lblInstructions.Text = "Update the Vapor Pressure Correction Factor below";
				((Form)this).Text = "Update Vapor Pressure Correction Factor";
				if (Operators.CompareString(sWhoAmI, "Xrm", false) == 0)
				{
					Label obj = lblX[(short)0];
					string text = sWhoAmI;
					ref bool pFirstOp = ref Globals_Renamed.arNoPre[Globals_Renamed.intOpIndex];
					short pOpNumber = (short)(Globals_Renamed.intOpIndex + 1);
					object arOpParms = Globals_Renamed.arOpParms;
					object pArSubOpID = Globals_Renamed.arSubOpID;
					float xrmDefault = ChemStrX.GetXrmDefault(ref Globals_Renamed.intNumOps, ref pFirstOp, ref pOpNumber, ref arOpParms, ref pArSubOpID);
					Globals_Renamed.arSubOpID = (short[,])pArSubOpID;
					Globals_Renamed.arOpParms = (float[,])arOpParms;
					obj.Text = text + "=" + Conversions.ToString(xrmDefault);
				}
				else
				{
					lblX[(short)0].Text = sWhoAmI + "=" + Conversions.ToString(Globals_Renamed.arOpParms[118, Globals_Renamed.intOpIndex]);
				}
				lblX[(short)1].Text = sWhoAmI + "=1";
				switch (iWhoAmI)
				{
				case 118:
					lblX[(short)2].Text = sWhoAmI + "=" + Conversions.ToString(Globals_Renamed.arOpParms[11, Globals_Renamed.intOpIndex]);
					lblY.Text = Conversions.ToString(Globals_Renamed.arOpParms[11, Globals_Renamed.intOpIndex]);
					iStartOfMyWork = 7;
					iWhereMyOption = 4;
					break;
				case 119:
					lblX[(short)2].Text = sWhoAmI + "=" + Conversions.ToString(Globals_Renamed.arOpParms[10, Globals_Renamed.intOpIndex]);
					lblY.Text = Conversions.ToString(Globals_Renamed.arOpParms[10, Globals_Renamed.intOpIndex]);
					iStartOfMyWork = 19;
					iWhereMyOption = 5;
					break;
				case 120:
					lblX[(short)2].Text = sWhoAmI + "=" + Conversions.ToString(Globals_Renamed.arOpParms[11, Globals_Renamed.intOpIndex]);
					lblY.Text = Conversions.ToString(Globals_Renamed.arOpParms[11, Globals_Renamed.intOpIndex]);
					iStartOfMyWork = 31;
					iWhereMyOption = 6;
					break;
				}
				lblMW.Text = frmMain.DefInstance.lblMW.Text;
				if (Globals_Renamed.arOpSP[iWhereMyOption, Globals_Renamed.intOpIndex] < (float)((BaseControlArray)optX).Count())
				{
					optX[(short)Math.Round(Globals_Renamed.arOpSP[iWhereMyOption, Globals_Renamed.intOpIndex])].Checked = true;
				}
				else
				{
					optX[(short)0].Checked = true;
				}
				short num5 = 0;
				short num6;
				short num7;
				do
				{
					txtXya[num5].Text = Conversions.ToString(Globals_Renamed.arOpSP[(short)unchecked(num5 + iStartOfMyWork), Globals_Renamed.intOpIndex]);
					txtXmwa[num5].Text = Conversions.ToString(Globals_Renamed.arOpSP[(short)unchecked(num5 + iStartOfMyWork) + 5, Globals_Renamed.intOpIndex]);
					num5 = (short)unchecked(num5 + 1);
					num6 = num5;
					num7 = 4;
				}
				while (num6 <= num7);
				lblX[(short)3].Text = sWhoAmI + "=" + Conversions.ToString(Globals_Renamed.arOpSP[iStartOfMyWork + 10, Globals_Renamed.intOpIndex]);
				txtXuserdef.Text = Conversions.ToString(Globals_Renamed.arOpSP[iStartOfMyWork + 11, Globals_Renamed.intOpIndex]);
				break;
			}
			case 3:
			{
				sWhoAmI = "Electroplating Additive";
				lblInstructions.Text = "Update the Electroplating Additive Type below";
				float num = Globals_Renamed.arOpSP[47, Globals_Renamed.intOpIndex];
				if (num == 1f)
				{
					optElecAddType[(short)0].Checked = true;
				}
				else if (num == 2f)
				{
					optElecAddType[(short)1].Checked = true;
				}
				break;
			}
			}
			return true;
		}
	}

	private void cmdCalcX_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
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
					if (!Versioned.IsNumeric((object)lblMW.Text))
					{
						Interaction.Beep();
						Interaction.MsgBox((object)"Please specify a Molecular Weight for the chemical", (MsgBoxStyle)64, (object)"Missing Information");
						goto end_IL_0001;
					}
					if (Conversions.ToSingle(lblMW.Text) == 0f)
					{
						Interaction.Beep();
						Interaction.MsgBox((object)"Please specify a Molecular Weight for the chemical", (MsgBoxStyle)64, (object)"Missing Information");
						goto end_IL_0001;
					}
					if (!Versioned.IsNumeric((object)lblY.Text))
					{
						Interaction.Beep();
						Interaction.MsgBox((object)"Please specify a Weight Fraction for the chemical", (MsgBoxStyle)64, (object)"Missing Information");
						goto end_IL_0001;
					}
					if (Conversions.ToSingle(lblY.Text) < 0f)
					{
						Interaction.Beep();
						Interaction.MsgBox((object)"Please specify a Weight Fraction for the chemical", (MsgBoxStyle)64, (object)"Missing Information");
						goto end_IL_0001;
					}
					float[] array = new float[5];
					float[] array2 = new float[5];
					short num3 = 0;
					short num4;
					short num5;
					do
					{
						array[num3] = Conversions.ToSingle(Common.MyNullCheck0(((Control)_fraWhatAmIDoing_1).Controls["_txtXya_" + Conversions.ToString((int)num3)].Text));
						array2[num3] = Conversions.ToSingle(Common.MyNullCheck0(((Control)_fraWhatAmIDoing_1).Controls["_txtXmwa_" + Conversions.ToString((int)num3)].Text));
						checked
						{
							num3 = (short)unchecked(num3 + 1);
							num4 = num3;
							num5 = 4;
						}
					}
					while (num4 <= num5);
					float Y = Conversions.ToSingle(lblY.Text);
					float mw = Conversions.ToSingle(lblMW.Text);
					object arYa = array;
					object arMWa = array2;
					float num6 = ChemStrX.CalcRaoultsFormula(ref Y, ref mw, ref arYa, ref arMWa);
					array2 = (float[])arMWa;
					array = (float[])arYa;
					float num7 = num6;
					ref short pID = ref iWhoAmI;
					arMWa = num7;
					short pModType = 0;
					bool num8 = ChemStrX.ValidateParmInput(ref pID, ref arMWa, ref pModType);
					num7 = Conversions.ToSingle(arMWa);
					if (num8)
					{
						lblX[(short)3].Text = sWhoAmI + "=" + Conversions.ToString(num7);
					}
					goto end_IL_0001;
				}
				case 635:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						string Eobject = ((Control)this).Name;
						string Efunction = "cmdCalcX_Click";
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
				try0001_dispatch = 635;
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
		((Control)this).Tag = -1;
		((Control)this).Hide();
	}

	private void frmUpdSP_Load(object eventSender, EventArgs eventArgs)
	{
	}

	private void cmdOk_Click(object eventSender, EventArgs eventArgs)
	{
		if (UpdateFrmMain())
		{
			((Control)this).Hide();
		}
	}

	private void optBoothVentType_CheckedChanged(object eventSender, EventArgs eventArgs)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		if (Conversions.ToBoolean(NewLateBinding.LateGet(eventSender, (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			short index = optBoothVentType.GetIndex((RadioButton)eventSender);
			iBVType = checked((short)(index + 1));
		}
	}

	private void optElecAddType_CheckedChanged(object eventSender, EventArgs eventArgs)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		if (Conversions.ToBoolean(NewLateBinding.LateGet(eventSender, (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			short index = optElecAddType.GetIndex((RadioButton)eventSender);
			iEAType = checked((short)(index + 1));
		}
	}

	private void optOverSprayCntlType_CheckedChanged(object eventSender, EventArgs eventArgs)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		if (Conversions.ToBoolean(NewLateBinding.LateGet(eventSender, (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			short index = optOverSprayCntlType.GetIndex((RadioButton)eventSender);
			iOSType = checked((short)(index + 1));
		}
	}

	private void optSprayGunType_CheckedChanged(object eventSender, EventArgs eventArgs)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		if (Conversions.ToBoolean(NewLateBinding.LateGet(eventSender, (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			short index = optSprayGunType.GetIndex((RadioButton)eventSender);
			iSGType = checked((short)(index + 1));
		}
	}

	private void optX_CheckedChanged(object eventSender, EventArgs eventArgs)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		if (!Conversions.ToBoolean(NewLateBinding.LateGet(eventSender, (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			return;
		}
		short index = optX.GetIndex((RadioButton)eventSender);
		iXOption = index;
		switch (iXOption)
		{
		case 0:
		case 1:
		case 2:
			((Control)cmdCalcX).Enabled = false;
			((Control)txtXuserdef).Enabled = false;
			((TextBoxBase)txtXuserdef).BackColor = ((Form)this).BackColor;
			break;
		case 3:
			if ((Versioned.IsNumeric((object)lblMW.Text) & Versioned.IsNumeric((object)lblY.Text)) && ((Conversions.ToDouble(lblMW.Text) > 0.0) & (Conversions.ToDouble(lblY.Text) >= 0.0)))
			{
				((Control)cmdCalcX).Enabled = true;
				((Control)txtXuserdef).Enabled = false;
				((TextBoxBase)txtXuserdef).BackColor = ((Form)this).BackColor;
			}
			else
			{
				Interaction.Beep();
				Interaction.MsgBox((object)"You cannot select this option, you need to specify a non-zero Molecular Weight and Weight Fraction first.", (MsgBoxStyle)64, (object)null);
				optX[(short)0].Checked = true;
			}
			break;
		case 4:
			((Control)cmdCalcX).Enabled = false;
			((Control)txtXuserdef).Enabled = true;
			((TextBoxBase)txtXuserdef).BackColor = Color.White;
			break;
		}
	}

	private float GetXDefault()
	{
		checked
		{
			short num = (short)Strings.InStr(lblX[iXOption].Text, "=", (CompareMethod)0);
			if (num == 0)
			{
				return 0f;
			}
			if (Versioned.IsNumeric((object)Strings.Mid(lblX[iXOption].Text, num + 1)))
			{
				return Conversions.ToSingle(Strings.Mid(lblX[iXOption].Text, num + 1));
			}
			return 0f;
		}
	}

	private void txtXmwa_Leave(object eventSender, EventArgs eventArgs)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		short index = txtXmwa.GetIndex((TextBox)eventSender);
		txtXmwa[index].Text = Strings.Trim(txtXmwa[index].Text);
		if (Strings.Len(txtXmwa[index].Text) > 0 && !Versioned.IsNumeric((object)txtXmwa[index].Text))
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Please enter a valid, numeric value, or blanks", (MsgBoxStyle)64, (object)"Invalid Entry");
		}
	}

	private void txtXuserdef_Leave(object eventSender, EventArgs eventArgs)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		txtXuserdef.Text = Strings.Trim(txtXuserdef.Text);
		if (Strings.Len(txtXuserdef.Text) <= 0)
		{
			return;
		}
		if (!Versioned.IsNumeric((object)txtXuserdef.Text))
		{
			Interaction.MsgBox((object)("Please enter a valid, numberic " + sWhoAmI), (MsgBoxStyle)64, (object)"Invalid Input");
		}
		else
		{
			ref short pID = ref iWhoAmI;
			TextBox val = txtXuserdef;
			object pValue = val.Text;
			short pModType = 0;
			bool num = ChemStrX.ValidateParmInput(ref pID, ref pValue, ref pModType);
			val.Text = Conversions.ToString(pValue);
			if (num)
			{
				return;
			}
		}
		((TextBoxBase)txtXuserdef).SelectionStart = 0;
		((TextBoxBase)txtXuserdef).SelectionLength = Strings.Len(txtXuserdef.Text);
		((Control)txtXuserdef).Focus();
	}

	private void txtXya_Leave(object eventSender, EventArgs eventArgs)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		short index = txtXya.GetIndex((TextBox)eventSender);
		txtXya[index].Text = Strings.Trim(txtXya[index].Text);
		if (Strings.Len(txtXya[index].Text) > 0 && !Versioned.IsNumeric((object)txtXya[index].Text))
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Please enter a valid, numeric value, or blanks", (MsgBoxStyle)64, (object)"Invalid Entry");
		}
	}

	private bool UpdateFrmMain()
	{
		//IL_051b: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
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
						float num3 = Globals_Renamed.arOpParms[iWhoAmI, Globals_Renamed.intOpIndex];
						short num4;
						short num10;
						switch (WhatAmIDoing)
						{
						case 1:
						{
							if (Globals_Renamed.arOpSP[1, Globals_Renamed.intOpIndex] != (float)iSGType)
							{
								Globals_Renamed.arOpSP[1, Globals_Renamed.intOpIndex] = iSGType;
								if (Globals_Renamed.arOpSPType[1, Globals_Renamed.intOpIndex] == 1)
								{
									Globals_Renamed.arOpSPType[1, Globals_Renamed.intOpIndex] = 2;
								}
								else
								{
									Globals_Renamed.arOpSPType[1, Globals_Renamed.intOpIndex] = 1;
								}
								flag = true;
							}
							if (!flag)
							{
								break;
							}
							num4 = 0;
							short num22;
							do
							{
								short num5 = 0;
								short num20;
								do
								{
									if (Globals_Renamed.arRelModels[num5, num4, Globals_Renamed.intOpIndex] > 0)
									{
										short num6 = (short)(Globals_Renamed.arRelModels[num5, num4, Globals_Renamed.intOpIndex] - 1);
										if ((Globals_Renamed.arRelModType[num6] == 48) | (Globals_Renamed.arRelModType[num6] == 41))
										{
											short pDualID = 0;
											short num19;
											do
											{
												if (Globals_Renamed.arRelModParmsT[pDualID, 43, num6] == 1)
												{
													float[,,] arRelModParmsV2 = Globals_Renamed.arRelModParmsV;
													short num15 = pDualID;
													short num16 = num6;
													short pID = 43;
													arRelModParmsV2[num15, 43, num16] = GetParmDefaults.GetParmDefault3107(ref pID, ref pDualID, ref Globals_Renamed.arRelModType[num6]);
													float[,,] arRelModParmsV3 = Globals_Renamed.arRelModParmsV;
													short num17 = pDualID;
													short num18 = num6;
													object ParRelModParmsV = Globals_Renamed.arRelModParmsV;
													float parmDefault = GetParmDefaults.GetParmDefault3105(ref num6, ref pDualID, ref ParRelModParmsV);
													Globals_Renamed.arRelModParmsV = (float[,,])ParRelModParmsV;
													arRelModParmsV3[num17, 74, num18] = parmDefault;
												}
												else
												{
													Globals_Renamed.arRelModParmsT[pDualID, 43, num6] = 1;
												}
												pDualID = (short)unchecked(pDualID + 1);
												num19 = pDualID;
												num10 = 1;
											}
											while (num19 <= num10);
										}
									}
									num5 = (short)unchecked(num5 + 1);
									num20 = num5;
									num10 = 9;
								}
								while (num20 <= num10);
								if (Globals_Renamed.arExpModels[1, num4, Globals_Renamed.intOpIndex] > 0)
								{
									short num6 = (short)(Globals_Renamed.arExpModels[1, num4, Globals_Renamed.intOpIndex] - 1);
									short pDualID = 0;
									short num21;
									do
									{
										if (Globals_Renamed.arExpModParmsT[pDualID, 57, num6] == 1)
										{
											Globals_Renamed.arExpModParmsV[pDualID, 57, num6] = GetParmDefaults.GetParmDefault2109(ref Globals_Renamed.arExpModType[num6], ref pDualID);
										}
										else
										{
											switch (Globals_Renamed.arExpModType[num6])
											{
											case 49:
												if (Globals_Renamed.arExpModParmsV[pDualID, 57, num6] == 1f)
												{
													Globals_Renamed.arExpModParmsT[pDualID, 57, num6] = 1;
												}
												break;
											case 40:
											case 50:
												if (Globals_Renamed.arExpModParmsV[pDualID, 57, num6] == 3f)
												{
													Globals_Renamed.arExpModParmsT[pDualID, 57, num6] = 1;
												}
												break;
											}
										}
										pDualID = (short)unchecked(pDualID + 1);
										num21 = pDualID;
										num10 = 1;
									}
									while (num21 <= num10);
								}
								num4 = (short)unchecked(num4 + 1);
								num22 = num4;
								num10 = 24;
							}
							while (num22 <= num10);
							break;
						}
						case 2:
							switch (iXOption)
							{
							case 0:
								if (Globals_Renamed.arOpParms[iWhoAmI, Globals_Renamed.intOpIndex] != GetXDefault())
								{
									Globals_Renamed.arOpParms[iWhoAmI, Globals_Renamed.intOpIndex] = GetXDefault();
								}
								Globals_Renamed.arOpParmsType[iWhoAmI, Globals_Renamed.intOpIndex] = 1;
								goto default;
							case 1:
							case 2:
								if (Globals_Renamed.arOpParms[iWhoAmI, Globals_Renamed.intOpIndex] != GetXDefault())
								{
									Globals_Renamed.arOpParms[iWhoAmI, Globals_Renamed.intOpIndex] = GetXDefault();
								}
								Globals_Renamed.arOpParmsType[iWhoAmI, Globals_Renamed.intOpIndex] = 2;
								goto default;
							case 3:
							{
								float xDefault = GetXDefault();
								Globals_Renamed.arOpParms[iWhoAmI, Globals_Renamed.intOpIndex] = xDefault;
								Globals_Renamed.arOpParmsType[iWhoAmI, Globals_Renamed.intOpIndex] = 2;
								goto default;
							}
							case 4:
								if (Versioned.IsNumeric((object)txtXuserdef.Text))
								{
									if (Conversions.ToSingle(txtXuserdef.Text) >= 0f)
									{
										Globals_Renamed.arOpParms[iWhoAmI, Globals_Renamed.intOpIndex] = Conversions.ToSingle(txtXuserdef.Text);
										Globals_Renamed.arOpParmsType[iWhoAmI, Globals_Renamed.intOpIndex] = 2;
										goto default;
									}
									Interaction.Beep();
									Interaction.MsgBox((object)"Please enter a valid User Specified Default value. This must be greater than or equal to zero.", (MsgBoxStyle)64, (object)"Missing Information");
									((TextBoxBase)txtXuserdef).SelectionStart = 0;
									((TextBoxBase)txtXuserdef).SelectionLength = Strings.Len(txtXuserdef.Text);
									((Control)txtXuserdef).Focus();
									goto end_IL_0001;
								}
								Interaction.Beep();
								Interaction.MsgBox((object)"Please enter a User Specified Default value", (MsgBoxStyle)64, (object)"Missing Information");
								((Control)txtXuserdef).Focus();
								goto end_IL_0001;
							default:
							{
								ref short pID2 = ref iWhoAmI;
								ref float pValue = ref Globals_Renamed.arOpParms[iWhoAmI, Globals_Renamed.intOpIndex];
								object ParRelModParmsV = (short)(-1000);
								ChemStrX.RollDownhillOp(ref pID2, ref pValue, ref ParRelModParmsV);
								if (Versioned.IsNumeric((object)frmMain.DefInstance.lblVP.Text))
								{
									switch (iWhoAmI)
									{
									case 118:
										Globals_Renamed.arOpParms[121, Globals_Renamed.intOpIndex] = Globals_Renamed.arOpParms[118, Globals_Renamed.intOpIndex] * Conversions.ToSingle(frmMain.DefInstance.lblVP.Text);
										break;
									case 119:
										Globals_Renamed.arOpParms[122, Globals_Renamed.intOpIndex] = Globals_Renamed.arOpParms[119, Globals_Renamed.intOpIndex] * Conversions.ToSingle(frmMain.DefInstance.lblVP.Text);
										break;
									}
									if (Globals_Renamed.arOpParms[iWhoAmI, Globals_Renamed.intOpIndex] != num3)
									{
										ChemStrX.CheckAVP();
									}
								}
								Globals_Renamed.arOpSP[iWhereMyOption, Globals_Renamed.intOpIndex] = iXOption;
								num4 = 0;
								short num23;
								do
								{
									Globals_Renamed.arOpSP[(short)unchecked(iStartOfMyWork + num4), Globals_Renamed.intOpIndex] = 0f;
									Globals_Renamed.arOpSP[(short)unchecked(iStartOfMyWork + num4) + 5, Globals_Renamed.intOpIndex] = 0f;
									if ((Versioned.IsNumeric((object)txtXmwa[num4].Text) & Versioned.IsNumeric((object)txtXya[num4].Text)) && ((Conversions.ToDouble(txtXmwa[num4].Text) > 0.0) & (Conversions.ToDouble(txtXya[num4].Text) > 0.0)))
									{
										Globals_Renamed.arOpSP[(short)unchecked(iStartOfMyWork + num4), Globals_Renamed.intOpIndex] = Conversions.ToSingle(txtXya[num4].Text);
										Globals_Renamed.arOpSP[(short)unchecked(iStartOfMyWork + num4) + 5, Globals_Renamed.intOpIndex] = Conversions.ToSingle(txtXmwa[num4].Text);
									}
									num4 = (short)unchecked(num4 + 1);
									num23 = num4;
									num10 = 4;
								}
								while (num23 <= num10);
								if (Versioned.IsNumeric((object)txtXuserdef.Text))
								{
									Globals_Renamed.arOpSP[iStartOfMyWork + 11, Globals_Renamed.intOpIndex] = Conversions.ToSingle(txtXuserdef.Text);
								}
								else
								{
									Globals_Renamed.arOpParms[iStartOfMyWork + 11, Globals_Renamed.intOpIndex] = 0f;
								}
								num4 = (short)Strings.InStr(lblX[(short)3].Text, "=", (CompareMethod)0);
								if (num4 > 0)
								{
									if (Versioned.IsNumeric((object)Strings.Mid(lblX[(short)3].Text, num4 + 1)))
									{
										Globals_Renamed.arOpSP[iStartOfMyWork + 10, Globals_Renamed.intOpIndex] = Conversions.ToSingle(Strings.Mid(lblX[(short)3].Text, num4 + 1));
									}
									else
									{
										num4 = 0;
									}
								}
								if (num4 == 0)
								{
									Globals_Renamed.arOpParms[iStartOfMyWork + 10, Globals_Renamed.intOpIndex] = 0f;
								}
								break;
							}
							}
							break;
						case 3:
						{
							if (Globals_Renamed.arOpSP[47, Globals_Renamed.intOpIndex] != (float)iEAType)
							{
								Globals_Renamed.arOpSP[47, Globals_Renamed.intOpIndex] = iEAType;
								if (Globals_Renamed.arOpSPType[47, Globals_Renamed.intOpIndex] == 1)
								{
									Globals_Renamed.arOpSPType[47, Globals_Renamed.intOpIndex] = 3;
								}
								else
								{
									Globals_Renamed.arOpSPType[47, Globals_Renamed.intOpIndex] = 1;
								}
								flag = true;
							}
							if (!flag)
							{
								break;
							}
							num4 = 0;
							short num14;
							do
							{
								short num5 = 0;
								short num13;
								do
								{
									if (Globals_Renamed.arRelModels[num5, num4, Globals_Renamed.intOpIndex] > 0)
									{
										short num6 = (short)(Globals_Renamed.arRelModels[num5, num4, Globals_Renamed.intOpIndex] - 1);
										short pDualID;
										if ((Globals_Renamed.arRelModType[num6] == 51) | (Globals_Renamed.arRelModType[num6] == 52))
										{
											pDualID = 0;
											short num9;
											do
											{
												if (Globals_Renamed.arRelModParmsT[pDualID, 142, num6] == 1)
												{
													float[,,] arRelModParmsV = Globals_Renamed.arRelModParmsV;
													short num7 = pDualID;
													short num8 = num6;
													short pID = 142;
													arRelModParmsV[num7, 142, num8] = GetParmDefaults.GetParmDefault3107(ref pID, ref pDualID, ref Globals_Renamed.arRelModType[num6]);
												}
												else
												{
													Globals_Renamed.arRelModParmsT[pDualID, 142, num6] = 1;
												}
												pDualID = (short)unchecked(pDualID + 1);
												num9 = pDualID;
												num10 = 1;
											}
											while (num9 <= num10);
										}
										pDualID = 0;
										short num11;
										do
										{
											Globals_Renamed.arRelModMedia[pDualID, num6] = 0f;
											pDualID = (short)unchecked(pDualID + 1);
											num11 = pDualID;
											num10 = 17;
										}
										while (num11 <= num10);
										pDualID = 0;
										short num12;
										do
										{
											Globals_Renamed.arRelModMedia[13, num6] = (float)((1.0 - Conversions.ToDouble(ChemStrX.ShowInSciNot(Globals_Renamed.arRelModParmsV[pDualID, 142, num6]))) * 100.0);
											Globals_Renamed.arRelModMedia[8, num6] = Globals_Renamed.arRelModParmsV[pDualID, 142, num6] * 100f;
											pDualID = (short)unchecked(pDualID + 1);
											num12 = pDualID;
											num10 = 1;
										}
										while (num12 <= num10);
									}
									num5 = (short)unchecked(num5 + 1);
									num13 = num5;
									num10 = 9;
								}
								while (num13 <= num10);
								num4 = (short)unchecked(num4 + 1);
								num14 = num4;
								num10 = 24;
							}
							while (num14 <= num10);
							break;
						}
						}
						short intNumOps = Globals_Renamed.intNumOps;
						num4 = 0;
						while (true)
						{
							short num24 = num4;
							num10 = intNumOps;
							if (num24 > num10)
							{
								break;
							}
							Globals_Renamed.intOpIndex = num4;
							short num5 = 0;
							short num25;
							do
							{
								Globals_Renamed.intActIndex = num5;
								ChemStrX.ResetMetaDefaults();
								num5 = (short)unchecked(num5 + 1);
								num25 = num5;
								num10 = 25;
							}
							while (num25 <= num10);
							num4 = (short)unchecked(num4 + 1);
						}
						num4 = 0;
						short num28;
						do
						{
							short num5 = 0;
							short num26;
							do
							{
								if (Globals_Renamed.arRelModels[num5, num4, Globals_Renamed.intOpIndex] > 0)
								{
									Globals_Renamed.arRelModStatus[Globals_Renamed.arRelModels[num5, num4, Globals_Renamed.intOpIndex] - 1] = 3;
								}
								num5 = (short)unchecked(num5 + 1);
								num26 = num5;
								num10 = 9;
							}
							while (num26 <= num10);
							num5 = 0;
							short num27;
							do
							{
								if (Globals_Renamed.arExpModels[num5, num4, Globals_Renamed.intOpIndex] > 0)
								{
									Globals_Renamed.arExpModStatus[Globals_Renamed.arExpModels[num5, num4, Globals_Renamed.intOpIndex] - 1] = 3;
								}
								num5 = (short)unchecked(num5 + 1);
								num27 = num5;
								num10 = 1;
							}
							while (num27 <= num10);
							num4 = (short)unchecked(num4 + 1);
							num28 = num4;
							num10 = 24;
						}
						while (num28 <= num10);
						((Control)this).Tag = frmMain.DefInstance._lstSelOps_1.SelectedIndex;
						frmMain.DefInstance._lstSelOps_1.SelectedIndex = -1;
						frmMain.DefInstance._lstSelOps_1.SelectedIndex = Conversions.ToInteger(((Control)this).Tag);
						flag2 = true;
						goto end_IL_0001;
					}
					case 3186:
						num = -1;
						switch (num2)
						{
						case 2:
						{
							string Eobject = "frmUpdSP.vb";
							string Efunction = "UpdateFrmMain";
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
				try0001_dispatch = 3186;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		bool result = flag2;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}
}
