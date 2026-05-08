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

internal class frmMDUpdRelMed : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("_txtMedia_17")]
	private TextBox __txtMedia_17;

	[AccessedThroughProperty("txtBasis")]
	private TextBox _txtBasis;

	[AccessedThroughProperty("_txtMedia_14")]
	private TextBox __txtMedia_14;

	[AccessedThroughProperty("_txtMedia_12")]
	private TextBox __txtMedia_12;

	[AccessedThroughProperty("_txtMedia_13")]
	private TextBox __txtMedia_13;

	[AccessedThroughProperty("_txtMedia_15")]
	private TextBox __txtMedia_15;

	[AccessedThroughProperty("_txtMedia_16")]
	private TextBox __txtMedia_16;

	[AccessedThroughProperty("_txtMedia_6")]
	private TextBox __txtMedia_6;

	[AccessedThroughProperty("_txtMedia_7")]
	private TextBox __txtMedia_7;

	[AccessedThroughProperty("_txtMedia_8")]
	private TextBox __txtMedia_8;

	[AccessedThroughProperty("_txtMedia_9")]
	private TextBox __txtMedia_9;

	[AccessedThroughProperty("_txtMedia_10")]
	private TextBox __txtMedia_10;

	[AccessedThroughProperty("_txtMedia_11")]
	private TextBox __txtMedia_11;

	[AccessedThroughProperty("txtNAICS")]
	private TextBox _txtNAICS;

	[AccessedThroughProperty("_txtMedia_5")]
	private TextBox __txtMedia_5;

	[AccessedThroughProperty("_txtMedia_4")]
	private TextBox __txtMedia_4;

	[AccessedThroughProperty("_txtMedia_3")]
	private TextBox __txtMedia_3;

	[AccessedThroughProperty("_txtMedia_2")]
	private TextBox __txtMedia_2;

	[AccessedThroughProperty("_txtMedia_1")]
	private TextBox __txtMedia_1;

	[AccessedThroughProperty("_txtMedia_0")]
	private TextBox __txtMedia_0;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("cmdOk")]
	private Button _cmdOk;

	[AccessedThroughProperty("_lblMedia_17")]
	private Label __lblMedia_17;

	[AccessedThroughProperty("_Label1_4")]
	private Label __Label1_4;

	[AccessedThroughProperty("_Label1_1")]
	private Label __Label1_1;

	[AccessedThroughProperty("_lblMedia_12")]
	private Label __lblMedia_12;

	[AccessedThroughProperty("_lblMedia_13")]
	private Label __lblMedia_13;

	[AccessedThroughProperty("_Label1_31")]
	private Label __Label1_31;

	[AccessedThroughProperty("_Label1_30")]
	private Label __Label1_30;

	[AccessedThroughProperty("_Label1_29")]
	private Label __Label1_29;

	[AccessedThroughProperty("_Label1_27")]
	private Label __Label1_27;

	[AccessedThroughProperty("_Label1_26")]
	private Label __Label1_26;

	[AccessedThroughProperty("_Label1_19")]
	private Label __Label1_19;

	[AccessedThroughProperty("_Label1_18")]
	private Label __Label1_18;

	[AccessedThroughProperty("_Label1_17")]
	private Label __Label1_17;

	[AccessedThroughProperty("_Label1_16")]
	private Label __Label1_16;

	[AccessedThroughProperty("_Label1_9")]
	private Label __Label1_9;

	[AccessedThroughProperty("_Label1_2")]
	private Label __Label1_2;

	[AccessedThroughProperty("_Label1_0")]
	private Label __Label1_0;

	[AccessedThroughProperty("lblInstructions")]
	private Label _lblInstructions;

	[AccessedThroughProperty("_Line1_1")]
	private Label __Line1_1;

	[AccessedThroughProperty("_Label1_15")]
	private Label __Label1_15;

	[AccessedThroughProperty("_Label1_14")]
	private Label __Label1_14;

	[AccessedThroughProperty("_Label1_13")]
	private Label __Label1_13;

	[AccessedThroughProperty("_Label1_12")]
	private Label __Label1_12;

	[AccessedThroughProperty("_Label1_11")]
	private Label __Label1_11;

	[AccessedThroughProperty("_Label1_10")]
	private Label __Label1_10;

	[AccessedThroughProperty("lblTotal")]
	private Label _lblTotal;

	[AccessedThroughProperty("_Line1_0")]
	private Label __Line1_0;

	[AccessedThroughProperty("_Label1_3")]
	private Label __Label1_3;

	[AccessedThroughProperty("_lblMedia_5")]
	private Label __lblMedia_5;

	[AccessedThroughProperty("_lblMedia_4")]
	private Label __lblMedia_4;

	[AccessedThroughProperty("_lblMedia_3")]
	private Label __lblMedia_3;

	[AccessedThroughProperty("_lblMedia_2")]
	private Label __lblMedia_2;

	[AccessedThroughProperty("_lblMedia_1")]
	private Label __lblMedia_1;

	[AccessedThroughProperty("_lblMedia_0")]
	private Label __lblMedia_0;

	[AccessedThroughProperty("lblAct")]
	private Label _lblAct;

	[AccessedThroughProperty("lblOp")]
	private Label _lblOp;

	[AccessedThroughProperty("_lblMedia_6")]
	private Label __lblMedia_6;

	[AccessedThroughProperty("_lblMedia_7")]
	private Label __lblMedia_7;

	[AccessedThroughProperty("_lblMedia_8")]
	private Label __lblMedia_8;

	[AccessedThroughProperty("_lblMedia_9")]
	private Label __lblMedia_9;

	[AccessedThroughProperty("_lblMedia_10")]
	private Label __lblMedia_10;

	[AccessedThroughProperty("_lblMedia_11")]
	private Label __lblMedia_11;

	[AccessedThroughProperty("_lblMedia_14")]
	private Label __lblMedia_14;

	[AccessedThroughProperty("_lblMedia_15")]
	private Label __lblMedia_15;

	[AccessedThroughProperty("_lblMedia_16")]
	private Label __lblMedia_16;

	[AccessedThroughProperty("Label1")]
	private LabelArray _Label1;

	[AccessedThroughProperty("Line1")]
	private LabelArray _Line1;

	[AccessedThroughProperty("lblMedia")]
	private LabelArray _lblMedia;

	[AccessedThroughProperty("txtMedia")]
	private TextBoxArray _txtMedia;

	private static frmMDUpdRelMed m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	public virtual TextBox _txtMedia_17
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtMedia_17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtMedia_Enter;
			if (__txtMedia_17 != null)
			{
				((TextBoxBase)__txtMedia_17).Click -= eventHandler;
			}
			__txtMedia_17 = value;
			if (__txtMedia_17 != null)
			{
				((TextBoxBase)__txtMedia_17).Click += eventHandler;
			}
		}
	}

	public virtual TextBox txtBasis
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtBasis;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtBasis_Leave;
			if (_txtBasis != null)
			{
				((Control)_txtBasis).Leave -= eventHandler;
			}
			_txtBasis = value;
			if (_txtBasis != null)
			{
				((Control)_txtBasis).Leave += eventHandler;
			}
		}
	}

	public virtual TextBox _txtMedia_14
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtMedia_14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtMedia_Enter;
			if (__txtMedia_14 != null)
			{
				((TextBoxBase)__txtMedia_14).Click -= eventHandler;
			}
			__txtMedia_14 = value;
			if (__txtMedia_14 != null)
			{
				((TextBoxBase)__txtMedia_14).Click += eventHandler;
			}
		}
	}

	public virtual TextBox _txtMedia_12
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtMedia_12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtMedia_Enter;
			if (__txtMedia_12 != null)
			{
				((TextBoxBase)__txtMedia_12).Click -= eventHandler;
			}
			__txtMedia_12 = value;
			if (__txtMedia_12 != null)
			{
				((TextBoxBase)__txtMedia_12).Click += eventHandler;
			}
		}
	}

	public virtual TextBox _txtMedia_13
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtMedia_13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtMedia_Enter;
			if (__txtMedia_13 != null)
			{
				((TextBoxBase)__txtMedia_13).Click -= eventHandler;
			}
			__txtMedia_13 = value;
			if (__txtMedia_13 != null)
			{
				((TextBoxBase)__txtMedia_13).Click += eventHandler;
			}
		}
	}

	public virtual TextBox _txtMedia_15
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtMedia_15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtMedia_Enter;
			if (__txtMedia_15 != null)
			{
				((TextBoxBase)__txtMedia_15).Click -= eventHandler;
			}
			__txtMedia_15 = value;
			if (__txtMedia_15 != null)
			{
				((TextBoxBase)__txtMedia_15).Click += eventHandler;
			}
		}
	}

	public virtual TextBox _txtMedia_16
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtMedia_16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtMedia_Enter;
			if (__txtMedia_16 != null)
			{
				((TextBoxBase)__txtMedia_16).Click -= eventHandler;
			}
			__txtMedia_16 = value;
			if (__txtMedia_16 != null)
			{
				((TextBoxBase)__txtMedia_16).Click += eventHandler;
			}
		}
	}

	public virtual TextBox _txtMedia_6
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtMedia_6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtMedia_Enter;
			if (__txtMedia_6 != null)
			{
				((TextBoxBase)__txtMedia_6).Click -= eventHandler;
			}
			__txtMedia_6 = value;
			if (__txtMedia_6 != null)
			{
				((TextBoxBase)__txtMedia_6).Click += eventHandler;
			}
		}
	}

	public virtual TextBox _txtMedia_7
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtMedia_7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtMedia_Enter;
			if (__txtMedia_7 != null)
			{
				((TextBoxBase)__txtMedia_7).Click -= eventHandler;
			}
			__txtMedia_7 = value;
			if (__txtMedia_7 != null)
			{
				((TextBoxBase)__txtMedia_7).Click += eventHandler;
			}
		}
	}

	public virtual TextBox _txtMedia_8
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtMedia_8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtMedia_Enter;
			if (__txtMedia_8 != null)
			{
				((TextBoxBase)__txtMedia_8).Click -= eventHandler;
			}
			__txtMedia_8 = value;
			if (__txtMedia_8 != null)
			{
				((TextBoxBase)__txtMedia_8).Click += eventHandler;
			}
		}
	}

	public virtual TextBox _txtMedia_9
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtMedia_9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtMedia_Enter;
			if (__txtMedia_9 != null)
			{
				((TextBoxBase)__txtMedia_9).Click -= eventHandler;
			}
			__txtMedia_9 = value;
			if (__txtMedia_9 != null)
			{
				((TextBoxBase)__txtMedia_9).Click += eventHandler;
			}
		}
	}

	public virtual TextBox _txtMedia_10
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtMedia_10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtMedia_Enter;
			if (__txtMedia_10 != null)
			{
				((TextBoxBase)__txtMedia_10).Click -= eventHandler;
			}
			__txtMedia_10 = value;
			if (__txtMedia_10 != null)
			{
				((TextBoxBase)__txtMedia_10).Click += eventHandler;
			}
		}
	}

	public virtual TextBox _txtMedia_11
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtMedia_11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtMedia_Enter;
			if (__txtMedia_11 != null)
			{
				((TextBoxBase)__txtMedia_11).Click -= eventHandler;
			}
			__txtMedia_11 = value;
			if (__txtMedia_11 != null)
			{
				((TextBoxBase)__txtMedia_11).Click += eventHandler;
			}
		}
	}

	public virtual TextBox txtNAICS
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNAICS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtNAICS_Leave;
			if (_txtNAICS != null)
			{
				((Control)_txtNAICS).Leave -= eventHandler;
			}
			_txtNAICS = value;
			if (_txtNAICS != null)
			{
				((Control)_txtNAICS).Leave += eventHandler;
			}
		}
	}

	public virtual TextBox _txtMedia_5
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtMedia_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtMedia_Enter;
			if (__txtMedia_5 != null)
			{
				((TextBoxBase)__txtMedia_5).Click -= eventHandler;
			}
			__txtMedia_5 = value;
			if (__txtMedia_5 != null)
			{
				((TextBoxBase)__txtMedia_5).Click += eventHandler;
			}
		}
	}

	public virtual TextBox _txtMedia_4
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtMedia_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtMedia_Enter;
			if (__txtMedia_4 != null)
			{
				((TextBoxBase)__txtMedia_4).Click -= eventHandler;
			}
			__txtMedia_4 = value;
			if (__txtMedia_4 != null)
			{
				((TextBoxBase)__txtMedia_4).Click += eventHandler;
			}
		}
	}

	public virtual TextBox _txtMedia_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtMedia_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtMedia_Enter;
			if (__txtMedia_3 != null)
			{
				((TextBoxBase)__txtMedia_3).Click -= eventHandler;
			}
			__txtMedia_3 = value;
			if (__txtMedia_3 != null)
			{
				((TextBoxBase)__txtMedia_3).Click += eventHandler;
			}
		}
	}

	public virtual TextBox _txtMedia_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtMedia_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtMedia_Enter;
			if (__txtMedia_2 != null)
			{
				((TextBoxBase)__txtMedia_2).Click -= eventHandler;
			}
			__txtMedia_2 = value;
			if (__txtMedia_2 != null)
			{
				((TextBoxBase)__txtMedia_2).Click += eventHandler;
			}
		}
	}

	public virtual TextBox _txtMedia_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtMedia_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtMedia_Enter;
			if (__txtMedia_1 != null)
			{
				((TextBoxBase)__txtMedia_1).Click -= eventHandler;
			}
			__txtMedia_1 = value;
			if (__txtMedia_1 != null)
			{
				((TextBoxBase)__txtMedia_1).Click += eventHandler;
			}
		}
	}

	public virtual TextBox _txtMedia_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtMedia_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtMedia_Enter;
			if (__txtMedia_0 != null)
			{
				((TextBoxBase)__txtMedia_0).Click -= eventHandler;
			}
			__txtMedia_0 = value;
			if (__txtMedia_0 != null)
			{
				((TextBoxBase)__txtMedia_0).Click += eventHandler;
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

	public virtual Label _lblMedia_17
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblMedia_17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblMedia_17 = value;
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

	public virtual Label _lblMedia_12
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblMedia_12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblMedia_12 = value;
		}
	}

	public virtual Label _lblMedia_13
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblMedia_13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblMedia_13 = value;
		}
	}

	public virtual Label _Label1_31
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_31;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_31 = value;
		}
	}

	public virtual Label _Label1_30
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_30;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_30 = value;
		}
	}

	public virtual Label _Label1_29
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_29;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_29 = value;
		}
	}

	public virtual Label _Label1_27
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_27;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_27 = value;
		}
	}

	public virtual Label _Label1_26
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_26;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_26 = value;
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

	public virtual Label lblTotal
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTotal;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTotal = value;
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

	public virtual Label _lblMedia_5
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblMedia_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblMedia_5 = value;
		}
	}

	public virtual Label _lblMedia_4
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblMedia_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblMedia_4 = value;
		}
	}

	public virtual Label _lblMedia_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblMedia_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblMedia_3 = value;
		}
	}

	public virtual Label _lblMedia_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblMedia_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblMedia_2 = value;
		}
	}

	public virtual Label _lblMedia_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblMedia_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblMedia_1 = value;
		}
	}

	public virtual Label _lblMedia_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblMedia_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblMedia_0 = value;
		}
	}

	public virtual Label lblAct
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblAct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblAct = value;
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

	public virtual Label _lblMedia_6
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblMedia_6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblMedia_6 = value;
		}
	}

	public virtual Label _lblMedia_7
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblMedia_7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblMedia_7 = value;
		}
	}

	public virtual Label _lblMedia_8
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblMedia_8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblMedia_8 = value;
		}
	}

	public virtual Label _lblMedia_9
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblMedia_9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblMedia_9 = value;
		}
	}

	public virtual Label _lblMedia_10
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblMedia_10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblMedia_10 = value;
		}
	}

	public virtual Label _lblMedia_11
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblMedia_11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblMedia_11 = value;
		}
	}

	public virtual Label _lblMedia_14
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblMedia_14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblMedia_14 = value;
		}
	}

	public virtual Label _lblMedia_15
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblMedia_15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblMedia_15 = value;
		}
	}

	public virtual Label _lblMedia_16
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblMedia_16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblMedia_16 = value;
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

	public virtual LabelArray lblMedia
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMedia;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMedia = value;
		}
	}

	public virtual TextBoxArray txtMedia
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMedia;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtMedia_Leave;
			if (_txtMedia != null)
			{
				_txtMedia.Leave -= eventHandler;
			}
			_txtMedia = value;
			if (_txtMedia != null)
			{
				_txtMedia.Leave += eventHandler;
			}
		}
	}

	public static frmMDUpdRelMed DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmMDUpdRelMed();
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

	public frmMDUpdRelMed()
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
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Expected O, but got Unknown
		//IL_04f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Expected O, but got Unknown
		//IL_05df: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e9: Expected O, but got Unknown
		//IL_06c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cd: Expected O, but got Unknown
		//IL_07a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b1: Expected O, but got Unknown
		//IL_088b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0895: Expected O, but got Unknown
		//IL_096f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0979: Expected O, but got Unknown
		//IL_0a53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5d: Expected O, but got Unknown
		//IL_0b35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3f: Expected O, but got Unknown
		//IL_0c18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c22: Expected O, but got Unknown
		//IL_0cfb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d05: Expected O, but got Unknown
		//IL_0ddf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de9: Expected O, but got Unknown
		//IL_0ec3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ecd: Expected O, but got Unknown
		//IL_0fa7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb1: Expected O, but got Unknown
		//IL_1090: Unknown result type (might be due to invalid IL or missing references)
		//IL_109a: Expected O, but got Unknown
		//IL_1172: Unknown result type (might be due to invalid IL or missing references)
		//IL_117c: Expected O, but got Unknown
		//IL_1254: Unknown result type (might be due to invalid IL or missing references)
		//IL_125e: Expected O, but got Unknown
		//IL_1336: Unknown result type (might be due to invalid IL or missing references)
		//IL_1340: Expected O, but got Unknown
		//IL_1418: Unknown result type (might be due to invalid IL or missing references)
		//IL_1422: Expected O, but got Unknown
		//IL_14fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1504: Expected O, but got Unknown
		//IL_15dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e6: Expected O, but got Unknown
		//IL_16b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ba: Expected O, but got Unknown
		//IL_1784: Unknown result type (might be due to invalid IL or missing references)
		//IL_178e: Expected O, but got Unknown
		//IL_186c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1876: Expected O, but got Unknown
		//IL_1946: Unknown result type (might be due to invalid IL or missing references)
		//IL_1950: Expected O, but got Unknown
		//IL_1a29: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a33: Expected O, but got Unknown
		//IL_1b14: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b1e: Expected O, but got Unknown
		//IL_1bff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c09: Expected O, but got Unknown
		//IL_1cda: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ce4: Expected O, but got Unknown
		//IL_1db5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dbf: Expected O, but got Unknown
		//IL_1e90: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e9a: Expected O, but got Unknown
		//IL_1f6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f75: Expected O, but got Unknown
		//IL_2046: Unknown result type (might be due to invalid IL or missing references)
		//IL_2050: Expected O, but got Unknown
		//IL_2121: Unknown result type (might be due to invalid IL or missing references)
		//IL_212b: Expected O, but got Unknown
		//IL_21fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2206: Expected O, but got Unknown
		//IL_22d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_22e1: Expected O, but got Unknown
		//IL_23b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_23bc: Expected O, but got Unknown
		//IL_248d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2497: Expected O, but got Unknown
		//IL_2567: Unknown result type (might be due to invalid IL or missing references)
		//IL_2571: Expected O, but got Unknown
		//IL_264a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2654: Expected O, but got Unknown
		//IL_2786: Unknown result type (might be due to invalid IL or missing references)
		//IL_2790: Expected O, but got Unknown
		//IL_2861: Unknown result type (might be due to invalid IL or missing references)
		//IL_286b: Expected O, but got Unknown
		//IL_293c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2946: Expected O, but got Unknown
		//IL_2a17: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a21: Expected O, but got Unknown
		//IL_2af2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2afc: Expected O, but got Unknown
		//IL_2bcd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bd7: Expected O, but got Unknown
		//IL_2ca8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cb2: Expected O, but got Unknown
		//IL_2ded: Unknown result type (might be due to invalid IL or missing references)
		//IL_2df7: Expected O, but got Unknown
		//IL_2ed4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ede: Expected O, but got Unknown
		//IL_2fbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fc5: Expected O, but got Unknown
		//IL_30a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_30ab: Expected O, but got Unknown
		//IL_3188: Unknown result type (might be due to invalid IL or missing references)
		//IL_3192: Expected O, but got Unknown
		//IL_326e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3278: Expected O, but got Unknown
		//IL_3355: Unknown result type (might be due to invalid IL or missing references)
		//IL_335f: Expected O, but got Unknown
		//IL_343c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3446: Expected O, but got Unknown
		//IL_34ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_3509: Expected O, but got Unknown
		//IL_35c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_35cc: Expected O, but got Unknown
		//IL_36a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_36b3: Expected O, but got Unknown
		//IL_3790: Unknown result type (might be due to invalid IL or missing references)
		//IL_379a: Expected O, but got Unknown
		//IL_387a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3884: Expected O, but got Unknown
		//IL_3965: Unknown result type (might be due to invalid IL or missing references)
		//IL_396f: Expected O, but got Unknown
		//IL_3a50: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a5a: Expected O, but got Unknown
		//IL_3b3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b45: Expected O, but got Unknown
		//IL_3c26: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c30: Expected O, but got Unknown
		//IL_3d0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d18: Expected O, but got Unknown
		//IL_42d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_42e3: Expected O, but got Unknown
		//IL_42f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_4302: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMDUpdRelMed));
		ToolTip1 = new ToolTip(components);
		_txtMedia_17 = new TextBox();
		txtBasis = new TextBox();
		_txtMedia_14 = new TextBox();
		_txtMedia_12 = new TextBox();
		_txtMedia_13 = new TextBox();
		_txtMedia_15 = new TextBox();
		_txtMedia_16 = new TextBox();
		_txtMedia_6 = new TextBox();
		_txtMedia_7 = new TextBox();
		_txtMedia_8 = new TextBox();
		_txtMedia_9 = new TextBox();
		_txtMedia_10 = new TextBox();
		_txtMedia_11 = new TextBox();
		txtNAICS = new TextBox();
		_txtMedia_5 = new TextBox();
		_txtMedia_4 = new TextBox();
		_txtMedia_3 = new TextBox();
		_txtMedia_2 = new TextBox();
		_txtMedia_1 = new TextBox();
		_txtMedia_0 = new TextBox();
		cmdCancel = new Button();
		cmdOk = new Button();
		_lblMedia_17 = new Label();
		_Label1_4 = new Label();
		_Label1_1 = new Label();
		_lblMedia_12 = new Label();
		_lblMedia_13 = new Label();
		_Label1_31 = new Label();
		_Label1_30 = new Label();
		_Label1_29 = new Label();
		_Label1_27 = new Label();
		_Label1_26 = new Label();
		_Label1_19 = new Label();
		_Label1_18 = new Label();
		_Label1_17 = new Label();
		_Label1_16 = new Label();
		_Label1_9 = new Label();
		_Label1_2 = new Label();
		_Label1_0 = new Label();
		lblInstructions = new Label();
		_Line1_1 = new Label();
		_Label1_15 = new Label();
		_Label1_14 = new Label();
		_Label1_13 = new Label();
		_Label1_12 = new Label();
		_Label1_11 = new Label();
		_Label1_10 = new Label();
		lblTotal = new Label();
		_Line1_0 = new Label();
		_Label1_3 = new Label();
		_lblMedia_5 = new Label();
		_lblMedia_4 = new Label();
		_lblMedia_3 = new Label();
		_lblMedia_2 = new Label();
		_lblMedia_1 = new Label();
		_lblMedia_0 = new Label();
		lblAct = new Label();
		lblOp = new Label();
		_lblMedia_6 = new Label();
		_lblMedia_7 = new Label();
		_lblMedia_8 = new Label();
		_lblMedia_9 = new Label();
		_lblMedia_10 = new Label();
		_lblMedia_11 = new Label();
		_lblMedia_14 = new Label();
		_lblMedia_15 = new Label();
		_lblMedia_16 = new Label();
		Label1 = new LabelArray(components);
		Line1 = new LabelArray(components);
		lblMedia = new LabelArray(components);
		txtMedia = new TextBoxArray(components);
		((ISupportInitialize)Label1).BeginInit();
		((ISupportInitialize)Line1).BeginInit();
		((ISupportInitialize)lblMedia).BeginInit();
		((ISupportInitialize)txtMedia).BeginInit();
		((Control)this).SuspendLayout();
		_txtMedia_17.AcceptsReturn = true;
		((TextBoxBase)_txtMedia_17).BackColor = SystemColors.Window;
		((Control)_txtMedia_17).Cursor = Cursors.IBeam;
		((Control)_txtMedia_17).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtMedia_17).ForeColor = SystemColors.WindowText;
		txtMedia.SetIndex(_txtMedia_17, (short)17);
		TextBox txtMedia_ = _txtMedia_17;
		Point location = new Point(566, 368);
		((Control)txtMedia_).Location = location;
		((TextBoxBase)_txtMedia_17).MaxLength = 5;
		((Control)_txtMedia_17).Name = "_txtMedia_17";
		((Control)_txtMedia_17).RightToLeft = (RightToLeft)0;
		TextBox txtMedia_2 = _txtMedia_17;
		Size size = new Size(36, 20);
		((Control)txtMedia_2).Size = size;
		((Control)_txtMedia_17).TabIndex = 19;
		txtBasis.AcceptsReturn = true;
		((TextBoxBase)txtBasis).BackColor = SystemColors.Window;
		((Control)txtBasis).Cursor = Cursors.IBeam;
		((Control)txtBasis).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtBasis).ForeColor = SystemColors.WindowText;
		TextBox obj = txtBasis;
		location = new Point(56, 136);
		((Control)obj).Location = location;
		((TextBoxBase)txtBasis).MaxLength = 0;
		txtBasis.Multiline = true;
		((Control)txtBasis).Name = "txtBasis";
		((Control)txtBasis).RightToLeft = (RightToLeft)0;
		txtBasis.ScrollBars = (ScrollBars)2;
		TextBox obj2 = txtBasis;
		size = new Size(553, 41);
		((Control)obj2).Size = size;
		((Control)txtBasis).TabIndex = 1;
		_txtMedia_14.AcceptsReturn = true;
		((TextBoxBase)_txtMedia_14).BackColor = SystemColors.Window;
		((Control)_txtMedia_14).Cursor = Cursors.IBeam;
		((Control)_txtMedia_14).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtMedia_14).ForeColor = SystemColors.WindowText;
		txtMedia.SetIndex(_txtMedia_14, (short)14);
		TextBox txtMedia_3 = _txtMedia_14;
		location = new Point(400, 368);
		((Control)txtMedia_3).Location = location;
		((TextBoxBase)_txtMedia_14).MaxLength = 5;
		((Control)_txtMedia_14).Name = "_txtMedia_14";
		((Control)_txtMedia_14).RightToLeft = (RightToLeft)0;
		TextBox txtMedia_4 = _txtMedia_14;
		size = new Size(36, 20);
		((Control)txtMedia_4).Size = size;
		((Control)_txtMedia_14).TabIndex = 16;
		_txtMedia_12.AcceptsReturn = true;
		((TextBoxBase)_txtMedia_12).BackColor = SystemColors.Window;
		((Control)_txtMedia_12).Cursor = Cursors.IBeam;
		((Control)_txtMedia_12).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtMedia_12).ForeColor = SystemColors.WindowText;
		txtMedia.SetIndex(_txtMedia_12, (short)12);
		TextBox txtMedia_5 = _txtMedia_12;
		location = new Point(400, 320);
		((Control)txtMedia_5).Location = location;
		((TextBoxBase)_txtMedia_12).MaxLength = 5;
		((Control)_txtMedia_12).Name = "_txtMedia_12";
		((Control)_txtMedia_12).RightToLeft = (RightToLeft)0;
		TextBox txtMedia_6 = _txtMedia_12;
		size = new Size(36, 20);
		((Control)txtMedia_6).Size = size;
		((Control)_txtMedia_12).TabIndex = 14;
		_txtMedia_13.AcceptsReturn = true;
		((TextBoxBase)_txtMedia_13).BackColor = SystemColors.Window;
		((Control)_txtMedia_13).Cursor = Cursors.IBeam;
		((Control)_txtMedia_13).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtMedia_13).ForeColor = SystemColors.WindowText;
		txtMedia.SetIndex(_txtMedia_13, (short)13);
		TextBox txtMedia_7 = _txtMedia_13;
		location = new Point(400, 344);
		((Control)txtMedia_7).Location = location;
		((TextBoxBase)_txtMedia_13).MaxLength = 5;
		((Control)_txtMedia_13).Name = "_txtMedia_13";
		((Control)_txtMedia_13).RightToLeft = (RightToLeft)0;
		TextBox txtMedia_8 = _txtMedia_13;
		size = new Size(36, 20);
		((Control)txtMedia_8).Size = size;
		((Control)_txtMedia_13).TabIndex = 15;
		_txtMedia_15.AcceptsReturn = true;
		((TextBoxBase)_txtMedia_15).BackColor = SystemColors.Window;
		((Control)_txtMedia_15).Cursor = Cursors.IBeam;
		((Control)_txtMedia_15).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtMedia_15).ForeColor = SystemColors.WindowText;
		txtMedia.SetIndex(_txtMedia_15, (short)15);
		TextBox txtMedia_9 = _txtMedia_15;
		location = new Point(566, 320);
		((Control)txtMedia_9).Location = location;
		((TextBoxBase)_txtMedia_15).MaxLength = 5;
		((Control)_txtMedia_15).Name = "_txtMedia_15";
		((Control)_txtMedia_15).RightToLeft = (RightToLeft)0;
		TextBox txtMedia_10 = _txtMedia_15;
		size = new Size(36, 20);
		((Control)txtMedia_10).Size = size;
		((Control)_txtMedia_15).TabIndex = 17;
		_txtMedia_16.AcceptsReturn = true;
		((TextBoxBase)_txtMedia_16).BackColor = SystemColors.Window;
		((Control)_txtMedia_16).Cursor = Cursors.IBeam;
		((Control)_txtMedia_16).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtMedia_16).ForeColor = SystemColors.WindowText;
		txtMedia.SetIndex(_txtMedia_16, (short)16);
		TextBox txtMedia_11 = _txtMedia_16;
		location = new Point(566, 344);
		((Control)txtMedia_11).Location = location;
		((TextBoxBase)_txtMedia_16).MaxLength = 5;
		((Control)_txtMedia_16).Name = "_txtMedia_16";
		((Control)_txtMedia_16).RightToLeft = (RightToLeft)0;
		TextBox txtMedia_12 = _txtMedia_16;
		size = new Size(36, 20);
		((Control)txtMedia_12).Size = size;
		((Control)_txtMedia_16).TabIndex = 18;
		_txtMedia_6.AcceptsReturn = true;
		((TextBoxBase)_txtMedia_6).BackColor = SystemColors.Window;
		((Control)_txtMedia_6).Cursor = Cursors.IBeam;
		((Control)_txtMedia_6).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtMedia_6).ForeColor = SystemColors.WindowText;
		txtMedia.SetIndex(_txtMedia_6, (short)6);
		TextBox txtMedia_13 = _txtMedia_6;
		location = new Point(199, 344);
		((Control)txtMedia_13).Location = location;
		((TextBoxBase)_txtMedia_6).MaxLength = 5;
		((Control)_txtMedia_6).Name = "_txtMedia_6";
		((Control)_txtMedia_6).RightToLeft = (RightToLeft)0;
		TextBox txtMedia_14 = _txtMedia_6;
		size = new Size(36, 20);
		((Control)txtMedia_14).Size = size;
		((Control)_txtMedia_6).TabIndex = 8;
		_txtMedia_7.AcceptsReturn = true;
		((TextBoxBase)_txtMedia_7).BackColor = SystemColors.Window;
		((Control)_txtMedia_7).Cursor = Cursors.IBeam;
		((Control)_txtMedia_7).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtMedia_7).ForeColor = SystemColors.WindowText;
		txtMedia.SetIndex(_txtMedia_7, (short)7);
		TextBox txtMedia_15 = _txtMedia_7;
		location = new Point(199, 368);
		((Control)txtMedia_15).Location = location;
		((TextBoxBase)_txtMedia_7).MaxLength = 5;
		((Control)_txtMedia_7).Name = "_txtMedia_7";
		((Control)_txtMedia_7).RightToLeft = (RightToLeft)0;
		TextBox txtMedia_16 = _txtMedia_7;
		size = new Size(36, 20);
		((Control)txtMedia_16).Size = size;
		((Control)_txtMedia_7).TabIndex = 9;
		_txtMedia_8.AcceptsReturn = true;
		((TextBoxBase)_txtMedia_8).BackColor = SystemColors.Window;
		((Control)_txtMedia_8).Cursor = Cursors.IBeam;
		((Control)_txtMedia_8).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtMedia_8).ForeColor = SystemColors.WindowText;
		txtMedia.SetIndex(_txtMedia_8, (short)8);
		TextBox txtMedia_17 = _txtMedia_8;
		location = new Point(400, 224);
		((Control)txtMedia_17).Location = location;
		((TextBoxBase)_txtMedia_8).MaxLength = 5;
		((Control)_txtMedia_8).Name = "_txtMedia_8";
		((Control)_txtMedia_8).RightToLeft = (RightToLeft)0;
		TextBox txtMedia_18 = _txtMedia_8;
		size = new Size(36, 20);
		((Control)txtMedia_18).Size = size;
		((Control)_txtMedia_8).TabIndex = 10;
		_txtMedia_9.AcceptsReturn = true;
		((TextBoxBase)_txtMedia_9).BackColor = SystemColors.Window;
		((Control)_txtMedia_9).Cursor = Cursors.IBeam;
		((Control)_txtMedia_9).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtMedia_9).ForeColor = SystemColors.WindowText;
		txtMedia.SetIndex(_txtMedia_9, (short)9);
		TextBox txtMedia_19 = _txtMedia_9;
		location = new Point(400, 248);
		((Control)txtMedia_19).Location = location;
		((TextBoxBase)_txtMedia_9).MaxLength = 5;
		((Control)_txtMedia_9).Name = "_txtMedia_9";
		((Control)_txtMedia_9).RightToLeft = (RightToLeft)0;
		TextBox txtMedia_20 = _txtMedia_9;
		size = new Size(36, 20);
		((Control)txtMedia_20).Size = size;
		((Control)_txtMedia_9).TabIndex = 11;
		_txtMedia_10.AcceptsReturn = true;
		((TextBoxBase)_txtMedia_10).BackColor = SystemColors.Window;
		((Control)_txtMedia_10).Cursor = Cursors.IBeam;
		((Control)_txtMedia_10).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtMedia_10).ForeColor = SystemColors.WindowText;
		txtMedia.SetIndex(_txtMedia_10, (short)10);
		TextBox txtMedia_21 = _txtMedia_10;
		location = new Point(400, 272);
		((Control)txtMedia_21).Location = location;
		((TextBoxBase)_txtMedia_10).MaxLength = 5;
		((Control)_txtMedia_10).Name = "_txtMedia_10";
		((Control)_txtMedia_10).RightToLeft = (RightToLeft)0;
		TextBox txtMedia_22 = _txtMedia_10;
		size = new Size(36, 20);
		((Control)txtMedia_22).Size = size;
		((Control)_txtMedia_10).TabIndex = 12;
		_txtMedia_11.AcceptsReturn = true;
		((TextBoxBase)_txtMedia_11).BackColor = SystemColors.Window;
		((Control)_txtMedia_11).Cursor = Cursors.IBeam;
		((Control)_txtMedia_11).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtMedia_11).ForeColor = SystemColors.WindowText;
		txtMedia.SetIndex(_txtMedia_11, (short)11);
		TextBox txtMedia_23 = _txtMedia_11;
		location = new Point(400, 296);
		((Control)txtMedia_23).Location = location;
		((TextBoxBase)_txtMedia_11).MaxLength = 5;
		((Control)_txtMedia_11).Name = "_txtMedia_11";
		((Control)_txtMedia_11).RightToLeft = (RightToLeft)0;
		TextBox txtMedia_24 = _txtMedia_11;
		size = new Size(36, 20);
		((Control)txtMedia_24).Size = size;
		((Control)_txtMedia_11).TabIndex = 13;
		txtNAICS.AcceptsReturn = true;
		((TextBoxBase)txtNAICS).BackColor = SystemColors.Window;
		((Control)txtNAICS).Cursor = Cursors.IBeam;
		((Control)txtNAICS).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtNAICS).ForeColor = SystemColors.WindowText;
		TextBox obj3 = txtNAICS;
		location = new Point(216, 88);
		((Control)obj3).Location = location;
		((TextBoxBase)txtNAICS).MaxLength = 0;
		txtNAICS.Multiline = true;
		((Control)txtNAICS).Name = "txtNAICS";
		((Control)txtNAICS).RightToLeft = (RightToLeft)0;
		txtNAICS.ScrollBars = (ScrollBars)2;
		TextBox obj4 = txtNAICS;
		size = new Size(393, 33);
		((Control)obj4).Size = size;
		((Control)txtNAICS).TabIndex = 0;
		_txtMedia_5.AcceptsReturn = true;
		((TextBoxBase)_txtMedia_5).BackColor = SystemColors.Window;
		((Control)_txtMedia_5).Cursor = Cursors.IBeam;
		((Control)_txtMedia_5).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtMedia_5).ForeColor = SystemColors.WindowText;
		txtMedia.SetIndex(_txtMedia_5, (short)5);
		TextBox txtMedia_25 = _txtMedia_5;
		location = new Point(199, 320);
		((Control)txtMedia_25).Location = location;
		((TextBoxBase)_txtMedia_5).MaxLength = 5;
		((Control)_txtMedia_5).Name = "_txtMedia_5";
		((Control)_txtMedia_5).RightToLeft = (RightToLeft)0;
		TextBox txtMedia_26 = _txtMedia_5;
		size = new Size(36, 20);
		((Control)txtMedia_26).Size = size;
		((Control)_txtMedia_5).TabIndex = 7;
		_txtMedia_4.AcceptsReturn = true;
		((TextBoxBase)_txtMedia_4).BackColor = SystemColors.Window;
		((Control)_txtMedia_4).Cursor = Cursors.IBeam;
		((Control)_txtMedia_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtMedia_4).ForeColor = SystemColors.WindowText;
		txtMedia.SetIndex(_txtMedia_4, (short)4);
		TextBox txtMedia_27 = _txtMedia_4;
		location = new Point(199, 296);
		((Control)txtMedia_27).Location = location;
		((TextBoxBase)_txtMedia_4).MaxLength = 5;
		((Control)_txtMedia_4).Name = "_txtMedia_4";
		((Control)_txtMedia_4).RightToLeft = (RightToLeft)0;
		TextBox txtMedia_28 = _txtMedia_4;
		size = new Size(36, 20);
		((Control)txtMedia_28).Size = size;
		((Control)_txtMedia_4).TabIndex = 6;
		_txtMedia_3.AcceptsReturn = true;
		((TextBoxBase)_txtMedia_3).BackColor = SystemColors.Window;
		((Control)_txtMedia_3).Cursor = Cursors.IBeam;
		((Control)_txtMedia_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtMedia_3).ForeColor = SystemColors.WindowText;
		txtMedia.SetIndex(_txtMedia_3, (short)3);
		TextBox txtMedia_29 = _txtMedia_3;
		location = new Point(199, 272);
		((Control)txtMedia_29).Location = location;
		((TextBoxBase)_txtMedia_3).MaxLength = 5;
		((Control)_txtMedia_3).Name = "_txtMedia_3";
		((Control)_txtMedia_3).RightToLeft = (RightToLeft)0;
		TextBox txtMedia_30 = _txtMedia_3;
		size = new Size(36, 20);
		((Control)txtMedia_30).Size = size;
		((Control)_txtMedia_3).TabIndex = 5;
		_txtMedia_2.AcceptsReturn = true;
		((TextBoxBase)_txtMedia_2).BackColor = SystemColors.Window;
		((Control)_txtMedia_2).Cursor = Cursors.IBeam;
		((Control)_txtMedia_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtMedia_2).ForeColor = SystemColors.WindowText;
		txtMedia.SetIndex(_txtMedia_2, (short)2);
		TextBox txtMedia_31 = _txtMedia_2;
		location = new Point(199, 248);
		((Control)txtMedia_31).Location = location;
		((TextBoxBase)_txtMedia_2).MaxLength = 5;
		((Control)_txtMedia_2).Name = "_txtMedia_2";
		((Control)_txtMedia_2).RightToLeft = (RightToLeft)0;
		TextBox txtMedia_32 = _txtMedia_2;
		size = new Size(36, 20);
		((Control)txtMedia_32).Size = size;
		((Control)_txtMedia_2).TabIndex = 4;
		_txtMedia_1.AcceptsReturn = true;
		((TextBoxBase)_txtMedia_1).BackColor = SystemColors.Window;
		((Control)_txtMedia_1).Cursor = Cursors.IBeam;
		((Control)_txtMedia_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtMedia_1).ForeColor = SystemColors.WindowText;
		txtMedia.SetIndex(_txtMedia_1, (short)1);
		TextBox txtMedia_33 = _txtMedia_1;
		location = new Point(199, 224);
		((Control)txtMedia_33).Location = location;
		((TextBoxBase)_txtMedia_1).MaxLength = 5;
		((Control)_txtMedia_1).Name = "_txtMedia_1";
		((Control)_txtMedia_1).RightToLeft = (RightToLeft)0;
		TextBox txtMedia_34 = _txtMedia_1;
		size = new Size(36, 20);
		((Control)txtMedia_34).Size = size;
		((Control)_txtMedia_1).TabIndex = 3;
		_txtMedia_0.AcceptsReturn = true;
		((TextBoxBase)_txtMedia_0).BackColor = SystemColors.Window;
		((Control)_txtMedia_0).Cursor = Cursors.IBeam;
		((Control)_txtMedia_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtMedia_0).ForeColor = SystemColors.WindowText;
		txtMedia.SetIndex(_txtMedia_0, (short)0);
		TextBox txtMedia_35 = _txtMedia_0;
		location = new Point(199, 200);
		((Control)txtMedia_35).Location = location;
		((TextBoxBase)_txtMedia_0).MaxLength = 5;
		((Control)_txtMedia_0).Name = "_txtMedia_0";
		((Control)_txtMedia_0).RightToLeft = (RightToLeft)0;
		TextBox txtMedia_36 = _txtMedia_0;
		size = new Size(36, 20);
		((Control)txtMedia_36).Size = size;
		((Control)_txtMedia_0).TabIndex = 2;
		((ButtonBase)cmdCancel).BackColor = SystemColors.Control;
		((Control)cmdCancel).Cursor = Cursors.Default;
		cmdCancel.DialogResult = (DialogResult)2;
		((Control)cmdCancel).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCancel).ForeColor = SystemColors.ControlText;
		Button obj5 = cmdCancel;
		location = new Point(320, 400);
		((Control)obj5).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		((Control)cmdCancel).RightToLeft = (RightToLeft)0;
		Button obj6 = cmdCancel;
		size = new Size(81, 25);
		((Control)obj6).Size = size;
		((Control)cmdCancel).TabIndex = 21;
		((ButtonBase)cmdCancel).Text = "Cancel";
		((ButtonBase)cmdCancel).UseVisualStyleBackColor = false;
		((ButtonBase)cmdOk).BackColor = SystemColors.Control;
		((Control)cmdOk).Cursor = Cursors.Default;
		((Control)cmdOk).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdOk).ForeColor = SystemColors.ControlText;
		Button obj7 = cmdOk;
		location = new Point(224, 400);
		((Control)obj7).Location = location;
		((Control)cmdOk).Name = "cmdOk";
		((Control)cmdOk).RightToLeft = (RightToLeft)0;
		Button obj8 = cmdOk;
		size = new Size(81, 25);
		((Control)obj8).Size = size;
		((Control)cmdOk).TabIndex = 20;
		((ButtonBase)cmdOk).Text = "OK";
		((ButtonBase)cmdOk).UseVisualStyleBackColor = false;
		((Control)_lblMedia_17).BackColor = SystemColors.Control;
		((Control)_lblMedia_17).Cursor = Cursors.Default;
		((Control)_lblMedia_17).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblMedia_17).ForeColor = SystemColors.ControlText;
		lblMedia.SetIndex(_lblMedia_17, (short)17);
		Label lblMedia_ = _lblMedia_17;
		location = new Point(454, 368);
		((Control)lblMedia_).Location = location;
		((Control)_lblMedia_17).Name = "_lblMedia_17";
		((Control)_lblMedia_17).RightToLeft = (RightToLeft)0;
		Label lblMedia_2 = _lblMedia_17;
		size = new Size(105, 17);
		((Control)lblMedia_2).Size = size;
		((Control)_lblMedia_17).TabIndex = 64;
		_lblMedia_17.Text = "x";
		_lblMedia_17.TextAlign = (ContentAlignment)4;
		((Control)_Label1_4).BackColor = SystemColors.Control;
		((Control)_Label1_4).Cursor = Cursors.Default;
		((Control)_Label1_4).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_4).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_4, (short)4);
		Label label1_ = _Label1_4;
		location = new Point(602, 368);
		((Control)label1_).Location = location;
		((Control)_Label1_4).Name = "_Label1_4";
		((Control)_Label1_4).RightToLeft = (RightToLeft)0;
		Label label1_2 = _Label1_4;
		size = new Size(17, 17);
		((Control)label1_2).Size = size;
		((Control)_Label1_4).TabIndex = 63;
		_Label1_4.Text = "%";
		((Control)_Label1_1).BackColor = SystemColors.Control;
		((Control)_Label1_1).Cursor = Cursors.Default;
		((Control)_Label1_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_1).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_1, (short)1);
		Label label1_3 = _Label1_1;
		location = new Point(8, 136);
		((Control)label1_3).Location = location;
		((Control)_Label1_1).Name = "_Label1_1";
		((Control)_Label1_1).RightToLeft = (RightToLeft)0;
		Label label1_4 = _Label1_1;
		size = new Size(41, 17);
		((Control)label1_4).Size = size;
		((Control)_Label1_1).TabIndex = 61;
		_Label1_1.Text = "Basis:";
		_Label1_1.TextAlign = (ContentAlignment)4;
		((Control)_lblMedia_12).BackColor = SystemColors.Control;
		((Control)_lblMedia_12).Cursor = Cursors.Default;
		((Control)_lblMedia_12).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblMedia_12).ForeColor = SystemColors.ControlText;
		lblMedia.SetIndex(_lblMedia_12, (short)12);
		Label lblMedia_3 = _lblMedia_12;
		location = new Point(258, 320);
		((Control)lblMedia_3).Location = location;
		((Control)_lblMedia_12).Name = "_lblMedia_12";
		((Control)_lblMedia_12).RightToLeft = (RightToLeft)0;
		Label lblMedia_4 = _lblMedia_12;
		size = new Size(134, 19);
		((Control)lblMedia_4).Size = size;
		((Control)_lblMedia_12).TabIndex = 60;
		_lblMedia_12.Text = "x";
		_lblMedia_12.TextAlign = (ContentAlignment)4;
		((Control)_lblMedia_13).BackColor = SystemColors.Control;
		((Control)_lblMedia_13).Cursor = Cursors.Default;
		((Control)_lblMedia_13).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblMedia_13).ForeColor = SystemColors.ControlText;
		lblMedia.SetIndex(_lblMedia_13, (short)13);
		Label lblMedia_5 = _lblMedia_13;
		location = new Point(258, 344);
		((Control)lblMedia_5).Location = location;
		((Control)_lblMedia_13).Name = "_lblMedia_13";
		((Control)_lblMedia_13).RightToLeft = (RightToLeft)0;
		Label lblMedia_6 = _lblMedia_13;
		size = new Size(134, 19);
		((Control)lblMedia_6).Size = size;
		((Control)_lblMedia_13).TabIndex = 59;
		_lblMedia_13.Text = "x";
		_lblMedia_13.TextAlign = (ContentAlignment)4;
		((Control)_Label1_31).BackColor = SystemColors.Control;
		((Control)_Label1_31).Cursor = Cursors.Default;
		((Control)_Label1_31).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_31).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_31, (short)31);
		Label label1_5 = _Label1_31;
		location = new Point(436, 320);
		((Control)label1_5).Location = location;
		((Control)_Label1_31).Name = "_Label1_31";
		((Control)_Label1_31).RightToLeft = (RightToLeft)0;
		Label label1_6 = _Label1_31;
		size = new Size(17, 17);
		((Control)label1_6).Size = size;
		((Control)_Label1_31).TabIndex = 55;
		_Label1_31.Text = "%";
		((Control)_Label1_30).BackColor = SystemColors.Control;
		((Control)_Label1_30).Cursor = Cursors.Default;
		((Control)_Label1_30).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_30).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_30, (short)30);
		Label label1_7 = _Label1_30;
		location = new Point(436, 344);
		((Control)label1_7).Location = location;
		((Control)_Label1_30).Name = "_Label1_30";
		((Control)_Label1_30).RightToLeft = (RightToLeft)0;
		Label label1_8 = _Label1_30;
		size = new Size(17, 17);
		((Control)label1_8).Size = size;
		((Control)_Label1_30).TabIndex = 54;
		_Label1_30.Text = "%";
		((Control)_Label1_29).BackColor = SystemColors.Control;
		((Control)_Label1_29).Cursor = Cursors.Default;
		((Control)_Label1_29).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_29).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_29, (short)29);
		Label label1_9 = _Label1_29;
		location = new Point(436, 368);
		((Control)label1_9).Location = location;
		((Control)_Label1_29).Name = "_Label1_29";
		((Control)_Label1_29).RightToLeft = (RightToLeft)0;
		Label label1_10 = _Label1_29;
		size = new Size(17, 17);
		((Control)label1_10).Size = size;
		((Control)_Label1_29).TabIndex = 53;
		_Label1_29.Text = "%";
		((Control)_Label1_27).BackColor = SystemColors.Control;
		((Control)_Label1_27).Cursor = Cursors.Default;
		((Control)_Label1_27).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_27).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_27, (short)27);
		Label label1_11 = _Label1_27;
		location = new Point(602, 344);
		((Control)label1_11).Location = location;
		((Control)_Label1_27).Name = "_Label1_27";
		((Control)_Label1_27).RightToLeft = (RightToLeft)0;
		Label label1_12 = _Label1_27;
		size = new Size(17, 17);
		((Control)label1_12).Size = size;
		((Control)_Label1_27).TabIndex = 52;
		_Label1_27.Text = "%";
		((Control)_Label1_26).BackColor = SystemColors.Control;
		((Control)_Label1_26).Cursor = Cursors.Default;
		((Control)_Label1_26).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_26).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_26, (short)26);
		Label label1_13 = _Label1_26;
		location = new Point(602, 320);
		((Control)label1_13).Location = location;
		((Control)_Label1_26).Name = "_Label1_26";
		((Control)_Label1_26).RightToLeft = (RightToLeft)0;
		Label label1_14 = _Label1_26;
		size = new Size(17, 17);
		((Control)label1_14).Size = size;
		((Control)_Label1_26).TabIndex = 51;
		_Label1_26.Text = "%";
		((Control)_Label1_19).BackColor = SystemColors.Control;
		((Control)_Label1_19).Cursor = Cursors.Default;
		((Control)_Label1_19).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_19).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_19, (short)19);
		Label label1_15 = _Label1_19;
		location = new Point(235, 344);
		((Control)label1_15).Location = location;
		((Control)_Label1_19).Name = "_Label1_19";
		((Control)_Label1_19).RightToLeft = (RightToLeft)0;
		Label label1_16 = _Label1_19;
		size = new Size(17, 17);
		((Control)label1_16).Size = size;
		((Control)_Label1_19).TabIndex = 44;
		_Label1_19.Text = "%";
		((Control)_Label1_18).BackColor = SystemColors.Control;
		((Control)_Label1_18).Cursor = Cursors.Default;
		((Control)_Label1_18).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_18).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_18, (short)18);
		Label label1_17 = _Label1_18;
		location = new Point(235, 368);
		((Control)label1_17).Location = location;
		((Control)_Label1_18).Name = "_Label1_18";
		((Control)_Label1_18).RightToLeft = (RightToLeft)0;
		Label label1_18 = _Label1_18;
		size = new Size(17, 17);
		((Control)label1_18).Size = size;
		((Control)_Label1_18).TabIndex = 43;
		_Label1_18.Text = "%";
		((Control)_Label1_17).BackColor = SystemColors.Control;
		((Control)_Label1_17).Cursor = Cursors.Default;
		((Control)_Label1_17).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_17).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_17, (short)17);
		Label label1_19 = _Label1_17;
		location = new Point(436, 224);
		((Control)label1_19).Location = location;
		((Control)_Label1_17).Name = "_Label1_17";
		((Control)_Label1_17).RightToLeft = (RightToLeft)0;
		Label label1_20 = _Label1_17;
		size = new Size(17, 17);
		((Control)label1_20).Size = size;
		((Control)_Label1_17).TabIndex = 42;
		_Label1_17.Text = "%";
		((Control)_Label1_16).BackColor = SystemColors.Control;
		((Control)_Label1_16).Cursor = Cursors.Default;
		((Control)_Label1_16).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_16).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_16, (short)16);
		Label label1_21 = _Label1_16;
		location = new Point(436, 296);
		((Control)label1_21).Location = location;
		((Control)_Label1_16).Name = "_Label1_16";
		((Control)_Label1_16).RightToLeft = (RightToLeft)0;
		Label label1_22 = _Label1_16;
		size = new Size(17, 17);
		((Control)label1_22).Size = size;
		((Control)_Label1_16).TabIndex = 41;
		_Label1_16.Text = "%";
		((Control)_Label1_9).BackColor = SystemColors.Control;
		((Control)_Label1_9).Cursor = Cursors.Default;
		((Control)_Label1_9).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_9).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_9, (short)9);
		Label label1_23 = _Label1_9;
		location = new Point(436, 272);
		((Control)label1_23).Location = location;
		((Control)_Label1_9).Name = "_Label1_9";
		((Control)_Label1_9).RightToLeft = (RightToLeft)0;
		Label label1_24 = _Label1_9;
		size = new Size(17, 17);
		((Control)label1_24).Size = size;
		((Control)_Label1_9).TabIndex = 40;
		_Label1_9.Text = "%";
		((Control)_Label1_2).BackColor = SystemColors.Control;
		((Control)_Label1_2).Cursor = Cursors.Default;
		((Control)_Label1_2).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_2).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_2, (short)2);
		Label label1_25 = _Label1_2;
		location = new Point(436, 248);
		((Control)label1_25).Location = location;
		((Control)_Label1_2).Name = "_Label1_2";
		((Control)_Label1_2).RightToLeft = (RightToLeft)0;
		Label label1_26 = _Label1_2;
		size = new Size(17, 17);
		((Control)label1_26).Size = size;
		((Control)_Label1_2).TabIndex = 39;
		_Label1_2.Text = "%";
		((Control)_Label1_0).BackColor = SystemColors.Control;
		((Control)_Label1_0).Cursor = Cursors.Default;
		((Control)_Label1_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_0).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_0, (short)0);
		Label label1_27 = _Label1_0;
		location = new Point(8, 88);
		((Control)label1_27).Location = location;
		((Control)_Label1_0).Name = "_Label1_0";
		((Control)_Label1_0).RightToLeft = (RightToLeft)0;
		Label label1_28 = _Label1_0;
		size = new Size(201, 17);
		((Control)label1_28).Size = size;
		((Control)_Label1_0).TabIndex = 38;
		_Label1_0.Text = "To (NPDES number if appropriate):";
		_Label1_0.TextAlign = (ContentAlignment)4;
		((Control)lblInstructions).BackColor = SystemColors.Control;
		((Control)lblInstructions).Cursor = Cursors.Default;
		((Control)lblInstructions).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblInstructions).ForeColor = SystemColors.ControlText;
		Label obj9 = lblInstructions;
		location = new Point(8, 8);
		((Control)obj9).Location = location;
		((Control)lblInstructions).Name = "lblInstructions";
		((Control)lblInstructions).RightToLeft = (RightToLeft)0;
		Label obj10 = lblInstructions;
		size = new Size(577, 17);
		((Control)obj10).Size = size;
		((Control)lblInstructions).TabIndex = 37;
		lblInstructions.Text = "xxx";
		((Control)_Line1_1).BackColor = SystemColors.WindowText;
		Line1.SetIndex(_Line1_1, (short)1);
		Label line1_ = _Line1_1;
		location = new Point(8, 192);
		((Control)line1_).Location = location;
		((Control)_Line1_1).Name = "_Line1_1";
		Label line1_2 = _Line1_1;
		size = new Size(608, 1);
		((Control)line1_2).Size = size;
		((Control)_Line1_1).TabIndex = 65;
		((Control)_Label1_15).BackColor = SystemColors.Control;
		((Control)_Label1_15).Cursor = Cursors.Default;
		((Control)_Label1_15).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_15).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_15, (short)15);
		Label label1_29 = _Label1_15;
		location = new Point(235, 272);
		((Control)label1_29).Location = location;
		((Control)_Label1_15).Name = "_Label1_15";
		((Control)_Label1_15).RightToLeft = (RightToLeft)0;
		Label label1_30 = _Label1_15;
		size = new Size(17, 17);
		((Control)label1_30).Size = size;
		((Control)_Label1_15).TabIndex = 36;
		_Label1_15.Text = "%";
		((Control)_Label1_14).BackColor = SystemColors.Control;
		((Control)_Label1_14).Cursor = Cursors.Default;
		((Control)_Label1_14).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_14).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_14, (short)14);
		Label label1_31 = _Label1_14;
		location = new Point(235, 296);
		((Control)label1_31).Location = location;
		((Control)_Label1_14).Name = "_Label1_14";
		((Control)_Label1_14).RightToLeft = (RightToLeft)0;
		Label label1_32 = _Label1_14;
		size = new Size(17, 17);
		((Control)label1_32).Size = size;
		((Control)_Label1_14).TabIndex = 35;
		_Label1_14.Text = "%";
		((Control)_Label1_13).BackColor = SystemColors.Control;
		((Control)_Label1_13).Cursor = Cursors.Default;
		((Control)_Label1_13).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_13).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_13, (short)13);
		Label label1_33 = _Label1_13;
		location = new Point(235, 320);
		((Control)label1_33).Location = location;
		((Control)_Label1_13).Name = "_Label1_13";
		((Control)_Label1_13).RightToLeft = (RightToLeft)0;
		Label label1_34 = _Label1_13;
		size = new Size(17, 17);
		((Control)label1_34).Size = size;
		((Control)_Label1_13).TabIndex = 34;
		_Label1_13.Text = "%";
		((Control)_Label1_12).BackColor = SystemColors.Control;
		((Control)_Label1_12).Cursor = Cursors.Default;
		((Control)_Label1_12).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_12).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_12, (short)12);
		Label label1_35 = _Label1_12;
		location = new Point(235, 248);
		((Control)label1_35).Location = location;
		((Control)_Label1_12).Name = "_Label1_12";
		((Control)_Label1_12).RightToLeft = (RightToLeft)0;
		Label label1_36 = _Label1_12;
		size = new Size(17, 17);
		((Control)label1_36).Size = size;
		((Control)_Label1_12).TabIndex = 33;
		_Label1_12.Text = "%";
		((Control)_Label1_11).BackColor = SystemColors.Control;
		((Control)_Label1_11).Cursor = Cursors.Default;
		((Control)_Label1_11).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_11).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_11, (short)11);
		Label label1_37 = _Label1_11;
		location = new Point(235, 224);
		((Control)label1_37).Location = location;
		((Control)_Label1_11).Name = "_Label1_11";
		((Control)_Label1_11).RightToLeft = (RightToLeft)0;
		Label label1_38 = _Label1_11;
		size = new Size(17, 17);
		((Control)label1_38).Size = size;
		((Control)_Label1_11).TabIndex = 32;
		_Label1_11.Text = "%";
		((Control)_Label1_10).BackColor = SystemColors.Control;
		((Control)_Label1_10).Cursor = Cursors.Default;
		((Control)_Label1_10).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_10).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_10, (short)10);
		Label label1_39 = _Label1_10;
		location = new Point(235, 200);
		((Control)label1_39).Location = location;
		((Control)_Label1_10).Name = "_Label1_10";
		((Control)_Label1_10).RightToLeft = (RightToLeft)0;
		Label label1_40 = _Label1_10;
		size = new Size(17, 17);
		((Control)label1_40).Size = size;
		((Control)_Label1_10).TabIndex = 31;
		_Label1_10.Text = "%";
		((Control)lblTotal).BackColor = SystemColors.Control;
		((Control)lblTotal).Cursor = Cursors.Default;
		((Control)lblTotal).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)lblTotal).ForeColor = SystemColors.ControlText;
		Label obj11 = lblTotal;
		location = new Point(560, 400);
		((Control)obj11).Location = location;
		((Control)lblTotal).Name = "lblTotal";
		((Control)lblTotal).RightToLeft = (RightToLeft)0;
		Label obj12 = lblTotal;
		size = new Size(54, 17);
		((Control)obj12).Size = size;
		((Control)lblTotal).TabIndex = 30;
		lblTotal.Text = "100%";
		((Control)_Line1_0).BackColor = SystemColors.WindowText;
		Line1.SetIndex(_Line1_0, (short)0);
		Label line1_3 = _Line1_0;
		location = new Point(488, 392);
		((Control)line1_3).Location = location;
		((Control)_Line1_0).Name = "_Line1_0";
		Label line1_4 = _Line1_0;
		size = new Size(128, 1);
		((Control)line1_4).Size = size;
		((Control)_Line1_0).TabIndex = 66;
		((Control)_Label1_3).BackColor = SystemColors.Control;
		((Control)_Label1_3).Cursor = Cursors.Default;
		((Control)_Label1_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_3).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_3, (short)3);
		Label label1_41 = _Label1_3;
		location = new Point(464, 400);
		((Control)label1_41).Location = location;
		((Control)_Label1_3).Name = "_Label1_3";
		((Control)_Label1_3).RightToLeft = (RightToLeft)0;
		Label label1_42 = _Label1_3;
		size = new Size(81, 17);
		((Control)label1_42).Size = size;
		((Control)_Label1_3).TabIndex = 29;
		_Label1_3.Text = "Total: ";
		_Label1_3.TextAlign = (ContentAlignment)4;
		((Control)_lblMedia_5).BackColor = SystemColors.Control;
		((Control)_lblMedia_5).Cursor = Cursors.Default;
		((Control)_lblMedia_5).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblMedia_5).ForeColor = SystemColors.ControlText;
		lblMedia.SetIndex(_lblMedia_5, (short)5);
		Label lblMedia_7 = _lblMedia_5;
		location = new Point(16, 320);
		((Control)lblMedia_7).Location = location;
		((Control)_lblMedia_5).Name = "_lblMedia_5";
		((Control)_lblMedia_5).RightToLeft = (RightToLeft)0;
		Label lblMedia_8 = _lblMedia_5;
		size = new Size(175, 17);
		((Control)lblMedia_8).Size = size;
		((Control)_lblMedia_5).TabIndex = 28;
		_lblMedia_5.Text = "x";
		_lblMedia_5.TextAlign = (ContentAlignment)4;
		((Control)_lblMedia_4).BackColor = SystemColors.Control;
		((Control)_lblMedia_4).Cursor = Cursors.Default;
		((Control)_lblMedia_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblMedia_4).ForeColor = SystemColors.ControlText;
		lblMedia.SetIndex(_lblMedia_4, (short)4);
		Label lblMedia_9 = _lblMedia_4;
		location = new Point(3, 296);
		((Control)lblMedia_9).Location = location;
		((Control)_lblMedia_4).Name = "_lblMedia_4";
		((Control)_lblMedia_4).RightToLeft = (RightToLeft)0;
		Label lblMedia_10 = _lblMedia_4;
		size = new Size(188, 19);
		((Control)lblMedia_10).Size = size;
		((Control)_lblMedia_4).TabIndex = 27;
		_lblMedia_4.Text = "x";
		_lblMedia_4.TextAlign = (ContentAlignment)4;
		((Control)_lblMedia_3).BackColor = SystemColors.Control;
		((Control)_lblMedia_3).Cursor = Cursors.Default;
		((Control)_lblMedia_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblMedia_3).ForeColor = SystemColors.ControlText;
		lblMedia.SetIndex(_lblMedia_3, (short)3);
		Label lblMedia_11 = _lblMedia_3;
		location = new Point(11, 272);
		((Control)lblMedia_11).Location = location;
		((Control)_lblMedia_3).Name = "_lblMedia_3";
		((Control)_lblMedia_3).RightToLeft = (RightToLeft)0;
		Label lblMedia_12 = _lblMedia_3;
		size = new Size(180, 17);
		((Control)lblMedia_12).Size = size;
		((Control)_lblMedia_3).TabIndex = 26;
		_lblMedia_3.Text = "x";
		_lblMedia_3.TextAlign = (ContentAlignment)4;
		((Control)_lblMedia_2).BackColor = SystemColors.Control;
		((Control)_lblMedia_2).Cursor = Cursors.Default;
		((Control)_lblMedia_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblMedia_2).ForeColor = SystemColors.ControlText;
		lblMedia.SetIndex(_lblMedia_2, (short)2);
		Label lblMedia_13 = _lblMedia_2;
		location = new Point(8, 248);
		((Control)lblMedia_13).Location = location;
		((Control)_lblMedia_2).Name = "_lblMedia_2";
		((Control)_lblMedia_2).RightToLeft = (RightToLeft)0;
		Label lblMedia_14 = _lblMedia_2;
		size = new Size(183, 17);
		((Control)lblMedia_14).Size = size;
		((Control)_lblMedia_2).TabIndex = 25;
		_lblMedia_2.Text = "x";
		_lblMedia_2.TextAlign = (ContentAlignment)4;
		((Control)_lblMedia_1).BackColor = SystemColors.Control;
		((Control)_lblMedia_1).Cursor = Cursors.Default;
		((Control)_lblMedia_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblMedia_1).ForeColor = SystemColors.ControlText;
		lblMedia.SetIndex(_lblMedia_1, (short)1);
		Label lblMedia_15 = _lblMedia_1;
		location = new Point(16, 224);
		((Control)lblMedia_15).Location = location;
		((Control)_lblMedia_1).Name = "_lblMedia_1";
		((Control)_lblMedia_1).RightToLeft = (RightToLeft)0;
		Label lblMedia_16 = _lblMedia_1;
		size = new Size(175, 17);
		((Control)lblMedia_16).Size = size;
		((Control)_lblMedia_1).TabIndex = 24;
		_lblMedia_1.Text = "x";
		_lblMedia_1.TextAlign = (ContentAlignment)4;
		((Control)_lblMedia_0).BackColor = SystemColors.Control;
		((Control)_lblMedia_0).Cursor = Cursors.Default;
		((Control)_lblMedia_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblMedia_0).ForeColor = SystemColors.ControlText;
		lblMedia.SetIndex(_lblMedia_0, (short)0);
		Label lblMedia_17 = _lblMedia_0;
		location = new Point(16, 200);
		((Control)lblMedia_17).Location = location;
		((Control)_lblMedia_0).Name = "_lblMedia_0";
		((Control)_lblMedia_0).RightToLeft = (RightToLeft)0;
		Label lblMedia_18 = _lblMedia_0;
		size = new Size(175, 17);
		((Control)lblMedia_18).Size = size;
		((Control)_lblMedia_0).TabIndex = 23;
		_lblMedia_0.Text = "x";
		_lblMedia_0.TextAlign = (ContentAlignment)4;
		((Control)lblAct).BackColor = SystemColors.Control;
		((Control)lblAct).Cursor = Cursors.Default;
		((Control)lblAct).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)lblAct).ForeColor = SystemColors.ControlText;
		Label obj13 = lblAct;
		location = new Point(8, 64);
		((Control)obj13).Location = location;
		((Control)lblAct).Name = "lblAct";
		((Control)lblAct).RightToLeft = (RightToLeft)0;
		Label obj14 = lblAct;
		size = new Size(577, 17);
		((Control)obj14).Size = size;
		((Control)lblAct).TabIndex = 22;
		lblAct.Text = "x";
		((Control)lblOp).BackColor = SystemColors.Control;
		((Control)lblOp).Cursor = Cursors.Default;
		((Control)lblOp).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)lblOp).ForeColor = SystemColors.ControlText;
		Label obj15 = lblOp;
		location = new Point(8, 40);
		((Control)obj15).Location = location;
		((Control)lblOp).Name = "lblOp";
		((Control)lblOp).RightToLeft = (RightToLeft)0;
		Label obj16 = lblOp;
		size = new Size(473, 17);
		((Control)obj16).Size = size;
		((Control)lblOp).TabIndex = 21;
		lblOp.Text = "x";
		((Control)_lblMedia_6).BackColor = SystemColors.Control;
		((Control)_lblMedia_6).Cursor = Cursors.Default;
		((Control)_lblMedia_6).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblMedia_6).ForeColor = SystemColors.ControlText;
		lblMedia.SetIndex(_lblMedia_6, (short)6);
		Label lblMedia_19 = _lblMedia_6;
		location = new Point(16, 344);
		((Control)lblMedia_19).Location = location;
		((Control)_lblMedia_6).Name = "_lblMedia_6";
		((Control)_lblMedia_6).RightToLeft = (RightToLeft)0;
		Label lblMedia_20 = _lblMedia_6;
		size = new Size(175, 17);
		((Control)lblMedia_20).Size = size;
		((Control)_lblMedia_6).TabIndex = 50;
		_lblMedia_6.Text = "x";
		_lblMedia_6.TextAlign = (ContentAlignment)4;
		((Control)_lblMedia_7).BackColor = SystemColors.Control;
		((Control)_lblMedia_7).Cursor = Cursors.Default;
		((Control)_lblMedia_7).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblMedia_7).ForeColor = SystemColors.ControlText;
		lblMedia.SetIndex(_lblMedia_7, (short)7);
		Label lblMedia_21 = _lblMedia_7;
		location = new Point(16, 368);
		((Control)lblMedia_21).Location = location;
		((Control)_lblMedia_7).Name = "_lblMedia_7";
		((Control)_lblMedia_7).RightToLeft = (RightToLeft)0;
		Label lblMedia_22 = _lblMedia_7;
		size = new Size(175, 17);
		((Control)lblMedia_22).Size = size;
		((Control)_lblMedia_7).TabIndex = 49;
		_lblMedia_7.Text = "x";
		_lblMedia_7.TextAlign = (ContentAlignment)4;
		((Control)_lblMedia_8).BackColor = SystemColors.Control;
		((Control)_lblMedia_8).Cursor = Cursors.Default;
		((Control)_lblMedia_8).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblMedia_8).ForeColor = SystemColors.ControlText;
		lblMedia.SetIndex(_lblMedia_8, (short)8);
		Label lblMedia_23 = _lblMedia_8;
		location = new Point(240, 224);
		((Control)lblMedia_23).Location = location;
		((Control)_lblMedia_8).Name = "_lblMedia_8";
		((Control)_lblMedia_8).RightToLeft = (RightToLeft)0;
		Label lblMedia_24 = _lblMedia_8;
		size = new Size(152, 17);
		((Control)lblMedia_24).Size = size;
		((Control)_lblMedia_8).TabIndex = 48;
		_lblMedia_8.Text = "x";
		_lblMedia_8.TextAlign = (ContentAlignment)4;
		((Control)_lblMedia_9).BackColor = SystemColors.Control;
		((Control)_lblMedia_9).Cursor = Cursors.Default;
		((Control)_lblMedia_9).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblMedia_9).ForeColor = SystemColors.ControlText;
		lblMedia.SetIndex(_lblMedia_9, (short)9);
		Label lblMedia_25 = _lblMedia_9;
		location = new Point(240, 248);
		((Control)lblMedia_25).Location = location;
		((Control)_lblMedia_9).Name = "_lblMedia_9";
		((Control)_lblMedia_9).RightToLeft = (RightToLeft)0;
		Label lblMedia_26 = _lblMedia_9;
		size = new Size(152, 17);
		((Control)lblMedia_26).Size = size;
		((Control)_lblMedia_9).TabIndex = 47;
		_lblMedia_9.Text = "x";
		_lblMedia_9.TextAlign = (ContentAlignment)4;
		((Control)_lblMedia_10).BackColor = SystemColors.Control;
		((Control)_lblMedia_10).Cursor = Cursors.Default;
		((Control)_lblMedia_10).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblMedia_10).ForeColor = SystemColors.ControlText;
		lblMedia.SetIndex(_lblMedia_10, (short)10);
		Label lblMedia_27 = _lblMedia_10;
		location = new Point(240, 272);
		((Control)lblMedia_27).Location = location;
		((Control)_lblMedia_10).Name = "_lblMedia_10";
		((Control)_lblMedia_10).RightToLeft = (RightToLeft)0;
		Label lblMedia_28 = _lblMedia_10;
		size = new Size(152, 17);
		((Control)lblMedia_28).Size = size;
		((Control)_lblMedia_10).TabIndex = 46;
		_lblMedia_10.Text = "x";
		_lblMedia_10.TextAlign = (ContentAlignment)4;
		((Control)_lblMedia_11).BackColor = SystemColors.Control;
		((Control)_lblMedia_11).Cursor = Cursors.Default;
		((Control)_lblMedia_11).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblMedia_11).ForeColor = SystemColors.ControlText;
		lblMedia.SetIndex(_lblMedia_11, (short)11);
		Label lblMedia_29 = _lblMedia_11;
		location = new Point(240, 296);
		((Control)lblMedia_29).Location = location;
		((Control)_lblMedia_11).Name = "_lblMedia_11";
		((Control)_lblMedia_11).RightToLeft = (RightToLeft)0;
		Label lblMedia_30 = _lblMedia_11;
		size = new Size(152, 17);
		((Control)lblMedia_30).Size = size;
		((Control)_lblMedia_11).TabIndex = 45;
		_lblMedia_11.Text = "x";
		_lblMedia_11.TextAlign = (ContentAlignment)4;
		((Control)_lblMedia_14).BackColor = SystemColors.Control;
		((Control)_lblMedia_14).Cursor = Cursors.Default;
		((Control)_lblMedia_14).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblMedia_14).ForeColor = SystemColors.ControlText;
		lblMedia.SetIndex(_lblMedia_14, (short)14);
		Label lblMedia_31 = _lblMedia_14;
		location = new Point(240, 368);
		((Control)lblMedia_31).Location = location;
		((Control)_lblMedia_14).Name = "_lblMedia_14";
		((Control)_lblMedia_14).RightToLeft = (RightToLeft)0;
		Label lblMedia_32 = _lblMedia_14;
		size = new Size(152, 17);
		((Control)lblMedia_32).Size = size;
		((Control)_lblMedia_14).TabIndex = 58;
		_lblMedia_14.Text = "x";
		_lblMedia_14.TextAlign = (ContentAlignment)4;
		((Control)_lblMedia_15).BackColor = SystemColors.Control;
		((Control)_lblMedia_15).Cursor = Cursors.Default;
		((Control)_lblMedia_15).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblMedia_15).ForeColor = SystemColors.ControlText;
		lblMedia.SetIndex(_lblMedia_15, (short)15);
		Label lblMedia_33 = _lblMedia_15;
		location = new Point(454, 320);
		((Control)lblMedia_33).Location = location;
		((Control)_lblMedia_15).Name = "_lblMedia_15";
		((Control)_lblMedia_15).RightToLeft = (RightToLeft)0;
		Label lblMedia_34 = _lblMedia_15;
		size = new Size(105, 17);
		((Control)lblMedia_34).Size = size;
		((Control)_lblMedia_15).TabIndex = 57;
		_lblMedia_15.Text = "x";
		_lblMedia_15.TextAlign = (ContentAlignment)4;
		((Control)_lblMedia_16).BackColor = SystemColors.Control;
		((Control)_lblMedia_16).Cursor = Cursors.Default;
		((Control)_lblMedia_16).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblMedia_16).ForeColor = SystemColors.ControlText;
		lblMedia.SetIndex(_lblMedia_16, (short)16);
		Label lblMedia_35 = _lblMedia_16;
		location = new Point(454, 344);
		((Control)lblMedia_35).Location = location;
		((Control)_lblMedia_16).Name = "_lblMedia_16";
		((Control)_lblMedia_16).RightToLeft = (RightToLeft)0;
		Label lblMedia_36 = _lblMedia_16;
		size = new Size(105, 17);
		((Control)lblMedia_36).Size = size;
		((Control)_lblMedia_16).TabIndex = 56;
		_lblMedia_16.Text = "x";
		_lblMedia_16.TextAlign = (ContentAlignment)4;
		size = new Size(5, 13);
		((Form)this).AutoScaleBaseSize = size;
		((Form)this).BackColor = SystemColors.Control;
		((Form)this).CancelButton = (IButtonControl)(object)cmdCancel;
		size = new Size(626, 443);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)_txtMedia_17);
		((Control)this).Controls.Add((Control)(object)txtBasis);
		((Control)this).Controls.Add((Control)(object)_txtMedia_14);
		((Control)this).Controls.Add((Control)(object)_txtMedia_12);
		((Control)this).Controls.Add((Control)(object)_txtMedia_13);
		((Control)this).Controls.Add((Control)(object)_txtMedia_15);
		((Control)this).Controls.Add((Control)(object)_txtMedia_16);
		((Control)this).Controls.Add((Control)(object)_txtMedia_6);
		((Control)this).Controls.Add((Control)(object)_txtMedia_7);
		((Control)this).Controls.Add((Control)(object)_txtMedia_8);
		((Control)this).Controls.Add((Control)(object)_txtMedia_9);
		((Control)this).Controls.Add((Control)(object)_txtMedia_10);
		((Control)this).Controls.Add((Control)(object)_txtMedia_11);
		((Control)this).Controls.Add((Control)(object)txtNAICS);
		((Control)this).Controls.Add((Control)(object)_txtMedia_5);
		((Control)this).Controls.Add((Control)(object)_txtMedia_4);
		((Control)this).Controls.Add((Control)(object)_txtMedia_3);
		((Control)this).Controls.Add((Control)(object)_txtMedia_2);
		((Control)this).Controls.Add((Control)(object)_txtMedia_1);
		((Control)this).Controls.Add((Control)(object)_txtMedia_0);
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)cmdOk);
		((Control)this).Controls.Add((Control)(object)_lblMedia_17);
		((Control)this).Controls.Add((Control)(object)_Label1_4);
		((Control)this).Controls.Add((Control)(object)_Label1_1);
		((Control)this).Controls.Add((Control)(object)_lblMedia_12);
		((Control)this).Controls.Add((Control)(object)_lblMedia_13);
		((Control)this).Controls.Add((Control)(object)_Label1_31);
		((Control)this).Controls.Add((Control)(object)_Label1_30);
		((Control)this).Controls.Add((Control)(object)_Label1_29);
		((Control)this).Controls.Add((Control)(object)_Label1_27);
		((Control)this).Controls.Add((Control)(object)_Label1_26);
		((Control)this).Controls.Add((Control)(object)_Label1_19);
		((Control)this).Controls.Add((Control)(object)_Label1_18);
		((Control)this).Controls.Add((Control)(object)_Label1_17);
		((Control)this).Controls.Add((Control)(object)_Label1_16);
		((Control)this).Controls.Add((Control)(object)_Label1_9);
		((Control)this).Controls.Add((Control)(object)_Label1_2);
		((Control)this).Controls.Add((Control)(object)_Label1_0);
		((Control)this).Controls.Add((Control)(object)lblInstructions);
		((Control)this).Controls.Add((Control)(object)_Line1_1);
		((Control)this).Controls.Add((Control)(object)_Label1_15);
		((Control)this).Controls.Add((Control)(object)_Label1_14);
		((Control)this).Controls.Add((Control)(object)_Label1_13);
		((Control)this).Controls.Add((Control)(object)_Label1_12);
		((Control)this).Controls.Add((Control)(object)_Label1_11);
		((Control)this).Controls.Add((Control)(object)_Label1_10);
		((Control)this).Controls.Add((Control)(object)lblTotal);
		((Control)this).Controls.Add((Control)(object)_Line1_0);
		((Control)this).Controls.Add((Control)(object)_Label1_3);
		((Control)this).Controls.Add((Control)(object)_lblMedia_5);
		((Control)this).Controls.Add((Control)(object)_lblMedia_4);
		((Control)this).Controls.Add((Control)(object)_lblMedia_3);
		((Control)this).Controls.Add((Control)(object)_lblMedia_2);
		((Control)this).Controls.Add((Control)(object)_lblMedia_1);
		((Control)this).Controls.Add((Control)(object)_lblMedia_0);
		((Control)this).Controls.Add((Control)(object)lblAct);
		((Control)this).Controls.Add((Control)(object)lblOp);
		((Control)this).Controls.Add((Control)(object)_lblMedia_6);
		((Control)this).Controls.Add((Control)(object)_lblMedia_7);
		((Control)this).Controls.Add((Control)(object)_lblMedia_8);
		((Control)this).Controls.Add((Control)(object)_lblMedia_9);
		((Control)this).Controls.Add((Control)(object)_lblMedia_10);
		((Control)this).Controls.Add((Control)(object)_lblMedia_11);
		((Control)this).Controls.Add((Control)(object)_lblMedia_14);
		((Control)this).Controls.Add((Control)(object)_lblMedia_15);
		((Control)this).Controls.Add((Control)(object)_lblMedia_16);
		((Control)this).Cursor = Cursors.Default;
		((Control)this).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		location = new Point(250, 150);
		((Form)this).Location = location;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmMDUpdRelMed";
		((Control)this).RightToLeft = (RightToLeft)0;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Update Release Media Output Specifications";
		((ISupportInitialize)Label1).EndInit();
		((ISupportInitialize)Line1).EndInit();
		((ISupportInitialize)lblMedia).EndInit();
		((ISupportInitialize)txtMedia).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void cmdCancel_Click(object eventSender, EventArgs eventArgs)
	{
		((Form)this).Close();
		((Component)(object)this).Dispose();
	}

	private void cmdOk_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Invalid comparison between Unknown and I4
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(lblTotal.Text, "100%", false) != 0)
		{
			Interaction.Beep();
			if ((int)Interaction.MsgBox((object)"Warning, the sum of the release percentages does not add up to 100%.  Are you sure you want to continue?", (MsgBoxStyle)36, (object)"Warning") == 7)
			{
				return;
			}
		}
		bool flag = false;
		short num = 0;
		checked
		{
			short num2;
			short num3;
			do
			{
				if (Operators.ConditionalCompareObjectNotEqual(((Control)lblMedia[num]).Tag, (object)txtMedia[num].Text, false))
				{
					flag = true;
					break;
				}
				num = (short)unchecked(num + 1);
				num2 = num;
				num3 = 17;
			}
			while (num2 <= num3);
			if (flag)
			{
				switch (Globals_Renamed.arRelModType[Globals_Renamed.intModIndex])
				{
				case 41:
				case 48:
					Interaction.Beep();
					Interaction.MsgBox((object)("Your changes to media of release for this model will be overwritten if you change either the " + Globals_Renamed.arParmNames[45] + " or the " + Globals_Renamed.arParmNames[52] + " model parameters. If you change one or both of those input parameters, you will need to return to this window to re-enter your changes to media of release."), (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
					break;
				case 51:
				case 52:
					Interaction.Beep();
					Interaction.MsgBox((object)("Your changes to media of release for this model will be overwritten if you change the " + Globals_Renamed.arParmNames[142] + " model parameter. If you change this input parameter, you will need to return to this window to re-enter your changes to media of release."), (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
					break;
				case 53:
					Interaction.Beep();
					Interaction.MsgBox((object)"Your changes to media of release for this model will be overwritten if you change the model parameters. If you change one of those input parameters, you will need to return to this window to re-enter your changes to media of release.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
					break;
				}
			}
			num = 0;
			short num4;
			do
			{
				if (Strings.Len(txtMedia[num].Text) > 0)
				{
					Globals_Renamed.arRelModMedia[Conversions.ToInteger(((Control)txtMedia[num]).Tag), Globals_Renamed.intModIndex] = Conversions.ToSingle(txtMedia[num].Text);
				}
				else
				{
					Globals_Renamed.arRelModMedia[Conversions.ToInteger(((Control)txtMedia[num]).Tag), Globals_Renamed.intModIndex] = 0f;
				}
				num = (short)unchecked(num + 1);
				num4 = num;
				num3 = 17;
			}
			while (num4 <= num3);
			frmMain.DefInstance.lstRelModels_SelectedIndexChanged(frmMain.DefInstance.lstRelModels, new EventArgs());
			Globals_Renamed.arRelModBasis[Globals_Renamed.arRelModels[frmMain.DefInstance.lstRelModels.SelectedIndex, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1] = txtBasis.Text;
			Globals_Renamed.arRelModNAICS[Globals_Renamed.arRelModels[frmMain.DefInstance.lstRelModels.SelectedIndex, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1] = txtNAICS.Text;
			Globals_Renamed.gblIWasChanged = true;
			((Form)this).Close();
			((Component)(object)this).Dispose();
		}
	}

	public bool SetUp()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		float num3 = default(float);
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
						command.Parameters.Append(command.CreateParameter("pID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, 23));
						Command command2 = command;
						object RecordsAffected = Missing.Value;
						object Parameters = Missing.Value;
						recordset = command2.Execute(out RecordsAffected, ref Parameters);
						command.Parameters.Delete("pID");
						lblInstructions.Text = Conversions.ToString(recordset.Fields[0].Value);
						recordset.Close();
						lblOp.Text = frmMain.DefInstance.cmbRelOps.Text;
						lblAct.Text = frmMain.DefInstance.cmbRelActs.Text;
						recordset.CursorLocation = CursorLocationEnum.adUseClient;
						recordset.Open("SELECT * FROM qryListOfMedia", Common.MyConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
						while (!recordset.EOF)
						{
							txtMedia[Conversions.ToShort(recordset.Fields["SortID"].Value)].Text = Conversions.ToString(Globals_Renamed.arRelModMedia[Conversions.ToInteger(recordset.Fields["MediaID"].Value), Globals_Renamed.intModIndex]);
							((Control)txtMedia[Conversions.ToShort(recordset.Fields["SortID"].Value)]).Tag = RuntimeHelpers.GetObjectValue(recordset.Fields["MediaID"].Value);
							num3 = (float)((double)num3 + Conversions.ToDouble(txtMedia[Conversions.ToShort(recordset.Fields["SortID"].Value)].Text));
							lblMedia[Conversions.ToShort(recordset.Fields["SortID"].Value)].Text = Conversions.ToString(recordset.Fields[0].Value);
							((Control)lblMedia[Conversions.ToShort(recordset.Fields["SortID"].Value)]).Tag = txtMedia[Conversions.ToShort(recordset.Fields["SortID"].Value)].Text;
							recordset.MoveNext();
						}
						lblTotal.Text = Conversions.ToString(num3) + "%";
						txtBasis.Text = Globals_Renamed.arRelModBasis[Globals_Renamed.arRelModels[frmMain.DefInstance.lstRelModels.SelectedIndex, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1];
						txtNAICS.Text = Globals_Renamed.arRelModNAICS[Globals_Renamed.arRelModels[frmMain.DefInstance.lstRelModels.SelectedIndex, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1];
						recordset.Close();
						recordset = null;
						command = null;
						flag = true;
						goto end_IL_0001;
					}
					case 959:
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
				try0001_dispatch = 959;
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

	private void txtBasis_Leave(object eventSender, EventArgs eventArgs)
	{
		TextBox obj = txtBasis;
		TextBox val = txtBasis;
		string pText = val.Text;
		string text = ChemStrX.TrtLineBreak(ref pText);
		val.Text = pText;
		obj.Text = text;
	}

	private void txtMedia_Enter(object eventSender, EventArgs eventArgs)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		short num = Conversions.ToShort(Strings.Mid(Conversions.ToString(NewLateBinding.LateGet(eventSender, (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null)), 11));
		((TextBoxBase)(TextBox)eventSender).SelectAll();
	}

	private void txtMedia_Leave(object eventSender, EventArgs eventArgs)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		short index = txtMedia.GetIndex((TextBox)eventSender);
		txtMedia[index].Text = Strings.Trim(txtMedia[index].Text);
		if (Strings.Len(txtMedia[index].Text) == 0)
		{
			txtMedia[index].Text = Conversions.ToString(0);
		}
		else
		{
			if (!Versioned.IsNumeric((object)txtMedia[index].Text))
			{
				Interaction.Beep();
				Interaction.MsgBox((object)"Please enter a valid percentage.", (MsgBoxStyle)64, (object)"Invalid Input");
				txtMedia[index].Text = Conversions.ToString(0);
				return;
			}
			if (Conversions.ToDouble(txtMedia[index].Text) < 0.0)
			{
				Interaction.Beep();
				Interaction.MsgBox((object)"Please enter a valid percentage.  Percentages must be integers between zero and 100.", (MsgBoxStyle)64, (object)"Invalid Input");
				txtMedia[index].Text = Conversions.ToString(0);
				return;
			}
			if (Conversions.ToDouble(txtMedia[index].Text) > 100.0)
			{
				Interaction.Beep();
				Interaction.MsgBox((object)"Please enter a valid percentage.  Percentages must be integers between zero and 100.", (MsgBoxStyle)64, (object)"Invalid Input");
				txtMedia[index].Text = Conversions.ToString(0);
				return;
			}
		}
		short num = 0;
		checked
		{
			float num2 = default(float);
			short num3;
			short num4;
			do
			{
				if (Strings.Len(txtMedia[num].Text) > 0)
				{
					num2 = (float)((double)num2 + Conversions.ToDouble(txtMedia[num].Text));
				}
				num = (short)unchecked(num + 1);
				num3 = num;
				num4 = 17;
			}
			while (num3 <= num4);
			lblTotal.Text = Conversions.ToString(num2) + "%";
		}
	}

	private void txtNAICS_Leave(object eventSender, EventArgs eventArgs)
	{
		TextBox obj = txtNAICS;
		TextBox val = txtNAICS;
		string pText = val.Text;
		string text = ChemStrX.TrtLineBreak(ref pText);
		val.Text = pText;
		obj.Text = text;
	}
}
