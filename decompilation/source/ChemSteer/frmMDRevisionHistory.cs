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
using Microsoft.VisualBasic.CompilerServices;

namespace ChemSteer;

internal class frmMDRevisionHistory : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("cmdOK")]
	private Button _cmdOK;

	[AccessedThroughProperty("dgvRevisions")]
	private DataGridView _dgvRevisions;

	[AccessedThroughProperty("SavedOn")]
	private DataGridViewTextBoxColumn _SavedOn;

	[AccessedThroughProperty("EPAIDNumber")]
	private DataGridViewTextBoxColumn _EPAIDNumber;

	[AccessedThroughProperty("CBI")]
	private DataGridViewTextBoxColumn _CBI;

	[AccessedThroughProperty("MyType")]
	private DataGridViewTextBoxColumn _MyType;

	[AccessedThroughProperty("MyStatus")]
	private DataGridViewTextBoxColumn _MyStatus;

	[AccessedThroughProperty("FiscalYear")]
	private DataGridViewTextBoxColumn _FiscalYear;

	[AccessedThroughProperty("lblInstructions")]
	private Label _lblInstructions;

	private static frmMDRevisionHistory m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	public virtual Button cmdOK
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdOK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdOk_Click;
			if (_cmdOK != null)
			{
				((Control)_cmdOK).Click -= eventHandler;
			}
			_cmdOK = value;
			if (_cmdOK != null)
			{
				((Control)_cmdOK).Click += eventHandler;
			}
		}
	}

	internal virtual DataGridView dgvRevisions
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvRevisions;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvRevisions = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn SavedOn
	{
		[DebuggerNonUserCode]
		get
		{
			return _SavedOn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SavedOn = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn EPAIDNumber
	{
		[DebuggerNonUserCode]
		get
		{
			return _EPAIDNumber;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_EPAIDNumber = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn CBI
	{
		[DebuggerNonUserCode]
		get
		{
			return _CBI;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CBI = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn MyType
	{
		[DebuggerNonUserCode]
		get
		{
			return _MyType;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_MyType = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn MyStatus
	{
		[DebuggerNonUserCode]
		get
		{
			return _MyStatus;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_MyStatus = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn FiscalYear
	{
		[DebuggerNonUserCode]
		get
		{
			return _FiscalYear;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_FiscalYear = value;
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

	public static frmMDRevisionHistory DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmMDRevisionHistory();
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

	public frmMDRevisionHistory()
	{
		((Form)this).Load += frmMDRevisionHistory_Load;
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
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_0472: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Expected O, but got Unknown
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMDRevisionHistory));
		cmdOK = new Button();
		lblInstructions = new Label();
		dgvRevisions = new DataGridView();
		SavedOn = new DataGridViewTextBoxColumn();
		EPAIDNumber = new DataGridViewTextBoxColumn();
		CBI = new DataGridViewTextBoxColumn();
		MyType = new DataGridViewTextBoxColumn();
		MyStatus = new DataGridViewTextBoxColumn();
		FiscalYear = new DataGridViewTextBoxColumn();
		((ISupportInitialize)dgvRevisions).BeginInit();
		((Control)this).SuspendLayout();
		((ButtonBase)cmdOK).BackColor = SystemColors.Control;
		((Control)cmdOK).Cursor = Cursors.Default;
		((Control)cmdOK).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdOK).ForeColor = SystemColors.ControlText;
		Button obj = cmdOK;
		Point location = new Point(312, 424);
		((Control)obj).Location = location;
		((Control)cmdOK).Name = "cmdOK";
		((Control)cmdOK).RightToLeft = (RightToLeft)0;
		Button obj2 = cmdOK;
		Size size = new Size(81, 25);
		((Control)obj2).Size = size;
		((Control)cmdOK).TabIndex = 0;
		((ButtonBase)cmdOK).Text = "&Close";
		((ButtonBase)cmdOK).UseVisualStyleBackColor = false;
		((Control)lblInstructions).BackColor = SystemColors.Control;
		((Control)lblInstructions).Cursor = Cursors.Default;
		((Control)lblInstructions).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblInstructions).ForeColor = SystemColors.ControlText;
		Label obj3 = lblInstructions;
		location = new Point(8, 8);
		((Control)obj3).Location = location;
		((Control)lblInstructions).Name = "lblInstructions";
		((Control)lblInstructions).RightToLeft = (RightToLeft)0;
		Label obj4 = lblInstructions;
		size = new Size(681, 25);
		((Control)obj4).Size = size;
		((Control)lblInstructions).TabIndex = 1;
		lblInstructions.Text = "The table below contains one entry for each time the assessment was saved. This infomation is only read-only data. ";
		dgvRevisions.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		dgvRevisions.Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[6]
		{
			(DataGridViewColumn)SavedOn,
			(DataGridViewColumn)EPAIDNumber,
			(DataGridViewColumn)CBI,
			(DataGridViewColumn)MyType,
			(DataGridViewColumn)MyStatus,
			(DataGridViewColumn)FiscalYear
		});
		DataGridView obj5 = dgvRevisions;
		location = new Point(12, 36);
		((Control)obj5).Location = location;
		((Control)dgvRevisions).Name = "dgvRevisions";
		DataGridView obj6 = dgvRevisions;
		size = new Size(635, 348);
		((Control)obj6).Size = size;
		((Control)dgvRevisions).TabIndex = 3;
		((DataGridViewColumn)SavedOn).HeaderText = "Saved On";
		((DataGridViewColumn)SavedOn).Name = "SavedOn";
		((DataGridViewColumn)SavedOn).ReadOnly = true;
		((DataGridViewColumn)EPAIDNumber).HeaderText = "EPA ID";
		((DataGridViewColumn)EPAIDNumber).Name = "EPAIDNumber";
		((DataGridViewColumn)EPAIDNumber).ReadOnly = true;
		((DataGridViewColumn)CBI).HeaderText = "CBI";
		((DataGridViewColumn)CBI).Name = "CBI";
		((DataGridViewColumn)CBI).ReadOnly = true;
		((DataGridViewColumn)MyType).HeaderText = "Type";
		((DataGridViewColumn)MyType).Name = "MyType";
		((DataGridViewColumn)MyType).ReadOnly = true;
		((DataGridViewColumn)MyStatus).HeaderText = "Status";
		((DataGridViewColumn)MyStatus).Name = "MyStatus";
		((DataGridViewColumn)MyStatus).ReadOnly = true;
		((DataGridViewColumn)FiscalYear).HeaderText = "Fiscal Year";
		((DataGridViewColumn)FiscalYear).Name = "FiscalYear";
		((DataGridViewColumn)FiscalYear).ReadOnly = true;
		size = new Size(5, 13);
		((Form)this).AutoScaleBaseSize = size;
		size = new Size(703, 465);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)dgvRevisions);
		((Control)this).Controls.Add((Control)(object)cmdOK);
		((Control)this).Controls.Add((Control)(object)lblInstructions);
		((Control)this).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		location = new Point(250, 150);
		((Form)this).Location = location;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmMDRevisionHistory";
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Display Revision History of the Assessment";
		((ISupportInitialize)dgvRevisions).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public bool SetUp()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		if (Globals_Renamed.gblDataVersion == 4)
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Revision History is not available in databases created with the December 19th version of ChemSTEER.", (MsgBoxStyle)64, (object)"Invalid Request");
			bool result = default(bool);
			return result;
		}
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		clsid = new Guid("00000514-0000-0010-8000-00AA006D2EA4");
		Connection connection = (Connection)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		connection.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Globals_Renamed.gblDBName;
		connection.Open();
		string source = "SELECT * FROM qryRevisionHistory WHERE AssessID=" + Conversions.ToString((int)Globals_Renamed.gblAssessID) + " ORDER BY SavedOn DESC";
		recordset.Open(source, connection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
		if (!recordset.EOF)
		{
			recordset.MoveLast();
			recordset.MoveFirst();
		}
		dgvRevisions.Rows.Clear();
		while (!recordset.EOF)
		{
			dgvRevisions.Rows.Add(new object[6]
			{
				RuntimeHelpers.GetObjectValue(recordset.Fields["SavedOn"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["EPAIDNumber"].Value),
				RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.ConditionalCompareObjectEqual(recordset.Fields["CBI"].Value, (object)1, false), (object)"Yes", (object)"")),
				RuntimeHelpers.GetObjectValue(recordset.Fields["MyType"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["MyStatus"].Value),
				RuntimeHelpers.GetObjectValue(recordset.Fields["FiscalYear"].Value)
			});
			recordset.MoveNext();
		}
		recordset.Close();
		recordset = null;
		return true;
	}

	private void frmMDRevisionHistory_Load(object eventSender, EventArgs eventArgs)
	{
	}

	private void cmdOk_Click(object eventSender, EventArgs eventArgs)
	{
		((Form)this).Close();
	}
}
