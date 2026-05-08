using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB;

[ComImport]
[CompilerGenerated]
[TypeIdentifier]
[Guid("0000050D-0000-0010-8000-00AA006D2EA4")]
public interface Parameters : _DynaCollection
{
	void _VtblGap1_3();

	[DispId(1610809344)]
	void Append([In][MarshalAs(UnmanagedType.IDispatch)] object Object);

	[DispId(1610809345)]
	void Delete([In][MarshalAs(UnmanagedType.Struct)] object Index);

	[DispId(0)]
	Parameter this[[In][MarshalAs(UnmanagedType.Struct)] object Index]
	{
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}
}
