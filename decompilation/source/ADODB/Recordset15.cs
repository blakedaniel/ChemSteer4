using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB;

[ComImport]
[CompilerGenerated]
[TypeIdentifier]
[DefaultMember("Fields")]
[Guid("0000050E-0000-0010-8000-00AA006D2EA4")]
public interface Recordset15 : _ADO
{
	void _VtblGap1_14();

	[DispId(0)]
	Fields Fields
	{
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "ADODB.FieldsToInternalFieldsMarshaler")]
		get;
	}
}
