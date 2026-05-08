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

internal class frmMDCalcXmoProd : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("cmdCalcNS")]
	private Button _cmdCalcNS;

	[AccessedThroughProperty("cmdYctw")]
	private Button _cmdYctw;

	[AccessedThroughProperty("cmdCalcRRctw")]
	private Button _cmdCalcRRctw;

	[AccessedThroughProperty("txtHD")]
	private TextBox _txtHD;

	[AccessedThroughProperty("txtDctw")]
	private TextBox _txtDctw;

	[AccessedThroughProperty("txtRRctw")]
	private TextBox _txtRRctw;

	[AccessedThroughProperty("txtYctw")]
	private TextBox _txtYctw;

	[AccessedThroughProperty("_Label1_21")]
	private Label __Label1_21;

	[AccessedThroughProperty("_Label1_15")]
	private Label __Label1_15;

	[AccessedThroughProperty("_Label1_16")]
	private Label __Label1_16;

	[AccessedThroughProperty("_Label1_17")]
	private Label __Label1_17;

	[AccessedThroughProperty("Frame4")]
	private GroupBox _Frame4;

	[AccessedThroughProperty("txtLFe")]
	private TextBox _txtLFe;

	[AccessedThroughProperty("txtLFw")]
	private TextBox _txtLFw;

	[AccessedThroughProperty("txtLFb")]
	private TextBox _txtLFb;

	[AccessedThroughProperty("_Label1_24")]
	private Label __Label1_24;

	[AccessedThroughProperty("_Label1_23")]
	private Label __Label1_23;

	[AccessedThroughProperty("_Label1_22")]
	private Label __Label1_22;

	[AccessedThroughProperty("Frame3")]
	private GroupBox _Frame3;

	[AccessedThroughProperty("cmdCalc103")]
	private Button _cmdCalc103;

	[AccessedThroughProperty("_txtDRRchem_1")]
	private TextBox __txtDRRchem_1;

	[AccessedThroughProperty("_txtDMUchem_1")]
	private TextBox __txtDMUchem_1;

	[AccessedThroughProperty("_optMethod103_1")]
	private RadioButton __optMethod103_1;

	[AccessedThroughProperty("_Label1_25")]
	private Label __Label1_25;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("_Label1_18")]
	private Label __Label1_18;

	[AccessedThroughProperty("_Frame2_2")]
	private GroupBox __Frame2_2;

	[AccessedThroughProperty("_txtDMUchem_0")]
	private TextBox __txtDMUchem_0;

	[AccessedThroughProperty("_txtDRRchem_0")]
	private TextBox __txtDRRchem_0;

	[AccessedThroughProperty("_optMethod103_0")]
	private RadioButton __optMethod103_0;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("_Label1_20")]
	private Label __Label1_20;

	[AccessedThroughProperty("_Label1_19")]
	private Label __Label1_19;

	[AccessedThroughProperty("_j_1")]
	private GroupBox __j_1;

	[AccessedThroughProperty("lblCalcNS")]
	private Label _lblCalcNS;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("_fraGSS_3")]
	private GroupBox __fraGSS_3;

	[AccessedThroughProperty("txtUserInput")]
	private TextBox _txtUserInput;

	[AccessedThroughProperty("_optMethod102_1")]
	private RadioButton __optMethod102_1;

	[AccessedThroughProperty("_Label1_5")]
	private Label __Label1_5;

	[AccessedThroughProperty("_Frame2_1")]
	private GroupBox __Frame2_1;

	[AccessedThroughProperty("cmdCalcBmoProd102")]
	private Button _cmdCalcBmoProd102;

	[AccessedThroughProperty("_optMethod102_0")]
	private RadioButton __optMethod102_0;

	[AccessedThroughProperty("_txtDprod_2")]
	private TextBox __txtDprod_2;

	[AccessedThroughProperty("txtVbatch")]
	private TextBox _txtVbatch;

	[AccessedThroughProperty("lblBMOprod")]
	private Label _lblBMOprod;

	[AccessedThroughProperty("_Label1_13")]
	private Label __Label1_13;

	[AccessedThroughProperty("_Label1_11")]
	private Label __Label1_11;

	[AccessedThroughProperty("_Label1_10")]
	private Label __Label1_10;

	[AccessedThroughProperty("_frame1_3")]
	private GroupBox __frame1_3;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("_fraGSS_1")]
	private GroupBox __fraGSS_1;

	[AccessedThroughProperty("cmdCalc")]
	private Button _cmdCalc;

	[AccessedThroughProperty("txtVpaint")]
	private TextBox _txtVpaint;

	[AccessedThroughProperty("_txtDprod_1")]
	private TextBox __txtDprod_1;

	[AccessedThroughProperty("_optMethod_1")]
	private RadioButton __optMethod_1;

	[AccessedThroughProperty("_Label1_4")]
	private Label __Label1_4;

	[AccessedThroughProperty("_Label1_6")]
	private Label __Label1_6;

	[AccessedThroughProperty("_Label1_7")]
	private Label __Label1_7;

	[AccessedThroughProperty("_lblDmuPaint_1")]
	private Label __lblDmuPaint_1;

	[AccessedThroughProperty("_j_0")]
	private GroupBox __j_0;

	[AccessedThroughProperty("txtVcar")]
	private TextBox _txtVcar;

	[AccessedThroughProperty("_txtDprod_0")]
	private TextBox __txtDprod_0;

	[AccessedThroughProperty("txtNcar")]
	private TextBox _txtNcar;

	[AccessedThroughProperty("_optMethod_0")]
	private RadioButton __optMethod_0;

	[AccessedThroughProperty("_Label1_0")]
	private Label __Label1_0;

	[AccessedThroughProperty("_Label1_1")]
	private Label __Label1_1;

	[AccessedThroughProperty("_Label1_2")]
	private Label __Label1_2;

	[AccessedThroughProperty("_Label1_3")]
	private Label __Label1_3;

	[AccessedThroughProperty("_lblDmuPaint_0")]
	private Label __lblDmuPaint_0;

	[AccessedThroughProperty("_jj_1")]
	private GroupBox __jj_1;

	[AccessedThroughProperty("lblInstructions")]
	private Label _lblInstructions;

	[AccessedThroughProperty("_fraGSS_0")]
	private GroupBox __fraGSS_0;

	[AccessedThroughProperty("txtDVIppaint")]
	private TextBox _txtDVIppaint;

	[AccessedThroughProperty("txtDppaint")]
	private TextBox _txtDppaint;

	[AccessedThroughProperty("_optMethod101_0")]
	private RadioButton __optMethod101_0;

	[AccessedThroughProperty("cmdCalc101")]
	private Button _cmdCalc101;

	[AccessedThroughProperty("_Label1_14")]
	private Label __Label1_14;

	[AccessedThroughProperty("_Label1_12")]
	private Label __Label1_12;

	[AccessedThroughProperty("_Label1_9")]
	private Label __Label1_9;

	[AccessedThroughProperty("lblDMIppaint")]
	private Label _lblDMIppaint;

	[AccessedThroughProperty("_j_2")]
	private GroupBox __j_2;

	[AccessedThroughProperty("_optMethod101_1")]
	private RadioButton __optMethod101_1;

	[AccessedThroughProperty("txtUserInput101")]
	private TextBox _txtUserInput101;

	[AccessedThroughProperty("_Label1_8")]
	private Label __Label1_8;

	[AccessedThroughProperty("_Frame2_0")]
	private GroupBox __Frame2_0;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("_fraGSS_2")]
	private GroupBox __fraGSS_2;

	[AccessedThroughProperty("cmdOk")]
	private Button _cmdOk;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("cmdRestore")]
	private Button _cmdRestore;

	[AccessedThroughProperty("Frame2")]
	private GroupBoxArray _Frame2;

	[AccessedThroughProperty("Label1")]
	private LabelArray _Label1;

	[AccessedThroughProperty("Label9")]
	private LabelArray _Label9;

	[AccessedThroughProperty("chkFix")]
	private CheckBoxArray _chkFix;

	[AccessedThroughProperty("fraGSS")]
	private GroupBoxArray _fraGSS;

	[AccessedThroughProperty("frame1")]
	private GroupBoxArray _frame1;

	[AccessedThroughProperty("j")]
	private GroupBoxArray _j;

	[AccessedThroughProperty("jj")]
	private GroupBoxArray _jj;

	[AccessedThroughProperty("lblDmuPaint")]
	private LabelArray _lblDmuPaint;

	[AccessedThroughProperty("optMethod")]
	private RadioButtonArray _optMethod;

	[AccessedThroughProperty("optMethod101")]
	private RadioButtonArray _optMethod101;

	[AccessedThroughProperty("optMethod102")]
	private RadioButtonArray _optMethod102;

	[AccessedThroughProperty("optMethod103")]
	private RadioButtonArray _optMethod103;

	[AccessedThroughProperty("txtDMUchem")]
	private TextBoxArray _txtDMUchem;

	[AccessedThroughProperty("txtDRRchem")]
	private TextBoxArray _txtDRRchem;

	[AccessedThroughProperty("_fraGSS_4")]
	private GroupBox __fraGSS_4;

	[AccessedThroughProperty("cmdCalc104")]
	private Button _cmdCalc104;

	[AccessedThroughProperty("_txt104_10")]
	private TextBox __txt104_10;

	[AccessedThroughProperty("_txt104_9")]
	private TextBox __txt104_9;

	[AccessedThroughProperty("_txt104_8")]
	private TextBox __txt104_8;

	[AccessedThroughProperty("_txt104_7")]
	private TextBox __txt104_7;

	[AccessedThroughProperty("_txt104_6")]
	private TextBox __txt104_6;

	[AccessedThroughProperty("_txt104_5")]
	private TextBox __txt104_5;

	[AccessedThroughProperty("_txt104_4")]
	private TextBox __txt104_4;

	[AccessedThroughProperty("_txt104_3")]
	private TextBox __txt104_3;

	[AccessedThroughProperty("_txt104_2")]
	private TextBox __txt104_2;

	[AccessedThroughProperty("_txt104_1")]
	private TextBox __txt104_1;

	[AccessedThroughProperty("_txt104_0")]
	private TextBox __txt104_0;

	[AccessedThroughProperty("_chkFix_8")]
	private CheckBox __chkFix_8;

	[AccessedThroughProperty("_chkFix_6")]
	private CheckBox __chkFix_6;

	[AccessedThroughProperty("_chkFix_0")]
	private CheckBox __chkFix_0;

	[AccessedThroughProperty("_Label9_0")]
	private Label __Label9_0;

	[AccessedThroughProperty("lblWarning")]
	private Label _lblWarning;

	[AccessedThroughProperty("_Label9_10")]
	private Label __Label9_10;

	[AccessedThroughProperty("_Label9_9")]
	private Label __Label9_9;

	[AccessedThroughProperty("_Label9_7")]
	private Label __Label9_7;

	[AccessedThroughProperty("_Label9_5")]
	private Label __Label9_5;

	[AccessedThroughProperty("_Label9_4")]
	private Label __Label9_4;

	[AccessedThroughProperty("_Label9_3")]
	private Label __Label9_3;

	[AccessedThroughProperty("_Label9_2")]
	private Label __Label9_2;

	[AccessedThroughProperty("_Label9_1")]
	private Label __Label9_1;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("lblInst")]
	private Label _lblInst;

	[AccessedThroughProperty("_Label9_6")]
	private Label __Label9_6;

	[AccessedThroughProperty("_Label9_8")]
	private Label __Label9_8;

	[AccessedThroughProperty("txtDprod")]
	private TextBoxArray _txtDprod;

	private static frmMDCalcXmoProd m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	private short iMyGSS;

	public short iSelected;

	public short iReCalcNS;

	private string sWarning;

	public float sCalcNS;

	public float sSaveNS;

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

	public virtual Button cmdYctw
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdYctw;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdYctw_Click;
			if (_cmdYctw != null)
			{
				((Control)_cmdYctw).Click -= eventHandler;
			}
			_cmdYctw = value;
			if (_cmdYctw != null)
			{
				((Control)_cmdYctw).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdCalcRRctw
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdCalcRRctw;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdCalcRRctw_Click;
			if (_cmdCalcRRctw != null)
			{
				((Control)_cmdCalcRRctw).Click -= eventHandler;
			}
			_cmdCalcRRctw = value;
			if (_cmdCalcRRctw != null)
			{
				((Control)_cmdCalcRRctw).Click += eventHandler;
			}
		}
	}

	public virtual TextBox txtHD
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtHD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtHD_Leave;
			EventHandler eventHandler2 = txtHD_TextChanged;
			if (_txtHD != null)
			{
				((Control)_txtHD).Leave -= eventHandler;
				((Control)_txtHD).TextChanged -= eventHandler2;
			}
			_txtHD = value;
			if (_txtHD != null)
			{
				((Control)_txtHD).Leave += eventHandler;
				((Control)_txtHD).TextChanged += eventHandler2;
			}
		}
	}

	public virtual TextBox txtDctw
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDctw;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtDctw_Leave;
			EventHandler eventHandler2 = txtDctw_TextChanged;
			if (_txtDctw != null)
			{
				((Control)_txtDctw).Leave -= eventHandler;
				((Control)_txtDctw).TextChanged -= eventHandler2;
			}
			_txtDctw = value;
			if (_txtDctw != null)
			{
				((Control)_txtDctw).Leave += eventHandler;
				((Control)_txtDctw).TextChanged += eventHandler2;
			}
		}
	}

	public virtual TextBox txtRRctw
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtRRctw;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtRRctw_TextChanged;
			if (_txtRRctw != null)
			{
				((Control)_txtRRctw).TextChanged -= eventHandler;
			}
			_txtRRctw = value;
			if (_txtRRctw != null)
			{
				((Control)_txtRRctw).TextChanged += eventHandler;
			}
		}
	}

	public virtual TextBox txtYctw
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtYctw;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtYctw_TextChanged;
			if (_txtYctw != null)
			{
				((Control)_txtYctw).TextChanged -= eventHandler;
			}
			_txtYctw = value;
			if (_txtYctw != null)
			{
				((Control)_txtYctw).TextChanged += eventHandler;
			}
		}
	}

	public virtual Label _Label1_21
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_21 = value;
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

	public virtual GroupBox Frame4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Frame4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Frame4 = value;
		}
	}

	public virtual TextBox txtLFe
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtLFe;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtLFe_Leave;
			EventHandler eventHandler2 = txtLFe_TextChanged;
			if (_txtLFe != null)
			{
				((Control)_txtLFe).Leave -= eventHandler;
				((Control)_txtLFe).TextChanged -= eventHandler2;
			}
			_txtLFe = value;
			if (_txtLFe != null)
			{
				((Control)_txtLFe).Leave += eventHandler;
				((Control)_txtLFe).TextChanged += eventHandler2;
			}
		}
	}

	public virtual TextBox txtLFw
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtLFw;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtLFw_Leave;
			EventHandler eventHandler2 = txtLFw_TextChanged;
			if (_txtLFw != null)
			{
				((Control)_txtLFw).Leave -= eventHandler;
				((Control)_txtLFw).TextChanged -= eventHandler2;
			}
			_txtLFw = value;
			if (_txtLFw != null)
			{
				((Control)_txtLFw).Leave += eventHandler;
				((Control)_txtLFw).TextChanged += eventHandler2;
			}
		}
	}

	public virtual TextBox txtLFb
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtLFb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtLFb_Leave;
			EventHandler eventHandler2 = txtLFb_TextChanged;
			if (_txtLFb != null)
			{
				((Control)_txtLFb).Leave -= eventHandler;
				((Control)_txtLFb).TextChanged -= eventHandler2;
			}
			_txtLFb = value;
			if (_txtLFb != null)
			{
				((Control)_txtLFb).Leave += eventHandler;
				((Control)_txtLFb).TextChanged += eventHandler2;
			}
		}
	}

	public virtual Label _Label1_24
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_24 = value;
		}
	}

	public virtual Label _Label1_23
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_23 = value;
		}
	}

	public virtual Label _Label1_22
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_22 = value;
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

	public virtual Button cmdCalc103
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdCalc103;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdCalc103_Click;
			if (_cmdCalc103 != null)
			{
				((Control)_cmdCalc103).Click -= eventHandler;
			}
			_cmdCalc103 = value;
			if (_cmdCalc103 != null)
			{
				((Control)_cmdCalc103).Click += eventHandler;
			}
		}
	}

	public virtual TextBox _txtDRRchem_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtDRRchem_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtDRRchem_1 = value;
		}
	}

	public virtual TextBox _txtDMUchem_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtDMUchem_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtDMUchem_1 = value;
		}
	}

	public virtual RadioButton _optMethod103_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __optMethod103_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__optMethod103_1 = value;
		}
	}

	public virtual Label _Label1_25
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_25;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_25 = value;
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

	public virtual GroupBox _Frame2_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __Frame2_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Frame2_2 = value;
		}
	}

	public virtual TextBox _txtDMUchem_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtDMUchem_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtDMUchem_0 = value;
		}
	}

	public virtual TextBox _txtDRRchem_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtDRRchem_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtDRRchem_0 = value;
		}
	}

	public virtual RadioButton _optMethod103_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __optMethod103_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__optMethod103_0 = value;
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

	public virtual Label _Label1_19
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_19 = value;
		}
	}

	public virtual GroupBox _j_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __j_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__j_1 = value;
		}
	}

	public virtual Label lblCalcNS
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblCalcNS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblCalcNS = value;
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

	public virtual GroupBox _fraGSS_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraGSS_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraGSS_3 = value;
		}
	}

	public virtual TextBox txtUserInput
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtUserInput;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtUserInput_TextChanged;
			if (_txtUserInput != null)
			{
				((Control)_txtUserInput).TextChanged -= eventHandler;
			}
			_txtUserInput = value;
			if (_txtUserInput != null)
			{
				((Control)_txtUserInput).TextChanged += eventHandler;
			}
		}
	}

	public virtual RadioButton _optMethod102_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __optMethod102_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__optMethod102_1 = value;
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

	public virtual GroupBox _Frame2_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __Frame2_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Frame2_1 = value;
		}
	}

	public virtual Button cmdCalcBmoProd102
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdCalcBmoProd102;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdCalcBmoProd102_Click;
			if (_cmdCalcBmoProd102 != null)
			{
				((Control)_cmdCalcBmoProd102).Click -= eventHandler;
			}
			_cmdCalcBmoProd102 = value;
			if (_cmdCalcBmoProd102 != null)
			{
				((Control)_cmdCalcBmoProd102).Click += eventHandler;
			}
		}
	}

	public virtual RadioButton _optMethod102_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __optMethod102_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__optMethod102_0 = value;
		}
	}

	public virtual TextBox _txtDprod_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtDprod_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtDprod_2 = value;
		}
	}

	public virtual TextBox txtVbatch
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtVbatch;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtVbatch_TextChanged;
			if (_txtVbatch != null)
			{
				((Control)_txtVbatch).TextChanged -= eventHandler;
			}
			_txtVbatch = value;
			if (_txtVbatch != null)
			{
				((Control)_txtVbatch).TextChanged += eventHandler;
			}
		}
	}

	public virtual Label lblBMOprod
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblBMOprod;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblBMOprod = value;
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

	public virtual GroupBox _frame1_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __frame1_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__frame1_3 = value;
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

	public virtual GroupBox _fraGSS_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraGSS_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraGSS_1 = value;
		}
	}

	public virtual Button cmdCalc
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdCalc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdCalc_Click;
			if (_cmdCalc != null)
			{
				((Control)_cmdCalc).Click -= eventHandler;
			}
			_cmdCalc = value;
			if (_cmdCalc != null)
			{
				((Control)_cmdCalc).Click += eventHandler;
			}
		}
	}

	public virtual TextBox txtVpaint
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtVpaint;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtVpaint_TextChanged;
			if (_txtVpaint != null)
			{
				((Control)_txtVpaint).TextChanged -= eventHandler;
			}
			_txtVpaint = value;
			if (_txtVpaint != null)
			{
				((Control)_txtVpaint).TextChanged += eventHandler;
			}
		}
	}

	public virtual TextBox _txtDprod_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtDprod_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtDprod_1 = value;
		}
	}

	public virtual RadioButton _optMethod_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __optMethod_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__optMethod_1 = value;
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

	public virtual Label _lblDmuPaint_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblDmuPaint_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblDmuPaint_1 = value;
		}
	}

	public virtual GroupBox _j_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __j_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__j_0 = value;
		}
	}

	public virtual TextBox txtVcar
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtVcar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtVcar_TextChanged;
			if (_txtVcar != null)
			{
				((Control)_txtVcar).TextChanged -= eventHandler;
			}
			_txtVcar = value;
			if (_txtVcar != null)
			{
				((Control)_txtVcar).TextChanged += eventHandler;
			}
		}
	}

	public virtual TextBox _txtDprod_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtDprod_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtDprod_0 = value;
		}
	}

	public virtual TextBox txtNcar
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNcar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtNcar_TextChanged;
			if (_txtNcar != null)
			{
				((Control)_txtNcar).TextChanged -= eventHandler;
			}
			_txtNcar = value;
			if (_txtNcar != null)
			{
				((Control)_txtNcar).TextChanged += eventHandler;
			}
		}
	}

	public virtual RadioButton _optMethod_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __optMethod_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__optMethod_0 = value;
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

	public virtual Label _lblDmuPaint_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblDmuPaint_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblDmuPaint_0 = value;
		}
	}

	public virtual GroupBox _jj_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __jj_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__jj_1 = value;
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

	public virtual GroupBox _fraGSS_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraGSS_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraGSS_0 = value;
		}
	}

	public virtual TextBox txtDVIppaint
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDVIppaint;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDVIppaint = value;
		}
	}

	public virtual TextBox txtDppaint
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDppaint;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDppaint = value;
		}
	}

	public virtual RadioButton _optMethod101_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __optMethod101_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__optMethod101_0 = value;
		}
	}

	public virtual Button cmdCalc101
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdCalc101;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdCalc101_Click;
			if (_cmdCalc101 != null)
			{
				((Control)_cmdCalc101).Click -= eventHandler;
			}
			_cmdCalc101 = value;
			if (_cmdCalc101 != null)
			{
				((Control)_cmdCalc101).Click += eventHandler;
			}
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

	public virtual Label lblDMIppaint
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDMIppaint;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDMIppaint = value;
		}
	}

	public virtual GroupBox _j_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __j_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__j_2 = value;
		}
	}

	public virtual RadioButton _optMethod101_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __optMethod101_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__optMethod101_1 = value;
		}
	}

	public virtual TextBox txtUserInput101
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtUserInput101;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtUserInput101_TextChanged;
			if (_txtUserInput101 != null)
			{
				((Control)_txtUserInput101).TextChanged -= eventHandler;
			}
			_txtUserInput101 = value;
			if (_txtUserInput101 != null)
			{
				((Control)_txtUserInput101).TextChanged += eventHandler;
			}
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

	public virtual GroupBox _Frame2_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __Frame2_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Frame2_0 = value;
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

	public virtual GroupBox _fraGSS_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraGSS_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraGSS_2 = value;
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

	public virtual GroupBoxArray Frame2
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

	public virtual LabelArray Label9
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

	public virtual CheckBoxArray chkFix
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkFix;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = chkFix_CheckStateChanged;
			if (_chkFix != null)
			{
				_chkFix.CheckStateChanged -= eventHandler;
			}
			_chkFix = value;
			if (_chkFix != null)
			{
				_chkFix.CheckStateChanged += eventHandler;
			}
		}
	}

	public virtual GroupBoxArray fraGSS
	{
		[DebuggerNonUserCode]
		get
		{
			return _fraGSS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_fraGSS = value;
		}
	}

	public virtual GroupBoxArray frame1
	{
		[DebuggerNonUserCode]
		get
		{
			return _frame1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_frame1 = value;
		}
	}

	public virtual GroupBoxArray j
	{
		[DebuggerNonUserCode]
		get
		{
			return _j;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_j = value;
		}
	}

	public virtual GroupBoxArray jj
	{
		[DebuggerNonUserCode]
		get
		{
			return _jj;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_jj = value;
		}
	}

	public virtual LabelArray lblDmuPaint
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDmuPaint;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDmuPaint = value;
		}
	}

	public virtual RadioButtonArray optMethod
	{
		[DebuggerNonUserCode]
		get
		{
			return _optMethod;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = optMethod_CheckedChanged;
			if (_optMethod != null)
			{
				_optMethod.CheckedChanged -= eventHandler;
			}
			_optMethod = value;
			if (_optMethod != null)
			{
				_optMethod.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual RadioButtonArray optMethod101
	{
		[DebuggerNonUserCode]
		get
		{
			return _optMethod101;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = optMethod101_CheckedChanged;
			if (_optMethod101 != null)
			{
				_optMethod101.CheckedChanged -= eventHandler;
			}
			_optMethod101 = value;
			if (_optMethod101 != null)
			{
				_optMethod101.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual RadioButtonArray optMethod102
	{
		[DebuggerNonUserCode]
		get
		{
			return _optMethod102;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = optMethod102_CheckedChanged;
			if (_optMethod102 != null)
			{
				_optMethod102.CheckedChanged -= eventHandler;
			}
			_optMethod102 = value;
			if (_optMethod102 != null)
			{
				_optMethod102.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual RadioButtonArray optMethod103
	{
		[DebuggerNonUserCode]
		get
		{
			return _optMethod103;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = optMethod103_CheckedChanged;
			if (_optMethod103 != null)
			{
				_optMethod103.CheckedChanged -= eventHandler;
			}
			_optMethod103 = value;
			if (_optMethod103 != null)
			{
				_optMethod103.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual TextBoxArray txtDMUchem
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDMUchem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDMUchem = value;
		}
	}

	public virtual TextBoxArray txtDRRchem
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDRRchem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDRRchem = value;
		}
	}

	public virtual GroupBox _fraGSS_4
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraGSS_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraGSS_4 = value;
		}
	}

	public virtual Button cmdCalc104
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdCalc104;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdCalc104_Click;
			if (_cmdCalc104 != null)
			{
				((Control)_cmdCalc104).Click -= eventHandler;
			}
			_cmdCalc104 = value;
			if (_cmdCalc104 != null)
			{
				((Control)_cmdCalc104).Click += eventHandler;
			}
		}
	}

	public virtual TextBox _txt104_10
	{
		[DebuggerNonUserCode]
		get
		{
			return __txt104_10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _txt104_10_TextChanged;
			if (__txt104_10 != null)
			{
				((Control)__txt104_10).TextChanged -= eventHandler;
			}
			__txt104_10 = value;
			if (__txt104_10 != null)
			{
				((Control)__txt104_10).TextChanged += eventHandler;
			}
		}
	}

	public virtual TextBox _txt104_9
	{
		[DebuggerNonUserCode]
		get
		{
			return __txt104_9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _txt104_9_TextChanged;
			if (__txt104_9 != null)
			{
				((Control)__txt104_9).TextChanged -= eventHandler;
			}
			__txt104_9 = value;
			if (__txt104_9 != null)
			{
				((Control)__txt104_9).TextChanged += eventHandler;
			}
		}
	}

	public virtual TextBox _txt104_8
	{
		[DebuggerNonUserCode]
		get
		{
			return __txt104_8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _txt104_8_TextChanged;
			if (__txt104_8 != null)
			{
				((Control)__txt104_8).TextChanged -= eventHandler;
			}
			__txt104_8 = value;
			if (__txt104_8 != null)
			{
				((Control)__txt104_8).TextChanged += eventHandler;
			}
		}
	}

	public virtual TextBox _txt104_7
	{
		[DebuggerNonUserCode]
		get
		{
			return __txt104_7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _txt104_7_TextChanged;
			if (__txt104_7 != null)
			{
				((Control)__txt104_7).TextChanged -= eventHandler;
			}
			__txt104_7 = value;
			if (__txt104_7 != null)
			{
				((Control)__txt104_7).TextChanged += eventHandler;
			}
		}
	}

	public virtual TextBox _txt104_6
	{
		[DebuggerNonUserCode]
		get
		{
			return __txt104_6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _txt104_6_TextChanged;
			if (__txt104_6 != null)
			{
				((Control)__txt104_6).TextChanged -= eventHandler;
			}
			__txt104_6 = value;
			if (__txt104_6 != null)
			{
				((Control)__txt104_6).TextChanged += eventHandler;
			}
		}
	}

	public virtual TextBox _txt104_5
	{
		[DebuggerNonUserCode]
		get
		{
			return __txt104_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _txt104_5_TextChanged;
			if (__txt104_5 != null)
			{
				((Control)__txt104_5).TextChanged -= eventHandler;
			}
			__txt104_5 = value;
			if (__txt104_5 != null)
			{
				((Control)__txt104_5).TextChanged += eventHandler;
			}
		}
	}

	public virtual TextBox _txt104_4
	{
		[DebuggerNonUserCode]
		get
		{
			return __txt104_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _txt104_4_TextChanged;
			EventHandler eventHandler2 = _txt104_4_Leave;
			if (__txt104_4 != null)
			{
				((Control)__txt104_4).TextChanged -= eventHandler;
				((Control)__txt104_4).Leave -= eventHandler2;
			}
			__txt104_4 = value;
			if (__txt104_4 != null)
			{
				((Control)__txt104_4).TextChanged += eventHandler;
				((Control)__txt104_4).Leave += eventHandler2;
			}
		}
	}

	public virtual TextBox _txt104_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __txt104_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _txt104_3_TextChanged;
			if (__txt104_3 != null)
			{
				((Control)__txt104_3).TextChanged -= eventHandler;
			}
			__txt104_3 = value;
			if (__txt104_3 != null)
			{
				((Control)__txt104_3).TextChanged += eventHandler;
			}
		}
	}

	public virtual TextBox _txt104_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __txt104_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _txt104_2_TextChanged;
			if (__txt104_2 != null)
			{
				((Control)__txt104_2).TextChanged -= eventHandler;
			}
			__txt104_2 = value;
			if (__txt104_2 != null)
			{
				((Control)__txt104_2).TextChanged += eventHandler;
			}
		}
	}

	public virtual TextBox _txt104_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __txt104_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _txt104_1_TextChanged;
			if (__txt104_1 != null)
			{
				((Control)__txt104_1).TextChanged -= eventHandler;
			}
			__txt104_1 = value;
			if (__txt104_1 != null)
			{
				((Control)__txt104_1).TextChanged += eventHandler;
			}
		}
	}

	public virtual TextBox _txt104_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __txt104_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _txt104_0_TextChanged;
			if (__txt104_0 != null)
			{
				((Control)__txt104_0).TextChanged -= eventHandler;
			}
			__txt104_0 = value;
			if (__txt104_0 != null)
			{
				((Control)__txt104_0).TextChanged += eventHandler;
			}
		}
	}

	public virtual CheckBox _chkFix_8
	{
		[DebuggerNonUserCode]
		get
		{
			return __chkFix_8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _chkFix_8_CheckStateChanged;
			if (__chkFix_8 != null)
			{
				__chkFix_8.CheckStateChanged -= eventHandler;
			}
			__chkFix_8 = value;
			if (__chkFix_8 != null)
			{
				__chkFix_8.CheckStateChanged += eventHandler;
			}
		}
	}

	public virtual CheckBox _chkFix_6
	{
		[DebuggerNonUserCode]
		get
		{
			return __chkFix_6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _chkFix_6_CheckStateChanged;
			if (__chkFix_6 != null)
			{
				__chkFix_6.CheckStateChanged -= eventHandler;
			}
			__chkFix_6 = value;
			if (__chkFix_6 != null)
			{
				__chkFix_6.CheckStateChanged += eventHandler;
			}
		}
	}

	public virtual CheckBox _chkFix_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __chkFix_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _chkFix_0_CheckStateChanged;
			if (__chkFix_0 != null)
			{
				__chkFix_0.CheckStateChanged -= eventHandler;
			}
			__chkFix_0 = value;
			if (__chkFix_0 != null)
			{
				__chkFix_0.CheckStateChanged += eventHandler;
			}
		}
	}

	public virtual Label _Label9_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label9_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label9_0 = value;
		}
	}

	public virtual Label lblWarning
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblWarning;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblWarning = value;
		}
	}

	public virtual Label _Label9_10
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label9_10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label9_10 = value;
		}
	}

	public virtual Label _Label9_9
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label9_9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label9_9 = value;
		}
	}

	public virtual Label _Label9_7
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label9_7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label9_7 = value;
		}
	}

	public virtual Label _Label9_5
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label9_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label9_5 = value;
		}
	}

	public virtual Label _Label9_4
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label9_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label9_4 = value;
		}
	}

	public virtual Label _Label9_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label9_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label9_3 = value;
		}
	}

	public virtual Label _Label9_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label9_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label9_2 = value;
		}
	}

	public virtual Label _Label9_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label9_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label9_1 = value;
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

	public virtual Label lblInst
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblInst;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblInst = value;
		}
	}

	public virtual Label _Label9_6
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label9_6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label9_6 = value;
		}
	}

	public virtual Label _Label9_8
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label9_8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label9_8 = value;
		}
	}

	public virtual TextBoxArray txtDprod
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDprod;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtDprod_TextChanged;
			if (_txtDprod != null)
			{
				_txtDprod.TextChanged -= eventHandler;
			}
			_txtDprod = value;
			if (_txtDprod != null)
			{
				_txtDprod.TextChanged += eventHandler;
			}
		}
	}

	public static frmMDCalcXmoProd DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmMDCalcXmoProd();
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

	public frmMDCalcXmoProd()
	{
		((Form)this).Load += frmMDCalcXmoProd_Load;
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
		//IL_059e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a8: Expected O, but got Unknown
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b4: Expected O, but got Unknown
		//IL_05b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c0: Expected O, but got Unknown
		//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cc: Expected O, but got Unknown
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d8: Expected O, but got Unknown
		//IL_05da: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e4: Expected O, but got Unknown
		//IL_05e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f0: Expected O, but got Unknown
		//IL_05f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fc: Expected O, but got Unknown
		//IL_05fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0608: Expected O, but got Unknown
		//IL_060a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0614: Expected O, but got Unknown
		//IL_0616: Unknown result type (might be due to invalid IL or missing references)
		//IL_0620: Expected O, but got Unknown
		//IL_0622: Unknown result type (might be due to invalid IL or missing references)
		//IL_062c: Expected O, but got Unknown
		//IL_062e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0638: Expected O, but got Unknown
		//IL_063a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0644: Expected O, but got Unknown
		//IL_0646: Unknown result type (might be due to invalid IL or missing references)
		//IL_0650: Expected O, but got Unknown
		//IL_0652: Unknown result type (might be due to invalid IL or missing references)
		//IL_065c: Expected O, but got Unknown
		//IL_065e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0668: Expected O, but got Unknown
		//IL_066a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0674: Expected O, but got Unknown
		//IL_0676: Unknown result type (might be due to invalid IL or missing references)
		//IL_0680: Expected O, but got Unknown
		//IL_0682: Unknown result type (might be due to invalid IL or missing references)
		//IL_068c: Expected O, but got Unknown
		//IL_068e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0698: Expected O, but got Unknown
		//IL_069a: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a4: Expected O, but got Unknown
		//IL_06a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b0: Expected O, but got Unknown
		//IL_06b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bc: Expected O, but got Unknown
		//IL_06be: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c8: Expected O, but got Unknown
		//IL_06ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d4: Expected O, but got Unknown
		//IL_06d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e0: Expected O, but got Unknown
		//IL_06e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ec: Expected O, but got Unknown
		//IL_06ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f8: Expected O, but got Unknown
		//IL_06fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0704: Expected O, but got Unknown
		//IL_095c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0966: Expected O, but got Unknown
		//IL_0a3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a47: Expected O, but got Unknown
		//IL_0be9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf3: Expected O, but got Unknown
		//IL_0cb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc3: Expected O, but got Unknown
		//IL_0d8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d94: Expected O, but got Unknown
		//IL_0e77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e81: Expected O, but got Unknown
		//IL_0f60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f6a: Expected O, but got Unknown
		//IL_1049: Unknown result type (might be due to invalid IL or missing references)
		//IL_1053: Expected O, but got Unknown
		//IL_1132: Unknown result type (might be due to invalid IL or missing references)
		//IL_113c: Expected O, but got Unknown
		//IL_11ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1209: Expected O, but got Unknown
		//IL_12e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ed: Expected O, but got Unknown
		//IL_13c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d2: Expected O, but got Unknown
		//IL_14ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b6: Expected O, but got Unknown
		//IL_160a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1614: Expected O, but got Unknown
		//IL_16ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f4: Expected O, but got Unknown
		//IL_17b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_17c1: Expected O, but got Unknown
		//IL_1884: Unknown result type (might be due to invalid IL or missing references)
		//IL_188e: Expected O, but got Unknown
		//IL_1944: Unknown result type (might be due to invalid IL or missing references)
		//IL_194e: Expected O, but got Unknown
		//IL_1a28: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a32: Expected O, but got Unknown
		//IL_1b0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b17: Expected O, but got Unknown
		//IL_1bf2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bfc: Expected O, but got Unknown
		//IL_1d42: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d4c: Expected O, but got Unknown
		//IL_1e39: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e43: Expected O, but got Unknown
		//IL_1f26: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f30: Expected O, but got Unknown
		//IL_2006: Unknown result type (might be due to invalid IL or missing references)
		//IL_2010: Expected O, but got Unknown
		//IL_20e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_20ed: Expected O, but got Unknown
		//IL_21c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_21d2: Expected O, but got Unknown
		//IL_2298: Unknown result type (might be due to invalid IL or missing references)
		//IL_22a2: Expected O, but got Unknown
		//IL_240d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2417: Expected O, but got Unknown
		//IL_2501: Unknown result type (might be due to invalid IL or missing references)
		//IL_250b: Expected O, but got Unknown
		//IL_25ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_25f8: Expected O, but got Unknown
		//IL_26ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_26d8: Expected O, but got Unknown
		//IL_27ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_27b5: Expected O, but got Unknown
		//IL_287b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2885: Expected O, but got Unknown
		//IL_294b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2955: Expected O, but got Unknown
		//IL_2a30: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a3a: Expected O, but got Unknown
		//IL_2b15: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b1f: Expected O, but got Unknown
		//IL_2bdc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2be6: Expected O, but got Unknown
		//IL_2cd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cde: Expected O, but got Unknown
		//IL_2dea: Unknown result type (might be due to invalid IL or missing references)
		//IL_2df4: Expected O, but got Unknown
		//IL_2ede: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ee8: Expected O, but got Unknown
		//IL_2faa: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fb4: Expected O, but got Unknown
		//IL_3086: Unknown result type (might be due to invalid IL or missing references)
		//IL_3090: Expected O, but got Unknown
		//IL_3211: Unknown result type (might be due to invalid IL or missing references)
		//IL_321b: Expected O, but got Unknown
		//IL_32f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_3302: Expected O, but got Unknown
		//IL_33c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_33d2: Expected O, but got Unknown
		//IL_34c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_34ca: Expected O, but got Unknown
		//IL_35bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_35c5: Expected O, but got Unknown
		//IL_3694: Unknown result type (might be due to invalid IL or missing references)
		//IL_369e: Expected O, but got Unknown
		//IL_3753: Unknown result type (might be due to invalid IL or missing references)
		//IL_375d: Expected O, but got Unknown
		//IL_3838: Unknown result type (might be due to invalid IL or missing references)
		//IL_3842: Expected O, but got Unknown
		//IL_391d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3927: Expected O, but got Unknown
		//IL_3a02: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a0c: Expected O, but got Unknown
		//IL_3b11: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b1b: Expected O, but got Unknown
		//IL_3bf2: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bfc: Expected O, but got Unknown
		//IL_3d59: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d63: Expected O, but got Unknown
		//IL_3e5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e66: Expected O, but got Unknown
		//IL_3f45: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f4f: Expected O, but got Unknown
		//IL_4025: Unknown result type (might be due to invalid IL or missing references)
		//IL_402f: Expected O, but got Unknown
		//IL_4102: Unknown result type (might be due to invalid IL or missing references)
		//IL_410c: Expected O, but got Unknown
		//IL_41e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_41f0: Expected O, but got Unknown
		//IL_42cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_42d7: Expected O, but got Unknown
		//IL_43c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_43cb: Expected O, but got Unknown
		//IL_4552: Unknown result type (might be due to invalid IL or missing references)
		//IL_455c: Expected O, but got Unknown
		//IL_4654: Unknown result type (might be due to invalid IL or missing references)
		//IL_465e: Expected O, but got Unknown
		//IL_473d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4747: Expected O, but got Unknown
		//IL_4839: Unknown result type (might be due to invalid IL or missing references)
		//IL_4843: Expected O, but got Unknown
		//IL_4906: Unknown result type (might be due to invalid IL or missing references)
		//IL_4910: Expected O, but got Unknown
		//IL_49e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_49ed: Expected O, but got Unknown
		//IL_4ac7: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ad1: Expected O, but got Unknown
		//IL_4bae: Unknown result type (might be due to invalid IL or missing references)
		//IL_4bb8: Expected O, but got Unknown
		//IL_4c95: Unknown result type (might be due to invalid IL or missing references)
		//IL_4c9f: Expected O, but got Unknown
		//IL_4d86: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d90: Expected O, but got Unknown
		//IL_4e59: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e63: Expected O, but got Unknown
		//IL_4f51: Unknown result type (might be due to invalid IL or missing references)
		//IL_4f5b: Expected O, but got Unknown
		//IL_50da: Unknown result type (might be due to invalid IL or missing references)
		//IL_50e4: Expected O, but got Unknown
		//IL_51dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_51e7: Expected O, but got Unknown
		//IL_52c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_52d0: Expected O, but got Unknown
		//IL_5393: Unknown result type (might be due to invalid IL or missing references)
		//IL_539d: Expected O, but got Unknown
		//IL_5470: Unknown result type (might be due to invalid IL or missing references)
		//IL_547a: Expected O, but got Unknown
		//IL_5541: Unknown result type (might be due to invalid IL or missing references)
		//IL_554b: Expected O, but got Unknown
		//IL_5626: Unknown result type (might be due to invalid IL or missing references)
		//IL_5630: Expected O, but got Unknown
		//IL_570b: Unknown result type (might be due to invalid IL or missing references)
		//IL_5715: Expected O, but got Unknown
		//IL_57fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_5807: Expected O, but got Unknown
		//IL_58f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_58fb: Expected O, but got Unknown
		//IL_59d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_59e2: Expected O, but got Unknown
		//IL_5ac2: Unknown result type (might be due to invalid IL or missing references)
		//IL_5acc: Expected O, but got Unknown
		//IL_5b8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_5b99: Expected O, but got Unknown
		//IL_5c73: Unknown result type (might be due to invalid IL or missing references)
		//IL_5c7d: Expected O, but got Unknown
		//IL_5d37: Unknown result type (might be due to invalid IL or missing references)
		//IL_5d41: Expected O, but got Unknown
		//IL_5e18: Unknown result type (might be due to invalid IL or missing references)
		//IL_5e22: Expected O, but got Unknown
		//IL_5eec: Unknown result type (might be due to invalid IL or missing references)
		//IL_5ef6: Expected O, but got Unknown
		//IL_5fc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_5fca: Expected O, but got Unknown
		//IL_6094: Unknown result type (might be due to invalid IL or missing references)
		//IL_609e: Expected O, but got Unknown
		//IL_6168: Unknown result type (might be due to invalid IL or missing references)
		//IL_6172: Expected O, but got Unknown
		//IL_6231: Unknown result type (might be due to invalid IL or missing references)
		//IL_623b: Expected O, but got Unknown
		//IL_62f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_62fe: Expected O, but got Unknown
		//IL_63bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_63c5: Expected O, but got Unknown
		//IL_6482: Unknown result type (might be due to invalid IL or missing references)
		//IL_648c: Expected O, but got Unknown
		//IL_6549: Unknown result type (might be due to invalid IL or missing references)
		//IL_6553: Expected O, but got Unknown
		//IL_6610: Unknown result type (might be due to invalid IL or missing references)
		//IL_661a: Expected O, but got Unknown
		//IL_66d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_66e1: Expected O, but got Unknown
		//IL_679e: Unknown result type (might be due to invalid IL or missing references)
		//IL_67a8: Expected O, but got Unknown
		//IL_6865: Unknown result type (might be due to invalid IL or missing references)
		//IL_686f: Expected O, but got Unknown
		//IL_692c: Unknown result type (might be due to invalid IL or missing references)
		//IL_6936: Expected O, but got Unknown
		//IL_69ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_6a09: Expected O, but got Unknown
		//IL_6ade: Unknown result type (might be due to invalid IL or missing references)
		//IL_6ae8: Expected O, but got Unknown
		//IL_6bbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_6bc7: Expected O, but got Unknown
		//IL_6c9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_6ca9: Expected O, but got Unknown
		//IL_6d8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_6d99: Expected O, but got Unknown
		//IL_6e69: Unknown result type (might be due to invalid IL or missing references)
		//IL_6e73: Expected O, but got Unknown
		//IL_6f39: Unknown result type (might be due to invalid IL or missing references)
		//IL_6f43: Expected O, but got Unknown
		//IL_7009: Unknown result type (might be due to invalid IL or missing references)
		//IL_7013: Expected O, but got Unknown
		//IL_70d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_70e3: Expected O, but got Unknown
		//IL_71b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_71c2: Expected O, but got Unknown
		//IL_72a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_72ae: Expected O, but got Unknown
		//IL_7381: Unknown result type (might be due to invalid IL or missing references)
		//IL_738b: Expected O, but got Unknown
		//IL_7460: Unknown result type (might be due to invalid IL or missing references)
		//IL_746a: Expected O, but got Unknown
		//IL_753d: Unknown result type (might be due to invalid IL or missing references)
		//IL_7547: Expected O, but got Unknown
		//IL_761c: Unknown result type (might be due to invalid IL or missing references)
		//IL_7626: Expected O, but got Unknown
		//IL_76ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_76f6: Expected O, but got Unknown
		//IL_7a4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_7a54: Expected O, but got Unknown
		//IL_7be2: Unknown result type (might be due to invalid IL or missing references)
		//IL_7bec: Expected O, but got Unknown
		//IL_7c01: Unknown result type (might be due to invalid IL or missing references)
		//IL_7c0b: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMDCalcXmoProd));
		ToolTip1 = new ToolTip(components);
		_fraGSS_3 = new GroupBox();
		cmdCalcNS = new Button();
		Frame4 = new GroupBox();
		cmdYctw = new Button();
		cmdCalcRRctw = new Button();
		txtHD = new TextBox();
		txtDctw = new TextBox();
		txtRRctw = new TextBox();
		txtYctw = new TextBox();
		_Label1_21 = new Label();
		_Label1_15 = new Label();
		_Label1_16 = new Label();
		_Label1_17 = new Label();
		Frame3 = new GroupBox();
		txtLFe = new TextBox();
		txtLFw = new TextBox();
		txtLFb = new TextBox();
		_Label1_24 = new Label();
		_Label1_23 = new Label();
		_Label1_22 = new Label();
		cmdCalc103 = new Button();
		_Frame2_2 = new GroupBox();
		_txtDRRchem_1 = new TextBox();
		_txtDMUchem_1 = new TextBox();
		_optMethod103_1 = new RadioButton();
		_Label1_25 = new Label();
		Label7 = new Label();
		_Label1_18 = new Label();
		_j_1 = new GroupBox();
		_txtDMUchem_0 = new TextBox();
		_txtDRRchem_0 = new TextBox();
		_optMethod103_0 = new RadioButton();
		Label6 = new Label();
		Label3 = new Label();
		_Label1_20 = new Label();
		_Label1_19 = new Label();
		lblCalcNS = new Label();
		Label5 = new Label();
		_fraGSS_1 = new GroupBox();
		_Frame2_1 = new GroupBox();
		txtUserInput = new TextBox();
		_optMethod102_1 = new RadioButton();
		_Label1_5 = new Label();
		_frame1_3 = new GroupBox();
		cmdCalcBmoProd102 = new Button();
		_optMethod102_0 = new RadioButton();
		_txtDprod_2 = new TextBox();
		txtVbatch = new TextBox();
		lblBMOprod = new Label();
		_Label1_13 = new Label();
		_Label1_11 = new Label();
		_Label1_10 = new Label();
		Label2 = new Label();
		_fraGSS_0 = new GroupBox();
		cmdCalc = new Button();
		_j_0 = new GroupBox();
		txtVpaint = new TextBox();
		_txtDprod_1 = new TextBox();
		_optMethod_1 = new RadioButton();
		_Label1_4 = new Label();
		_Label1_6 = new Label();
		_Label1_7 = new Label();
		_lblDmuPaint_1 = new Label();
		_jj_1 = new GroupBox();
		txtVcar = new TextBox();
		_txtDprod_0 = new TextBox();
		txtNcar = new TextBox();
		_optMethod_0 = new RadioButton();
		_Label1_0 = new Label();
		_Label1_1 = new Label();
		_Label1_2 = new Label();
		_Label1_3 = new Label();
		_lblDmuPaint_0 = new Label();
		lblInstructions = new Label();
		_fraGSS_2 = new GroupBox();
		_j_2 = new GroupBox();
		txtDVIppaint = new TextBox();
		txtDppaint = new TextBox();
		_optMethod101_0 = new RadioButton();
		cmdCalc101 = new Button();
		_Label1_14 = new Label();
		_Label1_12 = new Label();
		_Label1_9 = new Label();
		lblDMIppaint = new Label();
		_Frame2_0 = new GroupBox();
		_optMethod101_1 = new RadioButton();
		txtUserInput101 = new TextBox();
		_Label1_8 = new Label();
		Label4 = new Label();
		cmdOk = new Button();
		cmdCancel = new Button();
		cmdRestore = new Button();
		Frame2 = new GroupBoxArray(components);
		Label1 = new LabelArray(components);
		Label9 = new LabelArray(components);
		chkFix = new CheckBoxArray(components);
		fraGSS = new GroupBoxArray(components);
		frame1 = new GroupBoxArray(components);
		j = new GroupBoxArray(components);
		jj = new GroupBoxArray(components);
		lblDmuPaint = new LabelArray(components);
		optMethod = new RadioButtonArray(components);
		optMethod101 = new RadioButtonArray(components);
		optMethod102 = new RadioButtonArray(components);
		optMethod103 = new RadioButtonArray(components);
		txtDMUchem = new TextBoxArray(components);
		txtDRRchem = new TextBoxArray(components);
		txtDprod = new TextBoxArray(components);
		_Label9_8 = new Label();
		_Label9_6 = new Label();
		lblInst = new Label();
		Label8 = new Label();
		_Label9_1 = new Label();
		_Label9_2 = new Label();
		_Label9_3 = new Label();
		_Label9_4 = new Label();
		_Label9_5 = new Label();
		_Label9_7 = new Label();
		_Label9_9 = new Label();
		_Label9_10 = new Label();
		lblWarning = new Label();
		_Label9_0 = new Label();
		_chkFix_0 = new CheckBox();
		_chkFix_6 = new CheckBox();
		_chkFix_8 = new CheckBox();
		_txt104_0 = new TextBox();
		_txt104_1 = new TextBox();
		_txt104_2 = new TextBox();
		_txt104_3 = new TextBox();
		_txt104_4 = new TextBox();
		_txt104_5 = new TextBox();
		_txt104_6 = new TextBox();
		_txt104_7 = new TextBox();
		_txt104_8 = new TextBox();
		_txt104_9 = new TextBox();
		_txt104_10 = new TextBox();
		cmdCalc104 = new Button();
		_fraGSS_4 = new GroupBox();
		((Control)_fraGSS_3).SuspendLayout();
		((Control)Frame4).SuspendLayout();
		((Control)Frame3).SuspendLayout();
		((Control)_Frame2_2).SuspendLayout();
		((Control)_j_1).SuspendLayout();
		((Control)_fraGSS_1).SuspendLayout();
		((Control)_Frame2_1).SuspendLayout();
		((Control)_frame1_3).SuspendLayout();
		((Control)_fraGSS_0).SuspendLayout();
		((Control)_j_0).SuspendLayout();
		((Control)_jj_1).SuspendLayout();
		((Control)_fraGSS_2).SuspendLayout();
		((Control)_j_2).SuspendLayout();
		((Control)_Frame2_0).SuspendLayout();
		((ISupportInitialize)Frame2).BeginInit();
		((ISupportInitialize)Label1).BeginInit();
		((ISupportInitialize)Label9).BeginInit();
		((ISupportInitialize)chkFix).BeginInit();
		((ISupportInitialize)fraGSS).BeginInit();
		((ISupportInitialize)frame1).BeginInit();
		((ISupportInitialize)j).BeginInit();
		((ISupportInitialize)jj).BeginInit();
		((ISupportInitialize)lblDmuPaint).BeginInit();
		((ISupportInitialize)optMethod).BeginInit();
		((ISupportInitialize)optMethod101).BeginInit();
		((ISupportInitialize)optMethod102).BeginInit();
		((ISupportInitialize)optMethod103).BeginInit();
		((ISupportInitialize)txtDMUchem).BeginInit();
		((ISupportInitialize)txtDRRchem).BeginInit();
		((ISupportInitialize)txtDprod).BeginInit();
		((Control)_fraGSS_4).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)_fraGSS_3).BackColor = SystemColors.Control;
		((Control)_fraGSS_3).Controls.Add((Control)(object)cmdCalcNS);
		((Control)_fraGSS_3).Controls.Add((Control)(object)Frame4);
		((Control)_fraGSS_3).Controls.Add((Control)(object)Frame3);
		((Control)_fraGSS_3).Controls.Add((Control)(object)cmdCalc103);
		((Control)_fraGSS_3).Controls.Add((Control)(object)_Frame2_2);
		((Control)_fraGSS_3).Controls.Add((Control)(object)_j_1);
		((Control)_fraGSS_3).Controls.Add((Control)(object)lblCalcNS);
		((Control)_fraGSS_3).Controls.Add((Control)(object)Label5);
		((Control)_fraGSS_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_fraGSS_3).ForeColor = SystemColors.ControlText;
		fraGSS.SetIndex(_fraGSS_3, (short)3);
		GroupBox fraGSS_ = _fraGSS_3;
		Point location = new Point(0, 8);
		((Control)fraGSS_).Location = location;
		((Control)_fraGSS_3).Name = "_fraGSS_3";
		((Control)_fraGSS_3).RightToLeft = (RightToLeft)0;
		GroupBox fraGSS_2 = _fraGSS_3;
		Size size = new Size(721, 393);
		((Control)fraGSS_2).Size = size;
		((Control)_fraGSS_3).TabIndex = 54;
		_fraGSS_3.TabStop = false;
		((Control)_fraGSS_3).Visible = false;
		((ButtonBase)cmdCalcNS).BackColor = SystemColors.Control;
		((Control)cmdCalcNS).Cursor = Cursors.Default;
		((Control)cmdCalcNS).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCalcNS).ForeColor = SystemColors.ControlText;
		Button obj = cmdCalcNS;
		location = new Point(488, 336);
		((Control)obj).Location = location;
		((Control)cmdCalcNS).Name = "cmdCalcNS";
		((Control)cmdCalcNS).RightToLeft = (RightToLeft)0;
		Button obj2 = cmdCalcNS;
		size = new Size(185, 25);
		((Control)obj2).Size = size;
		((Control)cmdCalcNS).TabIndex = 90;
		((ButtonBase)cmdCalcNS).Text = "&Re-calculate NS";
		((ButtonBase)cmdCalcNS).UseVisualStyleBackColor = false;
		((Control)Frame4).BackColor = SystemColors.Control;
		((Control)Frame4).Controls.Add((Control)(object)cmdYctw);
		((Control)Frame4).Controls.Add((Control)(object)cmdCalcRRctw);
		((Control)Frame4).Controls.Add((Control)(object)txtHD);
		((Control)Frame4).Controls.Add((Control)(object)txtDctw);
		((Control)Frame4).Controls.Add((Control)(object)txtRRctw);
		((Control)Frame4).Controls.Add((Control)(object)txtYctw);
		((Control)Frame4).Controls.Add((Control)(object)_Label1_21);
		((Control)Frame4).Controls.Add((Control)(object)_Label1_15);
		((Control)Frame4).Controls.Add((Control)(object)_Label1_16);
		((Control)Frame4).Controls.Add((Control)(object)_Label1_17);
		((Control)Frame4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Frame4).ForeColor = SystemColors.ControlText;
		GroupBox frame = Frame4;
		location = new Point(8, 48);
		((Control)frame).Location = location;
		((Control)Frame4).Name = "Frame4";
		((Control)Frame4).RightToLeft = (RightToLeft)0;
		GroupBox frame2 = Frame4;
		size = new Size(409, 113);
		((Control)frame2).Size = size;
		((Control)Frame4).TabIndex = 72;
		Frame4.TabStop = false;
		Frame4.Text = "Parameter Set 1";
		((ButtonBase)cmdYctw).BackColor = SystemColors.Control;
		((Control)cmdYctw).Cursor = Cursors.Default;
		((Control)cmdYctw).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdYctw).ForeColor = SystemColors.ControlText;
		Button obj3 = cmdYctw;
		location = new Point(336, 40);
		((Control)obj3).Location = location;
		((Control)cmdYctw).Name = "cmdYctw";
		((Control)cmdYctw).RightToLeft = (RightToLeft)0;
		Button obj4 = cmdYctw;
		size = new Size(57, 19);
		((Control)obj4).Size = size;
		((Control)cmdYctw).TabIndex = 82;
		((ButtonBase)cmdYctw).Text = "&Select";
		((ButtonBase)cmdYctw).UseVisualStyleBackColor = false;
		((ButtonBase)cmdCalcRRctw).BackColor = SystemColors.Control;
		((Control)cmdCalcRRctw).Cursor = Cursors.Default;
		((Control)cmdCalcRRctw).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCalcRRctw).ForeColor = SystemColors.ControlText;
		Button obj5 = cmdCalcRRctw;
		location = new Point(336, 16);
		((Control)obj5).Location = location;
		((Control)cmdCalcRRctw).Name = "cmdCalcRRctw";
		((Control)cmdCalcRRctw).RightToLeft = (RightToLeft)0;
		Button obj6 = cmdCalcRRctw;
		size = new Size(57, 19);
		((Control)obj6).Size = size;
		((Control)cmdCalcRRctw).TabIndex = 81;
		((ButtonBase)cmdCalcRRctw).Text = "&Select";
		((ButtonBase)cmdCalcRRctw).UseVisualStyleBackColor = false;
		txtHD.AcceptsReturn = true;
		((TextBoxBase)txtHD).BackColor = Color.FromArgb(192, 192, 192);
		((Control)txtHD).Cursor = Cursors.IBeam;
		((Control)txtHD).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtHD).ForeColor = SystemColors.WindowText;
		TextBox obj7 = txtHD;
		location = new Point(256, 64);
		((Control)obj7).Location = location;
		((TextBoxBase)txtHD).MaxLength = 0;
		((Control)txtHD).Name = "txtHD";
		((TextBoxBase)txtHD).ReadOnly = true;
		((Control)txtHD).RightToLeft = (RightToLeft)0;
		TextBox obj8 = txtHD;
		size = new Size(73, 20);
		((Control)obj8).Size = size;
		((Control)txtHD).TabIndex = 79;
		txtDctw.AcceptsReturn = true;
		((TextBoxBase)txtDctw).BackColor = Color.FromArgb(192, 192, 192);
		((Control)txtDctw).Cursor = Cursors.IBeam;
		((Control)txtDctw).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtDctw).ForeColor = SystemColors.WindowText;
		TextBox obj9 = txtDctw;
		location = new Point(256, 88);
		((Control)obj9).Location = location;
		((TextBoxBase)txtDctw).MaxLength = 0;
		((Control)txtDctw).Name = "txtDctw";
		((TextBoxBase)txtDctw).ReadOnly = true;
		((Control)txtDctw).RightToLeft = (RightToLeft)0;
		TextBox obj10 = txtDctw;
		size = new Size(73, 20);
		((Control)obj10).Size = size;
		((Control)txtDctw).TabIndex = 78;
		txtRRctw.AcceptsReturn = true;
		((TextBoxBase)txtRRctw).BackColor = Color.FromArgb(192, 192, 192);
		((Control)txtRRctw).Cursor = Cursors.IBeam;
		((Control)txtRRctw).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtRRctw).ForeColor = SystemColors.WindowText;
		TextBox obj11 = txtRRctw;
		location = new Point(256, 16);
		((Control)obj11).Location = location;
		((TextBoxBase)txtRRctw).MaxLength = 0;
		((Control)txtRRctw).Name = "txtRRctw";
		((TextBoxBase)txtRRctw).ReadOnly = true;
		((Control)txtRRctw).RightToLeft = (RightToLeft)0;
		TextBox obj12 = txtRRctw;
		size = new Size(73, 20);
		((Control)obj12).Size = size;
		((Control)txtRRctw).TabIndex = 74;
		txtYctw.AcceptsReturn = true;
		((TextBoxBase)txtYctw).BackColor = Color.FromArgb(192, 192, 192);
		((Control)txtYctw).Cursor = Cursors.IBeam;
		((Control)txtYctw).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtYctw).ForeColor = SystemColors.WindowText;
		TextBox obj13 = txtYctw;
		location = new Point(256, 40);
		((Control)obj13).Location = location;
		((TextBoxBase)txtYctw).MaxLength = 0;
		((Control)txtYctw).Name = "txtYctw";
		((TextBoxBase)txtYctw).ReadOnly = true;
		((Control)txtYctw).RightToLeft = (RightToLeft)0;
		TextBox obj14 = txtYctw;
		size = new Size(73, 20);
		((Control)obj14).Size = size;
		((Control)txtYctw).TabIndex = 73;
		((Control)_Label1_21).BackColor = SystemColors.Control;
		((Control)_Label1_21).Cursor = Cursors.Default;
		((Control)_Label1_21).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_21).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_21, (short)21);
		Label label1_ = _Label1_21;
		location = new Point(4, 64);
		((Control)label1_).Location = location;
		((Control)_Label1_21).Name = "_Label1_21";
		((Control)_Label1_21).RightToLeft = (RightToLeft)0;
		Label label1_2 = _Label1_21;
		size = new Size(245, 19);
		((Control)label1_2).Size = size;
		((Control)_Label1_21).TabIndex = 80;
		_Label1_21.Text = "HD, hours of cooling tower operation (hr/day)";
		_Label1_21.TextAlign = (ContentAlignment)4;
		((Control)_Label1_15).BackColor = SystemColors.Control;
		((Control)_Label1_15).Cursor = Cursors.Default;
		((Control)_Label1_15).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_15).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_15, (short)15);
		Label label1_3 = _Label1_15;
		location = new Point(11, 16);
		((Control)label1_3).Location = location;
		((Control)_Label1_15).Name = "_Label1_15";
		((Control)_Label1_15).RightToLeft = (RightToLeft)0;
		Label label1_4 = _Label1_15;
		size = new Size(238, 19);
		((Control)label1_4).Size = size;
		((Control)_Label1_15).TabIndex = 77;
		_Label1_15.Text = "RRctw, Recirculation Rate  (gal/min)";
		_Label1_15.TextAlign = (ContentAlignment)4;
		((Control)_Label1_16).BackColor = SystemColors.Control;
		((Control)_Label1_16).Cursor = Cursors.Default;
		((Control)_Label1_16).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_16).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_16, (short)16);
		Label label1_5 = _Label1_16;
		location = new Point(3, 40);
		((Control)label1_5).Location = location;
		((Control)_Label1_16).Name = "_Label1_16";
		((Control)_Label1_16).RightToLeft = (RightToLeft)0;
		Label label1_6 = _Label1_16;
		size = new Size(246, 17);
		((Control)label1_6).Size = size;
		((Control)_Label1_16).TabIndex = 76;
		_Label1_16.Text = "Yctw, Weight fraction of chemical in system";
		_Label1_16.TextAlign = (ContentAlignment)4;
		((Control)_Label1_17).BackColor = SystemColors.Control;
		((Control)_Label1_17).Cursor = Cursors.Default;
		((Control)_Label1_17).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_17).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_17, (short)17);
		Label label1_7 = _Label1_17;
		location = new Point(-2, 88);
		((Control)label1_7).Location = location;
		((Control)_Label1_17).Name = "_Label1_17";
		((Control)_Label1_17).RightToLeft = (RightToLeft)0;
		Label label1_8 = _Label1_17;
		size = new Size(251, 20);
		((Control)label1_8).Size = size;
		((Control)_Label1_17).TabIndex = 75;
		_Label1_17.Text = "Dctw, density of the recirculating water (kg/gal)";
		_Label1_17.TextAlign = (ContentAlignment)4;
		((Control)Frame3).BackColor = SystemColors.Control;
		((Control)Frame3).Controls.Add((Control)(object)txtLFe);
		((Control)Frame3).Controls.Add((Control)(object)txtLFw);
		((Control)Frame3).Controls.Add((Control)(object)txtLFb);
		((Control)Frame3).Controls.Add((Control)(object)_Label1_24);
		((Control)Frame3).Controls.Add((Control)(object)_Label1_23);
		((Control)Frame3).Controls.Add((Control)(object)_Label1_22);
		((Control)Frame3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Frame3).ForeColor = SystemColors.ControlText;
		GroupBox frame3 = Frame3;
		location = new Point(8, 176);
		((Control)frame3).Location = location;
		((Control)Frame3).Name = "Frame3";
		((Control)Frame3).RightToLeft = (RightToLeft)0;
		GroupBox frame4 = Frame3;
		size = new Size(409, 105);
		((Control)frame4).Size = size;
		((Control)Frame3).TabIndex = 65;
		Frame3.TabStop = false;
		Frame3.Text = "Parameter Set 2";
		txtLFe.AcceptsReturn = true;
		((TextBoxBase)txtLFe).BackColor = Color.White;
		((Control)txtLFe).Cursor = Cursors.IBeam;
		((Control)txtLFe).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtLFe).ForeColor = SystemColors.WindowText;
		TextBox obj15 = txtLFe;
		location = new Point(288, 62);
		((Control)obj15).Location = location;
		((TextBoxBase)txtLFe).MaxLength = 0;
		((Control)txtLFe).Name = "txtLFe";
		((Control)txtLFe).RightToLeft = (RightToLeft)0;
		TextBox obj16 = txtLFe;
		size = new Size(73, 20);
		((Control)obj16).Size = size;
		((Control)txtLFe).TabIndex = 70;
		txtLFw.AcceptsReturn = true;
		((TextBoxBase)txtLFw).BackColor = Color.White;
		((Control)txtLFw).Cursor = Cursors.IBeam;
		((Control)txtLFw).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtLFw).ForeColor = SystemColors.WindowText;
		TextBox obj17 = txtLFw;
		location = new Point(288, 38);
		((Control)obj17).Location = location;
		((TextBoxBase)txtLFw).MaxLength = 0;
		((Control)txtLFw).Name = "txtLFw";
		((Control)txtLFw).RightToLeft = (RightToLeft)0;
		TextBox obj18 = txtLFw;
		size = new Size(73, 20);
		((Control)obj18).Size = size;
		((Control)txtLFw).TabIndex = 68;
		txtLFb.AcceptsReturn = true;
		((TextBoxBase)txtLFb).BackColor = Color.White;
		((Control)txtLFb).Cursor = Cursors.IBeam;
		((Control)txtLFb).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtLFb).ForeColor = SystemColors.WindowText;
		TextBox obj19 = txtLFb;
		location = new Point(288, 14);
		((Control)obj19).Location = location;
		((TextBoxBase)txtLFb).MaxLength = 0;
		((Control)txtLFb).Name = "txtLFb";
		((Control)txtLFb).RightToLeft = (RightToLeft)0;
		TextBox obj20 = txtLFb;
		size = new Size(73, 20);
		((Control)obj20).Size = size;
		((Control)txtLFb).TabIndex = 66;
		((Control)_Label1_24).BackColor = SystemColors.Control;
		((Control)_Label1_24).Cursor = Cursors.Default;
		((Control)_Label1_24).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_24).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_24, (short)24);
		Label label1_9 = _Label1_24;
		location = new Point(8, 64);
		((Control)label1_9).Location = location;
		((Control)_Label1_24).Name = "_Label1_24";
		((Control)_Label1_24).RightToLeft = (RightToLeft)0;
		Label label1_10 = _Label1_24;
		size = new Size(274, 17);
		((Control)label1_10).Size = size;
		((Control)_Label1_24).TabIndex = 71;
		_Label1_24.Text = "LFe, loss fraction from evaporation (dimensionless)";
		_Label1_24.TextAlign = (ContentAlignment)4;
		((Control)_Label1_23).BackColor = SystemColors.Control;
		((Control)_Label1_23).Cursor = Cursors.Default;
		((Control)_Label1_23).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_23).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_23, (short)23);
		Label label1_11 = _Label1_23;
		location = new Point(16, 40);
		((Control)label1_11).Location = location;
		((Control)_Label1_23).Name = "_Label1_23";
		((Control)_Label1_23).RightToLeft = (RightToLeft)0;
		Label label1_12 = _Label1_23;
		size = new Size(266, 18);
		((Control)label1_12).Size = size;
		((Control)_Label1_23).TabIndex = 69;
		_Label1_23.Text = "LFw, loss fraction from windage (dimensionless)";
		_Label1_23.TextAlign = (ContentAlignment)4;
		((Control)_Label1_22).BackColor = SystemColors.Control;
		((Control)_Label1_22).Cursor = Cursors.Default;
		((Control)_Label1_22).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_22).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_22, (short)22);
		Label label1_13 = _Label1_22;
		location = new Point(16, 16);
		((Control)label1_13).Location = location;
		((Control)_Label1_22).Name = "_Label1_22";
		((Control)_Label1_22).RightToLeft = (RightToLeft)0;
		Label label1_14 = _Label1_22;
		size = new Size(266, 18);
		((Control)label1_14).Size = size;
		((Control)_Label1_22).TabIndex = 67;
		_Label1_22.Text = "LFb, loss fraction from blowdown (dimensionless)";
		_Label1_22.TextAlign = (ContentAlignment)4;
		((ButtonBase)cmdCalc103).BackColor = SystemColors.Control;
		((Control)cmdCalc103).Cursor = Cursors.Default;
		((Control)cmdCalc103).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCalc103).ForeColor = SystemColors.ControlText;
		Button obj21 = cmdCalc103;
		location = new Point(488, 296);
		((Control)obj21).Location = location;
		((Control)cmdCalc103).Name = "cmdCalc103";
		((Control)cmdCalc103).RightToLeft = (RightToLeft)0;
		Button obj22 = cmdCalc103;
		size = new Size(185, 25);
		((Control)obj22).Size = size;
		((Control)cmdCalc103).TabIndex = 64;
		((ButtonBase)cmdCalc103).Text = "&Calculate DRRchem && DMUchem";
		((ButtonBase)cmdCalc103).UseVisualStyleBackColor = false;
		((Control)_Frame2_2).BackColor = SystemColors.Control;
		((Control)_Frame2_2).Controls.Add((Control)(object)_txtDRRchem_1);
		((Control)_Frame2_2).Controls.Add((Control)(object)_txtDMUchem_1);
		((Control)_Frame2_2).Controls.Add((Control)(object)_optMethod103_1);
		((Control)_Frame2_2).Controls.Add((Control)(object)_Label1_25);
		((Control)_Frame2_2).Controls.Add((Control)(object)Label7);
		((Control)_Frame2_2).Controls.Add((Control)(object)_Label1_18);
		((Control)_Frame2_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Frame2_2).ForeColor = SystemColors.ControlText;
		Frame2.SetIndex(_Frame2_2, (short)2);
		GroupBox frame2_ = _Frame2_2;
		location = new Point(432, 176);
		((Control)frame2_).Location = location;
		((Control)_Frame2_2).Name = "_Frame2_2";
		((Control)_Frame2_2).RightToLeft = (RightToLeft)0;
		GroupBox frame2_2 = _Frame2_2;
		size = new Size(273, 105);
		((Control)frame2_2).Size = size;
		((Control)_Frame2_2).TabIndex = 57;
		_Frame2_2.TabStop = false;
		_Frame2_2.Text = "Calculate DRRchem, DMUchem = user input value";
		_txtDRRchem_1.AcceptsReturn = true;
		((TextBoxBase)_txtDRRchem_1).BackColor = SystemColors.Menu;
		((Control)_txtDRRchem_1).Cursor = Cursors.IBeam;
		((Control)_txtDRRchem_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtDRRchem_1).ForeColor = SystemColors.WindowText;
		txtDRRchem.SetIndex(_txtDRRchem_1, (short)1);
		TextBox txtDRRchem_ = _txtDRRchem_1;
		location = new Point(192, 48);
		((Control)txtDRRchem_).Location = location;
		((TextBoxBase)_txtDRRchem_1).MaxLength = 0;
		((Control)_txtDRRchem_1).Name = "_txtDRRchem_1";
		((TextBoxBase)_txtDRRchem_1).ReadOnly = true;
		((Control)_txtDRRchem_1).RightToLeft = (RightToLeft)0;
		TextBox txtDRRchem_2 = _txtDRRchem_1;
		size = new Size(74, 20);
		((Control)txtDRRchem_2).Size = size;
		((Control)_txtDRRchem_1).TabIndex = 86;
		_txtDMUchem_1.AcceptsReturn = true;
		((TextBoxBase)_txtDMUchem_1).BackColor = SystemColors.Menu;
		((Control)_txtDMUchem_1).Cursor = Cursors.IBeam;
		((Control)_txtDMUchem_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtDMUchem_1).ForeColor = SystemColors.WindowText;
		txtDMUchem.SetIndex(_txtDMUchem_1, (short)1);
		TextBox txtDMUchem_ = _txtDMUchem_1;
		location = new Point(192, 24);
		((Control)txtDMUchem_).Location = location;
		((TextBoxBase)_txtDMUchem_1).MaxLength = 0;
		((Control)_txtDMUchem_1).Name = "_txtDMUchem_1";
		((TextBoxBase)_txtDMUchem_1).ReadOnly = true;
		((Control)_txtDMUchem_1).RightToLeft = (RightToLeft)0;
		TextBox txtDMUchem_2 = _txtDMUchem_1;
		size = new Size(74, 20);
		((Control)txtDMUchem_2).Size = size;
		((Control)_txtDMUchem_1).TabIndex = 59;
		((ButtonBase)_optMethod103_1).BackColor = SystemColors.Control;
		((Control)_optMethod103_1).Cursor = Cursors.Default;
		((Control)_optMethod103_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optMethod103_1).ForeColor = SystemColors.ControlText;
		optMethod103.SetIndex(_optMethod103_1, (short)1);
		RadioButton optMethod103_ = _optMethod103_1;
		location = new Point(16, 24);
		((Control)optMethod103_).Location = location;
		((Control)_optMethod103_1).Name = "_optMethod103_1";
		((Control)_optMethod103_1).RightToLeft = (RightToLeft)0;
		RadioButton optMethod103_2 = _optMethod103_1;
		size = new Size(25, 17);
		((Control)optMethod103_2).Size = size;
		((Control)_optMethod103_1).TabIndex = 58;
		_optMethod103_1.TabStop = true;
		((ButtonBase)_optMethod103_1).UseVisualStyleBackColor = false;
		((Control)_Label1_25).BackColor = SystemColors.Control;
		((Control)_Label1_25).Cursor = Cursors.Default;
		((Control)_Label1_25).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_25).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_25, (short)25);
		Label label1_15 = _Label1_25;
		location = new Point(37, 48);
		((Control)label1_15).Location = location;
		((Control)_Label1_25).Name = "_Label1_25";
		((Control)_Label1_25).RightToLeft = (RightToLeft)0;
		Label label1_16 = _Label1_25;
		size = new Size(148, 17);
		((Control)label1_16).Size = size;
		((Control)_Label1_25).TabIndex = 87;
		_Label1_25.Text = "DRRchem (kg/site-day)";
		_Label1_25.TextAlign = (ContentAlignment)4;
		((Control)Label7).BackColor = SystemColors.Control;
		((Control)Label7).Cursor = Cursors.Default;
		((Control)Label7).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label7).ForeColor = SystemColors.ControlText;
		Label label = Label7;
		location = new Point(6, 80);
		((Control)label).Location = location;
		((Control)Label7).Name = "Label7";
		((Control)Label7).RightToLeft = (RightToLeft)0;
		Label label2 = Label7;
		size = new Size(259, 19);
		((Control)label2).Size = size;
		((Control)Label7).TabIndex = 85;
		Label7.Text = "DRRchem = DMUchem / (LFb + LFw + LFe)";
		Label7.TextAlign = (ContentAlignment)4;
		((Control)_Label1_18).BackColor = SystemColors.Control;
		((Control)_Label1_18).Cursor = Cursors.Default;
		((Control)_Label1_18).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_18).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_18, (short)18);
		Label label1_17 = _Label1_18;
		location = new Point(34, 24);
		((Control)label1_17).Location = location;
		((Control)_Label1_18).Name = "_Label1_18";
		((Control)_Label1_18).RightToLeft = (RightToLeft)0;
		Label label1_18 = _Label1_18;
		size = new Size(151, 20);
		((Control)label1_18).Size = size;
		((Control)_Label1_18).TabIndex = 60;
		_Label1_18.Text = "DMUchem (kg/site-day)";
		_Label1_18.TextAlign = (ContentAlignment)4;
		((Control)_j_1).BackColor = SystemColors.Control;
		((Control)_j_1).Controls.Add((Control)(object)_txtDMUchem_0);
		((Control)_j_1).Controls.Add((Control)(object)_txtDRRchem_0);
		((Control)_j_1).Controls.Add((Control)(object)_optMethod103_0);
		((Control)_j_1).Controls.Add((Control)(object)Label6);
		((Control)_j_1).Controls.Add((Control)(object)Label3);
		((Control)_j_1).Controls.Add((Control)(object)_Label1_20);
		((Control)_j_1).Controls.Add((Control)(object)_Label1_19);
		((Control)_j_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_j_1).ForeColor = SystemColors.ControlText;
		j.SetIndex(_j_1, (short)1);
		GroupBox j_ = _j_1;
		location = new Point(432, 48);
		((Control)j_).Location = location;
		((Control)_j_1).Name = "_j_1";
		((Control)_j_1).RightToLeft = (RightToLeft)0;
		GroupBox j_2 = _j_1;
		size = new Size(273, 113);
		((Control)j_2).Size = size;
		((Control)_j_1).TabIndex = 55;
		_j_1.TabStop = false;
		_j_1.Text = "Calculate DRRchem and DMUchem";
		_txtDMUchem_0.AcceptsReturn = true;
		((TextBoxBase)_txtDMUchem_0).BackColor = SystemColors.Menu;
		((Control)_txtDMUchem_0).Cursor = Cursors.IBeam;
		((Control)_txtDMUchem_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtDMUchem_0).ForeColor = SystemColors.WindowText;
		txtDMUchem.SetIndex(_txtDMUchem_0, (short)0);
		TextBox txtDMUchem_3 = _txtDMUchem_0;
		location = new Point(192, 24);
		((Control)txtDMUchem_3).Location = location;
		((TextBoxBase)_txtDMUchem_0).MaxLength = 0;
		((Control)_txtDMUchem_0).Name = "_txtDMUchem_0";
		((TextBoxBase)_txtDMUchem_0).ReadOnly = true;
		((Control)_txtDMUchem_0).RightToLeft = (RightToLeft)0;
		TextBox txtDMUchem_4 = _txtDMUchem_0;
		size = new Size(74, 20);
		((Control)txtDMUchem_4).Size = size;
		((Control)_txtDMUchem_0).TabIndex = 89;
		_txtDRRchem_0.AcceptsReturn = true;
		((TextBoxBase)_txtDRRchem_0).BackColor = SystemColors.Menu;
		((Control)_txtDRRchem_0).Cursor = Cursors.IBeam;
		((Control)_txtDRRchem_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtDRRchem_0).ForeColor = SystemColors.WindowText;
		txtDRRchem.SetIndex(_txtDRRchem_0, (short)0);
		TextBox txtDRRchem_3 = _txtDRRchem_0;
		location = new Point(192, 48);
		((Control)txtDRRchem_3).Location = location;
		((TextBoxBase)_txtDRRchem_0).MaxLength = 0;
		((Control)_txtDRRchem_0).Name = "_txtDRRchem_0";
		((TextBoxBase)_txtDRRchem_0).ReadOnly = true;
		((Control)_txtDRRchem_0).RightToLeft = (RightToLeft)0;
		TextBox txtDRRchem_4 = _txtDRRchem_0;
		size = new Size(74, 20);
		((Control)txtDRRchem_4).Size = size;
		((Control)_txtDRRchem_0).TabIndex = 88;
		((ButtonBase)_optMethod103_0).BackColor = SystemColors.Control;
		((Control)_optMethod103_0).Cursor = Cursors.Default;
		((Control)_optMethod103_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optMethod103_0).ForeColor = SystemColors.ControlText;
		optMethod103.SetIndex(_optMethod103_0, (short)0);
		RadioButton optMethod103_3 = _optMethod103_0;
		location = new Point(16, 16);
		((Control)optMethod103_3).Location = location;
		((Control)_optMethod103_0).Name = "_optMethod103_0";
		((Control)_optMethod103_0).RightToLeft = (RightToLeft)0;
		RadioButton optMethod103_4 = _optMethod103_0;
		size = new Size(17, 33);
		((Control)optMethod103_4).Size = size;
		((Control)_optMethod103_0).TabIndex = 56;
		_optMethod103_0.TabStop = true;
		((ButtonBase)_optMethod103_0).UseVisualStyleBackColor = false;
		((Control)Label6).BackColor = SystemColors.Control;
		((Control)Label6).Cursor = Cursors.Default;
		((Control)Label6).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label6).ForeColor = SystemColors.ControlText;
		Label label3 = Label6;
		location = new Point(6, 88);
		((Control)label3).Location = location;
		((Control)Label6).Name = "Label6";
		((Control)Label6).RightToLeft = (RightToLeft)0;
		Label label4 = Label6;
		size = new Size(259, 20);
		((Control)label4).Size = size;
		((Control)Label6).TabIndex = 84;
		Label6.Text = "DMUchem = (LFb + LFw + LFe) x DRRchem";
		Label6.TextAlign = (ContentAlignment)4;
		((Control)Label3).BackColor = SystemColors.Control;
		((Control)Label3).Cursor = Cursors.Default;
		((Control)Label3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label3).ForeColor = SystemColors.ControlText;
		Label label5 = Label3;
		location = new Point(0, 72);
		((Control)label5).Location = location;
		((Control)Label3).Name = "Label3";
		((Control)Label3).RightToLeft = (RightToLeft)0;
		Label label6 = Label3;
		size = new Size(273, 16);
		((Control)label6).Size = size;
		((Control)Label3).TabIndex = 83;
		Label3.Text = "DRRchem = (RRctw x Yctw x HD x Dctw x 60 min/hr)";
		Label3.TextAlign = (ContentAlignment)4;
		((Control)_Label1_20).BackColor = SystemColors.Control;
		((Control)_Label1_20).Cursor = Cursors.Default;
		((Control)_Label1_20).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_20).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_20, (short)20);
		Label label1_19 = _Label1_20;
		location = new Point(48, 24);
		((Control)label1_19).Location = location;
		((Control)_Label1_20).Name = "_Label1_20";
		((Control)_Label1_20).RightToLeft = (RightToLeft)0;
		Label label1_20 = _Label1_20;
		size = new Size(137, 17);
		((Control)label1_20).Size = size;
		((Control)_Label1_20).TabIndex = 63;
		_Label1_20.Text = "DMUchem (kg/site-day)";
		_Label1_20.TextAlign = (ContentAlignment)4;
		((Control)_Label1_19).BackColor = SystemColors.Control;
		((Control)_Label1_19).Cursor = Cursors.Default;
		((Control)_Label1_19).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_19).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_19, (short)19);
		Label label1_21 = _Label1_19;
		location = new Point(56, 48);
		((Control)label1_21).Location = location;
		((Control)_Label1_19).Name = "_Label1_19";
		((Control)_Label1_19).RightToLeft = (RightToLeft)0;
		Label label1_22 = _Label1_19;
		size = new Size(129, 17);
		((Control)label1_22).Size = size;
		((Control)_Label1_19).TabIndex = 62;
		_Label1_19.Text = "DRRchem (kg/site-day)";
		_Label1_19.TextAlign = (ContentAlignment)4;
		((Control)lblCalcNS).BackColor = SystemColors.Control;
		((Control)lblCalcNS).Cursor = Cursors.Default;
		((Control)lblCalcNS).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblCalcNS).ForeColor = SystemColors.ControlText;
		Label obj23 = lblCalcNS;
		location = new Point(16, 332);
		((Control)obj23).Location = location;
		((Control)lblCalcNS).Name = "lblCalcNS";
		((Control)lblCalcNS).RightToLeft = (RightToLeft)0;
		Label obj24 = lblCalcNS;
		size = new Size(409, 45);
		((Control)obj24).Size = size;
		((Control)lblCalcNS).TabIndex = 91;
		lblCalcNS.Text = "Clicking the \"Re-calculate NS\" button will temporarily set OD = 360, re-calculate NS based on the new DMUchem and standard equations, and then re-calculate OD based on the new number of sites.";
		((Control)Label5).BackColor = SystemColors.Control;
		((Control)Label5).Cursor = Cursors.Default;
		((Control)Label5).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label5).ForeColor = SystemColors.ControlText;
		Label label7 = Label5;
		location = new Point(16, 16);
		((Control)label7).Location = location;
		((Control)Label5).Name = "Label5";
		((Control)Label5).RightToLeft = (RightToLeft)0;
		Label label8 = Label5;
		size = new Size(697, 33);
		((Control)label8).Size = size;
		((Control)Label5).TabIndex = 61;
		Label5.Text = "View or change the method for deriving DMUchem. Press &Restore Defaults to restore the original defaults for all parameters on this window.";
		((Control)_fraGSS_1).BackColor = SystemColors.Control;
		((Control)_fraGSS_1).Controls.Add((Control)(object)_Frame2_1);
		((Control)_fraGSS_1).Controls.Add((Control)(object)_frame1_3);
		((Control)_fraGSS_1).Controls.Add((Control)(object)Label2);
		((Control)_fraGSS_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_fraGSS_1).ForeColor = SystemColors.ControlText;
		fraGSS.SetIndex(_fraGSS_1, (short)1);
		GroupBox fraGSS_3 = _fraGSS_1;
		location = new Point(96, 8);
		((Control)fraGSS_3).Location = location;
		((Control)_fraGSS_1).Name = "_fraGSS_1";
		((Control)_fraGSS_1).RightToLeft = (RightToLeft)0;
		GroupBox fraGSS_4 = _fraGSS_1;
		size = new Size(529, 377);
		((Control)fraGSS_4).Size = size;
		((Control)_fraGSS_1).TabIndex = 28;
		_fraGSS_1.TabStop = false;
		((Control)_fraGSS_1).Visible = false;
		((Control)_Frame2_1).BackColor = SystemColors.Control;
		((Control)_Frame2_1).Controls.Add((Control)(object)txtUserInput);
		((Control)_Frame2_1).Controls.Add((Control)(object)_optMethod102_1);
		((Control)_Frame2_1).Controls.Add((Control)(object)_Label1_5);
		((Control)_Frame2_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Frame2_1).ForeColor = SystemColors.ControlText;
		Frame2.SetIndex(_Frame2_1, (short)1);
		GroupBox frame2_3 = _Frame2_1;
		location = new Point(48, 264);
		((Control)frame2_3).Location = location;
		((Control)_Frame2_1).Name = "_Frame2_1";
		((Control)_Frame2_1).RightToLeft = (RightToLeft)0;
		GroupBox frame2_4 = _Frame2_1;
		size = new Size(433, 65);
		((Control)frame2_4).Size = size;
		((Control)_Frame2_1).TabIndex = 34;
		_Frame2_1.TabStop = false;
		_Frame2_1.Text = "BMOprod = User input value";
		txtUserInput.AcceptsReturn = true;
		((TextBoxBase)txtUserInput).BackColor = SystemColors.Menu;
		((Control)txtUserInput).Cursor = Cursors.IBeam;
		((Control)txtUserInput).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtUserInput).ForeColor = SystemColors.WindowText;
		TextBox obj25 = txtUserInput;
		location = new Point(304, 24);
		((Control)obj25).Location = location;
		((TextBoxBase)txtUserInput).MaxLength = 0;
		((Control)txtUserInput).Name = "txtUserInput";
		((TextBoxBase)txtUserInput).ReadOnly = true;
		((Control)txtUserInput).RightToLeft = (RightToLeft)0;
		TextBox obj26 = txtUserInput;
		size = new Size(74, 20);
		((Control)obj26).Size = size;
		((Control)txtUserInput).TabIndex = 6;
		((ButtonBase)_optMethod102_1).BackColor = SystemColors.Control;
		((Control)_optMethod102_1).Cursor = Cursors.Default;
		((Control)_optMethod102_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optMethod102_1).ForeColor = SystemColors.ControlText;
		optMethod102.SetIndex(_optMethod102_1, (short)1);
		RadioButton optMethod102_ = _optMethod102_1;
		location = new Point(16, 24);
		((Control)optMethod102_).Location = location;
		((Control)_optMethod102_1).Name = "_optMethod102_1";
		((Control)_optMethod102_1).RightToLeft = (RightToLeft)0;
		RadioButton optMethod102_2 = _optMethod102_1;
		size = new Size(25, 17);
		((Control)optMethod102_2).Size = size;
		((Control)_optMethod102_1).TabIndex = 5;
		_optMethod102_1.TabStop = true;
		((ButtonBase)_optMethod102_1).UseVisualStyleBackColor = false;
		((Control)_Label1_5).BackColor = SystemColors.Control;
		((Control)_Label1_5).Cursor = Cursors.Default;
		((Control)_Label1_5).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_5).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_5, (short)5);
		Label label1_23 = _Label1_5;
		location = new Point(64, 24);
		((Control)label1_23).Location = location;
		((Control)_Label1_5).Name = "_Label1_5";
		((Control)_Label1_5).RightToLeft = (RightToLeft)0;
		Label label1_24 = _Label1_5;
		size = new Size(233, 17);
		((Control)label1_24).Size = size;
		((Control)_Label1_5).TabIndex = 35;
		_Label1_5.Text = "BMOprod (kg formulated adhesive/ site-batch): ";
		_Label1_5.TextAlign = (ContentAlignment)4;
		((Control)_frame1_3).BackColor = SystemColors.Control;
		((Control)_frame1_3).Controls.Add((Control)(object)cmdCalcBmoProd102);
		((Control)_frame1_3).Controls.Add((Control)(object)_optMethod102_0);
		((Control)_frame1_3).Controls.Add((Control)(object)_txtDprod_2);
		((Control)_frame1_3).Controls.Add((Control)(object)txtVbatch);
		((Control)_frame1_3).Controls.Add((Control)(object)lblBMOprod);
		((Control)_frame1_3).Controls.Add((Control)(object)_Label1_13);
		((Control)_frame1_3).Controls.Add((Control)(object)_Label1_11);
		((Control)_frame1_3).Controls.Add((Control)(object)_Label1_10);
		((Control)_frame1_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_frame1_3).ForeColor = SystemColors.ControlText;
		frame1.SetIndex(_frame1_3, (short)3);
		GroupBox frame1_ = _frame1_3;
		location = new Point(48, 64);
		((Control)frame1_).Location = location;
		((Control)_frame1_3).Name = "_frame1_3";
		((Control)_frame1_3).RightToLeft = (RightToLeft)0;
		GroupBox frame1_2 = _frame1_3;
		size = new Size(433, 177);
		((Control)frame1_2).Size = size;
		((Control)_frame1_3).TabIndex = 29;
		_frame1_3.TabStop = false;
		_frame1_3.Text = "BMOprod = Vbatch x Dprod";
		((ButtonBase)cmdCalcBmoProd102).BackColor = SystemColors.Control;
		((Control)cmdCalcBmoProd102).Cursor = Cursors.Default;
		((Control)cmdCalcBmoProd102).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCalcBmoProd102).ForeColor = SystemColors.ControlText;
		Button obj27 = cmdCalcBmoProd102;
		location = new Point(112, 120);
		((Control)obj27).Location = location;
		((Control)cmdCalcBmoProd102).Name = "cmdCalcBmoProd102";
		((Control)cmdCalcBmoProd102).RightToLeft = (RightToLeft)0;
		Button obj28 = cmdCalcBmoProd102;
		size = new Size(193, 25);
		((Control)obj28).Size = size;
		((Control)cmdCalcBmoProd102).TabIndex = 4;
		((ButtonBase)cmdCalcBmoProd102).Text = "&Calculate BMOprod";
		((ButtonBase)cmdCalcBmoProd102).UseVisualStyleBackColor = false;
		((ButtonBase)_optMethod102_0).BackColor = SystemColors.Control;
		((Control)_optMethod102_0).Cursor = Cursors.Default;
		((Control)_optMethod102_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optMethod102_0).ForeColor = SystemColors.ControlText;
		optMethod102.SetIndex(_optMethod102_0, (short)0);
		RadioButton optMethod102_3 = _optMethod102_0;
		location = new Point(24, 48);
		((Control)optMethod102_3).Location = location;
		((Control)_optMethod102_0).Name = "_optMethod102_0";
		((Control)_optMethod102_0).RightToLeft = (RightToLeft)0;
		RadioButton optMethod102_4 = _optMethod102_0;
		size = new Size(17, 33);
		((Control)optMethod102_4).Size = size;
		((Control)_optMethod102_0).TabIndex = 0;
		_optMethod102_0.TabStop = true;
		((ButtonBase)_optMethod102_0).UseVisualStyleBackColor = false;
		_txtDprod_2.AcceptsReturn = true;
		((TextBoxBase)_txtDprod_2).BackColor = Color.FromArgb(192, 192, 192);
		((Control)_txtDprod_2).Cursor = Cursors.IBeam;
		((Control)_txtDprod_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtDprod_2).ForeColor = SystemColors.WindowText;
		txtDprod.SetIndex(_txtDprod_2, (short)2);
		TextBox txtDprod_ = _txtDprod_2;
		location = new Point(304, 48);
		((Control)txtDprod_).Location = location;
		((TextBoxBase)_txtDprod_2).MaxLength = 0;
		((Control)_txtDprod_2).Name = "_txtDprod_2";
		((TextBoxBase)_txtDprod_2).ReadOnly = true;
		((Control)_txtDprod_2).RightToLeft = (RightToLeft)0;
		TextBox txtDprod_2 = _txtDprod_2;
		size = new Size(73, 20);
		((Control)txtDprod_2).Size = size;
		((Control)_txtDprod_2).TabIndex = 2;
		txtVbatch.AcceptsReturn = true;
		((TextBoxBase)txtVbatch).BackColor = Color.FromArgb(192, 192, 192);
		((Control)txtVbatch).Cursor = Cursors.IBeam;
		((Control)txtVbatch).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtVbatch).ForeColor = SystemColors.WindowText;
		TextBox obj29 = txtVbatch;
		location = new Point(304, 24);
		((Control)obj29).Location = location;
		((TextBoxBase)txtVbatch).MaxLength = 0;
		((Control)txtVbatch).Name = "txtVbatch";
		((TextBoxBase)txtVbatch).ReadOnly = true;
		((Control)txtVbatch).RightToLeft = (RightToLeft)0;
		TextBox obj30 = txtVbatch;
		size = new Size(73, 20);
		((Control)obj30).Size = size;
		((Control)txtVbatch).TabIndex = 1;
		((Control)lblBMOprod).BackColor = SystemColors.Control;
		lblBMOprod.BorderStyle = (BorderStyle)2;
		((Control)lblBMOprod).Cursor = Cursors.Default;
		((Control)lblBMOprod).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblBMOprod).ForeColor = SystemColors.ControlText;
		Label obj31 = lblBMOprod;
		location = new Point(304, 80);
		((Control)obj31).Location = location;
		((Control)lblBMOprod).Name = "lblBMOprod";
		((Control)lblBMOprod).RightToLeft = (RightToLeft)0;
		Label obj32 = lblBMOprod;
		size = new Size(73, 19);
		((Control)obj32).Size = size;
		((Control)lblBMOprod).TabIndex = 3;
		lblBMOprod.TextAlign = (ContentAlignment)4;
		((Control)_Label1_13).BackColor = SystemColors.Control;
		((Control)_Label1_13).Cursor = Cursors.Default;
		((Control)_Label1_13).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_13).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_13, (short)13);
		Label label1_25 = _Label1_13;
		location = new Point(37, 80);
		((Control)label1_25).Location = location;
		((Control)_Label1_13).Name = "_Label1_13";
		((Control)_Label1_13).RightToLeft = (RightToLeft)0;
		Label label1_26 = _Label1_13;
		size = new Size(260, 17);
		((Control)label1_26).Size = size;
		((Control)_Label1_13).TabIndex = 32;
		_Label1_13.Text = "BMOprod (kg formulated adhesive/ site-batch): ";
		_Label1_13.TextAlign = (ContentAlignment)4;
		((Control)_Label1_11).BackColor = SystemColors.Control;
		((Control)_Label1_11).Cursor = Cursors.Default;
		((Control)_Label1_11).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_11).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_11, (short)11);
		Label label1_27 = _Label1_11;
		location = new Point(56, 48);
		((Control)label1_27).Location = location;
		((Control)_Label1_11).Name = "_Label1_11";
		((Control)_Label1_11).RightToLeft = (RightToLeft)0;
		Label label1_28 = _Label1_11;
		size = new Size(241, 19);
		((Control)label1_28).Size = size;
		((Control)_Label1_11).TabIndex = 31;
		_Label1_11.Text = "Dprod (adhesive density, kg/L): ";
		_Label1_11.TextAlign = (ContentAlignment)4;
		((Control)_Label1_10).BackColor = SystemColors.Control;
		((Control)_Label1_10).Cursor = Cursors.Default;
		((Control)_Label1_10).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_10).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_10, (short)10);
		Label label1_29 = _Label1_10;
		location = new Point(40, 24);
		((Control)label1_29).Location = location;
		((Control)_Label1_10).Name = "_Label1_10";
		((Control)_Label1_10).RightToLeft = (RightToLeft)0;
		Label label1_30 = _Label1_10;
		size = new Size(257, 17);
		((Control)label1_30).Size = size;
		((Control)_Label1_10).TabIndex = 30;
		_Label1_10.Text = "Vbatch (liters of adhesive / site-batch): ";
		_Label1_10.TextAlign = (ContentAlignment)4;
		((Control)Label2).BackColor = SystemColors.Control;
		((Control)Label2).Cursor = Cursors.Default;
		((Control)Label2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label2).ForeColor = SystemColors.ControlText;
		Label label9 = Label2;
		location = new Point(16, 16);
		((Control)label9).Location = location;
		((Control)Label2).Name = "Label2";
		((Control)Label2).RightToLeft = (RightToLeft)0;
		Label label10 = Label2;
		size = new Size(497, 41);
		((Control)label10).Size = size;
		((Control)Label2).TabIndex = 33;
		Label2.Text = "View or change the method for deriving BMOProd. Press &Restore Defaults to restore the original defaults for all parameters on this window. ";
		((Control)_fraGSS_0).BackColor = SystemColors.Control;
		((Control)_fraGSS_0).Controls.Add((Control)(object)cmdCalc);
		((Control)_fraGSS_0).Controls.Add((Control)(object)_j_0);
		((Control)_fraGSS_0).Controls.Add((Control)(object)_jj_1);
		((Control)_fraGSS_0).Controls.Add((Control)(object)lblInstructions);
		((Control)_fraGSS_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_fraGSS_0).ForeColor = SystemColors.ControlText;
		fraGSS.SetIndex(_fraGSS_0, (short)0);
		GroupBox fraGSS_5 = _fraGSS_0;
		location = new Point(96, 8);
		((Control)fraGSS_5).Location = location;
		((Control)_fraGSS_0).Name = "_fraGSS_0";
		((Control)_fraGSS_0).RightToLeft = (RightToLeft)0;
		GroupBox fraGSS_6 = _fraGSS_0;
		size = new Size(529, 377);
		((Control)fraGSS_6).Size = size;
		((Control)_fraGSS_0).TabIndex = 7;
		_fraGSS_0.TabStop = false;
		((Control)_fraGSS_0).Visible = false;
		((ButtonBase)cmdCalc).BackColor = SystemColors.Control;
		((Control)cmdCalc).Cursor = Cursors.Default;
		((Control)cmdCalc).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCalc).ForeColor = SystemColors.ControlText;
		Button obj33 = cmdCalc;
		location = new Point(168, 344);
		((Control)obj33).Location = location;
		((Control)cmdCalc).Name = "cmdCalc";
		((Control)cmdCalc).RightToLeft = (RightToLeft)0;
		Button obj34 = cmdCalc;
		size = new Size(193, 25);
		((Control)obj34).Size = size;
		((Control)cmdCalc).TabIndex = 27;
		((ButtonBase)cmdCalc).Text = "&Calculate a new Daily Mass of Paint";
		((ButtonBase)cmdCalc).UseVisualStyleBackColor = false;
		((Control)_j_0).BackColor = SystemColors.Control;
		((Control)_j_0).Controls.Add((Control)(object)txtVpaint);
		((Control)_j_0).Controls.Add((Control)(object)_txtDprod_1);
		((Control)_j_0).Controls.Add((Control)(object)_optMethod_1);
		((Control)_j_0).Controls.Add((Control)(object)_Label1_4);
		((Control)_j_0).Controls.Add((Control)(object)_Label1_6);
		((Control)_j_0).Controls.Add((Control)(object)_Label1_7);
		((Control)_j_0).Controls.Add((Control)(object)_lblDmuPaint_1);
		((Control)_j_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_j_0).ForeColor = SystemColors.ControlText;
		j.SetIndex(_j_0, (short)0);
		GroupBox j_3 = _j_0;
		location = new Point(16, 216);
		((Control)j_3).Location = location;
		((Control)_j_0).Name = "_j_0";
		((Control)_j_0).RightToLeft = (RightToLeft)0;
		GroupBox j_4 = _j_0;
		size = new Size(497, 113);
		((Control)j_4).Size = size;
		((Control)_j_0).TabIndex = 19;
		_j_0.TabStop = false;
		_j_0.Text = "DMUpaint=Gallons of paint used per day x Paint density x Conversion factor (3.785)";
		txtVpaint.AcceptsReturn = true;
		((TextBoxBase)txtVpaint).BackColor = Color.FromArgb(192, 192, 192);
		((Control)txtVpaint).Cursor = Cursors.IBeam;
		((Control)txtVpaint).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtVpaint).ForeColor = SystemColors.WindowText;
		TextBox obj35 = txtVpaint;
		location = new Point(384, 24);
		((Control)obj35).Location = location;
		((TextBoxBase)txtVpaint).MaxLength = 0;
		((Control)txtVpaint).Name = "txtVpaint";
		((TextBoxBase)txtVpaint).ReadOnly = true;
		((Control)txtVpaint).RightToLeft = (RightToLeft)0;
		TextBox obj36 = txtVpaint;
		size = new Size(73, 20);
		((Control)obj36).Size = size;
		((Control)txtVpaint).TabIndex = 22;
		_txtDprod_1.AcceptsReturn = true;
		((TextBoxBase)_txtDprod_1).BackColor = Color.FromArgb(192, 192, 192);
		((Control)_txtDprod_1).Cursor = Cursors.IBeam;
		((Control)_txtDprod_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtDprod_1).ForeColor = SystemColors.WindowText;
		txtDprod.SetIndex(_txtDprod_1, (short)1);
		TextBox txtDprod_3 = _txtDprod_1;
		location = new Point(384, 48);
		((Control)txtDprod_3).Location = location;
		((TextBoxBase)_txtDprod_1).MaxLength = 0;
		((Control)_txtDprod_1).Name = "_txtDprod_1";
		((TextBoxBase)_txtDprod_1).ReadOnly = true;
		((Control)_txtDprod_1).RightToLeft = (RightToLeft)0;
		TextBox txtDprod_4 = _txtDprod_1;
		size = new Size(73, 20);
		((Control)txtDprod_4).Size = size;
		((Control)_txtDprod_1).TabIndex = 21;
		((ButtonBase)_optMethod_1).BackColor = SystemColors.Control;
		((Control)_optMethod_1).Cursor = Cursors.Default;
		((Control)_optMethod_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optMethod_1).ForeColor = SystemColors.ControlText;
		optMethod.SetIndex(_optMethod_1, (short)1);
		RadioButton optMethod_ = _optMethod_1;
		location = new Point(24, 32);
		((Control)optMethod_).Location = location;
		((Control)_optMethod_1).Name = "_optMethod_1";
		((Control)_optMethod_1).RightToLeft = (RightToLeft)0;
		RadioButton optMethod_2 = _optMethod_1;
		size = new Size(17, 33);
		((Control)optMethod_2).Size = size;
		((Control)_optMethod_1).TabIndex = 20;
		_optMethod_1.TabStop = true;
		((ButtonBase)_optMethod_1).UseVisualStyleBackColor = false;
		((Control)_Label1_4).BackColor = SystemColors.Control;
		((Control)_Label1_4).Cursor = Cursors.Default;
		((Control)_Label1_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_4).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_4, (short)4);
		Label label1_31 = _Label1_4;
		location = new Point(16, 80);
		((Control)label1_31).Location = location;
		((Control)_Label1_4).Name = "_Label1_4";
		((Control)_Label1_4).RightToLeft = (RightToLeft)0;
		Label label1_32 = _Label1_4;
		size = new Size(361, 17);
		((Control)label1_32).Size = size;
		((Control)_Label1_4).TabIndex = 26;
		_Label1_4.Text = "DVUfpaint, volume of formulated coating used per day(gallons/site-day):";
		_Label1_4.TextAlign = (ContentAlignment)4;
		((Control)_Label1_6).BackColor = SystemColors.Control;
		((Control)_Label1_6).Cursor = Cursors.Default;
		((Control)_Label1_6).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_6).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_6, (short)6);
		Label label1_33 = _Label1_6;
		location = new Point(192, 48);
		((Control)label1_33).Location = location;
		((Control)_Label1_6).Name = "_Label1_6";
		((Control)_Label1_6).RightToLeft = (RightToLeft)0;
		Label label1_34 = _Label1_6;
		size = new Size(185, 17);
		((Control)label1_34).Size = size;
		((Control)_Label1_6).TabIndex = 25;
		_Label1_6.Text = "Dfpaint, density of paint (kg/L): ";
		_Label1_6.TextAlign = (ContentAlignment)4;
		((Control)_Label1_7).BackColor = SystemColors.Control;
		((Control)_Label1_7).Cursor = Cursors.Default;
		((Control)_Label1_7).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_7).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_7, (short)7);
		Label label1_35 = _Label1_7;
		location = new Point(152, 24);
		((Control)label1_35).Location = location;
		((Control)_Label1_7).Name = "_Label1_7";
		((Control)_Label1_7).RightToLeft = (RightToLeft)0;
		Label label1_36 = _Label1_7;
		size = new Size(225, 17);
		((Control)label1_36).Size = size;
		((Control)_Label1_7).TabIndex = 24;
		_Label1_7.Text = "Gallons of paint used per day: ";
		_Label1_7.TextAlign = (ContentAlignment)4;
		((Control)_lblDmuPaint_1).BackColor = SystemColors.Control;
		_lblDmuPaint_1.BorderStyle = (BorderStyle)2;
		((Control)_lblDmuPaint_1).Cursor = Cursors.Default;
		((Control)_lblDmuPaint_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblDmuPaint_1).ForeColor = SystemColors.ControlText;
		lblDmuPaint.SetIndex(_lblDmuPaint_1, (short)1);
		Label lblDmuPaint_ = _lblDmuPaint_1;
		location = new Point(384, 80);
		((Control)lblDmuPaint_).Location = location;
		((Control)_lblDmuPaint_1).Name = "_lblDmuPaint_1";
		((Control)_lblDmuPaint_1).RightToLeft = (RightToLeft)0;
		Label lblDmuPaint_2 = _lblDmuPaint_1;
		size = new Size(73, 19);
		((Control)lblDmuPaint_2).Size = size;
		((Control)_lblDmuPaint_1).TabIndex = 23;
		_lblDmuPaint_1.TextAlign = (ContentAlignment)4;
		((Control)_jj_1).BackColor = SystemColors.Control;
		((Control)_jj_1).Controls.Add((Control)(object)txtVcar);
		((Control)_jj_1).Controls.Add((Control)(object)_txtDprod_0);
		((Control)_jj_1).Controls.Add((Control)(object)txtNcar);
		((Control)_jj_1).Controls.Add((Control)(object)_optMethod_0);
		((Control)_jj_1).Controls.Add((Control)(object)_Label1_0);
		((Control)_jj_1).Controls.Add((Control)(object)_Label1_1);
		((Control)_jj_1).Controls.Add((Control)(object)_Label1_2);
		((Control)_jj_1).Controls.Add((Control)(object)_Label1_3);
		((Control)_jj_1).Controls.Add((Control)(object)_lblDmuPaint_0);
		((Control)_jj_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_jj_1).ForeColor = SystemColors.ControlText;
		jj.SetIndex(_jj_1, (short)1);
		GroupBox jj_ = _jj_1;
		location = new Point(16, 64);
		((Control)jj_).Location = location;
		((Control)_jj_1).Name = "_jj_1";
		((Control)_jj_1).RightToLeft = (RightToLeft)0;
		GroupBox jj_2 = _jj_1;
		size = new Size(497, 137);
		((Control)jj_2).Size = size;
		((Control)_jj_1).TabIndex = 8;
		_jj_1.TabStop = false;
		_jj_1.Text = "DMUpaint=Liters of paint applied per car x Paint density x Number of cars per site-day";
		txtVcar.AcceptsReturn = true;
		((TextBoxBase)txtVcar).BackColor = Color.FromArgb(192, 192, 192);
		((Control)txtVcar).Cursor = Cursors.IBeam;
		((Control)txtVcar).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtVcar).ForeColor = SystemColors.WindowText;
		TextBox obj37 = txtVcar;
		location = new Point(384, 24);
		((Control)obj37).Location = location;
		((TextBoxBase)txtVcar).MaxLength = 0;
		((Control)txtVcar).Name = "txtVcar";
		((TextBoxBase)txtVcar).ReadOnly = true;
		((Control)txtVcar).RightToLeft = (RightToLeft)0;
		TextBox obj38 = txtVcar;
		size = new Size(73, 20);
		((Control)obj38).Size = size;
		((Control)txtVcar).TabIndex = 12;
		_txtDprod_0.AcceptsReturn = true;
		((TextBoxBase)_txtDprod_0).BackColor = Color.FromArgb(192, 192, 192);
		((Control)_txtDprod_0).Cursor = Cursors.IBeam;
		((Control)_txtDprod_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtDprod_0).ForeColor = SystemColors.WindowText;
		txtDprod.SetIndex(_txtDprod_0, (short)0);
		TextBox txtDprod_5 = _txtDprod_0;
		location = new Point(384, 48);
		((Control)txtDprod_5).Location = location;
		((TextBoxBase)_txtDprod_0).MaxLength = 0;
		((Control)_txtDprod_0).Name = "_txtDprod_0";
		((TextBoxBase)_txtDprod_0).ReadOnly = true;
		((Control)_txtDprod_0).RightToLeft = (RightToLeft)0;
		TextBox txtDprod_6 = _txtDprod_0;
		size = new Size(73, 20);
		((Control)txtDprod_6).Size = size;
		((Control)_txtDprod_0).TabIndex = 11;
		txtNcar.AcceptsReturn = true;
		((TextBoxBase)txtNcar).BackColor = Color.FromArgb(192, 192, 192);
		((Control)txtNcar).Cursor = Cursors.IBeam;
		((Control)txtNcar).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtNcar).ForeColor = SystemColors.WindowText;
		TextBox obj39 = txtNcar;
		location = new Point(384, 72);
		((Control)obj39).Location = location;
		((TextBoxBase)txtNcar).MaxLength = 0;
		((Control)txtNcar).Name = "txtNcar";
		((TextBoxBase)txtNcar).ReadOnly = true;
		((Control)txtNcar).RightToLeft = (RightToLeft)0;
		TextBox obj40 = txtNcar;
		size = new Size(73, 20);
		((Control)obj40).Size = size;
		((Control)txtNcar).TabIndex = 10;
		((ButtonBase)_optMethod_0).BackColor = SystemColors.Control;
		((Control)_optMethod_0).Cursor = Cursors.Default;
		((Control)_optMethod_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optMethod_0).ForeColor = SystemColors.ControlText;
		optMethod.SetIndex(_optMethod_0, (short)0);
		RadioButton optMethod_3 = _optMethod_0;
		location = new Point(24, 48);
		((Control)optMethod_3).Location = location;
		((Control)_optMethod_0).Name = "_optMethod_0";
		((Control)_optMethod_0).RightToLeft = (RightToLeft)0;
		RadioButton optMethod_4 = _optMethod_0;
		size = new Size(17, 33);
		((Control)optMethod_4).Size = size;
		((Control)_optMethod_0).TabIndex = 9;
		_optMethod_0.TabStop = true;
		((ButtonBase)_optMethod_0).UseVisualStyleBackColor = false;
		((Control)_Label1_0).BackColor = SystemColors.Control;
		((Control)_Label1_0).Cursor = Cursors.Default;
		((Control)_Label1_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_0).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_0, (short)0);
		Label label1_37 = _Label1_0;
		location = new Point(96, 24);
		((Control)label1_37).Location = location;
		((Control)_Label1_0).Name = "_Label1_0";
		((Control)_Label1_0).RightToLeft = (RightToLeft)0;
		Label label1_38 = _Label1_0;
		size = new Size(281, 17);
		((Control)label1_38).Size = size;
		((Control)_Label1_0).TabIndex = 17;
		_Label1_0.Text = "Liters of paint applied per car: ";
		_Label1_0.TextAlign = (ContentAlignment)4;
		((Control)_Label1_1).BackColor = SystemColors.Control;
		((Control)_Label1_1).Cursor = Cursors.Default;
		((Control)_Label1_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_1).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_1, (short)1);
		Label label1_39 = _Label1_1;
		location = new Point(128, 48);
		((Control)label1_39).Location = location;
		((Control)_Label1_1).Name = "_Label1_1";
		((Control)_Label1_1).RightToLeft = (RightToLeft)0;
		Label label1_40 = _Label1_1;
		size = new Size(249, 17);
		((Control)label1_40).Size = size;
		((Control)_Label1_1).TabIndex = 16;
		_Label1_1.Text = "Dfpaint, density of paint (kg/L): ";
		_Label1_1.TextAlign = (ContentAlignment)4;
		((Control)_Label1_2).BackColor = SystemColors.Control;
		((Control)_Label1_2).Cursor = Cursors.Default;
		((Control)_Label1_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_2).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_2, (short)2);
		Label label1_41 = _Label1_2;
		location = new Point(144, 72);
		((Control)label1_41).Location = location;
		((Control)_Label1_2).Name = "_Label1_2";
		((Control)_Label1_2).RightToLeft = (RightToLeft)0;
		Label label1_42 = _Label1_2;
		size = new Size(233, 17);
		((Control)label1_42).Size = size;
		((Control)_Label1_2).TabIndex = 15;
		_Label1_2.Text = "Ncar, Number of cars painted per site-day: ";
		_Label1_2.TextAlign = (ContentAlignment)4;
		((Control)_Label1_3).BackColor = SystemColors.Control;
		((Control)_Label1_3).Cursor = Cursors.Default;
		((Control)_Label1_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_3).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_3, (short)3);
		Label label1_43 = _Label1_3;
		location = new Point(16, 104);
		((Control)label1_43).Location = location;
		((Control)_Label1_3).Name = "_Label1_3";
		((Control)_Label1_3).RightToLeft = (RightToLeft)0;
		Label label1_44 = _Label1_3;
		size = new Size(361, 17);
		((Control)label1_44).Size = size;
		((Control)_Label1_3).TabIndex = 14;
		_Label1_3.Text = "DVUfpaint, volume of formulated coating used per day(gallons/site-day):";
		_Label1_3.TextAlign = (ContentAlignment)4;
		((Control)_lblDmuPaint_0).BackColor = SystemColors.Control;
		_lblDmuPaint_0.BorderStyle = (BorderStyle)2;
		((Control)_lblDmuPaint_0).Cursor = Cursors.Default;
		((Control)_lblDmuPaint_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblDmuPaint_0).ForeColor = SystemColors.ControlText;
		lblDmuPaint.SetIndex(_lblDmuPaint_0, (short)0);
		Label lblDmuPaint_3 = _lblDmuPaint_0;
		location = new Point(384, 104);
		((Control)lblDmuPaint_3).Location = location;
		((Control)_lblDmuPaint_0).Name = "_lblDmuPaint_0";
		((Control)_lblDmuPaint_0).RightToLeft = (RightToLeft)0;
		Label lblDmuPaint_4 = _lblDmuPaint_0;
		size = new Size(73, 19);
		((Control)lblDmuPaint_4).Size = size;
		((Control)_lblDmuPaint_0).TabIndex = 13;
		_lblDmuPaint_0.TextAlign = (ContentAlignment)4;
		((Control)lblInstructions).BackColor = SystemColors.Control;
		((Control)lblInstructions).Cursor = Cursors.Default;
		((Control)lblInstructions).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblInstructions).ForeColor = SystemColors.ControlText;
		Label obj41 = lblInstructions;
		location = new Point(16, 16);
		((Control)obj41).Location = location;
		((Control)lblInstructions).Name = "lblInstructions";
		((Control)lblInstructions).RightToLeft = (RightToLeft)0;
		Label obj42 = lblInstructions;
		size = new Size(497, 41);
		((Control)obj42).Size = size;
		((Control)lblInstructions).TabIndex = 18;
		lblInstructions.Text = "View or change the method for deriving DMUPaint. Press &Restore Defaults to restore the original defaults for all parameters on this window. ";
		((Control)_fraGSS_2).BackColor = SystemColors.Control;
		((Control)_fraGSS_2).Controls.Add((Control)(object)_j_2);
		((Control)_fraGSS_2).Controls.Add((Control)(object)_Frame2_0);
		((Control)_fraGSS_2).Controls.Add((Control)(object)Label4);
		((Control)_fraGSS_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_fraGSS_2).ForeColor = SystemColors.ControlText;
		fraGSS.SetIndex(_fraGSS_2, (short)2);
		GroupBox fraGSS_7 = _fraGSS_2;
		location = new Point(96, 8);
		((Control)fraGSS_7).Location = location;
		((Control)_fraGSS_2).Name = "_fraGSS_2";
		((Control)_fraGSS_2).RightToLeft = (RightToLeft)0;
		GroupBox fraGSS_8 = _fraGSS_2;
		size = new Size(529, 377);
		((Control)fraGSS_8).Size = size;
		((Control)_fraGSS_2).TabIndex = 39;
		_fraGSS_2.TabStop = false;
		((Control)_fraGSS_2).Visible = false;
		((Control)_j_2).BackColor = SystemColors.Control;
		((Control)_j_2).Controls.Add((Control)(object)txtDVIppaint);
		((Control)_j_2).Controls.Add((Control)(object)txtDppaint);
		((Control)_j_2).Controls.Add((Control)(object)_optMethod101_0);
		((Control)_j_2).Controls.Add((Control)(object)cmdCalc101);
		((Control)_j_2).Controls.Add((Control)(object)_Label1_14);
		((Control)_j_2).Controls.Add((Control)(object)_Label1_12);
		((Control)_j_2).Controls.Add((Control)(object)_Label1_9);
		((Control)_j_2).Controls.Add((Control)(object)lblDMIppaint);
		((Control)_j_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_j_2).ForeColor = SystemColors.ControlText;
		j.SetIndex(_j_2, (short)2);
		GroupBox j_5 = _j_2;
		location = new Point(48, 64);
		((Control)j_5).Location = location;
		((Control)_j_2).Name = "_j_2";
		((Control)_j_2).RightToLeft = (RightToLeft)0;
		GroupBox j_6 = _j_2;
		size = new Size(433, 177);
		((Control)j_6).Size = size;
		((Control)_j_2).TabIndex = 44;
		_j_2.TabStop = false;
		_j_2.Text = "DMIppaint = DVIppaint x Dppaint";
		txtDVIppaint.AcceptsReturn = true;
		((TextBoxBase)txtDVIppaint).BackColor = Color.FromArgb(192, 192, 192);
		((Control)txtDVIppaint).Cursor = Cursors.IBeam;
		((Control)txtDVIppaint).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtDVIppaint).ForeColor = SystemColors.WindowText;
		TextBox obj43 = txtDVIppaint;
		location = new Point(304, 24);
		((Control)obj43).Location = location;
		((TextBoxBase)txtDVIppaint).MaxLength = 0;
		((Control)txtDVIppaint).Name = "txtDVIppaint";
		((TextBoxBase)txtDVIppaint).ReadOnly = true;
		((Control)txtDVIppaint).RightToLeft = (RightToLeft)0;
		TextBox obj44 = txtDVIppaint;
		size = new Size(73, 20);
		((Control)obj44).Size = size;
		((Control)txtDVIppaint).TabIndex = 48;
		txtDppaint.AcceptsReturn = true;
		((TextBoxBase)txtDppaint).BackColor = Color.FromArgb(192, 192, 192);
		((Control)txtDppaint).Cursor = Cursors.IBeam;
		((Control)txtDppaint).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtDppaint).ForeColor = SystemColors.WindowText;
		TextBox obj45 = txtDppaint;
		location = new Point(304, 48);
		((Control)obj45).Location = location;
		((TextBoxBase)txtDppaint).MaxLength = 0;
		((Control)txtDppaint).Name = "txtDppaint";
		((TextBoxBase)txtDppaint).ReadOnly = true;
		((Control)txtDppaint).RightToLeft = (RightToLeft)0;
		TextBox obj46 = txtDppaint;
		size = new Size(73, 20);
		((Control)obj46).Size = size;
		((Control)txtDppaint).TabIndex = 47;
		((ButtonBase)_optMethod101_0).BackColor = SystemColors.Control;
		((Control)_optMethod101_0).Cursor = Cursors.Default;
		((Control)_optMethod101_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optMethod101_0).ForeColor = SystemColors.ControlText;
		optMethod101.SetIndex(_optMethod101_0, (short)0);
		RadioButton optMethod101_ = _optMethod101_0;
		location = new Point(24, 48);
		((Control)optMethod101_).Location = location;
		((Control)_optMethod101_0).Name = "_optMethod101_0";
		((Control)_optMethod101_0).RightToLeft = (RightToLeft)0;
		RadioButton optMethod101_2 = _optMethod101_0;
		size = new Size(17, 33);
		((Control)optMethod101_2).Size = size;
		((Control)_optMethod101_0).TabIndex = 46;
		_optMethod101_0.TabStop = true;
		((ButtonBase)_optMethod101_0).UseVisualStyleBackColor = false;
		((ButtonBase)cmdCalc101).BackColor = SystemColors.Control;
		((Control)cmdCalc101).Cursor = Cursors.Default;
		((Control)cmdCalc101).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCalc101).ForeColor = SystemColors.ControlText;
		Button obj47 = cmdCalc101;
		location = new Point(112, 120);
		((Control)obj47).Location = location;
		((Control)cmdCalc101).Name = "cmdCalc101";
		((Control)cmdCalc101).RightToLeft = (RightToLeft)0;
		Button obj48 = cmdCalc101;
		size = new Size(193, 25);
		((Control)obj48).Size = size;
		((Control)cmdCalc101).TabIndex = 45;
		((ButtonBase)cmdCalc101).Text = "&Calculate DMIppaint";
		((ButtonBase)cmdCalc101).UseVisualStyleBackColor = false;
		((Control)_Label1_14).BackColor = SystemColors.Control;
		((Control)_Label1_14).Cursor = Cursors.Default;
		((Control)_Label1_14).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_14).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_14, (short)14);
		Label label1_45 = _Label1_14;
		location = new Point(40, 24);
		((Control)label1_45).Location = location;
		((Control)_Label1_14).Name = "_Label1_14";
		((Control)_Label1_14).RightToLeft = (RightToLeft)0;
		Label label1_46 = _Label1_14;
		size = new Size(257, 17);
		((Control)label1_46).Size = size;
		((Control)_Label1_14).TabIndex = 52;
		_Label1_14.Text = "DVIppaint";
		_Label1_14.TextAlign = (ContentAlignment)4;
		((Control)_Label1_12).BackColor = SystemColors.Control;
		((Control)_Label1_12).Cursor = Cursors.Default;
		((Control)_Label1_12).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_12).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_12, (short)12);
		Label label1_47 = _Label1_12;
		location = new Point(56, 48);
		((Control)label1_47).Location = location;
		((Control)_Label1_12).Name = "_Label1_12";
		((Control)_Label1_12).RightToLeft = (RightToLeft)0;
		Label label1_48 = _Label1_12;
		size = new Size(241, 17);
		((Control)label1_48).Size = size;
		((Control)_Label1_12).TabIndex = 51;
		_Label1_12.Text = "Dppaint (density of purchased paint, kg/L): ";
		_Label1_12.TextAlign = (ContentAlignment)4;
		((Control)_Label1_9).BackColor = SystemColors.Control;
		((Control)_Label1_9).Cursor = Cursors.Default;
		((Control)_Label1_9).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_9).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_9, (short)9);
		Label label1_49 = _Label1_9;
		location = new Point(24, 80);
		((Control)label1_49).Location = location;
		((Control)_Label1_9).Name = "_Label1_9";
		((Control)_Label1_9).RightToLeft = (RightToLeft)0;
		Label label1_50 = _Label1_9;
		size = new Size(273, 17);
		((Control)label1_50).Size = size;
		((Control)_Label1_9).TabIndex = 50;
		_Label1_9.Text = "DMIppaint";
		_Label1_9.TextAlign = (ContentAlignment)4;
		((Control)lblDMIppaint).BackColor = SystemColors.Control;
		lblDMIppaint.BorderStyle = (BorderStyle)2;
		((Control)lblDMIppaint).Cursor = Cursors.Default;
		((Control)lblDMIppaint).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblDMIppaint).ForeColor = SystemColors.ControlText;
		Label obj49 = lblDMIppaint;
		location = new Point(304, 80);
		((Control)obj49).Location = location;
		((Control)lblDMIppaint).Name = "lblDMIppaint";
		((Control)lblDMIppaint).RightToLeft = (RightToLeft)0;
		Label obj50 = lblDMIppaint;
		size = new Size(73, 19);
		((Control)obj50).Size = size;
		((Control)lblDMIppaint).TabIndex = 49;
		lblDMIppaint.TextAlign = (ContentAlignment)4;
		((Control)_Frame2_0).BackColor = SystemColors.Control;
		((Control)_Frame2_0).Controls.Add((Control)(object)_optMethod101_1);
		((Control)_Frame2_0).Controls.Add((Control)(object)txtUserInput101);
		((Control)_Frame2_0).Controls.Add((Control)(object)_Label1_8);
		((Control)_Frame2_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Frame2_0).ForeColor = SystemColors.ControlText;
		Frame2.SetIndex(_Frame2_0, (short)0);
		GroupBox frame2_5 = _Frame2_0;
		location = new Point(48, 264);
		((Control)frame2_5).Location = location;
		((Control)_Frame2_0).Name = "_Frame2_0";
		((Control)_Frame2_0).RightToLeft = (RightToLeft)0;
		GroupBox frame2_6 = _Frame2_0;
		size = new Size(433, 65);
		((Control)frame2_6).Size = size;
		((Control)_Frame2_0).TabIndex = 40;
		_Frame2_0.TabStop = false;
		_Frame2_0.Text = "DMIppaint = User input value";
		((ButtonBase)_optMethod101_1).BackColor = SystemColors.Control;
		((Control)_optMethod101_1).Cursor = Cursors.Default;
		((Control)_optMethod101_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optMethod101_1).ForeColor = SystemColors.ControlText;
		optMethod101.SetIndex(_optMethod101_1, (short)1);
		RadioButton optMethod101_3 = _optMethod101_1;
		location = new Point(16, 24);
		((Control)optMethod101_3).Location = location;
		((Control)_optMethod101_1).Name = "_optMethod101_1";
		((Control)_optMethod101_1).RightToLeft = (RightToLeft)0;
		RadioButton optMethod101_4 = _optMethod101_1;
		size = new Size(25, 17);
		((Control)optMethod101_4).Size = size;
		((Control)_optMethod101_1).TabIndex = 42;
		_optMethod101_1.TabStop = true;
		((ButtonBase)_optMethod101_1).UseVisualStyleBackColor = false;
		txtUserInput101.AcceptsReturn = true;
		((TextBoxBase)txtUserInput101).BackColor = SystemColors.Menu;
		((Control)txtUserInput101).Cursor = Cursors.IBeam;
		((Control)txtUserInput101).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtUserInput101).ForeColor = SystemColors.WindowText;
		TextBox obj51 = txtUserInput101;
		location = new Point(304, 24);
		((Control)obj51).Location = location;
		((TextBoxBase)txtUserInput101).MaxLength = 0;
		((Control)txtUserInput101).Name = "txtUserInput101";
		((TextBoxBase)txtUserInput101).ReadOnly = true;
		((Control)txtUserInput101).RightToLeft = (RightToLeft)0;
		TextBox obj52 = txtUserInput101;
		size = new Size(74, 20);
		((Control)obj52).Size = size;
		((Control)txtUserInput101).TabIndex = 41;
		((Control)_Label1_8).BackColor = SystemColors.Control;
		((Control)_Label1_8).Cursor = Cursors.Default;
		((Control)_Label1_8).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_8).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_8, (short)8);
		Label label1_51 = _Label1_8;
		location = new Point(64, 24);
		((Control)label1_51).Location = location;
		((Control)_Label1_8).Name = "_Label1_8";
		((Control)_Label1_8).RightToLeft = (RightToLeft)0;
		Label label1_52 = _Label1_8;
		size = new Size(233, 17);
		((Control)label1_52).Size = size;
		((Control)_Label1_8).TabIndex = 43;
		_Label1_8.Text = "DMIppaint";
		_Label1_8.TextAlign = (ContentAlignment)4;
		((Control)Label4).BackColor = SystemColors.Control;
		((Control)Label4).Cursor = Cursors.Default;
		((Control)Label4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label4).ForeColor = SystemColors.ControlText;
		Label label11 = Label4;
		location = new Point(16, 16);
		((Control)label11).Location = location;
		((Control)Label4).Name = "Label4";
		((Control)Label4).RightToLeft = (RightToLeft)0;
		Label label12 = Label4;
		size = new Size(497, 41);
		((Control)label12).Size = size;
		((Control)Label4).TabIndex = 53;
		Label4.Text = "View or change the method for deriving DMIppaint. Press &Restore Defaults to restore the original defaults for all parameters on this window. ";
		((ButtonBase)cmdOk).BackColor = SystemColors.Control;
		((Control)cmdOk).Cursor = Cursors.Default;
		((Control)cmdOk).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdOk).ForeColor = SystemColors.ControlText;
		Button obj53 = cmdOk;
		location = new Point(200, 408);
		((Control)obj53).Location = location;
		((Control)cmdOk).Name = "cmdOk";
		((Control)cmdOk).RightToLeft = (RightToLeft)0;
		Button obj54 = cmdOk;
		size = new Size(97, 25);
		((Control)obj54).Size = size;
		((Control)cmdOk).TabIndex = 38;
		((ButtonBase)cmdOk).Text = "OK";
		((ButtonBase)cmdOk).UseVisualStyleBackColor = false;
		((ButtonBase)cmdCancel).BackColor = SystemColors.Control;
		((Control)cmdCancel).Cursor = Cursors.Default;
		cmdCancel.DialogResult = (DialogResult)2;
		((Control)cmdCancel).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCancel).ForeColor = SystemColors.ControlText;
		Button obj55 = cmdCancel;
		location = new Point(312, 408);
		((Control)obj55).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		((Control)cmdCancel).RightToLeft = (RightToLeft)0;
		Button obj56 = cmdCancel;
		size = new Size(97, 25);
		((Control)obj56).Size = size;
		((Control)cmdCancel).TabIndex = 37;
		((ButtonBase)cmdCancel).Text = "Cancel";
		((ButtonBase)cmdCancel).UseVisualStyleBackColor = false;
		((ButtonBase)cmdRestore).BackColor = SystemColors.Control;
		((Control)cmdRestore).Cursor = Cursors.Default;
		((Control)cmdRestore).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdRestore).ForeColor = SystemColors.ControlText;
		Button obj57 = cmdRestore;
		location = new Point(424, 408);
		((Control)obj57).Location = location;
		((Control)cmdRestore).Name = "cmdRestore";
		((Control)cmdRestore).RightToLeft = (RightToLeft)0;
		Button obj58 = cmdRestore;
		size = new Size(97, 25);
		((Control)obj58).Size = size;
		((Control)cmdRestore).TabIndex = 36;
		((ButtonBase)cmdRestore).Text = "&Restore Defaults";
		((ButtonBase)cmdRestore).UseVisualStyleBackColor = false;
		((Control)_Label9_8).BackColor = SystemColors.Control;
		((Control)_Label9_8).Cursor = Cursors.Default;
		((Control)_Label9_8).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label9_8).ForeColor = SystemColors.ControlText;
		Label label9_ = _Label9_8;
		location = new Point(64, 280);
		((Control)label9_).Location = location;
		((Control)_Label9_8).Name = "_Label9_8";
		((Control)_Label9_8).RightToLeft = (RightToLeft)0;
		Label label9_2 = _Label9_8;
		size = new Size(201, 17);
		((Control)label9_2).Size = size;
		((Control)_Label9_8).TabIndex = 108;
		_Label9_8.Text = "Yrinse, weight fraction of chem in rinse water";
		((Control)_Label9_8).Visible = false;
		((Control)_Label9_6).BackColor = SystemColors.Control;
		((Control)_Label9_6).Cursor = Cursors.Default;
		((Control)_Label9_6).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label9_6).ForeColor = SystemColors.ControlText;
		Label label9_3 = _Label9_6;
		location = new Point(64, 240);
		((Control)label9_3).Location = location;
		((Control)_Label9_6).Name = "_Label9_6";
		((Control)_Label9_6).RightToLeft = (RightToLeft)0;
		Label label9_4 = _Label9_6;
		size = new Size(201, 17);
		((Control)label9_4).Size = size;
		((Control)_Label9_6).TabIndex = 109;
		_Label9_6.Text = "DVrinse, daily rinse water produced (gallons/day)";
		((Control)_Label9_6).Visible = false;
		((Control)lblInst).BackColor = SystemColors.Control;
		((Control)lblInst).Cursor = Cursors.Default;
		((Control)lblInst).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblInst).ForeColor = SystemColors.ControlText;
		Label obj59 = lblInst;
		location = new Point(8, 16);
		((Control)obj59).Location = location;
		((Control)lblInst).Name = "lblInst";
		((Control)lblInst).RightToLeft = (RightToLeft)0;
		Label obj60 = lblInst;
		size = new Size(705, 65);
		((Control)obj60).Size = size;
		((Control)lblInst).TabIndex = 110;
		lblInst.Text = componentResourceManager.GetString("lblInst.Text");
		((Control)Label8).BackColor = SystemColors.Control;
		((Control)Label8).Cursor = Cursors.Default;
		((Control)Label8).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label8).ForeColor = SystemColors.ControlText;
		Label label13 = Label8;
		location = new Point(8, 88);
		((Control)label13).Location = location;
		((Control)Label8).Name = "Label8";
		((Control)Label8).RightToLeft = (RightToLeft)0;
		Label label14 = Label8;
		size = new Size(657, 17);
		((Control)label14).Size = size;
		((Control)Label8).TabIndex = 111;
		Label8.Text = "ADMUchem = [(Vbath x Nbath x Freqbath x Dbath x 3.78 L/gal x Ybath / OD) + (DVrinse x Drinse x 3.78 L/gal x Yrinse x (1 - RinseE))]";
		((Control)_Label9_1).BackColor = SystemColors.Control;
		((Control)_Label9_1).Cursor = Cursors.Default;
		((Control)_Label9_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label9_1).ForeColor = SystemColors.ControlText;
		Label label9_5 = _Label9_1;
		location = new Point(64, 131);
		((Control)label9_5).Location = location;
		((Control)_Label9_1).Name = "_Label9_1";
		((Control)_Label9_1).RightToLeft = (RightToLeft)0;
		Label label9_6 = _Label9_1;
		size = new Size(201, 17);
		((Control)label9_6).Size = size;
		((Control)_Label9_1).TabIndex = 112;
		_Label9_1.Text = "Nbath, number of tanks/site (tanks/site)";
		((Control)_Label9_2).BackColor = SystemColors.Control;
		((Control)_Label9_2).Cursor = Cursors.Default;
		((Control)_Label9_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label9_2).ForeColor = SystemColors.ControlText;
		Label label9_7 = _Label9_2;
		location = new Point(64, 150);
		((Control)label9_7).Location = location;
		((Control)_Label9_2).Name = "_Label9_2";
		((Control)_Label9_2).RightToLeft = (RightToLeft)0;
		Label label9_8 = _Label9_2;
		size = new Size(265, 17);
		((Control)label9_8).Size = size;
		((Control)_Label9_2).TabIndex = 113;
		_Label9_2.Text = "Freqbath, frequency of bath discharge (changes/yr)";
		((Control)_Label9_3).BackColor = SystemColors.Control;
		((Control)_Label9_3).Cursor = Cursors.Default;
		((Control)_Label9_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label9_3).ForeColor = SystemColors.ControlText;
		Label label9_9 = _Label9_3;
		location = new Point(64, 169);
		((Control)label9_9).Location = location;
		((Control)_Label9_3).Name = "_Label9_3";
		((Control)_Label9_3).RightToLeft = (RightToLeft)0;
		Label label9_10 = _Label9_3;
		size = new Size(201, 17);
		((Control)label9_10).Size = size;
		((Control)_Label9_3).TabIndex = 114;
		_Label9_3.Text = "Dbath, density of the bath (kg/L)";
		((Control)_Label9_4).BackColor = SystemColors.Control;
		((Control)_Label9_4).Cursor = Cursors.Default;
		((Control)_Label9_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label9_4).ForeColor = SystemColors.ControlText;
		Label label9_11 = _Label9_4;
		location = new Point(64, 188);
		((Control)label9_11).Location = location;
		((Control)_Label9_4).Name = "_Label9_4";
		((Control)_Label9_4).RightToLeft = (RightToLeft)0;
		Label label9_12 = _Label9_4;
		size = new Size(201, 17);
		((Control)label9_12).Size = size;
		((Control)_Label9_4).TabIndex = 115;
		_Label9_4.Text = "Ybath, weight fraction of chem in bath";
		((Control)_Label9_5).BackColor = SystemColors.Control;
		((Control)_Label9_5).Cursor = Cursors.Default;
		((Control)_Label9_5).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label9_5).ForeColor = SystemColors.ControlText;
		Label label9_13 = _Label9_5;
		location = new Point(64, 207);
		((Control)label9_13).Location = location;
		((Control)_Label9_5).Name = "_Label9_5";
		((Control)_Label9_5).RightToLeft = (RightToLeft)0;
		Label label9_14 = _Label9_5;
		size = new Size(201, 17);
		((Control)label9_14).Size = size;
		((Control)_Label9_5).TabIndex = 116;
		_Label9_5.Text = "OD, annual operating days (days/yr)";
		((Control)_Label9_7).BackColor = SystemColors.Control;
		((Control)_Label9_7).Cursor = Cursors.Default;
		((Control)_Label9_7).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label9_7).ForeColor = SystemColors.ControlText;
		Label label9_15 = _Label9_7;
		location = new Point(64, 259);
		((Control)label9_15).Location = location;
		((Control)_Label9_7).Name = "_Label9_7";
		((Control)_Label9_7).RightToLeft = (RightToLeft)0;
		Label label9_16 = _Label9_7;
		size = new Size(201, 17);
		((Control)label9_16).Size = size;
		((Control)_Label9_7).TabIndex = 117;
		_Label9_7.Text = "Drinse, density of rinse water (kg/L)";
		((Control)_Label9_9).BackColor = SystemColors.Control;
		((Control)_Label9_9).Cursor = Cursors.Default;
		((Control)_Label9_9).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label9_9).ForeColor = SystemColors.ControlText;
		Label label9_17 = _Label9_9;
		location = new Point(64, 297);
		((Control)label9_17).Location = location;
		((Control)_Label9_9).Name = "_Label9_9";
		((Control)_Label9_9).RightToLeft = (RightToLeft)0;
		Label label9_18 = _Label9_9;
		size = new Size(305, 17);
		((Control)label9_18).Size = size;
		((Control)_Label9_9).TabIndex = 118;
		_Label9_9.Text = "RinseE, removal efficiency of chem from rinse water";
		((Control)_Label9_10).BackColor = SystemColors.Control;
		((Control)_Label9_10).Cursor = Cursors.Default;
		((Control)_Label9_10).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label9_10).ForeColor = SystemColors.ControlText;
		Label label9_19 = _Label9_10;
		location = new Point(64, 316);
		((Control)label9_19).Location = location;
		((Control)_Label9_10).Name = "_Label9_10";
		((Control)_Label9_10).RightToLeft = (RightToLeft)0;
		Label label9_20 = _Label9_10;
		size = new Size(313, 17);
		((Control)label9_20).Size = size;
		((Control)_Label9_10).TabIndex = 119;
		_Label9_10.Text = "ADMUchem, average daily mass of chemical used (kg/site-day)";
		((Control)lblWarning).BackColor = SystemColors.Control;
		((Control)lblWarning).Cursor = Cursors.Default;
		((Control)lblWarning).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblWarning).ForeColor = SystemColors.ControlText;
		Label obj61 = lblWarning;
		location = new Point(8, 376);
		((Control)obj61).Location = location;
		((Control)lblWarning).Name = "lblWarning";
		((Control)lblWarning).RightToLeft = (RightToLeft)0;
		Label obj62 = lblWarning;
		size = new Size(489, 17);
		((Control)obj62).Size = size;
		((Control)lblWarning).TabIndex = 120;
		lblWarning.Text = "Parameters should be adjusted such that ADMUchem is increased and/or DVrinse is decreased.";
		((Control)lblWarning).Visible = false;
		((Control)_Label9_0).BackColor = SystemColors.Control;
		((Control)_Label9_0).Cursor = Cursors.Default;
		((Control)_Label9_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label9_0).ForeColor = SystemColors.ControlText;
		Label label9_21 = _Label9_0;
		location = new Point(64, 112);
		((Control)label9_21).Location = location;
		((Control)_Label9_0).Name = "_Label9_0";
		((Control)_Label9_0).RightToLeft = (RightToLeft)0;
		Label label9_22 = _Label9_0;
		size = new Size(201, 17);
		((Control)label9_22).Size = size;
		((Control)_Label9_0).TabIndex = 121;
		_Label9_0.Text = "Vbath, bath tank volume (gallons/tank)";
		((Control)_Label9_0).Visible = false;
		((ButtonBase)_chkFix_0).BackColor = SystemColors.Control;
		_chkFix_0.CheckAlign = (ContentAlignment)64;
		((Control)_chkFix_0).Cursor = Cursors.Default;
		((Control)_chkFix_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_chkFix_0).ForeColor = SystemColors.ControlText;
		CheckBox chkFix_ = _chkFix_0;
		location = new Point(62, 112);
		((Control)chkFix_).Location = location;
		((Control)_chkFix_0).Name = "_chkFix_0";
		((Control)_chkFix_0).RightToLeft = (RightToLeft)0;
		CheckBox chkFix_2 = _chkFix_0;
		size = new Size(329, 17);
		((Control)chkFix_2).Size = size;
		((Control)_chkFix_0).TabIndex = 93;
		((ButtonBase)_chkFix_0).Text = "Vbath, bath tank volume (gallons/tank)";
		((ButtonBase)_chkFix_0).UseVisualStyleBackColor = false;
		((ButtonBase)_chkFix_6).BackColor = SystemColors.Control;
		_chkFix_6.CheckAlign = (ContentAlignment)64;
		((Control)_chkFix_6).Cursor = Cursors.Default;
		((Control)_chkFix_6).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_chkFix_6).ForeColor = SystemColors.ControlText;
		CheckBox chkFix_3 = _chkFix_6;
		location = new Point(62, 240);
		((Control)chkFix_3).Location = location;
		((Control)_chkFix_6).Name = "_chkFix_6";
		((Control)_chkFix_6).RightToLeft = (RightToLeft)0;
		CheckBox chkFix_4 = _chkFix_6;
		size = new Size(329, 17);
		((Control)chkFix_4).Size = size;
		((Control)_chkFix_6).TabIndex = 94;
		((ButtonBase)_chkFix_6).Text = "DVrinse, daily rinse water produced (gallons/day)";
		((ButtonBase)_chkFix_6).UseVisualStyleBackColor = false;
		((ButtonBase)_chkFix_8).BackColor = SystemColors.Control;
		_chkFix_8.CheckAlign = (ContentAlignment)64;
		((Control)_chkFix_8).Cursor = Cursors.Default;
		((Control)_chkFix_8).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_chkFix_8).ForeColor = SystemColors.ControlText;
		CheckBox chkFix_5 = _chkFix_8;
		location = new Point(62, 278);
		((Control)chkFix_5).Location = location;
		((Control)_chkFix_8).Name = "_chkFix_8";
		((Control)_chkFix_8).RightToLeft = (RightToLeft)0;
		CheckBox chkFix_6 = _chkFix_8;
		size = new Size(329, 17);
		((Control)chkFix_6).Size = size;
		((Control)_chkFix_8).TabIndex = 95;
		((ButtonBase)_chkFix_8).Text = "Yrinse, weight fraction of chem in rinse water";
		((ButtonBase)_chkFix_8).UseVisualStyleBackColor = false;
		_txt104_0.AcceptsReturn = true;
		((TextBoxBase)_txt104_0).BackColor = Color.FromArgb(192, 192, 192);
		((Control)_txt104_0).Cursor = Cursors.IBeam;
		((Control)_txt104_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txt104_0).ForeColor = SystemColors.WindowText;
		TextBox txt104_ = _txt104_0;
		location = new Point(584, 112);
		((Control)txt104_).Location = location;
		((TextBoxBase)_txt104_0).MaxLength = 0;
		((Control)_txt104_0).Name = "_txt104_0";
		((TextBoxBase)_txt104_0).ReadOnly = true;
		((Control)_txt104_0).RightToLeft = (RightToLeft)0;
		TextBox txt104_2 = _txt104_0;
		size = new Size(74, 20);
		((Control)txt104_2).Size = size;
		((Control)_txt104_0).TabIndex = 96;
		_txt104_1.AcceptsReturn = true;
		((TextBoxBase)_txt104_1).BackColor = SystemColors.Window;
		((Control)_txt104_1).Cursor = Cursors.IBeam;
		((Control)_txt104_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txt104_1).ForeColor = SystemColors.WindowText;
		TextBox txt104_3 = _txt104_1;
		location = new Point(584, 131);
		((Control)txt104_3).Location = location;
		((TextBoxBase)_txt104_1).MaxLength = 0;
		((Control)_txt104_1).Name = "_txt104_1";
		((Control)_txt104_1).RightToLeft = (RightToLeft)0;
		TextBox txt104_4 = _txt104_1;
		size = new Size(74, 20);
		((Control)txt104_4).Size = size;
		((Control)_txt104_1).TabIndex = 97;
		_txt104_2.AcceptsReturn = true;
		((TextBoxBase)_txt104_2).BackColor = SystemColors.Window;
		((Control)_txt104_2).Cursor = Cursors.IBeam;
		((Control)_txt104_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txt104_2).ForeColor = SystemColors.WindowText;
		TextBox txt104_5 = _txt104_2;
		location = new Point(584, 150);
		((Control)txt104_5).Location = location;
		((TextBoxBase)_txt104_2).MaxLength = 0;
		((Control)_txt104_2).Name = "_txt104_2";
		((Control)_txt104_2).RightToLeft = (RightToLeft)0;
		TextBox txt104_6 = _txt104_2;
		size = new Size(74, 20);
		((Control)txt104_6).Size = size;
		((Control)_txt104_2).TabIndex = 98;
		_txt104_3.AcceptsReturn = true;
		((TextBoxBase)_txt104_3).BackColor = SystemColors.Window;
		((Control)_txt104_3).Cursor = Cursors.IBeam;
		((Control)_txt104_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txt104_3).ForeColor = SystemColors.WindowText;
		TextBox txt104_7 = _txt104_3;
		location = new Point(584, 169);
		((Control)txt104_7).Location = location;
		((TextBoxBase)_txt104_3).MaxLength = 0;
		((Control)_txt104_3).Name = "_txt104_3";
		((Control)_txt104_3).RightToLeft = (RightToLeft)0;
		TextBox txt104_8 = _txt104_3;
		size = new Size(74, 20);
		((Control)txt104_8).Size = size;
		((Control)_txt104_3).TabIndex = 99;
		_txt104_4.AcceptsReturn = true;
		((TextBoxBase)_txt104_4).BackColor = SystemColors.Window;
		((Control)_txt104_4).Cursor = Cursors.IBeam;
		((Control)_txt104_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txt104_4).ForeColor = SystemColors.WindowText;
		TextBox txt104_9 = _txt104_4;
		location = new Point(584, 188);
		((Control)txt104_9).Location = location;
		((TextBoxBase)_txt104_4).MaxLength = 0;
		((Control)_txt104_4).Name = "_txt104_4";
		((Control)_txt104_4).RightToLeft = (RightToLeft)0;
		TextBox txt104_10 = _txt104_4;
		size = new Size(74, 20);
		((Control)txt104_10).Size = size;
		((Control)_txt104_4).TabIndex = 100;
		_txt104_5.AcceptsReturn = true;
		((TextBoxBase)_txt104_5).BackColor = Color.FromArgb(192, 192, 192);
		((Control)_txt104_5).Cursor = Cursors.IBeam;
		((Control)_txt104_5).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txt104_5).ForeColor = SystemColors.WindowText;
		TextBox txt104_11 = _txt104_5;
		location = new Point(584, 207);
		((Control)txt104_11).Location = location;
		((TextBoxBase)_txt104_5).MaxLength = 0;
		((Control)_txt104_5).Name = "_txt104_5";
		((TextBoxBase)_txt104_5).ReadOnly = true;
		((Control)_txt104_5).RightToLeft = (RightToLeft)0;
		TextBox txt104_12 = _txt104_5;
		size = new Size(74, 20);
		((Control)txt104_12).Size = size;
		((Control)_txt104_5).TabIndex = 101;
		_txt104_6.AcceptsReturn = true;
		((TextBoxBase)_txt104_6).BackColor = Color.FromArgb(192, 192, 192);
		((Control)_txt104_6).Cursor = Cursors.IBeam;
		((Control)_txt104_6).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txt104_6).ForeColor = SystemColors.WindowText;
		TextBox txt104_13 = _txt104_6;
		location = new Point(584, 240);
		((Control)txt104_13).Location = location;
		((TextBoxBase)_txt104_6).MaxLength = 0;
		((Control)_txt104_6).Name = "_txt104_6";
		((TextBoxBase)_txt104_6).ReadOnly = true;
		((Control)_txt104_6).RightToLeft = (RightToLeft)0;
		TextBox txt104_14 = _txt104_6;
		size = new Size(74, 20);
		((Control)txt104_14).Size = size;
		((Control)_txt104_6).TabIndex = 102;
		_txt104_7.AcceptsReturn = true;
		((TextBoxBase)_txt104_7).BackColor = SystemColors.Window;
		((Control)_txt104_7).Cursor = Cursors.IBeam;
		((Control)_txt104_7).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txt104_7).ForeColor = SystemColors.WindowText;
		TextBox txt104_15 = _txt104_7;
		location = new Point(584, 259);
		((Control)txt104_15).Location = location;
		((TextBoxBase)_txt104_7).MaxLength = 0;
		((Control)_txt104_7).Name = "_txt104_7";
		((Control)_txt104_7).RightToLeft = (RightToLeft)0;
		TextBox txt104_16 = _txt104_7;
		size = new Size(74, 20);
		((Control)txt104_16).Size = size;
		((Control)_txt104_7).TabIndex = 103;
		_txt104_8.AcceptsReturn = true;
		((TextBoxBase)_txt104_8).BackColor = Color.FromArgb(192, 192, 192);
		((Control)_txt104_8).Cursor = Cursors.IBeam;
		((Control)_txt104_8).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txt104_8).ForeColor = SystemColors.WindowText;
		TextBox txt104_17 = _txt104_8;
		location = new Point(584, 278);
		((Control)txt104_17).Location = location;
		((TextBoxBase)_txt104_8).MaxLength = 0;
		((Control)_txt104_8).Name = "_txt104_8";
		((TextBoxBase)_txt104_8).ReadOnly = true;
		((Control)_txt104_8).RightToLeft = (RightToLeft)0;
		TextBox txt104_18 = _txt104_8;
		size = new Size(74, 20);
		((Control)txt104_18).Size = size;
		((Control)_txt104_8).TabIndex = 104;
		_txt104_9.AcceptsReturn = true;
		((TextBoxBase)_txt104_9).BackColor = SystemColors.Window;
		((Control)_txt104_9).Cursor = Cursors.IBeam;
		((Control)_txt104_9).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txt104_9).ForeColor = SystemColors.WindowText;
		TextBox txt104_19 = _txt104_9;
		location = new Point(584, 297);
		((Control)txt104_19).Location = location;
		((TextBoxBase)_txt104_9).MaxLength = 0;
		((Control)_txt104_9).Name = "_txt104_9";
		((Control)_txt104_9).RightToLeft = (RightToLeft)0;
		TextBox txt104_20 = _txt104_9;
		size = new Size(74, 20);
		((Control)txt104_20).Size = size;
		((Control)_txt104_9).TabIndex = 105;
		_txt104_10.AcceptsReturn = true;
		((TextBoxBase)_txt104_10).BackColor = Color.FromArgb(192, 192, 192);
		((Control)_txt104_10).Cursor = Cursors.IBeam;
		((Control)_txt104_10).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txt104_10).ForeColor = SystemColors.WindowText;
		TextBox txt104_21 = _txt104_10;
		location = new Point(584, 316);
		((Control)txt104_21).Location = location;
		((TextBoxBase)_txt104_10).MaxLength = 0;
		((Control)_txt104_10).Name = "_txt104_10";
		((TextBoxBase)_txt104_10).ReadOnly = true;
		((Control)_txt104_10).RightToLeft = (RightToLeft)0;
		TextBox txt104_22 = _txt104_10;
		size = new Size(74, 20);
		((Control)txt104_22).Size = size;
		((Control)_txt104_10).TabIndex = 106;
		((ButtonBase)cmdCalc104).BackColor = SystemColors.Control;
		((Control)cmdCalc104).Cursor = Cursors.Default;
		((Control)cmdCalc104).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCalc104).ForeColor = SystemColors.ControlText;
		Button obj63 = cmdCalc104;
		location = new Point(64, 344);
		((Control)obj63).Location = location;
		((Control)cmdCalc104).Name = "cmdCalc104";
		((Control)cmdCalc104).RightToLeft = (RightToLeft)0;
		Button obj64 = cmdCalc104;
		size = new Size(137, 25);
		((Control)obj64).Size = size;
		((Control)cmdCalc104).TabIndex = 107;
		((ButtonBase)cmdCalc104).Text = "&Update Mass Balance";
		((ButtonBase)cmdCalc104).UseVisualStyleBackColor = false;
		((Control)_fraGSS_4).BackColor = SystemColors.Control;
		((Control)_fraGSS_4).Controls.Add((Control)(object)cmdCalc104);
		((Control)_fraGSS_4).Controls.Add((Control)(object)_txt104_10);
		((Control)_fraGSS_4).Controls.Add((Control)(object)_txt104_9);
		((Control)_fraGSS_4).Controls.Add((Control)(object)_txt104_8);
		((Control)_fraGSS_4).Controls.Add((Control)(object)_txt104_7);
		((Control)_fraGSS_4).Controls.Add((Control)(object)_txt104_6);
		((Control)_fraGSS_4).Controls.Add((Control)(object)_txt104_5);
		((Control)_fraGSS_4).Controls.Add((Control)(object)_txt104_4);
		((Control)_fraGSS_4).Controls.Add((Control)(object)_txt104_3);
		((Control)_fraGSS_4).Controls.Add((Control)(object)_txt104_2);
		((Control)_fraGSS_4).Controls.Add((Control)(object)_txt104_1);
		((Control)_fraGSS_4).Controls.Add((Control)(object)_txt104_0);
		((Control)_fraGSS_4).Controls.Add((Control)(object)_chkFix_8);
		((Control)_fraGSS_4).Controls.Add((Control)(object)_chkFix_6);
		((Control)_fraGSS_4).Controls.Add((Control)(object)_chkFix_0);
		((Control)_fraGSS_4).Controls.Add((Control)(object)_Label9_0);
		((Control)_fraGSS_4).Controls.Add((Control)(object)lblWarning);
		((Control)_fraGSS_4).Controls.Add((Control)(object)_Label9_10);
		((Control)_fraGSS_4).Controls.Add((Control)(object)_Label9_9);
		((Control)_fraGSS_4).Controls.Add((Control)(object)_Label9_7);
		((Control)_fraGSS_4).Controls.Add((Control)(object)_Label9_5);
		((Control)_fraGSS_4).Controls.Add((Control)(object)_Label9_4);
		((Control)_fraGSS_4).Controls.Add((Control)(object)_Label9_3);
		((Control)_fraGSS_4).Controls.Add((Control)(object)_Label9_2);
		((Control)_fraGSS_4).Controls.Add((Control)(object)_Label9_1);
		((Control)_fraGSS_4).Controls.Add((Control)(object)Label8);
		((Control)_fraGSS_4).Controls.Add((Control)(object)lblInst);
		((Control)_fraGSS_4).Controls.Add((Control)(object)_Label9_6);
		((Control)_fraGSS_4).Controls.Add((Control)(object)_Label9_8);
		((Control)_fraGSS_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_fraGSS_4).ForeColor = SystemColors.ControlText;
		GroupBox fraGSS_9 = _fraGSS_4;
		location = new Point(0, 8);
		((Control)fraGSS_9).Location = location;
		((Control)_fraGSS_4).Name = "_fraGSS_4";
		((Control)_fraGSS_4).RightToLeft = (RightToLeft)0;
		GroupBox fraGSS_10 = _fraGSS_4;
		size = new Size(721, 387);
		((Control)fraGSS_10).Size = size;
		((Control)_fraGSS_4).TabIndex = 92;
		_fraGSS_4.TabStop = false;
		((Control)_fraGSS_4).Visible = false;
		((Form)this).AcceptButton = (IButtonControl)(object)cmdOk;
		size = new Size(5, 13);
		((Form)this).AutoScaleBaseSize = size;
		((Form)this).BackColor = SystemColors.Control;
		((Form)this).CancelButton = (IButtonControl)(object)cmdCancel;
		size = new Size(743, 473);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)cmdOk);
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)cmdRestore);
		((Control)this).Controls.Add((Control)(object)_fraGSS_3);
		((Control)this).Controls.Add((Control)(object)_fraGSS_1);
		((Control)this).Controls.Add((Control)(object)_fraGSS_0);
		((Control)this).Controls.Add((Control)(object)_fraGSS_2);
		((Control)this).Controls.Add((Control)(object)_fraGSS_4);
		((Control)this).Cursor = Cursors.Default;
		((Control)this).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		location = new Point(250, 150);
		((Form)this).Location = location;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmMDCalcXmoProd";
		((Control)this).RightToLeft = (RightToLeft)0;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = " ";
		((Control)_fraGSS_3).ResumeLayout(false);
		((Control)Frame4).ResumeLayout(false);
		((Control)Frame4).PerformLayout();
		((Control)Frame3).ResumeLayout(false);
		((Control)Frame3).PerformLayout();
		((Control)_Frame2_2).ResumeLayout(false);
		((Control)_Frame2_2).PerformLayout();
		((Control)_j_1).ResumeLayout(false);
		((Control)_j_1).PerformLayout();
		((Control)_fraGSS_1).ResumeLayout(false);
		((Control)_Frame2_1).ResumeLayout(false);
		((Control)_Frame2_1).PerformLayout();
		((Control)_frame1_3).ResumeLayout(false);
		((Control)_frame1_3).PerformLayout();
		((Control)_fraGSS_0).ResumeLayout(false);
		((Control)_j_0).ResumeLayout(false);
		((Control)_j_0).PerformLayout();
		((Control)_jj_1).ResumeLayout(false);
		((Control)_jj_1).PerformLayout();
		((Control)_fraGSS_2).ResumeLayout(false);
		((Control)_j_2).ResumeLayout(false);
		((Control)_j_2).PerformLayout();
		((Control)_Frame2_0).ResumeLayout(false);
		((Control)_Frame2_0).PerformLayout();
		((ISupportInitialize)Frame2).EndInit();
		((ISupportInitialize)Label1).EndInit();
		((ISupportInitialize)Label9).EndInit();
		((ISupportInitialize)chkFix).EndInit();
		((ISupportInitialize)fraGSS).EndInit();
		((ISupportInitialize)frame1).EndInit();
		((ISupportInitialize)j).EndInit();
		((ISupportInitialize)jj).EndInit();
		((ISupportInitialize)lblDmuPaint).EndInit();
		((ISupportInitialize)optMethod).EndInit();
		((ISupportInitialize)optMethod101).EndInit();
		((ISupportInitialize)optMethod102).EndInit();
		((ISupportInitialize)optMethod103).EndInit();
		((ISupportInitialize)txtDMUchem).EndInit();
		((ISupportInitialize)txtDRRchem).EndInit();
		((ISupportInitialize)txtDprod).EndInit();
		((Control)_fraGSS_4).ResumeLayout(false);
		((Control)_fraGSS_4).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void chkFix_CheckStateChanged(object eventSender, EventArgs eventArgs)
	{
	}

	private void cmdCalc_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		if (_optMethod_0.Checked)
		{
			if (Versioned.IsNumeric((object)txtVcar.Text) & Versioned.IsNumeric((object)_txtDprod_0.Text) & Versioned.IsNumeric((object)txtNcar.Text))
			{
				_lblDmuPaint_0.Text = Conversions.ToString(Conversions.ToDouble(txtVcar.Text) * Conversions.ToDouble(_txtDprod_0.Text) * Conversions.ToDouble(txtNcar.Text));
				bool bValue = false;
				SetButtons(ref bValue);
			}
			else
			{
				Interaction.MsgBox((object)"Please specify all parameters before pressing the Calculate button.", (MsgBoxStyle)64, (object)null);
			}
		}
		else if (_optMethod_1.Checked)
		{
			if (Versioned.IsNumeric((object)txtVpaint.Text) & Versioned.IsNumeric((object)_txtDprod_1.Text))
			{
				_lblDmuPaint_1.Text = Conversions.ToString(Conversions.ToDouble(txtVpaint.Text) * Conversions.ToDouble(_txtDprod_1.Text) * 3.785);
				bool bValue = false;
				SetButtons(ref bValue);
			}
			else
			{
				Interaction.MsgBox((object)"Please specify all parameters before pressing the Calculate button.", (MsgBoxStyle)64, (object)null);
			}
		}
		else
		{
			Interaction.MsgBox((object)"Please specify which method you wish to use", (MsgBoxStyle)64, (object)null);
		}
	}

	private void cmdCalc101_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		if (_optMethod101_0.Checked)
		{
			if (Versioned.IsNumeric((object)txtDVIppaint.Text) & Versioned.IsNumeric((object)txtDppaint.Text))
			{
				lblDMIppaint.Text = Conversions.ToString(Conversions.ToDouble(txtDVIppaint.Text) * Conversions.ToDouble(txtDppaint.Text));
				bool bValue = false;
				SetButtons(ref bValue);
			}
			else
			{
				Interaction.MsgBox((object)"Please specify all parameters before pressing the Calculate button.", (MsgBoxStyle)64, (object)null);
			}
		}
	}

	private void cmdCalc103_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		if (_optMethod103_0.Checked)
		{
			if (Versioned.IsNumeric((object)txtRRctw.Text) & Versioned.IsNumeric((object)txtYctw.Text) & Versioned.IsNumeric((object)txtHD.Text) & Versioned.IsNumeric((object)txtDctw.Text))
			{
				_txtDRRchem_0.Text = ChemStrX.ShowInSciNot(Conversions.ToDouble(txtRRctw.Text) * Conversions.ToDouble(txtYctw.Text) * Conversions.ToDouble(txtHD.Text) * Conversions.ToDouble(txtDctw.Text) * 60.0);
				if (Versioned.IsNumeric((object)txtLFb.Text) & Versioned.IsNumeric((object)txtLFw.Text) & Versioned.IsNumeric((object)txtLFe.Text) & Versioned.IsNumeric((object)txtDRRchem[(short)0].Text))
				{
					_txtDMUchem_0.Text = ChemStrX.ShowInSciNot((Conversions.ToDouble(txtLFb.Text) + Conversions.ToDouble(txtLFw.Text) + Conversions.ToDouble(txtLFe.Text)) * Conversions.ToDouble(_txtDRRchem_0.Text));
					bool bValue = false;
					SetButtons(ref bValue);
				}
				else
				{
					Interaction.MsgBox((object)"Please specify all parameters before pressing the Calculate button.", (MsgBoxStyle)64, (object)null);
				}
			}
			else
			{
				Interaction.MsgBox((object)"Please specify all parameters before pressing the Calculate button.", (MsgBoxStyle)64, (object)null);
			}
		}
		else if (Versioned.IsNumeric((object)txtLFb.Text) & Versioned.IsNumeric((object)txtLFw.Text) & Versioned.IsNumeric((object)txtLFe.Text) & Versioned.IsNumeric((object)_txtDMUchem_1.Text))
		{
			float num = Conversions.ToSingle(txtLFb.Text) + Conversions.ToSingle(txtLFw.Text) + Conversions.ToSingle(txtLFe.Text);
			if (num > 0f)
			{
				_txtDRRchem_1.Text = ChemStrX.ShowInSciNot(Conversions.ToSingle(_txtDMUchem_1.Text) / num);
				bool bValue = false;
				SetButtons(ref bValue);
			}
			else
			{
				Interaction.MsgBox((object)"The sum of LFb, LFw, and LFe must be greater then zero.", (MsgBoxStyle)64, (object)null);
			}
		}
		else
		{
			Interaction.MsgBox((object)"Please specify all parameters before pressing the Calculate button.", (MsgBoxStyle)64, (object)null);
		}
	}

	private void cmdCalc104_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		short num5 = default(short);
		string text = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				bool bValue;
				short num6;
				short num7;
				switch (try0001_dispatch)
				{
				default:
					num = 1;
					sWarning = "";
					goto IL_000f;
				case 1734:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0001;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000f;
						case 3:
							goto IL_0018;
						case 4:
							goto IL_001d;
						case 5:
							goto IL_0056;
						case 6:
							goto IL_005f;
						case 7:
							goto IL_0089;
						case 8:
							goto IL_00a5;
						case 9:
							goto IL_00c6;
						case 10:
							goto IL_00f5;
						case 12:
						case 13:
							goto IL_0126;
						case 14:
							goto IL_013c;
						case 15:
							goto IL_0169;
						case 16:
							goto IL_0196;
						case 17:
							goto IL_01c3;
						case 18:
							goto IL_01f0;
						case 19:
							goto IL_021d;
						case 20:
							goto IL_024b;
						case 21:
							goto IL_0278;
						case 22:
							goto IL_02a5;
						case 23:
							goto IL_02d2;
						case 24:
							goto IL_02ff;
						case 25:
							goto IL_032d;
						case 26:
							goto IL_034c;
						case 27:
							goto IL_0366;
						case 28:
							goto IL_0380;
						case 29:
							goto IL_039a;
						case 30:
							goto IL_03b8;
						case 31:
							goto IL_03dc;
						case 32:
							goto IL_0400;
						case 33:
							goto IL_0424;
						case 34:
							goto IL_0448;
						case 35:
							goto IL_047f;
						case 36:
							goto IL_04a4;
						case 37:
							goto IL_04c8;
						case 38:
							goto IL_04ec;
						case 39:
							goto IL_0523;
						case 40:
							goto IL_0547;
						case 41:
							goto IL_0571;
						case 42:
							goto IL_0595;
						case 43:
							goto IL_05a9;
						case 45:
							goto IL_05bb;
						case 46:
							goto IL_05c0;
						case 44:
						case 47:
						case 48:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 11:
						case 49:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_05a9:
					num = 43;
					bValue = true;
					SetButtons(ref bValue);
					break;
					IL_05bb:
					num = 45;
					goto IL_05c0;
					IL_0595:
					num = 42;
					if (frmMDUpdOpIP.DefInstance.bElecError)
					{
						goto IL_05a9;
					}
					goto IL_05bb;
					IL_05c0:
					num = 46;
					bValue = false;
					SetButtons(ref bValue);
					break;
					IL_000f:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0018;
					IL_0018:
					num = 3;
					num5 = 0;
					goto IL_001d;
					IL_001d:
					num = 4;
					if (!Versioned.IsNumeric((object)((Control)_fraGSS_4).Controls["_txt104_" + Conversions.ToString((int)num5)].Text))
					{
						goto IL_0056;
					}
					goto IL_0126;
					IL_0056:
					num = 5;
					Interaction.Beep();
					goto IL_005f;
					IL_005f:
					num = 6;
					text = ((Control)_fraGSS_4).Controls["_Label9_" + Conversions.ToString((int)num5)].Text;
					goto IL_0089;
					IL_0089:
					num = 7;
					text = Strings.Mid(text, 1, checked(Strings.InStr(text, ",", (CompareMethod)0) - 1));
					goto IL_00a5;
					IL_00a5:
					num = 8;
					Interaction.MsgBox((object)("Please specify a valid value for " + text + ".  This parameter must be numeric."), (MsgBoxStyle)64, (object)"Required Information Missing");
					goto IL_00c6;
					IL_00c6:
					num = 9;
					((Control)_fraGSS_4).Controls["_txt104_" + Conversions.ToString((int)num5)].Text = "";
					goto IL_00f5;
					IL_00f5:
					num = 10;
					((Control)_fraGSS_4).Controls["_txt104_" + Conversions.ToString((int)num5)].Focus();
					goto end_IL_0001_3;
					IL_0126:
					num = 13;
					num5 = checked((short)unchecked(num5 + 1));
					num6 = num5;
					num7 = 10;
					if (num6 <= num7)
					{
						goto IL_001d;
					}
					goto IL_013c;
					IL_013c:
					num = 14;
					frmMDUpdOpIP.DefInstance.sVbath = Conversions.ToSingle(((Control)_fraGSS_4).Controls["_txt104_0"].Text);
					goto IL_0169;
					IL_0169:
					num = 15;
					frmMDUpdOpIP.DefInstance.sNbath = Conversions.ToSingle(((Control)_fraGSS_4).Controls["_txt104_1"].Text);
					goto IL_0196;
					IL_0196:
					num = 16;
					frmMDUpdOpIP.DefInstance.sFreqbath = Conversions.ToSingle(((Control)_fraGSS_4).Controls["_txt104_2"].Text);
					goto IL_01c3;
					IL_01c3:
					num = 17;
					frmMDUpdOpIP.DefInstance.sDbath = Conversions.ToSingle(((Control)_fraGSS_4).Controls["_txt104_3"].Text);
					goto IL_01f0;
					IL_01f0:
					num = 18;
					frmMDUpdOpIP.DefInstance.sYbath = Conversions.ToSingle(((Control)_fraGSS_4).Controls["_txt104_4"].Text);
					goto IL_021d;
					IL_021d:
					num = 19;
					frmMDUpdOpIP.DefInstance._txtKnowns_1.Text = ((Control)_fraGSS_4).Controls["_txt104_5"].Text;
					goto IL_024b;
					IL_024b:
					num = 20;
					frmMDUpdOpIP.DefInstance.sDVrinse = Conversions.ToSingle(((Control)_fraGSS_4).Controls["_txt104_6"].Text);
					goto IL_0278;
					IL_0278:
					num = 21;
					frmMDUpdOpIP.DefInstance.sDrinse = Conversions.ToSingle(((Control)_fraGSS_4).Controls["_txt104_7"].Text);
					goto IL_02a5;
					IL_02a5:
					num = 22;
					frmMDUpdOpIP.DefInstance.sYrinse = Conversions.ToSingle(((Control)_fraGSS_4).Controls["_txt104_8"].Text);
					goto IL_02d2;
					IL_02d2:
					num = 23;
					frmMDUpdOpIP.DefInstance.sRinseE = Conversions.ToSingle(((Control)_fraGSS_4).Controls["_txt104_9"].Text);
					goto IL_02ff;
					IL_02ff:
					num = 24;
					frmMDUpdOpIP.DefInstance._txtKnowns_2.Text = ((Control)_fraGSS_4).Controls["_txt104_10"].Text;
					goto IL_032d;
					IL_032d:
					num = 25;
					frmMDUpdOpIP.DefInstance._txtKnowns_0.Text = Conversions.ToString(sCalcNS);
					goto IL_034c;
					IL_034c:
					num = 26;
					frmMDUpdOpIP.DefInstance.iFixVbath = checked((short)_chkFix_0.CheckState);
					goto IL_0366;
					IL_0366:
					num = 27;
					frmMDUpdOpIP.DefInstance.iFixDVRinse = checked((short)_chkFix_6.CheckState);
					goto IL_0380;
					IL_0380:
					num = 28;
					frmMDUpdOpIP.DefInstance.iFixYrinse = checked((short)_chkFix_8.CheckState);
					goto IL_039a;
					IL_039a:
					num = 29;
					frmMDUpdOpIP.DefInstance.cmdCalcOthers_Click(frmMDUpdOpIP.DefInstance.cmdCalcOthers, new EventArgs());
					goto IL_03b8;
					IL_03b8:
					num = 30;
					_txt104_0.Text = ChemStrX.ShowInSciNot(frmMDUpdOpIP.DefInstance.sVbath);
					goto IL_03dc;
					IL_03dc:
					num = 31;
					_txt104_1.Text = ChemStrX.ShowInSciNot(frmMDUpdOpIP.DefInstance.sNbath);
					goto IL_0400;
					IL_0400:
					num = 32;
					_txt104_2.Text = ChemStrX.ShowInSciNot(frmMDUpdOpIP.DefInstance.sFreqbath);
					goto IL_0424;
					IL_0424:
					num = 33;
					_txt104_3.Text = ChemStrX.ShowInSciNot(frmMDUpdOpIP.DefInstance.sDbath);
					goto IL_0448;
					IL_0448:
					num = 34;
					_txt104_4.Text = Support.Format((object)(frmMDUpdOpIP.DefInstance.sYbath * 1000f / 1000f), "0.####", (FirstDayOfWeek)1, (FirstWeekOfYear)1);
					goto IL_047f;
					IL_047f:
					num = 35;
					_txt104_5.Text = frmMDUpdOpIP.DefInstance.txtKnowns[(short)1].Text;
					goto IL_04a4;
					IL_04a4:
					num = 36;
					_txt104_6.Text = ChemStrX.ShowInSciNot(frmMDUpdOpIP.DefInstance.sDVrinse);
					goto IL_04c8;
					IL_04c8:
					num = 37;
					_txt104_7.Text = ChemStrX.ShowInSciNot(frmMDUpdOpIP.DefInstance.sDrinse);
					goto IL_04ec;
					IL_04ec:
					num = 38;
					_txt104_8.Text = Support.Format((object)(frmMDUpdOpIP.DefInstance.sYrinse * 1000f / 1000f), "0.####", (FirstDayOfWeek)1, (FirstWeekOfYear)1);
					goto IL_0523;
					IL_0523:
					num = 39;
					_txt104_9.Text = ChemStrX.ShowInSciNot(frmMDUpdOpIP.DefInstance.sRinseE);
					goto IL_0547;
					IL_0547:
					num = 40;
					_txt104_10.Text = ChemStrX.ShowInSciNot(frmMDUpdOpIP.DefInstance.txtKnowns[(short)2].Text);
					goto IL_0571;
					IL_0571:
					num = 41;
					sCalcNS = Conversions.ToSingle(frmMDUpdOpIP.DefInstance.txtKnowns[(short)0].Text);
					goto IL_0595;
					end_IL_0001_2:
					break;
				}
				num = 48;
				lblWarning.Text = sWarning;
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 1734;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void cmdCalcBmoProd102_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		if (Versioned.IsNumeric((object)txtVbatch.Text) & Versioned.IsNumeric((object)txtDprod[(short)2].Text))
		{
			lblBMOprod.Text = Conversions.ToString(Conversions.ToDouble(txtVbatch.Text) * Conversions.ToDouble(txtDprod[(short)2].Text));
			bool bValue = false;
			SetButtons(ref bValue);
		}
		else
		{
			Interaction.MsgBox((object)"Please specify all parameters before pressing the Calculate button.", (MsgBoxStyle)64, (object)null);
		}
	}

	private void ADMU_Calc104_Seq()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Invalid comparison between Unknown and I4
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Invalid comparison between Unknown and I4
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Invalid comparison between Unknown and I4
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Invalid comparison between Unknown and I4
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Invalid comparison between Unknown and I4
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Invalid comparison between Unknown and I4
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Unknown result type (might be due to invalid IL or missing references)
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
					if (((int)_chkFix_0.CheckState == 0) & ((int)_chkFix_6.CheckState == 0))
					{
						TextBox txt104_ = _txt104_0;
						float pADMUchem = Conversions.ToSingle(_txt104_10.Text);
						float pNbath = Conversions.ToSingle(_txt104_1.Text);
						float pFreqbath = Conversions.ToSingle(_txt104_2.Text);
						float pDbath = Conversions.ToSingle(_txt104_3.Text);
						float pYbath = Conversions.ToSingle(_txt104_4.Text);
						float pOD = Conversions.ToSingle(_txt104_5.Text);
						float pDrinse = Conversions.ToSingle(_txt104_7.Text);
						float pYrinse = Conversions.ToSingle(_txt104_8.Text);
						float pRinseE = Conversions.ToSingle(_txt104_9.Text);
						txt104_.Text = ChemStrX.ShowInSciNot(ChemStrX.Calc_Vbath_SeqA(ref pADMUchem, ref pNbath, ref pFreqbath, ref pDbath, ref pYbath, ref pOD, ref pDrinse, ref pYrinse, ref pRinseE));
						TextBox txt104_2 = _txt104_6;
						pRinseE = Conversions.ToSingle(_txt104_0.Text);
						pYrinse = Conversions.ToSingle(_txt104_1.Text);
						txt104_2.Text = ChemStrX.ShowInSciNot(ChemStrX.Calc_DVrinse_SeqA(ref pRinseE, ref pYrinse));
					}
					else if (((int)chkFix[(short)0].CheckState == 1) & ((int)chkFix[(short)6].CheckState == 0))
					{
						float pRinseE = Conversions.ToSingle(_txt104_10.Text);
						float pYrinse = Conversions.ToSingle(_txt104_0.Text);
						float pDrinse = Conversions.ToSingle(_txt104_1.Text);
						float pOD = Conversions.ToSingle(_txt104_2.Text);
						float pYbath = Conversions.ToSingle(_txt104_3.Text);
						float pDbath = Conversions.ToSingle(_txt104_4.Text);
						float pFreqbath = Conversions.ToSingle(_txt104_5.Text);
						float pNbath = Conversions.ToSingle(_txt104_7.Text);
						float pADMUchem = Conversions.ToSingle(_txt104_8.Text);
						float pRinseE2 = Conversions.ToSingle(_txt104_9.Text);
						double num3 = ChemStrX.Calc_DVrinse_SeqB(ref pRinseE, ref pYrinse, ref pDrinse, ref pOD, ref pYbath, ref pDbath, ref pFreqbath, ref pNbath, ref pADMUchem, ref pRinseE2);
						if (num3 < 0.0)
						{
							string text = "Parameters should be adjusted such that ADMUchem is increased and/or Vbath is decreased.";
							Interaction.MsgBox((object)text, (MsgBoxStyle)64, (object)null);
							_txt104_6.Text = Conversions.ToString(0);
						}
						else
						{
							_txt104_6.Text = Conversions.ToString(num3);
						}
					}
					else if (((int)chkFix[(short)0].CheckState == 0) & ((int)chkFix[(short)6].CheckState == 1))
					{
						float pRinseE2 = Conversions.ToSingle(_txt104_10.Text);
						float pRinseE = Conversions.ToSingle(_txt104_6.Text);
						float pYrinse = Conversions.ToSingle(_txt104_7.Text);
						float pDrinse = Conversions.ToSingle(_txt104_8.Text);
						float pOD = Conversions.ToSingle(_txt104_9.Text);
						float pYbath = Conversions.ToSingle(_txt104_1.Text);
						float pDbath = Conversions.ToSingle(_txt104_2.Text);
						float pFreqbath = Conversions.ToSingle(_txt104_3.Text);
						float pNbath = Conversions.ToSingle(_txt104_4.Text);
						float pADMUchem = Conversions.ToSingle(_txt104_5.Text);
						double num3 = ChemStrX.Calc_Vbath_SeqC(ref pRinseE2, ref pRinseE, ref pYrinse, ref pDrinse, ref pOD, ref pYbath, ref pDbath, ref pFreqbath, ref pNbath, ref pADMUchem);
						if (num3 < 0.0)
						{
							string text = "Parameters should be adjusted such that ADMUchem is increased and/or DVrinse is decreased.";
							Interaction.MsgBox((object)text, (MsgBoxStyle)64, (object)null);
							_txt104_0.Text = Conversions.ToString(0);
						}
						else
						{
							_txt104_0.Text = Conversions.ToString(num3);
						}
					}
					else if (((int)chkFix[(short)0].CheckState == 1) & ((int)chkFix[(short)6].CheckState == 1))
					{
						float pRinseE2 = Conversions.ToSingle(_txt104_0.Text);
						float pRinseE = Conversions.ToSingle(_txt104_0.Text);
						float pYrinse = Conversions.ToSingle(_txt104_1.Text);
						float pDrinse = Conversions.ToSingle(_txt104_2.Text);
						float pOD = Conversions.ToSingle(_txt104_3.Text);
						float pYbath = Conversions.ToSingle(_txt104_4.Text);
						float pDbath = Conversions.ToSingle(_txt104_5.Text);
						float pFreqbath = Conversions.ToSingle(_txt104_6.Text);
						float pNbath = Conversions.ToSingle(_txt104_7.Text);
						float pADMUchem = Conversions.ToSingle(_txt104_8.Text);
						float pRinseE3 = Conversions.ToSingle(_txt104_9.Text);
						double num3 = ChemStrX.Calc_Yrinse_SeqD(ref pRinseE2, ref pRinseE, ref pYrinse, ref pDrinse, ref pOD, ref pYbath, ref pDbath, ref pFreqbath, ref pNbath, ref pADMUchem, ref pRinseE3);
						if (Math.Abs(num3) > 0.05)
						{
							string text = "The fixed values of DVrinse and Vbath result in a mass balance discrepancy of greater than 5%.";
							Interaction.MsgBox((object)text, (MsgBoxStyle)64, (object)null);
							lblWarning.Text = text;
						}
					}
					goto end_IL_0001;
				case 1426:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						string Eobject = ((Control)this).Name;
						string Efunction = "ADMU_Calc104_Seq";
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
				try0001_dispatch = 1426;
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

	private void cmdCalcNS_Click(object eventSender, EventArgs eventArgs)
	{
		iReCalcNS = 1;
		if (optMethod103[(short)0].Checked)
		{
			frmMDUpdOpIP.DefInstance.txtKnowns[(short)2].Text = txtDMUchem[(short)0].Text;
		}
		else
		{
			frmMDUpdOpIP.DefInstance.txtKnowns[(short)2].Text = txtDMUchem[(short)1].Text;
		}
		frmMDUpdOpIP.DefInstance.chkKnowns1[(short)0].CheckState = (CheckState)0;
		frmMDUpdOpIP.DefInstance.chkKnowns1[(short)1].CheckState = (CheckState)1;
		frmMDUpdOpIP.DefInstance.txtKnowns[(short)1].Text = Conversions.ToString(360);
		frmMDUpdOpIP.DefInstance.cmdCalcOthers_Click(frmMDUpdOpIP.DefInstance.cmdCalcOthers, new EventArgs());
		frmMDUpdOpIP.DefInstance.chkKnowns1[(short)1].CheckState = (CheckState)0;
		frmMDUpdOpIP.DefInstance.chkKnowns1[(short)0].CheckState = (CheckState)1;
		frmMDUpdOpIP.DefInstance.cmdCalcOthers_Click(frmMDUpdOpIP.DefInstance.cmdCalcOthers, new EventArgs());
	}

	private void cmdCalcRRctw_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		frmMDCalcCtw defInstance = frmMDCalcCtw.DefInstance;
		short pID = 126;
		object pOption = frmMDUpdOpIP.DefInstance.sRRctwOption;
		if (defInstance.SetUp(ref pID, ref pOption))
		{
			((Form)frmMDCalcCtw.DefInstance).ShowDialog();
			if (Operators.ConditionalCompareObjectEqual(((Control)frmMDCalcCtw.DefInstance).Tag, (object)"", false))
			{
				frmMDUpdOpIP.DefInstance.sRRctwOption = frmMDCalcCtw.DefInstance.iSelected;
				frmMDUpdOpIP.DefInstance.sRRctw = Conversions.ToSingle(txtRRctw.Text);
			}
		}
		((Form)frmMDCalcCtw.DefInstance).Close();
	}

	private void cmdOk_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_05db: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0607: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			switch (Globals_Renamed.arOpType[Globals_Renamed.intOpIndex])
			{
			case 100:
				if (optMethod[(short)0].Checked)
				{
					frmMDUpdOpIP.DefInstance.sVcar = Conversions.ToSingle(txtVcar.Text);
					frmMDUpdOpIP.DefInstance.sDprod = Conversions.ToSingle(txtDprod[(short)0].Text);
					frmMDUpdOpIP.DefInstance.sNcar = Conversions.ToSingle(txtNcar.Text);
					frmMDUpdOpIP.DefInstance.txtKnowns[(short)4].Text = lblDmuPaint[(short)0].Text;
					frmMDUpdOpIP.DefInstance.sVpaint = 0f;
				}
				else if (optMethod[(short)1].Checked)
				{
					lblDmuPaint[(short)1].Text = Conversions.ToString(Conversions.ToDouble(txtVpaint.Text) * Conversions.ToDouble(txtDprod[(short)1].Text) * 3.785);
					frmMDUpdOpIP.DefInstance.sVpaint = Conversions.ToSingle(txtVpaint.Text);
					frmMDUpdOpIP.DefInstance.sDprod = Conversions.ToSingle(txtDprod[(short)1].Text);
					frmMDUpdOpIP.DefInstance.txtKnowns[(short)4].Text = lblDmuPaint[(short)1].Text;
					frmMDUpdOpIP.DefInstance.sVcar = 0f;
					frmMDUpdOpIP.DefInstance.sNcar = 0f;
				}
				break;
			case 101:
				if (optMethod101[(short)0].Checked)
				{
					frmMDUpdOpIP.DefInstance.sDVIppaint = Conversions.ToSingle(txtDVIppaint.Text);
					frmMDUpdOpIP.DefInstance.sDrm = Conversions.ToSingle(txtDppaint.Text);
					frmMDUpdOpIP.DefInstance.txtKnowns[(short)4].Text = Conversions.ToString(Conversions.ToDouble(txtDVIppaint.Text) * Conversions.ToDouble(txtDppaint.Text));
				}
				else
				{
					frmMDUpdOpIP.DefInstance.txtKnowns[(short)4].Text = txtUserInput101.Text;
				}
				break;
			case 102:
				if (optMethod102[(short)1].Checked)
				{
					frmMDUpdOpIP.DefInstance.txtKnowns[(short)4].Text = txtUserInput.Text;
					break;
				}
				frmMDUpdOpIP.DefInstance.sVbatch = Conversions.ToSingle(txtVbatch.Text);
				frmMDUpdOpIP.DefInstance.sDprod = Conversions.ToSingle(txtDprod[(short)2].Text);
				frmMDUpdOpIP.DefInstance.txtKnowns[(short)4].Text = lblBMOprod.Text;
				break;
			case 103:
				if (optMethod103[(short)0].Checked)
				{
					frmMDUpdOpIP.DefInstance.sRRctw = Conversions.ToSingle(txtRRctw.Text);
					frmMDUpdOpIP.DefInstance.sYctw = Conversions.ToSingle(txtYctw.Text);
					frmMDUpdOpIP.DefInstance.sHD = Conversions.ToSingle(txtHD.Text);
					frmMDUpdOpIP.DefInstance.sDctw = Conversions.ToSingle(txtDctw.Text);
					frmMDUpdOpIP.DefInstance.sLFb = Conversions.ToSingle(txtLFb.Text);
					frmMDUpdOpIP.DefInstance.sLFw = Conversions.ToSingle(txtLFw.Text);
					frmMDUpdOpIP.DefInstance.sLFe = Conversions.ToSingle(txtLFe.Text);
					frmMDUpdOpIP.DefInstance.sDRRchem = Conversions.ToSingle(txtDRRchem[(short)0].Text);
					frmMDUpdOpIP.DefInstance.txtKnowns[(short)2].Text = txtDMUchem[(short)0].Text;
				}
				else
				{
					frmMDUpdOpIP.DefInstance.sLFb = Conversions.ToSingle(txtLFb.Text);
					frmMDUpdOpIP.DefInstance.sLFw = Conversions.ToSingle(txtLFw.Text);
					frmMDUpdOpIP.DefInstance.sLFe = Conversions.ToSingle(Common.MyNullCheck0(txtLFe.Text));
					frmMDUpdOpIP.DefInstance.sDRRchem = Conversions.ToSingle(txtDRRchem[(short)1].Text);
					frmMDUpdOpIP.DefInstance.txtKnowns[(short)2].Text = txtDMUchem[(short)1].Text;
				}
				break;
			case 104:
				frmMDUpdOpIP.DefInstance.sVbath = Conversions.ToSingle(_txt104_0.Text);
				frmMDUpdOpIP.DefInstance.sNbath = Conversions.ToSingle(_txt104_1.Text);
				frmMDUpdOpIP.DefInstance.sFreqbath = Conversions.ToSingle(_txt104_2.Text);
				frmMDUpdOpIP.DefInstance.sDbath = Conversions.ToSingle(_txt104_3.Text);
				frmMDUpdOpIP.DefInstance.sYbath = Conversions.ToSingle(_txt104_4.Text);
				frmMDUpdOpIP.DefInstance.sDVrinse = Conversions.ToSingle(_txt104_6.Text);
				frmMDUpdOpIP.DefInstance.sDrinse = Conversions.ToSingle(_txt104_7.Text);
				frmMDUpdOpIP.DefInstance.sYrinse = Conversions.ToSingle(_txt104_8.Text);
				frmMDUpdOpIP.DefInstance.sRinseE = Conversions.ToSingle(_txt104_9.Text);
				frmMDUpdOpIP.DefInstance.txtKnowns[(short)2].Text = _txt104_10.Text;
				frmMDUpdOpIP.DefInstance.iFixVbath = (short)_chkFix_0.CheckState;
				frmMDUpdOpIP.DefInstance.iFixDVRinse = (short)_chkFix_6.CheckState;
				frmMDUpdOpIP.DefInstance.iFixYrinse = (short)_chkFix_8.CheckState;
				break;
			}
			((Control)this).Tag = "";
			((Control)this).Hide();
		}
	}

	private void cmdRestore_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Invalid comparison between Unknown and I4
		//IL_0620: Unknown result type (might be due to invalid IL or missing references)
		//IL_0626: Invalid comparison between Unknown and I4
		//IL_068a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0690: Invalid comparison between Unknown and I4
		switch (Globals_Renamed.arOpType[Globals_Renamed.intOpIndex])
		{
		case 100:
		{
			TextBox obj = txtVcar;
			short pParmID = 100;
			short pGSSID = 21;
			obj.Text = Conversions.ToString(ChemStrX.SetGSSParmDefault(ref pParmID, ref pGSSID));
			TextBox obj2 = txtNcar;
			pGSSID = 100;
			pParmID = 25;
			obj2.Text = Conversions.ToString(ChemStrX.SetGSSParmDefault(ref pGSSID, ref pParmID));
			txtVpaint.Text = "";
			txtDprod[(short)1].Text = "";
			lblDmuPaint[(short)1].Text = "";
			if (Strings.Len(frmMain.DefInstance.lblDchem.Text) > 0)
			{
				_txtDprod_0.Text = frmMain.DefInstance.lblDchem.Text;
			}
			else
			{
				_txtDprod_0.Text = "";
			}
			_optMethod_0.Checked = true;
			cmdCalc_Click(cmdCalc, new EventArgs());
			break;
		}
		case 101:
		{
			TextBox obj3 = txtDVIppaint;
			short pGSSID = 101;
			short pParmID = 116;
			obj3.Text = Conversions.ToString(ChemStrX.SetGSSParmDefault(ref pGSSID, ref pParmID));
			txtUserInput101.Text = "";
			_optMethod101_0.Checked = true;
			cmdCalc101_Click(cmdCalc101, new EventArgs());
			break;
		}
		case 102:
		{
			txtVbatch.Text = "";
			_txtDprod_2.Text = "";
			lblBMOprod.Text = "";
			_optMethod102_0.Checked = true;
			txtUserInput.Text = Conversions.ToString(4000);
			bool bValue = false;
			SetButtons(ref bValue);
			break;
		}
		case 103:
		{
			TextBox obj4 = txtRRctw;
			short pGSSID = 103;
			short pParmID = 126;
			obj4.Text = Conversions.ToString(ChemStrX.SetGSSParmDefault(ref pGSSID, ref pParmID));
			TextBox obj5 = txtYctw;
			pGSSID = 103;
			pParmID = 124;
			obj5.Text = Conversions.ToString(ChemStrX.SetGSSParmDefault(ref pGSSID, ref pParmID));
			txtHD.Text = Conversions.ToString(24);
			TextBox obj6 = txtDctw;
			pGSSID = 103;
			pParmID = 125;
			obj6.Text = Conversions.ToString(ChemStrX.SetGSSParmDefault(ref pGSSID, ref pParmID));
			TextBox obj7 = txtLFb;
			pGSSID = 103;
			pParmID = 127;
			obj7.Text = Conversions.ToString(ChemStrX.SetGSSParmDefault(ref pGSSID, ref pParmID));
			TextBox obj8 = txtLFw;
			pGSSID = 103;
			pParmID = 128;
			obj8.Text = Conversions.ToString(ChemStrX.SetGSSParmDefault(ref pGSSID, ref pParmID));
			TextBox obj9 = txtLFe;
			pGSSID = 103;
			pParmID = 129;
			obj9.Text = Conversions.ToString(ChemStrX.SetGSSParmDefault(ref pGSSID, ref pParmID));
			frmMDUpdOpIP.DefInstance.sYctwOption = 0;
			frmMDUpdOpIP.DefInstance.sYctwOther = "";
			frmMDUpdOpIP.DefInstance.sRRctwOption = 0;
			_optMethod103_0.Checked = true;
			cmdCalc103_Click(cmdCalc103, new EventArgs());
			bool bValue = false;
			SetButtons(ref bValue);
			break;
		}
		case 104:
		{
			TextBox txt104_ = _txt104_0;
			short pGSSID = 104;
			short pParmID = 135;
			txt104_.Text = Support.Format((object)(ChemStrX.SetGSSParmDefault(ref pGSSID, ref pParmID) * 1000f / 1000f), "0.####", (FirstDayOfWeek)1, (FirstWeekOfYear)1);
			TextBox txt104_2 = _txt104_1;
			pGSSID = 104;
			pParmID = 136;
			txt104_2.Text = ChemStrX.ShowInSciNot(ChemStrX.SetGSSParmDefault(ref pGSSID, ref pParmID));
			TextBox txt104_3 = _txt104_2;
			pGSSID = 104;
			pParmID = 137;
			txt104_3.Text = ChemStrX.ShowInSciNot(ChemStrX.SetGSSParmDefault(ref pGSSID, ref pParmID));
			TextBox txt104_4 = _txt104_3;
			pGSSID = 104;
			pParmID = 133;
			txt104_4.Text = ChemStrX.ShowInSciNot(ChemStrX.SetGSSParmDefault(ref pGSSID, ref pParmID));
			TextBox txt104_5 = _txt104_4;
			pGSSID = 104;
			pParmID = 131;
			txt104_5.Text = Support.Format((object)(ChemStrX.SetGSSParmDefault(ref pGSSID, ref pParmID) * 1000f / 1000f), "0.####", (FirstDayOfWeek)1, (FirstWeekOfYear)1);
			if ((int)frmMDUpdOpIP.DefInstance.chkKnowns1[(short)1].CheckState == 1)
			{
				_txt104_5.Text = frmMDUpdOpIP.DefInstance.txtKnowns[(short)1].Text;
			}
			else
			{
				TextBox txt104_6 = _txt104_5;
				pGSSID = 104;
				pParmID = 2;
				txt104_6.Text = ChemStrX.ShowInSciNot(ChemStrX.SetGSSParmDefault2(ref pGSSID, ref pParmID));
			}
			TextBox txt104_7 = _txt104_6;
			pGSSID = 104;
			pParmID = 138;
			txt104_7.Text = Support.Format((object)(ChemStrX.SetGSSParmDefault(ref pGSSID, ref pParmID) * 1000f / 1000f), "0.####", (FirstDayOfWeek)1, (FirstWeekOfYear)1);
			TextBox txt104_8 = _txt104_7;
			pGSSID = 104;
			pParmID = 134;
			txt104_8.Text = ChemStrX.ShowInSciNot(ChemStrX.SetGSSParmDefault(ref pGSSID, ref pParmID));
			TextBox txt104_9 = _txt104_8;
			pGSSID = 104;
			pParmID = 132;
			txt104_9.Text = Support.Format((object)(ChemStrX.SetGSSParmDefault(ref pGSSID, ref pParmID) * 1000f / 1000f), "0.####", (FirstDayOfWeek)1, (FirstWeekOfYear)1);
			TextBox txt104_10 = _txt104_9;
			pGSSID = 104;
			pParmID = 139;
			txt104_10.Text = ChemStrX.ShowInSciNot(ChemStrX.SetGSSParmDefault(ref pGSSID, ref pParmID));
			_chkFix_0.CheckState = (CheckState)0;
			_chkFix_6.CheckState = (CheckState)0;
			_chkFix_8.CheckState = (CheckState)1;
			double num = ChemStrX.Calc104_EP1(Conversions.ToDouble(_txt104_0.Text), Conversions.ToDouble(_txt104_1.Text), Conversions.ToDouble(_txt104_2.Text), Conversions.ToDouble(_txt104_3.Text), Conversions.ToDouble(_txt104_4.Text), Conversions.ToDouble(_txt104_5.Text), Conversions.ToDouble(_txt104_6.Text), Conversions.ToDouble(_txt104_7.Text), Conversions.ToDouble(_txt104_8.Text), Conversions.ToDouble(_txt104_9.Text));
			_txt104_10.Text = ChemStrX.ShowInSciNot(num);
			double pValue;
			if ((int)frmMDUpdOpIP.DefInstance.chkKnowns1[(short)0].CheckState == 0)
			{
				sCalcNS = (float)ChemStrX.Calc104_EP2(frmMDUpdOpIP.DefInstance.MyPvOp, Conversions.ToDouble(_txt104_5.Text), Conversions.ToDouble(_txt104_10.Text));
				if (sCalcNS < 1f)
				{
					if ((int)frmMDUpdOpIP.DefInstance.chkKnowns1[(short)1].CheckState == 0)
					{
						sCalcNS = 1f;
					}
				}
				else
				{
					frmMDUpdOpIP defInstance = frmMDUpdOpIP.DefInstance;
					pValue = sCalcNS;
					sCalcNS = defInstance.MassBalanceRoundUp(ref pValue);
				}
			}
			TextBox txt104_11 = _txt104_5;
			frmMDUpdOpIP defInstance2 = frmMDUpdOpIP.DefInstance;
			pValue = ChemStrX.Calc104_EP2a(frmMDUpdOpIP.DefInstance.MyPvOp, sCalcNS, Conversions.ToDouble(_txt104_10.Text));
			string sAbbr = "";
			pGSSID = 1;
			txt104_11.Text = Conversions.ToString(defInstance2.MyRoundIt(ref pValue, ref sAbbr, ref pGSSID));
			_txt104_10.Text = ChemStrX.ShowInSciNot(ChemStrX.Calc104_EP3(frmMDUpdOpIP.DefInstance.MyPvOp, sCalcNS, Conversions.ToDouble(_txt104_5.Text)));
			ADMU_Calc104_Seq();
			bool bValue = false;
			SetButtons(ref bValue);
			break;
		}
		}
	}

	private void cmdYctw_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		frmMDCalcCtw defInstance = frmMDCalcCtw.DefInstance;
		short pID = 124;
		object pOption = frmMDUpdOpIP.DefInstance.sYctwOption;
		if (defInstance.SetUp(ref pID, ref pOption))
		{
			((Form)frmMDCalcCtw.DefInstance).ShowDialog();
			if (Operators.ConditionalCompareObjectEqual(((Control)frmMDCalcCtw.DefInstance).Tag, (object)"", false))
			{
				frmMDUpdOpIP.DefInstance.sYctwOption = frmMDCalcCtw.DefInstance.iSelected;
				frmMDUpdOpIP.DefInstance.sYctw = Conversions.ToSingle(txtYctw.Text);
				if (frmMDCalcCtw.DefInstance.iSelected == 3)
				{
					frmMDUpdOpIP.DefInstance.sYctwOther = frmMDCalcCtw.DefInstance.txtYctwOther.Text;
				}
				else
				{
					frmMDUpdOpIP.DefInstance.sYctwOther = "";
				}
			}
		}
		((Form)frmMDCalcCtw.DefInstance).Close();
	}

	private void optMethod_CheckedChanged(object eventSender, EventArgs eventArgs)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		checked
		{
			if (Conversions.ToBoolean(NewLateBinding.LateGet(eventSender, (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null)))
			{
				short index = optMethod.GetIndex((RadioButton)eventSender);
				bool bValue = true;
				SetButtons(ref bValue);
				iSelected = index;
				bool flag;
				float num;
				float num2;
				if (index == 0)
				{
					flag = false;
					num = ColorTranslator.ToOle(Color.White);
					num2 = ColorTranslator.ToOle(((Control)lblDmuPaint[(short)0]).BackColor);
					optMethod[(short)1].Checked = false;
				}
				else
				{
					flag = true;
					num = ColorTranslator.ToOle(((Control)lblDmuPaint[(short)0]).BackColor);
					num2 = ColorTranslator.ToOle(Color.White);
					optMethod[(short)0].Checked = false;
				}
				((TextBoxBase)txtVcar).ReadOnly = flag;
				((TextBoxBase)txtVcar).BackColor = ColorTranslator.FromOle((int)Math.Round(num));
				((TextBoxBase)txtDprod[(short)0]).ReadOnly = flag;
				((TextBoxBase)txtDprod[(short)0]).BackColor = ColorTranslator.FromOle((int)Math.Round(num));
				((TextBoxBase)txtNcar).ReadOnly = flag;
				((TextBoxBase)txtNcar).BackColor = ColorTranslator.FromOle((int)Math.Round(num));
				((TextBoxBase)txtVpaint).ReadOnly = !flag;
				((TextBoxBase)txtVpaint).BackColor = ColorTranslator.FromOle((int)Math.Round(num2));
				((TextBoxBase)txtDprod[(short)1]).ReadOnly = !flag;
				((TextBoxBase)txtDprod[(short)1]).BackColor = ColorTranslator.FromOle((int)Math.Round(num2));
			}
		}
	}

	private void cmdCancel_Click(object eventSender, EventArgs eventArgs)
	{
		((Control)this).Tag = "Cancel";
		((Control)this).Hide();
	}

	private void frmMDCalcXmoProd_Load(object eventSender, EventArgs eventArgs)
	{
		SetUp(ref frmMDUpdOpIP.DefInstance.pOption);
	}

	private void change_txt104(int index)
	{
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Invalid comparison between Unknown and I4
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		short pID = default(short);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				Control val;
				object pValue;
				short pModType;
				bool num5;
				bool bValue;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_000a;
				case 672:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0001;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000a;
						case 3:
							goto IL_000f;
						case 4:
							goto IL_0043;
						case 5:
							goto IL_0074;
						case 6:
							goto IL_00b3;
						case 8:
						case 10:
							goto IL_00e6;
						case 12:
						case 13:
							goto IL_00f3;
						case 15:
						case 16:
							goto IL_0100;
						case 18:
						case 19:
							goto IL_0109;
						case 7:
						case 11:
						case 14:
						case 17:
						case 20:
						case 21:
							goto IL_0114;
						case 22:
							goto IL_0122;
						case 23:
							goto IL_016a;
						case 26:
							goto IL_017d;
						case 27:
							goto IL_0182;
						case 24:
						case 25:
						case 28:
						case 29:
							goto IL_0193;
						case 30:
							goto IL_01a5;
						case 31:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 32:
						case 33:
						case 34:
						case 35:
						case 36:
						case 37:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0182:
					num = 27;
					bValue = true;
					SetButtons(ref bValue);
					goto IL_0193;
					IL_0193:
					num = 29;
					if (pID != 131)
					{
						goto end_IL_0001_3;
					}
					goto IL_01a5;
					IL_017d:
					num = 26;
					goto IL_0182;
					IL_01a5:
					num = 30;
					if ((int)_chkFix_8.CheckState != 0)
					{
						goto end_IL_0001_3;
					}
					break;
					IL_000a:
					num = 2;
					pID = 0;
					goto IL_000f;
					IL_000f:
					num = 3;
					if (Strings.Len(((Control)this).Controls["_txt104_" + Conversions.ToString(index)].Text) <= 0)
					{
						goto end_IL_0001_3;
					}
					goto IL_0043;
					IL_0043:
					num = 4;
					if (!Versioned.IsNumeric((object)((Control)this).Controls["_txt104_" + Conversions.ToString(index)].Text))
					{
						goto end_IL_0001_3;
					}
					goto IL_0074;
					IL_0074:
					num = 5;
					if (Conversions.ToDouble(((Control)this).Controls["_txt104_" + Conversions.ToString(index)].Text) == 0.0)
					{
						goto end_IL_0001_3;
					}
					goto IL_00b3;
					IL_00b3:
					num = 6;
					switch (index)
					{
					case 2:
						break;
					case 4:
						goto IL_00f3;
					case 5:
						goto IL_0100;
					case 9:
						goto IL_0109;
					default:
						goto IL_0114;
					}
					goto IL_00e6;
					IL_0109:
					num = 19;
					pID = 139;
					goto IL_0114;
					IL_0100:
					num = 16;
					pID = 2;
					goto IL_0114;
					IL_00f3:
					num = 13;
					pID = 131;
					goto IL_0114;
					IL_00e6:
					num = 10;
					pID = 137;
					goto IL_0114;
					IL_0114:
					num = 21;
					if (pID > 0)
					{
						goto IL_0122;
					}
					goto IL_017d;
					IL_0122:
					num = 22;
					val = ((Control)this).Controls["_txt104_" + Conversions.ToString(index)];
					pValue = val.Text;
					pModType = 0;
					num5 = ChemStrX.ValidateParmInput(ref pID, ref pValue, ref pModType);
					val.Text = Conversions.ToString(pValue);
					if (num5)
					{
						goto IL_016a;
					}
					goto IL_0193;
					IL_016a:
					num = 23;
					bValue = true;
					SetButtons(ref bValue);
					goto IL_0193;
					end_IL_0001_2:
					break;
				}
				num = 31;
				_txt104_8.Text = Conversions.ToString(0.5 * Conversions.ToDouble(_txt104_4.Text));
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 672;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public bool SetUp(ref short pOption)
	{
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Invalid comparison between Unknown and I4
		//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Invalid comparison between Unknown and I4
		//IL_08cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_08eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0907: Unknown result type (might be due to invalid IL or missing references)
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
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					((Form)this).Text = "Calculate " + ((ButtonBase)frmMDUpdOpIP.DefInstance._chkKnowns1_4).Text;
					switch (Globals_Renamed.arOpType[Globals_Renamed.intOpIndex])
					{
					case 100:
						((Control)_fraGSS_0).Visible = true;
						((Control)_fraGSS_0).BringToFront();
						txtVcar.Text = ChemStrX.ShowZeroAsNull(frmMDUpdOpIP.DefInstance.sVcar);
						txtNcar.Text = ChemStrX.ShowZeroAsNull(frmMDUpdOpIP.DefInstance.sNcar);
						txtVpaint.Text = ChemStrX.ShowZeroAsNull(frmMDUpdOpIP.DefInstance.sVpaint);
						if ((pOption == 0) | (pOption == 1))
						{
							optMethod[num3].Checked = true;
							txtDprod[num3].Text = ChemStrX.ShowZeroAsNull(frmMDUpdOpIP.DefInstance.sDprod);
							lblDmuPaint[num3].Text = ChemStrX.ShowZeroAsNull(frmMDUpdOpIP.DefInstance.txtKnowns[(short)4].Text);
						}
						else
						{
							cmdRestore_Click(cmdRestore, new EventArgs());
						}
						cmdCalc_Click(cmdCalc, new EventArgs());
						break;
					case 102:
						((Control)_fraGSS_1).Visible = true;
						((Control)_fraGSS_1).BringToFront();
						if (pOption == 0)
						{
							optMethod102[(short)0].Checked = true;
							txtVbatch.Text = ChemStrX.ShowZeroAsNull(frmMDUpdOpIP.DefInstance.sVbatch);
							_txtDprod_2.Text = ChemStrX.ShowZeroAsNull(frmMDUpdOpIP.DefInstance.sDprod);
							lblBMOprod.Text = ChemStrX.ShowZeroAsNull(frmMDUpdOpIP.DefInstance.txtKnowns[(short)4].Text);
							cmdCalcBmoProd102_Click(cmdCalcBmoProd102, new EventArgs());
						}
						else
						{
							_optMethod102_1.Checked = true;
							txtUserInput.Text = ChemStrX.ShowZeroAsNull(frmMDUpdOpIP.DefInstance.txtKnowns[(short)4].Text);
						}
						break;
					case 101:
						((Control)_fraGSS_2).Visible = true;
						((Control)_fraGSS_2).BringToFront();
						if (pOption == 0)
						{
							_optMethod101_0.Checked = true;
							txtDVIppaint.Text = ChemStrX.ShowZeroAsNull(frmMDUpdOpIP.DefInstance.sDVIppaint);
							txtDppaint.Text = ChemStrX.ShowZeroAsNull(frmMDUpdOpIP.DefInstance.sDrm);
							lblDMIppaint.Text = ChemStrX.ShowZeroAsNull(frmMDUpdOpIP.DefInstance.txtKnowns[(short)4].Text);
							cmdCalc101_Click(cmdCalc101, new EventArgs());
						}
						else
						{
							_optMethod102_1.Checked = true;
							txtUserInput101.Text = ChemStrX.ShowZeroAsNull(frmMDUpdOpIP.DefInstance.txtKnowns[(short)4].Text);
						}
						break;
					case 103:
						((Form)this).Text = "Calculate " + ((ButtonBase)frmMDUpdOpIP.DefInstance.chkKnowns1[(short)2]).Text;
						((Control)_fraGSS_3).Visible = true;
						((Control)_fraGSS_3).BringToFront();
						if (pOption == 0)
						{
							_optMethod103_0.Checked = true;
						}
						else
						{
							_optMethod103_1.Checked = true;
						}
						txtRRctw.Text = ChemStrX.ShowZeroAsNull(frmMDUpdOpIP.DefInstance.sRRctw);
						txtYctw.Text = ChemStrX.ShowZeroAsNull(frmMDUpdOpIP.DefInstance.sYctw);
						txtHD.Text = ChemStrX.ShowZeroAsNull(frmMDUpdOpIP.DefInstance.sHD);
						txtDctw.Text = ChemStrX.ShowZeroAsNull(frmMDUpdOpIP.DefInstance.sDctw);
						txtLFb.Text = ChemStrX.ShowZeroAsNull(frmMDUpdOpIP.DefInstance.sLFb);
						txtLFw.Text = ChemStrX.ShowZeroAsNull(frmMDUpdOpIP.DefInstance.sLFw);
						txtLFe.Text = Conversions.ToString(frmMDUpdOpIP.DefInstance.sLFe);
						if (pOption == 1)
						{
							_txtDMUchem_1.Text = frmMDUpdOpIP.DefInstance.txtKnowns[(short)2].Text;
						}
						if (((int)frmMDUpdOpIP.DefInstance.chkKnowns1[(short)0].CheckState == 1) & ((int)frmMDUpdOpIP.DefInstance.chkKnowns1[(short)1].CheckState == 0))
						{
							((Control)cmdCalcNS).Visible = true;
							((Control)lblCalcNS).Visible = true;
						}
						else
						{
							((Control)cmdCalcNS).Visible = false;
							((Control)lblCalcNS).Visible = false;
						}
						iReCalcNS = 0;
						cmdCalc103_Click(cmdCalc103, new EventArgs());
						break;
					case 104:
					{
						((Form)this).Text = "Calculate " + ((ButtonBase)frmMDUpdOpIP.DefInstance._chkKnowns1_2).Text;
						((Control)_fraGSS_4).BringToFront();
						((Control)_fraGSS_4).Visible = true;
						_txt104_0.Text = ChemStrX.ShowInSciNot(ChemStrX.ShowZeroAsNull(frmMDUpdOpIP.DefInstance.sVbath));
						_txt104_1.Text = ChemStrX.ShowInSciNot(ChemStrX.ShowZeroAsNull(frmMDUpdOpIP.DefInstance.sNbath));
						_txt104_2.Text = ChemStrX.ShowInSciNot(ChemStrX.ShowZeroAsNull(frmMDUpdOpIP.DefInstance.sFreqbath));
						_txt104_3.Text = ChemStrX.ShowInSciNot(ChemStrX.ShowZeroAsNull(frmMDUpdOpIP.DefInstance.sDbath));
						_txt104_4.Text = Support.Format((object)(frmMDUpdOpIP.DefInstance.sYbath * 1000f / 1000f), "0.####", (FirstDayOfWeek)1, (FirstWeekOfYear)1);
						_txt104_5.Text = frmMDUpdOpIP.DefInstance._txtKnowns_1.Text;
						_txt104_6.Text = ChemStrX.ShowInSciNot(ChemStrX.ShowZeroAsNull(frmMDUpdOpIP.DefInstance.sDVrinse));
						_txt104_7.Text = ChemStrX.ShowInSciNot(ChemStrX.ShowZeroAsNull(frmMDUpdOpIP.DefInstance.sDrinse));
						_txt104_8.Text = Support.Format((object)(frmMDUpdOpIP.DefInstance.sYrinse * 1000f / 1000f), "0.####", (FirstDayOfWeek)1, (FirstWeekOfYear)1);
						_txt104_9.Text = ChemStrX.ShowInSciNot(ChemStrX.ShowZeroAsNull(frmMDUpdOpIP.DefInstance.sRinseE));
						_txt104_10.Text = ChemStrX.ShowInSciNot(frmMDUpdOpIP.DefInstance._txtKnowns_2.Text);
						_chkFix_0.CheckState = (CheckState)frmMDUpdOpIP.DefInstance.iFixVbath;
						_chkFix_6.CheckState = (CheckState)frmMDUpdOpIP.DefInstance.iFixDVRinse;
						_chkFix_8.CheckState = (CheckState)frmMDUpdOpIP.DefInstance.iFixYrinse;
						sCalcNS = Conversions.ToSingle(frmMDUpdOpIP.DefInstance._txtKnowns_0.Text);
						num3 = 0;
						short num4;
						short num5;
						do
						{
							((Control)_fraGSS_4).Controls["_txt104_" + Conversions.ToString((int)num3)].Tag = ((Control)_fraGSS_4).Controls["_txt104_" + Conversions.ToString((int)num3)].Text;
							checked
							{
								num3 = (short)unchecked(num3 + 1);
								num4 = num3;
								num5 = 10;
							}
						}
						while (num4 <= num5);
						num3 = 0;
						short num6;
						do
						{
							((Control)frmMDUpdOpIP.DefInstance._fraTab2_0).Controls["_txtKnowns_" + Conversions.ToString((int)num3)].Tag = ((Control)frmMDUpdOpIP.DefInstance._fraTab2_0).Controls["_txtKnowns_" + Conversions.ToString((int)num3)].Text;
							checked
							{
								num3 = (short)unchecked(num3 + 1);
								num6 = num3;
								num5 = 4;
							}
						}
						while (num6 <= num5);
						num3 = 0;
						short num7;
						do
						{
							((Control)frmMDUpdOpIP.DefInstance._fraTab2_1).Controls["_txtOther_" + Conversions.ToString((int)num3)].Tag = ((Control)frmMDUpdOpIP.DefInstance._fraTab2_1).Controls["_txtOther_" + Conversions.ToString((int)num3)].Text;
							checked
							{
								num3 = (short)unchecked(num3 + 1);
								num7 = num3;
								num5 = 2;
							}
						}
						while (num7 <= num5);
						sSaveNS = Conversions.ToSingle(frmMDUpdOpIP.DefInstance._txtKnowns_0.Text);
						((Control)_chkFix_0).Tag = _chkFix_0.CheckState;
						((Control)_chkFix_6).Tag = _chkFix_6.CheckState;
						((Control)_chkFix_8).Tag = _chkFix_8.CheckState;
						bool Econtact = false;
						SetButtons(ref Econtact);
						Econtact = false;
						SetButtons(ref Econtact);
						break;
					}
					}
					flag = true;
					goto end_IL_0001;
				case 2456:
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
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 2456;
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

	private void optMethod101_CheckedChanged(object eventSender, EventArgs eventArgs)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		checked
		{
			if (Conversions.ToBoolean(NewLateBinding.LateGet(eventSender, (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null)))
			{
				short num = (iSelected = optMethod101.GetIndex((RadioButton)eventSender));
				bool bValue = true;
				SetButtons(ref bValue);
				bool flag;
				float num2;
				float num3;
				if (num == 0)
				{
					flag = false;
					num2 = ColorTranslator.ToOle(Color.White);
					num3 = ColorTranslator.ToOle(((Form)this).BackColor);
					optMethod101[(short)1].Checked = false;
				}
				else
				{
					flag = true;
					num2 = ColorTranslator.ToOle(((Form)this).BackColor);
					num3 = ColorTranslator.ToOle(Color.White);
					optMethod101[(short)0].Checked = false;
				}
				((TextBoxBase)txtDVIppaint).ReadOnly = flag;
				((TextBoxBase)txtDVIppaint).BackColor = ColorTranslator.FromOle((int)Math.Round(num2));
				((TextBoxBase)txtDppaint).ReadOnly = flag;
				((TextBoxBase)txtDppaint).BackColor = ColorTranslator.FromOle((int)Math.Round(num2));
				txtDppaint.Text = ChemStrX.ShowZeroAsNull(frmMDUpdOpIP.DefInstance.sDrm);
				((TextBoxBase)txtUserInput101).ReadOnly = !flag;
				((TextBoxBase)txtUserInput101).BackColor = ColorTranslator.FromOle((int)Math.Round(num3));
			}
		}
	}

	private void optMethod102_CheckedChanged(object eventSender, EventArgs eventArgs)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		checked
		{
			if (Conversions.ToBoolean(NewLateBinding.LateGet(eventSender, (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null)))
			{
				short num = (iSelected = optMethod102.GetIndex((RadioButton)eventSender));
				bool bValue = true;
				SetButtons(ref bValue);
				bool flag;
				float num2;
				float num3;
				if (num == 0)
				{
					flag = false;
					num2 = ColorTranslator.ToOle(Color.White);
					num3 = ColorTranslator.ToOle(((Control)lblDmuPaint[(short)0]).BackColor);
					_optMethod102_1.Checked = false;
				}
				else
				{
					flag = true;
					num2 = ColorTranslator.ToOle(((Control)lblDmuPaint[(short)0]).BackColor);
					num3 = ColorTranslator.ToOle(Color.White);
					_optMethod102_0.Checked = false;
				}
				((TextBoxBase)txtVbatch).ReadOnly = flag;
				((TextBoxBase)txtVbatch).BackColor = ColorTranslator.FromOle((int)Math.Round(num2));
				((TextBoxBase)_txtDprod_2).ReadOnly = flag;
				((TextBoxBase)_txtDprod_2).BackColor = ColorTranslator.FromOle((int)Math.Round(num2));
				_txtDprod_2.Text = ChemStrX.ShowZeroAsNull(frmMDUpdOpIP.DefInstance.sDprod);
				((TextBoxBase)txtUserInput).ReadOnly = !flag;
				((TextBoxBase)txtUserInput).BackColor = ColorTranslator.FromOle((int)Math.Round(num3));
			}
		}
	}

	private void optMethod103_CheckedChanged(object eventSender, EventArgs eventArgs)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		checked
		{
			if (Conversions.ToBoolean(NewLateBinding.LateGet(eventSender, (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null)))
			{
				short index = optMethod103.GetIndex((RadioButton)eventSender);
				bool bValue = true;
				SetButtons(ref bValue);
				iSelected = index;
				bool readOnly;
				bool readOnly2;
				float num;
				float num3;
				float num4;
				float num5;
				if (index == 0)
				{
					readOnly = false;
					readOnly2 = true;
					num = ColorTranslator.ToOle(Color.White);
					float num2 = -2.1474836E+09f;
					num3 = -2.1474836E+09f;
					num4 = 8421504f;
					num5 = 8421504f;
					_optMethod103_1.Checked = false;
					((ButtonBase)cmdCalc103).Text = "&Calculate DRRchem && DMUchem";
				}
				else
				{
					readOnly = true;
					readOnly2 = false;
					num = -2.1474836E+09f;
					float num2 = ColorTranslator.ToOle(Color.White);
					num3 = 8421504f;
					num4 = -2.1474836E+09f;
					num5 = ColorTranslator.ToOle(Color.White);
					_optMethod103_0.Checked = false;
					((ButtonBase)cmdCalc103).Text = "&Calculate DRRchem";
				}
				((TextBoxBase)txtHD).ReadOnly = readOnly;
				((TextBoxBase)txtDctw).ReadOnly = readOnly;
				((TextBoxBase)txtHD).BackColor = ColorTranslator.FromOle((int)Math.Round(num));
				((TextBoxBase)txtDctw).BackColor = ColorTranslator.FromOle((int)Math.Round(num));
				((TextBoxBase)_txtDMUchem_0).ReadOnly = readOnly2;
				((TextBoxBase)_txtDMUchem_0).BackColor = ColorTranslator.FromOle((int)Math.Round(num3));
				((TextBoxBase)_txtDMUchem_1).BackColor = ColorTranslator.FromOle((int)Math.Round(num5));
				((TextBoxBase)_txtDMUchem_1).ReadOnly = readOnly2;
				((TextBoxBase)_txtDRRchem_0).BackColor = ColorTranslator.FromOle((int)Math.Round(num3));
				((TextBoxBase)_txtDRRchem_1).BackColor = ColorTranslator.FromOle((int)Math.Round(num4));
			}
		}
	}

	private void txt104_TextChanged(object eventSender, EventArgs eventArgs)
	{
	}

	private void txt104_Leave(object eventSender, EventArgs eventArgs)
	{
	}

	private void txtDctw_TextChanged(object eventSender, EventArgs eventArgs)
	{
		if (Strings.Len(txtDctw.Text) > 0 && Versioned.IsNumeric((object)txtDctw.Text) && Conversions.ToDouble(txtDctw.Text) != 0.0)
		{
			short pID = 125;
			object pValue = txtDctw.Text;
			short pModType = 0;
			if (ChemStrX.ValidateParmInput(ref pID, ref pValue, ref pModType))
			{
				bool bValue = true;
				SetButtons(ref bValue);
			}
		}
	}

	private void txtDctw_Leave(object eventSender, EventArgs eventArgs)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		if (Strings.Len(txtDctw.Text) == 0)
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Invalid number. Please enter a valid number.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
			((TextBoxBase)txtDctw).SelectionStart = 0;
			((TextBoxBase)txtDctw).SelectionLength = Strings.Len(txtDctw.Text);
			((Control)txtDctw).Focus();
			return;
		}
		if (!Versioned.IsNumeric((object)txtDctw.Text))
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Invalid number. Please enter a valid number.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
			((TextBoxBase)txtDctw).SelectionStart = 0;
			((TextBoxBase)txtDctw).SelectionLength = Strings.Len(txtDctw.Text);
			((Control)txtDctw).Focus();
			return;
		}
		short pID = 125;
		object pValue = txtDctw.Text;
		short pModType = 0;
		if (!ChemStrX.ValidateParmInput(ref pID, ref pValue, ref pModType))
		{
			((TextBoxBase)txtDctw).SelectionStart = 0;
			((TextBoxBase)txtDctw).SelectionLength = Strings.Len(txtDctw.Text);
			((Control)txtDctw).Focus();
		}
	}

	private void txtDprod_TextChanged(object eventSender, EventArgs eventArgs)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		short index = txtDprod.GetIndex((TextBox)eventSender);
		bool bValue = true;
		SetButtons(ref bValue);
	}

	private void SetButtons(ref bool bValue)
	{
		((Control)cmdOk).Enabled = !bValue;
		((Control)cmdCalc).Enabled = bValue;
	}

	private void txtHD_TextChanged(object eventSender, EventArgs eventArgs)
	{
		if (Strings.Len(txtHD.Text) > 0 && Versioned.IsNumeric((object)txtHD.Text) && Conversions.ToDouble(txtHD.Text) != 0.0)
		{
			short pID = 35;
			object pValue = txtHD.Text;
			short pModType = 0;
			if (ChemStrX.ValidateParmInput(ref pID, ref pValue, ref pModType))
			{
				bool bValue = true;
				SetButtons(ref bValue);
			}
		}
	}

	private void txtHD_Leave(object eventSender, EventArgs eventArgs)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		if (Strings.Len(txtHD.Text) == 0)
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Invalid number. Please enter a valid number.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
			((TextBoxBase)txtHD).SelectionStart = 0;
			((TextBoxBase)txtHD).SelectionLength = Strings.Len(txtHD.Text);
			((Control)txtHD).Focus();
			return;
		}
		if (!Versioned.IsNumeric((object)txtHD.Text))
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Invalid number. Please enter a valid number.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
			((TextBoxBase)txtHD).SelectionStart = 0;
			((TextBoxBase)txtHD).SelectionLength = Strings.Len(txtHD.Text);
			((Control)txtHD).Focus();
			return;
		}
		short pID = 35;
		object pValue = txtHD.Text;
		short pModType = 0;
		if (!ChemStrX.ValidateParmInput(ref pID, ref pValue, ref pModType))
		{
			((TextBoxBase)txtHD).SelectionStart = 0;
			((TextBoxBase)txtHD).SelectionLength = Strings.Len(txtHD.Text);
			((Control)txtHD).Focus();
		}
	}

	private void txtLFb_TextChanged(object eventSender, EventArgs eventArgs)
	{
		if (Strings.Len(txtLFb.Text) > 0 && Versioned.IsNumeric((object)txtLFb.Text) && Conversions.ToDouble(txtLFb.Text) != 0.0)
		{
			short pID = 127;
			object pValue = txtLFb.Text;
			short pModType = 0;
			if (ChemStrX.ValidateParmInput(ref pID, ref pValue, ref pModType))
			{
				bool bValue = true;
				SetButtons(ref bValue);
			}
		}
	}

	private void txtLFb_Leave(object eventSender, EventArgs eventArgs)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		if (Strings.Len(txtLFb.Text) == 0)
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Invalid number. Please enter a valid number.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
			((TextBoxBase)txtLFb).SelectionStart = 0;
			((TextBoxBase)txtLFb).SelectionLength = Strings.Len(txtLFb.Text);
			((Control)txtLFb).Focus();
			return;
		}
		if (!Versioned.IsNumeric((object)txtLFb.Text))
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Invalid number. Please enter a valid number.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
			((TextBoxBase)txtLFb).SelectionStart = 0;
			((TextBoxBase)txtLFb).SelectionLength = Strings.Len(txtLFb.Text);
			((Control)txtLFb).Focus();
			return;
		}
		short pID = 127;
		object pValue = txtLFb.Text;
		short pModType = 0;
		if (!ChemStrX.ValidateParmInput(ref pID, ref pValue, ref pModType))
		{
			((TextBoxBase)txtLFb).SelectionStart = 0;
			((TextBoxBase)txtLFb).SelectionLength = Strings.Len(txtLFb.Text);
			((Control)txtLFb).Focus();
		}
	}

	private void txtLFe_TextChanged(object eventSender, EventArgs eventArgs)
	{
		if (Strings.Len(txtLFe.Text) > 0 && Versioned.IsNumeric((object)txtLFe.Text) && Conversions.ToDouble(txtLFe.Text) != 0.0)
		{
			short pID = 129;
			object pValue = txtLFe.Text;
			short pModType = 0;
			if (ChemStrX.ValidateParmInput(ref pID, ref pValue, ref pModType))
			{
				bool bValue = true;
				SetButtons(ref bValue);
			}
		}
	}

	private void txtLFe_Leave(object eventSender, EventArgs eventArgs)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		if (Strings.Len(txtLFe.Text) == 0)
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Invalid number. Please enter a valid number.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
			((TextBoxBase)txtLFe).SelectionStart = 0;
			((TextBoxBase)txtLFe).SelectionLength = Strings.Len(txtLFe.Text);
			((Control)txtLFe).Focus();
			return;
		}
		if (!Versioned.IsNumeric((object)txtLFe.Text))
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Invalid number. Please enter a valid number.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
			((TextBoxBase)txtLFe).SelectionStart = 0;
			((TextBoxBase)txtLFe).SelectionLength = Strings.Len(txtLFe.Text);
			((Control)txtLFe).Focus();
			return;
		}
		short pID = 129;
		object pValue = txtLFe.Text;
		short pModType = 0;
		if (!ChemStrX.ValidateParmInput(ref pID, ref pValue, ref pModType))
		{
			((TextBoxBase)txtLFe).SelectionStart = 0;
			((TextBoxBase)txtLFe).SelectionLength = Strings.Len(txtLFe.Text);
			((Control)txtLFe).Focus();
		}
	}

	private void txtLFw_TextChanged(object eventSender, EventArgs eventArgs)
	{
		if (Strings.Len(txtLFw.Text) > 0 && Versioned.IsNumeric((object)txtLFw.Text) && Conversions.ToDouble(txtLFw.Text) != 0.0)
		{
			short pID = 128;
			object pValue = txtLFw.Text;
			short pModType = 0;
			if (ChemStrX.ValidateParmInput(ref pID, ref pValue, ref pModType))
			{
				bool bValue = true;
				SetButtons(ref bValue);
			}
		}
	}

	private void txtLFw_Leave(object eventSender, EventArgs eventArgs)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		if (Strings.Len(txtLFw.Text) == 0)
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Invalid number. Please enter a valid number.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
			((TextBoxBase)txtLFw).SelectionStart = 0;
			((TextBoxBase)txtLFw).SelectionLength = Strings.Len(txtLFw.Text);
			((Control)txtLFw).Focus();
			return;
		}
		if (!Versioned.IsNumeric((object)txtLFw.Text))
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Invalid number. Please enter a valid number.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
			((TextBoxBase)txtLFw).SelectionStart = 0;
			((TextBoxBase)txtLFw).SelectionLength = Strings.Len(txtLFw.Text);
			((Control)txtLFw).Focus();
			return;
		}
		short pID = 128;
		object pValue = txtLFw.Text;
		short pModType = 0;
		if (!ChemStrX.ValidateParmInput(ref pID, ref pValue, ref pModType))
		{
			((TextBoxBase)txtLFw).SelectionStart = 0;
			((TextBoxBase)txtLFw).SelectionLength = Strings.Len(txtLFw.Text);
			((Control)txtLFw).Focus();
		}
	}

	private void txtNcar_TextChanged(object eventSender, EventArgs eventArgs)
	{
		bool bValue = true;
		SetButtons(ref bValue);
	}

	private void txtRRctw_TextChanged(object eventSender, EventArgs eventArgs)
	{
		if (Strings.Len(txtRRctw.Text) > 0 && Versioned.IsNumeric((object)txtRRctw.Text) && Conversions.ToDouble(txtRRctw.Text) != 0.0)
		{
			short pID = 126;
			object pValue = txtRRctw.Text;
			short pModType = 0;
			if (ChemStrX.ValidateParmInput(ref pID, ref pValue, ref pModType))
			{
				bool bValue = true;
				SetButtons(ref bValue);
			}
		}
	}

	private void txtUserInput_TextChanged(object eventSender, EventArgs eventArgs)
	{
		if (Versioned.IsNumeric((object)txtUserInput.Text))
		{
			bool bValue = false;
			SetButtons(ref bValue);
		}
		else
		{
			bool bValue = true;
			SetButtons(ref bValue);
		}
	}

	private void txtUserInput101_TextChanged(object eventSender, EventArgs eventArgs)
	{
		if (Versioned.IsNumeric((object)txtUserInput101.Text))
		{
			bool bValue = false;
			SetButtons(ref bValue);
		}
		else
		{
			bool bValue = true;
			SetButtons(ref bValue);
		}
	}

	private void txtVbatch_TextChanged(object eventSender, EventArgs eventArgs)
	{
		bool bValue = true;
		SetButtons(ref bValue);
	}

	private void txtVcar_TextChanged(object eventSender, EventArgs eventArgs)
	{
		bool bValue = true;
		SetButtons(ref bValue);
	}

	private void txtVpaint_TextChanged(object eventSender, EventArgs eventArgs)
	{
		bool bValue = true;
		SetButtons(ref bValue);
	}

	private void txtYctw_TextChanged(object eventSender, EventArgs eventArgs)
	{
		bool bValue = true;
		SetButtons(ref bValue);
	}

	private void _txt104_4_Leave(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		if ((int)_chkFix_8.CheckState == 1 && Operators.CompareString(_txt104_4.Text, ChemStrX.ShowInSciNot(ChemStrX.ShowZeroAsNull(frmMDUpdOpIP.DefInstance.sYbath)), false) != 0)
		{
			short num = checked((short)Interaction.MsgBox((object)"Would you like to update Yrinse to the default, Yrinse = 0.5 x Ybath?", (MsgBoxStyle)36, (object)null));
			if (num == 6)
			{
				_txt104_8.Text = Conversions.ToString(0.5 * Conversions.ToDouble(_txt104_4.Text));
				_chkFix_8.CheckState = (CheckState)0;
			}
		}
	}

	private void _chkFix_0_CheckStateChanged(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		if ((int)_chkFix_0.CheckState == 1)
		{
			((TextBoxBase)_txt104_0).ReadOnly = false;
			((TextBoxBase)_txt104_0).BackColor = Color.White;
		}
		else
		{
			((TextBoxBase)_txt104_0).ReadOnly = true;
			((TextBoxBase)_txt104_0).BackColor = ((Form)this).BackColor;
		}
		bool bValue = true;
		SetButtons(ref bValue);
	}

	private void _chkFix_6_CheckStateChanged(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		if ((int)_chkFix_6.CheckState == 1)
		{
			((TextBoxBase)_txt104_6).ReadOnly = false;
			((TextBoxBase)_txt104_6).BackColor = Color.White;
		}
		else
		{
			((TextBoxBase)_txt104_6).ReadOnly = true;
			((TextBoxBase)_txt104_6).BackColor = ((Form)this).BackColor;
		}
		bool bValue = true;
		SetButtons(ref bValue);
	}

	private void _chkFix_8_CheckStateChanged(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		if ((int)_chkFix_8.CheckState == 1)
		{
			((TextBoxBase)_txt104_8).ReadOnly = false;
			((TextBoxBase)_txt104_8).BackColor = Color.White;
		}
		else
		{
			((TextBoxBase)_txt104_8).ReadOnly = true;
			((TextBoxBase)_txt104_8).BackColor = ((Form)this).BackColor;
		}
		bool bValue = true;
		SetButtons(ref bValue);
	}

	private void _txt104_0_TextChanged(object sender, EventArgs e)
	{
		change_txt104(0);
	}

	private void _txt104_1_TextChanged(object sender, EventArgs e)
	{
		change_txt104(1);
	}

	private void _txt104_10_TextChanged(object sender, EventArgs e)
	{
		change_txt104(10);
	}

	private void _txt104_2_TextChanged(object sender, EventArgs e)
	{
		change_txt104(2);
	}

	private void _txt104_3_TextChanged(object sender, EventArgs e)
	{
		change_txt104(3);
	}

	private void _txt104_4_TextChanged(object sender, EventArgs e)
	{
		change_txt104(4);
	}

	private void _txt104_5_TextChanged(object sender, EventArgs e)
	{
		change_txt104(5);
	}

	private void _txt104_6_TextChanged(object sender, EventArgs e)
	{
		change_txt104(6);
	}

	private void _txt104_7_TextChanged(object sender, EventArgs e)
	{
		change_txt104(7);
	}

	private void _txt104_8_TextChanged(object sender, EventArgs e)
	{
		change_txt104(8);
	}

	private void _txt104_9_TextChanged(object sender, EventArgs e)
	{
		change_txt104(9);
	}
}
