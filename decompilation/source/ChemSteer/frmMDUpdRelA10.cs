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

internal class frmMDUpdRelA10 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("txtInput")]
	private TextBox _txtInput;

	[AccessedThroughProperty("_optType_10")]
	private RadioButton __optType_10;

	[AccessedThroughProperty("_optType_0")]
	private RadioButton __optType_0;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("cmdClose")]
	private Button _cmdClose;

	[AccessedThroughProperty("_Line2_0")]
	private Label __Line2_0;

	[AccessedThroughProperty("_lblUnits_10")]
	private Label __lblUnits_10;

	[AccessedThroughProperty("_lblV_10")]
	private Label __lblV_10;

	[AccessedThroughProperty("_lblVC_10")]
	private Label __lblVC_10;

	[AccessedThroughProperty("lblParm")]
	private Label _lblParm;

	[AccessedThroughProperty("_Line2_10")]
	private Label __Line2_10;

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

	[AccessedThroughProperty("_optType_1")]
	private RadioButton __optType_1;

	[AccessedThroughProperty("_Line2_1")]
	private Label __Line2_1;

	[AccessedThroughProperty("_lblUnits_1")]
	private Label __lblUnits_1;

	[AccessedThroughProperty("_lblVC_1")]
	private Label __lblVC_1;

	[AccessedThroughProperty("_lblV_1")]
	private Label __lblV_1;

	[AccessedThroughProperty("_optType_3")]
	private RadioButton __optType_3;

	[AccessedThroughProperty("_Line2_3")]
	private Label __Line2_3;

	[AccessedThroughProperty("_lblUnits_3")]
	private Label __lblUnits_3;

	[AccessedThroughProperty("_lblVC_3")]
	private Label __lblVC_3;

	[AccessedThroughProperty("_lblV_3")]
	private Label __lblV_3;

	[AccessedThroughProperty("_optType_2")]
	private RadioButton __optType_2;

	[AccessedThroughProperty("_Line2_2")]
	private Label __Line2_2;

	[AccessedThroughProperty("_lblUnits_2")]
	private Label __lblUnits_2;

	[AccessedThroughProperty("_lblVC_2")]
	private Label __lblVC_2;

	[AccessedThroughProperty("_lblV_2")]
	private Label __lblV_2;

	[AccessedThroughProperty("_optType_7")]
	private RadioButton __optType_7;

	[AccessedThroughProperty("_Line2_7")]
	private Label __Line2_7;

	[AccessedThroughProperty("_lblUnits_7")]
	private Label __lblUnits_7;

	[AccessedThroughProperty("_lblVC_7")]
	private Label __lblVC_7;

	[AccessedThroughProperty("_lblV_7")]
	private Label __lblV_7;

	[AccessedThroughProperty("_optType_6")]
	private RadioButton __optType_6;

	[AccessedThroughProperty("_Line2_6")]
	private Label __Line2_6;

	[AccessedThroughProperty("_lblUnits_6")]
	private Label __lblUnits_6;

	[AccessedThroughProperty("_lblVC_6")]
	private Label __lblVC_6;

	[AccessedThroughProperty("_lblV_6")]
	private Label __lblV_6;

	[AccessedThroughProperty("_optType_5")]
	private RadioButton __optType_5;

	[AccessedThroughProperty("_Line2_5")]
	private Label __Line2_5;

	[AccessedThroughProperty("_lblUnits_5")]
	private Label __lblUnits_5;

	[AccessedThroughProperty("_lblVC_5")]
	private Label __lblVC_5;

	[AccessedThroughProperty("_lblV_5")]
	private Label __lblV_5;

	[AccessedThroughProperty("_optType_4")]
	private RadioButton __optType_4;

	[AccessedThroughProperty("_Line2_4")]
	private Label __Line2_4;

	[AccessedThroughProperty("_lblUnits_4")]
	private Label __lblUnits_4;

	[AccessedThroughProperty("_lblVC_4")]
	private Label __lblVC_4;

	[AccessedThroughProperty("_lblV_4")]
	private Label __lblV_4;

	[AccessedThroughProperty("_optType_9")]
	private RadioButton __optType_9;

	[AccessedThroughProperty("_Line2_9")]
	private Label __Line2_9;

	[AccessedThroughProperty("_lblUnits_9")]
	private Label __lblUnits_9;

	[AccessedThroughProperty("_lblVC_9")]
	private Label __lblVC_9;

	[AccessedThroughProperty("_lblV_9")]
	private Label __lblV_9;

	[AccessedThroughProperty("_optType_8")]
	private RadioButton __optType_8;

	[AccessedThroughProperty("_Line2_8")]
	private Label __Line2_8;

	[AccessedThroughProperty("_lblUnits_8")]
	private Label __lblUnits_8;

	[AccessedThroughProperty("_lblVC_8")]
	private Label __lblVC_8;

	[AccessedThroughProperty("_lblV_8")]
	private Label __lblV_8;

	[AccessedThroughProperty("optType")]
	private RadioButtonArray _optType;

	private static frmMDUpdRelA10 m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	private short MyParmID;

	private short MyModelType;

	private short iSelected;

	private short iUserDef;

	private short SaveRelOrExp;

	private short iColIndex;

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

	public virtual RadioButtonArray optType
	{
		[DebuggerNonUserCode]
		get
		{
			return _optType;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_optType = value;
		}
	}

	public static frmMDUpdRelA10 DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmMDUpdRelA10();
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

	public frmMDUpdRelA10()
	{
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
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected O, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected O, but got Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected O, but got Unknown
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected O, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected O, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected O, but got Unknown
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected O, but got Unknown
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected O, but got Unknown
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected O, but got Unknown
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected O, but got Unknown
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected O, but got Unknown
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected O, but got Unknown
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected O, but got Unknown
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected O, but got Unknown
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected O, but got Unknown
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected O, but got Unknown
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected O, but got Unknown
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected O, but got Unknown
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected O, but got Unknown
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected O, but got Unknown
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected O, but got Unknown
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Expected O, but got Unknown
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected O, but got Unknown
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Expected O, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected O, but got Unknown
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected O, but got Unknown
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Expected O, but got Unknown
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected O, but got Unknown
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Expected O, but got Unknown
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected O, but got Unknown
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Expected O, but got Unknown
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected O, but got Unknown
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Expected O, but got Unknown
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Expected O, but got Unknown
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Expected O, but got Unknown
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected O, but got Unknown
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Expected O, but got Unknown
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Expected O, but got Unknown
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Expected O, but got Unknown
		//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Expected O, but got Unknown
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Expected O, but got Unknown
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		//IL_046a: Expected O, but got Unknown
		//IL_052f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0539: Expected O, but got Unknown
		//IL_062c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0636: Expected O, but got Unknown
		//IL_0726: Unknown result type (might be due to invalid IL or missing references)
		//IL_0730: Expected O, but got Unknown
		//IL_07f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0803: Expected O, but got Unknown
		//IL_0942: Unknown result type (might be due to invalid IL or missing references)
		//IL_094c: Expected O, but got Unknown
		//IL_0a2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a36: Expected O, but got Unknown
		//IL_0b16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b20: Expected O, but got Unknown
		//IL_0c00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0a: Expected O, but got Unknown
		//IL_0d4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d58: Expected O, but got Unknown
		//IL_0e28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e32: Expected O, but got Unknown
		//IL_0f02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0c: Expected O, but got Unknown
		//IL_1053: Unknown result type (might be due to invalid IL or missing references)
		//IL_105d: Expected O, but got Unknown
		//IL_112a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1134: Expected O, but got Unknown
		//IL_1201: Unknown result type (might be due to invalid IL or missing references)
		//IL_120b: Expected O, but got Unknown
		//IL_12da: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e4: Expected O, but got Unknown
		//IL_13ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_13b8: Expected O, but got Unknown
		//IL_1482: Unknown result type (might be due to invalid IL or missing references)
		//IL_148c: Expected O, but got Unknown
		//IL_1544: Unknown result type (might be due to invalid IL or missing references)
		//IL_154e: Expected O, but got Unknown
		//IL_16a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ad: Expected O, but got Unknown
		//IL_177a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1784: Expected O, but got Unknown
		//IL_184e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1858: Expected O, but got Unknown
		//IL_1925: Unknown result type (might be due to invalid IL or missing references)
		//IL_192f: Expected O, but got Unknown
		//IL_1a84: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a8e: Expected O, but got Unknown
		//IL_1b5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b65: Expected O, but got Unknown
		//IL_1c32: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c3c: Expected O, but got Unknown
		//IL_1d09: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d13: Expected O, but got Unknown
		//IL_1e68: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e72: Expected O, but got Unknown
		//IL_1f3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f49: Expected O, but got Unknown
		//IL_2016: Unknown result type (might be due to invalid IL or missing references)
		//IL_2020: Expected O, but got Unknown
		//IL_20ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_20f7: Expected O, but got Unknown
		//IL_224c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2256: Expected O, but got Unknown
		//IL_2323: Unknown result type (might be due to invalid IL or missing references)
		//IL_232d: Expected O, but got Unknown
		//IL_23fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_2404: Expected O, but got Unknown
		//IL_24d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_24db: Expected O, but got Unknown
		//IL_2630: Unknown result type (might be due to invalid IL or missing references)
		//IL_263a: Expected O, but got Unknown
		//IL_2707: Unknown result type (might be due to invalid IL or missing references)
		//IL_2711: Expected O, but got Unknown
		//IL_27de: Unknown result type (might be due to invalid IL or missing references)
		//IL_27e8: Expected O, but got Unknown
		//IL_28b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_28bf: Expected O, but got Unknown
		//IL_2a14: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a1e: Expected O, but got Unknown
		//IL_2aeb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2af5: Expected O, but got Unknown
		//IL_2bc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bcc: Expected O, but got Unknown
		//IL_2c99: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ca3: Expected O, but got Unknown
		//IL_2df8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e02: Expected O, but got Unknown
		//IL_2ecf: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ed9: Expected O, but got Unknown
		//IL_2fa6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fb0: Expected O, but got Unknown
		//IL_307d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3087: Expected O, but got Unknown
		//IL_31dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_31e6: Expected O, but got Unknown
		//IL_32b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_32bd: Expected O, but got Unknown
		//IL_338a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3394: Expected O, but got Unknown
		//IL_3461: Unknown result type (might be due to invalid IL or missing references)
		//IL_346b: Expected O, but got Unknown
		//IL_35c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_35ca: Expected O, but got Unknown
		//IL_3697: Unknown result type (might be due to invalid IL or missing references)
		//IL_36a1: Expected O, but got Unknown
		//IL_376e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3778: Expected O, but got Unknown
		//IL_3d23: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d2d: Expected O, but got Unknown
		//IL_3d42: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d4c: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMDUpdRelA10));
		ToolTip1 = new ToolTip(components);
		txtInput = new TextBox();
		_optType_10 = new RadioButton();
		_optType_0 = new RadioButton();
		cmdCancel = new Button();
		cmdClose = new Button();
		_Line2_0 = new Label();
		_lblUnits_10 = new Label();
		_lblV_10 = new Label();
		_lblVC_10 = new Label();
		lblParm = new Label();
		_Line2_10 = new Label();
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
		optType = new RadioButtonArray(components);
		_optType_1 = new RadioButton();
		_Line2_1 = new Label();
		_lblUnits_1 = new Label();
		_lblVC_1 = new Label();
		_lblV_1 = new Label();
		_optType_3 = new RadioButton();
		_Line2_3 = new Label();
		_lblUnits_3 = new Label();
		_lblVC_3 = new Label();
		_lblV_3 = new Label();
		_optType_2 = new RadioButton();
		_Line2_2 = new Label();
		_lblUnits_2 = new Label();
		_lblVC_2 = new Label();
		_lblV_2 = new Label();
		_optType_7 = new RadioButton();
		_Line2_7 = new Label();
		_lblUnits_7 = new Label();
		_lblVC_7 = new Label();
		_lblV_7 = new Label();
		_optType_6 = new RadioButton();
		_Line2_6 = new Label();
		_lblUnits_6 = new Label();
		_lblVC_6 = new Label();
		_lblV_6 = new Label();
		_optType_5 = new RadioButton();
		_Line2_5 = new Label();
		_lblUnits_5 = new Label();
		_lblVC_5 = new Label();
		_lblV_5 = new Label();
		_optType_4 = new RadioButton();
		_Line2_4 = new Label();
		_lblUnits_4 = new Label();
		_lblVC_4 = new Label();
		_lblV_4 = new Label();
		_optType_9 = new RadioButton();
		_Line2_9 = new Label();
		_lblUnits_9 = new Label();
		_lblVC_9 = new Label();
		_lblV_9 = new Label();
		_optType_8 = new RadioButton();
		_Line2_8 = new Label();
		_lblUnits_8 = new Label();
		_lblVC_8 = new Label();
		_lblV_8 = new Label();
		((ISupportInitialize)Label1).BeginInit();
		((ISupportInitialize)Line1).BeginInit();
		((ISupportInitialize)Line2).BeginInit();
		((ISupportInitialize)lblUnits).BeginInit();
		((ISupportInitialize)lblV).BeginInit();
		((ISupportInitialize)lblVC).BeginInit();
		((ISupportInitialize)optType).BeginInit();
		((Control)this).SuspendLayout();
		txtInput.AcceptsReturn = true;
		((TextBoxBase)txtInput).BackColor = SystemColors.Window;
		((Control)txtInput).Cursor = Cursors.IBeam;
		((Control)txtInput).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtInput).ForeColor = SystemColors.WindowText;
		TextBox obj = txtInput;
		Point location = new Point(291, 426);
		((Control)obj).Location = location;
		((TextBoxBase)txtInput).MaxLength = 0;
		((Control)txtInput).Name = "txtInput";
		((Control)txtInput).RightToLeft = (RightToLeft)0;
		TextBox obj2 = txtInput;
		Size size = new Size(81, 20);
		((Control)obj2).Size = size;
		((Control)txtInput).TabIndex = 2;
		((Control)txtInput).Visible = false;
		((ButtonBase)_optType_10).BackColor = SystemColors.Control;
		((Control)_optType_10).Cursor = Cursors.Default;
		((Control)_optType_10).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optType_10).ForeColor = SystemColors.ControlText;
		optType.SetIndex(_optType_10, (short)1);
		RadioButton optType_ = _optType_10;
		location = new Point(16, 429);
		((Control)optType_).Location = location;
		((Control)_optType_10).Name = "_optType_10";
		((Control)_optType_10).RightToLeft = (RightToLeft)0;
		RadioButton optType_2 = _optType_10;
		size = new Size(89, 17);
		((Control)optType_2).Size = size;
		((Control)_optType_10).TabIndex = 1;
		_optType_10.TabStop = true;
		((ButtonBase)_optType_10).Text = "Non-default";
		((ButtonBase)_optType_10).UseVisualStyleBackColor = false;
		((Control)_optType_10).Visible = false;
		((ButtonBase)_optType_0).BackColor = SystemColors.Control;
		((Control)_optType_0).Cursor = Cursors.Default;
		((Control)_optType_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optType_0).ForeColor = SystemColors.ControlText;
		optType.SetIndex(_optType_0, (short)0);
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
		((ButtonBase)_optType_0).Text = "Non-default";
		((ButtonBase)_optType_0).UseVisualStyleBackColor = false;
		((ButtonBase)cmdCancel).BackColor = SystemColors.Control;
		((Control)cmdCancel).Cursor = Cursors.Default;
		cmdCancel.DialogResult = (DialogResult)2;
		((Control)cmdCancel).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCancel).ForeColor = SystemColors.ControlText;
		Button obj3 = cmdCancel;
		location = new Point(327, 471);
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
		location = new Point(231, 471);
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
		((Control)_lblUnits_10).BackColor = SystemColors.Control;
		((Control)_lblUnits_10).Cursor = Cursors.Default;
		((Control)_lblUnits_10).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblUnits_10).ForeColor = SystemColors.ControlText;
		lblUnits.SetIndex(_lblUnits_10, (short)1);
		Label lblUnits_ = _lblUnits_10;
		location = new Point(464, 429);
		((Control)lblUnits_).Location = location;
		((Control)_lblUnits_10).Name = "_lblUnits_10";
		((Control)_lblUnits_10).RightToLeft = (RightToLeft)0;
		Label lblUnits_2 = _lblUnits_10;
		size = new Size(153, 17);
		((Control)lblUnits_2).Size = size;
		((Control)_lblUnits_10).TabIndex = 17;
		_lblUnits_10.Text = "x";
		((Control)_lblUnits_10).Visible = false;
		((Control)_lblV_10).BackColor = SystemColors.Control;
		((Control)_lblV_10).Cursor = Cursors.Default;
		((Control)_lblV_10).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblV_10).ForeColor = SystemColors.ControlText;
		lblV.SetIndex(_lblV_10, (short)1);
		Label lblV_ = _lblV_10;
		location = new Point(288, 429);
		((Control)lblV_).Location = location;
		((Control)_lblV_10).Name = "_lblV_10";
		((Control)_lblV_10).RightToLeft = (RightToLeft)0;
		Label lblV_2 = _lblV_10;
		size = new Size(153, 17);
		((Control)lblV_2).Size = size;
		((Control)_lblV_10).TabIndex = 16;
		_lblV_10.Text = "x";
		((Control)_lblV_10).Visible = false;
		((Control)_lblVC_10).BackColor = SystemColors.Control;
		((Control)_lblVC_10).Cursor = Cursors.Default;
		((Control)_lblVC_10).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblVC_10).ForeColor = SystemColors.ControlText;
		lblVC.SetIndex(_lblVC_10, (short)1);
		Label lblVC_ = _lblVC_10;
		location = new Point(128, 429);
		((Control)lblVC_).Location = location;
		((Control)_lblVC_10).Name = "_lblVC_10";
		((Control)_lblVC_10).RightToLeft = (RightToLeft)0;
		Label lblVC_2 = _lblVC_10;
		size = new Size(145, 17);
		((Control)lblVC_2).Size = size;
		((Control)_lblVC_10).TabIndex = 15;
		_lblVC_10.Text = "x";
		((Control)_lblVC_10).Visible = false;
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
		((Control)_Line2_10).BackColor = SystemColors.WindowText;
		Line2.SetIndex(_Line2_10, (short)1);
		Label line2_3 = _Line2_10;
		location = new Point(8, 453);
		((Control)line2_3).Location = location;
		((Control)_Line2_10).Name = "_Line2_10";
		Label line2_4 = _Line2_10;
		size = new Size(624, 1);
		((Control)line2_4).Size = size;
		((Control)_Line2_10).TabIndex = 18;
		((Control)_Line2_10).Visible = false;
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
		_Label1_0.Text = "Origin";
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
		lblInstructions.Text = "As appropriate, view or update the Origin for this model parameter.";
		((ButtonBase)_optType_1).BackColor = SystemColors.Control;
		((Control)_optType_1).Cursor = Cursors.Default;
		((Control)_optType_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optType_1).ForeColor = SystemColors.ControlText;
		RadioButton optType_5 = _optType_1;
		location = new Point(16, 128);
		((Control)optType_5).Location = location;
		((Control)_optType_1).Name = "_optType_1";
		((Control)_optType_1).RightToLeft = (RightToLeft)0;
		RadioButton optType_6 = _optType_1;
		size = new Size(89, 17);
		((Control)optType_6).Size = size;
		((Control)_optType_1).TabIndex = 20;
		_optType_1.TabStop = true;
		((ButtonBase)_optType_1).Text = "Non-default";
		((ButtonBase)_optType_1).UseVisualStyleBackColor = false;
		((Control)_optType_1).Visible = false;
		((Control)_Line2_1).BackColor = SystemColors.WindowText;
		Label line2_5 = _Line2_1;
		location = new Point(7, 152);
		((Control)line2_5).Location = location;
		((Control)_Line2_1).Name = "_Line2_1";
		Label line2_6 = _Line2_1;
		size = new Size(624, 1);
		((Control)line2_6).Size = size;
		((Control)_Line2_1).TabIndex = 21;
		((Control)_Line2_1).Visible = false;
		((Control)_lblUnits_1).BackColor = SystemColors.Control;
		((Control)_lblUnits_1).Cursor = Cursors.Default;
		((Control)_lblUnits_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblUnits_1).ForeColor = SystemColors.ControlText;
		Label lblUnits_5 = _lblUnits_1;
		location = new Point(463, 128);
		((Control)lblUnits_5).Location = location;
		((Control)_lblUnits_1).Name = "_lblUnits_1";
		((Control)_lblUnits_1).RightToLeft = (RightToLeft)0;
		Label lblUnits_6 = _lblUnits_1;
		size = new Size(153, 17);
		((Control)lblUnits_6).Size = size;
		((Control)_lblUnits_1).TabIndex = 24;
		_lblUnits_1.Text = "x";
		((Control)_lblUnits_1).Visible = false;
		((Control)_lblVC_1).BackColor = SystemColors.Control;
		((Control)_lblVC_1).Cursor = Cursors.Default;
		((Control)_lblVC_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblVC_1).ForeColor = SystemColors.ControlText;
		Label lblVC_5 = _lblVC_1;
		location = new Point(127, 128);
		((Control)lblVC_5).Location = location;
		((Control)_lblVC_1).Name = "_lblVC_1";
		((Control)_lblVC_1).RightToLeft = (RightToLeft)0;
		Label lblVC_6 = _lblVC_1;
		size = new Size(145, 17);
		((Control)lblVC_6).Size = size;
		((Control)_lblVC_1).TabIndex = 23;
		_lblVC_1.Text = "x";
		((Control)_lblVC_1).Visible = false;
		((Control)_lblV_1).BackColor = SystemColors.Control;
		((Control)_lblV_1).Cursor = Cursors.Default;
		((Control)_lblV_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblV_1).ForeColor = SystemColors.ControlText;
		Label lblV_5 = _lblV_1;
		location = new Point(287, 128);
		((Control)lblV_5).Location = location;
		((Control)_lblV_1).Name = "_lblV_1";
		((Control)_lblV_1).RightToLeft = (RightToLeft)0;
		Label lblV_6 = _lblV_1;
		size = new Size(153, 17);
		((Control)lblV_6).Size = size;
		((Control)_lblV_1).TabIndex = 22;
		_lblV_1.Text = "x";
		((Control)_lblV_1).Visible = false;
		((ButtonBase)_optType_3).BackColor = SystemColors.Control;
		((Control)_optType_3).Cursor = Cursors.Default;
		((Control)_optType_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optType_3).ForeColor = SystemColors.ControlText;
		RadioButton optType_7 = _optType_3;
		location = new Point(16, 197);
		((Control)optType_7).Location = location;
		((Control)_optType_3).Name = "_optType_3";
		((Control)_optType_3).RightToLeft = (RightToLeft)0;
		RadioButton optType_8 = _optType_3;
		size = new Size(89, 17);
		((Control)optType_8).Size = size;
		((Control)_optType_3).TabIndex = 30;
		_optType_3.TabStop = true;
		((ButtonBase)_optType_3).Text = "Non-default";
		((ButtonBase)_optType_3).UseVisualStyleBackColor = false;
		((Control)_optType_3).Visible = false;
		((Control)_Line2_3).BackColor = SystemColors.WindowText;
		Label line2_7 = _Line2_3;
		location = new Point(8, 221);
		((Control)line2_7).Location = location;
		((Control)_Line2_3).Name = "_Line2_3";
		Label line2_8 = _Line2_3;
		size = new Size(624, 1);
		((Control)line2_8).Size = size;
		((Control)_Line2_3).TabIndex = 31;
		((Control)_Line2_3).Visible = false;
		((Control)_lblUnits_3).BackColor = SystemColors.Control;
		((Control)_lblUnits_3).Cursor = Cursors.Default;
		((Control)_lblUnits_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblUnits_3).ForeColor = SystemColors.ControlText;
		Label lblUnits_7 = _lblUnits_3;
		location = new Point(464, 197);
		((Control)lblUnits_7).Location = location;
		((Control)_lblUnits_3).Name = "_lblUnits_3";
		((Control)_lblUnits_3).RightToLeft = (RightToLeft)0;
		Label lblUnits_8 = _lblUnits_3;
		size = new Size(153, 17);
		((Control)lblUnits_8).Size = size;
		((Control)_lblUnits_3).TabIndex = 34;
		_lblUnits_3.Text = "x";
		((Control)_lblUnits_3).Visible = false;
		((Control)_lblVC_3).BackColor = SystemColors.Control;
		((Control)_lblVC_3).Cursor = Cursors.Default;
		((Control)_lblVC_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblVC_3).ForeColor = SystemColors.ControlText;
		Label lblVC_7 = _lblVC_3;
		location = new Point(128, 197);
		((Control)lblVC_7).Location = location;
		((Control)_lblVC_3).Name = "_lblVC_3";
		((Control)_lblVC_3).RightToLeft = (RightToLeft)0;
		Label lblVC_8 = _lblVC_3;
		size = new Size(145, 17);
		((Control)lblVC_8).Size = size;
		((Control)_lblVC_3).TabIndex = 33;
		_lblVC_3.Text = "x";
		((Control)_lblVC_3).Visible = false;
		((Control)_lblV_3).BackColor = SystemColors.Control;
		((Control)_lblV_3).Cursor = Cursors.Default;
		((Control)_lblV_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblV_3).ForeColor = SystemColors.ControlText;
		Label lblV_7 = _lblV_3;
		location = new Point(288, 197);
		((Control)lblV_7).Location = location;
		((Control)_lblV_3).Name = "_lblV_3";
		((Control)_lblV_3).RightToLeft = (RightToLeft)0;
		Label lblV_8 = _lblV_3;
		size = new Size(153, 17);
		((Control)lblV_8).Size = size;
		((Control)_lblV_3).TabIndex = 32;
		_lblV_3.Text = "x";
		((Control)_lblV_3).Visible = false;
		((ButtonBase)_optType_2).BackColor = SystemColors.Control;
		((Control)_optType_2).Cursor = Cursors.Default;
		((Control)_optType_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optType_2).ForeColor = SystemColors.ControlText;
		RadioButton optType_9 = _optType_2;
		location = new Point(16, 162);
		((Control)optType_9).Location = location;
		((Control)_optType_2).Name = "_optType_2";
		((Control)_optType_2).RightToLeft = (RightToLeft)0;
		RadioButton optType_10 = _optType_2;
		size = new Size(89, 17);
		((Control)optType_10).Size = size;
		((Control)_optType_2).TabIndex = 25;
		_optType_2.TabStop = true;
		((ButtonBase)_optType_2).Text = "Non-default";
		((ButtonBase)_optType_2).UseVisualStyleBackColor = false;
		((Control)_optType_2).Visible = false;
		((Control)_Line2_2).BackColor = SystemColors.WindowText;
		Label line2_9 = _Line2_2;
		location = new Point(8, 186);
		((Control)line2_9).Location = location;
		((Control)_Line2_2).Name = "_Line2_2";
		Label line2_10 = _Line2_2;
		size = new Size(624, 1);
		((Control)line2_10).Size = size;
		((Control)_Line2_2).TabIndex = 26;
		((Control)_Line2_2).Visible = false;
		((Control)_lblUnits_2).BackColor = SystemColors.Control;
		((Control)_lblUnits_2).Cursor = Cursors.Default;
		((Control)_lblUnits_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblUnits_2).ForeColor = SystemColors.ControlText;
		Label lblUnits_9 = _lblUnits_2;
		location = new Point(464, 162);
		((Control)lblUnits_9).Location = location;
		((Control)_lblUnits_2).Name = "_lblUnits_2";
		((Control)_lblUnits_2).RightToLeft = (RightToLeft)0;
		Label lblUnits_10 = _lblUnits_2;
		size = new Size(153, 17);
		((Control)lblUnits_10).Size = size;
		((Control)_lblUnits_2).TabIndex = 29;
		_lblUnits_2.Text = "x";
		((Control)_lblUnits_2).Visible = false;
		((Control)_lblVC_2).BackColor = SystemColors.Control;
		((Control)_lblVC_2).Cursor = Cursors.Default;
		((Control)_lblVC_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblVC_2).ForeColor = SystemColors.ControlText;
		Label lblVC_9 = _lblVC_2;
		location = new Point(128, 162);
		((Control)lblVC_9).Location = location;
		((Control)_lblVC_2).Name = "_lblVC_2";
		((Control)_lblVC_2).RightToLeft = (RightToLeft)0;
		Label lblVC_10 = _lblVC_2;
		size = new Size(145, 17);
		((Control)lblVC_10).Size = size;
		((Control)_lblVC_2).TabIndex = 28;
		_lblVC_2.Text = "x";
		((Control)_lblVC_2).Visible = false;
		((Control)_lblV_2).BackColor = SystemColors.Control;
		((Control)_lblV_2).Cursor = Cursors.Default;
		((Control)_lblV_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblV_2).ForeColor = SystemColors.ControlText;
		Label lblV_9 = _lblV_2;
		location = new Point(288, 162);
		((Control)lblV_9).Location = location;
		((Control)_lblV_2).Name = "_lblV_2";
		((Control)_lblV_2).RightToLeft = (RightToLeft)0;
		Label lblV_10 = _lblV_2;
		size = new Size(153, 17);
		((Control)lblV_10).Size = size;
		((Control)_lblV_2).TabIndex = 27;
		_lblV_2.Text = "x";
		((Control)_lblV_2).Visible = false;
		((ButtonBase)_optType_7).BackColor = SystemColors.Control;
		((Control)_optType_7).Cursor = Cursors.Default;
		((Control)_optType_7).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optType_7).ForeColor = SystemColors.ControlText;
		RadioButton optType_11 = _optType_7;
		location = new Point(16, 329);
		((Control)optType_11).Location = location;
		((Control)_optType_7).Name = "_optType_7";
		((Control)_optType_7).RightToLeft = (RightToLeft)0;
		RadioButton optType_12 = _optType_7;
		size = new Size(89, 17);
		((Control)optType_12).Size = size;
		((Control)_optType_7).TabIndex = 50;
		_optType_7.TabStop = true;
		((ButtonBase)_optType_7).Text = "Non-default";
		((ButtonBase)_optType_7).UseVisualStyleBackColor = false;
		((Control)_optType_7).Visible = false;
		((Control)_Line2_7).BackColor = SystemColors.WindowText;
		Label line2_11 = _Line2_7;
		location = new Point(8, 353);
		((Control)line2_11).Location = location;
		((Control)_Line2_7).Name = "_Line2_7";
		Label line2_12 = _Line2_7;
		size = new Size(624, 1);
		((Control)line2_12).Size = size;
		((Control)_Line2_7).TabIndex = 51;
		((Control)_Line2_7).Visible = false;
		((Control)_lblUnits_7).BackColor = SystemColors.Control;
		((Control)_lblUnits_7).Cursor = Cursors.Default;
		((Control)_lblUnits_7).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblUnits_7).ForeColor = SystemColors.ControlText;
		Label lblUnits_11 = _lblUnits_7;
		location = new Point(464, 329);
		((Control)lblUnits_11).Location = location;
		((Control)_lblUnits_7).Name = "_lblUnits_7";
		((Control)_lblUnits_7).RightToLeft = (RightToLeft)0;
		Label lblUnits_12 = _lblUnits_7;
		size = new Size(153, 17);
		((Control)lblUnits_12).Size = size;
		((Control)_lblUnits_7).TabIndex = 54;
		_lblUnits_7.Text = "x";
		((Control)_lblUnits_7).Visible = false;
		((Control)_lblVC_7).BackColor = SystemColors.Control;
		((Control)_lblVC_7).Cursor = Cursors.Default;
		((Control)_lblVC_7).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblVC_7).ForeColor = SystemColors.ControlText;
		Label lblVC_11 = _lblVC_7;
		location = new Point(128, 329);
		((Control)lblVC_11).Location = location;
		((Control)_lblVC_7).Name = "_lblVC_7";
		((Control)_lblVC_7).RightToLeft = (RightToLeft)0;
		Label lblVC_12 = _lblVC_7;
		size = new Size(145, 17);
		((Control)lblVC_12).Size = size;
		((Control)_lblVC_7).TabIndex = 53;
		_lblVC_7.Text = "x";
		((Control)_lblVC_7).Visible = false;
		((Control)_lblV_7).BackColor = SystemColors.Control;
		((Control)_lblV_7).Cursor = Cursors.Default;
		((Control)_lblV_7).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblV_7).ForeColor = SystemColors.ControlText;
		Label lblV_11 = _lblV_7;
		location = new Point(288, 329);
		((Control)lblV_11).Location = location;
		((Control)_lblV_7).Name = "_lblV_7";
		((Control)_lblV_7).RightToLeft = (RightToLeft)0;
		Label lblV_12 = _lblV_7;
		size = new Size(153, 17);
		((Control)lblV_12).Size = size;
		((Control)_lblV_7).TabIndex = 52;
		_lblV_7.Text = "x";
		((Control)_lblV_7).Visible = false;
		((ButtonBase)_optType_6).BackColor = SystemColors.Control;
		((Control)_optType_6).Cursor = Cursors.Default;
		((Control)_optType_6).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optType_6).ForeColor = SystemColors.ControlText;
		RadioButton optType_13 = _optType_6;
		location = new Point(16, 294);
		((Control)optType_13).Location = location;
		((Control)_optType_6).Name = "_optType_6";
		((Control)_optType_6).RightToLeft = (RightToLeft)0;
		RadioButton optType_14 = _optType_6;
		size = new Size(89, 17);
		((Control)optType_14).Size = size;
		((Control)_optType_6).TabIndex = 45;
		_optType_6.TabStop = true;
		((ButtonBase)_optType_6).Text = "Non-default";
		((ButtonBase)_optType_6).UseVisualStyleBackColor = false;
		((Control)_optType_6).Visible = false;
		((Control)_Line2_6).BackColor = SystemColors.WindowText;
		Label line2_13 = _Line2_6;
		location = new Point(8, 318);
		((Control)line2_13).Location = location;
		((Control)_Line2_6).Name = "_Line2_6";
		Label line2_14 = _Line2_6;
		size = new Size(624, 1);
		((Control)line2_14).Size = size;
		((Control)_Line2_6).TabIndex = 46;
		((Control)_Line2_6).Visible = false;
		((Control)_lblUnits_6).BackColor = SystemColors.Control;
		((Control)_lblUnits_6).Cursor = Cursors.Default;
		((Control)_lblUnits_6).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblUnits_6).ForeColor = SystemColors.ControlText;
		Label lblUnits_13 = _lblUnits_6;
		location = new Point(464, 294);
		((Control)lblUnits_13).Location = location;
		((Control)_lblUnits_6).Name = "_lblUnits_6";
		((Control)_lblUnits_6).RightToLeft = (RightToLeft)0;
		Label lblUnits_14 = _lblUnits_6;
		size = new Size(153, 17);
		((Control)lblUnits_14).Size = size;
		((Control)_lblUnits_6).TabIndex = 49;
		_lblUnits_6.Text = "x";
		((Control)_lblUnits_6).Visible = false;
		((Control)_lblVC_6).BackColor = SystemColors.Control;
		((Control)_lblVC_6).Cursor = Cursors.Default;
		((Control)_lblVC_6).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblVC_6).ForeColor = SystemColors.ControlText;
		Label lblVC_13 = _lblVC_6;
		location = new Point(128, 294);
		((Control)lblVC_13).Location = location;
		((Control)_lblVC_6).Name = "_lblVC_6";
		((Control)_lblVC_6).RightToLeft = (RightToLeft)0;
		Label lblVC_14 = _lblVC_6;
		size = new Size(145, 17);
		((Control)lblVC_14).Size = size;
		((Control)_lblVC_6).TabIndex = 48;
		_lblVC_6.Text = "x";
		((Control)_lblVC_6).Visible = false;
		((Control)_lblV_6).BackColor = SystemColors.Control;
		((Control)_lblV_6).Cursor = Cursors.Default;
		((Control)_lblV_6).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblV_6).ForeColor = SystemColors.ControlText;
		Label lblV_13 = _lblV_6;
		location = new Point(288, 294);
		((Control)lblV_13).Location = location;
		((Control)_lblV_6).Name = "_lblV_6";
		((Control)_lblV_6).RightToLeft = (RightToLeft)0;
		Label lblV_14 = _lblV_6;
		size = new Size(153, 17);
		((Control)lblV_14).Size = size;
		((Control)_lblV_6).TabIndex = 47;
		_lblV_6.Text = "x";
		((Control)_lblV_6).Visible = false;
		((ButtonBase)_optType_5).BackColor = SystemColors.Control;
		((Control)_optType_5).Cursor = Cursors.Default;
		((Control)_optType_5).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optType_5).ForeColor = SystemColors.ControlText;
		RadioButton optType_15 = _optType_5;
		location = new Point(16, 260);
		((Control)optType_15).Location = location;
		((Control)_optType_5).Name = "_optType_5";
		((Control)_optType_5).RightToLeft = (RightToLeft)0;
		RadioButton optType_16 = _optType_5;
		size = new Size(89, 17);
		((Control)optType_16).Size = size;
		((Control)_optType_5).TabIndex = 40;
		_optType_5.TabStop = true;
		((ButtonBase)_optType_5).Text = "Non-default";
		((ButtonBase)_optType_5).UseVisualStyleBackColor = false;
		((Control)_optType_5).Visible = false;
		((Control)_Line2_5).BackColor = SystemColors.WindowText;
		Label line2_15 = _Line2_5;
		location = new Point(8, 284);
		((Control)line2_15).Location = location;
		((Control)_Line2_5).Name = "_Line2_5";
		Label line2_16 = _Line2_5;
		size = new Size(624, 1);
		((Control)line2_16).Size = size;
		((Control)_Line2_5).TabIndex = 41;
		((Control)_Line2_5).Visible = false;
		((Control)_lblUnits_5).BackColor = SystemColors.Control;
		((Control)_lblUnits_5).Cursor = Cursors.Default;
		((Control)_lblUnits_5).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblUnits_5).ForeColor = SystemColors.ControlText;
		Label lblUnits_15 = _lblUnits_5;
		location = new Point(464, 260);
		((Control)lblUnits_15).Location = location;
		((Control)_lblUnits_5).Name = "_lblUnits_5";
		((Control)_lblUnits_5).RightToLeft = (RightToLeft)0;
		Label lblUnits_16 = _lblUnits_5;
		size = new Size(153, 17);
		((Control)lblUnits_16).Size = size;
		((Control)_lblUnits_5).TabIndex = 44;
		_lblUnits_5.Text = "x";
		((Control)_lblUnits_5).Visible = false;
		((Control)_lblVC_5).BackColor = SystemColors.Control;
		((Control)_lblVC_5).Cursor = Cursors.Default;
		((Control)_lblVC_5).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblVC_5).ForeColor = SystemColors.ControlText;
		Label lblVC_15 = _lblVC_5;
		location = new Point(128, 260);
		((Control)lblVC_15).Location = location;
		((Control)_lblVC_5).Name = "_lblVC_5";
		((Control)_lblVC_5).RightToLeft = (RightToLeft)0;
		Label lblVC_16 = _lblVC_5;
		size = new Size(145, 17);
		((Control)lblVC_16).Size = size;
		((Control)_lblVC_5).TabIndex = 43;
		_lblVC_5.Text = "x";
		((Control)_lblVC_5).Visible = false;
		((Control)_lblV_5).BackColor = SystemColors.Control;
		((Control)_lblV_5).Cursor = Cursors.Default;
		((Control)_lblV_5).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblV_5).ForeColor = SystemColors.ControlText;
		Label lblV_15 = _lblV_5;
		location = new Point(288, 260);
		((Control)lblV_15).Location = location;
		((Control)_lblV_5).Name = "_lblV_5";
		((Control)_lblV_5).RightToLeft = (RightToLeft)0;
		Label lblV_16 = _lblV_5;
		size = new Size(153, 17);
		((Control)lblV_16).Size = size;
		((Control)_lblV_5).TabIndex = 42;
		_lblV_5.Text = "x";
		((Control)_lblV_5).Visible = false;
		((ButtonBase)_optType_4).BackColor = SystemColors.Control;
		((Control)_optType_4).Cursor = Cursors.Default;
		((Control)_optType_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optType_4).ForeColor = SystemColors.ControlText;
		RadioButton optType_17 = _optType_4;
		location = new Point(16, 228);
		((Control)optType_17).Location = location;
		((Control)_optType_4).Name = "_optType_4";
		((Control)_optType_4).RightToLeft = (RightToLeft)0;
		RadioButton optType_18 = _optType_4;
		size = new Size(89, 17);
		((Control)optType_18).Size = size;
		((Control)_optType_4).TabIndex = 35;
		_optType_4.TabStop = true;
		((ButtonBase)_optType_4).Text = "Non-default";
		((ButtonBase)_optType_4).UseVisualStyleBackColor = false;
		((Control)_optType_4).Visible = false;
		((Control)_Line2_4).BackColor = SystemColors.WindowText;
		Label line2_17 = _Line2_4;
		location = new Point(8, 252);
		((Control)line2_17).Location = location;
		((Control)_Line2_4).Name = "_Line2_4";
		Label line2_18 = _Line2_4;
		size = new Size(624, 1);
		((Control)line2_18).Size = size;
		((Control)_Line2_4).TabIndex = 36;
		((Control)_Line2_4).Visible = false;
		((Control)_lblUnits_4).BackColor = SystemColors.Control;
		((Control)_lblUnits_4).Cursor = Cursors.Default;
		((Control)_lblUnits_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblUnits_4).ForeColor = SystemColors.ControlText;
		Label lblUnits_17 = _lblUnits_4;
		location = new Point(464, 228);
		((Control)lblUnits_17).Location = location;
		((Control)_lblUnits_4).Name = "_lblUnits_4";
		((Control)_lblUnits_4).RightToLeft = (RightToLeft)0;
		Label lblUnits_18 = _lblUnits_4;
		size = new Size(153, 17);
		((Control)lblUnits_18).Size = size;
		((Control)_lblUnits_4).TabIndex = 39;
		_lblUnits_4.Text = "x";
		((Control)_lblUnits_4).Visible = false;
		((Control)_lblVC_4).BackColor = SystemColors.Control;
		((Control)_lblVC_4).Cursor = Cursors.Default;
		((Control)_lblVC_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblVC_4).ForeColor = SystemColors.ControlText;
		Label lblVC_17 = _lblVC_4;
		location = new Point(128, 228);
		((Control)lblVC_17).Location = location;
		((Control)_lblVC_4).Name = "_lblVC_4";
		((Control)_lblVC_4).RightToLeft = (RightToLeft)0;
		Label lblVC_18 = _lblVC_4;
		size = new Size(145, 17);
		((Control)lblVC_18).Size = size;
		((Control)_lblVC_4).TabIndex = 38;
		_lblVC_4.Text = "x";
		((Control)_lblVC_4).Visible = false;
		((Control)_lblV_4).BackColor = SystemColors.Control;
		((Control)_lblV_4).Cursor = Cursors.Default;
		((Control)_lblV_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblV_4).ForeColor = SystemColors.ControlText;
		Label lblV_17 = _lblV_4;
		location = new Point(288, 228);
		((Control)lblV_17).Location = location;
		((Control)_lblV_4).Name = "_lblV_4";
		((Control)_lblV_4).RightToLeft = (RightToLeft)0;
		Label lblV_18 = _lblV_4;
		size = new Size(153, 17);
		((Control)lblV_18).Size = size;
		((Control)_lblV_4).TabIndex = 37;
		_lblV_4.Text = "x";
		((Control)_lblV_4).Visible = false;
		((ButtonBase)_optType_9).BackColor = SystemColors.Control;
		((Control)_optType_9).Cursor = Cursors.Default;
		((Control)_optType_9).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optType_9).ForeColor = SystemColors.ControlText;
		RadioButton optType_19 = _optType_9;
		location = new Point(16, 396);
		((Control)optType_19).Location = location;
		((Control)_optType_9).Name = "_optType_9";
		((Control)_optType_9).RightToLeft = (RightToLeft)0;
		RadioButton optType_20 = _optType_9;
		size = new Size(89, 17);
		((Control)optType_20).Size = size;
		((Control)_optType_9).TabIndex = 60;
		_optType_9.TabStop = true;
		((ButtonBase)_optType_9).Text = "Non-default";
		((ButtonBase)_optType_9).UseVisualStyleBackColor = false;
		((Control)_optType_9).Visible = false;
		((Control)_Line2_9).BackColor = SystemColors.WindowText;
		Label line2_19 = _Line2_9;
		location = new Point(8, 420);
		((Control)line2_19).Location = location;
		((Control)_Line2_9).Name = "_Line2_9";
		Label line2_20 = _Line2_9;
		size = new Size(624, 1);
		((Control)line2_20).Size = size;
		((Control)_Line2_9).TabIndex = 61;
		((Control)_Line2_9).Visible = false;
		((Control)_lblUnits_9).BackColor = SystemColors.Control;
		((Control)_lblUnits_9).Cursor = Cursors.Default;
		((Control)_lblUnits_9).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblUnits_9).ForeColor = SystemColors.ControlText;
		Label lblUnits_19 = _lblUnits_9;
		location = new Point(464, 396);
		((Control)lblUnits_19).Location = location;
		((Control)_lblUnits_9).Name = "_lblUnits_9";
		((Control)_lblUnits_9).RightToLeft = (RightToLeft)0;
		Label lblUnits_20 = _lblUnits_9;
		size = new Size(153, 17);
		((Control)lblUnits_20).Size = size;
		((Control)_lblUnits_9).TabIndex = 64;
		_lblUnits_9.Text = "x";
		((Control)_lblUnits_9).Visible = false;
		((Control)_lblVC_9).BackColor = SystemColors.Control;
		((Control)_lblVC_9).Cursor = Cursors.Default;
		((Control)_lblVC_9).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblVC_9).ForeColor = SystemColors.ControlText;
		Label lblVC_19 = _lblVC_9;
		location = new Point(128, 396);
		((Control)lblVC_19).Location = location;
		((Control)_lblVC_9).Name = "_lblVC_9";
		((Control)_lblVC_9).RightToLeft = (RightToLeft)0;
		Label lblVC_20 = _lblVC_9;
		size = new Size(145, 17);
		((Control)lblVC_20).Size = size;
		((Control)_lblVC_9).TabIndex = 63;
		_lblVC_9.Text = "x";
		((Control)_lblVC_9).Visible = false;
		((Control)_lblV_9).BackColor = SystemColors.Control;
		((Control)_lblV_9).Cursor = Cursors.Default;
		((Control)_lblV_9).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblV_9).ForeColor = SystemColors.ControlText;
		Label lblV_19 = _lblV_9;
		location = new Point(288, 396);
		((Control)lblV_19).Location = location;
		((Control)_lblV_9).Name = "_lblV_9";
		((Control)_lblV_9).RightToLeft = (RightToLeft)0;
		Label lblV_20 = _lblV_9;
		size = new Size(153, 17);
		((Control)lblV_20).Size = size;
		((Control)_lblV_9).TabIndex = 62;
		_lblV_9.Text = "x";
		((Control)_lblV_9).Visible = false;
		((ButtonBase)_optType_8).BackColor = SystemColors.Control;
		((Control)_optType_8).Cursor = Cursors.Default;
		((Control)_optType_8).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optType_8).ForeColor = SystemColors.ControlText;
		RadioButton optType_21 = _optType_8;
		location = new Point(16, 361);
		((Control)optType_21).Location = location;
		((Control)_optType_8).Name = "_optType_8";
		((Control)_optType_8).RightToLeft = (RightToLeft)0;
		RadioButton optType_22 = _optType_8;
		size = new Size(89, 17);
		((Control)optType_22).Size = size;
		((Control)_optType_8).TabIndex = 55;
		_optType_8.TabStop = true;
		((ButtonBase)_optType_8).Text = "Non-default";
		((ButtonBase)_optType_8).UseVisualStyleBackColor = false;
		((Control)_optType_8).Visible = false;
		((Control)_Line2_8).BackColor = SystemColors.WindowText;
		Label line2_21 = _Line2_8;
		location = new Point(8, 385);
		((Control)line2_21).Location = location;
		((Control)_Line2_8).Name = "_Line2_8";
		Label line2_22 = _Line2_8;
		size = new Size(624, 1);
		((Control)line2_22).Size = size;
		((Control)_Line2_8).TabIndex = 56;
		((Control)_Line2_8).Visible = false;
		((Control)_lblUnits_8).BackColor = SystemColors.Control;
		((Control)_lblUnits_8).Cursor = Cursors.Default;
		((Control)_lblUnits_8).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblUnits_8).ForeColor = SystemColors.ControlText;
		Label lblUnits_21 = _lblUnits_8;
		location = new Point(464, 361);
		((Control)lblUnits_21).Location = location;
		((Control)_lblUnits_8).Name = "_lblUnits_8";
		((Control)_lblUnits_8).RightToLeft = (RightToLeft)0;
		Label lblUnits_22 = _lblUnits_8;
		size = new Size(153, 17);
		((Control)lblUnits_22).Size = size;
		((Control)_lblUnits_8).TabIndex = 59;
		_lblUnits_8.Text = "x";
		((Control)_lblUnits_8).Visible = false;
		((Control)_lblVC_8).BackColor = SystemColors.Control;
		((Control)_lblVC_8).Cursor = Cursors.Default;
		((Control)_lblVC_8).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblVC_8).ForeColor = SystemColors.ControlText;
		Label lblVC_21 = _lblVC_8;
		location = new Point(128, 361);
		((Control)lblVC_21).Location = location;
		((Control)_lblVC_8).Name = "_lblVC_8";
		((Control)_lblVC_8).RightToLeft = (RightToLeft)0;
		Label lblVC_22 = _lblVC_8;
		size = new Size(145, 17);
		((Control)lblVC_22).Size = size;
		((Control)_lblVC_8).TabIndex = 58;
		_lblVC_8.Text = "x";
		((Control)_lblVC_8).Visible = false;
		((Control)_lblV_8).BackColor = SystemColors.Control;
		((Control)_lblV_8).Cursor = Cursors.Default;
		((Control)_lblV_8).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblV_8).ForeColor = SystemColors.ControlText;
		Label lblV_21 = _lblV_8;
		location = new Point(288, 361);
		((Control)lblV_21).Location = location;
		((Control)_lblV_8).Name = "_lblV_8";
		((Control)_lblV_8).RightToLeft = (RightToLeft)0;
		Label lblV_22 = _lblV_8;
		size = new Size(153, 17);
		((Control)lblV_22).Size = size;
		((Control)_lblV_8).TabIndex = 57;
		_lblV_8.Text = "x";
		((Control)_lblV_8).Visible = false;
		((Form)this).AcceptButton = (IButtonControl)(object)cmdClose;
		size = new Size(5, 13);
		((Form)this).AutoScaleBaseSize = size;
		((Form)this).BackColor = SystemColors.Control;
		((Form)this).CancelButton = (IButtonControl)(object)cmdCancel;
		size = new Size(639, 506);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)_optType_9);
		((Control)this).Controls.Add((Control)(object)_Line2_9);
		((Control)this).Controls.Add((Control)(object)_lblUnits_9);
		((Control)this).Controls.Add((Control)(object)_lblVC_9);
		((Control)this).Controls.Add((Control)(object)_lblV_9);
		((Control)this).Controls.Add((Control)(object)_optType_8);
		((Control)this).Controls.Add((Control)(object)_Line2_8);
		((Control)this).Controls.Add((Control)(object)_lblUnits_8);
		((Control)this).Controls.Add((Control)(object)_lblVC_8);
		((Control)this).Controls.Add((Control)(object)_lblV_8);
		((Control)this).Controls.Add((Control)(object)_optType_7);
		((Control)this).Controls.Add((Control)(object)_Line2_7);
		((Control)this).Controls.Add((Control)(object)_lblUnits_7);
		((Control)this).Controls.Add((Control)(object)_lblVC_7);
		((Control)this).Controls.Add((Control)(object)_lblV_7);
		((Control)this).Controls.Add((Control)(object)_optType_6);
		((Control)this).Controls.Add((Control)(object)_Line2_6);
		((Control)this).Controls.Add((Control)(object)_lblUnits_6);
		((Control)this).Controls.Add((Control)(object)_lblVC_6);
		((Control)this).Controls.Add((Control)(object)_lblV_6);
		((Control)this).Controls.Add((Control)(object)_optType_5);
		((Control)this).Controls.Add((Control)(object)_Line2_5);
		((Control)this).Controls.Add((Control)(object)_lblUnits_5);
		((Control)this).Controls.Add((Control)(object)_lblVC_5);
		((Control)this).Controls.Add((Control)(object)_lblV_5);
		((Control)this).Controls.Add((Control)(object)_optType_4);
		((Control)this).Controls.Add((Control)(object)_Line2_4);
		((Control)this).Controls.Add((Control)(object)_lblUnits_4);
		((Control)this).Controls.Add((Control)(object)_lblVC_4);
		((Control)this).Controls.Add((Control)(object)_lblV_4);
		((Control)this).Controls.Add((Control)(object)_optType_3);
		((Control)this).Controls.Add((Control)(object)_Line2_3);
		((Control)this).Controls.Add((Control)(object)_lblUnits_3);
		((Control)this).Controls.Add((Control)(object)_lblVC_3);
		((Control)this).Controls.Add((Control)(object)_lblV_3);
		((Control)this).Controls.Add((Control)(object)_optType_2);
		((Control)this).Controls.Add((Control)(object)_Line2_2);
		((Control)this).Controls.Add((Control)(object)_lblUnits_2);
		((Control)this).Controls.Add((Control)(object)_lblVC_2);
		((Control)this).Controls.Add((Control)(object)_lblV_2);
		((Control)this).Controls.Add((Control)(object)_optType_1);
		((Control)this).Controls.Add((Control)(object)_Line2_1);
		((Control)this).Controls.Add((Control)(object)_lblUnits_1);
		((Control)this).Controls.Add((Control)(object)_lblVC_1);
		((Control)this).Controls.Add((Control)(object)_lblV_1);
		((Control)this).Controls.Add((Control)(object)txtInput);
		((Control)this).Controls.Add((Control)(object)_optType_10);
		((Control)this).Controls.Add((Control)(object)_optType_0);
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)cmdClose);
		((Control)this).Controls.Add((Control)(object)_Line2_0);
		((Control)this).Controls.Add((Control)(object)_lblUnits_10);
		((Control)this).Controls.Add((Control)(object)_lblV_10);
		((Control)this).Controls.Add((Control)(object)_lblVC_10);
		((Control)this).Controls.Add((Control)(object)lblParm);
		((Control)this).Controls.Add((Control)(object)_Line2_10);
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
		((Control)this).Name = "frmMDUpdRelA10";
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
		((ISupportInitialize)optType).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void cmdCancel_Click(object eventSender, EventArgs eventArgs)
	{
		((Form)this).Close();
	}

	private void cmdClose_Click(object eventSender, EventArgs eventArgs)
	{
		if (SaveRelOrExp == 0)
		{
			AxMSFlexGrid msfRelParms = frmMDUpdRelMod.DefInstance.msfRelParms;
			msfRelParms[msfRelParms.Row, (int)iColIndex] = ((Control)this).Controls["_optType_" + Conversions.ToString((int)iSelected)].Text;
			msfRelParms[msfRelParms.Row, checked(iColIndex + 1)] = ((Control)this).Controls["_lblVC_" + Conversions.ToString((int)iSelected)].Text;
			msfRelParms[msfRelParms.Row, checked(iColIndex + 2)] = ((Control)this).Controls["_lblV_" + Conversions.ToString((int)iSelected)].Text;
			msfRelParms[msfRelParms.Row, checked(iColIndex + 3)] = Conversions.ToString(((Control)this).Controls["_lblV_" + Conversions.ToString((int)iSelected)].Tag);
			msfRelParms = null;
		}
		else
		{
			AxMSFlexGrid msfExpParms = frmMDUpdExpMod.DefInstance.msfExpParms;
			msfExpParms[msfExpParms.Row, (int)iColIndex] = ((Control)this).Controls["_optType_" + Conversions.ToString((int)iSelected)].Text;
			msfExpParms[msfExpParms.Row, checked(iColIndex + 1)] = ((Control)this).Controls["_lblVC_" + Conversions.ToString((int)iSelected)].Text;
			msfExpParms[msfExpParms.Row, checked(iColIndex + 2)] = ((Control)this).Controls["_lblV_" + Conversions.ToString((int)iSelected)].Text;
			if (MyParmID != 57)
			{
				msfExpParms[msfExpParms.Row, checked(iColIndex + 3)] = Conversions.ToString(((Control)this).Controls["_lblV_" + Conversions.ToString((int)iSelected)].Tag);
			}
			msfExpParms = null;
		}
		((Form)this).Close();
	}

	public bool SetUp(ref short pRelOrExp, ref short pModType, ref short pActID, ref AxMSFlexGrid pMsfParms)
	{
		//IL_0652: Unknown result type (might be due to invalid IL or missing references)
		//IL_067a: Unknown result type (might be due to invalid IL or missing references)
		//IL_072a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0752: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num2 = default(int);
		bool flag2 = default(bool);
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
					Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
					Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
					Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					ProjectData.ClearProjectError();
					num2 = 2;
					MyParmID = 0;
					MyModelType = 0;
					iSelected = 0;
					iUserDef = 0;
					SaveRelOrExp = 0;
					iColIndex = 0;
					SaveRelOrExp = pRelOrExp;
					iColIndex = checked((short)pMsfParms.Col);
					MyParmID = Conversions.ToShort(pMsfParms[pMsfParms.Row, 0]);
					MyModelType = pModType;
					lblParm.Text = ChemStrX.GetParmLabels(ref Globals_Renamed.arOpType[Globals_Renamed.intOpIndex], ref MyParmID);
					short myParmID = MyParmID;
					string text;
					if (myParmID == 57)
					{
						ref short myParmID2 = ref MyParmID;
						short pDualID = 0;
						float pValue = GetParmDefaults.GetParmDefault2109(ref pModType, ref pDualID);
						text = ChemStrX.GetVCLabel(ref myParmID2, ref pValue, ref pModType);
					}
					else
					{
						ref short myParmID3 = ref MyParmID;
						short pDualID = Conversions.ToShort(Interaction.IIf(iColIndex == 3, (object)0, (object)1));
						text = Conversions.ToString(GetParmDefaults.GetParmDefault3107(ref myParmID3, ref pDualID, ref MyModelType));
					}
					command.ActiveConnection = Common.MyConn;
					command.CommandText = "pqryGetMeta2Labels";
					command.CommandType = CommandTypeEnum.adCmdStoredProc;
					command.Parameters.Append(command.CreateParameter("pModelID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, MyModelType));
					command.Parameters.Append(command.CreateParameter("pDualID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, RuntimeHelpers.GetObjectValue(Interaction.IIf(iColIndex < 6, (object)0, (object)1))));
					command.Parameters.Append(command.CreateParameter("pParmID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, MyParmID));
					Command command2 = command;
					object RecordsAffected = Missing.Value;
					object Parameters = Missing.Value;
					recordset = command2.Execute(out RecordsAffected, ref Parameters);
					command.Parameters.Delete("pModelID");
					command.Parameters.Delete("pDualID");
					command.Parameters.Delete("pParmID");
					short num3 = 0;
					while (!recordset.EOF)
					{
						if (num3 > 0)
						{
							MakeUmVisible(num3);
						}
						((Control)this).Controls["_lblVC_" + Conversions.ToString((int)num3)].Text = Conversions.ToString(recordset.Fields["Label"].Value);
						((Control)this).Controls["_lblV_" + Conversions.ToString((int)num3)].Text = Conversions.ToString(recordset.Fields["value"].Value);
						if (MyParmID == 57)
						{
							if (Operators.CompareString(((Control)this).Controls["_lblVC_" + Conversions.ToString((int)num3)].Text, text, false) == 0)
							{
								((Control)this).Controls["_optType_" + Conversions.ToString((int)num3)].Text = "Default";
							}
							else
							{
								((Control)this).Controls["_optType_" + Conversions.ToString((int)num3)].Text = "Non-default";
							}
						}
						else if (Operators.CompareString(((Control)this).Controls["_lblV_" + Conversions.ToString((int)num3)].Text, text, false) == 0)
						{
							((Control)this).Controls["_optType_" + Conversions.ToString((int)num3)].Text = "Default";
						}
						else
						{
							((Control)this).Controls["_optType_" + Conversions.ToString((int)num3)].Text = "Non-default";
						}
						((Control)this).Controls["_lblUnits_" + Conversions.ToString((int)num3)].Text = Globals_Renamed.arParmUnits[MyParmID];
						((Control)this).Controls["_lblVC_" + Conversions.ToString((int)num3)].Tag = checked(num3 + 1);
						recordset.MoveNext();
						num3 = checked((short)(num3 + 1));
					}
					recordset.Close();
					if (MyParmID != 57)
					{
						iUserDef = num3;
						MakeUmVisible(num3);
						((Control)this).Controls["_optType_" + Conversions.ToString((int)num3)].Text = "Non-default";
						((Control)txtInput).Top = ((Control)this).Controls["_lblV_" + Conversions.ToString((int)num3)].Top;
						((Control)this).Controls["_lblVC_" + Conversions.ToString((int)num3)].Text = "User Specified";
						txtInput.Text = "0";
						((Control)this).Controls["_lblUnits_" + Conversions.ToString((int)num3)].Text = Globals_Renamed.arParmUnits[MyParmID];
						((Control)this).Controls["_lblVC_" + Conversions.ToString((int)num3)].Tag = (short)999;
					}
					bool flag = false;
					short num4 = myMaxRows;
					num3 = 0;
					while (true)
					{
						short num5 = num3;
						short num6 = num4;
						if (num5 > num6)
						{
							break;
						}
						if (Operators.CompareString(((Control)this).Controls["_lblVC_" + Conversions.ToString((int)num3)].Text, pMsfParms[pMsfParms.Row, checked(pMsfParms.Col + 1)], false) == 0)
						{
							if (Operators.CompareString(((Control)this).Controls["_lblVC_" + Conversions.ToString((int)num3)].Text, "User Specified", false) == 0)
							{
								txtInput.Text = pMsfParms[pMsfParms.Row, checked(pMsfParms.Col + 2)];
							}
							((RadioButton)((Control)this).Controls["_optType_" + Conversions.ToString((int)num3)]).Checked = false;
							((RadioButton)((Control)this).Controls["_optType_" + Conversions.ToString((int)num3)]).Checked = true;
							flag = true;
							break;
						}
						checked
						{
							num3 = (short)unchecked(num3 + 1);
						}
					}
					if (!flag & Globals_Renamed.gblDoEasyModels)
					{
						short num7 = myMaxRows;
						num3 = 0;
						while (true)
						{
							short num8 = num3;
							short num6 = num7;
							if (num8 > num6)
							{
								break;
							}
							if (Operators.CompareString(((Control)this).Controls["_lblV_" + Conversions.ToString((int)num3)].Text, pMsfParms[pMsfParms.Row, checked(pMsfParms.Col + 2)], false) == 0)
							{
								((RadioButton)((Control)this).Controls["_optType_" + Conversions.ToString((int)num3)]).Checked = false;
								((RadioButton)((Control)this).Controls["_optType_" + Conversions.ToString((int)num3)]).Checked = true;
								break;
							}
							checked
							{
								num3 = (short)unchecked(num3 + 1);
							}
						}
					}
					recordset = null;
					command = null;
					flag2 = true;
					goto end_IL_0001;
				}
				case 2024:
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
				try0001_dispatch = 2024;
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
		if (!Conversions.ToBoolean(NewLateBinding.LateGet(eventSender, (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			return;
		}
		iSelected = checked((short)Conversions.ToInteger(Strings.Mid(Conversions.ToString(NewLateBinding.LateGet(eventSender, (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null)), 10)));
		((Control)cmdClose).Enabled = true;
		if (iUserDef > 0)
		{
			if (iSelected == iUserDef)
			{
				((Control)txtInput).Visible = true;
				((Control)this).Controls["_lblV_" + Conversions.ToString((int)iUserDef)].Visible = false;
				((Control)this).Controls["_lblV_" + Conversions.ToString((int)iUserDef)].Text = txtInput.Text;
			}
			else
			{
				((Control)txtInput).Visible = false;
				((Control)this).Controls["_lblV_" + Conversions.ToString((int)iUserDef)].Visible = true;
				((Control)this).Controls["_lblV_" + Conversions.ToString((int)iUserDef)].Text = "0";
			}
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
			((Control)this).Controls["_lblV_" + Conversions.ToString((int)iUserDef)].Visible = true;
		}
	}
}
