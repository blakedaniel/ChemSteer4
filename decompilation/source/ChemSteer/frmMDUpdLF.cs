using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AxMSFlexGridLib;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Compatibility.VB6;
using Microsoft.VisualBasic.CompilerServices;

namespace ChemSteer;

internal class frmMDUpdLF : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private short myMaxRows;

	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("_optType_0")]
	private RadioButton __optType_0;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("cmdClose")]
	private Button _cmdClose;

	[AccessedThroughProperty("_Line2_0")]
	private Label __Line2_0;

	[AccessedThroughProperty("lblParm")]
	private Label _lblParm;

	[AccessedThroughProperty("_lblVC_0")]
	private Label __lblVC_0;

	[AccessedThroughProperty("_lblV_0")]
	private Label __lblV_0;

	[AccessedThroughProperty("_Line1_0")]
	private Label __Line1_0;

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

	[AccessedThroughProperty("lblV")]
	private LabelArray _lblV;

	[AccessedThroughProperty("lblVC")]
	private LabelArray _lblVC;

	[AccessedThroughProperty("_optType_1")]
	private RadioButton __optType_1;

	[AccessedThroughProperty("_Line2_1")]
	private Label __Line2_1;

	[AccessedThroughProperty("_lblVC_1")]
	private Label __lblVC_1;

	[AccessedThroughProperty("_lblV_1")]
	private Label __lblV_1;

	[AccessedThroughProperty("_optType_3")]
	private RadioButton __optType_3;

	[AccessedThroughProperty("_Line2_3")]
	private Label __Line2_3;

	[AccessedThroughProperty("_lblVC_3")]
	private Label __lblVC_3;

	[AccessedThroughProperty("_lblV_3")]
	private Label __lblV_3;

	[AccessedThroughProperty("_optType_2")]
	private RadioButton __optType_2;

	[AccessedThroughProperty("_Line2_2")]
	private Label __Line2_2;

	[AccessedThroughProperty("_lblVC_2")]
	private Label __lblVC_2;

	[AccessedThroughProperty("_lblV_2")]
	private Label __lblV_2;

	[AccessedThroughProperty("_optType_7")]
	private RadioButton __optType_7;

	[AccessedThroughProperty("_Line2_7")]
	private Label __Line2_7;

	[AccessedThroughProperty("_lblVC_7")]
	private Label __lblVC_7;

	[AccessedThroughProperty("_lblV_7")]
	private Label __lblV_7;

	[AccessedThroughProperty("_optType_6")]
	private RadioButton __optType_6;

	[AccessedThroughProperty("_Line2_6")]
	private Label __Line2_6;

	[AccessedThroughProperty("_lblVC_6")]
	private Label __lblVC_6;

	[AccessedThroughProperty("_lblV_6")]
	private Label __lblV_6;

	[AccessedThroughProperty("_optType_5")]
	private RadioButton __optType_5;

	[AccessedThroughProperty("_Line2_5")]
	private Label __Line2_5;

	[AccessedThroughProperty("_lblVC_5")]
	private Label __lblVC_5;

	[AccessedThroughProperty("_lblV_5")]
	private Label __lblV_5;

	[AccessedThroughProperty("_optType_4")]
	private RadioButton __optType_4;

	[AccessedThroughProperty("_Line2_4")]
	private Label __Line2_4;

	[AccessedThroughProperty("_lblVC_4")]
	private Label __lblVC_4;

	[AccessedThroughProperty("_lblV_4")]
	private Label __lblV_4;

	[AccessedThroughProperty("_optType_9")]
	private RadioButton __optType_9;

	[AccessedThroughProperty("_Line2_9")]
	private Label __Line2_9;

	[AccessedThroughProperty("_lblVC_9")]
	private Label __lblVC_9;

	[AccessedThroughProperty("_lblV_9")]
	private Label __lblV_9;

	[AccessedThroughProperty("_optType_8")]
	private RadioButton __optType_8;

	[AccessedThroughProperty("_Line2_8")]
	private Label __Line2_8;

	[AccessedThroughProperty("_lblVC_8")]
	private Label __lblVC_8;

	[AccessedThroughProperty("_lblV_8")]
	private Label __lblV_8;

	[AccessedThroughProperty("_optType_10")]
	private RadioButton __optType_10;

	[AccessedThroughProperty("_Line2_10")]
	private Label __Line2_10;

	[AccessedThroughProperty("_lblVC_10")]
	private Label __lblVC_10;

	[AccessedThroughProperty("_lblV_10")]
	private Label __lblV_10;

	[AccessedThroughProperty("optType")]
	private RadioButtonArray _optType;

	private static frmMDUpdLF m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	private short MyParmID;

	private short MyModelType;

	private short iSelected;

	private short iUserDef;

	private short SaveRelOrExp;

	private short iColIndex;

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
			EventHandler eventHandler = cmdClose_BindingContextChanged;
			EventHandler eventHandler2 = cmdClose_Click;
			if (_cmdClose != null)
			{
				((Control)_cmdClose).BindingContextChanged -= eventHandler;
				((Control)_cmdClose).Click -= eventHandler2;
			}
			_cmdClose = value;
			if (_cmdClose != null)
			{
				((Control)_cmdClose).BindingContextChanged += eventHandler;
				((Control)_cmdClose).Click += eventHandler2;
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

	public static frmMDUpdLF DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmMDUpdLF();
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

	public frmMDUpdLF()
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
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected O, but got Unknown
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
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Expected O, but got Unknown
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Expected O, but got Unknown
		//IL_0566: Unknown result type (might be due to invalid IL or missing references)
		//IL_0570: Expected O, but got Unknown
		//IL_06af: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b9: Expected O, but got Unknown
		//IL_0776: Unknown result type (might be due to invalid IL or missing references)
		//IL_0780: Expected O, but got Unknown
		//IL_0850: Unknown result type (might be due to invalid IL or missing references)
		//IL_085a: Expected O, but got Unknown
		//IL_09a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09aa: Expected O, but got Unknown
		//IL_0a76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a80: Expected O, but got Unknown
		//IL_0b4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b59: Expected O, but got Unknown
		//IL_0c23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2d: Expected O, but got Unknown
		//IL_0cf7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d01: Expected O, but got Unknown
		//IL_0db9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc3: Expected O, but got Unknown
		//IL_0efe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f08: Expected O, but got Unknown
		//IL_0fc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd2: Expected O, but got Unknown
		//IL_1092: Unknown result type (might be due to invalid IL or missing references)
		//IL_109c: Expected O, but got Unknown
		//IL_11d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e1: Expected O, but got Unknown
		//IL_12a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ab: Expected O, but got Unknown
		//IL_136b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1375: Expected O, but got Unknown
		//IL_14b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ba: Expected O, but got Unknown
		//IL_157a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1584: Expected O, but got Unknown
		//IL_1644: Unknown result type (might be due to invalid IL or missing references)
		//IL_164e: Expected O, but got Unknown
		//IL_1789: Unknown result type (might be due to invalid IL or missing references)
		//IL_1793: Expected O, but got Unknown
		//IL_1853: Unknown result type (might be due to invalid IL or missing references)
		//IL_185d: Expected O, but got Unknown
		//IL_191d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1927: Expected O, but got Unknown
		//IL_1a62: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a6c: Expected O, but got Unknown
		//IL_1b2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b36: Expected O, but got Unknown
		//IL_1bf6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c00: Expected O, but got Unknown
		//IL_1d3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d45: Expected O, but got Unknown
		//IL_1e05: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e0f: Expected O, but got Unknown
		//IL_1ecf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ed9: Expected O, but got Unknown
		//IL_2014: Unknown result type (might be due to invalid IL or missing references)
		//IL_201e: Expected O, but got Unknown
		//IL_20de: Unknown result type (might be due to invalid IL or missing references)
		//IL_20e8: Expected O, but got Unknown
		//IL_21a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_21b2: Expected O, but got Unknown
		//IL_22ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_22f7: Expected O, but got Unknown
		//IL_23b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_23c1: Expected O, but got Unknown
		//IL_2481: Unknown result type (might be due to invalid IL or missing references)
		//IL_248b: Expected O, but got Unknown
		//IL_25c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_25d0: Expected O, but got Unknown
		//IL_2690: Unknown result type (might be due to invalid IL or missing references)
		//IL_269a: Expected O, but got Unknown
		//IL_275a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2764: Expected O, but got Unknown
		//IL_289f: Unknown result type (might be due to invalid IL or missing references)
		//IL_28a9: Expected O, but got Unknown
		//IL_2969: Unknown result type (might be due to invalid IL or missing references)
		//IL_2973: Expected O, but got Unknown
		//IL_2e27: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e31: Expected O, but got Unknown
		//IL_2e46: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e50: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMDUpdLF));
		ToolTip1 = new ToolTip(components);
		_optType_0 = new RadioButton();
		cmdCancel = new Button();
		cmdClose = new Button();
		_Line2_0 = new Label();
		lblParm = new Label();
		_lblVC_0 = new Label();
		_lblV_0 = new Label();
		_Line1_0 = new Label();
		_Label1_1 = new Label();
		_Label1_0 = new Label();
		_Label1_98 = new Label();
		_Label1_76 = new Label();
		lblInstructions = new Label();
		Label1 = new LabelArray(components);
		Line1 = new LabelArray(components);
		Line2 = new LabelArray(components);
		lblV = new LabelArray(components);
		lblVC = new LabelArray(components);
		optType = new RadioButtonArray(components);
		_optType_1 = new RadioButton();
		_Line2_1 = new Label();
		_lblVC_1 = new Label();
		_lblV_1 = new Label();
		_optType_3 = new RadioButton();
		_Line2_3 = new Label();
		_lblVC_3 = new Label();
		_lblV_3 = new Label();
		_optType_2 = new RadioButton();
		_Line2_2 = new Label();
		_lblVC_2 = new Label();
		_lblV_2 = new Label();
		_optType_7 = new RadioButton();
		_Line2_7 = new Label();
		_lblVC_7 = new Label();
		_lblV_7 = new Label();
		_optType_6 = new RadioButton();
		_Line2_6 = new Label();
		_lblVC_6 = new Label();
		_lblV_6 = new Label();
		_optType_5 = new RadioButton();
		_Line2_5 = new Label();
		_lblVC_5 = new Label();
		_lblV_5 = new Label();
		_optType_4 = new RadioButton();
		_Line2_4 = new Label();
		_lblVC_4 = new Label();
		_lblV_4 = new Label();
		_optType_9 = new RadioButton();
		_Line2_9 = new Label();
		_lblVC_9 = new Label();
		_lblV_9 = new Label();
		_optType_8 = new RadioButton();
		_Line2_8 = new Label();
		_lblVC_8 = new Label();
		_lblV_8 = new Label();
		_optType_10 = new RadioButton();
		_Line2_10 = new Label();
		_lblVC_10 = new Label();
		_lblV_10 = new Label();
		((ISupportInitialize)Label1).BeginInit();
		((ISupportInitialize)Line1).BeginInit();
		((ISupportInitialize)Line2).BeginInit();
		((ISupportInitialize)lblV).BeginInit();
		((ISupportInitialize)lblVC).BeginInit();
		((ISupportInitialize)optType).BeginInit();
		((Control)this).SuspendLayout();
		((ButtonBase)_optType_0).BackColor = SystemColors.Control;
		((Control)_optType_0).Cursor = Cursors.Default;
		((Control)_optType_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optType_0).ForeColor = SystemColors.ControlText;
		optType.SetIndex(_optType_0, (short)0);
		RadioButton optType_ = _optType_0;
		Point location = new Point(16, 96);
		((Control)optType_).Location = location;
		((Control)_optType_0).Name = "_optType_0";
		((Control)_optType_0).RightToLeft = (RightToLeft)0;
		RadioButton optType_2 = _optType_0;
		Size size = new Size(89, 17);
		((Control)optType_2).Size = size;
		((Control)_optType_0).TabIndex = 0;
		_optType_0.TabStop = true;
		((ButtonBase)_optType_0).Text = "Default";
		((ButtonBase)_optType_0).UseVisualStyleBackColor = false;
		((ButtonBase)cmdCancel).BackColor = SystemColors.Control;
		((Control)cmdCancel).Cursor = Cursors.Default;
		cmdCancel.DialogResult = (DialogResult)2;
		((Control)cmdCancel).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCancel).ForeColor = SystemColors.ControlText;
		Button obj = cmdCancel;
		location = new Point(326, 495);
		((Control)obj).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		((Control)cmdCancel).RightToLeft = (RightToLeft)0;
		Button obj2 = cmdCancel;
		size = new Size(81, 25);
		((Control)obj2).Size = size;
		((Control)cmdCancel).TabIndex = 2;
		((ButtonBase)cmdCancel).Text = "Cancel";
		((ButtonBase)cmdCancel).UseVisualStyleBackColor = false;
		((ButtonBase)cmdClose).BackColor = SystemColors.Control;
		((Control)cmdClose).Cursor = Cursors.Default;
		((Control)cmdClose).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdClose).ForeColor = SystemColors.ControlText;
		Button obj3 = cmdClose;
		location = new Point(230, 495);
		((Control)obj3).Location = location;
		((Control)cmdClose).Name = "cmdClose";
		((Control)cmdClose).RightToLeft = (RightToLeft)0;
		Button obj4 = cmdClose;
		size = new Size(81, 25);
		((Control)obj4).Size = size;
		((Control)cmdClose).TabIndex = 1;
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
		((Control)_Line2_0).TabIndex = 3;
		((Control)lblParm).BackColor = SystemColors.Control;
		((Control)lblParm).Cursor = Cursors.Default;
		((Control)lblParm).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblParm).ForeColor = SystemColors.ControlText;
		Label obj5 = lblParm;
		location = new Point(128, 40);
		((Control)obj5).Location = location;
		((Control)lblParm).Name = "lblParm";
		((Control)lblParm).RightToLeft = (RightToLeft)0;
		Label obj6 = lblParm;
		size = new Size(497, 17);
		((Control)obj6).Size = size;
		((Control)lblParm).TabIndex = 10;
		lblParm.Text = "x";
		((Control)_lblVC_0).BackColor = SystemColors.Control;
		((Control)_lblVC_0).Cursor = Cursors.Default;
		((Control)_lblVC_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblVC_0).ForeColor = SystemColors.ControlText;
		lblVC.SetIndex(_lblVC_0, (short)0);
		Label lblVC_ = _lblVC_0;
		location = new Point(128, 96);
		((Control)lblVC_).Location = location;
		((Control)_lblVC_0).Name = "_lblVC_0";
		((Control)_lblVC_0).RightToLeft = (RightToLeft)0;
		Label lblVC_2 = _lblVC_0;
		size = new Size(313, 17);
		((Control)lblVC_2).Size = size;
		((Control)_lblVC_0).TabIndex = 9;
		_lblVC_0.Text = "x";
		((Control)_lblV_0).BackColor = SystemColors.Control;
		((Control)_lblV_0).Cursor = Cursors.Default;
		((Control)_lblV_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblV_0).ForeColor = SystemColors.ControlText;
		lblV.SetIndex(_lblV_0, (short)0);
		Label lblV_ = _lblV_0;
		location = new Point(448, 96);
		((Control)lblV_).Location = location;
		((Control)_lblV_0).Name = "_lblV_0";
		((Control)_lblV_0).RightToLeft = (RightToLeft)0;
		Label lblV_2 = _lblV_0;
		size = new Size(153, 17);
		((Control)lblV_2).Size = size;
		((Control)_lblV_0).TabIndex = 8;
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
		((Control)_Line1_0).TabIndex = 11;
		((Control)_Label1_1).BackColor = SystemColors.Control;
		((Control)_Label1_1).Cursor = Cursors.Default;
		((Control)_Label1_1).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_1).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_1, (short)1);
		Label label1_ = _Label1_1;
		location = new Point(448, 72);
		((Control)label1_).Location = location;
		((Control)_Label1_1).Name = "_Label1_1";
		((Control)_Label1_1).RightToLeft = (RightToLeft)0;
		Label label1_2 = _Label1_1;
		size = new Size(49, 17);
		((Control)label1_2).Size = size;
		((Control)_Label1_1).TabIndex = 7;
		_Label1_1.Text = "Value";
		((Control)_Label1_0).BackColor = SystemColors.Control;
		((Control)_Label1_0).Cursor = Cursors.Default;
		((Control)_Label1_0).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_0).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_0, (short)0);
		Label label1_3 = _Label1_0;
		location = new Point(128, 72);
		((Control)label1_3).Location = location;
		((Control)_Label1_0).Name = "_Label1_0";
		((Control)_Label1_0).RightToLeft = (RightToLeft)0;
		Label label1_4 = _Label1_0;
		size = new Size(313, 17);
		((Control)label1_4).Size = size;
		((Control)_Label1_0).TabIndex = 6;
		_Label1_0.Text = "Origin";
		((Control)_Label1_98).BackColor = SystemColors.Control;
		((Control)_Label1_98).Cursor = Cursors.Default;
		((Control)_Label1_98).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_98).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_98, (short)98);
		Label label1_5 = _Label1_98;
		location = new Point(16, 40);
		((Control)label1_5).Location = location;
		((Control)_Label1_98).Name = "_Label1_98";
		((Control)_Label1_98).RightToLeft = (RightToLeft)0;
		Label label1_6 = _Label1_98;
		size = new Size(105, 17);
		((Control)label1_6).Size = size;
		((Control)_Label1_98).TabIndex = 5;
		_Label1_98.Text = "Model Parameter: ";
		((Control)_Label1_76).BackColor = SystemColors.Control;
		((Control)_Label1_76).Cursor = Cursors.Default;
		((Control)_Label1_76).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_76).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_76, (short)76);
		Label label1_7 = _Label1_76;
		location = new Point(16, 72);
		((Control)label1_7).Location = location;
		((Control)_Label1_76).Name = "_Label1_76";
		((Control)_Label1_76).RightToLeft = (RightToLeft)0;
		Label label1_8 = _Label1_76;
		size = new Size(49, 17);
		((Control)label1_8).Size = size;
		((Control)_Label1_76).TabIndex = 4;
		_Label1_76.Text = "Type";
		((Control)lblInstructions).BackColor = SystemColors.Control;
		((Control)lblInstructions).Cursor = Cursors.Default;
		((Control)lblInstructions).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblInstructions).ForeColor = SystemColors.ControlText;
		Label obj7 = lblInstructions;
		location = new Point(16, 8);
		((Control)obj7).Location = location;
		((Control)lblInstructions).Name = "lblInstructions";
		((Control)lblInstructions).RightToLeft = (RightToLeft)0;
		Label obj8 = lblInstructions;
		size = new Size(609, 25);
		((Control)obj8).Size = size;
		((Control)lblInstructions).TabIndex = 3;
		lblInstructions.Text = "As appropriate, view or update the Origin for this model parameter.";
		((ButtonBase)_optType_1).BackColor = SystemColors.Control;
		((Control)_optType_1).Cursor = Cursors.Default;
		((Control)_optType_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optType_1).ForeColor = SystemColors.ControlText;
		RadioButton optType_3 = _optType_1;
		location = new Point(16, 132);
		((Control)optType_3).Location = location;
		((Control)_optType_1).Name = "_optType_1";
		((Control)_optType_1).RightToLeft = (RightToLeft)0;
		RadioButton optType_4 = _optType_1;
		size = new Size(89, 17);
		((Control)optType_4).Size = size;
		((Control)_optType_1).TabIndex = 12;
		_optType_1.TabStop = true;
		((ButtonBase)_optType_1).Text = "Default";
		((ButtonBase)_optType_1).UseVisualStyleBackColor = false;
		((Control)_Line2_1).BackColor = SystemColors.WindowText;
		Label line2_3 = _Line2_1;
		location = new Point(8, 156);
		((Control)line2_3).Location = location;
		((Control)_Line2_1).Name = "_Line2_1";
		Label line2_4 = _Line2_1;
		size = new Size(624, 1);
		((Control)line2_4).Size = size;
		((Control)_Line2_1).TabIndex = 13;
		((Control)_lblVC_1).BackColor = SystemColors.Control;
		((Control)_lblVC_1).Cursor = Cursors.Default;
		((Control)_lblVC_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblVC_1).ForeColor = SystemColors.ControlText;
		Label lblVC_3 = _lblVC_1;
		location = new Point(128, 132);
		((Control)lblVC_3).Location = location;
		((Control)_lblVC_1).Name = "_lblVC_1";
		((Control)_lblVC_1).RightToLeft = (RightToLeft)0;
		Label lblVC_4 = _lblVC_1;
		size = new Size(313, 17);
		((Control)lblVC_4).Size = size;
		((Control)_lblVC_1).TabIndex = 15;
		_lblVC_1.Text = "x";
		((Control)_lblV_1).BackColor = SystemColors.Control;
		((Control)_lblV_1).Cursor = Cursors.Default;
		((Control)_lblV_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblV_1).ForeColor = SystemColors.ControlText;
		Label lblV_3 = _lblV_1;
		location = new Point(448, 132);
		((Control)lblV_3).Location = location;
		((Control)_lblV_1).Name = "_lblV_1";
		((Control)_lblV_1).RightToLeft = (RightToLeft)0;
		Label lblV_4 = _lblV_1;
		size = new Size(153, 17);
		((Control)lblV_4).Size = size;
		((Control)_lblV_1).TabIndex = 14;
		_lblV_1.Text = "x";
		((ButtonBase)_optType_3).BackColor = SystemColors.Control;
		((Control)_optType_3).Cursor = Cursors.Default;
		((Control)_optType_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optType_3).ForeColor = SystemColors.ControlText;
		RadioButton optType_5 = _optType_3;
		location = new Point(16, 202);
		((Control)optType_5).Location = location;
		((Control)_optType_3).Name = "_optType_3";
		((Control)_optType_3).RightToLeft = (RightToLeft)0;
		RadioButton optType_6 = _optType_3;
		size = new Size(89, 17);
		((Control)optType_6).Size = size;
		((Control)_optType_3).TabIndex = 20;
		_optType_3.TabStop = true;
		((ButtonBase)_optType_3).Text = "Default";
		((ButtonBase)_optType_3).UseVisualStyleBackColor = false;
		((Control)_Line2_3).BackColor = SystemColors.WindowText;
		Label line2_5 = _Line2_3;
		location = new Point(8, 226);
		((Control)line2_5).Location = location;
		((Control)_Line2_3).Name = "_Line2_3";
		Label line2_6 = _Line2_3;
		size = new Size(624, 1);
		((Control)line2_6).Size = size;
		((Control)_Line2_3).TabIndex = 21;
		((Control)_lblVC_3).BackColor = SystemColors.Control;
		((Control)_lblVC_3).Cursor = Cursors.Default;
		((Control)_lblVC_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblVC_3).ForeColor = SystemColors.ControlText;
		Label lblVC_5 = _lblVC_3;
		location = new Point(128, 202);
		((Control)lblVC_5).Location = location;
		((Control)_lblVC_3).Name = "_lblVC_3";
		((Control)_lblVC_3).RightToLeft = (RightToLeft)0;
		Label lblVC_6 = _lblVC_3;
		size = new Size(313, 17);
		((Control)lblVC_6).Size = size;
		((Control)_lblVC_3).TabIndex = 23;
		_lblVC_3.Text = "x";
		((Control)_lblV_3).BackColor = SystemColors.Control;
		((Control)_lblV_3).Cursor = Cursors.Default;
		((Control)_lblV_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblV_3).ForeColor = SystemColors.ControlText;
		Label lblV_5 = _lblV_3;
		location = new Point(448, 202);
		((Control)lblV_5).Location = location;
		((Control)_lblV_3).Name = "_lblV_3";
		((Control)_lblV_3).RightToLeft = (RightToLeft)0;
		Label lblV_6 = _lblV_3;
		size = new Size(153, 17);
		((Control)lblV_6).Size = size;
		((Control)_lblV_3).TabIndex = 22;
		_lblV_3.Text = "x";
		((ButtonBase)_optType_2).BackColor = SystemColors.Control;
		((Control)_optType_2).Cursor = Cursors.Default;
		((Control)_optType_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optType_2).ForeColor = SystemColors.ControlText;
		RadioButton optType_7 = _optType_2;
		location = new Point(16, 166);
		((Control)optType_7).Location = location;
		((Control)_optType_2).Name = "_optType_2";
		((Control)_optType_2).RightToLeft = (RightToLeft)0;
		RadioButton optType_8 = _optType_2;
		size = new Size(89, 17);
		((Control)optType_8).Size = size;
		((Control)_optType_2).TabIndex = 16;
		_optType_2.TabStop = true;
		((ButtonBase)_optType_2).Text = "Default";
		((ButtonBase)_optType_2).UseVisualStyleBackColor = false;
		((Control)_Line2_2).BackColor = SystemColors.WindowText;
		Label line2_7 = _Line2_2;
		location = new Point(8, 190);
		((Control)line2_7).Location = location;
		((Control)_Line2_2).Name = "_Line2_2";
		Label line2_8 = _Line2_2;
		size = new Size(624, 1);
		((Control)line2_8).Size = size;
		((Control)_Line2_2).TabIndex = 17;
		((Control)_lblVC_2).BackColor = SystemColors.Control;
		((Control)_lblVC_2).Cursor = Cursors.Default;
		((Control)_lblVC_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblVC_2).ForeColor = SystemColors.ControlText;
		Label lblVC_7 = _lblVC_2;
		location = new Point(128, 166);
		((Control)lblVC_7).Location = location;
		((Control)_lblVC_2).Name = "_lblVC_2";
		((Control)_lblVC_2).RightToLeft = (RightToLeft)0;
		Label lblVC_8 = _lblVC_2;
		size = new Size(313, 17);
		((Control)lblVC_8).Size = size;
		((Control)_lblVC_2).TabIndex = 19;
		_lblVC_2.Text = "x";
		((Control)_lblV_2).BackColor = SystemColors.Control;
		((Control)_lblV_2).Cursor = Cursors.Default;
		((Control)_lblV_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblV_2).ForeColor = SystemColors.ControlText;
		Label lblV_7 = _lblV_2;
		location = new Point(448, 166);
		((Control)lblV_7).Location = location;
		((Control)_lblV_2).Name = "_lblV_2";
		((Control)_lblV_2).RightToLeft = (RightToLeft)0;
		Label lblV_8 = _lblV_2;
		size = new Size(153, 17);
		((Control)lblV_8).Size = size;
		((Control)_lblV_2).TabIndex = 18;
		_lblV_2.Text = "x";
		((ButtonBase)_optType_7).BackColor = SystemColors.Control;
		((Control)_optType_7).Cursor = Cursors.Default;
		((Control)_optType_7).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optType_7).ForeColor = SystemColors.ControlText;
		RadioButton optType_9 = _optType_7;
		location = new Point(16, 343);
		((Control)optType_9).Location = location;
		((Control)_optType_7).Name = "_optType_7";
		((Control)_optType_7).RightToLeft = (RightToLeft)0;
		RadioButton optType_10 = _optType_7;
		size = new Size(89, 17);
		((Control)optType_10).Size = size;
		((Control)_optType_7).TabIndex = 36;
		_optType_7.TabStop = true;
		((ButtonBase)_optType_7).Text = "Default";
		((ButtonBase)_optType_7).UseVisualStyleBackColor = false;
		((Control)_Line2_7).BackColor = SystemColors.WindowText;
		Label line2_9 = _Line2_7;
		location = new Point(8, 367);
		((Control)line2_9).Location = location;
		((Control)_Line2_7).Name = "_Line2_7";
		Label line2_10 = _Line2_7;
		size = new Size(624, 1);
		((Control)line2_10).Size = size;
		((Control)_Line2_7).TabIndex = 37;
		((Control)_lblVC_7).BackColor = SystemColors.Control;
		((Control)_lblVC_7).Cursor = Cursors.Default;
		((Control)_lblVC_7).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblVC_7).ForeColor = SystemColors.ControlText;
		Label lblVC_9 = _lblVC_7;
		location = new Point(128, 343);
		((Control)lblVC_9).Location = location;
		((Control)_lblVC_7).Name = "_lblVC_7";
		((Control)_lblVC_7).RightToLeft = (RightToLeft)0;
		Label lblVC_10 = _lblVC_7;
		size = new Size(313, 17);
		((Control)lblVC_10).Size = size;
		((Control)_lblVC_7).TabIndex = 39;
		_lblVC_7.Text = "x";
		((Control)_lblV_7).BackColor = SystemColors.Control;
		((Control)_lblV_7).Cursor = Cursors.Default;
		((Control)_lblV_7).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblV_7).ForeColor = SystemColors.ControlText;
		Label lblV_9 = _lblV_7;
		location = new Point(448, 343);
		((Control)lblV_9).Location = location;
		((Control)_lblV_7).Name = "_lblV_7";
		((Control)_lblV_7).RightToLeft = (RightToLeft)0;
		Label lblV_10 = _lblV_7;
		size = new Size(153, 17);
		((Control)lblV_10).Size = size;
		((Control)_lblV_7).TabIndex = 38;
		_lblV_7.Text = "x";
		((ButtonBase)_optType_6).BackColor = SystemColors.Control;
		((Control)_optType_6).Cursor = Cursors.Default;
		((Control)_optType_6).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optType_6).ForeColor = SystemColors.ControlText;
		RadioButton optType_11 = _optType_6;
		location = new Point(16, 307);
		((Control)optType_11).Location = location;
		((Control)_optType_6).Name = "_optType_6";
		((Control)_optType_6).RightToLeft = (RightToLeft)0;
		RadioButton optType_12 = _optType_6;
		size = new Size(89, 17);
		((Control)optType_12).Size = size;
		((Control)_optType_6).TabIndex = 32;
		_optType_6.TabStop = true;
		((ButtonBase)_optType_6).Text = "Default";
		((ButtonBase)_optType_6).UseVisualStyleBackColor = false;
		((Control)_Line2_6).BackColor = SystemColors.WindowText;
		Label line2_11 = _Line2_6;
		location = new Point(8, 331);
		((Control)line2_11).Location = location;
		((Control)_Line2_6).Name = "_Line2_6";
		Label line2_12 = _Line2_6;
		size = new Size(624, 1);
		((Control)line2_12).Size = size;
		((Control)_Line2_6).TabIndex = 33;
		((Control)_lblVC_6).BackColor = SystemColors.Control;
		((Control)_lblVC_6).Cursor = Cursors.Default;
		((Control)_lblVC_6).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblVC_6).ForeColor = SystemColors.ControlText;
		Label lblVC_11 = _lblVC_6;
		location = new Point(128, 307);
		((Control)lblVC_11).Location = location;
		((Control)_lblVC_6).Name = "_lblVC_6";
		((Control)_lblVC_6).RightToLeft = (RightToLeft)0;
		Label lblVC_12 = _lblVC_6;
		size = new Size(313, 17);
		((Control)lblVC_12).Size = size;
		((Control)_lblVC_6).TabIndex = 35;
		_lblVC_6.Text = "x";
		((Control)_lblV_6).BackColor = SystemColors.Control;
		((Control)_lblV_6).Cursor = Cursors.Default;
		((Control)_lblV_6).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblV_6).ForeColor = SystemColors.ControlText;
		Label lblV_11 = _lblV_6;
		location = new Point(448, 307);
		((Control)lblV_11).Location = location;
		((Control)_lblV_6).Name = "_lblV_6";
		((Control)_lblV_6).RightToLeft = (RightToLeft)0;
		Label lblV_12 = _lblV_6;
		size = new Size(153, 17);
		((Control)lblV_12).Size = size;
		((Control)_lblV_6).TabIndex = 34;
		_lblV_6.Text = "x";
		((ButtonBase)_optType_5).BackColor = SystemColors.Control;
		((Control)_optType_5).Cursor = Cursors.Default;
		((Control)_optType_5).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optType_5).ForeColor = SystemColors.ControlText;
		RadioButton optType_13 = _optType_5;
		location = new Point(16, 273);
		((Control)optType_13).Location = location;
		((Control)_optType_5).Name = "_optType_5";
		((Control)_optType_5).RightToLeft = (RightToLeft)0;
		RadioButton optType_14 = _optType_5;
		size = new Size(89, 17);
		((Control)optType_14).Size = size;
		((Control)_optType_5).TabIndex = 28;
		_optType_5.TabStop = true;
		((ButtonBase)_optType_5).Text = "Default";
		((ButtonBase)_optType_5).UseVisualStyleBackColor = false;
		((Control)_Line2_5).BackColor = SystemColors.WindowText;
		Label line2_13 = _Line2_5;
		location = new Point(8, 297);
		((Control)line2_13).Location = location;
		((Control)_Line2_5).Name = "_Line2_5";
		Label line2_14 = _Line2_5;
		size = new Size(624, 1);
		((Control)line2_14).Size = size;
		((Control)_Line2_5).TabIndex = 29;
		((Control)_lblVC_5).BackColor = SystemColors.Control;
		((Control)_lblVC_5).Cursor = Cursors.Default;
		((Control)_lblVC_5).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblVC_5).ForeColor = SystemColors.ControlText;
		Label lblVC_13 = _lblVC_5;
		location = new Point(128, 273);
		((Control)lblVC_13).Location = location;
		((Control)_lblVC_5).Name = "_lblVC_5";
		((Control)_lblVC_5).RightToLeft = (RightToLeft)0;
		Label lblVC_14 = _lblVC_5;
		size = new Size(313, 17);
		((Control)lblVC_14).Size = size;
		((Control)_lblVC_5).TabIndex = 31;
		_lblVC_5.Text = "x";
		((Control)_lblV_5).BackColor = SystemColors.Control;
		((Control)_lblV_5).Cursor = Cursors.Default;
		((Control)_lblV_5).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblV_5).ForeColor = SystemColors.ControlText;
		Label lblV_13 = _lblV_5;
		location = new Point(448, 273);
		((Control)lblV_13).Location = location;
		((Control)_lblV_5).Name = "_lblV_5";
		((Control)_lblV_5).RightToLeft = (RightToLeft)0;
		Label lblV_14 = _lblV_5;
		size = new Size(153, 17);
		((Control)lblV_14).Size = size;
		((Control)_lblV_5).TabIndex = 30;
		_lblV_5.Text = "x";
		((ButtonBase)_optType_4).BackColor = SystemColors.Control;
		((Control)_optType_4).Cursor = Cursors.Default;
		((Control)_optType_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optType_4).ForeColor = SystemColors.ControlText;
		RadioButton optType_15 = _optType_4;
		location = new Point(16, 237);
		((Control)optType_15).Location = location;
		((Control)_optType_4).Name = "_optType_4";
		((Control)_optType_4).RightToLeft = (RightToLeft)0;
		RadioButton optType_16 = _optType_4;
		size = new Size(89, 17);
		((Control)optType_16).Size = size;
		((Control)_optType_4).TabIndex = 24;
		_optType_4.TabStop = true;
		((ButtonBase)_optType_4).Text = "Default";
		((ButtonBase)_optType_4).UseVisualStyleBackColor = false;
		((Control)_Line2_4).BackColor = SystemColors.WindowText;
		Label line2_15 = _Line2_4;
		location = new Point(8, 261);
		((Control)line2_15).Location = location;
		((Control)_Line2_4).Name = "_Line2_4";
		Label line2_16 = _Line2_4;
		size = new Size(624, 1);
		((Control)line2_16).Size = size;
		((Control)_Line2_4).TabIndex = 25;
		((Control)_lblVC_4).BackColor = SystemColors.Control;
		((Control)_lblVC_4).Cursor = Cursors.Default;
		((Control)_lblVC_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblVC_4).ForeColor = SystemColors.ControlText;
		Label lblVC_15 = _lblVC_4;
		location = new Point(128, 237);
		((Control)lblVC_15).Location = location;
		((Control)_lblVC_4).Name = "_lblVC_4";
		((Control)_lblVC_4).RightToLeft = (RightToLeft)0;
		Label lblVC_16 = _lblVC_4;
		size = new Size(313, 17);
		((Control)lblVC_16).Size = size;
		((Control)_lblVC_4).TabIndex = 27;
		_lblVC_4.Text = "x";
		((Control)_lblV_4).BackColor = SystemColors.Control;
		((Control)_lblV_4).Cursor = Cursors.Default;
		((Control)_lblV_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblV_4).ForeColor = SystemColors.ControlText;
		Label lblV_15 = _lblV_4;
		location = new Point(448, 237);
		((Control)lblV_15).Location = location;
		((Control)_lblV_4).Name = "_lblV_4";
		((Control)_lblV_4).RightToLeft = (RightToLeft)0;
		Label lblV_16 = _lblV_4;
		size = new Size(153, 17);
		((Control)lblV_16).Size = size;
		((Control)_lblV_4).TabIndex = 26;
		_lblV_4.Text = "x";
		((ButtonBase)_optType_9).BackColor = SystemColors.Control;
		((Control)_optType_9).Cursor = Cursors.Default;
		((Control)_optType_9).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optType_9).ForeColor = SystemColors.ControlText;
		RadioButton optType_17 = _optType_9;
		location = new Point(16, 415);
		((Control)optType_17).Location = location;
		((Control)_optType_9).Name = "_optType_9";
		((Control)_optType_9).RightToLeft = (RightToLeft)0;
		RadioButton optType_18 = _optType_9;
		size = new Size(89, 17);
		((Control)optType_18).Size = size;
		((Control)_optType_9).TabIndex = 44;
		_optType_9.TabStop = true;
		((ButtonBase)_optType_9).Text = "Default";
		((ButtonBase)_optType_9).UseVisualStyleBackColor = false;
		((Control)_Line2_9).BackColor = SystemColors.WindowText;
		Label line2_17 = _Line2_9;
		location = new Point(8, 439);
		((Control)line2_17).Location = location;
		((Control)_Line2_9).Name = "_Line2_9";
		Label line2_18 = _Line2_9;
		size = new Size(624, 1);
		((Control)line2_18).Size = size;
		((Control)_Line2_9).TabIndex = 45;
		((Control)_lblVC_9).BackColor = SystemColors.Control;
		((Control)_lblVC_9).Cursor = Cursors.Default;
		((Control)_lblVC_9).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblVC_9).ForeColor = SystemColors.ControlText;
		Label lblVC_17 = _lblVC_9;
		location = new Point(128, 415);
		((Control)lblVC_17).Location = location;
		((Control)_lblVC_9).Name = "_lblVC_9";
		((Control)_lblVC_9).RightToLeft = (RightToLeft)0;
		Label lblVC_18 = _lblVC_9;
		size = new Size(313, 17);
		((Control)lblVC_18).Size = size;
		((Control)_lblVC_9).TabIndex = 47;
		_lblVC_9.Text = "x";
		((Control)_lblV_9).BackColor = SystemColors.Control;
		((Control)_lblV_9).Cursor = Cursors.Default;
		((Control)_lblV_9).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblV_9).ForeColor = SystemColors.ControlText;
		Label lblV_17 = _lblV_9;
		location = new Point(448, 415);
		((Control)lblV_17).Location = location;
		((Control)_lblV_9).Name = "_lblV_9";
		((Control)_lblV_9).RightToLeft = (RightToLeft)0;
		Label lblV_18 = _lblV_9;
		size = new Size(153, 17);
		((Control)lblV_18).Size = size;
		((Control)_lblV_9).TabIndex = 46;
		_lblV_9.Text = "x";
		((ButtonBase)_optType_8).BackColor = SystemColors.Control;
		((Control)_optType_8).Cursor = Cursors.Default;
		((Control)_optType_8).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optType_8).ForeColor = SystemColors.ControlText;
		RadioButton optType_19 = _optType_8;
		location = new Point(16, 379);
		((Control)optType_19).Location = location;
		((Control)_optType_8).Name = "_optType_8";
		((Control)_optType_8).RightToLeft = (RightToLeft)0;
		RadioButton optType_20 = _optType_8;
		size = new Size(89, 17);
		((Control)optType_20).Size = size;
		((Control)_optType_8).TabIndex = 40;
		_optType_8.TabStop = true;
		((ButtonBase)_optType_8).Text = "Default";
		((ButtonBase)_optType_8).UseVisualStyleBackColor = false;
		((Control)_Line2_8).BackColor = SystemColors.WindowText;
		Label line2_19 = _Line2_8;
		location = new Point(8, 403);
		((Control)line2_19).Location = location;
		((Control)_Line2_8).Name = "_Line2_8";
		Label line2_20 = _Line2_8;
		size = new Size(624, 1);
		((Control)line2_20).Size = size;
		((Control)_Line2_8).TabIndex = 41;
		((Control)_lblVC_8).BackColor = SystemColors.Control;
		((Control)_lblVC_8).Cursor = Cursors.Default;
		((Control)_lblVC_8).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblVC_8).ForeColor = SystemColors.ControlText;
		Label lblVC_19 = _lblVC_8;
		location = new Point(128, 379);
		((Control)lblVC_19).Location = location;
		((Control)_lblVC_8).Name = "_lblVC_8";
		((Control)_lblVC_8).RightToLeft = (RightToLeft)0;
		Label lblVC_20 = _lblVC_8;
		size = new Size(313, 17);
		((Control)lblVC_20).Size = size;
		((Control)_lblVC_8).TabIndex = 43;
		_lblVC_8.Text = "x";
		((Control)_lblV_8).BackColor = SystemColors.Control;
		((Control)_lblV_8).Cursor = Cursors.Default;
		((Control)_lblV_8).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblV_8).ForeColor = SystemColors.ControlText;
		Label lblV_19 = _lblV_8;
		location = new Point(448, 379);
		((Control)lblV_19).Location = location;
		((Control)_lblV_8).Name = "_lblV_8";
		((Control)_lblV_8).RightToLeft = (RightToLeft)0;
		Label lblV_20 = _lblV_8;
		size = new Size(153, 17);
		((Control)lblV_20).Size = size;
		((Control)_lblV_8).TabIndex = 42;
		_lblV_8.Text = "x";
		((ButtonBase)_optType_10).BackColor = SystemColors.Control;
		((Control)_optType_10).Cursor = Cursors.Default;
		((Control)_optType_10).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optType_10).ForeColor = SystemColors.ControlText;
		RadioButton optType_21 = _optType_10;
		location = new Point(16, 452);
		((Control)optType_21).Location = location;
		((Control)_optType_10).Name = "_optType_10";
		((Control)_optType_10).RightToLeft = (RightToLeft)0;
		RadioButton optType_22 = _optType_10;
		size = new Size(89, 17);
		((Control)optType_22).Size = size;
		((Control)_optType_10).TabIndex = 48;
		_optType_10.TabStop = true;
		((ButtonBase)_optType_10).Text = "Default";
		((ButtonBase)_optType_10).UseVisualStyleBackColor = false;
		((Control)_Line2_10).BackColor = SystemColors.WindowText;
		Label line2_21 = _Line2_10;
		location = new Point(8, 476);
		((Control)line2_21).Location = location;
		((Control)_Line2_10).Name = "_Line2_10";
		Label line2_22 = _Line2_10;
		size = new Size(624, 1);
		((Control)line2_22).Size = size;
		((Control)_Line2_10).TabIndex = 49;
		((Control)_lblVC_10).BackColor = SystemColors.Control;
		((Control)_lblVC_10).Cursor = Cursors.Default;
		((Control)_lblVC_10).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblVC_10).ForeColor = SystemColors.ControlText;
		Label lblVC_21 = _lblVC_10;
		location = new Point(128, 452);
		((Control)lblVC_21).Location = location;
		((Control)_lblVC_10).Name = "_lblVC_10";
		((Control)_lblVC_10).RightToLeft = (RightToLeft)0;
		Label lblVC_22 = _lblVC_10;
		size = new Size(313, 17);
		((Control)lblVC_22).Size = size;
		((Control)_lblVC_10).TabIndex = 51;
		_lblVC_10.Text = "x";
		((Control)_lblV_10).BackColor = SystemColors.Control;
		((Control)_lblV_10).Cursor = Cursors.Default;
		((Control)_lblV_10).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblV_10).ForeColor = SystemColors.ControlText;
		Label lblV_21 = _lblV_10;
		location = new Point(448, 452);
		((Control)lblV_21).Location = location;
		((Control)_lblV_10).Name = "_lblV_10";
		((Control)_lblV_10).RightToLeft = (RightToLeft)0;
		Label lblV_22 = _lblV_10;
		size = new Size(153, 17);
		((Control)lblV_22).Size = size;
		((Control)_lblV_10).TabIndex = 50;
		_lblV_10.Text = "x";
		((Form)this).AcceptButton = (IButtonControl)(object)cmdClose;
		size = new Size(5, 13);
		((Form)this).AutoScaleBaseSize = size;
		((Form)this).BackColor = SystemColors.Control;
		((Form)this).CancelButton = (IButtonControl)(object)cmdCancel;
		size = new Size(639, 543);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)_optType_10);
		((Control)this).Controls.Add((Control)(object)_Line2_10);
		((Control)this).Controls.Add((Control)(object)_lblVC_10);
		((Control)this).Controls.Add((Control)(object)_lblV_10);
		((Control)this).Controls.Add((Control)(object)_optType_9);
		((Control)this).Controls.Add((Control)(object)_Line2_9);
		((Control)this).Controls.Add((Control)(object)_lblVC_9);
		((Control)this).Controls.Add((Control)(object)_lblV_9);
		((Control)this).Controls.Add((Control)(object)_optType_8);
		((Control)this).Controls.Add((Control)(object)_Line2_8);
		((Control)this).Controls.Add((Control)(object)_lblVC_8);
		((Control)this).Controls.Add((Control)(object)_lblV_8);
		((Control)this).Controls.Add((Control)(object)_optType_7);
		((Control)this).Controls.Add((Control)(object)_Line2_7);
		((Control)this).Controls.Add((Control)(object)_lblVC_7);
		((Control)this).Controls.Add((Control)(object)_lblV_7);
		((Control)this).Controls.Add((Control)(object)_optType_6);
		((Control)this).Controls.Add((Control)(object)_Line2_6);
		((Control)this).Controls.Add((Control)(object)_lblVC_6);
		((Control)this).Controls.Add((Control)(object)_lblV_6);
		((Control)this).Controls.Add((Control)(object)_optType_5);
		((Control)this).Controls.Add((Control)(object)_Line2_5);
		((Control)this).Controls.Add((Control)(object)_lblVC_5);
		((Control)this).Controls.Add((Control)(object)_lblV_5);
		((Control)this).Controls.Add((Control)(object)_optType_4);
		((Control)this).Controls.Add((Control)(object)_Line2_4);
		((Control)this).Controls.Add((Control)(object)_lblVC_4);
		((Control)this).Controls.Add((Control)(object)_lblV_4);
		((Control)this).Controls.Add((Control)(object)_optType_3);
		((Control)this).Controls.Add((Control)(object)_Line2_3);
		((Control)this).Controls.Add((Control)(object)_lblVC_3);
		((Control)this).Controls.Add((Control)(object)_lblV_3);
		((Control)this).Controls.Add((Control)(object)_optType_2);
		((Control)this).Controls.Add((Control)(object)_Line2_2);
		((Control)this).Controls.Add((Control)(object)_lblVC_2);
		((Control)this).Controls.Add((Control)(object)_lblV_2);
		((Control)this).Controls.Add((Control)(object)_optType_1);
		((Control)this).Controls.Add((Control)(object)_Line2_1);
		((Control)this).Controls.Add((Control)(object)_lblVC_1);
		((Control)this).Controls.Add((Control)(object)_lblV_1);
		((Control)this).Controls.Add((Control)(object)_optType_0);
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)cmdClose);
		((Control)this).Controls.Add((Control)(object)_Line2_0);
		((Control)this).Controls.Add((Control)(object)lblParm);
		((Control)this).Controls.Add((Control)(object)_lblVC_0);
		((Control)this).Controls.Add((Control)(object)_lblV_0);
		((Control)this).Controls.Add((Control)(object)_Line1_0);
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
		((Control)this).Name = "frmMDUpdLF";
		((Control)this).RightToLeft = (RightToLeft)0;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "View/Update the Value Calculation of the selected Model Parameter ";
		((ISupportInitialize)Label1).EndInit();
		((ISupportInitialize)Line1).EndInit();
		((ISupportInitialize)Line2).EndInit();
		((ISupportInitialize)lblV).EndInit();
		((ISupportInitialize)lblVC).EndInit();
		((ISupportInitialize)optType).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void cmdCancel_Click(object eventSender, EventArgs eventArgs)
	{
		((Form)this).Close();
	}

	private void cmdClose_BindingContextChanged(object sender, EventArgs e)
	{
	}

	private void cmdClose_Click(object eventSender, EventArgs eventArgs)
	{
		bool flag = default(bool);
		if (SaveRelOrExp == 0)
		{
			AxMSFlexGrid msfRelParms = frmMDUpdRelMod.DefInstance.msfRelParms;
			msfRelParms[msfRelParms.Row, (int)iColIndex] = ((Control)this).Controls["_optType_" + Conversions.ToString((int)iSelected)].Text;
			checked
			{
				if (Operators.CompareString(((Control)this).Controls["_optType_" + Conversions.ToString(unchecked((int)iSelected))].Text, "Default", false) == 0)
				{
					msfRelParms[msfRelParms.Row, iColIndex + 1] = "Model Parm";
				}
				else
				{
					msfRelParms[msfRelParms.Row, iColIndex + 1] = "User-defined";
				}
				msfRelParms[msfRelParms.Row, iColIndex + 2] = ((Control)this).Controls["_lblV_" + Conversions.ToString(unchecked((int)iSelected))].Text;
				short num = (short)(frmMDUpdRelMod.DefInstance.cmbChar[Globals_Renamed.intDualIndex].Items.Count - 1);
				short num2 = 0;
				while (true)
				{
					short num3 = num2;
					short num4 = num;
					if (num3 > num4)
					{
						break;
					}
					if (unchecked(Operators.CompareString(Support.GetItemString((Control)(object)frmMDUpdRelMod.DefInstance.cmbChar[Globals_Renamed.intDualIndex], (int)num2), ((Control)this).Controls["_lblVC_" + Conversions.ToString((int)iSelected)].Text, false)) == 0)
					{
						frmMDUpdRelMod.DefInstance.cmbChar[Globals_Renamed.intDualIndex].SelectedIndex = num2;
						flag = true;
						break;
					}
					num2 = (short)unchecked(num2 + 1);
				}
				if (!flag)
				{
					short num5 = (short)(frmMDUpdRelMod.DefInstance.cmbChar[Globals_Renamed.intDualIndex].Items.Count - 1);
					num2 = 0;
					while (true)
					{
						short num6 = num2;
						short num4 = num5;
						if (num6 > num4)
						{
							break;
						}
						if (unchecked(Operators.CompareString(Strings.Left(Support.GetItemString((Control)(object)frmMDUpdRelMod.DefInstance.cmbChar[Globals_Renamed.intDualIndex], (int)num2), 4), Strings.Left(((Control)this).Controls["_lblVC_" + Conversions.ToString((int)iSelected)].Text, 4), false)) == 0)
						{
							frmMDUpdRelMod.DefInstance.cmbChar[Globals_Renamed.intDualIndex].SelectedIndex = num2;
							break;
						}
						num2 = (short)unchecked(num2 + 1);
					}
				}
				msfRelParms = null;
			}
		}
		else
		{
			AxMSFlexGrid msfExpParms = frmMDUpdExpMod.DefInstance.msfExpParms;
			msfExpParms[msfExpParms.Row, (int)iColIndex] = ((ButtonBase)optType[iSelected]).Text;
			checked
			{
				if (Operators.CompareString(((ButtonBase)optType[iSelected]).Text, "Default", false) == 0)
				{
					msfExpParms[msfExpParms.Row, iColIndex + 1] = "Model Parm";
				}
				else
				{
					msfExpParms[msfExpParms.Row, iColIndex + 1] = "User-defined";
				}
				msfExpParms[msfExpParms.Row, iColIndex + 2] = lblV[iSelected].Text;
				short num7 = (short)(frmMDUpdExpMod.DefInstance.cmbChar[Globals_Renamed.intDualIndex].Items.Count - 1);
				short num2 = 0;
				while (true)
				{
					short num8 = num2;
					short num4 = num7;
					if (num8 > num4)
					{
						break;
					}
					if (Operators.CompareString(Support.GetItemString((Control)(object)frmMDUpdExpMod.DefInstance.cmbChar[Globals_Renamed.intDualIndex], unchecked((int)num2)), lblVC[iSelected].Text, false) == 0)
					{
						frmMDUpdExpMod.DefInstance.cmbChar[Globals_Renamed.intDualIndex].SelectedIndex = num2;
						flag = true;
						break;
					}
					num2 = (short)unchecked(num2 + 1);
				}
				if (!flag)
				{
					short num9 = (short)(frmMDUpdExpMod.DefInstance.cmbChar[Globals_Renamed.intDualIndex].Items.Count - 1);
					num2 = 0;
					while (true)
					{
						short num10 = num2;
						short num4 = num9;
						if (num10 > num4)
						{
							break;
						}
						if (Operators.CompareString(Strings.Left(Support.GetItemString((Control)(object)frmMDUpdExpMod.DefInstance.cmbChar[Globals_Renamed.intDualIndex], unchecked((int)num2)), 4), Strings.Left(lblVC[iSelected].Text, 4), false) == 0)
						{
							frmMDUpdExpMod.DefInstance.cmbChar[Globals_Renamed.intDualIndex].SelectedIndex = num2;
							break;
						}
						num2 = (short)unchecked(num2 + 1);
					}
				}
				msfExpParms = null;
			}
		}
		((Form)this).Close();
	}

	public bool SetUp(ref short pRelOrExp, ref short pModType, object pMsfParms)
	{
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num2 = default(int);
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
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					SaveRelOrExp = pRelOrExp;
					iColIndex = Conversions.ToShort(NewLateBinding.LateGet(pMsfParms, (Type)null, "Col", new object[0], (string[])null, (Type[])null, (bool[])null));
					object[] array = new object[2];
					object[] array2 = array;
					object obj = pMsfParms;
					array2[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "Row", new object[0], (string[])null, (Type[])null, (bool[])null));
					array[1] = 0;
					object[] array3 = array;
					object[] array4 = array3;
					bool[] array5 = new bool[2] { true, false };
					object obj2 = NewLateBinding.LateGet(pMsfParms, (Type)null, "get_TextMatrix", array4, (string[])null, (Type[])null, array5);
					if (array5[0])
					{
						NewLateBinding.LateSetComplex(obj, (Type)null, "Row", new object[1] { RuntimeHelpers.GetObjectValue(array3[0]) }, (string[])null, (Type[])null, true, false);
					}
					MyParmID = Conversions.ToShort(obj2);
					MyModelType = pModType;
					lblParm.Text = ChemStrX.GetParmLabels(ref Globals_Renamed.arOpType[Globals_Renamed.intOpIndex], ref MyParmID);
					Globals_Renamed.intDualIndex = Conversions.ToShort(Interaction.IIf(iColIndex == 2, (object)0, (object)1));
					short myParmID = MyParmID;
					ref short myModelType = ref MyModelType;
					short pActID = 0;
					float modelDefault = ChemStrX.GetModelDefault(-1302, myParmID, ref myModelType, ref pActID, ref Globals_Renamed.intModIndex, ref Globals_Renamed.intDualIndex);
					short num3 = checked((short)(Globals_Renamed.gblNumMetaNonDefaults - 1));
					short num4 = 0;
					while (true)
					{
						short num5 = num4;
						short num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						if (num4 > 0)
						{
							MakeUmVisible(num4);
						}
						((Control)this).Controls["_lblVC_" + Conversions.ToString((int)num4)].Text = Conversions.ToString(Globals_Renamed.gblMetaNonDefaultCaps[num4]);
						((Control)this).Controls["_lblV_" + Conversions.ToString((int)num4)].Text = Conversions.ToString(Globals_Renamed.gblMetaNonDefaults[num4]);
						((Control)this).Controls["_lblV_" + Conversions.ToString((int)num4)].Tag = checked(num4 + 1);
						checked
						{
							num4 = (short)unchecked(num4 + 1);
						}
					}
					((Control)this).Controls["_Line2_" + Conversions.ToString((int)num4)].Visible = true;
					((Control)cmdCancel).Top = ((Control)cmdClose).Top;
					((Control)cmdClose).TabIndex = 999;
					((Control)cmdCancel).TabIndex = 999;
					short num7 = checked((short)(Globals_Renamed.gblNumMetaNonDefaults - 1));
					num4 = 0;
					while (true)
					{
						short num8 = num4;
						short num6 = num7;
						if (num8 > num6)
						{
							break;
						}
						string text = ((Control)this).Controls["_lblV_" + Conversions.ToString((int)num4)].Text;
						object[] array6 = new object[2];
						object[] array7 = array6;
						obj = pMsfParms;
						array7[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "Row", new object[0], (string[])null, (Type[])null, (bool[])null));
						array6[1] = Operators.AddObject(NewLateBinding.LateGet(pMsfParms, (Type)null, "Col", new object[0], (string[])null, (Type[])null, (bool[])null), (object)2);
						array3 = array6;
						object[] array8 = array3;
						array5 = new bool[2] { true, false };
						object obj3 = NewLateBinding.LateGet(pMsfParms, (Type)null, "get_textMatrix", array8, (string[])null, (Type[])null, array5);
						if (array5[0])
						{
							NewLateBinding.LateSetComplex(obj, (Type)null, "Row", new object[1] { RuntimeHelpers.GetObjectValue(array3[0]) }, (string[])null, (Type[])null, true, false);
						}
						if (Operators.ConditionalCompareObjectEqual((object)text, obj3, false))
						{
							((RadioButton)((Control)this).Controls["_optType_" + Conversions.ToString((int)num4)]).Checked = false;
							((RadioButton)((Control)this).Controls["_optType_" + Conversions.ToString((int)num4)]).Checked = true;
							break;
						}
						checked
						{
							num4 = (short)unchecked(num4 + 1);
						}
					}
					short gblNumMetaNonDefaults = Globals_Renamed.gblNumMetaNonDefaults;
					short num9 = myMaxRows;
					num4 = gblNumMetaNonDefaults;
					while (true)
					{
						short num10 = num4;
						short num6 = num9;
						if (num10 > num6)
						{
							break;
						}
						((Control)this).Controls["_optType_" + Conversions.ToString((int)num4)].Visible = false;
						((Control)this).Controls["_lblVC_" + Conversions.ToString((int)num4)].Visible = false;
						((Control)this).Controls["_lblV_" + Conversions.ToString((int)num4)].Visible = false;
						((Control)this).Controls["_Line2_" + Conversions.ToString((int)num4)].Visible = false;
						checked
						{
							num4 = (short)unchecked(num4 + 1);
						}
					}
					flag = true;
					goto end_IL_0001;
				}
				case 1235:
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
			catch (object obj4) when (obj4 is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj4);
				try0001_dispatch = 1235;
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

	private void MakeUmVisible(short x)
	{
		((Control)this).Controls["_optType_" + Conversions.ToString((int)x)].Visible = true;
		((Control)this).Controls["_lblVC_" + Conversions.ToString((int)x)].Visible = true;
		((Control)this).Controls["_lblV_" + Conversions.ToString((int)x)].Visible = true;
		((Control)this).Controls["_Line2_" + Conversions.ToString((int)x)].Visible = true;
	}

	private void optType_CheckedChanged(object eventSender, EventArgs eventArgs)
	{
		if (!Conversions.ToBoolean(NewLateBinding.LateGet(eventSender, (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			return;
		}
		iSelected = checked((short)Conversions.ToInteger(Strings.Mid(Conversions.ToString(NewLateBinding.LateGet(eventSender, (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null)), 10)));
		if (((MyParmID == 72) | (MyParmID == 75)) && Versioned.IsNumeric((object)lblV[iSelected].Text) && Conversions.ToDouble(lblV[iSelected].Text) > 0.0)
		{
			ref short myParmID = ref MyParmID;
			Label val = lblV[iSelected];
			object pValue = val.Text;
			short pModType = 0;
			bool num = ChemStrX.ValidateParmInput(ref myParmID, ref pValue, ref pModType);
			val.Text = Conversions.ToString(pValue);
			if (!num)
			{
				((Control)cmdClose).Enabled = false;
				return;
			}
		}
		((Control)cmdClose).Enabled = true;
	}
}
