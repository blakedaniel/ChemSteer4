using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB;

[ComImport]
[DefaultMember("ConnectionString")]
[TypeIdentifier]
[CompilerGenerated]
[Guid("00000550-0000-0010-8000-00AA006D2EA4")]
public interface _Connection : Connection15
{
	new void _VtblGap1_1();

	[DispId(0)]
	new string ConnectionString
	{
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[DispId(0)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	void _VtblGap2_5();

	[DispId(5)]
	void Close();

	void _VtblGap3_4();

	[DispId(10)]
	void Open([In][MarshalAs(UnmanagedType.BStr)] string ConnectionString = "", [In][MarshalAs(UnmanagedType.BStr)] string UserID = "", [In][MarshalAs(UnmanagedType.BStr)] string Password = "", [In] int Options = -1);

	void _VtblGap4_13();

	[DispId(18)]
	int State
	{
		[DispId(18)]
		get;
	}
}
