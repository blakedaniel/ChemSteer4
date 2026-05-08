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

internal class frmMDUpdSat : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("cmbEcoXBYesNo")]
	private ComboBox _cmbEcoXBYesNo;

	[AccessedThroughProperty("cmbHealthXBYesNo")]
	private ComboBox _cmbHealthXBYesNo;

	[AccessedThroughProperty("txtWaterDesc")]
	private TextBox _txtWaterDesc;

	[AccessedThroughProperty("txtEcoXPDesc")]
	private TextBox _txtEcoXPDesc;

	[AccessedThroughProperty("_chkEReq_5")]
	private CheckBox __chkEReq_5;

	[AccessedThroughProperty("txtHealthXPDesc")]
	private TextBox _txtHealthXPDesc;

	[AccessedThroughProperty("_chkReq_5")]
	private CheckBox __chkReq_5;

	[AccessedThroughProperty("_chkEReq_3")]
	private CheckBox __chkEReq_3;

	[AccessedThroughProperty("txtSatAddPbtInfo")]
	private TextBox _txtSatAddPbtInfo;

	[AccessedThroughProperty("txtSatRelatedCases")]
	private TextBox _txtSatRelatedCases;

	[AccessedThroughProperty("txtSATdate")]
	private TextBox _txtSATdate;

	[AccessedThroughProperty("txtEcoOther")]
	private TextBox _txtEcoOther;

	[AccessedThroughProperty("_chkEReq_4")]
	private CheckBox __chkEReq_4;

	[AccessedThroughProperty("_chkEReq_2")]
	private CheckBox __chkEReq_2;

	[AccessedThroughProperty("_chkEReq_1")]
	private CheckBox __chkEReq_1;

	[AccessedThroughProperty("_chkEReq_0")]
	private CheckBox __chkEReq_0;

	[AccessedThroughProperty("cmbSatER")]
	private ComboBox _cmbSatER;

	[AccessedThroughProperty("cmbM2G")]
	private ComboBox _cmbM2G;

	[AccessedThroughProperty("cmbTR")]
	private ComboBox _cmbTR;

	[AccessedThroughProperty("cmbBR")]
	private ComboBox _cmbBR;

	[AccessedThroughProperty("cmbPR")]
	private ComboBox _cmbPR;

	[AccessedThroughProperty("cmbSatHR")]
	private ComboBox _cmbSatHR;

	[AccessedThroughProperty("txtM2GOther")]
	private TextBox _txtM2GOther;

	[AccessedThroughProperty("_chkReq_0")]
	private CheckBox __chkReq_0;

	[AccessedThroughProperty("_chkReq_2")]
	private CheckBox __chkReq_2;

	[AccessedThroughProperty("_chkReq_1")]
	private CheckBox __chkReq_1;

	[AccessedThroughProperty("_chkReq_3")]
	private CheckBox __chkReq_3;

	[AccessedThroughProperty("_chkReq_4")]
	private CheckBox __chkReq_4;

	[AccessedThroughProperty("txtOtherDesc")]
	private TextBox _txtOtherDesc;

	[AccessedThroughProperty("CancelButton_Renamed")]
	private Button _CancelButton_Renamed;

	[AccessedThroughProperty("OKButton")]
	private Button _OKButton;

	[AccessedThroughProperty("_Label1_4")]
	private Label __Label1_4;

	[AccessedThroughProperty("_Label1_3")]
	private Label __Label1_3;

	[AccessedThroughProperty("_Label1_2")]
	private Label __Label1_2;

	[AccessedThroughProperty("_Line2_4")]
	private Label __Line2_4;

	[AccessedThroughProperty("_Line2_3")]
	private Label __Line2_3;

	[AccessedThroughProperty("_Line2_0")]
	private Label __Line2_0;

	[AccessedThroughProperty("_Label1_0")]
	private Label __Label1_0;

	[AccessedThroughProperty("lblInstructions")]
	private Label _lblInstructions;

	[AccessedThroughProperty("_Line2_2")]
	private Label __Line2_2;

	[AccessedThroughProperty("_Label1_27")]
	private Label __Label1_27;

	[AccessedThroughProperty("_Line2_1")]
	private Label __Line2_1;

	[AccessedThroughProperty("_Label1_31")]
	private Label __Label1_31;

	[AccessedThroughProperty("_Label1_33")]
	private Label __Label1_33;

	[AccessedThroughProperty("_Label1_34")]
	private Label __Label1_34;

	[AccessedThroughProperty("_Label1_35")]
	private Label __Label1_35;

	[AccessedThroughProperty("Label1")]
	private LabelArray _Label1;

	[AccessedThroughProperty("Line2")]
	private LabelArray _Line2;

	[AccessedThroughProperty("chkEReq")]
	private CheckBoxArray _chkEReq;

	[AccessedThroughProperty("chkReq")]
	private CheckBoxArray _chkReq;

	private static frmMDUpdSat m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	public virtual ComboBox cmbEcoXBYesNo
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbEcoXBYesNo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cmbEcoXBYesNo = value;
		}
	}

	public virtual ComboBox cmbHealthXBYesNo
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbHealthXBYesNo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmbHealthXBYesNo_SelectedIndexChanged;
			if (_cmbHealthXBYesNo != null)
			{
				_cmbHealthXBYesNo.SelectedIndexChanged -= eventHandler;
			}
			_cmbHealthXBYesNo = value;
			if (_cmbHealthXBYesNo != null)
			{
				_cmbHealthXBYesNo.SelectedIndexChanged += eventHandler;
			}
		}
	}

	public virtual TextBox txtWaterDesc
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtWaterDesc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtWaterDesc_Leave;
			if (_txtWaterDesc != null)
			{
				((Control)_txtWaterDesc).Leave -= eventHandler;
			}
			_txtWaterDesc = value;
			if (_txtWaterDesc != null)
			{
				((Control)_txtWaterDesc).Leave += eventHandler;
			}
		}
	}

	public virtual TextBox txtEcoXPDesc
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtEcoXPDesc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtEcoXPDesc = value;
		}
	}

	public virtual CheckBox _chkEReq_5
	{
		[DebuggerNonUserCode]
		get
		{
			return __chkEReq_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _chkEReq_5_CheckedChanged;
			if (__chkEReq_5 != null)
			{
				__chkEReq_5.CheckedChanged -= eventHandler;
			}
			__chkEReq_5 = value;
			if (__chkEReq_5 != null)
			{
				__chkEReq_5.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual TextBox txtHealthXPDesc
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtHealthXPDesc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtHealthXPDesc = value;
		}
	}

	public virtual CheckBox _chkReq_5
	{
		[DebuggerNonUserCode]
		get
		{
			return __chkReq_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _chkReq_5_CheckedChanged;
			if (__chkReq_5 != null)
			{
				__chkReq_5.CheckedChanged -= eventHandler;
			}
			__chkReq_5 = value;
			if (__chkReq_5 != null)
			{
				__chkReq_5.CheckedChanged += eventHandler;
			}
		}
	}

	public virtual CheckBox _chkEReq_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __chkEReq_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__chkEReq_3 = value;
		}
	}

	public virtual TextBox txtSatAddPbtInfo
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSatAddPbtInfo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtSatAddPbtInfo_Leave;
			if (_txtSatAddPbtInfo != null)
			{
				((Control)_txtSatAddPbtInfo).Leave -= eventHandler;
			}
			_txtSatAddPbtInfo = value;
			if (_txtSatAddPbtInfo != null)
			{
				((Control)_txtSatAddPbtInfo).Leave += eventHandler;
			}
		}
	}

	public virtual TextBox txtSatRelatedCases
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSatRelatedCases;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtSatRelatedCases_Leave;
			if (_txtSatRelatedCases != null)
			{
				((Control)_txtSatRelatedCases).Leave -= eventHandler;
			}
			_txtSatRelatedCases = value;
			if (_txtSatRelatedCases != null)
			{
				((Control)_txtSatRelatedCases).Leave += eventHandler;
			}
		}
	}

	public virtual TextBox txtSATdate
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSATdate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtSATdate_Leave;
			if (_txtSATdate != null)
			{
				((Control)_txtSATdate).Leave -= eventHandler;
			}
			_txtSATdate = value;
			if (_txtSATdate != null)
			{
				((Control)_txtSATdate).Leave += eventHandler;
			}
		}
	}

	public virtual TextBox txtEcoOther
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtEcoOther;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtEcoOther = value;
		}
	}

	public virtual CheckBox _chkEReq_4
	{
		[DebuggerNonUserCode]
		get
		{
			return __chkEReq_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__chkEReq_4 = value;
		}
	}

	public virtual CheckBox _chkEReq_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __chkEReq_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__chkEReq_2 = value;
		}
	}

	public virtual CheckBox _chkEReq_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __chkEReq_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__chkEReq_1 = value;
		}
	}

	public virtual CheckBox _chkEReq_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __chkEReq_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__chkEReq_0 = value;
		}
	}

	public virtual ComboBox cmbSatER
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbSatER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cmbSatER = value;
		}
	}

	public virtual ComboBox cmbM2G
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbM2G;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmbM2G_SelectedIndexChanged;
			if (_cmbM2G != null)
			{
				_cmbM2G.SelectedIndexChanged -= eventHandler;
			}
			_cmbM2G = value;
			if (_cmbM2G != null)
			{
				_cmbM2G.SelectedIndexChanged += eventHandler;
			}
		}
	}

	public virtual ComboBox cmbTR
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbTR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cmbTR = value;
		}
	}

	public virtual ComboBox cmbBR
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbBR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cmbBR = value;
		}
	}

	public virtual ComboBox cmbPR
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbPR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cmbPR = value;
		}
	}

	public virtual ComboBox cmbSatHR
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbSatHR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cmbSatHR = value;
		}
	}

	public virtual TextBox txtM2GOther
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtM2GOther;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtM2GOther = value;
		}
	}

	public virtual CheckBox _chkReq_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __chkReq_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__chkReq_0 = value;
		}
	}

	public virtual CheckBox _chkReq_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __chkReq_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__chkReq_2 = value;
		}
	}

	public virtual CheckBox _chkReq_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __chkReq_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__chkReq_1 = value;
		}
	}

	public virtual CheckBox _chkReq_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __chkReq_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__chkReq_3 = value;
		}
	}

	public virtual CheckBox _chkReq_4
	{
		[DebuggerNonUserCode]
		get
		{
			return __chkReq_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__chkReq_4 = value;
		}
	}

	public virtual TextBox txtOtherDesc
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtOtherDesc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtOtherDesc = value;
		}
	}

	public virtual Button CancelButton_Renamed
	{
		[DebuggerNonUserCode]
		get
		{
			return _CancelButton_Renamed;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = CancelButton_Renamed_Click;
			if (_CancelButton_Renamed != null)
			{
				((Control)_CancelButton_Renamed).Click -= eventHandler;
			}
			_CancelButton_Renamed = value;
			if (_CancelButton_Renamed != null)
			{
				((Control)_CancelButton_Renamed).Click += eventHandler;
			}
		}
	}

	public virtual Button OKButton
	{
		[DebuggerNonUserCode]
		get
		{
			return _OKButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = OKButton_Click;
			if (_OKButton != null)
			{
				((Control)_OKButton).Click -= eventHandler;
			}
			_OKButton = value;
			if (_OKButton != null)
			{
				((Control)_OKButton).Click += eventHandler;
			}
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
			EventHandler eventHandler = _Label1_0_Click;
			if (__Label1_0 != null)
			{
				((Control)__Label1_0).Click -= eventHandler;
			}
			__Label1_0 = value;
			if (__Label1_0 != null)
			{
				((Control)__Label1_0).Click += eventHandler;
			}
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

	public virtual Label _Label1_33
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_33;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_33 = value;
		}
	}

	public virtual Label _Label1_34
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_34;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_34 = value;
		}
	}

	public virtual Label _Label1_35
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_35;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_35 = value;
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

	public virtual CheckBoxArray chkEReq
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkEReq;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = chkEReq_CheckStateChanged;
			if (_chkEReq != null)
			{
				_chkEReq.CheckStateChanged -= eventHandler;
			}
			_chkEReq = value;
			if (_chkEReq != null)
			{
				_chkEReq.CheckStateChanged += eventHandler;
			}
		}
	}

	public virtual CheckBoxArray chkReq
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkReq;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = chkReq_CheckStateChanged;
			if (_chkReq != null)
			{
				_chkReq.CheckStateChanged -= eventHandler;
			}
			_chkReq = value;
			if (_chkReq != null)
			{
				_chkReq.CheckStateChanged += eventHandler;
			}
		}
	}

	public static frmMDUpdSat DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmMDUpdSat();
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

	public frmMDUpdSat()
	{
		((Form)this).Load += frmMDUpdSat_Load;
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
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected O, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected O, but got Unknown
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected O, but got Unknown
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected O, but got Unknown
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0429: Expected O, but got Unknown
		//IL_051b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0525: Expected O, but got Unknown
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		//IL_0621: Expected O, but got Unknown
		//IL_06df: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e9: Expected O, but got Unknown
		//IL_07e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07eb: Expected O, but got Unknown
		//IL_08a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b3: Expected O, but got Unknown
		//IL_098e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0998: Expected O, but got Unknown
		//IL_0a86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a90: Expected O, but got Unknown
		//IL_0b73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7d: Expected O, but got Unknown
		//IL_0c5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c67: Expected O, but got Unknown
		//IL_0d38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d42: Expected O, but got Unknown
		//IL_0e00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0a: Expected O, but got Unknown
		//IL_0eeb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef5: Expected O, but got Unknown
		//IL_0fd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe0: Expected O, but got Unknown
		//IL_10c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10cb: Expected O, but got Unknown
		//IL_11b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c3: Expected O, but got Unknown
		//IL_127d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1287: Expected O, but got Unknown
		//IL_1351: Unknown result type (might be due to invalid IL or missing references)
		//IL_135b: Expected O, but got Unknown
		//IL_1415: Unknown result type (might be due to invalid IL or missing references)
		//IL_141f: Expected O, but got Unknown
		//IL_14d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e3: Expected O, but got Unknown
		//IL_159d: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a7: Expected O, but got Unknown
		//IL_166d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1677: Expected O, but got Unknown
		//IL_1738: Unknown result type (might be due to invalid IL or missing references)
		//IL_1742: Expected O, but got Unknown
		//IL_181c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1826: Expected O, but got Unknown
		//IL_1900: Unknown result type (might be due to invalid IL or missing references)
		//IL_190a: Expected O, but got Unknown
		//IL_19e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_19f1: Expected O, but got Unknown
		//IL_1ace: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ad8: Expected O, but got Unknown
		//IL_1bcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bd9: Expected O, but got Unknown
		//IL_1ca4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cae: Expected O, but got Unknown
		//IL_1d79: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d83: Expected O, but got Unknown
		//IL_1e4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e58: Expected O, but got Unknown
		//IL_1f35: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f3f: Expected O, but got Unknown
		//IL_201a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2024: Expected O, but got Unknown
		//IL_2273: Unknown result type (might be due to invalid IL or missing references)
		//IL_227d: Expected O, but got Unknown
		//IL_2351: Unknown result type (might be due to invalid IL or missing references)
		//IL_235b: Expected O, but got Unknown
		//IL_2490: Unknown result type (might be due to invalid IL or missing references)
		//IL_249a: Expected O, but got Unknown
		//IL_25e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_25f2: Expected O, but got Unknown
		//IL_26d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_26db: Expected O, but got Unknown
		//IL_27ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_27c4: Expected O, but got Unknown
		//IL_28a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_28ad: Expected O, but got Unknown
		//IL_2cf5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cff: Expected O, but got Unknown
		//IL_2d20: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d2a: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMDUpdSat));
		ToolTip1 = new ToolTip(components);
		cmbEcoXBYesNo = new ComboBox();
		cmbHealthXBYesNo = new ComboBox();
		txtWaterDesc = new TextBox();
		txtEcoXPDesc = new TextBox();
		_chkEReq_5 = new CheckBox();
		txtHealthXPDesc = new TextBox();
		_chkReq_5 = new CheckBox();
		_chkEReq_3 = new CheckBox();
		txtSatAddPbtInfo = new TextBox();
		txtSatRelatedCases = new TextBox();
		txtSATdate = new TextBox();
		txtEcoOther = new TextBox();
		_chkEReq_4 = new CheckBox();
		_chkEReq_2 = new CheckBox();
		_chkEReq_1 = new CheckBox();
		_chkEReq_0 = new CheckBox();
		cmbSatER = new ComboBox();
		cmbM2G = new ComboBox();
		cmbTR = new ComboBox();
		cmbBR = new ComboBox();
		cmbPR = new ComboBox();
		cmbSatHR = new ComboBox();
		txtM2GOther = new TextBox();
		_chkReq_0 = new CheckBox();
		_chkReq_2 = new CheckBox();
		_chkReq_1 = new CheckBox();
		_chkReq_3 = new CheckBox();
		_chkReq_4 = new CheckBox();
		txtOtherDesc = new TextBox();
		CancelButton_Renamed = new Button();
		OKButton = new Button();
		_Label1_4 = new Label();
		_Label1_3 = new Label();
		_Label1_2 = new Label();
		_Line2_4 = new Label();
		_Line2_3 = new Label();
		_Line2_0 = new Label();
		_Label1_0 = new Label();
		lblInstructions = new Label();
		_Line2_2 = new Label();
		_Label1_27 = new Label();
		_Line2_1 = new Label();
		_Label1_31 = new Label();
		_Label1_33 = new Label();
		_Label1_34 = new Label();
		_Label1_35 = new Label();
		Label1 = new LabelArray(components);
		Line2 = new LabelArray(components);
		chkEReq = new CheckBoxArray(components);
		chkReq = new CheckBoxArray(components);
		((ISupportInitialize)Label1).BeginInit();
		((ISupportInitialize)Line2).BeginInit();
		((ISupportInitialize)chkEReq).BeginInit();
		((ISupportInitialize)chkReq).BeginInit();
		((Control)this).SuspendLayout();
		cmbEcoXBYesNo.BackColor = SystemColors.Window;
		((Control)cmbEcoXBYesNo).Cursor = Cursors.Default;
		cmbEcoXBYesNo.DropDownStyle = (ComboBoxStyle)2;
		((Control)cmbEcoXBYesNo).Enabled = false;
		((Control)cmbEcoXBYesNo).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		cmbEcoXBYesNo.ForeColor = SystemColors.WindowText;
		cmbEcoXBYesNo.Items.AddRange(new object[2] { "Yes", "No" });
		ComboBox obj = cmbEcoXBYesNo;
		Point location = new Point(448, 352);
		((Control)obj).Location = location;
		((Control)cmbEcoXBYesNo).Name = "cmbEcoXBYesNo";
		((Control)cmbEcoXBYesNo).RightToLeft = (RightToLeft)0;
		ComboBox obj2 = cmbEcoXBYesNo;
		Size size = new Size(49, 22);
		((Control)obj2).Size = size;
		((Control)cmbEcoXBYesNo).TabIndex = 22;
		cmbHealthXBYesNo.BackColor = SystemColors.Window;
		((Control)cmbHealthXBYesNo).Cursor = Cursors.Default;
		cmbHealthXBYesNo.DropDownStyle = (ComboBoxStyle)2;
		((Control)cmbHealthXBYesNo).Enabled = false;
		((Control)cmbHealthXBYesNo).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		cmbHealthXBYesNo.ForeColor = SystemColors.WindowText;
		cmbHealthXBYesNo.Items.AddRange(new object[2] { "Yes", "No" });
		ComboBox obj3 = cmbHealthXBYesNo;
		location = new Point(128, 352);
		((Control)obj3).Location = location;
		((Control)cmbHealthXBYesNo).Name = "cmbHealthXBYesNo";
		((Control)cmbHealthXBYesNo).RightToLeft = (RightToLeft)0;
		ComboBox obj4 = cmbHealthXBYesNo;
		size = new Size(49, 22);
		((Control)obj4).Size = size;
		((Control)cmbHealthXBYesNo).TabIndex = 11;
		txtWaterDesc.AcceptsReturn = true;
		((TextBoxBase)txtWaterDesc).BackColor = SystemColors.Control;
		((Control)txtWaterDesc).Cursor = Cursors.IBeam;
		((Control)txtWaterDesc).Enabled = false;
		((Control)txtWaterDesc).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtWaterDesc).ForeColor = SystemColors.WindowText;
		TextBox obj5 = txtWaterDesc;
		location = new Point(480, 232);
		((Control)obj5).Location = location;
		((TextBoxBase)txtWaterDesc).MaxLength = 100;
		txtWaterDesc.Multiline = true;
		((Control)txtWaterDesc).Name = "txtWaterDesc";
		((Control)txtWaterDesc).RightToLeft = (RightToLeft)0;
		txtWaterDesc.ScrollBars = (ScrollBars)2;
		TextBox obj6 = txtWaterDesc;
		size = new Size(217, 35);
		((Control)obj6).Size = size;
		((Control)txtWaterDesc).TabIndex = 15;
		txtEcoXPDesc.AcceptsReturn = true;
		((TextBoxBase)txtEcoXPDesc).BackColor = SystemColors.Control;
		((Control)txtEcoXPDesc).Cursor = Cursors.IBeam;
		((Control)txtEcoXPDesc).Enabled = false;
		((Control)txtEcoXPDesc).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtEcoXPDesc).ForeColor = SystemColors.WindowText;
		TextBox obj7 = txtEcoXPDesc;
		location = new Point(504, 352);
		((Control)obj7).Location = location;
		((TextBoxBase)txtEcoXPDesc).MaxLength = 100;
		((Control)txtEcoXPDesc).Name = "txtEcoXPDesc";
		((Control)txtEcoXPDesc).RightToLeft = (RightToLeft)0;
		TextBox obj8 = txtEcoXPDesc;
		size = new Size(153, 20);
		((Control)obj8).Size = size;
		((Control)txtEcoXPDesc).TabIndex = 23;
		((ButtonBase)_chkEReq_5).BackColor = SystemColors.Control;
		((Control)_chkEReq_5).Cursor = Cursors.Default;
		((Control)_chkEReq_5).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_chkEReq_5).ForeColor = SystemColors.ControlText;
		chkEReq.SetIndex(_chkEReq_5, (short)5);
		CheckBox chkEReq_ = _chkEReq_5;
		location = new Point(368, 352);
		((Control)chkEReq_).Location = location;
		((Control)_chkEReq_5).Name = "_chkEReq_5";
		((Control)_chkEReq_5).RightToLeft = (RightToLeft)0;
		CheckBox chkEReq_2 = _chkEReq_5;
		size = new Size(81, 17);
		((Control)chkEReq_2).Size = size;
		((Control)_chkEReq_5).TabIndex = 21;
		((ButtonBase)_chkEReq_5).Text = "XB Testing";
		((ButtonBase)_chkEReq_5).UseVisualStyleBackColor = false;
		txtHealthXPDesc.AcceptsReturn = true;
		((TextBoxBase)txtHealthXPDesc).BackColor = SystemColors.Control;
		((Control)txtHealthXPDesc).Cursor = Cursors.IBeam;
		((Control)txtHealthXPDesc).Enabled = false;
		((Control)txtHealthXPDesc).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtHealthXPDesc).ForeColor = SystemColors.WindowText;
		TextBox obj9 = txtHealthXPDesc;
		location = new Point(184, 352);
		((Control)obj9).Location = location;
		((TextBoxBase)txtHealthXPDesc).MaxLength = 100;
		((Control)txtHealthXPDesc).Name = "txtHealthXPDesc";
		((Control)txtHealthXPDesc).RightToLeft = (RightToLeft)0;
		TextBox obj10 = txtHealthXPDesc;
		size = new Size(153, 20);
		((Control)obj10).Size = size;
		((Control)txtHealthXPDesc).TabIndex = 12;
		((ButtonBase)_chkReq_5).BackColor = SystemColors.Control;
		((Control)_chkReq_5).Cursor = Cursors.Default;
		((Control)_chkReq_5).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_chkReq_5).ForeColor = SystemColors.ControlText;
		chkReq.SetIndex(_chkReq_5, (short)5);
		CheckBox chkReq_ = _chkReq_5;
		location = new Point(39, 352);
		((Control)chkReq_).Location = location;
		((Control)_chkReq_5).Name = "_chkReq_5";
		((Control)_chkReq_5).RightToLeft = (RightToLeft)0;
		CheckBox chkReq_2 = _chkReq_5;
		size = new Size(83, 20);
		((Control)chkReq_2).Size = size;
		((Control)_chkReq_5).TabIndex = 10;
		((ButtonBase)_chkReq_5).Text = "XB Testing";
		((ButtonBase)_chkReq_5).UseVisualStyleBackColor = false;
		((ButtonBase)_chkEReq_3).BackColor = SystemColors.Control;
		((Control)_chkEReq_3).Cursor = Cursors.Default;
		((Control)_chkEReq_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_chkEReq_3).ForeColor = SystemColors.ControlText;
		chkEReq.SetIndex(_chkEReq_3, (short)3);
		CheckBox chkEReq_3 = _chkEReq_3;
		location = new Point(368, 304);
		((Control)chkEReq_3).Location = location;
		((Control)_chkEReq_3).Name = "_chkEReq_3";
		((Control)_chkEReq_3).RightToLeft = (RightToLeft)0;
		CheckBox chkEReq_4 = _chkEReq_3;
		size = new Size(137, 17);
		((Control)chkEReq_4).Size = size;
		((Control)_chkEReq_3).TabIndex = 18;
		((ButtonBase)_chkEReq_3).Text = "Not Required";
		((ButtonBase)_chkEReq_3).UseVisualStyleBackColor = false;
		txtSatAddPbtInfo.AcceptsReturn = true;
		((TextBoxBase)txtSatAddPbtInfo).BackColor = SystemColors.Window;
		((Control)txtSatAddPbtInfo).Cursor = Cursors.IBeam;
		((Control)txtSatAddPbtInfo).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtSatAddPbtInfo).ForeColor = SystemColors.WindowText;
		TextBox obj11 = txtSatAddPbtInfo;
		location = new Point(160, 144);
		((Control)obj11).Location = location;
		((TextBoxBase)txtSatAddPbtInfo).MaxLength = 0;
		txtSatAddPbtInfo.Multiline = true;
		((Control)txtSatAddPbtInfo).Name = "txtSatAddPbtInfo";
		((Control)txtSatAddPbtInfo).RightToLeft = (RightToLeft)0;
		txtSatAddPbtInfo.ScrollBars = (ScrollBars)2;
		TextBox obj12 = txtSatAddPbtInfo;
		size = new Size(505, 43);
		((Control)obj12).Size = size;
		((Control)txtSatAddPbtInfo).TabIndex = 2;
		txtSatRelatedCases.AcceptsReturn = true;
		((TextBoxBase)txtSatRelatedCases).BackColor = SystemColors.Window;
		((Control)txtSatRelatedCases).Cursor = Cursors.IBeam;
		((Control)txtSatRelatedCases).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtSatRelatedCases).ForeColor = SystemColors.WindowText;
		TextBox obj13 = txtSatRelatedCases;
		location = new Point(160, 88);
		((Control)obj13).Location = location;
		((TextBoxBase)txtSatRelatedCases).MaxLength = 0;
		txtSatRelatedCases.Multiline = true;
		((Control)txtSatRelatedCases).Name = "txtSatRelatedCases";
		((Control)txtSatRelatedCases).RightToLeft = (RightToLeft)0;
		txtSatRelatedCases.ScrollBars = (ScrollBars)2;
		TextBox obj14 = txtSatRelatedCases;
		size = new Size(505, 43);
		((Control)obj14).Size = size;
		((Control)txtSatRelatedCases).TabIndex = 1;
		txtSATdate.AcceptsReturn = true;
		((TextBoxBase)txtSATdate).BackColor = SystemColors.Window;
		((Control)txtSATdate).Cursor = Cursors.IBeam;
		((Control)txtSATdate).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtSATdate).ForeColor = SystemColors.WindowText;
		TextBox obj15 = txtSATdate;
		location = new Point(160, 56);
		((Control)obj15).Location = location;
		((TextBoxBase)txtSATdate).MaxLength = 30;
		((Control)txtSATdate).Name = "txtSATdate";
		((Control)txtSATdate).RightToLeft = (RightToLeft)0;
		TextBox obj16 = txtSATdate;
		size = new Size(89, 20);
		((Control)obj16).Size = size;
		((Control)txtSATdate).TabIndex = 0;
		txtEcoOther.AcceptsReturn = true;
		((TextBoxBase)txtEcoOther).BackColor = SystemColors.Control;
		((Control)txtEcoOther).Cursor = Cursors.IBeam;
		((Control)txtEcoOther).Enabled = false;
		((Control)txtEcoOther).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtEcoOther).ForeColor = SystemColors.WindowText;
		TextBox obj17 = txtEcoOther;
		location = new Point(504, 328);
		((Control)obj17).Location = location;
		((TextBoxBase)txtEcoOther).MaxLength = 100;
		((Control)txtEcoOther).Name = "txtEcoOther";
		((Control)txtEcoOther).RightToLeft = (RightToLeft)0;
		TextBox obj18 = txtEcoOther;
		size = new Size(153, 20);
		((Control)obj18).Size = size;
		((Control)txtEcoOther).TabIndex = 20;
		((ButtonBase)_chkEReq_4).BackColor = SystemColors.Control;
		((Control)_chkEReq_4).Cursor = Cursors.Default;
		((Control)_chkEReq_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_chkEReq_4).ForeColor = SystemColors.ControlText;
		chkEReq.SetIndex(_chkEReq_4, (short)4);
		CheckBox chkEReq_5 = _chkEReq_4;
		location = new Point(368, 328);
		((Control)chkEReq_5).Location = location;
		((Control)_chkEReq_4).Name = "_chkEReq_4";
		((Control)_chkEReq_4).RightToLeft = (RightToLeft)0;
		CheckBox chkEReq_6 = _chkEReq_4;
		size = new Size(137, 17);
		((Control)chkEReq_6).Size = size;
		((Control)_chkEReq_4).TabIndex = 19;
		((ButtonBase)_chkEReq_4).Text = "Other (please specify)";
		((ButtonBase)_chkEReq_4).UseVisualStyleBackColor = false;
		((ButtonBase)_chkEReq_2).BackColor = SystemColors.Control;
		((Control)_chkEReq_2).Cursor = Cursors.Default;
		((Control)_chkEReq_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_chkEReq_2).ForeColor = SystemColors.ControlText;
		chkEReq.SetIndex(_chkEReq_2, (short)2);
		CheckBox chkEReq_7 = _chkEReq_2;
		location = new Point(368, 280);
		((Control)chkEReq_7).Location = location;
		((Control)_chkEReq_2).Name = "_chkEReq_2";
		((Control)_chkEReq_2).RightToLeft = (RightToLeft)0;
		CheckBox chkEReq_8 = _chkEReq_2;
		size = new Size(185, 17);
		((Control)chkEReq_8).Size = size;
		((Control)_chkEReq_2).TabIndex = 17;
		((ButtonBase)_chkEReq_2).Text = "Land Releases";
		((ButtonBase)_chkEReq_2).UseVisualStyleBackColor = false;
		((ButtonBase)_chkEReq_1).BackColor = SystemColors.Control;
		((Control)_chkEReq_1).Cursor = Cursors.Default;
		((Control)_chkEReq_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_chkEReq_1).ForeColor = SystemColors.ControlText;
		chkEReq.SetIndex(_chkEReq_1, (short)1);
		CheckBox chkEReq_9 = _chkEReq_1;
		location = new Point(368, 256);
		((Control)chkEReq_9).Location = location;
		((Control)_chkEReq_1).Name = "_chkEReq_1";
		((Control)_chkEReq_1).RightToLeft = (RightToLeft)0;
		CheckBox chkEReq_10 = _chkEReq_1;
		size = new Size(185, 17);
		((Control)chkEReq_10).Size = size;
		((Control)_chkEReq_1).TabIndex = 16;
		((ButtonBase)_chkEReq_1).Text = "Air Releases";
		((ButtonBase)_chkEReq_1).UseVisualStyleBackColor = false;
		((ButtonBase)_chkEReq_0).BackColor = SystemColors.Control;
		((Control)_chkEReq_0).Cursor = Cursors.Default;
		((Control)_chkEReq_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_chkEReq_0).ForeColor = SystemColors.ControlText;
		chkEReq.SetIndex(_chkEReq_0, (short)0);
		CheckBox chkEReq_11 = _chkEReq_0;
		location = new Point(368, 232);
		((Control)chkEReq_11).Location = location;
		((Control)_chkEReq_0).Name = "_chkEReq_0";
		((Control)_chkEReq_0).RightToLeft = (RightToLeft)0;
		CheckBox chkEReq_12 = _chkEReq_0;
		size = new Size(185, 17);
		((Control)chkEReq_12).Size = size;
		((Control)_chkEReq_0).TabIndex = 14;
		((ButtonBase)_chkEReq_0).Text = "Water Releases";
		((ButtonBase)_chkEReq_0).UseVisualStyleBackColor = false;
		cmbSatER.BackColor = SystemColors.Window;
		((Control)cmbSatER).Cursor = Cursors.Default;
		cmbSatER.DropDownStyle = (ComboBoxStyle)2;
		((Control)cmbSatER).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		cmbSatER.ForeColor = SystemColors.WindowText;
		ComboBox obj19 = cmbSatER;
		location = new Point(560, 208);
		((Control)obj19).Location = location;
		((Control)cmbSatER).Name = "cmbSatER";
		((Control)cmbSatER).RightToLeft = (RightToLeft)0;
		ComboBox obj20 = cmbSatER;
		size = new Size(57, 22);
		((Control)obj20).Size = size;
		((Control)cmbSatER).TabIndex = 13;
		cmbM2G.BackColor = SystemColors.Window;
		((Control)cmbM2G).Cursor = Cursors.Default;
		cmbM2G.DropDownStyle = (ComboBoxStyle)2;
		((Control)cmbM2G).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		cmbM2G.ForeColor = SystemColors.WindowText;
		ComboBox obj21 = cmbM2G;
		location = new Point(200, 400);
		((Control)obj21).Location = location;
		((Control)cmbM2G).Name = "cmbM2G";
		((Control)cmbM2G).RightToLeft = (RightToLeft)0;
		ComboBox obj22 = cmbM2G;
		size = new Size(209, 22);
		((Control)obj22).Size = size;
		cmbM2G.Sorted = true;
		((Control)cmbM2G).TabIndex = 24;
		cmbTR.BackColor = SystemColors.Window;
		((Control)cmbTR).Cursor = Cursors.Default;
		cmbTR.DropDownStyle = (ComboBoxStyle)2;
		((Control)cmbTR).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		cmbTR.ForeColor = SystemColors.WindowText;
		ComboBox obj23 = cmbTR;
		location = new Point(456, 440);
		((Control)obj23).Location = location;
		((Control)cmbTR).Name = "cmbTR";
		((Control)cmbTR).RightToLeft = (RightToLeft)0;
		ComboBox obj24 = cmbTR;
		size = new Size(57, 22);
		((Control)obj24).Size = size;
		((Control)cmbTR).TabIndex = 28;
		cmbBR.BackColor = SystemColors.Window;
		((Control)cmbBR).Cursor = Cursors.Default;
		cmbBR.DropDownStyle = (ComboBoxStyle)2;
		((Control)cmbBR).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		cmbBR.ForeColor = SystemColors.WindowText;
		ComboBox obj25 = cmbBR;
		location = new Point(328, 440);
		((Control)obj25).Location = location;
		((Control)cmbBR).Name = "cmbBR";
		((Control)cmbBR).RightToLeft = (RightToLeft)0;
		ComboBox obj26 = cmbBR;
		size = new Size(57, 22);
		((Control)obj26).Size = size;
		((Control)cmbBR).TabIndex = 27;
		cmbPR.BackColor = SystemColors.Window;
		((Control)cmbPR).Cursor = Cursors.Default;
		cmbPR.DropDownStyle = (ComboBoxStyle)2;
		((Control)cmbPR).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		cmbPR.ForeColor = SystemColors.WindowText;
		ComboBox obj27 = cmbPR;
		location = new Point(200, 440);
		((Control)obj27).Location = location;
		((Control)cmbPR).Name = "cmbPR";
		((Control)cmbPR).RightToLeft = (RightToLeft)0;
		ComboBox obj28 = cmbPR;
		size = new Size(57, 22);
		((Control)obj28).Size = size;
		((Control)cmbPR).TabIndex = 26;
		cmbSatHR.BackColor = SystemColors.Window;
		((Control)cmbSatHR).Cursor = Cursors.Default;
		cmbSatHR.DropDownStyle = (ComboBoxStyle)2;
		((Control)cmbSatHR).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		cmbSatHR.ForeColor = SystemColors.WindowText;
		ComboBox obj29 = cmbSatHR;
		location = new Point(256, 208);
		((Control)obj29).Location = location;
		((Control)cmbSatHR).Name = "cmbSatHR";
		((Control)cmbSatHR).RightToLeft = (RightToLeft)0;
		ComboBox obj30 = cmbSatHR;
		size = new Size(57, 22);
		((Control)obj30).Size = size;
		((Control)cmbSatHR).TabIndex = 3;
		txtM2GOther.AcceptsReturn = true;
		((TextBoxBase)txtM2GOther).BackColor = SystemColors.Control;
		((Control)txtM2GOther).Cursor = Cursors.IBeam;
		((Control)txtM2GOther).Enabled = false;
		((Control)txtM2GOther).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtM2GOther).ForeColor = SystemColors.WindowText;
		TextBox obj31 = txtM2GOther;
		location = new Point(416, 400);
		((Control)obj31).Location = location;
		((TextBoxBase)txtM2GOther).MaxLength = 255;
		((Control)txtM2GOther).Name = "txtM2GOther";
		((Control)txtM2GOther).RightToLeft = (RightToLeft)0;
		TextBox obj32 = txtM2GOther;
		size = new Size(201, 20);
		((Control)obj32).Size = size;
		((Control)txtM2GOther).TabIndex = 25;
		((ButtonBase)_chkReq_0).BackColor = SystemColors.Control;
		((Control)_chkReq_0).Cursor = Cursors.Default;
		((Control)_chkReq_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_chkReq_0).ForeColor = SystemColors.ControlText;
		chkReq.SetIndex(_chkReq_0, (short)0);
		CheckBox chkReq_3 = _chkReq_0;
		location = new Point(39, 232);
		((Control)chkReq_3).Location = location;
		((Control)_chkReq_0).Name = "_chkReq_0";
		((Control)_chkReq_0).RightToLeft = (RightToLeft)0;
		CheckBox chkReq_4 = _chkReq_0;
		size = new Size(105, 17);
		((Control)chkReq_4).Size = size;
		((Control)_chkReq_0).TabIndex = 4;
		((ButtonBase)_chkReq_0).Text = "Dermal";
		((ButtonBase)_chkReq_0).UseVisualStyleBackColor = false;
		((ButtonBase)_chkReq_2).BackColor = SystemColors.Control;
		((Control)_chkReq_2).Cursor = Cursors.Default;
		((Control)_chkReq_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_chkReq_2).ForeColor = SystemColors.ControlText;
		chkReq.SetIndex(_chkReq_2, (short)2);
		CheckBox chkReq_5 = _chkReq_2;
		location = new Point(39, 280);
		((Control)chkReq_5).Location = location;
		((Control)_chkReq_2).Name = "_chkReq_2";
		((Control)_chkReq_2).RightToLeft = (RightToLeft)0;
		CheckBox chkReq_6 = _chkReq_2;
		size = new Size(97, 17);
		((Control)chkReq_6).Size = size;
		((Control)_chkReq_2).TabIndex = 6;
		((ButtonBase)_chkReq_2).Text = "Inhalation";
		((ButtonBase)_chkReq_2).UseVisualStyleBackColor = false;
		((ButtonBase)_chkReq_1).BackColor = SystemColors.Control;
		((Control)_chkReq_1).Cursor = Cursors.Default;
		((Control)_chkReq_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_chkReq_1).ForeColor = SystemColors.ControlText;
		chkReq.SetIndex(_chkReq_1, (short)1);
		CheckBox chkReq_7 = _chkReq_1;
		location = new Point(39, 256);
		((Control)chkReq_7).Location = location;
		((Control)_chkReq_1).Name = "_chkReq_1";
		((Control)_chkReq_1).RightToLeft = (RightToLeft)0;
		CheckBox chkReq_8 = _chkReq_1;
		size = new Size(129, 17);
		((Control)chkReq_8).Size = size;
		((Control)_chkReq_1).TabIndex = 5;
		((ButtonBase)_chkReq_1).Text = "Drinking Water";
		((ButtonBase)_chkReq_1).UseVisualStyleBackColor = false;
		((ButtonBase)_chkReq_3).BackColor = SystemColors.Control;
		((Control)_chkReq_3).Cursor = Cursors.Default;
		((Control)_chkReq_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_chkReq_3).ForeColor = SystemColors.ControlText;
		chkReq.SetIndex(_chkReq_3, (short)3);
		CheckBox chkReq_9 = _chkReq_3;
		location = new Point(39, 304);
		((Control)chkReq_9).Location = location;
		((Control)_chkReq_3).Name = "_chkReq_3";
		((Control)_chkReq_3).RightToLeft = (RightToLeft)0;
		CheckBox chkReq_10 = _chkReq_3;
		size = new Size(129, 17);
		((Control)chkReq_10).Size = size;
		((Control)_chkReq_3).TabIndex = 7;
		((ButtonBase)_chkReq_3).Text = "Not Required";
		((ButtonBase)_chkReq_3).UseVisualStyleBackColor = false;
		((ButtonBase)_chkReq_4).BackColor = SystemColors.Control;
		((Control)_chkReq_4).Cursor = Cursors.Default;
		((Control)_chkReq_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_chkReq_4).ForeColor = SystemColors.ControlText;
		chkReq.SetIndex(_chkReq_4, (short)4);
		CheckBox chkReq_11 = _chkReq_4;
		location = new Point(39, 328);
		((Control)chkReq_11).Location = location;
		((Control)_chkReq_4).Name = "_chkReq_4";
		((Control)_chkReq_4).RightToLeft = (RightToLeft)0;
		CheckBox chkReq_12 = _chkReq_4;
		size = new Size(139, 20);
		((Control)chkReq_12).Size = size;
		((Control)_chkReq_4).TabIndex = 8;
		((ButtonBase)_chkReq_4).Text = "Other (please specify)";
		((ButtonBase)_chkReq_4).UseVisualStyleBackColor = false;
		txtOtherDesc.AcceptsReturn = true;
		((TextBoxBase)txtOtherDesc).BackColor = SystemColors.Control;
		((Control)txtOtherDesc).Cursor = Cursors.IBeam;
		((Control)txtOtherDesc).Enabled = false;
		((Control)txtOtherDesc).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtOtherDesc).ForeColor = SystemColors.WindowText;
		TextBox obj33 = txtOtherDesc;
		location = new Point(184, 328);
		((Control)obj33).Location = location;
		((TextBoxBase)txtOtherDesc).MaxLength = 100;
		((Control)txtOtherDesc).Name = "txtOtherDesc";
		((Control)txtOtherDesc).RightToLeft = (RightToLeft)0;
		TextBox obj34 = txtOtherDesc;
		size = new Size(153, 20);
		((Control)obj34).Size = size;
		((Control)txtOtherDesc).TabIndex = 9;
		((ButtonBase)CancelButton_Renamed).BackColor = SystemColors.Control;
		((Control)CancelButton_Renamed).Cursor = Cursors.Default;
		CancelButton_Renamed.DialogResult = (DialogResult)2;
		((Control)CancelButton_Renamed).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)CancelButton_Renamed).ForeColor = SystemColors.ControlText;
		Button cancelButton_Renamed = CancelButton_Renamed;
		location = new Point(360, 488);
		((Control)cancelButton_Renamed).Location = location;
		((Control)CancelButton_Renamed).Name = "CancelButton_Renamed";
		((Control)CancelButton_Renamed).RightToLeft = (RightToLeft)0;
		Button cancelButton_Renamed2 = CancelButton_Renamed;
		size = new Size(81, 25);
		((Control)cancelButton_Renamed2).Size = size;
		((Control)CancelButton_Renamed).TabIndex = 30;
		((ButtonBase)CancelButton_Renamed).Text = "Cancel";
		((ButtonBase)CancelButton_Renamed).UseVisualStyleBackColor = false;
		((ButtonBase)OKButton).BackColor = SystemColors.Control;
		((Control)OKButton).Cursor = Cursors.Default;
		((Control)OKButton).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)OKButton).ForeColor = SystemColors.ControlText;
		Button oKButton = OKButton;
		location = new Point(264, 488);
		((Control)oKButton).Location = location;
		((Control)OKButton).Name = "OKButton";
		((Control)OKButton).RightToLeft = (RightToLeft)0;
		Button oKButton2 = OKButton;
		size = new Size(81, 25);
		((Control)oKButton2).Size = size;
		((Control)OKButton).TabIndex = 29;
		((ButtonBase)OKButton).Text = "OK";
		((ButtonBase)OKButton).UseVisualStyleBackColor = false;
		((Control)_Label1_4).BackColor = SystemColors.Control;
		((Control)_Label1_4).Cursor = Cursors.Default;
		((Control)_Label1_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_4).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_4, (short)4);
		Label label1_ = _Label1_4;
		location = new Point(8, 144);
		((Control)label1_).Location = location;
		((Control)_Label1_4).Name = "_Label1_4";
		((Control)_Label1_4).RightToLeft = (RightToLeft)0;
		Label label1_2 = _Label1_4;
		size = new Size(145, 17);
		((Control)label1_2).Size = size;
		((Control)_Label1_4).TabIndex = 40;
		_Label1_4.Text = "Additional PBT Information:";
		_Label1_4.TextAlign = (ContentAlignment)4;
		((Control)_Label1_3).BackColor = SystemColors.Control;
		((Control)_Label1_3).Cursor = Cursors.Default;
		((Control)_Label1_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_3).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_3, (short)3);
		Label label1_3 = _Label1_3;
		location = new Point(16, 88);
		((Control)label1_3).Location = location;
		((Control)_Label1_3).Name = "_Label1_3";
		((Control)_Label1_3).RightToLeft = (RightToLeft)0;
		Label label1_4 = _Label1_3;
		size = new Size(137, 41);
		((Control)label1_4).Size = size;
		((Control)_Label1_3).TabIndex = 39;
		_Label1_3.Text = "Related Cases and Miscellaneous SAT Information:";
		_Label1_3.TextAlign = (ContentAlignment)4;
		((Control)_Label1_2).BackColor = SystemColors.Control;
		((Control)_Label1_2).Cursor = Cursors.Default;
		((Control)_Label1_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_2).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_2, (short)2);
		Label label1_5 = _Label1_2;
		location = new Point(72, 56);
		((Control)label1_5).Location = location;
		((Control)_Label1_2).Name = "_Label1_2";
		((Control)_Label1_2).RightToLeft = (RightToLeft)0;
		Label label1_6 = _Label1_2;
		size = new Size(81, 17);
		((Control)label1_6).Size = size;
		((Control)_Label1_2).TabIndex = 38;
		_Label1_2.Text = "SAT Date:";
		_Label1_2.TextAlign = (ContentAlignment)4;
		((Control)_Line2_4).BackColor = SystemColors.WindowText;
		Line2.SetIndex(_Line2_4, (short)4);
		Label line2_ = _Line2_4;
		location = new Point(39, 200);
		((Control)line2_).Location = location;
		((Control)_Line2_4).Name = "_Line2_4";
		Label line2_2 = _Line2_4;
		size = new Size(650, 1);
		((Control)line2_2).Size = size;
		((Control)_Line2_4).TabIndex = 41;
		((Control)_Line2_3).BackColor = SystemColors.WindowText;
		Line2.SetIndex(_Line2_3, (short)3);
		Label line2_3 = _Line2_3;
		location = new Point(352, 200);
		((Control)line2_3).Location = location;
		((Control)_Line2_3).Name = "_Line2_3";
		Label line2_4 = _Line2_3;
		size = new Size(1, 192);
		((Control)line2_4).Size = size;
		((Control)_Line2_3).TabIndex = 42;
		((Control)_Line2_0).BackColor = SystemColors.WindowText;
		Line2.SetIndex(_Line2_0, (short)0);
		Label line2_5 = _Line2_0;
		location = new Point(48, 472);
		((Control)line2_5).Location = location;
		((Control)_Line2_0).Name = "_Line2_0";
		Label line2_6 = _Line2_0;
		size = new Size(608, 1);
		((Control)line2_6).Size = size;
		((Control)_Line2_0).TabIndex = 43;
		((Control)_Label1_0).BackColor = SystemColors.Control;
		((Control)_Label1_0).Cursor = Cursors.Default;
		((Control)_Label1_0).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_0).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_0, (short)0);
		Label label1_7 = _Label1_0;
		location = new Point(368, 208);
		((Control)label1_7).Location = location;
		((Control)_Label1_0).Name = "_Label1_0";
		((Control)_Label1_0).RightToLeft = (RightToLeft)0;
		Label label1_8 = _Label1_0;
		size = new Size(185, 17);
		((Control)label1_8).Size = size;
		((Control)_Label1_0).TabIndex = 37;
		_Label1_0.Text = "Eco Requirements and Rating:";
		((Control)lblInstructions).BackColor = SystemColors.Control;
		((Control)lblInstructions).Cursor = Cursors.Default;
		((Control)lblInstructions).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblInstructions).ForeColor = SystemColors.ControlText;
		Label obj35 = lblInstructions;
		location = new Point(8, 8);
		((Control)obj35).Location = location;
		((Control)lblInstructions).Name = "lblInstructions";
		((Control)lblInstructions).RightToLeft = (RightToLeft)0;
		Label obj36 = lblInstructions;
		size = new Size(545, 33);
		((Control)obj36).Size = size;
		((Control)lblInstructions).TabIndex = 36;
		lblInstructions.Text = "xxx";
		((Control)_Line2_2).BackColor = SystemColors.WindowText;
		Line2.SetIndex(_Line2_2, (short)2);
		Label line2_7 = _Line2_2;
		location = new Point(56, 432);
		((Control)line2_7).Location = location;
		((Control)_Line2_2).Name = "_Line2_2";
		Label line2_8 = _Line2_2;
		size = new Size(600, 1);
		((Control)line2_8).Size = size;
		((Control)_Line2_2).TabIndex = 44;
		((Control)_Label1_27).BackColor = SystemColors.Control;
		((Control)_Label1_27).Cursor = Cursors.Default;
		((Control)_Label1_27).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_27).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_27, (short)27);
		Label label1_9 = _Label1_27;
		location = new Point(39, 208);
		((Control)label1_9).Location = location;
		((Control)_Label1_27).Name = "_Label1_27";
		((Control)_Label1_27).RightToLeft = (RightToLeft)0;
		Label label1_10 = _Label1_27;
		size = new Size(201, 17);
		((Control)label1_10).Size = size;
		((Control)_Label1_27).TabIndex = 35;
		_Label1_27.Text = "Health Requirements and Rating:";
		((Control)_Line2_1).BackColor = SystemColors.WindowText;
		Line2.SetIndex(_Line2_1, (short)1);
		Label line2_9 = _Line2_1;
		location = new Point(56, 392);
		((Control)line2_9).Location = location;
		((Control)_Line2_1).Name = "_Line2_1";
		Label line2_10 = _Line2_1;
		size = new Size(600, 1);
		((Control)line2_10).Size = size;
		((Control)_Line2_1).TabIndex = 45;
		((Control)_Label1_31).BackColor = SystemColors.Control;
		((Control)_Label1_31).Cursor = Cursors.Default;
		((Control)_Label1_31).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_31).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_31, (short)31);
		Label label1_11 = _Label1_31;
		location = new Point(48, 400);
		((Control)label1_11).Location = location;
		((Control)_Label1_31).Name = "_Label1_31";
		((Control)_Label1_31).RightToLeft = (RightToLeft)0;
		Label label1_12 = _Label1_31;
		size = new Size(145, 17);
		((Control)label1_12).Size = size;
		((Control)_Label1_31).TabIndex = 34;
		_Label1_31.Text = "Migration to Groundwater:";
		_Label1_31.TextAlign = (ContentAlignment)4;
		((Control)_Label1_33).BackColor = SystemColors.Control;
		((Control)_Label1_33).Cursor = Cursors.Default;
		((Control)_Label1_33).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_33).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_33, (short)33);
		Label label1_13 = _Label1_33;
		location = new Point(128, 440);
		((Control)label1_13).Location = location;
		((Control)_Label1_33).Name = "_Label1_33";
		((Control)_Label1_33).RightToLeft = (RightToLeft)0;
		Label label1_14 = _Label1_33;
		size = new Size(65, 17);
		((Control)label1_14).Size = size;
		((Control)_Label1_33).TabIndex = 33;
		_Label1_33.Text = "P Rating:";
		_Label1_33.TextAlign = (ContentAlignment)4;
		((Control)_Label1_34).BackColor = SystemColors.Control;
		((Control)_Label1_34).Cursor = Cursors.Default;
		((Control)_Label1_34).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_34).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_34, (short)34);
		Label label1_15 = _Label1_34;
		location = new Point(264, 440);
		((Control)label1_15).Location = location;
		((Control)_Label1_34).Name = "_Label1_34";
		((Control)_Label1_34).RightToLeft = (RightToLeft)0;
		Label label1_16 = _Label1_34;
		size = new Size(57, 17);
		((Control)label1_16).Size = size;
		((Control)_Label1_34).TabIndex = 32;
		_Label1_34.Text = "B Rating:";
		_Label1_34.TextAlign = (ContentAlignment)4;
		((Control)_Label1_35).BackColor = SystemColors.Control;
		((Control)_Label1_35).Cursor = Cursors.Default;
		((Control)_Label1_35).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_35).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_35, (short)35);
		Label label1_17 = _Label1_35;
		location = new Point(392, 440);
		((Control)label1_17).Location = location;
		((Control)_Label1_35).Name = "_Label1_35";
		((Control)_Label1_35).RightToLeft = (RightToLeft)0;
		Label label1_18 = _Label1_35;
		size = new Size(57, 17);
		((Control)label1_18).Size = size;
		((Control)_Label1_35).TabIndex = 31;
		_Label1_35.Text = "T Rating:";
		_Label1_35.TextAlign = (ContentAlignment)4;
		size = new Size(5, 13);
		((Form)this).AutoScaleBaseSize = size;
		((Form)this).BackColor = SystemColors.Control;
		((Form)this).CancelButton = (IButtonControl)(object)CancelButton_Renamed;
		size = new Size(708, 521);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)cmbEcoXBYesNo);
		((Control)this).Controls.Add((Control)(object)cmbHealthXBYesNo);
		((Control)this).Controls.Add((Control)(object)txtWaterDesc);
		((Control)this).Controls.Add((Control)(object)txtEcoXPDesc);
		((Control)this).Controls.Add((Control)(object)_chkEReq_5);
		((Control)this).Controls.Add((Control)(object)txtHealthXPDesc);
		((Control)this).Controls.Add((Control)(object)_chkReq_5);
		((Control)this).Controls.Add((Control)(object)_chkEReq_3);
		((Control)this).Controls.Add((Control)(object)txtSatAddPbtInfo);
		((Control)this).Controls.Add((Control)(object)txtSatRelatedCases);
		((Control)this).Controls.Add((Control)(object)txtSATdate);
		((Control)this).Controls.Add((Control)(object)txtEcoOther);
		((Control)this).Controls.Add((Control)(object)_chkEReq_4);
		((Control)this).Controls.Add((Control)(object)_chkEReq_2);
		((Control)this).Controls.Add((Control)(object)_chkEReq_1);
		((Control)this).Controls.Add((Control)(object)_chkEReq_0);
		((Control)this).Controls.Add((Control)(object)cmbSatER);
		((Control)this).Controls.Add((Control)(object)cmbM2G);
		((Control)this).Controls.Add((Control)(object)cmbTR);
		((Control)this).Controls.Add((Control)(object)cmbBR);
		((Control)this).Controls.Add((Control)(object)cmbPR);
		((Control)this).Controls.Add((Control)(object)cmbSatHR);
		((Control)this).Controls.Add((Control)(object)txtM2GOther);
		((Control)this).Controls.Add((Control)(object)_chkReq_0);
		((Control)this).Controls.Add((Control)(object)_chkReq_2);
		((Control)this).Controls.Add((Control)(object)_chkReq_1);
		((Control)this).Controls.Add((Control)(object)_chkReq_3);
		((Control)this).Controls.Add((Control)(object)_chkReq_4);
		((Control)this).Controls.Add((Control)(object)txtOtherDesc);
		((Control)this).Controls.Add((Control)(object)CancelButton_Renamed);
		((Control)this).Controls.Add((Control)(object)OKButton);
		((Control)this).Controls.Add((Control)(object)_Label1_4);
		((Control)this).Controls.Add((Control)(object)_Label1_3);
		((Control)this).Controls.Add((Control)(object)_Label1_2);
		((Control)this).Controls.Add((Control)(object)_Line2_4);
		((Control)this).Controls.Add((Control)(object)_Line2_3);
		((Control)this).Controls.Add((Control)(object)_Line2_0);
		((Control)this).Controls.Add((Control)(object)_Label1_0);
		((Control)this).Controls.Add((Control)(object)lblInstructions);
		((Control)this).Controls.Add((Control)(object)_Line2_2);
		((Control)this).Controls.Add((Control)(object)_Label1_27);
		((Control)this).Controls.Add((Control)(object)_Line2_1);
		((Control)this).Controls.Add((Control)(object)_Label1_31);
		((Control)this).Controls.Add((Control)(object)_Label1_33);
		((Control)this).Controls.Add((Control)(object)_Label1_34);
		((Control)this).Controls.Add((Control)(object)_Label1_35);
		((Control)this).Cursor = Cursors.Default;
		((Control)this).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this).ForeColor = SystemColors.Window;
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		location = new Point(250, 150);
		((Form)this).Location = location;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmMDUpdSat";
		((Control)this).RightToLeft = (RightToLeft)0;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Update SAT Data";
		((ISupportInitialize)Label1).EndInit();
		((ISupportInitialize)Line2).EndInit();
		((ISupportInitialize)chkEReq).EndInit();
		((ISupportInitialize)chkReq).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void CancelButton_Renamed_Click(object eventSender, EventArgs eventArgs)
	{
		((Form)this).Close();
	}

	private void chkEReq_CheckStateChanged(object eventSender, EventArgs eventArgs)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Invalid comparison between Unknown and I4
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Invalid comparison between Unknown and I4
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Invalid comparison between Unknown and I4
		short index = chkEReq.GetIndex((CheckBox)eventSender);
		switch (index)
		{
		case 0:
			if ((int)chkEReq[index].CheckState == 1)
			{
				((Control)txtWaterDesc).Enabled = true;
				((TextBoxBase)txtWaterDesc).BackColor = Color.White;
			}
			else
			{
				((Control)txtWaterDesc).Enabled = false;
				((TextBoxBase)txtWaterDesc).BackColor = ((Form)this).BackColor;
			}
			break;
		case 4:
			if ((int)chkEReq[index].CheckState == 1)
			{
				((Control)txtEcoOther).Enabled = true;
				((TextBoxBase)txtEcoOther).BackColor = Color.White;
			}
			else
			{
				((Control)txtEcoOther).Enabled = false;
				((TextBoxBase)txtEcoOther).BackColor = ((Form)this).BackColor;
			}
			break;
		case 5:
			if ((int)chkEReq[index].CheckState == 1)
			{
				txtEcoXPDesc.Text = "Testing desired";
				((Control)txtEcoXPDesc).Enabled = true;
				((TextBoxBase)txtEcoXPDesc).BackColor = Color.White;
				((Control)cmbEcoXBYesNo).Enabled = true;
			}
			else
			{
				txtEcoXPDesc.Text = "No testing desired";
				((Control)txtEcoXPDesc).Enabled = false;
				((TextBoxBase)txtEcoXPDesc).BackColor = ((Form)this).BackColor;
				((Control)cmbEcoXBYesNo).Enabled = false;
			}
			break;
		case 1:
		case 2:
		case 3:
			break;
		}
	}

	private void chkReq_CheckStateChanged(object eventSender, EventArgs eventArgs)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Invalid comparison between Unknown and I4
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Invalid comparison between Unknown and I4
		short index = chkReq.GetIndex((CheckBox)eventSender);
		switch (index)
		{
		case 4:
			if ((int)chkReq[index].CheckState == 1)
			{
				txtOtherDesc.Text = Conversions.ToString(((Control)txtOtherDesc).Tag);
				((Control)txtOtherDesc).Enabled = true;
				((TextBoxBase)txtOtherDesc).BackColor = Color.White;
			}
			else
			{
				((Control)txtOtherDesc).Tag = txtOtherDesc.Text;
				txtOtherDesc.Text = "";
				((Control)txtOtherDesc).Enabled = false;
				((TextBoxBase)txtOtherDesc).BackColor = ((Form)this).BackColor;
			}
			break;
		case 5:
			if ((int)chkReq[index].CheckState == 1)
			{
				txtHealthXPDesc.Text = "Testing desired";
				((Control)txtHealthXPDesc).Enabled = true;
				((TextBoxBase)txtHealthXPDesc).BackColor = Color.White;
				((Control)cmbHealthXBYesNo).Enabled = true;
			}
			else
			{
				((Control)txtHealthXPDesc).Tag = txtHealthXPDesc.Text;
				txtHealthXPDesc.Text = "No testing desired";
				((Control)txtHealthXPDesc).Enabled = false;
				((TextBoxBase)txtHealthXPDesc).BackColor = ((Form)this).BackColor;
				((Control)cmbHealthXBYesNo).Enabled = false;
			}
			break;
		}
	}

	private void cmbM2G_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
	{
		if (cmbM2G.SelectedIndex != -1)
		{
			if (Support.GetItemData((Control)(object)cmbM2G, cmbM2G.SelectedIndex) == 99)
			{
				((TextBoxBase)txtM2GOther).BackColor = Color.White;
				((Control)txtM2GOther).Enabled = true;
			}
			else
			{
				((TextBoxBase)txtM2GOther).BackColor = ((Form)this).BackColor;
				txtM2GOther.Text = "";
				((Control)txtM2GOther).Enabled = false;
			}
		}
	}

	private void frmMDUpdSat_Load(object eventSender, EventArgs eventArgs)
	{
	}

	private void OKButton_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		if (Strings.Len(txtSATdate.Text) > 0 && !Information.IsDate((object)txtSATdate.Text))
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Please enter a valid date", (MsgBoxStyle)64, (object)"Invalid Date");
			((TextBoxBase)txtSATdate).SelectionStart = 0;
			((TextBoxBase)txtSATdate).SelectionLength = Strings.Len(txtSATdate.Text);
			((Control)txtSATdate).Focus();
			return;
		}
		UpdateFrmMain();
		ChemStrX.SetOER();
		checked
		{
			short num = (short)(Globals_Renamed.intNumOps - 1);
			short num2 = 0;
			while (true)
			{
				short num3 = num2;
				short num4 = num;
				if (num3 > num4)
				{
					break;
				}
				object pOpIndex = num2;
				ChemStrX.resetInhRespClass(ref pOpIndex);
				num2 = (short)unchecked(num2 + 1);
			}
			frmMain.DefInstance.cmbExpOps.SelectedIndex = -1;
			Globals_Renamed.gblIWasChanged = true;
			((Form)this).Close();
		}
	}

	public bool SetUp()
	{
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected O, but got Unknown
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected O, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected O, but got Unknown
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected O, but got Unknown
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Expected O, but got Unknown
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
						Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
						Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
						Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						ProjectData.ClearProjectError();
						num2 = 2;
						command.ActiveConnection = Common.MyConn;
						command.CommandText = "pqryGetInstructions";
						command.CommandType = CommandTypeEnum.adCmdStoredProc;
						command.Parameters.Append(command.CreateParameter("pID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, 25));
						Command command2 = command;
						object RecordsAffected = Missing.Value;
						object Parameters = Missing.Value;
						recordset = command2.Execute(out RecordsAffected, ref Parameters);
						command.Parameters.Delete("pID");
						lblInstructions.Text = Conversions.ToString(recordset.Fields[0].Value);
						recordset.Close();
						recordset.CursorLocation = CursorLocationEnum.adUseClient;
						recordset.Open("SELECT * FROM qryTrtSatRatings", Common.MyConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
						cmbSatHR.Items.Clear();
						cmbSatER.Items.Clear();
						cmbPR.Items.Clear();
						cmbBR.Items.Clear();
						cmbTR.Items.Clear();
						while (!recordset.EOF)
						{
							cmbSatHR.Items.Add((object)new ListBoxItem(Conversions.ToString(recordset.Fields[1].Value), Conversions.ToInteger(recordset.Fields[0].Value)));
							cmbSatER.Items.Add((object)new ListBoxItem(Conversions.ToString(recordset.Fields[1].Value), Conversions.ToInteger(recordset.Fields[0].Value)));
							if (Strings.InStr(Conversions.ToString(recordset.Fields[1].Value), "-", (CompareMethod)0) == 0)
							{
								cmbPR.Items.Add((object)new ListBoxItem(Conversions.ToString(recordset.Fields[1].Value), Conversions.ToInteger(recordset.Fields[0].Value)));
								cmbBR.Items.Add((object)new ListBoxItem(Conversions.ToString(recordset.Fields[1].Value), Conversions.ToInteger(recordset.Fields[0].Value)));
								cmbTR.Items.Add((object)new ListBoxItem(Conversions.ToString(recordset.Fields[1].Value), Conversions.ToInteger(recordset.Fields[0].Value)));
							}
							recordset.MoveNext();
						}
						recordset.Close();
						recordset.Open("SELECT * FROM qryTrtM2G", Common.MyConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
						cmbM2G.Items.Clear();
						while (!recordset.EOF)
						{
							cmbM2G.Items.Add((object)new ListBoxItem(Conversions.ToString(recordset.Fields[1].Value), Conversions.ToInteger(recordset.Fields[0].Value)));
							recordset.MoveNext();
						}
						recordset.Close();
						short num3 = (short)(cmbSatHR.Items.Count - 1);
						short num4 = 0;
						short num6;
						while (true)
						{
							short num5 = num4;
							num6 = num3;
							if (num5 > num6)
							{
								break;
							}
							if (Operators.CompareString(Support.GetItemString((Control)(object)cmbSatHR, unchecked((int)num4)), frmMain.DefInstance.lblSATHR.Text, false) == 0)
							{
								cmbSatHR.SelectedIndex = num4;
								break;
							}
							num4 = (short)unchecked(num4 + 1);
						}
						short num7 = (short)(cmbSatER.Items.Count - 1);
						num4 = 0;
						while (true)
						{
							short num8 = num4;
							num6 = num7;
							if (num8 > num6)
							{
								break;
							}
							if (Operators.CompareString(Support.GetItemString((Control)(object)cmbSatER, unchecked((int)num4)), frmMain.DefInstance.lblSATER.Text, false) == 0)
							{
								cmbSatER.SelectedIndex = num4;
								break;
							}
							num4 = (short)unchecked(num4 + 1);
						}
						num4 = 0;
						short num9;
						Label val3;
						string Eobject;
						do
						{
							val3 = frmMain.DefInstance.lblSatHReq[num4];
							Eobject = val3.Text;
							CheckBox pCheck = chkReq[num4];
							ChemStrX.SetCheck(ref Eobject, ref pCheck);
							val3.Text = Eobject;
							num4 = (short)unchecked(num4 + 1);
							num9 = num4;
							num6 = 5;
						}
						while (num9 <= num6);
						txtOtherDesc.Text = frmMain.DefInstance.lblSatHReq[(short)6].Text;
						txtHealthXPDesc.Text = frmMain.DefInstance.lblSatHReq[(short)7].Text;
						txtM2GOther.Text = frmMain.DefInstance.lblSatM2GOther.Text;
						num4 = 0;
						short num10;
						do
						{
							val3 = frmMain.DefInstance.lblSatEReq[num4];
							Eobject = val3.Text;
							CheckBox pCheck = chkEReq[num4];
							ChemStrX.SetCheck(ref Eobject, ref pCheck);
							val3.Text = Eobject;
							num4 = (short)unchecked(num4 + 1);
							num10 = num4;
							num6 = 5;
						}
						while (num10 <= num6);
						if (Strings.Len(frmMain.DefInstance.lblSatEReq[(short)6].Text) > 0)
						{
							txtEcoOther.Text = frmMain.DefInstance.lblSatEReq[(short)6].Text;
						}
						else
						{
							txtEcoOther.Text = "No releases to Water";
						}
						txtEcoXPDesc.Text = frmMain.DefInstance.lblSatEReq[(short)7].Text;
						if (Strings.Len(frmMain.DefInstance.lblCC.Text) > 0)
						{
							txtWaterDesc.Text = frmMain.DefInstance.lblCC.Text;
						}
						else
						{
							txtWaterDesc.Text = "All releases to water with a CC =";
						}
						txtSATdate.Text = frmMain.DefInstance.lblSATdate.Text;
						txtSatRelatedCases.Text = frmMain.DefInstance.txtSatRelatedCases.Text;
						txtSatAddPbtInfo.Text = frmMain.DefInstance.txtSatAddPBTinfo.Text;
						val3 = frmMain.DefInstance.lblSatM2G;
						Eobject = val3.Text;
						ComboBox pCombo = cmbM2G;
						ChemStrX.SetCombo(ref Eobject, ref pCombo);
						cmbM2G = pCombo;
						val3.Text = Eobject;
						val3 = frmMain.DefInstance.lblSatPR;
						Eobject = val3.Text;
						pCombo = cmbPR;
						ChemStrX.SetCombo(ref Eobject, ref pCombo);
						cmbPR = pCombo;
						val3.Text = Eobject;
						val3 = frmMain.DefInstance.lblSatBR;
						Eobject = val3.Text;
						pCombo = cmbBR;
						ChemStrX.SetCombo(ref Eobject, ref pCombo);
						cmbBR = pCombo;
						val3.Text = Eobject;
						val3 = frmMain.DefInstance.lblSatTR;
						Eobject = val3.Text;
						pCombo = cmbTR;
						ChemStrX.SetCombo(ref Eobject, ref pCombo);
						cmbTR = pCombo;
						val3.Text = Eobject;
						cmbHealthXBYesNo.SelectedIndex = 1;
						cmbEcoXBYesNo.SelectedIndex = 1;
						val3 = frmMain.DefInstance.lblSatHReq[(short)8];
						Eobject = val3.Text;
						pCombo = cmbHealthXBYesNo;
						ChemStrX.SetCombo(ref Eobject, ref pCombo);
						cmbHealthXBYesNo = pCombo;
						val3.Text = Eobject;
						val3 = frmMain.DefInstance.lblSatEReq[(short)8];
						Eobject = val3.Text;
						pCombo = cmbEcoXBYesNo;
						ChemStrX.SetCombo(ref Eobject, ref pCombo);
						cmbEcoXBYesNo = pCombo;
						val3.Text = Eobject;
						recordset = null;
						command = null;
						flag = true;
						goto end_IL_0001;
					}
					case 2174:
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
				try0001_dispatch = 2174;
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

	private void UpdateFrmMain()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Invalid comparison between Unknown and I4
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Invalid comparison between Unknown and I4
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Invalid comparison between Unknown and I4
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Invalid comparison between Unknown and I4
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
					if (cmbSatHR.SelectedIndex != -1)
					{
						frmMain.DefInstance.lblSATHR.Text = cmbSatHR.Text;
					}
					if (cmbSatER.SelectedIndex != -1)
					{
						frmMain.DefInstance.lblSATER.Text = cmbSatER.Text;
					}
					short num3 = 0;
					short num4;
					short num5;
					do
					{
						frmMain.DefInstance.lblSatHReq[num3].Text = Conversions.ToString(Interaction.IIf((int)chkReq[num3].CheckState == 1, (object)"Yes", (object)"No"));
						checked
						{
							num3 = (short)unchecked(num3 + 1);
							num4 = num3;
							num5 = 5;
						}
					}
					while (num4 <= num5);
					frmMain.DefInstance.lblSatHReq[(short)6].Text = txtOtherDesc.Text;
					frmMain.DefInstance.lblSatHReq[(short)7].Text = txtHealthXPDesc.Text;
					if (cmbM2G.SelectedIndex != -1)
					{
						frmMain.DefInstance.lblSatM2G.Text = cmbM2G.Text;
					}
					frmMain.DefInstance.lblSatM2GOther.Text = txtM2GOther.Text;
					num3 = 0;
					short num6;
					do
					{
						frmMain.DefInstance.lblSatEReq[num3].Text = Conversions.ToString(Interaction.IIf((int)chkEReq[num3].CheckState == 1, (object)"Yes", (object)"No"));
						checked
						{
							num3 = (short)unchecked(num3 + 1);
							num6 = num3;
							num5 = 5;
						}
					}
					while (num6 <= num5);
					frmMain.DefInstance.lblCC.Text = txtWaterDesc.Text;
					frmMain.DefInstance.lblSatEReq[(short)7].Text = txtEcoXPDesc.Text;
					if ((int)chkReq[(short)5].CheckState == 1)
					{
						frmMain.DefInstance.lblSatHReq[(short)8].Text = cmbHealthXBYesNo.Text;
					}
					else
					{
						frmMain.DefInstance.lblSatHReq[(short)8].Text = "";
					}
					if ((int)chkEReq[(short)5].CheckState == 1)
					{
						frmMain.DefInstance.lblSatEReq[(short)8].Text = cmbEcoXBYesNo.Text;
					}
					else
					{
						frmMain.DefInstance.lblSatEReq[(short)8].Text = "";
					}
					if (Operators.CompareString(frmMain.DefInstance.lblSatEReq[(short)0].Text, "Yes", false) == 0)
					{
						frmMain.DefInstance.lblCC.Text = txtWaterDesc.Text;
					}
					else
					{
						frmMain.DefInstance.lblCC.Text = "";
					}
					if (Operators.CompareString(frmMain.DefInstance.lblSatEReq[(short)4].Text, "Yes", false) == 0)
					{
						frmMain.DefInstance.lblSatEReq[(short)6].Text = txtEcoOther.Text;
					}
					else
					{
						frmMain.DefInstance.lblSatEReq[(short)6].Text = "";
					}
					if (cmbPR.SelectedIndex != -1)
					{
						frmMain.DefInstance.lblSatPR.Text = cmbPR.Text;
					}
					if (cmbBR.SelectedIndex != -1)
					{
						frmMain.DefInstance.lblSatBR.Text = cmbBR.Text;
					}
					if (cmbTR.SelectedIndex != -1)
					{
						frmMain.DefInstance.lblSatTR.Text = cmbTR.Text;
					}
					frmMain.DefInstance.lblSATdate.Text = txtSATdate.Text;
					frmMain.DefInstance.txtSatRelatedCases.Text = txtSatRelatedCases.Text;
					frmMain.DefInstance.txtSatAddPBTinfo.Text = txtSatAddPbtInfo.Text;
					goto end_IL_0001;
				}
				case 1182:
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
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 1182;
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

	private void txtSatAddPbtInfo_Leave(object eventSender, EventArgs eventArgs)
	{
		TextBox obj = txtSatAddPbtInfo;
		TextBox val = txtSatAddPbtInfo;
		string pText = val.Text;
		string text = ChemStrX.TrtLineBreak(ref pText);
		val.Text = pText;
		obj.Text = text;
	}

	private void txtSATdate_Leave(object eventSender, EventArgs eventArgs)
	{
		if (Information.IsDate((object)txtSATdate))
		{
			DateTime dateTime = Conversions.ToDate(txtSATdate.Text);
			txtSATdate.Text = Strings.Format((object)dateTime, Globals_Renamed.gblChemDateFormat);
		}
	}

	private void txtSatRelatedCases_Leave(object eventSender, EventArgs eventArgs)
	{
		TextBox obj = txtSatRelatedCases;
		TextBox val = txtSatRelatedCases;
		string pText = val.Text;
		string text = ChemStrX.TrtLineBreak(ref pText);
		val.Text = pText;
		obj.Text = text;
	}

	private void txtWaterDesc_Leave(object eventSender, EventArgs eventArgs)
	{
		TextBox obj = txtWaterDesc;
		TextBox val = txtWaterDesc;
		string pText = val.Text;
		string text = ChemStrX.TrtLineBreak(ref pText);
		val.Text = pText;
		obj.Text = text;
	}

	private void _Label1_0_Click(object sender, EventArgs e)
	{
	}

	private void _chkReq_5_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void cmbHealthXBYesNo_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void _chkEReq_5_CheckedChanged(object sender, EventArgs e)
	{
	}
}
