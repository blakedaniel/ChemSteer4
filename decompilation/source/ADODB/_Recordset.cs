using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB;

[ComImport]
[CompilerGenerated]
[TypeIdentifier]
[Guid("00000556-0000-0010-8000-00AA006D2EA4")]
[DefaultMember("Fields")]
public interface _Recordset : Recordset21
{
	void _VtblGap1_1();

	[DispId(1000)]
	PositionEnum AbsolutePosition
	{
		[DispId(1000)]
		get;
		[DispId(1000)]
		[param: In]
		set;
	}

	void _VtblGap2_10();

	[DispId(1006)]
	bool EOF
	{
		[DispId(1006)]
		get;
	}

	[DispId(0)]
	new Fields Fields
	{
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "ADODB.FieldsToInternalFieldsMarshaler")]
		get;
	}

	void _VtblGap3_4();

	[DispId(1010)]
	int RecordCount
	{
		[DispId(1010)]
		get;
	}

	void _VtblGap4_3();

	[DispId(1012)]
	void AddNew([Optional][In][MarshalAs(UnmanagedType.Struct)] object FieldList, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Values);

	void _VtblGap5_1();

	[DispId(1014)]
	void Close();

	[DispId(1015)]
	void Delete([In] AffectEnum AffectRecords = AffectEnum.adAffectCurrent);

	void _VtblGap6_2();

	[DispId(1018)]
	void MoveNext();

	void _VtblGap7_1();

	[DispId(1020)]
	void MoveFirst();

	[DispId(1021)]
	void MoveLast();

	[DispId(1022)]
	void Open([Optional][In][MarshalAs(UnmanagedType.Struct)] object Source, [Optional][In][MarshalAs(UnmanagedType.Struct)] object ActiveConnection, [In] CursorTypeEnum CursorType = CursorTypeEnum.adOpenUnspecified, [In] LockTypeEnum LockType = LockTypeEnum.adLockUnspecified, [In] int Options = -1);

	void _VtblGap8_2();

	[DispId(1025)]
	void Update([Optional][In][MarshalAs(UnmanagedType.Struct)] object Fields, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Values);

	void _VtblGap9_3();

	[DispId(1030)]
	object Filter
	{
		[DispId(1030)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
		[DispId(1030)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
	}

	void _VtblGap10_3();

	[DispId(1031)]
	string Sort
	{
		[DispId(1031)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[DispId(1031)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	void _VtblGap11_5();

	[DispId(1051)]
	CursorLocationEnum CursorLocation
	{
		[DispId(1051)]
		get;
		[DispId(1051)]
		[param: In]
		set;
	}

	void _VtblGap12_6();

	[DispId(1058)]
	void Find([In][MarshalAs(UnmanagedType.BStr)] string Criteria, [In] int SkipRecords = 0, [In] SearchDirectionEnum SearchDirection = SearchDirectionEnum.adSearchForward, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Start);
}
