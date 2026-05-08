using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB;

[ComImport]
[DefaultMember("Description")]
[CompilerGenerated]
[Guid("00000500-0000-0010-8000-00AA006D2EA4")]
[TypeIdentifier]
public interface Error
{
	void _VtblGap1_2();

	[DispId(0)]
	string Description
	{
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}
}
