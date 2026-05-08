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

internal class frmMDUpdD : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("txtInput")]
	private TextBox _txtInput;

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

	[AccessedThroughProperty("_optType_2")]
	private RadioButton __optType_2;

	[AccessedThroughProperty("_Line2_2")]
	private Label __Line2_2;

	[AccessedThroughProperty("_lblVC_2")]
	private Label __lblVC_2;

	[AccessedThroughProperty("_lblV_2")]
	private Label __lblV_2;

	[AccessedThroughProperty("_optType_3")]
	private RadioButton __optType_3;

	[AccessedThroughProperty("_Line2_3")]
	private Label __Line2_3;

	[AccessedThroughProperty("_lblVC_3")]
	private Label __lblVC_3;

	[AccessedThroughProperty("_lblV_3")]
	private Label __lblV_3;

	[AccessedThroughProperty("_optType_4")]
	private RadioButton __optType_4;

	[AccessedThroughProperty("_Line2_4")]
	private Label __Line2_4;

	[AccessedThroughProperty("_lblVC_4")]
	private Label __lblVC_4;

	[AccessedThroughProperty("_lblV_4")]
	private Label __lblV_4;

	[AccessedThroughProperty("_optType_5")]
	private RadioButton __optType_5;

	[AccessedThroughProperty("_Line2_5")]
	private Label __Line2_5;

	[AccessedThroughProperty("_lblVC_5")]
	private Label __lblVC_5;

	[AccessedThroughProperty("_lblV_5")]
	private Label __lblV_5;

	[AccessedThroughProperty("_optType_6")]
	private RadioButton __optType_6;

	[AccessedThroughProperty("_Line2_6")]
	private Label __Line2_6;

	[AccessedThroughProperty("_lblVC_6")]
	private Label __lblVC_6;

	[AccessedThroughProperty("_lblV_6")]
	private Label __lblV_6;

	[AccessedThroughProperty("_optType_7")]
	private RadioButton __optType_7;

	[AccessedThroughProperty("_Line2_7")]
	private Label __Line2_7;

	[AccessedThroughProperty("_lblVC_7")]
	private Label __lblVC_7;

	[AccessedThroughProperty("_lblV_7")]
	private Label __lblV_7;

	[AccessedThroughProperty("_optType_8")]
	private RadioButton __optType_8;

	[AccessedThroughProperty("_Line2_8")]
	private Label __Line2_8;

	[AccessedThroughProperty("_lblVC_8")]
	private Label __lblVC_8;

	[AccessedThroughProperty("_lblV_8")]
	private Label __lblV_8;

	[AccessedThroughProperty("_optType_9")]
	private RadioButton __optType_9;

	[AccessedThroughProperty("_Line2_9")]
	private Label __Line2_9;

	[AccessedThroughProperty("_lblVC_9")]
	private Label __lblVC_9;

	[AccessedThroughProperty("_lblV_9")]
	private Label __lblV_9;

	[AccessedThroughProperty("optType")]
	private RadioButtonArray _optType;

	private static frmMDUpdD m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	private short MyParmID;

	private short MyModelType;

	private int iSelected;

	private short iUserDef;

	private short SaveRelOrExp;

	private short iColIndex;

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
			EventHandler eventHandler2 = txtInput_TextChanged;
			if (_txtInput != null)
			{
				((Control)_txtInput).Leave -= eventHandler;
				((Control)_txtInput).TextChanged -= eventHandler2;
			}
			_txtInput = value;
			if (_txtInput != null)
			{
				((Control)_txtInput).Leave += eventHandler;
				((Control)_txtInput).TextChanged += eventHandler2;
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

	public static frmMDUpdD DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmMDUpdD();
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

	public frmMDUpdD()
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
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
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
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected O, but got Unknown
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Expected O, but got Unknown
		//IL_0549: Unknown result type (might be due to invalid IL or missing references)
		//IL_0553: Expected O, but got Unknown
		//IL_061c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0626: Expected O, but got Unknown
		//IL_0766: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Expected O, but got Unknown
		//IL_082d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0837: Expected O, but got Unknown
		//IL_0907: Unknown result type (might be due to invalid IL or missing references)
		//IL_0911: Expected O, but got Unknown
		//IL_0a57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a61: Expected O, but got Unknown
		//IL_0b2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b37: Expected O, but got Unknown
		//IL_0c06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c10: Expected O, but got Unknown
		//IL_0cda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce4: Expected O, but got Unknown
		//IL_0dae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db8: Expected O, but got Unknown
		//IL_0e70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7a: Expected O, but got Unknown
		//IL_0fcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd9: Expected O, but got Unknown
		//IL_10a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b0: Expected O, but got Unknown
		//IL_117d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1187: Expected O, but got Unknown
		//IL_12dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e6: Expected O, but got Unknown
		//IL_13b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_13bd: Expected O, but got Unknown
		//IL_148a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1494: Expected O, but got Unknown
		//IL_15e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f3: Expected O, but got Unknown
		//IL_16c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ca: Expected O, but got Unknown
		//IL_1797: Unknown result type (might be due to invalid IL or missing references)
		//IL_17a1: Expected O, but got Unknown
		//IL_18f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1900: Expected O, but got Unknown
		//IL_19cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_19d7: Expected O, but got Unknown
		//IL_1aa4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aae: Expected O, but got Unknown
		//IL_1c03: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c0d: Expected O, but got Unknown
		//IL_1cda: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ce4: Expected O, but got Unknown
		//IL_1db1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dbb: Expected O, but got Unknown
		//IL_1f10: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f1a: Expected O, but got Unknown
		//IL_1fe7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ff1: Expected O, but got Unknown
		//IL_20be: Unknown result type (might be due to invalid IL or missing references)
		//IL_20c8: Expected O, but got Unknown
		//IL_221d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2227: Expected O, but got Unknown
		//IL_22f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_22fe: Expected O, but got Unknown
		//IL_23cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_23d5: Expected O, but got Unknown
		//IL_252a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2534: Expected O, but got Unknown
		//IL_2601: Unknown result type (might be due to invalid IL or missing references)
		//IL_260b: Expected O, but got Unknown
		//IL_26d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_26e2: Expected O, but got Unknown
		//IL_2837: Unknown result type (might be due to invalid IL or missing references)
		//IL_2841: Expected O, but got Unknown
		//IL_290e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2918: Expected O, but got Unknown
		//IL_2da3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dad: Expected O, but got Unknown
		//IL_2dc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dcc: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMDUpdD));
		ToolTip1 = new ToolTip(components);
		txtInput = new TextBox();
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
		_optType_2 = new RadioButton();
		_Line2_2 = new Label();
		_lblVC_2 = new Label();
		_lblV_2 = new Label();
		_optType_3 = new RadioButton();
		_Line2_3 = new Label();
		_lblVC_3 = new Label();
		_lblV_3 = new Label();
		_optType_4 = new RadioButton();
		_Line2_4 = new Label();
		_lblVC_4 = new Label();
		_lblV_4 = new Label();
		_optType_5 = new RadioButton();
		_Line2_5 = new Label();
		_lblVC_5 = new Label();
		_lblV_5 = new Label();
		_optType_6 = new RadioButton();
		_Line2_6 = new Label();
		_lblVC_6 = new Label();
		_lblV_6 = new Label();
		_optType_7 = new RadioButton();
		_Line2_7 = new Label();
		_lblVC_7 = new Label();
		_lblV_7 = new Label();
		_optType_8 = new RadioButton();
		_Line2_8 = new Label();
		_lblVC_8 = new Label();
		_lblV_8 = new Label();
		_optType_9 = new RadioButton();
		_Line2_9 = new Label();
		_lblVC_9 = new Label();
		_lblV_9 = new Label();
		((ISupportInitialize)Label1).BeginInit();
		((ISupportInitialize)Line1).BeginInit();
		((ISupportInitialize)Line2).BeginInit();
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
		Point location = new Point(441, 50);
		((Control)obj).Location = location;
		((TextBoxBase)txtInput).MaxLength = 0;
		((Control)txtInput).Name = "txtInput";
		((Control)txtInput).RightToLeft = (RightToLeft)0;
		TextBox obj2 = txtInput;
		Size size = new Size(91, 20);
		((Control)obj2).Size = size;
		((Control)txtInput).TabIndex = 11;
		((Control)txtInput).Visible = false;
		((ButtonBase)_optType_0).BackColor = SystemColors.Control;
		((Control)_optType_0).Cursor = Cursors.Default;
		((Control)_optType_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optType_0).ForeColor = SystemColors.ControlText;
		optType.SetIndex(_optType_0, (short)0);
		RadioButton optType_ = _optType_0;
		location = new Point(16, 96);
		((Control)optType_).Location = location;
		((Control)_optType_0).Name = "_optType_0";
		((Control)_optType_0).RightToLeft = (RightToLeft)0;
		RadioButton optType_2 = _optType_0;
		size = new Size(89, 17);
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
		Button obj3 = cmdCancel;
		location = new Point(334, 468);
		((Control)obj3).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		((Control)cmdCancel).RightToLeft = (RightToLeft)0;
		Button obj4 = cmdCancel;
		size = new Size(81, 25);
		((Control)obj4).Size = size;
		((Control)cmdCancel).TabIndex = 2;
		((ButtonBase)cmdCancel).Text = "Cancel";
		((ButtonBase)cmdCancel).UseVisualStyleBackColor = false;
		((ButtonBase)cmdClose).BackColor = SystemColors.Control;
		((Control)cmdClose).Cursor = Cursors.Default;
		((Control)cmdClose).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdClose).ForeColor = SystemColors.ControlText;
		Button obj5 = cmdClose;
		location = new Point(238, 468);
		((Control)obj5).Location = location;
		((Control)cmdClose).Name = "cmdClose";
		((Control)cmdClose).RightToLeft = (RightToLeft)0;
		Button obj6 = cmdClose;
		size = new Size(81, 25);
		((Control)obj6).Size = size;
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
		((Control)_Line2_0).TabIndex = 12;
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
		location = new Point(448, 97);
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
		((Control)_Line1_0).TabIndex = 13;
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
		Label obj9 = lblInstructions;
		location = new Point(16, 8);
		((Control)obj9).Location = location;
		((Control)lblInstructions).Name = "lblInstructions";
		((Control)lblInstructions).RightToLeft = (RightToLeft)0;
		Label obj10 = lblInstructions;
		size = new Size(609, 25);
		((Control)obj10).Size = size;
		((Control)lblInstructions).TabIndex = 3;
		lblInstructions.Text = "As appropriate, view or update the Origin for this model parameter.";
		((ButtonBase)_optType_1).BackColor = SystemColors.Control;
		((Control)_optType_1).Cursor = Cursors.Default;
		((Control)_optType_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optType_1).ForeColor = SystemColors.ControlText;
		RadioButton optType_3 = _optType_1;
		location = new Point(16, 130);
		((Control)optType_3).Location = location;
		((Control)_optType_1).Name = "_optType_1";
		((Control)_optType_1).RightToLeft = (RightToLeft)0;
		RadioButton optType_4 = _optType_1;
		size = new Size(89, 17);
		((Control)optType_4).Size = size;
		((Control)_optType_1).TabIndex = 14;
		_optType_1.TabStop = true;
		((ButtonBase)_optType_1).Text = "Default";
		((ButtonBase)_optType_1).UseVisualStyleBackColor = false;
		((Control)_optType_1).Visible = false;
		((Control)_Line2_1).BackColor = SystemColors.WindowText;
		Label line2_3 = _Line2_1;
		location = new Point(8, 154);
		((Control)line2_3).Location = location;
		((Control)_Line2_1).Name = "_Line2_1";
		Label line2_4 = _Line2_1;
		size = new Size(624, 1);
		((Control)line2_4).Size = size;
		((Control)_Line2_1).TabIndex = 18;
		((Control)_Line2_1).Visible = false;
		((Control)_lblVC_1).BackColor = SystemColors.Control;
		((Control)_lblVC_1).Cursor = Cursors.Default;
		((Control)_lblVC_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblVC_1).ForeColor = SystemColors.ControlText;
		Label lblVC_3 = _lblVC_1;
		location = new Point(128, 130);
		((Control)lblVC_3).Location = location;
		((Control)_lblVC_1).Name = "_lblVC_1";
		((Control)_lblVC_1).RightToLeft = (RightToLeft)0;
		Label lblVC_4 = _lblVC_1;
		size = new Size(313, 17);
		((Control)lblVC_4).Size = size;
		((Control)_lblVC_1).TabIndex = 16;
		_lblVC_1.Text = "x";
		((Control)_lblVC_1).Visible = false;
		((Control)_lblV_1).BackColor = SystemColors.Control;
		((Control)_lblV_1).Cursor = Cursors.Default;
		((Control)_lblV_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblV_1).ForeColor = SystemColors.ControlText;
		Label lblV_3 = _lblV_1;
		location = new Point(448, 130);
		((Control)lblV_3).Location = location;
		((Control)_lblV_1).Name = "_lblV_1";
		((Control)_lblV_1).RightToLeft = (RightToLeft)0;
		Label lblV_4 = _lblV_1;
		size = new Size(153, 17);
		((Control)lblV_4).Size = size;
		((Control)_lblV_1).TabIndex = 15;
		_lblV_1.Text = "x";
		((Control)_lblV_1).Visible = false;
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
		((Control)_optType_2).TabIndex = 19;
		_optType_2.TabStop = true;
		((ButtonBase)_optType_2).Text = "Default";
		((ButtonBase)_optType_2).UseVisualStyleBackColor = false;
		((Control)_optType_2).Visible = false;
		((Control)_Line2_2).BackColor = SystemColors.WindowText;
		Label line2_5 = _Line2_2;
		location = new Point(8, 189);
		((Control)line2_5).Location = location;
		((Control)_Line2_2).Name = "_Line2_2";
		Label line2_6 = _Line2_2;
		size = new Size(624, 1);
		((Control)line2_6).Size = size;
		((Control)_Line2_2).TabIndex = 23;
		((Control)_Line2_2).Visible = false;
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
		size = new Size(313, 17);
		((Control)lblVC_6).Size = size;
		((Control)_lblVC_2).TabIndex = 21;
		_lblVC_2.Text = "x";
		((Control)_lblVC_2).Visible = false;
		((Control)_lblV_2).BackColor = SystemColors.Control;
		((Control)_lblV_2).Cursor = Cursors.Default;
		((Control)_lblV_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblV_2).ForeColor = SystemColors.ControlText;
		Label lblV_5 = _lblV_2;
		location = new Point(448, 165);
		((Control)lblV_5).Location = location;
		((Control)_lblV_2).Name = "_lblV_2";
		((Control)_lblV_2).RightToLeft = (RightToLeft)0;
		Label lblV_6 = _lblV_2;
		size = new Size(153, 17);
		((Control)lblV_6).Size = size;
		((Control)_lblV_2).TabIndex = 20;
		_lblV_2.Text = "x";
		((Control)_lblV_2).Visible = false;
		((ButtonBase)_optType_3).BackColor = SystemColors.Control;
		((Control)_optType_3).Cursor = Cursors.Default;
		((Control)_optType_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optType_3).ForeColor = SystemColors.ControlText;
		RadioButton optType_7 = _optType_3;
		location = new Point(16, 200);
		((Control)optType_7).Location = location;
		((Control)_optType_3).Name = "_optType_3";
		((Control)_optType_3).RightToLeft = (RightToLeft)0;
		RadioButton optType_8 = _optType_3;
		size = new Size(89, 17);
		((Control)optType_8).Size = size;
		((Control)_optType_3).TabIndex = 24;
		_optType_3.TabStop = true;
		((ButtonBase)_optType_3).Text = "Default";
		((ButtonBase)_optType_3).UseVisualStyleBackColor = false;
		((Control)_optType_3).Visible = false;
		((Control)_Line2_3).BackColor = SystemColors.WindowText;
		Label line2_7 = _Line2_3;
		location = new Point(8, 224);
		((Control)line2_7).Location = location;
		((Control)_Line2_3).Name = "_Line2_3";
		Label line2_8 = _Line2_3;
		size = new Size(624, 1);
		((Control)line2_8).Size = size;
		((Control)_Line2_3).TabIndex = 28;
		((Control)_Line2_3).Visible = false;
		((Control)_lblVC_3).BackColor = SystemColors.Control;
		((Control)_lblVC_3).Cursor = Cursors.Default;
		((Control)_lblVC_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblVC_3).ForeColor = SystemColors.ControlText;
		Label lblVC_7 = _lblVC_3;
		location = new Point(128, 200);
		((Control)lblVC_7).Location = location;
		((Control)_lblVC_3).Name = "_lblVC_3";
		((Control)_lblVC_3).RightToLeft = (RightToLeft)0;
		Label lblVC_8 = _lblVC_3;
		size = new Size(313, 17);
		((Control)lblVC_8).Size = size;
		((Control)_lblVC_3).TabIndex = 26;
		_lblVC_3.Text = "x";
		((Control)_lblVC_3).Visible = false;
		((Control)_lblV_3).BackColor = SystemColors.Control;
		((Control)_lblV_3).Cursor = Cursors.Default;
		((Control)_lblV_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblV_3).ForeColor = SystemColors.ControlText;
		Label lblV_7 = _lblV_3;
		location = new Point(448, 200);
		((Control)lblV_7).Location = location;
		((Control)_lblV_3).Name = "_lblV_3";
		((Control)_lblV_3).RightToLeft = (RightToLeft)0;
		Label lblV_8 = _lblV_3;
		size = new Size(153, 17);
		((Control)lblV_8).Size = size;
		((Control)_lblV_3).TabIndex = 25;
		_lblV_3.Text = "x";
		((Control)_lblV_3).Visible = false;
		((ButtonBase)_optType_4).BackColor = SystemColors.Control;
		((Control)_optType_4).Cursor = Cursors.Default;
		((Control)_optType_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optType_4).ForeColor = SystemColors.ControlText;
		RadioButton optType_9 = _optType_4;
		location = new Point(16, 235);
		((Control)optType_9).Location = location;
		((Control)_optType_4).Name = "_optType_4";
		((Control)_optType_4).RightToLeft = (RightToLeft)0;
		RadioButton optType_10 = _optType_4;
		size = new Size(89, 17);
		((Control)optType_10).Size = size;
		((Control)_optType_4).TabIndex = 29;
		_optType_4.TabStop = true;
		((ButtonBase)_optType_4).Text = "Default";
		((ButtonBase)_optType_4).UseVisualStyleBackColor = false;
		((Control)_optType_4).Visible = false;
		((Control)_Line2_4).BackColor = SystemColors.WindowText;
		Label line2_9 = _Line2_4;
		location = new Point(8, 259);
		((Control)line2_9).Location = location;
		((Control)_Line2_4).Name = "_Line2_4";
		Label line2_10 = _Line2_4;
		size = new Size(624, 1);
		((Control)line2_10).Size = size;
		((Control)_Line2_4).TabIndex = 33;
		((Control)_Line2_4).Visible = false;
		((Control)_lblVC_4).BackColor = SystemColors.Control;
		((Control)_lblVC_4).Cursor = Cursors.Default;
		((Control)_lblVC_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblVC_4).ForeColor = SystemColors.ControlText;
		Label lblVC_9 = _lblVC_4;
		location = new Point(128, 235);
		((Control)lblVC_9).Location = location;
		((Control)_lblVC_4).Name = "_lblVC_4";
		((Control)_lblVC_4).RightToLeft = (RightToLeft)0;
		Label lblVC_10 = _lblVC_4;
		size = new Size(313, 17);
		((Control)lblVC_10).Size = size;
		((Control)_lblVC_4).TabIndex = 31;
		_lblVC_4.Text = "x";
		((Control)_lblVC_4).Visible = false;
		((Control)_lblV_4).BackColor = SystemColors.Control;
		((Control)_lblV_4).Cursor = Cursors.Default;
		((Control)_lblV_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblV_4).ForeColor = SystemColors.ControlText;
		Label lblV_9 = _lblV_4;
		location = new Point(448, 235);
		((Control)lblV_9).Location = location;
		((Control)_lblV_4).Name = "_lblV_4";
		((Control)_lblV_4).RightToLeft = (RightToLeft)0;
		Label lblV_10 = _lblV_4;
		size = new Size(153, 17);
		((Control)lblV_10).Size = size;
		((Control)_lblV_4).TabIndex = 30;
		_lblV_4.Text = "x";
		((Control)_lblV_4).Visible = false;
		((ButtonBase)_optType_5).BackColor = SystemColors.Control;
		((Control)_optType_5).Cursor = Cursors.Default;
		((Control)_optType_5).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optType_5).ForeColor = SystemColors.ControlText;
		RadioButton optType_11 = _optType_5;
		location = new Point(16, 272);
		((Control)optType_11).Location = location;
		((Control)_optType_5).Name = "_optType_5";
		((Control)_optType_5).RightToLeft = (RightToLeft)0;
		RadioButton optType_12 = _optType_5;
		size = new Size(89, 17);
		((Control)optType_12).Size = size;
		((Control)_optType_5).TabIndex = 34;
		_optType_5.TabStop = true;
		((ButtonBase)_optType_5).Text = "Default";
		((ButtonBase)_optType_5).UseVisualStyleBackColor = false;
		((Control)_optType_5).Visible = false;
		((Control)_Line2_5).BackColor = SystemColors.WindowText;
		Label line2_11 = _Line2_5;
		location = new Point(8, 296);
		((Control)line2_11).Location = location;
		((Control)_Line2_5).Name = "_Line2_5";
		Label line2_12 = _Line2_5;
		size = new Size(624, 1);
		((Control)line2_12).Size = size;
		((Control)_Line2_5).TabIndex = 38;
		((Control)_Line2_5).Visible = false;
		((Control)_lblVC_5).BackColor = SystemColors.Control;
		((Control)_lblVC_5).Cursor = Cursors.Default;
		((Control)_lblVC_5).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblVC_5).ForeColor = SystemColors.ControlText;
		Label lblVC_11 = _lblVC_5;
		location = new Point(128, 272);
		((Control)lblVC_11).Location = location;
		((Control)_lblVC_5).Name = "_lblVC_5";
		((Control)_lblVC_5).RightToLeft = (RightToLeft)0;
		Label lblVC_12 = _lblVC_5;
		size = new Size(313, 17);
		((Control)lblVC_12).Size = size;
		((Control)_lblVC_5).TabIndex = 36;
		_lblVC_5.Text = "x";
		((Control)_lblVC_5).Visible = false;
		((Control)_lblV_5).BackColor = SystemColors.Control;
		((Control)_lblV_5).Cursor = Cursors.Default;
		((Control)_lblV_5).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblV_5).ForeColor = SystemColors.ControlText;
		Label lblV_11 = _lblV_5;
		location = new Point(448, 272);
		((Control)lblV_11).Location = location;
		((Control)_lblV_5).Name = "_lblV_5";
		((Control)_lblV_5).RightToLeft = (RightToLeft)0;
		Label lblV_12 = _lblV_5;
		size = new Size(153, 17);
		((Control)lblV_12).Size = size;
		((Control)_lblV_5).TabIndex = 35;
		_lblV_5.Text = "x";
		((Control)_lblV_5).Visible = false;
		((ButtonBase)_optType_6).BackColor = SystemColors.Control;
		((Control)_optType_6).Cursor = Cursors.Default;
		((Control)_optType_6).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optType_6).ForeColor = SystemColors.ControlText;
		RadioButton optType_13 = _optType_6;
		location = new Point(16, 306);
		((Control)optType_13).Location = location;
		((Control)_optType_6).Name = "_optType_6";
		((Control)_optType_6).RightToLeft = (RightToLeft)0;
		RadioButton optType_14 = _optType_6;
		size = new Size(89, 17);
		((Control)optType_14).Size = size;
		((Control)_optType_6).TabIndex = 39;
		_optType_6.TabStop = true;
		((ButtonBase)_optType_6).Text = "Default";
		((ButtonBase)_optType_6).UseVisualStyleBackColor = false;
		((Control)_optType_6).Visible = false;
		((Control)_Line2_6).BackColor = SystemColors.WindowText;
		Label line2_13 = _Line2_6;
		location = new Point(8, 330);
		((Control)line2_13).Location = location;
		((Control)_Line2_6).Name = "_Line2_6";
		Label line2_14 = _Line2_6;
		size = new Size(624, 1);
		((Control)line2_14).Size = size;
		((Control)_Line2_6).TabIndex = 43;
		((Control)_Line2_6).Visible = false;
		((Control)_lblVC_6).BackColor = SystemColors.Control;
		((Control)_lblVC_6).Cursor = Cursors.Default;
		((Control)_lblVC_6).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblVC_6).ForeColor = SystemColors.ControlText;
		Label lblVC_13 = _lblVC_6;
		location = new Point(128, 306);
		((Control)lblVC_13).Location = location;
		((Control)_lblVC_6).Name = "_lblVC_6";
		((Control)_lblVC_6).RightToLeft = (RightToLeft)0;
		Label lblVC_14 = _lblVC_6;
		size = new Size(313, 17);
		((Control)lblVC_14).Size = size;
		((Control)_lblVC_6).TabIndex = 41;
		_lblVC_6.Text = "x";
		((Control)_lblVC_6).Visible = false;
		((Control)_lblV_6).BackColor = SystemColors.Control;
		((Control)_lblV_6).Cursor = Cursors.Default;
		((Control)_lblV_6).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblV_6).ForeColor = SystemColors.ControlText;
		Label lblV_13 = _lblV_6;
		location = new Point(448, 306);
		((Control)lblV_13).Location = location;
		((Control)_lblV_6).Name = "_lblV_6";
		((Control)_lblV_6).RightToLeft = (RightToLeft)0;
		Label lblV_14 = _lblV_6;
		size = new Size(153, 17);
		((Control)lblV_14).Size = size;
		((Control)_lblV_6).TabIndex = 40;
		_lblV_6.Text = "x";
		((Control)_lblV_6).Visible = false;
		((ButtonBase)_optType_7).BackColor = SystemColors.Control;
		((Control)_optType_7).Cursor = Cursors.Default;
		((Control)_optType_7).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optType_7).ForeColor = SystemColors.ControlText;
		RadioButton optType_15 = _optType_7;
		location = new Point(16, 341);
		((Control)optType_15).Location = location;
		((Control)_optType_7).Name = "_optType_7";
		((Control)_optType_7).RightToLeft = (RightToLeft)0;
		RadioButton optType_16 = _optType_7;
		size = new Size(89, 17);
		((Control)optType_16).Size = size;
		((Control)_optType_7).TabIndex = 44;
		_optType_7.TabStop = true;
		((ButtonBase)_optType_7).Text = "Default";
		((ButtonBase)_optType_7).UseVisualStyleBackColor = false;
		((Control)_optType_7).Visible = false;
		((Control)_Line2_7).BackColor = SystemColors.WindowText;
		Label line2_15 = _Line2_7;
		location = new Point(8, 365);
		((Control)line2_15).Location = location;
		((Control)_Line2_7).Name = "_Line2_7";
		Label line2_16 = _Line2_7;
		size = new Size(624, 1);
		((Control)line2_16).Size = size;
		((Control)_Line2_7).TabIndex = 48;
		((Control)_Line2_7).Visible = false;
		((Control)_lblVC_7).BackColor = SystemColors.Control;
		((Control)_lblVC_7).Cursor = Cursors.Default;
		((Control)_lblVC_7).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblVC_7).ForeColor = SystemColors.ControlText;
		Label lblVC_15 = _lblVC_7;
		location = new Point(128, 341);
		((Control)lblVC_15).Location = location;
		((Control)_lblVC_7).Name = "_lblVC_7";
		((Control)_lblVC_7).RightToLeft = (RightToLeft)0;
		Label lblVC_16 = _lblVC_7;
		size = new Size(313, 17);
		((Control)lblVC_16).Size = size;
		((Control)_lblVC_7).TabIndex = 46;
		_lblVC_7.Text = "x";
		((Control)_lblVC_7).Visible = false;
		((Control)_lblV_7).BackColor = SystemColors.Control;
		((Control)_lblV_7).Cursor = Cursors.Default;
		((Control)_lblV_7).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblV_7).ForeColor = SystemColors.ControlText;
		Label lblV_15 = _lblV_7;
		location = new Point(448, 341);
		((Control)lblV_15).Location = location;
		((Control)_lblV_7).Name = "_lblV_7";
		((Control)_lblV_7).RightToLeft = (RightToLeft)0;
		Label lblV_16 = _lblV_7;
		size = new Size(153, 17);
		((Control)lblV_16).Size = size;
		((Control)_lblV_7).TabIndex = 45;
		_lblV_7.Text = "x";
		((Control)_lblV_7).Visible = false;
		((ButtonBase)_optType_8).BackColor = SystemColors.Control;
		((Control)_optType_8).Cursor = Cursors.Default;
		((Control)_optType_8).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optType_8).ForeColor = SystemColors.ControlText;
		RadioButton optType_17 = _optType_8;
		location = new Point(16, 379);
		((Control)optType_17).Location = location;
		((Control)_optType_8).Name = "_optType_8";
		((Control)_optType_8).RightToLeft = (RightToLeft)0;
		RadioButton optType_18 = _optType_8;
		size = new Size(89, 17);
		((Control)optType_18).Size = size;
		((Control)_optType_8).TabIndex = 49;
		_optType_8.TabStop = true;
		((ButtonBase)_optType_8).Text = "Default";
		((ButtonBase)_optType_8).UseVisualStyleBackColor = false;
		((Control)_optType_8).Visible = false;
		((Control)_Line2_8).BackColor = SystemColors.WindowText;
		Label line2_17 = _Line2_8;
		location = new Point(8, 403);
		((Control)line2_17).Location = location;
		((Control)_Line2_8).Name = "_Line2_8";
		Label line2_18 = _Line2_8;
		size = new Size(624, 1);
		((Control)line2_18).Size = size;
		((Control)_Line2_8).TabIndex = 53;
		((Control)_Line2_8).Visible = false;
		((Control)_lblVC_8).BackColor = SystemColors.Control;
		((Control)_lblVC_8).Cursor = Cursors.Default;
		((Control)_lblVC_8).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblVC_8).ForeColor = SystemColors.ControlText;
		Label lblVC_17 = _lblVC_8;
		location = new Point(128, 379);
		((Control)lblVC_17).Location = location;
		((Control)_lblVC_8).Name = "_lblVC_8";
		((Control)_lblVC_8).RightToLeft = (RightToLeft)0;
		Label lblVC_18 = _lblVC_8;
		size = new Size(313, 17);
		((Control)lblVC_18).Size = size;
		((Control)_lblVC_8).TabIndex = 51;
		_lblVC_8.Text = "x";
		((Control)_lblVC_8).Visible = false;
		((Control)_lblV_8).BackColor = SystemColors.Control;
		((Control)_lblV_8).Cursor = Cursors.Default;
		((Control)_lblV_8).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblV_8).ForeColor = SystemColors.ControlText;
		Label lblV_17 = _lblV_8;
		location = new Point(448, 379);
		((Control)lblV_17).Location = location;
		((Control)_lblV_8).Name = "_lblV_8";
		((Control)_lblV_8).RightToLeft = (RightToLeft)0;
		Label lblV_18 = _lblV_8;
		size = new Size(153, 17);
		((Control)lblV_18).Size = size;
		((Control)_lblV_8).TabIndex = 50;
		_lblV_8.Text = "x";
		((Control)_lblV_8).Visible = false;
		((ButtonBase)_optType_9).BackColor = SystemColors.Control;
		((Control)_optType_9).Cursor = Cursors.Default;
		((Control)_optType_9).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optType_9).ForeColor = SystemColors.ControlText;
		RadioButton optType_19 = _optType_9;
		location = new Point(16, 414);
		((Control)optType_19).Location = location;
		((Control)_optType_9).Name = "_optType_9";
		((Control)_optType_9).RightToLeft = (RightToLeft)0;
		RadioButton optType_20 = _optType_9;
		size = new Size(89, 17);
		((Control)optType_20).Size = size;
		((Control)_optType_9).TabIndex = 54;
		_optType_9.TabStop = true;
		((ButtonBase)_optType_9).Text = "Default";
		((ButtonBase)_optType_9).UseVisualStyleBackColor = false;
		((Control)_optType_9).Visible = false;
		((Control)_Line2_9).BackColor = SystemColors.WindowText;
		Label line2_19 = _Line2_9;
		location = new Point(8, 438);
		((Control)line2_19).Location = location;
		((Control)_Line2_9).Name = "_Line2_9";
		Label line2_20 = _Line2_9;
		size = new Size(624, 1);
		((Control)line2_20).Size = size;
		((Control)_Line2_9).TabIndex = 58;
		((Control)_Line2_9).Visible = false;
		((Control)_lblVC_9).BackColor = SystemColors.Control;
		((Control)_lblVC_9).Cursor = Cursors.Default;
		((Control)_lblVC_9).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblVC_9).ForeColor = SystemColors.ControlText;
		Label lblVC_19 = _lblVC_9;
		location = new Point(128, 414);
		((Control)lblVC_19).Location = location;
		((Control)_lblVC_9).Name = "_lblVC_9";
		((Control)_lblVC_9).RightToLeft = (RightToLeft)0;
		Label lblVC_20 = _lblVC_9;
		size = new Size(313, 17);
		((Control)lblVC_20).Size = size;
		((Control)_lblVC_9).TabIndex = 56;
		_lblVC_9.Text = "x";
		((Control)_lblVC_9).Visible = false;
		((Control)_lblV_9).BackColor = SystemColors.Control;
		((Control)_lblV_9).Cursor = Cursors.Default;
		((Control)_lblV_9).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblV_9).ForeColor = SystemColors.ControlText;
		Label lblV_19 = _lblV_9;
		location = new Point(448, 414);
		((Control)lblV_19).Location = location;
		((Control)_lblV_9).Name = "_lblV_9";
		((Control)_lblV_9).RightToLeft = (RightToLeft)0;
		Label lblV_20 = _lblV_9;
		size = new Size(153, 17);
		((Control)lblV_20).Size = size;
		((Control)_lblV_9).TabIndex = 55;
		_lblV_9.Text = "x";
		((Control)_lblV_9).Visible = false;
		((Form)this).AcceptButton = (IButtonControl)(object)cmdClose;
		size = new Size(5, 13);
		((Form)this).AutoScaleBaseSize = size;
		((Form)this).BackColor = SystemColors.Control;
		((Form)this).CancelButton = (IButtonControl)(object)cmdCancel;
		size = new Size(653, 517);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)txtInput);
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
		((Control)this).Name = "frmMDUpdD";
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
		((Control)this).PerformLayout();
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

	private void cmdCancel_Click(object eventSender, EventArgs eventArgs)
	{
		((Form)this).Close();
	}

	private void cmdClose_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		if (SaveRelOrExp == 0)
		{
			AxMSFlexGrid msfRelParms = frmMDUpdRelMod.DefInstance.msfRelParms;
			msfRelParms[msfRelParms.Row, (int)iColIndex] = ((Control)this).Controls["_optType_" + Conversions.ToString(iSelected)].Text;
			checked
			{
				if ((Conversions.ToDouble(msfRelParms[msfRelParms.Row, 0]) != 137.0) & (Conversions.ToDouble(msfRelParms[msfRelParms.Row, 0]) != 141.0))
				{
					if (iSelected == iUserDef)
					{
						msfRelParms[msfRelParms.Row, iColIndex + 1] = "User-defined";
					}
					else
					{
						msfRelParms[msfRelParms.Row, iColIndex + 1] = "Model Parm";
					}
				}
				msfRelParms[msfRelParms.Row, iColIndex + 2] = ((Control)this).Controls["_lblV_" + Conversions.ToString(iSelected)].Text;
				msfRelParms[msfRelParms.Row, iColIndex + 3] = ((Control)this).Controls["_Line2_" + Conversions.ToString(iSelected)].Text;
				msfRelParms = null;
				short num = (short)(((ComboBox)((Control)frmMDUpdRelMod.DefInstance).Controls["_cmbChar_" + Conversions.ToString(unchecked((int)Globals_Renamed.intDualIndex))]).Items.Count - 1);
				short num2 = 0;
				bool flag = default(bool);
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
						if (Operators.CompareString(Support.GetItemString(((Control)frmMDUpdRelMod.DefInstance).Controls["_cmbChar_" + Conversions.ToString((int)Globals_Renamed.intDualIndex)], (int)num2), ((Control)this).Controls["_lblVC_" + Conversions.ToString(iSelected)].Text, false) == 0)
						{
							((ComboBox)((Control)frmMDUpdRelMod.DefInstance).Controls["_cmbChar_" + Conversions.ToString((int)Globals_Renamed.intDualIndex)]).SelectedIndex = num2;
							flag = true;
							break;
						}
					}
					num2 = (short)unchecked(num2 + 1);
				}
				if (!flag)
				{
					short num5 = (short)(((ComboBox)((Control)frmMDUpdRelMod.DefInstance).Controls["_cmbChar_" + Conversions.ToString(unchecked((int)Globals_Renamed.intDualIndex))]).Items.Count - 1);
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
							if (Operators.CompareString(Strings.Mid(Support.GetItemString(((Control)frmMDUpdRelMod.DefInstance).Controls["_cmbChar_" + Conversions.ToString((int)Globals_Renamed.intDualIndex)], (int)num2), 1, 4), Strings.Mid(((Control)this).Controls["_lblVC_" + Conversions.ToString(iSelected)].Text, 1, 4), false) == 0)
							{
								((ComboBox)((Control)frmMDUpdRelMod.DefInstance).Controls["_cmbChar_" + Conversions.ToString((int)Globals_Renamed.intDualIndex)]).SelectedIndex = num2;
								flag = true;
								break;
							}
						}
						num2 = (short)unchecked(num2 + 1);
					}
				}
				if (!flag)
				{
					short num7 = (short)(((ComboBox)((Control)frmMDUpdRelMod.DefInstance).Controls["_cmbChar_" + Conversions.ToString(unchecked((int)Globals_Renamed.intDualIndex))]).Items.Count - 1);
					num2 = 0;
					while (true)
					{
						short num8 = num2;
						short num4 = num7;
						if (num8 <= num4)
						{
							unchecked
							{
								if (Operators.CompareString(Strings.Mid(Support.GetItemString((Control)(object)frmMDUpdRelMod.DefInstance.cmbChar[Globals_Renamed.intDualIndex], (int)num2), 1, 6), "Output", false) == 0)
								{
									((ComboBox)((Control)frmMDUpdRelMod.DefInstance).Controls["_cmbChar_" + Conversions.ToString((int)Globals_Renamed.intDualIndex)]).SelectedIndex = num2;
									break;
								}
							}
							num2 = (short)unchecked(num2 + 1);
							continue;
						}
						break;
					}
				}
			}
		}
		else
		{
			AxMSFlexGrid msfExpParms = frmMDUpdExpMod.DefInstance.msfExpParms;
			msfExpParms[msfExpParms.Row, (int)iColIndex] = ((Control)this).Controls["_optType_" + Conversions.ToString(iSelected)].Text;
			checked
			{
				if (iSelected == iUserDef)
				{
					msfExpParms[msfExpParms.Row, iColIndex + 1] = "User-defined";
				}
				else
				{
					msfExpParms[msfExpParms.Row, iColIndex + 1] = "Model Parm";
				}
				msfExpParms[msfExpParms.Row, iColIndex + 2] = ((Control)this).Controls["_lblV_" + Conversions.ToString(iSelected)].Text;
				msfExpParms = null;
			}
		}
		((Form)this).Close();
	}

	public bool SetUp(ref short pRelOrExp, ref short pModType, ref short pActID, ref AxMSFlexGrid pMsfParms)
	{
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
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
						int num3 = 0;
						ProjectData.ClearProjectError();
						num2 = 2;
						SaveRelOrExp = pRelOrExp;
						iColIndex = (short)pMsfParms.Col;
						MyParmID = Conversions.ToShort(pMsfParms[pMsfParms.Row, 0]);
						MyModelType = pModType;
						lblParm.Text = ChemStrX.GetParmLabels(ref Globals_Renamed.arOpType[Globals_Renamed.intOpIndex], ref MyParmID);
						Globals_Renamed.intDualIndex = Conversions.ToShort(Interaction.IIf(iColIndex == 2, (object)0, (object)1));
						float modelDefault = ChemStrX.GetModelDefault(-1302, MyParmID, ref MyModelType, ref pActID, ref Globals_Renamed.intModIndex, ref Globals_Renamed.intDualIndex);
						if (modelDefault == -1f)
						{
							modelDefault = 0f;
							((Control)this).Controls["_lblVC_0"].Text = "User Specified";
							((Control)this).Controls["_lblV_0"].Text = "0";
							((Control)this).Controls["_Line2_0"].Text = Conversions.ToString(999);
							((Control)txtInput).Top = ((Control)_lblV_0).Top;
							iUserDef = 0;
							num3 = 1;
						}
						else
						{
							int num4 = Globals_Renamed.gblNumMetaNonDefaults - 1;
							num3 = 0;
							while (true)
							{
								int num5 = num3;
								int num6 = num4;
								if (num5 > num6)
								{
									break;
								}
								if (num3 > 0)
								{
									MakeUmVisible(num3);
								}
								((Control)this).Controls["_lblVC_" + Conversions.ToString(num3)].Text = Conversions.ToString(Globals_Renamed.gblMetaNonDefaultCaps[num3]);
								((Control)this).Controls["_lblV_" + Conversions.ToString(num3)].Text = Conversions.ToString(Globals_Renamed.gblMetaNonDefaults[num3]);
								((Control)this).Controls["_Line2_" + Conversions.ToString(num3)].Text = Conversions.ToString(num3 + 1);
								num3++;
							}
							if ((MyParmID != 137) & (MyParmID != 141))
							{
								MakeUmVisible(num3);
								((Control)this).Controls["_lblVC_" + Conversions.ToString(num3)].Text = "User Specified";
								((Control)this).Controls["_lblV_" + Conversions.ToString(num3)].Text = "0";
								((Control)this).Controls["_Line2_" + Conversions.ToString(num3)].Text = "999";
								((Control)txtInput).Top = ((Control)this).Controls["_lblV_" + Conversions.ToString(num3)].Top;
								iUserDef = (short)num3;
								num3++;
							}
						}
						if ((Operators.CompareString(pMsfParms[pMsfParms.Row, pMsfParms.Col + 1], "User-defined", false) == 0) | (Operators.CompareString(pMsfParms[pMsfParms.Row, pMsfParms.Col + 1], "User Specified", false) == 0))
						{
							txtInput.Text = pMsfParms[pMsfParms.Row, pMsfParms.Col + 2];
							((RadioButton)((Control)this).Controls["_optType_" + Conversions.ToString(unchecked((int)iUserDef))]).Checked = true;
						}
						else
						{
							num3 = 0;
							int num7;
							int num6;
							do
							{
								if (Operators.CompareString(((Control)this).Controls["_lblV_" + Conversions.ToString(num3)].Text, pMsfParms[pMsfParms.Row, pMsfParms.Col + 2], false) == 0)
								{
									((RadioButton)((Control)this).Controls["_optType_" + Conversions.ToString(num3)]).Checked = true;
									break;
								}
								num3++;
								num7 = num3;
								num6 = 9;
							}
							while (num7 <= num6);
						}
						flag = true;
						goto end_IL_0001;
					}
					case 1176:
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
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 1176;
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

	private void MakeUmVisible(int x)
	{
		((Control)this).Controls["_optType_" + Conversions.ToString(x)].Visible = true;
		((Control)this).Controls["_lblVC_" + Conversions.ToString(x)].Visible = true;
		((Control)this).Controls["_lblV_" + Conversions.ToString(x)].Visible = true;
		((Control)this).Controls["_Line2_" + Conversions.ToString(x)].Visible = true;
	}

	private void optType_CheckedChanged(object eventSender, EventArgs eventArgs)
	{
		if (!Conversions.ToBoolean(NewLateBinding.LateGet(eventSender, (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			return;
		}
		int num = Conversions.ToInteger(Strings.Mid(Conversions.ToString(NewLateBinding.LateGet(eventSender, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null)), 10));
		if (((MyParmID == 72) | (MyParmID == 75)) && Versioned.IsNumeric((object)((Control)this).Controls["_lblV_" + Conversions.ToString(num)].Text) && Conversions.ToDouble(((Control)this).Controls["_lblV_" + Conversions.ToString(num)].Text) > 0.0)
		{
			ref short myParmID = ref MyParmID;
			Control val = ((Control)this).Controls["_lblV_" + Conversions.ToString(num)];
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
		if ((MyParmID == 137) | (MyParmID == 141))
		{
			((Control)txtInput).Visible = false;
		}
		else if (num == iUserDef)
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

	private void txtInput_TextChanged(object eventSender, EventArgs eventArgs)
	{
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)txtInput).Visible && Strings.Len(txtInput.Text) > 0)
		{
			if (Versioned.IsNumeric((object)txtInput.Text))
			{
				if ((Operators.CompareString(txtInput.Text, "0", false) != 0) & (Operators.CompareString(txtInput.Text, "0.", false) != 0))
				{
					ValidateTxtInput();
				}
			}
			else
			{
				Interaction.MsgBox((object)"Non-numeric values are not valid.", (MsgBoxStyle)64, (object)"Invalid User Input");
				((TextBoxBase)txtInput).SelectionStart = 0;
				((TextBoxBase)txtInput).SelectionLength = Strings.Len(txtInput.Text);
				((Control)txtInput).Focus();
			}
		}
		((Control)this).Controls["_lblV_" + Conversions.ToString((int)iUserDef)].Text = txtInput.Text;
	}

	private void txtInput_Leave(object eventSender, EventArgs eventArgs)
	{
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (!((Control)txtInput).Visible || Strings.Len(txtInput.Text) <= 0)
		{
			return;
		}
		if (Versioned.IsNumeric((object)txtInput.Text))
		{
			if ((Operators.CompareString(txtInput.Text, "0", false) != 0) & (Operators.CompareString(txtInput.Text, "0.", false) != 0))
			{
				ValidateTxtInput();
			}
		}
		else
		{
			Interaction.MsgBox((object)"Non-numeric values are not valid.", (MsgBoxStyle)64, (object)"Invalid User Input");
			((TextBoxBase)txtInput).SelectionStart = 0;
			((TextBoxBase)txtInput).SelectionLength = Strings.Len(txtInput.Text);
			((Control)txtInput).Focus();
		}
	}
}
