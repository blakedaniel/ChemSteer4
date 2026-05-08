using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB;

[ComImport]
[TypeIdentifier]
[Guid("0000054F-0000-0010-8000-00AA006D2EA4")]
[DefaultMember("Fields")]
[CompilerGenerated]
public interface Recordset20 : Recordset15
{
	new void _VtblGap1_14();

	[DispId(0)]
	new Fields Fields
	{
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "ADODB.FieldsToInternalFieldsMarshaler")]
		get;
	}
}
