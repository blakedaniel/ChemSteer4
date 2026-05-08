using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB;

[ComImport]
[Guid("00000569-0000-0010-8000-00AA006D2EA4")]
[TypeIdentifier]
[DefaultMember("Value")]
[CompilerGenerated]
public interface Field : Field20
{
	void _VtblGap1_4();

	[DispId(1100)]
	string Name
	{
		[DispId(1100)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(1102)]
	DataTypeEnum Type
	{
		[DispId(1102)]
		get;
		[DispId(1102)]
		[param: In]
		set;
	}

	[DispId(0)]
	new object Value
	{
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
		[DispId(0)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
	}

	void _VtblGap2_10();
}
