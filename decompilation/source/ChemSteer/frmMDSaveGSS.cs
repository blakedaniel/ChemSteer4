using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ADODB;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ChemSteer;

[DesignerGenerated]
public class frmMDSaveGSS : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("cmdCancel")]
	private Button _cmdCancel;

	[AccessedThroughProperty("cmdOk")]
	private Button _cmdOk;

	[AccessedThroughProperty("lstOps")]
	private ListBox _lstOps;

	[AccessedThroughProperty("lblPDF")]
	private Label _lblPDF;

	[AccessedThroughProperty("cmdPDF")]
	private Button _cmdPDF;

	[AccessedThroughProperty("txtPDF")]
	private TextBox _txtPDF;

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

	public virtual ListBox lstOps
	{
		[DebuggerNonUserCode]
		get
		{
			return _lstOps;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = lstOps_SelectedIndexChanged;
			if (_lstOps != null)
			{
				_lstOps.SelectedIndexChanged -= eventHandler;
			}
			_lstOps = value;
			if (_lstOps != null)
			{
				_lstOps.SelectedIndexChanged += eventHandler;
			}
		}
	}

	internal virtual Label lblPDF
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPDF;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPDF = value;
		}
	}

	public virtual Button cmdPDF
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdPDF;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdPDF_Click;
			if (_cmdPDF != null)
			{
				((Control)_cmdPDF).Click -= eventHandler;
			}
			_cmdPDF = value;
			if (_cmdPDF != null)
			{
				((Control)_cmdPDF).Click += eventHandler;
			}
		}
	}

	internal virtual TextBox txtPDF
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtPDF;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtPDF = value;
		}
	}

	[DebuggerNonUserCode]
	public frmMDSaveGSS()
	{
		__ENCAddToList(this);
		InitializeComponent();
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

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected O, but got Unknown
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected O, but got Unknown
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMDSaveGSS));
		cmdCancel = new Button();
		cmdOk = new Button();
		lstOps = new ListBox();
		lblPDF = new Label();
		cmdPDF = new Button();
		txtPDF = new TextBox();
		((Control)this).SuspendLayout();
		((ButtonBase)cmdCancel).BackColor = SystemColors.Control;
		((Control)cmdCancel).Cursor = Cursors.Default;
		cmdCancel.DialogResult = (DialogResult)2;
		((Control)cmdCancel).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCancel).ForeColor = SystemColors.ControlText;
		Button obj = cmdCancel;
		Point location = new Point(422, 229);
		((Control)obj).Location = location;
		((Control)cmdCancel).Name = "cmdCancel";
		((Control)cmdCancel).RightToLeft = (RightToLeft)0;
		Button obj2 = cmdCancel;
		Size size = new Size(81, 25);
		((Control)obj2).Size = size;
		((Control)cmdCancel).TabIndex = 11;
		((ButtonBase)cmdCancel).Text = "Cancel";
		((ButtonBase)cmdCancel).UseVisualStyleBackColor = false;
		((ButtonBase)cmdOk).BackColor = SystemColors.Control;
		((Control)cmdOk).Cursor = Cursors.Default;
		((Control)cmdOk).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdOk).ForeColor = SystemColors.ControlText;
		Button obj3 = cmdOk;
		location = new Point(335, 229);
		((Control)obj3).Location = location;
		((Control)cmdOk).Name = "cmdOk";
		((Control)cmdOk).RightToLeft = (RightToLeft)0;
		Button obj4 = cmdOk;
		size = new Size(81, 25);
		((Control)obj4).Size = size;
		((Control)cmdOk).TabIndex = 10;
		((ButtonBase)cmdOk).Text = "Save";
		((ButtonBase)cmdOk).UseVisualStyleBackColor = false;
		lstOps.BackColor = Color.White;
		((Control)lstOps).Cursor = Cursors.Default;
		lstOps.Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		lstOps.ForeColor = SystemColors.WindowText;
		lstOps.ItemHeight = 14;
		ListBox obj5 = lstOps;
		location = new Point(23, 27);
		((Control)obj5).Location = location;
		((Control)lstOps).Name = "lstOps";
		lstOps.RightToLeft = (RightToLeft)0;
		ListBox obj6 = lstOps;
		size = new Size(689, 130);
		((Control)obj6).Size = size;
		((Control)lstOps).TabIndex = 9;
		Label obj7 = lblPDF;
		location = new Point(20, 174);
		((Control)obj7).Location = location;
		((Control)lblPDF).Name = "lblPDF";
		Label obj8 = lblPDF;
		size = new Size(86, 23);
		((Control)obj8).Size = size;
		((Control)lblPDF).TabIndex = 12;
		lblPDF.Text = "PDF Help File:";
		((ButtonBase)cmdPDF).BackColor = SystemColors.Control;
		((Control)cmdPDF).Cursor = Cursors.Default;
		((Control)cmdPDF).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdPDF).ForeColor = SystemColors.ControlText;
		Button obj9 = cmdPDF;
		location = new Point(248, 229);
		((Control)obj9).Location = location;
		((Control)cmdPDF).Name = "cmdPDF";
		((Control)cmdPDF).RightToLeft = (RightToLeft)0;
		Button obj10 = cmdPDF;
		size = new Size(81, 25);
		((Control)obj10).Size = size;
		((Control)cmdPDF).TabIndex = 13;
		((ButtonBase)cmdPDF).Text = "Select PDF";
		((ButtonBase)cmdPDF).UseVisualStyleBackColor = false;
		TextBox obj11 = txtPDF;
		location = new Point(100, 171);
		((Control)obj11).Location = location;
		((Control)txtPDF).Name = "txtPDF";
		TextBox obj12 = txtPDF;
		size = new Size(612, 20);
		((Control)obj12).Size = size;
		((Control)txtPDF).TabIndex = 14;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(747, 277);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)txtPDF);
		((Control)this).Controls.Add((Control)(object)cmdPDF);
		((Control)this).Controls.Add((Control)(object)lblPDF);
		((Control)this).Controls.Add((Control)(object)cmdCancel);
		((Control)this).Controls.Add((Control)(object)cmdOk);
		((Control)this).Controls.Add((Control)(object)lstOps);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Control)this).Name = "frmMDSaveGSS";
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Save Generic Scenario Operation";
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void cmdCancel_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void cmdOk_Click(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Invalid comparison between Unknown and I4
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
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
				{
					if (lstOps.SelectedIndex == -1)
					{
						Interaction.MsgBox((object)"Please select (higlight) an operation to save as a GSS.", (MsgBoxStyle)48, (object)"Select the operation you wish to save as a GSS.");
						break;
					}
					Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
					Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					ProjectData.ClearProjectError();
					num2 = 2;
					recordset.CursorLocation = CursorLocationEnum.adUseServer;
					recordset.Open("SELECT * FROM Operations WHERE OpName='" + lstOps.SelectedItem.ToString() + "'", Common.gssConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
					string text;
					if (recordset.EOF)
					{
						text = "The selected operation has been added as a new Generic Scenario";
					}
					else
					{
						if ((int)Interaction.MsgBox((object)"A Generic Scenario with this name already exists in the Generic Scenario Database.  Select 'ok' to continue which will cause the existing Generic Scenario to be overlaid or select 'cancel' to cancel this action.", (MsgBoxStyle)1, (object)"Confirm Action") == 2)
						{
							break;
						}
						text = "The selected Generic Scenario has been updated.";
					}
					if (DBFuncs.saveGSS(lstOps.SelectedIndex, lstOps.SelectedItem.ToString(), txtPDF.Text))
					{
						Interaction.MsgBox((object)text, (MsgBoxStyle)0, (object)"Save Generic Scenario");
						((Form)this).Close();
					}
					break;
				}
				case 274:
					num = -1;
					switch (num2)
					{
					case 2:
						break;
					default:
						goto IL_014a;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 274;
				continue;
			}
			break;
			IL_014a:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public bool setup()
	{
		checked
		{
			int num = Globals_Renamed.intNumOps - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				lstOps.Items.Add(RuntimeHelpers.GetObjectValue(frmMain.DefInstance._lstSelOps_0.Items[num2]));
				num2++;
			}
			if (Globals_Renamed.intNumOps == 1)
			{
				lstOps.SelectedIndex = 0;
			}
			return true;
		}
	}

	private void cmdPDF_Click(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Invalid comparison between Unknown and I4
		OpenFileDialog val = new OpenFileDialog();
		OpenFileDialog val2 = val;
		((FileDialog)val2).Title = "Select the PDF file you would like associated with this GSS";
		((FileDialog)val2).FileName = "*.pdf";
		((FileDialog)val2).DefaultExt = "PDF";
		((FileDialog)val2).Filter = "ChemSTEER Help File (*.PDF)|*.PDF";
		val2 = null;
		if ((int)((CommonDialog)val).ShowDialog() == 1)
		{
			txtPDF.Text = ((FileDialog)val).FileName;
		}
		((Component)(object)val).Dispose();
	}

	private void lstOps_SelectedIndexChanged(object sender, EventArgs e)
	{
		Guid clsid = new Guid("00000514-0000-0010-8000-00AA006D2EA4");
		Connection connection = (Connection)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
		Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		recordset.CursorLocation = CursorLocationEnum.adUseClient;
		string text = Strings.Replace(Strings.Replace(lstOps.Text, "'", " ", 1, -1, (CompareMethod)0), "\"", " ", 1, -1, (CompareMethod)0);
		connection.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Application.StartupPath + "\\scenarios.epa";
		connection.Open();
		recordset.Open("SELECT GSS_PDF FROM Operations WHERE OpName='" + text + "'", connection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
		if (recordset.EOF)
		{
			txtPDF.Text = "";
		}
		else
		{
			txtPDF.Text = Conversions.ToString(recordset.Fields[0].Value);
		}
		recordset.Close();
	}
}
