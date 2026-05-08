using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ChemSteer;

internal class frmUpdShowSP : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("_chkShowSP_3")]
	private CheckBox __chkShowSP_3;

	[AccessedThroughProperty("_chkShowSP_2")]
	private CheckBox __chkShowSP_2;

	[AccessedThroughProperty("_chkShowSP_1")]
	private CheckBox __chkShowSP_1;

	[AccessedThroughProperty("_chkShowSP_0")]
	private CheckBox __chkShowSP_0;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("cmdOK")]
	private Button _cmdOK;

	[AccessedThroughProperty("lblInstructions")]
	private Label _lblInstructions;

	private static frmUpdShowSP m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	public virtual CheckBox _chkShowSP_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __chkShowSP_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__chkShowSP_3 = value;
		}
	}

	public virtual CheckBox _chkShowSP_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __chkShowSP_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__chkShowSP_2 = value;
		}
	}

	public virtual CheckBox _chkShowSP_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __chkShowSP_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__chkShowSP_1 = value;
		}
	}

	public virtual CheckBox _chkShowSP_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __chkShowSP_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__chkShowSP_0 = value;
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

	public static frmUpdShowSP DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmUpdShowSP();
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

	public frmUpdShowSP()
	{
		((Form)this).Load += frmUpdShowSP_Load;
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
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected O, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected O, but got Unknown
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected O, but got Unknown
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Expected O, but got Unknown
		//IL_04d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Expected O, but got Unknown
		//IL_05a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b3: Expected O, but got Unknown
		//IL_071b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0725: Expected O, but got Unknown
		//IL_073a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0744: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmUpdShowSP));
		ToolTip1 = new ToolTip(components);
		_chkShowSP_3 = new CheckBox();
		_chkShowSP_2 = new CheckBox();
		_chkShowSP_1 = new CheckBox();
		_chkShowSP_0 = new CheckBox();
		cmdCancel = new Button();
		cmdOK = new Button();
		lblInstructions = new Label();
		((Control)this).SuspendLayout();
		((ButtonBase)_chkShowSP_3).BackColor = SystemColors.Control;
		((Control)_chkShowSP_3).Cursor = Cursors.Default;
		((Control)_chkShowSP_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_chkShowSP_3).ForeColor = SystemColors.ControlText;
		CheckBox chkShowSP_ = _chkShowSP_3;
		Point location = new Point(80, 160);
		((Control)chkShowSP_).Location = location;
		((Control)_chkShowSP_3).Name = "_chkShowSP_3";
		((Control)_chkShowSP_3).RightToLeft = (RightToLeft)0;
		CheckBox chkShowSP_2 = _chkShowSP_3;
		Size size = new Size(393, 17);
		((Control)chkShowSP_2).Size = size;
		((Control)_chkShowSP_3).TabIndex = 6;
		((ButtonBase)_chkShowSP_3).Text = "Show Electroplating Bath Additive shared parameters";
		((ButtonBase)_chkShowSP_3).UseVisualStyleBackColor = false;
		((ButtonBase)_chkShowSP_2).BackColor = SystemColors.Control;
		((Control)_chkShowSP_2).Cursor = Cursors.Default;
		((Control)_chkShowSP_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_chkShowSP_2).ForeColor = SystemColors.ControlText;
		CheckBox chkShowSP_3 = _chkShowSP_2;
		location = new Point(80, 136);
		((Control)chkShowSP_3).Location = location;
		((Control)_chkShowSP_2).Name = "_chkShowSP_2";
		((Control)_chkShowSP_2).RightToLeft = (RightToLeft)0;
		CheckBox chkShowSP_4 = _chkShowSP_2;
		size = new Size(393, 17);
		((Control)chkShowSP_4).Size = size;
		((Control)_chkShowSP_2).TabIndex = 5;
		((ButtonBase)_chkShowSP_2).Text = "Show Recirculating Water-Cooling Tower Additive shared parameters";
		((ButtonBase)_chkShowSP_2).UseVisualStyleBackColor = false;
		((ButtonBase)_chkShowSP_1).BackColor = SystemColors.Control;
		((Control)_chkShowSP_1).Cursor = Cursors.Default;
		((Control)_chkShowSP_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_chkShowSP_1).ForeColor = SystemColors.ControlText;
		CheckBox chkShowSP_5 = _chkShowSP_1;
		location = new Point(80, 112);
		((Control)chkShowSP_5).Location = location;
		((Control)_chkShowSP_1).Name = "_chkShowSP_1";
		((Control)_chkShowSP_1).RightToLeft = (RightToLeft)0;
		CheckBox chkShowSP_6 = _chkShowSP_1;
		size = new Size(321, 17);
		((Control)chkShowSP_6).Size = size;
		((Control)_chkShowSP_1).TabIndex = 4;
		((ButtonBase)_chkShowSP_1).Text = "Show Vapor Pressure shared parameters";
		((ButtonBase)_chkShowSP_1).UseVisualStyleBackColor = false;
		((ButtonBase)_chkShowSP_0).BackColor = SystemColors.Control;
		((Control)_chkShowSP_0).Cursor = Cursors.Default;
		((Control)_chkShowSP_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_chkShowSP_0).ForeColor = SystemColors.ControlText;
		CheckBox chkShowSP_7 = _chkShowSP_0;
		location = new Point(80, 88);
		((Control)chkShowSP_7).Location = location;
		((Control)_chkShowSP_0).Name = "_chkShowSP_0";
		((Control)_chkShowSP_0).RightToLeft = (RightToLeft)0;
		CheckBox chkShowSP_8 = _chkShowSP_0;
		size = new Size(321, 17);
		((Control)chkShowSP_8).Size = size;
		((Control)_chkShowSP_0).TabIndex = 3;
		((ButtonBase)_chkShowSP_0).Text = "Show Automobile Spray Painting shared parameters";
		((ButtonBase)_chkShowSP_0).UseVisualStyleBackColor = false;
		((ButtonBase)cmdCancel).BackColor = SystemColors.Control;
		((Control)cmdCancel).Cursor = Cursors.Default;
		((Control)cmdCancel).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCancel).ForeColor = SystemColors.ControlText;
		Button obj = cmdCancel;
		location = new Point(256, 192);
		((Control)obj).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		((Control)cmdCancel).RightToLeft = (RightToLeft)0;
		Button obj2 = cmdCancel;
		size = new Size(89, 25);
		((Control)obj2).Size = size;
		((Control)cmdCancel).TabIndex = 1;
		((ButtonBase)cmdCancel).Text = "Cancel";
		((ButtonBase)cmdCancel).UseVisualStyleBackColor = false;
		((ButtonBase)cmdOK).BackColor = SystemColors.Control;
		((Control)cmdOK).Cursor = Cursors.Default;
		((Control)cmdOK).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdOK).ForeColor = SystemColors.ControlText;
		Button obj3 = cmdOK;
		location = new Point(152, 192);
		((Control)obj3).Location = location;
		((Control)cmdOK).Name = "cmdOK";
		((Control)cmdOK).RightToLeft = (RightToLeft)0;
		Button obj4 = cmdOK;
		size = new Size(89, 25);
		((Control)obj4).Size = size;
		((Control)cmdOK).TabIndex = 0;
		((ButtonBase)cmdOK).Text = "OK";
		((ButtonBase)cmdOK).UseVisualStyleBackColor = false;
		((Control)lblInstructions).BackColor = SystemColors.Control;
		((Control)lblInstructions).Cursor = Cursors.Default;
		((Control)lblInstructions).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblInstructions).ForeColor = SystemColors.ControlText;
		Label obj5 = lblInstructions;
		location = new Point(8, 8);
		((Control)obj5).Location = location;
		((Control)lblInstructions).Name = "lblInstructions";
		((Control)lblInstructions).RightToLeft = (RightToLeft)0;
		Label obj6 = lblInstructions;
		size = new Size(481, 65);
		((Control)obj6).Size = size;
		((Control)lblInstructions).TabIndex = 2;
		lblInstructions.Text = componentResourceManager.GetString("lblInstructions.Text");
		((Form)this).AcceptButton = (IButtonControl)(object)cmdOK;
		size = new Size(5, 13);
		((Form)this).AutoScaleBaseSize = size;
		((Form)this).BackColor = SystemColors.Control;
		size = new Size(497, 236);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)_chkShowSP_3);
		((Control)this).Controls.Add((Control)(object)_chkShowSP_2);
		((Control)this).Controls.Add((Control)(object)_chkShowSP_1);
		((Control)this).Controls.Add((Control)(object)_chkShowSP_0);
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)cmdOK);
		((Control)this).Controls.Add((Control)(object)lblInstructions);
		((Control)this).Cursor = Cursors.Default;
		((Control)this).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		location = new Point(250, 150);
		((Form)this).Location = location;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmUpdShowSP";
		((Control)this).RightToLeft = (RightToLeft)0;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Shared Parameters Display Options";
		((Control)this).ResumeLayout(false);
	}

	public bool SetUp()
	{
		if (Globals_Renamed.arOpSP[43, Globals_Renamed.intOpIndex] == 1f)
		{
			_chkShowSP_0.CheckState = (CheckState)1;
		}
		if (Globals_Renamed.arOpSP[44, Globals_Renamed.intOpIndex] == 1f)
		{
			_chkShowSP_1.CheckState = (CheckState)1;
		}
		if (Globals_Renamed.arOpSP[45, Globals_Renamed.intOpIndex] == 1f)
		{
			_chkShowSP_2.CheckState = (CheckState)1;
		}
		if (Globals_Renamed.arOpSP[46, Globals_Renamed.intOpIndex] == 1f)
		{
			_chkShowSP_3.CheckState = (CheckState)1;
		}
		return true;
	}

	private void cmdCancel_Click(object eventSender, EventArgs eventArgs)
	{
		((Control)this).Tag = "Cancel";
		((Control)this).Hide();
	}

	private void frmUpdShowSP_Load(object eventSender, EventArgs eventArgs)
	{
	}

	private void cmdOk_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Invalid comparison between Unknown and I4
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Invalid comparison between Unknown and I4
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Invalid comparison between Unknown and I4
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Invalid comparison between Unknown and I4
		Globals_Renamed.arOpSP[43, Globals_Renamed.intOpIndex] = Conversions.ToSingle(Interaction.IIf((int)_chkShowSP_0.CheckState == 1, (object)(short)1, (object)0));
		Globals_Renamed.arOpSP[44, Globals_Renamed.intOpIndex] = Conversions.ToSingle(Interaction.IIf((int)_chkShowSP_1.CheckState == 1, (object)(short)1, (object)0));
		Globals_Renamed.arOpSP[45, Globals_Renamed.intOpIndex] = Conversions.ToSingle(Interaction.IIf((int)_chkShowSP_2.CheckState == 1, (object)(short)1, (object)0));
		Globals_Renamed.arOpSP[46, Globals_Renamed.intOpIndex] = Conversions.ToSingle(Interaction.IIf((int)_chkShowSP_3.CheckState == 1, (object)(short)1, (object)0));
		((Control)this).Hide();
	}
}
