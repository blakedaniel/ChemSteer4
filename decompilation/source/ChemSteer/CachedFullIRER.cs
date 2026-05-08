using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace ChemSteer;

[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
public class CachedFullIRER : Component, ICachedReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual bool IsCacheable
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual bool ShareDBLogonInfo
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual TimeSpan CacheTimeOut
	{
		get
		{
			return CachedReportConstants.DEFAULT_TIMEOUT;
		}
		set
		{
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

	public CachedFullIRER()
	{
		__ENCAddToList(this);
	}

	public virtual ReportDocument CreateReport()
	{
		FullIRER fullIRER = new FullIRER();
		((ReportDocument)fullIRER).Site = Site;
		return (ReportDocument)(object)fullIRER;
	}

	public virtual string GetCustomizedCacheKey(RequestContext request)
	{
		return null;
	}
}
