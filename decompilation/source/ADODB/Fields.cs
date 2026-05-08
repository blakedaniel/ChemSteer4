using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB;

[ComImport]
[CompilerGenerated]
[Guid("00000564-0000-0010-8000-00AA006D2EA4")]
[TypeIdentifier]
public interface Fields : Fields20
{
	[DispId(1)]
	int Count
	{
		[DispId(1)]
		get;
	}

	void _VtblGap1_2();

	[DispId(0)]
	new Field this[[In][MarshalAs(UnmanagedType.Struct)] object Index]
	{
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}
}
