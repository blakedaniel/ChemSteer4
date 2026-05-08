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

internal class frmMDAddRelModel : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("Command2")]
	private Button _Command2;

	[AccessedThroughProperty("Command1")]
	private Button _Command1;

	[AccessedThroughProperty("cmdShow")]
	private Button _cmdShow;

	[AccessedThroughProperty("lstSelModels")]
	private ListBox _lstSelModels;

	[AccessedThroughProperty("cmdRemove")]
	private Button _cmdRemove;

	[AccessedThroughProperty("cmdAdd")]
	private Button _cmdAdd;

	[AccessedThroughProperty("lstAvailModels")]
	private ListBox _lstAvailModels;

	[AccessedThroughProperty("CancelButton_Renamed")]
	private Button _CancelButton_Renamed;

	[AccessedThroughProperty("OKButton")]
	private Button _OKButton;

	[AccessedThroughProperty("lblAct")]
	private Label _lblAct;

	[AccessedThroughProperty("lblInstructions")]
	private Label _lblInstructions;

	[AccessedThroughProperty("_Label1_1")]
	private Label __Label1_1;

	[AccessedThroughProperty("_Label1_0")]
	private Label __Label1_0;

	[AccessedThroughProperty("Label1")]
	private LabelArray _Label1;

	private static frmMDAddRelModel m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	private short COFintNumRelModels;

	private short[,,] COFarRelModels;

	private short[] COFarRelModType;

	private string[] COFarRelModBasis;

	private string[] COFarRelModNAICS;

	private short[] COFarRelModStatus;

	private short[,] COFarRelModOutputOn;

	private string[,] COFarRelModChar;

	private short[,] COFarRelModMedia;

	private float[,,] COFarRelModParmsV;

	private short[,,] COFarRelModParmsT;

	private short[,,] COFarRelModParmsVC;

	private float[,] COFarRelModDRR;

	private float[,] COFarRelModARR;

	private short[,] COFarRelModDOR;

	private bool LoadingControls;

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

	public virtual Button cmdShow
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdShow;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdShow_Click;
			if (_cmdShow != null)
			{
				((Control)_cmdShow).Click -= eventHandler;
			}
			_cmdShow = value;
			if (_cmdShow != null)
			{
				((Control)_cmdShow).Click += eventHandler;
			}
		}
	}

	public virtual ListBox lstSelModels
	{
		[DebuggerNonUserCode]
		get
		{
			return _lstSelModels;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = lstSelModels_DoubleClick;
			if (_lstSelModels != null)
			{
				((Control)_lstSelModels).DoubleClick -= eventHandler;
			}
			_lstSelModels = value;
			if (_lstSelModels != null)
			{
				((Control)_lstSelModels).DoubleClick += eventHandler;
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

	public virtual ListBox lstAvailModels
	{
		[DebuggerNonUserCode]
		get
		{
			return _lstAvailModels;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = lstAvailModels_DoubleClick;
			if (_lstAvailModels != null)
			{
				((Control)_lstAvailModels).DoubleClick -= eventHandler;
			}
			_lstAvailModels = value;
			if (_lstAvailModels != null)
			{
				((Control)_lstAvailModels).DoubleClick += eventHandler;
			}
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

	public virtual Label lblAct
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblAct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblAct = value;
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

	public static frmMDAddRelModel DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmMDAddRelModel();
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

	public frmMDAddRelModel()
	{
		((Form)this).Load += frmMDAddRelModel_Load;
		((Form)this).Closed += frmMDAddRelModel_Closed;
		__ENCAddToList(this);
		COFarRelModels = new short[2, 2, 2];
		COFarRelModType = new short[2];
		COFarRelModBasis = new string[2];
		COFarRelModNAICS = new string[2];
		COFarRelModStatus = new short[2];
		COFarRelModOutputOn = new short[2, 2];
		COFarRelModChar = new string[2, 2];
		COFarRelModMedia = new short[2, 2];
		COFarRelModParmsV = new float[2, 2, 2];
		COFarRelModParmsT = new short[2, 2, 2];
		COFarRelModParmsVC = new short[2, 2, 2];
		COFarRelModDRR = new float[2, 2];
		COFarRelModARR = new float[2, 2];
		COFarRelModDOR = new short[2, 2];
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
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected O, but got Unknown
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Expected O, but got Unknown
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bd: Expected O, but got Unknown
		//IL_0589: Unknown result type (might be due to invalid IL or missing references)
		//IL_0593: Expected O, but got Unknown
		//IL_065f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0669: Expected O, but got Unknown
		//IL_073b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0745: Expected O, but got Unknown
		//IL_080e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0818: Expected O, but got Unknown
		//IL_08e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08eb: Expected O, but got Unknown
		//IL_09a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ad: Expected O, but got Unknown
		//IL_0a65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6f: Expected O, but got Unknown
		//IL_0b3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b47: Expected O, but got Unknown
		//IL_0d39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d43: Expected O, but got Unknown
		//IL_0d58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d62: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMDAddRelModel));
		ToolTip1 = new ToolTip(components);
		Command2 = new Button();
		Command1 = new Button();
		cmdShow = new Button();
		lstSelModels = new ListBox();
		cmdRemove = new Button();
		cmdAdd = new Button();
		lstAvailModels = new ListBox();
		CancelButton_Renamed = new Button();
		OKButton = new Button();
		lblAct = new Label();
		lblInstructions = new Label();
		_Label1_1 = new Label();
		_Label1_0 = new Label();
		Label1 = new LabelArray(components);
		((ISupportInitialize)Label1).BeginInit();
		((Control)this).SuspendLayout();
		((ButtonBase)Command2).BackColor = Color.FromArgb(255, 128, 255);
		((Control)Command2).Cursor = Cursors.Default;
		((Control)Command2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Command2).ForeColor = SystemColors.ControlText;
		Button command = Command2;
		Point location = new Point(423, 360);
		((Control)command).Location = location;
		((Control)Command2).Name = "Command2";
		((Control)Command2).RightToLeft = (RightToLeft)0;
		Button command2 = Command2;
		Size size = new Size(153, 25);
		((Control)command2).Size = size;
		((Control)Command2).TabIndex = 12;
		((ButtonBase)Command2).Text = "Modify User Defined Model";
		((ButtonBase)Command2).UseVisualStyleBackColor = false;
		((Control)Command2).Visible = false;
		((ButtonBase)Command1).BackColor = Color.FromArgb(255, 128, 255);
		((Control)Command1).Cursor = Cursors.Default;
		((Control)Command1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Command1).ForeColor = SystemColors.ControlText;
		Button command3 = Command1;
		location = new Point(439, 340);
		((Control)command3).Location = location;
		((Control)Command1).Name = "Command1";
		((Control)Command1).RightToLeft = (RightToLeft)0;
		Button command4 = Command1;
		size = new Size(137, 25);
		((Control)command4).Size = size;
		((Control)Command1).TabIndex = 11;
		((ButtonBase)Command1).Text = "Add User Defined Model";
		((ButtonBase)Command1).UseVisualStyleBackColor = false;
		((Control)Command1).Visible = false;
		((ButtonBase)cmdShow).BackColor = SystemColors.Control;
		((Control)cmdShow).Cursor = Cursors.Default;
		((Control)cmdShow).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdShow).ForeColor = SystemColors.ControlText;
		Button obj = cmdShow;
		location = new Point(360, 128);
		((Control)obj).Location = location;
		((Control)cmdShow).Name = "cmdShow";
		((Control)cmdShow).RightToLeft = (RightToLeft)0;
		Button obj2 = cmdShow;
		size = new Size(241, 25);
		((Control)obj2).Size = size;
		((Control)cmdShow).TabIndex = 10;
		((Control)cmdShow).Tag = "only";
		((ButtonBase)cmdShow).Text = "&Show All Release Models";
		((ButtonBase)cmdShow).UseVisualStyleBackColor = false;
		lstSelModels.BackColor = SystemColors.Window;
		((Control)lstSelModels).Cursor = Cursors.Default;
		lstSelModels.Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		lstSelModels.ForeColor = SystemColors.WindowText;
		lstSelModels.ItemHeight = 14;
		ListBox obj3 = lstSelModels;
		location = new Point(8, 288);
		((Control)obj3).Location = location;
		((Control)lstSelModels).Name = "lstSelModels";
		lstSelModels.RightToLeft = (RightToLeft)0;
		ListBox obj4 = lstSelModels;
		size = new Size(593, 46);
		((Control)obj4).Size = size;
		((Control)lstSelModels).TabIndex = 3;
		((ButtonBase)cmdRemove).BackColor = SystemColors.Control;
		((Control)cmdRemove).Cursor = Cursors.Default;
		((Control)cmdRemove).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdRemove).ForeColor = SystemColors.ControlText;
		Button obj5 = cmdRemove;
		location = new Point(312, 233);
		((Control)obj5).Location = location;
		((Control)cmdRemove).Name = "cmdRemove";
		((Control)cmdRemove).RightToLeft = (RightToLeft)0;
		Button obj6 = cmdRemove;
		size = new Size(137, 25);
		((Control)obj6).Size = size;
		((Control)cmdRemove).TabIndex = 2;
		((ButtonBase)cmdRemove).Text = "&Remove from list";
		((ButtonBase)cmdRemove).UseVisualStyleBackColor = false;
		((ButtonBase)cmdAdd).BackColor = SystemColors.Control;
		((Control)cmdAdd).Cursor = Cursors.Default;
		((Control)cmdAdd).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdAdd).ForeColor = SystemColors.ControlText;
		Button obj7 = cmdAdd;
		location = new Point(160, 233);
		((Control)obj7).Location = location;
		((Control)cmdAdd).Name = "cmdAdd";
		((Control)cmdAdd).RightToLeft = (RightToLeft)0;
		Button obj8 = cmdAdd;
		size = new Size(137, 25);
		((Control)obj8).Size = size;
		((Control)cmdAdd).TabIndex = 1;
		((ButtonBase)cmdAdd).Text = "&Add to list";
		((ButtonBase)cmdAdd).UseVisualStyleBackColor = false;
		lstAvailModels.BackColor = SystemColors.Window;
		((Control)lstAvailModels).Cursor = Cursors.Default;
		lstAvailModels.Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		lstAvailModels.ForeColor = SystemColors.WindowText;
		lstAvailModels.ItemHeight = 14;
		ListBox obj9 = lstAvailModels;
		location = new Point(8, 152);
		((Control)obj9).Location = location;
		((Control)lstAvailModels).Name = "lstAvailModels";
		lstAvailModels.RightToLeft = (RightToLeft)0;
		ListBox obj10 = lstAvailModels;
		size = new Size(593, 60);
		((Control)obj10).Size = size;
		lstAvailModels.Sorted = true;
		((Control)lstAvailModels).TabIndex = 0;
		((ButtonBase)CancelButton_Renamed).BackColor = SystemColors.Control;
		((Control)CancelButton_Renamed).Cursor = Cursors.Default;
		CancelButton_Renamed.DialogResult = (DialogResult)2;
		((Control)CancelButton_Renamed).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)CancelButton_Renamed).ForeColor = SystemColors.ControlText;
		Button cancelButton_Renamed = CancelButton_Renamed;
		location = new Point(312, 360);
		((Control)cancelButton_Renamed).Location = location;
		((Control)CancelButton_Renamed).Name = "CancelButton_Renamed";
		((Control)CancelButton_Renamed).RightToLeft = (RightToLeft)0;
		Button cancelButton_Renamed2 = CancelButton_Renamed;
		size = new Size(81, 25);
		((Control)cancelButton_Renamed2).Size = size;
		((Control)CancelButton_Renamed).TabIndex = 5;
		((ButtonBase)CancelButton_Renamed).Text = "Cancel";
		((ButtonBase)CancelButton_Renamed).UseVisualStyleBackColor = false;
		((ButtonBase)OKButton).BackColor = SystemColors.Control;
		((Control)OKButton).Cursor = Cursors.Default;
		((Control)OKButton).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)OKButton).ForeColor = SystemColors.ControlText;
		Button oKButton = OKButton;
		location = new Point(216, 360);
		((Control)oKButton).Location = location;
		((Control)OKButton).Name = "OKButton";
		((Control)OKButton).RightToLeft = (RightToLeft)0;
		Button oKButton2 = OKButton;
		size = new Size(81, 25);
		((Control)oKButton2).Size = size;
		((Control)OKButton).TabIndex = 4;
		((ButtonBase)OKButton).Text = "OK";
		((ButtonBase)OKButton).UseVisualStyleBackColor = false;
		((Control)lblAct).BackColor = SystemColors.Control;
		((Control)lblAct).Cursor = Cursors.Default;
		((Control)lblAct).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)lblAct).ForeColor = SystemColors.ControlText;
		Label obj11 = lblAct;
		location = new Point(8, 8);
		((Control)obj11).Location = location;
		((Control)lblAct).Name = "lblAct";
		((Control)lblAct).RightToLeft = (RightToLeft)0;
		Label obj12 = lblAct;
		size = new Size(585, 17);
		((Control)obj12).Size = size;
		((Control)lblAct).TabIndex = 9;
		lblAct.Text = "x";
		((Control)lblInstructions).BackColor = SystemColors.Control;
		((Control)lblInstructions).Cursor = Cursors.Default;
		((Control)lblInstructions).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblInstructions).ForeColor = SystemColors.ControlText;
		Label obj13 = lblInstructions;
		location = new Point(8, 40);
		((Control)obj13).Location = location;
		((Control)lblInstructions).Name = "lblInstructions";
		((Control)lblInstructions).RightToLeft = (RightToLeft)0;
		Label obj14 = lblInstructions;
		size = new Size(585, 81);
		((Control)obj14).Size = size;
		((Control)lblInstructions).TabIndex = 8;
		lblInstructions.Text = "xxx";
		((Control)_Label1_1).BackColor = SystemColors.Control;
		((Control)_Label1_1).Cursor = Cursors.Default;
		((Control)_Label1_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_1).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_1, (short)1);
		Label label1_ = _Label1_1;
		location = new Point(8, 272);
		((Control)label1_).Location = location;
		((Control)_Label1_1).Name = "_Label1_1";
		((Control)_Label1_1).RightToLeft = (RightToLeft)0;
		Label label1_2 = _Label1_1;
		size = new Size(185, 17);
		((Control)label1_2).Size = size;
		((Control)_Label1_1).TabIndex = 7;
		_Label1_1.Text = "Selected Models:";
		((Control)_Label1_0).BackColor = SystemColors.Control;
		((Control)_Label1_0).Cursor = Cursors.Default;
		((Control)_Label1_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_0).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_0, (short)0);
		Label label1_3 = _Label1_0;
		location = new Point(8, 136);
		((Control)label1_3).Location = location;
		((Control)_Label1_0).Name = "_Label1_0";
		((Control)_Label1_0).RightToLeft = (RightToLeft)0;
		Label label1_4 = _Label1_0;
		size = new Size(129, 17);
		((Control)label1_4).Size = size;
		((Control)_Label1_0).TabIndex = 6;
		_Label1_0.Text = "Available Models:";
		((Form)this).AcceptButton = (IButtonControl)(object)OKButton;
		size = new Size(5, 13);
		((Form)this).AutoScaleBaseSize = size;
		((Form)this).BackColor = SystemColors.Control;
		((Form)this).CancelButton = (IButtonControl)(object)CancelButton_Renamed;
		size = new Size(607, 398);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Command2);
		((Control)this).Controls.Add((Control)(object)Command1);
		((Control)this).Controls.Add((Control)(object)cmdShow);
		((Control)this).Controls.Add((Control)(object)lstSelModels);
		((Control)this).Controls.Add((Control)(object)cmdRemove);
		((Control)this).Controls.Add((Control)(object)cmdAdd);
		((Control)this).Controls.Add((Control)(object)lstAvailModels);
		((Control)this).Controls.Add((Control)(object)CancelButton_Renamed);
		((Control)this).Controls.Add((Control)(object)OKButton);
		((Control)this).Controls.Add((Control)(object)lblAct);
		((Control)this).Controls.Add((Control)(object)lblInstructions);
		((Control)this).Controls.Add((Control)(object)_Label1_1);
		((Control)this).Controls.Add((Control)(object)_Label1_0);
		((Control)this).Cursor = Cursors.Default;
		((Control)this).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		location = new Point(250, 150);
		((Form)this).Location = location;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmMDAddRelModel";
		((Control)this).RightToLeft = (RightToLeft)0;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Add / Remove Release Models";
		((ISupportInitialize)Label1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public bool SetUp()
	{
		//IL_06d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06db: Expected O, but got Unknown
		//IL_07f0: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
		bool flag3 = default(bool);
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
						LoadingControls = true;
						lblAct.Text = frmMain.DefInstance.cmbRelActs.Text;
						command.ActiveConnection = Common.MyConn;
						command.CommandText = "pqryGetInstructions";
						command.CommandType = CommandTypeEnum.adCmdStoredProc;
						command.Parameters.Append(command.CreateParameter("pID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, 1));
						Command command2 = command;
						object RecordsAffected = Missing.Value;
						object Parameters = Missing.Value;
						recordset = command2.Execute(out RecordsAffected, ref Parameters);
						command.Parameters.Delete("pID");
						lblInstructions.Text = Conversions.ToString(recordset.Fields[0].Value);
						recordset.Close();
						COFintNumRelModels = Globals_Renamed.intNumRelModels;
						COFarRelModels = new short[11, 26, Globals_Renamed.intNumOps + 1];
						COFarRelModType = new short[COFintNumRelModels + 1];
						COFarRelModBasis = new string[COFintNumRelModels + 1];
						COFarRelModNAICS = new string[COFintNumRelModels + 1];
						COFarRelModStatus = new short[COFintNumRelModels + 1];
						COFarRelModOutputOn = new short[3, COFintNumRelModels + 1];
						COFarRelModChar = new string[3, COFintNumRelModels + 1];
						COFarRelModMedia = new short[19, COFintNumRelModels + 1];
						COFarRelModParmsV = new float[3, 163, COFintNumRelModels + 1];
						COFarRelModParmsT = new short[3, 163, COFintNumRelModels + 1];
						COFarRelModParmsVC = new short[3, 163, COFintNumRelModels + 1];
						COFarRelModDRR = new float[3, COFintNumRelModels + 1];
						COFarRelModARR = new float[3, COFintNumRelModels + 1];
						COFarRelModDOR = new short[3, COFintNumRelModels + 1];
						Parameters = Globals_Renamed.arRelModels;
						RecordsAffected = COFarRelModels;
						short pDim = 10;
						short pDim2 = 25;
						ChemStrX.Clone3DArray(ref Parameters, ref RecordsAffected, ref pDim, ref pDim2, ref Globals_Renamed.intNumOps);
						COFarRelModels = (short[,,])RecordsAffected;
						Globals_Renamed.arRelModels = (short[,,])Parameters;
						Parameters = Globals_Renamed.arRelModType;
						RecordsAffected = COFarRelModType;
						ChemStrX.Clone1DArray(ref Parameters, ref RecordsAffected, ref COFintNumRelModels);
						COFarRelModType = (short[])RecordsAffected;
						Globals_Renamed.arRelModType = (short[])Parameters;
						Parameters = Globals_Renamed.arRelModBasis;
						RecordsAffected = COFarRelModBasis;
						ChemStrX.Clone1DArray(ref Parameters, ref RecordsAffected, ref COFintNumRelModels);
						COFarRelModBasis = (string[])RecordsAffected;
						Globals_Renamed.arRelModBasis = (string[])Parameters;
						Parameters = Globals_Renamed.arRelModNAICS;
						RecordsAffected = COFarRelModNAICS;
						ChemStrX.Clone1DArray(ref Parameters, ref RecordsAffected, ref COFintNumRelModels);
						COFarRelModNAICS = (string[])RecordsAffected;
						Globals_Renamed.arRelModNAICS = (string[])Parameters;
						Parameters = Globals_Renamed.arRelModStatus;
						RecordsAffected = COFarRelModStatus;
						ChemStrX.Clone1DArray(ref Parameters, ref RecordsAffected, ref COFintNumRelModels);
						COFarRelModStatus = (short[])RecordsAffected;
						Globals_Renamed.arRelModStatus = (short[])Parameters;
						Parameters = Globals_Renamed.arRelModOutputOn;
						RecordsAffected = COFarRelModOutputOn;
						pDim2 = 2;
						ChemStrX.Clone2DArray(ref Parameters, ref RecordsAffected, ref pDim2, ref COFintNumRelModels);
						COFarRelModOutputOn = (short[,])RecordsAffected;
						Globals_Renamed.arRelModOutputOn = (short[,])Parameters;
						Parameters = Globals_Renamed.arRelModChar;
						RecordsAffected = COFarRelModChar;
						pDim2 = 2;
						ChemStrX.Clone2DArray(ref Parameters, ref RecordsAffected, ref pDim2, ref COFintNumRelModels);
						COFarRelModChar = (string[,])RecordsAffected;
						Globals_Renamed.arRelModChar = (string[,])Parameters;
						Parameters = Globals_Renamed.arRelModMedia;
						RecordsAffected = COFarRelModMedia;
						pDim2 = 18;
						ChemStrX.Clone2DArray(ref Parameters, ref RecordsAffected, ref pDim2, ref COFintNumRelModels);
						COFarRelModMedia = (short[,])RecordsAffected;
						Globals_Renamed.arRelModMedia = (float[,])Parameters;
						Parameters = Globals_Renamed.arRelModParmsV;
						RecordsAffected = COFarRelModParmsV;
						pDim2 = 2;
						pDim = 162;
						ChemStrX.Clone3DArray(ref Parameters, ref RecordsAffected, ref pDim2, ref pDim, ref COFintNumRelModels);
						COFarRelModParmsV = (float[,,])RecordsAffected;
						Globals_Renamed.arRelModParmsV = (float[,,])Parameters;
						Parameters = Globals_Renamed.arRelModParmsT;
						RecordsAffected = COFarRelModParmsT;
						pDim2 = 2;
						pDim = 162;
						ChemStrX.Clone3DArray(ref Parameters, ref RecordsAffected, ref pDim2, ref pDim, ref COFintNumRelModels);
						COFarRelModParmsT = (short[,,])RecordsAffected;
						Globals_Renamed.arRelModParmsT = (short[,,])Parameters;
						Parameters = Globals_Renamed.arRelModParmsVC;
						RecordsAffected = COFarRelModParmsVC;
						pDim2 = 2;
						pDim = 162;
						ChemStrX.Clone3DArray(ref Parameters, ref RecordsAffected, ref pDim2, ref pDim, ref COFintNumRelModels);
						COFarRelModParmsVC = (short[,,])RecordsAffected;
						Globals_Renamed.arRelModParmsVC = (short[,,])Parameters;
						Parameters = Globals_Renamed.arRelModDRR;
						RecordsAffected = COFarRelModDRR;
						pDim2 = 2;
						ChemStrX.Clone2DArray(ref Parameters, ref RecordsAffected, ref pDim2, ref COFintNumRelModels);
						COFarRelModDRR = (float[,])RecordsAffected;
						Globals_Renamed.arRelModDRR = (float[,])Parameters;
						Parameters = Globals_Renamed.arRelModARR;
						RecordsAffected = COFarRelModARR;
						pDim2 = 2;
						ChemStrX.Clone2DArray(ref Parameters, ref RecordsAffected, ref pDim2, ref COFintNumRelModels);
						COFarRelModARR = (float[,])RecordsAffected;
						Globals_Renamed.arRelModARR = (float[,])Parameters;
						Parameters = Globals_Renamed.arRelModDOR;
						RecordsAffected = COFarRelModDOR;
						pDim2 = 2;
						ChemStrX.Clone2DArray(ref Parameters, ref RecordsAffected, ref pDim2, ref COFintNumRelModels);
						COFarRelModDOR = (short[,])RecordsAffected;
						Globals_Renamed.arRelModDOR = (short[,])Parameters;
						((Control)cmdShow).Tag = "only";
						((ButtonBase)cmdShow).Text = "Show All Release Models";
						while (true)
						{
							lstAvailModels.Items.Clear();
							lstSelModels.Items.Clear();
							if (flag)
							{
								recordset.CursorLocation = CursorLocationEnum.adUseClient;
								recordset.Open("SELECT * FROM qryListOfRelModels", Common.MyConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
							}
							else
							{
								command.ActiveConnection = Common.MyConn;
								command.CommandText = "pqryListOfValidRelModels";
								command.CommandType = CommandTypeEnum.adCmdStoredProc;
								command.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, Globals_Renamed.arSelActType[Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex]));
								Command command3 = command;
								Parameters = Missing.Value;
								RecordsAffected = Missing.Value;
								recordset = command3.Execute(out Parameters, ref RecordsAffected);
								command.Parameters.Delete("pActID");
							}
							while (!recordset.EOF)
							{
								lstAvailModels.Items.Add((object)new ListBoxItem(Conversions.ToString(recordset.Fields[1].Value), Conversions.ToInteger(recordset.Fields[0].Value)));
								recordset.MoveNext();
							}
							recordset.Close();
							short num3 = 0;
							while (true)
							{
								short num7;
								if (Globals_Renamed.arRelModels[num3, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] > 0)
								{
									bool flag2 = false;
									short num4 = (short)(lstAvailModels.Items.Count - 1);
									short num5 = 0;
									while (true)
									{
										short num6 = num5;
										num7 = num4;
										if (num6 > num7)
										{
											break;
										}
										if (Support.GetItemData((Control)(object)lstAvailModels, unchecked((int)num5)) == Globals_Renamed.arRelModType[Globals_Renamed.arRelModels[num3, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1])
										{
											lstAvailModels.SelectedIndex = num5;
											cmdAdd_Click(cmdAdd, new EventArgs());
											flag2 = true;
											break;
										}
										num5 = (short)unchecked(num5 + 1);
									}
									if (!flag2)
									{
										if (!flag)
										{
											flag = true;
											((Control)cmdShow).Tag = "all";
											((ButtonBase)cmdShow).Text = "Show Only Most Likely Release Models";
											break;
										}
										Interaction.MsgBox((object)"Corrupted database.  Please contact technical support.", (MsgBoxStyle)0, (object)null);
										Debugger.Break();
									}
								}
								num3 = (short)unchecked(num3 + 1);
								short num8 = num3;
								num7 = 10;
								if (num8 > num7)
								{
									LoadingControls = false;
									recordset = null;
									command = null;
									flag3 = true;
									goto end_IL_0001;
								}
							}
						}
					}
					case 2187:
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
				try0001_dispatch = 2187;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		bool result = flag3;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private void CancelButton_Renamed_Click(object eventSender, EventArgs eventArgs)
	{
		RestoreGlobalsAndArrays();
		((Form)this).Close();
	}

	private void cmdAdd_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
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
						Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
						Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
						Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						ProjectData.ClearProjectError();
						num2 = 2;
						if (lstAvailModels.SelectedIndex == -1)
						{
							goto end_IL_0001;
						}
						if (lstSelModels.Items.Count > 9)
						{
							Interaction.Beep();
							Interaction.MsgBox((object)"You can only have 10 release models associated with an activity. Action cancelled.", (MsgBoxStyle)64, (object)"Invalid Request");
							goto end_IL_0001;
						}
						Globals_Renamed.gblIWasChanged = true;
						int num3 = lstSelModels.Items.Add((object)new ListBoxItem(lstAvailModels.Text, Support.GetItemData((Control)(object)lstAvailModels, lstAvailModels.SelectedIndex)));
						lstAvailModels.Items.RemoveAt(lstAvailModels.SelectedIndex);
						if (!LoadingControls)
						{
							Globals_Renamed.intModIndex = Globals_Renamed.intNumRelModels;
							Globals_Renamed.intNumRelModels++;
							Globals_Renamed.arRelModType = (short[])Utils.CopyArray((Array)Globals_Renamed.arRelModType, (Array)new short[Globals_Renamed.intNumRelModels + 1]);
							Globals_Renamed.arRelModBasis = (string[])Utils.CopyArray((Array)Globals_Renamed.arRelModBasis, (Array)new string[Globals_Renamed.intNumRelModels + 1]);
							Globals_Renamed.arRelModNAICS = (string[])Utils.CopyArray((Array)Globals_Renamed.arRelModNAICS, (Array)new string[Globals_Renamed.intNumRelModels + 1]);
							Globals_Renamed.arRelModStatus = (short[])Utils.CopyArray((Array)Globals_Renamed.arRelModStatus, (Array)new short[Globals_Renamed.intNumRelModels + 1]);
							Globals_Renamed.arRelModOutputOn = (short[,])Utils.CopyArray((Array)Globals_Renamed.arRelModOutputOn, (Array)new short[3, Globals_Renamed.intNumRelModels + 1]);
							Globals_Renamed.arRelModChar = (string[,])Utils.CopyArray((Array)Globals_Renamed.arRelModChar, (Array)new string[3, Globals_Renamed.intNumRelModels + 1]);
							Globals_Renamed.arRelModMedia = (float[,])Utils.CopyArray((Array)Globals_Renamed.arRelModMedia, (Array)new float[19, Globals_Renamed.intNumRelModels + 1]);
							Globals_Renamed.arRelModParmsV = (float[,,])Utils.CopyArray((Array)Globals_Renamed.arRelModParmsV, (Array)new float[3, 163, Globals_Renamed.intNumRelModels + 1]);
							Globals_Renamed.arRelModParmsT = (short[,,])Utils.CopyArray((Array)Globals_Renamed.arRelModParmsT, (Array)new short[3, 163, Globals_Renamed.intNumRelModels + 1]);
							Globals_Renamed.arRelModParmsVC = (short[,,])Utils.CopyArray((Array)Globals_Renamed.arRelModParmsVC, (Array)new short[3, 163, Globals_Renamed.intNumRelModels + 1]);
							Globals_Renamed.arRelModDRR = (float[,])Utils.CopyArray((Array)Globals_Renamed.arRelModDRR, (Array)new float[3, Globals_Renamed.intNumRelModels + 1]);
							Globals_Renamed.arRelModARR = (float[,])Utils.CopyArray((Array)Globals_Renamed.arRelModARR, (Array)new float[3, Globals_Renamed.intNumRelModels + 1]);
							Globals_Renamed.arRelModDOR = (short[,])Utils.CopyArray((Array)Globals_Renamed.arRelModDOR, (Array)new short[3, Globals_Renamed.intNumRelModels + 1]);
							command.ActiveConnection = Common.MyConn;
							command.CommandText = "pqryGetRelModel";
							command.CommandType = CommandTypeEnum.adCmdStoredProc;
							command.Parameters.Append(command.CreateParameter("pRelModID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, Support.GetItemData((Control)(object)lstSelModels, num3)));
							Command command2 = command;
							object RecordsAffected = Missing.Value;
							object Parameters = Missing.Value;
							recordset = command2.Execute(out RecordsAffected, ref Parameters);
							command.Parameters.Delete("pRelModID");
							Globals_Renamed.arRelModType[Globals_Renamed.intNumRelModels - 1] = (short)Support.GetItemData((Control)(object)lstSelModels, num3);
							Globals_Renamed.arRelModBasis[Globals_Renamed.intNumRelModels - 1] = Conversions.ToString(recordset.Fields["Basis"].Value);
							Globals_Renamed.arRelModOutputOn[0, Globals_Renamed.intNumRelModels - 1] = Conversions.ToShort(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["OutputOn1"].Value)), (object)0, RuntimeHelpers.GetObjectValue(recordset.Fields["OutputOn1"].Value)));
							Globals_Renamed.arRelModChar[0, Globals_Renamed.intNumRelModels - 1] = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["Char1"].Value)), (object)"", RuntimeHelpers.GetObjectValue(recordset.Fields["Char1"].Value)));
							Globals_Renamed.arRelModOutputOn[1, Globals_Renamed.intNumRelModels - 1] = Conversions.ToShort(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["OutputOn2"].Value)), (object)0, RuntimeHelpers.GetObjectValue(recordset.Fields["OutputOn2"].Value)));
							Globals_Renamed.arRelModChar[1, Globals_Renamed.intNumRelModels - 1] = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["Char2"].Value)), (object)"", RuntimeHelpers.GetObjectValue(recordset.Fields["Char2"].Value)));
							Globals_Renamed.arRelModels[lstSelModels.Items.Count - 1, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] = Globals_Renamed.intNumRelModels;
							command.ActiveConnection = Common.MyConn;
							command.CommandText = "pqryGetMediaDefaults";
							command.CommandType = CommandTypeEnum.adCmdStoredProc;
							command.Parameters.Append(command.CreateParameter("pRelModID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, Support.GetItemData((Control)(object)lstSelModels, num3)));
							Command command3 = command;
							Parameters = Missing.Value;
							RecordsAffected = Missing.Value;
							recordset = command3.Execute(out Parameters, ref RecordsAffected);
							command.Parameters.Delete("pRelModID");
							while (!recordset.EOF)
							{
								Globals_Renamed.arRelModMedia[Conversions.ToInteger(recordset.Fields["MediaID"].Value), Globals_Renamed.intNumRelModels - 1] = Conversions.ToSingle(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["Pct"].Value)), (object)0, RuntimeHelpers.GetObjectValue(recordset.Fields["Pct"].Value)));
								recordset.MoveNext();
							}
							recordset.Close();
							short pModType = (short)Support.GetItemData((Control)(object)lstSelModels, num3);
							short pModNum = (short)(lstSelModels.Items.Count - 1);
							ChemStrX.AddRelModel(ref pModType, ref pModNum);
							frmMain.DefInstance.cmbExpOps.SelectedIndex = -1;
							recordset = null;
							command = null;
						}
						goto end_IL_0001;
					}
					case 1819:
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
				try0001_dispatch = 1819;
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

	private void cmdRemove_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Expected O, but got Unknown
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
						if (lstSelModels.SelectedIndex == -1)
						{
							goto end_IL_0001;
						}
						Globals_Renamed.gblIWasChanged = true;
						if (Globals_Renamed.intOpIndex == -1)
						{
							Interaction.MsgBox((object)"intOpIndex is incorrectly set to -1. Please contact technical support. Please cancel out of this window and try again.", (MsgBoxStyle)64, (object)"Program Error");
							goto end_IL_0001;
						}
						short num3 = Globals_Renamed.arRelModels[lstSelModels.SelectedIndex, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex];
						short num4 = (short)(Globals_Renamed.intNumOps - 1);
						short num5 = 0;
						short num9;
						short num8;
						short num7;
						while (true)
						{
							short num6 = num5;
							num7 = num4;
							if (num6 > num7)
							{
								break;
							}
							num8 = 0;
							short num11;
							do
							{
								num9 = 0;
								short num10;
								do
								{
									if (Globals_Renamed.arRelModels[num9, num8, num5] > num3)
									{
										Globals_Renamed.arRelModels[num9, num8, num5] = (short)(Globals_Renamed.arRelModels[num9, num8, num5] - 1);
									}
									num9 = (short)unchecked(num9 + 1);
									num10 = num9;
									num7 = 9;
								}
								while (num10 <= num7);
								num8 = (short)unchecked(num8 + 1);
								num11 = num8;
								num7 = 24;
							}
							while (num11 <= num7);
							num5 = (short)unchecked(num5 + 1);
						}
						num9 = (short)lstSelModels.SelectedIndex;
						while (true)
						{
							short num12 = num9;
							num7 = 9;
							if (num12 > num7)
							{
								break;
							}
							Globals_Renamed.arRelModels[num9, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] = Globals_Renamed.arRelModels[num9 + 1, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex];
							num9 = (short)unchecked(num9 + 1);
						}
						short num13 = (short)(Globals_Renamed.intNumRelModels - 1);
						num9 = num3;
						while (true)
						{
							short num14 = num9;
							num7 = num13;
							if (num14 > num7)
							{
								break;
							}
							Globals_Renamed.arRelModType[num9 - 1] = Globals_Renamed.arRelModType[num9];
							Globals_Renamed.arRelModBasis[num9 - 1] = Globals_Renamed.arRelModBasis[num9];
							Globals_Renamed.arRelModNAICS[num9 - 1] = Globals_Renamed.arRelModNAICS[num9];
							Globals_Renamed.arRelModStatus[num9 - 1] = Globals_Renamed.arRelModStatus[num9];
							Globals_Renamed.arRelModOutputOn[0, num9 - 1] = Globals_Renamed.arRelModOutputOn[0, num9];
							Globals_Renamed.arRelModOutputOn[1, num9 - 1] = Globals_Renamed.arRelModOutputOn[1, num9];
							Globals_Renamed.arRelModChar[0, num9 - 1] = Globals_Renamed.arRelModChar[0, num9];
							Globals_Renamed.arRelModChar[1, num9 - 1] = Globals_Renamed.arRelModChar[1, num9];
							num8 = 0;
							short num15;
							do
							{
								Globals_Renamed.arRelModDRR[num8, num9 - 1] = Globals_Renamed.arRelModDRR[num8, num9];
								Globals_Renamed.arRelModARR[num8, num9 - 1] = Globals_Renamed.arRelModARR[num8, num9];
								Globals_Renamed.arRelModDOR[num8, num9 - 1] = Globals_Renamed.arRelModDOR[num8, num9];
								num8 = (short)unchecked(num8 + 1);
								num15 = num8;
								num7 = 1;
							}
							while (num15 <= num7);
							num8 = 0;
							short num16;
							do
							{
								Globals_Renamed.arRelModMedia[num8, num9 - 1] = Globals_Renamed.arRelModMedia[num8, num9];
								num8 = (short)unchecked(num8 + 1);
								num16 = num8;
								num7 = 17;
							}
							while (num16 <= num7);
							num5 = 0;
							short num18;
							do
							{
								num8 = 1;
								short num17;
								do
								{
									Globals_Renamed.arRelModParmsV[num5, num8, num9 - 1] = Globals_Renamed.arRelModParmsV[num5, num8, num9];
									Globals_Renamed.arRelModParmsT[num5, num8, num9 - 1] = Globals_Renamed.arRelModParmsT[num5, num8, num9];
									Globals_Renamed.arRelModParmsVC[num5, num8, num9 - 1] = Globals_Renamed.arRelModParmsVC[num5, num8, num9];
									num8 = (short)unchecked(num8 + 1);
									num17 = num8;
									num7 = 162;
								}
								while (num17 <= num7);
								num5 = (short)unchecked(num5 + 1);
								num18 = num5;
								num7 = 1;
							}
							while (num18 <= num7);
							num9 = (short)unchecked(num9 + 1);
						}
						Globals_Renamed.intNumRelModels--;
						Globals_Renamed.arRelModType[Globals_Renamed.intNumRelModels] = 0;
						Globals_Renamed.arRelModBasis[Globals_Renamed.intNumRelModels] = "";
						Globals_Renamed.arRelModNAICS[Globals_Renamed.intNumRelModels] = "";
						Globals_Renamed.arRelModStatus[Globals_Renamed.intNumRelModels] = 0;
						Globals_Renamed.arRelModOutputOn[0, Globals_Renamed.intNumRelModels] = 0;
						Globals_Renamed.arRelModChar[0, Globals_Renamed.intNumRelModels] = "";
						Globals_Renamed.arRelModOutputOn[1, Globals_Renamed.intNumRelModels] = 0;
						Globals_Renamed.arRelModChar[1, Globals_Renamed.intNumRelModels] = "";
						num8 = 0;
						short num19;
						do
						{
							Globals_Renamed.arRelModDRR[num8, Globals_Renamed.intNumRelModels] = 0f;
							Globals_Renamed.arRelModARR[num8, Globals_Renamed.intNumRelModels] = 0f;
							Globals_Renamed.arRelModDOR[num8, Globals_Renamed.intNumRelModels] = 0;
							num8 = (short)unchecked(num8 + 1);
							num19 = num8;
							num7 = 1;
						}
						while (num19 <= num7);
						num8 = 0;
						short num20;
						do
						{
							Globals_Renamed.arRelModMedia[num8, Globals_Renamed.intNumRelModels] = 0f;
							num8 = (short)unchecked(num8 + 1);
							num20 = num8;
							num7 = 17;
						}
						while (num20 <= num7);
						num5 = 0;
						short num22;
						do
						{
							num8 = 1;
							short num21;
							do
							{
								Globals_Renamed.arRelModParmsV[num5, num8, Globals_Renamed.intNumRelModels] = 0f;
								Globals_Renamed.arRelModParmsT[num5, num8, Globals_Renamed.intNumRelModels] = 0;
								Globals_Renamed.arRelModParmsVC[num5, num8, Globals_Renamed.intNumRelModels] = 0;
								num8 = (short)unchecked(num8 + 1);
								num21 = num8;
								num7 = 162;
							}
							while (num21 <= num7);
							num5 = (short)unchecked(num5 + 1);
							num22 = num5;
							num7 = 1;
						}
						while (num22 <= num7);
						lstAvailModels.Items.Add((object)new ListBoxItem(lstSelModels.Text, Support.GetItemData((Control)(object)lstSelModels, lstSelModels.SelectedIndex)));
						lstSelModels.Items.RemoveAt(lstSelModels.SelectedIndex);
						((Control)this).Tag = "RemoveWasDone";
						goto end_IL_0001;
					}
					case 1317:
						num = -1;
						switch (num2)
						{
						case 2:
						{
							string Eobject = ((Control)this).Name;
							string Efunction = "cmdRemove_Click";
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
				try0001_dispatch = 1317;
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

	private void cmdShow_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected O, but got Unknown
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
						Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
						Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
						Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						ProjectData.ClearProjectError();
						num2 = 2;
						lstAvailModels.Items.Clear();
						if (Operators.ConditionalCompareObjectEqual(((Control)cmdShow).Tag, (object)"only", false))
						{
							((Control)cmdShow).Tag = "all";
							((ButtonBase)cmdShow).Text = "Show Only Most Likely Release Models";
							recordset.CursorLocation = CursorLocationEnum.adUseClient;
							recordset.Open("SELECT * FROM qryListOfRelModels", Common.MyConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
						}
						else
						{
							((Control)cmdShow).Tag = "only";
							((ButtonBase)cmdShow).Text = "Show All Release Models";
							command.ActiveConnection = Common.MyConn;
							command.CommandText = "pqryListOfValidRelModels";
							command.CommandType = CommandTypeEnum.adCmdStoredProc;
							command.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, Globals_Renamed.arSelActType[Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex]));
							Command command2 = command;
							object RecordsAffected = Missing.Value;
							object Parameters = Missing.Value;
							recordset = command2.Execute(out RecordsAffected, ref Parameters);
							command.Parameters.Delete("pActID");
						}
						while (!recordset.EOF)
						{
							lstAvailModels.Items.Add((object)new ListBoxItem(Conversions.ToString(recordset.Fields[1].Value), Conversions.ToInteger(recordset.Fields[0].Value)));
							recordset.MoveNext();
						}
						recordset.Close();
						short num3 = (short)(lstSelModels.Items.Count - 1);
						short num4 = 0;
						while (true)
						{
							short num5 = num4;
							short num6 = num3;
							if (num5 > num6)
							{
								break;
							}
							short num7 = (short)(lstAvailModels.Items.Count - 1);
							short num8 = 0;
							while (true)
							{
								short num9 = num8;
								num6 = num7;
								if (num9 > num6)
								{
									break;
								}
								unchecked
								{
									if (Support.GetItemData((Control)(object)lstAvailModels, (int)num8) == Support.GetItemData((Control)(object)lstSelModels, (int)num4))
									{
										lstAvailModels.Items.RemoveAt((int)num8);
										break;
									}
								}
								num8 = (short)unchecked(num8 + 1);
							}
							num4 = (short)unchecked(num4 + 1);
						}
						recordset = null;
						command = null;
						goto end_IL_0001;
					}
					case 696:
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
				try0001_dispatch = 696;
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

	private void frmMDAddRelModel_Load(object eventSender, EventArgs eventArgs)
	{
		SetUp();
	}

	private void frmMDAddRelModel_Closed(object eventSender, EventArgs eventArgs)
	{
		frmMain.DefInstance.cmbRelActs_SelectedIndexChanged(frmMain.DefInstance.cmbRelActs, new EventArgs());
	}

	private void lstAvailModels_DoubleClick(object eventSender, EventArgs eventArgs)
	{
		cmdAdd_Click(cmdAdd, new EventArgs());
	}

	private void lstSelModels_DoubleClick(object eventSender, EventArgs eventArgs)
	{
		cmdRemove_Click(cmdRemove, new EventArgs());
	}

	private void OKButton_Click(object eventSender, EventArgs eventArgs)
	{
		if (Operators.ConditionalCompareObjectEqual(((Control)this).Tag, (object)"RemoveWasDone", false))
		{
			ChemStrX.RefreshAllLinks();
			frmMain.DefInstance.cmbExpOps.SelectedIndex = -1;
		}
		((Form)this).Close();
	}

	private void RestoreGlobalsAndArrays()
	{
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
						ProjectData.ClearProjectError();
						num2 = 2;
						if (Globals_Renamed.gblIWasChanged)
						{
							Globals_Renamed.gblIWasChanged = false;
							Globals_Renamed.intNumRelModels = COFintNumRelModels;
							Globals_Renamed.arRelModType = new short[COFintNumRelModels + 1];
							Globals_Renamed.arRelModBasis = new string[COFintNumRelModels + 1];
							Globals_Renamed.arRelModNAICS = new string[COFintNumRelModels + 1];
							Globals_Renamed.arRelModStatus = new short[COFintNumRelModels + 1];
							Globals_Renamed.arRelModOutputOn = new short[3, COFintNumRelModels + 1];
							Globals_Renamed.arRelModChar = new string[3, COFintNumRelModels + 1];
							Globals_Renamed.arRelModMedia = new float[19, COFintNumRelModels + 1];
							Globals_Renamed.arRelModParmsV = new float[3, 163, COFintNumRelModels + 1];
							Globals_Renamed.arRelModParmsT = new short[3, 163, COFintNumRelModels + 1];
							Globals_Renamed.arRelModParmsVC = new short[3, 163, COFintNumRelModels + 1];
							Globals_Renamed.arRelModDRR = new float[3, COFintNumRelModels + 1];
							Globals_Renamed.arRelModARR = new float[3, COFintNumRelModels + 1];
							Globals_Renamed.arRelModDOR = new short[3, COFintNumRelModels + 1];
							object pCopyArray = COFarRelModels;
							object pToArray = Globals_Renamed.arRelModels;
							short pDim = 10;
							short pDim2 = 25;
							ChemStrX.Clone3DArray(ref pCopyArray, ref pToArray, ref pDim, ref pDim2, ref Globals_Renamed.intNumOps);
							Globals_Renamed.arRelModels = (short[,,])pToArray;
							COFarRelModels = (short[,,])pCopyArray;
							pToArray = COFarRelModType;
							pCopyArray = Globals_Renamed.arRelModType;
							ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref COFintNumRelModels);
							Globals_Renamed.arRelModType = (short[])pCopyArray;
							COFarRelModType = (short[])pToArray;
							pToArray = COFarRelModBasis;
							pCopyArray = Globals_Renamed.arRelModBasis;
							ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref COFintNumRelModels);
							Globals_Renamed.arRelModBasis = (string[])pCopyArray;
							COFarRelModBasis = (string[])pToArray;
							pToArray = COFarRelModStatus;
							pCopyArray = Globals_Renamed.arRelModStatus;
							ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref COFintNumRelModels);
							Globals_Renamed.arRelModStatus = (short[])pCopyArray;
							COFarRelModStatus = (short[])pToArray;
							pToArray = COFarRelModNAICS;
							pCopyArray = Globals_Renamed.arRelModNAICS;
							ChemStrX.Clone1DArray(ref pToArray, ref pCopyArray, ref COFintNumRelModels);
							Globals_Renamed.arRelModNAICS = (string[])pCopyArray;
							COFarRelModNAICS = (string[])pToArray;
							pToArray = COFarRelModOutputOn;
							pCopyArray = Globals_Renamed.arRelModOutputOn;
							pDim2 = 2;
							ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref COFintNumRelModels);
							Globals_Renamed.arRelModOutputOn = (short[,])pCopyArray;
							COFarRelModOutputOn = (short[,])pToArray;
							pToArray = COFarRelModChar;
							pCopyArray = Globals_Renamed.arRelModChar;
							pDim2 = 2;
							ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref COFintNumRelModels);
							Globals_Renamed.arRelModChar = (string[,])pCopyArray;
							COFarRelModChar = (string[,])pToArray;
							pToArray = COFarRelModMedia;
							pCopyArray = Globals_Renamed.arRelModMedia;
							pDim2 = 18;
							ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref COFintNumRelModels);
							Globals_Renamed.arRelModMedia = (float[,])pCopyArray;
							COFarRelModMedia = (short[,])pToArray;
							pToArray = COFarRelModParmsV;
							pCopyArray = Globals_Renamed.arRelModParmsV;
							pDim2 = 2;
							pDim = 162;
							ChemStrX.Clone3DArray(ref pToArray, ref pCopyArray, ref pDim2, ref pDim, ref COFintNumRelModels);
							Globals_Renamed.arRelModParmsV = (float[,,])pCopyArray;
							COFarRelModParmsV = (float[,,])pToArray;
							pToArray = COFarRelModParmsT;
							pCopyArray = Globals_Renamed.arRelModParmsT;
							pDim2 = 2;
							pDim = 162;
							ChemStrX.Clone3DArray(ref pToArray, ref pCopyArray, ref pDim2, ref pDim, ref COFintNumRelModels);
							Globals_Renamed.arRelModParmsT = (short[,,])pCopyArray;
							COFarRelModParmsT = (short[,,])pToArray;
							pToArray = COFarRelModParmsVC;
							pCopyArray = Globals_Renamed.arRelModParmsVC;
							pDim2 = 2;
							pDim = 162;
							ChemStrX.Clone3DArray(ref pToArray, ref pCopyArray, ref pDim2, ref pDim, ref COFintNumRelModels);
							Globals_Renamed.arRelModParmsVC = (short[,,])pCopyArray;
							COFarRelModParmsVC = (short[,,])pToArray;
							pToArray = COFarRelModDRR;
							pCopyArray = Globals_Renamed.arRelModDRR;
							pDim2 = 2;
							ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref COFintNumRelModels);
							Globals_Renamed.arRelModDRR = (float[,])pCopyArray;
							COFarRelModDRR = (float[,])pToArray;
							pToArray = COFarRelModARR;
							pCopyArray = Globals_Renamed.arRelModARR;
							pDim2 = 2;
							ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref COFintNumRelModels);
							Globals_Renamed.arRelModARR = (float[,])pCopyArray;
							COFarRelModARR = (float[,])pToArray;
							pToArray = COFarRelModDOR;
							pCopyArray = Globals_Renamed.arRelModDOR;
							pDim2 = 2;
							ChemStrX.Clone2DArray(ref pToArray, ref pCopyArray, ref pDim2, ref COFintNumRelModels);
							Globals_Renamed.arRelModDOR = (short[,])pCopyArray;
							COFarRelModDOR = (short[,])pToArray;
						}
						goto end_IL_0001;
					case 1203:
						num = -1;
						switch (num2)
						{
						case 2:
						{
							string Eobject = ((Control)this).Name;
							string Efunction = "RestoreGlobalsAndArrays";
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
				try0001_dispatch = 1203;
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
}
