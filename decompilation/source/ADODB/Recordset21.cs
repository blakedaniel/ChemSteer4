using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB;

[ComImport]
[Guid("00000555-0000-0010-8000-00AA006D2EA4")]
[DefaultMember("Fields")]
[TypeIdentifier]
[CompilerGenerated]
public interface Recordset21 : Recordset20
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
