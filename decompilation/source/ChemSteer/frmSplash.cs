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
using Microsoft.VisualBasic.PowerPacks;

namespace ChemSteer;

internal class frmSplash : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("imgLogo")]
	private PictureBoxArray _imgLogo;

	[AccessedThroughProperty("_lblCompanyProduct_0")]
	private Label __lblCompanyProduct_0;

	[AccessedThroughProperty("lblProductName")]
	private Label _lblProductName;

	[AccessedThroughProperty("lblVersion")]
	private Label _lblVersion;

	[AccessedThroughProperty("_imgLogo_0")]
	private PictureBox __imgLogo_0;

	[AccessedThroughProperty("_imgLogo_1")]
	private PictureBox __imgLogo_1;

	[AccessedThroughProperty("_lblCompanyProduct_1")]
	private Label __lblCompanyProduct_1;

	[AccessedThroughProperty("cmdRunAssessment")]
	private Button _cmdRunAssessment;

	[AccessedThroughProperty("ShapeContainer1")]
	private ShapeContainer _ShapeContainer1;

	[AccessedThroughProperty("RectangleShape1")]
	private RectangleShape _RectangleShape1;

	[AccessedThroughProperty("cmdWhatsNew")]
	private Button _cmdWhatsNew;

	[AccessedThroughProperty("cmdRunModels")]
	private Button _cmdRunModels;

	[AccessedThroughProperty("cmdQuickStart")]
	private Button _cmdQuickStart;

	[AccessedThroughProperty("cmdUserGuide")]
	private Button _cmdUserGuide;

	[AccessedThroughProperty("cmdClose")]
	private Button _cmdClose;

	[AccessedThroughProperty("lblCompanyProduct")]
	private LabelArray _lblCompanyProduct;

	private static frmSplash m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	private bool bButtonPushed;

	public virtual PictureBoxArray imgLogo
	{
		[DebuggerNonUserCode]
		get
		{
			return _imgLogo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_imgLogo = value;
		}
	}

	public virtual Label _lblCompanyProduct_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblCompanyProduct_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblCompanyProduct_0 = value;
		}
	}

	public virtual Label lblProductName
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblProductName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblProductName = value;
		}
	}

	public virtual Label lblVersion
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblVersion;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblVersion = value;
		}
	}

	public virtual PictureBox _imgLogo_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __imgLogo_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__imgLogo_0 = value;
		}
	}

	public virtual PictureBox _imgLogo_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __imgLogo_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__imgLogo_1 = value;
		}
	}

	public virtual Label _lblCompanyProduct_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblCompanyProduct_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblCompanyProduct_1 = value;
		}
	}

	public virtual Button cmdRunAssessment
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdRunAssessment;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdRunAssessment_Click;
			if (_cmdRunAssessment != null)
			{
				((Control)_cmdRunAssessment).Click -= eventHandler;
			}
			_cmdRunAssessment = value;
			if (_cmdRunAssessment != null)
			{
				((Control)_cmdRunAssessment).Click += eventHandler;
			}
		}
	}

	internal virtual ShapeContainer ShapeContainer1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ShapeContainer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ShapeContainer1 = value;
		}
	}

	internal virtual RectangleShape RectangleShape1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RectangleShape1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RectangleShape1 = value;
		}
	}

	public virtual Button cmdWhatsNew
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdWhatsNew;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdWhatsNew_Click;
			if (_cmdWhatsNew != null)
			{
				((Control)_cmdWhatsNew).Click -= eventHandler;
			}
			_cmdWhatsNew = value;
			if (_cmdWhatsNew != null)
			{
				((Control)_cmdWhatsNew).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdRunModels
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdRunModels;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdRunModels_Click;
			if (_cmdRunModels != null)
			{
				((Control)_cmdRunModels).Click -= eventHandler;
			}
			_cmdRunModels = value;
			if (_cmdRunModels != null)
			{
				((Control)_cmdRunModels).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdQuickStart
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdQuickStart;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdQuickStart_Click;
			if (_cmdQuickStart != null)
			{
				((Control)_cmdQuickStart).Click -= eventHandler;
			}
			_cmdQuickStart = value;
			if (_cmdQuickStart != null)
			{
				((Control)_cmdQuickStart).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdUserGuide
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdUserGuide;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdUserGuide_Click;
			if (_cmdUserGuide != null)
			{
				((Control)_cmdUserGuide).Click -= eventHandler;
			}
			_cmdUserGuide = value;
			if (_cmdUserGuide != null)
			{
				((Control)_cmdUserGuide).Click += eventHandler;
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

	public virtual LabelArray lblCompanyProduct
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblCompanyProduct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblCompanyProduct = value;
		}
	}

	public static frmSplash DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmSplash();
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

	public frmSplash()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		((Form)this).FormClosing += new FormClosingEventHandler(frmSplash_FormClosing);
		((Form)this).Load += frmSplash_Load;
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
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
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
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected O, but got Unknown
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected O, but got Unknown
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Expected O, but got Unknown
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Expected O, but got Unknown
		//IL_0534: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Expected O, but got Unknown
		//IL_0607: Unknown result type (might be due to invalid IL or missing references)
		//IL_0611: Expected O, but got Unknown
		//IL_06cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fa: Expected O, but got Unknown
		//IL_08c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ce: Expected O, but got Unknown
		//IL_0998: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a2: Expected O, but got Unknown
		//IL_0a6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a76: Expected O, but got Unknown
		//IL_0b40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4a: Expected O, but got Unknown
		//IL_0d2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d35: Expected O, but got Unknown
		//IL_0d4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d54: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmSplash));
		ToolTip1 = new ToolTip(components);
		imgLogo = new PictureBoxArray(components);
		lblCompanyProduct = new LabelArray(components);
		_lblCompanyProduct_0 = new Label();
		lblProductName = new Label();
		lblVersion = new Label();
		_imgLogo_0 = new PictureBox();
		_imgLogo_1 = new PictureBox();
		_lblCompanyProduct_1 = new Label();
		cmdRunAssessment = new Button();
		ShapeContainer1 = new ShapeContainer();
		RectangleShape1 = new RectangleShape();
		cmdWhatsNew = new Button();
		cmdRunModels = new Button();
		cmdQuickStart = new Button();
		cmdUserGuide = new Button();
		cmdClose = new Button();
		((ISupportInitialize)imgLogo).BeginInit();
		((ISupportInitialize)lblCompanyProduct).BeginInit();
		((ISupportInitialize)_imgLogo_0).BeginInit();
		((ISupportInitialize)_imgLogo_1).BeginInit();
		((Control)this).SuspendLayout();
		_lblCompanyProduct_0.AutoSize = true;
		((Control)_lblCompanyProduct_0).BackColor = Color.White;
		((Control)_lblCompanyProduct_0).Cursor = Cursors.Default;
		((Control)_lblCompanyProduct_0).Font = new Font("Arial", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_lblCompanyProduct_0).ForeColor = Color.Black;
		Label lblCompanyProduct_ = _lblCompanyProduct_0;
		Point location = new Point(285, 93);
		((Control)lblCompanyProduct_).Location = location;
		((Control)_lblCompanyProduct_0).Name = "_lblCompanyProduct_0";
		((Control)_lblCompanyProduct_0).RightToLeft = (RightToLeft)0;
		Label lblCompanyProduct_2 = _lblCompanyProduct_0;
		Size size = new Size(299, 24);
		((Control)lblCompanyProduct_2).Size = size;
		((Control)_lblCompanyProduct_0).TabIndex = 2;
		_lblCompanyProduct_0.Text = "and Environmental Releases";
		_lblCompanyProduct_0.TextAlign = (ContentAlignment)2;
		((Control)lblProductName).BackColor = Color.White;
		((Control)lblProductName).Cursor = Cursors.Default;
		((Control)lblProductName).Font = new Font("Arial", 36f, (FontStyle)3, (GraphicsUnit)3, (byte)0);
		((Control)lblProductName).ForeColor = Color.MidnightBlue;
		Label obj = lblProductName;
		location = new Point(213, 12);
		((Control)obj).Location = location;
		((Control)lblProductName).Name = "lblProductName";
		((Control)lblProductName).RightToLeft = (RightToLeft)0;
		Label obj2 = lblProductName;
		size = new Size(442, 55);
		((Control)obj2).Size = size;
		((Control)lblProductName).TabIndex = 3;
		lblProductName.Text = "ChemSTEER";
		lblProductName.TextAlign = (ContentAlignment)2;
		((Control)lblVersion).BackColor = Color.White;
		((Control)lblVersion).Cursor = Cursors.Default;
		((Control)lblVersion).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)lblVersion).ForeColor = SystemColors.ControlText;
		Label obj3 = lblVersion;
		location = new Point(243, 416);
		((Control)obj3).Location = location;
		((Control)lblVersion).Name = "lblVersion";
		((Control)lblVersion).RightToLeft = (RightToLeft)0;
		Label obj4 = lblVersion;
		size = new Size(380, 19);
		((Control)obj4).Size = size;
		((Control)lblVersion).TabIndex = 1;
		lblVersion.Text = "z";
		lblVersion.TextAlign = (ContentAlignment)2;
		((Control)_imgLogo_0).Cursor = Cursors.Default;
		_imgLogo_0.Image = (Image)componentResourceManager.GetObject("_imgLogo_0.Image");
		PictureBox imgLogo_ = _imgLogo_0;
		location = new Point(207, 122);
		((Control)imgLogo_).Location = location;
		((Control)_imgLogo_0).Name = "_imgLogo_0";
		PictureBox imgLogo_2 = _imgLogo_0;
		size = new Size(462, 291);
		((Control)imgLogo_2).Size = size;
		_imgLogo_0.SizeMode = (PictureBoxSizeMode)1;
		_imgLogo_0.TabIndex = 7;
		_imgLogo_0.TabStop = false;
		((Control)_imgLogo_1).Cursor = Cursors.Default;
		_imgLogo_1.Image = (Image)componentResourceManager.GetObject("_imgLogo_1.Image");
		PictureBox imgLogo_3 = _imgLogo_1;
		location = new Point(40, 16);
		((Control)imgLogo_3).Location = location;
		((Control)_imgLogo_1).Name = "_imgLogo_1";
		PictureBox imgLogo_4 = _imgLogo_1;
		size = new Size(125, 125);
		((Control)imgLogo_4).Size = size;
		_imgLogo_1.SizeMode = (PictureBoxSizeMode)1;
		_imgLogo_1.TabIndex = 6;
		_imgLogo_1.TabStop = false;
		_lblCompanyProduct_1.AutoSize = true;
		((Control)_lblCompanyProduct_1).BackColor = Color.White;
		((Control)_lblCompanyProduct_1).Cursor = Cursors.Default;
		((Control)_lblCompanyProduct_1).Font = new Font("Arial", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_lblCompanyProduct_1).ForeColor = Color.Black;
		Label lblCompanyProduct_3 = _lblCompanyProduct_1;
		location = new Point(232, 67);
		((Control)lblCompanyProduct_3).Location = location;
		((Control)_lblCompanyProduct_1).Name = "_lblCompanyProduct_1";
		((Control)_lblCompanyProduct_1).RightToLeft = (RightToLeft)0;
		Label lblCompanyProduct_4 = _lblCompanyProduct_1;
		size = new Size(408, 24);
		((Control)lblCompanyProduct_4).Size = size;
		((Control)_lblCompanyProduct_1).TabIndex = 5;
		_lblCompanyProduct_1.Text = "Chemical Screening Tool for Exposures";
		_lblCompanyProduct_1.TextAlign = (ContentAlignment)2;
		((ButtonBase)cmdRunAssessment).BackColor = SystemColors.Control;
		((Control)cmdRunAssessment).Cursor = Cursors.Default;
		((Control)cmdRunAssessment).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)cmdRunAssessment).ForeColor = SystemColors.ControlText;
		Button obj5 = cmdRunAssessment;
		location = new Point(21, 206);
		((Control)obj5).Location = location;
		((Control)cmdRunAssessment).Name = "cmdRunAssessment";
		((Control)cmdRunAssessment).RightToLeft = (RightToLeft)0;
		Button obj6 = cmdRunAssessment;
		size = new Size(162, 41);
		((Control)obj6).Size = size;
		((Control)cmdRunAssessment).TabIndex = 4;
		((ButtonBase)cmdRunAssessment).Text = "&Prepare an Assessment";
		((ButtonBase)cmdRunAssessment).UseVisualStyleBackColor = false;
		ShapeContainer shapeContainer = ShapeContainer1;
		location = new Point(0, 0);
		((Control)shapeContainer).Location = location;
		ShapeContainer shapeContainer2 = ShapeContainer1;
		Padding margin = default(Padding);
		((Padding)(ref margin))._002Ector(0);
		((Control)shapeContainer2).Margin = margin;
		((Control)ShapeContainer1).Name = "ShapeContainer1";
		ShapeContainer1.Shapes.AddRange(new Shape[1] { RectangleShape1 });
		ShapeContainer shapeContainer3 = ShapeContainer1;
		size = new Size(700, 440);
		((Control)shapeContainer3).Size = size;
		((Control)ShapeContainer1).TabIndex = 8;
		((Control)ShapeContainer1).TabStop = false;
		RectangleShape1.BackColor = Color.White;
		RectangleShape1.BorderColor = Color.MidnightBlue;
		RectangleShape1.BorderWidth = 3;
		RectangleShape rectangleShape = RectangleShape1;
		location = new Point(1, 1);
		rectangleShape.Location = location;
		RectangleShape1.Name = "RectangleShape1";
		RectangleShape rectangleShape2 = RectangleShape1;
		size = new Size(697, 438);
		rectangleShape2.Size = size;
		((ButtonBase)cmdWhatsNew).BackColor = SystemColors.Control;
		((Control)cmdWhatsNew).Cursor = Cursors.Default;
		((Control)cmdWhatsNew).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)cmdWhatsNew).ForeColor = SystemColors.ControlText;
		Button obj7 = cmdWhatsNew;
		location = new Point(21, 155);
		((Control)obj7).Location = location;
		((Control)cmdWhatsNew).Name = "cmdWhatsNew";
		((Control)cmdWhatsNew).RightToLeft = (RightToLeft)0;
		Button obj8 = cmdWhatsNew;
		size = new Size(162, 41);
		((Control)obj8).Size = size;
		((Control)cmdWhatsNew).TabIndex = 9;
		((ButtonBase)cmdWhatsNew).Text = "&What's New in This Version?";
		((ButtonBase)cmdWhatsNew).UseVisualStyleBackColor = false;
		((ButtonBase)cmdRunModels).BackColor = SystemColors.Control;
		((Control)cmdRunModels).Cursor = Cursors.Default;
		((Control)cmdRunModels).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)cmdRunModels).ForeColor = SystemColors.ControlText;
		Button obj9 = cmdRunModels;
		location = new Point(21, 259);
		((Control)obj9).Location = location;
		((Control)cmdRunModels).Name = "cmdRunModels";
		((Control)cmdRunModels).RightToLeft = (RightToLeft)0;
		Button obj10 = cmdRunModels;
		size = new Size(162, 41);
		((Control)obj10).Size = size;
		((Control)cmdRunModels).TabIndex = 10;
		((ButtonBase)cmdRunModels).Text = "&Run Exposure/Release Models (Advanced Users)";
		((ButtonBase)cmdRunModels).UseVisualStyleBackColor = false;
		((ButtonBase)cmdQuickStart).BackColor = SystemColors.Control;
		((Control)cmdQuickStart).Cursor = Cursors.Default;
		((Control)cmdQuickStart).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)cmdQuickStart).ForeColor = SystemColors.ControlText;
		Button obj11 = cmdQuickStart;
		location = new Point(21, 312);
		((Control)obj11).Location = location;
		((Control)cmdQuickStart).Name = "cmdQuickStart";
		((Control)cmdQuickStart).RightToLeft = (RightToLeft)0;
		Button obj12 = cmdQuickStart;
		size = new Size(162, 41);
		((Control)obj12).Size = size;
		((Control)cmdQuickStart).TabIndex = 12;
		((ButtonBase)cmdQuickStart).Text = "&View ChemSTEER Quick Start Guide";
		((ButtonBase)cmdQuickStart).UseVisualStyleBackColor = false;
		((ButtonBase)cmdUserGuide).BackColor = SystemColors.Control;
		((Control)cmdUserGuide).Cursor = Cursors.Default;
		((Control)cmdUserGuide).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)cmdUserGuide).ForeColor = SystemColors.ControlText;
		Button obj13 = cmdUserGuide;
		location = new Point(21, 366);
		((Control)obj13).Location = location;
		((Control)cmdUserGuide).Name = "cmdUserGuide";
		((Control)cmdUserGuide).RightToLeft = (RightToLeft)0;
		Button obj14 = cmdUserGuide;
		size = new Size(162, 41);
		((Control)obj14).Size = size;
		((Control)cmdUserGuide).TabIndex = 11;
		((ButtonBase)cmdUserGuide).Text = "&View ChemSTEER User Guide";
		((ButtonBase)cmdUserGuide).UseVisualStyleBackColor = false;
		((ButtonBase)cmdClose).BackColor = SystemColors.Control;
		((Control)cmdClose).Cursor = Cursors.Default;
		((Control)cmdClose).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)cmdClose).ForeColor = SystemColors.ControlText;
		Button obj15 = cmdClose;
		location = new Point(670, 12);
		((Control)obj15).Location = location;
		((Control)cmdClose).Name = "cmdClose";
		Button obj16 = cmdClose;
		size = new Size(162, 41);
		((Control)obj16).Size = size;
		((Control)cmdClose).TabIndex = 13;
		((ButtonBase)cmdClose).Text = "&Close";
		((ButtonBase)cmdClose).UseVisualStyleBackColor = false;
		((Control)cmdClose).Visible = false;
		((Form)this).AcceptButton = (IButtonControl)(object)cmdRunAssessment;
		size = new Size(5, 13);
		((Form)this).AutoScaleBaseSize = size;
		((Form)this).BackColor = Color.White;
		size = new Size(700, 440);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)cmdQuickStart);
		((Control)this).Controls.Add((Control)(object)cmdUserGuide);
		((Control)this).Controls.Add((Control)(object)cmdRunModels);
		((Control)this).Controls.Add((Control)(object)cmdWhatsNew);
		((Control)this).Controls.Add((Control)(object)cmdRunAssessment);
		((Control)this).Controls.Add((Control)(object)_lblCompanyProduct_1);
		((Control)this).Controls.Add((Control)(object)_imgLogo_1);
		((Control)this).Controls.Add((Control)(object)_lblCompanyProduct_0);
		((Control)this).Controls.Add((Control)(object)_imgLogo_0);
		((Control)this).Controls.Add((Control)(object)lblVersion);
		((Control)this).Controls.Add((Control)(object)lblProductName);
		((Control)this).Controls.Add((Control)(object)cmdClose);
		((Control)this).Controls.Add((Control)(object)ShapeContainer1);
		((Control)this).Cursor = Cursors.Default;
		((Control)this).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Form)this).FormBorderStyle = (FormBorderStyle)5;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).KeyPreview = true;
		location = new Point(15, 92);
		((Form)this).Location = location;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmSplash";
		((Control)this).RightToLeft = (RightToLeft)0;
		((Form)this).StartPosition = (FormStartPosition)1;
		((ISupportInitialize)imgLogo).EndInit();
		((ISupportInitialize)lblCompanyProduct).EndInit();
		((ISupportInitialize)_imgLogo_0).EndInit();
		((ISupportInitialize)_imgLogo_1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private void frmSplash_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (!bButtonPushed & ((Control)cmdUserGuide).Visible)
		{
			ProjectData.EndApp();
		}
	}

	private void frmSplash_Load(object eventSender, EventArgs eventArgs)
	{
		lblProductName.Text = "ChemSTEER v3.2";
		lblVersion.Text = "May 12, 2016";
	}

	private void cmdRunModels_Click(object sender, EventArgs e)
	{
		Globals_Renamed.gblDoEasyModels = true;
		bButtonPushed = true;
		((Form)this).Close();
	}

	private void cmdUserGuide_Click(object sender, EventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
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
					ProjectData.ClearProjectError();
					num2 = 2;
					Process.Start(Application.StartupPath + "/help/chemsteer.pdf");
					goto end_IL_0001;
				case 54:
					num = -1;
					switch (num2)
					{
					case 2:
						Interaction.MsgBox((object)"There was a problem displaying the ChemSTEER User Guide. Please verify that you have Adobe's PDF Reader software installed on your computer.", (MsgBoxStyle)64, (object)"Error Viewing ChemSTEER User Guide");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 54;
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

	private void cmdWhatsNew_Click(object sender, EventArgs e)
	{
		((Control)frmStartUp.DefInstance).Show();
	}

	private void cmdQuickStart_Click(object sender, EventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
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
					ProjectData.ClearProjectError();
					num2 = 2;
					Process.Start(Application.StartupPath + "/help/chemsteer_quick_start_guide.pdf");
					goto end_IL_0001;
				case 54:
					num = -1;
					switch (num2)
					{
					case 2:
						Interaction.MsgBox((object)"There was a problem displaying the ChemSTEER Quick Start Guide. Please verify that you have Adobe's PDF Reader software installed on your computer.", (MsgBoxStyle)64, (object)"Error Viewing ChemSTEER Quick Start Guide");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 54;
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

	public bool SetUp(ref short iWhatAmIDoing)
	{
		short num = iWhatAmIDoing;
		if (num == 1)
		{
			((Control)cmdClose).Left = ((Control)cmdRunAssessment).Left;
			((Control)cmdClose).Top = ((Control)cmdRunAssessment).Top;
			((Control)cmdClose).Visible = true;
			((Control)cmdUserGuide).Visible = false;
			((Control)cmdRunAssessment).Visible = false;
			((Control)cmdRunModels).Visible = false;
			((Control)cmdQuickStart).Visible = false;
		}
		else
		{
			((Control)cmdClose).Visible = false;
		}
		return true;
	}

	private void cmdRunAssessment_Click(object sender, EventArgs e)
	{
		Globals_Renamed.gblDoEasyModels = false;
		bButtonPushed = true;
		((Form)this).Close();
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private void cmdClose_Click(object sender, EventArgs e)
	{
		if (((Control)cmdUserGuide).Visible)
		{
			ProjectData.EndApp();
		}
		else
		{
			((Form)this).Close();
		}
	}
}
