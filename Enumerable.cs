public abstract class Enum : ValueType, IComparable, IFormattable, IConvertible // TypeDefIndex: 211
{	private static readonly char[] enumSeperatorCharArray; // 0x2B10A1C
	private const string enumSeperator = ", ";


	private static Enum.ValuesAndNames GetCachedValuesAndNames(RuntimeType enumType, bool getNames) { }

	private static string InternalFormattedHexString(object value) { }

	private static string InternalFormat(RuntimeType eT, object value) { }

	private static string InternalFlagsFormat(RuntimeType eT, object value) { }

	internal static ulong ToUInt64(object value) { }

	private static int InternalCompareTo(object o1, object o2) { }

	internal static RuntimeType InternalGetUnderlyingType(RuntimeType enumType) { }

	private static bool GetEnumValuesAndNames(RuntimeType enumType, out ulong[] values, out string[] names) { }

	private static object InternalBoxEnum(RuntimeType enumType, long value) { }

	public static bool TryParse<TEnum>(string value, out TEnum result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEF5B0 Offset: 0xBEDBB0 VA: 0x180BEF5B0
	|-Enum.TryParse<Int32Enum>
	|-Enum.TryParse<KeyCode>
	*/

	public static bool TryParse<TEnum>(string value, bool ignoreCase, out TEnum result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEF630 Offset: 0xBEDC30 VA: 0x180BEF630
	|-Enum.TryParse<Int32Enum>
	|-Enum.TryParse<KeyCode>
	*/

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	public static object Parse(Type enumType, string value) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	public static object Parse(Type enumType, string value, bool ignoreCase) { }

	private static bool TryParseEnum(Type enumType, string value, bool ignoreCase, ref Enum.EnumResult parseResult) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	public static Type GetUnderlyingType(Type enumType) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	public static Array GetValues(Type enumType) { }

	internal static ulong[] InternalGetValues(RuntimeType enumType) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	public static string GetName(Type enumType, object value) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	public static string[] GetNames(Type enumType) { }

	internal static string[] InternalGetNames(RuntimeType enumType) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	public static object ToObject(Type enumType, object value) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	public static bool IsDefined(Type enumType, object value) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	public static string Format(Type enumType, object value, string format) { }

	private object get_value() { }

	internal object GetValue() { }

	private bool InternalHasFlag(Enum flags) { }

	private int get_hashcode() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public override string ToString() { }

	[ObsoleteAttribute] // RVA: 0x79FB0 Offset: 0x793B0 VA: 0x180079FB0
	public string ToString(string format, IFormatProvider provider) { }

	public int CompareTo(object target) { }

	public string ToString(string format) { }

	[ObsoleteAttribute] // RVA: 0x7A290 Offset: 0x79690 VA: 0x18007A290
	public string ToString(IFormatProvider provider) { }

	public bool HasFlag(Enum flag) { }

	public TypeCode GetTypeCode() { }

	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	[ComVisibleAttribute] // RVA: 0x7A390 Offset: 0x79790 VA: 0x18007A390
	[CLSCompliantAttribute] // RVA: 0x7A390 Offset: 0x79790 VA: 0x18007A390
	public static object ToObject(Type enumType, sbyte value) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	public static object ToObject(Type enumType, short value) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	public static object ToObject(Type enumType, int value) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	public static object ToObject(Type enumType, byte value) { }

	[ComVisibleAttribute] // RVA: 0x7A390 Offset: 0x79790 VA: 0x18007A390
	[CLSCompliantAttribute] // RVA: 0x7A390 Offset: 0x79790 VA: 0x18007A390
	public static object ToObject(Type enumType, ushort value) { }

	[ComVisibleAttribute] // RVA: 0x7A390 Offset: 0x79790 VA: 0x18007A390
	[CLSCompliantAttribute] // RVA: 0x7A390 Offset: 0x79790 VA: 0x18007A390
	public static object ToObject(Type enumType, uint value) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	public static object ToObject(Type enumType, long value) { }

	[ComVisibleAttribute] // RVA: 0x7A390 Offset: 0x79790 VA: 0x18007A390
	[CLSCompliantAttribute] // RVA: 0x7A390 Offset: 0x79790 VA: 0x18007A390
	public static object ToObject(Type enumType, ulong value) { }

	private static object ToObject(Type enumType, char value) { }

	private static object ToObject(Type enumType, bool value) { }

	protected void .ctor() { }

	private static void .cctor() { }

}

private enum Enum.ParseFailureKind // TypeDefIndex: 212
{	public int value__; // 0x0
	public const Enum.ParseFailureKind None = 0;
	public const Enum.ParseFailureKind Argument = 1;
	public const Enum.ParseFailureKind ArgumentNull = 2;
	public const Enum.ParseFailureKind ArgumentWithParameter = 3;
	public const Enum.ParseFailureKind UnhandledException = 4;

}

private struct Enum.EnumResult // TypeDefIndex: 213
{	internal object parsedEnum; // 0x0
	internal bool canThrow; // 0x8
	internal Enum.ParseFailureKind m_failure; // 0xC
	internal string m_failureMessageID; // 0x10
	internal string m_failureParameter; // 0x18
	internal object m_failureMessageFormatArgument; // 0x20
	internal Exception m_innerException; // 0x28


	internal void Init(bool canMethodThrow) { }

	internal void SetFailure(Exception unhandledException) { }

	internal void SetFailure(Enum.ParseFailureKind failure, string failureParameter) { }

	internal void SetFailure(Enum.ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument) { }

	internal Exception GetEnumParseException() { }

}

private class Enum.ValuesAndNames // TypeDefIndex: 214
{	public ulong[] Values; // 0x10
	public string[] Names; // 0x18


	public void .ctor(ulong[] values, string[] names) { }

}

public abstract class EnumBuilder : TypeInfo // TypeDefIndex: 602
{
public abstract class EnumBuilder : TypeInfo // TypeDefIndex: 602
	public override Assembly Assembly { get; }
	public override string AssemblyQualifiedName { get; }
	public override Type BaseType { get; }
	public override string FullName { get; }
	public override Module Module { get; }
	public override string Name { get; }
	public override string Namespace { get; }
	public override Type UnderlyingSystemType { get; }


	public override Assembly get_Assembly() { }

	public override string get_AssemblyQualifiedName() { }

	public override Type get_BaseType() { }

	public override string get_FullName() { }

	public override Module get_Module() { }

	public override string get_Name() { }

	public override string get_Namespace() { }

	public override Type GetElementType() { }

	public override Type get_UnderlyingSystemType() { }

	protected override TypeAttributes GetAttributeFlagsImpl() { }

	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	public override object[] GetCustomAttributes(bool inherit) { }

	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	public override Type[] GetInterfaces() { }

	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	public override Type GetNestedType(string name, BindingFlags bindingAttr) { }

	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	protected override bool HasElementTypeImpl() { }

	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { }

	protected override bool IsArrayImpl() { }

	protected override bool IsByRefImpl() { }

	protected override bool IsCOMObjectImpl() { }

	public override bool IsDefined(Type attributeType, bool inherit) { }

	protected override bool IsPointerImpl() { }

	protected override bool IsPrimitiveImpl() { }

}

internal static class EnumHelper<UnderlyingType> // TypeDefIndex: 1511
{
internal static class EnumHelper<UnderlyingType> // TypeDefIndex: 1511
	private static readonly MethodInfo IdentityInfo; // 0x0


	public static UnderlyingType Cast<ValueType>(ValueType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A372E0 Offset: 0x1A358E0 VA: 0x181A372E0
	|-EnumHelper<byte>.Cast<bool>
	|-EnumHelper<byte>.Cast<byte>
	|-EnumHelper<byte>.Cast<sbyte>
	|-EnumHelper<short>.Cast<bool>
	|-EnumHelper<short>.Cast<byte>
	|-EnumHelper<short>.Cast<sbyte>
	|-EnumHelper<int>.Cast<bool>
	|-EnumHelper<int>.Cast<byte>
	|-EnumHelper<int>.Cast<sbyte>
	|-EnumHelper<long>.Cast<bool>
	|-EnumHelper<long>.Cast<byte>
	|-EnumHelper<long>.Cast<sbyte>
	|-EnumHelper<sbyte>.Cast<bool>
	|-EnumHelper<sbyte>.Cast<byte>
	|-EnumHelper<sbyte>.Cast<sbyte>
	|-EnumHelper<ushort>.Cast<bool>
	|-EnumHelper<ushort>.Cast<byte>
	|-EnumHelper<ushort>.Cast<sbyte>
	|-EnumHelper<uint>.Cast<bool>
	|-EnumHelper<uint>.Cast<byte>
	|-EnumHelper<uint>.Cast<sbyte>
	|-EnumHelper<ulong>.Cast<bool>
	|-EnumHelper<ulong>.Cast<byte>
	|-EnumHelper<ulong>.Cast<sbyte>
	|
	|-RVA: 0x1A373B0 Offset: 0x1A359B0 VA: 0x181A373B0
	|-EnumHelper<byte>.Cast<char>
	|-EnumHelper<byte>.Cast<short>
	|-EnumHelper<byte>.Cast<ushort>
	|-EnumHelper<short>.Cast<char>
	|-EnumHelper<short>.Cast<short>
	|-EnumHelper<short>.Cast<ushort>
	|-EnumHelper<int>.Cast<char>
	|-EnumHelper<int>.Cast<short>
	|-EnumHelper<int>.Cast<ushort>
	|-EnumHelper<long>.Cast<char>
	|-EnumHelper<long>.Cast<short>
	|-EnumHelper<long>.Cast<ushort>
	|-EnumHelper<sbyte>.Cast<char>
	|-EnumHelper<sbyte>.Cast<short>
	|-EnumHelper<sbyte>.Cast<ushort>
	|-EnumHelper<ushort>.Cast<char>
	|-EnumHelper<ushort>.Cast<short>
	|-EnumHelper<ushort>.Cast<ushort>
	|-EnumHelper<uint>.Cast<char>
	|-EnumHelper<uint>.Cast<short>
	|-EnumHelper<uint>.Cast<ushort>
	|-EnumHelper<ulong>.Cast<char>
	|-EnumHelper<ulong>.Cast<short>
	|-EnumHelper<ulong>.Cast<ushort>
	|
	|-RVA: 0x1A37480 Offset: 0x1A35A80 VA: 0x181A37480
	|-EnumHelper<byte>.Cast<KeyValuePair<object, object>>
	|-EnumHelper<byte>.Cast<DateTimeOffset>
	|-EnumHelper<byte>.Cast<Decimal>
	|-EnumHelper<byte>.Cast<Guid>
	|-EnumHelper<short>.Cast<KeyValuePair<object, object>>
	|-EnumHelper<short>.Cast<DateTimeOffset>
	|-EnumHelper<short>.Cast<Decimal>
	|-EnumHelper<short>.Cast<Guid>
	|-EnumHelper<int>.Cast<KeyValuePair<object, object>>
	|-EnumHelper<int>.Cast<DateTimeOffset>
	|-EnumHelper<int>.Cast<Decimal>
	|-EnumHelper<int>.Cast<Guid>
	|-EnumHelper<long>.Cast<KeyValuePair<object, object>>
	|-EnumHelper<long>.Cast<DateTimeOffset>
	|-EnumHelper<long>.Cast<Decimal>
	|-EnumHelper<long>.Cast<Guid>
	|-EnumHelper<sbyte>.Cast<KeyValuePair<object, object>>
	|-EnumHelper<sbyte>.Cast<DateTimeOffset>
	|-EnumHelper<sbyte>.Cast<Decimal>
	|-EnumHelper<sbyte>.Cast<Guid>
	|-EnumHelper<ushort>.Cast<KeyValuePair<object, object>>
	|-EnumHelper<ushort>.Cast<DateTimeOffset>
	|-EnumHelper<ushort>.Cast<Decimal>
	|-EnumHelper<ushort>.Cast<Guid>
	|-EnumHelper<uint>.Cast<KeyValuePair<object, object>>
	|-EnumHelper<uint>.Cast<DateTimeOffset>
	|-EnumHelper<uint>.Cast<Decimal>
	|-EnumHelper<uint>.Cast<Guid>
	|-EnumHelper<ulong>.Cast<KeyValuePair<object, object>>
	|-EnumHelper<ulong>.Cast<DateTimeOffset>
	|-EnumHelper<ulong>.Cast<Decimal>
	|-EnumHelper<ulong>.Cast<Guid>
	|
	|-RVA: 0x1A37550 Offset: 0x1A35B50 VA: 0x181A37550
	|-EnumHelper<byte>.Cast<DateTime>
	|-EnumHelper<byte>.Cast<TimeSpan>
	|-EnumHelper<short>.Cast<DateTime>
	|-EnumHelper<short>.Cast<TimeSpan>
	|-EnumHelper<int>.Cast<DateTime>
	|-EnumHelper<int>.Cast<TimeSpan>
	|-EnumHelper<long>.Cast<DateTime>
	|-EnumHelper<long>.Cast<TimeSpan>
	|-EnumHelper<sbyte>.Cast<DateTime>
	|-EnumHelper<sbyte>.Cast<TimeSpan>
	|-EnumHelper<ushort>.Cast<DateTime>
	|-EnumHelper<ushort>.Cast<TimeSpan>
	|-EnumHelper<uint>.Cast<DateTime>
	|-EnumHelper<uint>.Cast<TimeSpan>
	|-EnumHelper<ulong>.Cast<DateTime>
	|-EnumHelper<ulong>.Cast<TimeSpan>
	|
	|-RVA: 0x1A376F0 Offset: 0x1A35CF0 VA: 0x181A376F0
	|-EnumHelper<byte>.Cast<EmptyStruct>
	|-EnumHelper<short>.Cast<EmptyStruct>
	|-EnumHelper<int>.Cast<EmptyStruct>
	|-EnumHelper<long>.Cast<EmptyStruct>
	|-EnumHelper<sbyte>.Cast<EmptyStruct>
	|-EnumHelper<ushort>.Cast<EmptyStruct>
	|-EnumHelper<uint>.Cast<EmptyStruct>
	|-EnumHelper<ulong>.Cast<EmptyStruct>
	|
	|-RVA: 0x1A37620 Offset: 0x1A35C20 VA: 0x181A37620
	|-EnumHelper<byte>.Cast<double>
	|-EnumHelper<byte>.Cast<float>
	|-EnumHelper<short>.Cast<double>
	|-EnumHelper<short>.Cast<float>
	|-EnumHelper<int>.Cast<double>
	|-EnumHelper<int>.Cast<float>
	|-EnumHelper<long>.Cast<double>
	|-EnumHelper<long>.Cast<float>
	|-EnumHelper<sbyte>.Cast<double>
	|-EnumHelper<sbyte>.Cast<float>
	|-EnumHelper<ushort>.Cast<double>
	|-EnumHelper<ushort>.Cast<float>
	|-EnumHelper<uint>.Cast<double>
	|-EnumHelper<uint>.Cast<float>
	|-EnumHelper<ulong>.Cast<double>
	|-EnumHelper<ulong>.Cast<float>
	|
	|-RVA: 0x1A377C0 Offset: 0x1A35DC0 VA: 0x181A377C0
	|-EnumHelper<byte>.Cast<int>
	|-EnumHelper<byte>.Cast<uint>
	|-EnumHelper<short>.Cast<int>
	|-EnumHelper<short>.Cast<uint>
	|-EnumHelper<int>.Cast<int>
	|-EnumHelper<int>.Cast<uint>
	|-EnumHelper<long>.Cast<int>
	|-EnumHelper<long>.Cast<uint>
	|-EnumHelper<sbyte>.Cast<int>
	|-EnumHelper<sbyte>.Cast<uint>
	|-EnumHelper<ushort>.Cast<int>
	|-EnumHelper<ushort>.Cast<uint>
	|-EnumHelper<uint>.Cast<int>
	|-EnumHelper<uint>.Cast<uint>
	|-EnumHelper<ulong>.Cast<int>
	|-EnumHelper<ulong>.Cast<uint>
	|
	|-RVA: 0x1A37890 Offset: 0x1A35E90 VA: 0x181A37890
	|-EnumHelper<byte>.Cast<long>
	|-EnumHelper<byte>.Cast<IntPtr>
	|-EnumHelper<byte>.Cast<object>
	|-EnumHelper<byte>.Cast<ulong>
	|-EnumHelper<byte>.Cast<UIntPtr>
	|-EnumHelper<short>.Cast<long>
	|-EnumHelper<short>.Cast<IntPtr>
	|-EnumHelper<short>.Cast<object>
	|-EnumHelper<short>.Cast<ulong>
	|-EnumHelper<short>.Cast<UIntPtr>
	|-EnumHelper<int>.Cast<long>
	|-EnumHelper<int>.Cast<IntPtr>
	|-EnumHelper<int>.Cast<object>
	|-EnumHelper<int>.Cast<ulong>
	|-EnumHelper<int>.Cast<UIntPtr>
	|-EnumHelper<long>.Cast<long>
	|-EnumHelper<long>.Cast<IntPtr>
	|-EnumHelper<long>.Cast<object>
	|-EnumHelper<long>.Cast<ulong>
	|-EnumHelper<long>.Cast<UIntPtr>
	|-EnumHelper<object>.Cast<object>
	|-EnumHelper<sbyte>.Cast<long>
	|-EnumHelper<sbyte>.Cast<IntPtr>
	|-EnumHelper<sbyte>.Cast<object>
	|-EnumHelper<sbyte>.Cast<ulong>
	|-EnumHelper<sbyte>.Cast<UIntPtr>
	|-EnumHelper<ushort>.Cast<long>
	|-EnumHelper<ushort>.Cast<IntPtr>
	|-EnumHelper<ushort>.Cast<object>
	|-EnumHelper<ushort>.Cast<ulong>
	|-EnumHelper<ushort>.Cast<UIntPtr>
	|-EnumHelper<uint>.Cast<long>
	|-EnumHelper<uint>.Cast<IntPtr>
	|-EnumHelper<uint>.Cast<object>
	|-EnumHelper<uint>.Cast<ulong>
	|-EnumHelper<uint>.Cast<UIntPtr>
	|-EnumHelper<ulong>.Cast<long>
	|-EnumHelper<ulong>.Cast<IntPtr>
	|-EnumHelper<ulong>.Cast<object>
	|-EnumHelper<ulong>.Cast<ulong>
	|-EnumHelper<ulong>.Cast<UIntPtr>
	*/

	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2133CD0 Offset: 0x21322D0 VA: 0x182133CD0
	|-EnumHelper<byte>..cctor
	|
	|-RVA: 0x21337D0 Offset: 0x2131DD0 VA: 0x1821337D0
	|-EnumHelper<short>..cctor
	|
	|-RVA: 0x21338D0 Offset: 0x2131ED0 VA: 0x1821338D0
	|-EnumHelper<int>..cctor
	|
	|-RVA: 0x21339D0 Offset: 0x2131FD0 VA: 0x1821339D0
	|-EnumHelper<long>..cctor
	|
	|-RVA: 0x2133AD0 Offset: 0x21320D0 VA: 0x182133AD0
	|-EnumHelper<object>..cctor
	|
	|-RVA: 0x2133ED0 Offset: 0x21324D0 VA: 0x182133ED0
	|-EnumHelper<sbyte>..cctor
	|
	|-RVA: 0x2133DD0 Offset: 0x21323D0 VA: 0x182133DD0
	|-EnumHelper<ushort>..cctor
	|
	|-RVA: 0x21336D0 Offset: 0x2131CD0 VA: 0x1821336D0
	|-EnumHelper<uint>..cctor
	|
	|-RVA: 0x2133BD0 Offset: 0x21321D0 VA: 0x182133BD0
	|-EnumHelper<ulong>..cctor
	*/

}

private sealed class EnumHelper.Transformer<UnderlyingType, ValueType> : MulticastDelegate // TypeDefIndex: 1512
{
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	|-EnumHelper.Transformer<byte, bool>..ctor
	|-EnumHelper.Transformer<byte, byte>..ctor
	|-EnumHelper.Transformer<byte, char>..ctor
	|-EnumHelper.Transformer<byte, KeyValuePair<object, object>>..ctor
	|-EnumHelper.Transformer<byte, DateTime>..ctor
	|-EnumHelper.Transformer<byte, DateTimeOffset>..ctor
	|-EnumHelper.Transformer<byte, Decimal>..ctor
	|-EnumHelper.Transformer<byte, EmptyStruct>..ctor
	|-EnumHelper.Transformer<byte, double>..ctor
	|-EnumHelper.Transformer<byte, Guid>..ctor
	|-EnumHelper.Transformer<byte, short>..ctor
	|-EnumHelper.Transformer<byte, int>..ctor
	|-EnumHelper.Transformer<byte, long>..ctor
	|-EnumHelper.Transformer<byte, IntPtr>..ctor
	|-EnumHelper.Transformer<byte, object>..ctor
	|-EnumHelper.Transformer<byte, sbyte>..ctor
	|-EnumHelper.Transformer<byte, float>..ctor
	|-EnumHelper.Transformer<byte, TimeSpan>..ctor
	|-EnumHelper.Transformer<byte, ushort>..ctor
	|-EnumHelper.Transformer<byte, uint>..ctor
	|-EnumHelper.Transformer<byte, ulong>..ctor
	|-EnumHelper.Transformer<byte, UIntPtr>..ctor
	|-EnumHelper.Transformer<short, bool>..ctor
	|-EnumHelper.Transformer<short, byte>..ctor
	|-EnumHelper.Transformer<short, char>..ctor
	|-EnumHelper.Transformer<short, KeyValuePair<object, object>>..ctor
	|-EnumHelper.Transformer<short, DateTime>..ctor
	|-EnumHelper.Transformer<short, DateTimeOffset>..ctor
	|-EnumHelper.Transformer<short, Decimal>..ctor
	|-EnumHelper.Transformer<short, EmptyStruct>..ctor
	|-EnumHelper.Transformer<short, double>..ctor
	|-EnumHelper.Transformer<short, Guid>..ctor
	|-EnumHelper.Transformer<short, short>..ctor
	|-EnumHelper.Transformer<short, int>..ctor
	|-EnumHelper.Transformer<short, long>..ctor
	|-EnumHelper.Transformer<short, IntPtr>..ctor
	|-EnumHelper.Transformer<short, object>..ctor
	|-EnumHelper.Transformer<short, sbyte>..ctor
	|-EnumHelper.Transformer<short, float>..ctor
	|-EnumHelper.Transformer<short, TimeSpan>..ctor
	|-EnumHelper.Transformer<short, ushort>..ctor
	|-EnumHelper.Transformer<short, uint>..ctor
	|-EnumHelper.Transformer<short, ulong>..ctor
	|-EnumHelper.Transformer<short, UIntPtr>..ctor
	|-EnumHelper.Transformer<int, bool>..ctor
	|-EnumHelper.Transformer<int, byte>..ctor
	|-EnumHelper.Transformer<int, char>..ctor
	|-EnumHelper.Transformer<int, KeyValuePair<object, object>>..ctor
	|-EnumHelper.Transformer<int, DateTime>..ctor
	|-EnumHelper.Transformer<int, DateTimeOffset>..ctor
	|-EnumHelper.Transformer<int, Decimal>..ctor
	|-EnumHelper.Transformer<int, EmptyStruct>..ctor
	|-EnumHelper.Transformer<int, double>..ctor
	|-EnumHelper.Transformer<int, Guid>..ctor
	|-EnumHelper.Transformer<int, short>..ctor
	|-EnumHelper.Transformer<int, int>..ctor
	|-EnumHelper.Transformer<int, long>..ctor
	|-EnumHelper.Transformer<int, IntPtr>..ctor
	|-EnumHelper.Transformer<int, object>..ctor
	|-EnumHelper.Transformer<int, sbyte>..ctor
	|-EnumHelper.Transformer<int, float>..ctor
	|-EnumHelper.Transformer<int, TimeSpan>..ctor
	|-EnumHelper.Transformer<int, ushort>..ctor
	|-EnumHelper.Transformer<int, uint>..ctor
	|-EnumHelper.Transformer<int, ulong>..ctor
	|-EnumHelper.Transformer<int, UIntPtr>..ctor
	|-EnumHelper.Transformer<long, bool>..ctor
	|-EnumHelper.Transformer<long, byte>..ctor
	|-EnumHelper.Transformer<long, char>..ctor
	|-EnumHelper.Transformer<long, KeyValuePair<object, object>>..ctor
	|-EnumHelper.Transformer<long, DateTime>..ctor
	|-EnumHelper.Transformer<long, DateTimeOffset>..ctor
	|-EnumHelper.Transformer<long, Decimal>..ctor
	|-EnumHelper.Transformer<long, EmptyStruct>..ctor
	|-EnumHelper.Transformer<long, double>..ctor
	|-EnumHelper.Transformer<long, Guid>..ctor
	|-EnumHelper.Transformer<long, short>..ctor
	|-EnumHelper.Transformer<long, int>..ctor
	|-EnumHelper.Transformer<long, long>..ctor
	|-EnumHelper.Transformer<long, IntPtr>..ctor
	|-EnumHelper.Transformer<long, object>..ctor
	|-EnumHelper.Transformer<long, sbyte>..ctor
	|-EnumHelper.Transformer<long, float>..ctor
	|-EnumHelper.Transformer<long, TimeSpan>..ctor
	|-EnumHelper.Transformer<long, ushort>..ctor
	|-EnumHelper.Transformer<long, uint>..ctor
	|-EnumHelper.Transformer<long, ulong>..ctor
	|-EnumHelper.Transformer<long, UIntPtr>..ctor
	|-EnumHelper.Transformer<object, object>..ctor
	|-EnumHelper.Transformer<sbyte, bool>..ctor
	|-EnumHelper.Transformer<sbyte, byte>..ctor
	|-EnumHelper.Transformer<sbyte, char>..ctor
	|-EnumHelper.Transformer<sbyte, KeyValuePair<object, object>>..ctor
	|-EnumHelper.Transformer<sbyte, DateTime>..ctor
	|-EnumHelper.Transformer<sbyte, DateTimeOffset>..ctor
	|-EnumHelper.Transformer<sbyte, Decimal>..ctor
	|-EnumHelper.Transformer<sbyte, EmptyStruct>..ctor
	|-EnumHelper.Transformer<sbyte, double>..ctor
	|-EnumHelper.Transformer<sbyte, Guid>..ctor
	|-EnumHelper.Transformer<sbyte, short>..ctor
	|-EnumHelper.Transformer<sbyte, int>..ctor
	|-EnumHelper.Transformer<sbyte, long>..ctor
	|-EnumHelper.Transformer<sbyte, IntPtr>..ctor
	|-EnumHelper.Transformer<sbyte, object>..ctor
	|-EnumHelper.Transformer<sbyte, sbyte>..ctor
	|-EnumHelper.Transformer<sbyte, float>..ctor
	|-EnumHelper.Transformer<sbyte, TimeSpan>..ctor
	|-EnumHelper.Transformer<sbyte, ushort>..ctor
	|-EnumHelper.Transformer<sbyte, uint>..ctor
	|-EnumHelper.Transformer<sbyte, ulong>..ctor
	|-EnumHelper.Transformer<sbyte, UIntPtr>..ctor
	|-EnumHelper.Transformer<ushort, bool>..ctor
	|-EnumHelper.Transformer<ushort, byte>..ctor
	|-EnumHelper.Transformer<ushort, char>..ctor
	|-EnumHelper.Transformer<ushort, KeyValuePair<object, object>>..ctor
	|-EnumHelper.Transformer<ushort, DateTime>..ctor
	|-EnumHelper.Transformer<ushort, DateTimeOffset>..ctor
	|-EnumHelper.Transformer<ushort, Decimal>..ctor
	|-EnumHelper.Transformer<ushort, EmptyStruct>..ctor
	|-EnumHelper.Transformer<ushort, double>..ctor
	|-EnumHelper.Transformer<ushort, Guid>..ctor
	|-EnumHelper.Transformer<ushort, short>..ctor
	|-EnumHelper.Transformer<ushort, int>..ctor
	|-EnumHelper.Transformer<ushort, long>..ctor
	|-EnumHelper.Transformer<ushort, IntPtr>..ctor
	|-EnumHelper.Transformer<ushort, object>..ctor
	|-EnumHelper.Transformer<ushort, sbyte>..ctor
	|-EnumHelper.Transformer<ushort, float>..ctor
	|-EnumHelper.Transformer<ushort, TimeSpan>..ctor
	|-EnumHelper.Transformer<ushort, ushort>..ctor
	|-EnumHelper.Transformer<ushort, uint>..ctor
	|-EnumHelper.Transformer<ushort, ulong>..ctor
	|-EnumHelper.Transformer<ushort, UIntPtr>..ctor
	|-EnumHelper.Transformer<uint, bool>..ctor
	|-EnumHelper.Transformer<uint, byte>..ctor
	|-EnumHelper.Transformer<uint, char>..ctor
	|-EnumHelper.Transformer<uint, KeyValuePair<object, object>>..ctor
	|-EnumHelper.Transformer<uint, DateTime>..ctor
	|-EnumHelper.Transformer<uint, DateTimeOffset>..ctor
	|-EnumHelper.Transformer<uint, Decimal>..ctor
	|-EnumHelper.Transformer<uint, EmptyStruct>..ctor
	|-EnumHelper.Transformer<uint, double>..ctor
	|-EnumHelper.Transformer<uint, Guid>..ctor
	|-EnumHelper.Transformer<uint, short>..ctor
	|-EnumHelper.Transformer<uint, int>..ctor
	|-EnumHelper.Transformer<uint, long>..ctor
	|-EnumHelper.Transformer<uint, IntPtr>..ctor
	|-EnumHelper.Transformer<uint, object>..ctor
	|-EnumHelper.Transformer<uint, sbyte>..ctor
	|-EnumHelper.Transformer<uint, float>..ctor
	|-EnumHelper.Transformer<uint, TimeSpan>..ctor
	|-EnumHelper.Transformer<uint, ushort>..ctor
	|-EnumHelper.Transformer<uint, uint>..ctor
	|-EnumHelper.Transformer<uint, ulong>..ctor
	|-EnumHelper.Transformer<uint, UIntPtr>..ctor
	|-EnumHelper.Transformer<ulong, bool>..ctor
	|-EnumHelper.Transformer<ulong, byte>..ctor
	|-EnumHelper.Transformer<ulong, char>..ctor
	|-EnumHelper.Transformer<ulong, KeyValuePair<object, object>>..ctor
	|-EnumHelper.Transformer<ulong, DateTime>..ctor
	|-EnumHelper.Transformer<ulong, DateTimeOffset>..ctor
	|-EnumHelper.Transformer<ulong, Decimal>..ctor
	|-EnumHelper.Transformer<ulong, EmptyStruct>..ctor
	|-EnumHelper.Transformer<ulong, double>..ctor
	|-EnumHelper.Transformer<ulong, Guid>..ctor
	|-EnumHelper.Transformer<ulong, short>..ctor
	|-EnumHelper.Transformer<ulong, int>..ctor
	|-EnumHelper.Transformer<ulong, long>..ctor
	|-EnumHelper.Transformer<ulong, IntPtr>..ctor
	|-EnumHelper.Transformer<ulong, object>..ctor
	|-EnumHelper.Transformer<ulong, sbyte>..ctor
	|-EnumHelper.Transformer<ulong, float>..ctor
	|-EnumHelper.Transformer<ulong, TimeSpan>..ctor
	|-EnumHelper.Transformer<ulong, ushort>..ctor
	|-EnumHelper.Transformer<ulong, uint>..ctor
	|-EnumHelper.Transformer<ulong, ulong>..ctor
	|-EnumHelper.Transformer<ulong, UIntPtr>..ctor
	*/

	public virtual UnderlyingType Invoke(ValueType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18A3230 Offset: 0x18A1830 VA: 0x1818A3230
	|-EnumHelper.Transformer<byte, bool>.Invoke
	|-EnumHelper.Transformer<byte, byte>.Invoke
	|-EnumHelper.Transformer<byte, sbyte>.Invoke
	|-EnumHelper.Transformer<sbyte, bool>.Invoke
	|-EnumHelper.Transformer<sbyte, byte>.Invoke
	|-EnumHelper.Transformer<sbyte, sbyte>.Invoke
	|
	|-RVA: 0x18A5B70 Offset: 0x18A4170 VA: 0x1818A5B70
	|-EnumHelper.Transformer<byte, char>.Invoke
	|-EnumHelper.Transformer<byte, short>.Invoke
	|-EnumHelper.Transformer<byte, ushort>.Invoke
	|-EnumHelper.Transformer<sbyte, char>.Invoke
	|-EnumHelper.Transformer<sbyte, short>.Invoke
	|-EnumHelper.Transformer<sbyte, ushort>.Invoke
	|
	|-RVA: 0x16D03E0 Offset: 0x16CE9E0 VA: 0x1816D03E0
	|-EnumHelper.Transformer<byte, KeyValuePair<object, object>>.Invoke
	|-EnumHelper.Transformer<byte, DateTimeOffset>.Invoke
	|-EnumHelper.Transformer<byte, Decimal>.Invoke
	|-EnumHelper.Transformer<byte, Guid>.Invoke
	|-EnumHelper.Transformer<sbyte, KeyValuePair<object, object>>.Invoke
	|-EnumHelper.Transformer<sbyte, DateTimeOffset>.Invoke
	|-EnumHelper.Transformer<sbyte, Decimal>.Invoke
	|-EnumHelper.Transformer<sbyte, Guid>.Invoke
	|
	|-RVA: 0x16D0720 Offset: 0x16CED20 VA: 0x1816D0720
	|-EnumHelper.Transformer<byte, DateTime>.Invoke
	|-EnumHelper.Transformer<byte, TimeSpan>.Invoke
	|-EnumHelper.Transformer<sbyte, DateTime>.Invoke
	|-EnumHelper.Transformer<sbyte, TimeSpan>.Invoke
	|
	|-RVA: 0x18A7AF0 Offset: 0x18A60F0 VA: 0x1818A7AF0
	|-EnumHelper.Transformer<byte, EmptyStruct>.Invoke
	|-EnumHelper.Transformer<sbyte, EmptyStruct>.Invoke
	|
	|-RVA: 0x18A66B0 Offset: 0x18A4CB0 VA: 0x1818A66B0
	|-EnumHelper.Transformer<byte, double>.Invoke
	|-EnumHelper.Transformer<sbyte, double>.Invoke
	|
	|-RVA: 0x146D210 Offset: 0x146B810 VA: 0x18146D210
	|-EnumHelper.Transformer<byte, int>.Invoke
	|-EnumHelper.Transformer<byte, uint>.Invoke
	|-EnumHelper.Transformer<sbyte, int>.Invoke
	|-EnumHelper.Transformer<sbyte, uint>.Invoke
	|
	|-RVA: 0x1B17040 Offset: 0x1B15640 VA: 0x181B17040
	|-EnumHelper.Transformer<byte, long>.Invoke
	|-EnumHelper.Transformer<byte, IntPtr>.Invoke
	|-EnumHelper.Transformer<byte, ulong>.Invoke
	|-EnumHelper.Transformer<byte, UIntPtr>.Invoke
	|-EnumHelper.Transformer<sbyte, long>.Invoke
	|-EnumHelper.Transformer<sbyte, IntPtr>.Invoke
	|-EnumHelper.Transformer<sbyte, ulong>.Invoke
	|-EnumHelper.Transformer<sbyte, UIntPtr>.Invoke
	|
	|-RVA: 0x1783EA0 Offset: 0x17824A0 VA: 0x181783EA0
	|-EnumHelper.Transformer<byte, object>.Invoke
	|-EnumHelper.Transformer<sbyte, object>.Invoke
	|
	|-RVA: 0x18A41F0 Offset: 0x18A27F0 VA: 0x1818A41F0
	|-EnumHelper.Transformer<byte, float>.Invoke
	|-EnumHelper.Transformer<sbyte, float>.Invoke
	|
	|-RVA: 0x1B17830 Offset: 0x1B15E30 VA: 0x181B17830
	|-EnumHelper.Transformer<short, bool>.Invoke
	|-EnumHelper.Transformer<short, byte>.Invoke
	|-EnumHelper.Transformer<short, sbyte>.Invoke
	|-EnumHelper.Transformer<ushort, bool>.Invoke
	|-EnumHelper.Transformer<ushort, byte>.Invoke
	|-EnumHelper.Transformer<ushort, sbyte>.Invoke
	|
	|-RVA: 0x1B19740 Offset: 0x1B17D40 VA: 0x181B19740
	|-EnumHelper.Transformer<short, char>.Invoke
	|-EnumHelper.Transformer<short, short>.Invoke
	|-EnumHelper.Transformer<short, ushort>.Invoke
	|-EnumHelper.Transformer<ushort, char>.Invoke
	|-EnumHelper.Transformer<ushort, short>.Invoke
	|-EnumHelper.Transformer<ushort, ushort>.Invoke
	|
	|-RVA: 0x1B18E00 Offset: 0x1B17400 VA: 0x181B18E00
	|-EnumHelper.Transformer<short, KeyValuePair<object, object>>.Invoke
	|-EnumHelper.Transformer<short, DateTimeOffset>.Invoke
	|-EnumHelper.Transformer<short, Decimal>.Invoke
	|-EnumHelper.Transformer<short, Guid>.Invoke
	|-EnumHelper.Transformer<ushort, KeyValuePair<object, object>>.Invoke
	|-EnumHelper.Transformer<ushort, DateTimeOffset>.Invoke
	|-EnumHelper.Transformer<ushort, Decimal>.Invoke
	|-EnumHelper.Transformer<ushort, Guid>.Invoke
	|
	|-RVA: 0x1B19140 Offset: 0x1B17740 VA: 0x181B19140
	|-EnumHelper.Transformer<short, DateTime>.Invoke
	|-EnumHelper.Transformer<short, TimeSpan>.Invoke
	|-EnumHelper.Transformer<ushort, DateTime>.Invoke
	|-EnumHelper.Transformer<ushort, TimeSpan>.Invoke
	|
	|-RVA: 0x1B1A050 Offset: 0x1B18650 VA: 0x181B1A050
	|-EnumHelper.Transformer<short, EmptyStruct>.Invoke
	|-EnumHelper.Transformer<ushort, EmptyStruct>.Invoke
	|
	|-RVA: 0x1B16B30 Offset: 0x1B15130 VA: 0x181B16B30
	|-EnumHelper.Transformer<short, double>.Invoke
	|-EnumHelper.Transformer<ushort, double>.Invoke
	|
	|-RVA: 0x1B16080 Offset: 0x1B14680 VA: 0x181B16080
	|-EnumHelper.Transformer<short, int>.Invoke
	|-EnumHelper.Transformer<short, uint>.Invoke
	|-EnumHelper.Transformer<ushort, int>.Invoke
	|-EnumHelper.Transformer<ushort, uint>.Invoke
	|
	|-RVA: 0x1B17E70 Offset: 0x1B16470 VA: 0x181B17E70
	|-EnumHelper.Transformer<short, long>.Invoke
	|-EnumHelper.Transformer<short, IntPtr>.Invoke
	|-EnumHelper.Transformer<short, ulong>.Invoke
	|-EnumHelper.Transformer<short, UIntPtr>.Invoke
	|-EnumHelper.Transformer<ushort, long>.Invoke
	|-EnumHelper.Transformer<ushort, IntPtr>.Invoke
	|-EnumHelper.Transformer<ushort, ulong>.Invoke
	|-EnumHelper.Transformer<ushort, UIntPtr>.Invoke
	|
	|-RVA: 0x1B18670 Offset: 0x1B16C70 VA: 0x181B18670
	|-EnumHelper.Transformer<short, object>.Invoke
	|-EnumHelper.Transformer<ushort, object>.Invoke
	|
	|-RVA: 0x1B1A350 Offset: 0x1B18950 VA: 0x181B1A350
	|-EnumHelper.Transformer<short, float>.Invoke
	|-EnumHelper.Transformer<ushort, float>.Invoke
	|
	|-RVA: 0x1B18B00 Offset: 0x1B17100 VA: 0x181B18B00
	|-EnumHelper.Transformer<int, bool>.Invoke
	|-EnumHelper.Transformer<int, byte>.Invoke
	|-EnumHelper.Transformer<int, sbyte>.Invoke
	|-EnumHelper.Transformer<uint, bool>.Invoke
	|-EnumHelper.Transformer<uint, byte>.Invoke
	|-EnumHelper.Transformer<uint, sbyte>.Invoke
	|
	|-RVA: 0x1B18370 Offset: 0x1B16970 VA: 0x181B18370
	|-EnumHelper.Transformer<int, char>.Invoke
	|-EnumHelper.Transformer<int, short>.Invoke
	|-EnumHelper.Transformer<int, ushort>.Invoke
	|-EnumHelper.Transformer<uint, char>.Invoke
	|-EnumHelper.Transformer<uint, short>.Invoke
	|-EnumHelper.Transformer<uint, ushort>.Invoke
	|
	|-RVA: 0x1B17B30 Offset: 0x1B16130 VA: 0x181B17B30
	|-EnumHelper.Transformer<int, KeyValuePair<object, object>>.Invoke
	|-EnumHelper.Transformer<int, DateTimeOffset>.Invoke
	|-EnumHelper.Transformer<int, Decimal>.Invoke
	|-EnumHelper.Transformer<int, Guid>.Invoke
	|-EnumHelper.Transformer<uint, KeyValuePair<object, object>>.Invoke
	|-EnumHelper.Transformer<uint, DateTimeOffset>.Invoke
	|-EnumHelper.Transformer<uint, Decimal>.Invoke
	|-EnumHelper.Transformer<uint, Guid>.Invoke
	|
	|-RVA: 0x1B19440 Offset: 0x1B17A40 VA: 0x181B19440
	|-EnumHelper.Transformer<int, DateTime>.Invoke
	|-EnumHelper.Transformer<int, TimeSpan>.Invoke
	|-EnumHelper.Transformer<uint, DateTime>.Invoke
	|-EnumHelper.Transformer<uint, TimeSpan>.Invoke
	|
	|-RVA: 0x1B19A40 Offset: 0x1B18040 VA: 0x181B19A40
	|-EnumHelper.Transformer<int, EmptyStruct>.Invoke
	|-EnumHelper.Transformer<uint, EmptyStruct>.Invoke
	|
	|-RVA: 0x1B19D40 Offset: 0x1B18340 VA: 0x181B19D40
	|-EnumHelper.Transformer<int, double>.Invoke
	|-EnumHelper.Transformer<uint, double>.Invoke
	|
	|-RVA: 0x19E7E80 Offset: 0x19E6480 VA: 0x1819E7E80
	|-EnumHelper.Transformer<int, int>.Invoke
	|-EnumHelper.Transformer<int, uint>.Invoke
	|-EnumHelper.Transformer<uint, int>.Invoke
	|-EnumHelper.Transformer<uint, uint>.Invoke
	|
	|-RVA: 0x1B16E40 Offset: 0x1B15440 VA: 0x181B16E40
	|-EnumHelper.Transformer<int, long>.Invoke
	|-EnumHelper.Transformer<int, IntPtr>.Invoke
	|-EnumHelper.Transformer<int, ulong>.Invoke
	|-EnumHelper.Transformer<int, UIntPtr>.Invoke
	|-EnumHelper.Transformer<uint, long>.Invoke
	|-EnumHelper.Transformer<uint, IntPtr>.Invoke
	|-EnumHelper.Transformer<uint, ulong>.Invoke
	|-EnumHelper.Transformer<uint, UIntPtr>.Invoke
	|
	|-RVA: 0x1B166B0 Offset: 0x1B14CB0 VA: 0x181B166B0
	|-EnumHelper.Transformer<int, object>.Invoke
	|-EnumHelper.Transformer<uint, object>.Invoke
	|
	|-RVA: 0x1B17540 Offset: 0x1B15B40 VA: 0x181B17540
	|-EnumHelper.Transformer<int, float>.Invoke
	|-EnumHelper.Transformer<uint, float>.Invoke
	|
	|-RVA: 0x1B18070 Offset: 0x1B16670 VA: 0x181B18070
	|-EnumHelper.Transformer<long, bool>.Invoke
	|-EnumHelper.Transformer<long, byte>.Invoke
	|-EnumHelper.Transformer<long, sbyte>.Invoke
	|-EnumHelper.Transformer<ulong, bool>.Invoke
	|-EnumHelper.Transformer<ulong, byte>.Invoke
	|-EnumHelper.Transformer<ulong, sbyte>.Invoke
	|
	|-RVA: 0x1B17240 Offset: 0x1B15840 VA: 0x181B17240
	|-EnumHelper.Transformer<long, char>.Invoke
	|-EnumHelper.Transformer<long, short>.Invoke
	|-EnumHelper.Transformer<long, ushort>.Invoke
	|-EnumHelper.Transformer<ulong, char>.Invoke
	|-EnumHelper.Transformer<ulong, short>.Invoke
	|-EnumHelper.Transformer<ulong, ushort>.Invoke
	|
	|-RVA: 0x1B16370 Offset: 0x1B14970 VA: 0x181B16370
	|-EnumHelper.Transformer<long, KeyValuePair<object, object>>.Invoke
	|-EnumHelper.Transformer<long, DateTimeOffset>.Invoke
	|-EnumHelper.Transformer<long, Decimal>.Invoke
	|-EnumHelper.Transformer<long, Guid>.Invoke
	|-EnumHelper.Transformer<ulong, KeyValuePair<object, object>>.Invoke
	|-EnumHelper.Transformer<ulong, DateTimeOffset>.Invoke
	|-EnumHelper.Transformer<ulong, Decimal>.Invoke
	|-EnumHelper.Transformer<ulong, Guid>.Invoke
	|
	|-RVA: 0x19EA850 Offset: 0x19E8E50 VA: 0x1819EA850
	|-EnumHelper.Transformer<long, DateTime>.Invoke
	|-EnumHelper.Transformer<long, TimeSpan>.Invoke
	|-EnumHelper.Transformer<ulong, DateTime>.Invoke
	|-EnumHelper.Transformer<ulong, TimeSpan>.Invoke
	|
	|-RVA: 0x1B962A0 Offset: 0x1B948A0 VA: 0x181B962A0
	|-EnumHelper.Transformer<long, EmptyStruct>.Invoke
	|-EnumHelper.Transformer<ulong, EmptyStruct>.Invoke
	|
	|-RVA: 0x20C8490 Offset: 0x20C6A90 VA: 0x1820C8490
	|-EnumHelper.Transformer<long, double>.Invoke
	|-EnumHelper.Transformer<ulong, double>.Invoke
	|
	|-RVA: 0x20C81A0 Offset: 0x20C67A0 VA: 0x1820C81A0
	|-EnumHelper.Transformer<long, int>.Invoke
	|-EnumHelper.Transformer<long, uint>.Invoke
	|-EnumHelper.Transformer<ulong, int>.Invoke
	|-EnumHelper.Transformer<ulong, uint>.Invoke
	|
	|-RVA: 0x20C87A0 Offset: 0x20C6DA0 VA: 0x1820C87A0
	|-EnumHelper.Transformer<long, long>.Invoke
	|-EnumHelper.Transformer<long, IntPtr>.Invoke
	|-EnumHelper.Transformer<long, ulong>.Invoke
	|-EnumHelper.Transformer<long, UIntPtr>.Invoke
	|-EnumHelper.Transformer<ulong, long>.Invoke
	|-EnumHelper.Transformer<ulong, IntPtr>.Invoke
	|-EnumHelper.Transformer<ulong, ulong>.Invoke
	|-EnumHelper.Transformer<ulong, UIntPtr>.Invoke
	|
	|-RVA: 0x133A9E0 Offset: 0x1338FE0 VA: 0x18133A9E0
	|-EnumHelper.Transformer<long, object>.Invoke
	|-EnumHelper.Transformer<object, object>.Invoke
	|-EnumHelper.Transformer<ulong, object>.Invoke
	|
	|-RVA: 0x20C89A0 Offset: 0x20C6FA0 VA: 0x1820C89A0
	|-EnumHelper.Transformer<long, float>.Invoke
	|-EnumHelper.Transformer<ulong, float>.Invoke
	*/

	public virtual IAsyncResult BeginInvoke(ValueType value, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B14D80 Offset: 0x1B13380 VA: 0x181B14D80
	|-EnumHelper.Transformer<byte, bool>.BeginInvoke
	|
	|-RVA: 0x1B13F80 Offset: 0x1B12580 VA: 0x181B13F80
	|-EnumHelper.Transformer<byte, byte>.BeginInvoke
	|
	|-RVA: 0x1B15480 Offset: 0x1B13A80 VA: 0x181B15480
	|-EnumHelper.Transformer<byte, char>.BeginInvoke
	|
	|-RVA: 0x1B15E00 Offset: 0x1B14400 VA: 0x181B15E00
	|-EnumHelper.Transformer<byte, KeyValuePair<object, object>>.BeginInvoke
	|
	|-RVA: 0x1B15F80 Offset: 0x1B14580 VA: 0x181B15F80
	|-EnumHelper.Transformer<byte, DateTime>.BeginInvoke
	|
	|-RVA: 0x1B15F00 Offset: 0x1B14500 VA: 0x181B15F00
	|-EnumHelper.Transformer<byte, DateTimeOffset>.BeginInvoke
	|
	|-RVA: 0x1B15A00 Offset: 0x1B14000 VA: 0x181B15A00
	|-EnumHelper.Transformer<byte, Decimal>.BeginInvoke
	|
	|-RVA: 0x1B14F80 Offset: 0x1B13580 VA: 0x181B14F80
	|-EnumHelper.Transformer<byte, EmptyStruct>.BeginInvoke
	|
	|-RVA: 0x1B15B00 Offset: 0x1B14100 VA: 0x181B15B00
	|-EnumHelper.Transformer<byte, double>.BeginInvoke
	|
	|-RVA: 0x1B14700 Offset: 0x1B12D00 VA: 0x181B14700
	|-EnumHelper.Transformer<byte, Guid>.BeginInvoke
	|
	|-RVA: 0x1B15700 Offset: 0x1B13D00 VA: 0x181B15700
	|-EnumHelper.Transformer<byte, short>.BeginInvoke
	|
	|-RVA: 0x1B14800 Offset: 0x1B12E00 VA: 0x181B14800
	|-EnumHelper.Transformer<byte, int>.BeginInvoke
	|
	|-RVA: 0x1B15C00 Offset: 0x1B14200 VA: 0x181B15C00
	|-EnumHelper.Transformer<byte, long>.BeginInvoke
	|
	|-RVA: 0x1B14B00 Offset: 0x1B13100 VA: 0x181B14B00
	|-EnumHelper.Transformer<byte, IntPtr>.BeginInvoke
	|
	|-RVA: 0x49A380 Offset: 0x498980 VA: 0x18049A380
	|-EnumHelper.Transformer<byte, object>.BeginInvoke
	|-EnumHelper.Transformer<short, object>.BeginInvoke
	|-EnumHelper.Transformer<int, object>.BeginInvoke
	|-EnumHelper.Transformer<long, object>.BeginInvoke
	|-EnumHelper.Transformer<object, object>.BeginInvoke
	|-EnumHelper.Transformer<sbyte, object>.BeginInvoke
	|-EnumHelper.Transformer<ushort, object>.BeginInvoke
	|-EnumHelper.Transformer<uint, object>.BeginInvoke
	|-EnumHelper.Transformer<ulong, object>.BeginInvoke
	|
	|-RVA: 0x1B15800 Offset: 0x1B13E00 VA: 0x181B15800
	|-EnumHelper.Transformer<byte, sbyte>.BeginInvoke
	|
	|-RVA: 0x1B15280 Offset: 0x1B13880 VA: 0x181B15280
	|-EnumHelper.Transformer<byte, float>.BeginInvoke
	|
	|-RVA: 0x1B15D00 Offset: 0x1B14300 VA: 0x181B15D00
	|-EnumHelper.Transformer<byte, TimeSpan>.BeginInvoke
	|
	|-RVA: 0x1B14100 Offset: 0x1B12700 VA: 0x181B14100
	|-EnumHelper.Transformer<byte, ushort>.BeginInvoke
	|
	|-RVA: 0x1B15880 Offset: 0x1B13E80 VA: 0x181B15880
	|-EnumHelper.Transformer<byte, uint>.BeginInvoke
	|
	|-RVA: 0x1B14900 Offset: 0x1B12F00 VA: 0x181B14900
	|-EnumHelper.Transformer<byte, ulong>.BeginInvoke
	|
	|-RVA: 0x1B13E00 Offset: 0x1B12400 VA: 0x181B13E00
	|-EnumHelper.Transformer<byte, UIntPtr>.BeginInvoke
	|
	|-RVA: 0x1B15500 Offset: 0x1B13B00 VA: 0x181B15500
	|-EnumHelper.Transformer<short, bool>.BeginInvoke
	|
	|-RVA: 0x1B15300 Offset: 0x1B13900 VA: 0x181B15300
	|-EnumHelper.Transformer<short, byte>.BeginInvoke
	|
	|-RVA: 0x1B14580 Offset: 0x1B12B80 VA: 0x181B14580
	|-EnumHelper.Transformer<short, char>.BeginInvoke
	|
	|-RVA: 0x1B14200 Offset: 0x1B12800 VA: 0x181B14200
	|-EnumHelper.Transformer<short, KeyValuePair<object, object>>.BeginInvoke
	|
	|-RVA: 0x1B13D80 Offset: 0x1B12380 VA: 0x181B13D80
	|-EnumHelper.Transformer<short, DateTime>.BeginInvoke
	|
	|-RVA: 0x1B14D00 Offset: 0x1B13300 VA: 0x181B14D00
	|-EnumHelper.Transformer<short, DateTimeOffset>.BeginInvoke
	|
	|-RVA: 0x1B14000 Offset: 0x1B12600 VA: 0x181B14000
	|-EnumHelper.Transformer<short, Decimal>.BeginInvoke
	|
	|-RVA: 0x1B15980 Offset: 0x1B13F80 VA: 0x181B15980
	|-EnumHelper.Transformer<short, EmptyStruct>.BeginInvoke
	|
	|-RVA: 0x1B14C80 Offset: 0x1B13280 VA: 0x181B14C80
	|-EnumHelper.Transformer<short, double>.BeginInvoke
	|
	|-RVA: 0x1B14500 Offset: 0x1B12B00 VA: 0x181B14500
	|-EnumHelper.Transformer<short, Guid>.BeginInvoke
	|
	|-RVA: 0x1B14300 Offset: 0x1B12900 VA: 0x181B14300
	|-EnumHelper.Transformer<short, short>.BeginInvoke
	|
	|-RVA: 0x1B14180 Offset: 0x1B12780 VA: 0x181B14180
	|-EnumHelper.Transformer<short, int>.BeginInvoke
	|
	|-RVA: 0x1B14480 Offset: 0x1B12A80 VA: 0x181B14480
	|-EnumHelper.Transformer<short, long>.BeginInvoke
	|
	|-RVA: 0x1B14080 Offset: 0x1B12680 VA: 0x181B14080
	|-EnumHelper.Transformer<short, IntPtr>.BeginInvoke
	|
	|-RVA: 0x1B14280 Offset: 0x1B12880 VA: 0x181B14280
	|-EnumHelper.Transformer<short, sbyte>.BeginInvoke
	|
	|-RVA: 0x1B16000 Offset: 0x1B14600 VA: 0x181B16000
	|-EnumHelper.Transformer<short, float>.BeginInvoke
	|
	|-RVA: 0x1B15D80 Offset: 0x1B14380 VA: 0x181B15D80
	|-EnumHelper.Transformer<short, TimeSpan>.BeginInvoke
	|
	|-RVA: 0x1B14680 Offset: 0x1B12C80 VA: 0x181B14680
	|-EnumHelper.Transformer<short, ushort>.BeginInvoke
	|
	|-RVA: 0x1B14A00 Offset: 0x1B13000 VA: 0x181B14A00
	|-EnumHelper.Transformer<short, uint>.BeginInvoke
	|
	|-RVA: 0x1B15380 Offset: 0x1B13980 VA: 0x181B15380
	|-EnumHelper.Transformer<short, ulong>.BeginInvoke
	|
	|-RVA: 0x1B14C00 Offset: 0x1B13200 VA: 0x181B14C00
	|-EnumHelper.Transformer<short, UIntPtr>.BeginInvoke
	|
	|-RVA: 0x1B15C80 Offset: 0x1B14280 VA: 0x181B15C80
	|-EnumHelper.Transformer<int, bool>.BeginInvoke
	|
	|-RVA: 0x1B14600 Offset: 0x1B12C00 VA: 0x181B14600
	|-EnumHelper.Transformer<int, byte>.BeginInvoke
	|
	|-RVA: 0x1B14880 Offset: 0x1B12E80 VA: 0x181B14880
	|-EnumHelper.Transformer<int, char>.BeginInvoke
	|
	|-RVA: 0x1B14E00 Offset: 0x1B13400 VA: 0x181B14E00
	|-EnumHelper.Transformer<int, KeyValuePair<object, object>>.BeginInvoke
	|
	|-RVA: 0x1B14E80 Offset: 0x1B13480 VA: 0x181B14E80
	|-EnumHelper.Transformer<int, DateTime>.BeginInvoke
	|
	|-RVA: 0x1B15180 Offset: 0x1B13780 VA: 0x181B15180
	|-EnumHelper.Transformer<int, DateTimeOffset>.BeginInvoke
	|
	|-RVA: 0x1B15000 Offset: 0x1B13600 VA: 0x181B15000
	|-EnumHelper.Transformer<int, Decimal>.BeginInvoke
	|
	|-RVA: 0x1B15900 Offset: 0x1B13F00 VA: 0x181B15900
	|-EnumHelper.Transformer<int, EmptyStruct>.BeginInvoke
	|
	|-RVA: 0x1B14B80 Offset: 0x1B13180 VA: 0x181B14B80
	|-EnumHelper.Transformer<int, double>.BeginInvoke
	|
	|-RVA: 0x1B15E80 Offset: 0x1B14480 VA: 0x181B15E80
	|-EnumHelper.Transformer<int, Guid>.BeginInvoke
	|
	|-RVA: 0x1B15200 Offset: 0x1B13800 VA: 0x181B15200
	|-EnumHelper.Transformer<int, short>.BeginInvoke
	|
	|-RVA: 0x1B15B80 Offset: 0x1B14180 VA: 0x181B15B80
	|-EnumHelper.Transformer<int, int>.BeginInvoke
	|
	|-RVA: 0x1B15600 Offset: 0x1B13C00 VA: 0x181B15600
	|-EnumHelper.Transformer<int, long>.BeginInvoke
	|
	|-RVA: 0x1B15780 Offset: 0x1B13D80 VA: 0x181B15780
	|-EnumHelper.Transformer<int, IntPtr>.BeginInvoke
	|
	|-RVA: 0x1B14380 Offset: 0x1B12980 VA: 0x181B14380
	|-EnumHelper.Transformer<int, sbyte>.BeginInvoke
	|
	|-RVA: 0x1B13E80 Offset: 0x1B12480 VA: 0x181B13E80
	|-EnumHelper.Transformer<int, float>.BeginInvoke
	|
	|-RVA: 0x1B15400 Offset: 0x1B13A00 VA: 0x181B15400
	|-EnumHelper.Transformer<int, TimeSpan>.BeginInvoke
	|
	|-RVA: 0x1B14780 Offset: 0x1B12D80 VA: 0x181B14780
	|-EnumHelper.Transformer<int, ushort>.BeginInvoke
	|
	|-RVA: 0x1B15100 Offset: 0x1B13700 VA: 0x181B15100
	|-EnumHelper.Transformer<int, uint>.BeginInvoke
	|
	|-RVA: 0x1B13F00 Offset: 0x1B12500 VA: 0x181B13F00
	|-EnumHelper.Transformer<int, ulong>.BeginInvoke
	|
	|-RVA: 0x1B14F00 Offset: 0x1B13500 VA: 0x181B14F00
	|-EnumHelper.Transformer<int, UIntPtr>.BeginInvoke
	|
	|-RVA: 0x1B14980 Offset: 0x1B12F80 VA: 0x181B14980
	|-EnumHelper.Transformer<long, bool>.BeginInvoke
	|
	|-RVA: 0x1B15580 Offset: 0x1B13B80 VA: 0x181B15580
	|-EnumHelper.Transformer<long, byte>.BeginInvoke
	|
	|-RVA: 0x1B14400 Offset: 0x1B12A00 VA: 0x181B14400
	|-EnumHelper.Transformer<long, char>.BeginInvoke
	|
	|-RVA: 0x1B15080 Offset: 0x1B13680 VA: 0x181B15080
	|-EnumHelper.Transformer<long, KeyValuePair<object, object>>.BeginInvoke
	|
	|-RVA: 0x1B15A80 Offset: 0x1B14080 VA: 0x181B15A80
	|-EnumHelper.Transformer<long, DateTime>.BeginInvoke
	|
	|-RVA: 0x1B15680 Offset: 0x1B13C80 VA: 0x181B15680
	|-EnumHelper.Transformer<long, DateTimeOffset>.BeginInvoke
	|
	|-RVA: 0x1B14A80 Offset: 0x1B13080 VA: 0x181B14A80
	|-EnumHelper.Transformer<long, Decimal>.BeginInvoke
	|
	|-RVA: 0x213C7A0 Offset: 0x213ADA0 VA: 0x18213C7A0
	|-EnumHelper.Transformer<long, EmptyStruct>.BeginInvoke
	|
	|-RVA: 0x213C8A0 Offset: 0x213AEA0 VA: 0x18213C8A0
	|-EnumHelper.Transformer<long, double>.BeginInvoke
	|
	|-RVA: 0x213AA20 Offset: 0x2139020 VA: 0x18213AA20
	|-EnumHelper.Transformer<long, Guid>.BeginInvoke
	|
	|-RVA: 0x213C120 Offset: 0x213A720 VA: 0x18213C120
	|-EnumHelper.Transformer<long, short>.BeginInvoke
	|
	|-RVA: 0x213B720 Offset: 0x2139D20 VA: 0x18213B720
	|-EnumHelper.Transformer<long, int>.BeginInvoke
	|
	|-RVA: 0x213BDA0 Offset: 0x213A3A0 VA: 0x18213BDA0
	|-EnumHelper.Transformer<long, long>.BeginInvoke
	|
	|-RVA: 0x213B9A0 Offset: 0x2139FA0 VA: 0x18213B9A0
	|-EnumHelper.Transformer<long, IntPtr>.BeginInvoke
	|
	|-RVA: 0x213C4A0 Offset: 0x213AAA0 VA: 0x18213C4A0
	|-EnumHelper.Transformer<long, sbyte>.BeginInvoke
	|
	|-RVA: 0x213B620 Offset: 0x2139C20 VA: 0x18213B620
	|-EnumHelper.Transformer<long, float>.BeginInvoke
	|
	|-RVA: 0x213D820 Offset: 0x213BE20 VA: 0x18213D820
	|-EnumHelper.Transformer<long, TimeSpan>.BeginInvoke
	|
	|-RVA: 0x213B0A0 Offset: 0x21396A0 VA: 0x18213B0A0
	|-EnumHelper.Transformer<long, ushort>.BeginInvoke
	|
	|-RVA: 0x213C920 Offset: 0x213AF20 VA: 0x18213C920
	|-EnumHelper.Transformer<long, uint>.BeginInvoke
	|
	|-RVA: 0x213B920 Offset: 0x2139F20 VA: 0x18213B920
	|-EnumHelper.Transformer<long, ulong>.BeginInvoke
	|
	|-RVA: 0x213CB20 Offset: 0x213B120 VA: 0x18213CB20
	|-EnumHelper.Transformer<long, UIntPtr>.BeginInvoke
	|
	|-RVA: 0x213AEA0 Offset: 0x21394A0 VA: 0x18213AEA0
	|-EnumHelper.Transformer<sbyte, bool>.BeginInvoke
	|
	|-RVA: 0x213B6A0 Offset: 0x2139CA0 VA: 0x18213B6A0
	|-EnumHelper.Transformer<sbyte, byte>.BeginInvoke
	|
	|-RVA: 0x213B220 Offset: 0x2139820 VA: 0x18213B220
	|-EnumHelper.Transformer<sbyte, char>.BeginInvoke
	|
	|-RVA: 0x213CEA0 Offset: 0x213B4A0 VA: 0x18213CEA0
	|-EnumHelper.Transformer<sbyte, KeyValuePair<object, object>>.BeginInvoke
	|
	|-RVA: 0x213C520 Offset: 0x213AB20 VA: 0x18213C520
	|-EnumHelper.Transformer<sbyte, DateTime>.BeginInvoke
	|
	|-RVA: 0x213ADA0 Offset: 0x21393A0 VA: 0x18213ADA0
	|-EnumHelper.Transformer<sbyte, DateTimeOffset>.BeginInvoke
	|
	|-RVA: 0x213B820 Offset: 0x2139E20 VA: 0x18213B820
	|-EnumHelper.Transformer<sbyte, Decimal>.BeginInvoke
	|
	|-RVA: 0x213A920 Offset: 0x2138F20 VA: 0x18213A920
	|-EnumHelper.Transformer<sbyte, EmptyStruct>.BeginInvoke
	|
	|-RVA: 0x213CF20 Offset: 0x213B520 VA: 0x18213CF20
	|-EnumHelper.Transformer<sbyte, double>.BeginInvoke
	|
	|-RVA: 0x213CFA0 Offset: 0x213B5A0 VA: 0x18213CFA0
	|-EnumHelper.Transformer<sbyte, Guid>.BeginInvoke
	|
	|-RVA: 0x213B5A0 Offset: 0x2139BA0 VA: 0x18213B5A0
	|-EnumHelper.Transformer<sbyte, short>.BeginInvoke
	|
	|-RVA: 0x213C6A0 Offset: 0x213ACA0 VA: 0x18213C6A0
	|-EnumHelper.Transformer<sbyte, int>.BeginInvoke
	|
	|-RVA: 0x213CD20 Offset: 0x213B320 VA: 0x18213CD20
	|-EnumHelper.Transformer<sbyte, long>.BeginInvoke
	|
	|-RVA: 0x213BEA0 Offset: 0x213A4A0 VA: 0x18213BEA0
	|-EnumHelper.Transformer<sbyte, IntPtr>.BeginInvoke
	|
	|-RVA: 0x213CC20 Offset: 0x213B220 VA: 0x18213CC20
	|-EnumHelper.Transformer<sbyte, sbyte>.BeginInvoke
	|
	|-RVA: 0x213C5A0 Offset: 0x213ABA0 VA: 0x18213C5A0
	|-EnumHelper.Transformer<sbyte, float>.BeginInvoke
	|
	|-RVA: 0x213BFA0 Offset: 0x213A5A0 VA: 0x18213BFA0
	|-EnumHelper.Transformer<sbyte, TimeSpan>.BeginInvoke
	|
	|-RVA: 0x213D720 Offset: 0x213BD20 VA: 0x18213D720
	|-EnumHelper.Transformer<sbyte, ushort>.BeginInvoke
	|
	|-RVA: 0x213AC20 Offset: 0x2139220 VA: 0x18213AC20
	|-EnumHelper.Transformer<sbyte, uint>.BeginInvoke
	|
	|-RVA: 0x213A9A0 Offset: 0x2138FA0 VA: 0x18213A9A0
	|-EnumHelper.Transformer<sbyte, ulong>.BeginInvoke
	|
	|-RVA: 0x213A7A0 Offset: 0x2138DA0 VA: 0x18213A7A0
	|-EnumHelper.Transformer<sbyte, UIntPtr>.BeginInvoke
	|
	|-RVA: 0x213C420 Offset: 0x213AA20 VA: 0x18213C420
	|-EnumHelper.Transformer<ushort, bool>.BeginInvoke
	|
	|-RVA: 0x213BB20 Offset: 0x213A120 VA: 0x18213BB20
	|-EnumHelper.Transformer<ushort, byte>.BeginInvoke
	|
	|-RVA: 0x213C2A0 Offset: 0x213A8A0 VA: 0x18213C2A0
	|-EnumHelper.Transformer<ushort, char>.BeginInvoke
	|
	|-RVA: 0x213BBA0 Offset: 0x213A1A0 VA: 0x18213BBA0
	|-EnumHelper.Transformer<ushort, KeyValuePair<object, object>>.BeginInvoke
	|
	|-RVA: 0x213B020 Offset: 0x2139620 VA: 0x18213B020
	|-EnumHelper.Transformer<ushort, DateTime>.BeginInvoke
	|
	|-RVA: 0x213AD20 Offset: 0x2139320 VA: 0x18213AD20
	|-EnumHelper.Transformer<ushort, DateTimeOffset>.BeginInvoke
	|
	|-RVA: 0x213BCA0 Offset: 0x213A2A0 VA: 0x18213BCA0
	|-EnumHelper.Transformer<ushort, Decimal>.BeginInvoke
	|
	|-RVA: 0x213AB20 Offset: 0x2139120 VA: 0x18213AB20
	|-EnumHelper.Transformer<ushort, EmptyStruct>.BeginInvoke
	|
	|-RVA: 0x213C020 Offset: 0x213A620 VA: 0x18213C020
	|-EnumHelper.Transformer<ushort, double>.BeginInvoke
	|
	|-RVA: 0x213A820 Offset: 0x2138E20 VA: 0x18213A820
	|-EnumHelper.Transformer<ushort, Guid>.BeginInvoke
	|
	|-RVA: 0x213C620 Offset: 0x213AC20 VA: 0x18213C620
	|-EnumHelper.Transformer<ushort, short>.BeginInvoke
	|
	|-RVA: 0x213D520 Offset: 0x213BB20 VA: 0x18213D520
	|-EnumHelper.Transformer<ushort, int>.BeginInvoke
	|
	|-RVA: 0x213B320 Offset: 0x2139920 VA: 0x18213B320
	|-EnumHelper.Transformer<ushort, long>.BeginInvoke
	|
	|-RVA: 0x213A8A0 Offset: 0x2138EA0 VA: 0x18213A8A0
	|-EnumHelper.Transformer<ushort, IntPtr>.BeginInvoke
	|
	|-RVA: 0x213CAA0 Offset: 0x213B0A0 VA: 0x18213CAA0
	|-EnumHelper.Transformer<ushort, sbyte>.BeginInvoke
	|
	|-RVA: 0x213B2A0 Offset: 0x21398A0 VA: 0x18213B2A0
	|-EnumHelper.Transformer<ushort, float>.BeginInvoke
	|
	|-RVA: 0x213BD20 Offset: 0x213A320 VA: 0x18213BD20
	|-EnumHelper.Transformer<ushort, TimeSpan>.BeginInvoke
	|
	|-RVA: 0x213D0A0 Offset: 0x213B6A0 VA: 0x18213D0A0
	|-EnumHelper.Transformer<ushort, ushort>.BeginInvoke
	|
	|-RVA: 0x213BE20 Offset: 0x213A420 VA: 0x18213BE20
	|-EnumHelper.Transformer<ushort, uint>.BeginInvoke
	|
	|-RVA: 0x213B1A0 Offset: 0x21397A0 VA: 0x18213B1A0
	|-EnumHelper.Transformer<ushort, ulong>.BeginInvoke
	|
	|-RVA: 0x213BAA0 Offset: 0x213A0A0 VA: 0x18213BAA0
	|-EnumHelper.Transformer<ushort, UIntPtr>.BeginInvoke
	|
	|-RVA: 0x213C3A0 Offset: 0x213A9A0 VA: 0x18213C3A0
	|-EnumHelper.Transformer<uint, bool>.BeginInvoke
	|
	|-RVA: 0x213BF20 Offset: 0x213A520 VA: 0x18213BF20
	|-EnumHelper.Transformer<uint, byte>.BeginInvoke
	|
	|-RVA: 0x213D320 Offset: 0x213B920 VA: 0x18213D320
	|-EnumHelper.Transformer<uint, char>.BeginInvoke
	|
	|-RVA: 0x213C220 Offset: 0x213A820 VA: 0x18213C220
	|-EnumHelper.Transformer<uint, KeyValuePair<object, object>>.BeginInvoke
	|
	|-RVA: 0x213AF20 Offset: 0x2139520 VA: 0x18213AF20
	|-EnumHelper.Transformer<uint, DateTime>.BeginInvoke
	|
	|-RVA: 0x213B120 Offset: 0x2139720 VA: 0x18213B120
	|-EnumHelper.Transformer<uint, DateTimeOffset>.BeginInvoke
	|
	|-RVA: 0x213B420 Offset: 0x2139A20 VA: 0x18213B420
	|-EnumHelper.Transformer<uint, Decimal>.BeginInvoke
	|
	|-RVA: 0x213C9A0 Offset: 0x213AFA0 VA: 0x18213C9A0
	|-EnumHelper.Transformer<uint, EmptyStruct>.BeginInvoke
	|
	|-RVA: 0x213ABA0 Offset: 0x21391A0 VA: 0x18213ABA0
	|-EnumHelper.Transformer<uint, double>.BeginInvoke
	|
	|-RVA: 0x213CDA0 Offset: 0x213B3A0 VA: 0x18213CDA0
	|-EnumHelper.Transformer<uint, Guid>.BeginInvoke
	|
	|-RVA: 0x213BA20 Offset: 0x213A020 VA: 0x18213BA20
	|-EnumHelper.Transformer<uint, short>.BeginInvoke
	|
	|-RVA: 0x213B520 Offset: 0x2139B20 VA: 0x18213B520
	|-EnumHelper.Transformer<uint, int>.BeginInvoke
	|
	|-RVA: 0x213D3A0 Offset: 0x213B9A0 VA: 0x18213D3A0
	|-EnumHelper.Transformer<uint, long>.BeginInvoke
	|
	|-RVA: 0x213D120 Offset: 0x213B720 VA: 0x18213D120
	|-EnumHelper.Transformer<uint, IntPtr>.BeginInvoke
	|
	|-RVA: 0x213D6A0 Offset: 0x213BCA0 VA: 0x18213D6A0
	|-EnumHelper.Transformer<uint, sbyte>.BeginInvoke
	|
	|-RVA: 0x213C1A0 Offset: 0x213A7A0 VA: 0x18213C1A0
	|-EnumHelper.Transformer<uint, float>.BeginInvoke
	|
	|-RVA: 0x213D7A0 Offset: 0x213BDA0 VA: 0x18213D7A0
	|-EnumHelper.Transformer<uint, TimeSpan>.BeginInvoke
	|
	|-RVA: 0x213BC20 Offset: 0x213A220 VA: 0x18213BC20
	|-EnumHelper.Transformer<uint, ushort>.BeginInvoke
	|
	|-RVA: 0x213D4A0 Offset: 0x213BAA0 VA: 0x18213D4A0
	|-EnumHelper.Transformer<uint, uint>.BeginInvoke
	|
	|-RVA: 0x213CCA0 Offset: 0x213B2A0 VA: 0x18213CCA0
	|-EnumHelper.Transformer<uint, ulong>.BeginInvoke
	|
	|-RVA: 0x213D420 Offset: 0x213BA20 VA: 0x18213D420
	|-EnumHelper.Transformer<uint, UIntPtr>.BeginInvoke
	|
	|-RVA: 0x213D1A0 Offset: 0x213B7A0 VA: 0x18213D1A0
	|-EnumHelper.Transformer<ulong, bool>.BeginInvoke
	|
	|-RVA: 0x213D2A0 Offset: 0x213B8A0 VA: 0x18213D2A0
	|-EnumHelper.Transformer<ulong, byte>.BeginInvoke
	|
	|-RVA: 0x213D620 Offset: 0x213BC20 VA: 0x18213D620
	|-EnumHelper.Transformer<ulong, char>.BeginInvoke
	|
	|-RVA: 0x213C820 Offset: 0x213AE20 VA: 0x18213C820
	|-EnumHelper.Transformer<ulong, KeyValuePair<object, object>>.BeginInvoke
	|
	|-RVA: 0x213C0A0 Offset: 0x213A6A0 VA: 0x18213C0A0
	|-EnumHelper.Transformer<ulong, DateTime>.BeginInvoke
	|
	|-RVA: 0x213ACA0 Offset: 0x21392A0 VA: 0x18213ACA0
	|-EnumHelper.Transformer<ulong, DateTimeOffset>.BeginInvoke
	|
	|-RVA: 0x213B4A0 Offset: 0x2139AA0 VA: 0x18213B4A0
	|-EnumHelper.Transformer<ulong, Decimal>.BeginInvoke
	|
	|-RVA: 0x213C320 Offset: 0x213A920 VA: 0x18213C320
	|-EnumHelper.Transformer<ulong, EmptyStruct>.BeginInvoke
	|
	|-RVA: 0x213B8A0 Offset: 0x2139EA0 VA: 0x18213B8A0
	|-EnumHelper.Transformer<ulong, double>.BeginInvoke
	|
	|-RVA: 0x213AFA0 Offset: 0x21395A0 VA: 0x18213AFA0
	|-EnumHelper.Transformer<ulong, Guid>.BeginInvoke
	|
	|-RVA: 0x213D020 Offset: 0x213B620 VA: 0x18213D020
	|-EnumHelper.Transformer<ulong, short>.BeginInvoke
	|
	|-RVA: 0x213B3A0 Offset: 0x21399A0 VA: 0x18213B3A0
	|-EnumHelper.Transformer<ulong, int>.BeginInvoke
	|
	|-RVA: 0x213B7A0 Offset: 0x2139DA0 VA: 0x18213B7A0
	|-EnumHelper.Transformer<ulong, long>.BeginInvoke
	|
	|-RVA: 0x213CBA0 Offset: 0x213B1A0 VA: 0x18213CBA0
	|-EnumHelper.Transformer<ulong, IntPtr>.BeginInvoke
	|
	|-RVA: 0x213AAA0 Offset: 0x21390A0 VA: 0x18213AAA0
	|-EnumHelper.Transformer<ulong, sbyte>.BeginInvoke
	|
	|-RVA: 0x213CA20 Offset: 0x213B020 VA: 0x18213CA20
	|-EnumHelper.Transformer<ulong, float>.BeginInvoke
	|
	|-RVA: 0x213D220 Offset: 0x213B820 VA: 0x18213D220
	|-EnumHelper.Transformer<ulong, TimeSpan>.BeginInvoke
	|
	|-RVA: 0x213D5A0 Offset: 0x213BBA0 VA: 0x18213D5A0
	|-EnumHelper.Transformer<ulong, ushort>.BeginInvoke
	|
	|-RVA: 0x213AE20 Offset: 0x2139420 VA: 0x18213AE20
	|-EnumHelper.Transformer<ulong, uint>.BeginInvoke
	|
	|-RVA: 0x213C720 Offset: 0x213AD20 VA: 0x18213C720
	|-EnumHelper.Transformer<ulong, ulong>.BeginInvoke
	|
	|-RVA: 0x213CE20 Offset: 0x213B420 VA: 0x18213CE20
	|-EnumHelper.Transformer<ulong, UIntPtr>.BeginInvoke
	*/

	public virtual UnderlyingType EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFF6FF0 Offset: 0xFF55F0 VA: 0x180FF6FF0
	|-EnumHelper.Transformer<byte, bool>.EndInvoke
	|-EnumHelper.Transformer<byte, byte>.EndInvoke
	|-EnumHelper.Transformer<byte, char>.EndInvoke
	|-EnumHelper.Transformer<byte, KeyValuePair<object, object>>.EndInvoke
	|-EnumHelper.Transformer<byte, DateTime>.EndInvoke
	|-EnumHelper.Transformer<byte, DateTimeOffset>.EndInvoke
	|-EnumHelper.Transformer<byte, Decimal>.EndInvoke
	|-EnumHelper.Transformer<byte, EmptyStruct>.EndInvoke
	|-EnumHelper.Transformer<byte, double>.EndInvoke
	|-EnumHelper.Transformer<byte, Guid>.EndInvoke
	|-EnumHelper.Transformer<byte, short>.EndInvoke
	|-EnumHelper.Transformer<byte, int>.EndInvoke
	|-EnumHelper.Transformer<byte, long>.EndInvoke
	|-EnumHelper.Transformer<byte, IntPtr>.EndInvoke
	|-EnumHelper.Transformer<byte, object>.EndInvoke
	|-EnumHelper.Transformer<byte, sbyte>.EndInvoke
	|-EnumHelper.Transformer<byte, float>.EndInvoke
	|-EnumHelper.Transformer<byte, TimeSpan>.EndInvoke
	|-EnumHelper.Transformer<byte, ushort>.EndInvoke
	|-EnumHelper.Transformer<byte, uint>.EndInvoke
	|-EnumHelper.Transformer<byte, ulong>.EndInvoke
	|-EnumHelper.Transformer<byte, UIntPtr>.EndInvoke
	|-EnumHelper.Transformer<sbyte, bool>.EndInvoke
	|-EnumHelper.Transformer<sbyte, byte>.EndInvoke
	|-EnumHelper.Transformer<sbyte, char>.EndInvoke
	|-EnumHelper.Transformer<sbyte, KeyValuePair<object, object>>.EndInvoke
	|-EnumHelper.Transformer<sbyte, DateTime>.EndInvoke
	|-EnumHelper.Transformer<sbyte, DateTimeOffset>.EndInvoke
	|-EnumHelper.Transformer<sbyte, Decimal>.EndInvoke
	|-EnumHelper.Transformer<sbyte, EmptyStruct>.EndInvoke
	|-EnumHelper.Transformer<sbyte, double>.EndInvoke
	|-EnumHelper.Transformer<sbyte, Guid>.EndInvoke
	|-EnumHelper.Transformer<sbyte, short>.EndInvoke
	|-EnumHelper.Transformer<sbyte, int>.EndInvoke
	|-EnumHelper.Transformer<sbyte, long>.EndInvoke
	|-EnumHelper.Transformer<sbyte, IntPtr>.EndInvoke
	|-EnumHelper.Transformer<sbyte, object>.EndInvoke
	|-EnumHelper.Transformer<sbyte, sbyte>.EndInvoke
	|-EnumHelper.Transformer<sbyte, float>.EndInvoke
	|-EnumHelper.Transformer<sbyte, TimeSpan>.EndInvoke
	|-EnumHelper.Transformer<sbyte, ushort>.EndInvoke
	|-EnumHelper.Transformer<sbyte, uint>.EndInvoke
	|-EnumHelper.Transformer<sbyte, ulong>.EndInvoke
	|-EnumHelper.Transformer<sbyte, UIntPtr>.EndInvoke
	|
	|-RVA: 0xD985D0 Offset: 0xD96BD0 VA: 0x180D985D0
	|-EnumHelper.Transformer<short, bool>.EndInvoke
	|-EnumHelper.Transformer<short, byte>.EndInvoke
	|-EnumHelper.Transformer<short, char>.EndInvoke
	|-EnumHelper.Transformer<short, KeyValuePair<object, object>>.EndInvoke
	|-EnumHelper.Transformer<short, DateTime>.EndInvoke
	|-EnumHelper.Transformer<short, DateTimeOffset>.EndInvoke
	|-EnumHelper.Transformer<short, Decimal>.EndInvoke
	|-EnumHelper.Transformer<short, EmptyStruct>.EndInvoke
	|-EnumHelper.Transformer<short, double>.EndInvoke
	|-EnumHelper.Transformer<short, Guid>.EndInvoke
	|-EnumHelper.Transformer<short, short>.EndInvoke
	|-EnumHelper.Transformer<short, int>.EndInvoke
	|-EnumHelper.Transformer<short, long>.EndInvoke
	|-EnumHelper.Transformer<short, IntPtr>.EndInvoke
	|-EnumHelper.Transformer<short, object>.EndInvoke
	|-EnumHelper.Transformer<short, sbyte>.EndInvoke
	|-EnumHelper.Transformer<short, float>.EndInvoke
	|-EnumHelper.Transformer<short, TimeSpan>.EndInvoke
	|-EnumHelper.Transformer<short, ushort>.EndInvoke
	|-EnumHelper.Transformer<short, uint>.EndInvoke
	|-EnumHelper.Transformer<short, ulong>.EndInvoke
	|-EnumHelper.Transformer<short, UIntPtr>.EndInvoke
	|-EnumHelper.Transformer<ushort, bool>.EndInvoke
	|-EnumHelper.Transformer<ushort, byte>.EndInvoke
	|-EnumHelper.Transformer<ushort, char>.EndInvoke
	|-EnumHelper.Transformer<ushort, KeyValuePair<object, object>>.EndInvoke
	|-EnumHelper.Transformer<ushort, DateTime>.EndInvoke
	|-EnumHelper.Transformer<ushort, DateTimeOffset>.EndInvoke
	|-EnumHelper.Transformer<ushort, Decimal>.EndInvoke
	|-EnumHelper.Transformer<ushort, EmptyStruct>.EndInvoke
	|-EnumHelper.Transformer<ushort, double>.EndInvoke
	|-EnumHelper.Transformer<ushort, Guid>.EndInvoke
	|-EnumHelper.Transformer<ushort, short>.EndInvoke
	|-EnumHelper.Transformer<ushort, int>.EndInvoke
	|-EnumHelper.Transformer<ushort, long>.EndInvoke
	|-EnumHelper.Transformer<ushort, IntPtr>.EndInvoke
	|-EnumHelper.Transformer<ushort, object>.EndInvoke
	|-EnumHelper.Transformer<ushort, sbyte>.EndInvoke
	|-EnumHelper.Transformer<ushort, float>.EndInvoke
	|-EnumHelper.Transformer<ushort, TimeSpan>.EndInvoke
	|-EnumHelper.Transformer<ushort, ushort>.EndInvoke
	|-EnumHelper.Transformer<ushort, uint>.EndInvoke
	|-EnumHelper.Transformer<ushort, ulong>.EndInvoke
	|-EnumHelper.Transformer<ushort, UIntPtr>.EndInvoke
	|
	|-RVA: 0xB9AFE0 Offset: 0xB995E0 VA: 0x180B9AFE0
	|-EnumHelper.Transformer<int, bool>.EndInvoke
	|-EnumHelper.Transformer<int, byte>.EndInvoke
	|-EnumHelper.Transformer<int, char>.EndInvoke
	|-EnumHelper.Transformer<int, KeyValuePair<object, object>>.EndInvoke
	|-EnumHelper.Transformer<int, DateTime>.EndInvoke
	|-EnumHelper.Transformer<int, DateTimeOffset>.EndInvoke
	|-EnumHelper.Transformer<int, Decimal>.EndInvoke
	|-EnumHelper.Transformer<int, EmptyStruct>.EndInvoke
	|-EnumHelper.Transformer<int, double>.EndInvoke
	|-EnumHelper.Transformer<int, Guid>.EndInvoke
	|-EnumHelper.Transformer<int, short>.EndInvoke
	|-EnumHelper.Transformer<int, int>.EndInvoke
	|-EnumHelper.Transformer<int, long>.EndInvoke
	|-EnumHelper.Transformer<int, IntPtr>.EndInvoke
	|-EnumHelper.Transformer<int, object>.EndInvoke
	|-EnumHelper.Transformer<int, sbyte>.EndInvoke
	|-EnumHelper.Transformer<int, float>.EndInvoke
	|-EnumHelper.Transformer<int, TimeSpan>.EndInvoke
	|-EnumHelper.Transformer<int, ushort>.EndInvoke
	|-EnumHelper.Transformer<int, uint>.EndInvoke
	|-EnumHelper.Transformer<int, ulong>.EndInvoke
	|-EnumHelper.Transformer<int, UIntPtr>.EndInvoke
	|-EnumHelper.Transformer<uint, bool>.EndInvoke
	|-EnumHelper.Transformer<uint, byte>.EndInvoke
	|-EnumHelper.Transformer<uint, char>.EndInvoke
	|-EnumHelper.Transformer<uint, KeyValuePair<object, object>>.EndInvoke
	|-EnumHelper.Transformer<uint, DateTime>.EndInvoke
	|-EnumHelper.Transformer<uint, DateTimeOffset>.EndInvoke
	|-EnumHelper.Transformer<uint, Decimal>.EndInvoke
	|-EnumHelper.Transformer<uint, EmptyStruct>.EndInvoke
	|-EnumHelper.Transformer<uint, double>.EndInvoke
	|-EnumHelper.Transformer<uint, Guid>.EndInvoke
	|-EnumHelper.Transformer<uint, short>.EndInvoke
	|-EnumHelper.Transformer<uint, int>.EndInvoke
	|-EnumHelper.Transformer<uint, long>.EndInvoke
	|-EnumHelper.Transformer<uint, IntPtr>.EndInvoke
	|-EnumHelper.Transformer<uint, object>.EndInvoke
	|-EnumHelper.Transformer<uint, sbyte>.EndInvoke
	|-EnumHelper.Transformer<uint, float>.EndInvoke
	|-EnumHelper.Transformer<uint, TimeSpan>.EndInvoke
	|-EnumHelper.Transformer<uint, ushort>.EndInvoke
	|-EnumHelper.Transformer<uint, uint>.EndInvoke
	|-EnumHelper.Transformer<uint, ulong>.EndInvoke
	|-EnumHelper.Transformer<uint, UIntPtr>.EndInvoke
	|
	|-RVA: 0x1221D70 Offset: 0x1220370 VA: 0x181221D70
	|-EnumHelper.Transformer<long, bool>.EndInvoke
	|-EnumHelper.Transformer<long, byte>.EndInvoke
	|-EnumHelper.Transformer<long, char>.EndInvoke
	|-EnumHelper.Transformer<long, KeyValuePair<object, object>>.EndInvoke
	|-EnumHelper.Transformer<long, DateTime>.EndInvoke
	|-EnumHelper.Transformer<long, DateTimeOffset>.EndInvoke
	|-EnumHelper.Transformer<long, Decimal>.EndInvoke
	|-EnumHelper.Transformer<long, EmptyStruct>.EndInvoke
	|-EnumHelper.Transformer<long, double>.EndInvoke
	|-EnumHelper.Transformer<long, Guid>.EndInvoke
	|-EnumHelper.Transformer<long, short>.EndInvoke
	|-EnumHelper.Transformer<long, int>.EndInvoke
	|-EnumHelper.Transformer<long, long>.EndInvoke
	|-EnumHelper.Transformer<long, IntPtr>.EndInvoke
	|-EnumHelper.Transformer<long, object>.EndInvoke
	|-EnumHelper.Transformer<long, sbyte>.EndInvoke
	|-EnumHelper.Transformer<long, float>.EndInvoke
	|-EnumHelper.Transformer<long, TimeSpan>.EndInvoke
	|-EnumHelper.Transformer<long, ushort>.EndInvoke
	|-EnumHelper.Transformer<long, uint>.EndInvoke
	|-EnumHelper.Transformer<long, ulong>.EndInvoke
	|-EnumHelper.Transformer<long, UIntPtr>.EndInvoke
	|-EnumHelper.Transformer<ulong, bool>.EndInvoke
	|-EnumHelper.Transformer<ulong, byte>.EndInvoke
	|-EnumHelper.Transformer<ulong, char>.EndInvoke
	|-EnumHelper.Transformer<ulong, KeyValuePair<object, object>>.EndInvoke
	|-EnumHelper.Transformer<ulong, DateTime>.EndInvoke
	|-EnumHelper.Transformer<ulong, DateTimeOffset>.EndInvoke
	|-EnumHelper.Transformer<ulong, Decimal>.EndInvoke
	|-EnumHelper.Transformer<ulong, EmptyStruct>.EndInvoke
	|-EnumHelper.Transformer<ulong, double>.EndInvoke
	|-EnumHelper.Transformer<ulong, Guid>.EndInvoke
	|-EnumHelper.Transformer<ulong, short>.EndInvoke
	|-EnumHelper.Transformer<ulong, int>.EndInvoke
	|-EnumHelper.Transformer<ulong, long>.EndInvoke
	|-EnumHelper.Transformer<ulong, IntPtr>.EndInvoke
	|-EnumHelper.Transformer<ulong, object>.EndInvoke
	|-EnumHelper.Transformer<ulong, sbyte>.EndInvoke
	|-EnumHelper.Transformer<ulong, float>.EndInvoke
	|-EnumHelper.Transformer<ulong, TimeSpan>.EndInvoke
	|-EnumHelper.Transformer<ulong, ushort>.EndInvoke
	|-EnumHelper.Transformer<ulong, uint>.EndInvoke
	|-EnumHelper.Transformer<ulong, ulong>.EndInvoke
	|-EnumHelper.Transformer<ulong, UIntPtr>.EndInvoke
	|
	|-RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0
	|-EnumHelper.Transformer<object, object>.EndInvoke
	*/

}

private static class EnumHelper.Caster<UnderlyingType, ValueType> // TypeDefIndex: 1513
{	public static readonly EnumHelper.Transformer<UnderlyingType, ValueType> Instance; // 0x0


	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AFC200 Offset: 0x1AFA800 VA: 0x181AFC200
	|-EnumHelper.Caster<byte, bool>..cctor
	|
	|-RVA: 0x1AF75B0 Offset: 0x1AF5BB0 VA: 0x181AF75B0
	|-EnumHelper.Caster<byte, byte>..cctor
	|
	|-RVA: 0x1B009B0 Offset: 0x1AFEFB0 VA: 0x181B009B0
	|-EnumHelper.Caster<byte, char>..cctor
	|
	|-RVA: 0x1B04CC0 Offset: 0x1B032C0 VA: 0x181B04CC0
	|-EnumHelper.Caster<byte, KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x1AFE950 Offset: 0x1AFCF50 VA: 0x181AFE950
	|-EnumHelper.Caster<byte, DateTime>..cctor
	|
	|-RVA: 0x1B06AD0 Offset: 0x1B050D0 VA: 0x181B06AD0
	|-EnumHelper.Caster<byte, DateTimeOffset>..cctor
	|
	|-RVA: 0x1B0B280 Offset: 0x1B09880 VA: 0x181B0B280
	|-EnumHelper.Caster<byte, Decimal>..cctor
	|
	|-RVA: 0x1AFF4E0 Offset: 0x1AFDAE0 VA: 0x181AFF4E0
	|-EnumHelper.Caster<byte, EmptyStruct>..cctor
	|
	|-RVA: 0x1B0EA00 Offset: 0x1B0D000 VA: 0x181B0EA00
	|-EnumHelper.Caster<byte, double>..cctor
	|
	|-RVA: 0x1B0F590 Offset: 0x1B0DB90 VA: 0x181B0F590
	|-EnumHelper.Caster<byte, Guid>..cctor
	|
	|-RVA: 0x1AF7110 Offset: 0x1AF5710 VA: 0x181AF7110
	|-EnumHelper.Caster<byte, short>..cctor
	|
	|-RVA: 0x1AFC450 Offset: 0x1AFAA50 VA: 0x181AFC450
	|-EnumHelper.Caster<byte, int>..cctor
	|
	|-RVA: 0x1AFEBA0 Offset: 0x1AFD1A0 VA: 0x181AFEBA0
	|-EnumHelper.Caster<byte, long>..cctor
	|
	|-RVA: 0x1B03EE0 Offset: 0x1B024E0 VA: 0x181B03EE0
	|-EnumHelper.Caster<byte, IntPtr>..cctor
	|
	|-RVA: 0x1B0E7B0 Offset: 0x1B0CDB0 VA: 0x181B0E7B0
	|-EnumHelper.Caster<byte, object>..cctor
	|
	|-RVA: 0x1B078B0 Offset: 0x1B05EB0 VA: 0x181B078B0
	|-EnumHelper.Caster<byte, sbyte>..cctor
	|
	|-RVA: 0x1B02EB0 Offset: 0x1B014B0 VA: 0x181B02EB0
	|-EnumHelper.Caster<byte, float>..cctor
	|
	|-RVA: 0x1AFA890 Offset: 0x1AF8E90 VA: 0x181AFA890
	|-EnumHelper.Caster<byte, TimeSpan>..cctor
	|
	|-RVA: 0x1AFBFB0 Offset: 0x1AFA5B0 VA: 0x181AFBFB0
	|-EnumHelper.Caster<byte, ushort>..cctor
	|
	|-RVA: 0x1AFE700 Offset: 0x1AFCD00 VA: 0x181AFE700
	|-EnumHelper.Caster<byte, uint>..cctor
	|
	|-RVA: 0x1B0C060 Offset: 0x1B0A660 VA: 0x181B0C060
	|-EnumHelper.Caster<byte, ulong>..cctor
	|
	|-RVA: 0x1AFD230 Offset: 0x1AFB830 VA: 0x181AFD230
	|-EnumHelper.Caster<byte, UIntPtr>..cctor
	|
	|-RVA: 0x1B0D9D0 Offset: 0x1B0BFD0 VA: 0x181B0D9D0
	|-EnumHelper.Caster<short, bool>..cctor
	|
	|-RVA: 0x1AF8830 Offset: 0x1AF6E30 VA: 0x181AF8830
	|-EnumHelper.Caster<short, byte>..cctor
	|
	|-RVA: 0x1AF8390 Offset: 0x1AF6990 VA: 0x181AF8390
	|-EnumHelper.Caster<short, char>..cctor
	|
	|-RVA: 0x1B01C30 Offset: 0x1B00230 VA: 0x181B01C30
	|-EnumHelper.Caster<short, KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x1B012F0 Offset: 0x1AFF8F0 VA: 0x181B012F0
	|-EnumHelper.Caster<short, DateTime>..cctor
	|
	|-RVA: 0x1B07410 Offset: 0x1B05A10 VA: 0x181B07410
	|-EnumHelper.Caster<short, DateTimeOffset>..cctor
	|
	|-RVA: 0x1AFB420 Offset: 0x1AF9A20 VA: 0x181AFB420
	|-EnumHelper.Caster<short, Decimal>..cctor
	|
	|-RVA: 0x1B0B720 Offset: 0x1B09D20 VA: 0x181B0B720
	|-EnumHelper.Caster<short, EmptyStruct>..cctor
	|
	|-RVA: 0x1AFA3F0 Offset: 0x1AF89F0 VA: 0x181AFA3F0
	|-EnumHelper.Caster<short, double>..cctor
	|
	|-RVA: 0x1B06630 Offset: 0x1B04C30 VA: 0x181B06630
	|-EnumHelper.Caster<short, Guid>..cctor
	|
	|-RVA: 0x1B05CF0 Offset: 0x1B042F0 VA: 0x181B05CF0
	|-EnumHelper.Caster<short, short>..cctor
	|
	|-RVA: 0x1B00C00 Offset: 0x1AFF200 VA: 0x181B00C00
	|-EnumHelper.Caster<short, int>..cctor
	|
	|-RVA: 0x1AFD480 Offset: 0x1AFBA80 VA: 0x181AFD480
	|-EnumHelper.Caster<short, long>..cctor
	|
	|-RVA: 0x1B08440 Offset: 0x1B06A40 VA: 0x181B08440
	|-EnumHelper.Caster<short, IntPtr>..cctor
	|
	|-RVA: 0x1B020D0 Offset: 0x1B006D0 VA: 0x181B020D0
	|-EnumHelper.Caster<short, object>..cctor
	|
	|-RVA: 0x1B037F0 Offset: 0x1B01DF0 VA: 0x181B037F0
	|-EnumHelper.Caster<short, sbyte>..cctor
	|
	|-RVA: 0x1B09910 Offset: 0x1B07F10 VA: 0x181B09910
	|-EnumHelper.Caster<short, float>..cctor
	|
	|-RVA: 0x1B096C0 Offset: 0x1B07CC0 VA: 0x181B096C0
	|-EnumHelper.Caster<short, TimeSpan>..cctor
	|
	|-RVA: 0x1B0CE40 Offset: 0x1B0B440 VA: 0x181B0CE40
	|-EnumHelper.Caster<short, ushort>..cctor
	|
	|-RVA: 0x1AFBD60 Offset: 0x1AFA360 VA: 0x181AFBD60
	|-EnumHelper.Caster<short, uint>..cctor
	|
	|-RVA: 0x1AFDDC0 Offset: 0x1AFC3C0 VA: 0x181AFDDC0
	|-EnumHelper.Caster<short, ulong>..cctor
	|
	|-RVA: 0x1B09DB0 Offset: 0x1B083B0 VA: 0x181B09DB0
	|-EnumHelper.Caster<short, UIntPtr>..cctor
	|
	|-RVA: 0x1AF60E0 Offset: 0x1AF46E0 VA: 0x181AF60E0
	|-EnumHelper.Caster<int, bool>..cctor
	|
	|-RVA: 0x1AF93C0 Offset: 0x1AF79C0 VA: 0x181AF93C0
	|-EnumHelper.Caster<int, byte>..cctor
	|
	|-RVA: 0x1AF8F20 Offset: 0x1AF7520 VA: 0x181AF8F20
	|-EnumHelper.Caster<int, char>..cctor
	|
	|-RVA: 0x1B0A940 Offset: 0x1B08F40 VA: 0x181B0A940
	|-EnumHelper.Caster<int, KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x1B081F0 Offset: 0x1B067F0 VA: 0x181B081F0
	|-EnumHelper.Caster<int, DateTime>..cctor
	|
	|-RVA: 0x1AFF040 Offset: 0x1AFD640 VA: 0x181AFF040
	|-EnumHelper.Caster<int, DateTimeOffset>..cctor
	|
	|-RVA: 0x1B04820 Offset: 0x1B02E20 VA: 0x181B04820
	|-EnumHelper.Caster<int, Decimal>..cctor
	|
	|-RVA: 0x1B063E0 Offset: 0x1B049E0 VA: 0x181B063E0
	|-EnumHelper.Caster<int, EmptyStruct>..cctor
	|
	|-RVA: 0x1AF9F50 Offset: 0x1AF8550 VA: 0x181AF9F50
	|-EnumHelper.Caster<int, double>..cctor
	|
	|-RVA: 0x1AF6A20 Offset: 0x1AF5020 VA: 0x181AF6A20
	|-EnumHelper.Caster<int, Guid>..cctor
	|
	|-RVA: 0x1AFD920 Offset: 0x1AFBF20 VA: 0x181AFD920
	|-EnumHelper.Caster<int, short>..cctor
	|
	|-RVA: 0x1AF85E0 Offset: 0x1AF6BE0 VA: 0x181AF85E0
	|-EnumHelper.Caster<int, int>..cctor
	|
	|-RVA: 0x1B0ADE0 Offset: 0x1B093E0 VA: 0x181B0ADE0
	|-EnumHelper.Caster<int, long>..cctor
	|
	|-RVA: 0x1AF67D0 Offset: 0x1AF4DD0 VA: 0x181AF67D0
	|-EnumHelper.Caster<int, IntPtr>..cctor
	|
	|-RVA: 0x1B0B4D0 Offset: 0x1B09AD0 VA: 0x181B0B4D0
	|-EnumHelper.Caster<int, object>..cctor
	|
	|-RVA: 0x1B08FD0 Offset: 0x1B075D0 VA: 0x181B08FD0
	|-EnumHelper.Caster<int, sbyte>..cctor
	|
	|-RVA: 0x1AFB670 Offset: 0x1AF9C70 VA: 0x181AFB670
	|-EnumHelper.Caster<int, float>..cctor
	|
	|-RVA: 0x1B06D20 Offset: 0x1B05320 VA: 0x181B06D20
	|-EnumHelper.Caster<int, TimeSpan>..cctor
	|
	|-RVA: 0x1B0E560 Offset: 0x1B0CB60 VA: 0x181B0E560
	|-EnumHelper.Caster<int, ushort>..cctor
	|
	|-RVA: 0x1B01540 Offset: 0x1AFFB40 VA: 0x181B01540
	|-EnumHelper.Caster<int, uint>..cctor
	|
	|-RVA: 0x1AF8CD0 Offset: 0x1AF72D0 VA: 0x181AF8CD0
	|-EnumHelper.Caster<int, ulong>..cctor
	|
	|-RVA: 0x1B08690 Offset: 0x1B06C90 VA: 0x181B08690
	|-EnumHelper.Caster<int, UIntPtr>..cctor
	|
	|-RVA: 0x1B04380 Offset: 0x1B02980 VA: 0x181B04380
	|-EnumHelper.Caster<long, bool>..cctor
	|
	|-RVA: 0x1B00070 Offset: 0x1AFE670 VA: 0x181B00070
	|-EnumHelper.Caster<long, byte>..cctor
	|
	|-RVA: 0x1B03A40 Offset: 0x1B02040 VA: 0x181B03A40
	|-EnumHelper.Caster<long, char>..cctor
	|
	|-RVA: 0x1AF9610 Offset: 0x1AF7C10 VA: 0x181AF9610
	|-EnumHelper.Caster<long, KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x1AFAAE0 Offset: 0x1AF90E0 VA: 0x181AFAAE0
	|-EnumHelper.Caster<long, DateTime>..cctor
	|
	|-RVA: 0x1B01E80 Offset: 0x1B00480 VA: 0x181B01E80
	|-EnumHelper.Caster<long, DateTimeOffset>..cctor
	|
	|-RVA: 0x1B002C0 Offset: 0x1AFE8C0 VA: 0x181B002C0
	|-EnumHelper.Caster<long, Decimal>..cctor
	|
	|-RVA: 0x1B09220 Offset: 0x1B07820 VA: 0x181B09220
	|-EnumHelper.Caster<long, EmptyStruct>..cctor
	|
	|-RVA: 0x1AF6C70 Offset: 0x1AF5270 VA: 0x181AF6C70
	|-EnumHelper.Caster<long, double>..cctor
	|
	|-RVA: 0x1AFF730 Offset: 0x1AFDD30 VA: 0x181AFF730
	|-EnumHelper.Caster<long, Guid>..cctor
	|
	|-RVA: 0x1B0A6F0 Offset: 0x1B08CF0 VA: 0x181B0A6F0
	|-EnumHelper.Caster<long, short>..cctor
	|
	|-RVA: 0x1B00760 Offset: 0x1AFED60 VA: 0x181B00760
	|-EnumHelper.Caster<long, int>..cctor
	|
	|-RVA: 0x1AFE260 Offset: 0x1AFC860 VA: 0x181AFE260
	|-EnumHelper.Caster<long, long>..cctor
	|
	|-RVA: 0x1B0F340 Offset: 0x1B0D940 VA: 0x181B0F340
	|-EnumHelper.Caster<long, IntPtr>..cctor
	|
	|-RVA: 0x1AF9170 Offset: 0x1AF7770 VA: 0x181AF9170
	|-EnumHelper.Caster<long, object>..cctor
	|
	|-RVA: 0x1B0C2B0 Offset: 0x1B0A8B0 VA: 0x181B0C2B0
	|-EnumHelper.Caster<long, sbyte>..cctor
	|
	|-RVA: 0x1AF9AB0 Offset: 0x1AF80B0 VA: 0x181AF9AB0
	|-EnumHelper.Caster<long, float>..cctor
	|
	|-RVA: 0x1AF7CA0 Offset: 0x1AF62A0 VA: 0x181AF7CA0
	|-EnumHelper.Caster<long, TimeSpan>..cctor
	|
	|-RVA: 0x1B05AA0 Offset: 0x1B040A0 VA: 0x181B05AA0
	|-EnumHelper.Caster<long, ushort>..cctor
	|
	|-RVA: 0x1B02A10 Offset: 0x1B01010 VA: 0x181B02A10
	|-EnumHelper.Caster<long, uint>..cctor
	|
	|-RVA: 0x1B0DC20 Offset: 0x1B0C220 VA: 0x181B0DC20
	|-EnumHelper.Caster<long, ulong>..cctor
	|
	|-RVA: 0x1B03100 Offset: 0x1B01700 VA: 0x181B03100
	|-EnumHelper.Caster<long, UIntPtr>..cctor
	|
	|-RVA: 0x1B06190 Offset: 0x1B04790 VA: 0x181B06190
	|-EnumHelper.Caster<object, object>..cctor
	|
	|-RVA: 0x1AFB8C0 Offset: 0x1AF9EC0 VA: 0x181AFB8C0
	|-EnumHelper.Caster<sbyte, bool>..cctor
	|
	|-RVA: 0x1B0EEA0 Offset: 0x1B0D4A0 VA: 0x181B0EEA0
	|-EnumHelper.Caster<sbyte, byte>..cctor
	|
	|-RVA: 0x1AF7A50 Offset: 0x1AF6050 VA: 0x181AF7A50
	|-EnumHelper.Caster<sbyte, char>..cctor
	|
	|-RVA: 0x1B0AB90 Offset: 0x1B09190 VA: 0x181B0AB90
	|-EnumHelper.Caster<sbyte, KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x1AFB1D0 Offset: 0x1AF97D0 VA: 0x181AFB1D0
	|-EnumHelper.Caster<sbyte, DateTime>..cctor
	|
	|-RVA: 0x1AFC6A0 Offset: 0x1AFACA0 VA: 0x181AFC6A0
	|-EnumHelper.Caster<sbyte, DateTimeOffset>..cctor
	|
	|-RVA: 0x1AFCD90 Offset: 0x1AFB390 VA: 0x181AFCD90
	|-EnumHelper.Caster<sbyte, Decimal>..cctor
	|
	|-RVA: 0x1AF6EC0 Offset: 0x1AF54C0 VA: 0x181AF6EC0
	|-EnumHelper.Caster<sbyte, EmptyStruct>..cctor
	|
	|-RVA: 0x1B04130 Offset: 0x1B02730 VA: 0x181B04130
	|-EnumHelper.Caster<sbyte, double>..cctor
	|
	|-RVA: 0x1B05160 Offset: 0x1B03760 VA: 0x181B05160
	|-EnumHelper.Caster<sbyte, Guid>..cctor
	|
	|-RVA: 0x1B0A250 Offset: 0x1B08850 VA: 0x181B0A250
	|-EnumHelper.Caster<sbyte, short>..cctor
	|
	|-RVA: 0x1B0C9A0 Offset: 0x1B0AFA0 VA: 0x181B0C9A0
	|-EnumHelper.Caster<sbyte, int>..cctor
	|
	|-RVA: 0x1AFDB70 Offset: 0x1AFC170 VA: 0x181AFDB70
	|-EnumHelper.Caster<sbyte, long>..cctor
	|
	|-RVA: 0x1B0A000 Offset: 0x1B08600 VA: 0x181B0A000
	|-EnumHelper.Caster<sbyte, IntPtr>..cctor
	|
	|-RVA: 0x1B04F10 Offset: 0x1B03510 VA: 0x181B04F10
	|-EnumHelper.Caster<sbyte, object>..cctor
	|
	|-RVA: 0x1B0D090 Offset: 0x1B0B690 VA: 0x181B0D090
	|-EnumHelper.Caster<sbyte, sbyte>..cctor
	|
	|-RVA: 0x1B07FA0 Offset: 0x1B065A0 VA: 0x181B07FA0
	|-EnumHelper.Caster<sbyte, float>..cctor
	|
	|-RVA: 0x1B00E50 Offset: 0x1AFF450 VA: 0x181B00E50
	|-EnumHelper.Caster<sbyte, TimeSpan>..cctor
	|
	|-RVA: 0x1AFAD30 Offset: 0x1AF9330 VA: 0x181AFAD30
	|-EnumHelper.Caster<sbyte, ushort>..cctor
	|
	|-RVA: 0x1B0B030 Offset: 0x1B09630 VA: 0x181B0B030
	|-EnumHelper.Caster<sbyte, uint>..cctor
	|
	|-RVA: 0x1B053B0 Offset: 0x1B039B0 VA: 0x181B053B0
	|-EnumHelper.Caster<sbyte, ulong>..cctor
	|
	|-RVA: 0x1AF7EF0 Offset: 0x1AF64F0 VA: 0x181AF7EF0
	|-EnumHelper.Caster<sbyte, UIntPtr>..cctor
	|
	|-RVA: 0x1B09470 Offset: 0x1B07A70 VA: 0x181B09470
	|-EnumHelper.Caster<ushort, bool>..cctor
	|
	|-RVA: 0x1B06F70 Offset: 0x1B05570 VA: 0x181B06F70
	|-EnumHelper.Caster<ushort, byte>..cctor
	|
	|-RVA: 0x1B019E0 Offset: 0x1AFFFE0 VA: 0x181B019E0
	|-EnumHelper.Caster<ushort, char>..cctor
	|
	|-RVA: 0x1B07B00 Offset: 0x1B06100 VA: 0x181B07B00
	|-EnumHelper.Caster<ushort, KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x1B0E0C0 Offset: 0x1B0C6C0 VA: 0x181B0E0C0
	|-EnumHelper.Caster<ushort, DateTime>..cctor
	|
	|-RVA: 0x1B0B970 Offset: 0x1B09F70 VA: 0x181B0B970
	|-EnumHelper.Caster<ushort, DateTimeOffset>..cctor
	|
	|-RVA: 0x1B0C500 Offset: 0x1B0AB00 VA: 0x181B0C500
	|-EnumHelper.Caster<ushort, Decimal>..cctor
	|
	|-RVA: 0x1AFD6D0 Offset: 0x1AFBCD0 VA: 0x181AFD6D0
	|-EnumHelper.Caster<ushort, EmptyStruct>..cctor
	|
	|-RVA: 0x1B027C0 Offset: 0x1B00DC0 VA: 0x181B027C0
	|-EnumHelper.Caster<ushort, double>..cctor
	|
	|-RVA: 0x1B02570 Offset: 0x1B00B70 VA: 0x181B02570
	|-EnumHelper.Caster<ushort, Guid>..cctor
	|
	|-RVA: 0x1B05850 Offset: 0x1B03E50 VA: 0x181B05850
	|-EnumHelper.Caster<ushort, short>..cctor
	|
	|-RVA: 0x1B08B30 Offset: 0x1B07130 VA: 0x181B08B30
	|-EnumHelper.Caster<ushort, int>..cctor
	|
	|-RVA: 0x1B01790 Offset: 0x1AFFD90 VA: 0x181B01790
	|-EnumHelper.Caster<ushort, long>..cctor
	|
	|-RVA: 0x1B02320 Offset: 0x1B00920 VA: 0x181B02320
	|-EnumHelper.Caster<ushort, IntPtr>..cctor
	|
	|-RVA: 0x1B06880 Offset: 0x1B04E80 VA: 0x181B06880
	|-EnumHelper.Caster<ushort, object>..cctor
	|
	|-RVA: 0x1B07660 Offset: 0x1B05C60 VA: 0x181B07660
	|-EnumHelper.Caster<ushort, sbyte>..cctor
	|
	|-RVA: 0x1AFFBD0 Offset: 0x1AFE1D0 VA: 0x181AFFBD0
	|-EnumHelper.Caster<ushort, float>..cctor
	|
	|-RVA: 0x1B0A4A0 Offset: 0x1B08AA0 VA: 0x181B0A4A0
	|-EnumHelper.Caster<ushort, TimeSpan>..cctor
	|
	|-RVA: 0x1AFE010 Offset: 0x1AFC610 VA: 0x181AFE010
	|-EnumHelper.Caster<ushort, ushort>..cctor
	|
	|-RVA: 0x1AFC8F0 Offset: 0x1AFAEF0 VA: 0x181AFC8F0
	|-EnumHelper.Caster<ushort, uint>..cctor
	|
	|-RVA: 0x1B05F40 Offset: 0x1B04540 VA: 0x181B05F40
	|-EnumHelper.Caster<ushort, ulong>..cctor
	|
	|-RVA: 0x1B035A0 Offset: 0x1B01BA0 VA: 0x181B035A0
	|-EnumHelper.Caster<ushort, UIntPtr>..cctor
	|
	|-RVA: 0x1AF6330 Offset: 0x1AF4930 VA: 0x181AF6330
	|-EnumHelper.Caster<uint, bool>..cctor
	|
	|-RVA: 0x1AFCFE0 Offset: 0x1AFB5E0 VA: 0x181AFCFE0
	|-EnumHelper.Caster<uint, byte>..cctor
	|
	|-RVA: 0x1AF9D00 Offset: 0x1AF8300 VA: 0x181AF9D00
	|-EnumHelper.Caster<uint, char>..cctor
	|
	|-RVA: 0x1B04A70 Offset: 0x1B03070 VA: 0x181B04A70
	|-EnumHelper.Caster<uint, KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x1B0F7E0 Offset: 0x1B0DDE0 VA: 0x181B0F7E0
	|-EnumHelper.Caster<uint, DateTime>..cctor
	|
	|-RVA: 0x1B0C750 Offset: 0x1B0AD50 VA: 0x181B0C750
	|-EnumHelper.Caster<uint, DateTimeOffset>..cctor
	|
	|-RVA: 0x1AFF980 Offset: 0x1AFDF80 VA: 0x181AFF980
	|-EnumHelper.Caster<uint, Decimal>..cctor
	|
	|-RVA: 0x1B0F0F0 Offset: 0x1B0D6F0 VA: 0x181B0F0F0
	|-EnumHelper.Caster<uint, EmptyStruct>..cctor
	|
	|-RVA: 0x1AFFE20 Offset: 0x1AFE420 VA: 0x181AFFE20
	|-EnumHelper.Caster<uint, double>..cctor
	|
	|-RVA: 0x1AFEDF0 Offset: 0x1AFD3F0 VA: 0x181AFEDF0
	|-EnumHelper.Caster<uint, Guid>..cctor
	|
	|-RVA: 0x1AF7360 Offset: 0x1AF5960 VA: 0x181AF7360
	|-EnumHelper.Caster<uint, short>..cctor
	|
	|-RVA: 0x1AFAF80 Offset: 0x1AF9580 VA: 0x181AFAF80
	|-EnumHelper.Caster<uint, int>..cctor
	|
	|-RVA: 0x1B00510 Offset: 0x1AFEB10 VA: 0x181B00510
	|-EnumHelper.Caster<uint, long>..cctor
	|
	|-RVA: 0x1B045D0 Offset: 0x1B02BD0 VA: 0x181B045D0
	|-EnumHelper.Caster<uint, IntPtr>..cctor
	|
	|-RVA: 0x1B0BE10 Offset: 0x1B0A410 VA: 0x181B0BE10
	|-EnumHelper.Caster<uint, object>..cctor
	|
	|-RVA: 0x1AF8140 Offset: 0x1AF6740 VA: 0x181AF8140
	|-EnumHelper.Caster<uint, sbyte>..cctor
	|
	|-RVA: 0x1B0DE70 Offset: 0x1B0C470 VA: 0x181B0DE70
	|-EnumHelper.Caster<uint, float>..cctor
	|
	|-RVA: 0x1AFA1A0 Offset: 0x1AF87A0 VA: 0x181AFA1A0
	|-EnumHelper.Caster<uint, TimeSpan>..cctor
	|
	|-RVA: 0x1AFE4B0 Offset: 0x1AFCAB0 VA: 0x181AFE4B0
	|-EnumHelper.Caster<uint, ushort>..cctor
	|
	|-RVA: 0x1AF6580 Offset: 0x1AF4B80 VA: 0x181AF6580
	|-EnumHelper.Caster<uint, uint>..cctor
	|
	|-RVA: 0x1AF7800 Offset: 0x1AF5E00 VA: 0x181AF7800
	|-EnumHelper.Caster<uint, ulong>..cctor
	|
	|-RVA: 0x1AFA640 Offset: 0x1AF8C40 VA: 0x181AFA640
	|-EnumHelper.Caster<uint, UIntPtr>..cctor
	|
	|-RVA: 0x1B0D780 Offset: 0x1B0BD80 VA: 0x181B0D780
	|-EnumHelper.Caster<ulong, bool>..cctor
	|
	|-RVA: 0x1B0BBC0 Offset: 0x1B0A1C0 VA: 0x181B0BBC0
	|-EnumHelper.Caster<ulong, byte>..cctor
	|
	|-RVA: 0x1B0D2E0 Offset: 0x1B0B8E0 VA: 0x181B0D2E0
	|-EnumHelper.Caster<ulong, char>..cctor
	|
	|-RVA: 0x1B088E0 Offset: 0x1B06EE0 VA: 0x181B088E0
	|-EnumHelper.Caster<ulong, KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x1AFF290 Offset: 0x1AFD890 VA: 0x181AFF290
	|-EnumHelper.Caster<ulong, DateTime>..cctor
	|
	|-RVA: 0x1B07D50 Offset: 0x1B06350 VA: 0x181B07D50
	|-EnumHelper.Caster<ulong, DateTimeOffset>..cctor
	|
	|-RVA: 0x1B05600 Offset: 0x1B03C00 VA: 0x181B05600
	|-EnumHelper.Caster<ulong, Decimal>..cctor
	|
	|-RVA: 0x1AF8A80 Offset: 0x1AF7080 VA: 0x181AF8A80
	|-EnumHelper.Caster<ulong, EmptyStruct>..cctor
	|
	|-RVA: 0x1B0CBF0 Offset: 0x1B0B1F0 VA: 0x181B0CBF0
	|-EnumHelper.Caster<ulong, double>..cctor
	|
	|-RVA: 0x1AF9860 Offset: 0x1AF7E60 VA: 0x181AF9860
	|-EnumHelper.Caster<ulong, Guid>..cctor
	|
	|-RVA: 0x1B09B60 Offset: 0x1B08160 VA: 0x181B09B60
	|-EnumHelper.Caster<ulong, short>..cctor
	|
	|-RVA: 0x1B0D530 Offset: 0x1B0BB30 VA: 0x181B0D530
	|-EnumHelper.Caster<ulong, int>..cctor
	|
	|-RVA: 0x1AFCB40 Offset: 0x1AFB140 VA: 0x181AFCB40
	|-EnumHelper.Caster<ulong, long>..cctor
	|
	|-RVA: 0x1B071C0 Offset: 0x1B057C0 VA: 0x181B071C0
	|-EnumHelper.Caster<ulong, IntPtr>..cctor
	|
	|-RVA: 0x1B03350 Offset: 0x1B01950 VA: 0x181B03350
	|-EnumHelper.Caster<ulong, object>..cctor
	|
	|-RVA: 0x1B0EC50 Offset: 0x1B0D250 VA: 0x181B0EC50
	|-EnumHelper.Caster<ulong, sbyte>..cctor
	|
	|-RVA: 0x1AFBB10 Offset: 0x1AFA110 VA: 0x181AFBB10
	|-EnumHelper.Caster<ulong, float>..cctor
	|
	|-RVA: 0x1B010A0 Offset: 0x1AFF6A0 VA: 0x181B010A0
	|-EnumHelper.Caster<ulong, TimeSpan>..cctor
	|
	|-RVA: 0x1B03C90 Offset: 0x1B02290 VA: 0x181B03C90
	|-EnumHelper.Caster<ulong, ushort>..cctor
	|
	|-RVA: 0x1B08D80 Offset: 0x1B07380 VA: 0x181B08D80
	|-EnumHelper.Caster<ulong, uint>..cctor
	|
	|-RVA: 0x1B0E310 Offset: 0x1B0C910 VA: 0x181B0E310
	|-EnumHelper.Caster<ulong, ulong>..cctor
	|
	|-RVA: 0x1B02C60 Offset: 0x1B01260 VA: 0x181B02C60
	|-EnumHelper.Caster<ulong, UIntPtr>..cctor
	*/

}

internal sealed class EnumerableTypeInfo<IterableType, ElementType> : TraceLoggingTypeInfo<IterableType> // TypeDefIndex: 1514
{	private readonly TraceLoggingTypeInfo<ElementType> elementInfo; // 0x0


	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B4E9B0 Offset: 0x1B4CFB0 VA: 0x181B4E9B0
	|-EnumerableTypeInfo<object, object>.WriteMetadata
	*/

	public override void WriteData(TraceLoggingDataCollector collector, ref IterableType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B4E690 Offset: 0x1B4CC90 VA: 0x181B4E690
	|-EnumerableTypeInfo<object, object>.WriteData
	*/

}

internal sealed class EnumByteTypeInfo<EnumType> : TraceLoggingTypeInfo<EnumType> // TypeDefIndex: 1560
{
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B131B0 Offset: 0x1B117B0 VA: 0x181B131B0
	|-EnumByteTypeInfo<bool>.WriteMetadata
	|
	|-RVA: 0x1B13480 Offset: 0x1B11A80 VA: 0x181B13480
	|-EnumByteTypeInfo<byte>.WriteMetadata
	|
	|-RVA: 0x1B133F0 Offset: 0x1B119F0 VA: 0x181B133F0
	|-EnumByteTypeInfo<char>.WriteMetadata
	|
	|-RVA: 0x1B136C0 Offset: 0x1B11CC0 VA: 0x181B136C0
	|-EnumByteTypeInfo<KeyValuePair<object, object>>.WriteMetadata
	|
	|-RVA: 0x1B137E0 Offset: 0x1B11DE0 VA: 0x181B137E0
	|-EnumByteTypeInfo<DateTime>.WriteMetadata
	|
	|-RVA: 0x1B135A0 Offset: 0x1B11BA0 VA: 0x181B135A0
	|-EnumByteTypeInfo<DateTimeOffset>.WriteMetadata
	|
	|-RVA: 0x1B13510 Offset: 0x1B11B10 VA: 0x181B13510
	|-EnumByteTypeInfo<Decimal>.WriteMetadata
	|
	|-RVA: 0x1B13870 Offset: 0x1B11E70 VA: 0x181B13870
	|-EnumByteTypeInfo<EmptyStruct>.WriteMetadata
	|
	|-RVA: 0x1B13630 Offset: 0x1B11C30 VA: 0x181B13630
	|-EnumByteTypeInfo<double>.WriteMetadata
	|
	|-RVA: 0x1B13240 Offset: 0x1B11840 VA: 0x181B13240
	|-EnumByteTypeInfo<Guid>.WriteMetadata
	|
	|-RVA: 0x1B13900 Offset: 0x1B11F00 VA: 0x181B13900
	|-EnumByteTypeInfo<short>.WriteMetadata
	|
	|-RVA: 0x1B13C60 Offset: 0x1B12260 VA: 0x181B13C60
	|-EnumByteTypeInfo<int>.WriteMetadata
	|
	|-RVA: 0x1B13BD0 Offset: 0x1B121D0 VA: 0x181B13BD0
	|-EnumByteTypeInfo<long>.WriteMetadata
	|
	|-RVA: 0x1B13B40 Offset: 0x1B12140 VA: 0x181B13B40
	|-EnumByteTypeInfo<IntPtr>.WriteMetadata
	|
	|-RVA: 0x1B13120 Offset: 0x1B11720 VA: 0x181B13120
	|-EnumByteTypeInfo<object>.WriteMetadata
	|
	|-RVA: 0x1B13A20 Offset: 0x1B12020 VA: 0x181B13A20
	|-EnumByteTypeInfo<sbyte>.WriteMetadata
	|
	|-RVA: 0x1B132D0 Offset: 0x1B118D0 VA: 0x181B132D0
	|-EnumByteTypeInfo<float>.WriteMetadata
	|
	|-RVA: 0x1B13990 Offset: 0x1B11F90 VA: 0x181B13990
	|-EnumByteTypeInfo<TimeSpan>.WriteMetadata
	|
	|-RVA: 0x1B13360 Offset: 0x1B11960 VA: 0x181B13360
	|-EnumByteTypeInfo<ushort>.WriteMetadata
	|
	|-RVA: 0x1B13AB0 Offset: 0x1B120B0 VA: 0x181B13AB0
	|-EnumByteTypeInfo<uint>.WriteMetadata
	|
	|-RVA: 0x1B13CF0 Offset: 0x1B122F0 VA: 0x181B13CF0
	|-EnumByteTypeInfo<ulong>.WriteMetadata
	|
	|-RVA: 0x1B13750 Offset: 0x1B11D50 VA: 0x181B13750
	|-EnumByteTypeInfo<UIntPtr>.WriteMetadata
	*/

	public override void WriteData(TraceLoggingDataCollector collector, ref EnumType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B12540 Offset: 0x1B10B40 VA: 0x181B12540
	|-EnumByteTypeInfo<bool>.WriteData
	|
	|-RVA: 0x1B12C10 Offset: 0x1B11210 VA: 0x181B12C10
	|-EnumByteTypeInfo<byte>.WriteData
	|
	|-RVA: 0x1B12680 Offset: 0x1B10C80 VA: 0x181B12680
	|-EnumByteTypeInfo<char>.WriteData
	|
	|-RVA: 0x1B123F0 Offset: 0x1B109F0 VA: 0x181B123F0
	|-EnumByteTypeInfo<KeyValuePair<object, object>>.WriteData
	|
	|-RVA: 0x1B12A40 Offset: 0x1B11040 VA: 0x181B12A40
	|-EnumByteTypeInfo<DateTime>.WriteData
	|
	|-RVA: 0x1B12340 Offset: 0x1B10940 VA: 0x181B12340
	|-EnumByteTypeInfo<DateTimeOffset>.WriteData
	|
	|-RVA: 0x1B128F0 Offset: 0x1B10EF0 VA: 0x181B128F0
	|-EnumByteTypeInfo<Decimal>.WriteData
	|
	|-RVA: 0x1B12850 Offset: 0x1B10E50 VA: 0x181B12850
	|-EnumByteTypeInfo<EmptyStruct>.WriteData
	|
	|-RVA: 0x1B12720 Offset: 0x1B10D20 VA: 0x181B12720
	|-EnumByteTypeInfo<double>.WriteData
	|
	|-RVA: 0x1B12CB0 Offset: 0x1B112B0 VA: 0x181B12CB0
	|-EnumByteTypeInfo<Guid>.WriteData
	|
	|-RVA: 0x1B125E0 Offset: 0x1B10BE0 VA: 0x181B125E0
	|-EnumByteTypeInfo<short>.WriteData
	|
	|-RVA: 0x1B127C0 Offset: 0x1B10DC0 VA: 0x181B127C0
	|-EnumByteTypeInfo<int>.WriteData
	|
	|-RVA: 0x1B12FE0 Offset: 0x1B115E0 VA: 0x181B12FE0
	|-EnumByteTypeInfo<long>.WriteData
	|
	|-RVA: 0x1B13080 Offset: 0x1B11680 VA: 0x181B13080
	|-EnumByteTypeInfo<IntPtr>.WriteData
	|
	|-RVA: 0x1B12F40 Offset: 0x1B11540 VA: 0x181B12F40
	|-EnumByteTypeInfo<object>.WriteData
	|
	|-RVA: 0x1B124A0 Offset: 0x1B10AA0 VA: 0x181B124A0
	|-EnumByteTypeInfo<sbyte>.WriteData
	|
	|-RVA: 0x1B12E00 Offset: 0x1B11400 VA: 0x181B12E00
	|-EnumByteTypeInfo<float>.WriteData
	|
	|-RVA: 0x1B12D60 Offset: 0x1B11360 VA: 0x181B12D60
	|-EnumByteTypeInfo<TimeSpan>.WriteData
	|
	|-RVA: 0x1B12B70 Offset: 0x1B11170 VA: 0x181B12B70
	|-EnumByteTypeInfo<ushort>.WriteData
	|
	|-RVA: 0x1B12AE0 Offset: 0x1B110E0 VA: 0x181B12AE0
	|-EnumByteTypeInfo<uint>.WriteData
	|
	|-RVA: 0x1B12EA0 Offset: 0x1B114A0 VA: 0x181B12EA0
	|-EnumByteTypeInfo<ulong>.WriteData
	|
	|-RVA: 0x1B129A0 Offset: 0x1B10FA0 VA: 0x181B129A0
	|-EnumByteTypeInfo<UIntPtr>.WriteData
	*/

	public override object GetData(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7D3460 Offset: 0x7D1A60 VA: 0x1807D3460
	|-EnumByteTypeInfo<bool>.GetData
	|-EnumByteTypeInfo<byte>.GetData
	|-EnumByteTypeInfo<char>.GetData
	|-EnumByteTypeInfo<KeyValuePair<object, object>>.GetData
	|-EnumByteTypeInfo<DateTime>.GetData
	|-EnumByteTypeInfo<DateTimeOffset>.GetData
	|-EnumByteTypeInfo<Decimal>.GetData
	|-EnumByteTypeInfo<EmptyStruct>.GetData
	|-EnumByteTypeInfo<double>.GetData
	|-EnumByteTypeInfo<Guid>.GetData
	|-EnumByteTypeInfo<short>.GetData
	|-EnumByteTypeInfo<int>.GetData
	|-EnumByteTypeInfo<long>.GetData
	|-EnumByteTypeInfo<IntPtr>.GetData
	|-EnumByteTypeInfo<object>.GetData
	|-EnumByteTypeInfo<sbyte>.GetData
	|-EnumByteTypeInfo<float>.GetData
	|-EnumByteTypeInfo<TimeSpan>.GetData
	|-EnumByteTypeInfo<ushort>.GetData
	|-EnumByteTypeInfo<uint>.GetData
	|-EnumByteTypeInfo<ulong>.GetData
	|-EnumByteTypeInfo<UIntPtr>.GetData
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19AD3A0 Offset: 0x19AB9A0 VA: 0x1819AD3A0
	|-EnumByteTypeInfo<bool>..ctor
	|-EnumByteTypeInfo<byte>..ctor
	|-EnumByteTypeInfo<char>..ctor
	|-EnumByteTypeInfo<KeyValuePair<object, object>>..ctor
	|-EnumByteTypeInfo<DateTime>..ctor
	|-EnumByteTypeInfo<DateTimeOffset>..ctor
	|-EnumByteTypeInfo<Decimal>..ctor
	|-EnumByteTypeInfo<EmptyStruct>..ctor
	|-EnumByteTypeInfo<double>..ctor
	|-EnumByteTypeInfo<Guid>..ctor
	|-EnumByteTypeInfo<short>..ctor
	|-EnumByteTypeInfo<int>..ctor
	|-EnumByteTypeInfo<long>..ctor
	|-EnumByteTypeInfo<IntPtr>..ctor
	|-EnumByteTypeInfo<object>..ctor
	|-EnumByteTypeInfo<sbyte>..ctor
	|-EnumByteTypeInfo<float>..ctor
	|-EnumByteTypeInfo<TimeSpan>..ctor
	|-EnumByteTypeInfo<ushort>..ctor
	|-EnumByteTypeInfo<uint>..ctor
	|-EnumByteTypeInfo<ulong>..ctor
	|-EnumByteTypeInfo<UIntPtr>..ctor
	*/

}

internal sealed class EnumSByteTypeInfo<EnumType> : TraceLoggingTypeInfo<EnumType> // TypeDefIndex: 1561
{
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2139D80 Offset: 0x2138380 VA: 0x182139D80
	|-EnumSByteTypeInfo<bool>.WriteMetadata
	|
	|-RVA: 0x2139FC0 Offset: 0x21385C0 VA: 0x182139FC0
	|-EnumSByteTypeInfo<byte>.WriteMetadata
	|
	|-RVA: 0x213A320 Offset: 0x2138920 VA: 0x18213A320
	|-EnumSByteTypeInfo<char>.WriteMetadata
	|
	|-RVA: 0x213A0E0 Offset: 0x21386E0 VA: 0x18213A0E0
	|-EnumSByteTypeInfo<KeyValuePair<object, object>>.WriteMetadata
	|
	|-RVA: 0x213A3B0 Offset: 0x21389B0 VA: 0x18213A3B0
	|-EnumSByteTypeInfo<DateTime>.WriteMetadata
	|
	|-RVA: 0x2139CF0 Offset: 0x21382F0 VA: 0x182139CF0
	|-EnumSByteTypeInfo<DateTimeOffset>.WriteMetadata
	|
	|-RVA: 0x213A710 Offset: 0x2138D10 VA: 0x18213A710
	|-EnumSByteTypeInfo<Decimal>.WriteMetadata
	|
	|-RVA: 0x213A4D0 Offset: 0x2138AD0 VA: 0x18213A4D0
	|-EnumSByteTypeInfo<EmptyStruct>.WriteMetadata
	|
	|-RVA: 0x2139BD0 Offset: 0x21381D0 VA: 0x182139BD0
	|-EnumSByteTypeInfo<double>.WriteMetadata
	|
	|-RVA: 0x213A440 Offset: 0x2138A40 VA: 0x18213A440
	|-EnumSByteTypeInfo<Guid>.WriteMetadata
	|
	|-RVA: 0x213A560 Offset: 0x2138B60 VA: 0x18213A560
	|-EnumSByteTypeInfo<short>.WriteMetadata
	|
	|-RVA: 0x2139E10 Offset: 0x2138410 VA: 0x182139E10
	|-EnumSByteTypeInfo<int>.WriteMetadata
	|
	|-RVA: 0x213A170 Offset: 0x2138770 VA: 0x18213A170
	|-EnumSByteTypeInfo<long>.WriteMetadata
	|
	|-RVA: 0x2139C60 Offset: 0x2138260 VA: 0x182139C60
	|-EnumSByteTypeInfo<IntPtr>.WriteMetadata
	|
	|-RVA: 0x213A050 Offset: 0x2138650 VA: 0x18213A050
	|-EnumSByteTypeInfo<object>.WriteMetadata
	|
	|-RVA: 0x213A200 Offset: 0x2138800 VA: 0x18213A200
	|-EnumSByteTypeInfo<sbyte>.WriteMetadata
	|
	|-RVA: 0x213A290 Offset: 0x2138890 VA: 0x18213A290
	|-EnumSByteTypeInfo<float>.WriteMetadata
	|
	|-RVA: 0x213A680 Offset: 0x2138C80 VA: 0x18213A680
	|-EnumSByteTypeInfo<TimeSpan>.WriteMetadata
	|
	|-RVA: 0x213A5F0 Offset: 0x2138BF0 VA: 0x18213A5F0
	|-EnumSByteTypeInfo<ushort>.WriteMetadata
	|
	|-RVA: 0x2139EA0 Offset: 0x21384A0 VA: 0x182139EA0
	|-EnumSByteTypeInfo<uint>.WriteMetadata
	|
	|-RVA: 0x2139F30 Offset: 0x2138530 VA: 0x182139F30
	|-EnumSByteTypeInfo<ulong>.WriteMetadata
	|
	|-RVA: 0x1B49740 Offset: 0x1B47D40 VA: 0x181B49740
	|-EnumSByteTypeInfo<UIntPtr>.WriteMetadata
	*/

	public override void WriteData(TraceLoggingDataCollector collector, ref EnumType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21398A0 Offset: 0x2137EA0 VA: 0x1821398A0
	|-EnumSByteTypeInfo<bool>.WriteData
	|
	|-RVA: 0x2139A90 Offset: 0x2138090 VA: 0x182139A90
	|-EnumSByteTypeInfo<byte>.WriteData
	|
	|-RVA: 0x21391A0 Offset: 0x21377A0 VA: 0x1821391A0
	|-EnumSByteTypeInfo<char>.WriteData
	|
	|-RVA: 0x2139430 Offset: 0x2137A30 VA: 0x182139430
	|-EnumSByteTypeInfo<KeyValuePair<object, object>>.WriteData
	|
	|-RVA: 0x2139940 Offset: 0x2137F40 VA: 0x182139940
	|-EnumSByteTypeInfo<DateTime>.WriteData
	|
	|-RVA: 0x21399E0 Offset: 0x2137FE0 VA: 0x1821399E0
	|-EnumSByteTypeInfo<DateTimeOffset>.WriteData
	|
	|-RVA: 0x21392E0 Offset: 0x21378E0 VA: 0x1821392E0
	|-EnumSByteTypeInfo<Decimal>.WriteData
	|
	|-RVA: 0x2139390 Offset: 0x2137990 VA: 0x182139390
	|-EnumSByteTypeInfo<EmptyStruct>.WriteData
	|
	|-RVA: 0x2139800 Offset: 0x2137E00 VA: 0x182139800
	|-EnumSByteTypeInfo<double>.WriteData
	|
	|-RVA: 0x2139620 Offset: 0x2137C20 VA: 0x182139620
	|-EnumSByteTypeInfo<Guid>.WriteData
	|
	|-RVA: 0x21396D0 Offset: 0x2137CD0 VA: 0x1821396D0
	|-EnumSByteTypeInfo<short>.WriteData
	|
	|-RVA: 0x2138FD0 Offset: 0x21375D0 VA: 0x182138FD0
	|-EnumSByteTypeInfo<int>.WriteData
	|
	|-RVA: 0x2139100 Offset: 0x2137700 VA: 0x182139100
	|-EnumSByteTypeInfo<long>.WriteData
	|
	|-RVA: 0x21394E0 Offset: 0x2137AE0 VA: 0x1821394E0
	|-EnumSByteTypeInfo<IntPtr>.WriteData
	|
	|-RVA: 0x2139060 Offset: 0x2137660 VA: 0x182139060
	|-EnumSByteTypeInfo<object>.WriteData
	|
	|-RVA: 0x2138F30 Offset: 0x2137530 VA: 0x182138F30
	|-EnumSByteTypeInfo<sbyte>.WriteData
	|
	|-RVA: 0x2139B30 Offset: 0x2138130 VA: 0x182139B30
	|-EnumSByteTypeInfo<float>.WriteData
	|
	|-RVA: 0x2138E90 Offset: 0x2137490 VA: 0x182138E90
	|-EnumSByteTypeInfo<TimeSpan>.WriteData
	|
	|-RVA: 0x2139580 Offset: 0x2137B80 VA: 0x182139580
	|-EnumSByteTypeInfo<ushort>.WriteData
	|
	|-RVA: 0x2139770 Offset: 0x2137D70 VA: 0x182139770
	|-EnumSByteTypeInfo<uint>.WriteData
	|
	|-RVA: 0x2139240 Offset: 0x2137840 VA: 0x182139240
	|-EnumSByteTypeInfo<ulong>.WriteData
	|
	|-RVA: 0x1B496A0 Offset: 0x1B47CA0 VA: 0x181B496A0
	|-EnumSByteTypeInfo<UIntPtr>.WriteData
	*/

	public override object GetData(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7D3460 Offset: 0x7D1A60 VA: 0x1807D3460
	|-EnumSByteTypeInfo<bool>.GetData
	|-EnumSByteTypeInfo<byte>.GetData
	|-EnumSByteTypeInfo<char>.GetData
	|-EnumSByteTypeInfo<KeyValuePair<object, object>>.GetData
	|-EnumSByteTypeInfo<DateTime>.GetData
	|-EnumSByteTypeInfo<DateTimeOffset>.GetData
	|-EnumSByteTypeInfo<Decimal>.GetData
	|-EnumSByteTypeInfo<EmptyStruct>.GetData
	|-EnumSByteTypeInfo<double>.GetData
	|-EnumSByteTypeInfo<Guid>.GetData
	|-EnumSByteTypeInfo<short>.GetData
	|-EnumSByteTypeInfo<int>.GetData
	|-EnumSByteTypeInfo<long>.GetData
	|-EnumSByteTypeInfo<IntPtr>.GetData
	|-EnumSByteTypeInfo<object>.GetData
	|-EnumSByteTypeInfo<sbyte>.GetData
	|-EnumSByteTypeInfo<float>.GetData
	|-EnumSByteTypeInfo<TimeSpan>.GetData
	|-EnumSByteTypeInfo<ushort>.GetData
	|-EnumSByteTypeInfo<uint>.GetData
	|-EnumSByteTypeInfo<ulong>.GetData
	|-EnumSByteTypeInfo<UIntPtr>.GetData
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19AD3A0 Offset: 0x19AB9A0 VA: 0x1819AD3A0
	|-EnumSByteTypeInfo<bool>..ctor
	|-EnumSByteTypeInfo<byte>..ctor
	|-EnumSByteTypeInfo<char>..ctor
	|-EnumSByteTypeInfo<KeyValuePair<object, object>>..ctor
	|-EnumSByteTypeInfo<DateTime>..ctor
	|-EnumSByteTypeInfo<DateTimeOffset>..ctor
	|-EnumSByteTypeInfo<Decimal>..ctor
	|-EnumSByteTypeInfo<EmptyStruct>..ctor
	|-EnumSByteTypeInfo<double>..ctor
	|-EnumSByteTypeInfo<Guid>..ctor
	|-EnumSByteTypeInfo<short>..ctor
	|-EnumSByteTypeInfo<int>..ctor
	|-EnumSByteTypeInfo<long>..ctor
	|-EnumSByteTypeInfo<IntPtr>..ctor
	|-EnumSByteTypeInfo<object>..ctor
	|-EnumSByteTypeInfo<sbyte>..ctor
	|-EnumSByteTypeInfo<float>..ctor
	|-EnumSByteTypeInfo<TimeSpan>..ctor
	|-EnumSByteTypeInfo<ushort>..ctor
	|-EnumSByteTypeInfo<uint>..ctor
	|-EnumSByteTypeInfo<ulong>..ctor
	|-EnumSByteTypeInfo<UIntPtr>..ctor
	*/

}

internal sealed class EnumInt16TypeInfo<EnumType> : TraceLoggingTypeInfo<EnumType> // TypeDefIndex: 1562
{
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21353E0 Offset: 0x21339E0 VA: 0x1821353E0
	|-EnumInt16TypeInfo<bool>.WriteMetadata
	|
	|-RVA: 0x2135080 Offset: 0x2133680 VA: 0x182135080
	|-EnumInt16TypeInfo<byte>.WriteMetadata
	|
	|-RVA: 0x2135620 Offset: 0x2133C20 VA: 0x182135620
	|-EnumInt16TypeInfo<char>.WriteMetadata
	|
	|-RVA: 0x21351A0 Offset: 0x21337A0 VA: 0x1821351A0
	|-EnumInt16TypeInfo<KeyValuePair<object, object>>.WriteMetadata
	|
	|-RVA: 0x21357D0 Offset: 0x2133DD0 VA: 0x1821357D0
	|-EnumInt16TypeInfo<DateTime>.WriteMetadata
	|
	|-RVA: 0x21356B0 Offset: 0x2133CB0 VA: 0x1821356B0
	|-EnumInt16TypeInfo<DateTimeOffset>.WriteMetadata
	|
	|-RVA: 0x2134DB0 Offset: 0x21333B0 VA: 0x182134DB0
	|-EnumInt16TypeInfo<Decimal>.WriteMetadata
	|
	|-RVA: 0x2135980 Offset: 0x2133F80 VA: 0x182135980
	|-EnumInt16TypeInfo<EmptyStruct>.WriteMetadata
	|
	|-RVA: 0x2134FF0 Offset: 0x21335F0 VA: 0x182134FF0
	|-EnumInt16TypeInfo<double>.WriteMetadata
	|
	|-RVA: 0x21358F0 Offset: 0x2133EF0 VA: 0x1821358F0
	|-EnumInt16TypeInfo<Guid>.WriteMetadata
	|
	|-RVA: 0x2135470 Offset: 0x2133A70 VA: 0x182135470
	|-EnumInt16TypeInfo<short>.WriteMetadata
	|
	|-RVA: 0x2135740 Offset: 0x2133D40 VA: 0x182135740
	|-EnumInt16TypeInfo<int>.WriteMetadata
	|
	|-RVA: 0x2135860 Offset: 0x2133E60 VA: 0x182135860
	|-EnumInt16TypeInfo<long>.WriteMetadata
	|
	|-RVA: 0x2134E40 Offset: 0x2133440 VA: 0x182134E40
	|-EnumInt16TypeInfo<IntPtr>.WriteMetadata
	|
	|-RVA: 0x2135590 Offset: 0x2133B90 VA: 0x182135590
	|-EnumInt16TypeInfo<object>.WriteMetadata
	|
	|-RVA: 0x2134F60 Offset: 0x2133560 VA: 0x182134F60
	|-EnumInt16TypeInfo<sbyte>.WriteMetadata
	|
	|-RVA: 0x21352C0 Offset: 0x21338C0 VA: 0x1821352C0
	|-EnumInt16TypeInfo<float>.WriteMetadata
	|
	|-RVA: 0x2135350 Offset: 0x2133950 VA: 0x182135350
	|-EnumInt16TypeInfo<TimeSpan>.WriteMetadata
	|
	|-RVA: 0x2135230 Offset: 0x2133830 VA: 0x182135230
	|-EnumInt16TypeInfo<ushort>.WriteMetadata
	|
	|-RVA: 0x2134ED0 Offset: 0x21334D0 VA: 0x182134ED0
	|-EnumInt16TypeInfo<uint>.WriteMetadata
	|
	|-RVA: 0x2135500 Offset: 0x2133B00 VA: 0x182135500
	|-EnumInt16TypeInfo<ulong>.WriteMetadata
	|
	|-RVA: 0x2135110 Offset: 0x2133710 VA: 0x182135110
	|-EnumInt16TypeInfo<UIntPtr>.WriteMetadata
	*/

	public override void WriteData(TraceLoggingDataCollector collector, ref EnumType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2134060 Offset: 0x2132660 VA: 0x182134060
	|-EnumInt16TypeInfo<bool>.WriteData
	|
	|-RVA: 0x21341A0 Offset: 0x21327A0 VA: 0x1821341A0
	|-EnumInt16TypeInfo<byte>.WriteData
	|
	|-RVA: 0x2134890 Offset: 0x2132E90 VA: 0x182134890
	|-EnumInt16TypeInfo<char>.WriteData
	|
	|-RVA: 0x2134BC0 Offset: 0x21331C0 VA: 0x182134BC0
	|-EnumInt16TypeInfo<KeyValuePair<object, object>>.WriteData
	|
	|-RVA: 0x21342E0 Offset: 0x21328E0 VA: 0x1821342E0
	|-EnumInt16TypeInfo<DateTime>.WriteData
	|
	|-RVA: 0x2134420 Offset: 0x2132A20 VA: 0x182134420
	|-EnumInt16TypeInfo<DateTimeOffset>.WriteData
	|
	|-RVA: 0x2134930 Offset: 0x2132F30 VA: 0x182134930
	|-EnumInt16TypeInfo<Decimal>.WriteData
	|
	|-RVA: 0x2134750 Offset: 0x2132D50 VA: 0x182134750
	|-EnumInt16TypeInfo<EmptyStruct>.WriteData
	|
	|-RVA: 0x21344D0 Offset: 0x2132AD0 VA: 0x1821344D0
	|-EnumInt16TypeInfo<double>.WriteData
	|
	|-RVA: 0x21349E0 Offset: 0x2132FE0 VA: 0x1821349E0
	|-EnumInt16TypeInfo<Guid>.WriteData
	|
	|-RVA: 0x2134570 Offset: 0x2132B70 VA: 0x182134570
	|-EnumInt16TypeInfo<short>.WriteData
	|
	|-RVA: 0x2133FD0 Offset: 0x21325D0 VA: 0x182133FD0
	|-EnumInt16TypeInfo<int>.WriteData
	|
	|-RVA: 0x2134C70 Offset: 0x2133270 VA: 0x182134C70
	|-EnumInt16TypeInfo<long>.WriteData
	|
	|-RVA: 0x2134610 Offset: 0x2132C10 VA: 0x182134610
	|-EnumInt16TypeInfo<IntPtr>.WriteData
	|
	|-RVA: 0x2134240 Offset: 0x2132840 VA: 0x182134240
	|-EnumInt16TypeInfo<object>.WriteData
	|
	|-RVA: 0x2134D10 Offset: 0x2133310 VA: 0x182134D10
	|-EnumInt16TypeInfo<sbyte>.WriteData
	|
	|-RVA: 0x2134380 Offset: 0x2132980 VA: 0x182134380
	|-EnumInt16TypeInfo<float>.WriteData
	|
	|-RVA: 0x21347F0 Offset: 0x2132DF0 VA: 0x1821347F0
	|-EnumInt16TypeInfo<TimeSpan>.WriteData
	|
	|-RVA: 0x2134A90 Offset: 0x2133090 VA: 0x182134A90
	|-EnumInt16TypeInfo<ushort>.WriteData
	|
	|-RVA: 0x2134B30 Offset: 0x2133130 VA: 0x182134B30
	|-EnumInt16TypeInfo<uint>.WriteData
	|
	|-RVA: 0x2134100 Offset: 0x2132700 VA: 0x182134100
	|-EnumInt16TypeInfo<ulong>.WriteData
	|
	|-RVA: 0x21346B0 Offset: 0x2132CB0 VA: 0x1821346B0
	|-EnumInt16TypeInfo<UIntPtr>.WriteData
	*/

	public override object GetData(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7D3460 Offset: 0x7D1A60 VA: 0x1807D3460
	|-EnumInt16TypeInfo<bool>.GetData
	|-EnumInt16TypeInfo<byte>.GetData
	|-EnumInt16TypeInfo<char>.GetData
	|-EnumInt16TypeInfo<KeyValuePair<object, object>>.GetData
	|-EnumInt16TypeInfo<DateTime>.GetData
	|-EnumInt16TypeInfo<DateTimeOffset>.GetData
	|-EnumInt16TypeInfo<Decimal>.GetData
	|-EnumInt16TypeInfo<EmptyStruct>.GetData
	|-EnumInt16TypeInfo<double>.GetData
	|-EnumInt16TypeInfo<Guid>.GetData
	|-EnumInt16TypeInfo<short>.GetData
	|-EnumInt16TypeInfo<int>.GetData
	|-EnumInt16TypeInfo<long>.GetData
	|-EnumInt16TypeInfo<IntPtr>.GetData
	|-EnumInt16TypeInfo<object>.GetData
	|-EnumInt16TypeInfo<sbyte>.GetData
	|-EnumInt16TypeInfo<float>.GetData
	|-EnumInt16TypeInfo<TimeSpan>.GetData
	|-EnumInt16TypeInfo<ushort>.GetData
	|-EnumInt16TypeInfo<uint>.GetData
	|-EnumInt16TypeInfo<ulong>.GetData
	|-EnumInt16TypeInfo<UIntPtr>.GetData
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19AD3A0 Offset: 0x19AB9A0 VA: 0x1819AD3A0
	|-EnumInt16TypeInfo<bool>..ctor
	|-EnumInt16TypeInfo<byte>..ctor
	|-EnumInt16TypeInfo<char>..ctor
	|-EnumInt16TypeInfo<KeyValuePair<object, object>>..ctor
	|-EnumInt16TypeInfo<DateTime>..ctor
	|-EnumInt16TypeInfo<DateTimeOffset>..ctor
	|-EnumInt16TypeInfo<Decimal>..ctor
	|-EnumInt16TypeInfo<EmptyStruct>..ctor
	|-EnumInt16TypeInfo<double>..ctor
	|-EnumInt16TypeInfo<Guid>..ctor
	|-EnumInt16TypeInfo<short>..ctor
	|-EnumInt16TypeInfo<int>..ctor
	|-EnumInt16TypeInfo<long>..ctor
	|-EnumInt16TypeInfo<IntPtr>..ctor
	|-EnumInt16TypeInfo<object>..ctor
	|-EnumInt16TypeInfo<sbyte>..ctor
	|-EnumInt16TypeInfo<float>..ctor
	|-EnumInt16TypeInfo<TimeSpan>..ctor
	|-EnumInt16TypeInfo<ushort>..ctor
	|-EnumInt16TypeInfo<uint>..ctor
	|-EnumInt16TypeInfo<ulong>..ctor
	|-EnumInt16TypeInfo<UIntPtr>..ctor
	*/

}

internal sealed class EnumUInt16TypeInfo<EnumType> : TraceLoggingTypeInfo<EnumType> // TypeDefIndex: 1563
{
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B4AAC0 Offset: 0x1B490C0 VA: 0x181B4AAC0
	|-EnumUInt16TypeInfo<bool>.WriteMetadata
	|
	|-RVA: 0x1B4ABE0 Offset: 0x1B491E0 VA: 0x181B4ABE0
	|-EnumUInt16TypeInfo<byte>.WriteMetadata
	|
	|-RVA: 0x1B4AFD0 Offset: 0x1B495D0 VA: 0x181B4AFD0
	|-EnumUInt16TypeInfo<char>.WriteMetadata
	|
	|-RVA: 0x1B4AEB0 Offset: 0x1B494B0 VA: 0x181B4AEB0
	|-EnumUInt16TypeInfo<KeyValuePair<object, object>>.WriteMetadata
	|
	|-RVA: 0x1B4AC70 Offset: 0x1B49270 VA: 0x181B4AC70
	|-EnumUInt16TypeInfo<DateTime>.WriteMetadata
	|
	|-RVA: 0x1B4A9A0 Offset: 0x1B48FA0 VA: 0x181B4A9A0
	|-EnumUInt16TypeInfo<DateTimeOffset>.WriteMetadata
	|
	|-RVA: 0x1B4B0F0 Offset: 0x1B496F0 VA: 0x181B4B0F0
	|-EnumUInt16TypeInfo<Decimal>.WriteMetadata
	|
	|-RVA: 0x1B4AD90 Offset: 0x1B49390 VA: 0x181B4AD90
	|-EnumUInt16TypeInfo<EmptyStruct>.WriteMetadata
	|
	|-RVA: 0x1B4A640 Offset: 0x1B48C40 VA: 0x181B4A640
	|-EnumUInt16TypeInfo<double>.WriteMetadata
	|
	|-RVA: 0x1B4A880 Offset: 0x1B48E80 VA: 0x181B4A880
	|-EnumUInt16TypeInfo<Guid>.WriteMetadata
	|
	|-RVA: 0x1B4A6D0 Offset: 0x1B48CD0 VA: 0x181B4A6D0
	|-EnumUInt16TypeInfo<short>.WriteMetadata
	|
	|-RVA: 0x1B4AD00 Offset: 0x1B49300 VA: 0x181B4AD00
	|-EnumUInt16TypeInfo<int>.WriteMetadata
	|
	|-RVA: 0x1B4A5B0 Offset: 0x1B48BB0 VA: 0x181B4A5B0
	|-EnumUInt16TypeInfo<long>.WriteMetadata
	|
	|-RVA: 0x1B4A760 Offset: 0x1B48D60 VA: 0x181B4A760
	|-EnumUInt16TypeInfo<IntPtr>.WriteMetadata
	|
	|-RVA: 0x1B4AF40 Offset: 0x1B49540 VA: 0x181B4AF40
	|-EnumUInt16TypeInfo<object>.WriteMetadata
	|
	|-RVA: 0x1B4A7F0 Offset: 0x1B48DF0 VA: 0x181B4A7F0
	|-EnumUInt16TypeInfo<sbyte>.WriteMetadata
	|
	|-RVA: 0x1B4B180 Offset: 0x1B49780 VA: 0x181B4B180
	|-EnumUInt16TypeInfo<float>.WriteMetadata
	|
	|-RVA: 0x1B4A910 Offset: 0x1B48F10 VA: 0x181B4A910
	|-EnumUInt16TypeInfo<TimeSpan>.WriteMetadata
	|
	|-RVA: 0x1B4AB50 Offset: 0x1B49150 VA: 0x181B4AB50
	|-EnumUInt16TypeInfo<ushort>.WriteMetadata
	|
	|-RVA: 0x1B4AA30 Offset: 0x1B49030 VA: 0x181B4AA30
	|-EnumUInt16TypeInfo<uint>.WriteMetadata
	|
	|-RVA: 0x1B4B060 Offset: 0x1B49660 VA: 0x181B4B060
	|-EnumUInt16TypeInfo<ulong>.WriteMetadata
	|
	|-RVA: 0x1B4AE20 Offset: 0x1B49420 VA: 0x181B4AE20
	|-EnumUInt16TypeInfo<UIntPtr>.WriteMetadata
	*/

	public override void WriteData(TraceLoggingDataCollector collector, ref EnumType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B4A090 Offset: 0x1B48690 VA: 0x181B4A090
	|-EnumUInt16TypeInfo<bool>.WriteData
	|
	|-RVA: 0x1B49C40 Offset: 0x1B48240 VA: 0x181B49C40
	|-EnumUInt16TypeInfo<byte>.WriteData
	|
	|-RVA: 0x1B49BA0 Offset: 0x1B481A0 VA: 0x181B49BA0
	|-EnumUInt16TypeInfo<char>.WriteData
	|
	|-RVA: 0x1B4A460 Offset: 0x1B48A60 VA: 0x181B4A460
	|-EnumUInt16TypeInfo<KeyValuePair<object, object>>.WriteData
	|
	|-RVA: 0x1B49E20 Offset: 0x1B48420 VA: 0x181B49E20
	|-EnumUInt16TypeInfo<DateTime>.WriteData
	|
	|-RVA: 0x1B4A130 Offset: 0x1B48730 VA: 0x181B4A130
	|-EnumUInt16TypeInfo<DateTimeOffset>.WriteData
	|
	|-RVA: 0x1B49910 Offset: 0x1B47F10 VA: 0x181B49910
	|-EnumUInt16TypeInfo<Decimal>.WriteData
	|
	|-RVA: 0x1B497D0 Offset: 0x1B47DD0 VA: 0x181B497D0
	|-EnumUInt16TypeInfo<EmptyStruct>.WriteData
	|
	|-RVA: 0x1B49D80 Offset: 0x1B48380 VA: 0x181B49D80
	|-EnumUInt16TypeInfo<double>.WriteData
	|
	|-RVA: 0x1B4A280 Offset: 0x1B48880 VA: 0x181B4A280
	|-EnumUInt16TypeInfo<Guid>.WriteData
	|
	|-RVA: 0x1B49CE0 Offset: 0x1B482E0 VA: 0x181B49CE0
	|-EnumUInt16TypeInfo<short>.WriteData
	|
	|-RVA: 0x1B4A330 Offset: 0x1B48930 VA: 0x181B4A330
	|-EnumUInt16TypeInfo<int>.WriteData
	|
	|-RVA: 0x1B499C0 Offset: 0x1B47FC0 VA: 0x181B499C0
	|-EnumUInt16TypeInfo<long>.WriteData
	|
	|-RVA: 0x1B49B00 Offset: 0x1B48100 VA: 0x181B49B00
	|-EnumUInt16TypeInfo<IntPtr>.WriteData
	|
	|-RVA: 0x1B4A1E0 Offset: 0x1B487E0 VA: 0x181B4A1E0
	|-EnumUInt16TypeInfo<object>.WriteData
	|
	|-RVA: 0x1B49FF0 Offset: 0x1B485F0 VA: 0x181B49FF0
	|-EnumUInt16TypeInfo<sbyte>.WriteData
	|
	|-RVA: 0x1B4A510 Offset: 0x1B48B10 VA: 0x181B4A510
	|-EnumUInt16TypeInfo<float>.WriteData
	|
	|-RVA: 0x1B49A60 Offset: 0x1B48060 VA: 0x181B49A60
	|-EnumUInt16TypeInfo<TimeSpan>.WriteData
	|
	|-RVA: 0x1B4A3C0 Offset: 0x1B489C0 VA: 0x181B4A3C0
	|-EnumUInt16TypeInfo<ushort>.WriteData
	|
	|-RVA: 0x1B49EC0 Offset: 0x1B484C0 VA: 0x181B49EC0
	|-EnumUInt16TypeInfo<uint>.WriteData
	|
	|-RVA: 0x1B49F50 Offset: 0x1B48550 VA: 0x181B49F50
	|-EnumUInt16TypeInfo<ulong>.WriteData
	|
	|-RVA: 0x1B49870 Offset: 0x1B47E70 VA: 0x181B49870
	|-EnumUInt16TypeInfo<UIntPtr>.WriteData
	*/

	public override object GetData(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7D3460 Offset: 0x7D1A60 VA: 0x1807D3460
	|-EnumUInt16TypeInfo<bool>.GetData
	|-EnumUInt16TypeInfo<byte>.GetData
	|-EnumUInt16TypeInfo<char>.GetData
	|-EnumUInt16TypeInfo<KeyValuePair<object, object>>.GetData
	|-EnumUInt16TypeInfo<DateTime>.GetData
	|-EnumUInt16TypeInfo<DateTimeOffset>.GetData
	|-EnumUInt16TypeInfo<Decimal>.GetData
	|-EnumUInt16TypeInfo<EmptyStruct>.GetData
	|-EnumUInt16TypeInfo<double>.GetData
	|-EnumUInt16TypeInfo<Guid>.GetData
	|-EnumUInt16TypeInfo<short>.GetData
	|-EnumUInt16TypeInfo<int>.GetData
	|-EnumUInt16TypeInfo<long>.GetData
	|-EnumUInt16TypeInfo<IntPtr>.GetData
	|-EnumUInt16TypeInfo<object>.GetData
	|-EnumUInt16TypeInfo<sbyte>.GetData
	|-EnumUInt16TypeInfo<float>.GetData
	|-EnumUInt16TypeInfo<TimeSpan>.GetData
	|-EnumUInt16TypeInfo<ushort>.GetData
	|-EnumUInt16TypeInfo<uint>.GetData
	|-EnumUInt16TypeInfo<ulong>.GetData
	|-EnumUInt16TypeInfo<UIntPtr>.GetData
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19AD3A0 Offset: 0x19AB9A0 VA: 0x1819AD3A0
	|-EnumUInt16TypeInfo<bool>..ctor
	|-EnumUInt16TypeInfo<byte>..ctor
	|-EnumUInt16TypeInfo<char>..ctor
	|-EnumUInt16TypeInfo<KeyValuePair<object, object>>..ctor
	|-EnumUInt16TypeInfo<DateTime>..ctor
	|-EnumUInt16TypeInfo<DateTimeOffset>..ctor
	|-EnumUInt16TypeInfo<Decimal>..ctor
	|-EnumUInt16TypeInfo<EmptyStruct>..ctor
	|-EnumUInt16TypeInfo<double>..ctor
	|-EnumUInt16TypeInfo<Guid>..ctor
	|-EnumUInt16TypeInfo<short>..ctor
	|-EnumUInt16TypeInfo<int>..ctor
	|-EnumUInt16TypeInfo<long>..ctor
	|-EnumUInt16TypeInfo<IntPtr>..ctor
	|-EnumUInt16TypeInfo<object>..ctor
	|-EnumUInt16TypeInfo<sbyte>..ctor
	|-EnumUInt16TypeInfo<float>..ctor
	|-EnumUInt16TypeInfo<TimeSpan>..ctor
	|-EnumUInt16TypeInfo<ushort>..ctor
	|-EnumUInt16TypeInfo<uint>..ctor
	|-EnumUInt16TypeInfo<ulong>..ctor
	|-EnumUInt16TypeInfo<UIntPtr>..ctor
	*/

}

internal sealed class EnumInt32TypeInfo<EnumType> : TraceLoggingTypeInfo<EnumType> // TypeDefIndex: 1564
{
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2137210 Offset: 0x2135810 VA: 0x182137210
	|-EnumInt32TypeInfo<bool>.WriteMetadata
	|
	|-RVA: 0x21373C0 Offset: 0x21359C0 VA: 0x1821373C0
	|-EnumInt32TypeInfo<byte>.WriteMetadata
	|
	|-RVA: 0x2137060 Offset: 0x2135660 VA: 0x182137060
	|-EnumInt32TypeInfo<char>.WriteMetadata
	|
	|-RVA: 0x2136E20 Offset: 0x2135420 VA: 0x182136E20
	|-EnumInt32TypeInfo<KeyValuePair<object, object>>.WriteMetadata
	|
	|-RVA: 0x21369A0 Offset: 0x2134FA0 VA: 0x1821369A0
	|-EnumInt32TypeInfo<DateTime>.WriteMetadata
	|
	|-RVA: 0x2136C70 Offset: 0x2135270 VA: 0x182136C70
	|-EnumInt32TypeInfo<DateTimeOffset>.WriteMetadata
	|
	|-RVA: 0x2136AC0 Offset: 0x21350C0 VA: 0x182136AC0
	|-EnumInt32TypeInfo<Decimal>.WriteMetadata
	|
	|-RVA: 0x2136EB0 Offset: 0x21354B0 VA: 0x182136EB0
	|-EnumInt32TypeInfo<EmptyStruct>.WriteMetadata
	|
	|-RVA: 0x2136D00 Offset: 0x2135300 VA: 0x182136D00
	|-EnumInt32TypeInfo<double>.WriteMetadata
	|
	|-RVA: 0x2136880 Offset: 0x2134E80 VA: 0x182136880
	|-EnumInt32TypeInfo<Guid>.WriteMetadata
	|
	|-RVA: 0x2136B50 Offset: 0x2135150 VA: 0x182136B50
	|-EnumInt32TypeInfo<short>.WriteMetadata
	|
	|-RVA: 0x2136D90 Offset: 0x2135390 VA: 0x182136D90
	|-EnumInt32TypeInfo<int>.WriteMetadata
	|
	|-RVA: 0x2136910 Offset: 0x2134F10 VA: 0x182136910
	|-EnumInt32TypeInfo<long>.WriteMetadata
	|
	|-RVA: 0x2136A30 Offset: 0x2135030 VA: 0x182136A30
	|-EnumInt32TypeInfo<IntPtr>.WriteMetadata
	|
	|-RVA: 0x21372A0 Offset: 0x21358A0 VA: 0x1821372A0
	|-EnumInt32TypeInfo<object>.WriteMetadata
	|
	|-RVA: 0x2137180 Offset: 0x2135780 VA: 0x182137180
	|-EnumInt32TypeInfo<sbyte>.WriteMetadata
	|
	|-RVA: 0x2136FD0 Offset: 0x21355D0 VA: 0x182136FD0
	|-EnumInt32TypeInfo<float>.WriteMetadata
	|
	|-RVA: 0x21367F0 Offset: 0x2134DF0 VA: 0x1821367F0
	|-EnumInt32TypeInfo<TimeSpan>.WriteMetadata
	|
	|-RVA: 0x2136F40 Offset: 0x2135540 VA: 0x182136F40
	|-EnumInt32TypeInfo<ushort>.WriteMetadata
	|
	|-RVA: 0x21370F0 Offset: 0x21356F0 VA: 0x1821370F0
	|-EnumInt32TypeInfo<uint>.WriteMetadata
	|
	|-RVA: 0x2136BE0 Offset: 0x21351E0 VA: 0x182136BE0
	|-EnumInt32TypeInfo<ulong>.WriteMetadata
	|
	|-RVA: 0x2137330 Offset: 0x2135930 VA: 0x182137330
	|-EnumInt32TypeInfo<UIntPtr>.WriteMetadata
	*/

	public override void WriteData(TraceLoggingDataCollector collector, ref EnumType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2135A10 Offset: 0x2134010 VA: 0x182135A10
	|-EnumInt32TypeInfo<bool>.WriteData
	|
	|-RVA: 0x2136750 Offset: 0x2134D50 VA: 0x182136750
	|-EnumInt32TypeInfo<byte>.WriteData
	|
	|-RVA: 0x21366B0 Offset: 0x2134CB0 VA: 0x1821366B0
	|-EnumInt32TypeInfo<char>.WriteData
	|
	|-RVA: 0x2135B50 Offset: 0x2134150 VA: 0x182135B50
	|-EnumInt32TypeInfo<KeyValuePair<object, object>>.WriteData
	|
	|-RVA: 0x2136120 Offset: 0x2134720 VA: 0x182136120
	|-EnumInt32TypeInfo<DateTime>.WriteData
	|
	|-RVA: 0x2135F30 Offset: 0x2134530 VA: 0x182135F30
	|-EnumInt32TypeInfo<DateTimeOffset>.WriteData
	|
	|-RVA: 0x2135C00 Offset: 0x2134200 VA: 0x182135C00
	|-EnumInt32TypeInfo<Decimal>.WriteData
	|
	|-RVA: 0x21361C0 Offset: 0x21347C0 VA: 0x1821361C0
	|-EnumInt32TypeInfo<EmptyStruct>.WriteData
	|
	|-RVA: 0x2135CB0 Offset: 0x21342B0 VA: 0x182135CB0
	|-EnumInt32TypeInfo<double>.WriteData
	|
	|-RVA: 0x21364D0 Offset: 0x2134AD0 VA: 0x1821364D0
	|-EnumInt32TypeInfo<Guid>.WriteData
	|
	|-RVA: 0x2135D50 Offset: 0x2134350 VA: 0x182135D50
	|-EnumInt32TypeInfo<short>.WriteData
	|
	|-RVA: 0x2136620 Offset: 0x2134C20 VA: 0x182136620
	|-EnumInt32TypeInfo<int>.WriteData
	|
	|-RVA: 0x2135DF0 Offset: 0x21343F0 VA: 0x182135DF0
	|-EnumInt32TypeInfo<long>.WriteData
	|
	|-RVA: 0x2136580 Offset: 0x2134B80 VA: 0x182136580
	|-EnumInt32TypeInfo<IntPtr>.WriteData
	|
	|-RVA: 0x21363A0 Offset: 0x21349A0 VA: 0x1821363A0
	|-EnumInt32TypeInfo<object>.WriteData
	|
	|-RVA: 0x2135AB0 Offset: 0x21340B0 VA: 0x182135AB0
	|-EnumInt32TypeInfo<sbyte>.WriteData
	|
	|-RVA: 0x2136080 Offset: 0x2134680 VA: 0x182136080
	|-EnumInt32TypeInfo<float>.WriteData
	|
	|-RVA: 0x2136260 Offset: 0x2134860 VA: 0x182136260
	|-EnumInt32TypeInfo<TimeSpan>.WriteData
	|
	|-RVA: 0x2136300 Offset: 0x2134900 VA: 0x182136300
	|-EnumInt32TypeInfo<ushort>.WriteData
	|
	|-RVA: 0x2136440 Offset: 0x2134A40 VA: 0x182136440
	|-EnumInt32TypeInfo<uint>.WriteData
	|
	|-RVA: 0x2135FE0 Offset: 0x21345E0 VA: 0x182135FE0
	|-EnumInt32TypeInfo<ulong>.WriteData
	|
	|-RVA: 0x2135E90 Offset: 0x2134490 VA: 0x182135E90
	|-EnumInt32TypeInfo<UIntPtr>.WriteData
	*/

	public override object GetData(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7D3460 Offset: 0x7D1A60 VA: 0x1807D3460
	|-EnumInt32TypeInfo<bool>.GetData
	|-EnumInt32TypeInfo<byte>.GetData
	|-EnumInt32TypeInfo<char>.GetData
	|-EnumInt32TypeInfo<KeyValuePair<object, object>>.GetData
	|-EnumInt32TypeInfo<DateTime>.GetData
	|-EnumInt32TypeInfo<DateTimeOffset>.GetData
	|-EnumInt32TypeInfo<Decimal>.GetData
	|-EnumInt32TypeInfo<EmptyStruct>.GetData
	|-EnumInt32TypeInfo<double>.GetData
	|-EnumInt32TypeInfo<Guid>.GetData
	|-EnumInt32TypeInfo<short>.GetData
	|-EnumInt32TypeInfo<int>.GetData
	|-EnumInt32TypeInfo<long>.GetData
	|-EnumInt32TypeInfo<IntPtr>.GetData
	|-EnumInt32TypeInfo<object>.GetData
	|-EnumInt32TypeInfo<sbyte>.GetData
	|-EnumInt32TypeInfo<float>.GetData
	|-EnumInt32TypeInfo<TimeSpan>.GetData
	|-EnumInt32TypeInfo<ushort>.GetData
	|-EnumInt32TypeInfo<uint>.GetData
	|-EnumInt32TypeInfo<ulong>.GetData
	|-EnumInt32TypeInfo<UIntPtr>.GetData
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19AD3A0 Offset: 0x19AB9A0 VA: 0x1819AD3A0
	|-EnumInt32TypeInfo<bool>..ctor
	|-EnumInt32TypeInfo<byte>..ctor
	|-EnumInt32TypeInfo<char>..ctor
	|-EnumInt32TypeInfo<KeyValuePair<object, object>>..ctor
	|-EnumInt32TypeInfo<DateTime>..ctor
	|-EnumInt32TypeInfo<DateTimeOffset>..ctor
	|-EnumInt32TypeInfo<Decimal>..ctor
	|-EnumInt32TypeInfo<EmptyStruct>..ctor
	|-EnumInt32TypeInfo<double>..ctor
	|-EnumInt32TypeInfo<Guid>..ctor
	|-EnumInt32TypeInfo<short>..ctor
	|-EnumInt32TypeInfo<int>..ctor
	|-EnumInt32TypeInfo<long>..ctor
	|-EnumInt32TypeInfo<IntPtr>..ctor
	|-EnumInt32TypeInfo<object>..ctor
	|-EnumInt32TypeInfo<sbyte>..ctor
	|-EnumInt32TypeInfo<float>..ctor
	|-EnumInt32TypeInfo<TimeSpan>..ctor
	|-EnumInt32TypeInfo<ushort>..ctor
	|-EnumInt32TypeInfo<uint>..ctor
	|-EnumInt32TypeInfo<ulong>..ctor
	|-EnumInt32TypeInfo<UIntPtr>..ctor
	*/

}

internal sealed class EnumUInt32TypeInfo<EnumType> : TraceLoggingTypeInfo<EnumType> // TypeDefIndex: 1565
{
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B4C860 Offset: 0x1B4AE60 VA: 0x181B4C860
	|-EnumUInt32TypeInfo<bool>.WriteMetadata
	|
	|-RVA: 0x1B4C080 Offset: 0x1B4A680 VA: 0x181B4C080
	|-EnumUInt32TypeInfo<byte>.WriteMetadata
	|
	|-RVA: 0x1B4C590 Offset: 0x1B4AB90 VA: 0x181B4C590
	|-EnumUInt32TypeInfo<char>.WriteMetadata
	|
	|-RVA: 0x1B4C500 Offset: 0x1B4AB00 VA: 0x181B4C500
	|-EnumUInt32TypeInfo<KeyValuePair<object, object>>.WriteMetadata
	|
	|-RVA: 0x1B4C6B0 Offset: 0x1B4ACB0 VA: 0x181B4C6B0
	|-EnumUInt32TypeInfo<DateTime>.WriteMetadata
	|
	|-RVA: 0x1B4C1A0 Offset: 0x1B4A7A0 VA: 0x181B4C1A0
	|-EnumUInt32TypeInfo<DateTimeOffset>.WriteMetadata
	|
	|-RVA: 0x1B4BFF0 Offset: 0x1B4A5F0 VA: 0x181B4BFF0
	|-EnumUInt32TypeInfo<Decimal>.WriteMetadata
	|
	|-RVA: 0x1B4C110 Offset: 0x1B4A710 VA: 0x181B4C110
	|-EnumUInt32TypeInfo<EmptyStruct>.WriteMetadata
	|
	|-RVA: 0x1B4CAA0 Offset: 0x1B4B0A0 VA: 0x181B4CAA0
	|-EnumUInt32TypeInfo<double>.WriteMetadata
	|
	|-RVA: 0x1B4C470 Offset: 0x1B4AA70 VA: 0x181B4C470
	|-EnumUInt32TypeInfo<Guid>.WriteMetadata
	|
	|-RVA: 0x1B4C740 Offset: 0x1B4AD40 VA: 0x181B4C740
	|-EnumUInt32TypeInfo<short>.WriteMetadata
	|
	|-RVA: 0x1B4C980 Offset: 0x1B4AF80 VA: 0x181B4C980
	|-EnumUInt32TypeInfo<int>.WriteMetadata
	|
	|-RVA: 0x1B4C8F0 Offset: 0x1B4AEF0 VA: 0x181B4C8F0
	|-EnumUInt32TypeInfo<long>.WriteMetadata
	|
	|-RVA: 0x1B4C3E0 Offset: 0x1B4A9E0 VA: 0x181B4C3E0
	|-EnumUInt32TypeInfo<IntPtr>.WriteMetadata
	|
	|-RVA: 0x1B4C2C0 Offset: 0x1B4A8C0 VA: 0x181B4C2C0
	|-EnumUInt32TypeInfo<object>.WriteMetadata
	|
	|-RVA: 0x1B4CBC0 Offset: 0x1B4B1C0 VA: 0x181B4CBC0
	|-EnumUInt32TypeInfo<sbyte>.WriteMetadata
	|
	|-RVA: 0x1B4C620 Offset: 0x1B4AC20 VA: 0x181B4C620
	|-EnumUInt32TypeInfo<float>.WriteMetadata
	|
	|-RVA: 0x1B4CA10 Offset: 0x1B4B010 VA: 0x181B4CA10
	|-EnumUInt32TypeInfo<TimeSpan>.WriteMetadata
	|
	|-RVA: 0x1B4C350 Offset: 0x1B4A950 VA: 0x181B4C350
	|-EnumUInt32TypeInfo<ushort>.WriteMetadata
	|
	|-RVA: 0x1B4CB30 Offset: 0x1B4B130 VA: 0x181B4CB30
	|-EnumUInt32TypeInfo<uint>.WriteMetadata
	|
	|-RVA: 0x1B4C230 Offset: 0x1B4A830 VA: 0x181B4C230
	|-EnumUInt32TypeInfo<ulong>.WriteMetadata
	|
	|-RVA: 0x1B4C7D0 Offset: 0x1B4ADD0 VA: 0x181B4C7D0
	|-EnumUInt32TypeInfo<UIntPtr>.WriteMetadata
	*/

	public override void WriteData(TraceLoggingDataCollector collector, ref EnumType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B4BC20 Offset: 0x1B4A220 VA: 0x181B4BC20
	|-EnumUInt32TypeInfo<bool>.WriteData
	|
	|-RVA: 0x1B4B8E0 Offset: 0x1B49EE0 VA: 0x181B4B8E0
	|-EnumUInt32TypeInfo<byte>.WriteData
	|
	|-RVA: 0x1B4B650 Offset: 0x1B49C50 VA: 0x181B4B650
	|-EnumUInt32TypeInfo<char>.WriteData
	|
	|-RVA: 0x1B4BB70 Offset: 0x1B4A170 VA: 0x181B4BB70
	|-EnumUInt32TypeInfo<KeyValuePair<object, object>>.WriteData
	|
	|-RVA: 0x1B4B210 Offset: 0x1B49810 VA: 0x181B4B210
	|-EnumUInt32TypeInfo<DateTime>.WriteData
	|
	|-RVA: 0x1B4BE00 Offset: 0x1B4A400 VA: 0x181B4BE00
	|-EnumUInt32TypeInfo<DateTimeOffset>.WriteData
	|
	|-RVA: 0x1B4BAC0 Offset: 0x1B4A0C0 VA: 0x181B4BAC0
	|-EnumUInt32TypeInfo<Decimal>.WriteData
	|
	|-RVA: 0x1B4B470 Offset: 0x1B49A70 VA: 0x181B4B470
	|-EnumUInt32TypeInfo<EmptyStruct>.WriteData
	|
	|-RVA: 0x1B4BCC0 Offset: 0x1B4A2C0 VA: 0x181B4BCC0
	|-EnumUInt32TypeInfo<double>.WriteData
	|
	|-RVA: 0x1B4B6F0 Offset: 0x1B49CF0 VA: 0x181B4B6F0
	|-EnumUInt32TypeInfo<Guid>.WriteData
	|
	|-RVA: 0x1B4B2B0 Offset: 0x1B498B0 VA: 0x181B4B2B0
	|-EnumUInt32TypeInfo<short>.WriteData
	|
	|-RVA: 0x1B4B3E0 Offset: 0x1B499E0 VA: 0x181B4B3E0
	|-EnumUInt32TypeInfo<int>.WriteData
	|
	|-RVA: 0x1B4B7A0 Offset: 0x1B49DA0 VA: 0x181B4B7A0
	|-EnumUInt32TypeInfo<long>.WriteData
	|
	|-RVA: 0x1B4BEB0 Offset: 0x1B4A4B0 VA: 0x181B4BEB0
	|-EnumUInt32TypeInfo<IntPtr>.WriteData
	|
	|-RVA: 0x1B4BD60 Offset: 0x1B4A360 VA: 0x181B4BD60
	|-EnumUInt32TypeInfo<object>.WriteData
	|
	|-RVA: 0x1B4B5B0 Offset: 0x1B49BB0 VA: 0x181B4B5B0
	|-EnumUInt32TypeInfo<sbyte>.WriteData
	|
	|-RVA: 0x1B4B840 Offset: 0x1B49E40 VA: 0x181B4B840
	|-EnumUInt32TypeInfo<float>.WriteData
	|
	|-RVA: 0x1B4BF50 Offset: 0x1B4A550 VA: 0x181B4BF50
	|-EnumUInt32TypeInfo<TimeSpan>.WriteData
	|
	|-RVA: 0x1B4B510 Offset: 0x1B49B10 VA: 0x181B4B510
	|-EnumUInt32TypeInfo<ushort>.WriteData
	|
	|-RVA: 0x1B4B350 Offset: 0x1B49950 VA: 0x181B4B350
	|-EnumUInt32TypeInfo<uint>.WriteData
	|
	|-RVA: 0x1B4B980 Offset: 0x1B49F80 VA: 0x181B4B980
	|-EnumUInt32TypeInfo<ulong>.WriteData
	|
	|-RVA: 0x1B4BA20 Offset: 0x1B4A020 VA: 0x181B4BA20
	|-EnumUInt32TypeInfo<UIntPtr>.WriteData
	*/

	public override object GetData(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7D3460 Offset: 0x7D1A60 VA: 0x1807D3460
	|-EnumUInt32TypeInfo<bool>.GetData
	|-EnumUInt32TypeInfo<byte>.GetData
	|-EnumUInt32TypeInfo<char>.GetData
	|-EnumUInt32TypeInfo<KeyValuePair<object, object>>.GetData
	|-EnumUInt32TypeInfo<DateTime>.GetData
	|-EnumUInt32TypeInfo<DateTimeOffset>.GetData
	|-EnumUInt32TypeInfo<Decimal>.GetData
	|-EnumUInt32TypeInfo<EmptyStruct>.GetData
	|-EnumUInt32TypeInfo<double>.GetData
	|-EnumUInt32TypeInfo<Guid>.GetData
	|-EnumUInt32TypeInfo<short>.GetData
	|-EnumUInt32TypeInfo<int>.GetData
	|-EnumUInt32TypeInfo<long>.GetData
	|-EnumUInt32TypeInfo<IntPtr>.GetData
	|-EnumUInt32TypeInfo<object>.GetData
	|-EnumUInt32TypeInfo<sbyte>.GetData
	|-EnumUInt32TypeInfo<float>.GetData
	|-EnumUInt32TypeInfo<TimeSpan>.GetData
	|-EnumUInt32TypeInfo<ushort>.GetData
	|-EnumUInt32TypeInfo<uint>.GetData
	|-EnumUInt32TypeInfo<ulong>.GetData
	|-EnumUInt32TypeInfo<UIntPtr>.GetData
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19AD3A0 Offset: 0x19AB9A0 VA: 0x1819AD3A0
	|-EnumUInt32TypeInfo<bool>..ctor
	|-EnumUInt32TypeInfo<byte>..ctor
	|-EnumUInt32TypeInfo<char>..ctor
	|-EnumUInt32TypeInfo<KeyValuePair<object, object>>..ctor
	|-EnumUInt32TypeInfo<DateTime>..ctor
	|-EnumUInt32TypeInfo<DateTimeOffset>..ctor
	|-EnumUInt32TypeInfo<Decimal>..ctor
	|-EnumUInt32TypeInfo<EmptyStruct>..ctor
	|-EnumUInt32TypeInfo<double>..ctor
	|-EnumUInt32TypeInfo<Guid>..ctor
	|-EnumUInt32TypeInfo<short>..ctor
	|-EnumUInt32TypeInfo<int>..ctor
	|-EnumUInt32TypeInfo<long>..ctor
	|-EnumUInt32TypeInfo<IntPtr>..ctor
	|-EnumUInt32TypeInfo<object>..ctor
	|-EnumUInt32TypeInfo<sbyte>..ctor
	|-EnumUInt32TypeInfo<float>..ctor
	|-EnumUInt32TypeInfo<TimeSpan>..ctor
	|-EnumUInt32TypeInfo<ushort>..ctor
	|-EnumUInt32TypeInfo<uint>..ctor
	|-EnumUInt32TypeInfo<ulong>..ctor
	|-EnumUInt32TypeInfo<UIntPtr>..ctor
	*/

}

internal sealed class EnumInt64TypeInfo<EnumType> : TraceLoggingTypeInfo<EnumType> // TypeDefIndex: 1566
{
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2138470 Offset: 0x2136A70 VA: 0x182138470
	|-EnumInt64TypeInfo<bool>.WriteMetadata
	|
	|-RVA: 0x21387D0 Offset: 0x2136DD0 VA: 0x1821387D0
	|-EnumInt64TypeInfo<byte>.WriteMetadata
	|
	|-RVA: 0x2138980 Offset: 0x2136F80 VA: 0x182138980
	|-EnumInt64TypeInfo<char>.WriteMetadata
	|
	|-RVA: 0x2138740 Offset: 0x2136D40 VA: 0x182138740
	|-EnumInt64TypeInfo<KeyValuePair<object, object>>.WriteMetadata
	|
	|-RVA: 0x2138500 Offset: 0x2136B00 VA: 0x182138500
	|-EnumInt64TypeInfo<DateTime>.WriteMetadata
	|
	|-RVA: 0x2138CE0 Offset: 0x21372E0 VA: 0x182138CE0
	|-EnumInt64TypeInfo<DateTimeOffset>.WriteMetadata
	|
	|-RVA: 0x21383E0 Offset: 0x21369E0 VA: 0x1821383E0
	|-EnumInt64TypeInfo<Decimal>.WriteMetadata
	|
	|-RVA: 0x21382C0 Offset: 0x21368C0 VA: 0x1821382C0
	|-EnumInt64TypeInfo<EmptyStruct>.WriteMetadata
	|
	|-RVA: 0x21386B0 Offset: 0x2136CB0 VA: 0x1821386B0
	|-EnumInt64TypeInfo<double>.WriteMetadata
	|
	|-RVA: 0x2138860 Offset: 0x2136E60 VA: 0x182138860
	|-EnumInt64TypeInfo<Guid>.WriteMetadata
	|
	|-RVA: 0x2138AA0 Offset: 0x21370A0 VA: 0x182138AA0
	|-EnumInt64TypeInfo<short>.WriteMetadata
	|
	|-RVA: 0x2138230 Offset: 0x2136830 VA: 0x182138230
	|-EnumInt64TypeInfo<int>.WriteMetadata
	|
	|-RVA: 0x2138620 Offset: 0x2136C20 VA: 0x182138620
	|-EnumInt64TypeInfo<long>.WriteMetadata
	|
	|-RVA: 0x2138D70 Offset: 0x2137370 VA: 0x182138D70
	|-EnumInt64TypeInfo<IntPtr>.WriteMetadata
	|
	|-RVA: 0x2138A10 Offset: 0x2137010 VA: 0x182138A10
	|-EnumInt64TypeInfo<object>.WriteMetadata
	|
	|-RVA: 0x2138B30 Offset: 0x2137130 VA: 0x182138B30
	|-EnumInt64TypeInfo<sbyte>.WriteMetadata
	|
	|-RVA: 0x2138590 Offset: 0x2136B90 VA: 0x182138590
	|-EnumInt64TypeInfo<float>.WriteMetadata
	|
	|-RVA: 0x2138E00 Offset: 0x2137400 VA: 0x182138E00
	|-EnumInt64TypeInfo<TimeSpan>.WriteMetadata
	|
	|-RVA: 0x2138C50 Offset: 0x2137250 VA: 0x182138C50
	|-EnumInt64TypeInfo<ushort>.WriteMetadata
	|
	|-RVA: 0x2138350 Offset: 0x2136950 VA: 0x182138350
	|-EnumInt64TypeInfo<uint>.WriteMetadata
	|
	|-RVA: 0x2138BC0 Offset: 0x21371C0 VA: 0x182138BC0
	|-EnumInt64TypeInfo<ulong>.WriteMetadata
	|
	|-RVA: 0x21388F0 Offset: 0x2136EF0 VA: 0x1821388F0
	|-EnumInt64TypeInfo<UIntPtr>.WriteMetadata
	*/

	public override void WriteData(TraceLoggingDataCollector collector, ref EnumType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2137FA0 Offset: 0x21365A0 VA: 0x182137FA0
	|-EnumInt64TypeInfo<bool>.WriteData
	|
	|-RVA: 0x2137790 Offset: 0x2135D90 VA: 0x182137790
	|-EnumInt64TypeInfo<byte>.WriteData
	|
	|-RVA: 0x2137C90 Offset: 0x2136290 VA: 0x182137C90
	|-EnumInt64TypeInfo<char>.WriteData
	|
	|-RVA: 0x21380E0 Offset: 0x21366E0 VA: 0x1821380E0
	|-EnumInt64TypeInfo<KeyValuePair<object, object>>.WriteData
	|
	|-RVA: 0x2137830 Offset: 0x2135E30 VA: 0x182137830
	|-EnumInt64TypeInfo<DateTime>.WriteData
	|
	|-RVA: 0x21376E0 Offset: 0x2135CE0 VA: 0x1821376E0
	|-EnumInt64TypeInfo<DateTimeOffset>.WriteData
	|
	|-RVA: 0x2137AA0 Offset: 0x21360A0 VA: 0x182137AA0
	|-EnumInt64TypeInfo<Decimal>.WriteData
	|
	|-RVA: 0x21375A0 Offset: 0x2135BA0 VA: 0x1821375A0
	|-EnumInt64TypeInfo<EmptyStruct>.WriteData
	|
	|-RVA: 0x2138190 Offset: 0x2136790 VA: 0x182138190
	|-EnumInt64TypeInfo<double>.WriteData
	|
	|-RVA: 0x21374F0 Offset: 0x2135AF0 VA: 0x1821374F0
	|-EnumInt64TypeInfo<Guid>.WriteData
	|
	|-RVA: 0x2137E60 Offset: 0x2136460 VA: 0x182137E60
	|-EnumInt64TypeInfo<short>.WriteData
	|
	|-RVA: 0x2137D30 Offset: 0x2136330 VA: 0x182137D30
	|-EnumInt64TypeInfo<int>.WriteData
	|
	|-RVA: 0x2137A00 Offset: 0x2136000 VA: 0x182137A00
	|-EnumInt64TypeInfo<long>.WriteData
	|
	|-RVA: 0x2137DC0 Offset: 0x21363C0 VA: 0x182137DC0
	|-EnumInt64TypeInfo<IntPtr>.WriteData
	|
	|-RVA: 0x2137450 Offset: 0x2135A50 VA: 0x182137450
	|-EnumInt64TypeInfo<object>.WriteData
	|
	|-RVA: 0x2137F00 Offset: 0x2136500 VA: 0x182137F00
	|-EnumInt64TypeInfo<sbyte>.WriteData
	|
	|-RVA: 0x2138040 Offset: 0x2136640 VA: 0x182138040
	|-EnumInt64TypeInfo<float>.WriteData
	|
	|-RVA: 0x2137640 Offset: 0x2135C40 VA: 0x182137640
	|-EnumInt64TypeInfo<TimeSpan>.WriteData
	|
	|-RVA: 0x2137BF0 Offset: 0x21361F0 VA: 0x182137BF0
	|-EnumInt64TypeInfo<ushort>.WriteData
	|
	|-RVA: 0x2137970 Offset: 0x2135F70 VA: 0x182137970
	|-EnumInt64TypeInfo<uint>.WriteData
	|
	|-RVA: 0x21378D0 Offset: 0x2135ED0 VA: 0x1821378D0
	|-EnumInt64TypeInfo<ulong>.WriteData
	|
	|-RVA: 0x2137B50 Offset: 0x2136150 VA: 0x182137B50
	|-EnumInt64TypeInfo<UIntPtr>.WriteData
	*/

	public override object GetData(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7D3460 Offset: 0x7D1A60 VA: 0x1807D3460
	|-EnumInt64TypeInfo<bool>.GetData
	|-EnumInt64TypeInfo<byte>.GetData
	|-EnumInt64TypeInfo<char>.GetData
	|-EnumInt64TypeInfo<KeyValuePair<object, object>>.GetData
	|-EnumInt64TypeInfo<DateTime>.GetData
	|-EnumInt64TypeInfo<DateTimeOffset>.GetData
	|-EnumInt64TypeInfo<Decimal>.GetData
	|-EnumInt64TypeInfo<EmptyStruct>.GetData
	|-EnumInt64TypeInfo<double>.GetData
	|-EnumInt64TypeInfo<Guid>.GetData
	|-EnumInt64TypeInfo<short>.GetData
	|-EnumInt64TypeInfo<int>.GetData
	|-EnumInt64TypeInfo<long>.GetData
	|-EnumInt64TypeInfo<IntPtr>.GetData
	|-EnumInt64TypeInfo<object>.GetData
	|-EnumInt64TypeInfo<sbyte>.GetData
	|-EnumInt64TypeInfo<float>.GetData
	|-EnumInt64TypeInfo<TimeSpan>.GetData
	|-EnumInt64TypeInfo<ushort>.GetData
	|-EnumInt64TypeInfo<uint>.GetData
	|-EnumInt64TypeInfo<ulong>.GetData
	|-EnumInt64TypeInfo<UIntPtr>.GetData
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19AD3A0 Offset: 0x19AB9A0 VA: 0x1819AD3A0
	|-EnumInt64TypeInfo<bool>..ctor
	|-EnumInt64TypeInfo<byte>..ctor
	|-EnumInt64TypeInfo<char>..ctor
	|-EnumInt64TypeInfo<KeyValuePair<object, object>>..ctor
	|-EnumInt64TypeInfo<DateTime>..ctor
	|-EnumInt64TypeInfo<DateTimeOffset>..ctor
	|-EnumInt64TypeInfo<Decimal>..ctor
	|-EnumInt64TypeInfo<EmptyStruct>..ctor
	|-EnumInt64TypeInfo<double>..ctor
	|-EnumInt64TypeInfo<Guid>..ctor
	|-EnumInt64TypeInfo<short>..ctor
	|-EnumInt64TypeInfo<int>..ctor
	|-EnumInt64TypeInfo<long>..ctor
	|-EnumInt64TypeInfo<IntPtr>..ctor
	|-EnumInt64TypeInfo<object>..ctor
	|-EnumInt64TypeInfo<sbyte>..ctor
	|-EnumInt64TypeInfo<float>..ctor
	|-EnumInt64TypeInfo<TimeSpan>..ctor
	|-EnumInt64TypeInfo<ushort>..ctor
	|-EnumInt64TypeInfo<uint>..ctor
	|-EnumInt64TypeInfo<ulong>..ctor
	|-EnumInt64TypeInfo<UIntPtr>..ctor
	*/

}

internal sealed class EnumUInt64TypeInfo<EnumType> : TraceLoggingTypeInfo<EnumType> // TypeDefIndex: 1567
{
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B4E570 Offset: 0x1B4CB70 VA: 0x181B4E570
	|-EnumUInt64TypeInfo<bool>.WriteMetadata
	|
	|-RVA: 0x1B4DF40 Offset: 0x1B4C540 VA: 0x181B4DF40
	|-EnumUInt64TypeInfo<byte>.WriteMetadata
	|
	|-RVA: 0x1B4DC70 Offset: 0x1B4C270 VA: 0x181B4DC70
	|-EnumUInt64TypeInfo<char>.WriteMetadata
	|
	|-RVA: 0x1B4E3C0 Offset: 0x1B4C9C0 VA: 0x181B4E3C0
	|-EnumUInt64TypeInfo<KeyValuePair<object, object>>.WriteMetadata
	|
	|-RVA: 0x1B4E450 Offset: 0x1B4CA50 VA: 0x181B4E450
	|-EnumUInt64TypeInfo<DateTime>.WriteMetadata
	|
	|-RVA: 0x1B4DD90 Offset: 0x1B4C390 VA: 0x181B4DD90
	|-EnumUInt64TypeInfo<DateTimeOffset>.WriteMetadata
	|
	|-RVA: 0x1B4DB50 Offset: 0x1B4C150 VA: 0x181B4DB50
	|-EnumUInt64TypeInfo<Decimal>.WriteMetadata
	|
	|-RVA: 0x1B4DBE0 Offset: 0x1B4C1E0 VA: 0x181B4DBE0
	|-EnumUInt64TypeInfo<EmptyStruct>.WriteMetadata
	|
	|-RVA: 0x1B4E330 Offset: 0x1B4C930 VA: 0x181B4E330
	|-EnumUInt64TypeInfo<double>.WriteMetadata
	|
	|-RVA: 0x1B4DEB0 Offset: 0x1B4C4B0 VA: 0x181B4DEB0
	|-EnumUInt64TypeInfo<Guid>.WriteMetadata
	|
	|-RVA: 0x1B4E2A0 Offset: 0x1B4C8A0 VA: 0x181B4E2A0
	|-EnumUInt64TypeInfo<short>.WriteMetadata
	|
	|-RVA: 0x1B4E0F0 Offset: 0x1B4C6F0 VA: 0x181B4E0F0
	|-EnumUInt64TypeInfo<int>.WriteMetadata
	|
	|-RVA: 0x1B4E600 Offset: 0x1B4CC00 VA: 0x181B4E600
	|-EnumUInt64TypeInfo<long>.WriteMetadata
	|
	|-RVA: 0x1B4E210 Offset: 0x1B4C810 VA: 0x181B4E210
	|-EnumUInt64TypeInfo<IntPtr>.WriteMetadata
	|
	|-RVA: 0x1B4DA30 Offset: 0x1B4C030 VA: 0x181B4DA30
	|-EnumUInt64TypeInfo<object>.WriteMetadata
	|
	|-RVA: 0x1B4DD00 Offset: 0x1B4C300 VA: 0x181B4DD00
	|-EnumUInt64TypeInfo<sbyte>.WriteMetadata
	|
	|-RVA: 0x1B4E4E0 Offset: 0x1B4CAE0 VA: 0x181B4E4E0
	|-EnumUInt64TypeInfo<float>.WriteMetadata
	|
	|-RVA: 0x1B4E180 Offset: 0x1B4C780 VA: 0x181B4E180
	|-EnumUInt64TypeInfo<TimeSpan>.WriteMetadata
	|
	|-RVA: 0x1B4DFD0 Offset: 0x1B4C5D0 VA: 0x181B4DFD0
	|-EnumUInt64TypeInfo<ushort>.WriteMetadata
	|
	|-RVA: 0x1B4DE20 Offset: 0x1B4C420 VA: 0x181B4DE20
	|-EnumUInt64TypeInfo<uint>.WriteMetadata
	|
	|-RVA: 0x1B4DAC0 Offset: 0x1B4C0C0 VA: 0x181B4DAC0
	|-EnumUInt64TypeInfo<ulong>.WriteMetadata
	|
	|-RVA: 0x1B4E060 Offset: 0x1B4C660 VA: 0x181B4E060
	|-EnumUInt64TypeInfo<UIntPtr>.WriteMetadata
	*/

	public override void WriteData(TraceLoggingDataCollector collector, ref EnumType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B4CED0 Offset: 0x1B4B4D0 VA: 0x181B4CED0
	|-EnumUInt64TypeInfo<bool>.WriteData
	|
	|-RVA: 0x1B4D0C0 Offset: 0x1B4B6C0 VA: 0x181B4D0C0
	|-EnumUInt64TypeInfo<byte>.WriteData
	|
	|-RVA: 0x1B4CE30 Offset: 0x1B4B430 VA: 0x181B4CE30
	|-EnumUInt64TypeInfo<char>.WriteData
	|
	|-RVA: 0x1B4D6E0 Offset: 0x1B4BCE0 VA: 0x181B4D6E0
	|-EnumUInt64TypeInfo<KeyValuePair<object, object>>.WriteData
	|
	|-RVA: 0x1B4D640 Offset: 0x1B4BC40 VA: 0x181B4D640
	|-EnumUInt64TypeInfo<DateTime>.WriteData
	|
	|-RVA: 0x1B4CF70 Offset: 0x1B4B570 VA: 0x181B4CF70
	|-EnumUInt64TypeInfo<DateTimeOffset>.WriteData
	|
	|-RVA: 0x1B4D8E0 Offset: 0x1B4BEE0 VA: 0x181B4D8E0
	|-EnumUInt64TypeInfo<Decimal>.WriteData
	|
	|-RVA: 0x1B4D5A0 Offset: 0x1B4BBA0 VA: 0x181B4D5A0
	|-EnumUInt64TypeInfo<EmptyStruct>.WriteData
	|
	|-RVA: 0x1B4D3D0 Offset: 0x1B4B9D0 VA: 0x181B4D3D0
	|-EnumUInt64TypeInfo<double>.WriteData
	|
	|-RVA: 0x1B4D790 Offset: 0x1B4BD90 VA: 0x181B4D790
	|-EnumUInt64TypeInfo<Guid>.WriteData
	|
	|-RVA: 0x1B4D020 Offset: 0x1B4B620 VA: 0x181B4D020
	|-EnumUInt64TypeInfo<short>.WriteData
	|
	|-RVA: 0x1B4D2A0 Offset: 0x1B4B8A0 VA: 0x181B4D2A0
	|-EnumUInt64TypeInfo<int>.WriteData
	|
	|-RVA: 0x1B4D160 Offset: 0x1B4B760 VA: 0x181B4D160
	|-EnumUInt64TypeInfo<long>.WriteData
	|
	|-RVA: 0x1B4D990 Offset: 0x1B4BF90 VA: 0x181B4D990
	|-EnumUInt64TypeInfo<IntPtr>.WriteData
	|
	|-RVA: 0x1B4D840 Offset: 0x1B4BE40 VA: 0x181B4D840
	|-EnumUInt64TypeInfo<object>.WriteData
	|
	|-RVA: 0x1B4D200 Offset: 0x1B4B800 VA: 0x181B4D200
	|-EnumUInt64TypeInfo<sbyte>.WriteData
	|
	|-RVA: 0x1B4CD90 Offset: 0x1B4B390 VA: 0x181B4CD90
	|-EnumUInt64TypeInfo<float>.WriteData
	|
	|-RVA: 0x1B4D330 Offset: 0x1B4B930 VA: 0x181B4D330
	|-EnumUInt64TypeInfo<TimeSpan>.WriteData
	|
	|-RVA: 0x1B4D470 Offset: 0x1B4BA70 VA: 0x181B4D470
	|-EnumUInt64TypeInfo<ushort>.WriteData
	|
	|-RVA: 0x1B4D510 Offset: 0x1B4BB10 VA: 0x181B4D510
	|-EnumUInt64TypeInfo<uint>.WriteData
	|
	|-RVA: 0x1B4CC50 Offset: 0x1B4B250 VA: 0x181B4CC50
	|-EnumUInt64TypeInfo<ulong>.WriteData
	|
	|-RVA: 0x1B4CCF0 Offset: 0x1B4B2F0 VA: 0x181B4CCF0
	|-EnumUInt64TypeInfo<UIntPtr>.WriteData
	*/

	public override object GetData(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7D3460 Offset: 0x7D1A60 VA: 0x1807D3460
	|-EnumUInt64TypeInfo<bool>.GetData
	|-EnumUInt64TypeInfo<byte>.GetData
	|-EnumUInt64TypeInfo<char>.GetData
	|-EnumUInt64TypeInfo<KeyValuePair<object, object>>.GetData
	|-EnumUInt64TypeInfo<DateTime>.GetData
	|-EnumUInt64TypeInfo<DateTimeOffset>.GetData
	|-EnumUInt64TypeInfo<Decimal>.GetData
	|-EnumUInt64TypeInfo<EmptyStruct>.GetData
	|-EnumUInt64TypeInfo<double>.GetData
	|-EnumUInt64TypeInfo<Guid>.GetData
	|-EnumUInt64TypeInfo<short>.GetData
	|-EnumUInt64TypeInfo<int>.GetData
	|-EnumUInt64TypeInfo<long>.GetData
	|-EnumUInt64TypeInfo<IntPtr>.GetData
	|-EnumUInt64TypeInfo<object>.GetData
	|-EnumUInt64TypeInfo<sbyte>.GetData
	|-EnumUInt64TypeInfo<float>.GetData
	|-EnumUInt64TypeInfo<TimeSpan>.GetData
	|-EnumUInt64TypeInfo<ushort>.GetData
	|-EnumUInt64TypeInfo<uint>.GetData
	|-EnumUInt64TypeInfo<ulong>.GetData
	|-EnumUInt64TypeInfo<UIntPtr>.GetData
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19AD3A0 Offset: 0x19AB9A0 VA: 0x1819AD3A0
	|-EnumUInt64TypeInfo<bool>..ctor
	|-EnumUInt64TypeInfo<byte>..ctor
	|-EnumUInt64TypeInfo<char>..ctor
	|-EnumUInt64TypeInfo<KeyValuePair<object, object>>..ctor
	|-EnumUInt64TypeInfo<DateTime>..ctor
	|-EnumUInt64TypeInfo<DateTimeOffset>..ctor
	|-EnumUInt64TypeInfo<Decimal>..ctor
	|-EnumUInt64TypeInfo<EmptyStruct>..ctor
	|-EnumUInt64TypeInfo<double>..ctor
	|-EnumUInt64TypeInfo<Guid>..ctor
	|-EnumUInt64TypeInfo<short>..ctor
	|-EnumUInt64TypeInfo<int>..ctor
	|-EnumUInt64TypeInfo<long>..ctor
	|-EnumUInt64TypeInfo<IntPtr>..ctor
	|-EnumUInt64TypeInfo<object>..ctor
	|-EnumUInt64TypeInfo<sbyte>..ctor
	|-EnumUInt64TypeInfo<float>..ctor
	|-EnumUInt64TypeInfo<TimeSpan>..ctor
	|-EnumUInt64TypeInfo<ushort>..ctor
	|-EnumUInt64TypeInfo<uint>..ctor
	|-EnumUInt64TypeInfo<ulong>..ctor
	|-EnumUInt64TypeInfo<UIntPtr>..ctor
	*/

}

internal class EnumMap : ObjectMap // TypeDefIndex: 2130
{	private readonly EnumMap.EnumMapMember[] _members; // 0x10
	private readonly bool _isFlags; // 0x18
	private readonly string[] _enumNames; // 0x20
	private readonly string[] _xmlNames; // 0x28
	private readonly long[] _values; // 0x30

	public bool IsFlags { get; }
	public string[] EnumNames { get; }
	public string[] XmlNames { get; }
	public long[] Values { get; }


	public void .ctor(EnumMap.EnumMapMember[] members, bool isFlags) { }

	public bool get_IsFlags() { }

	public string[] get_EnumNames() { }

	public string[] get_XmlNames() { }

	public long[] get_Values() { }

	public string GetXmlName(string typeName, object enumValue) { }

	public string GetEnumName(string typeName, string xmlName) { }

}

public class EnumMap.EnumMapMember // TypeDefIndex: 2131
{	private readonly string _xmlName; // 0x10
	private readonly string _enumName; // 0x18
	private readonly long _value; // 0x20

	public string XmlName { get; }
	public string EnumName { get; }
	public long Value { get; }


	public void .ctor(string xmlName, string enumName, long value) { }

	public string get_XmlName() { }

	public string get_EnumName() { }

	public long get_Value() { }

}

public class EnumConverter : TypeConverter // TypeDefIndex: 2701
{	private TypeConverter.StandardValuesCollection values; // 0x10
	private Type type; // 0x18

	protected virtual IComparer Comparer { get; }


	public void .ctor(Type type) { }

	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	protected virtual IComparer get_Comparer() { }

	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	public override bool IsValid(ITypeDescriptorContext context, object value) { }

}

public static class Enumerable // TypeDefIndex: 3198
{
	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static IEnumerable<TSource> Where<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B9500 Offset: 0x4B7B00 VA: 0x1804B9500
	|-Enumerable.Where<BaseNetworkable>
	|-Enumerable.Where<ConsoleSystem.Command>
	|-Enumerable.Where<ConstructionGrade>
	|-Enumerable.Where<CraftingQueueIcon>
	|-Enumerable.Where<Input.Button>
	|-Enumerable.Where<GameManifest.PrefabProperties>
	|-Enumerable.Where<GenerateDungeonGrid.PathNode>
	|-Enumerable.Where<GeneratePowerlineLayout.PathNode>
	|-Enumerable.Where<GenerateRoadLayout.PathNode>
	|-Enumerable.Where<IPlayerInfo>
	|-Enumerable.Where<IPlayerItem>
	|-Enumerable.Where<IPlayerItemDefinition>
	|-Enumerable.Where<Item>
	|-Enumerable.Where<ItemBlueprint>
	|-Enumerable.Where<ItemDefinition>
	|-Enumerable.Where<ItemModWearable>
	|-Enumerable.Where<TrackChunk>
	|-Enumerable.Where<ITempoMapValuesCache>
	|-Enumerable.Where<ValueChange<TimeSignature>>
	|-Enumerable.Where<PieMenu.MenuOption>
	|-Enumerable.Where<Prefab>
	|-Enumerable.Where<ProjectileWeaponMod>
	|-Enumerable.Where<PathData>
	|-Enumerable.Where<PrefabData>
	|-Enumerable.Where<SteamInventoryItem>
	|-Enumerable.Where<Skinnable>
	|-Enumerable.Where<InventoryRecipe[]>
	|-Enumerable.Where<FileInfo>
	|-Enumerable.Where<ConstructorInfo>
	|-Enumerable.Where<FieldInfo>
	|-Enumerable.Where<MemberInfo>
	|-Enumerable.Where<PropertyInfo>
	|-Enumerable.Where<string>
	|-Enumerable.Where<Type>
	|-Enumerable.Where<Collider>
	|-Enumerable.Where<PlayerEditorConnectionEvents.MessageTypeSubscribers>
	|-Enumerable.Where<Object>
	|-Enumerable.Where<Renderer>
	|-Enumerable.Where<Transform>
	|-Enumerable.Where<Toggle>
	|-Enumerable.Where<WeatherPreset>
	|-Enumerable.Where<object>
	|
	|-RVA: 0x4B7070 Offset: 0x4B5670 VA: 0x1804B7070
	|-Enumerable.Where<SkeletonDefinition.Bone>
	|
	|-RVA: 0x4B9D70 Offset: 0x4B8370 VA: 0x1804B9D70
	|-Enumerable.Where<GameStat.Stat>
	|
	|-RVA: 0x4B9AA0 Offset: 0x4B80A0 VA: 0x1804B9AA0
	|-Enumerable.Where<ItemSkinDirectory.Skin>
	|
	|-RVA: 0x4B8C90 Offset: 0x4B7290 VA: 0x1804B8C90
	|-Enumerable.Where<ProjectileWeaponMod.Modifier>
	|
	|-RVA: 0x4B8F60 Offset: 0x4B7560 VA: 0x1804B8F60
	|-Enumerable.Where<Option>
	|
	|-RVA: 0x4B97D0 Offset: 0x4B7DD0 VA: 0x1804B97D0
	|-Enumerable.Where<ServerInfo>
	|
	|-RVA: 0x4B9230 Offset: 0x4B7830 VA: 0x1804B9230
	|-Enumerable.Where<SkinnedMultiMesh.Part>
	|
	|-RVA: 0x4B7E80 Offset: 0x4B6480 VA: 0x1804B7E80
	|-Enumerable.Where<InventoryItem>
	|
	|-RVA: 0x4B7610 Offset: 0x4B5C10 VA: 0x1804B7610
	|-Enumerable.Where<InventoryRecipe.Ingredient>
	|
	|-RVA: 0x4B8150 Offset: 0x4B6750 VA: 0x1804B8150
	|-Enumerable.Where<InventoryRecipe>
	|
	|-RVA: 0x4B7340 Offset: 0x4B5940 VA: 0x1804B7340
	|-Enumerable.Where<char>
	|
	|-RVA: 0x4B8420 Offset: 0x4B6A20 VA: 0x1804B8420
	|-Enumerable.Where<KeyValuePair<string, AssetBundle>>
	|-Enumerable.Where<KeyValuePair<Type, PostProcessBundle>>
	|-Enumerable.Where<KeyValuePair<object, object>>
	|
	|-RVA: 0x4B86F0 Offset: 0x4B6CF0 VA: 0x1804B86F0
	|-Enumerable.Where<KeyValuePair<uint, FileStorage.CacheData>>
	|-Enumerable.Where<KeyValuePair<uint, object>>
	|
	|-RVA: 0x4B89C0 Offset: 0x4B6FC0 VA: 0x1804B89C0
	|-Enumerable.Where<KeyValuePair<ulong, Dispatch.ResultCallback>>
	|
	|-RVA: 0x4B7BB0 Offset: 0x4B61B0 VA: 0x1804B7BB0
	|-Enumerable.Where<int>
	|
	|-RVA: 0x4B78E0 Offset: 0x4B5EE0 VA: 0x1804B78E0
	|-Enumerable.Where<KeyCode>
	|-Enumerable.Where<Int32Enum>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static IEnumerable<TResult> Select<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC8AF20 Offset: 0xC89520 VA: 0x180C8AF20
	|-Enumerable.Select<BaseNetworkable, Debugging.EntityInfo>
	|-Enumerable.Select<object, Debugging.EntityInfo>
	|
	|-RVA: 0x4B6060 Offset: 0x4B4660 VA: 0x1804B6060
	|-Enumerable.Select<BaseViewModel, string>
	|-Enumerable.Select<Input.Button, string>
	|-Enumerable.Select<Manifest.ServerDesc, string>
	|-Enumerable.Select<GameManifest.PrefabProperties, string>
	|-Enumerable.Select<IPlayerInfo, string>
	|-Enumerable.Select<ItemDefinition, ItemModWearable>
	|-Enumerable.Select<TrackChunk, EventsCollection>
	|-Enumerable.Select<JsonProperty, string>
	|-Enumerable.Select<PathData, PathList>
	|-Enumerable.Select<SteamItemDefinition, InventoryDef>
	|-Enumerable.Select<SteamInventoryItem, Task<IPlayerInventory>>
	|-Enumerable.Select<Skinnable, string>
	|-Enumerable.Select<InventoryDef, IPlayerItemDefinition>
	|-Enumerable.Select<InventoryDef, SteamItemDefinition>
	|-Enumerable.Select<InventoryDef, InventoryRecipe[]>
	|-Enumerable.Select<InventoryDef, string>
	|-Enumerable.Select<StackFrame, Report.StackTrace.StackFrame>
	|-Enumerable.Select<IGrouping<uint, BaseNetworkable>, BaseNetworkable>
	|-Enumerable.Select<IGrouping<AssetBundle, string>, LoadAssetsResult>
	|-Enumerable.Select<object, Type>
	|-Enumerable.Select<FieldInfo, ParameterOverride>
	|-Enumerable.Select<ParameterInfo, Type>
	|-Enumerable.Select<EnumMemberAttribute, string>
	|-Enumerable.Select<string, Report.StackTrace.StackFrame>
	|-Enumerable.Select<string, string>
	|-Enumerable.Select<string, Match>
	|-Enumerable.Select<Match, string>
	|-Enumerable.Select<GameObject, ItemBlueprint>
	|-Enumerable.Select<GameObject, ItemDefinition>
	|-Enumerable.Select<Toggle, SteamInventoryItem>
	|-Enumerable.Select<object, object>
	|
	|-RVA: 0xC865B0 Offset: 0xC84BB0 VA: 0x180C865B0
	|-Enumerable.Select<SkeletonDefinition.Bone, GameObject>
	|-Enumerable.Select<SkeletonDefinition.Bone, Transform>
	|-Enumerable.Select<SkeletonDefinition.Bone, object>
	|
	|-RVA: 0xC8C0C0 Offset: 0xC8A6C0 VA: 0x180C8C0C0
	|-Enumerable.Select<GenerateDungeonGrid.PathNode, PathFinder.Point>
	|-Enumerable.Select<GeneratePowerlineLayout.PathNode, PathFinder.Point>
	|-Enumerable.Select<GenerateRoadLayout.PathNode, PathFinder.Point>
	|-Enumerable.Select<object, PathFinder.Point>
	|
	|-RVA: 0x4B54A0 Offset: 0x4B3AA0 VA: 0x1804B54A0
	|-Enumerable.Select<ItemBlueprint, int>
	|-Enumerable.Select<EventsCollection, int>
	|-Enumerable.Select<object, int>
	|
	|-RVA: 0xC8AC30 Offset: 0xC89230 VA: 0x180C8AC30
	|-Enumerable.Select<PlayerItemRecipe, IPlayerItemDefinition>
	|-Enumerable.Select<PlayerItemRecipe, object>
	|
	|-RVA: 0xC8BAE0 Offset: 0xC8A0E0 VA: 0x180C8BAE0
	|-Enumerable.Select<ProjectileWeaponMod, ProjectileWeaponMod.Modifier>
	|-Enumerable.Select<object, ProjectileWeaponMod.Modifier>
	|
	|-RVA: 0xC8A360 Offset: 0xC88960 VA: 0x180C8A360
	|-Enumerable.Select<ProjectileWeaponMod.Modifier, float>
	|
	|-RVA: 0xC8B500 Offset: 0xC89B00 VA: 0x180C8B500
	|-Enumerable.Select<SteamItem, InventoryItem>
	|-Enumerable.Select<object, InventoryItem>
	|
	|-RVA: 0xC8A650 Offset: 0xC88C50 VA: 0x180C8A650
	|-Enumerable.Select<Option, Option>
	|
	|-RVA: 0xC8BDD0 Offset: 0xC8A3D0 VA: 0x180C8BDD0
	|-Enumerable.Select<OptionAttribute, Option>
	|-Enumerable.Select<object, Option>
	|
	|-RVA: 0x4B4EC0 Offset: 0x4B34C0 VA: 0x1804B4EC0
	|-Enumerable.Select<ServerBrowserTag, bool>
	|-Enumerable.Select<object, bool>
	|
	|-RVA: 0xC8C6A0 Offset: 0xC8ACA0 VA: 0x180C8C6A0
	|-Enumerable.Select<ServerInfo, string>
	|-Enumerable.Select<ServerInfo, object>
	|
	|-RVA: 0xC85CE0 Offset: 0xC842E0 VA: 0x180C85CE0
	|-Enumerable.Select<Achievement, <>f__AnonymousType0<string, string, bool>>
	|-Enumerable.Select<Achievement, object>
	|
	|-RVA: 0xC888F0 Offset: 0xC86EF0 VA: 0x180C888F0
	|-Enumerable.Select<InventoryDefId, InventoryDef>
	|-Enumerable.Select<InventoryDefId, object>
	|
	|-RVA: 0xC8C990 Offset: 0xC8AF90 VA: 0x180C8C990
	|-Enumerable.Select<ServerInfo, ServerInfo>
	|
	|-RVA: 0xC87170 Offset: 0xC85770 VA: 0x180C87170
	|-Enumerable.Select<Friend, SteamPlayer>
	|-Enumerable.Select<Friend, object>
	|
	|-RVA: 0xC891C0 Offset: 0xC877C0 VA: 0x180C891C0
	|-Enumerable.Select<InventoryItem, SteamItem>
	|-Enumerable.Select<InventoryItem, object>
	|
	|-RVA: 0xC88ED0 Offset: 0xC874D0 VA: 0x180C88ED0
	|-Enumerable.Select<InventoryItem, InventoryItemId>
	|
	|-RVA: 0xC894B0 Offset: 0xC87AB0 VA: 0x180C894B0
	|-Enumerable.Select<InventoryItem, uint>
	|
	|-RVA: 0xC85FD0 Offset: 0xC845D0 VA: 0x180C85FD0
	|-Enumerable.Select<InventoryItem.Amount, InventoryItemId>
	|
	|-RVA: 0xC862C0 Offset: 0xC848C0 VA: 0x180C862C0
	|-Enumerable.Select<InventoryItem.Amount, uint>
	|
	|-RVA: 0xC897A0 Offset: 0xC87DA0 VA: 0x180C897A0
	|-Enumerable.Select<InventoryRecipe, PlayerItemRecipe>
	|
	|-RVA: 0xC87750 Offset: 0xC85D50 VA: 0x180C87750
	|-Enumerable.Select<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>
	|
	|-RVA: 0xC87A40 Offset: 0xC86040 VA: 0x180C87A40
	|-Enumerable.Select<InventoryRecipe.Ingredient, string>
	|-Enumerable.Select<InventoryRecipe.Ingredient, object>
	|
	|-RVA: 0xC89A90 Offset: 0xC88090 VA: 0x180C89A90
	|-Enumerable.Select<KeyValuePair<Type, PostProcessBundle>, PostProcessBundle>
	|-Enumerable.Select<KeyValuePair<object, object>, object>
	|
	|-RVA: 0xC8A070 Offset: 0xC88670 VA: 0x180C8A070
	|-Enumerable.Select<KeyValuePair<uint, FileStorage.CacheData>, uint>
	|-Enumerable.Select<KeyValuePair<uint, object>, uint>
	|
	|-RVA: 0xC89D80 Offset: 0xC88380 VA: 0x180C89D80
	|-Enumerable.Select<KeyValuePair<uint, Indexer.Entity>, Indexer.Entity>
	|-Enumerable.Select<KeyValuePair<uint, object>, object>
	|
	|-RVA: 0xC88020 Offset: 0xC86620 VA: 0x180C88020
	|-Enumerable.Select<int, FourBitNumber>
	|
	|-RVA: 0xC88600 Offset: 0xC86C00 VA: 0x180C88600
	|-Enumerable.Select<int, SevenBitNumber>
	|
	|-RVA: 0xC88310 Offset: 0xC86910 VA: 0x180C88310
	|-Enumerable.Select<int, int>
	|
	|-RVA: 0x4B5A80 Offset: 0x4B4080 VA: 0x1804B5A80
	|-Enumerable.Select<IGrouping<string, Transform>, KeyValuePair<Transform, int>>
	|-Enumerable.Select<object, KeyValuePair<object, int>>
	|
	|-RVA: 0x4B5D70 Offset: 0x4B4370 VA: 0x1804B5D70
	|-Enumerable.Select<IGrouping<Vector2Int, Resolution>, Resolution>
	|-Enumerable.Select<object, Resolution>
	|
	|-RVA: 0xC8B210 Offset: 0xC89810 VA: 0x180C8B210
	|-Enumerable.Select<string, InventoryRecipe.Ingredient>
	|-Enumerable.Select<object, InventoryRecipe.Ingredient>
	|
	|-RVA: 0xC8B7F0 Offset: 0xC89DF0 VA: 0x180C8B7F0
	|-Enumerable.Select<string, InventoryRecipe>
	|-Enumerable.Select<object, InventoryRecipe>
	|
	|-RVA: 0x4B51B0 Offset: 0x4B37B0 VA: 0x1804B51B0
	|-Enumerable.Select<string, KeyCode>
	|-Enumerable.Select<object, Int32Enum>
	|
	|-RVA: 0xC87D30 Offset: 0xC86330 VA: 0x180C87D30
	|-Enumerable.Select<KeyCode, string>
	|-Enumerable.Select<Int32Enum, object>
	|
	|-RVA: 0xC868A0 Offset: 0xC84EA0 VA: 0x180C868A0
	|-Enumerable.Select<BurstCloth.Chain, int>
	|
	|-RVA: 0xC86B90 Offset: 0xC85190 VA: 0x180C86B90
	|-Enumerable.Select<WeightedStringList.Container, float>
	|
	|-RVA: 0xC87460 Offset: 0xC85A60 VA: 0x180C87460
	|-Enumerable.Select<PlayerItemRecipe.Ingredient, int>
	|
	|-RVA: 0xC8C3B0 Offset: 0xC8A9B0 VA: 0x180C8C3B0
	|-Enumerable.Select<ServerInfo, int>
	|
	|-RVA: 0xC8A940 Offset: 0xC88F40 VA: 0x180C8A940
	|-Enumerable.Select<SkinnedMultiMesh.Part, long>
	|
	|-RVA: 0xC88BE0 Offset: 0xC871E0 VA: 0x180C88BE0
	|-Enumerable.Select<InventoryItem, int>
	|
	|-RVA: 0xC86E80 Offset: 0xC85480 VA: 0x180C86E80
	|-Enumerable.Select<DictionaryEntry, KeyValuePair<object, object>>
	|
	|-RVA: 0x4B5790 Offset: 0x4B3D90 VA: 0x1804B5790
	|-Enumerable.Select<object, long>
	|
	|-RVA: 0x4B6350 Offset: 0x4B4950 VA: 0x1804B6350
	|-Enumerable.Select<object, float>
	*/

	private static Func<TSource, bool> CombinePredicates<TSource>(Func<TSource, bool> predicate1, Func<TSource, bool> predicate2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B1A940 Offset: 0x1B18F40 VA: 0x181B1A940
	|-Enumerable.CombinePredicates<Debugging.EntityInfo>
	|-Enumerable.CombinePredicates<SkeletonDefinition.Bone>
	|-Enumerable.CombinePredicates<GameStat.Stat>
	|-Enumerable.CombinePredicates<ItemSkinDirectory.Skin>
	|-Enumerable.CombinePredicates<FourBitNumber>
	|-Enumerable.CombinePredicates<SevenBitNumber>
	|-Enumerable.CombinePredicates<PathFinder.Point>
	|-Enumerable.CombinePredicates<PlayerItemRecipe.Ingredient>
	|-Enumerable.CombinePredicates<PlayerItemRecipe>
	|-Enumerable.CombinePredicates<ProjectileWeaponMod.Modifier>
	|-Enumerable.CombinePredicates<Option>
	|-Enumerable.CombinePredicates<ServerInfo>
	|-Enumerable.CombinePredicates<SkinnedMultiMesh.Part>
	|-Enumerable.CombinePredicates<InventoryItemId>
	|-Enumerable.CombinePredicates<InventoryItem>
	|-Enumerable.CombinePredicates<InventoryRecipe.Ingredient>
	|-Enumerable.CombinePredicates<InventoryRecipe>
	|-Enumerable.CombinePredicates<bool>
	|-Enumerable.CombinePredicates<char>
	|-Enumerable.CombinePredicates<KeyValuePair<object, int>>
	|-Enumerable.CombinePredicates<KeyValuePair<object, object>>
	|-Enumerable.CombinePredicates<KeyValuePair<uint, object>>
	|-Enumerable.CombinePredicates<KeyValuePair<ulong, Dispatch.ResultCallback>>
	|-Enumerable.CombinePredicates<int>
	|-Enumerable.CombinePredicates<Int32Enum>
	|-Enumerable.CombinePredicates<long>
	|-Enumerable.CombinePredicates<object>
	|-Enumerable.CombinePredicates<float>
	|-Enumerable.CombinePredicates<uint>
	|-Enumerable.CombinePredicates<Resolution>
	*/

	private static Func<TSource, TResult> CombineSelectors<TSource, TMiddle, TResult>(Func<TSource, TMiddle> selector1, Func<TMiddle, TResult> selector2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1179BC0 Offset: 0x11781C0 VA: 0x181179BC0
	|-Enumerable.CombineSelectors<BurstCloth.Chain, FourBitNumber, FourBitNumber>
	|-Enumerable.CombineSelectors<BurstCloth.Chain, SevenBitNumber, SevenBitNumber>
	|-Enumerable.CombineSelectors<BurstCloth.Chain, int, FourBitNumber>
	|-Enumerable.CombineSelectors<BurstCloth.Chain, int, SevenBitNumber>
	|-Enumerable.CombineSelectors<BurstCloth.Chain, int, int>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, Debugging.EntityInfo, Debugging.EntityInfo>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, PathFinder.Point, PathFinder.Point>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, Option, Option>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, InventoryItem, InventoryItem>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, InventoryRecipe, InventoryRecipe>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, bool, bool>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, KeyValuePair<object, int>, KeyValuePair<object, int>>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, int, int>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, Int32Enum, Int32Enum>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, long, long>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, object, Debugging.EntityInfo>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, object, PathFinder.Point>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, object, ProjectileWeaponMod.Modifier>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, object, Option>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, object, InventoryItem>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, object, InventoryRecipe.Ingredient>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, object, InventoryRecipe>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, object, bool>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, object, KeyValuePair<object, int>>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, object, int>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, object, Int32Enum>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, object, long>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, object, object>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, object, float>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, object, Resolution>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, float, float>
	|-Enumerable.CombineSelectors<SkeletonDefinition.Bone, Resolution, Resolution>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, Debugging.EntityInfo, Debugging.EntityInfo>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, PathFinder.Point, PathFinder.Point>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, Option, Option>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, InventoryItem, InventoryItem>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, InventoryRecipe, InventoryRecipe>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, bool, bool>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, KeyValuePair<object, int>, KeyValuePair<object, int>>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, int, int>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, Int32Enum, Int32Enum>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, long, long>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, object, Debugging.EntityInfo>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, object, PathFinder.Point>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, object, ProjectileWeaponMod.Modifier>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, object, Option>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, object, InventoryItem>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, object, InventoryRecipe.Ingredient>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, object, InventoryRecipe>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, object, bool>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, object, KeyValuePair<object, int>>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, object, int>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, object, Int32Enum>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, object, long>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, object, object>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, object, float>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, object, Resolution>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, float, float>
	|-Enumerable.CombineSelectors<PlayerItemRecipe, Resolution, Resolution>
	|-Enumerable.CombineSelectors<PlayerItemRecipe.Ingredient, FourBitNumber, FourBitNumber>
	|-Enumerable.CombineSelectors<PlayerItemRecipe.Ingredient, SevenBitNumber, SevenBitNumber>
	|-Enumerable.CombineSelectors<PlayerItemRecipe.Ingredient, int, FourBitNumber>
	|-Enumerable.CombineSelectors<PlayerItemRecipe.Ingredient, int, SevenBitNumber>
	|-Enumerable.CombineSelectors<PlayerItemRecipe.Ingredient, int, int>
	|-Enumerable.CombineSelectors<Option, Option, Option>
	|-Enumerable.CombineSelectors<ServerInfo, Debugging.EntityInfo, Debugging.EntityInfo>
	|-Enumerable.CombineSelectors<ServerInfo, FourBitNumber, FourBitNumber>
	|-Enumerable.CombineSelectors<ServerInfo, SevenBitNumber, SevenBitNumber>
	|-Enumerable.CombineSelectors<ServerInfo, PathFinder.Point, PathFinder.Point>
	|-Enumerable.CombineSelectors<ServerInfo, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>
	|-Enumerable.CombineSelectors<ServerInfo, Option, Option>
	|-Enumerable.CombineSelectors<ServerInfo, InventoryItem, InventoryItem>
	|-Enumerable.CombineSelectors<ServerInfo, InventoryRecipe, InventoryRecipe>
	|-Enumerable.CombineSelectors<ServerInfo, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>
	|-Enumerable.CombineSelectors<ServerInfo, bool, bool>
	|-Enumerable.CombineSelectors<ServerInfo, KeyValuePair<object, int>, KeyValuePair<object, int>>
	|-Enumerable.CombineSelectors<ServerInfo, int, FourBitNumber>
	|-Enumerable.CombineSelectors<ServerInfo, int, SevenBitNumber>
	|-Enumerable.CombineSelectors<ServerInfo, int, int>
	|-Enumerable.CombineSelectors<ServerInfo, Int32Enum, Int32Enum>
	|-Enumerable.CombineSelectors<ServerInfo, long, long>
	|-Enumerable.CombineSelectors<ServerInfo, object, Debugging.EntityInfo>
	|-Enumerable.CombineSelectors<ServerInfo, object, PathFinder.Point>
	|-Enumerable.CombineSelectors<ServerInfo, object, ProjectileWeaponMod.Modifier>
	|-Enumerable.CombineSelectors<ServerInfo, object, Option>
	|-Enumerable.CombineSelectors<ServerInfo, object, InventoryItem>
	|-Enumerable.CombineSelectors<ServerInfo, object, InventoryRecipe.Ingredient>
	|-Enumerable.CombineSelectors<ServerInfo, object, InventoryRecipe>
	|-Enumerable.CombineSelectors<ServerInfo, object, bool>
	|-Enumerable.CombineSelectors<ServerInfo, object, KeyValuePair<object, int>>
	|-Enumerable.CombineSelectors<ServerInfo, object, int>
	|-Enumerable.CombineSelectors<ServerInfo, object, Int32Enum>
	|-Enumerable.CombineSelectors<ServerInfo, object, long>
	|-Enumerable.CombineSelectors<ServerInfo, object, object>
	|-Enumerable.CombineSelectors<ServerInfo, object, float>
	|-Enumerable.CombineSelectors<ServerInfo, object, Resolution>
	|-Enumerable.CombineSelectors<ServerInfo, float, float>
	|-Enumerable.CombineSelectors<ServerInfo, Resolution, Resolution>
	|-Enumerable.CombineSelectors<Achievement, Debugging.EntityInfo, Debugging.EntityInfo>
	|-Enumerable.CombineSelectors<Achievement, PathFinder.Point, PathFinder.Point>
	|-Enumerable.CombineSelectors<Achievement, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>
	|-Enumerable.CombineSelectors<Achievement, Option, Option>
	|-Enumerable.CombineSelectors<Achievement, InventoryItem, InventoryItem>
	|-Enumerable.CombineSelectors<Achievement, InventoryRecipe, InventoryRecipe>
	|-Enumerable.CombineSelectors<Achievement, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>
	|-Enumerable.CombineSelectors<Achievement, bool, bool>
	|-Enumerable.CombineSelectors<Achievement, KeyValuePair<object, int>, KeyValuePair<object, int>>
	|-Enumerable.CombineSelectors<Achievement, int, int>
	|-Enumerable.CombineSelectors<Achievement, Int32Enum, Int32Enum>
	|-Enumerable.CombineSelectors<Achievement, long, long>
	|-Enumerable.CombineSelectors<Achievement, object, Debugging.EntityInfo>
	|-Enumerable.CombineSelectors<Achievement, object, PathFinder.Point>
	|-Enumerable.CombineSelectors<Achievement, object, ProjectileWeaponMod.Modifier>
	|-Enumerable.CombineSelectors<Achievement, object, Option>
	|-Enumerable.CombineSelectors<Achievement, object, InventoryItem>
	|-Enumerable.CombineSelectors<Achievement, object, InventoryRecipe.Ingredient>
	|-Enumerable.CombineSelectors<Achievement, object, InventoryRecipe>
	|-Enumerable.CombineSelectors<Achievement, object, bool>
	|-Enumerable.CombineSelectors<Achievement, object, KeyValuePair<object, int>>
	|-Enumerable.CombineSelectors<Achievement, object, int>
	|-Enumerable.CombineSelectors<Achievement, object, Int32Enum>
	|-Enumerable.CombineSelectors<Achievement, object, long>
	|-Enumerable.CombineSelectors<Achievement, object, object>
	|-Enumerable.CombineSelectors<Achievement, object, float>
	|-Enumerable.CombineSelectors<Achievement, object, Resolution>
	|-Enumerable.CombineSelectors<Achievement, float, float>
	|-Enumerable.CombineSelectors<Achievement, Resolution, Resolution>
	|-Enumerable.CombineSelectors<InventoryDefId, Debugging.EntityInfo, Debugging.EntityInfo>
	|-Enumerable.CombineSelectors<InventoryDefId, PathFinder.Point, PathFinder.Point>
	|-Enumerable.CombineSelectors<InventoryDefId, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>
	|-Enumerable.CombineSelectors<InventoryDefId, Option, Option>
	|-Enumerable.CombineSelectors<InventoryDefId, InventoryItem, InventoryItem>
	|-Enumerable.CombineSelectors<InventoryDefId, InventoryRecipe, InventoryRecipe>
	|-Enumerable.CombineSelectors<InventoryDefId, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>
	|-Enumerable.CombineSelectors<InventoryDefId, bool, bool>
	|-Enumerable.CombineSelectors<InventoryDefId, KeyValuePair<object, int>, KeyValuePair<object, int>>
	|-Enumerable.CombineSelectors<InventoryDefId, int, int>
	|-Enumerable.CombineSelectors<InventoryDefId, Int32Enum, Int32Enum>
	|-Enumerable.CombineSelectors<InventoryDefId, long, long>
	|-Enumerable.CombineSelectors<InventoryDefId, object, Debugging.EntityInfo>
	|-Enumerable.CombineSelectors<InventoryDefId, object, PathFinder.Point>
	|-Enumerable.CombineSelectors<InventoryDefId, object, ProjectileWeaponMod.Modifier>
	|-Enumerable.CombineSelectors<InventoryDefId, object, Option>
	|-Enumerable.CombineSelectors<InventoryDefId, object, InventoryItem>
	|-Enumerable.CombineSelectors<InventoryDefId, object, InventoryRecipe.Ingredient>
	|-Enumerable.CombineSelectors<InventoryDefId, object, InventoryRecipe>
	|-Enumerable.CombineSelectors<InventoryDefId, object, bool>
	|-Enumerable.CombineSelectors<InventoryDefId, object, KeyValuePair<object, int>>
	|-Enumerable.CombineSelectors<InventoryDefId, object, int>
	|-Enumerable.CombineSelectors<InventoryDefId, object, Int32Enum>
	|-Enumerable.CombineSelectors<InventoryDefId, object, long>
	|-Enumerable.CombineSelectors<InventoryDefId, object, object>
	|-Enumerable.CombineSelectors<InventoryDefId, object, float>
	|-Enumerable.CombineSelectors<InventoryDefId, object, Resolution>
	|-Enumerable.CombineSelectors<InventoryDefId, float, float>
	|-Enumerable.CombineSelectors<InventoryDefId, Resolution, Resolution>
	|-Enumerable.CombineSelectors<ServerInfo, ServerInfo, int>
	|-Enumerable.CombineSelectors<ServerInfo, ServerInfo, object>
	|-Enumerable.CombineSelectors<ServerInfo, int, int>
	|-Enumerable.CombineSelectors<ServerInfo, object, object>
	|-Enumerable.CombineSelectors<Friend, Debugging.EntityInfo, Debugging.EntityInfo>
	|-Enumerable.CombineSelectors<Friend, PathFinder.Point, PathFinder.Point>
	|-Enumerable.CombineSelectors<Friend, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>
	|-Enumerable.CombineSelectors<Friend, Option, Option>
	|-Enumerable.CombineSelectors<Friend, InventoryItem, InventoryItem>
	|-Enumerable.CombineSelectors<Friend, InventoryRecipe, InventoryRecipe>
	|-Enumerable.CombineSelectors<Friend, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>
	|-Enumerable.CombineSelectors<Friend, bool, bool>
	|-Enumerable.CombineSelectors<Friend, KeyValuePair<object, int>, KeyValuePair<object, int>>
	|-Enumerable.CombineSelectors<Friend, int, int>
	|-Enumerable.CombineSelectors<Friend, Int32Enum, Int32Enum>
	|-Enumerable.CombineSelectors<Friend, long, long>
	|-Enumerable.CombineSelectors<Friend, object, Debugging.EntityInfo>
	|-Enumerable.CombineSelectors<Friend, object, PathFinder.Point>
	|-Enumerable.CombineSelectors<Friend, object, ProjectileWeaponMod.Modifier>
	|-Enumerable.CombineSelectors<Friend, object, Option>
	|-Enumerable.CombineSelectors<Friend, object, InventoryItem>
	|-Enumerable.CombineSelectors<Friend, object, InventoryRecipe.Ingredient>
	|-Enumerable.CombineSelectors<Friend, object, InventoryRecipe>
	|-Enumerable.CombineSelectors<Friend, object, bool>
	|-Enumerable.CombineSelectors<Friend, object, KeyValuePair<object, int>>
	|-Enumerable.CombineSelectors<Friend, object, int>
	|-Enumerable.CombineSelectors<Friend, object, Int32Enum>
	|-Enumerable.CombineSelectors<Friend, object, long>
	|-Enumerable.CombineSelectors<Friend, object, object>
	|-Enumerable.CombineSelectors<Friend, object, float>
	|-Enumerable.CombineSelectors<Friend, object, Resolution>
	|-Enumerable.CombineSelectors<Friend, float, float>
	|-Enumerable.CombineSelectors<Friend, Resolution, Resolution>
	|-Enumerable.CombineSelectors<InventoryItem, Debugging.EntityInfo, Debugging.EntityInfo>
	|-Enumerable.CombineSelectors<InventoryItem, FourBitNumber, FourBitNumber>
	|-Enumerable.CombineSelectors<InventoryItem, SevenBitNumber, SevenBitNumber>
	|-Enumerable.CombineSelectors<InventoryItem, PathFinder.Point, PathFinder.Point>
	|-Enumerable.CombineSelectors<InventoryItem, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>
	|-Enumerable.CombineSelectors<InventoryItem, Option, Option>
	|-Enumerable.CombineSelectors<InventoryItem, InventoryItem, InventoryItem>
	|-Enumerable.CombineSelectors<InventoryItem, InventoryRecipe, InventoryRecipe>
	|-Enumerable.CombineSelectors<InventoryItem, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>
	|-Enumerable.CombineSelectors<InventoryItem, bool, bool>
	|-Enumerable.CombineSelectors<InventoryItem, KeyValuePair<object, int>, KeyValuePair<object, int>>
	|-Enumerable.CombineSelectors<InventoryItem, int, FourBitNumber>
	|-Enumerable.CombineSelectors<InventoryItem, int, SevenBitNumber>
	|-Enumerable.CombineSelectors<InventoryItem, int, int>
	|-Enumerable.CombineSelectors<InventoryItem, Int32Enum, Int32Enum>
	|-Enumerable.CombineSelectors<InventoryItem, long, long>
	|-Enumerable.CombineSelectors<InventoryItem, object, Debugging.EntityInfo>
	|-Enumerable.CombineSelectors<InventoryItem, object, PathFinder.Point>
	|-Enumerable.CombineSelectors<InventoryItem, object, ProjectileWeaponMod.Modifier>
	|-Enumerable.CombineSelectors<InventoryItem, object, Option>
	|-Enumerable.CombineSelectors<InventoryItem, object, InventoryItem>
	|-Enumerable.CombineSelectors<InventoryItem, object, InventoryRecipe.Ingredient>
	|-Enumerable.CombineSelectors<InventoryItem, object, InventoryRecipe>
	|-Enumerable.CombineSelectors<InventoryItem, object, bool>
	|-Enumerable.CombineSelectors<InventoryItem, object, KeyValuePair<object, int>>
	|-Enumerable.CombineSelectors<InventoryItem, object, int>
	|-Enumerable.CombineSelectors<InventoryItem, object, Int32Enum>
	|-Enumerable.CombineSelectors<InventoryItem, object, long>
	|-Enumerable.CombineSelectors<InventoryItem, object, object>
	|-Enumerable.CombineSelectors<InventoryItem, object, float>
	|-Enumerable.CombineSelectors<InventoryItem, object, Resolution>
	|-Enumerable.CombineSelectors<InventoryItem, float, float>
	|-Enumerable.CombineSelectors<InventoryItem, Resolution, Resolution>
	|-Enumerable.CombineSelectors<InventoryRecipe, PlayerItemRecipe, object>
	|-Enumerable.CombineSelectors<InventoryRecipe, object, object>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, Debugging.EntityInfo, Debugging.EntityInfo>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, PathFinder.Point, PathFinder.Point>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient, int>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, Option, Option>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, InventoryItem, InventoryItem>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, InventoryRecipe, InventoryRecipe>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, bool, bool>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, KeyValuePair<object, int>, KeyValuePair<object, int>>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, int, int>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, Int32Enum, Int32Enum>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, long, long>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, object, Debugging.EntityInfo>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, object, PathFinder.Point>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, object, ProjectileWeaponMod.Modifier>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, object, Option>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, object, InventoryItem>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, object, InventoryRecipe.Ingredient>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, object, InventoryRecipe>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, object, bool>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, object, KeyValuePair<object, int>>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, object, int>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, object, Int32Enum>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, object, long>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, object, object>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, object, float>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, object, Resolution>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, float, float>
	|-Enumerable.CombineSelectors<InventoryRecipe.Ingredient, Resolution, Resolution>
	|-Enumerable.CombineSelectors<DictionaryEntry, KeyValuePair<object, object>, object>
	|-Enumerable.CombineSelectors<DictionaryEntry, object, object>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, Debugging.EntityInfo, Debugging.EntityInfo>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, PathFinder.Point, PathFinder.Point>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, Option, Option>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, InventoryItem, InventoryItem>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, InventoryRecipe, InventoryRecipe>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, bool, bool>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, KeyValuePair<object, int>, KeyValuePair<object, int>>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, int, int>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, Int32Enum, Int32Enum>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, long, long>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, Debugging.EntityInfo>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, PathFinder.Point>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, ProjectileWeaponMod.Modifier>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, Option>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, InventoryItem>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, InventoryRecipe.Ingredient>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, InventoryRecipe>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, bool>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, KeyValuePair<object, int>>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, int>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, Int32Enum>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, long>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, object>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, float>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, Resolution>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, float, float>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, Resolution, Resolution>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, Debugging.EntityInfo, Debugging.EntityInfo>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, PathFinder.Point, PathFinder.Point>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, Option, Option>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, InventoryItem, InventoryItem>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, InventoryRecipe, InventoryRecipe>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, bool, bool>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, KeyValuePair<object, int>, KeyValuePair<object, int>>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, int, int>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, Int32Enum, Int32Enum>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, long, long>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, object, Debugging.EntityInfo>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, object, PathFinder.Point>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, object, ProjectileWeaponMod.Modifier>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, object, Option>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, object, InventoryItem>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, object, InventoryRecipe.Ingredient>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, object, InventoryRecipe>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, object, bool>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, object, KeyValuePair<object, int>>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, object, int>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, object, Int32Enum>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, object, long>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, object, object>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, object, float>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, object, Resolution>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, float, float>
	|-Enumerable.CombineSelectors<KeyValuePair<uint, object>, Resolution, Resolution>
	|-Enumerable.CombineSelectors<int, int, FourBitNumber>
	|-Enumerable.CombineSelectors<int, int, SevenBitNumber>
	|-Enumerable.CombineSelectors<int, int, int>
	|-Enumerable.CombineSelectors<Int32Enum, Debugging.EntityInfo, Debugging.EntityInfo>
	|-Enumerable.CombineSelectors<Int32Enum, PathFinder.Point, PathFinder.Point>
	|-Enumerable.CombineSelectors<Int32Enum, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>
	|-Enumerable.CombineSelectors<Int32Enum, Option, Option>
	|-Enumerable.CombineSelectors<Int32Enum, InventoryItem, InventoryItem>
	|-Enumerable.CombineSelectors<Int32Enum, InventoryRecipe, InventoryRecipe>
	|-Enumerable.CombineSelectors<Int32Enum, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>
	|-Enumerable.CombineSelectors<Int32Enum, bool, bool>
	|-Enumerable.CombineSelectors<Int32Enum, KeyValuePair<object, int>, KeyValuePair<object, int>>
	|-Enumerable.CombineSelectors<Int32Enum, int, int>
	|-Enumerable.CombineSelectors<Int32Enum, Int32Enum, Int32Enum>
	|-Enumerable.CombineSelectors<Int32Enum, long, long>
	|-Enumerable.CombineSelectors<Int32Enum, object, Debugging.EntityInfo>
	|-Enumerable.CombineSelectors<Int32Enum, object, PathFinder.Point>
	|-Enumerable.CombineSelectors<Int32Enum, object, ProjectileWeaponMod.Modifier>
	|-Enumerable.CombineSelectors<Int32Enum, object, Option>
	|-Enumerable.CombineSelectors<Int32Enum, object, InventoryItem>
	|-Enumerable.CombineSelectors<Int32Enum, object, InventoryRecipe.Ingredient>
	|-Enumerable.CombineSelectors<Int32Enum, object, InventoryRecipe>
	|-Enumerable.CombineSelectors<Int32Enum, object, bool>
	|-Enumerable.CombineSelectors<Int32Enum, object, KeyValuePair<object, int>>
	|-Enumerable.CombineSelectors<Int32Enum, object, int>
	|-Enumerable.CombineSelectors<Int32Enum, object, Int32Enum>
	|-Enumerable.CombineSelectors<Int32Enum, object, long>
	|-Enumerable.CombineSelectors<Int32Enum, object, object>
	|-Enumerable.CombineSelectors<Int32Enum, object, float>
	|-Enumerable.CombineSelectors<Int32Enum, object, Resolution>
	|-Enumerable.CombineSelectors<Int32Enum, float, float>
	|-Enumerable.CombineSelectors<Int32Enum, Resolution, Resolution>
	|-Enumerable.CombineSelectors<object, FourBitNumber, FourBitNumber>
	|-Enumerable.CombineSelectors<object, SevenBitNumber, SevenBitNumber>
	|-Enumerable.CombineSelectors<object, PlayerItemRecipe, PlayerItemRecipe>
	|-Enumerable.CombineSelectors<object, PlayerItemRecipe.Ingredient, PlayerItemRecipe.Ingredient>
	|-Enumerable.CombineSelectors<object, ProjectileWeaponMod.Modifier, float>
	|-Enumerable.CombineSelectors<object, Option, Option>
	|-Enumerable.CombineSelectors<object, InventoryItemId, InventoryItemId>
	|-Enumerable.CombineSelectors<object, InventoryItem, InventoryItemId>
	|-Enumerable.CombineSelectors<object, InventoryItem, int>
	|-Enumerable.CombineSelectors<object, InventoryItem, object>
	|-Enumerable.CombineSelectors<object, InventoryItem, uint>
	|-Enumerable.CombineSelectors<object, InventoryRecipe, PlayerItemRecipe>
	|-Enumerable.CombineSelectors<object, InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>
	|-Enumerable.CombineSelectors<object, InventoryRecipe.Ingredient, object>
	|-Enumerable.CombineSelectors<object, int, FourBitNumber>
	|-Enumerable.CombineSelectors<object, int, SevenBitNumber>
	|-Enumerable.CombineSelectors<object, int, int>
	|-Enumerable.CombineSelectors<object, Int32Enum, object>
	|-Enumerable.CombineSelectors<object, object, Debugging.EntityInfo>
	|-Enumerable.CombineSelectors<object, object, PathFinder.Point>
	|-Enumerable.CombineSelectors<object, object, ProjectileWeaponMod.Modifier>
	|-Enumerable.CombineSelectors<object, object, Option>
	|-Enumerable.CombineSelectors<object, object, InventoryItem>
	|-Enumerable.CombineSelectors<object, object, InventoryRecipe.Ingredient>
	|-Enumerable.CombineSelectors<object, object, InventoryRecipe>
	|-Enumerable.CombineSelectors<object, object, bool>
	|-Enumerable.CombineSelectors<object, object, KeyValuePair<object, int>>
	|-Enumerable.CombineSelectors<object, object, int>
	|-Enumerable.CombineSelectors<object, object, Int32Enum>
	|-Enumerable.CombineSelectors<object, object, long>
	|-Enumerable.CombineSelectors<object, object, object>
	|-Enumerable.CombineSelectors<object, object, float>
	|-Enumerable.CombineSelectors<object, object, Resolution>
	|-Enumerable.CombineSelectors<object, uint, uint>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static IEnumerable<TResult> SelectMany<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B4D80 Offset: 0x4B3380 VA: 0x1804B4D80
	|-Enumerable.SelectMany<SteamInventoryItem, PlayerItemRecipe>
	|-Enumerable.SelectMany<object, PlayerItemRecipe>
	|
	|-RVA: 0x4B4CE0 Offset: 0x4B32E0 VA: 0x1804B4CE0
	|-Enumerable.SelectMany<InventoryRecipe[], InventoryRecipe>
	|-Enumerable.SelectMany<object, InventoryRecipe>
	|
	|-RVA: 0x4B4C40 Offset: 0x4B3240 VA: 0x1804B4C40
	|-Enumerable.SelectMany<byte[], byte>
	|-Enumerable.SelectMany<object, byte>
	|
	|-RVA: 0x4B4E20 Offset: 0x4B3420 VA: 0x1804B4E20
	|-Enumerable.SelectMany<Assembly, Type>
	|-Enumerable.SelectMany<Type, MemberInfo>
	|-Enumerable.SelectMany<object, object>
	*/

	[IteratorStateMachineAttribute] // RVA: 0xC2120 Offset: 0xC1520 VA: 0x1800C2120
	private static IEnumerable<TResult> SelectManyIterator<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B4BA0 Offset: 0x4B31A0 VA: 0x1804B4BA0
	|-Enumerable.SelectManyIterator<object, PlayerItemRecipe>
	|
	|-RVA: 0x4B4B00 Offset: 0x4B3100 VA: 0x1804B4B00
	|-Enumerable.SelectManyIterator<object, InventoryRecipe>
	|
	|-RVA: 0x4B3F90 Offset: 0x4B2590 VA: 0x1804B3F90
	|-Enumerable.SelectManyIterator<object, byte>
	|
	|-RVA: 0x4B4030 Offset: 0x4B2630 VA: 0x1804B4030
	|-Enumerable.SelectManyIterator<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static IEnumerable<TSource> Take<TSource>(IEnumerable<TSource> source, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B6D30 Offset: 0x4B5330 VA: 0x1804B6D30
	|-Enumerable.Take<ConsoleSystem.Command>
	|-Enumerable.Take<ItemBlueprint>
	|-Enumerable.Take<ItemDefinition>
	|-Enumerable.Take<ItemModWearable>
	|-Enumerable.Take<string>
	|-Enumerable.Take<object>
	|
	|-RVA: 0x4B6CB0 Offset: 0x4B52B0 VA: 0x1804B6CB0
	|-Enumerable.Take<Option>
	|
	|-RVA: 0x4B6C30 Offset: 0x4B5230 VA: 0x1804B6C30
	|-Enumerable.Take<InventoryItem>
	|
	|-RVA: 0x4B6B30 Offset: 0x4B5130 VA: 0x1804B6B30
	|-Enumerable.Take<byte>
	|
	|-RVA: 0x4B6BB0 Offset: 0x4B51B0 VA: 0x1804B6BB0
	|-Enumerable.Take<double>
	*/

	[IteratorStateMachineAttribute] // RVA: 0xC3610 Offset: 0xC2A10 VA: 0x1800C3610
	private static IEnumerable<TSource> TakeIterator<TSource>(IEnumerable<TSource> source, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B6A00 Offset: 0x4B5000 VA: 0x1804B6A00
	|-Enumerable.TakeIterator<Option>
	|-Enumerable.TakeIterator<InventoryItem>
	|
	|-RVA: 0x4B68E0 Offset: 0x4B4EE0 VA: 0x1804B68E0
	|-Enumerable.TakeIterator<byte>
	|
	|-RVA: 0x4B6970 Offset: 0x4B4F70 VA: 0x1804B6970
	|-Enumerable.TakeIterator<double>
	|-Enumerable.TakeIterator<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static IEnumerable<TSource> TakeWhile<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B6A90 Offset: 0x4B5090 VA: 0x1804B6A90
	|-Enumerable.TakeWhile<MetricTempoMapValuesCache.AccumulatedMicroseconds>
	|-Enumerable.TakeWhile<object>
	*/

	[IteratorStateMachineAttribute] // RVA: 0xC3860 Offset: 0xC2C60 VA: 0x1800C3860
	private static IEnumerable<TSource> TakeWhileIterator<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B4030 Offset: 0x4B2630 VA: 0x1804B4030
	|-Enumerable.TakeWhileIterator<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static IEnumerable<TSource> Skip<TSource>(IEnumerable<TSource> source, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B67E0 Offset: 0x4B4DE0 VA: 0x1804B67E0
	|-Enumerable.Skip<double>
	|
	|-RVA: 0x4B6860 Offset: 0x4B4E60 VA: 0x1804B6860
	|-Enumerable.Skip<string>
	|-Enumerable.Skip<object>
	|
	|-RVA: 0x4B6760 Offset: 0x4B4D60 VA: 0x1804B6760
	|-Enumerable.Skip<byte>
	*/

	[IteratorStateMachineAttribute] // RVA: 0xC3B30 Offset: 0xC2F30 VA: 0x1800C3B30
	private static IEnumerable<TSource> SkipIterator<TSource>(IEnumerable<TSource> source, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B6640 Offset: 0x4B4C40 VA: 0x1804B6640
	|-Enumerable.SkipIterator<byte>
	|
	|-RVA: 0x4B66D0 Offset: 0x4B4CD0 VA: 0x1804B66D0
	|-Enumerable.SkipIterator<double>
	|-Enumerable.SkipIterator<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED4840 Offset: 0xED2E40 VA: 0x180ED4840
	|-Enumerable.OrderBy<BaseViewModel, string>
	|-Enumerable.OrderBy<ConstructionGrade, BuildingGrade.Enum>
	|-Enumerable.OrderBy<Demos.DemoInfo, DateTime>
	|-Enumerable.OrderBy<Demos.DemoInfo, string>
	|-Enumerable.OrderBy<Demos.DemoInfo, TimeSpan>
	|-Enumerable.OrderBy<AccountNotice, bool>
	|-Enumerable.OrderBy<Hero, Guid>
	|-Enumerable.OrderBy<HitboxDefinition, int>
	|-Enumerable.OrderBy<ItemDefinition, float>
	|-Enumerable.OrderBy<ItemDefinition, string>
	|-Enumerable.OrderBy<ItemIcon, int>
	|-Enumerable.OrderBy<ItemModWearable, Guid>
	|-Enumerable.OrderBy<MusicTheme, float>
	|-Enumerable.OrderBy<JsonProperty, int>
	|-Enumerable.OrderBy<PieMenu.MenuOption, int>
	|-Enumerable.OrderBy<ServerInfo, int>
	|-Enumerable.OrderBy<ServerInfo, string>
	|-Enumerable.OrderBy<ServerInfo, uint>
	|-Enumerable.OrderBy<double, double>
	|-Enumerable.OrderBy<IGrouping<ItemCategory, ItemDefinition>, ItemCategory>
	|-Enumerable.OrderBy<object, string>
	|-Enumerable.OrderBy<FieldInfo, int>
	|-Enumerable.OrderBy<string, Guid>
	|-Enumerable.OrderBy<string, string>
	|-Enumerable.OrderBy<KerningPair, uint>
	|-Enumerable.OrderBy<TMP_Character, uint>
	|-Enumerable.OrderBy<TMP_GlyphPairAdjustmentRecord, uint>
	|-Enumerable.OrderBy<Glyph, uint>
	|-Enumerable.OrderBy<Transform, object>
	|-Enumerable.OrderBy<Demos.DemoInfo, object>
	|-Enumerable.OrderBy<ServerInfo, object>
	|-Enumerable.OrderBy<object, bool>
	|-Enumerable.OrderBy<object, Guid>
	|-Enumerable.OrderBy<object, int>
	|-Enumerable.OrderBy<object, Int32Enum>
	|-Enumerable.OrderBy<object, object>
	|-Enumerable.OrderBy<object, float>
	|-Enumerable.OrderBy<object, uint>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED48C0 Offset: 0xED2EC0 VA: 0x180ED48C0
	|-Enumerable.OrderBy<string, string>
	|-Enumerable.OrderBy<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED47C0 Offset: 0xED2DC0 VA: 0x180ED47C0
	|-Enumerable.OrderByDescending<Demos.DemoInfo, DateTime>
	|-Enumerable.OrderByDescending<Demos.DemoInfo, string>
	|-Enumerable.OrderByDescending<Demos.DemoInfo, TimeSpan>
	|-Enumerable.OrderByDescending<GenerateDungeonBase.DungeonSegment, float>
	|-Enumerable.OrderByDescending<IPlayerInfo, int>
	|-Enumerable.OrderByDescending<IPlayerItem, DateTimeOffset>
	|-Enumerable.OrderByDescending<ItemBlueprint, bool>
	|-Enumerable.OrderByDescending<Prefab<DungeonGridLink>, int>
	|-Enumerable.OrderByDescending<ServerInfo, int>
	|-Enumerable.OrderByDescending<ServerInfo, string>
	|-Enumerable.OrderByDescending<ServerInfo, uint>
	|-Enumerable.OrderByDescending<Item, DateTime>
	|-Enumerable.OrderByDescending<KeyValuePair<IPAddress, int>, int>
	|-Enumerable.OrderByDescending<KeyValuePair<string, Stats.Node>, long>
	|-Enumerable.OrderByDescending<KeyValuePair<Type, Pool.ICollection>, long>
	|-Enumerable.OrderByDescending<KeyValuePair<Type, long>, long>
	|-Enumerable.OrderByDescending<KeyValuePair<Transform, int>, int>
	|-Enumerable.OrderByDescending<IGrouping<string, Animator>, int>
	|-Enumerable.OrderByDescending<IGrouping<string, Collider>, int>
	|-Enumerable.OrderByDescending<IGrouping<string, LODGroup>, int>
	|-Enumerable.OrderByDescending<IGrouping<string, Rigidbody>, int>
	|-Enumerable.OrderByDescending<IGrouping<string, Transform>, int>
	|-Enumerable.OrderByDescending<IGrouping<Type, Object>, int>
	|-Enumerable.OrderByDescending<IGrouping<uint, BaseNetworkable>, int>
	|-Enumerable.OrderByDescending<Resolution, int>
	|-Enumerable.OrderByDescending<Demos.DemoInfo, object>
	|-Enumerable.OrderByDescending<ServerInfo, object>
	|-Enumerable.OrderByDescending<KeyValuePair<object, int>, int>
	|-Enumerable.OrderByDescending<KeyValuePair<object, long>, long>
	|-Enumerable.OrderByDescending<KeyValuePair<object, object>, long>
	|-Enumerable.OrderByDescending<object, bool>
	|-Enumerable.OrderByDescending<object, DateTimeOffset>
	|-Enumerable.OrderByDescending<object, int>
	|-Enumerable.OrderByDescending<object, object>
	|-Enumerable.OrderByDescending<object, float>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static IOrderedEnumerable<TSource> ThenBy<TSource, TKey>(IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED4E70 Offset: 0xED3470 VA: 0x180ED4E70
	|-Enumerable.ThenBy<IPlayerInfo, string>
	|-Enumerable.ThenBy<object, object>
	|
	|-RVA: 0xED4D60 Offset: 0xED3360 VA: 0x180ED4D60
	|-Enumerable.ThenBy<ItemBlueprint, Rarity>
	|-Enumerable.ThenBy<object, Int32Enum>
	|
	|-RVA: 0xED4EF0 Offset: 0xED34F0 VA: 0x180ED4EF0
	|-Enumerable.ThenBy<KerningPair, uint>
	|-Enumerable.ThenBy<TMP_GlyphPairAdjustmentRecord, uint>
	|-Enumerable.ThenBy<object, uint>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static IOrderedEnumerable<TSource> ThenByDescending<TSource, TKey>(IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED4AC0 Offset: 0xED30C0 VA: 0x180ED4AC0
	|-Enumerable.ThenByDescending<AccountNotice, DateTime>
	|-Enumerable.ThenByDescending<object, DateTime>
	|
	|-RVA: 0xED4BD0 Offset: 0xED31D0 VA: 0x180ED4BD0
	|-Enumerable.ThenByDescending<ItemBlueprint, int>
	|-Enumerable.ThenByDescending<object, int>
	|
	|-RVA: 0xED49B0 Offset: 0xED2FB0 VA: 0x180ED49B0
	|-Enumerable.ThenByDescending<Resolution, int>
	|
	|-RVA: 0xED4CE0 Offset: 0xED32E0 VA: 0x180ED4CE0
	|-Enumerable.ThenByDescending<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD00130 Offset: 0xCFE730 VA: 0x180D00130
	|-Enumerable.GroupBy<BaseNetworkable, uint>
	|-Enumerable.GroupBy<IPlayerInfo, string>
	|-Enumerable.GroupBy<ItemDefinition, ItemCategory>
	|-Enumerable.GroupBy<PrefabData, string>
	|-Enumerable.GroupBy<InventoryDef, InventoryDefId>
	|-Enumerable.GroupBy<InventoryItem, InventoryDefId>
	|-Enumerable.GroupBy<MemberInfo, string>
	|-Enumerable.GroupBy<string, AssetBundle>
	|-Enumerable.GroupBy<Animator, string>
	|-Enumerable.GroupBy<Collider, string>
	|-Enumerable.GroupBy<LODGroup, string>
	|-Enumerable.GroupBy<Object, Type>
	|-Enumerable.GroupBy<Resolution, Vector2Int>
	|-Enumerable.GroupBy<Rigidbody, string>
	|-Enumerable.GroupBy<Transform, string>
	|-Enumerable.GroupBy<object, InventoryDefId>
	|-Enumerable.GroupBy<object, Int32Enum>
	|-Enumerable.GroupBy<object, object>
	|-Enumerable.GroupBy<object, uint>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static IEnumerable<TSource> Concat<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B40D0 Offset: 0x4B26D0 VA: 0x1804B40D0
	|-Enumerable.Concat<byte>
	|
	|-RVA: 0x4B4170 Offset: 0x4B2770 VA: 0x1804B4170
	|-Enumerable.Concat<long>
	|
	|-RVA: 0x4B4210 Offset: 0x4B2810 VA: 0x1804B4210
	|-Enumerable.Concat<object>
	*/

	[IteratorStateMachineAttribute] // RVA: 0xC5490 Offset: 0xC4890 VA: 0x1800C5490
	private static IEnumerable<TSource> ConcatIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B3F90 Offset: 0x4B2590 VA: 0x1804B3F90
	|-Enumerable.ConcatIterator<byte>
	|
	|-RVA: 0x4B4030 Offset: 0x4B2630 VA: 0x1804B4030
	|-Enumerable.ConcatIterator<long>
	|-Enumerable.ConcatIterator<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(IEnumerable<TFirst> first, IEnumerable<TSecond> second, Func<TFirst, TSecond, TResult> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4BA100 Offset: 0x4B8700 VA: 0x1804BA100
	|-Enumerable.Zip<object, long, object>
	|
	|-RVA: 0x4BA1D0 Offset: 0x4B87D0 VA: 0x1804BA1D0
	|-Enumerable.Zip<object, object, object>
	*/

	[IteratorStateMachineAttribute] // RVA: 0xC56E0 Offset: 0xC4AE0 VA: 0x1800C56E0
	private static IEnumerable<TResult> ZipIterator<TFirst, TSecond, TResult>(IEnumerable<TFirst> first, IEnumerable<TSecond> second, Func<TFirst, TSecond, TResult> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4BA040 Offset: 0x4B8640 VA: 0x1804BA040
	|-Enumerable.ZipIterator<object, long, object>
	|-Enumerable.ZipIterator<object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static IEnumerable<TSource> Distinct<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B4470 Offset: 0x4B2A70 VA: 0x1804B4470
	|-Enumerable.Distinct<IPlayerItemDefinition>
	|-Enumerable.Distinct<object>
	|
	|-RVA: 0x4B44E0 Offset: 0x4B2AE0 VA: 0x1804B44E0
	|-Enumerable.Distinct<ServerInfo>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static IEnumerable<TSource> Distinct<TSource>(IEnumerable<TSource> source, IEqualityComparer<TSource> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B43F0 Offset: 0x4B29F0 VA: 0x1804B43F0
	|-Enumerable.Distinct<string>
	|-Enumerable.Distinct<object>
	*/

	[IteratorStateMachineAttribute] // RVA: 0xC5A20 Offset: 0xC4E20 VA: 0x1800C5A20
	private static IEnumerable<TSource> DistinctIterator<TSource>(IEnumerable<TSource> source, IEqualityComparer<TSource> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B4350 Offset: 0x4B2950 VA: 0x1804B4350
	|-Enumerable.DistinctIterator<ServerInfo>
	|
	|-RVA: 0x4B42B0 Offset: 0x4B28B0 VA: 0x1804B42B0
	|-Enumerable.DistinctIterator<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static IEnumerable<TSource> Union<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B6FD0 Offset: 0x4B55D0 VA: 0x1804B6FD0
	|-Enumerable.Union<Attribute>
	|-Enumerable.Union<object>
	|
	|-RVA: 0x4B6F30 Offset: 0x4B5530 VA: 0x1804B6F30
	|-Enumerable.Union<char>
	*/

	[IteratorStateMachineAttribute] // RVA: 0xC5C00 Offset: 0xC5000 VA: 0x1800C5C00
	private static IEnumerable<TSource> UnionIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B6DB0 Offset: 0x4B53B0 VA: 0x1804B6DB0
	|-Enumerable.UnionIterator<char>
	|
	|-RVA: 0x4B6E70 Offset: 0x4B5470 VA: 0x1804B6E70
	|-Enumerable.UnionIterator<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static IEnumerable<TSource> Except<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B4770 Offset: 0x4B2D70 VA: 0x1804B4770
	|-Enumerable.Except<float>
	|
	|-RVA: 0x4B4810 Offset: 0x4B2E10 VA: 0x1804B4810
	|-Enumerable.Except<Vector2>
	|
	|-RVA: 0x4B46D0 Offset: 0x4B2CD0 VA: 0x1804B46D0
	|-Enumerable.Except<object>
	*/

	[IteratorStateMachineAttribute] // RVA: 0xC5E60 Offset: 0xC5260 VA: 0x1800C5E60
	private static IEnumerable<TSource> ExceptIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B4550 Offset: 0x4B2B50 VA: 0x1804B4550
	|-Enumerable.ExceptIterator<object>
	|
	|-RVA: 0x4B4610 Offset: 0x4B2C10 VA: 0x1804B4610
	|-Enumerable.ExceptIterator<float>
	|-Enumerable.ExceptIterator<Vector2>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static IEnumerable<TSource> Reverse<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B4A90 Offset: 0x4B3090 VA: 0x1804B4A90
	|-Enumerable.Reverse<PathList>
	|-Enumerable.Reverse<string>
	|-Enumerable.Reverse<object>
	|
	|-RVA: 0x4B49B0 Offset: 0x4B2FB0 VA: 0x1804B49B0
	|-Enumerable.Reverse<char>
	|
	|-RVA: 0x4B4A20 Offset: 0x4B3020 VA: 0x1804B4A20
	|-Enumerable.Reverse<long>
	*/

	[IteratorStateMachineAttribute] // RVA: 0xC60B0 Offset: 0xC54B0 VA: 0x1800C60B0
	private static IEnumerable<TSource> ReverseIterator<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B48B0 Offset: 0x4B2EB0 VA: 0x1804B48B0
	|-Enumerable.ReverseIterator<char>
	|
	|-RVA: 0x4B4930 Offset: 0x4B2F30 VA: 0x1804B4930
	|-Enumerable.ReverseIterator<long>
	|-Enumerable.ReverseIterator<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static bool SequenceEqual<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF1920 Offset: 0xBEFF20 VA: 0x180BF1920
	|-Enumerable.SequenceEqual<PlayerItemRecipe.Ingredient>
	|-Enumerable.SequenceEqual<bool>
	|-Enumerable.SequenceEqual<object>
	|-Enumerable.SequenceEqual<string>
	|-Enumerable.SequenceEqual<Vector3>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static bool SequenceEqual<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF1CA0 Offset: 0xBF02A0 VA: 0x180BF1CA0
	|-Enumerable.SequenceEqual<PlayerItemRecipe.Ingredient>
	|
	|-RVA: 0xBF1930 Offset: 0xBEFF30 VA: 0x180BF1930
	|-Enumerable.SequenceEqual<bool>
	|
	|-RVA: 0xBF1FF0 Offset: 0xBF05F0 VA: 0x180BF1FF0
	|-Enumerable.SequenceEqual<object>
	|
	|-RVA: 0xBF2350 Offset: 0xBF0950 VA: 0x180BF2350
	|-Enumerable.SequenceEqual<Vector3>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static IEnumerable<TSource> AsEnumerable<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80
	|-Enumerable.AsEnumerable<Demos.DemoInfo>
	|-Enumerable.AsEnumerable<PathList>
	|-Enumerable.AsEnumerable<ServerInfo>
	|-Enumerable.AsEnumerable<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TSource[] ToArray<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A2A40 Offset: 0x15A1040 VA: 0x1815A2A40
	|-Enumerable.ToArray<<>f__AnonymousType0<string, string, bool>>
	|-Enumerable.ToArray<BasePlayer>
	|-Enumerable.ToArray<BaseViewModel>
	|-Enumerable.ToArray<ConsoleSystem.Command>
	|-Enumerable.ToArray<Report.StackTrace.StackFrame>
	|-Enumerable.ToArray<IPlayerInfo>
	|-Enumerable.ToArray<IPlayerItem>
	|-Enumerable.ToArray<IPlayerItemDefinition>
	|-Enumerable.ToArray<ItemDefinition>
	|-Enumerable.ToArray<ItemModWearable>
	|-Enumerable.ToArray<EventsCollection>
	|-Enumerable.ToArray<JsonConverter>
	|-Enumerable.ToArray<PieMenu.MenuOption>
	|-Enumerable.ToArray<Prefab>
	|-Enumerable.ToArray<Prefab<DungeonGridLink>>
	|-Enumerable.ToArray<Indexer.Entity>
	|-Enumerable.ToArray<SteamInventoryItem>
	|-Enumerable.ToArray<InventoryDef>
	|-Enumerable.ToArray<Attribute>
	|-Enumerable.ToArray<FileInfo>
	|-Enumerable.ToArray<string>
	|-Enumerable.ToArray<Type>
	|-Enumerable.ToArray<Behaviour>
	|-Enumerable.ToArray<GameObject>
	|-Enumerable.ToArray<Renderer>
	|-Enumerable.ToArray<Transform>
	|-Enumerable.ToArray<WeatherPreset>
	|-Enumerable.ToArray<object>
	|
	|-RVA: 0x15A22C0 Offset: 0x15A08C0 VA: 0x1815A22C0
	|-Enumerable.ToArray<Debugging.EntityInfo>
	|
	|-RVA: 0x15A2C20 Offset: 0x15A1220 VA: 0x1815A2C20
	|-Enumerable.ToArray<GameStat.Stat>
	|
	|-RVA: 0x15A2B80 Offset: 0x15A1180 VA: 0x1815A2B80
	|-Enumerable.ToArray<ItemSkinDirectory.Skin>
	|
	|-RVA: 0x15A2360 Offset: 0x15A0960 VA: 0x1815A2360
	|-Enumerable.ToArray<FourBitNumber>
	|
	|-RVA: 0x15A2AE0 Offset: 0x15A10E0 VA: 0x1815A2AE0
	|-Enumerable.ToArray<SevenBitNumber>
	|
	|-RVA: 0x15A2900 Offset: 0x15A0F00 VA: 0x1815A2900
	|-Enumerable.ToArray<Option>
	|
	|-RVA: 0x15A29A0 Offset: 0x15A0FA0 VA: 0x1815A29A0
	|-Enumerable.ToArray<SkinnedMultiMesh.Part>
	|
	|-RVA: 0x15A25E0 Offset: 0x15A0BE0 VA: 0x1815A25E0
	|-Enumerable.ToArray<InventoryDefId>
	|
	|-RVA: 0x15A2680 Offset: 0x15A0C80 VA: 0x1815A2680
	|-Enumerable.ToArray<InventoryItemId>
	|
	|-RVA: 0x15A2720 Offset: 0x15A0D20 VA: 0x1815A2720
	|-Enumerable.ToArray<InventoryItem>
	|
	|-RVA: 0x15A2400 Offset: 0x15A0A00 VA: 0x1815A2400
	|-Enumerable.ToArray<InventoryRecipe.Ingredient>
	|
	|-RVA: 0x15A27C0 Offset: 0x15A0DC0 VA: 0x1815A27C0
	|-Enumerable.ToArray<InventoryRecipe>
	|
	|-RVA: 0x15A2860 Offset: 0x15A0E60 VA: 0x1815A2860
	|-Enumerable.ToArray<Item>
	|
	|-RVA: 0x15A2180 Offset: 0x15A0780 VA: 0x1815A2180
	|-Enumerable.ToArray<byte>
	|
	|-RVA: 0x15A2220 Offset: 0x15A0820 VA: 0x1815A2220
	|-Enumerable.ToArray<char>
	|
	|-RVA: 0x15A2540 Offset: 0x15A0B40 VA: 0x1815A2540
	|-Enumerable.ToArray<int>
	|
	|-RVA: 0x15A2CC0 Offset: 0x15A12C0 VA: 0x1815A2CC0
	|-Enumerable.ToArray<uint>
	|
	|-RVA: 0x15A24A0 Offset: 0x15A0AA0 VA: 0x1815A24A0
	|-Enumerable.ToArray<KeyCode>
	|-Enumerable.ToArray<Int32Enum>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static List<TSource> ToList<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12ADA50 Offset: 0x12AC050 VA: 0x1812ADA50
	|-Enumerable.ToList<Chat.MuteEntry>
	|
	|-RVA: 0x12ADB90 Offset: 0x12AC190 VA: 0x1812ADB90
	|-Enumerable.ToList<GenerateDungeonBase.DungeonSegment>
	|-Enumerable.ToList<IPlayerItemDefinition>
	|-Enumerable.ToList<Item>
	|-Enumerable.ToList<ItemBlueprint>
	|-Enumerable.ToList<ItemDefinition>
	|-Enumerable.ToList<ItemIcon>
	|-Enumerable.ToList<LoadAssetsResult>
	|-Enumerable.ToList<ValueChange<TimeSignature>>
	|-Enumerable.ToList<MusicTheme>
	|-Enumerable.ToList<JsonWriter.State[]>
	|-Enumerable.ToList<JsonProperty>
	|-Enumerable.ToList<PieMenu.MenuOption>
	|-Enumerable.ToList<PrefabData>
	|-Enumerable.ToList<SteamItem>
	|-Enumerable.ToList<SteamItemDefinition>
	|-Enumerable.ToList<SkeletonProperties.BoneProperty>
	|-Enumerable.ToList<ConstructorInfo>
	|-Enumerable.ToList<MemberInfo>
	|-Enumerable.ToList<string>
	|-Enumerable.ToList<KerningPair>
	|-Enumerable.ToList<TMP_Character>
	|-Enumerable.ToList<TMP_GlyphPairAdjustmentRecord>
	|-Enumerable.ToList<Component>
	|-Enumerable.ToList<ParameterOverride>
	|-Enumerable.ToList<PostProcessBundle>
	|-Enumerable.ToList<Shader>
	|-Enumerable.ToList<Glyph>
	|-Enumerable.ToList<Transform>
	|-Enumerable.ToList<object>
	|
	|-RVA: 0x12AD9B0 Offset: 0x12ABFB0 VA: 0x1812AD9B0
	|-Enumerable.ToList<PlayerItemRecipe.Ingredient>
	|
	|-RVA: 0x12ADC30 Offset: 0x12AC230 VA: 0x1812ADC30
	|-Enumerable.ToList<ServerInfo>
	|
	|-RVA: 0x12ADCD0 Offset: 0x12AC2D0 VA: 0x1812ADCD0
	|-Enumerable.ToList<ServerInfo>
	|
	|-RVA: 0x12AD910 Offset: 0x12ABF10 VA: 0x1812AD910
	|-Enumerable.ToList<bool>
	|
	|-RVA: 0x12ADD70 Offset: 0x12AC370 VA: 0x1812ADD70
	|-Enumerable.ToList<float>
	|
	|-RVA: 0x12ADAF0 Offset: 0x12AC0F0 VA: 0x1812ADAF0
	|-Enumerable.ToList<Resolution>
	|
	|-RVA: 0x12ADE10 Offset: 0x12AC410 VA: 0x1812ADE10
	|-Enumerable.ToList<Vector2>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1537ED0 Offset: 0x15364D0 VA: 0x181537ED0
	|-Enumerable.ToDictionary<Input.Button, string>
	|-Enumerable.ToDictionary<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDFBD10 Offset: 0xDFA310 VA: 0x180DFBD10
	|-Enumerable.ToDictionary<JsonProperty, JsonProperty, JsonSerializerInternalReader.PropertyPresence>
	|-Enumerable.ToDictionary<Indexer.Entity, uint, Indexer.Entity>
	|-Enumerable.ToDictionary<KeyValuePair<ulong, Dispatch.ResultCallback>, ulong, Dispatch.ResultCallback>
	|-Enumerable.ToDictionary<IGrouping<InventoryDefId, InventoryDef>, InventoryDefId, uint>
	|-Enumerable.ToDictionary<IGrouping<string, IPlayerInfo>, string, string>
	|-Enumerable.ToDictionary<TechTreeData.NodeInstance, int, TechTreeData.NodeInstance>
	|-Enumerable.ToDictionary<object, InventoryDefId, uint>
	|-Enumerable.ToDictionary<object, int, object>
	|-Enumerable.ToDictionary<object, object, Int32Enum>
	|-Enumerable.ToDictionary<object, object, object>
	|-Enumerable.ToDictionary<object, uint, object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1537C50 Offset: 0x1536250 VA: 0x181537C50
	|-Enumerable.ToDictionary<IGrouping<string, PrefabData>, string, List<PrefabData>>
	|-Enumerable.ToDictionary<object, object, object>
	|
	|-RVA: 0x15371A0 Offset: 0x15357A0 VA: 0x1815371A0
	|-Enumerable.ToDictionary<KeyValuePair<ulong, Dispatch.ResultCallback>, ulong, Dispatch.ResultCallback>
	|
	|-RVA: 0x1537760 Offset: 0x1535D60 VA: 0x181537760
	|-Enumerable.ToDictionary<object, InventoryDefId, uint>
	|
	|-RVA: 0x15374E0 Offset: 0x1535AE0 VA: 0x1815374E0
	|-Enumerable.ToDictionary<object, int, object>
	|
	|-RVA: 0x15379D0 Offset: 0x1535FD0 VA: 0x1815379D0
	|-Enumerable.ToDictionary<object, object, Int32Enum>
	|
	|-RVA: 0x1537F30 Offset: 0x1536530 VA: 0x181537F30
	|-Enumerable.ToDictionary<object, uint, object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static IEnumerable<TResult> OfType<TResult>(IEnumerable source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC85C70 Offset: 0xC84270 VA: 0x180C85C70
	|-Enumerable.OfType<TrackChunk>
	|-Enumerable.OfType<Behaviour>
	|-Enumerable.OfType<object>
	*/

	[IteratorStateMachineAttribute] // RVA: 0xC65C0 Offset: 0xC59C0 VA: 0x1800C65C0
	private static IEnumerable<TResult> OfTypeIterator<TResult>(IEnumerable source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B4930 Offset: 0x4B2F30 VA: 0x1804B4930
	|-Enumerable.OfTypeIterator<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static IEnumerable<TResult> Cast<TResult>(IEnumerable source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC85BD0 Offset: 0xC841D0 VA: 0x180C85BD0
	|-Enumerable.Cast<ProjectileWeaponMod>
	|-Enumerable.Cast<SteamItem>
	|-Enumerable.Cast<SteamItemDefinition>
	|-Enumerable.Cast<Attribute>
	|-Enumerable.Cast<FieldInfo>
	|-Enumerable.Cast<MemberInfo>
	|-Enumerable.Cast<EnumMemberAttribute>
	|-Enumerable.Cast<Match>
	|-Enumerable.Cast<Component>
	|-Enumerable.Cast<Transform>
	|-Enumerable.Cast<object>
	|
	|-RVA: 0xC858B0 Offset: 0xC83EB0 VA: 0x180C858B0
	|-Enumerable.Cast<bool>
	|
	|-RVA: 0xC85950 Offset: 0xC83F50 VA: 0x180C85950
	|-Enumerable.Cast<byte>
	|
	|-RVA: 0xC859F0 Offset: 0xC83FF0 VA: 0x180C859F0
	|-Enumerable.Cast<DictionaryEntry>
	|
	|-RVA: 0xC85A90 Offset: 0xC84090 VA: 0x180C85A90
	|-Enumerable.Cast<short>
	|
	|-RVA: 0xC85B30 Offset: 0xC84130 VA: 0x180C85B30
	|-Enumerable.Cast<int>
	*/

	[IteratorStateMachineAttribute] // RVA: 0xC6770 Offset: 0xC5B70 VA: 0x1800C6770
	private static IEnumerable<TResult> CastIterator<TResult>(IEnumerable source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B48B0 Offset: 0x4B2EB0 VA: 0x1804B48B0
	|-Enumerable.CastIterator<bool>
	|-Enumerable.CastIterator<byte>
	|-Enumerable.CastIterator<short>
	|-Enumerable.CastIterator<int>
	|
	|-RVA: 0xC85830 Offset: 0xC83E30 VA: 0x180C85830
	|-Enumerable.CastIterator<DictionaryEntry>
	|
	|-RVA: 0x4B4930 Offset: 0x4B2F30 VA: 0x1804B4930
	|-Enumerable.CastIterator<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TSource First<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A0FF0 Offset: 0x159F5F0 VA: 0x1815A0FF0
	|-Enumerable.First<BaseNetworkable>
	|-Enumerable.First<ItemDefinition>
	|-Enumerable.First<SteamInventoryItem>
	|-Enumerable.First<ConstructorInfo>
	|-Enumerable.First<MemberInfo>
	|-Enumerable.First<string>
	|-Enumerable.First<Animator>
	|-Enumerable.First<Object>
	|-Enumerable.First<Transform>
	|-Enumerable.First<object>
	|
	|-RVA: 0x159FD40 Offset: 0x159E340 VA: 0x18159FD40
	|-Enumerable.First<InventoryItem>
	|
	|-RVA: 0x15A0070 Offset: 0x159E670 VA: 0x1815A0070
	|-Enumerable.First<Item>
	|
	|-RVA: 0x15A0AA0 Offset: 0x159F0A0 VA: 0x1815A0AA0
	|-Enumerable.First<Resolution>
	|
	|-RVA: 0x159FA50 Offset: 0x159E050 VA: 0x18159FA50
	|-Enumerable.First<byte>
	|
	|-RVA: 0x15A0510 Offset: 0x159EB10 VA: 0x1815A0510
	|-Enumerable.First<KeyValuePair<long, object>>
	|
	|-RVA: 0x15A0830 Offset: 0x159EE30 VA: 0x1815A0830
	|-Enumerable.First<KeyValuePair<object, object>>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TSource First<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A0E00 Offset: 0x159F400 VA: 0x1815A0E00
	|-Enumerable.First<Dropdown.OptionData>
	|-Enumerable.First<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TSource FirstOrDefault<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x159F2D0 Offset: 0x159D8D0 VA: 0x18159F2D0
	|-Enumerable.FirstOrDefault<CraftingQueueIcon>
	|-Enumerable.FirstOrDefault<ValueChange<TimeSignature>>
	|-Enumerable.FirstOrDefault<ProjectileWeaponMod>
	|-Enumerable.FirstOrDefault<SocketHandle>
	|-Enumerable.FirstOrDefault<string>
	|-Enumerable.FirstOrDefault<Toggle>
	|-Enumerable.FirstOrDefault<object>
	|
	|-RVA: 0x159E7A0 Offset: 0x159CDA0 VA: 0x18159E7A0
	|-Enumerable.FirstOrDefault<SkeletonDefinition.Bone>
	|
	|-RVA: 0x159F4E0 Offset: 0x159DAE0 VA: 0x18159F4E0
	|-Enumerable.FirstOrDefault<ItemSkinDirectory.Skin>
	|
	|-RVA: 0x159EAF0 Offset: 0x159D0F0 VA: 0x18159EAF0
	|-Enumerable.FirstOrDefault<InventoryRecipe>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TSource FirstOrDefault<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x159F100 Offset: 0x159D700 VA: 0x18159F100
	|-Enumerable.FirstOrDefault<Input.Button>
	|-Enumerable.FirstOrDefault<IPlayerItemDefinition>
	|-Enumerable.FirstOrDefault<Skinnable>
	|-Enumerable.FirstOrDefault<string>
	|-Enumerable.FirstOrDefault<Match>
	|-Enumerable.FirstOrDefault<Toggle>
	|-Enumerable.FirstOrDefault<object>
	|
	|-RVA: 0x159F7A0 Offset: 0x159DDA0 VA: 0x18159F7A0
	|-Enumerable.FirstOrDefault<ItemSkinDirectory.Skin>
	|
	|-RVA: 0x159EE30 Offset: 0x159D430 VA: 0x18159EE30
	|-Enumerable.FirstOrDefault<PetCommandList.PetCommandDesc>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TSource Last<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A1730 Offset: 0x159FD30 VA: 0x1815A1730
	|-Enumerable.Last<string>
	|-Enumerable.Last<KerningPair>
	|-Enumerable.Last<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TSource LastOrDefault<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A1210 Offset: 0x159F810 VA: 0x1815A1210
	|-Enumerable.LastOrDefault<MetricTempoMapValuesCache.AccumulatedMicroseconds>
	|-Enumerable.LastOrDefault<ValueChange<TimeSignature>>
	|-Enumerable.LastOrDefault<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TSource LastOrDefault<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A1510 Offset: 0x159FB10 VA: 0x1815A1510
	|-Enumerable.LastOrDefault<MemberInfo>
	|-Enumerable.LastOrDefault<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TSource Single<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A1F00 Offset: 0x15A0500 VA: 0x1815A1F00
	|-Enumerable.Single<MemberInfo>
	|-Enumerable.Single<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TSource SingleOrDefault<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A1A50 Offset: 0x15A0050 VA: 0x1815A1A50
	|-Enumerable.SingleOrDefault<MemberInfo>
	|-Enumerable.SingleOrDefault<string>
	|-Enumerable.SingleOrDefault<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TSource SingleOrDefault<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A1CB0 Offset: 0x15A02B0 VA: 0x1815A1CB0
	|-Enumerable.SingleOrDefault<ConstructorInfo>
	|-Enumerable.SingleOrDefault<PlayerEditorConnectionEvents.MessageTypeSubscribers>
	|-Enumerable.SingleOrDefault<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TSource ElementAt<TSource>(IEnumerable<TSource> source, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x159E260 Offset: 0x159C860 VA: 0x18159E260
	|-Enumerable.ElementAt<KeyValuePair<string, JSONNode>>
	|-Enumerable.ElementAt<KeyValuePair<object, object>>
	|
	|-RVA: 0x159E520 Offset: 0x159CB20 VA: 0x18159E520
	|-Enumerable.ElementAt<string>
	|-Enumerable.ElementAt<object>
	*/

	public static IEnumerable<int> Range(int start, int count) { }

	[IteratorStateMachineAttribute] // RVA: 0xC7120 Offset: 0xC6520 VA: 0x1800C7120
	private static IEnumerable<int> RangeIterator(int start, int count) { }

	public static IEnumerable<TResult> Empty<TResult>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49AA10 Offset: 0x499010 VA: 0x18049AA10
	|-Enumerable.Empty<ItemBlueprint>
	|-Enumerable.Empty<byte>
	|-Enumerable.Empty<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static bool Any<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF0390 Offset: 0xBEE990 VA: 0x180BF0390
	|-Enumerable.Any<PlayerItemRecipe>
	|
	|-RVA: 0xBEFE40 Offset: 0xBEE440 VA: 0x180BEFE40
	|-Enumerable.Any<KeyValuePair<long, object>>
	|
	|-RVA: 0xBEFFB0 Offset: 0xBEE5B0 VA: 0x180BEFFB0
	|-Enumerable.Any<KeyValuePair<object, object>>
	|
	|-RVA: 0xBF0500 Offset: 0xBEEB00 VA: 0x180BF0500
	|-Enumerable.Any<FileInfo>
	|-Enumerable.Any<object>
	|-Enumerable.Any<ParameterInfo>
	|-Enumerable.Any<PlayerEditorConnectionEvents.MessageTypeSubscribers>
	|
	|-RVA: 0xBF0840 Offset: 0xBEEE40 VA: 0x180BF0840
	|-Enumerable.Any<float>
	|
	|-RVA: 0xBF09B0 Offset: 0xBEEFB0 VA: 0x180BF09B0
	|-Enumerable.Any<Vector2>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static bool Any<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF0670 Offset: 0xBEEC70 VA: 0x180BF0670
	|-Enumerable.Any<BaseEntity>
	|-Enumerable.Any<CardPlayerData>
	|-Enumerable.Any<Manifest.Administrator>
	|-Enumerable.Any<IPlayerInfo>
	|-Enumerable.Any<IPlayerItem>
	|-Enumerable.Any<Item>
	|-Enumerable.Any<LoadAssetsResult>
	|-Enumerable.Any<ProjectileWeaponMod>
	|-Enumerable.Any<PlayerNameID>
	|-Enumerable.Any<SteamInventoryItem>
	|-Enumerable.Any<byte[]>
	|-Enumerable.Any<object>
	|-Enumerable.Any<string>
	|-Enumerable.Any<Type>
	|-Enumerable.Any<PlayerEditorConnectionEvents.MessageTypeSubscribers>
	|-Enumerable.Any<Wearable>
	|
	|-RVA: 0xBF0120 Offset: 0xBEE720 VA: 0x180BF0120
	|-Enumerable.Any<SkinnedMultiMesh.Part>
	|
	|-RVA: 0xBEF950 Offset: 0xBEDF50 VA: 0x180BEF950
	|-Enumerable.Any<InventoryItem.Amount>
	|
	|-RVA: 0xBEFBD0 Offset: 0xBEE1D0 VA: 0x180BEFBD0
	|-Enumerable.Any<InventoryRecipe.Ingredient>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static bool All<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEF780 Offset: 0xBEDD80 VA: 0x180BEF780
	|-Enumerable.All<AchievementGroup.AchievementItem>
	|-Enumerable.All<JsonSerializerInternalReader.CreatorPropertyContext>
	|-Enumerable.All<SteamInventoryItem>
	|-Enumerable.All<SkeletonProperties.BoneProperty>
	|-Enumerable.All<object>
	|-Enumerable.All<Collider>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static int Count<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED3FB0 Offset: 0xED25B0 VA: 0x180ED3FB0
	|-Enumerable.Count<BaseNetworkable>
	|-Enumerable.Count<CraftingQueueIcon>
	|-Enumerable.Count<AccountNotice>
	|-Enumerable.Count<GameSetup>
	|-Enumerable.Count<PieMenu.MenuOption>
	|-Enumerable.Count<SteamInventoryItem>
	|-Enumerable.Count<InventoryDef>
	|-Enumerable.Count<object>
	|-Enumerable.Count<MemberInfo>
	|-Enumerable.Count<string>
	|-Enumerable.Count<Animator>
	|-Enumerable.Count<BoxCollider>
	|-Enumerable.Count<CapsuleCollider>
	|-Enumerable.Count<Collider>
	|-Enumerable.Count<LODGroup>
	|-Enumerable.Count<MeshCollider>
	|-Enumerable.Count<Object>
	|-Enumerable.Count<Rigidbody>
	|-Enumerable.Count<SphereCollider>
	|-Enumerable.Count<Transform>
	|
	|-RVA: 0xED43A0 Offset: 0xED29A0 VA: 0x180ED43A0
	|-Enumerable.Count<ServerInfo>
	|
	|-RVA: 0xED3DB0 Offset: 0xED23B0 VA: 0x180ED3DB0
	|-Enumerable.Count<InventoryItem>
	|
	|-RVA: 0xED3BB0 Offset: 0xED21B0 VA: 0x180ED3BB0
	|-Enumerable.Count<int>
	|
	|-RVA: 0xED45A0 Offset: 0xED2BA0 VA: 0x180ED45A0
	|-Enumerable.Count<float>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static int Count<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED3740 Offset: 0xED1D40 VA: 0x180ED3740
	|-Enumerable.Count<RCon.BannedAddresses>
	|
	|-RVA: 0xED39C0 Offset: 0xED1FC0 VA: 0x180ED39C0
	|-Enumerable.Count<bool>
	|
	|-RVA: 0xED41B0 Offset: 0xED27B0 VA: 0x180ED41B0
	|-Enumerable.Count<object>
	|-Enumerable.Count<Collider>
	|-Enumerable.Count<Renderer>
	|-Enumerable.Count<Rigidbody>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static bool Contains<TSource>(IEnumerable<TSource> source, TSource value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF0EF0 Offset: 0xBEF4F0 VA: 0x180BF0EF0
	|-Enumerable.Contains<TempoMapLine>
	|-Enumerable.Contains<int>
	|-Enumerable.Contains<Int32Enum>
	|-Enumerable.Contains<GraphicsDeviceType>
	|
	|-RVA: 0xBF15B0 Offset: 0xBEFBB0 VA: 0x180BF15B0
	|-Enumerable.Contains<MeshPaintableSource>
	|-Enumerable.Contains<object>
	|-Enumerable.Contains<string>
	|-Enumerable.Contains<Component>
	|-Enumerable.Contains<Material>
	|-Enumerable.Contains<Renderer>
	|
	|-RVA: 0xBF0B20 Offset: 0xBEF120 VA: 0x180BF0B20
	|-Enumerable.Contains<char>
	|-Enumerable.Contains<ushort>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static bool Contains<TSource>(IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF0C30 Offset: 0xBEF230 VA: 0x180BF0C30
	|-Enumerable.Contains<char>
	|
	|-RVA: 0xBF11A0 Offset: 0xBEF7A0 VA: 0x180BF11A0
	|-Enumerable.Contains<int>
	|
	|-RVA: 0xBF0FA0 Offset: 0xBEF5A0 VA: 0x180BF0FA0
	|-Enumerable.Contains<Int32Enum>
	|
	|-RVA: 0xBF13A0 Offset: 0xBEF9A0 VA: 0x180BF13A0
	|-Enumerable.Contains<object>
	|
	|-RVA: 0xBF1660 Offset: 0xBEFC60 VA: 0x180BF1660
	|-Enumerable.Contains<ushort>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static int Sum(IEnumerable<int> source) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static long Sum(IEnumerable<long> source) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static float Sum(IEnumerable<float> source) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static int Sum<TSource>(IEnumerable<TSource> source, Func<TSource, int> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED4950 Offset: 0xED2F50 VA: 0x180ED4950
	|-Enumerable.Sum<BurstCloth.Chain>
	|-Enumerable.Sum<IPlayerItem>
	|-Enumerable.Sum<IPlayerItemDefinition>
	|-Enumerable.Sum<Item>
	|-Enumerable.Sum<LoadAssetsResult>
	|-Enumerable.Sum<EventsCollection>
	|-Enumerable.Sum<PlayerItemRecipe.Ingredient>
	|-Enumerable.Sum<ServerInfo>
	|-Enumerable.Sum<InventoryItem>
	|-Enumerable.Sum<byte[]>
	|-Enumerable.Sum<object>
	|-Enumerable.Sum<Transform>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static long Sum<TSource>(IEnumerable<TSource> source, Func<TSource, long> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED4990 Offset: 0xED2F90 VA: 0x180ED4990
	|-Enumerable.Sum<SkinnedMultiMesh.Part>
	|-Enumerable.Sum<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static float Sum<TSource>(IEnumerable<TSource> source, Func<TSource, float> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED4970 Offset: 0xED2F70 VA: 0x180ED4970
	|-Enumerable.Sum<WeightedStringList.Container>
	|-Enumerable.Sum<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static float Min(IEnumerable<float> source) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static int Max(IEnumerable<int> source) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static float Max(IEnumerable<float> source) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static int Max<TSource>(IEnumerable<TSource> source, Func<TSource, int> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED47A0 Offset: 0xED2DA0 VA: 0x180ED47A0
	|-Enumerable.Max<DungeonBaseInfo>
	|-Enumerable.Max<EZSoftBone.BoneChain>
	|-Enumerable.Max<BurstCloth.Chain>
	|-Enumerable.Max<object>
	|-Enumerable.Max<FieldInfo>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static float Average(IEnumerable<float> source) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static double Average(IEnumerable<double> source) { }

}

private abstract class Enumerable.Iterator<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 3199
{	private int threadId; // 0x0
	internal int state; // 0x0
	internal TSource current; // 0x0

	public TSource Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D0B30 Offset: 0x19CF130 VA: 0x1819D0B30
	|-Enumerable.Iterator<Debugging.EntityInfo>..ctor
	|-Enumerable.Iterator<BurstCloth.Chain>..ctor
	|-Enumerable.Iterator<SkeletonDefinition.Bone>..ctor
	|-Enumerable.Iterator<WeightedStringList.Container>..ctor
	|-Enumerable.Iterator<GameStat.Stat>..ctor
	|-Enumerable.Iterator<ItemSkinDirectory.Skin>..ctor
	|-Enumerable.Iterator<FourBitNumber>..ctor
	|-Enumerable.Iterator<SevenBitNumber>..ctor
	|-Enumerable.Iterator<PathFinder.Point>..ctor
	|-Enumerable.Iterator<PlayerItemRecipe.Ingredient>..ctor
	|-Enumerable.Iterator<PlayerItemRecipe>..ctor
	|-Enumerable.Iterator<ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.Iterator<Option>..ctor
	|-Enumerable.Iterator<ServerInfo>..ctor
	|-Enumerable.Iterator<SkinnedMultiMesh.Part>..ctor
	|-Enumerable.Iterator<Achievement>..ctor
	|-Enumerable.Iterator<InventoryDefId>..ctor
	|-Enumerable.Iterator<InventoryItemId>..ctor
	|-Enumerable.Iterator<ServerInfo>..ctor
	|-Enumerable.Iterator<Friend>..ctor
	|-Enumerable.Iterator<InventoryItem.Amount>..ctor
	|-Enumerable.Iterator<InventoryItem>..ctor
	|-Enumerable.Iterator<InventoryRecipe.Ingredient>..ctor
	|-Enumerable.Iterator<InventoryRecipe>..ctor
	|-Enumerable.Iterator<bool>..ctor
	|-Enumerable.Iterator<char>..ctor
	|-Enumerable.Iterator<DictionaryEntry>..ctor
	|-Enumerable.Iterator<KeyValuePair<object, int>>..ctor
	|-Enumerable.Iterator<KeyValuePair<object, object>>..ctor
	|-Enumerable.Iterator<KeyValuePair<uint, object>>..ctor
	|-Enumerable.Iterator<KeyValuePair<ulong, Dispatch.ResultCallback>>..ctor
	|-Enumerable.Iterator<int>..ctor
	|-Enumerable.Iterator<Int32Enum>..ctor
	|-Enumerable.Iterator<long>..ctor
	|-Enumerable.Iterator<object>..ctor
	|-Enumerable.Iterator<float>..ctor
	|-Enumerable.Iterator<uint>..ctor
	|-Enumerable.Iterator<Resolution>..ctor
	*/

	public TSource get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB11B00 Offset: 0xB10100 VA: 0x180B11B00
	|-Enumerable.Iterator<Debugging.EntityInfo>.get_Current
	|-Enumerable.Iterator<WeightedStringList.Container>.get_Current
	|-Enumerable.Iterator<GameStat.Stat>.get_Current
	|-Enumerable.Iterator<PlayerItemRecipe>.get_Current
	|-Enumerable.Iterator<DictionaryEntry>.get_Current
	|-Enumerable.Iterator<KeyValuePair<object, int>>.get_Current
	|-Enumerable.Iterator<KeyValuePair<object, object>>.get_Current
	|-Enumerable.Iterator<KeyValuePair<uint, object>>.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.Iterator<BurstCloth.Chain>.get_Current
	|-Enumerable.Iterator<PathFinder.Point>.get_Current
	|-Enumerable.Iterator<PlayerItemRecipe.Ingredient>.get_Current
	|-Enumerable.Iterator<Achievement>.get_Current
	|-Enumerable.Iterator<InventoryItemId>.get_Current
	|-Enumerable.Iterator<Friend>.get_Current
	|-Enumerable.Iterator<long>.get_Current
	|-Enumerable.Iterator<object>.get_Current
	|
	|-RVA: 0x1650290 Offset: 0x164E890 VA: 0x181650290
	|-Enumerable.Iterator<SkeletonDefinition.Bone>.get_Current
	|-Enumerable.Iterator<InventoryItem.Amount>.get_Current
	|
	|-RVA: 0x176B310 Offset: 0x1769910 VA: 0x18176B310
	|-Enumerable.Iterator<ItemSkinDirectory.Skin>.get_Current
	|-Enumerable.Iterator<Option>.get_Current
	|-Enumerable.Iterator<SkinnedMultiMesh.Part>.get_Current
	|-Enumerable.Iterator<InventoryItem>.get_Current
	|
	|-RVA: 0x960130 Offset: 0x95E730 VA: 0x180960130
	|-Enumerable.Iterator<FourBitNumber>.get_Current
	|-Enumerable.Iterator<SevenBitNumber>.get_Current
	|-Enumerable.Iterator<bool>.get_Current
	|
	|-RVA: 0x12D3B70 Offset: 0x12D2170 VA: 0x1812D3B70
	|-Enumerable.Iterator<ProjectileWeaponMod.Modifier>.get_Current
	|-Enumerable.Iterator<Resolution>.get_Current
	|
	|-RVA: 0xDECE60 Offset: 0xDEB460 VA: 0x180DECE60
	|-Enumerable.Iterator<ServerInfo>.get_Current
	|-Enumerable.Iterator<ServerInfo>.get_Current
	|
	|-RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400
	|-Enumerable.Iterator<InventoryDefId>.get_Current
	|-Enumerable.Iterator<int>.get_Current
	|-Enumerable.Iterator<Int32Enum>.get_Current
	|-Enumerable.Iterator<uint>.get_Current
	|
	|-RVA: 0x11283A0 Offset: 0x11269A0 VA: 0x1811283A0
	|-Enumerable.Iterator<InventoryRecipe.Ingredient>.get_Current
	|-Enumerable.Iterator<InventoryRecipe>.get_Current
	|-Enumerable.Iterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.get_Current
	|
	|-RVA: 0x13984B0 Offset: 0x1396AB0 VA: 0x1813984B0
	|-Enumerable.Iterator<char>.get_Current
	|
	|-RVA: 0x7747F0 Offset: 0x772DF0 VA: 0x1807747F0
	|-Enumerable.Iterator<float>.get_Current
	*/

	public abstract Enumerable.Iterator<TSource> Clone();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Enumerable.Iterator<object>.Clone
	*/

	public virtual void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CF8C0 Offset: 0x19CDEC0 VA: 0x1819CF8C0
	|-Enumerable.Iterator<Debugging.EntityInfo>.Dispose
	|-Enumerable.Iterator<WeightedStringList.Container>.Dispose
	|-Enumerable.Iterator<GameStat.Stat>.Dispose
	|-Enumerable.Iterator<PlayerItemRecipe>.Dispose
	|-Enumerable.Iterator<DictionaryEntry>.Dispose
	|-Enumerable.Iterator<KeyValuePair<object, int>>.Dispose
	|-Enumerable.Iterator<KeyValuePair<object, object>>.Dispose
	|-Enumerable.Iterator<KeyValuePair<uint, object>>.Dispose
	|
	|-RVA: 0x19CF8F0 Offset: 0x19CDEF0 VA: 0x1819CF8F0
	|-Enumerable.Iterator<BurstCloth.Chain>.Dispose
	|-Enumerable.Iterator<PathFinder.Point>.Dispose
	|-Enumerable.Iterator<PlayerItemRecipe.Ingredient>.Dispose
	|-Enumerable.Iterator<Achievement>.Dispose
	|-Enumerable.Iterator<InventoryItemId>.Dispose
	|-Enumerable.Iterator<Friend>.Dispose
	|-Enumerable.Iterator<long>.Dispose
	|-Enumerable.Iterator<object>.Dispose
	|
	|-RVA: 0x19CF950 Offset: 0x19CDF50 VA: 0x1819CF950
	|-Enumerable.Iterator<SkeletonDefinition.Bone>.Dispose
	|-Enumerable.Iterator<InventoryItem.Amount>.Dispose
	|
	|-RVA: 0x19CF920 Offset: 0x19CDF20 VA: 0x1819CF920
	|-Enumerable.Iterator<ItemSkinDirectory.Skin>.Dispose
	|-Enumerable.Iterator<Option>.Dispose
	|-Enumerable.Iterator<SkinnedMultiMesh.Part>.Dispose
	|-Enumerable.Iterator<InventoryItem>.Dispose
	|
	|-RVA: 0x19CF9A0 Offset: 0x19CDFA0 VA: 0x1819CF9A0
	|-Enumerable.Iterator<FourBitNumber>.Dispose
	|-Enumerable.Iterator<SevenBitNumber>.Dispose
	|-Enumerable.Iterator<bool>.Dispose
	|
	|-RVA: 0x19CF900 Offset: 0x19CDF00 VA: 0x1819CF900
	|-Enumerable.Iterator<ProjectileWeaponMod.Modifier>.Dispose
	|-Enumerable.Iterator<Resolution>.Dispose
	|
	|-RVA: 0x19CF970 Offset: 0x19CDF70 VA: 0x1819CF970
	|-Enumerable.Iterator<ServerInfo>.Dispose
	|-Enumerable.Iterator<ServerInfo>.Dispose
	|
	|-RVA: 0x19CF8B0 Offset: 0x19CDEB0 VA: 0x1819CF8B0
	|-Enumerable.Iterator<InventoryDefId>.Dispose
	|-Enumerable.Iterator<int>.Dispose
	|-Enumerable.Iterator<Int32Enum>.Dispose
	|-Enumerable.Iterator<float>.Dispose
	|-Enumerable.Iterator<uint>.Dispose
	|
	|-RVA: 0x19CF8D0 Offset: 0x19CDED0 VA: 0x1819CF8D0
	|-Enumerable.Iterator<InventoryRecipe.Ingredient>.Dispose
	|-Enumerable.Iterator<InventoryRecipe>.Dispose
	|-Enumerable.Iterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.Dispose
	|
	|-RVA: 0x19CF940 Offset: 0x19CDF40 VA: 0x1819CF940
	|-Enumerable.Iterator<char>.Dispose
	*/

	public IEnumerator<TSource> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CF9B0 Offset: 0x19CDFB0 VA: 0x1819CF9B0
	|-Enumerable.Iterator<Debugging.EntityInfo>.GetEnumerator
	|-Enumerable.Iterator<BurstCloth.Chain>.GetEnumerator
	|-Enumerable.Iterator<SkeletonDefinition.Bone>.GetEnumerator
	|-Enumerable.Iterator<WeightedStringList.Container>.GetEnumerator
	|-Enumerable.Iterator<GameStat.Stat>.GetEnumerator
	|-Enumerable.Iterator<ItemSkinDirectory.Skin>.GetEnumerator
	|-Enumerable.Iterator<FourBitNumber>.GetEnumerator
	|-Enumerable.Iterator<SevenBitNumber>.GetEnumerator
	|-Enumerable.Iterator<PathFinder.Point>.GetEnumerator
	|-Enumerable.Iterator<PlayerItemRecipe.Ingredient>.GetEnumerator
	|-Enumerable.Iterator<PlayerItemRecipe>.GetEnumerator
	|-Enumerable.Iterator<ProjectileWeaponMod.Modifier>.GetEnumerator
	|-Enumerable.Iterator<Option>.GetEnumerator
	|-Enumerable.Iterator<ServerInfo>.GetEnumerator
	|-Enumerable.Iterator<SkinnedMultiMesh.Part>.GetEnumerator
	|-Enumerable.Iterator<Achievement>.GetEnumerator
	|-Enumerable.Iterator<InventoryDefId>.GetEnumerator
	|-Enumerable.Iterator<InventoryItemId>.GetEnumerator
	|-Enumerable.Iterator<ServerInfo>.GetEnumerator
	|-Enumerable.Iterator<Friend>.GetEnumerator
	|-Enumerable.Iterator<InventoryItem.Amount>.GetEnumerator
	|-Enumerable.Iterator<InventoryItem>.GetEnumerator
	|-Enumerable.Iterator<InventoryRecipe.Ingredient>.GetEnumerator
	|-Enumerable.Iterator<InventoryRecipe>.GetEnumerator
	|-Enumerable.Iterator<bool>.GetEnumerator
	|-Enumerable.Iterator<char>.GetEnumerator
	|-Enumerable.Iterator<DictionaryEntry>.GetEnumerator
	|-Enumerable.Iterator<KeyValuePair<object, int>>.GetEnumerator
	|-Enumerable.Iterator<KeyValuePair<object, object>>.GetEnumerator
	|-Enumerable.Iterator<KeyValuePair<uint, object>>.GetEnumerator
	|-Enumerable.Iterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.GetEnumerator
	|-Enumerable.Iterator<int>.GetEnumerator
	|-Enumerable.Iterator<Int32Enum>.GetEnumerator
	|-Enumerable.Iterator<long>.GetEnumerator
	|-Enumerable.Iterator<object>.GetEnumerator
	|-Enumerable.Iterator<float>.GetEnumerator
	|-Enumerable.Iterator<uint>.GetEnumerator
	|-Enumerable.Iterator<Resolution>.GetEnumerator
	*/

	public abstract bool MoveNext();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Enumerable.Iterator<object>.MoveNext
	*/

	public abstract IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Enumerable.Iterator<object>.Select<object>
	*/

	public abstract IEnumerable<TSource> Where(Func<TSource, bool> predicate);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Enumerable.Iterator<object>.Where
	*/

	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D0690 Offset: 0x19CEC90 VA: 0x1819D0690
	|-Enumerable.Iterator<Debugging.EntityInfo>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<WeightedStringList.Container>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<GameStat.Stat>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<PlayerItemRecipe>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<DictionaryEntry>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<KeyValuePair<object, int>>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<KeyValuePair<object, object>>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<KeyValuePair<uint, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D0700 Offset: 0x19CED00 VA: 0x1819D0700
	|-Enumerable.Iterator<BurstCloth.Chain>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<PathFinder.Point>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<PlayerItemRecipe.Ingredient>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<Achievement>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<InventoryItemId>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<Friend>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D0A50 Offset: 0x19CF050 VA: 0x1819D0A50
	|-Enumerable.Iterator<SkeletonDefinition.Bone>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<InventoryItem.Amount>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D0760 Offset: 0x19CED60 VA: 0x1819D0760
	|-Enumerable.Iterator<ItemSkinDirectory.Skin>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<Option>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<SkinnedMultiMesh.Part>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<InventoryItem>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D09F0 Offset: 0x19CEFF0 VA: 0x1819D09F0
	|-Enumerable.Iterator<FourBitNumber>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<SevenBitNumber>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D0970 Offset: 0x19CEF70 VA: 0x1819D0970
	|-Enumerable.Iterator<ProjectileWeaponMod.Modifier>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<Resolution>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D07E0 Offset: 0x19CEDE0 VA: 0x1819D07E0
	|-Enumerable.Iterator<ServerInfo>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<ServerInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D0910 Offset: 0x19CEF10 VA: 0x1819D0910
	|-Enumerable.Iterator<InventoryDefId>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<int>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<Int32Enum>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<uint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D0610 Offset: 0x19CEC10 VA: 0x1819D0610
	|-Enumerable.Iterator<InventoryRecipe.Ingredient>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<InventoryRecipe>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D0AD0 Offset: 0x19CF0D0 VA: 0x1819D0AD0
	|-Enumerable.Iterator<char>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19AD3A0 Offset: 0x19AB9A0 VA: 0x1819AD3A0
	|-Enumerable.Iterator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D08A0 Offset: 0x19CEEA0 VA: 0x1819D08A0
	|-Enumerable.Iterator<float>.System.Collections.IEnumerator.get_Current
	*/

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1650910 Offset: 0x164EF10 VA: 0x181650910
	|-Enumerable.Iterator<Debugging.EntityInfo>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<BurstCloth.Chain>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<SkeletonDefinition.Bone>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<WeightedStringList.Container>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<GameStat.Stat>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<ItemSkinDirectory.Skin>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<FourBitNumber>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<SevenBitNumber>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<PathFinder.Point>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<PlayerItemRecipe.Ingredient>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<PlayerItemRecipe>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<ProjectileWeaponMod.Modifier>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<Option>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<ServerInfo>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<SkinnedMultiMesh.Part>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<Achievement>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<InventoryDefId>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<InventoryItemId>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<ServerInfo>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<Friend>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<InventoryItem.Amount>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<InventoryItem>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<InventoryRecipe.Ingredient>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<InventoryRecipe>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<bool>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<char>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<DictionaryEntry>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<KeyValuePair<object, int>>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<KeyValuePair<object, object>>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<KeyValuePair<uint, object>>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<int>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<long>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<object>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<float>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<uint>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.Iterator<Resolution>.System.Collections.IEnumerable.GetEnumerator
	*/

	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D0430 Offset: 0x19CEA30 VA: 0x1819D0430
	|-Enumerable.Iterator<Debugging.EntityInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D04D0 Offset: 0x19CEAD0 VA: 0x1819D04D0
	|-Enumerable.Iterator<BurstCloth.Chain>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0110 Offset: 0x19CE710 VA: 0x1819D0110
	|-Enumerable.Iterator<SkeletonDefinition.Bone>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFC10 Offset: 0x19CE210 VA: 0x1819CFC10
	|-Enumerable.Iterator<WeightedStringList.Container>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0160 Offset: 0x19CE760 VA: 0x1819D0160
	|-Enumerable.Iterator<GameStat.Stat>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFB20 Offset: 0x19CE120 VA: 0x1819CFB20
	|-Enumerable.Iterator<ItemSkinDirectory.Skin>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0570 Offset: 0x19CEB70 VA: 0x1819D0570
	|-Enumerable.Iterator<FourBitNumber>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFD00 Offset: 0x19CE300 VA: 0x1819CFD00
	|-Enumerable.Iterator<SevenBitNumber>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFB70 Offset: 0x19CE170 VA: 0x1819CFB70
	|-Enumerable.Iterator<PathFinder.Point>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0480 Offset: 0x19CEA80 VA: 0x1819D0480
	|-Enumerable.Iterator<PlayerItemRecipe.Ingredient>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFEE0 Offset: 0x19CE4E0 VA: 0x1819CFEE0
	|-Enumerable.Iterator<PlayerItemRecipe>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFE40 Offset: 0x19CE440 VA: 0x1819CFE40
	|-Enumerable.Iterator<ProjectileWeaponMod.Modifier>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFFD0 Offset: 0x19CE5D0 VA: 0x1819CFFD0
	|-Enumerable.Iterator<Option>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFCB0 Offset: 0x19CE2B0 VA: 0x1819CFCB0
	|-Enumerable.Iterator<ServerInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFF80 Offset: 0x19CE580 VA: 0x1819CFF80
	|-Enumerable.Iterator<SkinnedMultiMesh.Part>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFA30 Offset: 0x19CE030 VA: 0x1819CFA30
	|-Enumerable.Iterator<Achievement>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D03E0 Offset: 0x19CE9E0 VA: 0x1819D03E0
	|-Enumerable.Iterator<InventoryDefId>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0200 Offset: 0x19CE800 VA: 0x1819D0200
	|-Enumerable.Iterator<InventoryItemId>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D05C0 Offset: 0x19CEBC0 VA: 0x1819D05C0
	|-Enumerable.Iterator<ServerInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D02F0 Offset: 0x19CE8F0 VA: 0x1819D02F0
	|-Enumerable.Iterator<Friend>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0520 Offset: 0x19CEB20 VA: 0x1819D0520
	|-Enumerable.Iterator<InventoryItem.Amount>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D00C0 Offset: 0x19CE6C0 VA: 0x1819D00C0
	|-Enumerable.Iterator<InventoryItem>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0340 Offset: 0x19CE940 VA: 0x1819D0340
	|-Enumerable.Iterator<InventoryRecipe.Ingredient>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D01B0 Offset: 0x19CE7B0 VA: 0x1819D01B0
	|-Enumerable.Iterator<InventoryRecipe>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFF30 Offset: 0x19CE530 VA: 0x1819CFF30
	|-Enumerable.Iterator<bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0250 Offset: 0x19CE850 VA: 0x1819D0250
	|-Enumerable.Iterator<char>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFBC0 Offset: 0x19CE1C0 VA: 0x1819CFBC0
	|-Enumerable.Iterator<DictionaryEntry>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFE90 Offset: 0x19CE490 VA: 0x1819CFE90
	|-Enumerable.Iterator<KeyValuePair<object, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFDA0 Offset: 0x19CE3A0 VA: 0x1819CFDA0
	|-Enumerable.Iterator<KeyValuePair<object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFAD0 Offset: 0x19CE0D0 VA: 0x1819CFAD0
	|-Enumerable.Iterator<KeyValuePair<uint, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0390 Offset: 0x19CE990 VA: 0x1819D0390
	|-Enumerable.Iterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFA80 Offset: 0x19CE080 VA: 0x1819CFA80
	|-Enumerable.Iterator<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0070 Offset: 0x19CE670 VA: 0x1819D0070
	|-Enumerable.Iterator<Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFDF0 Offset: 0x19CE3F0 VA: 0x1819CFDF0
	|-Enumerable.Iterator<long>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFC60 Offset: 0x19CE260 VA: 0x1819CFC60
	|-Enumerable.Iterator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFD50 Offset: 0x19CE350 VA: 0x1819CFD50
	|-Enumerable.Iterator<float>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D02A0 Offset: 0x19CE8A0 VA: 0x1819D02A0
	|-Enumerable.Iterator<uint>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0020 Offset: 0x19CE620 VA: 0x1819D0020
	|-Enumerable.Iterator<Resolution>.System.Collections.IEnumerator.Reset
	*/

}

private class Enumerable.WhereEnumerableIterator<TSource> : Enumerable.Iterator<TSource> // TypeDefIndex: 3200
{	private IEnumerable<TSource> source; // 0x0
	private Func<TSource, bool> predicate; // 0x0
	private IEnumerator<TSource> enumerator; // 0x0


	public void .ctor(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A2210 Offset: 0x16A0810 VA: 0x1816A2210
	|-Enumerable.WhereEnumerableIterator<Debugging.EntityInfo>..ctor
	|-Enumerable.WhereEnumerableIterator<GameStat.Stat>..ctor
	|-Enumerable.WhereEnumerableIterator<PlayerItemRecipe>..ctor
	|-Enumerable.WhereEnumerableIterator<ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, object>>..ctor
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<uint, object>>..ctor
	|-Enumerable.WhereEnumerableIterator<Resolution>..ctor
	|
	|-RVA: 0x16A3A70 Offset: 0x16A2070 VA: 0x1816A3A70
	|-Enumerable.WhereEnumerableIterator<SkeletonDefinition.Bone>..ctor
	|
	|-RVA: 0x16A3AE0 Offset: 0x16A20E0 VA: 0x1816A3AE0
	|-Enumerable.WhereEnumerableIterator<ItemSkinDirectory.Skin>..ctor
	|-Enumerable.WhereEnumerableIterator<Option>..ctor
	|-Enumerable.WhereEnumerableIterator<SkinnedMultiMesh.Part>..ctor
	|-Enumerable.WhereEnumerableIterator<InventoryItem>..ctor
	|
	|-RVA: 0x16A2280 Offset: 0x16A0880 VA: 0x1816A2280
	|-Enumerable.WhereEnumerableIterator<FourBitNumber>..ctor
	|-Enumerable.WhereEnumerableIterator<SevenBitNumber>..ctor
	|-Enumerable.WhereEnumerableIterator<PathFinder.Point>..ctor
	|-Enumerable.WhereEnumerableIterator<PlayerItemRecipe.Ingredient>..ctor
	|-Enumerable.WhereEnumerableIterator<InventoryItemId>..ctor
	|-Enumerable.WhereEnumerableIterator<bool>..ctor
	|-Enumerable.WhereEnumerableIterator<char>..ctor
	|-Enumerable.WhereEnumerableIterator<int>..ctor
	|-Enumerable.WhereEnumerableIterator<Int32Enum>..ctor
	|-Enumerable.WhereEnumerableIterator<long>..ctor
	|-Enumerable.WhereEnumerableIterator<object>..ctor
	|-Enumerable.WhereEnumerableIterator<float>..ctor
	|-Enumerable.WhereEnumerableIterator<uint>..ctor
	|
	|-RVA: 0x16A3B50 Offset: 0x16A2150 VA: 0x1816A3B50
	|-Enumerable.WhereEnumerableIterator<ServerInfo>..ctor
	|
	|-RVA: 0x16A3A00 Offset: 0x16A2000 VA: 0x1816A3A00
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe>..ctor
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>..ctor
	*/

	public override Enumerable.Iterator<TSource> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A1B10 Offset: 0x16A0110 VA: 0x1816A1B10
	|-Enumerable.WhereEnumerableIterator<Debugging.EntityInfo>.Clone
	|-Enumerable.WhereEnumerableIterator<GameStat.Stat>.Clone
	|-Enumerable.WhereEnumerableIterator<PlayerItemRecipe>.Clone
	|-Enumerable.WhereEnumerableIterator<ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, object>>.Clone
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<uint, object>>.Clone
	|-Enumerable.WhereEnumerableIterator<Resolution>.Clone
	|
	|-RVA: 0x16A2370 Offset: 0x16A0970 VA: 0x1816A2370
	|-Enumerable.WhereEnumerableIterator<SkeletonDefinition.Bone>.Clone
	|
	|-RVA: 0x16A22F0 Offset: 0x16A08F0 VA: 0x1816A22F0
	|-Enumerable.WhereEnumerableIterator<ItemSkinDirectory.Skin>.Clone
	|-Enumerable.WhereEnumerableIterator<Option>.Clone
	|-Enumerable.WhereEnumerableIterator<SkinnedMultiMesh.Part>.Clone
	|-Enumerable.WhereEnumerableIterator<InventoryItem>.Clone
	|
	|-RVA: 0x16A1B90 Offset: 0x16A0190 VA: 0x1816A1B90
	|-Enumerable.WhereEnumerableIterator<FourBitNumber>.Clone
	|-Enumerable.WhereEnumerableIterator<SevenBitNumber>.Clone
	|-Enumerable.WhereEnumerableIterator<PathFinder.Point>.Clone
	|-Enumerable.WhereEnumerableIterator<PlayerItemRecipe.Ingredient>.Clone
	|-Enumerable.WhereEnumerableIterator<InventoryItemId>.Clone
	|-Enumerable.WhereEnumerableIterator<bool>.Clone
	|-Enumerable.WhereEnumerableIterator<char>.Clone
	|-Enumerable.WhereEnumerableIterator<int>.Clone
	|-Enumerable.WhereEnumerableIterator<Int32Enum>.Clone
	|-Enumerable.WhereEnumerableIterator<long>.Clone
	|-Enumerable.WhereEnumerableIterator<object>.Clone
	|-Enumerable.WhereEnumerableIterator<float>.Clone
	|-Enumerable.WhereEnumerableIterator<uint>.Clone
	|
	|-RVA: 0x16A23F0 Offset: 0x16A09F0 VA: 0x1816A23F0
	|-Enumerable.WhereEnumerableIterator<ServerInfo>.Clone
	|
	|-RVA: 0x16A2480 Offset: 0x16A0A80 VA: 0x1816A2480
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe>.Clone
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.Clone
	*/

	public override void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D86C0 Offset: 0x19D6CC0 VA: 0x1819D86C0
	|-Enumerable.WhereEnumerableIterator<Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x19D9200 Offset: 0x19D7800 VA: 0x1819D9200
	|-Enumerable.WhereEnumerableIterator<SkeletonDefinition.Bone>.Dispose
	|
	|-RVA: 0x19D8870 Offset: 0x19D6E70 VA: 0x1819D8870
	|-Enumerable.WhereEnumerableIterator<GameStat.Stat>.Dispose
	|
	|-RVA: 0x19D8510 Offset: 0x19D6B10 VA: 0x1819D8510
	|-Enumerable.WhereEnumerableIterator<ItemSkinDirectory.Skin>.Dispose
	|
	|-RVA: 0x19D83F0 Offset: 0x19D69F0 VA: 0x1819D83F0
	|-Enumerable.WhereEnumerableIterator<FourBitNumber>.Dispose
	|
	|-RVA: 0x19D8BD0 Offset: 0x19D71D0 VA: 0x1819D8BD0
	|-Enumerable.WhereEnumerableIterator<SevenBitNumber>.Dispose
	|
	|-RVA: 0x19D8480 Offset: 0x19D6A80 VA: 0x1819D8480
	|-Enumerable.WhereEnumerableIterator<PathFinder.Point>.Dispose
	|
	|-RVA: 0x19D8990 Offset: 0x19D6F90 VA: 0x1819D8990
	|-Enumerable.WhereEnumerableIterator<PlayerItemRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x19D87E0 Offset: 0x19D6DE0 VA: 0x1819D87E0
	|-Enumerable.WhereEnumerableIterator<PlayerItemRecipe>.Dispose
	|
	|-RVA: 0x19D8360 Offset: 0x19D6960 VA: 0x1819D8360
	|-Enumerable.WhereEnumerableIterator<ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x19D8AB0 Offset: 0x19D70B0 VA: 0x1819D8AB0
	|-Enumerable.WhereEnumerableIterator<Option>.Dispose
	|
	|-RVA: 0x19D90E0 Offset: 0x19D76E0 VA: 0x1819D90E0
	|-Enumerable.WhereEnumerableIterator<ServerInfo>.Dispose
	|
	|-RVA: 0x19D82D0 Offset: 0x19D68D0 VA: 0x1819D82D0
	|-Enumerable.WhereEnumerableIterator<SkinnedMultiMesh.Part>.Dispose
	|
	|-RVA: 0x19D8C60 Offset: 0x19D7260 VA: 0x1819D8C60
	|-Enumerable.WhereEnumerableIterator<InventoryItemId>.Dispose
	|
	|-RVA: 0x19D8D80 Offset: 0x19D7380 VA: 0x1819D8D80
	|-Enumerable.WhereEnumerableIterator<InventoryItem>.Dispose
	|
	|-RVA: 0x19D9050 Offset: 0x19D7650 VA: 0x1819D9050
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x19D85A0 Offset: 0x19D6BA0 VA: 0x1819D85A0
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe>.Dispose
	|
	|-RVA: 0x19D8750 Offset: 0x19D6D50 VA: 0x1819D8750
	|-Enumerable.WhereEnumerableIterator<bool>.Dispose
	|
	|-RVA: 0x19D8F30 Offset: 0x19D7530 VA: 0x1819D8F30
	|-Enumerable.WhereEnumerableIterator<char>.Dispose
	|
	|-RVA: 0x19D8630 Offset: 0x19D6C30 VA: 0x1819D8630
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x19D8EA0 Offset: 0x19D74A0 VA: 0x1819D8EA0
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, object>>.Dispose
	|
	|-RVA: 0x19D8B40 Offset: 0x19D7140 VA: 0x1819D8B40
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<uint, object>>.Dispose
	|
	|-RVA: 0x19D8CF0 Offset: 0x19D72F0 VA: 0x1819D8CF0
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.Dispose
	|
	|-RVA: 0x19D8A20 Offset: 0x19D7020 VA: 0x1819D8A20
	|-Enumerable.WhereEnumerableIterator<int>.Dispose
	|
	|-RVA: 0x19D9170 Offset: 0x19D7770 VA: 0x1819D9170
	|-Enumerable.WhereEnumerableIterator<Int32Enum>.Dispose
	|
	|-RVA: 0x19D8900 Offset: 0x19D6F00 VA: 0x1819D8900
	|-Enumerable.WhereEnumerableIterator<long>.Dispose
	|
	|-RVA: 0x19D8FC0 Offset: 0x19D75C0 VA: 0x1819D8FC0
	|-Enumerable.WhereEnumerableIterator<object>.Dispose
	|
	|-RVA: 0x19D8E10 Offset: 0x19D7410 VA: 0x1819D8E10
	|-Enumerable.WhereEnumerableIterator<float>.Dispose
	|
	|-RVA: 0x16A1C10 Offset: 0x16A0210 VA: 0x1816A1C10
	|-Enumerable.WhereEnumerableIterator<uint>.Dispose
	|
	|-RVA: 0x16A1CA0 Offset: 0x16A02A0 VA: 0x1816A1CA0
	|-Enumerable.WhereEnumerableIterator<Resolution>.Dispose
	*/

	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19DAFB0 Offset: 0x19D95B0 VA: 0x1819DAFB0
	|-Enumerable.WhereEnumerableIterator<Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x19DB190 Offset: 0x19D9790 VA: 0x1819DB190
	|-Enumerable.WhereEnumerableIterator<SkeletonDefinition.Bone>.MoveNext
	|
	|-RVA: 0x19D9A30 Offset: 0x19D8030 VA: 0x1819D9A30
	|-Enumerable.WhereEnumerableIterator<GameStat.Stat>.MoveNext
	|
	|-RVA: 0x19DC460 Offset: 0x19DAA60 VA: 0x1819DC460
	|-Enumerable.WhereEnumerableIterator<ItemSkinDirectory.Skin>.MoveNext
	|
	|-RVA: 0x19DC0C0 Offset: 0x19DA6C0 VA: 0x1819DC0C0
	|-Enumerable.WhereEnumerableIterator<FourBitNumber>.MoveNext
	|
	|-RVA: 0x19D9F10 Offset: 0x19D8510 VA: 0x1819D9F10
	|-Enumerable.WhereEnumerableIterator<SevenBitNumber>.MoveNext
	|
	|-RVA: 0x19DA690 Offset: 0x19D8C90 VA: 0x1819DA690
	|-Enumerable.WhereEnumerableIterator<PathFinder.Point>.MoveNext
	|
	|-RVA: 0x19DA0D0 Offset: 0x19D86D0 VA: 0x1819DA0D0
	|-Enumerable.WhereEnumerableIterator<PlayerItemRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x19DABF0 Offset: 0x19D91F0 VA: 0x1819DABF0
	|-Enumerable.WhereEnumerableIterator<PlayerItemRecipe>.MoveNext
	|
	|-RVA: 0x19DA4B0 Offset: 0x19D8AB0 VA: 0x1819DA4B0
	|-Enumerable.WhereEnumerableIterator<ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x19D94C0 Offset: 0x19D7AC0 VA: 0x1819D94C0
	|-Enumerable.WhereEnumerableIterator<Option>.MoveNext
	|
	|-RVA: 0x19D9C10 Offset: 0x19D8210 VA: 0x1819D9C10
	|-Enumerable.WhereEnumerableIterator<ServerInfo>.MoveNext
	|
	|-RVA: 0x19DA9C0 Offset: 0x19D8FC0 VA: 0x1819DA9C0
	|-Enumerable.WhereEnumerableIterator<SkinnedMultiMesh.Part>.MoveNext
	|
	|-RVA: 0x19DBC40 Offset: 0x19DA240 VA: 0x1819DBC40
	|-Enumerable.WhereEnumerableIterator<InventoryItemId>.MoveNext
	|
	|-RVA: 0x19D9290 Offset: 0x19D7890 VA: 0x1819D9290
	|-Enumerable.WhereEnumerableIterator<InventoryItem>.MoveNext
	|
	|-RVA: 0x19DA290 Offset: 0x19D8890 VA: 0x1819DA290
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x19DB3E0 Offset: 0x19D99E0 VA: 0x1819DB3E0
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe>.MoveNext
	|
	|-RVA: 0x19DBE00 Offset: 0x19DA400 VA: 0x1819DBE00
	|-Enumerable.WhereEnumerableIterator<bool>.MoveNext
	|
	|-RVA: 0x19DBF60 Offset: 0x19DA560 VA: 0x1819DBF60
	|-Enumerable.WhereEnumerableIterator<char>.MoveNext
	|
	|-RVA: 0x19DADD0 Offset: 0x19D93D0 VA: 0x1819DADD0
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x19D9850 Offset: 0x19D7E50 VA: 0x1819D9850
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0x19DC280 Offset: 0x19DA880 VA: 0x1819DC280
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<uint, object>>.MoveNext
	|
	|-RVA: 0x19DB760 Offset: 0x19D9D60 VA: 0x1819DB760
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.MoveNext
	|
	|-RVA: 0x19DBAE0 Offset: 0x19DA0E0 VA: 0x1819DBAE0
	|-Enumerable.WhereEnumerableIterator<int>.MoveNext
	|
	|-RVA: 0x19D96F0 Offset: 0x19D7CF0 VA: 0x1819D96F0
	|-Enumerable.WhereEnumerableIterator<Int32Enum>.MoveNext
	|
	|-RVA: 0x19DB600 Offset: 0x19D9C00 VA: 0x1819DB600
	|-Enumerable.WhereEnumerableIterator<long>.MoveNext
	|
	|-RVA: 0x19DA850 Offset: 0x19D8E50 VA: 0x1819DA850
	|-Enumerable.WhereEnumerableIterator<object>.MoveNext
	|
	|-RVA: 0x19DB980 Offset: 0x19D9F80 VA: 0x1819DB980
	|-Enumerable.WhereEnumerableIterator<float>.MoveNext
	|
	|-RVA: 0x16A1F10 Offset: 0x16A0510 VA: 0x1816A1F10
	|-Enumerable.WhereEnumerableIterator<uint>.MoveNext
	|
	|-RVA: 0x16A1D30 Offset: 0x16A0330 VA: 0x1816A1D30
	|-Enumerable.WhereEnumerableIterator<Resolution>.MoveNext
	*/

	public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC8CF50 Offset: 0xC8B550 VA: 0x180C8CF50
	|-Enumerable.WhereEnumerableIterator<SkeletonDefinition.Bone>.Select<object>
	|
	|-RVA: 0xC8CC80 Offset: 0xC8B280 VA: 0x180C8CC80
	|-Enumerable.WhereEnumerableIterator<PlayerItemRecipe.Ingredient>.Select<int>
	|-Enumerable.WhereEnumerableIterator<int>.Select<FourBitNumber>
	|-Enumerable.WhereEnumerableIterator<int>.Select<SevenBitNumber>
	|-Enumerable.WhereEnumerableIterator<int>.Select<int>
	|-Enumerable.WhereEnumerableIterator<Int32Enum>.Select<object>
	|-Enumerable.WhereEnumerableIterator<object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereEnumerableIterator<object>.Select<PathFinder.Point>
	|-Enumerable.WhereEnumerableIterator<object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereEnumerableIterator<object>.Select<Option>
	|-Enumerable.WhereEnumerableIterator<object>.Select<InventoryItem>
	|-Enumerable.WhereEnumerableIterator<object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereEnumerableIterator<object>.Select<InventoryRecipe>
	|-Enumerable.WhereEnumerableIterator<object>.Select<bool>
	|-Enumerable.WhereEnumerableIterator<object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereEnumerableIterator<object>.Select<int>
	|-Enumerable.WhereEnumerableIterator<object>.Select<Int32Enum>
	|-Enumerable.WhereEnumerableIterator<object>.Select<long>
	|-Enumerable.WhereEnumerableIterator<object>.Select<object>
	|-Enumerable.WhereEnumerableIterator<object>.Select<float>
	|-Enumerable.WhereEnumerableIterator<object>.Select<Resolution>
	|
	|-RVA: 0xC8CEC0 Offset: 0xC8B4C0 VA: 0x180C8CEC0
	|-Enumerable.WhereEnumerableIterator<PlayerItemRecipe>.Select<object>
	|-Enumerable.WhereEnumerableIterator<ProjectileWeaponMod.Modifier>.Select<float>
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, object>>.Select<object>
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<uint, object>>.Select<object>
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<uint, object>>.Select<uint>
	|
	|-RVA: 0xC8CE30 Offset: 0xC8B430 VA: 0x180C8CE30
	|-Enumerable.WhereEnumerableIterator<Option>.Select<Option>
	|-Enumerable.WhereEnumerableIterator<SkinnedMultiMesh.Part>.Select<long>
	|-Enumerable.WhereEnumerableIterator<InventoryItem>.Select<InventoryItemId>
	|-Enumerable.WhereEnumerableIterator<InventoryItem>.Select<int>
	|-Enumerable.WhereEnumerableIterator<InventoryItem>.Select<object>
	|-Enumerable.WhereEnumerableIterator<InventoryItem>.Select<uint>
	|
	|-RVA: 0xC8CDA0 Offset: 0xC8B3A0 VA: 0x180C8CDA0
	|-Enumerable.WhereEnumerableIterator<ServerInfo>.Select<int>
	|-Enumerable.WhereEnumerableIterator<ServerInfo>.Select<object>
	|
	|-RVA: 0xC8CD10 Offset: 0xC8B310 VA: 0x180C8CD10
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe.Ingredient>.Select<PlayerItemRecipe.Ingredient>
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe.Ingredient>.Select<object>
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe>.Select<PlayerItemRecipe>
	*/

	public override IEnumerable<TSource> Where(Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A2170 Offset: 0x16A0770 VA: 0x1816A2170
	|-Enumerable.WhereEnumerableIterator<Debugging.EntityInfo>.Where
	|-Enumerable.WhereEnumerableIterator<GameStat.Stat>.Where
	|-Enumerable.WhereEnumerableIterator<PlayerItemRecipe>.Where
	|-Enumerable.WhereEnumerableIterator<ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, int>>.Where
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, object>>.Where
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<uint, object>>.Where
	|-Enumerable.WhereEnumerableIterator<Resolution>.Where
	|
	|-RVA: 0x19DC730 Offset: 0x19DAD30 VA: 0x1819DC730
	|-Enumerable.WhereEnumerableIterator<SkeletonDefinition.Bone>.Where
	|
	|-RVA: 0x19DC690 Offset: 0x19DAC90 VA: 0x1819DC690
	|-Enumerable.WhereEnumerableIterator<ItemSkinDirectory.Skin>.Where
	|-Enumerable.WhereEnumerableIterator<Option>.Where
	|-Enumerable.WhereEnumerableIterator<SkinnedMultiMesh.Part>.Where
	|-Enumerable.WhereEnumerableIterator<InventoryItem>.Where
	|
	|-RVA: 0x16A20D0 Offset: 0x16A06D0 VA: 0x1816A20D0
	|-Enumerable.WhereEnumerableIterator<FourBitNumber>.Where
	|-Enumerable.WhereEnumerableIterator<SevenBitNumber>.Where
	|-Enumerable.WhereEnumerableIterator<PathFinder.Point>.Where
	|-Enumerable.WhereEnumerableIterator<PlayerItemRecipe.Ingredient>.Where
	|-Enumerable.WhereEnumerableIterator<InventoryItemId>.Where
	|-Enumerable.WhereEnumerableIterator<bool>.Where
	|-Enumerable.WhereEnumerableIterator<char>.Where
	|-Enumerable.WhereEnumerableIterator<int>.Where
	|-Enumerable.WhereEnumerableIterator<Int32Enum>.Where
	|-Enumerable.WhereEnumerableIterator<long>.Where
	|-Enumerable.WhereEnumerableIterator<object>.Where
	|-Enumerable.WhereEnumerableIterator<float>.Where
	|-Enumerable.WhereEnumerableIterator<uint>.Where
	|
	|-RVA: 0x19DC7D0 Offset: 0x19DADD0 VA: 0x1819DC7D0
	|-Enumerable.WhereEnumerableIterator<ServerInfo>.Where
	|
	|-RVA: 0x19DC870 Offset: 0x19DAE70 VA: 0x1819DC870
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe>.Where
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.Where
	*/

}

private class Enumerable.WhereArrayIterator<TSource> : Enumerable.Iterator<TSource> // TypeDefIndex: 3201
{	private TSource[] source; // 0x0
	private Func<TSource, bool> predicate; // 0x0
	private int index; // 0x0


	public void .ctor(TSource[] source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A3A70 Offset: 0x16A2070 VA: 0x1816A3A70
	|-Enumerable.WhereArrayIterator<SkeletonDefinition.Bone>..ctor
	|
	|-RVA: 0x16A2210 Offset: 0x16A0810 VA: 0x1816A2210
	|-Enumerable.WhereArrayIterator<GameStat.Stat>..ctor
	|-Enumerable.WhereArrayIterator<ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereArrayIterator<KeyValuePair<object, object>>..ctor
	|-Enumerable.WhereArrayIterator<KeyValuePair<uint, object>>..ctor
	|
	|-RVA: 0x16A3AE0 Offset: 0x16A20E0 VA: 0x1816A3AE0
	|-Enumerable.WhereArrayIterator<ItemSkinDirectory.Skin>..ctor
	|-Enumerable.WhereArrayIterator<Option>..ctor
	|-Enumerable.WhereArrayIterator<SkinnedMultiMesh.Part>..ctor
	|-Enumerable.WhereArrayIterator<InventoryItem>..ctor
	|
	|-RVA: 0x16A3B50 Offset: 0x16A2150 VA: 0x1816A3B50
	|-Enumerable.WhereArrayIterator<ServerInfo>..ctor
	|
	|-RVA: 0x16A3A00 Offset: 0x16A2000 VA: 0x1816A3A00
	|-Enumerable.WhereArrayIterator<InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereArrayIterator<InventoryRecipe>..ctor
	|-Enumerable.WhereArrayIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>..ctor
	|
	|-RVA: 0x16A2280 Offset: 0x16A0880 VA: 0x1816A2280
	|-Enumerable.WhereArrayIterator<char>..ctor
	|-Enumerable.WhereArrayIterator<int>..ctor
	|-Enumerable.WhereArrayIterator<Int32Enum>..ctor
	|-Enumerable.WhereArrayIterator<object>..ctor
	*/

	public override Enumerable.Iterator<TSource> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A2370 Offset: 0x16A0970 VA: 0x1816A2370
	|-Enumerable.WhereArrayIterator<SkeletonDefinition.Bone>.Clone
	|
	|-RVA: 0x16A1B10 Offset: 0x16A0110 VA: 0x1816A1B10
	|-Enumerable.WhereArrayIterator<GameStat.Stat>.Clone
	|-Enumerable.WhereArrayIterator<ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereArrayIterator<KeyValuePair<object, object>>.Clone
	|-Enumerable.WhereArrayIterator<KeyValuePair<uint, object>>.Clone
	|
	|-RVA: 0x16A22F0 Offset: 0x16A08F0 VA: 0x1816A22F0
	|-Enumerable.WhereArrayIterator<ItemSkinDirectory.Skin>.Clone
	|-Enumerable.WhereArrayIterator<Option>.Clone
	|-Enumerable.WhereArrayIterator<SkinnedMultiMesh.Part>.Clone
	|-Enumerable.WhereArrayIterator<InventoryItem>.Clone
	|
	|-RVA: 0x16A23F0 Offset: 0x16A09F0 VA: 0x1816A23F0
	|-Enumerable.WhereArrayIterator<ServerInfo>.Clone
	|
	|-RVA: 0x16A2480 Offset: 0x16A0A80 VA: 0x1816A2480
	|-Enumerable.WhereArrayIterator<InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereArrayIterator<InventoryRecipe>.Clone
	|-Enumerable.WhereArrayIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.Clone
	|
	|-RVA: 0x16A1B90 Offset: 0x16A0190 VA: 0x1816A1B90
	|-Enumerable.WhereArrayIterator<char>.Clone
	|-Enumerable.WhereArrayIterator<int>.Clone
	|-Enumerable.WhereArrayIterator<Int32Enum>.Clone
	|-Enumerable.WhereArrayIterator<object>.Clone
	*/

	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D7680 Offset: 0x19D5C80 VA: 0x1819D7680
	|-Enumerable.WhereArrayIterator<SkeletonDefinition.Bone>.MoveNext
	|
	|-RVA: 0x19D75A0 Offset: 0x19D5BA0 VA: 0x1819D75A0
	|-Enumerable.WhereArrayIterator<GameStat.Stat>.MoveNext
	|-Enumerable.WhereArrayIterator<KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0x19D74A0 Offset: 0x19D5AA0 VA: 0x1819D74A0
	|-Enumerable.WhereArrayIterator<ItemSkinDirectory.Skin>.MoveNext
	|-Enumerable.WhereArrayIterator<Option>.MoveNext
	|
	|-RVA: 0x19D7E20 Offset: 0x19D6420 VA: 0x1819D7E20
	|-Enumerable.WhereArrayIterator<ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x19D72B0 Offset: 0x19D58B0 VA: 0x1819D72B0
	|-Enumerable.WhereArrayIterator<ServerInfo>.MoveNext
	|
	|-RVA: 0x19D7A80 Offset: 0x19D6080 VA: 0x1819D7A80
	|-Enumerable.WhereArrayIterator<SkinnedMultiMesh.Part>.MoveNext
	|
	|-RVA: 0x19D7880 Offset: 0x19D5E80 VA: 0x1819D7880
	|-Enumerable.WhereArrayIterator<InventoryItem>.MoveNext
	|
	|-RVA: 0x19D7980 Offset: 0x19D5F80 VA: 0x1819D7980
	|-Enumerable.WhereArrayIterator<InventoryRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereArrayIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.MoveNext
	|
	|-RVA: 0x19D7D20 Offset: 0x19D6320 VA: 0x1819D7D20
	|-Enumerable.WhereArrayIterator<InventoryRecipe>.MoveNext
	|
	|-RVA: 0x19D71F0 Offset: 0x19D57F0 VA: 0x1819D71F0
	|-Enumerable.WhereArrayIterator<char>.MoveNext
	|
	|-RVA: 0x19D7C40 Offset: 0x19D6240 VA: 0x1819D7C40
	|-Enumerable.WhereArrayIterator<KeyValuePair<uint, object>>.MoveNext
	|
	|-RVA: 0x19D7B80 Offset: 0x19D6180 VA: 0x1819D7B80
	|-Enumerable.WhereArrayIterator<int>.MoveNext
	|-Enumerable.WhereArrayIterator<Int32Enum>.MoveNext
	|
	|-RVA: 0x19D77B0 Offset: 0x19D5DB0 VA: 0x1819D77B0
	|-Enumerable.WhereArrayIterator<object>.MoveNext
	*/

	public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC8CF50 Offset: 0xC8B550 VA: 0x180C8CF50
	|-Enumerable.WhereArrayIterator<SkeletonDefinition.Bone>.Select<object>
	|
	|-RVA: 0xC8CEC0 Offset: 0xC8B4C0 VA: 0x180C8CEC0
	|-Enumerable.WhereArrayIterator<ProjectileWeaponMod.Modifier>.Select<float>
	|-Enumerable.WhereArrayIterator<KeyValuePair<object, object>>.Select<object>
	|-Enumerable.WhereArrayIterator<KeyValuePair<uint, object>>.Select<object>
	|-Enumerable.WhereArrayIterator<KeyValuePair<uint, object>>.Select<uint>
	|
	|-RVA: 0xC8CE30 Offset: 0xC8B430 VA: 0x180C8CE30
	|-Enumerable.WhereArrayIterator<Option>.Select<Option>
	|-Enumerable.WhereArrayIterator<SkinnedMultiMesh.Part>.Select<long>
	|-Enumerable.WhereArrayIterator<InventoryItem>.Select<InventoryItemId>
	|-Enumerable.WhereArrayIterator<InventoryItem>.Select<int>
	|-Enumerable.WhereArrayIterator<InventoryItem>.Select<object>
	|-Enumerable.WhereArrayIterator<InventoryItem>.Select<uint>
	|
	|-RVA: 0xC8CDA0 Offset: 0xC8B3A0 VA: 0x180C8CDA0
	|-Enumerable.WhereArrayIterator<ServerInfo>.Select<int>
	|-Enumerable.WhereArrayIterator<ServerInfo>.Select<object>
	|
	|-RVA: 0xC8CD10 Offset: 0xC8B310 VA: 0x180C8CD10
	|-Enumerable.WhereArrayIterator<InventoryRecipe.Ingredient>.Select<PlayerItemRecipe.Ingredient>
	|-Enumerable.WhereArrayIterator<InventoryRecipe.Ingredient>.Select<object>
	|-Enumerable.WhereArrayIterator<InventoryRecipe>.Select<PlayerItemRecipe>
	|
	|-RVA: 0xC8CC80 Offset: 0xC8B280 VA: 0x180C8CC80
	|-Enumerable.WhereArrayIterator<int>.Select<FourBitNumber>
	|-Enumerable.WhereArrayIterator<int>.Select<SevenBitNumber>
	|-Enumerable.WhereArrayIterator<int>.Select<int>
	|-Enumerable.WhereArrayIterator<Int32Enum>.Select<object>
	|-Enumerable.WhereArrayIterator<object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereArrayIterator<object>.Select<PathFinder.Point>
	|-Enumerable.WhereArrayIterator<object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereArrayIterator<object>.Select<Option>
	|-Enumerable.WhereArrayIterator<object>.Select<InventoryItem>
	|-Enumerable.WhereArrayIterator<object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereArrayIterator<object>.Select<InventoryRecipe>
	|-Enumerable.WhereArrayIterator<object>.Select<bool>
	|-Enumerable.WhereArrayIterator<object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereArrayIterator<object>.Select<int>
	|-Enumerable.WhereArrayIterator<object>.Select<Int32Enum>
	|-Enumerable.WhereArrayIterator<object>.Select<long>
	|-Enumerable.WhereArrayIterator<object>.Select<object>
	|-Enumerable.WhereArrayIterator<object>.Select<float>
	|-Enumerable.WhereArrayIterator<object>.Select<Resolution>
	*/

	public override IEnumerable<TSource> Where(Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D80F0 Offset: 0x19D66F0 VA: 0x1819D80F0
	|-Enumerable.WhereArrayIterator<SkeletonDefinition.Bone>.Where
	|
	|-RVA: 0x19D8050 Offset: 0x19D6650 VA: 0x1819D8050
	|-Enumerable.WhereArrayIterator<GameStat.Stat>.Where
	|-Enumerable.WhereArrayIterator<ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereArrayIterator<KeyValuePair<object, object>>.Where
	|-Enumerable.WhereArrayIterator<KeyValuePair<uint, object>>.Where
	|
	|-RVA: 0x19D7F10 Offset: 0x19D6510 VA: 0x1819D7F10
	|-Enumerable.WhereArrayIterator<ItemSkinDirectory.Skin>.Where
	|-Enumerable.WhereArrayIterator<Option>.Where
	|-Enumerable.WhereArrayIterator<SkinnedMultiMesh.Part>.Where
	|-Enumerable.WhereArrayIterator<InventoryItem>.Where
	|
	|-RVA: 0x19D8190 Offset: 0x19D6790 VA: 0x1819D8190
	|-Enumerable.WhereArrayIterator<ServerInfo>.Where
	|
	|-RVA: 0x19D8230 Offset: 0x19D6830 VA: 0x1819D8230
	|-Enumerable.WhereArrayIterator<InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereArrayIterator<InventoryRecipe>.Where
	|-Enumerable.WhereArrayIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.Where
	|
	|-RVA: 0x19D7FB0 Offset: 0x19D65B0 VA: 0x1819D7FB0
	|-Enumerable.WhereArrayIterator<char>.Where
	|-Enumerable.WhereArrayIterator<int>.Where
	|-Enumerable.WhereArrayIterator<Int32Enum>.Where
	|-Enumerable.WhereArrayIterator<object>.Where
	*/

}

private class Enumerable.WhereListIterator<TSource> : Enumerable.Iterator<TSource> // TypeDefIndex: 3202
{	private List<TSource> source; // 0x0
	private Func<TSource, bool> predicate; // 0x0
	private List.Enumerator<TSource> enumerator; // 0x0


	public void .ctor(List<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A3A70 Offset: 0x16A2070 VA: 0x1816A3A70
	|-Enumerable.WhereListIterator<SkeletonDefinition.Bone>..ctor
	|
	|-RVA: 0x16A2210 Offset: 0x16A0810 VA: 0x1816A2210
	|-Enumerable.WhereListIterator<GameStat.Stat>..ctor
	|-Enumerable.WhereListIterator<ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereListIterator<KeyValuePair<object, object>>..ctor
	|-Enumerable.WhereListIterator<KeyValuePair<uint, object>>..ctor
	|
	|-RVA: 0x16A3AE0 Offset: 0x16A20E0 VA: 0x1816A3AE0
	|-Enumerable.WhereListIterator<ItemSkinDirectory.Skin>..ctor
	|-Enumerable.WhereListIterator<Option>..ctor
	|-Enumerable.WhereListIterator<SkinnedMultiMesh.Part>..ctor
	|-Enumerable.WhereListIterator<InventoryItem>..ctor
	|
	|-RVA: 0x16A3B50 Offset: 0x16A2150 VA: 0x1816A3B50
	|-Enumerable.WhereListIterator<ServerInfo>..ctor
	|
	|-RVA: 0x16A3A00 Offset: 0x16A2000 VA: 0x1816A3A00
	|-Enumerable.WhereListIterator<InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereListIterator<InventoryRecipe>..ctor
	|-Enumerable.WhereListIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>..ctor
	|
	|-RVA: 0x16A2280 Offset: 0x16A0880 VA: 0x1816A2280
	|-Enumerable.WhereListIterator<char>..ctor
	|-Enumerable.WhereListIterator<int>..ctor
	|-Enumerable.WhereListIterator<Int32Enum>..ctor
	|-Enumerable.WhereListIterator<object>..ctor
	*/

	public override Enumerable.Iterator<TSource> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A2370 Offset: 0x16A0970 VA: 0x1816A2370
	|-Enumerable.WhereListIterator<SkeletonDefinition.Bone>.Clone
	|
	|-RVA: 0x16A1B10 Offset: 0x16A0110 VA: 0x1816A1B10
	|-Enumerable.WhereListIterator<GameStat.Stat>.Clone
	|-Enumerable.WhereListIterator<ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereListIterator<KeyValuePair<object, object>>.Clone
	|-Enumerable.WhereListIterator<KeyValuePair<uint, object>>.Clone
	|
	|-RVA: 0x16A22F0 Offset: 0x16A08F0 VA: 0x1816A22F0
	|-Enumerable.WhereListIterator<ItemSkinDirectory.Skin>.Clone
	|-Enumerable.WhereListIterator<Option>.Clone
	|-Enumerable.WhereListIterator<SkinnedMultiMesh.Part>.Clone
	|-Enumerable.WhereListIterator<InventoryItem>.Clone
	|
	|-RVA: 0x16A23F0 Offset: 0x16A09F0 VA: 0x1816A23F0
	|-Enumerable.WhereListIterator<ServerInfo>.Clone
	|
	|-RVA: 0x16A2480 Offset: 0x16A0A80 VA: 0x1816A2480
	|-Enumerable.WhereListIterator<InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereListIterator<InventoryRecipe>.Clone
	|-Enumerable.WhereListIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.Clone
	|
	|-RVA: 0x16A1B90 Offset: 0x16A0190 VA: 0x1816A1B90
	|-Enumerable.WhereListIterator<char>.Clone
	|-Enumerable.WhereListIterator<int>.Clone
	|-Enumerable.WhereListIterator<Int32Enum>.Clone
	|-Enumerable.WhereListIterator<object>.Clone
	*/

	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A2500 Offset: 0x16A0B00 VA: 0x1816A2500
	|-Enumerable.WhereListIterator<SkeletonDefinition.Bone>.MoveNext
	|
	|-RVA: 0x16A2680 Offset: 0x16A0C80 VA: 0x1816A2680
	|-Enumerable.WhereListIterator<GameStat.Stat>.MoveNext
	|-Enumerable.WhereListIterator<KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0x16A2A10 Offset: 0x16A1010 VA: 0x1816A2A10
	|-Enumerable.WhereListIterator<ItemSkinDirectory.Skin>.MoveNext
	|-Enumerable.WhereListIterator<Option>.MoveNext
	|
	|-RVA: 0x16A27A0 Offset: 0x16A0DA0 VA: 0x1816A27A0
	|-Enumerable.WhereListIterator<ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x16A2B60 Offset: 0x16A1160 VA: 0x1816A2B60
	|-Enumerable.WhereListIterator<ServerInfo>.MoveNext
	|
	|-RVA: 0x16A33F0 Offset: 0x16A19F0 VA: 0x1816A33F0
	|-Enumerable.WhereListIterator<SkinnedMultiMesh.Part>.MoveNext
	|
	|-RVA: 0x16A28C0 Offset: 0x16A0EC0 VA: 0x1816A28C0
	|-Enumerable.WhereListIterator<InventoryItem>.MoveNext
	|
	|-RVA: 0x16A3010 Offset: 0x16A1610 VA: 0x1816A3010
	|-Enumerable.WhereListIterator<InventoryRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereListIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.MoveNext
	|
	|-RVA: 0x16A3290 Offset: 0x16A1890 VA: 0x1816A3290
	|-Enumerable.WhereListIterator<InventoryRecipe>.MoveNext
	|
	|-RVA: 0x16A3540 Offset: 0x16A1B40 VA: 0x1816A3540
	|-Enumerable.WhereListIterator<char>.MoveNext
	|
	|-RVA: 0x16A3170 Offset: 0x16A1770 VA: 0x1816A3170
	|-Enumerable.WhereListIterator<KeyValuePair<uint, object>>.MoveNext
	|
	|-RVA: 0x16A2F10 Offset: 0x16A1510 VA: 0x1816A2F10
	|-Enumerable.WhereListIterator<int>.MoveNext
	|-Enumerable.WhereListIterator<Int32Enum>.MoveNext
	|
	|-RVA: 0x16A2E00 Offset: 0x16A1400 VA: 0x1816A2E00
	|-Enumerable.WhereListIterator<object>.MoveNext
	*/

	public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC8CF50 Offset: 0xC8B550 VA: 0x180C8CF50
	|-Enumerable.WhereListIterator<SkeletonDefinition.Bone>.Select<object>
	|
	|-RVA: 0xC8CEC0 Offset: 0xC8B4C0 VA: 0x180C8CEC0
	|-Enumerable.WhereListIterator<ProjectileWeaponMod.Modifier>.Select<float>
	|-Enumerable.WhereListIterator<KeyValuePair<object, object>>.Select<object>
	|-Enumerable.WhereListIterator<KeyValuePair<uint, object>>.Select<object>
	|-Enumerable.WhereListIterator<KeyValuePair<uint, object>>.Select<uint>
	|
	|-RVA: 0xC8CE30 Offset: 0xC8B430 VA: 0x180C8CE30
	|-Enumerable.WhereListIterator<Option>.Select<Option>
	|-Enumerable.WhereListIterator<SkinnedMultiMesh.Part>.Select<long>
	|-Enumerable.WhereListIterator<InventoryItem>.Select<InventoryItemId>
	|-Enumerable.WhereListIterator<InventoryItem>.Select<int>
	|-Enumerable.WhereListIterator<InventoryItem>.Select<object>
	|-Enumerable.WhereListIterator<InventoryItem>.Select<uint>
	|
	|-RVA: 0xC8CDA0 Offset: 0xC8B3A0 VA: 0x180C8CDA0
	|-Enumerable.WhereListIterator<ServerInfo>.Select<int>
	|-Enumerable.WhereListIterator<ServerInfo>.Select<object>
	|
	|-RVA: 0xC8CD10 Offset: 0xC8B310 VA: 0x180C8CD10
	|-Enumerable.WhereListIterator<InventoryRecipe.Ingredient>.Select<PlayerItemRecipe.Ingredient>
	|-Enumerable.WhereListIterator<InventoryRecipe.Ingredient>.Select<object>
	|-Enumerable.WhereListIterator<InventoryRecipe>.Select<PlayerItemRecipe>
	|
	|-RVA: 0xC8CC80 Offset: 0xC8B280 VA: 0x180C8CC80
	|-Enumerable.WhereListIterator<int>.Select<FourBitNumber>
	|-Enumerable.WhereListIterator<int>.Select<SevenBitNumber>
	|-Enumerable.WhereListIterator<int>.Select<int>
	|-Enumerable.WhereListIterator<Int32Enum>.Select<object>
	|-Enumerable.WhereListIterator<object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereListIterator<object>.Select<PathFinder.Point>
	|-Enumerable.WhereListIterator<object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereListIterator<object>.Select<Option>
	|-Enumerable.WhereListIterator<object>.Select<InventoryItem>
	|-Enumerable.WhereListIterator<object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereListIterator<object>.Select<InventoryRecipe>
	|-Enumerable.WhereListIterator<object>.Select<bool>
	|-Enumerable.WhereListIterator<object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereListIterator<object>.Select<int>
	|-Enumerable.WhereListIterator<object>.Select<Int32Enum>
	|-Enumerable.WhereListIterator<object>.Select<long>
	|-Enumerable.WhereListIterator<object>.Select<object>
	|-Enumerable.WhereListIterator<object>.Select<float>
	|-Enumerable.WhereListIterator<object>.Select<Resolution>
	*/

	public override IEnumerable<TSource> Where(Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A3960 Offset: 0x16A1F60 VA: 0x1816A3960
	|-Enumerable.WhereListIterator<SkeletonDefinition.Bone>.Where
	|
	|-RVA: 0x16A3640 Offset: 0x16A1C40 VA: 0x1816A3640
	|-Enumerable.WhereListIterator<GameStat.Stat>.Where
	|-Enumerable.WhereListIterator<ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereListIterator<KeyValuePair<object, object>>.Where
	|-Enumerable.WhereListIterator<KeyValuePair<uint, object>>.Where
	|
	|-RVA: 0x16A36E0 Offset: 0x16A1CE0 VA: 0x1816A36E0
	|-Enumerable.WhereListIterator<ItemSkinDirectory.Skin>.Where
	|-Enumerable.WhereListIterator<Option>.Where
	|-Enumerable.WhereListIterator<SkinnedMultiMesh.Part>.Where
	|-Enumerable.WhereListIterator<InventoryItem>.Where
	|
	|-RVA: 0x16A38C0 Offset: 0x16A1EC0 VA: 0x1816A38C0
	|-Enumerable.WhereListIterator<ServerInfo>.Where
	|
	|-RVA: 0x16A3820 Offset: 0x16A1E20 VA: 0x1816A3820
	|-Enumerable.WhereListIterator<InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereListIterator<InventoryRecipe>.Where
	|-Enumerable.WhereListIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.Where
	|
	|-RVA: 0x16A3780 Offset: 0x16A1D80 VA: 0x1816A3780
	|-Enumerable.WhereListIterator<char>.Where
	|-Enumerable.WhereListIterator<int>.Where
	|-Enumerable.WhereListIterator<Int32Enum>.Where
	|-Enumerable.WhereListIterator<object>.Where
	*/

}

private class Enumerable.WhereSelectEnumerableIterator<TSource, TResult> : Enumerable.Iterator<TResult> // TypeDefIndex: 3203
{	private IEnumerable<TSource> source; // 0x0
	private Func<TSource, bool> predicate; // 0x0
	private Func<TSource, TResult> selector; // 0x0
	private IEnumerator<TSource> enumerator; // 0x0


	public void .ctor(IEnumerable<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A8E20 Offset: 0x16A7420 VA: 0x1816A8E20
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, FourBitNumber>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, SevenBitNumber>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, int>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, bool>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, int>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Int32Enum>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, long>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, object>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, float>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<WeightedStringList.Container, float>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, bool>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, int>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Int32Enum>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, long>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, object>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, float>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, FourBitNumber>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, SevenBitNumber>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, int>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<ProjectileWeaponMod.Modifier, float>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, FourBitNumber>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, SevenBitNumber>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, bool>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, int>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Int32Enum>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, long>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, float>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<SkinnedMultiMesh.Part, long>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, bool>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, int>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Int32Enum>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, long>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, object>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, float>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, bool>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, int>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Int32Enum>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, long>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, object>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, float>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, int>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Friend, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Friend, bool>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Friend, int>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Int32Enum>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Friend, long>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Friend, object>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Friend, float>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, FourBitNumber>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, SevenBitNumber>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryItemId>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, bool>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, int>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Int32Enum>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, long>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, object>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, float>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, uint>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem.Amount, InventoryItemId>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem.Amount, uint>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe, object>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, bool>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, int>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Int32Enum>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, long>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, object>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, float>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<DictionaryEntry, object>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, bool>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, int>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Int32Enum>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, long>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, float>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, bool>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, int>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Int32Enum>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, long>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, object>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, float>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, uint>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<int, FourBitNumber>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<int, SevenBitNumber>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<int, int>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, bool>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, int>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Int32Enum>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, long>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, float>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<object, FourBitNumber>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<object, SevenBitNumber>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<object, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<object, PlayerItemRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryItemId>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<object, bool>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<object, int>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<object, Int32Enum>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<object, long>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<object, object>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<object, float>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<object, uint>..ctor
	|
	|-RVA: 0x16A8EB0 Offset: 0x16A74B0 VA: 0x1816A8EB0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Resolution>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Resolution>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Resolution>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Resolution>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Resolution>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Friend, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Friend, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Resolution>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Resolution>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe, PlayerItemRecipe>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Resolution>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<DictionaryEntry, KeyValuePair<object, object>>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Resolution>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Resolution>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Resolution>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<object, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<object, PlayerItemRecipe>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<object, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<object, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<object, Resolution>..ctor
	|
	|-RVA: 0x16A8FD0 Offset: 0x16A75D0 VA: 0x1816A8FD0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Option>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, InventoryItem>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Option>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, InventoryItem>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Option, Option>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Option>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, InventoryItem>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Option>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, InventoryItem>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Option>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, InventoryItem>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Option>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Friend, InventoryItem>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Option>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryItem>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Option>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, InventoryItem>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Option>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, InventoryItem>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Option>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, InventoryItem>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Option>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, InventoryItem>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<object, Option>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryItem>..ctor
	|
	|-RVA: 0x16A8F40 Offset: 0x16A7540 VA: 0x1816A8F40
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Friend, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Friend, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryRecipe>..ctor
	|
	|-RVA: 0x16A9060 Offset: 0x16A7660 VA: 0x1816A9060
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, ServerInfo>..ctor
	*/

	public override Enumerable.Iterator<TResult> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A3D00 Offset: 0x16A2300 VA: 0x1816A3D00
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, FourBitNumber>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, SevenBitNumber>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, int>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, bool>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, int>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Int32Enum>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, long>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, object>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, float>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<WeightedStringList.Container, float>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, bool>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, int>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Int32Enum>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, long>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, object>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, float>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, FourBitNumber>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, SevenBitNumber>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, int>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<ProjectileWeaponMod.Modifier, float>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, FourBitNumber>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, SevenBitNumber>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, bool>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, int>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Int32Enum>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, long>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, float>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<SkinnedMultiMesh.Part, long>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, bool>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, int>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Int32Enum>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, long>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, object>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, float>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, bool>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, int>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Int32Enum>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, long>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, object>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, float>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, int>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Friend, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Friend, bool>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Friend, int>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Int32Enum>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Friend, long>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Friend, object>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Friend, float>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, FourBitNumber>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, SevenBitNumber>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryItemId>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, bool>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, int>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Int32Enum>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, long>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, object>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, float>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, uint>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem.Amount, InventoryItemId>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem.Amount, uint>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe, object>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, bool>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, int>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Int32Enum>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, long>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, object>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, float>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<DictionaryEntry, object>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, bool>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, int>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Int32Enum>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, long>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, float>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, bool>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, int>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Int32Enum>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, long>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, object>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, float>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, uint>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<int, FourBitNumber>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<int, SevenBitNumber>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<int, int>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, bool>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, int>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Int32Enum>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, long>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, float>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<object, FourBitNumber>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<object, SevenBitNumber>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<object, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<object, PlayerItemRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryItemId>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<object, bool>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<object, int>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<object, Int32Enum>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<object, long>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<object, float>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<object, uint>.Clone
	|
	|-RVA: 0x16A3BC0 Offset: 0x16A21C0 VA: 0x1816A3BC0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Resolution>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Resolution>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Resolution>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Resolution>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Resolution>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Friend, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Friend, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Resolution>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Resolution>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe, PlayerItemRecipe>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Resolution>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<DictionaryEntry, KeyValuePair<object, object>>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Resolution>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Resolution>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Resolution>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<object, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<object, PlayerItemRecipe>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<object, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<object, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<object, Resolution>.Clone
	|
	|-RVA: 0x16A3C60 Offset: 0x16A2260 VA: 0x1816A3C60
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Option>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, InventoryItem>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Option>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, InventoryItem>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Option, Option>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Option>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, InventoryItem>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Option>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, InventoryItem>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Option>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, InventoryItem>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Option>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Friend, InventoryItem>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Option>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryItem>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Option>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, InventoryItem>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Option>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, InventoryItem>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Option>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, InventoryItem>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Option>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, InventoryItem>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<object, Option>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryItem>.Clone
	|
	|-RVA: 0x16A3DA0 Offset: 0x16A23A0 VA: 0x1816A3DA0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Friend, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Friend, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryRecipe>.Clone
	|
	|-RVA: 0x16A3E40 Offset: 0x16A2440 VA: 0x1816A3E40
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, ServerInfo>.Clone
	*/

	public override void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C02E0 Offset: 0x19BE8E0 VA: 0x1819C02E0
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, FourBitNumber>.Dispose
	|
	|-RVA: 0x19BFDD0 Offset: 0x19BE3D0 VA: 0x1819BFDD0
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, SevenBitNumber>.Dispose
	|
	|-RVA: 0x19BFCB0 Offset: 0x19BE2B0 VA: 0x1819BFCB0
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, int>.Dispose
	|
	|-RVA: 0x19C0400 Offset: 0x19BEA00 VA: 0x1819C0400
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x19C0490 Offset: 0x19BEA90 VA: 0x1819C0490
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, PathFinder.Point>.Dispose
	|
	|-RVA: 0x19C0370 Offset: 0x19BE970 VA: 0x1819C0370
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x19BFF80 Offset: 0x19BE580 VA: 0x1819BFF80
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Option>.Dispose
	|
	|-RVA: 0x19C0130 Offset: 0x19BE730 VA: 0x1819C0130
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, InventoryItem>.Dispose
	|
	|-RVA: 0x19C00A0 Offset: 0x19BE6A0 VA: 0x1819C00A0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x19BFD40 Offset: 0x19BE340 VA: 0x1819BFD40
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, InventoryRecipe>.Dispose
	|
	|-RVA: 0x19C0010 Offset: 0x19BE610 VA: 0x1819C0010
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, bool>.Dispose
	|
	|-RVA: 0x19BFC20 Offset: 0x19BE220 VA: 0x1819BFC20
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x19BFE60 Offset: 0x19BE460 VA: 0x1819BFE60
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, int>.Dispose
	|
	|-RVA: 0x19BFEF0 Offset: 0x19BE4F0 VA: 0x1819BFEF0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Int32Enum>.Dispose
	|
	|-RVA: 0x19C0250 Offset: 0x19BE850 VA: 0x1819C0250
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, long>.Dispose
	|
	|-RVA: 0x19C01C0 Offset: 0x19BE7C0 VA: 0x1819C01C0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, object>.Dispose
	|
	|-RVA: 0x1A18710 Offset: 0x1A16D10 VA: 0x181A18710
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, float>.Dispose
	|
	|-RVA: 0x1A19AC0 Offset: 0x1A180C0 VA: 0x181A19AC0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Resolution>.Dispose
	|
	|-RVA: 0x1A19760 Offset: 0x1A17D60 VA: 0x181A19760
	|-Enumerable.WhereSelectEnumerableIterator<WeightedStringList.Container, float>.Dispose
	|
	|-RVA: 0x1A17A20 Offset: 0x1A16020 VA: 0x181A17A20
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A18CB0 Offset: 0x1A172B0 VA: 0x181A18CB0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A19B50 Offset: 0x1A18150 VA: 0x181A19B50
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A16820 Offset: 0x1A14E20 VA: 0x181A16820
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Option>.Dispose
	|
	|-RVA: 0x1A18C20 Offset: 0x1A17220 VA: 0x181A18C20
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, InventoryItem>.Dispose
	|
	|-RVA: 0x1A17870 Offset: 0x1A15E70 VA: 0x181A17870
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A17D80 Offset: 0x1A16380 VA: 0x181A17D80
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A17EA0 Offset: 0x1A164A0 VA: 0x181A17EA0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, bool>.Dispose
	|
	|-RVA: 0x1A19A30 Offset: 0x1A18030 VA: 0x181A19A30
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A19250 Offset: 0x1A17850 VA: 0x181A19250
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, int>.Dispose
	|
	|-RVA: 0x1A17AB0 Offset: 0x1A160B0 VA: 0x181A17AB0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Int32Enum>.Dispose
	|
	|-RVA: 0x1A17E10 Offset: 0x1A16410 VA: 0x181A17E10
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, long>.Dispose
	|
	|-RVA: 0x1A18560 Offset: 0x1A16B60 VA: 0x181A18560
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, object>.Dispose
	|
	|-RVA: 0x1A168B0 Offset: 0x1A14EB0 VA: 0x181A168B0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, float>.Dispose
	|
	|-RVA: 0x1A183B0 Offset: 0x1A169B0 VA: 0x181A183B0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Resolution>.Dispose
	|
	|-RVA: 0x1A173F0 Offset: 0x1A159F0 VA: 0x181A173F0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, FourBitNumber>.Dispose
	|
	|-RVA: 0x1A18D40 Offset: 0x1A17340 VA: 0x181A18D40
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, SevenBitNumber>.Dispose
	|
	|-RVA: 0x1A19010 Offset: 0x1A17610 VA: 0x181A19010
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, int>.Dispose
	|
	|-RVA: 0x1A17630 Offset: 0x1A15C30 VA: 0x181A17630
	|-Enumerable.WhereSelectEnumerableIterator<ProjectileWeaponMod.Modifier, float>.Dispose
	|
	|-RVA: 0x1A16AF0 Offset: 0x1A150F0 VA: 0x181A16AF0
	|-Enumerable.WhereSelectEnumerableIterator<Option, Option>.Dispose
	|
	|-RVA: 0x1A189E0 Offset: 0x1A16FE0 VA: 0x181A189E0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A187A0 Offset: 0x1A16DA0 VA: 0x181A187A0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, FourBitNumber>.Dispose
	|
	|-RVA: 0x1A17750 Offset: 0x1A15D50 VA: 0x181A17750
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, SevenBitNumber>.Dispose
	|
	|-RVA: 0x1A19130 Offset: 0x1A17730 VA: 0x181A19130
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A17510 Offset: 0x1A15B10 VA: 0x181A17510
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A18DD0 Offset: 0x1A173D0 VA: 0x181A18DD0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Option>.Dispose
	|
	|-RVA: 0x1A18A70 Offset: 0x1A17070 VA: 0x181A18A70
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, InventoryItem>.Dispose
	|
	|-RVA: 0x1A16940 Offset: 0x1A14F40 VA: 0x181A16940
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A16B80 Offset: 0x1A15180 VA: 0x181A16B80
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A180E0 Offset: 0x1A166E0 VA: 0x181A180E0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, bool>.Dispose
	|
	|-RVA: 0x1A16EE0 Offset: 0x1A154E0 VA: 0x181A16EE0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A18830 Offset: 0x1A16E30 VA: 0x181A18830
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, int>.Dispose
	|
	|-RVA: 0x1A17BD0 Offset: 0x1A161D0 VA: 0x181A17BD0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Int32Enum>.Dispose
	|
	|-RVA: 0x1A17360 Offset: 0x1A15960 VA: 0x181A17360
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, long>.Dispose
	|
	|-RVA: 0x1A18290 Offset: 0x1A16890 VA: 0x181A18290
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.Dispose
	|
	|-RVA: 0x1A16700 Offset: 0x1A14D00 VA: 0x181A16700
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, float>.Dispose
	|
	|-RVA: 0x1A165E0 Offset: 0x1A14BE0 VA: 0x181A165E0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Resolution>.Dispose
	|
	|-RVA: 0x1A17480 Offset: 0x1A15A80 VA: 0x181A17480
	|-Enumerable.WhereSelectEnumerableIterator<SkinnedMultiMesh.Part, long>.Dispose
	|
	|-RVA: 0x1A17000 Offset: 0x1A15600 VA: 0x181A17000
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A177E0 Offset: 0x1A15DE0 VA: 0x181A177E0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A16550 Offset: 0x1A14B50 VA: 0x181A16550
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A176C0 Offset: 0x1A15CC0 VA: 0x181A176C0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Option>.Dispose
	|
	|-RVA: 0x1A18050 Offset: 0x1A16650 VA: 0x181A18050
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, InventoryItem>.Dispose
	|
	|-RVA: 0x1A18680 Offset: 0x1A16C80 VA: 0x181A18680
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A192E0 Offset: 0x1A178E0 VA: 0x181A192E0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A17990 Offset: 0x1A15F90 VA: 0x181A17990
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, bool>.Dispose
	|
	|-RVA: 0x1A16F70 Offset: 0x1A15570 VA: 0x181A16F70
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A163A0 Offset: 0x1A149A0 VA: 0x181A163A0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, int>.Dispose
	|
	|-RVA: 0x1A17F30 Offset: 0x1A16530 VA: 0x181A17F30
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Int32Enum>.Dispose
	|
	|-RVA: 0x1A17FC0 Offset: 0x1A165C0 VA: 0x181A17FC0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, long>.Dispose
	|
	|-RVA: 0x1A16790 Offset: 0x1A14D90 VA: 0x181A16790
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, object>.Dispose
	|
	|-RVA: 0x1A19520 Offset: 0x1A17B20 VA: 0x181A19520
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, float>.Dispose
	|
	|-RVA: 0x1A18F80 Offset: 0x1A17580 VA: 0x181A18F80
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Resolution>.Dispose
	|
	|-RVA: 0x1A197F0 Offset: 0x1A17DF0 VA: 0x181A197F0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A169D0 Offset: 0x1A14FD0 VA: 0x181A169D0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A190A0 Offset: 0x1A176A0 VA: 0x181A190A0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A19490 Offset: 0x1A17A90 VA: 0x181A19490
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Option>.Dispose
	|
	|-RVA: 0x1A195B0 Offset: 0x1A17BB0 VA: 0x181A195B0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, InventoryItem>.Dispose
	|
	|-RVA: 0x1A18950 Offset: 0x1A16F50 VA: 0x181A18950
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A17090 Offset: 0x1A15690 VA: 0x181A17090
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A16670 Offset: 0x1A14C70 VA: 0x181A16670
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, bool>.Dispose
	|
	|-RVA: 0x1A18E60 Offset: 0x1A17460 VA: 0x181A18E60
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A188C0 Offset: 0x1A16EC0 VA: 0x181A188C0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, int>.Dispose
	|
	|-RVA: 0x1A19400 Offset: 0x1A17A00 VA: 0x181A19400
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Int32Enum>.Dispose
	|
	|-RVA: 0x1A185F0 Offset: 0x1A16BF0 VA: 0x181A185F0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, long>.Dispose
	|
	|-RVA: 0x1A16430 Offset: 0x1A14A30 VA: 0x181A16430
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, object>.Dispose
	|
	|-RVA: 0x1A175A0 Offset: 0x1A15BA0 VA: 0x181A175A0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, float>.Dispose
	|
	|-RVA: 0x1A17900 Offset: 0x1A15F00 VA: 0x181A17900
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Resolution>.Dispose
	|
	|-RVA: 0x1A19640 Offset: 0x1A17C40 VA: 0x181A19640
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, ServerInfo>.Dispose
	|
	|-RVA: 0x1A184D0 Offset: 0x1A16AD0 VA: 0x181A184D0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, int>.Dispose
	|
	|-RVA: 0x1A164C0 Offset: 0x1A14AC0 VA: 0x181A164C0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.Dispose
	|
	|-RVA: 0x1A17120 Offset: 0x1A15720 VA: 0x181A17120
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A16C10 Offset: 0x1A15210 VA: 0x181A16C10
	|-Enumerable.WhereSelectEnumerableIterator<Friend, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A196D0 Offset: 0x1A17CD0 VA: 0x181A196D0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A18440 Offset: 0x1A16A40 VA: 0x181A18440
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Option>.Dispose
	|
	|-RVA: 0x1A19370 Offset: 0x1A17970 VA: 0x181A19370
	|-Enumerable.WhereSelectEnumerableIterator<Friend, InventoryItem>.Dispose
	|
	|-RVA: 0x1A16DC0 Offset: 0x1A153C0 VA: 0x181A16DC0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A18320 Offset: 0x1A16920 VA: 0x181A18320
	|-Enumerable.WhereSelectEnumerableIterator<Friend, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A16E50 Offset: 0x1A15450 VA: 0x181A16E50
	|-Enumerable.WhereSelectEnumerableIterator<Friend, bool>.Dispose
	|
	|-RVA: 0x1A199A0 Offset: 0x1A17FA0 VA: 0x181A199A0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A18B00 Offset: 0x1A17100 VA: 0x181A18B00
	|-Enumerable.WhereSelectEnumerableIterator<Friend, int>.Dispose
	|
	|-RVA: 0x1A18200 Offset: 0x1A16800 VA: 0x181A18200
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Int32Enum>.Dispose
	|
	|-RVA: 0x1A16D30 Offset: 0x1A15330 VA: 0x181A16D30
	|-Enumerable.WhereSelectEnumerableIterator<Friend, long>.Dispose
	|
	|-RVA: 0x1A18170 Offset: 0x1A16770 VA: 0x181A18170
	|-Enumerable.WhereSelectEnumerableIterator<Friend, object>.Dispose
	|
	|-RVA: 0x1A17B40 Offset: 0x1A16140 VA: 0x181A17B40
	|-Enumerable.WhereSelectEnumerableIterator<Friend, float>.Dispose
	|
	|-RVA: 0x1A17CF0 Offset: 0x1A162F0 VA: 0x181A17CF0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Resolution>.Dispose
	|
	|-RVA: 0x1A19880 Offset: 0x1A17E80 VA: 0x181A19880
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A17240 Offset: 0x1A15840 VA: 0x181A17240
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, FourBitNumber>.Dispose
	|
	|-RVA: 0x1A191C0 Offset: 0x1A177C0 VA: 0x181A191C0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, SevenBitNumber>.Dispose
	|
	|-RVA: 0x1A16A60 Offset: 0x1A15060 VA: 0x181A16A60
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A16310 Offset: 0x1A14910 VA: 0x181A16310
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A18EF0 Offset: 0x1A174F0 VA: 0x181A18EF0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Option>.Dispose
	|
	|-RVA: 0x1A171B0 Offset: 0x1A157B0 VA: 0x181A171B0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryItemId>.Dispose
	|
	|-RVA: 0x1A16CA0 Offset: 0x1A152A0 VA: 0x181A16CA0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryItem>.Dispose
	|
	|-RVA: 0x1A17C60 Offset: 0x1A16260 VA: 0x181A17C60
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A172D0 Offset: 0x1A158D0 VA: 0x181A172D0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A18B90 Offset: 0x1A17190 VA: 0x181A18B90
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, bool>.Dispose
	|
	|-RVA: 0x1A19910 Offset: 0x1A17F10 VA: 0x181A19910
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A29B10 Offset: 0x1A28110 VA: 0x181A29B10
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, int>.Dispose
	|
	|-RVA: 0x1A27710 Offset: 0x1A25D10 VA: 0x181A27710
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Int32Enum>.Dispose
	|
	|-RVA: 0x1A27830 Offset: 0x1A25E30 VA: 0x181A27830
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, long>.Dispose
	|
	|-RVA: 0x1A26B40 Offset: 0x1A25140 VA: 0x181A26B40
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, object>.Dispose
	|
	|-RVA: 0x1A28D90 Offset: 0x1A27390 VA: 0x181A28D90
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, float>.Dispose
	|
	|-RVA: 0x1A27320 Offset: 0x1A25920 VA: 0x181A27320
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, uint>.Dispose
	|
	|-RVA: 0x1A27B90 Offset: 0x1A26190 VA: 0x181A27B90
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Resolution>.Dispose
	|
	|-RVA: 0x1A27D40 Offset: 0x1A26340 VA: 0x181A27D40
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem.Amount, InventoryItemId>.Dispose
	|
	|-RVA: 0x1A29F90 Offset: 0x1A28590 VA: 0x181A29F90
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem.Amount, uint>.Dispose
	|
	|-RVA: 0x1A28AC0 Offset: 0x1A270C0 VA: 0x181A28AC0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe, PlayerItemRecipe>.Dispose
	|
	|-RVA: 0x1A29330 Offset: 0x1A27930 VA: 0x181A29330
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe, object>.Dispose
	|
	|-RVA: 0x1A26F30 Offset: 0x1A25530 VA: 0x181A26F30
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A27680 Offset: 0x1A25C80 VA: 0x181A27680
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A29D50 Offset: 0x1A28350 VA: 0x181A29D50
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A29BA0 Offset: 0x1A281A0 VA: 0x181A29BA0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A29690 Offset: 0x1A27C90 VA: 0x181A29690
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Option>.Dispose
	|
	|-RVA: 0x1A28F40 Offset: 0x1A27540 VA: 0x181A28F40
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, InventoryItem>.Dispose
	|
	|-RVA: 0x1A29180 Offset: 0x1A27780 VA: 0x181A29180
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A27560 Offset: 0x1A25B60 VA: 0x181A27560
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A26CF0 Offset: 0x1A252F0 VA: 0x181A26CF0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, bool>.Dispose
	|
	|-RVA: 0x1A274D0 Offset: 0x1A25AD0 VA: 0x181A274D0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A292A0 Offset: 0x1A278A0 VA: 0x181A292A0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, int>.Dispose
	|
	|-RVA: 0x1A287F0 Offset: 0x1A26DF0 VA: 0x181A287F0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Int32Enum>.Dispose
	|
	|-RVA: 0x1A29C30 Offset: 0x1A28230 VA: 0x181A29C30
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, long>.Dispose
	|
	|-RVA: 0x1A286D0 Offset: 0x1A26CD0 VA: 0x181A286D0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, object>.Dispose
	|
	|-RVA: 0x1A29720 Offset: 0x1A27D20 VA: 0x181A29720
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, float>.Dispose
	|
	|-RVA: 0x1A27170 Offset: 0x1A25770 VA: 0x181A27170
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Resolution>.Dispose
	|
	|-RVA: 0x1A28C70 Offset: 0x1A27270 VA: 0x181A28C70
	|-Enumerable.WhereSelectEnumerableIterator<DictionaryEntry, KeyValuePair<object, object>>.Dispose
	|
	|-RVA: 0x1A27440 Offset: 0x1A25A40 VA: 0x181A27440
	|-Enumerable.WhereSelectEnumerableIterator<DictionaryEntry, object>.Dispose
	|
	|-RVA: 0x1A26900 Offset: 0x1A24F00 VA: 0x181A26900
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A285B0 Offset: 0x1A26BB0 VA: 0x181A285B0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A26AB0 Offset: 0x1A250B0 VA: 0x181A26AB0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A27050 Offset: 0x1A25650 VA: 0x181A27050
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Option>.Dispose
	|
	|-RVA: 0x1A289A0 Offset: 0x1A26FA0 VA: 0x181A289A0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, InventoryItem>.Dispose
	|
	|-RVA: 0x1A28130 Offset: 0x1A26730 VA: 0x181A28130
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A28A30 Offset: 0x1A27030 VA: 0x181A28A30
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A27DD0 Offset: 0x1A263D0 VA: 0x181A27DD0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, bool>.Dispose
	|
	|-RVA: 0x1A290F0 Offset: 0x1A276F0 VA: 0x181A290F0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A29F00 Offset: 0x1A28500 VA: 0x181A29F00
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, int>.Dispose
	|
	|-RVA: 0x1A27950 Offset: 0x1A25F50 VA: 0x181A27950
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Int32Enum>.Dispose
	|
	|-RVA: 0x1A26A20 Offset: 0x1A25020 VA: 0x181A26A20
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, long>.Dispose
	|
	|-RVA: 0x1A270E0 Offset: 0x1A256E0 VA: 0x181A270E0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Dispose
	|
	|-RVA: 0x1A297B0 Offset: 0x1A27DB0 VA: 0x181A297B0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, float>.Dispose
	|
	|-RVA: 0x1A26FC0 Offset: 0x1A255C0 VA: 0x181A26FC0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Resolution>.Dispose
	|
	|-RVA: 0x1A27A70 Offset: 0x1A26070 VA: 0x181A27A70
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A29570 Offset: 0x1A27B70 VA: 0x181A29570
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A26E10 Offset: 0x1A25410 VA: 0x181A26E10
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A29960 Offset: 0x1A27F60 VA: 0x181A29960
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Option>.Dispose
	|
	|-RVA: 0x1A29E70 Offset: 0x1A28470 VA: 0x181A29E70
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, InventoryItem>.Dispose
	|
	|-RVA: 0x1A28880 Offset: 0x1A26E80 VA: 0x181A28880
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A299F0 Offset: 0x1A27FF0 VA: 0x181A299F0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A28EB0 Offset: 0x1A274B0 VA: 0x181A28EB0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, bool>.Dispose
	|
	|-RVA: 0x1A279E0 Offset: 0x1A25FE0 VA: 0x181A279E0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A26D80 Offset: 0x1A25380 VA: 0x181A26D80
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, int>.Dispose
	|
	|-RVA: 0x1A28B50 Offset: 0x1A27150 VA: 0x181A28B50
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Int32Enum>.Dispose
	|
	|-RVA: 0x1A27290 Offset: 0x1A25890 VA: 0x181A27290
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, long>.Dispose
	|
	|-RVA: 0x1A29840 Offset: 0x1A27E40 VA: 0x181A29840
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, object>.Dispose
	|
	|-RVA: 0x1A27200 Offset: 0x1A25800 VA: 0x181A27200
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, float>.Dispose
	|
	|-RVA: 0x1A273B0 Offset: 0x1A259B0 VA: 0x181A273B0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, uint>.Dispose
	|
	|-RVA: 0x1A28370 Offset: 0x1A26970 VA: 0x181A28370
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Resolution>.Dispose
	|
	|-RVA: 0x1A29600 Offset: 0x1A27C00 VA: 0x181A29600
	|-Enumerable.WhereSelectEnumerableIterator<int, FourBitNumber>.Dispose
	|
	|-RVA: 0x1A29060 Offset: 0x1A27660 VA: 0x181A29060
	|-Enumerable.WhereSelectEnumerableIterator<int, SevenBitNumber>.Dispose
	|
	|-RVA: 0x1A28640 Offset: 0x1A26C40 VA: 0x181A28640
	|-Enumerable.WhereSelectEnumerableIterator<int, int>.Dispose
	|
	|-RVA: 0x1A28760 Offset: 0x1A26D60 VA: 0x181A28760
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A29DE0 Offset: 0x1A283E0 VA: 0x181A29DE0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A28250 Offset: 0x1A26850 VA: 0x181A28250
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A281C0 Offset: 0x1A267C0 VA: 0x181A281C0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Option>.Dispose
	|
	|-RVA: 0x1A28490 Offset: 0x1A26A90 VA: 0x181A28490
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, InventoryItem>.Dispose
	|
	|-RVA: 0x1A28520 Offset: 0x1A26B20 VA: 0x181A28520
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A27CB0 Offset: 0x1A262B0 VA: 0x181A27CB0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A27B00 Offset: 0x1A26100 VA: 0x181A27B00
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, bool>.Dispose
	|
	|-RVA: 0x1A28FD0 Offset: 0x1A275D0 VA: 0x181A28FD0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A29A80 Offset: 0x1A28080 VA: 0x181A29A80
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, int>.Dispose
	|
	|-RVA: 0x1A29210 Offset: 0x1A27810 VA: 0x181A29210
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Int32Enum>.Dispose
	|
	|-RVA: 0x1A298D0 Offset: 0x1A27ED0 VA: 0x181A298D0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, long>.Dispose
	|
	|-RVA: 0x1A27F80 Offset: 0x1A26580 VA: 0x181A27F80
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Dispose
	|
	|-RVA: 0x1A282E0 Offset: 0x1A268E0 VA: 0x181A282E0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, float>.Dispose
	|
	|-RVA: 0x1A26C60 Offset: 0x1A25260 VA: 0x181A26C60
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Resolution>.Dispose
	|
	|-RVA: 0x1A28400 Offset: 0x1A26A00 VA: 0x181A28400
	|-Enumerable.WhereSelectEnumerableIterator<object, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A28010 Offset: 0x1A26610 VA: 0x181A28010
	|-Enumerable.WhereSelectEnumerableIterator<object, FourBitNumber>.Dispose
	|
	|-RVA: 0x1A28BE0 Offset: 0x1A271E0 VA: 0x181A28BE0
	|-Enumerable.WhereSelectEnumerableIterator<object, SevenBitNumber>.Dispose
	|
	|-RVA: 0x1A275F0 Offset: 0x1A25BF0 VA: 0x181A275F0
	|-Enumerable.WhereSelectEnumerableIterator<object, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A26BD0 Offset: 0x1A251D0 VA: 0x181A26BD0
	|-Enumerable.WhereSelectEnumerableIterator<object, PlayerItemRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A26870 Offset: 0x1A24E70 VA: 0x181A26870
	|-Enumerable.WhereSelectEnumerableIterator<object, PlayerItemRecipe>.Dispose
	|
	|-RVA: 0x1A29CC0 Offset: 0x1A282C0 VA: 0x181A29CC0
	|-Enumerable.WhereSelectEnumerableIterator<object, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A26990 Offset: 0x1A24F90 VA: 0x181A26990
	|-Enumerable.WhereSelectEnumerableIterator<object, Option>.Dispose
	|
	|-RVA: 0x1A280A0 Offset: 0x1A266A0 VA: 0x181A280A0
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryItemId>.Dispose
	|
	|-RVA: 0x1A26EA0 Offset: 0x1A254A0 VA: 0x181A26EA0
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryItem>.Dispose
	|
	|-RVA: 0x1A277A0 Offset: 0x1A25DA0 VA: 0x181A277A0
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A278C0 Offset: 0x1A25EC0 VA: 0x181A278C0
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A29450 Offset: 0x1A27A50 VA: 0x181A29450
	|-Enumerable.WhereSelectEnumerableIterator<object, bool>.Dispose
	|
	|-RVA: 0x1A28910 Offset: 0x1A26F10 VA: 0x181A28910
	|-Enumerable.WhereSelectEnumerableIterator<object, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A27E60 Offset: 0x1A26460 VA: 0x181A27E60
	|-Enumerable.WhereSelectEnumerableIterator<object, int>.Dispose
	|
	|-RVA: 0x1A28D00 Offset: 0x1A27300 VA: 0x181A28D00
	|-Enumerable.WhereSelectEnumerableIterator<object, Int32Enum>.Dispose
	|
	|-RVA: 0x1A27EF0 Offset: 0x1A264F0 VA: 0x181A27EF0
	|-Enumerable.WhereSelectEnumerableIterator<object, long>.Dispose
	|
	|-RVA: 0x1A27C20 Offset: 0x1A26220 VA: 0x181A27C20
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Dispose
	|
	|-RVA: 0x1A293C0 Offset: 0x1A279C0 VA: 0x181A293C0
	|-Enumerable.WhereSelectEnumerableIterator<object, float>.Dispose
	|
	|-RVA: 0x1A294E0 Offset: 0x1A27AE0 VA: 0x181A294E0
	|-Enumerable.WhereSelectEnumerableIterator<object, uint>.Dispose
	|
	|-RVA: 0x1A28E20 Offset: 0x1A27420 VA: 0x181A28E20
	|-Enumerable.WhereSelectEnumerableIterator<object, Resolution>.Dispose
	*/

	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C0C80 Offset: 0x19BF280 VA: 0x1819C0C80
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, FourBitNumber>.MoveNext
	|
	|-RVA: 0x19C1550 Offset: 0x19BFB50 VA: 0x1819C1550
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, SevenBitNumber>.MoveNext
	|
	|-RVA: 0x19C1930 Offset: 0x19BFF30 VA: 0x1819C1930
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, int>.MoveNext
	|
	|-RVA: 0x19C1AB0 Offset: 0x19C00B0 VA: 0x1819C1AB0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x19C07A0 Offset: 0x19BEDA0 VA: 0x1819C07A0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x19C12E0 Offset: 0x19BF8E0 VA: 0x1819C12E0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x19C21F0 Offset: 0x19C07F0 VA: 0x1819C21F0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Option>.MoveNext
	|
	|-RVA: 0x19C0E00 Offset: 0x19BF400 VA: 0x1819C0E00
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, InventoryItem>.MoveNext
	|
	|-RVA: 0x19C0A00 Offset: 0x19BF000 VA: 0x1819C0A00
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x19C0520 Offset: 0x19BEB20 VA: 0x1819C0520
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x19C1D20 Offset: 0x19C0320 VA: 0x1819C1D20
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, bool>.MoveNext
	|
	|-RVA: 0x19C1F80 Offset: 0x19C0580 VA: 0x1819C1F80
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x19C16D0 Offset: 0x19BFCD0 VA: 0x1819C16D0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, int>.MoveNext
	|
	|-RVA: 0x19C2470 Offset: 0x19C0A70 VA: 0x1819C2470
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Int32Enum>.MoveNext
	|
	|-RVA: 0x19C1080 Offset: 0x19BF680 VA: 0x1819C1080
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, long>.MoveNext
	|
	|-RVA: 0x19C26D0 Offset: 0x19C0CD0 VA: 0x1819C26D0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, object>.MoveNext
	|
	|-RVA: 0x1A24B80 Offset: 0x1A23180 VA: 0x181A24B80
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, float>.MoveNext
	|
	|-RVA: 0x1A1C280 Offset: 0x1A1A880 VA: 0x181A1C280
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Resolution>.MoveNext
	|
	|-RVA: 0x1A1EDA0 Offset: 0x1A1D3A0 VA: 0x181A1EDA0
	|-Enumerable.WhereSelectEnumerableIterator<WeightedStringList.Container, float>.MoveNext
	|
	|-RVA: 0x1A25510 Offset: 0x1A23B10 VA: 0x181A25510
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A22490 Offset: 0x1A20A90 VA: 0x181A22490
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A1B580 Offset: 0x1A19B80 VA: 0x181A1B580
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A210D0 Offset: 0x1A1F6D0 VA: 0x181A210D0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Option>.MoveNext
	|
	|-RVA: 0x1A1E7D0 Offset: 0x1A1CDD0 VA: 0x181A1E7D0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A230E0 Offset: 0x1A216E0 VA: 0x181A230E0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A244D0 Offset: 0x1A22AD0 VA: 0x181A244D0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A20EC0 Offset: 0x1A1F4C0 VA: 0x181A20EC0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, bool>.MoveNext
	|
	|-RVA: 0x1A23A80 Offset: 0x1A22080 VA: 0x181A23A80
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A1EB90 Offset: 0x1A1D190 VA: 0x181A1EB90
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, int>.MoveNext
	|
	|-RVA: 0x1A1EFB0 Offset: 0x1A1D5B0 VA: 0x181A1EFB0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A21A00 Offset: 0x1A20000 VA: 0x181A21A00
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, long>.MoveNext
	|
	|-RVA: 0x1A1C060 Offset: 0x1A1A660 VA: 0x181A1C060
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, object>.MoveNext
	|
	|-RVA: 0x1A24970 Offset: 0x1A22F70 VA: 0x181A24970
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, float>.MoveNext
	|
	|-RVA: 0x1A1FC70 Offset: 0x1A1E270 VA: 0x181A1FC70
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Resolution>.MoveNext
	|
	|-RVA: 0x1A22C40 Offset: 0x1A21240 VA: 0x181A22C40
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, FourBitNumber>.MoveNext
	|
	|-RVA: 0x1A24350 Offset: 0x1A22950 VA: 0x181A24350
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, SevenBitNumber>.MoveNext
	|
	|-RVA: 0x1A1F620 Offset: 0x1A1DC20 VA: 0x181A1F620
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, int>.MoveNext
	|
	|-RVA: 0x1A1AB00 Offset: 0x1A19100 VA: 0x181A1AB00
	|-Enumerable.WhereSelectEnumerableIterator<ProjectileWeaponMod.Modifier, float>.MoveNext
	|
	|-RVA: 0x1A226A0 Offset: 0x1A20CA0 VA: 0x181A226A0
	|-Enumerable.WhereSelectEnumerableIterator<Option, Option>.MoveNext
	|
	|-RVA: 0x1A1A130 Offset: 0x1A18730 VA: 0x181A1A130
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A1B000 Offset: 0x1A19600 VA: 0x181A1B000
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, FourBitNumber>.MoveNext
	|
	|-RVA: 0x1A262E0 Offset: 0x1A248E0 VA: 0x181A262E0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, SevenBitNumber>.MoveNext
	|
	|-RVA: 0x1A25DE0 Offset: 0x1A243E0 VA: 0x181A25DE0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A265A0 Offset: 0x1A24BA0 VA: 0x181A265A0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A20610 Offset: 0x1A1EC10 VA: 0x181A20610
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Option>.MoveNext
	|
	|-RVA: 0x1A1DCD0 Offset: 0x1A1C2D0 VA: 0x181A1DCD0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A1F340 Offset: 0x1A1D940 VA: 0x181A1F340
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A1AD20 Offset: 0x1A19320 VA: 0x181A1AD20
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A1B2C0 Offset: 0x1A198C0 VA: 0x181A1B2C0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, bool>.MoveNext
	|
	|-RVA: 0x1A1C810 Offset: 0x1A1AE10 VA: 0x181A1C810
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A1D4F0 Offset: 0x1A1BAF0 VA: 0x181A1D4F0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, int>.MoveNext
	|
	|-RVA: 0x1A258C0 Offset: 0x1A23EC0 VA: 0x181A258C0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A23E50 Offset: 0x1A22450 VA: 0x181A23E50
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, long>.MoveNext
	|
	|-RVA: 0x1A20A70 Offset: 0x1A1F070 VA: 0x181A20A70
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.MoveNext
	|
	|-RVA: 0x1A201D0 Offset: 0x1A1E7D0 VA: 0x181A201D0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, float>.MoveNext
	|
	|-RVA: 0x1A23320 Offset: 0x1A21920 VA: 0x181A23320
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Resolution>.MoveNext
	|
	|-RVA: 0x1A21490 Offset: 0x1A1FA90 VA: 0x181A21490
	|-Enumerable.WhereSelectEnumerableIterator<SkinnedMultiMesh.Part, long>.MoveNext
	|
	|-RVA: 0x1A22900 Offset: 0x1A20F00 VA: 0x181A22900
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A21DB0 Offset: 0x1A203B0 VA: 0x181A21DB0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A21300 Offset: 0x1A1F900 VA: 0x181A21300
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A1FE90 Offset: 0x1A1E490 VA: 0x181A1FE90
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Option>.MoveNext
	|
	|-RVA: 0x1A1F7A0 Offset: 0x1A1DDA0 VA: 0x181A1F7A0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A21C10 Offset: 0x1A20210 VA: 0x181A21C10
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A1CC60 Offset: 0x1A1B260 VA: 0x181A1CC60
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A25390 Offset: 0x1A23990 VA: 0x181A25390
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, bool>.MoveNext
	|
	|-RVA: 0x1A1C670 Offset: 0x1A1AC70 VA: 0x181A1C670
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A23900 Offset: 0x1A21F00 VA: 0x181A23900
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, int>.MoveNext
	|
	|-RVA: 0x1A1C4F0 Offset: 0x1A1AAF0 VA: 0x181A1C4F0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A22310 Offset: 0x1A20910 VA: 0x181A22310
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, long>.MoveNext
	|
	|-RVA: 0x1A1FAE0 Offset: 0x1A1E0E0 VA: 0x181A1FAE0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, object>.MoveNext
	|
	|-RVA: 0x1A19FA0 Offset: 0x1A185A0 VA: 0x181A19FA0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, float>.MoveNext
	|
	|-RVA: 0x1A216D0 Offset: 0x1A1FCD0 VA: 0x181A216D0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Resolution>.MoveNext
	|
	|-RVA: 0x1A1BB90 Offset: 0x1A1A190 VA: 0x181A1BB90
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A1F1C0 Offset: 0x1A1D7C0 VA: 0x181A1F1C0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A1CE00 Offset: 0x1A1B400 VA: 0x181A1CE00
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A23CB0 Offset: 0x1A222B0 VA: 0x181A23CB0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Option>.MoveNext
	|
	|-RVA: 0x1A1BD20 Offset: 0x1A1A320 VA: 0x181A1BD20
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A24E00 Offset: 0x1A23400 VA: 0x181A24E00
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A1BEC0 Offset: 0x1A1A4C0 VA: 0x181A1BEC0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A1E650 Offset: 0x1A1CC50 VA: 0x181A1E650
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, bool>.MoveNext
	|
	|-RVA: 0x1A1DFB0 Offset: 0x1A1C5B0 VA: 0x181A1DFB0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A1CF90 Offset: 0x1A1B590 VA: 0x181A1CF90
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, int>.MoveNext
	|
	|-RVA: 0x1A19E20 Offset: 0x1A18420 VA: 0x181A19E20
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A208F0 Offset: 0x1A1EEF0 VA: 0x181A208F0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, long>.MoveNext
	|
	|-RVA: 0x1A24FA0 Offset: 0x1A235A0 VA: 0x181A24FA0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, object>.MoveNext
	|
	|-RVA: 0x1A20490 Offset: 0x1A1EA90 VA: 0x181A20490
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, float>.MoveNext
	|
	|-RVA: 0x1A22DC0 Offset: 0x1A213C0 VA: 0x181A22DC0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Resolution>.MoveNext
	|
	|-RVA: 0x1A1A7D0 Offset: 0x1A18DD0 VA: 0x181A1A7D0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, ServerInfo>.MoveNext
	|
	|-RVA: 0x1A1E140 Offset: 0x1A1C740 VA: 0x181A1E140
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, int>.MoveNext
	|
	|-RVA: 0x1A1D7B0 Offset: 0x1A1BDB0 VA: 0x181A1D7B0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.MoveNext
	|
	|-RVA: 0x1A20030 Offset: 0x1A1E630 VA: 0x181A20030
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A25740 Offset: 0x1A23D40 VA: 0x181A25740
	|-Enumerable.WhereSelectEnumerableIterator<Friend, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A1A400 Offset: 0x1A18A00 VA: 0x181A1A400
	|-Enumerable.WhereSelectEnumerableIterator<Friend, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A22AA0 Offset: 0x1A210A0 VA: 0x181A22AA0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Option>.MoveNext
	|
	|-RVA: 0x1A1F940 Offset: 0x1A1DF40 VA: 0x181A1F940
	|-Enumerable.WhereSelectEnumerableIterator<Friend, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A1B7A0 Offset: 0x1A19DA0 VA: 0x181A1B7A0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A1D350 Offset: 0x1A1B950 VA: 0x181A1D350
	|-Enumerable.WhereSelectEnumerableIterator<Friend, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A23780 Offset: 0x1A21D80 VA: 0x181A23780
	|-Enumerable.WhereSelectEnumerableIterator<Friend, bool>.MoveNext
	|
	|-RVA: 0x1A21860 Offset: 0x1A1FE60 VA: 0x181A21860
	|-Enumerable.WhereSelectEnumerableIterator<Friend, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A21F30 Offset: 0x1A20530 VA: 0x181A21F30
	|-Enumerable.WhereSelectEnumerableIterator<Friend, int>.MoveNext
	|
	|-RVA: 0x1A20D40 Offset: 0x1A1F340 VA: 0x181A20D40
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A1CAE0 Offset: 0x1A1B0E0 VA: 0x181A1CAE0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, long>.MoveNext
	|
	|-RVA: 0x1A1EA00 Offset: 0x1A1D000 VA: 0x181A1EA00
	|-Enumerable.WhereSelectEnumerableIterator<Friend, object>.MoveNext
	|
	|-RVA: 0x1A235F0 Offset: 0x1A21BF0 VA: 0x181A235F0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, float>.MoveNext
	|
	|-RVA: 0x1A22F50 Offset: 0x1A21550 VA: 0x181A22F50
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Resolution>.MoveNext
	|
	|-RVA: 0x1A1DA80 Offset: 0x1A1C080 VA: 0x181A1DA80
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A1A590 Offset: 0x1A18B90 VA: 0x181A1A590
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, FourBitNumber>.MoveNext
	|
	|-RVA: 0x1A1D110 Offset: 0x1A1B710 VA: 0x181A1D110
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, SevenBitNumber>.MoveNext
	|
	|-RVA: 0x1A24110 Offset: 0x1A22710 VA: 0x181A24110
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A1B940 Offset: 0x1A19F40 VA: 0x181A1B940
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A25B80 Offset: 0x1A24180 VA: 0x181A25B80
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Option>.MoveNext
	|
	|-RVA: 0x1A19BE0 Offset: 0x1A181E0 VA: 0x181A19BE0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryItemId>.MoveNext
	|
	|-RVA: 0x1A220B0 Offset: 0x1A206B0 VA: 0x181A220B0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A25130 Offset: 0x1A23730 VA: 0x181A25130
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A24710 Offset: 0x1A22D10 VA: 0x181A24710
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A260A0 Offset: 0x1A246A0 VA: 0x181A260A0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, bool>.MoveNext
	|
	|-RVA: 0x1A1E400 Offset: 0x1A1CA00 VA: 0x181A1E400
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A2C540 Offset: 0x1A2AB40 VA: 0x181A2C540
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, int>.MoveNext
	|
	|-RVA: 0x1A32190 Offset: 0x1A30790 VA: 0x181A32190
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A2B7A0 Offset: 0x1A29DA0 VA: 0x181A2B7A0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, long>.MoveNext
	|
	|-RVA: 0x1A2B550 Offset: 0x1A29B50 VA: 0x181A2B550
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, object>.MoveNext
	|
	|-RVA: 0x1A325F0 Offset: 0x1A30BF0 VA: 0x181A325F0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, float>.MoveNext
	|
	|-RVA: 0x1A2AB90 Offset: 0x1A29190 VA: 0x181A2AB90
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, uint>.MoveNext
	|
	|-RVA: 0x1A34B80 Offset: 0x1A33180 VA: 0x181A34B80
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Resolution>.MoveNext
	|
	|-RVA: 0x1A2E220 Offset: 0x1A2C820 VA: 0x181A2E220
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem.Amount, InventoryItemId>.MoveNext
	|
	|-RVA: 0x1A33510 Offset: 0x1A31B10 VA: 0x181A33510
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem.Amount, uint>.MoveNext
	|
	|-RVA: 0x1A309B0 Offset: 0x1A2EFB0 VA: 0x181A309B0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe, PlayerItemRecipe>.MoveNext
	|
	|-RVA: 0x1A2A640 Offset: 0x1A28C40 VA: 0x181A2A640
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe, object>.MoveNext
	|
	|-RVA: 0x1A35020 Offset: 0x1A33620 VA: 0x181A35020
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A2DE50 Offset: 0x1A2C450 VA: 0x181A2DE50
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A35790 Offset: 0x1A33D90 VA: 0x181A35790
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A359C0 Offset: 0x1A33FC0 VA: 0x181A359C0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A30550 Offset: 0x1A2EB50 VA: 0x181A30550
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Option>.MoveNext
	|
	|-RVA: 0x1A33770 Offset: 0x1A31D70 VA: 0x181A33770
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A34DD0 Offset: 0x1A333D0 VA: 0x181A34DD0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A35E40 Offset: 0x1A34440 VA: 0x181A35E40
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A31980 Offset: 0x1A2FF80 VA: 0x181A31980
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, bool>.MoveNext
	|
	|-RVA: 0x1A32D90 Offset: 0x1A31390 VA: 0x181A32D90
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A32FD0 Offset: 0x1A315D0 VA: 0x181A32FD0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, int>.MoveNext
	|
	|-RVA: 0x1A34380 Offset: 0x1A32980 VA: 0x181A34380
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A31BB0 Offset: 0x1A301B0 VA: 0x181A31BB0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, long>.MoveNext
	|
	|-RVA: 0x1A339C0 Offset: 0x1A31FC0 VA: 0x181A339C0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, object>.MoveNext
	|
	|-RVA: 0x1A33F10 Offset: 0x1A32510 VA: 0x181A33F10
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, float>.MoveNext
	|
	|-RVA: 0x1A2FCA0 Offset: 0x1A2E2A0 VA: 0x181A2FCA0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Resolution>.MoveNext
	|
	|-RVA: 0x1A2C9B0 Offset: 0x1A2AFB0 VA: 0x181A2C9B0
	|-Enumerable.WhereSelectEnumerableIterator<DictionaryEntry, KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0x1A35260 Offset: 0x1A33860 VA: 0x181A35260
	|-Enumerable.WhereSelectEnumerableIterator<DictionaryEntry, object>.MoveNext
	|
	|-RVA: 0x1A34950 Offset: 0x1A32F50 VA: 0x181A34950
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A2D910 Offset: 0x1A2BF10 VA: 0x181A2D910
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A2E600 Offset: 0x1A2CC00 VA: 0x181A2E600
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A2C780 Offset: 0x1A2AD80 VA: 0x181A2C780
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Option>.MoveNext
	|
	|-RVA: 0x1A31DE0 Offset: 0x1A303E0 VA: 0x181A31DE0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A2A1C0 Offset: 0x1A287C0 VA: 0x181A2A1C0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A35C00 Offset: 0x1A34200 VA: 0x181A35C00
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A2EE80 Offset: 0x1A2D480 VA: 0x181A2EE80
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, bool>.MoveNext
	|
	|-RVA: 0x1A30320 Offset: 0x1A2E920 VA: 0x181A30320
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A2BD70 Offset: 0x1A2A370 VA: 0x181A2BD70
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, int>.MoveNext
	|
	|-RVA: 0x1A31080 Offset: 0x1A2F680 VA: 0x181A31080
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A2B9E0 Offset: 0x1A29FE0 VA: 0x181A2B9E0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, long>.MoveNext
	|
	|-RVA: 0x1A31290 Offset: 0x1A2F890 VA: 0x181A31290
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.MoveNext
	|
	|-RVA: 0x1A32840 Offset: 0x1A30E40 VA: 0x181A32840
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, float>.MoveNext
	|
	|-RVA: 0x1A2B330 Offset: 0x1A29930 VA: 0x181A2B330
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Resolution>.MoveNext
	|
	|-RVA: 0x1A2FEE0 Offset: 0x1A2E4E0 VA: 0x181A2FEE0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A2C330 Offset: 0x1A2A930 VA: 0x181A2C330
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A345B0 Offset: 0x1A32BB0 VA: 0x181A345B0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A2F3B0 Offset: 0x1A2D9B0 VA: 0x181A2F3B0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Option>.MoveNext
	|
	|-RVA: 0x1A2BF80 Offset: 0x1A2A580 VA: 0x181A2BF80
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A2A400 Offset: 0x1A28A00 VA: 0x181A2A400
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A2AF70 Offset: 0x1A29570 VA: 0x181A2AF70
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A307A0 Offset: 0x1A2EDA0 VA: 0x181A307A0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, bool>.MoveNext
	|
	|-RVA: 0x1A2D550 Offset: 0x1A2BB50 VA: 0x181A2D550
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A2CD80 Offset: 0x1A2B380 VA: 0x181A2CD80
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, int>.MoveNext
	|
	|-RVA: 0x1A30110 Offset: 0x1A2E710 VA: 0x181A30110
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A2D1A0 Offset: 0x1A2B7A0 VA: 0x181A2D1A0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, long>.MoveNext
	|
	|-RVA: 0x1A34160 Offset: 0x1A32760 VA: 0x181A34160
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, object>.MoveNext
	|
	|-RVA: 0x1A2F780 Offset: 0x1A2DD80 VA: 0x181A2F780
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, float>.MoveNext
	|
	|-RVA: 0x1A2CF90 Offset: 0x1A2B590 VA: 0x181A2CF90
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, uint>.MoveNext
	|
	|-RVA: 0x1A323D0 Offset: 0x1A309D0 VA: 0x181A323D0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Resolution>.MoveNext
	|
	|-RVA: 0x1A2AA10 Offset: 0x1A29010 VA: 0x181A2AA10
	|-Enumerable.WhereSelectEnumerableIterator<int, FourBitNumber>.MoveNext
	|
	|-RVA: 0x1A33200 Offset: 0x1A31800 VA: 0x181A33200
	|-Enumerable.WhereSelectEnumerableIterator<int, SevenBitNumber>.MoveNext
	|
	|-RVA: 0x1A30F00 Offset: 0x1A2F500 VA: 0x181A30F00
	|-Enumerable.WhereSelectEnumerableIterator<int, int>.MoveNext
	|
	|-RVA: 0x1A2F210 Offset: 0x1A2D810 VA: 0x181A2F210
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A2C1B0 Offset: 0x1A2A7B0 VA: 0x181A2C1B0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A33380 Offset: 0x1A31980 VA: 0x181A33380
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A2EB40 Offset: 0x1A2D140 VA: 0x181A2EB40
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Option>.MoveNext
	|
	|-RVA: 0x1A32BF0 Offset: 0x1A311F0 VA: 0x181A32BF0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A2CBE0 Offset: 0x1A2B1E0 VA: 0x181A2CBE0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A2E9A0 Offset: 0x1A2CFA0 VA: 0x181A2E9A0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A33C00 Offset: 0x1A32200 VA: 0x181A33C00
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, bool>.MoveNext
	|
	|-RVA: 0x1A317E0 Offset: 0x1A2FDE0 VA: 0x181A317E0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A2F090 Offset: 0x1A2D690 VA: 0x181A2F090
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, int>.MoveNext
	|
	|-RVA: 0x1A2BBF0 Offset: 0x1A2A1F0 VA: 0x181A2BBF0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A2B1B0 Offset: 0x1A297B0 VA: 0x181A2B1B0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, long>.MoveNext
	|
	|-RVA: 0x1A2D780 Offset: 0x1A2BD80 VA: 0x181A2D780
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.MoveNext
	|
	|-RVA: 0x1A35610 Offset: 0x1A33C10 VA: 0x181A35610
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, float>.MoveNext
	|
	|-RVA: 0x1A314B0 Offset: 0x1A2FAB0 VA: 0x181A314B0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Resolution>.MoveNext
	|
	|-RVA: 0x1A2A020 Offset: 0x1A28620 VA: 0x181A2A020
	|-Enumerable.WhereSelectEnumerableIterator<object, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A2E480 Offset: 0x1A2CA80 VA: 0x181A2E480
	|-Enumerable.WhereSelectEnumerableIterator<object, FourBitNumber>.MoveNext
	|
	|-RVA: 0x1A30BF0 Offset: 0x1A2F1F0 VA: 0x181A30BF0
	|-Enumerable.WhereSelectEnumerableIterator<object, SevenBitNumber>.MoveNext
	|
	|-RVA: 0x1A2DB20 Offset: 0x1A2C120 VA: 0x181A2DB20
	|-Enumerable.WhereSelectEnumerableIterator<object, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A2FB10 Offset: 0x1A2E110 VA: 0x181A2FB10
	|-Enumerable.WhereSelectEnumerableIterator<object, PlayerItemRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A2DCB0 Offset: 0x1A2C2B0 VA: 0x181A2DCB0
	|-Enumerable.WhereSelectEnumerableIterator<object, PlayerItemRecipe>.MoveNext
	|
	|-RVA: 0x1A2ADD0 Offset: 0x1A293D0 VA: 0x181A2ADD0
	|-Enumerable.WhereSelectEnumerableIterator<object, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A31640 Offset: 0x1A2FC40 VA: 0x181A31640
	|-Enumerable.WhereSelectEnumerableIterator<object, Option>.MoveNext
	|
	|-RVA: 0x1A33D80 Offset: 0x1A32380 VA: 0x181A33D80
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryItemId>.MoveNext
	|
	|-RVA: 0x1A2F5E0 Offset: 0x1A2DBE0 VA: 0x181A2F5E0
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A32A50 Offset: 0x1A31050 VA: 0x181A32A50
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A2E080 Offset: 0x1A2C680 VA: 0x181A2E080
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A2E820 Offset: 0x1A2CE20 VA: 0x181A2E820
	|-Enumerable.WhereSelectEnumerableIterator<object, bool>.MoveNext
	|
	|-RVA: 0x1A2ECE0 Offset: 0x1A2D2E0 VA: 0x181A2ECE0
	|-Enumerable.WhereSelectEnumerableIterator<object, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A32010 Offset: 0x1A30610 VA: 0x181A32010
	|-Enumerable.WhereSelectEnumerableIterator<object, int>.MoveNext
	|
	|-RVA: 0x1A347D0 Offset: 0x1A32DD0 VA: 0x181A347D0
	|-Enumerable.WhereSelectEnumerableIterator<object, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A30D70 Offset: 0x1A2F370 VA: 0x181A30D70
	|-Enumerable.WhereSelectEnumerableIterator<object, long>.MoveNext
	|
	|-RVA: 0x1A2A880 Offset: 0x1A28E80 VA: 0x181A2A880
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.MoveNext
	|
	|-RVA: 0x1A35480 Offset: 0x1A33A80 VA: 0x181A35480
	|-Enumerable.WhereSelectEnumerableIterator<object, float>.MoveNext
	|
	|-RVA: 0x1A2F990 Offset: 0x1A2DF90 VA: 0x181A2F990
	|-Enumerable.WhereSelectEnumerableIterator<object, uint>.MoveNext
	|
	|-RVA: 0x1A2D3B0 Offset: 0x1A2B9B0 VA: 0x181A2D3B0
	|-Enumerable.WhereSelectEnumerableIterator<object, Resolution>.MoveNext
	*/

	public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC8CFE0 Offset: 0xC8B5E0 VA: 0x180C8CFE0
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, int>.Select<FourBitNumber>
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, int>.Select<SevenBitNumber>
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, int>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, object>.Select<Option>
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, object>.Select<bool>
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, object>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, object>.Select<long>
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, object>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, object>.Select<float>
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, object>.Select<Resolution>
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, object>.Select<Option>
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, object>.Select<bool>
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, object>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, object>.Select<long>
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, object>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, object>.Select<float>
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, object>.Select<Resolution>
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, int>.Select<FourBitNumber>
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, int>.Select<SevenBitNumber>
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, int>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, int>.Select<FourBitNumber>
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, int>.Select<SevenBitNumber>
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, int>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.Select<Option>
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.Select<bool>
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.Select<long>
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.Select<float>
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.Select<Resolution>
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, object>.Select<Option>
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, object>.Select<bool>
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, object>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, object>.Select<long>
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, object>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, object>.Select<float>
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, object>.Select<Resolution>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, object>.Select<Option>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, object>.Select<bool>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, object>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, object>.Select<long>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, object>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, object>.Select<float>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, object>.Select<Resolution>
	|-Enumerable.WhereSelectEnumerableIterator<Friend, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectEnumerableIterator<Friend, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectEnumerableIterator<Friend, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectEnumerableIterator<Friend, object>.Select<Option>
	|-Enumerable.WhereSelectEnumerableIterator<Friend, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectEnumerableIterator<Friend, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectEnumerableIterator<Friend, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectEnumerableIterator<Friend, object>.Select<bool>
	|-Enumerable.WhereSelectEnumerableIterator<Friend, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectEnumerableIterator<Friend, object>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<Friend, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectEnumerableIterator<Friend, object>.Select<long>
	|-Enumerable.WhereSelectEnumerableIterator<Friend, object>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<Friend, object>.Select<float>
	|-Enumerable.WhereSelectEnumerableIterator<Friend, object>.Select<Resolution>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, int>.Select<FourBitNumber>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, int>.Select<SevenBitNumber>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, int>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, object>.Select<Option>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, object>.Select<bool>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, object>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, object>.Select<long>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, object>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, object>.Select<float>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, object>.Select<Resolution>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, object>.Select<Option>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, object>.Select<bool>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, object>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, object>.Select<long>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, object>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, object>.Select<float>
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, object>.Select<Resolution>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Select<Option>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Select<bool>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Select<long>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Select<float>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Select<Resolution>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, object>.Select<Option>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, object>.Select<bool>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, object>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, object>.Select<long>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, object>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, object>.Select<float>
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, object>.Select<Resolution>
	|-Enumerable.WhereSelectEnumerableIterator<int, int>.Select<FourBitNumber>
	|-Enumerable.WhereSelectEnumerableIterator<int, int>.Select<SevenBitNumber>
	|-Enumerable.WhereSelectEnumerableIterator<int, int>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Select<Option>
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Select<bool>
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Select<long>
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Select<float>
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Select<Resolution>
	|-Enumerable.WhereSelectEnumerableIterator<object, int>.Select<FourBitNumber>
	|-Enumerable.WhereSelectEnumerableIterator<object, int>.Select<SevenBitNumber>
	|-Enumerable.WhereSelectEnumerableIterator<object, int>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<object, Int32Enum>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<Option>
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<bool>
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<long>
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<float>
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<Resolution>
	|
	|-RVA: 0xC8D120 Offset: 0xC8B720 VA: 0x180C8D120
	|-Enumerable.WhereSelectEnumerableIterator<Option, Option>.Select<Option>
	|-Enumerable.WhereSelectEnumerableIterator<object, Option>.Select<Option>
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryItem>.Select<InventoryItemId>
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryItem>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryItem>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryItem>.Select<uint>
	|
	|-RVA: 0xC8D260 Offset: 0xC8B860 VA: 0x180C8D260
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, ServerInfo>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, ServerInfo>.Select<object>
	|
	|-RVA: 0xC8D1C0 Offset: 0xC8B7C0 VA: 0x180C8D1C0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe, PlayerItemRecipe>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<DictionaryEntry, KeyValuePair<object, object>>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<object, ProjectileWeaponMod.Modifier>.Select<float>
	|
	|-RVA: 0xC8D080 Offset: 0xC8B680 VA: 0x180C8D080
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryRecipe.Ingredient>.Select<PlayerItemRecipe.Ingredient>
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryRecipe.Ingredient>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryRecipe>.Select<PlayerItemRecipe>
	*/

	public override IEnumerable<TResult> Where(Func<TResult, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C2940 Offset: 0x19C0F40 VA: 0x1819C2940
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, FourBitNumber>.Where
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, SevenBitNumber>.Where
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, int>.Where
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, PathFinder.Point>.Where
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Option>.Where
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, InventoryItem>.Where
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, InventoryRecipe>.Where
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, bool>.Where
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, int>.Where
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Int32Enum>.Where
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, long>.Where
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, object>.Where
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, float>.Where
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Resolution>.Where
	|-Enumerable.WhereSelectEnumerableIterator<WeightedStringList.Container, float>.Where
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, PathFinder.Point>.Where
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Option>.Where
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, InventoryItem>.Where
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, InventoryRecipe>.Where
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, bool>.Where
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, int>.Where
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Int32Enum>.Where
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, long>.Where
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, object>.Where
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, float>.Where
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Resolution>.Where
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, FourBitNumber>.Where
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, SevenBitNumber>.Where
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, int>.Where
	|-Enumerable.WhereSelectEnumerableIterator<ProjectileWeaponMod.Modifier, float>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Option, Option>.Where
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, FourBitNumber>.Where
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, SevenBitNumber>.Where
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, PathFinder.Point>.Where
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Option>.Where
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, InventoryItem>.Where
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, InventoryRecipe>.Where
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, bool>.Where
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, int>.Where
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Int32Enum>.Where
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, long>.Where
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.Where
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, float>.Where
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Resolution>.Where
	|-Enumerable.WhereSelectEnumerableIterator<SkinnedMultiMesh.Part, long>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, PathFinder.Point>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Option>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, InventoryItem>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, InventoryRecipe>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, bool>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, int>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Int32Enum>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, long>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, object>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, float>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Resolution>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, PathFinder.Point>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Option>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, InventoryItem>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, InventoryRecipe>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, bool>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, int>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Int32Enum>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, long>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, object>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, float>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Resolution>.Where
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, ServerInfo>.Where
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, int>.Where
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Friend, PathFinder.Point>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Friend, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Option>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Friend, InventoryItem>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Friend, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Friend, InventoryRecipe>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Friend, bool>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Friend, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Friend, int>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Int32Enum>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Friend, long>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Friend, object>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Friend, float>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Resolution>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, FourBitNumber>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, SevenBitNumber>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, PathFinder.Point>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Option>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryItemId>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryItem>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryRecipe>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, bool>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, int>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Int32Enum>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, long>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, object>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, float>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, uint>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Resolution>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem.Amount, InventoryItemId>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem.Amount, uint>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe, PlayerItemRecipe>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe, object>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, PathFinder.Point>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Option>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, InventoryItem>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, InventoryRecipe>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, bool>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, int>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Int32Enum>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, long>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, object>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, float>.Where
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Resolution>.Where
	|-Enumerable.WhereSelectEnumerableIterator<DictionaryEntry, KeyValuePair<object, object>>.Where
	|-Enumerable.WhereSelectEnumerableIterator<DictionaryEntry, object>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, PathFinder.Point>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Option>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, InventoryItem>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, InventoryRecipe>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, bool>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, int>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Int32Enum>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, long>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, float>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Resolution>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, PathFinder.Point>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Option>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, InventoryItem>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, InventoryRecipe>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, bool>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, int>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Int32Enum>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, long>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, object>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, float>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, uint>.Where
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Resolution>.Where
	|-Enumerable.WhereSelectEnumerableIterator<int, FourBitNumber>.Where
	|-Enumerable.WhereSelectEnumerableIterator<int, SevenBitNumber>.Where
	|-Enumerable.WhereSelectEnumerableIterator<int, int>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, PathFinder.Point>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Option>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, InventoryItem>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, InventoryRecipe>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, bool>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, int>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Int32Enum>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, long>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, float>.Where
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Resolution>.Where
	|-Enumerable.WhereSelectEnumerableIterator<object, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectEnumerableIterator<object, FourBitNumber>.Where
	|-Enumerable.WhereSelectEnumerableIterator<object, SevenBitNumber>.Where
	|-Enumerable.WhereSelectEnumerableIterator<object, PathFinder.Point>.Where
	|-Enumerable.WhereSelectEnumerableIterator<object, PlayerItemRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectEnumerableIterator<object, PlayerItemRecipe>.Where
	|-Enumerable.WhereSelectEnumerableIterator<object, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectEnumerableIterator<object, Option>.Where
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryItemId>.Where
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryItem>.Where
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryRecipe>.Where
	|-Enumerable.WhereSelectEnumerableIterator<object, bool>.Where
	|-Enumerable.WhereSelectEnumerableIterator<object, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectEnumerableIterator<object, int>.Where
	|-Enumerable.WhereSelectEnumerableIterator<object, Int32Enum>.Where
	|-Enumerable.WhereSelectEnumerableIterator<object, long>.Where
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Where
	|-Enumerable.WhereSelectEnumerableIterator<object, float>.Where
	|-Enumerable.WhereSelectEnumerableIterator<object, uint>.Where
	|-Enumerable.WhereSelectEnumerableIterator<object, Resolution>.Where
	*/

}

private class Enumerable.WhereSelectArrayIterator<TSource, TResult> : Enumerable.Iterator<TResult> // TypeDefIndex: 3204
{	private TSource[] source; // 0x0
	private Func<TSource, bool> predicate; // 0x0
	private Func<TSource, TResult> selector; // 0x0
	private int index; // 0x0


	public void .ctor(TSource[] source, Func<TSource, bool> predicate, Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A8E20 Offset: 0x16A7420 VA: 0x1816A8E20
	|-Enumerable.WhereSelectArrayIterator<BurstCloth.Chain, FourBitNumber>..ctor
	|-Enumerable.WhereSelectArrayIterator<BurstCloth.Chain, SevenBitNumber>..ctor
	|-Enumerable.WhereSelectArrayIterator<BurstCloth.Chain, int>..ctor
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, bool>..ctor
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, int>..ctor
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, Int32Enum>..ctor
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, long>..ctor
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, object>..ctor
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, float>..ctor
	|-Enumerable.WhereSelectArrayIterator<WeightedStringList.Container, float>..ctor
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, bool>..ctor
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, int>..ctor
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, Int32Enum>..ctor
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, long>..ctor
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, object>..ctor
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, float>..ctor
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe.Ingredient, FourBitNumber>..ctor
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe.Ingredient, SevenBitNumber>..ctor
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe.Ingredient, int>..ctor
	|-Enumerable.WhereSelectArrayIterator<ProjectileWeaponMod.Modifier, float>..ctor
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, FourBitNumber>..ctor
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, SevenBitNumber>..ctor
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, bool>..ctor
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, int>..ctor
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, Int32Enum>..ctor
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, long>..ctor
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>..ctor
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, float>..ctor
	|-Enumerable.WhereSelectArrayIterator<SkinnedMultiMesh.Part, long>..ctor
	|-Enumerable.WhereSelectArrayIterator<Achievement, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectArrayIterator<Achievement, bool>..ctor
	|-Enumerable.WhereSelectArrayIterator<Achievement, int>..ctor
	|-Enumerable.WhereSelectArrayIterator<Achievement, Int32Enum>..ctor
	|-Enumerable.WhereSelectArrayIterator<Achievement, long>..ctor
	|-Enumerable.WhereSelectArrayIterator<Achievement, object>..ctor
	|-Enumerable.WhereSelectArrayIterator<Achievement, float>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, bool>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, int>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, Int32Enum>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, long>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, object>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, float>..ctor
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, int>..ctor
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>..ctor
	|-Enumerable.WhereSelectArrayIterator<Friend, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectArrayIterator<Friend, bool>..ctor
	|-Enumerable.WhereSelectArrayIterator<Friend, int>..ctor
	|-Enumerable.WhereSelectArrayIterator<Friend, Int32Enum>..ctor
	|-Enumerable.WhereSelectArrayIterator<Friend, long>..ctor
	|-Enumerable.WhereSelectArrayIterator<Friend, object>..ctor
	|-Enumerable.WhereSelectArrayIterator<Friend, float>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, FourBitNumber>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, SevenBitNumber>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, InventoryItemId>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, bool>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, int>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, Int32Enum>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, long>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, object>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, float>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, uint>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryItem.Amount, InventoryItemId>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryItem.Amount, uint>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe, object>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, bool>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, int>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, Int32Enum>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, long>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, object>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, float>..ctor
	|-Enumerable.WhereSelectArrayIterator<DictionaryEntry, object>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, bool>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, int>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Int32Enum>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, long>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, float>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, bool>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, int>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, Int32Enum>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, long>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, object>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, float>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, uint>..ctor
	|-Enumerable.WhereSelectArrayIterator<int, FourBitNumber>..ctor
	|-Enumerable.WhereSelectArrayIterator<int, SevenBitNumber>..ctor
	|-Enumerable.WhereSelectArrayIterator<int, int>..ctor
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, bool>..ctor
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, int>..ctor
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Int32Enum>..ctor
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, long>..ctor
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>..ctor
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, float>..ctor
	|-Enumerable.WhereSelectArrayIterator<object, FourBitNumber>..ctor
	|-Enumerable.WhereSelectArrayIterator<object, SevenBitNumber>..ctor
	|-Enumerable.WhereSelectArrayIterator<object, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectArrayIterator<object, PlayerItemRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectArrayIterator<object, InventoryItemId>..ctor
	|-Enumerable.WhereSelectArrayIterator<object, bool>..ctor
	|-Enumerable.WhereSelectArrayIterator<object, int>..ctor
	|-Enumerable.WhereSelectArrayIterator<object, Int32Enum>..ctor
	|-Enumerable.WhereSelectArrayIterator<object, long>..ctor
	|-Enumerable.WhereSelectArrayIterator<object, object>..ctor
	|-Enumerable.WhereSelectArrayIterator<object, float>..ctor
	|-Enumerable.WhereSelectArrayIterator<object, uint>..ctor
	|
	|-RVA: 0x16A8EB0 Offset: 0x16A74B0 VA: 0x1816A8EB0
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, Resolution>..ctor
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, Resolution>..ctor
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, Resolution>..ctor
	|-Enumerable.WhereSelectArrayIterator<Achievement, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectArrayIterator<Achievement, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectArrayIterator<Achievement, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectArrayIterator<Achievement, Resolution>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, Resolution>..ctor
	|-Enumerable.WhereSelectArrayIterator<Friend, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectArrayIterator<Friend, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectArrayIterator<Friend, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectArrayIterator<Friend, Resolution>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, Resolution>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe, PlayerItemRecipe>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, Resolution>..ctor
	|-Enumerable.WhereSelectArrayIterator<DictionaryEntry, KeyValuePair<object, object>>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Resolution>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, Resolution>..ctor
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Resolution>..ctor
	|-Enumerable.WhereSelectArrayIterator<object, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectArrayIterator<object, PlayerItemRecipe>..ctor
	|-Enumerable.WhereSelectArrayIterator<object, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectArrayIterator<object, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectArrayIterator<object, Resolution>..ctor
	|
	|-RVA: 0x16A8FD0 Offset: 0x16A75D0 VA: 0x1816A8FD0
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, Option>..ctor
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, InventoryItem>..ctor
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, Option>..ctor
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, InventoryItem>..ctor
	|-Enumerable.WhereSelectArrayIterator<Option, Option>..ctor
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, Option>..ctor
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, InventoryItem>..ctor
	|-Enumerable.WhereSelectArrayIterator<Achievement, Option>..ctor
	|-Enumerable.WhereSelectArrayIterator<Achievement, InventoryItem>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, Option>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, InventoryItem>..ctor
	|-Enumerable.WhereSelectArrayIterator<Friend, Option>..ctor
	|-Enumerable.WhereSelectArrayIterator<Friend, InventoryItem>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, Option>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, InventoryItem>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, Option>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, InventoryItem>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Option>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, InventoryItem>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, Option>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, InventoryItem>..ctor
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Option>..ctor
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, InventoryItem>..ctor
	|-Enumerable.WhereSelectArrayIterator<object, Option>..ctor
	|-Enumerable.WhereSelectArrayIterator<object, InventoryItem>..ctor
	|
	|-RVA: 0x16A8F40 Offset: 0x16A7540 VA: 0x1816A8F40
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectArrayIterator<Achievement, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectArrayIterator<Achievement, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectArrayIterator<Friend, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectArrayIterator<Friend, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectArrayIterator<object, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectArrayIterator<object, InventoryRecipe>..ctor
	|
	|-RVA: 0x16A9060 Offset: 0x16A7660 VA: 0x1816A9060
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, ServerInfo>..ctor
	*/

	public override Enumerable.Iterator<TResult> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A3D00 Offset: 0x16A2300 VA: 0x1816A3D00
	|-Enumerable.WhereSelectArrayIterator<BurstCloth.Chain, FourBitNumber>.Clone
	|-Enumerable.WhereSelectArrayIterator<BurstCloth.Chain, SevenBitNumber>.Clone
	|-Enumerable.WhereSelectArrayIterator<BurstCloth.Chain, int>.Clone
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, bool>.Clone
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, int>.Clone
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, Int32Enum>.Clone
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, long>.Clone
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, object>.Clone
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, float>.Clone
	|-Enumerable.WhereSelectArrayIterator<WeightedStringList.Container, float>.Clone
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, bool>.Clone
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, int>.Clone
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, Int32Enum>.Clone
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, long>.Clone
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, object>.Clone
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, float>.Clone
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe.Ingredient, FourBitNumber>.Clone
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe.Ingredient, SevenBitNumber>.Clone
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe.Ingredient, int>.Clone
	|-Enumerable.WhereSelectArrayIterator<ProjectileWeaponMod.Modifier, float>.Clone
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, FourBitNumber>.Clone
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, SevenBitNumber>.Clone
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, bool>.Clone
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, int>.Clone
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, Int32Enum>.Clone
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, long>.Clone
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>.Clone
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, float>.Clone
	|-Enumerable.WhereSelectArrayIterator<SkinnedMultiMesh.Part, long>.Clone
	|-Enumerable.WhereSelectArrayIterator<Achievement, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectArrayIterator<Achievement, bool>.Clone
	|-Enumerable.WhereSelectArrayIterator<Achievement, int>.Clone
	|-Enumerable.WhereSelectArrayIterator<Achievement, Int32Enum>.Clone
	|-Enumerable.WhereSelectArrayIterator<Achievement, long>.Clone
	|-Enumerable.WhereSelectArrayIterator<Achievement, object>.Clone
	|-Enumerable.WhereSelectArrayIterator<Achievement, float>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, bool>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, int>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, Int32Enum>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, long>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, object>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, float>.Clone
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, int>.Clone
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>.Clone
	|-Enumerable.WhereSelectArrayIterator<Friend, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectArrayIterator<Friend, bool>.Clone
	|-Enumerable.WhereSelectArrayIterator<Friend, int>.Clone
	|-Enumerable.WhereSelectArrayIterator<Friend, Int32Enum>.Clone
	|-Enumerable.WhereSelectArrayIterator<Friend, long>.Clone
	|-Enumerable.WhereSelectArrayIterator<Friend, object>.Clone
	|-Enumerable.WhereSelectArrayIterator<Friend, float>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, FourBitNumber>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, SevenBitNumber>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, InventoryItemId>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, bool>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, int>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, Int32Enum>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, long>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, object>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, float>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, uint>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryItem.Amount, InventoryItemId>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryItem.Amount, uint>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe, object>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, bool>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, int>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, Int32Enum>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, long>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, object>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, float>.Clone
	|-Enumerable.WhereSelectArrayIterator<DictionaryEntry, object>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, bool>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, int>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Int32Enum>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, long>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, float>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, bool>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, int>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, Int32Enum>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, long>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, object>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, float>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, uint>.Clone
	|-Enumerable.WhereSelectArrayIterator<int, FourBitNumber>.Clone
	|-Enumerable.WhereSelectArrayIterator<int, SevenBitNumber>.Clone
	|-Enumerable.WhereSelectArrayIterator<int, int>.Clone
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, bool>.Clone
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, int>.Clone
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Int32Enum>.Clone
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, long>.Clone
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Clone
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, float>.Clone
	|-Enumerable.WhereSelectArrayIterator<object, FourBitNumber>.Clone
	|-Enumerable.WhereSelectArrayIterator<object, SevenBitNumber>.Clone
	|-Enumerable.WhereSelectArrayIterator<object, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectArrayIterator<object, PlayerItemRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectArrayIterator<object, InventoryItemId>.Clone
	|-Enumerable.WhereSelectArrayIterator<object, bool>.Clone
	|-Enumerable.WhereSelectArrayIterator<object, int>.Clone
	|-Enumerable.WhereSelectArrayIterator<object, Int32Enum>.Clone
	|-Enumerable.WhereSelectArrayIterator<object, long>.Clone
	|-Enumerable.WhereSelectArrayIterator<object, object>.Clone
	|-Enumerable.WhereSelectArrayIterator<object, float>.Clone
	|-Enumerable.WhereSelectArrayIterator<object, uint>.Clone
	|
	|-RVA: 0x16A3BC0 Offset: 0x16A21C0 VA: 0x1816A3BC0
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, Resolution>.Clone
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, Resolution>.Clone
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, Resolution>.Clone
	|-Enumerable.WhereSelectArrayIterator<Achievement, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectArrayIterator<Achievement, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectArrayIterator<Achievement, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectArrayIterator<Achievement, Resolution>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, Resolution>.Clone
	|-Enumerable.WhereSelectArrayIterator<Friend, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectArrayIterator<Friend, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectArrayIterator<Friend, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectArrayIterator<Friend, Resolution>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, Resolution>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe, PlayerItemRecipe>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, Resolution>.Clone
	|-Enumerable.WhereSelectArrayIterator<DictionaryEntry, KeyValuePair<object, object>>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Resolution>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, Resolution>.Clone
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Resolution>.Clone
	|-Enumerable.WhereSelectArrayIterator<object, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectArrayIterator<object, PlayerItemRecipe>.Clone
	|-Enumerable.WhereSelectArrayIterator<object, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectArrayIterator<object, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectArrayIterator<object, Resolution>.Clone
	|
	|-RVA: 0x16A3C60 Offset: 0x16A2260 VA: 0x1816A3C60
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, Option>.Clone
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, InventoryItem>.Clone
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, Option>.Clone
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, InventoryItem>.Clone
	|-Enumerable.WhereSelectArrayIterator<Option, Option>.Clone
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, Option>.Clone
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, InventoryItem>.Clone
	|-Enumerable.WhereSelectArrayIterator<Achievement, Option>.Clone
	|-Enumerable.WhereSelectArrayIterator<Achievement, InventoryItem>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, Option>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, InventoryItem>.Clone
	|-Enumerable.WhereSelectArrayIterator<Friend, Option>.Clone
	|-Enumerable.WhereSelectArrayIterator<Friend, InventoryItem>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, Option>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, InventoryItem>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, Option>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, InventoryItem>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Option>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, InventoryItem>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, Option>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, InventoryItem>.Clone
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Option>.Clone
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, InventoryItem>.Clone
	|-Enumerable.WhereSelectArrayIterator<object, Option>.Clone
	|-Enumerable.WhereSelectArrayIterator<object, InventoryItem>.Clone
	|
	|-RVA: 0x16A3DA0 Offset: 0x16A23A0 VA: 0x1816A3DA0
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectArrayIterator<Achievement, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectArrayIterator<Achievement, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectArrayIterator<Friend, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectArrayIterator<Friend, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectArrayIterator<object, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectArrayIterator<object, InventoryRecipe>.Clone
	|
	|-RVA: 0x16A3E40 Offset: 0x16A2440 VA: 0x1816A3E40
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, ServerInfo>.Clone
	*/

	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A4320 Offset: 0x16A2920 VA: 0x1816A4320
	|-Enumerable.WhereSelectArrayIterator<BurstCloth.Chain, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<BurstCloth.Chain, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe.Ingredient, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe.Ingredient, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Achievement, bool>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, bool>.MoveNext
	|
	|-RVA: 0x16A4CB0 Offset: 0x16A32B0 VA: 0x1816A4CB0
	|-Enumerable.WhereSelectArrayIterator<BurstCloth.Chain, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe.Ingredient, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Achievement, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Achievement, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, Int32Enum>.MoveNext
	|
	|-RVA: 0x16A4400 Offset: 0x16A2A00 VA: 0x1816A4400
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x16A7E90 Offset: 0x16A6490 VA: 0x1816A7E90
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, long>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem.Amount, InventoryItemId>.MoveNext
	|
	|-RVA: 0x16A8C50 Offset: 0x16A7250 VA: 0x1816A8C50
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, Resolution>.MoveNext
	|
	|-RVA: 0x16A70A0 Offset: 0x16A56A0 VA: 0x1816A70A0
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, Option>.MoveNext
	|
	|-RVA: 0x16A5B60 Offset: 0x16A4160 VA: 0x1816A5B60
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, InventoryItem>.MoveNext
	|
	|-RVA: 0x16A7310 Offset: 0x16A5910 VA: 0x1816A7310
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x16A5900 Offset: 0x16A3F00 VA: 0x1816A5900
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x16A7B70 Offset: 0x16A6170 VA: 0x1816A7B70
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, bool>.MoveNext
	|
	|-RVA: 0x16A4550 Offset: 0x16A2B50 VA: 0x1816A4550
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem.Amount, uint>.MoveNext
	|
	|-RVA: 0x16A6A60 Offset: 0x16A5060 VA: 0x1816A6A60
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, object>.MoveNext
	|
	|-RVA: 0x16A89E0 Offset: 0x16A6FE0 VA: 0x1816A89E0
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, float>.MoveNext
	|
	|-RVA: 0x16A4FB0 Offset: 0x16A35B0 VA: 0x1816A4FB0
	|-Enumerable.WhereSelectArrayIterator<WeightedStringList.Container, float>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, float>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, float>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, float>.MoveNext
	|
	|-RVA: 0x16A76C0 Offset: 0x16A5CC0 VA: 0x1816A76C0
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, KeyValuePair<object, int>>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<DictionaryEntry, KeyValuePair<object, object>>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, KeyValuePair<object, int>>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x16A3EE0 Offset: 0x16A24E0 VA: 0x1816A3EE0
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, long>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, long>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, long>.MoveNext
	|
	|-RVA: 0x16A82E0 Offset: 0x16A68E0 VA: 0x1816A82E0
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, Resolution>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Resolution>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, Resolution>.MoveNext
	|
	|-RVA: 0x16A88C0 Offset: 0x16A6EC0 VA: 0x1816A88C0
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, Option>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Option>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, Option>.MoveNext
	|
	|-RVA: 0x16A6750 Offset: 0x16A4D50 VA: 0x1816A6750
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, InventoryItem>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, InventoryItem>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, InventoryItem>.MoveNext
	|
	|-RVA: 0x16A87A0 Offset: 0x16A6DA0 VA: 0x1816A87A0
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, InventoryRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, InventoryRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x16A6E80 Offset: 0x16A5480 VA: 0x1816A6E80
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, InventoryRecipe>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, InventoryRecipe>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x16A81E0 Offset: 0x16A67E0 VA: 0x1816A81E0
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, bool>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, bool>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, bool>.MoveNext
	|
	|-RVA: 0x16A6200 Offset: 0x16A4800 VA: 0x1816A6200
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, uint>.MoveNext
	|
	|-RVA: 0x16A6D70 Offset: 0x16A5370 VA: 0x1816A6D70
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, object>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<DictionaryEntry, object>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, object>.MoveNext
	|
	|-RVA: 0x16A7FD0 Offset: 0x16A65D0 VA: 0x1816A7FD0
	|-Enumerable.WhereSelectArrayIterator<ProjectileWeaponMod.Modifier, float>.MoveNext
	|
	|-RVA: 0x16A8B10 Offset: 0x16A7110 VA: 0x1816A8B10
	|-Enumerable.WhereSelectArrayIterator<Option, Option>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, Option>.MoveNext
	|
	|-RVA: 0x16A5290 Offset: 0x16A3890 VA: 0x1816A5290
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x16A4790 Offset: 0x16A2D90 VA: 0x1816A4790
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, bool>.MoveNext
	|
	|-RVA: 0x16A6300 Offset: 0x16A4900 VA: 0x1816A6300
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, long>.MoveNext
	|
	|-RVA: 0x16A6520 Offset: 0x16A4B20 VA: 0x1816A6520
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, Resolution>.MoveNext
	|
	|-RVA: 0x16A7480 Offset: 0x16A5A80 VA: 0x1816A7480
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, Option>.MoveNext
	|
	|-RVA: 0x16A5FC0 Offset: 0x16A45C0 VA: 0x1816A5FC0
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, InventoryItem>.MoveNext
	|
	|-RVA: 0x16A3FE0 Offset: 0x16A25E0 VA: 0x1816A3FE0
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x16A55D0 Offset: 0x16A3BD0 VA: 0x1816A55D0
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x16A4AA0 Offset: 0x16A30A0 VA: 0x1816A4AA0
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, int>.MoveNext
	|
	|-RVA: 0x16A4D90 Offset: 0x16A3390 VA: 0x1816A4D90
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>.MoveNext
	|
	|-RVA: 0x16A50B0 Offset: 0x16A36B0 VA: 0x1816A50B0
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, float>.MoveNext
	|
	|-RVA: 0x16A5DB0 Offset: 0x16A43B0 VA: 0x1816A5DB0
	|-Enumerable.WhereSelectArrayIterator<SkinnedMultiMesh.Part, long>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, InventoryItemId>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, long>.MoveNext
	|
	|-RVA: 0x16A5810 Offset: 0x16A3E10 VA: 0x1816A5810
	|-Enumerable.WhereSelectArrayIterator<Achievement, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Achievement, KeyValuePair<object, int>>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x16A6C90 Offset: 0x16A5290 VA: 0x1816A6C90
	|-Enumerable.WhereSelectArrayIterator<Achievement, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Achievement, long>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, long>.MoveNext
	|
	|-RVA: 0x16A7DA0 Offset: 0x16A63A0 VA: 0x1816A7DA0
	|-Enumerable.WhereSelectArrayIterator<Achievement, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Achievement, Resolution>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, Resolution>.MoveNext
	|
	|-RVA: 0x16A77D0 Offset: 0x16A5DD0 VA: 0x1816A77D0
	|-Enumerable.WhereSelectArrayIterator<Achievement, Option>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, Option>.MoveNext
	|
	|-RVA: 0x16A6870 Offset: 0x16A4E70 VA: 0x1816A6870
	|-Enumerable.WhereSelectArrayIterator<Achievement, InventoryItem>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, InventoryItem>.MoveNext
	|
	|-RVA: 0x16A7210 Offset: 0x16A5810 VA: 0x1816A7210
	|-Enumerable.WhereSelectArrayIterator<Achievement, InventoryRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x16A49A0 Offset: 0x16A2FA0 VA: 0x1816A49A0
	|-Enumerable.WhereSelectArrayIterator<Achievement, InventoryRecipe>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x16A7CB0 Offset: 0x16A62B0 VA: 0x1816A7CB0
	|-Enumerable.WhereSelectArrayIterator<Achievement, object>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, object>.MoveNext
	|
	|-RVA: 0x16A6BB0 Offset: 0x16A51B0 VA: 0x1816A6BB0
	|-Enumerable.WhereSelectArrayIterator<Achievement, float>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, float>.MoveNext
	|
	|-RVA: 0x16A5ED0 Offset: 0x16A44D0 VA: 0x1816A5ED0
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x16A7A90 Offset: 0x16A6090 VA: 0x1816A7A90
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, long>.MoveNext
	|
	|-RVA: 0x16A6970 Offset: 0x16A4F70 VA: 0x1816A6970
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, Resolution>.MoveNext
	|
	|-RVA: 0x16A6FA0 Offset: 0x16A55A0 VA: 0x1816A6FA0
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, Option>.MoveNext
	|
	|-RVA: 0x16A4220 Offset: 0x16A2820 VA: 0x1816A4220
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, InventoryItem>.MoveNext
	|
	|-RVA: 0x16A80E0 Offset: 0x16A66E0 VA: 0x1816A80E0
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x16A4690 Offset: 0x16A2C90 VA: 0x1816A4690
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x16A5CD0 Offset: 0x16A42D0 VA: 0x1816A5CD0
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, bool>.MoveNext
	|
	|-RVA: 0x16A79B0 Offset: 0x16A5FB0 VA: 0x1816A79B0
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, Int32Enum>.MoveNext
	|
	|-RVA: 0x16A5A70 Offset: 0x16A4070 VA: 0x1816A5A70
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, object>.MoveNext
	|
	|-RVA: 0x16A78D0 Offset: 0x16A5ED0 VA: 0x1816A78D0
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, float>.MoveNext
	|
	|-RVA: 0x16A8520 Offset: 0x16A6B20 VA: 0x1816A8520
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, ServerInfo>.MoveNext
	|
	|-RVA: 0x16A83F0 Offset: 0x16A69F0 VA: 0x1816A83F0
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x16A54C0 Offset: 0x16A3AC0 VA: 0x1816A54C0
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, bool>.MoveNext
	|
	|-RVA: 0x19BD5A0 Offset: 0x19BBBA0 VA: 0x1819BD5A0
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, Resolution>.MoveNext
	|
	|-RVA: 0x19BE550 Offset: 0x19BCB50 VA: 0x1819BE550
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, InventoryItem>.MoveNext
	|
	|-RVA: 0x19BF6B0 Offset: 0x19BDCB0 VA: 0x1819BF6B0
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x19BE070 Offset: 0x19BC670 VA: 0x1819BE070
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x19BF5A0 Offset: 0x19BDBA0 VA: 0x1819BF5A0
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, uint>.MoveNext
	|
	|-RVA: 0x19BFB00 Offset: 0x19BE100 VA: 0x1819BFB00
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, object>.MoveNext
	|
	|-RVA: 0x19BF8F0 Offset: 0x19BDEF0 VA: 0x1819BF8F0
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, float>.MoveNext
	|
	|-RVA: 0x19BDF40 Offset: 0x19BC540 VA: 0x1819BDF40
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe, PlayerItemRecipe>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x19BD380 Offset: 0x19BB980 VA: 0x1819BD380
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe, object>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, object>.MoveNext
	|
	|-RVA: 0x19BDA10 Offset: 0x19BC010 VA: 0x1819BDA10
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, long>.MoveNext
	|
	|-RVA: 0x19BD6D0 Offset: 0x19BBCD0 VA: 0x1819BD6D0
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, Resolution>.MoveNext
	|
	|-RVA: 0x19BEFC0 Offset: 0x19BD5C0 VA: 0x1819BEFC0
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, Option>.MoveNext
	|
	|-RVA: 0x19BDB30 Offset: 0x19BC130 VA: 0x1819BDB30
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, InventoryItem>.MoveNext
	|
	|-RVA: 0x19BEBC0 Offset: 0x19BD1C0 VA: 0x1819BEBC0
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x19BE690 Offset: 0x19BCC90 VA: 0x1819BE690
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x19BD8F0 Offset: 0x19BBEF0 VA: 0x1819BD8F0
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, bool>.MoveNext
	|
	|-RVA: 0x19BDC60 Offset: 0x19BC260 VA: 0x1819BDC60
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, Int32Enum>.MoveNext
	|
	|-RVA: 0x19BE8C0 Offset: 0x19BCEC0 VA: 0x1819BE8C0
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, float>.MoveNext
	|
	|-RVA: 0x19BECF0 Offset: 0x19BD2F0 VA: 0x1819BECF0
	|-Enumerable.WhereSelectArrayIterator<int, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<int, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, bool>.MoveNext
	|
	|-RVA: 0x19BD2A0 Offset: 0x19BB8A0 VA: 0x1819BD2A0
	|-Enumerable.WhereSelectArrayIterator<int, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Int32Enum>.MoveNext
	|
	|-RVA: 0x19BE290 Offset: 0x19BC890 VA: 0x1819BE290
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x19BE470 Offset: 0x19BCA70 VA: 0x1819BE470
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, long>.MoveNext
	|
	|-RVA: 0x19BE9D0 Offset: 0x19BCFD0 VA: 0x1819BE9D0
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Resolution>.MoveNext
	|
	|-RVA: 0x19BFA00 Offset: 0x19BE000 VA: 0x1819BFA00
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Option>.MoveNext
	|
	|-RVA: 0x19BF7F0 Offset: 0x19BDDF0 VA: 0x1819BF7F0
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, InventoryItem>.MoveNext
	|
	|-RVA: 0x19BEAC0 Offset: 0x19BD0C0 VA: 0x1819BEAC0
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x19BE7C0 Offset: 0x19BCDC0 VA: 0x1819BE7C0
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x19BE380 Offset: 0x19BC980 VA: 0x1819BE380
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.MoveNext
	|
	|-RVA: 0x19BDD80 Offset: 0x19BC380 VA: 0x1819BDD80
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, float>.MoveNext
	|
	|-RVA: 0x19BD800 Offset: 0x19BBE00 VA: 0x1819BD800
	|-Enumerable.WhereSelectArrayIterator<object, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, PlayerItemRecipe>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x19BE1B0 Offset: 0x19BC7B0 VA: 0x1819BE1B0
	|-Enumerable.WhereSelectArrayIterator<object, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, bool>.MoveNext
	|
	|-RVA: 0x19BDE60 Offset: 0x19BC460 VA: 0x1819BDE60
	|-Enumerable.WhereSelectArrayIterator<object, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, PlayerItemRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, InventoryItemId>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, long>.MoveNext
	|
	|-RVA: 0x19BF0F0 Offset: 0x19BD6F0 VA: 0x1819BF0F0
	|-Enumerable.WhereSelectArrayIterator<object, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, Resolution>.MoveNext
	|
	|-RVA: 0x19BF2C0 Offset: 0x19BD8C0 VA: 0x1819BF2C0
	|-Enumerable.WhereSelectArrayIterator<object, Option>.MoveNext
	|
	|-RVA: 0x19BF4A0 Offset: 0x19BDAA0 VA: 0x1819BF4A0
	|-Enumerable.WhereSelectArrayIterator<object, InventoryItem>.MoveNext
	|
	|-RVA: 0x19BEDD0 Offset: 0x19BD3D0 VA: 0x1819BEDD0
	|-Enumerable.WhereSelectArrayIterator<object, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x19BD4A0 Offset: 0x19BBAA0 VA: 0x1819BD4A0
	|-Enumerable.WhereSelectArrayIterator<object, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x19BF3C0 Offset: 0x19BD9C0 VA: 0x1819BF3C0
	|-Enumerable.WhereSelectArrayIterator<object, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, uint>.MoveNext
	|
	|-RVA: 0x19BEED0 Offset: 0x19BD4D0 VA: 0x1819BEED0
	|-Enumerable.WhereSelectArrayIterator<object, object>.MoveNext
	|
	|-RVA: 0x19BF1E0 Offset: 0x19BD7E0 VA: 0x1819BF1E0
	|-Enumerable.WhereSelectArrayIterator<object, float>.MoveNext
	*/

	public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC8CFE0 Offset: 0xC8B5E0 VA: 0x180C8CFE0
	|-Enumerable.WhereSelectArrayIterator<BurstCloth.Chain, int>.Select<FourBitNumber>
	|-Enumerable.WhereSelectArrayIterator<BurstCloth.Chain, int>.Select<SevenBitNumber>
	|-Enumerable.WhereSelectArrayIterator<BurstCloth.Chain, int>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, object>.Select<Option>
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, object>.Select<bool>
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, object>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, object>.Select<long>
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, object>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, object>.Select<float>
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, object>.Select<Resolution>
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, object>.Select<Option>
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, object>.Select<bool>
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, object>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, object>.Select<long>
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, object>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, object>.Select<float>
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, object>.Select<Resolution>
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe.Ingredient, int>.Select<FourBitNumber>
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe.Ingredient, int>.Select<SevenBitNumber>
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe.Ingredient, int>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, int>.Select<FourBitNumber>
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, int>.Select<SevenBitNumber>
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, int>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>.Select<Option>
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>.Select<bool>
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>.Select<long>
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>.Select<float>
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>.Select<Resolution>
	|-Enumerable.WhereSelectArrayIterator<Achievement, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectArrayIterator<Achievement, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectArrayIterator<Achievement, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectArrayIterator<Achievement, object>.Select<Option>
	|-Enumerable.WhereSelectArrayIterator<Achievement, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectArrayIterator<Achievement, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectArrayIterator<Achievement, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectArrayIterator<Achievement, object>.Select<bool>
	|-Enumerable.WhereSelectArrayIterator<Achievement, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectArrayIterator<Achievement, object>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<Achievement, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectArrayIterator<Achievement, object>.Select<long>
	|-Enumerable.WhereSelectArrayIterator<Achievement, object>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<Achievement, object>.Select<float>
	|-Enumerable.WhereSelectArrayIterator<Achievement, object>.Select<Resolution>
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, object>.Select<Option>
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, object>.Select<bool>
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, object>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, object>.Select<long>
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, object>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, object>.Select<float>
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, object>.Select<Resolution>
	|-Enumerable.WhereSelectArrayIterator<Friend, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectArrayIterator<Friend, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectArrayIterator<Friend, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectArrayIterator<Friend, object>.Select<Option>
	|-Enumerable.WhereSelectArrayIterator<Friend, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectArrayIterator<Friend, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectArrayIterator<Friend, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectArrayIterator<Friend, object>.Select<bool>
	|-Enumerable.WhereSelectArrayIterator<Friend, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectArrayIterator<Friend, object>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<Friend, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectArrayIterator<Friend, object>.Select<long>
	|-Enumerable.WhereSelectArrayIterator<Friend, object>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<Friend, object>.Select<float>
	|-Enumerable.WhereSelectArrayIterator<Friend, object>.Select<Resolution>
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, int>.Select<FourBitNumber>
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, int>.Select<SevenBitNumber>
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, int>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, object>.Select<Option>
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, object>.Select<bool>
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, object>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, object>.Select<long>
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, object>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, object>.Select<float>
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, object>.Select<Resolution>
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, object>.Select<Option>
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, object>.Select<bool>
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, object>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, object>.Select<long>
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, object>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, object>.Select<float>
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, object>.Select<Resolution>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Select<Option>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Select<bool>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Select<long>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Select<float>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Select<Resolution>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, object>.Select<Option>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, object>.Select<bool>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, object>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, object>.Select<long>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, object>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, object>.Select<float>
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, object>.Select<Resolution>
	|-Enumerable.WhereSelectArrayIterator<int, int>.Select<FourBitNumber>
	|-Enumerable.WhereSelectArrayIterator<int, int>.Select<SevenBitNumber>
	|-Enumerable.WhereSelectArrayIterator<int, int>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Select<Option>
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Select<bool>
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Select<long>
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Select<float>
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Select<Resolution>
	|-Enumerable.WhereSelectArrayIterator<object, int>.Select<FourBitNumber>
	|-Enumerable.WhereSelectArrayIterator<object, int>.Select<SevenBitNumber>
	|-Enumerable.WhereSelectArrayIterator<object, int>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<object, Int32Enum>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<Option>
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<bool>
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<long>
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<float>
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<Resolution>
	|
	|-RVA: 0xC8D120 Offset: 0xC8B720 VA: 0x180C8D120
	|-Enumerable.WhereSelectArrayIterator<Option, Option>.Select<Option>
	|-Enumerable.WhereSelectArrayIterator<object, Option>.Select<Option>
	|-Enumerable.WhereSelectArrayIterator<object, InventoryItem>.Select<InventoryItemId>
	|-Enumerable.WhereSelectArrayIterator<object, InventoryItem>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<object, InventoryItem>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<object, InventoryItem>.Select<uint>
	|
	|-RVA: 0xC8D260 Offset: 0xC8B860 VA: 0x180C8D260
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, ServerInfo>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, ServerInfo>.Select<object>
	|
	|-RVA: 0xC8D1C0 Offset: 0xC8B7C0 VA: 0x180C8D1C0
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe, PlayerItemRecipe>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<DictionaryEntry, KeyValuePair<object, object>>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<object, ProjectileWeaponMod.Modifier>.Select<float>
	|
	|-RVA: 0xC8D080 Offset: 0xC8B680 VA: 0x180C8D080
	|-Enumerable.WhereSelectArrayIterator<object, InventoryRecipe.Ingredient>.Select<PlayerItemRecipe.Ingredient>
	|-Enumerable.WhereSelectArrayIterator<object, InventoryRecipe.Ingredient>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<object, InventoryRecipe>.Select<PlayerItemRecipe>
	*/

	public override IEnumerable<TResult> Where(Func<TResult, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A8DA0 Offset: 0x16A73A0 VA: 0x1816A8DA0
	|-Enumerable.WhereSelectArrayIterator<BurstCloth.Chain, FourBitNumber>.Where
	|-Enumerable.WhereSelectArrayIterator<BurstCloth.Chain, SevenBitNumber>.Where
	|-Enumerable.WhereSelectArrayIterator<BurstCloth.Chain, int>.Where
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, PathFinder.Point>.Where
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, Option>.Where
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, InventoryItem>.Where
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, InventoryRecipe>.Where
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, bool>.Where
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, int>.Where
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, Int32Enum>.Where
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, long>.Where
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, object>.Where
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, float>.Where
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, Resolution>.Where
	|-Enumerable.WhereSelectArrayIterator<WeightedStringList.Container, float>.Where
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, PathFinder.Point>.Where
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, Option>.Where
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, InventoryItem>.Where
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, InventoryRecipe>.Where
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, bool>.Where
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, int>.Where
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, Int32Enum>.Where
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, long>.Where
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, object>.Where
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, float>.Where
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, Resolution>.Where
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe.Ingredient, FourBitNumber>.Where
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe.Ingredient, SevenBitNumber>.Where
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe.Ingredient, int>.Where
	|-Enumerable.WhereSelectArrayIterator<ProjectileWeaponMod.Modifier, float>.Where
	|-Enumerable.WhereSelectArrayIterator<Option, Option>.Where
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, FourBitNumber>.Where
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, SevenBitNumber>.Where
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, PathFinder.Point>.Where
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, Option>.Where
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, InventoryItem>.Where
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, InventoryRecipe>.Where
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, bool>.Where
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, int>.Where
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, Int32Enum>.Where
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, long>.Where
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>.Where
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, float>.Where
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, Resolution>.Where
	|-Enumerable.WhereSelectArrayIterator<SkinnedMultiMesh.Part, long>.Where
	|-Enumerable.WhereSelectArrayIterator<Achievement, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectArrayIterator<Achievement, PathFinder.Point>.Where
	|-Enumerable.WhereSelectArrayIterator<Achievement, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectArrayIterator<Achievement, Option>.Where
	|-Enumerable.WhereSelectArrayIterator<Achievement, InventoryItem>.Where
	|-Enumerable.WhereSelectArrayIterator<Achievement, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectArrayIterator<Achievement, InventoryRecipe>.Where
	|-Enumerable.WhereSelectArrayIterator<Achievement, bool>.Where
	|-Enumerable.WhereSelectArrayIterator<Achievement, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectArrayIterator<Achievement, int>.Where
	|-Enumerable.WhereSelectArrayIterator<Achievement, Int32Enum>.Where
	|-Enumerable.WhereSelectArrayIterator<Achievement, long>.Where
	|-Enumerable.WhereSelectArrayIterator<Achievement, object>.Where
	|-Enumerable.WhereSelectArrayIterator<Achievement, float>.Where
	|-Enumerable.WhereSelectArrayIterator<Achievement, Resolution>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, PathFinder.Point>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, Option>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, InventoryItem>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, InventoryRecipe>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, bool>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, int>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, Int32Enum>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, long>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, object>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, float>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, Resolution>.Where
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, ServerInfo>.Where
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, int>.Where
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>.Where
	|-Enumerable.WhereSelectArrayIterator<Friend, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectArrayIterator<Friend, PathFinder.Point>.Where
	|-Enumerable.WhereSelectArrayIterator<Friend, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectArrayIterator<Friend, Option>.Where
	|-Enumerable.WhereSelectArrayIterator<Friend, InventoryItem>.Where
	|-Enumerable.WhereSelectArrayIterator<Friend, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectArrayIterator<Friend, InventoryRecipe>.Where
	|-Enumerable.WhereSelectArrayIterator<Friend, bool>.Where
	|-Enumerable.WhereSelectArrayIterator<Friend, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectArrayIterator<Friend, int>.Where
	|-Enumerable.WhereSelectArrayIterator<Friend, Int32Enum>.Where
	|-Enumerable.WhereSelectArrayIterator<Friend, long>.Where
	|-Enumerable.WhereSelectArrayIterator<Friend, object>.Where
	|-Enumerable.WhereSelectArrayIterator<Friend, float>.Where
	|-Enumerable.WhereSelectArrayIterator<Friend, Resolution>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, FourBitNumber>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, SevenBitNumber>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, PathFinder.Point>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, Option>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, InventoryItemId>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, InventoryItem>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, InventoryRecipe>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, bool>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, int>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, Int32Enum>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, long>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, object>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, float>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, uint>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, Resolution>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryItem.Amount, InventoryItemId>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryItem.Amount, uint>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe, PlayerItemRecipe>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe, object>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, PathFinder.Point>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, Option>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, InventoryItem>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, InventoryRecipe>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, bool>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, int>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, Int32Enum>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, long>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, object>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, float>.Where
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, Resolution>.Where
	|-Enumerable.WhereSelectArrayIterator<DictionaryEntry, KeyValuePair<object, object>>.Where
	|-Enumerable.WhereSelectArrayIterator<DictionaryEntry, object>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, PathFinder.Point>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Option>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, InventoryItem>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, InventoryRecipe>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, bool>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, int>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Int32Enum>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, long>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, float>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Resolution>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, PathFinder.Point>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, Option>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, InventoryItem>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, InventoryRecipe>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, bool>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, int>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, Int32Enum>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, long>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, object>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, float>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, uint>.Where
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, Resolution>.Where
	|-Enumerable.WhereSelectArrayIterator<int, FourBitNumber>.Where
	|-Enumerable.WhereSelectArrayIterator<int, SevenBitNumber>.Where
	|-Enumerable.WhereSelectArrayIterator<int, int>.Where
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, PathFinder.Point>.Where
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Option>.Where
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, InventoryItem>.Where
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, InventoryRecipe>.Where
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, bool>.Where
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, int>.Where
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Int32Enum>.Where
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, long>.Where
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.Where
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, float>.Where
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Resolution>.Where
	|-Enumerable.WhereSelectArrayIterator<object, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectArrayIterator<object, FourBitNumber>.Where
	|-Enumerable.WhereSelectArrayIterator<object, SevenBitNumber>.Where
	|-Enumerable.WhereSelectArrayIterator<object, PathFinder.Point>.Where
	|-Enumerable.WhereSelectArrayIterator<object, PlayerItemRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectArrayIterator<object, PlayerItemRecipe>.Where
	|-Enumerable.WhereSelectArrayIterator<object, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectArrayIterator<object, Option>.Where
	|-Enumerable.WhereSelectArrayIterator<object, InventoryItemId>.Where
	|-Enumerable.WhereSelectArrayIterator<object, InventoryItem>.Where
	|-Enumerable.WhereSelectArrayIterator<object, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectArrayIterator<object, InventoryRecipe>.Where
	|-Enumerable.WhereSelectArrayIterator<object, bool>.Where
	|-Enumerable.WhereSelectArrayIterator<object, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectArrayIterator<object, int>.Where
	|-Enumerable.WhereSelectArrayIterator<object, Int32Enum>.Where
	|-Enumerable.WhereSelectArrayIterator<object, long>.Where
	|-Enumerable.WhereSelectArrayIterator<object, object>.Where
	|-Enumerable.WhereSelectArrayIterator<object, float>.Where
	|-Enumerable.WhereSelectArrayIterator<object, uint>.Where
	|-Enumerable.WhereSelectArrayIterator<object, Resolution>.Where
	*/

}

private class Enumerable.WhereSelectListIterator<TSource, TResult> : Enumerable.Iterator<TResult> // TypeDefIndex: 3205
{	private List<TSource> source; // 0x0
	private Func<TSource, bool> predicate; // 0x0
	private Func<TSource, TResult> selector; // 0x0
	private List.Enumerator<TSource> enumerator; // 0x0


	public void .ctor(List<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A8E20 Offset: 0x16A7420 VA: 0x1816A8E20
	|-Enumerable.WhereSelectListIterator<BurstCloth.Chain, FourBitNumber>..ctor
	|-Enumerable.WhereSelectListIterator<BurstCloth.Chain, SevenBitNumber>..ctor
	|-Enumerable.WhereSelectListIterator<BurstCloth.Chain, int>..ctor
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, bool>..ctor
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, int>..ctor
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, Int32Enum>..ctor
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, long>..ctor
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, object>..ctor
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, float>..ctor
	|-Enumerable.WhereSelectListIterator<WeightedStringList.Container, float>..ctor
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, bool>..ctor
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, int>..ctor
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, Int32Enum>..ctor
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, long>..ctor
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, object>..ctor
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, float>..ctor
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe.Ingredient, FourBitNumber>..ctor
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe.Ingredient, SevenBitNumber>..ctor
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe.Ingredient, int>..ctor
	|-Enumerable.WhereSelectListIterator<ProjectileWeaponMod.Modifier, float>..ctor
	|-Enumerable.WhereSelectListIterator<ServerInfo, FourBitNumber>..ctor
	|-Enumerable.WhereSelectListIterator<ServerInfo, SevenBitNumber>..ctor
	|-Enumerable.WhereSelectListIterator<ServerInfo, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectListIterator<ServerInfo, bool>..ctor
	|-Enumerable.WhereSelectListIterator<ServerInfo, int>..ctor
	|-Enumerable.WhereSelectListIterator<ServerInfo, Int32Enum>..ctor
	|-Enumerable.WhereSelectListIterator<ServerInfo, long>..ctor
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>..ctor
	|-Enumerable.WhereSelectListIterator<ServerInfo, float>..ctor
	|-Enumerable.WhereSelectListIterator<SkinnedMultiMesh.Part, long>..ctor
	|-Enumerable.WhereSelectListIterator<Achievement, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectListIterator<Achievement, bool>..ctor
	|-Enumerable.WhereSelectListIterator<Achievement, int>..ctor
	|-Enumerable.WhereSelectListIterator<Achievement, Int32Enum>..ctor
	|-Enumerable.WhereSelectListIterator<Achievement, long>..ctor
	|-Enumerable.WhereSelectListIterator<Achievement, object>..ctor
	|-Enumerable.WhereSelectListIterator<Achievement, float>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryDefId, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryDefId, bool>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryDefId, int>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryDefId, Int32Enum>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryDefId, long>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryDefId, object>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryDefId, float>..ctor
	|-Enumerable.WhereSelectListIterator<ServerInfo, int>..ctor
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>..ctor
	|-Enumerable.WhereSelectListIterator<Friend, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectListIterator<Friend, bool>..ctor
	|-Enumerable.WhereSelectListIterator<Friend, int>..ctor
	|-Enumerable.WhereSelectListIterator<Friend, Int32Enum>..ctor
	|-Enumerable.WhereSelectListIterator<Friend, long>..ctor
	|-Enumerable.WhereSelectListIterator<Friend, object>..ctor
	|-Enumerable.WhereSelectListIterator<Friend, float>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryItem, FourBitNumber>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryItem, SevenBitNumber>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryItem, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryItem, InventoryItemId>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryItem, bool>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryItem, int>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryItem, Int32Enum>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryItem, long>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryItem, object>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryItem, float>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryItem, uint>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryItem.Amount, InventoryItemId>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryItem.Amount, uint>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryRecipe, object>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, bool>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, int>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, Int32Enum>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, long>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, object>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, float>..ctor
	|-Enumerable.WhereSelectListIterator<DictionaryEntry, object>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, bool>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, int>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Int32Enum>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, long>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, float>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, bool>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, int>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, Int32Enum>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, long>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, object>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, float>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, uint>..ctor
	|-Enumerable.WhereSelectListIterator<int, FourBitNumber>..ctor
	|-Enumerable.WhereSelectListIterator<int, SevenBitNumber>..ctor
	|-Enumerable.WhereSelectListIterator<int, int>..ctor
	|-Enumerable.WhereSelectListIterator<Int32Enum, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectListIterator<Int32Enum, bool>..ctor
	|-Enumerable.WhereSelectListIterator<Int32Enum, int>..ctor
	|-Enumerable.WhereSelectListIterator<Int32Enum, Int32Enum>..ctor
	|-Enumerable.WhereSelectListIterator<Int32Enum, long>..ctor
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>..ctor
	|-Enumerable.WhereSelectListIterator<Int32Enum, float>..ctor
	|-Enumerable.WhereSelectListIterator<object, FourBitNumber>..ctor
	|-Enumerable.WhereSelectListIterator<object, SevenBitNumber>..ctor
	|-Enumerable.WhereSelectListIterator<object, PathFinder.Point>..ctor
	|-Enumerable.WhereSelectListIterator<object, PlayerItemRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectListIterator<object, InventoryItemId>..ctor
	|-Enumerable.WhereSelectListIterator<object, bool>..ctor
	|-Enumerable.WhereSelectListIterator<object, int>..ctor
	|-Enumerable.WhereSelectListIterator<object, Int32Enum>..ctor
	|-Enumerable.WhereSelectListIterator<object, long>..ctor
	|-Enumerable.WhereSelectListIterator<object, object>..ctor
	|-Enumerable.WhereSelectListIterator<object, float>..ctor
	|-Enumerable.WhereSelectListIterator<object, uint>..ctor
	|
	|-RVA: 0x16A8EB0 Offset: 0x16A74B0 VA: 0x1816A8EB0
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, Resolution>..ctor
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, Resolution>..ctor
	|-Enumerable.WhereSelectListIterator<ServerInfo, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectListIterator<ServerInfo, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectListIterator<ServerInfo, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectListIterator<ServerInfo, Resolution>..ctor
	|-Enumerable.WhereSelectListIterator<Achievement, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectListIterator<Achievement, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectListIterator<Achievement, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectListIterator<Achievement, Resolution>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryDefId, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryDefId, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryDefId, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryDefId, Resolution>..ctor
	|-Enumerable.WhereSelectListIterator<Friend, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectListIterator<Friend, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectListIterator<Friend, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectListIterator<Friend, Resolution>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryItem, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryItem, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryItem, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryItem, Resolution>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryRecipe, PlayerItemRecipe>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, Resolution>..ctor
	|-Enumerable.WhereSelectListIterator<DictionaryEntry, KeyValuePair<object, object>>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Resolution>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, Resolution>..ctor
	|-Enumerable.WhereSelectListIterator<Int32Enum, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectListIterator<Int32Enum, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectListIterator<Int32Enum, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectListIterator<Int32Enum, Resolution>..ctor
	|-Enumerable.WhereSelectListIterator<object, Debugging.EntityInfo>..ctor
	|-Enumerable.WhereSelectListIterator<object, PlayerItemRecipe>..ctor
	|-Enumerable.WhereSelectListIterator<object, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereSelectListIterator<object, KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereSelectListIterator<object, Resolution>..ctor
	|
	|-RVA: 0x16A8FD0 Offset: 0x16A75D0 VA: 0x1816A8FD0
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, Option>..ctor
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, InventoryItem>..ctor
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, Option>..ctor
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, InventoryItem>..ctor
	|-Enumerable.WhereSelectListIterator<Option, Option>..ctor
	|-Enumerable.WhereSelectListIterator<ServerInfo, Option>..ctor
	|-Enumerable.WhereSelectListIterator<ServerInfo, InventoryItem>..ctor
	|-Enumerable.WhereSelectListIterator<Achievement, Option>..ctor
	|-Enumerable.WhereSelectListIterator<Achievement, InventoryItem>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryDefId, Option>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryDefId, InventoryItem>..ctor
	|-Enumerable.WhereSelectListIterator<Friend, Option>..ctor
	|-Enumerable.WhereSelectListIterator<Friend, InventoryItem>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryItem, Option>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryItem, InventoryItem>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, Option>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, InventoryItem>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Option>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, InventoryItem>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, Option>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, InventoryItem>..ctor
	|-Enumerable.WhereSelectListIterator<Int32Enum, Option>..ctor
	|-Enumerable.WhereSelectListIterator<Int32Enum, InventoryItem>..ctor
	|-Enumerable.WhereSelectListIterator<object, Option>..ctor
	|-Enumerable.WhereSelectListIterator<object, InventoryItem>..ctor
	|
	|-RVA: 0x16A8F40 Offset: 0x16A7540 VA: 0x1816A8F40
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectListIterator<ServerInfo, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectListIterator<ServerInfo, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectListIterator<Achievement, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectListIterator<Achievement, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryDefId, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryDefId, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectListIterator<Friend, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectListIterator<Friend, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryItem, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryItem, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectListIterator<Int32Enum, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectListIterator<Int32Enum, InventoryRecipe>..ctor
	|-Enumerable.WhereSelectListIterator<object, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereSelectListIterator<object, InventoryRecipe>..ctor
	|
	|-RVA: 0x16A9060 Offset: 0x16A7660 VA: 0x1816A9060
	|-Enumerable.WhereSelectListIterator<ServerInfo, ServerInfo>..ctor
	*/

	public override Enumerable.Iterator<TResult> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A3D00 Offset: 0x16A2300 VA: 0x1816A3D00
	|-Enumerable.WhereSelectListIterator<BurstCloth.Chain, FourBitNumber>.Clone
	|-Enumerable.WhereSelectListIterator<BurstCloth.Chain, SevenBitNumber>.Clone
	|-Enumerable.WhereSelectListIterator<BurstCloth.Chain, int>.Clone
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, bool>.Clone
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, int>.Clone
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, Int32Enum>.Clone
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, long>.Clone
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, object>.Clone
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, float>.Clone
	|-Enumerable.WhereSelectListIterator<WeightedStringList.Container, float>.Clone
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, bool>.Clone
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, int>.Clone
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, Int32Enum>.Clone
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, long>.Clone
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, object>.Clone
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, float>.Clone
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe.Ingredient, FourBitNumber>.Clone
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe.Ingredient, SevenBitNumber>.Clone
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe.Ingredient, int>.Clone
	|-Enumerable.WhereSelectListIterator<ProjectileWeaponMod.Modifier, float>.Clone
	|-Enumerable.WhereSelectListIterator<ServerInfo, FourBitNumber>.Clone
	|-Enumerable.WhereSelectListIterator<ServerInfo, SevenBitNumber>.Clone
	|-Enumerable.WhereSelectListIterator<ServerInfo, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectListIterator<ServerInfo, bool>.Clone
	|-Enumerable.WhereSelectListIterator<ServerInfo, int>.Clone
	|-Enumerable.WhereSelectListIterator<ServerInfo, Int32Enum>.Clone
	|-Enumerable.WhereSelectListIterator<ServerInfo, long>.Clone
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>.Clone
	|-Enumerable.WhereSelectListIterator<ServerInfo, float>.Clone
	|-Enumerable.WhereSelectListIterator<SkinnedMultiMesh.Part, long>.Clone
	|-Enumerable.WhereSelectListIterator<Achievement, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectListIterator<Achievement, bool>.Clone
	|-Enumerable.WhereSelectListIterator<Achievement, int>.Clone
	|-Enumerable.WhereSelectListIterator<Achievement, Int32Enum>.Clone
	|-Enumerable.WhereSelectListIterator<Achievement, long>.Clone
	|-Enumerable.WhereSelectListIterator<Achievement, object>.Clone
	|-Enumerable.WhereSelectListIterator<Achievement, float>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryDefId, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryDefId, bool>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryDefId, int>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryDefId, Int32Enum>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryDefId, long>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryDefId, object>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryDefId, float>.Clone
	|-Enumerable.WhereSelectListIterator<ServerInfo, int>.Clone
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>.Clone
	|-Enumerable.WhereSelectListIterator<Friend, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectListIterator<Friend, bool>.Clone
	|-Enumerable.WhereSelectListIterator<Friend, int>.Clone
	|-Enumerable.WhereSelectListIterator<Friend, Int32Enum>.Clone
	|-Enumerable.WhereSelectListIterator<Friend, long>.Clone
	|-Enumerable.WhereSelectListIterator<Friend, object>.Clone
	|-Enumerable.WhereSelectListIterator<Friend, float>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryItem, FourBitNumber>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryItem, SevenBitNumber>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryItem, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryItem, InventoryItemId>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryItem, bool>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryItem, int>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryItem, Int32Enum>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryItem, long>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryItem, object>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryItem, float>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryItem, uint>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryItem.Amount, InventoryItemId>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryItem.Amount, uint>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryRecipe, object>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, bool>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, int>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, Int32Enum>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, long>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, object>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, float>.Clone
	|-Enumerable.WhereSelectListIterator<DictionaryEntry, object>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, bool>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, int>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Int32Enum>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, long>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, float>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, bool>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, int>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, Int32Enum>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, long>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, object>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, float>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, uint>.Clone
	|-Enumerable.WhereSelectListIterator<int, FourBitNumber>.Clone
	|-Enumerable.WhereSelectListIterator<int, SevenBitNumber>.Clone
	|-Enumerable.WhereSelectListIterator<int, int>.Clone
	|-Enumerable.WhereSelectListIterator<Int32Enum, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectListIterator<Int32Enum, bool>.Clone
	|-Enumerable.WhereSelectListIterator<Int32Enum, int>.Clone
	|-Enumerable.WhereSelectListIterator<Int32Enum, Int32Enum>.Clone
	|-Enumerable.WhereSelectListIterator<Int32Enum, long>.Clone
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Clone
	|-Enumerable.WhereSelectListIterator<Int32Enum, float>.Clone
	|-Enumerable.WhereSelectListIterator<object, FourBitNumber>.Clone
	|-Enumerable.WhereSelectListIterator<object, SevenBitNumber>.Clone
	|-Enumerable.WhereSelectListIterator<object, PathFinder.Point>.Clone
	|-Enumerable.WhereSelectListIterator<object, PlayerItemRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectListIterator<object, InventoryItemId>.Clone
	|-Enumerable.WhereSelectListIterator<object, bool>.Clone
	|-Enumerable.WhereSelectListIterator<object, int>.Clone
	|-Enumerable.WhereSelectListIterator<object, Int32Enum>.Clone
	|-Enumerable.WhereSelectListIterator<object, long>.Clone
	|-Enumerable.WhereSelectListIterator<object, object>.Clone
	|-Enumerable.WhereSelectListIterator<object, float>.Clone
	|-Enumerable.WhereSelectListIterator<object, uint>.Clone
	|
	|-RVA: 0x16A3BC0 Offset: 0x16A21C0 VA: 0x1816A3BC0
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, Resolution>.Clone
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, Resolution>.Clone
	|-Enumerable.WhereSelectListIterator<ServerInfo, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectListIterator<ServerInfo, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectListIterator<ServerInfo, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectListIterator<ServerInfo, Resolution>.Clone
	|-Enumerable.WhereSelectListIterator<Achievement, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectListIterator<Achievement, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectListIterator<Achievement, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectListIterator<Achievement, Resolution>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryDefId, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryDefId, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryDefId, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryDefId, Resolution>.Clone
	|-Enumerable.WhereSelectListIterator<Friend, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectListIterator<Friend, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectListIterator<Friend, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectListIterator<Friend, Resolution>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryItem, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryItem, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryItem, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryItem, Resolution>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryRecipe, PlayerItemRecipe>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, Resolution>.Clone
	|-Enumerable.WhereSelectListIterator<DictionaryEntry, KeyValuePair<object, object>>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Resolution>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, Resolution>.Clone
	|-Enumerable.WhereSelectListIterator<Int32Enum, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectListIterator<Int32Enum, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectListIterator<Int32Enum, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectListIterator<Int32Enum, Resolution>.Clone
	|-Enumerable.WhereSelectListIterator<object, Debugging.EntityInfo>.Clone
	|-Enumerable.WhereSelectListIterator<object, PlayerItemRecipe>.Clone
	|-Enumerable.WhereSelectListIterator<object, ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereSelectListIterator<object, KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereSelectListIterator<object, Resolution>.Clone
	|
	|-RVA: 0x16A3C60 Offset: 0x16A2260 VA: 0x1816A3C60
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, Option>.Clone
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, InventoryItem>.Clone
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, Option>.Clone
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, InventoryItem>.Clone
	|-Enumerable.WhereSelectListIterator<Option, Option>.Clone
	|-Enumerable.WhereSelectListIterator<ServerInfo, Option>.Clone
	|-Enumerable.WhereSelectListIterator<ServerInfo, InventoryItem>.Clone
	|-Enumerable.WhereSelectListIterator<Achievement, Option>.Clone
	|-Enumerable.WhereSelectListIterator<Achievement, InventoryItem>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryDefId, Option>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryDefId, InventoryItem>.Clone
	|-Enumerable.WhereSelectListIterator<Friend, Option>.Clone
	|-Enumerable.WhereSelectListIterator<Friend, InventoryItem>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryItem, Option>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryItem, InventoryItem>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, Option>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, InventoryItem>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Option>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, InventoryItem>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, Option>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, InventoryItem>.Clone
	|-Enumerable.WhereSelectListIterator<Int32Enum, Option>.Clone
	|-Enumerable.WhereSelectListIterator<Int32Enum, InventoryItem>.Clone
	|-Enumerable.WhereSelectListIterator<object, Option>.Clone
	|-Enumerable.WhereSelectListIterator<object, InventoryItem>.Clone
	|
	|-RVA: 0x16A3DA0 Offset: 0x16A23A0 VA: 0x1816A3DA0
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectListIterator<ServerInfo, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectListIterator<ServerInfo, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectListIterator<Achievement, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectListIterator<Achievement, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryDefId, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryDefId, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectListIterator<Friend, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectListIterator<Friend, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryItem, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryItem, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectListIterator<Int32Enum, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectListIterator<Int32Enum, InventoryRecipe>.Clone
	|-Enumerable.WhereSelectListIterator<object, InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereSelectListIterator<object, InventoryRecipe>.Clone
	|
	|-RVA: 0x16A3E40 Offset: 0x16A2440 VA: 0x1816A3E40
	|-Enumerable.WhereSelectListIterator<ServerInfo, ServerInfo>.Clone
	*/

	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176DC90 Offset: 0x176C290 VA: 0x18176DC90
	|-Enumerable.WhereSelectListIterator<BurstCloth.Chain, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<BurstCloth.Chain, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<Achievement, bool>.MoveNext
	|
	|-RVA: 0x1770290 Offset: 0x176E890 VA: 0x181770290
	|-Enumerable.WhereSelectListIterator<BurstCloth.Chain, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<Achievement, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<Achievement, Int32Enum>.MoveNext
	|
	|-RVA: 0x176C140 Offset: 0x176A740 VA: 0x18176C140
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x176E950 Offset: 0x176CF50 VA: 0x18176E950
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, long>.MoveNext
	|
	|-RVA: 0x176C400 Offset: 0x176AA00 VA: 0x18176C400
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, Resolution>.MoveNext
	|
	|-RVA: 0x1772D40 Offset: 0x1771340 VA: 0x181772D40
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, Option>.MoveNext
	|
	|-RVA: 0x176D2F0 Offset: 0x176B8F0 VA: 0x18176D2F0
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, InventoryItem>.MoveNext
	|
	|-RVA: 0x1773180 Offset: 0x1771780 VA: 0x181773180
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x17710E0 Offset: 0x176F6E0 VA: 0x1817710E0
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1770930 Offset: 0x176EF30 VA: 0x181770930
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, bool>.MoveNext
	|
	|-RVA: 0x17719D0 Offset: 0x176FFD0 VA: 0x1817719D0
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, Int32Enum>.MoveNext
	|
	|-RVA: 0x1773870 Offset: 0x1771E70 VA: 0x181773870
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, object>.MoveNext
	|
	|-RVA: 0x176EED0 Offset: 0x176D4D0 VA: 0x18176EED0
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, float>.MoveNext
	|
	|-RVA: 0x176EDA0 Offset: 0x176D3A0 VA: 0x18176EDA0
	|-Enumerable.WhereSelectListIterator<WeightedStringList.Container, float>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, float>.MoveNext
	|
	|-RVA: 0x176E300 Offset: 0x176C900 VA: 0x18176E300
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, KeyValuePair<object, int>>.MoveNext
	|-Enumerable.WhereSelectListIterator<DictionaryEntry, KeyValuePair<object, object>>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x176CD20 Offset: 0x176B320 VA: 0x18176CD20
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, long>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, long>.MoveNext
	|
	|-RVA: 0x176DDB0 Offset: 0x176C3B0 VA: 0x18176DDB0
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, Resolution>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Resolution>.MoveNext
	|
	|-RVA: 0x1772420 Offset: 0x1770A20 VA: 0x181772420
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, Option>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Option>.MoveNext
	|
	|-RVA: 0x176D890 Offset: 0x176BE90 VA: 0x18176D890
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, InventoryItem>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, InventoryItem>.MoveNext
	|
	|-RVA: 0x176E1B0 Offset: 0x176C7B0 VA: 0x18176E1B0
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, InventoryRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1770E50 Offset: 0x176F450 VA: 0x181770E50
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, InventoryRecipe>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x176FF10 Offset: 0x176E510 VA: 0x18176FF10
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, bool>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, bool>.MoveNext
	|
	|-RVA: 0x176D1C0 Offset: 0x176B7C0 VA: 0x18176D1C0
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Int32Enum>.MoveNext
	|
	|-RVA: 0x1771CA0 Offset: 0x17702A0 VA: 0x181771CA0
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, object>.MoveNext
	|-Enumerable.WhereSelectListIterator<DictionaryEntry, object>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.MoveNext
	|
	|-RVA: 0x176FDE0 Offset: 0x176E3E0 VA: 0x18176FDE0
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, float>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, float>.MoveNext
	|
	|-RVA: 0x176FB50 Offset: 0x176E150 VA: 0x18176FB50
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe.Ingredient, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe.Ingredient, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<Friend, bool>.MoveNext
	|
	|-RVA: 0x1770170 Offset: 0x176E770 VA: 0x181770170
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe.Ingredient, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<Friend, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<Friend, Int32Enum>.MoveNext
	|
	|-RVA: 0x1770FA0 Offset: 0x176F5A0 VA: 0x181770FA0
	|-Enumerable.WhereSelectListIterator<ProjectileWeaponMod.Modifier, float>.MoveNext
	|
	|-RVA: 0x1773700 Offset: 0x1771D00 VA: 0x181773700
	|-Enumerable.WhereSelectListIterator<Option, Option>.MoveNext
	|
	|-RVA: 0x176D9E0 Offset: 0x176BFE0 VA: 0x18176D9E0
	|-Enumerable.WhereSelectListIterator<ServerInfo, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<ServerInfo, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x176BEA0 Offset: 0x176A4A0 VA: 0x18176BEA0
	|-Enumerable.WhereSelectListIterator<ServerInfo, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<ServerInfo, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<ServerInfo, bool>.MoveNext
	|
	|-RVA: 0x176F8B0 Offset: 0x176DEB0 VA: 0x18176F8B0
	|-Enumerable.WhereSelectListIterator<ServerInfo, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<ServerInfo, long>.MoveNext
	|
	|-RVA: 0x176E560 Offset: 0x176CB60 VA: 0x18176E560
	|-Enumerable.WhereSelectListIterator<ServerInfo, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<ServerInfo, Resolution>.MoveNext
	|
	|-RVA: 0x176DEF0 Offset: 0x176C4F0 VA: 0x18176DEF0
	|-Enumerable.WhereSelectListIterator<ServerInfo, Option>.MoveNext
	|
	|-RVA: 0x1772A80 Offset: 0x1771080 VA: 0x181772A80
	|-Enumerable.WhereSelectListIterator<ServerInfo, InventoryItem>.MoveNext
	|
	|-RVA: 0x176F050 Offset: 0x176D650 VA: 0x18176F050
	|-Enumerable.WhereSelectListIterator<ServerInfo, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x176EAE0 Offset: 0x176D0E0 VA: 0x18176EAE0
	|-Enumerable.WhereSelectListIterator<ServerInfo, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x176F310 Offset: 0x176D910 VA: 0x18176F310
	|-Enumerable.WhereSelectListIterator<ServerInfo, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<ServerInfo, Int32Enum>.MoveNext
	|
	|-RVA: 0x1772EE0 Offset: 0x17714E0 VA: 0x181772EE0
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>.MoveNext
	|
	|-RVA: 0x1770AC0 Offset: 0x176F0C0 VA: 0x181770AC0
	|-Enumerable.WhereSelectListIterator<ServerInfo, float>.MoveNext
	|
	|-RVA: 0x1770660 Offset: 0x176EC60 VA: 0x181770660
	|-Enumerable.WhereSelectListIterator<SkinnedMultiMesh.Part, long>.MoveNext
	|
	|-RVA: 0x176D090 Offset: 0x176B690 VA: 0x18176D090
	|-Enumerable.WhereSelectListIterator<Achievement, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<Achievement, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x176CF70 Offset: 0x176B570 VA: 0x18176CF70
	|-Enumerable.WhereSelectListIterator<Achievement, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<Achievement, long>.MoveNext
	|
	|-RVA: 0x176C820 Offset: 0x176AE20 VA: 0x18176C820
	|-Enumerable.WhereSelectListIterator<Achievement, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<Achievement, Resolution>.MoveNext
	|
	|-RVA: 0x1772940 Offset: 0x1770F40 VA: 0x181772940
	|-Enumerable.WhereSelectListIterator<Achievement, Option>.MoveNext
	|
	|-RVA: 0x17721A0 Offset: 0x17707A0 VA: 0x1817721A0
	|-Enumerable.WhereSelectListIterator<Achievement, InventoryItem>.MoveNext
	|
	|-RVA: 0x17703B0 Offset: 0x176E9B0 VA: 0x1817703B0
	|-Enumerable.WhereSelectListIterator<Achievement, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1771890 Offset: 0x176FE90 VA: 0x181771890
	|-Enumerable.WhereSelectListIterator<Achievement, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x176D760 Offset: 0x176BD60 VA: 0x18176D760
	|-Enumerable.WhereSelectListIterator<Achievement, object>.MoveNext
	|
	|-RVA: 0x1772570 Offset: 0x1770B70 VA: 0x181772570
	|-Enumerable.WhereSelectListIterator<Achievement, float>.MoveNext
	|
	|-RVA: 0x1771280 Offset: 0x176F880 VA: 0x181771280
	|-Enumerable.WhereSelectListIterator<InventoryDefId, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryDefId, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x176C5A0 Offset: 0x176ABA0 VA: 0x18176C5A0
	|-Enumerable.WhereSelectListIterator<InventoryDefId, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryDefId, long>.MoveNext
	|
	|-RVA: 0x17714D0 Offset: 0x176FAD0 VA: 0x1817714D0
	|-Enumerable.WhereSelectListIterator<InventoryDefId, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryDefId, Resolution>.MoveNext
	|
	|-RVA: 0x1771B60 Offset: 0x1770160 VA: 0x181771B60
	|-Enumerable.WhereSelectListIterator<InventoryDefId, Option>.MoveNext
	|
	|-RVA: 0x176E810 Offset: 0x176CE10 VA: 0x18176E810
	|-Enumerable.WhereSelectListIterator<InventoryDefId, InventoryItem>.MoveNext
	|
	|-RVA: 0x17722E0 Offset: 0x17708E0 VA: 0x1817722E0
	|-Enumerable.WhereSelectListIterator<InventoryDefId, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1772800 Offset: 0x1770E00 VA: 0x181772800
	|-Enumerable.WhereSelectListIterator<InventoryDefId, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x176E440 Offset: 0x176CA40 VA: 0x18176E440
	|-Enumerable.WhereSelectListIterator<InventoryDefId, bool>.MoveNext
	|
	|-RVA: 0x176C2E0 Offset: 0x176A8E0 VA: 0x18176C2E0
	|-Enumerable.WhereSelectListIterator<InventoryDefId, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryDefId, Int32Enum>.MoveNext
	|
	|-RVA: 0x1770040 Offset: 0x176E640 VA: 0x181770040
	|-Enumerable.WhereSelectListIterator<InventoryDefId, object>.MoveNext
	|
	|-RVA: 0x1771600 Offset: 0x176FC00 VA: 0x181771600
	|-Enumerable.WhereSelectListIterator<InventoryDefId, float>.MoveNext
	|
	|-RVA: 0x176F5B0 Offset: 0x176DBB0 VA: 0x18176F5B0
	|-Enumerable.WhereSelectListIterator<ServerInfo, ServerInfo>.MoveNext
	|
	|-RVA: 0x1773460 Offset: 0x1771A60 VA: 0x181773460
	|-Enumerable.WhereSelectListIterator<ServerInfo, int>.MoveNext
	|
	|-RVA: 0x176CA80 Offset: 0x176B080 VA: 0x18176CA80
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>.MoveNext
	|
	|-RVA: 0x176C950 Offset: 0x176AF50 VA: 0x18176C950
	|-Enumerable.WhereSelectListIterator<Friend, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<Friend, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x176CE50 Offset: 0x176B450 VA: 0x18176CE50
	|-Enumerable.WhereSelectListIterator<Friend, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<Friend, long>.MoveNext
	|
	|-RVA: 0x176BD70 Offset: 0x176A370 VA: 0x18176BD70
	|-Enumerable.WhereSelectListIterator<Friend, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<Friend, Resolution>.MoveNext
	|
	|-RVA: 0x1771F20 Offset: 0x1770520 VA: 0x181771F20
	|-Enumerable.WhereSelectListIterator<Friend, Option>.MoveNext
	|
	|-RVA: 0x1771DE0 Offset: 0x17703E0 VA: 0x181771DE0
	|-Enumerable.WhereSelectListIterator<Friend, InventoryItem>.MoveNext
	|
	|-RVA: 0x1772060 Offset: 0x1770660 VA: 0x181772060
	|-Enumerable.WhereSelectListIterator<Friend, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1773320 Offset: 0x1771920 VA: 0x181773320
	|-Enumerable.WhereSelectListIterator<Friend, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1770D20 Offset: 0x176F320 VA: 0x181770D20
	|-Enumerable.WhereSelectListIterator<Friend, object>.MoveNext
	|
	|-RVA: 0x17713B0 Offset: 0x176F9B0 VA: 0x1817713B0
	|-Enumerable.WhereSelectListIterator<Friend, float>.MoveNext
	|
	|-RVA: 0x176D490 Offset: 0x176BA90 VA: 0x18176D490
	|-Enumerable.WhereSelectListIterator<InventoryItem, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryItem, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x176C6C0 Offset: 0x176ACC0 VA: 0x18176C6C0
	|-Enumerable.WhereSelectListIterator<InventoryItem, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryItem, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryItem, bool>.MoveNext
	|
	|-RVA: 0x176D600 Offset: 0x176BC00 VA: 0x18176D600
	|-Enumerable.WhereSelectListIterator<InventoryItem, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryItem, InventoryItemId>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryItem, long>.MoveNext
	|
	|-RVA: 0x176FC70 Offset: 0x176E270 VA: 0x18176FC70
	|-Enumerable.WhereSelectListIterator<InventoryItem, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryItem, Resolution>.MoveNext
	|
	|-RVA: 0x17707C0 Offset: 0x176EDC0 VA: 0x1817707C0
	|-Enumerable.WhereSelectListIterator<InventoryItem, Option>.MoveNext
	|
	|-RVA: 0x1772690 Offset: 0x1770C90 VA: 0x181772690
	|-Enumerable.WhereSelectListIterator<InventoryItem, InventoryItem>.MoveNext
	|
	|-RVA: 0x1771720 Offset: 0x176FD20 VA: 0x181771720
	|-Enumerable.WhereSelectListIterator<InventoryItem, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x17704F0 Offset: 0x176EAF0 VA: 0x1817704F0
	|-Enumerable.WhereSelectListIterator<InventoryItem, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x17929B0 Offset: 0x1790FB0 VA: 0x1817929B0
	|-Enumerable.WhereSelectListIterator<InventoryItem, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryItem, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryItem, uint>.MoveNext
	|
	|-RVA: 0x1791360 Offset: 0x178F960 VA: 0x181791360
	|-Enumerable.WhereSelectListIterator<InventoryItem, object>.MoveNext
	|
	|-RVA: 0x1793780 Offset: 0x1791D80 VA: 0x181793780
	|-Enumerable.WhereSelectListIterator<InventoryItem, float>.MoveNext
	|
	|-RVA: 0x1792C40 Offset: 0x1791240 VA: 0x181792C40
	|-Enumerable.WhereSelectListIterator<InventoryItem.Amount, InventoryItemId>.MoveNext
	|
	|-RVA: 0x1792F10 Offset: 0x1791510 VA: 0x181792F10
	|-Enumerable.WhereSelectListIterator<InventoryItem.Amount, uint>.MoveNext
	|
	|-RVA: 0x17914D0 Offset: 0x178FAD0 VA: 0x1817914D0
	|-Enumerable.WhereSelectListIterator<InventoryRecipe, PlayerItemRecipe>.MoveNext
	|
	|-RVA: 0x17933A0 Offset: 0x17919A0 VA: 0x1817933A0
	|-Enumerable.WhereSelectListIterator<InventoryRecipe, object>.MoveNext
	|
	|-RVA: 0x1790E30 Offset: 0x178F430 VA: 0x181790E30
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x17911F0 Offset: 0x178F7F0 VA: 0x1817911F0
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, long>.MoveNext
	|
	|-RVA: 0x1791A60 Offset: 0x1790060 VA: 0x181791A60
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, Resolution>.MoveNext
	|
	|-RVA: 0x17918D0 Offset: 0x178FED0 VA: 0x1817918D0
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, Option>.MoveNext
	|
	|-RVA: 0x1792320 Offset: 0x1790920 VA: 0x181792320
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, InventoryItem>.MoveNext
	|
	|-RVA: 0x1793210 Offset: 0x1791810 VA: 0x181793210
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1793C70 Offset: 0x1792270 VA: 0x181793C70
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x17924B0 Offset: 0x1790AB0 VA: 0x1817924B0
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, bool>.MoveNext
	|
	|-RVA: 0x1790590 Offset: 0x178EB90 VA: 0x181790590
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, Int32Enum>.MoveNext
	|
	|-RVA: 0x17930A0 Offset: 0x17916A0 VA: 0x1817930A0
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, object>.MoveNext
	|
	|-RVA: 0x1793F40 Offset: 0x1792540 VA: 0x181793F40
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, float>.MoveNext
	|
	|-RVA: 0x1793B30 Offset: 0x1792130 VA: 0x181793B30
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1792B10 Offset: 0x1791110 VA: 0x181792B10
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, long>.MoveNext
	|
	|-RVA: 0x1790450 Offset: 0x178EA50 VA: 0x181790450
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, Resolution>.MoveNext
	|
	|-RVA: 0x1790700 Offset: 0x178ED00 VA: 0x181790700
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, Option>.MoveNext
	|
	|-RVA: 0x1791D10 Offset: 0x1790310 VA: 0x181791D10
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, InventoryItem>.MoveNext
	|
	|-RVA: 0x1791650 Offset: 0x178FC50 VA: 0x181791650
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1790AA0 Offset: 0x178F0A0 VA: 0x181790AA0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1794320 Offset: 0x1792920 VA: 0x181794320
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, bool>.MoveNext
	|
	|-RVA: 0x17921F0 Offset: 0x17907F0 VA: 0x1817921F0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, uint>.MoveNext
	|
	|-RVA: 0x1793640 Offset: 0x1791C40 VA: 0x181793640
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, object>.MoveNext
	|
	|-RVA: 0x1790BF0 Offset: 0x178F1F0 VA: 0x181790BF0
	|-Enumerable.WhereSelectListIterator<int, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<int, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<Int32Enum, bool>.MoveNext
	|
	|-RVA: 0x1792760 Offset: 0x1790D60 VA: 0x181792760
	|-Enumerable.WhereSelectListIterator<int, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<Int32Enum, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<Int32Enum, Int32Enum>.MoveNext
	|
	|-RVA: 0x1790970 Offset: 0x178EF70 VA: 0x181790970
	|-Enumerable.WhereSelectListIterator<Int32Enum, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<Int32Enum, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x17910D0 Offset: 0x178F6D0 VA: 0x1817910D0
	|-Enumerable.WhereSelectListIterator<Int32Enum, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<Int32Enum, long>.MoveNext
	|
	|-RVA: 0x17917A0 Offset: 0x178FDA0 VA: 0x1817917A0
	|-Enumerable.WhereSelectListIterator<Int32Enum, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<Int32Enum, Resolution>.MoveNext
	|
	|-RVA: 0x1792620 Offset: 0x1790C20 VA: 0x181792620
	|-Enumerable.WhereSelectListIterator<Int32Enum, Option>.MoveNext
	|
	|-RVA: 0x1792DD0 Offset: 0x17913D0 VA: 0x181792DD0
	|-Enumerable.WhereSelectListIterator<Int32Enum, InventoryItem>.MoveNext
	|
	|-RVA: 0x17941E0 Offset: 0x17927E0 VA: 0x1817941E0
	|-Enumerable.WhereSelectListIterator<Int32Enum, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x17938D0 Offset: 0x1791ED0 VA: 0x1817938D0
	|-Enumerable.WhereSelectListIterator<Int32Enum, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1793510 Offset: 0x1791B10 VA: 0x181793510
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.MoveNext
	|
	|-RVA: 0x1793A10 Offset: 0x1792010 VA: 0x181793A10
	|-Enumerable.WhereSelectListIterator<Int32Enum, float>.MoveNext
	|
	|-RVA: 0x1791BE0 Offset: 0x17901E0 VA: 0x181791BE0
	|-Enumerable.WhereSelectListIterator<object, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, PlayerItemRecipe>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1790FB0 Offset: 0x178F5B0 VA: 0x181790FB0
	|-Enumerable.WhereSelectListIterator<object, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, bool>.MoveNext
	|
	|-RVA: 0x1790850 Offset: 0x178EE50 VA: 0x181790850
	|-Enumerable.WhereSelectListIterator<object, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, PlayerItemRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, InventoryItemId>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, long>.MoveNext
	|
	|-RVA: 0x1792880 Offset: 0x1790E80 VA: 0x181792880
	|-Enumerable.WhereSelectListIterator<object, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, Resolution>.MoveNext
	|
	|-RVA: 0x1793E00 Offset: 0x1792400 VA: 0x181793E00
	|-Enumerable.WhereSelectListIterator<object, Option>.MoveNext
	|
	|-RVA: 0x17920B0 Offset: 0x17906B0 VA: 0x1817920B0
	|-Enumerable.WhereSelectListIterator<object, InventoryItem>.MoveNext
	|
	|-RVA: 0x1794450 Offset: 0x1792A50 VA: 0x181794450
	|-Enumerable.WhereSelectListIterator<object, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x17940A0 Offset: 0x17926A0 VA: 0x1817940A0
	|-Enumerable.WhereSelectListIterator<object, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1790D10 Offset: 0x178F310 VA: 0x181790D10
	|-Enumerable.WhereSelectListIterator<object, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, uint>.MoveNext
	|
	|-RVA: 0x1791F80 Offset: 0x1790580 VA: 0x181791F80
	|-Enumerable.WhereSelectListIterator<object, object>.MoveNext
	|
	|-RVA: 0x1791E60 Offset: 0x1790460 VA: 0x181791E60
	|-Enumerable.WhereSelectListIterator<object, float>.MoveNext
	*/

	public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC8CFE0 Offset: 0xC8B5E0 VA: 0x180C8CFE0
	|-Enumerable.WhereSelectListIterator<BurstCloth.Chain, int>.Select<FourBitNumber>
	|-Enumerable.WhereSelectListIterator<BurstCloth.Chain, int>.Select<SevenBitNumber>
	|-Enumerable.WhereSelectListIterator<BurstCloth.Chain, int>.Select<int>
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, object>.Select<Option>
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, object>.Select<bool>
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, object>.Select<int>
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, object>.Select<long>
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, object>.Select<object>
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, object>.Select<float>
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, object>.Select<Resolution>
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, object>.Select<Option>
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, object>.Select<bool>
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, object>.Select<int>
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, object>.Select<long>
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, object>.Select<object>
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, object>.Select<float>
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, object>.Select<Resolution>
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe.Ingredient, int>.Select<FourBitNumber>
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe.Ingredient, int>.Select<SevenBitNumber>
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe.Ingredient, int>.Select<int>
	|-Enumerable.WhereSelectListIterator<ServerInfo, int>.Select<FourBitNumber>
	|-Enumerable.WhereSelectListIterator<ServerInfo, int>.Select<SevenBitNumber>
	|-Enumerable.WhereSelectListIterator<ServerInfo, int>.Select<int>
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>.Select<Option>
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>.Select<bool>
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>.Select<int>
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>.Select<long>
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>.Select<object>
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>.Select<float>
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>.Select<Resolution>
	|-Enumerable.WhereSelectListIterator<Achievement, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectListIterator<Achievement, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectListIterator<Achievement, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectListIterator<Achievement, object>.Select<Option>
	|-Enumerable.WhereSelectListIterator<Achievement, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectListIterator<Achievement, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectListIterator<Achievement, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectListIterator<Achievement, object>.Select<bool>
	|-Enumerable.WhereSelectListIterator<Achievement, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectListIterator<Achievement, object>.Select<int>
	|-Enumerable.WhereSelectListIterator<Achievement, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectListIterator<Achievement, object>.Select<long>
	|-Enumerable.WhereSelectListIterator<Achievement, object>.Select<object>
	|-Enumerable.WhereSelectListIterator<Achievement, object>.Select<float>
	|-Enumerable.WhereSelectListIterator<Achievement, object>.Select<Resolution>
	|-Enumerable.WhereSelectListIterator<InventoryDefId, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectListIterator<InventoryDefId, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectListIterator<InventoryDefId, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectListIterator<InventoryDefId, object>.Select<Option>
	|-Enumerable.WhereSelectListIterator<InventoryDefId, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectListIterator<InventoryDefId, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectListIterator<InventoryDefId, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectListIterator<InventoryDefId, object>.Select<bool>
	|-Enumerable.WhereSelectListIterator<InventoryDefId, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectListIterator<InventoryDefId, object>.Select<int>
	|-Enumerable.WhereSelectListIterator<InventoryDefId, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectListIterator<InventoryDefId, object>.Select<long>
	|-Enumerable.WhereSelectListIterator<InventoryDefId, object>.Select<object>
	|-Enumerable.WhereSelectListIterator<InventoryDefId, object>.Select<float>
	|-Enumerable.WhereSelectListIterator<InventoryDefId, object>.Select<Resolution>
	|-Enumerable.WhereSelectListIterator<Friend, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectListIterator<Friend, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectListIterator<Friend, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectListIterator<Friend, object>.Select<Option>
	|-Enumerable.WhereSelectListIterator<Friend, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectListIterator<Friend, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectListIterator<Friend, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectListIterator<Friend, object>.Select<bool>
	|-Enumerable.WhereSelectListIterator<Friend, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectListIterator<Friend, object>.Select<int>
	|-Enumerable.WhereSelectListIterator<Friend, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectListIterator<Friend, object>.Select<long>
	|-Enumerable.WhereSelectListIterator<Friend, object>.Select<object>
	|-Enumerable.WhereSelectListIterator<Friend, object>.Select<float>
	|-Enumerable.WhereSelectListIterator<Friend, object>.Select<Resolution>
	|-Enumerable.WhereSelectListIterator<InventoryItem, int>.Select<FourBitNumber>
	|-Enumerable.WhereSelectListIterator<InventoryItem, int>.Select<SevenBitNumber>
	|-Enumerable.WhereSelectListIterator<InventoryItem, int>.Select<int>
	|-Enumerable.WhereSelectListIterator<InventoryItem, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectListIterator<InventoryItem, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectListIterator<InventoryItem, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectListIterator<InventoryItem, object>.Select<Option>
	|-Enumerable.WhereSelectListIterator<InventoryItem, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectListIterator<InventoryItem, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectListIterator<InventoryItem, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectListIterator<InventoryItem, object>.Select<bool>
	|-Enumerable.WhereSelectListIterator<InventoryItem, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectListIterator<InventoryItem, object>.Select<int>
	|-Enumerable.WhereSelectListIterator<InventoryItem, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectListIterator<InventoryItem, object>.Select<long>
	|-Enumerable.WhereSelectListIterator<InventoryItem, object>.Select<object>
	|-Enumerable.WhereSelectListIterator<InventoryItem, object>.Select<float>
	|-Enumerable.WhereSelectListIterator<InventoryItem, object>.Select<Resolution>
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.Select<int>
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, object>.Select<Option>
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, object>.Select<bool>
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, object>.Select<int>
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, object>.Select<long>
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, object>.Select<object>
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, object>.Select<float>
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, object>.Select<Resolution>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Select<Option>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Select<bool>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Select<int>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Select<long>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Select<object>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Select<float>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Select<Resolution>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, object>.Select<Option>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, object>.Select<bool>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, object>.Select<int>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, object>.Select<long>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, object>.Select<object>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, object>.Select<float>
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, object>.Select<Resolution>
	|-Enumerable.WhereSelectListIterator<int, int>.Select<FourBitNumber>
	|-Enumerable.WhereSelectListIterator<int, int>.Select<SevenBitNumber>
	|-Enumerable.WhereSelectListIterator<int, int>.Select<int>
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Select<Option>
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Select<bool>
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Select<int>
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Select<long>
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Select<object>
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Select<float>
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Select<Resolution>
	|-Enumerable.WhereSelectListIterator<object, int>.Select<FourBitNumber>
	|-Enumerable.WhereSelectListIterator<object, int>.Select<SevenBitNumber>
	|-Enumerable.WhereSelectListIterator<object, int>.Select<int>
	|-Enumerable.WhereSelectListIterator<object, Int32Enum>.Select<object>
	|-Enumerable.WhereSelectListIterator<object, object>.Select<Debugging.EntityInfo>
	|-Enumerable.WhereSelectListIterator<object, object>.Select<PathFinder.Point>
	|-Enumerable.WhereSelectListIterator<object, object>.Select<ProjectileWeaponMod.Modifier>
	|-Enumerable.WhereSelectListIterator<object, object>.Select<Option>
	|-Enumerable.WhereSelectListIterator<object, object>.Select<InventoryItem>
	|-Enumerable.WhereSelectListIterator<object, object>.Select<InventoryRecipe.Ingredient>
	|-Enumerable.WhereSelectListIterator<object, object>.Select<InventoryRecipe>
	|-Enumerable.WhereSelectListIterator<object, object>.Select<bool>
	|-Enumerable.WhereSelectListIterator<object, object>.Select<KeyValuePair<object, int>>
	|-Enumerable.WhereSelectListIterator<object, object>.Select<int>
	|-Enumerable.WhereSelectListIterator<object, object>.Select<Int32Enum>
	|-Enumerable.WhereSelectListIterator<object, object>.Select<long>
	|-Enumerable.WhereSelectListIterator<object, object>.Select<object>
	|-Enumerable.WhereSelectListIterator<object, object>.Select<float>
	|-Enumerable.WhereSelectListIterator<object, object>.Select<Resolution>
	|
	|-RVA: 0xC8D120 Offset: 0xC8B720 VA: 0x180C8D120
	|-Enumerable.WhereSelectListIterator<Option, Option>.Select<Option>
	|-Enumerable.WhereSelectListIterator<object, Option>.Select<Option>
	|-Enumerable.WhereSelectListIterator<object, InventoryItem>.Select<InventoryItemId>
	|-Enumerable.WhereSelectListIterator<object, InventoryItem>.Select<int>
	|-Enumerable.WhereSelectListIterator<object, InventoryItem>.Select<object>
	|-Enumerable.WhereSelectListIterator<object, InventoryItem>.Select<uint>
	|
	|-RVA: 0xC8D260 Offset: 0xC8B860 VA: 0x180C8D260
	|-Enumerable.WhereSelectListIterator<ServerInfo, ServerInfo>.Select<int>
	|-Enumerable.WhereSelectListIterator<ServerInfo, ServerInfo>.Select<object>
	|
	|-RVA: 0xC8D1C0 Offset: 0xC8B7C0 VA: 0x180C8D1C0
	|-Enumerable.WhereSelectListIterator<InventoryRecipe, PlayerItemRecipe>.Select<object>
	|-Enumerable.WhereSelectListIterator<DictionaryEntry, KeyValuePair<object, object>>.Select<object>
	|-Enumerable.WhereSelectListIterator<object, ProjectileWeaponMod.Modifier>.Select<float>
	|
	|-RVA: 0xC8D080 Offset: 0xC8B680 VA: 0x180C8D080
	|-Enumerable.WhereSelectListIterator<object, InventoryRecipe.Ingredient>.Select<PlayerItemRecipe.Ingredient>
	|-Enumerable.WhereSelectListIterator<object, InventoryRecipe.Ingredient>.Select<object>
	|-Enumerable.WhereSelectListIterator<object, InventoryRecipe>.Select<PlayerItemRecipe>
	*/

	public override IEnumerable<TResult> Where(Func<TResult, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1773A00 Offset: 0x1772000 VA: 0x181773A00
	|-Enumerable.WhereSelectListIterator<BurstCloth.Chain, FourBitNumber>.Where
	|-Enumerable.WhereSelectListIterator<BurstCloth.Chain, SevenBitNumber>.Where
	|-Enumerable.WhereSelectListIterator<BurstCloth.Chain, int>.Where
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, PathFinder.Point>.Where
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, Option>.Where
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, InventoryItem>.Where
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, InventoryRecipe>.Where
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, bool>.Where
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, int>.Where
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, Int32Enum>.Where
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, long>.Where
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, object>.Where
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, float>.Where
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, Resolution>.Where
	|-Enumerable.WhereSelectListIterator<WeightedStringList.Container, float>.Where
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, PathFinder.Point>.Where
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, Option>.Where
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, InventoryItem>.Where
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, InventoryRecipe>.Where
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, bool>.Where
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, int>.Where
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, Int32Enum>.Where
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, long>.Where
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, object>.Where
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, float>.Where
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, Resolution>.Where
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe.Ingredient, FourBitNumber>.Where
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe.Ingredient, SevenBitNumber>.Where
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe.Ingredient, int>.Where
	|-Enumerable.WhereSelectListIterator<ProjectileWeaponMod.Modifier, float>.Where
	|-Enumerable.WhereSelectListIterator<Option, Option>.Where
	|-Enumerable.WhereSelectListIterator<ServerInfo, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectListIterator<ServerInfo, FourBitNumber>.Where
	|-Enumerable.WhereSelectListIterator<ServerInfo, SevenBitNumber>.Where
	|-Enumerable.WhereSelectListIterator<ServerInfo, PathFinder.Point>.Where
	|-Enumerable.WhereSelectListIterator<ServerInfo, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectListIterator<ServerInfo, Option>.Where
	|-Enumerable.WhereSelectListIterator<ServerInfo, InventoryItem>.Where
	|-Enumerable.WhereSelectListIterator<ServerInfo, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectListIterator<ServerInfo, InventoryRecipe>.Where
	|-Enumerable.WhereSelectListIterator<ServerInfo, bool>.Where
	|-Enumerable.WhereSelectListIterator<ServerInfo, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectListIterator<ServerInfo, int>.Where
	|-Enumerable.WhereSelectListIterator<ServerInfo, Int32Enum>.Where
	|-Enumerable.WhereSelectListIterator<ServerInfo, long>.Where
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>.Where
	|-Enumerable.WhereSelectListIterator<ServerInfo, float>.Where
	|-Enumerable.WhereSelectListIterator<ServerInfo, Resolution>.Where
	|-Enumerable.WhereSelectListIterator<SkinnedMultiMesh.Part, long>.Where
	|-Enumerable.WhereSelectListIterator<Achievement, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectListIterator<Achievement, PathFinder.Point>.Where
	|-Enumerable.WhereSelectListIterator<Achievement, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectListIterator<Achievement, Option>.Where
	|-Enumerable.WhereSelectListIterator<Achievement, InventoryItem>.Where
	|-Enumerable.WhereSelectListIterator<Achievement, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectListIterator<Achievement, InventoryRecipe>.Where
	|-Enumerable.WhereSelectListIterator<Achievement, bool>.Where
	|-Enumerable.WhereSelectListIterator<Achievement, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectListIterator<Achievement, int>.Where
	|-Enumerable.WhereSelectListIterator<Achievement, Int32Enum>.Where
	|-Enumerable.WhereSelectListIterator<Achievement, long>.Where
	|-Enumerable.WhereSelectListIterator<Achievement, object>.Where
	|-Enumerable.WhereSelectListIterator<Achievement, float>.Where
	|-Enumerable.WhereSelectListIterator<Achievement, Resolution>.Where
	|-Enumerable.WhereSelectListIterator<InventoryDefId, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectListIterator<InventoryDefId, PathFinder.Point>.Where
	|-Enumerable.WhereSelectListIterator<InventoryDefId, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectListIterator<InventoryDefId, Option>.Where
	|-Enumerable.WhereSelectListIterator<InventoryDefId, InventoryItem>.Where
	|-Enumerable.WhereSelectListIterator<InventoryDefId, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectListIterator<InventoryDefId, InventoryRecipe>.Where
	|-Enumerable.WhereSelectListIterator<InventoryDefId, bool>.Where
	|-Enumerable.WhereSelectListIterator<InventoryDefId, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectListIterator<InventoryDefId, int>.Where
	|-Enumerable.WhereSelectListIterator<InventoryDefId, Int32Enum>.Where
	|-Enumerable.WhereSelectListIterator<InventoryDefId, long>.Where
	|-Enumerable.WhereSelectListIterator<InventoryDefId, object>.Where
	|-Enumerable.WhereSelectListIterator<InventoryDefId, float>.Where
	|-Enumerable.WhereSelectListIterator<InventoryDefId, Resolution>.Where
	|-Enumerable.WhereSelectListIterator<ServerInfo, ServerInfo>.Where
	|-Enumerable.WhereSelectListIterator<ServerInfo, int>.Where
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>.Where
	|-Enumerable.WhereSelectListIterator<Friend, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectListIterator<Friend, PathFinder.Point>.Where
	|-Enumerable.WhereSelectListIterator<Friend, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectListIterator<Friend, Option>.Where
	|-Enumerable.WhereSelectListIterator<Friend, InventoryItem>.Where
	|-Enumerable.WhereSelectListIterator<Friend, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectListIterator<Friend, InventoryRecipe>.Where
	|-Enumerable.WhereSelectListIterator<Friend, bool>.Where
	|-Enumerable.WhereSelectListIterator<Friend, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectListIterator<Friend, int>.Where
	|-Enumerable.WhereSelectListIterator<Friend, Int32Enum>.Where
	|-Enumerable.WhereSelectListIterator<Friend, long>.Where
	|-Enumerable.WhereSelectListIterator<Friend, object>.Where
	|-Enumerable.WhereSelectListIterator<Friend, float>.Where
	|-Enumerable.WhereSelectListIterator<Friend, Resolution>.Where
	|-Enumerable.WhereSelectListIterator<InventoryItem, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectListIterator<InventoryItem, FourBitNumber>.Where
	|-Enumerable.WhereSelectListIterator<InventoryItem, SevenBitNumber>.Where
	|-Enumerable.WhereSelectListIterator<InventoryItem, PathFinder.Point>.Where
	|-Enumerable.WhereSelectListIterator<InventoryItem, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectListIterator<InventoryItem, Option>.Where
	|-Enumerable.WhereSelectListIterator<InventoryItem, InventoryItemId>.Where
	|-Enumerable.WhereSelectListIterator<InventoryItem, InventoryItem>.Where
	|-Enumerable.WhereSelectListIterator<InventoryItem, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectListIterator<InventoryItem, InventoryRecipe>.Where
	|-Enumerable.WhereSelectListIterator<InventoryItem, bool>.Where
	|-Enumerable.WhereSelectListIterator<InventoryItem, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectListIterator<InventoryItem, int>.Where
	|-Enumerable.WhereSelectListIterator<InventoryItem, Int32Enum>.Where
	|-Enumerable.WhereSelectListIterator<InventoryItem, long>.Where
	|-Enumerable.WhereSelectListIterator<InventoryItem, object>.Where
	|-Enumerable.WhereSelectListIterator<InventoryItem, float>.Where
	|-Enumerable.WhereSelectListIterator<InventoryItem, uint>.Where
	|-Enumerable.WhereSelectListIterator<InventoryItem, Resolution>.Where
	|-Enumerable.WhereSelectListIterator<InventoryItem.Amount, InventoryItemId>.Where
	|-Enumerable.WhereSelectListIterator<InventoryItem.Amount, uint>.Where
	|-Enumerable.WhereSelectListIterator<InventoryRecipe, PlayerItemRecipe>.Where
	|-Enumerable.WhereSelectListIterator<InventoryRecipe, object>.Where
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, PathFinder.Point>.Where
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, Option>.Where
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, InventoryItem>.Where
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, InventoryRecipe>.Where
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, bool>.Where
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, int>.Where
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, Int32Enum>.Where
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, long>.Where
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, object>.Where
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, float>.Where
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, Resolution>.Where
	|-Enumerable.WhereSelectListIterator<DictionaryEntry, KeyValuePair<object, object>>.Where
	|-Enumerable.WhereSelectListIterator<DictionaryEntry, object>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, PathFinder.Point>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Option>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, InventoryItem>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, InventoryRecipe>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, bool>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, int>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Int32Enum>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, long>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, float>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Resolution>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, PathFinder.Point>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, Option>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, InventoryItem>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, InventoryRecipe>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, bool>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, int>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, Int32Enum>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, long>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, object>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, float>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, uint>.Where
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, Resolution>.Where
	|-Enumerable.WhereSelectListIterator<int, FourBitNumber>.Where
	|-Enumerable.WhereSelectListIterator<int, SevenBitNumber>.Where
	|-Enumerable.WhereSelectListIterator<int, int>.Where
	|-Enumerable.WhereSelectListIterator<Int32Enum, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectListIterator<Int32Enum, PathFinder.Point>.Where
	|-Enumerable.WhereSelectListIterator<Int32Enum, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectListIterator<Int32Enum, Option>.Where
	|-Enumerable.WhereSelectListIterator<Int32Enum, InventoryItem>.Where
	|-Enumerable.WhereSelectListIterator<Int32Enum, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectListIterator<Int32Enum, InventoryRecipe>.Where
	|-Enumerable.WhereSelectListIterator<Int32Enum, bool>.Where
	|-Enumerable.WhereSelectListIterator<Int32Enum, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectListIterator<Int32Enum, int>.Where
	|-Enumerable.WhereSelectListIterator<Int32Enum, Int32Enum>.Where
	|-Enumerable.WhereSelectListIterator<Int32Enum, long>.Where
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.Where
	|-Enumerable.WhereSelectListIterator<Int32Enum, float>.Where
	|-Enumerable.WhereSelectListIterator<Int32Enum, Resolution>.Where
	|-Enumerable.WhereSelectListIterator<object, Debugging.EntityInfo>.Where
	|-Enumerable.WhereSelectListIterator<object, FourBitNumber>.Where
	|-Enumerable.WhereSelectListIterator<object, SevenBitNumber>.Where
	|-Enumerable.WhereSelectListIterator<object, PathFinder.Point>.Where
	|-Enumerable.WhereSelectListIterator<object, PlayerItemRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectListIterator<object, PlayerItemRecipe>.Where
	|-Enumerable.WhereSelectListIterator<object, ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereSelectListIterator<object, Option>.Where
	|-Enumerable.WhereSelectListIterator<object, InventoryItemId>.Where
	|-Enumerable.WhereSelectListIterator<object, InventoryItem>.Where
	|-Enumerable.WhereSelectListIterator<object, InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereSelectListIterator<object, InventoryRecipe>.Where
	|-Enumerable.WhereSelectListIterator<object, bool>.Where
	|-Enumerable.WhereSelectListIterator<object, KeyValuePair<object, int>>.Where
	|-Enumerable.WhereSelectListIterator<object, int>.Where
	|-Enumerable.WhereSelectListIterator<object, Int32Enum>.Where
	|-Enumerable.WhereSelectListIterator<object, long>.Where
	|-Enumerable.WhereSelectListIterator<object, object>.Where
	|-Enumerable.WhereSelectListIterator<object, float>.Where
	|-Enumerable.WhereSelectListIterator<object, uint>.Where
	|-Enumerable.WhereSelectListIterator<object, Resolution>.Where
	*/

}

private sealed class Enumerable.<>c__DisplayClass6_0<TSource> // TypeDefIndex: 3206
{	public Func<TSource, bool> predicate1; // 0x0
	public Func<TSource, bool> predicate2; // 0x0


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BC10 Offset: 0xD5A210 VA: 0x180D5BC10
	|-Enumerable.<>c__DisplayClass6_0<Debugging.EntityInfo>..ctor
	|-Enumerable.<>c__DisplayClass6_0<SkeletonDefinition.Bone>..ctor
	|-Enumerable.<>c__DisplayClass6_0<GameStat.Stat>..ctor
	|-Enumerable.<>c__DisplayClass6_0<ItemSkinDirectory.Skin>..ctor
	|-Enumerable.<>c__DisplayClass6_0<FourBitNumber>..ctor
	|-Enumerable.<>c__DisplayClass6_0<SevenBitNumber>..ctor
	|-Enumerable.<>c__DisplayClass6_0<PathFinder.Point>..ctor
	|-Enumerable.<>c__DisplayClass6_0<PlayerItemRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass6_0<PlayerItemRecipe>..ctor
	|-Enumerable.<>c__DisplayClass6_0<ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.<>c__DisplayClass6_0<Option>..ctor
	|-Enumerable.<>c__DisplayClass6_0<ServerInfo>..ctor
	|-Enumerable.<>c__DisplayClass6_0<SkinnedMultiMesh.Part>..ctor
	|-Enumerable.<>c__DisplayClass6_0<InventoryItemId>..ctor
	|-Enumerable.<>c__DisplayClass6_0<InventoryItem>..ctor
	|-Enumerable.<>c__DisplayClass6_0<InventoryRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass6_0<InventoryRecipe>..ctor
	|-Enumerable.<>c__DisplayClass6_0<bool>..ctor
	|-Enumerable.<>c__DisplayClass6_0<char>..ctor
	|-Enumerable.<>c__DisplayClass6_0<KeyValuePair<object, int>>..ctor
	|-Enumerable.<>c__DisplayClass6_0<KeyValuePair<object, object>>..ctor
	|-Enumerable.<>c__DisplayClass6_0<KeyValuePair<uint, object>>..ctor
	|-Enumerable.<>c__DisplayClass6_0<KeyValuePair<ulong, Dispatch.ResultCallback>>..ctor
	|-Enumerable.<>c__DisplayClass6_0<int>..ctor
	|-Enumerable.<>c__DisplayClass6_0<Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass6_0<long>..ctor
	|-Enumerable.<>c__DisplayClass6_0<object>..ctor
	|-Enumerable.<>c__DisplayClass6_0<float>..ctor
	|-Enumerable.<>c__DisplayClass6_0<uint>..ctor
	|-Enumerable.<>c__DisplayClass6_0<Resolution>..ctor
	*/

	internal bool <CombinePredicates>b__0(TSource x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19EFDB0 Offset: 0x19EE3B0 VA: 0x1819EFDB0
	|-Enumerable.<>c__DisplayClass6_0<Debugging.EntityInfo>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<GameStat.Stat>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<PlayerItemRecipe>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<KeyValuePair<object, int>>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<KeyValuePair<object, object>>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<KeyValuePair<uint, object>>.<CombinePredicates>b__0
	|
	|-RVA: 0x19EFED0 Offset: 0x19EE4D0 VA: 0x1819EFED0
	|-Enumerable.<>c__DisplayClass6_0<SkeletonDefinition.Bone>.<CombinePredicates>b__0
	|
	|-RVA: 0x19F0360 Offset: 0x19EE960 VA: 0x1819F0360
	|-Enumerable.<>c__DisplayClass6_0<ItemSkinDirectory.Skin>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<Option>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<SkinnedMultiMesh.Part>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<InventoryItem>.<CombinePredicates>b__0
	|
	|-RVA: 0x19F02E0 Offset: 0x19EE8E0 VA: 0x1819F02E0
	|-Enumerable.<>c__DisplayClass6_0<FourBitNumber>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<SevenBitNumber>.<CombinePredicates>b__0
	|
	|-RVA: 0x19F0260 Offset: 0x19EE860 VA: 0x1819F0260
	|-Enumerable.<>c__DisplayClass6_0<PathFinder.Point>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<PlayerItemRecipe.Ingredient>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<InventoryItemId>.<CombinePredicates>b__0
	|
	|-RVA: 0x19F0130 Offset: 0x19EE730 VA: 0x1819F0130
	|-Enumerable.<>c__DisplayClass6_0<ProjectileWeaponMod.Modifier>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<Resolution>.<CombinePredicates>b__0
	|
	|-RVA: 0x19EFF90 Offset: 0x19EE590 VA: 0x1819EFF90
	|-Enumerable.<>c__DisplayClass6_0<ServerInfo>.<CombinePredicates>b__0
	|
	|-RVA: 0x19F0410 Offset: 0x19EEA10 VA: 0x1819F0410
	|-Enumerable.<>c__DisplayClass6_0<InventoryRecipe.Ingredient>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<InventoryRecipe>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<KeyValuePair<ulong, Dispatch.ResultCallback>>.<CombinePredicates>b__0
	|
	|-RVA: 0x19F0540 Offset: 0x19EEB40 VA: 0x1819F0540
	|-Enumerable.<>c__DisplayClass6_0<bool>.<CombinePredicates>b__0
	|
	|-RVA: 0x19F01E0 Offset: 0x19EE7E0 VA: 0x1819F01E0
	|-Enumerable.<>c__DisplayClass6_0<char>.<CombinePredicates>b__0
	|
	|-RVA: 0x19EFE50 Offset: 0x19EE450 VA: 0x1819EFE50
	|-Enumerable.<>c__DisplayClass6_0<int>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<Int32Enum>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<uint>.<CombinePredicates>b__0
	|
	|-RVA: 0x19F00B0 Offset: 0x19EE6B0 VA: 0x1819F00B0
	|-Enumerable.<>c__DisplayClass6_0<long>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<object>.<CombinePredicates>b__0
	|
	|-RVA: 0x19F04C0 Offset: 0x19EEAC0 VA: 0x1819F04C0
	|-Enumerable.<>c__DisplayClass6_0<float>.<CombinePredicates>b__0
	*/

}

private sealed class Enumerable.<>c__DisplayClass7_0<TSource, TMiddle, TResult> // TypeDefIndex: 3207
{	public Func<TMiddle, TResult> selector2; // 0x0
	public Func<TSource, TMiddle> selector1; // 0x0


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BC10 Offset: 0xD5A210 VA: 0x180D5BC10
	|-Enumerable.<>c__DisplayClass7_0<BurstCloth.Chain, FourBitNumber, FourBitNumber>..ctor
	|-Enumerable.<>c__DisplayClass7_0<BurstCloth.Chain, SevenBitNumber, SevenBitNumber>..ctor
	|-Enumerable.<>c__DisplayClass7_0<BurstCloth.Chain, int, FourBitNumber>..ctor
	|-Enumerable.<>c__DisplayClass7_0<BurstCloth.Chain, int, SevenBitNumber>..ctor
	|-Enumerable.<>c__DisplayClass7_0<BurstCloth.Chain, int, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, Debugging.EntityInfo, Debugging.EntityInfo>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, PathFinder.Point, PathFinder.Point>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, Option, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, InventoryItem, InventoryItem>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, InventoryRecipe, InventoryRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, bool, bool>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, KeyValuePair<object, int>, KeyValuePair<object, int>>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, int, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, Int32Enum, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, long, long>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, Debugging.EntityInfo>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, PathFinder.Point>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, InventoryItem>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, InventoryRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, bool>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, KeyValuePair<object, int>>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, long>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, Resolution>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, float, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, Resolution, Resolution>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, Debugging.EntityInfo, Debugging.EntityInfo>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, PathFinder.Point, PathFinder.Point>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, Option, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, InventoryItem, InventoryItem>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, InventoryRecipe, InventoryRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, bool, bool>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, KeyValuePair<object, int>, KeyValuePair<object, int>>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, int, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, Int32Enum, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, long, long>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, Debugging.EntityInfo>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, PathFinder.Point>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, InventoryItem>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, InventoryRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, bool>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, KeyValuePair<object, int>>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, long>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, Resolution>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, float, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, Resolution, Resolution>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe.Ingredient, FourBitNumber, FourBitNumber>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe.Ingredient, SevenBitNumber, SevenBitNumber>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe.Ingredient, int, FourBitNumber>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe.Ingredient, int, SevenBitNumber>..ctor
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe.Ingredient, int, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Option, Option, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, Debugging.EntityInfo, Debugging.EntityInfo>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, FourBitNumber, FourBitNumber>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, SevenBitNumber, SevenBitNumber>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, PathFinder.Point, PathFinder.Point>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, Option, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, InventoryItem, InventoryItem>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, InventoryRecipe, InventoryRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, bool, bool>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, KeyValuePair<object, int>, KeyValuePair<object, int>>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, int, FourBitNumber>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, int, SevenBitNumber>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, int, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, Int32Enum, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, long, long>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, Debugging.EntityInfo>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, PathFinder.Point>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, InventoryItem>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, InventoryRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, bool>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, KeyValuePair<object, int>>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, long>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, Resolution>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, float, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, Resolution, Resolution>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, Debugging.EntityInfo, Debugging.EntityInfo>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, PathFinder.Point, PathFinder.Point>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, Option, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, InventoryItem, InventoryItem>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, InventoryRecipe, InventoryRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, bool, bool>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, KeyValuePair<object, int>, KeyValuePair<object, int>>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, int, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, Int32Enum, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, long, long>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, Debugging.EntityInfo>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, PathFinder.Point>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, InventoryItem>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, InventoryRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, bool>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, KeyValuePair<object, int>>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, long>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, Resolution>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, float, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Achievement, Resolution, Resolution>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, Debugging.EntityInfo, Debugging.EntityInfo>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, PathFinder.Point, PathFinder.Point>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, Option, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, InventoryItem, InventoryItem>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, InventoryRecipe, InventoryRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, bool, bool>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, KeyValuePair<object, int>, KeyValuePair<object, int>>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, int, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, Int32Enum, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, long, long>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, Debugging.EntityInfo>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, PathFinder.Point>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, InventoryItem>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, InventoryRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, bool>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, KeyValuePair<object, int>>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, long>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, Resolution>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, float, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, Resolution, Resolution>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, ServerInfo, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, ServerInfo, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, int, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, Debugging.EntityInfo, Debugging.EntityInfo>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, PathFinder.Point, PathFinder.Point>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, Option, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, InventoryItem, InventoryItem>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, InventoryRecipe, InventoryRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, bool, bool>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, KeyValuePair<object, int>, KeyValuePair<object, int>>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, int, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, Int32Enum, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, long, long>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, Debugging.EntityInfo>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, PathFinder.Point>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, InventoryItem>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, InventoryRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, bool>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, KeyValuePair<object, int>>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, long>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, Resolution>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, float, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Friend, Resolution, Resolution>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, Debugging.EntityInfo, Debugging.EntityInfo>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, FourBitNumber, FourBitNumber>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, SevenBitNumber, SevenBitNumber>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, PathFinder.Point, PathFinder.Point>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, Option, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, InventoryItem, InventoryItem>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, InventoryRecipe, InventoryRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, bool, bool>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, KeyValuePair<object, int>, KeyValuePair<object, int>>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, int, FourBitNumber>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, int, SevenBitNumber>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, int, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, Int32Enum, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, long, long>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, Debugging.EntityInfo>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, PathFinder.Point>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, InventoryItem>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, InventoryRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, bool>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, KeyValuePair<object, int>>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, long>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, Resolution>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, float, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, Resolution, Resolution>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe, PlayerItemRecipe, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe, object, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, Debugging.EntityInfo, Debugging.EntityInfo>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, PathFinder.Point, PathFinder.Point>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, Option, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, InventoryItem, InventoryItem>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, InventoryRecipe, InventoryRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, bool, bool>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, KeyValuePair<object, int>, KeyValuePair<object, int>>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, int, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, Int32Enum, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, long, long>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, Debugging.EntityInfo>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, PathFinder.Point>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, InventoryItem>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, InventoryRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, bool>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, KeyValuePair<object, int>>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, long>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, Resolution>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, float, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, Resolution, Resolution>..ctor
	|-Enumerable.<>c__DisplayClass7_0<DictionaryEntry, KeyValuePair<object, object>, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<DictionaryEntry, object, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, Debugging.EntityInfo, Debugging.EntityInfo>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, PathFinder.Point, PathFinder.Point>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, Option, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, InventoryItem, InventoryItem>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, InventoryRecipe, InventoryRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, bool, bool>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, KeyValuePair<object, int>, KeyValuePair<object, int>>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, int, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, Int32Enum, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, long, long>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, Debugging.EntityInfo>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, PathFinder.Point>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, InventoryItem>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, InventoryRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, bool>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, KeyValuePair<object, int>>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, long>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, Resolution>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, float, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, Resolution, Resolution>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, Debugging.EntityInfo, Debugging.EntityInfo>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, PathFinder.Point, PathFinder.Point>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, Option, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, InventoryItem, InventoryItem>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, InventoryRecipe, InventoryRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, bool, bool>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, KeyValuePair<object, int>, KeyValuePair<object, int>>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, int, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, Int32Enum, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, long, long>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, Debugging.EntityInfo>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, PathFinder.Point>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, InventoryItem>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, InventoryRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, bool>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, KeyValuePair<object, int>>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, long>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, Resolution>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, float, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, Resolution, Resolution>..ctor
	|-Enumerable.<>c__DisplayClass7_0<int, int, FourBitNumber>..ctor
	|-Enumerable.<>c__DisplayClass7_0<int, int, SevenBitNumber>..ctor
	|-Enumerable.<>c__DisplayClass7_0<int, int, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, Debugging.EntityInfo, Debugging.EntityInfo>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, PathFinder.Point, PathFinder.Point>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, Option, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, InventoryItem, InventoryItem>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, InventoryRecipe, InventoryRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, bool, bool>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, KeyValuePair<object, int>, KeyValuePair<object, int>>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, int, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, Int32Enum, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, long, long>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, Debugging.EntityInfo>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, PathFinder.Point>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, InventoryItem>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, InventoryRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, bool>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, KeyValuePair<object, int>>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, long>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, Resolution>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, float, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, Resolution, Resolution>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, FourBitNumber, FourBitNumber>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, SevenBitNumber, SevenBitNumber>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, PlayerItemRecipe, PlayerItemRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, PlayerItemRecipe.Ingredient, PlayerItemRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, ProjectileWeaponMod.Modifier, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, Option, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryItemId, InventoryItemId>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryItem, InventoryItemId>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryItem, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryItem, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryItem, uint>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryRecipe, PlayerItemRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryRecipe.Ingredient, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, int, FourBitNumber>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, int, SevenBitNumber>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, int, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, Int32Enum, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, object, Debugging.EntityInfo>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, object, PathFinder.Point>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, object, ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, object, Option>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, object, InventoryItem>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, object, InventoryRecipe.Ingredient>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, object, InventoryRecipe>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, object, bool>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, object, KeyValuePair<object, int>>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, object, int>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, object, Int32Enum>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, object, long>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, object, object>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, object, float>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, object, Resolution>..ctor
	|-Enumerable.<>c__DisplayClass7_0<object, uint, uint>..ctor
	*/

	internal TResult <CombineSelectors>b__0(TSource x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144D2C0 Offset: 0x144B8C0 VA: 0x18144D2C0
	|-Enumerable.<>c__DisplayClass7_0<BurstCloth.Chain, FourBitNumber, FourBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<BurstCloth.Chain, SevenBitNumber, SevenBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe.Ingredient, FourBitNumber, FourBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe.Ingredient, SevenBitNumber, SevenBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, bool, bool>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, bool, bool>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, bool, bool>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, bool, bool>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, FourBitNumber, FourBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, SevenBitNumber, SevenBitNumber>.<CombineSelectors>b__0
	|
	|-RVA: 0x144BC90 Offset: 0x144A290 VA: 0x18144BC90
	|-Enumerable.<>c__DisplayClass7_0<BurstCloth.Chain, int, FourBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<BurstCloth.Chain, int, SevenBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<BurstCloth.Chain, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe.Ingredient, int, FourBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe.Ingredient, int, SevenBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe.Ingredient, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, Int32Enum, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, Int32Enum, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, Int32Enum, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<int, int, FourBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<int, int, SevenBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<int, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, Int32Enum, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, int, FourBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, int, SevenBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, Int32Enum, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, uint, uint>.<CombineSelectors>b__0
	|
	|-RVA: 0x19F0C40 Offset: 0x19EF240 VA: 0x1819F0C40
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, Debugging.EntityInfo, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, KeyValuePair<object, int>, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x19F0690 Offset: 0x19EEC90 VA: 0x1819F0690
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, PathFinder.Point, PathFinder.Point>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, long, long>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, PathFinder.Point>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, bool>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, long>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, float>.<CombineSelectors>b__0
	|
	|-RVA: 0x19F09C0 Offset: 0x19EEFC0 VA: 0x1819F09C0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, Resolution, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x19F07C0 Offset: 0x19EEDC0 VA: 0x1819F07C0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, Option, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, InventoryItem, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x19F05C0 Offset: 0x19EEBC0 VA: 0x1819F05C0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|
	|-RVA: 0x19F0890 Offset: 0x19EEE90 VA: 0x1819F0890
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, bool, bool>.<CombineSelectors>b__0
	|
	|-RVA: 0x19F0A90 Offset: 0x19EF090 VA: 0x1819F0A90
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, Int32Enum, Int32Enum>.<CombineSelectors>b__0
	|
	|-RVA: 0x19F0D00 Offset: 0x19EF300 VA: 0x1819F0D00
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x19F0B90 Offset: 0x19EF190 VA: 0x1819F0B90
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x19F0710 Offset: 0x19EED10 VA: 0x1819F0710
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x19F0910 Offset: 0x19EEF10 VA: 0x1819F0910
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, InventoryRecipe>.<CombineSelectors>b__0
	|
	|-RVA: 0x19F0B10 Offset: 0x19EF110 VA: 0x1819F0B10
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, float, float>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C770 Offset: 0x144AD70 VA: 0x18144C770
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, Debugging.EntityInfo, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, KeyValuePair<object, int>, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, Debugging.EntityInfo, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, KeyValuePair<object, int>, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, Debugging.EntityInfo, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, KeyValuePair<object, int>, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x144BB70 Offset: 0x144A170 VA: 0x18144BB70
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, PathFinder.Point, PathFinder.Point>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, long, long>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, PathFinder.Point>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, bool>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, long>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<DictionaryEntry, object, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, PathFinder.Point, PathFinder.Point>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, long, long>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, PathFinder.Point>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, bool>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, long>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, PathFinder.Point, PathFinder.Point>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, long, long>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, PathFinder.Point>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, bool>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, long>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, float>.<CombineSelectors>b__0
	|
	|-RVA: 0x144BBE0 Offset: 0x144A1E0 VA: 0x18144BBE0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, Resolution, Resolution>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, Resolution, Resolution>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, Resolution, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144BF50 Offset: 0x144A550 VA: 0x18144BF50
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, Option, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, InventoryItem, InventoryItem>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, Option, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, InventoryItem, InventoryItem>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, Option, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, InventoryItem, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C9C0 Offset: 0x144AFC0 VA: 0x18144C9C0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D9A0 Offset: 0x144BFA0 VA: 0x18144D9A0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, bool, bool>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, bool, bool>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, bool, bool>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C4E0 Offset: 0x144AAE0 VA: 0x18144C4E0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, Int32Enum, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, Int32Enum, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, Int32Enum, Int32Enum>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C310 Offset: 0x144A910 VA: 0x18144C310
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x144DFB0 Offset: 0x144C5B0 VA: 0x18144DFB0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, Resolution>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, Resolution>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C930 Offset: 0x144AF30 VA: 0x18144C930
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, InventoryItem>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, InventoryItem>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D020 Offset: 0x144B620 VA: 0x18144D020
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, InventoryRecipe>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D320 Offset: 0x144B920 VA: 0x18144D320
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, float, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, float, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, float, float>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C550 Offset: 0x144AB50 VA: 0x18144C550
	|-Enumerable.<>c__DisplayClass7_0<Option, Option, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, Option, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, InventoryItem, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x144CB10 Offset: 0x144B110 VA: 0x18144CB10
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, Debugging.EntityInfo, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, KeyValuePair<object, int>, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E200 Offset: 0x144C800 VA: 0x18144E200
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, FourBitNumber, FourBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, SevenBitNumber, SevenBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, bool, bool>.<CombineSelectors>b__0
	|
	|-RVA: 0x144CDB0 Offset: 0x144B3B0 VA: 0x18144CDB0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, PathFinder.Point, PathFinder.Point>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, long, long>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, PathFinder.Point>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, bool>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, long>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, object>.<CombineSelectors>b__0
	|
	|-RVA: 0x144DB90 Offset: 0x144C190 VA: 0x18144DB90
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, Resolution, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144BE50 Offset: 0x144A450 VA: 0x18144BE50
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, Option, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, InventoryItem, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D610 Offset: 0x144BC10 VA: 0x18144D610
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|
	|-RVA: 0x144DD20 Offset: 0x144C320 VA: 0x18144DD20
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, int, FourBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, int, SevenBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, Int32Enum, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, int, int>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E9B0 Offset: 0x144CFB0 VA: 0x18144E9B0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x144DA10 Offset: 0x144C010 VA: 0x18144DA10
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D140 Offset: 0x144B740 VA: 0x18144D140
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E8C0 Offset: 0x144CEC0 VA: 0x18144E8C0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, InventoryRecipe>.<CombineSelectors>b__0
	|
	|-RVA: 0x144EA90 Offset: 0x144D090 VA: 0x18144EA90
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, float, float>.<CombineSelectors>b__0
	|
	|-RVA: 0x144CF90 Offset: 0x144B590 VA: 0x18144CF90
	|-Enumerable.<>c__DisplayClass7_0<Achievement, Debugging.EntityInfo, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, KeyValuePair<object, int>, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, Debugging.EntityInfo, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, KeyValuePair<object, int>, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, Debugging.EntityInfo, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, KeyValuePair<object, int>, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, Debugging.EntityInfo, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, KeyValuePair<object, int>, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, PlayerItemRecipe, PlayerItemRecipe>.<CombineSelectors>b__0
	|
	|-RVA: 0x144BD70 Offset: 0x144A370 VA: 0x18144BD70
	|-Enumerable.<>c__DisplayClass7_0<Achievement, PathFinder.Point, PathFinder.Point>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, long, long>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, PathFinder.Point>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, bool>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, long>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, PathFinder.Point, PathFinder.Point>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, long, long>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, PathFinder.Point>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, bool>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, long>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, PathFinder.Point, PathFinder.Point>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, long, long>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, PathFinder.Point>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, bool>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, long>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, PathFinder.Point, PathFinder.Point>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, long, long>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, PathFinder.Point>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, bool>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, long>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, PlayerItemRecipe.Ingredient, PlayerItemRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryItemId, InventoryItemId>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, object, PathFinder.Point>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, object, bool>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, object, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, object, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, object, long>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, object, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, object, float>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C3A0 Offset: 0x144A9A0 VA: 0x18144C3A0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, Resolution, Resolution>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, Resolution, Resolution>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, Resolution, Resolution>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, Resolution, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144CA70 Offset: 0x144B070 VA: 0x18144CA70
	|-Enumerable.<>c__DisplayClass7_0<Achievement, Option, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, InventoryItem, InventoryItem>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, Option, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, InventoryItem, InventoryItem>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, Option, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, InventoryItem, InventoryItem>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, Option, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, InventoryItem, InventoryItem>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, Option, Option>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C440 Offset: 0x144AA40 VA: 0x18144C440
	|-Enumerable.<>c__DisplayClass7_0<Achievement, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C810 Offset: 0x144AE10 VA: 0x18144C810
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x144DC90 Offset: 0x144C290 VA: 0x18144DC90
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, Resolution>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D230 Offset: 0x144B830 VA: 0x18144D230
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, InventoryItem>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C200 Offset: 0x144A800 VA: 0x18144C200
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, InventoryRecipe>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C000 Offset: 0x144A600 VA: 0x18144C000
	|-Enumerable.<>c__DisplayClass7_0<Achievement, float, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, float, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, float, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, float, float>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E180 Offset: 0x144C780 VA: 0x18144E180
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E2C0 Offset: 0x144C8C0 VA: 0x18144E2C0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144CF00 Offset: 0x144B500 VA: 0x18144CF00
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x144CE70 Offset: 0x144B470 VA: 0x18144CE70
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, InventoryRecipe>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D4F0 Offset: 0x144BAF0 VA: 0x18144D4F0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, ServerInfo, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, ServerInfo, object>.<CombineSelectors>b__0
	|
	|-RVA: 0x144DAF0 Offset: 0x144C0F0 VA: 0x18144DAF0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, Debugging.EntityInfo, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, KeyValuePair<object, int>, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E100 Offset: 0x144C700 VA: 0x18144E100
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, FourBitNumber, FourBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, SevenBitNumber, SevenBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, bool, bool>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C180 Offset: 0x144A780 VA: 0x18144C180
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, PathFinder.Point, PathFinder.Point>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, long, long>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, PathFinder.Point>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, bool>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, long>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, float>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C610 Offset: 0x144AC10 VA: 0x18144C610
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, Resolution, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E800 Offset: 0x144CE00 VA: 0x18144E800
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|
	|-RVA: 0x144CCA0 Offset: 0x144B2A0 VA: 0x18144CCA0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, int, FourBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, int, SevenBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, Int32Enum, Int32Enum>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D710 Offset: 0x144BD10 VA: 0x18144D710
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D7B0 Offset: 0x144BDB0 VA: 0x18144D7B0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C0E0 Offset: 0x144A6E0 VA: 0x18144C0E0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D390 Offset: 0x144B990 VA: 0x18144D390
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, InventoryRecipe>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D0C0 Offset: 0x144B6C0 VA: 0x18144D0C0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, float, float>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D910 Offset: 0x144BF10 VA: 0x18144D910
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe, PlayerItemRecipe, object>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C290 Offset: 0x144A890 VA: 0x18144C290
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe, object, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, PathFinder.Point, PathFinder.Point>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, long, long>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, PathFinder.Point>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, bool>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, long>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, float>.<CombineSelectors>b__0
	|
	|-RVA: 0x144BAC0 Offset: 0x144A0C0 VA: 0x18144BAC0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, Debugging.EntityInfo, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, KeyValuePair<object, int>, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D850 Offset: 0x144BE50 VA: 0x18144D850
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, Resolution, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D430 Offset: 0x144BA30 VA: 0x18144D430
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, Option, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, InventoryItem, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E040 Offset: 0x144C640 VA: 0x18144E040
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E670 Offset: 0x144CC70 VA: 0x18144E670
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, bool, bool>.<CombineSelectors>b__0
	|
	|-RVA: 0x144BDD0 Offset: 0x144A3D0 VA: 0x18144BDD0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, Int32Enum, Int32Enum>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C890 Offset: 0x144AE90 VA: 0x18144C890
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x144DF10 Offset: 0x144C510 VA: 0x18144DF10
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144DE70 Offset: 0x144C470 VA: 0x18144DE70
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x144CC00 Offset: 0x144B200 VA: 0x18144CC00
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, InventoryRecipe>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E470 Offset: 0x144CA70 VA: 0x18144E470
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, float, float>.<CombineSelectors>b__0
	|
	|-RVA: 0x144BCF0 Offset: 0x144A2F0 VA: 0x18144BCF0
	|-Enumerable.<>c__DisplayClass7_0<DictionaryEntry, KeyValuePair<object, object>, object>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E4F0 Offset: 0x144CAF0 VA: 0x18144E4F0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E350 Offset: 0x144C950 VA: 0x18144E350
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E770 Offset: 0x144CD70 VA: 0x18144E770
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x144DDE0 Offset: 0x144C3E0 VA: 0x18144DDE0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, InventoryRecipe>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E6F0 Offset: 0x144CCF0 VA: 0x18144E6F0
	|-Enumerable.<>c__DisplayClass7_0<object, ProjectileWeaponMod.Modifier, float>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E5F0 Offset: 0x144CBF0 VA: 0x18144E5F0
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryItem, InventoryItemId>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryItem, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryItem, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryItem, uint>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C6D0 Offset: 0x144ACD0 VA: 0x18144C6D0
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryRecipe, PlayerItemRecipe>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C060 Offset: 0x144A660 VA: 0x18144C060
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryRecipe.Ingredient, object>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E570 Offset: 0x144CB70 VA: 0x18144E570
	|-Enumerable.<>c__DisplayClass7_0<object, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x144EB50 Offset: 0x144D150 VA: 0x18144EB50
	|-Enumerable.<>c__DisplayClass7_0<object, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, object, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E3E0 Offset: 0x144C9E0 VA: 0x18144E3E0
	|-Enumerable.<>c__DisplayClass7_0<object, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, object, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x144CD20 Offset: 0x144B320 VA: 0x18144CD20
	|-Enumerable.<>c__DisplayClass7_0<object, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, object, InventoryRecipe>.<CombineSelectors>b__0
	*/

}

private sealed class Enumerable.<SelectManyIterator>d__17<TSource, TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator // TypeDefIndex: 3208
{	private int <>1__state; // 0x0
	private TResult <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable<TSource> source; // 0x0
	public IEnumerable<TSource> <>3__source; // 0x0
	private Func<TSource, IEnumerable<TResult>> selector; // 0x0
	public Func<TSource, IEnumerable<TResult>> <>3__selector; // 0x0
	private IEnumerator<TSource> <>7__wrap1; // 0x0
	private IEnumerator<TResult> <>7__wrap2; // 0x0

	private TResult System.Collections.Generic.IEnumerator<TResult>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144ABD0 Offset: 0x14491D0 VA: 0x18144ABD0
	|-Enumerable.<SelectManyIterator>d__17<object, PlayerItemRecipe>..ctor
	|
	|-RVA: 0x19D42C0 Offset: 0x19D28C0 VA: 0x1819D42C0
	|-Enumerable.<SelectManyIterator>d__17<object, InventoryRecipe>..ctor
	|
	|-RVA: 0x144AB90 Offset: 0x1449190 VA: 0x18144AB90
	|-Enumerable.<SelectManyIterator>d__17<object, byte>..ctor
	|
	|-RVA: 0x144AC10 Offset: 0x1449210 VA: 0x18144AC10
	|-Enumerable.<SelectManyIterator>d__17<object, object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D3F70 Offset: 0x19D2570 VA: 0x1819D3F70
	|-Enumerable.<SelectManyIterator>d__17<object, PlayerItemRecipe>.System.IDisposable.Dispose
	|-Enumerable.<SelectManyIterator>d__17<object, InventoryRecipe>.System.IDisposable.Dispose
	|-Enumerable.<SelectManyIterator>d__17<object, byte>.System.IDisposable.Dispose
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D31B0 Offset: 0x19D17B0 VA: 0x1819D31B0
	|-Enumerable.<SelectManyIterator>d__17<object, PlayerItemRecipe>.MoveNext
	|
	|-RVA: 0x19D2ED0 Offset: 0x19D14D0 VA: 0x1819D2ED0
	|-Enumerable.<SelectManyIterator>d__17<object, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x19D3750 Offset: 0x19D1D50 VA: 0x1819D3750
	|-Enumerable.<SelectManyIterator>d__17<object, byte>.MoveNext
	|
	|-RVA: 0x19D3480 Offset: 0x19D1A80 VA: 0x1819D3480
	|-Enumerable.<SelectManyIterator>d__17<object, object>.MoveNext
	*/

	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D4130 Offset: 0x19D2730 VA: 0x1819D4130
	|-Enumerable.<SelectManyIterator>d__17<object, PlayerItemRecipe>.<>m__Finally1
	|
	|-RVA: 0x19D40E0 Offset: 0x19D26E0 VA: 0x1819D40E0
	|-Enumerable.<SelectManyIterator>d__17<object, InventoryRecipe>.<>m__Finally1
	|
	|-RVA: 0x19D4040 Offset: 0x19D2640 VA: 0x1819D4040
	|-Enumerable.<SelectManyIterator>d__17<object, byte>.<>m__Finally1
	|
	|-RVA: 0x19D4090 Offset: 0x19D2690 VA: 0x1819D4090
	|-Enumerable.<SelectManyIterator>d__17<object, object>.<>m__Finally1
	*/

	private void <>m__Finally2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D4270 Offset: 0x19D2870 VA: 0x1819D4270
	|-Enumerable.<SelectManyIterator>d__17<object, PlayerItemRecipe>.<>m__Finally2
	|
	|-RVA: 0x19D41D0 Offset: 0x19D27D0 VA: 0x1819D41D0
	|-Enumerable.<SelectManyIterator>d__17<object, InventoryRecipe>.<>m__Finally2
	|
	|-RVA: 0x19D4180 Offset: 0x19D2780 VA: 0x1819D4180
	|-Enumerable.<SelectManyIterator>d__17<object, byte>.<>m__Finally2
	|
	|-RVA: 0x19D4220 Offset: 0x19D2820 VA: 0x1819D4220
	|-Enumerable.<SelectManyIterator>d__17<object, object>.<>m__Finally2
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB11B00 Offset: 0xB10100 VA: 0x180B11B00
	|-Enumerable.<SelectManyIterator>d__17<object, PlayerItemRecipe>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0x11283A0 Offset: 0x11269A0 VA: 0x1811283A0
	|-Enumerable.<SelectManyIterator>d__17<object, InventoryRecipe>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0xA116F0 Offset: 0xA0FCF0 VA: 0x180A116F0
	|-Enumerable.<SelectManyIterator>d__17<object, byte>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D3DE0 Offset: 0x19D23E0 VA: 0x1819D3DE0
	|-Enumerable.<SelectManyIterator>d__17<object, PlayerItemRecipe>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D3D90 Offset: 0x19D2390 VA: 0x1819D3D90
	|-Enumerable.<SelectManyIterator>d__17<object, InventoryRecipe>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D3E30 Offset: 0x19D2430 VA: 0x1819D3E30
	|-Enumerable.<SelectManyIterator>d__17<object, byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D3D40 Offset: 0x19D2340 VA: 0x1819D3D40
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D3F20 Offset: 0x19D2520 VA: 0x1819D3F20
	|-Enumerable.<SelectManyIterator>d__17<object, PlayerItemRecipe>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D3ED0 Offset: 0x19D24D0 VA: 0x1819D3ED0
	|-Enumerable.<SelectManyIterator>d__17<object, InventoryRecipe>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D3E80 Offset: 0x19D2480 VA: 0x1819D3E80
	|-Enumerable.<SelectManyIterator>d__17<object, byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D3A10 Offset: 0x19D2010 VA: 0x1819D3A10
	|-Enumerable.<SelectManyIterator>d__17<object, PlayerItemRecipe>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0x19D3AD0 Offset: 0x19D20D0 VA: 0x1819D3AD0
	|-Enumerable.<SelectManyIterator>d__17<object, InventoryRecipe>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0x19D3C50 Offset: 0x19D2250 VA: 0x1819D3C50
	|-Enumerable.<SelectManyIterator>d__17<object, byte>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0x19D3B90 Offset: 0x19D2190 VA: 0x1819D3B90
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D3D10 Offset: 0x19D2310 VA: 0x1819D3D10
	|-Enumerable.<SelectManyIterator>d__17<object, PlayerItemRecipe>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<SelectManyIterator>d__17<object, InventoryRecipe>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<SelectManyIterator>d__17<object, byte>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.Collections.IEnumerable.GetEnumerator
	*/

}

private sealed class Enumerable.<TakeIterator>d__25<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 3209
{	private int <>1__state; // 0x0
	private TSource <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private int count; // 0x0
	public int <>3__count; // 0x0
	private IEnumerable<TSource> source; // 0x0
	public IEnumerable<TSource> <>3__source; // 0x0
	private IEnumerator<TSource> <>7__wrap1; // 0x0

	private TSource System.Collections.Generic.IEnumerator<TSource>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D5BC0 Offset: 0x19D41C0 VA: 0x1819D5BC0
	|-Enumerable.<TakeIterator>d__25<Option>..ctor
	|-Enumerable.<TakeIterator>d__25<InventoryItem>..ctor
	|
	|-RVA: 0x144AB90 Offset: 0x1449190 VA: 0x18144AB90
	|-Enumerable.<TakeIterator>d__25<byte>..ctor
	|
	|-RVA: 0x144AC10 Offset: 0x1449210 VA: 0x18144AC10
	|-Enumerable.<TakeIterator>d__25<double>..ctor
	|-Enumerable.<TakeIterator>d__25<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A8D0 Offset: 0x1448ED0 VA: 0x18144A8D0
	|-Enumerable.<TakeIterator>d__25<Option>.System.IDisposable.Dispose
	|-Enumerable.<TakeIterator>d__25<InventoryItem>.System.IDisposable.Dispose
	|-Enumerable.<TakeIterator>d__25<byte>.System.IDisposable.Dispose
	|-Enumerable.<TakeIterator>d__25<double>.System.IDisposable.Dispose
	|-Enumerable.<TakeIterator>d__25<object>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D4D90 Offset: 0x19D3390 VA: 0x1819D4D90
	|-Enumerable.<TakeIterator>d__25<Option>.MoveNext
	|
	|-RVA: 0x19D52F0 Offset: 0x19D38F0 VA: 0x1819D52F0
	|-Enumerable.<TakeIterator>d__25<InventoryItem>.MoveNext
	|
	|-RVA: 0x19D5130 Offset: 0x19D3730 VA: 0x1819D5130
	|-Enumerable.<TakeIterator>d__25<byte>.MoveNext
	|
	|-RVA: 0x19D4F70 Offset: 0x19D3570 VA: 0x1819D4F70
	|-Enumerable.<TakeIterator>d__25<double>.MoveNext
	|
	|-RVA: 0x19D54D0 Offset: 0x19D3AD0 VA: 0x1819D54D0
	|-Enumerable.<TakeIterator>d__25<object>.MoveNext
	*/

	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D5A80 Offset: 0x19D4080 VA: 0x1819D5A80
	|-Enumerable.<TakeIterator>d__25<Option>.<>m__Finally1
	|
	|-RVA: 0x19D5B20 Offset: 0x19D4120 VA: 0x1819D5B20
	|-Enumerable.<TakeIterator>d__25<InventoryItem>.<>m__Finally1
	|
	|-RVA: 0x19D5A30 Offset: 0x19D4030 VA: 0x1819D5A30
	|-Enumerable.<TakeIterator>d__25<byte>.<>m__Finally1
	|
	|-RVA: 0x19D5B70 Offset: 0x19D4170 VA: 0x1819D5B70
	|-Enumerable.<TakeIterator>d__25<double>.<>m__Finally1
	|
	|-RVA: 0x19D5AD0 Offset: 0x19D40D0 VA: 0x1819D5AD0
	|-Enumerable.<TakeIterator>d__25<object>.<>m__Finally1
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176B310 Offset: 0x1769910 VA: 0x18176B310
	|-Enumerable.<TakeIterator>d__25<Option>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|-Enumerable.<TakeIterator>d__25<InventoryItem>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0xA116F0 Offset: 0xA0FCF0 VA: 0x180A116F0
	|-Enumerable.<TakeIterator>d__25<byte>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0xB3C170 Offset: 0xB3A770 VA: 0x180B3C170
	|-Enumerable.<TakeIterator>d__25<double>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<TakeIterator>d__25<object>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D5990 Offset: 0x19D3F90 VA: 0x1819D5990
	|-Enumerable.<TakeIterator>d__25<Option>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D5940 Offset: 0x19D3F40 VA: 0x1819D5940
	|-Enumerable.<TakeIterator>d__25<InventoryItem>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D58F0 Offset: 0x19D3EF0 VA: 0x1819D58F0
	|-Enumerable.<TakeIterator>d__25<byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D58A0 Offset: 0x19D3EA0 VA: 0x1819D58A0
	|-Enumerable.<TakeIterator>d__25<double>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D59E0 Offset: 0x19D3FE0 VA: 0x1819D59E0
	|-Enumerable.<TakeIterator>d__25<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176B800 Offset: 0x1769E00 VA: 0x18176B800
	|-Enumerable.<TakeIterator>d__25<Option>.System.Collections.IEnumerator.get_Current
	|-Enumerable.<TakeIterator>d__25<InventoryItem>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D4C50 Offset: 0x19D3250 VA: 0x1819D4C50
	|-Enumerable.<TakeIterator>d__25<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x176B720 Offset: 0x1769D20 VA: 0x18176B720
	|-Enumerable.<TakeIterator>d__25<double>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<TakeIterator>d__25<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D5740 Offset: 0x19D3D40 VA: 0x1819D5740
	|-Enumerable.<TakeIterator>d__25<Option>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|-Enumerable.<TakeIterator>d__25<InventoryItem>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x19D57F0 Offset: 0x19D3DF0 VA: 0x1819D57F0
	|-Enumerable.<TakeIterator>d__25<byte>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x19D5690 Offset: 0x19D3C90 VA: 0x1819D5690
	|-Enumerable.<TakeIterator>d__25<double>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|-Enumerable.<TakeIterator>d__25<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19B4580 Offset: 0x19B2B80 VA: 0x1819B4580
	|-Enumerable.<TakeIterator>d__25<Option>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<TakeIterator>d__25<InventoryItem>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<TakeIterator>d__25<byte>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<TakeIterator>d__25<double>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<TakeIterator>d__25<object>.System.Collections.IEnumerable.GetEnumerator
	*/

}

private sealed class Enumerable.<TakeWhileIterator>d__27<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 3210
{	private int <>1__state; // 0x0
	private TSource <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable<TSource> source; // 0x0
	public IEnumerable<TSource> <>3__source; // 0x0
	private Func<TSource, bool> predicate; // 0x0
	public Func<TSource, bool> <>3__predicate; // 0x0
	private IEnumerator<TSource> <>7__wrap1; // 0x0

	private TSource System.Collections.Generic.IEnumerator<TSource>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144AC10 Offset: 0x1449210 VA: 0x18144AC10
	|-Enumerable.<TakeWhileIterator>d__27<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A8D0 Offset: 0x1448ED0 VA: 0x18144A8D0
	|-Enumerable.<TakeWhileIterator>d__27<object>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D5C00 Offset: 0x19D4200 VA: 0x1819D5C00
	|-Enumerable.<TakeWhileIterator>d__27<object>.MoveNext
	*/

	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D5E40 Offset: 0x19D4440 VA: 0x1819D5E40
	|-Enumerable.<TakeWhileIterator>d__27<object>.<>m__Finally1
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<TakeWhileIterator>d__27<object>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D5DF0 Offset: 0x19D43F0 VA: 0x1819D5DF0
	|-Enumerable.<TakeWhileIterator>d__27<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<TakeWhileIterator>d__27<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144B470 Offset: 0x1449A70 VA: 0x18144B470
	|-Enumerable.<TakeWhileIterator>d__27<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144B5F0 Offset: 0x1449BF0 VA: 0x18144B5F0
	|-Enumerable.<TakeWhileIterator>d__27<object>.System.Collections.IEnumerable.GetEnumerator
	*/

}

private sealed class Enumerable.<SkipIterator>d__31<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 3211
{	private int <>1__state; // 0x0
	private TSource <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable<TSource> source; // 0x0
	public IEnumerable<TSource> <>3__source; // 0x0
	private int count; // 0x0
	public int <>3__count; // 0x0
	private IEnumerator<TSource> <e>5__1; // 0x0

	private TSource System.Collections.Generic.IEnumerator<TSource>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144AB90 Offset: 0x1449190 VA: 0x18144AB90
	|-Enumerable.<SkipIterator>d__31<byte>..ctor
	|
	|-RVA: 0x144AC10 Offset: 0x1449210 VA: 0x18144AC10
	|-Enumerable.<SkipIterator>d__31<double>..ctor
	|-Enumerable.<SkipIterator>d__31<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A8D0 Offset: 0x1448ED0 VA: 0x18144A8D0
	|-Enumerable.<SkipIterator>d__31<byte>.System.IDisposable.Dispose
	|-Enumerable.<SkipIterator>d__31<double>.System.IDisposable.Dispose
	|-Enumerable.<SkipIterator>d__31<object>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D47B0 Offset: 0x19D2DB0 VA: 0x1819D47B0
	|-Enumerable.<SkipIterator>d__31<byte>.MoveNext
	|
	|-RVA: 0x19D4560 Offset: 0x19D2B60 VA: 0x1819D4560
	|-Enumerable.<SkipIterator>d__31<double>.MoveNext
	|
	|-RVA: 0x19D4300 Offset: 0x19D2900 VA: 0x1819D4300
	|-Enumerable.<SkipIterator>d__31<object>.MoveNext
	*/

	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D4D40 Offset: 0x19D3340 VA: 0x1819D4D40
	|-Enumerable.<SkipIterator>d__31<byte>.<>m__Finally1
	|
	|-RVA: 0x19D4CF0 Offset: 0x19D32F0 VA: 0x1819D4CF0
	|-Enumerable.<SkipIterator>d__31<double>.<>m__Finally1
	|
	|-RVA: 0x19D4CA0 Offset: 0x19D32A0 VA: 0x1819D4CA0
	|-Enumerable.<SkipIterator>d__31<object>.<>m__Finally1
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA116F0 Offset: 0xA0FCF0 VA: 0x180A116F0
	|-Enumerable.<SkipIterator>d__31<byte>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0xB3C170 Offset: 0xB3A770 VA: 0x180B3C170
	|-Enumerable.<SkipIterator>d__31<double>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<SkipIterator>d__31<object>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D4B60 Offset: 0x19D3160 VA: 0x1819D4B60
	|-Enumerable.<SkipIterator>d__31<byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D4C00 Offset: 0x19D3200 VA: 0x1819D4C00
	|-Enumerable.<SkipIterator>d__31<double>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D4BB0 Offset: 0x19D31B0 VA: 0x1819D4BB0
	|-Enumerable.<SkipIterator>d__31<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D4C50 Offset: 0x19D3250 VA: 0x1819D4C50
	|-Enumerable.<SkipIterator>d__31<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x176B720 Offset: 0x1769D20 VA: 0x18176B720
	|-Enumerable.<SkipIterator>d__31<double>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<SkipIterator>d__31<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D4AB0 Offset: 0x19D30B0 VA: 0x1819D4AB0
	|-Enumerable.<SkipIterator>d__31<byte>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x19D4A00 Offset: 0x19D3000 VA: 0x1819D4A00
	|-Enumerable.<SkipIterator>d__31<double>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|-Enumerable.<SkipIterator>d__31<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19B4580 Offset: 0x19B2B80 VA: 0x1819B4580
	|-Enumerable.<SkipIterator>d__31<byte>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<SkipIterator>d__31<double>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<SkipIterator>d__31<object>.System.Collections.IEnumerable.GetEnumerator
	*/

}

private sealed class Enumerable.<ConcatIterator>d__59<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 3212
{	private int <>1__state; // 0x0
	private TSource <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable<TSource> first; // 0x0
	public IEnumerable<TSource> <>3__first; // 0x0
	private IEnumerable<TSource> second; // 0x0
	public IEnumerable<TSource> <>3__second; // 0x0
	private IEnumerator<TSource> <>7__wrap1; // 0x0

	private TSource System.Collections.Generic.IEnumerator<TSource>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144AB90 Offset: 0x1449190 VA: 0x18144AB90
	|-Enumerable.<ConcatIterator>d__59<byte>..ctor
	|
	|-RVA: 0x144AC10 Offset: 0x1449210 VA: 0x18144AC10
	|-Enumerable.<ConcatIterator>d__59<long>..ctor
	|-Enumerable.<ConcatIterator>d__59<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144B7B0 Offset: 0x1449DB0 VA: 0x18144B7B0
	|-Enumerable.<ConcatIterator>d__59<byte>.System.IDisposable.Dispose
	|-Enumerable.<ConcatIterator>d__59<long>.System.IDisposable.Dispose
	|-Enumerable.<ConcatIterator>d__59<object>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144AC50 Offset: 0x1449250 VA: 0x18144AC50
	|-Enumerable.<ConcatIterator>d__59<byte>.MoveNext
	|
	|-RVA: 0x144B1C0 Offset: 0x14497C0 VA: 0x18144B1C0
	|-Enumerable.<ConcatIterator>d__59<long>.MoveNext
	|
	|-RVA: 0x144AF00 Offset: 0x1449500 VA: 0x18144AF00
	|-Enumerable.<ConcatIterator>d__59<object>.MoveNext
	*/

	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144B980 Offset: 0x1449F80 VA: 0x18144B980
	|-Enumerable.<ConcatIterator>d__59<byte>.<>m__Finally1
	|
	|-RVA: 0x144B930 Offset: 0x1449F30 VA: 0x18144B930
	|-Enumerable.<ConcatIterator>d__59<long>.<>m__Finally1
	|
	|-RVA: 0x144B8E0 Offset: 0x1449EE0 VA: 0x18144B8E0
	|-Enumerable.<ConcatIterator>d__59<object>.<>m__Finally1
	*/

	private void <>m__Finally2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144BA20 Offset: 0x144A020 VA: 0x18144BA20
	|-Enumerable.<ConcatIterator>d__59<byte>.<>m__Finally2
	|
	|-RVA: 0x144BA70 Offset: 0x144A070 VA: 0x18144BA70
	|-Enumerable.<ConcatIterator>d__59<long>.<>m__Finally2
	|
	|-RVA: 0x144B9D0 Offset: 0x1449FD0 VA: 0x18144B9D0
	|-Enumerable.<ConcatIterator>d__59<object>.<>m__Finally2
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA116F0 Offset: 0xA0FCF0 VA: 0x180A116F0
	|-Enumerable.<ConcatIterator>d__59<byte>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<ConcatIterator>d__59<long>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|-Enumerable.<ConcatIterator>d__59<object>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144B620 Offset: 0x1449C20 VA: 0x18144B620
	|-Enumerable.<ConcatIterator>d__59<byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x144B6C0 Offset: 0x1449CC0 VA: 0x18144B6C0
	|-Enumerable.<ConcatIterator>d__59<long>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x144B670 Offset: 0x1449C70 VA: 0x18144B670
	|-Enumerable.<ConcatIterator>d__59<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144B710 Offset: 0x1449D10 VA: 0x18144B710
	|-Enumerable.<ConcatIterator>d__59<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x144B760 Offset: 0x1449D60 VA: 0x18144B760
	|-Enumerable.<ConcatIterator>d__59<long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<ConcatIterator>d__59<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144B530 Offset: 0x1449B30 VA: 0x18144B530
	|-Enumerable.<ConcatIterator>d__59<byte>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x144B470 Offset: 0x1449A70 VA: 0x18144B470
	|-Enumerable.<ConcatIterator>d__59<long>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|-Enumerable.<ConcatIterator>d__59<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144B5F0 Offset: 0x1449BF0 VA: 0x18144B5F0
	|-Enumerable.<ConcatIterator>d__59<byte>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<ConcatIterator>d__59<long>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<ConcatIterator>d__59<object>.System.Collections.IEnumerable.GetEnumerator
	*/

}

private sealed class Enumerable.<ZipIterator>d__65<TFirst, TSecond, TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator // TypeDefIndex: 3213
{	private int <>1__state; // 0x0
	private TResult <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable<TFirst> first; // 0x0
	public IEnumerable<TFirst> <>3__first; // 0x0
	private IEnumerable<TSecond> second; // 0x0
	public IEnumerable<TSecond> <>3__second; // 0x0
	private Func<TFirst, TSecond, TResult> resultSelector; // 0x0
	public Func<TFirst, TSecond, TResult> <>3__resultSelector; // 0x0
	private IEnumerator<TFirst> <e1>5__1; // 0x0
	private IEnumerator<TSecond> <e2>5__2; // 0x0

	private TResult System.Collections.Generic.IEnumerator<TResult>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144AC10 Offset: 0x1449210 VA: 0x18144AC10
	|-Enumerable.<ZipIterator>d__65<object, long, object>..ctor
	|-Enumerable.<ZipIterator>d__65<object, object, object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D3F70 Offset: 0x19D2570 VA: 0x1819D3F70
	|-Enumerable.<ZipIterator>d__65<object, long, object>.System.IDisposable.Dispose
	|-Enumerable.<ZipIterator>d__65<object, object, object>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D6C60 Offset: 0x19D5260 VA: 0x1819D6C60
	|-Enumerable.<ZipIterator>d__65<object, long, object>.MoveNext
	|
	|-RVA: 0x19D6980 Offset: 0x19D4F80 VA: 0x1819D6980
	|-Enumerable.<ZipIterator>d__65<object, object, object>.MoveNext
	*/

	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D70B0 Offset: 0x19D56B0 VA: 0x1819D70B0
	|-Enumerable.<ZipIterator>d__65<object, long, object>.<>m__Finally1
	|
	|-RVA: 0x19D7100 Offset: 0x19D5700 VA: 0x1819D7100
	|-Enumerable.<ZipIterator>d__65<object, object, object>.<>m__Finally1
	*/

	private void <>m__Finally2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D7150 Offset: 0x19D5750 VA: 0x1819D7150
	|-Enumerable.<ZipIterator>d__65<object, long, object>.<>m__Finally2
	|
	|-RVA: 0x19D71A0 Offset: 0x19D57A0 VA: 0x1819D71A0
	|-Enumerable.<ZipIterator>d__65<object, object, object>.<>m__Finally2
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<ZipIterator>d__65<object, long, object>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|-Enumerable.<ZipIterator>d__65<object, object, object>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D7010 Offset: 0x19D5610 VA: 0x1819D7010
	|-Enumerable.<ZipIterator>d__65<object, long, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D7060 Offset: 0x19D5660 VA: 0x1819D7060
	|-Enumerable.<ZipIterator>d__65<object, object, object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<ZipIterator>d__65<object, long, object>.System.Collections.IEnumerator.get_Current
	|-Enumerable.<ZipIterator>d__65<object, object, object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D6F40 Offset: 0x19D5540 VA: 0x1819D6F40
	|-Enumerable.<ZipIterator>d__65<object, long, object>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|-Enumerable.<ZipIterator>d__65<object, object, object>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D3D10 Offset: 0x19D2310 VA: 0x1819D3D10
	|-Enumerable.<ZipIterator>d__65<object, long, object>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<ZipIterator>d__65<object, object, object>.System.Collections.IEnumerable.GetEnumerator
	*/

}

private sealed class Enumerable.<DistinctIterator>d__68<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 3214
{	private int <>1__state; // 0x0
	private TSource <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEqualityComparer<TSource> comparer; // 0x0
	public IEqualityComparer<TSource> <>3__comparer; // 0x0
	private IEnumerable<TSource> source; // 0x0
	public IEnumerable<TSource> <>3__source; // 0x0
	private Set<TSource> <set>5__1; // 0x0
	private IEnumerator<TSource> <>7__wrap1; // 0x0

	private TSource System.Collections.Generic.IEnumerator<TSource>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D1520 Offset: 0x19CFB20 VA: 0x1819D1520
	|-Enumerable.<DistinctIterator>d__68<ServerInfo>..ctor
	|
	|-RVA: 0x144AC10 Offset: 0x1449210 VA: 0x18144AC10
	|-Enumerable.<DistinctIterator>d__68<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A8D0 Offset: 0x1448ED0 VA: 0x18144A8D0
	|-Enumerable.<DistinctIterator>d__68<ServerInfo>.System.IDisposable.Dispose
	|-Enumerable.<DistinctIterator>d__68<object>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D0DC0 Offset: 0x19CF3C0 VA: 0x1819D0DC0
	|-Enumerable.<DistinctIterator>d__68<ServerInfo>.MoveNext
	|
	|-RVA: 0x19D0B70 Offset: 0x19CF170 VA: 0x1819D0B70
	|-Enumerable.<DistinctIterator>d__68<object>.MoveNext
	*/

	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D14D0 Offset: 0x19CFAD0 VA: 0x1819D14D0
	|-Enumerable.<DistinctIterator>d__68<ServerInfo>.<>m__Finally1
	|
	|-RVA: 0x19D1480 Offset: 0x19CFA80 VA: 0x1819D1480
	|-Enumerable.<DistinctIterator>d__68<object>.<>m__Finally1
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDECE60 Offset: 0xDEB460 VA: 0x180DECE60
	|-Enumerable.<DistinctIterator>d__68<ServerInfo>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<DistinctIterator>d__68<object>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D1350 Offset: 0x19CF950 VA: 0x1819D1350
	|-Enumerable.<DistinctIterator>d__68<ServerInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D13A0 Offset: 0x19CF9A0 VA: 0x1819D13A0
	|-Enumerable.<DistinctIterator>d__68<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D13F0 Offset: 0x19CF9F0 VA: 0x1819D13F0
	|-Enumerable.<DistinctIterator>d__68<ServerInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<DistinctIterator>d__68<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D1190 Offset: 0x19CF790 VA: 0x1819D1190
	|-Enumerable.<DistinctIterator>d__68<ServerInfo>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x19D1260 Offset: 0x19CF860 VA: 0x1819D1260
	|-Enumerable.<DistinctIterator>d__68<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D1320 Offset: 0x19CF920 VA: 0x1819D1320
	|-Enumerable.<DistinctIterator>d__68<ServerInfo>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<DistinctIterator>d__68<object>.System.Collections.IEnumerable.GetEnumerator
	*/

}

private sealed class Enumerable.<UnionIterator>d__71<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 3215
{	private int <>1__state; // 0x0
	private TSource <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEqualityComparer<TSource> comparer; // 0x0
	public IEqualityComparer<TSource> <>3__comparer; // 0x0
	private IEnumerable<TSource> first; // 0x0
	public IEnumerable<TSource> <>3__first; // 0x0
	private Set<TSource> <set>5__1; // 0x0
	private IEnumerable<TSource> second; // 0x0
	public IEnumerable<TSource> <>3__second; // 0x0
	private IEnumerator<TSource> <>7__wrap1; // 0x0

	private TSource System.Collections.Generic.IEnumerator<TSource>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144AB90 Offset: 0x1449190 VA: 0x18144AB90
	|-Enumerable.<UnionIterator>d__71<char>..ctor
	|
	|-RVA: 0x144AC10 Offset: 0x1449210 VA: 0x18144AC10
	|-Enumerable.<UnionIterator>d__71<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144B7B0 Offset: 0x1449DB0 VA: 0x18144B7B0
	|-Enumerable.<UnionIterator>d__71<char>.System.IDisposable.Dispose
	|-Enumerable.<UnionIterator>d__71<object>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D6230 Offset: 0x19D4830 VA: 0x1819D6230
	|-Enumerable.<UnionIterator>d__71<char>.MoveNext
	|
	|-RVA: 0x19D5E90 Offset: 0x19D4490 VA: 0x1819D5E90
	|-Enumerable.<UnionIterator>d__71<object>.MoveNext
	*/

	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D6840 Offset: 0x19D4E40 VA: 0x1819D6840
	|-Enumerable.<UnionIterator>d__71<char>.<>m__Finally1
	|
	|-RVA: 0x19D6890 Offset: 0x19D4E90 VA: 0x1819D6890
	|-Enumerable.<UnionIterator>d__71<object>.<>m__Finally1
	*/

	private void <>m__Finally2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D6930 Offset: 0x19D4F30 VA: 0x1819D6930
	|-Enumerable.<UnionIterator>d__71<char>.<>m__Finally2
	|
	|-RVA: 0x19D68E0 Offset: 0x19D4EE0 VA: 0x1819D68E0
	|-Enumerable.<UnionIterator>d__71<object>.<>m__Finally2
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A580 Offset: 0x1448B80 VA: 0x18144A580
	|-Enumerable.<UnionIterator>d__71<char>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<UnionIterator>d__71<object>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D67A0 Offset: 0x19D4DA0 VA: 0x1819D67A0
	|-Enumerable.<UnionIterator>d__71<char>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D6750 Offset: 0x19D4D50 VA: 0x1819D6750
	|-Enumerable.<UnionIterator>d__71<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D67F0 Offset: 0x19D4DF0 VA: 0x1819D67F0
	|-Enumerable.<UnionIterator>d__71<char>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<UnionIterator>d__71<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D6680 Offset: 0x19D4C80 VA: 0x1819D6680
	|-Enumerable.<UnionIterator>d__71<char>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x19D65B0 Offset: 0x19D4BB0 VA: 0x1819D65B0
	|-Enumerable.<UnionIterator>d__71<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D3D10 Offset: 0x19D2310 VA: 0x1819D3D10
	|-Enumerable.<UnionIterator>d__71<char>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<UnionIterator>d__71<object>.System.Collections.IEnumerable.GetEnumerator
	*/

}

private sealed class Enumerable.<ExceptIterator>d__77<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 3216
{	private int <>1__state; // 0x0
	private TSource <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEqualityComparer<TSource> comparer; // 0x0
	public IEqualityComparer<TSource> <>3__comparer; // 0x0
	private IEnumerable<TSource> second; // 0x0
	public IEnumerable<TSource> <>3__second; // 0x0
	private IEnumerable<TSource> first; // 0x0
	public IEnumerable<TSource> <>3__first; // 0x0
	private Set<TSource> <set>5__1; // 0x0
	private IEnumerator<TSource> <>7__wrap1; // 0x0

	private TSource System.Collections.Generic.IEnumerator<TSource>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144AC10 Offset: 0x1449210 VA: 0x18144AC10
	|-Enumerable.<ExceptIterator>d__77<object>..ctor
	|
	|-RVA: 0x144AB90 Offset: 0x1449190 VA: 0x18144AB90
	|-Enumerable.<ExceptIterator>d__77<float>..ctor
	|
	|-RVA: 0x19D2820 Offset: 0x19D0E20 VA: 0x1819D2820
	|-Enumerable.<ExceptIterator>d__77<Vector2>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A8D0 Offset: 0x1448ED0 VA: 0x18144A8D0
	|-Enumerable.<ExceptIterator>d__77<object>.System.IDisposable.Dispose
	|-Enumerable.<ExceptIterator>d__77<float>.System.IDisposable.Dispose
	|-Enumerable.<ExceptIterator>d__77<Vector2>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D1A00 Offset: 0x19D0000 VA: 0x1819D1A00
	|-Enumerable.<ExceptIterator>d__77<object>.MoveNext
	|
	|-RVA: 0x19D1E90 Offset: 0x19D0490 VA: 0x1819D1E90
	|-Enumerable.<ExceptIterator>d__77<float>.MoveNext
	|
	|-RVA: 0x19D1560 Offset: 0x19CFB60 VA: 0x1819D1560
	|-Enumerable.<ExceptIterator>d__77<Vector2>.MoveNext
	*/

	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D27D0 Offset: 0x19D0DD0 VA: 0x1819D27D0
	|-Enumerable.<ExceptIterator>d__77<object>.<>m__Finally1
	|
	|-RVA: 0x19D2780 Offset: 0x19D0D80 VA: 0x1819D2780
	|-Enumerable.<ExceptIterator>d__77<float>.<>m__Finally1
	|
	|-RVA: 0x19D2730 Offset: 0x19D0D30 VA: 0x1819D2730
	|-Enumerable.<ExceptIterator>d__77<Vector2>.<>m__Finally1
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<ExceptIterator>d__77<object>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0xE73AC0 Offset: 0xE720C0 VA: 0x180E73AC0
	|-Enumerable.<ExceptIterator>d__77<float>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x19D2580 Offset: 0x19D0B80 VA: 0x1819D2580
	|-Enumerable.<ExceptIterator>d__77<Vector2>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D25F0 Offset: 0x19D0BF0 VA: 0x1819D25F0
	|-Enumerable.<ExceptIterator>d__77<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D2640 Offset: 0x19D0C40 VA: 0x1819D2640
	|-Enumerable.<ExceptIterator>d__77<float>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D25A0 Offset: 0x19D0BA0 VA: 0x1819D25A0
	|-Enumerable.<ExceptIterator>d__77<Vector2>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<ExceptIterator>d__77<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D2690 Offset: 0x19D0C90 VA: 0x1819D2690
	|-Enumerable.<ExceptIterator>d__77<float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D26E0 Offset: 0x19D0CE0 VA: 0x1819D26E0
	|-Enumerable.<ExceptIterator>d__77<Vector2>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D24B0 Offset: 0x19D0AB0 VA: 0x1819D24B0
	|-Enumerable.<ExceptIterator>d__77<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x19D23E0 Offset: 0x19D09E0 VA: 0x1819D23E0
	|-Enumerable.<ExceptIterator>d__77<float>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x19D2310 Offset: 0x19D0910 VA: 0x1819D2310
	|-Enumerable.<ExceptIterator>d__77<Vector2>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D1320 Offset: 0x19CF920 VA: 0x1819D1320
	|-Enumerable.<ExceptIterator>d__77<object>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<ExceptIterator>d__77<float>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<ExceptIterator>d__77<Vector2>.System.Collections.IEnumerable.GetEnumerator
	*/

}

private sealed class Enumerable.<ReverseIterator>d__79<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 3217
{	private int <>1__state; // 0x0
	private TSource <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable<TSource> source; // 0x0
	public IEnumerable<TSource> <>3__source; // 0x0
	private Buffer<TSource> <buffer>5__1; // 0x0
	private int <i>5__2; // 0x0

	private TSource System.Collections.Generic.IEnumerator<TSource>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144AB90 Offset: 0x1449190 VA: 0x18144AB90
	|-Enumerable.<ReverseIterator>d__79<char>..ctor
	|
	|-RVA: 0x144AC10 Offset: 0x1449210 VA: 0x18144AC10
	|-Enumerable.<ReverseIterator>d__79<long>..ctor
	|-Enumerable.<ReverseIterator>d__79<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	|-Enumerable.<ReverseIterator>d__79<char>.System.IDisposable.Dispose
	|-Enumerable.<ReverseIterator>d__79<long>.System.IDisposable.Dispose
	|-Enumerable.<ReverseIterator>d__79<object>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D2BC0 Offset: 0x19D11C0 VA: 0x1819D2BC0
	|-Enumerable.<ReverseIterator>d__79<char>.MoveNext
	|
	|-RVA: 0x19D2C80 Offset: 0x19D1280 VA: 0x1819D2C80
	|-Enumerable.<ReverseIterator>d__79<long>.MoveNext
	|
	|-RVA: 0x19D2B00 Offset: 0x19D1100 VA: 0x1819D2B00
	|-Enumerable.<ReverseIterator>d__79<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A580 Offset: 0x1448B80 VA: 0x18144A580
	|-Enumerable.<ReverseIterator>d__79<char>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<ReverseIterator>d__79<long>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|-Enumerable.<ReverseIterator>d__79<object>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D2DE0 Offset: 0x19D13E0 VA: 0x1819D2DE0
	|-Enumerable.<ReverseIterator>d__79<char>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D2D90 Offset: 0x19D1390 VA: 0x1819D2D90
	|-Enumerable.<ReverseIterator>d__79<long>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D2D40 Offset: 0x19D1340 VA: 0x1819D2D40
	|-Enumerable.<ReverseIterator>d__79<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D2E80 Offset: 0x19D1480 VA: 0x1819D2E80
	|-Enumerable.<ReverseIterator>d__79<char>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D2E30 Offset: 0x19D1430 VA: 0x1819D2E30
	|-Enumerable.<ReverseIterator>d__79<long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<ReverseIterator>d__79<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A4D0 Offset: 0x1448AD0 VA: 0x18144A4D0
	|-Enumerable.<ReverseIterator>d__79<char>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x144A420 Offset: 0x1448A20 VA: 0x18144A420
	|-Enumerable.<ReverseIterator>d__79<long>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|-Enumerable.<ReverseIterator>d__79<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A590 Offset: 0x1448B90 VA: 0x18144A590
	|-Enumerable.<ReverseIterator>d__79<char>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<ReverseIterator>d__79<long>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<ReverseIterator>d__79<object>.System.Collections.IEnumerable.GetEnumerator
	*/

}

private sealed class Enumerable.<OfTypeIterator>d__97<TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator // TypeDefIndex: 3218
{	private int <>1__state; // 0x0
	private TResult <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable source; // 0x0
	public IEnumerable <>3__source; // 0x0
	private IEnumerator <>7__wrap1; // 0x0

	private TResult System.Collections.Generic.IEnumerator<TResult>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144AC10 Offset: 0x1449210 VA: 0x18144AC10
	|-Enumerable.<OfTypeIterator>d__97<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A8D0 Offset: 0x1448ED0 VA: 0x18144A8D0
	|-Enumerable.<OfTypeIterator>d__97<object>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D2860 Offset: 0x19D0E60 VA: 0x1819D2860
	|-Enumerable.<OfTypeIterator>d__97<object>.MoveNext
	*/

	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D2AA0 Offset: 0x19D10A0 VA: 0x1819D2AA0
	|-Enumerable.<OfTypeIterator>d__97<object>.<>m__Finally1
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<OfTypeIterator>d__97<object>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D2A50 Offset: 0x19D1050 VA: 0x1819D2A50
	|-Enumerable.<OfTypeIterator>d__97<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<OfTypeIterator>d__97<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A420 Offset: 0x1448A20 VA: 0x18144A420
	|-Enumerable.<OfTypeIterator>d__97<object>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A590 Offset: 0x1448B90 VA: 0x18144A590
	|-Enumerable.<OfTypeIterator>d__97<object>.System.Collections.IEnumerable.GetEnumerator
	*/

}

private sealed class Enumerable.<CastIterator>d__99<TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator // TypeDefIndex: 3219
{	private int <>1__state; // 0x0
	private TResult <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable source; // 0x0
	public IEnumerable <>3__source; // 0x0
	private IEnumerator <>7__wrap1; // 0x0

	private TResult System.Collections.Generic.IEnumerator<TResult>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144AB90 Offset: 0x1449190 VA: 0x18144AB90
	|-Enumerable.<CastIterator>d__99<bool>..ctor
	|-Enumerable.<CastIterator>d__99<byte>..ctor
	|-Enumerable.<CastIterator>d__99<short>..ctor
	|-Enumerable.<CastIterator>d__99<int>..ctor
	|
	|-RVA: 0x144ABD0 Offset: 0x14491D0 VA: 0x18144ABD0
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>..ctor
	|
	|-RVA: 0x144AC10 Offset: 0x1449210 VA: 0x18144AC10
	|-Enumerable.<CastIterator>d__99<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A8D0 Offset: 0x1448ED0 VA: 0x18144A8D0
	|-Enumerable.<CastIterator>d__99<bool>.System.IDisposable.Dispose
	|-Enumerable.<CastIterator>d__99<byte>.System.IDisposable.Dispose
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>.System.IDisposable.Dispose
	|-Enumerable.<CastIterator>d__99<short>.System.IDisposable.Dispose
	|-Enumerable.<CastIterator>d__99<int>.System.IDisposable.Dispose
	|-Enumerable.<CastIterator>d__99<object>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A1B0 Offset: 0x14487B0 VA: 0x18144A1B0
	|-Enumerable.<CastIterator>d__99<bool>.MoveNext
	|
	|-RVA: 0x14498E0 Offset: 0x1447EE0 VA: 0x1814498E0
	|-Enumerable.<CastIterator>d__99<byte>.MoveNext
	|
	|-RVA: 0x1449AA0 Offset: 0x14480A0 VA: 0x181449AA0
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>.MoveNext
	|
	|-RVA: 0x1449FF0 Offset: 0x14485F0 VA: 0x181449FF0
	|-Enumerable.<CastIterator>d__99<short>.MoveNext
	|
	|-RVA: 0x1449C70 Offset: 0x1448270 VA: 0x181449C70
	|-Enumerable.<CastIterator>d__99<int>.MoveNext
	|
	|-RVA: 0x1449E30 Offset: 0x1448430 VA: 0x181449E30
	|-Enumerable.<CastIterator>d__99<object>.MoveNext
	*/

	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144AB30 Offset: 0x1449130 VA: 0x18144AB30
	|-Enumerable.<CastIterator>d__99<bool>.<>m__Finally1
	|
	|-RVA: 0x144A950 Offset: 0x1448F50 VA: 0x18144A950
	|-Enumerable.<CastIterator>d__99<byte>.<>m__Finally1
	|
	|-RVA: 0x144AA10 Offset: 0x1449010 VA: 0x18144AA10
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>.<>m__Finally1
	|
	|-RVA: 0x144AAD0 Offset: 0x14490D0 VA: 0x18144AAD0
	|-Enumerable.<CastIterator>d__99<short>.<>m__Finally1
	|
	|-RVA: 0x144A9B0 Offset: 0x1448FB0 VA: 0x18144A9B0
	|-Enumerable.<CastIterator>d__99<int>.<>m__Finally1
	|
	|-RVA: 0x144AA70 Offset: 0x1449070 VA: 0x18144AA70
	|-Enumerable.<CastIterator>d__99<object>.<>m__Finally1
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA116F0 Offset: 0xA0FCF0 VA: 0x180A116F0
	|-Enumerable.<CastIterator>d__99<bool>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|-Enumerable.<CastIterator>d__99<byte>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0xB11B00 Offset: 0xB10100 VA: 0x180B11B00
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0x144A580 Offset: 0x1448B80 VA: 0x18144A580
	|-Enumerable.<CastIterator>d__99<short>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0x57CA30 Offset: 0x57B030 VA: 0x18057CA30
	|-Enumerable.<CastIterator>d__99<int>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<CastIterator>d__99<object>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A660 Offset: 0x1448C60 VA: 0x18144A660
	|-Enumerable.<CastIterator>d__99<bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x144A700 Offset: 0x1448D00 VA: 0x18144A700
	|-Enumerable.<CastIterator>d__99<byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x144A5C0 Offset: 0x1448BC0 VA: 0x18144A5C0
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x144A6B0 Offset: 0x1448CB0 VA: 0x18144A6B0
	|-Enumerable.<CastIterator>d__99<short>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x144A610 Offset: 0x1448C10 VA: 0x18144A610
	|-Enumerable.<CastIterator>d__99<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x144A750 Offset: 0x1448D50 VA: 0x18144A750
	|-Enumerable.<CastIterator>d__99<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A7A0 Offset: 0x1448DA0 VA: 0x18144A7A0
	|-Enumerable.<CastIterator>d__99<bool>.System.Collections.IEnumerator.get_Current
	|-Enumerable.<CastIterator>d__99<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x144A840 Offset: 0x1448E40 VA: 0x18144A840
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x144A7F0 Offset: 0x1448DF0 VA: 0x18144A7F0
	|-Enumerable.<CastIterator>d__99<short>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x144A890 Offset: 0x1448E90 VA: 0x18144A890
	|-Enumerable.<CastIterator>d__99<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<CastIterator>d__99<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A4D0 Offset: 0x1448AD0 VA: 0x18144A4D0
	|-Enumerable.<CastIterator>d__99<bool>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|-Enumerable.<CastIterator>d__99<byte>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|-Enumerable.<CastIterator>d__99<short>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|-Enumerable.<CastIterator>d__99<int>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0x144A370 Offset: 0x1448970 VA: 0x18144A370
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0x144A420 Offset: 0x1448A20 VA: 0x18144A420
	|-Enumerable.<CastIterator>d__99<object>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A590 Offset: 0x1448B90 VA: 0x18144A590
	|-Enumerable.<CastIterator>d__99<bool>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<CastIterator>d__99<byte>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<CastIterator>d__99<short>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<CastIterator>d__99<int>.System.Collections.IEnumerable.GetEnumerator
	|-Enumerable.<CastIterator>d__99<object>.System.Collections.IEnumerable.GetEnumerator
	*/

}

private sealed class Enumerable.<RangeIterator>d__115 : IEnumerable<int>, IEnumerable, IEnumerator<int>, IDisposable, IEnumerator // TypeDefIndex: 3220
{	private int <>1__state; // 0x10
	private int <>2__current; // 0x14
	private int <>l__initialThreadId; // 0x18
	private int start; // 0x1C
	public int <>3__start; // 0x20
	private int <i>5__1; // 0x24
	private int count; // 0x28
	public int <>3__count; // 0x2C

	private int System.Collections.Generic.IEnumerator<System.Int32>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int System.Collections.Generic.IEnumerator<System.Int32>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator<int> System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

internal abstract class EnumerableSorter<TElement> // TypeDefIndex: 3236
{
	internal abstract void ComputeKeys(TElement[] elements, int count);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-EnumerableSorter<object>.ComputeKeys
	*/

	internal abstract int CompareKeys(int index1, int index2);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-EnumerableSorter<object>.CompareKeys
	*/

	internal int[] Sort(TElement[] elements, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178F350 Offset: 0x178D950 VA: 0x18178F350
	|-EnumerableSorter<Demos.DemoInfo>.Sort
	|
	|-RVA: 0x178F430 Offset: 0x178DA30 VA: 0x18178F430
	|-EnumerableSorter<ServerInfo>.Sort
	|
	|-RVA: 0x178FA50 Offset: 0x178E050 VA: 0x18178FA50
	|-EnumerableSorter<Item>.Sort
	|
	|-RVA: 0x178F970 Offset: 0x178DF70 VA: 0x18178F970
	|-EnumerableSorter<KeyValuePair<object, int>>.Sort
	|
	|-RVA: 0x178F510 Offset: 0x178DB10 VA: 0x18178F510
	|-EnumerableSorter<KeyValuePair<object, long>>.Sort
	|
	|-RVA: 0x178F890 Offset: 0x178DE90 VA: 0x18178F890
	|-EnumerableSorter<KeyValuePair<object, object>>.Sort
	|
	|-RVA: 0x178F5F0 Offset: 0x178DBF0 VA: 0x18178F5F0
	|-EnumerableSorter<double>.Sort
	|
	|-RVA: 0x178F6D0 Offset: 0x178DCD0 VA: 0x18178F6D0
	|-EnumerableSorter<object>.Sort
	|
	|-RVA: 0x178F7B0 Offset: 0x178DDB0 VA: 0x18178F7B0
	|-EnumerableSorter<Resolution>.Sort
	*/

	private void QuickSort(int[] map, int left, int right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178F130 Offset: 0x178D730 VA: 0x18178F130
	|-EnumerableSorter<Demos.DemoInfo>.QuickSort
	|-EnumerableSorter<ServerInfo>.QuickSort
	|-EnumerableSorter<Item>.QuickSort
	|-EnumerableSorter<KeyValuePair<object, int>>.QuickSort
	|-EnumerableSorter<KeyValuePair<object, long>>.QuickSort
	|-EnumerableSorter<KeyValuePair<object, object>>.QuickSort
	|-EnumerableSorter<double>.QuickSort
	|-EnumerableSorter<object>.QuickSort
	|-EnumerableSorter<Resolution>.QuickSort
	*/

	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BC10 Offset: 0xD5A210 VA: 0x180D5BC10
	|-EnumerableSorter<Demos.DemoInfo>..ctor
	|-EnumerableSorter<ServerInfo>..ctor
	|-EnumerableSorter<Item>..ctor
	|-EnumerableSorter<KeyValuePair<object, int>>..ctor
	|-EnumerableSorter<KeyValuePair<object, long>>..ctor
	|-EnumerableSorter<KeyValuePair<object, object>>..ctor
	|-EnumerableSorter<double>..ctor
	|-EnumerableSorter<object>..ctor
	|-EnumerableSorter<Resolution>..ctor
	*/

}

internal class EnumerableSorter<TElement, TKey> : EnumerableSorter<TElement> // TypeDefIndex: 3237
{	internal Func<TElement, TKey> keySelector; // 0x0
	internal IComparer<TKey> comparer; // 0x0
	internal bool descending; // 0x0
	internal EnumerableSorter<TElement> next; // 0x0
	internal TKey[] keys; // 0x0


	internal void .ctor(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending, EnumerableSorter<TElement> next) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x175EC10 Offset: 0x175D210 VA: 0x18175EC10
	|-EnumerableSorter<Demos.DemoInfo, DateTime>..ctor
	|-EnumerableSorter<Demos.DemoInfo, object>..ctor
	|-EnumerableSorter<Demos.DemoInfo, TimeSpan>..ctor
	|-EnumerableSorter<ServerInfo, int>..ctor
	|-EnumerableSorter<ServerInfo, object>..ctor
	|-EnumerableSorter<ServerInfo, uint>..ctor
	|-EnumerableSorter<Item, DateTime>..ctor
	|-EnumerableSorter<KeyValuePair<object, int>, int>..ctor
	|-EnumerableSorter<KeyValuePair<object, long>, long>..ctor
	|-EnumerableSorter<KeyValuePair<object, object>, long>..ctor
	|-EnumerableSorter<double, double>..ctor
	|-EnumerableSorter<object, bool>..ctor
	|-EnumerableSorter<object, DateTime>..ctor
	|-EnumerableSorter<object, DateTimeOffset>..ctor
	|-EnumerableSorter<object, Guid>..ctor
	|-EnumerableSorter<object, int>..ctor
	|-EnumerableSorter<object, Int32Enum>..ctor
	|-EnumerableSorter<object, object>..ctor
	|-EnumerableSorter<object, float>..ctor
	|-EnumerableSorter<object, uint>..ctor
	|-EnumerableSorter<Resolution, int>..ctor
	*/

	internal override void ComputeKeys(TElement[] elements, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178FC40 Offset: 0x178E240 VA: 0x18178FC40
	|-EnumerableSorter<Demos.DemoInfo, DateTime>.ComputeKeys
	|-EnumerableSorter<Demos.DemoInfo, TimeSpan>.ComputeKeys
	|
	|-RVA: 0x178FD90 Offset: 0x178E390 VA: 0x18178FD90
	|-EnumerableSorter<Demos.DemoInfo, object>.ComputeKeys
	|
	|-RVA: 0x17902A0 Offset: 0x178E8A0 VA: 0x1817902A0
	|-EnumerableSorter<ServerInfo, int>.ComputeKeys
	|-EnumerableSorter<ServerInfo, uint>.ComputeKeys
	|
	|-RVA: 0x178FEF0 Offset: 0x178E4F0 VA: 0x18178FEF0
	|-EnumerableSorter<ServerInfo, object>.ComputeKeys
	|
	|-RVA: 0x17900B0 Offset: 0x178E6B0 VA: 0x1817900B0
	|-EnumerableSorter<Item, DateTime>.ComputeKeys
	|
	|-RVA: 0x175E2B0 Offset: 0x175C8B0 VA: 0x18175E2B0
	|-EnumerableSorter<KeyValuePair<object, int>, int>.ComputeKeys
	|
	|-RVA: 0x175E760 Offset: 0x175CD60 VA: 0x18175E760
	|-EnumerableSorter<KeyValuePair<object, long>, long>.ComputeKeys
	|-EnumerableSorter<KeyValuePair<object, object>, long>.ComputeKeys
	|
	|-RVA: 0x175E640 Offset: 0x175CC40 VA: 0x18175E640
	|-EnumerableSorter<double, double>.ComputeKeys
	|
	|-RVA: 0x175E9D0 Offset: 0x175CFD0 VA: 0x18175E9D0
	|-EnumerableSorter<object, bool>.ComputeKeys
	|
	|-RVA: 0x175EAF0 Offset: 0x175D0F0 VA: 0x18175EAF0
	|-EnumerableSorter<object, DateTime>.ComputeKeys
	|
	|-RVA: 0x175E060 Offset: 0x175C660 VA: 0x18175E060
	|-EnumerableSorter<object, DateTimeOffset>.ComputeKeys
	|-EnumerableSorter<object, Guid>.ComputeKeys
	|
	|-RVA: 0x175E3E0 Offset: 0x175C9E0 VA: 0x18175E3E0
	|-EnumerableSorter<object, int>.ComputeKeys
	|-EnumerableSorter<object, Int32Enum>.ComputeKeys
	|-EnumerableSorter<object, uint>.ComputeKeys
	|
	|-RVA: 0x175E8A0 Offset: 0x175CEA0 VA: 0x18175E8A0
	|-EnumerableSorter<object, object>.ComputeKeys
	|
	|-RVA: 0x175E190 Offset: 0x175C790 VA: 0x18175E190
	|-EnumerableSorter<object, float>.ComputeKeys
	|
	|-RVA: 0x175E500 Offset: 0x175CB00 VA: 0x18175E500
	|-EnumerableSorter<Resolution, int>.ComputeKeys
	*/

	internal override int CompareKeys(int index1, int index2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178FB30 Offset: 0x178E130 VA: 0x18178FB30
	|-EnumerableSorter<Demos.DemoInfo, DateTime>.CompareKeys
	|-EnumerableSorter<Item, DateTime>.CompareKeys
	|
	|-RVA: 0x175D6E0 Offset: 0x175BCE0 VA: 0x18175D6E0
	|-EnumerableSorter<Demos.DemoInfo, object>.CompareKeys
	|-EnumerableSorter<ServerInfo, object>.CompareKeys
	|-EnumerableSorter<KeyValuePair<object, long>, long>.CompareKeys
	|-EnumerableSorter<KeyValuePair<object, object>, long>.CompareKeys
	|
	|-RVA: 0x175DC10 Offset: 0x175C210 VA: 0x18175DC10
	|-EnumerableSorter<Demos.DemoInfo, TimeSpan>.CompareKeys
	|-EnumerableSorter<object, DateTime>.CompareKeys
	|
	|-RVA: 0x175DD80 Offset: 0x175C380 VA: 0x18175DD80
	|-EnumerableSorter<ServerInfo, int>.CompareKeys
	|-EnumerableSorter<ServerInfo, uint>.CompareKeys
	|-EnumerableSorter<object, uint>.CompareKeys
	|
	|-RVA: 0x175D980 Offset: 0x175BF80 VA: 0x18175D980
	|-EnumerableSorter<KeyValuePair<object, int>, int>.CompareKeys
	|-EnumerableSorter<object, int>.CompareKeys
	|-EnumerableSorter<object, Int32Enum>.CompareKeys
	|-EnumerableSorter<Resolution, int>.CompareKeys
	|
	|-RVA: 0x175DA90 Offset: 0x175C090 VA: 0x18175DA90
	|-EnumerableSorter<double, double>.CompareKeys
	|
	|-RVA: 0x175D570 Offset: 0x175BB70 VA: 0x18175D570
	|-EnumerableSorter<object, bool>.CompareKeys
	|
	|-RVA: 0x175D7F0 Offset: 0x175BDF0 VA: 0x18175D7F0
	|-EnumerableSorter<object, DateTimeOffset>.CompareKeys
	|-EnumerableSorter<object, Guid>.CompareKeys
	|
	|-RVA: 0x175D410 Offset: 0x175BA10 VA: 0x18175D410
	|-EnumerableSorter<object, object>.CompareKeys
	|
	|-RVA: 0x175DEE0 Offset: 0x175C4E0 VA: 0x18175DEE0
	|-EnumerableSorter<object, float>.CompareKeys
	*/

}

public sealed class EnumMemberAttribute : Attribute // TypeDefIndex: 5707
{	private string value; // 0x10

	public string Value { get; }


	public string get_Value() { }

}

internal static class EnumUtils // TypeDefIndex: 5954
{	private static readonly ThreadSafeStore<Type, BidirectionalDictionary<string, string>> EnumMemberNamesPerType; // 0x3300


	private static BidirectionalDictionary<string, string> InitializeEnumType(Type type) { }

	public static IList<object> GetValues(Type enumType) { }

	public static object ParseEnumName(string enumText, bool isNullable, Type t) { }

	public static string ToEnumName(Type enumType, string enumText, bool camelCaseText) { }

	private static string ResolvedEnumName(BidirectionalDictionary<string, string> map, string enumText) { }

	private static void .cctor() { }

}

private sealed class EnumUtils.<>c // TypeDefIndex: 5955
{	public static readonly EnumUtils.<>c <>9; // 0x0
	public static Func<EnumMemberAttribute, string> <>9__1_0; // 0x8
	public static Func<FieldInfo, bool> <>9__5_0; // 0x10


	private static void .cctor() { }

	public void .ctor() { }

	internal string <InitializeEnumType>b__1_0(EnumMemberAttribute a) { }

	internal bool <GetValues>b__5_0(FieldInfo f) { }

}

private sealed class EnumUtils.<>c__2<T> // TypeDefIndex: 5956
{	public static readonly EnumUtils.<>c__2<T> <>9; // 0x0


	private static void .cctor() { }

	public void .ctor() { }

}

public class EnumListItemUI : MonoBehaviour // TypeDefIndex: 10795
{	public object Value; // 0x18
	public RustText TextValue; // 0x20
	private EnumListUI list; // 0x28


	public void Init(object value, string valueText, EnumListUI list) { }

	public void Clicked() { }

	public void .ctor() { }

}

public class EnumListUI : MonoBehaviour // TypeDefIndex: 10796
{	public Transform PrefabItem; // 0x18
	public Transform Container; // 0x20
	private Action<object> clickedAction; // 0x28
	private CanvasScaler canvasScaler; // 0x30


	private void Awake() { }

	public void Show(List<object> values, Action<object> clicked) { }

	public void ItemClicked(object value) { }

	public void Hide() { }

	public void .ctor() { }

}

