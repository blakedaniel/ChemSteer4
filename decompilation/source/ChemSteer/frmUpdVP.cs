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

internal class frmUpdVP : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("txtAVPlow")]
	private TextBox _txtAVPlow;

	[AccessedThroughProperty("txtAVPhigh")]
	private TextBox _txtAVPhigh;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("cmdOK")]
	private Button _cmdOK;

	[AccessedThroughProperty("_lblX_1")]
	private Label __lblX_1;

	[AccessedThroughProperty("_lblX_0")]
	private Label __lblX_0;

	[AccessedThroughProperty("lblInstructions")]
	private Label _lblInstructions;

	private static frmUpdVP m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	public virtual TextBox txtAVPlow
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtAVPlow;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtAVPlow = value;
		}
	}

	public virtual TextBox txtAVPhigh
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtAVPhigh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtAVPhigh = value;
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

	public virtual Label _lblX_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblX_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblX_1 = value;
		}
	}

	public virtual Label _lblX_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblX_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblX_0 = value;
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

	public static frmUpdVP DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmUpdVP();
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

	public frmUpdVP()
	{
		((Form)this).Load += frmUpdVP_Load;
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
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected O, but got Unknown
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Expected O, but got Unknown
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Expected O, but got Unknown
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d5: Expected O, but got Unknown
		//IL_059a: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a4: Expected O, but got Unknown
		//IL_070c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0716: Expected O, but got Unknown
		//IL_072b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0735: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmUpdVP));
		ToolTip1 = new ToolTip(components);
		txtAVPlow = new TextBox();
		txtAVPhigh = new TextBox();
		cmdCancel = new Button();
		cmdOK = new Button();
		_lblX_1 = new Label();
		_lblX_0 = new Label();
		lblInstructions = new Label();
		((Control)this).SuspendLayout();
		txtAVPlow.AcceptsReturn = true;
		((TextBoxBase)txtAVPlow).BackColor = SystemColors.Window;
		((Control)txtAVPlow).Cursor = Cursors.IBeam;
		((Control)txtAVPlow).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtAVPlow).ForeColor = SystemColors.WindowText;
		TextBox obj = txtAVPlow;
		Point location = new Point(392, 79);
		((Control)obj).Location = location;
		((TextBoxBase)txtAVPlow).MaxLength = 5;
		((Control)txtAVPlow).Name = "txtAVPlow";
		((Control)txtAVPlow).RightToLeft = (RightToLeft)0;
		TextBox obj2 = txtAVPlow;
		Size size = new Size(49, 20);
		((Control)obj2).Size = size;
		((Control)txtAVPlow).TabIndex = 0;
		txtAVPhigh.AcceptsReturn = true;
		((TextBoxBase)txtAVPhigh).BackColor = SystemColors.Window;
		((Control)txtAVPhigh).Cursor = Cursors.IBeam;
		((Control)txtAVPhigh).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtAVPhigh).ForeColor = SystemColors.WindowText;
		TextBox obj3 = txtAVPhigh;
		location = new Point(392, 102);
		((Control)obj3).Location = location;
		((TextBoxBase)txtAVPhigh).MaxLength = 5;
		((Control)txtAVPhigh).Name = "txtAVPhigh";
		((Control)txtAVPhigh).RightToLeft = (RightToLeft)0;
		TextBox obj4 = txtAVPhigh;
		size = new Size(49, 20);
		((Control)obj4).Size = size;
		((Control)txtAVPhigh).TabIndex = 1;
		((ButtonBase)cmdCancel).BackColor = SystemColors.Control;
		((Control)cmdCancel).Cursor = Cursors.Default;
		((Control)cmdCancel).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCancel).ForeColor = SystemColors.ControlText;
		Button obj5 = cmdCancel;
		location = new Point(232, 152);
		((Control)obj5).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		((Control)cmdCancel).RightToLeft = (RightToLeft)0;
		Button obj6 = cmdCancel;
		size = new Size(89, 25);
		((Control)obj6).Size = size;
		((Control)cmdCancel).TabIndex = 3;
		((ButtonBase)cmdCancel).Text = "Cancel";
		((ButtonBase)cmdCancel).UseVisualStyleBackColor = false;
		((ButtonBase)cmdOK).BackColor = SystemColors.Control;
		((Control)cmdOK).Cursor = Cursors.Default;
		((Control)cmdOK).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdOK).ForeColor = SystemColors.ControlText;
		Button obj7 = cmdOK;
		location = new Point(128, 152);
		((Control)obj7).Location = location;
		((Control)cmdOK).Name = "cmdOK";
		((Control)cmdOK).RightToLeft = (RightToLeft)0;
		Button obj8 = cmdOK;
		size = new Size(89, 25);
		((Control)obj8).Size = size;
		((Control)cmdOK).TabIndex = 2;
		((ButtonBase)cmdOK).Text = "OK";
		((ButtonBase)cmdOK).UseVisualStyleBackColor = false;
		((Control)_lblX_1).BackColor = SystemColors.Control;
		((Control)_lblX_1).Cursor = Cursors.Default;
		((Control)_lblX_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblX_1).ForeColor = SystemColors.ControlText;
		Label lblX_ = _lblX_1;
		location = new Point(-2, 80);
		((Control)lblX_).Location = location;
		((Control)_lblX_1).Name = "_lblX_1";
		((Control)_lblX_1).RightToLeft = (RightToLeft)0;
		Label lblX_2 = _lblX_1;
		size = new Size(388, 18);
		((Control)lblX_2).Size = size;
		((Control)_lblX_1).TabIndex = 6;
		_lblX_1.Text = "AVPlow: Low end of Adjusted Vapor Pressure Range for the assessment:";
		_lblX_1.TextAlign = (ContentAlignment)4;
		((Control)_lblX_0).BackColor = SystemColors.Control;
		((Control)_lblX_0).Cursor = Cursors.Default;
		((Control)_lblX_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblX_0).ForeColor = SystemColors.ControlText;
		Label lblX_3 = _lblX_0;
		location = new Point(1, 104);
		((Control)lblX_3).Location = location;
		((Control)_lblX_0).Name = "_lblX_0";
		((Control)_lblX_0).RightToLeft = (RightToLeft)0;
		Label lblX_4 = _lblX_0;
		size = new Size(385, 17);
		((Control)lblX_4).Size = size;
		((Control)_lblX_0).TabIndex = 5;
		_lblX_0.Text = "AVPhigh: High end of Adjusted Vapor Pressure Range for the assessment:";
		_lblX_0.TextAlign = (ContentAlignment)4;
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
		size = new Size(433, 57);
		((Control)obj10).Size = size;
		((Control)lblInstructions).TabIndex = 4;
		lblInstructions.Text = componentResourceManager.GetString("lblInstructions.Text");
		((Form)this).AcceptButton = (IButtonControl)(object)cmdOK;
		size = new Size(5, 13);
		((Form)this).AutoScaleBaseSize = size;
		((Form)this).BackColor = SystemColors.Control;
		size = new Size(450, 187);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)txtAVPlow);
		((Control)this).Controls.Add((Control)(object)txtAVPhigh);
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)cmdOK);
		((Control)this).Controls.Add((Control)(object)_lblX_1);
		((Control)this).Controls.Add((Control)(object)_lblX_0);
		((Control)this).Controls.Add((Control)(object)lblInstructions);
		((Control)this).Cursor = Cursors.Default;
		((Control)this).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		location = new Point(250, 150);
		((Form)this).Location = location;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmUpdVP";
		((Control)this).RightToLeft = (RightToLeft)0;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Update AVPrange";
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public bool SetUp()
	{
		txtAVPhigh.Text = frmMain.DefInstance.lblAVPhigh.Text;
		txtAVPlow.Text = frmMain.DefInstance.lblAVPlow.Text;
		return true;
	}

	private void cmdCancel_Click(object eventSender, EventArgs eventArgs)
	{
		((Control)this).Tag = "Cancel";
		((Control)this).Hide();
	}

	private void frmUpdVP_Load(object eventSender, EventArgs eventArgs)
	{
	}

	private void cmdOk_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		if ((Versioned.IsNumeric((object)txtAVPhigh.Text) & Versioned.IsNumeric((object)txtAVPlow.Text)) && ((Conversions.ToDouble(txtAVPhigh.Text) > 0.0) & (Conversions.ToDouble(txtAVPlow.Text) > 0.0)))
		{
			bool flag = default(bool);
			if (Operators.CompareString(frmMain.DefInstance.lblAVPhigh.Text, txtAVPhigh.Text, false) != 0)
			{
				frmMain.DefInstance.lblAVPhigh.Text = txtAVPhigh.Text;
				flag = true;
			}
			if (Operators.CompareString(frmMain.DefInstance.lblAVPlow.Text, txtAVPlow.Text, false) != 0)
			{
				frmMain.DefInstance.lblAVPlow.Text = txtAVPlow.Text;
				flag = true;
			}
			if (flag)
			{
				ChemStrX.CheckAVP();
			}
			((Control)this).Hide();
		}
		else
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Please enter valid values for AVPhigh and AVPlow", (MsgBoxStyle)64, (object)"Invalid Data");
		}
	}
}
