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
	|-RVA: 0x1A373E0 Offset: 0x1A359E0 VA: 0x181A373E0
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
	|-RVA: 0x1A374B0 Offset: 0x1A35AB0 VA: 0x181A374B0
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
	|-RVA: 0x1A37580 Offset: 0x1A35B80 VA: 0x181A37580
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
	|-RVA: 0x1A37650 Offset: 0x1A35C50 VA: 0x181A37650
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
	|-RVA: 0x1A377F0 Offset: 0x1A35DF0 VA: 0x181A377F0
	|-EnumHelper<byte>.Cast<EmptyStruct>
	|-EnumHelper<short>.Cast<EmptyStruct>
	|-EnumHelper<int>.Cast<EmptyStruct>
	|-EnumHelper<long>.Cast<EmptyStruct>
	|-EnumHelper<sbyte>.Cast<EmptyStruct>
	|-EnumHelper<ushort>.Cast<EmptyStruct>
	|-EnumHelper<uint>.Cast<EmptyStruct>
	|-EnumHelper<ulong>.Cast<EmptyStruct>
	|
	|-RVA: 0x1A37720 Offset: 0x1A35D20 VA: 0x181A37720
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
	|-RVA: 0x1A378C0 Offset: 0x1A35EC0 VA: 0x181A378C0
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
	|-RVA: 0x1A37990 Offset: 0x1A35F90 VA: 0x181A37990
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
	|-RVA: 0x2133DD0 Offset: 0x21323D0 VA: 0x182133DD0
	|-EnumHelper<byte>..cctor
	|
	|-RVA: 0x21338D0 Offset: 0x2131ED0 VA: 0x1821338D0
	|-EnumHelper<short>..cctor
	|
	|-RVA: 0x21339D0 Offset: 0x2131FD0 VA: 0x1821339D0
	|-EnumHelper<int>..cctor
	|
	|-RVA: 0x2133AD0 Offset: 0x21320D0 VA: 0x182133AD0
	|-EnumHelper<long>..cctor
	|
	|-RVA: 0x2133BD0 Offset: 0x21321D0 VA: 0x182133BD0
	|-EnumHelper<object>..cctor
	|
	|-RVA: 0x2133FD0 Offset: 0x21325D0 VA: 0x182133FD0
	|-EnumHelper<sbyte>..cctor
	|
	|-RVA: 0x2133ED0 Offset: 0x21324D0 VA: 0x182133ED0
	|-EnumHelper<ushort>..cctor
	|
	|-RVA: 0x21337D0 Offset: 0x2131DD0 VA: 0x1821337D0
	|-EnumHelper<uint>..cctor
	|
	|-RVA: 0x2133CD0 Offset: 0x21322D0 VA: 0x182133CD0
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
	|-RVA: 0x18A3330 Offset: 0x18A1930 VA: 0x1818A3330
	|-EnumHelper.Transformer<byte, bool>.Invoke
	|-EnumHelper.Transformer<byte, byte>.Invoke
	|-EnumHelper.Transformer<byte, sbyte>.Invoke
	|-EnumHelper.Transformer<sbyte, bool>.Invoke
	|-EnumHelper.Transformer<sbyte, byte>.Invoke
	|-EnumHelper.Transformer<sbyte, sbyte>.Invoke
	|
	|-RVA: 0x18A5C70 Offset: 0x18A4270 VA: 0x1818A5C70
	|-EnumHelper.Transformer<byte, char>.Invoke
	|-EnumHelper.Transformer<byte, short>.Invoke
	|-EnumHelper.Transformer<byte, ushort>.Invoke
	|-EnumHelper.Transformer<sbyte, char>.Invoke
	|-EnumHelper.Transformer<sbyte, short>.Invoke
	|-EnumHelper.Transformer<sbyte, ushort>.Invoke
	|
	|-RVA: 0x16D04E0 Offset: 0x16CEAE0 VA: 0x1816D04E0
	|-EnumHelper.Transformer<byte, KeyValuePair<object, object>>.Invoke
	|-EnumHelper.Transformer<byte, DateTimeOffset>.Invoke
	|-EnumHelper.Transformer<byte, Decimal>.Invoke
	|-EnumHelper.Transformer<byte, Guid>.Invoke
	|-EnumHelper.Transformer<sbyte, KeyValuePair<object, object>>.Invoke
	|-EnumHelper.Transformer<sbyte, DateTimeOffset>.Invoke
	|-EnumHelper.Transformer<sbyte, Decimal>.Invoke
	|-EnumHelper.Transformer<sbyte, Guid>.Invoke
	|
	|-RVA: 0x16D0820 Offset: 0x16CEE20 VA: 0x1816D0820
	|-EnumHelper.Transformer<byte, DateTime>.Invoke
	|-EnumHelper.Transformer<byte, TimeSpan>.Invoke
	|-EnumHelper.Transformer<sbyte, DateTime>.Invoke
	|-EnumHelper.Transformer<sbyte, TimeSpan>.Invoke
	|
	|-RVA: 0x18A7BF0 Offset: 0x18A61F0 VA: 0x1818A7BF0
	|-EnumHelper.Transformer<byte, EmptyStruct>.Invoke
	|-EnumHelper.Transformer<sbyte, EmptyStruct>.Invoke
	|
	|-RVA: 0x18A67B0 Offset: 0x18A4DB0 VA: 0x1818A67B0
	|-EnumHelper.Transformer<byte, double>.Invoke
	|-EnumHelper.Transformer<sbyte, double>.Invoke
	|
	|-RVA: 0x146D310 Offset: 0x146B910 VA: 0x18146D310
	|-EnumHelper.Transformer<byte, int>.Invoke
	|-EnumHelper.Transformer<byte, uint>.Invoke
	|-EnumHelper.Transformer<sbyte, int>.Invoke
	|-EnumHelper.Transformer<sbyte, uint>.Invoke
	|
	|-RVA: 0x1B17140 Offset: 0x1B15740 VA: 0x181B17140
	|-EnumHelper.Transformer<byte, long>.Invoke
	|-EnumHelper.Transformer<byte, IntPtr>.Invoke
	|-EnumHelper.Transformer<byte, ulong>.Invoke
	|-EnumHelper.Transformer<byte, UIntPtr>.Invoke
	|-EnumHelper.Transformer<sbyte, long>.Invoke
	|-EnumHelper.Transformer<sbyte, IntPtr>.Invoke
	|-EnumHelper.Transformer<sbyte, ulong>.Invoke
	|-EnumHelper.Transformer<sbyte, UIntPtr>.Invoke
	|
	|-RVA: 0x1783FA0 Offset: 0x17825A0 VA: 0x181783FA0
	|-EnumHelper.Transformer<byte, object>.Invoke
	|-EnumHelper.Transformer<sbyte, object>.Invoke
	|
	|-RVA: 0x18A42F0 Offset: 0x18A28F0 VA: 0x1818A42F0
	|-EnumHelper.Transformer<byte, float>.Invoke
	|-EnumHelper.Transformer<sbyte, float>.Invoke
	|
	|-RVA: 0x1B17930 Offset: 0x1B15F30 VA: 0x181B17930
	|-EnumHelper.Transformer<short, bool>.Invoke
	|-EnumHelper.Transformer<short, byte>.Invoke
	|-EnumHelper.Transformer<short, sbyte>.Invoke
	|-EnumHelper.Transformer<ushort, bool>.Invoke
	|-EnumHelper.Transformer<ushort, byte>.Invoke
	|-EnumHelper.Transformer<ushort, sbyte>.Invoke
	|
	|-RVA: 0x1B19840 Offset: 0x1B17E40 VA: 0x181B19840
	|-EnumHelper.Transformer<short, char>.Invoke
	|-EnumHelper.Transformer<short, short>.Invoke
	|-EnumHelper.Transformer<short, ushort>.Invoke
	|-EnumHelper.Transformer<ushort, char>.Invoke
	|-EnumHelper.Transformer<ushort, short>.Invoke
	|-EnumHelper.Transformer<ushort, ushort>.Invoke
	|
	|-RVA: 0x1B18F00 Offset: 0x1B17500 VA: 0x181B18F00
	|-EnumHelper.Transformer<short, KeyValuePair<object, object>>.Invoke
	|-EnumHelper.Transformer<short, DateTimeOffset>.Invoke
	|-EnumHelper.Transformer<short, Decimal>.Invoke
	|-EnumHelper.Transformer<short, Guid>.Invoke
	|-EnumHelper.Transformer<ushort, KeyValuePair<object, object>>.Invoke
	|-EnumHelper.Transformer<ushort, DateTimeOffset>.Invoke
	|-EnumHelper.Transformer<ushort, Decimal>.Invoke
	|-EnumHelper.Transformer<ushort, Guid>.Invoke
	|
	|-RVA: 0x1B19240 Offset: 0x1B17840 VA: 0x181B19240
	|-EnumHelper.Transformer<short, DateTime>.Invoke
	|-EnumHelper.Transformer<short, TimeSpan>.Invoke
	|-EnumHelper.Transformer<ushort, DateTime>.Invoke
	|-EnumHelper.Transformer<ushort, TimeSpan>.Invoke
	|
	|-RVA: 0x1B1A150 Offset: 0x1B18750 VA: 0x181B1A150
	|-EnumHelper.Transformer<short, EmptyStruct>.Invoke
	|-EnumHelper.Transformer<ushort, EmptyStruct>.Invoke
	|
	|-RVA: 0x1B16C30 Offset: 0x1B15230 VA: 0x181B16C30
	|-EnumHelper.Transformer<short, double>.Invoke
	|-EnumHelper.Transformer<ushort, double>.Invoke
	|
	|-RVA: 0x1B16180 Offset: 0x1B14780 VA: 0x181B16180
	|-EnumHelper.Transformer<short, int>.Invoke
	|-EnumHelper.Transformer<short, uint>.Invoke
	|-EnumHelper.Transformer<ushort, int>.Invoke
	|-EnumHelper.Transformer<ushort, uint>.Invoke
	|
	|-RVA: 0x1B17F70 Offset: 0x1B16570 VA: 0x181B17F70
	|-EnumHelper.Transformer<short, long>.Invoke
	|-EnumHelper.Transformer<short, IntPtr>.Invoke
	|-EnumHelper.Transformer<short, ulong>.Invoke
	|-EnumHelper.Transformer<short, UIntPtr>.Invoke
	|-EnumHelper.Transformer<ushort, long>.Invoke
	|-EnumHelper.Transformer<ushort, IntPtr>.Invoke
	|-EnumHelper.Transformer<ushort, ulong>.Invoke
	|-EnumHelper.Transformer<ushort, UIntPtr>.Invoke
	|
	|-RVA: 0x1B18770 Offset: 0x1B16D70 VA: 0x181B18770
	|-EnumHelper.Transformer<short, object>.Invoke
	|-EnumHelper.Transformer<ushort, object>.Invoke
	|
	|-RVA: 0x1B1A450 Offset: 0x1B18A50 VA: 0x181B1A450
	|-EnumHelper.Transformer<short, float>.Invoke
	|-EnumHelper.Transformer<ushort, float>.Invoke
	|
	|-RVA: 0x1B18C00 Offset: 0x1B17200 VA: 0x181B18C00
	|-EnumHelper.Transformer<int, bool>.Invoke
	|-EnumHelper.Transformer<int, byte>.Invoke
	|-EnumHelper.Transformer<int, sbyte>.Invoke
	|-EnumHelper.Transformer<uint, bool>.Invoke
	|-EnumHelper.Transformer<uint, byte>.Invoke
	|-EnumHelper.Transformer<uint, sbyte>.Invoke
	|
	|-RVA: 0x1B18470 Offset: 0x1B16A70 VA: 0x181B18470
	|-EnumHelper.Transformer<int, char>.Invoke
	|-EnumHelper.Transformer<int, short>.Invoke
	|-EnumHelper.Transformer<int, ushort>.Invoke
	|-EnumHelper.Transformer<uint, char>.Invoke
	|-EnumHelper.Transformer<uint, short>.Invoke
	|-EnumHelper.Transformer<uint, ushort>.Invoke
	|
	|-RVA: 0x1B17C30 Offset: 0x1B16230 VA: 0x181B17C30
	|-EnumHelper.Transformer<int, KeyValuePair<object, object>>.Invoke
	|-EnumHelper.Transformer<int, DateTimeOffset>.Invoke
	|-EnumHelper.Transformer<int, Decimal>.Invoke
	|-EnumHelper.Transformer<int, Guid>.Invoke
	|-EnumHelper.Transformer<uint, KeyValuePair<object, object>>.Invoke
	|-EnumHelper.Transformer<uint, DateTimeOffset>.Invoke
	|-EnumHelper.Transformer<uint, Decimal>.Invoke
	|-EnumHelper.Transformer<uint, Guid>.Invoke
	|
	|-RVA: 0x1B19540 Offset: 0x1B17B40 VA: 0x181B19540
	|-EnumHelper.Transformer<int, DateTime>.Invoke
	|-EnumHelper.Transformer<int, TimeSpan>.Invoke
	|-EnumHelper.Transformer<uint, DateTime>.Invoke
	|-EnumHelper.Transformer<uint, TimeSpan>.Invoke
	|
	|-RVA: 0x1B19B40 Offset: 0x1B18140 VA: 0x181B19B40
	|-EnumHelper.Transformer<int, EmptyStruct>.Invoke
	|-EnumHelper.Transformer<uint, EmptyStruct>.Invoke
	|
	|-RVA: 0x1B19E40 Offset: 0x1B18440 VA: 0x181B19E40
	|-EnumHelper.Transformer<int, double>.Invoke
	|-EnumHelper.Transformer<uint, double>.Invoke
	|
	|-RVA: 0x19E7F80 Offset: 0x19E6580 VA: 0x1819E7F80
	|-EnumHelper.Transformer<int, int>.Invoke
	|-EnumHelper.Transformer<int, uint>.Invoke
	|-EnumHelper.Transformer<uint, int>.Invoke
	|-EnumHelper.Transformer<uint, uint>.Invoke
	|
	|-RVA: 0x1B16F40 Offset: 0x1B15540 VA: 0x181B16F40
	|-EnumHelper.Transformer<int, long>.Invoke
	|-EnumHelper.Transformer<int, IntPtr>.Invoke
	|-EnumHelper.Transformer<int, ulong>.Invoke
	|-EnumHelper.Transformer<int, UIntPtr>.Invoke
	|-EnumHelper.Transformer<uint, long>.Invoke
	|-EnumHelper.Transformer<uint, IntPtr>.Invoke
	|-EnumHelper.Transformer<uint, ulong>.Invoke
	|-EnumHelper.Transformer<uint, UIntPtr>.Invoke
	|
	|-RVA: 0x1B167B0 Offset: 0x1B14DB0 VA: 0x181B167B0
	|-EnumHelper.Transformer<int, object>.Invoke
	|-EnumHelper.Transformer<uint, object>.Invoke
	|
	|-RVA: 0x1B17640 Offset: 0x1B15C40 VA: 0x181B17640
	|-EnumHelper.Transformer<int, float>.Invoke
	|-EnumHelper.Transformer<uint, float>.Invoke
	|
	|-RVA: 0x1B18170 Offset: 0x1B16770 VA: 0x181B18170
	|-EnumHelper.Transformer<long, bool>.Invoke
	|-EnumHelper.Transformer<long, byte>.Invoke
	|-EnumHelper.Transformer<long, sbyte>.Invoke
	|-EnumHelper.Transformer<ulong, bool>.Invoke
	|-EnumHelper.Transformer<ulong, byte>.Invoke
	|-EnumHelper.Transformer<ulong, sbyte>.Invoke
	|
	|-RVA: 0x1B17340 Offset: 0x1B15940 VA: 0x181B17340
	|-EnumHelper.Transformer<long, char>.Invoke
	|-EnumHelper.Transformer<long, short>.Invoke
	|-EnumHelper.Transformer<long, ushort>.Invoke
	|-EnumHelper.Transformer<ulong, char>.Invoke
	|-EnumHelper.Transformer<ulong, short>.Invoke
	|-EnumHelper.Transformer<ulong, ushort>.Invoke
	|
	|-RVA: 0x1B16470 Offset: 0x1B14A70 VA: 0x181B16470
	|-EnumHelper.Transformer<long, KeyValuePair<object, object>>.Invoke
	|-EnumHelper.Transformer<long, DateTimeOffset>.Invoke
	|-EnumHelper.Transformer<long, Decimal>.Invoke
	|-EnumHelper.Transformer<long, Guid>.Invoke
	|-EnumHelper.Transformer<ulong, KeyValuePair<object, object>>.Invoke
	|-EnumHelper.Transformer<ulong, DateTimeOffset>.Invoke
	|-EnumHelper.Transformer<ulong, Decimal>.Invoke
	|-EnumHelper.Transformer<ulong, Guid>.Invoke
	|
	|-RVA: 0x19EA950 Offset: 0x19E8F50 VA: 0x1819EA950
	|-EnumHelper.Transformer<long, DateTime>.Invoke
	|-EnumHelper.Transformer<long, TimeSpan>.Invoke
	|-EnumHelper.Transformer<ulong, DateTime>.Invoke
	|-EnumHelper.Transformer<ulong, TimeSpan>.Invoke
	|
	|-RVA: 0x1B963A0 Offset: 0x1B949A0 VA: 0x181B963A0
	|-EnumHelper.Transformer<long, EmptyStruct>.Invoke
	|-EnumHelper.Transformer<ulong, EmptyStruct>.Invoke
	|
	|-RVA: 0x20C8590 Offset: 0x20C6B90 VA: 0x1820C8590
	|-EnumHelper.Transformer<long, double>.Invoke
	|-EnumHelper.Transformer<ulong, double>.Invoke
	|
	|-RVA: 0x20C82A0 Offset: 0x20C68A0 VA: 0x1820C82A0
	|-EnumHelper.Transformer<long, int>.Invoke
	|-EnumHelper.Transformer<long, uint>.Invoke
	|-EnumHelper.Transformer<ulong, int>.Invoke
	|-EnumHelper.Transformer<ulong, uint>.Invoke
	|
	|-RVA: 0x20C88A0 Offset: 0x20C6EA0 VA: 0x1820C88A0
	|-EnumHelper.Transformer<long, long>.Invoke
	|-EnumHelper.Transformer<long, IntPtr>.Invoke
	|-EnumHelper.Transformer<long, ulong>.Invoke
	|-EnumHelper.Transformer<long, UIntPtr>.Invoke
	|-EnumHelper.Transformer<ulong, long>.Invoke
	|-EnumHelper.Transformer<ulong, IntPtr>.Invoke
	|-EnumHelper.Transformer<ulong, ulong>.Invoke
	|-EnumHelper.Transformer<ulong, UIntPtr>.Invoke
	|
	|-RVA: 0x133AAE0 Offset: 0x13390E0 VA: 0x18133AAE0
	|-EnumHelper.Transformer<long, object>.Invoke
	|-EnumHelper.Transformer<object, object>.Invoke
	|-EnumHelper.Transformer<ulong, object>.Invoke
	|
	|-RVA: 0x20C8AA0 Offset: 0x20C70A0 VA: 0x1820C8AA0
	|-EnumHelper.Transformer<long, float>.Invoke
	|-EnumHelper.Transformer<ulong, float>.Invoke
	*/

	public virtual IAsyncResult BeginInvoke(ValueType value, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B14E80 Offset: 0x1B13480 VA: 0x181B14E80
	|-EnumHelper.Transformer<byte, bool>.BeginInvoke
	|
	|-RVA: 0x1B14080 Offset: 0x1B12680 VA: 0x181B14080
	|-EnumHelper.Transformer<byte, byte>.BeginInvoke
	|
	|-RVA: 0x1B15580 Offset: 0x1B13B80 VA: 0x181B15580
	|-EnumHelper.Transformer<byte, char>.BeginInvoke
	|
	|-RVA: 0x1B15F00 Offset: 0x1B14500 VA: 0x181B15F00
	|-EnumHelper.Transformer<byte, KeyValuePair<object, object>>.BeginInvoke
	|
	|-RVA: 0x1B16080 Offset: 0x1B14680 VA: 0x181B16080
	|-EnumHelper.Transformer<byte, DateTime>.BeginInvoke
	|
	|-RVA: 0x1B16000 Offset: 0x1B14600 VA: 0x181B16000
	|-EnumHelper.Transformer<byte, DateTimeOffset>.BeginInvoke
	|
	|-RVA: 0x1B15B00 Offset: 0x1B14100 VA: 0x181B15B00
	|-EnumHelper.Transformer<byte, Decimal>.BeginInvoke
	|
	|-RVA: 0x1B15080 Offset: 0x1B13680 VA: 0x181B15080
	|-EnumHelper.Transformer<byte, EmptyStruct>.BeginInvoke
	|
	|-RVA: 0x1B15C00 Offset: 0x1B14200 VA: 0x181B15C00
	|-EnumHelper.Transformer<byte, double>.BeginInvoke
	|
	|-RVA: 0x1B14800 Offset: 0x1B12E00 VA: 0x181B14800
	|-EnumHelper.Transformer<byte, Guid>.BeginInvoke
	|
	|-RVA: 0x1B15800 Offset: 0x1B13E00 VA: 0x181B15800
	|-EnumHelper.Transformer<byte, short>.BeginInvoke
	|
	|-RVA: 0x1B14900 Offset: 0x1B12F00 VA: 0x181B14900
	|-EnumHelper.Transformer<byte, int>.BeginInvoke
	|
	|-RVA: 0x1B15D00 Offset: 0x1B14300 VA: 0x181B15D00
	|-EnumHelper.Transformer<byte, long>.BeginInvoke
	|
	|-RVA: 0x1B14C00 Offset: 0x1B13200 VA: 0x181B14C00
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
	|-RVA: 0x1B15900 Offset: 0x1B13F00 VA: 0x181B15900
	|-EnumHelper.Transformer<byte, sbyte>.BeginInvoke
	|
	|-RVA: 0x1B15380 Offset: 0x1B13980 VA: 0x181B15380
	|-EnumHelper.Transformer<byte, float>.BeginInvoke
	|
	|-RVA: 0x1B15E00 Offset: 0x1B14400 VA: 0x181B15E00
	|-EnumHelper.Transformer<byte, TimeSpan>.BeginInvoke
	|
	|-RVA: 0x1B14200 Offset: 0x1B12800 VA: 0x181B14200
	|-EnumHelper.Transformer<byte, ushort>.BeginInvoke
	|
	|-RVA: 0x1B15980 Offset: 0x1B13F80 VA: 0x181B15980
	|-EnumHelper.Transformer<byte, uint>.BeginInvoke
	|
	|-RVA: 0x1B14A00 Offset: 0x1B13000 VA: 0x181B14A00
	|-EnumHelper.Transformer<byte, ulong>.BeginInvoke
	|
	|-RVA: 0x1B13F00 Offset: 0x1B12500 VA: 0x181B13F00
	|-EnumHelper.Transformer<byte, UIntPtr>.BeginInvoke
	|
	|-RVA: 0x1B15600 Offset: 0x1B13C00 VA: 0x181B15600
	|-EnumHelper.Transformer<short, bool>.BeginInvoke
	|
	|-RVA: 0x1B15400 Offset: 0x1B13A00 VA: 0x181B15400
	|-EnumHelper.Transformer<short, byte>.BeginInvoke
	|
	|-RVA: 0x1B14680 Offset: 0x1B12C80 VA: 0x181B14680
	|-EnumHelper.Transformer<short, char>.BeginInvoke
	|
	|-RVA: 0x1B14300 Offset: 0x1B12900 VA: 0x181B14300
	|-EnumHelper.Transformer<short, KeyValuePair<object, object>>.BeginInvoke
	|
	|-RVA: 0x1B13E80 Offset: 0x1B12480 VA: 0x181B13E80
	|-EnumHelper.Transformer<short, DateTime>.BeginInvoke
	|
	|-RVA: 0x1B14E00 Offset: 0x1B13400 VA: 0x181B14E00
	|-EnumHelper.Transformer<short, DateTimeOffset>.BeginInvoke
	|
	|-RVA: 0x1B14100 Offset: 0x1B12700 VA: 0x181B14100
	|-EnumHelper.Transformer<short, Decimal>.BeginInvoke
	|
	|-RVA: 0x1B15A80 Offset: 0x1B14080 VA: 0x181B15A80
	|-EnumHelper.Transformer<short, EmptyStruct>.BeginInvoke
	|
	|-RVA: 0x1B14D80 Offset: 0x1B13380 VA: 0x181B14D80
	|-EnumHelper.Transformer<short, double>.BeginInvoke
	|
	|-RVA: 0x1B14600 Offset: 0x1B12C00 VA: 0x181B14600
	|-EnumHelper.Transformer<short, Guid>.BeginInvoke
	|
	|-RVA: 0x1B14400 Offset: 0x1B12A00 VA: 0x181B14400
	|-EnumHelper.Transformer<short, short>.BeginInvoke
	|
	|-RVA: 0x1B14280 Offset: 0x1B12880 VA: 0x181B14280
	|-EnumHelper.Transformer<short, int>.BeginInvoke
	|
	|-RVA: 0x1B14580 Offset: 0x1B12B80 VA: 0x181B14580
	|-EnumHelper.Transformer<short, long>.BeginInvoke
	|
	|-RVA: 0x1B14180 Offset: 0x1B12780 VA: 0x181B14180
	|-EnumHelper.Transformer<short, IntPtr>.BeginInvoke
	|
	|-RVA: 0x1B14380 Offset: 0x1B12980 VA: 0x181B14380
	|-EnumHelper.Transformer<short, sbyte>.BeginInvoke
	|
	|-RVA: 0x1B16100 Offset: 0x1B14700 VA: 0x181B16100
	|-EnumHelper.Transformer<short, float>.BeginInvoke
	|
	|-RVA: 0x1B15E80 Offset: 0x1B14480 VA: 0x181B15E80
	|-EnumHelper.Transformer<short, TimeSpan>.BeginInvoke
	|
	|-RVA: 0x1B14780 Offset: 0x1B12D80 VA: 0x181B14780
	|-EnumHelper.Transformer<short, ushort>.BeginInvoke
	|
	|-RVA: 0x1B14B00 Offset: 0x1B13100 VA: 0x181B14B00
	|-EnumHelper.Transformer<short, uint>.BeginInvoke
	|
	|-RVA: 0x1B15480 Offset: 0x1B13A80 VA: 0x181B15480
	|-EnumHelper.Transformer<short, ulong>.BeginInvoke
	|
	|-RVA: 0x1B14D00 Offset: 0x1B13300 VA: 0x181B14D00
	|-EnumHelper.Transformer<short, UIntPtr>.BeginInvoke
	|
	|-RVA: 0x1B15D80 Offset: 0x1B14380 VA: 0x181B15D80
	|-EnumHelper.Transformer<int, bool>.BeginInvoke
	|
	|-RVA: 0x1B14700 Offset: 0x1B12D00 VA: 0x181B14700
	|-EnumHelper.Transformer<int, byte>.BeginInvoke
	|
	|-RVA: 0x1B14980 Offset: 0x1B12F80 VA: 0x181B14980
	|-EnumHelper.Transformer<int, char>.BeginInvoke
	|
	|-RVA: 0x1B14F00 Offset: 0x1B13500 VA: 0x181B14F00
	|-EnumHelper.Transformer<int, KeyValuePair<object, object>>.BeginInvoke
	|
	|-RVA: 0x1B14F80 Offset: 0x1B13580 VA: 0x181B14F80
	|-EnumHelper.Transformer<int, DateTime>.BeginInvoke
	|
	|-RVA: 0x1B15280 Offset: 0x1B13880 VA: 0x181B15280
	|-EnumHelper.Transformer<int, DateTimeOffset>.BeginInvoke
	|
	|-RVA: 0x1B15100 Offset: 0x1B13700 VA: 0x181B15100
	|-EnumHelper.Transformer<int, Decimal>.BeginInvoke
	|
	|-RVA: 0x1B15A00 Offset: 0x1B14000 VA: 0x181B15A00
	|-EnumHelper.Transformer<int, EmptyStruct>.BeginInvoke
	|
	|-RVA: 0x1B14C80 Offset: 0x1B13280 VA: 0x181B14C80
	|-EnumHelper.Transformer<int, double>.BeginInvoke
	|
	|-RVA: 0x1B15F80 Offset: 0x1B14580 VA: 0x181B15F80
	|-EnumHelper.Transformer<int, Guid>.BeginInvoke
	|
	|-RVA: 0x1B15300 Offset: 0x1B13900 VA: 0x181B15300
	|-EnumHelper.Transformer<int, short>.BeginInvoke
	|
	|-RVA: 0x1B15C80 Offset: 0x1B14280 VA: 0x181B15C80
	|-EnumHelper.Transformer<int, int>.BeginInvoke
	|
	|-RVA: 0x1B15700 Offset: 0x1B13D00 VA: 0x181B15700
	|-EnumHelper.Transformer<int, long>.BeginInvoke
	|
	|-RVA: 0x1B15880 Offset: 0x1B13E80 VA: 0x181B15880
	|-EnumHelper.Transformer<int, IntPtr>.BeginInvoke
	|
	|-RVA: 0x1B14480 Offset: 0x1B12A80 VA: 0x181B14480
	|-EnumHelper.Transformer<int, sbyte>.BeginInvoke
	|
	|-RVA: 0x1B13F80 Offset: 0x1B12580 VA: 0x181B13F80
	|-EnumHelper.Transformer<int, float>.BeginInvoke
	|
	|-RVA: 0x1B15500 Offset: 0x1B13B00 VA: 0x181B15500
	|-EnumHelper.Transformer<int, TimeSpan>.BeginInvoke
	|
	|-RVA: 0x1B14880 Offset: 0x1B12E80 VA: 0x181B14880
	|-EnumHelper.Transformer<int, ushort>.BeginInvoke
	|
	|-RVA: 0x1B15200 Offset: 0x1B13800 VA: 0x181B15200
	|-EnumHelper.Transformer<int, uint>.BeginInvoke
	|
	|-RVA: 0x1B14000 Offset: 0x1B12600 VA: 0x181B14000
	|-EnumHelper.Transformer<int, ulong>.BeginInvoke
	|
	|-RVA: 0x1B15000 Offset: 0x1B13600 VA: 0x181B15000
	|-EnumHelper.Transformer<int, UIntPtr>.BeginInvoke
	|
	|-RVA: 0x1B14A80 Offset: 0x1B13080 VA: 0x181B14A80
	|-EnumHelper.Transformer<long, bool>.BeginInvoke
	|
	|-RVA: 0x1B15680 Offset: 0x1B13C80 VA: 0x181B15680
	|-EnumHelper.Transformer<long, byte>.BeginInvoke
	|
	|-RVA: 0x1B14500 Offset: 0x1B12B00 VA: 0x181B14500
	|-EnumHelper.Transformer<long, char>.BeginInvoke
	|
	|-RVA: 0x1B15180 Offset: 0x1B13780 VA: 0x181B15180
	|-EnumHelper.Transformer<long, KeyValuePair<object, object>>.BeginInvoke
	|
	|-RVA: 0x1B15B80 Offset: 0x1B14180 VA: 0x181B15B80
	|-EnumHelper.Transformer<long, DateTime>.BeginInvoke
	|
	|-RVA: 0x1B15780 Offset: 0x1B13D80 VA: 0x181B15780
	|-EnumHelper.Transformer<long, DateTimeOffset>.BeginInvoke
	|
	|-RVA: 0x1B14B80 Offset: 0x1B13180 VA: 0x181B14B80
	|-EnumHelper.Transformer<long, Decimal>.BeginInvoke
	|
	|-RVA: 0x213C8A0 Offset: 0x213AEA0 VA: 0x18213C8A0
	|-EnumHelper.Transformer<long, EmptyStruct>.BeginInvoke
	|
	|-RVA: 0x213C9A0 Offset: 0x213AFA0 VA: 0x18213C9A0
	|-EnumHelper.Transformer<long, double>.BeginInvoke
	|
	|-RVA: 0x213AB20 Offset: 0x2139120 VA: 0x18213AB20
	|-EnumHelper.Transformer<long, Guid>.BeginInvoke
	|
	|-RVA: 0x213C220 Offset: 0x213A820 VA: 0x18213C220
	|-EnumHelper.Transformer<long, short>.BeginInvoke
	|
	|-RVA: 0x213B820 Offset: 0x2139E20 VA: 0x18213B820
	|-EnumHelper.Transformer<long, int>.BeginInvoke
	|
	|-RVA: 0x213BEA0 Offset: 0x213A4A0 VA: 0x18213BEA0
	|-EnumHelper.Transformer<long, long>.BeginInvoke
	|
	|-RVA: 0x213BAA0 Offset: 0x213A0A0 VA: 0x18213BAA0
	|-EnumHelper.Transformer<long, IntPtr>.BeginInvoke
	|
	|-RVA: 0x213C5A0 Offset: 0x213ABA0 VA: 0x18213C5A0
	|-EnumHelper.Transformer<long, sbyte>.BeginInvoke
	|
	|-RVA: 0x213B720 Offset: 0x2139D20 VA: 0x18213B720
	|-EnumHelper.Transformer<long, float>.BeginInvoke
	|
	|-RVA: 0x213D920 Offset: 0x213BF20 VA: 0x18213D920
	|-EnumHelper.Transformer<long, TimeSpan>.BeginInvoke
	|
	|-RVA: 0x213B1A0 Offset: 0x21397A0 VA: 0x18213B1A0
	|-EnumHelper.Transformer<long, ushort>.BeginInvoke
	|
	|-RVA: 0x213CA20 Offset: 0x213B020 VA: 0x18213CA20
	|-EnumHelper.Transformer<long, uint>.BeginInvoke
	|
	|-RVA: 0x213BA20 Offset: 0x213A020 VA: 0x18213BA20
	|-EnumHelper.Transformer<long, ulong>.BeginInvoke
	|
	|-RVA: 0x213CC20 Offset: 0x213B220 VA: 0x18213CC20
	|-EnumHelper.Transformer<long, UIntPtr>.BeginInvoke
	|
	|-RVA: 0x213AFA0 Offset: 0x21395A0 VA: 0x18213AFA0
	|-EnumHelper.Transformer<sbyte, bool>.BeginInvoke
	|
	|-RVA: 0x213B7A0 Offset: 0x2139DA0 VA: 0x18213B7A0
	|-EnumHelper.Transformer<sbyte, byte>.BeginInvoke
	|
	|-RVA: 0x213B320 Offset: 0x2139920 VA: 0x18213B320
	|-EnumHelper.Transformer<sbyte, char>.BeginInvoke
	|
	|-RVA: 0x213CFA0 Offset: 0x213B5A0 VA: 0x18213CFA0
	|-EnumHelper.Transformer<sbyte, KeyValuePair<object, object>>.BeginInvoke
	|
	|-RVA: 0x213C620 Offset: 0x213AC20 VA: 0x18213C620
	|-EnumHelper.Transformer<sbyte, DateTime>.BeginInvoke
	|
	|-RVA: 0x213AEA0 Offset: 0x21394A0 VA: 0x18213AEA0
	|-EnumHelper.Transformer<sbyte, DateTimeOffset>.BeginInvoke
	|
	|-RVA: 0x213B920 Offset: 0x2139F20 VA: 0x18213B920
	|-EnumHelper.Transformer<sbyte, Decimal>.BeginInvoke
	|
	|-RVA: 0x213AA20 Offset: 0x2139020 VA: 0x18213AA20
	|-EnumHelper.Transformer<sbyte, EmptyStruct>.BeginInvoke
	|
	|-RVA: 0x213D020 Offset: 0x213B620 VA: 0x18213D020
	|-EnumHelper.Transformer<sbyte, double>.BeginInvoke
	|
	|-RVA: 0x213D0A0 Offset: 0x213B6A0 VA: 0x18213D0A0
	|-EnumHelper.Transformer<sbyte, Guid>.BeginInvoke
	|
	|-RVA: 0x213B6A0 Offset: 0x2139CA0 VA: 0x18213B6A0
	|-EnumHelper.Transformer<sbyte, short>.BeginInvoke
	|
	|-RVA: 0x213C7A0 Offset: 0x213ADA0 VA: 0x18213C7A0
	|-EnumHelper.Transformer<sbyte, int>.BeginInvoke
	|
	|-RVA: 0x213CE20 Offset: 0x213B420 VA: 0x18213CE20
	|-EnumHelper.Transformer<sbyte, long>.BeginInvoke
	|
	|-RVA: 0x213BFA0 Offset: 0x213A5A0 VA: 0x18213BFA0
	|-EnumHelper.Transformer<sbyte, IntPtr>.BeginInvoke
	|
	|-RVA: 0x213CD20 Offset: 0x213B320 VA: 0x18213CD20
	|-EnumHelper.Transformer<sbyte, sbyte>.BeginInvoke
	|
	|-RVA: 0x213C6A0 Offset: 0x213ACA0 VA: 0x18213C6A0
	|-EnumHelper.Transformer<sbyte, float>.BeginInvoke
	|
	|-RVA: 0x213C0A0 Offset: 0x213A6A0 VA: 0x18213C0A0
	|-EnumHelper.Transformer<sbyte, TimeSpan>.BeginInvoke
	|
	|-RVA: 0x213D820 Offset: 0x213BE20 VA: 0x18213D820
	|-EnumHelper.Transformer<sbyte, ushort>.BeginInvoke
	|
	|-RVA: 0x213AD20 Offset: 0x2139320 VA: 0x18213AD20
	|-EnumHelper.Transformer<sbyte, uint>.BeginInvoke
	|
	|-RVA: 0x213AAA0 Offset: 0x21390A0 VA: 0x18213AAA0
	|-EnumHelper.Transformer<sbyte, ulong>.BeginInvoke
	|
	|-RVA: 0x213A8A0 Offset: 0x2138EA0 VA: 0x18213A8A0
	|-EnumHelper.Transformer<sbyte, UIntPtr>.BeginInvoke
	|
	|-RVA: 0x213C520 Offset: 0x213AB20 VA: 0x18213C520
	|-EnumHelper.Transformer<ushort, bool>.BeginInvoke
	|
	|-RVA: 0x213BC20 Offset: 0x213A220 VA: 0x18213BC20
	|-EnumHelper.Transformer<ushort, byte>.BeginInvoke
	|
	|-RVA: 0x213C3A0 Offset: 0x213A9A0 VA: 0x18213C3A0
	|-EnumHelper.Transformer<ushort, char>.BeginInvoke
	|
	|-RVA: 0x213BCA0 Offset: 0x213A2A0 VA: 0x18213BCA0
	|-EnumHelper.Transformer<ushort, KeyValuePair<object, object>>.BeginInvoke
	|
	|-RVA: 0x213B120 Offset: 0x2139720 VA: 0x18213B120
	|-EnumHelper.Transformer<ushort, DateTime>.BeginInvoke
	|
	|-RVA: 0x213AE20 Offset: 0x2139420 VA: 0x18213AE20
	|-EnumHelper.Transformer<ushort, DateTimeOffset>.BeginInvoke
	|
	|-RVA: 0x213BDA0 Offset: 0x213A3A0 VA: 0x18213BDA0
	|-EnumHelper.Transformer<ushort, Decimal>.BeginInvoke
	|
	|-RVA: 0x213AC20 Offset: 0x2139220 VA: 0x18213AC20
	|-EnumHelper.Transformer<ushort, EmptyStruct>.BeginInvoke
	|
	|-RVA: 0x213C120 Offset: 0x213A720 VA: 0x18213C120
	|-EnumHelper.Transformer<ushort, double>.BeginInvoke
	|
	|-RVA: 0x213A920 Offset: 0x2138F20 VA: 0x18213A920
	|-EnumHelper.Transformer<ushort, Guid>.BeginInvoke
	|
	|-RVA: 0x213C720 Offset: 0x213AD20 VA: 0x18213C720
	|-EnumHelper.Transformer<ushort, short>.BeginInvoke
	|
	|-RVA: 0x213D620 Offset: 0x213BC20 VA: 0x18213D620
	|-EnumHelper.Transformer<ushort, int>.BeginInvoke
	|
	|-RVA: 0x213B420 Offset: 0x2139A20 VA: 0x18213B420
	|-EnumHelper.Transformer<ushort, long>.BeginInvoke
	|
	|-RVA: 0x213A9A0 Offset: 0x2138FA0 VA: 0x18213A9A0
	|-EnumHelper.Transformer<ushort, IntPtr>.BeginInvoke
	|
	|-RVA: 0x213CBA0 Offset: 0x213B1A0 VA: 0x18213CBA0
	|-EnumHelper.Transformer<ushort, sbyte>.BeginInvoke
	|
	|-RVA: 0x213B3A0 Offset: 0x21399A0 VA: 0x18213B3A0
	|-EnumHelper.Transformer<ushort, float>.BeginInvoke
	|
	|-RVA: 0x213BE20 Offset: 0x213A420 VA: 0x18213BE20
	|-EnumHelper.Transformer<ushort, TimeSpan>.BeginInvoke
	|
	|-RVA: 0x213D1A0 Offset: 0x213B7A0 VA: 0x18213D1A0
	|-EnumHelper.Transformer<ushort, ushort>.BeginInvoke
	|
	|-RVA: 0x213BF20 Offset: 0x213A520 VA: 0x18213BF20
	|-EnumHelper.Transformer<ushort, uint>.BeginInvoke
	|
	|-RVA: 0x213B2A0 Offset: 0x21398A0 VA: 0x18213B2A0
	|-EnumHelper.Transformer<ushort, ulong>.BeginInvoke
	|
	|-RVA: 0x213BBA0 Offset: 0x213A1A0 VA: 0x18213BBA0
	|-EnumHelper.Transformer<ushort, UIntPtr>.BeginInvoke
	|
	|-RVA: 0x213C4A0 Offset: 0x213AAA0 VA: 0x18213C4A0
	|-EnumHelper.Transformer<uint, bool>.BeginInvoke
	|
	|-RVA: 0x213C020 Offset: 0x213A620 VA: 0x18213C020
	|-EnumHelper.Transformer<uint, byte>.BeginInvoke
	|
	|-RVA: 0x213D420 Offset: 0x213BA20 VA: 0x18213D420
	|-EnumHelper.Transformer<uint, char>.BeginInvoke
	|
	|-RVA: 0x213C320 Offset: 0x213A920 VA: 0x18213C320
	|-EnumHelper.Transformer<uint, KeyValuePair<object, object>>.BeginInvoke
	|
	|-RVA: 0x213B020 Offset: 0x2139620 VA: 0x18213B020
	|-EnumHelper.Transformer<uint, DateTime>.BeginInvoke
	|
	|-RVA: 0x213B220 Offset: 0x2139820 VA: 0x18213B220
	|-EnumHelper.Transformer<uint, DateTimeOffset>.BeginInvoke
	|
	|-RVA: 0x213B520 Offset: 0x2139B20 VA: 0x18213B520
	|-EnumHelper.Transformer<uint, Decimal>.BeginInvoke
	|
	|-RVA: 0x213CAA0 Offset: 0x213B0A0 VA: 0x18213CAA0
	|-EnumHelper.Transformer<uint, EmptyStruct>.BeginInvoke
	|
	|-RVA: 0x213ACA0 Offset: 0x21392A0 VA: 0x18213ACA0
	|-EnumHelper.Transformer<uint, double>.BeginInvoke
	|
	|-RVA: 0x213CEA0 Offset: 0x213B4A0 VA: 0x18213CEA0
	|-EnumHelper.Transformer<uint, Guid>.BeginInvoke
	|
	|-RVA: 0x213BB20 Offset: 0x213A120 VA: 0x18213BB20
	|-EnumHelper.Transformer<uint, short>.BeginInvoke
	|
	|-RVA: 0x213B620 Offset: 0x2139C20 VA: 0x18213B620
	|-EnumHelper.Transformer<uint, int>.BeginInvoke
	|
	|-RVA: 0x213D4A0 Offset: 0x213BAA0 VA: 0x18213D4A0
	|-EnumHelper.Transformer<uint, long>.BeginInvoke
	|
	|-RVA: 0x213D220 Offset: 0x213B820 VA: 0x18213D220
	|-EnumHelper.Transformer<uint, IntPtr>.BeginInvoke
	|
	|-RVA: 0x213D7A0 Offset: 0x213BDA0 VA: 0x18213D7A0
	|-EnumHelper.Transformer<uint, sbyte>.BeginInvoke
	|
	|-RVA: 0x213C2A0 Offset: 0x213A8A0 VA: 0x18213C2A0
	|-EnumHelper.Transformer<uint, float>.BeginInvoke
	|
	|-RVA: 0x213D8A0 Offset: 0x213BEA0 VA: 0x18213D8A0
	|-EnumHelper.Transformer<uint, TimeSpan>.BeginInvoke
	|
	|-RVA: 0x213BD20 Offset: 0x213A320 VA: 0x18213BD20
	|-EnumHelper.Transformer<uint, ushort>.BeginInvoke
	|
	|-RVA: 0x213D5A0 Offset: 0x213BBA0 VA: 0x18213D5A0
	|-EnumHelper.Transformer<uint, uint>.BeginInvoke
	|
	|-RVA: 0x213CDA0 Offset: 0x213B3A0 VA: 0x18213CDA0
	|-EnumHelper.Transformer<uint, ulong>.BeginInvoke
	|
	|-RVA: 0x213D520 Offset: 0x213BB20 VA: 0x18213D520
	|-EnumHelper.Transformer<uint, UIntPtr>.BeginInvoke
	|
	|-RVA: 0x213D2A0 Offset: 0x213B8A0 VA: 0x18213D2A0
	|-EnumHelper.Transformer<ulong, bool>.BeginInvoke
	|
	|-RVA: 0x213D3A0 Offset: 0x213B9A0 VA: 0x18213D3A0
	|-EnumHelper.Transformer<ulong, byte>.BeginInvoke
	|
	|-RVA: 0x213D720 Offset: 0x213BD20 VA: 0x18213D720
	|-EnumHelper.Transformer<ulong, char>.BeginInvoke
	|
	|-RVA: 0x213C920 Offset: 0x213AF20 VA: 0x18213C920
	|-EnumHelper.Transformer<ulong, KeyValuePair<object, object>>.BeginInvoke
	|
	|-RVA: 0x213C1A0 Offset: 0x213A7A0 VA: 0x18213C1A0
	|-EnumHelper.Transformer<ulong, DateTime>.BeginInvoke
	|
	|-RVA: 0x213ADA0 Offset: 0x21393A0 VA: 0x18213ADA0
	|-EnumHelper.Transformer<ulong, DateTimeOffset>.BeginInvoke
	|
	|-RVA: 0x213B5A0 Offset: 0x2139BA0 VA: 0x18213B5A0
	|-EnumHelper.Transformer<ulong, Decimal>.BeginInvoke
	|
	|-RVA: 0x213C420 Offset: 0x213AA20 VA: 0x18213C420
	|-EnumHelper.Transformer<ulong, EmptyStruct>.BeginInvoke
	|
	|-RVA: 0x213B9A0 Offset: 0x2139FA0 VA: 0x18213B9A0
	|-EnumHelper.Transformer<ulong, double>.BeginInvoke
	|
	|-RVA: 0x213B0A0 Offset: 0x21396A0 VA: 0x18213B0A0
	|-EnumHelper.Transformer<ulong, Guid>.BeginInvoke
	|
	|-RVA: 0x213D120 Offset: 0x213B720 VA: 0x18213D120
	|-EnumHelper.Transformer<ulong, short>.BeginInvoke
	|
	|-RVA: 0x213B4A0 Offset: 0x2139AA0 VA: 0x18213B4A0
	|-EnumHelper.Transformer<ulong, int>.BeginInvoke
	|
	|-RVA: 0x213B8A0 Offset: 0x2139EA0 VA: 0x18213B8A0
	|-EnumHelper.Transformer<ulong, long>.BeginInvoke
	|
	|-RVA: 0x213CCA0 Offset: 0x213B2A0 VA: 0x18213CCA0
	|-EnumHelper.Transformer<ulong, IntPtr>.BeginInvoke
	|
	|-RVA: 0x213ABA0 Offset: 0x21391A0 VA: 0x18213ABA0
	|-EnumHelper.Transformer<ulong, sbyte>.BeginInvoke
	|
	|-RVA: 0x213CB20 Offset: 0x213B120 VA: 0x18213CB20
	|-EnumHelper.Transformer<ulong, float>.BeginInvoke
	|
	|-RVA: 0x213D320 Offset: 0x213B920 VA: 0x18213D320
	|-EnumHelper.Transformer<ulong, TimeSpan>.BeginInvoke
	|
	|-RVA: 0x213D6A0 Offset: 0x213BCA0 VA: 0x18213D6A0
	|-EnumHelper.Transformer<ulong, ushort>.BeginInvoke
	|
	|-RVA: 0x213AF20 Offset: 0x2139520 VA: 0x18213AF20
	|-EnumHelper.Transformer<ulong, uint>.BeginInvoke
	|
	|-RVA: 0x213C820 Offset: 0x213AE20 VA: 0x18213C820
	|-EnumHelper.Transformer<ulong, ulong>.BeginInvoke
	|
	|-RVA: 0x213CF20 Offset: 0x213B520 VA: 0x18213CF20
	|-EnumHelper.Transformer<ulong, UIntPtr>.BeginInvoke
	*/

	public virtual UnderlyingType EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFF70F0 Offset: 0xFF56F0 VA: 0x180FF70F0
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
	|-RVA: 0xD986D0 Offset: 0xD96CD0 VA: 0x180D986D0
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
	|-RVA: 0x1221E70 Offset: 0x1220470 VA: 0x181221E70
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
	|-RVA: 0x1AFC300 Offset: 0x1AFA900 VA: 0x181AFC300
	|-EnumHelper.Caster<byte, bool>..cctor
	|
	|-RVA: 0x1AF76B0 Offset: 0x1AF5CB0 VA: 0x181AF76B0
	|-EnumHelper.Caster<byte, byte>..cctor
	|
	|-RVA: 0x1B00AB0 Offset: 0x1AFF0B0 VA: 0x181B00AB0
	|-EnumHelper.Caster<byte, char>..cctor
	|
	|-RVA: 0x1B04DC0 Offset: 0x1B033C0 VA: 0x181B04DC0
	|-EnumHelper.Caster<byte, KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x1AFEA50 Offset: 0x1AFD050 VA: 0x181AFEA50
	|-EnumHelper.Caster<byte, DateTime>..cctor
	|
	|-RVA: 0x1B06BD0 Offset: 0x1B051D0 VA: 0x181B06BD0
	|-EnumHelper.Caster<byte, DateTimeOffset>..cctor
	|
	|-RVA: 0x1B0B380 Offset: 0x1B09980 VA: 0x181B0B380
	|-EnumHelper.Caster<byte, Decimal>..cctor
	|
	|-RVA: 0x1AFF5E0 Offset: 0x1AFDBE0 VA: 0x181AFF5E0
	|-EnumHelper.Caster<byte, EmptyStruct>..cctor
	|
	|-RVA: 0x1B0EB00 Offset: 0x1B0D100 VA: 0x181B0EB00
	|-EnumHelper.Caster<byte, double>..cctor
	|
	|-RVA: 0x1B0F690 Offset: 0x1B0DC90 VA: 0x181B0F690
	|-EnumHelper.Caster<byte, Guid>..cctor
	|
	|-RVA: 0x1AF7210 Offset: 0x1AF5810 VA: 0x181AF7210
	|-EnumHelper.Caster<byte, short>..cctor
	|
	|-RVA: 0x1AFC550 Offset: 0x1AFAB50 VA: 0x181AFC550
	|-EnumHelper.Caster<byte, int>..cctor
	|
	|-RVA: 0x1AFECA0 Offset: 0x1AFD2A0 VA: 0x181AFECA0
	|-EnumHelper.Caster<byte, long>..cctor
	|
	|-RVA: 0x1B03FE0 Offset: 0x1B025E0 VA: 0x181B03FE0
	|-EnumHelper.Caster<byte, IntPtr>..cctor
	|
	|-RVA: 0x1B0E8B0 Offset: 0x1B0CEB0 VA: 0x181B0E8B0
	|-EnumHelper.Caster<byte, object>..cctor
	|
	|-RVA: 0x1B079B0 Offset: 0x1B05FB0 VA: 0x181B079B0
	|-EnumHelper.Caster<byte, sbyte>..cctor
	|
	|-RVA: 0x1B02FB0 Offset: 0x1B015B0 VA: 0x181B02FB0
	|-EnumHelper.Caster<byte, float>..cctor
	|
	|-RVA: 0x1AFA990 Offset: 0x1AF8F90 VA: 0x181AFA990
	|-EnumHelper.Caster<byte, TimeSpan>..cctor
	|
	|-RVA: 0x1AFC0B0 Offset: 0x1AFA6B0 VA: 0x181AFC0B0
	|-EnumHelper.Caster<byte, ushort>..cctor
	|
	|-RVA: 0x1AFE800 Offset: 0x1AFCE00 VA: 0x181AFE800
	|-EnumHelper.Caster<byte, uint>..cctor
	|
	|-RVA: 0x1B0C160 Offset: 0x1B0A760 VA: 0x181B0C160
	|-EnumHelper.Caster<byte, ulong>..cctor
	|
	|-RVA: 0x1AFD330 Offset: 0x1AFB930 VA: 0x181AFD330
	|-EnumHelper.Caster<byte, UIntPtr>..cctor
	|
	|-RVA: 0x1B0DAD0 Offset: 0x1B0C0D0 VA: 0x181B0DAD0
	|-EnumHelper.Caster<short, bool>..cctor
	|
	|-RVA: 0x1AF8930 Offset: 0x1AF6F30 VA: 0x181AF8930
	|-EnumHelper.Caster<short, byte>..cctor
	|
	|-RVA: 0x1AF8490 Offset: 0x1AF6A90 VA: 0x181AF8490
	|-EnumHelper.Caster<short, char>..cctor
	|
	|-RVA: 0x1B01D30 Offset: 0x1B00330 VA: 0x181B01D30
	|-EnumHelper.Caster<short, KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x1B013F0 Offset: 0x1AFF9F0 VA: 0x181B013F0
	|-EnumHelper.Caster<short, DateTime>..cctor
	|
	|-RVA: 0x1B07510 Offset: 0x1B05B10 VA: 0x181B07510
	|-EnumHelper.Caster<short, DateTimeOffset>..cctor
	|
	|-RVA: 0x1AFB520 Offset: 0x1AF9B20 VA: 0x181AFB520
	|-EnumHelper.Caster<short, Decimal>..cctor
	|
	|-RVA: 0x1B0B820 Offset: 0x1B09E20 VA: 0x181B0B820
	|-EnumHelper.Caster<short, EmptyStruct>..cctor
	|
	|-RVA: 0x1AFA4F0 Offset: 0x1AF8AF0 VA: 0x181AFA4F0
	|-EnumHelper.Caster<short, double>..cctor
	|
	|-RVA: 0x1B06730 Offset: 0x1B04D30 VA: 0x181B06730
	|-EnumHelper.Caster<short, Guid>..cctor
	|
	|-RVA: 0x1B05DF0 Offset: 0x1B043F0 VA: 0x181B05DF0
	|-EnumHelper.Caster<short, short>..cctor
	|
	|-RVA: 0x1B00D00 Offset: 0x1AFF300 VA: 0x181B00D00
	|-EnumHelper.Caster<short, int>..cctor
	|
	|-RVA: 0x1AFD580 Offset: 0x1AFBB80 VA: 0x181AFD580
	|-EnumHelper.Caster<short, long>..cctor
	|
	|-RVA: 0x1B08540 Offset: 0x1B06B40 VA: 0x181B08540
	|-EnumHelper.Caster<short, IntPtr>..cctor
	|
	|-RVA: 0x1B021D0 Offset: 0x1B007D0 VA: 0x181B021D0
	|-EnumHelper.Caster<short, object>..cctor
	|
	|-RVA: 0x1B038F0 Offset: 0x1B01EF0 VA: 0x181B038F0
	|-EnumHelper.Caster<short, sbyte>..cctor
	|
	|-RVA: 0x1B09A10 Offset: 0x1B08010 VA: 0x181B09A10
	|-EnumHelper.Caster<short, float>..cctor
	|
	|-RVA: 0x1B097C0 Offset: 0x1B07DC0 VA: 0x181B097C0
	|-EnumHelper.Caster<short, TimeSpan>..cctor
	|
	|-RVA: 0x1B0CF40 Offset: 0x1B0B540 VA: 0x181B0CF40
	|-EnumHelper.Caster<short, ushort>..cctor
	|
	|-RVA: 0x1AFBE60 Offset: 0x1AFA460 VA: 0x181AFBE60
	|-EnumHelper.Caster<short, uint>..cctor
	|
	|-RVA: 0x1AFDEC0 Offset: 0x1AFC4C0 VA: 0x181AFDEC0
	|-EnumHelper.Caster<short, ulong>..cctor
	|
	|-RVA: 0x1B09EB0 Offset: 0x1B084B0 VA: 0x181B09EB0
	|-EnumHelper.Caster<short, UIntPtr>..cctor
	|
	|-RVA: 0x1AF61E0 Offset: 0x1AF47E0 VA: 0x181AF61E0
	|-EnumHelper.Caster<int, bool>..cctor
	|
	|-RVA: 0x1AF94C0 Offset: 0x1AF7AC0 VA: 0x181AF94C0
	|-EnumHelper.Caster<int, byte>..cctor
	|
	|-RVA: 0x1AF9020 Offset: 0x1AF7620 VA: 0x181AF9020
	|-EnumHelper.Caster<int, char>..cctor
	|
	|-RVA: 0x1B0AA40 Offset: 0x1B09040 VA: 0x181B0AA40
	|-EnumHelper.Caster<int, KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x1B082F0 Offset: 0x1B068F0 VA: 0x181B082F0
	|-EnumHelper.Caster<int, DateTime>..cctor
	|
	|-RVA: 0x1AFF140 Offset: 0x1AFD740 VA: 0x181AFF140
	|-EnumHelper.Caster<int, DateTimeOffset>..cctor
	|
	|-RVA: 0x1B04920 Offset: 0x1B02F20 VA: 0x181B04920
	|-EnumHelper.Caster<int, Decimal>..cctor
	|
	|-RVA: 0x1B064E0 Offset: 0x1B04AE0 VA: 0x181B064E0
	|-EnumHelper.Caster<int, EmptyStruct>..cctor
	|
	|-RVA: 0x1AFA050 Offset: 0x1AF8650 VA: 0x181AFA050
	|-EnumHelper.Caster<int, double>..cctor
	|
	|-RVA: 0x1AF6B20 Offset: 0x1AF5120 VA: 0x181AF6B20
	|-EnumHelper.Caster<int, Guid>..cctor
	|
	|-RVA: 0x1AFDA20 Offset: 0x1AFC020 VA: 0x181AFDA20
	|-EnumHelper.Caster<int, short>..cctor
	|
	|-RVA: 0x1AF86E0 Offset: 0x1AF6CE0 VA: 0x181AF86E0
	|-EnumHelper.Caster<int, int>..cctor
	|
	|-RVA: 0x1B0AEE0 Offset: 0x1B094E0 VA: 0x181B0AEE0
	|-EnumHelper.Caster<int, long>..cctor
	|
	|-RVA: 0x1AF68D0 Offset: 0x1AF4ED0 VA: 0x181AF68D0
	|-EnumHelper.Caster<int, IntPtr>..cctor
	|
	|-RVA: 0x1B0B5D0 Offset: 0x1B09BD0 VA: 0x181B0B5D0
	|-EnumHelper.Caster<int, object>..cctor
	|
	|-RVA: 0x1B090D0 Offset: 0x1B076D0 VA: 0x181B090D0
	|-EnumHelper.Caster<int, sbyte>..cctor
	|
	|-RVA: 0x1AFB770 Offset: 0x1AF9D70 VA: 0x181AFB770
	|-EnumHelper.Caster<int, float>..cctor
	|
	|-RVA: 0x1B06E20 Offset: 0x1B05420 VA: 0x181B06E20
	|-EnumHelper.Caster<int, TimeSpan>..cctor
	|
	|-RVA: 0x1B0E660 Offset: 0x1B0CC60 VA: 0x181B0E660
	|-EnumHelper.Caster<int, ushort>..cctor
	|
	|-RVA: 0x1B01640 Offset: 0x1AFFC40 VA: 0x181B01640
	|-EnumHelper.Caster<int, uint>..cctor
	|
	|-RVA: 0x1AF8DD0 Offset: 0x1AF73D0 VA: 0x181AF8DD0
	|-EnumHelper.Caster<int, ulong>..cctor
	|
	|-RVA: 0x1B08790 Offset: 0x1B06D90 VA: 0x181B08790
	|-EnumHelper.Caster<int, UIntPtr>..cctor
	|
	|-RVA: 0x1B04480 Offset: 0x1B02A80 VA: 0x181B04480
	|-EnumHelper.Caster<long, bool>..cctor
	|
	|-RVA: 0x1B00170 Offset: 0x1AFE770 VA: 0x181B00170
	|-EnumHelper.Caster<long, byte>..cctor
	|
	|-RVA: 0x1B03B40 Offset: 0x1B02140 VA: 0x181B03B40
	|-EnumHelper.Caster<long, char>..cctor
	|
	|-RVA: 0x1AF9710 Offset: 0x1AF7D10 VA: 0x181AF9710
	|-EnumHelper.Caster<long, KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x1AFABE0 Offset: 0x1AF91E0 VA: 0x181AFABE0
	|-EnumHelper.Caster<long, DateTime>..cctor
	|
	|-RVA: 0x1B01F80 Offset: 0x1B00580 VA: 0x181B01F80
	|-EnumHelper.Caster<long, DateTimeOffset>..cctor
	|
	|-RVA: 0x1B003C0 Offset: 0x1AFE9C0 VA: 0x181B003C0
	|-EnumHelper.Caster<long, Decimal>..cctor
	|
	|-RVA: 0x1B09320 Offset: 0x1B07920 VA: 0x181B09320
	|-EnumHelper.Caster<long, EmptyStruct>..cctor
	|
	|-RVA: 0x1AF6D70 Offset: 0x1AF5370 VA: 0x181AF6D70
	|-EnumHelper.Caster<long, double>..cctor
	|
	|-RVA: 0x1AFF830 Offset: 0x1AFDE30 VA: 0x181AFF830
	|-EnumHelper.Caster<long, Guid>..cctor
	|
	|-RVA: 0x1B0A7F0 Offset: 0x1B08DF0 VA: 0x181B0A7F0
	|-EnumHelper.Caster<long, short>..cctor
	|
	|-RVA: 0x1B00860 Offset: 0x1AFEE60 VA: 0x181B00860
	|-EnumHelper.Caster<long, int>..cctor
	|
	|-RVA: 0x1AFE360 Offset: 0x1AFC960 VA: 0x181AFE360
	|-EnumHelper.Caster<long, long>..cctor
	|
	|-RVA: 0x1B0F440 Offset: 0x1B0DA40 VA: 0x181B0F440
	|-EnumHelper.Caster<long, IntPtr>..cctor
	|
	|-RVA: 0x1AF9270 Offset: 0x1AF7870 VA: 0x181AF9270
	|-EnumHelper.Caster<long, object>..cctor
	|
	|-RVA: 0x1B0C3B0 Offset: 0x1B0A9B0 VA: 0x181B0C3B0
	|-EnumHelper.Caster<long, sbyte>..cctor
	|
	|-RVA: 0x1AF9BB0 Offset: 0x1AF81B0 VA: 0x181AF9BB0
	|-EnumHelper.Caster<long, float>..cctor
	|
	|-RVA: 0x1AF7DA0 Offset: 0x1AF63A0 VA: 0x181AF7DA0
	|-EnumHelper.Caster<long, TimeSpan>..cctor
	|
	|-RVA: 0x1B05BA0 Offset: 0x1B041A0 VA: 0x181B05BA0
	|-EnumHelper.Caster<long, ushort>..cctor
	|
	|-RVA: 0x1B02B10 Offset: 0x1B01110 VA: 0x181B02B10
	|-EnumHelper.Caster<long, uint>..cctor
	|
	|-RVA: 0x1B0DD20 Offset: 0x1B0C320 VA: 0x181B0DD20
	|-EnumHelper.Caster<long, ulong>..cctor
	|
	|-RVA: 0x1B03200 Offset: 0x1B01800 VA: 0x181B03200
	|-EnumHelper.Caster<long, UIntPtr>..cctor
	|
	|-RVA: 0x1B06290 Offset: 0x1B04890 VA: 0x181B06290
	|-EnumHelper.Caster<object, object>..cctor
	|
	|-RVA: 0x1AFB9C0 Offset: 0x1AF9FC0 VA: 0x181AFB9C0
	|-EnumHelper.Caster<sbyte, bool>..cctor
	|
	|-RVA: 0x1B0EFA0 Offset: 0x1B0D5A0 VA: 0x181B0EFA0
	|-EnumHelper.Caster<sbyte, byte>..cctor
	|
	|-RVA: 0x1AF7B50 Offset: 0x1AF6150 VA: 0x181AF7B50
	|-EnumHelper.Caster<sbyte, char>..cctor
	|
	|-RVA: 0x1B0AC90 Offset: 0x1B09290 VA: 0x181B0AC90
	|-EnumHelper.Caster<sbyte, KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x1AFB2D0 Offset: 0x1AF98D0 VA: 0x181AFB2D0
	|-EnumHelper.Caster<sbyte, DateTime>..cctor
	|
	|-RVA: 0x1AFC7A0 Offset: 0x1AFADA0 VA: 0x181AFC7A0
	|-EnumHelper.Caster<sbyte, DateTimeOffset>..cctor
	|
	|-RVA: 0x1AFCE90 Offset: 0x1AFB490 VA: 0x181AFCE90
	|-EnumHelper.Caster<sbyte, Decimal>..cctor
	|
	|-RVA: 0x1AF6FC0 Offset: 0x1AF55C0 VA: 0x181AF6FC0
	|-EnumHelper.Caster<sbyte, EmptyStruct>..cctor
	|
	|-RVA: 0x1B04230 Offset: 0x1B02830 VA: 0x181B04230
	|-EnumHelper.Caster<sbyte, double>..cctor
	|
	|-RVA: 0x1B05260 Offset: 0x1B03860 VA: 0x181B05260
	|-EnumHelper.Caster<sbyte, Guid>..cctor
	|
	|-RVA: 0x1B0A350 Offset: 0x1B08950 VA: 0x181B0A350
	|-EnumHelper.Caster<sbyte, short>..cctor
	|
	|-RVA: 0x1B0CAA0 Offset: 0x1B0B0A0 VA: 0x181B0CAA0
	|-EnumHelper.Caster<sbyte, int>..cctor
	|
	|-RVA: 0x1AFDC70 Offset: 0x1AFC270 VA: 0x181AFDC70
	|-EnumHelper.Caster<sbyte, long>..cctor
	|
	|-RVA: 0x1B0A100 Offset: 0x1B08700 VA: 0x181B0A100
	|-EnumHelper.Caster<sbyte, IntPtr>..cctor
	|
	|-RVA: 0x1B05010 Offset: 0x1B03610 VA: 0x181B05010
	|-EnumHelper.Caster<sbyte, object>..cctor
	|
	|-RVA: 0x1B0D190 Offset: 0x1B0B790 VA: 0x181B0D190
	|-EnumHelper.Caster<sbyte, sbyte>..cctor
	|
	|-RVA: 0x1B080A0 Offset: 0x1B066A0 VA: 0x181B080A0
	|-EnumHelper.Caster<sbyte, float>..cctor
	|
	|-RVA: 0x1B00F50 Offset: 0x1AFF550 VA: 0x181B00F50
	|-EnumHelper.Caster<sbyte, TimeSpan>..cctor
	|
	|-RVA: 0x1AFAE30 Offset: 0x1AF9430 VA: 0x181AFAE30
	|-EnumHelper.Caster<sbyte, ushort>..cctor
	|
	|-RVA: 0x1B0B130 Offset: 0x1B09730 VA: 0x181B0B130
	|-EnumHelper.Caster<sbyte, uint>..cctor
	|
	|-RVA: 0x1B054B0 Offset: 0x1B03AB0 VA: 0x181B054B0
	|-EnumHelper.Caster<sbyte, ulong>..cctor
	|
	|-RVA: 0x1AF7FF0 Offset: 0x1AF65F0 VA: 0x181AF7FF0
	|-EnumHelper.Caster<sbyte, UIntPtr>..cctor
	|
	|-RVA: 0x1B09570 Offset: 0x1B07B70 VA: 0x181B09570
	|-EnumHelper.Caster<ushort, bool>..cctor
	|
	|-RVA: 0x1B07070 Offset: 0x1B05670 VA: 0x181B07070
	|-EnumHelper.Caster<ushort, byte>..cctor
	|
	|-RVA: 0x1B01AE0 Offset: 0x1B000E0 VA: 0x181B01AE0
	|-EnumHelper.Caster<ushort, char>..cctor
	|
	|-RVA: 0x1B07C00 Offset: 0x1B06200 VA: 0x181B07C00
	|-EnumHelper.Caster<ushort, KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x1B0E1C0 Offset: 0x1B0C7C0 VA: 0x181B0E1C0
	|-EnumHelper.Caster<ushort, DateTime>..cctor
	|
	|-RVA: 0x1B0BA70 Offset: 0x1B0A070 VA: 0x181B0BA70
	|-EnumHelper.Caster<ushort, DateTimeOffset>..cctor
	|
	|-RVA: 0x1B0C600 Offset: 0x1B0AC00 VA: 0x181B0C600
	|-EnumHelper.Caster<ushort, Decimal>..cctor
	|
	|-RVA: 0x1AFD7D0 Offset: 0x1AFBDD0 VA: 0x181AFD7D0
	|-EnumHelper.Caster<ushort, EmptyStruct>..cctor
	|
	|-RVA: 0x1B028C0 Offset: 0x1B00EC0 VA: 0x181B028C0
	|-EnumHelper.Caster<ushort, double>..cctor
	|
	|-RVA: 0x1B02670 Offset: 0x1B00C70 VA: 0x181B02670
	|-EnumHelper.Caster<ushort, Guid>..cctor
	|
	|-RVA: 0x1B05950 Offset: 0x1B03F50 VA: 0x181B05950
	|-EnumHelper.Caster<ushort, short>..cctor
	|
	|-RVA: 0x1B08C30 Offset: 0x1B07230 VA: 0x181B08C30
	|-EnumHelper.Caster<ushort, int>..cctor
	|
	|-RVA: 0x1B01890 Offset: 0x1AFFE90 VA: 0x181B01890
	|-EnumHelper.Caster<ushort, long>..cctor
	|
	|-RVA: 0x1B02420 Offset: 0x1B00A20 VA: 0x181B02420
	|-EnumHelper.Caster<ushort, IntPtr>..cctor
	|
	|-RVA: 0x1B06980 Offset: 0x1B04F80 VA: 0x181B06980
	|-EnumHelper.Caster<ushort, object>..cctor
	|
	|-RVA: 0x1B07760 Offset: 0x1B05D60 VA: 0x181B07760
	|-EnumHelper.Caster<ushort, sbyte>..cctor
	|
	|-RVA: 0x1AFFCD0 Offset: 0x1AFE2D0 VA: 0x181AFFCD0
	|-EnumHelper.Caster<ushort, float>..cctor
	|
	|-RVA: 0x1B0A5A0 Offset: 0x1B08BA0 VA: 0x181B0A5A0
	|-EnumHelper.Caster<ushort, TimeSpan>..cctor
	|
	|-RVA: 0x1AFE110 Offset: 0x1AFC710 VA: 0x181AFE110
	|-EnumHelper.Caster<ushort, ushort>..cctor
	|
	|-RVA: 0x1AFC9F0 Offset: 0x1AFAFF0 VA: 0x181AFC9F0
	|-EnumHelper.Caster<ushort, uint>..cctor
	|
	|-RVA: 0x1B06040 Offset: 0x1B04640 VA: 0x181B06040
	|-EnumHelper.Caster<ushort, ulong>..cctor
	|
	|-RVA: 0x1B036A0 Offset: 0x1B01CA0 VA: 0x181B036A0
	|-EnumHelper.Caster<ushort, UIntPtr>..cctor
	|
	|-RVA: 0x1AF6430 Offset: 0x1AF4A30 VA: 0x181AF6430
	|-EnumHelper.Caster<uint, bool>..cctor
	|
	|-RVA: 0x1AFD0E0 Offset: 0x1AFB6E0 VA: 0x181AFD0E0
	|-EnumHelper.Caster<uint, byte>..cctor
	|
	|-RVA: 0x1AF9E00 Offset: 0x1AF8400 VA: 0x181AF9E00
	|-EnumHelper.Caster<uint, char>..cctor
	|
	|-RVA: 0x1B04B70 Offset: 0x1B03170 VA: 0x181B04B70
	|-EnumHelper.Caster<uint, KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x1B0F8E0 Offset: 0x1B0DEE0 VA: 0x181B0F8E0
	|-EnumHelper.Caster<uint, DateTime>..cctor
	|
	|-RVA: 0x1B0C850 Offset: 0x1B0AE50 VA: 0x181B0C850
	|-EnumHelper.Caster<uint, DateTimeOffset>..cctor
	|
	|-RVA: 0x1AFFA80 Offset: 0x1AFE080 VA: 0x181AFFA80
	|-EnumHelper.Caster<uint, Decimal>..cctor
	|
	|-RVA: 0x1B0F1F0 Offset: 0x1B0D7F0 VA: 0x181B0F1F0
	|-EnumHelper.Caster<uint, EmptyStruct>..cctor
	|
	|-RVA: 0x1AFFF20 Offset: 0x1AFE520 VA: 0x181AFFF20
	|-EnumHelper.Caster<uint, double>..cctor
	|
	|-RVA: 0x1AFEEF0 Offset: 0x1AFD4F0 VA: 0x181AFEEF0
	|-EnumHelper.Caster<uint, Guid>..cctor
	|
	|-RVA: 0x1AF7460 Offset: 0x1AF5A60 VA: 0x181AF7460
	|-EnumHelper.Caster<uint, short>..cctor
	|
	|-RVA: 0x1AFB080 Offset: 0x1AF9680 VA: 0x181AFB080
	|-EnumHelper.Caster<uint, int>..cctor
	|
	|-RVA: 0x1B00610 Offset: 0x1AFEC10 VA: 0x181B00610
	|-EnumHelper.Caster<uint, long>..cctor
	|
	|-RVA: 0x1B046D0 Offset: 0x1B02CD0 VA: 0x181B046D0
	|-EnumHelper.Caster<uint, IntPtr>..cctor
	|
	|-RVA: 0x1B0BF10 Offset: 0x1B0A510 VA: 0x181B0BF10
	|-EnumHelper.Caster<uint, object>..cctor
	|
	|-RVA: 0x1AF8240 Offset: 0x1AF6840 VA: 0x181AF8240
	|-EnumHelper.Caster<uint, sbyte>..cctor
	|
	|-RVA: 0x1B0DF70 Offset: 0x1B0C570 VA: 0x181B0DF70
	|-EnumHelper.Caster<uint, float>..cctor
	|
	|-RVA: 0x1AFA2A0 Offset: 0x1AF88A0 VA: 0x181AFA2A0
	|-EnumHelper.Caster<uint, TimeSpan>..cctor
	|
	|-RVA: 0x1AFE5B0 Offset: 0x1AFCBB0 VA: 0x181AFE5B0
	|-EnumHelper.Caster<uint, ushort>..cctor
	|
	|-RVA: 0x1AF6680 Offset: 0x1AF4C80 VA: 0x181AF6680
	|-EnumHelper.Caster<uint, uint>..cctor
	|
	|-RVA: 0x1AF7900 Offset: 0x1AF5F00 VA: 0x181AF7900
	|-EnumHelper.Caster<uint, ulong>..cctor
	|
	|-RVA: 0x1AFA740 Offset: 0x1AF8D40 VA: 0x181AFA740
	|-EnumHelper.Caster<uint, UIntPtr>..cctor
	|
	|-RVA: 0x1B0D880 Offset: 0x1B0BE80 VA: 0x181B0D880
	|-EnumHelper.Caster<ulong, bool>..cctor
	|
	|-RVA: 0x1B0BCC0 Offset: 0x1B0A2C0 VA: 0x181B0BCC0
	|-EnumHelper.Caster<ulong, byte>..cctor
	|
	|-RVA: 0x1B0D3E0 Offset: 0x1B0B9E0 VA: 0x181B0D3E0
	|-EnumHelper.Caster<ulong, char>..cctor
	|
	|-RVA: 0x1B089E0 Offset: 0x1B06FE0 VA: 0x181B089E0
	|-EnumHelper.Caster<ulong, KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x1AFF390 Offset: 0x1AFD990 VA: 0x181AFF390
	|-EnumHelper.Caster<ulong, DateTime>..cctor
	|
	|-RVA: 0x1B07E50 Offset: 0x1B06450 VA: 0x181B07E50
	|-EnumHelper.Caster<ulong, DateTimeOffset>..cctor
	|
	|-RVA: 0x1B05700 Offset: 0x1B03D00 VA: 0x181B05700
	|-EnumHelper.Caster<ulong, Decimal>..cctor
	|
	|-RVA: 0x1AF8B80 Offset: 0x1AF7180 VA: 0x181AF8B80
	|-EnumHelper.Caster<ulong, EmptyStruct>..cctor
	|
	|-RVA: 0x1B0CCF0 Offset: 0x1B0B2F0 VA: 0x181B0CCF0
	|-EnumHelper.Caster<ulong, double>..cctor
	|
	|-RVA: 0x1AF9960 Offset: 0x1AF7F60 VA: 0x181AF9960
	|-EnumHelper.Caster<ulong, Guid>..cctor
	|
	|-RVA: 0x1B09C60 Offset: 0x1B08260 VA: 0x181B09C60
	|-EnumHelper.Caster<ulong, short>..cctor
	|
	|-RVA: 0x1B0D630 Offset: 0x1B0BC30 VA: 0x181B0D630
	|-EnumHelper.Caster<ulong, int>..cctor
	|
	|-RVA: 0x1AFCC40 Offset: 0x1AFB240 VA: 0x181AFCC40
	|-EnumHelper.Caster<ulong, long>..cctor
	|
	|-RVA: 0x1B072C0 Offset: 0x1B058C0 VA: 0x181B072C0
	|-EnumHelper.Caster<ulong, IntPtr>..cctor
	|
	|-RVA: 0x1B03450 Offset: 0x1B01A50 VA: 0x181B03450
	|-EnumHelper.Caster<ulong, object>..cctor
	|
	|-RVA: 0x1B0ED50 Offset: 0x1B0D350 VA: 0x181B0ED50
	|-EnumHelper.Caster<ulong, sbyte>..cctor
	|
	|-RVA: 0x1AFBC10 Offset: 0x1AFA210 VA: 0x181AFBC10
	|-EnumHelper.Caster<ulong, float>..cctor
	|
	|-RVA: 0x1B011A0 Offset: 0x1AFF7A0 VA: 0x181B011A0
	|-EnumHelper.Caster<ulong, TimeSpan>..cctor
	|
	|-RVA: 0x1B03D90 Offset: 0x1B02390 VA: 0x181B03D90
	|-EnumHelper.Caster<ulong, ushort>..cctor
	|
	|-RVA: 0x1B08E80 Offset: 0x1B07480 VA: 0x181B08E80
	|-EnumHelper.Caster<ulong, uint>..cctor
	|
	|-RVA: 0x1B0E410 Offset: 0x1B0CA10 VA: 0x181B0E410
	|-EnumHelper.Caster<ulong, ulong>..cctor
	|
	|-RVA: 0x1B02D60 Offset: 0x1B01360 VA: 0x181B02D60
	|-EnumHelper.Caster<ulong, UIntPtr>..cctor
	*/

}

internal sealed class EnumerableTypeInfo<IterableType, ElementType> : TraceLoggingTypeInfo<IterableType> // TypeDefIndex: 1514
{	private readonly TraceLoggingTypeInfo<ElementType> elementInfo; // 0x0


	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B4EAB0 Offset: 0x1B4D0B0 VA: 0x181B4EAB0
	|-EnumerableTypeInfo<object, object>.WriteMetadata
	*/

	public override void WriteData(TraceLoggingDataCollector collector, ref IterableType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B4E790 Offset: 0x1B4CD90 VA: 0x181B4E790
	|-EnumerableTypeInfo<object, object>.WriteData
	*/

}

internal sealed class EnumByteTypeInfo<EnumType> : TraceLoggingTypeInfo<EnumType> // TypeDefIndex: 1560
{
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B132B0 Offset: 0x1B118B0 VA: 0x181B132B0
	|-EnumByteTypeInfo<bool>.WriteMetadata
	|
	|-RVA: 0x1B13580 Offset: 0x1B11B80 VA: 0x181B13580
	|-EnumByteTypeInfo<byte>.WriteMetadata
	|
	|-RVA: 0x1B134F0 Offset: 0x1B11AF0 VA: 0x181B134F0
	|-EnumByteTypeInfo<char>.WriteMetadata
	|
	|-RVA: 0x1B137C0 Offset: 0x1B11DC0 VA: 0x181B137C0
	|-EnumByteTypeInfo<KeyValuePair<object, object>>.WriteMetadata
	|
	|-RVA: 0x1B138E0 Offset: 0x1B11EE0 VA: 0x181B138E0
	|-EnumByteTypeInfo<DateTime>.WriteMetadata
	|
	|-RVA: 0x1B136A0 Offset: 0x1B11CA0 VA: 0x181B136A0
	|-EnumByteTypeInfo<DateTimeOffset>.WriteMetadata
	|
	|-RVA: 0x1B13610 Offset: 0x1B11C10 VA: 0x181B13610
	|-EnumByteTypeInfo<Decimal>.WriteMetadata
	|
	|-RVA: 0x1B13970 Offset: 0x1B11F70 VA: 0x181B13970
	|-EnumByteTypeInfo<EmptyStruct>.WriteMetadata
	|
	|-RVA: 0x1B13730 Offset: 0x1B11D30 VA: 0x181B13730
	|-EnumByteTypeInfo<double>.WriteMetadata
	|
	|-RVA: 0x1B13340 Offset: 0x1B11940 VA: 0x181B13340
	|-EnumByteTypeInfo<Guid>.WriteMetadata
	|
	|-RVA: 0x1B13A00 Offset: 0x1B12000 VA: 0x181B13A00
	|-EnumByteTypeInfo<short>.WriteMetadata
	|
	|-RVA: 0x1B13D60 Offset: 0x1B12360 VA: 0x181B13D60
	|-EnumByteTypeInfo<int>.WriteMetadata
	|
	|-RVA: 0x1B13CD0 Offset: 0x1B122D0 VA: 0x181B13CD0
	|-EnumByteTypeInfo<long>.WriteMetadata
	|
	|-RVA: 0x1B13C40 Offset: 0x1B12240 VA: 0x181B13C40
	|-EnumByteTypeInfo<IntPtr>.WriteMetadata
	|
	|-RVA: 0x1B13220 Offset: 0x1B11820 VA: 0x181B13220
	|-EnumByteTypeInfo<object>.WriteMetadata
	|
	|-RVA: 0x1B13B20 Offset: 0x1B12120 VA: 0x181B13B20
	|-EnumByteTypeInfo<sbyte>.WriteMetadata
	|
	|-RVA: 0x1B133D0 Offset: 0x1B119D0 VA: 0x181B133D0
	|-EnumByteTypeInfo<float>.WriteMetadata
	|
	|-RVA: 0x1B13A90 Offset: 0x1B12090 VA: 0x181B13A90
	|-EnumByteTypeInfo<TimeSpan>.WriteMetadata
	|
	|-RVA: 0x1B13460 Offset: 0x1B11A60 VA: 0x181B13460
	|-EnumByteTypeInfo<ushort>.WriteMetadata
	|
	|-RVA: 0x1B13BB0 Offset: 0x1B121B0 VA: 0x181B13BB0
	|-EnumByteTypeInfo<uint>.WriteMetadata
	|
	|-RVA: 0x1B13DF0 Offset: 0x1B123F0 VA: 0x181B13DF0
	|-EnumByteTypeInfo<ulong>.WriteMetadata
	|
	|-RVA: 0x1B13850 Offset: 0x1B11E50 VA: 0x181B13850
	|-EnumByteTypeInfo<UIntPtr>.WriteMetadata
	*/

	public override void WriteData(TraceLoggingDataCollector collector, ref EnumType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B12640 Offset: 0x1B10C40 VA: 0x181B12640
	|-EnumByteTypeInfo<bool>.WriteData
	|
	|-RVA: 0x1B12D10 Offset: 0x1B11310 VA: 0x181B12D10
	|-EnumByteTypeInfo<byte>.WriteData
	|
	|-RVA: 0x1B12780 Offset: 0x1B10D80 VA: 0x181B12780
	|-EnumByteTypeInfo<char>.WriteData
	|
	|-RVA: 0x1B124F0 Offset: 0x1B10AF0 VA: 0x181B124F0
	|-EnumByteTypeInfo<KeyValuePair<object, object>>.WriteData
	|
	|-RVA: 0x1B12B40 Offset: 0x1B11140 VA: 0x181B12B40
	|-EnumByteTypeInfo<DateTime>.WriteData
	|
	|-RVA: 0x1B12440 Offset: 0x1B10A40 VA: 0x181B12440
	|-EnumByteTypeInfo<DateTimeOffset>.WriteData
	|
	|-RVA: 0x1B129F0 Offset: 0x1B10FF0 VA: 0x181B129F0
	|-EnumByteTypeInfo<Decimal>.WriteData
	|
	|-RVA: 0x1B12950 Offset: 0x1B10F50 VA: 0x181B12950
	|-EnumByteTypeInfo<EmptyStruct>.WriteData
	|
	|-RVA: 0x1B12820 Offset: 0x1B10E20 VA: 0x181B12820
	|-EnumByteTypeInfo<double>.WriteData
	|
	|-RVA: 0x1B12DB0 Offset: 0x1B113B0 VA: 0x181B12DB0
	|-EnumByteTypeInfo<Guid>.WriteData
	|
	|-RVA: 0x1B126E0 Offset: 0x1B10CE0 VA: 0x181B126E0
	|-EnumByteTypeInfo<short>.WriteData
	|
	|-RVA: 0x1B128C0 Offset: 0x1B10EC0 VA: 0x181B128C0
	|-EnumByteTypeInfo<int>.WriteData
	|
	|-RVA: 0x1B130E0 Offset: 0x1B116E0 VA: 0x181B130E0
	|-EnumByteTypeInfo<long>.WriteData
	|
	|-RVA: 0x1B13180 Offset: 0x1B11780 VA: 0x181B13180
	|-EnumByteTypeInfo<IntPtr>.WriteData
	|
	|-RVA: 0x1B13040 Offset: 0x1B11640 VA: 0x181B13040
	|-EnumByteTypeInfo<object>.WriteData
	|
	|-RVA: 0x1B125A0 Offset: 0x1B10BA0 VA: 0x181B125A0
	|-EnumByteTypeInfo<sbyte>.WriteData
	|
	|-RVA: 0x1B12F00 Offset: 0x1B11500 VA: 0x181B12F00
	|-EnumByteTypeInfo<float>.WriteData
	|
	|-RVA: 0x1B12E60 Offset: 0x1B11460 VA: 0x181B12E60
	|-EnumByteTypeInfo<TimeSpan>.WriteData
	|
	|-RVA: 0x1B12C70 Offset: 0x1B11270 VA: 0x181B12C70
	|-EnumByteTypeInfo<ushort>.WriteData
	|
	|-RVA: 0x1B12BE0 Offset: 0x1B111E0 VA: 0x181B12BE0
	|-EnumByteTypeInfo<uint>.WriteData
	|
	|-RVA: 0x1B12FA0 Offset: 0x1B115A0 VA: 0x181B12FA0
	|-EnumByteTypeInfo<ulong>.WriteData
	|
	|-RVA: 0x1B12AA0 Offset: 0x1B110A0 VA: 0x181B12AA0
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
	|-RVA: 0x19AD4A0 Offset: 0x19ABAA0 VA: 0x1819AD4A0
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
	|-RVA: 0x2139E80 Offset: 0x2138480 VA: 0x182139E80
	|-EnumSByteTypeInfo<bool>.WriteMetadata
	|
	|-RVA: 0x213A0C0 Offset: 0x21386C0 VA: 0x18213A0C0
	|-EnumSByteTypeInfo<byte>.WriteMetadata
	|
	|-RVA: 0x213A420 Offset: 0x2138A20 VA: 0x18213A420
	|-EnumSByteTypeInfo<char>.WriteMetadata
	|
	|-RVA: 0x213A1E0 Offset: 0x21387E0 VA: 0x18213A1E0
	|-EnumSByteTypeInfo<KeyValuePair<object, object>>.WriteMetadata
	|
	|-RVA: 0x213A4B0 Offset: 0x2138AB0 VA: 0x18213A4B0
	|-EnumSByteTypeInfo<DateTime>.WriteMetadata
	|
	|-RVA: 0x2139DF0 Offset: 0x21383F0 VA: 0x182139DF0
	|-EnumSByteTypeInfo<DateTimeOffset>.WriteMetadata
	|
	|-RVA: 0x213A810 Offset: 0x2138E10 VA: 0x18213A810
	|-EnumSByteTypeInfo<Decimal>.WriteMetadata
	|
	|-RVA: 0x213A5D0 Offset: 0x2138BD0 VA: 0x18213A5D0
	|-EnumSByteTypeInfo<EmptyStruct>.WriteMetadata
	|
	|-RVA: 0x2139CD0 Offset: 0x21382D0 VA: 0x182139CD0
	|-EnumSByteTypeInfo<double>.WriteMetadata
	|
	|-RVA: 0x213A540 Offset: 0x2138B40 VA: 0x18213A540
	|-EnumSByteTypeInfo<Guid>.WriteMetadata
	|
	|-RVA: 0x213A660 Offset: 0x2138C60 VA: 0x18213A660
	|-EnumSByteTypeInfo<short>.WriteMetadata
	|
	|-RVA: 0x2139F10 Offset: 0x2138510 VA: 0x182139F10
	|-EnumSByteTypeInfo<int>.WriteMetadata
	|
	|-RVA: 0x213A270 Offset: 0x2138870 VA: 0x18213A270
	|-EnumSByteTypeInfo<long>.WriteMetadata
	|
	|-RVA: 0x2139D60 Offset: 0x2138360 VA: 0x182139D60
	|-EnumSByteTypeInfo<IntPtr>.WriteMetadata
	|
	|-RVA: 0x213A150 Offset: 0x2138750 VA: 0x18213A150
	|-EnumSByteTypeInfo<object>.WriteMetadata
	|
	|-RVA: 0x213A300 Offset: 0x2138900 VA: 0x18213A300
	|-EnumSByteTypeInfo<sbyte>.WriteMetadata
	|
	|-RVA: 0x213A390 Offset: 0x2138990 VA: 0x18213A390
	|-EnumSByteTypeInfo<float>.WriteMetadata
	|
	|-RVA: 0x213A780 Offset: 0x2138D80 VA: 0x18213A780
	|-EnumSByteTypeInfo<TimeSpan>.WriteMetadata
	|
	|-RVA: 0x213A6F0 Offset: 0x2138CF0 VA: 0x18213A6F0
	|-EnumSByteTypeInfo<ushort>.WriteMetadata
	|
	|-RVA: 0x2139FA0 Offset: 0x21385A0 VA: 0x182139FA0
	|-EnumSByteTypeInfo<uint>.WriteMetadata
	|
	|-RVA: 0x213A030 Offset: 0x2138630 VA: 0x18213A030
	|-EnumSByteTypeInfo<ulong>.WriteMetadata
	|
	|-RVA: 0x1B49840 Offset: 0x1B47E40 VA: 0x181B49840
	|-EnumSByteTypeInfo<UIntPtr>.WriteMetadata
	*/

	public override void WriteData(TraceLoggingDataCollector collector, ref EnumType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21399A0 Offset: 0x2137FA0 VA: 0x1821399A0
	|-EnumSByteTypeInfo<bool>.WriteData
	|
	|-RVA: 0x2139B90 Offset: 0x2138190 VA: 0x182139B90
	|-EnumSByteTypeInfo<byte>.WriteData
	|
	|-RVA: 0x21392A0 Offset: 0x21378A0 VA: 0x1821392A0
	|-EnumSByteTypeInfo<char>.WriteData
	|
	|-RVA: 0x2139530 Offset: 0x2137B30 VA: 0x182139530
	|-EnumSByteTypeInfo<KeyValuePair<object, object>>.WriteData
	|
	|-RVA: 0x2139A40 Offset: 0x2138040 VA: 0x182139A40
	|-EnumSByteTypeInfo<DateTime>.WriteData
	|
	|-RVA: 0x2139AE0 Offset: 0x21380E0 VA: 0x182139AE0
	|-EnumSByteTypeInfo<DateTimeOffset>.WriteData
	|
	|-RVA: 0x21393E0 Offset: 0x21379E0 VA: 0x1821393E0
	|-EnumSByteTypeInfo<Decimal>.WriteData
	|
	|-RVA: 0x2139490 Offset: 0x2137A90 VA: 0x182139490
	|-EnumSByteTypeInfo<EmptyStruct>.WriteData
	|
	|-RVA: 0x2139900 Offset: 0x2137F00 VA: 0x182139900
	|-EnumSByteTypeInfo<double>.WriteData
	|
	|-RVA: 0x2139720 Offset: 0x2137D20 VA: 0x182139720
	|-EnumSByteTypeInfo<Guid>.WriteData
	|
	|-RVA: 0x21397D0 Offset: 0x2137DD0 VA: 0x1821397D0
	|-EnumSByteTypeInfo<short>.WriteData
	|
	|-RVA: 0x21390D0 Offset: 0x21376D0 VA: 0x1821390D0
	|-EnumSByteTypeInfo<int>.WriteData
	|
	|-RVA: 0x2139200 Offset: 0x2137800 VA: 0x182139200
	|-EnumSByteTypeInfo<long>.WriteData
	|
	|-RVA: 0x21395E0 Offset: 0x2137BE0 VA: 0x1821395E0
	|-EnumSByteTypeInfo<IntPtr>.WriteData
	|
	|-RVA: 0x2139160 Offset: 0x2137760 VA: 0x182139160
	|-EnumSByteTypeInfo<object>.WriteData
	|
	|-RVA: 0x2139030 Offset: 0x2137630 VA: 0x182139030
	|-EnumSByteTypeInfo<sbyte>.WriteData
	|
	|-RVA: 0x2139C30 Offset: 0x2138230 VA: 0x182139C30
	|-EnumSByteTypeInfo<float>.WriteData
	|
	|-RVA: 0x2138F90 Offset: 0x2137590 VA: 0x182138F90
	|-EnumSByteTypeInfo<TimeSpan>.WriteData
	|
	|-RVA: 0x2139680 Offset: 0x2137C80 VA: 0x182139680
	|-EnumSByteTypeInfo<ushort>.WriteData
	|
	|-RVA: 0x2139870 Offset: 0x2137E70 VA: 0x182139870
	|-EnumSByteTypeInfo<uint>.WriteData
	|
	|-RVA: 0x2139340 Offset: 0x2137940 VA: 0x182139340
	|-EnumSByteTypeInfo<ulong>.WriteData
	|
	|-RVA: 0x1B497A0 Offset: 0x1B47DA0 VA: 0x181B497A0
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
	|-RVA: 0x19AD4A0 Offset: 0x19ABAA0 VA: 0x1819AD4A0
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
	|-RVA: 0x21354E0 Offset: 0x2133AE0 VA: 0x1821354E0
	|-EnumInt16TypeInfo<bool>.WriteMetadata
	|
	|-RVA: 0x2135180 Offset: 0x2133780 VA: 0x182135180
	|-EnumInt16TypeInfo<byte>.WriteMetadata
	|
	|-RVA: 0x2135720 Offset: 0x2133D20 VA: 0x182135720
	|-EnumInt16TypeInfo<char>.WriteMetadata
	|
	|-RVA: 0x21352A0 Offset: 0x21338A0 VA: 0x1821352A0
	|-EnumInt16TypeInfo<KeyValuePair<object, object>>.WriteMetadata
	|
	|-RVA: 0x21358D0 Offset: 0x2133ED0 VA: 0x1821358D0
	|-EnumInt16TypeInfo<DateTime>.WriteMetadata
	|
	|-RVA: 0x21357B0 Offset: 0x2133DB0 VA: 0x1821357B0
	|-EnumInt16TypeInfo<DateTimeOffset>.WriteMetadata
	|
	|-RVA: 0x2134EB0 Offset: 0x21334B0 VA: 0x182134EB0
	|-EnumInt16TypeInfo<Decimal>.WriteMetadata
	|
	|-RVA: 0x2135A80 Offset: 0x2134080 VA: 0x182135A80
	|-EnumInt16TypeInfo<EmptyStruct>.WriteMetadata
	|
	|-RVA: 0x21350F0 Offset: 0x21336F0 VA: 0x1821350F0
	|-EnumInt16TypeInfo<double>.WriteMetadata
	|
	|-RVA: 0x21359F0 Offset: 0x2133FF0 VA: 0x1821359F0
	|-EnumInt16TypeInfo<Guid>.WriteMetadata
	|
	|-RVA: 0x2135570 Offset: 0x2133B70 VA: 0x182135570
	|-EnumInt16TypeInfo<short>.WriteMetadata
	|
	|-RVA: 0x2135840 Offset: 0x2133E40 VA: 0x182135840
	|-EnumInt16TypeInfo<int>.WriteMetadata
	|
	|-RVA: 0x2135960 Offset: 0x2133F60 VA: 0x182135960
	|-EnumInt16TypeInfo<long>.WriteMetadata
	|
	|-RVA: 0x2134F40 Offset: 0x2133540 VA: 0x182134F40
	|-EnumInt16TypeInfo<IntPtr>.WriteMetadata
	|
	|-RVA: 0x2135690 Offset: 0x2133C90 VA: 0x182135690
	|-EnumInt16TypeInfo<object>.WriteMetadata
	|
	|-RVA: 0x2135060 Offset: 0x2133660 VA: 0x182135060
	|-EnumInt16TypeInfo<sbyte>.WriteMetadata
	|
	|-RVA: 0x21353C0 Offset: 0x21339C0 VA: 0x1821353C0
	|-EnumInt16TypeInfo<float>.WriteMetadata
	|
	|-RVA: 0x2135450 Offset: 0x2133A50 VA: 0x182135450
	|-EnumInt16TypeInfo<TimeSpan>.WriteMetadata
	|
	|-RVA: 0x2135330 Offset: 0x2133930 VA: 0x182135330
	|-EnumInt16TypeInfo<ushort>.WriteMetadata
	|
	|-RVA: 0x2134FD0 Offset: 0x21335D0 VA: 0x182134FD0
	|-EnumInt16TypeInfo<uint>.WriteMetadata
	|
	|-RVA: 0x2135600 Offset: 0x2133C00 VA: 0x182135600
	|-EnumInt16TypeInfo<ulong>.WriteMetadata
	|
	|-RVA: 0x2135210 Offset: 0x2133810 VA: 0x182135210
	|-EnumInt16TypeInfo<UIntPtr>.WriteMetadata
	*/

	public override void WriteData(TraceLoggingDataCollector collector, ref EnumType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2134160 Offset: 0x2132760 VA: 0x182134160
	|-EnumInt16TypeInfo<bool>.WriteData
	|
	|-RVA: 0x21342A0 Offset: 0x21328A0 VA: 0x1821342A0
	|-EnumInt16TypeInfo<byte>.WriteData
	|
	|-RVA: 0x2134990 Offset: 0x2132F90 VA: 0x182134990
	|-EnumInt16TypeInfo<char>.WriteData
	|
	|-RVA: 0x2134CC0 Offset: 0x21332C0 VA: 0x182134CC0
	|-EnumInt16TypeInfo<KeyValuePair<object, object>>.WriteData
	|
	|-RVA: 0x21343E0 Offset: 0x21329E0 VA: 0x1821343E0
	|-EnumInt16TypeInfo<DateTime>.WriteData
	|
	|-RVA: 0x2134520 Offset: 0x2132B20 VA: 0x182134520
	|-EnumInt16TypeInfo<DateTimeOffset>.WriteData
	|
	|-RVA: 0x2134A30 Offset: 0x2133030 VA: 0x182134A30
	|-EnumInt16TypeInfo<Decimal>.WriteData
	|
	|-RVA: 0x2134850 Offset: 0x2132E50 VA: 0x182134850
	|-EnumInt16TypeInfo<EmptyStruct>.WriteData
	|
	|-RVA: 0x21345D0 Offset: 0x2132BD0 VA: 0x1821345D0
	|-EnumInt16TypeInfo<double>.WriteData
	|
	|-RVA: 0x2134AE0 Offset: 0x21330E0 VA: 0x182134AE0
	|-EnumInt16TypeInfo<Guid>.WriteData
	|
	|-RVA: 0x2134670 Offset: 0x2132C70 VA: 0x182134670
	|-EnumInt16TypeInfo<short>.WriteData
	|
	|-RVA: 0x21340D0 Offset: 0x21326D0 VA: 0x1821340D0
	|-EnumInt16TypeInfo<int>.WriteData
	|
	|-RVA: 0x2134D70 Offset: 0x2133370 VA: 0x182134D70
	|-EnumInt16TypeInfo<long>.WriteData
	|
	|-RVA: 0x2134710 Offset: 0x2132D10 VA: 0x182134710
	|-EnumInt16TypeInfo<IntPtr>.WriteData
	|
	|-RVA: 0x2134340 Offset: 0x2132940 VA: 0x182134340
	|-EnumInt16TypeInfo<object>.WriteData
	|
	|-RVA: 0x2134E10 Offset: 0x2133410 VA: 0x182134E10
	|-EnumInt16TypeInfo<sbyte>.WriteData
	|
	|-RVA: 0x2134480 Offset: 0x2132A80 VA: 0x182134480
	|-EnumInt16TypeInfo<float>.WriteData
	|
	|-RVA: 0x21348F0 Offset: 0x2132EF0 VA: 0x1821348F0
	|-EnumInt16TypeInfo<TimeSpan>.WriteData
	|
	|-RVA: 0x2134B90 Offset: 0x2133190 VA: 0x182134B90
	|-EnumInt16TypeInfo<ushort>.WriteData
	|
	|-RVA: 0x2134C30 Offset: 0x2133230 VA: 0x182134C30
	|-EnumInt16TypeInfo<uint>.WriteData
	|
	|-RVA: 0x2134200 Offset: 0x2132800 VA: 0x182134200
	|-EnumInt16TypeInfo<ulong>.WriteData
	|
	|-RVA: 0x21347B0 Offset: 0x2132DB0 VA: 0x1821347B0
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
	|-RVA: 0x19AD4A0 Offset: 0x19ABAA0 VA: 0x1819AD4A0
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
	|-RVA: 0x1B4ABC0 Offset: 0x1B491C0 VA: 0x181B4ABC0
	|-EnumUInt16TypeInfo<bool>.WriteMetadata
	|
	|-RVA: 0x1B4ACE0 Offset: 0x1B492E0 VA: 0x181B4ACE0
	|-EnumUInt16TypeInfo<byte>.WriteMetadata
	|
	|-RVA: 0x1B4B0D0 Offset: 0x1B496D0 VA: 0x181B4B0D0
	|-EnumUInt16TypeInfo<char>.WriteMetadata
	|
	|-RVA: 0x1B4AFB0 Offset: 0x1B495B0 VA: 0x181B4AFB0
	|-EnumUInt16TypeInfo<KeyValuePair<object, object>>.WriteMetadata
	|
	|-RVA: 0x1B4AD70 Offset: 0x1B49370 VA: 0x181B4AD70
	|-EnumUInt16TypeInfo<DateTime>.WriteMetadata
	|
	|-RVA: 0x1B4AAA0 Offset: 0x1B490A0 VA: 0x181B4AAA0
	|-EnumUInt16TypeInfo<DateTimeOffset>.WriteMetadata
	|
	|-RVA: 0x1B4B1F0 Offset: 0x1B497F0 VA: 0x181B4B1F0
	|-EnumUInt16TypeInfo<Decimal>.WriteMetadata
	|
	|-RVA: 0x1B4AE90 Offset: 0x1B49490 VA: 0x181B4AE90
	|-EnumUInt16TypeInfo<EmptyStruct>.WriteMetadata
	|
	|-RVA: 0x1B4A740 Offset: 0x1B48D40 VA: 0x181B4A740
	|-EnumUInt16TypeInfo<double>.WriteMetadata
	|
	|-RVA: 0x1B4A980 Offset: 0x1B48F80 VA: 0x181B4A980
	|-EnumUInt16TypeInfo<Guid>.WriteMetadata
	|
	|-RVA: 0x1B4A7D0 Offset: 0x1B48DD0 VA: 0x181B4A7D0
	|-EnumUInt16TypeInfo<short>.WriteMetadata
	|
	|-RVA: 0x1B4AE00 Offset: 0x1B49400 VA: 0x181B4AE00
	|-EnumUInt16TypeInfo<int>.WriteMetadata
	|
	|-RVA: 0x1B4A6B0 Offset: 0x1B48CB0 VA: 0x181B4A6B0
	|-EnumUInt16TypeInfo<long>.WriteMetadata
	|
	|-RVA: 0x1B4A860 Offset: 0x1B48E60 VA: 0x181B4A860
	|-EnumUInt16TypeInfo<IntPtr>.WriteMetadata
	|
	|-RVA: 0x1B4B040 Offset: 0x1B49640 VA: 0x181B4B040
	|-EnumUInt16TypeInfo<object>.WriteMetadata
	|
	|-RVA: 0x1B4A8F0 Offset: 0x1B48EF0 VA: 0x181B4A8F0
	|-EnumUInt16TypeInfo<sbyte>.WriteMetadata
	|
	|-RVA: 0x1B4B280 Offset: 0x1B49880 VA: 0x181B4B280
	|-EnumUInt16TypeInfo<float>.WriteMetadata
	|
	|-RVA: 0x1B4AA10 Offset: 0x1B49010 VA: 0x181B4AA10
	|-EnumUInt16TypeInfo<TimeSpan>.WriteMetadata
	|
	|-RVA: 0x1B4AC50 Offset: 0x1B49250 VA: 0x181B4AC50
	|-EnumUInt16TypeInfo<ushort>.WriteMetadata
	|
	|-RVA: 0x1B4AB30 Offset: 0x1B49130 VA: 0x181B4AB30
	|-EnumUInt16TypeInfo<uint>.WriteMetadata
	|
	|-RVA: 0x1B4B160 Offset: 0x1B49760 VA: 0x181B4B160
	|-EnumUInt16TypeInfo<ulong>.WriteMetadata
	|
	|-RVA: 0x1B4AF20 Offset: 0x1B49520 VA: 0x181B4AF20
	|-EnumUInt16TypeInfo<UIntPtr>.WriteMetadata
	*/

	public override void WriteData(TraceLoggingDataCollector collector, ref EnumType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B4A190 Offset: 0x1B48790 VA: 0x181B4A190
	|-EnumUInt16TypeInfo<bool>.WriteData
	|
	|-RVA: 0x1B49D40 Offset: 0x1B48340 VA: 0x181B49D40
	|-EnumUInt16TypeInfo<byte>.WriteData
	|
	|-RVA: 0x1B49CA0 Offset: 0x1B482A0 VA: 0x181B49CA0
	|-EnumUInt16TypeInfo<char>.WriteData
	|
	|-RVA: 0x1B4A560 Offset: 0x1B48B60 VA: 0x181B4A560
	|-EnumUInt16TypeInfo<KeyValuePair<object, object>>.WriteData
	|
	|-RVA: 0x1B49F20 Offset: 0x1B48520 VA: 0x181B49F20
	|-EnumUInt16TypeInfo<DateTime>.WriteData
	|
	|-RVA: 0x1B4A230 Offset: 0x1B48830 VA: 0x181B4A230
	|-EnumUInt16TypeInfo<DateTimeOffset>.WriteData
	|
	|-RVA: 0x1B49A10 Offset: 0x1B48010 VA: 0x181B49A10
	|-EnumUInt16TypeInfo<Decimal>.WriteData
	|
	|-RVA: 0x1B498D0 Offset: 0x1B47ED0 VA: 0x181B498D0
	|-EnumUInt16TypeInfo<EmptyStruct>.WriteData
	|
	|-RVA: 0x1B49E80 Offset: 0x1B48480 VA: 0x181B49E80
	|-EnumUInt16TypeInfo<double>.WriteData
	|
	|-RVA: 0x1B4A380 Offset: 0x1B48980 VA: 0x181B4A380
	|-EnumUInt16TypeInfo<Guid>.WriteData
	|
	|-RVA: 0x1B49DE0 Offset: 0x1B483E0 VA: 0x181B49DE0
	|-EnumUInt16TypeInfo<short>.WriteData
	|
	|-RVA: 0x1B4A430 Offset: 0x1B48A30 VA: 0x181B4A430
	|-EnumUInt16TypeInfo<int>.WriteData
	|
	|-RVA: 0x1B49AC0 Offset: 0x1B480C0 VA: 0x181B49AC0
	|-EnumUInt16TypeInfo<long>.WriteData
	|
	|-RVA: 0x1B49C00 Offset: 0x1B48200 VA: 0x181B49C00
	|-EnumUInt16TypeInfo<IntPtr>.WriteData
	|
	|-RVA: 0x1B4A2E0 Offset: 0x1B488E0 VA: 0x181B4A2E0
	|-EnumUInt16TypeInfo<object>.WriteData
	|
	|-RVA: 0x1B4A0F0 Offset: 0x1B486F0 VA: 0x181B4A0F0
	|-EnumUInt16TypeInfo<sbyte>.WriteData
	|
	|-RVA: 0x1B4A610 Offset: 0x1B48C10 VA: 0x181B4A610
	|-EnumUInt16TypeInfo<float>.WriteData
	|
	|-RVA: 0x1B49B60 Offset: 0x1B48160 VA: 0x181B49B60
	|-EnumUInt16TypeInfo<TimeSpan>.WriteData
	|
	|-RVA: 0x1B4A4C0 Offset: 0x1B48AC0 VA: 0x181B4A4C0
	|-EnumUInt16TypeInfo<ushort>.WriteData
	|
	|-RVA: 0x1B49FC0 Offset: 0x1B485C0 VA: 0x181B49FC0
	|-EnumUInt16TypeInfo<uint>.WriteData
	|
	|-RVA: 0x1B4A050 Offset: 0x1B48650 VA: 0x181B4A050
	|-EnumUInt16TypeInfo<ulong>.WriteData
	|
	|-RVA: 0x1B49970 Offset: 0x1B47F70 VA: 0x181B49970
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
	|-RVA: 0x19AD4A0 Offset: 0x19ABAA0 VA: 0x1819AD4A0
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
	|-RVA: 0x2137310 Offset: 0x2135910 VA: 0x182137310
	|-EnumInt32TypeInfo<bool>.WriteMetadata
	|
	|-RVA: 0x21374C0 Offset: 0x2135AC0 VA: 0x1821374C0
	|-EnumInt32TypeInfo<byte>.WriteMetadata
	|
	|-RVA: 0x2137160 Offset: 0x2135760 VA: 0x182137160
	|-EnumInt32TypeInfo<char>.WriteMetadata
	|
	|-RVA: 0x2136F20 Offset: 0x2135520 VA: 0x182136F20
	|-EnumInt32TypeInfo<KeyValuePair<object, object>>.WriteMetadata
	|
	|-RVA: 0x2136AA0 Offset: 0x21350A0 VA: 0x182136AA0
	|-EnumInt32TypeInfo<DateTime>.WriteMetadata
	|
	|-RVA: 0x2136D70 Offset: 0x2135370 VA: 0x182136D70
	|-EnumInt32TypeInfo<DateTimeOffset>.WriteMetadata
	|
	|-RVA: 0x2136BC0 Offset: 0x21351C0 VA: 0x182136BC0
	|-EnumInt32TypeInfo<Decimal>.WriteMetadata
	|
	|-RVA: 0x2136FB0 Offset: 0x21355B0 VA: 0x182136FB0
	|-EnumInt32TypeInfo<EmptyStruct>.WriteMetadata
	|
	|-RVA: 0x2136E00 Offset: 0x2135400 VA: 0x182136E00
	|-EnumInt32TypeInfo<double>.WriteMetadata
	|
	|-RVA: 0x2136980 Offset: 0x2134F80 VA: 0x182136980
	|-EnumInt32TypeInfo<Guid>.WriteMetadata
	|
	|-RVA: 0x2136C50 Offset: 0x2135250 VA: 0x182136C50
	|-EnumInt32TypeInfo<short>.WriteMetadata
	|
	|-RVA: 0x2136E90 Offset: 0x2135490 VA: 0x182136E90
	|-EnumInt32TypeInfo<int>.WriteMetadata
	|
	|-RVA: 0x2136A10 Offset: 0x2135010 VA: 0x182136A10
	|-EnumInt32TypeInfo<long>.WriteMetadata
	|
	|-RVA: 0x2136B30 Offset: 0x2135130 VA: 0x182136B30
	|-EnumInt32TypeInfo<IntPtr>.WriteMetadata
	|
	|-RVA: 0x21373A0 Offset: 0x21359A0 VA: 0x1821373A0
	|-EnumInt32TypeInfo<object>.WriteMetadata
	|
	|-RVA: 0x2137280 Offset: 0x2135880 VA: 0x182137280
	|-EnumInt32TypeInfo<sbyte>.WriteMetadata
	|
	|-RVA: 0x21370D0 Offset: 0x21356D0 VA: 0x1821370D0
	|-EnumInt32TypeInfo<float>.WriteMetadata
	|
	|-RVA: 0x21368F0 Offset: 0x2134EF0 VA: 0x1821368F0
	|-EnumInt32TypeInfo<TimeSpan>.WriteMetadata
	|
	|-RVA: 0x2137040 Offset: 0x2135640 VA: 0x182137040
	|-EnumInt32TypeInfo<ushort>.WriteMetadata
	|
	|-RVA: 0x21371F0 Offset: 0x21357F0 VA: 0x1821371F0
	|-EnumInt32TypeInfo<uint>.WriteMetadata
	|
	|-RVA: 0x2136CE0 Offset: 0x21352E0 VA: 0x182136CE0
	|-EnumInt32TypeInfo<ulong>.WriteMetadata
	|
	|-RVA: 0x2137430 Offset: 0x2135A30 VA: 0x182137430
	|-EnumInt32TypeInfo<UIntPtr>.WriteMetadata
	*/

	public override void WriteData(TraceLoggingDataCollector collector, ref EnumType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2135B10 Offset: 0x2134110 VA: 0x182135B10
	|-EnumInt32TypeInfo<bool>.WriteData
	|
	|-RVA: 0x2136850 Offset: 0x2134E50 VA: 0x182136850
	|-EnumInt32TypeInfo<byte>.WriteData
	|
	|-RVA: 0x21367B0 Offset: 0x2134DB0 VA: 0x1821367B0
	|-EnumInt32TypeInfo<char>.WriteData
	|
	|-RVA: 0x2135C50 Offset: 0x2134250 VA: 0x182135C50
	|-EnumInt32TypeInfo<KeyValuePair<object, object>>.WriteData
	|
	|-RVA: 0x2136220 Offset: 0x2134820 VA: 0x182136220
	|-EnumInt32TypeInfo<DateTime>.WriteData
	|
	|-RVA: 0x2136030 Offset: 0x2134630 VA: 0x182136030
	|-EnumInt32TypeInfo<DateTimeOffset>.WriteData
	|
	|-RVA: 0x2135D00 Offset: 0x2134300 VA: 0x182135D00
	|-EnumInt32TypeInfo<Decimal>.WriteData
	|
	|-RVA: 0x21362C0 Offset: 0x21348C0 VA: 0x1821362C0
	|-EnumInt32TypeInfo<EmptyStruct>.WriteData
	|
	|-RVA: 0x2135DB0 Offset: 0x21343B0 VA: 0x182135DB0
	|-EnumInt32TypeInfo<double>.WriteData
	|
	|-RVA: 0x21365D0 Offset: 0x2134BD0 VA: 0x1821365D0
	|-EnumInt32TypeInfo<Guid>.WriteData
	|
	|-RVA: 0x2135E50 Offset: 0x2134450 VA: 0x182135E50
	|-EnumInt32TypeInfo<short>.WriteData
	|
	|-RVA: 0x2136720 Offset: 0x2134D20 VA: 0x182136720
	|-EnumInt32TypeInfo<int>.WriteData
	|
	|-RVA: 0x2135EF0 Offset: 0x21344F0 VA: 0x182135EF0
	|-EnumInt32TypeInfo<long>.WriteData
	|
	|-RVA: 0x2136680 Offset: 0x2134C80 VA: 0x182136680
	|-EnumInt32TypeInfo<IntPtr>.WriteData
	|
	|-RVA: 0x21364A0 Offset: 0x2134AA0 VA: 0x1821364A0
	|-EnumInt32TypeInfo<object>.WriteData
	|
	|-RVA: 0x2135BB0 Offset: 0x21341B0 VA: 0x182135BB0
	|-EnumInt32TypeInfo<sbyte>.WriteData
	|
	|-RVA: 0x2136180 Offset: 0x2134780 VA: 0x182136180
	|-EnumInt32TypeInfo<float>.WriteData
	|
	|-RVA: 0x2136360 Offset: 0x2134960 VA: 0x182136360
	|-EnumInt32TypeInfo<TimeSpan>.WriteData
	|
	|-RVA: 0x2136400 Offset: 0x2134A00 VA: 0x182136400
	|-EnumInt32TypeInfo<ushort>.WriteData
	|
	|-RVA: 0x2136540 Offset: 0x2134B40 VA: 0x182136540
	|-EnumInt32TypeInfo<uint>.WriteData
	|
	|-RVA: 0x21360E0 Offset: 0x21346E0 VA: 0x1821360E0
	|-EnumInt32TypeInfo<ulong>.WriteData
	|
	|-RVA: 0x2135F90 Offset: 0x2134590 VA: 0x182135F90
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
	|-RVA: 0x19AD4A0 Offset: 0x19ABAA0 VA: 0x1819AD4A0
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
	|-RVA: 0x1B4C960 Offset: 0x1B4AF60 VA: 0x181B4C960
	|-EnumUInt32TypeInfo<bool>.WriteMetadata
	|
	|-RVA: 0x1B4C180 Offset: 0x1B4A780 VA: 0x181B4C180
	|-EnumUInt32TypeInfo<byte>.WriteMetadata
	|
	|-RVA: 0x1B4C690 Offset: 0x1B4AC90 VA: 0x181B4C690
	|-EnumUInt32TypeInfo<char>.WriteMetadata
	|
	|-RVA: 0x1B4C600 Offset: 0x1B4AC00 VA: 0x181B4C600
	|-EnumUInt32TypeInfo<KeyValuePair<object, object>>.WriteMetadata
	|
	|-RVA: 0x1B4C7B0 Offset: 0x1B4ADB0 VA: 0x181B4C7B0
	|-EnumUInt32TypeInfo<DateTime>.WriteMetadata
	|
	|-RVA: 0x1B4C2A0 Offset: 0x1B4A8A0 VA: 0x181B4C2A0
	|-EnumUInt32TypeInfo<DateTimeOffset>.WriteMetadata
	|
	|-RVA: 0x1B4C0F0 Offset: 0x1B4A6F0 VA: 0x181B4C0F0
	|-EnumUInt32TypeInfo<Decimal>.WriteMetadata
	|
	|-RVA: 0x1B4C210 Offset: 0x1B4A810 VA: 0x181B4C210
	|-EnumUInt32TypeInfo<EmptyStruct>.WriteMetadata
	|
	|-RVA: 0x1B4CBA0 Offset: 0x1B4B1A0 VA: 0x181B4CBA0
	|-EnumUInt32TypeInfo<double>.WriteMetadata
	|
	|-RVA: 0x1B4C570 Offset: 0x1B4AB70 VA: 0x181B4C570
	|-EnumUInt32TypeInfo<Guid>.WriteMetadata
	|
	|-RVA: 0x1B4C840 Offset: 0x1B4AE40 VA: 0x181B4C840
	|-EnumUInt32TypeInfo<short>.WriteMetadata
	|
	|-RVA: 0x1B4CA80 Offset: 0x1B4B080 VA: 0x181B4CA80
	|-EnumUInt32TypeInfo<int>.WriteMetadata
	|
	|-RVA: 0x1B4C9F0 Offset: 0x1B4AFF0 VA: 0x181B4C9F0
	|-EnumUInt32TypeInfo<long>.WriteMetadata
	|
	|-RVA: 0x1B4C4E0 Offset: 0x1B4AAE0 VA: 0x181B4C4E0
	|-EnumUInt32TypeInfo<IntPtr>.WriteMetadata
	|
	|-RVA: 0x1B4C3C0 Offset: 0x1B4A9C0 VA: 0x181B4C3C0
	|-EnumUInt32TypeInfo<object>.WriteMetadata
	|
	|-RVA: 0x1B4CCC0 Offset: 0x1B4B2C0 VA: 0x181B4CCC0
	|-EnumUInt32TypeInfo<sbyte>.WriteMetadata
	|
	|-RVA: 0x1B4C720 Offset: 0x1B4AD20 VA: 0x181B4C720
	|-EnumUInt32TypeInfo<float>.WriteMetadata
	|
	|-RVA: 0x1B4CB10 Offset: 0x1B4B110 VA: 0x181B4CB10
	|-EnumUInt32TypeInfo<TimeSpan>.WriteMetadata
	|
	|-RVA: 0x1B4C450 Offset: 0x1B4AA50 VA: 0x181B4C450
	|-EnumUInt32TypeInfo<ushort>.WriteMetadata
	|
	|-RVA: 0x1B4CC30 Offset: 0x1B4B230 VA: 0x181B4CC30
	|-EnumUInt32TypeInfo<uint>.WriteMetadata
	|
	|-RVA: 0x1B4C330 Offset: 0x1B4A930 VA: 0x181B4C330
	|-EnumUInt32TypeInfo<ulong>.WriteMetadata
	|
	|-RVA: 0x1B4C8D0 Offset: 0x1B4AED0 VA: 0x181B4C8D0
	|-EnumUInt32TypeInfo<UIntPtr>.WriteMetadata
	*/

	public override void WriteData(TraceLoggingDataCollector collector, ref EnumType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B4BD20 Offset: 0x1B4A320 VA: 0x181B4BD20
	|-EnumUInt32TypeInfo<bool>.WriteData
	|
	|-RVA: 0x1B4B9E0 Offset: 0x1B49FE0 VA: 0x181B4B9E0
	|-EnumUInt32TypeInfo<byte>.WriteData
	|
	|-RVA: 0x1B4B750 Offset: 0x1B49D50 VA: 0x181B4B750
	|-EnumUInt32TypeInfo<char>.WriteData
	|
	|-RVA: 0x1B4BC70 Offset: 0x1B4A270 VA: 0x181B4BC70
	|-EnumUInt32TypeInfo<KeyValuePair<object, object>>.WriteData
	|
	|-RVA: 0x1B4B310 Offset: 0x1B49910 VA: 0x181B4B310
	|-EnumUInt32TypeInfo<DateTime>.WriteData
	|
	|-RVA: 0x1B4BF00 Offset: 0x1B4A500 VA: 0x181B4BF00
	|-EnumUInt32TypeInfo<DateTimeOffset>.WriteData
	|
	|-RVA: 0x1B4BBC0 Offset: 0x1B4A1C0 VA: 0x181B4BBC0
	|-EnumUInt32TypeInfo<Decimal>.WriteData
	|
	|-RVA: 0x1B4B570 Offset: 0x1B49B70 VA: 0x181B4B570
	|-EnumUInt32TypeInfo<EmptyStruct>.WriteData
	|
	|-RVA: 0x1B4BDC0 Offset: 0x1B4A3C0 VA: 0x181B4BDC0
	|-EnumUInt32TypeInfo<double>.WriteData
	|
	|-RVA: 0x1B4B7F0 Offset: 0x1B49DF0 VA: 0x181B4B7F0
	|-EnumUInt32TypeInfo<Guid>.WriteData
	|
	|-RVA: 0x1B4B3B0 Offset: 0x1B499B0 VA: 0x181B4B3B0
	|-EnumUInt32TypeInfo<short>.WriteData
	|
	|-RVA: 0x1B4B4E0 Offset: 0x1B49AE0 VA: 0x181B4B4E0
	|-EnumUInt32TypeInfo<int>.WriteData
	|
	|-RVA: 0x1B4B8A0 Offset: 0x1B49EA0 VA: 0x181B4B8A0
	|-EnumUInt32TypeInfo<long>.WriteData
	|
	|-RVA: 0x1B4BFB0 Offset: 0x1B4A5B0 VA: 0x181B4BFB0
	|-EnumUInt32TypeInfo<IntPtr>.WriteData
	|
	|-RVA: 0x1B4BE60 Offset: 0x1B4A460 VA: 0x181B4BE60
	|-EnumUInt32TypeInfo<object>.WriteData
	|
	|-RVA: 0x1B4B6B0 Offset: 0x1B49CB0 VA: 0x181B4B6B0
	|-EnumUInt32TypeInfo<sbyte>.WriteData
	|
	|-RVA: 0x1B4B940 Offset: 0x1B49F40 VA: 0x181B4B940
	|-EnumUInt32TypeInfo<float>.WriteData
	|
	|-RVA: 0x1B4C050 Offset: 0x1B4A650 VA: 0x181B4C050
	|-EnumUInt32TypeInfo<TimeSpan>.WriteData
	|
	|-RVA: 0x1B4B610 Offset: 0x1B49C10 VA: 0x181B4B610
	|-EnumUInt32TypeInfo<ushort>.WriteData
	|
	|-RVA: 0x1B4B450 Offset: 0x1B49A50 VA: 0x181B4B450
	|-EnumUInt32TypeInfo<uint>.WriteData
	|
	|-RVA: 0x1B4BA80 Offset: 0x1B4A080 VA: 0x181B4BA80
	|-EnumUInt32TypeInfo<ulong>.WriteData
	|
	|-RVA: 0x1B4BB20 Offset: 0x1B4A120 VA: 0x181B4BB20
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
	|-RVA: 0x19AD4A0 Offset: 0x19ABAA0 VA: 0x1819AD4A0
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
	|-RVA: 0x2138570 Offset: 0x2136B70 VA: 0x182138570
	|-EnumInt64TypeInfo<bool>.WriteMetadata
	|
	|-RVA: 0x21388D0 Offset: 0x2136ED0 VA: 0x1821388D0
	|-EnumInt64TypeInfo<byte>.WriteMetadata
	|
	|-RVA: 0x2138A80 Offset: 0x2137080 VA: 0x182138A80
	|-EnumInt64TypeInfo<char>.WriteMetadata
	|
	|-RVA: 0x2138840 Offset: 0x2136E40 VA: 0x182138840
	|-EnumInt64TypeInfo<KeyValuePair<object, object>>.WriteMetadata
	|
	|-RVA: 0x2138600 Offset: 0x2136C00 VA: 0x182138600
	|-EnumInt64TypeInfo<DateTime>.WriteMetadata
	|
	|-RVA: 0x2138DE0 Offset: 0x21373E0 VA: 0x182138DE0
	|-EnumInt64TypeInfo<DateTimeOffset>.WriteMetadata
	|
	|-RVA: 0x21384E0 Offset: 0x2136AE0 VA: 0x1821384E0
	|-EnumInt64TypeInfo<Decimal>.WriteMetadata
	|
	|-RVA: 0x21383C0 Offset: 0x21369C0 VA: 0x1821383C0
	|-EnumInt64TypeInfo<EmptyStruct>.WriteMetadata
	|
	|-RVA: 0x21387B0 Offset: 0x2136DB0 VA: 0x1821387B0
	|-EnumInt64TypeInfo<double>.WriteMetadata
	|
	|-RVA: 0x2138960 Offset: 0x2136F60 VA: 0x182138960
	|-EnumInt64TypeInfo<Guid>.WriteMetadata
	|
	|-RVA: 0x2138BA0 Offset: 0x21371A0 VA: 0x182138BA0
	|-EnumInt64TypeInfo<short>.WriteMetadata
	|
	|-RVA: 0x2138330 Offset: 0x2136930 VA: 0x182138330
	|-EnumInt64TypeInfo<int>.WriteMetadata
	|
	|-RVA: 0x2138720 Offset: 0x2136D20 VA: 0x182138720
	|-EnumInt64TypeInfo<long>.WriteMetadata
	|
	|-RVA: 0x2138E70 Offset: 0x2137470 VA: 0x182138E70
	|-EnumInt64TypeInfo<IntPtr>.WriteMetadata
	|
	|-RVA: 0x2138B10 Offset: 0x2137110 VA: 0x182138B10
	|-EnumInt64TypeInfo<object>.WriteMetadata
	|
	|-RVA: 0x2138C30 Offset: 0x2137230 VA: 0x182138C30
	|-EnumInt64TypeInfo<sbyte>.WriteMetadata
	|
	|-RVA: 0x2138690 Offset: 0x2136C90 VA: 0x182138690
	|-EnumInt64TypeInfo<float>.WriteMetadata
	|
	|-RVA: 0x2138F00 Offset: 0x2137500 VA: 0x182138F00
	|-EnumInt64TypeInfo<TimeSpan>.WriteMetadata
	|
	|-RVA: 0x2138D50 Offset: 0x2137350 VA: 0x182138D50
	|-EnumInt64TypeInfo<ushort>.WriteMetadata
	|
	|-RVA: 0x2138450 Offset: 0x2136A50 VA: 0x182138450
	|-EnumInt64TypeInfo<uint>.WriteMetadata
	|
	|-RVA: 0x2138CC0 Offset: 0x21372C0 VA: 0x182138CC0
	|-EnumInt64TypeInfo<ulong>.WriteMetadata
	|
	|-RVA: 0x21389F0 Offset: 0x2136FF0 VA: 0x1821389F0
	|-EnumInt64TypeInfo<UIntPtr>.WriteMetadata
	*/

	public override void WriteData(TraceLoggingDataCollector collector, ref EnumType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21380A0 Offset: 0x21366A0 VA: 0x1821380A0
	|-EnumInt64TypeInfo<bool>.WriteData
	|
	|-RVA: 0x2137890 Offset: 0x2135E90 VA: 0x182137890
	|-EnumInt64TypeInfo<byte>.WriteData
	|
	|-RVA: 0x2137D90 Offset: 0x2136390 VA: 0x182137D90
	|-EnumInt64TypeInfo<char>.WriteData
	|
	|-RVA: 0x21381E0 Offset: 0x21367E0 VA: 0x1821381E0
	|-EnumInt64TypeInfo<KeyValuePair<object, object>>.WriteData
	|
	|-RVA: 0x2137930 Offset: 0x2135F30 VA: 0x182137930
	|-EnumInt64TypeInfo<DateTime>.WriteData
	|
	|-RVA: 0x21377E0 Offset: 0x2135DE0 VA: 0x1821377E0
	|-EnumInt64TypeInfo<DateTimeOffset>.WriteData
	|
	|-RVA: 0x2137BA0 Offset: 0x21361A0 VA: 0x182137BA0
	|-EnumInt64TypeInfo<Decimal>.WriteData
	|
	|-RVA: 0x21376A0 Offset: 0x2135CA0 VA: 0x1821376A0
	|-EnumInt64TypeInfo<EmptyStruct>.WriteData
	|
	|-RVA: 0x2138290 Offset: 0x2136890 VA: 0x182138290
	|-EnumInt64TypeInfo<double>.WriteData
	|
	|-RVA: 0x21375F0 Offset: 0x2135BF0 VA: 0x1821375F0
	|-EnumInt64TypeInfo<Guid>.WriteData
	|
	|-RVA: 0x2137F60 Offset: 0x2136560 VA: 0x182137F60
	|-EnumInt64TypeInfo<short>.WriteData
	|
	|-RVA: 0x2137E30 Offset: 0x2136430 VA: 0x182137E30
	|-EnumInt64TypeInfo<int>.WriteData
	|
	|-RVA: 0x2137B00 Offset: 0x2136100 VA: 0x182137B00
	|-EnumInt64TypeInfo<long>.WriteData
	|
	|-RVA: 0x2137EC0 Offset: 0x21364C0 VA: 0x182137EC0
	|-EnumInt64TypeInfo<IntPtr>.WriteData
	|
	|-RVA: 0x2137550 Offset: 0x2135B50 VA: 0x182137550
	|-EnumInt64TypeInfo<object>.WriteData
	|
	|-RVA: 0x2138000 Offset: 0x2136600 VA: 0x182138000
	|-EnumInt64TypeInfo<sbyte>.WriteData
	|
	|-RVA: 0x2138140 Offset: 0x2136740 VA: 0x182138140
	|-EnumInt64TypeInfo<float>.WriteData
	|
	|-RVA: 0x2137740 Offset: 0x2135D40 VA: 0x182137740
	|-EnumInt64TypeInfo<TimeSpan>.WriteData
	|
	|-RVA: 0x2137CF0 Offset: 0x21362F0 VA: 0x182137CF0
	|-EnumInt64TypeInfo<ushort>.WriteData
	|
	|-RVA: 0x2137A70 Offset: 0x2136070 VA: 0x182137A70
	|-EnumInt64TypeInfo<uint>.WriteData
	|
	|-RVA: 0x21379D0 Offset: 0x2135FD0 VA: 0x1821379D0
	|-EnumInt64TypeInfo<ulong>.WriteData
	|
	|-RVA: 0x2137C50 Offset: 0x2136250 VA: 0x182137C50
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
	|-RVA: 0x19AD4A0 Offset: 0x19ABAA0 VA: 0x1819AD4A0
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
	|-RVA: 0x1B4E670 Offset: 0x1B4CC70 VA: 0x181B4E670
	|-EnumUInt64TypeInfo<bool>.WriteMetadata
	|
	|-RVA: 0x1B4E040 Offset: 0x1B4C640 VA: 0x181B4E040
	|-EnumUInt64TypeInfo<byte>.WriteMetadata
	|
	|-RVA: 0x1B4DD70 Offset: 0x1B4C370 VA: 0x181B4DD70
	|-EnumUInt64TypeInfo<char>.WriteMetadata
	|
	|-RVA: 0x1B4E4C0 Offset: 0x1B4CAC0 VA: 0x181B4E4C0
	|-EnumUInt64TypeInfo<KeyValuePair<object, object>>.WriteMetadata
	|
	|-RVA: 0x1B4E550 Offset: 0x1B4CB50 VA: 0x181B4E550
	|-EnumUInt64TypeInfo<DateTime>.WriteMetadata
	|
	|-RVA: 0x1B4DE90 Offset: 0x1B4C490 VA: 0x181B4DE90
	|-EnumUInt64TypeInfo<DateTimeOffset>.WriteMetadata
	|
	|-RVA: 0x1B4DC50 Offset: 0x1B4C250 VA: 0x181B4DC50
	|-EnumUInt64TypeInfo<Decimal>.WriteMetadata
	|
	|-RVA: 0x1B4DCE0 Offset: 0x1B4C2E0 VA: 0x181B4DCE0
	|-EnumUInt64TypeInfo<EmptyStruct>.WriteMetadata
	|
	|-RVA: 0x1B4E430 Offset: 0x1B4CA30 VA: 0x181B4E430
	|-EnumUInt64TypeInfo<double>.WriteMetadata
	|
	|-RVA: 0x1B4DFB0 Offset: 0x1B4C5B0 VA: 0x181B4DFB0
	|-EnumUInt64TypeInfo<Guid>.WriteMetadata
	|
	|-RVA: 0x1B4E3A0 Offset: 0x1B4C9A0 VA: 0x181B4E3A0
	|-EnumUInt64TypeInfo<short>.WriteMetadata
	|
	|-RVA: 0x1B4E1F0 Offset: 0x1B4C7F0 VA: 0x181B4E1F0
	|-EnumUInt64TypeInfo<int>.WriteMetadata
	|
	|-RVA: 0x1B4E700 Offset: 0x1B4CD00 VA: 0x181B4E700
	|-EnumUInt64TypeInfo<long>.WriteMetadata
	|
	|-RVA: 0x1B4E310 Offset: 0x1B4C910 VA: 0x181B4E310
	|-EnumUInt64TypeInfo<IntPtr>.WriteMetadata
	|
	|-RVA: 0x1B4DB30 Offset: 0x1B4C130 VA: 0x181B4DB30
	|-EnumUInt64TypeInfo<object>.WriteMetadata
	|
	|-RVA: 0x1B4DE00 Offset: 0x1B4C400 VA: 0x181B4DE00
	|-EnumUInt64TypeInfo<sbyte>.WriteMetadata
	|
	|-RVA: 0x1B4E5E0 Offset: 0x1B4CBE0 VA: 0x181B4E5E0
	|-EnumUInt64TypeInfo<float>.WriteMetadata
	|
	|-RVA: 0x1B4E280 Offset: 0x1B4C880 VA: 0x181B4E280
	|-EnumUInt64TypeInfo<TimeSpan>.WriteMetadata
	|
	|-RVA: 0x1B4E0D0 Offset: 0x1B4C6D0 VA: 0x181B4E0D0
	|-EnumUInt64TypeInfo<ushort>.WriteMetadata
	|
	|-RVA: 0x1B4DF20 Offset: 0x1B4C520 VA: 0x181B4DF20
	|-EnumUInt64TypeInfo<uint>.WriteMetadata
	|
	|-RVA: 0x1B4DBC0 Offset: 0x1B4C1C0 VA: 0x181B4DBC0
	|-EnumUInt64TypeInfo<ulong>.WriteMetadata
	|
	|-RVA: 0x1B4E160 Offset: 0x1B4C760 VA: 0x181B4E160
	|-EnumUInt64TypeInfo<UIntPtr>.WriteMetadata
	*/

	public override void WriteData(TraceLoggingDataCollector collector, ref EnumType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B4CFD0 Offset: 0x1B4B5D0 VA: 0x181B4CFD0
	|-EnumUInt64TypeInfo<bool>.WriteData
	|
	|-RVA: 0x1B4D1C0 Offset: 0x1B4B7C0 VA: 0x181B4D1C0
	|-EnumUInt64TypeInfo<byte>.WriteData
	|
	|-RVA: 0x1B4CF30 Offset: 0x1B4B530 VA: 0x181B4CF30
	|-EnumUInt64TypeInfo<char>.WriteData
	|
	|-RVA: 0x1B4D7E0 Offset: 0x1B4BDE0 VA: 0x181B4D7E0
	|-EnumUInt64TypeInfo<KeyValuePair<object, object>>.WriteData
	|
	|-RVA: 0x1B4D740 Offset: 0x1B4BD40 VA: 0x181B4D740
	|-EnumUInt64TypeInfo<DateTime>.WriteData
	|
	|-RVA: 0x1B4D070 Offset: 0x1B4B670 VA: 0x181B4D070
	|-EnumUInt64TypeInfo<DateTimeOffset>.WriteData
	|
	|-RVA: 0x1B4D9E0 Offset: 0x1B4BFE0 VA: 0x181B4D9E0
	|-EnumUInt64TypeInfo<Decimal>.WriteData
	|
	|-RVA: 0x1B4D6A0 Offset: 0x1B4BCA0 VA: 0x181B4D6A0
	|-EnumUInt64TypeInfo<EmptyStruct>.WriteData
	|
	|-RVA: 0x1B4D4D0 Offset: 0x1B4BAD0 VA: 0x181B4D4D0
	|-EnumUInt64TypeInfo<double>.WriteData
	|
	|-RVA: 0x1B4D890 Offset: 0x1B4BE90 VA: 0x181B4D890
	|-EnumUInt64TypeInfo<Guid>.WriteData
	|
	|-RVA: 0x1B4D120 Offset: 0x1B4B720 VA: 0x181B4D120
	|-EnumUInt64TypeInfo<short>.WriteData
	|
	|-RVA: 0x1B4D3A0 Offset: 0x1B4B9A0 VA: 0x181B4D3A0
	|-EnumUInt64TypeInfo<int>.WriteData
	|
	|-RVA: 0x1B4D260 Offset: 0x1B4B860 VA: 0x181B4D260
	|-EnumUInt64TypeInfo<long>.WriteData
	|
	|-RVA: 0x1B4DA90 Offset: 0x1B4C090 VA: 0x181B4DA90
	|-EnumUInt64TypeInfo<IntPtr>.WriteData
	|
	|-RVA: 0x1B4D940 Offset: 0x1B4BF40 VA: 0x181B4D940
	|-EnumUInt64TypeInfo<object>.WriteData
	|
	|-RVA: 0x1B4D300 Offset: 0x1B4B900 VA: 0x181B4D300
	|-EnumUInt64TypeInfo<sbyte>.WriteData
	|
	|-RVA: 0x1B4CE90 Offset: 0x1B4B490 VA: 0x181B4CE90
	|-EnumUInt64TypeInfo<float>.WriteData
	|
	|-RVA: 0x1B4D430 Offset: 0x1B4BA30 VA: 0x181B4D430
	|-EnumUInt64TypeInfo<TimeSpan>.WriteData
	|
	|-RVA: 0x1B4D570 Offset: 0x1B4BB70 VA: 0x181B4D570
	|-EnumUInt64TypeInfo<ushort>.WriteData
	|
	|-RVA: 0x1B4D610 Offset: 0x1B4BC10 VA: 0x181B4D610
	|-EnumUInt64TypeInfo<uint>.WriteData
	|
	|-RVA: 0x1B4CD50 Offset: 0x1B4B350 VA: 0x181B4CD50
	|-EnumUInt64TypeInfo<ulong>.WriteData
	|
	|-RVA: 0x1B4CDF0 Offset: 0x1B4B3F0 VA: 0x181B4CDF0
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
	|-RVA: 0x19AD4A0 Offset: 0x19ABAA0 VA: 0x1819AD4A0
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
	|-RVA: 0x1B1AA40 Offset: 0x1B19040 VA: 0x181B1AA40
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
	|-RVA: 0x1179CC0 Offset: 0x11782C0 VA: 0x181179CC0
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
	|-RVA: 0xED4940 Offset: 0xED2F40 VA: 0x180ED4940
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
	|-RVA: 0xED49C0 Offset: 0xED2FC0 VA: 0x180ED49C0
	|-Enumerable.OrderBy<string, string>
	|-Enumerable.OrderBy<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED48C0 Offset: 0xED2EC0 VA: 0x180ED48C0
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
	|-RVA: 0xED4F70 Offset: 0xED3570 VA: 0x180ED4F70
	|-Enumerable.ThenBy<IPlayerInfo, string>
	|-Enumerable.ThenBy<object, object>
	|
	|-RVA: 0xED4E60 Offset: 0xED3460 VA: 0x180ED4E60
	|-Enumerable.ThenBy<ItemBlueprint, Rarity>
	|-Enumerable.ThenBy<object, Int32Enum>
	|
	|-RVA: 0xED4FF0 Offset: 0xED35F0 VA: 0x180ED4FF0
	|-Enumerable.ThenBy<KerningPair, uint>
	|-Enumerable.ThenBy<TMP_GlyphPairAdjustmentRecord, uint>
	|-Enumerable.ThenBy<object, uint>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static IOrderedEnumerable<TSource> ThenByDescending<TSource, TKey>(IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED4BC0 Offset: 0xED31C0 VA: 0x180ED4BC0
	|-Enumerable.ThenByDescending<AccountNotice, DateTime>
	|-Enumerable.ThenByDescending<object, DateTime>
	|
	|-RVA: 0xED4CD0 Offset: 0xED32D0 VA: 0x180ED4CD0
	|-Enumerable.ThenByDescending<ItemBlueprint, int>
	|-Enumerable.ThenByDescending<object, int>
	|
	|-RVA: 0xED4AB0 Offset: 0xED30B0 VA: 0x180ED4AB0
	|-Enumerable.ThenByDescending<Resolution, int>
	|
	|-RVA: 0xED4DE0 Offset: 0xED33E0 VA: 0x180ED4DE0
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
	|-RVA: 0x15A2B40 Offset: 0x15A1140 VA: 0x1815A2B40
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
	|-RVA: 0x15A23C0 Offset: 0x15A09C0 VA: 0x1815A23C0
	|-Enumerable.ToArray<Debugging.EntityInfo>
	|
	|-RVA: 0x15A2D20 Offset: 0x15A1320 VA: 0x1815A2D20
	|-Enumerable.ToArray<GameStat.Stat>
	|
	|-RVA: 0x15A2C80 Offset: 0x15A1280 VA: 0x1815A2C80
	|-Enumerable.ToArray<ItemSkinDirectory.Skin>
	|
	|-RVA: 0x15A2460 Offset: 0x15A0A60 VA: 0x1815A2460
	|-Enumerable.ToArray<FourBitNumber>
	|
	|-RVA: 0x15A2BE0 Offset: 0x15A11E0 VA: 0x1815A2BE0
	|-Enumerable.ToArray<SevenBitNumber>
	|
	|-RVA: 0x15A2A00 Offset: 0x15A1000 VA: 0x1815A2A00
	|-Enumerable.ToArray<Option>
	|
	|-RVA: 0x15A2AA0 Offset: 0x15A10A0 VA: 0x1815A2AA0
	|-Enumerable.ToArray<SkinnedMultiMesh.Part>
	|
	|-RVA: 0x15A26E0 Offset: 0x15A0CE0 VA: 0x1815A26E0
	|-Enumerable.ToArray<InventoryDefId>
	|
	|-RVA: 0x15A2780 Offset: 0x15A0D80 VA: 0x1815A2780
	|-Enumerable.ToArray<InventoryItemId>
	|
	|-RVA: 0x15A2820 Offset: 0x15A0E20 VA: 0x1815A2820
	|-Enumerable.ToArray<InventoryItem>
	|
	|-RVA: 0x15A2500 Offset: 0x15A0B00 VA: 0x1815A2500
	|-Enumerable.ToArray<InventoryRecipe.Ingredient>
	|
	|-RVA: 0x15A28C0 Offset: 0x15A0EC0 VA: 0x1815A28C0
	|-Enumerable.ToArray<InventoryRecipe>
	|
	|-RVA: 0x15A2960 Offset: 0x15A0F60 VA: 0x1815A2960
	|-Enumerable.ToArray<Item>
	|
	|-RVA: 0x15A2280 Offset: 0x15A0880 VA: 0x1815A2280
	|-Enumerable.ToArray<byte>
	|
	|-RVA: 0x15A2320 Offset: 0x15A0920 VA: 0x1815A2320
	|-Enumerable.ToArray<char>
	|
	|-RVA: 0x15A2640 Offset: 0x15A0C40 VA: 0x1815A2640
	|-Enumerable.ToArray<int>
	|
	|-RVA: 0x15A2DC0 Offset: 0x15A13C0 VA: 0x1815A2DC0
	|-Enumerable.ToArray<uint>
	|
	|-RVA: 0x15A25A0 Offset: 0x15A0BA0 VA: 0x1815A25A0
	|-Enumerable.ToArray<KeyCode>
	|-Enumerable.ToArray<Int32Enum>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static List<TSource> ToList<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12ADB50 Offset: 0x12AC150 VA: 0x1812ADB50
	|-Enumerable.ToList<Chat.MuteEntry>
	|
	|-RVA: 0x12ADC90 Offset: 0x12AC290 VA: 0x1812ADC90
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
	|-RVA: 0x12ADAB0 Offset: 0x12AC0B0 VA: 0x1812ADAB0
	|-Enumerable.ToList<PlayerItemRecipe.Ingredient>
	|
	|-RVA: 0x12ADD30 Offset: 0x12AC330 VA: 0x1812ADD30
	|-Enumerable.ToList<ServerInfo>
	|
	|-RVA: 0x12ADDD0 Offset: 0x12AC3D0 VA: 0x1812ADDD0
	|-Enumerable.ToList<ServerInfo>
	|
	|-RVA: 0x12ADA10 Offset: 0x12AC010 VA: 0x1812ADA10
	|-Enumerable.ToList<bool>
	|
	|-RVA: 0x12ADE70 Offset: 0x12AC470 VA: 0x1812ADE70
	|-Enumerable.ToList<float>
	|
	|-RVA: 0x12ADBF0 Offset: 0x12AC1F0 VA: 0x1812ADBF0
	|-Enumerable.ToList<Resolution>
	|
	|-RVA: 0x12ADF10 Offset: 0x12AC510 VA: 0x1812ADF10
	|-Enumerable.ToList<Vector2>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1537FD0 Offset: 0x15365D0 VA: 0x181537FD0
	|-Enumerable.ToDictionary<Input.Button, string>
	|-Enumerable.ToDictionary<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDFBE10 Offset: 0xDFA410 VA: 0x180DFBE10
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
	|-RVA: 0x1537D50 Offset: 0x1536350 VA: 0x181537D50
	|-Enumerable.ToDictionary<IGrouping<string, PrefabData>, string, List<PrefabData>>
	|-Enumerable.ToDictionary<object, object, object>
	|
	|-RVA: 0x15372A0 Offset: 0x15358A0 VA: 0x1815372A0
	|-Enumerable.ToDictionary<KeyValuePair<ulong, Dispatch.ResultCallback>, ulong, Dispatch.ResultCallback>
	|
	|-RVA: 0x1537860 Offset: 0x1535E60 VA: 0x181537860
	|-Enumerable.ToDictionary<object, InventoryDefId, uint>
	|
	|-RVA: 0x15375E0 Offset: 0x1535BE0 VA: 0x1815375E0
	|-Enumerable.ToDictionary<object, int, object>
	|
	|-RVA: 0x1537AD0 Offset: 0x15360D0 VA: 0x181537AD0
	|-Enumerable.ToDictionary<object, object, Int32Enum>
	|
	|-RVA: 0x1538030 Offset: 0x1536630 VA: 0x181538030
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
	|-RVA: 0x15A10F0 Offset: 0x159F6F0 VA: 0x1815A10F0
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
	|-RVA: 0x159FE40 Offset: 0x159E440 VA: 0x18159FE40
	|-Enumerable.First<InventoryItem>
	|
	|-RVA: 0x15A0170 Offset: 0x159E770 VA: 0x1815A0170
	|-Enumerable.First<Item>
	|
	|-RVA: 0x15A0BA0 Offset: 0x159F1A0 VA: 0x1815A0BA0
	|-Enumerable.First<Resolution>
	|
	|-RVA: 0x159FB50 Offset: 0x159E150 VA: 0x18159FB50
	|-Enumerable.First<byte>
	|
	|-RVA: 0x15A0610 Offset: 0x159EC10 VA: 0x1815A0610
	|-Enumerable.First<KeyValuePair<long, object>>
	|
	|-RVA: 0x15A0930 Offset: 0x159EF30 VA: 0x1815A0930
	|-Enumerable.First<KeyValuePair<object, object>>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TSource First<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A0F00 Offset: 0x159F500 VA: 0x1815A0F00
	|-Enumerable.First<Dropdown.OptionData>
	|-Enumerable.First<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TSource FirstOrDefault<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x159F3D0 Offset: 0x159D9D0 VA: 0x18159F3D0
	|-Enumerable.FirstOrDefault<CraftingQueueIcon>
	|-Enumerable.FirstOrDefault<ValueChange<TimeSignature>>
	|-Enumerable.FirstOrDefault<ProjectileWeaponMod>
	|-Enumerable.FirstOrDefault<SocketHandle>
	|-Enumerable.FirstOrDefault<string>
	|-Enumerable.FirstOrDefault<Toggle>
	|-Enumerable.FirstOrDefault<object>
	|
	|-RVA: 0x159E8A0 Offset: 0x159CEA0 VA: 0x18159E8A0
	|-Enumerable.FirstOrDefault<SkeletonDefinition.Bone>
	|
	|-RVA: 0x159F5E0 Offset: 0x159DBE0 VA: 0x18159F5E0
	|-Enumerable.FirstOrDefault<ItemSkinDirectory.Skin>
	|
	|-RVA: 0x159EBF0 Offset: 0x159D1F0 VA: 0x18159EBF0
	|-Enumerable.FirstOrDefault<InventoryRecipe>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TSource FirstOrDefault<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x159F200 Offset: 0x159D800 VA: 0x18159F200
	|-Enumerable.FirstOrDefault<Input.Button>
	|-Enumerable.FirstOrDefault<IPlayerItemDefinition>
	|-Enumerable.FirstOrDefault<Skinnable>
	|-Enumerable.FirstOrDefault<string>
	|-Enumerable.FirstOrDefault<Match>
	|-Enumerable.FirstOrDefault<Toggle>
	|-Enumerable.FirstOrDefault<object>
	|
	|-RVA: 0x159F8A0 Offset: 0x159DEA0 VA: 0x18159F8A0
	|-Enumerable.FirstOrDefault<ItemSkinDirectory.Skin>
	|
	|-RVA: 0x159EF30 Offset: 0x159D530 VA: 0x18159EF30
	|-Enumerable.FirstOrDefault<PetCommandList.PetCommandDesc>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TSource Last<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A1830 Offset: 0x159FE30 VA: 0x1815A1830
	|-Enumerable.Last<string>
	|-Enumerable.Last<KerningPair>
	|-Enumerable.Last<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TSource LastOrDefault<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A1310 Offset: 0x159F910 VA: 0x1815A1310
	|-Enumerable.LastOrDefault<MetricTempoMapValuesCache.AccumulatedMicroseconds>
	|-Enumerable.LastOrDefault<ValueChange<TimeSignature>>
	|-Enumerable.LastOrDefault<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TSource LastOrDefault<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A1610 Offset: 0x159FC10 VA: 0x1815A1610
	|-Enumerable.LastOrDefault<MemberInfo>
	|-Enumerable.LastOrDefault<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TSource Single<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A2000 Offset: 0x15A0600 VA: 0x1815A2000
	|-Enumerable.Single<MemberInfo>
	|-Enumerable.Single<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TSource SingleOrDefault<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A1B50 Offset: 0x15A0150 VA: 0x1815A1B50
	|-Enumerable.SingleOrDefault<MemberInfo>
	|-Enumerable.SingleOrDefault<string>
	|-Enumerable.SingleOrDefault<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TSource SingleOrDefault<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A1DB0 Offset: 0x15A03B0 VA: 0x1815A1DB0
	|-Enumerable.SingleOrDefault<ConstructorInfo>
	|-Enumerable.SingleOrDefault<PlayerEditorConnectionEvents.MessageTypeSubscribers>
	|-Enumerable.SingleOrDefault<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TSource ElementAt<TSource>(IEnumerable<TSource> source, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x159E360 Offset: 0x159C960 VA: 0x18159E360
	|-Enumerable.ElementAt<KeyValuePair<string, JSONNode>>
	|-Enumerable.ElementAt<KeyValuePair<object, object>>
	|
	|-RVA: 0x159E620 Offset: 0x159CC20 VA: 0x18159E620
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
	|-RVA: 0xED40B0 Offset: 0xED26B0 VA: 0x180ED40B0
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
	|-RVA: 0xED44A0 Offset: 0xED2AA0 VA: 0x180ED44A0
	|-Enumerable.Count<ServerInfo>
	|
	|-RVA: 0xED3EB0 Offset: 0xED24B0 VA: 0x180ED3EB0
	|-Enumerable.Count<InventoryItem>
	|
	|-RVA: 0xED3CB0 Offset: 0xED22B0 VA: 0x180ED3CB0
	|-Enumerable.Count<int>
	|
	|-RVA: 0xED46A0 Offset: 0xED2CA0 VA: 0x180ED46A0
	|-Enumerable.Count<float>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static int Count<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED3840 Offset: 0xED1E40 VA: 0x180ED3840
	|-Enumerable.Count<RCon.BannedAddresses>
	|
	|-RVA: 0xED3AC0 Offset: 0xED20C0 VA: 0x180ED3AC0
	|-Enumerable.Count<bool>
	|
	|-RVA: 0xED42B0 Offset: 0xED28B0 VA: 0x180ED42B0
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
	|-RVA: 0xED4A50 Offset: 0xED3050 VA: 0x180ED4A50
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
	|-RVA: 0xED4A90 Offset: 0xED3090 VA: 0x180ED4A90
	|-Enumerable.Sum<SkinnedMultiMesh.Part>
	|-Enumerable.Sum<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static float Sum<TSource>(IEnumerable<TSource> source, Func<TSource, float> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED4A70 Offset: 0xED3070 VA: 0x180ED4A70
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
	|-RVA: 0xED48A0 Offset: 0xED2EA0 VA: 0x180ED48A0
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
	|-RVA: 0x19D0C30 Offset: 0x19CF230 VA: 0x1819D0C30
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
	|-RVA: 0x1650390 Offset: 0x164E990 VA: 0x181650390
	|-Enumerable.Iterator<SkeletonDefinition.Bone>.get_Current
	|-Enumerable.Iterator<InventoryItem.Amount>.get_Current
	|
	|-RVA: 0x176B410 Offset: 0x1769A10 VA: 0x18176B410
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
	|-RVA: 0x12D3C70 Offset: 0x12D2270 VA: 0x1812D3C70
	|-Enumerable.Iterator<ProjectileWeaponMod.Modifier>.get_Current
	|-Enumerable.Iterator<Resolution>.get_Current
	|
	|-RVA: 0xDECF60 Offset: 0xDEB560 VA: 0x180DECF60
	|-Enumerable.Iterator<ServerInfo>.get_Current
	|-Enumerable.Iterator<ServerInfo>.get_Current
	|
	|-RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400
	|-Enumerable.Iterator<InventoryDefId>.get_Current
	|-Enumerable.Iterator<int>.get_Current
	|-Enumerable.Iterator<Int32Enum>.get_Current
	|-Enumerable.Iterator<uint>.get_Current
	|
	|-RVA: 0x11284A0 Offset: 0x1126AA0 VA: 0x1811284A0
	|-Enumerable.Iterator<InventoryRecipe.Ingredient>.get_Current
	|-Enumerable.Iterator<InventoryRecipe>.get_Current
	|-Enumerable.Iterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.get_Current
	|
	|-RVA: 0x13985B0 Offset: 0x1396BB0 VA: 0x1813985B0
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
	|-RVA: 0x19CF9C0 Offset: 0x19CDFC0 VA: 0x1819CF9C0
	|-Enumerable.Iterator<Debugging.EntityInfo>.Dispose
	|-Enumerable.Iterator<WeightedStringList.Container>.Dispose
	|-Enumerable.Iterator<GameStat.Stat>.Dispose
	|-Enumerable.Iterator<PlayerItemRecipe>.Dispose
	|-Enumerable.Iterator<DictionaryEntry>.Dispose
	|-Enumerable.Iterator<KeyValuePair<object, int>>.Dispose
	|-Enumerable.Iterator<KeyValuePair<object, object>>.Dispose
	|-Enumerable.Iterator<KeyValuePair<uint, object>>.Dispose
	|
	|-RVA: 0x19CF9F0 Offset: 0x19CDFF0 VA: 0x1819CF9F0
	|-Enumerable.Iterator<BurstCloth.Chain>.Dispose
	|-Enumerable.Iterator<PathFinder.Point>.Dispose
	|-Enumerable.Iterator<PlayerItemRecipe.Ingredient>.Dispose
	|-Enumerable.Iterator<Achievement>.Dispose
	|-Enumerable.Iterator<InventoryItemId>.Dispose
	|-Enumerable.Iterator<Friend>.Dispose
	|-Enumerable.Iterator<long>.Dispose
	|-Enumerable.Iterator<object>.Dispose
	|
	|-RVA: 0x19CFA50 Offset: 0x19CE050 VA: 0x1819CFA50
	|-Enumerable.Iterator<SkeletonDefinition.Bone>.Dispose
	|-Enumerable.Iterator<InventoryItem.Amount>.Dispose
	|
	|-RVA: 0x19CFA20 Offset: 0x19CE020 VA: 0x1819CFA20
	|-Enumerable.Iterator<ItemSkinDirectory.Skin>.Dispose
	|-Enumerable.Iterator<Option>.Dispose
	|-Enumerable.Iterator<SkinnedMultiMesh.Part>.Dispose
	|-Enumerable.Iterator<InventoryItem>.Dispose
	|
	|-RVA: 0x19CFAA0 Offset: 0x19CE0A0 VA: 0x1819CFAA0
	|-Enumerable.Iterator<FourBitNumber>.Dispose
	|-Enumerable.Iterator<SevenBitNumber>.Dispose
	|-Enumerable.Iterator<bool>.Dispose
	|
	|-RVA: 0x19CFA00 Offset: 0x19CE000 VA: 0x1819CFA00
	|-Enumerable.Iterator<ProjectileWeaponMod.Modifier>.Dispose
	|-Enumerable.Iterator<Resolution>.Dispose
	|
	|-RVA: 0x19CFA70 Offset: 0x19CE070 VA: 0x1819CFA70
	|-Enumerable.Iterator<ServerInfo>.Dispose
	|-Enumerable.Iterator<ServerInfo>.Dispose
	|
	|-RVA: 0x19CF9B0 Offset: 0x19CDFB0 VA: 0x1819CF9B0
	|-Enumerable.Iterator<InventoryDefId>.Dispose
	|-Enumerable.Iterator<int>.Dispose
	|-Enumerable.Iterator<Int32Enum>.Dispose
	|-Enumerable.Iterator<float>.Dispose
	|-Enumerable.Iterator<uint>.Dispose
	|
	|-RVA: 0x19CF9D0 Offset: 0x19CDFD0 VA: 0x1819CF9D0
	|-Enumerable.Iterator<InventoryRecipe.Ingredient>.Dispose
	|-Enumerable.Iterator<InventoryRecipe>.Dispose
	|-Enumerable.Iterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.Dispose
	|
	|-RVA: 0x19CFA40 Offset: 0x19CE040 VA: 0x1819CFA40
	|-Enumerable.Iterator<char>.Dispose
	*/

	public IEnumerator<TSource> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CFAB0 Offset: 0x19CE0B0 VA: 0x1819CFAB0
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
	|-RVA: 0x19D0790 Offset: 0x19CED90 VA: 0x1819D0790
	|-Enumerable.Iterator<Debugging.EntityInfo>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<WeightedStringList.Container>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<GameStat.Stat>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<PlayerItemRecipe>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<DictionaryEntry>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<KeyValuePair<object, int>>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<KeyValuePair<object, object>>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<KeyValuePair<uint, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D0800 Offset: 0x19CEE00 VA: 0x1819D0800
	|-Enumerable.Iterator<BurstCloth.Chain>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<PathFinder.Point>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<PlayerItemRecipe.Ingredient>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<Achievement>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<InventoryItemId>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<Friend>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D0B50 Offset: 0x19CF150 VA: 0x1819D0B50
	|-Enumerable.Iterator<SkeletonDefinition.Bone>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<InventoryItem.Amount>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D0860 Offset: 0x19CEE60 VA: 0x1819D0860
	|-Enumerable.Iterator<ItemSkinDirectory.Skin>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<Option>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<SkinnedMultiMesh.Part>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<InventoryItem>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D0AF0 Offset: 0x19CF0F0 VA: 0x1819D0AF0
	|-Enumerable.Iterator<FourBitNumber>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<SevenBitNumber>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D0A70 Offset: 0x19CF070 VA: 0x1819D0A70
	|-Enumerable.Iterator<ProjectileWeaponMod.Modifier>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<Resolution>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D08E0 Offset: 0x19CEEE0 VA: 0x1819D08E0
	|-Enumerable.Iterator<ServerInfo>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<ServerInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D0A10 Offset: 0x19CF010 VA: 0x1819D0A10
	|-Enumerable.Iterator<InventoryDefId>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<int>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<Int32Enum>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<uint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D0710 Offset: 0x19CED10 VA: 0x1819D0710
	|-Enumerable.Iterator<InventoryRecipe.Ingredient>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<InventoryRecipe>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D0BD0 Offset: 0x19CF1D0 VA: 0x1819D0BD0
	|-Enumerable.Iterator<char>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19AD4A0 Offset: 0x19ABAA0 VA: 0x1819AD4A0
	|-Enumerable.Iterator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D09A0 Offset: 0x19CEFA0 VA: 0x1819D09A0
	|-Enumerable.Iterator<float>.System.Collections.IEnumerator.get_Current
	*/

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1650A10 Offset: 0x164F010 VA: 0x181650A10
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
	|-RVA: 0x19D0530 Offset: 0x19CEB30 VA: 0x1819D0530
	|-Enumerable.Iterator<Debugging.EntityInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D05D0 Offset: 0x19CEBD0 VA: 0x1819D05D0
	|-Enumerable.Iterator<BurstCloth.Chain>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0210 Offset: 0x19CE810 VA: 0x1819D0210
	|-Enumerable.Iterator<SkeletonDefinition.Bone>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFD10 Offset: 0x19CE310 VA: 0x1819CFD10
	|-Enumerable.Iterator<WeightedStringList.Container>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0260 Offset: 0x19CE860 VA: 0x1819D0260
	|-Enumerable.Iterator<GameStat.Stat>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFC20 Offset: 0x19CE220 VA: 0x1819CFC20
	|-Enumerable.Iterator<ItemSkinDirectory.Skin>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0670 Offset: 0x19CEC70 VA: 0x1819D0670
	|-Enumerable.Iterator<FourBitNumber>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFE00 Offset: 0x19CE400 VA: 0x1819CFE00
	|-Enumerable.Iterator<SevenBitNumber>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFC70 Offset: 0x19CE270 VA: 0x1819CFC70
	|-Enumerable.Iterator<PathFinder.Point>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0580 Offset: 0x19CEB80 VA: 0x1819D0580
	|-Enumerable.Iterator<PlayerItemRecipe.Ingredient>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFFE0 Offset: 0x19CE5E0 VA: 0x1819CFFE0
	|-Enumerable.Iterator<PlayerItemRecipe>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFF40 Offset: 0x19CE540 VA: 0x1819CFF40
	|-Enumerable.Iterator<ProjectileWeaponMod.Modifier>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D00D0 Offset: 0x19CE6D0 VA: 0x1819D00D0
	|-Enumerable.Iterator<Option>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFDB0 Offset: 0x19CE3B0 VA: 0x1819CFDB0
	|-Enumerable.Iterator<ServerInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0080 Offset: 0x19CE680 VA: 0x1819D0080
	|-Enumerable.Iterator<SkinnedMultiMesh.Part>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFB30 Offset: 0x19CE130 VA: 0x1819CFB30
	|-Enumerable.Iterator<Achievement>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D04E0 Offset: 0x19CEAE0 VA: 0x1819D04E0
	|-Enumerable.Iterator<InventoryDefId>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0300 Offset: 0x19CE900 VA: 0x1819D0300
	|-Enumerable.Iterator<InventoryItemId>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D06C0 Offset: 0x19CECC0 VA: 0x1819D06C0
	|-Enumerable.Iterator<ServerInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D03F0 Offset: 0x19CE9F0 VA: 0x1819D03F0
	|-Enumerable.Iterator<Friend>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0620 Offset: 0x19CEC20 VA: 0x1819D0620
	|-Enumerable.Iterator<InventoryItem.Amount>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D01C0 Offset: 0x19CE7C0 VA: 0x1819D01C0
	|-Enumerable.Iterator<InventoryItem>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0440 Offset: 0x19CEA40 VA: 0x1819D0440
	|-Enumerable.Iterator<InventoryRecipe.Ingredient>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D02B0 Offset: 0x19CE8B0 VA: 0x1819D02B0
	|-Enumerable.Iterator<InventoryRecipe>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0030 Offset: 0x19CE630 VA: 0x1819D0030
	|-Enumerable.Iterator<bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0350 Offset: 0x19CE950 VA: 0x1819D0350
	|-Enumerable.Iterator<char>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFCC0 Offset: 0x19CE2C0 VA: 0x1819CFCC0
	|-Enumerable.Iterator<DictionaryEntry>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFF90 Offset: 0x19CE590 VA: 0x1819CFF90
	|-Enumerable.Iterator<KeyValuePair<object, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFEA0 Offset: 0x19CE4A0 VA: 0x1819CFEA0
	|-Enumerable.Iterator<KeyValuePair<object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFBD0 Offset: 0x19CE1D0 VA: 0x1819CFBD0
	|-Enumerable.Iterator<KeyValuePair<uint, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0490 Offset: 0x19CEA90 VA: 0x1819D0490
	|-Enumerable.Iterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFB80 Offset: 0x19CE180 VA: 0x1819CFB80
	|-Enumerable.Iterator<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0170 Offset: 0x19CE770 VA: 0x1819D0170
	|-Enumerable.Iterator<Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFEF0 Offset: 0x19CE4F0 VA: 0x1819CFEF0
	|-Enumerable.Iterator<long>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFD60 Offset: 0x19CE360 VA: 0x1819CFD60
	|-Enumerable.Iterator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFE50 Offset: 0x19CE450 VA: 0x1819CFE50
	|-Enumerable.Iterator<float>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D03A0 Offset: 0x19CE9A0 VA: 0x1819D03A0
	|-Enumerable.Iterator<uint>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0120 Offset: 0x19CE720 VA: 0x1819D0120
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
	|-RVA: 0x16A2310 Offset: 0x16A0910 VA: 0x1816A2310
	|-Enumerable.WhereEnumerableIterator<Debugging.EntityInfo>..ctor
	|-Enumerable.WhereEnumerableIterator<GameStat.Stat>..ctor
	|-Enumerable.WhereEnumerableIterator<PlayerItemRecipe>..ctor
	|-Enumerable.WhereEnumerableIterator<ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, object>>..ctor
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<uint, object>>..ctor
	|-Enumerable.WhereEnumerableIterator<Resolution>..ctor
	|
	|-RVA: 0x16A3B70 Offset: 0x16A2170 VA: 0x1816A3B70
	|-Enumerable.WhereEnumerableIterator<SkeletonDefinition.Bone>..ctor
	|
	|-RVA: 0x16A3BE0 Offset: 0x16A21E0 VA: 0x1816A3BE0
	|-Enumerable.WhereEnumerableIterator<ItemSkinDirectory.Skin>..ctor
	|-Enumerable.WhereEnumerableIterator<Option>..ctor
	|-Enumerable.WhereEnumerableIterator<SkinnedMultiMesh.Part>..ctor
	|-Enumerable.WhereEnumerableIterator<InventoryItem>..ctor
	|
	|-RVA: 0x16A2380 Offset: 0x16A0980 VA: 0x1816A2380
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
	|-RVA: 0x16A3C50 Offset: 0x16A2250 VA: 0x1816A3C50
	|-Enumerable.WhereEnumerableIterator<ServerInfo>..ctor
	|
	|-RVA: 0x16A3B00 Offset: 0x16A2100 VA: 0x1816A3B00
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe>..ctor
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>..ctor
	*/

	public override Enumerable.Iterator<TSource> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A1C10 Offset: 0x16A0210 VA: 0x1816A1C10
	|-Enumerable.WhereEnumerableIterator<Debugging.EntityInfo>.Clone
	|-Enumerable.WhereEnumerableIterator<GameStat.Stat>.Clone
	|-Enumerable.WhereEnumerableIterator<PlayerItemRecipe>.Clone
	|-Enumerable.WhereEnumerableIterator<ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, object>>.Clone
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<uint, object>>.Clone
	|-Enumerable.WhereEnumerableIterator<Resolution>.Clone
	|
	|-RVA: 0x16A2470 Offset: 0x16A0A70 VA: 0x1816A2470
	|-Enumerable.WhereEnumerableIterator<SkeletonDefinition.Bone>.Clone
	|
	|-RVA: 0x16A23F0 Offset: 0x16A09F0 VA: 0x1816A23F0
	|-Enumerable.WhereEnumerableIterator<ItemSkinDirectory.Skin>.Clone
	|-Enumerable.WhereEnumerableIterator<Option>.Clone
	|-Enumerable.WhereEnumerableIterator<SkinnedMultiMesh.Part>.Clone
	|-Enumerable.WhereEnumerableIterator<InventoryItem>.Clone
	|
	|-RVA: 0x16A1C90 Offset: 0x16A0290 VA: 0x1816A1C90
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
	|-RVA: 0x16A24F0 Offset: 0x16A0AF0 VA: 0x1816A24F0
	|-Enumerable.WhereEnumerableIterator<ServerInfo>.Clone
	|
	|-RVA: 0x16A2580 Offset: 0x16A0B80 VA: 0x1816A2580
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe>.Clone
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.Clone
	*/

	public override void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D87C0 Offset: 0x19D6DC0 VA: 0x1819D87C0
	|-Enumerable.WhereEnumerableIterator<Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x19D9300 Offset: 0x19D7900 VA: 0x1819D9300
	|-Enumerable.WhereEnumerableIterator<SkeletonDefinition.Bone>.Dispose
	|
	|-RVA: 0x19D8970 Offset: 0x19D6F70 VA: 0x1819D8970
	|-Enumerable.WhereEnumerableIterator<GameStat.Stat>.Dispose
	|
	|-RVA: 0x19D8610 Offset: 0x19D6C10 VA: 0x1819D8610
	|-Enumerable.WhereEnumerableIterator<ItemSkinDirectory.Skin>.Dispose
	|
	|-RVA: 0x19D84F0 Offset: 0x19D6AF0 VA: 0x1819D84F0
	|-Enumerable.WhereEnumerableIterator<FourBitNumber>.Dispose
	|
	|-RVA: 0x19D8CD0 Offset: 0x19D72D0 VA: 0x1819D8CD0
	|-Enumerable.WhereEnumerableIterator<SevenBitNumber>.Dispose
	|
	|-RVA: 0x19D8580 Offset: 0x19D6B80 VA: 0x1819D8580
	|-Enumerable.WhereEnumerableIterator<PathFinder.Point>.Dispose
	|
	|-RVA: 0x19D8A90 Offset: 0x19D7090 VA: 0x1819D8A90
	|-Enumerable.WhereEnumerableIterator<PlayerItemRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x19D88E0 Offset: 0x19D6EE0 VA: 0x1819D88E0
	|-Enumerable.WhereEnumerableIterator<PlayerItemRecipe>.Dispose
	|
	|-RVA: 0x19D8460 Offset: 0x19D6A60 VA: 0x1819D8460
	|-Enumerable.WhereEnumerableIterator<ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x19D8BB0 Offset: 0x19D71B0 VA: 0x1819D8BB0
	|-Enumerable.WhereEnumerableIterator<Option>.Dispose
	|
	|-RVA: 0x19D91E0 Offset: 0x19D77E0 VA: 0x1819D91E0
	|-Enumerable.WhereEnumerableIterator<ServerInfo>.Dispose
	|
	|-RVA: 0x19D83D0 Offset: 0x19D69D0 VA: 0x1819D83D0
	|-Enumerable.WhereEnumerableIterator<SkinnedMultiMesh.Part>.Dispose
	|
	|-RVA: 0x19D8D60 Offset: 0x19D7360 VA: 0x1819D8D60
	|-Enumerable.WhereEnumerableIterator<InventoryItemId>.Dispose
	|
	|-RVA: 0x19D8E80 Offset: 0x19D7480 VA: 0x1819D8E80
	|-Enumerable.WhereEnumerableIterator<InventoryItem>.Dispose
	|
	|-RVA: 0x19D9150 Offset: 0x19D7750 VA: 0x1819D9150
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x19D86A0 Offset: 0x19D6CA0 VA: 0x1819D86A0
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe>.Dispose
	|
	|-RVA: 0x19D8850 Offset: 0x19D6E50 VA: 0x1819D8850
	|-Enumerable.WhereEnumerableIterator<bool>.Dispose
	|
	|-RVA: 0x19D9030 Offset: 0x19D7630 VA: 0x1819D9030
	|-Enumerable.WhereEnumerableIterator<char>.Dispose
	|
	|-RVA: 0x19D8730 Offset: 0x19D6D30 VA: 0x1819D8730
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x19D8FA0 Offset: 0x19D75A0 VA: 0x1819D8FA0
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, object>>.Dispose
	|
	|-RVA: 0x19D8C40 Offset: 0x19D7240 VA: 0x1819D8C40
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<uint, object>>.Dispose
	|
	|-RVA: 0x19D8DF0 Offset: 0x19D73F0 VA: 0x1819D8DF0
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.Dispose
	|
	|-RVA: 0x19D8B20 Offset: 0x19D7120 VA: 0x1819D8B20
	|-Enumerable.WhereEnumerableIterator<int>.Dispose
	|
	|-RVA: 0x19D9270 Offset: 0x19D7870 VA: 0x1819D9270
	|-Enumerable.WhereEnumerableIterator<Int32Enum>.Dispose
	|
	|-RVA: 0x19D8A00 Offset: 0x19D7000 VA: 0x1819D8A00
	|-Enumerable.WhereEnumerableIterator<long>.Dispose
	|
	|-RVA: 0x19D90C0 Offset: 0x19D76C0 VA: 0x1819D90C0
	|-Enumerable.WhereEnumerableIterator<object>.Dispose
	|
	|-RVA: 0x19D8F10 Offset: 0x19D7510 VA: 0x1819D8F10
	|-Enumerable.WhereEnumerableIterator<float>.Dispose
	|
	|-RVA: 0x16A1D10 Offset: 0x16A0310 VA: 0x1816A1D10
	|-Enumerable.WhereEnumerableIterator<uint>.Dispose
	|
	|-RVA: 0x16A1DA0 Offset: 0x16A03A0 VA: 0x1816A1DA0
	|-Enumerable.WhereEnumerableIterator<Resolution>.Dispose
	*/

	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19DB0B0 Offset: 0x19D96B0 VA: 0x1819DB0B0
	|-Enumerable.WhereEnumerableIterator<Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x19DB290 Offset: 0x19D9890 VA: 0x1819DB290
	|-Enumerable.WhereEnumerableIterator<SkeletonDefinition.Bone>.MoveNext
	|
	|-RVA: 0x19D9B30 Offset: 0x19D8130 VA: 0x1819D9B30
	|-Enumerable.WhereEnumerableIterator<GameStat.Stat>.MoveNext
	|
	|-RVA: 0x19DC560 Offset: 0x19DAB60 VA: 0x1819DC560
	|-Enumerable.WhereEnumerableIterator<ItemSkinDirectory.Skin>.MoveNext
	|
	|-RVA: 0x19DC1C0 Offset: 0x19DA7C0 VA: 0x1819DC1C0
	|-Enumerable.WhereEnumerableIterator<FourBitNumber>.MoveNext
	|
	|-RVA: 0x19DA010 Offset: 0x19D8610 VA: 0x1819DA010
	|-Enumerable.WhereEnumerableIterator<SevenBitNumber>.MoveNext
	|
	|-RVA: 0x19DA790 Offset: 0x19D8D90 VA: 0x1819DA790
	|-Enumerable.WhereEnumerableIterator<PathFinder.Point>.MoveNext
	|
	|-RVA: 0x19DA1D0 Offset: 0x19D87D0 VA: 0x1819DA1D0
	|-Enumerable.WhereEnumerableIterator<PlayerItemRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x19DACF0 Offset: 0x19D92F0 VA: 0x1819DACF0
	|-Enumerable.WhereEnumerableIterator<PlayerItemRecipe>.MoveNext
	|
	|-RVA: 0x19DA5B0 Offset: 0x19D8BB0 VA: 0x1819DA5B0
	|-Enumerable.WhereEnumerableIterator<ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x19D95C0 Offset: 0x19D7BC0 VA: 0x1819D95C0
	|-Enumerable.WhereEnumerableIterator<Option>.MoveNext
	|
	|-RVA: 0x19D9D10 Offset: 0x19D8310 VA: 0x1819D9D10
	|-Enumerable.WhereEnumerableIterator<ServerInfo>.MoveNext
	|
	|-RVA: 0x19DAAC0 Offset: 0x19D90C0 VA: 0x1819DAAC0
	|-Enumerable.WhereEnumerableIterator<SkinnedMultiMesh.Part>.MoveNext
	|
	|-RVA: 0x19DBD40 Offset: 0x19DA340 VA: 0x1819DBD40
	|-Enumerable.WhereEnumerableIterator<InventoryItemId>.MoveNext
	|
	|-RVA: 0x19D9390 Offset: 0x19D7990 VA: 0x1819D9390
	|-Enumerable.WhereEnumerableIterator<InventoryItem>.MoveNext
	|
	|-RVA: 0x19DA390 Offset: 0x19D8990 VA: 0x1819DA390
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x19DB4E0 Offset: 0x19D9AE0 VA: 0x1819DB4E0
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe>.MoveNext
	|
	|-RVA: 0x19DBF00 Offset: 0x19DA500 VA: 0x1819DBF00
	|-Enumerable.WhereEnumerableIterator<bool>.MoveNext
	|
	|-RVA: 0x19DC060 Offset: 0x19DA660 VA: 0x1819DC060
	|-Enumerable.WhereEnumerableIterator<char>.MoveNext
	|
	|-RVA: 0x19DAED0 Offset: 0x19D94D0 VA: 0x1819DAED0
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x19D9950 Offset: 0x19D7F50 VA: 0x1819D9950
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0x19DC380 Offset: 0x19DA980 VA: 0x1819DC380
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<uint, object>>.MoveNext
	|
	|-RVA: 0x19DB860 Offset: 0x19D9E60 VA: 0x1819DB860
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.MoveNext
	|
	|-RVA: 0x19DBBE0 Offset: 0x19DA1E0 VA: 0x1819DBBE0
	|-Enumerable.WhereEnumerableIterator<int>.MoveNext
	|
	|-RVA: 0x19D97F0 Offset: 0x19D7DF0 VA: 0x1819D97F0
	|-Enumerable.WhereEnumerableIterator<Int32Enum>.MoveNext
	|
	|-RVA: 0x19DB700 Offset: 0x19D9D00 VA: 0x1819DB700
	|-Enumerable.WhereEnumerableIterator<long>.MoveNext
	|
	|-RVA: 0x19DA950 Offset: 0x19D8F50 VA: 0x1819DA950
	|-Enumerable.WhereEnumerableIterator<object>.MoveNext
	|
	|-RVA: 0x19DBA80 Offset: 0x19DA080 VA: 0x1819DBA80
	|-Enumerable.WhereEnumerableIterator<float>.MoveNext
	|
	|-RVA: 0x16A2010 Offset: 0x16A0610 VA: 0x1816A2010
	|-Enumerable.WhereEnumerableIterator<uint>.MoveNext
	|
	|-RVA: 0x16A1E30 Offset: 0x16A0430 VA: 0x1816A1E30
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
	|-RVA: 0x16A2270 Offset: 0x16A0870 VA: 0x1816A2270
	|-Enumerable.WhereEnumerableIterator<Debugging.EntityInfo>.Where
	|-Enumerable.WhereEnumerableIterator<GameStat.Stat>.Where
	|-Enumerable.WhereEnumerableIterator<PlayerItemRecipe>.Where
	|-Enumerable.WhereEnumerableIterator<ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, int>>.Where
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, object>>.Where
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<uint, object>>.Where
	|-Enumerable.WhereEnumerableIterator<Resolution>.Where
	|
	|-RVA: 0x19DC830 Offset: 0x19DAE30 VA: 0x1819DC830
	|-Enumerable.WhereEnumerableIterator<SkeletonDefinition.Bone>.Where
	|
	|-RVA: 0x19DC790 Offset: 0x19DAD90 VA: 0x1819DC790
	|-Enumerable.WhereEnumerableIterator<ItemSkinDirectory.Skin>.Where
	|-Enumerable.WhereEnumerableIterator<Option>.Where
	|-Enumerable.WhereEnumerableIterator<SkinnedMultiMesh.Part>.Where
	|-Enumerable.WhereEnumerableIterator<InventoryItem>.Where
	|
	|-RVA: 0x16A21D0 Offset: 0x16A07D0 VA: 0x1816A21D0
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
	|-RVA: 0x19DC8D0 Offset: 0x19DAED0 VA: 0x1819DC8D0
	|-Enumerable.WhereEnumerableIterator<ServerInfo>.Where
	|
	|-RVA: 0x19DC970 Offset: 0x19DAF70 VA: 0x1819DC970
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
	|-RVA: 0x16A3B70 Offset: 0x16A2170 VA: 0x1816A3B70
	|-Enumerable.WhereArrayIterator<SkeletonDefinition.Bone>..ctor
	|
	|-RVA: 0x16A2310 Offset: 0x16A0910 VA: 0x1816A2310
	|-Enumerable.WhereArrayIterator<GameStat.Stat>..ctor
	|-Enumerable.WhereArrayIterator<ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereArrayIterator<KeyValuePair<object, object>>..ctor
	|-Enumerable.WhereArrayIterator<KeyValuePair<uint, object>>..ctor
	|
	|-RVA: 0x16A3BE0 Offset: 0x16A21E0 VA: 0x1816A3BE0
	|-Enumerable.WhereArrayIterator<ItemSkinDirectory.Skin>..ctor
	|-Enumerable.WhereArrayIterator<Option>..ctor
	|-Enumerable.WhereArrayIterator<SkinnedMultiMesh.Part>..ctor
	|-Enumerable.WhereArrayIterator<InventoryItem>..ctor
	|
	|-RVA: 0x16A3C50 Offset: 0x16A2250 VA: 0x1816A3C50
	|-Enumerable.WhereArrayIterator<ServerInfo>..ctor
	|
	|-RVA: 0x16A3B00 Offset: 0x16A2100 VA: 0x1816A3B00
	|-Enumerable.WhereArrayIterator<InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereArrayIterator<InventoryRecipe>..ctor
	|-Enumerable.WhereArrayIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>..ctor
	|
	|-RVA: 0x16A2380 Offset: 0x16A0980 VA: 0x1816A2380
	|-Enumerable.WhereArrayIterator<char>..ctor
	|-Enumerable.WhereArrayIterator<int>..ctor
	|-Enumerable.WhereArrayIterator<Int32Enum>..ctor
	|-Enumerable.WhereArrayIterator<object>..ctor
	*/

	public override Enumerable.Iterator<TSource> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A2470 Offset: 0x16A0A70 VA: 0x1816A2470
	|-Enumerable.WhereArrayIterator<SkeletonDefinition.Bone>.Clone
	|
	|-RVA: 0x16A1C10 Offset: 0x16A0210 VA: 0x1816A1C10
	|-Enumerable.WhereArrayIterator<GameStat.Stat>.Clone
	|-Enumerable.WhereArrayIterator<ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereArrayIterator<KeyValuePair<object, object>>.Clone
	|-Enumerable.WhereArrayIterator<KeyValuePair<uint, object>>.Clone
	|
	|-RVA: 0x16A23F0 Offset: 0x16A09F0 VA: 0x1816A23F0
	|-Enumerable.WhereArrayIterator<ItemSkinDirectory.Skin>.Clone
	|-Enumerable.WhereArrayIterator<Option>.Clone
	|-Enumerable.WhereArrayIterator<SkinnedMultiMesh.Part>.Clone
	|-Enumerable.WhereArrayIterator<InventoryItem>.Clone
	|
	|-RVA: 0x16A24F0 Offset: 0x16A0AF0 VA: 0x1816A24F0
	|-Enumerable.WhereArrayIterator<ServerInfo>.Clone
	|
	|-RVA: 0x16A2580 Offset: 0x16A0B80 VA: 0x1816A2580
	|-Enumerable.WhereArrayIterator<InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereArrayIterator<InventoryRecipe>.Clone
	|-Enumerable.WhereArrayIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.Clone
	|
	|-RVA: 0x16A1C90 Offset: 0x16A0290 VA: 0x1816A1C90
	|-Enumerable.WhereArrayIterator<char>.Clone
	|-Enumerable.WhereArrayIterator<int>.Clone
	|-Enumerable.WhereArrayIterator<Int32Enum>.Clone
	|-Enumerable.WhereArrayIterator<object>.Clone
	*/

	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D7780 Offset: 0x19D5D80 VA: 0x1819D7780
	|-Enumerable.WhereArrayIterator<SkeletonDefinition.Bone>.MoveNext
	|
	|-RVA: 0x19D76A0 Offset: 0x19D5CA0 VA: 0x1819D76A0
	|-Enumerable.WhereArrayIterator<GameStat.Stat>.MoveNext
	|-Enumerable.WhereArrayIterator<KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0x19D75A0 Offset: 0x19D5BA0 VA: 0x1819D75A0
	|-Enumerable.WhereArrayIterator<ItemSkinDirectory.Skin>.MoveNext
	|-Enumerable.WhereArrayIterator<Option>.MoveNext
	|
	|-RVA: 0x19D7F20 Offset: 0x19D6520 VA: 0x1819D7F20
	|-Enumerable.WhereArrayIterator<ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x19D73B0 Offset: 0x19D59B0 VA: 0x1819D73B0
	|-Enumerable.WhereArrayIterator<ServerInfo>.MoveNext
	|
	|-RVA: 0x19D7B80 Offset: 0x19D6180 VA: 0x1819D7B80
	|-Enumerable.WhereArrayIterator<SkinnedMultiMesh.Part>.MoveNext
	|
	|-RVA: 0x19D7980 Offset: 0x19D5F80 VA: 0x1819D7980
	|-Enumerable.WhereArrayIterator<InventoryItem>.MoveNext
	|
	|-RVA: 0x19D7A80 Offset: 0x19D6080 VA: 0x1819D7A80
	|-Enumerable.WhereArrayIterator<InventoryRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereArrayIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.MoveNext
	|
	|-RVA: 0x19D7E20 Offset: 0x19D6420 VA: 0x1819D7E20
	|-Enumerable.WhereArrayIterator<InventoryRecipe>.MoveNext
	|
	|-RVA: 0x19D72F0 Offset: 0x19D58F0 VA: 0x1819D72F0
	|-Enumerable.WhereArrayIterator<char>.MoveNext
	|
	|-RVA: 0x19D7D40 Offset: 0x19D6340 VA: 0x1819D7D40
	|-Enumerable.WhereArrayIterator<KeyValuePair<uint, object>>.MoveNext
	|
	|-RVA: 0x19D7C80 Offset: 0x19D6280 VA: 0x1819D7C80
	|-Enumerable.WhereArrayIterator<int>.MoveNext
	|-Enumerable.WhereArrayIterator<Int32Enum>.MoveNext
	|
	|-RVA: 0x19D78B0 Offset: 0x19D5EB0 VA: 0x1819D78B0
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
	|-RVA: 0x19D81F0 Offset: 0x19D67F0 VA: 0x1819D81F0
	|-Enumerable.WhereArrayIterator<SkeletonDefinition.Bone>.Where
	|
	|-RVA: 0x19D8150 Offset: 0x19D6750 VA: 0x1819D8150
	|-Enumerable.WhereArrayIterator<GameStat.Stat>.Where
	|-Enumerable.WhereArrayIterator<ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereArrayIterator<KeyValuePair<object, object>>.Where
	|-Enumerable.WhereArrayIterator<KeyValuePair<uint, object>>.Where
	|
	|-RVA: 0x19D8010 Offset: 0x19D6610 VA: 0x1819D8010
	|-Enumerable.WhereArrayIterator<ItemSkinDirectory.Skin>.Where
	|-Enumerable.WhereArrayIterator<Option>.Where
	|-Enumerable.WhereArrayIterator<SkinnedMultiMesh.Part>.Where
	|-Enumerable.WhereArrayIterator<InventoryItem>.Where
	|
	|-RVA: 0x19D8290 Offset: 0x19D6890 VA: 0x1819D8290
	|-Enumerable.WhereArrayIterator<ServerInfo>.Where
	|
	|-RVA: 0x19D8330 Offset: 0x19D6930 VA: 0x1819D8330
	|-Enumerable.WhereArrayIterator<InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereArrayIterator<InventoryRecipe>.Where
	|-Enumerable.WhereArrayIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.Where
	|
	|-RVA: 0x19D80B0 Offset: 0x19D66B0 VA: 0x1819D80B0
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
	|-RVA: 0x16A3B70 Offset: 0x16A2170 VA: 0x1816A3B70
	|-Enumerable.WhereListIterator<SkeletonDefinition.Bone>..ctor
	|
	|-RVA: 0x16A2310 Offset: 0x16A0910 VA: 0x1816A2310
	|-Enumerable.WhereListIterator<GameStat.Stat>..ctor
	|-Enumerable.WhereListIterator<ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereListIterator<KeyValuePair<object, object>>..ctor
	|-Enumerable.WhereListIterator<KeyValuePair<uint, object>>..ctor
	|
	|-RVA: 0x16A3BE0 Offset: 0x16A21E0 VA: 0x1816A3BE0
	|-Enumerable.WhereListIterator<ItemSkinDirectory.Skin>..ctor
	|-Enumerable.WhereListIterator<Option>..ctor
	|-Enumerable.WhereListIterator<SkinnedMultiMesh.Part>..ctor
	|-Enumerable.WhereListIterator<InventoryItem>..ctor
	|
	|-RVA: 0x16A3C50 Offset: 0x16A2250 VA: 0x1816A3C50
	|-Enumerable.WhereListIterator<ServerInfo>..ctor
	|
	|-RVA: 0x16A3B00 Offset: 0x16A2100 VA: 0x1816A3B00
	|-Enumerable.WhereListIterator<InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereListIterator<InventoryRecipe>..ctor
	|-Enumerable.WhereListIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>..ctor
	|
	|-RVA: 0x16A2380 Offset: 0x16A0980 VA: 0x1816A2380
	|-Enumerable.WhereListIterator<char>..ctor
	|-Enumerable.WhereListIterator<int>..ctor
	|-Enumerable.WhereListIterator<Int32Enum>..ctor
	|-Enumerable.WhereListIterator<object>..ctor
	*/

	public override Enumerable.Iterator<TSource> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A2470 Offset: 0x16A0A70 VA: 0x1816A2470
	|-Enumerable.WhereListIterator<SkeletonDefinition.Bone>.Clone
	|
	|-RVA: 0x16A1C10 Offset: 0x16A0210 VA: 0x1816A1C10
	|-Enumerable.WhereListIterator<GameStat.Stat>.Clone
	|-Enumerable.WhereListIterator<ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereListIterator<KeyValuePair<object, object>>.Clone
	|-Enumerable.WhereListIterator<KeyValuePair<uint, object>>.Clone
	|
	|-RVA: 0x16A23F0 Offset: 0x16A09F0 VA: 0x1816A23F0
	|-Enumerable.WhereListIterator<ItemSkinDirectory.Skin>.Clone
	|-Enumerable.WhereListIterator<Option>.Clone
	|-Enumerable.WhereListIterator<SkinnedMultiMesh.Part>.Clone
	|-Enumerable.WhereListIterator<InventoryItem>.Clone
	|
	|-RVA: 0x16A24F0 Offset: 0x16A0AF0 VA: 0x1816A24F0
	|-Enumerable.WhereListIterator<ServerInfo>.Clone
	|
	|-RVA: 0x16A2580 Offset: 0x16A0B80 VA: 0x1816A2580
	|-Enumerable.WhereListIterator<InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereListIterator<InventoryRecipe>.Clone
	|-Enumerable.WhereListIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.Clone
	|
	|-RVA: 0x16A1C90 Offset: 0x16A0290 VA: 0x1816A1C90
	|-Enumerable.WhereListIterator<char>.Clone
	|-Enumerable.WhereListIterator<int>.Clone
	|-Enumerable.WhereListIterator<Int32Enum>.Clone
	|-Enumerable.WhereListIterator<object>.Clone
	*/

	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A2600 Offset: 0x16A0C00 VA: 0x1816A2600
	|-Enumerable.WhereListIterator<SkeletonDefinition.Bone>.MoveNext
	|
	|-RVA: 0x16A2780 Offset: 0x16A0D80 VA: 0x1816A2780
	|-Enumerable.WhereListIterator<GameStat.Stat>.MoveNext
	|-Enumerable.WhereListIterator<KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0x16A2B10 Offset: 0x16A1110 VA: 0x1816A2B10
	|-Enumerable.WhereListIterator<ItemSkinDirectory.Skin>.MoveNext
	|-Enumerable.WhereListIterator<Option>.MoveNext
	|
	|-RVA: 0x16A28A0 Offset: 0x16A0EA0 VA: 0x1816A28A0
	|-Enumerable.WhereListIterator<ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x16A2C60 Offset: 0x16A1260 VA: 0x1816A2C60
	|-Enumerable.WhereListIterator<ServerInfo>.MoveNext
	|
	|-RVA: 0x16A34F0 Offset: 0x16A1AF0 VA: 0x1816A34F0
	|-Enumerable.WhereListIterator<SkinnedMultiMesh.Part>.MoveNext
	|
	|-RVA: 0x16A29C0 Offset: 0x16A0FC0 VA: 0x1816A29C0
	|-Enumerable.WhereListIterator<InventoryItem>.MoveNext
	|
	|-RVA: 0x16A3110 Offset: 0x16A1710 VA: 0x1816A3110
	|-Enumerable.WhereListIterator<InventoryRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereListIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.MoveNext
	|
	|-RVA: 0x16A3390 Offset: 0x16A1990 VA: 0x1816A3390
	|-Enumerable.WhereListIterator<InventoryRecipe>.MoveNext
	|
	|-RVA: 0x16A3640 Offset: 0x16A1C40 VA: 0x1816A3640
	|-Enumerable.WhereListIterator<char>.MoveNext
	|
	|-RVA: 0x16A3270 Offset: 0x16A1870 VA: 0x1816A3270
	|-Enumerable.WhereListIterator<KeyValuePair<uint, object>>.MoveNext
	|
	|-RVA: 0x16A3010 Offset: 0x16A1610 VA: 0x1816A3010
	|-Enumerable.WhereListIterator<int>.MoveNext
	|-Enumerable.WhereListIterator<Int32Enum>.MoveNext
	|
	|-RVA: 0x16A2F00 Offset: 0x16A1500 VA: 0x1816A2F00
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
	|-RVA: 0x16A3A60 Offset: 0x16A2060 VA: 0x1816A3A60
	|-Enumerable.WhereListIterator<SkeletonDefinition.Bone>.Where
	|
	|-RVA: 0x16A3740 Offset: 0x16A1D40 VA: 0x1816A3740
	|-Enumerable.WhereListIterator<GameStat.Stat>.Where
	|-Enumerable.WhereListIterator<ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereListIterator<KeyValuePair<object, object>>.Where
	|-Enumerable.WhereListIterator<KeyValuePair<uint, object>>.Where
	|
	|-RVA: 0x16A37E0 Offset: 0x16A1DE0 VA: 0x1816A37E0
	|-Enumerable.WhereListIterator<ItemSkinDirectory.Skin>.Where
	|-Enumerable.WhereListIterator<Option>.Where
	|-Enumerable.WhereListIterator<SkinnedMultiMesh.Part>.Where
	|-Enumerable.WhereListIterator<InventoryItem>.Where
	|
	|-RVA: 0x16A39C0 Offset: 0x16A1FC0 VA: 0x1816A39C0
	|-Enumerable.WhereListIterator<ServerInfo>.Where
	|
	|-RVA: 0x16A3920 Offset: 0x16A1F20 VA: 0x1816A3920
	|-Enumerable.WhereListIterator<InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereListIterator<InventoryRecipe>.Where
	|-Enumerable.WhereListIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.Where
	|
	|-RVA: 0x16A3880 Offset: 0x16A1E80 VA: 0x1816A3880
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
	|-RVA: 0x16A8F20 Offset: 0x16A7520 VA: 0x1816A8F20
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
	|-RVA: 0x16A8FB0 Offset: 0x16A75B0 VA: 0x1816A8FB0
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
	|-RVA: 0x16A90D0 Offset: 0x16A76D0 VA: 0x1816A90D0
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
	|-RVA: 0x16A9040 Offset: 0x16A7640 VA: 0x1816A9040
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
	|-RVA: 0x16A9160 Offset: 0x16A7760 VA: 0x1816A9160
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, ServerInfo>..ctor
	*/

	public override Enumerable.Iterator<TResult> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A3E00 Offset: 0x16A2400 VA: 0x1816A3E00
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
	|-RVA: 0x16A3CC0 Offset: 0x16A22C0 VA: 0x1816A3CC0
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
	|-RVA: 0x16A3D60 Offset: 0x16A2360 VA: 0x1816A3D60
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
	|-RVA: 0x16A3EA0 Offset: 0x16A24A0 VA: 0x1816A3EA0
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
	|-RVA: 0x16A3F40 Offset: 0x16A2540 VA: 0x1816A3F40
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, ServerInfo>.Clone
	*/

	public override void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C03E0 Offset: 0x19BE9E0 VA: 0x1819C03E0
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, FourBitNumber>.Dispose
	|
	|-RVA: 0x19BFED0 Offset: 0x19BE4D0 VA: 0x1819BFED0
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, SevenBitNumber>.Dispose
	|
	|-RVA: 0x19BFDB0 Offset: 0x19BE3B0 VA: 0x1819BFDB0
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, int>.Dispose
	|
	|-RVA: 0x19C0500 Offset: 0x19BEB00 VA: 0x1819C0500
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x19C0590 Offset: 0x19BEB90 VA: 0x1819C0590
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, PathFinder.Point>.Dispose
	|
	|-RVA: 0x19C0470 Offset: 0x19BEA70 VA: 0x1819C0470
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x19C0080 Offset: 0x19BE680 VA: 0x1819C0080
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Option>.Dispose
	|
	|-RVA: 0x19C0230 Offset: 0x19BE830 VA: 0x1819C0230
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, InventoryItem>.Dispose
	|
	|-RVA: 0x19C01A0 Offset: 0x19BE7A0 VA: 0x1819C01A0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x19BFE40 Offset: 0x19BE440 VA: 0x1819BFE40
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, InventoryRecipe>.Dispose
	|
	|-RVA: 0x19C0110 Offset: 0x19BE710 VA: 0x1819C0110
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, bool>.Dispose
	|
	|-RVA: 0x19BFD20 Offset: 0x19BE320 VA: 0x1819BFD20
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x19BFF60 Offset: 0x19BE560 VA: 0x1819BFF60
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, int>.Dispose
	|
	|-RVA: 0x19BFFF0 Offset: 0x19BE5F0 VA: 0x1819BFFF0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Int32Enum>.Dispose
	|
	|-RVA: 0x19C0350 Offset: 0x19BE950 VA: 0x1819C0350
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, long>.Dispose
	|
	|-RVA: 0x19C02C0 Offset: 0x19BE8C0 VA: 0x1819C02C0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, object>.Dispose
	|
	|-RVA: 0x1A18810 Offset: 0x1A16E10 VA: 0x181A18810
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, float>.Dispose
	|
	|-RVA: 0x1A19BC0 Offset: 0x1A181C0 VA: 0x181A19BC0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Resolution>.Dispose
	|
	|-RVA: 0x1A19860 Offset: 0x1A17E60 VA: 0x181A19860
	|-Enumerable.WhereSelectEnumerableIterator<WeightedStringList.Container, float>.Dispose
	|
	|-RVA: 0x1A17B20 Offset: 0x1A16120 VA: 0x181A17B20
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A18DB0 Offset: 0x1A173B0 VA: 0x181A18DB0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A19C50 Offset: 0x1A18250 VA: 0x181A19C50
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A16920 Offset: 0x1A14F20 VA: 0x181A16920
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Option>.Dispose
	|
	|-RVA: 0x1A18D20 Offset: 0x1A17320 VA: 0x181A18D20
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, InventoryItem>.Dispose
	|
	|-RVA: 0x1A17970 Offset: 0x1A15F70 VA: 0x181A17970
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A17E80 Offset: 0x1A16480 VA: 0x181A17E80
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A17FA0 Offset: 0x1A165A0 VA: 0x181A17FA0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, bool>.Dispose
	|
	|-RVA: 0x1A19B30 Offset: 0x1A18130 VA: 0x181A19B30
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A19350 Offset: 0x1A17950 VA: 0x181A19350
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, int>.Dispose
	|
	|-RVA: 0x1A17BB0 Offset: 0x1A161B0 VA: 0x181A17BB0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Int32Enum>.Dispose
	|
	|-RVA: 0x1A17F10 Offset: 0x1A16510 VA: 0x181A17F10
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, long>.Dispose
	|
	|-RVA: 0x1A18660 Offset: 0x1A16C60 VA: 0x181A18660
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, object>.Dispose
	|
	|-RVA: 0x1A169B0 Offset: 0x1A14FB0 VA: 0x181A169B0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, float>.Dispose
	|
	|-RVA: 0x1A184B0 Offset: 0x1A16AB0 VA: 0x181A184B0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Resolution>.Dispose
	|
	|-RVA: 0x1A174F0 Offset: 0x1A15AF0 VA: 0x181A174F0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, FourBitNumber>.Dispose
	|
	|-RVA: 0x1A18E40 Offset: 0x1A17440 VA: 0x181A18E40
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, SevenBitNumber>.Dispose
	|
	|-RVA: 0x1A19110 Offset: 0x1A17710 VA: 0x181A19110
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, int>.Dispose
	|
	|-RVA: 0x1A17730 Offset: 0x1A15D30 VA: 0x181A17730
	|-Enumerable.WhereSelectEnumerableIterator<ProjectileWeaponMod.Modifier, float>.Dispose
	|
	|-RVA: 0x1A16BF0 Offset: 0x1A151F0 VA: 0x181A16BF0
	|-Enumerable.WhereSelectEnumerableIterator<Option, Option>.Dispose
	|
	|-RVA: 0x1A18AE0 Offset: 0x1A170E0 VA: 0x181A18AE0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A188A0 Offset: 0x1A16EA0 VA: 0x181A188A0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, FourBitNumber>.Dispose
	|
	|-RVA: 0x1A17850 Offset: 0x1A15E50 VA: 0x181A17850
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, SevenBitNumber>.Dispose
	|
	|-RVA: 0x1A19230 Offset: 0x1A17830 VA: 0x181A19230
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A17610 Offset: 0x1A15C10 VA: 0x181A17610
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A18ED0 Offset: 0x1A174D0 VA: 0x181A18ED0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Option>.Dispose
	|
	|-RVA: 0x1A18B70 Offset: 0x1A17170 VA: 0x181A18B70
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, InventoryItem>.Dispose
	|
	|-RVA: 0x1A16A40 Offset: 0x1A15040 VA: 0x181A16A40
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A16C80 Offset: 0x1A15280 VA: 0x181A16C80
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A181E0 Offset: 0x1A167E0 VA: 0x181A181E0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, bool>.Dispose
	|
	|-RVA: 0x1A16FE0 Offset: 0x1A155E0 VA: 0x181A16FE0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A18930 Offset: 0x1A16F30 VA: 0x181A18930
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, int>.Dispose
	|
	|-RVA: 0x1A17CD0 Offset: 0x1A162D0 VA: 0x181A17CD0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Int32Enum>.Dispose
	|
	|-RVA: 0x1A17460 Offset: 0x1A15A60 VA: 0x181A17460
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, long>.Dispose
	|
	|-RVA: 0x1A18390 Offset: 0x1A16990 VA: 0x181A18390
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.Dispose
	|
	|-RVA: 0x1A16800 Offset: 0x1A14E00 VA: 0x181A16800
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, float>.Dispose
	|
	|-RVA: 0x1A166E0 Offset: 0x1A14CE0 VA: 0x181A166E0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Resolution>.Dispose
	|
	|-RVA: 0x1A17580 Offset: 0x1A15B80 VA: 0x181A17580
	|-Enumerable.WhereSelectEnumerableIterator<SkinnedMultiMesh.Part, long>.Dispose
	|
	|-RVA: 0x1A17100 Offset: 0x1A15700 VA: 0x181A17100
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A178E0 Offset: 0x1A15EE0 VA: 0x181A178E0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A16650 Offset: 0x1A14C50 VA: 0x181A16650
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A177C0 Offset: 0x1A15DC0 VA: 0x181A177C0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Option>.Dispose
	|
	|-RVA: 0x1A18150 Offset: 0x1A16750 VA: 0x181A18150
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, InventoryItem>.Dispose
	|
	|-RVA: 0x1A18780 Offset: 0x1A16D80 VA: 0x181A18780
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A193E0 Offset: 0x1A179E0 VA: 0x181A193E0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A17A90 Offset: 0x1A16090 VA: 0x181A17A90
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, bool>.Dispose
	|
	|-RVA: 0x1A17070 Offset: 0x1A15670 VA: 0x181A17070
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A164A0 Offset: 0x1A14AA0 VA: 0x181A164A0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, int>.Dispose
	|
	|-RVA: 0x1A18030 Offset: 0x1A16630 VA: 0x181A18030
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Int32Enum>.Dispose
	|
	|-RVA: 0x1A180C0 Offset: 0x1A166C0 VA: 0x181A180C0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, long>.Dispose
	|
	|-RVA: 0x1A16890 Offset: 0x1A14E90 VA: 0x181A16890
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, object>.Dispose
	|
	|-RVA: 0x1A19620 Offset: 0x1A17C20 VA: 0x181A19620
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, float>.Dispose
	|
	|-RVA: 0x1A19080 Offset: 0x1A17680 VA: 0x181A19080
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Resolution>.Dispose
	|
	|-RVA: 0x1A198F0 Offset: 0x1A17EF0 VA: 0x181A198F0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A16AD0 Offset: 0x1A150D0 VA: 0x181A16AD0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A191A0 Offset: 0x1A177A0 VA: 0x181A191A0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A19590 Offset: 0x1A17B90 VA: 0x181A19590
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Option>.Dispose
	|
	|-RVA: 0x1A196B0 Offset: 0x1A17CB0 VA: 0x181A196B0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, InventoryItem>.Dispose
	|
	|-RVA: 0x1A18A50 Offset: 0x1A17050 VA: 0x181A18A50
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A17190 Offset: 0x1A15790 VA: 0x181A17190
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A16770 Offset: 0x1A14D70 VA: 0x181A16770
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, bool>.Dispose
	|
	|-RVA: 0x1A18F60 Offset: 0x1A17560 VA: 0x181A18F60
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A189C0 Offset: 0x1A16FC0 VA: 0x181A189C0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, int>.Dispose
	|
	|-RVA: 0x1A19500 Offset: 0x1A17B00 VA: 0x181A19500
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Int32Enum>.Dispose
	|
	|-RVA: 0x1A186F0 Offset: 0x1A16CF0 VA: 0x181A186F0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, long>.Dispose
	|
	|-RVA: 0x1A16530 Offset: 0x1A14B30 VA: 0x181A16530
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, object>.Dispose
	|
	|-RVA: 0x1A176A0 Offset: 0x1A15CA0 VA: 0x181A176A0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, float>.Dispose
	|
	|-RVA: 0x1A17A00 Offset: 0x1A16000 VA: 0x181A17A00
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Resolution>.Dispose
	|
	|-RVA: 0x1A19740 Offset: 0x1A17D40 VA: 0x181A19740
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, ServerInfo>.Dispose
	|
	|-RVA: 0x1A185D0 Offset: 0x1A16BD0 VA: 0x181A185D0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, int>.Dispose
	|
	|-RVA: 0x1A165C0 Offset: 0x1A14BC0 VA: 0x181A165C0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.Dispose
	|
	|-RVA: 0x1A17220 Offset: 0x1A15820 VA: 0x181A17220
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A16D10 Offset: 0x1A15310 VA: 0x181A16D10
	|-Enumerable.WhereSelectEnumerableIterator<Friend, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A197D0 Offset: 0x1A17DD0 VA: 0x181A197D0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A18540 Offset: 0x1A16B40 VA: 0x181A18540
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Option>.Dispose
	|
	|-RVA: 0x1A19470 Offset: 0x1A17A70 VA: 0x181A19470
	|-Enumerable.WhereSelectEnumerableIterator<Friend, InventoryItem>.Dispose
	|
	|-RVA: 0x1A16EC0 Offset: 0x1A154C0 VA: 0x181A16EC0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A18420 Offset: 0x1A16A20 VA: 0x181A18420
	|-Enumerable.WhereSelectEnumerableIterator<Friend, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A16F50 Offset: 0x1A15550 VA: 0x181A16F50
	|-Enumerable.WhereSelectEnumerableIterator<Friend, bool>.Dispose
	|
	|-RVA: 0x1A19AA0 Offset: 0x1A180A0 VA: 0x181A19AA0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A18C00 Offset: 0x1A17200 VA: 0x181A18C00
	|-Enumerable.WhereSelectEnumerableIterator<Friend, int>.Dispose
	|
	|-RVA: 0x1A18300 Offset: 0x1A16900 VA: 0x181A18300
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Int32Enum>.Dispose
	|
	|-RVA: 0x1A16E30 Offset: 0x1A15430 VA: 0x181A16E30
	|-Enumerable.WhereSelectEnumerableIterator<Friend, long>.Dispose
	|
	|-RVA: 0x1A18270 Offset: 0x1A16870 VA: 0x181A18270
	|-Enumerable.WhereSelectEnumerableIterator<Friend, object>.Dispose
	|
	|-RVA: 0x1A17C40 Offset: 0x1A16240 VA: 0x181A17C40
	|-Enumerable.WhereSelectEnumerableIterator<Friend, float>.Dispose
	|
	|-RVA: 0x1A17DF0 Offset: 0x1A163F0 VA: 0x181A17DF0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Resolution>.Dispose
	|
	|-RVA: 0x1A19980 Offset: 0x1A17F80 VA: 0x181A19980
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A17340 Offset: 0x1A15940 VA: 0x181A17340
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, FourBitNumber>.Dispose
	|
	|-RVA: 0x1A192C0 Offset: 0x1A178C0 VA: 0x181A192C0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, SevenBitNumber>.Dispose
	|
	|-RVA: 0x1A16B60 Offset: 0x1A15160 VA: 0x181A16B60
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A16410 Offset: 0x1A14A10 VA: 0x181A16410
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A18FF0 Offset: 0x1A175F0 VA: 0x181A18FF0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Option>.Dispose
	|
	|-RVA: 0x1A172B0 Offset: 0x1A158B0 VA: 0x181A172B0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryItemId>.Dispose
	|
	|-RVA: 0x1A16DA0 Offset: 0x1A153A0 VA: 0x181A16DA0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryItem>.Dispose
	|
	|-RVA: 0x1A17D60 Offset: 0x1A16360 VA: 0x181A17D60
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A173D0 Offset: 0x1A159D0 VA: 0x181A173D0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A18C90 Offset: 0x1A17290 VA: 0x181A18C90
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, bool>.Dispose
	|
	|-RVA: 0x1A19A10 Offset: 0x1A18010 VA: 0x181A19A10
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A29C10 Offset: 0x1A28210 VA: 0x181A29C10
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, int>.Dispose
	|
	|-RVA: 0x1A27810 Offset: 0x1A25E10 VA: 0x181A27810
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Int32Enum>.Dispose
	|
	|-RVA: 0x1A27930 Offset: 0x1A25F30 VA: 0x181A27930
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, long>.Dispose
	|
	|-RVA: 0x1A26C40 Offset: 0x1A25240 VA: 0x181A26C40
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, object>.Dispose
	|
	|-RVA: 0x1A28E90 Offset: 0x1A27490 VA: 0x181A28E90
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, float>.Dispose
	|
	|-RVA: 0x1A27420 Offset: 0x1A25A20 VA: 0x181A27420
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, uint>.Dispose
	|
	|-RVA: 0x1A27C90 Offset: 0x1A26290 VA: 0x181A27C90
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Resolution>.Dispose
	|
	|-RVA: 0x1A27E40 Offset: 0x1A26440 VA: 0x181A27E40
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem.Amount, InventoryItemId>.Dispose
	|
	|-RVA: 0x1A2A090 Offset: 0x1A28690 VA: 0x181A2A090
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem.Amount, uint>.Dispose
	|
	|-RVA: 0x1A28BC0 Offset: 0x1A271C0 VA: 0x181A28BC0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe, PlayerItemRecipe>.Dispose
	|
	|-RVA: 0x1A29430 Offset: 0x1A27A30 VA: 0x181A29430
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe, object>.Dispose
	|
	|-RVA: 0x1A27030 Offset: 0x1A25630 VA: 0x181A27030
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A27780 Offset: 0x1A25D80 VA: 0x181A27780
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A29E50 Offset: 0x1A28450 VA: 0x181A29E50
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A29CA0 Offset: 0x1A282A0 VA: 0x181A29CA0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A29790 Offset: 0x1A27D90 VA: 0x181A29790
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Option>.Dispose
	|
	|-RVA: 0x1A29040 Offset: 0x1A27640 VA: 0x181A29040
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, InventoryItem>.Dispose
	|
	|-RVA: 0x1A29280 Offset: 0x1A27880 VA: 0x181A29280
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A27660 Offset: 0x1A25C60 VA: 0x181A27660
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A26DF0 Offset: 0x1A253F0 VA: 0x181A26DF0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, bool>.Dispose
	|
	|-RVA: 0x1A275D0 Offset: 0x1A25BD0 VA: 0x181A275D0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A293A0 Offset: 0x1A279A0 VA: 0x181A293A0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, int>.Dispose
	|
	|-RVA: 0x1A288F0 Offset: 0x1A26EF0 VA: 0x181A288F0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Int32Enum>.Dispose
	|
	|-RVA: 0x1A29D30 Offset: 0x1A28330 VA: 0x181A29D30
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, long>.Dispose
	|
	|-RVA: 0x1A287D0 Offset: 0x1A26DD0 VA: 0x181A287D0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, object>.Dispose
	|
	|-RVA: 0x1A29820 Offset: 0x1A27E20 VA: 0x181A29820
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, float>.Dispose
	|
	|-RVA: 0x1A27270 Offset: 0x1A25870 VA: 0x181A27270
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Resolution>.Dispose
	|
	|-RVA: 0x1A28D70 Offset: 0x1A27370 VA: 0x181A28D70
	|-Enumerable.WhereSelectEnumerableIterator<DictionaryEntry, KeyValuePair<object, object>>.Dispose
	|
	|-RVA: 0x1A27540 Offset: 0x1A25B40 VA: 0x181A27540
	|-Enumerable.WhereSelectEnumerableIterator<DictionaryEntry, object>.Dispose
	|
	|-RVA: 0x1A26A00 Offset: 0x1A25000 VA: 0x181A26A00
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A286B0 Offset: 0x1A26CB0 VA: 0x181A286B0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A26BB0 Offset: 0x1A251B0 VA: 0x181A26BB0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A27150 Offset: 0x1A25750 VA: 0x181A27150
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Option>.Dispose
	|
	|-RVA: 0x1A28AA0 Offset: 0x1A270A0 VA: 0x181A28AA0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, InventoryItem>.Dispose
	|
	|-RVA: 0x1A28230 Offset: 0x1A26830 VA: 0x181A28230
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A28B30 Offset: 0x1A27130 VA: 0x181A28B30
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A27ED0 Offset: 0x1A264D0 VA: 0x181A27ED0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, bool>.Dispose
	|
	|-RVA: 0x1A291F0 Offset: 0x1A277F0 VA: 0x181A291F0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A2A000 Offset: 0x1A28600 VA: 0x181A2A000
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, int>.Dispose
	|
	|-RVA: 0x1A27A50 Offset: 0x1A26050 VA: 0x181A27A50
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Int32Enum>.Dispose
	|
	|-RVA: 0x1A26B20 Offset: 0x1A25120 VA: 0x181A26B20
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, long>.Dispose
	|
	|-RVA: 0x1A271E0 Offset: 0x1A257E0 VA: 0x181A271E0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Dispose
	|
	|-RVA: 0x1A298B0 Offset: 0x1A27EB0 VA: 0x181A298B0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, float>.Dispose
	|
	|-RVA: 0x1A270C0 Offset: 0x1A256C0 VA: 0x181A270C0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Resolution>.Dispose
	|
	|-RVA: 0x1A27B70 Offset: 0x1A26170 VA: 0x181A27B70
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A29670 Offset: 0x1A27C70 VA: 0x181A29670
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A26F10 Offset: 0x1A25510 VA: 0x181A26F10
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A29A60 Offset: 0x1A28060 VA: 0x181A29A60
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Option>.Dispose
	|
	|-RVA: 0x1A29F70 Offset: 0x1A28570 VA: 0x181A29F70
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, InventoryItem>.Dispose
	|
	|-RVA: 0x1A28980 Offset: 0x1A26F80 VA: 0x181A28980
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A29AF0 Offset: 0x1A280F0 VA: 0x181A29AF0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A28FB0 Offset: 0x1A275B0 VA: 0x181A28FB0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, bool>.Dispose
	|
	|-RVA: 0x1A27AE0 Offset: 0x1A260E0 VA: 0x181A27AE0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A26E80 Offset: 0x1A25480 VA: 0x181A26E80
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, int>.Dispose
	|
	|-RVA: 0x1A28C50 Offset: 0x1A27250 VA: 0x181A28C50
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Int32Enum>.Dispose
	|
	|-RVA: 0x1A27390 Offset: 0x1A25990 VA: 0x181A27390
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, long>.Dispose
	|
	|-RVA: 0x1A29940 Offset: 0x1A27F40 VA: 0x181A29940
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, object>.Dispose
	|
	|-RVA: 0x1A27300 Offset: 0x1A25900 VA: 0x181A27300
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, float>.Dispose
	|
	|-RVA: 0x1A274B0 Offset: 0x1A25AB0 VA: 0x181A274B0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, uint>.Dispose
	|
	|-RVA: 0x1A28470 Offset: 0x1A26A70 VA: 0x181A28470
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Resolution>.Dispose
	|
	|-RVA: 0x1A29700 Offset: 0x1A27D00 VA: 0x181A29700
	|-Enumerable.WhereSelectEnumerableIterator<int, FourBitNumber>.Dispose
	|
	|-RVA: 0x1A29160 Offset: 0x1A27760 VA: 0x181A29160
	|-Enumerable.WhereSelectEnumerableIterator<int, SevenBitNumber>.Dispose
	|
	|-RVA: 0x1A28740 Offset: 0x1A26D40 VA: 0x181A28740
	|-Enumerable.WhereSelectEnumerableIterator<int, int>.Dispose
	|
	|-RVA: 0x1A28860 Offset: 0x1A26E60 VA: 0x181A28860
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A29EE0 Offset: 0x1A284E0 VA: 0x181A29EE0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A28350 Offset: 0x1A26950 VA: 0x181A28350
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A282C0 Offset: 0x1A268C0 VA: 0x181A282C0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Option>.Dispose
	|
	|-RVA: 0x1A28590 Offset: 0x1A26B90 VA: 0x181A28590
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, InventoryItem>.Dispose
	|
	|-RVA: 0x1A28620 Offset: 0x1A26C20 VA: 0x181A28620
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A27DB0 Offset: 0x1A263B0 VA: 0x181A27DB0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A27C00 Offset: 0x1A26200 VA: 0x181A27C00
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, bool>.Dispose
	|
	|-RVA: 0x1A290D0 Offset: 0x1A276D0 VA: 0x181A290D0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A29B80 Offset: 0x1A28180 VA: 0x181A29B80
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, int>.Dispose
	|
	|-RVA: 0x1A29310 Offset: 0x1A27910 VA: 0x181A29310
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Int32Enum>.Dispose
	|
	|-RVA: 0x1A299D0 Offset: 0x1A27FD0 VA: 0x181A299D0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, long>.Dispose
	|
	|-RVA: 0x1A28080 Offset: 0x1A26680 VA: 0x181A28080
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Dispose
	|
	|-RVA: 0x1A283E0 Offset: 0x1A269E0 VA: 0x181A283E0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, float>.Dispose
	|
	|-RVA: 0x1A26D60 Offset: 0x1A25360 VA: 0x181A26D60
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Resolution>.Dispose
	|
	|-RVA: 0x1A28500 Offset: 0x1A26B00 VA: 0x181A28500
	|-Enumerable.WhereSelectEnumerableIterator<object, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A28110 Offset: 0x1A26710 VA: 0x181A28110
	|-Enumerable.WhereSelectEnumerableIterator<object, FourBitNumber>.Dispose
	|
	|-RVA: 0x1A28CE0 Offset: 0x1A272E0 VA: 0x181A28CE0
	|-Enumerable.WhereSelectEnumerableIterator<object, SevenBitNumber>.Dispose
	|
	|-RVA: 0x1A276F0 Offset: 0x1A25CF0 VA: 0x181A276F0
	|-Enumerable.WhereSelectEnumerableIterator<object, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A26CD0 Offset: 0x1A252D0 VA: 0x181A26CD0
	|-Enumerable.WhereSelectEnumerableIterator<object, PlayerItemRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A26970 Offset: 0x1A24F70 VA: 0x181A26970
	|-Enumerable.WhereSelectEnumerableIterator<object, PlayerItemRecipe>.Dispose
	|
	|-RVA: 0x1A29DC0 Offset: 0x1A283C0 VA: 0x181A29DC0
	|-Enumerable.WhereSelectEnumerableIterator<object, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A26A90 Offset: 0x1A25090 VA: 0x181A26A90
	|-Enumerable.WhereSelectEnumerableIterator<object, Option>.Dispose
	|
	|-RVA: 0x1A281A0 Offset: 0x1A267A0 VA: 0x181A281A0
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryItemId>.Dispose
	|
	|-RVA: 0x1A26FA0 Offset: 0x1A255A0 VA: 0x181A26FA0
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryItem>.Dispose
	|
	|-RVA: 0x1A278A0 Offset: 0x1A25EA0 VA: 0x181A278A0
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A279C0 Offset: 0x1A25FC0 VA: 0x181A279C0
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A29550 Offset: 0x1A27B50 VA: 0x181A29550
	|-Enumerable.WhereSelectEnumerableIterator<object, bool>.Dispose
	|
	|-RVA: 0x1A28A10 Offset: 0x1A27010 VA: 0x181A28A10
	|-Enumerable.WhereSelectEnumerableIterator<object, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A27F60 Offset: 0x1A26560 VA: 0x181A27F60
	|-Enumerable.WhereSelectEnumerableIterator<object, int>.Dispose
	|
	|-RVA: 0x1A28E00 Offset: 0x1A27400 VA: 0x181A28E00
	|-Enumerable.WhereSelectEnumerableIterator<object, Int32Enum>.Dispose
	|
	|-RVA: 0x1A27FF0 Offset: 0x1A265F0 VA: 0x181A27FF0
	|-Enumerable.WhereSelectEnumerableIterator<object, long>.Dispose
	|
	|-RVA: 0x1A27D20 Offset: 0x1A26320 VA: 0x181A27D20
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Dispose
	|
	|-RVA: 0x1A294C0 Offset: 0x1A27AC0 VA: 0x181A294C0
	|-Enumerable.WhereSelectEnumerableIterator<object, float>.Dispose
	|
	|-RVA: 0x1A295E0 Offset: 0x1A27BE0 VA: 0x181A295E0
	|-Enumerable.WhereSelectEnumerableIterator<object, uint>.Dispose
	|
	|-RVA: 0x1A28F20 Offset: 0x1A27520 VA: 0x181A28F20
	|-Enumerable.WhereSelectEnumerableIterator<object, Resolution>.Dispose
	*/

	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C0D80 Offset: 0x19BF380 VA: 0x1819C0D80
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, FourBitNumber>.MoveNext
	|
	|-RVA: 0x19C1650 Offset: 0x19BFC50 VA: 0x1819C1650
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, SevenBitNumber>.MoveNext
	|
	|-RVA: 0x19C1A30 Offset: 0x19C0030 VA: 0x1819C1A30
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, int>.MoveNext
	|
	|-RVA: 0x19C1BB0 Offset: 0x19C01B0 VA: 0x1819C1BB0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x19C08A0 Offset: 0x19BEEA0 VA: 0x1819C08A0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x19C13E0 Offset: 0x19BF9E0 VA: 0x1819C13E0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x19C22F0 Offset: 0x19C08F0 VA: 0x1819C22F0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Option>.MoveNext
	|
	|-RVA: 0x19C0F00 Offset: 0x19BF500 VA: 0x1819C0F00
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, InventoryItem>.MoveNext
	|
	|-RVA: 0x19C0B00 Offset: 0x19BF100 VA: 0x1819C0B00
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x19C0620 Offset: 0x19BEC20 VA: 0x1819C0620
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x19C1E20 Offset: 0x19C0420 VA: 0x1819C1E20
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, bool>.MoveNext
	|
	|-RVA: 0x19C2080 Offset: 0x19C0680 VA: 0x1819C2080
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x19C17D0 Offset: 0x19BFDD0 VA: 0x1819C17D0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, int>.MoveNext
	|
	|-RVA: 0x19C2570 Offset: 0x19C0B70 VA: 0x1819C2570
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Int32Enum>.MoveNext
	|
	|-RVA: 0x19C1180 Offset: 0x19BF780 VA: 0x1819C1180
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, long>.MoveNext
	|
	|-RVA: 0x19C27D0 Offset: 0x19C0DD0 VA: 0x1819C27D0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, object>.MoveNext
	|
	|-RVA: 0x1A24C80 Offset: 0x1A23280 VA: 0x181A24C80
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, float>.MoveNext
	|
	|-RVA: 0x1A1C380 Offset: 0x1A1A980 VA: 0x181A1C380
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Resolution>.MoveNext
	|
	|-RVA: 0x1A1EEA0 Offset: 0x1A1D4A0 VA: 0x181A1EEA0
	|-Enumerable.WhereSelectEnumerableIterator<WeightedStringList.Container, float>.MoveNext
	|
	|-RVA: 0x1A25610 Offset: 0x1A23C10 VA: 0x181A25610
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A22590 Offset: 0x1A20B90 VA: 0x181A22590
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A1B680 Offset: 0x1A19C80 VA: 0x181A1B680
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A211D0 Offset: 0x1A1F7D0 VA: 0x181A211D0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Option>.MoveNext
	|
	|-RVA: 0x1A1E8D0 Offset: 0x1A1CED0 VA: 0x181A1E8D0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A231E0 Offset: 0x1A217E0 VA: 0x181A231E0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A245D0 Offset: 0x1A22BD0 VA: 0x181A245D0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A20FC0 Offset: 0x1A1F5C0 VA: 0x181A20FC0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, bool>.MoveNext
	|
	|-RVA: 0x1A23B80 Offset: 0x1A22180 VA: 0x181A23B80
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A1EC90 Offset: 0x1A1D290 VA: 0x181A1EC90
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, int>.MoveNext
	|
	|-RVA: 0x1A1F0B0 Offset: 0x1A1D6B0 VA: 0x181A1F0B0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A21B00 Offset: 0x1A20100 VA: 0x181A21B00
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, long>.MoveNext
	|
	|-RVA: 0x1A1C160 Offset: 0x1A1A760 VA: 0x181A1C160
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, object>.MoveNext
	|
	|-RVA: 0x1A24A70 Offset: 0x1A23070 VA: 0x181A24A70
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, float>.MoveNext
	|
	|-RVA: 0x1A1FD70 Offset: 0x1A1E370 VA: 0x181A1FD70
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Resolution>.MoveNext
	|
	|-RVA: 0x1A22D40 Offset: 0x1A21340 VA: 0x181A22D40
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, FourBitNumber>.MoveNext
	|
	|-RVA: 0x1A24450 Offset: 0x1A22A50 VA: 0x181A24450
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, SevenBitNumber>.MoveNext
	|
	|-RVA: 0x1A1F720 Offset: 0x1A1DD20 VA: 0x181A1F720
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, int>.MoveNext
	|
	|-RVA: 0x1A1AC00 Offset: 0x1A19200 VA: 0x181A1AC00
	|-Enumerable.WhereSelectEnumerableIterator<ProjectileWeaponMod.Modifier, float>.MoveNext
	|
	|-RVA: 0x1A227A0 Offset: 0x1A20DA0 VA: 0x181A227A0
	|-Enumerable.WhereSelectEnumerableIterator<Option, Option>.MoveNext
	|
	|-RVA: 0x1A1A230 Offset: 0x1A18830 VA: 0x181A1A230
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A1B100 Offset: 0x1A19700 VA: 0x181A1B100
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, FourBitNumber>.MoveNext
	|
	|-RVA: 0x1A263E0 Offset: 0x1A249E0 VA: 0x181A263E0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, SevenBitNumber>.MoveNext
	|
	|-RVA: 0x1A25EE0 Offset: 0x1A244E0 VA: 0x181A25EE0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A266A0 Offset: 0x1A24CA0 VA: 0x181A266A0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A20710 Offset: 0x1A1ED10 VA: 0x181A20710
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Option>.MoveNext
	|
	|-RVA: 0x1A1DDD0 Offset: 0x1A1C3D0 VA: 0x181A1DDD0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A1F440 Offset: 0x1A1DA40 VA: 0x181A1F440
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A1AE20 Offset: 0x1A19420 VA: 0x181A1AE20
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A1B3C0 Offset: 0x1A199C0 VA: 0x181A1B3C0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, bool>.MoveNext
	|
	|-RVA: 0x1A1C910 Offset: 0x1A1AF10 VA: 0x181A1C910
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A1D5F0 Offset: 0x1A1BBF0 VA: 0x181A1D5F0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, int>.MoveNext
	|
	|-RVA: 0x1A259C0 Offset: 0x1A23FC0 VA: 0x181A259C0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A23F50 Offset: 0x1A22550 VA: 0x181A23F50
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, long>.MoveNext
	|
	|-RVA: 0x1A20B70 Offset: 0x1A1F170 VA: 0x181A20B70
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.MoveNext
	|
	|-RVA: 0x1A202D0 Offset: 0x1A1E8D0 VA: 0x181A202D0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, float>.MoveNext
	|
	|-RVA: 0x1A23420 Offset: 0x1A21A20 VA: 0x181A23420
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Resolution>.MoveNext
	|
	|-RVA: 0x1A21590 Offset: 0x1A1FB90 VA: 0x181A21590
	|-Enumerable.WhereSelectEnumerableIterator<SkinnedMultiMesh.Part, long>.MoveNext
	|
	|-RVA: 0x1A22A00 Offset: 0x1A21000 VA: 0x181A22A00
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A21EB0 Offset: 0x1A204B0 VA: 0x181A21EB0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A21400 Offset: 0x1A1FA00 VA: 0x181A21400
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A1FF90 Offset: 0x1A1E590 VA: 0x181A1FF90
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Option>.MoveNext
	|
	|-RVA: 0x1A1F8A0 Offset: 0x1A1DEA0 VA: 0x181A1F8A0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A21D10 Offset: 0x1A20310 VA: 0x181A21D10
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A1CD60 Offset: 0x1A1B360 VA: 0x181A1CD60
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A25490 Offset: 0x1A23A90 VA: 0x181A25490
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, bool>.MoveNext
	|
	|-RVA: 0x1A1C770 Offset: 0x1A1AD70 VA: 0x181A1C770
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A23A00 Offset: 0x1A22000 VA: 0x181A23A00
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, int>.MoveNext
	|
	|-RVA: 0x1A1C5F0 Offset: 0x1A1ABF0 VA: 0x181A1C5F0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A22410 Offset: 0x1A20A10 VA: 0x181A22410
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, long>.MoveNext
	|
	|-RVA: 0x1A1FBE0 Offset: 0x1A1E1E0 VA: 0x181A1FBE0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, object>.MoveNext
	|
	|-RVA: 0x1A1A0A0 Offset: 0x1A186A0 VA: 0x181A1A0A0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, float>.MoveNext
	|
	|-RVA: 0x1A217D0 Offset: 0x1A1FDD0 VA: 0x181A217D0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Resolution>.MoveNext
	|
	|-RVA: 0x1A1BC90 Offset: 0x1A1A290 VA: 0x181A1BC90
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A1F2C0 Offset: 0x1A1D8C0 VA: 0x181A1F2C0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A1CF00 Offset: 0x1A1B500 VA: 0x181A1CF00
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A23DB0 Offset: 0x1A223B0 VA: 0x181A23DB0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Option>.MoveNext
	|
	|-RVA: 0x1A1BE20 Offset: 0x1A1A420 VA: 0x181A1BE20
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A24F00 Offset: 0x1A23500 VA: 0x181A24F00
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A1BFC0 Offset: 0x1A1A5C0 VA: 0x181A1BFC0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A1E750 Offset: 0x1A1CD50 VA: 0x181A1E750
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, bool>.MoveNext
	|
	|-RVA: 0x1A1E0B0 Offset: 0x1A1C6B0 VA: 0x181A1E0B0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A1D090 Offset: 0x1A1B690 VA: 0x181A1D090
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, int>.MoveNext
	|
	|-RVA: 0x1A19F20 Offset: 0x1A18520 VA: 0x181A19F20
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A209F0 Offset: 0x1A1EFF0 VA: 0x181A209F0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, long>.MoveNext
	|
	|-RVA: 0x1A250A0 Offset: 0x1A236A0 VA: 0x181A250A0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, object>.MoveNext
	|
	|-RVA: 0x1A20590 Offset: 0x1A1EB90 VA: 0x181A20590
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, float>.MoveNext
	|
	|-RVA: 0x1A22EC0 Offset: 0x1A214C0 VA: 0x181A22EC0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Resolution>.MoveNext
	|
	|-RVA: 0x1A1A8D0 Offset: 0x1A18ED0 VA: 0x181A1A8D0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, ServerInfo>.MoveNext
	|
	|-RVA: 0x1A1E240 Offset: 0x1A1C840 VA: 0x181A1E240
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, int>.MoveNext
	|
	|-RVA: 0x1A1D8B0 Offset: 0x1A1BEB0 VA: 0x181A1D8B0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.MoveNext
	|
	|-RVA: 0x1A20130 Offset: 0x1A1E730 VA: 0x181A20130
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A25840 Offset: 0x1A23E40 VA: 0x181A25840
	|-Enumerable.WhereSelectEnumerableIterator<Friend, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A1A500 Offset: 0x1A18B00 VA: 0x181A1A500
	|-Enumerable.WhereSelectEnumerableIterator<Friend, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A22BA0 Offset: 0x1A211A0 VA: 0x181A22BA0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Option>.MoveNext
	|
	|-RVA: 0x1A1FA40 Offset: 0x1A1E040 VA: 0x181A1FA40
	|-Enumerable.WhereSelectEnumerableIterator<Friend, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A1B8A0 Offset: 0x1A19EA0 VA: 0x181A1B8A0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A1D450 Offset: 0x1A1BA50 VA: 0x181A1D450
	|-Enumerable.WhereSelectEnumerableIterator<Friend, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A23880 Offset: 0x1A21E80 VA: 0x181A23880
	|-Enumerable.WhereSelectEnumerableIterator<Friend, bool>.MoveNext
	|
	|-RVA: 0x1A21960 Offset: 0x1A1FF60 VA: 0x181A21960
	|-Enumerable.WhereSelectEnumerableIterator<Friend, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A22030 Offset: 0x1A20630 VA: 0x181A22030
	|-Enumerable.WhereSelectEnumerableIterator<Friend, int>.MoveNext
	|
	|-RVA: 0x1A20E40 Offset: 0x1A1F440 VA: 0x181A20E40
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A1CBE0 Offset: 0x1A1B1E0 VA: 0x181A1CBE0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, long>.MoveNext
	|
	|-RVA: 0x1A1EB00 Offset: 0x1A1D100 VA: 0x181A1EB00
	|-Enumerable.WhereSelectEnumerableIterator<Friend, object>.MoveNext
	|
	|-RVA: 0x1A236F0 Offset: 0x1A21CF0 VA: 0x181A236F0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, float>.MoveNext
	|
	|-RVA: 0x1A23050 Offset: 0x1A21650 VA: 0x181A23050
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Resolution>.MoveNext
	|
	|-RVA: 0x1A1DB80 Offset: 0x1A1C180 VA: 0x181A1DB80
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A1A690 Offset: 0x1A18C90 VA: 0x181A1A690
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, FourBitNumber>.MoveNext
	|
	|-RVA: 0x1A1D210 Offset: 0x1A1B810 VA: 0x181A1D210
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, SevenBitNumber>.MoveNext
	|
	|-RVA: 0x1A24210 Offset: 0x1A22810 VA: 0x181A24210
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A1BA40 Offset: 0x1A1A040 VA: 0x181A1BA40
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A25C80 Offset: 0x1A24280 VA: 0x181A25C80
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Option>.MoveNext
	|
	|-RVA: 0x1A19CE0 Offset: 0x1A182E0 VA: 0x181A19CE0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryItemId>.MoveNext
	|
	|-RVA: 0x1A221B0 Offset: 0x1A207B0 VA: 0x181A221B0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A25230 Offset: 0x1A23830 VA: 0x181A25230
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A24810 Offset: 0x1A22E10 VA: 0x181A24810
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A261A0 Offset: 0x1A247A0 VA: 0x181A261A0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, bool>.MoveNext
	|
	|-RVA: 0x1A1E500 Offset: 0x1A1CB00 VA: 0x181A1E500
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A2C640 Offset: 0x1A2AC40 VA: 0x181A2C640
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, int>.MoveNext
	|
	|-RVA: 0x1A32290 Offset: 0x1A30890 VA: 0x181A32290
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A2B8A0 Offset: 0x1A29EA0 VA: 0x181A2B8A0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, long>.MoveNext
	|
	|-RVA: 0x1A2B650 Offset: 0x1A29C50 VA: 0x181A2B650
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, object>.MoveNext
	|
	|-RVA: 0x1A326F0 Offset: 0x1A30CF0 VA: 0x181A326F0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, float>.MoveNext
	|
	|-RVA: 0x1A2AC90 Offset: 0x1A29290 VA: 0x181A2AC90
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, uint>.MoveNext
	|
	|-RVA: 0x1A34C80 Offset: 0x1A33280 VA: 0x181A34C80
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Resolution>.MoveNext
	|
	|-RVA: 0x1A2E320 Offset: 0x1A2C920 VA: 0x181A2E320
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem.Amount, InventoryItemId>.MoveNext
	|
	|-RVA: 0x1A33610 Offset: 0x1A31C10 VA: 0x181A33610
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem.Amount, uint>.MoveNext
	|
	|-RVA: 0x1A30AB0 Offset: 0x1A2F0B0 VA: 0x181A30AB0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe, PlayerItemRecipe>.MoveNext
	|
	|-RVA: 0x1A2A740 Offset: 0x1A28D40 VA: 0x181A2A740
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe, object>.MoveNext
	|
	|-RVA: 0x1A35120 Offset: 0x1A33720 VA: 0x181A35120
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A2DF50 Offset: 0x1A2C550 VA: 0x181A2DF50
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A35890 Offset: 0x1A33E90 VA: 0x181A35890
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A35AC0 Offset: 0x1A340C0 VA: 0x181A35AC0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A30650 Offset: 0x1A2EC50 VA: 0x181A30650
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Option>.MoveNext
	|
	|-RVA: 0x1A33870 Offset: 0x1A31E70 VA: 0x181A33870
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A34ED0 Offset: 0x1A334D0 VA: 0x181A34ED0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A35F40 Offset: 0x1A34540 VA: 0x181A35F40
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A31A80 Offset: 0x1A30080 VA: 0x181A31A80
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, bool>.MoveNext
	|
	|-RVA: 0x1A32E90 Offset: 0x1A31490 VA: 0x181A32E90
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A330D0 Offset: 0x1A316D0 VA: 0x181A330D0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, int>.MoveNext
	|
	|-RVA: 0x1A34480 Offset: 0x1A32A80 VA: 0x181A34480
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A31CB0 Offset: 0x1A302B0 VA: 0x181A31CB0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, long>.MoveNext
	|
	|-RVA: 0x1A33AC0 Offset: 0x1A320C0 VA: 0x181A33AC0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, object>.MoveNext
	|
	|-RVA: 0x1A34010 Offset: 0x1A32610 VA: 0x181A34010
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, float>.MoveNext
	|
	|-RVA: 0x1A2FDA0 Offset: 0x1A2E3A0 VA: 0x181A2FDA0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Resolution>.MoveNext
	|
	|-RVA: 0x1A2CAB0 Offset: 0x1A2B0B0 VA: 0x181A2CAB0
	|-Enumerable.WhereSelectEnumerableIterator<DictionaryEntry, KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0x1A35360 Offset: 0x1A33960 VA: 0x181A35360
	|-Enumerable.WhereSelectEnumerableIterator<DictionaryEntry, object>.MoveNext
	|
	|-RVA: 0x1A34A50 Offset: 0x1A33050 VA: 0x181A34A50
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A2DA10 Offset: 0x1A2C010 VA: 0x181A2DA10
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A2E700 Offset: 0x1A2CD00 VA: 0x181A2E700
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A2C880 Offset: 0x1A2AE80 VA: 0x181A2C880
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Option>.MoveNext
	|
	|-RVA: 0x1A31EE0 Offset: 0x1A304E0 VA: 0x181A31EE0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A2A2C0 Offset: 0x1A288C0 VA: 0x181A2A2C0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A35D00 Offset: 0x1A34300 VA: 0x181A35D00
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A2EF80 Offset: 0x1A2D580 VA: 0x181A2EF80
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, bool>.MoveNext
	|
	|-RVA: 0x1A30420 Offset: 0x1A2EA20 VA: 0x181A30420
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A2BE70 Offset: 0x1A2A470 VA: 0x181A2BE70
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, int>.MoveNext
	|
	|-RVA: 0x1A31180 Offset: 0x1A2F780 VA: 0x181A31180
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A2BAE0 Offset: 0x1A2A0E0 VA: 0x181A2BAE0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, long>.MoveNext
	|
	|-RVA: 0x1A31390 Offset: 0x1A2F990 VA: 0x181A31390
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.MoveNext
	|
	|-RVA: 0x1A32940 Offset: 0x1A30F40 VA: 0x181A32940
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, float>.MoveNext
	|
	|-RVA: 0x1A2B430 Offset: 0x1A29A30 VA: 0x181A2B430
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Resolution>.MoveNext
	|
	|-RVA: 0x1A2FFE0 Offset: 0x1A2E5E0 VA: 0x181A2FFE0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A2C430 Offset: 0x1A2AA30 VA: 0x181A2C430
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A346B0 Offset: 0x1A32CB0 VA: 0x181A346B0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A2F4B0 Offset: 0x1A2DAB0 VA: 0x181A2F4B0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Option>.MoveNext
	|
	|-RVA: 0x1A2C080 Offset: 0x1A2A680 VA: 0x181A2C080
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A2A500 Offset: 0x1A28B00 VA: 0x181A2A500
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A2B070 Offset: 0x1A29670 VA: 0x181A2B070
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A308A0 Offset: 0x1A2EEA0 VA: 0x181A308A0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, bool>.MoveNext
	|
	|-RVA: 0x1A2D650 Offset: 0x1A2BC50 VA: 0x181A2D650
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A2CE80 Offset: 0x1A2B480 VA: 0x181A2CE80
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, int>.MoveNext
	|
	|-RVA: 0x1A30210 Offset: 0x1A2E810 VA: 0x181A30210
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A2D2A0 Offset: 0x1A2B8A0 VA: 0x181A2D2A0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, long>.MoveNext
	|
	|-RVA: 0x1A34260 Offset: 0x1A32860 VA: 0x181A34260
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, object>.MoveNext
	|
	|-RVA: 0x1A2F880 Offset: 0x1A2DE80 VA: 0x181A2F880
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, float>.MoveNext
	|
	|-RVA: 0x1A2D090 Offset: 0x1A2B690 VA: 0x181A2D090
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, uint>.MoveNext
	|
	|-RVA: 0x1A324D0 Offset: 0x1A30AD0 VA: 0x181A324D0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Resolution>.MoveNext
	|
	|-RVA: 0x1A2AB10 Offset: 0x1A29110 VA: 0x181A2AB10
	|-Enumerable.WhereSelectEnumerableIterator<int, FourBitNumber>.MoveNext
	|
	|-RVA: 0x1A33300 Offset: 0x1A31900 VA: 0x181A33300
	|-Enumerable.WhereSelectEnumerableIterator<int, SevenBitNumber>.MoveNext
	|
	|-RVA: 0x1A31000 Offset: 0x1A2F600 VA: 0x181A31000
	|-Enumerable.WhereSelectEnumerableIterator<int, int>.MoveNext
	|
	|-RVA: 0x1A2F310 Offset: 0x1A2D910 VA: 0x181A2F310
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A2C2B0 Offset: 0x1A2A8B0 VA: 0x181A2C2B0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A33480 Offset: 0x1A31A80 VA: 0x181A33480
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A2EC40 Offset: 0x1A2D240 VA: 0x181A2EC40
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Option>.MoveNext
	|
	|-RVA: 0x1A32CF0 Offset: 0x1A312F0 VA: 0x181A32CF0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A2CCE0 Offset: 0x1A2B2E0 VA: 0x181A2CCE0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A2EAA0 Offset: 0x1A2D0A0 VA: 0x181A2EAA0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A33D00 Offset: 0x1A32300 VA: 0x181A33D00
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, bool>.MoveNext
	|
	|-RVA: 0x1A318E0 Offset: 0x1A2FEE0 VA: 0x181A318E0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A2F190 Offset: 0x1A2D790 VA: 0x181A2F190
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, int>.MoveNext
	|
	|-RVA: 0x1A2BCF0 Offset: 0x1A2A2F0 VA: 0x181A2BCF0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A2B2B0 Offset: 0x1A298B0 VA: 0x181A2B2B0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, long>.MoveNext
	|
	|-RVA: 0x1A2D880 Offset: 0x1A2BE80 VA: 0x181A2D880
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.MoveNext
	|
	|-RVA: 0x1A35710 Offset: 0x1A33D10 VA: 0x181A35710
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, float>.MoveNext
	|
	|-RVA: 0x1A315B0 Offset: 0x1A2FBB0 VA: 0x181A315B0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Resolution>.MoveNext
	|
	|-RVA: 0x1A2A120 Offset: 0x1A28720 VA: 0x181A2A120
	|-Enumerable.WhereSelectEnumerableIterator<object, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A2E580 Offset: 0x1A2CB80 VA: 0x181A2E580
	|-Enumerable.WhereSelectEnumerableIterator<object, FourBitNumber>.MoveNext
	|
	|-RVA: 0x1A30CF0 Offset: 0x1A2F2F0 VA: 0x181A30CF0
	|-Enumerable.WhereSelectEnumerableIterator<object, SevenBitNumber>.MoveNext
	|
	|-RVA: 0x1A2DC20 Offset: 0x1A2C220 VA: 0x181A2DC20
	|-Enumerable.WhereSelectEnumerableIterator<object, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A2FC10 Offset: 0x1A2E210 VA: 0x181A2FC10
	|-Enumerable.WhereSelectEnumerableIterator<object, PlayerItemRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A2DDB0 Offset: 0x1A2C3B0 VA: 0x181A2DDB0
	|-Enumerable.WhereSelectEnumerableIterator<object, PlayerItemRecipe>.MoveNext
	|
	|-RVA: 0x1A2AED0 Offset: 0x1A294D0 VA: 0x181A2AED0
	|-Enumerable.WhereSelectEnumerableIterator<object, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A31740 Offset: 0x1A2FD40 VA: 0x181A31740
	|-Enumerable.WhereSelectEnumerableIterator<object, Option>.MoveNext
	|
	|-RVA: 0x1A33E80 Offset: 0x1A32480 VA: 0x181A33E80
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryItemId>.MoveNext
	|
	|-RVA: 0x1A2F6E0 Offset: 0x1A2DCE0 VA: 0x181A2F6E0
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A32B50 Offset: 0x1A31150 VA: 0x181A32B50
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A2E180 Offset: 0x1A2C780 VA: 0x181A2E180
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A2E920 Offset: 0x1A2CF20 VA: 0x181A2E920
	|-Enumerable.WhereSelectEnumerableIterator<object, bool>.MoveNext
	|
	|-RVA: 0x1A2EDE0 Offset: 0x1A2D3E0 VA: 0x181A2EDE0
	|-Enumerable.WhereSelectEnumerableIterator<object, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A32110 Offset: 0x1A30710 VA: 0x181A32110
	|-Enumerable.WhereSelectEnumerableIterator<object, int>.MoveNext
	|
	|-RVA: 0x1A348D0 Offset: 0x1A32ED0 VA: 0x181A348D0
	|-Enumerable.WhereSelectEnumerableIterator<object, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A30E70 Offset: 0x1A2F470 VA: 0x181A30E70
	|-Enumerable.WhereSelectEnumerableIterator<object, long>.MoveNext
	|
	|-RVA: 0x1A2A980 Offset: 0x1A28F80 VA: 0x181A2A980
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.MoveNext
	|
	|-RVA: 0x1A35580 Offset: 0x1A33B80 VA: 0x181A35580
	|-Enumerable.WhereSelectEnumerableIterator<object, float>.MoveNext
	|
	|-RVA: 0x1A2FA90 Offset: 0x1A2E090 VA: 0x181A2FA90
	|-Enumerable.WhereSelectEnumerableIterator<object, uint>.MoveNext
	|
	|-RVA: 0x1A2D4B0 Offset: 0x1A2BAB0 VA: 0x181A2D4B0
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
	|-RVA: 0x19C2A40 Offset: 0x19C1040 VA: 0x1819C2A40
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
	|-RVA: 0x16A8F20 Offset: 0x16A7520 VA: 0x1816A8F20
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
	|-RVA: 0x16A8FB0 Offset: 0x16A75B0 VA: 0x1816A8FB0
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
	|-RVA: 0x16A90D0 Offset: 0x16A76D0 VA: 0x1816A90D0
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
	|-RVA: 0x16A9040 Offset: 0x16A7640 VA: 0x1816A9040
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
	|-RVA: 0x16A9160 Offset: 0x16A7760 VA: 0x1816A9160
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, ServerInfo>..ctor
	*/

	public override Enumerable.Iterator<TResult> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A3E00 Offset: 0x16A2400 VA: 0x1816A3E00
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
	|-RVA: 0x16A3CC0 Offset: 0x16A22C0 VA: 0x1816A3CC0
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
	|-RVA: 0x16A3D60 Offset: 0x16A2360 VA: 0x1816A3D60
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
	|-RVA: 0x16A3EA0 Offset: 0x16A24A0 VA: 0x1816A3EA0
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
	|-RVA: 0x16A3F40 Offset: 0x16A2540 VA: 0x1816A3F40
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, ServerInfo>.Clone
	*/

	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A4420 Offset: 0x16A2A20 VA: 0x1816A4420
	|-Enumerable.WhereSelectArrayIterator<BurstCloth.Chain, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<BurstCloth.Chain, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe.Ingredient, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe.Ingredient, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Achievement, bool>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, bool>.MoveNext
	|
	|-RVA: 0x16A4DB0 Offset: 0x16A33B0 VA: 0x1816A4DB0
	|-Enumerable.WhereSelectArrayIterator<BurstCloth.Chain, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe.Ingredient, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Achievement, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Achievement, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, Int32Enum>.MoveNext
	|
	|-RVA: 0x16A4500 Offset: 0x16A2B00 VA: 0x1816A4500
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x16A7F90 Offset: 0x16A6590 VA: 0x1816A7F90
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, long>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem.Amount, InventoryItemId>.MoveNext
	|
	|-RVA: 0x16A8D50 Offset: 0x16A7350 VA: 0x1816A8D50
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, Resolution>.MoveNext
	|
	|-RVA: 0x16A71A0 Offset: 0x16A57A0 VA: 0x1816A71A0
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, Option>.MoveNext
	|
	|-RVA: 0x16A5C60 Offset: 0x16A4260 VA: 0x1816A5C60
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, InventoryItem>.MoveNext
	|
	|-RVA: 0x16A7410 Offset: 0x16A5A10 VA: 0x1816A7410
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x16A5A00 Offset: 0x16A4000 VA: 0x1816A5A00
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x16A7C70 Offset: 0x16A6270 VA: 0x1816A7C70
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, bool>.MoveNext
	|
	|-RVA: 0x16A4650 Offset: 0x16A2C50 VA: 0x1816A4650
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem.Amount, uint>.MoveNext
	|
	|-RVA: 0x16A6B60 Offset: 0x16A5160 VA: 0x1816A6B60
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, object>.MoveNext
	|
	|-RVA: 0x16A8AE0 Offset: 0x16A70E0 VA: 0x1816A8AE0
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, float>.MoveNext
	|
	|-RVA: 0x16A50B0 Offset: 0x16A36B0 VA: 0x1816A50B0
	|-Enumerable.WhereSelectArrayIterator<WeightedStringList.Container, float>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, float>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, float>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, float>.MoveNext
	|
	|-RVA: 0x16A77C0 Offset: 0x16A5DC0 VA: 0x1816A77C0
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, KeyValuePair<object, int>>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<DictionaryEntry, KeyValuePair<object, object>>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, KeyValuePair<object, int>>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x16A3FE0 Offset: 0x16A25E0 VA: 0x1816A3FE0
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, long>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, long>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, long>.MoveNext
	|
	|-RVA: 0x16A83E0 Offset: 0x16A69E0 VA: 0x1816A83E0
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, Resolution>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Resolution>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, Resolution>.MoveNext
	|
	|-RVA: 0x16A89C0 Offset: 0x16A6FC0 VA: 0x1816A89C0
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, Option>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Option>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, Option>.MoveNext
	|
	|-RVA: 0x16A6850 Offset: 0x16A4E50 VA: 0x1816A6850
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, InventoryItem>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, InventoryItem>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, InventoryItem>.MoveNext
	|
	|-RVA: 0x16A88A0 Offset: 0x16A6EA0 VA: 0x1816A88A0
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, InventoryRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, InventoryRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x16A6F80 Offset: 0x16A5580 VA: 0x1816A6F80
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, InventoryRecipe>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, InventoryRecipe>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x16A82E0 Offset: 0x16A68E0 VA: 0x1816A82E0
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, bool>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, bool>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, bool>.MoveNext
	|
	|-RVA: 0x16A6300 Offset: 0x16A4900 VA: 0x1816A6300
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, uint>.MoveNext
	|
	|-RVA: 0x16A6E70 Offset: 0x16A5470 VA: 0x1816A6E70
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, object>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<DictionaryEntry, object>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, object>.MoveNext
	|
	|-RVA: 0x16A80D0 Offset: 0x16A66D0 VA: 0x1816A80D0
	|-Enumerable.WhereSelectArrayIterator<ProjectileWeaponMod.Modifier, float>.MoveNext
	|
	|-RVA: 0x16A8C10 Offset: 0x16A7210 VA: 0x1816A8C10
	|-Enumerable.WhereSelectArrayIterator<Option, Option>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, Option>.MoveNext
	|
	|-RVA: 0x16A5390 Offset: 0x16A3990 VA: 0x1816A5390
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x16A4890 Offset: 0x16A2E90 VA: 0x1816A4890
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, bool>.MoveNext
	|
	|-RVA: 0x16A6400 Offset: 0x16A4A00 VA: 0x1816A6400
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, long>.MoveNext
	|
	|-RVA: 0x16A6620 Offset: 0x16A4C20 VA: 0x1816A6620
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, Resolution>.MoveNext
	|
	|-RVA: 0x16A7580 Offset: 0x16A5B80 VA: 0x1816A7580
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, Option>.MoveNext
	|
	|-RVA: 0x16A60C0 Offset: 0x16A46C0 VA: 0x1816A60C0
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, InventoryItem>.MoveNext
	|
	|-RVA: 0x16A40E0 Offset: 0x16A26E0 VA: 0x1816A40E0
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x16A56D0 Offset: 0x16A3CD0 VA: 0x1816A56D0
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x16A4BA0 Offset: 0x16A31A0 VA: 0x1816A4BA0
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, int>.MoveNext
	|
	|-RVA: 0x16A4E90 Offset: 0x16A3490 VA: 0x1816A4E90
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>.MoveNext
	|
	|-RVA: 0x16A51B0 Offset: 0x16A37B0 VA: 0x1816A51B0
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, float>.MoveNext
	|
	|-RVA: 0x16A5EB0 Offset: 0x16A44B0 VA: 0x1816A5EB0
	|-Enumerable.WhereSelectArrayIterator<SkinnedMultiMesh.Part, long>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, InventoryItemId>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, long>.MoveNext
	|
	|-RVA: 0x16A5910 Offset: 0x16A3F10 VA: 0x1816A5910
	|-Enumerable.WhereSelectArrayIterator<Achievement, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Achievement, KeyValuePair<object, int>>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x16A6D90 Offset: 0x16A5390 VA: 0x1816A6D90
	|-Enumerable.WhereSelectArrayIterator<Achievement, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Achievement, long>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, long>.MoveNext
	|
	|-RVA: 0x16A7EA0 Offset: 0x16A64A0 VA: 0x1816A7EA0
	|-Enumerable.WhereSelectArrayIterator<Achievement, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Achievement, Resolution>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, Resolution>.MoveNext
	|
	|-RVA: 0x16A78D0 Offset: 0x16A5ED0 VA: 0x1816A78D0
	|-Enumerable.WhereSelectArrayIterator<Achievement, Option>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, Option>.MoveNext
	|
	|-RVA: 0x16A6970 Offset: 0x16A4F70 VA: 0x1816A6970
	|-Enumerable.WhereSelectArrayIterator<Achievement, InventoryItem>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, InventoryItem>.MoveNext
	|
	|-RVA: 0x16A7310 Offset: 0x16A5910 VA: 0x1816A7310
	|-Enumerable.WhereSelectArrayIterator<Achievement, InventoryRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x16A4AA0 Offset: 0x16A30A0 VA: 0x1816A4AA0
	|-Enumerable.WhereSelectArrayIterator<Achievement, InventoryRecipe>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x16A7DB0 Offset: 0x16A63B0 VA: 0x1816A7DB0
	|-Enumerable.WhereSelectArrayIterator<Achievement, object>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, object>.MoveNext
	|
	|-RVA: 0x16A6CB0 Offset: 0x16A52B0 VA: 0x1816A6CB0
	|-Enumerable.WhereSelectArrayIterator<Achievement, float>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, float>.MoveNext
	|
	|-RVA: 0x16A5FD0 Offset: 0x16A45D0 VA: 0x1816A5FD0
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x16A7B90 Offset: 0x16A6190 VA: 0x1816A7B90
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, long>.MoveNext
	|
	|-RVA: 0x16A6A70 Offset: 0x16A5070 VA: 0x1816A6A70
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, Resolution>.MoveNext
	|
	|-RVA: 0x16A70A0 Offset: 0x16A56A0 VA: 0x1816A70A0
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, Option>.MoveNext
	|
	|-RVA: 0x16A4320 Offset: 0x16A2920 VA: 0x1816A4320
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, InventoryItem>.MoveNext
	|
	|-RVA: 0x16A81E0 Offset: 0x16A67E0 VA: 0x1816A81E0
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x16A4790 Offset: 0x16A2D90 VA: 0x1816A4790
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x16A5DD0 Offset: 0x16A43D0 VA: 0x1816A5DD0
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, bool>.MoveNext
	|
	|-RVA: 0x16A7AB0 Offset: 0x16A60B0 VA: 0x1816A7AB0
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, Int32Enum>.MoveNext
	|
	|-RVA: 0x16A5B70 Offset: 0x16A4170 VA: 0x1816A5B70
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, object>.MoveNext
	|
	|-RVA: 0x16A79D0 Offset: 0x16A5FD0 VA: 0x1816A79D0
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, float>.MoveNext
	|
	|-RVA: 0x16A8620 Offset: 0x16A6C20 VA: 0x1816A8620
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, ServerInfo>.MoveNext
	|
	|-RVA: 0x16A84F0 Offset: 0x16A6AF0 VA: 0x1816A84F0
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x16A55C0 Offset: 0x16A3BC0 VA: 0x1816A55C0
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, bool>.MoveNext
	|
	|-RVA: 0x19BD6A0 Offset: 0x19BBCA0 VA: 0x1819BD6A0
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, Resolution>.MoveNext
	|
	|-RVA: 0x19BE650 Offset: 0x19BCC50 VA: 0x1819BE650
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, InventoryItem>.MoveNext
	|
	|-RVA: 0x19BF7B0 Offset: 0x19BDDB0 VA: 0x1819BF7B0
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x19BE170 Offset: 0x19BC770 VA: 0x1819BE170
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x19BF6A0 Offset: 0x19BDCA0 VA: 0x1819BF6A0
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, uint>.MoveNext
	|
	|-RVA: 0x19BFC00 Offset: 0x19BE200 VA: 0x1819BFC00
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, object>.MoveNext
	|
	|-RVA: 0x19BF9F0 Offset: 0x19BDFF0 VA: 0x1819BF9F0
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, float>.MoveNext
	|
	|-RVA: 0x19BE040 Offset: 0x19BC640 VA: 0x1819BE040
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe, PlayerItemRecipe>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x19BD480 Offset: 0x19BBA80 VA: 0x1819BD480
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe, object>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, object>.MoveNext
	|
	|-RVA: 0x19BDB10 Offset: 0x19BC110 VA: 0x1819BDB10
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, long>.MoveNext
	|
	|-RVA: 0x19BD7D0 Offset: 0x19BBDD0 VA: 0x1819BD7D0
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, Resolution>.MoveNext
	|
	|-RVA: 0x19BF0C0 Offset: 0x19BD6C0 VA: 0x1819BF0C0
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, Option>.MoveNext
	|
	|-RVA: 0x19BDC30 Offset: 0x19BC230 VA: 0x1819BDC30
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, InventoryItem>.MoveNext
	|
	|-RVA: 0x19BECC0 Offset: 0x19BD2C0 VA: 0x1819BECC0
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x19BE790 Offset: 0x19BCD90 VA: 0x1819BE790
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x19BD9F0 Offset: 0x19BBFF0 VA: 0x1819BD9F0
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, bool>.MoveNext
	|
	|-RVA: 0x19BDD60 Offset: 0x19BC360 VA: 0x1819BDD60
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, Int32Enum>.MoveNext
	|
	|-RVA: 0x19BE9C0 Offset: 0x19BCFC0 VA: 0x1819BE9C0
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, float>.MoveNext
	|
	|-RVA: 0x19BEDF0 Offset: 0x19BD3F0 VA: 0x1819BEDF0
	|-Enumerable.WhereSelectArrayIterator<int, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<int, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, bool>.MoveNext
	|
	|-RVA: 0x19BD3A0 Offset: 0x19BB9A0 VA: 0x1819BD3A0
	|-Enumerable.WhereSelectArrayIterator<int, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Int32Enum>.MoveNext
	|
	|-RVA: 0x19BE390 Offset: 0x19BC990 VA: 0x1819BE390
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x19BE570 Offset: 0x19BCB70 VA: 0x1819BE570
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, long>.MoveNext
	|
	|-RVA: 0x19BEAD0 Offset: 0x19BD0D0 VA: 0x1819BEAD0
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Resolution>.MoveNext
	|
	|-RVA: 0x19BFB00 Offset: 0x19BE100 VA: 0x1819BFB00
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Option>.MoveNext
	|
	|-RVA: 0x19BF8F0 Offset: 0x19BDEF0 VA: 0x1819BF8F0
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, InventoryItem>.MoveNext
	|
	|-RVA: 0x19BEBC0 Offset: 0x19BD1C0 VA: 0x1819BEBC0
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x19BE8C0 Offset: 0x19BCEC0 VA: 0x1819BE8C0
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x19BE480 Offset: 0x19BCA80 VA: 0x1819BE480
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.MoveNext
	|
	|-RVA: 0x19BDE80 Offset: 0x19BC480 VA: 0x1819BDE80
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, float>.MoveNext
	|
	|-RVA: 0x19BD900 Offset: 0x19BBF00 VA: 0x1819BD900
	|-Enumerable.WhereSelectArrayIterator<object, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, PlayerItemRecipe>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x19BE2B0 Offset: 0x19BC8B0 VA: 0x1819BE2B0
	|-Enumerable.WhereSelectArrayIterator<object, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, bool>.MoveNext
	|
	|-RVA: 0x19BDF60 Offset: 0x19BC560 VA: 0x1819BDF60
	|-Enumerable.WhereSelectArrayIterator<object, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, PlayerItemRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, InventoryItemId>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, long>.MoveNext
	|
	|-RVA: 0x19BF1F0 Offset: 0x19BD7F0 VA: 0x1819BF1F0
	|-Enumerable.WhereSelectArrayIterator<object, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, Resolution>.MoveNext
	|
	|-RVA: 0x19BF3C0 Offset: 0x19BD9C0 VA: 0x1819BF3C0
	|-Enumerable.WhereSelectArrayIterator<object, Option>.MoveNext
	|
	|-RVA: 0x19BF5A0 Offset: 0x19BDBA0 VA: 0x1819BF5A0
	|-Enumerable.WhereSelectArrayIterator<object, InventoryItem>.MoveNext
	|
	|-RVA: 0x19BEED0 Offset: 0x19BD4D0 VA: 0x1819BEED0
	|-Enumerable.WhereSelectArrayIterator<object, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x19BD5A0 Offset: 0x19BBBA0 VA: 0x1819BD5A0
	|-Enumerable.WhereSelectArrayIterator<object, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x19BF4C0 Offset: 0x19BDAC0 VA: 0x1819BF4C0
	|-Enumerable.WhereSelectArrayIterator<object, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, uint>.MoveNext
	|
	|-RVA: 0x19BEFD0 Offset: 0x19BD5D0 VA: 0x1819BEFD0
	|-Enumerable.WhereSelectArrayIterator<object, object>.MoveNext
	|
	|-RVA: 0x19BF2E0 Offset: 0x19BD8E0 VA: 0x1819BF2E0
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
	|-RVA: 0x16A8EA0 Offset: 0x16A74A0 VA: 0x1816A8EA0
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
	|-RVA: 0x16A8F20 Offset: 0x16A7520 VA: 0x1816A8F20
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
	|-RVA: 0x16A8FB0 Offset: 0x16A75B0 VA: 0x1816A8FB0
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
	|-RVA: 0x16A90D0 Offset: 0x16A76D0 VA: 0x1816A90D0
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
	|-RVA: 0x16A9040 Offset: 0x16A7640 VA: 0x1816A9040
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
	|-RVA: 0x16A9160 Offset: 0x16A7760 VA: 0x1816A9160
	|-Enumerable.WhereSelectListIterator<ServerInfo, ServerInfo>..ctor
	*/

	public override Enumerable.Iterator<TResult> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A3E00 Offset: 0x16A2400 VA: 0x1816A3E00
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
	|-RVA: 0x16A3CC0 Offset: 0x16A22C0 VA: 0x1816A3CC0
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
	|-RVA: 0x16A3D60 Offset: 0x16A2360 VA: 0x1816A3D60
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
	|-RVA: 0x16A3EA0 Offset: 0x16A24A0 VA: 0x1816A3EA0
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
	|-RVA: 0x16A3F40 Offset: 0x16A2540 VA: 0x1816A3F40
	|-Enumerable.WhereSelectListIterator<ServerInfo, ServerInfo>.Clone
	*/

	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176DD90 Offset: 0x176C390 VA: 0x18176DD90
	|-Enumerable.WhereSelectListIterator<BurstCloth.Chain, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<BurstCloth.Chain, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<Achievement, bool>.MoveNext
	|
	|-RVA: 0x1770390 Offset: 0x176E990 VA: 0x181770390
	|-Enumerable.WhereSelectListIterator<BurstCloth.Chain, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<Achievement, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<Achievement, Int32Enum>.MoveNext
	|
	|-RVA: 0x176C240 Offset: 0x176A840 VA: 0x18176C240
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x176EA50 Offset: 0x176D050 VA: 0x18176EA50
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, long>.MoveNext
	|
	|-RVA: 0x176C500 Offset: 0x176AB00 VA: 0x18176C500
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, Resolution>.MoveNext
	|
	|-RVA: 0x1772E40 Offset: 0x1771440 VA: 0x181772E40
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, Option>.MoveNext
	|
	|-RVA: 0x176D3F0 Offset: 0x176B9F0 VA: 0x18176D3F0
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, InventoryItem>.MoveNext
	|
	|-RVA: 0x1773280 Offset: 0x1771880 VA: 0x181773280
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x17711E0 Offset: 0x176F7E0 VA: 0x1817711E0
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1770A30 Offset: 0x176F030 VA: 0x181770A30
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, bool>.MoveNext
	|
	|-RVA: 0x1771AD0 Offset: 0x17700D0 VA: 0x181771AD0
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, Int32Enum>.MoveNext
	|
	|-RVA: 0x1773970 Offset: 0x1771F70 VA: 0x181773970
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, object>.MoveNext
	|
	|-RVA: 0x176EFD0 Offset: 0x176D5D0 VA: 0x18176EFD0
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, float>.MoveNext
	|
	|-RVA: 0x176EEA0 Offset: 0x176D4A0 VA: 0x18176EEA0
	|-Enumerable.WhereSelectListIterator<WeightedStringList.Container, float>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, float>.MoveNext
	|
	|-RVA: 0x176E400 Offset: 0x176CA00 VA: 0x18176E400
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, KeyValuePair<object, int>>.MoveNext
	|-Enumerable.WhereSelectListIterator<DictionaryEntry, KeyValuePair<object, object>>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x176CE20 Offset: 0x176B420 VA: 0x18176CE20
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, long>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, long>.MoveNext
	|
	|-RVA: 0x176DEB0 Offset: 0x176C4B0 VA: 0x18176DEB0
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, Resolution>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Resolution>.MoveNext
	|
	|-RVA: 0x1772520 Offset: 0x1770B20 VA: 0x181772520
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, Option>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Option>.MoveNext
	|
	|-RVA: 0x176D990 Offset: 0x176BF90 VA: 0x18176D990
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, InventoryItem>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, InventoryItem>.MoveNext
	|
	|-RVA: 0x176E2B0 Offset: 0x176C8B0 VA: 0x18176E2B0
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, InventoryRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1770F50 Offset: 0x176F550 VA: 0x181770F50
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, InventoryRecipe>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1770010 Offset: 0x176E610 VA: 0x181770010
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, bool>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, bool>.MoveNext
	|
	|-RVA: 0x176D2C0 Offset: 0x176B8C0 VA: 0x18176D2C0
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Int32Enum>.MoveNext
	|
	|-RVA: 0x1771DA0 Offset: 0x17703A0 VA: 0x181771DA0
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, object>.MoveNext
	|-Enumerable.WhereSelectListIterator<DictionaryEntry, object>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.MoveNext
	|
	|-RVA: 0x176FEE0 Offset: 0x176E4E0 VA: 0x18176FEE0
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, float>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, float>.MoveNext
	|
	|-RVA: 0x176FC50 Offset: 0x176E250 VA: 0x18176FC50
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe.Ingredient, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe.Ingredient, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<Friend, bool>.MoveNext
	|
	|-RVA: 0x1770270 Offset: 0x176E870 VA: 0x181770270
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe.Ingredient, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<Friend, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<Friend, Int32Enum>.MoveNext
	|
	|-RVA: 0x17710A0 Offset: 0x176F6A0 VA: 0x1817710A0
	|-Enumerable.WhereSelectListIterator<ProjectileWeaponMod.Modifier, float>.MoveNext
	|
	|-RVA: 0x1773800 Offset: 0x1771E00 VA: 0x181773800
	|-Enumerable.WhereSelectListIterator<Option, Option>.MoveNext
	|
	|-RVA: 0x176DAE0 Offset: 0x176C0E0 VA: 0x18176DAE0
	|-Enumerable.WhereSelectListIterator<ServerInfo, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<ServerInfo, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x176BFA0 Offset: 0x176A5A0 VA: 0x18176BFA0
	|-Enumerable.WhereSelectListIterator<ServerInfo, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<ServerInfo, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<ServerInfo, bool>.MoveNext
	|
	|-RVA: 0x176F9B0 Offset: 0x176DFB0 VA: 0x18176F9B0
	|-Enumerable.WhereSelectListIterator<ServerInfo, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<ServerInfo, long>.MoveNext
	|
	|-RVA: 0x176E660 Offset: 0x176CC60 VA: 0x18176E660
	|-Enumerable.WhereSelectListIterator<ServerInfo, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<ServerInfo, Resolution>.MoveNext
	|
	|-RVA: 0x176DFF0 Offset: 0x176C5F0 VA: 0x18176DFF0
	|-Enumerable.WhereSelectListIterator<ServerInfo, Option>.MoveNext
	|
	|-RVA: 0x1772B80 Offset: 0x1771180 VA: 0x181772B80
	|-Enumerable.WhereSelectListIterator<ServerInfo, InventoryItem>.MoveNext
	|
	|-RVA: 0x176F150 Offset: 0x176D750 VA: 0x18176F150
	|-Enumerable.WhereSelectListIterator<ServerInfo, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x176EBE0 Offset: 0x176D1E0 VA: 0x18176EBE0
	|-Enumerable.WhereSelectListIterator<ServerInfo, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x176F410 Offset: 0x176DA10 VA: 0x18176F410
	|-Enumerable.WhereSelectListIterator<ServerInfo, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<ServerInfo, Int32Enum>.MoveNext
	|
	|-RVA: 0x1772FE0 Offset: 0x17715E0 VA: 0x181772FE0
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>.MoveNext
	|
	|-RVA: 0x1770BC0 Offset: 0x176F1C0 VA: 0x181770BC0
	|-Enumerable.WhereSelectListIterator<ServerInfo, float>.MoveNext
	|
	|-RVA: 0x1770760 Offset: 0x176ED60 VA: 0x181770760
	|-Enumerable.WhereSelectListIterator<SkinnedMultiMesh.Part, long>.MoveNext
	|
	|-RVA: 0x176D190 Offset: 0x176B790 VA: 0x18176D190
	|-Enumerable.WhereSelectListIterator<Achievement, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<Achievement, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x176D070 Offset: 0x176B670 VA: 0x18176D070
	|-Enumerable.WhereSelectListIterator<Achievement, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<Achievement, long>.MoveNext
	|
	|-RVA: 0x176C920 Offset: 0x176AF20 VA: 0x18176C920
	|-Enumerable.WhereSelectListIterator<Achievement, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<Achievement, Resolution>.MoveNext
	|
	|-RVA: 0x1772A40 Offset: 0x1771040 VA: 0x181772A40
	|-Enumerable.WhereSelectListIterator<Achievement, Option>.MoveNext
	|
	|-RVA: 0x17722A0 Offset: 0x17708A0 VA: 0x1817722A0
	|-Enumerable.WhereSelectListIterator<Achievement, InventoryItem>.MoveNext
	|
	|-RVA: 0x17704B0 Offset: 0x176EAB0 VA: 0x1817704B0
	|-Enumerable.WhereSelectListIterator<Achievement, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1771990 Offset: 0x176FF90 VA: 0x181771990
	|-Enumerable.WhereSelectListIterator<Achievement, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x176D860 Offset: 0x176BE60 VA: 0x18176D860
	|-Enumerable.WhereSelectListIterator<Achievement, object>.MoveNext
	|
	|-RVA: 0x1772670 Offset: 0x1770C70 VA: 0x181772670
	|-Enumerable.WhereSelectListIterator<Achievement, float>.MoveNext
	|
	|-RVA: 0x1771380 Offset: 0x176F980 VA: 0x181771380
	|-Enumerable.WhereSelectListIterator<InventoryDefId, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryDefId, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x176C6A0 Offset: 0x176ACA0 VA: 0x18176C6A0
	|-Enumerable.WhereSelectListIterator<InventoryDefId, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryDefId, long>.MoveNext
	|
	|-RVA: 0x17715D0 Offset: 0x176FBD0 VA: 0x1817715D0
	|-Enumerable.WhereSelectListIterator<InventoryDefId, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryDefId, Resolution>.MoveNext
	|
	|-RVA: 0x1771C60 Offset: 0x1770260 VA: 0x181771C60
	|-Enumerable.WhereSelectListIterator<InventoryDefId, Option>.MoveNext
	|
	|-RVA: 0x176E910 Offset: 0x176CF10 VA: 0x18176E910
	|-Enumerable.WhereSelectListIterator<InventoryDefId, InventoryItem>.MoveNext
	|
	|-RVA: 0x17723E0 Offset: 0x17709E0 VA: 0x1817723E0
	|-Enumerable.WhereSelectListIterator<InventoryDefId, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1772900 Offset: 0x1770F00 VA: 0x181772900
	|-Enumerable.WhereSelectListIterator<InventoryDefId, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x176E540 Offset: 0x176CB40 VA: 0x18176E540
	|-Enumerable.WhereSelectListIterator<InventoryDefId, bool>.MoveNext
	|
	|-RVA: 0x176C3E0 Offset: 0x176A9E0 VA: 0x18176C3E0
	|-Enumerable.WhereSelectListIterator<InventoryDefId, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryDefId, Int32Enum>.MoveNext
	|
	|-RVA: 0x1770140 Offset: 0x176E740 VA: 0x181770140
	|-Enumerable.WhereSelectListIterator<InventoryDefId, object>.MoveNext
	|
	|-RVA: 0x1771700 Offset: 0x176FD00 VA: 0x181771700
	|-Enumerable.WhereSelectListIterator<InventoryDefId, float>.MoveNext
	|
	|-RVA: 0x176F6B0 Offset: 0x176DCB0 VA: 0x18176F6B0
	|-Enumerable.WhereSelectListIterator<ServerInfo, ServerInfo>.MoveNext
	|
	|-RVA: 0x1773560 Offset: 0x1771B60 VA: 0x181773560
	|-Enumerable.WhereSelectListIterator<ServerInfo, int>.MoveNext
	|
	|-RVA: 0x176CB80 Offset: 0x176B180 VA: 0x18176CB80
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>.MoveNext
	|
	|-RVA: 0x176CA50 Offset: 0x176B050 VA: 0x18176CA50
	|-Enumerable.WhereSelectListIterator<Friend, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<Friend, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x176CF50 Offset: 0x176B550 VA: 0x18176CF50
	|-Enumerable.WhereSelectListIterator<Friend, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<Friend, long>.MoveNext
	|
	|-RVA: 0x176BE70 Offset: 0x176A470 VA: 0x18176BE70
	|-Enumerable.WhereSelectListIterator<Friend, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<Friend, Resolution>.MoveNext
	|
	|-RVA: 0x1772020 Offset: 0x1770620 VA: 0x181772020
	|-Enumerable.WhereSelectListIterator<Friend, Option>.MoveNext
	|
	|-RVA: 0x1771EE0 Offset: 0x17704E0 VA: 0x181771EE0
	|-Enumerable.WhereSelectListIterator<Friend, InventoryItem>.MoveNext
	|
	|-RVA: 0x1772160 Offset: 0x1770760 VA: 0x181772160
	|-Enumerable.WhereSelectListIterator<Friend, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1773420 Offset: 0x1771A20 VA: 0x181773420
	|-Enumerable.WhereSelectListIterator<Friend, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1770E20 Offset: 0x176F420 VA: 0x181770E20
	|-Enumerable.WhereSelectListIterator<Friend, object>.MoveNext
	|
	|-RVA: 0x17714B0 Offset: 0x176FAB0 VA: 0x1817714B0
	|-Enumerable.WhereSelectListIterator<Friend, float>.MoveNext
	|
	|-RVA: 0x176D590 Offset: 0x176BB90 VA: 0x18176D590
	|-Enumerable.WhereSelectListIterator<InventoryItem, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryItem, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x176C7C0 Offset: 0x176ADC0 VA: 0x18176C7C0
	|-Enumerable.WhereSelectListIterator<InventoryItem, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryItem, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryItem, bool>.MoveNext
	|
	|-RVA: 0x176D700 Offset: 0x176BD00 VA: 0x18176D700
	|-Enumerable.WhereSelectListIterator<InventoryItem, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryItem, InventoryItemId>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryItem, long>.MoveNext
	|
	|-RVA: 0x176FD70 Offset: 0x176E370 VA: 0x18176FD70
	|-Enumerable.WhereSelectListIterator<InventoryItem, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryItem, Resolution>.MoveNext
	|
	|-RVA: 0x17708C0 Offset: 0x176EEC0 VA: 0x1817708C0
	|-Enumerable.WhereSelectListIterator<InventoryItem, Option>.MoveNext
	|
	|-RVA: 0x1772790 Offset: 0x1770D90 VA: 0x181772790
	|-Enumerable.WhereSelectListIterator<InventoryItem, InventoryItem>.MoveNext
	|
	|-RVA: 0x1771820 Offset: 0x176FE20 VA: 0x181771820
	|-Enumerable.WhereSelectListIterator<InventoryItem, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x17705F0 Offset: 0x176EBF0 VA: 0x1817705F0
	|-Enumerable.WhereSelectListIterator<InventoryItem, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1792AB0 Offset: 0x17910B0 VA: 0x181792AB0
	|-Enumerable.WhereSelectListIterator<InventoryItem, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryItem, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryItem, uint>.MoveNext
	|
	|-RVA: 0x1791460 Offset: 0x178FA60 VA: 0x181791460
	|-Enumerable.WhereSelectListIterator<InventoryItem, object>.MoveNext
	|
	|-RVA: 0x1793880 Offset: 0x1791E80 VA: 0x181793880
	|-Enumerable.WhereSelectListIterator<InventoryItem, float>.MoveNext
	|
	|-RVA: 0x1792D40 Offset: 0x1791340 VA: 0x181792D40
	|-Enumerable.WhereSelectListIterator<InventoryItem.Amount, InventoryItemId>.MoveNext
	|
	|-RVA: 0x1793010 Offset: 0x1791610 VA: 0x181793010
	|-Enumerable.WhereSelectListIterator<InventoryItem.Amount, uint>.MoveNext
	|
	|-RVA: 0x17915D0 Offset: 0x178FBD0 VA: 0x1817915D0
	|-Enumerable.WhereSelectListIterator<InventoryRecipe, PlayerItemRecipe>.MoveNext
	|
	|-RVA: 0x17934A0 Offset: 0x1791AA0 VA: 0x1817934A0
	|-Enumerable.WhereSelectListIterator<InventoryRecipe, object>.MoveNext
	|
	|-RVA: 0x1790F30 Offset: 0x178F530 VA: 0x181790F30
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x17912F0 Offset: 0x178F8F0 VA: 0x1817912F0
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, long>.MoveNext
	|
	|-RVA: 0x1791B60 Offset: 0x1790160 VA: 0x181791B60
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, Resolution>.MoveNext
	|
	|-RVA: 0x17919D0 Offset: 0x178FFD0 VA: 0x1817919D0
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, Option>.MoveNext
	|
	|-RVA: 0x1792420 Offset: 0x1790A20 VA: 0x181792420
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, InventoryItem>.MoveNext
	|
	|-RVA: 0x1793310 Offset: 0x1791910 VA: 0x181793310
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1793D70 Offset: 0x1792370 VA: 0x181793D70
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x17925B0 Offset: 0x1790BB0 VA: 0x1817925B0
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, bool>.MoveNext
	|
	|-RVA: 0x1790690 Offset: 0x178EC90 VA: 0x181790690
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, Int32Enum>.MoveNext
	|
	|-RVA: 0x17931A0 Offset: 0x17917A0 VA: 0x1817931A0
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, object>.MoveNext
	|
	|-RVA: 0x1794040 Offset: 0x1792640 VA: 0x181794040
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, float>.MoveNext
	|
	|-RVA: 0x1793C30 Offset: 0x1792230 VA: 0x181793C30
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1792C10 Offset: 0x1791210 VA: 0x181792C10
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, long>.MoveNext
	|
	|-RVA: 0x1790550 Offset: 0x178EB50 VA: 0x181790550
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, Resolution>.MoveNext
	|
	|-RVA: 0x1790800 Offset: 0x178EE00 VA: 0x181790800
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, Option>.MoveNext
	|
	|-RVA: 0x1791E10 Offset: 0x1790410 VA: 0x181791E10
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, InventoryItem>.MoveNext
	|
	|-RVA: 0x1791750 Offset: 0x178FD50 VA: 0x181791750
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1790BA0 Offset: 0x178F1A0 VA: 0x181790BA0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1794420 Offset: 0x1792A20 VA: 0x181794420
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, bool>.MoveNext
	|
	|-RVA: 0x17922F0 Offset: 0x17908F0 VA: 0x1817922F0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, uint>.MoveNext
	|
	|-RVA: 0x1793740 Offset: 0x1791D40 VA: 0x181793740
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, object>.MoveNext
	|
	|-RVA: 0x1790CF0 Offset: 0x178F2F0 VA: 0x181790CF0
	|-Enumerable.WhereSelectListIterator<int, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<int, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<Int32Enum, bool>.MoveNext
	|
	|-RVA: 0x1792860 Offset: 0x1790E60 VA: 0x181792860
	|-Enumerable.WhereSelectListIterator<int, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<Int32Enum, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<Int32Enum, Int32Enum>.MoveNext
	|
	|-RVA: 0x1790A70 Offset: 0x178F070 VA: 0x181790A70
	|-Enumerable.WhereSelectListIterator<Int32Enum, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<Int32Enum, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x17911D0 Offset: 0x178F7D0 VA: 0x1817911D0
	|-Enumerable.WhereSelectListIterator<Int32Enum, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<Int32Enum, long>.MoveNext
	|
	|-RVA: 0x17918A0 Offset: 0x178FEA0 VA: 0x1817918A0
	|-Enumerable.WhereSelectListIterator<Int32Enum, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<Int32Enum, Resolution>.MoveNext
	|
	|-RVA: 0x1792720 Offset: 0x1790D20 VA: 0x181792720
	|-Enumerable.WhereSelectListIterator<Int32Enum, Option>.MoveNext
	|
	|-RVA: 0x1792ED0 Offset: 0x17914D0 VA: 0x181792ED0
	|-Enumerable.WhereSelectListIterator<Int32Enum, InventoryItem>.MoveNext
	|
	|-RVA: 0x17942E0 Offset: 0x17928E0 VA: 0x1817942E0
	|-Enumerable.WhereSelectListIterator<Int32Enum, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x17939D0 Offset: 0x1791FD0 VA: 0x1817939D0
	|-Enumerable.WhereSelectListIterator<Int32Enum, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1793610 Offset: 0x1791C10 VA: 0x181793610
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.MoveNext
	|
	|-RVA: 0x1793B10 Offset: 0x1792110 VA: 0x181793B10
	|-Enumerable.WhereSelectListIterator<Int32Enum, float>.MoveNext
	|
	|-RVA: 0x1791CE0 Offset: 0x17902E0 VA: 0x181791CE0
	|-Enumerable.WhereSelectListIterator<object, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, PlayerItemRecipe>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x17910B0 Offset: 0x178F6B0 VA: 0x1817910B0
	|-Enumerable.WhereSelectListIterator<object, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, bool>.MoveNext
	|
	|-RVA: 0x1790950 Offset: 0x178EF50 VA: 0x181790950
	|-Enumerable.WhereSelectListIterator<object, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, PlayerItemRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, InventoryItemId>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, long>.MoveNext
	|
	|-RVA: 0x1792980 Offset: 0x1790F80 VA: 0x181792980
	|-Enumerable.WhereSelectListIterator<object, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, Resolution>.MoveNext
	|
	|-RVA: 0x1793F00 Offset: 0x1792500 VA: 0x181793F00
	|-Enumerable.WhereSelectListIterator<object, Option>.MoveNext
	|
	|-RVA: 0x17921B0 Offset: 0x17907B0 VA: 0x1817921B0
	|-Enumerable.WhereSelectListIterator<object, InventoryItem>.MoveNext
	|
	|-RVA: 0x1794550 Offset: 0x1792B50 VA: 0x181794550
	|-Enumerable.WhereSelectListIterator<object, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x17941A0 Offset: 0x17927A0 VA: 0x1817941A0
	|-Enumerable.WhereSelectListIterator<object, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1790E10 Offset: 0x178F410 VA: 0x181790E10
	|-Enumerable.WhereSelectListIterator<object, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, uint>.MoveNext
	|
	|-RVA: 0x1792080 Offset: 0x1790680 VA: 0x181792080
	|-Enumerable.WhereSelectListIterator<object, object>.MoveNext
	|
	|-RVA: 0x1791F60 Offset: 0x1790560 VA: 0x181791F60
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
	|-RVA: 0x1773B00 Offset: 0x1772100 VA: 0x181773B00
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
	|-RVA: 0x19EFEB0 Offset: 0x19EE4B0 VA: 0x1819EFEB0
	|-Enumerable.<>c__DisplayClass6_0<Debugging.EntityInfo>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<GameStat.Stat>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<PlayerItemRecipe>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<KeyValuePair<object, int>>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<KeyValuePair<object, object>>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<KeyValuePair<uint, object>>.<CombinePredicates>b__0
	|
	|-RVA: 0x19EFFD0 Offset: 0x19EE5D0 VA: 0x1819EFFD0
	|-Enumerable.<>c__DisplayClass6_0<SkeletonDefinition.Bone>.<CombinePredicates>b__0
	|
	|-RVA: 0x19F0460 Offset: 0x19EEA60 VA: 0x1819F0460
	|-Enumerable.<>c__DisplayClass6_0<ItemSkinDirectory.Skin>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<Option>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<SkinnedMultiMesh.Part>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<InventoryItem>.<CombinePredicates>b__0
	|
	|-RVA: 0x19F03E0 Offset: 0x19EE9E0 VA: 0x1819F03E0
	|-Enumerable.<>c__DisplayClass6_0<FourBitNumber>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<SevenBitNumber>.<CombinePredicates>b__0
	|
	|-RVA: 0x19F0360 Offset: 0x19EE960 VA: 0x1819F0360
	|-Enumerable.<>c__DisplayClass6_0<PathFinder.Point>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<PlayerItemRecipe.Ingredient>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<InventoryItemId>.<CombinePredicates>b__0
	|
	|-RVA: 0x19F0230 Offset: 0x19EE830 VA: 0x1819F0230
	|-Enumerable.<>c__DisplayClass6_0<ProjectileWeaponMod.Modifier>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<Resolution>.<CombinePredicates>b__0
	|
	|-RVA: 0x19F0090 Offset: 0x19EE690 VA: 0x1819F0090
	|-Enumerable.<>c__DisplayClass6_0<ServerInfo>.<CombinePredicates>b__0
	|
	|-RVA: 0x19F0510 Offset: 0x19EEB10 VA: 0x1819F0510
	|-Enumerable.<>c__DisplayClass6_0<InventoryRecipe.Ingredient>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<InventoryRecipe>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<KeyValuePair<ulong, Dispatch.ResultCallback>>.<CombinePredicates>b__0
	|
	|-RVA: 0x19F0640 Offset: 0x19EEC40 VA: 0x1819F0640
	|-Enumerable.<>c__DisplayClass6_0<bool>.<CombinePredicates>b__0
	|
	|-RVA: 0x19F02E0 Offset: 0x19EE8E0 VA: 0x1819F02E0
	|-Enumerable.<>c__DisplayClass6_0<char>.<CombinePredicates>b__0
	|
	|-RVA: 0x19EFF50 Offset: 0x19EE550 VA: 0x1819EFF50
	|-Enumerable.<>c__DisplayClass6_0<int>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<Int32Enum>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<uint>.<CombinePredicates>b__0
	|
	|-RVA: 0x19F01B0 Offset: 0x19EE7B0 VA: 0x1819F01B0
	|-Enumerable.<>c__DisplayClass6_0<long>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<object>.<CombinePredicates>b__0
	|
	|-RVA: 0x19F05C0 Offset: 0x19EEBC0 VA: 0x1819F05C0
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
	|-RVA: 0x144D3C0 Offset: 0x144B9C0 VA: 0x18144D3C0
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
	|-RVA: 0x144BD90 Offset: 0x144A390 VA: 0x18144BD90
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
	|-RVA: 0x19F0D40 Offset: 0x19EF340 VA: 0x1819F0D40
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, Debugging.EntityInfo, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, KeyValuePair<object, int>, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x19F0790 Offset: 0x19EED90 VA: 0x1819F0790
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
	|-RVA: 0x19F0AC0 Offset: 0x19EF0C0 VA: 0x1819F0AC0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, Resolution, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x19F08C0 Offset: 0x19EEEC0 VA: 0x1819F08C0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, Option, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, InventoryItem, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x19F06C0 Offset: 0x19EECC0 VA: 0x1819F06C0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|
	|-RVA: 0x19F0990 Offset: 0x19EEF90 VA: 0x1819F0990
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, bool, bool>.<CombineSelectors>b__0
	|
	|-RVA: 0x19F0B90 Offset: 0x19EF190 VA: 0x1819F0B90
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, Int32Enum, Int32Enum>.<CombineSelectors>b__0
	|
	|-RVA: 0x19F0E00 Offset: 0x19EF400 VA: 0x1819F0E00
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x19F0C90 Offset: 0x19EF290 VA: 0x1819F0C90
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x19F0810 Offset: 0x19EEE10 VA: 0x1819F0810
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x19F0A10 Offset: 0x19EF010 VA: 0x1819F0A10
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, InventoryRecipe>.<CombineSelectors>b__0
	|
	|-RVA: 0x19F0C10 Offset: 0x19EF210 VA: 0x1819F0C10
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, float, float>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C870 Offset: 0x144AE70 VA: 0x18144C870
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, Debugging.EntityInfo, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, KeyValuePair<object, int>, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, Debugging.EntityInfo, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, KeyValuePair<object, int>, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, Debugging.EntityInfo, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, KeyValuePair<object, int>, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x144BC70 Offset: 0x144A270 VA: 0x18144BC70
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
	|-RVA: 0x144BCE0 Offset: 0x144A2E0 VA: 0x18144BCE0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, Resolution, Resolution>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, Resolution, Resolution>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, Resolution, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C050 Offset: 0x144A650 VA: 0x18144C050
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, Option, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, InventoryItem, InventoryItem>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, Option, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, InventoryItem, InventoryItem>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, Option, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, InventoryItem, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x144CAC0 Offset: 0x144B0C0 VA: 0x18144CAC0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|
	|-RVA: 0x144DAA0 Offset: 0x144C0A0 VA: 0x18144DAA0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, bool, bool>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, bool, bool>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, bool, bool>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C5E0 Offset: 0x144ABE0 VA: 0x18144C5E0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, Int32Enum, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, Int32Enum, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, Int32Enum, Int32Enum>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C410 Offset: 0x144AA10 VA: 0x18144C410
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E0B0 Offset: 0x144C6B0 VA: 0x18144E0B0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, Resolution>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, Resolution>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144CA30 Offset: 0x144B030 VA: 0x18144CA30
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, InventoryItem>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, InventoryItem>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D120 Offset: 0x144B720 VA: 0x18144D120
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, InventoryRecipe>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D420 Offset: 0x144BA20 VA: 0x18144D420
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, float, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, float, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, float, float>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C650 Offset: 0x144AC50 VA: 0x18144C650
	|-Enumerable.<>c__DisplayClass7_0<Option, Option, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, Option, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, InventoryItem, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x144CC10 Offset: 0x144B210 VA: 0x18144CC10
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, Debugging.EntityInfo, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, KeyValuePair<object, int>, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E300 Offset: 0x144C900 VA: 0x18144E300
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, FourBitNumber, FourBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, SevenBitNumber, SevenBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, bool, bool>.<CombineSelectors>b__0
	|
	|-RVA: 0x144CEB0 Offset: 0x144B4B0 VA: 0x18144CEB0
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
	|-RVA: 0x144DC90 Offset: 0x144C290 VA: 0x18144DC90
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, Resolution, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144BF50 Offset: 0x144A550 VA: 0x18144BF50
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, Option, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, InventoryItem, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D710 Offset: 0x144BD10 VA: 0x18144D710
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|
	|-RVA: 0x144DE20 Offset: 0x144C420 VA: 0x18144DE20
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, int, FourBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, int, SevenBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, Int32Enum, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, int, int>.<CombineSelectors>b__0
	|
	|-RVA: 0x144EAB0 Offset: 0x144D0B0 VA: 0x18144EAB0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x144DB10 Offset: 0x144C110 VA: 0x18144DB10
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D240 Offset: 0x144B840 VA: 0x18144D240
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E9C0 Offset: 0x144CFC0 VA: 0x18144E9C0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, InventoryRecipe>.<CombineSelectors>b__0
	|
	|-RVA: 0x144EB90 Offset: 0x144D190 VA: 0x18144EB90
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, float, float>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D090 Offset: 0x144B690 VA: 0x18144D090
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
	|-RVA: 0x144BE70 Offset: 0x144A470 VA: 0x18144BE70
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
	|-RVA: 0x144C4A0 Offset: 0x144AAA0 VA: 0x18144C4A0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, Resolution, Resolution>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, Resolution, Resolution>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, Resolution, Resolution>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, Resolution, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144CB70 Offset: 0x144B170 VA: 0x18144CB70
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
	|-RVA: 0x144C540 Offset: 0x144AB40 VA: 0x18144C540
	|-Enumerable.<>c__DisplayClass7_0<Achievement, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C910 Offset: 0x144AF10 VA: 0x18144C910
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x144DD90 Offset: 0x144C390 VA: 0x18144DD90
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, Resolution>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D330 Offset: 0x144B930 VA: 0x18144D330
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, InventoryItem>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C300 Offset: 0x144A900 VA: 0x18144C300
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, InventoryRecipe>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C100 Offset: 0x144A700 VA: 0x18144C100
	|-Enumerable.<>c__DisplayClass7_0<Achievement, float, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, float, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, float, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, float, float>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E280 Offset: 0x144C880 VA: 0x18144E280
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E3C0 Offset: 0x144C9C0 VA: 0x18144E3C0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D000 Offset: 0x144B600 VA: 0x18144D000
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x144CF70 Offset: 0x144B570 VA: 0x18144CF70
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, InventoryRecipe>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D5F0 Offset: 0x144BBF0 VA: 0x18144D5F0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, ServerInfo, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, ServerInfo, object>.<CombineSelectors>b__0
	|
	|-RVA: 0x144DBF0 Offset: 0x144C1F0 VA: 0x18144DBF0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, Debugging.EntityInfo, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, KeyValuePair<object, int>, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E200 Offset: 0x144C800 VA: 0x18144E200
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, FourBitNumber, FourBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, SevenBitNumber, SevenBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, bool, bool>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C280 Offset: 0x144A880 VA: 0x18144C280
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
	|-RVA: 0x144C710 Offset: 0x144AD10 VA: 0x18144C710
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, Resolution, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E900 Offset: 0x144CF00 VA: 0x18144E900
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|
	|-RVA: 0x144CDA0 Offset: 0x144B3A0 VA: 0x18144CDA0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, int, FourBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, int, SevenBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, Int32Enum, Int32Enum>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D810 Offset: 0x144BE10 VA: 0x18144D810
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D8B0 Offset: 0x144BEB0 VA: 0x18144D8B0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C1E0 Offset: 0x144A7E0 VA: 0x18144C1E0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D490 Offset: 0x144BA90 VA: 0x18144D490
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, InventoryRecipe>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D1C0 Offset: 0x144B7C0 VA: 0x18144D1C0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, float, float>.<CombineSelectors>b__0
	|
	|-RVA: 0x144DA10 Offset: 0x144C010 VA: 0x18144DA10
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe, PlayerItemRecipe, object>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C390 Offset: 0x144A990 VA: 0x18144C390
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
	|-RVA: 0x144BBC0 Offset: 0x144A1C0 VA: 0x18144BBC0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, Debugging.EntityInfo, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, KeyValuePair<object, int>, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D950 Offset: 0x144BF50 VA: 0x18144D950
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, Resolution, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D530 Offset: 0x144BB30 VA: 0x18144D530
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, Option, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, InventoryItem, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E140 Offset: 0x144C740 VA: 0x18144E140
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E770 Offset: 0x144CD70 VA: 0x18144E770
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, bool, bool>.<CombineSelectors>b__0
	|
	|-RVA: 0x144BED0 Offset: 0x144A4D0 VA: 0x18144BED0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, Int32Enum, Int32Enum>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C990 Offset: 0x144AF90 VA: 0x18144C990
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E010 Offset: 0x144C610 VA: 0x18144E010
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144DF70 Offset: 0x144C570 VA: 0x18144DF70
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x144CD00 Offset: 0x144B300 VA: 0x18144CD00
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, InventoryRecipe>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E570 Offset: 0x144CB70 VA: 0x18144E570
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, float, float>.<CombineSelectors>b__0
	|
	|-RVA: 0x144BDF0 Offset: 0x144A3F0 VA: 0x18144BDF0
	|-Enumerable.<>c__DisplayClass7_0<DictionaryEntry, KeyValuePair<object, object>, object>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E5F0 Offset: 0x144CBF0 VA: 0x18144E5F0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E450 Offset: 0x144CA50 VA: 0x18144E450
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E870 Offset: 0x144CE70 VA: 0x18144E870
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x144DEE0 Offset: 0x144C4E0 VA: 0x18144DEE0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, InventoryRecipe>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E7F0 Offset: 0x144CDF0 VA: 0x18144E7F0
	|-Enumerable.<>c__DisplayClass7_0<object, ProjectileWeaponMod.Modifier, float>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E6F0 Offset: 0x144CCF0 VA: 0x18144E6F0
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryItem, InventoryItemId>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryItem, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryItem, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryItem, uint>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C7D0 Offset: 0x144ADD0 VA: 0x18144C7D0
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryRecipe, PlayerItemRecipe>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C160 Offset: 0x144A760 VA: 0x18144C160
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryRecipe.Ingredient, object>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E670 Offset: 0x144CC70 VA: 0x18144E670
	|-Enumerable.<>c__DisplayClass7_0<object, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x144EC50 Offset: 0x144D250 VA: 0x18144EC50
	|-Enumerable.<>c__DisplayClass7_0<object, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, object, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E4E0 Offset: 0x144CAE0 VA: 0x18144E4E0
	|-Enumerable.<>c__DisplayClass7_0<object, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, object, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x144CE20 Offset: 0x144B420 VA: 0x18144CE20
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
	|-RVA: 0x144ACD0 Offset: 0x14492D0 VA: 0x18144ACD0
	|-Enumerable.<SelectManyIterator>d__17<object, PlayerItemRecipe>..ctor
	|
	|-RVA: 0x19D43C0 Offset: 0x19D29C0 VA: 0x1819D43C0
	|-Enumerable.<SelectManyIterator>d__17<object, InventoryRecipe>..ctor
	|
	|-RVA: 0x144AC90 Offset: 0x1449290 VA: 0x18144AC90
	|-Enumerable.<SelectManyIterator>d__17<object, byte>..ctor
	|
	|-RVA: 0x144AD10 Offset: 0x1449310 VA: 0x18144AD10
	|-Enumerable.<SelectManyIterator>d__17<object, object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D4070 Offset: 0x19D2670 VA: 0x1819D4070
	|-Enumerable.<SelectManyIterator>d__17<object, PlayerItemRecipe>.System.IDisposable.Dispose
	|-Enumerable.<SelectManyIterator>d__17<object, InventoryRecipe>.System.IDisposable.Dispose
	|-Enumerable.<SelectManyIterator>d__17<object, byte>.System.IDisposable.Dispose
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D32B0 Offset: 0x19D18B0 VA: 0x1819D32B0
	|-Enumerable.<SelectManyIterator>d__17<object, PlayerItemRecipe>.MoveNext
	|
	|-RVA: 0x19D2FD0 Offset: 0x19D15D0 VA: 0x1819D2FD0
	|-Enumerable.<SelectManyIterator>d__17<object, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x19D3850 Offset: 0x19D1E50 VA: 0x1819D3850
	|-Enumerable.<SelectManyIterator>d__17<object, byte>.MoveNext
	|
	|-RVA: 0x19D3580 Offset: 0x19D1B80 VA: 0x1819D3580
	|-Enumerable.<SelectManyIterator>d__17<object, object>.MoveNext
	*/

	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D4230 Offset: 0x19D2830 VA: 0x1819D4230
	|-Enumerable.<SelectManyIterator>d__17<object, PlayerItemRecipe>.<>m__Finally1
	|
	|-RVA: 0x19D41E0 Offset: 0x19D27E0 VA: 0x1819D41E0
	|-Enumerable.<SelectManyIterator>d__17<object, InventoryRecipe>.<>m__Finally1
	|
	|-RVA: 0x19D4140 Offset: 0x19D2740 VA: 0x1819D4140
	|-Enumerable.<SelectManyIterator>d__17<object, byte>.<>m__Finally1
	|
	|-RVA: 0x19D4190 Offset: 0x19D2790 VA: 0x1819D4190
	|-Enumerable.<SelectManyIterator>d__17<object, object>.<>m__Finally1
	*/

	private void <>m__Finally2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D4370 Offset: 0x19D2970 VA: 0x1819D4370
	|-Enumerable.<SelectManyIterator>d__17<object, PlayerItemRecipe>.<>m__Finally2
	|
	|-RVA: 0x19D42D0 Offset: 0x19D28D0 VA: 0x1819D42D0
	|-Enumerable.<SelectManyIterator>d__17<object, InventoryRecipe>.<>m__Finally2
	|
	|-RVA: 0x19D4280 Offset: 0x19D2880 VA: 0x1819D4280
	|-Enumerable.<SelectManyIterator>d__17<object, byte>.<>m__Finally2
	|
	|-RVA: 0x19D4320 Offset: 0x19D2920 VA: 0x1819D4320
	|-Enumerable.<SelectManyIterator>d__17<object, object>.<>m__Finally2
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB11B00 Offset: 0xB10100 VA: 0x180B11B00
	|-Enumerable.<SelectManyIterator>d__17<object, PlayerItemRecipe>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0x11284A0 Offset: 0x1126AA0 VA: 0x1811284A0
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
	|-RVA: 0x19D3EE0 Offset: 0x19D24E0 VA: 0x1819D3EE0
	|-Enumerable.<SelectManyIterator>d__17<object, PlayerItemRecipe>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D3E90 Offset: 0x19D2490 VA: 0x1819D3E90
	|-Enumerable.<SelectManyIterator>d__17<object, InventoryRecipe>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D3F30 Offset: 0x19D2530 VA: 0x1819D3F30
	|-Enumerable.<SelectManyIterator>d__17<object, byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D3E40 Offset: 0x19D2440 VA: 0x1819D3E40
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D4020 Offset: 0x19D2620 VA: 0x1819D4020
	|-Enumerable.<SelectManyIterator>d__17<object, PlayerItemRecipe>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D3FD0 Offset: 0x19D25D0 VA: 0x1819D3FD0
	|-Enumerable.<SelectManyIterator>d__17<object, InventoryRecipe>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D3F80 Offset: 0x19D2580 VA: 0x1819D3F80
	|-Enumerable.<SelectManyIterator>d__17<object, byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D3B10 Offset: 0x19D2110 VA: 0x1819D3B10
	|-Enumerable.<SelectManyIterator>d__17<object, PlayerItemRecipe>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0x19D3BD0 Offset: 0x19D21D0 VA: 0x1819D3BD0
	|-Enumerable.<SelectManyIterator>d__17<object, InventoryRecipe>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0x19D3D50 Offset: 0x19D2350 VA: 0x1819D3D50
	|-Enumerable.<SelectManyIterator>d__17<object, byte>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0x19D3C90 Offset: 0x19D2290 VA: 0x1819D3C90
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D3E10 Offset: 0x19D2410 VA: 0x1819D3E10
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
	|-RVA: 0x19D5CC0 Offset: 0x19D42C0 VA: 0x1819D5CC0
	|-Enumerable.<TakeIterator>d__25<Option>..ctor
	|-Enumerable.<TakeIterator>d__25<InventoryItem>..ctor
	|
	|-RVA: 0x144AC90 Offset: 0x1449290 VA: 0x18144AC90
	|-Enumerable.<TakeIterator>d__25<byte>..ctor
	|
	|-RVA: 0x144AD10 Offset: 0x1449310 VA: 0x18144AD10
	|-Enumerable.<TakeIterator>d__25<double>..ctor
	|-Enumerable.<TakeIterator>d__25<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A9D0 Offset: 0x1448FD0 VA: 0x18144A9D0
	|-Enumerable.<TakeIterator>d__25<Option>.System.IDisposable.Dispose
	|-Enumerable.<TakeIterator>d__25<InventoryItem>.System.IDisposable.Dispose
	|-Enumerable.<TakeIterator>d__25<byte>.System.IDisposable.Dispose
	|-Enumerable.<TakeIterator>d__25<double>.System.IDisposable.Dispose
	|-Enumerable.<TakeIterator>d__25<object>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D4E90 Offset: 0x19D3490 VA: 0x1819D4E90
	|-Enumerable.<TakeIterator>d__25<Option>.MoveNext
	|
	|-RVA: 0x19D53F0 Offset: 0x19D39F0 VA: 0x1819D53F0
	|-Enumerable.<TakeIterator>d__25<InventoryItem>.MoveNext
	|
	|-RVA: 0x19D5230 Offset: 0x19D3830 VA: 0x1819D5230
	|-Enumerable.<TakeIterator>d__25<byte>.MoveNext
	|
	|-RVA: 0x19D5070 Offset: 0x19D3670 VA: 0x1819D5070
	|-Enumerable.<TakeIterator>d__25<double>.MoveNext
	|
	|-RVA: 0x19D55D0 Offset: 0x19D3BD0 VA: 0x1819D55D0
	|-Enumerable.<TakeIterator>d__25<object>.MoveNext
	*/

	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D5B80 Offset: 0x19D4180 VA: 0x1819D5B80
	|-Enumerable.<TakeIterator>d__25<Option>.<>m__Finally1
	|
	|-RVA: 0x19D5C20 Offset: 0x19D4220 VA: 0x1819D5C20
	|-Enumerable.<TakeIterator>d__25<InventoryItem>.<>m__Finally1
	|
	|-RVA: 0x19D5B30 Offset: 0x19D4130 VA: 0x1819D5B30
	|-Enumerable.<TakeIterator>d__25<byte>.<>m__Finally1
	|
	|-RVA: 0x19D5C70 Offset: 0x19D4270 VA: 0x1819D5C70
	|-Enumerable.<TakeIterator>d__25<double>.<>m__Finally1
	|
	|-RVA: 0x19D5BD0 Offset: 0x19D41D0 VA: 0x1819D5BD0
	|-Enumerable.<TakeIterator>d__25<object>.<>m__Finally1
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176B410 Offset: 0x1769A10 VA: 0x18176B410
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
	|-RVA: 0x19D5A90 Offset: 0x19D4090 VA: 0x1819D5A90
	|-Enumerable.<TakeIterator>d__25<Option>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D5A40 Offset: 0x19D4040 VA: 0x1819D5A40
	|-Enumerable.<TakeIterator>d__25<InventoryItem>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D59F0 Offset: 0x19D3FF0 VA: 0x1819D59F0
	|-Enumerable.<TakeIterator>d__25<byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D59A0 Offset: 0x19D3FA0 VA: 0x1819D59A0
	|-Enumerable.<TakeIterator>d__25<double>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D5AE0 Offset: 0x19D40E0 VA: 0x1819D5AE0
	|-Enumerable.<TakeIterator>d__25<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176B900 Offset: 0x1769F00 VA: 0x18176B900
	|-Enumerable.<TakeIterator>d__25<Option>.System.Collections.IEnumerator.get_Current
	|-Enumerable.<TakeIterator>d__25<InventoryItem>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D4D50 Offset: 0x19D3350 VA: 0x1819D4D50
	|-Enumerable.<TakeIterator>d__25<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x176B820 Offset: 0x1769E20 VA: 0x18176B820
	|-Enumerable.<TakeIterator>d__25<double>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<TakeIterator>d__25<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D5840 Offset: 0x19D3E40 VA: 0x1819D5840
	|-Enumerable.<TakeIterator>d__25<Option>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|-Enumerable.<TakeIterator>d__25<InventoryItem>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x19D58F0 Offset: 0x19D3EF0 VA: 0x1819D58F0
	|-Enumerable.<TakeIterator>d__25<byte>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x19D5790 Offset: 0x19D3D90 VA: 0x1819D5790
	|-Enumerable.<TakeIterator>d__25<double>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|-Enumerable.<TakeIterator>d__25<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19B4680 Offset: 0x19B2C80 VA: 0x1819B4680
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
	|-RVA: 0x144AD10 Offset: 0x1449310 VA: 0x18144AD10
	|-Enumerable.<TakeWhileIterator>d__27<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A9D0 Offset: 0x1448FD0 VA: 0x18144A9D0
	|-Enumerable.<TakeWhileIterator>d__27<object>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D5D00 Offset: 0x19D4300 VA: 0x1819D5D00
	|-Enumerable.<TakeWhileIterator>d__27<object>.MoveNext
	*/

	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D5F40 Offset: 0x19D4540 VA: 0x1819D5F40
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
	|-RVA: 0x19D5EF0 Offset: 0x19D44F0 VA: 0x1819D5EF0
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
	|-RVA: 0x144B570 Offset: 0x1449B70 VA: 0x18144B570
	|-Enumerable.<TakeWhileIterator>d__27<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144B6F0 Offset: 0x1449CF0 VA: 0x18144B6F0
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
	|-RVA: 0x144AC90 Offset: 0x1449290 VA: 0x18144AC90
	|-Enumerable.<SkipIterator>d__31<byte>..ctor
	|
	|-RVA: 0x144AD10 Offset: 0x1449310 VA: 0x18144AD10
	|-Enumerable.<SkipIterator>d__31<double>..ctor
	|-Enumerable.<SkipIterator>d__31<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A9D0 Offset: 0x1448FD0 VA: 0x18144A9D0
	|-Enumerable.<SkipIterator>d__31<byte>.System.IDisposable.Dispose
	|-Enumerable.<SkipIterator>d__31<double>.System.IDisposable.Dispose
	|-Enumerable.<SkipIterator>d__31<object>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D48B0 Offset: 0x19D2EB0 VA: 0x1819D48B0
	|-Enumerable.<SkipIterator>d__31<byte>.MoveNext
	|
	|-RVA: 0x19D4660 Offset: 0x19D2C60 VA: 0x1819D4660
	|-Enumerable.<SkipIterator>d__31<double>.MoveNext
	|
	|-RVA: 0x19D4400 Offset: 0x19D2A00 VA: 0x1819D4400
	|-Enumerable.<SkipIterator>d__31<object>.MoveNext
	*/

	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D4E40 Offset: 0x19D3440 VA: 0x1819D4E40
	|-Enumerable.<SkipIterator>d__31<byte>.<>m__Finally1
	|
	|-RVA: 0x19D4DF0 Offset: 0x19D33F0 VA: 0x1819D4DF0
	|-Enumerable.<SkipIterator>d__31<double>.<>m__Finally1
	|
	|-RVA: 0x19D4DA0 Offset: 0x19D33A0 VA: 0x1819D4DA0
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
	|-RVA: 0x19D4C60 Offset: 0x19D3260 VA: 0x1819D4C60
	|-Enumerable.<SkipIterator>d__31<byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D4D00 Offset: 0x19D3300 VA: 0x1819D4D00
	|-Enumerable.<SkipIterator>d__31<double>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D4CB0 Offset: 0x19D32B0 VA: 0x1819D4CB0
	|-Enumerable.<SkipIterator>d__31<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D4D50 Offset: 0x19D3350 VA: 0x1819D4D50
	|-Enumerable.<SkipIterator>d__31<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x176B820 Offset: 0x1769E20 VA: 0x18176B820
	|-Enumerable.<SkipIterator>d__31<double>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<SkipIterator>d__31<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D4BB0 Offset: 0x19D31B0 VA: 0x1819D4BB0
	|-Enumerable.<SkipIterator>d__31<byte>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x19D4B00 Offset: 0x19D3100 VA: 0x1819D4B00
	|-Enumerable.<SkipIterator>d__31<double>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|-Enumerable.<SkipIterator>d__31<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19B4680 Offset: 0x19B2C80 VA: 0x1819B4680
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
	|-RVA: 0x144AC90 Offset: 0x1449290 VA: 0x18144AC90
	|-Enumerable.<ConcatIterator>d__59<byte>..ctor
	|
	|-RVA: 0x144AD10 Offset: 0x1449310 VA: 0x18144AD10
	|-Enumerable.<ConcatIterator>d__59<long>..ctor
	|-Enumerable.<ConcatIterator>d__59<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144B8B0 Offset: 0x1449EB0 VA: 0x18144B8B0
	|-Enumerable.<ConcatIterator>d__59<byte>.System.IDisposable.Dispose
	|-Enumerable.<ConcatIterator>d__59<long>.System.IDisposable.Dispose
	|-Enumerable.<ConcatIterator>d__59<object>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144AD50 Offset: 0x1449350 VA: 0x18144AD50
	|-Enumerable.<ConcatIterator>d__59<byte>.MoveNext
	|
	|-RVA: 0x144B2C0 Offset: 0x14498C0 VA: 0x18144B2C0
	|-Enumerable.<ConcatIterator>d__59<long>.MoveNext
	|
	|-RVA: 0x144B000 Offset: 0x1449600 VA: 0x18144B000
	|-Enumerable.<ConcatIterator>d__59<object>.MoveNext
	*/

	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144BA80 Offset: 0x144A080 VA: 0x18144BA80
	|-Enumerable.<ConcatIterator>d__59<byte>.<>m__Finally1
	|
	|-RVA: 0x144BA30 Offset: 0x144A030 VA: 0x18144BA30
	|-Enumerable.<ConcatIterator>d__59<long>.<>m__Finally1
	|
	|-RVA: 0x144B9E0 Offset: 0x1449FE0 VA: 0x18144B9E0
	|-Enumerable.<ConcatIterator>d__59<object>.<>m__Finally1
	*/

	private void <>m__Finally2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144BB20 Offset: 0x144A120 VA: 0x18144BB20
	|-Enumerable.<ConcatIterator>d__59<byte>.<>m__Finally2
	|
	|-RVA: 0x144BB70 Offset: 0x144A170 VA: 0x18144BB70
	|-Enumerable.<ConcatIterator>d__59<long>.<>m__Finally2
	|
	|-RVA: 0x144BAD0 Offset: 0x144A0D0 VA: 0x18144BAD0
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
	|-RVA: 0x144B720 Offset: 0x1449D20 VA: 0x18144B720
	|-Enumerable.<ConcatIterator>d__59<byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x144B7C0 Offset: 0x1449DC0 VA: 0x18144B7C0
	|-Enumerable.<ConcatIterator>d__59<long>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x144B770 Offset: 0x1449D70 VA: 0x18144B770
	|-Enumerable.<ConcatIterator>d__59<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144B810 Offset: 0x1449E10 VA: 0x18144B810
	|-Enumerable.<ConcatIterator>d__59<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x144B860 Offset: 0x1449E60 VA: 0x18144B860
	|-Enumerable.<ConcatIterator>d__59<long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<ConcatIterator>d__59<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144B630 Offset: 0x1449C30 VA: 0x18144B630
	|-Enumerable.<ConcatIterator>d__59<byte>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x144B570 Offset: 0x1449B70 VA: 0x18144B570
	|-Enumerable.<ConcatIterator>d__59<long>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|-Enumerable.<ConcatIterator>d__59<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144B6F0 Offset: 0x1449CF0 VA: 0x18144B6F0
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
	|-RVA: 0x144AD10 Offset: 0x1449310 VA: 0x18144AD10
	|-Enumerable.<ZipIterator>d__65<object, long, object>..ctor
	|-Enumerable.<ZipIterator>d__65<object, object, object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D4070 Offset: 0x19D2670 VA: 0x1819D4070
	|-Enumerable.<ZipIterator>d__65<object, long, object>.System.IDisposable.Dispose
	|-Enumerable.<ZipIterator>d__65<object, object, object>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D6D60 Offset: 0x19D5360 VA: 0x1819D6D60
	|-Enumerable.<ZipIterator>d__65<object, long, object>.MoveNext
	|
	|-RVA: 0x19D6A80 Offset: 0x19D5080 VA: 0x1819D6A80
	|-Enumerable.<ZipIterator>d__65<object, object, object>.MoveNext
	*/

	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D71B0 Offset: 0x19D57B0 VA: 0x1819D71B0
	|-Enumerable.<ZipIterator>d__65<object, long, object>.<>m__Finally1
	|
	|-RVA: 0x19D7200 Offset: 0x19D5800 VA: 0x1819D7200
	|-Enumerable.<ZipIterator>d__65<object, object, object>.<>m__Finally1
	*/

	private void <>m__Finally2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D7250 Offset: 0x19D5850 VA: 0x1819D7250
	|-Enumerable.<ZipIterator>d__65<object, long, object>.<>m__Finally2
	|
	|-RVA: 0x19D72A0 Offset: 0x19D58A0 VA: 0x1819D72A0
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
	|-RVA: 0x19D7110 Offset: 0x19D5710 VA: 0x1819D7110
	|-Enumerable.<ZipIterator>d__65<object, long, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D7160 Offset: 0x19D5760 VA: 0x1819D7160
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
	|-RVA: 0x19D7040 Offset: 0x19D5640 VA: 0x1819D7040
	|-Enumerable.<ZipIterator>d__65<object, long, object>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|-Enumerable.<ZipIterator>d__65<object, object, object>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D3E10 Offset: 0x19D2410 VA: 0x1819D3E10
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
	|-RVA: 0x19D1620 Offset: 0x19CFC20 VA: 0x1819D1620
	|-Enumerable.<DistinctIterator>d__68<ServerInfo>..ctor
	|
	|-RVA: 0x144AD10 Offset: 0x1449310 VA: 0x18144AD10
	|-Enumerable.<DistinctIterator>d__68<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A9D0 Offset: 0x1448FD0 VA: 0x18144A9D0
	|-Enumerable.<DistinctIterator>d__68<ServerInfo>.System.IDisposable.Dispose
	|-Enumerable.<DistinctIterator>d__68<object>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D0EC0 Offset: 0x19CF4C0 VA: 0x1819D0EC0
	|-Enumerable.<DistinctIterator>d__68<ServerInfo>.MoveNext
	|
	|-RVA: 0x19D0C70 Offset: 0x19CF270 VA: 0x1819D0C70
	|-Enumerable.<DistinctIterator>d__68<object>.MoveNext
	*/

	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D15D0 Offset: 0x19CFBD0 VA: 0x1819D15D0
	|-Enumerable.<DistinctIterator>d__68<ServerInfo>.<>m__Finally1
	|
	|-RVA: 0x19D1580 Offset: 0x19CFB80 VA: 0x1819D1580
	|-Enumerable.<DistinctIterator>d__68<object>.<>m__Finally1
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDECF60 Offset: 0xDEB560 VA: 0x180DECF60
	|-Enumerable.<DistinctIterator>d__68<ServerInfo>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<DistinctIterator>d__68<object>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D1450 Offset: 0x19CFA50 VA: 0x1819D1450
	|-Enumerable.<DistinctIterator>d__68<ServerInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D14A0 Offset: 0x19CFAA0 VA: 0x1819D14A0
	|-Enumerable.<DistinctIterator>d__68<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D14F0 Offset: 0x19CFAF0 VA: 0x1819D14F0
	|-Enumerable.<DistinctIterator>d__68<ServerInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<DistinctIterator>d__68<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D1290 Offset: 0x19CF890 VA: 0x1819D1290
	|-Enumerable.<DistinctIterator>d__68<ServerInfo>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x19D1360 Offset: 0x19CF960 VA: 0x1819D1360
	|-Enumerable.<DistinctIterator>d__68<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D1420 Offset: 0x19CFA20 VA: 0x1819D1420
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
	|-RVA: 0x144AC90 Offset: 0x1449290 VA: 0x18144AC90
	|-Enumerable.<UnionIterator>d__71<char>..ctor
	|
	|-RVA: 0x144AD10 Offset: 0x1449310 VA: 0x18144AD10
	|-Enumerable.<UnionIterator>d__71<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144B8B0 Offset: 0x1449EB0 VA: 0x18144B8B0
	|-Enumerable.<UnionIterator>d__71<char>.System.IDisposable.Dispose
	|-Enumerable.<UnionIterator>d__71<object>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D6330 Offset: 0x19D4930 VA: 0x1819D6330
	|-Enumerable.<UnionIterator>d__71<char>.MoveNext
	|
	|-RVA: 0x19D5F90 Offset: 0x19D4590 VA: 0x1819D5F90
	|-Enumerable.<UnionIterator>d__71<object>.MoveNext
	*/

	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D6940 Offset: 0x19D4F40 VA: 0x1819D6940
	|-Enumerable.<UnionIterator>d__71<char>.<>m__Finally1
	|
	|-RVA: 0x19D6990 Offset: 0x19D4F90 VA: 0x1819D6990
	|-Enumerable.<UnionIterator>d__71<object>.<>m__Finally1
	*/

	private void <>m__Finally2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D6A30 Offset: 0x19D5030 VA: 0x1819D6A30
	|-Enumerable.<UnionIterator>d__71<char>.<>m__Finally2
	|
	|-RVA: 0x19D69E0 Offset: 0x19D4FE0 VA: 0x1819D69E0
	|-Enumerable.<UnionIterator>d__71<object>.<>m__Finally2
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A680 Offset: 0x1448C80 VA: 0x18144A680
	|-Enumerable.<UnionIterator>d__71<char>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<UnionIterator>d__71<object>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D68A0 Offset: 0x19D4EA0 VA: 0x1819D68A0
	|-Enumerable.<UnionIterator>d__71<char>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D6850 Offset: 0x19D4E50 VA: 0x1819D6850
	|-Enumerable.<UnionIterator>d__71<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D68F0 Offset: 0x19D4EF0 VA: 0x1819D68F0
	|-Enumerable.<UnionIterator>d__71<char>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<UnionIterator>d__71<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D6780 Offset: 0x19D4D80 VA: 0x1819D6780
	|-Enumerable.<UnionIterator>d__71<char>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x19D66B0 Offset: 0x19D4CB0 VA: 0x1819D66B0
	|-Enumerable.<UnionIterator>d__71<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D3E10 Offset: 0x19D2410 VA: 0x1819D3E10
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
	|-RVA: 0x144AD10 Offset: 0x1449310 VA: 0x18144AD10
	|-Enumerable.<ExceptIterator>d__77<object>..ctor
	|
	|-RVA: 0x144AC90 Offset: 0x1449290 VA: 0x18144AC90
	|-Enumerable.<ExceptIterator>d__77<float>..ctor
	|
	|-RVA: 0x19D2920 Offset: 0x19D0F20 VA: 0x1819D2920
	|-Enumerable.<ExceptIterator>d__77<Vector2>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A9D0 Offset: 0x1448FD0 VA: 0x18144A9D0
	|-Enumerable.<ExceptIterator>d__77<object>.System.IDisposable.Dispose
	|-Enumerable.<ExceptIterator>d__77<float>.System.IDisposable.Dispose
	|-Enumerable.<ExceptIterator>d__77<Vector2>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D1B00 Offset: 0x19D0100 VA: 0x1819D1B00
	|-Enumerable.<ExceptIterator>d__77<object>.MoveNext
	|
	|-RVA: 0x19D1F90 Offset: 0x19D0590 VA: 0x1819D1F90
	|-Enumerable.<ExceptIterator>d__77<float>.MoveNext
	|
	|-RVA: 0x19D1660 Offset: 0x19CFC60 VA: 0x1819D1660
	|-Enumerable.<ExceptIterator>d__77<Vector2>.MoveNext
	*/

	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D28D0 Offset: 0x19D0ED0 VA: 0x1819D28D0
	|-Enumerable.<ExceptIterator>d__77<object>.<>m__Finally1
	|
	|-RVA: 0x19D2880 Offset: 0x19D0E80 VA: 0x1819D2880
	|-Enumerable.<ExceptIterator>d__77<float>.<>m__Finally1
	|
	|-RVA: 0x19D2830 Offset: 0x19D0E30 VA: 0x1819D2830
	|-Enumerable.<ExceptIterator>d__77<Vector2>.<>m__Finally1
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<ExceptIterator>d__77<object>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0xE73BC0 Offset: 0xE721C0 VA: 0x180E73BC0
	|-Enumerable.<ExceptIterator>d__77<float>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x19D2680 Offset: 0x19D0C80 VA: 0x1819D2680
	|-Enumerable.<ExceptIterator>d__77<Vector2>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D26F0 Offset: 0x19D0CF0 VA: 0x1819D26F0
	|-Enumerable.<ExceptIterator>d__77<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D2740 Offset: 0x19D0D40 VA: 0x1819D2740
	|-Enumerable.<ExceptIterator>d__77<float>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D26A0 Offset: 0x19D0CA0 VA: 0x1819D26A0
	|-Enumerable.<ExceptIterator>d__77<Vector2>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<ExceptIterator>d__77<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D2790 Offset: 0x19D0D90 VA: 0x1819D2790
	|-Enumerable.<ExceptIterator>d__77<float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D27E0 Offset: 0x19D0DE0 VA: 0x1819D27E0
	|-Enumerable.<ExceptIterator>d__77<Vector2>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D25B0 Offset: 0x19D0BB0 VA: 0x1819D25B0
	|-Enumerable.<ExceptIterator>d__77<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x19D24E0 Offset: 0x19D0AE0 VA: 0x1819D24E0
	|-Enumerable.<ExceptIterator>d__77<float>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x19D2410 Offset: 0x19D0A10 VA: 0x1819D2410
	|-Enumerable.<ExceptIterator>d__77<Vector2>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D1420 Offset: 0x19CFA20 VA: 0x1819D1420
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
	|-RVA: 0x144AC90 Offset: 0x1449290 VA: 0x18144AC90
	|-Enumerable.<ReverseIterator>d__79<char>..ctor
	|
	|-RVA: 0x144AD10 Offset: 0x1449310 VA: 0x18144AD10
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
	|-RVA: 0x19D2CC0 Offset: 0x19D12C0 VA: 0x1819D2CC0
	|-Enumerable.<ReverseIterator>d__79<char>.MoveNext
	|
	|-RVA: 0x19D2D80 Offset: 0x19D1380 VA: 0x1819D2D80
	|-Enumerable.<ReverseIterator>d__79<long>.MoveNext
	|
	|-RVA: 0x19D2C00 Offset: 0x19D1200 VA: 0x1819D2C00
	|-Enumerable.<ReverseIterator>d__79<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A680 Offset: 0x1448C80 VA: 0x18144A680
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
	|-RVA: 0x19D2EE0 Offset: 0x19D14E0 VA: 0x1819D2EE0
	|-Enumerable.<ReverseIterator>d__79<char>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D2E90 Offset: 0x19D1490 VA: 0x1819D2E90
	|-Enumerable.<ReverseIterator>d__79<long>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D2E40 Offset: 0x19D1440 VA: 0x1819D2E40
	|-Enumerable.<ReverseIterator>d__79<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D2F80 Offset: 0x19D1580 VA: 0x1819D2F80
	|-Enumerable.<ReverseIterator>d__79<char>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D2F30 Offset: 0x19D1530 VA: 0x1819D2F30
	|-Enumerable.<ReverseIterator>d__79<long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<ReverseIterator>d__79<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A5D0 Offset: 0x1448BD0 VA: 0x18144A5D0
	|-Enumerable.<ReverseIterator>d__79<char>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x144A520 Offset: 0x1448B20 VA: 0x18144A520
	|-Enumerable.<ReverseIterator>d__79<long>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|-Enumerable.<ReverseIterator>d__79<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A690 Offset: 0x1448C90 VA: 0x18144A690
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
	|-RVA: 0x144AD10 Offset: 0x1449310 VA: 0x18144AD10
	|-Enumerable.<OfTypeIterator>d__97<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A9D0 Offset: 0x1448FD0 VA: 0x18144A9D0
	|-Enumerable.<OfTypeIterator>d__97<object>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D2960 Offset: 0x19D0F60 VA: 0x1819D2960
	|-Enumerable.<OfTypeIterator>d__97<object>.MoveNext
	*/

	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D2BA0 Offset: 0x19D11A0 VA: 0x1819D2BA0
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
	|-RVA: 0x19D2B50 Offset: 0x19D1150 VA: 0x1819D2B50
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
	|-RVA: 0x144A520 Offset: 0x1448B20 VA: 0x18144A520
	|-Enumerable.<OfTypeIterator>d__97<object>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A690 Offset: 0x1448C90 VA: 0x18144A690
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
	|-RVA: 0x144AC90 Offset: 0x1449290 VA: 0x18144AC90
	|-Enumerable.<CastIterator>d__99<bool>..ctor
	|-Enumerable.<CastIterator>d__99<byte>..ctor
	|-Enumerable.<CastIterator>d__99<short>..ctor
	|-Enumerable.<CastIterator>d__99<int>..ctor
	|
	|-RVA: 0x144ACD0 Offset: 0x14492D0 VA: 0x18144ACD0
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>..ctor
	|
	|-RVA: 0x144AD10 Offset: 0x1449310 VA: 0x18144AD10
	|-Enumerable.<CastIterator>d__99<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A9D0 Offset: 0x1448FD0 VA: 0x18144A9D0
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
	|-RVA: 0x144A2B0 Offset: 0x14488B0 VA: 0x18144A2B0
	|-Enumerable.<CastIterator>d__99<bool>.MoveNext
	|
	|-RVA: 0x14499E0 Offset: 0x1447FE0 VA: 0x1814499E0
	|-Enumerable.<CastIterator>d__99<byte>.MoveNext
	|
	|-RVA: 0x1449BA0 Offset: 0x14481A0 VA: 0x181449BA0
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>.MoveNext
	|
	|-RVA: 0x144A0F0 Offset: 0x14486F0 VA: 0x18144A0F0
	|-Enumerable.<CastIterator>d__99<short>.MoveNext
	|
	|-RVA: 0x1449D70 Offset: 0x1448370 VA: 0x181449D70
	|-Enumerable.<CastIterator>d__99<int>.MoveNext
	|
	|-RVA: 0x1449F30 Offset: 0x1448530 VA: 0x181449F30
	|-Enumerable.<CastIterator>d__99<object>.MoveNext
	*/

	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144AC30 Offset: 0x1449230 VA: 0x18144AC30
	|-Enumerable.<CastIterator>d__99<bool>.<>m__Finally1
	|
	|-RVA: 0x144AA50 Offset: 0x1449050 VA: 0x18144AA50
	|-Enumerable.<CastIterator>d__99<byte>.<>m__Finally1
	|
	|-RVA: 0x144AB10 Offset: 0x1449110 VA: 0x18144AB10
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>.<>m__Finally1
	|
	|-RVA: 0x144ABD0 Offset: 0x14491D0 VA: 0x18144ABD0
	|-Enumerable.<CastIterator>d__99<short>.<>m__Finally1
	|
	|-RVA: 0x144AAB0 Offset: 0x14490B0 VA: 0x18144AAB0
	|-Enumerable.<CastIterator>d__99<int>.<>m__Finally1
	|
	|-RVA: 0x144AB70 Offset: 0x1449170 VA: 0x18144AB70
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
	|-RVA: 0x144A680 Offset: 0x1448C80 VA: 0x18144A680
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
	|-RVA: 0x144A760 Offset: 0x1448D60 VA: 0x18144A760
	|-Enumerable.<CastIterator>d__99<bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x144A800 Offset: 0x1448E00 VA: 0x18144A800
	|-Enumerable.<CastIterator>d__99<byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x144A6C0 Offset: 0x1448CC0 VA: 0x18144A6C0
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x144A7B0 Offset: 0x1448DB0 VA: 0x18144A7B0
	|-Enumerable.<CastIterator>d__99<short>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x144A710 Offset: 0x1448D10 VA: 0x18144A710
	|-Enumerable.<CastIterator>d__99<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x144A850 Offset: 0x1448E50 VA: 0x18144A850
	|-Enumerable.<CastIterator>d__99<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A8A0 Offset: 0x1448EA0 VA: 0x18144A8A0
	|-Enumerable.<CastIterator>d__99<bool>.System.Collections.IEnumerator.get_Current
	|-Enumerable.<CastIterator>d__99<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x144A940 Offset: 0x1448F40 VA: 0x18144A940
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x144A8F0 Offset: 0x1448EF0 VA: 0x18144A8F0
	|-Enumerable.<CastIterator>d__99<short>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x144A990 Offset: 0x1448F90 VA: 0x18144A990
	|-Enumerable.<CastIterator>d__99<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<CastIterator>d__99<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A5D0 Offset: 0x1448BD0 VA: 0x18144A5D0
	|-Enumerable.<CastIterator>d__99<bool>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|-Enumerable.<CastIterator>d__99<byte>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|-Enumerable.<CastIterator>d__99<short>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|-Enumerable.<CastIterator>d__99<int>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0x144A470 Offset: 0x1448A70 VA: 0x18144A470
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0x144A520 Offset: 0x1448B20 VA: 0x18144A520
	|-Enumerable.<CastIterator>d__99<object>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A690 Offset: 0x1448C90 VA: 0x18144A690
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
	|-RVA: 0x178F450 Offset: 0x178DA50 VA: 0x18178F450
	|-EnumerableSorter<Demos.DemoInfo>.Sort
	|
	|-RVA: 0x178F530 Offset: 0x178DB30 VA: 0x18178F530
	|-EnumerableSorter<ServerInfo>.Sort
	|
	|-RVA: 0x178FB50 Offset: 0x178E150 VA: 0x18178FB50
	|-EnumerableSorter<Item>.Sort
	|
	|-RVA: 0x178FA70 Offset: 0x178E070 VA: 0x18178FA70
	|-EnumerableSorter<KeyValuePair<object, int>>.Sort
	|
	|-RVA: 0x178F610 Offset: 0x178DC10 VA: 0x18178F610
	|-EnumerableSorter<KeyValuePair<object, long>>.Sort
	|
	|-RVA: 0x178F990 Offset: 0x178DF90 VA: 0x18178F990
	|-EnumerableSorter<KeyValuePair<object, object>>.Sort
	|
	|-RVA: 0x178F6F0 Offset: 0x178DCF0 VA: 0x18178F6F0
	|-EnumerableSorter<double>.Sort
	|
	|-RVA: 0x178F7D0 Offset: 0x178DDD0 VA: 0x18178F7D0
	|-EnumerableSorter<object>.Sort
	|
	|-RVA: 0x178F8B0 Offset: 0x178DEB0 VA: 0x18178F8B0
	|-EnumerableSorter<Resolution>.Sort
	*/

	private void QuickSort(int[] map, int left, int right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178F230 Offset: 0x178D830 VA: 0x18178F230
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
	|-RVA: 0x175ED10 Offset: 0x175D310 VA: 0x18175ED10
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
	|-RVA: 0x178FD40 Offset: 0x178E340 VA: 0x18178FD40
	|-EnumerableSorter<Demos.DemoInfo, DateTime>.ComputeKeys
	|-EnumerableSorter<Demos.DemoInfo, TimeSpan>.ComputeKeys
	|
	|-RVA: 0x178FE90 Offset: 0x178E490 VA: 0x18178FE90
	|-EnumerableSorter<Demos.DemoInfo, object>.ComputeKeys
	|
	|-RVA: 0x17903A0 Offset: 0x178E9A0 VA: 0x1817903A0
	|-EnumerableSorter<ServerInfo, int>.ComputeKeys
	|-EnumerableSorter<ServerInfo, uint>.ComputeKeys
	|
	|-RVA: 0x178FFF0 Offset: 0x178E5F0 VA: 0x18178FFF0
	|-EnumerableSorter<ServerInfo, object>.ComputeKeys
	|
	|-RVA: 0x17901B0 Offset: 0x178E7B0 VA: 0x1817901B0
	|-EnumerableSorter<Item, DateTime>.ComputeKeys
	|
	|-RVA: 0x175E3B0 Offset: 0x175C9B0 VA: 0x18175E3B0
	|-EnumerableSorter<KeyValuePair<object, int>, int>.ComputeKeys
	|
	|-RVA: 0x175E860 Offset: 0x175CE60 VA: 0x18175E860
	|-EnumerableSorter<KeyValuePair<object, long>, long>.ComputeKeys
	|-EnumerableSorter<KeyValuePair<object, object>, long>.ComputeKeys
	|
	|-RVA: 0x175E740 Offset: 0x175CD40 VA: 0x18175E740
	|-EnumerableSorter<double, double>.ComputeKeys
	|
	|-RVA: 0x175EAD0 Offset: 0x175D0D0 VA: 0x18175EAD0
	|-EnumerableSorter<object, bool>.ComputeKeys
	|
	|-RVA: 0x175EBF0 Offset: 0x175D1F0 VA: 0x18175EBF0
	|-EnumerableSorter<object, DateTime>.ComputeKeys
	|
	|-RVA: 0x175E160 Offset: 0x175C760 VA: 0x18175E160
	|-EnumerableSorter<object, DateTimeOffset>.ComputeKeys
	|-EnumerableSorter<object, Guid>.ComputeKeys
	|
	|-RVA: 0x175E4E0 Offset: 0x175CAE0 VA: 0x18175E4E0
	|-EnumerableSorter<object, int>.ComputeKeys
	|-EnumerableSorter<object, Int32Enum>.ComputeKeys
	|-EnumerableSorter<object, uint>.ComputeKeys
	|
	|-RVA: 0x175E9A0 Offset: 0x175CFA0 VA: 0x18175E9A0
	|-EnumerableSorter<object, object>.ComputeKeys
	|
	|-RVA: 0x175E290 Offset: 0x175C890 VA: 0x18175E290
	|-EnumerableSorter<object, float>.ComputeKeys
	|
	|-RVA: 0x175E600 Offset: 0x175CC00 VA: 0x18175E600
	|-EnumerableSorter<Resolution, int>.ComputeKeys
	*/

	internal override int CompareKeys(int index1, int index2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178FC30 Offset: 0x178E230 VA: 0x18178FC30
	|-EnumerableSorter<Demos.DemoInfo, DateTime>.CompareKeys
	|-EnumerableSorter<Item, DateTime>.CompareKeys
	|
	|-RVA: 0x175D7E0 Offset: 0x175BDE0 VA: 0x18175D7E0
	|-EnumerableSorter<Demos.DemoInfo, object>.CompareKeys
	|-EnumerableSorter<ServerInfo, object>.CompareKeys
	|-EnumerableSorter<KeyValuePair<object, long>, long>.CompareKeys
	|-EnumerableSorter<KeyValuePair<object, object>, long>.CompareKeys
	|
	|-RVA: 0x175DD10 Offset: 0x175C310 VA: 0x18175DD10
	|-EnumerableSorter<Demos.DemoInfo, TimeSpan>.CompareKeys
	|-EnumerableSorter<object, DateTime>.CompareKeys
	|
	|-RVA: 0x175DE80 Offset: 0x175C480 VA: 0x18175DE80
	|-EnumerableSorter<ServerInfo, int>.CompareKeys
	|-EnumerableSorter<ServerInfo, uint>.CompareKeys
	|-EnumerableSorter<object, uint>.CompareKeys
	|
	|-RVA: 0x175DA80 Offset: 0x175C080 VA: 0x18175DA80
	|-EnumerableSorter<KeyValuePair<object, int>, int>.CompareKeys
	|-EnumerableSorter<object, int>.CompareKeys
	|-EnumerableSorter<object, Int32Enum>.CompareKeys
	|-EnumerableSorter<Resolution, int>.CompareKeys
	|
	|-RVA: 0x175DB90 Offset: 0x175C190 VA: 0x18175DB90
	|-EnumerableSorter<double, double>.CompareKeys
	|
	|-RVA: 0x175D670 Offset: 0x175BC70 VA: 0x18175D670
	|-EnumerableSorter<object, bool>.CompareKeys
	|
	|-RVA: 0x175D8F0 Offset: 0x175BEF0 VA: 0x18175D8F0
	|-EnumerableSorter<object, DateTimeOffset>.CompareKeys
	|-EnumerableSorter<object, Guid>.CompareKeys
	|
	|-RVA: 0x175D510 Offset: 0x175BB10 VA: 0x18175D510
	|-EnumerableSorter<object, object>.CompareKeys
	|
	|-RVA: 0x175DFE0 Offset: 0x175C5E0 VA: 0x18175DFE0
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

