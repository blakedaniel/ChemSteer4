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

internal class frmMDUpdRels : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("txtPvOp")]
	private TextBox _txtPvOp;

	[AccessedThroughProperty("txtInput")]
	private TextBox _txtInput;

	[AccessedThroughProperty("chkNoPre")]
	private CheckBox _chkNoPre;

	[AccessedThroughProperty("msfSubOps")]
	private AxMSFlexGrid _msfSubOps;

	[AccessedThroughProperty("cmdRemove")]
	private Button _cmdRemove;

	[AccessedThroughProperty("cmdAdd")]
	private Button _cmdAdd;

	[AccessedThroughProperty("lstAvailOps")]
	private ListBox _lstAvailOps;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("cmdOk")]
	private Button _cmdOk;

	[AccessedThroughProperty("_Label1_0")]
	private Label __Label1_0;

	[AccessedThroughProperty("lblInstructions")]
	private Label _lblInstructions;

	[AccessedThroughProperty("lblOp")]
	private Label _lblOp;

	[AccessedThroughProperty("_Label1_2")]
	private Label __Label1_2;

	[AccessedThroughProperty("Label1")]
	private LabelArray _Label1;

	private static frmMDUpdRels m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	private bool[] COFarNoPre;

	private float[] COFarOpPV;

	private short[,] COFarSubOpID;

	private float[,] COFarSubPVf;

	private float[,] COFarSubPvOp;

	private float MyPv;

	private float MyPvf;

	private double PvAss;

	public virtual TextBox txtPvOp
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtPvOp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtPvOp = value;
		}
	}

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
			EventHandler eventHandler = txtInput_TextChanged;
			if (_txtInput != null)
			{
				((Control)_txtInput).TextChanged -= eventHandler;
			}
			_txtInput = value;
			if (_txtInput != null)
			{
				((Control)_txtInput).TextChanged += eventHandler;
			}
		}
	}

	public virtual CheckBox chkNoPre
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkNoPre;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = chkNoPre_CheckStateChanged;
			if (_chkNoPre != null)
			{
				_chkNoPre.CheckStateChanged -= eventHandler;
			}
			_chkNoPre = value;
			if (_chkNoPre != null)
			{
				_chkNoPre.CheckStateChanged += eventHandler;
			}
		}
	}

	public virtual AxMSFlexGrid msfSubOps
	{
		[DebuggerNonUserCode]
		get
		{
			return _msfSubOps;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = msfSubOps_Scroll;
			EventHandler eventHandler2 = msfSubOps_DblClick;
			EventHandler eventHandler3 = msfSubOps_ClickEvent;
			if (_msfSubOps != null)
			{
				_msfSubOps.Scroll -= eventHandler;
				_msfSubOps.DblClick -= eventHandler2;
				_msfSubOps.ClickEvent -= eventHandler3;
			}
			_msfSubOps = value;
			if (_msfSubOps != null)
			{
				_msfSubOps.Scroll += eventHandler;
				_msfSubOps.DblClick += eventHandler2;
				_msfSubOps.ClickEvent += eventHandler3;
			}
		}
	}

	public virtual Button cmdRemove
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdRemove;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdRemove_Click;
			if (_cmdRemove != null)
			{
				((Control)_cmdRemove).Click -= eventHandler;
			}
			_cmdRemove = value;
			if (_cmdRemove != null)
			{
				((Control)_cmdRemove).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdAdd
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdAdd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdAdd_Click;
			if (_cmdAdd != null)
			{
				((Control)_cmdAdd).Click -= eventHandler;
			}
			_cmdAdd = value;
			if (_cmdAdd != null)
			{
				((Control)_cmdAdd).Click += eventHandler;
			}
		}
	}

	public virtual ListBox lstAvailOps
	{
		[DebuggerNonUserCode]
		get
		{
			return _lstAvailOps;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = lstAvailOps_DoubleClick;
			if (_lstAvailOps != null)
			{
				((Control)_lstAvailOps).DoubleClick -= eventHandler;
			}
			_lstAvailOps = value;
			if (_lstAvailOps != null)
			{
				((Control)_lstAvailOps).DoubleClick += eventHandler;
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

	public static frmMDUpdRels DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmMDUpdRels();
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

	public frmMDUpdRels()
	{
		((Form)this).Load += frmMDUpdRels_Load;
		__ENCAddToList(this);
		COFarSubOpID = new short[2, 2];
		COFarSubPVf = new float[2, 2];
		COFarSubPvOp = new float[2, 2];
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
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected O, but got Unknown
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected O, but got Unknown
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Expected O, but got Unknown
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Expected O, but got Unknown
		//IL_050c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Expected O, but got Unknown
		//IL_05df: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e9: Expected O, but got Unknown
		//IL_06bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c5: Expected O, but got Unknown
		//IL_078e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0798: Expected O, but got Unknown
		//IL_0861: Unknown result type (might be due to invalid IL or missing references)
		//IL_086b: Expected O, but got Unknown
		//IL_0955: Unknown result type (might be due to invalid IL or missing references)
		//IL_095f: Expected O, but got Unknown
		//IL_0a18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a22: Expected O, but got Unknown
		//IL_0ada: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae4: Expected O, but got Unknown
		//IL_0cd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce0: Expected O, but got Unknown
		//IL_0cf5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cff: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMDUpdRels));
		ToolTip1 = new ToolTip(components);
		txtPvOp = new TextBox();
		txtInput = new TextBox();
		chkNoPre = new CheckBox();
		msfSubOps = new AxMSFlexGrid();
		cmdRemove = new Button();
		cmdAdd = new Button();
		lstAvailOps = new ListBox();
		cmdCancel = new Button();
		cmdOk = new Button();
		_Label1_0 = new Label();
		lblInstructions = new Label();
		lblOp = new Label();
		_Label1_2 = new Label();
		Label1 = new LabelArray(components);
		((ISupportInitialize)msfSubOps).BeginInit();
		((ISupportInitialize)Label1).BeginInit();
		((Control)this).SuspendLayout();
		txtPvOp.AcceptsReturn = true;
		((TextBoxBase)txtPvOp).BackColor = Color.White;
		((Control)txtPvOp).Cursor = Cursors.IBeam;
		((Control)txtPvOp).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtPvOp).ForeColor = SystemColors.WindowText;
		TextBox obj = txtPvOp;
		Point location = new Point(392, 168);
		((Control)obj).Location = location;
		((TextBoxBase)txtPvOp).MaxLength = 0;
		((Control)txtPvOp).Name = "txtPvOp";
		((Control)txtPvOp).RightToLeft = (RightToLeft)0;
		TextBox obj2 = txtPvOp;
		Size size = new Size(73, 20);
		((Control)obj2).Size = size;
		((Control)txtPvOp).TabIndex = 11;
		((Control)txtPvOp).Visible = false;
		txtInput.AcceptsReturn = true;
		((TextBoxBase)txtInput).BackColor = Color.FromArgb(255, 255, 192);
		((Control)txtInput).Cursor = Cursors.IBeam;
		((Control)txtInput).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtInput).ForeColor = SystemColors.WindowText;
		TextBox obj3 = txtInput;
		location = new Point(16, 392);
		((Control)obj3).Location = location;
		((TextBoxBase)txtInput).MaxLength = 0;
		((Control)txtInput).Name = "txtInput";
		((Control)txtInput).RightToLeft = (RightToLeft)0;
		TextBox obj4 = txtInput;
		size = new Size(65, 20);
		((Control)obj4).Size = size;
		((Control)txtInput).TabIndex = 10;
		((Control)txtInput).Visible = false;
		((ButtonBase)chkNoPre).BackColor = SystemColors.Control;
		((Control)chkNoPre).Cursor = Cursors.Default;
		((Control)chkNoPre).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)chkNoPre).ForeColor = SystemColors.ControlText;
		CheckBox obj5 = chkNoPre;
		location = new Point(8, 168);
		((Control)obj5).Location = location;
		((Control)chkNoPre).Name = "chkNoPre";
		((Control)chkNoPre).RightToLeft = (RightToLeft)0;
		CheckBox obj6 = chkNoPre;
		size = new Size(241, 17);
		((Control)obj6).Size = size;
		((Control)chkNoPre).TabIndex = 0;
		((ButtonBase)chkNoPre).Text = "This operation has no preceding operations.";
		((ButtonBase)chkNoPre).UseVisualStyleBackColor = false;
		AxMSFlexGrid obj7 = msfSubOps;
		location = new Point(8, 304);
		((Control)obj7).Location = location;
		((Control)msfSubOps).Name = "msfSubOps";
		((AxHost)msfSubOps).OcxState = (State)componentResourceManager.GetObject("msfSubOps.OcxState");
		AxMSFlexGrid obj8 = msfSubOps;
		size = new Size(465, 73);
		((Control)obj8).Size = size;
		((Control)msfSubOps).TabIndex = 4;
		((ButtonBase)cmdRemove).BackColor = SystemColors.Control;
		((Control)cmdRemove).Cursor = Cursors.Default;
		((Control)cmdRemove).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdRemove).ForeColor = SystemColors.ControlText;
		Button obj9 = cmdRemove;
		location = new Point(248, 272);
		((Control)obj9).Location = location;
		((Control)cmdRemove).Name = "cmdRemove";
		((Control)cmdRemove).RightToLeft = (RightToLeft)0;
		Button obj10 = cmdRemove;
		size = new Size(105, 25);
		((Control)obj10).Size = size;
		((Control)cmdRemove).TabIndex = 3;
		((ButtonBase)cmdRemove).Text = "&Remove from list";
		((ButtonBase)cmdRemove).UseVisualStyleBackColor = false;
		((ButtonBase)cmdAdd).BackColor = SystemColors.Control;
		((Control)cmdAdd).Cursor = Cursors.Default;
		((Control)cmdAdd).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdAdd).ForeColor = SystemColors.ControlText;
		Button obj11 = cmdAdd;
		location = new Point(128, 272);
		((Control)obj11).Location = location;
		((Control)cmdAdd).Name = "cmdAdd";
		((Control)cmdAdd).RightToLeft = (RightToLeft)0;
		Button obj12 = cmdAdd;
		size = new Size(105, 25);
		((Control)obj12).Size = size;
		((Control)cmdAdd).TabIndex = 2;
		((ButtonBase)cmdAdd).Text = "&Add to list";
		((ButtonBase)cmdAdd).UseVisualStyleBackColor = false;
		lstAvailOps.BackColor = SystemColors.Window;
		((Control)lstAvailOps).Cursor = Cursors.Default;
		lstAvailOps.Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		lstAvailOps.ForeColor = SystemColors.WindowText;
		lstAvailOps.ItemHeight = 14;
		ListBox obj13 = lstAvailOps;
		location = new Point(8, 216);
		((Control)obj13).Location = location;
		((Control)lstAvailOps).Name = "lstAvailOps";
		lstAvailOps.RightToLeft = (RightToLeft)0;
		ListBox obj14 = lstAvailOps;
		size = new Size(465, 46);
		((Control)obj14).Size = size;
		lstAvailOps.Sorted = true;
		((Control)lstAvailOps).TabIndex = 1;
		((ButtonBase)cmdCancel).BackColor = SystemColors.Control;
		((Control)cmdCancel).Cursor = Cursors.Default;
		cmdCancel.DialogResult = (DialogResult)2;
		((Control)cmdCancel).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCancel).ForeColor = SystemColors.ControlText;
		Button obj15 = cmdCancel;
		location = new Point(248, 384);
		((Control)obj15).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		((Control)cmdCancel).RightToLeft = (RightToLeft)0;
		Button obj16 = cmdCancel;
		size = new Size(81, 25);
		((Control)obj16).Size = size;
		((Control)cmdCancel).TabIndex = 6;
		((ButtonBase)cmdCancel).Text = "Cancel";
		((ButtonBase)cmdCancel).UseVisualStyleBackColor = false;
		((ButtonBase)cmdOk).BackColor = SystemColors.Control;
		((Control)cmdOk).Cursor = Cursors.Default;
		((Control)cmdOk).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdOk).ForeColor = SystemColors.ControlText;
		Button obj17 = cmdOk;
		location = new Point(152, 384);
		((Control)obj17).Location = location;
		((Control)cmdOk).Name = "cmdOk";
		((Control)cmdOk).RightToLeft = (RightToLeft)0;
		Button obj18 = cmdOk;
		size = new Size(81, 25);
		((Control)obj18).Size = size;
		((Control)cmdOk).TabIndex = 5;
		((ButtonBase)cmdOk).Text = "OK";
		((ButtonBase)cmdOk).UseVisualStyleBackColor = false;
		((Control)_Label1_0).BackColor = SystemColors.Control;
		((Control)_Label1_0).Cursor = Cursors.Default;
		((Control)_Label1_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_0).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_0, (short)0);
		Label label1_ = _Label1_0;
		location = new Point(336, 168);
		((Control)label1_).Location = location;
		((Control)_Label1_0).Name = "_Label1_0";
		((Control)_Label1_0).RightToLeft = (RightToLeft)0;
		Label label1_2 = _Label1_0;
		size = new Size(49, 17);
		((Control)label1_2).Size = size;
		((Control)_Label1_0).TabIndex = 12;
		_Label1_0.Text = "PVop:";
		_Label1_0.TextAlign = (ContentAlignment)4;
		((Control)_Label1_0).Visible = false;
		((Control)lblInstructions).BackColor = SystemColors.Control;
		((Control)lblInstructions).Cursor = Cursors.Default;
		((Control)lblInstructions).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblInstructions).ForeColor = SystemColors.ControlText;
		Label obj19 = lblInstructions;
		location = new Point(8, 40);
		((Control)obj19).Location = location;
		((Control)lblInstructions).Name = "lblInstructions";
		((Control)lblInstructions).RightToLeft = (RightToLeft)0;
		Label obj20 = lblInstructions;
		size = new Size(465, 121);
		((Control)obj20).Size = size;
		((Control)lblInstructions).TabIndex = 9;
		lblInstructions.Text = "xxx";
		((Control)lblOp).BackColor = SystemColors.Control;
		((Control)lblOp).Cursor = Cursors.Default;
		((Control)lblOp).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)lblOp).ForeColor = SystemColors.ControlText;
		Label obj21 = lblOp;
		location = new Point(8, 16);
		((Control)obj21).Location = location;
		((Control)lblOp).Name = "lblOp";
		((Control)lblOp).RightToLeft = (RightToLeft)0;
		Label obj22 = lblOp;
		size = new Size(473, 17);
		((Control)obj22).Size = size;
		((Control)lblOp).TabIndex = 8;
		lblOp.Text = "x";
		((Control)_Label1_2).BackColor = SystemColors.Control;
		((Control)_Label1_2).Cursor = Cursors.Default;
		((Control)_Label1_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_2).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_2, (short)2);
		Label label1_3 = _Label1_2;
		location = new Point(8, 200);
		((Control)label1_3).Location = location;
		((Control)_Label1_2).Name = "_Label1_2";
		((Control)_Label1_2).RightToLeft = (RightToLeft)0;
		Label label1_4 = _Label1_2;
		size = new Size(129, 17);
		((Control)label1_4).Size = size;
		((Control)_Label1_2).TabIndex = 7;
		_Label1_2.Text = "Available Operations:";
		((Form)this).AcceptButton = (IButtonControl)(object)cmdOk;
		size = new Size(5, 13);
		((Form)this).AutoScaleBaseSize = size;
		((Form)this).BackColor = SystemColors.Control;
		((Form)this).CancelButton = (IButtonControl)(object)cmdCancel;
		size = new Size(483, 422);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)txtPvOp);
		((Control)this).Controls.Add((Control)(object)txtInput);
		((Control)this).Controls.Add((Control)(object)chkNoPre);
		((Control)this).Controls.Add((Control)(object)msfSubOps);
		((Control)this).Controls.Add((Control)(object)cmdRemove);
		((Control)this).Controls.Add((Control)(object)cmdAdd);
		((Control)this).Controls.Add((Control)(object)lstAvailOps);
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)cmdOk);
		((Control)this).Controls.Add((Control)(object)_Label1_0);
		((Control)this).Controls.Add((Control)(object)lblInstructions);
		((Control)this).Controls.Add((Control)(object)lblOp);
		((Control)this).Controls.Add((Control)(object)_Label1_2);
		((Control)this).Cursor = Cursors.Default;
		((Control)this).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		location = new Point(275, 150);
		((Form)this).Location = location;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmMDUpdRels";
		((Control)this).RightToLeft = (RightToLeft)0;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Update Operation Relationships";
		((ISupportInitialize)msfSubOps).EndInit();
		((ISupportInitialize)Label1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public bool SetUp()
	{
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Expected O, but got Unknown
		int try0001_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
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
						command.Parameters.Append(command.CreateParameter("pID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, 24));
						Command command2 = command;
						object RecordsAffected = Missing.Value;
						object Parameters = Missing.Value;
						recordset = command2.Execute(out RecordsAffected, ref Parameters);
						command.Parameters.Delete("pID");
						lblInstructions.Text = Conversions.ToString(recordset.Fields[0].Value);
						recordset.Close();
						COFarNoPre = new bool[Globals_Renamed.intNumOps + 1];
						COFarOpPV = new float[Globals_Renamed.intNumOps + 1];
						COFarSubOpID = new short[11, Globals_Renamed.intNumOps + 1];
						COFarSubPVf = new float[11, Globals_Renamed.intNumOps + 1];
						COFarSubPvOp = new float[11, Globals_Renamed.intNumOps + 1];
						short num3 = (short)(Globals_Renamed.intOpIndex + 1);
						MyPv = (float)Globals_Renamed.arOpPv[Globals_Renamed.intOpIndex];
						if (Versioned.IsNumeric((object)frmMain.DefInstance.lblPV.Text))
						{
							MyPvf = (float)((double)MyPv / Conversions.ToDouble(frmMain.DefInstance.lblPV.Text));
						}
						else
						{
							MyPvf = 0f;
						}
						Parameters = Globals_Renamed.arNoPre;
						RecordsAffected = COFarNoPre;
						ChemStrX.Clone1DArray(ref Parameters, ref RecordsAffected, ref Globals_Renamed.intNumOps);
						COFarNoPre = (bool[])RecordsAffected;
						Globals_Renamed.arNoPre = (bool[])Parameters;
						Parameters = Globals_Renamed.arOpPv;
						RecordsAffected = COFarOpPV;
						ChemStrX.Clone1DArray(ref Parameters, ref RecordsAffected, ref Globals_Renamed.intNumOps);
						COFarOpPV = (float[])RecordsAffected;
						Globals_Renamed.arOpPv = (double[])Parameters;
						Parameters = Globals_Renamed.arSubOpID;
						RecordsAffected = COFarSubOpID;
						short pDim = 10;
						ChemStrX.Clone2DArray(ref Parameters, ref RecordsAffected, ref pDim, ref Globals_Renamed.intNumOps);
						COFarSubOpID = (short[,])RecordsAffected;
						Globals_Renamed.arSubOpID = (short[,])Parameters;
						Parameters = Globals_Renamed.arSubPVf;
						RecordsAffected = COFarSubPVf;
						pDim = 10;
						ChemStrX.Clone2DArray(ref Parameters, ref RecordsAffected, ref pDim, ref Globals_Renamed.intNumOps);
						COFarSubPVf = (float[,])RecordsAffected;
						Globals_Renamed.arSubPVf = (float[,])Parameters;
						Parameters = Globals_Renamed.arSubPvOp;
						RecordsAffected = COFarSubPvOp;
						pDim = 10;
						ChemStrX.Clone2DArray(ref Parameters, ref RecordsAffected, ref pDim, ref Globals_Renamed.intNumOps);
						COFarSubPvOp = (float[,])RecordsAffected;
						Globals_Renamed.arSubPvOp = (double[,])Parameters;
						short num4 = (short)(Globals_Renamed.intNumOps - 1);
						short num5 = 0;
						while (true)
						{
							short num6 = num5;
							short num7 = num4;
							if (num6 > num7)
							{
								break;
							}
							short num8 = 0;
							short num9;
							do
							{
								if (Globals_Renamed.arSubOpID[num8, num5] == num3)
								{
									flag = true;
									break;
								}
								num8 = (short)unchecked(num8 + 1);
								num9 = num8;
								num7 = 9;
							}
							while (num9 <= num7);
							num5 = (short)unchecked(num5 + 1);
						}
						if (flag)
						{
							((Control)chkNoPre).Enabled = false;
							flag = false;
						}
						else if (Globals_Renamed.arNoPre[Globals_Renamed.intOpIndex])
						{
							chkNoPre.CheckState = (CheckState)1;
						}
						else
						{
							chkNoPre.CheckState = (CheckState)0;
						}
						short num10 = (short)(Globals_Renamed.intNumOps - 1);
						num5 = 0;
						while (true)
						{
							short num11 = num5;
							short num7 = num10;
							if (num11 > num7)
							{
								break;
							}
							if (num5 == Globals_Renamed.intOpIndex)
							{
								lblOp.Text = "Selected Operation: " + Globals_Renamed.arOpName[Globals_Renamed.intOpIndex];
							}
							else
							{
								flag = false;
								short num8 = 0;
								short num12;
								do
								{
									if (Globals_Renamed.arSubOpID[num8, Globals_Renamed.intOpIndex] == num5 + 1)
									{
										msfSubOps.AddItem(Conversions.ToString(num5 + 1) + "\t" + Globals_Renamed.arOpName[num5] + "\t" + Conversions.ToString(COFarSubPVf[num8, Globals_Renamed.intOpIndex]) + "\t" + Conversions.ToString(COFarSubPvOp[num8, Globals_Renamed.intOpIndex]));
										flag = true;
										break;
									}
									num8 = (short)unchecked(num8 + 1);
									num12 = num8;
									num7 = 9;
								}
								while (num12 <= num7);
								if (!flag & !Globals_Renamed.arNoPre[num5])
								{
									lstAvailOps.Items.Add((object)new ListBoxItem(Globals_Renamed.arOpName[num5], num5 + 1));
								}
							}
							num5 = (short)unchecked(num5 + 1);
						}
						recordset = null;
						command = null;
						flag2 = true;
						goto end_IL_0001;
					}
					case 1344:
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
				try0001_dispatch = 1344;
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

	private void chkNoPre_CheckStateChanged(object eventSender, EventArgs eventArgs)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		if ((int)chkNoPre.CheckState == 1)
		{
			((Control)txtPvOp).Visible = true;
			((Control)Label1[(short)0]).Visible = true;
			txtPvOp.Text = Conversions.ToString(COFarOpPV[Globals_Renamed.intOpIndex]);
		}
		else
		{
			((Control)txtPvOp).Visible = false;
			((Control)Label1[(short)0]).Visible = false;
		}
	}

	private void cmdAdd_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num2 = default(int);
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
						ProjectData.ClearProjectError();
						num2 = 2;
						if (lstAvailOps.SelectedIndex == -1)
						{
							goto end_IL_0001;
						}
						short num3 = -1;
						short num4 = 0;
						short num5;
						short num6;
						do
						{
							if (COFarSubOpID[num4, Globals_Renamed.intOpIndex] == 0)
							{
								num3 = num4;
								break;
							}
							num4 = (short)unchecked(num4 + 1);
							num5 = num4;
							num6 = 9;
						}
						while (num5 <= num6);
						if (num3 == -1)
						{
							Interaction.Beep();
							Interaction.MsgBox((object)"You cannot have more than 10 subsequent operations.", (MsgBoxStyle)64, (object)"Invalid Request");
							goto end_IL_0001;
						}
						short num7 = (short)(Globals_Renamed.intNumOps - 1);
						num4 = 0;
						while (true)
						{
							short num8 = num4;
							num6 = num7;
							if (num8 > num6)
							{
								break;
							}
							short num9 = 0;
							short num10;
							do
							{
								if (COFarSubOpID[num9, num4] == Support.GetItemData((Control)(object)lstAvailOps, lstAvailOps.SelectedIndex))
								{
									COFarSubOpID[num9, num4] = 0;
									COFarSubPVf[num9, num4] = 0f;
									COFarSubPvOp[num9, num4] = 0f;
									break;
								}
								num9 = (short)unchecked(num9 + 1);
								num10 = num9;
								num6 = 9;
							}
							while (num10 <= num6);
							num4 = (short)unchecked(num4 + 1);
						}
						COFarOpPV[Support.GetItemData((Control)(object)lstAvailOps, lstAvailOps.SelectedIndex) - 1] = 0f;
						COFarSubOpID[num3, Globals_Renamed.intOpIndex] = (short)Support.GetItemData((Control)(object)lstAvailOps, lstAvailOps.SelectedIndex);
						COFarSubPVf[num3, Globals_Renamed.intOpIndex] = 0f;
						COFarSubPvOp[num3, Globals_Renamed.intOpIndex] = 0f;
						msfSubOps.AddItem(Conversions.ToString(Support.GetItemData((Control)(object)lstAvailOps, lstAvailOps.SelectedIndex)) + "\t" + lstAvailOps.Text + "\t0\t0");
						if (Operators.CompareString(msfSubOps[1, 0], "", false) == 0)
						{
							msfSubOps.RemoveItem(1);
						}
						lstAvailOps.Items.RemoveAt(lstAvailOps.SelectedIndex);
						goto end_IL_0001;
					}
					case 634:
						num = -1;
						switch (num2)
						{
						case 2:
						{
							string Eobject = ((Control)this).Name;
							string Efunction = "cmdAdd_Click";
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
				try0001_dispatch = 634;
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

	private void cmdCancel_Click(object eventSender, EventArgs eventArgs)
	{
		((Form)this).Close();
	}

	private void cmdRemove_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		int try0001_dispatch = -1;
		int num2 = default(int);
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
						ProjectData.ClearProjectError();
						num2 = 2;
						if (msfSubOps.Rows == 1 || !Versioned.IsNumeric((object)msfSubOps[msfSubOps.Row, 0]))
						{
							goto end_IL_0001;
						}
						short num3 = 0;
						short num7;
						short num6;
						do
						{
							if ((double)COFarSubOpID[num3, Globals_Renamed.intOpIndex] == Conversions.ToDouble(msfSubOps[msfSubOps.Row, 0]))
							{
								short num4 = num3;
								while (true)
								{
									short num5 = num4;
									num6 = 9;
									if (num5 <= num6)
									{
										COFarSubOpID[num4, Globals_Renamed.intOpIndex] = COFarSubOpID[num4 + 1, Globals_Renamed.intOpIndex];
										COFarSubPVf[num4, Globals_Renamed.intOpIndex] = COFarSubPVf[num4 + 1, Globals_Renamed.intOpIndex];
										COFarSubPvOp[num4, Globals_Renamed.intOpIndex] = COFarSubPvOp[num4 + 1, Globals_Renamed.intOpIndex];
										num4 = (short)unchecked(num4 + 1);
										continue;
									}
									break;
								}
								break;
							}
							num3 = (short)unchecked(num3 + 1);
							num7 = num3;
							num6 = 9;
						}
						while (num7 <= num6);
						lstAvailOps.Items.Add((object)new ListBoxItem(msfSubOps[msfSubOps.Row, 1], Conversions.ToInteger(msfSubOps[msfSubOps.Row, 0])));
						if (msfSubOps.Rows == 2)
						{
							short num8 = (short)(msfSubOps.Cols - 1);
							num3 = 0;
							while (true)
							{
								short num9 = num3;
								num6 = num8;
								if (num9 <= num6)
								{
									msfSubOps[1, unchecked((int)num3)] = "";
									num3 = (short)unchecked(num3 + 1);
									continue;
								}
								break;
							}
						}
						else
						{
							msfSubOps.RemoveItem(msfSubOps.Row);
						}
						goto end_IL_0001;
					}
					case 564:
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
				try0001_dispatch = 564;
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

	private void frmMDUpdRels_Load(object eventSender, EventArgs eventArgs)
	{
		msfSubOps[0, 1] = "Subsequent Operation";
		msfSubOps[0, 2] = "Percent of PV";
		msfSubOps[0, 3] = "PVop";
		msfSubOps[0] = 0;
		msfSubOps[1] = 4000;
		msfSubOps[2] = 1300;
		msfSubOps[3] = 1300;
		if (Versioned.IsNumeric((object)frmMain.DefInstance.lblPV.Text))
		{
			PvAss = Conversions.ToDouble(frmMain.DefInstance.lblPV.Text);
		}
		else
		{
			PvAss = 0.0;
		}
	}

	private void cmdOk_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Invalid comparison between Unknown and I4
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		if (((int)chkNoPre.CheckState == 1) & Versioned.IsNumeric((object)txtPvOp.Text))
		{
			COFarOpPV[Globals_Renamed.intOpIndex] = Conversions.ToSingle(txtPvOp.Text);
		}
		if ((int)chkNoPre.CheckState == 1)
		{
			COFarNoPre[Globals_Renamed.intOpIndex] = true;
		}
		else
		{
			COFarNoPre[Globals_Renamed.intOpIndex] = false;
		}
		checked
		{
			short num = (short)(msfSubOps.Rows - 1);
			short num2 = 1;
			while (true)
			{
				short num3 = num2;
				short num4 = num;
				if (num3 > num4)
				{
					break;
				}
				if (Versioned.IsNumeric((object)msfSubOps[unchecked((int)num2), 2]))
				{
					COFarSubPVf[num2 - 1, Globals_Renamed.intOpIndex] = Conversions.ToSingle(msfSubOps[unchecked((int)num2), 2]);
				}
				else
				{
					COFarSubPVf[num2 - 1, Globals_Renamed.intOpIndex] = 0f;
				}
				if (Versioned.IsNumeric((object)msfSubOps[unchecked((int)num2), 3]))
				{
					COFarSubPvOp[num2 - 1, Globals_Renamed.intOpIndex] = Conversions.ToSingle(msfSubOps[unchecked((int)num2), 3]);
				}
				else
				{
					COFarSubPvOp[num2 - 1, Globals_Renamed.intOpIndex] = 0f;
				}
				num2 = (short)unchecked(num2 + 1);
			}
			short num5 = (short)(Globals_Renamed.intNumOps - 1);
			num2 = 0;
			float num8;
			float num10;
			while (true)
			{
				short num6 = num2;
				short num4 = num5;
				if (num6 > num4)
				{
					break;
				}
				Globals_Renamed.arNoPre[num2] = COFarNoPre[num2];
				Globals_Renamed.arOpNeedsMassBalance[num2] = 1;
				Globals_Renamed.arOpPv[num2] = COFarOpPV[num2];
				short num7 = 0;
				num8 = 0f;
				float num9;
				do
				{
					Globals_Renamed.arSubOpID[(int)Math.Round(num8), num2] = 0;
					Globals_Renamed.arSubPVf[(int)Math.Round(num8), num2] = 0f;
					Globals_Renamed.arSubPvOp[(int)Math.Round(num8), num2] = 0.0;
					num8 += 1f;
					num9 = num8;
					num10 = 9f;
				}
				while (num9 <= num10);
				num8 = 0f;
				float num11;
				do
				{
					if (COFarSubOpID[(int)Math.Round(num8), num2] > 0)
					{
						Globals_Renamed.arSubOpID[num7, num2] = COFarSubOpID[(int)Math.Round(num8), num2];
						Globals_Renamed.arSubPVf[num7, num2] = COFarSubPVf[(int)Math.Round(num8), num2];
						Globals_Renamed.arSubPvOp[num7, num2] = COFarSubPvOp[(int)Math.Round(num8), num2];
						num7++;
					}
					num8 += 1f;
					num11 = num8;
					num10 = 9f;
				}
				while (num11 <= num10);
				num2 = (short)unchecked(num2 + 1);
			}
			num8 = 0f;
			float num12;
			do
			{
				if (Globals_Renamed.arSubOpID[(int)Math.Round(num8), Globals_Renamed.intOpIndex] > 0)
				{
					Globals_Renamed.arOpPv[Globals_Renamed.arSubOpID[(int)Math.Round(num8), Globals_Renamed.intOpIndex] - 1] = Globals_Renamed.arSubPvOp[(int)Math.Round(num8), Globals_Renamed.intOpIndex];
				}
				num8 += 1f;
				num12 = num8;
				num10 = 9f;
			}
			while (num12 <= num10);
			if (Versioned.IsNumeric((object)frmMain.DefInstance.lblPV.Text))
			{
				short num13 = (short)(Globals_Renamed.intNumOps - 1);
				num2 = 0;
				while (true)
				{
					short num14 = num2;
					short num4 = num13;
					if (num14 > num4)
					{
						break;
					}
					if (Globals_Renamed.arNoPre[num2])
					{
					}
					num2 = (short)unchecked(num2 + 1);
				}
			}
			frmMain.DefInstance.LoadMsfSubOps();
			frmMain.DefInstance.SetPvOpLabels();
			bool flag = false;
			short num15 = (short)(Globals_Renamed.intNumOps - 1);
			num2 = 0;
			while (true)
			{
				short num16 = num2;
				short num4 = num15;
				if (num16 > num4)
				{
					break;
				}
				if (Globals_Renamed.arNoPre[num2])
				{
					flag = true;
					break;
				}
				num2 = (short)unchecked(num2 + 1);
			}
			if (!flag)
			{
				Interaction.MsgBox((object)"You do not have an operation designated as the 'first' operation in the chemical process. To ensure a valid assessment, please designate which operation is 'first' by checking the 'No Preceding Operations' on the first operation.", (MsgBoxStyle)48, (object)"Missing First Operation Designation");
			}
			Interaction.MsgBox((object)"Please update the Mass Balance Parameters (subtab 4a) for all of your operations before running models.", (MsgBoxStyle)48, (object)"Mass Balance Message");
			Globals_Renamed.gblIWasChanged = true;
			short num17 = (short)(Globals_Renamed.intNumOps - 1);
			num2 = 0;
			while (true)
			{
				short num18 = num2;
				short num4 = num17;
				if (num18 > num4)
				{
					break;
				}
				if (Globals_Renamed.arNoPre[num2])
				{
					ChemStrX.RollXprodSideways(ref num2, ref Globals_Renamed.arOpParms[119, num2]);
				}
				num2 = (short)unchecked(num2 + 1);
			}
			((Form)this).Close();
		}
	}

	private void lstAvailOps_DoubleClick(object eventSender, EventArgs eventArgs)
	{
		cmdAdd_Click(cmdAdd, new EventArgs());
	}

	private void msfSubOps_ClickEvent(object eventSender, EventArgs eventArgs)
	{
		if (msfSubOps.Col < 2)
		{
			((Control)txtInput).Visible = false;
			return;
		}
		checked
		{
			((Control)txtInput).Left = (int)Math.Round(Support.TwipsToPixelsX(Support.PixelsToTwipsX((double)((Control)msfSubOps).Left) + (double)msfSubOps[msfSubOps.Col]));
			((Control)txtInput).Top = (int)Math.Round(Support.TwipsToPixelsY(Support.PixelsToTwipsY((double)((Control)msfSubOps).Top) + (double)msfSubOps[msfSubOps.Row]));
			((Control)txtInput).Width = (int)Math.Round(Support.TwipsToPixelsX((double)msfSubOps[msfSubOps.Col]));
			((Control)txtInput).Height = (int)Math.Round(Support.TwipsToPixelsY((double)msfSubOps[msfSubOps.Row]));
			((Control)txtInput).Tag = "Loading";
			txtInput.Text = msfSubOps.Text;
			((Control)txtInput).Tag = "";
			((Control)txtInput).Visible = true;
			((TextBoxBase)txtInput).SelectionLength = Strings.Len(txtInput.Text);
			((Control)txtInput).Focus();
		}
	}

	private void msfSubOps_DblClick(object eventSender, EventArgs eventArgs)
	{
		cmdRemove_Click(cmdRemove, new EventArgs());
	}

	private void msfSubOps_Scroll(object eventSender, EventArgs eventArgs)
	{
		((Control)txtInput).Visible = false;
	}

	private void txtInput_TextChanged(object eventSender, EventArgs eventArgs)
	{
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(((Control)txtInput).Tag, (object)"Loading", false))
		{
			return;
		}
		if (msfSubOps.Col == 2)
		{
			if (Strings.Len(txtInput.Text) == 0)
			{
				txtInput.Text = Conversions.ToString(0);
			}
			else
			{
				if (!Versioned.IsNumeric((object)txtInput.Text))
				{
					Interaction.Beep();
					Interaction.MsgBox((object)"Please enter a valid numeric value for PVf.", (MsgBoxStyle)64, (object)"Invalid User Input");
					((Control)txtInput).Focus();
					return;
				}
				if (Conversions.ToDouble(txtInput.Text) > 100.0)
				{
					Interaction.Beep();
					Interaction.MsgBox((object)"Please enter a valid numeric value for PVf.", (MsgBoxStyle)64, (object)"Invalid User Input");
					((Control)txtInput).Focus();
					return;
				}
			}
			msfSubOps[msfSubOps.Row, 2] = txtInput.Text;
			if ((PvAss > 0.0) & (MyPvf > 0f))
			{
				float num = Conversions.ToSingle(txtInput.Text);
				msfSubOps[msfSubOps.Row, 3] = Conversions.ToString(PvAss * (double)num / 100.0);
			}
			else
			{
				msfSubOps[msfSubOps.Row, 3] = Conversions.ToString(0);
			}
		}
		else
		{
			if (Strings.Len(txtInput.Text) == 0)
			{
				txtInput.Text = Conversions.ToString(0);
			}
			else if (!Versioned.IsNumeric((object)txtInput.Text))
			{
				Interaction.Beep();
				Interaction.MsgBox((object)"Please enter a valid numeric value for PVop.", (MsgBoxStyle)64, (object)"Invalid User Input");
				((Control)txtInput).Focus();
				return;
			}
			if (PvAss == 0.0)
			{
				msfSubOps[msfSubOps.Row, 2] = "0";
			}
			else
			{
				msfSubOps[msfSubOps.Row, 2] = Support.Format((object)(Conversions.ToDouble(txtInput.Text) / PvAss * 100.0), "##0.00", (FirstDayOfWeek)1, (FirstWeekOfYear)1);
			}
			msfSubOps[msfSubOps.Row, 3] = txtInput.Text;
		}
	}

	private void AdjustKids(ref short pOpIndex, ref float pMomsPct)
	{
		short num = 0;
		checked
		{
			float num2 = default(float);
			short num3;
			short num4;
			do
			{
				num2 += Globals_Renamed.arSubPVf[num, pOpIndex];
				num = (short)unchecked(num + 1);
				num3 = num;
				num4 = 9;
			}
			while (num3 <= num4);
			if (!(num2 > 0f))
			{
				return;
			}
			num = 0;
			short num6;
			do
			{
				if (Globals_Renamed.arSubOpID[num, pOpIndex] > 0)
				{
					Globals_Renamed.arSubPVf[num, pOpIndex] = Globals_Renamed.arSubPVf[num, pOpIndex] / 100f * pMomsPct;
					float num5 = (float)((double)(int)Math.Round(MyPvf * 10000f) / 10000.0);
					if (MyPv == 0f)
					{
						Globals_Renamed.arSubPvOp[num, pOpIndex] = 0.0;
					}
					else
					{
						Globals_Renamed.arSubPvOp[num, pOpIndex] = Conversion.Fix(Globals_Renamed.arSubPVf[num, pOpIndex] / num5 * MyPv) / 100f;
					}
					Globals_Renamed.arOpPv[Globals_Renamed.arSubOpID[num, pOpIndex] - 1] = Globals_Renamed.arSubPvOp[num, pOpIndex];
					short pOpIndex2 = (short)(Globals_Renamed.arSubOpID[num, pOpIndex] - 1);
					AdjustKids(ref pOpIndex2, ref Globals_Renamed.arSubPVf[num, pOpIndex]);
				}
				num = (short)unchecked(num + 1);
				num6 = num;
				num4 = 9;
			}
			while (num6 <= num4);
		}
	}
}
