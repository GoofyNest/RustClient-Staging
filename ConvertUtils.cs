internal static class ConvertUtils // TypeDefIndex: 5943
{	// Fields
	private static readonly Dictionary<Type, PrimitiveTypeCode> TypeCodeMap; // 0x0
	private static readonly TypeInformation[] PrimitiveTypeCodes; // 0x8
	private static readonly ThreadSafeStore<ConvertUtils.TypeConvertKey, Func<object, object>> CastConverters; // 0x10

	// Methods

	// RVA: 0x17FF8A0 Offset: 0x17FDEA0 VA: 0x1817FF8A0
	public static PrimitiveTypeCode GetTypeCode(Type t) { }

	// RVA: 0x17FF900 Offset: 0x17FDF00 VA: 0x1817FF900
	public static PrimitiveTypeCode GetTypeCode(Type t, out bool isEnum) { }

	// RVA: 0x17FFBA0 Offset: 0x17FE1A0 VA: 0x1817FFBA0
	public static TypeInformation GetTypeInformation(IConvertible convertable) { }

	// RVA: 0x1800170 Offset: 0x17FE770 VA: 0x181800170
	public static bool IsConvertible(Type t) { }

	// RVA: 0x1800320 Offset: 0x17FE920 VA: 0x181800320
	public static TimeSpan ParseTimeSpan(string input) { }

	// RVA: 0x17FF310 Offset: 0x17FD910 VA: 0x1817FF310
	private static Func<object, object> CreateCastConverter(ConvertUtils.TypeConvertKey t) { }

	// RVA: 0x1800E80 Offset: 0x17FF480 VA: 0x181800E80
	private static bool TryConvert(object initialValue, CultureInfo culture, Type targetType, out object value) { }

	// RVA: 0x18004C0 Offset: 0x17FEAC0 VA: 0x1818004C0
	private static ConvertUtils.ConvertResult TryConvertInternal(object initialValue, CultureInfo culture, Type targetType, out object value) { }

	// RVA: 0x17FF1A0 Offset: 0x17FD7A0 VA: 0x1817FF1A0
	public static object ConvertOrCast(object initialValue, CultureInfo culture, Type targetType) { }

	// RVA: 0x17FF550 Offset: 0x17FDB50 VA: 0x1817FF550
	private static object EnsureTypeAssignable(object value, Type initialType, Type targetType) { }

	// RVA: 0x17FF810 Offset: 0x17FDE10 VA: 0x1817FF810
	internal static TypeConverter GetConverter(Type t) { }

	// RVA: 0x1800F50 Offset: 0x17FF550 VA: 0x181800F50
	public static bool VersionTryParse(string input, out Version result) { }

	// RVA: 0x1800200 Offset: 0x17FE800 VA: 0x181800200
	public static bool IsInteger(object value) { }

	// RVA: 0x17FFE00 Offset: 0x17FE400 VA: 0x1817FFE00
	public static ParseResult Int32TryParse(char[] chars, int start, int length, out int value) { }

	// RVA: 0x17FFFD0 Offset: 0x17FE5D0 VA: 0x1817FFFD0
	public static ParseResult Int64TryParse(char[] chars, int start, int length, out long value) { }

	// RVA: 0x1800380 Offset: 0x17FE980 VA: 0x181800380
	public static bool TryConvertGuid(string s, out Guid g) { }

	// RVA: 0x17FFD20 Offset: 0x17FE320 VA: 0x1817FFD20
	public static int HexTextToInt(char[] text, int start, int end) { }

	// RVA: 0x17FFC50 Offset: 0x17FE250 VA: 0x1817FFC50
	private static int HexCharToInt(char ch) { }

	// RVA: 0x1800FF0 Offset: 0x17FF5F0 VA: 0x181800FF0
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

	// RVA: 0x18154C0 Offset: 0x1813AC0 VA: 0x1818154C0
	internal object <CreateCastConverter>b__0(object o) { }

}

