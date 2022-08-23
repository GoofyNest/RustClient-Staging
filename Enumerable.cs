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
	|-RVA: 0xBEF570 Offset: 0xBEDB70 VA: 0x180BEF570
	|-Enum.TryParse<Int32Enum>
	|-Enum.TryParse<KeyCode>
	*/

	public static bool TryParse<TEnum>(string value, bool ignoreCase, out TEnum result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEF5F0 Offset: 0xBEDBF0 VA: 0x180BEF5F0
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
	|-RVA: 0x1A373A0 Offset: 0x1A359A0 VA: 0x181A373A0
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
	|-RVA: 0x1A37470 Offset: 0x1A35A70 VA: 0x181A37470
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
	|-RVA: 0x1A37540 Offset: 0x1A35B40 VA: 0x181A37540
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
	|-RVA: 0x1A37610 Offset: 0x1A35C10 VA: 0x181A37610
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
	|-RVA: 0x1A377B0 Offset: 0x1A35DB0 VA: 0x181A377B0
	|-EnumHelper<byte>.Cast<EmptyStruct>
	|-EnumHelper<short>.Cast<EmptyStruct>
	|-EnumHelper<int>.Cast<EmptyStruct>
	|-EnumHelper<long>.Cast<EmptyStruct>
	|-EnumHelper<sbyte>.Cast<EmptyStruct>
	|-EnumHelper<ushort>.Cast<EmptyStruct>
	|-EnumHelper<uint>.Cast<EmptyStruct>
	|-EnumHelper<ulong>.Cast<EmptyStruct>
	|
	|-RVA: 0x1A376E0 Offset: 0x1A35CE0 VA: 0x181A376E0
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
	|-RVA: 0x1A37880 Offset: 0x1A35E80 VA: 0x181A37880
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
	|-RVA: 0x1A37950 Offset: 0x1A35F50 VA: 0x181A37950
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
	|-RVA: 0x2133D90 Offset: 0x2132390 VA: 0x182133D90
	|-EnumHelper<byte>..cctor
	|
	|-RVA: 0x2133890 Offset: 0x2131E90 VA: 0x182133890
	|-EnumHelper<short>..cctor
	|
	|-RVA: 0x2133990 Offset: 0x2131F90 VA: 0x182133990
	|-EnumHelper<int>..cctor
	|
	|-RVA: 0x2133A90 Offset: 0x2132090 VA: 0x182133A90
	|-EnumHelper<long>..cctor
	|
	|-RVA: 0x2133B90 Offset: 0x2132190 VA: 0x182133B90
	|-EnumHelper<object>..cctor
	|
	|-RVA: 0x2133F90 Offset: 0x2132590 VA: 0x182133F90
	|-EnumHelper<sbyte>..cctor
	|
	|-RVA: 0x2133E90 Offset: 0x2132490 VA: 0x182133E90
	|-EnumHelper<ushort>..cctor
	|
	|-RVA: 0x2133790 Offset: 0x2131D90 VA: 0x182133790
	|-EnumHelper<uint>..cctor
	|
	|-RVA: 0x2133C90 Offset: 0x2132290 VA: 0x182133C90
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
	|-RVA: 0x18A32F0 Offset: 0x18A18F0 VA: 0x1818A32F0
	|-EnumHelper.Transformer<byte, bool>.Invoke
	|-EnumHelper.Transformer<byte, byte>.Invoke
	|-EnumHelper.Transformer<byte, sbyte>.Invoke
	|-EnumHelper.Transformer<sbyte, bool>.Invoke
	|-EnumHelper.Transformer<sbyte, byte>.Invoke
	|-EnumHelper.Transformer<sbyte, sbyte>.Invoke
	|
	|-RVA: 0x18A5C30 Offset: 0x18A4230 VA: 0x1818A5C30
	|-EnumHelper.Transformer<byte, char>.Invoke
	|-EnumHelper.Transformer<byte, short>.Invoke
	|-EnumHelper.Transformer<byte, ushort>.Invoke
	|-EnumHelper.Transformer<sbyte, char>.Invoke
	|-EnumHelper.Transformer<sbyte, short>.Invoke
	|-EnumHelper.Transformer<sbyte, ushort>.Invoke
	|
	|-RVA: 0x16D04A0 Offset: 0x16CEAA0 VA: 0x1816D04A0
	|-EnumHelper.Transformer<byte, KeyValuePair<object, object>>.Invoke
	|-EnumHelper.Transformer<byte, DateTimeOffset>.Invoke
	|-EnumHelper.Transformer<byte, Decimal>.Invoke
	|-EnumHelper.Transformer<byte, Guid>.Invoke
	|-EnumHelper.Transformer<sbyte, KeyValuePair<object, object>>.Invoke
	|-EnumHelper.Transformer<sbyte, DateTimeOffset>.Invoke
	|-EnumHelper.Transformer<sbyte, Decimal>.Invoke
	|-EnumHelper.Transformer<sbyte, Guid>.Invoke
	|
	|-RVA: 0x16D07E0 Offset: 0x16CEDE0 VA: 0x1816D07E0
	|-EnumHelper.Transformer<byte, DateTime>.Invoke
	|-EnumHelper.Transformer<byte, TimeSpan>.Invoke
	|-EnumHelper.Transformer<sbyte, DateTime>.Invoke
	|-EnumHelper.Transformer<sbyte, TimeSpan>.Invoke
	|
	|-RVA: 0x18A7BB0 Offset: 0x18A61B0 VA: 0x1818A7BB0
	|-EnumHelper.Transformer<byte, EmptyStruct>.Invoke
	|-EnumHelper.Transformer<sbyte, EmptyStruct>.Invoke
	|
	|-RVA: 0x18A6770 Offset: 0x18A4D70 VA: 0x1818A6770
	|-EnumHelper.Transformer<byte, double>.Invoke
	|-EnumHelper.Transformer<sbyte, double>.Invoke
	|
	|-RVA: 0x146D2D0 Offset: 0x146B8D0 VA: 0x18146D2D0
	|-EnumHelper.Transformer<byte, int>.Invoke
	|-EnumHelper.Transformer<byte, uint>.Invoke
	|-EnumHelper.Transformer<sbyte, int>.Invoke
	|-EnumHelper.Transformer<sbyte, uint>.Invoke
	|
	|-RVA: 0x1B17100 Offset: 0x1B15700 VA: 0x181B17100
	|-EnumHelper.Transformer<byte, long>.Invoke
	|-EnumHelper.Transformer<byte, IntPtr>.Invoke
	|-EnumHelper.Transformer<byte, ulong>.Invoke
	|-EnumHelper.Transformer<byte, UIntPtr>.Invoke
	|-EnumHelper.Transformer<sbyte, long>.Invoke
	|-EnumHelper.Transformer<sbyte, IntPtr>.Invoke
	|-EnumHelper.Transformer<sbyte, ulong>.Invoke
	|-EnumHelper.Transformer<sbyte, UIntPtr>.Invoke
	|
	|-RVA: 0x1783F60 Offset: 0x1782560 VA: 0x181783F60
	|-EnumHelper.Transformer<byte, object>.Invoke
	|-EnumHelper.Transformer<sbyte, object>.Invoke
	|
	|-RVA: 0x18A42B0 Offset: 0x18A28B0 VA: 0x1818A42B0
	|-EnumHelper.Transformer<byte, float>.Invoke
	|-EnumHelper.Transformer<sbyte, float>.Invoke
	|
	|-RVA: 0x1B178F0 Offset: 0x1B15EF0 VA: 0x181B178F0
	|-EnumHelper.Transformer<short, bool>.Invoke
	|-EnumHelper.Transformer<short, byte>.Invoke
	|-EnumHelper.Transformer<short, sbyte>.Invoke
	|-EnumHelper.Transformer<ushort, bool>.Invoke
	|-EnumHelper.Transformer<ushort, byte>.Invoke
	|-EnumHelper.Transformer<ushort, sbyte>.Invoke
	|
	|-RVA: 0x1B19800 Offset: 0x1B17E00 VA: 0x181B19800
	|-EnumHelper.Transformer<short, char>.Invoke
	|-EnumHelper.Transformer<short, short>.Invoke
	|-EnumHelper.Transformer<short, ushort>.Invoke
	|-EnumHelper.Transformer<ushort, char>.Invoke
	|-EnumHelper.Transformer<ushort, short>.Invoke
	|-EnumHelper.Transformer<ushort, ushort>.Invoke
	|
	|-RVA: 0x1B18EC0 Offset: 0x1B174C0 VA: 0x181B18EC0
	|-EnumHelper.Transformer<short, KeyValuePair<object, object>>.Invoke
	|-EnumHelper.Transformer<short, DateTimeOffset>.Invoke
	|-EnumHelper.Transformer<short, Decimal>.Invoke
	|-EnumHelper.Transformer<short, Guid>.Invoke
	|-EnumHelper.Transformer<ushort, KeyValuePair<object, object>>.Invoke
	|-EnumHelper.Transformer<ushort, DateTimeOffset>.Invoke
	|-EnumHelper.Transformer<ushort, Decimal>.Invoke
	|-EnumHelper.Transformer<ushort, Guid>.Invoke
	|
	|-RVA: 0x1B19200 Offset: 0x1B17800 VA: 0x181B19200
	|-EnumHelper.Transformer<short, DateTime>.Invoke
	|-EnumHelper.Transformer<short, TimeSpan>.Invoke
	|-EnumHelper.Transformer<ushort, DateTime>.Invoke
	|-EnumHelper.Transformer<ushort, TimeSpan>.Invoke
	|
	|-RVA: 0x1B1A110 Offset: 0x1B18710 VA: 0x181B1A110
	|-EnumHelper.Transformer<short, EmptyStruct>.Invoke
	|-EnumHelper.Transformer<ushort, EmptyStruct>.Invoke
	|
	|-RVA: 0x1B16BF0 Offset: 0x1B151F0 VA: 0x181B16BF0
	|-EnumHelper.Transformer<short, double>.Invoke
	|-EnumHelper.Transformer<ushort, double>.Invoke
	|
	|-RVA: 0x1B16140 Offset: 0x1B14740 VA: 0x181B16140
	|-EnumHelper.Transformer<short, int>.Invoke
	|-EnumHelper.Transformer<short, uint>.Invoke
	|-EnumHelper.Transformer<ushort, int>.Invoke
	|-EnumHelper.Transformer<ushort, uint>.Invoke
	|
	|-RVA: 0x1B17F30 Offset: 0x1B16530 VA: 0x181B17F30
	|-EnumHelper.Transformer<short, long>.Invoke
	|-EnumHelper.Transformer<short, IntPtr>.Invoke
	|-EnumHelper.Transformer<short, ulong>.Invoke
	|-EnumHelper.Transformer<short, UIntPtr>.Invoke
	|-EnumHelper.Transformer<ushort, long>.Invoke
	|-EnumHelper.Transformer<ushort, IntPtr>.Invoke
	|-EnumHelper.Transformer<ushort, ulong>.Invoke
	|-EnumHelper.Transformer<ushort, UIntPtr>.Invoke
	|
	|-RVA: 0x1B18730 Offset: 0x1B16D30 VA: 0x181B18730
	|-EnumHelper.Transformer<short, object>.Invoke
	|-EnumHelper.Transformer<ushort, object>.Invoke
	|
	|-RVA: 0x1B1A410 Offset: 0x1B18A10 VA: 0x181B1A410
	|-EnumHelper.Transformer<short, float>.Invoke
	|-EnumHelper.Transformer<ushort, float>.Invoke
	|
	|-RVA: 0x1B18BC0 Offset: 0x1B171C0 VA: 0x181B18BC0
	|-EnumHelper.Transformer<int, bool>.Invoke
	|-EnumHelper.Transformer<int, byte>.Invoke
	|-EnumHelper.Transformer<int, sbyte>.Invoke
	|-EnumHelper.Transformer<uint, bool>.Invoke
	|-EnumHelper.Transformer<uint, byte>.Invoke
	|-EnumHelper.Transformer<uint, sbyte>.Invoke
	|
	|-RVA: 0x1B18430 Offset: 0x1B16A30 VA: 0x181B18430
	|-EnumHelper.Transformer<int, char>.Invoke
	|-EnumHelper.Transformer<int, short>.Invoke
	|-EnumHelper.Transformer<int, ushort>.Invoke
	|-EnumHelper.Transformer<uint, char>.Invoke
	|-EnumHelper.Transformer<uint, short>.Invoke
	|-EnumHelper.Transformer<uint, ushort>.Invoke
	|
	|-RVA: 0x1B17BF0 Offset: 0x1B161F0 VA: 0x181B17BF0
	|-EnumHelper.Transformer<int, KeyValuePair<object, object>>.Invoke
	|-EnumHelper.Transformer<int, DateTimeOffset>.Invoke
	|-EnumHelper.Transformer<int, Decimal>.Invoke
	|-EnumHelper.Transformer<int, Guid>.Invoke
	|-EnumHelper.Transformer<uint, KeyValuePair<object, object>>.Invoke
	|-EnumHelper.Transformer<uint, DateTimeOffset>.Invoke
	|-EnumHelper.Transformer<uint, Decimal>.Invoke
	|-EnumHelper.Transformer<uint, Guid>.Invoke
	|
	|-RVA: 0x1B19500 Offset: 0x1B17B00 VA: 0x181B19500
	|-EnumHelper.Transformer<int, DateTime>.Invoke
	|-EnumHelper.Transformer<int, TimeSpan>.Invoke
	|-EnumHelper.Transformer<uint, DateTime>.Invoke
	|-EnumHelper.Transformer<uint, TimeSpan>.Invoke
	|
	|-RVA: 0x1B19B00 Offset: 0x1B18100 VA: 0x181B19B00
	|-EnumHelper.Transformer<int, EmptyStruct>.Invoke
	|-EnumHelper.Transformer<uint, EmptyStruct>.Invoke
	|
	|-RVA: 0x1B19E00 Offset: 0x1B18400 VA: 0x181B19E00
	|-EnumHelper.Transformer<int, double>.Invoke
	|-EnumHelper.Transformer<uint, double>.Invoke
	|
	|-RVA: 0x19E7F40 Offset: 0x19E6540 VA: 0x1819E7F40
	|-EnumHelper.Transformer<int, int>.Invoke
	|-EnumHelper.Transformer<int, uint>.Invoke
	|-EnumHelper.Transformer<uint, int>.Invoke
	|-EnumHelper.Transformer<uint, uint>.Invoke
	|
	|-RVA: 0x1B16F00 Offset: 0x1B15500 VA: 0x181B16F00
	|-EnumHelper.Transformer<int, long>.Invoke
	|-EnumHelper.Transformer<int, IntPtr>.Invoke
	|-EnumHelper.Transformer<int, ulong>.Invoke
	|-EnumHelper.Transformer<int, UIntPtr>.Invoke
	|-EnumHelper.Transformer<uint, long>.Invoke
	|-EnumHelper.Transformer<uint, IntPtr>.Invoke
	|-EnumHelper.Transformer<uint, ulong>.Invoke
	|-EnumHelper.Transformer<uint, UIntPtr>.Invoke
	|
	|-RVA: 0x1B16770 Offset: 0x1B14D70 VA: 0x181B16770
	|-EnumHelper.Transformer<int, object>.Invoke
	|-EnumHelper.Transformer<uint, object>.Invoke
	|
	|-RVA: 0x1B17600 Offset: 0x1B15C00 VA: 0x181B17600
	|-EnumHelper.Transformer<int, float>.Invoke
	|-EnumHelper.Transformer<uint, float>.Invoke
	|
	|-RVA: 0x1B18130 Offset: 0x1B16730 VA: 0x181B18130
	|-EnumHelper.Transformer<long, bool>.Invoke
	|-EnumHelper.Transformer<long, byte>.Invoke
	|-EnumHelper.Transformer<long, sbyte>.Invoke
	|-EnumHelper.Transformer<ulong, bool>.Invoke
	|-EnumHelper.Transformer<ulong, byte>.Invoke
	|-EnumHelper.Transformer<ulong, sbyte>.Invoke
	|
	|-RVA: 0x1B17300 Offset: 0x1B15900 VA: 0x181B17300
	|-EnumHelper.Transformer<long, char>.Invoke
	|-EnumHelper.Transformer<long, short>.Invoke
	|-EnumHelper.Transformer<long, ushort>.Invoke
	|-EnumHelper.Transformer<ulong, char>.Invoke
	|-EnumHelper.Transformer<ulong, short>.Invoke
	|-EnumHelper.Transformer<ulong, ushort>.Invoke
	|
	|-RVA: 0x1B16430 Offset: 0x1B14A30 VA: 0x181B16430
	|-EnumHelper.Transformer<long, KeyValuePair<object, object>>.Invoke
	|-EnumHelper.Transformer<long, DateTimeOffset>.Invoke
	|-EnumHelper.Transformer<long, Decimal>.Invoke
	|-EnumHelper.Transformer<long, Guid>.Invoke
	|-EnumHelper.Transformer<ulong, KeyValuePair<object, object>>.Invoke
	|-EnumHelper.Transformer<ulong, DateTimeOffset>.Invoke
	|-EnumHelper.Transformer<ulong, Decimal>.Invoke
	|-EnumHelper.Transformer<ulong, Guid>.Invoke
	|
	|-RVA: 0x19EA910 Offset: 0x19E8F10 VA: 0x1819EA910
	|-EnumHelper.Transformer<long, DateTime>.Invoke
	|-EnumHelper.Transformer<long, TimeSpan>.Invoke
	|-EnumHelper.Transformer<ulong, DateTime>.Invoke
	|-EnumHelper.Transformer<ulong, TimeSpan>.Invoke
	|
	|-RVA: 0x1B96360 Offset: 0x1B94960 VA: 0x181B96360
	|-EnumHelper.Transformer<long, EmptyStruct>.Invoke
	|-EnumHelper.Transformer<ulong, EmptyStruct>.Invoke
	|
	|-RVA: 0x20C8550 Offset: 0x20C6B50 VA: 0x1820C8550
	|-EnumHelper.Transformer<long, double>.Invoke
	|-EnumHelper.Transformer<ulong, double>.Invoke
	|
	|-RVA: 0x20C8260 Offset: 0x20C6860 VA: 0x1820C8260
	|-EnumHelper.Transformer<long, int>.Invoke
	|-EnumHelper.Transformer<long, uint>.Invoke
	|-EnumHelper.Transformer<ulong, int>.Invoke
	|-EnumHelper.Transformer<ulong, uint>.Invoke
	|
	|-RVA: 0x20C8860 Offset: 0x20C6E60 VA: 0x1820C8860
	|-EnumHelper.Transformer<long, long>.Invoke
	|-EnumHelper.Transformer<long, IntPtr>.Invoke
	|-EnumHelper.Transformer<long, ulong>.Invoke
	|-EnumHelper.Transformer<long, UIntPtr>.Invoke
	|-EnumHelper.Transformer<ulong, long>.Invoke
	|-EnumHelper.Transformer<ulong, IntPtr>.Invoke
	|-EnumHelper.Transformer<ulong, ulong>.Invoke
	|-EnumHelper.Transformer<ulong, UIntPtr>.Invoke
	|
	|-RVA: 0x133AAA0 Offset: 0x13390A0 VA: 0x18133AAA0
	|-EnumHelper.Transformer<long, object>.Invoke
	|-EnumHelper.Transformer<object, object>.Invoke
	|-EnumHelper.Transformer<ulong, object>.Invoke
	|
	|-RVA: 0x20C8A60 Offset: 0x20C7060 VA: 0x1820C8A60
	|-EnumHelper.Transformer<long, float>.Invoke
	|-EnumHelper.Transformer<ulong, float>.Invoke
	*/

	public virtual IAsyncResult BeginInvoke(ValueType value, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B14E40 Offset: 0x1B13440 VA: 0x181B14E40
	|-EnumHelper.Transformer<byte, bool>.BeginInvoke
	|
	|-RVA: 0x1B14040 Offset: 0x1B12640 VA: 0x181B14040
	|-EnumHelper.Transformer<byte, byte>.BeginInvoke
	|
	|-RVA: 0x1B15540 Offset: 0x1B13B40 VA: 0x181B15540
	|-EnumHelper.Transformer<byte, char>.BeginInvoke
	|
	|-RVA: 0x1B15EC0 Offset: 0x1B144C0 VA: 0x181B15EC0
	|-EnumHelper.Transformer<byte, KeyValuePair<object, object>>.BeginInvoke
	|
	|-RVA: 0x1B16040 Offset: 0x1B14640 VA: 0x181B16040
	|-EnumHelper.Transformer<byte, DateTime>.BeginInvoke
	|
	|-RVA: 0x1B15FC0 Offset: 0x1B145C0 VA: 0x181B15FC0
	|-EnumHelper.Transformer<byte, DateTimeOffset>.BeginInvoke
	|
	|-RVA: 0x1B15AC0 Offset: 0x1B140C0 VA: 0x181B15AC0
	|-EnumHelper.Transformer<byte, Decimal>.BeginInvoke
	|
	|-RVA: 0x1B15040 Offset: 0x1B13640 VA: 0x181B15040
	|-EnumHelper.Transformer<byte, EmptyStruct>.BeginInvoke
	|
	|-RVA: 0x1B15BC0 Offset: 0x1B141C0 VA: 0x181B15BC0
	|-EnumHelper.Transformer<byte, double>.BeginInvoke
	|
	|-RVA: 0x1B147C0 Offset: 0x1B12DC0 VA: 0x181B147C0
	|-EnumHelper.Transformer<byte, Guid>.BeginInvoke
	|
	|-RVA: 0x1B157C0 Offset: 0x1B13DC0 VA: 0x181B157C0
	|-EnumHelper.Transformer<byte, short>.BeginInvoke
	|
	|-RVA: 0x1B148C0 Offset: 0x1B12EC0 VA: 0x181B148C0
	|-EnumHelper.Transformer<byte, int>.BeginInvoke
	|
	|-RVA: 0x1B15CC0 Offset: 0x1B142C0 VA: 0x181B15CC0
	|-EnumHelper.Transformer<byte, long>.BeginInvoke
	|
	|-RVA: 0x1B14BC0 Offset: 0x1B131C0 VA: 0x181B14BC0
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
	|-RVA: 0x1B158C0 Offset: 0x1B13EC0 VA: 0x181B158C0
	|-EnumHelper.Transformer<byte, sbyte>.BeginInvoke
	|
	|-RVA: 0x1B15340 Offset: 0x1B13940 VA: 0x181B15340
	|-EnumHelper.Transformer<byte, float>.BeginInvoke
	|
	|-RVA: 0x1B15DC0 Offset: 0x1B143C0 VA: 0x181B15DC0
	|-EnumHelper.Transformer<byte, TimeSpan>.BeginInvoke
	|
	|-RVA: 0x1B141C0 Offset: 0x1B127C0 VA: 0x181B141C0
	|-EnumHelper.Transformer<byte, ushort>.BeginInvoke
	|
	|-RVA: 0x1B15940 Offset: 0x1B13F40 VA: 0x181B15940
	|-EnumHelper.Transformer<byte, uint>.BeginInvoke
	|
	|-RVA: 0x1B149C0 Offset: 0x1B12FC0 VA: 0x181B149C0
	|-EnumHelper.Transformer<byte, ulong>.BeginInvoke
	|
	|-RVA: 0x1B13EC0 Offset: 0x1B124C0 VA: 0x181B13EC0
	|-EnumHelper.Transformer<byte, UIntPtr>.BeginInvoke
	|
	|-RVA: 0x1B155C0 Offset: 0x1B13BC0 VA: 0x181B155C0
	|-EnumHelper.Transformer<short, bool>.BeginInvoke
	|
	|-RVA: 0x1B153C0 Offset: 0x1B139C0 VA: 0x181B153C0
	|-EnumHelper.Transformer<short, byte>.BeginInvoke
	|
	|-RVA: 0x1B14640 Offset: 0x1B12C40 VA: 0x181B14640
	|-EnumHelper.Transformer<short, char>.BeginInvoke
	|
	|-RVA: 0x1B142C0 Offset: 0x1B128C0 VA: 0x181B142C0
	|-EnumHelper.Transformer<short, KeyValuePair<object, object>>.BeginInvoke
	|
	|-RVA: 0x1B13E40 Offset: 0x1B12440 VA: 0x181B13E40
	|-EnumHelper.Transformer<short, DateTime>.BeginInvoke
	|
	|-RVA: 0x1B14DC0 Offset: 0x1B133C0 VA: 0x181B14DC0
	|-EnumHelper.Transformer<short, DateTimeOffset>.BeginInvoke
	|
	|-RVA: 0x1B140C0 Offset: 0x1B126C0 VA: 0x181B140C0
	|-EnumHelper.Transformer<short, Decimal>.BeginInvoke
	|
	|-RVA: 0x1B15A40 Offset: 0x1B14040 VA: 0x181B15A40
	|-EnumHelper.Transformer<short, EmptyStruct>.BeginInvoke
	|
	|-RVA: 0x1B14D40 Offset: 0x1B13340 VA: 0x181B14D40
	|-EnumHelper.Transformer<short, double>.BeginInvoke
	|
	|-RVA: 0x1B145C0 Offset: 0x1B12BC0 VA: 0x181B145C0
	|-EnumHelper.Transformer<short, Guid>.BeginInvoke
	|
	|-RVA: 0x1B143C0 Offset: 0x1B129C0 VA: 0x181B143C0
	|-EnumHelper.Transformer<short, short>.BeginInvoke
	|
	|-RVA: 0x1B14240 Offset: 0x1B12840 VA: 0x181B14240
	|-EnumHelper.Transformer<short, int>.BeginInvoke
	|
	|-RVA: 0x1B14540 Offset: 0x1B12B40 VA: 0x181B14540
	|-EnumHelper.Transformer<short, long>.BeginInvoke
	|
	|-RVA: 0x1B14140 Offset: 0x1B12740 VA: 0x181B14140
	|-EnumHelper.Transformer<short, IntPtr>.BeginInvoke
	|
	|-RVA: 0x1B14340 Offset: 0x1B12940 VA: 0x181B14340
	|-EnumHelper.Transformer<short, sbyte>.BeginInvoke
	|
	|-RVA: 0x1B160C0 Offset: 0x1B146C0 VA: 0x181B160C0
	|-EnumHelper.Transformer<short, float>.BeginInvoke
	|
	|-RVA: 0x1B15E40 Offset: 0x1B14440 VA: 0x181B15E40
	|-EnumHelper.Transformer<short, TimeSpan>.BeginInvoke
	|
	|-RVA: 0x1B14740 Offset: 0x1B12D40 VA: 0x181B14740
	|-EnumHelper.Transformer<short, ushort>.BeginInvoke
	|
	|-RVA: 0x1B14AC0 Offset: 0x1B130C0 VA: 0x181B14AC0
	|-EnumHelper.Transformer<short, uint>.BeginInvoke
	|
	|-RVA: 0x1B15440 Offset: 0x1B13A40 VA: 0x181B15440
	|-EnumHelper.Transformer<short, ulong>.BeginInvoke
	|
	|-RVA: 0x1B14CC0 Offset: 0x1B132C0 VA: 0x181B14CC0
	|-EnumHelper.Transformer<short, UIntPtr>.BeginInvoke
	|
	|-RVA: 0x1B15D40 Offset: 0x1B14340 VA: 0x181B15D40
	|-EnumHelper.Transformer<int, bool>.BeginInvoke
	|
	|-RVA: 0x1B146C0 Offset: 0x1B12CC0 VA: 0x181B146C0
	|-EnumHelper.Transformer<int, byte>.BeginInvoke
	|
	|-RVA: 0x1B14940 Offset: 0x1B12F40 VA: 0x181B14940
	|-EnumHelper.Transformer<int, char>.BeginInvoke
	|
	|-RVA: 0x1B14EC0 Offset: 0x1B134C0 VA: 0x181B14EC0
	|-EnumHelper.Transformer<int, KeyValuePair<object, object>>.BeginInvoke
	|
	|-RVA: 0x1B14F40 Offset: 0x1B13540 VA: 0x181B14F40
	|-EnumHelper.Transformer<int, DateTime>.BeginInvoke
	|
	|-RVA: 0x1B15240 Offset: 0x1B13840 VA: 0x181B15240
	|-EnumHelper.Transformer<int, DateTimeOffset>.BeginInvoke
	|
	|-RVA: 0x1B150C0 Offset: 0x1B136C0 VA: 0x181B150C0
	|-EnumHelper.Transformer<int, Decimal>.BeginInvoke
	|
	|-RVA: 0x1B159C0 Offset: 0x1B13FC0 VA: 0x181B159C0
	|-EnumHelper.Transformer<int, EmptyStruct>.BeginInvoke
	|
	|-RVA: 0x1B14C40 Offset: 0x1B13240 VA: 0x181B14C40
	|-EnumHelper.Transformer<int, double>.BeginInvoke
	|
	|-RVA: 0x1B15F40 Offset: 0x1B14540 VA: 0x181B15F40
	|-EnumHelper.Transformer<int, Guid>.BeginInvoke
	|
	|-RVA: 0x1B152C0 Offset: 0x1B138C0 VA: 0x181B152C0
	|-EnumHelper.Transformer<int, short>.BeginInvoke
	|
	|-RVA: 0x1B15C40 Offset: 0x1B14240 VA: 0x181B15C40
	|-EnumHelper.Transformer<int, int>.BeginInvoke
	|
	|-RVA: 0x1B156C0 Offset: 0x1B13CC0 VA: 0x181B156C0
	|-EnumHelper.Transformer<int, long>.BeginInvoke
	|
	|-RVA: 0x1B15840 Offset: 0x1B13E40 VA: 0x181B15840
	|-EnumHelper.Transformer<int, IntPtr>.BeginInvoke
	|
	|-RVA: 0x1B14440 Offset: 0x1B12A40 VA: 0x181B14440
	|-EnumHelper.Transformer<int, sbyte>.BeginInvoke
	|
	|-RVA: 0x1B13F40 Offset: 0x1B12540 VA: 0x181B13F40
	|-EnumHelper.Transformer<int, float>.BeginInvoke
	|
	|-RVA: 0x1B154C0 Offset: 0x1B13AC0 VA: 0x181B154C0
	|-EnumHelper.Transformer<int, TimeSpan>.BeginInvoke
	|
	|-RVA: 0x1B14840 Offset: 0x1B12E40 VA: 0x181B14840
	|-EnumHelper.Transformer<int, ushort>.BeginInvoke
	|
	|-RVA: 0x1B151C0 Offset: 0x1B137C0 VA: 0x181B151C0
	|-EnumHelper.Transformer<int, uint>.BeginInvoke
	|
	|-RVA: 0x1B13FC0 Offset: 0x1B125C0 VA: 0x181B13FC0
	|-EnumHelper.Transformer<int, ulong>.BeginInvoke
	|
	|-RVA: 0x1B14FC0 Offset: 0x1B135C0 VA: 0x181B14FC0
	|-EnumHelper.Transformer<int, UIntPtr>.BeginInvoke
	|
	|-RVA: 0x1B14A40 Offset: 0x1B13040 VA: 0x181B14A40
	|-EnumHelper.Transformer<long, bool>.BeginInvoke
	|
	|-RVA: 0x1B15640 Offset: 0x1B13C40 VA: 0x181B15640
	|-EnumHelper.Transformer<long, byte>.BeginInvoke
	|
	|-RVA: 0x1B144C0 Offset: 0x1B12AC0 VA: 0x181B144C0
	|-EnumHelper.Transformer<long, char>.BeginInvoke
	|
	|-RVA: 0x1B15140 Offset: 0x1B13740 VA: 0x181B15140
	|-EnumHelper.Transformer<long, KeyValuePair<object, object>>.BeginInvoke
	|
	|-RVA: 0x1B15B40 Offset: 0x1B14140 VA: 0x181B15B40
	|-EnumHelper.Transformer<long, DateTime>.BeginInvoke
	|
	|-RVA: 0x1B15740 Offset: 0x1B13D40 VA: 0x181B15740
	|-EnumHelper.Transformer<long, DateTimeOffset>.BeginInvoke
	|
	|-RVA: 0x1B14B40 Offset: 0x1B13140 VA: 0x181B14B40
	|-EnumHelper.Transformer<long, Decimal>.BeginInvoke
	|
	|-RVA: 0x213C860 Offset: 0x213AE60 VA: 0x18213C860
	|-EnumHelper.Transformer<long, EmptyStruct>.BeginInvoke
	|
	|-RVA: 0x213C960 Offset: 0x213AF60 VA: 0x18213C960
	|-EnumHelper.Transformer<long, double>.BeginInvoke
	|
	|-RVA: 0x213AAE0 Offset: 0x21390E0 VA: 0x18213AAE0
	|-EnumHelper.Transformer<long, Guid>.BeginInvoke
	|
	|-RVA: 0x213C1E0 Offset: 0x213A7E0 VA: 0x18213C1E0
	|-EnumHelper.Transformer<long, short>.BeginInvoke
	|
	|-RVA: 0x213B7E0 Offset: 0x2139DE0 VA: 0x18213B7E0
	|-EnumHelper.Transformer<long, int>.BeginInvoke
	|
	|-RVA: 0x213BE60 Offset: 0x213A460 VA: 0x18213BE60
	|-EnumHelper.Transformer<long, long>.BeginInvoke
	|
	|-RVA: 0x213BA60 Offset: 0x213A060 VA: 0x18213BA60
	|-EnumHelper.Transformer<long, IntPtr>.BeginInvoke
	|
	|-RVA: 0x213C560 Offset: 0x213AB60 VA: 0x18213C560
	|-EnumHelper.Transformer<long, sbyte>.BeginInvoke
	|
	|-RVA: 0x213B6E0 Offset: 0x2139CE0 VA: 0x18213B6E0
	|-EnumHelper.Transformer<long, float>.BeginInvoke
	|
	|-RVA: 0x213D8E0 Offset: 0x213BEE0 VA: 0x18213D8E0
	|-EnumHelper.Transformer<long, TimeSpan>.BeginInvoke
	|
	|-RVA: 0x213B160 Offset: 0x2139760 VA: 0x18213B160
	|-EnumHelper.Transformer<long, ushort>.BeginInvoke
	|
	|-RVA: 0x213C9E0 Offset: 0x213AFE0 VA: 0x18213C9E0
	|-EnumHelper.Transformer<long, uint>.BeginInvoke
	|
	|-RVA: 0x213B9E0 Offset: 0x2139FE0 VA: 0x18213B9E0
	|-EnumHelper.Transformer<long, ulong>.BeginInvoke
	|
	|-RVA: 0x213CBE0 Offset: 0x213B1E0 VA: 0x18213CBE0
	|-EnumHelper.Transformer<long, UIntPtr>.BeginInvoke
	|
	|-RVA: 0x213AF60 Offset: 0x2139560 VA: 0x18213AF60
	|-EnumHelper.Transformer<sbyte, bool>.BeginInvoke
	|
	|-RVA: 0x213B760 Offset: 0x2139D60 VA: 0x18213B760
	|-EnumHelper.Transformer<sbyte, byte>.BeginInvoke
	|
	|-RVA: 0x213B2E0 Offset: 0x21398E0 VA: 0x18213B2E0
	|-EnumHelper.Transformer<sbyte, char>.BeginInvoke
	|
	|-RVA: 0x213CF60 Offset: 0x213B560 VA: 0x18213CF60
	|-EnumHelper.Transformer<sbyte, KeyValuePair<object, object>>.BeginInvoke
	|
	|-RVA: 0x213C5E0 Offset: 0x213ABE0 VA: 0x18213C5E0
	|-EnumHelper.Transformer<sbyte, DateTime>.BeginInvoke
	|
	|-RVA: 0x213AE60 Offset: 0x2139460 VA: 0x18213AE60
	|-EnumHelper.Transformer<sbyte, DateTimeOffset>.BeginInvoke
	|
	|-RVA: 0x213B8E0 Offset: 0x2139EE0 VA: 0x18213B8E0
	|-EnumHelper.Transformer<sbyte, Decimal>.BeginInvoke
	|
	|-RVA: 0x213A9E0 Offset: 0x2138FE0 VA: 0x18213A9E0
	|-EnumHelper.Transformer<sbyte, EmptyStruct>.BeginInvoke
	|
	|-RVA: 0x213CFE0 Offset: 0x213B5E0 VA: 0x18213CFE0
	|-EnumHelper.Transformer<sbyte, double>.BeginInvoke
	|
	|-RVA: 0x213D060 Offset: 0x213B660 VA: 0x18213D060
	|-EnumHelper.Transformer<sbyte, Guid>.BeginInvoke
	|
	|-RVA: 0x213B660 Offset: 0x2139C60 VA: 0x18213B660
	|-EnumHelper.Transformer<sbyte, short>.BeginInvoke
	|
	|-RVA: 0x213C760 Offset: 0x213AD60 VA: 0x18213C760
	|-EnumHelper.Transformer<sbyte, int>.BeginInvoke
	|
	|-RVA: 0x213CDE0 Offset: 0x213B3E0 VA: 0x18213CDE0
	|-EnumHelper.Transformer<sbyte, long>.BeginInvoke
	|
	|-RVA: 0x213BF60 Offset: 0x213A560 VA: 0x18213BF60
	|-EnumHelper.Transformer<sbyte, IntPtr>.BeginInvoke
	|
	|-RVA: 0x213CCE0 Offset: 0x213B2E0 VA: 0x18213CCE0
	|-EnumHelper.Transformer<sbyte, sbyte>.BeginInvoke
	|
	|-RVA: 0x213C660 Offset: 0x213AC60 VA: 0x18213C660
	|-EnumHelper.Transformer<sbyte, float>.BeginInvoke
	|
	|-RVA: 0x213C060 Offset: 0x213A660 VA: 0x18213C060
	|-EnumHelper.Transformer<sbyte, TimeSpan>.BeginInvoke
	|
	|-RVA: 0x213D7E0 Offset: 0x213BDE0 VA: 0x18213D7E0
	|-EnumHelper.Transformer<sbyte, ushort>.BeginInvoke
	|
	|-RVA: 0x213ACE0 Offset: 0x21392E0 VA: 0x18213ACE0
	|-EnumHelper.Transformer<sbyte, uint>.BeginInvoke
	|
	|-RVA: 0x213AA60 Offset: 0x2139060 VA: 0x18213AA60
	|-EnumHelper.Transformer<sbyte, ulong>.BeginInvoke
	|
	|-RVA: 0x213A860 Offset: 0x2138E60 VA: 0x18213A860
	|-EnumHelper.Transformer<sbyte, UIntPtr>.BeginInvoke
	|
	|-RVA: 0x213C4E0 Offset: 0x213AAE0 VA: 0x18213C4E0
	|-EnumHelper.Transformer<ushort, bool>.BeginInvoke
	|
	|-RVA: 0x213BBE0 Offset: 0x213A1E0 VA: 0x18213BBE0
	|-EnumHelper.Transformer<ushort, byte>.BeginInvoke
	|
	|-RVA: 0x213C360 Offset: 0x213A960 VA: 0x18213C360
	|-EnumHelper.Transformer<ushort, char>.BeginInvoke
	|
	|-RVA: 0x213BC60 Offset: 0x213A260 VA: 0x18213BC60
	|-EnumHelper.Transformer<ushort, KeyValuePair<object, object>>.BeginInvoke
	|
	|-RVA: 0x213B0E0 Offset: 0x21396E0 VA: 0x18213B0E0
	|-EnumHelper.Transformer<ushort, DateTime>.BeginInvoke
	|
	|-RVA: 0x213ADE0 Offset: 0x21393E0 VA: 0x18213ADE0
	|-EnumHelper.Transformer<ushort, DateTimeOffset>.BeginInvoke
	|
	|-RVA: 0x213BD60 Offset: 0x213A360 VA: 0x18213BD60
	|-EnumHelper.Transformer<ushort, Decimal>.BeginInvoke
	|
	|-RVA: 0x213ABE0 Offset: 0x21391E0 VA: 0x18213ABE0
	|-EnumHelper.Transformer<ushort, EmptyStruct>.BeginInvoke
	|
	|-RVA: 0x213C0E0 Offset: 0x213A6E0 VA: 0x18213C0E0
	|-EnumHelper.Transformer<ushort, double>.BeginInvoke
	|
	|-RVA: 0x213A8E0 Offset: 0x2138EE0 VA: 0x18213A8E0
	|-EnumHelper.Transformer<ushort, Guid>.BeginInvoke
	|
	|-RVA: 0x213C6E0 Offset: 0x213ACE0 VA: 0x18213C6E0
	|-EnumHelper.Transformer<ushort, short>.BeginInvoke
	|
	|-RVA: 0x213D5E0 Offset: 0x213BBE0 VA: 0x18213D5E0
	|-EnumHelper.Transformer<ushort, int>.BeginInvoke
	|
	|-RVA: 0x213B3E0 Offset: 0x21399E0 VA: 0x18213B3E0
	|-EnumHelper.Transformer<ushort, long>.BeginInvoke
	|
	|-RVA: 0x213A960 Offset: 0x2138F60 VA: 0x18213A960
	|-EnumHelper.Transformer<ushort, IntPtr>.BeginInvoke
	|
	|-RVA: 0x213CB60 Offset: 0x213B160 VA: 0x18213CB60
	|-EnumHelper.Transformer<ushort, sbyte>.BeginInvoke
	|
	|-RVA: 0x213B360 Offset: 0x2139960 VA: 0x18213B360
	|-EnumHelper.Transformer<ushort, float>.BeginInvoke
	|
	|-RVA: 0x213BDE0 Offset: 0x213A3E0 VA: 0x18213BDE0
	|-EnumHelper.Transformer<ushort, TimeSpan>.BeginInvoke
	|
	|-RVA: 0x213D160 Offset: 0x213B760 VA: 0x18213D160
	|-EnumHelper.Transformer<ushort, ushort>.BeginInvoke
	|
	|-RVA: 0x213BEE0 Offset: 0x213A4E0 VA: 0x18213BEE0
	|-EnumHelper.Transformer<ushort, uint>.BeginInvoke
	|
	|-RVA: 0x213B260 Offset: 0x2139860 VA: 0x18213B260
	|-EnumHelper.Transformer<ushort, ulong>.BeginInvoke
	|
	|-RVA: 0x213BB60 Offset: 0x213A160 VA: 0x18213BB60
	|-EnumHelper.Transformer<ushort, UIntPtr>.BeginInvoke
	|
	|-RVA: 0x213C460 Offset: 0x213AA60 VA: 0x18213C460
	|-EnumHelper.Transformer<uint, bool>.BeginInvoke
	|
	|-RVA: 0x213BFE0 Offset: 0x213A5E0 VA: 0x18213BFE0
	|-EnumHelper.Transformer<uint, byte>.BeginInvoke
	|
	|-RVA: 0x213D3E0 Offset: 0x213B9E0 VA: 0x18213D3E0
	|-EnumHelper.Transformer<uint, char>.BeginInvoke
	|
	|-RVA: 0x213C2E0 Offset: 0x213A8E0 VA: 0x18213C2E0
	|-EnumHelper.Transformer<uint, KeyValuePair<object, object>>.BeginInvoke
	|
	|-RVA: 0x213AFE0 Offset: 0x21395E0 VA: 0x18213AFE0
	|-EnumHelper.Transformer<uint, DateTime>.BeginInvoke
	|
	|-RVA: 0x213B1E0 Offset: 0x21397E0 VA: 0x18213B1E0
	|-EnumHelper.Transformer<uint, DateTimeOffset>.BeginInvoke
	|
	|-RVA: 0x213B4E0 Offset: 0x2139AE0 VA: 0x18213B4E0
	|-EnumHelper.Transformer<uint, Decimal>.BeginInvoke
	|
	|-RVA: 0x213CA60 Offset: 0x213B060 VA: 0x18213CA60
	|-EnumHelper.Transformer<uint, EmptyStruct>.BeginInvoke
	|
	|-RVA: 0x213AC60 Offset: 0x2139260 VA: 0x18213AC60
	|-EnumHelper.Transformer<uint, double>.BeginInvoke
	|
	|-RVA: 0x213CE60 Offset: 0x213B460 VA: 0x18213CE60
	|-EnumHelper.Transformer<uint, Guid>.BeginInvoke
	|
	|-RVA: 0x213BAE0 Offset: 0x213A0E0 VA: 0x18213BAE0
	|-EnumHelper.Transformer<uint, short>.BeginInvoke
	|
	|-RVA: 0x213B5E0 Offset: 0x2139BE0 VA: 0x18213B5E0
	|-EnumHelper.Transformer<uint, int>.BeginInvoke
	|
	|-RVA: 0x213D460 Offset: 0x213BA60 VA: 0x18213D460
	|-EnumHelper.Transformer<uint, long>.BeginInvoke
	|
	|-RVA: 0x213D1E0 Offset: 0x213B7E0 VA: 0x18213D1E0
	|-EnumHelper.Transformer<uint, IntPtr>.BeginInvoke
	|
	|-RVA: 0x213D760 Offset: 0x213BD60 VA: 0x18213D760
	|-EnumHelper.Transformer<uint, sbyte>.BeginInvoke
	|
	|-RVA: 0x213C260 Offset: 0x213A860 VA: 0x18213C260
	|-EnumHelper.Transformer<uint, float>.BeginInvoke
	|
	|-RVA: 0x213D860 Offset: 0x213BE60 VA: 0x18213D860
	|-EnumHelper.Transformer<uint, TimeSpan>.BeginInvoke
	|
	|-RVA: 0x213BCE0 Offset: 0x213A2E0 VA: 0x18213BCE0
	|-EnumHelper.Transformer<uint, ushort>.BeginInvoke
	|
	|-RVA: 0x213D560 Offset: 0x213BB60 VA: 0x18213D560
	|-EnumHelper.Transformer<uint, uint>.BeginInvoke
	|
	|-RVA: 0x213CD60 Offset: 0x213B360 VA: 0x18213CD60
	|-EnumHelper.Transformer<uint, ulong>.BeginInvoke
	|
	|-RVA: 0x213D4E0 Offset: 0x213BAE0 VA: 0x18213D4E0
	|-EnumHelper.Transformer<uint, UIntPtr>.BeginInvoke
	|
	|-RVA: 0x213D260 Offset: 0x213B860 VA: 0x18213D260
	|-EnumHelper.Transformer<ulong, bool>.BeginInvoke
	|
	|-RVA: 0x213D360 Offset: 0x213B960 VA: 0x18213D360
	|-EnumHelper.Transformer<ulong, byte>.BeginInvoke
	|
	|-RVA: 0x213D6E0 Offset: 0x213BCE0 VA: 0x18213D6E0
	|-EnumHelper.Transformer<ulong, char>.BeginInvoke
	|
	|-RVA: 0x213C8E0 Offset: 0x213AEE0 VA: 0x18213C8E0
	|-EnumHelper.Transformer<ulong, KeyValuePair<object, object>>.BeginInvoke
	|
	|-RVA: 0x213C160 Offset: 0x213A760 VA: 0x18213C160
	|-EnumHelper.Transformer<ulong, DateTime>.BeginInvoke
	|
	|-RVA: 0x213AD60 Offset: 0x2139360 VA: 0x18213AD60
	|-EnumHelper.Transformer<ulong, DateTimeOffset>.BeginInvoke
	|
	|-RVA: 0x213B560 Offset: 0x2139B60 VA: 0x18213B560
	|-EnumHelper.Transformer<ulong, Decimal>.BeginInvoke
	|
	|-RVA: 0x213C3E0 Offset: 0x213A9E0 VA: 0x18213C3E0
	|-EnumHelper.Transformer<ulong, EmptyStruct>.BeginInvoke
	|
	|-RVA: 0x213B960 Offset: 0x2139F60 VA: 0x18213B960
	|-EnumHelper.Transformer<ulong, double>.BeginInvoke
	|
	|-RVA: 0x213B060 Offset: 0x2139660 VA: 0x18213B060
	|-EnumHelper.Transformer<ulong, Guid>.BeginInvoke
	|
	|-RVA: 0x213D0E0 Offset: 0x213B6E0 VA: 0x18213D0E0
	|-EnumHelper.Transformer<ulong, short>.BeginInvoke
	|
	|-RVA: 0x213B460 Offset: 0x2139A60 VA: 0x18213B460
	|-EnumHelper.Transformer<ulong, int>.BeginInvoke
	|
	|-RVA: 0x213B860 Offset: 0x2139E60 VA: 0x18213B860
	|-EnumHelper.Transformer<ulong, long>.BeginInvoke
	|
	|-RVA: 0x213CC60 Offset: 0x213B260 VA: 0x18213CC60
	|-EnumHelper.Transformer<ulong, IntPtr>.BeginInvoke
	|
	|-RVA: 0x213AB60 Offset: 0x2139160 VA: 0x18213AB60
	|-EnumHelper.Transformer<ulong, sbyte>.BeginInvoke
	|
	|-RVA: 0x213CAE0 Offset: 0x213B0E0 VA: 0x18213CAE0
	|-EnumHelper.Transformer<ulong, float>.BeginInvoke
	|
	|-RVA: 0x213D2E0 Offset: 0x213B8E0 VA: 0x18213D2E0
	|-EnumHelper.Transformer<ulong, TimeSpan>.BeginInvoke
	|
	|-RVA: 0x213D660 Offset: 0x213BC60 VA: 0x18213D660
	|-EnumHelper.Transformer<ulong, ushort>.BeginInvoke
	|
	|-RVA: 0x213AEE0 Offset: 0x21394E0 VA: 0x18213AEE0
	|-EnumHelper.Transformer<ulong, uint>.BeginInvoke
	|
	|-RVA: 0x213C7E0 Offset: 0x213ADE0 VA: 0x18213C7E0
	|-EnumHelper.Transformer<ulong, ulong>.BeginInvoke
	|
	|-RVA: 0x213CEE0 Offset: 0x213B4E0 VA: 0x18213CEE0
	|-EnumHelper.Transformer<ulong, UIntPtr>.BeginInvoke
	*/

	public virtual UnderlyingType EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFF70B0 Offset: 0xFF56B0 VA: 0x180FF70B0
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
	|-RVA: 0xD98690 Offset: 0xD96C90 VA: 0x180D98690
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
	|-RVA: 0xB9AFA0 Offset: 0xB995A0 VA: 0x180B9AFA0
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
	|-RVA: 0x1221E30 Offset: 0x1220430 VA: 0x181221E30
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
	|-RVA: 0x1AFC2C0 Offset: 0x1AFA8C0 VA: 0x181AFC2C0
	|-EnumHelper.Caster<byte, bool>..cctor
	|
	|-RVA: 0x1AF7670 Offset: 0x1AF5C70 VA: 0x181AF7670
	|-EnumHelper.Caster<byte, byte>..cctor
	|
	|-RVA: 0x1B00A70 Offset: 0x1AFF070 VA: 0x181B00A70
	|-EnumHelper.Caster<byte, char>..cctor
	|
	|-RVA: 0x1B04D80 Offset: 0x1B03380 VA: 0x181B04D80
	|-EnumHelper.Caster<byte, KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x1AFEA10 Offset: 0x1AFD010 VA: 0x181AFEA10
	|-EnumHelper.Caster<byte, DateTime>..cctor
	|
	|-RVA: 0x1B06B90 Offset: 0x1B05190 VA: 0x181B06B90
	|-EnumHelper.Caster<byte, DateTimeOffset>..cctor
	|
	|-RVA: 0x1B0B340 Offset: 0x1B09940 VA: 0x181B0B340
	|-EnumHelper.Caster<byte, Decimal>..cctor
	|
	|-RVA: 0x1AFF5A0 Offset: 0x1AFDBA0 VA: 0x181AFF5A0
	|-EnumHelper.Caster<byte, EmptyStruct>..cctor
	|
	|-RVA: 0x1B0EAC0 Offset: 0x1B0D0C0 VA: 0x181B0EAC0
	|-EnumHelper.Caster<byte, double>..cctor
	|
	|-RVA: 0x1B0F650 Offset: 0x1B0DC50 VA: 0x181B0F650
	|-EnumHelper.Caster<byte, Guid>..cctor
	|
	|-RVA: 0x1AF71D0 Offset: 0x1AF57D0 VA: 0x181AF71D0
	|-EnumHelper.Caster<byte, short>..cctor
	|
	|-RVA: 0x1AFC510 Offset: 0x1AFAB10 VA: 0x181AFC510
	|-EnumHelper.Caster<byte, int>..cctor
	|
	|-RVA: 0x1AFEC60 Offset: 0x1AFD260 VA: 0x181AFEC60
	|-EnumHelper.Caster<byte, long>..cctor
	|
	|-RVA: 0x1B03FA0 Offset: 0x1B025A0 VA: 0x181B03FA0
	|-EnumHelper.Caster<byte, IntPtr>..cctor
	|
	|-RVA: 0x1B0E870 Offset: 0x1B0CE70 VA: 0x181B0E870
	|-EnumHelper.Caster<byte, object>..cctor
	|
	|-RVA: 0x1B07970 Offset: 0x1B05F70 VA: 0x181B07970
	|-EnumHelper.Caster<byte, sbyte>..cctor
	|
	|-RVA: 0x1B02F70 Offset: 0x1B01570 VA: 0x181B02F70
	|-EnumHelper.Caster<byte, float>..cctor
	|
	|-RVA: 0x1AFA950 Offset: 0x1AF8F50 VA: 0x181AFA950
	|-EnumHelper.Caster<byte, TimeSpan>..cctor
	|
	|-RVA: 0x1AFC070 Offset: 0x1AFA670 VA: 0x181AFC070
	|-EnumHelper.Caster<byte, ushort>..cctor
	|
	|-RVA: 0x1AFE7C0 Offset: 0x1AFCDC0 VA: 0x181AFE7C0
	|-EnumHelper.Caster<byte, uint>..cctor
	|
	|-RVA: 0x1B0C120 Offset: 0x1B0A720 VA: 0x181B0C120
	|-EnumHelper.Caster<byte, ulong>..cctor
	|
	|-RVA: 0x1AFD2F0 Offset: 0x1AFB8F0 VA: 0x181AFD2F0
	|-EnumHelper.Caster<byte, UIntPtr>..cctor
	|
	|-RVA: 0x1B0DA90 Offset: 0x1B0C090 VA: 0x181B0DA90
	|-EnumHelper.Caster<short, bool>..cctor
	|
	|-RVA: 0x1AF88F0 Offset: 0x1AF6EF0 VA: 0x181AF88F0
	|-EnumHelper.Caster<short, byte>..cctor
	|
	|-RVA: 0x1AF8450 Offset: 0x1AF6A50 VA: 0x181AF8450
	|-EnumHelper.Caster<short, char>..cctor
	|
	|-RVA: 0x1B01CF0 Offset: 0x1B002F0 VA: 0x181B01CF0
	|-EnumHelper.Caster<short, KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x1B013B0 Offset: 0x1AFF9B0 VA: 0x181B013B0
	|-EnumHelper.Caster<short, DateTime>..cctor
	|
	|-RVA: 0x1B074D0 Offset: 0x1B05AD0 VA: 0x181B074D0
	|-EnumHelper.Caster<short, DateTimeOffset>..cctor
	|
	|-RVA: 0x1AFB4E0 Offset: 0x1AF9AE0 VA: 0x181AFB4E0
	|-EnumHelper.Caster<short, Decimal>..cctor
	|
	|-RVA: 0x1B0B7E0 Offset: 0x1B09DE0 VA: 0x181B0B7E0
	|-EnumHelper.Caster<short, EmptyStruct>..cctor
	|
	|-RVA: 0x1AFA4B0 Offset: 0x1AF8AB0 VA: 0x181AFA4B0
	|-EnumHelper.Caster<short, double>..cctor
	|
	|-RVA: 0x1B066F0 Offset: 0x1B04CF0 VA: 0x181B066F0
	|-EnumHelper.Caster<short, Guid>..cctor
	|
	|-RVA: 0x1B05DB0 Offset: 0x1B043B0 VA: 0x181B05DB0
	|-EnumHelper.Caster<short, short>..cctor
	|
	|-RVA: 0x1B00CC0 Offset: 0x1AFF2C0 VA: 0x181B00CC0
	|-EnumHelper.Caster<short, int>..cctor
	|
	|-RVA: 0x1AFD540 Offset: 0x1AFBB40 VA: 0x181AFD540
	|-EnumHelper.Caster<short, long>..cctor
	|
	|-RVA: 0x1B08500 Offset: 0x1B06B00 VA: 0x181B08500
	|-EnumHelper.Caster<short, IntPtr>..cctor
	|
	|-RVA: 0x1B02190 Offset: 0x1B00790 VA: 0x181B02190
	|-EnumHelper.Caster<short, object>..cctor
	|
	|-RVA: 0x1B038B0 Offset: 0x1B01EB0 VA: 0x181B038B0
	|-EnumHelper.Caster<short, sbyte>..cctor
	|
	|-RVA: 0x1B099D0 Offset: 0x1B07FD0 VA: 0x181B099D0
	|-EnumHelper.Caster<short, float>..cctor
	|
	|-RVA: 0x1B09780 Offset: 0x1B07D80 VA: 0x181B09780
	|-EnumHelper.Caster<short, TimeSpan>..cctor
	|
	|-RVA: 0x1B0CF00 Offset: 0x1B0B500 VA: 0x181B0CF00
	|-EnumHelper.Caster<short, ushort>..cctor
	|
	|-RVA: 0x1AFBE20 Offset: 0x1AFA420 VA: 0x181AFBE20
	|-EnumHelper.Caster<short, uint>..cctor
	|
	|-RVA: 0x1AFDE80 Offset: 0x1AFC480 VA: 0x181AFDE80
	|-EnumHelper.Caster<short, ulong>..cctor
	|
	|-RVA: 0x1B09E70 Offset: 0x1B08470 VA: 0x181B09E70
	|-EnumHelper.Caster<short, UIntPtr>..cctor
	|
	|-RVA: 0x1AF61A0 Offset: 0x1AF47A0 VA: 0x181AF61A0
	|-EnumHelper.Caster<int, bool>..cctor
	|
	|-RVA: 0x1AF9480 Offset: 0x1AF7A80 VA: 0x181AF9480
	|-EnumHelper.Caster<int, byte>..cctor
	|
	|-RVA: 0x1AF8FE0 Offset: 0x1AF75E0 VA: 0x181AF8FE0
	|-EnumHelper.Caster<int, char>..cctor
	|
	|-RVA: 0x1B0AA00 Offset: 0x1B09000 VA: 0x181B0AA00
	|-EnumHelper.Caster<int, KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x1B082B0 Offset: 0x1B068B0 VA: 0x181B082B0
	|-EnumHelper.Caster<int, DateTime>..cctor
	|
	|-RVA: 0x1AFF100 Offset: 0x1AFD700 VA: 0x181AFF100
	|-EnumHelper.Caster<int, DateTimeOffset>..cctor
	|
	|-RVA: 0x1B048E0 Offset: 0x1B02EE0 VA: 0x181B048E0
	|-EnumHelper.Caster<int, Decimal>..cctor
	|
	|-RVA: 0x1B064A0 Offset: 0x1B04AA0 VA: 0x181B064A0
	|-EnumHelper.Caster<int, EmptyStruct>..cctor
	|
	|-RVA: 0x1AFA010 Offset: 0x1AF8610 VA: 0x181AFA010
	|-EnumHelper.Caster<int, double>..cctor
	|
	|-RVA: 0x1AF6AE0 Offset: 0x1AF50E0 VA: 0x181AF6AE0
	|-EnumHelper.Caster<int, Guid>..cctor
	|
	|-RVA: 0x1AFD9E0 Offset: 0x1AFBFE0 VA: 0x181AFD9E0
	|-EnumHelper.Caster<int, short>..cctor
	|
	|-RVA: 0x1AF86A0 Offset: 0x1AF6CA0 VA: 0x181AF86A0
	|-EnumHelper.Caster<int, int>..cctor
	|
	|-RVA: 0x1B0AEA0 Offset: 0x1B094A0 VA: 0x181B0AEA0
	|-EnumHelper.Caster<int, long>..cctor
	|
	|-RVA: 0x1AF6890 Offset: 0x1AF4E90 VA: 0x181AF6890
	|-EnumHelper.Caster<int, IntPtr>..cctor
	|
	|-RVA: 0x1B0B590 Offset: 0x1B09B90 VA: 0x181B0B590
	|-EnumHelper.Caster<int, object>..cctor
	|
	|-RVA: 0x1B09090 Offset: 0x1B07690 VA: 0x181B09090
	|-EnumHelper.Caster<int, sbyte>..cctor
	|
	|-RVA: 0x1AFB730 Offset: 0x1AF9D30 VA: 0x181AFB730
	|-EnumHelper.Caster<int, float>..cctor
	|
	|-RVA: 0x1B06DE0 Offset: 0x1B053E0 VA: 0x181B06DE0
	|-EnumHelper.Caster<int, TimeSpan>..cctor
	|
	|-RVA: 0x1B0E620 Offset: 0x1B0CC20 VA: 0x181B0E620
	|-EnumHelper.Caster<int, ushort>..cctor
	|
	|-RVA: 0x1B01600 Offset: 0x1AFFC00 VA: 0x181B01600
	|-EnumHelper.Caster<int, uint>..cctor
	|
	|-RVA: 0x1AF8D90 Offset: 0x1AF7390 VA: 0x181AF8D90
	|-EnumHelper.Caster<int, ulong>..cctor
	|
	|-RVA: 0x1B08750 Offset: 0x1B06D50 VA: 0x181B08750
	|-EnumHelper.Caster<int, UIntPtr>..cctor
	|
	|-RVA: 0x1B04440 Offset: 0x1B02A40 VA: 0x181B04440
	|-EnumHelper.Caster<long, bool>..cctor
	|
	|-RVA: 0x1B00130 Offset: 0x1AFE730 VA: 0x181B00130
	|-EnumHelper.Caster<long, byte>..cctor
	|
	|-RVA: 0x1B03B00 Offset: 0x1B02100 VA: 0x181B03B00
	|-EnumHelper.Caster<long, char>..cctor
	|
	|-RVA: 0x1AF96D0 Offset: 0x1AF7CD0 VA: 0x181AF96D0
	|-EnumHelper.Caster<long, KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x1AFABA0 Offset: 0x1AF91A0 VA: 0x181AFABA0
	|-EnumHelper.Caster<long, DateTime>..cctor
	|
	|-RVA: 0x1B01F40 Offset: 0x1B00540 VA: 0x181B01F40
	|-EnumHelper.Caster<long, DateTimeOffset>..cctor
	|
	|-RVA: 0x1B00380 Offset: 0x1AFE980 VA: 0x181B00380
	|-EnumHelper.Caster<long, Decimal>..cctor
	|
	|-RVA: 0x1B092E0 Offset: 0x1B078E0 VA: 0x181B092E0
	|-EnumHelper.Caster<long, EmptyStruct>..cctor
	|
	|-RVA: 0x1AF6D30 Offset: 0x1AF5330 VA: 0x181AF6D30
	|-EnumHelper.Caster<long, double>..cctor
	|
	|-RVA: 0x1AFF7F0 Offset: 0x1AFDDF0 VA: 0x181AFF7F0
	|-EnumHelper.Caster<long, Guid>..cctor
	|
	|-RVA: 0x1B0A7B0 Offset: 0x1B08DB0 VA: 0x181B0A7B0
	|-EnumHelper.Caster<long, short>..cctor
	|
	|-RVA: 0x1B00820 Offset: 0x1AFEE20 VA: 0x181B00820
	|-EnumHelper.Caster<long, int>..cctor
	|
	|-RVA: 0x1AFE320 Offset: 0x1AFC920 VA: 0x181AFE320
	|-EnumHelper.Caster<long, long>..cctor
	|
	|-RVA: 0x1B0F400 Offset: 0x1B0DA00 VA: 0x181B0F400
	|-EnumHelper.Caster<long, IntPtr>..cctor
	|
	|-RVA: 0x1AF9230 Offset: 0x1AF7830 VA: 0x181AF9230
	|-EnumHelper.Caster<long, object>..cctor
	|
	|-RVA: 0x1B0C370 Offset: 0x1B0A970 VA: 0x181B0C370
	|-EnumHelper.Caster<long, sbyte>..cctor
	|
	|-RVA: 0x1AF9B70 Offset: 0x1AF8170 VA: 0x181AF9B70
	|-EnumHelper.Caster<long, float>..cctor
	|
	|-RVA: 0x1AF7D60 Offset: 0x1AF6360 VA: 0x181AF7D60
	|-EnumHelper.Caster<long, TimeSpan>..cctor
	|
	|-RVA: 0x1B05B60 Offset: 0x1B04160 VA: 0x181B05B60
	|-EnumHelper.Caster<long, ushort>..cctor
	|
	|-RVA: 0x1B02AD0 Offset: 0x1B010D0 VA: 0x181B02AD0
	|-EnumHelper.Caster<long, uint>..cctor
	|
	|-RVA: 0x1B0DCE0 Offset: 0x1B0C2E0 VA: 0x181B0DCE0
	|-EnumHelper.Caster<long, ulong>..cctor
	|
	|-RVA: 0x1B031C0 Offset: 0x1B017C0 VA: 0x181B031C0
	|-EnumHelper.Caster<long, UIntPtr>..cctor
	|
	|-RVA: 0x1B06250 Offset: 0x1B04850 VA: 0x181B06250
	|-EnumHelper.Caster<object, object>..cctor
	|
	|-RVA: 0x1AFB980 Offset: 0x1AF9F80 VA: 0x181AFB980
	|-EnumHelper.Caster<sbyte, bool>..cctor
	|
	|-RVA: 0x1B0EF60 Offset: 0x1B0D560 VA: 0x181B0EF60
	|-EnumHelper.Caster<sbyte, byte>..cctor
	|
	|-RVA: 0x1AF7B10 Offset: 0x1AF6110 VA: 0x181AF7B10
	|-EnumHelper.Caster<sbyte, char>..cctor
	|
	|-RVA: 0x1B0AC50 Offset: 0x1B09250 VA: 0x181B0AC50
	|-EnumHelper.Caster<sbyte, KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x1AFB290 Offset: 0x1AF9890 VA: 0x181AFB290
	|-EnumHelper.Caster<sbyte, DateTime>..cctor
	|
	|-RVA: 0x1AFC760 Offset: 0x1AFAD60 VA: 0x181AFC760
	|-EnumHelper.Caster<sbyte, DateTimeOffset>..cctor
	|
	|-RVA: 0x1AFCE50 Offset: 0x1AFB450 VA: 0x181AFCE50
	|-EnumHelper.Caster<sbyte, Decimal>..cctor
	|
	|-RVA: 0x1AF6F80 Offset: 0x1AF5580 VA: 0x181AF6F80
	|-EnumHelper.Caster<sbyte, EmptyStruct>..cctor
	|
	|-RVA: 0x1B041F0 Offset: 0x1B027F0 VA: 0x181B041F0
	|-EnumHelper.Caster<sbyte, double>..cctor
	|
	|-RVA: 0x1B05220 Offset: 0x1B03820 VA: 0x181B05220
	|-EnumHelper.Caster<sbyte, Guid>..cctor
	|
	|-RVA: 0x1B0A310 Offset: 0x1B08910 VA: 0x181B0A310
	|-EnumHelper.Caster<sbyte, short>..cctor
	|
	|-RVA: 0x1B0CA60 Offset: 0x1B0B060 VA: 0x181B0CA60
	|-EnumHelper.Caster<sbyte, int>..cctor
	|
	|-RVA: 0x1AFDC30 Offset: 0x1AFC230 VA: 0x181AFDC30
	|-EnumHelper.Caster<sbyte, long>..cctor
	|
	|-RVA: 0x1B0A0C0 Offset: 0x1B086C0 VA: 0x181B0A0C0
	|-EnumHelper.Caster<sbyte, IntPtr>..cctor
	|
	|-RVA: 0x1B04FD0 Offset: 0x1B035D0 VA: 0x181B04FD0
	|-EnumHelper.Caster<sbyte, object>..cctor
	|
	|-RVA: 0x1B0D150 Offset: 0x1B0B750 VA: 0x181B0D150
	|-EnumHelper.Caster<sbyte, sbyte>..cctor
	|
	|-RVA: 0x1B08060 Offset: 0x1B06660 VA: 0x181B08060
	|-EnumHelper.Caster<sbyte, float>..cctor
	|
	|-RVA: 0x1B00F10 Offset: 0x1AFF510 VA: 0x181B00F10
	|-EnumHelper.Caster<sbyte, TimeSpan>..cctor
	|
	|-RVA: 0x1AFADF0 Offset: 0x1AF93F0 VA: 0x181AFADF0
	|-EnumHelper.Caster<sbyte, ushort>..cctor
	|
	|-RVA: 0x1B0B0F0 Offset: 0x1B096F0 VA: 0x181B0B0F0
	|-EnumHelper.Caster<sbyte, uint>..cctor
	|
	|-RVA: 0x1B05470 Offset: 0x1B03A70 VA: 0x181B05470
	|-EnumHelper.Caster<sbyte, ulong>..cctor
	|
	|-RVA: 0x1AF7FB0 Offset: 0x1AF65B0 VA: 0x181AF7FB0
	|-EnumHelper.Caster<sbyte, UIntPtr>..cctor
	|
	|-RVA: 0x1B09530 Offset: 0x1B07B30 VA: 0x181B09530
	|-EnumHelper.Caster<ushort, bool>..cctor
	|
	|-RVA: 0x1B07030 Offset: 0x1B05630 VA: 0x181B07030
	|-EnumHelper.Caster<ushort, byte>..cctor
	|
	|-RVA: 0x1B01AA0 Offset: 0x1B000A0 VA: 0x181B01AA0
	|-EnumHelper.Caster<ushort, char>..cctor
	|
	|-RVA: 0x1B07BC0 Offset: 0x1B061C0 VA: 0x181B07BC0
	|-EnumHelper.Caster<ushort, KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x1B0E180 Offset: 0x1B0C780 VA: 0x181B0E180
	|-EnumHelper.Caster<ushort, DateTime>..cctor
	|
	|-RVA: 0x1B0BA30 Offset: 0x1B0A030 VA: 0x181B0BA30
	|-EnumHelper.Caster<ushort, DateTimeOffset>..cctor
	|
	|-RVA: 0x1B0C5C0 Offset: 0x1B0ABC0 VA: 0x181B0C5C0
	|-EnumHelper.Caster<ushort, Decimal>..cctor
	|
	|-RVA: 0x1AFD790 Offset: 0x1AFBD90 VA: 0x181AFD790
	|-EnumHelper.Caster<ushort, EmptyStruct>..cctor
	|
	|-RVA: 0x1B02880 Offset: 0x1B00E80 VA: 0x181B02880
	|-EnumHelper.Caster<ushort, double>..cctor
	|
	|-RVA: 0x1B02630 Offset: 0x1B00C30 VA: 0x181B02630
	|-EnumHelper.Caster<ushort, Guid>..cctor
	|
	|-RVA: 0x1B05910 Offset: 0x1B03F10 VA: 0x181B05910
	|-EnumHelper.Caster<ushort, short>..cctor
	|
	|-RVA: 0x1B08BF0 Offset: 0x1B071F0 VA: 0x181B08BF0
	|-EnumHelper.Caster<ushort, int>..cctor
	|
	|-RVA: 0x1B01850 Offset: 0x1AFFE50 VA: 0x181B01850
	|-EnumHelper.Caster<ushort, long>..cctor
	|
	|-RVA: 0x1B023E0 Offset: 0x1B009E0 VA: 0x181B023E0
	|-EnumHelper.Caster<ushort, IntPtr>..cctor
	|
	|-RVA: 0x1B06940 Offset: 0x1B04F40 VA: 0x181B06940
	|-EnumHelper.Caster<ushort, object>..cctor
	|
	|-RVA: 0x1B07720 Offset: 0x1B05D20 VA: 0x181B07720
	|-EnumHelper.Caster<ushort, sbyte>..cctor
	|
	|-RVA: 0x1AFFC90 Offset: 0x1AFE290 VA: 0x181AFFC90
	|-EnumHelper.Caster<ushort, float>..cctor
	|
	|-RVA: 0x1B0A560 Offset: 0x1B08B60 VA: 0x181B0A560
	|-EnumHelper.Caster<ushort, TimeSpan>..cctor
	|
	|-RVA: 0x1AFE0D0 Offset: 0x1AFC6D0 VA: 0x181AFE0D0
	|-EnumHelper.Caster<ushort, ushort>..cctor
	|
	|-RVA: 0x1AFC9B0 Offset: 0x1AFAFB0 VA: 0x181AFC9B0
	|-EnumHelper.Caster<ushort, uint>..cctor
	|
	|-RVA: 0x1B06000 Offset: 0x1B04600 VA: 0x181B06000
	|-EnumHelper.Caster<ushort, ulong>..cctor
	|
	|-RVA: 0x1B03660 Offset: 0x1B01C60 VA: 0x181B03660
	|-EnumHelper.Caster<ushort, UIntPtr>..cctor
	|
	|-RVA: 0x1AF63F0 Offset: 0x1AF49F0 VA: 0x181AF63F0
	|-EnumHelper.Caster<uint, bool>..cctor
	|
	|-RVA: 0x1AFD0A0 Offset: 0x1AFB6A0 VA: 0x181AFD0A0
	|-EnumHelper.Caster<uint, byte>..cctor
	|
	|-RVA: 0x1AF9DC0 Offset: 0x1AF83C0 VA: 0x181AF9DC0
	|-EnumHelper.Caster<uint, char>..cctor
	|
	|-RVA: 0x1B04B30 Offset: 0x1B03130 VA: 0x181B04B30
	|-EnumHelper.Caster<uint, KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x1B0F8A0 Offset: 0x1B0DEA0 VA: 0x181B0F8A0
	|-EnumHelper.Caster<uint, DateTime>..cctor
	|
	|-RVA: 0x1B0C810 Offset: 0x1B0AE10 VA: 0x181B0C810
	|-EnumHelper.Caster<uint, DateTimeOffset>..cctor
	|
	|-RVA: 0x1AFFA40 Offset: 0x1AFE040 VA: 0x181AFFA40
	|-EnumHelper.Caster<uint, Decimal>..cctor
	|
	|-RVA: 0x1B0F1B0 Offset: 0x1B0D7B0 VA: 0x181B0F1B0
	|-EnumHelper.Caster<uint, EmptyStruct>..cctor
	|
	|-RVA: 0x1AFFEE0 Offset: 0x1AFE4E0 VA: 0x181AFFEE0
	|-EnumHelper.Caster<uint, double>..cctor
	|
	|-RVA: 0x1AFEEB0 Offset: 0x1AFD4B0 VA: 0x181AFEEB0
	|-EnumHelper.Caster<uint, Guid>..cctor
	|
	|-RVA: 0x1AF7420 Offset: 0x1AF5A20 VA: 0x181AF7420
	|-EnumHelper.Caster<uint, short>..cctor
	|
	|-RVA: 0x1AFB040 Offset: 0x1AF9640 VA: 0x181AFB040
	|-EnumHelper.Caster<uint, int>..cctor
	|
	|-RVA: 0x1B005D0 Offset: 0x1AFEBD0 VA: 0x181B005D0
	|-EnumHelper.Caster<uint, long>..cctor
	|
	|-RVA: 0x1B04690 Offset: 0x1B02C90 VA: 0x181B04690
	|-EnumHelper.Caster<uint, IntPtr>..cctor
	|
	|-RVA: 0x1B0BED0 Offset: 0x1B0A4D0 VA: 0x181B0BED0
	|-EnumHelper.Caster<uint, object>..cctor
	|
	|-RVA: 0x1AF8200 Offset: 0x1AF6800 VA: 0x181AF8200
	|-EnumHelper.Caster<uint, sbyte>..cctor
	|
	|-RVA: 0x1B0DF30 Offset: 0x1B0C530 VA: 0x181B0DF30
	|-EnumHelper.Caster<uint, float>..cctor
	|
	|-RVA: 0x1AFA260 Offset: 0x1AF8860 VA: 0x181AFA260
	|-EnumHelper.Caster<uint, TimeSpan>..cctor
	|
	|-RVA: 0x1AFE570 Offset: 0x1AFCB70 VA: 0x181AFE570
	|-EnumHelper.Caster<uint, ushort>..cctor
	|
	|-RVA: 0x1AF6640 Offset: 0x1AF4C40 VA: 0x181AF6640
	|-EnumHelper.Caster<uint, uint>..cctor
	|
	|-RVA: 0x1AF78C0 Offset: 0x1AF5EC0 VA: 0x181AF78C0
	|-EnumHelper.Caster<uint, ulong>..cctor
	|
	|-RVA: 0x1AFA700 Offset: 0x1AF8D00 VA: 0x181AFA700
	|-EnumHelper.Caster<uint, UIntPtr>..cctor
	|
	|-RVA: 0x1B0D840 Offset: 0x1B0BE40 VA: 0x181B0D840
	|-EnumHelper.Caster<ulong, bool>..cctor
	|
	|-RVA: 0x1B0BC80 Offset: 0x1B0A280 VA: 0x181B0BC80
	|-EnumHelper.Caster<ulong, byte>..cctor
	|
	|-RVA: 0x1B0D3A0 Offset: 0x1B0B9A0 VA: 0x181B0D3A0
	|-EnumHelper.Caster<ulong, char>..cctor
	|
	|-RVA: 0x1B089A0 Offset: 0x1B06FA0 VA: 0x181B089A0
	|-EnumHelper.Caster<ulong, KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x1AFF350 Offset: 0x1AFD950 VA: 0x181AFF350
	|-EnumHelper.Caster<ulong, DateTime>..cctor
	|
	|-RVA: 0x1B07E10 Offset: 0x1B06410 VA: 0x181B07E10
	|-EnumHelper.Caster<ulong, DateTimeOffset>..cctor
	|
	|-RVA: 0x1B056C0 Offset: 0x1B03CC0 VA: 0x181B056C0
	|-EnumHelper.Caster<ulong, Decimal>..cctor
	|
	|-RVA: 0x1AF8B40 Offset: 0x1AF7140 VA: 0x181AF8B40
	|-EnumHelper.Caster<ulong, EmptyStruct>..cctor
	|
	|-RVA: 0x1B0CCB0 Offset: 0x1B0B2B0 VA: 0x181B0CCB0
	|-EnumHelper.Caster<ulong, double>..cctor
	|
	|-RVA: 0x1AF9920 Offset: 0x1AF7F20 VA: 0x181AF9920
	|-EnumHelper.Caster<ulong, Guid>..cctor
	|
	|-RVA: 0x1B09C20 Offset: 0x1B08220 VA: 0x181B09C20
	|-EnumHelper.Caster<ulong, short>..cctor
	|
	|-RVA: 0x1B0D5F0 Offset: 0x1B0BBF0 VA: 0x181B0D5F0
	|-EnumHelper.Caster<ulong, int>..cctor
	|
	|-RVA: 0x1AFCC00 Offset: 0x1AFB200 VA: 0x181AFCC00
	|-EnumHelper.Caster<ulong, long>..cctor
	|
	|-RVA: 0x1B07280 Offset: 0x1B05880 VA: 0x181B07280
	|-EnumHelper.Caster<ulong, IntPtr>..cctor
	|
	|-RVA: 0x1B03410 Offset: 0x1B01A10 VA: 0x181B03410
	|-EnumHelper.Caster<ulong, object>..cctor
	|
	|-RVA: 0x1B0ED10 Offset: 0x1B0D310 VA: 0x181B0ED10
	|-EnumHelper.Caster<ulong, sbyte>..cctor
	|
	|-RVA: 0x1AFBBD0 Offset: 0x1AFA1D0 VA: 0x181AFBBD0
	|-EnumHelper.Caster<ulong, float>..cctor
	|
	|-RVA: 0x1B01160 Offset: 0x1AFF760 VA: 0x181B01160
	|-EnumHelper.Caster<ulong, TimeSpan>..cctor
	|
	|-RVA: 0x1B03D50 Offset: 0x1B02350 VA: 0x181B03D50
	|-EnumHelper.Caster<ulong, ushort>..cctor
	|
	|-RVA: 0x1B08E40 Offset: 0x1B07440 VA: 0x181B08E40
	|-EnumHelper.Caster<ulong, uint>..cctor
	|
	|-RVA: 0x1B0E3D0 Offset: 0x1B0C9D0 VA: 0x181B0E3D0
	|-EnumHelper.Caster<ulong, ulong>..cctor
	|
	|-RVA: 0x1B02D20 Offset: 0x1B01320 VA: 0x181B02D20
	|-EnumHelper.Caster<ulong, UIntPtr>..cctor
	*/

}

internal sealed class EnumerableTypeInfo<IterableType, ElementType> : TraceLoggingTypeInfo<IterableType> // TypeDefIndex: 1514
{	private readonly TraceLoggingTypeInfo<ElementType> elementInfo; // 0x0


	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B4EA70 Offset: 0x1B4D070 VA: 0x181B4EA70
	|-EnumerableTypeInfo<object, object>.WriteMetadata
	*/

	public override void WriteData(TraceLoggingDataCollector collector, ref IterableType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B4E750 Offset: 0x1B4CD50 VA: 0x181B4E750
	|-EnumerableTypeInfo<object, object>.WriteData
	*/

}

internal sealed class EnumByteTypeInfo<EnumType> : TraceLoggingTypeInfo<EnumType> // TypeDefIndex: 1560
{
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B13270 Offset: 0x1B11870 VA: 0x181B13270
	|-EnumByteTypeInfo<bool>.WriteMetadata
	|
	|-RVA: 0x1B13540 Offset: 0x1B11B40 VA: 0x181B13540
	|-EnumByteTypeInfo<byte>.WriteMetadata
	|
	|-RVA: 0x1B134B0 Offset: 0x1B11AB0 VA: 0x181B134B0
	|-EnumByteTypeInfo<char>.WriteMetadata
	|
	|-RVA: 0x1B13780 Offset: 0x1B11D80 VA: 0x181B13780
	|-EnumByteTypeInfo<KeyValuePair<object, object>>.WriteMetadata
	|
	|-RVA: 0x1B138A0 Offset: 0x1B11EA0 VA: 0x181B138A0
	|-EnumByteTypeInfo<DateTime>.WriteMetadata
	|
	|-RVA: 0x1B13660 Offset: 0x1B11C60 VA: 0x181B13660
	|-EnumByteTypeInfo<DateTimeOffset>.WriteMetadata
	|
	|-RVA: 0x1B135D0 Offset: 0x1B11BD0 VA: 0x181B135D0
	|-EnumByteTypeInfo<Decimal>.WriteMetadata
	|
	|-RVA: 0x1B13930 Offset: 0x1B11F30 VA: 0x181B13930
	|-EnumByteTypeInfo<EmptyStruct>.WriteMetadata
	|
	|-RVA: 0x1B136F0 Offset: 0x1B11CF0 VA: 0x181B136F0
	|-EnumByteTypeInfo<double>.WriteMetadata
	|
	|-RVA: 0x1B13300 Offset: 0x1B11900 VA: 0x181B13300
	|-EnumByteTypeInfo<Guid>.WriteMetadata
	|
	|-RVA: 0x1B139C0 Offset: 0x1B11FC0 VA: 0x181B139C0
	|-EnumByteTypeInfo<short>.WriteMetadata
	|
	|-RVA: 0x1B13D20 Offset: 0x1B12320 VA: 0x181B13D20
	|-EnumByteTypeInfo<int>.WriteMetadata
	|
	|-RVA: 0x1B13C90 Offset: 0x1B12290 VA: 0x181B13C90
	|-EnumByteTypeInfo<long>.WriteMetadata
	|
	|-RVA: 0x1B13C00 Offset: 0x1B12200 VA: 0x181B13C00
	|-EnumByteTypeInfo<IntPtr>.WriteMetadata
	|
	|-RVA: 0x1B131E0 Offset: 0x1B117E0 VA: 0x181B131E0
	|-EnumByteTypeInfo<object>.WriteMetadata
	|
	|-RVA: 0x1B13AE0 Offset: 0x1B120E0 VA: 0x181B13AE0
	|-EnumByteTypeInfo<sbyte>.WriteMetadata
	|
	|-RVA: 0x1B13390 Offset: 0x1B11990 VA: 0x181B13390
	|-EnumByteTypeInfo<float>.WriteMetadata
	|
	|-RVA: 0x1B13A50 Offset: 0x1B12050 VA: 0x181B13A50
	|-EnumByteTypeInfo<TimeSpan>.WriteMetadata
	|
	|-RVA: 0x1B13420 Offset: 0x1B11A20 VA: 0x181B13420
	|-EnumByteTypeInfo<ushort>.WriteMetadata
	|
	|-RVA: 0x1B13B70 Offset: 0x1B12170 VA: 0x181B13B70
	|-EnumByteTypeInfo<uint>.WriteMetadata
	|
	|-RVA: 0x1B13DB0 Offset: 0x1B123B0 VA: 0x181B13DB0
	|-EnumByteTypeInfo<ulong>.WriteMetadata
	|
	|-RVA: 0x1B13810 Offset: 0x1B11E10 VA: 0x181B13810
	|-EnumByteTypeInfo<UIntPtr>.WriteMetadata
	*/

	public override void WriteData(TraceLoggingDataCollector collector, ref EnumType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B12600 Offset: 0x1B10C00 VA: 0x181B12600
	|-EnumByteTypeInfo<bool>.WriteData
	|
	|-RVA: 0x1B12CD0 Offset: 0x1B112D0 VA: 0x181B12CD0
	|-EnumByteTypeInfo<byte>.WriteData
	|
	|-RVA: 0x1B12740 Offset: 0x1B10D40 VA: 0x181B12740
	|-EnumByteTypeInfo<char>.WriteData
	|
	|-RVA: 0x1B124B0 Offset: 0x1B10AB0 VA: 0x181B124B0
	|-EnumByteTypeInfo<KeyValuePair<object, object>>.WriteData
	|
	|-RVA: 0x1B12B00 Offset: 0x1B11100 VA: 0x181B12B00
	|-EnumByteTypeInfo<DateTime>.WriteData
	|
	|-RVA: 0x1B12400 Offset: 0x1B10A00 VA: 0x181B12400
	|-EnumByteTypeInfo<DateTimeOffset>.WriteData
	|
	|-RVA: 0x1B129B0 Offset: 0x1B10FB0 VA: 0x181B129B0
	|-EnumByteTypeInfo<Decimal>.WriteData
	|
	|-RVA: 0x1B12910 Offset: 0x1B10F10 VA: 0x181B12910
	|-EnumByteTypeInfo<EmptyStruct>.WriteData
	|
	|-RVA: 0x1B127E0 Offset: 0x1B10DE0 VA: 0x181B127E0
	|-EnumByteTypeInfo<double>.WriteData
	|
	|-RVA: 0x1B12D70 Offset: 0x1B11370 VA: 0x181B12D70
	|-EnumByteTypeInfo<Guid>.WriteData
	|
	|-RVA: 0x1B126A0 Offset: 0x1B10CA0 VA: 0x181B126A0
	|-EnumByteTypeInfo<short>.WriteData
	|
	|-RVA: 0x1B12880 Offset: 0x1B10E80 VA: 0x181B12880
	|-EnumByteTypeInfo<int>.WriteData
	|
	|-RVA: 0x1B130A0 Offset: 0x1B116A0 VA: 0x181B130A0
	|-EnumByteTypeInfo<long>.WriteData
	|
	|-RVA: 0x1B13140 Offset: 0x1B11740 VA: 0x181B13140
	|-EnumByteTypeInfo<IntPtr>.WriteData
	|
	|-RVA: 0x1B13000 Offset: 0x1B11600 VA: 0x181B13000
	|-EnumByteTypeInfo<object>.WriteData
	|
	|-RVA: 0x1B12560 Offset: 0x1B10B60 VA: 0x181B12560
	|-EnumByteTypeInfo<sbyte>.WriteData
	|
	|-RVA: 0x1B12EC0 Offset: 0x1B114C0 VA: 0x181B12EC0
	|-EnumByteTypeInfo<float>.WriteData
	|
	|-RVA: 0x1B12E20 Offset: 0x1B11420 VA: 0x181B12E20
	|-EnumByteTypeInfo<TimeSpan>.WriteData
	|
	|-RVA: 0x1B12C30 Offset: 0x1B11230 VA: 0x181B12C30
	|-EnumByteTypeInfo<ushort>.WriteData
	|
	|-RVA: 0x1B12BA0 Offset: 0x1B111A0 VA: 0x181B12BA0
	|-EnumByteTypeInfo<uint>.WriteData
	|
	|-RVA: 0x1B12F60 Offset: 0x1B11560 VA: 0x181B12F60
	|-EnumByteTypeInfo<ulong>.WriteData
	|
	|-RVA: 0x1B12A60 Offset: 0x1B11060 VA: 0x181B12A60
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
	|-RVA: 0x19AD460 Offset: 0x19ABA60 VA: 0x1819AD460
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
	|-RVA: 0x2139E40 Offset: 0x2138440 VA: 0x182139E40
	|-EnumSByteTypeInfo<bool>.WriteMetadata
	|
	|-RVA: 0x213A080 Offset: 0x2138680 VA: 0x18213A080
	|-EnumSByteTypeInfo<byte>.WriteMetadata
	|
	|-RVA: 0x213A3E0 Offset: 0x21389E0 VA: 0x18213A3E0
	|-EnumSByteTypeInfo<char>.WriteMetadata
	|
	|-RVA: 0x213A1A0 Offset: 0x21387A0 VA: 0x18213A1A0
	|-EnumSByteTypeInfo<KeyValuePair<object, object>>.WriteMetadata
	|
	|-RVA: 0x213A470 Offset: 0x2138A70 VA: 0x18213A470
	|-EnumSByteTypeInfo<DateTime>.WriteMetadata
	|
	|-RVA: 0x2139DB0 Offset: 0x21383B0 VA: 0x182139DB0
	|-EnumSByteTypeInfo<DateTimeOffset>.WriteMetadata
	|
	|-RVA: 0x213A7D0 Offset: 0x2138DD0 VA: 0x18213A7D0
	|-EnumSByteTypeInfo<Decimal>.WriteMetadata
	|
	|-RVA: 0x213A590 Offset: 0x2138B90 VA: 0x18213A590
	|-EnumSByteTypeInfo<EmptyStruct>.WriteMetadata
	|
	|-RVA: 0x2139C90 Offset: 0x2138290 VA: 0x182139C90
	|-EnumSByteTypeInfo<double>.WriteMetadata
	|
	|-RVA: 0x213A500 Offset: 0x2138B00 VA: 0x18213A500
	|-EnumSByteTypeInfo<Guid>.WriteMetadata
	|
	|-RVA: 0x213A620 Offset: 0x2138C20 VA: 0x18213A620
	|-EnumSByteTypeInfo<short>.WriteMetadata
	|
	|-RVA: 0x2139ED0 Offset: 0x21384D0 VA: 0x182139ED0
	|-EnumSByteTypeInfo<int>.WriteMetadata
	|
	|-RVA: 0x213A230 Offset: 0x2138830 VA: 0x18213A230
	|-EnumSByteTypeInfo<long>.WriteMetadata
	|
	|-RVA: 0x2139D20 Offset: 0x2138320 VA: 0x182139D20
	|-EnumSByteTypeInfo<IntPtr>.WriteMetadata
	|
	|-RVA: 0x213A110 Offset: 0x2138710 VA: 0x18213A110
	|-EnumSByteTypeInfo<object>.WriteMetadata
	|
	|-RVA: 0x213A2C0 Offset: 0x21388C0 VA: 0x18213A2C0
	|-EnumSByteTypeInfo<sbyte>.WriteMetadata
	|
	|-RVA: 0x213A350 Offset: 0x2138950 VA: 0x18213A350
	|-EnumSByteTypeInfo<float>.WriteMetadata
	|
	|-RVA: 0x213A740 Offset: 0x2138D40 VA: 0x18213A740
	|-EnumSByteTypeInfo<TimeSpan>.WriteMetadata
	|
	|-RVA: 0x213A6B0 Offset: 0x2138CB0 VA: 0x18213A6B0
	|-EnumSByteTypeInfo<ushort>.WriteMetadata
	|
	|-RVA: 0x2139F60 Offset: 0x2138560 VA: 0x182139F60
	|-EnumSByteTypeInfo<uint>.WriteMetadata
	|
	|-RVA: 0x2139FF0 Offset: 0x21385F0 VA: 0x182139FF0
	|-EnumSByteTypeInfo<ulong>.WriteMetadata
	|
	|-RVA: 0x1B49800 Offset: 0x1B47E00 VA: 0x181B49800
	|-EnumSByteTypeInfo<UIntPtr>.WriteMetadata
	*/

	public override void WriteData(TraceLoggingDataCollector collector, ref EnumType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2139960 Offset: 0x2137F60 VA: 0x182139960
	|-EnumSByteTypeInfo<bool>.WriteData
	|
	|-RVA: 0x2139B50 Offset: 0x2138150 VA: 0x182139B50
	|-EnumSByteTypeInfo<byte>.WriteData
	|
	|-RVA: 0x2139260 Offset: 0x2137860 VA: 0x182139260
	|-EnumSByteTypeInfo<char>.WriteData
	|
	|-RVA: 0x21394F0 Offset: 0x2137AF0 VA: 0x1821394F0
	|-EnumSByteTypeInfo<KeyValuePair<object, object>>.WriteData
	|
	|-RVA: 0x2139A00 Offset: 0x2138000 VA: 0x182139A00
	|-EnumSByteTypeInfo<DateTime>.WriteData
	|
	|-RVA: 0x2139AA0 Offset: 0x21380A0 VA: 0x182139AA0
	|-EnumSByteTypeInfo<DateTimeOffset>.WriteData
	|
	|-RVA: 0x21393A0 Offset: 0x21379A0 VA: 0x1821393A0
	|-EnumSByteTypeInfo<Decimal>.WriteData
	|
	|-RVA: 0x2139450 Offset: 0x2137A50 VA: 0x182139450
	|-EnumSByteTypeInfo<EmptyStruct>.WriteData
	|
	|-RVA: 0x21398C0 Offset: 0x2137EC0 VA: 0x1821398C0
	|-EnumSByteTypeInfo<double>.WriteData
	|
	|-RVA: 0x21396E0 Offset: 0x2137CE0 VA: 0x1821396E0
	|-EnumSByteTypeInfo<Guid>.WriteData
	|
	|-RVA: 0x2139790 Offset: 0x2137D90 VA: 0x182139790
	|-EnumSByteTypeInfo<short>.WriteData
	|
	|-RVA: 0x2139090 Offset: 0x2137690 VA: 0x182139090
	|-EnumSByteTypeInfo<int>.WriteData
	|
	|-RVA: 0x21391C0 Offset: 0x21377C0 VA: 0x1821391C0
	|-EnumSByteTypeInfo<long>.WriteData
	|
	|-RVA: 0x21395A0 Offset: 0x2137BA0 VA: 0x1821395A0
	|-EnumSByteTypeInfo<IntPtr>.WriteData
	|
	|-RVA: 0x2139120 Offset: 0x2137720 VA: 0x182139120
	|-EnumSByteTypeInfo<object>.WriteData
	|
	|-RVA: 0x2138FF0 Offset: 0x21375F0 VA: 0x182138FF0
	|-EnumSByteTypeInfo<sbyte>.WriteData
	|
	|-RVA: 0x2139BF0 Offset: 0x21381F0 VA: 0x182139BF0
	|-EnumSByteTypeInfo<float>.WriteData
	|
	|-RVA: 0x2138F50 Offset: 0x2137550 VA: 0x182138F50
	|-EnumSByteTypeInfo<TimeSpan>.WriteData
	|
	|-RVA: 0x2139640 Offset: 0x2137C40 VA: 0x182139640
	|-EnumSByteTypeInfo<ushort>.WriteData
	|
	|-RVA: 0x2139830 Offset: 0x2137E30 VA: 0x182139830
	|-EnumSByteTypeInfo<uint>.WriteData
	|
	|-RVA: 0x2139300 Offset: 0x2137900 VA: 0x182139300
	|-EnumSByteTypeInfo<ulong>.WriteData
	|
	|-RVA: 0x1B49760 Offset: 0x1B47D60 VA: 0x181B49760
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
	|-RVA: 0x19AD460 Offset: 0x19ABA60 VA: 0x1819AD460
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
	|-RVA: 0x21354A0 Offset: 0x2133AA0 VA: 0x1821354A0
	|-EnumInt16TypeInfo<bool>.WriteMetadata
	|
	|-RVA: 0x2135140 Offset: 0x2133740 VA: 0x182135140
	|-EnumInt16TypeInfo<byte>.WriteMetadata
	|
	|-RVA: 0x21356E0 Offset: 0x2133CE0 VA: 0x1821356E0
	|-EnumInt16TypeInfo<char>.WriteMetadata
	|
	|-RVA: 0x2135260 Offset: 0x2133860 VA: 0x182135260
	|-EnumInt16TypeInfo<KeyValuePair<object, object>>.WriteMetadata
	|
	|-RVA: 0x2135890 Offset: 0x2133E90 VA: 0x182135890
	|-EnumInt16TypeInfo<DateTime>.WriteMetadata
	|
	|-RVA: 0x2135770 Offset: 0x2133D70 VA: 0x182135770
	|-EnumInt16TypeInfo<DateTimeOffset>.WriteMetadata
	|
	|-RVA: 0x2134E70 Offset: 0x2133470 VA: 0x182134E70
	|-EnumInt16TypeInfo<Decimal>.WriteMetadata
	|
	|-RVA: 0x2135A40 Offset: 0x2134040 VA: 0x182135A40
	|-EnumInt16TypeInfo<EmptyStruct>.WriteMetadata
	|
	|-RVA: 0x21350B0 Offset: 0x21336B0 VA: 0x1821350B0
	|-EnumInt16TypeInfo<double>.WriteMetadata
	|
	|-RVA: 0x21359B0 Offset: 0x2133FB0 VA: 0x1821359B0
	|-EnumInt16TypeInfo<Guid>.WriteMetadata
	|
	|-RVA: 0x2135530 Offset: 0x2133B30 VA: 0x182135530
	|-EnumInt16TypeInfo<short>.WriteMetadata
	|
	|-RVA: 0x2135800 Offset: 0x2133E00 VA: 0x182135800
	|-EnumInt16TypeInfo<int>.WriteMetadata
	|
	|-RVA: 0x2135920 Offset: 0x2133F20 VA: 0x182135920
	|-EnumInt16TypeInfo<long>.WriteMetadata
	|
	|-RVA: 0x2134F00 Offset: 0x2133500 VA: 0x182134F00
	|-EnumInt16TypeInfo<IntPtr>.WriteMetadata
	|
	|-RVA: 0x2135650 Offset: 0x2133C50 VA: 0x182135650
	|-EnumInt16TypeInfo<object>.WriteMetadata
	|
	|-RVA: 0x2135020 Offset: 0x2133620 VA: 0x182135020
	|-EnumInt16TypeInfo<sbyte>.WriteMetadata
	|
	|-RVA: 0x2135380 Offset: 0x2133980 VA: 0x182135380
	|-EnumInt16TypeInfo<float>.WriteMetadata
	|
	|-RVA: 0x2135410 Offset: 0x2133A10 VA: 0x182135410
	|-EnumInt16TypeInfo<TimeSpan>.WriteMetadata
	|
	|-RVA: 0x21352F0 Offset: 0x21338F0 VA: 0x1821352F0
	|-EnumInt16TypeInfo<ushort>.WriteMetadata
	|
	|-RVA: 0x2134F90 Offset: 0x2133590 VA: 0x182134F90
	|-EnumInt16TypeInfo<uint>.WriteMetadata
	|
	|-RVA: 0x21355C0 Offset: 0x2133BC0 VA: 0x1821355C0
	|-EnumInt16TypeInfo<ulong>.WriteMetadata
	|
	|-RVA: 0x21351D0 Offset: 0x21337D0 VA: 0x1821351D0
	|-EnumInt16TypeInfo<UIntPtr>.WriteMetadata
	*/

	public override void WriteData(TraceLoggingDataCollector collector, ref EnumType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2134120 Offset: 0x2132720 VA: 0x182134120
	|-EnumInt16TypeInfo<bool>.WriteData
	|
	|-RVA: 0x2134260 Offset: 0x2132860 VA: 0x182134260
	|-EnumInt16TypeInfo<byte>.WriteData
	|
	|-RVA: 0x2134950 Offset: 0x2132F50 VA: 0x182134950
	|-EnumInt16TypeInfo<char>.WriteData
	|
	|-RVA: 0x2134C80 Offset: 0x2133280 VA: 0x182134C80
	|-EnumInt16TypeInfo<KeyValuePair<object, object>>.WriteData
	|
	|-RVA: 0x21343A0 Offset: 0x21329A0 VA: 0x1821343A0
	|-EnumInt16TypeInfo<DateTime>.WriteData
	|
	|-RVA: 0x21344E0 Offset: 0x2132AE0 VA: 0x1821344E0
	|-EnumInt16TypeInfo<DateTimeOffset>.WriteData
	|
	|-RVA: 0x21349F0 Offset: 0x2132FF0 VA: 0x1821349F0
	|-EnumInt16TypeInfo<Decimal>.WriteData
	|
	|-RVA: 0x2134810 Offset: 0x2132E10 VA: 0x182134810
	|-EnumInt16TypeInfo<EmptyStruct>.WriteData
	|
	|-RVA: 0x2134590 Offset: 0x2132B90 VA: 0x182134590
	|-EnumInt16TypeInfo<double>.WriteData
	|
	|-RVA: 0x2134AA0 Offset: 0x21330A0 VA: 0x182134AA0
	|-EnumInt16TypeInfo<Guid>.WriteData
	|
	|-RVA: 0x2134630 Offset: 0x2132C30 VA: 0x182134630
	|-EnumInt16TypeInfo<short>.WriteData
	|
	|-RVA: 0x2134090 Offset: 0x2132690 VA: 0x182134090
	|-EnumInt16TypeInfo<int>.WriteData
	|
	|-RVA: 0x2134D30 Offset: 0x2133330 VA: 0x182134D30
	|-EnumInt16TypeInfo<long>.WriteData
	|
	|-RVA: 0x21346D0 Offset: 0x2132CD0 VA: 0x1821346D0
	|-EnumInt16TypeInfo<IntPtr>.WriteData
	|
	|-RVA: 0x2134300 Offset: 0x2132900 VA: 0x182134300
	|-EnumInt16TypeInfo<object>.WriteData
	|
	|-RVA: 0x2134DD0 Offset: 0x21333D0 VA: 0x182134DD0
	|-EnumInt16TypeInfo<sbyte>.WriteData
	|
	|-RVA: 0x2134440 Offset: 0x2132A40 VA: 0x182134440
	|-EnumInt16TypeInfo<float>.WriteData
	|
	|-RVA: 0x21348B0 Offset: 0x2132EB0 VA: 0x1821348B0
	|-EnumInt16TypeInfo<TimeSpan>.WriteData
	|
	|-RVA: 0x2134B50 Offset: 0x2133150 VA: 0x182134B50
	|-EnumInt16TypeInfo<ushort>.WriteData
	|
	|-RVA: 0x2134BF0 Offset: 0x21331F0 VA: 0x182134BF0
	|-EnumInt16TypeInfo<uint>.WriteData
	|
	|-RVA: 0x21341C0 Offset: 0x21327C0 VA: 0x1821341C0
	|-EnumInt16TypeInfo<ulong>.WriteData
	|
	|-RVA: 0x2134770 Offset: 0x2132D70 VA: 0x182134770
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
	|-RVA: 0x19AD460 Offset: 0x19ABA60 VA: 0x1819AD460
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
	|-RVA: 0x1B4AB80 Offset: 0x1B49180 VA: 0x181B4AB80
	|-EnumUInt16TypeInfo<bool>.WriteMetadata
	|
	|-RVA: 0x1B4ACA0 Offset: 0x1B492A0 VA: 0x181B4ACA0
	|-EnumUInt16TypeInfo<byte>.WriteMetadata
	|
	|-RVA: 0x1B4B090 Offset: 0x1B49690 VA: 0x181B4B090
	|-EnumUInt16TypeInfo<char>.WriteMetadata
	|
	|-RVA: 0x1B4AF70 Offset: 0x1B49570 VA: 0x181B4AF70
	|-EnumUInt16TypeInfo<KeyValuePair<object, object>>.WriteMetadata
	|
	|-RVA: 0x1B4AD30 Offset: 0x1B49330 VA: 0x181B4AD30
	|-EnumUInt16TypeInfo<DateTime>.WriteMetadata
	|
	|-RVA: 0x1B4AA60 Offset: 0x1B49060 VA: 0x181B4AA60
	|-EnumUInt16TypeInfo<DateTimeOffset>.WriteMetadata
	|
	|-RVA: 0x1B4B1B0 Offset: 0x1B497B0 VA: 0x181B4B1B0
	|-EnumUInt16TypeInfo<Decimal>.WriteMetadata
	|
	|-RVA: 0x1B4AE50 Offset: 0x1B49450 VA: 0x181B4AE50
	|-EnumUInt16TypeInfo<EmptyStruct>.WriteMetadata
	|
	|-RVA: 0x1B4A700 Offset: 0x1B48D00 VA: 0x181B4A700
	|-EnumUInt16TypeInfo<double>.WriteMetadata
	|
	|-RVA: 0x1B4A940 Offset: 0x1B48F40 VA: 0x181B4A940
	|-EnumUInt16TypeInfo<Guid>.WriteMetadata
	|
	|-RVA: 0x1B4A790 Offset: 0x1B48D90 VA: 0x181B4A790
	|-EnumUInt16TypeInfo<short>.WriteMetadata
	|
	|-RVA: 0x1B4ADC0 Offset: 0x1B493C0 VA: 0x181B4ADC0
	|-EnumUInt16TypeInfo<int>.WriteMetadata
	|
	|-RVA: 0x1B4A670 Offset: 0x1B48C70 VA: 0x181B4A670
	|-EnumUInt16TypeInfo<long>.WriteMetadata
	|
	|-RVA: 0x1B4A820 Offset: 0x1B48E20 VA: 0x181B4A820
	|-EnumUInt16TypeInfo<IntPtr>.WriteMetadata
	|
	|-RVA: 0x1B4B000 Offset: 0x1B49600 VA: 0x181B4B000
	|-EnumUInt16TypeInfo<object>.WriteMetadata
	|
	|-RVA: 0x1B4A8B0 Offset: 0x1B48EB0 VA: 0x181B4A8B0
	|-EnumUInt16TypeInfo<sbyte>.WriteMetadata
	|
	|-RVA: 0x1B4B240 Offset: 0x1B49840 VA: 0x181B4B240
	|-EnumUInt16TypeInfo<float>.WriteMetadata
	|
	|-RVA: 0x1B4A9D0 Offset: 0x1B48FD0 VA: 0x181B4A9D0
	|-EnumUInt16TypeInfo<TimeSpan>.WriteMetadata
	|
	|-RVA: 0x1B4AC10 Offset: 0x1B49210 VA: 0x181B4AC10
	|-EnumUInt16TypeInfo<ushort>.WriteMetadata
	|
	|-RVA: 0x1B4AAF0 Offset: 0x1B490F0 VA: 0x181B4AAF0
	|-EnumUInt16TypeInfo<uint>.WriteMetadata
	|
	|-RVA: 0x1B4B120 Offset: 0x1B49720 VA: 0x181B4B120
	|-EnumUInt16TypeInfo<ulong>.WriteMetadata
	|
	|-RVA: 0x1B4AEE0 Offset: 0x1B494E0 VA: 0x181B4AEE0
	|-EnumUInt16TypeInfo<UIntPtr>.WriteMetadata
	*/

	public override void WriteData(TraceLoggingDataCollector collector, ref EnumType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B4A150 Offset: 0x1B48750 VA: 0x181B4A150
	|-EnumUInt16TypeInfo<bool>.WriteData
	|
	|-RVA: 0x1B49D00 Offset: 0x1B48300 VA: 0x181B49D00
	|-EnumUInt16TypeInfo<byte>.WriteData
	|
	|-RVA: 0x1B49C60 Offset: 0x1B48260 VA: 0x181B49C60
	|-EnumUInt16TypeInfo<char>.WriteData
	|
	|-RVA: 0x1B4A520 Offset: 0x1B48B20 VA: 0x181B4A520
	|-EnumUInt16TypeInfo<KeyValuePair<object, object>>.WriteData
	|
	|-RVA: 0x1B49EE0 Offset: 0x1B484E0 VA: 0x181B49EE0
	|-EnumUInt16TypeInfo<DateTime>.WriteData
	|
	|-RVA: 0x1B4A1F0 Offset: 0x1B487F0 VA: 0x181B4A1F0
	|-EnumUInt16TypeInfo<DateTimeOffset>.WriteData
	|
	|-RVA: 0x1B499D0 Offset: 0x1B47FD0 VA: 0x181B499D0
	|-EnumUInt16TypeInfo<Decimal>.WriteData
	|
	|-RVA: 0x1B49890 Offset: 0x1B47E90 VA: 0x181B49890
	|-EnumUInt16TypeInfo<EmptyStruct>.WriteData
	|
	|-RVA: 0x1B49E40 Offset: 0x1B48440 VA: 0x181B49E40
	|-EnumUInt16TypeInfo<double>.WriteData
	|
	|-RVA: 0x1B4A340 Offset: 0x1B48940 VA: 0x181B4A340
	|-EnumUInt16TypeInfo<Guid>.WriteData
	|
	|-RVA: 0x1B49DA0 Offset: 0x1B483A0 VA: 0x181B49DA0
	|-EnumUInt16TypeInfo<short>.WriteData
	|
	|-RVA: 0x1B4A3F0 Offset: 0x1B489F0 VA: 0x181B4A3F0
	|-EnumUInt16TypeInfo<int>.WriteData
	|
	|-RVA: 0x1B49A80 Offset: 0x1B48080 VA: 0x181B49A80
	|-EnumUInt16TypeInfo<long>.WriteData
	|
	|-RVA: 0x1B49BC0 Offset: 0x1B481C0 VA: 0x181B49BC0
	|-EnumUInt16TypeInfo<IntPtr>.WriteData
	|
	|-RVA: 0x1B4A2A0 Offset: 0x1B488A0 VA: 0x181B4A2A0
	|-EnumUInt16TypeInfo<object>.WriteData
	|
	|-RVA: 0x1B4A0B0 Offset: 0x1B486B0 VA: 0x181B4A0B0
	|-EnumUInt16TypeInfo<sbyte>.WriteData
	|
	|-RVA: 0x1B4A5D0 Offset: 0x1B48BD0 VA: 0x181B4A5D0
	|-EnumUInt16TypeInfo<float>.WriteData
	|
	|-RVA: 0x1B49B20 Offset: 0x1B48120 VA: 0x181B49B20
	|-EnumUInt16TypeInfo<TimeSpan>.WriteData
	|
	|-RVA: 0x1B4A480 Offset: 0x1B48A80 VA: 0x181B4A480
	|-EnumUInt16TypeInfo<ushort>.WriteData
	|
	|-RVA: 0x1B49F80 Offset: 0x1B48580 VA: 0x181B49F80
	|-EnumUInt16TypeInfo<uint>.WriteData
	|
	|-RVA: 0x1B4A010 Offset: 0x1B48610 VA: 0x181B4A010
	|-EnumUInt16TypeInfo<ulong>.WriteData
	|
	|-RVA: 0x1B49930 Offset: 0x1B47F30 VA: 0x181B49930
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
	|-RVA: 0x19AD460 Offset: 0x19ABA60 VA: 0x1819AD460
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
	|-RVA: 0x21372D0 Offset: 0x21358D0 VA: 0x1821372D0
	|-EnumInt32TypeInfo<bool>.WriteMetadata
	|
	|-RVA: 0x2137480 Offset: 0x2135A80 VA: 0x182137480
	|-EnumInt32TypeInfo<byte>.WriteMetadata
	|
	|-RVA: 0x2137120 Offset: 0x2135720 VA: 0x182137120
	|-EnumInt32TypeInfo<char>.WriteMetadata
	|
	|-RVA: 0x2136EE0 Offset: 0x21354E0 VA: 0x182136EE0
	|-EnumInt32TypeInfo<KeyValuePair<object, object>>.WriteMetadata
	|
	|-RVA: 0x2136A60 Offset: 0x2135060 VA: 0x182136A60
	|-EnumInt32TypeInfo<DateTime>.WriteMetadata
	|
	|-RVA: 0x2136D30 Offset: 0x2135330 VA: 0x182136D30
	|-EnumInt32TypeInfo<DateTimeOffset>.WriteMetadata
	|
	|-RVA: 0x2136B80 Offset: 0x2135180 VA: 0x182136B80
	|-EnumInt32TypeInfo<Decimal>.WriteMetadata
	|
	|-RVA: 0x2136F70 Offset: 0x2135570 VA: 0x182136F70
	|-EnumInt32TypeInfo<EmptyStruct>.WriteMetadata
	|
	|-RVA: 0x2136DC0 Offset: 0x21353C0 VA: 0x182136DC0
	|-EnumInt32TypeInfo<double>.WriteMetadata
	|
	|-RVA: 0x2136940 Offset: 0x2134F40 VA: 0x182136940
	|-EnumInt32TypeInfo<Guid>.WriteMetadata
	|
	|-RVA: 0x2136C10 Offset: 0x2135210 VA: 0x182136C10
	|-EnumInt32TypeInfo<short>.WriteMetadata
	|
	|-RVA: 0x2136E50 Offset: 0x2135450 VA: 0x182136E50
	|-EnumInt32TypeInfo<int>.WriteMetadata
	|
	|-RVA: 0x21369D0 Offset: 0x2134FD0 VA: 0x1821369D0
	|-EnumInt32TypeInfo<long>.WriteMetadata
	|
	|-RVA: 0x2136AF0 Offset: 0x21350F0 VA: 0x182136AF0
	|-EnumInt32TypeInfo<IntPtr>.WriteMetadata
	|
	|-RVA: 0x2137360 Offset: 0x2135960 VA: 0x182137360
	|-EnumInt32TypeInfo<object>.WriteMetadata
	|
	|-RVA: 0x2137240 Offset: 0x2135840 VA: 0x182137240
	|-EnumInt32TypeInfo<sbyte>.WriteMetadata
	|
	|-RVA: 0x2137090 Offset: 0x2135690 VA: 0x182137090
	|-EnumInt32TypeInfo<float>.WriteMetadata
	|
	|-RVA: 0x21368B0 Offset: 0x2134EB0 VA: 0x1821368B0
	|-EnumInt32TypeInfo<TimeSpan>.WriteMetadata
	|
	|-RVA: 0x2137000 Offset: 0x2135600 VA: 0x182137000
	|-EnumInt32TypeInfo<ushort>.WriteMetadata
	|
	|-RVA: 0x21371B0 Offset: 0x21357B0 VA: 0x1821371B0
	|-EnumInt32TypeInfo<uint>.WriteMetadata
	|
	|-RVA: 0x2136CA0 Offset: 0x21352A0 VA: 0x182136CA0
	|-EnumInt32TypeInfo<ulong>.WriteMetadata
	|
	|-RVA: 0x21373F0 Offset: 0x21359F0 VA: 0x1821373F0
	|-EnumInt32TypeInfo<UIntPtr>.WriteMetadata
	*/

	public override void WriteData(TraceLoggingDataCollector collector, ref EnumType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2135AD0 Offset: 0x21340D0 VA: 0x182135AD0
	|-EnumInt32TypeInfo<bool>.WriteData
	|
	|-RVA: 0x2136810 Offset: 0x2134E10 VA: 0x182136810
	|-EnumInt32TypeInfo<byte>.WriteData
	|
	|-RVA: 0x2136770 Offset: 0x2134D70 VA: 0x182136770
	|-EnumInt32TypeInfo<char>.WriteData
	|
	|-RVA: 0x2135C10 Offset: 0x2134210 VA: 0x182135C10
	|-EnumInt32TypeInfo<KeyValuePair<object, object>>.WriteData
	|
	|-RVA: 0x21361E0 Offset: 0x21347E0 VA: 0x1821361E0
	|-EnumInt32TypeInfo<DateTime>.WriteData
	|
	|-RVA: 0x2135FF0 Offset: 0x21345F0 VA: 0x182135FF0
	|-EnumInt32TypeInfo<DateTimeOffset>.WriteData
	|
	|-RVA: 0x2135CC0 Offset: 0x21342C0 VA: 0x182135CC0
	|-EnumInt32TypeInfo<Decimal>.WriteData
	|
	|-RVA: 0x2136280 Offset: 0x2134880 VA: 0x182136280
	|-EnumInt32TypeInfo<EmptyStruct>.WriteData
	|
	|-RVA: 0x2135D70 Offset: 0x2134370 VA: 0x182135D70
	|-EnumInt32TypeInfo<double>.WriteData
	|
	|-RVA: 0x2136590 Offset: 0x2134B90 VA: 0x182136590
	|-EnumInt32TypeInfo<Guid>.WriteData
	|
	|-RVA: 0x2135E10 Offset: 0x2134410 VA: 0x182135E10
	|-EnumInt32TypeInfo<short>.WriteData
	|
	|-RVA: 0x21366E0 Offset: 0x2134CE0 VA: 0x1821366E0
	|-EnumInt32TypeInfo<int>.WriteData
	|
	|-RVA: 0x2135EB0 Offset: 0x21344B0 VA: 0x182135EB0
	|-EnumInt32TypeInfo<long>.WriteData
	|
	|-RVA: 0x2136640 Offset: 0x2134C40 VA: 0x182136640
	|-EnumInt32TypeInfo<IntPtr>.WriteData
	|
	|-RVA: 0x2136460 Offset: 0x2134A60 VA: 0x182136460
	|-EnumInt32TypeInfo<object>.WriteData
	|
	|-RVA: 0x2135B70 Offset: 0x2134170 VA: 0x182135B70
	|-EnumInt32TypeInfo<sbyte>.WriteData
	|
	|-RVA: 0x2136140 Offset: 0x2134740 VA: 0x182136140
	|-EnumInt32TypeInfo<float>.WriteData
	|
	|-RVA: 0x2136320 Offset: 0x2134920 VA: 0x182136320
	|-EnumInt32TypeInfo<TimeSpan>.WriteData
	|
	|-RVA: 0x21363C0 Offset: 0x21349C0 VA: 0x1821363C0
	|-EnumInt32TypeInfo<ushort>.WriteData
	|
	|-RVA: 0x2136500 Offset: 0x2134B00 VA: 0x182136500
	|-EnumInt32TypeInfo<uint>.WriteData
	|
	|-RVA: 0x21360A0 Offset: 0x21346A0 VA: 0x1821360A0
	|-EnumInt32TypeInfo<ulong>.WriteData
	|
	|-RVA: 0x2135F50 Offset: 0x2134550 VA: 0x182135F50
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
	|-RVA: 0x19AD460 Offset: 0x19ABA60 VA: 0x1819AD460
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
	|-RVA: 0x1B4C920 Offset: 0x1B4AF20 VA: 0x181B4C920
	|-EnumUInt32TypeInfo<bool>.WriteMetadata
	|
	|-RVA: 0x1B4C140 Offset: 0x1B4A740 VA: 0x181B4C140
	|-EnumUInt32TypeInfo<byte>.WriteMetadata
	|
	|-RVA: 0x1B4C650 Offset: 0x1B4AC50 VA: 0x181B4C650
	|-EnumUInt32TypeInfo<char>.WriteMetadata
	|
	|-RVA: 0x1B4C5C0 Offset: 0x1B4ABC0 VA: 0x181B4C5C0
	|-EnumUInt32TypeInfo<KeyValuePair<object, object>>.WriteMetadata
	|
	|-RVA: 0x1B4C770 Offset: 0x1B4AD70 VA: 0x181B4C770
	|-EnumUInt32TypeInfo<DateTime>.WriteMetadata
	|
	|-RVA: 0x1B4C260 Offset: 0x1B4A860 VA: 0x181B4C260
	|-EnumUInt32TypeInfo<DateTimeOffset>.WriteMetadata
	|
	|-RVA: 0x1B4C0B0 Offset: 0x1B4A6B0 VA: 0x181B4C0B0
	|-EnumUInt32TypeInfo<Decimal>.WriteMetadata
	|
	|-RVA: 0x1B4C1D0 Offset: 0x1B4A7D0 VA: 0x181B4C1D0
	|-EnumUInt32TypeInfo<EmptyStruct>.WriteMetadata
	|
	|-RVA: 0x1B4CB60 Offset: 0x1B4B160 VA: 0x181B4CB60
	|-EnumUInt32TypeInfo<double>.WriteMetadata
	|
	|-RVA: 0x1B4C530 Offset: 0x1B4AB30 VA: 0x181B4C530
	|-EnumUInt32TypeInfo<Guid>.WriteMetadata
	|
	|-RVA: 0x1B4C800 Offset: 0x1B4AE00 VA: 0x181B4C800
	|-EnumUInt32TypeInfo<short>.WriteMetadata
	|
	|-RVA: 0x1B4CA40 Offset: 0x1B4B040 VA: 0x181B4CA40
	|-EnumUInt32TypeInfo<int>.WriteMetadata
	|
	|-RVA: 0x1B4C9B0 Offset: 0x1B4AFB0 VA: 0x181B4C9B0
	|-EnumUInt32TypeInfo<long>.WriteMetadata
	|
	|-RVA: 0x1B4C4A0 Offset: 0x1B4AAA0 VA: 0x181B4C4A0
	|-EnumUInt32TypeInfo<IntPtr>.WriteMetadata
	|
	|-RVA: 0x1B4C380 Offset: 0x1B4A980 VA: 0x181B4C380
	|-EnumUInt32TypeInfo<object>.WriteMetadata
	|
	|-RVA: 0x1B4CC80 Offset: 0x1B4B280 VA: 0x181B4CC80
	|-EnumUInt32TypeInfo<sbyte>.WriteMetadata
	|
	|-RVA: 0x1B4C6E0 Offset: 0x1B4ACE0 VA: 0x181B4C6E0
	|-EnumUInt32TypeInfo<float>.WriteMetadata
	|
	|-RVA: 0x1B4CAD0 Offset: 0x1B4B0D0 VA: 0x181B4CAD0
	|-EnumUInt32TypeInfo<TimeSpan>.WriteMetadata
	|
	|-RVA: 0x1B4C410 Offset: 0x1B4AA10 VA: 0x181B4C410
	|-EnumUInt32TypeInfo<ushort>.WriteMetadata
	|
	|-RVA: 0x1B4CBF0 Offset: 0x1B4B1F0 VA: 0x181B4CBF0
	|-EnumUInt32TypeInfo<uint>.WriteMetadata
	|
	|-RVA: 0x1B4C2F0 Offset: 0x1B4A8F0 VA: 0x181B4C2F0
	|-EnumUInt32TypeInfo<ulong>.WriteMetadata
	|
	|-RVA: 0x1B4C890 Offset: 0x1B4AE90 VA: 0x181B4C890
	|-EnumUInt32TypeInfo<UIntPtr>.WriteMetadata
	*/

	public override void WriteData(TraceLoggingDataCollector collector, ref EnumType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B4BCE0 Offset: 0x1B4A2E0 VA: 0x181B4BCE0
	|-EnumUInt32TypeInfo<bool>.WriteData
	|
	|-RVA: 0x1B4B9A0 Offset: 0x1B49FA0 VA: 0x181B4B9A0
	|-EnumUInt32TypeInfo<byte>.WriteData
	|
	|-RVA: 0x1B4B710 Offset: 0x1B49D10 VA: 0x181B4B710
	|-EnumUInt32TypeInfo<char>.WriteData
	|
	|-RVA: 0x1B4BC30 Offset: 0x1B4A230 VA: 0x181B4BC30
	|-EnumUInt32TypeInfo<KeyValuePair<object, object>>.WriteData
	|
	|-RVA: 0x1B4B2D0 Offset: 0x1B498D0 VA: 0x181B4B2D0
	|-EnumUInt32TypeInfo<DateTime>.WriteData
	|
	|-RVA: 0x1B4BEC0 Offset: 0x1B4A4C0 VA: 0x181B4BEC0
	|-EnumUInt32TypeInfo<DateTimeOffset>.WriteData
	|
	|-RVA: 0x1B4BB80 Offset: 0x1B4A180 VA: 0x181B4BB80
	|-EnumUInt32TypeInfo<Decimal>.WriteData
	|
	|-RVA: 0x1B4B530 Offset: 0x1B49B30 VA: 0x181B4B530
	|-EnumUInt32TypeInfo<EmptyStruct>.WriteData
	|
	|-RVA: 0x1B4BD80 Offset: 0x1B4A380 VA: 0x181B4BD80
	|-EnumUInt32TypeInfo<double>.WriteData
	|
	|-RVA: 0x1B4B7B0 Offset: 0x1B49DB0 VA: 0x181B4B7B0
	|-EnumUInt32TypeInfo<Guid>.WriteData
	|
	|-RVA: 0x1B4B370 Offset: 0x1B49970 VA: 0x181B4B370
	|-EnumUInt32TypeInfo<short>.WriteData
	|
	|-RVA: 0x1B4B4A0 Offset: 0x1B49AA0 VA: 0x181B4B4A0
	|-EnumUInt32TypeInfo<int>.WriteData
	|
	|-RVA: 0x1B4B860 Offset: 0x1B49E60 VA: 0x181B4B860
	|-EnumUInt32TypeInfo<long>.WriteData
	|
	|-RVA: 0x1B4BF70 Offset: 0x1B4A570 VA: 0x181B4BF70
	|-EnumUInt32TypeInfo<IntPtr>.WriteData
	|
	|-RVA: 0x1B4BE20 Offset: 0x1B4A420 VA: 0x181B4BE20
	|-EnumUInt32TypeInfo<object>.WriteData
	|
	|-RVA: 0x1B4B670 Offset: 0x1B49C70 VA: 0x181B4B670
	|-EnumUInt32TypeInfo<sbyte>.WriteData
	|
	|-RVA: 0x1B4B900 Offset: 0x1B49F00 VA: 0x181B4B900
	|-EnumUInt32TypeInfo<float>.WriteData
	|
	|-RVA: 0x1B4C010 Offset: 0x1B4A610 VA: 0x181B4C010
	|-EnumUInt32TypeInfo<TimeSpan>.WriteData
	|
	|-RVA: 0x1B4B5D0 Offset: 0x1B49BD0 VA: 0x181B4B5D0
	|-EnumUInt32TypeInfo<ushort>.WriteData
	|
	|-RVA: 0x1B4B410 Offset: 0x1B49A10 VA: 0x181B4B410
	|-EnumUInt32TypeInfo<uint>.WriteData
	|
	|-RVA: 0x1B4BA40 Offset: 0x1B4A040 VA: 0x181B4BA40
	|-EnumUInt32TypeInfo<ulong>.WriteData
	|
	|-RVA: 0x1B4BAE0 Offset: 0x1B4A0E0 VA: 0x181B4BAE0
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
	|-RVA: 0x19AD460 Offset: 0x19ABA60 VA: 0x1819AD460
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
	|-RVA: 0x2138530 Offset: 0x2136B30 VA: 0x182138530
	|-EnumInt64TypeInfo<bool>.WriteMetadata
	|
	|-RVA: 0x2138890 Offset: 0x2136E90 VA: 0x182138890
	|-EnumInt64TypeInfo<byte>.WriteMetadata
	|
	|-RVA: 0x2138A40 Offset: 0x2137040 VA: 0x182138A40
	|-EnumInt64TypeInfo<char>.WriteMetadata
	|
	|-RVA: 0x2138800 Offset: 0x2136E00 VA: 0x182138800
	|-EnumInt64TypeInfo<KeyValuePair<object, object>>.WriteMetadata
	|
	|-RVA: 0x21385C0 Offset: 0x2136BC0 VA: 0x1821385C0
	|-EnumInt64TypeInfo<DateTime>.WriteMetadata
	|
	|-RVA: 0x2138DA0 Offset: 0x21373A0 VA: 0x182138DA0
	|-EnumInt64TypeInfo<DateTimeOffset>.WriteMetadata
	|
	|-RVA: 0x21384A0 Offset: 0x2136AA0 VA: 0x1821384A0
	|-EnumInt64TypeInfo<Decimal>.WriteMetadata
	|
	|-RVA: 0x2138380 Offset: 0x2136980 VA: 0x182138380
	|-EnumInt64TypeInfo<EmptyStruct>.WriteMetadata
	|
	|-RVA: 0x2138770 Offset: 0x2136D70 VA: 0x182138770
	|-EnumInt64TypeInfo<double>.WriteMetadata
	|
	|-RVA: 0x2138920 Offset: 0x2136F20 VA: 0x182138920
	|-EnumInt64TypeInfo<Guid>.WriteMetadata
	|
	|-RVA: 0x2138B60 Offset: 0x2137160 VA: 0x182138B60
	|-EnumInt64TypeInfo<short>.WriteMetadata
	|
	|-RVA: 0x21382F0 Offset: 0x21368F0 VA: 0x1821382F0
	|-EnumInt64TypeInfo<int>.WriteMetadata
	|
	|-RVA: 0x21386E0 Offset: 0x2136CE0 VA: 0x1821386E0
	|-EnumInt64TypeInfo<long>.WriteMetadata
	|
	|-RVA: 0x2138E30 Offset: 0x2137430 VA: 0x182138E30
	|-EnumInt64TypeInfo<IntPtr>.WriteMetadata
	|
	|-RVA: 0x2138AD0 Offset: 0x21370D0 VA: 0x182138AD0
	|-EnumInt64TypeInfo<object>.WriteMetadata
	|
	|-RVA: 0x2138BF0 Offset: 0x21371F0 VA: 0x182138BF0
	|-EnumInt64TypeInfo<sbyte>.WriteMetadata
	|
	|-RVA: 0x2138650 Offset: 0x2136C50 VA: 0x182138650
	|-EnumInt64TypeInfo<float>.WriteMetadata
	|
	|-RVA: 0x2138EC0 Offset: 0x21374C0 VA: 0x182138EC0
	|-EnumInt64TypeInfo<TimeSpan>.WriteMetadata
	|
	|-RVA: 0x2138D10 Offset: 0x2137310 VA: 0x182138D10
	|-EnumInt64TypeInfo<ushort>.WriteMetadata
	|
	|-RVA: 0x2138410 Offset: 0x2136A10 VA: 0x182138410
	|-EnumInt64TypeInfo<uint>.WriteMetadata
	|
	|-RVA: 0x2138C80 Offset: 0x2137280 VA: 0x182138C80
	|-EnumInt64TypeInfo<ulong>.WriteMetadata
	|
	|-RVA: 0x21389B0 Offset: 0x2136FB0 VA: 0x1821389B0
	|-EnumInt64TypeInfo<UIntPtr>.WriteMetadata
	*/

	public override void WriteData(TraceLoggingDataCollector collector, ref EnumType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2138060 Offset: 0x2136660 VA: 0x182138060
	|-EnumInt64TypeInfo<bool>.WriteData
	|
	|-RVA: 0x2137850 Offset: 0x2135E50 VA: 0x182137850
	|-EnumInt64TypeInfo<byte>.WriteData
	|
	|-RVA: 0x2137D50 Offset: 0x2136350 VA: 0x182137D50
	|-EnumInt64TypeInfo<char>.WriteData
	|
	|-RVA: 0x21381A0 Offset: 0x21367A0 VA: 0x1821381A0
	|-EnumInt64TypeInfo<KeyValuePair<object, object>>.WriteData
	|
	|-RVA: 0x21378F0 Offset: 0x2135EF0 VA: 0x1821378F0
	|-EnumInt64TypeInfo<DateTime>.WriteData
	|
	|-RVA: 0x21377A0 Offset: 0x2135DA0 VA: 0x1821377A0
	|-EnumInt64TypeInfo<DateTimeOffset>.WriteData
	|
	|-RVA: 0x2137B60 Offset: 0x2136160 VA: 0x182137B60
	|-EnumInt64TypeInfo<Decimal>.WriteData
	|
	|-RVA: 0x2137660 Offset: 0x2135C60 VA: 0x182137660
	|-EnumInt64TypeInfo<EmptyStruct>.WriteData
	|
	|-RVA: 0x2138250 Offset: 0x2136850 VA: 0x182138250
	|-EnumInt64TypeInfo<double>.WriteData
	|
	|-RVA: 0x21375B0 Offset: 0x2135BB0 VA: 0x1821375B0
	|-EnumInt64TypeInfo<Guid>.WriteData
	|
	|-RVA: 0x2137F20 Offset: 0x2136520 VA: 0x182137F20
	|-EnumInt64TypeInfo<short>.WriteData
	|
	|-RVA: 0x2137DF0 Offset: 0x21363F0 VA: 0x182137DF0
	|-EnumInt64TypeInfo<int>.WriteData
	|
	|-RVA: 0x2137AC0 Offset: 0x21360C0 VA: 0x182137AC0
	|-EnumInt64TypeInfo<long>.WriteData
	|
	|-RVA: 0x2137E80 Offset: 0x2136480 VA: 0x182137E80
	|-EnumInt64TypeInfo<IntPtr>.WriteData
	|
	|-RVA: 0x2137510 Offset: 0x2135B10 VA: 0x182137510
	|-EnumInt64TypeInfo<object>.WriteData
	|
	|-RVA: 0x2137FC0 Offset: 0x21365C0 VA: 0x182137FC0
	|-EnumInt64TypeInfo<sbyte>.WriteData
	|
	|-RVA: 0x2138100 Offset: 0x2136700 VA: 0x182138100
	|-EnumInt64TypeInfo<float>.WriteData
	|
	|-RVA: 0x2137700 Offset: 0x2135D00 VA: 0x182137700
	|-EnumInt64TypeInfo<TimeSpan>.WriteData
	|
	|-RVA: 0x2137CB0 Offset: 0x21362B0 VA: 0x182137CB0
	|-EnumInt64TypeInfo<ushort>.WriteData
	|
	|-RVA: 0x2137A30 Offset: 0x2136030 VA: 0x182137A30
	|-EnumInt64TypeInfo<uint>.WriteData
	|
	|-RVA: 0x2137990 Offset: 0x2135F90 VA: 0x182137990
	|-EnumInt64TypeInfo<ulong>.WriteData
	|
	|-RVA: 0x2137C10 Offset: 0x2136210 VA: 0x182137C10
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
	|-RVA: 0x19AD460 Offset: 0x19ABA60 VA: 0x1819AD460
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
	|-RVA: 0x1B4E630 Offset: 0x1B4CC30 VA: 0x181B4E630
	|-EnumUInt64TypeInfo<bool>.WriteMetadata
	|
	|-RVA: 0x1B4E000 Offset: 0x1B4C600 VA: 0x181B4E000
	|-EnumUInt64TypeInfo<byte>.WriteMetadata
	|
	|-RVA: 0x1B4DD30 Offset: 0x1B4C330 VA: 0x181B4DD30
	|-EnumUInt64TypeInfo<char>.WriteMetadata
	|
	|-RVA: 0x1B4E480 Offset: 0x1B4CA80 VA: 0x181B4E480
	|-EnumUInt64TypeInfo<KeyValuePair<object, object>>.WriteMetadata
	|
	|-RVA: 0x1B4E510 Offset: 0x1B4CB10 VA: 0x181B4E510
	|-EnumUInt64TypeInfo<DateTime>.WriteMetadata
	|
	|-RVA: 0x1B4DE50 Offset: 0x1B4C450 VA: 0x181B4DE50
	|-EnumUInt64TypeInfo<DateTimeOffset>.WriteMetadata
	|
	|-RVA: 0x1B4DC10 Offset: 0x1B4C210 VA: 0x181B4DC10
	|-EnumUInt64TypeInfo<Decimal>.WriteMetadata
	|
	|-RVA: 0x1B4DCA0 Offset: 0x1B4C2A0 VA: 0x181B4DCA0
	|-EnumUInt64TypeInfo<EmptyStruct>.WriteMetadata
	|
	|-RVA: 0x1B4E3F0 Offset: 0x1B4C9F0 VA: 0x181B4E3F0
	|-EnumUInt64TypeInfo<double>.WriteMetadata
	|
	|-RVA: 0x1B4DF70 Offset: 0x1B4C570 VA: 0x181B4DF70
	|-EnumUInt64TypeInfo<Guid>.WriteMetadata
	|
	|-RVA: 0x1B4E360 Offset: 0x1B4C960 VA: 0x181B4E360
	|-EnumUInt64TypeInfo<short>.WriteMetadata
	|
	|-RVA: 0x1B4E1B0 Offset: 0x1B4C7B0 VA: 0x181B4E1B0
	|-EnumUInt64TypeInfo<int>.WriteMetadata
	|
	|-RVA: 0x1B4E6C0 Offset: 0x1B4CCC0 VA: 0x181B4E6C0
	|-EnumUInt64TypeInfo<long>.WriteMetadata
	|
	|-RVA: 0x1B4E2D0 Offset: 0x1B4C8D0 VA: 0x181B4E2D0
	|-EnumUInt64TypeInfo<IntPtr>.WriteMetadata
	|
	|-RVA: 0x1B4DAF0 Offset: 0x1B4C0F0 VA: 0x181B4DAF0
	|-EnumUInt64TypeInfo<object>.WriteMetadata
	|
	|-RVA: 0x1B4DDC0 Offset: 0x1B4C3C0 VA: 0x181B4DDC0
	|-EnumUInt64TypeInfo<sbyte>.WriteMetadata
	|
	|-RVA: 0x1B4E5A0 Offset: 0x1B4CBA0 VA: 0x181B4E5A0
	|-EnumUInt64TypeInfo<float>.WriteMetadata
	|
	|-RVA: 0x1B4E240 Offset: 0x1B4C840 VA: 0x181B4E240
	|-EnumUInt64TypeInfo<TimeSpan>.WriteMetadata
	|
	|-RVA: 0x1B4E090 Offset: 0x1B4C690 VA: 0x181B4E090
	|-EnumUInt64TypeInfo<ushort>.WriteMetadata
	|
	|-RVA: 0x1B4DEE0 Offset: 0x1B4C4E0 VA: 0x181B4DEE0
	|-EnumUInt64TypeInfo<uint>.WriteMetadata
	|
	|-RVA: 0x1B4DB80 Offset: 0x1B4C180 VA: 0x181B4DB80
	|-EnumUInt64TypeInfo<ulong>.WriteMetadata
	|
	|-RVA: 0x1B4E120 Offset: 0x1B4C720 VA: 0x181B4E120
	|-EnumUInt64TypeInfo<UIntPtr>.WriteMetadata
	*/

	public override void WriteData(TraceLoggingDataCollector collector, ref EnumType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B4CF90 Offset: 0x1B4B590 VA: 0x181B4CF90
	|-EnumUInt64TypeInfo<bool>.WriteData
	|
	|-RVA: 0x1B4D180 Offset: 0x1B4B780 VA: 0x181B4D180
	|-EnumUInt64TypeInfo<byte>.WriteData
	|
	|-RVA: 0x1B4CEF0 Offset: 0x1B4B4F0 VA: 0x181B4CEF0
	|-EnumUInt64TypeInfo<char>.WriteData
	|
	|-RVA: 0x1B4D7A0 Offset: 0x1B4BDA0 VA: 0x181B4D7A0
	|-EnumUInt64TypeInfo<KeyValuePair<object, object>>.WriteData
	|
	|-RVA: 0x1B4D700 Offset: 0x1B4BD00 VA: 0x181B4D700
	|-EnumUInt64TypeInfo<DateTime>.WriteData
	|
	|-RVA: 0x1B4D030 Offset: 0x1B4B630 VA: 0x181B4D030
	|-EnumUInt64TypeInfo<DateTimeOffset>.WriteData
	|
	|-RVA: 0x1B4D9A0 Offset: 0x1B4BFA0 VA: 0x181B4D9A0
	|-EnumUInt64TypeInfo<Decimal>.WriteData
	|
	|-RVA: 0x1B4D660 Offset: 0x1B4BC60 VA: 0x181B4D660
	|-EnumUInt64TypeInfo<EmptyStruct>.WriteData
	|
	|-RVA: 0x1B4D490 Offset: 0x1B4BA90 VA: 0x181B4D490
	|-EnumUInt64TypeInfo<double>.WriteData
	|
	|-RVA: 0x1B4D850 Offset: 0x1B4BE50 VA: 0x181B4D850
	|-EnumUInt64TypeInfo<Guid>.WriteData
	|
	|-RVA: 0x1B4D0E0 Offset: 0x1B4B6E0 VA: 0x181B4D0E0
	|-EnumUInt64TypeInfo<short>.WriteData
	|
	|-RVA: 0x1B4D360 Offset: 0x1B4B960 VA: 0x181B4D360
	|-EnumUInt64TypeInfo<int>.WriteData
	|
	|-RVA: 0x1B4D220 Offset: 0x1B4B820 VA: 0x181B4D220
	|-EnumUInt64TypeInfo<long>.WriteData
	|
	|-RVA: 0x1B4DA50 Offset: 0x1B4C050 VA: 0x181B4DA50
	|-EnumUInt64TypeInfo<IntPtr>.WriteData
	|
	|-RVA: 0x1B4D900 Offset: 0x1B4BF00 VA: 0x181B4D900
	|-EnumUInt64TypeInfo<object>.WriteData
	|
	|-RVA: 0x1B4D2C0 Offset: 0x1B4B8C0 VA: 0x181B4D2C0
	|-EnumUInt64TypeInfo<sbyte>.WriteData
	|
	|-RVA: 0x1B4CE50 Offset: 0x1B4B450 VA: 0x181B4CE50
	|-EnumUInt64TypeInfo<float>.WriteData
	|
	|-RVA: 0x1B4D3F0 Offset: 0x1B4B9F0 VA: 0x181B4D3F0
	|-EnumUInt64TypeInfo<TimeSpan>.WriteData
	|
	|-RVA: 0x1B4D530 Offset: 0x1B4BB30 VA: 0x181B4D530
	|-EnumUInt64TypeInfo<ushort>.WriteData
	|
	|-RVA: 0x1B4D5D0 Offset: 0x1B4BBD0 VA: 0x181B4D5D0
	|-EnumUInt64TypeInfo<uint>.WriteData
	|
	|-RVA: 0x1B4CD10 Offset: 0x1B4B310 VA: 0x181B4CD10
	|-EnumUInt64TypeInfo<ulong>.WriteData
	|
	|-RVA: 0x1B4CDB0 Offset: 0x1B4B3B0 VA: 0x181B4CDB0
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
	|-RVA: 0x19AD460 Offset: 0x19ABA60 VA: 0x1819AD460
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
	|-RVA: 0xC8AEE0 Offset: 0xC894E0 VA: 0x180C8AEE0
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
	|-RVA: 0xC86570 Offset: 0xC84B70 VA: 0x180C86570
	|-Enumerable.Select<SkeletonDefinition.Bone, GameObject>
	|-Enumerable.Select<SkeletonDefinition.Bone, Transform>
	|-Enumerable.Select<SkeletonDefinition.Bone, object>
	|
	|-RVA: 0xC8C080 Offset: 0xC8A680 VA: 0x180C8C080
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
	|-RVA: 0xC8ABF0 Offset: 0xC891F0 VA: 0x180C8ABF0
	|-Enumerable.Select<PlayerItemRecipe, IPlayerItemDefinition>
	|-Enumerable.Select<PlayerItemRecipe, object>
	|
	|-RVA: 0xC8BAA0 Offset: 0xC8A0A0 VA: 0x180C8BAA0
	|-Enumerable.Select<ProjectileWeaponMod, ProjectileWeaponMod.Modifier>
	|-Enumerable.Select<object, ProjectileWeaponMod.Modifier>
	|
	|-RVA: 0xC8A320 Offset: 0xC88920 VA: 0x180C8A320
	|-Enumerable.Select<ProjectileWeaponMod.Modifier, float>
	|
	|-RVA: 0xC8B4C0 Offset: 0xC89AC0 VA: 0x180C8B4C0
	|-Enumerable.Select<SteamItem, InventoryItem>
	|-Enumerable.Select<object, InventoryItem>
	|
	|-RVA: 0xC8A610 Offset: 0xC88C10 VA: 0x180C8A610
	|-Enumerable.Select<Option, Option>
	|
	|-RVA: 0xC8BD90 Offset: 0xC8A390 VA: 0x180C8BD90
	|-Enumerable.Select<OptionAttribute, Option>
	|-Enumerable.Select<object, Option>
	|
	|-RVA: 0x4B4EC0 Offset: 0x4B34C0 VA: 0x1804B4EC0
	|-Enumerable.Select<ServerBrowserTag, bool>
	|-Enumerable.Select<object, bool>
	|
	|-RVA: 0xC8C660 Offset: 0xC8AC60 VA: 0x180C8C660
	|-Enumerable.Select<ServerInfo, string>
	|-Enumerable.Select<ServerInfo, object>
	|
	|-RVA: 0xC85CA0 Offset: 0xC842A0 VA: 0x180C85CA0
	|-Enumerable.Select<Achievement, <>f__AnonymousType0<string, string, bool>>
	|-Enumerable.Select<Achievement, object>
	|
	|-RVA: 0xC888B0 Offset: 0xC86EB0 VA: 0x180C888B0
	|-Enumerable.Select<InventoryDefId, InventoryDef>
	|-Enumerable.Select<InventoryDefId, object>
	|
	|-RVA: 0xC8C950 Offset: 0xC8AF50 VA: 0x180C8C950
	|-Enumerable.Select<ServerInfo, ServerInfo>
	|
	|-RVA: 0xC87130 Offset: 0xC85730 VA: 0x180C87130
	|-Enumerable.Select<Friend, SteamPlayer>
	|-Enumerable.Select<Friend, object>
	|
	|-RVA: 0xC89180 Offset: 0xC87780 VA: 0x180C89180
	|-Enumerable.Select<InventoryItem, SteamItem>
	|-Enumerable.Select<InventoryItem, object>
	|
	|-RVA: 0xC88E90 Offset: 0xC87490 VA: 0x180C88E90
	|-Enumerable.Select<InventoryItem, InventoryItemId>
	|
	|-RVA: 0xC89470 Offset: 0xC87A70 VA: 0x180C89470
	|-Enumerable.Select<InventoryItem, uint>
	|
	|-RVA: 0xC85F90 Offset: 0xC84590 VA: 0x180C85F90
	|-Enumerable.Select<InventoryItem.Amount, InventoryItemId>
	|
	|-RVA: 0xC86280 Offset: 0xC84880 VA: 0x180C86280
	|-Enumerable.Select<InventoryItem.Amount, uint>
	|
	|-RVA: 0xC89760 Offset: 0xC87D60 VA: 0x180C89760
	|-Enumerable.Select<InventoryRecipe, PlayerItemRecipe>
	|
	|-RVA: 0xC87710 Offset: 0xC85D10 VA: 0x180C87710
	|-Enumerable.Select<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>
	|
	|-RVA: 0xC87A00 Offset: 0xC86000 VA: 0x180C87A00
	|-Enumerable.Select<InventoryRecipe.Ingredient, string>
	|-Enumerable.Select<InventoryRecipe.Ingredient, object>
	|
	|-RVA: 0xC89A50 Offset: 0xC88050 VA: 0x180C89A50
	|-Enumerable.Select<KeyValuePair<Type, PostProcessBundle>, PostProcessBundle>
	|-Enumerable.Select<KeyValuePair<object, object>, object>
	|
	|-RVA: 0xC8A030 Offset: 0xC88630 VA: 0x180C8A030
	|-Enumerable.Select<KeyValuePair<uint, FileStorage.CacheData>, uint>
	|-Enumerable.Select<KeyValuePair<uint, object>, uint>
	|
	|-RVA: 0xC89D40 Offset: 0xC88340 VA: 0x180C89D40
	|-Enumerable.Select<KeyValuePair<uint, Indexer.Entity>, Indexer.Entity>
	|-Enumerable.Select<KeyValuePair<uint, object>, object>
	|
	|-RVA: 0xC87FE0 Offset: 0xC865E0 VA: 0x180C87FE0
	|-Enumerable.Select<int, FourBitNumber>
	|
	|-RVA: 0xC885C0 Offset: 0xC86BC0 VA: 0x180C885C0
	|-Enumerable.Select<int, SevenBitNumber>
	|
	|-RVA: 0xC882D0 Offset: 0xC868D0 VA: 0x180C882D0
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
	|-RVA: 0xC8B1D0 Offset: 0xC897D0 VA: 0x180C8B1D0
	|-Enumerable.Select<string, InventoryRecipe.Ingredient>
	|-Enumerable.Select<object, InventoryRecipe.Ingredient>
	|
	|-RVA: 0xC8B7B0 Offset: 0xC89DB0 VA: 0x180C8B7B0
	|-Enumerable.Select<string, InventoryRecipe>
	|-Enumerable.Select<object, InventoryRecipe>
	|
	|-RVA: 0x4B51B0 Offset: 0x4B37B0 VA: 0x1804B51B0
	|-Enumerable.Select<string, KeyCode>
	|-Enumerable.Select<object, Int32Enum>
	|
	|-RVA: 0xC87CF0 Offset: 0xC862F0 VA: 0x180C87CF0
	|-Enumerable.Select<KeyCode, string>
	|-Enumerable.Select<Int32Enum, object>
	|
	|-RVA: 0xC86860 Offset: 0xC84E60 VA: 0x180C86860
	|-Enumerable.Select<BurstCloth.Chain, int>
	|
	|-RVA: 0xC86B50 Offset: 0xC85150 VA: 0x180C86B50
	|-Enumerable.Select<WeightedStringList.Container, float>
	|
	|-RVA: 0xC87420 Offset: 0xC85A20 VA: 0x180C87420
	|-Enumerable.Select<PlayerItemRecipe.Ingredient, int>
	|
	|-RVA: 0xC8C370 Offset: 0xC8A970 VA: 0x180C8C370
	|-Enumerable.Select<ServerInfo, int>
	|
	|-RVA: 0xC8A900 Offset: 0xC88F00 VA: 0x180C8A900
	|-Enumerable.Select<SkinnedMultiMesh.Part, long>
	|
	|-RVA: 0xC88BA0 Offset: 0xC871A0 VA: 0x180C88BA0
	|-Enumerable.Select<InventoryItem, int>
	|
	|-RVA: 0xC86E40 Offset: 0xC85440 VA: 0x180C86E40
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
	|-RVA: 0x1B1AA00 Offset: 0x1B19000 VA: 0x181B1AA00
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
	|-RVA: 0x1179C80 Offset: 0x1178280 VA: 0x181179C80
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
	|-RVA: 0xED4900 Offset: 0xED2F00 VA: 0x180ED4900
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
	|-RVA: 0xED4980 Offset: 0xED2F80 VA: 0x180ED4980
	|-Enumerable.OrderBy<string, string>
	|-Enumerable.OrderBy<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED4880 Offset: 0xED2E80 VA: 0x180ED4880
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
	|-RVA: 0xED4F30 Offset: 0xED3530 VA: 0x180ED4F30
	|-Enumerable.ThenBy<IPlayerInfo, string>
	|-Enumerable.ThenBy<object, object>
	|
	|-RVA: 0xED4E20 Offset: 0xED3420 VA: 0x180ED4E20
	|-Enumerable.ThenBy<ItemBlueprint, Rarity>
	|-Enumerable.ThenBy<object, Int32Enum>
	|
	|-RVA: 0xED4FB0 Offset: 0xED35B0 VA: 0x180ED4FB0
	|-Enumerable.ThenBy<KerningPair, uint>
	|-Enumerable.ThenBy<TMP_GlyphPairAdjustmentRecord, uint>
	|-Enumerable.ThenBy<object, uint>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static IOrderedEnumerable<TSource> ThenByDescending<TSource, TKey>(IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED4B80 Offset: 0xED3180 VA: 0x180ED4B80
	|-Enumerable.ThenByDescending<AccountNotice, DateTime>
	|-Enumerable.ThenByDescending<object, DateTime>
	|
	|-RVA: 0xED4C90 Offset: 0xED3290 VA: 0x180ED4C90
	|-Enumerable.ThenByDescending<ItemBlueprint, int>
	|-Enumerable.ThenByDescending<object, int>
	|
	|-RVA: 0xED4A70 Offset: 0xED3070 VA: 0x180ED4A70
	|-Enumerable.ThenByDescending<Resolution, int>
	|
	|-RVA: 0xED4DA0 Offset: 0xED33A0 VA: 0x180ED4DA0
	|-Enumerable.ThenByDescending<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD000F0 Offset: 0xCFE6F0 VA: 0x180D000F0
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
	|-RVA: 0xBF18E0 Offset: 0xBEFEE0 VA: 0x180BF18E0
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
	|-RVA: 0xBF1C60 Offset: 0xBF0260 VA: 0x180BF1C60
	|-Enumerable.SequenceEqual<PlayerItemRecipe.Ingredient>
	|
	|-RVA: 0xBF18F0 Offset: 0xBEFEF0 VA: 0x180BF18F0
	|-Enumerable.SequenceEqual<bool>
	|
	|-RVA: 0xBF1FB0 Offset: 0xBF05B0 VA: 0x180BF1FB0
	|-Enumerable.SequenceEqual<object>
	|
	|-RVA: 0xBF2310 Offset: 0xBF0910 VA: 0x180BF2310
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
	|-RVA: 0x15A2B00 Offset: 0x15A1100 VA: 0x1815A2B00
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
	|-RVA: 0x15A2380 Offset: 0x15A0980 VA: 0x1815A2380
	|-Enumerable.ToArray<Debugging.EntityInfo>
	|
	|-RVA: 0x15A2CE0 Offset: 0x15A12E0 VA: 0x1815A2CE0
	|-Enumerable.ToArray<GameStat.Stat>
	|
	|-RVA: 0x15A2C40 Offset: 0x15A1240 VA: 0x1815A2C40
	|-Enumerable.ToArray<ItemSkinDirectory.Skin>
	|
	|-RVA: 0x15A2420 Offset: 0x15A0A20 VA: 0x1815A2420
	|-Enumerable.ToArray<FourBitNumber>
	|
	|-RVA: 0x15A2BA0 Offset: 0x15A11A0 VA: 0x1815A2BA0
	|-Enumerable.ToArray<SevenBitNumber>
	|
	|-RVA: 0x15A29C0 Offset: 0x15A0FC0 VA: 0x1815A29C0
	|-Enumerable.ToArray<Option>
	|
	|-RVA: 0x15A2A60 Offset: 0x15A1060 VA: 0x1815A2A60
	|-Enumerable.ToArray<SkinnedMultiMesh.Part>
	|
	|-RVA: 0x15A26A0 Offset: 0x15A0CA0 VA: 0x1815A26A0
	|-Enumerable.ToArray<InventoryDefId>
	|
	|-RVA: 0x15A2740 Offset: 0x15A0D40 VA: 0x1815A2740
	|-Enumerable.ToArray<InventoryItemId>
	|
	|-RVA: 0x15A27E0 Offset: 0x15A0DE0 VA: 0x1815A27E0
	|-Enumerable.ToArray<InventoryItem>
	|
	|-RVA: 0x15A24C0 Offset: 0x15A0AC0 VA: 0x1815A24C0
	|-Enumerable.ToArray<InventoryRecipe.Ingredient>
	|
	|-RVA: 0x15A2880 Offset: 0x15A0E80 VA: 0x1815A2880
	|-Enumerable.ToArray<InventoryRecipe>
	|
	|-RVA: 0x15A2920 Offset: 0x15A0F20 VA: 0x1815A2920
	|-Enumerable.ToArray<Item>
	|
	|-RVA: 0x15A2240 Offset: 0x15A0840 VA: 0x1815A2240
	|-Enumerable.ToArray<byte>
	|
	|-RVA: 0x15A22E0 Offset: 0x15A08E0 VA: 0x1815A22E0
	|-Enumerable.ToArray<char>
	|
	|-RVA: 0x15A2600 Offset: 0x15A0C00 VA: 0x1815A2600
	|-Enumerable.ToArray<int>
	|
	|-RVA: 0x15A2D80 Offset: 0x15A1380 VA: 0x1815A2D80
	|-Enumerable.ToArray<uint>
	|
	|-RVA: 0x15A2560 Offset: 0x15A0B60 VA: 0x1815A2560
	|-Enumerable.ToArray<KeyCode>
	|-Enumerable.ToArray<Int32Enum>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static List<TSource> ToList<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12ADB10 Offset: 0x12AC110 VA: 0x1812ADB10
	|-Enumerable.ToList<Chat.MuteEntry>
	|
	|-RVA: 0x12ADC50 Offset: 0x12AC250 VA: 0x1812ADC50
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
	|-RVA: 0x12ADA70 Offset: 0x12AC070 VA: 0x1812ADA70
	|-Enumerable.ToList<PlayerItemRecipe.Ingredient>
	|
	|-RVA: 0x12ADCF0 Offset: 0x12AC2F0 VA: 0x1812ADCF0
	|-Enumerable.ToList<ServerInfo>
	|
	|-RVA: 0x12ADD90 Offset: 0x12AC390 VA: 0x1812ADD90
	|-Enumerable.ToList<ServerInfo>
	|
	|-RVA: 0x12AD9D0 Offset: 0x12ABFD0 VA: 0x1812AD9D0
	|-Enumerable.ToList<bool>
	|
	|-RVA: 0x12ADE30 Offset: 0x12AC430 VA: 0x1812ADE30
	|-Enumerable.ToList<float>
	|
	|-RVA: 0x12ADBB0 Offset: 0x12AC1B0 VA: 0x1812ADBB0
	|-Enumerable.ToList<Resolution>
	|
	|-RVA: 0x12ADED0 Offset: 0x12AC4D0 VA: 0x1812ADED0
	|-Enumerable.ToList<Vector2>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1537F90 Offset: 0x1536590 VA: 0x181537F90
	|-Enumerable.ToDictionary<Input.Button, string>
	|-Enumerable.ToDictionary<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDFBDD0 Offset: 0xDFA3D0 VA: 0x180DFBDD0
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
	|-RVA: 0x1537D10 Offset: 0x1536310 VA: 0x181537D10
	|-Enumerable.ToDictionary<IGrouping<string, PrefabData>, string, List<PrefabData>>
	|-Enumerable.ToDictionary<object, object, object>
	|
	|-RVA: 0x1537260 Offset: 0x1535860 VA: 0x181537260
	|-Enumerable.ToDictionary<KeyValuePair<ulong, Dispatch.ResultCallback>, ulong, Dispatch.ResultCallback>
	|
	|-RVA: 0x1537820 Offset: 0x1535E20 VA: 0x181537820
	|-Enumerable.ToDictionary<object, InventoryDefId, uint>
	|
	|-RVA: 0x15375A0 Offset: 0x1535BA0 VA: 0x1815375A0
	|-Enumerable.ToDictionary<object, int, object>
	|
	|-RVA: 0x1537A90 Offset: 0x1536090 VA: 0x181537A90
	|-Enumerable.ToDictionary<object, object, Int32Enum>
	|
	|-RVA: 0x1537FF0 Offset: 0x15365F0 VA: 0x181537FF0
	|-Enumerable.ToDictionary<object, uint, object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static IEnumerable<TResult> OfType<TResult>(IEnumerable source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC85C30 Offset: 0xC84230 VA: 0x180C85C30
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
	|-RVA: 0xC85B90 Offset: 0xC84190 VA: 0x180C85B90
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
	|-RVA: 0xC85870 Offset: 0xC83E70 VA: 0x180C85870
	|-Enumerable.Cast<bool>
	|
	|-RVA: 0xC85910 Offset: 0xC83F10 VA: 0x180C85910
	|-Enumerable.Cast<byte>
	|
	|-RVA: 0xC859B0 Offset: 0xC83FB0 VA: 0x180C859B0
	|-Enumerable.Cast<DictionaryEntry>
	|
	|-RVA: 0xC85A50 Offset: 0xC84050 VA: 0x180C85A50
	|-Enumerable.Cast<short>
	|
	|-RVA: 0xC85AF0 Offset: 0xC840F0 VA: 0x180C85AF0
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
	|-RVA: 0xC857F0 Offset: 0xC83DF0 VA: 0x180C857F0
	|-Enumerable.CastIterator<DictionaryEntry>
	|
	|-RVA: 0x4B4930 Offset: 0x4B2F30 VA: 0x1804B4930
	|-Enumerable.CastIterator<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TSource First<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A10B0 Offset: 0x159F6B0 VA: 0x1815A10B0
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
	|-RVA: 0x159FE00 Offset: 0x159E400 VA: 0x18159FE00
	|-Enumerable.First<InventoryItem>
	|
	|-RVA: 0x15A0130 Offset: 0x159E730 VA: 0x1815A0130
	|-Enumerable.First<Item>
	|
	|-RVA: 0x15A0B60 Offset: 0x159F160 VA: 0x1815A0B60
	|-Enumerable.First<Resolution>
	|
	|-RVA: 0x159FB10 Offset: 0x159E110 VA: 0x18159FB10
	|-Enumerable.First<byte>
	|
	|-RVA: 0x15A05D0 Offset: 0x159EBD0 VA: 0x1815A05D0
	|-Enumerable.First<KeyValuePair<long, object>>
	|
	|-RVA: 0x15A08F0 Offset: 0x159EEF0 VA: 0x1815A08F0
	|-Enumerable.First<KeyValuePair<object, object>>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TSource First<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A0EC0 Offset: 0x159F4C0 VA: 0x1815A0EC0
	|-Enumerable.First<Dropdown.OptionData>
	|-Enumerable.First<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TSource FirstOrDefault<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x159F390 Offset: 0x159D990 VA: 0x18159F390
	|-Enumerable.FirstOrDefault<CraftingQueueIcon>
	|-Enumerable.FirstOrDefault<ValueChange<TimeSignature>>
	|-Enumerable.FirstOrDefault<ProjectileWeaponMod>
	|-Enumerable.FirstOrDefault<SocketHandle>
	|-Enumerable.FirstOrDefault<string>
	|-Enumerable.FirstOrDefault<Toggle>
	|-Enumerable.FirstOrDefault<object>
	|
	|-RVA: 0x159E860 Offset: 0x159CE60 VA: 0x18159E860
	|-Enumerable.FirstOrDefault<SkeletonDefinition.Bone>
	|
	|-RVA: 0x159F5A0 Offset: 0x159DBA0 VA: 0x18159F5A0
	|-Enumerable.FirstOrDefault<ItemSkinDirectory.Skin>
	|
	|-RVA: 0x159EBB0 Offset: 0x159D1B0 VA: 0x18159EBB0
	|-Enumerable.FirstOrDefault<InventoryRecipe>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TSource FirstOrDefault<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x159F1C0 Offset: 0x159D7C0 VA: 0x18159F1C0
	|-Enumerable.FirstOrDefault<Input.Button>
	|-Enumerable.FirstOrDefault<IPlayerItemDefinition>
	|-Enumerable.FirstOrDefault<Skinnable>
	|-Enumerable.FirstOrDefault<string>
	|-Enumerable.FirstOrDefault<Match>
	|-Enumerable.FirstOrDefault<Toggle>
	|-Enumerable.FirstOrDefault<object>
	|
	|-RVA: 0x159F860 Offset: 0x159DE60 VA: 0x18159F860
	|-Enumerable.FirstOrDefault<ItemSkinDirectory.Skin>
	|
	|-RVA: 0x159EEF0 Offset: 0x159D4F0 VA: 0x18159EEF0
	|-Enumerable.FirstOrDefault<PetCommandList.PetCommandDesc>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TSource Last<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A17F0 Offset: 0x159FDF0 VA: 0x1815A17F0
	|-Enumerable.Last<string>
	|-Enumerable.Last<KerningPair>
	|-Enumerable.Last<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TSource LastOrDefault<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A12D0 Offset: 0x159F8D0 VA: 0x1815A12D0
	|-Enumerable.LastOrDefault<MetricTempoMapValuesCache.AccumulatedMicroseconds>
	|-Enumerable.LastOrDefault<ValueChange<TimeSignature>>
	|-Enumerable.LastOrDefault<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TSource LastOrDefault<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A15D0 Offset: 0x159FBD0 VA: 0x1815A15D0
	|-Enumerable.LastOrDefault<MemberInfo>
	|-Enumerable.LastOrDefault<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TSource Single<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A1FC0 Offset: 0x15A05C0 VA: 0x1815A1FC0
	|-Enumerable.Single<MemberInfo>
	|-Enumerable.Single<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TSource SingleOrDefault<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A1B10 Offset: 0x15A0110 VA: 0x1815A1B10
	|-Enumerable.SingleOrDefault<MemberInfo>
	|-Enumerable.SingleOrDefault<string>
	|-Enumerable.SingleOrDefault<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TSource SingleOrDefault<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A1D70 Offset: 0x15A0370 VA: 0x1815A1D70
	|-Enumerable.SingleOrDefault<ConstructorInfo>
	|-Enumerable.SingleOrDefault<PlayerEditorConnectionEvents.MessageTypeSubscribers>
	|-Enumerable.SingleOrDefault<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TSource ElementAt<TSource>(IEnumerable<TSource> source, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x159E320 Offset: 0x159C920 VA: 0x18159E320
	|-Enumerable.ElementAt<KeyValuePair<string, JSONNode>>
	|-Enumerable.ElementAt<KeyValuePair<object, object>>
	|
	|-RVA: 0x159E5E0 Offset: 0x159CBE0 VA: 0x18159E5E0
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
	|-RVA: 0xBF0350 Offset: 0xBEE950 VA: 0x180BF0350
	|-Enumerable.Any<PlayerItemRecipe>
	|
	|-RVA: 0xBEFE00 Offset: 0xBEE400 VA: 0x180BEFE00
	|-Enumerable.Any<KeyValuePair<long, object>>
	|
	|-RVA: 0xBEFF70 Offset: 0xBEE570 VA: 0x180BEFF70
	|-Enumerable.Any<KeyValuePair<object, object>>
	|
	|-RVA: 0xBF04C0 Offset: 0xBEEAC0 VA: 0x180BF04C0
	|-Enumerable.Any<FileInfo>
	|-Enumerable.Any<object>
	|-Enumerable.Any<ParameterInfo>
	|-Enumerable.Any<PlayerEditorConnectionEvents.MessageTypeSubscribers>
	|
	|-RVA: 0xBF0800 Offset: 0xBEEE00 VA: 0x180BF0800
	|-Enumerable.Any<float>
	|
	|-RVA: 0xBF0970 Offset: 0xBEEF70 VA: 0x180BF0970
	|-Enumerable.Any<Vector2>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static bool Any<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF0630 Offset: 0xBEEC30 VA: 0x180BF0630
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
	|-RVA: 0xBF00E0 Offset: 0xBEE6E0 VA: 0x180BF00E0
	|-Enumerable.Any<SkinnedMultiMesh.Part>
	|
	|-RVA: 0xBEF910 Offset: 0xBEDF10 VA: 0x180BEF910
	|-Enumerable.Any<InventoryItem.Amount>
	|
	|-RVA: 0xBEFB90 Offset: 0xBEE190 VA: 0x180BEFB90
	|-Enumerable.Any<InventoryRecipe.Ingredient>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static bool All<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEF740 Offset: 0xBEDD40 VA: 0x180BEF740
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
	|-RVA: 0xED4070 Offset: 0xED2670 VA: 0x180ED4070
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
	|-RVA: 0xED4460 Offset: 0xED2A60 VA: 0x180ED4460
	|-Enumerable.Count<ServerInfo>
	|
	|-RVA: 0xED3E70 Offset: 0xED2470 VA: 0x180ED3E70
	|-Enumerable.Count<InventoryItem>
	|
	|-RVA: 0xED3C70 Offset: 0xED2270 VA: 0x180ED3C70
	|-Enumerable.Count<int>
	|
	|-RVA: 0xED4660 Offset: 0xED2C60 VA: 0x180ED4660
	|-Enumerable.Count<float>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static int Count<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED3800 Offset: 0xED1E00 VA: 0x180ED3800
	|-Enumerable.Count<RCon.BannedAddresses>
	|
	|-RVA: 0xED3A80 Offset: 0xED2080 VA: 0x180ED3A80
	|-Enumerable.Count<bool>
	|
	|-RVA: 0xED4270 Offset: 0xED2870 VA: 0x180ED4270
	|-Enumerable.Count<object>
	|-Enumerable.Count<Collider>
	|-Enumerable.Count<Renderer>
	|-Enumerable.Count<Rigidbody>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static bool Contains<TSource>(IEnumerable<TSource> source, TSource value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF0EB0 Offset: 0xBEF4B0 VA: 0x180BF0EB0
	|-Enumerable.Contains<TempoMapLine>
	|-Enumerable.Contains<int>
	|-Enumerable.Contains<Int32Enum>
	|-Enumerable.Contains<GraphicsDeviceType>
	|
	|-RVA: 0xBF1570 Offset: 0xBEFB70 VA: 0x180BF1570
	|-Enumerable.Contains<MeshPaintableSource>
	|-Enumerable.Contains<object>
	|-Enumerable.Contains<string>
	|-Enumerable.Contains<Component>
	|-Enumerable.Contains<Material>
	|-Enumerable.Contains<Renderer>
	|
	|-RVA: 0xBF0AE0 Offset: 0xBEF0E0 VA: 0x180BF0AE0
	|-Enumerable.Contains<char>
	|-Enumerable.Contains<ushort>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static bool Contains<TSource>(IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF0BF0 Offset: 0xBEF1F0 VA: 0x180BF0BF0
	|-Enumerable.Contains<char>
	|
	|-RVA: 0xBF1160 Offset: 0xBEF760 VA: 0x180BF1160
	|-Enumerable.Contains<int>
	|
	|-RVA: 0xBF0F60 Offset: 0xBEF560 VA: 0x180BF0F60
	|-Enumerable.Contains<Int32Enum>
	|
	|-RVA: 0xBF1360 Offset: 0xBEF960 VA: 0x180BF1360
	|-Enumerable.Contains<object>
	|
	|-RVA: 0xBF1620 Offset: 0xBEFC20 VA: 0x180BF1620
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
	|-RVA: 0xED4A10 Offset: 0xED3010 VA: 0x180ED4A10
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
	|-RVA: 0xED4A50 Offset: 0xED3050 VA: 0x180ED4A50
	|-Enumerable.Sum<SkinnedMultiMesh.Part>
	|-Enumerable.Sum<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static float Sum<TSource>(IEnumerable<TSource> source, Func<TSource, float> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED4A30 Offset: 0xED3030 VA: 0x180ED4A30
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
	|-RVA: 0xED4860 Offset: 0xED2E60 VA: 0x180ED4860
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
	|-RVA: 0x19D0BF0 Offset: 0x19CF1F0 VA: 0x1819D0BF0
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
	|-RVA: 0xB11AC0 Offset: 0xB100C0 VA: 0x180B11AC0
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
	|-RVA: 0x1650350 Offset: 0x164E950 VA: 0x181650350
	|-Enumerable.Iterator<SkeletonDefinition.Bone>.get_Current
	|-Enumerable.Iterator<InventoryItem.Amount>.get_Current
	|
	|-RVA: 0x176B3D0 Offset: 0x17699D0 VA: 0x18176B3D0
	|-Enumerable.Iterator<ItemSkinDirectory.Skin>.get_Current
	|-Enumerable.Iterator<Option>.get_Current
	|-Enumerable.Iterator<SkinnedMultiMesh.Part>.get_Current
	|-Enumerable.Iterator<InventoryItem>.get_Current
	|
	|-RVA: 0x9600F0 Offset: 0x95E6F0 VA: 0x1809600F0
	|-Enumerable.Iterator<FourBitNumber>.get_Current
	|-Enumerable.Iterator<SevenBitNumber>.get_Current
	|-Enumerable.Iterator<bool>.get_Current
	|
	|-RVA: 0x12D3C30 Offset: 0x12D2230 VA: 0x1812D3C30
	|-Enumerable.Iterator<ProjectileWeaponMod.Modifier>.get_Current
	|-Enumerable.Iterator<Resolution>.get_Current
	|
	|-RVA: 0xDECF20 Offset: 0xDEB520 VA: 0x180DECF20
	|-Enumerable.Iterator<ServerInfo>.get_Current
	|-Enumerable.Iterator<ServerInfo>.get_Current
	|
	|-RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400
	|-Enumerable.Iterator<InventoryDefId>.get_Current
	|-Enumerable.Iterator<int>.get_Current
	|-Enumerable.Iterator<Int32Enum>.get_Current
	|-Enumerable.Iterator<uint>.get_Current
	|
	|-RVA: 0x1128460 Offset: 0x1126A60 VA: 0x181128460
	|-Enumerable.Iterator<InventoryRecipe.Ingredient>.get_Current
	|-Enumerable.Iterator<InventoryRecipe>.get_Current
	|-Enumerable.Iterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.get_Current
	|
	|-RVA: 0x1398570 Offset: 0x1396B70 VA: 0x181398570
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
	|-RVA: 0x19CF980 Offset: 0x19CDF80 VA: 0x1819CF980
	|-Enumerable.Iterator<Debugging.EntityInfo>.Dispose
	|-Enumerable.Iterator<WeightedStringList.Container>.Dispose
	|-Enumerable.Iterator<GameStat.Stat>.Dispose
	|-Enumerable.Iterator<PlayerItemRecipe>.Dispose
	|-Enumerable.Iterator<DictionaryEntry>.Dispose
	|-Enumerable.Iterator<KeyValuePair<object, int>>.Dispose
	|-Enumerable.Iterator<KeyValuePair<object, object>>.Dispose
	|-Enumerable.Iterator<KeyValuePair<uint, object>>.Dispose
	|
	|-RVA: 0x19CF9B0 Offset: 0x19CDFB0 VA: 0x1819CF9B0
	|-Enumerable.Iterator<BurstCloth.Chain>.Dispose
	|-Enumerable.Iterator<PathFinder.Point>.Dispose
	|-Enumerable.Iterator<PlayerItemRecipe.Ingredient>.Dispose
	|-Enumerable.Iterator<Achievement>.Dispose
	|-Enumerable.Iterator<InventoryItemId>.Dispose
	|-Enumerable.Iterator<Friend>.Dispose
	|-Enumerable.Iterator<long>.Dispose
	|-Enumerable.Iterator<object>.Dispose
	|
	|-RVA: 0x19CFA10 Offset: 0x19CE010 VA: 0x1819CFA10
	|-Enumerable.Iterator<SkeletonDefinition.Bone>.Dispose
	|-Enumerable.Iterator<InventoryItem.Amount>.Dispose
	|
	|-RVA: 0x19CF9E0 Offset: 0x19CDFE0 VA: 0x1819CF9E0
	|-Enumerable.Iterator<ItemSkinDirectory.Skin>.Dispose
	|-Enumerable.Iterator<Option>.Dispose
	|-Enumerable.Iterator<SkinnedMultiMesh.Part>.Dispose
	|-Enumerable.Iterator<InventoryItem>.Dispose
	|
	|-RVA: 0x19CFA60 Offset: 0x19CE060 VA: 0x1819CFA60
	|-Enumerable.Iterator<FourBitNumber>.Dispose
	|-Enumerable.Iterator<SevenBitNumber>.Dispose
	|-Enumerable.Iterator<bool>.Dispose
	|
	|-RVA: 0x19CF9C0 Offset: 0x19CDFC0 VA: 0x1819CF9C0
	|-Enumerable.Iterator<ProjectileWeaponMod.Modifier>.Dispose
	|-Enumerable.Iterator<Resolution>.Dispose
	|
	|-RVA: 0x19CFA30 Offset: 0x19CE030 VA: 0x1819CFA30
	|-Enumerable.Iterator<ServerInfo>.Dispose
	|-Enumerable.Iterator<ServerInfo>.Dispose
	|
	|-RVA: 0x19CF970 Offset: 0x19CDF70 VA: 0x1819CF970
	|-Enumerable.Iterator<InventoryDefId>.Dispose
	|-Enumerable.Iterator<int>.Dispose
	|-Enumerable.Iterator<Int32Enum>.Dispose
	|-Enumerable.Iterator<float>.Dispose
	|-Enumerable.Iterator<uint>.Dispose
	|
	|-RVA: 0x19CF990 Offset: 0x19CDF90 VA: 0x1819CF990
	|-Enumerable.Iterator<InventoryRecipe.Ingredient>.Dispose
	|-Enumerable.Iterator<InventoryRecipe>.Dispose
	|-Enumerable.Iterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.Dispose
	|
	|-RVA: 0x19CFA00 Offset: 0x19CE000 VA: 0x1819CFA00
	|-Enumerable.Iterator<char>.Dispose
	*/

	public IEnumerator<TSource> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CFA70 Offset: 0x19CE070 VA: 0x1819CFA70
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
	|-RVA: 0x19D0750 Offset: 0x19CED50 VA: 0x1819D0750
	|-Enumerable.Iterator<Debugging.EntityInfo>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<WeightedStringList.Container>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<GameStat.Stat>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<PlayerItemRecipe>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<DictionaryEntry>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<KeyValuePair<object, int>>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<KeyValuePair<object, object>>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<KeyValuePair<uint, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D07C0 Offset: 0x19CEDC0 VA: 0x1819D07C0
	|-Enumerable.Iterator<BurstCloth.Chain>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<PathFinder.Point>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<PlayerItemRecipe.Ingredient>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<Achievement>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<InventoryItemId>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<Friend>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D0B10 Offset: 0x19CF110 VA: 0x1819D0B10
	|-Enumerable.Iterator<SkeletonDefinition.Bone>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<InventoryItem.Amount>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D0820 Offset: 0x19CEE20 VA: 0x1819D0820
	|-Enumerable.Iterator<ItemSkinDirectory.Skin>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<Option>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<SkinnedMultiMesh.Part>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<InventoryItem>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D0AB0 Offset: 0x19CF0B0 VA: 0x1819D0AB0
	|-Enumerable.Iterator<FourBitNumber>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<SevenBitNumber>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D0A30 Offset: 0x19CF030 VA: 0x1819D0A30
	|-Enumerable.Iterator<ProjectileWeaponMod.Modifier>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<Resolution>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D08A0 Offset: 0x19CEEA0 VA: 0x1819D08A0
	|-Enumerable.Iterator<ServerInfo>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<ServerInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D09D0 Offset: 0x19CEFD0 VA: 0x1819D09D0
	|-Enumerable.Iterator<InventoryDefId>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<int>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<Int32Enum>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<uint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D06D0 Offset: 0x19CECD0 VA: 0x1819D06D0
	|-Enumerable.Iterator<InventoryRecipe.Ingredient>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<InventoryRecipe>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D0B90 Offset: 0x19CF190 VA: 0x1819D0B90
	|-Enumerable.Iterator<char>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19AD460 Offset: 0x19ABA60 VA: 0x1819AD460
	|-Enumerable.Iterator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D0960 Offset: 0x19CEF60 VA: 0x1819D0960
	|-Enumerable.Iterator<float>.System.Collections.IEnumerator.get_Current
	*/

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16509D0 Offset: 0x164EFD0 VA: 0x1816509D0
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
	|-RVA: 0x19D04F0 Offset: 0x19CEAF0 VA: 0x1819D04F0
	|-Enumerable.Iterator<Debugging.EntityInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0590 Offset: 0x19CEB90 VA: 0x1819D0590
	|-Enumerable.Iterator<BurstCloth.Chain>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D01D0 Offset: 0x19CE7D0 VA: 0x1819D01D0
	|-Enumerable.Iterator<SkeletonDefinition.Bone>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFCD0 Offset: 0x19CE2D0 VA: 0x1819CFCD0
	|-Enumerable.Iterator<WeightedStringList.Container>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0220 Offset: 0x19CE820 VA: 0x1819D0220
	|-Enumerable.Iterator<GameStat.Stat>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFBE0 Offset: 0x19CE1E0 VA: 0x1819CFBE0
	|-Enumerable.Iterator<ItemSkinDirectory.Skin>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0630 Offset: 0x19CEC30 VA: 0x1819D0630
	|-Enumerable.Iterator<FourBitNumber>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFDC0 Offset: 0x19CE3C0 VA: 0x1819CFDC0
	|-Enumerable.Iterator<SevenBitNumber>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFC30 Offset: 0x19CE230 VA: 0x1819CFC30
	|-Enumerable.Iterator<PathFinder.Point>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0540 Offset: 0x19CEB40 VA: 0x1819D0540
	|-Enumerable.Iterator<PlayerItemRecipe.Ingredient>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFFA0 Offset: 0x19CE5A0 VA: 0x1819CFFA0
	|-Enumerable.Iterator<PlayerItemRecipe>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFF00 Offset: 0x19CE500 VA: 0x1819CFF00
	|-Enumerable.Iterator<ProjectileWeaponMod.Modifier>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0090 Offset: 0x19CE690 VA: 0x1819D0090
	|-Enumerable.Iterator<Option>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFD70 Offset: 0x19CE370 VA: 0x1819CFD70
	|-Enumerable.Iterator<ServerInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0040 Offset: 0x19CE640 VA: 0x1819D0040
	|-Enumerable.Iterator<SkinnedMultiMesh.Part>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFAF0 Offset: 0x19CE0F0 VA: 0x1819CFAF0
	|-Enumerable.Iterator<Achievement>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D04A0 Offset: 0x19CEAA0 VA: 0x1819D04A0
	|-Enumerable.Iterator<InventoryDefId>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D02C0 Offset: 0x19CE8C0 VA: 0x1819D02C0
	|-Enumerable.Iterator<InventoryItemId>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0680 Offset: 0x19CEC80 VA: 0x1819D0680
	|-Enumerable.Iterator<ServerInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D03B0 Offset: 0x19CE9B0 VA: 0x1819D03B0
	|-Enumerable.Iterator<Friend>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D05E0 Offset: 0x19CEBE0 VA: 0x1819D05E0
	|-Enumerable.Iterator<InventoryItem.Amount>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0180 Offset: 0x19CE780 VA: 0x1819D0180
	|-Enumerable.Iterator<InventoryItem>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0400 Offset: 0x19CEA00 VA: 0x1819D0400
	|-Enumerable.Iterator<InventoryRecipe.Ingredient>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0270 Offset: 0x19CE870 VA: 0x1819D0270
	|-Enumerable.Iterator<InventoryRecipe>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFFF0 Offset: 0x19CE5F0 VA: 0x1819CFFF0
	|-Enumerable.Iterator<bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0310 Offset: 0x19CE910 VA: 0x1819D0310
	|-Enumerable.Iterator<char>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFC80 Offset: 0x19CE280 VA: 0x1819CFC80
	|-Enumerable.Iterator<DictionaryEntry>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFF50 Offset: 0x19CE550 VA: 0x1819CFF50
	|-Enumerable.Iterator<KeyValuePair<object, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFE60 Offset: 0x19CE460 VA: 0x1819CFE60
	|-Enumerable.Iterator<KeyValuePair<object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFB90 Offset: 0x19CE190 VA: 0x1819CFB90
	|-Enumerable.Iterator<KeyValuePair<uint, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0450 Offset: 0x19CEA50 VA: 0x1819D0450
	|-Enumerable.Iterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFB40 Offset: 0x19CE140 VA: 0x1819CFB40
	|-Enumerable.Iterator<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0130 Offset: 0x19CE730 VA: 0x1819D0130
	|-Enumerable.Iterator<Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFEB0 Offset: 0x19CE4B0 VA: 0x1819CFEB0
	|-Enumerable.Iterator<long>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFD20 Offset: 0x19CE320 VA: 0x1819CFD20
	|-Enumerable.Iterator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFE10 Offset: 0x19CE410 VA: 0x1819CFE10
	|-Enumerable.Iterator<float>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0360 Offset: 0x19CE960 VA: 0x1819D0360
	|-Enumerable.Iterator<uint>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D00E0 Offset: 0x19CE6E0 VA: 0x1819D00E0
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
	|-RVA: 0x16A22D0 Offset: 0x16A08D0 VA: 0x1816A22D0
	|-Enumerable.WhereEnumerableIterator<Debugging.EntityInfo>..ctor
	|-Enumerable.WhereEnumerableIterator<GameStat.Stat>..ctor
	|-Enumerable.WhereEnumerableIterator<PlayerItemRecipe>..ctor
	|-Enumerable.WhereEnumerableIterator<ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, object>>..ctor
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<uint, object>>..ctor
	|-Enumerable.WhereEnumerableIterator<Resolution>..ctor
	|
	|-RVA: 0x16A3B30 Offset: 0x16A2130 VA: 0x1816A3B30
	|-Enumerable.WhereEnumerableIterator<SkeletonDefinition.Bone>..ctor
	|
	|-RVA: 0x16A3BA0 Offset: 0x16A21A0 VA: 0x1816A3BA0
	|-Enumerable.WhereEnumerableIterator<ItemSkinDirectory.Skin>..ctor
	|-Enumerable.WhereEnumerableIterator<Option>..ctor
	|-Enumerable.WhereEnumerableIterator<SkinnedMultiMesh.Part>..ctor
	|-Enumerable.WhereEnumerableIterator<InventoryItem>..ctor
	|
	|-RVA: 0x16A2340 Offset: 0x16A0940 VA: 0x1816A2340
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
	|-RVA: 0x16A3C10 Offset: 0x16A2210 VA: 0x1816A3C10
	|-Enumerable.WhereEnumerableIterator<ServerInfo>..ctor
	|
	|-RVA: 0x16A3AC0 Offset: 0x16A20C0 VA: 0x1816A3AC0
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe>..ctor
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>..ctor
	*/

	public override Enumerable.Iterator<TSource> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A1BD0 Offset: 0x16A01D0 VA: 0x1816A1BD0
	|-Enumerable.WhereEnumerableIterator<Debugging.EntityInfo>.Clone
	|-Enumerable.WhereEnumerableIterator<GameStat.Stat>.Clone
	|-Enumerable.WhereEnumerableIterator<PlayerItemRecipe>.Clone
	|-Enumerable.WhereEnumerableIterator<ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, object>>.Clone
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<uint, object>>.Clone
	|-Enumerable.WhereEnumerableIterator<Resolution>.Clone
	|
	|-RVA: 0x16A2430 Offset: 0x16A0A30 VA: 0x1816A2430
	|-Enumerable.WhereEnumerableIterator<SkeletonDefinition.Bone>.Clone
	|
	|-RVA: 0x16A23B0 Offset: 0x16A09B0 VA: 0x1816A23B0
	|-Enumerable.WhereEnumerableIterator<ItemSkinDirectory.Skin>.Clone
	|-Enumerable.WhereEnumerableIterator<Option>.Clone
	|-Enumerable.WhereEnumerableIterator<SkinnedMultiMesh.Part>.Clone
	|-Enumerable.WhereEnumerableIterator<InventoryItem>.Clone
	|
	|-RVA: 0x16A1C50 Offset: 0x16A0250 VA: 0x1816A1C50
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
	|-RVA: 0x16A24B0 Offset: 0x16A0AB0 VA: 0x1816A24B0
	|-Enumerable.WhereEnumerableIterator<ServerInfo>.Clone
	|
	|-RVA: 0x16A2540 Offset: 0x16A0B40 VA: 0x1816A2540
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe>.Clone
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.Clone
	*/

	public override void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D8780 Offset: 0x19D6D80 VA: 0x1819D8780
	|-Enumerable.WhereEnumerableIterator<Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x19D92C0 Offset: 0x19D78C0 VA: 0x1819D92C0
	|-Enumerable.WhereEnumerableIterator<SkeletonDefinition.Bone>.Dispose
	|
	|-RVA: 0x19D8930 Offset: 0x19D6F30 VA: 0x1819D8930
	|-Enumerable.WhereEnumerableIterator<GameStat.Stat>.Dispose
	|
	|-RVA: 0x19D85D0 Offset: 0x19D6BD0 VA: 0x1819D85D0
	|-Enumerable.WhereEnumerableIterator<ItemSkinDirectory.Skin>.Dispose
	|
	|-RVA: 0x19D84B0 Offset: 0x19D6AB0 VA: 0x1819D84B0
	|-Enumerable.WhereEnumerableIterator<FourBitNumber>.Dispose
	|
	|-RVA: 0x19D8C90 Offset: 0x19D7290 VA: 0x1819D8C90
	|-Enumerable.WhereEnumerableIterator<SevenBitNumber>.Dispose
	|
	|-RVA: 0x19D8540 Offset: 0x19D6B40 VA: 0x1819D8540
	|-Enumerable.WhereEnumerableIterator<PathFinder.Point>.Dispose
	|
	|-RVA: 0x19D8A50 Offset: 0x19D7050 VA: 0x1819D8A50
	|-Enumerable.WhereEnumerableIterator<PlayerItemRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x19D88A0 Offset: 0x19D6EA0 VA: 0x1819D88A0
	|-Enumerable.WhereEnumerableIterator<PlayerItemRecipe>.Dispose
	|
	|-RVA: 0x19D8420 Offset: 0x19D6A20 VA: 0x1819D8420
	|-Enumerable.WhereEnumerableIterator<ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x19D8B70 Offset: 0x19D7170 VA: 0x1819D8B70
	|-Enumerable.WhereEnumerableIterator<Option>.Dispose
	|
	|-RVA: 0x19D91A0 Offset: 0x19D77A0 VA: 0x1819D91A0
	|-Enumerable.WhereEnumerableIterator<ServerInfo>.Dispose
	|
	|-RVA: 0x19D8390 Offset: 0x19D6990 VA: 0x1819D8390
	|-Enumerable.WhereEnumerableIterator<SkinnedMultiMesh.Part>.Dispose
	|
	|-RVA: 0x19D8D20 Offset: 0x19D7320 VA: 0x1819D8D20
	|-Enumerable.WhereEnumerableIterator<InventoryItemId>.Dispose
	|
	|-RVA: 0x19D8E40 Offset: 0x19D7440 VA: 0x1819D8E40
	|-Enumerable.WhereEnumerableIterator<InventoryItem>.Dispose
	|
	|-RVA: 0x19D9110 Offset: 0x19D7710 VA: 0x1819D9110
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x19D8660 Offset: 0x19D6C60 VA: 0x1819D8660
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe>.Dispose
	|
	|-RVA: 0x19D8810 Offset: 0x19D6E10 VA: 0x1819D8810
	|-Enumerable.WhereEnumerableIterator<bool>.Dispose
	|
	|-RVA: 0x19D8FF0 Offset: 0x19D75F0 VA: 0x1819D8FF0
	|-Enumerable.WhereEnumerableIterator<char>.Dispose
	|
	|-RVA: 0x19D86F0 Offset: 0x19D6CF0 VA: 0x1819D86F0
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x19D8F60 Offset: 0x19D7560 VA: 0x1819D8F60
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, object>>.Dispose
	|
	|-RVA: 0x19D8C00 Offset: 0x19D7200 VA: 0x1819D8C00
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<uint, object>>.Dispose
	|
	|-RVA: 0x19D8DB0 Offset: 0x19D73B0 VA: 0x1819D8DB0
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.Dispose
	|
	|-RVA: 0x19D8AE0 Offset: 0x19D70E0 VA: 0x1819D8AE0
	|-Enumerable.WhereEnumerableIterator<int>.Dispose
	|
	|-RVA: 0x19D9230 Offset: 0x19D7830 VA: 0x1819D9230
	|-Enumerable.WhereEnumerableIterator<Int32Enum>.Dispose
	|
	|-RVA: 0x19D89C0 Offset: 0x19D6FC0 VA: 0x1819D89C0
	|-Enumerable.WhereEnumerableIterator<long>.Dispose
	|
	|-RVA: 0x19D9080 Offset: 0x19D7680 VA: 0x1819D9080
	|-Enumerable.WhereEnumerableIterator<object>.Dispose
	|
	|-RVA: 0x19D8ED0 Offset: 0x19D74D0 VA: 0x1819D8ED0
	|-Enumerable.WhereEnumerableIterator<float>.Dispose
	|
	|-RVA: 0x16A1CD0 Offset: 0x16A02D0 VA: 0x1816A1CD0
	|-Enumerable.WhereEnumerableIterator<uint>.Dispose
	|
	|-RVA: 0x16A1D60 Offset: 0x16A0360 VA: 0x1816A1D60
	|-Enumerable.WhereEnumerableIterator<Resolution>.Dispose
	*/

	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19DB070 Offset: 0x19D9670 VA: 0x1819DB070
	|-Enumerable.WhereEnumerableIterator<Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x19DB250 Offset: 0x19D9850 VA: 0x1819DB250
	|-Enumerable.WhereEnumerableIterator<SkeletonDefinition.Bone>.MoveNext
	|
	|-RVA: 0x19D9AF0 Offset: 0x19D80F0 VA: 0x1819D9AF0
	|-Enumerable.WhereEnumerableIterator<GameStat.Stat>.MoveNext
	|
	|-RVA: 0x19DC520 Offset: 0x19DAB20 VA: 0x1819DC520
	|-Enumerable.WhereEnumerableIterator<ItemSkinDirectory.Skin>.MoveNext
	|
	|-RVA: 0x19DC180 Offset: 0x19DA780 VA: 0x1819DC180
	|-Enumerable.WhereEnumerableIterator<FourBitNumber>.MoveNext
	|
	|-RVA: 0x19D9FD0 Offset: 0x19D85D0 VA: 0x1819D9FD0
	|-Enumerable.WhereEnumerableIterator<SevenBitNumber>.MoveNext
	|
	|-RVA: 0x19DA750 Offset: 0x19D8D50 VA: 0x1819DA750
	|-Enumerable.WhereEnumerableIterator<PathFinder.Point>.MoveNext
	|
	|-RVA: 0x19DA190 Offset: 0x19D8790 VA: 0x1819DA190
	|-Enumerable.WhereEnumerableIterator<PlayerItemRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x19DACB0 Offset: 0x19D92B0 VA: 0x1819DACB0
	|-Enumerable.WhereEnumerableIterator<PlayerItemRecipe>.MoveNext
	|
	|-RVA: 0x19DA570 Offset: 0x19D8B70 VA: 0x1819DA570
	|-Enumerable.WhereEnumerableIterator<ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x19D9580 Offset: 0x19D7B80 VA: 0x1819D9580
	|-Enumerable.WhereEnumerableIterator<Option>.MoveNext
	|
	|-RVA: 0x19D9CD0 Offset: 0x19D82D0 VA: 0x1819D9CD0
	|-Enumerable.WhereEnumerableIterator<ServerInfo>.MoveNext
	|
	|-RVA: 0x19DAA80 Offset: 0x19D9080 VA: 0x1819DAA80
	|-Enumerable.WhereEnumerableIterator<SkinnedMultiMesh.Part>.MoveNext
	|
	|-RVA: 0x19DBD00 Offset: 0x19DA300 VA: 0x1819DBD00
	|-Enumerable.WhereEnumerableIterator<InventoryItemId>.MoveNext
	|
	|-RVA: 0x19D9350 Offset: 0x19D7950 VA: 0x1819D9350
	|-Enumerable.WhereEnumerableIterator<InventoryItem>.MoveNext
	|
	|-RVA: 0x19DA350 Offset: 0x19D8950 VA: 0x1819DA350
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x19DB4A0 Offset: 0x19D9AA0 VA: 0x1819DB4A0
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe>.MoveNext
	|
	|-RVA: 0x19DBEC0 Offset: 0x19DA4C0 VA: 0x1819DBEC0
	|-Enumerable.WhereEnumerableIterator<bool>.MoveNext
	|
	|-RVA: 0x19DC020 Offset: 0x19DA620 VA: 0x1819DC020
	|-Enumerable.WhereEnumerableIterator<char>.MoveNext
	|
	|-RVA: 0x19DAE90 Offset: 0x19D9490 VA: 0x1819DAE90
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x19D9910 Offset: 0x19D7F10 VA: 0x1819D9910
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0x19DC340 Offset: 0x19DA940 VA: 0x1819DC340
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<uint, object>>.MoveNext
	|
	|-RVA: 0x19DB820 Offset: 0x19D9E20 VA: 0x1819DB820
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.MoveNext
	|
	|-RVA: 0x19DBBA0 Offset: 0x19DA1A0 VA: 0x1819DBBA0
	|-Enumerable.WhereEnumerableIterator<int>.MoveNext
	|
	|-RVA: 0x19D97B0 Offset: 0x19D7DB0 VA: 0x1819D97B0
	|-Enumerable.WhereEnumerableIterator<Int32Enum>.MoveNext
	|
	|-RVA: 0x19DB6C0 Offset: 0x19D9CC0 VA: 0x1819DB6C0
	|-Enumerable.WhereEnumerableIterator<long>.MoveNext
	|
	|-RVA: 0x19DA910 Offset: 0x19D8F10 VA: 0x1819DA910
	|-Enumerable.WhereEnumerableIterator<object>.MoveNext
	|
	|-RVA: 0x19DBA40 Offset: 0x19DA040 VA: 0x1819DBA40
	|-Enumerable.WhereEnumerableIterator<float>.MoveNext
	|
	|-RVA: 0x16A1FD0 Offset: 0x16A05D0 VA: 0x1816A1FD0
	|-Enumerable.WhereEnumerableIterator<uint>.MoveNext
	|
	|-RVA: 0x16A1DF0 Offset: 0x16A03F0 VA: 0x1816A1DF0
	|-Enumerable.WhereEnumerableIterator<Resolution>.MoveNext
	*/

	public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC8CF10 Offset: 0xC8B510 VA: 0x180C8CF10
	|-Enumerable.WhereEnumerableIterator<SkeletonDefinition.Bone>.Select<object>
	|
	|-RVA: 0xC8CC40 Offset: 0xC8B240 VA: 0x180C8CC40
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
	|-RVA: 0xC8CE80 Offset: 0xC8B480 VA: 0x180C8CE80
	|-Enumerable.WhereEnumerableIterator<PlayerItemRecipe>.Select<object>
	|-Enumerable.WhereEnumerableIterator<ProjectileWeaponMod.Modifier>.Select<float>
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, object>>.Select<object>
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<uint, object>>.Select<object>
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<uint, object>>.Select<uint>
	|
	|-RVA: 0xC8CDF0 Offset: 0xC8B3F0 VA: 0x180C8CDF0
	|-Enumerable.WhereEnumerableIterator<Option>.Select<Option>
	|-Enumerable.WhereEnumerableIterator<SkinnedMultiMesh.Part>.Select<long>
	|-Enumerable.WhereEnumerableIterator<InventoryItem>.Select<InventoryItemId>
	|-Enumerable.WhereEnumerableIterator<InventoryItem>.Select<int>
	|-Enumerable.WhereEnumerableIterator<InventoryItem>.Select<object>
	|-Enumerable.WhereEnumerableIterator<InventoryItem>.Select<uint>
	|
	|-RVA: 0xC8CD60 Offset: 0xC8B360 VA: 0x180C8CD60
	|-Enumerable.WhereEnumerableIterator<ServerInfo>.Select<int>
	|-Enumerable.WhereEnumerableIterator<ServerInfo>.Select<object>
	|
	|-RVA: 0xC8CCD0 Offset: 0xC8B2D0 VA: 0x180C8CCD0
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe.Ingredient>.Select<PlayerItemRecipe.Ingredient>
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe.Ingredient>.Select<object>
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe>.Select<PlayerItemRecipe>
	*/

	public override IEnumerable<TSource> Where(Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A2230 Offset: 0x16A0830 VA: 0x1816A2230
	|-Enumerable.WhereEnumerableIterator<Debugging.EntityInfo>.Where
	|-Enumerable.WhereEnumerableIterator<GameStat.Stat>.Where
	|-Enumerable.WhereEnumerableIterator<PlayerItemRecipe>.Where
	|-Enumerable.WhereEnumerableIterator<ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, int>>.Where
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, object>>.Where
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<uint, object>>.Where
	|-Enumerable.WhereEnumerableIterator<Resolution>.Where
	|
	|-RVA: 0x19DC7F0 Offset: 0x19DADF0 VA: 0x1819DC7F0
	|-Enumerable.WhereEnumerableIterator<SkeletonDefinition.Bone>.Where
	|
	|-RVA: 0x19DC750 Offset: 0x19DAD50 VA: 0x1819DC750
	|-Enumerable.WhereEnumerableIterator<ItemSkinDirectory.Skin>.Where
	|-Enumerable.WhereEnumerableIterator<Option>.Where
	|-Enumerable.WhereEnumerableIterator<SkinnedMultiMesh.Part>.Where
	|-Enumerable.WhereEnumerableIterator<InventoryItem>.Where
	|
	|-RVA: 0x16A2190 Offset: 0x16A0790 VA: 0x1816A2190
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
	|-RVA: 0x19DC890 Offset: 0x19DAE90 VA: 0x1819DC890
	|-Enumerable.WhereEnumerableIterator<ServerInfo>.Where
	|
	|-RVA: 0x19DC930 Offset: 0x19DAF30 VA: 0x1819DC930
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
	|-RVA: 0x16A3B30 Offset: 0x16A2130 VA: 0x1816A3B30
	|-Enumerable.WhereArrayIterator<SkeletonDefinition.Bone>..ctor
	|
	|-RVA: 0x16A22D0 Offset: 0x16A08D0 VA: 0x1816A22D0
	|-Enumerable.WhereArrayIterator<GameStat.Stat>..ctor
	|-Enumerable.WhereArrayIterator<ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereArrayIterator<KeyValuePair<object, object>>..ctor
	|-Enumerable.WhereArrayIterator<KeyValuePair<uint, object>>..ctor
	|
	|-RVA: 0x16A3BA0 Offset: 0x16A21A0 VA: 0x1816A3BA0
	|-Enumerable.WhereArrayIterator<ItemSkinDirectory.Skin>..ctor
	|-Enumerable.WhereArrayIterator<Option>..ctor
	|-Enumerable.WhereArrayIterator<SkinnedMultiMesh.Part>..ctor
	|-Enumerable.WhereArrayIterator<InventoryItem>..ctor
	|
	|-RVA: 0x16A3C10 Offset: 0x16A2210 VA: 0x1816A3C10
	|-Enumerable.WhereArrayIterator<ServerInfo>..ctor
	|
	|-RVA: 0x16A3AC0 Offset: 0x16A20C0 VA: 0x1816A3AC0
	|-Enumerable.WhereArrayIterator<InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereArrayIterator<InventoryRecipe>..ctor
	|-Enumerable.WhereArrayIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>..ctor
	|
	|-RVA: 0x16A2340 Offset: 0x16A0940 VA: 0x1816A2340
	|-Enumerable.WhereArrayIterator<char>..ctor
	|-Enumerable.WhereArrayIterator<int>..ctor
	|-Enumerable.WhereArrayIterator<Int32Enum>..ctor
	|-Enumerable.WhereArrayIterator<object>..ctor
	*/

	public override Enumerable.Iterator<TSource> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A2430 Offset: 0x16A0A30 VA: 0x1816A2430
	|-Enumerable.WhereArrayIterator<SkeletonDefinition.Bone>.Clone
	|
	|-RVA: 0x16A1BD0 Offset: 0x16A01D0 VA: 0x1816A1BD0
	|-Enumerable.WhereArrayIterator<GameStat.Stat>.Clone
	|-Enumerable.WhereArrayIterator<ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereArrayIterator<KeyValuePair<object, object>>.Clone
	|-Enumerable.WhereArrayIterator<KeyValuePair<uint, object>>.Clone
	|
	|-RVA: 0x16A23B0 Offset: 0x16A09B0 VA: 0x1816A23B0
	|-Enumerable.WhereArrayIterator<ItemSkinDirectory.Skin>.Clone
	|-Enumerable.WhereArrayIterator<Option>.Clone
	|-Enumerable.WhereArrayIterator<SkinnedMultiMesh.Part>.Clone
	|-Enumerable.WhereArrayIterator<InventoryItem>.Clone
	|
	|-RVA: 0x16A24B0 Offset: 0x16A0AB0 VA: 0x1816A24B0
	|-Enumerable.WhereArrayIterator<ServerInfo>.Clone
	|
	|-RVA: 0x16A2540 Offset: 0x16A0B40 VA: 0x1816A2540
	|-Enumerable.WhereArrayIterator<InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereArrayIterator<InventoryRecipe>.Clone
	|-Enumerable.WhereArrayIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.Clone
	|
	|-RVA: 0x16A1C50 Offset: 0x16A0250 VA: 0x1816A1C50
	|-Enumerable.WhereArrayIterator<char>.Clone
	|-Enumerable.WhereArrayIterator<int>.Clone
	|-Enumerable.WhereArrayIterator<Int32Enum>.Clone
	|-Enumerable.WhereArrayIterator<object>.Clone
	*/

	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D7740 Offset: 0x19D5D40 VA: 0x1819D7740
	|-Enumerable.WhereArrayIterator<SkeletonDefinition.Bone>.MoveNext
	|
	|-RVA: 0x19D7660 Offset: 0x19D5C60 VA: 0x1819D7660
	|-Enumerable.WhereArrayIterator<GameStat.Stat>.MoveNext
	|-Enumerable.WhereArrayIterator<KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0x19D7560 Offset: 0x19D5B60 VA: 0x1819D7560
	|-Enumerable.WhereArrayIterator<ItemSkinDirectory.Skin>.MoveNext
	|-Enumerable.WhereArrayIterator<Option>.MoveNext
	|
	|-RVA: 0x19D7EE0 Offset: 0x19D64E0 VA: 0x1819D7EE0
	|-Enumerable.WhereArrayIterator<ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x19D7370 Offset: 0x19D5970 VA: 0x1819D7370
	|-Enumerable.WhereArrayIterator<ServerInfo>.MoveNext
	|
	|-RVA: 0x19D7B40 Offset: 0x19D6140 VA: 0x1819D7B40
	|-Enumerable.WhereArrayIterator<SkinnedMultiMesh.Part>.MoveNext
	|
	|-RVA: 0x19D7940 Offset: 0x19D5F40 VA: 0x1819D7940
	|-Enumerable.WhereArrayIterator<InventoryItem>.MoveNext
	|
	|-RVA: 0x19D7A40 Offset: 0x19D6040 VA: 0x1819D7A40
	|-Enumerable.WhereArrayIterator<InventoryRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereArrayIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.MoveNext
	|
	|-RVA: 0x19D7DE0 Offset: 0x19D63E0 VA: 0x1819D7DE0
	|-Enumerable.WhereArrayIterator<InventoryRecipe>.MoveNext
	|
	|-RVA: 0x19D72B0 Offset: 0x19D58B0 VA: 0x1819D72B0
	|-Enumerable.WhereArrayIterator<char>.MoveNext
	|
	|-RVA: 0x19D7D00 Offset: 0x19D6300 VA: 0x1819D7D00
	|-Enumerable.WhereArrayIterator<KeyValuePair<uint, object>>.MoveNext
	|
	|-RVA: 0x19D7C40 Offset: 0x19D6240 VA: 0x1819D7C40
	|-Enumerable.WhereArrayIterator<int>.MoveNext
	|-Enumerable.WhereArrayIterator<Int32Enum>.MoveNext
	|
	|-RVA: 0x19D7870 Offset: 0x19D5E70 VA: 0x1819D7870
	|-Enumerable.WhereArrayIterator<object>.MoveNext
	*/

	public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC8CF10 Offset: 0xC8B510 VA: 0x180C8CF10
	|-Enumerable.WhereArrayIterator<SkeletonDefinition.Bone>.Select<object>
	|
	|-RVA: 0xC8CE80 Offset: 0xC8B480 VA: 0x180C8CE80
	|-Enumerable.WhereArrayIterator<ProjectileWeaponMod.Modifier>.Select<float>
	|-Enumerable.WhereArrayIterator<KeyValuePair<object, object>>.Select<object>
	|-Enumerable.WhereArrayIterator<KeyValuePair<uint, object>>.Select<object>
	|-Enumerable.WhereArrayIterator<KeyValuePair<uint, object>>.Select<uint>
	|
	|-RVA: 0xC8CDF0 Offset: 0xC8B3F0 VA: 0x180C8CDF0
	|-Enumerable.WhereArrayIterator<Option>.Select<Option>
	|-Enumerable.WhereArrayIterator<SkinnedMultiMesh.Part>.Select<long>
	|-Enumerable.WhereArrayIterator<InventoryItem>.Select<InventoryItemId>
	|-Enumerable.WhereArrayIterator<InventoryItem>.Select<int>
	|-Enumerable.WhereArrayIterator<InventoryItem>.Select<object>
	|-Enumerable.WhereArrayIterator<InventoryItem>.Select<uint>
	|
	|-RVA: 0xC8CD60 Offset: 0xC8B360 VA: 0x180C8CD60
	|-Enumerable.WhereArrayIterator<ServerInfo>.Select<int>
	|-Enumerable.WhereArrayIterator<ServerInfo>.Select<object>
	|
	|-RVA: 0xC8CCD0 Offset: 0xC8B2D0 VA: 0x180C8CCD0
	|-Enumerable.WhereArrayIterator<InventoryRecipe.Ingredient>.Select<PlayerItemRecipe.Ingredient>
	|-Enumerable.WhereArrayIterator<InventoryRecipe.Ingredient>.Select<object>
	|-Enumerable.WhereArrayIterator<InventoryRecipe>.Select<PlayerItemRecipe>
	|
	|-RVA: 0xC8CC40 Offset: 0xC8B240 VA: 0x180C8CC40
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
	|-RVA: 0x19D81B0 Offset: 0x19D67B0 VA: 0x1819D81B0
	|-Enumerable.WhereArrayIterator<SkeletonDefinition.Bone>.Where
	|
	|-RVA: 0x19D8110 Offset: 0x19D6710 VA: 0x1819D8110
	|-Enumerable.WhereArrayIterator<GameStat.Stat>.Where
	|-Enumerable.WhereArrayIterator<ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereArrayIterator<KeyValuePair<object, object>>.Where
	|-Enumerable.WhereArrayIterator<KeyValuePair<uint, object>>.Where
	|
	|-RVA: 0x19D7FD0 Offset: 0x19D65D0 VA: 0x1819D7FD0
	|-Enumerable.WhereArrayIterator<ItemSkinDirectory.Skin>.Where
	|-Enumerable.WhereArrayIterator<Option>.Where
	|-Enumerable.WhereArrayIterator<SkinnedMultiMesh.Part>.Where
	|-Enumerable.WhereArrayIterator<InventoryItem>.Where
	|
	|-RVA: 0x19D8250 Offset: 0x19D6850 VA: 0x1819D8250
	|-Enumerable.WhereArrayIterator<ServerInfo>.Where
	|
	|-RVA: 0x19D82F0 Offset: 0x19D68F0 VA: 0x1819D82F0
	|-Enumerable.WhereArrayIterator<InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereArrayIterator<InventoryRecipe>.Where
	|-Enumerable.WhereArrayIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.Where
	|
	|-RVA: 0x19D8070 Offset: 0x19D6670 VA: 0x1819D8070
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
	|-RVA: 0x16A3B30 Offset: 0x16A2130 VA: 0x1816A3B30
	|-Enumerable.WhereListIterator<SkeletonDefinition.Bone>..ctor
	|
	|-RVA: 0x16A22D0 Offset: 0x16A08D0 VA: 0x1816A22D0
	|-Enumerable.WhereListIterator<GameStat.Stat>..ctor
	|-Enumerable.WhereListIterator<ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereListIterator<KeyValuePair<object, object>>..ctor
	|-Enumerable.WhereListIterator<KeyValuePair<uint, object>>..ctor
	|
	|-RVA: 0x16A3BA0 Offset: 0x16A21A0 VA: 0x1816A3BA0
	|-Enumerable.WhereListIterator<ItemSkinDirectory.Skin>..ctor
	|-Enumerable.WhereListIterator<Option>..ctor
	|-Enumerable.WhereListIterator<SkinnedMultiMesh.Part>..ctor
	|-Enumerable.WhereListIterator<InventoryItem>..ctor
	|
	|-RVA: 0x16A3C10 Offset: 0x16A2210 VA: 0x1816A3C10
	|-Enumerable.WhereListIterator<ServerInfo>..ctor
	|
	|-RVA: 0x16A3AC0 Offset: 0x16A20C0 VA: 0x1816A3AC0
	|-Enumerable.WhereListIterator<InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereListIterator<InventoryRecipe>..ctor
	|-Enumerable.WhereListIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>..ctor
	|
	|-RVA: 0x16A2340 Offset: 0x16A0940 VA: 0x1816A2340
	|-Enumerable.WhereListIterator<char>..ctor
	|-Enumerable.WhereListIterator<int>..ctor
	|-Enumerable.WhereListIterator<Int32Enum>..ctor
	|-Enumerable.WhereListIterator<object>..ctor
	*/

	public override Enumerable.Iterator<TSource> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A2430 Offset: 0x16A0A30 VA: 0x1816A2430
	|-Enumerable.WhereListIterator<SkeletonDefinition.Bone>.Clone
	|
	|-RVA: 0x16A1BD0 Offset: 0x16A01D0 VA: 0x1816A1BD0
	|-Enumerable.WhereListIterator<GameStat.Stat>.Clone
	|-Enumerable.WhereListIterator<ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereListIterator<KeyValuePair<object, object>>.Clone
	|-Enumerable.WhereListIterator<KeyValuePair<uint, object>>.Clone
	|
	|-RVA: 0x16A23B0 Offset: 0x16A09B0 VA: 0x1816A23B0
	|-Enumerable.WhereListIterator<ItemSkinDirectory.Skin>.Clone
	|-Enumerable.WhereListIterator<Option>.Clone
	|-Enumerable.WhereListIterator<SkinnedMultiMesh.Part>.Clone
	|-Enumerable.WhereListIterator<InventoryItem>.Clone
	|
	|-RVA: 0x16A24B0 Offset: 0x16A0AB0 VA: 0x1816A24B0
	|-Enumerable.WhereListIterator<ServerInfo>.Clone
	|
	|-RVA: 0x16A2540 Offset: 0x16A0B40 VA: 0x1816A2540
	|-Enumerable.WhereListIterator<InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereListIterator<InventoryRecipe>.Clone
	|-Enumerable.WhereListIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.Clone
	|
	|-RVA: 0x16A1C50 Offset: 0x16A0250 VA: 0x1816A1C50
	|-Enumerable.WhereListIterator<char>.Clone
	|-Enumerable.WhereListIterator<int>.Clone
	|-Enumerable.WhereListIterator<Int32Enum>.Clone
	|-Enumerable.WhereListIterator<object>.Clone
	*/

	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A25C0 Offset: 0x16A0BC0 VA: 0x1816A25C0
	|-Enumerable.WhereListIterator<SkeletonDefinition.Bone>.MoveNext
	|
	|-RVA: 0x16A2740 Offset: 0x16A0D40 VA: 0x1816A2740
	|-Enumerable.WhereListIterator<GameStat.Stat>.MoveNext
	|-Enumerable.WhereListIterator<KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0x16A2AD0 Offset: 0x16A10D0 VA: 0x1816A2AD0
	|-Enumerable.WhereListIterator<ItemSkinDirectory.Skin>.MoveNext
	|-Enumerable.WhereListIterator<Option>.MoveNext
	|
	|-RVA: 0x16A2860 Offset: 0x16A0E60 VA: 0x1816A2860
	|-Enumerable.WhereListIterator<ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x16A2C20 Offset: 0x16A1220 VA: 0x1816A2C20
	|-Enumerable.WhereListIterator<ServerInfo>.MoveNext
	|
	|-RVA: 0x16A34B0 Offset: 0x16A1AB0 VA: 0x1816A34B0
	|-Enumerable.WhereListIterator<SkinnedMultiMesh.Part>.MoveNext
	|
	|-RVA: 0x16A2980 Offset: 0x16A0F80 VA: 0x1816A2980
	|-Enumerable.WhereListIterator<InventoryItem>.MoveNext
	|
	|-RVA: 0x16A30D0 Offset: 0x16A16D0 VA: 0x1816A30D0
	|-Enumerable.WhereListIterator<InventoryRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereListIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.MoveNext
	|
	|-RVA: 0x16A3350 Offset: 0x16A1950 VA: 0x1816A3350
	|-Enumerable.WhereListIterator<InventoryRecipe>.MoveNext
	|
	|-RVA: 0x16A3600 Offset: 0x16A1C00 VA: 0x1816A3600
	|-Enumerable.WhereListIterator<char>.MoveNext
	|
	|-RVA: 0x16A3230 Offset: 0x16A1830 VA: 0x1816A3230
	|-Enumerable.WhereListIterator<KeyValuePair<uint, object>>.MoveNext
	|
	|-RVA: 0x16A2FD0 Offset: 0x16A15D0 VA: 0x1816A2FD0
	|-Enumerable.WhereListIterator<int>.MoveNext
	|-Enumerable.WhereListIterator<Int32Enum>.MoveNext
	|
	|-RVA: 0x16A2EC0 Offset: 0x16A14C0 VA: 0x1816A2EC0
	|-Enumerable.WhereListIterator<object>.MoveNext
	*/

	public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC8CF10 Offset: 0xC8B510 VA: 0x180C8CF10
	|-Enumerable.WhereListIterator<SkeletonDefinition.Bone>.Select<object>
	|
	|-RVA: 0xC8CE80 Offset: 0xC8B480 VA: 0x180C8CE80
	|-Enumerable.WhereListIterator<ProjectileWeaponMod.Modifier>.Select<float>
	|-Enumerable.WhereListIterator<KeyValuePair<object, object>>.Select<object>
	|-Enumerable.WhereListIterator<KeyValuePair<uint, object>>.Select<object>
	|-Enumerable.WhereListIterator<KeyValuePair<uint, object>>.Select<uint>
	|
	|-RVA: 0xC8CDF0 Offset: 0xC8B3F0 VA: 0x180C8CDF0
	|-Enumerable.WhereListIterator<Option>.Select<Option>
	|-Enumerable.WhereListIterator<SkinnedMultiMesh.Part>.Select<long>
	|-Enumerable.WhereListIterator<InventoryItem>.Select<InventoryItemId>
	|-Enumerable.WhereListIterator<InventoryItem>.Select<int>
	|-Enumerable.WhereListIterator<InventoryItem>.Select<object>
	|-Enumerable.WhereListIterator<InventoryItem>.Select<uint>
	|
	|-RVA: 0xC8CD60 Offset: 0xC8B360 VA: 0x180C8CD60
	|-Enumerable.WhereListIterator<ServerInfo>.Select<int>
	|-Enumerable.WhereListIterator<ServerInfo>.Select<object>
	|
	|-RVA: 0xC8CCD0 Offset: 0xC8B2D0 VA: 0x180C8CCD0
	|-Enumerable.WhereListIterator<InventoryRecipe.Ingredient>.Select<PlayerItemRecipe.Ingredient>
	|-Enumerable.WhereListIterator<InventoryRecipe.Ingredient>.Select<object>
	|-Enumerable.WhereListIterator<InventoryRecipe>.Select<PlayerItemRecipe>
	|
	|-RVA: 0xC8CC40 Offset: 0xC8B240 VA: 0x180C8CC40
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
	|-RVA: 0x16A3A20 Offset: 0x16A2020 VA: 0x1816A3A20
	|-Enumerable.WhereListIterator<SkeletonDefinition.Bone>.Where
	|
	|-RVA: 0x16A3700 Offset: 0x16A1D00 VA: 0x1816A3700
	|-Enumerable.WhereListIterator<GameStat.Stat>.Where
	|-Enumerable.WhereListIterator<ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereListIterator<KeyValuePair<object, object>>.Where
	|-Enumerable.WhereListIterator<KeyValuePair<uint, object>>.Where
	|
	|-RVA: 0x16A37A0 Offset: 0x16A1DA0 VA: 0x1816A37A0
	|-Enumerable.WhereListIterator<ItemSkinDirectory.Skin>.Where
	|-Enumerable.WhereListIterator<Option>.Where
	|-Enumerable.WhereListIterator<SkinnedMultiMesh.Part>.Where
	|-Enumerable.WhereListIterator<InventoryItem>.Where
	|
	|-RVA: 0x16A3980 Offset: 0x16A1F80 VA: 0x1816A3980
	|-Enumerable.WhereListIterator<ServerInfo>.Where
	|
	|-RVA: 0x16A38E0 Offset: 0x16A1EE0 VA: 0x1816A38E0
	|-Enumerable.WhereListIterator<InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereListIterator<InventoryRecipe>.Where
	|-Enumerable.WhereListIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.Where
	|
	|-RVA: 0x16A3840 Offset: 0x16A1E40 VA: 0x1816A3840
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
	|-RVA: 0x16A8EE0 Offset: 0x16A74E0 VA: 0x1816A8EE0
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
	|-RVA: 0x16A8F70 Offset: 0x16A7570 VA: 0x1816A8F70
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
	|-RVA: 0x16A9090 Offset: 0x16A7690 VA: 0x1816A9090
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
	|-RVA: 0x16A9000 Offset: 0x16A7600 VA: 0x1816A9000
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
	|-RVA: 0x16A9120 Offset: 0x16A7720 VA: 0x1816A9120
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, ServerInfo>..ctor
	*/

	public override Enumerable.Iterator<TResult> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A3DC0 Offset: 0x16A23C0 VA: 0x1816A3DC0
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
	|-RVA: 0x16A3C80 Offset: 0x16A2280 VA: 0x1816A3C80
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
	|-RVA: 0x16A3D20 Offset: 0x16A2320 VA: 0x1816A3D20
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
	|-RVA: 0x16A3E60 Offset: 0x16A2460 VA: 0x1816A3E60
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
	|-RVA: 0x16A3F00 Offset: 0x16A2500 VA: 0x1816A3F00
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, ServerInfo>.Clone
	*/

	public override void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C03A0 Offset: 0x19BE9A0 VA: 0x1819C03A0
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, FourBitNumber>.Dispose
	|
	|-RVA: 0x19BFE90 Offset: 0x19BE490 VA: 0x1819BFE90
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, SevenBitNumber>.Dispose
	|
	|-RVA: 0x19BFD70 Offset: 0x19BE370 VA: 0x1819BFD70
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, int>.Dispose
	|
	|-RVA: 0x19C04C0 Offset: 0x19BEAC0 VA: 0x1819C04C0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x19C0550 Offset: 0x19BEB50 VA: 0x1819C0550
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, PathFinder.Point>.Dispose
	|
	|-RVA: 0x19C0430 Offset: 0x19BEA30 VA: 0x1819C0430
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x19C0040 Offset: 0x19BE640 VA: 0x1819C0040
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Option>.Dispose
	|
	|-RVA: 0x19C01F0 Offset: 0x19BE7F0 VA: 0x1819C01F0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, InventoryItem>.Dispose
	|
	|-RVA: 0x19C0160 Offset: 0x19BE760 VA: 0x1819C0160
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x19BFE00 Offset: 0x19BE400 VA: 0x1819BFE00
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, InventoryRecipe>.Dispose
	|
	|-RVA: 0x19C00D0 Offset: 0x19BE6D0 VA: 0x1819C00D0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, bool>.Dispose
	|
	|-RVA: 0x19BFCE0 Offset: 0x19BE2E0 VA: 0x1819BFCE0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x19BFF20 Offset: 0x19BE520 VA: 0x1819BFF20
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, int>.Dispose
	|
	|-RVA: 0x19BFFB0 Offset: 0x19BE5B0 VA: 0x1819BFFB0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Int32Enum>.Dispose
	|
	|-RVA: 0x19C0310 Offset: 0x19BE910 VA: 0x1819C0310
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, long>.Dispose
	|
	|-RVA: 0x19C0280 Offset: 0x19BE880 VA: 0x1819C0280
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, object>.Dispose
	|
	|-RVA: 0x1A187D0 Offset: 0x1A16DD0 VA: 0x181A187D0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, float>.Dispose
	|
	|-RVA: 0x1A19B80 Offset: 0x1A18180 VA: 0x181A19B80
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Resolution>.Dispose
	|
	|-RVA: 0x1A19820 Offset: 0x1A17E20 VA: 0x181A19820
	|-Enumerable.WhereSelectEnumerableIterator<WeightedStringList.Container, float>.Dispose
	|
	|-RVA: 0x1A17AE0 Offset: 0x1A160E0 VA: 0x181A17AE0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A18D70 Offset: 0x1A17370 VA: 0x181A18D70
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A19C10 Offset: 0x1A18210 VA: 0x181A19C10
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A168E0 Offset: 0x1A14EE0 VA: 0x181A168E0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Option>.Dispose
	|
	|-RVA: 0x1A18CE0 Offset: 0x1A172E0 VA: 0x181A18CE0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, InventoryItem>.Dispose
	|
	|-RVA: 0x1A17930 Offset: 0x1A15F30 VA: 0x181A17930
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A17E40 Offset: 0x1A16440 VA: 0x181A17E40
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A17F60 Offset: 0x1A16560 VA: 0x181A17F60
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, bool>.Dispose
	|
	|-RVA: 0x1A19AF0 Offset: 0x1A180F0 VA: 0x181A19AF0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A19310 Offset: 0x1A17910 VA: 0x181A19310
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, int>.Dispose
	|
	|-RVA: 0x1A17B70 Offset: 0x1A16170 VA: 0x181A17B70
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Int32Enum>.Dispose
	|
	|-RVA: 0x1A17ED0 Offset: 0x1A164D0 VA: 0x181A17ED0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, long>.Dispose
	|
	|-RVA: 0x1A18620 Offset: 0x1A16C20 VA: 0x181A18620
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, object>.Dispose
	|
	|-RVA: 0x1A16970 Offset: 0x1A14F70 VA: 0x181A16970
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, float>.Dispose
	|
	|-RVA: 0x1A18470 Offset: 0x1A16A70 VA: 0x181A18470
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Resolution>.Dispose
	|
	|-RVA: 0x1A174B0 Offset: 0x1A15AB0 VA: 0x181A174B0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, FourBitNumber>.Dispose
	|
	|-RVA: 0x1A18E00 Offset: 0x1A17400 VA: 0x181A18E00
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, SevenBitNumber>.Dispose
	|
	|-RVA: 0x1A190D0 Offset: 0x1A176D0 VA: 0x181A190D0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, int>.Dispose
	|
	|-RVA: 0x1A176F0 Offset: 0x1A15CF0 VA: 0x181A176F0
	|-Enumerable.WhereSelectEnumerableIterator<ProjectileWeaponMod.Modifier, float>.Dispose
	|
	|-RVA: 0x1A16BB0 Offset: 0x1A151B0 VA: 0x181A16BB0
	|-Enumerable.WhereSelectEnumerableIterator<Option, Option>.Dispose
	|
	|-RVA: 0x1A18AA0 Offset: 0x1A170A0 VA: 0x181A18AA0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A18860 Offset: 0x1A16E60 VA: 0x181A18860
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, FourBitNumber>.Dispose
	|
	|-RVA: 0x1A17810 Offset: 0x1A15E10 VA: 0x181A17810
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, SevenBitNumber>.Dispose
	|
	|-RVA: 0x1A191F0 Offset: 0x1A177F0 VA: 0x181A191F0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A175D0 Offset: 0x1A15BD0 VA: 0x181A175D0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A18E90 Offset: 0x1A17490 VA: 0x181A18E90
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Option>.Dispose
	|
	|-RVA: 0x1A18B30 Offset: 0x1A17130 VA: 0x181A18B30
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, InventoryItem>.Dispose
	|
	|-RVA: 0x1A16A00 Offset: 0x1A15000 VA: 0x181A16A00
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A16C40 Offset: 0x1A15240 VA: 0x181A16C40
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A181A0 Offset: 0x1A167A0 VA: 0x181A181A0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, bool>.Dispose
	|
	|-RVA: 0x1A16FA0 Offset: 0x1A155A0 VA: 0x181A16FA0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A188F0 Offset: 0x1A16EF0 VA: 0x181A188F0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, int>.Dispose
	|
	|-RVA: 0x1A17C90 Offset: 0x1A16290 VA: 0x181A17C90
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Int32Enum>.Dispose
	|
	|-RVA: 0x1A17420 Offset: 0x1A15A20 VA: 0x181A17420
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, long>.Dispose
	|
	|-RVA: 0x1A18350 Offset: 0x1A16950 VA: 0x181A18350
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.Dispose
	|
	|-RVA: 0x1A167C0 Offset: 0x1A14DC0 VA: 0x181A167C0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, float>.Dispose
	|
	|-RVA: 0x1A166A0 Offset: 0x1A14CA0 VA: 0x181A166A0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Resolution>.Dispose
	|
	|-RVA: 0x1A17540 Offset: 0x1A15B40 VA: 0x181A17540
	|-Enumerable.WhereSelectEnumerableIterator<SkinnedMultiMesh.Part, long>.Dispose
	|
	|-RVA: 0x1A170C0 Offset: 0x1A156C0 VA: 0x181A170C0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A178A0 Offset: 0x1A15EA0 VA: 0x181A178A0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A16610 Offset: 0x1A14C10 VA: 0x181A16610
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A17780 Offset: 0x1A15D80 VA: 0x181A17780
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Option>.Dispose
	|
	|-RVA: 0x1A18110 Offset: 0x1A16710 VA: 0x181A18110
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, InventoryItem>.Dispose
	|
	|-RVA: 0x1A18740 Offset: 0x1A16D40 VA: 0x181A18740
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A193A0 Offset: 0x1A179A0 VA: 0x181A193A0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A17A50 Offset: 0x1A16050 VA: 0x181A17A50
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, bool>.Dispose
	|
	|-RVA: 0x1A17030 Offset: 0x1A15630 VA: 0x181A17030
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A16460 Offset: 0x1A14A60 VA: 0x181A16460
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, int>.Dispose
	|
	|-RVA: 0x1A17FF0 Offset: 0x1A165F0 VA: 0x181A17FF0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Int32Enum>.Dispose
	|
	|-RVA: 0x1A18080 Offset: 0x1A16680 VA: 0x181A18080
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, long>.Dispose
	|
	|-RVA: 0x1A16850 Offset: 0x1A14E50 VA: 0x181A16850
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, object>.Dispose
	|
	|-RVA: 0x1A195E0 Offset: 0x1A17BE0 VA: 0x181A195E0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, float>.Dispose
	|
	|-RVA: 0x1A19040 Offset: 0x1A17640 VA: 0x181A19040
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Resolution>.Dispose
	|
	|-RVA: 0x1A198B0 Offset: 0x1A17EB0 VA: 0x181A198B0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A16A90 Offset: 0x1A15090 VA: 0x181A16A90
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A19160 Offset: 0x1A17760 VA: 0x181A19160
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A19550 Offset: 0x1A17B50 VA: 0x181A19550
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Option>.Dispose
	|
	|-RVA: 0x1A19670 Offset: 0x1A17C70 VA: 0x181A19670
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, InventoryItem>.Dispose
	|
	|-RVA: 0x1A18A10 Offset: 0x1A17010 VA: 0x181A18A10
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A17150 Offset: 0x1A15750 VA: 0x181A17150
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A16730 Offset: 0x1A14D30 VA: 0x181A16730
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, bool>.Dispose
	|
	|-RVA: 0x1A18F20 Offset: 0x1A17520 VA: 0x181A18F20
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A18980 Offset: 0x1A16F80 VA: 0x181A18980
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, int>.Dispose
	|
	|-RVA: 0x1A194C0 Offset: 0x1A17AC0 VA: 0x181A194C0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Int32Enum>.Dispose
	|
	|-RVA: 0x1A186B0 Offset: 0x1A16CB0 VA: 0x181A186B0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, long>.Dispose
	|
	|-RVA: 0x1A164F0 Offset: 0x1A14AF0 VA: 0x181A164F0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, object>.Dispose
	|
	|-RVA: 0x1A17660 Offset: 0x1A15C60 VA: 0x181A17660
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, float>.Dispose
	|
	|-RVA: 0x1A179C0 Offset: 0x1A15FC0 VA: 0x181A179C0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Resolution>.Dispose
	|
	|-RVA: 0x1A19700 Offset: 0x1A17D00 VA: 0x181A19700
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, ServerInfo>.Dispose
	|
	|-RVA: 0x1A18590 Offset: 0x1A16B90 VA: 0x181A18590
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, int>.Dispose
	|
	|-RVA: 0x1A16580 Offset: 0x1A14B80 VA: 0x181A16580
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.Dispose
	|
	|-RVA: 0x1A171E0 Offset: 0x1A157E0 VA: 0x181A171E0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A16CD0 Offset: 0x1A152D0 VA: 0x181A16CD0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A19790 Offset: 0x1A17D90 VA: 0x181A19790
	|-Enumerable.WhereSelectEnumerableIterator<Friend, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A18500 Offset: 0x1A16B00 VA: 0x181A18500
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Option>.Dispose
	|
	|-RVA: 0x1A19430 Offset: 0x1A17A30 VA: 0x181A19430
	|-Enumerable.WhereSelectEnumerableIterator<Friend, InventoryItem>.Dispose
	|
	|-RVA: 0x1A16E80 Offset: 0x1A15480 VA: 0x181A16E80
	|-Enumerable.WhereSelectEnumerableIterator<Friend, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A183E0 Offset: 0x1A169E0 VA: 0x181A183E0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A16F10 Offset: 0x1A15510 VA: 0x181A16F10
	|-Enumerable.WhereSelectEnumerableIterator<Friend, bool>.Dispose
	|
	|-RVA: 0x1A19A60 Offset: 0x1A18060 VA: 0x181A19A60
	|-Enumerable.WhereSelectEnumerableIterator<Friend, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A18BC0 Offset: 0x1A171C0 VA: 0x181A18BC0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, int>.Dispose
	|
	|-RVA: 0x1A182C0 Offset: 0x1A168C0 VA: 0x181A182C0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Int32Enum>.Dispose
	|
	|-RVA: 0x1A16DF0 Offset: 0x1A153F0 VA: 0x181A16DF0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, long>.Dispose
	|
	|-RVA: 0x1A18230 Offset: 0x1A16830 VA: 0x181A18230
	|-Enumerable.WhereSelectEnumerableIterator<Friend, object>.Dispose
	|
	|-RVA: 0x1A17C00 Offset: 0x1A16200 VA: 0x181A17C00
	|-Enumerable.WhereSelectEnumerableIterator<Friend, float>.Dispose
	|
	|-RVA: 0x1A17DB0 Offset: 0x1A163B0 VA: 0x181A17DB0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Resolution>.Dispose
	|
	|-RVA: 0x1A19940 Offset: 0x1A17F40 VA: 0x181A19940
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A17300 Offset: 0x1A15900 VA: 0x181A17300
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, FourBitNumber>.Dispose
	|
	|-RVA: 0x1A19280 Offset: 0x1A17880 VA: 0x181A19280
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, SevenBitNumber>.Dispose
	|
	|-RVA: 0x1A16B20 Offset: 0x1A15120 VA: 0x181A16B20
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A163D0 Offset: 0x1A149D0 VA: 0x181A163D0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A18FB0 Offset: 0x1A175B0 VA: 0x181A18FB0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Option>.Dispose
	|
	|-RVA: 0x1A17270 Offset: 0x1A15870 VA: 0x181A17270
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryItemId>.Dispose
	|
	|-RVA: 0x1A16D60 Offset: 0x1A15360 VA: 0x181A16D60
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryItem>.Dispose
	|
	|-RVA: 0x1A17D20 Offset: 0x1A16320 VA: 0x181A17D20
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A17390 Offset: 0x1A15990 VA: 0x181A17390
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A18C50 Offset: 0x1A17250 VA: 0x181A18C50
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, bool>.Dispose
	|
	|-RVA: 0x1A199D0 Offset: 0x1A17FD0 VA: 0x181A199D0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A29BD0 Offset: 0x1A281D0 VA: 0x181A29BD0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, int>.Dispose
	|
	|-RVA: 0x1A277D0 Offset: 0x1A25DD0 VA: 0x181A277D0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Int32Enum>.Dispose
	|
	|-RVA: 0x1A278F0 Offset: 0x1A25EF0 VA: 0x181A278F0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, long>.Dispose
	|
	|-RVA: 0x1A26C00 Offset: 0x1A25200 VA: 0x181A26C00
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, object>.Dispose
	|
	|-RVA: 0x1A28E50 Offset: 0x1A27450 VA: 0x181A28E50
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, float>.Dispose
	|
	|-RVA: 0x1A273E0 Offset: 0x1A259E0 VA: 0x181A273E0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, uint>.Dispose
	|
	|-RVA: 0x1A27C50 Offset: 0x1A26250 VA: 0x181A27C50
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Resolution>.Dispose
	|
	|-RVA: 0x1A27E00 Offset: 0x1A26400 VA: 0x181A27E00
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem.Amount, InventoryItemId>.Dispose
	|
	|-RVA: 0x1A2A050 Offset: 0x1A28650 VA: 0x181A2A050
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem.Amount, uint>.Dispose
	|
	|-RVA: 0x1A28B80 Offset: 0x1A27180 VA: 0x181A28B80
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe, PlayerItemRecipe>.Dispose
	|
	|-RVA: 0x1A293F0 Offset: 0x1A279F0 VA: 0x181A293F0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe, object>.Dispose
	|
	|-RVA: 0x1A26FF0 Offset: 0x1A255F0 VA: 0x181A26FF0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A27740 Offset: 0x1A25D40 VA: 0x181A27740
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A29E10 Offset: 0x1A28410 VA: 0x181A29E10
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A29C60 Offset: 0x1A28260 VA: 0x181A29C60
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A29750 Offset: 0x1A27D50 VA: 0x181A29750
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Option>.Dispose
	|
	|-RVA: 0x1A29000 Offset: 0x1A27600 VA: 0x181A29000
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, InventoryItem>.Dispose
	|
	|-RVA: 0x1A29240 Offset: 0x1A27840 VA: 0x181A29240
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A27620 Offset: 0x1A25C20 VA: 0x181A27620
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A26DB0 Offset: 0x1A253B0 VA: 0x181A26DB0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, bool>.Dispose
	|
	|-RVA: 0x1A27590 Offset: 0x1A25B90 VA: 0x181A27590
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A29360 Offset: 0x1A27960 VA: 0x181A29360
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, int>.Dispose
	|
	|-RVA: 0x1A288B0 Offset: 0x1A26EB0 VA: 0x181A288B0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Int32Enum>.Dispose
	|
	|-RVA: 0x1A29CF0 Offset: 0x1A282F0 VA: 0x181A29CF0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, long>.Dispose
	|
	|-RVA: 0x1A28790 Offset: 0x1A26D90 VA: 0x181A28790
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, object>.Dispose
	|
	|-RVA: 0x1A297E0 Offset: 0x1A27DE0 VA: 0x181A297E0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, float>.Dispose
	|
	|-RVA: 0x1A27230 Offset: 0x1A25830 VA: 0x181A27230
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Resolution>.Dispose
	|
	|-RVA: 0x1A28D30 Offset: 0x1A27330 VA: 0x181A28D30
	|-Enumerable.WhereSelectEnumerableIterator<DictionaryEntry, KeyValuePair<object, object>>.Dispose
	|
	|-RVA: 0x1A27500 Offset: 0x1A25B00 VA: 0x181A27500
	|-Enumerable.WhereSelectEnumerableIterator<DictionaryEntry, object>.Dispose
	|
	|-RVA: 0x1A269C0 Offset: 0x1A24FC0 VA: 0x181A269C0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A28670 Offset: 0x1A26C70 VA: 0x181A28670
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A26B70 Offset: 0x1A25170 VA: 0x181A26B70
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A27110 Offset: 0x1A25710 VA: 0x181A27110
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Option>.Dispose
	|
	|-RVA: 0x1A28A60 Offset: 0x1A27060 VA: 0x181A28A60
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, InventoryItem>.Dispose
	|
	|-RVA: 0x1A281F0 Offset: 0x1A267F0 VA: 0x181A281F0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A28AF0 Offset: 0x1A270F0 VA: 0x181A28AF0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A27E90 Offset: 0x1A26490 VA: 0x181A27E90
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, bool>.Dispose
	|
	|-RVA: 0x1A291B0 Offset: 0x1A277B0 VA: 0x181A291B0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A29FC0 Offset: 0x1A285C0 VA: 0x181A29FC0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, int>.Dispose
	|
	|-RVA: 0x1A27A10 Offset: 0x1A26010 VA: 0x181A27A10
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Int32Enum>.Dispose
	|
	|-RVA: 0x1A26AE0 Offset: 0x1A250E0 VA: 0x181A26AE0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, long>.Dispose
	|
	|-RVA: 0x1A271A0 Offset: 0x1A257A0 VA: 0x181A271A0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Dispose
	|
	|-RVA: 0x1A29870 Offset: 0x1A27E70 VA: 0x181A29870
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, float>.Dispose
	|
	|-RVA: 0x1A27080 Offset: 0x1A25680 VA: 0x181A27080
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Resolution>.Dispose
	|
	|-RVA: 0x1A27B30 Offset: 0x1A26130 VA: 0x181A27B30
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A29630 Offset: 0x1A27C30 VA: 0x181A29630
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A26ED0 Offset: 0x1A254D0 VA: 0x181A26ED0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A29A20 Offset: 0x1A28020 VA: 0x181A29A20
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Option>.Dispose
	|
	|-RVA: 0x1A29F30 Offset: 0x1A28530 VA: 0x181A29F30
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, InventoryItem>.Dispose
	|
	|-RVA: 0x1A28940 Offset: 0x1A26F40 VA: 0x181A28940
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A29AB0 Offset: 0x1A280B0 VA: 0x181A29AB0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A28F70 Offset: 0x1A27570 VA: 0x181A28F70
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, bool>.Dispose
	|
	|-RVA: 0x1A27AA0 Offset: 0x1A260A0 VA: 0x181A27AA0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A26E40 Offset: 0x1A25440 VA: 0x181A26E40
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, int>.Dispose
	|
	|-RVA: 0x1A28C10 Offset: 0x1A27210 VA: 0x181A28C10
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Int32Enum>.Dispose
	|
	|-RVA: 0x1A27350 Offset: 0x1A25950 VA: 0x181A27350
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, long>.Dispose
	|
	|-RVA: 0x1A29900 Offset: 0x1A27F00 VA: 0x181A29900
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, object>.Dispose
	|
	|-RVA: 0x1A272C0 Offset: 0x1A258C0 VA: 0x181A272C0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, float>.Dispose
	|
	|-RVA: 0x1A27470 Offset: 0x1A25A70 VA: 0x181A27470
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, uint>.Dispose
	|
	|-RVA: 0x1A28430 Offset: 0x1A26A30 VA: 0x181A28430
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Resolution>.Dispose
	|
	|-RVA: 0x1A296C0 Offset: 0x1A27CC0 VA: 0x181A296C0
	|-Enumerable.WhereSelectEnumerableIterator<int, FourBitNumber>.Dispose
	|
	|-RVA: 0x1A29120 Offset: 0x1A27720 VA: 0x181A29120
	|-Enumerable.WhereSelectEnumerableIterator<int, SevenBitNumber>.Dispose
	|
	|-RVA: 0x1A28700 Offset: 0x1A26D00 VA: 0x181A28700
	|-Enumerable.WhereSelectEnumerableIterator<int, int>.Dispose
	|
	|-RVA: 0x1A28820 Offset: 0x1A26E20 VA: 0x181A28820
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A29EA0 Offset: 0x1A284A0 VA: 0x181A29EA0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A28310 Offset: 0x1A26910 VA: 0x181A28310
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A28280 Offset: 0x1A26880 VA: 0x181A28280
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Option>.Dispose
	|
	|-RVA: 0x1A28550 Offset: 0x1A26B50 VA: 0x181A28550
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, InventoryItem>.Dispose
	|
	|-RVA: 0x1A285E0 Offset: 0x1A26BE0 VA: 0x181A285E0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A27D70 Offset: 0x1A26370 VA: 0x181A27D70
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A27BC0 Offset: 0x1A261C0 VA: 0x181A27BC0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, bool>.Dispose
	|
	|-RVA: 0x1A29090 Offset: 0x1A27690 VA: 0x181A29090
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A29B40 Offset: 0x1A28140 VA: 0x181A29B40
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, int>.Dispose
	|
	|-RVA: 0x1A292D0 Offset: 0x1A278D0 VA: 0x181A292D0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Int32Enum>.Dispose
	|
	|-RVA: 0x1A29990 Offset: 0x1A27F90 VA: 0x181A29990
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, long>.Dispose
	|
	|-RVA: 0x1A28040 Offset: 0x1A26640 VA: 0x181A28040
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Dispose
	|
	|-RVA: 0x1A283A0 Offset: 0x1A269A0 VA: 0x181A283A0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, float>.Dispose
	|
	|-RVA: 0x1A26D20 Offset: 0x1A25320 VA: 0x181A26D20
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Resolution>.Dispose
	|
	|-RVA: 0x1A284C0 Offset: 0x1A26AC0 VA: 0x181A284C0
	|-Enumerable.WhereSelectEnumerableIterator<object, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A280D0 Offset: 0x1A266D0 VA: 0x181A280D0
	|-Enumerable.WhereSelectEnumerableIterator<object, FourBitNumber>.Dispose
	|
	|-RVA: 0x1A28CA0 Offset: 0x1A272A0 VA: 0x181A28CA0
	|-Enumerable.WhereSelectEnumerableIterator<object, SevenBitNumber>.Dispose
	|
	|-RVA: 0x1A276B0 Offset: 0x1A25CB0 VA: 0x181A276B0
	|-Enumerable.WhereSelectEnumerableIterator<object, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A26C90 Offset: 0x1A25290 VA: 0x181A26C90
	|-Enumerable.WhereSelectEnumerableIterator<object, PlayerItemRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A26930 Offset: 0x1A24F30 VA: 0x181A26930
	|-Enumerable.WhereSelectEnumerableIterator<object, PlayerItemRecipe>.Dispose
	|
	|-RVA: 0x1A29D80 Offset: 0x1A28380 VA: 0x181A29D80
	|-Enumerable.WhereSelectEnumerableIterator<object, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A26A50 Offset: 0x1A25050 VA: 0x181A26A50
	|-Enumerable.WhereSelectEnumerableIterator<object, Option>.Dispose
	|
	|-RVA: 0x1A28160 Offset: 0x1A26760 VA: 0x181A28160
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryItemId>.Dispose
	|
	|-RVA: 0x1A26F60 Offset: 0x1A25560 VA: 0x181A26F60
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryItem>.Dispose
	|
	|-RVA: 0x1A27860 Offset: 0x1A25E60 VA: 0x181A27860
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A27980 Offset: 0x1A25F80 VA: 0x181A27980
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A29510 Offset: 0x1A27B10 VA: 0x181A29510
	|-Enumerable.WhereSelectEnumerableIterator<object, bool>.Dispose
	|
	|-RVA: 0x1A289D0 Offset: 0x1A26FD0 VA: 0x181A289D0
	|-Enumerable.WhereSelectEnumerableIterator<object, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A27F20 Offset: 0x1A26520 VA: 0x181A27F20
	|-Enumerable.WhereSelectEnumerableIterator<object, int>.Dispose
	|
	|-RVA: 0x1A28DC0 Offset: 0x1A273C0 VA: 0x181A28DC0
	|-Enumerable.WhereSelectEnumerableIterator<object, Int32Enum>.Dispose
	|
	|-RVA: 0x1A27FB0 Offset: 0x1A265B0 VA: 0x181A27FB0
	|-Enumerable.WhereSelectEnumerableIterator<object, long>.Dispose
	|
	|-RVA: 0x1A27CE0 Offset: 0x1A262E0 VA: 0x181A27CE0
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Dispose
	|
	|-RVA: 0x1A29480 Offset: 0x1A27A80 VA: 0x181A29480
	|-Enumerable.WhereSelectEnumerableIterator<object, float>.Dispose
	|
	|-RVA: 0x1A295A0 Offset: 0x1A27BA0 VA: 0x181A295A0
	|-Enumerable.WhereSelectEnumerableIterator<object, uint>.Dispose
	|
	|-RVA: 0x1A28EE0 Offset: 0x1A274E0 VA: 0x181A28EE0
	|-Enumerable.WhereSelectEnumerableIterator<object, Resolution>.Dispose
	*/

	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C0D40 Offset: 0x19BF340 VA: 0x1819C0D40
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, FourBitNumber>.MoveNext
	|
	|-RVA: 0x19C1610 Offset: 0x19BFC10 VA: 0x1819C1610
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, SevenBitNumber>.MoveNext
	|
	|-RVA: 0x19C19F0 Offset: 0x19BFFF0 VA: 0x1819C19F0
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, int>.MoveNext
	|
	|-RVA: 0x19C1B70 Offset: 0x19C0170 VA: 0x1819C1B70
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x19C0860 Offset: 0x19BEE60 VA: 0x1819C0860
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x19C13A0 Offset: 0x19BF9A0 VA: 0x1819C13A0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x19C22B0 Offset: 0x19C08B0 VA: 0x1819C22B0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Option>.MoveNext
	|
	|-RVA: 0x19C0EC0 Offset: 0x19BF4C0 VA: 0x1819C0EC0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, InventoryItem>.MoveNext
	|
	|-RVA: 0x19C0AC0 Offset: 0x19BF0C0 VA: 0x1819C0AC0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x19C05E0 Offset: 0x19BEBE0 VA: 0x1819C05E0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x19C1DE0 Offset: 0x19C03E0 VA: 0x1819C1DE0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, bool>.MoveNext
	|
	|-RVA: 0x19C2040 Offset: 0x19C0640 VA: 0x1819C2040
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x19C1790 Offset: 0x19BFD90 VA: 0x1819C1790
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, int>.MoveNext
	|
	|-RVA: 0x19C2530 Offset: 0x19C0B30 VA: 0x1819C2530
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Int32Enum>.MoveNext
	|
	|-RVA: 0x19C1140 Offset: 0x19BF740 VA: 0x1819C1140
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, long>.MoveNext
	|
	|-RVA: 0x19C2790 Offset: 0x19C0D90 VA: 0x1819C2790
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, object>.MoveNext
	|
	|-RVA: 0x1A24C40 Offset: 0x1A23240 VA: 0x181A24C40
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, float>.MoveNext
	|
	|-RVA: 0x1A1C340 Offset: 0x1A1A940 VA: 0x181A1C340
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Resolution>.MoveNext
	|
	|-RVA: 0x1A1EE60 Offset: 0x1A1D460 VA: 0x181A1EE60
	|-Enumerable.WhereSelectEnumerableIterator<WeightedStringList.Container, float>.MoveNext
	|
	|-RVA: 0x1A255D0 Offset: 0x1A23BD0 VA: 0x181A255D0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A22550 Offset: 0x1A20B50 VA: 0x181A22550
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A1B640 Offset: 0x1A19C40 VA: 0x181A1B640
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A21190 Offset: 0x1A1F790 VA: 0x181A21190
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Option>.MoveNext
	|
	|-RVA: 0x1A1E890 Offset: 0x1A1CE90 VA: 0x181A1E890
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A231A0 Offset: 0x1A217A0 VA: 0x181A231A0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A24590 Offset: 0x1A22B90 VA: 0x181A24590
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A20F80 Offset: 0x1A1F580 VA: 0x181A20F80
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, bool>.MoveNext
	|
	|-RVA: 0x1A23B40 Offset: 0x1A22140 VA: 0x181A23B40
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A1EC50 Offset: 0x1A1D250 VA: 0x181A1EC50
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, int>.MoveNext
	|
	|-RVA: 0x1A1F070 Offset: 0x1A1D670 VA: 0x181A1F070
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A21AC0 Offset: 0x1A200C0 VA: 0x181A21AC0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, long>.MoveNext
	|
	|-RVA: 0x1A1C120 Offset: 0x1A1A720 VA: 0x181A1C120
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, object>.MoveNext
	|
	|-RVA: 0x1A24A30 Offset: 0x1A23030 VA: 0x181A24A30
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, float>.MoveNext
	|
	|-RVA: 0x1A1FD30 Offset: 0x1A1E330 VA: 0x181A1FD30
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Resolution>.MoveNext
	|
	|-RVA: 0x1A22D00 Offset: 0x1A21300 VA: 0x181A22D00
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, FourBitNumber>.MoveNext
	|
	|-RVA: 0x1A24410 Offset: 0x1A22A10 VA: 0x181A24410
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, SevenBitNumber>.MoveNext
	|
	|-RVA: 0x1A1F6E0 Offset: 0x1A1DCE0 VA: 0x181A1F6E0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, int>.MoveNext
	|
	|-RVA: 0x1A1ABC0 Offset: 0x1A191C0 VA: 0x181A1ABC0
	|-Enumerable.WhereSelectEnumerableIterator<ProjectileWeaponMod.Modifier, float>.MoveNext
	|
	|-RVA: 0x1A22760 Offset: 0x1A20D60 VA: 0x181A22760
	|-Enumerable.WhereSelectEnumerableIterator<Option, Option>.MoveNext
	|
	|-RVA: 0x1A1A1F0 Offset: 0x1A187F0 VA: 0x181A1A1F0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A1B0C0 Offset: 0x1A196C0 VA: 0x181A1B0C0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, FourBitNumber>.MoveNext
	|
	|-RVA: 0x1A263A0 Offset: 0x1A249A0 VA: 0x181A263A0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, SevenBitNumber>.MoveNext
	|
	|-RVA: 0x1A25EA0 Offset: 0x1A244A0 VA: 0x181A25EA0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A26660 Offset: 0x1A24C60 VA: 0x181A26660
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A206D0 Offset: 0x1A1ECD0 VA: 0x181A206D0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Option>.MoveNext
	|
	|-RVA: 0x1A1DD90 Offset: 0x1A1C390 VA: 0x181A1DD90
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A1F400 Offset: 0x1A1DA00 VA: 0x181A1F400
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A1ADE0 Offset: 0x1A193E0 VA: 0x181A1ADE0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A1B380 Offset: 0x1A19980 VA: 0x181A1B380
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, bool>.MoveNext
	|
	|-RVA: 0x1A1C8D0 Offset: 0x1A1AED0 VA: 0x181A1C8D0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A1D5B0 Offset: 0x1A1BBB0 VA: 0x181A1D5B0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, int>.MoveNext
	|
	|-RVA: 0x1A25980 Offset: 0x1A23F80 VA: 0x181A25980
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A23F10 Offset: 0x1A22510 VA: 0x181A23F10
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, long>.MoveNext
	|
	|-RVA: 0x1A20B30 Offset: 0x1A1F130 VA: 0x181A20B30
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.MoveNext
	|
	|-RVA: 0x1A20290 Offset: 0x1A1E890 VA: 0x181A20290
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, float>.MoveNext
	|
	|-RVA: 0x1A233E0 Offset: 0x1A219E0 VA: 0x181A233E0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Resolution>.MoveNext
	|
	|-RVA: 0x1A21550 Offset: 0x1A1FB50 VA: 0x181A21550
	|-Enumerable.WhereSelectEnumerableIterator<SkinnedMultiMesh.Part, long>.MoveNext
	|
	|-RVA: 0x1A229C0 Offset: 0x1A20FC0 VA: 0x181A229C0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A21E70 Offset: 0x1A20470 VA: 0x181A21E70
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A213C0 Offset: 0x1A1F9C0 VA: 0x181A213C0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A1FF50 Offset: 0x1A1E550 VA: 0x181A1FF50
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Option>.MoveNext
	|
	|-RVA: 0x1A1F860 Offset: 0x1A1DE60 VA: 0x181A1F860
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A21CD0 Offset: 0x1A202D0 VA: 0x181A21CD0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A1CD20 Offset: 0x1A1B320 VA: 0x181A1CD20
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A25450 Offset: 0x1A23A50 VA: 0x181A25450
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, bool>.MoveNext
	|
	|-RVA: 0x1A1C730 Offset: 0x1A1AD30 VA: 0x181A1C730
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A239C0 Offset: 0x1A21FC0 VA: 0x181A239C0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, int>.MoveNext
	|
	|-RVA: 0x1A1C5B0 Offset: 0x1A1ABB0 VA: 0x181A1C5B0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A223D0 Offset: 0x1A209D0 VA: 0x181A223D0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, long>.MoveNext
	|
	|-RVA: 0x1A1FBA0 Offset: 0x1A1E1A0 VA: 0x181A1FBA0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, object>.MoveNext
	|
	|-RVA: 0x1A1A060 Offset: 0x1A18660 VA: 0x181A1A060
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, float>.MoveNext
	|
	|-RVA: 0x1A21790 Offset: 0x1A1FD90 VA: 0x181A21790
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Resolution>.MoveNext
	|
	|-RVA: 0x1A1BC50 Offset: 0x1A1A250 VA: 0x181A1BC50
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A1F280 Offset: 0x1A1D880 VA: 0x181A1F280
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A1CEC0 Offset: 0x1A1B4C0 VA: 0x181A1CEC0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A23D70 Offset: 0x1A22370 VA: 0x181A23D70
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Option>.MoveNext
	|
	|-RVA: 0x1A1BDE0 Offset: 0x1A1A3E0 VA: 0x181A1BDE0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A24EC0 Offset: 0x1A234C0 VA: 0x181A24EC0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A1BF80 Offset: 0x1A1A580 VA: 0x181A1BF80
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A1E710 Offset: 0x1A1CD10 VA: 0x181A1E710
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, bool>.MoveNext
	|
	|-RVA: 0x1A1E070 Offset: 0x1A1C670 VA: 0x181A1E070
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A1D050 Offset: 0x1A1B650 VA: 0x181A1D050
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, int>.MoveNext
	|
	|-RVA: 0x1A19EE0 Offset: 0x1A184E0 VA: 0x181A19EE0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A209B0 Offset: 0x1A1EFB0 VA: 0x181A209B0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, long>.MoveNext
	|
	|-RVA: 0x1A25060 Offset: 0x1A23660 VA: 0x181A25060
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, object>.MoveNext
	|
	|-RVA: 0x1A20550 Offset: 0x1A1EB50 VA: 0x181A20550
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, float>.MoveNext
	|
	|-RVA: 0x1A22E80 Offset: 0x1A21480 VA: 0x181A22E80
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Resolution>.MoveNext
	|
	|-RVA: 0x1A1A890 Offset: 0x1A18E90 VA: 0x181A1A890
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, ServerInfo>.MoveNext
	|
	|-RVA: 0x1A1E200 Offset: 0x1A1C800 VA: 0x181A1E200
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, int>.MoveNext
	|
	|-RVA: 0x1A1D870 Offset: 0x1A1BE70 VA: 0x181A1D870
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.MoveNext
	|
	|-RVA: 0x1A200F0 Offset: 0x1A1E6F0 VA: 0x181A200F0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A25800 Offset: 0x1A23E00 VA: 0x181A25800
	|-Enumerable.WhereSelectEnumerableIterator<Friend, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A1A4C0 Offset: 0x1A18AC0 VA: 0x181A1A4C0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A22B60 Offset: 0x1A21160 VA: 0x181A22B60
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Option>.MoveNext
	|
	|-RVA: 0x1A1FA00 Offset: 0x1A1E000 VA: 0x181A1FA00
	|-Enumerable.WhereSelectEnumerableIterator<Friend, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A1B860 Offset: 0x1A19E60 VA: 0x181A1B860
	|-Enumerable.WhereSelectEnumerableIterator<Friend, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A1D410 Offset: 0x1A1BA10 VA: 0x181A1D410
	|-Enumerable.WhereSelectEnumerableIterator<Friend, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A23840 Offset: 0x1A21E40 VA: 0x181A23840
	|-Enumerable.WhereSelectEnumerableIterator<Friend, bool>.MoveNext
	|
	|-RVA: 0x1A21920 Offset: 0x1A1FF20 VA: 0x181A21920
	|-Enumerable.WhereSelectEnumerableIterator<Friend, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A21FF0 Offset: 0x1A205F0 VA: 0x181A21FF0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, int>.MoveNext
	|
	|-RVA: 0x1A20E00 Offset: 0x1A1F400 VA: 0x181A20E00
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A1CBA0 Offset: 0x1A1B1A0 VA: 0x181A1CBA0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, long>.MoveNext
	|
	|-RVA: 0x1A1EAC0 Offset: 0x1A1D0C0 VA: 0x181A1EAC0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, object>.MoveNext
	|
	|-RVA: 0x1A236B0 Offset: 0x1A21CB0 VA: 0x181A236B0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, float>.MoveNext
	|
	|-RVA: 0x1A23010 Offset: 0x1A21610 VA: 0x181A23010
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Resolution>.MoveNext
	|
	|-RVA: 0x1A1DB40 Offset: 0x1A1C140 VA: 0x181A1DB40
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A1A650 Offset: 0x1A18C50 VA: 0x181A1A650
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, FourBitNumber>.MoveNext
	|
	|-RVA: 0x1A1D1D0 Offset: 0x1A1B7D0 VA: 0x181A1D1D0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, SevenBitNumber>.MoveNext
	|
	|-RVA: 0x1A241D0 Offset: 0x1A227D0 VA: 0x181A241D0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A1BA00 Offset: 0x1A1A000 VA: 0x181A1BA00
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A25C40 Offset: 0x1A24240 VA: 0x181A25C40
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Option>.MoveNext
	|
	|-RVA: 0x1A19CA0 Offset: 0x1A182A0 VA: 0x181A19CA0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryItemId>.MoveNext
	|
	|-RVA: 0x1A22170 Offset: 0x1A20770 VA: 0x181A22170
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A251F0 Offset: 0x1A237F0 VA: 0x181A251F0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A247D0 Offset: 0x1A22DD0 VA: 0x181A247D0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A26160 Offset: 0x1A24760 VA: 0x181A26160
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, bool>.MoveNext
	|
	|-RVA: 0x1A1E4C0 Offset: 0x1A1CAC0 VA: 0x181A1E4C0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A2C600 Offset: 0x1A2AC00 VA: 0x181A2C600
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, int>.MoveNext
	|
	|-RVA: 0x1A32250 Offset: 0x1A30850 VA: 0x181A32250
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A2B860 Offset: 0x1A29E60 VA: 0x181A2B860
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, long>.MoveNext
	|
	|-RVA: 0x1A2B610 Offset: 0x1A29C10 VA: 0x181A2B610
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, object>.MoveNext
	|
	|-RVA: 0x1A326B0 Offset: 0x1A30CB0 VA: 0x181A326B0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, float>.MoveNext
	|
	|-RVA: 0x1A2AC50 Offset: 0x1A29250 VA: 0x181A2AC50
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, uint>.MoveNext
	|
	|-RVA: 0x1A34C40 Offset: 0x1A33240 VA: 0x181A34C40
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Resolution>.MoveNext
	|
	|-RVA: 0x1A2E2E0 Offset: 0x1A2C8E0 VA: 0x181A2E2E0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem.Amount, InventoryItemId>.MoveNext
	|
	|-RVA: 0x1A335D0 Offset: 0x1A31BD0 VA: 0x181A335D0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem.Amount, uint>.MoveNext
	|
	|-RVA: 0x1A30A70 Offset: 0x1A2F070 VA: 0x181A30A70
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe, PlayerItemRecipe>.MoveNext
	|
	|-RVA: 0x1A2A700 Offset: 0x1A28D00 VA: 0x181A2A700
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe, object>.MoveNext
	|
	|-RVA: 0x1A350E0 Offset: 0x1A336E0 VA: 0x181A350E0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A2DF10 Offset: 0x1A2C510 VA: 0x181A2DF10
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A35850 Offset: 0x1A33E50 VA: 0x181A35850
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A35A80 Offset: 0x1A34080 VA: 0x181A35A80
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A30610 Offset: 0x1A2EC10 VA: 0x181A30610
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Option>.MoveNext
	|
	|-RVA: 0x1A33830 Offset: 0x1A31E30 VA: 0x181A33830
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A34E90 Offset: 0x1A33490 VA: 0x181A34E90
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A35F00 Offset: 0x1A34500 VA: 0x181A35F00
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A31A40 Offset: 0x1A30040 VA: 0x181A31A40
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, bool>.MoveNext
	|
	|-RVA: 0x1A32E50 Offset: 0x1A31450 VA: 0x181A32E50
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A33090 Offset: 0x1A31690 VA: 0x181A33090
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, int>.MoveNext
	|
	|-RVA: 0x1A34440 Offset: 0x1A32A40 VA: 0x181A34440
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A31C70 Offset: 0x1A30270 VA: 0x181A31C70
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, long>.MoveNext
	|
	|-RVA: 0x1A33A80 Offset: 0x1A32080 VA: 0x181A33A80
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, object>.MoveNext
	|
	|-RVA: 0x1A33FD0 Offset: 0x1A325D0 VA: 0x181A33FD0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, float>.MoveNext
	|
	|-RVA: 0x1A2FD60 Offset: 0x1A2E360 VA: 0x181A2FD60
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Resolution>.MoveNext
	|
	|-RVA: 0x1A2CA70 Offset: 0x1A2B070 VA: 0x181A2CA70
	|-Enumerable.WhereSelectEnumerableIterator<DictionaryEntry, KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0x1A35320 Offset: 0x1A33920 VA: 0x181A35320
	|-Enumerable.WhereSelectEnumerableIterator<DictionaryEntry, object>.MoveNext
	|
	|-RVA: 0x1A34A10 Offset: 0x1A33010 VA: 0x181A34A10
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A2D9D0 Offset: 0x1A2BFD0 VA: 0x181A2D9D0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A2E6C0 Offset: 0x1A2CCC0 VA: 0x181A2E6C0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A2C840 Offset: 0x1A2AE40 VA: 0x181A2C840
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Option>.MoveNext
	|
	|-RVA: 0x1A31EA0 Offset: 0x1A304A0 VA: 0x181A31EA0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A2A280 Offset: 0x1A28880 VA: 0x181A2A280
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A35CC0 Offset: 0x1A342C0 VA: 0x181A35CC0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A2EF40 Offset: 0x1A2D540 VA: 0x181A2EF40
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, bool>.MoveNext
	|
	|-RVA: 0x1A303E0 Offset: 0x1A2E9E0 VA: 0x181A303E0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A2BE30 Offset: 0x1A2A430 VA: 0x181A2BE30
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, int>.MoveNext
	|
	|-RVA: 0x1A31140 Offset: 0x1A2F740 VA: 0x181A31140
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A2BAA0 Offset: 0x1A2A0A0 VA: 0x181A2BAA0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, long>.MoveNext
	|
	|-RVA: 0x1A31350 Offset: 0x1A2F950 VA: 0x181A31350
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.MoveNext
	|
	|-RVA: 0x1A32900 Offset: 0x1A30F00 VA: 0x181A32900
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, float>.MoveNext
	|
	|-RVA: 0x1A2B3F0 Offset: 0x1A299F0 VA: 0x181A2B3F0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Resolution>.MoveNext
	|
	|-RVA: 0x1A2FFA0 Offset: 0x1A2E5A0 VA: 0x181A2FFA0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A2C3F0 Offset: 0x1A2A9F0 VA: 0x181A2C3F0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A34670 Offset: 0x1A32C70 VA: 0x181A34670
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A2F470 Offset: 0x1A2DA70 VA: 0x181A2F470
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Option>.MoveNext
	|
	|-RVA: 0x1A2C040 Offset: 0x1A2A640 VA: 0x181A2C040
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A2A4C0 Offset: 0x1A28AC0 VA: 0x181A2A4C0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A2B030 Offset: 0x1A29630 VA: 0x181A2B030
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A30860 Offset: 0x1A2EE60 VA: 0x181A30860
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, bool>.MoveNext
	|
	|-RVA: 0x1A2D610 Offset: 0x1A2BC10 VA: 0x181A2D610
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A2CE40 Offset: 0x1A2B440 VA: 0x181A2CE40
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, int>.MoveNext
	|
	|-RVA: 0x1A301D0 Offset: 0x1A2E7D0 VA: 0x181A301D0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A2D260 Offset: 0x1A2B860 VA: 0x181A2D260
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, long>.MoveNext
	|
	|-RVA: 0x1A34220 Offset: 0x1A32820 VA: 0x181A34220
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, object>.MoveNext
	|
	|-RVA: 0x1A2F840 Offset: 0x1A2DE40 VA: 0x181A2F840
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, float>.MoveNext
	|
	|-RVA: 0x1A2D050 Offset: 0x1A2B650 VA: 0x181A2D050
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, uint>.MoveNext
	|
	|-RVA: 0x1A32490 Offset: 0x1A30A90 VA: 0x181A32490
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Resolution>.MoveNext
	|
	|-RVA: 0x1A2AAD0 Offset: 0x1A290D0 VA: 0x181A2AAD0
	|-Enumerable.WhereSelectEnumerableIterator<int, FourBitNumber>.MoveNext
	|
	|-RVA: 0x1A332C0 Offset: 0x1A318C0 VA: 0x181A332C0
	|-Enumerable.WhereSelectEnumerableIterator<int, SevenBitNumber>.MoveNext
	|
	|-RVA: 0x1A30FC0 Offset: 0x1A2F5C0 VA: 0x181A30FC0
	|-Enumerable.WhereSelectEnumerableIterator<int, int>.MoveNext
	|
	|-RVA: 0x1A2F2D0 Offset: 0x1A2D8D0 VA: 0x181A2F2D0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A2C270 Offset: 0x1A2A870 VA: 0x181A2C270
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A33440 Offset: 0x1A31A40 VA: 0x181A33440
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A2EC00 Offset: 0x1A2D200 VA: 0x181A2EC00
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Option>.MoveNext
	|
	|-RVA: 0x1A32CB0 Offset: 0x1A312B0 VA: 0x181A32CB0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A2CCA0 Offset: 0x1A2B2A0 VA: 0x181A2CCA0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A2EA60 Offset: 0x1A2D060 VA: 0x181A2EA60
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A33CC0 Offset: 0x1A322C0 VA: 0x181A33CC0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, bool>.MoveNext
	|
	|-RVA: 0x1A318A0 Offset: 0x1A2FEA0 VA: 0x181A318A0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A2F150 Offset: 0x1A2D750 VA: 0x181A2F150
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, int>.MoveNext
	|
	|-RVA: 0x1A2BCB0 Offset: 0x1A2A2B0 VA: 0x181A2BCB0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A2B270 Offset: 0x1A29870 VA: 0x181A2B270
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, long>.MoveNext
	|
	|-RVA: 0x1A2D840 Offset: 0x1A2BE40 VA: 0x181A2D840
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.MoveNext
	|
	|-RVA: 0x1A356D0 Offset: 0x1A33CD0 VA: 0x181A356D0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, float>.MoveNext
	|
	|-RVA: 0x1A31570 Offset: 0x1A2FB70 VA: 0x181A31570
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Resolution>.MoveNext
	|
	|-RVA: 0x1A2A0E0 Offset: 0x1A286E0 VA: 0x181A2A0E0
	|-Enumerable.WhereSelectEnumerableIterator<object, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A2E540 Offset: 0x1A2CB40 VA: 0x181A2E540
	|-Enumerable.WhereSelectEnumerableIterator<object, FourBitNumber>.MoveNext
	|
	|-RVA: 0x1A30CB0 Offset: 0x1A2F2B0 VA: 0x181A30CB0
	|-Enumerable.WhereSelectEnumerableIterator<object, SevenBitNumber>.MoveNext
	|
	|-RVA: 0x1A2DBE0 Offset: 0x1A2C1E0 VA: 0x181A2DBE0
	|-Enumerable.WhereSelectEnumerableIterator<object, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A2FBD0 Offset: 0x1A2E1D0 VA: 0x181A2FBD0
	|-Enumerable.WhereSelectEnumerableIterator<object, PlayerItemRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A2DD70 Offset: 0x1A2C370 VA: 0x181A2DD70
	|-Enumerable.WhereSelectEnumerableIterator<object, PlayerItemRecipe>.MoveNext
	|
	|-RVA: 0x1A2AE90 Offset: 0x1A29490 VA: 0x181A2AE90
	|-Enumerable.WhereSelectEnumerableIterator<object, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A31700 Offset: 0x1A2FD00 VA: 0x181A31700
	|-Enumerable.WhereSelectEnumerableIterator<object, Option>.MoveNext
	|
	|-RVA: 0x1A33E40 Offset: 0x1A32440 VA: 0x181A33E40
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryItemId>.MoveNext
	|
	|-RVA: 0x1A2F6A0 Offset: 0x1A2DCA0 VA: 0x181A2F6A0
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A32B10 Offset: 0x1A31110 VA: 0x181A32B10
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A2E140 Offset: 0x1A2C740 VA: 0x181A2E140
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A2E8E0 Offset: 0x1A2CEE0 VA: 0x181A2E8E0
	|-Enumerable.WhereSelectEnumerableIterator<object, bool>.MoveNext
	|
	|-RVA: 0x1A2EDA0 Offset: 0x1A2D3A0 VA: 0x181A2EDA0
	|-Enumerable.WhereSelectEnumerableIterator<object, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A320D0 Offset: 0x1A306D0 VA: 0x181A320D0
	|-Enumerable.WhereSelectEnumerableIterator<object, int>.MoveNext
	|
	|-RVA: 0x1A34890 Offset: 0x1A32E90 VA: 0x181A34890
	|-Enumerable.WhereSelectEnumerableIterator<object, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A30E30 Offset: 0x1A2F430 VA: 0x181A30E30
	|-Enumerable.WhereSelectEnumerableIterator<object, long>.MoveNext
	|
	|-RVA: 0x1A2A940 Offset: 0x1A28F40 VA: 0x181A2A940
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.MoveNext
	|
	|-RVA: 0x1A35540 Offset: 0x1A33B40 VA: 0x181A35540
	|-Enumerable.WhereSelectEnumerableIterator<object, float>.MoveNext
	|
	|-RVA: 0x1A2FA50 Offset: 0x1A2E050 VA: 0x181A2FA50
	|-Enumerable.WhereSelectEnumerableIterator<object, uint>.MoveNext
	|
	|-RVA: 0x1A2D470 Offset: 0x1A2BA70 VA: 0x181A2D470
	|-Enumerable.WhereSelectEnumerableIterator<object, Resolution>.MoveNext
	*/

	public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC8CFA0 Offset: 0xC8B5A0 VA: 0x180C8CFA0
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
	|-RVA: 0xC8D0E0 Offset: 0xC8B6E0 VA: 0x180C8D0E0
	|-Enumerable.WhereSelectEnumerableIterator<Option, Option>.Select<Option>
	|-Enumerable.WhereSelectEnumerableIterator<object, Option>.Select<Option>
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryItem>.Select<InventoryItemId>
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryItem>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryItem>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryItem>.Select<uint>
	|
	|-RVA: 0xC8D220 Offset: 0xC8B820 VA: 0x180C8D220
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, ServerInfo>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, ServerInfo>.Select<object>
	|
	|-RVA: 0xC8D180 Offset: 0xC8B780 VA: 0x180C8D180
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe, PlayerItemRecipe>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<DictionaryEntry, KeyValuePair<object, object>>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<object, ProjectileWeaponMod.Modifier>.Select<float>
	|
	|-RVA: 0xC8D040 Offset: 0xC8B640 VA: 0x180C8D040
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryRecipe.Ingredient>.Select<PlayerItemRecipe.Ingredient>
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryRecipe.Ingredient>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryRecipe>.Select<PlayerItemRecipe>
	*/

	public override IEnumerable<TResult> Where(Func<TResult, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C2A00 Offset: 0x19C1000 VA: 0x1819C2A00
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
	|-RVA: 0x16A8EE0 Offset: 0x16A74E0 VA: 0x1816A8EE0
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
	|-RVA: 0x16A8F70 Offset: 0x16A7570 VA: 0x1816A8F70
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
	|-RVA: 0x16A9090 Offset: 0x16A7690 VA: 0x1816A9090
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
	|-RVA: 0x16A9000 Offset: 0x16A7600 VA: 0x1816A9000
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
	|-RVA: 0x16A9120 Offset: 0x16A7720 VA: 0x1816A9120
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, ServerInfo>..ctor
	*/

	public override Enumerable.Iterator<TResult> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A3DC0 Offset: 0x16A23C0 VA: 0x1816A3DC0
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
	|-RVA: 0x16A3C80 Offset: 0x16A2280 VA: 0x1816A3C80
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
	|-RVA: 0x16A3D20 Offset: 0x16A2320 VA: 0x1816A3D20
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
	|-RVA: 0x16A3E60 Offset: 0x16A2460 VA: 0x1816A3E60
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
	|-RVA: 0x16A3F00 Offset: 0x16A2500 VA: 0x1816A3F00
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, ServerInfo>.Clone
	*/

	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A43E0 Offset: 0x16A29E0 VA: 0x1816A43E0
	|-Enumerable.WhereSelectArrayIterator<BurstCloth.Chain, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<BurstCloth.Chain, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe.Ingredient, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe.Ingredient, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Achievement, bool>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, bool>.MoveNext
	|
	|-RVA: 0x16A4D70 Offset: 0x16A3370 VA: 0x1816A4D70
	|-Enumerable.WhereSelectArrayIterator<BurstCloth.Chain, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe.Ingredient, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Achievement, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Achievement, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, Int32Enum>.MoveNext
	|
	|-RVA: 0x16A44C0 Offset: 0x16A2AC0 VA: 0x1816A44C0
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x16A7F50 Offset: 0x16A6550 VA: 0x1816A7F50
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, long>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem.Amount, InventoryItemId>.MoveNext
	|
	|-RVA: 0x16A8D10 Offset: 0x16A7310 VA: 0x1816A8D10
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, Resolution>.MoveNext
	|
	|-RVA: 0x16A7160 Offset: 0x16A5760 VA: 0x1816A7160
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, Option>.MoveNext
	|
	|-RVA: 0x16A5C20 Offset: 0x16A4220 VA: 0x1816A5C20
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, InventoryItem>.MoveNext
	|
	|-RVA: 0x16A73D0 Offset: 0x16A59D0 VA: 0x1816A73D0
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x16A59C0 Offset: 0x16A3FC0 VA: 0x1816A59C0
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x16A7C30 Offset: 0x16A6230 VA: 0x1816A7C30
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, bool>.MoveNext
	|
	|-RVA: 0x16A4610 Offset: 0x16A2C10 VA: 0x1816A4610
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem.Amount, uint>.MoveNext
	|
	|-RVA: 0x16A6B20 Offset: 0x16A5120 VA: 0x1816A6B20
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, object>.MoveNext
	|
	|-RVA: 0x16A8AA0 Offset: 0x16A70A0 VA: 0x1816A8AA0
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, float>.MoveNext
	|
	|-RVA: 0x16A5070 Offset: 0x16A3670 VA: 0x1816A5070
	|-Enumerable.WhereSelectArrayIterator<WeightedStringList.Container, float>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, float>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, float>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, float>.MoveNext
	|
	|-RVA: 0x16A7780 Offset: 0x16A5D80 VA: 0x1816A7780
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, KeyValuePair<object, int>>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<DictionaryEntry, KeyValuePair<object, object>>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, KeyValuePair<object, int>>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x16A3FA0 Offset: 0x16A25A0 VA: 0x1816A3FA0
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, long>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, long>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, long>.MoveNext
	|
	|-RVA: 0x16A83A0 Offset: 0x16A69A0 VA: 0x1816A83A0
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, Resolution>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Resolution>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, Resolution>.MoveNext
	|
	|-RVA: 0x16A8980 Offset: 0x16A6F80 VA: 0x1816A8980
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, Option>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Option>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, Option>.MoveNext
	|
	|-RVA: 0x16A6810 Offset: 0x16A4E10 VA: 0x1816A6810
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, InventoryItem>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, InventoryItem>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, InventoryItem>.MoveNext
	|
	|-RVA: 0x16A8860 Offset: 0x16A6E60 VA: 0x1816A8860
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, InventoryRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, InventoryRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x16A6F40 Offset: 0x16A5540 VA: 0x1816A6F40
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, InventoryRecipe>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, InventoryRecipe>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x16A82A0 Offset: 0x16A68A0 VA: 0x1816A82A0
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, bool>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, bool>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, bool>.MoveNext
	|
	|-RVA: 0x16A62C0 Offset: 0x16A48C0 VA: 0x1816A62C0
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, uint>.MoveNext
	|
	|-RVA: 0x16A6E30 Offset: 0x16A5430 VA: 0x1816A6E30
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, object>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<DictionaryEntry, object>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, object>.MoveNext
	|
	|-RVA: 0x16A8090 Offset: 0x16A6690 VA: 0x1816A8090
	|-Enumerable.WhereSelectArrayIterator<ProjectileWeaponMod.Modifier, float>.MoveNext
	|
	|-RVA: 0x16A8BD0 Offset: 0x16A71D0 VA: 0x1816A8BD0
	|-Enumerable.WhereSelectArrayIterator<Option, Option>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, Option>.MoveNext
	|
	|-RVA: 0x16A5350 Offset: 0x16A3950 VA: 0x1816A5350
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x16A4850 Offset: 0x16A2E50 VA: 0x1816A4850
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, bool>.MoveNext
	|
	|-RVA: 0x16A63C0 Offset: 0x16A49C0 VA: 0x1816A63C0
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, long>.MoveNext
	|
	|-RVA: 0x16A65E0 Offset: 0x16A4BE0 VA: 0x1816A65E0
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, Resolution>.MoveNext
	|
	|-RVA: 0x16A7540 Offset: 0x16A5B40 VA: 0x1816A7540
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, Option>.MoveNext
	|
	|-RVA: 0x16A6080 Offset: 0x16A4680 VA: 0x1816A6080
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, InventoryItem>.MoveNext
	|
	|-RVA: 0x16A40A0 Offset: 0x16A26A0 VA: 0x1816A40A0
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x16A5690 Offset: 0x16A3C90 VA: 0x1816A5690
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x16A4B60 Offset: 0x16A3160 VA: 0x1816A4B60
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, int>.MoveNext
	|
	|-RVA: 0x16A4E50 Offset: 0x16A3450 VA: 0x1816A4E50
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>.MoveNext
	|
	|-RVA: 0x16A5170 Offset: 0x16A3770 VA: 0x1816A5170
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, float>.MoveNext
	|
	|-RVA: 0x16A5E70 Offset: 0x16A4470 VA: 0x1816A5E70
	|-Enumerable.WhereSelectArrayIterator<SkinnedMultiMesh.Part, long>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, InventoryItemId>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, long>.MoveNext
	|
	|-RVA: 0x16A58D0 Offset: 0x16A3ED0 VA: 0x1816A58D0
	|-Enumerable.WhereSelectArrayIterator<Achievement, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Achievement, KeyValuePair<object, int>>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x16A6D50 Offset: 0x16A5350 VA: 0x1816A6D50
	|-Enumerable.WhereSelectArrayIterator<Achievement, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Achievement, long>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, long>.MoveNext
	|
	|-RVA: 0x16A7E60 Offset: 0x16A6460 VA: 0x1816A7E60
	|-Enumerable.WhereSelectArrayIterator<Achievement, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Achievement, Resolution>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, Resolution>.MoveNext
	|
	|-RVA: 0x16A7890 Offset: 0x16A5E90 VA: 0x1816A7890
	|-Enumerable.WhereSelectArrayIterator<Achievement, Option>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, Option>.MoveNext
	|
	|-RVA: 0x16A6930 Offset: 0x16A4F30 VA: 0x1816A6930
	|-Enumerable.WhereSelectArrayIterator<Achievement, InventoryItem>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, InventoryItem>.MoveNext
	|
	|-RVA: 0x16A72D0 Offset: 0x16A58D0 VA: 0x1816A72D0
	|-Enumerable.WhereSelectArrayIterator<Achievement, InventoryRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x16A4A60 Offset: 0x16A3060 VA: 0x1816A4A60
	|-Enumerable.WhereSelectArrayIterator<Achievement, InventoryRecipe>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x16A7D70 Offset: 0x16A6370 VA: 0x1816A7D70
	|-Enumerable.WhereSelectArrayIterator<Achievement, object>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, object>.MoveNext
	|
	|-RVA: 0x16A6C70 Offset: 0x16A5270 VA: 0x1816A6C70
	|-Enumerable.WhereSelectArrayIterator<Achievement, float>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, float>.MoveNext
	|
	|-RVA: 0x16A5F90 Offset: 0x16A4590 VA: 0x1816A5F90
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x16A7B50 Offset: 0x16A6150 VA: 0x1816A7B50
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, long>.MoveNext
	|
	|-RVA: 0x16A6A30 Offset: 0x16A5030 VA: 0x1816A6A30
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, Resolution>.MoveNext
	|
	|-RVA: 0x16A7060 Offset: 0x16A5660 VA: 0x1816A7060
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, Option>.MoveNext
	|
	|-RVA: 0x16A42E0 Offset: 0x16A28E0 VA: 0x1816A42E0
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, InventoryItem>.MoveNext
	|
	|-RVA: 0x16A81A0 Offset: 0x16A67A0 VA: 0x1816A81A0
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x16A4750 Offset: 0x16A2D50 VA: 0x1816A4750
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x16A5D90 Offset: 0x16A4390 VA: 0x1816A5D90
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, bool>.MoveNext
	|
	|-RVA: 0x16A7A70 Offset: 0x16A6070 VA: 0x1816A7A70
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, Int32Enum>.MoveNext
	|
	|-RVA: 0x16A5B30 Offset: 0x16A4130 VA: 0x1816A5B30
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, object>.MoveNext
	|
	|-RVA: 0x16A7990 Offset: 0x16A5F90 VA: 0x1816A7990
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, float>.MoveNext
	|
	|-RVA: 0x16A85E0 Offset: 0x16A6BE0 VA: 0x1816A85E0
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, ServerInfo>.MoveNext
	|
	|-RVA: 0x16A84B0 Offset: 0x16A6AB0 VA: 0x1816A84B0
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x16A5580 Offset: 0x16A3B80 VA: 0x1816A5580
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, bool>.MoveNext
	|
	|-RVA: 0x19BD660 Offset: 0x19BBC60 VA: 0x1819BD660
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, Resolution>.MoveNext
	|
	|-RVA: 0x19BE610 Offset: 0x19BCC10 VA: 0x1819BE610
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, InventoryItem>.MoveNext
	|
	|-RVA: 0x19BF770 Offset: 0x19BDD70 VA: 0x1819BF770
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x19BE130 Offset: 0x19BC730 VA: 0x1819BE130
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x19BF660 Offset: 0x19BDC60 VA: 0x1819BF660
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, uint>.MoveNext
	|
	|-RVA: 0x19BFBC0 Offset: 0x19BE1C0 VA: 0x1819BFBC0
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, object>.MoveNext
	|
	|-RVA: 0x19BF9B0 Offset: 0x19BDFB0 VA: 0x1819BF9B0
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, float>.MoveNext
	|
	|-RVA: 0x19BE000 Offset: 0x19BC600 VA: 0x1819BE000
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe, PlayerItemRecipe>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x19BD440 Offset: 0x19BBA40 VA: 0x1819BD440
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe, object>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, object>.MoveNext
	|
	|-RVA: 0x19BDAD0 Offset: 0x19BC0D0 VA: 0x1819BDAD0
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, long>.MoveNext
	|
	|-RVA: 0x19BD790 Offset: 0x19BBD90 VA: 0x1819BD790
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, Resolution>.MoveNext
	|
	|-RVA: 0x19BF080 Offset: 0x19BD680 VA: 0x1819BF080
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, Option>.MoveNext
	|
	|-RVA: 0x19BDBF0 Offset: 0x19BC1F0 VA: 0x1819BDBF0
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, InventoryItem>.MoveNext
	|
	|-RVA: 0x19BEC80 Offset: 0x19BD280 VA: 0x1819BEC80
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x19BE750 Offset: 0x19BCD50 VA: 0x1819BE750
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x19BD9B0 Offset: 0x19BBFB0 VA: 0x1819BD9B0
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, bool>.MoveNext
	|
	|-RVA: 0x19BDD20 Offset: 0x19BC320 VA: 0x1819BDD20
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, Int32Enum>.MoveNext
	|
	|-RVA: 0x19BE980 Offset: 0x19BCF80 VA: 0x1819BE980
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, float>.MoveNext
	|
	|-RVA: 0x19BEDB0 Offset: 0x19BD3B0 VA: 0x1819BEDB0
	|-Enumerable.WhereSelectArrayIterator<int, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<int, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, bool>.MoveNext
	|
	|-RVA: 0x19BD360 Offset: 0x19BB960 VA: 0x1819BD360
	|-Enumerable.WhereSelectArrayIterator<int, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Int32Enum>.MoveNext
	|
	|-RVA: 0x19BE350 Offset: 0x19BC950 VA: 0x1819BE350
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x19BE530 Offset: 0x19BCB30 VA: 0x1819BE530
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, long>.MoveNext
	|
	|-RVA: 0x19BEA90 Offset: 0x19BD090 VA: 0x1819BEA90
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Resolution>.MoveNext
	|
	|-RVA: 0x19BFAC0 Offset: 0x19BE0C0 VA: 0x1819BFAC0
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Option>.MoveNext
	|
	|-RVA: 0x19BF8B0 Offset: 0x19BDEB0 VA: 0x1819BF8B0
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, InventoryItem>.MoveNext
	|
	|-RVA: 0x19BEB80 Offset: 0x19BD180 VA: 0x1819BEB80
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x19BE880 Offset: 0x19BCE80 VA: 0x1819BE880
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x19BE440 Offset: 0x19BCA40 VA: 0x1819BE440
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.MoveNext
	|
	|-RVA: 0x19BDE40 Offset: 0x19BC440 VA: 0x1819BDE40
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, float>.MoveNext
	|
	|-RVA: 0x19BD8C0 Offset: 0x19BBEC0 VA: 0x1819BD8C0
	|-Enumerable.WhereSelectArrayIterator<object, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, PlayerItemRecipe>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x19BE270 Offset: 0x19BC870 VA: 0x1819BE270
	|-Enumerable.WhereSelectArrayIterator<object, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, bool>.MoveNext
	|
	|-RVA: 0x19BDF20 Offset: 0x19BC520 VA: 0x1819BDF20
	|-Enumerable.WhereSelectArrayIterator<object, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, PlayerItemRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, InventoryItemId>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, long>.MoveNext
	|
	|-RVA: 0x19BF1B0 Offset: 0x19BD7B0 VA: 0x1819BF1B0
	|-Enumerable.WhereSelectArrayIterator<object, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, Resolution>.MoveNext
	|
	|-RVA: 0x19BF380 Offset: 0x19BD980 VA: 0x1819BF380
	|-Enumerable.WhereSelectArrayIterator<object, Option>.MoveNext
	|
	|-RVA: 0x19BF560 Offset: 0x19BDB60 VA: 0x1819BF560
	|-Enumerable.WhereSelectArrayIterator<object, InventoryItem>.MoveNext
	|
	|-RVA: 0x19BEE90 Offset: 0x19BD490 VA: 0x1819BEE90
	|-Enumerable.WhereSelectArrayIterator<object, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x19BD560 Offset: 0x19BBB60 VA: 0x1819BD560
	|-Enumerable.WhereSelectArrayIterator<object, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x19BF480 Offset: 0x19BDA80 VA: 0x1819BF480
	|-Enumerable.WhereSelectArrayIterator<object, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, uint>.MoveNext
	|
	|-RVA: 0x19BEF90 Offset: 0x19BD590 VA: 0x1819BEF90
	|-Enumerable.WhereSelectArrayIterator<object, object>.MoveNext
	|
	|-RVA: 0x19BF2A0 Offset: 0x19BD8A0 VA: 0x1819BF2A0
	|-Enumerable.WhereSelectArrayIterator<object, float>.MoveNext
	*/

	public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC8CFA0 Offset: 0xC8B5A0 VA: 0x180C8CFA0
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
	|-RVA: 0xC8D0E0 Offset: 0xC8B6E0 VA: 0x180C8D0E0
	|-Enumerable.WhereSelectArrayIterator<Option, Option>.Select<Option>
	|-Enumerable.WhereSelectArrayIterator<object, Option>.Select<Option>
	|-Enumerable.WhereSelectArrayIterator<object, InventoryItem>.Select<InventoryItemId>
	|-Enumerable.WhereSelectArrayIterator<object, InventoryItem>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<object, InventoryItem>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<object, InventoryItem>.Select<uint>
	|
	|-RVA: 0xC8D220 Offset: 0xC8B820 VA: 0x180C8D220
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, ServerInfo>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, ServerInfo>.Select<object>
	|
	|-RVA: 0xC8D180 Offset: 0xC8B780 VA: 0x180C8D180
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe, PlayerItemRecipe>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<DictionaryEntry, KeyValuePair<object, object>>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<object, ProjectileWeaponMod.Modifier>.Select<float>
	|
	|-RVA: 0xC8D040 Offset: 0xC8B640 VA: 0x180C8D040
	|-Enumerable.WhereSelectArrayIterator<object, InventoryRecipe.Ingredient>.Select<PlayerItemRecipe.Ingredient>
	|-Enumerable.WhereSelectArrayIterator<object, InventoryRecipe.Ingredient>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<object, InventoryRecipe>.Select<PlayerItemRecipe>
	*/

	public override IEnumerable<TResult> Where(Func<TResult, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A8E60 Offset: 0x16A7460 VA: 0x1816A8E60
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
	|-RVA: 0x16A8EE0 Offset: 0x16A74E0 VA: 0x1816A8EE0
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
	|-RVA: 0x16A8F70 Offset: 0x16A7570 VA: 0x1816A8F70
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
	|-RVA: 0x16A9090 Offset: 0x16A7690 VA: 0x1816A9090
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
	|-RVA: 0x16A9000 Offset: 0x16A7600 VA: 0x1816A9000
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
	|-RVA: 0x16A9120 Offset: 0x16A7720 VA: 0x1816A9120
	|-Enumerable.WhereSelectListIterator<ServerInfo, ServerInfo>..ctor
	*/

	public override Enumerable.Iterator<TResult> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A3DC0 Offset: 0x16A23C0 VA: 0x1816A3DC0
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
	|-RVA: 0x16A3C80 Offset: 0x16A2280 VA: 0x1816A3C80
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
	|-RVA: 0x16A3D20 Offset: 0x16A2320 VA: 0x1816A3D20
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
	|-RVA: 0x16A3E60 Offset: 0x16A2460 VA: 0x1816A3E60
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
	|-RVA: 0x16A3F00 Offset: 0x16A2500 VA: 0x1816A3F00
	|-Enumerable.WhereSelectListIterator<ServerInfo, ServerInfo>.Clone
	*/

	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176DD50 Offset: 0x176C350 VA: 0x18176DD50
	|-Enumerable.WhereSelectListIterator<BurstCloth.Chain, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<BurstCloth.Chain, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<Achievement, bool>.MoveNext
	|
	|-RVA: 0x1770350 Offset: 0x176E950 VA: 0x181770350
	|-Enumerable.WhereSelectListIterator<BurstCloth.Chain, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<Achievement, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<Achievement, Int32Enum>.MoveNext
	|
	|-RVA: 0x176C200 Offset: 0x176A800 VA: 0x18176C200
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x176EA10 Offset: 0x176D010 VA: 0x18176EA10
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, long>.MoveNext
	|
	|-RVA: 0x176C4C0 Offset: 0x176AAC0 VA: 0x18176C4C0
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, Resolution>.MoveNext
	|
	|-RVA: 0x1772E00 Offset: 0x1771400 VA: 0x181772E00
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, Option>.MoveNext
	|
	|-RVA: 0x176D3B0 Offset: 0x176B9B0 VA: 0x18176D3B0
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, InventoryItem>.MoveNext
	|
	|-RVA: 0x1773240 Offset: 0x1771840 VA: 0x181773240
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x17711A0 Offset: 0x176F7A0 VA: 0x1817711A0
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x17709F0 Offset: 0x176EFF0 VA: 0x1817709F0
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, bool>.MoveNext
	|
	|-RVA: 0x1771A90 Offset: 0x1770090 VA: 0x181771A90
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, Int32Enum>.MoveNext
	|
	|-RVA: 0x1773930 Offset: 0x1771F30 VA: 0x181773930
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, object>.MoveNext
	|
	|-RVA: 0x176EF90 Offset: 0x176D590 VA: 0x18176EF90
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, float>.MoveNext
	|
	|-RVA: 0x176EE60 Offset: 0x176D460 VA: 0x18176EE60
	|-Enumerable.WhereSelectListIterator<WeightedStringList.Container, float>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, float>.MoveNext
	|
	|-RVA: 0x176E3C0 Offset: 0x176C9C0 VA: 0x18176E3C0
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, KeyValuePair<object, int>>.MoveNext
	|-Enumerable.WhereSelectListIterator<DictionaryEntry, KeyValuePair<object, object>>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x176CDE0 Offset: 0x176B3E0 VA: 0x18176CDE0
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, long>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, long>.MoveNext
	|
	|-RVA: 0x176DE70 Offset: 0x176C470 VA: 0x18176DE70
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, Resolution>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Resolution>.MoveNext
	|
	|-RVA: 0x17724E0 Offset: 0x1770AE0 VA: 0x1817724E0
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, Option>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Option>.MoveNext
	|
	|-RVA: 0x176D950 Offset: 0x176BF50 VA: 0x18176D950
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, InventoryItem>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, InventoryItem>.MoveNext
	|
	|-RVA: 0x176E270 Offset: 0x176C870 VA: 0x18176E270
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, InventoryRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1770F10 Offset: 0x176F510 VA: 0x181770F10
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, InventoryRecipe>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x176FFD0 Offset: 0x176E5D0 VA: 0x18176FFD0
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, bool>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, bool>.MoveNext
	|
	|-RVA: 0x176D280 Offset: 0x176B880 VA: 0x18176D280
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Int32Enum>.MoveNext
	|
	|-RVA: 0x1771D60 Offset: 0x1770360 VA: 0x181771D60
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, object>.MoveNext
	|-Enumerable.WhereSelectListIterator<DictionaryEntry, object>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.MoveNext
	|
	|-RVA: 0x176FEA0 Offset: 0x176E4A0 VA: 0x18176FEA0
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, float>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, float>.MoveNext
	|
	|-RVA: 0x176FC10 Offset: 0x176E210 VA: 0x18176FC10
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe.Ingredient, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe.Ingredient, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<Friend, bool>.MoveNext
	|
	|-RVA: 0x1770230 Offset: 0x176E830 VA: 0x181770230
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe.Ingredient, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<Friend, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<Friend, Int32Enum>.MoveNext
	|
	|-RVA: 0x1771060 Offset: 0x176F660 VA: 0x181771060
	|-Enumerable.WhereSelectListIterator<ProjectileWeaponMod.Modifier, float>.MoveNext
	|
	|-RVA: 0x17737C0 Offset: 0x1771DC0 VA: 0x1817737C0
	|-Enumerable.WhereSelectListIterator<Option, Option>.MoveNext
	|
	|-RVA: 0x176DAA0 Offset: 0x176C0A0 VA: 0x18176DAA0
	|-Enumerable.WhereSelectListIterator<ServerInfo, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<ServerInfo, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x176BF60 Offset: 0x176A560 VA: 0x18176BF60
	|-Enumerable.WhereSelectListIterator<ServerInfo, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<ServerInfo, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<ServerInfo, bool>.MoveNext
	|
	|-RVA: 0x176F970 Offset: 0x176DF70 VA: 0x18176F970
	|-Enumerable.WhereSelectListIterator<ServerInfo, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<ServerInfo, long>.MoveNext
	|
	|-RVA: 0x176E620 Offset: 0x176CC20 VA: 0x18176E620
	|-Enumerable.WhereSelectListIterator<ServerInfo, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<ServerInfo, Resolution>.MoveNext
	|
	|-RVA: 0x176DFB0 Offset: 0x176C5B0 VA: 0x18176DFB0
	|-Enumerable.WhereSelectListIterator<ServerInfo, Option>.MoveNext
	|
	|-RVA: 0x1772B40 Offset: 0x1771140 VA: 0x181772B40
	|-Enumerable.WhereSelectListIterator<ServerInfo, InventoryItem>.MoveNext
	|
	|-RVA: 0x176F110 Offset: 0x176D710 VA: 0x18176F110
	|-Enumerable.WhereSelectListIterator<ServerInfo, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x176EBA0 Offset: 0x176D1A0 VA: 0x18176EBA0
	|-Enumerable.WhereSelectListIterator<ServerInfo, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x176F3D0 Offset: 0x176D9D0 VA: 0x18176F3D0
	|-Enumerable.WhereSelectListIterator<ServerInfo, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<ServerInfo, Int32Enum>.MoveNext
	|
	|-RVA: 0x1772FA0 Offset: 0x17715A0 VA: 0x181772FA0
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>.MoveNext
	|
	|-RVA: 0x1770B80 Offset: 0x176F180 VA: 0x181770B80
	|-Enumerable.WhereSelectListIterator<ServerInfo, float>.MoveNext
	|
	|-RVA: 0x1770720 Offset: 0x176ED20 VA: 0x181770720
	|-Enumerable.WhereSelectListIterator<SkinnedMultiMesh.Part, long>.MoveNext
	|
	|-RVA: 0x176D150 Offset: 0x176B750 VA: 0x18176D150
	|-Enumerable.WhereSelectListIterator<Achievement, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<Achievement, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x176D030 Offset: 0x176B630 VA: 0x18176D030
	|-Enumerable.WhereSelectListIterator<Achievement, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<Achievement, long>.MoveNext
	|
	|-RVA: 0x176C8E0 Offset: 0x176AEE0 VA: 0x18176C8E0
	|-Enumerable.WhereSelectListIterator<Achievement, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<Achievement, Resolution>.MoveNext
	|
	|-RVA: 0x1772A00 Offset: 0x1771000 VA: 0x181772A00
	|-Enumerable.WhereSelectListIterator<Achievement, Option>.MoveNext
	|
	|-RVA: 0x1772260 Offset: 0x1770860 VA: 0x181772260
	|-Enumerable.WhereSelectListIterator<Achievement, InventoryItem>.MoveNext
	|
	|-RVA: 0x1770470 Offset: 0x176EA70 VA: 0x181770470
	|-Enumerable.WhereSelectListIterator<Achievement, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1771950 Offset: 0x176FF50 VA: 0x181771950
	|-Enumerable.WhereSelectListIterator<Achievement, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x176D820 Offset: 0x176BE20 VA: 0x18176D820
	|-Enumerable.WhereSelectListIterator<Achievement, object>.MoveNext
	|
	|-RVA: 0x1772630 Offset: 0x1770C30 VA: 0x181772630
	|-Enumerable.WhereSelectListIterator<Achievement, float>.MoveNext
	|
	|-RVA: 0x1771340 Offset: 0x176F940 VA: 0x181771340
	|-Enumerable.WhereSelectListIterator<InventoryDefId, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryDefId, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x176C660 Offset: 0x176AC60 VA: 0x18176C660
	|-Enumerable.WhereSelectListIterator<InventoryDefId, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryDefId, long>.MoveNext
	|
	|-RVA: 0x1771590 Offset: 0x176FB90 VA: 0x181771590
	|-Enumerable.WhereSelectListIterator<InventoryDefId, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryDefId, Resolution>.MoveNext
	|
	|-RVA: 0x1771C20 Offset: 0x1770220 VA: 0x181771C20
	|-Enumerable.WhereSelectListIterator<InventoryDefId, Option>.MoveNext
	|
	|-RVA: 0x176E8D0 Offset: 0x176CED0 VA: 0x18176E8D0
	|-Enumerable.WhereSelectListIterator<InventoryDefId, InventoryItem>.MoveNext
	|
	|-RVA: 0x17723A0 Offset: 0x17709A0 VA: 0x1817723A0
	|-Enumerable.WhereSelectListIterator<InventoryDefId, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x17728C0 Offset: 0x1770EC0 VA: 0x1817728C0
	|-Enumerable.WhereSelectListIterator<InventoryDefId, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x176E500 Offset: 0x176CB00 VA: 0x18176E500
	|-Enumerable.WhereSelectListIterator<InventoryDefId, bool>.MoveNext
	|
	|-RVA: 0x176C3A0 Offset: 0x176A9A0 VA: 0x18176C3A0
	|-Enumerable.WhereSelectListIterator<InventoryDefId, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryDefId, Int32Enum>.MoveNext
	|
	|-RVA: 0x1770100 Offset: 0x176E700 VA: 0x181770100
	|-Enumerable.WhereSelectListIterator<InventoryDefId, object>.MoveNext
	|
	|-RVA: 0x17716C0 Offset: 0x176FCC0 VA: 0x1817716C0
	|-Enumerable.WhereSelectListIterator<InventoryDefId, float>.MoveNext
	|
	|-RVA: 0x176F670 Offset: 0x176DC70 VA: 0x18176F670
	|-Enumerable.WhereSelectListIterator<ServerInfo, ServerInfo>.MoveNext
	|
	|-RVA: 0x1773520 Offset: 0x1771B20 VA: 0x181773520
	|-Enumerable.WhereSelectListIterator<ServerInfo, int>.MoveNext
	|
	|-RVA: 0x176CB40 Offset: 0x176B140 VA: 0x18176CB40
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>.MoveNext
	|
	|-RVA: 0x176CA10 Offset: 0x176B010 VA: 0x18176CA10
	|-Enumerable.WhereSelectListIterator<Friend, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<Friend, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x176CF10 Offset: 0x176B510 VA: 0x18176CF10
	|-Enumerable.WhereSelectListIterator<Friend, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<Friend, long>.MoveNext
	|
	|-RVA: 0x176BE30 Offset: 0x176A430 VA: 0x18176BE30
	|-Enumerable.WhereSelectListIterator<Friend, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<Friend, Resolution>.MoveNext
	|
	|-RVA: 0x1771FE0 Offset: 0x17705E0 VA: 0x181771FE0
	|-Enumerable.WhereSelectListIterator<Friend, Option>.MoveNext
	|
	|-RVA: 0x1771EA0 Offset: 0x17704A0 VA: 0x181771EA0
	|-Enumerable.WhereSelectListIterator<Friend, InventoryItem>.MoveNext
	|
	|-RVA: 0x1772120 Offset: 0x1770720 VA: 0x181772120
	|-Enumerable.WhereSelectListIterator<Friend, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x17733E0 Offset: 0x17719E0 VA: 0x1817733E0
	|-Enumerable.WhereSelectListIterator<Friend, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1770DE0 Offset: 0x176F3E0 VA: 0x181770DE0
	|-Enumerable.WhereSelectListIterator<Friend, object>.MoveNext
	|
	|-RVA: 0x1771470 Offset: 0x176FA70 VA: 0x181771470
	|-Enumerable.WhereSelectListIterator<Friend, float>.MoveNext
	|
	|-RVA: 0x176D550 Offset: 0x176BB50 VA: 0x18176D550
	|-Enumerable.WhereSelectListIterator<InventoryItem, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryItem, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x176C780 Offset: 0x176AD80 VA: 0x18176C780
	|-Enumerable.WhereSelectListIterator<InventoryItem, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryItem, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryItem, bool>.MoveNext
	|
	|-RVA: 0x176D6C0 Offset: 0x176BCC0 VA: 0x18176D6C0
	|-Enumerable.WhereSelectListIterator<InventoryItem, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryItem, InventoryItemId>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryItem, long>.MoveNext
	|
	|-RVA: 0x176FD30 Offset: 0x176E330 VA: 0x18176FD30
	|-Enumerable.WhereSelectListIterator<InventoryItem, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryItem, Resolution>.MoveNext
	|
	|-RVA: 0x1770880 Offset: 0x176EE80 VA: 0x181770880
	|-Enumerable.WhereSelectListIterator<InventoryItem, Option>.MoveNext
	|
	|-RVA: 0x1772750 Offset: 0x1770D50 VA: 0x181772750
	|-Enumerable.WhereSelectListIterator<InventoryItem, InventoryItem>.MoveNext
	|
	|-RVA: 0x17717E0 Offset: 0x176FDE0 VA: 0x1817717E0
	|-Enumerable.WhereSelectListIterator<InventoryItem, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x17705B0 Offset: 0x176EBB0 VA: 0x1817705B0
	|-Enumerable.WhereSelectListIterator<InventoryItem, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1792A70 Offset: 0x1791070 VA: 0x181792A70
	|-Enumerable.WhereSelectListIterator<InventoryItem, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryItem, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryItem, uint>.MoveNext
	|
	|-RVA: 0x1791420 Offset: 0x178FA20 VA: 0x181791420
	|-Enumerable.WhereSelectListIterator<InventoryItem, object>.MoveNext
	|
	|-RVA: 0x1793840 Offset: 0x1791E40 VA: 0x181793840
	|-Enumerable.WhereSelectListIterator<InventoryItem, float>.MoveNext
	|
	|-RVA: 0x1792D00 Offset: 0x1791300 VA: 0x181792D00
	|-Enumerable.WhereSelectListIterator<InventoryItem.Amount, InventoryItemId>.MoveNext
	|
	|-RVA: 0x1792FD0 Offset: 0x17915D0 VA: 0x181792FD0
	|-Enumerable.WhereSelectListIterator<InventoryItem.Amount, uint>.MoveNext
	|
	|-RVA: 0x1791590 Offset: 0x178FB90 VA: 0x181791590
	|-Enumerable.WhereSelectListIterator<InventoryRecipe, PlayerItemRecipe>.MoveNext
	|
	|-RVA: 0x1793460 Offset: 0x1791A60 VA: 0x181793460
	|-Enumerable.WhereSelectListIterator<InventoryRecipe, object>.MoveNext
	|
	|-RVA: 0x1790EF0 Offset: 0x178F4F0 VA: 0x181790EF0
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x17912B0 Offset: 0x178F8B0 VA: 0x1817912B0
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, long>.MoveNext
	|
	|-RVA: 0x1791B20 Offset: 0x1790120 VA: 0x181791B20
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, Resolution>.MoveNext
	|
	|-RVA: 0x1791990 Offset: 0x178FF90 VA: 0x181791990
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, Option>.MoveNext
	|
	|-RVA: 0x17923E0 Offset: 0x17909E0 VA: 0x1817923E0
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, InventoryItem>.MoveNext
	|
	|-RVA: 0x17932D0 Offset: 0x17918D0 VA: 0x1817932D0
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1793D30 Offset: 0x1792330 VA: 0x181793D30
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1792570 Offset: 0x1790B70 VA: 0x181792570
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, bool>.MoveNext
	|
	|-RVA: 0x1790650 Offset: 0x178EC50 VA: 0x181790650
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, Int32Enum>.MoveNext
	|
	|-RVA: 0x1793160 Offset: 0x1791760 VA: 0x181793160
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, object>.MoveNext
	|
	|-RVA: 0x1794000 Offset: 0x1792600 VA: 0x181794000
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, float>.MoveNext
	|
	|-RVA: 0x1793BF0 Offset: 0x17921F0 VA: 0x181793BF0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1792BD0 Offset: 0x17911D0 VA: 0x181792BD0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, long>.MoveNext
	|
	|-RVA: 0x1790510 Offset: 0x178EB10 VA: 0x181790510
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, Resolution>.MoveNext
	|
	|-RVA: 0x17907C0 Offset: 0x178EDC0 VA: 0x1817907C0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, Option>.MoveNext
	|
	|-RVA: 0x1791DD0 Offset: 0x17903D0 VA: 0x181791DD0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, InventoryItem>.MoveNext
	|
	|-RVA: 0x1791710 Offset: 0x178FD10 VA: 0x181791710
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1790B60 Offset: 0x178F160 VA: 0x181790B60
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x17943E0 Offset: 0x17929E0 VA: 0x1817943E0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, bool>.MoveNext
	|
	|-RVA: 0x17922B0 Offset: 0x17908B0 VA: 0x1817922B0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, uint>.MoveNext
	|
	|-RVA: 0x1793700 Offset: 0x1791D00 VA: 0x181793700
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, object>.MoveNext
	|
	|-RVA: 0x1790CB0 Offset: 0x178F2B0 VA: 0x181790CB0
	|-Enumerable.WhereSelectListIterator<int, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<int, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<Int32Enum, bool>.MoveNext
	|
	|-RVA: 0x1792820 Offset: 0x1790E20 VA: 0x181792820
	|-Enumerable.WhereSelectListIterator<int, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<Int32Enum, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<Int32Enum, Int32Enum>.MoveNext
	|
	|-RVA: 0x1790A30 Offset: 0x178F030 VA: 0x181790A30
	|-Enumerable.WhereSelectListIterator<Int32Enum, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<Int32Enum, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1791190 Offset: 0x178F790 VA: 0x181791190
	|-Enumerable.WhereSelectListIterator<Int32Enum, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<Int32Enum, long>.MoveNext
	|
	|-RVA: 0x1791860 Offset: 0x178FE60 VA: 0x181791860
	|-Enumerable.WhereSelectListIterator<Int32Enum, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<Int32Enum, Resolution>.MoveNext
	|
	|-RVA: 0x17926E0 Offset: 0x1790CE0 VA: 0x1817926E0
	|-Enumerable.WhereSelectListIterator<Int32Enum, Option>.MoveNext
	|
	|-RVA: 0x1792E90 Offset: 0x1791490 VA: 0x181792E90
	|-Enumerable.WhereSelectListIterator<Int32Enum, InventoryItem>.MoveNext
	|
	|-RVA: 0x17942A0 Offset: 0x17928A0 VA: 0x1817942A0
	|-Enumerable.WhereSelectListIterator<Int32Enum, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1793990 Offset: 0x1791F90 VA: 0x181793990
	|-Enumerable.WhereSelectListIterator<Int32Enum, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x17935D0 Offset: 0x1791BD0 VA: 0x1817935D0
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.MoveNext
	|
	|-RVA: 0x1793AD0 Offset: 0x17920D0 VA: 0x181793AD0
	|-Enumerable.WhereSelectListIterator<Int32Enum, float>.MoveNext
	|
	|-RVA: 0x1791CA0 Offset: 0x17902A0 VA: 0x181791CA0
	|-Enumerable.WhereSelectListIterator<object, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, PlayerItemRecipe>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1791070 Offset: 0x178F670 VA: 0x181791070
	|-Enumerable.WhereSelectListIterator<object, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, bool>.MoveNext
	|
	|-RVA: 0x1790910 Offset: 0x178EF10 VA: 0x181790910
	|-Enumerable.WhereSelectListIterator<object, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, PlayerItemRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, InventoryItemId>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, long>.MoveNext
	|
	|-RVA: 0x1792940 Offset: 0x1790F40 VA: 0x181792940
	|-Enumerable.WhereSelectListIterator<object, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, Resolution>.MoveNext
	|
	|-RVA: 0x1793EC0 Offset: 0x17924C0 VA: 0x181793EC0
	|-Enumerable.WhereSelectListIterator<object, Option>.MoveNext
	|
	|-RVA: 0x1792170 Offset: 0x1790770 VA: 0x181792170
	|-Enumerable.WhereSelectListIterator<object, InventoryItem>.MoveNext
	|
	|-RVA: 0x1794510 Offset: 0x1792B10 VA: 0x181794510
	|-Enumerable.WhereSelectListIterator<object, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1794160 Offset: 0x1792760 VA: 0x181794160
	|-Enumerable.WhereSelectListIterator<object, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1790DD0 Offset: 0x178F3D0 VA: 0x181790DD0
	|-Enumerable.WhereSelectListIterator<object, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, uint>.MoveNext
	|
	|-RVA: 0x1792040 Offset: 0x1790640 VA: 0x181792040
	|-Enumerable.WhereSelectListIterator<object, object>.MoveNext
	|
	|-RVA: 0x1791F20 Offset: 0x1790520 VA: 0x181791F20
	|-Enumerable.WhereSelectListIterator<object, float>.MoveNext
	*/

	public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC8CFA0 Offset: 0xC8B5A0 VA: 0x180C8CFA0
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
	|-RVA: 0xC8D0E0 Offset: 0xC8B6E0 VA: 0x180C8D0E0
	|-Enumerable.WhereSelectListIterator<Option, Option>.Select<Option>
	|-Enumerable.WhereSelectListIterator<object, Option>.Select<Option>
	|-Enumerable.WhereSelectListIterator<object, InventoryItem>.Select<InventoryItemId>
	|-Enumerable.WhereSelectListIterator<object, InventoryItem>.Select<int>
	|-Enumerable.WhereSelectListIterator<object, InventoryItem>.Select<object>
	|-Enumerable.WhereSelectListIterator<object, InventoryItem>.Select<uint>
	|
	|-RVA: 0xC8D220 Offset: 0xC8B820 VA: 0x180C8D220
	|-Enumerable.WhereSelectListIterator<ServerInfo, ServerInfo>.Select<int>
	|-Enumerable.WhereSelectListIterator<ServerInfo, ServerInfo>.Select<object>
	|
	|-RVA: 0xC8D180 Offset: 0xC8B780 VA: 0x180C8D180
	|-Enumerable.WhereSelectListIterator<InventoryRecipe, PlayerItemRecipe>.Select<object>
	|-Enumerable.WhereSelectListIterator<DictionaryEntry, KeyValuePair<object, object>>.Select<object>
	|-Enumerable.WhereSelectListIterator<object, ProjectileWeaponMod.Modifier>.Select<float>
	|
	|-RVA: 0xC8D040 Offset: 0xC8B640 VA: 0x180C8D040
	|-Enumerable.WhereSelectListIterator<object, InventoryRecipe.Ingredient>.Select<PlayerItemRecipe.Ingredient>
	|-Enumerable.WhereSelectListIterator<object, InventoryRecipe.Ingredient>.Select<object>
	|-Enumerable.WhereSelectListIterator<object, InventoryRecipe>.Select<PlayerItemRecipe>
	*/

	public override IEnumerable<TResult> Where(Func<TResult, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1773AC0 Offset: 0x17720C0 VA: 0x181773AC0
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
	|-RVA: 0xD5BBD0 Offset: 0xD5A1D0 VA: 0x180D5BBD0
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
	|-RVA: 0x19EFE70 Offset: 0x19EE470 VA: 0x1819EFE70
	|-Enumerable.<>c__DisplayClass6_0<Debugging.EntityInfo>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<GameStat.Stat>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<PlayerItemRecipe>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<KeyValuePair<object, int>>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<KeyValuePair<object, object>>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<KeyValuePair<uint, object>>.<CombinePredicates>b__0
	|
	|-RVA: 0x19EFF90 Offset: 0x19EE590 VA: 0x1819EFF90
	|-Enumerable.<>c__DisplayClass6_0<SkeletonDefinition.Bone>.<CombinePredicates>b__0
	|
	|-RVA: 0x19F0420 Offset: 0x19EEA20 VA: 0x1819F0420
	|-Enumerable.<>c__DisplayClass6_0<ItemSkinDirectory.Skin>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<Option>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<SkinnedMultiMesh.Part>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<InventoryItem>.<CombinePredicates>b__0
	|
	|-RVA: 0x19F03A0 Offset: 0x19EE9A0 VA: 0x1819F03A0
	|-Enumerable.<>c__DisplayClass6_0<FourBitNumber>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<SevenBitNumber>.<CombinePredicates>b__0
	|
	|-RVA: 0x19F0320 Offset: 0x19EE920 VA: 0x1819F0320
	|-Enumerable.<>c__DisplayClass6_0<PathFinder.Point>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<PlayerItemRecipe.Ingredient>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<InventoryItemId>.<CombinePredicates>b__0
	|
	|-RVA: 0x19F01F0 Offset: 0x19EE7F0 VA: 0x1819F01F0
	|-Enumerable.<>c__DisplayClass6_0<ProjectileWeaponMod.Modifier>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<Resolution>.<CombinePredicates>b__0
	|
	|-RVA: 0x19F0050 Offset: 0x19EE650 VA: 0x1819F0050
	|-Enumerable.<>c__DisplayClass6_0<ServerInfo>.<CombinePredicates>b__0
	|
	|-RVA: 0x19F04D0 Offset: 0x19EEAD0 VA: 0x1819F04D0
	|-Enumerable.<>c__DisplayClass6_0<InventoryRecipe.Ingredient>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<InventoryRecipe>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<KeyValuePair<ulong, Dispatch.ResultCallback>>.<CombinePredicates>b__0
	|
	|-RVA: 0x19F0600 Offset: 0x19EEC00 VA: 0x1819F0600
	|-Enumerable.<>c__DisplayClass6_0<bool>.<CombinePredicates>b__0
	|
	|-RVA: 0x19F02A0 Offset: 0x19EE8A0 VA: 0x1819F02A0
	|-Enumerable.<>c__DisplayClass6_0<char>.<CombinePredicates>b__0
	|
	|-RVA: 0x19EFF10 Offset: 0x19EE510 VA: 0x1819EFF10
	|-Enumerable.<>c__DisplayClass6_0<int>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<Int32Enum>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<uint>.<CombinePredicates>b__0
	|
	|-RVA: 0x19F0170 Offset: 0x19EE770 VA: 0x1819F0170
	|-Enumerable.<>c__DisplayClass6_0<long>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<object>.<CombinePredicates>b__0
	|
	|-RVA: 0x19F0580 Offset: 0x19EEB80 VA: 0x1819F0580
	|-Enumerable.<>c__DisplayClass6_0<float>.<CombinePredicates>b__0
	*/

}

private sealed class Enumerable.<>c__DisplayClass7_0<TSource, TMiddle, TResult> // TypeDefIndex: 3207
{	public Func<TMiddle, TResult> selector2; // 0x0
	public Func<TSource, TMiddle> selector1; // 0x0


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BBD0 Offset: 0xD5A1D0 VA: 0x180D5BBD0
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
	|-RVA: 0x144D380 Offset: 0x144B980 VA: 0x18144D380
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
	|-RVA: 0x144BD50 Offset: 0x144A350 VA: 0x18144BD50
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
	|-RVA: 0x19F0D00 Offset: 0x19EF300 VA: 0x1819F0D00
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, Debugging.EntityInfo, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, KeyValuePair<object, int>, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x19F0750 Offset: 0x19EED50 VA: 0x1819F0750
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
	|-RVA: 0x19F0A80 Offset: 0x19EF080 VA: 0x1819F0A80
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, Resolution, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x19F0880 Offset: 0x19EEE80 VA: 0x1819F0880
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, Option, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, InventoryItem, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x19F0680 Offset: 0x19EEC80 VA: 0x1819F0680
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|
	|-RVA: 0x19F0950 Offset: 0x19EEF50 VA: 0x1819F0950
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, bool, bool>.<CombineSelectors>b__0
	|
	|-RVA: 0x19F0B50 Offset: 0x19EF150 VA: 0x1819F0B50
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, Int32Enum, Int32Enum>.<CombineSelectors>b__0
	|
	|-RVA: 0x19F0DC0 Offset: 0x19EF3C0 VA: 0x1819F0DC0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x19F0C50 Offset: 0x19EF250 VA: 0x1819F0C50
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x19F07D0 Offset: 0x19EEDD0 VA: 0x1819F07D0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x19F09D0 Offset: 0x19EEFD0 VA: 0x1819F09D0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, InventoryRecipe>.<CombineSelectors>b__0
	|
	|-RVA: 0x19F0BD0 Offset: 0x19EF1D0 VA: 0x1819F0BD0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, float, float>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C830 Offset: 0x144AE30 VA: 0x18144C830
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, Debugging.EntityInfo, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, KeyValuePair<object, int>, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, Debugging.EntityInfo, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, KeyValuePair<object, int>, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, Debugging.EntityInfo, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, KeyValuePair<object, int>, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x144BC30 Offset: 0x144A230 VA: 0x18144BC30
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
	|-RVA: 0x144BCA0 Offset: 0x144A2A0 VA: 0x18144BCA0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, Resolution, Resolution>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, Resolution, Resolution>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, Resolution, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C010 Offset: 0x144A610 VA: 0x18144C010
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, Option, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, InventoryItem, InventoryItem>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, Option, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, InventoryItem, InventoryItem>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, Option, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, InventoryItem, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x144CA80 Offset: 0x144B080 VA: 0x18144CA80
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|
	|-RVA: 0x144DA60 Offset: 0x144C060 VA: 0x18144DA60
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, bool, bool>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, bool, bool>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, bool, bool>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C5A0 Offset: 0x144ABA0 VA: 0x18144C5A0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, Int32Enum, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, Int32Enum, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, Int32Enum, Int32Enum>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C3D0 Offset: 0x144A9D0 VA: 0x18144C3D0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E070 Offset: 0x144C670 VA: 0x18144E070
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, Resolution>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, Resolution>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C9F0 Offset: 0x144AFF0 VA: 0x18144C9F0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, InventoryItem>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, InventoryItem>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D0E0 Offset: 0x144B6E0 VA: 0x18144D0E0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, InventoryRecipe>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D3E0 Offset: 0x144B9E0 VA: 0x18144D3E0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, float, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, float, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, float, float>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C610 Offset: 0x144AC10 VA: 0x18144C610
	|-Enumerable.<>c__DisplayClass7_0<Option, Option, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, Option, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, InventoryItem, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x144CBD0 Offset: 0x144B1D0 VA: 0x18144CBD0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, Debugging.EntityInfo, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, KeyValuePair<object, int>, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E2C0 Offset: 0x144C8C0 VA: 0x18144E2C0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, FourBitNumber, FourBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, SevenBitNumber, SevenBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, bool, bool>.<CombineSelectors>b__0
	|
	|-RVA: 0x144CE70 Offset: 0x144B470 VA: 0x18144CE70
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
	|-RVA: 0x144DC50 Offset: 0x144C250 VA: 0x18144DC50
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, Resolution, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144BF10 Offset: 0x144A510 VA: 0x18144BF10
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, Option, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, InventoryItem, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D6D0 Offset: 0x144BCD0 VA: 0x18144D6D0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|
	|-RVA: 0x144DDE0 Offset: 0x144C3E0 VA: 0x18144DDE0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, int, FourBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, int, SevenBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, Int32Enum, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, int, int>.<CombineSelectors>b__0
	|
	|-RVA: 0x144EA70 Offset: 0x144D070 VA: 0x18144EA70
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x144DAD0 Offset: 0x144C0D0 VA: 0x18144DAD0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D200 Offset: 0x144B800 VA: 0x18144D200
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E980 Offset: 0x144CF80 VA: 0x18144E980
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, InventoryRecipe>.<CombineSelectors>b__0
	|
	|-RVA: 0x144EB50 Offset: 0x144D150 VA: 0x18144EB50
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, float, float>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D050 Offset: 0x144B650 VA: 0x18144D050
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
	|-RVA: 0x144BE30 Offset: 0x144A430 VA: 0x18144BE30
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
	|-RVA: 0x144C460 Offset: 0x144AA60 VA: 0x18144C460
	|-Enumerable.<>c__DisplayClass7_0<Achievement, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, Resolution, Resolution>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, Resolution, Resolution>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, Resolution, Resolution>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, Resolution, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144CB30 Offset: 0x144B130 VA: 0x18144CB30
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
	|-RVA: 0x144C500 Offset: 0x144AB00 VA: 0x18144C500
	|-Enumerable.<>c__DisplayClass7_0<Achievement, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C8D0 Offset: 0x144AED0 VA: 0x18144C8D0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x144DD50 Offset: 0x144C350 VA: 0x18144DD50
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, Resolution>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D2F0 Offset: 0x144B8F0 VA: 0x18144D2F0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, InventoryItem>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C2C0 Offset: 0x144A8C0 VA: 0x18144C2C0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, InventoryRecipe>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C0C0 Offset: 0x144A6C0 VA: 0x18144C0C0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, float, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, float, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, float, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, float, float>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E240 Offset: 0x144C840 VA: 0x18144E240
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E380 Offset: 0x144C980 VA: 0x18144E380
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144CFC0 Offset: 0x144B5C0 VA: 0x18144CFC0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x144CF30 Offset: 0x144B530 VA: 0x18144CF30
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, InventoryRecipe>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D5B0 Offset: 0x144BBB0 VA: 0x18144D5B0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, ServerInfo, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, ServerInfo, object>.<CombineSelectors>b__0
	|
	|-RVA: 0x144DBB0 Offset: 0x144C1B0 VA: 0x18144DBB0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, Debugging.EntityInfo, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, KeyValuePair<object, int>, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E1C0 Offset: 0x144C7C0 VA: 0x18144E1C0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, FourBitNumber, FourBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, SevenBitNumber, SevenBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, bool, bool>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C240 Offset: 0x144A840 VA: 0x18144C240
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
	|-RVA: 0x144C6D0 Offset: 0x144ACD0 VA: 0x18144C6D0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, Resolution, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E8C0 Offset: 0x144CEC0 VA: 0x18144E8C0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|
	|-RVA: 0x144CD60 Offset: 0x144B360 VA: 0x18144CD60
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, int, FourBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, int, SevenBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, Int32Enum, Int32Enum>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D7D0 Offset: 0x144BDD0 VA: 0x18144D7D0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D870 Offset: 0x144BE70 VA: 0x18144D870
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C1A0 Offset: 0x144A7A0 VA: 0x18144C1A0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D450 Offset: 0x144BA50 VA: 0x18144D450
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, InventoryRecipe>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D180 Offset: 0x144B780 VA: 0x18144D180
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, float, float>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D9D0 Offset: 0x144BFD0 VA: 0x18144D9D0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe, PlayerItemRecipe, object>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C350 Offset: 0x144A950 VA: 0x18144C350
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
	|-RVA: 0x144BB80 Offset: 0x144A180 VA: 0x18144BB80
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, Debugging.EntityInfo, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, KeyValuePair<object, int>, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D910 Offset: 0x144BF10 VA: 0x18144D910
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, Resolution, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D4F0 Offset: 0x144BAF0 VA: 0x18144D4F0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, Option, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, InventoryItem, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E100 Offset: 0x144C700 VA: 0x18144E100
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E730 Offset: 0x144CD30 VA: 0x18144E730
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, bool, bool>.<CombineSelectors>b__0
	|
	|-RVA: 0x144BE90 Offset: 0x144A490 VA: 0x18144BE90
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, Int32Enum, Int32Enum>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C950 Offset: 0x144AF50 VA: 0x18144C950
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x144DFD0 Offset: 0x144C5D0 VA: 0x18144DFD0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144DF30 Offset: 0x144C530 VA: 0x18144DF30
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x144CCC0 Offset: 0x144B2C0 VA: 0x18144CCC0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, InventoryRecipe>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E530 Offset: 0x144CB30 VA: 0x18144E530
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, float, float>.<CombineSelectors>b__0
	|
	|-RVA: 0x144BDB0 Offset: 0x144A3B0 VA: 0x18144BDB0
	|-Enumerable.<>c__DisplayClass7_0<DictionaryEntry, KeyValuePair<object, object>, object>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E5B0 Offset: 0x144CBB0 VA: 0x18144E5B0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E410 Offset: 0x144CA10 VA: 0x18144E410
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E830 Offset: 0x144CE30 VA: 0x18144E830
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x144DEA0 Offset: 0x144C4A0 VA: 0x18144DEA0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, InventoryRecipe>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E7B0 Offset: 0x144CDB0 VA: 0x18144E7B0
	|-Enumerable.<>c__DisplayClass7_0<object, ProjectileWeaponMod.Modifier, float>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E6B0 Offset: 0x144CCB0 VA: 0x18144E6B0
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryItem, InventoryItemId>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryItem, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryItem, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryItem, uint>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C790 Offset: 0x144AD90 VA: 0x18144C790
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryRecipe, PlayerItemRecipe>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C120 Offset: 0x144A720 VA: 0x18144C120
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryRecipe.Ingredient, object>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E630 Offset: 0x144CC30 VA: 0x18144E630
	|-Enumerable.<>c__DisplayClass7_0<object, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x144EC10 Offset: 0x144D210 VA: 0x18144EC10
	|-Enumerable.<>c__DisplayClass7_0<object, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, object, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E4A0 Offset: 0x144CAA0 VA: 0x18144E4A0
	|-Enumerable.<>c__DisplayClass7_0<object, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, object, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x144CDE0 Offset: 0x144B3E0 VA: 0x18144CDE0
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
	|-RVA: 0x144AC90 Offset: 0x1449290 VA: 0x18144AC90
	|-Enumerable.<SelectManyIterator>d__17<object, PlayerItemRecipe>..ctor
	|
	|-RVA: 0x19D4380 Offset: 0x19D2980 VA: 0x1819D4380
	|-Enumerable.<SelectManyIterator>d__17<object, InventoryRecipe>..ctor
	|
	|-RVA: 0x144AC50 Offset: 0x1449250 VA: 0x18144AC50
	|-Enumerable.<SelectManyIterator>d__17<object, byte>..ctor
	|
	|-RVA: 0x144ACD0 Offset: 0x14492D0 VA: 0x18144ACD0
	|-Enumerable.<SelectManyIterator>d__17<object, object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D4030 Offset: 0x19D2630 VA: 0x1819D4030
	|-Enumerable.<SelectManyIterator>d__17<object, PlayerItemRecipe>.System.IDisposable.Dispose
	|-Enumerable.<SelectManyIterator>d__17<object, InventoryRecipe>.System.IDisposable.Dispose
	|-Enumerable.<SelectManyIterator>d__17<object, byte>.System.IDisposable.Dispose
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D3270 Offset: 0x19D1870 VA: 0x1819D3270
	|-Enumerable.<SelectManyIterator>d__17<object, PlayerItemRecipe>.MoveNext
	|
	|-RVA: 0x19D2F90 Offset: 0x19D1590 VA: 0x1819D2F90
	|-Enumerable.<SelectManyIterator>d__17<object, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x19D3810 Offset: 0x19D1E10 VA: 0x1819D3810
	|-Enumerable.<SelectManyIterator>d__17<object, byte>.MoveNext
	|
	|-RVA: 0x19D3540 Offset: 0x19D1B40 VA: 0x1819D3540
	|-Enumerable.<SelectManyIterator>d__17<object, object>.MoveNext
	*/

	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D41F0 Offset: 0x19D27F0 VA: 0x1819D41F0
	|-Enumerable.<SelectManyIterator>d__17<object, PlayerItemRecipe>.<>m__Finally1
	|
	|-RVA: 0x19D41A0 Offset: 0x19D27A0 VA: 0x1819D41A0
	|-Enumerable.<SelectManyIterator>d__17<object, InventoryRecipe>.<>m__Finally1
	|
	|-RVA: 0x19D4100 Offset: 0x19D2700 VA: 0x1819D4100
	|-Enumerable.<SelectManyIterator>d__17<object, byte>.<>m__Finally1
	|
	|-RVA: 0x19D4150 Offset: 0x19D2750 VA: 0x1819D4150
	|-Enumerable.<SelectManyIterator>d__17<object, object>.<>m__Finally1
	*/

	private void <>m__Finally2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D4330 Offset: 0x19D2930 VA: 0x1819D4330
	|-Enumerable.<SelectManyIterator>d__17<object, PlayerItemRecipe>.<>m__Finally2
	|
	|-RVA: 0x19D4290 Offset: 0x19D2890 VA: 0x1819D4290
	|-Enumerable.<SelectManyIterator>d__17<object, InventoryRecipe>.<>m__Finally2
	|
	|-RVA: 0x19D4240 Offset: 0x19D2840 VA: 0x1819D4240
	|-Enumerable.<SelectManyIterator>d__17<object, byte>.<>m__Finally2
	|
	|-RVA: 0x19D42E0 Offset: 0x19D28E0 VA: 0x1819D42E0
	|-Enumerable.<SelectManyIterator>d__17<object, object>.<>m__Finally2
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB11AC0 Offset: 0xB100C0 VA: 0x180B11AC0
	|-Enumerable.<SelectManyIterator>d__17<object, PlayerItemRecipe>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0x1128460 Offset: 0x1126A60 VA: 0x181128460
	|-Enumerable.<SelectManyIterator>d__17<object, InventoryRecipe>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0xA116B0 Offset: 0xA0FCB0 VA: 0x180A116B0
	|-Enumerable.<SelectManyIterator>d__17<object, byte>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D3EA0 Offset: 0x19D24A0 VA: 0x1819D3EA0
	|-Enumerable.<SelectManyIterator>d__17<object, PlayerItemRecipe>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D3E50 Offset: 0x19D2450 VA: 0x1819D3E50
	|-Enumerable.<SelectManyIterator>d__17<object, InventoryRecipe>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D3EF0 Offset: 0x19D24F0 VA: 0x1819D3EF0
	|-Enumerable.<SelectManyIterator>d__17<object, byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D3E00 Offset: 0x19D2400 VA: 0x1819D3E00
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D3FE0 Offset: 0x19D25E0 VA: 0x1819D3FE0
	|-Enumerable.<SelectManyIterator>d__17<object, PlayerItemRecipe>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D3F90 Offset: 0x19D2590 VA: 0x1819D3F90
	|-Enumerable.<SelectManyIterator>d__17<object, InventoryRecipe>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D3F40 Offset: 0x19D2540 VA: 0x1819D3F40
	|-Enumerable.<SelectManyIterator>d__17<object, byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D3AD0 Offset: 0x19D20D0 VA: 0x1819D3AD0
	|-Enumerable.<SelectManyIterator>d__17<object, PlayerItemRecipe>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0x19D3B90 Offset: 0x19D2190 VA: 0x1819D3B90
	|-Enumerable.<SelectManyIterator>d__17<object, InventoryRecipe>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0x19D3D10 Offset: 0x19D2310 VA: 0x1819D3D10
	|-Enumerable.<SelectManyIterator>d__17<object, byte>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0x19D3C50 Offset: 0x19D2250 VA: 0x1819D3C50
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D3DD0 Offset: 0x19D23D0 VA: 0x1819D3DD0
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
	|-RVA: 0x19D5C80 Offset: 0x19D4280 VA: 0x1819D5C80
	|-Enumerable.<TakeIterator>d__25<Option>..ctor
	|-Enumerable.<TakeIterator>d__25<InventoryItem>..ctor
	|
	|-RVA: 0x144AC50 Offset: 0x1449250 VA: 0x18144AC50
	|-Enumerable.<TakeIterator>d__25<byte>..ctor
	|
	|-RVA: 0x144ACD0 Offset: 0x14492D0 VA: 0x18144ACD0
	|-Enumerable.<TakeIterator>d__25<double>..ctor
	|-Enumerable.<TakeIterator>d__25<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A990 Offset: 0x1448F90 VA: 0x18144A990
	|-Enumerable.<TakeIterator>d__25<Option>.System.IDisposable.Dispose
	|-Enumerable.<TakeIterator>d__25<InventoryItem>.System.IDisposable.Dispose
	|-Enumerable.<TakeIterator>d__25<byte>.System.IDisposable.Dispose
	|-Enumerable.<TakeIterator>d__25<double>.System.IDisposable.Dispose
	|-Enumerable.<TakeIterator>d__25<object>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D4E50 Offset: 0x19D3450 VA: 0x1819D4E50
	|-Enumerable.<TakeIterator>d__25<Option>.MoveNext
	|
	|-RVA: 0x19D53B0 Offset: 0x19D39B0 VA: 0x1819D53B0
	|-Enumerable.<TakeIterator>d__25<InventoryItem>.MoveNext
	|
	|-RVA: 0x19D51F0 Offset: 0x19D37F0 VA: 0x1819D51F0
	|-Enumerable.<TakeIterator>d__25<byte>.MoveNext
	|
	|-RVA: 0x19D5030 Offset: 0x19D3630 VA: 0x1819D5030
	|-Enumerable.<TakeIterator>d__25<double>.MoveNext
	|
	|-RVA: 0x19D5590 Offset: 0x19D3B90 VA: 0x1819D5590
	|-Enumerable.<TakeIterator>d__25<object>.MoveNext
	*/

	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D5B40 Offset: 0x19D4140 VA: 0x1819D5B40
	|-Enumerable.<TakeIterator>d__25<Option>.<>m__Finally1
	|
	|-RVA: 0x19D5BE0 Offset: 0x19D41E0 VA: 0x1819D5BE0
	|-Enumerable.<TakeIterator>d__25<InventoryItem>.<>m__Finally1
	|
	|-RVA: 0x19D5AF0 Offset: 0x19D40F0 VA: 0x1819D5AF0
	|-Enumerable.<TakeIterator>d__25<byte>.<>m__Finally1
	|
	|-RVA: 0x19D5C30 Offset: 0x19D4230 VA: 0x1819D5C30
	|-Enumerable.<TakeIterator>d__25<double>.<>m__Finally1
	|
	|-RVA: 0x19D5B90 Offset: 0x19D4190 VA: 0x1819D5B90
	|-Enumerable.<TakeIterator>d__25<object>.<>m__Finally1
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176B3D0 Offset: 0x17699D0 VA: 0x18176B3D0
	|-Enumerable.<TakeIterator>d__25<Option>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|-Enumerable.<TakeIterator>d__25<InventoryItem>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0xA116B0 Offset: 0xA0FCB0 VA: 0x180A116B0
	|-Enumerable.<TakeIterator>d__25<byte>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0xB3C130 Offset: 0xB3A730 VA: 0x180B3C130
	|-Enumerable.<TakeIterator>d__25<double>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<TakeIterator>d__25<object>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D5A50 Offset: 0x19D4050 VA: 0x1819D5A50
	|-Enumerable.<TakeIterator>d__25<Option>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D5A00 Offset: 0x19D4000 VA: 0x1819D5A00
	|-Enumerable.<TakeIterator>d__25<InventoryItem>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D59B0 Offset: 0x19D3FB0 VA: 0x1819D59B0
	|-Enumerable.<TakeIterator>d__25<byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D5960 Offset: 0x19D3F60 VA: 0x1819D5960
	|-Enumerable.<TakeIterator>d__25<double>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D5AA0 Offset: 0x19D40A0 VA: 0x1819D5AA0
	|-Enumerable.<TakeIterator>d__25<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176B8C0 Offset: 0x1769EC0 VA: 0x18176B8C0
	|-Enumerable.<TakeIterator>d__25<Option>.System.Collections.IEnumerator.get_Current
	|-Enumerable.<TakeIterator>d__25<InventoryItem>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D4D10 Offset: 0x19D3310 VA: 0x1819D4D10
	|-Enumerable.<TakeIterator>d__25<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x176B7E0 Offset: 0x1769DE0 VA: 0x18176B7E0
	|-Enumerable.<TakeIterator>d__25<double>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<TakeIterator>d__25<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D5800 Offset: 0x19D3E00 VA: 0x1819D5800
	|-Enumerable.<TakeIterator>d__25<Option>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|-Enumerable.<TakeIterator>d__25<InventoryItem>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x19D58B0 Offset: 0x19D3EB0 VA: 0x1819D58B0
	|-Enumerable.<TakeIterator>d__25<byte>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x19D5750 Offset: 0x19D3D50 VA: 0x1819D5750
	|-Enumerable.<TakeIterator>d__25<double>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|-Enumerable.<TakeIterator>d__25<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19B4640 Offset: 0x19B2C40 VA: 0x1819B4640
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
	|-RVA: 0x144ACD0 Offset: 0x14492D0 VA: 0x18144ACD0
	|-Enumerable.<TakeWhileIterator>d__27<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A990 Offset: 0x1448F90 VA: 0x18144A990
	|-Enumerable.<TakeWhileIterator>d__27<object>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D5CC0 Offset: 0x19D42C0 VA: 0x1819D5CC0
	|-Enumerable.<TakeWhileIterator>d__27<object>.MoveNext
	*/

	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D5F00 Offset: 0x19D4500 VA: 0x1819D5F00
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
	|-RVA: 0x19D5EB0 Offset: 0x19D44B0 VA: 0x1819D5EB0
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
	|-RVA: 0x144B530 Offset: 0x1449B30 VA: 0x18144B530
	|-Enumerable.<TakeWhileIterator>d__27<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144B6B0 Offset: 0x1449CB0 VA: 0x18144B6B0
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
	|-RVA: 0x144AC50 Offset: 0x1449250 VA: 0x18144AC50
	|-Enumerable.<SkipIterator>d__31<byte>..ctor
	|
	|-RVA: 0x144ACD0 Offset: 0x14492D0 VA: 0x18144ACD0
	|-Enumerable.<SkipIterator>d__31<double>..ctor
	|-Enumerable.<SkipIterator>d__31<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A990 Offset: 0x1448F90 VA: 0x18144A990
	|-Enumerable.<SkipIterator>d__31<byte>.System.IDisposable.Dispose
	|-Enumerable.<SkipIterator>d__31<double>.System.IDisposable.Dispose
	|-Enumerable.<SkipIterator>d__31<object>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D4870 Offset: 0x19D2E70 VA: 0x1819D4870
	|-Enumerable.<SkipIterator>d__31<byte>.MoveNext
	|
	|-RVA: 0x19D4620 Offset: 0x19D2C20 VA: 0x1819D4620
	|-Enumerable.<SkipIterator>d__31<double>.MoveNext
	|
	|-RVA: 0x19D43C0 Offset: 0x19D29C0 VA: 0x1819D43C0
	|-Enumerable.<SkipIterator>d__31<object>.MoveNext
	*/

	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D4E00 Offset: 0x19D3400 VA: 0x1819D4E00
	|-Enumerable.<SkipIterator>d__31<byte>.<>m__Finally1
	|
	|-RVA: 0x19D4DB0 Offset: 0x19D33B0 VA: 0x1819D4DB0
	|-Enumerable.<SkipIterator>d__31<double>.<>m__Finally1
	|
	|-RVA: 0x19D4D60 Offset: 0x19D3360 VA: 0x1819D4D60
	|-Enumerable.<SkipIterator>d__31<object>.<>m__Finally1
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA116B0 Offset: 0xA0FCB0 VA: 0x180A116B0
	|-Enumerable.<SkipIterator>d__31<byte>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0xB3C130 Offset: 0xB3A730 VA: 0x180B3C130
	|-Enumerable.<SkipIterator>d__31<double>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<SkipIterator>d__31<object>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D4C20 Offset: 0x19D3220 VA: 0x1819D4C20
	|-Enumerable.<SkipIterator>d__31<byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D4CC0 Offset: 0x19D32C0 VA: 0x1819D4CC0
	|-Enumerable.<SkipIterator>d__31<double>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D4C70 Offset: 0x19D3270 VA: 0x1819D4C70
	|-Enumerable.<SkipIterator>d__31<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D4D10 Offset: 0x19D3310 VA: 0x1819D4D10
	|-Enumerable.<SkipIterator>d__31<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x176B7E0 Offset: 0x1769DE0 VA: 0x18176B7E0
	|-Enumerable.<SkipIterator>d__31<double>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<SkipIterator>d__31<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D4B70 Offset: 0x19D3170 VA: 0x1819D4B70
	|-Enumerable.<SkipIterator>d__31<byte>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x19D4AC0 Offset: 0x19D30C0 VA: 0x1819D4AC0
	|-Enumerable.<SkipIterator>d__31<double>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|-Enumerable.<SkipIterator>d__31<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19B4640 Offset: 0x19B2C40 VA: 0x1819B4640
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
	|-RVA: 0x144AC50 Offset: 0x1449250 VA: 0x18144AC50
	|-Enumerable.<ConcatIterator>d__59<byte>..ctor
	|
	|-RVA: 0x144ACD0 Offset: 0x14492D0 VA: 0x18144ACD0
	|-Enumerable.<ConcatIterator>d__59<long>..ctor
	|-Enumerable.<ConcatIterator>d__59<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144B870 Offset: 0x1449E70 VA: 0x18144B870
	|-Enumerable.<ConcatIterator>d__59<byte>.System.IDisposable.Dispose
	|-Enumerable.<ConcatIterator>d__59<long>.System.IDisposable.Dispose
	|-Enumerable.<ConcatIterator>d__59<object>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144AD10 Offset: 0x1449310 VA: 0x18144AD10
	|-Enumerable.<ConcatIterator>d__59<byte>.MoveNext
	|
	|-RVA: 0x144B280 Offset: 0x1449880 VA: 0x18144B280
	|-Enumerable.<ConcatIterator>d__59<long>.MoveNext
	|
	|-RVA: 0x144AFC0 Offset: 0x14495C0 VA: 0x18144AFC0
	|-Enumerable.<ConcatIterator>d__59<object>.MoveNext
	*/

	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144BA40 Offset: 0x144A040 VA: 0x18144BA40
	|-Enumerable.<ConcatIterator>d__59<byte>.<>m__Finally1
	|
	|-RVA: 0x144B9F0 Offset: 0x1449FF0 VA: 0x18144B9F0
	|-Enumerable.<ConcatIterator>d__59<long>.<>m__Finally1
	|
	|-RVA: 0x144B9A0 Offset: 0x1449FA0 VA: 0x18144B9A0
	|-Enumerable.<ConcatIterator>d__59<object>.<>m__Finally1
	*/

	private void <>m__Finally2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144BAE0 Offset: 0x144A0E0 VA: 0x18144BAE0
	|-Enumerable.<ConcatIterator>d__59<byte>.<>m__Finally2
	|
	|-RVA: 0x144BB30 Offset: 0x144A130 VA: 0x18144BB30
	|-Enumerable.<ConcatIterator>d__59<long>.<>m__Finally2
	|
	|-RVA: 0x144BA90 Offset: 0x144A090 VA: 0x18144BA90
	|-Enumerable.<ConcatIterator>d__59<object>.<>m__Finally2
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA116B0 Offset: 0xA0FCB0 VA: 0x180A116B0
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
	|-RVA: 0x144B6E0 Offset: 0x1449CE0 VA: 0x18144B6E0
	|-Enumerable.<ConcatIterator>d__59<byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x144B780 Offset: 0x1449D80 VA: 0x18144B780
	|-Enumerable.<ConcatIterator>d__59<long>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x144B730 Offset: 0x1449D30 VA: 0x18144B730
	|-Enumerable.<ConcatIterator>d__59<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144B7D0 Offset: 0x1449DD0 VA: 0x18144B7D0
	|-Enumerable.<ConcatIterator>d__59<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x144B820 Offset: 0x1449E20 VA: 0x18144B820
	|-Enumerable.<ConcatIterator>d__59<long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<ConcatIterator>d__59<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144B5F0 Offset: 0x1449BF0 VA: 0x18144B5F0
	|-Enumerable.<ConcatIterator>d__59<byte>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x144B530 Offset: 0x1449B30 VA: 0x18144B530
	|-Enumerable.<ConcatIterator>d__59<long>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|-Enumerable.<ConcatIterator>d__59<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144B6B0 Offset: 0x1449CB0 VA: 0x18144B6B0
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
	|-RVA: 0x144ACD0 Offset: 0x14492D0 VA: 0x18144ACD0
	|-Enumerable.<ZipIterator>d__65<object, long, object>..ctor
	|-Enumerable.<ZipIterator>d__65<object, object, object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D4030 Offset: 0x19D2630 VA: 0x1819D4030
	|-Enumerable.<ZipIterator>d__65<object, long, object>.System.IDisposable.Dispose
	|-Enumerable.<ZipIterator>d__65<object, object, object>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D6D20 Offset: 0x19D5320 VA: 0x1819D6D20
	|-Enumerable.<ZipIterator>d__65<object, long, object>.MoveNext
	|
	|-RVA: 0x19D6A40 Offset: 0x19D5040 VA: 0x1819D6A40
	|-Enumerable.<ZipIterator>d__65<object, object, object>.MoveNext
	*/

	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D7170 Offset: 0x19D5770 VA: 0x1819D7170
	|-Enumerable.<ZipIterator>d__65<object, long, object>.<>m__Finally1
	|
	|-RVA: 0x19D71C0 Offset: 0x19D57C0 VA: 0x1819D71C0
	|-Enumerable.<ZipIterator>d__65<object, object, object>.<>m__Finally1
	*/

	private void <>m__Finally2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D7210 Offset: 0x19D5810 VA: 0x1819D7210
	|-Enumerable.<ZipIterator>d__65<object, long, object>.<>m__Finally2
	|
	|-RVA: 0x19D7260 Offset: 0x19D5860 VA: 0x1819D7260
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
	|-RVA: 0x19D70D0 Offset: 0x19D56D0 VA: 0x1819D70D0
	|-Enumerable.<ZipIterator>d__65<object, long, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D7120 Offset: 0x19D5720 VA: 0x1819D7120
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
	|-RVA: 0x19D7000 Offset: 0x19D5600 VA: 0x1819D7000
	|-Enumerable.<ZipIterator>d__65<object, long, object>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|-Enumerable.<ZipIterator>d__65<object, object, object>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D3DD0 Offset: 0x19D23D0 VA: 0x1819D3DD0
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
	|-RVA: 0x19D15E0 Offset: 0x19CFBE0 VA: 0x1819D15E0
	|-Enumerable.<DistinctIterator>d__68<ServerInfo>..ctor
	|
	|-RVA: 0x144ACD0 Offset: 0x14492D0 VA: 0x18144ACD0
	|-Enumerable.<DistinctIterator>d__68<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A990 Offset: 0x1448F90 VA: 0x18144A990
	|-Enumerable.<DistinctIterator>d__68<ServerInfo>.System.IDisposable.Dispose
	|-Enumerable.<DistinctIterator>d__68<object>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D0E80 Offset: 0x19CF480 VA: 0x1819D0E80
	|-Enumerable.<DistinctIterator>d__68<ServerInfo>.MoveNext
	|
	|-RVA: 0x19D0C30 Offset: 0x19CF230 VA: 0x1819D0C30
	|-Enumerable.<DistinctIterator>d__68<object>.MoveNext
	*/

	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D1590 Offset: 0x19CFB90 VA: 0x1819D1590
	|-Enumerable.<DistinctIterator>d__68<ServerInfo>.<>m__Finally1
	|
	|-RVA: 0x19D1540 Offset: 0x19CFB40 VA: 0x1819D1540
	|-Enumerable.<DistinctIterator>d__68<object>.<>m__Finally1
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDECF20 Offset: 0xDEB520 VA: 0x180DECF20
	|-Enumerable.<DistinctIterator>d__68<ServerInfo>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<DistinctIterator>d__68<object>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D1410 Offset: 0x19CFA10 VA: 0x1819D1410
	|-Enumerable.<DistinctIterator>d__68<ServerInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D1460 Offset: 0x19CFA60 VA: 0x1819D1460
	|-Enumerable.<DistinctIterator>d__68<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D14B0 Offset: 0x19CFAB0 VA: 0x1819D14B0
	|-Enumerable.<DistinctIterator>d__68<ServerInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<DistinctIterator>d__68<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D1250 Offset: 0x19CF850 VA: 0x1819D1250
	|-Enumerable.<DistinctIterator>d__68<ServerInfo>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x19D1320 Offset: 0x19CF920 VA: 0x1819D1320
	|-Enumerable.<DistinctIterator>d__68<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D13E0 Offset: 0x19CF9E0 VA: 0x1819D13E0
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
	|-RVA: 0x144AC50 Offset: 0x1449250 VA: 0x18144AC50
	|-Enumerable.<UnionIterator>d__71<char>..ctor
	|
	|-RVA: 0x144ACD0 Offset: 0x14492D0 VA: 0x18144ACD0
	|-Enumerable.<UnionIterator>d__71<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144B870 Offset: 0x1449E70 VA: 0x18144B870
	|-Enumerable.<UnionIterator>d__71<char>.System.IDisposable.Dispose
	|-Enumerable.<UnionIterator>d__71<object>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D62F0 Offset: 0x19D48F0 VA: 0x1819D62F0
	|-Enumerable.<UnionIterator>d__71<char>.MoveNext
	|
	|-RVA: 0x19D5F50 Offset: 0x19D4550 VA: 0x1819D5F50
	|-Enumerable.<UnionIterator>d__71<object>.MoveNext
	*/

	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D6900 Offset: 0x19D4F00 VA: 0x1819D6900
	|-Enumerable.<UnionIterator>d__71<char>.<>m__Finally1
	|
	|-RVA: 0x19D6950 Offset: 0x19D4F50 VA: 0x1819D6950
	|-Enumerable.<UnionIterator>d__71<object>.<>m__Finally1
	*/

	private void <>m__Finally2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D69F0 Offset: 0x19D4FF0 VA: 0x1819D69F0
	|-Enumerable.<UnionIterator>d__71<char>.<>m__Finally2
	|
	|-RVA: 0x19D69A0 Offset: 0x19D4FA0 VA: 0x1819D69A0
	|-Enumerable.<UnionIterator>d__71<object>.<>m__Finally2
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A640 Offset: 0x1448C40 VA: 0x18144A640
	|-Enumerable.<UnionIterator>d__71<char>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<UnionIterator>d__71<object>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D6860 Offset: 0x19D4E60 VA: 0x1819D6860
	|-Enumerable.<UnionIterator>d__71<char>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D6810 Offset: 0x19D4E10 VA: 0x1819D6810
	|-Enumerable.<UnionIterator>d__71<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D68B0 Offset: 0x19D4EB0 VA: 0x1819D68B0
	|-Enumerable.<UnionIterator>d__71<char>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<UnionIterator>d__71<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D6740 Offset: 0x19D4D40 VA: 0x1819D6740
	|-Enumerable.<UnionIterator>d__71<char>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x19D6670 Offset: 0x19D4C70 VA: 0x1819D6670
	|-Enumerable.<UnionIterator>d__71<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D3DD0 Offset: 0x19D23D0 VA: 0x1819D3DD0
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
	|-RVA: 0x144ACD0 Offset: 0x14492D0 VA: 0x18144ACD0
	|-Enumerable.<ExceptIterator>d__77<object>..ctor
	|
	|-RVA: 0x144AC50 Offset: 0x1449250 VA: 0x18144AC50
	|-Enumerable.<ExceptIterator>d__77<float>..ctor
	|
	|-RVA: 0x19D28E0 Offset: 0x19D0EE0 VA: 0x1819D28E0
	|-Enumerable.<ExceptIterator>d__77<Vector2>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A990 Offset: 0x1448F90 VA: 0x18144A990
	|-Enumerable.<ExceptIterator>d__77<object>.System.IDisposable.Dispose
	|-Enumerable.<ExceptIterator>d__77<float>.System.IDisposable.Dispose
	|-Enumerable.<ExceptIterator>d__77<Vector2>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D1AC0 Offset: 0x19D00C0 VA: 0x1819D1AC0
	|-Enumerable.<ExceptIterator>d__77<object>.MoveNext
	|
	|-RVA: 0x19D1F50 Offset: 0x19D0550 VA: 0x1819D1F50
	|-Enumerable.<ExceptIterator>d__77<float>.MoveNext
	|
	|-RVA: 0x19D1620 Offset: 0x19CFC20 VA: 0x1819D1620
	|-Enumerable.<ExceptIterator>d__77<Vector2>.MoveNext
	*/

	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D2890 Offset: 0x19D0E90 VA: 0x1819D2890
	|-Enumerable.<ExceptIterator>d__77<object>.<>m__Finally1
	|
	|-RVA: 0x19D2840 Offset: 0x19D0E40 VA: 0x1819D2840
	|-Enumerable.<ExceptIterator>d__77<float>.<>m__Finally1
	|
	|-RVA: 0x19D27F0 Offset: 0x19D0DF0 VA: 0x1819D27F0
	|-Enumerable.<ExceptIterator>d__77<Vector2>.<>m__Finally1
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<ExceptIterator>d__77<object>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0xE73B80 Offset: 0xE72180 VA: 0x180E73B80
	|-Enumerable.<ExceptIterator>d__77<float>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x19D2640 Offset: 0x19D0C40 VA: 0x1819D2640
	|-Enumerable.<ExceptIterator>d__77<Vector2>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D26B0 Offset: 0x19D0CB0 VA: 0x1819D26B0
	|-Enumerable.<ExceptIterator>d__77<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D2700 Offset: 0x19D0D00 VA: 0x1819D2700
	|-Enumerable.<ExceptIterator>d__77<float>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D2660 Offset: 0x19D0C60 VA: 0x1819D2660
	|-Enumerable.<ExceptIterator>d__77<Vector2>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<ExceptIterator>d__77<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D2750 Offset: 0x19D0D50 VA: 0x1819D2750
	|-Enumerable.<ExceptIterator>d__77<float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D27A0 Offset: 0x19D0DA0 VA: 0x1819D27A0
	|-Enumerable.<ExceptIterator>d__77<Vector2>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D2570 Offset: 0x19D0B70 VA: 0x1819D2570
	|-Enumerable.<ExceptIterator>d__77<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x19D24A0 Offset: 0x19D0AA0 VA: 0x1819D24A0
	|-Enumerable.<ExceptIterator>d__77<float>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x19D23D0 Offset: 0x19D09D0 VA: 0x1819D23D0
	|-Enumerable.<ExceptIterator>d__77<Vector2>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D13E0 Offset: 0x19CF9E0 VA: 0x1819D13E0
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
	|-RVA: 0x144AC50 Offset: 0x1449250 VA: 0x18144AC50
	|-Enumerable.<ReverseIterator>d__79<char>..ctor
	|
	|-RVA: 0x144ACD0 Offset: 0x14492D0 VA: 0x18144ACD0
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
	|-RVA: 0x19D2C80 Offset: 0x19D1280 VA: 0x1819D2C80
	|-Enumerable.<ReverseIterator>d__79<char>.MoveNext
	|
	|-RVA: 0x19D2D40 Offset: 0x19D1340 VA: 0x1819D2D40
	|-Enumerable.<ReverseIterator>d__79<long>.MoveNext
	|
	|-RVA: 0x19D2BC0 Offset: 0x19D11C0 VA: 0x1819D2BC0
	|-Enumerable.<ReverseIterator>d__79<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A640 Offset: 0x1448C40 VA: 0x18144A640
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
	|-RVA: 0x19D2EA0 Offset: 0x19D14A0 VA: 0x1819D2EA0
	|-Enumerable.<ReverseIterator>d__79<char>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D2E50 Offset: 0x19D1450 VA: 0x1819D2E50
	|-Enumerable.<ReverseIterator>d__79<long>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D2E00 Offset: 0x19D1400 VA: 0x1819D2E00
	|-Enumerable.<ReverseIterator>d__79<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D2F40 Offset: 0x19D1540 VA: 0x1819D2F40
	|-Enumerable.<ReverseIterator>d__79<char>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D2EF0 Offset: 0x19D14F0 VA: 0x1819D2EF0
	|-Enumerable.<ReverseIterator>d__79<long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<ReverseIterator>d__79<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A590 Offset: 0x1448B90 VA: 0x18144A590
	|-Enumerable.<ReverseIterator>d__79<char>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x144A4E0 Offset: 0x1448AE0 VA: 0x18144A4E0
	|-Enumerable.<ReverseIterator>d__79<long>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|-Enumerable.<ReverseIterator>d__79<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A650 Offset: 0x1448C50 VA: 0x18144A650
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
	|-RVA: 0x144ACD0 Offset: 0x14492D0 VA: 0x18144ACD0
	|-Enumerable.<OfTypeIterator>d__97<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A990 Offset: 0x1448F90 VA: 0x18144A990
	|-Enumerable.<OfTypeIterator>d__97<object>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D2920 Offset: 0x19D0F20 VA: 0x1819D2920
	|-Enumerable.<OfTypeIterator>d__97<object>.MoveNext
	*/

	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D2B60 Offset: 0x19D1160 VA: 0x1819D2B60
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
	|-RVA: 0x19D2B10 Offset: 0x19D1110 VA: 0x1819D2B10
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
	|-RVA: 0x144A4E0 Offset: 0x1448AE0 VA: 0x18144A4E0
	|-Enumerable.<OfTypeIterator>d__97<object>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A650 Offset: 0x1448C50 VA: 0x18144A650
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
	|-RVA: 0x144AC50 Offset: 0x1449250 VA: 0x18144AC50
	|-Enumerable.<CastIterator>d__99<bool>..ctor
	|-Enumerable.<CastIterator>d__99<byte>..ctor
	|-Enumerable.<CastIterator>d__99<short>..ctor
	|-Enumerable.<CastIterator>d__99<int>..ctor
	|
	|-RVA: 0x144AC90 Offset: 0x1449290 VA: 0x18144AC90
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>..ctor
	|
	|-RVA: 0x144ACD0 Offset: 0x14492D0 VA: 0x18144ACD0
	|-Enumerable.<CastIterator>d__99<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A990 Offset: 0x1448F90 VA: 0x18144A990
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
	|-RVA: 0x144A270 Offset: 0x1448870 VA: 0x18144A270
	|-Enumerable.<CastIterator>d__99<bool>.MoveNext
	|
	|-RVA: 0x14499A0 Offset: 0x1447FA0 VA: 0x1814499A0
	|-Enumerable.<CastIterator>d__99<byte>.MoveNext
	|
	|-RVA: 0x1449B60 Offset: 0x1448160 VA: 0x181449B60
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>.MoveNext
	|
	|-RVA: 0x144A0B0 Offset: 0x14486B0 VA: 0x18144A0B0
	|-Enumerable.<CastIterator>d__99<short>.MoveNext
	|
	|-RVA: 0x1449D30 Offset: 0x1448330 VA: 0x181449D30
	|-Enumerable.<CastIterator>d__99<int>.MoveNext
	|
	|-RVA: 0x1449EF0 Offset: 0x14484F0 VA: 0x181449EF0
	|-Enumerable.<CastIterator>d__99<object>.MoveNext
	*/

	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144ABF0 Offset: 0x14491F0 VA: 0x18144ABF0
	|-Enumerable.<CastIterator>d__99<bool>.<>m__Finally1
	|
	|-RVA: 0x144AA10 Offset: 0x1449010 VA: 0x18144AA10
	|-Enumerable.<CastIterator>d__99<byte>.<>m__Finally1
	|
	|-RVA: 0x144AAD0 Offset: 0x14490D0 VA: 0x18144AAD0
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>.<>m__Finally1
	|
	|-RVA: 0x144AB90 Offset: 0x1449190 VA: 0x18144AB90
	|-Enumerable.<CastIterator>d__99<short>.<>m__Finally1
	|
	|-RVA: 0x144AA70 Offset: 0x1449070 VA: 0x18144AA70
	|-Enumerable.<CastIterator>d__99<int>.<>m__Finally1
	|
	|-RVA: 0x144AB30 Offset: 0x1449130 VA: 0x18144AB30
	|-Enumerable.<CastIterator>d__99<object>.<>m__Finally1
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA116B0 Offset: 0xA0FCB0 VA: 0x180A116B0
	|-Enumerable.<CastIterator>d__99<bool>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|-Enumerable.<CastIterator>d__99<byte>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0xB11AC0 Offset: 0xB100C0 VA: 0x180B11AC0
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0x144A640 Offset: 0x1448C40 VA: 0x18144A640
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
	|-RVA: 0x144A720 Offset: 0x1448D20 VA: 0x18144A720
	|-Enumerable.<CastIterator>d__99<bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x144A7C0 Offset: 0x1448DC0 VA: 0x18144A7C0
	|-Enumerable.<CastIterator>d__99<byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x144A680 Offset: 0x1448C80 VA: 0x18144A680
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x144A770 Offset: 0x1448D70 VA: 0x18144A770
	|-Enumerable.<CastIterator>d__99<short>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x144A6D0 Offset: 0x1448CD0 VA: 0x18144A6D0
	|-Enumerable.<CastIterator>d__99<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x144A810 Offset: 0x1448E10 VA: 0x18144A810
	|-Enumerable.<CastIterator>d__99<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A860 Offset: 0x1448E60 VA: 0x18144A860
	|-Enumerable.<CastIterator>d__99<bool>.System.Collections.IEnumerator.get_Current
	|-Enumerable.<CastIterator>d__99<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x144A900 Offset: 0x1448F00 VA: 0x18144A900
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x144A8B0 Offset: 0x1448EB0 VA: 0x18144A8B0
	|-Enumerable.<CastIterator>d__99<short>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x144A950 Offset: 0x1448F50 VA: 0x18144A950
	|-Enumerable.<CastIterator>d__99<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<CastIterator>d__99<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A590 Offset: 0x1448B90 VA: 0x18144A590
	|-Enumerable.<CastIterator>d__99<bool>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|-Enumerable.<CastIterator>d__99<byte>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|-Enumerable.<CastIterator>d__99<short>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|-Enumerable.<CastIterator>d__99<int>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0x144A430 Offset: 0x1448A30 VA: 0x18144A430
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0x144A4E0 Offset: 0x1448AE0 VA: 0x18144A4E0
	|-Enumerable.<CastIterator>d__99<object>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A650 Offset: 0x1448C50 VA: 0x18144A650
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
	|-RVA: 0x178F410 Offset: 0x178DA10 VA: 0x18178F410
	|-EnumerableSorter<Demos.DemoInfo>.Sort
	|
	|-RVA: 0x178F4F0 Offset: 0x178DAF0 VA: 0x18178F4F0
	|-EnumerableSorter<ServerInfo>.Sort
	|
	|-RVA: 0x178FB10 Offset: 0x178E110 VA: 0x18178FB10
	|-EnumerableSorter<Item>.Sort
	|
	|-RVA: 0x178FA30 Offset: 0x178E030 VA: 0x18178FA30
	|-EnumerableSorter<KeyValuePair<object, int>>.Sort
	|
	|-RVA: 0x178F5D0 Offset: 0x178DBD0 VA: 0x18178F5D0
	|-EnumerableSorter<KeyValuePair<object, long>>.Sort
	|
	|-RVA: 0x178F950 Offset: 0x178DF50 VA: 0x18178F950
	|-EnumerableSorter<KeyValuePair<object, object>>.Sort
	|
	|-RVA: 0x178F6B0 Offset: 0x178DCB0 VA: 0x18178F6B0
	|-EnumerableSorter<double>.Sort
	|
	|-RVA: 0x178F790 Offset: 0x178DD90 VA: 0x18178F790
	|-EnumerableSorter<object>.Sort
	|
	|-RVA: 0x178F870 Offset: 0x178DE70 VA: 0x18178F870
	|-EnumerableSorter<Resolution>.Sort
	*/

	private void QuickSort(int[] map, int left, int right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178F1F0 Offset: 0x178D7F0 VA: 0x18178F1F0
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
	|-RVA: 0xD5BBD0 Offset: 0xD5A1D0 VA: 0x180D5BBD0
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
	|-RVA: 0x175ECD0 Offset: 0x175D2D0 VA: 0x18175ECD0
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
	|-RVA: 0x178FD00 Offset: 0x178E300 VA: 0x18178FD00
	|-EnumerableSorter<Demos.DemoInfo, DateTime>.ComputeKeys
	|-EnumerableSorter<Demos.DemoInfo, TimeSpan>.ComputeKeys
	|
	|-RVA: 0x178FE50 Offset: 0x178E450 VA: 0x18178FE50
	|-EnumerableSorter<Demos.DemoInfo, object>.ComputeKeys
	|
	|-RVA: 0x1790360 Offset: 0x178E960 VA: 0x181790360
	|-EnumerableSorter<ServerInfo, int>.ComputeKeys
	|-EnumerableSorter<ServerInfo, uint>.ComputeKeys
	|
	|-RVA: 0x178FFB0 Offset: 0x178E5B0 VA: 0x18178FFB0
	|-EnumerableSorter<ServerInfo, object>.ComputeKeys
	|
	|-RVA: 0x1790170 Offset: 0x178E770 VA: 0x181790170
	|-EnumerableSorter<Item, DateTime>.ComputeKeys
	|
	|-RVA: 0x175E370 Offset: 0x175C970 VA: 0x18175E370
	|-EnumerableSorter<KeyValuePair<object, int>, int>.ComputeKeys
	|
	|-RVA: 0x175E820 Offset: 0x175CE20 VA: 0x18175E820
	|-EnumerableSorter<KeyValuePair<object, long>, long>.ComputeKeys
	|-EnumerableSorter<KeyValuePair<object, object>, long>.ComputeKeys
	|
	|-RVA: 0x175E700 Offset: 0x175CD00 VA: 0x18175E700
	|-EnumerableSorter<double, double>.ComputeKeys
	|
	|-RVA: 0x175EA90 Offset: 0x175D090 VA: 0x18175EA90
	|-EnumerableSorter<object, bool>.ComputeKeys
	|
	|-RVA: 0x175EBB0 Offset: 0x175D1B0 VA: 0x18175EBB0
	|-EnumerableSorter<object, DateTime>.ComputeKeys
	|
	|-RVA: 0x175E120 Offset: 0x175C720 VA: 0x18175E120
	|-EnumerableSorter<object, DateTimeOffset>.ComputeKeys
	|-EnumerableSorter<object, Guid>.ComputeKeys
	|
	|-RVA: 0x175E4A0 Offset: 0x175CAA0 VA: 0x18175E4A0
	|-EnumerableSorter<object, int>.ComputeKeys
	|-EnumerableSorter<object, Int32Enum>.ComputeKeys
	|-EnumerableSorter<object, uint>.ComputeKeys
	|
	|-RVA: 0x175E960 Offset: 0x175CF60 VA: 0x18175E960
	|-EnumerableSorter<object, object>.ComputeKeys
	|
	|-RVA: 0x175E250 Offset: 0x175C850 VA: 0x18175E250
	|-EnumerableSorter<object, float>.ComputeKeys
	|
	|-RVA: 0x175E5C0 Offset: 0x175CBC0 VA: 0x18175E5C0
	|-EnumerableSorter<Resolution, int>.ComputeKeys
	*/

	internal override int CompareKeys(int index1, int index2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178FBF0 Offset: 0x178E1F0 VA: 0x18178FBF0
	|-EnumerableSorter<Demos.DemoInfo, DateTime>.CompareKeys
	|-EnumerableSorter<Item, DateTime>.CompareKeys
	|
	|-RVA: 0x175D7A0 Offset: 0x175BDA0 VA: 0x18175D7A0
	|-EnumerableSorter<Demos.DemoInfo, object>.CompareKeys
	|-EnumerableSorter<ServerInfo, object>.CompareKeys
	|-EnumerableSorter<KeyValuePair<object, long>, long>.CompareKeys
	|-EnumerableSorter<KeyValuePair<object, object>, long>.CompareKeys
	|
	|-RVA: 0x175DCD0 Offset: 0x175C2D0 VA: 0x18175DCD0
	|-EnumerableSorter<Demos.DemoInfo, TimeSpan>.CompareKeys
	|-EnumerableSorter<object, DateTime>.CompareKeys
	|
	|-RVA: 0x175DE40 Offset: 0x175C440 VA: 0x18175DE40
	|-EnumerableSorter<ServerInfo, int>.CompareKeys
	|-EnumerableSorter<ServerInfo, uint>.CompareKeys
	|-EnumerableSorter<object, uint>.CompareKeys
	|
	|-RVA: 0x175DA40 Offset: 0x175C040 VA: 0x18175DA40
	|-EnumerableSorter<KeyValuePair<object, int>, int>.CompareKeys
	|-EnumerableSorter<object, int>.CompareKeys
	|-EnumerableSorter<object, Int32Enum>.CompareKeys
	|-EnumerableSorter<Resolution, int>.CompareKeys
	|
	|-RVA: 0x175DB50 Offset: 0x175C150 VA: 0x18175DB50
	|-EnumerableSorter<double, double>.CompareKeys
	|
	|-RVA: 0x175D630 Offset: 0x175BC30 VA: 0x18175D630
	|-EnumerableSorter<object, bool>.CompareKeys
	|
	|-RVA: 0x175D8B0 Offset: 0x175BEB0 VA: 0x18175D8B0
	|-EnumerableSorter<object, DateTimeOffset>.CompareKeys
	|-EnumerableSorter<object, Guid>.CompareKeys
	|
	|-RVA: 0x175D4D0 Offset: 0x175BAD0 VA: 0x18175D4D0
	|-EnumerableSorter<object, object>.CompareKeys
	|
	|-RVA: 0x175DFA0 Offset: 0x175C5A0 VA: 0x18175DFA0
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

