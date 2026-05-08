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

internal class frmMDUpdAmtFreq : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("txtInput")]
	private TextBox _txtInput;

	[AccessedThroughProperty("_optType_1")]
	private RadioButton __optType_1;

	[AccessedThroughProperty("_optType_0")]
	private RadioButton __optType_0;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("cmdClose")]
	private Button _cmdClose;

	[AccessedThroughProperty("_Line2_0")]
	private Label __Line2_0;

	[AccessedThroughProperty("_lblUnits_1")]
	private Label __lblUnits_1;

	[AccessedThroughProperty("_lblV_1")]
	private Label __lblV_1;

	[AccessedThroughProperty("_lblVC_1")]
	private Label __lblVC_1;

	[AccessedThroughProperty("lblParm")]
	private Label _lblParm;

	[AccessedThroughProperty("_Line2_1")]
	private Label __Line2_1;

	[AccessedThroughProperty("_lblUnits_0")]
	private Label __lblUnits_0;

	[AccessedThroughProperty("_lblVC_0")]
	private Label __lblVC_0;

	[AccessedThroughProperty("_lblV_0")]
	private Label __lblV_0;

	[AccessedThroughProperty("_Line1_0")]
	private Label __Line1_0;

	[AccessedThroughProperty("_Label1_2")]
	private Label __Label1_2;

	[AccessedThroughProperty("_Label1_1")]
	private Label __Label1_1;

	[AccessedThroughProperty("_Label1_0")]
	private Label __Label1_0;

	[AccessedThroughProperty("_Label1_98")]
	private Label __Label1_98;

	[AccessedThroughProperty("_Label1_76")]
	private Label __Label1_76;

	[AccessedThroughProperty("lblInstructions")]
	private Label _lblInstructions;

	[AccessedThroughProperty("Label1")]
	private LabelArray _Label1;

	[AccessedThroughProperty("Line1")]
	private LabelArray _Line1;

	[AccessedThroughProperty("Line2")]
	private LabelArray _Line2;

	[AccessedThroughProperty("lblUnits")]
	private LabelArray _lblUnits;

	[AccessedThroughProperty("lblV")]
	private LabelArray _lblV;

	[AccessedThroughProperty("lblVC")]
	private LabelArray _lblVC;

	[AccessedThroughProperty("_optType_2")]
	private RadioButton __optType_2;

	[AccessedThroughProperty("_lblUnits_2")]
	private Label __lblUnits_2;

	[AccessedThroughProperty("_lblV_2")]
	private Label __lblV_2;

	[AccessedThroughProperty("_lblVC_2")]
	private Label __lblVC_2;

	[AccessedThroughProperty("_Line2_2")]
	private Label __Line2_2;

	[AccessedThroughProperty("_optType_3")]
	private RadioButton __optType_3;

	[AccessedThroughProperty("_lblUnits_3")]
	private Label __lblUnits_3;

	[AccessedThroughProperty("_lblV_3")]
	private Label __lblV_3;

	[AccessedThroughProperty("_lblVC_3")]
	private Label __lblVC_3;

	[AccessedThroughProperty("_Line2_3")]
	private Label __Line2_3;

	[AccessedThroughProperty("_optType_4")]
	private RadioButton __optType_4;

	[AccessedThroughProperty("_lblUnits_4")]
	private Label __lblUnits_4;

	[AccessedThroughProperty("_lblV_4")]
	private Label __lblV_4;

	[AccessedThroughProperty("_lblVC_4")]
	private Label __lblVC_4;

	[AccessedThroughProperty("_Line2_4")]
	private Label __Line2_4;

	[AccessedThroughProperty("_optType_5")]
	private RadioButton __optType_5;

	[AccessedThroughProperty("_lblUnits_5")]
	private Label __lblUnits_5;

	[AccessedThroughProperty("_lblV_5")]
	private Label __lblV_5;

	[AccessedThroughProperty("_lblVC_5")]
	private Label __lblVC_5;

	[AccessedThroughProperty("_Line2_5")]
	private Label __Line2_5;

	[AccessedThroughProperty("_optType_6")]
	private RadioButton __optType_6;

	[AccessedThroughProperty("_lblUnits_6")]
	private Label __lblUnits_6;

	[AccessedThroughProperty("_lblV_6")]
	private Label __lblV_6;

	[AccessedThroughProperty("_lblVC_6")]
	private Label __lblVC_6;

	[AccessedThroughProperty("_Line2_6")]
	private Label __Line2_6;

	[AccessedThroughProperty("_optType_7")]
	private RadioButton __optType_7;

	[AccessedThroughProperty("_lblUnits_7")]
	private Label __lblUnits_7;

	[AccessedThroughProperty("_lblV_7")]
	private Label __lblV_7;

	[AccessedThroughProperty("_lblVC_7")]
	private Label __lblVC_7;

	[AccessedThroughProperty("_Line2_7")]
	private Label __Line2_7;

	[AccessedThroughProperty("_optType_8")]
	private RadioButton __optType_8;

	[AccessedThroughProperty("_lblUnits_8")]
	private Label __lblUnits_8;

	[AccessedThroughProperty("_lblV_8")]
	private Label __lblV_8;

	[AccessedThroughProperty("_lblVC_8")]
	private Label __lblVC_8;

	[AccessedThroughProperty("_Line2_8")]
	private Label __Line2_8;

	[AccessedThroughProperty("_optType_9")]
	private RadioButton __optType_9;

	[AccessedThroughProperty("_lblUnits_9")]
	private Label __lblUnits_9;

	[AccessedThroughProperty("_lblV_9")]
	private Label __lblV_9;

	[AccessedThroughProperty("_lblVC_9")]
	private Label __lblVC_9;

	[AccessedThroughProperty("_Line2_9")]
	private Label __Line2_9;

	[AccessedThroughProperty("_optType_10")]
	private RadioButton __optType_10;

	[AccessedThroughProperty("_lblUnits_10")]
	private Label __lblUnits_10;

	[AccessedThroughProperty("_lblV_10")]
	private Label __lblV_10;

	[AccessedThroughProperty("_lblVC_10")]
	private Label __lblVC_10;

	[AccessedThroughProperty("_lblV_11")]
	private Label __lblV_11;

	[AccessedThroughProperty("_optType_11")]
	private RadioButton __optType_11;

	[AccessedThroughProperty("_lblUnits_11")]
	private Label __lblUnits_11;

	[AccessedThroughProperty("_lblVC_11")]
	private Label __lblVC_11;

	[AccessedThroughProperty("_Line2_11")]
	private Label __Line2_11;

	[AccessedThroughProperty("_Line2_10")]
	private Label __Line2_10;

	private static frmMDUpdAmtFreq m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	private short MyParmID;

	private short MyModelType;

	private short iSelected;

	private short iUserDef;

	private short iCallerID;

	private short iDualIndex;

	private short myMaxRows;

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
			EventHandler eventHandler = txtInput_Leave;
			EventHandler eventHandler2 = txtInput_Enter;
			EventHandler eventHandler3 = txtInput_TextChanged;
			if (_txtInput != null)
			{
				((Control)_txtInput).Leave -= eventHandler;
				((Control)_txtInput).Enter -= eventHandler2;
				((Control)_txtInput).TextChanged -= eventHandler3;
			}
			_txtInput = value;
			if (_txtInput != null)
			{
				((Control)_txtInput).Leave += eventHandler;
				((Control)_txtInput).Enter += eventHandler2;
				((Control)_txtInput).TextChanged += eventHandler3;
			}
		}
	}

	public virtual RadioButton _optType_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __optType_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = optType_CheckedChanged;
			if (__optType_1 != null)
			{
				__optType_1.CheckedChanged -= eventHandler;
			}
			__optType_1 = value;
			if (__optType_1 != null)
			{
				__optType_1.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual RadioButton _optType_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __optType_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = optType_CheckedChanged;
			if (__optType_0 != null)
			{
				__optType_0.CheckedChanged -= eventHandler;
			}
			__optType_0 = value;
			if (__optType_0 != null)
			{
				__optType_0.CheckedChanged += eventHandler;
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

	public virtual Label _Line2_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __Line2_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Line2_0 = value;
		}
	}

	public virtual Label _lblUnits_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblUnits_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblUnits_1 = value;
		}
	}

	public virtual Label _lblV_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblV_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblV_1 = value;
		}
	}

	public virtual Label _lblVC_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblVC_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblVC_1 = value;
		}
	}

	public virtual Label lblParm
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblParm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblParm = value;
		}
	}

	public virtual Label _Line2_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __Line2_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Line2_1 = value;
		}
	}

	public virtual Label _lblUnits_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblUnits_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblUnits_0 = value;
		}
	}

	public virtual Label _lblVC_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblVC_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblVC_0 = value;
		}
	}

	public virtual Label _lblV_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblV_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblV_0 = value;
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

	public virtual Label _Label1_98
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_98;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_98 = value;
		}
	}

	public virtual Label _Label1_76
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_76;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_76 = value;
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

	public virtual LabelArray Line2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Line2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Line2 = value;
		}
	}

	public virtual LabelArray lblUnits
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblUnits;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblUnits = value;
		}
	}

	public virtual LabelArray lblV
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblV;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblV = value;
		}
	}

	public virtual LabelArray lblVC
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblVC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblVC = value;
		}
	}

	public virtual RadioButton _optType_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __optType_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = optType_CheckedChanged;
			if (__optType_2 != null)
			{
				__optType_2.CheckedChanged -= eventHandler;
			}
			__optType_2 = value;
			if (__optType_2 != null)
			{
				__optType_2.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual Label _lblUnits_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblUnits_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblUnits_2 = value;
		}
	}

	public virtual Label _lblV_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblV_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblV_2 = value;
		}
	}

	public virtual Label _lblVC_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblVC_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblVC_2 = value;
		}
	}

	public virtual Label _Line2_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __Line2_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Line2_2 = value;
		}
	}

	public virtual RadioButton _optType_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __optType_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = optType_CheckedChanged;
			if (__optType_3 != null)
			{
				__optType_3.CheckedChanged -= eventHandler;
			}
			__optType_3 = value;
			if (__optType_3 != null)
			{
				__optType_3.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual Label _lblUnits_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblUnits_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblUnits_3 = value;
		}
	}

	public virtual Label _lblV_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblV_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblV_3 = value;
		}
	}

	public virtual Label _lblVC_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblVC_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblVC_3 = value;
		}
	}

	public virtual Label _Line2_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __Line2_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Line2_3 = value;
		}
	}

	public virtual RadioButton _optType_4
	{
		[DebuggerNonUserCode]
		get
		{
			return __optType_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = optType_CheckedChanged;
			if (__optType_4 != null)
			{
				__optType_4.CheckedChanged -= eventHandler;
			}
			__optType_4 = value;
			if (__optType_4 != null)
			{
				__optType_4.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual Label _lblUnits_4
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblUnits_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblUnits_4 = value;
		}
	}

	public virtual Label _lblV_4
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblV_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblV_4 = value;
		}
	}

	public virtual Label _lblVC_4
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblVC_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblVC_4 = value;
		}
	}

	public virtual Label _Line2_4
	{
		[DebuggerNonUserCode]
		get
		{
			return __Line2_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Line2_4 = value;
		}
	}

	public virtual RadioButton _optType_5
	{
		[DebuggerNonUserCode]
		get
		{
			return __optType_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = optType_CheckedChanged;
			if (__optType_5 != null)
			{
				__optType_5.CheckedChanged -= eventHandler;
			}
			__optType_5 = value;
			if (__optType_5 != null)
			{
				__optType_5.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual Label _lblUnits_5
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblUnits_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblUnits_5 = value;
		}
	}

	public virtual Label _lblV_5
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblV_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblV_5 = value;
		}
	}

	public virtual Label _lblVC_5
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblVC_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblVC_5 = value;
		}
	}

	public virtual Label _Line2_5
	{
		[DebuggerNonUserCode]
		get
		{
			return __Line2_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Line2_5 = value;
		}
	}

	public virtual RadioButton _optType_6
	{
		[DebuggerNonUserCode]
		get
		{
			return __optType_6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = optType_CheckedChanged;
			if (__optType_6 != null)
			{
				__optType_6.CheckedChanged -= eventHandler;
			}
			__optType_6 = value;
			if (__optType_6 != null)
			{
				__optType_6.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual Label _lblUnits_6
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblUnits_6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblUnits_6 = value;
		}
	}

	public virtual Label _lblV_6
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblV_6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblV_6 = value;
		}
	}

	public virtual Label _lblVC_6
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblVC_6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblVC_6 = value;
		}
	}

	public virtual Label _Line2_6
	{
		[DebuggerNonUserCode]
		get
		{
			return __Line2_6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Line2_6 = value;
		}
	}

	public virtual RadioButton _optType_7
	{
		[DebuggerNonUserCode]
		get
		{
			return __optType_7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = optType_CheckedChanged;
			if (__optType_7 != null)
			{
				__optType_7.CheckedChanged -= eventHandler;
			}
			__optType_7 = value;
			if (__optType_7 != null)
			{
				__optType_7.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual Label _lblUnits_7
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblUnits_7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblUnits_7 = value;
		}
	}

	public virtual Label _lblV_7
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblV_7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblV_7 = value;
		}
	}

	public virtual Label _lblVC_7
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblVC_7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblVC_7 = value;
		}
	}

	public virtual Label _Line2_7
	{
		[DebuggerNonUserCode]
		get
		{
			return __Line2_7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Line2_7 = value;
		}
	}

	public virtual RadioButton _optType_8
	{
		[DebuggerNonUserCode]
		get
		{
			return __optType_8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = optType_CheckedChanged;
			if (__optType_8 != null)
			{
				__optType_8.CheckedChanged -= eventHandler;
			}
			__optType_8 = value;
			if (__optType_8 != null)
			{
				__optType_8.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual Label _lblUnits_8
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblUnits_8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblUnits_8 = value;
		}
	}

	public virtual Label _lblV_8
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblV_8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblV_8 = value;
		}
	}

	public virtual Label _lblVC_8
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblVC_8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblVC_8 = value;
		}
	}

	public virtual Label _Line2_8
	{
		[DebuggerNonUserCode]
		get
		{
			return __Line2_8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Line2_8 = value;
		}
	}

	public virtual RadioButton _optType_9
	{
		[DebuggerNonUserCode]
		get
		{
			return __optType_9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = optType_CheckedChanged;
			if (__optType_9 != null)
			{
				__optType_9.CheckedChanged -= eventHandler;
			}
			__optType_9 = value;
			if (__optType_9 != null)
			{
				__optType_9.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual Label _lblUnits_9
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblUnits_9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblUnits_9 = value;
		}
	}

	public virtual Label _lblV_9
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblV_9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblV_9 = value;
		}
	}

	public virtual Label _lblVC_9
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblVC_9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblVC_9 = value;
		}
	}

	public virtual Label _Line2_9
	{
		[DebuggerNonUserCode]
		get
		{
			return __Line2_9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Line2_9 = value;
		}
	}

	public virtual RadioButton _optType_10
	{
		[DebuggerNonUserCode]
		get
		{
			return __optType_10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = optType_CheckedChanged;
			if (__optType_10 != null)
			{
				__optType_10.CheckedChanged -= eventHandler;
			}
			__optType_10 = value;
			if (__optType_10 != null)
			{
				__optType_10.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual Label _lblUnits_10
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblUnits_10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblUnits_10 = value;
		}
	}

	public virtual Label _lblV_10
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblV_10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblV_10 = value;
		}
	}

	public virtual Label _lblVC_10
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblVC_10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblVC_10 = value;
		}
	}

	public virtual Label _lblV_11
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblV_11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblV_11 = value;
		}
	}

	public virtual RadioButton _optType_11
	{
		[DebuggerNonUserCode]
		get
		{
			return __optType_11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = optType_CheckedChanged;
			if (__optType_11 != null)
			{
				__optType_11.CheckedChanged -= eventHandler;
			}
			__optType_11 = value;
			if (__optType_11 != null)
			{
				__optType_11.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual Label _lblUnits_11
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblUnits_11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblUnits_11 = value;
		}
	}

	public virtual Label _lblVC_11
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblVC_11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblVC_11 = value;
		}
	}

	public virtual Label _Line2_11
	{
		[DebuggerNonUserCode]
		get
		{
			return __Line2_11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Line2_11 = value;
		}
	}

	public virtual Label _Line2_10
	{
		[DebuggerNonUserCode]
		get
		{
			return __Line2_10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Line2_10 = value;
		}
	}

	public static frmMDUpdAmtFreq DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmMDUpdAmtFreq();
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

	public frmMDUpdAmtFreq()
	{
		((Form)this).Load += frmMDUpdAmtFreq_Load;
		__ENCAddToList(this);
		myMaxRows = 10;
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
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
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
		//IL_047e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Expected O, but got Unknown
		//IL_0540: Unknown result type (might be due to invalid IL or missing references)
		//IL_054a: Expected O, but got Unknown
		//IL_062a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0634: Expected O, but got Unknown
		//IL_0711: Unknown result type (might be due to invalid IL or missing references)
		//IL_071b: Expected O, but got Unknown
		//IL_07e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ee: Expected O, but got Unknown
		//IL_092d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0937: Expected O, but got Unknown
		//IL_0a17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a21: Expected O, but got Unknown
		//IL_0b01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0b: Expected O, but got Unknown
		//IL_0beb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf5: Expected O, but got Unknown
		//IL_0d39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d43: Expected O, but got Unknown
		//IL_0e13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1d: Expected O, but got Unknown
		//IL_0eed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef7: Expected O, but got Unknown
		//IL_103e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1048: Expected O, but got Unknown
		//IL_1115: Unknown result type (might be due to invalid IL or missing references)
		//IL_111f: Expected O, but got Unknown
		//IL_11ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f6: Expected O, but got Unknown
		//IL_12c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_12cf: Expected O, but got Unknown
		//IL_1399: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a3: Expected O, but got Unknown
		//IL_146d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1477: Expected O, but got Unknown
		//IL_152f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1539: Expected O, but got Unknown
		//IL_161a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1624: Expected O, but got Unknown
		//IL_16f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_16fb: Expected O, but got Unknown
		//IL_17c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_17d2: Expected O, but got Unknown
		//IL_1913: Unknown result type (might be due to invalid IL or missing references)
		//IL_191d: Expected O, but got Unknown
		//IL_19fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a08: Expected O, but got Unknown
		//IL_1ad5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1adf: Expected O, but got Unknown
		//IL_1bac: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bb6: Expected O, but got Unknown
		//IL_1cf7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d01: Expected O, but got Unknown
		//IL_1de2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dec: Expected O, but got Unknown
		//IL_1eb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ec3: Expected O, but got Unknown
		//IL_1f90: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f9a: Expected O, but got Unknown
		//IL_20db: Unknown result type (might be due to invalid IL or missing references)
		//IL_20e5: Expected O, but got Unknown
		//IL_21c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_21d0: Expected O, but got Unknown
		//IL_229d: Unknown result type (might be due to invalid IL or missing references)
		//IL_22a7: Expected O, but got Unknown
		//IL_2374: Unknown result type (might be due to invalid IL or missing references)
		//IL_237e: Expected O, but got Unknown
		//IL_24bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_24c9: Expected O, but got Unknown
		//IL_25aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_25b4: Expected O, but got Unknown
		//IL_2681: Unknown result type (might be due to invalid IL or missing references)
		//IL_268b: Expected O, but got Unknown
		//IL_2758: Unknown result type (might be due to invalid IL or missing references)
		//IL_2762: Expected O, but got Unknown
		//IL_28a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_28ad: Expected O, but got Unknown
		//IL_298e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2998: Expected O, but got Unknown
		//IL_2a65: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a6f: Expected O, but got Unknown
		//IL_2b3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b46: Expected O, but got Unknown
		//IL_2c87: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c91: Expected O, but got Unknown
		//IL_2d72: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d7c: Expected O, but got Unknown
		//IL_2e49: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e53: Expected O, but got Unknown
		//IL_2f20: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f2a: Expected O, but got Unknown
		//IL_306b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3075: Expected O, but got Unknown
		//IL_3156: Unknown result type (might be due to invalid IL or missing references)
		//IL_3160: Expected O, but got Unknown
		//IL_322d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3237: Expected O, but got Unknown
		//IL_3304: Unknown result type (might be due to invalid IL or missing references)
		//IL_330e: Expected O, but got Unknown
		//IL_344f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3459: Expected O, but got Unknown
		//IL_353a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3544: Expected O, but got Unknown
		//IL_3611: Unknown result type (might be due to invalid IL or missing references)
		//IL_361b: Expected O, but got Unknown
		//IL_36e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_36f2: Expected O, but got Unknown
		//IL_3833: Unknown result type (might be due to invalid IL or missing references)
		//IL_383d: Expected O, but got Unknown
		//IL_390a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3914: Expected O, but got Unknown
		//IL_39f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_39ff: Expected O, but got Unknown
		//IL_3acc: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ad6: Expected O, but got Unknown
		//IL_414f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4159: Expected O, but got Unknown
		//IL_416e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4178: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMDUpdAmtFreq));
		ToolTip1 = new ToolTip(components);
		txtInput = new TextBox();
		_optType_1 = new RadioButton();
		_optType_0 = new RadioButton();
		cmdCancel = new Button();
		cmdClose = new Button();
		_Line2_0 = new Label();
		_lblUnits_1 = new Label();
		_lblV_1 = new Label();
		_lblVC_1 = new Label();
		lblParm = new Label();
		_Line2_1 = new Label();
		_lblUnits_0 = new Label();
		_lblVC_0 = new Label();
		_lblV_0 = new Label();
		_Line1_0 = new Label();
		_Label1_2 = new Label();
		_Label1_1 = new Label();
		_Label1_0 = new Label();
		_Label1_98 = new Label();
		_Label1_76 = new Label();
		lblInstructions = new Label();
		Label1 = new LabelArray(components);
		Line1 = new LabelArray(components);
		Line2 = new LabelArray(components);
		lblUnits = new LabelArray(components);
		lblV = new LabelArray(components);
		lblVC = new LabelArray(components);
		_optType_2 = new RadioButton();
		_lblUnits_2 = new Label();
		_lblV_2 = new Label();
		_lblVC_2 = new Label();
		_Line2_2 = new Label();
		_optType_3 = new RadioButton();
		_lblUnits_3 = new Label();
		_lblV_3 = new Label();
		_lblVC_3 = new Label();
		_Line2_3 = new Label();
		_optType_4 = new RadioButton();
		_lblUnits_4 = new Label();
		_lblV_4 = new Label();
		_lblVC_4 = new Label();
		_Line2_4 = new Label();
		_optType_5 = new RadioButton();
		_lblUnits_5 = new Label();
		_lblV_5 = new Label();
		_lblVC_5 = new Label();
		_Line2_5 = new Label();
		_optType_6 = new RadioButton();
		_lblUnits_6 = new Label();
		_lblV_6 = new Label();
		_lblVC_6 = new Label();
		_Line2_6 = new Label();
		_optType_7 = new RadioButton();
		_lblUnits_7 = new Label();
		_lblV_7 = new Label();
		_lblVC_7 = new Label();
		_Line2_7 = new Label();
		_optType_8 = new RadioButton();
		_lblUnits_8 = new Label();
		_lblV_8 = new Label();
		_lblVC_8 = new Label();
		_Line2_8 = new Label();
		_optType_9 = new RadioButton();
		_lblUnits_9 = new Label();
		_lblV_9 = new Label();
		_lblVC_9 = new Label();
		_Line2_9 = new Label();
		_optType_10 = new RadioButton();
		_lblUnits_10 = new Label();
		_lblV_10 = new Label();
		_lblVC_10 = new Label();
		_Line2_10 = new Label();
		_lblV_11 = new Label();
		_optType_11 = new RadioButton();
		_lblUnits_11 = new Label();
		_lblVC_11 = new Label();
		_Line2_11 = new Label();
		((ISupportInitialize)Label1).BeginInit();
		((ISupportInitialize)Line1).BeginInit();
		((ISupportInitialize)Line2).BeginInit();
		((ISupportInitialize)lblUnits).BeginInit();
		((ISupportInitialize)lblV).BeginInit();
		((ISupportInitialize)lblVC).BeginInit();
		((Control)this).SuspendLayout();
		txtInput.AcceptsReturn = true;
		((TextBoxBase)txtInput).BackColor = SystemColors.Window;
		((Control)txtInput).Cursor = Cursors.IBeam;
		((Control)txtInput).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtInput).ForeColor = SystemColors.WindowText;
		TextBox obj = txtInput;
		Point location = new Point(279, 504);
		((Control)obj).Location = location;
		((TextBoxBase)txtInput).MaxLength = 0;
		((Control)txtInput).Name = "txtInput";
		((Control)txtInput).RightToLeft = (RightToLeft)0;
		TextBox obj2 = txtInput;
		Size size = new Size(81, 20);
		((Control)obj2).Size = size;
		((Control)txtInput).TabIndex = 2;
		((ButtonBase)_optType_1).BackColor = SystemColors.Control;
		((Control)_optType_1).Cursor = Cursors.Default;
		((Control)_optType_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optType_1).ForeColor = SystemColors.ControlText;
		RadioButton optType_ = _optType_1;
		location = new Point(16, 128);
		((Control)optType_).Location = location;
		((Control)_optType_1).Name = "_optType_1";
		((Control)_optType_1).RightToLeft = (RightToLeft)0;
		RadioButton optType_2 = _optType_1;
		size = new Size(89, 17);
		((Control)optType_2).Size = size;
		((Control)_optType_1).TabIndex = 1;
		_optType_1.TabStop = true;
		((ButtonBase)_optType_1).Text = "Non-default";
		((ButtonBase)_optType_1).UseVisualStyleBackColor = false;
		((Control)_optType_1).Visible = false;
		((ButtonBase)_optType_0).BackColor = SystemColors.Control;
		((Control)_optType_0).Cursor = Cursors.Default;
		((Control)_optType_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optType_0).ForeColor = SystemColors.ControlText;
		RadioButton optType_3 = _optType_0;
		location = new Point(16, 96);
		((Control)optType_3).Location = location;
		((Control)_optType_0).Name = "_optType_0";
		((Control)_optType_0).RightToLeft = (RightToLeft)0;
		RadioButton optType_4 = _optType_0;
		size = new Size(89, 17);
		((Control)optType_4).Size = size;
		((Control)_optType_0).TabIndex = 0;
		_optType_0.TabStop = true;
		((ButtonBase)_optType_0).Text = "Default";
		((ButtonBase)_optType_0).UseVisualStyleBackColor = false;
		((ButtonBase)cmdCancel).BackColor = SystemColors.Control;
		((Control)cmdCancel).Cursor = Cursors.Default;
		cmdCancel.DialogResult = (DialogResult)2;
		((Control)cmdCancel).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCancel).ForeColor = SystemColors.ControlText;
		Button obj3 = cmdCancel;
		location = new Point(320, 557);
		((Control)obj3).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		((Control)cmdCancel).RightToLeft = (RightToLeft)0;
		Button obj4 = cmdCancel;
		size = new Size(81, 25);
		((Control)obj4).Size = size;
		((Control)cmdCancel).TabIndex = 4;
		((ButtonBase)cmdCancel).Text = "Cancel";
		((ButtonBase)cmdCancel).UseVisualStyleBackColor = false;
		((ButtonBase)cmdClose).BackColor = SystemColors.Control;
		((Control)cmdClose).Cursor = Cursors.Default;
		((Control)cmdClose).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdClose).ForeColor = SystemColors.ControlText;
		Button obj5 = cmdClose;
		location = new Point(224, 557);
		((Control)obj5).Location = location;
		((Control)cmdClose).Name = "cmdClose";
		((Control)cmdClose).RightToLeft = (RightToLeft)0;
		Button obj6 = cmdClose;
		size = new Size(81, 25);
		((Control)obj6).Size = size;
		((Control)cmdClose).TabIndex = 3;
		((ButtonBase)cmdClose).Text = "Ok";
		((ButtonBase)cmdClose).UseVisualStyleBackColor = false;
		((Control)_Line2_0).BackColor = SystemColors.WindowText;
		Line2.SetIndex(_Line2_0, (short)0);
		Label line2_ = _Line2_0;
		location = new Point(8, 120);
		((Control)line2_).Location = location;
		((Control)_Line2_0).Name = "_Line2_0";
		Label line2_2 = _Line2_0;
		size = new Size(624, 1);
		((Control)line2_2).Size = size;
		((Control)_Line2_0).TabIndex = 5;
		((Control)_lblUnits_1).BackColor = SystemColors.Control;
		((Control)_lblUnits_1).Cursor = Cursors.Default;
		((Control)_lblUnits_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblUnits_1).ForeColor = SystemColors.ControlText;
		lblUnits.SetIndex(_lblUnits_1, (short)1);
		Label lblUnits_ = _lblUnits_1;
		location = new Point(464, 128);
		((Control)lblUnits_).Location = location;
		((Control)_lblUnits_1).Name = "_lblUnits_1";
		((Control)_lblUnits_1).RightToLeft = (RightToLeft)0;
		Label lblUnits_2 = _lblUnits_1;
		size = new Size(153, 17);
		((Control)lblUnits_2).Size = size;
		((Control)_lblUnits_1).TabIndex = 17;
		_lblUnits_1.Text = "x";
		((Control)_lblUnits_1).Visible = false;
		((Control)_lblV_1).BackColor = SystemColors.Control;
		((Control)_lblV_1).Cursor = Cursors.Default;
		((Control)_lblV_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblV_1).ForeColor = SystemColors.ControlText;
		lblV.SetIndex(_lblV_1, (short)1);
		Label lblV_ = _lblV_1;
		location = new Point(288, 128);
		((Control)lblV_).Location = location;
		((Control)_lblV_1).Name = "_lblV_1";
		((Control)_lblV_1).RightToLeft = (RightToLeft)0;
		Label lblV_2 = _lblV_1;
		size = new Size(153, 17);
		((Control)lblV_2).Size = size;
		((Control)_lblV_1).TabIndex = 16;
		_lblV_1.Text = "x";
		((Control)_lblV_1).Visible = false;
		((Control)_lblVC_1).BackColor = SystemColors.Control;
		((Control)_lblVC_1).Cursor = Cursors.Default;
		((Control)_lblVC_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblVC_1).ForeColor = SystemColors.ControlText;
		lblVC.SetIndex(_lblVC_1, (short)1);
		Label lblVC_ = _lblVC_1;
		location = new Point(128, 128);
		((Control)lblVC_).Location = location;
		((Control)_lblVC_1).Name = "_lblVC_1";
		((Control)_lblVC_1).RightToLeft = (RightToLeft)0;
		Label lblVC_2 = _lblVC_1;
		size = new Size(145, 17);
		((Control)lblVC_2).Size = size;
		((Control)_lblVC_1).TabIndex = 15;
		_lblVC_1.Text = "x";
		((Control)_lblVC_1).Visible = false;
		((Control)lblParm).BackColor = SystemColors.Control;
		((Control)lblParm).Cursor = Cursors.Default;
		((Control)lblParm).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblParm).ForeColor = SystemColors.ControlText;
		Label obj7 = lblParm;
		location = new Point(128, 40);
		((Control)obj7).Location = location;
		((Control)lblParm).Name = "lblParm";
		((Control)lblParm).RightToLeft = (RightToLeft)0;
		Label obj8 = lblParm;
		size = new Size(497, 17);
		((Control)obj8).Size = size;
		((Control)lblParm).TabIndex = 14;
		lblParm.Text = "x";
		((Control)_Line2_1).BackColor = SystemColors.WindowText;
		Line2.SetIndex(_Line2_1, (short)1);
		Label line2_3 = _Line2_1;
		location = new Point(8, 152);
		((Control)line2_3).Location = location;
		((Control)_Line2_1).Name = "_Line2_1";
		Label line2_4 = _Line2_1;
		size = new Size(624, 1);
		((Control)line2_4).Size = size;
		((Control)_Line2_1).TabIndex = 18;
		((Control)_Line2_1).Visible = false;
		((Control)_lblUnits_0).BackColor = SystemColors.Control;
		((Control)_lblUnits_0).Cursor = Cursors.Default;
		((Control)_lblUnits_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblUnits_0).ForeColor = SystemColors.ControlText;
		lblUnits.SetIndex(_lblUnits_0, (short)0);
		Label lblUnits_3 = _lblUnits_0;
		location = new Point(464, 96);
		((Control)lblUnits_3).Location = location;
		((Control)_lblUnits_0).Name = "_lblUnits_0";
		((Control)_lblUnits_0).RightToLeft = (RightToLeft)0;
		Label lblUnits_4 = _lblUnits_0;
		size = new Size(153, 17);
		((Control)lblUnits_4).Size = size;
		((Control)_lblUnits_0).TabIndex = 13;
		_lblUnits_0.Text = "x";
		((Control)_lblVC_0).BackColor = SystemColors.Control;
		((Control)_lblVC_0).Cursor = Cursors.Default;
		((Control)_lblVC_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblVC_0).ForeColor = SystemColors.ControlText;
		lblVC.SetIndex(_lblVC_0, (short)0);
		Label lblVC_3 = _lblVC_0;
		location = new Point(128, 96);
		((Control)lblVC_3).Location = location;
		((Control)_lblVC_0).Name = "_lblVC_0";
		((Control)_lblVC_0).RightToLeft = (RightToLeft)0;
		Label lblVC_4 = _lblVC_0;
		size = new Size(145, 17);
		((Control)lblVC_4).Size = size;
		((Control)_lblVC_0).TabIndex = 12;
		_lblVC_0.Text = "x";
		((Control)_lblV_0).BackColor = SystemColors.Control;
		((Control)_lblV_0).Cursor = Cursors.Default;
		((Control)_lblV_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblV_0).ForeColor = SystemColors.ControlText;
		lblV.SetIndex(_lblV_0, (short)0);
		Label lblV_3 = _lblV_0;
		location = new Point(288, 96);
		((Control)lblV_3).Location = location;
		((Control)_lblV_0).Name = "_lblV_0";
		((Control)_lblV_0).RightToLeft = (RightToLeft)0;
		Label lblV_4 = _lblV_0;
		size = new Size(153, 17);
		((Control)lblV_4).Size = size;
		((Control)_lblV_0).TabIndex = 11;
		_lblV_0.Text = "x";
		((Control)_Line1_0).BackColor = SystemColors.WindowText;
		Line1.SetIndex(_Line1_0, (short)0);
		Label line1_ = _Line1_0;
		location = new Point(8, 88);
		((Control)line1_).Location = location;
		((Control)_Line1_0).Name = "_Line1_0";
		Label line1_2 = _Line1_0;
		size = new Size(624, 1);
		((Control)line1_2).Size = size;
		((Control)_Line1_0).TabIndex = 19;
		((Control)_Label1_2).BackColor = SystemColors.Control;
		((Control)_Label1_2).Cursor = Cursors.Default;
		((Control)_Label1_2).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_2).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_2, (short)2);
		Label label1_ = _Label1_2;
		location = new Point(464, 72);
		((Control)label1_).Location = location;
		((Control)_Label1_2).Name = "_Label1_2";
		((Control)_Label1_2).RightToLeft = (RightToLeft)0;
		Label label1_2 = _Label1_2;
		size = new Size(49, 17);
		((Control)label1_2).Size = size;
		((Control)_Label1_2).TabIndex = 10;
		_Label1_2.Text = "Units";
		((Control)_Label1_1).BackColor = SystemColors.Control;
		((Control)_Label1_1).Cursor = Cursors.Default;
		((Control)_Label1_1).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_1).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_1, (short)1);
		Label label1_3 = _Label1_1;
		location = new Point(288, 72);
		((Control)label1_3).Location = location;
		((Control)_Label1_1).Name = "_Label1_1";
		((Control)_Label1_1).RightToLeft = (RightToLeft)0;
		Label label1_4 = _Label1_1;
		size = new Size(49, 17);
		((Control)label1_4).Size = size;
		((Control)_Label1_1).TabIndex = 9;
		_Label1_1.Text = "Value";
		((Control)_Label1_0).BackColor = SystemColors.Control;
		((Control)_Label1_0).Cursor = Cursors.Default;
		((Control)_Label1_0).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_0).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_0, (short)0);
		Label label1_5 = _Label1_0;
		location = new Point(128, 72);
		((Control)label1_5).Location = location;
		((Control)_Label1_0).Name = "_Label1_0";
		((Control)_Label1_0).RightToLeft = (RightToLeft)0;
		Label label1_6 = _Label1_0;
		size = new Size(129, 17);
		((Control)label1_6).Size = size;
		((Control)_Label1_0).TabIndex = 8;
		_Label1_0.Text = "Value Calculation";
		((Control)_Label1_98).BackColor = SystemColors.Control;
		((Control)_Label1_98).Cursor = Cursors.Default;
		((Control)_Label1_98).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_98).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_98, (short)98);
		Label label1_7 = _Label1_98;
		location = new Point(16, 40);
		((Control)label1_7).Location = location;
		((Control)_Label1_98).Name = "_Label1_98";
		((Control)_Label1_98).RightToLeft = (RightToLeft)0;
		Label label1_8 = _Label1_98;
		size = new Size(105, 17);
		((Control)label1_8).Size = size;
		((Control)_Label1_98).TabIndex = 7;
		_Label1_98.Text = "Model Parameter: ";
		((Control)_Label1_76).BackColor = SystemColors.Control;
		((Control)_Label1_76).Cursor = Cursors.Default;
		((Control)_Label1_76).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_76).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_76, (short)76);
		Label label1_9 = _Label1_76;
		location = new Point(16, 72);
		((Control)label1_9).Location = location;
		((Control)_Label1_76).Name = "_Label1_76";
		((Control)_Label1_76).RightToLeft = (RightToLeft)0;
		Label label1_10 = _Label1_76;
		size = new Size(49, 17);
		((Control)label1_10).Size = size;
		((Control)_Label1_76).TabIndex = 6;
		_Label1_76.Text = "Type";
		((Control)lblInstructions).BackColor = SystemColors.Control;
		((Control)lblInstructions).Cursor = Cursors.Default;
		((Control)lblInstructions).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblInstructions).ForeColor = SystemColors.ControlText;
		Label obj9 = lblInstructions;
		location = new Point(16, 8);
		((Control)obj9).Location = location;
		((Control)lblInstructions).Name = "lblInstructions";
		((Control)lblInstructions).RightToLeft = (RightToLeft)0;
		Label obj10 = lblInstructions;
		size = new Size(609, 25);
		((Control)obj10).Size = size;
		((Control)lblInstructions).TabIndex = 5;
		lblInstructions.Text = "As appropriate, view or update the Value Calculation for this model parameter.";
		((ButtonBase)_optType_2).BackColor = SystemColors.Control;
		((Control)_optType_2).Cursor = Cursors.Default;
		((Control)_optType_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optType_2).ForeColor = SystemColors.ControlText;
		RadioButton optType_5 = _optType_2;
		location = new Point(16, 165);
		((Control)optType_5).Location = location;
		((Control)_optType_2).Name = "_optType_2";
		((Control)_optType_2).RightToLeft = (RightToLeft)0;
		RadioButton optType_6 = _optType_2;
		size = new Size(89, 17);
		((Control)optType_6).Size = size;
		((Control)_optType_2).TabIndex = 20;
		_optType_2.TabStop = true;
		((ButtonBase)_optType_2).Text = "Non-default";
		((ButtonBase)_optType_2).UseVisualStyleBackColor = false;
		((Control)_optType_2).Visible = false;
		((Control)_lblUnits_2).BackColor = SystemColors.Control;
		((Control)_lblUnits_2).Cursor = Cursors.Default;
		((Control)_lblUnits_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblUnits_2).ForeColor = SystemColors.ControlText;
		Label lblUnits_5 = _lblUnits_2;
		location = new Point(464, 165);
		((Control)lblUnits_5).Location = location;
		((Control)_lblUnits_2).Name = "_lblUnits_2";
		((Control)_lblUnits_2).RightToLeft = (RightToLeft)0;
		Label lblUnits_6 = _lblUnits_2;
		size = new Size(153, 17);
		((Control)lblUnits_6).Size = size;
		((Control)_lblUnits_2).TabIndex = 23;
		_lblUnits_2.Text = "x";
		((Control)_lblUnits_2).Visible = false;
		((Control)_lblV_2).BackColor = SystemColors.Control;
		((Control)_lblV_2).Cursor = Cursors.Default;
		((Control)_lblV_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblV_2).ForeColor = SystemColors.ControlText;
		Label lblV_5 = _lblV_2;
		location = new Point(288, 165);
		((Control)lblV_5).Location = location;
		((Control)_lblV_2).Name = "_lblV_2";
		((Control)_lblV_2).RightToLeft = (RightToLeft)0;
		Label lblV_6 = _lblV_2;
		size = new Size(153, 17);
		((Control)lblV_6).Size = size;
		((Control)_lblV_2).TabIndex = 22;
		_lblV_2.Text = "x";
		((Control)_lblV_2).Visible = false;
		((Control)_lblVC_2).BackColor = SystemColors.Control;
		((Control)_lblVC_2).Cursor = Cursors.Default;
		((Control)_lblVC_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblVC_2).ForeColor = SystemColors.ControlText;
		Label lblVC_5 = _lblVC_2;
		location = new Point(128, 165);
		((Control)lblVC_5).Location = location;
		((Control)_lblVC_2).Name = "_lblVC_2";
		((Control)_lblVC_2).RightToLeft = (RightToLeft)0;
		Label lblVC_6 = _lblVC_2;
		size = new Size(145, 17);
		((Control)lblVC_6).Size = size;
		((Control)_lblVC_2).TabIndex = 21;
		_lblVC_2.Text = "x";
		((Control)_lblVC_2).Visible = false;
		((Control)_Line2_2).BackColor = SystemColors.WindowText;
		Label line2_5 = _Line2_2;
		location = new Point(8, 189);
		((Control)line2_5).Location = location;
		((Control)_Line2_2).Name = "_Line2_2";
		Label line2_6 = _Line2_2;
		size = new Size(624, 1);
		((Control)line2_6).Size = size;
		((Control)_Line2_2).TabIndex = 24;
		((Control)_Line2_2).Visible = false;
		((ButtonBase)_optType_3).BackColor = SystemColors.Control;
		((Control)_optType_3).Cursor = Cursors.Default;
		((Control)_optType_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optType_3).ForeColor = SystemColors.ControlText;
		RadioButton optType_7 = _optType_3;
		location = new Point(16, 202);
		((Control)optType_7).Location = location;
		((Control)_optType_3).Name = "_optType_3";
		((Control)_optType_3).RightToLeft = (RightToLeft)0;
		RadioButton optType_8 = _optType_3;
		size = new Size(89, 17);
		((Control)optType_8).Size = size;
		((Control)_optType_3).TabIndex = 25;
		_optType_3.TabStop = true;
		((ButtonBase)_optType_3).Text = "Non-default";
		((ButtonBase)_optType_3).UseVisualStyleBackColor = false;
		((Control)_optType_3).Visible = false;
		((Control)_lblUnits_3).BackColor = SystemColors.Control;
		((Control)_lblUnits_3).Cursor = Cursors.Default;
		((Control)_lblUnits_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblUnits_3).ForeColor = SystemColors.ControlText;
		Label lblUnits_7 = _lblUnits_3;
		location = new Point(464, 202);
		((Control)lblUnits_7).Location = location;
		((Control)_lblUnits_3).Name = "_lblUnits_3";
		((Control)_lblUnits_3).RightToLeft = (RightToLeft)0;
		Label lblUnits_8 = _lblUnits_3;
		size = new Size(153, 17);
		((Control)lblUnits_8).Size = size;
		((Control)_lblUnits_3).TabIndex = 28;
		_lblUnits_3.Text = "x";
		((Control)_lblUnits_3).Visible = false;
		((Control)_lblV_3).BackColor = SystemColors.Control;
		((Control)_lblV_3).Cursor = Cursors.Default;
		((Control)_lblV_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblV_3).ForeColor = SystemColors.ControlText;
		Label lblV_7 = _lblV_3;
		location = new Point(288, 202);
		((Control)lblV_7).Location = location;
		((Control)_lblV_3).Name = "_lblV_3";
		((Control)_lblV_3).RightToLeft = (RightToLeft)0;
		Label lblV_8 = _lblV_3;
		size = new Size(153, 17);
		((Control)lblV_8).Size = size;
		((Control)_lblV_3).TabIndex = 27;
		_lblV_3.Text = "x";
		((Control)_lblV_3).Visible = false;
		((Control)_lblVC_3).BackColor = SystemColors.Control;
		((Control)_lblVC_3).Cursor = Cursors.Default;
		((Control)_lblVC_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblVC_3).ForeColor = SystemColors.ControlText;
		Label lblVC_7 = _lblVC_3;
		location = new Point(128, 202);
		((Control)lblVC_7).Location = location;
		((Control)_lblVC_3).Name = "_lblVC_3";
		((Control)_lblVC_3).RightToLeft = (RightToLeft)0;
		Label lblVC_8 = _lblVC_3;
		size = new Size(145, 17);
		((Control)lblVC_8).Size = size;
		((Control)_lblVC_3).TabIndex = 26;
		_lblVC_3.Text = "x";
		((Control)_lblVC_3).Visible = false;
		((Control)_Line2_3).BackColor = SystemColors.WindowText;
		Label line2_7 = _Line2_3;
		location = new Point(8, 226);
		((Control)line2_7).Location = location;
		((Control)_Line2_3).Name = "_Line2_3";
		Label line2_8 = _Line2_3;
		size = new Size(624, 1);
		((Control)line2_8).Size = size;
		((Control)_Line2_3).TabIndex = 29;
		((Control)_Line2_3).Visible = false;
		((ButtonBase)_optType_4).BackColor = SystemColors.Control;
		((Control)_optType_4).Cursor = Cursors.Default;
		((Control)_optType_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optType_4).ForeColor = SystemColors.ControlText;
		RadioButton optType_9 = _optType_4;
		location = new Point(16, 240);
		((Control)optType_9).Location = location;
		((Control)_optType_4).Name = "_optType_4";
		((Control)_optType_4).RightToLeft = (RightToLeft)0;
		RadioButton optType_10 = _optType_4;
		size = new Size(89, 17);
		((Control)optType_10).Size = size;
		((Control)_optType_4).TabIndex = 30;
		_optType_4.TabStop = true;
		((ButtonBase)_optType_4).Text = "Non-default";
		((ButtonBase)_optType_4).UseVisualStyleBackColor = false;
		((Control)_optType_4).Visible = false;
		((Control)_lblUnits_4).BackColor = SystemColors.Control;
		((Control)_lblUnits_4).Cursor = Cursors.Default;
		((Control)_lblUnits_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblUnits_4).ForeColor = SystemColors.ControlText;
		Label lblUnits_9 = _lblUnits_4;
		location = new Point(464, 240);
		((Control)lblUnits_9).Location = location;
		((Control)_lblUnits_4).Name = "_lblUnits_4";
		((Control)_lblUnits_4).RightToLeft = (RightToLeft)0;
		Label lblUnits_10 = _lblUnits_4;
		size = new Size(153, 17);
		((Control)lblUnits_10).Size = size;
		((Control)_lblUnits_4).TabIndex = 33;
		_lblUnits_4.Text = "x";
		((Control)_lblUnits_4).Visible = false;
		((Control)_lblV_4).BackColor = SystemColors.Control;
		((Control)_lblV_4).Cursor = Cursors.Default;
		((Control)_lblV_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblV_4).ForeColor = SystemColors.ControlText;
		Label lblV_9 = _lblV_4;
		location = new Point(288, 240);
		((Control)lblV_9).Location = location;
		((Control)_lblV_4).Name = "_lblV_4";
		((Control)_lblV_4).RightToLeft = (RightToLeft)0;
		Label lblV_10 = _lblV_4;
		size = new Size(153, 17);
		((Control)lblV_10).Size = size;
		((Control)_lblV_4).TabIndex = 32;
		_lblV_4.Text = "x";
		((Control)_lblV_4).Visible = false;
		((Control)_lblVC_4).BackColor = SystemColors.Control;
		((Control)_lblVC_4).Cursor = Cursors.Default;
		((Control)_lblVC_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblVC_4).ForeColor = SystemColors.ControlText;
		Label lblVC_9 = _lblVC_4;
		location = new Point(128, 240);
		((Control)lblVC_9).Location = location;
		((Control)_lblVC_4).Name = "_lblVC_4";
		((Control)_lblVC_4).RightToLeft = (RightToLeft)0;
		Label lblVC_10 = _lblVC_4;
		size = new Size(145, 17);
		((Control)lblVC_10).Size = size;
		((Control)_lblVC_4).TabIndex = 31;
		_lblVC_4.Text = "x";
		((Control)_lblVC_4).Visible = false;
		((Control)_Line2_4).BackColor = SystemColors.WindowText;
		Label line2_9 = _Line2_4;
		location = new Point(8, 264);
		((Control)line2_9).Location = location;
		((Control)_Line2_4).Name = "_Line2_4";
		Label line2_10 = _Line2_4;
		size = new Size(624, 1);
		((Control)line2_10).Size = size;
		((Control)_Line2_4).TabIndex = 34;
		((Control)_Line2_4).Visible = false;
		((ButtonBase)_optType_5).BackColor = SystemColors.Control;
		((Control)_optType_5).Cursor = Cursors.Default;
		((Control)_optType_5).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optType_5).ForeColor = SystemColors.ControlText;
		RadioButton optType_11 = _optType_5;
		location = new Point(16, 277);
		((Control)optType_11).Location = location;
		((Control)_optType_5).Name = "_optType_5";
		((Control)_optType_5).RightToLeft = (RightToLeft)0;
		RadioButton optType_12 = _optType_5;
		size = new Size(89, 17);
		((Control)optType_12).Size = size;
		((Control)_optType_5).TabIndex = 35;
		_optType_5.TabStop = true;
		((ButtonBase)_optType_5).Text = "Non-default";
		((ButtonBase)_optType_5).UseVisualStyleBackColor = false;
		((Control)_optType_5).Visible = false;
		((Control)_lblUnits_5).BackColor = SystemColors.Control;
		((Control)_lblUnits_5).Cursor = Cursors.Default;
		((Control)_lblUnits_5).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblUnits_5).ForeColor = SystemColors.ControlText;
		Label lblUnits_11 = _lblUnits_5;
		location = new Point(464, 277);
		((Control)lblUnits_11).Location = location;
		((Control)_lblUnits_5).Name = "_lblUnits_5";
		((Control)_lblUnits_5).RightToLeft = (RightToLeft)0;
		Label lblUnits_12 = _lblUnits_5;
		size = new Size(153, 17);
		((Control)lblUnits_12).Size = size;
		((Control)_lblUnits_5).TabIndex = 38;
		_lblUnits_5.Text = "x";
		((Control)_lblUnits_5).Visible = false;
		((Control)_lblV_5).BackColor = SystemColors.Control;
		((Control)_lblV_5).Cursor = Cursors.Default;
		((Control)_lblV_5).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblV_5).ForeColor = SystemColors.ControlText;
		Label lblV_11 = _lblV_5;
		location = new Point(288, 277);
		((Control)lblV_11).Location = location;
		((Control)_lblV_5).Name = "_lblV_5";
		((Control)_lblV_5).RightToLeft = (RightToLeft)0;
		Label lblV_12 = _lblV_5;
		size = new Size(153, 17);
		((Control)lblV_12).Size = size;
		((Control)_lblV_5).TabIndex = 37;
		_lblV_5.Text = "x";
		((Control)_lblV_5).Visible = false;
		((Control)_lblVC_5).BackColor = SystemColors.Control;
		((Control)_lblVC_5).Cursor = Cursors.Default;
		((Control)_lblVC_5).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblVC_5).ForeColor = SystemColors.ControlText;
		Label lblVC_11 = _lblVC_5;
		location = new Point(128, 277);
		((Control)lblVC_11).Location = location;
		((Control)_lblVC_5).Name = "_lblVC_5";
		((Control)_lblVC_5).RightToLeft = (RightToLeft)0;
		Label lblVC_12 = _lblVC_5;
		size = new Size(145, 17);
		((Control)lblVC_12).Size = size;
		((Control)_lblVC_5).TabIndex = 36;
		_lblVC_5.Text = "x";
		((Control)_lblVC_5).Visible = false;
		((Control)_Line2_5).BackColor = SystemColors.WindowText;
		Label line2_11 = _Line2_5;
		location = new Point(8, 301);
		((Control)line2_11).Location = location;
		((Control)_Line2_5).Name = "_Line2_5";
		Label line2_12 = _Line2_5;
		size = new Size(624, 1);
		((Control)line2_12).Size = size;
		((Control)_Line2_5).TabIndex = 39;
		((Control)_Line2_5).Visible = false;
		((ButtonBase)_optType_6).BackColor = SystemColors.Control;
		((Control)_optType_6).Cursor = Cursors.Default;
		((Control)_optType_6).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optType_6).ForeColor = SystemColors.ControlText;
		RadioButton optType_13 = _optType_6;
		location = new Point(16, 316);
		((Control)optType_13).Location = location;
		((Control)_optType_6).Name = "_optType_6";
		((Control)_optType_6).RightToLeft = (RightToLeft)0;
		RadioButton optType_14 = _optType_6;
		size = new Size(89, 17);
		((Control)optType_14).Size = size;
		((Control)_optType_6).TabIndex = 40;
		_optType_6.TabStop = true;
		((ButtonBase)_optType_6).Text = "Non-default";
		((ButtonBase)_optType_6).UseVisualStyleBackColor = false;
		((Control)_optType_6).Visible = false;
		((Control)_lblUnits_6).BackColor = SystemColors.Control;
		((Control)_lblUnits_6).Cursor = Cursors.Default;
		((Control)_lblUnits_6).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblUnits_6).ForeColor = SystemColors.ControlText;
		Label lblUnits_13 = _lblUnits_6;
		location = new Point(464, 316);
		((Control)lblUnits_13).Location = location;
		((Control)_lblUnits_6).Name = "_lblUnits_6";
		((Control)_lblUnits_6).RightToLeft = (RightToLeft)0;
		Label lblUnits_14 = _lblUnits_6;
		size = new Size(153, 17);
		((Control)lblUnits_14).Size = size;
		((Control)_lblUnits_6).TabIndex = 43;
		_lblUnits_6.Text = "x";
		((Control)_lblUnits_6).Visible = false;
		((Control)_lblV_6).BackColor = SystemColors.Control;
		((Control)_lblV_6).Cursor = Cursors.Default;
		((Control)_lblV_6).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblV_6).ForeColor = SystemColors.ControlText;
		Label lblV_13 = _lblV_6;
		location = new Point(288, 316);
		((Control)lblV_13).Location = location;
		((Control)_lblV_6).Name = "_lblV_6";
		((Control)_lblV_6).RightToLeft = (RightToLeft)0;
		Label lblV_14 = _lblV_6;
		size = new Size(153, 17);
		((Control)lblV_14).Size = size;
		((Control)_lblV_6).TabIndex = 42;
		_lblV_6.Text = "x";
		((Control)_lblV_6).Visible = false;
		((Control)_lblVC_6).BackColor = SystemColors.Control;
		((Control)_lblVC_6).Cursor = Cursors.Default;
		((Control)_lblVC_6).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblVC_6).ForeColor = SystemColors.ControlText;
		Label lblVC_13 = _lblVC_6;
		location = new Point(128, 316);
		((Control)lblVC_13).Location = location;
		((Control)_lblVC_6).Name = "_lblVC_6";
		((Control)_lblVC_6).RightToLeft = (RightToLeft)0;
		Label lblVC_14 = _lblVC_6;
		size = new Size(145, 17);
		((Control)lblVC_14).Size = size;
		((Control)_lblVC_6).TabIndex = 41;
		_lblVC_6.Text = "x";
		((Control)_lblVC_6).Visible = false;
		((Control)_Line2_6).BackColor = SystemColors.WindowText;
		Label line2_13 = _Line2_6;
		location = new Point(8, 340);
		((Control)line2_13).Location = location;
		((Control)_Line2_6).Name = "_Line2_6";
		Label line2_14 = _Line2_6;
		size = new Size(624, 1);
		((Control)line2_14).Size = size;
		((Control)_Line2_6).TabIndex = 44;
		((Control)_Line2_6).Visible = false;
		((ButtonBase)_optType_7).BackColor = SystemColors.Control;
		((Control)_optType_7).Cursor = Cursors.Default;
		((Control)_optType_7).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optType_7).ForeColor = SystemColors.ControlText;
		RadioButton optType_15 = _optType_7;
		location = new Point(16, 353);
		((Control)optType_15).Location = location;
		((Control)_optType_7).Name = "_optType_7";
		((Control)_optType_7).RightToLeft = (RightToLeft)0;
		RadioButton optType_16 = _optType_7;
		size = new Size(89, 17);
		((Control)optType_16).Size = size;
		((Control)_optType_7).TabIndex = 45;
		_optType_7.TabStop = true;
		((ButtonBase)_optType_7).Text = "Non-default";
		((ButtonBase)_optType_7).UseVisualStyleBackColor = false;
		((Control)_optType_7).Visible = false;
		((Control)_lblUnits_7).BackColor = SystemColors.Control;
		((Control)_lblUnits_7).Cursor = Cursors.Default;
		((Control)_lblUnits_7).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblUnits_7).ForeColor = SystemColors.ControlText;
		Label lblUnits_15 = _lblUnits_7;
		location = new Point(464, 353);
		((Control)lblUnits_15).Location = location;
		((Control)_lblUnits_7).Name = "_lblUnits_7";
		((Control)_lblUnits_7).RightToLeft = (RightToLeft)0;
		Label lblUnits_16 = _lblUnits_7;
		size = new Size(153, 17);
		((Control)lblUnits_16).Size = size;
		((Control)_lblUnits_7).TabIndex = 48;
		_lblUnits_7.Text = "x";
		((Control)_lblUnits_7).Visible = false;
		((Control)_lblV_7).BackColor = SystemColors.Control;
		((Control)_lblV_7).Cursor = Cursors.Default;
		((Control)_lblV_7).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblV_7).ForeColor = SystemColors.ControlText;
		Label lblV_15 = _lblV_7;
		location = new Point(288, 353);
		((Control)lblV_15).Location = location;
		((Control)_lblV_7).Name = "_lblV_7";
		((Control)_lblV_7).RightToLeft = (RightToLeft)0;
		Label lblV_16 = _lblV_7;
		size = new Size(153, 17);
		((Control)lblV_16).Size = size;
		((Control)_lblV_7).TabIndex = 47;
		_lblV_7.Text = "x";
		((Control)_lblV_7).Visible = false;
		((Control)_lblVC_7).BackColor = SystemColors.Control;
		((Control)_lblVC_7).Cursor = Cursors.Default;
		((Control)_lblVC_7).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblVC_7).ForeColor = SystemColors.ControlText;
		Label lblVC_15 = _lblVC_7;
		location = new Point(128, 353);
		((Control)lblVC_15).Location = location;
		((Control)_lblVC_7).Name = "_lblVC_7";
		((Control)_lblVC_7).RightToLeft = (RightToLeft)0;
		Label lblVC_16 = _lblVC_7;
		size = new Size(145, 17);
		((Control)lblVC_16).Size = size;
		((Control)_lblVC_7).TabIndex = 46;
		_lblVC_7.Text = "x";
		((Control)_lblVC_7).Visible = false;
		((Control)_Line2_7).BackColor = SystemColors.WindowText;
		Label line2_15 = _Line2_7;
		location = new Point(8, 377);
		((Control)line2_15).Location = location;
		((Control)_Line2_7).Name = "_Line2_7";
		Label line2_16 = _Line2_7;
		size = new Size(624, 1);
		((Control)line2_16).Size = size;
		((Control)_Line2_7).TabIndex = 49;
		((Control)_Line2_7).Visible = false;
		((ButtonBase)_optType_8).BackColor = SystemColors.Control;
		((Control)_optType_8).Cursor = Cursors.Default;
		((Control)_optType_8).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optType_8).ForeColor = SystemColors.ControlText;
		RadioButton optType_17 = _optType_8;
		location = new Point(16, 392);
		((Control)optType_17).Location = location;
		((Control)_optType_8).Name = "_optType_8";
		((Control)_optType_8).RightToLeft = (RightToLeft)0;
		RadioButton optType_18 = _optType_8;
		size = new Size(89, 17);
		((Control)optType_18).Size = size;
		((Control)_optType_8).TabIndex = 50;
		_optType_8.TabStop = true;
		((ButtonBase)_optType_8).Text = "Non-default";
		((ButtonBase)_optType_8).UseVisualStyleBackColor = false;
		((Control)_optType_8).Visible = false;
		((Control)_lblUnits_8).BackColor = SystemColors.Control;
		((Control)_lblUnits_8).Cursor = Cursors.Default;
		((Control)_lblUnits_8).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblUnits_8).ForeColor = SystemColors.ControlText;
		Label lblUnits_17 = _lblUnits_8;
		location = new Point(464, 392);
		((Control)lblUnits_17).Location = location;
		((Control)_lblUnits_8).Name = "_lblUnits_8";
		((Control)_lblUnits_8).RightToLeft = (RightToLeft)0;
		Label lblUnits_18 = _lblUnits_8;
		size = new Size(153, 17);
		((Control)lblUnits_18).Size = size;
		((Control)_lblUnits_8).TabIndex = 53;
		_lblUnits_8.Text = "x";
		((Control)_lblUnits_8).Visible = false;
		((Control)_lblV_8).BackColor = SystemColors.Control;
		((Control)_lblV_8).Cursor = Cursors.Default;
		((Control)_lblV_8).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblV_8).ForeColor = SystemColors.ControlText;
		Label lblV_17 = _lblV_8;
		location = new Point(288, 392);
		((Control)lblV_17).Location = location;
		((Control)_lblV_8).Name = "_lblV_8";
		((Control)_lblV_8).RightToLeft = (RightToLeft)0;
		Label lblV_18 = _lblV_8;
		size = new Size(153, 17);
		((Control)lblV_18).Size = size;
		((Control)_lblV_8).TabIndex = 52;
		_lblV_8.Text = "x";
		((Control)_lblV_8).Visible = false;
		((Control)_lblVC_8).BackColor = SystemColors.Control;
		((Control)_lblVC_8).Cursor = Cursors.Default;
		((Control)_lblVC_8).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblVC_8).ForeColor = SystemColors.ControlText;
		Label lblVC_17 = _lblVC_8;
		location = new Point(128, 392);
		((Control)lblVC_17).Location = location;
		((Control)_lblVC_8).Name = "_lblVC_8";
		((Control)_lblVC_8).RightToLeft = (RightToLeft)0;
		Label lblVC_18 = _lblVC_8;
		size = new Size(145, 17);
		((Control)lblVC_18).Size = size;
		((Control)_lblVC_8).TabIndex = 51;
		_lblVC_8.Text = "x";
		((Control)_lblVC_8).Visible = false;
		((Control)_Line2_8).BackColor = SystemColors.WindowText;
		Label line2_17 = _Line2_8;
		location = new Point(8, 416);
		((Control)line2_17).Location = location;
		((Control)_Line2_8).Name = "_Line2_8";
		Label line2_18 = _Line2_8;
		size = new Size(624, 1);
		((Control)line2_18).Size = size;
		((Control)_Line2_8).TabIndex = 54;
		((Control)_Line2_8).Visible = false;
		((ButtonBase)_optType_9).BackColor = SystemColors.Control;
		((Control)_optType_9).Cursor = Cursors.Default;
		((Control)_optType_9).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optType_9).ForeColor = SystemColors.ControlText;
		RadioButton optType_19 = _optType_9;
		location = new Point(16, 431);
		((Control)optType_19).Location = location;
		((Control)_optType_9).Name = "_optType_9";
		((Control)_optType_9).RightToLeft = (RightToLeft)0;
		RadioButton optType_20 = _optType_9;
		size = new Size(89, 17);
		((Control)optType_20).Size = size;
		((Control)_optType_9).TabIndex = 55;
		_optType_9.TabStop = true;
		((ButtonBase)_optType_9).Text = "Non-default";
		((ButtonBase)_optType_9).UseVisualStyleBackColor = false;
		((Control)_optType_9).Visible = false;
		((Control)_lblUnits_9).BackColor = SystemColors.Control;
		((Control)_lblUnits_9).Cursor = Cursors.Default;
		((Control)_lblUnits_9).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblUnits_9).ForeColor = SystemColors.ControlText;
		Label lblUnits_19 = _lblUnits_9;
		location = new Point(464, 431);
		((Control)lblUnits_19).Location = location;
		((Control)_lblUnits_9).Name = "_lblUnits_9";
		((Control)_lblUnits_9).RightToLeft = (RightToLeft)0;
		Label lblUnits_20 = _lblUnits_9;
		size = new Size(153, 17);
		((Control)lblUnits_20).Size = size;
		((Control)_lblUnits_9).TabIndex = 58;
		_lblUnits_9.Text = "x";
		((Control)_lblUnits_9).Visible = false;
		((Control)_lblV_9).BackColor = SystemColors.Control;
		((Control)_lblV_9).Cursor = Cursors.Default;
		((Control)_lblV_9).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblV_9).ForeColor = SystemColors.ControlText;
		Label lblV_19 = _lblV_9;
		location = new Point(288, 431);
		((Control)lblV_19).Location = location;
		((Control)_lblV_9).Name = "_lblV_9";
		((Control)_lblV_9).RightToLeft = (RightToLeft)0;
		Label lblV_20 = _lblV_9;
		size = new Size(153, 17);
		((Control)lblV_20).Size = size;
		((Control)_lblV_9).TabIndex = 57;
		_lblV_9.Text = "x";
		((Control)_lblV_9).Visible = false;
		((Control)_lblVC_9).BackColor = SystemColors.Control;
		((Control)_lblVC_9).Cursor = Cursors.Default;
		((Control)_lblVC_9).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblVC_9).ForeColor = SystemColors.ControlText;
		Label lblVC_19 = _lblVC_9;
		location = new Point(128, 431);
		((Control)lblVC_19).Location = location;
		((Control)_lblVC_9).Name = "_lblVC_9";
		((Control)_lblVC_9).RightToLeft = (RightToLeft)0;
		Label lblVC_20 = _lblVC_9;
		size = new Size(145, 17);
		((Control)lblVC_20).Size = size;
		((Control)_lblVC_9).TabIndex = 56;
		_lblVC_9.Text = "x";
		((Control)_lblVC_9).Visible = false;
		((Control)_Line2_9).BackColor = SystemColors.WindowText;
		Label line2_19 = _Line2_9;
		location = new Point(8, 455);
		((Control)line2_19).Location = location;
		((Control)_Line2_9).Name = "_Line2_9";
		Label line2_20 = _Line2_9;
		size = new Size(624, 1);
		((Control)line2_20).Size = size;
		((Control)_Line2_9).TabIndex = 59;
		((Control)_Line2_9).Visible = false;
		((ButtonBase)_optType_10).BackColor = SystemColors.Control;
		((Control)_optType_10).Cursor = Cursors.Default;
		((Control)_optType_10).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optType_10).ForeColor = SystemColors.ControlText;
		RadioButton optType_21 = _optType_10;
		location = new Point(16, 470);
		((Control)optType_21).Location = location;
		((Control)_optType_10).Name = "_optType_10";
		((Control)_optType_10).RightToLeft = (RightToLeft)0;
		RadioButton optType_22 = _optType_10;
		size = new Size(89, 17);
		((Control)optType_22).Size = size;
		((Control)_optType_10).TabIndex = 60;
		_optType_10.TabStop = true;
		((ButtonBase)_optType_10).Text = "Non-default";
		((ButtonBase)_optType_10).UseVisualStyleBackColor = false;
		((Control)_optType_10).Visible = false;
		((Control)_lblUnits_10).BackColor = SystemColors.Control;
		((Control)_lblUnits_10).Cursor = Cursors.Default;
		((Control)_lblUnits_10).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblUnits_10).ForeColor = SystemColors.ControlText;
		Label lblUnits_21 = _lblUnits_10;
		location = new Point(464, 470);
		((Control)lblUnits_21).Location = location;
		((Control)_lblUnits_10).Name = "_lblUnits_10";
		((Control)_lblUnits_10).RightToLeft = (RightToLeft)0;
		Label lblUnits_22 = _lblUnits_10;
		size = new Size(153, 17);
		((Control)lblUnits_22).Size = size;
		((Control)_lblUnits_10).TabIndex = 63;
		_lblUnits_10.Text = "x";
		((Control)_lblUnits_10).Visible = false;
		((Control)_lblV_10).BackColor = SystemColors.Control;
		((Control)_lblV_10).Cursor = Cursors.Default;
		((Control)_lblV_10).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblV_10).ForeColor = SystemColors.ControlText;
		Label lblV_21 = _lblV_10;
		location = new Point(288, 470);
		((Control)lblV_21).Location = location;
		((Control)_lblV_10).Name = "_lblV_10";
		((Control)_lblV_10).RightToLeft = (RightToLeft)0;
		Label lblV_22 = _lblV_10;
		size = new Size(153, 17);
		((Control)lblV_22).Size = size;
		((Control)_lblV_10).TabIndex = 62;
		_lblV_10.Text = "x";
		((Control)_lblV_10).Visible = false;
		((Control)_lblVC_10).BackColor = SystemColors.Control;
		((Control)_lblVC_10).Cursor = Cursors.Default;
		((Control)_lblVC_10).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblVC_10).ForeColor = SystemColors.ControlText;
		Label lblVC_21 = _lblVC_10;
		location = new Point(128, 470);
		((Control)lblVC_21).Location = location;
		((Control)_lblVC_10).Name = "_lblVC_10";
		((Control)_lblVC_10).RightToLeft = (RightToLeft)0;
		Label lblVC_22 = _lblVC_10;
		size = new Size(145, 17);
		((Control)lblVC_22).Size = size;
		((Control)_lblVC_10).TabIndex = 61;
		_lblVC_10.Text = "x";
		((Control)_lblVC_10).Visible = false;
		((Control)_Line2_10).BackColor = SystemColors.WindowText;
		Label line2_21 = _Line2_10;
		location = new Point(8, 494);
		((Control)line2_21).Location = location;
		((Control)_Line2_10).Name = "_Line2_10";
		Label line2_22 = _Line2_10;
		size = new Size(624, 1);
		((Control)line2_22).Size = size;
		((Control)_Line2_10).TabIndex = 64;
		((Control)_Line2_10).Visible = false;
		((Control)_lblV_11).BackColor = SystemColors.Control;
		((Control)_lblV_11).Cursor = Cursors.Default;
		((Control)_lblV_11).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblV_11).ForeColor = SystemColors.ControlText;
		Label lblV_23 = _lblV_11;
		location = new Point(288, 507);
		((Control)lblV_23).Location = location;
		((Control)_lblV_11).Name = "_lblV_11";
		((Control)_lblV_11).RightToLeft = (RightToLeft)0;
		Label lblV_24 = _lblV_11;
		size = new Size(153, 17);
		((Control)lblV_24).Size = size;
		((Control)_lblV_11).TabIndex = 67;
		_lblV_11.Text = "x";
		((Control)_lblV_11).Visible = false;
		((ButtonBase)_optType_11).BackColor = SystemColors.Control;
		((Control)_optType_11).Cursor = Cursors.Default;
		((Control)_optType_11).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optType_11).ForeColor = SystemColors.ControlText;
		RadioButton optType_23 = _optType_11;
		location = new Point(16, 507);
		((Control)optType_23).Location = location;
		((Control)_optType_11).Name = "_optType_11";
		((Control)_optType_11).RightToLeft = (RightToLeft)0;
		RadioButton optType_24 = _optType_11;
		size = new Size(89, 17);
		((Control)optType_24).Size = size;
		((Control)_optType_11).TabIndex = 65;
		_optType_11.TabStop = true;
		((ButtonBase)_optType_11).Text = "Non-default";
		((ButtonBase)_optType_11).UseVisualStyleBackColor = false;
		((Control)_optType_11).Visible = false;
		((Control)_lblUnits_11).BackColor = SystemColors.Control;
		((Control)_lblUnits_11).Cursor = Cursors.Default;
		((Control)_lblUnits_11).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblUnits_11).ForeColor = SystemColors.ControlText;
		Label lblUnits_23 = _lblUnits_11;
		location = new Point(464, 507);
		((Control)lblUnits_23).Location = location;
		((Control)_lblUnits_11).Name = "_lblUnits_11";
		((Control)_lblUnits_11).RightToLeft = (RightToLeft)0;
		Label lblUnits_24 = _lblUnits_11;
		size = new Size(153, 17);
		((Control)lblUnits_24).Size = size;
		((Control)_lblUnits_11).TabIndex = 68;
		_lblUnits_11.Text = "x";
		((Control)_lblUnits_11).Visible = false;
		((Control)_lblVC_11).BackColor = SystemColors.Control;
		((Control)_lblVC_11).Cursor = Cursors.Default;
		((Control)_lblVC_11).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblVC_11).ForeColor = SystemColors.ControlText;
		Label lblVC_23 = _lblVC_11;
		location = new Point(128, 507);
		((Control)lblVC_23).Location = location;
		((Control)_lblVC_11).Name = "_lblVC_11";
		((Control)_lblVC_11).RightToLeft = (RightToLeft)0;
		Label lblVC_24 = _lblVC_11;
		size = new Size(145, 17);
		((Control)lblVC_24).Size = size;
		((Control)_lblVC_11).TabIndex = 66;
		_lblVC_11.Text = "x";
		((Control)_lblVC_11).Visible = false;
		((Control)_Line2_11).BackColor = SystemColors.WindowText;
		Label line2_23 = _Line2_11;
		location = new Point(8, 531);
		((Control)line2_23).Location = location;
		((Control)_Line2_11).Name = "_Line2_11";
		Label line2_24 = _Line2_11;
		size = new Size(624, 1);
		((Control)line2_24).Size = size;
		((Control)_Line2_11).TabIndex = 69;
		((Control)_Line2_11).Visible = false;
		((Form)this).AcceptButton = (IButtonControl)(object)cmdClose;
		size = new Size(5, 13);
		((Form)this).AutoScaleBaseSize = size;
		((Form)this).BackColor = SystemColors.Control;
		((Form)this).CancelButton = (IButtonControl)(object)cmdCancel;
		size = new Size(639, 611);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)txtInput);
		((Control)this).Controls.Add((Control)(object)_lblV_11);
		((Control)this).Controls.Add((Control)(object)_optType_11);
		((Control)this).Controls.Add((Control)(object)_lblUnits_11);
		((Control)this).Controls.Add((Control)(object)_lblVC_11);
		((Control)this).Controls.Add((Control)(object)_Line2_11);
		((Control)this).Controls.Add((Control)(object)_lblV_10);
		((Control)this).Controls.Add((Control)(object)_optType_10);
		((Control)this).Controls.Add((Control)(object)_lblUnits_10);
		((Control)this).Controls.Add((Control)(object)_lblVC_10);
		((Control)this).Controls.Add((Control)(object)_Line2_10);
		((Control)this).Controls.Add((Control)(object)_optType_9);
		((Control)this).Controls.Add((Control)(object)_lblUnits_9);
		((Control)this).Controls.Add((Control)(object)_lblV_9);
		((Control)this).Controls.Add((Control)(object)_lblVC_9);
		((Control)this).Controls.Add((Control)(object)_Line2_9);
		((Control)this).Controls.Add((Control)(object)_optType_8);
		((Control)this).Controls.Add((Control)(object)_lblUnits_8);
		((Control)this).Controls.Add((Control)(object)_lblV_8);
		((Control)this).Controls.Add((Control)(object)_lblVC_8);
		((Control)this).Controls.Add((Control)(object)_Line2_8);
		((Control)this).Controls.Add((Control)(object)_optType_7);
		((Control)this).Controls.Add((Control)(object)_lblUnits_7);
		((Control)this).Controls.Add((Control)(object)_lblV_7);
		((Control)this).Controls.Add((Control)(object)_lblVC_7);
		((Control)this).Controls.Add((Control)(object)_Line2_7);
		((Control)this).Controls.Add((Control)(object)_optType_6);
		((Control)this).Controls.Add((Control)(object)_lblUnits_6);
		((Control)this).Controls.Add((Control)(object)_lblV_6);
		((Control)this).Controls.Add((Control)(object)_lblVC_6);
		((Control)this).Controls.Add((Control)(object)_Line2_6);
		((Control)this).Controls.Add((Control)(object)_optType_5);
		((Control)this).Controls.Add((Control)(object)_lblUnits_5);
		((Control)this).Controls.Add((Control)(object)_lblV_5);
		((Control)this).Controls.Add((Control)(object)_lblVC_5);
		((Control)this).Controls.Add((Control)(object)_Line2_5);
		((Control)this).Controls.Add((Control)(object)_optType_4);
		((Control)this).Controls.Add((Control)(object)_lblUnits_4);
		((Control)this).Controls.Add((Control)(object)_lblV_4);
		((Control)this).Controls.Add((Control)(object)_lblVC_4);
		((Control)this).Controls.Add((Control)(object)_Line2_4);
		((Control)this).Controls.Add((Control)(object)_optType_3);
		((Control)this).Controls.Add((Control)(object)_lblUnits_3);
		((Control)this).Controls.Add((Control)(object)_lblV_3);
		((Control)this).Controls.Add((Control)(object)_lblVC_3);
		((Control)this).Controls.Add((Control)(object)_Line2_3);
		((Control)this).Controls.Add((Control)(object)_optType_2);
		((Control)this).Controls.Add((Control)(object)_lblUnits_2);
		((Control)this).Controls.Add((Control)(object)_lblV_2);
		((Control)this).Controls.Add((Control)(object)_lblVC_2);
		((Control)this).Controls.Add((Control)(object)_Line2_2);
		((Control)this).Controls.Add((Control)(object)_optType_1);
		((Control)this).Controls.Add((Control)(object)_optType_0);
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)cmdClose);
		((Control)this).Controls.Add((Control)(object)_Line2_0);
		((Control)this).Controls.Add((Control)(object)_lblUnits_1);
		((Control)this).Controls.Add((Control)(object)_lblV_1);
		((Control)this).Controls.Add((Control)(object)_lblVC_1);
		((Control)this).Controls.Add((Control)(object)lblParm);
		((Control)this).Controls.Add((Control)(object)_Line2_1);
		((Control)this).Controls.Add((Control)(object)_lblUnits_0);
		((Control)this).Controls.Add((Control)(object)_lblVC_0);
		((Control)this).Controls.Add((Control)(object)_lblV_0);
		((Control)this).Controls.Add((Control)(object)_Line1_0);
		((Control)this).Controls.Add((Control)(object)_Label1_2);
		((Control)this).Controls.Add((Control)(object)_Label1_1);
		((Control)this).Controls.Add((Control)(object)_Label1_0);
		((Control)this).Controls.Add((Control)(object)_Label1_98);
		((Control)this).Controls.Add((Control)(object)_Label1_76);
		((Control)this).Controls.Add((Control)(object)lblInstructions);
		((Control)this).Cursor = Cursors.Default;
		((Control)this).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		location = new Point(250, 150);
		((Form)this).Location = location;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmMDUpdAmtFreq";
		((Control)this).RightToLeft = (RightToLeft)0;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "View/Update the Value Calculation of the selected Model Parameter ";
		((ISupportInitialize)Label1).EndInit();
		((ISupportInitialize)Line1).EndInit();
		((ISupportInitialize)Line2).EndInit();
		((ISupportInitialize)lblUnits).EndInit();
		((ISupportInitialize)lblV).EndInit();
		((ISupportInitialize)lblVC).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void cmdCancel_Click(object eventSender, EventArgs eventArgs)
	{
		((Form)this).Close();
	}

	private void cmdClose_Click(object eventSender, EventArgs eventArgs)
	{
		checked
		{
			iDualIndex *= 4;
			if (iCallerID == 0)
			{
				AxMSFlexGrid msfRelParms = frmMDUpdRelMod.DefInstance.msfRelParms;
				msfRelParms[msfRelParms.Row, iDualIndex + 2] = ((Control)this).Controls["_optType_" + Conversions.ToString(unchecked((int)iSelected))].Text;
				msfRelParms[msfRelParms.Row, iDualIndex + 3] = ((Control)this).Controls["_lblVC_" + Conversions.ToString(unchecked((int)iSelected))].Text;
				msfRelParms[msfRelParms.Row, iDualIndex + 4] = ((Control)this).Controls["_lblV_" + Conversions.ToString(unchecked((int)iSelected))].Text;
				msfRelParms[msfRelParms.Row, iDualIndex + 5] = Conversions.ToString(((Control)this).Controls["_lblVC_" + Conversions.ToString(unchecked((int)iSelected))].Tag);
				msfRelParms = null;
			}
			else
			{
				AxMSFlexGrid msfExpParms = frmMDUpdExpMod.DefInstance.msfExpParms;
				msfExpParms[msfExpParms.Row, iDualIndex + 2] = ((Control)this).Controls["_optType_" + Conversions.ToString(unchecked((int)iSelected))].Text;
				msfExpParms[msfExpParms.Row, iDualIndex + 3] = ((Control)this).Controls["_lblVC_" + Conversions.ToString(unchecked((int)iSelected))].Text;
				msfExpParms[msfExpParms.Row, iDualIndex + 4] = ((Control)this).Controls["_lblV_" + Conversions.ToString(unchecked((int)iSelected))].Text;
				msfExpParms[msfExpParms.Row, iDualIndex + 5] = Conversions.ToString(((Control)this).Controls["_lblVC_" + Conversions.ToString(unchecked((int)iSelected))].Tag);
				msfExpParms = null;
			}
			((Form)this).Close();
		}
	}

	private void frmMDUpdAmtFreq_Load(object eventSender, EventArgs eventArgs)
	{
		((Control)this).Top = 0;
	}

	public bool SetUp(ref short pModType, ref short pCallerID, ref short pActID, ref short pDualIndex, ref AxMSFlexGrid pMsfParms)
	{
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d30: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num = default(int);
		Recordset recordset = default(Recordset);
		int num2 = default(int);
		int num3 = default(int);
		short num4 = default(short);
		Command command = default(Command);
		short num6 = default(short);
		short myParmID = default(short);
		short pParmID = default(short);
		short pParmID2 = default(short);
		short num8 = default(short);
		float num9 = default(float);
		short num10 = default(short);
		short gblNumMetaNonDefaults = default(short);
		short num13 = default(short);
		short num16 = default(short);
		bool flag = default(bool);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				int num5;
				string Eobject;
				string Efunction;
				ErrObject val;
				int Enumber;
				ErrObject val2;
				string Edescription;
				bool Econtact;
				Guid clsid;
				Command command2;
				object RecordsAffected;
				object Parameters;
				Control obj;
				short pDS;
				short pParmID3;
				short num7;
				Control obj2;
				short pDS2;
				short pParmID4;
				short pActID2;
				short num11;
				short num14;
				short num15;
				short num17;
				short num12;
				switch (try0001_dispatch)
				{
				default:
					num = 1;
					clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
					recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					goto IL_0024;
				case 4705:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 2:
							break;
						case 1:
							goto IL_0f1f;
						default:
							goto end_IL_0001;
						}
						goto IL_0e8d;
					}
					IL_0df8:
					num = 193;
					((Control)this).Controls["_lblUnits_" + Conversions.ToString((int)num4)].Visible = false;
					goto IL_0e22;
					IL_0e22:
					num = 194;
					((Control)this).Controls["_Line2_" + Conversions.ToString((int)num4)].Visible = false;
					goto IL_0e4c;
					IL_0dce:
					num = 192;
					((Control)this).Controls["_lblV_" + Conversions.ToString((int)num4)].Visible = false;
					goto IL_0df8;
					IL_0f1f:
					num5 = num2 + 1;
					goto IL_0f23;
					IL_0e8d:
					num = 200;
					Eobject = ((Control)this).Name;
					Efunction = "Setup";
					val = Information.Err();
					Enumber = val.Number;
					val2 = Information.Err();
					Edescription = val2.Description;
					Econtact = true;
					Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
					val2.Description = Edescription;
					val.Number = Enumber;
					((Control)this).Name = Eobject;
					goto IL_0ef3;
					IL_0ef3:
					num = 201;
					ProjectData.ClearProjectError();
					if (num2 == 0)
					{
						throw ProjectData.CreateProjectError(-2146828268);
					}
					num5 = num2;
					goto IL_0f23;
					IL_0e4c:
					num = 195;
					num4 = checked((short)unchecked(num4 + 1));
					goto IL_0e5b;
					IL_0d40:
					num = 188;
					num4 = checked((short)unchecked(num4 + 1));
					goto IL_0d4f;
					IL_0f23:
					num2 = 0;
					switch (num5)
					{
					case 1:
						break;
					case 2:
						goto IL_0024;
					case 3:
						goto IL_0046;
					case 4:
						goto IL_004e;
					case 5:
						goto IL_005a;
					case 6:
						goto IL_0079;
					case 7:
						goto IL_0084;
					case 8:
						goto IL_00a3;
					case 9:
						goto IL_00ae;
					case 10:
						goto IL_00be;
					case 11:
						goto IL_00ce;
					case 12:
						goto IL_00da;
					case 13:
						goto IL_00fe;
					case 14:
						goto IL_0123;
					case 15:
						goto IL_014c;
					case 16:
						goto IL_016b;
					case 17:
						goto IL_0180;
					case 18:
						goto IL_0195;
					case 19:
						goto IL_01aa;
					case 20:
						goto IL_01bb;
					case 21:
						goto IL_01c5;
					case 23:
						goto IL_0236;
					case 24:
						goto IL_023b;
					case 22:
					case 25:
					case 26:
						goto IL_025e;
					case 27:
						goto IL_026a;
					case 29:
					case 30:
						goto IL_0277;
					case 31:
						goto IL_0292;
					case 33:
						goto IL_02a1;
					case 34:
						goto IL_02bc;
					case 36:
						goto IL_02c8;
					case 37:
						goto IL_02fb;
					case 39:
						goto IL_0307;
					case 40:
						goto IL_0318;
					case 28:
					case 32:
					case 35:
					case 38:
					case 41:
					case 42:
						goto IL_0323;
					case 43:
						goto IL_032a;
					case 45:
					case 46:
						goto IL_0333;
					case 47:
						goto IL_0347;
					case 49:
						goto IL_0358;
					case 50:
						goto IL_036c;
					case 52:
						goto IL_037d;
					case 53:
						goto IL_0391;
					case 55:
						goto IL_03a2;
					case 56:
						goto IL_03b6;
					case 58:
						goto IL_03c7;
					case 59:
						goto IL_03db;
					case 61:
						goto IL_03ec;
					case 62:
						goto IL_0400;
					case 64:
						goto IL_0411;
					case 65:
						goto IL_0425;
					case 66:
						goto IL_0433;
					case 67:
						goto IL_0449;
					case 69:
						goto IL_0453;
					case 70:
						goto IL_0458;
					case 73:
						goto IL_0472;
					case 74:
						goto IL_0486;
					case 76:
						goto IL_0497;
					case 77:
						goto IL_04ab;
					case 79:
						goto IL_04bc;
					case 80:
						goto IL_04d0;
					case 82:
						goto IL_04e1;
					case 83:
						goto IL_04f5;
					case 85:
						goto IL_0506;
					case 86:
						goto IL_051a;
					case 88:
						goto IL_052b;
					case 89:
						goto IL_053f;
					case 90:
						goto IL_054b;
					case 91:
						goto IL_055a;
					case 92:
						goto IL_0563;
					case 94:
						goto IL_056d;
					case 95:
						goto IL_0572;
					case 98:
						goto IL_0585;
					case 99:
						goto IL_0599;
					case 100:
						goto IL_05a5;
					case 101:
						goto IL_05b4;
					case 103:
						goto IL_05bd;
					case 104:
						goto IL_05c2;
					case 107:
						goto IL_05d5;
					case 108:
						goto IL_05e9;
					case 109:
						goto IL_0603;
					case 110:
						goto IL_0612;
					case 111:
						goto IL_061b;
					case 113:
						goto IL_0625;
					case 114:
						goto IL_062a;
					case 117:
						goto IL_063d;
					case 118:
						goto IL_0651;
					case 120:
						goto IL_0662;
					case 121:
						goto IL_0676;
					case 123:
						goto IL_0689;
					case 124:
						goto IL_069d;
					case 126:
						goto IL_06ab;
					case 127:
						goto IL_06bf;
					case 129:
						goto IL_06d1;
					case 130:
						goto IL_06e8;
					case 132:
					case 133:
						goto IL_06fa;
					case 44:
					case 48:
					case 51:
					case 54:
					case 57:
					case 60:
					case 63:
					case 68:
					case 71:
					case 72:
					case 75:
					case 78:
					case 81:
					case 84:
					case 87:
					case 93:
					case 96:
					case 97:
					case 102:
					case 105:
					case 106:
					case 112:
					case 115:
					case 116:
					case 119:
					case 122:
					case 125:
					case 128:
					case 131:
					case 134:
					case 135:
						goto IL_0706;
					case 137:
					case 138:
						goto IL_0712;
					case 140:
						goto IL_072e;
					case 141:
						goto IL_0742;
					case 142:
						goto IL_0764;
					case 143:
						goto IL_078d;
					case 145:
					case 146:
						goto IL_07bc;
					case 147:
						goto IL_07e0;
					case 148:
						goto IL_0823;
					case 136:
					case 139:
					case 144:
					case 149:
					case 150:
						goto IL_0849;
					case 151:
						goto IL_086d;
					case 152:
						goto IL_0883;
					case 153:
						goto IL_089b;
					case 154:
						goto IL_08b1;
					case 155:
					case 156:
						goto IL_08c2;
					case 157:
						goto IL_08f0;
					case 158:
						goto IL_0920;
					case 159:
						goto IL_096f;
					case 160:
						goto IL_09a0;
					case 161:
						goto IL_09d0;
					case 162:
						goto IL_09ec;
					case 163:
						goto IL_0a08;
					case 164:
						goto IL_0a18;
					case 165:
						goto IL_0a46;
					case 166:
						goto IL_0a55;
					case 167:
						goto IL_0a83;
					case 168:
						goto IL_0ab7;
					case 169:
						goto IL_0acf;
					case 170:
						goto IL_0b04;
					case 172:
						goto IL_0b3c;
					case 173:
						goto IL_0b44;
					case 174:
						goto IL_0b52;
					case 175:
						goto IL_0b6a;
					case 176:
						goto IL_0b8c;
					case 177:
						goto IL_0bb5;
					case 171:
					case 178:
					case 179:
						goto IL_0bdd;
					case 180:
						goto IL_0bf6;
					case 181:
						goto IL_0c5f;
					case 182:
						goto IL_0c9b;
					case 183:
					case 184:
						goto IL_0cde;
					case 185:
						goto IL_0d0d;
					case 187:
					case 188:
						goto IL_0d40;
					case 186:
					case 189:
						goto IL_0d5c;
					case 190:
						goto IL_0d7a;
					case 191:
						goto IL_0da4;
					case 192:
						goto IL_0dce;
					case 193:
						goto IL_0df8;
					case 194:
						goto IL_0e22;
					case 195:
						goto IL_0e4c;
					case 196:
						goto IL_0e68;
					case 197:
						goto IL_0e72;
					case 198:
						goto IL_0e7b;
					case 200:
						goto IL_0e8d;
					case 201:
						goto IL_0ef3;
					default:
						goto end_IL_0001;
					case 199:
					case 202:
					case 203:
					case 204:
						goto end_IL_0001_2;
					}
					goto default;
					IL_0024:
					num = 2;
					clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
					command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					goto IL_0046;
					IL_0046:
					ProjectData.ClearProjectError();
					num3 = 2;
					goto IL_004e;
					IL_004e:
					num = 4;
					iDualIndex = pDualIndex;
					goto IL_005a;
					IL_005a:
					num = 5;
					MyParmID = Conversions.ToShort(pMsfParms[pMsfParms.Row, 0]);
					goto IL_0079;
					IL_0079:
					num = 6;
					MyModelType = pModType;
					goto IL_0084;
					IL_0084:
					num = 7;
					lblParm.Text = ChemStrX.GetParmLabels(ref Globals_Renamed.intOpIndex, ref MyParmID);
					goto IL_00a3;
					IL_00a3:
					num = 8;
					iCallerID = pCallerID;
					goto IL_00ae;
					IL_00ae:
					num = 9;
					command.ActiveConnection = Common.MyConn;
					goto IL_00be;
					IL_00be:
					num = 10;
					command.CommandText = "pqryGetParmDefault";
					goto IL_00ce;
					IL_00ce:
					num = 11;
					command.CommandType = CommandTypeEnum.adCmdStoredProc;
					goto IL_00da;
					IL_00da:
					num = 12;
					command.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, 0));
					goto IL_00fe;
					IL_00fe:
					num = 13;
					command.Parameters.Append(command.CreateParameter("pModelID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, pModType));
					goto IL_0123;
					IL_0123:
					num = 14;
					command.Parameters.Append(command.CreateParameter("pParmID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, MyParmID));
					goto IL_014c;
					IL_014c:
					num = 15;
					command2 = command;
					RecordsAffected = Missing.Value;
					Parameters = Missing.Value;
					recordset = command2.Execute(out RecordsAffected, ref Parameters);
					goto IL_016b;
					IL_016b:
					num = 16;
					command.Parameters.Delete("pActID");
					goto IL_0180;
					IL_0180:
					num = 17;
					command.Parameters.Delete("pModelID");
					goto IL_0195;
					IL_0195:
					num = 18;
					command.Parameters.Delete("pParmID");
					goto IL_01aa;
					IL_01aa:
					num = 19;
					if (recordset.EOF)
					{
						goto IL_01bb;
					}
					goto IL_0236;
					IL_01bb:
					num = 20;
					Interaction.Beep();
					goto IL_01c5;
					IL_01c5:
					num = 21;
					Interaction.MsgBox((object)("Database error in " + ((Control)this).Name + ", missing ParmDefault for ParmID " + Conversions.ToString((int)MyParmID) + " and ModelID " + Conversions.ToString((int)pModType) + ". Please contact technical support."), (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
					goto IL_025e;
					IL_0236:
					num = 23;
					goto IL_023b;
					IL_023b:
					num = 24;
					num6 = Conversions.ToShort(recordset.Fields[0].Value);
					goto IL_025e;
					IL_025e:
					num = 26;
					recordset.Close();
					goto IL_026a;
					IL_026a:
					num = 27;
					myParmID = MyParmID;
					goto IL_0277;
					IL_0277:
					num = 30;
					if (myParmID == 92 || myParmID == 61)
					{
						goto IL_0292;
					}
					goto IL_02a1;
					IL_0883:
					num = 152;
					pParmID = Conversions.ToShort(Globals_Renamed.gblMetaNonDefaults[checked(num4 - 1)]);
					goto IL_089b;
					IL_089b:
					num = 153;
					if (pParmID != pParmID2)
					{
						goto IL_08b1;
					}
					goto IL_08c2;
					IL_02a1:
					num = 33;
					if (myParmID == 72 || myParmID == 75)
					{
						goto IL_02bc;
					}
					goto IL_02c8;
					IL_08b1:
					num = 154;
					MakeUmVisible(num4);
					goto IL_08c2;
					IL_08c2:
					num = 156;
					((Control)this).Controls["_optType_" + Conversions.ToString((int)num4)].Text = "Non-default";
					goto IL_08f0;
					IL_02c8:
					num = 36;
					if ((myParmID == 9 || myParmID == 76 || myParmID == 77 || myParmID == 78 || myParmID == 59) ? true : false)
					{
						goto IL_02fb;
					}
					goto IL_0307;
					IL_0920:
					num = 158;
					obj = ((Control)this).Controls["_lblV_" + Conversions.ToString((int)num4)];
					pDS = Globals_Renamed.arParmDS[pParmID];
					pParmID3 = pParmID;
					pActID2 = 0;
					obj.Text = ChemStrX.ShowInSciNot(ChemStrX.GetModelDefault(pDS, pParmID3, ref pModType, ref pActID2, ref Globals_Renamed.intModIndex, ref pDualIndex));
					goto IL_096f;
					IL_096f:
					num = 159;
					((Control)this).Controls["_lblUnits_" + Conversions.ToString((int)num4)].Text = Globals_Renamed.arParmUnits[pParmID];
					goto IL_09a0;
					IL_09a0:
					num = 160;
					((Control)this).Controls["_lblVC_" + Conversions.ToString((int)num4)].Tag = pParmID;
					goto IL_09d0;
					IL_09d0:
					num = 161;
					num4 = checked((short)unchecked(num4 + 1));
					goto IL_09df;
					IL_08f0:
					num = 157;
					((Control)this).Controls["_lblVC_" + Conversions.ToString((int)num4)].Text = ChemStrX.GetParmAcronym(ref pParmID);
					goto IL_0920;
					IL_02fb:
					num = 37;
					num7 = 142;
					goto IL_0323;
					IL_0307:
					num = 39;
					if (myParmID == 40)
					{
						goto IL_0318;
					}
					goto IL_0323;
					IL_0318:
					num = 40;
					num7 = 143;
					goto IL_0323;
					IL_02bc:
					num = 34;
					num7 = 141;
					goto IL_0323;
					IL_0292:
					num = 31;
					num7 = 140;
					goto IL_0323;
					IL_0323:
					num = 42;
					num4 = 0;
					goto IL_032a;
					IL_032a:
					num = 43;
					num8 = num6;
					goto IL_0333;
					IL_0333:
					num = 46;
					if (num8 == -1101)
					{
						goto IL_0347;
					}
					goto IL_0358;
					IL_0347:
					num = 47;
					pParmID2 = GetParmDefaults.GetParmDefault1101(ref pActID);
					goto IL_0706;
					IL_0358:
					num = 49;
					if (num8 == -1102)
					{
						goto IL_036c;
					}
					goto IL_037d;
					IL_036c:
					num = 50;
					pParmID2 = GetParmDefaults.GetParmDefault1102(ref pActID);
					goto IL_0706;
					IL_037d:
					num = 52;
					if (num8 == -1104)
					{
						goto IL_0391;
					}
					goto IL_03a2;
					IL_0391:
					num = 53;
					pParmID2 = GetParmDefaults.GetParmDefault1104(ref pActID);
					goto IL_0706;
					IL_03a2:
					num = 55;
					if (num8 == -1105)
					{
						goto IL_03b6;
					}
					goto IL_03c7;
					IL_03b6:
					num = 56;
					pParmID2 = GetParmDefaults.GetParmDefault1105(ref pActID);
					goto IL_0706;
					IL_03c7:
					num = 58;
					if (num8 == -1106)
					{
						goto IL_03db;
					}
					goto IL_03ec;
					IL_03db:
					num = 59;
					pParmID2 = GetParmDefaults.GetParmDefault1106(ref pActID);
					goto IL_0706;
					IL_03ec:
					num = 61;
					if (num8 == -1109)
					{
						goto IL_0400;
					}
					goto IL_0411;
					IL_0400:
					num = 62;
					pParmID2 = GetParmDefaults.GetParmDefault1109(ref pActID);
					goto IL_0706;
					IL_0411:
					num = 64;
					if (num8 == -1111)
					{
						goto IL_0425;
					}
					goto IL_0472;
					IL_0425:
					num = 65;
					num9 = GetParmDefaults.GetParmDefault1111(ref pActID, ref pDualIndex);
					goto IL_0433;
					IL_0433:
					num = 66;
					if (num9 >= 0f)
					{
						goto IL_0449;
					}
					goto IL_0453;
					IL_0449:
					num = 67;
					pParmID2 = -123;
					goto IL_0706;
					IL_0453:
					num = 69;
					goto IL_0458;
					IL_0458:
					num = 70;
					pParmID2 = checked((short)Math.Round(Math.Abs(num9)));
					goto IL_0706;
					IL_0472:
					num = 73;
					if (num8 == -1112)
					{
						goto IL_0486;
					}
					goto IL_0497;
					IL_0486:
					num = 74;
					pParmID2 = GetParmDefaults.GetParmDefault1112(ref pActID);
					goto IL_0706;
					IL_0497:
					num = 76;
					if (num8 == -1114)
					{
						goto IL_04ab;
					}
					goto IL_04bc;
					IL_04ab:
					num = 77;
					pParmID2 = GetParmDefaults.GetParmDefault1114(ref pActID);
					goto IL_0706;
					IL_04bc:
					num = 79;
					if (num8 == -1115)
					{
						goto IL_04d0;
					}
					goto IL_04e1;
					IL_04d0:
					num = 80;
					pParmID2 = GetParmDefaults.GetParmDefault1115(ref pActID);
					goto IL_0706;
					IL_04e1:
					num = 82;
					if (num8 == -2101)
					{
						goto IL_04f5;
					}
					goto IL_0506;
					IL_04f5:
					num = 83;
					pParmID2 = GetParmDefaults.GetParmDefault2101(ref pActID);
					goto IL_0706;
					IL_0506:
					num = 85;
					if (num8 == -2102)
					{
						goto IL_051a;
					}
					goto IL_052b;
					IL_051a:
					num = 86;
					pParmID2 = GetParmDefaults.GetParmDefault2102(ref pActID);
					goto IL_0706;
					IL_052b:
					num = 88;
					if (num8 == -2103)
					{
						goto IL_053f;
					}
					goto IL_0585;
					IL_053f:
					num = 89;
					pParmID2 = GetParmDefaults.GetParmDefault2103(ref pActID);
					goto IL_054b;
					IL_054b:
					num = 90;
					if (pParmID2 > 0)
					{
						goto IL_055a;
					}
					goto IL_056d;
					IL_055a:
					num = 91;
					num9 = pParmID2;
					goto IL_0563;
					IL_0563:
					num = 92;
					pParmID2 = -123;
					goto IL_0706;
					IL_056d:
					num = 94;
					goto IL_0572;
					IL_0572:
					num = 95;
					pParmID2 = Math.Abs(pParmID2);
					goto IL_0706;
					IL_0585:
					num = 98;
					if (num8 == -2104)
					{
						goto IL_0599;
					}
					goto IL_05d5;
					IL_0599:
					num = 99;
					pParmID2 = GetParmDefaults.GetParmDefault2104(ref pActID);
					goto IL_05a5;
					IL_05a5:
					num = 100;
					if (pParmID2 > 0)
					{
						goto IL_05b4;
					}
					goto IL_05bd;
					IL_05b4:
					num = 101;
					pParmID2 = 0;
					goto IL_0706;
					IL_05bd:
					num = 103;
					goto IL_05c2;
					IL_05c2:
					num = 104;
					pParmID2 = Math.Abs(pParmID2);
					goto IL_0706;
					IL_05d5:
					num = 107;
					if (num8 == -2105)
					{
						goto IL_05e9;
					}
					goto IL_063d;
					IL_05e9:
					num = 108;
					pActID2 = -1;
					pParmID2 = checked((short)Math.Round(GetParmDefaults.GetParmDefault2105(ref pActID, ref pActID2, ref pDualIndex)));
					goto IL_0603;
					IL_0603:
					num = 109;
					if (pParmID2 > 0)
					{
						goto IL_0612;
					}
					goto IL_0625;
					IL_0612:
					num = 110;
					num9 = pParmID2;
					goto IL_061b;
					IL_061b:
					num = 111;
					pParmID2 = -123;
					goto IL_0706;
					IL_0625:
					num = 113;
					goto IL_062a;
					IL_062a:
					num = 114;
					pParmID2 = Math.Abs(pParmID2);
					goto IL_0706;
					IL_063d:
					num = 117;
					if (num8 == -2106)
					{
						goto IL_0651;
					}
					goto IL_0662;
					IL_0651:
					num = 118;
					pParmID2 = GetParmDefaults.GetParmDefault2106(ref pActID);
					goto IL_0706;
					IL_0662:
					num = 120;
					if (num8 == -2107)
					{
						goto IL_0676;
					}
					goto IL_0689;
					IL_0676:
					num = 121;
					pParmID2 = Math.Abs(GetParmDefaults.GetParmDefault2107(ref pActID));
					goto IL_0706;
					IL_0689:
					num = 123;
					if (num8 == -2108)
					{
						goto IL_069d;
					}
					goto IL_06ab;
					IL_069d:
					num = 124;
					pParmID2 = GetParmDefaults.GetParmDefault2108(ref pActID);
					goto IL_0706;
					IL_06ab:
					num = 126;
					if (num8 == -2110)
					{
						goto IL_06bf;
					}
					goto IL_06d1;
					IL_06bf:
					num = 127;
					pParmID2 = Math.Abs(GetParmDefaults.GetParmDefault2110());
					goto IL_0706;
					IL_06d1:
					num = 129;
					if (num8 == -2111)
					{
						goto IL_06e8;
					}
					goto IL_06fa;
					IL_06e8:
					num = 130;
					pParmID2 = GetParmDefaults.GetParmDefault2111(ref pActID);
					goto IL_0706;
					IL_06fa:
					num = 133;
					pParmID2 = num6;
					goto IL_0706;
					IL_0706:
					num = 135;
					num10 = pParmID2;
					goto IL_0712;
					IL_0712:
					num = 138;
					if (num10 != 999)
					{
						goto IL_072e;
					}
					goto IL_0849;
					IL_072e:
					num = 140;
					if (num10 == -123)
					{
						goto IL_0742;
					}
					goto IL_07bc;
					IL_0742:
					num = 141;
					((Control)this).Controls["_lblVC_0"].Text = "Linked";
					goto IL_0764;
					IL_0764:
					num = 142;
					((Control)this).Controls["_lblV_0"].Text = ChemStrX.ShowInSciNot(num9);
					goto IL_078d;
					IL_078d:
					num = 143;
					((Control)this).Controls["_lblUnits_0"].Text = Globals_Renamed.arParmUnits[MyParmID];
					goto IL_0849;
					IL_07bc:
					num = 146;
					((Control)this).Controls["_lblVC_0"].Text = ChemStrX.GetParmAcronym(ref pParmID2);
					goto IL_07e0;
					IL_07e0:
					num = 147;
					obj2 = ((Control)this).Controls["_lblV_0"];
					pDS2 = Globals_Renamed.arParmDS[pParmID2];
					pParmID4 = pParmID2;
					pActID2 = 0;
					obj2.Text = ChemStrX.ShowInSciNot(ChemStrX.GetModelDefault(pDS2, pParmID4, ref pModType, ref pActID2, ref pDualIndex, ref Globals_Renamed.intModIndex));
					goto IL_0823;
					IL_0823:
					num = 148;
					((Control)this).Controls["_lblUnits_0"].Text = Globals_Renamed.arParmUnits[pParmID2];
					goto IL_0849;
					IL_0849:
					num = 150;
					((Control)this).Controls["_lblVC_0"].Tag = pParmID2;
					goto IL_086d;
					IL_086d:
					num = 151;
					gblNumMetaNonDefaults = Globals_Renamed.gblNumMetaNonDefaults;
					num4 = 1;
					goto IL_09df;
					IL_09df:
					num11 = num4;
					num12 = gblNumMetaNonDefaults;
					if (num11 <= num12)
					{
						goto IL_0883;
					}
					goto IL_09ec;
					IL_09ec:
					num = 162;
					if (pParmID2 != 999)
					{
						goto IL_0a08;
					}
					goto IL_0b3c;
					IL_0a08:
					num = 163;
					MakeUmVisible(num4);
					goto IL_0a18;
					IL_0a18:
					num = 164;
					((Control)this).Controls["_optType_" + Conversions.ToString((int)num4)].Text = "Non-default";
					goto IL_0a46;
					IL_0a46:
					num = 165;
					iUserDef = num4;
					goto IL_0a55;
					IL_0a55:
					num = 166;
					((Control)this).Controls["_lblVC_" + Conversions.ToString((int)num4)].Text = "User-defined";
					goto IL_0a83;
					IL_0a83:
					num = 167;
					((Control)txtInput).Top = ((Control)this).Controls["_lblV_" + Conversions.ToString((int)num4)].Top;
					goto IL_0ab7;
					IL_0ab7:
					num = 168;
					txtInput.Text = "0";
					goto IL_0acf;
					IL_0acf:
					num = 169;
					((Control)this).Controls["_lblUnits_" + Conversions.ToString((int)num4)].Text = Globals_Renamed.arParmUnits[MyParmID];
					goto IL_0b04;
					IL_0b04:
					num = 170;
					((Control)this).Controls["_lblVC_" + Conversions.ToString((int)num4)].Tag = (short)999;
					goto IL_0bdd;
					IL_0b3c:
					num = 172;
					goto IL_0b44;
					IL_0b44:
					num = 173;
					iUserDef = 0;
					goto IL_0b52;
					IL_0b52:
					num = 174;
					txtInput.Text = "0";
					goto IL_0b6a;
					IL_0b6a:
					num = 175;
					((Control)this).Controls["_lblVC_0"].Text = "User-defined";
					goto IL_0b8c;
					IL_0b8c:
					num = 176;
					((Control)this).Controls["_lblUnits_0"].Text = Globals_Renamed.arParmUnits[MyParmID];
					goto IL_0bb5;
					IL_0bb5:
					num = 177;
					((Control)this).Controls["_lblVC_0"].Tag = (short)999;
					goto IL_0bdd;
					IL_0bdd:
					num = 179;
					num13 = checked((short)(Globals_Renamed.gblNumMetaNonDefaults + 1));
					num4 = 0;
					goto IL_0d4f;
					IL_0d4f:
					num14 = num4;
					num12 = num13;
					if (num14 <= num12)
					{
						goto IL_0bf6;
					}
					goto IL_0d5c;
					IL_0bf6:
					num = 180;
					if (Operators.CompareString(((Control)this).Controls["_lblVC_" + Conversions.ToString((int)num4)].Text, pMsfParms[pMsfParms.Row, Conversions.ToInteger(Interaction.IIf(iDualIndex == 0, (object)3, (object)7))], false) == 0)
					{
						goto IL_0c5f;
					}
					goto IL_0d40;
					IL_0c5f:
					num = 181;
					if (Operators.CompareString(((Control)this).Controls["_lblVC_" + Conversions.ToString((int)num4)].Text, "User-defined", false) == 0)
					{
						goto IL_0c9b;
					}
					goto IL_0cde;
					IL_0c9b:
					num = 182;
					txtInput.Text = pMsfParms[pMsfParms.Row, Conversions.ToInteger(Interaction.IIf(iDualIndex == 0, (object)4, (object)8))];
					goto IL_0cde;
					IL_0cde:
					num = 184;
					((RadioButton)((Control)this).Controls["_optType_" + Conversions.ToString((int)num4)]).Checked = false;
					goto IL_0d0d;
					IL_0d0d:
					num = 185;
					((RadioButton)((Control)this).Controls["_optType_" + Conversions.ToString((int)num4)]).Checked = true;
					goto IL_0d5c;
					IL_0d5c:
					num = 189;
					num15 = checked((short)(Globals_Renamed.gblNumMetaNonDefaults + 2));
					num16 = myMaxRows;
					num4 = num15;
					goto IL_0e5b;
					IL_0e5b:
					num17 = num4;
					num12 = num16;
					if (num17 <= num12)
					{
						goto IL_0d7a;
					}
					goto IL_0e68;
					IL_0e68:
					num = 196;
					recordset = null;
					goto IL_0e72;
					IL_0e72:
					num = 197;
					command = null;
					goto IL_0e7b;
					IL_0e7b:
					num = 198;
					flag = true;
					goto end_IL_0001_2;
					IL_0d7a:
					num = 190;
					((Control)this).Controls["_optType_" + Conversions.ToString((int)num4)].Visible = false;
					goto IL_0da4;
					IL_0da4:
					num = 191;
					((Control)this).Controls["_lblVC_" + Conversions.ToString((int)num4)].Visible = false;
					goto IL_0dce;
					end_IL_0001:
					break;
				}
			}
			catch (object obj3) when (obj3 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj3);
				try0001_dispatch = 4705;
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

	private void MakeUmVisible(short x)
	{
		((Control)this).Controls["_optType_" + Conversions.ToString((int)x)].Visible = true;
		((Control)this).Controls["_lblVC_" + Conversions.ToString((int)x)].Visible = true;
		((Control)this).Controls["_lblV_" + Conversions.ToString((int)x)].Visible = true;
		((Control)this).Controls["_lblUnits_" + Conversions.ToString((int)x)].Visible = true;
		((Control)this).Controls["_Line2_" + Conversions.ToString((int)x)].Visible = true;
	}

	private void optType_CheckedChanged(object eventSender, EventArgs eventArgs)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		if (!((RadioButton)eventSender).Checked)
		{
			return;
		}
		short num = Conversions.ToShort(Strings.Mid(Conversions.ToString(NewLateBinding.LateGet(eventSender, (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null)), 10));
		if (((MyParmID == 72) | (MyParmID == 75)) && Versioned.IsNumeric((object)((Control)this).Controls["_lblV_" + Conversions.ToString((int)num)].Text) && Conversions.ToDouble(((Control)this).Controls["_lblV_" + Conversions.ToString((int)num)].Text) > 0.0)
		{
			ref short myParmID = ref MyParmID;
			Control val = ((Control)this).Controls["_lblV_" + Conversions.ToString((int)num)];
			object pValue = val.Text;
			short pModType = 0;
			bool num2 = ChemStrX.ValidateParmInput(ref myParmID, ref pValue, ref pModType);
			val.Text = Conversions.ToString(pValue);
			if (!num2)
			{
				((Control)cmdClose).Enabled = false;
				return;
			}
		}
		((Control)cmdClose).Enabled = true;
		iSelected = num;
		if (num == iUserDef)
		{
			((Control)txtInput).Visible = true;
			((Control)this).Controls["_lblV_" + Conversions.ToString((int)iUserDef)].Text = txtInput.Text;
		}
		else
		{
			((Control)txtInput).Visible = false;
			((Control)this).Controls["_lblV_" + Conversions.ToString((int)iUserDef)].Text = "0";
		}
	}

	private object ValidateTxtInput()
	{
		ref short myParmID = ref MyParmID;
		TextBox val = txtInput;
		object pValue = val.Text;
		bool num = ChemStrX.ValidateParmInput(ref myParmID, ref pValue, ref MyModelType);
		val.Text = Conversions.ToString(pValue);
		if (!num)
		{
			((TextBoxBase)txtInput).SelectionStart = 0;
			((TextBoxBase)txtInput).SelectionLength = Strings.Len(txtInput.Text);
			((Control)txtInput).Focus();
			object result = default(object);
			return result;
		}
		return true;
	}

	private void txtInput_TextChanged(object eventSender, EventArgs eventArgs)
	{
		if (((Control)txtInput).Visible && Strings.Len(txtInput.Text) > 0 && (Versioned.IsNumeric((object)txtInput.Text) & ((Operators.CompareString(txtInput.Text, "0", false) != 0) & (Operators.CompareString(txtInput.Text, "0.", false) != 0))))
		{
			ValidateTxtInput();
		}
		((Control)this).Controls["_lblV_" + Conversions.ToString((int)iUserDef)].Text = txtInput.Text;
	}

	private void txtInput_Enter(object eventSender, EventArgs eventArgs)
	{
		((TextBoxBase)txtInput).SelectionStart = 0;
		((TextBoxBase)txtInput).SelectionLength = Strings.Len(txtInput.Text);
	}

	private void txtInput_Leave(object eventSender, EventArgs eventArgs)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		if (Strings.Len(txtInput.Text) == 0)
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Invalid number. All user specified parameters must be greater than zero.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
			((TextBoxBase)txtInput).SelectionStart = 0;
			((TextBoxBase)txtInput).SelectionLength = Strings.Len(txtInput.Text);
			((Control)txtInput).Focus();
		}
		else if (!Versioned.IsNumeric((object)txtInput.Text))
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Invalid number. All user specified parameters must be numeric values greater than or equal to zero.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
			((TextBoxBase)txtInput).SelectionStart = 0;
			((TextBoxBase)txtInput).SelectionLength = Strings.Len(txtInput.Text);
			((Control)txtInput).Focus();
		}
		else if (Conversions.ToBoolean(ValidateTxtInput()))
		{
			((Control)txtInput).Visible = false;
		}
	}
}
