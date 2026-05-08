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

internal class frmMDUpdLVE : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("txtPVd")]
	private TextBox _txtPVd;

	[AccessedThroughProperty("txtPVi")]
	private TextBox _txtPVi;

	[AccessedThroughProperty("txtPV")]
	private TextBox _txtPV;

	[AccessedThroughProperty("chkCOS")]
	private CheckBox _chkCOS;

	[AccessedThroughProperty("chkBinding")]
	private CheckBox _chkBinding;

	[AccessedThroughProperty("CancelButton_Renamed")]
	private Button _CancelButton_Renamed;

	[AccessedThroughProperty("OKButton")]
	private Button _OKButton;

	[AccessedThroughProperty("_Label2_11")]
	private Label __Label2_11;

	[AccessedThroughProperty("_Label2_12")]
	private Label __Label2_12;

	[AccessedThroughProperty("_Label1_40")]
	private Label __Label1_40;

	[AccessedThroughProperty("_Label1_105")]
	private Label __Label1_105;

	[AccessedThroughProperty("_Label2_13")]
	private Label __Label2_13;

	[AccessedThroughProperty("_Label1_106")]
	private Label __Label1_106;

	[AccessedThroughProperty("lblInstructions")]
	private Label _lblInstructions;

	[AccessedThroughProperty("Label1")]
	private LabelArray _Label1;

	[AccessedThroughProperty("Label2")]
	private LabelArray _Label2;

	private static frmMDUpdLVE m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	public virtual TextBox txtPVd
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtPVd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtPVd_Leave;
			if (_txtPVd != null)
			{
				((Control)_txtPVd).Leave -= eventHandler;
			}
			_txtPVd = value;
			if (_txtPVd != null)
			{
				((Control)_txtPVd).Leave += eventHandler;
			}
		}
	}

	public virtual TextBox txtPVi
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtPVi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtPVi_Leave;
			if (_txtPVi != null)
			{
				((Control)_txtPVi).Leave -= eventHandler;
			}
			_txtPVi = value;
			if (_txtPVi != null)
			{
				((Control)_txtPVi).Leave += eventHandler;
			}
		}
	}

	public virtual TextBox txtPV
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtPV;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtPV = value;
		}
	}

	public virtual CheckBox chkCOS
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkCOS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkCOS = value;
		}
	}

	public virtual CheckBox chkBinding
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkBinding;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkBinding = value;
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

	public virtual Label _Label2_11
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label2_11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label2_11 = value;
		}
	}

	public virtual Label _Label2_12
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label2_12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label2_12 = value;
		}
	}

	public virtual Label _Label1_40
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_40;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_40 = value;
		}
	}

	public virtual Label _Label1_105
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_105;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_105 = value;
		}
	}

	public virtual Label _Label2_13
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label2_13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label2_13 = value;
		}
	}

	public virtual Label _Label1_106
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_106;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_106 = value;
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

	public virtual LabelArray Label2
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

	public static frmMDUpdLVE DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmMDUpdLVE();
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

	public frmMDUpdLVE()
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
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected O, but got Unknown
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected O, but got Unknown
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected O, but got Unknown
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Expected O, but got Unknown
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Expected O, but got Unknown
		//IL_055e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0568: Expected O, but got Unknown
		//IL_0631: Unknown result type (might be due to invalid IL or missing references)
		//IL_063b: Expected O, but got Unknown
		//IL_0704: Unknown result type (might be due to invalid IL or missing references)
		//IL_070e: Expected O, but got Unknown
		//IL_07dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e6: Expected O, but got Unknown
		//IL_08b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c1: Expected O, but got Unknown
		//IL_099c: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a6: Expected O, but got Unknown
		//IL_0a81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8b: Expected O, but got Unknown
		//IL_0b59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b63: Expected O, but got Unknown
		//IL_0c40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4a: Expected O, but got Unknown
		//IL_0e2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e34: Expected O, but got Unknown
		//IL_0e49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e53: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMDUpdLVE));
		ToolTip1 = new ToolTip(components);
		txtPVd = new TextBox();
		txtPVi = new TextBox();
		txtPV = new TextBox();
		chkCOS = new CheckBox();
		chkBinding = new CheckBox();
		CancelButton_Renamed = new Button();
		OKButton = new Button();
		_Label2_11 = new Label();
		_Label2_12 = new Label();
		_Label1_40 = new Label();
		_Label1_105 = new Label();
		_Label2_13 = new Label();
		_Label1_106 = new Label();
		lblInstructions = new Label();
		Label1 = new LabelArray(components);
		Label2 = new LabelArray(components);
		((ISupportInitialize)Label1).BeginInit();
		((ISupportInitialize)Label2).BeginInit();
		((Control)this).SuspendLayout();
		txtPVd.AcceptsReturn = true;
		((TextBoxBase)txtPVd).BackColor = Color.White;
		((Control)txtPVd).Cursor = Cursors.IBeam;
		((Control)txtPVd).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtPVd).ForeColor = SystemColors.WindowText;
		TextBox obj = txtPVd;
		Point location = new Point(280, 88);
		((Control)obj).Location = location;
		((TextBoxBase)txtPVd).MaxLength = 0;
		((Control)txtPVd).Name = "txtPVd";
		((Control)txtPVd).RightToLeft = (RightToLeft)0;
		TextBox obj2 = txtPVd;
		Size size = new Size(81, 20);
		((Control)obj2).Size = size;
		((Control)txtPVd).TabIndex = 1;
		txtPVi.AcceptsReturn = true;
		((TextBoxBase)txtPVi).BackColor = Color.White;
		((Control)txtPVi).Cursor = Cursors.IBeam;
		((Control)txtPVi).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtPVi).ForeColor = SystemColors.WindowText;
		TextBox obj3 = txtPVi;
		location = new Point(280, 112);
		((Control)obj3).Location = location;
		((TextBoxBase)txtPVi).MaxLength = 0;
		((Control)txtPVi).Name = "txtPVi";
		((Control)txtPVi).RightToLeft = (RightToLeft)0;
		TextBox obj4 = txtPVi;
		size = new Size(81, 20);
		((Control)obj4).Size = size;
		((Control)txtPVi).TabIndex = 2;
		txtPV.AcceptsReturn = true;
		((TextBoxBase)txtPV).BackColor = Color.White;
		((Control)txtPV).Cursor = Cursors.IBeam;
		((Control)txtPV).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtPV).ForeColor = SystemColors.WindowText;
		TextBox obj5 = txtPV;
		location = new Point(280, 136);
		((Control)obj5).Location = location;
		((TextBoxBase)txtPV).MaxLength = 0;
		((Control)txtPV).Name = "txtPV";
		((Control)txtPV).RightToLeft = (RightToLeft)0;
		TextBox obj6 = txtPV;
		size = new Size(81, 20);
		((Control)obj6).Size = size;
		((Control)txtPV).TabIndex = 3;
		((ButtonBase)chkCOS).BackColor = SystemColors.Control;
		((Control)chkCOS).Cursor = Cursors.Default;
		((Control)chkCOS).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)chkCOS).ForeColor = SystemColors.ControlText;
		CheckBox obj7 = chkCOS;
		location = new Point(80, 176);
		((Control)obj7).Location = location;
		((Control)chkCOS).Name = "chkCOS";
		((Control)chkCOS).RightToLeft = (RightToLeft)0;
		CheckBox obj8 = chkCOS;
		size = new Size(89, 17);
		((Control)obj8).Size = size;
		((Control)chkCOS).TabIndex = 4;
		((ButtonBase)chkCOS).Text = "C.O.S.";
		((ButtonBase)chkCOS).UseVisualStyleBackColor = false;
		((ButtonBase)chkBinding).BackColor = SystemColors.Control;
		((Control)chkBinding).Cursor = Cursors.Default;
		((Control)chkBinding).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)chkBinding).ForeColor = SystemColors.ControlText;
		CheckBox obj9 = chkBinding;
		location = new Point(80, 64);
		((Control)obj9).Location = location;
		((Control)chkBinding).Name = "chkBinding";
		((Control)chkBinding).RightToLeft = (RightToLeft)0;
		CheckBox obj10 = chkBinding;
		size = new Size(89, 17);
		((Control)obj10).Size = size;
		((Control)chkBinding).TabIndex = 0;
		((ButtonBase)chkBinding).Text = "Binding PV";
		((ButtonBase)chkBinding).UseVisualStyleBackColor = false;
		((ButtonBase)CancelButton_Renamed).BackColor = SystemColors.Control;
		((Control)CancelButton_Renamed).Cursor = Cursors.Default;
		CancelButton_Renamed.DialogResult = (DialogResult)2;
		((Control)CancelButton_Renamed).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)CancelButton_Renamed).ForeColor = SystemColors.ControlText;
		Button cancelButton_Renamed = CancelButton_Renamed;
		location = new Point(224, 216);
		((Control)cancelButton_Renamed).Location = location;
		((Control)CancelButton_Renamed).Name = "CancelButton_Renamed";
		((Control)CancelButton_Renamed).RightToLeft = (RightToLeft)0;
		Button cancelButton_Renamed2 = CancelButton_Renamed;
		size = new Size(81, 25);
		((Control)cancelButton_Renamed2).Size = size;
		((Control)CancelButton_Renamed).TabIndex = 6;
		((ButtonBase)CancelButton_Renamed).Text = "Cancel";
		((ButtonBase)CancelButton_Renamed).UseVisualStyleBackColor = false;
		((ButtonBase)OKButton).BackColor = SystemColors.Control;
		((Control)OKButton).Cursor = Cursors.Default;
		((Control)OKButton).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)OKButton).ForeColor = SystemColors.ControlText;
		Button oKButton = OKButton;
		location = new Point(128, 216);
		((Control)oKButton).Location = location;
		((Control)OKButton).Name = "OKButton";
		((Control)OKButton).RightToLeft = (RightToLeft)0;
		Button oKButton2 = OKButton;
		size = new Size(81, 25);
		((Control)oKButton2).Size = size;
		((Control)OKButton).TabIndex = 5;
		((ButtonBase)OKButton).Text = "OK";
		((ButtonBase)OKButton).UseVisualStyleBackColor = false;
		((Control)_Label2_11).BackColor = SystemColors.Control;
		((Control)_Label2_11).Cursor = Cursors.Default;
		((Control)_Label2_11).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label2_11).ForeColor = SystemColors.WindowText;
		Label2.SetIndex(_Label2_11, (short)11);
		Label label2_ = _Label2_11;
		location = new Point(368, 112);
		((Control)label2_).Location = location;
		((Control)_Label2_11).Name = "_Label2_11";
		((Control)_Label2_11).RightToLeft = (RightToLeft)0;
		Label label2_2 = _Label2_11;
		size = new Size(41, 19);
		((Control)label2_2).Size = size;
		((Control)_Label2_11).TabIndex = 13;
		_Label2_11.Text = " kg/yr";
		((Control)_Label2_12).BackColor = SystemColors.Control;
		((Control)_Label2_12).Cursor = Cursors.Default;
		((Control)_Label2_12).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label2_12).ForeColor = SystemColors.WindowText;
		Label2.SetIndex(_Label2_12, (short)12);
		Label label2_3 = _Label2_12;
		location = new Point(368, 136);
		((Control)label2_3).Location = location;
		((Control)_Label2_12).Name = "_Label2_12";
		((Control)_Label2_12).RightToLeft = (RightToLeft)0;
		Label label2_4 = _Label2_12;
		size = new Size(49, 19);
		((Control)label2_4).Size = size;
		((Control)_Label2_12).TabIndex = 12;
		_Label2_12.Text = " kg/yr";
		((Control)_Label1_40).BackColor = SystemColors.Control;
		((Control)_Label1_40).Cursor = Cursors.Default;
		((Control)_Label1_40).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_40).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_40, (short)40);
		Label label1_ = _Label1_40;
		location = new Point(12, 112);
		((Control)label1_).Location = location;
		((Control)_Label1_40).Name = "_Label1_40";
		((Control)_Label1_40).RightToLeft = (RightToLeft)0;
		Label label1_2 = _Label1_40;
		size = new Size(261, 19);
		((Control)label1_2).Size = size;
		((Control)_Label1_40).TabIndex = 11;
		_Label1_40.Text = "Imported Submission Volume  (SubPVi):";
		_Label1_40.TextAlign = (ContentAlignment)4;
		((Control)_Label1_105).BackColor = SystemColors.Control;
		((Control)_Label1_105).Cursor = Cursors.Default;
		((Control)_Label1_105).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_105).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_105, (short)105);
		Label label1_3 = _Label1_105;
		location = new Point(40, 88);
		((Control)label1_3).Location = location;
		((Control)_Label1_105).Name = "_Label1_105";
		((Control)_Label1_105).RightToLeft = (RightToLeft)0;
		Label label1_4 = _Label1_105;
		size = new Size(233, 19);
		((Control)label1_4).Size = size;
		((Control)_Label1_105).TabIndex = 10;
		_Label1_105.Text = "Domestic Submission Volume (SubPVd):";
		_Label1_105.TextAlign = (ContentAlignment)4;
		((Control)_Label2_13).BackColor = SystemColors.Control;
		((Control)_Label2_13).Cursor = Cursors.Default;
		((Control)_Label2_13).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label2_13).ForeColor = SystemColors.WindowText;
		Label2.SetIndex(_Label2_13, (short)13);
		Label label2_5 = _Label2_13;
		location = new Point(368, 88);
		((Control)label2_5).Location = location;
		((Control)_Label2_13).Name = "_Label2_13";
		((Control)_Label2_13).RightToLeft = (RightToLeft)0;
		Label label2_6 = _Label2_13;
		size = new Size(49, 19);
		((Control)label2_6).Size = size;
		((Control)_Label2_13).TabIndex = 9;
		_Label2_13.Text = " kg/yr";
		((Control)_Label1_106).BackColor = SystemColors.Control;
		((Control)_Label1_106).Cursor = Cursors.Default;
		((Control)_Label1_106).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_106).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_106, (short)106);
		Label label1_5 = _Label1_106;
		location = new Point(80, 136);
		((Control)label1_5).Location = location;
		((Control)_Label1_106).Name = "_Label1_106";
		((Control)_Label1_106).RightToLeft = (RightToLeft)0;
		Label label1_6 = _Label1_106;
		size = new Size(193, 19);
		((Control)label1_6).Size = size;
		((Control)_Label1_106).TabIndex = 8;
		_Label1_106.Text = "Total Submission Volume (SubPV):";
		_Label1_106.TextAlign = (ContentAlignment)4;
		((Control)lblInstructions).BackColor = SystemColors.Control;
		((Control)lblInstructions).Cursor = Cursors.Default;
		((Control)lblInstructions).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblInstructions).ForeColor = SystemColors.ControlText;
		Label obj11 = lblInstructions;
		location = new Point(8, 8);
		((Control)obj11).Location = location;
		((Control)lblInstructions).Name = "lblInstructions";
		((Control)lblInstructions).RightToLeft = (RightToLeft)0;
		Label obj12 = lblInstructions;
		size = new Size(545, 33);
		((Control)obj12).Size = size;
		((Control)lblInstructions).TabIndex = 7;
		lblInstructions.Text = "xxx";
		size = new Size(5, 13);
		((Form)this).AutoScaleBaseSize = size;
		((Form)this).BackColor = SystemColors.Control;
		((Form)this).CancelButton = (IButtonControl)(object)CancelButton_Renamed;
		size = new Size(433, 260);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)txtPVd);
		((Control)this).Controls.Add((Control)(object)txtPVi);
		((Control)this).Controls.Add((Control)(object)txtPV);
		((Control)this).Controls.Add((Control)(object)chkCOS);
		((Control)this).Controls.Add((Control)(object)chkBinding);
		((Control)this).Controls.Add((Control)(object)CancelButton_Renamed);
		((Control)this).Controls.Add((Control)(object)OKButton);
		((Control)this).Controls.Add((Control)(object)_Label2_11);
		((Control)this).Controls.Add((Control)(object)_Label2_12);
		((Control)this).Controls.Add((Control)(object)_Label1_40);
		((Control)this).Controls.Add((Control)(object)_Label1_105);
		((Control)this).Controls.Add((Control)(object)_Label2_13);
		((Control)this).Controls.Add((Control)(object)_Label1_106);
		((Control)this).Controls.Add((Control)(object)lblInstructions);
		((Control)this).Cursor = Cursors.Default;
		((Control)this).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		location = new Point(250, 150);
		((Form)this).Location = location;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmMDUpdLVE";
		((Control)this).RightToLeft = (RightToLeft)0;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Update Special LVE Considerations";
		((ISupportInitialize)Label1).EndInit();
		((ISupportInitialize)Label2).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void CancelButton_Renamed_Click(object eventSender, EventArgs eventArgs)
	{
		((Control)this).Tag = "Cancel";
		((Form)this).Close();
	}

	private void OKButton_Click(object eventSender, EventArgs eventArgs)
	{
		UpdateFrmMain();
		Globals_Renamed.gblIWasChanged = true;
		((Form)this).Close();
	}

	public object SetUp()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		object obj = default(object);
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
					Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
					Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
					Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					ProjectData.ClearProjectError();
					num2 = 2;
					command.ActiveConnection = Common.MyConn;
					command.CommandText = "pqryGetInstructions";
					command.CommandType = CommandTypeEnum.adCmdStoredProc;
					command.Parameters.Append(command.CreateParameter("pID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, 6));
					Command command2 = command;
					object RecordsAffected = Missing.Value;
					object Parameters = Missing.Value;
					recordset = command2.Execute(out RecordsAffected, ref Parameters);
					command.Parameters.Delete("pID");
					lblInstructions.Text = Conversions.ToString(recordset.Fields[0].Value);
					recordset.Close();
					recordset = null;
					command = null;
					frmMain defInstance = frmMain.DefInstance;
					chkBinding.CheckState = (CheckState)Conversions.ToInteger(Interaction.IIf(Operators.CompareString(defInstance.lblBindingPV.Text, "Yes", false) == 0, (object)(CheckState)1, (object)(CheckState)0));
					txtPV.Text = Common.MyNullCheck(defInstance.lblTotalSubPV.Text);
					txtPVd.Text = Common.MyNullCheck(defInstance.lblDomesticSubPV.Text);
					txtPVi.Text = Common.MyNullCheck(defInstance.lblImportedSubPV.Text);
					chkCOS.CheckState = (CheckState)Conversions.ToInteger(Interaction.IIf(Operators.CompareString(defInstance.lblCOS.Text, "Yes", false) == 0, (object)(CheckState)1, (object)(CheckState)0));
					defInstance = null;
					obj = true;
					goto end_IL_0001;
				}
				case 557:
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
			catch (object obj2) when (obj2 is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0001_dispatch = 557;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		object result = obj;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private void UpdateFrmMain()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Invalid comparison between Unknown and I4
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Invalid comparison between Unknown and I4
		frmMain defInstance = frmMain.DefInstance;
		defInstance.lblBindingPV.Text = Conversions.ToString(Interaction.IIf((int)chkBinding.CheckState == 1, (object)"Yes", (object)"No"));
		defInstance.lblTotalSubPV.Text = Common.MyNullCheck(txtPV.Text);
		defInstance.lblDomesticSubPV.Text = Common.MyNullCheck(txtPVd.Text);
		defInstance.lblImportedSubPV.Text = Common.MyNullCheck(txtPVi.Text);
		defInstance.lblCOS.Text = Conversions.ToString(Interaction.IIf((int)chkCOS.CheckState == 1, (object)"Yes", (object)"No"));
		defInstance = null;
	}

	private void txtPVd_Leave(object eventSender, EventArgs eventArgs)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		txtPVd.Text = Strings.Trim(txtPVd.Text);
		if (Strings.Len(txtPVd.Text) > 0)
		{
			if (!Versioned.IsNumeric((object)txtPVd.Text))
			{
				Interaction.Beep();
				Interaction.MsgBox((object)"Please enter a valid number for domestic Submission PV.  If there is no domestic Submission PV, the domestic Submission PV field must be empty.", (MsgBoxStyle)64, (object)"Invalid Data");
				((TextBoxBase)txtPVd).SelectionStart = 0;
				((TextBoxBase)txtPVd).SelectionLength = Strings.Len(txtPVd.Text);
				((Control)txtPVd).Focus();
				return;
			}
			txtPVd.Text = Conversions.ToString(Conversions.ToDouble(txtPVd.Text));
		}
		CalculatePV();
	}

	private void txtPVi_Leave(object eventSender, EventArgs eventArgs)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		txtPVi.Text = Strings.Trim(txtPVi.Text);
		if (Strings.Len(txtPVi.Text) > 0)
		{
			if (!Versioned.IsNumeric((object)txtPVi.Text))
			{
				Interaction.Beep();
				Interaction.MsgBox((object)"Please enter a valid number for imported Submission PV.  If there is no imported Submission PV, the imported Submission PV field must be empty.", (MsgBoxStyle)64, (object)"Invalid Data");
				((TextBoxBase)txtPVi).SelectionStart = 0;
				((TextBoxBase)txtPVi).SelectionLength = Strings.Len(txtPVi.Text);
				((Control)txtPVi).Focus();
				return;
			}
			txtPVi.Text = Conversions.ToString(Conversions.ToDouble(txtPVi.Text));
		}
		CalculatePV();
	}

	private void CalculatePV()
	{
		if (Versioned.IsNumeric((object)txtPVi.Text))
		{
			if (Versioned.IsNumeric((object)txtPVd.Text))
			{
				txtPV.Text = Conversions.ToString(Conversions.ToSingle(txtPVi.Text) + Conversions.ToSingle(txtPVd.Text));
			}
			else
			{
				txtPV.Text = txtPVi.Text;
			}
		}
		else if (Versioned.IsNumeric((object)txtPVd.Text))
		{
			txtPV.Text = txtPVd.Text;
		}
		else
		{
			txtPV.Text = "";
		}
	}
}
