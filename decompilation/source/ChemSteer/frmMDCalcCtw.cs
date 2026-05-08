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

internal class frmMDCalcCtw : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("_txtYctw_3")]
	private TextBox __txtYctw_3;

	[AccessedThroughProperty("_txtYctw_2")]
	private TextBox __txtYctw_2;

	[AccessedThroughProperty("_txtYctw_1")]
	private TextBox __txtYctw_1;

	[AccessedThroughProperty("_txtYctw_0")]
	private TextBox __txtYctw_0;

	[AccessedThroughProperty("txtYctwOther")]
	private TextBox _txtYctwOther;

	[AccessedThroughProperty("_optYctw_3")]
	private RadioButton __optYctw_3;

	[AccessedThroughProperty("_optYctw_2")]
	private RadioButton __optYctw_2;

	[AccessedThroughProperty("_optYctw_1")]
	private RadioButton __optYctw_1;

	[AccessedThroughProperty("_optYctw_0")]
	private RadioButton __optYctw_0;

	[AccessedThroughProperty("fraYctw")]
	private Panel _fraYctw;

	[AccessedThroughProperty("_optRRctw_0")]
	private RadioButton __optRRctw_0;

	[AccessedThroughProperty("_optRRctw_1")]
	private RadioButton __optRRctw_1;

	[AccessedThroughProperty("_optRRctw_2")]
	private RadioButton __optRRctw_2;

	[AccessedThroughProperty("_txtRRctw_0")]
	private TextBox __txtRRctw_0;

	[AccessedThroughProperty("_txtRRctw_1")]
	private TextBox __txtRRctw_1;

	[AccessedThroughProperty("_txtRRctw_2")]
	private TextBox __txtRRctw_2;

	[AccessedThroughProperty("fraRRctw")]
	private Panel _fraRRctw;

	[AccessedThroughProperty("cmdOk")]
	private Button _cmdOk;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("lblInstructions2")]
	private Label _lblInstructions2;

	[AccessedThroughProperty("lblInstructions")]
	private Label _lblInstructions;

	[AccessedThroughProperty("optRRctw")]
	private RadioButtonArray _optRRctw;

	[AccessedThroughProperty("optYctw")]
	private RadioButtonArray _optYctw;

	[AccessedThroughProperty("txtRRctw")]
	private TextBoxArray _txtRRctw;

	[AccessedThroughProperty("txtYctw")]
	private TextBoxArray _txtYctw;

	private static frmMDCalcCtw m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	private short iMyGSS;

	public short iSelected;

	private double[] arMyCtw;

	public virtual TextBox _txtYctw_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtYctw_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _txtYctw_3_TextChanged;
			if (__txtYctw_3 != null)
			{
				((Control)__txtYctw_3).TextChanged -= eventHandler;
			}
			__txtYctw_3 = value;
			if (__txtYctw_3 != null)
			{
				((Control)__txtYctw_3).TextChanged += eventHandler;
			}
		}
	}

	public virtual TextBox _txtYctw_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtYctw_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _txtYctw_2_TextChanged;
			if (__txtYctw_2 != null)
			{
				((Control)__txtYctw_2).TextChanged -= eventHandler;
			}
			__txtYctw_2 = value;
			if (__txtYctw_2 != null)
			{
				((Control)__txtYctw_2).TextChanged += eventHandler;
			}
		}
	}

	public virtual TextBox _txtYctw_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtYctw_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _txtYctw_1_TextChanged;
			if (__txtYctw_1 != null)
			{
				((Control)__txtYctw_1).TextChanged -= eventHandler;
			}
			__txtYctw_1 = value;
			if (__txtYctw_1 != null)
			{
				((Control)__txtYctw_1).TextChanged += eventHandler;
			}
		}
	}

	public virtual TextBox _txtYctw_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtYctw_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _txtYctw_0_TextChanged;
			if (__txtYctw_0 != null)
			{
				((Control)__txtYctw_0).TextChanged -= eventHandler;
			}
			__txtYctw_0 = value;
			if (__txtYctw_0 != null)
			{
				((Control)__txtYctw_0).TextChanged += eventHandler;
			}
		}
	}

	public virtual TextBox txtYctwOther
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtYctwOther;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtYctwOther = value;
		}
	}

	public virtual RadioButton _optYctw_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __optYctw_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _optYctw_3_CheckedChanged;
			if (__optYctw_3 != null)
			{
				__optYctw_3.CheckedChanged -= eventHandler;
			}
			__optYctw_3 = value;
			if (__optYctw_3 != null)
			{
				__optYctw_3.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual RadioButton _optYctw_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __optYctw_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _optYctw_2_CheckedChanged;
			if (__optYctw_2 != null)
			{
				__optYctw_2.CheckedChanged -= eventHandler;
			}
			__optYctw_2 = value;
			if (__optYctw_2 != null)
			{
				__optYctw_2.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual RadioButton _optYctw_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __optYctw_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _optYctw_1_CheckedChanged;
			if (__optYctw_1 != null)
			{
				__optYctw_1.CheckedChanged -= eventHandler;
			}
			__optYctw_1 = value;
			if (__optYctw_1 != null)
			{
				__optYctw_1.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual RadioButton _optYctw_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __optYctw_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _optYctw_0_CheckedChanged;
			if (__optYctw_0 != null)
			{
				__optYctw_0.CheckedChanged -= eventHandler;
			}
			__optYctw_0 = value;
			if (__optYctw_0 != null)
			{
				__optYctw_0.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual Panel fraYctw
	{
		[DebuggerNonUserCode]
		get
		{
			return _fraYctw;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_fraYctw = value;
		}
	}

	public virtual RadioButton _optRRctw_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __optRRctw_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _optRRctw_0_CheckedChanged;
			if (__optRRctw_0 != null)
			{
				__optRRctw_0.CheckedChanged -= eventHandler;
			}
			__optRRctw_0 = value;
			if (__optRRctw_0 != null)
			{
				__optRRctw_0.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual RadioButton _optRRctw_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __optRRctw_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _optRRctw_1_CheckedChanged;
			if (__optRRctw_1 != null)
			{
				__optRRctw_1.CheckedChanged -= eventHandler;
			}
			__optRRctw_1 = value;
			if (__optRRctw_1 != null)
			{
				__optRRctw_1.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual RadioButton _optRRctw_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __optRRctw_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _optRRctw_2_CheckedChanged;
			if (__optRRctw_2 != null)
			{
				__optRRctw_2.CheckedChanged -= eventHandler;
			}
			__optRRctw_2 = value;
			if (__optRRctw_2 != null)
			{
				__optRRctw_2.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual TextBox _txtRRctw_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtRRctw_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _txtRRctw_0_Leave;
			EventHandler eventHandler2 = _txtRRctw_0_Enter;
			if (__txtRRctw_0 != null)
			{
				((Control)__txtRRctw_0).Leave -= eventHandler;
				((Control)__txtRRctw_0).Enter -= eventHandler2;
			}
			__txtRRctw_0 = value;
			if (__txtRRctw_0 != null)
			{
				((Control)__txtRRctw_0).Leave += eventHandler;
				((Control)__txtRRctw_0).Enter += eventHandler2;
			}
		}
	}

	public virtual TextBox _txtRRctw_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtRRctw_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _txtRRctw_1_Leave;
			EventHandler eventHandler2 = _txtRRctw_1_Enter;
			if (__txtRRctw_1 != null)
			{
				((Control)__txtRRctw_1).Leave -= eventHandler;
				((Control)__txtRRctw_1).Enter -= eventHandler2;
			}
			__txtRRctw_1 = value;
			if (__txtRRctw_1 != null)
			{
				((Control)__txtRRctw_1).Leave += eventHandler;
				((Control)__txtRRctw_1).Enter += eventHandler2;
			}
		}
	}

	public virtual TextBox _txtRRctw_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtRRctw_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _txtRRctw_2_Leave;
			EventHandler eventHandler2 = _txtRRctw_2_Enter;
			if (__txtRRctw_2 != null)
			{
				((Control)__txtRRctw_2).Leave -= eventHandler;
				((Control)__txtRRctw_2).Enter -= eventHandler2;
			}
			__txtRRctw_2 = value;
			if (__txtRRctw_2 != null)
			{
				((Control)__txtRRctw_2).Leave += eventHandler;
				((Control)__txtRRctw_2).Enter += eventHandler2;
			}
		}
	}

	public virtual Panel fraRRctw
	{
		[DebuggerNonUserCode]
		get
		{
			return _fraRRctw;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_fraRRctw = value;
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

	public virtual Label lblInstructions2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblInstructions2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblInstructions2 = value;
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

	public virtual RadioButtonArray optRRctw
	{
		[DebuggerNonUserCode]
		get
		{
			return _optRRctw;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = optRRctw_CheckedChanged;
			if (_optRRctw != null)
			{
				_optRRctw.CheckedChanged -= eventHandler;
			}
			_optRRctw = value;
			if (_optRRctw != null)
			{
				_optRRctw.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual RadioButtonArray optYctw
	{
		[DebuggerNonUserCode]
		get
		{
			return _optYctw;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = optYctw_CheckedChanged;
			if (_optYctw != null)
			{
				_optYctw.CheckedChanged -= eventHandler;
			}
			_optYctw = value;
			if (_optYctw != null)
			{
				_optYctw.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual TextBoxArray txtRRctw
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
			EventHandler eventHandler = txtRRctw_Leave;
			EventHandler eventHandler2 = txtRRctw_Enter;
			if (_txtRRctw != null)
			{
				_txtRRctw.Leave -= eventHandler;
				_txtRRctw.Enter -= eventHandler2;
			}
			_txtRRctw = value;
			if (_txtRRctw != null)
			{
				_txtRRctw.Leave += eventHandler;
				_txtRRctw.Enter += eventHandler2;
			}
		}
	}

	public virtual TextBoxArray txtYctw
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
				_txtYctw.TextChanged -= eventHandler;
			}
			_txtYctw = value;
			if (_txtYctw != null)
			{
				_txtYctw.TextChanged += eventHandler;
			}
		}
	}

	public static frmMDCalcCtw DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmMDCalcCtw();
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

	public frmMDCalcCtw()
	{
		((Form)this).Load += frmMDCalcCtw_Load;
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
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Expected O, but got Unknown
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Expected O, but got Unknown
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Expected O, but got Unknown
		//IL_058e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0598: Expected O, but got Unknown
		//IL_068a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0694: Expected O, but got Unknown
		//IL_0785: Unknown result type (might be due to invalid IL or missing references)
		//IL_078f: Expected O, but got Unknown
		//IL_0852: Unknown result type (might be due to invalid IL or missing references)
		//IL_085c: Expected O, but got Unknown
		//IL_0940: Unknown result type (might be due to invalid IL or missing references)
		//IL_094a: Expected O, but got Unknown
		//IL_0a31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3b: Expected O, but got Unknown
		//IL_0b21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2b: Expected O, but got Unknown
		//IL_0c9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca5: Expected O, but got Unknown
		//IL_0d51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5b: Expected O, but got Unknown
		//IL_0e41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4b: Expected O, but got Unknown
		//IL_0f31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3b: Expected O, but got Unknown
		//IL_102e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1038: Expected O, but got Unknown
		//IL_111a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1124: Expected O, but got Unknown
		//IL_1206: Unknown result type (might be due to invalid IL or missing references)
		//IL_1210: Expected O, but got Unknown
		//IL_12d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e2: Expected O, but got Unknown
		//IL_13b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_13c3: Expected O, but got Unknown
		//IL_148d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1497: Expected O, but got Unknown
		//IL_1551: Unknown result type (might be due to invalid IL or missing references)
		//IL_155b: Expected O, but got Unknown
		//IL_16ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_16b7: Expected O, but got Unknown
		//IL_16cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d6: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMDCalcCtw));
		ToolTip1 = new ToolTip(components);
		fraYctw = new Panel();
		_txtYctw_3 = new TextBox();
		_txtYctw_2 = new TextBox();
		_txtYctw_1 = new TextBox();
		_txtYctw_0 = new TextBox();
		txtYctwOther = new TextBox();
		_optYctw_3 = new RadioButton();
		_optYctw_2 = new RadioButton();
		_optYctw_1 = new RadioButton();
		_optYctw_0 = new RadioButton();
		fraRRctw = new Panel();
		_optRRctw_0 = new RadioButton();
		_optRRctw_1 = new RadioButton();
		_optRRctw_2 = new RadioButton();
		_txtRRctw_0 = new TextBox();
		_txtRRctw_1 = new TextBox();
		_txtRRctw_2 = new TextBox();
		cmdOk = new Button();
		cmdCancel = new Button();
		lblInstructions2 = new Label();
		lblInstructions = new Label();
		optRRctw = new RadioButtonArray(components);
		optYctw = new RadioButtonArray(components);
		txtRRctw = new TextBoxArray(components);
		txtYctw = new TextBoxArray(components);
		((Control)fraYctw).SuspendLayout();
		((Control)fraRRctw).SuspendLayout();
		((ISupportInitialize)optRRctw).BeginInit();
		((ISupportInitialize)optYctw).BeginInit();
		((ISupportInitialize)txtRRctw).BeginInit();
		((ISupportInitialize)txtYctw).BeginInit();
		((Control)this).SuspendLayout();
		((Control)fraYctw).BackColor = SystemColors.Control;
		((Control)fraYctw).Controls.Add((Control)(object)_txtYctw_3);
		((Control)fraYctw).Controls.Add((Control)(object)_txtYctw_2);
		((Control)fraYctw).Controls.Add((Control)(object)_txtYctw_1);
		((Control)fraYctw).Controls.Add((Control)(object)_txtYctw_0);
		((Control)fraYctw).Controls.Add((Control)(object)txtYctwOther);
		((Control)fraYctw).Controls.Add((Control)(object)_optYctw_3);
		((Control)fraYctw).Controls.Add((Control)(object)_optYctw_2);
		((Control)fraYctw).Controls.Add((Control)(object)_optYctw_1);
		((Control)fraYctw).Controls.Add((Control)(object)_optYctw_0);
		((Control)fraYctw).Cursor = Cursors.Default;
		((Control)fraYctw).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)fraYctw).ForeColor = SystemColors.ControlText;
		Panel obj = fraYctw;
		Point location = new Point(56, 64);
		((Control)obj).Location = location;
		((Control)fraYctw).Name = "fraYctw";
		((Control)fraYctw).RightToLeft = (RightToLeft)0;
		Panel obj2 = fraYctw;
		Size size = new Size(433, 153);
		((Control)obj2).Size = size;
		((Control)fraYctw).TabIndex = 18;
		_txtYctw_3.AcceptsReturn = true;
		((TextBoxBase)_txtYctw_3).BackColor = Color.FromArgb(192, 192, 192);
		((Control)_txtYctw_3).Cursor = Cursors.IBeam;
		((Control)_txtYctw_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtYctw_3).ForeColor = SystemColors.WindowText;
		txtYctw.SetIndex(_txtYctw_3, (short)3);
		TextBox txtYctw_ = _txtYctw_3;
		location = new Point(344, 120);
		((Control)txtYctw_).Location = location;
		((TextBoxBase)_txtYctw_3).MaxLength = 0;
		((Control)_txtYctw_3).Name = "_txtYctw_3";
		((TextBoxBase)_txtYctw_3).ReadOnly = true;
		((Control)_txtYctw_3).RightToLeft = (RightToLeft)0;
		TextBox txtYctw_2 = _txtYctw_3;
		size = new Size(73, 20);
		((Control)txtYctw_2).Size = size;
		((Control)_txtYctw_3).TabIndex = 14;
		_txtYctw_2.AcceptsReturn = true;
		((TextBoxBase)_txtYctw_2).BackColor = Color.FromArgb(192, 192, 192);
		((Control)_txtYctw_2).Cursor = Cursors.IBeam;
		((Control)_txtYctw_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtYctw_2).ForeColor = SystemColors.WindowText;
		txtYctw.SetIndex(_txtYctw_2, (short)2);
		TextBox txtYctw_3 = _txtYctw_2;
		location = new Point(344, 88);
		((Control)txtYctw_3).Location = location;
		((TextBoxBase)_txtYctw_2).MaxLength = 0;
		((Control)_txtYctw_2).Name = "_txtYctw_2";
		((TextBoxBase)_txtYctw_2).ReadOnly = true;
		((Control)_txtYctw_2).RightToLeft = (RightToLeft)0;
		TextBox txtYctw_4 = _txtYctw_2;
		size = new Size(73, 20);
		((Control)txtYctw_4).Size = size;
		((Control)_txtYctw_2).TabIndex = 11;
		_txtYctw_1.AcceptsReturn = true;
		((TextBoxBase)_txtYctw_1).BackColor = Color.FromArgb(192, 192, 192);
		((Control)_txtYctw_1).Cursor = Cursors.IBeam;
		((Control)_txtYctw_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtYctw_1).ForeColor = SystemColors.WindowText;
		txtYctw.SetIndex(_txtYctw_1, (short)1);
		TextBox txtYctw_5 = _txtYctw_1;
		location = new Point(344, 56);
		((Control)txtYctw_5).Location = location;
		((TextBoxBase)_txtYctw_1).MaxLength = 0;
		((Control)_txtYctw_1).Name = "_txtYctw_1";
		((TextBoxBase)_txtYctw_1).ReadOnly = true;
		((Control)_txtYctw_1).RightToLeft = (RightToLeft)0;
		TextBox txtYctw_6 = _txtYctw_1;
		size = new Size(73, 20);
		((Control)txtYctw_6).Size = size;
		((Control)_txtYctw_1).TabIndex = 9;
		_txtYctw_0.AcceptsReturn = true;
		((TextBoxBase)_txtYctw_0).BackColor = Color.FromArgb(192, 192, 192);
		((Control)_txtYctw_0).Cursor = Cursors.IBeam;
		((Control)_txtYctw_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtYctw_0).ForeColor = SystemColors.WindowText;
		txtYctw.SetIndex(_txtYctw_0, (short)0);
		TextBox txtYctw_7 = _txtYctw_0;
		location = new Point(344, 24);
		((Control)txtYctw_7).Location = location;
		((TextBoxBase)_txtYctw_0).MaxLength = 0;
		((Control)_txtYctw_0).Name = "_txtYctw_0";
		((TextBoxBase)_txtYctw_0).ReadOnly = true;
		((Control)_txtYctw_0).RightToLeft = (RightToLeft)0;
		TextBox txtYctw_8 = _txtYctw_0;
		size = new Size(73, 20);
		((Control)txtYctw_8).Size = size;
		((Control)_txtYctw_0).TabIndex = 7;
		txtYctwOther.AcceptsReturn = true;
		((TextBoxBase)txtYctwOther).BackColor = Color.FromArgb(192, 192, 192);
		((Control)txtYctwOther).Cursor = Cursors.IBeam;
		((Control)txtYctwOther).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtYctwOther).ForeColor = SystemColors.WindowText;
		TextBox obj3 = txtYctwOther;
		location = new Point(72, 120);
		((Control)obj3).Location = location;
		((TextBoxBase)txtYctwOther).MaxLength = 0;
		((Control)txtYctwOther).Name = "txtYctwOther";
		((TextBoxBase)txtYctwOther).ReadOnly = true;
		((Control)txtYctwOther).RightToLeft = (RightToLeft)0;
		TextBox obj4 = txtYctwOther;
		size = new Size(217, 20);
		((Control)obj4).Size = size;
		((Control)txtYctwOther).TabIndex = 13;
		((ButtonBase)_optYctw_3).BackColor = SystemColors.Control;
		((Control)_optYctw_3).Cursor = Cursors.Default;
		((Control)_optYctw_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optYctw_3).ForeColor = SystemColors.ControlText;
		optYctw.SetIndex(_optYctw_3, (short)3);
		RadioButton optYctw_ = _optYctw_3;
		location = new Point(16, 120);
		((Control)optYctw_).Location = location;
		((Control)_optYctw_3).Name = "_optYctw_3";
		((Control)_optYctw_3).RightToLeft = (RightToLeft)0;
		RadioButton optYctw_2 = _optYctw_3;
		size = new Size(65, 25);
		((Control)optYctw_2).Size = size;
		((Control)_optYctw_3).TabIndex = 12;
		_optYctw_3.TabStop = true;
		((ButtonBase)_optYctw_3).Text = "Other:";
		((ButtonBase)_optYctw_3).UseVisualStyleBackColor = false;
		((ButtonBase)_optYctw_2).BackColor = SystemColors.Control;
		((Control)_optYctw_2).Cursor = Cursors.Default;
		((Control)_optYctw_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optYctw_2).ForeColor = SystemColors.ControlText;
		optYctw.SetIndex(_optYctw_2, (short)2);
		RadioButton optYctw_3 = _optYctw_2;
		location = new Point(16, 88);
		((Control)optYctw_3).Location = location;
		((Control)_optYctw_2).Name = "_optYctw_2";
		((Control)_optYctw_2).RightToLeft = (RightToLeft)0;
		RadioButton optYctw_4 = _optYctw_2;
		size = new Size(289, 25);
		((Control)optYctw_4).Size = size;
		((Control)_optYctw_2).TabIndex = 10;
		_optYctw_2.TabStop = true;
		((ButtonBase)_optYctw_2).Text = "Scale Control (expected range: 1 to 5 ppm)";
		((ButtonBase)_optYctw_2).UseVisualStyleBackColor = false;
		((ButtonBase)_optYctw_1).BackColor = SystemColors.Control;
		((Control)_optYctw_1).Cursor = Cursors.Default;
		((Control)_optYctw_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optYctw_1).ForeColor = SystemColors.ControlText;
		optYctw.SetIndex(_optYctw_1, (short)1);
		RadioButton optYctw_5 = _optYctw_1;
		location = new Point(16, 56);
		((Control)optYctw_5).Location = location;
		((Control)_optYctw_1).Name = "_optYctw_1";
		((Control)_optYctw_1).RightToLeft = (RightToLeft)0;
		RadioButton optYctw_6 = _optYctw_1;
		size = new Size(289, 25);
		((Control)optYctw_6).Size = size;
		((Control)_optYctw_1).TabIndex = 8;
		_optYctw_1.TabStop = true;
		((ButtonBase)_optYctw_1).Text = "Microorganism Control (expected range: 1 - 20 ppm)";
		((ButtonBase)_optYctw_1).UseVisualStyleBackColor = false;
		((ButtonBase)_optYctw_0).BackColor = SystemColors.Control;
		((Control)_optYctw_0).Cursor = Cursors.Default;
		((Control)_optYctw_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optYctw_0).ForeColor = SystemColors.ControlText;
		optYctw.SetIndex(_optYctw_0, (short)0);
		RadioButton optYctw_7 = _optYctw_0;
		location = new Point(16, 24);
		((Control)optYctw_7).Location = location;
		((Control)_optYctw_0).Name = "_optYctw_0";
		((Control)_optYctw_0).RightToLeft = (RightToLeft)0;
		RadioButton optYctw_8 = _optYctw_0;
		size = new Size(289, 25);
		((Control)optYctw_8).Size = size;
		((Control)_optYctw_0).TabIndex = 6;
		_optYctw_0.TabStop = true;
		((ButtonBase)_optYctw_0).Text = "Corrosion Control (expected range: 50 - 1000 ppm)";
		((ButtonBase)_optYctw_0).UseVisualStyleBackColor = false;
		((Control)fraRRctw).BackColor = SystemColors.Control;
		((Control)fraRRctw).Controls.Add((Control)(object)_optRRctw_0);
		((Control)fraRRctw).Controls.Add((Control)(object)_optRRctw_1);
		((Control)fraRRctw).Controls.Add((Control)(object)_optRRctw_2);
		((Control)fraRRctw).Controls.Add((Control)(object)_txtRRctw_0);
		((Control)fraRRctw).Controls.Add((Control)(object)_txtRRctw_1);
		((Control)fraRRctw).Controls.Add((Control)(object)_txtRRctw_2);
		((Control)fraRRctw).Cursor = Cursors.Default;
		((Control)fraRRctw).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)fraRRctw).ForeColor = SystemColors.ControlText;
		Panel obj5 = fraRRctw;
		location = new Point(56, 64);
		((Control)obj5).Location = location;
		((Control)fraRRctw).Name = "fraRRctw";
		((Control)fraRRctw).RightToLeft = (RightToLeft)0;
		Panel obj6 = fraRRctw;
		size = new Size(441, 153);
		((Control)obj6).Size = size;
		((Control)fraRRctw).TabIndex = 20;
		((ButtonBase)_optRRctw_0).BackColor = SystemColors.Control;
		((Control)_optRRctw_0).Cursor = Cursors.Default;
		((Control)_optRRctw_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optRRctw_0).ForeColor = SystemColors.ControlText;
		optRRctw.SetIndex(_optRRctw_0, (short)0);
		RadioButton optRRctw_ = _optRRctw_0;
		location = new Point(16, 24);
		((Control)optRRctw_).Location = location;
		((Control)_optRRctw_0).Name = "_optRRctw_0";
		((Control)_optRRctw_0).RightToLeft = (RightToLeft)0;
		RadioButton optRRctw_2 = _optRRctw_0;
		size = new Size(289, 25);
		((Control)optRRctw_2).Size = size;
		((Control)_optRRctw_0).TabIndex = 0;
		_optRRctw_0.TabStop = true;
		((ButtonBase)_optRRctw_0).Text = "Moderately-sized tower water recirculation rate (gpm)";
		((ButtonBase)_optRRctw_0).UseVisualStyleBackColor = false;
		((ButtonBase)_optRRctw_1).BackColor = SystemColors.Control;
		((Control)_optRRctw_1).Cursor = Cursors.Default;
		((Control)_optRRctw_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optRRctw_1).ForeColor = SystemColors.ControlText;
		optRRctw.SetIndex(_optRRctw_1, (short)1);
		RadioButton optRRctw_3 = _optRRctw_1;
		location = new Point(16, 56);
		((Control)optRRctw_3).Location = location;
		((Control)_optRRctw_1).Name = "_optRRctw_1";
		((Control)_optRRctw_1).RightToLeft = (RightToLeft)0;
		RadioButton optRRctw_4 = _optRRctw_1;
		size = new Size(289, 25);
		((Control)optRRctw_4).Size = size;
		((Control)_optRRctw_1).TabIndex = 2;
		_optRRctw_1.TabStop = true;
		((ButtonBase)_optRRctw_1).Text = "Large-sized tower water recirculation rate (gpm)";
		((ButtonBase)_optRRctw_1).UseVisualStyleBackColor = false;
		((ButtonBase)_optRRctw_2).BackColor = SystemColors.Control;
		((Control)_optRRctw_2).Cursor = Cursors.Default;
		((Control)_optRRctw_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_optRRctw_2).ForeColor = SystemColors.ControlText;
		optRRctw.SetIndex(_optRRctw_2, (short)2);
		RadioButton optRRctw_5 = _optRRctw_2;
		location = new Point(16, 88);
		((Control)optRRctw_5).Location = location;
		((Control)_optRRctw_2).Name = "_optRRctw_2";
		((Control)_optRRctw_2).RightToLeft = (RightToLeft)0;
		RadioButton optRRctw_6 = _optRRctw_2;
		size = new Size(289, 25);
		((Control)optRRctw_6).Size = size;
		((Control)_optRRctw_2).TabIndex = 4;
		_optRRctw_2.TabStop = true;
		((ButtonBase)_optRRctw_2).Text = "Other size tower water recirculation rate (gpm)";
		((ButtonBase)_optRRctw_2).UseVisualStyleBackColor = false;
		_txtRRctw_0.AcceptsReturn = true;
		((TextBoxBase)_txtRRctw_0).BackColor = SystemColors.Control;
		((Control)_txtRRctw_0).Cursor = Cursors.IBeam;
		((Control)_txtRRctw_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtRRctw_0).ForeColor = SystemColors.WindowText;
		txtRRctw.SetIndex(_txtRRctw_0, (short)0);
		TextBox txtRRctw_ = _txtRRctw_0;
		location = new Point(352, 24);
		((Control)txtRRctw_).Location = location;
		((TextBoxBase)_txtRRctw_0).MaxLength = 0;
		((Control)_txtRRctw_0).Name = "_txtRRctw_0";
		((TextBoxBase)_txtRRctw_0).ReadOnly = true;
		((Control)_txtRRctw_0).RightToLeft = (RightToLeft)0;
		TextBox txtRRctw_2 = _txtRRctw_0;
		size = new Size(73, 20);
		((Control)txtRRctw_2).Size = size;
		((Control)_txtRRctw_0).TabIndex = 1;
		_txtRRctw_1.AcceptsReturn = true;
		((TextBoxBase)_txtRRctw_1).BackColor = SystemColors.Control;
		((Control)_txtRRctw_1).Cursor = Cursors.IBeam;
		((Control)_txtRRctw_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtRRctw_1).ForeColor = SystemColors.WindowText;
		txtRRctw.SetIndex(_txtRRctw_1, (short)1);
		TextBox txtRRctw_3 = _txtRRctw_1;
		location = new Point(352, 56);
		((Control)txtRRctw_3).Location = location;
		((TextBoxBase)_txtRRctw_1).MaxLength = 0;
		((Control)_txtRRctw_1).Name = "_txtRRctw_1";
		((TextBoxBase)_txtRRctw_1).ReadOnly = true;
		((Control)_txtRRctw_1).RightToLeft = (RightToLeft)0;
		TextBox txtRRctw_4 = _txtRRctw_1;
		size = new Size(73, 20);
		((Control)txtRRctw_4).Size = size;
		((Control)_txtRRctw_1).TabIndex = 3;
		_txtRRctw_2.AcceptsReturn = true;
		((TextBoxBase)_txtRRctw_2).BackColor = SystemColors.Control;
		((Control)_txtRRctw_2).Cursor = Cursors.IBeam;
		((Control)_txtRRctw_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtRRctw_2).ForeColor = SystemColors.WindowText;
		txtRRctw.SetIndex(_txtRRctw_2, (short)2);
		TextBox txtRRctw_5 = _txtRRctw_2;
		location = new Point(352, 88);
		((Control)txtRRctw_5).Location = location;
		((TextBoxBase)_txtRRctw_2).MaxLength = 0;
		((Control)_txtRRctw_2).Name = "_txtRRctw_2";
		((Control)_txtRRctw_2).RightToLeft = (RightToLeft)0;
		TextBox txtRRctw_6 = _txtRRctw_2;
		size = new Size(73, 20);
		((Control)txtRRctw_6).Size = size;
		((Control)_txtRRctw_2).TabIndex = 5;
		((ButtonBase)cmdOk).BackColor = SystemColors.Control;
		((Control)cmdOk).Cursor = Cursors.Default;
		((Control)cmdOk).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdOk).ForeColor = SystemColors.ControlText;
		Button obj7 = cmdOk;
		location = new Point(176, 232);
		((Control)obj7).Location = location;
		((Control)cmdOk).Name = "cmdOk";
		((Control)cmdOk).RightToLeft = (RightToLeft)0;
		Button obj8 = cmdOk;
		size = new Size(97, 25);
		((Control)obj8).Size = size;
		((Control)cmdOk).TabIndex = 15;
		((ButtonBase)cmdOk).Text = "OK";
		((ButtonBase)cmdOk).UseVisualStyleBackColor = false;
		((ButtonBase)cmdCancel).BackColor = SystemColors.Control;
		((Control)cmdCancel).Cursor = Cursors.Default;
		cmdCancel.DialogResult = (DialogResult)2;
		((Control)cmdCancel).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCancel).ForeColor = SystemColors.ControlText;
		Button obj9 = cmdCancel;
		location = new Point(296, 232);
		((Control)obj9).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		((Control)cmdCancel).RightToLeft = (RightToLeft)0;
		Button obj10 = cmdCancel;
		size = new Size(97, 25);
		((Control)obj10).Size = size;
		((Control)cmdCancel).TabIndex = 16;
		((ButtonBase)cmdCancel).Text = "Cancel";
		((ButtonBase)cmdCancel).UseVisualStyleBackColor = false;
		((Control)lblInstructions2).BackColor = SystemColors.Control;
		((Control)lblInstructions2).Cursor = Cursors.Default;
		((Control)lblInstructions2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblInstructions2).ForeColor = SystemColors.ControlText;
		Label obj11 = lblInstructions2;
		location = new Point(16, 32);
		((Control)obj11).Location = location;
		((Control)lblInstructions2).Name = "lblInstructions2";
		((Control)lblInstructions2).RightToLeft = (RightToLeft)0;
		Label obj12 = lblInstructions2;
		size = new Size(433, 25);
		((Control)obj12).Size = size;
		((Control)lblInstructions2).TabIndex = 19;
		lblInstructions2.Text = "x";
		((Control)lblInstructions).BackColor = SystemColors.Control;
		((Control)lblInstructions).Cursor = Cursors.Default;
		((Control)lblInstructions).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblInstructions).ForeColor = SystemColors.ControlText;
		Label obj13 = lblInstructions;
		location = new Point(16, 8);
		((Control)obj13).Location = location;
		((Control)lblInstructions).Name = "lblInstructions";
		((Control)lblInstructions).RightToLeft = (RightToLeft)0;
		Label obj14 = lblInstructions;
		size = new Size(433, 41);
		((Control)obj14).Size = size;
		((Control)lblInstructions).TabIndex = 17;
		lblInstructions.Text = "x";
		size = new Size(5, 13);
		((Form)this).AutoScaleBaseSize = size;
		((Form)this).BackColor = SystemColors.Control;
		((Form)this).CancelButton = (IButtonControl)(object)cmdCancel;
		size = new Size(572, 283);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)fraRRctw);
		((Control)this).Controls.Add((Control)(object)cmdOk);
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)lblInstructions2);
		((Control)this).Controls.Add((Control)(object)lblInstructions);
		((Control)this).Controls.Add((Control)(object)fraYctw);
		((Control)this).Cursor = Cursors.Default;
		((Control)this).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		location = new Point(250, 150);
		((Form)this).Location = location;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmMDCalcCtw";
		((Control)this).RightToLeft = (RightToLeft)0;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "View/Update Yctw";
		((Control)fraYctw).ResumeLayout(false);
		((Control)fraYctw).PerformLayout();
		((Control)fraRRctw).ResumeLayout(false);
		((Control)fraRRctw).PerformLayout();
		((ISupportInitialize)optRRctw).EndInit();
		((ISupportInitialize)optYctw).EndInit();
		((ISupportInitialize)txtRRctw).EndInit();
		((ISupportInitialize)txtYctw).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void cmdCancel_Click(object eventSender, EventArgs eventArgs)
	{
		((Control)this).Tag = "Cancel";
		((Control)this).Hide();
	}

	private void cmdOk_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)fraYctw).Visible)
		{
			if (!Versioned.IsNumeric((object)((Control)fraYctw).Controls["_txtYctw_" + Conversions.ToString((int)iSelected)].Text))
			{
				Interaction.MsgBox((object)"Please specify the concentration of the cooling tower additive.", (MsgBoxStyle)64, (object)null);
				return;
			}
			frmMDCalcXmoProd.DefInstance.txtYctw.Text = ((Control)fraYctw).Controls["_txtYctw_" + Conversions.ToString((int)iSelected)].Text;
		}
		else if (((Control)fraRRctw).Visible)
		{
			if (!Versioned.IsNumeric((object)((Control)fraRRctw).Controls["_txtRRctw_" + Conversions.ToString((int)iSelected)].Text))
			{
				Interaction.MsgBox((object)"Please specify the water recirculation rate.", (MsgBoxStyle)64, (object)null);
				return;
			}
			frmMDCalcXmoProd.DefInstance.txtRRctw.Text = ((Control)fraRRctw).Controls["_txtRRctw_" + Conversions.ToString((int)iSelected)].Text;
		}
		((Control)this).Tag = "";
		((Control)this).Hide();
	}

	private void frmMDCalcCtw_Load(object eventSender, EventArgs eventArgs)
	{
	}

	public bool SetUp(ref short pID, ref object pOption)
	{
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
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
					ProjectData.ClearProjectError();
					num2 = 2;
					((Form)this).Text = "Calculate " + Globals_Renamed.arParmNames[pID];
					if (pID == 124)
					{
						lblInstructions.Text = "Select or enter an alternative chemical function/concentration within the cooling tower.";
						lblInstructions2.Text = "Be sure to enter a dimensionless weight fraction for Yctw.";
						((Control)fraYctw).Visible = true;
						((Control)fraRRctw).Visible = false;
						arMyCtw = new double[5];
						short num3 = 0;
						short num4;
						short num5;
						do
						{
							if (Operators.ConditionalCompareObjectEqual((object)num3, pOption, false))
							{
								arMyCtw[Conversions.ToInteger(pOption)] = Conversions.ToDouble(Common.MyNullCheck0(frmMDCalcXmoProd.DefInstance.txtYctw.Text));
								if (Operators.ConditionalCompareObjectEqual(pOption, (object)3, false))
								{
									txtYctwOther.Text = frmMDUpdOpIP.DefInstance.sYctwOther;
								}
							}
							else if (arMyCtw[num3] == 0.0)
							{
								switch (num3)
								{
								case 0:
									arMyCtw[num3] = 0.001;
									break;
								case 1:
									arMyCtw[num3] = 2E-05;
									break;
								case 2:
									arMyCtw[num3] = 5E-06;
									break;
								}
							}
							else
							{
								arMyCtw[num3] = Conversions.ToDouble(ChemStrX.ShowInSciNot(arMyCtw[num3]));
							}
							((Control)fraYctw).Controls["_txtYctw_" + Conversions.ToString((int)num3)].Text = ChemStrX.ShowZeroAsNull(arMyCtw[num3]);
							checked
							{
								num3 = (short)unchecked(num3 + 1);
								num4 = num3;
								num5 = 3;
							}
						}
						while (num4 <= num5);
						((RadioButton)NewLateBinding.LateGet((object)((Control)fraYctw).Controls, (Type)null, "Item", new object[1] { Operators.ConcatenateObject((object)"_optYctw_", pOption) }, (string[])null, (Type[])null, (bool[])null)).Checked = true;
					}
					else if (pID == 126)
					{
						lblInstructions.Text = "Select or enter an alternative water recirculation rate within the cooling tower.";
						lblInstructions2.Text = "Be sure to enter a value for RRctw in gallons per minute (gpm).";
						((Control)fraYctw).Visible = false;
						((Control)fraRRctw).Visible = true;
						arMyCtw = new double[4];
						short num3 = 0;
						short num6;
						short num5;
						do
						{
							if (Operators.ConditionalCompareObjectEqual((object)num3, pOption, false))
							{
								arMyCtw[Conversions.ToInteger(pOption)] = Conversions.ToDouble(Common.MyNullCheck0(frmMDCalcXmoProd.DefInstance.txtRRctw.Text));
							}
							else if (arMyCtw[num3] == 0.0)
							{
								switch (num3)
								{
								case 0:
									arMyCtw[num3] = 2000.0;
									break;
								case 1:
									arMyCtw[num3] = 100000.0;
									break;
								}
							}
							else
							{
								arMyCtw[num3] = Conversions.ToDouble(ChemStrX.ShowInSciNot(arMyCtw[num3]));
							}
							((Control)fraRRctw).Controls["_txtRRctw_" + Conversions.ToString((int)num3)].Text = ChemStrX.ShowZeroAsNull(arMyCtw[num3]);
							checked
							{
								num3 = (short)unchecked(num3 + 1);
								num6 = num3;
								num5 = 2;
							}
						}
						while (num6 <= num5);
						((RadioButton)NewLateBinding.LateGet((object)((Control)fraRRctw).Controls, (Type)null, "Item", new object[1] { Operators.ConcatenateObject((object)"_optRRctw_", pOption) }, (string[])null, (Type[])null, (bool[])null)).Checked = true;
					}
					flag = true;
					goto end_IL_0001;
				case 1025:
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
				try0001_dispatch = 1025;
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

	private void CheckoptRRctw(short index)
	{
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		iSelected = index;
		short num = 0;
		short num2;
		short num3;
		do
		{
			if (num == index)
			{
				((Control)fraRRctw).Controls["_txtRRctw_" + Conversions.ToString((int)num)].BackColor = Color.White;
				if (num == 2)
				{
					((TextBoxBase)(TextBox)((Control)fraRRctw).Controls["_txtRRctw_" + Conversions.ToString((int)num)]).ReadOnly = false;
				}
				((Control)fraRRctw).Controls["_txtRRctw_" + Conversions.ToString((int)num)].Text = ChemStrX.ShowZeroAsNull(arMyCtw[num]);
			}
			else
			{
				((Control)fraRRctw).Controls["_txtRRctw_" + Conversions.ToString((int)num)].BackColor = ColorTranslator.FromOle(-2147483633);
				((TextBoxBase)(TextBox)((Control)fraRRctw).Controls["_txtRRctw_" + Conversions.ToString((int)num)]).ReadOnly = true;
			}
			checked
			{
				num = (short)unchecked(num + 1);
				num2 = num;
				num3 = 2;
			}
		}
		while (num2 <= num3);
	}

	private void CheckOptYctw(short index)
	{
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		iSelected = index;
		short num = 0;
		double num2 = default(double);
		short num3;
		short num4;
		do
		{
			if (num == index)
			{
				((Control)fraYctw).Controls["_txtYctw_" + Conversions.ToString((int)num)].BackColor = Color.White;
				if (num == 3)
				{
					((Control)txtYctwOther).Enabled = true;
					((TextBoxBase)txtYctwOther).ReadOnly = false;
					((TextBoxBase)txtYctwOther).BackColor = Color.White;
					((TextBoxBase)(TextBox)((Control)fraYctw).Controls["_txtYctw_" + Conversions.ToString((int)num)]).ReadOnly = false;
				}
				if (arMyCtw[num] == 0.0)
				{
					switch (num)
					{
					case 0:
						num2 = 0.001;
						break;
					case 1:
						num2 = 2E-05;
						break;
					case 2:
						num2 = 5E-06;
						break;
					case 3:
						num2 = 0.0;
						break;
					}
				}
				else
				{
					num2 = Conversions.ToDouble(ChemStrX.ShowInSciNot(arMyCtw[num]));
				}
				((Control)fraYctw).Controls["_txtYctw_" + Conversions.ToString((int)num)].Text = ChemStrX.ShowZeroAsNull(num2);
			}
			else
			{
				((Control)fraYctw).Controls["_txtYctw_" + Conversions.ToString((int)num)].BackColor = ColorTranslator.FromOle(-2147483633);
				((TextBoxBase)(TextBox)((Control)fraYctw).Controls["_txtYctw_" + Conversions.ToString((int)num)]).ReadOnly = true;
				if (num == 3)
				{
					((Control)txtYctwOther).Enabled = false;
					((TextBoxBase)txtYctwOther).BackColor = ColorTranslator.FromOle(-2147483633);
					((TextBoxBase)txtYctwOther).ReadOnly = true;
				}
			}
			checked
			{
				num = (short)unchecked(num + 1);
				num3 = num;
				num4 = 3;
			}
		}
		while (num3 <= num4);
	}

	private void LeaveTextRRctw(short index)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		if (!Versioned.IsNumeric((object)((Control)fraRRctw).Controls["_txtRRctw_" + Conversions.ToString((int)index)].Text))
		{
			Interaction.Beep();
			Interaction.MsgBox((object)("Invalid value. " + Globals_Renamed.arParmNames[126] + " must be numeric. Please correct this parameter."), (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
			((Control)cmdOk).Enabled = false;
			((Control)fraRRctw).Controls["_txtRRctw_" + Conversions.ToString((int)index)].Text = "";
		}
		else if (Conversions.ToDouble(txtRRctw[index].Text) <= 0.0)
		{
			Interaction.Beep();
			Interaction.MsgBox((object)("Invalid number. " + Globals_Renamed.arParmNames[126] + " must be greater than zero. Please correct this parameter."), (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
			((Control)cmdOk).Enabled = false;
			((Control)fraRRctw).Controls["_txtRRctw_" + Conversions.ToString((int)index)].Text = "";
		}
		else
		{
			arMyCtw[index] = Conversions.ToDouble(((Control)fraRRctw).Controls["_txtRRctw_" + Conversions.ToString((int)index)].Text);
			((Control)cmdOk).Enabled = true;
		}
	}

	private void ChangeTxtYctw(short index)
	{
		if (Strings.Len(((Control)fraYctw).Controls["_txtYctw_" + Conversions.ToString((int)index)].Text) > 0 && Versioned.IsNumeric((object)((Control)fraYctw).Controls["_txtYctw_" + Conversions.ToString((int)index)].Text) && Conversions.ToDouble(((Control)fraYctw).Controls["_txtYctw_" + Conversions.ToString((int)index)].Text) != 0.0)
		{
			short pID = 124;
			Control val = ((Control)fraYctw).Controls["_txtYctw_" + Conversions.ToString((int)index)];
			object pValue = val.Text;
			short pModType = 0;
			bool num = ChemStrX.ValidateParmInput(ref pID, ref pValue, ref pModType);
			val.Text = Conversions.ToString(pValue);
			if (num)
			{
				bool bValue = true;
				SetButtons(ref bValue);
			}
		}
	}

	private void optRRctw_CheckedChanged(object eventSender, EventArgs eventArgs)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		if (!Conversions.ToBoolean(NewLateBinding.LateGet(eventSender, (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			return;
		}
		short num = (iSelected = optRRctw.GetIndex((RadioButton)eventSender));
		short num2 = 0;
		checked
		{
			short num3;
			short num4;
			do
			{
				if (num2 == num)
				{
					((TextBoxBase)txtRRctw[num2]).BackColor = Color.White;
					if (num2 == 2)
					{
						((TextBoxBase)txtRRctw[num2]).ReadOnly = false;
					}
					txtRRctw[num2].Text = ChemStrX.ShowZeroAsNull(arMyCtw[num2]);
				}
				else
				{
					((TextBoxBase)txtRRctw[num2]).BackColor = ColorTranslator.FromOle(-2147483633);
					((TextBoxBase)txtRRctw[num2]).ReadOnly = true;
				}
				num2 = (short)unchecked(num2 + 1);
				num3 = num2;
				num4 = 2;
			}
			while (num3 <= num4);
		}
	}

	private void optYctw_CheckedChanged(object eventSender, EventArgs eventArgs)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		if (!Conversions.ToBoolean(NewLateBinding.LateGet(eventSender, (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			return;
		}
		short num = (iSelected = optYctw.GetIndex((RadioButton)eventSender));
		short num2 = 0;
		checked
		{
			double num3 = default(double);
			short num4;
			short num5;
			do
			{
				if (num2 == num)
				{
					((TextBoxBase)txtYctw[num2]).BackColor = Color.White;
					if (num2 == 3)
					{
						((Control)txtYctwOther).Enabled = true;
						((TextBoxBase)txtYctwOther).ReadOnly = false;
						((TextBoxBase)txtYctwOther).BackColor = Color.White;
						((TextBoxBase)txtYctw[num2]).ReadOnly = false;
					}
					if (arMyCtw[num2] == 0.0)
					{
						switch (num2)
						{
						case 0:
							num3 = 0.001;
							break;
						case 1:
							num3 = 2E-05;
							break;
						case 2:
							num3 = 5E-06;
							break;
						case 3:
							num3 = 0.0;
							break;
						}
					}
					else
					{
						num3 = Conversions.ToDouble(ChemStrX.ShowInSciNot(arMyCtw[num2]));
					}
					txtYctw[num2].Text = ChemStrX.ShowZeroAsNull(num3);
				}
				else
				{
					((TextBoxBase)txtYctw[num2]).BackColor = ColorTranslator.FromOle(-2147483633);
					((TextBoxBase)txtYctw[num2]).ReadOnly = true;
					if (num2 == 3)
					{
						((Control)txtYctwOther).Enabled = false;
						((TextBoxBase)txtYctwOther).BackColor = ColorTranslator.FromOle(-2147483633);
						((TextBoxBase)txtYctwOther).ReadOnly = true;
					}
				}
				num2 = (short)unchecked(num2 + 1);
				num4 = num2;
				num5 = 3;
			}
			while (num4 <= num5);
		}
	}

	private void txtRRctw_Enter(object eventSender, EventArgs eventArgs)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		short index = txtRRctw.GetIndex((TextBox)eventSender);
		((Control)cmdOk).Enabled = true;
	}

	private void txtRRctw_Leave(object eventSender, EventArgs eventArgs)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		short index = txtRRctw.GetIndex((TextBox)eventSender);
		if (!Versioned.IsNumeric((object)txtRRctw[index].Text))
		{
			Interaction.Beep();
			Interaction.MsgBox((object)("Invalid value. " + Globals_Renamed.arParmNames[126] + " must be numeric. Please correct this parameter."), (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
			((Control)cmdOk).Enabled = false;
			txtRRctw[index].Text = "";
		}
		else if (Conversions.ToDouble(txtRRctw[index].Text) <= 0.0)
		{
			Interaction.Beep();
			Interaction.MsgBox((object)("Invalid number. " + Globals_Renamed.arParmNames[126] + " must be greater than zero. Please correct this parameter."), (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
			((Control)cmdOk).Enabled = false;
			txtRRctw[index].Text = "";
		}
		else
		{
			arMyCtw[index] = Conversions.ToDouble(txtRRctw[index].Text);
			((Control)cmdOk).Enabled = true;
		}
	}

	private void txtYctw_TextChanged(object eventSender, EventArgs eventArgs)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		short index = txtYctw.GetIndex((TextBox)eventSender);
		if (Strings.Len(txtYctw[index].Text) > 0 && Versioned.IsNumeric((object)txtYctw[index].Text) && Conversions.ToDouble(txtYctw[index].Text) != 0.0)
		{
			short pID = 124;
			TextBox val = txtYctw[index];
			object pValue = val.Text;
			short pModType = 0;
			bool num = ChemStrX.ValidateParmInput(ref pID, ref pValue, ref pModType);
			val.Text = Conversions.ToString(pValue);
			if (num)
			{
				bool bValue = true;
				SetButtons(ref bValue);
			}
		}
	}

	private void SetButtons(ref bool bValue)
	{
		((Control)cmdOk).Enabled = bValue;
	}

	private void _optRRctw_0_CheckedChanged(object sender, EventArgs e)
	{
		if (_optRRctw_0.Checked)
		{
			CheckoptRRctw(0);
		}
	}

	private void _optRRctw_1_CheckedChanged(object sender, EventArgs e)
	{
		if (_optRRctw_1.Checked)
		{
			CheckoptRRctw(1);
		}
	}

	private void _optRRctw_2_CheckedChanged(object sender, EventArgs e)
	{
		if (_optRRctw_2.Checked)
		{
			CheckoptRRctw(2);
		}
	}

	private void _optYctw_0_CheckedChanged(object sender, EventArgs e)
	{
		if (_optYctw_0.Checked)
		{
			CheckOptYctw(0);
		}
	}

	private void _optYctw_1_CheckedChanged(object sender, EventArgs e)
	{
		if (_optYctw_1.Checked)
		{
			CheckOptYctw(1);
		}
	}

	private void _optYctw_2_CheckedChanged(object sender, EventArgs e)
	{
		if (_optYctw_2.Checked)
		{
			CheckOptYctw(2);
		}
	}

	private void _optYctw_3_CheckedChanged(object sender, EventArgs e)
	{
		if (_optYctw_3.Checked)
		{
			CheckOptYctw(3);
		}
	}

	private void _txtRRctw_0_Enter(object sender, EventArgs e)
	{
		((Control)cmdOk).Enabled = true;
	}

	private void _txtRRctw_1_Enter(object sender, EventArgs e)
	{
		((Control)cmdOk).Enabled = true;
	}

	private void _txtRRctw_2_Enter(object sender, EventArgs e)
	{
		((Control)cmdOk).Enabled = true;
	}

	private void _txtRRctw_0_Leave(object sender, EventArgs e)
	{
		LeaveTextRRctw(0);
	}

	private void _txtRRctw_1_Leave(object sender, EventArgs e)
	{
		LeaveTextRRctw(1);
	}

	private void _txtRRctw_2_Leave(object sender, EventArgs e)
	{
		LeaveTextRRctw(2);
	}

	private void _txtYctw_0_TextChanged(object sender, EventArgs e)
	{
		ChangeTxtYctw(0);
	}

	private void _txtYctw_1_TextChanged(object sender, EventArgs e)
	{
		ChangeTxtYctw(1);
	}

	private void _txtYctw_2_TextChanged(object sender, EventArgs e)
	{
		ChangeTxtYctw(2);
	}

	private void _txtYctw_3_TextChanged(object sender, EventArgs e)
	{
		ChangeTxtYctw(3);
	}
}
