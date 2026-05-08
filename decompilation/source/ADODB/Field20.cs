using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB;

[ComImport]
[Guid("0000054C-0000-0010-8000-00AA006D2EA4")]
[DefaultMember("Value")]
[CompilerGenerated]
[TypeIdentifier]
public interface Field20 : _ADO
{
	void _VtblGap1_6();

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
