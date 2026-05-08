using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ChemSteer;

internal class frmModelsToBeRun : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("cmdContinue")]
	private Button _cmdContinue;

	[AccessedThroughProperty("cmdOk")]
	private Button _cmdOk;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("txtMessage")]
	private TextBox _txtMessage;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	private static frmModelsToBeRun m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	public virtual Button cmdContinue
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdContinue;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdContinue_Click;
			if (_cmdContinue != null)
			{
				((Control)_cmdContinue).Click -= eventHandler;
			}
			_cmdContinue = value;
			if (_cmdContinue != null)
			{
				((Control)_cmdContinue).Click += eventHandler;
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

	public virtual TextBox txtMessage
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMessage;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMessage = value;
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

	public static frmModelsToBeRun DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmModelsToBeRun();
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

	public frmModelsToBeRun()
	{
		((Form)this).Load += frmModelsToBeRun_Load;
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
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected O, but got Unknown
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected O, but got Unknown
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Expected O, but got Unknown
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Expected O, but got Unknown
		//IL_0582: Unknown result type (might be due to invalid IL or missing references)
		//IL_058c: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmModelsToBeRun));
		ToolTip1 = new ToolTip(components);
		cmdContinue = new Button();
		cmdOk = new Button();
		cmdCancel = new Button();
		txtMessage = new TextBox();
		Label1 = new Label();
		((Control)this).SuspendLayout();
		((ButtonBase)cmdContinue).BackColor = SystemColors.Control;
		((Control)cmdContinue).Cursor = Cursors.Default;
		cmdContinue.DialogResult = (DialogResult)2;
		((Control)cmdContinue).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdContinue).ForeColor = SystemColors.ControlText;
		Button obj = cmdContinue;
		Point location = new Point(329, 288);
		((Control)obj).Location = location;
		((Control)cmdContinue).Name = "cmdContinue";
		((Control)cmdContinue).RightToLeft = (RightToLeft)0;
		Button obj2 = cmdContinue;
		Size size = new Size(206, 25);
		((Control)obj2).Size = size;
		((Control)cmdContinue).TabIndex = 2;
		((ButtonBase)cmdContinue).Text = "Continue without Running All Models";
		((ButtonBase)cmdContinue).UseVisualStyleBackColor = false;
		((ButtonBase)cmdOk).BackColor = SystemColors.Control;
		((Control)cmdOk).Cursor = Cursors.Default;
		((Control)cmdOk).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdOk).ForeColor = SystemColors.ControlText;
		Button obj3 = cmdOk;
		location = new Point(116, 288);
		((Control)obj3).Location = location;
		((Control)cmdOk).Name = "cmdOk";
		((Control)cmdOk).RightToLeft = (RightToLeft)0;
		Button obj4 = cmdOk;
		size = new Size(206, 25);
		((Control)obj4).Size = size;
		((Control)cmdOk).TabIndex = 1;
		((ButtonBase)cmdOk).Text = "Run All Models";
		((ButtonBase)cmdOk).UseVisualStyleBackColor = false;
		((ButtonBase)cmdCancel).BackColor = SystemColors.Control;
		((Control)cmdCancel).Cursor = Cursors.Default;
		((Control)cmdCancel).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCancel).ForeColor = SystemColors.ControlText;
		Button obj5 = cmdCancel;
		location = new Point(543, 288);
		((Control)obj5).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		((Control)cmdCancel).RightToLeft = (RightToLeft)0;
		Button obj6 = cmdCancel;
		size = new Size(206, 25);
		((Control)obj6).Size = size;
		((Control)cmdCancel).TabIndex = 3;
		((ButtonBase)cmdCancel).Text = "Cancel Action";
		((ButtonBase)cmdCancel).UseVisualStyleBackColor = false;
		txtMessage.AcceptsReturn = true;
		((TextBoxBase)txtMessage).BackColor = SystemColors.Window;
		((Control)txtMessage).Cursor = Cursors.IBeam;
		((Control)txtMessage).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtMessage).ForeColor = SystemColors.WindowText;
		TextBox obj7 = txtMessage;
		location = new Point(8, 80);
		((Control)obj7).Location = location;
		((TextBoxBase)txtMessage).MaxLength = 0;
		txtMessage.Multiline = true;
		((Control)txtMessage).Name = "txtMessage";
		((TextBoxBase)txtMessage).ReadOnly = true;
		((Control)txtMessage).RightToLeft = (RightToLeft)0;
		txtMessage.ScrollBars = (ScrollBars)3;
		TextBox obj8 = txtMessage;
		size = new Size(849, 193);
		((Control)obj8).Size = size;
		((Control)txtMessage).TabIndex = 0;
		((TextBoxBase)txtMessage).WordWrap = false;
		((Control)Label1).BackColor = SystemColors.Control;
		((Control)Label1).Cursor = Cursors.Default;
		((Control)Label1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label1).ForeColor = SystemColors.ControlText;
		Label label = Label1;
		location = new Point(8, 16);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		((Control)Label1).RightToLeft = (RightToLeft)0;
		Label label2 = Label1;
		size = new Size(841, 57);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 4;
		Label1.Text = componentResourceManager.GetString("Label1.Text");
		size = new Size(5, 13);
		((Form)this).AutoScaleBaseSize = size;
		((Form)this).BackColor = SystemColors.Control;
		((Form)this).CancelButton = (IButtonControl)(object)cmdContinue;
		size = new Size(866, 329);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)cmdContinue);
		((Control)this).Controls.Add((Control)(object)cmdOk);
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)txtMessage);
		((Control)this).Controls.Add((Control)(object)Label1);
		((Control)this).Cursor = Cursors.Default;
		((Control)this).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Form)this).FormBorderStyle = (FormBorderStyle)1;
		location = new Point(146, 158);
		((Form)this).Location = location;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmModelsToBeRun";
		((Control)this).RightToLeft = (RightToLeft)0;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Warning - Model results are not current";
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void cmdCancel_Click(object eventSender, EventArgs eventArgs)
	{
		((Control)this).Tag = "Cancel";
		((Control)this).Hide();
	}

	private void cmdContinue_Click(object eventSender, EventArgs eventArgs)
	{
		((Control)this).Tag = "Continue";
		((Control)this).Hide();
	}

	private void cmdOk_Click(object eventSender, EventArgs eventArgs)
	{
		((Control)this).Tag = "RunAll";
		((Control)this).Hide();
	}

	private void frmModelsToBeRun_Load(object eventSender, EventArgs eventArgs)
	{
	}
}
