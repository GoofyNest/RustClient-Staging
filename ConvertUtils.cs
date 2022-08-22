internal static class ConvertUtils // TypeDefIndex: 5943
{	// Fields
	private static readonly Dictionary<Type, PrimitiveTypeCode> TypeCodeMap; // 0x0
	private static readonly TypeInformation[] PrimitiveTypeCodes; // 0x8
	private static readonly ThreadSafeStore<ConvertUtils.TypeConvertKey, Func<object, object>> CastConverters; // 0x10

	// Methods

	// RVA: 0x17FFB60 Offset: 0x17FE160 VA: 0x1817FFB60
	public static PrimitiveTypeCode GetTypeCode(Type t) { }

	// RVA: 0x17FFBC0 Offset: 0x17FE1C0 VA: 0x1817FFBC0
	public static PrimitiveTypeCode GetTypeCode(Type t, out bool isEnum) { }

	// RVA: 0x17FFE60 Offset: 0x17FE460 VA: 0x1817FFE60
	public static TypeInformation GetTypeInformation(IConvertible convertable) { }

	// RVA: 0x1800430 Offset: 0x17FEA30 VA: 0x181800430
	public static bool IsConvertible(Type t) { }

	// RVA: 0x18005E0 Offset: 0x17FEBE0 VA: 0x1818005E0
	public static TimeSpan ParseTimeSpan(string input) { }

	// RVA: 0x17FF5D0 Offset: 0x17FDBD0 VA: 0x1817FF5D0
	private static Func<object, object> CreateCastConverter(ConvertUtils.TypeConvertKey t) { }

	// RVA: 0x1801140 Offset: 0x17FF740 VA: 0x181801140
	private static bool TryConvert(object initialValue, CultureInfo culture, Type targetType, out object value) { }

	// RVA: 0x1800780 Offset: 0x17FED80 VA: 0x181800780
	private static ConvertUtils.ConvertResult TryConvertInternal(object initialValue, CultureInfo culture, Type targetType, out object value) { }

	// RVA: 0x17FF460 Offset: 0x17FDA60 VA: 0x1817FF460
	public static object ConvertOrCast(object initialValue, CultureInfo culture, Type targetType) { }

	// RVA: 0x17FF810 Offset: 0x17FDE10 VA: 0x1817FF810
	private static object EnsureTypeAssignable(object value, Type initialType, Type targetType) { }

	// RVA: 0x17FFAD0 Offset: 0x17FE0D0 VA: 0x1817FFAD0
	internal static TypeConverter GetConverter(Type t) { }

	// RVA: 0x1801210 Offset: 0x17FF810 VA: 0x181801210
	public static bool VersionTryParse(string input, out Version result) { }

	// RVA: 0x18004C0 Offset: 0x17FEAC0 VA: 0x1818004C0
	public static bool IsInteger(object value) { }

	// RVA: 0x18000C0 Offset: 0x17FE6C0 VA: 0x1818000C0
	public static ParseResult Int32TryParse(char[] chars, int start, int length, out int value) { }

	// RVA: 0x1800290 Offset: 0x17FE890 VA: 0x181800290
	public static ParseResult Int64TryParse(char[] chars, int start, int length, out long value) { }

	// RVA: 0x1800640 Offset: 0x17FEC40 VA: 0x181800640
	public static bool TryConvertGuid(string s, out Guid g) { }

	// RVA: 0x17FFFE0 Offset: 0x17FE5E0 VA: 0x1817FFFE0
	public static int HexTextToInt(char[] text, int start, int end) { }

	// RVA: 0x17FFF10 Offset: 0x17FE510 VA: 0x1817FFF10
	private static int HexCharToInt(char ch) { }

	// RVA: 0x18012B0 Offset: 0x17FF8B0 VA: 0x1818012B0
	private static void .cctor() { }

}

internal struct ConvertUtils.TypeConvertKey // TypeDefIndex: 5944
{	// Fields
	private readonly Type _initialType; // 0x0
	private readonly Type _targetType; // 0x8

	// Properties
	public Type InitialType { get; }
	public Type TargetType { get; }

	// Methods

	// RVA: 0xFC840 Offset: 0xFBC40 VA: 0x1800FC840
	public Type get_InitialType() { }

	// RVA: 0xF3EC0 Offset: 0xF32C0 VA: 0x1800F3EC0
	public Type get_TargetType() { }

	// RVA: 0xF5A50 Offset: 0xF4E50 VA: 0x1800F5A50
	public void .ctor(Type initialType, Type targetType) { }

	// RVA: 0xF59F0 Offset: 0xF4DF0 VA: 0x1800F59F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x211E70 Offset: 0x211270 VA: 0x180211E70 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x211620 Offset: 0x210A20 VA: 0x180211620
	public bool Equals(ConvertUtils.TypeConvertKey other) { }

}

internal enum ConvertUtils.ConvertResult // TypeDefIndex: 5945
{	// Fields
	public int value__; // 0x0
	public const ConvertUtils.ConvertResult Success = 0;
	public const ConvertUtils.ConvertResult CannotConvertNull = 1;
	public const ConvertUtils.ConvertResult NotInstantiableType = 2;
	public const ConvertUtils.ConvertResult NoValidConversion = 3;

}

private sealed class ConvertUtils.<>c__DisplayClass9_0 // TypeDefIndex: 5946
{	// Fields
	public MethodCall<object, object> call; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1815780 Offset: 0x1813D80 VA: 0x181815780
	internal object <CreateCastConverter>b__0(object o) { }

}

