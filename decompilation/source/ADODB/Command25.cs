using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB;

[ComImport]
[TypeIdentifier]
[DefaultMember("Parameters")]
[CompilerGenerated]
[Guid("0000054E-0000-0010-8000-00AA006D2EA4")]
public interface Command25 : Command15
{
	new void _VtblGap1_12();

	[DispId(0)]
	new Parameters Parameters
	{
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "ADODB.ParametersToInternalParametersMarshaler")]
		get;
	}
}
