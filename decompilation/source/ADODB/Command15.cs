using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB;

[ComImport]
[DefaultMember("Parameters")]
[CompilerGenerated]
[Guid("00000508-0000-0010-8000-00AA006D2EA4")]
[TypeIdentifier]
public interface Command15 : _ADO
{
	void _VtblGap1_12();

	[DispId(0)]
	Parameters Parameters
	{
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "ADODB.ParametersToInternalParametersMarshaler")]
		get;
	}
}
