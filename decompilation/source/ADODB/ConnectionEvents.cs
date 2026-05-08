using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB;

[ComImport]
[TypeIdentifier]
[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
[DefaultMember("InfoMessage")]
[Guid("00000400-0000-0010-8000-00AA006D2EA4")]
[CompilerGenerated]
public interface ConnectionEvents
{
	[PreserveSig]
	[DispId(0)]
	void InfoMessage([In][MarshalAs(UnmanagedType.Interface)] Error pError, [In][Out] ref EventStatusEnum adStatus, [In][MarshalAs(UnmanagedType.Interface)] Connection pConnection);
}
