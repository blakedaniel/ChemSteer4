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
using Microsoft.VisualBasic.CompilerServices;

namespace ChemSteer;

internal class frmMDUpdNW : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("txtBasis")]
	private TextBox _txtBasis;

	[AccessedThroughProperty("txtEstimated")]
	private TextBox _txtEstimated;

	[AccessedThroughProperty("txtDefault")]
	private TextBox _txtDefault;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("cmdOK")]
	private Button _cmdOK;

	[AccessedThroughProperty("msfNW")]
	private AxMSFlexGrid _msfNW;

	[AccessedThroughProperty("_Label1_4")]
	private Label __Label1_4;

	[AccessedThroughProperty("_Label1_3")]
	private Label __Label1_3;

	[AccessedThroughProperty("_Label1_2")]
	private Label __Label1_2;

	[AccessedThroughProperty("_Label1_1")]
	private Label __Label1_1;

	[AccessedThroughProperty("_Label1_0")]
	private Label __Label1_0;

	[AccessedThroughProperty("lblOperation")]
	private Label _lblOperation;

	private static frmMDUpdNW m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

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
			_txtBasis = value;
		}
	}

	public virtual TextBox txtEstimated
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtEstimated;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtEstimated = value;
		}
	}

	public virtual TextBox txtDefault
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDefault;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDefault = value;
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

	public virtual AxMSFlexGrid msfNW
	{
		[DebuggerNonUserCode]
		get
		{
			return _msfNW;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_msfNW = value;
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

	public virtual Label lblOperation
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblOperation;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblOperation = value;
		}
	}

	public static frmMDUpdNW DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmMDUpdNW();
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

	public frmMDUpdNW()
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected O, but got Unknown
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected O, but got Unknown
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Expected O, but got Unknown
		//IL_0535: Unknown result type (might be due to invalid IL or missing references)
		//IL_053f: Expected O, but got Unknown
		//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ac: Expected O, but got Unknown
		//IL_0666: Unknown result type (might be due to invalid IL or missing references)
		//IL_0670: Expected O, but got Unknown
		//IL_072d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0737: Expected O, but got Unknown
		//IL_07f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fe: Expected O, but got Unknown
		//IL_08b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c0: Expected O, but got Unknown
		//IL_0978: Unknown result type (might be due to invalid IL or missing references)
		//IL_0982: Expected O, but got Unknown
		//IL_0b3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b48: Expected O, but got Unknown
		//IL_0b5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b67: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMDUpdNW));
		txtBasis = new TextBox();
		txtEstimated = new TextBox();
		txtDefault = new TextBox();
		cmdCancel = new Button();
		cmdOK = new Button();
		msfNW = new AxMSFlexGrid();
		_Label1_4 = new Label();
		_Label1_3 = new Label();
		_Label1_2 = new Label();
		_Label1_1 = new Label();
		_Label1_0 = new Label();
		lblOperation = new Label();
		((ISupportInitialize)msfNW).BeginInit();
		((Control)this).SuspendLayout();
		txtBasis.AcceptsReturn = true;
		((TextBoxBase)txtBasis).BackColor = SystemColors.Window;
		((Control)txtBasis).Cursor = Cursors.IBeam;
		((Control)txtBasis).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtBasis).ForeColor = SystemColors.WindowText;
		TextBox obj = txtBasis;
		Point location = new Point(16, 400);
		((Control)obj).Location = location;
		((TextBoxBase)txtBasis).MaxLength = 0;
		txtBasis.Multiline = true;
		((Control)txtBasis).Name = "txtBasis";
		((Control)txtBasis).RightToLeft = (RightToLeft)0;
		txtBasis.ScrollBars = (ScrollBars)2;
		TextBox obj2 = txtBasis;
		Size size = new Size(721, 83);
		((Control)obj2).Size = size;
		((Control)txtBasis).TabIndex = 3;
		txtEstimated.AcceptsReturn = true;
		((TextBoxBase)txtEstimated).BackColor = SystemColors.Window;
		((Control)txtEstimated).Cursor = Cursors.IBeam;
		((Control)txtEstimated).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtEstimated).ForeColor = SystemColors.WindowText;
		TextBox obj3 = txtEstimated;
		location = new Point(344, 360);
		((Control)obj3).Location = location;
		((TextBoxBase)txtEstimated).MaxLength = 0;
		((Control)txtEstimated).Name = "txtEstimated";
		((Control)txtEstimated).RightToLeft = (RightToLeft)0;
		TextBox obj4 = txtEstimated;
		size = new Size(81, 20);
		((Control)obj4).Size = size;
		((Control)txtEstimated).TabIndex = 2;
		txtDefault.AcceptsReturn = true;
		((TextBoxBase)txtDefault).BackColor = SystemColors.Control;
		((Control)txtDefault).Cursor = Cursors.IBeam;
		((Control)txtDefault).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtDefault).ForeColor = SystemColors.WindowText;
		TextBox obj5 = txtDefault;
		location = new Point(344, 336);
		((Control)obj5).Location = location;
		((TextBoxBase)txtDefault).MaxLength = 0;
		((Control)txtDefault).Name = "txtDefault";
		((TextBoxBase)txtDefault).ReadOnly = true;
		((Control)txtDefault).RightToLeft = (RightToLeft)0;
		TextBox obj6 = txtDefault;
		size = new Size(81, 20);
		((Control)obj6).Size = size;
		((Control)txtDefault).TabIndex = 1;
		((ButtonBase)cmdCancel).BackColor = SystemColors.Control;
		((Control)cmdCancel).Cursor = Cursors.Default;
		cmdCancel.DialogResult = (DialogResult)2;
		((Control)cmdCancel).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCancel).ForeColor = SystemColors.ControlText;
		Button obj7 = cmdCancel;
		location = new Point(384, 496);
		((Control)obj7).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		((Control)cmdCancel).RightToLeft = (RightToLeft)0;
		Button obj8 = cmdCancel;
		size = new Size(81, 25);
		((Control)obj8).Size = size;
		((Control)cmdCancel).TabIndex = 5;
		((ButtonBase)cmdCancel).Text = "Cancel";
		((ButtonBase)cmdCancel).UseVisualStyleBackColor = false;
		((ButtonBase)cmdOK).BackColor = SystemColors.Control;
		((Control)cmdOK).Cursor = Cursors.Default;
		((Control)cmdOK).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdOK).ForeColor = SystemColors.ControlText;
		Button obj9 = cmdOK;
		location = new Point(288, 496);
		((Control)obj9).Location = location;
		((Control)cmdOK).Name = "cmdOK";
		((Control)cmdOK).RightToLeft = (RightToLeft)0;
		Button obj10 = cmdOK;
		size = new Size(81, 25);
		((Control)obj10).Size = size;
		((Control)cmdOK).TabIndex = 4;
		((ButtonBase)cmdOK).Text = "OK";
		((ButtonBase)cmdOK).UseVisualStyleBackColor = false;
		AxMSFlexGrid obj11 = msfNW;
		location = new Point(8, 120);
		((Control)obj11).Location = location;
		((Control)msfNW).Name = "msfNW";
		((AxHost)msfNW).OcxState = (State)componentResourceManager.GetObject("msfNW.OcxState");
		AxMSFlexGrid obj12 = msfNW;
		size = new Size(729, 185);
		((Control)obj12).Size = size;
		((Control)msfNW).TabIndex = 0;
		((Control)_Label1_4).BackColor = SystemColors.Control;
		((Control)_Label1_4).Cursor = Cursors.Default;
		((Control)_Label1_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_4).ForeColor = SystemColors.ControlText;
		Label label1_ = _Label1_4;
		location = new Point(16, 384);
		((Control)label1_).Location = location;
		((Control)_Label1_4).Name = "_Label1_4";
		((Control)_Label1_4).RightToLeft = (RightToLeft)0;
		Label label1_2 = _Label1_4;
		size = new Size(121, 17);
		((Control)label1_2).Size = size;
		((Control)_Label1_4).TabIndex = 11;
		_Label1_4.Text = "Basis:";
		((Control)_Label1_3).BackColor = SystemColors.Control;
		((Control)_Label1_3).Cursor = Cursors.Default;
		((Control)_Label1_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_3).ForeColor = SystemColors.ControlText;
		Label label1_3 = _Label1_3;
		location = new Point(16, 360);
		((Control)label1_3).Location = location;
		((Control)_Label1_3).Name = "_Label1_3";
		((Control)_Label1_3).RightToLeft = (RightToLeft)0;
		Label label1_4 = _Label1_3;
		size = new Size(329, 17);
		((Control)label1_4).Size = size;
		((Control)_Label1_3).TabIndex = 10;
		_Label1_3.Text = "Operation total number of workers estimated: ";
		((Control)_Label1_2).BackColor = SystemColors.Control;
		((Control)_Label1_2).Cursor = Cursors.Default;
		((Control)_Label1_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_2).ForeColor = SystemColors.ControlText;
		Label label1_5 = _Label1_2;
		location = new Point(16, 336);
		((Control)label1_5).Location = location;
		((Control)_Label1_2).Name = "_Label1_2";
		((Control)_Label1_2).RightToLeft = (RightToLeft)0;
		Label label1_6 = _Label1_2;
		size = new Size(329, 17);
		((Control)label1_6).Size = size;
		((Control)_Label1_2).TabIndex = 9;
		_Label1_2.Text = "Operation total number of workers default (sum of all activities): ";
		((Control)_Label1_1).BackColor = SystemColors.Control;
		((Control)_Label1_1).Cursor = Cursors.Default;
		((Control)_Label1_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_1).ForeColor = SystemColors.ControlText;
		Label label1_7 = _Label1_1;
		location = new Point(8, 104);
		((Control)label1_7).Location = location;
		((Control)_Label1_1).Name = "_Label1_1";
		((Control)_Label1_1).RightToLeft = (RightToLeft)0;
		Label label1_8 = _Label1_1;
		size = new Size(497, 17);
		((Control)label1_8).Size = size;
		((Control)_Label1_1).TabIndex = 8;
		_Label1_1.Text = "Activities and other Sources of Exposure in the operation";
		((Control)_Label1_0).BackColor = SystemColors.Control;
		((Control)_Label1_0).Cursor = Cursors.Default;
		((Control)_Label1_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_0).ForeColor = SystemColors.ControlText;
		Label label1_9 = _Label1_0;
		location = new Point(8, 40);
		((Control)label1_9).Location = location;
		((Control)_Label1_0).Name = "_Label1_0";
		((Control)_Label1_0).RightToLeft = (RightToLeft)0;
		Label label1_10 = _Label1_0;
		size = new Size(729, 41);
		((Control)label1_10).Size = size;
		((Control)_Label1_0).TabIndex = 7;
		_Label1_0.Text = "This window allows you to view or modify the Operation Total Number of Workers.";
		((Control)lblOperation).BackColor = SystemColors.Control;
		((Control)lblOperation).Cursor = Cursors.Default;
		((Control)lblOperation).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)lblOperation).ForeColor = SystemColors.ControlText;
		Label obj13 = lblOperation;
		location = new Point(8, 8);
		((Control)obj13).Location = location;
		((Control)lblOperation).Name = "lblOperation";
		((Control)lblOperation).RightToLeft = (RightToLeft)0;
		Label obj14 = lblOperation;
		size = new Size(529, 17);
		((Control)obj14).Size = size;
		((Control)lblOperation).TabIndex = 6;
		lblOperation.Text = "x";
		size = new Size(5, 13);
		((Form)this).AutoScaleBaseSize = size;
		((Form)this).BackColor = SystemColors.Control;
		((Form)this).CancelButton = (IButtonControl)(object)cmdCancel;
		size = new Size(758, 536);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)txtBasis);
		((Control)this).Controls.Add((Control)(object)txtEstimated);
		((Control)this).Controls.Add((Control)(object)txtDefault);
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)cmdOK);
		((Control)this).Controls.Add((Control)(object)msfNW);
		((Control)this).Controls.Add((Control)(object)_Label1_4);
		((Control)this).Controls.Add((Control)(object)_Label1_3);
		((Control)this).Controls.Add((Control)(object)_Label1_2);
		((Control)this).Controls.Add((Control)(object)_Label1_1);
		((Control)this).Controls.Add((Control)(object)_Label1_0);
		((Control)this).Controls.Add((Control)(object)lblOperation);
		((Control)this).Cursor = Cursors.Default;
		((Control)this).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		location = new Point(250, 150);
		((Form)this).Location = location;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmMDUpdNW";
		((Control)this).RightToLeft = (RightToLeft)0;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Update Operation Total Number of Workers";
		((ISupportInitialize)msfNW).EndInit();
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
		Globals_Renamed.arOpNumWorkers[1, Globals_Renamed.intOpIndex] = Conversions.ToLong(Common.MyNullCheck0(txtEstimated.Text));
		Globals_Renamed.arOpNumWorkersBasis[Globals_Renamed.intOpIndex] = Common.MyNullCheck(txtBasis.Text);
		Globals_Renamed.gblIWasChanged = true;
		((Form)this).Close();
		((Component)(object)this).Dispose();
	}

	public object SetUp()
	{
		lblOperation.Text = "Selected Operation: " + frmMain.DefInstance.cmbExpOps.Text;
		msfNW[0, 0] = "Activity";
		msfNW[0, 1] = "Route";
		msfNW[0, 2] = "Number of sites, NS";
		msfNW[0, 3] = "Number of workers per site, NWexp";
		msfNW[0, 4] = "Total number of workers, NS x NWexp";
		msfNW[0] = 750;
		msfNW[0] = 5000;
		msfNW[1] = 1800;
		msfNW[2] = 1000;
		msfNW[3] = 1200;
		msfNW[4] = 1500;
		short num = 0;
		checked
		{
			short num2;
			short num3;
			do
			{
				if (Strings.Len(Globals_Renamed.arSelActs[num, Globals_Renamed.intOpIndex]) > 0 && Globals_Renamed.arSelActEa[num, Globals_Renamed.intOpIndex])
				{
					msfNW.AddItem(Globals_Renamed.arSelActs[num, Globals_Renamed.intOpIndex] + "\t" + Globals_Renamed.arActNW_Route[num, Globals_Renamed.intOpIndex] + "\t" + Conversions.ToString(Globals_Renamed.arActNumWorkers[0, num, Globals_Renamed.intOpIndex]) + "\t" + Conversions.ToString(Globals_Renamed.arActNumWorkers[1, num, Globals_Renamed.intOpIndex]) + "\t" + Conversions.ToString(Globals_Renamed.arActNumWorkers[2, num, Globals_Renamed.intOpIndex]));
				}
				num = (short)unchecked(num + 1);
				num2 = num;
				num3 = 24;
			}
			while (num2 <= num3);
			if (msfNW.Rows > 2)
			{
				msfNW.RemoveItem(msfNW.Row);
			}
			txtDefault.Text = Conversions.ToString(Globals_Renamed.arOpNumWorkers[0, Globals_Renamed.intOpIndex]);
			txtEstimated.Text = Conversions.ToString(Globals_Renamed.arOpNumWorkers[1, Globals_Renamed.intOpIndex]);
			txtBasis.Text = Globals_Renamed.arOpNumWorkersBasis[Globals_Renamed.intOpIndex];
			return true;
		}
	}
}
