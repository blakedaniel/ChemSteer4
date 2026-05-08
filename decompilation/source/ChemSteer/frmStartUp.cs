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

internal class frmStartUp : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("lblIntro")]
	private Label _lblIntro;

	[AccessedThroughProperty("Label1")]
	private LabelArray _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("cmdClose")]
	private Button _cmdClose;

	[AccessedThroughProperty("RectangleShape1")]
	private RectangleShape _RectangleShape1;

	[AccessedThroughProperty("ShapeContainer1")]
	private ShapeContainer _ShapeContainer1;

	[AccessedThroughProperty("_Label1_0")]
	private Label __Label1_0;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("Label13")]
	private Label _Label13;

	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	[AccessedThroughProperty("Label15")]
	private Label _Label15;

	[AccessedThroughProperty("Label16")]
	private Label _Label16;

	[AccessedThroughProperty("Label17")]
	private Label _Label17;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	private static frmStartUp m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	public virtual Label lblIntro
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblIntro;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = lblIntro_Click;
			if (_lblIntro != null)
			{
				((Control)_lblIntro).Click -= eventHandler;
			}
			_lblIntro = value;
			if (_lblIntro != null)
			{
				((Control)_lblIntro).Click += eventHandler;
			}
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

	public virtual Label Label2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label2 = value;
		}
	}

	public virtual Label Label3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label3 = value;
		}
	}

	public virtual Label Label4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label4 = value;
		}
	}

	public virtual Label Label5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label5 = value;
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

	public virtual Label Label8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label8 = value;
		}
	}

	public virtual Label Label9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label9 = value;
		}
	}

	public virtual Label Label6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Label6_Click;
			if (_Label6 != null)
			{
				((Control)_Label6).Click -= eventHandler;
			}
			_Label6 = value;
			if (_Label6 != null)
			{
				((Control)_Label6).Click += eventHandler;
			}
		}
	}

	public virtual Label Label10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label10 = value;
		}
	}

	public virtual Label Label11
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label11 = value;
		}
	}

	public virtual Label Label12
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label12 = value;
		}
	}

	public virtual Label Label13
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label13 = value;
		}
	}

	public virtual Label Label14
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label14 = value;
		}
	}

	public virtual Label Label15
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label15 = value;
		}
	}

	public virtual Label Label16
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label16 = value;
		}
	}

	public virtual Label Label17
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Label17_Click;
			if (_Label17 != null)
			{
				((Control)_Label17).Click -= eventHandler;
			}
			_Label17 = value;
			if (_Label17 != null)
			{
				((Control)_Label17).Click += eventHandler;
			}
		}
	}

	public virtual Label Label7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label7 = value;
		}
	}

	public static frmStartUp DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmStartUp();
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

	public frmStartUp()
	{
		((Form)this).Load += frmStartUp_Load;
		((Form)this).Closed += frmStartUp_Closed;
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
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected O, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected O, but got Unknown
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Expected O, but got Unknown
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Expected O, but got Unknown
		//IL_056c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0576: Expected O, but got Unknown
		//IL_06c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0774: Unknown result type (might be due to invalid IL or missing references)
		//IL_077e: Expected O, but got Unknown
		//IL_0838: Unknown result type (might be due to invalid IL or missing references)
		//IL_0842: Expected O, but got Unknown
		//IL_08ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0909: Expected O, but got Unknown
		//IL_09cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d6: Expected O, but got Unknown
		//IL_0a93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9d: Expected O, but got Unknown
		//IL_0b63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6d: Expected O, but got Unknown
		//IL_0c27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c31: Expected O, but got Unknown
		//IL_0ceb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf5: Expected O, but got Unknown
		//IL_0daf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db9: Expected O, but got Unknown
		//IL_0e76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e80: Expected O, but got Unknown
		//IL_0f3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f44: Expected O, but got Unknown
		//IL_0ffe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1008: Expected O, but got Unknown
		//IL_10c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_10cc: Expected O, but got Unknown
		//IL_1322: Unknown result type (might be due to invalid IL or missing references)
		//IL_132c: Expected O, but got Unknown
		//IL_1341: Unknown result type (might be due to invalid IL or missing references)
		//IL_134b: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmStartUp));
		ToolTip1 = new ToolTip(components);
		lblIntro = new Label();
		Label1 = new LabelArray(components);
		Label2 = new Label();
		Label3 = new Label();
		Label4 = new Label();
		Label5 = new Label();
		cmdClose = new Button();
		RectangleShape1 = new RectangleShape();
		ShapeContainer1 = new ShapeContainer();
		_Label1_0 = new Label();
		Label7 = new Label();
		Label8 = new Label();
		Label9 = new Label();
		Label6 = new Label();
		Label10 = new Label();
		Label11 = new Label();
		Label12 = new Label();
		Label13 = new Label();
		Label14 = new Label();
		Label15 = new Label();
		Label16 = new Label();
		Label17 = new Label();
		((ISupportInitialize)Label1).BeginInit();
		((Control)this).SuspendLayout();
		lblIntro.AutoSize = true;
		((Control)lblIntro).BackColor = Color.White;
		((Control)lblIntro).Cursor = Cursors.Default;
		((Control)lblIntro).Font = new Font("Times New Roman", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)lblIntro).ForeColor = SystemColors.ControlText;
		Label obj = lblIntro;
		Point location = new Point(48, 41);
		((Control)obj).Location = location;
		((Control)lblIntro).Name = "lblIntro";
		((Control)lblIntro).RightToLeft = (RightToLeft)0;
		Label obj2 = lblIntro;
		Size size = new Size(228, 22);
		((Control)obj2).Size = size;
		((Control)lblIntro).TabIndex = 0;
		lblIntro.Text = "Welcome to ChemSTEER ";
		((Control)Label2).BackColor = Color.White;
		((Control)Label2).Cursor = Cursors.Default;
		((Control)Label2).Font = new Font("Times New Roman", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label2).ForeColor = SystemColors.ControlText;
		Label label = Label2;
		location = new Point(74, 110);
		((Control)label).Location = location;
		((Control)Label2).Name = "Label2";
		((Control)Label2).RightToLeft = (RightToLeft)0;
		Label label2 = Label2;
		size = new Size(633, 19);
		((Control)label2).Size = size;
		((Control)Label2).TabIndex = 14;
		Label2.Text = "Modified layout - Main tabs have been move to the left and numbered";
		((Control)Label3).BackColor = Color.White;
		((Control)Label3).Cursor = Cursors.Default;
		((Control)Label3).Font = new Font("Times New Roman", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label3).ForeColor = SystemColors.ControlText;
		Label label3 = Label3;
		location = new Point(74, 133);
		((Control)label3).Location = location;
		((Control)Label3).Name = "Label3";
		((Control)Label3).RightToLeft = (RightToLeft)0;
		Label label4 = Label3;
		size = new Size(633, 19);
		((Control)label4).Size = size;
		((Control)Label3).TabIndex = 15;
		Label3.Text = "Included ability to import operations from previously saved assessments";
		((Control)Label4).BackColor = Color.White;
		((Control)Label4).Cursor = Cursors.Default;
		((Control)Label4).Font = new Font("Times New Roman", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label4).ForeColor = SystemColors.ControlText;
		Label label5 = Label4;
		location = new Point(74, 156);
		((Control)label5).Location = location;
		((Control)Label4).Name = "Label4";
		((Control)Label4).RightToLeft = (RightToLeft)0;
		Label label6 = Label4;
		size = new Size(633, 19);
		((Control)label6).Size = size;
		((Control)Label4).TabIndex = 16;
		Label4.Text = "Direct access to release and exposure models";
		((Control)Label5).BackColor = Color.White;
		((Control)Label5).Cursor = Cursors.Default;
		((Control)Label5).Font = new Font("Times New Roman", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label5).ForeColor = SystemColors.ControlText;
		Label label7 = Label5;
		location = new Point(74, 179);
		((Control)label7).Location = location;
		((Control)Label5).Name = "Label5";
		((Control)Label5).RightToLeft = (RightToLeft)0;
		Label label8 = Label5;
		size = new Size(633, 19);
		((Control)label8).Size = size;
		((Control)Label5).TabIndex = 17;
		Label5.Text = "Revamped User Guide and Quick Start Guides";
		((ButtonBase)cmdClose).BackColor = SystemColors.Control;
		((Control)cmdClose).Cursor = Cursors.Default;
		((Control)cmdClose).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)cmdClose).ForeColor = SystemColors.ControlText;
		Button obj3 = cmdClose;
		location = new Point(30, 518);
		((Control)obj3).Location = location;
		((Control)cmdClose).Name = "cmdClose";
		((Control)cmdClose).RightToLeft = (RightToLeft)0;
		Button obj4 = cmdClose;
		size = new Size(98, 30);
		((Control)obj4).Size = size;
		((Control)cmdClose).TabIndex = 19;
		((ButtonBase)cmdClose).Text = "&Close";
		((ButtonBase)cmdClose).UseVisualStyleBackColor = false;
		RectangleShape1.BackColor = Color.WhiteSmoke;
		RectangleShape1.BorderColor = Color.MidnightBlue;
		RectangleShape1.BorderWidth = 3;
		RectangleShape1.FillColor = Color.White;
		RectangleShape1.FillStyle = FillStyle.Solid;
		RectangleShape rectangleShape = RectangleShape1;
		location = new Point(30, 25);
		rectangleShape.Location = location;
		RectangleShape1.Name = "RectangleShape1";
		RectangleShape rectangleShape2 = RectangleShape1;
		size = new Size(764, 486);
		rectangleShape2.Size = size;
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
		size = new Size(822, 555);
		((Control)shapeContainer3).Size = size;
		((Control)ShapeContainer1).TabIndex = 20;
		((Control)ShapeContainer1).TabStop = false;
		((Control)_Label1_0).BackColor = Color.White;
		((Control)_Label1_0).Cursor = Cursors.Default;
		((Control)_Label1_0).Font = new Font("Times New Roman", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_0).ForeColor = SystemColors.ControlText;
		Label label1_ = _Label1_0;
		location = new Point(48, 83);
		((Control)label1_).Location = location;
		((Control)_Label1_0).Name = "_Label1_0";
		((Control)_Label1_0).RightToLeft = (RightToLeft)0;
		Label label1_2 = _Label1_0;
		size = new Size(730, 19);
		((Control)label1_2).Size = size;
		((Control)_Label1_0).TabIndex = 21;
		_Label1_0.Text = "You will find this improved version to contain the following key updates to the last publicly available version.";
		((Control)Label7).BackColor = Color.White;
		((Control)Label7).Cursor = Cursors.Default;
		((Control)Label7).Font = new Font("Times New Roman", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label7).ForeColor = SystemColors.ControlText;
		Label label9 = Label7;
		location = new Point(74, 352);
		((Control)label9).Location = location;
		((Control)Label7).Name = "Label7";
		((Control)Label7).RightToLeft = (RightToLeft)0;
		Label label10 = Label7;
		size = new Size(690, 39);
		((Control)label10).Size = size;
		((Control)Label7).TabIndex = 22;
		Label7.Text = "Revision of the following Generic Scenarios: (a) Adhesives Formulation; and (b) Automobile Refinish Spray Coating.";
		((Control)Label8).BackColor = Color.White;
		((Control)Label8).Cursor = Cursors.Default;
		((Control)Label8).Font = new Font("Times New Roman", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label8).ForeColor = SystemColors.ControlText;
		Label label11 = Label8;
		location = new Point(74, 391);
		((Control)label11).Location = location;
		((Control)Label8).Name = "Label8";
		((Control)Label8).RightToLeft = (RightToLeft)0;
		Label label12 = Label8;
		size = new Size(690, 58);
		((Control)label12).Size = size;
		((Control)Label8).TabIndex = 23;
		Label8.Text = componentResourceManager.GetString("Label8.Text");
		((Control)Label9).BackColor = Color.White;
		((Control)Label9).Cursor = Cursors.Default;
		((Control)Label9).Font = new Font("Times New Roman", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label9).ForeColor = SystemColors.ControlText;
		Label label13 = Label9;
		location = new Point(74, 455);
		((Control)label13).Location = location;
		((Control)Label9).Name = "Label9";
		((Control)Label9).RightToLeft = (RightToLeft)0;
		Label label14 = Label9;
		size = new Size(690, 43);
		((Control)label14).Size = size;
		((Control)Label9).TabIndex = 24;
		Label9.Text = "Added the following models: (a) EPA/OPPT Solids Transfer Dust Loss Model; and (b) EPA/OPPT Near-Field/Far-Field Inhalation Exposure Model.";
		((Control)Label6).BackColor = Color.White;
		((Control)Label6).Cursor = Cursors.Default;
		((Control)Label6).Font = new Font("Times New Roman", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label6).ForeColor = SystemColors.ControlText;
		Label label15 = Label6;
		location = new Point(74, 204);
		((Control)label15).Location = location;
		((Control)Label6).Name = "Label6";
		((Control)Label6).RightToLeft = (RightToLeft)0;
		Label label16 = Label6;
		size = new Size(690, 160);
		((Control)label16).Size = size;
		((Control)Label6).TabIndex = 18;
		Label6.Text = componentResourceManager.GetString("Label6.Text");
		((Control)Label10).BackColor = Color.White;
		((Control)Label10).Cursor = Cursors.Default;
		((Control)Label10).Font = new Font("Times New Roman", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label10).ForeColor = SystemColors.ControlText;
		Label label17 = Label10;
		location = new Point(54, 455);
		((Control)label17).Location = location;
		((Control)Label10).Name = "Label10";
		((Control)Label10).RightToLeft = (RightToLeft)0;
		Label label18 = Label10;
		size = new Size(22, 43);
		((Control)label18).Size = size;
		((Control)Label10).TabIndex = 32;
		Label10.Text = "8.";
		((Control)Label11).BackColor = Color.White;
		((Control)Label11).Cursor = Cursors.Default;
		((Control)Label11).Font = new Font("Times New Roman", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label11).ForeColor = SystemColors.ControlText;
		Label label19 = Label11;
		location = new Point(54, 391);
		((Control)label19).Location = location;
		((Control)Label11).Name = "Label11";
		((Control)Label11).RightToLeft = (RightToLeft)0;
		Label label20 = Label11;
		size = new Size(22, 58);
		((Control)label20).Size = size;
		((Control)Label11).TabIndex = 31;
		Label11.Text = "7.";
		((Control)Label12).BackColor = Color.White;
		((Control)Label12).Cursor = Cursors.Default;
		((Control)Label12).Font = new Font("Times New Roman", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label12).ForeColor = SystemColors.ControlText;
		Label label21 = Label12;
		location = new Point(54, 350);
		((Control)label21).Location = location;
		((Control)Label12).Name = "Label12";
		((Control)Label12).RightToLeft = (RightToLeft)0;
		Label label22 = Label12;
		size = new Size(22, 46);
		((Control)label22).Size = size;
		((Control)Label12).TabIndex = 30;
		Label12.Text = "6.";
		((Control)Label13).BackColor = Color.White;
		((Control)Label13).Cursor = Cursors.Default;
		((Control)Label13).Font = new Font("Times New Roman", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label13).ForeColor = SystemColors.ControlText;
		Label label23 = Label13;
		location = new Point(54, 204);
		((Control)label23).Location = location;
		((Control)Label13).Name = "Label13";
		((Control)Label13).RightToLeft = (RightToLeft)0;
		Label label24 = Label13;
		size = new Size(22, 140);
		((Control)label24).Size = size;
		((Control)Label13).TabIndex = 29;
		Label13.Text = "5.";
		((Control)Label14).BackColor = Color.White;
		((Control)Label14).Cursor = Cursors.Default;
		((Control)Label14).Font = new Font("Times New Roman", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label14).ForeColor = SystemColors.ControlText;
		Label label25 = Label14;
		location = new Point(54, 179);
		((Control)label25).Location = location;
		((Control)Label14).Name = "Label14";
		((Control)Label14).RightToLeft = (RightToLeft)0;
		Label label26 = Label14;
		size = new Size(21, 19);
		((Control)label26).Size = size;
		((Control)Label14).TabIndex = 28;
		Label14.Text = "4.";
		((Control)Label15).BackColor = Color.White;
		((Control)Label15).Cursor = Cursors.Default;
		((Control)Label15).Font = new Font("Times New Roman", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label15).ForeColor = SystemColors.ControlText;
		Label label27 = Label15;
		location = new Point(54, 156);
		((Control)label27).Location = location;
		((Control)Label15).Name = "Label15";
		((Control)Label15).RightToLeft = (RightToLeft)0;
		Label label28 = Label15;
		size = new Size(21, 19);
		((Control)label28).Size = size;
		((Control)Label15).TabIndex = 27;
		Label15.Text = "3.";
		((Control)Label16).BackColor = Color.White;
		((Control)Label16).Cursor = Cursors.Default;
		((Control)Label16).Font = new Font("Times New Roman", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label16).ForeColor = SystemColors.ControlText;
		Label label29 = Label16;
		location = new Point(54, 133);
		((Control)label29).Location = location;
		((Control)Label16).Name = "Label16";
		((Control)Label16).RightToLeft = (RightToLeft)0;
		Label label30 = Label16;
		size = new Size(21, 19);
		((Control)label30).Size = size;
		((Control)Label16).TabIndex = 26;
		Label16.Text = "2.";
		((Control)Label17).BackColor = Color.White;
		((Control)Label17).Cursor = Cursors.Default;
		((Control)Label17).Font = new Font("Times New Roman", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label17).ForeColor = SystemColors.ControlText;
		Label label31 = Label17;
		location = new Point(54, 110);
		((Control)label31).Location = location;
		((Control)Label17).Name = "Label17";
		((Control)Label17).RightToLeft = (RightToLeft)0;
		Label label32 = Label17;
		size = new Size(21, 19);
		((Control)label32).Size = size;
		((Control)Label17).TabIndex = 25;
		Label17.Text = "1.";
		size = new Size(5, 13);
		((Form)this).AutoScaleBaseSize = size;
		((Form)this).BackColor = Color.FromArgb(224, 224, 224);
		size = new Size(822, 555);
		((Form)this).ClientSize = size;
		((Form)this).ControlBox = false;
		((Control)this).Controls.Add((Control)(object)Label10);
		((Control)this).Controls.Add((Control)(object)Label11);
		((Control)this).Controls.Add((Control)(object)Label12);
		((Control)this).Controls.Add((Control)(object)Label13);
		((Control)this).Controls.Add((Control)(object)Label14);
		((Control)this).Controls.Add((Control)(object)Label15);
		((Control)this).Controls.Add((Control)(object)Label16);
		((Control)this).Controls.Add((Control)(object)Label17);
		((Control)this).Controls.Add((Control)(object)Label9);
		((Control)this).Controls.Add((Control)(object)Label8);
		((Control)this).Controls.Add((Control)(object)Label7);
		((Control)this).Controls.Add((Control)(object)_Label1_0);
		((Control)this).Controls.Add((Control)(object)cmdClose);
		((Control)this).Controls.Add((Control)(object)Label6);
		((Control)this).Controls.Add((Control)(object)Label5);
		((Control)this).Controls.Add((Control)(object)Label4);
		((Control)this).Controls.Add((Control)(object)Label3);
		((Control)this).Controls.Add((Control)(object)Label2);
		((Control)this).Controls.Add((Control)(object)lblIntro);
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
		((Control)this).Name = "frmStartUp";
		((Control)this).RightToLeft = (RightToLeft)0;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((ISupportInitialize)Label1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void cmdRun_Click(object eventSender, EventArgs eventArgs)
	{
		((Form)this).Close();
	}

	private void frmStartUp_Load(object eventSender, EventArgs eventArgs)
	{
		Globals_Renamed.gblFrmStartupUnloaded = 1;
		lblIntro.Text += " Version 3.2!";
	}

	private void frmStartUp_Closed(object eventSender, EventArgs eventArgs)
	{
		Globals_Renamed.gblFrmStartupUnloaded = 3;
	}

	private void cmdUserGuide_Click(object sender, EventArgs e)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
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
				case 94:
					num = -1;
					switch (num2)
					{
					case 2:
						Interaction.MsgBox((object)("There was a problem displaying the ChemSTEER User Guide. The error that was encountered was: " + Information.Err().Description), (MsgBoxStyle)16, (object)("ChemSTEER User Guide (" + Conversions.ToString(Information.Err().Number) + ")"));
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 94;
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

	private void cmdQuickStartGuide_Click(object sender, EventArgs e)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
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
				case 94:
					num = -1;
					switch (num2)
					{
					case 2:
						Interaction.MsgBox((object)("There was a problem displaying the ChemSTEER Quick Start Guide. The error that was encountered was: " + Information.Err().Description), (MsgBoxStyle)16, (object)("ChemSTEER Quick Start Guide (" + Conversions.ToString(Information.Err().Number) + ")"));
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 94;
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

	private void cmdEasyModel_Click(object sender, EventArgs e)
	{
		Globals_Renamed.gblDoEasyModels = true;
		((Form)this).Close();
	}

	private void cmdClose_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void lblIntro_Click(object sender, EventArgs e)
	{
	}

	private void Label6_Click(object sender, EventArgs e)
	{
	}

	private void Label17_Click(object sender, EventArgs e)
	{
	}
}
