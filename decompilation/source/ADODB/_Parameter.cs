using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB;

[ComImport]
[CompilerGenerated]
[TypeIdentifier]
[DefaultMember("Value")]
[Guid("0000050C-0000-0010-8000-00AA006D2EA4")]
public interface _Parameter : _ADO
{
	void _VtblGap1_3();

	[DispId(0)]
	object Value
	{
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
		[DispId(0)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
	}
}
