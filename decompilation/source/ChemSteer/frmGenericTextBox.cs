using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Compatibility.VB6;
using Microsoft.VisualBasic.CompilerServices;

namespace ChemSteer;

internal class frmGenericTextBox : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("cmdOk")]
	private Button _cmdOk;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("txtStuff")]
	private TextBox _txtStuff;

	private static frmGenericTextBox m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

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

	public static frmGenericTextBox DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmGenericTextBox();
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

	public frmGenericTextBox()
	{
		((Control)this).Resize += frmGenericTextBox_Resize;
		((Form)this).Activated += frmGenericTextBox_Activated;
		((Form)this).Load += frmGenericTextBox_Load;
		((Form)this).Closing += frmGenericTextBox_Closing;
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
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected O, but got Unknown
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected O, but got Unknown
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmGenericTextBox));
		ToolTip1 = new ToolTip(components);
		cmdOk = new Button();
		cmdCancel = new Button();
		txtStuff = new TextBox();
		((Control)this).SuspendLayout();
		((ButtonBase)cmdOk).BackColor = SystemColors.Control;
		((Control)cmdOk).Cursor = Cursors.Default;
		((Control)cmdOk).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdOk).ForeColor = SystemColors.ControlText;
		Button obj = cmdOk;
		Point location = new Point(88, 128);
		((Control)obj).Location = location;
		((Control)cmdOk).Name = "cmdOk";
		((Control)cmdOk).RightToLeft = (RightToLeft)0;
		Button obj2 = cmdOk;
		Size size = new Size(65, 25);
		((Control)obj2).Size = size;
		((Control)cmdOk).TabIndex = 1;
		((ButtonBase)cmdOk).Text = "OK";
		((ButtonBase)cmdOk).UseVisualStyleBackColor = false;
		((ButtonBase)cmdCancel).BackColor = SystemColors.Control;
		((Control)cmdCancel).Cursor = Cursors.Default;
		cmdCancel.DialogResult = (DialogResult)2;
		((Control)cmdCancel).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCancel).ForeColor = SystemColors.ControlText;
		Button obj3 = cmdCancel;
		location = new Point(168, 128);
		((Control)obj3).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		((Control)cmdCancel).RightToLeft = (RightToLeft)0;
		Button obj4 = cmdCancel;
		size = new Size(65, 25);
		((Control)obj4).Size = size;
		((Control)cmdCancel).TabIndex = 2;
		((ButtonBase)cmdCancel).Text = "Cancel";
		((ButtonBase)cmdCancel).UseVisualStyleBackColor = false;
		txtStuff.AcceptsReturn = true;
		((TextBoxBase)txtStuff).BackColor = SystemColors.Window;
		((Control)txtStuff).Cursor = Cursors.IBeam;
		((Control)txtStuff).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtStuff).ForeColor = SystemColors.WindowText;
		TextBox obj5 = txtStuff;
		location = new Point(8, 8);
		((Control)obj5).Location = location;
		((TextBoxBase)txtStuff).MaxLength = 0;
		txtStuff.Multiline = true;
		((Control)txtStuff).Name = "txtStuff";
		((Control)txtStuff).RightToLeft = (RightToLeft)0;
		txtStuff.ScrollBars = (ScrollBars)2;
		TextBox obj6 = txtStuff;
		size = new Size(305, 105);
		((Control)obj6).Size = size;
		((Control)txtStuff).TabIndex = 0;
		size = new Size(5, 13);
		((Form)this).AutoScaleBaseSize = size;
		((Form)this).CancelButton = (IButtonControl)(object)cmdCancel;
		size = new Size(321, 165);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)cmdOk);
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)txtStuff);
		((Control)this).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		location = new Point(147, 159);
		((Form)this).Location = location;
		((Control)this).Name = "frmGenericTextBox";
		((Form)this).StartPosition = (FormStartPosition)0;
		((Control)this).ResumeLayout(false);
	}

	public bool SetUp(ref string op, [Optional][DefaultParameterValue(null)] ref object value)
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
				checked
				{
					switch (try0001_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num2 = 2;
						if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(value)) & !Information.IsDBNull(RuntimeHelpers.GetObjectValue(value)))
						{
							txtStuff.Text = Conversions.ToString(value);
							short num3 = (short)Strings.InStr(Conversions.ToString(value), "_", (CompareMethod)0);
							if (num3 != 0)
							{
								((TextBoxBase)txtStuff).SelectionStart = num3 - 1;
								((TextBoxBase)txtStuff).SelectionLength = 1;
							}
						}
						flag = true;
						goto end_IL_0001;
					case 232:
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
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 232;
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

	private void cmdCancel_Click(object eventSender, EventArgs eventArgs)
	{
		((Control)this).Tag = "Cancel";
		((Control)this).Hide();
	}

	private void cmdOk_Click(object eventSender, EventArgs eventArgs)
	{
		((Control)this).Hide();
	}

	private void frmGenericTextBox_Activated(object eventSender, EventArgs eventArgs)
	{
		((Control)txtStuff).Focus();
	}

	private void frmGenericTextBox_Load(object eventSender, EventArgs eventArgs)
	{
	}

	private void frmGenericTextBox_Closing(object eventSender, CancelEventArgs eventArgs)
	{
		short num = (short)(0 - (eventArgs.Cancel ? 1 : 0));
		eventArgs.Cancel = num != 0;
	}

	private void frmGenericTextBox_Resize(object eventSender, EventArgs eventArgs)
	{
		checked
		{
			short num = (short)Math.Round(Support.PixelsToTwipsX((double)((Control)this).Width) - 360.0);
			((Control)txtStuff).Width = (int)Math.Round(Support.TwipsToPixelsX(Conversions.ToDouble(Interaction.IIf(num > 0, (object)num, (object)1))));
			num = (short)Math.Round(Support.PixelsToTwipsY((double)((Control)this).Height) - 1300.0);
			((Control)txtStuff).Height = (int)Math.Round(Support.TwipsToPixelsY(Conversions.ToDouble(Interaction.IIf(num > 0, (object)num, (object)1))));
			((Control)cmdOk).Top = (int)Math.Round(Support.TwipsToPixelsY(Support.PixelsToTwipsY((double)((Control)txtStuff).Height) + 250.0));
			((Control)cmdCancel).Top = ((Control)cmdOk).Top;
			((Control)cmdOk).Left = (int)Math.Round(Support.TwipsToPixelsX(Support.PixelsToTwipsX((double)((Control)this).Width) / 2.0 - 60.0 - Support.PixelsToTwipsX((double)((Control)cmdOk).Width)));
			((Control)cmdCancel).Left = (int)Math.Round(Support.TwipsToPixelsX(Support.PixelsToTwipsX((double)((Control)cmdOk).Left) + Support.PixelsToTwipsX((double)((Control)cmdOk).Width) + 120.0));
		}
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
