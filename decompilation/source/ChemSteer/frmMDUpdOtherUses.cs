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

internal class frmMDUpdOtherUses : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("txtCRSSdate")]
	private TextBox _txtCRSSdate;

	[AccessedThroughProperty("txtMiscCRSSinfo")]
	private TextBox _txtMiscCRSSinfo;

	[AccessedThroughProperty("cmbConsUse")]
	private ComboBox _cmbConsUse;

	[AccessedThroughProperty("txtOtherUses")]
	private TextBox _txtOtherUses;

	[AccessedThroughProperty("CancelButton_Renamed")]
	private Button _CancelButton_Renamed;

	[AccessedThroughProperty("OKButton")]
	private Button _OKButton;

	[AccessedThroughProperty("lblOccExpRating")]
	private Label _lblOccExpRating;

	[AccessedThroughProperty("_Label1_1")]
	private Label __Label1_1;

	[AccessedThroughProperty("_Label1_0")]
	private Label __Label1_0;

	[AccessedThroughProperty("lblInstructions")]
	private Label _lblInstructions;

	[AccessedThroughProperty("_Label1_44")]
	private Label __Label1_44;

	[AccessedThroughProperty("_Label1_43")]
	private Label __Label1_43;

	[AccessedThroughProperty("_Label1_22")]
	private Label __Label1_22;

	[AccessedThroughProperty("Label1")]
	private LabelArray _Label1;

	private static frmMDUpdOtherUses m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	public virtual TextBox txtCRSSdate
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtCRSSdate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtCRSSdate_Leave;
			if (_txtCRSSdate != null)
			{
				((Control)_txtCRSSdate).Leave -= eventHandler;
			}
			_txtCRSSdate = value;
			if (_txtCRSSdate != null)
			{
				((Control)_txtCRSSdate).Leave += eventHandler;
			}
		}
	}

	public virtual TextBox txtMiscCRSSinfo
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMiscCRSSinfo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtMiscCRSSinfo_Leave;
			if (_txtMiscCRSSinfo != null)
			{
				((Control)_txtMiscCRSSinfo).Leave -= eventHandler;
			}
			_txtMiscCRSSinfo = value;
			if (_txtMiscCRSSinfo != null)
			{
				((Control)_txtMiscCRSSinfo).Leave += eventHandler;
			}
		}
	}

	public virtual ComboBox cmbConsUse
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbConsUse;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cmbConsUse = value;
		}
	}

	public virtual TextBox txtOtherUses
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtOtherUses;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtOtherUses_Leave;
			if (_txtOtherUses != null)
			{
				((Control)_txtOtherUses).Leave -= eventHandler;
			}
			_txtOtherUses = value;
			if (_txtOtherUses != null)
			{
				((Control)_txtOtherUses).Leave += eventHandler;
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

	public virtual Label lblOccExpRating
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblOccExpRating;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblOccExpRating = value;
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

	public virtual Label _Label1_44
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_44;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_44 = value;
		}
	}

	public virtual Label _Label1_43
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_43;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_43 = value;
		}
	}

	public virtual Label _Label1_22
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_22 = value;
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

	public static frmMDUpdOtherUses DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmMDUpdOtherUses();
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

	public frmMDUpdOtherUses()
	{
		((Form)this).Load += frmMDUpdOtherUses_Load;
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
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Expected O, but got Unknown
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Expected O, but got Unknown
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Expected O, but got Unknown
		//IL_05a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ad: Expected O, but got Unknown
		//IL_0683: Unknown result type (might be due to invalid IL or missing references)
		//IL_068d: Expected O, but got Unknown
		//IL_0746: Unknown result type (might be due to invalid IL or missing references)
		//IL_0750: Expected O, but got Unknown
		//IL_081a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0824: Expected O, but got Unknown
		//IL_08f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fb: Expected O, but got Unknown
		//IL_09b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bd: Expected O, but got Unknown
		//IL_0a9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa4: Expected O, but got Unknown
		//IL_0b91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9b: Expected O, but got Unknown
		//IL_0d7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d89: Expected O, but got Unknown
		//IL_0d9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da8: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMDUpdOtherUses));
		ToolTip1 = new ToolTip(components);
		txtCRSSdate = new TextBox();
		txtMiscCRSSinfo = new TextBox();
		cmbConsUse = new ComboBox();
		txtOtherUses = new TextBox();
		CancelButton_Renamed = new Button();
		OKButton = new Button();
		lblOccExpRating = new Label();
		_Label1_1 = new Label();
		_Label1_0 = new Label();
		lblInstructions = new Label();
		_Label1_44 = new Label();
		_Label1_43 = new Label();
		_Label1_22 = new Label();
		Label1 = new LabelArray(components);
		((ISupportInitialize)Label1).BeginInit();
		((Control)this).SuspendLayout();
		txtCRSSdate.AcceptsReturn = true;
		((TextBoxBase)txtCRSSdate).BackColor = Color.White;
		((Control)txtCRSSdate).Cursor = Cursors.IBeam;
		((Control)txtCRSSdate).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtCRSSdate).ForeColor = SystemColors.WindowText;
		TextBox obj = txtCRSSdate;
		Point location = new Point(88, 56);
		((Control)obj).Location = location;
		((TextBoxBase)txtCRSSdate).MaxLength = 0;
		((Control)txtCRSSdate).Name = "txtCRSSdate";
		((Control)txtCRSSdate).RightToLeft = (RightToLeft)0;
		txtCRSSdate.ScrollBars = (ScrollBars)2;
		TextBox obj2 = txtCRSSdate;
		Size size = new Size(89, 20);
		((Control)obj2).Size = size;
		((Control)txtCRSSdate).TabIndex = 0;
		txtMiscCRSSinfo.AcceptsReturn = true;
		((TextBoxBase)txtMiscCRSSinfo).BackColor = Color.White;
		((Control)txtMiscCRSSinfo).Cursor = Cursors.IBeam;
		((Control)txtMiscCRSSinfo).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtMiscCRSSinfo).ForeColor = SystemColors.WindowText;
		TextBox obj3 = txtMiscCRSSinfo;
		location = new Point(16, 104);
		((Control)obj3).Location = location;
		((TextBoxBase)txtMiscCRSSinfo).MaxLength = 0;
		txtMiscCRSSinfo.Multiline = true;
		((Control)txtMiscCRSSinfo).Name = "txtMiscCRSSinfo";
		((Control)txtMiscCRSSinfo).RightToLeft = (RightToLeft)0;
		txtMiscCRSSinfo.ScrollBars = (ScrollBars)2;
		TextBox obj4 = txtMiscCRSSinfo;
		size = new Size(633, 75);
		((Control)obj4).Size = size;
		((Control)txtMiscCRSSinfo).TabIndex = 1;
		cmbConsUse.BackColor = SystemColors.Window;
		((Control)cmbConsUse).Cursor = Cursors.Default;
		cmbConsUse.DropDownStyle = (ComboBoxStyle)2;
		((Control)cmbConsUse).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		cmbConsUse.ForeColor = SystemColors.WindowText;
		cmbConsUse.Items.AddRange(new object[3] { "  ", "No", "Yes" });
		ComboBox obj5 = cmbConsUse;
		location = new Point(336, 312);
		((Control)obj5).Location = location;
		((Control)cmbConsUse).Name = "cmbConsUse";
		((Control)cmbConsUse).RightToLeft = (RightToLeft)0;
		ComboBox obj6 = cmbConsUse;
		size = new Size(57, 22);
		((Control)obj6).Size = size;
		((Control)cmbConsUse).TabIndex = 3;
		txtOtherUses.AcceptsReturn = true;
		((TextBoxBase)txtOtherUses).BackColor = Color.White;
		((Control)txtOtherUses).Cursor = Cursors.IBeam;
		((Control)txtOtherUses).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtOtherUses).ForeColor = SystemColors.WindowText;
		TextBox obj7 = txtOtherUses;
		location = new Point(16, 208);
		((Control)obj7).Location = location;
		((TextBoxBase)txtOtherUses).MaxLength = 0;
		txtOtherUses.Multiline = true;
		((Control)txtOtherUses).Name = "txtOtherUses";
		((Control)txtOtherUses).RightToLeft = (RightToLeft)0;
		txtOtherUses.ScrollBars = (ScrollBars)2;
		TextBox obj8 = txtOtherUses;
		size = new Size(633, 75);
		((Control)obj8).Size = size;
		((Control)txtOtherUses).TabIndex = 2;
		((ButtonBase)CancelButton_Renamed).BackColor = SystemColors.Control;
		((Control)CancelButton_Renamed).Cursor = Cursors.Default;
		CancelButton_Renamed.DialogResult = (DialogResult)2;
		((Control)CancelButton_Renamed).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)CancelButton_Renamed).ForeColor = SystemColors.ControlText;
		Button cancelButton_Renamed = CancelButton_Renamed;
		location = new Point(336, 352);
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
		location = new Point(240, 352);
		((Control)oKButton).Location = location;
		((Control)OKButton).Name = "OKButton";
		((Control)OKButton).RightToLeft = (RightToLeft)0;
		Button oKButton2 = OKButton;
		size = new Size(81, 25);
		((Control)oKButton2).Size = size;
		((Control)OKButton).TabIndex = 4;
		((ButtonBase)OKButton).Text = "OK";
		((ButtonBase)OKButton).UseVisualStyleBackColor = false;
		((Control)lblOccExpRating).BackColor = SystemColors.Control;
		lblOccExpRating.BorderStyle = (BorderStyle)2;
		((Control)lblOccExpRating).Cursor = Cursors.Default;
		((Control)lblOccExpRating).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblOccExpRating).ForeColor = SystemColors.ControlText;
		Label obj9 = lblOccExpRating;
		location = new Point(584, 304);
		((Control)obj9).Location = location;
		((Control)lblOccExpRating).Name = "lblOccExpRating";
		((Control)lblOccExpRating).RightToLeft = (RightToLeft)0;
		Label obj10 = lblOccExpRating;
		size = new Size(41, 19);
		((Control)obj10).Size = size;
		((Control)lblOccExpRating).TabIndex = 12;
		((Control)lblOccExpRating).Visible = false;
		((Control)_Label1_1).BackColor = SystemColors.Control;
		((Control)_Label1_1).Cursor = Cursors.Default;
		((Control)_Label1_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_1).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_1, (short)1);
		Label label1_ = _Label1_1;
		location = new Point(16, 56);
		((Control)label1_).Location = location;
		((Control)_Label1_1).Name = "_Label1_1";
		((Control)_Label1_1).RightToLeft = (RightToLeft)0;
		Label label1_2 = _Label1_1;
		size = new Size(73, 17);
		((Control)label1_2).Size = size;
		((Control)_Label1_1).TabIndex = 11;
		_Label1_1.Text = "CRSS Date:";
		((Control)_Label1_0).BackColor = SystemColors.Control;
		((Control)_Label1_0).Cursor = Cursors.Default;
		((Control)_Label1_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_0).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_0, (short)0);
		Label label1_3 = _Label1_0;
		location = new Point(16, 88);
		((Control)label1_3).Location = location;
		((Control)_Label1_0).Name = "_Label1_0";
		((Control)_Label1_0).RightToLeft = (RightToLeft)0;
		Label label1_4 = _Label1_0;
		size = new Size(313, 17);
		((Control)label1_4).Size = size;
		((Control)_Label1_0).TabIndex = 10;
		_Label1_0.Text = "Physical State and Misc CRSS Info:";
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
		((Control)lblInstructions).TabIndex = 9;
		lblInstructions.Text = "xxx";
		((Control)_Label1_44).BackColor = SystemColors.Control;
		((Control)_Label1_44).Cursor = Cursors.Default;
		((Control)_Label1_44).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_44).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_44, (short)44);
		Label label1_5 = _Label1_44;
		location = new Point(120, 312);
		((Control)label1_5).Location = location;
		((Control)_Label1_44).Name = "_Label1_44";
		((Control)_Label1_44).RightToLeft = (RightToLeft)0;
		Label label1_6 = _Label1_44;
		size = new Size(209, 17);
		((Control)label1_6).Size = size;
		((Control)_Label1_44).TabIndex = 8;
		_Label1_44.Text = "Consumer Use: ";
		_Label1_44.TextAlign = (ContentAlignment)4;
		((Control)_Label1_43).BackColor = SystemColors.Control;
		((Control)_Label1_43).Cursor = Cursors.Default;
		((Control)_Label1_43).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_43).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_43, (short)43);
		Label label1_7 = _Label1_43;
		location = new Point(584, 328);
		((Control)label1_7).Location = location;
		((Control)_Label1_43).Name = "_Label1_43";
		((Control)_Label1_43).RightToLeft = (RightToLeft)0;
		Label label1_8 = _Label1_43;
		size = new Size(209, 17);
		((Control)label1_8).Size = size;
		((Control)_Label1_43).TabIndex = 7;
		_Label1_43.Text = "Occupational Exposure Rating (default): ";
		_Label1_43.TextAlign = (ContentAlignment)4;
		((Control)_Label1_43).Visible = false;
		((Control)_Label1_22).BackColor = SystemColors.Control;
		((Control)_Label1_22).Cursor = Cursors.Default;
		((Control)_Label1_22).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_22).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_22, (short)22);
		Label label1_9 = _Label1_22;
		location = new Point(16, 192);
		((Control)label1_9).Location = location;
		((Control)_Label1_22).Name = "_Label1_22";
		((Control)_Label1_22).RightToLeft = (RightToLeft)0;
		Label label1_10 = _Label1_22;
		size = new Size(73, 17);
		((Control)label1_10).Size = size;
		((Control)_Label1_22).TabIndex = 6;
		_Label1_22.Text = "Other Uses: ";
		size = new Size(5, 13);
		((Form)this).AutoScaleBaseSize = size;
		((Form)this).BackColor = SystemColors.Control;
		((Form)this).CancelButton = (IButtonControl)(object)CancelButton_Renamed;
		size = new Size(659, 403);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)txtCRSSdate);
		((Control)this).Controls.Add((Control)(object)txtMiscCRSSinfo);
		((Control)this).Controls.Add((Control)(object)cmbConsUse);
		((Control)this).Controls.Add((Control)(object)txtOtherUses);
		((Control)this).Controls.Add((Control)(object)CancelButton_Renamed);
		((Control)this).Controls.Add((Control)(object)OKButton);
		((Control)this).Controls.Add((Control)(object)lblOccExpRating);
		((Control)this).Controls.Add((Control)(object)_Label1_1);
		((Control)this).Controls.Add((Control)(object)_Label1_0);
		((Control)this).Controls.Add((Control)(object)lblInstructions);
		((Control)this).Controls.Add((Control)(object)_Label1_44);
		((Control)this).Controls.Add((Control)(object)_Label1_43);
		((Control)this).Controls.Add((Control)(object)_Label1_22);
		((Control)this).Cursor = Cursors.Default;
		((Control)this).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		location = new Point(250, 150);
		((Form)this).Location = location;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmMDUpdOtherUses";
		((Control)this).RightToLeft = (RightToLeft)0;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Update Other Uses and Consumer Use";
		((ISupportInitialize)Label1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void CancelButton_Renamed_Click(object eventSender, EventArgs eventArgs)
	{
		((Control)this).Tag = "Cancel";
		((Form)this).Close();
	}

	private void frmMDUpdOtherUses_Load(object eventSender, EventArgs eventArgs)
	{
	}

	private void OKButton_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (Strings.Len(txtCRSSdate.Text) > 0 && !Information.IsDate((object)txtCRSSdate.Text))
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Please enter a valid date.", (MsgBoxStyle)64, (object)"Invalid Date");
			((TextBoxBase)txtCRSSdate).SelectionStart = 0;
			((TextBoxBase)txtCRSSdate).SelectionLength = Strings.Len(txtCRSSdate.Text);
			((Control)txtCRSSdate).Focus();
		}
		else
		{
			UpdateFrmMain();
			Globals_Renamed.gblIWasChanged = true;
			((Form)this).Close();
		}
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
					command.Parameters.Append(command.CreateParameter("pID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, 20));
					Command command2 = command;
					object RecordsAffected = Missing.Value;
					object Parameters = Missing.Value;
					recordset = command2.Execute(out RecordsAffected, ref Parameters);
					command.Parameters.Delete("pID");
					lblInstructions.Text = Conversions.ToString(recordset.Fields[0].Value);
					recordset.Close();
					recordset = null;
					command = null;
					txtCRSSdate.Text = frmMain.DefInstance.lblCRSSdate.Text;
					txtMiscCRSSinfo.Text = frmMain.DefInstance.txtMiscCRSSinfo.Text;
					txtOtherUses.Text = frmMain.DefInstance.txtOtherUses.Text;
					lblOccExpRating.Text = frmMain.DefInstance.lblOccExpRating.Text;
					if (Operators.CompareString(frmMain.DefInstance.lblConsUse.Text, "Yes", false) == 0)
					{
						cmbConsUse.SelectedIndex = 2;
					}
					else if (Operators.CompareString(frmMain.DefInstance.lblConsUse.Text, "No", false) == 0)
					{
						cmbConsUse.SelectedIndex = 1;
					}
					obj = true;
					goto end_IL_0001;
				}
				case 548:
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
				try0001_dispatch = 548;
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
		frmMain.DefInstance.lblCRSSdate.Text = txtCRSSdate.Text;
		frmMain.DefInstance.txtMiscCRSSinfo.Text = txtMiscCRSSinfo.Text;
		frmMain.DefInstance.txtOtherUses.Text = txtOtherUses.Text;
		frmMain.DefInstance.lblConsUse.Text = cmbConsUse.Text;
	}

	private void txtCRSSdate_Leave(object eventSender, EventArgs eventArgs)
	{
		if (Information.IsDate((object)txtCRSSdate.Text))
		{
			DateTime dateTime = Conversions.ToDate(txtCRSSdate.Text);
			txtCRSSdate.Text = Strings.Format((object)dateTime, Globals_Renamed.gblChemDateFormat);
		}
	}

	private void txtMiscCRSSinfo_Leave(object eventSender, EventArgs eventArgs)
	{
		TextBox obj = txtMiscCRSSinfo;
		TextBox val = txtMiscCRSSinfo;
		string pText = val.Text;
		string text = ChemStrX.TrtLineBreak(ref pText);
		val.Text = pText;
		obj.Text = text;
	}

	private void txtOtherUses_Leave(object eventSender, EventArgs eventArgs)
	{
		TextBox obj = txtOtherUses;
		TextBox val = txtOtherUses;
		string pText = val.Text;
		string text = ChemStrX.TrtLineBreak(ref pText);
		val.Text = pText;
		obj.Text = text;
	}
}
