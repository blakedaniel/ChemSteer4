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

internal class frmMDAddExpModel : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("cmbIModels")]
	private ComboBox _cmbIModels;

	[AccessedThroughProperty("cmbDModels")]
	private ComboBox _cmbDModels;

	[AccessedThroughProperty("CancelButton_Renamed")]
	private Button _CancelButton_Renamed;

	[AccessedThroughProperty("OKButton")]
	private Button _OKButton;

	[AccessedThroughProperty("_Label1_1")]
	private Label __Label1_1;

	[AccessedThroughProperty("lblAct")]
	private Label _lblAct;

	[AccessedThroughProperty("lblInstructions")]
	private Label _lblInstructions;

	[AccessedThroughProperty("_Label1_0")]
	private Label __Label1_0;

	[AccessedThroughProperty("CachedIRERcomb1")]
	private CachedIRERcomb _CachedIRERcomb1;

	[AccessedThroughProperty("Label1")]
	private LabelArray _Label1;

	private static frmMDAddExpModel m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	private bool LoadingControls;

	private short intOldDModel;

	private short intOldIModel;

	public virtual ComboBox cmbIModels
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbIModels;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cmbIModels = value;
		}
	}

	public virtual ComboBox cmbDModels
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbDModels;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cmbDModels = value;
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

	internal virtual CachedIRERcomb CachedIRERcomb1
	{
		[DebuggerNonUserCode]
		get
		{
			return _CachedIRERcomb1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CachedIRERcomb1 = value;
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

	public static frmMDAddExpModel DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmMDAddExpModel();
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

	public frmMDAddExpModel()
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
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected O, but got Unknown
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected O, but got Unknown
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Expected O, but got Unknown
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Expected O, but got Unknown
		//IL_050c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Expected O, but got Unknown
		//IL_05cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d7: Expected O, but got Unknown
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0699: Expected O, but got Unknown
		//IL_083b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0845: Expected O, but got Unknown
		//IL_085a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0864: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMDAddExpModel));
		ToolTip1 = new ToolTip(components);
		cmbIModels = new ComboBox();
		cmbDModels = new ComboBox();
		CancelButton_Renamed = new Button();
		OKButton = new Button();
		_Label1_1 = new Label();
		lblAct = new Label();
		lblInstructions = new Label();
		_Label1_0 = new Label();
		Label1 = new LabelArray(components);
		CachedIRERcomb1 = new CachedIRERcomb();
		((ISupportInitialize)Label1).BeginInit();
		((Control)this).SuspendLayout();
		cmbIModels.BackColor = SystemColors.Window;
		((Control)cmbIModels).Cursor = Cursors.Default;
		cmbIModels.DropDownStyle = (ComboBoxStyle)2;
		((Control)cmbIModels).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		cmbIModels.ForeColor = SystemColors.WindowText;
		ComboBox obj = cmbIModels;
		Point location = new Point(112, 168);
		((Control)obj).Location = location;
		((Control)cmbIModels).Name = "cmbIModels";
		((Control)cmbIModels).RightToLeft = (RightToLeft)0;
		ComboBox obj2 = cmbIModels;
		Size size = new Size(481, 22);
		((Control)obj2).Size = size;
		((Control)cmbIModels).TabIndex = 7;
		cmbDModels.BackColor = SystemColors.Window;
		((Control)cmbDModels).Cursor = Cursors.Default;
		cmbDModels.DropDownStyle = (ComboBoxStyle)2;
		((Control)cmbDModels).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		cmbDModels.ForeColor = SystemColors.WindowText;
		ComboBox obj3 = cmbDModels;
		location = new Point(112, 136);
		((Control)obj3).Location = location;
		((Control)cmbDModels).Name = "cmbDModels";
		((Control)cmbDModels).RightToLeft = (RightToLeft)0;
		ComboBox obj4 = cmbDModels;
		size = new Size(481, 22);
		((Control)obj4).Size = size;
		((Control)cmbDModels).TabIndex = 6;
		((ButtonBase)CancelButton_Renamed).BackColor = SystemColors.Control;
		((Control)CancelButton_Renamed).Cursor = Cursors.Default;
		CancelButton_Renamed.DialogResult = (DialogResult)2;
		((Control)CancelButton_Renamed).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)CancelButton_Renamed).ForeColor = SystemColors.ControlText;
		Button cancelButton_Renamed = CancelButton_Renamed;
		location = new Point(312, 208);
		((Control)cancelButton_Renamed).Location = location;
		((Control)CancelButton_Renamed).Name = "CancelButton_Renamed";
		((Control)CancelButton_Renamed).RightToLeft = (RightToLeft)0;
		Button cancelButton_Renamed2 = CancelButton_Renamed;
		size = new Size(81, 25);
		((Control)cancelButton_Renamed2).Size = size;
		((Control)CancelButton_Renamed).TabIndex = 1;
		((ButtonBase)CancelButton_Renamed).Text = "Cancel";
		((ButtonBase)CancelButton_Renamed).UseVisualStyleBackColor = false;
		((ButtonBase)OKButton).BackColor = SystemColors.Control;
		((Control)OKButton).Cursor = Cursors.Default;
		((Control)OKButton).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)OKButton).ForeColor = SystemColors.ControlText;
		Button oKButton = OKButton;
		location = new Point(216, 208);
		((Control)oKButton).Location = location;
		((Control)OKButton).Name = "OKButton";
		((Control)OKButton).RightToLeft = (RightToLeft)0;
		Button oKButton2 = OKButton;
		size = new Size(81, 25);
		((Control)oKButton2).Size = size;
		((Control)OKButton).TabIndex = 0;
		((ButtonBase)OKButton).Text = "OK";
		((ButtonBase)OKButton).UseVisualStyleBackColor = false;
		((Control)_Label1_1).BackColor = SystemColors.Control;
		((Control)_Label1_1).Cursor = Cursors.Default;
		((Control)_Label1_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_1).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_1, (short)1);
		Label label1_ = _Label1_1;
		location = new Point(8, 168);
		((Control)label1_).Location = location;
		((Control)_Label1_1).Name = "_Label1_1";
		((Control)_Label1_1).RightToLeft = (RightToLeft)0;
		Label label1_2 = _Label1_1;
		size = new Size(97, 17);
		((Control)label1_2).Size = size;
		((Control)_Label1_1).TabIndex = 5;
		_Label1_1.Text = "Inhalation Model:";
		_Label1_1.TextAlign = (ContentAlignment)4;
		((Control)lblAct).BackColor = SystemColors.Control;
		((Control)lblAct).Cursor = Cursors.Default;
		((Control)lblAct).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)lblAct).ForeColor = SystemColors.ControlText;
		Label obj5 = lblAct;
		location = new Point(8, 8);
		((Control)obj5).Location = location;
		((Control)lblAct).Name = "lblAct";
		((Control)lblAct).RightToLeft = (RightToLeft)0;
		Label obj6 = lblAct;
		size = new Size(729, 17);
		((Control)obj6).Size = size;
		((Control)lblAct).TabIndex = 4;
		lblAct.Text = "x";
		((Control)lblInstructions).BackColor = SystemColors.Control;
		((Control)lblInstructions).Cursor = Cursors.Default;
		((Control)lblInstructions).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblInstructions).ForeColor = SystemColors.ControlText;
		Label obj7 = lblInstructions;
		location = new Point(8, 40);
		((Control)obj7).Location = location;
		((Control)lblInstructions).Name = "lblInstructions";
		((Control)lblInstructions).RightToLeft = (RightToLeft)0;
		Label obj8 = lblInstructions;
		size = new Size(593, 81);
		((Control)obj8).Size = size;
		((Control)lblInstructions).TabIndex = 3;
		lblInstructions.Text = "x";
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
		size = new Size(97, 17);
		((Control)label1_4).Size = size;
		((Control)_Label1_0).TabIndex = 2;
		_Label1_0.Text = "Dermal Model:";
		_Label1_0.TextAlign = (ContentAlignment)4;
		((Form)this).AcceptButton = (IButtonControl)(object)OKButton;
		size = new Size(5, 13);
		((Form)this).AutoScaleBaseSize = size;
		((Form)this).BackColor = SystemColors.Control;
		((Form)this).CancelButton = (IButtonControl)(object)CancelButton_Renamed;
		size = new Size(608, 255);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)cmbIModels);
		((Control)this).Controls.Add((Control)(object)cmbDModels);
		((Control)this).Controls.Add((Control)(object)CancelButton_Renamed);
		((Control)this).Controls.Add((Control)(object)OKButton);
		((Control)this).Controls.Add((Control)(object)_Label1_1);
		((Control)this).Controls.Add((Control)(object)lblAct);
		((Control)this).Controls.Add((Control)(object)lblInstructions);
		((Control)this).Controls.Add((Control)(object)_Label1_0);
		((Control)this).Cursor = Cursors.Default;
		((Control)this).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		location = new Point(250, 175);
		((Form)this).Location = location;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmMDAddExpModel";
		((Control)this).RightToLeft = (RightToLeft)0;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)0;
		((Form)this).Text = "Add / Remove Exposure Models";
		((ISupportInitialize)Label1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public bool SetUp()
	{
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
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
					{
						Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
						Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
						Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						ProjectData.ClearProjectError();
						num2 = 2;
						LoadingControls = true;
						lblAct.Text = frmMain.DefInstance.cmbExpActs.Text;
						cmbDModels.Items.Clear();
						cmbDModels.Items.Add((object)"None Selected");
						recordset.CursorLocation = CursorLocationEnum.adUseClient;
						recordset.Open("SELECT * FROM qryListOfDExpModels", Common.MyConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
						while (!recordset.EOF)
						{
							cmbDModels.Items.Add((object)new ListBoxItem(Conversions.ToString(recordset.Fields[1].Value), Conversions.ToInteger(recordset.Fields[0].Value)));
							recordset.MoveNext();
						}
						recordset.Close();
						cmbIModels.Items.Clear();
						cmbIModels.Items.Add((object)"None Selected");
						recordset.CursorLocation = CursorLocationEnum.adUseClient;
						recordset.Open("SELECT * FROM qryListOfIExpModels", Common.MyConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
						while (!recordset.EOF)
						{
							cmbIModels.Items.Add((object)new ListBoxItem(Conversions.ToString(recordset.Fields[1].Value), Conversions.ToInteger(recordset.Fields[0].Value)));
							recordset.MoveNext();
						}
						recordset.Close();
						command.ActiveConnection = Common.MyConn;
						command.CommandText = "pqryGetInstructions";
						command.CommandType = CommandTypeEnum.adCmdStoredProc;
						command.Parameters.Append(command.CreateParameter("pID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, 7));
						Command command2 = command;
						object RecordsAffected = Missing.Value;
						object Parameters = Missing.Value;
						recordset = command2.Execute(out RecordsAffected, ref Parameters);
						command.Parameters.Delete("pID");
						lblInstructions.Text = Conversions.ToString(recordset.Fields[0].Value);
						recordset.Close();
						cmbDModels.SelectedIndex = 0;
						intOldDModel = 0;
						if (Globals_Renamed.arExpModels[0, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] > 0)
						{
							short num3 = (short)(cmbDModels.Items.Count - 1);
							short num4 = 0;
							while (true)
							{
								short num5 = num4;
								short num6 = num3;
								if (num5 > num6)
								{
									break;
								}
								if (Support.GetItemData((Control)(object)cmbDModels, unchecked((int)num4)) == Globals_Renamed.arExpModType[Globals_Renamed.arExpModels[0, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1])
								{
									cmbDModels.SelectedIndex = num4;
									intOldDModel = Globals_Renamed.arExpModType[Globals_Renamed.arExpModels[0, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1];
									break;
								}
								num4 = (short)unchecked(num4 + 1);
							}
						}
						cmbIModels.SelectedIndex = 0;
						intOldIModel = 0;
						if (Globals_Renamed.arExpModels[1, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] > 0)
						{
							short num7 = (short)(cmbIModels.Items.Count - 1);
							short num4 = 0;
							while (true)
							{
								short num8 = num4;
								short num6 = num7;
								if (num8 > num6)
								{
									break;
								}
								if (Support.GetItemData((Control)(object)cmbIModels, unchecked((int)num4)) == Globals_Renamed.arExpModType[Globals_Renamed.arExpModels[1, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1])
								{
									cmbIModels.SelectedIndex = num4;
									intOldIModel = Globals_Renamed.arExpModType[Globals_Renamed.arExpModels[1, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1];
									break;
								}
								num4 = (short)unchecked(num4 + 1);
							}
						}
						LoadingControls = false;
						recordset = null;
						command = null;
						flag = true;
						goto end_IL_0001;
					}
					case 1128:
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
				try0001_dispatch = 1128;
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

	private void CancelButton_Renamed_Click(object eventSender, EventArgs eventArgs)
	{
		((Form)this).Close();
	}

	private void OKButton_Click(object eventSender, EventArgs eventArgs)
	{
		UpdateFrmMain();
		frmMain.DefInstance.cmbExpActs_SelectedIndexChanged(frmMain.DefInstance.cmbExpActs, new EventArgs());
		Globals_Renamed.gblIWasChanged = true;
		((Form)this).Close();
	}

	private void UpdateFrmMain()
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
					{
						Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
						Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
						Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						ProjectData.ClearProjectError();
						num2 = 2;
						if (intOldDModel != Support.GetItemData((Control)(object)cmbDModels, cmbDModels.SelectedIndex))
						{
							if (Support.GetItemData((Control)(object)cmbDModels, cmbDModels.SelectedIndex) == 0)
							{
								Globals_Renamed.arExpModels[0, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] = 0;
								short num3 = 8;
								short num4;
								short num5;
								do
								{
									Globals_Renamed.arExpModEst[0, num3, Globals_Renamed.intActIndex] = 0f;
									Globals_Renamed.arExpModEst[1, num3, Globals_Renamed.intActIndex] = 0f;
									num3 = (short)unchecked(num3 + 1);
									num4 = num3;
									num5 = 11;
								}
								while (num4 <= num5);
								frmMain defInstance = frmMain.DefInstance;
								short pModel = 0;
								defInstance.LoadExpParms(ref pModel);
							}
							else if (intOldDModel == 0)
							{
								ChemStrX.addDermalModelToArrays(Support.GetItemData((Control)(object)cmbDModels, cmbDModels.SelectedIndex));
								frmMain defInstance2 = frmMain.DefInstance;
								short pModel = 0;
								defInstance2.LoadExpParms(ref pModel);
							}
							else
							{
								Globals_Renamed.intModIndex = (short)(Globals_Renamed.arExpModels[0, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1);
								short num3 = 1;
								short num8;
								short num5;
								do
								{
									short num6 = 0;
									short num7;
									do
									{
										Globals_Renamed.arExpModParmsV[num6, num3, Globals_Renamed.intModIndex] = 0f;
										Globals_Renamed.arExpModParmsT[num6, num3, Globals_Renamed.intModIndex] = 0;
										Globals_Renamed.arExpModParmsVC[num6, num3, Globals_Renamed.intModIndex] = 0;
										num6 = (short)unchecked(num6 + 1);
										num7 = num6;
										num5 = 1;
									}
									while (num7 <= num5);
									num3 = (short)unchecked(num3 + 1);
									num8 = num3;
									num5 = 162;
								}
								while (num8 <= num5);
								Globals_Renamed.arExpModType[Globals_Renamed.intModIndex] = (short)Support.GetItemData((Control)(object)cmbDModels, cmbDModels.SelectedIndex);
								command.ActiveConnection = Common.MyConn;
								command.CommandText = "pqryGetRelModel";
								command.CommandType = CommandTypeEnum.adCmdStoredProc;
								command.Parameters.Append(command.CreateParameter("pRelModID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, Support.GetItemData((Control)(object)cmbDModels, cmbDModels.SelectedIndex)));
								Command command2 = command;
								object RecordsAffected = Missing.Value;
								object Parameters = Missing.Value;
								recordset = command2.Execute(out RecordsAffected, ref Parameters);
								command.Parameters.Delete("pRelModID");
								Globals_Renamed.arExpModChmSt[Globals_Renamed.intModIndex] = (short)ChemStrX.SetChemStateID(ref Globals_Renamed.arExpModType[Globals_Renamed.intModIndex], Conversions.ToInteger(recordset.Fields["ChemStateID"].Value));
								Globals_Renamed.arExpModUncertainty[Globals_Renamed.intModIndex] = 0;
								Globals_Renamed.arExpModStatus[Globals_Renamed.intModIndex] = 0;
								Globals_Renamed.arExpModOutputOn[0, Globals_Renamed.intModIndex] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["OutputOn1"].Value)));
								Globals_Renamed.arExpModOutputOn[1, Globals_Renamed.intModIndex] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["OutputOn2"].Value)));
								Globals_Renamed.arExpModChar[0, Globals_Renamed.intModIndex] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["Char1"].Value));
								Globals_Renamed.arExpModChar[1, Globals_Renamed.intModIndex] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["Char2"].Value));
								Globals_Renamed.arExpModBasis[Globals_Renamed.intModIndex] = Conversions.ToString(recordset.Fields["Basis"].Value);
								recordset.Close();
								short num9 = 0;
								short num10;
								do
								{
									if (Operators.CompareString(Globals_Renamed.arExpModChar[num9, Globals_Renamed.intModIndex], "Output", false) == 0)
									{
										Globals_Renamed.arExpModChar[num9, Globals_Renamed.intModIndex] = "Output " + Conversions.ToString(num9 + 1);
									}
									num9 = (short)unchecked(num9 + 1);
									num10 = num9;
									num5 = 1;
								}
								while (num10 <= num5);
								ref short pActID = ref Globals_Renamed.arSelActType[Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex];
								short pModel = (short)Support.GetItemData((Control)(object)cmbDModels, cmbDModels.SelectedIndex);
								ChemStrX.PopParmsArraysD(ref pActID, ref pModel);
								frmMain defInstance3 = frmMain.DefInstance;
								pModel = 0;
								defInstance3.LoadExpParms(ref pModel);
							}
						}
						if (intOldIModel != Support.GetItemData((Control)(object)cmbIModels, cmbIModels.SelectedIndex))
						{
							object Parameters;
							if (Support.GetItemData((Control)(object)cmbIModels, cmbIModels.SelectedIndex) == 0)
							{
								Globals_Renamed.arExpModels[1, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] = 0;
								if (Globals_Renamed.intModIndex > -1)
								{
									short num3 = 4;
									short num11;
									short num5;
									do
									{
										Globals_Renamed.arExpModEst[0, num3, Globals_Renamed.intModIndex] = 0f;
										Globals_Renamed.arExpModEst[1, num3, Globals_Renamed.intModIndex] = 0f;
										num3 = (short)unchecked(num3 + 1);
										num11 = num3;
										num5 = 7;
									}
									while (num11 <= num5);
								}
								frmMain defInstance4 = frmMain.DefInstance;
								short pModel = 1;
								defInstance4.LoadExpParms(ref pModel);
							}
							else if (intOldIModel == 0)
							{
								ChemStrX.addInhalationModelToArrays(Support.GetItemData((Control)(object)cmbIModels, cmbIModels.SelectedIndex));
								frmMain defInstance5 = frmMain.DefInstance;
								short pModel = 1;
								defInstance5.LoadExpParms(ref pModel);
							}
							else
							{
								Globals_Renamed.intModIndex = (short)(Globals_Renamed.arExpModels[1, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1);
								short num6 = 0;
								short num13;
								short num3;
								short num5;
								do
								{
									num3 = 1;
									short num12;
									do
									{
										Globals_Renamed.arExpModParmsV[num6, num3, Globals_Renamed.intModIndex] = 0f;
										Globals_Renamed.arExpModParmsT[num6, num3, Globals_Renamed.intModIndex] = 0;
										Globals_Renamed.arExpModParmsVC[num6, num3, Globals_Renamed.intModIndex] = 0;
										num3 = (short)unchecked(num3 + 1);
										num12 = num3;
										num5 = 162;
									}
									while (num12 <= num5);
									num6 = (short)unchecked(num6 + 1);
									num13 = num6;
									num5 = 1;
								}
								while (num13 <= num5);
								num3 = 0;
								short num14;
								do
								{
									Globals_Renamed.arExpModInhRC[num3, Globals_Renamed.intModIndex] = "";
									num3 = (short)unchecked(num3 + 1);
									num14 = num3;
									num5 = 4;
								}
								while (num14 <= num5);
								Globals_Renamed.arExpModType[Globals_Renamed.intModIndex] = (short)Support.GetItemData((Control)(object)cmbIModels, cmbIModels.SelectedIndex);
								command.ActiveConnection = Common.MyConn;
								command.CommandText = "pqryGetRelModel";
								command.CommandType = CommandTypeEnum.adCmdStoredProc;
								command.Parameters.Append(command.CreateParameter("pRelModID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, Support.GetItemData((Control)(object)cmbIModels, cmbIModels.SelectedIndex)));
								Command command3 = command;
								Parameters = Missing.Value;
								object RecordsAffected = Missing.Value;
								recordset = command3.Execute(out Parameters, ref RecordsAffected);
								command.Parameters.Delete("pRelModID");
								Globals_Renamed.arExpModChmSt[Globals_Renamed.intModIndex] = (short)ChemStrX.SetChemStateID(ref Globals_Renamed.arExpModType[Globals_Renamed.intModIndex], Conversions.ToInteger(recordset.Fields["ChemStateID"].Value));
								Globals_Renamed.arExpModUncertainty[Globals_Renamed.intModIndex] = 1;
								Globals_Renamed.arExpModStatus[Globals_Renamed.intModIndex] = 0;
								Globals_Renamed.arExpModOutputOn[0, Globals_Renamed.intModIndex] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["OutputOn1"].Value)));
								Globals_Renamed.arExpModOutputOn[1, Globals_Renamed.intModIndex] = Conversions.ToShort(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset.Fields["OutputOn2"].Value)));
								Globals_Renamed.arExpModChar[0, Globals_Renamed.intModIndex] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["Char1"].Value));
								Globals_Renamed.arExpModChar[1, Globals_Renamed.intModIndex] = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields["Char2"].Value));
								Globals_Renamed.arExpModBasis[Globals_Renamed.intModIndex] = Conversions.ToString(recordset.Fields["Basis"].Value);
								recordset.Close();
								short num9 = 0;
								short num15;
								do
								{
									if (Operators.CompareString(Globals_Renamed.arExpModChar[num9, Globals_Renamed.intModIndex], "Output", false) == 0)
									{
										Globals_Renamed.arExpModChar[num9, Globals_Renamed.intModIndex] = "Output " + Conversions.ToString(num9 + 1);
									}
									num9 = (short)unchecked(num9 + 1);
									num15 = num9;
									num5 = 1;
								}
								while (num15 <= num5);
								ref short pActID2 = ref Globals_Renamed.arSelActType[Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex];
								short pModel = (short)Support.GetItemData((Control)(object)cmbIModels, cmbIModels.SelectedIndex);
								ChemStrX.PopParmsArraysD(ref pActID2, ref pModel);
								frmMain defInstance6 = frmMain.DefInstance;
								pModel = 1;
								defInstance6.LoadExpParms(ref pModel);
							}
							Parameters = Globals_Renamed.intOpIndex;
							ChemStrX.resetInhRespClass(ref Parameters);
							Globals_Renamed.intOpIndex = Conversions.ToShort(Parameters);
						}
						recordset = null;
						command = null;
						goto end_IL_0001;
					}
					case 2314:
						num = -1;
						switch (num2)
						{
						case 2:
						{
							string Eobject = ((Control)this).Name;
							string Efunction = "UpdateFrmMain";
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
				try0001_dispatch = 2314;
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
