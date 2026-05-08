using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CrystalDecisions.CrystalReports.Engine;

namespace ChemSteer;

public class FullIRER : ReportClass
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	public override string ResourceName
	{
		get
		{
			return "FullIRER.rpt";
		}
		set
		{
		}
	}

	public override bool NewGenerator
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	public override string FullResourceName
	{
		get
		{
			return "ChemSteer.FullIRER.rpt";
		}
		set
		{
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Section ReportHeaderSection1 => ((ReportDocument)this).ReportDefinition.Sections[0];

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Section PageHeaderSection1 => ((ReportDocument)this).ReportDefinition.Sections[1];

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Section DetailSection1 => ((ReportDocument)this).ReportDefinition.Sections[2];

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Section DetailSection23 => ((ReportDocument)this).ReportDefinition.Sections[3];

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Section DetailSection17 => ((ReportDocument)this).ReportDefinition.Sections[4];

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Section DetailSection28 => ((ReportDocument)this).ReportDefinition.Sections[5];

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Section DetailSection20 => ((ReportDocument)this).ReportDefinition.Sections[6];

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Section DetailSection22 => ((ReportDocument)this).ReportDefinition.Sections[7];

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Section DetailSection2 => ((ReportDocument)this).ReportDefinition.Sections[8];

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Section DetailSection3 => ((ReportDocument)this).ReportDefinition.Sections[9];

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Section DetailSection4 => ((ReportDocument)this).ReportDefinition.Sections[10];

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Section DetailSection21 => ((ReportDocument)this).ReportDefinition.Sections[11];

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Section DetailSection5 => ((ReportDocument)this).ReportDefinition.Sections[12];

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Section DetailSection7 => ((ReportDocument)this).ReportDefinition.Sections[13];

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Section DetailSection8 => ((ReportDocument)this).ReportDefinition.Sections[14];

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Section DetailSection32 => ((ReportDocument)this).ReportDefinition.Sections[15];

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Section DetailSection31 => ((ReportDocument)this).ReportDefinition.Sections[16];

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Section DetailSection33 => ((ReportDocument)this).ReportDefinition.Sections[17];

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Section DetailSection6 => ((ReportDocument)this).ReportDefinition.Sections[18];

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Section DetailSection19 => ((ReportDocument)this).ReportDefinition.Sections[19];

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Section DetailSection9 => ((ReportDocument)this).ReportDefinition.Sections[20];

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Section DetailSection10 => ((ReportDocument)this).ReportDefinition.Sections[21];

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Section DetailSection30 => ((ReportDocument)this).ReportDefinition.Sections[22];

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Section DetailSection18 => ((ReportDocument)this).ReportDefinition.Sections[23];

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Section DetailSection11 => ((ReportDocument)this).ReportDefinition.Sections[24];

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Section DetailSection37 => ((ReportDocument)this).ReportDefinition.Sections[25];

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Section DetailSection12 => ((ReportDocument)this).ReportDefinition.Sections[26];

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Section DetailSection13 => ((ReportDocument)this).ReportDefinition.Sections[27];

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Section DetailSection27 => ((ReportDocument)this).ReportDefinition.Sections[28];

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Section DetailSection24 => ((ReportDocument)this).ReportDefinition.Sections[29];

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Section DetailSection29 => ((ReportDocument)this).ReportDefinition.Sections[30];

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Section DetailSection14 => ((ReportDocument)this).ReportDefinition.Sections[31];

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Section DetailSection16 => ((ReportDocument)this).ReportDefinition.Sections[32];

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Section DetailSection36 => ((ReportDocument)this).ReportDefinition.Sections[33];

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Section DetailSection25 => ((ReportDocument)this).ReportDefinition.Sections[34];

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Section DetailSection35 => ((ReportDocument)this).ReportDefinition.Sections[35];

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Section DetailSection34 => ((ReportDocument)this).ReportDefinition.Sections[36];

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Section DetailSection38 => ((ReportDocument)this).ReportDefinition.Sections[37];

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Section DetailSection15 => ((ReportDocument)this).ReportDefinition.Sections[38];

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Section ReportFooterSection1 => ((ReportDocument)this).ReportDefinition.Sections[39];

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Section PageFooterSection1 => ((ReportDocument)this).ReportDefinition.Sections[40];

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

	public FullIRER()
	{
		__ENCAddToList(this);
	}
}
