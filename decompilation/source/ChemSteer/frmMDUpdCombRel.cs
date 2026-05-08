using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ADODB;
using Microsoft.VisualBasic.Compatibility.VB6;
using Microsoft.VisualBasic.CompilerServices;

namespace ChemSteer;

internal class frmMDUpdCombRel : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("Command4")]
	private Button _Command4;

	[AccessedThroughProperty("Command3")]
	private Button _Command3;

	[AccessedThroughProperty("Command2")]
	private Button _Command2;

	[AccessedThroughProperty("Command1")]
	private Button _Command1;

	[AccessedThroughProperty("Text1")]
	private TextBox _Text1;

	[AccessedThroughProperty("lstSelAct")]
	private ListBox _lstSelAct;

	[AccessedThroughProperty("lstCombAct")]
	private ListBox _lstCombAct;

	[AccessedThroughProperty("lstAvailAct")]
	private ListBox _lstAvailAct;

	[AccessedThroughProperty("cmbMedia")]
	private ComboBox _cmbMedia;

	[AccessedThroughProperty("cmdOk")]
	private Button _cmdOk;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("_Label1_3")]
	private Label __Label1_3;

	[AccessedThroughProperty("_Label1_2")]
	private Label __Label1_2;

	[AccessedThroughProperty("_Label1_1")]
	private Label __Label1_1;

	[AccessedThroughProperty("_Label1_0")]
	private Label __Label1_0;

	[AccessedThroughProperty("lblInstructions")]
	private Label _lblInstructions;

	[AccessedThroughProperty("Label1")]
	private LabelArray _Label1;

	private static frmMDUpdCombRel m_vb6FormDefInstance;

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

	public virtual TextBox Text1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text1 = value;
		}
	}

	public virtual ListBox lstSelAct
	{
		[DebuggerNonUserCode]
		get
		{
			return _lstSelAct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lstSelAct = value;
		}
	}

	public virtual ListBox lstCombAct
	{
		[DebuggerNonUserCode]
		get
		{
			return _lstCombAct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lstCombAct = value;
		}
	}

	public virtual ListBox lstAvailAct
	{
		[DebuggerNonUserCode]
		get
		{
			return _lstAvailAct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lstAvailAct = value;
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

	public static frmMDUpdCombRel DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmMDUpdCombRel();
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

	public frmMDUpdCombRel()
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
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got Unknown
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected O, but got Unknown
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected O, but got Unknown
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Expected O, but got Unknown
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b0: Expected O, but got Unknown
		//IL_0568: Unknown result type (might be due to invalid IL or missing references)
		//IL_0572: Expected O, but got Unknown
		//IL_062a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0634: Expected O, but got Unknown
		//IL_06ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f6: Expected O, but got Unknown
		//IL_07bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c5: Expected O, but got Unknown
		//IL_086c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0876: Expected O, but got Unknown
		//IL_094d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0957: Expected O, but got Unknown
		//IL_0a21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2b: Expected O, but got Unknown
		//IL_0b08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b12: Expected O, but got Unknown
		//IL_0bde: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be8: Expected O, but got Unknown
		//IL_0cb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbe: Expected O, but got Unknown
		//IL_0d8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d94: Expected O, but got Unknown
		//IL_0fa6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb0: Expected O, but got Unknown
		//IL_0fc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fcf: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMDUpdCombRel));
		ToolTip1 = new ToolTip(components);
		Command4 = new Button();
		Command3 = new Button();
		Command2 = new Button();
		Command1 = new Button();
		Text1 = new TextBox();
		lstSelAct = new ListBox();
		lstCombAct = new ListBox();
		lstAvailAct = new ListBox();
		cmbMedia = new ComboBox();
		cmdOk = new Button();
		cmdCancel = new Button();
		_Label1_3 = new Label();
		_Label1_2 = new Label();
		_Label1_1 = new Label();
		_Label1_0 = new Label();
		lblInstructions = new Label();
		Label1 = new LabelArray(components);
		((ISupportInitialize)Label1).BeginInit();
		((Control)this).SuspendLayout();
		((ButtonBase)Command4).BackColor = SystemColors.Control;
		((Control)Command4).Cursor = Cursors.Default;
		((Control)Command4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Command4).ForeColor = SystemColors.ControlText;
		Button command = Command4;
		Point location = new Point(152, 320);
		((Control)command).Location = location;
		((Control)Command4).Name = "Command4";
		((Control)Command4).RightToLeft = (RightToLeft)0;
		Button command2 = Command4;
		Size size = new Size(137, 25);
		((Control)command2).Size = size;
		((Control)Command4).TabIndex = 6;
		((ButtonBase)Command4).Text = "&Make Combination";
		((ButtonBase)Command4).UseVisualStyleBackColor = false;
		((ButtonBase)Command3).BackColor = SystemColors.Control;
		((Control)Command3).Cursor = Cursors.Default;
		((Control)Command3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Command3).ForeColor = SystemColors.ControlText;
		Button command3 = Command3;
		location = new Point(304, 320);
		((Control)command3).Location = location;
		((Control)Command3).Name = "Command3";
		((Control)Command3).RightToLeft = (RightToLeft)0;
		Button command4 = Command3;
		size = new Size(137, 25);
		((Control)command4).Size = size;
		((Control)Command3).TabIndex = 7;
		((ButtonBase)Command3).Text = "&Undo Combination";
		((ButtonBase)Command3).UseVisualStyleBackColor = false;
		((ButtonBase)Command2).BackColor = SystemColors.Control;
		((Control)Command2).Cursor = Cursors.Default;
		((Control)Command2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Command2).ForeColor = SystemColors.ControlText;
		Button command5 = Command2;
		location = new Point(304, 216);
		((Control)command5).Location = location;
		((Control)Command2).Name = "Command2";
		((Control)Command2).RightToLeft = (RightToLeft)0;
		Button command6 = Command2;
		size = new Size(81, 25);
		((Control)command6).Size = size;
		((Control)Command2).TabIndex = 3;
		((ButtonBase)Command2).Text = "&Remove";
		((ButtonBase)Command2).UseVisualStyleBackColor = false;
		((ButtonBase)Command1).BackColor = SystemColors.Control;
		((Control)Command1).Cursor = Cursors.Default;
		((Control)Command1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Command1).ForeColor = SystemColors.ControlText;
		Button command7 = Command1;
		location = new Point(208, 216);
		((Control)command7).Location = location;
		((Control)Command1).Name = "Command1";
		((Control)Command1).RightToLeft = (RightToLeft)0;
		Button command8 = Command1;
		size = new Size(81, 25);
		((Control)command8).Size = size;
		((Control)Command1).TabIndex = 2;
		((ButtonBase)Command1).Text = "&Select";
		((ButtonBase)Command1).UseVisualStyleBackColor = false;
		Text1.AcceptsReturn = true;
		((TextBoxBase)Text1).BackColor = SystemColors.Window;
		((Control)Text1).Cursor = Cursors.IBeam;
		((Control)Text1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)Text1).ForeColor = SystemColors.WindowText;
		TextBox text = Text1;
		location = new Point(536, 272);
		((Control)text).Location = location;
		((TextBoxBase)Text1).MaxLength = 0;
		((Control)Text1).Name = "Text1";
		((Control)Text1).RightToLeft = (RightToLeft)0;
		TextBox text2 = Text1;
		size = new Size(49, 20);
		((Control)text2).Size = size;
		((Control)Text1).TabIndex = 5;
		lstSelAct.BackColor = SystemColors.Window;
		((Control)lstSelAct).Cursor = Cursors.Default;
		lstSelAct.Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		lstSelAct.ForeColor = SystemColors.WindowText;
		lstSelAct.ItemHeight = 14;
		ListBox obj = lstSelAct;
		location = new Point(8, 256);
		((Control)obj).Location = location;
		((Control)lstSelAct).Name = "lstSelAct";
		lstSelAct.RightToLeft = (RightToLeft)0;
		ListBox obj2 = lstSelAct;
		size = new Size(521, 46);
		((Control)obj2).Size = size;
		((Control)lstSelAct).TabIndex = 4;
		lstCombAct.BackColor = SystemColors.Window;
		((Control)lstCombAct).Cursor = Cursors.Default;
		lstCombAct.Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		lstCombAct.ForeColor = SystemColors.WindowText;
		lstCombAct.ItemHeight = 14;
		ListBox obj3 = lstCombAct;
		location = new Point(8, 360);
		((Control)obj3).Location = location;
		((Control)lstCombAct).Name = "lstCombAct";
		lstCombAct.RightToLeft = (RightToLeft)0;
		ListBox obj4 = lstCombAct;
		size = new Size(577, 46);
		((Control)obj4).Size = size;
		((Control)lstCombAct).TabIndex = 8;
		lstAvailAct.BackColor = SystemColors.Window;
		((Control)lstAvailAct).Cursor = Cursors.Default;
		lstAvailAct.Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		lstAvailAct.ForeColor = SystemColors.WindowText;
		lstAvailAct.ItemHeight = 14;
		ListBox obj5 = lstAvailAct;
		location = new Point(8, 144);
		((Control)obj5).Location = location;
		((Control)lstAvailAct).Name = "lstAvailAct";
		lstAvailAct.RightToLeft = (RightToLeft)0;
		ListBox obj6 = lstAvailAct;
		size = new Size(577, 46);
		((Control)obj6).Size = size;
		((Control)lstAvailAct).TabIndex = 1;
		cmbMedia.BackColor = SystemColors.Window;
		((Control)cmbMedia).Cursor = Cursors.Default;
		cmbMedia.DropDownStyle = (ComboBoxStyle)2;
		((Control)cmbMedia).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		cmbMedia.ForeColor = SystemColors.WindowText;
		ComboBox obj7 = cmbMedia;
		location = new Point(8, 96);
		((Control)obj7).Location = location;
		((Control)cmbMedia).Name = "cmbMedia";
		((Control)cmbMedia).RightToLeft = (RightToLeft)0;
		ComboBox obj8 = cmbMedia;
		size = new Size(577, 22);
		((Control)obj8).Size = size;
		((Control)cmbMedia).TabIndex = 0;
		((ButtonBase)cmdOk).BackColor = SystemColors.Control;
		((Control)cmdOk).Cursor = Cursors.Default;
		((Control)cmdOk).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdOk).ForeColor = SystemColors.ControlText;
		Button obj9 = cmdOk;
		location = new Point(208, 416);
		((Control)obj9).Location = location;
		((Control)cmdOk).Name = "cmdOk";
		((Control)cmdOk).RightToLeft = (RightToLeft)0;
		Button obj10 = cmdOk;
		size = new Size(81, 25);
		((Control)obj10).Size = size;
		((Control)cmdOk).TabIndex = 9;
		((ButtonBase)cmdOk).Text = "OK";
		((ButtonBase)cmdOk).UseVisualStyleBackColor = false;
		((ButtonBase)cmdCancel).BackColor = SystemColors.Control;
		((Control)cmdCancel).Cursor = Cursors.Default;
		cmdCancel.DialogResult = (DialogResult)2;
		((Control)cmdCancel).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCancel).ForeColor = SystemColors.ControlText;
		Button obj11 = cmdCancel;
		location = new Point(304, 416);
		((Control)obj11).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		((Control)cmdCancel).RightToLeft = (RightToLeft)0;
		Button obj12 = cmdCancel;
		size = new Size(81, 25);
		((Control)obj12).Size = size;
		((Control)cmdCancel).TabIndex = 10;
		((ButtonBase)cmdCancel).Text = "Cancel";
		((ButtonBase)cmdCancel).UseVisualStyleBackColor = false;
		((Control)_Label1_3).BackColor = SystemColors.Control;
		((Control)_Label1_3).Cursor = Cursors.Default;
		((Control)_Label1_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_3).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_3, (short)3);
		Label label1_ = _Label1_3;
		location = new Point(520, 240);
		((Control)label1_).Location = location;
		((Control)_Label1_3).Name = "_Label1_3";
		((Control)_Label1_3).RightToLeft = (RightToLeft)0;
		Label label1_2 = _Label1_3;
		size = new Size(73, 33);
		((Control)label1_2).Size = size;
		((Control)_Label1_3).TabIndex = 15;
		_Label1_3.Text = "Days of Release:";
		_Label1_3.TextAlign = (ContentAlignment)2;
		((Control)_Label1_2).BackColor = SystemColors.Control;
		((Control)_Label1_2).Cursor = Cursors.Default;
		((Control)_Label1_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_2).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_2, (short)2);
		Label label1_3 = _Label1_2;
		location = new Point(8, 344);
		((Control)label1_3).Location = location;
		((Control)_Label1_2).Name = "_Label1_2";
		((Control)_Label1_2).RightToLeft = (RightToLeft)0;
		Label label1_4 = _Label1_2;
		size = new Size(121, 17);
		((Control)label1_4).Size = size;
		((Control)_Label1_2).TabIndex = 14;
		_Label1_2.Text = "Combinations:";
		((Control)_Label1_1).BackColor = SystemColors.Control;
		((Control)_Label1_1).Cursor = Cursors.Default;
		((Control)_Label1_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_1).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_1, (short)1);
		Label label1_5 = _Label1_1;
		location = new Point(8, 240);
		((Control)label1_5).Location = location;
		((Control)_Label1_1).Name = "_Label1_1";
		((Control)_Label1_1).RightToLeft = (RightToLeft)0;
		Label label1_6 = _Label1_1;
		size = new Size(121, 17);
		((Control)label1_6).Size = size;
		((Control)_Label1_1).TabIndex = 13;
		_Label1_1.Text = "Selected Activities:";
		((Control)_Label1_0).BackColor = SystemColors.Control;
		((Control)_Label1_0).Cursor = Cursors.Default;
		((Control)_Label1_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_0).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_0, (short)0);
		Label label1_7 = _Label1_0;
		location = new Point(8, 128);
		((Control)label1_7).Location = location;
		((Control)_Label1_0).Name = "_Label1_0";
		((Control)_Label1_0).RightToLeft = (RightToLeft)0;
		Label label1_8 = _Label1_0;
		size = new Size(121, 17);
		((Control)label1_8).Size = size;
		((Control)_Label1_0).TabIndex = 12;
		_Label1_0.Text = "Available Activities:";
		((Control)lblInstructions).BackColor = SystemColors.Control;
		((Control)lblInstructions).Cursor = Cursors.Default;
		((Control)lblInstructions).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblInstructions).ForeColor = SystemColors.ControlText;
		Label obj13 = lblInstructions;
		location = new Point(8, 8);
		((Control)obj13).Location = location;
		((Control)lblInstructions).Name = "lblInstructions";
		((Control)lblInstructions).RightToLeft = (RightToLeft)0;
		Label obj14 = lblInstructions;
		size = new Size(513, 81);
		((Control)obj14).Size = size;
		((Control)lblInstructions).TabIndex = 11;
		lblInstructions.Text = "xxx";
		((Form)this).AcceptButton = (IButtonControl)(object)cmdOk;
		size = new Size(5, 13);
		((Form)this).AutoScaleBaseSize = size;
		((Form)this).BackColor = SystemColors.Control;
		((Form)this).CancelButton = (IButtonControl)(object)cmdCancel;
		size = new Size(594, 446);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Command4);
		((Control)this).Controls.Add((Control)(object)Command3);
		((Control)this).Controls.Add((Control)(object)Command2);
		((Control)this).Controls.Add((Control)(object)Command1);
		((Control)this).Controls.Add((Control)(object)Text1);
		((Control)this).Controls.Add((Control)(object)lstSelAct);
		((Control)this).Controls.Add((Control)(object)lstCombAct);
		((Control)this).Controls.Add((Control)(object)lstAvailAct);
		((Control)this).Controls.Add((Control)(object)cmbMedia);
		((Control)this).Controls.Add((Control)(object)cmdOk);
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)_Label1_3);
		((Control)this).Controls.Add((Control)(object)_Label1_2);
		((Control)this).Controls.Add((Control)(object)_Label1_1);
		((Control)this).Controls.Add((Control)(object)_Label1_0);
		((Control)this).Controls.Add((Control)(object)lblInstructions);
		((Control)this).Cursor = Cursors.Default;
		((Control)this).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		location = new Point(250, 150);
		((Form)this).Location = location;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmMDUpdCombRel";
		((Control)this).RightToLeft = (RightToLeft)0;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "View / Update Release Combinations";
		((ISupportInitialize)Label1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void cmdCancel_Click(object eventSender, EventArgs eventArgs)
	{
		((Form)this).Close();
	}

	private void cmdOk_Click(object eventSender, EventArgs eventArgs)
	{
		((Form)this).Close();
	}

	public bool SetUp(ref int pOpID)
	{
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
		Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		command.ActiveConnection = Common.MyConn;
		command.CommandText = "pqryGetInstructions";
		command.CommandType = CommandTypeEnum.adCmdStoredProc;
		command.Parameters.Append(command.CreateParameter("pID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, 4));
		Command command2 = command;
		object RecordsAffected = Missing.Value;
		object Parameters = Missing.Value;
		recordset = command2.Execute(out RecordsAffected, ref Parameters);
		command.Parameters.Delete("pID");
		lblInstructions.Text = Conversions.ToString(recordset.Fields[0].Value);
		recordset.Close();
		recordset = null;
		command = null;
		cmbMedia.Items.Add((object)"Air");
		cmbMedia.Items.Add((object)"Incineration or Landfill");
		cmbMedia.SelectedIndex = 0;
		return true;
	}
}
