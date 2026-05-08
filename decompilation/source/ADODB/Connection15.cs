using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB;

[ComImport]
[Guid("00000515-0000-0010-8000-00AA006D2EA4")]
[DefaultMember("ConnectionString")]
[TypeIdentifier]
[CompilerGenerated]
public interface Connection15 : _ADO
{
	void _VtblGap1_1();

	[DispId(0)]
	string ConnectionString
	{
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[DispId(0)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}
}
