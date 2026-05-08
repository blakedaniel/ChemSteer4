using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ChemSteer;

internal class frmWaterAndInhBasis : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("cmdBasis")]
	private Button _cmdBasis;

	[AccessedThroughProperty("cmbDefaultText")]
	private ComboBox _cmbDefaultText;

	[AccessedThroughProperty("cmdOk")]
	private Button _cmdOk;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("txtStuff")]
	private TextBox _txtStuff;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("lblInstructions")]
	private Label _lblInstructions;

	private static frmWaterAndInhBasis m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	private short myType;

	public virtual Button cmdBasis
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdBasis;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdBasis_Click;
			if (_cmdBasis != null)
			{
				((Control)_cmdBasis).Click -= eventHandler;
			}
			_cmdBasis = value;
			if (_cmdBasis != null)
			{
				((Control)_cmdBasis).Click += eventHandler;
			}
		}
	}

	public virtual ComboBox cmbDefaultText
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbDefaultText;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cmbDefaultText = value;
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

	public virtual TextBox txtStuff
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtStuff;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtStuff_Leave;
			if (_txtStuff != null)
			{
				((Control)_txtStuff).Leave -= eventHandler;
			}
			_txtStuff = value;
			if (_txtStuff != null)
			{
				((Control)_txtStuff).Leave += eventHandler;
			}
		}
	}

	public virtual Label Label1
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

	public static frmWaterAndInhBasis DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmWaterAndInhBasis();
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

	public frmWaterAndInhBasis()
	{
		((Form)this).Activated += frmWaterAndInhBasis_Activated;
		((Form)this).Load += frmWaterAndInhBasis_Load;
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
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected O, but got Unknown
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected O, but got Unknown
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Expected O, but got Unknown
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Expected O, but got Unknown
		//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f6: Expected O, but got Unknown
		//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Expected O, but got Unknown
		//IL_071b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0725: Expected O, but got Unknown
		//IL_073a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0744: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmWaterAndInhBasis));
		ToolTip1 = new ToolTip(components);
		cmdBasis = new Button();
		cmbDefaultText = new ComboBox();
		cmdOk = new Button();
		cmdCancel = new Button();
		txtStuff = new TextBox();
		Label1 = new Label();
		lblInstructions = new Label();
		((Control)this).SuspendLayout();
		((ButtonBase)cmdBasis).BackColor = SystemColors.Control;
		((Control)cmdBasis).Cursor = Cursors.Default;
		((Control)cmdBasis).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdBasis).ForeColor = SystemColors.ControlText;
		Button obj = cmdBasis;
		Point location = new Point(264, 128);
		((Control)obj).Location = location;
		((Control)cmdBasis).Name = "cmdBasis";
		((Control)cmdBasis).RightToLeft = (RightToLeft)0;
		Button obj2 = cmdBasis;
		Size size = new Size(209, 25);
		((Control)obj2).Size = size;
		((Control)cmdBasis).TabIndex = 5;
		((ButtonBase)cmdBasis).Text = "&Add Standard text";
		((ButtonBase)cmdBasis).UseVisualStyleBackColor = false;
		cmbDefaultText.BackColor = SystemColors.Window;
		((Control)cmbDefaultText).Cursor = Cursors.Default;
		cmbDefaultText.DropDownStyle = (ComboBoxStyle)2;
		((Control)cmbDefaultText).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		cmbDefaultText.ForeColor = SystemColors.WindowText;
		ComboBox obj3 = cmbDefaultText;
		location = new Point(8, 88);
		((Control)obj3).Location = location;
		((Control)cmbDefaultText).Name = "cmbDefaultText";
		((Control)cmbDefaultText).RightToLeft = (RightToLeft)0;
		ComboBox obj4 = cmbDefaultText;
		size = new Size(721, 22);
		((Control)obj4).Size = size;
		((Control)cmbDefaultText).TabIndex = 4;
		((ButtonBase)cmdOk).BackColor = SystemColors.Control;
		((Control)cmdOk).Cursor = Cursors.Default;
		((Control)cmdOk).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdOk).ForeColor = SystemColors.ControlText;
		Button obj5 = cmdOk;
		location = new Point(296, 264);
		((Control)obj5).Location = location;
		((Control)cmdOk).Name = "cmdOk";
		((Control)cmdOk).RightToLeft = (RightToLeft)0;
		Button obj6 = cmdOk;
		size = new Size(65, 25);
		((Control)obj6).Size = size;
		((Control)cmdOk).TabIndex = 1;
		((ButtonBase)cmdOk).Text = "OK";
		((ButtonBase)cmdOk).UseVisualStyleBackColor = false;
		((ButtonBase)cmdCancel).BackColor = SystemColors.Control;
		((Control)cmdCancel).Cursor = Cursors.Default;
		cmdCancel.DialogResult = (DialogResult)2;
		((Control)cmdCancel).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCancel).ForeColor = SystemColors.ControlText;
		Button obj7 = cmdCancel;
		location = new Point(376, 264);
		((Control)obj7).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		((Control)cmdCancel).RightToLeft = (RightToLeft)0;
		Button obj8 = cmdCancel;
		size = new Size(65, 25);
		((Control)obj8).Size = size;
		((Control)cmdCancel).TabIndex = 2;
		((ButtonBase)cmdCancel).Text = "Cancel";
		((ButtonBase)cmdCancel).UseVisualStyleBackColor = false;
		txtStuff.AcceptsReturn = true;
		((TextBoxBase)txtStuff).BackColor = SystemColors.Window;
		((Control)txtStuff).Cursor = Cursors.IBeam;
		((Control)txtStuff).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtStuff).ForeColor = SystemColors.WindowText;
		TextBox obj9 = txtStuff;
		location = new Point(8, 176);
		((Control)obj9).Location = location;
		((TextBoxBase)txtStuff).MaxLength = 0;
		txtStuff.Multiline = true;
		((Control)txtStuff).Name = "txtStuff";
		((Control)txtStuff).RightToLeft = (RightToLeft)0;
		txtStuff.ScrollBars = (ScrollBars)2;
		TextBox obj10 = txtStuff;
		size = new Size(721, 73);
		((Control)obj10).Size = size;
		((Control)txtStuff).TabIndex = 0;
		((Control)Label1).BackColor = SystemColors.Control;
		((Control)Label1).Cursor = Cursors.Default;
		((Control)Label1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label1).ForeColor = SystemColors.ControlText;
		Label label = Label1;
		location = new Point(8, 72);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		((Control)Label1).RightToLeft = (RightToLeft)0;
		Label label2 = Label1;
		size = new Size(425, 17);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 6;
		Label1.Text = "Select standard text";
		((Control)lblInstructions).BackColor = SystemColors.Control;
		((Control)lblInstructions).Cursor = Cursors.Default;
		((Control)lblInstructions).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblInstructions).ForeColor = SystemColors.ControlText;
		Label obj11 = lblInstructions;
		location = new Point(8, 16);
		((Control)obj11).Location = location;
		((Control)lblInstructions).Name = "lblInstructions";
		((Control)lblInstructions).RightToLeft = (RightToLeft)0;
		Label obj12 = lblInstructions;
		size = new Size(721, 41);
		((Control)obj12).Size = size;
		((Control)lblInstructions).TabIndex = 3;
		lblInstructions.Text = "x";
		size = new Size(5, 13);
		((Form)this).AutoScaleBaseSize = size;
		((Form)this).BackColor = SystemColors.Control;
		((Form)this).CancelButton = (IButtonControl)(object)cmdCancel;
		size = new Size(736, 313);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)cmdBasis);
		((Control)this).Controls.Add((Control)(object)cmbDefaultText);
		((Control)this).Controls.Add((Control)(object)cmdOk);
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)txtStuff);
		((Control)this).Controls.Add((Control)(object)Label1);
		((Control)this).Controls.Add((Control)(object)lblInstructions);
		((Control)this).Cursor = Cursors.Default;
		((Control)this).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		location = new Point(250, 150);
		((Form)this).Location = location;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmWaterAndInhBasis";
		((Control)this).RightToLeft = (RightToLeft)0;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public bool SetUp(ref short pType)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
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
					cmbDefaultText.Items.Clear();
					myType = pType;
					if (myType == 0)
					{
						((Form)this).Text = "View / Update Release Basis for the Operation";
						lblInstructions.Text = "Text added to this box will appear on the IRER report at the beginning of the Releases section for this operation.";
						cmbDefaultText.Items.Add((object)"Water - not expected. ");
						cmbDefaultText.Items.Add((object)"IRER Note: The daily releases listed for any source below may coincide with daily releases from the other sources to the same medium. ");
						cmbDefaultText.Items.Add((object)"IRER Note: The daily releases listed for any source below are expected to coincide with daily releases from the other sources to the same medium. ");
						cmbDefaultText.Items.Add((object)"IRER Note: The daily releases listed for any source below are not expected to coincide with daily releases from the other sources to the same medium. ");
						txtStuff.Text = Globals_Renamed.arWaterBasis[Globals_Renamed.intOpIndex];
					}
					else if (myType == 2)
					{
						((Form)this).Text = "View / Update Inhalation Basis for the Operation";
						lblInstructions.Text = "Text added to this box will appear on the IRER report at the beginning of the Inhalation section for this operation.";
						cmbDefaultText.Items.Add((object)"negligible (VP < 0.001 torr) ");
						txtStuff.Text = Globals_Renamed.arInhalationBasis[Globals_Renamed.intOpIndex];
					}
					else
					{
						((Form)this).Text = "View / Update Dermal Basis for the Operation";
						lblInstructions.Text = "Text added to this box will appear on the IRER report at the beginning of the Dermal section for this operation.";
						cmbDefaultText.Items.Add((object)"Negligible - Corrosives (pH > 12, pH < 2).");
						cmbDefaultText.Items.Add((object)"Negligible - Materials at temperatures >140 deg. F (60 deg. C).");
						cmbDefaultText.Items.Add((object)"Non-Quantifiable (Some surface contact may occur if manually transferred) - in cast solids (such as molded plastics) or in matrices such as extruded pellets.");
						cmbDefaultText.Items.Add((object)"Non-Quantifiable - 'Dry' surface coatings (e.g., fiber spin finishes).");
						cmbDefaultText.Items.Add((object)"Non-Quantifiable - Gases/Vapors (Some contact may occur in the absence of protective clothing).");
						txtStuff.Text = Globals_Renamed.arDermalBasis[Globals_Renamed.intOpIndex];
					}
					flag = true;
					goto end_IL_0001;
				case 559:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						string Eobject = ((Control)this).Name;
						string Efunction = "SetUp";
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
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 559;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private void cmdBasis_Click(object eventSender, EventArgs eventArgs)
	{
		if (cmbDefaultText.SelectedIndex >= 0)
		{
			txtStuff.Text += cmbDefaultText.Text;
		}
	}

	private void cmdCancel_Click(object eventSender, EventArgs eventArgs)
	{
		((Form)this).Close();
	}

	private void cmdOk_Click(object eventSender, EventArgs eventArgs)
	{
		if (myType == 0)
		{
			Globals_Renamed.arWaterBasis[Globals_Renamed.intOpIndex] = Common.MyNullCheck(txtStuff.Text);
		}
		else if (myType == 2)
		{
			Globals_Renamed.arInhalationBasis[Globals_Renamed.intOpIndex] = Common.MyNullCheck(txtStuff.Text);
		}
		else
		{
			Globals_Renamed.arDermalBasis[Globals_Renamed.intOpIndex] = Common.MyNullCheck(txtStuff.Text);
		}
		((Form)this).Close();
	}

	private void frmWaterAndInhBasis_Activated(object eventSender, EventArgs eventArgs)
	{
		((Control)txtStuff).Focus();
	}

	private void frmWaterAndInhBasis_Load(object eventSender, EventArgs eventArgs)
	{
	}

	private void txtStuff_Leave(object eventSender, EventArgs eventArgs)
	{
		TextBox obj = txtStuff;
		TextBox val = txtStuff;
		string pText = val.Text;
		string text = ChemStrX.TrtLineBreak(ref pText);
		val.Text = pText;
		obj.Text = text;
	}
}
