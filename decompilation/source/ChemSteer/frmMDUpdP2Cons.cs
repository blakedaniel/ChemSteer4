using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.Compatibility.VB6;
using Microsoft.VisualBasic.CompilerServices;

namespace ChemSteer;

internal class frmMDUpdP2Cons : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("txtP2Rec")]
	private TextBox _txtP2Rec;

	[AccessedThroughProperty("txtInfo")]
	private TextBox _txtInfo;

	[AccessedThroughProperty("CancelButton_Renamed")]
	private Button _CancelButton_Renamed;

	[AccessedThroughProperty("OKButton")]
	private Button _OKButton;

	[AccessedThroughProperty("chkP2Rec")]
	private CheckBox _chkP2Rec;

	[AccessedThroughProperty("_Label1_1")]
	private Label __Label1_1;

	[AccessedThroughProperty("_Label1_0")]
	private Label __Label1_0;

	[AccessedThroughProperty("Label1")]
	private LabelArray _Label1;

	private static frmMDUpdP2Cons m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	public virtual TextBox txtP2Rec
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtP2Rec;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtP2Rec = value;
		}
	}

	public virtual TextBox txtInfo
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtInfo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtInfo = value;
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

	public virtual CheckBox chkP2Rec
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkP2Rec;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = chkP2Rec_CheckStateChanged;
			if (_chkP2Rec != null)
			{
				_chkP2Rec.CheckStateChanged -= eventHandler;
			}
			_chkP2Rec = value;
			if (_chkP2Rec != null)
			{
				_chkP2Rec.CheckStateChanged += eventHandler;
			}
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

	public static frmMDUpdP2Cons DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmMDUpdP2Cons();
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

	public frmMDUpdP2Cons()
	{
		((Form)this).Load += frmMDUpdP2Cons_Load;
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
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected O, but got Unknown
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected O, but got Unknown
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected O, but got Unknown
		//IL_0468: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Expected O, but got Unknown
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_0541: Expected O, but got Unknown
		//IL_060c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0616: Expected O, but got Unknown
		//IL_078c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0796: Expected O, but got Unknown
		//IL_07ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b5: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMDUpdP2Cons));
		ToolTip1 = new ToolTip(components);
		txtP2Rec = new TextBox();
		txtInfo = new TextBox();
		CancelButton_Renamed = new Button();
		OKButton = new Button();
		chkP2Rec = new CheckBox();
		_Label1_1 = new Label();
		_Label1_0 = new Label();
		Label1 = new LabelArray(components);
		((ISupportInitialize)Label1).BeginInit();
		((Control)this).SuspendLayout();
		txtP2Rec.AcceptsReturn = true;
		((TextBoxBase)txtP2Rec).BackColor = SystemColors.Control;
		((Control)txtP2Rec).Cursor = Cursors.IBeam;
		((Control)txtP2Rec).Enabled = false;
		((Control)txtP2Rec).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtP2Rec).ForeColor = SystemColors.WindowText;
		TextBox obj = txtP2Rec;
		Point location = new Point(8, 208);
		((Control)obj).Location = location;
		((TextBoxBase)txtP2Rec).MaxLength = 0;
		txtP2Rec.Multiline = true;
		((Control)txtP2Rec).Name = "txtP2Rec";
		((Control)txtP2Rec).RightToLeft = (RightToLeft)0;
		txtP2Rec.ScrollBars = (ScrollBars)2;
		TextBox obj2 = txtP2Rec;
		Size size = new Size(529, 107);
		((Control)obj2).Size = size;
		((Control)txtP2Rec).TabIndex = 2;
		txtInfo.AcceptsReturn = true;
		((TextBoxBase)txtInfo).BackColor = SystemColors.Window;
		((Control)txtInfo).Cursor = Cursors.IBeam;
		((Control)txtInfo).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtInfo).ForeColor = SystemColors.WindowText;
		TextBox obj3 = txtInfo;
		location = new Point(8, 64);
		((Control)obj3).Location = location;
		((TextBoxBase)txtInfo).MaxLength = 0;
		txtInfo.Multiline = true;
		((Control)txtInfo).Name = "txtInfo";
		((Control)txtInfo).RightToLeft = (RightToLeft)0;
		txtInfo.ScrollBars = (ScrollBars)2;
		TextBox obj4 = txtInfo;
		size = new Size(529, 107);
		((Control)obj4).Size = size;
		((Control)txtInfo).TabIndex = 0;
		((ButtonBase)CancelButton_Renamed).BackColor = SystemColors.Control;
		((Control)CancelButton_Renamed).Cursor = Cursors.Default;
		CancelButton_Renamed.DialogResult = (DialogResult)2;
		((Control)CancelButton_Renamed).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)CancelButton_Renamed).ForeColor = SystemColors.ControlText;
		Button cancelButton_Renamed = CancelButton_Renamed;
		location = new Point(280, 336);
		((Control)cancelButton_Renamed).Location = location;
		((Control)CancelButton_Renamed).Name = "CancelButton_Renamed";
		((Control)CancelButton_Renamed).RightToLeft = (RightToLeft)0;
		Button cancelButton_Renamed2 = CancelButton_Renamed;
		size = new Size(81, 25);
		((Control)cancelButton_Renamed2).Size = size;
		((Control)CancelButton_Renamed).TabIndex = 4;
		((ButtonBase)CancelButton_Renamed).Text = "Cancel";
		((ButtonBase)CancelButton_Renamed).UseVisualStyleBackColor = false;
		((ButtonBase)OKButton).BackColor = SystemColors.Control;
		((Control)OKButton).Cursor = Cursors.Default;
		((Control)OKButton).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)OKButton).ForeColor = SystemColors.ControlText;
		Button oKButton = OKButton;
		location = new Point(184, 336);
		((Control)oKButton).Location = location;
		((Control)OKButton).Name = "OKButton";
		((Control)OKButton).RightToLeft = (RightToLeft)0;
		Button oKButton2 = OKButton;
		size = new Size(81, 25);
		((Control)oKButton2).Size = size;
		((Control)OKButton).TabIndex = 3;
		((ButtonBase)OKButton).Text = "OK";
		((ButtonBase)OKButton).UseVisualStyleBackColor = false;
		((ButtonBase)chkP2Rec).BackColor = SystemColors.Control;
		((Control)chkP2Rec).Cursor = Cursors.Default;
		((Control)chkP2Rec).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)chkP2Rec).ForeColor = SystemColors.ControlText;
		CheckBox obj5 = chkP2Rec;
		location = new Point(8, 192);
		((Control)obj5).Location = location;
		((Control)chkP2Rec).Name = "chkP2Rec";
		((Control)chkP2Rec).RightToLeft = (RightToLeft)0;
		CheckBox obj6 = chkP2Rec;
		size = new Size(113, 17);
		((Control)obj6).Size = size;
		((Control)chkP2Rec).TabIndex = 1;
		((ButtonBase)chkP2Rec).Text = "P2REC";
		((ButtonBase)chkP2Rec).UseVisualStyleBackColor = false;
		((Control)_Label1_1).BackColor = SystemColors.Control;
		((Control)_Label1_1).Cursor = Cursors.Default;
		((Control)_Label1_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_1).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_1, (short)1);
		Label label1_ = _Label1_1;
		location = new Point(8, 48);
		((Control)label1_).Location = location;
		((Control)_Label1_1).Name = "_Label1_1";
		((Control)_Label1_1).RightToLeft = (RightToLeft)0;
		Label label1_2 = _Label1_1;
		size = new Size(409, 17);
		((Control)label1_2).Size = size;
		((Control)_Label1_1).TabIndex = 6;
		_Label1_1.Text = "Optional P2 Information";
		((Control)_Label1_0).BackColor = SystemColors.Control;
		((Control)_Label1_0).Cursor = Cursors.Default;
		((Control)_Label1_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_0).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_0, (short)0);
		Label label1_3 = _Label1_0;
		location = new Point(8, 16);
		((Control)label1_3).Location = location;
		((Control)_Label1_0).Name = "_Label1_0";
		((Control)_Label1_0).RightToLeft = (RightToLeft)0;
		Label label1_4 = _Label1_0;
		size = new Size(537, 25);
		((Control)label1_4).Size = size;
		((Control)_Label1_0).TabIndex = 5;
		_Label1_0.Text = "Add or enter P2 considerations below.  When you are done, press OK to save this information to the database.";
		size = new Size(5, 13);
		((Form)this).AutoScaleBaseSize = size;
		((Form)this).BackColor = SystemColors.Control;
		((Form)this).CancelButton = (IButtonControl)(object)CancelButton_Renamed;
		size = new Size(545, 376);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)txtP2Rec);
		((Control)this).Controls.Add((Control)(object)txtInfo);
		((Control)this).Controls.Add((Control)(object)CancelButton_Renamed);
		((Control)this).Controls.Add((Control)(object)OKButton);
		((Control)this).Controls.Add((Control)(object)chkP2Rec);
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
		((Control)this).Name = "frmMDUpdP2Cons";
		((Control)this).RightToLeft = (RightToLeft)0;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Add or Update P2 Considerations";
		((ISupportInitialize)Label1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void CancelButton_Renamed_Click(object eventSender, EventArgs eventArgs)
	{
		((Form)this).Close();
	}

	private void chkP2Rec_CheckStateChanged(object eventSender, EventArgs eventArgs)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		if ((int)chkP2Rec.CheckState == 1)
		{
			((Control)txtP2Rec).Enabled = true;
			((TextBoxBase)txtP2Rec).BackColor = Color.White;
			if (Operators.CompareString(txtP2Rec.Text, "", false) == 0)
			{
				txtP2Rec.Text = "No additional notes to add.";
			}
		}
		else
		{
			((Control)txtP2Rec).Enabled = false;
			((TextBoxBase)txtP2Rec).BackColor = ((Form)this).BackColor;
		}
	}

	private void frmMDUpdP2Cons_Load(object eventSender, EventArgs eventArgs)
	{
	}

	private void OKButton_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Invalid comparison between Unknown and I4
		TextBox txtP2Cons = frmMain.DefInstance.txtP2Cons;
		TextBox val = txtInfo;
		string pText = val.Text;
		string text = ChemStrX.TrtLineBreak(ref pText);
		val.Text = pText;
		txtP2Cons.Text = text;
		frmMain.DefInstance.chkp2rec.CheckState = chkP2Rec.CheckState;
		if ((int)chkP2Rec.CheckState == 1)
		{
			TextBox obj = frmMain.DefInstance.txtP2Rec;
			val = txtP2Rec;
			pText = val.Text;
			string text2 = ChemStrX.TrtLineBreak(ref pText);
			val.Text = pText;
			obj.Text = text2;
		}
		else
		{
			frmMain.DefInstance.txtP2Rec.Text = "";
		}
		Globals_Renamed.gblIWasChanged = true;
		((Form)this).Close();
	}

	public bool SetUp()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		txtInfo.Text = frmMain.DefInstance.txtP2Cons.Text;
		txtP2Rec.Text = frmMain.DefInstance.txtP2Rec.Text;
		chkP2Rec.CheckState = frmMain.DefInstance.chkp2rec.CheckState;
		return true;
	}
}
