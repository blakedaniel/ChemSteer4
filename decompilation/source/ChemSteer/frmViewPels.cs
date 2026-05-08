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
using MSComctlLib;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ChemSteer;

internal class frmViewPels : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("cmdOK")]
	private Button _cmdOK;

	[AccessedThroughProperty("_lblInstructions_8")]
	private Label __lblInstructions_8;

	[AccessedThroughProperty("_lblInstructions_3")]
	private Label __lblInstructions_3;

	[AccessedThroughProperty("_lblInstructions_4")]
	private Label __lblInstructions_4;

	[AccessedThroughProperty("_lblInstructions_5")]
	private Label __lblInstructions_5;

	[AccessedThroughProperty("Frame2")]
	private GroupBox _Frame2;

	[AccessedThroughProperty("_txtPEL_18")]
	private TextBox __txtPEL_18;

	[AccessedThroughProperty("_txtPEL_19")]
	private TextBox __txtPEL_19;

	[AccessedThroughProperty("_txtPEL_20")]
	private TextBox __txtPEL_20;

	[AccessedThroughProperty("_txtPEL_21")]
	private TextBox __txtPEL_21;

	[AccessedThroughProperty("_txtPEL_31")]
	private TextBox __txtPEL_31;

	[AccessedThroughProperty("_txtPEL_26")]
	private TextBox __txtPEL_26;

	[AccessedThroughProperty("_txtPEL_25")]
	private TextBox __txtPEL_25;

	[AccessedThroughProperty("_txtPEL_24")]
	private TextBox __txtPEL_24;

	[AccessedThroughProperty("_txtPEL_23")]
	private TextBox __txtPEL_23;

	[AccessedThroughProperty("_txtPEL_29")]
	private TextBox __txtPEL_29;

	[AccessedThroughProperty("_txtPEL_28")]
	private TextBox __txtPEL_28;

	[AccessedThroughProperty("_txtPEL_27")]
	private TextBox __txtPEL_27;

	[AccessedThroughProperty("_txtPEL_30")]
	private TextBox __txtPEL_30;

	[AccessedThroughProperty("_txtPEL_32")]
	private TextBox __txtPEL_32;

	[AccessedThroughProperty("_txtPEL_22")]
	private TextBox __txtPEL_22;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("Label13")]
	private Label _Label13;

	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	[AccessedThroughProperty("Label15")]
	private Label _Label15;

	[AccessedThroughProperty("Label16")]
	private Label _Label16;

	[AccessedThroughProperty("Label17")]
	private Label _Label17;

	[AccessedThroughProperty("Label18")]
	private Label _Label18;

	[AccessedThroughProperty("Label19")]
	private Label _Label19;

	[AccessedThroughProperty("Label20")]
	private Label _Label20;

	[AccessedThroughProperty("Label21")]
	private Label _Label21;

	[AccessedThroughProperty("Label22")]
	private Label _Label22;

	[AccessedThroughProperty("Label23")]
	private Label _Label23;

	[AccessedThroughProperty("Label24")]
	private Label _Label24;

	[AccessedThroughProperty("Label26")]
	private Label _Label26;

	[AccessedThroughProperty("_fraPEL_1")]
	private Panel __fraPEL_1;

	[AccessedThroughProperty("_lblInstructions_0")]
	private Label __lblInstructions_0;

	[AccessedThroughProperty("_lblInstructions_1")]
	private Label __lblInstructions_1;

	[AccessedThroughProperty("_lblInstructions_2")]
	private Label __lblInstructions_2;

	[AccessedThroughProperty("_lblInstructions_7")]
	private Label __lblInstructions_7;

	[AccessedThroughProperty("Frame3")]
	private GroupBox _Frame3;

	[AccessedThroughProperty("_txtPEL_17")]
	private TextBox __txtPEL_17;

	[AccessedThroughProperty("_txtPEL_15")]
	private TextBox __txtPEL_15;

	[AccessedThroughProperty("_txtPEL_12")]
	private TextBox __txtPEL_12;

	[AccessedThroughProperty("_txtPEL_13")]
	private TextBox __txtPEL_13;

	[AccessedThroughProperty("_txtPEL_14")]
	private TextBox __txtPEL_14;

	[AccessedThroughProperty("_txtPEL_8")]
	private TextBox __txtPEL_8;

	[AccessedThroughProperty("_txtPEL_9")]
	private TextBox __txtPEL_9;

	[AccessedThroughProperty("_txtPEL_10")]
	private TextBox __txtPEL_10;

	[AccessedThroughProperty("_txtPEL_11")]
	private TextBox __txtPEL_11;

	[AccessedThroughProperty("_txtPEL_7")]
	private TextBox __txtPEL_7;

	[AccessedThroughProperty("_txtPEL_6")]
	private TextBox __txtPEL_6;

	[AccessedThroughProperty("_txtPEL_5")]
	private TextBox __txtPEL_5;

	[AccessedThroughProperty("_txtPEL_4")]
	private TextBox __txtPEL_4;

	[AccessedThroughProperty("_txtPEL_3")]
	private TextBox __txtPEL_3;

	[AccessedThroughProperty("_txtPEL_16")]
	private TextBox __txtPEL_16;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("lblPELTWAConvmgm3")]
	private Label _lblPELTWAConvmgm3;

	[AccessedThroughProperty("lblPELTWAmgm3")]
	private Label _lblPELTWAmgm3;

	[AccessedThroughProperty("lblPELTWAConvppm")]
	private Label _lblPELTWAConvppm;

	[AccessedThroughProperty("lblPELTWAppm")]
	private Label _lblPELTWAppm;

	[AccessedThroughProperty("Label25")]
	private Label _Label25;

	[AccessedThroughProperty("_fraPEL_0")]
	private Panel __fraPEL_0;

	[AccessedThroughProperty("cmdNewSearch")]
	private Button _cmdNewSearch;

	[AccessedThroughProperty("_txtPEL_1")]
	private TextBox __txtPEL_1;

	[AccessedThroughProperty("_txtPEL_0")]
	private TextBox __txtPEL_0;

	[AccessedThroughProperty("_txtPEL_2")]
	private TextBox __txtPEL_2;

	[AccessedThroughProperty("cmdNext")]
	private Button _cmdNext;

	[AccessedThroughProperty("cmdPrev")]
	private Button _cmdPrev;

	[AccessedThroughProperty("cmdFirst")]
	private Button _cmdFirst;

	[AccessedThroughProperty("cmdLast")]
	private Button _cmdLast;

	[AccessedThroughProperty("tabViewPELs")]
	private AxTabStrip _tabViewPELs;

	[AccessedThroughProperty("lblMatches")]
	private Label _lblMatches;

	[AccessedThroughProperty("lblCAS")]
	private Label _lblCAS;

	[AccessedThroughProperty("lblMW")]
	private Label _lblMW;

	[AccessedThroughProperty("Label27")]
	private Label _Label27;

	[AccessedThroughProperty("fraView")]
	private Panel _fraView;

	[AccessedThroughProperty("cmdCanel")]
	private Button _cmdCanel;

	[AccessedThroughProperty("txtSearch")]
	private TextBox _txtSearch;

	[AccessedThroughProperty("_optSearch_0")]
	private RadioButton __optSearch_0;

	[AccessedThroughProperty("_optSearch_1")]
	private RadioButton __optSearch_1;

	[AccessedThroughProperty("cmdSearch")]
	private Button _cmdSearch;

	[AccessedThroughProperty("Label28")]
	private Label _Label28;

	[AccessedThroughProperty("fraSearch")]
	private Panel _fraSearch;

	private static frmViewPels m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	private object[,] arPELREL;

	private short currChem;

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

	public virtual Label _lblInstructions_8
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblInstructions_8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblInstructions_8 = value;
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

	public virtual Label _lblInstructions_5
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblInstructions_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblInstructions_5 = value;
		}
	}

	public virtual GroupBox Frame2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Frame2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Frame2 = value;
		}
	}

	public virtual TextBox _txtPEL_18
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtPEL_18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtPEL_18 = value;
		}
	}

	public virtual TextBox _txtPEL_19
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtPEL_19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtPEL_19 = value;
		}
	}

	public virtual TextBox _txtPEL_20
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtPEL_20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtPEL_20 = value;
		}
	}

	public virtual TextBox _txtPEL_21
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtPEL_21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtPEL_21 = value;
		}
	}

	public virtual TextBox _txtPEL_31
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtPEL_31;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtPEL_31 = value;
		}
	}

	public virtual TextBox _txtPEL_26
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtPEL_26;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtPEL_26 = value;
		}
	}

	public virtual TextBox _txtPEL_25
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtPEL_25;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtPEL_25 = value;
		}
	}

	public virtual TextBox _txtPEL_24
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtPEL_24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtPEL_24 = value;
		}
	}

	public virtual TextBox _txtPEL_23
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtPEL_23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtPEL_23 = value;
		}
	}

	public virtual TextBox _txtPEL_29
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtPEL_29;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtPEL_29 = value;
		}
	}

	public virtual TextBox _txtPEL_28
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtPEL_28;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtPEL_28 = value;
		}
	}

	public virtual TextBox _txtPEL_27
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtPEL_27;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtPEL_27 = value;
		}
	}

	public virtual TextBox _txtPEL_30
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtPEL_30;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtPEL_30 = value;
		}
	}

	public virtual TextBox _txtPEL_32
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtPEL_32;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtPEL_32 = value;
		}
	}

	public virtual TextBox _txtPEL_22
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtPEL_22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtPEL_22 = value;
		}
	}

	public virtual Label Label1
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

	public virtual Label Label12
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label12 = value;
		}
	}

	public virtual Label Label13
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label13 = value;
		}
	}

	public virtual Label Label14
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label14 = value;
		}
	}

	public virtual Label Label15
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label15 = value;
		}
	}

	public virtual Label Label16
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label16 = value;
		}
	}

	public virtual Label Label17
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label17 = value;
		}
	}

	public virtual Label Label18
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label18 = value;
		}
	}

	public virtual Label Label19
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label19 = value;
		}
	}

	public virtual Label Label20
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label20 = value;
		}
	}

	public virtual Label Label21
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label21 = value;
		}
	}

	public virtual Label Label22
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label22 = value;
		}
	}

	public virtual Label Label23
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label23 = value;
		}
	}

	public virtual Label Label24
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label24 = value;
		}
	}

	public virtual Label Label26
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label26;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label26 = value;
		}
	}

	public virtual Panel _fraPEL_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraPEL_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraPEL_1 = value;
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

	public virtual Label _lblInstructions_7
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblInstructions_7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblInstructions_7 = value;
		}
	}

	public virtual GroupBox Frame3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Frame3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Frame3 = value;
		}
	}

	public virtual TextBox _txtPEL_17
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtPEL_17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtPEL_17 = value;
		}
	}

	public virtual TextBox _txtPEL_15
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtPEL_15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtPEL_15 = value;
		}
	}

	public virtual TextBox _txtPEL_12
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtPEL_12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtPEL_12 = value;
		}
	}

	public virtual TextBox _txtPEL_13
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtPEL_13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtPEL_13 = value;
		}
	}

	public virtual TextBox _txtPEL_14
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtPEL_14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtPEL_14 = value;
		}
	}

	public virtual TextBox _txtPEL_8
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtPEL_8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtPEL_8 = value;
		}
	}

	public virtual TextBox _txtPEL_9
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtPEL_9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtPEL_9 = value;
		}
	}

	public virtual TextBox _txtPEL_10
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtPEL_10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtPEL_10 = value;
		}
	}

	public virtual TextBox _txtPEL_11
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtPEL_11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtPEL_11 = value;
		}
	}

	public virtual TextBox _txtPEL_7
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtPEL_7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtPEL_7 = value;
		}
	}

	public virtual TextBox _txtPEL_6
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtPEL_6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtPEL_6 = value;
		}
	}

	public virtual TextBox _txtPEL_5
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtPEL_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtPEL_5 = value;
		}
	}

	public virtual TextBox _txtPEL_4
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtPEL_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtPEL_4 = value;
		}
	}

	public virtual TextBox _txtPEL_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtPEL_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtPEL_3 = value;
		}
	}

	public virtual TextBox _txtPEL_16
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtPEL_16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtPEL_16 = value;
		}
	}

	public virtual Label Label11
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label11 = value;
		}
	}

	public virtual Label Label7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label7 = value;
		}
	}

	public virtual Label Label10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label10 = value;
		}
	}

	public virtual Label Label9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label9 = value;
		}
	}

	public virtual Label Label8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label8 = value;
		}
	}

	public virtual Label Label6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label6 = value;
		}
	}

	public virtual Label Label5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label5 = value;
		}
	}

	public virtual Label Label4
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

	public virtual Label Label3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label3 = value;
		}
	}

	public virtual Label Label2
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

	public virtual Label lblPELTWAConvmgm3
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPELTWAConvmgm3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPELTWAConvmgm3 = value;
		}
	}

	public virtual Label lblPELTWAmgm3
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPELTWAmgm3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPELTWAmgm3 = value;
		}
	}

	public virtual Label lblPELTWAConvppm
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPELTWAConvppm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPELTWAConvppm = value;
		}
	}

	public virtual Label lblPELTWAppm
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPELTWAppm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPELTWAppm = value;
		}
	}

	public virtual Label Label25
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label25;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label25 = value;
		}
	}

	public virtual Panel _fraPEL_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraPEL_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraPEL_0 = value;
		}
	}

	public virtual Button cmdNewSearch
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdNewSearch;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdNewSearch_Click;
			if (_cmdNewSearch != null)
			{
				((Control)_cmdNewSearch).Click -= eventHandler;
			}
			_cmdNewSearch = value;
			if (_cmdNewSearch != null)
			{
				((Control)_cmdNewSearch).Click += eventHandler;
			}
		}
	}

	public virtual TextBox _txtPEL_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtPEL_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtPEL_1 = value;
		}
	}

	public virtual TextBox _txtPEL_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtPEL_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtPEL_0 = value;
		}
	}

	public virtual TextBox _txtPEL_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtPEL_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtPEL_2 = value;
		}
	}

	public virtual Button cmdNext
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdNext;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdNext_Click;
			if (_cmdNext != null)
			{
				((Control)_cmdNext).Click -= eventHandler;
			}
			_cmdNext = value;
			if (_cmdNext != null)
			{
				((Control)_cmdNext).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdPrev
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdPrev;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdPrev_Click;
			if (_cmdPrev != null)
			{
				((Control)_cmdPrev).Click -= eventHandler;
			}
			_cmdPrev = value;
			if (_cmdPrev != null)
			{
				((Control)_cmdPrev).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdFirst
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdFirst;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdFirst_Click;
			if (_cmdFirst != null)
			{
				((Control)_cmdFirst).Click -= eventHandler;
			}
			_cmdFirst = value;
			if (_cmdFirst != null)
			{
				((Control)_cmdFirst).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdLast
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdLast;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdLast_Click;
			if (_cmdLast != null)
			{
				((Control)_cmdLast).Click -= eventHandler;
			}
			_cmdLast = value;
			if (_cmdLast != null)
			{
				((Control)_cmdLast).Click += eventHandler;
			}
		}
	}

	public virtual AxTabStrip tabViewPELs
	{
		[DebuggerNonUserCode]
		get
		{
			return _tabViewPELs;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = tabViewPELs_ClickEvent;
			if (_tabViewPELs != null)
			{
				_tabViewPELs.ClickEvent -= eventHandler;
			}
			_tabViewPELs = value;
			if (_tabViewPELs != null)
			{
				_tabViewPELs.ClickEvent += eventHandler;
			}
		}
	}

	public virtual Label lblMatches
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMatches;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMatches = value;
		}
	}

	public virtual Label lblCAS
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblCAS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblCAS = value;
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

	public virtual Label Label27
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label27;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label27 = value;
		}
	}

	public virtual Panel fraView
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

	public virtual Button cmdCanel
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdCanel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdCanel_Click;
			if (_cmdCanel != null)
			{
				((Control)_cmdCanel).Click -= eventHandler;
			}
			_cmdCanel = value;
			if (_cmdCanel != null)
			{
				((Control)_cmdCanel).Click += eventHandler;
			}
		}
	}

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

	public virtual RadioButton _optSearch_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __optSearch_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__optSearch_0 = value;
		}
	}

	public virtual RadioButton _optSearch_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __optSearch_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__optSearch_1 = value;
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

	public virtual Label Label28
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label28;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label28 = value;
		}
	}

	public virtual Panel fraSearch
	{
		[DebuggerNonUserCode]
		get
		{
			return _fraSearch;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_fraSearch = value;
		}
	}

	public static frmViewPels DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmViewPels();
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

	public frmViewPels()
	{
		((Form)this).Load += frmViewPels_Load;
		__ENCAddToList(this);
		arPELREL = new object[2, 2];
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
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Expected O, but got Unknown
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Expected O, but got Unknown
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Expected O, but got Unknown
		//IL_0466: Unknown result type (might be due to invalid IL or missing references)
		//IL_0470: Expected O, but got Unknown
		//IL_0472: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Expected O, but got Unknown
		//IL_047e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Expected O, but got Unknown
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Expected O, but got Unknown
		//IL_0695: Unknown result type (might be due to invalid IL or missing references)
		//IL_069f: Expected O, but got Unknown
		//IL_074a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0754: Expected O, but got Unknown
		//IL_081e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0828: Expected O, but got Unknown
		//IL_08ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0909: Expected O, but got Unknown
		//IL_09f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a00: Expected O, but got Unknown
		//IL_0ada: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae4: Expected O, but got Unknown
		//IL_0bb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbe: Expected O, but got Unknown
		//IL_0c87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c91: Expected O, but got Unknown
		//IL_0d57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d61: Expected O, but got Unknown
		//IL_0e26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e30: Expected O, but got Unknown
		//IL_0ef9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f03: Expected O, but got Unknown
		//IL_0fbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc9: Expected O, but got Unknown
		//IL_107f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1089: Expected O, but got Unknown
		//IL_1150: Unknown result type (might be due to invalid IL or missing references)
		//IL_115a: Expected O, but got Unknown
		//IL_14d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e2: Expected O, but got Unknown
		//IL_15d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e3: Expected O, but got Unknown
		//IL_169f: Unknown result type (might be due to invalid IL or missing references)
		//IL_16a9: Expected O, but got Unknown
		//IL_1763: Unknown result type (might be due to invalid IL or missing references)
		//IL_176d: Expected O, but got Unknown
		//IL_1827: Unknown result type (might be due to invalid IL or missing references)
		//IL_1831: Expected O, but got Unknown
		//IL_18eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_18f5: Expected O, but got Unknown
		//IL_19bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_19c6: Expected O, but got Unknown
		//IL_1ab3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1abd: Expected O, but got Unknown
		//IL_1b9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ba7: Expected O, but got Unknown
		//IL_1c87: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c91: Expected O, but got Unknown
		//IL_1d71: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d7b: Expected O, but got Unknown
		//IL_1e5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e65: Expected O, but got Unknown
		//IL_1f42: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f4c: Expected O, but got Unknown
		//IL_2029: Unknown result type (might be due to invalid IL or missing references)
		//IL_2033: Expected O, but got Unknown
		//IL_2113: Unknown result type (might be due to invalid IL or missing references)
		//IL_211d: Expected O, but got Unknown
		//IL_21fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2207: Expected O, but got Unknown
		//IL_22f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_22fd: Expected O, but got Unknown
		//IL_23da: Unknown result type (might be due to invalid IL or missing references)
		//IL_23e4: Expected O, but got Unknown
		//IL_24c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_24cb: Expected O, but got Unknown
		//IL_25a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_25b2: Expected O, but got Unknown
		//IL_268e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2698: Expected O, but got Unknown
		//IL_276b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2775: Expected O, but got Unknown
		//IL_283c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2846: Expected O, but got Unknown
		//IL_2902: Unknown result type (might be due to invalid IL or missing references)
		//IL_290c: Expected O, but got Unknown
		//IL_29c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_29d2: Expected O, but got Unknown
		//IL_2a8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a98: Expected O, but got Unknown
		//IL_2b54: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b5e: Expected O, but got Unknown
		//IL_2c17: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c21: Expected O, but got Unknown
		//IL_2cda: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ce4: Expected O, but got Unknown
		//IL_2da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2daa: Expected O, but got Unknown
		//IL_2e66: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e70: Expected O, but got Unknown
		//IL_2f36: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f40: Expected O, but got Unknown
		//IL_2ff9: Unknown result type (might be due to invalid IL or missing references)
		//IL_3003: Expected O, but got Unknown
		//IL_30bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_30c6: Expected O, but got Unknown
		//IL_317f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3189: Expected O, but got Unknown
		//IL_3241: Unknown result type (might be due to invalid IL or missing references)
		//IL_324b: Expected O, but got Unknown
		//IL_35d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_35da: Expected O, but got Unknown
		//IL_36d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_36db: Expected O, but got Unknown
		//IL_3797: Unknown result type (might be due to invalid IL or missing references)
		//IL_37a1: Expected O, but got Unknown
		//IL_385b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3865: Expected O, but got Unknown
		//IL_391f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3929: Expected O, but got Unknown
		//IL_39e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_39ed: Expected O, but got Unknown
		//IL_3ab4: Unknown result type (might be due to invalid IL or missing references)
		//IL_3abe: Expected O, but got Unknown
		//IL_3b9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ba4: Expected O, but got Unknown
		//IL_3c81: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c8b: Expected O, but got Unknown
		//IL_3d68: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d72: Expected O, but got Unknown
		//IL_3e4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e59: Expected O, but got Unknown
		//IL_3f36: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f40: Expected O, but got Unknown
		//IL_4020: Unknown result type (might be due to invalid IL or missing references)
		//IL_402a: Expected O, but got Unknown
		//IL_410a: Unknown result type (might be due to invalid IL or missing references)
		//IL_4114: Expected O, but got Unknown
		//IL_41f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_41fb: Expected O, but got Unknown
		//IL_42d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_42e2: Expected O, but got Unknown
		//IL_43c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_43cc: Expected O, but got Unknown
		//IL_44ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_44b6: Expected O, but got Unknown
		//IL_4596: Unknown result type (might be due to invalid IL or missing references)
		//IL_45a0: Expected O, but got Unknown
		//IL_4680: Unknown result type (might be due to invalid IL or missing references)
		//IL_468a: Expected O, but got Unknown
		//IL_4784: Unknown result type (might be due to invalid IL or missing references)
		//IL_478e: Expected O, but got Unknown
		//IL_487a: Unknown result type (might be due to invalid IL or missing references)
		//IL_4884: Expected O, but got Unknown
		//IL_4939: Unknown result type (might be due to invalid IL or missing references)
		//IL_4943: Expected O, but got Unknown
		//IL_49fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a06: Expected O, but got Unknown
		//IL_4abf: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ac9: Expected O, but got Unknown
		//IL_4b82: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b8c: Expected O, but got Unknown
		//IL_4c46: Unknown result type (might be due to invalid IL or missing references)
		//IL_4c50: Expected O, but got Unknown
		//IL_4d0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d16: Expected O, but got Unknown
		//IL_4dd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ddc: Expected O, but got Unknown
		//IL_4e95: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e9f: Expected O, but got Unknown
		//IL_4f55: Unknown result type (might be due to invalid IL or missing references)
		//IL_4f5f: Expected O, but got Unknown
		//IL_501b: Unknown result type (might be due to invalid IL or missing references)
		//IL_5025: Expected O, but got Unknown
		//IL_50e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_50eb: Expected O, but got Unknown
		//IL_51a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_51ae: Expected O, but got Unknown
		//IL_526a: Unknown result type (might be due to invalid IL or missing references)
		//IL_5274: Expected O, but got Unknown
		//IL_532e: Unknown result type (might be due to invalid IL or missing references)
		//IL_5338: Expected O, but got Unknown
		//IL_53f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_5400: Expected O, but got Unknown
		//IL_54ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_54f8: Expected O, but got Unknown
		//IL_55a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_55ad: Expected O, but got Unknown
		//IL_5683: Unknown result type (might be due to invalid IL or missing references)
		//IL_568d: Expected O, but got Unknown
		//IL_5741: Unknown result type (might be due to invalid IL or missing references)
		//IL_574b: Expected O, but got Unknown
		//IL_581d: Unknown result type (might be due to invalid IL or missing references)
		//IL_5827: Expected O, but got Unknown
		//IL_58fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_5907: Expected O, but got Unknown
		//IL_59cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_59d6: Expected O, but got Unknown
		//IL_5ae6: Unknown result type (might be due to invalid IL or missing references)
		//IL_5af0: Expected O, but got Unknown
		//IL_5b05: Unknown result type (might be due to invalid IL or missing references)
		//IL_5b0f: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmViewPels));
		ToolTip1 = new ToolTip(components);
		fraView = new Panel();
		cmdOK = new Button();
		cmdNewSearch = new Button();
		_txtPEL_1 = new TextBox();
		_txtPEL_0 = new TextBox();
		_txtPEL_2 = new TextBox();
		cmdNext = new Button();
		cmdPrev = new Button();
		cmdFirst = new Button();
		cmdLast = new Button();
		lblMatches = new Label();
		lblCAS = new Label();
		lblMW = new Label();
		Label27 = new Label();
		_fraPEL_0 = new Panel();
		Frame3 = new GroupBox();
		_lblInstructions_0 = new Label();
		_lblInstructions_1 = new Label();
		_lblInstructions_2 = new Label();
		_lblInstructions_7 = new Label();
		_txtPEL_17 = new TextBox();
		_txtPEL_15 = new TextBox();
		_txtPEL_12 = new TextBox();
		_txtPEL_13 = new TextBox();
		_txtPEL_14 = new TextBox();
		_txtPEL_8 = new TextBox();
		_txtPEL_9 = new TextBox();
		_txtPEL_10 = new TextBox();
		_txtPEL_11 = new TextBox();
		_txtPEL_7 = new TextBox();
		_txtPEL_6 = new TextBox();
		_txtPEL_5 = new TextBox();
		_txtPEL_4 = new TextBox();
		_txtPEL_3 = new TextBox();
		_txtPEL_16 = new TextBox();
		Label11 = new Label();
		Label7 = new Label();
		Label10 = new Label();
		Label9 = new Label();
		Label8 = new Label();
		Label6 = new Label();
		Label5 = new Label();
		Label4 = new Label();
		Label3 = new Label();
		Label2 = new Label();
		lblPELTWAConvmgm3 = new Label();
		lblPELTWAmgm3 = new Label();
		lblPELTWAConvppm = new Label();
		lblPELTWAppm = new Label();
		Label25 = new Label();
		_fraPEL_1 = new Panel();
		Frame2 = new GroupBox();
		_lblInstructions_8 = new Label();
		_lblInstructions_3 = new Label();
		_lblInstructions_4 = new Label();
		_lblInstructions_5 = new Label();
		_txtPEL_18 = new TextBox();
		_txtPEL_19 = new TextBox();
		_txtPEL_20 = new TextBox();
		_txtPEL_21 = new TextBox();
		_txtPEL_31 = new TextBox();
		_txtPEL_26 = new TextBox();
		_txtPEL_25 = new TextBox();
		_txtPEL_24 = new TextBox();
		_txtPEL_23 = new TextBox();
		_txtPEL_29 = new TextBox();
		_txtPEL_28 = new TextBox();
		_txtPEL_27 = new TextBox();
		_txtPEL_30 = new TextBox();
		_txtPEL_32 = new TextBox();
		_txtPEL_22 = new TextBox();
		Label1 = new Label();
		Label12 = new Label();
		Label13 = new Label();
		Label14 = new Label();
		Label15 = new Label();
		Label16 = new Label();
		Label17 = new Label();
		Label18 = new Label();
		Label19 = new Label();
		Label20 = new Label();
		Label21 = new Label();
		Label22 = new Label();
		Label23 = new Label();
		Label24 = new Label();
		Label26 = new Label();
		tabViewPELs = new AxTabStrip();
		fraSearch = new Panel();
		cmdCanel = new Button();
		txtSearch = new TextBox();
		_optSearch_0 = new RadioButton();
		_optSearch_1 = new RadioButton();
		cmdSearch = new Button();
		Label28 = new Label();
		((Control)fraView).SuspendLayout();
		((Control)_fraPEL_0).SuspendLayout();
		((Control)Frame3).SuspendLayout();
		((Control)_fraPEL_1).SuspendLayout();
		((Control)Frame2).SuspendLayout();
		((ISupportInitialize)tabViewPELs).BeginInit();
		((Control)fraSearch).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)fraView).BackColor = SystemColors.Control;
		((Control)fraView).Controls.Add((Control)(object)cmdOK);
		((Control)fraView).Controls.Add((Control)(object)cmdNewSearch);
		((Control)fraView).Controls.Add((Control)(object)_txtPEL_1);
		((Control)fraView).Controls.Add((Control)(object)_txtPEL_0);
		((Control)fraView).Controls.Add((Control)(object)_txtPEL_2);
		((Control)fraView).Controls.Add((Control)(object)cmdNext);
		((Control)fraView).Controls.Add((Control)(object)cmdPrev);
		((Control)fraView).Controls.Add((Control)(object)cmdFirst);
		((Control)fraView).Controls.Add((Control)(object)cmdLast);
		((Control)fraView).Controls.Add((Control)(object)lblMatches);
		((Control)fraView).Controls.Add((Control)(object)lblCAS);
		((Control)fraView).Controls.Add((Control)(object)lblMW);
		((Control)fraView).Controls.Add((Control)(object)Label27);
		((Control)fraView).Controls.Add((Control)(object)_fraPEL_0);
		((Control)fraView).Controls.Add((Control)(object)_fraPEL_1);
		((Control)fraView).Controls.Add((Control)(object)tabViewPELs);
		((Control)fraView).Cursor = Cursors.Default;
		((Control)fraView).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)fraView).ForeColor = SystemColors.ControlText;
		Panel obj = fraView;
		Point location = new Point(8, 16);
		((Control)obj).Location = location;
		((Control)fraView).Name = "fraView";
		((Control)fraView).RightToLeft = (RightToLeft)0;
		Panel obj2 = fraView;
		Size size = new Size(729, 481);
		((Control)obj2).Size = size;
		((Control)fraView).TabIndex = 39;
		((ButtonBase)cmdOK).BackColor = SystemColors.Control;
		((Control)cmdOK).Cursor = Cursors.Default;
		((Control)cmdOK).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdOK).ForeColor = SystemColors.ControlText;
		Button obj3 = cmdOK;
		location = new Point(632, 456);
		((Control)obj3).Location = location;
		((Control)cmdOK).Name = "cmdOK";
		((Control)cmdOK).RightToLeft = (RightToLeft)0;
		Button obj4 = cmdOK;
		size = new Size(89, 25);
		((Control)obj4).Size = size;
		((Control)cmdOK).TabIndex = 93;
		((ButtonBase)cmdOK).Text = "&Close Window";
		((ButtonBase)cmdOK).UseVisualStyleBackColor = false;
		((ButtonBase)cmdNewSearch).BackColor = SystemColors.Control;
		((Control)cmdNewSearch).Cursor = Cursors.Default;
		((Control)cmdNewSearch).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdNewSearch).ForeColor = SystemColors.ControlText;
		Button obj5 = cmdNewSearch;
		location = new Point(632, 424);
		((Control)obj5).Location = location;
		((Control)cmdNewSearch).Name = "cmdNewSearch";
		((Control)cmdNewSearch).RightToLeft = (RightToLeft)0;
		Button obj6 = cmdNewSearch;
		size = new Size(89, 25);
		((Control)obj6).Size = size;
		((Control)cmdNewSearch).TabIndex = 9;
		((ButtonBase)cmdNewSearch).Text = "New &Search";
		((ButtonBase)cmdNewSearch).UseVisualStyleBackColor = false;
		_txtPEL_1.AcceptsReturn = true;
		((TextBoxBase)_txtPEL_1).BackColor = SystemColors.Menu;
		((Control)_txtPEL_1).Cursor = Cursors.IBeam;
		((Control)_txtPEL_1).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtPEL_1).ForeColor = SystemColors.WindowText;
		TextBox txtPEL_ = _txtPEL_1;
		location = new Point(99, 0);
		((Control)txtPEL_).Location = location;
		((TextBoxBase)_txtPEL_1).MaxLength = 0;
		((Control)_txtPEL_1).Name = "_txtPEL_1";
		((TextBoxBase)_txtPEL_1).ReadOnly = true;
		((Control)_txtPEL_1).RightToLeft = (RightToLeft)0;
		TextBox txtPEL_2 = _txtPEL_1;
		size = new Size(497, 20);
		((Control)txtPEL_2).Size = size;
		((Control)_txtPEL_1).TabIndex = 85;
		((Control)_txtPEL_1).TabStop = false;
		_txtPEL_1.Text = "Chem name";
		_txtPEL_0.AcceptsReturn = true;
		((TextBoxBase)_txtPEL_0).BackColor = SystemColors.Menu;
		((Control)_txtPEL_0).Cursor = Cursors.IBeam;
		((Control)_txtPEL_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtPEL_0).ForeColor = SystemColors.WindowText;
		TextBox txtPEL_3 = _txtPEL_0;
		location = new Point(88, 29);
		((Control)txtPEL_3).Location = location;
		((TextBoxBase)_txtPEL_0).MaxLength = 0;
		((Control)_txtPEL_0).Name = "_txtPEL_0";
		((TextBoxBase)_txtPEL_0).ReadOnly = true;
		((Control)_txtPEL_0).RightToLeft = (RightToLeft)0;
		TextBox txtPEL_4 = _txtPEL_0;
		size = new Size(81, 20);
		((Control)txtPEL_4).Size = size;
		((Control)_txtPEL_0).TabIndex = 84;
		((Control)_txtPEL_0).TabStop = false;
		_txtPEL_2.AcceptsReturn = true;
		((TextBoxBase)_txtPEL_2).BackColor = SystemColors.Menu;
		((Control)_txtPEL_2).Cursor = Cursors.IBeam;
		((Control)_txtPEL_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtPEL_2).ForeColor = SystemColors.WindowText;
		TextBox txtPEL_5 = _txtPEL_2;
		location = new Point(288, 32);
		((Control)txtPEL_5).Location = location;
		((TextBoxBase)_txtPEL_2).MaxLength = 0;
		((Control)_txtPEL_2).Name = "_txtPEL_2";
		((TextBoxBase)_txtPEL_2).ReadOnly = true;
		((Control)_txtPEL_2).RightToLeft = (RightToLeft)0;
		TextBox txtPEL_6 = _txtPEL_2;
		size = new Size(81, 20);
		((Control)txtPEL_6).Size = size;
		((Control)_txtPEL_2).TabIndex = 83;
		((Control)_txtPEL_2).TabStop = false;
		((ButtonBase)cmdNext).BackColor = SystemColors.Control;
		((Control)cmdNext).Cursor = Cursors.Default;
		((Control)cmdNext).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdNext).ForeColor = SystemColors.ControlText;
		Button obj7 = cmdNext;
		location = new Point(152, 424);
		((Control)obj7).Location = location;
		((Control)cmdNext).Name = "cmdNext";
		((Control)cmdNext).RightToLeft = (RightToLeft)0;
		Button obj8 = cmdNext;
		size = new Size(65, 25);
		((Control)obj8).Size = size;
		((Control)cmdNext).TabIndex = 7;
		((ButtonBase)cmdNext).Text = "&Next >";
		((ButtonBase)cmdNext).UseVisualStyleBackColor = false;
		((ButtonBase)cmdPrev).BackColor = SystemColors.Control;
		((Control)cmdPrev).Cursor = Cursors.Default;
		((Control)cmdPrev).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdPrev).ForeColor = SystemColors.ControlText;
		Button obj9 = cmdPrev;
		location = new Point(80, 424);
		((Control)obj9).Location = location;
		((Control)cmdPrev).Name = "cmdPrev";
		((Control)cmdPrev).RightToLeft = (RightToLeft)0;
		Button obj10 = cmdPrev;
		size = new Size(65, 25);
		((Control)obj10).Size = size;
		((Control)cmdPrev).TabIndex = 6;
		((ButtonBase)cmdPrev).Text = "< &Previous";
		((ButtonBase)cmdPrev).UseVisualStyleBackColor = false;
		((ButtonBase)cmdFirst).BackColor = SystemColors.Control;
		((Control)cmdFirst).Cursor = Cursors.Default;
		((Control)cmdFirst).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdFirst).ForeColor = SystemColors.ControlText;
		Button obj11 = cmdFirst;
		location = new Point(8, 424);
		((Control)obj11).Location = location;
		((Control)cmdFirst).Name = "cmdFirst";
		((Control)cmdFirst).RightToLeft = (RightToLeft)0;
		Button obj12 = cmdFirst;
		size = new Size(65, 25);
		((Control)obj12).Size = size;
		((Control)cmdFirst).TabIndex = 5;
		((ButtonBase)cmdFirst).Text = "<<< &First";
		((ButtonBase)cmdFirst).UseVisualStyleBackColor = false;
		((ButtonBase)cmdLast).BackColor = SystemColors.Control;
		((Control)cmdLast).Cursor = Cursors.Default;
		((Control)cmdLast).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdLast).ForeColor = SystemColors.ControlText;
		Button obj13 = cmdLast;
		location = new Point(224, 424);
		((Control)obj13).Location = location;
		((Control)cmdLast).Name = "cmdLast";
		((Control)cmdLast).RightToLeft = (RightToLeft)0;
		Button obj14 = cmdLast;
		size = new Size(65, 25);
		((Control)obj14).Size = size;
		((Control)cmdLast).TabIndex = 8;
		((ButtonBase)cmdLast).Text = "&Last >>>";
		((ButtonBase)cmdLast).UseVisualStyleBackColor = false;
		((Control)lblMatches).BackColor = SystemColors.Control;
		((Control)lblMatches).Cursor = Cursors.Default;
		((Control)lblMatches).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)lblMatches).ForeColor = SystemColors.ControlText;
		Label obj15 = lblMatches;
		location = new Point(8, 456);
		((Control)obj15).Location = location;
		((Control)lblMatches).Name = "lblMatches";
		((Control)lblMatches).RightToLeft = (RightToLeft)0;
		Label obj16 = lblMatches;
		size = new Size(161, 17);
		((Control)obj16).Size = size;
		((Control)lblMatches).TabIndex = 92;
		lblMatches.Text = "xx matches found";
		((Control)lblCAS).BackColor = SystemColors.Control;
		((Control)lblCAS).Cursor = Cursors.Default;
		((Control)lblCAS).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblCAS).ForeColor = SystemColors.ControlText;
		Label obj17 = lblCAS;
		location = new Point(8, 32);
		((Control)obj17).Location = location;
		((Control)lblCAS).Name = "lblCAS";
		((Control)lblCAS).RightToLeft = (RightToLeft)0;
		Label obj18 = lblCAS;
		size = new Size(76, 17);
		((Control)obj18).Size = size;
		((Control)lblCAS).TabIndex = 89;
		lblCAS.Text = "CAS Number: ";
		((Control)lblMW).BackColor = SystemColors.Control;
		((Control)lblMW).Cursor = Cursors.Default;
		((Control)lblMW).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblMW).ForeColor = SystemColors.ControlText;
		Label obj19 = lblMW;
		location = new Point(184, 32);
		((Control)obj19).Location = location;
		((Control)lblMW).Name = "lblMW";
		((Control)lblMW).RightToLeft = (RightToLeft)0;
		Label obj20 = lblMW;
		size = new Size(105, 17);
		((Control)obj20).Size = size;
		((Control)lblMW).TabIndex = 88;
		lblMW.Text = "Molecular Weight:";
		lblMW.TextAlign = (ContentAlignment)4;
		((Control)Label27).BackColor = SystemColors.Control;
		((Control)Label27).Cursor = Cursors.Default;
		((Control)Label27).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label27).ForeColor = SystemColors.ControlText;
		Label label = Label27;
		location = new Point(8, 0);
		((Control)label).Location = location;
		((Control)Label27).Name = "Label27";
		((Control)Label27).RightToLeft = (RightToLeft)0;
		Label label2 = Label27;
		size = new Size(85, 20);
		((Control)label2).Size = size;
		((Control)Label27).TabIndex = 87;
		Label27.Text = "Chemical Name:";
		((Control)_fraPEL_0).BackColor = SystemColors.Control;
		((Control)_fraPEL_0).Controls.Add((Control)(object)Frame3);
		((Control)_fraPEL_0).Controls.Add((Control)(object)_txtPEL_17);
		((Control)_fraPEL_0).Controls.Add((Control)(object)_txtPEL_15);
		((Control)_fraPEL_0).Controls.Add((Control)(object)_txtPEL_12);
		((Control)_fraPEL_0).Controls.Add((Control)(object)_txtPEL_13);
		((Control)_fraPEL_0).Controls.Add((Control)(object)_txtPEL_14);
		((Control)_fraPEL_0).Controls.Add((Control)(object)_txtPEL_8);
		((Control)_fraPEL_0).Controls.Add((Control)(object)_txtPEL_9);
		((Control)_fraPEL_0).Controls.Add((Control)(object)_txtPEL_10);
		((Control)_fraPEL_0).Controls.Add((Control)(object)_txtPEL_11);
		((Control)_fraPEL_0).Controls.Add((Control)(object)_txtPEL_7);
		((Control)_fraPEL_0).Controls.Add((Control)(object)_txtPEL_6);
		((Control)_fraPEL_0).Controls.Add((Control)(object)_txtPEL_5);
		((Control)_fraPEL_0).Controls.Add((Control)(object)_txtPEL_4);
		((Control)_fraPEL_0).Controls.Add((Control)(object)_txtPEL_3);
		((Control)_fraPEL_0).Controls.Add((Control)(object)_txtPEL_16);
		((Control)_fraPEL_0).Controls.Add((Control)(object)Label11);
		((Control)_fraPEL_0).Controls.Add((Control)(object)Label7);
		((Control)_fraPEL_0).Controls.Add((Control)(object)Label10);
		((Control)_fraPEL_0).Controls.Add((Control)(object)Label9);
		((Control)_fraPEL_0).Controls.Add((Control)(object)Label8);
		((Control)_fraPEL_0).Controls.Add((Control)(object)Label6);
		((Control)_fraPEL_0).Controls.Add((Control)(object)Label5);
		((Control)_fraPEL_0).Controls.Add((Control)(object)Label4);
		((Control)_fraPEL_0).Controls.Add((Control)(object)Label3);
		((Control)_fraPEL_0).Controls.Add((Control)(object)Label2);
		((Control)_fraPEL_0).Controls.Add((Control)(object)lblPELTWAConvmgm3);
		((Control)_fraPEL_0).Controls.Add((Control)(object)lblPELTWAmgm3);
		((Control)_fraPEL_0).Controls.Add((Control)(object)lblPELTWAConvppm);
		((Control)_fraPEL_0).Controls.Add((Control)(object)lblPELTWAppm);
		((Control)_fraPEL_0).Controls.Add((Control)(object)Label25);
		((Control)_fraPEL_0).Cursor = Cursors.Default;
		((Control)_fraPEL_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_fraPEL_0).ForeColor = SystemColors.ControlText;
		Panel fraPEL_ = _fraPEL_0;
		location = new Point(24, 88);
		((Control)fraPEL_).Location = location;
		((Control)_fraPEL_0).Name = "_fraPEL_0";
		((Control)_fraPEL_0).RightToLeft = (RightToLeft)0;
		Panel fraPEL_2 = _fraPEL_0;
		size = new Size(681, 321);
		((Control)fraPEL_2).Size = size;
		((Control)_fraPEL_0).TabIndex = 62;
		((Control)Frame3).BackColor = SystemColors.Control;
		((Control)Frame3).Controls.Add((Control)(object)_lblInstructions_0);
		((Control)Frame3).Controls.Add((Control)(object)_lblInstructions_1);
		((Control)Frame3).Controls.Add((Control)(object)_lblInstructions_2);
		((Control)Frame3).Controls.Add((Control)(object)_lblInstructions_7);
		((Control)Frame3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Frame3).ForeColor = SystemColors.ControlText;
		GroupBox frame = Frame3;
		location = new Point(368, 176);
		((Control)frame).Location = location;
		((Control)Frame3).Name = "Frame3";
		((Control)Frame3).RightToLeft = (RightToLeft)0;
		GroupBox frame2 = Frame3;
		size = new Size(289, 113);
		((Control)frame2).Size = size;
		((Control)Frame3).TabIndex = 63;
		Frame3.TabStop = false;
		((Control)_lblInstructions_0).BackColor = SystemColors.Control;
		((Control)_lblInstructions_0).Cursor = Cursors.Default;
		((Control)_lblInstructions_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblInstructions_0).ForeColor = SystemColors.ControlText;
		Label lblInstructions_ = _lblInstructions_0;
		location = new Point(16, 16);
		((Control)lblInstructions_).Location = location;
		((Control)_lblInstructions_0).Name = "_lblInstructions_0";
		((Control)_lblInstructions_0).RightToLeft = (RightToLeft)0;
		Label lblInstructions_2 = _lblInstructions_0;
		size = new Size(241, 17);
		((Control)lblInstructions_2).Size = size;
		((Control)_lblInstructions_0).TabIndex = 67;
		_lblInstructions_0.Text = "PEL-TWA: OSHA PEL time-weighted average";
		((Control)_lblInstructions_1).BackColor = SystemColors.Control;
		((Control)_lblInstructions_1).Cursor = Cursors.Default;
		((Control)_lblInstructions_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblInstructions_1).ForeColor = SystemColors.ControlText;
		Label lblInstructions_3 = _lblInstructions_1;
		location = new Point(16, 32);
		((Control)lblInstructions_3).Location = location;
		((Control)_lblInstructions_1).Name = "_lblInstructions_1";
		((Control)_lblInstructions_1).RightToLeft = (RightToLeft)0;
		Label lblInstructions_4 = _lblInstructions_1;
		size = new Size(249, 17);
		((Control)lblInstructions_4).Size = size;
		((Control)_lblInstructions_1).TabIndex = 66;
		_lblInstructions_1.Text = "PEL-STEL: OSHA PEL short-term exposure limit";
		((Control)_lblInstructions_2).BackColor = SystemColors.Control;
		((Control)_lblInstructions_2).Cursor = Cursors.Default;
		((Control)_lblInstructions_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblInstructions_2).ForeColor = SystemColors.ControlText;
		Label lblInstructions_5 = _lblInstructions_2;
		location = new Point(16, 48);
		((Control)lblInstructions_5).Location = location;
		((Control)_lblInstructions_2).Name = "_lblInstructions_2";
		((Control)_lblInstructions_2).RightToLeft = (RightToLeft)0;
		Label lblInstructions_6 = _lblInstructions_2;
		size = new Size(241, 17);
		((Control)lblInstructions_6).Size = size;
		((Control)_lblInstructions_2).TabIndex = 65;
		_lblInstructions_2.Text = "PEL-CL: OSHA PEL ceiling";
		((Control)_lblInstructions_7).BackColor = SystemColors.Control;
		((Control)_lblInstructions_7).Cursor = Cursors.Default;
		((Control)_lblInstructions_7).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblInstructions_7).ForeColor = SystemColors.ControlText;
		Label lblInstructions_7 = _lblInstructions_7;
		location = new Point(16, 72);
		((Control)lblInstructions_7).Location = location;
		((Control)_lblInstructions_7).Name = "_lblInstructions_7";
		((Control)_lblInstructions_7).RightToLeft = (RightToLeft)0;
		Label lblInstructions_8 = _lblInstructions_7;
		size = new Size(257, 33);
		((Control)lblInstructions_8).Size = size;
		((Control)_lblInstructions_7).TabIndex = 64;
		_lblInstructions_7.Text = "Read the \"List of OSHA PELs and NIOSH RELs\" topic in the Help System for more information.";
		_txtPEL_17.AcceptsReturn = true;
		((TextBoxBase)_txtPEL_17).BackColor = SystemColors.Menu;
		((Control)_txtPEL_17).Cursor = Cursors.IBeam;
		((Control)_txtPEL_17).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtPEL_17).ForeColor = SystemColors.WindowText;
		TextBox txtPEL_7 = _txtPEL_17;
		location = new Point(368, 72);
		((Control)txtPEL_7).Location = location;
		((TextBoxBase)_txtPEL_17).MaxLength = 0;
		((Control)_txtPEL_17).Name = "_txtPEL_17";
		((TextBoxBase)_txtPEL_17).ReadOnly = true;
		((Control)_txtPEL_17).RightToLeft = (RightToLeft)0;
		_txtPEL_17.ScrollBars = (ScrollBars)2;
		TextBox txtPEL_8 = _txtPEL_17;
		size = new Size(289, 20);
		((Control)txtPEL_8).Size = size;
		((Control)_txtPEL_17).TabIndex = 38;
		((Control)_txtPEL_17).TabStop = false;
		_txtPEL_15.AcceptsReturn = true;
		((TextBoxBase)_txtPEL_15).BackColor = SystemColors.Menu;
		((Control)_txtPEL_15).Cursor = Cursors.IBeam;
		((Control)_txtPEL_15).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtPEL_15).ForeColor = SystemColors.WindowText;
		TextBox txtPEL_9 = _txtPEL_15;
		location = new Point(176, 264);
		((Control)txtPEL_9).Location = location;
		((TextBoxBase)_txtPEL_15).MaxLength = 0;
		((Control)_txtPEL_15).Name = "_txtPEL_15";
		((TextBoxBase)_txtPEL_15).ReadOnly = true;
		((Control)_txtPEL_15).RightToLeft = (RightToLeft)0;
		TextBox txtPEL_10 = _txtPEL_15;
		size = new Size(65, 20);
		((Control)txtPEL_10).Size = size;
		((Control)_txtPEL_15).TabIndex = 35;
		((Control)_txtPEL_15).TabStop = false;
		_txtPEL_12.AcceptsReturn = true;
		((TextBoxBase)_txtPEL_12).BackColor = SystemColors.Menu;
		((Control)_txtPEL_12).Cursor = Cursors.IBeam;
		((Control)_txtPEL_12).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtPEL_12).ForeColor = SystemColors.WindowText;
		TextBox txtPEL_11 = _txtPEL_12;
		location = new Point(176, 192);
		((Control)txtPEL_11).Location = location;
		((TextBoxBase)_txtPEL_12).MaxLength = 0;
		((Control)_txtPEL_12).Name = "_txtPEL_12";
		((TextBoxBase)_txtPEL_12).ReadOnly = true;
		((Control)_txtPEL_12).RightToLeft = (RightToLeft)0;
		TextBox txtPEL_12 = _txtPEL_12;
		size = new Size(65, 20);
		((Control)txtPEL_12).Size = size;
		((Control)_txtPEL_12).TabIndex = 32;
		((Control)_txtPEL_12).TabStop = false;
		_txtPEL_13.AcceptsReturn = true;
		((TextBoxBase)_txtPEL_13).BackColor = SystemColors.Menu;
		((Control)_txtPEL_13).Cursor = Cursors.IBeam;
		((Control)_txtPEL_13).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtPEL_13).ForeColor = SystemColors.WindowText;
		TextBox txtPEL_13 = _txtPEL_13;
		location = new Point(176, 216);
		((Control)txtPEL_13).Location = location;
		((TextBoxBase)_txtPEL_13).MaxLength = 0;
		((Control)_txtPEL_13).Name = "_txtPEL_13";
		((TextBoxBase)_txtPEL_13).ReadOnly = true;
		((Control)_txtPEL_13).RightToLeft = (RightToLeft)0;
		TextBox txtPEL_14 = _txtPEL_13;
		size = new Size(65, 20);
		((Control)txtPEL_14).Size = size;
		((Control)_txtPEL_13).TabIndex = 33;
		((Control)_txtPEL_13).TabStop = false;
		_txtPEL_14.AcceptsReturn = true;
		((TextBoxBase)_txtPEL_14).BackColor = SystemColors.Menu;
		((Control)_txtPEL_14).Cursor = Cursors.IBeam;
		((Control)_txtPEL_14).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtPEL_14).ForeColor = SystemColors.WindowText;
		TextBox txtPEL_15 = _txtPEL_14;
		location = new Point(176, 240);
		((Control)txtPEL_15).Location = location;
		((TextBoxBase)_txtPEL_14).MaxLength = 0;
		((Control)_txtPEL_14).Name = "_txtPEL_14";
		((TextBoxBase)_txtPEL_14).ReadOnly = true;
		((Control)_txtPEL_14).RightToLeft = (RightToLeft)0;
		TextBox txtPEL_16 = _txtPEL_14;
		size = new Size(65, 20);
		((Control)txtPEL_16).Size = size;
		((Control)_txtPEL_14).TabIndex = 34;
		((Control)_txtPEL_14).TabStop = false;
		_txtPEL_8.AcceptsReturn = true;
		((TextBoxBase)_txtPEL_8).BackColor = SystemColors.Menu;
		((Control)_txtPEL_8).Cursor = Cursors.IBeam;
		((Control)_txtPEL_8).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtPEL_8).ForeColor = SystemColors.WindowText;
		TextBox txtPEL_17 = _txtPEL_8;
		location = new Point(176, 96);
		((Control)txtPEL_17).Location = location;
		((TextBoxBase)_txtPEL_8).MaxLength = 0;
		((Control)_txtPEL_8).Name = "_txtPEL_8";
		((TextBoxBase)_txtPEL_8).ReadOnly = true;
		((Control)_txtPEL_8).RightToLeft = (RightToLeft)0;
		TextBox txtPEL_18 = _txtPEL_8;
		size = new Size(65, 20);
		((Control)txtPEL_18).Size = size;
		((Control)_txtPEL_8).TabIndex = 28;
		((Control)_txtPEL_8).TabStop = false;
		_txtPEL_9.AcceptsReturn = true;
		((TextBoxBase)_txtPEL_9).BackColor = SystemColors.Menu;
		((Control)_txtPEL_9).Cursor = Cursors.IBeam;
		((Control)_txtPEL_9).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtPEL_9).ForeColor = SystemColors.WindowText;
		TextBox txtPEL_19 = _txtPEL_9;
		location = new Point(176, 120);
		((Control)txtPEL_19).Location = location;
		((TextBoxBase)_txtPEL_9).MaxLength = 0;
		((Control)_txtPEL_9).Name = "_txtPEL_9";
		((TextBoxBase)_txtPEL_9).ReadOnly = true;
		((Control)_txtPEL_9).RightToLeft = (RightToLeft)0;
		TextBox txtPEL_20 = _txtPEL_9;
		size = new Size(65, 20);
		((Control)txtPEL_20).Size = size;
		((Control)_txtPEL_9).TabIndex = 29;
		((Control)_txtPEL_9).TabStop = false;
		_txtPEL_10.AcceptsReturn = true;
		((TextBoxBase)_txtPEL_10).BackColor = SystemColors.Menu;
		((Control)_txtPEL_10).Cursor = Cursors.IBeam;
		((Control)_txtPEL_10).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtPEL_10).ForeColor = SystemColors.WindowText;
		TextBox txtPEL_21 = _txtPEL_10;
		location = new Point(176, 144);
		((Control)txtPEL_21).Location = location;
		((TextBoxBase)_txtPEL_10).MaxLength = 0;
		((Control)_txtPEL_10).Name = "_txtPEL_10";
		((TextBoxBase)_txtPEL_10).ReadOnly = true;
		((Control)_txtPEL_10).RightToLeft = (RightToLeft)0;
		TextBox txtPEL_22 = _txtPEL_10;
		size = new Size(65, 20);
		((Control)txtPEL_22).Size = size;
		((Control)_txtPEL_10).TabIndex = 30;
		((Control)_txtPEL_10).TabStop = false;
		_txtPEL_11.AcceptsReturn = true;
		((TextBoxBase)_txtPEL_11).BackColor = SystemColors.Menu;
		((Control)_txtPEL_11).Cursor = Cursors.IBeam;
		((Control)_txtPEL_11).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtPEL_11).ForeColor = SystemColors.WindowText;
		TextBox txtPEL_23 = _txtPEL_11;
		location = new Point(176, 168);
		((Control)txtPEL_23).Location = location;
		((TextBoxBase)_txtPEL_11).MaxLength = 0;
		((Control)_txtPEL_11).Name = "_txtPEL_11";
		((TextBoxBase)_txtPEL_11).ReadOnly = true;
		((Control)_txtPEL_11).RightToLeft = (RightToLeft)0;
		TextBox txtPEL_24 = _txtPEL_11;
		size = new Size(65, 20);
		((Control)txtPEL_24).Size = size;
		((Control)_txtPEL_11).TabIndex = 31;
		((Control)_txtPEL_11).TabStop = false;
		_txtPEL_7.AcceptsReturn = true;
		((TextBoxBase)_txtPEL_7).BackColor = SystemColors.Menu;
		((Control)_txtPEL_7).Cursor = Cursors.IBeam;
		((Control)_txtPEL_7).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtPEL_7).ForeColor = SystemColors.WindowText;
		TextBox txtPEL_25 = _txtPEL_7;
		location = new Point(368, 0);
		((Control)txtPEL_25).Location = location;
		((TextBoxBase)_txtPEL_7).MaxLength = 0;
		((Control)_txtPEL_7).Name = "_txtPEL_7";
		((TextBoxBase)_txtPEL_7).ReadOnly = true;
		((Control)_txtPEL_7).RightToLeft = (RightToLeft)0;
		_txtPEL_7.ScrollBars = (ScrollBars)2;
		TextBox txtPEL_26 = _txtPEL_7;
		size = new Size(289, 20);
		((Control)txtPEL_26).Size = size;
		((Control)_txtPEL_7).TabIndex = 37;
		((Control)_txtPEL_7).TabStop = false;
		_txtPEL_6.AcceptsReturn = true;
		((TextBoxBase)_txtPEL_6).BackColor = SystemColors.Menu;
		((Control)_txtPEL_6).Cursor = Cursors.IBeam;
		((Control)_txtPEL_6).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtPEL_6).ForeColor = SystemColors.WindowText;
		TextBox txtPEL_27 = _txtPEL_6;
		location = new Point(176, 72);
		((Control)txtPEL_27).Location = location;
		((TextBoxBase)_txtPEL_6).MaxLength = 0;
		((Control)_txtPEL_6).Name = "_txtPEL_6";
		((TextBoxBase)_txtPEL_6).ReadOnly = true;
		((Control)_txtPEL_6).RightToLeft = (RightToLeft)0;
		TextBox txtPEL_28 = _txtPEL_6;
		size = new Size(65, 20);
		((Control)txtPEL_28).Size = size;
		((Control)_txtPEL_6).TabIndex = 27;
		((Control)_txtPEL_6).TabStop = false;
		_txtPEL_5.AcceptsReturn = true;
		((TextBoxBase)_txtPEL_5).BackColor = SystemColors.Menu;
		((Control)_txtPEL_5).Cursor = Cursors.IBeam;
		((Control)_txtPEL_5).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtPEL_5).ForeColor = SystemColors.WindowText;
		TextBox txtPEL_29 = _txtPEL_5;
		location = new Point(176, 48);
		((Control)txtPEL_29).Location = location;
		((TextBoxBase)_txtPEL_5).MaxLength = 0;
		((Control)_txtPEL_5).Name = "_txtPEL_5";
		((TextBoxBase)_txtPEL_5).ReadOnly = true;
		((Control)_txtPEL_5).RightToLeft = (RightToLeft)0;
		TextBox txtPEL_30 = _txtPEL_5;
		size = new Size(65, 20);
		((Control)txtPEL_30).Size = size;
		((Control)_txtPEL_5).TabIndex = 26;
		((Control)_txtPEL_5).TabStop = false;
		_txtPEL_4.AcceptsReturn = true;
		((TextBoxBase)_txtPEL_4).BackColor = SystemColors.Menu;
		((Control)_txtPEL_4).Cursor = Cursors.IBeam;
		((Control)_txtPEL_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtPEL_4).ForeColor = SystemColors.WindowText;
		TextBox txtPEL_31 = _txtPEL_4;
		location = new Point(176, 24);
		((Control)txtPEL_31).Location = location;
		((TextBoxBase)_txtPEL_4).MaxLength = 0;
		((Control)_txtPEL_4).Name = "_txtPEL_4";
		((TextBoxBase)_txtPEL_4).ReadOnly = true;
		((Control)_txtPEL_4).RightToLeft = (RightToLeft)0;
		TextBox txtPEL_32 = _txtPEL_4;
		size = new Size(65, 20);
		((Control)txtPEL_32).Size = size;
		((Control)_txtPEL_4).TabIndex = 25;
		((Control)_txtPEL_4).TabStop = false;
		_txtPEL_3.AcceptsReturn = true;
		((TextBoxBase)_txtPEL_3).BackColor = SystemColors.Menu;
		((Control)_txtPEL_3).Cursor = Cursors.IBeam;
		((Control)_txtPEL_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtPEL_3).ForeColor = SystemColors.WindowText;
		TextBox txtPEL_33 = _txtPEL_3;
		location = new Point(176, 0);
		((Control)txtPEL_33).Location = location;
		((TextBoxBase)_txtPEL_3).MaxLength = 0;
		((Control)_txtPEL_3).Name = "_txtPEL_3";
		((TextBoxBase)_txtPEL_3).ReadOnly = true;
		((Control)_txtPEL_3).RightToLeft = (RightToLeft)0;
		TextBox txtPEL_34 = _txtPEL_3;
		size = new Size(65, 20);
		((Control)txtPEL_34).Size = size;
		((Control)_txtPEL_3).TabIndex = 24;
		((Control)_txtPEL_3).TabStop = false;
		_txtPEL_16.AcceptsReturn = true;
		((TextBoxBase)_txtPEL_16).BackColor = SystemColors.Menu;
		((Control)_txtPEL_16).Cursor = Cursors.IBeam;
		((Control)_txtPEL_16).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtPEL_16).ForeColor = SystemColors.WindowText;
		TextBox txtPEL_35 = _txtPEL_16;
		location = new Point(176, 288);
		((Control)txtPEL_35).Location = location;
		((TextBoxBase)_txtPEL_16).MaxLength = 0;
		((Control)_txtPEL_16).Name = "_txtPEL_16";
		((TextBoxBase)_txtPEL_16).ReadOnly = true;
		((Control)_txtPEL_16).RightToLeft = (RightToLeft)0;
		TextBox txtPEL_36 = _txtPEL_16;
		size = new Size(65, 20);
		((Control)txtPEL_36).Size = size;
		((Control)_txtPEL_16).TabIndex = 36;
		((Control)_txtPEL_16).TabStop = false;
		((Control)Label11).BackColor = SystemColors.Control;
		((Control)Label11).Cursor = Cursors.Default;
		((Control)Label11).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label11).ForeColor = SystemColors.ControlText;
		Label label3 = Label11;
		location = new Point(272, 72);
		((Control)label3).Location = location;
		((Control)Label11).Name = "Label11";
		((Control)Label11).RightToLeft = (RightToLeft)0;
		Label label4 = Label11;
		size = new Size(89, 17);
		((Control)label4).Size = size;
		((Control)Label11).TabIndex = 82;
		Label11.Text = "PEL Comments:";
		Label11.TextAlign = (ContentAlignment)4;
		((Control)Label7).BackColor = SystemColors.Control;
		((Control)Label7).Cursor = Cursors.Default;
		((Control)Label7).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label7).ForeColor = SystemColors.ControlText;
		Label label5 = Label7;
		location = new Point(0, 264);
		((Control)label5).Location = location;
		((Control)Label7).Name = "Label7";
		((Control)Label7).RightToLeft = (RightToLeft)0;
		Label label6 = Label7;
		size = new Size(170, 17);
		((Control)label6).Size = size;
		((Control)Label7).TabIndex = 81;
		Label7.Text = "PEL CL Converted (mg/m3)?";
		((Control)Label10).BackColor = SystemColors.Control;
		((Control)Label10).Cursor = Cursors.Default;
		((Control)Label10).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label10).ForeColor = SystemColors.ControlText;
		Label label7 = Label10;
		location = new Point(0, 192);
		((Control)label7).Location = location;
		((Control)Label10).Name = "Label10";
		((Control)Label10).RightToLeft = (RightToLeft)0;
		Label label8 = Label10;
		size = new Size(170, 17);
		((Control)label8).Size = size;
		((Control)Label10).TabIndex = 80;
		Label10.Text = "PEL CL (ppm):";
		((Control)Label9).BackColor = SystemColors.Control;
		((Control)Label9).Cursor = Cursors.Default;
		((Control)Label9).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label9).ForeColor = SystemColors.ControlText;
		Label label9 = Label9;
		location = new Point(0, 216);
		((Control)label9).Location = location;
		((Control)Label9).Name = "Label9";
		((Control)Label9).RightToLeft = (RightToLeft)0;
		Label label10 = Label9;
		size = new Size(170, 17);
		((Control)label10).Size = size;
		((Control)Label9).TabIndex = 79;
		Label9.Text = "PEL CL Converted (ppm)?";
		((Control)Label8).BackColor = SystemColors.Control;
		((Control)Label8).Cursor = Cursors.Default;
		((Control)Label8).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label8).ForeColor = SystemColors.ControlText;
		Label label11 = Label8;
		location = new Point(0, 240);
		((Control)label11).Location = location;
		((Control)Label8).Name = "Label8";
		((Control)Label8).RightToLeft = (RightToLeft)0;
		Label label12 = Label8;
		size = new Size(170, 17);
		((Control)label12).Size = size;
		((Control)Label8).TabIndex = 78;
		Label8.Text = "PEL CL (mg/m3):";
		((Control)Label6).BackColor = SystemColors.Control;
		((Control)Label6).Cursor = Cursors.Default;
		((Control)Label6).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label6).ForeColor = SystemColors.ControlText;
		Label label13 = Label6;
		location = new Point(0, 96);
		((Control)label13).Location = location;
		((Control)Label6).Name = "Label6";
		((Control)Label6).RightToLeft = (RightToLeft)0;
		Label label14 = Label6;
		size = new Size(170, 17);
		((Control)label14).Size = size;
		((Control)Label6).TabIndex = 77;
		Label6.Text = "PEL STEL (ppm):";
		((Control)Label5).BackColor = SystemColors.Control;
		((Control)Label5).Cursor = Cursors.Default;
		((Control)Label5).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label5).ForeColor = SystemColors.ControlText;
		Label label15 = Label5;
		location = new Point(0, 120);
		((Control)label15).Location = location;
		((Control)Label5).Name = "Label5";
		((Control)Label5).RightToLeft = (RightToLeft)0;
		Label label16 = Label5;
		size = new Size(170, 17);
		((Control)label16).Size = size;
		((Control)Label5).TabIndex = 76;
		Label5.Text = "PEL STEL Converted (ppm)?";
		((Control)Label4).BackColor = SystemColors.Control;
		((Control)Label4).Cursor = Cursors.Default;
		((Control)Label4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label4).ForeColor = SystemColors.ControlText;
		Label label17 = Label4;
		location = new Point(0, 144);
		((Control)label17).Location = location;
		((Control)Label4).Name = "Label4";
		((Control)Label4).RightToLeft = (RightToLeft)0;
		Label label18 = Label4;
		size = new Size(170, 19);
		((Control)label18).Size = size;
		((Control)Label4).TabIndex = 75;
		Label4.Text = "PEL STEL (mg/m3):";
		((Control)Label3).BackColor = SystemColors.Control;
		((Control)Label3).Cursor = Cursors.Default;
		((Control)Label3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label3).ForeColor = SystemColors.ControlText;
		Label label19 = Label3;
		location = new Point(0, 168);
		((Control)label19).Location = location;
		((Control)Label3).Name = "Label3";
		((Control)Label3).RightToLeft = (RightToLeft)0;
		Label label20 = Label3;
		size = new Size(170, 20);
		((Control)label20).Size = size;
		((Control)Label3).TabIndex = 74;
		Label3.Text = "PEL STEL Converted (mg/m3)?";
		((Control)Label2).BackColor = SystemColors.Control;
		((Control)Label2).Cursor = Cursors.Default;
		((Control)Label2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label2).ForeColor = SystemColors.ControlText;
		Label label21 = Label2;
		location = new Point(272, 0);
		((Control)label21).Location = location;
		((Control)Label2).Name = "Label2";
		((Control)Label2).RightToLeft = (RightToLeft)0;
		Label label22 = Label2;
		size = new Size(89, 17);
		((Control)label22).Size = size;
		((Control)Label2).TabIndex = 73;
		Label2.Text = "PEL Notes:";
		Label2.TextAlign = (ContentAlignment)4;
		((Control)lblPELTWAConvmgm3).BackColor = SystemColors.Control;
		((Control)lblPELTWAConvmgm3).Cursor = Cursors.Default;
		((Control)lblPELTWAConvmgm3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblPELTWAConvmgm3).ForeColor = SystemColors.ControlText;
		Label obj21 = lblPELTWAConvmgm3;
		location = new Point(0, 72);
		((Control)obj21).Location = location;
		((Control)lblPELTWAConvmgm3).Name = "lblPELTWAConvmgm3";
		((Control)lblPELTWAConvmgm3).RightToLeft = (RightToLeft)0;
		Label obj22 = lblPELTWAConvmgm3;
		size = new Size(170, 17);
		((Control)obj22).Size = size;
		((Control)lblPELTWAConvmgm3).TabIndex = 72;
		lblPELTWAConvmgm3.Text = "PEL TWA Converted (mg/m3)?";
		((Control)lblPELTWAmgm3).BackColor = SystemColors.Control;
		((Control)lblPELTWAmgm3).Cursor = Cursors.Default;
		((Control)lblPELTWAmgm3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblPELTWAmgm3).ForeColor = SystemColors.ControlText;
		Label obj23 = lblPELTWAmgm3;
		location = new Point(0, 48);
		((Control)obj23).Location = location;
		((Control)lblPELTWAmgm3).Name = "lblPELTWAmgm3";
		((Control)lblPELTWAmgm3).RightToLeft = (RightToLeft)0;
		Label obj24 = lblPELTWAmgm3;
		size = new Size(170, 17);
		((Control)obj24).Size = size;
		((Control)lblPELTWAmgm3).TabIndex = 71;
		lblPELTWAmgm3.Text = "PEL TWA (mg/m3):";
		((Control)lblPELTWAConvppm).BackColor = SystemColors.Control;
		((Control)lblPELTWAConvppm).Cursor = Cursors.Default;
		((Control)lblPELTWAConvppm).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblPELTWAConvppm).ForeColor = SystemColors.ControlText;
		Label obj25 = lblPELTWAConvppm;
		location = new Point(0, 24);
		((Control)obj25).Location = location;
		((Control)lblPELTWAConvppm).Name = "lblPELTWAConvppm";
		((Control)lblPELTWAConvppm).RightToLeft = (RightToLeft)0;
		Label obj26 = lblPELTWAConvppm;
		size = new Size(170, 17);
		((Control)obj26).Size = size;
		((Control)lblPELTWAConvppm).TabIndex = 70;
		lblPELTWAConvppm.Text = "PEL TWA Converted (ppm)?";
		((Control)lblPELTWAppm).BackColor = SystemColors.Control;
		((Control)lblPELTWAppm).Cursor = Cursors.Default;
		((Control)lblPELTWAppm).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblPELTWAppm).ForeColor = SystemColors.ControlText;
		Label obj27 = lblPELTWAppm;
		location = new Point(0, 0);
		((Control)obj27).Location = location;
		((Control)lblPELTWAppm).Name = "lblPELTWAppm";
		((Control)lblPELTWAppm).RightToLeft = (RightToLeft)0;
		Label obj28 = lblPELTWAppm;
		size = new Size(161, 21);
		((Control)obj28).Size = size;
		((Control)lblPELTWAppm).TabIndex = 69;
		lblPELTWAppm.Text = "PEL TWA (ppm):";
		((Control)Label25).BackColor = SystemColors.Control;
		((Control)Label25).Cursor = Cursors.Default;
		((Control)Label25).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label25).ForeColor = SystemColors.ControlText;
		Label label23 = Label25;
		location = new Point(0, 288);
		((Control)label23).Location = location;
		((Control)Label25).Name = "Label25";
		((Control)Label25).RightToLeft = (RightToLeft)0;
		Label label24 = Label25;
		size = new Size(170, 20);
		((Control)label24).Size = size;
		((Control)Label25).TabIndex = 68;
		Label25.Text = "PEL mp/cfa";
		((Control)_fraPEL_1).BackColor = SystemColors.Control;
		((Control)_fraPEL_1).Controls.Add((Control)(object)Frame2);
		((Control)_fraPEL_1).Controls.Add((Control)(object)_txtPEL_18);
		((Control)_fraPEL_1).Controls.Add((Control)(object)_txtPEL_19);
		((Control)_fraPEL_1).Controls.Add((Control)(object)_txtPEL_20);
		((Control)_fraPEL_1).Controls.Add((Control)(object)_txtPEL_21);
		((Control)_fraPEL_1).Controls.Add((Control)(object)_txtPEL_31);
		((Control)_fraPEL_1).Controls.Add((Control)(object)_txtPEL_26);
		((Control)_fraPEL_1).Controls.Add((Control)(object)_txtPEL_25);
		((Control)_fraPEL_1).Controls.Add((Control)(object)_txtPEL_24);
		((Control)_fraPEL_1).Controls.Add((Control)(object)_txtPEL_23);
		((Control)_fraPEL_1).Controls.Add((Control)(object)_txtPEL_29);
		((Control)_fraPEL_1).Controls.Add((Control)(object)_txtPEL_28);
		((Control)_fraPEL_1).Controls.Add((Control)(object)_txtPEL_27);
		((Control)_fraPEL_1).Controls.Add((Control)(object)_txtPEL_30);
		((Control)_fraPEL_1).Controls.Add((Control)(object)_txtPEL_32);
		((Control)_fraPEL_1).Controls.Add((Control)(object)_txtPEL_22);
		((Control)_fraPEL_1).Controls.Add((Control)(object)Label1);
		((Control)_fraPEL_1).Controls.Add((Control)(object)Label12);
		((Control)_fraPEL_1).Controls.Add((Control)(object)Label13);
		((Control)_fraPEL_1).Controls.Add((Control)(object)Label14);
		((Control)_fraPEL_1).Controls.Add((Control)(object)Label15);
		((Control)_fraPEL_1).Controls.Add((Control)(object)Label16);
		((Control)_fraPEL_1).Controls.Add((Control)(object)Label17);
		((Control)_fraPEL_1).Controls.Add((Control)(object)Label18);
		((Control)_fraPEL_1).Controls.Add((Control)(object)Label19);
		((Control)_fraPEL_1).Controls.Add((Control)(object)Label20);
		((Control)_fraPEL_1).Controls.Add((Control)(object)Label21);
		((Control)_fraPEL_1).Controls.Add((Control)(object)Label22);
		((Control)_fraPEL_1).Controls.Add((Control)(object)Label23);
		((Control)_fraPEL_1).Controls.Add((Control)(object)Label24);
		((Control)_fraPEL_1).Controls.Add((Control)(object)Label26);
		((Control)_fraPEL_1).Cursor = Cursors.Default;
		((Control)_fraPEL_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_fraPEL_1).ForeColor = SystemColors.ControlText;
		Panel fraPEL_3 = _fraPEL_1;
		location = new Point(24, 88);
		((Control)fraPEL_3).Location = location;
		((Control)_fraPEL_1).Name = "_fraPEL_1";
		((Control)_fraPEL_1).RightToLeft = (RightToLeft)0;
		Panel fraPEL_4 = _fraPEL_1;
		size = new Size(678, 313);
		((Control)fraPEL_4).Size = size;
		((Control)_fraPEL_1).TabIndex = 40;
		((Control)Frame2).BackColor = SystemColors.Control;
		((Control)Frame2).Controls.Add((Control)(object)_lblInstructions_8);
		((Control)Frame2).Controls.Add((Control)(object)_lblInstructions_3);
		((Control)Frame2).Controls.Add((Control)(object)_lblInstructions_4);
		((Control)Frame2).Controls.Add((Control)(object)_lblInstructions_5);
		((Control)Frame2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Frame2).ForeColor = SystemColors.ControlText;
		GroupBox frame3 = Frame2;
		location = new Point(368, 176);
		((Control)frame3).Location = location;
		((Control)Frame2).Name = "Frame2";
		((Control)Frame2).RightToLeft = (RightToLeft)0;
		GroupBox frame4 = Frame2;
		size = new Size(289, 113);
		((Control)frame4).Size = size;
		((Control)Frame2).TabIndex = 41;
		Frame2.TabStop = false;
		((Control)_lblInstructions_8).BackColor = SystemColors.Control;
		((Control)_lblInstructions_8).Cursor = Cursors.Default;
		((Control)_lblInstructions_8).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblInstructions_8).ForeColor = SystemColors.ControlText;
		Label lblInstructions_9 = _lblInstructions_8;
		location = new Point(16, 72);
		((Control)lblInstructions_9).Location = location;
		((Control)_lblInstructions_8).Name = "_lblInstructions_8";
		((Control)_lblInstructions_8).RightToLeft = (RightToLeft)0;
		Label lblInstructions_10 = _lblInstructions_8;
		size = new Size(257, 33);
		((Control)lblInstructions_10).Size = size;
		((Control)_lblInstructions_8).TabIndex = 45;
		_lblInstructions_8.Text = "Read the \"List of OSHA PELs and NIOSH RELs\" topic in the Help System for more information.";
		((Control)_lblInstructions_3).BackColor = SystemColors.Control;
		((Control)_lblInstructions_3).Cursor = Cursors.Default;
		((Control)_lblInstructions_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblInstructions_3).ForeColor = SystemColors.ControlText;
		Label lblInstructions_11 = _lblInstructions_3;
		location = new Point(16, 16);
		((Control)lblInstructions_11).Location = location;
		((Control)_lblInstructions_3).Name = "_lblInstructions_3";
		((Control)_lblInstructions_3).RightToLeft = (RightToLeft)0;
		Label lblInstructions_12 = _lblInstructions_3;
		size = new Size(241, 17);
		((Control)lblInstructions_12).Size = size;
		((Control)_lblInstructions_3).TabIndex = 44;
		_lblInstructions_3.Text = "REL-TWA: NIOSH REL time-weighted average";
		((Control)_lblInstructions_4).BackColor = SystemColors.Control;
		((Control)_lblInstructions_4).Cursor = Cursors.Default;
		((Control)_lblInstructions_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblInstructions_4).ForeColor = SystemColors.ControlText;
		Label lblInstructions_13 = _lblInstructions_4;
		location = new Point(16, 32);
		((Control)lblInstructions_13).Location = location;
		((Control)_lblInstructions_4).Name = "_lblInstructions_4";
		((Control)_lblInstructions_4).RightToLeft = (RightToLeft)0;
		Label lblInstructions_14 = _lblInstructions_4;
		size = new Size(241, 17);
		((Control)lblInstructions_14).Size = size;
		((Control)_lblInstructions_4).TabIndex = 43;
		_lblInstructions_4.Text = "REL-STEL: NIOSH REL short-term exposure limit";
		((Control)_lblInstructions_5).BackColor = SystemColors.Control;
		((Control)_lblInstructions_5).Cursor = Cursors.Default;
		((Control)_lblInstructions_5).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblInstructions_5).ForeColor = SystemColors.ControlText;
		Label lblInstructions_15 = _lblInstructions_5;
		location = new Point(16, 48);
		((Control)lblInstructions_15).Location = location;
		((Control)_lblInstructions_5).Name = "_lblInstructions_5";
		((Control)_lblInstructions_5).RightToLeft = (RightToLeft)0;
		Label lblInstructions_16 = _lblInstructions_5;
		size = new Size(241, 17);
		((Control)lblInstructions_16).Size = size;
		((Control)_lblInstructions_5).TabIndex = 42;
		_lblInstructions_5.Text = "REL-CL: NIOSH REL ceiling";
		_txtPEL_18.AcceptsReturn = true;
		((TextBoxBase)_txtPEL_18).BackColor = SystemColors.Menu;
		((Control)_txtPEL_18).Cursor = Cursors.IBeam;
		((Control)_txtPEL_18).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtPEL_18).ForeColor = SystemColors.WindowText;
		TextBox txtPEL_37 = _txtPEL_18;
		location = new Point(176, 0);
		((Control)txtPEL_37).Location = location;
		((TextBoxBase)_txtPEL_18).MaxLength = 0;
		((Control)_txtPEL_18).Name = "_txtPEL_18";
		((TextBoxBase)_txtPEL_18).ReadOnly = true;
		((Control)_txtPEL_18).RightToLeft = (RightToLeft)0;
		TextBox txtPEL_38 = _txtPEL_18;
		size = new Size(65, 20);
		((Control)txtPEL_38).Size = size;
		((Control)_txtPEL_18).TabIndex = 46;
		((Control)_txtPEL_18).TabStop = false;
		_txtPEL_19.AcceptsReturn = true;
		((TextBoxBase)_txtPEL_19).BackColor = SystemColors.Menu;
		((Control)_txtPEL_19).Cursor = Cursors.IBeam;
		((Control)_txtPEL_19).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtPEL_19).ForeColor = SystemColors.WindowText;
		TextBox txtPEL_39 = _txtPEL_19;
		location = new Point(176, 24);
		((Control)txtPEL_39).Location = location;
		((TextBoxBase)_txtPEL_19).MaxLength = 0;
		((Control)_txtPEL_19).Name = "_txtPEL_19";
		((TextBoxBase)_txtPEL_19).ReadOnly = true;
		((Control)_txtPEL_19).RightToLeft = (RightToLeft)0;
		TextBox txtPEL_40 = _txtPEL_19;
		size = new Size(65, 20);
		((Control)txtPEL_40).Size = size;
		((Control)_txtPEL_19).TabIndex = 10;
		((Control)_txtPEL_19).TabStop = false;
		_txtPEL_20.AcceptsReturn = true;
		((TextBoxBase)_txtPEL_20).BackColor = SystemColors.Menu;
		((Control)_txtPEL_20).Cursor = Cursors.IBeam;
		((Control)_txtPEL_20).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtPEL_20).ForeColor = SystemColors.WindowText;
		TextBox txtPEL_41 = _txtPEL_20;
		location = new Point(176, 48);
		((Control)txtPEL_41).Location = location;
		((TextBoxBase)_txtPEL_20).MaxLength = 0;
		((Control)_txtPEL_20).Name = "_txtPEL_20";
		((TextBoxBase)_txtPEL_20).ReadOnly = true;
		((Control)_txtPEL_20).RightToLeft = (RightToLeft)0;
		TextBox txtPEL_42 = _txtPEL_20;
		size = new Size(65, 20);
		((Control)txtPEL_42).Size = size;
		((Control)_txtPEL_20).TabIndex = 11;
		((Control)_txtPEL_20).TabStop = false;
		_txtPEL_21.AcceptsReturn = true;
		((TextBoxBase)_txtPEL_21).BackColor = SystemColors.Menu;
		((Control)_txtPEL_21).Cursor = Cursors.IBeam;
		((Control)_txtPEL_21).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtPEL_21).ForeColor = SystemColors.WindowText;
		TextBox txtPEL_43 = _txtPEL_21;
		location = new Point(176, 72);
		((Control)txtPEL_43).Location = location;
		((TextBoxBase)_txtPEL_21).MaxLength = 0;
		((Control)_txtPEL_21).Name = "_txtPEL_21";
		((TextBoxBase)_txtPEL_21).ReadOnly = true;
		((Control)_txtPEL_21).RightToLeft = (RightToLeft)0;
		TextBox txtPEL_44 = _txtPEL_21;
		size = new Size(65, 20);
		((Control)txtPEL_44).Size = size;
		((Control)_txtPEL_21).TabIndex = 12;
		((Control)_txtPEL_21).TabStop = false;
		_txtPEL_31.AcceptsReturn = true;
		((TextBoxBase)_txtPEL_31).BackColor = SystemColors.Menu;
		((Control)_txtPEL_31).Cursor = Cursors.IBeam;
		((Control)_txtPEL_31).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtPEL_31).ForeColor = SystemColors.WindowText;
		TextBox txtPEL_45 = _txtPEL_31;
		location = new Point(368, 72);
		((Control)txtPEL_45).Location = location;
		((TextBoxBase)_txtPEL_31).MaxLength = 0;
		((Control)_txtPEL_31).Name = "_txtPEL_31";
		((TextBoxBase)_txtPEL_31).ReadOnly = true;
		((Control)_txtPEL_31).RightToLeft = (RightToLeft)0;
		TextBox txtPEL_46 = _txtPEL_31;
		size = new Size(73, 20);
		((Control)txtPEL_46).Size = size;
		((Control)_txtPEL_31).TabIndex = 22;
		((Control)_txtPEL_31).TabStop = false;
		_txtPEL_26.AcceptsReturn = true;
		((TextBoxBase)_txtPEL_26).BackColor = SystemColors.Menu;
		((Control)_txtPEL_26).Cursor = Cursors.IBeam;
		((Control)_txtPEL_26).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtPEL_26).ForeColor = SystemColors.WindowText;
		TextBox txtPEL_47 = _txtPEL_26;
		location = new Point(176, 168);
		((Control)txtPEL_47).Location = location;
		((TextBoxBase)_txtPEL_26).MaxLength = 0;
		((Control)_txtPEL_26).Name = "_txtPEL_26";
		((TextBoxBase)_txtPEL_26).ReadOnly = true;
		((Control)_txtPEL_26).RightToLeft = (RightToLeft)0;
		TextBox txtPEL_48 = _txtPEL_26;
		size = new Size(65, 20);
		((Control)txtPEL_48).Size = size;
		((Control)_txtPEL_26).TabIndex = 16;
		((Control)_txtPEL_26).TabStop = false;
		_txtPEL_25.AcceptsReturn = true;
		((TextBoxBase)_txtPEL_25).BackColor = SystemColors.Menu;
		((Control)_txtPEL_25).Cursor = Cursors.IBeam;
		((Control)_txtPEL_25).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtPEL_25).ForeColor = SystemColors.WindowText;
		TextBox txtPEL_49 = _txtPEL_25;
		location = new Point(176, 144);
		((Control)txtPEL_49).Location = location;
		((TextBoxBase)_txtPEL_25).MaxLength = 0;
		((Control)_txtPEL_25).Name = "_txtPEL_25";
		((TextBoxBase)_txtPEL_25).ReadOnly = true;
		((Control)_txtPEL_25).RightToLeft = (RightToLeft)0;
		TextBox txtPEL_50 = _txtPEL_25;
		size = new Size(65, 20);
		((Control)txtPEL_50).Size = size;
		((Control)_txtPEL_25).TabIndex = 15;
		((Control)_txtPEL_25).TabStop = false;
		_txtPEL_24.AcceptsReturn = true;
		((TextBoxBase)_txtPEL_24).BackColor = SystemColors.Menu;
		((Control)_txtPEL_24).Cursor = Cursors.IBeam;
		((Control)_txtPEL_24).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtPEL_24).ForeColor = SystemColors.WindowText;
		TextBox txtPEL_51 = _txtPEL_24;
		location = new Point(176, 120);
		((Control)txtPEL_51).Location = location;
		((TextBoxBase)_txtPEL_24).MaxLength = 0;
		((Control)_txtPEL_24).Name = "_txtPEL_24";
		((TextBoxBase)_txtPEL_24).ReadOnly = true;
		((Control)_txtPEL_24).RightToLeft = (RightToLeft)0;
		TextBox txtPEL_52 = _txtPEL_24;
		size = new Size(65, 20);
		((Control)txtPEL_52).Size = size;
		((Control)_txtPEL_24).TabIndex = 14;
		((Control)_txtPEL_24).TabStop = false;
		_txtPEL_23.AcceptsReturn = true;
		((TextBoxBase)_txtPEL_23).BackColor = SystemColors.Menu;
		((Control)_txtPEL_23).Cursor = Cursors.IBeam;
		((Control)_txtPEL_23).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtPEL_23).ForeColor = SystemColors.WindowText;
		TextBox txtPEL_53 = _txtPEL_23;
		location = new Point(176, 96);
		((Control)txtPEL_53).Location = location;
		((TextBoxBase)_txtPEL_23).MaxLength = 0;
		((Control)_txtPEL_23).Name = "_txtPEL_23";
		((TextBoxBase)_txtPEL_23).ReadOnly = true;
		((Control)_txtPEL_23).RightToLeft = (RightToLeft)0;
		TextBox txtPEL_54 = _txtPEL_23;
		size = new Size(65, 20);
		((Control)txtPEL_54).Size = size;
		((Control)_txtPEL_23).TabIndex = 13;
		((Control)_txtPEL_23).TabStop = false;
		_txtPEL_29.AcceptsReturn = true;
		((TextBoxBase)_txtPEL_29).BackColor = SystemColors.Menu;
		((Control)_txtPEL_29).Cursor = Cursors.IBeam;
		((Control)_txtPEL_29).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtPEL_29).ForeColor = SystemColors.WindowText;
		TextBox txtPEL_55 = _txtPEL_29;
		location = new Point(176, 240);
		((Control)txtPEL_55).Location = location;
		((TextBoxBase)_txtPEL_29).MaxLength = 0;
		((Control)_txtPEL_29).Name = "_txtPEL_29";
		((TextBoxBase)_txtPEL_29).ReadOnly = true;
		((Control)_txtPEL_29).RightToLeft = (RightToLeft)0;
		TextBox txtPEL_56 = _txtPEL_29;
		size = new Size(65, 20);
		((Control)txtPEL_56).Size = size;
		((Control)_txtPEL_29).TabIndex = 19;
		((Control)_txtPEL_29).TabStop = false;
		_txtPEL_28.AcceptsReturn = true;
		((TextBoxBase)_txtPEL_28).BackColor = SystemColors.Menu;
		((Control)_txtPEL_28).Cursor = Cursors.IBeam;
		((Control)_txtPEL_28).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtPEL_28).ForeColor = SystemColors.WindowText;
		TextBox txtPEL_57 = _txtPEL_28;
		location = new Point(176, 216);
		((Control)txtPEL_57).Location = location;
		((TextBoxBase)_txtPEL_28).MaxLength = 0;
		((Control)_txtPEL_28).Name = "_txtPEL_28";
		((TextBoxBase)_txtPEL_28).ReadOnly = true;
		((Control)_txtPEL_28).RightToLeft = (RightToLeft)0;
		TextBox txtPEL_58 = _txtPEL_28;
		size = new Size(65, 20);
		((Control)txtPEL_58).Size = size;
		((Control)_txtPEL_28).TabIndex = 18;
		((Control)_txtPEL_28).TabStop = false;
		_txtPEL_27.AcceptsReturn = true;
		((TextBoxBase)_txtPEL_27).BackColor = SystemColors.Menu;
		((Control)_txtPEL_27).Cursor = Cursors.IBeam;
		((Control)_txtPEL_27).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtPEL_27).ForeColor = SystemColors.WindowText;
		TextBox txtPEL_59 = _txtPEL_27;
		location = new Point(176, 192);
		((Control)txtPEL_59).Location = location;
		((TextBoxBase)_txtPEL_27).MaxLength = 0;
		((Control)_txtPEL_27).Name = "_txtPEL_27";
		((TextBoxBase)_txtPEL_27).ReadOnly = true;
		((Control)_txtPEL_27).RightToLeft = (RightToLeft)0;
		TextBox txtPEL_60 = _txtPEL_27;
		size = new Size(65, 20);
		((Control)txtPEL_60).Size = size;
		((Control)_txtPEL_27).TabIndex = 17;
		((Control)_txtPEL_27).TabStop = false;
		_txtPEL_30.AcceptsReturn = true;
		((TextBoxBase)_txtPEL_30).BackColor = SystemColors.Menu;
		((Control)_txtPEL_30).Cursor = Cursors.IBeam;
		((Control)_txtPEL_30).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtPEL_30).ForeColor = SystemColors.WindowText;
		TextBox txtPEL_61 = _txtPEL_30;
		location = new Point(176, 264);
		((Control)txtPEL_61).Location = location;
		((TextBoxBase)_txtPEL_30).MaxLength = 0;
		((Control)_txtPEL_30).Name = "_txtPEL_30";
		((TextBoxBase)_txtPEL_30).ReadOnly = true;
		((Control)_txtPEL_30).RightToLeft = (RightToLeft)0;
		TextBox txtPEL_62 = _txtPEL_30;
		size = new Size(65, 20);
		((Control)txtPEL_62).Size = size;
		((Control)_txtPEL_30).TabIndex = 20;
		((Control)_txtPEL_30).TabStop = false;
		_txtPEL_32.AcceptsReturn = true;
		((TextBoxBase)_txtPEL_32).BackColor = SystemColors.Menu;
		((Control)_txtPEL_32).Cursor = Cursors.IBeam;
		((Control)_txtPEL_32).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtPEL_32).ForeColor = SystemColors.WindowText;
		TextBox txtPEL_63 = _txtPEL_32;
		location = new Point(368, 104);
		((Control)txtPEL_63).Location = location;
		((TextBoxBase)_txtPEL_32).MaxLength = 0;
		_txtPEL_32.Multiline = true;
		((Control)_txtPEL_32).Name = "_txtPEL_32";
		((TextBoxBase)_txtPEL_32).ReadOnly = true;
		((Control)_txtPEL_32).RightToLeft = (RightToLeft)0;
		_txtPEL_32.ScrollBars = (ScrollBars)2;
		TextBox txtPEL_64 = _txtPEL_32;
		size = new Size(289, 59);
		((Control)txtPEL_64).Size = size;
		((Control)_txtPEL_32).TabIndex = 23;
		((Control)_txtPEL_32).TabStop = false;
		_txtPEL_22.AcceptsReturn = true;
		((TextBoxBase)_txtPEL_22).BackColor = SystemColors.Menu;
		((Control)_txtPEL_22).Cursor = Cursors.IBeam;
		((Control)_txtPEL_22).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtPEL_22).ForeColor = SystemColors.WindowText;
		TextBox txtPEL_65 = _txtPEL_22;
		location = new Point(368, 0);
		((Control)txtPEL_65).Location = location;
		((TextBoxBase)_txtPEL_22).MaxLength = 0;
		_txtPEL_22.Multiline = true;
		((Control)_txtPEL_22).Name = "_txtPEL_22";
		((TextBoxBase)_txtPEL_22).ReadOnly = true;
		((Control)_txtPEL_22).RightToLeft = (RightToLeft)0;
		_txtPEL_22.ScrollBars = (ScrollBars)2;
		TextBox txtPEL_66 = _txtPEL_22;
		size = new Size(289, 59);
		((Control)txtPEL_66).Size = size;
		((Control)_txtPEL_22).TabIndex = 21;
		((Control)_txtPEL_22).TabStop = false;
		((Control)Label1).BackColor = SystemColors.Control;
		((Control)Label1).Cursor = Cursors.Default;
		((Control)Label1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label1).ForeColor = SystemColors.ControlText;
		Label label25 = Label1;
		location = new Point(0, 0);
		((Control)label25).Location = location;
		((Control)Label1).Name = "Label1";
		((Control)Label1).RightToLeft = (RightToLeft)0;
		Label label26 = Label1;
		size = new Size(89, 17);
		((Control)label26).Size = size;
		((Control)Label1).TabIndex = 61;
		Label1.Text = "REL TWA (ppm):";
		((Control)Label12).BackColor = SystemColors.Control;
		((Control)Label12).Cursor = Cursors.Default;
		((Control)Label12).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label12).ForeColor = SystemColors.ControlText;
		Label label27 = Label12;
		location = new Point(0, 24);
		((Control)label27).Location = location;
		((Control)Label12).Name = "Label12";
		((Control)Label12).RightToLeft = (RightToLeft)0;
		Label label28 = Label12;
		size = new Size(145, 17);
		((Control)label28).Size = size;
		((Control)Label12).TabIndex = 60;
		Label12.Text = "REL TWA Converted (ppm)?";
		((Control)Label13).BackColor = SystemColors.Control;
		((Control)Label13).Cursor = Cursors.Default;
		((Control)Label13).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label13).ForeColor = SystemColors.ControlText;
		Label label29 = Label13;
		location = new Point(0, 48);
		((Control)label29).Location = location;
		((Control)Label13).Name = "Label13";
		((Control)Label13).RightToLeft = (RightToLeft)0;
		Label label30 = Label13;
		size = new Size(153, 17);
		((Control)label30).Size = size;
		((Control)Label13).TabIndex = 59;
		Label13.Text = "REL TWA (mg/m3):";
		((Control)Label14).BackColor = SystemColors.Control;
		((Control)Label14).Cursor = Cursors.Default;
		((Control)Label14).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label14).ForeColor = SystemColors.ControlText;
		Label label31 = Label14;
		location = new Point(0, 72);
		((Control)label31).Location = location;
		((Control)Label14).Name = "Label14";
		((Control)Label14).RightToLeft = (RightToLeft)0;
		Label label32 = Label14;
		size = new Size(161, 17);
		((Control)label32).Size = size;
		((Control)Label14).TabIndex = 58;
		Label14.Text = "REL TWA Converted (mg/m3)?";
		((Control)Label15).BackColor = SystemColors.Control;
		((Control)Label15).Cursor = Cursors.Default;
		((Control)Label15).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label15).ForeColor = SystemColors.ControlText;
		Label label33 = Label15;
		location = new Point(272, 72);
		((Control)label33).Location = location;
		((Control)Label15).Name = "Label15";
		((Control)Label15).RightToLeft = (RightToLeft)0;
		Label label34 = Label15;
		size = new Size(89, 17);
		((Control)label34).Size = size;
		((Control)Label15).TabIndex = 57;
		Label15.Text = "RELF/CC:";
		((Control)Label16).BackColor = SystemColors.Control;
		((Control)Label16).Cursor = Cursors.Default;
		((Control)Label16).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label16).ForeColor = SystemColors.ControlText;
		Label label35 = Label16;
		location = new Point(0, 168);
		((Control)label35).Location = location;
		((Control)Label16).Name = "Label16";
		((Control)Label16).RightToLeft = (RightToLeft)0;
		Label label36 = Label16;
		size = new Size(161, 17);
		((Control)label36).Size = size;
		((Control)Label16).TabIndex = 56;
		Label16.Text = "REL STEL Converted (mg/m3)?";
		((Control)Label17).BackColor = SystemColors.Control;
		((Control)Label17).Cursor = Cursors.Default;
		((Control)Label17).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label17).ForeColor = SystemColors.ControlText;
		Label label37 = Label17;
		location = new Point(0, 144);
		((Control)label37).Location = location;
		((Control)Label17).Name = "Label17";
		((Control)Label17).RightToLeft = (RightToLeft)0;
		Label label38 = Label17;
		size = new Size(153, 17);
		((Control)label38).Size = size;
		((Control)Label17).TabIndex = 55;
		Label17.Text = "REL STEL (mg/m3):";
		((Control)Label18).BackColor = SystemColors.Control;
		((Control)Label18).Cursor = Cursors.Default;
		((Control)Label18).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label18).ForeColor = SystemColors.ControlText;
		Label label39 = Label18;
		location = new Point(0, 120);
		((Control)label39).Location = location;
		((Control)Label18).Name = "Label18";
		((Control)Label18).RightToLeft = (RightToLeft)0;
		Label label40 = Label18;
		size = new Size(145, 17);
		((Control)label40).Size = size;
		((Control)Label18).TabIndex = 54;
		Label18.Text = "REL STEL Converted (ppm)?";
		((Control)Label19).BackColor = SystemColors.Control;
		((Control)Label19).Cursor = Cursors.Default;
		((Control)Label19).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label19).ForeColor = SystemColors.ControlText;
		Label label41 = Label19;
		location = new Point(0, 96);
		((Control)label41).Location = location;
		((Control)Label19).Name = "Label19";
		((Control)Label19).RightToLeft = (RightToLeft)0;
		Label label42 = Label19;
		size = new Size(89, 17);
		((Control)label42).Size = size;
		((Control)Label19).TabIndex = 53;
		Label19.Text = "REL STEL (ppm):";
		((Control)Label20).BackColor = SystemColors.Control;
		((Control)Label20).Cursor = Cursors.Default;
		((Control)Label20).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label20).ForeColor = SystemColors.ControlText;
		Label label43 = Label20;
		location = new Point(0, 240);
		((Control)label43).Location = location;
		((Control)Label20).Name = "Label20";
		((Control)Label20).RightToLeft = (RightToLeft)0;
		Label label44 = Label20;
		size = new Size(153, 17);
		((Control)label44).Size = size;
		((Control)Label20).TabIndex = 52;
		Label20.Text = "REL CL (mg/m3):";
		((Control)Label21).BackColor = SystemColors.Control;
		((Control)Label21).Cursor = Cursors.Default;
		((Control)Label21).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label21).ForeColor = SystemColors.ControlText;
		Label label45 = Label21;
		location = new Point(0, 216);
		((Control)label45).Location = location;
		((Control)Label21).Name = "Label21";
		((Control)Label21).RightToLeft = (RightToLeft)0;
		Label label46 = Label21;
		size = new Size(145, 17);
		((Control)label46).Size = size;
		((Control)Label21).TabIndex = 51;
		Label21.Text = "REL CL Converted (ppm)?";
		((Control)Label22).BackColor = SystemColors.Control;
		((Control)Label22).Cursor = Cursors.Default;
		((Control)Label22).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label22).ForeColor = SystemColors.ControlText;
		Label label47 = Label22;
		location = new Point(0, 192);
		((Control)label47).Location = location;
		((Control)Label22).Name = "Label22";
		((Control)Label22).RightToLeft = (RightToLeft)0;
		Label label48 = Label22;
		size = new Size(89, 17);
		((Control)label48).Size = size;
		((Control)Label22).TabIndex = 50;
		Label22.Text = "REL CL (ppm):";
		((Control)Label23).BackColor = SystemColors.Control;
		((Control)Label23).Cursor = Cursors.Default;
		((Control)Label23).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label23).ForeColor = SystemColors.ControlText;
		Label label49 = Label23;
		location = new Point(0, 264);
		((Control)label49).Location = location;
		((Control)Label23).Name = "Label23";
		((Control)Label23).RightToLeft = (RightToLeft)0;
		Label label50 = Label23;
		size = new Size(161, 17);
		((Control)label50).Size = size;
		((Control)Label23).TabIndex = 49;
		Label23.Text = "REL CL Converted (mg/m3)?";
		((Control)Label24).BackColor = SystemColors.Control;
		((Control)Label24).Cursor = Cursors.Default;
		((Control)Label24).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label24).ForeColor = SystemColors.ControlText;
		Label label51 = Label24;
		location = new Point(272, 104);
		((Control)label51).Location = location;
		((Control)Label24).Name = "Label24";
		((Control)Label24).RightToLeft = (RightToLeft)0;
		Label label52 = Label24;
		size = new Size(89, 17);
		((Control)label52).Size = size;
		((Control)Label24).TabIndex = 48;
		Label24.Text = "REL Comments:";
		((Control)Label26).BackColor = SystemColors.Control;
		((Control)Label26).Cursor = Cursors.Default;
		((Control)Label26).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label26).ForeColor = SystemColors.ControlText;
		Label label53 = Label26;
		location = new Point(272, 0);
		((Control)label53).Location = location;
		((Control)Label26).Name = "Label26";
		((Control)Label26).RightToLeft = (RightToLeft)0;
		Label label54 = Label26;
		size = new Size(89, 17);
		((Control)label54).Size = size;
		((Control)Label26).TabIndex = 47;
		Label26.Text = "REL Notes:";
		AxTabStrip obj29 = tabViewPELs;
		location = new Point(8, 56);
		((Control)obj29).Location = location;
		((Control)tabViewPELs).Name = "tabViewPELs";
		((AxHost)tabViewPELs).OcxState = (State)componentResourceManager.GetObject("tabViewPELs.OcxState");
		AxTabStrip obj30 = tabViewPELs;
		size = new Size(713, 361);
		((Control)obj30).Size = size;
		((Control)tabViewPELs).TabIndex = 86;
		((Control)fraSearch).BackColor = SystemColors.Control;
		((Control)fraSearch).Controls.Add((Control)(object)cmdCanel);
		((Control)fraSearch).Controls.Add((Control)(object)txtSearch);
		((Control)fraSearch).Controls.Add((Control)(object)_optSearch_0);
		((Control)fraSearch).Controls.Add((Control)(object)_optSearch_1);
		((Control)fraSearch).Controls.Add((Control)(object)cmdSearch);
		((Control)fraSearch).Controls.Add((Control)(object)Label28);
		((Control)fraSearch).Cursor = Cursors.Default;
		((Control)fraSearch).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)fraSearch).ForeColor = SystemColors.ControlText;
		Panel obj31 = fraSearch;
		location = new Point(8, 16);
		((Control)obj31).Location = location;
		((Control)fraSearch).Name = "fraSearch";
		((Control)fraSearch).RightToLeft = (RightToLeft)0;
		Panel obj32 = fraSearch;
		size = new Size(729, 481);
		((Control)obj32).Size = size;
		((Control)fraSearch).TabIndex = 90;
		((ButtonBase)cmdCanel).BackColor = SystemColors.Control;
		((Control)cmdCanel).Cursor = Cursors.Default;
		((Control)cmdCanel).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCanel).ForeColor = SystemColors.ControlText;
		Button obj33 = cmdCanel;
		location = new Point(144, 152);
		((Control)obj33).Location = location;
		((Control)cmdCanel).Name = "cmdCanel";
		((Control)cmdCanel).RightToLeft = (RightToLeft)0;
		Button obj34 = cmdCanel;
		size = new Size(97, 25);
		((Control)obj34).Size = size;
		((Control)cmdCanel).TabIndex = 4;
		((ButtonBase)cmdCanel).Text = "&Cancel Search";
		((ButtonBase)cmdCanel).UseVisualStyleBackColor = false;
		txtSearch.AcceptsReturn = true;
		((TextBoxBase)txtSearch).BackColor = SystemColors.Window;
		((Control)txtSearch).Cursor = Cursors.IBeam;
		((Control)txtSearch).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtSearch).ForeColor = SystemColors.WindowText;
		TextBox obj35 = txtSearch;
		location = new Point(8, 112);
		((Control)obj35).Location = location;
		((TextBoxBase)txtSearch).MaxLength = 0;
		((Control)txtSearch).Name = "txtSearch";
		((Control)txtSearch).RightToLeft = (RightToLeft)0;
		TextBox obj36 = txtSearch;
		size = new Size(417, 20);
		((Control)obj36).Size = size;
		((Control)txtSearch).TabIndex = 2;
		((ButtonBase)_optSearch_0).BackColor = SystemColors.Control;
		((Control)_optSearch_0).Cursor = Cursors.Default;
		((Control)_optSearch_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optSearch_0).ForeColor = SystemColors.ControlText;
		RadioButton optSearch_ = _optSearch_0;
		location = new Point(8, 80);
		((Control)optSearch_).Location = location;
		((Control)_optSearch_0).Name = "_optSearch_0";
		((Control)_optSearch_0).RightToLeft = (RightToLeft)0;
		RadioButton optSearch_2 = _optSearch_0;
		size = new Size(153, 25);
		((Control)optSearch_2).Size = size;
		((Control)_optSearch_0).TabIndex = 0;
		_optSearch_0.TabStop = true;
		((ButtonBase)_optSearch_0).Text = "Search on Chemical Name";
		((ButtonBase)_optSearch_0).UseVisualStyleBackColor = false;
		((ButtonBase)_optSearch_1).BackColor = SystemColors.Control;
		((Control)_optSearch_1).Cursor = Cursors.Default;
		((Control)_optSearch_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optSearch_1).ForeColor = SystemColors.ControlText;
		RadioButton optSearch_3 = _optSearch_1;
		location = new Point(176, 80);
		((Control)optSearch_3).Location = location;
		((Control)_optSearch_1).Name = "_optSearch_1";
		((Control)_optSearch_1).RightToLeft = (RightToLeft)0;
		RadioButton optSearch_4 = _optSearch_1;
		size = new Size(153, 25);
		((Control)optSearch_4).Size = size;
		((Control)_optSearch_1).TabIndex = 1;
		_optSearch_1.TabStop = true;
		((ButtonBase)_optSearch_1).Text = "Search on CAS Number";
		((ButtonBase)_optSearch_1).UseVisualStyleBackColor = false;
		((ButtonBase)cmdSearch).BackColor = SystemColors.Control;
		((Control)cmdSearch).Cursor = Cursors.Default;
		((Control)cmdSearch).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdSearch).ForeColor = SystemColors.ControlText;
		Button obj37 = cmdSearch;
		location = new Point(8, 152);
		((Control)obj37).Location = location;
		((Control)cmdSearch).Name = "cmdSearch";
		((Control)cmdSearch).RightToLeft = (RightToLeft)0;
		Button obj38 = cmdSearch;
		size = new Size(97, 25);
		((Control)obj38).Size = size;
		((Control)cmdSearch).TabIndex = 3;
		((ButtonBase)cmdSearch).Text = "&Search";
		((ButtonBase)cmdSearch).UseVisualStyleBackColor = false;
		((Control)Label28).BackColor = SystemColors.Control;
		((Control)Label28).Cursor = Cursors.Default;
		((Control)Label28).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label28).ForeColor = SystemColors.ControlText;
		Label label55 = Label28;
		location = new Point(8, 24);
		((Control)label55).Location = location;
		((Control)Label28).Name = "Label28";
		((Control)Label28).RightToLeft = (RightToLeft)0;
		Label label56 = Label28;
		size = new Size(713, 49);
		((Control)label56).Size = size;
		((Control)Label28).TabIndex = 91;
		Label28.Text = componentResourceManager.GetString("Label28.Text");
		((Form)this).AcceptButton = (IButtonControl)(object)cmdSearch;
		size = new Size(5, 13);
		((Form)this).AutoScaleBaseSize = size;
		((Form)this).BackColor = SystemColors.Control;
		size = new Size(746, 511);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)fraView);
		((Control)this).Controls.Add((Control)(object)fraSearch);
		((Control)this).Cursor = Cursors.Default;
		((Control)this).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		location = new Point(250, 125);
		((Form)this).Location = location;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmViewPels";
		((Control)this).RightToLeft = (RightToLeft)0;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "View OSHA PELs and NIOSH RELs";
		((Control)fraView).ResumeLayout(false);
		((Control)fraView).PerformLayout();
		((Control)_fraPEL_0).ResumeLayout(false);
		((Control)_fraPEL_0).PerformLayout();
		((Control)Frame3).ResumeLayout(false);
		((Control)_fraPEL_1).ResumeLayout(false);
		((Control)_fraPEL_1).PerformLayout();
		((Control)Frame2).ResumeLayout(false);
		((ISupportInitialize)tabViewPELs).EndInit();
		((Control)fraSearch).ResumeLayout(false);
		((Control)fraSearch).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void ClearArray()
	{
		checked
		{
			short num = (short)Information.UBound((Array)arPELREL, 1);
			short num2 = 0;
			while (true)
			{
				short num3 = num2;
				short num4 = num;
				if (num3 > num4)
				{
					break;
				}
				short num5 = (short)Information.UBound((Array)arPELREL, 2);
				short num6 = 0;
				while (true)
				{
					short num7 = num6;
					num4 = num5;
					if (num7 > num4)
					{
						break;
					}
					arPELREL[num2, num6] = "";
					num6 = (short)unchecked(num6 + 1);
				}
				num2 = (short)unchecked(num2 + 1);
			}
		}
	}

	private void GetRecordset(ref string tmpWhere)
	{
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		string source = "SELECT * FROM pel_rel_twa" + tmpWhere + " ORDER BY NumericCas, ChemicalName";
		recordset.CursorLocation = CursorLocationEnum.adUseClient;
		recordset.Open(source, Common.MyConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
		checked
		{
			if (recordset.RecordCount > 0)
			{
				recordset.MoveLast();
				recordset.MoveFirst();
				arPELREL = new object[recordset.RecordCount + 1, recordset.Fields.Count + 1];
				while (!recordset.EOF)
				{
					short num = (short)(recordset.Fields.Count - 1);
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
							if (recordset.Fields[num2].Type == DataTypeEnum.adBoolean)
							{
								bool pBool = Conversions.ToBoolean(recordset.Fields[num2].Value);
								arPELREL[(int)checked(recordset.AbsolutePosition - 1), num2] = Common.Cvt2YesNo(pBool);
							}
							else if (Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(recordset.Fields[num2].Value)))
							{
								double num5 = Conversions.ToDouble(recordset.Fields[num2].Value);
								arPELREL[(int)checked(recordset.AbsolutePosition - 1), num2] = ChemStrX.ShowInSciNot(num5);
							}
							else
							{
								arPELREL[(int)checked(recordset.AbsolutePosition - 1), num2] = RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields[num2].Value)), (object)"", RuntimeHelpers.GetObjectValue(recordset.Fields[num2].Value)));
							}
						}
						num2 = (short)unchecked(num2 + 1);
					}
					recordset.MoveNext();
				}
				recordset.Close();
				short tmpID = 0;
				LoadChem(ref tmpID);
				Tabs tabs = tabViewPELs.Tabs;
				object obj = 1;
				((ITab)((ITabs)tabs)[ref obj]).Selected = true;
			}
			else
			{
				ClearArray();
				short tmpID = 0;
				LoadChem(ref tmpID);
				((Control)cmdPrev).Enabled = false;
				((Control)cmdNext).Enabled = false;
				((Control)cmdFirst).Enabled = false;
				((Control)cmdLast).Enabled = false;
				lblMatches.Text = "No chemicals found.";
			}
			recordset = null;
		}
	}

	public bool SetUp()
	{
		((Control)fraSearch).Visible = false;
		((Control)fraView).Visible = true;
		string tmpWhere = "";
		GetRecordset(ref tmpWhere);
		return true;
	}

	private void LoadChem(ref short tmpID)
	{
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			short num = (short)(Information.UBound((Array)arPELREL, 2) - 1);
			short num2 = 1;
			while (true)
			{
				short num3 = num2;
				short num4 = num;
				if (num3 > num4)
				{
					break;
				}
				if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(arPELREL[tmpID, num2])))
				{
					if (num2 <= 3)
					{
						foreach (Control control in ((Control)fraView).Controls)
						{
							Control val = control;
							if (Operators.CompareString(val.Name, "_txtPEL_" + Conversions.ToString(num2 - 1), false) == 0)
							{
								((TextBox)val).Text = Conversions.ToString(arPELREL[tmpID, num2]);
							}
						}
					}
					else if (num2 <= 18)
					{
						foreach (Control control2 in ((Control)fraView).Controls["_fraPEL_0"].Controls)
						{
							Control val = control2;
							if (Operators.CompareString(val.Name, "_txtPEL_" + Conversions.ToString(num2 - 1), false) == 0)
							{
								((TextBox)val).Text = Conversions.ToString(arPELREL[tmpID, num2]);
								break;
							}
						}
					}
					else
					{
						foreach (Control control3 in ((Control)fraView).Controls["_fraPEL_1"].Controls)
						{
							Control val = control3;
							if (Operators.CompareString(val.Name, "_fraPEL_0", false) == 0 && Operators.CompareString(val.Name, "_txtPEL_" + Conversions.ToString(num2 - 1), false) == 0)
							{
								((TextBox)val).Text = Conversions.ToString(arPELREL[tmpID, num2]);
								break;
							}
						}
					}
				}
				num2 = (short)unchecked(num2 + 1);
			}
			if (Information.UBound((Array)arPELREL, 1) > 0)
			{
				((Control)cmdPrev).Enabled = true;
				((Control)cmdNext).Enabled = true;
				((Control)cmdFirst).Enabled = true;
				((Control)cmdLast).Enabled = true;
				if (tmpID == 0)
				{
					((Control)cmdPrev).Enabled = false;
				}
				if (tmpID == Information.UBound((Array)arPELREL, 1) - 1)
				{
					((Control)cmdNext).Enabled = false;
				}
			}
			else
			{
				((Control)cmdPrev).Enabled = false;
				((Control)cmdNext).Enabled = false;
				((Control)cmdFirst).Enabled = false;
				((Control)cmdLast).Enabled = false;
			}
			currChem = tmpID;
			if (Information.UBound((Array)arPELREL, 1) == 1)
			{
				lblMatches.Text = "1 chemical found";
			}
			else
			{
				lblMatches.Text = Conversions.ToString(currChem + 1) + " of " + Conversions.ToString(Information.UBound((Array)arPELREL, 1)) + " chemicals found";
			}
		}
	}

	private void cmdCanel_Click(object eventSender, EventArgs eventArgs)
	{
		((Control)fraView).Visible = true;
		((Control)fraSearch).Visible = false;
	}

	private void cmdFirst_Click(object eventSender, EventArgs eventArgs)
	{
		short tmpID = 0;
		LoadChem(ref tmpID);
	}

	private void cmdLast_Click(object eventSender, EventArgs eventArgs)
	{
		short tmpID = checked((short)(Information.UBound((Array)arPELREL, 1) - 1));
		LoadChem(ref tmpID);
	}

	private void cmdNewSearch_Click(object eventSender, EventArgs eventArgs)
	{
		((Control)fraView).Visible = false;
		((Control)fraSearch).Visible = true;
		_optSearch_0.Checked = true;
		txtSearch.Text = "";
	}

	private void cmdNext_Click(object eventSender, EventArgs eventArgs)
	{
		short tmpID = checked((short)(currChem + 1));
		LoadChem(ref tmpID);
	}

	private void cmdPrev_Click(object eventSender, EventArgs eventArgs)
	{
		short tmpID = checked((short)(currChem - 1));
		LoadChem(ref tmpID);
	}

	private void cmdSearch_Click(object eventSender, EventArgs eventArgs)
	{
		ClearArray();
		string tmpWhere;
		if (Operators.CompareString(txtSearch.Text, "", false) == 0)
		{
			tmpWhere = "";
		}
		else
		{
			string text = (_optSearch_0.Checked ? "ChemicalName" : ((Strings.InStr(txtSearch.Text, "-", (CompareMethod)0) <= 0) ? "NumericCAS" : "CASNumber"));
			tmpWhere = " WHERE instr(" + text + ",'" + Strings.UCase(txtSearch.Text) + "')>0";
		}
		GetRecordset(ref tmpWhere);
		((Control)fraSearch).Visible = false;
		((Control)fraView).Visible = true;
	}

	private void frmViewPels_Load(object eventSender, EventArgs eventArgs)
	{
		SetUp();
	}

	private void cmdOk_Click(object eventSender, EventArgs eventArgs)
	{
		((Form)this).Close();
	}

	private void tabViewPELs_ClickEvent(object eventSender, EventArgs eventArgs)
	{
		Tabs tabs = tabViewPELs.Tabs;
		object obj = 1;
		if (((ITab)((ITabs)tabs)[ref obj]).Selected)
		{
			((Control)_fraPEL_0).Visible = true;
			((Control)_fraPEL_1).Visible = false;
		}
		else
		{
			((Control)_fraPEL_1).Visible = true;
			((Control)_fraPEL_0).Visible = false;
		}
	}
}
