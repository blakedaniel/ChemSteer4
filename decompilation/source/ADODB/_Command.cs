using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB;

[ComImport]
[TypeIdentifier]
[Guid("B08400BD-F9D1-4D02-B856-71D5DBA123E9")]
[DefaultMember("Parameters")]
[CompilerGenerated]
public interface _Command : Command25
{
	void _VtblGap1_1();

	[DispId(1)]
	Connection ActiveConnection
	{
		[DispId(1)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
		[DispId(1)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Interface)]
		set;
	}

	void _VtblGap2_1();

	[DispId(2)]
	string CommandText
	{
		[DispId(2)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[DispId(2)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	void _VtblGap3_4();

	[DispId(5)]
	[return: MarshalAs(UnmanagedType.Interface)]
	Recordset Execute([Optional][MarshalAs(UnmanagedType.Struct)] out object RecordsAffected, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Parameters, [In] int Options = -1);

	[DispId(6)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "ADODB.ParameterToInternalParameterMarshaler")]
	Parameter CreateParameter([In][MarshalAs(UnmanagedType.BStr)] string Name = "", [In] DataTypeEnum Type = DataTypeEnum.adEmpty, [In] ParameterDirectionEnum Direction = ParameterDirectionEnum.adParamInput, [In] int Size = 0, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Value);

	[DispId(0)]
	new Parameters Parameters
	{
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "ADODB.ParametersToInternalParametersMarshaler")]
		get;
	}

	[DispId(7)]
	CommandTypeEnum CommandType
	{
		[DispId(7)]
		get;
		[DispId(7)]
		[param: In]
		set;
	}
}
