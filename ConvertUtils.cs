internal static class ConvertUtils // TypeDefIndex: 5943
{	// Fields
	private static readonly Dictionary<Type, PrimitiveTypeCode> TypeCodeMap; // 0x0
	private static readonly TypeInformation[] PrimitiveTypeCodes; // 0x8
	private static readonly ThreadSafeStore<ConvertUtils.TypeConvertKey, Func<object, object>> CastConverters; // 0x10

	// Methods

	// RVA: 0x17ECFA0 Offset: 0x17EB5A0 VA: 0x1817ECFA0
	public static PrimitiveTypeCode GetTypeCode(Type t) { }

	// RVA: 0x17ED000 Offset: 0x17EB600 VA: 0x1817ED000
	public static PrimitiveTypeCode GetTypeCode(Type t, out bool isEnum) { }

	// RVA: 0x17ED2A0 Offset: 0x17EB8A0 VA: 0x1817ED2A0
	public static TypeInformation GetTypeInformation(IConvertible convertable) { }

	// RVA: 0x17ED870 Offset: 0x17EBE70 VA: 0x1817ED870
	public static bool IsConvertible(Type t) { }

	// RVA: 0x17EDA20 Offset: 0x17EC020 VA: 0x1817EDA20
	public static TimeSpan ParseTimeSpan(string input) { }

	// RVA: 0x17ECA10 Offset: 0x17EB010 VA: 0x1817ECA10
	private static Func<object, object> CreateCastConverter(ConvertUtils.TypeConvertKey t) { }

	// RVA: 0x17EE580 Offset: 0x17ECB80 VA: 0x1817EE580
	private static bool TryConvert(object initialValue, CultureInfo culture, Type targetType, out object value) { }

	// RVA: 0x17EDBC0 Offset: 0x17EC1C0 VA: 0x1817EDBC0
	private static ConvertUtils.ConvertResult TryConvertInternal(object initialValue, CultureInfo culture, Type targetType, out object value) { }

	// RVA: 0x17EC8A0 Offset: 0x17EAEA0 VA: 0x1817EC8A0
	public static object ConvertOrCast(object initialValue, CultureInfo culture, Type targetType) { }

	// RVA: 0x17ECC50 Offset: 0x17EB250 VA: 0x1817ECC50
	private static object EnsureTypeAssignable(object value, Type initialType, Type targetType) { }

	// RVA: 0x17ECF10 Offset: 0x17EB510 VA: 0x1817ECF10
	internal static TypeConverter GetConverter(Type t) { }

	// RVA: 0x17EE650 Offset: 0x17ECC50 VA: 0x1817EE650
	public static bool VersionTryParse(string input, out Version result) { }

	// RVA: 0x17ED900 Offset: 0x17EBF00 VA: 0x1817ED900
	public static bool IsInteger(object value) { }

	// RVA: 0x17ED500 Offset: 0x17EBB00 VA: 0x1817ED500
	public static ParseResult Int32TryParse(char[] chars, int start, int length, out int value) { }

	// RVA: 0x17ED6D0 Offset: 0x17EBCD0 VA: 0x1817ED6D0
	public static ParseResult Int64TryParse(char[] chars, int start, int length, out long value) { }

	// RVA: 0x17EDA80 Offset: 0x17EC080 VA: 0x1817EDA80
	public static bool TryConvertGuid(string s, out Guid g) { }

	// RVA: 0x17ED420 Offset: 0x17EBA20 VA: 0x1817ED420
	public static int HexTextToInt(char[] text, int start, int end) { }

	// RVA: 0x17ED350 Offset: 0x17EB950 VA: 0x1817ED350
	private static int HexCharToInt(char ch) { }

	// RVA: 0x17EE6F0 Offset: 0x17ECCF0 VA: 0x1817EE6F0
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

	// RVA: 0xF5DB0 Offset: 0xF51B0 VA: 0x1800F5DB0
	public void .ctor(Type initialType, Type targetType) { }

	// RVA: 0xF5D50 Offset: 0xF5150 VA: 0x1800F5D50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2111D0 Offset: 0x2105D0 VA: 0x1802111D0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x210980 Offset: 0x20FD80 VA: 0x180210980
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

	// RVA: 0x1802BC0 Offset: 0x18011C0 VA: 0x181802BC0
	internal object <CreateCastConverter>b__0(object o) { }

}

