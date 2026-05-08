using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AxMSFlexGridLib;
using Microsoft.VisualBasic.Compatibility.VB6;
using Microsoft.VisualBasic.CompilerServices;

namespace ChemSteer;

internal class protocomb : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("Command4")]
	private Button _Command4;

	[AccessedThroughProperty("Command3")]
	private Button _Command3;

	[AccessedThroughProperty("msfComb")]
	private AxMSFlexGrid _msfComb;

	[AccessedThroughProperty("Command2")]
	private Button _Command2;

	[AccessedThroughProperty("Command1")]
	private Button _Command1;

	[AccessedThroughProperty("cmbMedia")]
	private ComboBox _cmbMedia;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("cmdOk")]
	private Button _cmdOk;

	[AccessedThroughProperty("_lblInstructions_1")]
	private Label __lblInstructions_1;

	[AccessedThroughProperty("_lblInstructions_0")]
	private Label __lblInstructions_0;

	[AccessedThroughProperty("lblOp")]
	private Label _lblOp;

	[AccessedThroughProperty("lblInstructions")]
	private LabelArray _lblInstructions;

	private static protocomb m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	public virtual Button Command4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Command4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Command4 = value;
		}
	}

	public virtual Button Command3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Command3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Command3 = value;
		}
	}

	public virtual AxMSFlexGrid msfComb
	{
		[DebuggerNonUserCode]
		get
		{
			return _msfComb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_msfComb = value;
		}
	}

	public virtual Button Command2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Command2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Command2 = value;
		}
	}

	public virtual Button Command1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Command1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Command1 = value;
		}
	}

	public virtual ComboBox cmbMedia
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbMedia;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cmbMedia = value;
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
			_cmdOk = value;
		}
	}

	public virtual Label _lblInstructions_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblInstructions_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblInstructions_1 = value;
		}
	}

	public virtual Label _lblInstructions_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblInstructions_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblInstructions_0 = value;
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

	public virtual LabelArray lblInstructions
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

	public static protocomb DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new protocomb();
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

	public protocomb()
	{
		((Form)this).Load += protocomb_Load;
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
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Expected O, but got Unknown
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Expected O, but got Unknown
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Expected O, but got Unknown
		//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c9: Expected O, but got Unknown
		//IL_06a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06af: Expected O, but got Unknown
		//IL_07d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07de: Expected O, but got Unknown
		//IL_08cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d9: Expected O, but got Unknown
		//IL_09b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c3: Expected O, but got Unknown
		//IL_0ac9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad3: Expected O, but got Unknown
		//IL_0b97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba1: Expected O, but got Unknown
		ResourceManager resourceManager = new ResourceManager(typeof(protocomb));
		components = new Container();
		ToolTip1 = new ToolTip(components);
		ToolTip1.Active = true;
		Command4 = new Button();
		Command3 = new Button();
		msfComb = new AxMSFlexGrid();
		Command2 = new Button();
		Command1 = new Button();
		cmbMedia = new ComboBox();
		cmdCancel = new Button();
		cmdOk = new Button();
		_lblInstructions_1 = new Label();
		_lblInstructions_0 = new Label();
		lblOp = new Label();
		lblInstructions = new LabelArray(components);
		((ISupportInitialize)msfComb).BeginInit();
		((ISupportInitialize)lblInstructions).BeginInit();
		((Form)this).StartPosition = (FormStartPosition)0;
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).Text = "View/Update Release Combinations";
		Size clientSize = new Size(559, 343);
		((Form)this).ClientSize = clientSize;
		Point location = new Point(184, 250);
		((Form)this).Location = location;
		((Form)this).Icon = (Icon)resourceManager.GetObject("protocomb.Icon");
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Form)this).ShowInTaskbar = false;
		((Control)this).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		clientSize = new Size(5, 13);
		((Form)this).AutoScaleBaseSize = clientSize;
		((Form)this).BackColor = SystemColors.Control;
		((Form)this).ControlBox = true;
		((Control)this).Enabled = true;
		((Form)this).KeyPreview = false;
		((Control)this).Cursor = Cursors.Default;
		((Control)this).RightToLeft = (RightToLeft)0;
		((Form)this).HelpButton = false;
		((Form)this).WindowState = (FormWindowState)0;
		((Control)this).Name = "protocomb";
		((ButtonBase)Command4).TextAlign = (ContentAlignment)32;
		((ButtonBase)Command4).Text = "&Uncombine All";
		Button command = Command4;
		clientSize = new Size(89, 25);
		((Control)command).Size = clientSize;
		Button command2 = Command4;
		location = new Point(456, 112);
		((Control)command2).Location = location;
		((Control)Command4).TabIndex = 10;
		((Control)Command4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((ButtonBase)Command4).BackColor = SystemColors.Control;
		((Control)Command4).CausesValidation = true;
		((Control)Command4).Enabled = true;
		((Control)Command4).ForeColor = SystemColors.ControlText;
		((Control)Command4).Cursor = Cursors.Default;
		((Control)Command4).RightToLeft = (RightToLeft)0;
		((Control)Command4).TabStop = true;
		((Control)Command4).Name = "Command4";
		((ButtonBase)Command3).TextAlign = (ContentAlignment)32;
		((ButtonBase)Command3).Text = "&Help";
		Button command3 = Command3;
		clientSize = new Size(81, 25);
		((Control)command3).Size = clientSize;
		Button command4 = Command3;
		location = new Point(336, 304);
		((Control)command4).Location = location;
		((Control)Command3).TabIndex = 8;
		((Control)Command3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((ButtonBase)Command3).BackColor = SystemColors.Control;
		((Control)Command3).CausesValidation = true;
		((Control)Command3).Enabled = true;
		((Control)Command3).ForeColor = SystemColors.ControlText;
		((Control)Command3).Cursor = Cursors.Default;
		((Control)Command3).RightToLeft = (RightToLeft)0;
		((Control)Command3).TabStop = true;
		((Control)Command3).Name = "Command3";
		((AxHost)msfComb).OcxState = (State)resourceManager.GetObject("msfComb.OcxState");
		AxMSFlexGrid obj = msfComb;
		clientSize = new Size(529, 137);
		((Control)obj).Size = clientSize;
		AxMSFlexGrid obj2 = msfComb;
		location = new Point(16, 152);
		((Control)obj2).Location = location;
		((Control)msfComb).TabIndex = 7;
		((Control)msfComb).Name = "msfComb";
		((ButtonBase)Command2).TextAlign = (ContentAlignment)32;
		((ButtonBase)Command2).Text = "&Remove Group";
		Button command5 = Command2;
		clientSize = new Size(89, 25);
		((Control)command5).Size = clientSize;
		Button command6 = Command2;
		location = new Point(352, 112);
		((Control)command6).Location = location;
		((Control)Command2).TabIndex = 6;
		((Control)Command2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((ButtonBase)Command2).BackColor = SystemColors.Control;
		((Control)Command2).CausesValidation = true;
		((Control)Command2).Enabled = true;
		((Control)Command2).ForeColor = SystemColors.ControlText;
		((Control)Command2).Cursor = Cursors.Default;
		((Control)Command2).RightToLeft = (RightToLeft)0;
		((Control)Command2).TabStop = true;
		((Control)Command2).Name = "Command2";
		((ButtonBase)Command1).TextAlign = (ContentAlignment)32;
		((ButtonBase)Command1).Text = "&Add Group";
		Button command7 = Command1;
		clientSize = new Size(89, 25);
		((Control)command7).Size = clientSize;
		Button command8 = Command1;
		location = new Point(248, 112);
		((Control)command8).Location = location;
		((Control)Command1).TabIndex = 5;
		((Control)Command1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((ButtonBase)Command1).BackColor = SystemColors.Control;
		((Control)Command1).CausesValidation = true;
		((Control)Command1).Enabled = true;
		((Control)Command1).ForeColor = SystemColors.ControlText;
		((Control)Command1).Cursor = Cursors.Default;
		((Control)Command1).RightToLeft = (RightToLeft)0;
		((Control)Command1).TabStop = true;
		((Control)Command1).Name = "Command1";
		ComboBox obj3 = cmbMedia;
		clientSize = new Size(217, 21);
		((Control)obj3).Size = clientSize;
		ComboBox obj4 = cmbMedia;
		location = new Point(16, 112);
		((Control)obj4).Location = location;
		cmbMedia.DropDownStyle = (ComboBoxStyle)2;
		((Control)cmbMedia).TabIndex = 4;
		((Control)cmbMedia).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		cmbMedia.BackColor = SystemColors.Window;
		((Control)cmbMedia).CausesValidation = true;
		((Control)cmbMedia).Enabled = true;
		cmbMedia.ForeColor = SystemColors.WindowText;
		cmbMedia.IntegralHeight = true;
		((Control)cmbMedia).Cursor = Cursors.Default;
		((Control)cmbMedia).RightToLeft = (RightToLeft)0;
		cmbMedia.Sorted = false;
		((Control)cmbMedia).TabStop = true;
		((Control)cmbMedia).Visible = true;
		((Control)cmbMedia).Name = "cmbMedia";
		((ButtonBase)cmdCancel).TextAlign = (ContentAlignment)32;
		((Form)this).CancelButton = (IButtonControl)(object)cmdCancel;
		((ButtonBase)cmdCancel).Text = "Cancel";
		Button obj5 = cmdCancel;
		clientSize = new Size(81, 25);
		((Control)obj5).Size = clientSize;
		Button obj6 = cmdCancel;
		location = new Point(240, 304);
		((Control)obj6).Location = location;
		((Control)cmdCancel).TabIndex = 1;
		((Control)cmdCancel).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((ButtonBase)cmdCancel).BackColor = SystemColors.Control;
		((Control)cmdCancel).CausesValidation = true;
		((Control)cmdCancel).Enabled = true;
		((Control)cmdCancel).ForeColor = SystemColors.ControlText;
		((Control)cmdCancel).Cursor = Cursors.Default;
		((Control)cmdCancel).RightToLeft = (RightToLeft)0;
		((Control)cmdCancel).TabStop = true;
		((Control)cmdCancel).Name = "cmdCancel";
		((ButtonBase)cmdOk).TextAlign = (ContentAlignment)32;
		((ButtonBase)cmdOk).Text = "OK";
		Button obj7 = cmdOk;
		clientSize = new Size(81, 25);
		((Control)obj7).Size = clientSize;
		Button obj8 = cmdOk;
		location = new Point(144, 304);
		((Control)obj8).Location = location;
		((Control)cmdOk).TabIndex = 0;
		((Control)cmdOk).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((ButtonBase)cmdOk).BackColor = SystemColors.Control;
		((Control)cmdOk).CausesValidation = true;
		((Control)cmdOk).Enabled = true;
		((Control)cmdOk).ForeColor = SystemColors.ControlText;
		((Control)cmdOk).Cursor = Cursors.Default;
		((Control)cmdOk).RightToLeft = (RightToLeft)0;
		((Control)cmdOk).TabStop = true;
		((Control)cmdOk).Name = "cmdOk";
		_lblInstructions_1.Text = "Press the Help button for more information on combining releases.";
		Label lblInstructions_ = _lblInstructions_1;
		clientSize = new Size(537, 17);
		((Control)lblInstructions_).Size = clientSize;
		Label lblInstructions_2 = _lblInstructions_1;
		location = new Point(8, 80);
		((Control)lblInstructions_2).Location = location;
		((Control)_lblInstructions_1).TabIndex = 9;
		((Control)_lblInstructions_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		_lblInstructions_1.TextAlign = (ContentAlignment)1;
		((Control)_lblInstructions_1).BackColor = SystemColors.Control;
		((Control)_lblInstructions_1).Enabled = true;
		((Control)_lblInstructions_1).ForeColor = SystemColors.ControlText;
		((Control)_lblInstructions_1).Cursor = Cursors.Default;
		((Control)_lblInstructions_1).RightToLeft = (RightToLeft)0;
		_lblInstructions_1.UseMnemonic = true;
		((Control)_lblInstructions_1).Visible = true;
		_lblInstructions_1.AutoSize = false;
		_lblInstructions_1.BorderStyle = (BorderStyle)0;
		((Control)_lblInstructions_1).Name = "_lblInstructions_1";
		_lblInstructions_0.Text = "Chemical Releases are combined within an operation as a default by ChemSTEER every time a release model within an operation is run. You can use this window to view or update these combinations.  Releases can only be combined with releases to the same media. ";
		Label lblInstructions_3 = _lblInstructions_0;
		clientSize = new Size(537, 41);
		((Control)lblInstructions_3).Size = clientSize;
		Label lblInstructions_4 = _lblInstructions_0;
		location = new Point(8, 32);
		((Control)lblInstructions_4).Location = location;
		((Control)_lblInstructions_0).TabIndex = 3;
		((Control)_lblInstructions_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		_lblInstructions_0.TextAlign = (ContentAlignment)1;
		((Control)_lblInstructions_0).BackColor = SystemColors.Control;
		((Control)_lblInstructions_0).Enabled = true;
		((Control)_lblInstructions_0).ForeColor = SystemColors.ControlText;
		((Control)_lblInstructions_0).Cursor = Cursors.Default;
		((Control)_lblInstructions_0).RightToLeft = (RightToLeft)0;
		_lblInstructions_0.UseMnemonic = true;
		((Control)_lblInstructions_0).Visible = true;
		_lblInstructions_0.AutoSize = false;
		_lblInstructions_0.BorderStyle = (BorderStyle)0;
		((Control)_lblInstructions_0).Name = "_lblInstructions_0";
		lblOp.Text = "Operation: User Defined Manufacturing";
		((Control)lblOp).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label obj9 = lblOp;
		clientSize = new Size(473, 17);
		((Control)obj9).Size = clientSize;
		Label obj10 = lblOp;
		location = new Point(8, 8);
		((Control)obj10).Location = location;
		((Control)lblOp).TabIndex = 2;
		lblOp.TextAlign = (ContentAlignment)1;
		((Control)lblOp).BackColor = SystemColors.Control;
		((Control)lblOp).Enabled = true;
		((Control)lblOp).ForeColor = SystemColors.ControlText;
		((Control)lblOp).Cursor = Cursors.Default;
		((Control)lblOp).RightToLeft = (RightToLeft)0;
		lblOp.UseMnemonic = true;
		((Control)lblOp).Visible = true;
		lblOp.AutoSize = false;
		lblOp.BorderStyle = (BorderStyle)0;
		((Control)lblOp).Name = "lblOp";
		((Control)this).Controls.Add((Control)(object)Command4);
		((Control)this).Controls.Add((Control)(object)Command3);
		((Control)this).Controls.Add((Control)(object)msfComb);
		((Control)this).Controls.Add((Control)(object)Command2);
		((Control)this).Controls.Add((Control)(object)Command1);
		((Control)this).Controls.Add((Control)(object)cmbMedia);
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)cmdOk);
		((Control)this).Controls.Add((Control)(object)_lblInstructions_1);
		((Control)this).Controls.Add((Control)(object)_lblInstructions_0);
		((Control)this).Controls.Add((Control)(object)lblOp);
		lblInstructions.SetIndex(_lblInstructions_1, (short)1);
		lblInstructions.SetIndex(_lblInstructions_0, (short)0);
		((ISupportInitialize)lblInstructions).EndInit();
		((ISupportInitialize)msfComb).EndInit();
	}

	private void cmdCancel_Click(object eventSender, EventArgs eventArgs)
	{
		((Form)this).Close();
	}

	private void protocomb_Load(object eventSender, EventArgs eventArgs)
	{
		cmbMedia.Items.Add((object)"Air");
		cmbMedia.Items.Add((object)"Air and Incineration");
		cmbMedia.Items.Add((object)"Destroyed");
		cmbMedia.SelectedIndex = 0;
		msfComb[0, 2] = "#1";
		msfComb[0, 3] = "#2";
		msfComb[0, 4] = "#3";
		msfComb[0, 5] = "Uncombined";
		msfComb[0] = 2500;
		msfComb[1] = 500;
		msfComb[2] = 500;
		msfComb[3] = 500;
		msfComb[4] = 500;
		msfComb[5] = 1200;
		msfComb[1, 0] = "Source/Activity";
		msfComb[1, 1] = "DOR";
		msfComb[1, 2] = "100";
		msfComb[1, 3] = "50";
		msfComb[1, 4] = "50";
		msfComb[2, 0] = "Loading product into railcars";
		msfComb[2, 1] = "200";
		msfComb[2, 2] = "X";
		msfComb[2, 3] = "X";
		msfComb[2, 4] = "X";
		msfComb[2, 5] = "0";
		msfComb[3, 0] = "Cleaning small containers";
		msfComb[3, 1] = "150";
		msfComb[3, 2] = "X";
		msfComb[3, 3] = "X";
		msfComb[3, 5] = "0";
		msfComb[4, 0] = "Miscellaneous Activities";
		msfComb[4, 1] = "100";
		msfComb[4, 2] = "X";
		msfComb[4, 5] = "0";
		short num = 0;
		checked
		{
			short num6;
			short num5;
			do
			{
				msfComb.Row = num;
				short num2 = (short)(msfComb.Cols - 1);
				short num3 = 0;
				while (true)
				{
					short num4 = num3;
					num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					if (num3 > 0)
					{
						msfComb[unchecked((int)num3)] = 4;
					}
					msfComb.Col = num3;
					msfComb.CellFontBold = true;
					num3 = (short)unchecked(num3 + 1);
				}
				num = (short)unchecked(num + 1);
				num6 = num;
				num5 = 1;
			}
			while (num6 <= num5);
		}
	}
}
