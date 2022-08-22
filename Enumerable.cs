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
	|-RVA: 0xBEF470 Offset: 0xBEDA70 VA: 0x180BEF470
	|-Enum.TryParse<Int32Enum>
	|-Enum.TryParse<KeyCode>
	*/

	public static bool TryParse<TEnum>(string value, bool ignoreCase, out TEnum result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEF4F0 Offset: 0xBEDAF0 VA: 0x180BEF4F0
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
	|-RVA: 0x1A372A0 Offset: 0x1A358A0 VA: 0x181A372A0
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
	|-RVA: 0x1A37370 Offset: 0x1A35970 VA: 0x181A37370
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
	|-RVA: 0x1A37440 Offset: 0x1A35A40 VA: 0x181A37440
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
	|-RVA: 0x1A37510 Offset: 0x1A35B10 VA: 0x181A37510
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
	|-RVA: 0x1A376B0 Offset: 0x1A35CB0 VA: 0x181A376B0
	|-EnumHelper<byte>.Cast<EmptyStruct>
	|-EnumHelper<short>.Cast<EmptyStruct>
	|-EnumHelper<int>.Cast<EmptyStruct>
	|-EnumHelper<long>.Cast<EmptyStruct>
	|-EnumHelper<sbyte>.Cast<EmptyStruct>
	|-EnumHelper<ushort>.Cast<EmptyStruct>
	|-EnumHelper<uint>.Cast<EmptyStruct>
	|-EnumHelper<ulong>.Cast<EmptyStruct>
	|
	|-RVA: 0x1A375E0 Offset: 0x1A35BE0 VA: 0x181A375E0
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
	|-RVA: 0x1A37780 Offset: 0x1A35D80 VA: 0x181A37780
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
	|-RVA: 0x1A37850 Offset: 0x1A35E50 VA: 0x181A37850
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
	|-RVA: 0x2133C90 Offset: 0x2132290 VA: 0x182133C90
	|-EnumHelper<byte>..cctor
	|
	|-RVA: 0x2133790 Offset: 0x2131D90 VA: 0x182133790
	|-EnumHelper<short>..cctor
	|
	|-RVA: 0x2133890 Offset: 0x2131E90 VA: 0x182133890
	|-EnumHelper<int>..cctor
	|
	|-RVA: 0x2133990 Offset: 0x2131F90 VA: 0x182133990
	|-EnumHelper<long>..cctor
	|
	|-RVA: 0x2133A90 Offset: 0x2132090 VA: 0x182133A90
	|-EnumHelper<object>..cctor
	|
	|-RVA: 0x2133E90 Offset: 0x2132490 VA: 0x182133E90
	|-EnumHelper<sbyte>..cctor
	|
	|-RVA: 0x2133D90 Offset: 0x2132390 VA: 0x182133D90
	|-EnumHelper<ushort>..cctor
	|
	|-RVA: 0x2133690 Offset: 0x2131C90 VA: 0x182133690
	|-EnumHelper<uint>..cctor
	|
	|-RVA: 0x2133B90 Offset: 0x2132190 VA: 0x182133B90
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
	|-RVA: 0x18A31F0 Offset: 0x18A17F0 VA: 0x1818A31F0
	|-EnumHelper.Transformer<byte, bool>.Invoke
	|-EnumHelper.Transformer<byte, byte>.Invoke
	|-EnumHelper.Transformer<byte, sbyte>.Invoke
	|-EnumHelper.Transformer<sbyte, bool>.Invoke
	|-EnumHelper.Transformer<sbyte, byte>.Invoke
	|-EnumHelper.Transformer<sbyte, sbyte>.Invoke
	|
	|-RVA: 0x18A5B30 Offset: 0x18A4130 VA: 0x1818A5B30
	|-EnumHelper.Transformer<byte, char>.Invoke
	|-EnumHelper.Transformer<byte, short>.Invoke
	|-EnumHelper.Transformer<byte, ushort>.Invoke
	|-EnumHelper.Transformer<sbyte, char>.Invoke
	|-EnumHelper.Transformer<sbyte, short>.Invoke
	|-EnumHelper.Transformer<sbyte, ushort>.Invoke
	|
	|-RVA: 0x16D03A0 Offset: 0x16CE9A0 VA: 0x1816D03A0
	|-EnumHelper.Transformer<byte, KeyValuePair<object, object>>.Invoke
	|-EnumHelper.Transformer<byte, DateTimeOffset>.Invoke
	|-EnumHelper.Transformer<byte, Decimal>.Invoke
	|-EnumHelper.Transformer<byte, Guid>.Invoke
	|-EnumHelper.Transformer<sbyte, KeyValuePair<object, object>>.Invoke
	|-EnumHelper.Transformer<sbyte, DateTimeOffset>.Invoke
	|-EnumHelper.Transformer<sbyte, Decimal>.Invoke
	|-EnumHelper.Transformer<sbyte, Guid>.Invoke
	|
	|-RVA: 0x16D06E0 Offset: 0x16CECE0 VA: 0x1816D06E0
	|-EnumHelper.Transformer<byte, DateTime>.Invoke
	|-EnumHelper.Transformer<byte, TimeSpan>.Invoke
	|-EnumHelper.Transformer<sbyte, DateTime>.Invoke
	|-EnumHelper.Transformer<sbyte, TimeSpan>.Invoke
	|
	|-RVA: 0x18A7AB0 Offset: 0x18A60B0 VA: 0x1818A7AB0
	|-EnumHelper.Transformer<byte, EmptyStruct>.Invoke
	|-EnumHelper.Transformer<sbyte, EmptyStruct>.Invoke
	|
	|-RVA: 0x18A6670 Offset: 0x18A4C70 VA: 0x1818A6670
	|-EnumHelper.Transformer<byte, double>.Invoke
	|-EnumHelper.Transformer<sbyte, double>.Invoke
	|
	|-RVA: 0x146D1D0 Offset: 0x146B7D0 VA: 0x18146D1D0
	|-EnumHelper.Transformer<byte, int>.Invoke
	|-EnumHelper.Transformer<byte, uint>.Invoke
	|-EnumHelper.Transformer<sbyte, int>.Invoke
	|-EnumHelper.Transformer<sbyte, uint>.Invoke
	|
	|-RVA: 0x1B17000 Offset: 0x1B15600 VA: 0x181B17000
	|-EnumHelper.Transformer<byte, long>.Invoke
	|-EnumHelper.Transformer<byte, IntPtr>.Invoke
	|-EnumHelper.Transformer<byte, ulong>.Invoke
	|-EnumHelper.Transformer<byte, UIntPtr>.Invoke
	|-EnumHelper.Transformer<sbyte, long>.Invoke
	|-EnumHelper.Transformer<sbyte, IntPtr>.Invoke
	|-EnumHelper.Transformer<sbyte, ulong>.Invoke
	|-EnumHelper.Transformer<sbyte, UIntPtr>.Invoke
	|
	|-RVA: 0x1783E60 Offset: 0x1782460 VA: 0x181783E60
	|-EnumHelper.Transformer<byte, object>.Invoke
	|-EnumHelper.Transformer<sbyte, object>.Invoke
	|
	|-RVA: 0x18A41B0 Offset: 0x18A27B0 VA: 0x1818A41B0
	|-EnumHelper.Transformer<byte, float>.Invoke
	|-EnumHelper.Transformer<sbyte, float>.Invoke
	|
	|-RVA: 0x1B177F0 Offset: 0x1B15DF0 VA: 0x181B177F0
	|-EnumHelper.Transformer<short, bool>.Invoke
	|-EnumHelper.Transformer<short, byte>.Invoke
	|-EnumHelper.Transformer<short, sbyte>.Invoke
	|-EnumHelper.Transformer<ushort, bool>.Invoke
	|-EnumHelper.Transformer<ushort, byte>.Invoke
	|-EnumHelper.Transformer<ushort, sbyte>.Invoke
	|
	|-RVA: 0x1B19700 Offset: 0x1B17D00 VA: 0x181B19700
	|-EnumHelper.Transformer<short, char>.Invoke
	|-EnumHelper.Transformer<short, short>.Invoke
	|-EnumHelper.Transformer<short, ushort>.Invoke
	|-EnumHelper.Transformer<ushort, char>.Invoke
	|-EnumHelper.Transformer<ushort, short>.Invoke
	|-EnumHelper.Transformer<ushort, ushort>.Invoke
	|
	|-RVA: 0x1B18DC0 Offset: 0x1B173C0 VA: 0x181B18DC0
	|-EnumHelper.Transformer<short, KeyValuePair<object, object>>.Invoke
	|-EnumHelper.Transformer<short, DateTimeOffset>.Invoke
	|-EnumHelper.Transformer<short, Decimal>.Invoke
	|-EnumHelper.Transformer<short, Guid>.Invoke
	|-EnumHelper.Transformer<ushort, KeyValuePair<object, object>>.Invoke
	|-EnumHelper.Transformer<ushort, DateTimeOffset>.Invoke
	|-EnumHelper.Transformer<ushort, Decimal>.Invoke
	|-EnumHelper.Transformer<ushort, Guid>.Invoke
	|
	|-RVA: 0x1B19100 Offset: 0x1B17700 VA: 0x181B19100
	|-EnumHelper.Transformer<short, DateTime>.Invoke
	|-EnumHelper.Transformer<short, TimeSpan>.Invoke
	|-EnumHelper.Transformer<ushort, DateTime>.Invoke
	|-EnumHelper.Transformer<ushort, TimeSpan>.Invoke
	|
	|-RVA: 0x1B1A010 Offset: 0x1B18610 VA: 0x181B1A010
	|-EnumHelper.Transformer<short, EmptyStruct>.Invoke
	|-EnumHelper.Transformer<ushort, EmptyStruct>.Invoke
	|
	|-RVA: 0x1B16AF0 Offset: 0x1B150F0 VA: 0x181B16AF0
	|-EnumHelper.Transformer<short, double>.Invoke
	|-EnumHelper.Transformer<ushort, double>.Invoke
	|
	|-RVA: 0x1B16040 Offset: 0x1B14640 VA: 0x181B16040
	|-EnumHelper.Transformer<short, int>.Invoke
	|-EnumHelper.Transformer<short, uint>.Invoke
	|-EnumHelper.Transformer<ushort, int>.Invoke
	|-EnumHelper.Transformer<ushort, uint>.Invoke
	|
	|-RVA: 0x1B17E30 Offset: 0x1B16430 VA: 0x181B17E30
	|-EnumHelper.Transformer<short, long>.Invoke
	|-EnumHelper.Transformer<short, IntPtr>.Invoke
	|-EnumHelper.Transformer<short, ulong>.Invoke
	|-EnumHelper.Transformer<short, UIntPtr>.Invoke
	|-EnumHelper.Transformer<ushort, long>.Invoke
	|-EnumHelper.Transformer<ushort, IntPtr>.Invoke
	|-EnumHelper.Transformer<ushort, ulong>.Invoke
	|-EnumHelper.Transformer<ushort, UIntPtr>.Invoke
	|
	|-RVA: 0x1B18630 Offset: 0x1B16C30 VA: 0x181B18630
	|-EnumHelper.Transformer<short, object>.Invoke
	|-EnumHelper.Transformer<ushort, object>.Invoke
	|
	|-RVA: 0x1B1A310 Offset: 0x1B18910 VA: 0x181B1A310
	|-EnumHelper.Transformer<short, float>.Invoke
	|-EnumHelper.Transformer<ushort, float>.Invoke
	|
	|-RVA: 0x1B18AC0 Offset: 0x1B170C0 VA: 0x181B18AC0
	|-EnumHelper.Transformer<int, bool>.Invoke
	|-EnumHelper.Transformer<int, byte>.Invoke
	|-EnumHelper.Transformer<int, sbyte>.Invoke
	|-EnumHelper.Transformer<uint, bool>.Invoke
	|-EnumHelper.Transformer<uint, byte>.Invoke
	|-EnumHelper.Transformer<uint, sbyte>.Invoke
	|
	|-RVA: 0x1B18330 Offset: 0x1B16930 VA: 0x181B18330
	|-EnumHelper.Transformer<int, char>.Invoke
	|-EnumHelper.Transformer<int, short>.Invoke
	|-EnumHelper.Transformer<int, ushort>.Invoke
	|-EnumHelper.Transformer<uint, char>.Invoke
	|-EnumHelper.Transformer<uint, short>.Invoke
	|-EnumHelper.Transformer<uint, ushort>.Invoke
	|
	|-RVA: 0x1B17AF0 Offset: 0x1B160F0 VA: 0x181B17AF0
	|-EnumHelper.Transformer<int, KeyValuePair<object, object>>.Invoke
	|-EnumHelper.Transformer<int, DateTimeOffset>.Invoke
	|-EnumHelper.Transformer<int, Decimal>.Invoke
	|-EnumHelper.Transformer<int, Guid>.Invoke
	|-EnumHelper.Transformer<uint, KeyValuePair<object, object>>.Invoke
	|-EnumHelper.Transformer<uint, DateTimeOffset>.Invoke
	|-EnumHelper.Transformer<uint, Decimal>.Invoke
	|-EnumHelper.Transformer<uint, Guid>.Invoke
	|
	|-RVA: 0x1B19400 Offset: 0x1B17A00 VA: 0x181B19400
	|-EnumHelper.Transformer<int, DateTime>.Invoke
	|-EnumHelper.Transformer<int, TimeSpan>.Invoke
	|-EnumHelper.Transformer<uint, DateTime>.Invoke
	|-EnumHelper.Transformer<uint, TimeSpan>.Invoke
	|
	|-RVA: 0x1B19A00 Offset: 0x1B18000 VA: 0x181B19A00
	|-EnumHelper.Transformer<int, EmptyStruct>.Invoke
	|-EnumHelper.Transformer<uint, EmptyStruct>.Invoke
	|
	|-RVA: 0x1B19D00 Offset: 0x1B18300 VA: 0x181B19D00
	|-EnumHelper.Transformer<int, double>.Invoke
	|-EnumHelper.Transformer<uint, double>.Invoke
	|
	|-RVA: 0x19E7E40 Offset: 0x19E6440 VA: 0x1819E7E40
	|-EnumHelper.Transformer<int, int>.Invoke
	|-EnumHelper.Transformer<int, uint>.Invoke
	|-EnumHelper.Transformer<uint, int>.Invoke
	|-EnumHelper.Transformer<uint, uint>.Invoke
	|
	|-RVA: 0x1B16E00 Offset: 0x1B15400 VA: 0x181B16E00
	|-EnumHelper.Transformer<int, long>.Invoke
	|-EnumHelper.Transformer<int, IntPtr>.Invoke
	|-EnumHelper.Transformer<int, ulong>.Invoke
	|-EnumHelper.Transformer<int, UIntPtr>.Invoke
	|-EnumHelper.Transformer<uint, long>.Invoke
	|-EnumHelper.Transformer<uint, IntPtr>.Invoke
	|-EnumHelper.Transformer<uint, ulong>.Invoke
	|-EnumHelper.Transformer<uint, UIntPtr>.Invoke
	|
	|-RVA: 0x1B16670 Offset: 0x1B14C70 VA: 0x181B16670
	|-EnumHelper.Transformer<int, object>.Invoke
	|-EnumHelper.Transformer<uint, object>.Invoke
	|
	|-RVA: 0x1B17500 Offset: 0x1B15B00 VA: 0x181B17500
	|-EnumHelper.Transformer<int, float>.Invoke
	|-EnumHelper.Transformer<uint, float>.Invoke
	|
	|-RVA: 0x1B18030 Offset: 0x1B16630 VA: 0x181B18030
	|-EnumHelper.Transformer<long, bool>.Invoke
	|-EnumHelper.Transformer<long, byte>.Invoke
	|-EnumHelper.Transformer<long, sbyte>.Invoke
	|-EnumHelper.Transformer<ulong, bool>.Invoke
	|-EnumHelper.Transformer<ulong, byte>.Invoke
	|-EnumHelper.Transformer<ulong, sbyte>.Invoke
	|
	|-RVA: 0x1B17200 Offset: 0x1B15800 VA: 0x181B17200
	|-EnumHelper.Transformer<long, char>.Invoke
	|-EnumHelper.Transformer<long, short>.Invoke
	|-EnumHelper.Transformer<long, ushort>.Invoke
	|-EnumHelper.Transformer<ulong, char>.Invoke
	|-EnumHelper.Transformer<ulong, short>.Invoke
	|-EnumHelper.Transformer<ulong, ushort>.Invoke
	|
	|-RVA: 0x1B16330 Offset: 0x1B14930 VA: 0x181B16330
	|-EnumHelper.Transformer<long, KeyValuePair<object, object>>.Invoke
	|-EnumHelper.Transformer<long, DateTimeOffset>.Invoke
	|-EnumHelper.Transformer<long, Decimal>.Invoke
	|-EnumHelper.Transformer<long, Guid>.Invoke
	|-EnumHelper.Transformer<ulong, KeyValuePair<object, object>>.Invoke
	|-EnumHelper.Transformer<ulong, DateTimeOffset>.Invoke
	|-EnumHelper.Transformer<ulong, Decimal>.Invoke
	|-EnumHelper.Transformer<ulong, Guid>.Invoke
	|
	|-RVA: 0x19EA810 Offset: 0x19E8E10 VA: 0x1819EA810
	|-EnumHelper.Transformer<long, DateTime>.Invoke
	|-EnumHelper.Transformer<long, TimeSpan>.Invoke
	|-EnumHelper.Transformer<ulong, DateTime>.Invoke
	|-EnumHelper.Transformer<ulong, TimeSpan>.Invoke
	|
	|-RVA: 0x1B96260 Offset: 0x1B94860 VA: 0x181B96260
	|-EnumHelper.Transformer<long, EmptyStruct>.Invoke
	|-EnumHelper.Transformer<ulong, EmptyStruct>.Invoke
	|
	|-RVA: 0x20C8450 Offset: 0x20C6A50 VA: 0x1820C8450
	|-EnumHelper.Transformer<long, double>.Invoke
	|-EnumHelper.Transformer<ulong, double>.Invoke
	|
	|-RVA: 0x20C8160 Offset: 0x20C6760 VA: 0x1820C8160
	|-EnumHelper.Transformer<long, int>.Invoke
	|-EnumHelper.Transformer<long, uint>.Invoke
	|-EnumHelper.Transformer<ulong, int>.Invoke
	|-EnumHelper.Transformer<ulong, uint>.Invoke
	|
	|-RVA: 0x20C8760 Offset: 0x20C6D60 VA: 0x1820C8760
	|-EnumHelper.Transformer<long, long>.Invoke
	|-EnumHelper.Transformer<long, IntPtr>.Invoke
	|-EnumHelper.Transformer<long, ulong>.Invoke
	|-EnumHelper.Transformer<long, UIntPtr>.Invoke
	|-EnumHelper.Transformer<ulong, long>.Invoke
	|-EnumHelper.Transformer<ulong, IntPtr>.Invoke
	|-EnumHelper.Transformer<ulong, ulong>.Invoke
	|-EnumHelper.Transformer<ulong, UIntPtr>.Invoke
	|
	|-RVA: 0x133A9A0 Offset: 0x1338FA0 VA: 0x18133A9A0
	|-EnumHelper.Transformer<long, object>.Invoke
	|-EnumHelper.Transformer<object, object>.Invoke
	|-EnumHelper.Transformer<ulong, object>.Invoke
	|
	|-RVA: 0x20C8960 Offset: 0x20C6F60 VA: 0x1820C8960
	|-EnumHelper.Transformer<long, float>.Invoke
	|-EnumHelper.Transformer<ulong, float>.Invoke
	*/

	public virtual IAsyncResult BeginInvoke(ValueType value, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B14D40 Offset: 0x1B13340 VA: 0x181B14D40
	|-EnumHelper.Transformer<byte, bool>.BeginInvoke
	|
	|-RVA: 0x1B13F40 Offset: 0x1B12540 VA: 0x181B13F40
	|-EnumHelper.Transformer<byte, byte>.BeginInvoke
	|
	|-RVA: 0x1B15440 Offset: 0x1B13A40 VA: 0x181B15440
	|-EnumHelper.Transformer<byte, char>.BeginInvoke
	|
	|-RVA: 0x1B15DC0 Offset: 0x1B143C0 VA: 0x181B15DC0
	|-EnumHelper.Transformer<byte, KeyValuePair<object, object>>.BeginInvoke
	|
	|-RVA: 0x1B15F40 Offset: 0x1B14540 VA: 0x181B15F40
	|-EnumHelper.Transformer<byte, DateTime>.BeginInvoke
	|
	|-RVA: 0x1B15EC0 Offset: 0x1B144C0 VA: 0x181B15EC0
	|-EnumHelper.Transformer<byte, DateTimeOffset>.BeginInvoke
	|
	|-RVA: 0x1B159C0 Offset: 0x1B13FC0 VA: 0x181B159C0
	|-EnumHelper.Transformer<byte, Decimal>.BeginInvoke
	|
	|-RVA: 0x1B14F40 Offset: 0x1B13540 VA: 0x181B14F40
	|-EnumHelper.Transformer<byte, EmptyStruct>.BeginInvoke
	|
	|-RVA: 0x1B15AC0 Offset: 0x1B140C0 VA: 0x181B15AC0
	|-EnumHelper.Transformer<byte, double>.BeginInvoke
	|
	|-RVA: 0x1B146C0 Offset: 0x1B12CC0 VA: 0x181B146C0
	|-EnumHelper.Transformer<byte, Guid>.BeginInvoke
	|
	|-RVA: 0x1B156C0 Offset: 0x1B13CC0 VA: 0x181B156C0
	|-EnumHelper.Transformer<byte, short>.BeginInvoke
	|
	|-RVA: 0x1B147C0 Offset: 0x1B12DC0 VA: 0x181B147C0
	|-EnumHelper.Transformer<byte, int>.BeginInvoke
	|
	|-RVA: 0x1B15BC0 Offset: 0x1B141C0 VA: 0x181B15BC0
	|-EnumHelper.Transformer<byte, long>.BeginInvoke
	|
	|-RVA: 0x1B14AC0 Offset: 0x1B130C0 VA: 0x181B14AC0
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
	|-RVA: 0x1B157C0 Offset: 0x1B13DC0 VA: 0x181B157C0
	|-EnumHelper.Transformer<byte, sbyte>.BeginInvoke
	|
	|-RVA: 0x1B15240 Offset: 0x1B13840 VA: 0x181B15240
	|-EnumHelper.Transformer<byte, float>.BeginInvoke
	|
	|-RVA: 0x1B15CC0 Offset: 0x1B142C0 VA: 0x181B15CC0
	|-EnumHelper.Transformer<byte, TimeSpan>.BeginInvoke
	|
	|-RVA: 0x1B140C0 Offset: 0x1B126C0 VA: 0x181B140C0
	|-EnumHelper.Transformer<byte, ushort>.BeginInvoke
	|
	|-RVA: 0x1B15840 Offset: 0x1B13E40 VA: 0x181B15840
	|-EnumHelper.Transformer<byte, uint>.BeginInvoke
	|
	|-RVA: 0x1B148C0 Offset: 0x1B12EC0 VA: 0x181B148C0
	|-EnumHelper.Transformer<byte, ulong>.BeginInvoke
	|
	|-RVA: 0x1B13DC0 Offset: 0x1B123C0 VA: 0x181B13DC0
	|-EnumHelper.Transformer<byte, UIntPtr>.BeginInvoke
	|
	|-RVA: 0x1B154C0 Offset: 0x1B13AC0 VA: 0x181B154C0
	|-EnumHelper.Transformer<short, bool>.BeginInvoke
	|
	|-RVA: 0x1B152C0 Offset: 0x1B138C0 VA: 0x181B152C0
	|-EnumHelper.Transformer<short, byte>.BeginInvoke
	|
	|-RVA: 0x1B14540 Offset: 0x1B12B40 VA: 0x181B14540
	|-EnumHelper.Transformer<short, char>.BeginInvoke
	|
	|-RVA: 0x1B141C0 Offset: 0x1B127C0 VA: 0x181B141C0
	|-EnumHelper.Transformer<short, KeyValuePair<object, object>>.BeginInvoke
	|
	|-RVA: 0x1B13D40 Offset: 0x1B12340 VA: 0x181B13D40
	|-EnumHelper.Transformer<short, DateTime>.BeginInvoke
	|
	|-RVA: 0x1B14CC0 Offset: 0x1B132C0 VA: 0x181B14CC0
	|-EnumHelper.Transformer<short, DateTimeOffset>.BeginInvoke
	|
	|-RVA: 0x1B13FC0 Offset: 0x1B125C0 VA: 0x181B13FC0
	|-EnumHelper.Transformer<short, Decimal>.BeginInvoke
	|
	|-RVA: 0x1B15940 Offset: 0x1B13F40 VA: 0x181B15940
	|-EnumHelper.Transformer<short, EmptyStruct>.BeginInvoke
	|
	|-RVA: 0x1B14C40 Offset: 0x1B13240 VA: 0x181B14C40
	|-EnumHelper.Transformer<short, double>.BeginInvoke
	|
	|-RVA: 0x1B144C0 Offset: 0x1B12AC0 VA: 0x181B144C0
	|-EnumHelper.Transformer<short, Guid>.BeginInvoke
	|
	|-RVA: 0x1B142C0 Offset: 0x1B128C0 VA: 0x181B142C0
	|-EnumHelper.Transformer<short, short>.BeginInvoke
	|
	|-RVA: 0x1B14140 Offset: 0x1B12740 VA: 0x181B14140
	|-EnumHelper.Transformer<short, int>.BeginInvoke
	|
	|-RVA: 0x1B14440 Offset: 0x1B12A40 VA: 0x181B14440
	|-EnumHelper.Transformer<short, long>.BeginInvoke
	|
	|-RVA: 0x1B14040 Offset: 0x1B12640 VA: 0x181B14040
	|-EnumHelper.Transformer<short, IntPtr>.BeginInvoke
	|
	|-RVA: 0x1B14240 Offset: 0x1B12840 VA: 0x181B14240
	|-EnumHelper.Transformer<short, sbyte>.BeginInvoke
	|
	|-RVA: 0x1B15FC0 Offset: 0x1B145C0 VA: 0x181B15FC0
	|-EnumHelper.Transformer<short, float>.BeginInvoke
	|
	|-RVA: 0x1B15D40 Offset: 0x1B14340 VA: 0x181B15D40
	|-EnumHelper.Transformer<short, TimeSpan>.BeginInvoke
	|
	|-RVA: 0x1B14640 Offset: 0x1B12C40 VA: 0x181B14640
	|-EnumHelper.Transformer<short, ushort>.BeginInvoke
	|
	|-RVA: 0x1B149C0 Offset: 0x1B12FC0 VA: 0x181B149C0
	|-EnumHelper.Transformer<short, uint>.BeginInvoke
	|
	|-RVA: 0x1B15340 Offset: 0x1B13940 VA: 0x181B15340
	|-EnumHelper.Transformer<short, ulong>.BeginInvoke
	|
	|-RVA: 0x1B14BC0 Offset: 0x1B131C0 VA: 0x181B14BC0
	|-EnumHelper.Transformer<short, UIntPtr>.BeginInvoke
	|
	|-RVA: 0x1B15C40 Offset: 0x1B14240 VA: 0x181B15C40
	|-EnumHelper.Transformer<int, bool>.BeginInvoke
	|
	|-RVA: 0x1B145C0 Offset: 0x1B12BC0 VA: 0x181B145C0
	|-EnumHelper.Transformer<int, byte>.BeginInvoke
	|
	|-RVA: 0x1B14840 Offset: 0x1B12E40 VA: 0x181B14840
	|-EnumHelper.Transformer<int, char>.BeginInvoke
	|
	|-RVA: 0x1B14DC0 Offset: 0x1B133C0 VA: 0x181B14DC0
	|-EnumHelper.Transformer<int, KeyValuePair<object, object>>.BeginInvoke
	|
	|-RVA: 0x1B14E40 Offset: 0x1B13440 VA: 0x181B14E40
	|-EnumHelper.Transformer<int, DateTime>.BeginInvoke
	|
	|-RVA: 0x1B15140 Offset: 0x1B13740 VA: 0x181B15140
	|-EnumHelper.Transformer<int, DateTimeOffset>.BeginInvoke
	|
	|-RVA: 0x1B14FC0 Offset: 0x1B135C0 VA: 0x181B14FC0
	|-EnumHelper.Transformer<int, Decimal>.BeginInvoke
	|
	|-RVA: 0x1B158C0 Offset: 0x1B13EC0 VA: 0x181B158C0
	|-EnumHelper.Transformer<int, EmptyStruct>.BeginInvoke
	|
	|-RVA: 0x1B14B40 Offset: 0x1B13140 VA: 0x181B14B40
	|-EnumHelper.Transformer<int, double>.BeginInvoke
	|
	|-RVA: 0x1B15E40 Offset: 0x1B14440 VA: 0x181B15E40
	|-EnumHelper.Transformer<int, Guid>.BeginInvoke
	|
	|-RVA: 0x1B151C0 Offset: 0x1B137C0 VA: 0x181B151C0
	|-EnumHelper.Transformer<int, short>.BeginInvoke
	|
	|-RVA: 0x1B15B40 Offset: 0x1B14140 VA: 0x181B15B40
	|-EnumHelper.Transformer<int, int>.BeginInvoke
	|
	|-RVA: 0x1B155C0 Offset: 0x1B13BC0 VA: 0x181B155C0
	|-EnumHelper.Transformer<int, long>.BeginInvoke
	|
	|-RVA: 0x1B15740 Offset: 0x1B13D40 VA: 0x181B15740
	|-EnumHelper.Transformer<int, IntPtr>.BeginInvoke
	|
	|-RVA: 0x1B14340 Offset: 0x1B12940 VA: 0x181B14340
	|-EnumHelper.Transformer<int, sbyte>.BeginInvoke
	|
	|-RVA: 0x1B13E40 Offset: 0x1B12440 VA: 0x181B13E40
	|-EnumHelper.Transformer<int, float>.BeginInvoke
	|
	|-RVA: 0x1B153C0 Offset: 0x1B139C0 VA: 0x181B153C0
	|-EnumHelper.Transformer<int, TimeSpan>.BeginInvoke
	|
	|-RVA: 0x1B14740 Offset: 0x1B12D40 VA: 0x181B14740
	|-EnumHelper.Transformer<int, ushort>.BeginInvoke
	|
	|-RVA: 0x1B150C0 Offset: 0x1B136C0 VA: 0x181B150C0
	|-EnumHelper.Transformer<int, uint>.BeginInvoke
	|
	|-RVA: 0x1B13EC0 Offset: 0x1B124C0 VA: 0x181B13EC0
	|-EnumHelper.Transformer<int, ulong>.BeginInvoke
	|
	|-RVA: 0x1B14EC0 Offset: 0x1B134C0 VA: 0x181B14EC0
	|-EnumHelper.Transformer<int, UIntPtr>.BeginInvoke
	|
	|-RVA: 0x1B14940 Offset: 0x1B12F40 VA: 0x181B14940
	|-EnumHelper.Transformer<long, bool>.BeginInvoke
	|
	|-RVA: 0x1B15540 Offset: 0x1B13B40 VA: 0x181B15540
	|-EnumHelper.Transformer<long, byte>.BeginInvoke
	|
	|-RVA: 0x1B143C0 Offset: 0x1B129C0 VA: 0x181B143C0
	|-EnumHelper.Transformer<long, char>.BeginInvoke
	|
	|-RVA: 0x1B15040 Offset: 0x1B13640 VA: 0x181B15040
	|-EnumHelper.Transformer<long, KeyValuePair<object, object>>.BeginInvoke
	|
	|-RVA: 0x1B15A40 Offset: 0x1B14040 VA: 0x181B15A40
	|-EnumHelper.Transformer<long, DateTime>.BeginInvoke
	|
	|-RVA: 0x1B15640 Offset: 0x1B13C40 VA: 0x181B15640
	|-EnumHelper.Transformer<long, DateTimeOffset>.BeginInvoke
	|
	|-RVA: 0x1B14A40 Offset: 0x1B13040 VA: 0x181B14A40
	|-EnumHelper.Transformer<long, Decimal>.BeginInvoke
	|
	|-RVA: 0x213C760 Offset: 0x213AD60 VA: 0x18213C760
	|-EnumHelper.Transformer<long, EmptyStruct>.BeginInvoke
	|
	|-RVA: 0x213C860 Offset: 0x213AE60 VA: 0x18213C860
	|-EnumHelper.Transformer<long, double>.BeginInvoke
	|
	|-RVA: 0x213A9E0 Offset: 0x2138FE0 VA: 0x18213A9E0
	|-EnumHelper.Transformer<long, Guid>.BeginInvoke
	|
	|-RVA: 0x213C0E0 Offset: 0x213A6E0 VA: 0x18213C0E0
	|-EnumHelper.Transformer<long, short>.BeginInvoke
	|
	|-RVA: 0x213B6E0 Offset: 0x2139CE0 VA: 0x18213B6E0
	|-EnumHelper.Transformer<long, int>.BeginInvoke
	|
	|-RVA: 0x213BD60 Offset: 0x213A360 VA: 0x18213BD60
	|-EnumHelper.Transformer<long, long>.BeginInvoke
	|
	|-RVA: 0x213B960 Offset: 0x2139F60 VA: 0x18213B960
	|-EnumHelper.Transformer<long, IntPtr>.BeginInvoke
	|
	|-RVA: 0x213C460 Offset: 0x213AA60 VA: 0x18213C460
	|-EnumHelper.Transformer<long, sbyte>.BeginInvoke
	|
	|-RVA: 0x213B5E0 Offset: 0x2139BE0 VA: 0x18213B5E0
	|-EnumHelper.Transformer<long, float>.BeginInvoke
	|
	|-RVA: 0x213D7E0 Offset: 0x213BDE0 VA: 0x18213D7E0
	|-EnumHelper.Transformer<long, TimeSpan>.BeginInvoke
	|
	|-RVA: 0x213B060 Offset: 0x2139660 VA: 0x18213B060
	|-EnumHelper.Transformer<long, ushort>.BeginInvoke
	|
	|-RVA: 0x213C8E0 Offset: 0x213AEE0 VA: 0x18213C8E0
	|-EnumHelper.Transformer<long, uint>.BeginInvoke
	|
	|-RVA: 0x213B8E0 Offset: 0x2139EE0 VA: 0x18213B8E0
	|-EnumHelper.Transformer<long, ulong>.BeginInvoke
	|
	|-RVA: 0x213CAE0 Offset: 0x213B0E0 VA: 0x18213CAE0
	|-EnumHelper.Transformer<long, UIntPtr>.BeginInvoke
	|
	|-RVA: 0x213AE60 Offset: 0x2139460 VA: 0x18213AE60
	|-EnumHelper.Transformer<sbyte, bool>.BeginInvoke
	|
	|-RVA: 0x213B660 Offset: 0x2139C60 VA: 0x18213B660
	|-EnumHelper.Transformer<sbyte, byte>.BeginInvoke
	|
	|-RVA: 0x213B1E0 Offset: 0x21397E0 VA: 0x18213B1E0
	|-EnumHelper.Transformer<sbyte, char>.BeginInvoke
	|
	|-RVA: 0x213CE60 Offset: 0x213B460 VA: 0x18213CE60
	|-EnumHelper.Transformer<sbyte, KeyValuePair<object, object>>.BeginInvoke
	|
	|-RVA: 0x213C4E0 Offset: 0x213AAE0 VA: 0x18213C4E0
	|-EnumHelper.Transformer<sbyte, DateTime>.BeginInvoke
	|
	|-RVA: 0x213AD60 Offset: 0x2139360 VA: 0x18213AD60
	|-EnumHelper.Transformer<sbyte, DateTimeOffset>.BeginInvoke
	|
	|-RVA: 0x213B7E0 Offset: 0x2139DE0 VA: 0x18213B7E0
	|-EnumHelper.Transformer<sbyte, Decimal>.BeginInvoke
	|
	|-RVA: 0x213A8E0 Offset: 0x2138EE0 VA: 0x18213A8E0
	|-EnumHelper.Transformer<sbyte, EmptyStruct>.BeginInvoke
	|
	|-RVA: 0x213CEE0 Offset: 0x213B4E0 VA: 0x18213CEE0
	|-EnumHelper.Transformer<sbyte, double>.BeginInvoke
	|
	|-RVA: 0x213CF60 Offset: 0x213B560 VA: 0x18213CF60
	|-EnumHelper.Transformer<sbyte, Guid>.BeginInvoke
	|
	|-RVA: 0x213B560 Offset: 0x2139B60 VA: 0x18213B560
	|-EnumHelper.Transformer<sbyte, short>.BeginInvoke
	|
	|-RVA: 0x213C660 Offset: 0x213AC60 VA: 0x18213C660
	|-EnumHelper.Transformer<sbyte, int>.BeginInvoke
	|
	|-RVA: 0x213CCE0 Offset: 0x213B2E0 VA: 0x18213CCE0
	|-EnumHelper.Transformer<sbyte, long>.BeginInvoke
	|
	|-RVA: 0x213BE60 Offset: 0x213A460 VA: 0x18213BE60
	|-EnumHelper.Transformer<sbyte, IntPtr>.BeginInvoke
	|
	|-RVA: 0x213CBE0 Offset: 0x213B1E0 VA: 0x18213CBE0
	|-EnumHelper.Transformer<sbyte, sbyte>.BeginInvoke
	|
	|-RVA: 0x213C560 Offset: 0x213AB60 VA: 0x18213C560
	|-EnumHelper.Transformer<sbyte, float>.BeginInvoke
	|
	|-RVA: 0x213BF60 Offset: 0x213A560 VA: 0x18213BF60
	|-EnumHelper.Transformer<sbyte, TimeSpan>.BeginInvoke
	|
	|-RVA: 0x213D6E0 Offset: 0x213BCE0 VA: 0x18213D6E0
	|-EnumHelper.Transformer<sbyte, ushort>.BeginInvoke
	|
	|-RVA: 0x213ABE0 Offset: 0x21391E0 VA: 0x18213ABE0
	|-EnumHelper.Transformer<sbyte, uint>.BeginInvoke
	|
	|-RVA: 0x213A960 Offset: 0x2138F60 VA: 0x18213A960
	|-EnumHelper.Transformer<sbyte, ulong>.BeginInvoke
	|
	|-RVA: 0x213A760 Offset: 0x2138D60 VA: 0x18213A760
	|-EnumHelper.Transformer<sbyte, UIntPtr>.BeginInvoke
	|
	|-RVA: 0x213C3E0 Offset: 0x213A9E0 VA: 0x18213C3E0
	|-EnumHelper.Transformer<ushort, bool>.BeginInvoke
	|
	|-RVA: 0x213BAE0 Offset: 0x213A0E0 VA: 0x18213BAE0
	|-EnumHelper.Transformer<ushort, byte>.BeginInvoke
	|
	|-RVA: 0x213C260 Offset: 0x213A860 VA: 0x18213C260
	|-EnumHelper.Transformer<ushort, char>.BeginInvoke
	|
	|-RVA: 0x213BB60 Offset: 0x213A160 VA: 0x18213BB60
	|-EnumHelper.Transformer<ushort, KeyValuePair<object, object>>.BeginInvoke
	|
	|-RVA: 0x213AFE0 Offset: 0x21395E0 VA: 0x18213AFE0
	|-EnumHelper.Transformer<ushort, DateTime>.BeginInvoke
	|
	|-RVA: 0x213ACE0 Offset: 0x21392E0 VA: 0x18213ACE0
	|-EnumHelper.Transformer<ushort, DateTimeOffset>.BeginInvoke
	|
	|-RVA: 0x213BC60 Offset: 0x213A260 VA: 0x18213BC60
	|-EnumHelper.Transformer<ushort, Decimal>.BeginInvoke
	|
	|-RVA: 0x213AAE0 Offset: 0x21390E0 VA: 0x18213AAE0
	|-EnumHelper.Transformer<ushort, EmptyStruct>.BeginInvoke
	|
	|-RVA: 0x213BFE0 Offset: 0x213A5E0 VA: 0x18213BFE0
	|-EnumHelper.Transformer<ushort, double>.BeginInvoke
	|
	|-RVA: 0x213A7E0 Offset: 0x2138DE0 VA: 0x18213A7E0
	|-EnumHelper.Transformer<ushort, Guid>.BeginInvoke
	|
	|-RVA: 0x213C5E0 Offset: 0x213ABE0 VA: 0x18213C5E0
	|-EnumHelper.Transformer<ushort, short>.BeginInvoke
	|
	|-RVA: 0x213D4E0 Offset: 0x213BAE0 VA: 0x18213D4E0
	|-EnumHelper.Transformer<ushort, int>.BeginInvoke
	|
	|-RVA: 0x213B2E0 Offset: 0x21398E0 VA: 0x18213B2E0
	|-EnumHelper.Transformer<ushort, long>.BeginInvoke
	|
	|-RVA: 0x213A860 Offset: 0x2138E60 VA: 0x18213A860
	|-EnumHelper.Transformer<ushort, IntPtr>.BeginInvoke
	|
	|-RVA: 0x213CA60 Offset: 0x213B060 VA: 0x18213CA60
	|-EnumHelper.Transformer<ushort, sbyte>.BeginInvoke
	|
	|-RVA: 0x213B260 Offset: 0x2139860 VA: 0x18213B260
	|-EnumHelper.Transformer<ushort, float>.BeginInvoke
	|
	|-RVA: 0x213BCE0 Offset: 0x213A2E0 VA: 0x18213BCE0
	|-EnumHelper.Transformer<ushort, TimeSpan>.BeginInvoke
	|
	|-RVA: 0x213D060 Offset: 0x213B660 VA: 0x18213D060
	|-EnumHelper.Transformer<ushort, ushort>.BeginInvoke
	|
	|-RVA: 0x213BDE0 Offset: 0x213A3E0 VA: 0x18213BDE0
	|-EnumHelper.Transformer<ushort, uint>.BeginInvoke
	|
	|-RVA: 0x213B160 Offset: 0x2139760 VA: 0x18213B160
	|-EnumHelper.Transformer<ushort, ulong>.BeginInvoke
	|
	|-RVA: 0x213BA60 Offset: 0x213A060 VA: 0x18213BA60
	|-EnumHelper.Transformer<ushort, UIntPtr>.BeginInvoke
	|
	|-RVA: 0x213C360 Offset: 0x213A960 VA: 0x18213C360
	|-EnumHelper.Transformer<uint, bool>.BeginInvoke
	|
	|-RVA: 0x213BEE0 Offset: 0x213A4E0 VA: 0x18213BEE0
	|-EnumHelper.Transformer<uint, byte>.BeginInvoke
	|
	|-RVA: 0x213D2E0 Offset: 0x213B8E0 VA: 0x18213D2E0
	|-EnumHelper.Transformer<uint, char>.BeginInvoke
	|
	|-RVA: 0x213C1E0 Offset: 0x213A7E0 VA: 0x18213C1E0
	|-EnumHelper.Transformer<uint, KeyValuePair<object, object>>.BeginInvoke
	|
	|-RVA: 0x213AEE0 Offset: 0x21394E0 VA: 0x18213AEE0
	|-EnumHelper.Transformer<uint, DateTime>.BeginInvoke
	|
	|-RVA: 0x213B0E0 Offset: 0x21396E0 VA: 0x18213B0E0
	|-EnumHelper.Transformer<uint, DateTimeOffset>.BeginInvoke
	|
	|-RVA: 0x213B3E0 Offset: 0x21399E0 VA: 0x18213B3E0
	|-EnumHelper.Transformer<uint, Decimal>.BeginInvoke
	|
	|-RVA: 0x213C960 Offset: 0x213AF60 VA: 0x18213C960
	|-EnumHelper.Transformer<uint, EmptyStruct>.BeginInvoke
	|
	|-RVA: 0x213AB60 Offset: 0x2139160 VA: 0x18213AB60
	|-EnumHelper.Transformer<uint, double>.BeginInvoke
	|
	|-RVA: 0x213CD60 Offset: 0x213B360 VA: 0x18213CD60
	|-EnumHelper.Transformer<uint, Guid>.BeginInvoke
	|
	|-RVA: 0x213B9E0 Offset: 0x2139FE0 VA: 0x18213B9E0
	|-EnumHelper.Transformer<uint, short>.BeginInvoke
	|
	|-RVA: 0x213B4E0 Offset: 0x2139AE0 VA: 0x18213B4E0
	|-EnumHelper.Transformer<uint, int>.BeginInvoke
	|
	|-RVA: 0x213D360 Offset: 0x213B960 VA: 0x18213D360
	|-EnumHelper.Transformer<uint, long>.BeginInvoke
	|
	|-RVA: 0x213D0E0 Offset: 0x213B6E0 VA: 0x18213D0E0
	|-EnumHelper.Transformer<uint, IntPtr>.BeginInvoke
	|
	|-RVA: 0x213D660 Offset: 0x213BC60 VA: 0x18213D660
	|-EnumHelper.Transformer<uint, sbyte>.BeginInvoke
	|
	|-RVA: 0x213C160 Offset: 0x213A760 VA: 0x18213C160
	|-EnumHelper.Transformer<uint, float>.BeginInvoke
	|
	|-RVA: 0x213D760 Offset: 0x213BD60 VA: 0x18213D760
	|-EnumHelper.Transformer<uint, TimeSpan>.BeginInvoke
	|
	|-RVA: 0x213BBE0 Offset: 0x213A1E0 VA: 0x18213BBE0
	|-EnumHelper.Transformer<uint, ushort>.BeginInvoke
	|
	|-RVA: 0x213D460 Offset: 0x213BA60 VA: 0x18213D460
	|-EnumHelper.Transformer<uint, uint>.BeginInvoke
	|
	|-RVA: 0x213CC60 Offset: 0x213B260 VA: 0x18213CC60
	|-EnumHelper.Transformer<uint, ulong>.BeginInvoke
	|
	|-RVA: 0x213D3E0 Offset: 0x213B9E0 VA: 0x18213D3E0
	|-EnumHelper.Transformer<uint, UIntPtr>.BeginInvoke
	|
	|-RVA: 0x213D160 Offset: 0x213B760 VA: 0x18213D160
	|-EnumHelper.Transformer<ulong, bool>.BeginInvoke
	|
	|-RVA: 0x213D260 Offset: 0x213B860 VA: 0x18213D260
	|-EnumHelper.Transformer<ulong, byte>.BeginInvoke
	|
	|-RVA: 0x213D5E0 Offset: 0x213BBE0 VA: 0x18213D5E0
	|-EnumHelper.Transformer<ulong, char>.BeginInvoke
	|
	|-RVA: 0x213C7E0 Offset: 0x213ADE0 VA: 0x18213C7E0
	|-EnumHelper.Transformer<ulong, KeyValuePair<object, object>>.BeginInvoke
	|
	|-RVA: 0x213C060 Offset: 0x213A660 VA: 0x18213C060
	|-EnumHelper.Transformer<ulong, DateTime>.BeginInvoke
	|
	|-RVA: 0x213AC60 Offset: 0x2139260 VA: 0x18213AC60
	|-EnumHelper.Transformer<ulong, DateTimeOffset>.BeginInvoke
	|
	|-RVA: 0x213B460 Offset: 0x2139A60 VA: 0x18213B460
	|-EnumHelper.Transformer<ulong, Decimal>.BeginInvoke
	|
	|-RVA: 0x213C2E0 Offset: 0x213A8E0 VA: 0x18213C2E0
	|-EnumHelper.Transformer<ulong, EmptyStruct>.BeginInvoke
	|
	|-RVA: 0x213B860 Offset: 0x2139E60 VA: 0x18213B860
	|-EnumHelper.Transformer<ulong, double>.BeginInvoke
	|
	|-RVA: 0x213AF60 Offset: 0x2139560 VA: 0x18213AF60
	|-EnumHelper.Transformer<ulong, Guid>.BeginInvoke
	|
	|-RVA: 0x213CFE0 Offset: 0x213B5E0 VA: 0x18213CFE0
	|-EnumHelper.Transformer<ulong, short>.BeginInvoke
	|
	|-RVA: 0x213B360 Offset: 0x2139960 VA: 0x18213B360
	|-EnumHelper.Transformer<ulong, int>.BeginInvoke
	|
	|-RVA: 0x213B760 Offset: 0x2139D60 VA: 0x18213B760
	|-EnumHelper.Transformer<ulong, long>.BeginInvoke
	|
	|-RVA: 0x213CB60 Offset: 0x213B160 VA: 0x18213CB60
	|-EnumHelper.Transformer<ulong, IntPtr>.BeginInvoke
	|
	|-RVA: 0x213AA60 Offset: 0x2139060 VA: 0x18213AA60
	|-EnumHelper.Transformer<ulong, sbyte>.BeginInvoke
	|
	|-RVA: 0x213C9E0 Offset: 0x213AFE0 VA: 0x18213C9E0
	|-EnumHelper.Transformer<ulong, float>.BeginInvoke
	|
	|-RVA: 0x213D1E0 Offset: 0x213B7E0 VA: 0x18213D1E0
	|-EnumHelper.Transformer<ulong, TimeSpan>.BeginInvoke
	|
	|-RVA: 0x213D560 Offset: 0x213BB60 VA: 0x18213D560
	|-EnumHelper.Transformer<ulong, ushort>.BeginInvoke
	|
	|-RVA: 0x213ADE0 Offset: 0x21393E0 VA: 0x18213ADE0
	|-EnumHelper.Transformer<ulong, uint>.BeginInvoke
	|
	|-RVA: 0x213C6E0 Offset: 0x213ACE0 VA: 0x18213C6E0
	|-EnumHelper.Transformer<ulong, ulong>.BeginInvoke
	|
	|-RVA: 0x213CDE0 Offset: 0x213B3E0 VA: 0x18213CDE0
	|-EnumHelper.Transformer<ulong, UIntPtr>.BeginInvoke
	*/

	public virtual UnderlyingType EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFF6FB0 Offset: 0xFF55B0 VA: 0x180FF6FB0
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
	|-RVA: 0xD98590 Offset: 0xD96B90 VA: 0x180D98590
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
	|-RVA: 0xB9AEA0 Offset: 0xB994A0 VA: 0x180B9AEA0
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
	|-RVA: 0x1221D30 Offset: 0x1220330 VA: 0x181221D30
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
	|-RVA: 0x1AFC1C0 Offset: 0x1AFA7C0 VA: 0x181AFC1C0
	|-EnumHelper.Caster<byte, bool>..cctor
	|
	|-RVA: 0x1AF7570 Offset: 0x1AF5B70 VA: 0x181AF7570
	|-EnumHelper.Caster<byte, byte>..cctor
	|
	|-RVA: 0x1B00970 Offset: 0x1AFEF70 VA: 0x181B00970
	|-EnumHelper.Caster<byte, char>..cctor
	|
	|-RVA: 0x1B04C80 Offset: 0x1B03280 VA: 0x181B04C80
	|-EnumHelper.Caster<byte, KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x1AFE910 Offset: 0x1AFCF10 VA: 0x181AFE910
	|-EnumHelper.Caster<byte, DateTime>..cctor
	|
	|-RVA: 0x1B06A90 Offset: 0x1B05090 VA: 0x181B06A90
	|-EnumHelper.Caster<byte, DateTimeOffset>..cctor
	|
	|-RVA: 0x1B0B240 Offset: 0x1B09840 VA: 0x181B0B240
	|-EnumHelper.Caster<byte, Decimal>..cctor
	|
	|-RVA: 0x1AFF4A0 Offset: 0x1AFDAA0 VA: 0x181AFF4A0
	|-EnumHelper.Caster<byte, EmptyStruct>..cctor
	|
	|-RVA: 0x1B0E9C0 Offset: 0x1B0CFC0 VA: 0x181B0E9C0
	|-EnumHelper.Caster<byte, double>..cctor
	|
	|-RVA: 0x1B0F550 Offset: 0x1B0DB50 VA: 0x181B0F550
	|-EnumHelper.Caster<byte, Guid>..cctor
	|
	|-RVA: 0x1AF70D0 Offset: 0x1AF56D0 VA: 0x181AF70D0
	|-EnumHelper.Caster<byte, short>..cctor
	|
	|-RVA: 0x1AFC410 Offset: 0x1AFAA10 VA: 0x181AFC410
	|-EnumHelper.Caster<byte, int>..cctor
	|
	|-RVA: 0x1AFEB60 Offset: 0x1AFD160 VA: 0x181AFEB60
	|-EnumHelper.Caster<byte, long>..cctor
	|
	|-RVA: 0x1B03EA0 Offset: 0x1B024A0 VA: 0x181B03EA0
	|-EnumHelper.Caster<byte, IntPtr>..cctor
	|
	|-RVA: 0x1B0E770 Offset: 0x1B0CD70 VA: 0x181B0E770
	|-EnumHelper.Caster<byte, object>..cctor
	|
	|-RVA: 0x1B07870 Offset: 0x1B05E70 VA: 0x181B07870
	|-EnumHelper.Caster<byte, sbyte>..cctor
	|
	|-RVA: 0x1B02E70 Offset: 0x1B01470 VA: 0x181B02E70
	|-EnumHelper.Caster<byte, float>..cctor
	|
	|-RVA: 0x1AFA850 Offset: 0x1AF8E50 VA: 0x181AFA850
	|-EnumHelper.Caster<byte, TimeSpan>..cctor
	|
	|-RVA: 0x1AFBF70 Offset: 0x1AFA570 VA: 0x181AFBF70
	|-EnumHelper.Caster<byte, ushort>..cctor
	|
	|-RVA: 0x1AFE6C0 Offset: 0x1AFCCC0 VA: 0x181AFE6C0
	|-EnumHelper.Caster<byte, uint>..cctor
	|
	|-RVA: 0x1B0C020 Offset: 0x1B0A620 VA: 0x181B0C020
	|-EnumHelper.Caster<byte, ulong>..cctor
	|
	|-RVA: 0x1AFD1F0 Offset: 0x1AFB7F0 VA: 0x181AFD1F0
	|-EnumHelper.Caster<byte, UIntPtr>..cctor
	|
	|-RVA: 0x1B0D990 Offset: 0x1B0BF90 VA: 0x181B0D990
	|-EnumHelper.Caster<short, bool>..cctor
	|
	|-RVA: 0x1AF87F0 Offset: 0x1AF6DF0 VA: 0x181AF87F0
	|-EnumHelper.Caster<short, byte>..cctor
	|
	|-RVA: 0x1AF8350 Offset: 0x1AF6950 VA: 0x181AF8350
	|-EnumHelper.Caster<short, char>..cctor
	|
	|-RVA: 0x1B01BF0 Offset: 0x1B001F0 VA: 0x181B01BF0
	|-EnumHelper.Caster<short, KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x1B012B0 Offset: 0x1AFF8B0 VA: 0x181B012B0
	|-EnumHelper.Caster<short, DateTime>..cctor
	|
	|-RVA: 0x1B073D0 Offset: 0x1B059D0 VA: 0x181B073D0
	|-EnumHelper.Caster<short, DateTimeOffset>..cctor
	|
	|-RVA: 0x1AFB3E0 Offset: 0x1AF99E0 VA: 0x181AFB3E0
	|-EnumHelper.Caster<short, Decimal>..cctor
	|
	|-RVA: 0x1B0B6E0 Offset: 0x1B09CE0 VA: 0x181B0B6E0
	|-EnumHelper.Caster<short, EmptyStruct>..cctor
	|
	|-RVA: 0x1AFA3B0 Offset: 0x1AF89B0 VA: 0x181AFA3B0
	|-EnumHelper.Caster<short, double>..cctor
	|
	|-RVA: 0x1B065F0 Offset: 0x1B04BF0 VA: 0x181B065F0
	|-EnumHelper.Caster<short, Guid>..cctor
	|
	|-RVA: 0x1B05CB0 Offset: 0x1B042B0 VA: 0x181B05CB0
	|-EnumHelper.Caster<short, short>..cctor
	|
	|-RVA: 0x1B00BC0 Offset: 0x1AFF1C0 VA: 0x181B00BC0
	|-EnumHelper.Caster<short, int>..cctor
	|
	|-RVA: 0x1AFD440 Offset: 0x1AFBA40 VA: 0x181AFD440
	|-EnumHelper.Caster<short, long>..cctor
	|
	|-RVA: 0x1B08400 Offset: 0x1B06A00 VA: 0x181B08400
	|-EnumHelper.Caster<short, IntPtr>..cctor
	|
	|-RVA: 0x1B02090 Offset: 0x1B00690 VA: 0x181B02090
	|-EnumHelper.Caster<short, object>..cctor
	|
	|-RVA: 0x1B037B0 Offset: 0x1B01DB0 VA: 0x181B037B0
	|-EnumHelper.Caster<short, sbyte>..cctor
	|
	|-RVA: 0x1B098D0 Offset: 0x1B07ED0 VA: 0x181B098D0
	|-EnumHelper.Caster<short, float>..cctor
	|
	|-RVA: 0x1B09680 Offset: 0x1B07C80 VA: 0x181B09680
	|-EnumHelper.Caster<short, TimeSpan>..cctor
	|
	|-RVA: 0x1B0CE00 Offset: 0x1B0B400 VA: 0x181B0CE00
	|-EnumHelper.Caster<short, ushort>..cctor
	|
	|-RVA: 0x1AFBD20 Offset: 0x1AFA320 VA: 0x181AFBD20
	|-EnumHelper.Caster<short, uint>..cctor
	|
	|-RVA: 0x1AFDD80 Offset: 0x1AFC380 VA: 0x181AFDD80
	|-EnumHelper.Caster<short, ulong>..cctor
	|
	|-RVA: 0x1B09D70 Offset: 0x1B08370 VA: 0x181B09D70
	|-EnumHelper.Caster<short, UIntPtr>..cctor
	|
	|-RVA: 0x1AF60A0 Offset: 0x1AF46A0 VA: 0x181AF60A0
	|-EnumHelper.Caster<int, bool>..cctor
	|
	|-RVA: 0x1AF9380 Offset: 0x1AF7980 VA: 0x181AF9380
	|-EnumHelper.Caster<int, byte>..cctor
	|
	|-RVA: 0x1AF8EE0 Offset: 0x1AF74E0 VA: 0x181AF8EE0
	|-EnumHelper.Caster<int, char>..cctor
	|
	|-RVA: 0x1B0A900 Offset: 0x1B08F00 VA: 0x181B0A900
	|-EnumHelper.Caster<int, KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x1B081B0 Offset: 0x1B067B0 VA: 0x181B081B0
	|-EnumHelper.Caster<int, DateTime>..cctor
	|
	|-RVA: 0x1AFF000 Offset: 0x1AFD600 VA: 0x181AFF000
	|-EnumHelper.Caster<int, DateTimeOffset>..cctor
	|
	|-RVA: 0x1B047E0 Offset: 0x1B02DE0 VA: 0x181B047E0
	|-EnumHelper.Caster<int, Decimal>..cctor
	|
	|-RVA: 0x1B063A0 Offset: 0x1B049A0 VA: 0x181B063A0
	|-EnumHelper.Caster<int, EmptyStruct>..cctor
	|
	|-RVA: 0x1AF9F10 Offset: 0x1AF8510 VA: 0x181AF9F10
	|-EnumHelper.Caster<int, double>..cctor
	|
	|-RVA: 0x1AF69E0 Offset: 0x1AF4FE0 VA: 0x181AF69E0
	|-EnumHelper.Caster<int, Guid>..cctor
	|
	|-RVA: 0x1AFD8E0 Offset: 0x1AFBEE0 VA: 0x181AFD8E0
	|-EnumHelper.Caster<int, short>..cctor
	|
	|-RVA: 0x1AF85A0 Offset: 0x1AF6BA0 VA: 0x181AF85A0
	|-EnumHelper.Caster<int, int>..cctor
	|
	|-RVA: 0x1B0ADA0 Offset: 0x1B093A0 VA: 0x181B0ADA0
	|-EnumHelper.Caster<int, long>..cctor
	|
	|-RVA: 0x1AF6790 Offset: 0x1AF4D90 VA: 0x181AF6790
	|-EnumHelper.Caster<int, IntPtr>..cctor
	|
	|-RVA: 0x1B0B490 Offset: 0x1B09A90 VA: 0x181B0B490
	|-EnumHelper.Caster<int, object>..cctor
	|
	|-RVA: 0x1B08F90 Offset: 0x1B07590 VA: 0x181B08F90
	|-EnumHelper.Caster<int, sbyte>..cctor
	|
	|-RVA: 0x1AFB630 Offset: 0x1AF9C30 VA: 0x181AFB630
	|-EnumHelper.Caster<int, float>..cctor
	|
	|-RVA: 0x1B06CE0 Offset: 0x1B052E0 VA: 0x181B06CE0
	|-EnumHelper.Caster<int, TimeSpan>..cctor
	|
	|-RVA: 0x1B0E520 Offset: 0x1B0CB20 VA: 0x181B0E520
	|-EnumHelper.Caster<int, ushort>..cctor
	|
	|-RVA: 0x1B01500 Offset: 0x1AFFB00 VA: 0x181B01500
	|-EnumHelper.Caster<int, uint>..cctor
	|
	|-RVA: 0x1AF8C90 Offset: 0x1AF7290 VA: 0x181AF8C90
	|-EnumHelper.Caster<int, ulong>..cctor
	|
	|-RVA: 0x1B08650 Offset: 0x1B06C50 VA: 0x181B08650
	|-EnumHelper.Caster<int, UIntPtr>..cctor
	|
	|-RVA: 0x1B04340 Offset: 0x1B02940 VA: 0x181B04340
	|-EnumHelper.Caster<long, bool>..cctor
	|
	|-RVA: 0x1B00030 Offset: 0x1AFE630 VA: 0x181B00030
	|-EnumHelper.Caster<long, byte>..cctor
	|
	|-RVA: 0x1B03A00 Offset: 0x1B02000 VA: 0x181B03A00
	|-EnumHelper.Caster<long, char>..cctor
	|
	|-RVA: 0x1AF95D0 Offset: 0x1AF7BD0 VA: 0x181AF95D0
	|-EnumHelper.Caster<long, KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x1AFAAA0 Offset: 0x1AF90A0 VA: 0x181AFAAA0
	|-EnumHelper.Caster<long, DateTime>..cctor
	|
	|-RVA: 0x1B01E40 Offset: 0x1B00440 VA: 0x181B01E40
	|-EnumHelper.Caster<long, DateTimeOffset>..cctor
	|
	|-RVA: 0x1B00280 Offset: 0x1AFE880 VA: 0x181B00280
	|-EnumHelper.Caster<long, Decimal>..cctor
	|
	|-RVA: 0x1B091E0 Offset: 0x1B077E0 VA: 0x181B091E0
	|-EnumHelper.Caster<long, EmptyStruct>..cctor
	|
	|-RVA: 0x1AF6C30 Offset: 0x1AF5230 VA: 0x181AF6C30
	|-EnumHelper.Caster<long, double>..cctor
	|
	|-RVA: 0x1AFF6F0 Offset: 0x1AFDCF0 VA: 0x181AFF6F0
	|-EnumHelper.Caster<long, Guid>..cctor
	|
	|-RVA: 0x1B0A6B0 Offset: 0x1B08CB0 VA: 0x181B0A6B0
	|-EnumHelper.Caster<long, short>..cctor
	|
	|-RVA: 0x1B00720 Offset: 0x1AFED20 VA: 0x181B00720
	|-EnumHelper.Caster<long, int>..cctor
	|
	|-RVA: 0x1AFE220 Offset: 0x1AFC820 VA: 0x181AFE220
	|-EnumHelper.Caster<long, long>..cctor
	|
	|-RVA: 0x1B0F300 Offset: 0x1B0D900 VA: 0x181B0F300
	|-EnumHelper.Caster<long, IntPtr>..cctor
	|
	|-RVA: 0x1AF9130 Offset: 0x1AF7730 VA: 0x181AF9130
	|-EnumHelper.Caster<long, object>..cctor
	|
	|-RVA: 0x1B0C270 Offset: 0x1B0A870 VA: 0x181B0C270
	|-EnumHelper.Caster<long, sbyte>..cctor
	|
	|-RVA: 0x1AF9A70 Offset: 0x1AF8070 VA: 0x181AF9A70
	|-EnumHelper.Caster<long, float>..cctor
	|
	|-RVA: 0x1AF7C60 Offset: 0x1AF6260 VA: 0x181AF7C60
	|-EnumHelper.Caster<long, TimeSpan>..cctor
	|
	|-RVA: 0x1B05A60 Offset: 0x1B04060 VA: 0x181B05A60
	|-EnumHelper.Caster<long, ushort>..cctor
	|
	|-RVA: 0x1B029D0 Offset: 0x1B00FD0 VA: 0x181B029D0
	|-EnumHelper.Caster<long, uint>..cctor
	|
	|-RVA: 0x1B0DBE0 Offset: 0x1B0C1E0 VA: 0x181B0DBE0
	|-EnumHelper.Caster<long, ulong>..cctor
	|
	|-RVA: 0x1B030C0 Offset: 0x1B016C0 VA: 0x181B030C0
	|-EnumHelper.Caster<long, UIntPtr>..cctor
	|
	|-RVA: 0x1B06150 Offset: 0x1B04750 VA: 0x181B06150
	|-EnumHelper.Caster<object, object>..cctor
	|
	|-RVA: 0x1AFB880 Offset: 0x1AF9E80 VA: 0x181AFB880
	|-EnumHelper.Caster<sbyte, bool>..cctor
	|
	|-RVA: 0x1B0EE60 Offset: 0x1B0D460 VA: 0x181B0EE60
	|-EnumHelper.Caster<sbyte, byte>..cctor
	|
	|-RVA: 0x1AF7A10 Offset: 0x1AF6010 VA: 0x181AF7A10
	|-EnumHelper.Caster<sbyte, char>..cctor
	|
	|-RVA: 0x1B0AB50 Offset: 0x1B09150 VA: 0x181B0AB50
	|-EnumHelper.Caster<sbyte, KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x1AFB190 Offset: 0x1AF9790 VA: 0x181AFB190
	|-EnumHelper.Caster<sbyte, DateTime>..cctor
	|
	|-RVA: 0x1AFC660 Offset: 0x1AFAC60 VA: 0x181AFC660
	|-EnumHelper.Caster<sbyte, DateTimeOffset>..cctor
	|
	|-RVA: 0x1AFCD50 Offset: 0x1AFB350 VA: 0x181AFCD50
	|-EnumHelper.Caster<sbyte, Decimal>..cctor
	|
	|-RVA: 0x1AF6E80 Offset: 0x1AF5480 VA: 0x181AF6E80
	|-EnumHelper.Caster<sbyte, EmptyStruct>..cctor
	|
	|-RVA: 0x1B040F0 Offset: 0x1B026F0 VA: 0x181B040F0
	|-EnumHelper.Caster<sbyte, double>..cctor
	|
	|-RVA: 0x1B05120 Offset: 0x1B03720 VA: 0x181B05120
	|-EnumHelper.Caster<sbyte, Guid>..cctor
	|
	|-RVA: 0x1B0A210 Offset: 0x1B08810 VA: 0x181B0A210
	|-EnumHelper.Caster<sbyte, short>..cctor
	|
	|-RVA: 0x1B0C960 Offset: 0x1B0AF60 VA: 0x181B0C960
	|-EnumHelper.Caster<sbyte, int>..cctor
	|
	|-RVA: 0x1AFDB30 Offset: 0x1AFC130 VA: 0x181AFDB30
	|-EnumHelper.Caster<sbyte, long>..cctor
	|
	|-RVA: 0x1B09FC0 Offset: 0x1B085C0 VA: 0x181B09FC0
	|-EnumHelper.Caster<sbyte, IntPtr>..cctor
	|
	|-RVA: 0x1B04ED0 Offset: 0x1B034D0 VA: 0x181B04ED0
	|-EnumHelper.Caster<sbyte, object>..cctor
	|
	|-RVA: 0x1B0D050 Offset: 0x1B0B650 VA: 0x181B0D050
	|-EnumHelper.Caster<sbyte, sbyte>..cctor
	|
	|-RVA: 0x1B07F60 Offset: 0x1B06560 VA: 0x181B07F60
	|-EnumHelper.Caster<sbyte, float>..cctor
	|
	|-RVA: 0x1B00E10 Offset: 0x1AFF410 VA: 0x181B00E10
	|-EnumHelper.Caster<sbyte, TimeSpan>..cctor
	|
	|-RVA: 0x1AFACF0 Offset: 0x1AF92F0 VA: 0x181AFACF0
	|-EnumHelper.Caster<sbyte, ushort>..cctor
	|
	|-RVA: 0x1B0AFF0 Offset: 0x1B095F0 VA: 0x181B0AFF0
	|-EnumHelper.Caster<sbyte, uint>..cctor
	|
	|-RVA: 0x1B05370 Offset: 0x1B03970 VA: 0x181B05370
	|-EnumHelper.Caster<sbyte, ulong>..cctor
	|
	|-RVA: 0x1AF7EB0 Offset: 0x1AF64B0 VA: 0x181AF7EB0
	|-EnumHelper.Caster<sbyte, UIntPtr>..cctor
	|
	|-RVA: 0x1B09430 Offset: 0x1B07A30 VA: 0x181B09430
	|-EnumHelper.Caster<ushort, bool>..cctor
	|
	|-RVA: 0x1B06F30 Offset: 0x1B05530 VA: 0x181B06F30
	|-EnumHelper.Caster<ushort, byte>..cctor
	|
	|-RVA: 0x1B019A0 Offset: 0x1AFFFA0 VA: 0x181B019A0
	|-EnumHelper.Caster<ushort, char>..cctor
	|
	|-RVA: 0x1B07AC0 Offset: 0x1B060C0 VA: 0x181B07AC0
	|-EnumHelper.Caster<ushort, KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x1B0E080 Offset: 0x1B0C680 VA: 0x181B0E080
	|-EnumHelper.Caster<ushort, DateTime>..cctor
	|
	|-RVA: 0x1B0B930 Offset: 0x1B09F30 VA: 0x181B0B930
	|-EnumHelper.Caster<ushort, DateTimeOffset>..cctor
	|
	|-RVA: 0x1B0C4C0 Offset: 0x1B0AAC0 VA: 0x181B0C4C0
	|-EnumHelper.Caster<ushort, Decimal>..cctor
	|
	|-RVA: 0x1AFD690 Offset: 0x1AFBC90 VA: 0x181AFD690
	|-EnumHelper.Caster<ushort, EmptyStruct>..cctor
	|
	|-RVA: 0x1B02780 Offset: 0x1B00D80 VA: 0x181B02780
	|-EnumHelper.Caster<ushort, double>..cctor
	|
	|-RVA: 0x1B02530 Offset: 0x1B00B30 VA: 0x181B02530
	|-EnumHelper.Caster<ushort, Guid>..cctor
	|
	|-RVA: 0x1B05810 Offset: 0x1B03E10 VA: 0x181B05810
	|-EnumHelper.Caster<ushort, short>..cctor
	|
	|-RVA: 0x1B08AF0 Offset: 0x1B070F0 VA: 0x181B08AF0
	|-EnumHelper.Caster<ushort, int>..cctor
	|
	|-RVA: 0x1B01750 Offset: 0x1AFFD50 VA: 0x181B01750
	|-EnumHelper.Caster<ushort, long>..cctor
	|
	|-RVA: 0x1B022E0 Offset: 0x1B008E0 VA: 0x181B022E0
	|-EnumHelper.Caster<ushort, IntPtr>..cctor
	|
	|-RVA: 0x1B06840 Offset: 0x1B04E40 VA: 0x181B06840
	|-EnumHelper.Caster<ushort, object>..cctor
	|
	|-RVA: 0x1B07620 Offset: 0x1B05C20 VA: 0x181B07620
	|-EnumHelper.Caster<ushort, sbyte>..cctor
	|
	|-RVA: 0x1AFFB90 Offset: 0x1AFE190 VA: 0x181AFFB90
	|-EnumHelper.Caster<ushort, float>..cctor
	|
	|-RVA: 0x1B0A460 Offset: 0x1B08A60 VA: 0x181B0A460
	|-EnumHelper.Caster<ushort, TimeSpan>..cctor
	|
	|-RVA: 0x1AFDFD0 Offset: 0x1AFC5D0 VA: 0x181AFDFD0
	|-EnumHelper.Caster<ushort, ushort>..cctor
	|
	|-RVA: 0x1AFC8B0 Offset: 0x1AFAEB0 VA: 0x181AFC8B0
	|-EnumHelper.Caster<ushort, uint>..cctor
	|
	|-RVA: 0x1B05F00 Offset: 0x1B04500 VA: 0x181B05F00
	|-EnumHelper.Caster<ushort, ulong>..cctor
	|
	|-RVA: 0x1B03560 Offset: 0x1B01B60 VA: 0x181B03560
	|-EnumHelper.Caster<ushort, UIntPtr>..cctor
	|
	|-RVA: 0x1AF62F0 Offset: 0x1AF48F0 VA: 0x181AF62F0
	|-EnumHelper.Caster<uint, bool>..cctor
	|
	|-RVA: 0x1AFCFA0 Offset: 0x1AFB5A0 VA: 0x181AFCFA0
	|-EnumHelper.Caster<uint, byte>..cctor
	|
	|-RVA: 0x1AF9CC0 Offset: 0x1AF82C0 VA: 0x181AF9CC0
	|-EnumHelper.Caster<uint, char>..cctor
	|
	|-RVA: 0x1B04A30 Offset: 0x1B03030 VA: 0x181B04A30
	|-EnumHelper.Caster<uint, KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x1B0F7A0 Offset: 0x1B0DDA0 VA: 0x181B0F7A0
	|-EnumHelper.Caster<uint, DateTime>..cctor
	|
	|-RVA: 0x1B0C710 Offset: 0x1B0AD10 VA: 0x181B0C710
	|-EnumHelper.Caster<uint, DateTimeOffset>..cctor
	|
	|-RVA: 0x1AFF940 Offset: 0x1AFDF40 VA: 0x181AFF940
	|-EnumHelper.Caster<uint, Decimal>..cctor
	|
	|-RVA: 0x1B0F0B0 Offset: 0x1B0D6B0 VA: 0x181B0F0B0
	|-EnumHelper.Caster<uint, EmptyStruct>..cctor
	|
	|-RVA: 0x1AFFDE0 Offset: 0x1AFE3E0 VA: 0x181AFFDE0
	|-EnumHelper.Caster<uint, double>..cctor
	|
	|-RVA: 0x1AFEDB0 Offset: 0x1AFD3B0 VA: 0x181AFEDB0
	|-EnumHelper.Caster<uint, Guid>..cctor
	|
	|-RVA: 0x1AF7320 Offset: 0x1AF5920 VA: 0x181AF7320
	|-EnumHelper.Caster<uint, short>..cctor
	|
	|-RVA: 0x1AFAF40 Offset: 0x1AF9540 VA: 0x181AFAF40
	|-EnumHelper.Caster<uint, int>..cctor
	|
	|-RVA: 0x1B004D0 Offset: 0x1AFEAD0 VA: 0x181B004D0
	|-EnumHelper.Caster<uint, long>..cctor
	|
	|-RVA: 0x1B04590 Offset: 0x1B02B90 VA: 0x181B04590
	|-EnumHelper.Caster<uint, IntPtr>..cctor
	|
	|-RVA: 0x1B0BDD0 Offset: 0x1B0A3D0 VA: 0x181B0BDD0
	|-EnumHelper.Caster<uint, object>..cctor
	|
	|-RVA: 0x1AF8100 Offset: 0x1AF6700 VA: 0x181AF8100
	|-EnumHelper.Caster<uint, sbyte>..cctor
	|
	|-RVA: 0x1B0DE30 Offset: 0x1B0C430 VA: 0x181B0DE30
	|-EnumHelper.Caster<uint, float>..cctor
	|
	|-RVA: 0x1AFA160 Offset: 0x1AF8760 VA: 0x181AFA160
	|-EnumHelper.Caster<uint, TimeSpan>..cctor
	|
	|-RVA: 0x1AFE470 Offset: 0x1AFCA70 VA: 0x181AFE470
	|-EnumHelper.Caster<uint, ushort>..cctor
	|
	|-RVA: 0x1AF6540 Offset: 0x1AF4B40 VA: 0x181AF6540
	|-EnumHelper.Caster<uint, uint>..cctor
	|
	|-RVA: 0x1AF77C0 Offset: 0x1AF5DC0 VA: 0x181AF77C0
	|-EnumHelper.Caster<uint, ulong>..cctor
	|
	|-RVA: 0x1AFA600 Offset: 0x1AF8C00 VA: 0x181AFA600
	|-EnumHelper.Caster<uint, UIntPtr>..cctor
	|
	|-RVA: 0x1B0D740 Offset: 0x1B0BD40 VA: 0x181B0D740
	|-EnumHelper.Caster<ulong, bool>..cctor
	|
	|-RVA: 0x1B0BB80 Offset: 0x1B0A180 VA: 0x181B0BB80
	|-EnumHelper.Caster<ulong, byte>..cctor
	|
	|-RVA: 0x1B0D2A0 Offset: 0x1B0B8A0 VA: 0x181B0D2A0
	|-EnumHelper.Caster<ulong, char>..cctor
	|
	|-RVA: 0x1B088A0 Offset: 0x1B06EA0 VA: 0x181B088A0
	|-EnumHelper.Caster<ulong, KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x1AFF250 Offset: 0x1AFD850 VA: 0x181AFF250
	|-EnumHelper.Caster<ulong, DateTime>..cctor
	|
	|-RVA: 0x1B07D10 Offset: 0x1B06310 VA: 0x181B07D10
	|-EnumHelper.Caster<ulong, DateTimeOffset>..cctor
	|
	|-RVA: 0x1B055C0 Offset: 0x1B03BC0 VA: 0x181B055C0
	|-EnumHelper.Caster<ulong, Decimal>..cctor
	|
	|-RVA: 0x1AF8A40 Offset: 0x1AF7040 VA: 0x181AF8A40
	|-EnumHelper.Caster<ulong, EmptyStruct>..cctor
	|
	|-RVA: 0x1B0CBB0 Offset: 0x1B0B1B0 VA: 0x181B0CBB0
	|-EnumHelper.Caster<ulong, double>..cctor
	|
	|-RVA: 0x1AF9820 Offset: 0x1AF7E20 VA: 0x181AF9820
	|-EnumHelper.Caster<ulong, Guid>..cctor
	|
	|-RVA: 0x1B09B20 Offset: 0x1B08120 VA: 0x181B09B20
	|-EnumHelper.Caster<ulong, short>..cctor
	|
	|-RVA: 0x1B0D4F0 Offset: 0x1B0BAF0 VA: 0x181B0D4F0
	|-EnumHelper.Caster<ulong, int>..cctor
	|
	|-RVA: 0x1AFCB00 Offset: 0x1AFB100 VA: 0x181AFCB00
	|-EnumHelper.Caster<ulong, long>..cctor
	|
	|-RVA: 0x1B07180 Offset: 0x1B05780 VA: 0x181B07180
	|-EnumHelper.Caster<ulong, IntPtr>..cctor
	|
	|-RVA: 0x1B03310 Offset: 0x1B01910 VA: 0x181B03310
	|-EnumHelper.Caster<ulong, object>..cctor
	|
	|-RVA: 0x1B0EC10 Offset: 0x1B0D210 VA: 0x181B0EC10
	|-EnumHelper.Caster<ulong, sbyte>..cctor
	|
	|-RVA: 0x1AFBAD0 Offset: 0x1AFA0D0 VA: 0x181AFBAD0
	|-EnumHelper.Caster<ulong, float>..cctor
	|
	|-RVA: 0x1B01060 Offset: 0x1AFF660 VA: 0x181B01060
	|-EnumHelper.Caster<ulong, TimeSpan>..cctor
	|
	|-RVA: 0x1B03C50 Offset: 0x1B02250 VA: 0x181B03C50
	|-EnumHelper.Caster<ulong, ushort>..cctor
	|
	|-RVA: 0x1B08D40 Offset: 0x1B07340 VA: 0x181B08D40
	|-EnumHelper.Caster<ulong, uint>..cctor
	|
	|-RVA: 0x1B0E2D0 Offset: 0x1B0C8D0 VA: 0x181B0E2D0
	|-EnumHelper.Caster<ulong, ulong>..cctor
	|
	|-RVA: 0x1B02C20 Offset: 0x1B01220 VA: 0x181B02C20
	|-EnumHelper.Caster<ulong, UIntPtr>..cctor
	*/

}

internal sealed class EnumerableTypeInfo<IterableType, ElementType> : TraceLoggingTypeInfo<IterableType> // TypeDefIndex: 1514
{	private readonly TraceLoggingTypeInfo<ElementType> elementInfo; // 0x0


	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B4E970 Offset: 0x1B4CF70 VA: 0x181B4E970
	|-EnumerableTypeInfo<object, object>.WriteMetadata
	*/

	public override void WriteData(TraceLoggingDataCollector collector, ref IterableType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B4E650 Offset: 0x1B4CC50 VA: 0x181B4E650
	|-EnumerableTypeInfo<object, object>.WriteData
	*/

}

internal sealed class EnumByteTypeInfo<EnumType> : TraceLoggingTypeInfo<EnumType> // TypeDefIndex: 1560
{
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B13170 Offset: 0x1B11770 VA: 0x181B13170
	|-EnumByteTypeInfo<bool>.WriteMetadata
	|
	|-RVA: 0x1B13440 Offset: 0x1B11A40 VA: 0x181B13440
	|-EnumByteTypeInfo<byte>.WriteMetadata
	|
	|-RVA: 0x1B133B0 Offset: 0x1B119B0 VA: 0x181B133B0
	|-EnumByteTypeInfo<char>.WriteMetadata
	|
	|-RVA: 0x1B13680 Offset: 0x1B11C80 VA: 0x181B13680
	|-EnumByteTypeInfo<KeyValuePair<object, object>>.WriteMetadata
	|
	|-RVA: 0x1B137A0 Offset: 0x1B11DA0 VA: 0x181B137A0
	|-EnumByteTypeInfo<DateTime>.WriteMetadata
	|
	|-RVA: 0x1B13560 Offset: 0x1B11B60 VA: 0x181B13560
	|-EnumByteTypeInfo<DateTimeOffset>.WriteMetadata
	|
	|-RVA: 0x1B134D0 Offset: 0x1B11AD0 VA: 0x181B134D0
	|-EnumByteTypeInfo<Decimal>.WriteMetadata
	|
	|-RVA: 0x1B13830 Offset: 0x1B11E30 VA: 0x181B13830
	|-EnumByteTypeInfo<EmptyStruct>.WriteMetadata
	|
	|-RVA: 0x1B135F0 Offset: 0x1B11BF0 VA: 0x181B135F0
	|-EnumByteTypeInfo<double>.WriteMetadata
	|
	|-RVA: 0x1B13200 Offset: 0x1B11800 VA: 0x181B13200
	|-EnumByteTypeInfo<Guid>.WriteMetadata
	|
	|-RVA: 0x1B138C0 Offset: 0x1B11EC0 VA: 0x181B138C0
	|-EnumByteTypeInfo<short>.WriteMetadata
	|
	|-RVA: 0x1B13C20 Offset: 0x1B12220 VA: 0x181B13C20
	|-EnumByteTypeInfo<int>.WriteMetadata
	|
	|-RVA: 0x1B13B90 Offset: 0x1B12190 VA: 0x181B13B90
	|-EnumByteTypeInfo<long>.WriteMetadata
	|
	|-RVA: 0x1B13B00 Offset: 0x1B12100 VA: 0x181B13B00
	|-EnumByteTypeInfo<IntPtr>.WriteMetadata
	|
	|-RVA: 0x1B130E0 Offset: 0x1B116E0 VA: 0x181B130E0
	|-EnumByteTypeInfo<object>.WriteMetadata
	|
	|-RVA: 0x1B139E0 Offset: 0x1B11FE0 VA: 0x181B139E0
	|-EnumByteTypeInfo<sbyte>.WriteMetadata
	|
	|-RVA: 0x1B13290 Offset: 0x1B11890 VA: 0x181B13290
	|-EnumByteTypeInfo<float>.WriteMetadata
	|
	|-RVA: 0x1B13950 Offset: 0x1B11F50 VA: 0x181B13950
	|-EnumByteTypeInfo<TimeSpan>.WriteMetadata
	|
	|-RVA: 0x1B13320 Offset: 0x1B11920 VA: 0x181B13320
	|-EnumByteTypeInfo<ushort>.WriteMetadata
	|
	|-RVA: 0x1B13A70 Offset: 0x1B12070 VA: 0x181B13A70
	|-EnumByteTypeInfo<uint>.WriteMetadata
	|
	|-RVA: 0x1B13CB0 Offset: 0x1B122B0 VA: 0x181B13CB0
	|-EnumByteTypeInfo<ulong>.WriteMetadata
	|
	|-RVA: 0x1B13710 Offset: 0x1B11D10 VA: 0x181B13710
	|-EnumByteTypeInfo<UIntPtr>.WriteMetadata
	*/

	public override void WriteData(TraceLoggingDataCollector collector, ref EnumType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B12500 Offset: 0x1B10B00 VA: 0x181B12500
	|-EnumByteTypeInfo<bool>.WriteData
	|
	|-RVA: 0x1B12BD0 Offset: 0x1B111D0 VA: 0x181B12BD0
	|-EnumByteTypeInfo<byte>.WriteData
	|
	|-RVA: 0x1B12640 Offset: 0x1B10C40 VA: 0x181B12640
	|-EnumByteTypeInfo<char>.WriteData
	|
	|-RVA: 0x1B123B0 Offset: 0x1B109B0 VA: 0x181B123B0
	|-EnumByteTypeInfo<KeyValuePair<object, object>>.WriteData
	|
	|-RVA: 0x1B12A00 Offset: 0x1B11000 VA: 0x181B12A00
	|-EnumByteTypeInfo<DateTime>.WriteData
	|
	|-RVA: 0x1B12300 Offset: 0x1B10900 VA: 0x181B12300
	|-EnumByteTypeInfo<DateTimeOffset>.WriteData
	|
	|-RVA: 0x1B128B0 Offset: 0x1B10EB0 VA: 0x181B128B0
	|-EnumByteTypeInfo<Decimal>.WriteData
	|
	|-RVA: 0x1B12810 Offset: 0x1B10E10 VA: 0x181B12810
	|-EnumByteTypeInfo<EmptyStruct>.WriteData
	|
	|-RVA: 0x1B126E0 Offset: 0x1B10CE0 VA: 0x181B126E0
	|-EnumByteTypeInfo<double>.WriteData
	|
	|-RVA: 0x1B12C70 Offset: 0x1B11270 VA: 0x181B12C70
	|-EnumByteTypeInfo<Guid>.WriteData
	|
	|-RVA: 0x1B125A0 Offset: 0x1B10BA0 VA: 0x181B125A0
	|-EnumByteTypeInfo<short>.WriteData
	|
	|-RVA: 0x1B12780 Offset: 0x1B10D80 VA: 0x181B12780
	|-EnumByteTypeInfo<int>.WriteData
	|
	|-RVA: 0x1B12FA0 Offset: 0x1B115A0 VA: 0x181B12FA0
	|-EnumByteTypeInfo<long>.WriteData
	|
	|-RVA: 0x1B13040 Offset: 0x1B11640 VA: 0x181B13040
	|-EnumByteTypeInfo<IntPtr>.WriteData
	|
	|-RVA: 0x1B12F00 Offset: 0x1B11500 VA: 0x181B12F00
	|-EnumByteTypeInfo<object>.WriteData
	|
	|-RVA: 0x1B12460 Offset: 0x1B10A60 VA: 0x181B12460
	|-EnumByteTypeInfo<sbyte>.WriteData
	|
	|-RVA: 0x1B12DC0 Offset: 0x1B113C0 VA: 0x181B12DC0
	|-EnumByteTypeInfo<float>.WriteData
	|
	|-RVA: 0x1B12D20 Offset: 0x1B11320 VA: 0x181B12D20
	|-EnumByteTypeInfo<TimeSpan>.WriteData
	|
	|-RVA: 0x1B12B30 Offset: 0x1B11130 VA: 0x181B12B30
	|-EnumByteTypeInfo<ushort>.WriteData
	|
	|-RVA: 0x1B12AA0 Offset: 0x1B110A0 VA: 0x181B12AA0
	|-EnumByteTypeInfo<uint>.WriteData
	|
	|-RVA: 0x1B12E60 Offset: 0x1B11460 VA: 0x181B12E60
	|-EnumByteTypeInfo<ulong>.WriteData
	|
	|-RVA: 0x1B12960 Offset: 0x1B10F60 VA: 0x181B12960
	|-EnumByteTypeInfo<UIntPtr>.WriteData
	*/

	public override object GetData(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7D3380 Offset: 0x7D1980 VA: 0x1807D3380
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
	|-RVA: 0x19AD360 Offset: 0x19AB960 VA: 0x1819AD360
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
	|-RVA: 0x2139D40 Offset: 0x2138340 VA: 0x182139D40
	|-EnumSByteTypeInfo<bool>.WriteMetadata
	|
	|-RVA: 0x2139F80 Offset: 0x2138580 VA: 0x182139F80
	|-EnumSByteTypeInfo<byte>.WriteMetadata
	|
	|-RVA: 0x213A2E0 Offset: 0x21388E0 VA: 0x18213A2E0
	|-EnumSByteTypeInfo<char>.WriteMetadata
	|
	|-RVA: 0x213A0A0 Offset: 0x21386A0 VA: 0x18213A0A0
	|-EnumSByteTypeInfo<KeyValuePair<object, object>>.WriteMetadata
	|
	|-RVA: 0x213A370 Offset: 0x2138970 VA: 0x18213A370
	|-EnumSByteTypeInfo<DateTime>.WriteMetadata
	|
	|-RVA: 0x2139CB0 Offset: 0x21382B0 VA: 0x182139CB0
	|-EnumSByteTypeInfo<DateTimeOffset>.WriteMetadata
	|
	|-RVA: 0x213A6D0 Offset: 0x2138CD0 VA: 0x18213A6D0
	|-EnumSByteTypeInfo<Decimal>.WriteMetadata
	|
	|-RVA: 0x213A490 Offset: 0x2138A90 VA: 0x18213A490
	|-EnumSByteTypeInfo<EmptyStruct>.WriteMetadata
	|
	|-RVA: 0x2139B90 Offset: 0x2138190 VA: 0x182139B90
	|-EnumSByteTypeInfo<double>.WriteMetadata
	|
	|-RVA: 0x213A400 Offset: 0x2138A00 VA: 0x18213A400
	|-EnumSByteTypeInfo<Guid>.WriteMetadata
	|
	|-RVA: 0x213A520 Offset: 0x2138B20 VA: 0x18213A520
	|-EnumSByteTypeInfo<short>.WriteMetadata
	|
	|-RVA: 0x2139DD0 Offset: 0x21383D0 VA: 0x182139DD0
	|-EnumSByteTypeInfo<int>.WriteMetadata
	|
	|-RVA: 0x213A130 Offset: 0x2138730 VA: 0x18213A130
	|-EnumSByteTypeInfo<long>.WriteMetadata
	|
	|-RVA: 0x2139C20 Offset: 0x2138220 VA: 0x182139C20
	|-EnumSByteTypeInfo<IntPtr>.WriteMetadata
	|
	|-RVA: 0x213A010 Offset: 0x2138610 VA: 0x18213A010
	|-EnumSByteTypeInfo<object>.WriteMetadata
	|
	|-RVA: 0x213A1C0 Offset: 0x21387C0 VA: 0x18213A1C0
	|-EnumSByteTypeInfo<sbyte>.WriteMetadata
	|
	|-RVA: 0x213A250 Offset: 0x2138850 VA: 0x18213A250
	|-EnumSByteTypeInfo<float>.WriteMetadata
	|
	|-RVA: 0x213A640 Offset: 0x2138C40 VA: 0x18213A640
	|-EnumSByteTypeInfo<TimeSpan>.WriteMetadata
	|
	|-RVA: 0x213A5B0 Offset: 0x2138BB0 VA: 0x18213A5B0
	|-EnumSByteTypeInfo<ushort>.WriteMetadata
	|
	|-RVA: 0x2139E60 Offset: 0x2138460 VA: 0x182139E60
	|-EnumSByteTypeInfo<uint>.WriteMetadata
	|
	|-RVA: 0x2139EF0 Offset: 0x21384F0 VA: 0x182139EF0
	|-EnumSByteTypeInfo<ulong>.WriteMetadata
	|
	|-RVA: 0x1B49700 Offset: 0x1B47D00 VA: 0x181B49700
	|-EnumSByteTypeInfo<UIntPtr>.WriteMetadata
	*/

	public override void WriteData(TraceLoggingDataCollector collector, ref EnumType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2139860 Offset: 0x2137E60 VA: 0x182139860
	|-EnumSByteTypeInfo<bool>.WriteData
	|
	|-RVA: 0x2139A50 Offset: 0x2138050 VA: 0x182139A50
	|-EnumSByteTypeInfo<byte>.WriteData
	|
	|-RVA: 0x2139160 Offset: 0x2137760 VA: 0x182139160
	|-EnumSByteTypeInfo<char>.WriteData
	|
	|-RVA: 0x21393F0 Offset: 0x21379F0 VA: 0x1821393F0
	|-EnumSByteTypeInfo<KeyValuePair<object, object>>.WriteData
	|
	|-RVA: 0x2139900 Offset: 0x2137F00 VA: 0x182139900
	|-EnumSByteTypeInfo<DateTime>.WriteData
	|
	|-RVA: 0x21399A0 Offset: 0x2137FA0 VA: 0x1821399A0
	|-EnumSByteTypeInfo<DateTimeOffset>.WriteData
	|
	|-RVA: 0x21392A0 Offset: 0x21378A0 VA: 0x1821392A0
	|-EnumSByteTypeInfo<Decimal>.WriteData
	|
	|-RVA: 0x2139350 Offset: 0x2137950 VA: 0x182139350
	|-EnumSByteTypeInfo<EmptyStruct>.WriteData
	|
	|-RVA: 0x21397C0 Offset: 0x2137DC0 VA: 0x1821397C0
	|-EnumSByteTypeInfo<double>.WriteData
	|
	|-RVA: 0x21395E0 Offset: 0x2137BE0 VA: 0x1821395E0
	|-EnumSByteTypeInfo<Guid>.WriteData
	|
	|-RVA: 0x2139690 Offset: 0x2137C90 VA: 0x182139690
	|-EnumSByteTypeInfo<short>.WriteData
	|
	|-RVA: 0x2138F90 Offset: 0x2137590 VA: 0x182138F90
	|-EnumSByteTypeInfo<int>.WriteData
	|
	|-RVA: 0x21390C0 Offset: 0x21376C0 VA: 0x1821390C0
	|-EnumSByteTypeInfo<long>.WriteData
	|
	|-RVA: 0x21394A0 Offset: 0x2137AA0 VA: 0x1821394A0
	|-EnumSByteTypeInfo<IntPtr>.WriteData
	|
	|-RVA: 0x2139020 Offset: 0x2137620 VA: 0x182139020
	|-EnumSByteTypeInfo<object>.WriteData
	|
	|-RVA: 0x2138EF0 Offset: 0x21374F0 VA: 0x182138EF0
	|-EnumSByteTypeInfo<sbyte>.WriteData
	|
	|-RVA: 0x2139AF0 Offset: 0x21380F0 VA: 0x182139AF0
	|-EnumSByteTypeInfo<float>.WriteData
	|
	|-RVA: 0x2138E50 Offset: 0x2137450 VA: 0x182138E50
	|-EnumSByteTypeInfo<TimeSpan>.WriteData
	|
	|-RVA: 0x2139540 Offset: 0x2137B40 VA: 0x182139540
	|-EnumSByteTypeInfo<ushort>.WriteData
	|
	|-RVA: 0x2139730 Offset: 0x2137D30 VA: 0x182139730
	|-EnumSByteTypeInfo<uint>.WriteData
	|
	|-RVA: 0x2139200 Offset: 0x2137800 VA: 0x182139200
	|-EnumSByteTypeInfo<ulong>.WriteData
	|
	|-RVA: 0x1B49660 Offset: 0x1B47C60 VA: 0x181B49660
	|-EnumSByteTypeInfo<UIntPtr>.WriteData
	*/

	public override object GetData(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7D3380 Offset: 0x7D1980 VA: 0x1807D3380
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
	|-RVA: 0x19AD360 Offset: 0x19AB960 VA: 0x1819AD360
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
	|-RVA: 0x21353A0 Offset: 0x21339A0 VA: 0x1821353A0
	|-EnumInt16TypeInfo<bool>.WriteMetadata
	|
	|-RVA: 0x2135040 Offset: 0x2133640 VA: 0x182135040
	|-EnumInt16TypeInfo<byte>.WriteMetadata
	|
	|-RVA: 0x21355E0 Offset: 0x2133BE0 VA: 0x1821355E0
	|-EnumInt16TypeInfo<char>.WriteMetadata
	|
	|-RVA: 0x2135160 Offset: 0x2133760 VA: 0x182135160
	|-EnumInt16TypeInfo<KeyValuePair<object, object>>.WriteMetadata
	|
	|-RVA: 0x2135790 Offset: 0x2133D90 VA: 0x182135790
	|-EnumInt16TypeInfo<DateTime>.WriteMetadata
	|
	|-RVA: 0x2135670 Offset: 0x2133C70 VA: 0x182135670
	|-EnumInt16TypeInfo<DateTimeOffset>.WriteMetadata
	|
	|-RVA: 0x2134D70 Offset: 0x2133370 VA: 0x182134D70
	|-EnumInt16TypeInfo<Decimal>.WriteMetadata
	|
	|-RVA: 0x2135940 Offset: 0x2133F40 VA: 0x182135940
	|-EnumInt16TypeInfo<EmptyStruct>.WriteMetadata
	|
	|-RVA: 0x2134FB0 Offset: 0x21335B0 VA: 0x182134FB0
	|-EnumInt16TypeInfo<double>.WriteMetadata
	|
	|-RVA: 0x21358B0 Offset: 0x2133EB0 VA: 0x1821358B0
	|-EnumInt16TypeInfo<Guid>.WriteMetadata
	|
	|-RVA: 0x2135430 Offset: 0x2133A30 VA: 0x182135430
	|-EnumInt16TypeInfo<short>.WriteMetadata
	|
	|-RVA: 0x2135700 Offset: 0x2133D00 VA: 0x182135700
	|-EnumInt16TypeInfo<int>.WriteMetadata
	|
	|-RVA: 0x2135820 Offset: 0x2133E20 VA: 0x182135820
	|-EnumInt16TypeInfo<long>.WriteMetadata
	|
	|-RVA: 0x2134E00 Offset: 0x2133400 VA: 0x182134E00
	|-EnumInt16TypeInfo<IntPtr>.WriteMetadata
	|
	|-RVA: 0x2135550 Offset: 0x2133B50 VA: 0x182135550
	|-EnumInt16TypeInfo<object>.WriteMetadata
	|
	|-RVA: 0x2134F20 Offset: 0x2133520 VA: 0x182134F20
	|-EnumInt16TypeInfo<sbyte>.WriteMetadata
	|
	|-RVA: 0x2135280 Offset: 0x2133880 VA: 0x182135280
	|-EnumInt16TypeInfo<float>.WriteMetadata
	|
	|-RVA: 0x2135310 Offset: 0x2133910 VA: 0x182135310
	|-EnumInt16TypeInfo<TimeSpan>.WriteMetadata
	|
	|-RVA: 0x21351F0 Offset: 0x21337F0 VA: 0x1821351F0
	|-EnumInt16TypeInfo<ushort>.WriteMetadata
	|
	|-RVA: 0x2134E90 Offset: 0x2133490 VA: 0x182134E90
	|-EnumInt16TypeInfo<uint>.WriteMetadata
	|
	|-RVA: 0x21354C0 Offset: 0x2133AC0 VA: 0x1821354C0
	|-EnumInt16TypeInfo<ulong>.WriteMetadata
	|
	|-RVA: 0x21350D0 Offset: 0x21336D0 VA: 0x1821350D0
	|-EnumInt16TypeInfo<UIntPtr>.WriteMetadata
	*/

	public override void WriteData(TraceLoggingDataCollector collector, ref EnumType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2134020 Offset: 0x2132620 VA: 0x182134020
	|-EnumInt16TypeInfo<bool>.WriteData
	|
	|-RVA: 0x2134160 Offset: 0x2132760 VA: 0x182134160
	|-EnumInt16TypeInfo<byte>.WriteData
	|
	|-RVA: 0x2134850 Offset: 0x2132E50 VA: 0x182134850
	|-EnumInt16TypeInfo<char>.WriteData
	|
	|-RVA: 0x2134B80 Offset: 0x2133180 VA: 0x182134B80
	|-EnumInt16TypeInfo<KeyValuePair<object, object>>.WriteData
	|
	|-RVA: 0x21342A0 Offset: 0x21328A0 VA: 0x1821342A0
	|-EnumInt16TypeInfo<DateTime>.WriteData
	|
	|-RVA: 0x21343E0 Offset: 0x21329E0 VA: 0x1821343E0
	|-EnumInt16TypeInfo<DateTimeOffset>.WriteData
	|
	|-RVA: 0x21348F0 Offset: 0x2132EF0 VA: 0x1821348F0
	|-EnumInt16TypeInfo<Decimal>.WriteData
	|
	|-RVA: 0x2134710 Offset: 0x2132D10 VA: 0x182134710
	|-EnumInt16TypeInfo<EmptyStruct>.WriteData
	|
	|-RVA: 0x2134490 Offset: 0x2132A90 VA: 0x182134490
	|-EnumInt16TypeInfo<double>.WriteData
	|
	|-RVA: 0x21349A0 Offset: 0x2132FA0 VA: 0x1821349A0
	|-EnumInt16TypeInfo<Guid>.WriteData
	|
	|-RVA: 0x2134530 Offset: 0x2132B30 VA: 0x182134530
	|-EnumInt16TypeInfo<short>.WriteData
	|
	|-RVA: 0x2133F90 Offset: 0x2132590 VA: 0x182133F90
	|-EnumInt16TypeInfo<int>.WriteData
	|
	|-RVA: 0x2134C30 Offset: 0x2133230 VA: 0x182134C30
	|-EnumInt16TypeInfo<long>.WriteData
	|
	|-RVA: 0x21345D0 Offset: 0x2132BD0 VA: 0x1821345D0
	|-EnumInt16TypeInfo<IntPtr>.WriteData
	|
	|-RVA: 0x2134200 Offset: 0x2132800 VA: 0x182134200
	|-EnumInt16TypeInfo<object>.WriteData
	|
	|-RVA: 0x2134CD0 Offset: 0x21332D0 VA: 0x182134CD0
	|-EnumInt16TypeInfo<sbyte>.WriteData
	|
	|-RVA: 0x2134340 Offset: 0x2132940 VA: 0x182134340
	|-EnumInt16TypeInfo<float>.WriteData
	|
	|-RVA: 0x21347B0 Offset: 0x2132DB0 VA: 0x1821347B0
	|-EnumInt16TypeInfo<TimeSpan>.WriteData
	|
	|-RVA: 0x2134A50 Offset: 0x2133050 VA: 0x182134A50
	|-EnumInt16TypeInfo<ushort>.WriteData
	|
	|-RVA: 0x2134AF0 Offset: 0x21330F0 VA: 0x182134AF0
	|-EnumInt16TypeInfo<uint>.WriteData
	|
	|-RVA: 0x21340C0 Offset: 0x21326C0 VA: 0x1821340C0
	|-EnumInt16TypeInfo<ulong>.WriteData
	|
	|-RVA: 0x2134670 Offset: 0x2132C70 VA: 0x182134670
	|-EnumInt16TypeInfo<UIntPtr>.WriteData
	*/

	public override object GetData(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7D3380 Offset: 0x7D1980 VA: 0x1807D3380
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
	|-RVA: 0x19AD360 Offset: 0x19AB960 VA: 0x1819AD360
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
	|-RVA: 0x1B4AA80 Offset: 0x1B49080 VA: 0x181B4AA80
	|-EnumUInt16TypeInfo<bool>.WriteMetadata
	|
	|-RVA: 0x1B4ABA0 Offset: 0x1B491A0 VA: 0x181B4ABA0
	|-EnumUInt16TypeInfo<byte>.WriteMetadata
	|
	|-RVA: 0x1B4AF90 Offset: 0x1B49590 VA: 0x181B4AF90
	|-EnumUInt16TypeInfo<char>.WriteMetadata
	|
	|-RVA: 0x1B4AE70 Offset: 0x1B49470 VA: 0x181B4AE70
	|-EnumUInt16TypeInfo<KeyValuePair<object, object>>.WriteMetadata
	|
	|-RVA: 0x1B4AC30 Offset: 0x1B49230 VA: 0x181B4AC30
	|-EnumUInt16TypeInfo<DateTime>.WriteMetadata
	|
	|-RVA: 0x1B4A960 Offset: 0x1B48F60 VA: 0x181B4A960
	|-EnumUInt16TypeInfo<DateTimeOffset>.WriteMetadata
	|
	|-RVA: 0x1B4B0B0 Offset: 0x1B496B0 VA: 0x181B4B0B0
	|-EnumUInt16TypeInfo<Decimal>.WriteMetadata
	|
	|-RVA: 0x1B4AD50 Offset: 0x1B49350 VA: 0x181B4AD50
	|-EnumUInt16TypeInfo<EmptyStruct>.WriteMetadata
	|
	|-RVA: 0x1B4A600 Offset: 0x1B48C00 VA: 0x181B4A600
	|-EnumUInt16TypeInfo<double>.WriteMetadata
	|
	|-RVA: 0x1B4A840 Offset: 0x1B48E40 VA: 0x181B4A840
	|-EnumUInt16TypeInfo<Guid>.WriteMetadata
	|
	|-RVA: 0x1B4A690 Offset: 0x1B48C90 VA: 0x181B4A690
	|-EnumUInt16TypeInfo<short>.WriteMetadata
	|
	|-RVA: 0x1B4ACC0 Offset: 0x1B492C0 VA: 0x181B4ACC0
	|-EnumUInt16TypeInfo<int>.WriteMetadata
	|
	|-RVA: 0x1B4A570 Offset: 0x1B48B70 VA: 0x181B4A570
	|-EnumUInt16TypeInfo<long>.WriteMetadata
	|
	|-RVA: 0x1B4A720 Offset: 0x1B48D20 VA: 0x181B4A720
	|-EnumUInt16TypeInfo<IntPtr>.WriteMetadata
	|
	|-RVA: 0x1B4AF00 Offset: 0x1B49500 VA: 0x181B4AF00
	|-EnumUInt16TypeInfo<object>.WriteMetadata
	|
	|-RVA: 0x1B4A7B0 Offset: 0x1B48DB0 VA: 0x181B4A7B0
	|-EnumUInt16TypeInfo<sbyte>.WriteMetadata
	|
	|-RVA: 0x1B4B140 Offset: 0x1B49740 VA: 0x181B4B140
	|-EnumUInt16TypeInfo<float>.WriteMetadata
	|
	|-RVA: 0x1B4A8D0 Offset: 0x1B48ED0 VA: 0x181B4A8D0
	|-EnumUInt16TypeInfo<TimeSpan>.WriteMetadata
	|
	|-RVA: 0x1B4AB10 Offset: 0x1B49110 VA: 0x181B4AB10
	|-EnumUInt16TypeInfo<ushort>.WriteMetadata
	|
	|-RVA: 0x1B4A9F0 Offset: 0x1B48FF0 VA: 0x181B4A9F0
	|-EnumUInt16TypeInfo<uint>.WriteMetadata
	|
	|-RVA: 0x1B4B020 Offset: 0x1B49620 VA: 0x181B4B020
	|-EnumUInt16TypeInfo<ulong>.WriteMetadata
	|
	|-RVA: 0x1B4ADE0 Offset: 0x1B493E0 VA: 0x181B4ADE0
	|-EnumUInt16TypeInfo<UIntPtr>.WriteMetadata
	*/

	public override void WriteData(TraceLoggingDataCollector collector, ref EnumType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B4A050 Offset: 0x1B48650 VA: 0x181B4A050
	|-EnumUInt16TypeInfo<bool>.WriteData
	|
	|-RVA: 0x1B49C00 Offset: 0x1B48200 VA: 0x181B49C00
	|-EnumUInt16TypeInfo<byte>.WriteData
	|
	|-RVA: 0x1B49B60 Offset: 0x1B48160 VA: 0x181B49B60
	|-EnumUInt16TypeInfo<char>.WriteData
	|
	|-RVA: 0x1B4A420 Offset: 0x1B48A20 VA: 0x181B4A420
	|-EnumUInt16TypeInfo<KeyValuePair<object, object>>.WriteData
	|
	|-RVA: 0x1B49DE0 Offset: 0x1B483E0 VA: 0x181B49DE0
	|-EnumUInt16TypeInfo<DateTime>.WriteData
	|
	|-RVA: 0x1B4A0F0 Offset: 0x1B486F0 VA: 0x181B4A0F0
	|-EnumUInt16TypeInfo<DateTimeOffset>.WriteData
	|
	|-RVA: 0x1B498D0 Offset: 0x1B47ED0 VA: 0x181B498D0
	|-EnumUInt16TypeInfo<Decimal>.WriteData
	|
	|-RVA: 0x1B49790 Offset: 0x1B47D90 VA: 0x181B49790
	|-EnumUInt16TypeInfo<EmptyStruct>.WriteData
	|
	|-RVA: 0x1B49D40 Offset: 0x1B48340 VA: 0x181B49D40
	|-EnumUInt16TypeInfo<double>.WriteData
	|
	|-RVA: 0x1B4A240 Offset: 0x1B48840 VA: 0x181B4A240
	|-EnumUInt16TypeInfo<Guid>.WriteData
	|
	|-RVA: 0x1B49CA0 Offset: 0x1B482A0 VA: 0x181B49CA0
	|-EnumUInt16TypeInfo<short>.WriteData
	|
	|-RVA: 0x1B4A2F0 Offset: 0x1B488F0 VA: 0x181B4A2F0
	|-EnumUInt16TypeInfo<int>.WriteData
	|
	|-RVA: 0x1B49980 Offset: 0x1B47F80 VA: 0x181B49980
	|-EnumUInt16TypeInfo<long>.WriteData
	|
	|-RVA: 0x1B49AC0 Offset: 0x1B480C0 VA: 0x181B49AC0
	|-EnumUInt16TypeInfo<IntPtr>.WriteData
	|
	|-RVA: 0x1B4A1A0 Offset: 0x1B487A0 VA: 0x181B4A1A0
	|-EnumUInt16TypeInfo<object>.WriteData
	|
	|-RVA: 0x1B49FB0 Offset: 0x1B485B0 VA: 0x181B49FB0
	|-EnumUInt16TypeInfo<sbyte>.WriteData
	|
	|-RVA: 0x1B4A4D0 Offset: 0x1B48AD0 VA: 0x181B4A4D0
	|-EnumUInt16TypeInfo<float>.WriteData
	|
	|-RVA: 0x1B49A20 Offset: 0x1B48020 VA: 0x181B49A20
	|-EnumUInt16TypeInfo<TimeSpan>.WriteData
	|
	|-RVA: 0x1B4A380 Offset: 0x1B48980 VA: 0x181B4A380
	|-EnumUInt16TypeInfo<ushort>.WriteData
	|
	|-RVA: 0x1B49E80 Offset: 0x1B48480 VA: 0x181B49E80
	|-EnumUInt16TypeInfo<uint>.WriteData
	|
	|-RVA: 0x1B49F10 Offset: 0x1B48510 VA: 0x181B49F10
	|-EnumUInt16TypeInfo<ulong>.WriteData
	|
	|-RVA: 0x1B49830 Offset: 0x1B47E30 VA: 0x181B49830
	|-EnumUInt16TypeInfo<UIntPtr>.WriteData
	*/

	public override object GetData(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7D3380 Offset: 0x7D1980 VA: 0x1807D3380
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
	|-RVA: 0x19AD360 Offset: 0x19AB960 VA: 0x1819AD360
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
	|-RVA: 0x21371D0 Offset: 0x21357D0 VA: 0x1821371D0
	|-EnumInt32TypeInfo<bool>.WriteMetadata
	|
	|-RVA: 0x2137380 Offset: 0x2135980 VA: 0x182137380
	|-EnumInt32TypeInfo<byte>.WriteMetadata
	|
	|-RVA: 0x2137020 Offset: 0x2135620 VA: 0x182137020
	|-EnumInt32TypeInfo<char>.WriteMetadata
	|
	|-RVA: 0x2136DE0 Offset: 0x21353E0 VA: 0x182136DE0
	|-EnumInt32TypeInfo<KeyValuePair<object, object>>.WriteMetadata
	|
	|-RVA: 0x2136960 Offset: 0x2134F60 VA: 0x182136960
	|-EnumInt32TypeInfo<DateTime>.WriteMetadata
	|
	|-RVA: 0x2136C30 Offset: 0x2135230 VA: 0x182136C30
	|-EnumInt32TypeInfo<DateTimeOffset>.WriteMetadata
	|
	|-RVA: 0x2136A80 Offset: 0x2135080 VA: 0x182136A80
	|-EnumInt32TypeInfo<Decimal>.WriteMetadata
	|
	|-RVA: 0x2136E70 Offset: 0x2135470 VA: 0x182136E70
	|-EnumInt32TypeInfo<EmptyStruct>.WriteMetadata
	|
	|-RVA: 0x2136CC0 Offset: 0x21352C0 VA: 0x182136CC0
	|-EnumInt32TypeInfo<double>.WriteMetadata
	|
	|-RVA: 0x2136840 Offset: 0x2134E40 VA: 0x182136840
	|-EnumInt32TypeInfo<Guid>.WriteMetadata
	|
	|-RVA: 0x2136B10 Offset: 0x2135110 VA: 0x182136B10
	|-EnumInt32TypeInfo<short>.WriteMetadata
	|
	|-RVA: 0x2136D50 Offset: 0x2135350 VA: 0x182136D50
	|-EnumInt32TypeInfo<int>.WriteMetadata
	|
	|-RVA: 0x21368D0 Offset: 0x2134ED0 VA: 0x1821368D0
	|-EnumInt32TypeInfo<long>.WriteMetadata
	|
	|-RVA: 0x21369F0 Offset: 0x2134FF0 VA: 0x1821369F0
	|-EnumInt32TypeInfo<IntPtr>.WriteMetadata
	|
	|-RVA: 0x2137260 Offset: 0x2135860 VA: 0x182137260
	|-EnumInt32TypeInfo<object>.WriteMetadata
	|
	|-RVA: 0x2137140 Offset: 0x2135740 VA: 0x182137140
	|-EnumInt32TypeInfo<sbyte>.WriteMetadata
	|
	|-RVA: 0x2136F90 Offset: 0x2135590 VA: 0x182136F90
	|-EnumInt32TypeInfo<float>.WriteMetadata
	|
	|-RVA: 0x21367B0 Offset: 0x2134DB0 VA: 0x1821367B0
	|-EnumInt32TypeInfo<TimeSpan>.WriteMetadata
	|
	|-RVA: 0x2136F00 Offset: 0x2135500 VA: 0x182136F00
	|-EnumInt32TypeInfo<ushort>.WriteMetadata
	|
	|-RVA: 0x21370B0 Offset: 0x21356B0 VA: 0x1821370B0
	|-EnumInt32TypeInfo<uint>.WriteMetadata
	|
	|-RVA: 0x2136BA0 Offset: 0x21351A0 VA: 0x182136BA0
	|-EnumInt32TypeInfo<ulong>.WriteMetadata
	|
	|-RVA: 0x21372F0 Offset: 0x21358F0 VA: 0x1821372F0
	|-EnumInt32TypeInfo<UIntPtr>.WriteMetadata
	*/

	public override void WriteData(TraceLoggingDataCollector collector, ref EnumType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21359D0 Offset: 0x2133FD0 VA: 0x1821359D0
	|-EnumInt32TypeInfo<bool>.WriteData
	|
	|-RVA: 0x2136710 Offset: 0x2134D10 VA: 0x182136710
	|-EnumInt32TypeInfo<byte>.WriteData
	|
	|-RVA: 0x2136670 Offset: 0x2134C70 VA: 0x182136670
	|-EnumInt32TypeInfo<char>.WriteData
	|
	|-RVA: 0x2135B10 Offset: 0x2134110 VA: 0x182135B10
	|-EnumInt32TypeInfo<KeyValuePair<object, object>>.WriteData
	|
	|-RVA: 0x21360E0 Offset: 0x21346E0 VA: 0x1821360E0
	|-EnumInt32TypeInfo<DateTime>.WriteData
	|
	|-RVA: 0x2135EF0 Offset: 0x21344F0 VA: 0x182135EF0
	|-EnumInt32TypeInfo<DateTimeOffset>.WriteData
	|
	|-RVA: 0x2135BC0 Offset: 0x21341C0 VA: 0x182135BC0
	|-EnumInt32TypeInfo<Decimal>.WriteData
	|
	|-RVA: 0x2136180 Offset: 0x2134780 VA: 0x182136180
	|-EnumInt32TypeInfo<EmptyStruct>.WriteData
	|
	|-RVA: 0x2135C70 Offset: 0x2134270 VA: 0x182135C70
	|-EnumInt32TypeInfo<double>.WriteData
	|
	|-RVA: 0x2136490 Offset: 0x2134A90 VA: 0x182136490
	|-EnumInt32TypeInfo<Guid>.WriteData
	|
	|-RVA: 0x2135D10 Offset: 0x2134310 VA: 0x182135D10
	|-EnumInt32TypeInfo<short>.WriteData
	|
	|-RVA: 0x21365E0 Offset: 0x2134BE0 VA: 0x1821365E0
	|-EnumInt32TypeInfo<int>.WriteData
	|
	|-RVA: 0x2135DB0 Offset: 0x21343B0 VA: 0x182135DB0
	|-EnumInt32TypeInfo<long>.WriteData
	|
	|-RVA: 0x2136540 Offset: 0x2134B40 VA: 0x182136540
	|-EnumInt32TypeInfo<IntPtr>.WriteData
	|
	|-RVA: 0x2136360 Offset: 0x2134960 VA: 0x182136360
	|-EnumInt32TypeInfo<object>.WriteData
	|
	|-RVA: 0x2135A70 Offset: 0x2134070 VA: 0x182135A70
	|-EnumInt32TypeInfo<sbyte>.WriteData
	|
	|-RVA: 0x2136040 Offset: 0x2134640 VA: 0x182136040
	|-EnumInt32TypeInfo<float>.WriteData
	|
	|-RVA: 0x2136220 Offset: 0x2134820 VA: 0x182136220
	|-EnumInt32TypeInfo<TimeSpan>.WriteData
	|
	|-RVA: 0x21362C0 Offset: 0x21348C0 VA: 0x1821362C0
	|-EnumInt32TypeInfo<ushort>.WriteData
	|
	|-RVA: 0x2136400 Offset: 0x2134A00 VA: 0x182136400
	|-EnumInt32TypeInfo<uint>.WriteData
	|
	|-RVA: 0x2135FA0 Offset: 0x21345A0 VA: 0x182135FA0
	|-EnumInt32TypeInfo<ulong>.WriteData
	|
	|-RVA: 0x2135E50 Offset: 0x2134450 VA: 0x182135E50
	|-EnumInt32TypeInfo<UIntPtr>.WriteData
	*/

	public override object GetData(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7D3380 Offset: 0x7D1980 VA: 0x1807D3380
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
	|-RVA: 0x19AD360 Offset: 0x19AB960 VA: 0x1819AD360
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
	|-RVA: 0x1B4C820 Offset: 0x1B4AE20 VA: 0x181B4C820
	|-EnumUInt32TypeInfo<bool>.WriteMetadata
	|
	|-RVA: 0x1B4C040 Offset: 0x1B4A640 VA: 0x181B4C040
	|-EnumUInt32TypeInfo<byte>.WriteMetadata
	|
	|-RVA: 0x1B4C550 Offset: 0x1B4AB50 VA: 0x181B4C550
	|-EnumUInt32TypeInfo<char>.WriteMetadata
	|
	|-RVA: 0x1B4C4C0 Offset: 0x1B4AAC0 VA: 0x181B4C4C0
	|-EnumUInt32TypeInfo<KeyValuePair<object, object>>.WriteMetadata
	|
	|-RVA: 0x1B4C670 Offset: 0x1B4AC70 VA: 0x181B4C670
	|-EnumUInt32TypeInfo<DateTime>.WriteMetadata
	|
	|-RVA: 0x1B4C160 Offset: 0x1B4A760 VA: 0x181B4C160
	|-EnumUInt32TypeInfo<DateTimeOffset>.WriteMetadata
	|
	|-RVA: 0x1B4BFB0 Offset: 0x1B4A5B0 VA: 0x181B4BFB0
	|-EnumUInt32TypeInfo<Decimal>.WriteMetadata
	|
	|-RVA: 0x1B4C0D0 Offset: 0x1B4A6D0 VA: 0x181B4C0D0
	|-EnumUInt32TypeInfo<EmptyStruct>.WriteMetadata
	|
	|-RVA: 0x1B4CA60 Offset: 0x1B4B060 VA: 0x181B4CA60
	|-EnumUInt32TypeInfo<double>.WriteMetadata
	|
	|-RVA: 0x1B4C430 Offset: 0x1B4AA30 VA: 0x181B4C430
	|-EnumUInt32TypeInfo<Guid>.WriteMetadata
	|
	|-RVA: 0x1B4C700 Offset: 0x1B4AD00 VA: 0x181B4C700
	|-EnumUInt32TypeInfo<short>.WriteMetadata
	|
	|-RVA: 0x1B4C940 Offset: 0x1B4AF40 VA: 0x181B4C940
	|-EnumUInt32TypeInfo<int>.WriteMetadata
	|
	|-RVA: 0x1B4C8B0 Offset: 0x1B4AEB0 VA: 0x181B4C8B0
	|-EnumUInt32TypeInfo<long>.WriteMetadata
	|
	|-RVA: 0x1B4C3A0 Offset: 0x1B4A9A0 VA: 0x181B4C3A0
	|-EnumUInt32TypeInfo<IntPtr>.WriteMetadata
	|
	|-RVA: 0x1B4C280 Offset: 0x1B4A880 VA: 0x181B4C280
	|-EnumUInt32TypeInfo<object>.WriteMetadata
	|
	|-RVA: 0x1B4CB80 Offset: 0x1B4B180 VA: 0x181B4CB80
	|-EnumUInt32TypeInfo<sbyte>.WriteMetadata
	|
	|-RVA: 0x1B4C5E0 Offset: 0x1B4ABE0 VA: 0x181B4C5E0
	|-EnumUInt32TypeInfo<float>.WriteMetadata
	|
	|-RVA: 0x1B4C9D0 Offset: 0x1B4AFD0 VA: 0x181B4C9D0
	|-EnumUInt32TypeInfo<TimeSpan>.WriteMetadata
	|
	|-RVA: 0x1B4C310 Offset: 0x1B4A910 VA: 0x181B4C310
	|-EnumUInt32TypeInfo<ushort>.WriteMetadata
	|
	|-RVA: 0x1B4CAF0 Offset: 0x1B4B0F0 VA: 0x181B4CAF0
	|-EnumUInt32TypeInfo<uint>.WriteMetadata
	|
	|-RVA: 0x1B4C1F0 Offset: 0x1B4A7F0 VA: 0x181B4C1F0
	|-EnumUInt32TypeInfo<ulong>.WriteMetadata
	|
	|-RVA: 0x1B4C790 Offset: 0x1B4AD90 VA: 0x181B4C790
	|-EnumUInt32TypeInfo<UIntPtr>.WriteMetadata
	*/

	public override void WriteData(TraceLoggingDataCollector collector, ref EnumType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B4BBE0 Offset: 0x1B4A1E0 VA: 0x181B4BBE0
	|-EnumUInt32TypeInfo<bool>.WriteData
	|
	|-RVA: 0x1B4B8A0 Offset: 0x1B49EA0 VA: 0x181B4B8A0
	|-EnumUInt32TypeInfo<byte>.WriteData
	|
	|-RVA: 0x1B4B610 Offset: 0x1B49C10 VA: 0x181B4B610
	|-EnumUInt32TypeInfo<char>.WriteData
	|
	|-RVA: 0x1B4BB30 Offset: 0x1B4A130 VA: 0x181B4BB30
	|-EnumUInt32TypeInfo<KeyValuePair<object, object>>.WriteData
	|
	|-RVA: 0x1B4B1D0 Offset: 0x1B497D0 VA: 0x181B4B1D0
	|-EnumUInt32TypeInfo<DateTime>.WriteData
	|
	|-RVA: 0x1B4BDC0 Offset: 0x1B4A3C0 VA: 0x181B4BDC0
	|-EnumUInt32TypeInfo<DateTimeOffset>.WriteData
	|
	|-RVA: 0x1B4BA80 Offset: 0x1B4A080 VA: 0x181B4BA80
	|-EnumUInt32TypeInfo<Decimal>.WriteData
	|
	|-RVA: 0x1B4B430 Offset: 0x1B49A30 VA: 0x181B4B430
	|-EnumUInt32TypeInfo<EmptyStruct>.WriteData
	|
	|-RVA: 0x1B4BC80 Offset: 0x1B4A280 VA: 0x181B4BC80
	|-EnumUInt32TypeInfo<double>.WriteData
	|
	|-RVA: 0x1B4B6B0 Offset: 0x1B49CB0 VA: 0x181B4B6B0
	|-EnumUInt32TypeInfo<Guid>.WriteData
	|
	|-RVA: 0x1B4B270 Offset: 0x1B49870 VA: 0x181B4B270
	|-EnumUInt32TypeInfo<short>.WriteData
	|
	|-RVA: 0x1B4B3A0 Offset: 0x1B499A0 VA: 0x181B4B3A0
	|-EnumUInt32TypeInfo<int>.WriteData
	|
	|-RVA: 0x1B4B760 Offset: 0x1B49D60 VA: 0x181B4B760
	|-EnumUInt32TypeInfo<long>.WriteData
	|
	|-RVA: 0x1B4BE70 Offset: 0x1B4A470 VA: 0x181B4BE70
	|-EnumUInt32TypeInfo<IntPtr>.WriteData
	|
	|-RVA: 0x1B4BD20 Offset: 0x1B4A320 VA: 0x181B4BD20
	|-EnumUInt32TypeInfo<object>.WriteData
	|
	|-RVA: 0x1B4B570 Offset: 0x1B49B70 VA: 0x181B4B570
	|-EnumUInt32TypeInfo<sbyte>.WriteData
	|
	|-RVA: 0x1B4B800 Offset: 0x1B49E00 VA: 0x181B4B800
	|-EnumUInt32TypeInfo<float>.WriteData
	|
	|-RVA: 0x1B4BF10 Offset: 0x1B4A510 VA: 0x181B4BF10
	|-EnumUInt32TypeInfo<TimeSpan>.WriteData
	|
	|-RVA: 0x1B4B4D0 Offset: 0x1B49AD0 VA: 0x181B4B4D0
	|-EnumUInt32TypeInfo<ushort>.WriteData
	|
	|-RVA: 0x1B4B310 Offset: 0x1B49910 VA: 0x181B4B310
	|-EnumUInt32TypeInfo<uint>.WriteData
	|
	|-RVA: 0x1B4B940 Offset: 0x1B49F40 VA: 0x181B4B940
	|-EnumUInt32TypeInfo<ulong>.WriteData
	|
	|-RVA: 0x1B4B9E0 Offset: 0x1B49FE0 VA: 0x181B4B9E0
	|-EnumUInt32TypeInfo<UIntPtr>.WriteData
	*/

	public override object GetData(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7D3380 Offset: 0x7D1980 VA: 0x1807D3380
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
	|-RVA: 0x19AD360 Offset: 0x19AB960 VA: 0x1819AD360
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
	|-RVA: 0x2138430 Offset: 0x2136A30 VA: 0x182138430
	|-EnumInt64TypeInfo<bool>.WriteMetadata
	|
	|-RVA: 0x2138790 Offset: 0x2136D90 VA: 0x182138790
	|-EnumInt64TypeInfo<byte>.WriteMetadata
	|
	|-RVA: 0x2138940 Offset: 0x2136F40 VA: 0x182138940
	|-EnumInt64TypeInfo<char>.WriteMetadata
	|
	|-RVA: 0x2138700 Offset: 0x2136D00 VA: 0x182138700
	|-EnumInt64TypeInfo<KeyValuePair<object, object>>.WriteMetadata
	|
	|-RVA: 0x21384C0 Offset: 0x2136AC0 VA: 0x1821384C0
	|-EnumInt64TypeInfo<DateTime>.WriteMetadata
	|
	|-RVA: 0x2138CA0 Offset: 0x21372A0 VA: 0x182138CA0
	|-EnumInt64TypeInfo<DateTimeOffset>.WriteMetadata
	|
	|-RVA: 0x21383A0 Offset: 0x21369A0 VA: 0x1821383A0
	|-EnumInt64TypeInfo<Decimal>.WriteMetadata
	|
	|-RVA: 0x2138280 Offset: 0x2136880 VA: 0x182138280
	|-EnumInt64TypeInfo<EmptyStruct>.WriteMetadata
	|
	|-RVA: 0x2138670 Offset: 0x2136C70 VA: 0x182138670
	|-EnumInt64TypeInfo<double>.WriteMetadata
	|
	|-RVA: 0x2138820 Offset: 0x2136E20 VA: 0x182138820
	|-EnumInt64TypeInfo<Guid>.WriteMetadata
	|
	|-RVA: 0x2138A60 Offset: 0x2137060 VA: 0x182138A60
	|-EnumInt64TypeInfo<short>.WriteMetadata
	|
	|-RVA: 0x21381F0 Offset: 0x21367F0 VA: 0x1821381F0
	|-EnumInt64TypeInfo<int>.WriteMetadata
	|
	|-RVA: 0x21385E0 Offset: 0x2136BE0 VA: 0x1821385E0
	|-EnumInt64TypeInfo<long>.WriteMetadata
	|
	|-RVA: 0x2138D30 Offset: 0x2137330 VA: 0x182138D30
	|-EnumInt64TypeInfo<IntPtr>.WriteMetadata
	|
	|-RVA: 0x21389D0 Offset: 0x2136FD0 VA: 0x1821389D0
	|-EnumInt64TypeInfo<object>.WriteMetadata
	|
	|-RVA: 0x2138AF0 Offset: 0x21370F0 VA: 0x182138AF0
	|-EnumInt64TypeInfo<sbyte>.WriteMetadata
	|
	|-RVA: 0x2138550 Offset: 0x2136B50 VA: 0x182138550
	|-EnumInt64TypeInfo<float>.WriteMetadata
	|
	|-RVA: 0x2138DC0 Offset: 0x21373C0 VA: 0x182138DC0
	|-EnumInt64TypeInfo<TimeSpan>.WriteMetadata
	|
	|-RVA: 0x2138C10 Offset: 0x2137210 VA: 0x182138C10
	|-EnumInt64TypeInfo<ushort>.WriteMetadata
	|
	|-RVA: 0x2138310 Offset: 0x2136910 VA: 0x182138310
	|-EnumInt64TypeInfo<uint>.WriteMetadata
	|
	|-RVA: 0x2138B80 Offset: 0x2137180 VA: 0x182138B80
	|-EnumInt64TypeInfo<ulong>.WriteMetadata
	|
	|-RVA: 0x21388B0 Offset: 0x2136EB0 VA: 0x1821388B0
	|-EnumInt64TypeInfo<UIntPtr>.WriteMetadata
	*/

	public override void WriteData(TraceLoggingDataCollector collector, ref EnumType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2137F60 Offset: 0x2136560 VA: 0x182137F60
	|-EnumInt64TypeInfo<bool>.WriteData
	|
	|-RVA: 0x2137750 Offset: 0x2135D50 VA: 0x182137750
	|-EnumInt64TypeInfo<byte>.WriteData
	|
	|-RVA: 0x2137C50 Offset: 0x2136250 VA: 0x182137C50
	|-EnumInt64TypeInfo<char>.WriteData
	|
	|-RVA: 0x21380A0 Offset: 0x21366A0 VA: 0x1821380A0
	|-EnumInt64TypeInfo<KeyValuePair<object, object>>.WriteData
	|
	|-RVA: 0x21377F0 Offset: 0x2135DF0 VA: 0x1821377F0
	|-EnumInt64TypeInfo<DateTime>.WriteData
	|
	|-RVA: 0x21376A0 Offset: 0x2135CA0 VA: 0x1821376A0
	|-EnumInt64TypeInfo<DateTimeOffset>.WriteData
	|
	|-RVA: 0x2137A60 Offset: 0x2136060 VA: 0x182137A60
	|-EnumInt64TypeInfo<Decimal>.WriteData
	|
	|-RVA: 0x2137560 Offset: 0x2135B60 VA: 0x182137560
	|-EnumInt64TypeInfo<EmptyStruct>.WriteData
	|
	|-RVA: 0x2138150 Offset: 0x2136750 VA: 0x182138150
	|-EnumInt64TypeInfo<double>.WriteData
	|
	|-RVA: 0x21374B0 Offset: 0x2135AB0 VA: 0x1821374B0
	|-EnumInt64TypeInfo<Guid>.WriteData
	|
	|-RVA: 0x2137E20 Offset: 0x2136420 VA: 0x182137E20
	|-EnumInt64TypeInfo<short>.WriteData
	|
	|-RVA: 0x2137CF0 Offset: 0x21362F0 VA: 0x182137CF0
	|-EnumInt64TypeInfo<int>.WriteData
	|
	|-RVA: 0x21379C0 Offset: 0x2135FC0 VA: 0x1821379C0
	|-EnumInt64TypeInfo<long>.WriteData
	|
	|-RVA: 0x2137D80 Offset: 0x2136380 VA: 0x182137D80
	|-EnumInt64TypeInfo<IntPtr>.WriteData
	|
	|-RVA: 0x2137410 Offset: 0x2135A10 VA: 0x182137410
	|-EnumInt64TypeInfo<object>.WriteData
	|
	|-RVA: 0x2137EC0 Offset: 0x21364C0 VA: 0x182137EC0
	|-EnumInt64TypeInfo<sbyte>.WriteData
	|
	|-RVA: 0x2138000 Offset: 0x2136600 VA: 0x182138000
	|-EnumInt64TypeInfo<float>.WriteData
	|
	|-RVA: 0x2137600 Offset: 0x2135C00 VA: 0x182137600
	|-EnumInt64TypeInfo<TimeSpan>.WriteData
	|
	|-RVA: 0x2137BB0 Offset: 0x21361B0 VA: 0x182137BB0
	|-EnumInt64TypeInfo<ushort>.WriteData
	|
	|-RVA: 0x2137930 Offset: 0x2135F30 VA: 0x182137930
	|-EnumInt64TypeInfo<uint>.WriteData
	|
	|-RVA: 0x2137890 Offset: 0x2135E90 VA: 0x182137890
	|-EnumInt64TypeInfo<ulong>.WriteData
	|
	|-RVA: 0x2137B10 Offset: 0x2136110 VA: 0x182137B10
	|-EnumInt64TypeInfo<UIntPtr>.WriteData
	*/

	public override object GetData(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7D3380 Offset: 0x7D1980 VA: 0x1807D3380
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
	|-RVA: 0x19AD360 Offset: 0x19AB960 VA: 0x1819AD360
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
	|-RVA: 0x1B4E530 Offset: 0x1B4CB30 VA: 0x181B4E530
	|-EnumUInt64TypeInfo<bool>.WriteMetadata
	|
	|-RVA: 0x1B4DF00 Offset: 0x1B4C500 VA: 0x181B4DF00
	|-EnumUInt64TypeInfo<byte>.WriteMetadata
	|
	|-RVA: 0x1B4DC30 Offset: 0x1B4C230 VA: 0x181B4DC30
	|-EnumUInt64TypeInfo<char>.WriteMetadata
	|
	|-RVA: 0x1B4E380 Offset: 0x1B4C980 VA: 0x181B4E380
	|-EnumUInt64TypeInfo<KeyValuePair<object, object>>.WriteMetadata
	|
	|-RVA: 0x1B4E410 Offset: 0x1B4CA10 VA: 0x181B4E410
	|-EnumUInt64TypeInfo<DateTime>.WriteMetadata
	|
	|-RVA: 0x1B4DD50 Offset: 0x1B4C350 VA: 0x181B4DD50
	|-EnumUInt64TypeInfo<DateTimeOffset>.WriteMetadata
	|
	|-RVA: 0x1B4DB10 Offset: 0x1B4C110 VA: 0x181B4DB10
	|-EnumUInt64TypeInfo<Decimal>.WriteMetadata
	|
	|-RVA: 0x1B4DBA0 Offset: 0x1B4C1A0 VA: 0x181B4DBA0
	|-EnumUInt64TypeInfo<EmptyStruct>.WriteMetadata
	|
	|-RVA: 0x1B4E2F0 Offset: 0x1B4C8F0 VA: 0x181B4E2F0
	|-EnumUInt64TypeInfo<double>.WriteMetadata
	|
	|-RVA: 0x1B4DE70 Offset: 0x1B4C470 VA: 0x181B4DE70
	|-EnumUInt64TypeInfo<Guid>.WriteMetadata
	|
	|-RVA: 0x1B4E260 Offset: 0x1B4C860 VA: 0x181B4E260
	|-EnumUInt64TypeInfo<short>.WriteMetadata
	|
	|-RVA: 0x1B4E0B0 Offset: 0x1B4C6B0 VA: 0x181B4E0B0
	|-EnumUInt64TypeInfo<int>.WriteMetadata
	|
	|-RVA: 0x1B4E5C0 Offset: 0x1B4CBC0 VA: 0x181B4E5C0
	|-EnumUInt64TypeInfo<long>.WriteMetadata
	|
	|-RVA: 0x1B4E1D0 Offset: 0x1B4C7D0 VA: 0x181B4E1D0
	|-EnumUInt64TypeInfo<IntPtr>.WriteMetadata
	|
	|-RVA: 0x1B4D9F0 Offset: 0x1B4BFF0 VA: 0x181B4D9F0
	|-EnumUInt64TypeInfo<object>.WriteMetadata
	|
	|-RVA: 0x1B4DCC0 Offset: 0x1B4C2C0 VA: 0x181B4DCC0
	|-EnumUInt64TypeInfo<sbyte>.WriteMetadata
	|
	|-RVA: 0x1B4E4A0 Offset: 0x1B4CAA0 VA: 0x181B4E4A0
	|-EnumUInt64TypeInfo<float>.WriteMetadata
	|
	|-RVA: 0x1B4E140 Offset: 0x1B4C740 VA: 0x181B4E140
	|-EnumUInt64TypeInfo<TimeSpan>.WriteMetadata
	|
	|-RVA: 0x1B4DF90 Offset: 0x1B4C590 VA: 0x181B4DF90
	|-EnumUInt64TypeInfo<ushort>.WriteMetadata
	|
	|-RVA: 0x1B4DDE0 Offset: 0x1B4C3E0 VA: 0x181B4DDE0
	|-EnumUInt64TypeInfo<uint>.WriteMetadata
	|
	|-RVA: 0x1B4DA80 Offset: 0x1B4C080 VA: 0x181B4DA80
	|-EnumUInt64TypeInfo<ulong>.WriteMetadata
	|
	|-RVA: 0x1B4E020 Offset: 0x1B4C620 VA: 0x181B4E020
	|-EnumUInt64TypeInfo<UIntPtr>.WriteMetadata
	*/

	public override void WriteData(TraceLoggingDataCollector collector, ref EnumType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B4CE90 Offset: 0x1B4B490 VA: 0x181B4CE90
	|-EnumUInt64TypeInfo<bool>.WriteData
	|
	|-RVA: 0x1B4D080 Offset: 0x1B4B680 VA: 0x181B4D080
	|-EnumUInt64TypeInfo<byte>.WriteData
	|
	|-RVA: 0x1B4CDF0 Offset: 0x1B4B3F0 VA: 0x181B4CDF0
	|-EnumUInt64TypeInfo<char>.WriteData
	|
	|-RVA: 0x1B4D6A0 Offset: 0x1B4BCA0 VA: 0x181B4D6A0
	|-EnumUInt64TypeInfo<KeyValuePair<object, object>>.WriteData
	|
	|-RVA: 0x1B4D600 Offset: 0x1B4BC00 VA: 0x181B4D600
	|-EnumUInt64TypeInfo<DateTime>.WriteData
	|
	|-RVA: 0x1B4CF30 Offset: 0x1B4B530 VA: 0x181B4CF30
	|-EnumUInt64TypeInfo<DateTimeOffset>.WriteData
	|
	|-RVA: 0x1B4D8A0 Offset: 0x1B4BEA0 VA: 0x181B4D8A0
	|-EnumUInt64TypeInfo<Decimal>.WriteData
	|
	|-RVA: 0x1B4D560 Offset: 0x1B4BB60 VA: 0x181B4D560
	|-EnumUInt64TypeInfo<EmptyStruct>.WriteData
	|
	|-RVA: 0x1B4D390 Offset: 0x1B4B990 VA: 0x181B4D390
	|-EnumUInt64TypeInfo<double>.WriteData
	|
	|-RVA: 0x1B4D750 Offset: 0x1B4BD50 VA: 0x181B4D750
	|-EnumUInt64TypeInfo<Guid>.WriteData
	|
	|-RVA: 0x1B4CFE0 Offset: 0x1B4B5E0 VA: 0x181B4CFE0
	|-EnumUInt64TypeInfo<short>.WriteData
	|
	|-RVA: 0x1B4D260 Offset: 0x1B4B860 VA: 0x181B4D260
	|-EnumUInt64TypeInfo<int>.WriteData
	|
	|-RVA: 0x1B4D120 Offset: 0x1B4B720 VA: 0x181B4D120
	|-EnumUInt64TypeInfo<long>.WriteData
	|
	|-RVA: 0x1B4D950 Offset: 0x1B4BF50 VA: 0x181B4D950
	|-EnumUInt64TypeInfo<IntPtr>.WriteData
	|
	|-RVA: 0x1B4D800 Offset: 0x1B4BE00 VA: 0x181B4D800
	|-EnumUInt64TypeInfo<object>.WriteData
	|
	|-RVA: 0x1B4D1C0 Offset: 0x1B4B7C0 VA: 0x181B4D1C0
	|-EnumUInt64TypeInfo<sbyte>.WriteData
	|
	|-RVA: 0x1B4CD50 Offset: 0x1B4B350 VA: 0x181B4CD50
	|-EnumUInt64TypeInfo<float>.WriteData
	|
	|-RVA: 0x1B4D2F0 Offset: 0x1B4B8F0 VA: 0x181B4D2F0
	|-EnumUInt64TypeInfo<TimeSpan>.WriteData
	|
	|-RVA: 0x1B4D430 Offset: 0x1B4BA30 VA: 0x181B4D430
	|-EnumUInt64TypeInfo<ushort>.WriteData
	|
	|-RVA: 0x1B4D4D0 Offset: 0x1B4BAD0 VA: 0x181B4D4D0
	|-EnumUInt64TypeInfo<uint>.WriteData
	|
	|-RVA: 0x1B4CC10 Offset: 0x1B4B210 VA: 0x181B4CC10
	|-EnumUInt64TypeInfo<ulong>.WriteData
	|
	|-RVA: 0x1B4CCB0 Offset: 0x1B4B2B0 VA: 0x181B4CCB0
	|-EnumUInt64TypeInfo<UIntPtr>.WriteData
	*/

	public override object GetData(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7D3380 Offset: 0x7D1980 VA: 0x1807D3380
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
	|-RVA: 0x19AD360 Offset: 0x19AB960 VA: 0x1819AD360
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
	|-RVA: 0xC8ADE0 Offset: 0xC893E0 VA: 0x180C8ADE0
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
	|-RVA: 0xC86470 Offset: 0xC84A70 VA: 0x180C86470
	|-Enumerable.Select<SkeletonDefinition.Bone, GameObject>
	|-Enumerable.Select<SkeletonDefinition.Bone, Transform>
	|-Enumerable.Select<SkeletonDefinition.Bone, object>
	|
	|-RVA: 0xC8BF80 Offset: 0xC8A580 VA: 0x180C8BF80
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
	|-RVA: 0xC8AAF0 Offset: 0xC890F0 VA: 0x180C8AAF0
	|-Enumerable.Select<PlayerItemRecipe, IPlayerItemDefinition>
	|-Enumerable.Select<PlayerItemRecipe, object>
	|
	|-RVA: 0xC8B9A0 Offset: 0xC89FA0 VA: 0x180C8B9A0
	|-Enumerable.Select<ProjectileWeaponMod, ProjectileWeaponMod.Modifier>
	|-Enumerable.Select<object, ProjectileWeaponMod.Modifier>
	|
	|-RVA: 0xC8A220 Offset: 0xC88820 VA: 0x180C8A220
	|-Enumerable.Select<ProjectileWeaponMod.Modifier, float>
	|
	|-RVA: 0xC8B3C0 Offset: 0xC899C0 VA: 0x180C8B3C0
	|-Enumerable.Select<SteamItem, InventoryItem>
	|-Enumerable.Select<object, InventoryItem>
	|
	|-RVA: 0xC8A510 Offset: 0xC88B10 VA: 0x180C8A510
	|-Enumerable.Select<Option, Option>
	|
	|-RVA: 0xC8BC90 Offset: 0xC8A290 VA: 0x180C8BC90
	|-Enumerable.Select<OptionAttribute, Option>
	|-Enumerable.Select<object, Option>
	|
	|-RVA: 0x4B4EC0 Offset: 0x4B34C0 VA: 0x1804B4EC0
	|-Enumerable.Select<ServerBrowserTag, bool>
	|-Enumerable.Select<object, bool>
	|
	|-RVA: 0xC8C560 Offset: 0xC8AB60 VA: 0x180C8C560
	|-Enumerable.Select<ServerInfo, string>
	|-Enumerable.Select<ServerInfo, object>
	|
	|-RVA: 0xC85BA0 Offset: 0xC841A0 VA: 0x180C85BA0
	|-Enumerable.Select<Achievement, <>f__AnonymousType0<string, string, bool>>
	|-Enumerable.Select<Achievement, object>
	|
	|-RVA: 0xC887B0 Offset: 0xC86DB0 VA: 0x180C887B0
	|-Enumerable.Select<InventoryDefId, InventoryDef>
	|-Enumerable.Select<InventoryDefId, object>
	|
	|-RVA: 0xC8C850 Offset: 0xC8AE50 VA: 0x180C8C850
	|-Enumerable.Select<ServerInfo, ServerInfo>
	|
	|-RVA: 0xC87030 Offset: 0xC85630 VA: 0x180C87030
	|-Enumerable.Select<Friend, SteamPlayer>
	|-Enumerable.Select<Friend, object>
	|
	|-RVA: 0xC89080 Offset: 0xC87680 VA: 0x180C89080
	|-Enumerable.Select<InventoryItem, SteamItem>
	|-Enumerable.Select<InventoryItem, object>
	|
	|-RVA: 0xC88D90 Offset: 0xC87390 VA: 0x180C88D90
	|-Enumerable.Select<InventoryItem, InventoryItemId>
	|
	|-RVA: 0xC89370 Offset: 0xC87970 VA: 0x180C89370
	|-Enumerable.Select<InventoryItem, uint>
	|
	|-RVA: 0xC85E90 Offset: 0xC84490 VA: 0x180C85E90
	|-Enumerable.Select<InventoryItem.Amount, InventoryItemId>
	|
	|-RVA: 0xC86180 Offset: 0xC84780 VA: 0x180C86180
	|-Enumerable.Select<InventoryItem.Amount, uint>
	|
	|-RVA: 0xC89660 Offset: 0xC87C60 VA: 0x180C89660
	|-Enumerable.Select<InventoryRecipe, PlayerItemRecipe>
	|
	|-RVA: 0xC87610 Offset: 0xC85C10 VA: 0x180C87610
	|-Enumerable.Select<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>
	|
	|-RVA: 0xC87900 Offset: 0xC85F00 VA: 0x180C87900
	|-Enumerable.Select<InventoryRecipe.Ingredient, string>
	|-Enumerable.Select<InventoryRecipe.Ingredient, object>
	|
	|-RVA: 0xC89950 Offset: 0xC87F50 VA: 0x180C89950
	|-Enumerable.Select<KeyValuePair<Type, PostProcessBundle>, PostProcessBundle>
	|-Enumerable.Select<KeyValuePair<object, object>, object>
	|
	|-RVA: 0xC89F30 Offset: 0xC88530 VA: 0x180C89F30
	|-Enumerable.Select<KeyValuePair<uint, FileStorage.CacheData>, uint>
	|-Enumerable.Select<KeyValuePair<uint, object>, uint>
	|
	|-RVA: 0xC89C40 Offset: 0xC88240 VA: 0x180C89C40
	|-Enumerable.Select<KeyValuePair<uint, Indexer.Entity>, Indexer.Entity>
	|-Enumerable.Select<KeyValuePair<uint, object>, object>
	|
	|-RVA: 0xC87EE0 Offset: 0xC864E0 VA: 0x180C87EE0
	|-Enumerable.Select<int, FourBitNumber>
	|
	|-RVA: 0xC884C0 Offset: 0xC86AC0 VA: 0x180C884C0
	|-Enumerable.Select<int, SevenBitNumber>
	|
	|-RVA: 0xC881D0 Offset: 0xC867D0 VA: 0x180C881D0
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
	|-RVA: 0xC8B0D0 Offset: 0xC896D0 VA: 0x180C8B0D0
	|-Enumerable.Select<string, InventoryRecipe.Ingredient>
	|-Enumerable.Select<object, InventoryRecipe.Ingredient>
	|
	|-RVA: 0xC8B6B0 Offset: 0xC89CB0 VA: 0x180C8B6B0
	|-Enumerable.Select<string, InventoryRecipe>
	|-Enumerable.Select<object, InventoryRecipe>
	|
	|-RVA: 0x4B51B0 Offset: 0x4B37B0 VA: 0x1804B51B0
	|-Enumerable.Select<string, KeyCode>
	|-Enumerable.Select<object, Int32Enum>
	|
	|-RVA: 0xC87BF0 Offset: 0xC861F0 VA: 0x180C87BF0
	|-Enumerable.Select<KeyCode, string>
	|-Enumerable.Select<Int32Enum, object>
	|
	|-RVA: 0xC86760 Offset: 0xC84D60 VA: 0x180C86760
	|-Enumerable.Select<BurstCloth.Chain, int>
	|
	|-RVA: 0xC86A50 Offset: 0xC85050 VA: 0x180C86A50
	|-Enumerable.Select<WeightedStringList.Container, float>
	|
	|-RVA: 0xC87320 Offset: 0xC85920 VA: 0x180C87320
	|-Enumerable.Select<PlayerItemRecipe.Ingredient, int>
	|
	|-RVA: 0xC8C270 Offset: 0xC8A870 VA: 0x180C8C270
	|-Enumerable.Select<ServerInfo, int>
	|
	|-RVA: 0xC8A800 Offset: 0xC88E00 VA: 0x180C8A800
	|-Enumerable.Select<SkinnedMultiMesh.Part, long>
	|
	|-RVA: 0xC88AA0 Offset: 0xC870A0 VA: 0x180C88AA0
	|-Enumerable.Select<InventoryItem, int>
	|
	|-RVA: 0xC86D40 Offset: 0xC85340 VA: 0x180C86D40
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
	|-RVA: 0x1B1A900 Offset: 0x1B18F00 VA: 0x181B1A900
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
	|-RVA: 0x1179B80 Offset: 0x1178180 VA: 0x181179B80
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
	|-RVA: 0xED4800 Offset: 0xED2E00 VA: 0x180ED4800
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
	|-RVA: 0xED4880 Offset: 0xED2E80 VA: 0x180ED4880
	|-Enumerable.OrderBy<string, string>
	|-Enumerable.OrderBy<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED4780 Offset: 0xED2D80 VA: 0x180ED4780
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
	|-RVA: 0xED4E30 Offset: 0xED3430 VA: 0x180ED4E30
	|-Enumerable.ThenBy<IPlayerInfo, string>
	|-Enumerable.ThenBy<object, object>
	|
	|-RVA: 0xED4D20 Offset: 0xED3320 VA: 0x180ED4D20
	|-Enumerable.ThenBy<ItemBlueprint, Rarity>
	|-Enumerable.ThenBy<object, Int32Enum>
	|
	|-RVA: 0xED4EB0 Offset: 0xED34B0 VA: 0x180ED4EB0
	|-Enumerable.ThenBy<KerningPair, uint>
	|-Enumerable.ThenBy<TMP_GlyphPairAdjustmentRecord, uint>
	|-Enumerable.ThenBy<object, uint>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static IOrderedEnumerable<TSource> ThenByDescending<TSource, TKey>(IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED4A80 Offset: 0xED3080 VA: 0x180ED4A80
	|-Enumerable.ThenByDescending<AccountNotice, DateTime>
	|-Enumerable.ThenByDescending<object, DateTime>
	|
	|-RVA: 0xED4B90 Offset: 0xED3190 VA: 0x180ED4B90
	|-Enumerable.ThenByDescending<ItemBlueprint, int>
	|-Enumerable.ThenByDescending<object, int>
	|
	|-RVA: 0xED4970 Offset: 0xED2F70 VA: 0x180ED4970
	|-Enumerable.ThenByDescending<Resolution, int>
	|
	|-RVA: 0xED4CA0 Offset: 0xED32A0 VA: 0x180ED4CA0
	|-Enumerable.ThenByDescending<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCFFFF0 Offset: 0xCFE5F0 VA: 0x180CFFFF0
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
	|-RVA: 0xBF17E0 Offset: 0xBEFDE0 VA: 0x180BF17E0
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
	|-RVA: 0xBF1B60 Offset: 0xBF0160 VA: 0x180BF1B60
	|-Enumerable.SequenceEqual<PlayerItemRecipe.Ingredient>
	|
	|-RVA: 0xBF17F0 Offset: 0xBEFDF0 VA: 0x180BF17F0
	|-Enumerable.SequenceEqual<bool>
	|
	|-RVA: 0xBF1EB0 Offset: 0xBF04B0 VA: 0x180BF1EB0
	|-Enumerable.SequenceEqual<object>
	|
	|-RVA: 0xBF2210 Offset: 0xBF0810 VA: 0x180BF2210
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
	|-RVA: 0x15A2A00 Offset: 0x15A1000 VA: 0x1815A2A00
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
	|-RVA: 0x15A2280 Offset: 0x15A0880 VA: 0x1815A2280
	|-Enumerable.ToArray<Debugging.EntityInfo>
	|
	|-RVA: 0x15A2BE0 Offset: 0x15A11E0 VA: 0x1815A2BE0
	|-Enumerable.ToArray<GameStat.Stat>
	|
	|-RVA: 0x15A2B40 Offset: 0x15A1140 VA: 0x1815A2B40
	|-Enumerable.ToArray<ItemSkinDirectory.Skin>
	|
	|-RVA: 0x15A2320 Offset: 0x15A0920 VA: 0x1815A2320
	|-Enumerable.ToArray<FourBitNumber>
	|
	|-RVA: 0x15A2AA0 Offset: 0x15A10A0 VA: 0x1815A2AA0
	|-Enumerable.ToArray<SevenBitNumber>
	|
	|-RVA: 0x15A28C0 Offset: 0x15A0EC0 VA: 0x1815A28C0
	|-Enumerable.ToArray<Option>
	|
	|-RVA: 0x15A2960 Offset: 0x15A0F60 VA: 0x1815A2960
	|-Enumerable.ToArray<SkinnedMultiMesh.Part>
	|
	|-RVA: 0x15A25A0 Offset: 0x15A0BA0 VA: 0x1815A25A0
	|-Enumerable.ToArray<InventoryDefId>
	|
	|-RVA: 0x15A2640 Offset: 0x15A0C40 VA: 0x1815A2640
	|-Enumerable.ToArray<InventoryItemId>
	|
	|-RVA: 0x15A26E0 Offset: 0x15A0CE0 VA: 0x1815A26E0
	|-Enumerable.ToArray<InventoryItem>
	|
	|-RVA: 0x15A23C0 Offset: 0x15A09C0 VA: 0x1815A23C0
	|-Enumerable.ToArray<InventoryRecipe.Ingredient>
	|
	|-RVA: 0x15A2780 Offset: 0x15A0D80 VA: 0x1815A2780
	|-Enumerable.ToArray<InventoryRecipe>
	|
	|-RVA: 0x15A2820 Offset: 0x15A0E20 VA: 0x1815A2820
	|-Enumerable.ToArray<Item>
	|
	|-RVA: 0x15A2140 Offset: 0x15A0740 VA: 0x1815A2140
	|-Enumerable.ToArray<byte>
	|
	|-RVA: 0x15A21E0 Offset: 0x15A07E0 VA: 0x1815A21E0
	|-Enumerable.ToArray<char>
	|
	|-RVA: 0x15A2500 Offset: 0x15A0B00 VA: 0x1815A2500
	|-Enumerable.ToArray<int>
	|
	|-RVA: 0x15A2C80 Offset: 0x15A1280 VA: 0x1815A2C80
	|-Enumerable.ToArray<uint>
	|
	|-RVA: 0x15A2460 Offset: 0x15A0A60 VA: 0x1815A2460
	|-Enumerable.ToArray<KeyCode>
	|-Enumerable.ToArray<Int32Enum>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static List<TSource> ToList<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12ADA10 Offset: 0x12AC010 VA: 0x1812ADA10
	|-Enumerable.ToList<Chat.MuteEntry>
	|
	|-RVA: 0x12ADB50 Offset: 0x12AC150 VA: 0x1812ADB50
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
	|-RVA: 0x12AD970 Offset: 0x12ABF70 VA: 0x1812AD970
	|-Enumerable.ToList<PlayerItemRecipe.Ingredient>
	|
	|-RVA: 0x12ADBF0 Offset: 0x12AC1F0 VA: 0x1812ADBF0
	|-Enumerable.ToList<ServerInfo>
	|
	|-RVA: 0x12ADC90 Offset: 0x12AC290 VA: 0x1812ADC90
	|-Enumerable.ToList<ServerInfo>
	|
	|-RVA: 0x12AD8D0 Offset: 0x12ABED0 VA: 0x1812AD8D0
	|-Enumerable.ToList<bool>
	|
	|-RVA: 0x12ADD30 Offset: 0x12AC330 VA: 0x1812ADD30
	|-Enumerable.ToList<float>
	|
	|-RVA: 0x12ADAB0 Offset: 0x12AC0B0 VA: 0x1812ADAB0
	|-Enumerable.ToList<Resolution>
	|
	|-RVA: 0x12ADDD0 Offset: 0x12AC3D0 VA: 0x1812ADDD0
	|-Enumerable.ToList<Vector2>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1537E90 Offset: 0x1536490 VA: 0x181537E90
	|-Enumerable.ToDictionary<Input.Button, string>
	|-Enumerable.ToDictionary<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDFBCD0 Offset: 0xDFA2D0 VA: 0x180DFBCD0
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
	|-RVA: 0x1537C10 Offset: 0x1536210 VA: 0x181537C10
	|-Enumerable.ToDictionary<IGrouping<string, PrefabData>, string, List<PrefabData>>
	|-Enumerable.ToDictionary<object, object, object>
	|
	|-RVA: 0x1537160 Offset: 0x1535760 VA: 0x181537160
	|-Enumerable.ToDictionary<KeyValuePair<ulong, Dispatch.ResultCallback>, ulong, Dispatch.ResultCallback>
	|
	|-RVA: 0x1537720 Offset: 0x1535D20 VA: 0x181537720
	|-Enumerable.ToDictionary<object, InventoryDefId, uint>
	|
	|-RVA: 0x15374A0 Offset: 0x1535AA0 VA: 0x1815374A0
	|-Enumerable.ToDictionary<object, int, object>
	|
	|-RVA: 0x1537990 Offset: 0x1535F90 VA: 0x181537990
	|-Enumerable.ToDictionary<object, object, Int32Enum>
	|
	|-RVA: 0x1537EF0 Offset: 0x15364F0 VA: 0x181537EF0
	|-Enumerable.ToDictionary<object, uint, object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static IEnumerable<TResult> OfType<TResult>(IEnumerable source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC85B30 Offset: 0xC84130 VA: 0x180C85B30
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
	|-RVA: 0xC85A90 Offset: 0xC84090 VA: 0x180C85A90
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
	|-RVA: 0xC85770 Offset: 0xC83D70 VA: 0x180C85770
	|-Enumerable.Cast<bool>
	|
	|-RVA: 0xC85810 Offset: 0xC83E10 VA: 0x180C85810
	|-Enumerable.Cast<byte>
	|
	|-RVA: 0xC858B0 Offset: 0xC83EB0 VA: 0x180C858B0
	|-Enumerable.Cast<DictionaryEntry>
	|
	|-RVA: 0xC85950 Offset: 0xC83F50 VA: 0x180C85950
	|-Enumerable.Cast<short>
	|
	|-RVA: 0xC859F0 Offset: 0xC83FF0 VA: 0x180C859F0
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
	|-RVA: 0xC856F0 Offset: 0xC83CF0 VA: 0x180C856F0
	|-Enumerable.CastIterator<DictionaryEntry>
	|
	|-RVA: 0x4B4930 Offset: 0x4B2F30 VA: 0x1804B4930
	|-Enumerable.CastIterator<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TSource First<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A0FB0 Offset: 0x159F5B0 VA: 0x1815A0FB0
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
	|-RVA: 0x159FD00 Offset: 0x159E300 VA: 0x18159FD00
	|-Enumerable.First<InventoryItem>
	|
	|-RVA: 0x15A0030 Offset: 0x159E630 VA: 0x1815A0030
	|-Enumerable.First<Item>
	|
	|-RVA: 0x15A0A60 Offset: 0x159F060 VA: 0x1815A0A60
	|-Enumerable.First<Resolution>
	|
	|-RVA: 0x159FA10 Offset: 0x159E010 VA: 0x18159FA10
	|-Enumerable.First<byte>
	|
	|-RVA: 0x15A04D0 Offset: 0x159EAD0 VA: 0x1815A04D0
	|-Enumerable.First<KeyValuePair<long, object>>
	|
	|-RVA: 0x15A07F0 Offset: 0x159EDF0 VA: 0x1815A07F0
	|-Enumerable.First<KeyValuePair<object, object>>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TSource First<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A0DC0 Offset: 0x159F3C0 VA: 0x1815A0DC0
	|-Enumerable.First<Dropdown.OptionData>
	|-Enumerable.First<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TSource FirstOrDefault<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x159F290 Offset: 0x159D890 VA: 0x18159F290
	|-Enumerable.FirstOrDefault<CraftingQueueIcon>
	|-Enumerable.FirstOrDefault<ValueChange<TimeSignature>>
	|-Enumerable.FirstOrDefault<ProjectileWeaponMod>
	|-Enumerable.FirstOrDefault<SocketHandle>
	|-Enumerable.FirstOrDefault<string>
	|-Enumerable.FirstOrDefault<Toggle>
	|-Enumerable.FirstOrDefault<object>
	|
	|-RVA: 0x159E760 Offset: 0x159CD60 VA: 0x18159E760
	|-Enumerable.FirstOrDefault<SkeletonDefinition.Bone>
	|
	|-RVA: 0x159F4A0 Offset: 0x159DAA0 VA: 0x18159F4A0
	|-Enumerable.FirstOrDefault<ItemSkinDirectory.Skin>
	|
	|-RVA: 0x159EAB0 Offset: 0x159D0B0 VA: 0x18159EAB0
	|-Enumerable.FirstOrDefault<InventoryRecipe>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TSource FirstOrDefault<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x159F0C0 Offset: 0x159D6C0 VA: 0x18159F0C0
	|-Enumerable.FirstOrDefault<Input.Button>
	|-Enumerable.FirstOrDefault<IPlayerItemDefinition>
	|-Enumerable.FirstOrDefault<Skinnable>
	|-Enumerable.FirstOrDefault<string>
	|-Enumerable.FirstOrDefault<Match>
	|-Enumerable.FirstOrDefault<Toggle>
	|-Enumerable.FirstOrDefault<object>
	|
	|-RVA: 0x159F760 Offset: 0x159DD60 VA: 0x18159F760
	|-Enumerable.FirstOrDefault<ItemSkinDirectory.Skin>
	|
	|-RVA: 0x159EDF0 Offset: 0x159D3F0 VA: 0x18159EDF0
	|-Enumerable.FirstOrDefault<PetCommandList.PetCommandDesc>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TSource Last<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A16F0 Offset: 0x159FCF0 VA: 0x1815A16F0
	|-Enumerable.Last<string>
	|-Enumerable.Last<KerningPair>
	|-Enumerable.Last<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TSource LastOrDefault<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A11D0 Offset: 0x159F7D0 VA: 0x1815A11D0
	|-Enumerable.LastOrDefault<MetricTempoMapValuesCache.AccumulatedMicroseconds>
	|-Enumerable.LastOrDefault<ValueChange<TimeSignature>>
	|-Enumerable.LastOrDefault<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TSource LastOrDefault<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A14D0 Offset: 0x159FAD0 VA: 0x1815A14D0
	|-Enumerable.LastOrDefault<MemberInfo>
	|-Enumerable.LastOrDefault<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TSource Single<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A1EC0 Offset: 0x15A04C0 VA: 0x1815A1EC0
	|-Enumerable.Single<MemberInfo>
	|-Enumerable.Single<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TSource SingleOrDefault<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A1A10 Offset: 0x15A0010 VA: 0x1815A1A10
	|-Enumerable.SingleOrDefault<MemberInfo>
	|-Enumerable.SingleOrDefault<string>
	|-Enumerable.SingleOrDefault<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TSource SingleOrDefault<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A1C70 Offset: 0x15A0270 VA: 0x1815A1C70
	|-Enumerable.SingleOrDefault<ConstructorInfo>
	|-Enumerable.SingleOrDefault<PlayerEditorConnectionEvents.MessageTypeSubscribers>
	|-Enumerable.SingleOrDefault<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TSource ElementAt<TSource>(IEnumerable<TSource> source, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x159E220 Offset: 0x159C820 VA: 0x18159E220
	|-Enumerable.ElementAt<KeyValuePair<string, JSONNode>>
	|-Enumerable.ElementAt<KeyValuePair<object, object>>
	|
	|-RVA: 0x159E4E0 Offset: 0x159CAE0 VA: 0x18159E4E0
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
	|-RVA: 0xBF0250 Offset: 0xBEE850 VA: 0x180BF0250
	|-Enumerable.Any<PlayerItemRecipe>
	|
	|-RVA: 0xBEFD00 Offset: 0xBEE300 VA: 0x180BEFD00
	|-Enumerable.Any<KeyValuePair<long, object>>
	|
	|-RVA: 0xBEFE70 Offset: 0xBEE470 VA: 0x180BEFE70
	|-Enumerable.Any<KeyValuePair<object, object>>
	|
	|-RVA: 0xBF03C0 Offset: 0xBEE9C0 VA: 0x180BF03C0
	|-Enumerable.Any<FileInfo>
	|-Enumerable.Any<object>
	|-Enumerable.Any<ParameterInfo>
	|-Enumerable.Any<PlayerEditorConnectionEvents.MessageTypeSubscribers>
	|
	|-RVA: 0xBF0700 Offset: 0xBEED00 VA: 0x180BF0700
	|-Enumerable.Any<float>
	|
	|-RVA: 0xBF0870 Offset: 0xBEEE70 VA: 0x180BF0870
	|-Enumerable.Any<Vector2>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static bool Any<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF0530 Offset: 0xBEEB30 VA: 0x180BF0530
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
	|-RVA: 0xBEFFE0 Offset: 0xBEE5E0 VA: 0x180BEFFE0
	|-Enumerable.Any<SkinnedMultiMesh.Part>
	|
	|-RVA: 0xBEF810 Offset: 0xBEDE10 VA: 0x180BEF810
	|-Enumerable.Any<InventoryItem.Amount>
	|
	|-RVA: 0xBEFA90 Offset: 0xBEE090 VA: 0x180BEFA90
	|-Enumerable.Any<InventoryRecipe.Ingredient>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static bool All<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEF640 Offset: 0xBEDC40 VA: 0x180BEF640
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
	|-RVA: 0xED3F70 Offset: 0xED2570 VA: 0x180ED3F70
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
	|-RVA: 0xED4360 Offset: 0xED2960 VA: 0x180ED4360
	|-Enumerable.Count<ServerInfo>
	|
	|-RVA: 0xED3D70 Offset: 0xED2370 VA: 0x180ED3D70
	|-Enumerable.Count<InventoryItem>
	|
	|-RVA: 0xED3B70 Offset: 0xED2170 VA: 0x180ED3B70
	|-Enumerable.Count<int>
	|
	|-RVA: 0xED4560 Offset: 0xED2B60 VA: 0x180ED4560
	|-Enumerable.Count<float>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static int Count<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED3700 Offset: 0xED1D00 VA: 0x180ED3700
	|-Enumerable.Count<RCon.BannedAddresses>
	|
	|-RVA: 0xED3980 Offset: 0xED1F80 VA: 0x180ED3980
	|-Enumerable.Count<bool>
	|
	|-RVA: 0xED4170 Offset: 0xED2770 VA: 0x180ED4170
	|-Enumerable.Count<object>
	|-Enumerable.Count<Collider>
	|-Enumerable.Count<Renderer>
	|-Enumerable.Count<Rigidbody>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static bool Contains<TSource>(IEnumerable<TSource> source, TSource value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF0DB0 Offset: 0xBEF3B0 VA: 0x180BF0DB0
	|-Enumerable.Contains<TempoMapLine>
	|-Enumerable.Contains<int>
	|-Enumerable.Contains<Int32Enum>
	|-Enumerable.Contains<GraphicsDeviceType>
	|
	|-RVA: 0xBF1470 Offset: 0xBEFA70 VA: 0x180BF1470
	|-Enumerable.Contains<MeshPaintableSource>
	|-Enumerable.Contains<object>
	|-Enumerable.Contains<string>
	|-Enumerable.Contains<Component>
	|-Enumerable.Contains<Material>
	|-Enumerable.Contains<Renderer>
	|
	|-RVA: 0xBF09E0 Offset: 0xBEEFE0 VA: 0x180BF09E0
	|-Enumerable.Contains<char>
	|-Enumerable.Contains<ushort>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static bool Contains<TSource>(IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF0AF0 Offset: 0xBEF0F0 VA: 0x180BF0AF0
	|-Enumerable.Contains<char>
	|
	|-RVA: 0xBF1060 Offset: 0xBEF660 VA: 0x180BF1060
	|-Enumerable.Contains<int>
	|
	|-RVA: 0xBF0E60 Offset: 0xBEF460 VA: 0x180BF0E60
	|-Enumerable.Contains<Int32Enum>
	|
	|-RVA: 0xBF1260 Offset: 0xBEF860 VA: 0x180BF1260
	|-Enumerable.Contains<object>
	|
	|-RVA: 0xBF1520 Offset: 0xBEFB20 VA: 0x180BF1520
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
	|-RVA: 0xED4910 Offset: 0xED2F10 VA: 0x180ED4910
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
	|-RVA: 0xED4950 Offset: 0xED2F50 VA: 0x180ED4950
	|-Enumerable.Sum<SkinnedMultiMesh.Part>
	|-Enumerable.Sum<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static float Sum<TSource>(IEnumerable<TSource> source, Func<TSource, float> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED4930 Offset: 0xED2F30 VA: 0x180ED4930
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
	|-RVA: 0xED4760 Offset: 0xED2D60 VA: 0x180ED4760
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
	|-RVA: 0x19D0AF0 Offset: 0x19CF0F0 VA: 0x1819D0AF0
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
	|-RVA: 0xB119C0 Offset: 0xB0FFC0 VA: 0x180B119C0
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
	|-RVA: 0x1650250 Offset: 0x164E850 VA: 0x181650250
	|-Enumerable.Iterator<SkeletonDefinition.Bone>.get_Current
	|-Enumerable.Iterator<InventoryItem.Amount>.get_Current
	|
	|-RVA: 0x176B2D0 Offset: 0x17698D0 VA: 0x18176B2D0
	|-Enumerable.Iterator<ItemSkinDirectory.Skin>.get_Current
	|-Enumerable.Iterator<Option>.get_Current
	|-Enumerable.Iterator<SkinnedMultiMesh.Part>.get_Current
	|-Enumerable.Iterator<InventoryItem>.get_Current
	|
	|-RVA: 0x95FFF0 Offset: 0x95E5F0 VA: 0x18095FFF0
	|-Enumerable.Iterator<FourBitNumber>.get_Current
	|-Enumerable.Iterator<SevenBitNumber>.get_Current
	|-Enumerable.Iterator<bool>.get_Current
	|
	|-RVA: 0x12D3B30 Offset: 0x12D2130 VA: 0x1812D3B30
	|-Enumerable.Iterator<ProjectileWeaponMod.Modifier>.get_Current
	|-Enumerable.Iterator<Resolution>.get_Current
	|
	|-RVA: 0xDECE20 Offset: 0xDEB420 VA: 0x180DECE20
	|-Enumerable.Iterator<ServerInfo>.get_Current
	|-Enumerable.Iterator<ServerInfo>.get_Current
	|
	|-RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400
	|-Enumerable.Iterator<InventoryDefId>.get_Current
	|-Enumerable.Iterator<int>.get_Current
	|-Enumerable.Iterator<Int32Enum>.get_Current
	|-Enumerable.Iterator<uint>.get_Current
	|
	|-RVA: 0x1128360 Offset: 0x1126960 VA: 0x181128360
	|-Enumerable.Iterator<InventoryRecipe.Ingredient>.get_Current
	|-Enumerable.Iterator<InventoryRecipe>.get_Current
	|-Enumerable.Iterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.get_Current
	|
	|-RVA: 0x1398470 Offset: 0x1396A70 VA: 0x181398470
	|-Enumerable.Iterator<char>.get_Current
	|
	|-RVA: 0x774710 Offset: 0x772D10 VA: 0x180774710
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
	|-RVA: 0x19CF880 Offset: 0x19CDE80 VA: 0x1819CF880
	|-Enumerable.Iterator<Debugging.EntityInfo>.Dispose
	|-Enumerable.Iterator<WeightedStringList.Container>.Dispose
	|-Enumerable.Iterator<GameStat.Stat>.Dispose
	|-Enumerable.Iterator<PlayerItemRecipe>.Dispose
	|-Enumerable.Iterator<DictionaryEntry>.Dispose
	|-Enumerable.Iterator<KeyValuePair<object, int>>.Dispose
	|-Enumerable.Iterator<KeyValuePair<object, object>>.Dispose
	|-Enumerable.Iterator<KeyValuePair<uint, object>>.Dispose
	|
	|-RVA: 0x19CF8B0 Offset: 0x19CDEB0 VA: 0x1819CF8B0
	|-Enumerable.Iterator<BurstCloth.Chain>.Dispose
	|-Enumerable.Iterator<PathFinder.Point>.Dispose
	|-Enumerable.Iterator<PlayerItemRecipe.Ingredient>.Dispose
	|-Enumerable.Iterator<Achievement>.Dispose
	|-Enumerable.Iterator<InventoryItemId>.Dispose
	|-Enumerable.Iterator<Friend>.Dispose
	|-Enumerable.Iterator<long>.Dispose
	|-Enumerable.Iterator<object>.Dispose
	|
	|-RVA: 0x19CF910 Offset: 0x19CDF10 VA: 0x1819CF910
	|-Enumerable.Iterator<SkeletonDefinition.Bone>.Dispose
	|-Enumerable.Iterator<InventoryItem.Amount>.Dispose
	|
	|-RVA: 0x19CF8E0 Offset: 0x19CDEE0 VA: 0x1819CF8E0
	|-Enumerable.Iterator<ItemSkinDirectory.Skin>.Dispose
	|-Enumerable.Iterator<Option>.Dispose
	|-Enumerable.Iterator<SkinnedMultiMesh.Part>.Dispose
	|-Enumerable.Iterator<InventoryItem>.Dispose
	|
	|-RVA: 0x19CF960 Offset: 0x19CDF60 VA: 0x1819CF960
	|-Enumerable.Iterator<FourBitNumber>.Dispose
	|-Enumerable.Iterator<SevenBitNumber>.Dispose
	|-Enumerable.Iterator<bool>.Dispose
	|
	|-RVA: 0x19CF8C0 Offset: 0x19CDEC0 VA: 0x1819CF8C0
	|-Enumerable.Iterator<ProjectileWeaponMod.Modifier>.Dispose
	|-Enumerable.Iterator<Resolution>.Dispose
	|
	|-RVA: 0x19CF930 Offset: 0x19CDF30 VA: 0x1819CF930
	|-Enumerable.Iterator<ServerInfo>.Dispose
	|-Enumerable.Iterator<ServerInfo>.Dispose
	|
	|-RVA: 0x19CF870 Offset: 0x19CDE70 VA: 0x1819CF870
	|-Enumerable.Iterator<InventoryDefId>.Dispose
	|-Enumerable.Iterator<int>.Dispose
	|-Enumerable.Iterator<Int32Enum>.Dispose
	|-Enumerable.Iterator<float>.Dispose
	|-Enumerable.Iterator<uint>.Dispose
	|
	|-RVA: 0x19CF890 Offset: 0x19CDE90 VA: 0x1819CF890
	|-Enumerable.Iterator<InventoryRecipe.Ingredient>.Dispose
	|-Enumerable.Iterator<InventoryRecipe>.Dispose
	|-Enumerable.Iterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.Dispose
	|
	|-RVA: 0x19CF900 Offset: 0x19CDF00 VA: 0x1819CF900
	|-Enumerable.Iterator<char>.Dispose
	*/

	public IEnumerator<TSource> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CF970 Offset: 0x19CDF70 VA: 0x1819CF970
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
	|-RVA: 0x19D0650 Offset: 0x19CEC50 VA: 0x1819D0650
	|-Enumerable.Iterator<Debugging.EntityInfo>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<WeightedStringList.Container>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<GameStat.Stat>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<PlayerItemRecipe>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<DictionaryEntry>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<KeyValuePair<object, int>>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<KeyValuePair<object, object>>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<KeyValuePair<uint, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D06C0 Offset: 0x19CECC0 VA: 0x1819D06C0
	|-Enumerable.Iterator<BurstCloth.Chain>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<PathFinder.Point>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<PlayerItemRecipe.Ingredient>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<Achievement>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<InventoryItemId>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<Friend>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D0A10 Offset: 0x19CF010 VA: 0x1819D0A10
	|-Enumerable.Iterator<SkeletonDefinition.Bone>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<InventoryItem.Amount>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D0720 Offset: 0x19CED20 VA: 0x1819D0720
	|-Enumerable.Iterator<ItemSkinDirectory.Skin>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<Option>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<SkinnedMultiMesh.Part>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<InventoryItem>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D09B0 Offset: 0x19CEFB0 VA: 0x1819D09B0
	|-Enumerable.Iterator<FourBitNumber>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<SevenBitNumber>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D0930 Offset: 0x19CEF30 VA: 0x1819D0930
	|-Enumerable.Iterator<ProjectileWeaponMod.Modifier>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<Resolution>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D07A0 Offset: 0x19CEDA0 VA: 0x1819D07A0
	|-Enumerable.Iterator<ServerInfo>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<ServerInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D08D0 Offset: 0x19CEED0 VA: 0x1819D08D0
	|-Enumerable.Iterator<InventoryDefId>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<int>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<Int32Enum>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<uint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D05D0 Offset: 0x19CEBD0 VA: 0x1819D05D0
	|-Enumerable.Iterator<InventoryRecipe.Ingredient>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<InventoryRecipe>.System.Collections.IEnumerator.get_Current
	|-Enumerable.Iterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D0A90 Offset: 0x19CF090 VA: 0x1819D0A90
	|-Enumerable.Iterator<char>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19AD360 Offset: 0x19AB960 VA: 0x1819AD360
	|-Enumerable.Iterator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D0860 Offset: 0x19CEE60 VA: 0x1819D0860
	|-Enumerable.Iterator<float>.System.Collections.IEnumerator.get_Current
	*/

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16508D0 Offset: 0x164EED0 VA: 0x1816508D0
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
	|-RVA: 0x19D03F0 Offset: 0x19CE9F0 VA: 0x1819D03F0
	|-Enumerable.Iterator<Debugging.EntityInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0490 Offset: 0x19CEA90 VA: 0x1819D0490
	|-Enumerable.Iterator<BurstCloth.Chain>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D00D0 Offset: 0x19CE6D0 VA: 0x1819D00D0
	|-Enumerable.Iterator<SkeletonDefinition.Bone>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFBD0 Offset: 0x19CE1D0 VA: 0x1819CFBD0
	|-Enumerable.Iterator<WeightedStringList.Container>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0120 Offset: 0x19CE720 VA: 0x1819D0120
	|-Enumerable.Iterator<GameStat.Stat>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFAE0 Offset: 0x19CE0E0 VA: 0x1819CFAE0
	|-Enumerable.Iterator<ItemSkinDirectory.Skin>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0530 Offset: 0x19CEB30 VA: 0x1819D0530
	|-Enumerable.Iterator<FourBitNumber>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFCC0 Offset: 0x19CE2C0 VA: 0x1819CFCC0
	|-Enumerable.Iterator<SevenBitNumber>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFB30 Offset: 0x19CE130 VA: 0x1819CFB30
	|-Enumerable.Iterator<PathFinder.Point>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0440 Offset: 0x19CEA40 VA: 0x1819D0440
	|-Enumerable.Iterator<PlayerItemRecipe.Ingredient>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFEA0 Offset: 0x19CE4A0 VA: 0x1819CFEA0
	|-Enumerable.Iterator<PlayerItemRecipe>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFE00 Offset: 0x19CE400 VA: 0x1819CFE00
	|-Enumerable.Iterator<ProjectileWeaponMod.Modifier>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFF90 Offset: 0x19CE590 VA: 0x1819CFF90
	|-Enumerable.Iterator<Option>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFC70 Offset: 0x19CE270 VA: 0x1819CFC70
	|-Enumerable.Iterator<ServerInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFF40 Offset: 0x19CE540 VA: 0x1819CFF40
	|-Enumerable.Iterator<SkinnedMultiMesh.Part>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CF9F0 Offset: 0x19CDFF0 VA: 0x1819CF9F0
	|-Enumerable.Iterator<Achievement>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D03A0 Offset: 0x19CE9A0 VA: 0x1819D03A0
	|-Enumerable.Iterator<InventoryDefId>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D01C0 Offset: 0x19CE7C0 VA: 0x1819D01C0
	|-Enumerable.Iterator<InventoryItemId>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0580 Offset: 0x19CEB80 VA: 0x1819D0580
	|-Enumerable.Iterator<ServerInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D02B0 Offset: 0x19CE8B0 VA: 0x1819D02B0
	|-Enumerable.Iterator<Friend>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D04E0 Offset: 0x19CEAE0 VA: 0x1819D04E0
	|-Enumerable.Iterator<InventoryItem.Amount>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0080 Offset: 0x19CE680 VA: 0x1819D0080
	|-Enumerable.Iterator<InventoryItem>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0300 Offset: 0x19CE900 VA: 0x1819D0300
	|-Enumerable.Iterator<InventoryRecipe.Ingredient>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0170 Offset: 0x19CE770 VA: 0x1819D0170
	|-Enumerable.Iterator<InventoryRecipe>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFEF0 Offset: 0x19CE4F0 VA: 0x1819CFEF0
	|-Enumerable.Iterator<bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0210 Offset: 0x19CE810 VA: 0x1819D0210
	|-Enumerable.Iterator<char>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFB80 Offset: 0x19CE180 VA: 0x1819CFB80
	|-Enumerable.Iterator<DictionaryEntry>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFE50 Offset: 0x19CE450 VA: 0x1819CFE50
	|-Enumerable.Iterator<KeyValuePair<object, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFD60 Offset: 0x19CE360 VA: 0x1819CFD60
	|-Enumerable.Iterator<KeyValuePair<object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFA90 Offset: 0x19CE090 VA: 0x1819CFA90
	|-Enumerable.Iterator<KeyValuePair<uint, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0350 Offset: 0x19CE950 VA: 0x1819D0350
	|-Enumerable.Iterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFA40 Offset: 0x19CE040 VA: 0x1819CFA40
	|-Enumerable.Iterator<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0030 Offset: 0x19CE630 VA: 0x1819D0030
	|-Enumerable.Iterator<Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFDB0 Offset: 0x19CE3B0 VA: 0x1819CFDB0
	|-Enumerable.Iterator<long>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFC20 Offset: 0x19CE220 VA: 0x1819CFC20
	|-Enumerable.Iterator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFD10 Offset: 0x19CE310 VA: 0x1819CFD10
	|-Enumerable.Iterator<float>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D0260 Offset: 0x19CE860 VA: 0x1819D0260
	|-Enumerable.Iterator<uint>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19CFFE0 Offset: 0x19CE5E0 VA: 0x1819CFFE0
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
	|-RVA: 0x16A21D0 Offset: 0x16A07D0 VA: 0x1816A21D0
	|-Enumerable.WhereEnumerableIterator<Debugging.EntityInfo>..ctor
	|-Enumerable.WhereEnumerableIterator<GameStat.Stat>..ctor
	|-Enumerable.WhereEnumerableIterator<PlayerItemRecipe>..ctor
	|-Enumerable.WhereEnumerableIterator<ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, int>>..ctor
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, object>>..ctor
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<uint, object>>..ctor
	|-Enumerable.WhereEnumerableIterator<Resolution>..ctor
	|
	|-RVA: 0x16A3A30 Offset: 0x16A2030 VA: 0x1816A3A30
	|-Enumerable.WhereEnumerableIterator<SkeletonDefinition.Bone>..ctor
	|
	|-RVA: 0x16A3AA0 Offset: 0x16A20A0 VA: 0x1816A3AA0
	|-Enumerable.WhereEnumerableIterator<ItemSkinDirectory.Skin>..ctor
	|-Enumerable.WhereEnumerableIterator<Option>..ctor
	|-Enumerable.WhereEnumerableIterator<SkinnedMultiMesh.Part>..ctor
	|-Enumerable.WhereEnumerableIterator<InventoryItem>..ctor
	|
	|-RVA: 0x16A2240 Offset: 0x16A0840 VA: 0x1816A2240
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
	|-RVA: 0x16A3B10 Offset: 0x16A2110 VA: 0x1816A3B10
	|-Enumerable.WhereEnumerableIterator<ServerInfo>..ctor
	|
	|-RVA: 0x16A39C0 Offset: 0x16A1FC0 VA: 0x1816A39C0
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe>..ctor
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>..ctor
	*/

	public override Enumerable.Iterator<TSource> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A1AD0 Offset: 0x16A00D0 VA: 0x1816A1AD0
	|-Enumerable.WhereEnumerableIterator<Debugging.EntityInfo>.Clone
	|-Enumerable.WhereEnumerableIterator<GameStat.Stat>.Clone
	|-Enumerable.WhereEnumerableIterator<PlayerItemRecipe>.Clone
	|-Enumerable.WhereEnumerableIterator<ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, int>>.Clone
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, object>>.Clone
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<uint, object>>.Clone
	|-Enumerable.WhereEnumerableIterator<Resolution>.Clone
	|
	|-RVA: 0x16A2330 Offset: 0x16A0930 VA: 0x1816A2330
	|-Enumerable.WhereEnumerableIterator<SkeletonDefinition.Bone>.Clone
	|
	|-RVA: 0x16A22B0 Offset: 0x16A08B0 VA: 0x1816A22B0
	|-Enumerable.WhereEnumerableIterator<ItemSkinDirectory.Skin>.Clone
	|-Enumerable.WhereEnumerableIterator<Option>.Clone
	|-Enumerable.WhereEnumerableIterator<SkinnedMultiMesh.Part>.Clone
	|-Enumerable.WhereEnumerableIterator<InventoryItem>.Clone
	|
	|-RVA: 0x16A1B50 Offset: 0x16A0150 VA: 0x1816A1B50
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
	|-RVA: 0x16A23B0 Offset: 0x16A09B0 VA: 0x1816A23B0
	|-Enumerable.WhereEnumerableIterator<ServerInfo>.Clone
	|
	|-RVA: 0x16A2440 Offset: 0x16A0A40 VA: 0x1816A2440
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe>.Clone
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.Clone
	*/

	public override void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D8680 Offset: 0x19D6C80 VA: 0x1819D8680
	|-Enumerable.WhereEnumerableIterator<Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x19D91C0 Offset: 0x19D77C0 VA: 0x1819D91C0
	|-Enumerable.WhereEnumerableIterator<SkeletonDefinition.Bone>.Dispose
	|
	|-RVA: 0x19D8830 Offset: 0x19D6E30 VA: 0x1819D8830
	|-Enumerable.WhereEnumerableIterator<GameStat.Stat>.Dispose
	|
	|-RVA: 0x19D84D0 Offset: 0x19D6AD0 VA: 0x1819D84D0
	|-Enumerable.WhereEnumerableIterator<ItemSkinDirectory.Skin>.Dispose
	|
	|-RVA: 0x19D83B0 Offset: 0x19D69B0 VA: 0x1819D83B0
	|-Enumerable.WhereEnumerableIterator<FourBitNumber>.Dispose
	|
	|-RVA: 0x19D8B90 Offset: 0x19D7190 VA: 0x1819D8B90
	|-Enumerable.WhereEnumerableIterator<SevenBitNumber>.Dispose
	|
	|-RVA: 0x19D8440 Offset: 0x19D6A40 VA: 0x1819D8440
	|-Enumerable.WhereEnumerableIterator<PathFinder.Point>.Dispose
	|
	|-RVA: 0x19D8950 Offset: 0x19D6F50 VA: 0x1819D8950
	|-Enumerable.WhereEnumerableIterator<PlayerItemRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x19D87A0 Offset: 0x19D6DA0 VA: 0x1819D87A0
	|-Enumerable.WhereEnumerableIterator<PlayerItemRecipe>.Dispose
	|
	|-RVA: 0x19D8320 Offset: 0x19D6920 VA: 0x1819D8320
	|-Enumerable.WhereEnumerableIterator<ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x19D8A70 Offset: 0x19D7070 VA: 0x1819D8A70
	|-Enumerable.WhereEnumerableIterator<Option>.Dispose
	|
	|-RVA: 0x19D90A0 Offset: 0x19D76A0 VA: 0x1819D90A0
	|-Enumerable.WhereEnumerableIterator<ServerInfo>.Dispose
	|
	|-RVA: 0x19D8290 Offset: 0x19D6890 VA: 0x1819D8290
	|-Enumerable.WhereEnumerableIterator<SkinnedMultiMesh.Part>.Dispose
	|
	|-RVA: 0x19D8C20 Offset: 0x19D7220 VA: 0x1819D8C20
	|-Enumerable.WhereEnumerableIterator<InventoryItemId>.Dispose
	|
	|-RVA: 0x19D8D40 Offset: 0x19D7340 VA: 0x1819D8D40
	|-Enumerable.WhereEnumerableIterator<InventoryItem>.Dispose
	|
	|-RVA: 0x19D9010 Offset: 0x19D7610 VA: 0x1819D9010
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x19D8560 Offset: 0x19D6B60 VA: 0x1819D8560
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe>.Dispose
	|
	|-RVA: 0x19D8710 Offset: 0x19D6D10 VA: 0x1819D8710
	|-Enumerable.WhereEnumerableIterator<bool>.Dispose
	|
	|-RVA: 0x19D8EF0 Offset: 0x19D74F0 VA: 0x1819D8EF0
	|-Enumerable.WhereEnumerableIterator<char>.Dispose
	|
	|-RVA: 0x19D85F0 Offset: 0x19D6BF0 VA: 0x1819D85F0
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x19D8E60 Offset: 0x19D7460 VA: 0x1819D8E60
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, object>>.Dispose
	|
	|-RVA: 0x19D8B00 Offset: 0x19D7100 VA: 0x1819D8B00
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<uint, object>>.Dispose
	|
	|-RVA: 0x19D8CB0 Offset: 0x19D72B0 VA: 0x1819D8CB0
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.Dispose
	|
	|-RVA: 0x19D89E0 Offset: 0x19D6FE0 VA: 0x1819D89E0
	|-Enumerable.WhereEnumerableIterator<int>.Dispose
	|
	|-RVA: 0x19D9130 Offset: 0x19D7730 VA: 0x1819D9130
	|-Enumerable.WhereEnumerableIterator<Int32Enum>.Dispose
	|
	|-RVA: 0x19D88C0 Offset: 0x19D6EC0 VA: 0x1819D88C0
	|-Enumerable.WhereEnumerableIterator<long>.Dispose
	|
	|-RVA: 0x19D8F80 Offset: 0x19D7580 VA: 0x1819D8F80
	|-Enumerable.WhereEnumerableIterator<object>.Dispose
	|
	|-RVA: 0x19D8DD0 Offset: 0x19D73D0 VA: 0x1819D8DD0
	|-Enumerable.WhereEnumerableIterator<float>.Dispose
	|
	|-RVA: 0x16A1BD0 Offset: 0x16A01D0 VA: 0x1816A1BD0
	|-Enumerable.WhereEnumerableIterator<uint>.Dispose
	|
	|-RVA: 0x16A1C60 Offset: 0x16A0260 VA: 0x1816A1C60
	|-Enumerable.WhereEnumerableIterator<Resolution>.Dispose
	*/

	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19DAF70 Offset: 0x19D9570 VA: 0x1819DAF70
	|-Enumerable.WhereEnumerableIterator<Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x19DB150 Offset: 0x19D9750 VA: 0x1819DB150
	|-Enumerable.WhereEnumerableIterator<SkeletonDefinition.Bone>.MoveNext
	|
	|-RVA: 0x19D99F0 Offset: 0x19D7FF0 VA: 0x1819D99F0
	|-Enumerable.WhereEnumerableIterator<GameStat.Stat>.MoveNext
	|
	|-RVA: 0x19DC420 Offset: 0x19DAA20 VA: 0x1819DC420
	|-Enumerable.WhereEnumerableIterator<ItemSkinDirectory.Skin>.MoveNext
	|
	|-RVA: 0x19DC080 Offset: 0x19DA680 VA: 0x1819DC080
	|-Enumerable.WhereEnumerableIterator<FourBitNumber>.MoveNext
	|
	|-RVA: 0x19D9ED0 Offset: 0x19D84D0 VA: 0x1819D9ED0
	|-Enumerable.WhereEnumerableIterator<SevenBitNumber>.MoveNext
	|
	|-RVA: 0x19DA650 Offset: 0x19D8C50 VA: 0x1819DA650
	|-Enumerable.WhereEnumerableIterator<PathFinder.Point>.MoveNext
	|
	|-RVA: 0x19DA090 Offset: 0x19D8690 VA: 0x1819DA090
	|-Enumerable.WhereEnumerableIterator<PlayerItemRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x19DABB0 Offset: 0x19D91B0 VA: 0x1819DABB0
	|-Enumerable.WhereEnumerableIterator<PlayerItemRecipe>.MoveNext
	|
	|-RVA: 0x19DA470 Offset: 0x19D8A70 VA: 0x1819DA470
	|-Enumerable.WhereEnumerableIterator<ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x19D9480 Offset: 0x19D7A80 VA: 0x1819D9480
	|-Enumerable.WhereEnumerableIterator<Option>.MoveNext
	|
	|-RVA: 0x19D9BD0 Offset: 0x19D81D0 VA: 0x1819D9BD0
	|-Enumerable.WhereEnumerableIterator<ServerInfo>.MoveNext
	|
	|-RVA: 0x19DA980 Offset: 0x19D8F80 VA: 0x1819DA980
	|-Enumerable.WhereEnumerableIterator<SkinnedMultiMesh.Part>.MoveNext
	|
	|-RVA: 0x19DBC00 Offset: 0x19DA200 VA: 0x1819DBC00
	|-Enumerable.WhereEnumerableIterator<InventoryItemId>.MoveNext
	|
	|-RVA: 0x19D9250 Offset: 0x19D7850 VA: 0x1819D9250
	|-Enumerable.WhereEnumerableIterator<InventoryItem>.MoveNext
	|
	|-RVA: 0x19DA250 Offset: 0x19D8850 VA: 0x1819DA250
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x19DB3A0 Offset: 0x19D99A0 VA: 0x1819DB3A0
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe>.MoveNext
	|
	|-RVA: 0x19DBDC0 Offset: 0x19DA3C0 VA: 0x1819DBDC0
	|-Enumerable.WhereEnumerableIterator<bool>.MoveNext
	|
	|-RVA: 0x19DBF20 Offset: 0x19DA520 VA: 0x1819DBF20
	|-Enumerable.WhereEnumerableIterator<char>.MoveNext
	|
	|-RVA: 0x19DAD90 Offset: 0x19D9390 VA: 0x1819DAD90
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x19D9810 Offset: 0x19D7E10 VA: 0x1819D9810
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0x19DC240 Offset: 0x19DA840 VA: 0x1819DC240
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<uint, object>>.MoveNext
	|
	|-RVA: 0x19DB720 Offset: 0x19D9D20 VA: 0x1819DB720
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.MoveNext
	|
	|-RVA: 0x19DBAA0 Offset: 0x19DA0A0 VA: 0x1819DBAA0
	|-Enumerable.WhereEnumerableIterator<int>.MoveNext
	|
	|-RVA: 0x19D96B0 Offset: 0x19D7CB0 VA: 0x1819D96B0
	|-Enumerable.WhereEnumerableIterator<Int32Enum>.MoveNext
	|
	|-RVA: 0x19DB5C0 Offset: 0x19D9BC0 VA: 0x1819DB5C0
	|-Enumerable.WhereEnumerableIterator<long>.MoveNext
	|
	|-RVA: 0x19DA810 Offset: 0x19D8E10 VA: 0x1819DA810
	|-Enumerable.WhereEnumerableIterator<object>.MoveNext
	|
	|-RVA: 0x19DB940 Offset: 0x19D9F40 VA: 0x1819DB940
	|-Enumerable.WhereEnumerableIterator<float>.MoveNext
	|
	|-RVA: 0x16A1ED0 Offset: 0x16A04D0 VA: 0x1816A1ED0
	|-Enumerable.WhereEnumerableIterator<uint>.MoveNext
	|
	|-RVA: 0x16A1CF0 Offset: 0x16A02F0 VA: 0x1816A1CF0
	|-Enumerable.WhereEnumerableIterator<Resolution>.MoveNext
	*/

	public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC8CE10 Offset: 0xC8B410 VA: 0x180C8CE10
	|-Enumerable.WhereEnumerableIterator<SkeletonDefinition.Bone>.Select<object>
	|
	|-RVA: 0xC8CB40 Offset: 0xC8B140 VA: 0x180C8CB40
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
	|-RVA: 0xC8CD80 Offset: 0xC8B380 VA: 0x180C8CD80
	|-Enumerable.WhereEnumerableIterator<PlayerItemRecipe>.Select<object>
	|-Enumerable.WhereEnumerableIterator<ProjectileWeaponMod.Modifier>.Select<float>
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, object>>.Select<object>
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<uint, object>>.Select<object>
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<uint, object>>.Select<uint>
	|
	|-RVA: 0xC8CCF0 Offset: 0xC8B2F0 VA: 0x180C8CCF0
	|-Enumerable.WhereEnumerableIterator<Option>.Select<Option>
	|-Enumerable.WhereEnumerableIterator<SkinnedMultiMesh.Part>.Select<long>
	|-Enumerable.WhereEnumerableIterator<InventoryItem>.Select<InventoryItemId>
	|-Enumerable.WhereEnumerableIterator<InventoryItem>.Select<int>
	|-Enumerable.WhereEnumerableIterator<InventoryItem>.Select<object>
	|-Enumerable.WhereEnumerableIterator<InventoryItem>.Select<uint>
	|
	|-RVA: 0xC8CC60 Offset: 0xC8B260 VA: 0x180C8CC60
	|-Enumerable.WhereEnumerableIterator<ServerInfo>.Select<int>
	|-Enumerable.WhereEnumerableIterator<ServerInfo>.Select<object>
	|
	|-RVA: 0xC8CBD0 Offset: 0xC8B1D0 VA: 0x180C8CBD0
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe.Ingredient>.Select<PlayerItemRecipe.Ingredient>
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe.Ingredient>.Select<object>
	|-Enumerable.WhereEnumerableIterator<InventoryRecipe>.Select<PlayerItemRecipe>
	*/

	public override IEnumerable<TSource> Where(Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A2130 Offset: 0x16A0730 VA: 0x1816A2130
	|-Enumerable.WhereEnumerableIterator<Debugging.EntityInfo>.Where
	|-Enumerable.WhereEnumerableIterator<GameStat.Stat>.Where
	|-Enumerable.WhereEnumerableIterator<PlayerItemRecipe>.Where
	|-Enumerable.WhereEnumerableIterator<ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, int>>.Where
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, object>>.Where
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<uint, object>>.Where
	|-Enumerable.WhereEnumerableIterator<Resolution>.Where
	|
	|-RVA: 0x19DC6F0 Offset: 0x19DACF0 VA: 0x1819DC6F0
	|-Enumerable.WhereEnumerableIterator<SkeletonDefinition.Bone>.Where
	|
	|-RVA: 0x19DC650 Offset: 0x19DAC50 VA: 0x1819DC650
	|-Enumerable.WhereEnumerableIterator<ItemSkinDirectory.Skin>.Where
	|-Enumerable.WhereEnumerableIterator<Option>.Where
	|-Enumerable.WhereEnumerableIterator<SkinnedMultiMesh.Part>.Where
	|-Enumerable.WhereEnumerableIterator<InventoryItem>.Where
	|
	|-RVA: 0x16A2090 Offset: 0x16A0690 VA: 0x1816A2090
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
	|-RVA: 0x19DC790 Offset: 0x19DAD90 VA: 0x1819DC790
	|-Enumerable.WhereEnumerableIterator<ServerInfo>.Where
	|
	|-RVA: 0x19DC830 Offset: 0x19DAE30 VA: 0x1819DC830
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
	|-RVA: 0x16A3A30 Offset: 0x16A2030 VA: 0x1816A3A30
	|-Enumerable.WhereArrayIterator<SkeletonDefinition.Bone>..ctor
	|
	|-RVA: 0x16A21D0 Offset: 0x16A07D0 VA: 0x1816A21D0
	|-Enumerable.WhereArrayIterator<GameStat.Stat>..ctor
	|-Enumerable.WhereArrayIterator<ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereArrayIterator<KeyValuePair<object, object>>..ctor
	|-Enumerable.WhereArrayIterator<KeyValuePair<uint, object>>..ctor
	|
	|-RVA: 0x16A3AA0 Offset: 0x16A20A0 VA: 0x1816A3AA0
	|-Enumerable.WhereArrayIterator<ItemSkinDirectory.Skin>..ctor
	|-Enumerable.WhereArrayIterator<Option>..ctor
	|-Enumerable.WhereArrayIterator<SkinnedMultiMesh.Part>..ctor
	|-Enumerable.WhereArrayIterator<InventoryItem>..ctor
	|
	|-RVA: 0x16A3B10 Offset: 0x16A2110 VA: 0x1816A3B10
	|-Enumerable.WhereArrayIterator<ServerInfo>..ctor
	|
	|-RVA: 0x16A39C0 Offset: 0x16A1FC0 VA: 0x1816A39C0
	|-Enumerable.WhereArrayIterator<InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereArrayIterator<InventoryRecipe>..ctor
	|-Enumerable.WhereArrayIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>..ctor
	|
	|-RVA: 0x16A2240 Offset: 0x16A0840 VA: 0x1816A2240
	|-Enumerable.WhereArrayIterator<char>..ctor
	|-Enumerable.WhereArrayIterator<int>..ctor
	|-Enumerable.WhereArrayIterator<Int32Enum>..ctor
	|-Enumerable.WhereArrayIterator<object>..ctor
	*/

	public override Enumerable.Iterator<TSource> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A2330 Offset: 0x16A0930 VA: 0x1816A2330
	|-Enumerable.WhereArrayIterator<SkeletonDefinition.Bone>.Clone
	|
	|-RVA: 0x16A1AD0 Offset: 0x16A00D0 VA: 0x1816A1AD0
	|-Enumerable.WhereArrayIterator<GameStat.Stat>.Clone
	|-Enumerable.WhereArrayIterator<ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereArrayIterator<KeyValuePair<object, object>>.Clone
	|-Enumerable.WhereArrayIterator<KeyValuePair<uint, object>>.Clone
	|
	|-RVA: 0x16A22B0 Offset: 0x16A08B0 VA: 0x1816A22B0
	|-Enumerable.WhereArrayIterator<ItemSkinDirectory.Skin>.Clone
	|-Enumerable.WhereArrayIterator<Option>.Clone
	|-Enumerable.WhereArrayIterator<SkinnedMultiMesh.Part>.Clone
	|-Enumerable.WhereArrayIterator<InventoryItem>.Clone
	|
	|-RVA: 0x16A23B0 Offset: 0x16A09B0 VA: 0x1816A23B0
	|-Enumerable.WhereArrayIterator<ServerInfo>.Clone
	|
	|-RVA: 0x16A2440 Offset: 0x16A0A40 VA: 0x1816A2440
	|-Enumerable.WhereArrayIterator<InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereArrayIterator<InventoryRecipe>.Clone
	|-Enumerable.WhereArrayIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.Clone
	|
	|-RVA: 0x16A1B50 Offset: 0x16A0150 VA: 0x1816A1B50
	|-Enumerable.WhereArrayIterator<char>.Clone
	|-Enumerable.WhereArrayIterator<int>.Clone
	|-Enumerable.WhereArrayIterator<Int32Enum>.Clone
	|-Enumerable.WhereArrayIterator<object>.Clone
	*/

	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D7640 Offset: 0x19D5C40 VA: 0x1819D7640
	|-Enumerable.WhereArrayIterator<SkeletonDefinition.Bone>.MoveNext
	|
	|-RVA: 0x19D7560 Offset: 0x19D5B60 VA: 0x1819D7560
	|-Enumerable.WhereArrayIterator<GameStat.Stat>.MoveNext
	|-Enumerable.WhereArrayIterator<KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0x19D7460 Offset: 0x19D5A60 VA: 0x1819D7460
	|-Enumerable.WhereArrayIterator<ItemSkinDirectory.Skin>.MoveNext
	|-Enumerable.WhereArrayIterator<Option>.MoveNext
	|
	|-RVA: 0x19D7DE0 Offset: 0x19D63E0 VA: 0x1819D7DE0
	|-Enumerable.WhereArrayIterator<ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x19D7270 Offset: 0x19D5870 VA: 0x1819D7270
	|-Enumerable.WhereArrayIterator<ServerInfo>.MoveNext
	|
	|-RVA: 0x19D7A40 Offset: 0x19D6040 VA: 0x1819D7A40
	|-Enumerable.WhereArrayIterator<SkinnedMultiMesh.Part>.MoveNext
	|
	|-RVA: 0x19D7840 Offset: 0x19D5E40 VA: 0x1819D7840
	|-Enumerable.WhereArrayIterator<InventoryItem>.MoveNext
	|
	|-RVA: 0x19D7940 Offset: 0x19D5F40 VA: 0x1819D7940
	|-Enumerable.WhereArrayIterator<InventoryRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereArrayIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.MoveNext
	|
	|-RVA: 0x19D7CE0 Offset: 0x19D62E0 VA: 0x1819D7CE0
	|-Enumerable.WhereArrayIterator<InventoryRecipe>.MoveNext
	|
	|-RVA: 0x19D71B0 Offset: 0x19D57B0 VA: 0x1819D71B0
	|-Enumerable.WhereArrayIterator<char>.MoveNext
	|
	|-RVA: 0x19D7C00 Offset: 0x19D6200 VA: 0x1819D7C00
	|-Enumerable.WhereArrayIterator<KeyValuePair<uint, object>>.MoveNext
	|
	|-RVA: 0x19D7B40 Offset: 0x19D6140 VA: 0x1819D7B40
	|-Enumerable.WhereArrayIterator<int>.MoveNext
	|-Enumerable.WhereArrayIterator<Int32Enum>.MoveNext
	|
	|-RVA: 0x19D7770 Offset: 0x19D5D70 VA: 0x1819D7770
	|-Enumerable.WhereArrayIterator<object>.MoveNext
	*/

	public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC8CE10 Offset: 0xC8B410 VA: 0x180C8CE10
	|-Enumerable.WhereArrayIterator<SkeletonDefinition.Bone>.Select<object>
	|
	|-RVA: 0xC8CD80 Offset: 0xC8B380 VA: 0x180C8CD80
	|-Enumerable.WhereArrayIterator<ProjectileWeaponMod.Modifier>.Select<float>
	|-Enumerable.WhereArrayIterator<KeyValuePair<object, object>>.Select<object>
	|-Enumerable.WhereArrayIterator<KeyValuePair<uint, object>>.Select<object>
	|-Enumerable.WhereArrayIterator<KeyValuePair<uint, object>>.Select<uint>
	|
	|-RVA: 0xC8CCF0 Offset: 0xC8B2F0 VA: 0x180C8CCF0
	|-Enumerable.WhereArrayIterator<Option>.Select<Option>
	|-Enumerable.WhereArrayIterator<SkinnedMultiMesh.Part>.Select<long>
	|-Enumerable.WhereArrayIterator<InventoryItem>.Select<InventoryItemId>
	|-Enumerable.WhereArrayIterator<InventoryItem>.Select<int>
	|-Enumerable.WhereArrayIterator<InventoryItem>.Select<object>
	|-Enumerable.WhereArrayIterator<InventoryItem>.Select<uint>
	|
	|-RVA: 0xC8CC60 Offset: 0xC8B260 VA: 0x180C8CC60
	|-Enumerable.WhereArrayIterator<ServerInfo>.Select<int>
	|-Enumerable.WhereArrayIterator<ServerInfo>.Select<object>
	|
	|-RVA: 0xC8CBD0 Offset: 0xC8B1D0 VA: 0x180C8CBD0
	|-Enumerable.WhereArrayIterator<InventoryRecipe.Ingredient>.Select<PlayerItemRecipe.Ingredient>
	|-Enumerable.WhereArrayIterator<InventoryRecipe.Ingredient>.Select<object>
	|-Enumerable.WhereArrayIterator<InventoryRecipe>.Select<PlayerItemRecipe>
	|
	|-RVA: 0xC8CB40 Offset: 0xC8B140 VA: 0x180C8CB40
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
	|-RVA: 0x19D80B0 Offset: 0x19D66B0 VA: 0x1819D80B0
	|-Enumerable.WhereArrayIterator<SkeletonDefinition.Bone>.Where
	|
	|-RVA: 0x19D8010 Offset: 0x19D6610 VA: 0x1819D8010
	|-Enumerable.WhereArrayIterator<GameStat.Stat>.Where
	|-Enumerable.WhereArrayIterator<ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereArrayIterator<KeyValuePair<object, object>>.Where
	|-Enumerable.WhereArrayIterator<KeyValuePair<uint, object>>.Where
	|
	|-RVA: 0x19D7ED0 Offset: 0x19D64D0 VA: 0x1819D7ED0
	|-Enumerable.WhereArrayIterator<ItemSkinDirectory.Skin>.Where
	|-Enumerable.WhereArrayIterator<Option>.Where
	|-Enumerable.WhereArrayIterator<SkinnedMultiMesh.Part>.Where
	|-Enumerable.WhereArrayIterator<InventoryItem>.Where
	|
	|-RVA: 0x19D8150 Offset: 0x19D6750 VA: 0x1819D8150
	|-Enumerable.WhereArrayIterator<ServerInfo>.Where
	|
	|-RVA: 0x19D81F0 Offset: 0x19D67F0 VA: 0x1819D81F0
	|-Enumerable.WhereArrayIterator<InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereArrayIterator<InventoryRecipe>.Where
	|-Enumerable.WhereArrayIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.Where
	|
	|-RVA: 0x19D7F70 Offset: 0x19D6570 VA: 0x1819D7F70
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
	|-RVA: 0x16A3A30 Offset: 0x16A2030 VA: 0x1816A3A30
	|-Enumerable.WhereListIterator<SkeletonDefinition.Bone>..ctor
	|
	|-RVA: 0x16A21D0 Offset: 0x16A07D0 VA: 0x1816A21D0
	|-Enumerable.WhereListIterator<GameStat.Stat>..ctor
	|-Enumerable.WhereListIterator<ProjectileWeaponMod.Modifier>..ctor
	|-Enumerable.WhereListIterator<KeyValuePair<object, object>>..ctor
	|-Enumerable.WhereListIterator<KeyValuePair<uint, object>>..ctor
	|
	|-RVA: 0x16A3AA0 Offset: 0x16A20A0 VA: 0x1816A3AA0
	|-Enumerable.WhereListIterator<ItemSkinDirectory.Skin>..ctor
	|-Enumerable.WhereListIterator<Option>..ctor
	|-Enumerable.WhereListIterator<SkinnedMultiMesh.Part>..ctor
	|-Enumerable.WhereListIterator<InventoryItem>..ctor
	|
	|-RVA: 0x16A3B10 Offset: 0x16A2110 VA: 0x1816A3B10
	|-Enumerable.WhereListIterator<ServerInfo>..ctor
	|
	|-RVA: 0x16A39C0 Offset: 0x16A1FC0 VA: 0x1816A39C0
	|-Enumerable.WhereListIterator<InventoryRecipe.Ingredient>..ctor
	|-Enumerable.WhereListIterator<InventoryRecipe>..ctor
	|-Enumerable.WhereListIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>..ctor
	|
	|-RVA: 0x16A2240 Offset: 0x16A0840 VA: 0x1816A2240
	|-Enumerable.WhereListIterator<char>..ctor
	|-Enumerable.WhereListIterator<int>..ctor
	|-Enumerable.WhereListIterator<Int32Enum>..ctor
	|-Enumerable.WhereListIterator<object>..ctor
	*/

	public override Enumerable.Iterator<TSource> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A2330 Offset: 0x16A0930 VA: 0x1816A2330
	|-Enumerable.WhereListIterator<SkeletonDefinition.Bone>.Clone
	|
	|-RVA: 0x16A1AD0 Offset: 0x16A00D0 VA: 0x1816A1AD0
	|-Enumerable.WhereListIterator<GameStat.Stat>.Clone
	|-Enumerable.WhereListIterator<ProjectileWeaponMod.Modifier>.Clone
	|-Enumerable.WhereListIterator<KeyValuePair<object, object>>.Clone
	|-Enumerable.WhereListIterator<KeyValuePair<uint, object>>.Clone
	|
	|-RVA: 0x16A22B0 Offset: 0x16A08B0 VA: 0x1816A22B0
	|-Enumerable.WhereListIterator<ItemSkinDirectory.Skin>.Clone
	|-Enumerable.WhereListIterator<Option>.Clone
	|-Enumerable.WhereListIterator<SkinnedMultiMesh.Part>.Clone
	|-Enumerable.WhereListIterator<InventoryItem>.Clone
	|
	|-RVA: 0x16A23B0 Offset: 0x16A09B0 VA: 0x1816A23B0
	|-Enumerable.WhereListIterator<ServerInfo>.Clone
	|
	|-RVA: 0x16A2440 Offset: 0x16A0A40 VA: 0x1816A2440
	|-Enumerable.WhereListIterator<InventoryRecipe.Ingredient>.Clone
	|-Enumerable.WhereListIterator<InventoryRecipe>.Clone
	|-Enumerable.WhereListIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.Clone
	|
	|-RVA: 0x16A1B50 Offset: 0x16A0150 VA: 0x1816A1B50
	|-Enumerable.WhereListIterator<char>.Clone
	|-Enumerable.WhereListIterator<int>.Clone
	|-Enumerable.WhereListIterator<Int32Enum>.Clone
	|-Enumerable.WhereListIterator<object>.Clone
	*/

	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A24C0 Offset: 0x16A0AC0 VA: 0x1816A24C0
	|-Enumerable.WhereListIterator<SkeletonDefinition.Bone>.MoveNext
	|
	|-RVA: 0x16A2640 Offset: 0x16A0C40 VA: 0x1816A2640
	|-Enumerable.WhereListIterator<GameStat.Stat>.MoveNext
	|-Enumerable.WhereListIterator<KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0x16A29D0 Offset: 0x16A0FD0 VA: 0x1816A29D0
	|-Enumerable.WhereListIterator<ItemSkinDirectory.Skin>.MoveNext
	|-Enumerable.WhereListIterator<Option>.MoveNext
	|
	|-RVA: 0x16A2760 Offset: 0x16A0D60 VA: 0x1816A2760
	|-Enumerable.WhereListIterator<ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x16A2B20 Offset: 0x16A1120 VA: 0x1816A2B20
	|-Enumerable.WhereListIterator<ServerInfo>.MoveNext
	|
	|-RVA: 0x16A33B0 Offset: 0x16A19B0 VA: 0x1816A33B0
	|-Enumerable.WhereListIterator<SkinnedMultiMesh.Part>.MoveNext
	|
	|-RVA: 0x16A2880 Offset: 0x16A0E80 VA: 0x1816A2880
	|-Enumerable.WhereListIterator<InventoryItem>.MoveNext
	|
	|-RVA: 0x16A2FD0 Offset: 0x16A15D0 VA: 0x1816A2FD0
	|-Enumerable.WhereListIterator<InventoryRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereListIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.MoveNext
	|
	|-RVA: 0x16A3250 Offset: 0x16A1850 VA: 0x1816A3250
	|-Enumerable.WhereListIterator<InventoryRecipe>.MoveNext
	|
	|-RVA: 0x16A3500 Offset: 0x16A1B00 VA: 0x1816A3500
	|-Enumerable.WhereListIterator<char>.MoveNext
	|
	|-RVA: 0x16A3130 Offset: 0x16A1730 VA: 0x1816A3130
	|-Enumerable.WhereListIterator<KeyValuePair<uint, object>>.MoveNext
	|
	|-RVA: 0x16A2ED0 Offset: 0x16A14D0 VA: 0x1816A2ED0
	|-Enumerable.WhereListIterator<int>.MoveNext
	|-Enumerable.WhereListIterator<Int32Enum>.MoveNext
	|
	|-RVA: 0x16A2DC0 Offset: 0x16A13C0 VA: 0x1816A2DC0
	|-Enumerable.WhereListIterator<object>.MoveNext
	*/

	public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC8CE10 Offset: 0xC8B410 VA: 0x180C8CE10
	|-Enumerable.WhereListIterator<SkeletonDefinition.Bone>.Select<object>
	|
	|-RVA: 0xC8CD80 Offset: 0xC8B380 VA: 0x180C8CD80
	|-Enumerable.WhereListIterator<ProjectileWeaponMod.Modifier>.Select<float>
	|-Enumerable.WhereListIterator<KeyValuePair<object, object>>.Select<object>
	|-Enumerable.WhereListIterator<KeyValuePair<uint, object>>.Select<object>
	|-Enumerable.WhereListIterator<KeyValuePair<uint, object>>.Select<uint>
	|
	|-RVA: 0xC8CCF0 Offset: 0xC8B2F0 VA: 0x180C8CCF0
	|-Enumerable.WhereListIterator<Option>.Select<Option>
	|-Enumerable.WhereListIterator<SkinnedMultiMesh.Part>.Select<long>
	|-Enumerable.WhereListIterator<InventoryItem>.Select<InventoryItemId>
	|-Enumerable.WhereListIterator<InventoryItem>.Select<int>
	|-Enumerable.WhereListIterator<InventoryItem>.Select<object>
	|-Enumerable.WhereListIterator<InventoryItem>.Select<uint>
	|
	|-RVA: 0xC8CC60 Offset: 0xC8B260 VA: 0x180C8CC60
	|-Enumerable.WhereListIterator<ServerInfo>.Select<int>
	|-Enumerable.WhereListIterator<ServerInfo>.Select<object>
	|
	|-RVA: 0xC8CBD0 Offset: 0xC8B1D0 VA: 0x180C8CBD0
	|-Enumerable.WhereListIterator<InventoryRecipe.Ingredient>.Select<PlayerItemRecipe.Ingredient>
	|-Enumerable.WhereListIterator<InventoryRecipe.Ingredient>.Select<object>
	|-Enumerable.WhereListIterator<InventoryRecipe>.Select<PlayerItemRecipe>
	|
	|-RVA: 0xC8CB40 Offset: 0xC8B140 VA: 0x180C8CB40
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
	|-RVA: 0x16A3920 Offset: 0x16A1F20 VA: 0x1816A3920
	|-Enumerable.WhereListIterator<SkeletonDefinition.Bone>.Where
	|
	|-RVA: 0x16A3600 Offset: 0x16A1C00 VA: 0x1816A3600
	|-Enumerable.WhereListIterator<GameStat.Stat>.Where
	|-Enumerable.WhereListIterator<ProjectileWeaponMod.Modifier>.Where
	|-Enumerable.WhereListIterator<KeyValuePair<object, object>>.Where
	|-Enumerable.WhereListIterator<KeyValuePair<uint, object>>.Where
	|
	|-RVA: 0x16A36A0 Offset: 0x16A1CA0 VA: 0x1816A36A0
	|-Enumerable.WhereListIterator<ItemSkinDirectory.Skin>.Where
	|-Enumerable.WhereListIterator<Option>.Where
	|-Enumerable.WhereListIterator<SkinnedMultiMesh.Part>.Where
	|-Enumerable.WhereListIterator<InventoryItem>.Where
	|
	|-RVA: 0x16A3880 Offset: 0x16A1E80 VA: 0x1816A3880
	|-Enumerable.WhereListIterator<ServerInfo>.Where
	|
	|-RVA: 0x16A37E0 Offset: 0x16A1DE0 VA: 0x1816A37E0
	|-Enumerable.WhereListIterator<InventoryRecipe.Ingredient>.Where
	|-Enumerable.WhereListIterator<InventoryRecipe>.Where
	|-Enumerable.WhereListIterator<KeyValuePair<ulong, Dispatch.ResultCallback>>.Where
	|
	|-RVA: 0x16A3740 Offset: 0x16A1D40 VA: 0x1816A3740
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
	|-RVA: 0x16A8DE0 Offset: 0x16A73E0 VA: 0x1816A8DE0
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
	|-RVA: 0x16A8E70 Offset: 0x16A7470 VA: 0x1816A8E70
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
	|-RVA: 0x16A8F90 Offset: 0x16A7590 VA: 0x1816A8F90
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
	|-RVA: 0x16A8F00 Offset: 0x16A7500 VA: 0x1816A8F00
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
	|-RVA: 0x16A9020 Offset: 0x16A7620 VA: 0x1816A9020
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, ServerInfo>..ctor
	*/

	public override Enumerable.Iterator<TResult> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A3CC0 Offset: 0x16A22C0 VA: 0x1816A3CC0
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
	|-RVA: 0x16A3B80 Offset: 0x16A2180 VA: 0x1816A3B80
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
	|-RVA: 0x16A3C20 Offset: 0x16A2220 VA: 0x1816A3C20
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
	|-RVA: 0x16A3D60 Offset: 0x16A2360 VA: 0x1816A3D60
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
	|-RVA: 0x16A3E00 Offset: 0x16A2400 VA: 0x1816A3E00
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, ServerInfo>.Clone
	*/

	public override void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C02A0 Offset: 0x19BE8A0 VA: 0x1819C02A0
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, FourBitNumber>.Dispose
	|
	|-RVA: 0x19BFD90 Offset: 0x19BE390 VA: 0x1819BFD90
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, SevenBitNumber>.Dispose
	|
	|-RVA: 0x19BFC70 Offset: 0x19BE270 VA: 0x1819BFC70
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, int>.Dispose
	|
	|-RVA: 0x19C03C0 Offset: 0x19BE9C0 VA: 0x1819C03C0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x19C0450 Offset: 0x19BEA50 VA: 0x1819C0450
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, PathFinder.Point>.Dispose
	|
	|-RVA: 0x19C0330 Offset: 0x19BE930 VA: 0x1819C0330
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x19BFF40 Offset: 0x19BE540 VA: 0x1819BFF40
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Option>.Dispose
	|
	|-RVA: 0x19C00F0 Offset: 0x19BE6F0 VA: 0x1819C00F0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, InventoryItem>.Dispose
	|
	|-RVA: 0x19C0060 Offset: 0x19BE660 VA: 0x1819C0060
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x19BFD00 Offset: 0x19BE300 VA: 0x1819BFD00
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, InventoryRecipe>.Dispose
	|
	|-RVA: 0x19BFFD0 Offset: 0x19BE5D0 VA: 0x1819BFFD0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, bool>.Dispose
	|
	|-RVA: 0x19BFBE0 Offset: 0x19BE1E0 VA: 0x1819BFBE0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x19BFE20 Offset: 0x19BE420 VA: 0x1819BFE20
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, int>.Dispose
	|
	|-RVA: 0x19BFEB0 Offset: 0x19BE4B0 VA: 0x1819BFEB0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Int32Enum>.Dispose
	|
	|-RVA: 0x19C0210 Offset: 0x19BE810 VA: 0x1819C0210
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, long>.Dispose
	|
	|-RVA: 0x19C0180 Offset: 0x19BE780 VA: 0x1819C0180
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, object>.Dispose
	|
	|-RVA: 0x1A186D0 Offset: 0x1A16CD0 VA: 0x181A186D0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, float>.Dispose
	|
	|-RVA: 0x1A19A80 Offset: 0x1A18080 VA: 0x181A19A80
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Resolution>.Dispose
	|
	|-RVA: 0x1A19720 Offset: 0x1A17D20 VA: 0x181A19720
	|-Enumerable.WhereSelectEnumerableIterator<WeightedStringList.Container, float>.Dispose
	|
	|-RVA: 0x1A179E0 Offset: 0x1A15FE0 VA: 0x181A179E0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A18C70 Offset: 0x1A17270 VA: 0x181A18C70
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A19B10 Offset: 0x1A18110 VA: 0x181A19B10
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A167E0 Offset: 0x1A14DE0 VA: 0x181A167E0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Option>.Dispose
	|
	|-RVA: 0x1A18BE0 Offset: 0x1A171E0 VA: 0x181A18BE0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, InventoryItem>.Dispose
	|
	|-RVA: 0x1A17830 Offset: 0x1A15E30 VA: 0x181A17830
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A17D40 Offset: 0x1A16340 VA: 0x181A17D40
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A17E60 Offset: 0x1A16460 VA: 0x181A17E60
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, bool>.Dispose
	|
	|-RVA: 0x1A199F0 Offset: 0x1A17FF0 VA: 0x181A199F0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A19210 Offset: 0x1A17810 VA: 0x181A19210
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, int>.Dispose
	|
	|-RVA: 0x1A17A70 Offset: 0x1A16070 VA: 0x181A17A70
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Int32Enum>.Dispose
	|
	|-RVA: 0x1A17DD0 Offset: 0x1A163D0 VA: 0x181A17DD0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, long>.Dispose
	|
	|-RVA: 0x1A18520 Offset: 0x1A16B20 VA: 0x181A18520
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, object>.Dispose
	|
	|-RVA: 0x1A16870 Offset: 0x1A14E70 VA: 0x181A16870
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, float>.Dispose
	|
	|-RVA: 0x1A18370 Offset: 0x1A16970 VA: 0x181A18370
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Resolution>.Dispose
	|
	|-RVA: 0x1A173B0 Offset: 0x1A159B0 VA: 0x181A173B0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, FourBitNumber>.Dispose
	|
	|-RVA: 0x1A18D00 Offset: 0x1A17300 VA: 0x181A18D00
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, SevenBitNumber>.Dispose
	|
	|-RVA: 0x1A18FD0 Offset: 0x1A175D0 VA: 0x181A18FD0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, int>.Dispose
	|
	|-RVA: 0x1A175F0 Offset: 0x1A15BF0 VA: 0x181A175F0
	|-Enumerable.WhereSelectEnumerableIterator<ProjectileWeaponMod.Modifier, float>.Dispose
	|
	|-RVA: 0x1A16AB0 Offset: 0x1A150B0 VA: 0x181A16AB0
	|-Enumerable.WhereSelectEnumerableIterator<Option, Option>.Dispose
	|
	|-RVA: 0x1A189A0 Offset: 0x1A16FA0 VA: 0x181A189A0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A18760 Offset: 0x1A16D60 VA: 0x181A18760
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, FourBitNumber>.Dispose
	|
	|-RVA: 0x1A17710 Offset: 0x1A15D10 VA: 0x181A17710
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, SevenBitNumber>.Dispose
	|
	|-RVA: 0x1A190F0 Offset: 0x1A176F0 VA: 0x181A190F0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A174D0 Offset: 0x1A15AD0 VA: 0x181A174D0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A18D90 Offset: 0x1A17390 VA: 0x181A18D90
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Option>.Dispose
	|
	|-RVA: 0x1A18A30 Offset: 0x1A17030 VA: 0x181A18A30
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, InventoryItem>.Dispose
	|
	|-RVA: 0x1A16900 Offset: 0x1A14F00 VA: 0x181A16900
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A16B40 Offset: 0x1A15140 VA: 0x181A16B40
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A180A0 Offset: 0x1A166A0 VA: 0x181A180A0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, bool>.Dispose
	|
	|-RVA: 0x1A16EA0 Offset: 0x1A154A0 VA: 0x181A16EA0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A187F0 Offset: 0x1A16DF0 VA: 0x181A187F0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, int>.Dispose
	|
	|-RVA: 0x1A17B90 Offset: 0x1A16190 VA: 0x181A17B90
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Int32Enum>.Dispose
	|
	|-RVA: 0x1A17320 Offset: 0x1A15920 VA: 0x181A17320
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, long>.Dispose
	|
	|-RVA: 0x1A18250 Offset: 0x1A16850 VA: 0x181A18250
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.Dispose
	|
	|-RVA: 0x1A166C0 Offset: 0x1A14CC0 VA: 0x181A166C0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, float>.Dispose
	|
	|-RVA: 0x1A165A0 Offset: 0x1A14BA0 VA: 0x181A165A0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Resolution>.Dispose
	|
	|-RVA: 0x1A17440 Offset: 0x1A15A40 VA: 0x181A17440
	|-Enumerable.WhereSelectEnumerableIterator<SkinnedMultiMesh.Part, long>.Dispose
	|
	|-RVA: 0x1A16FC0 Offset: 0x1A155C0 VA: 0x181A16FC0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A177A0 Offset: 0x1A15DA0 VA: 0x181A177A0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A16510 Offset: 0x1A14B10 VA: 0x181A16510
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A17680 Offset: 0x1A15C80 VA: 0x181A17680
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Option>.Dispose
	|
	|-RVA: 0x1A18010 Offset: 0x1A16610 VA: 0x181A18010
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, InventoryItem>.Dispose
	|
	|-RVA: 0x1A18640 Offset: 0x1A16C40 VA: 0x181A18640
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A192A0 Offset: 0x1A178A0 VA: 0x181A192A0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A17950 Offset: 0x1A15F50 VA: 0x181A17950
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, bool>.Dispose
	|
	|-RVA: 0x1A16F30 Offset: 0x1A15530 VA: 0x181A16F30
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A16360 Offset: 0x1A14960 VA: 0x181A16360
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, int>.Dispose
	|
	|-RVA: 0x1A17EF0 Offset: 0x1A164F0 VA: 0x181A17EF0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Int32Enum>.Dispose
	|
	|-RVA: 0x1A17F80 Offset: 0x1A16580 VA: 0x181A17F80
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, long>.Dispose
	|
	|-RVA: 0x1A16750 Offset: 0x1A14D50 VA: 0x181A16750
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, object>.Dispose
	|
	|-RVA: 0x1A194E0 Offset: 0x1A17AE0 VA: 0x181A194E0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, float>.Dispose
	|
	|-RVA: 0x1A18F40 Offset: 0x1A17540 VA: 0x181A18F40
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Resolution>.Dispose
	|
	|-RVA: 0x1A197B0 Offset: 0x1A17DB0 VA: 0x181A197B0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A16990 Offset: 0x1A14F90 VA: 0x181A16990
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A19060 Offset: 0x1A17660 VA: 0x181A19060
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A19450 Offset: 0x1A17A50 VA: 0x181A19450
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Option>.Dispose
	|
	|-RVA: 0x1A19570 Offset: 0x1A17B70 VA: 0x181A19570
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, InventoryItem>.Dispose
	|
	|-RVA: 0x1A18910 Offset: 0x1A16F10 VA: 0x181A18910
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A17050 Offset: 0x1A15650 VA: 0x181A17050
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A16630 Offset: 0x1A14C30 VA: 0x181A16630
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, bool>.Dispose
	|
	|-RVA: 0x1A18E20 Offset: 0x1A17420 VA: 0x181A18E20
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A18880 Offset: 0x1A16E80 VA: 0x181A18880
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, int>.Dispose
	|
	|-RVA: 0x1A193C0 Offset: 0x1A179C0 VA: 0x181A193C0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Int32Enum>.Dispose
	|
	|-RVA: 0x1A185B0 Offset: 0x1A16BB0 VA: 0x181A185B0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, long>.Dispose
	|
	|-RVA: 0x1A163F0 Offset: 0x1A149F0 VA: 0x181A163F0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, object>.Dispose
	|
	|-RVA: 0x1A17560 Offset: 0x1A15B60 VA: 0x181A17560
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, float>.Dispose
	|
	|-RVA: 0x1A178C0 Offset: 0x1A15EC0 VA: 0x181A178C0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Resolution>.Dispose
	|
	|-RVA: 0x1A19600 Offset: 0x1A17C00 VA: 0x181A19600
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, ServerInfo>.Dispose
	|
	|-RVA: 0x1A18490 Offset: 0x1A16A90 VA: 0x181A18490
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, int>.Dispose
	|
	|-RVA: 0x1A16480 Offset: 0x1A14A80 VA: 0x181A16480
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.Dispose
	|
	|-RVA: 0x1A170E0 Offset: 0x1A156E0 VA: 0x181A170E0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A16BD0 Offset: 0x1A151D0 VA: 0x181A16BD0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A19690 Offset: 0x1A17C90 VA: 0x181A19690
	|-Enumerable.WhereSelectEnumerableIterator<Friend, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A18400 Offset: 0x1A16A00 VA: 0x181A18400
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Option>.Dispose
	|
	|-RVA: 0x1A19330 Offset: 0x1A17930 VA: 0x181A19330
	|-Enumerable.WhereSelectEnumerableIterator<Friend, InventoryItem>.Dispose
	|
	|-RVA: 0x1A16D80 Offset: 0x1A15380 VA: 0x181A16D80
	|-Enumerable.WhereSelectEnumerableIterator<Friend, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A182E0 Offset: 0x1A168E0 VA: 0x181A182E0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A16E10 Offset: 0x1A15410 VA: 0x181A16E10
	|-Enumerable.WhereSelectEnumerableIterator<Friend, bool>.Dispose
	|
	|-RVA: 0x1A19960 Offset: 0x1A17F60 VA: 0x181A19960
	|-Enumerable.WhereSelectEnumerableIterator<Friend, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A18AC0 Offset: 0x1A170C0 VA: 0x181A18AC0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, int>.Dispose
	|
	|-RVA: 0x1A181C0 Offset: 0x1A167C0 VA: 0x181A181C0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Int32Enum>.Dispose
	|
	|-RVA: 0x1A16CF0 Offset: 0x1A152F0 VA: 0x181A16CF0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, long>.Dispose
	|
	|-RVA: 0x1A18130 Offset: 0x1A16730 VA: 0x181A18130
	|-Enumerable.WhereSelectEnumerableIterator<Friend, object>.Dispose
	|
	|-RVA: 0x1A17B00 Offset: 0x1A16100 VA: 0x181A17B00
	|-Enumerable.WhereSelectEnumerableIterator<Friend, float>.Dispose
	|
	|-RVA: 0x1A17CB0 Offset: 0x1A162B0 VA: 0x181A17CB0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Resolution>.Dispose
	|
	|-RVA: 0x1A19840 Offset: 0x1A17E40 VA: 0x181A19840
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A17200 Offset: 0x1A15800 VA: 0x181A17200
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, FourBitNumber>.Dispose
	|
	|-RVA: 0x1A19180 Offset: 0x1A17780 VA: 0x181A19180
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, SevenBitNumber>.Dispose
	|
	|-RVA: 0x1A16A20 Offset: 0x1A15020 VA: 0x181A16A20
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A162D0 Offset: 0x1A148D0 VA: 0x181A162D0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A18EB0 Offset: 0x1A174B0 VA: 0x181A18EB0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Option>.Dispose
	|
	|-RVA: 0x1A17170 Offset: 0x1A15770 VA: 0x181A17170
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryItemId>.Dispose
	|
	|-RVA: 0x1A16C60 Offset: 0x1A15260 VA: 0x181A16C60
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryItem>.Dispose
	|
	|-RVA: 0x1A17C20 Offset: 0x1A16220 VA: 0x181A17C20
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A17290 Offset: 0x1A15890 VA: 0x181A17290
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A18B50 Offset: 0x1A17150 VA: 0x181A18B50
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, bool>.Dispose
	|
	|-RVA: 0x1A198D0 Offset: 0x1A17ED0 VA: 0x181A198D0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A29AD0 Offset: 0x1A280D0 VA: 0x181A29AD0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, int>.Dispose
	|
	|-RVA: 0x1A276D0 Offset: 0x1A25CD0 VA: 0x181A276D0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Int32Enum>.Dispose
	|
	|-RVA: 0x1A277F0 Offset: 0x1A25DF0 VA: 0x181A277F0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, long>.Dispose
	|
	|-RVA: 0x1A26B00 Offset: 0x1A25100 VA: 0x181A26B00
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, object>.Dispose
	|
	|-RVA: 0x1A28D50 Offset: 0x1A27350 VA: 0x181A28D50
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, float>.Dispose
	|
	|-RVA: 0x1A272E0 Offset: 0x1A258E0 VA: 0x181A272E0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, uint>.Dispose
	|
	|-RVA: 0x1A27B50 Offset: 0x1A26150 VA: 0x181A27B50
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Resolution>.Dispose
	|
	|-RVA: 0x1A27D00 Offset: 0x1A26300 VA: 0x181A27D00
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem.Amount, InventoryItemId>.Dispose
	|
	|-RVA: 0x1A29F50 Offset: 0x1A28550 VA: 0x181A29F50
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem.Amount, uint>.Dispose
	|
	|-RVA: 0x1A28A80 Offset: 0x1A27080 VA: 0x181A28A80
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe, PlayerItemRecipe>.Dispose
	|
	|-RVA: 0x1A292F0 Offset: 0x1A278F0 VA: 0x181A292F0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe, object>.Dispose
	|
	|-RVA: 0x1A26EF0 Offset: 0x1A254F0 VA: 0x181A26EF0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A27640 Offset: 0x1A25C40 VA: 0x181A27640
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A29D10 Offset: 0x1A28310 VA: 0x181A29D10
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A29B60 Offset: 0x1A28160 VA: 0x181A29B60
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A29650 Offset: 0x1A27C50 VA: 0x181A29650
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Option>.Dispose
	|
	|-RVA: 0x1A28F00 Offset: 0x1A27500 VA: 0x181A28F00
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, InventoryItem>.Dispose
	|
	|-RVA: 0x1A29140 Offset: 0x1A27740 VA: 0x181A29140
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A27520 Offset: 0x1A25B20 VA: 0x181A27520
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A26CB0 Offset: 0x1A252B0 VA: 0x181A26CB0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, bool>.Dispose
	|
	|-RVA: 0x1A27490 Offset: 0x1A25A90 VA: 0x181A27490
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A29260 Offset: 0x1A27860 VA: 0x181A29260
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, int>.Dispose
	|
	|-RVA: 0x1A287B0 Offset: 0x1A26DB0 VA: 0x181A287B0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Int32Enum>.Dispose
	|
	|-RVA: 0x1A29BF0 Offset: 0x1A281F0 VA: 0x181A29BF0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, long>.Dispose
	|
	|-RVA: 0x1A28690 Offset: 0x1A26C90 VA: 0x181A28690
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, object>.Dispose
	|
	|-RVA: 0x1A296E0 Offset: 0x1A27CE0 VA: 0x181A296E0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, float>.Dispose
	|
	|-RVA: 0x1A27130 Offset: 0x1A25730 VA: 0x181A27130
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Resolution>.Dispose
	|
	|-RVA: 0x1A28C30 Offset: 0x1A27230 VA: 0x181A28C30
	|-Enumerable.WhereSelectEnumerableIterator<DictionaryEntry, KeyValuePair<object, object>>.Dispose
	|
	|-RVA: 0x1A27400 Offset: 0x1A25A00 VA: 0x181A27400
	|-Enumerable.WhereSelectEnumerableIterator<DictionaryEntry, object>.Dispose
	|
	|-RVA: 0x1A268C0 Offset: 0x1A24EC0 VA: 0x181A268C0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A28570 Offset: 0x1A26B70 VA: 0x181A28570
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A26A70 Offset: 0x1A25070 VA: 0x181A26A70
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A27010 Offset: 0x1A25610 VA: 0x181A27010
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Option>.Dispose
	|
	|-RVA: 0x1A28960 Offset: 0x1A26F60 VA: 0x181A28960
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, InventoryItem>.Dispose
	|
	|-RVA: 0x1A280F0 Offset: 0x1A266F0 VA: 0x181A280F0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A289F0 Offset: 0x1A26FF0 VA: 0x181A289F0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A27D90 Offset: 0x1A26390 VA: 0x181A27D90
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, bool>.Dispose
	|
	|-RVA: 0x1A290B0 Offset: 0x1A276B0 VA: 0x181A290B0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A29EC0 Offset: 0x1A284C0 VA: 0x181A29EC0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, int>.Dispose
	|
	|-RVA: 0x1A27910 Offset: 0x1A25F10 VA: 0x181A27910
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Int32Enum>.Dispose
	|
	|-RVA: 0x1A269E0 Offset: 0x1A24FE0 VA: 0x181A269E0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, long>.Dispose
	|
	|-RVA: 0x1A270A0 Offset: 0x1A256A0 VA: 0x181A270A0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Dispose
	|
	|-RVA: 0x1A29770 Offset: 0x1A27D70 VA: 0x181A29770
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, float>.Dispose
	|
	|-RVA: 0x1A26F80 Offset: 0x1A25580 VA: 0x181A26F80
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Resolution>.Dispose
	|
	|-RVA: 0x1A27A30 Offset: 0x1A26030 VA: 0x181A27A30
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A29530 Offset: 0x1A27B30 VA: 0x181A29530
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A26DD0 Offset: 0x1A253D0 VA: 0x181A26DD0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A29920 Offset: 0x1A27F20 VA: 0x181A29920
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Option>.Dispose
	|
	|-RVA: 0x1A29E30 Offset: 0x1A28430 VA: 0x181A29E30
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, InventoryItem>.Dispose
	|
	|-RVA: 0x1A28840 Offset: 0x1A26E40 VA: 0x181A28840
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A299B0 Offset: 0x1A27FB0 VA: 0x181A299B0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A28E70 Offset: 0x1A27470 VA: 0x181A28E70
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, bool>.Dispose
	|
	|-RVA: 0x1A279A0 Offset: 0x1A25FA0 VA: 0x181A279A0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A26D40 Offset: 0x1A25340 VA: 0x181A26D40
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, int>.Dispose
	|
	|-RVA: 0x1A28B10 Offset: 0x1A27110 VA: 0x181A28B10
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Int32Enum>.Dispose
	|
	|-RVA: 0x1A27250 Offset: 0x1A25850 VA: 0x181A27250
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, long>.Dispose
	|
	|-RVA: 0x1A29800 Offset: 0x1A27E00 VA: 0x181A29800
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, object>.Dispose
	|
	|-RVA: 0x1A271C0 Offset: 0x1A257C0 VA: 0x181A271C0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, float>.Dispose
	|
	|-RVA: 0x1A27370 Offset: 0x1A25970 VA: 0x181A27370
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, uint>.Dispose
	|
	|-RVA: 0x1A28330 Offset: 0x1A26930 VA: 0x181A28330
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Resolution>.Dispose
	|
	|-RVA: 0x1A295C0 Offset: 0x1A27BC0 VA: 0x181A295C0
	|-Enumerable.WhereSelectEnumerableIterator<int, FourBitNumber>.Dispose
	|
	|-RVA: 0x1A29020 Offset: 0x1A27620 VA: 0x181A29020
	|-Enumerable.WhereSelectEnumerableIterator<int, SevenBitNumber>.Dispose
	|
	|-RVA: 0x1A28600 Offset: 0x1A26C00 VA: 0x181A28600
	|-Enumerable.WhereSelectEnumerableIterator<int, int>.Dispose
	|
	|-RVA: 0x1A28720 Offset: 0x1A26D20 VA: 0x181A28720
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A29DA0 Offset: 0x1A283A0 VA: 0x181A29DA0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A28210 Offset: 0x1A26810 VA: 0x181A28210
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A28180 Offset: 0x1A26780 VA: 0x181A28180
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Option>.Dispose
	|
	|-RVA: 0x1A28450 Offset: 0x1A26A50 VA: 0x181A28450
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, InventoryItem>.Dispose
	|
	|-RVA: 0x1A284E0 Offset: 0x1A26AE0 VA: 0x181A284E0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A27C70 Offset: 0x1A26270 VA: 0x181A27C70
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A27AC0 Offset: 0x1A260C0 VA: 0x181A27AC0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, bool>.Dispose
	|
	|-RVA: 0x1A28F90 Offset: 0x1A27590 VA: 0x181A28F90
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A29A40 Offset: 0x1A28040 VA: 0x181A29A40
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, int>.Dispose
	|
	|-RVA: 0x1A291D0 Offset: 0x1A277D0 VA: 0x181A291D0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Int32Enum>.Dispose
	|
	|-RVA: 0x1A29890 Offset: 0x1A27E90 VA: 0x181A29890
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, long>.Dispose
	|
	|-RVA: 0x1A27F40 Offset: 0x1A26540 VA: 0x181A27F40
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.Dispose
	|
	|-RVA: 0x1A282A0 Offset: 0x1A268A0 VA: 0x181A282A0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, float>.Dispose
	|
	|-RVA: 0x1A26C20 Offset: 0x1A25220 VA: 0x181A26C20
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Resolution>.Dispose
	|
	|-RVA: 0x1A283C0 Offset: 0x1A269C0 VA: 0x181A283C0
	|-Enumerable.WhereSelectEnumerableIterator<object, Debugging.EntityInfo>.Dispose
	|
	|-RVA: 0x1A27FD0 Offset: 0x1A265D0 VA: 0x181A27FD0
	|-Enumerable.WhereSelectEnumerableIterator<object, FourBitNumber>.Dispose
	|
	|-RVA: 0x1A28BA0 Offset: 0x1A271A0 VA: 0x181A28BA0
	|-Enumerable.WhereSelectEnumerableIterator<object, SevenBitNumber>.Dispose
	|
	|-RVA: 0x1A275B0 Offset: 0x1A25BB0 VA: 0x181A275B0
	|-Enumerable.WhereSelectEnumerableIterator<object, PathFinder.Point>.Dispose
	|
	|-RVA: 0x1A26B90 Offset: 0x1A25190 VA: 0x181A26B90
	|-Enumerable.WhereSelectEnumerableIterator<object, PlayerItemRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A26830 Offset: 0x1A24E30 VA: 0x181A26830
	|-Enumerable.WhereSelectEnumerableIterator<object, PlayerItemRecipe>.Dispose
	|
	|-RVA: 0x1A29C80 Offset: 0x1A28280 VA: 0x181A29C80
	|-Enumerable.WhereSelectEnumerableIterator<object, ProjectileWeaponMod.Modifier>.Dispose
	|
	|-RVA: 0x1A26950 Offset: 0x1A24F50 VA: 0x181A26950
	|-Enumerable.WhereSelectEnumerableIterator<object, Option>.Dispose
	|
	|-RVA: 0x1A28060 Offset: 0x1A26660 VA: 0x181A28060
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryItemId>.Dispose
	|
	|-RVA: 0x1A26E60 Offset: 0x1A25460 VA: 0x181A26E60
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryItem>.Dispose
	|
	|-RVA: 0x1A27760 Offset: 0x1A25D60 VA: 0x181A27760
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryRecipe.Ingredient>.Dispose
	|
	|-RVA: 0x1A27880 Offset: 0x1A25E80 VA: 0x181A27880
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryRecipe>.Dispose
	|
	|-RVA: 0x1A29410 Offset: 0x1A27A10 VA: 0x181A29410
	|-Enumerable.WhereSelectEnumerableIterator<object, bool>.Dispose
	|
	|-RVA: 0x1A288D0 Offset: 0x1A26ED0 VA: 0x181A288D0
	|-Enumerable.WhereSelectEnumerableIterator<object, KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x1A27E20 Offset: 0x1A26420 VA: 0x181A27E20
	|-Enumerable.WhereSelectEnumerableIterator<object, int>.Dispose
	|
	|-RVA: 0x1A28CC0 Offset: 0x1A272C0 VA: 0x181A28CC0
	|-Enumerable.WhereSelectEnumerableIterator<object, Int32Enum>.Dispose
	|
	|-RVA: 0x1A27EB0 Offset: 0x1A264B0 VA: 0x181A27EB0
	|-Enumerable.WhereSelectEnumerableIterator<object, long>.Dispose
	|
	|-RVA: 0x1A27BE0 Offset: 0x1A261E0 VA: 0x181A27BE0
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Dispose
	|
	|-RVA: 0x1A29380 Offset: 0x1A27980 VA: 0x181A29380
	|-Enumerable.WhereSelectEnumerableIterator<object, float>.Dispose
	|
	|-RVA: 0x1A294A0 Offset: 0x1A27AA0 VA: 0x181A294A0
	|-Enumerable.WhereSelectEnumerableIterator<object, uint>.Dispose
	|
	|-RVA: 0x1A28DE0 Offset: 0x1A273E0 VA: 0x181A28DE0
	|-Enumerable.WhereSelectEnumerableIterator<object, Resolution>.Dispose
	*/

	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C0C40 Offset: 0x19BF240 VA: 0x1819C0C40
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, FourBitNumber>.MoveNext
	|
	|-RVA: 0x19C1510 Offset: 0x19BFB10 VA: 0x1819C1510
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, SevenBitNumber>.MoveNext
	|
	|-RVA: 0x19C18F0 Offset: 0x19BFEF0 VA: 0x1819C18F0
	|-Enumerable.WhereSelectEnumerableIterator<BurstCloth.Chain, int>.MoveNext
	|
	|-RVA: 0x19C1A70 Offset: 0x19C0070 VA: 0x1819C1A70
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x19C0760 Offset: 0x19BED60 VA: 0x1819C0760
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x19C12A0 Offset: 0x19BF8A0 VA: 0x1819C12A0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x19C21B0 Offset: 0x19C07B0 VA: 0x1819C21B0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Option>.MoveNext
	|
	|-RVA: 0x19C0DC0 Offset: 0x19BF3C0 VA: 0x1819C0DC0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, InventoryItem>.MoveNext
	|
	|-RVA: 0x19C09C0 Offset: 0x19BEFC0 VA: 0x1819C09C0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x19C04E0 Offset: 0x19BEAE0 VA: 0x1819C04E0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x19C1CE0 Offset: 0x19C02E0 VA: 0x1819C1CE0
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, bool>.MoveNext
	|
	|-RVA: 0x19C1F40 Offset: 0x19C0540 VA: 0x1819C1F40
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x19C1690 Offset: 0x19BFC90 VA: 0x1819C1690
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, int>.MoveNext
	|
	|-RVA: 0x19C2430 Offset: 0x19C0A30 VA: 0x1819C2430
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Int32Enum>.MoveNext
	|
	|-RVA: 0x19C1040 Offset: 0x19BF640 VA: 0x1819C1040
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, long>.MoveNext
	|
	|-RVA: 0x19C2690 Offset: 0x19C0C90 VA: 0x1819C2690
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, object>.MoveNext
	|
	|-RVA: 0x1A24B40 Offset: 0x1A23140 VA: 0x181A24B40
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, float>.MoveNext
	|
	|-RVA: 0x1A1C240 Offset: 0x1A1A840 VA: 0x181A1C240
	|-Enumerable.WhereSelectEnumerableIterator<SkeletonDefinition.Bone, Resolution>.MoveNext
	|
	|-RVA: 0x1A1ED60 Offset: 0x1A1D360 VA: 0x181A1ED60
	|-Enumerable.WhereSelectEnumerableIterator<WeightedStringList.Container, float>.MoveNext
	|
	|-RVA: 0x1A254D0 Offset: 0x1A23AD0 VA: 0x181A254D0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A22450 Offset: 0x1A20A50 VA: 0x181A22450
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A1B540 Offset: 0x1A19B40 VA: 0x181A1B540
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A21090 Offset: 0x1A1F690 VA: 0x181A21090
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Option>.MoveNext
	|
	|-RVA: 0x1A1E790 Offset: 0x1A1CD90 VA: 0x181A1E790
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A230A0 Offset: 0x1A216A0 VA: 0x181A230A0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A24490 Offset: 0x1A22A90 VA: 0x181A24490
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A20E80 Offset: 0x1A1F480 VA: 0x181A20E80
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, bool>.MoveNext
	|
	|-RVA: 0x1A23A40 Offset: 0x1A22040 VA: 0x181A23A40
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A1EB50 Offset: 0x1A1D150 VA: 0x181A1EB50
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, int>.MoveNext
	|
	|-RVA: 0x1A1EF70 Offset: 0x1A1D570 VA: 0x181A1EF70
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A219C0 Offset: 0x1A1FFC0 VA: 0x181A219C0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, long>.MoveNext
	|
	|-RVA: 0x1A1C020 Offset: 0x1A1A620 VA: 0x181A1C020
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, object>.MoveNext
	|
	|-RVA: 0x1A24930 Offset: 0x1A22F30 VA: 0x181A24930
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, float>.MoveNext
	|
	|-RVA: 0x1A1FC30 Offset: 0x1A1E230 VA: 0x181A1FC30
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe, Resolution>.MoveNext
	|
	|-RVA: 0x1A22C00 Offset: 0x1A21200 VA: 0x181A22C00
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, FourBitNumber>.MoveNext
	|
	|-RVA: 0x1A24310 Offset: 0x1A22910 VA: 0x181A24310
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, SevenBitNumber>.MoveNext
	|
	|-RVA: 0x1A1F5E0 Offset: 0x1A1DBE0 VA: 0x181A1F5E0
	|-Enumerable.WhereSelectEnumerableIterator<PlayerItemRecipe.Ingredient, int>.MoveNext
	|
	|-RVA: 0x1A1AAC0 Offset: 0x1A190C0 VA: 0x181A1AAC0
	|-Enumerable.WhereSelectEnumerableIterator<ProjectileWeaponMod.Modifier, float>.MoveNext
	|
	|-RVA: 0x1A22660 Offset: 0x1A20C60 VA: 0x181A22660
	|-Enumerable.WhereSelectEnumerableIterator<Option, Option>.MoveNext
	|
	|-RVA: 0x1A1A0F0 Offset: 0x1A186F0 VA: 0x181A1A0F0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A1AFC0 Offset: 0x1A195C0 VA: 0x181A1AFC0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, FourBitNumber>.MoveNext
	|
	|-RVA: 0x1A262A0 Offset: 0x1A248A0 VA: 0x181A262A0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, SevenBitNumber>.MoveNext
	|
	|-RVA: 0x1A25DA0 Offset: 0x1A243A0 VA: 0x181A25DA0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A26560 Offset: 0x1A24B60 VA: 0x181A26560
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A205D0 Offset: 0x1A1EBD0 VA: 0x181A205D0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Option>.MoveNext
	|
	|-RVA: 0x1A1DC90 Offset: 0x1A1C290 VA: 0x181A1DC90
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A1F300 Offset: 0x1A1D900 VA: 0x181A1F300
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A1ACE0 Offset: 0x1A192E0 VA: 0x181A1ACE0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A1B280 Offset: 0x1A19880 VA: 0x181A1B280
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, bool>.MoveNext
	|
	|-RVA: 0x1A1C7D0 Offset: 0x1A1ADD0 VA: 0x181A1C7D0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A1D4B0 Offset: 0x1A1BAB0 VA: 0x181A1D4B0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, int>.MoveNext
	|
	|-RVA: 0x1A25880 Offset: 0x1A23E80 VA: 0x181A25880
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A23E10 Offset: 0x1A22410 VA: 0x181A23E10
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, long>.MoveNext
	|
	|-RVA: 0x1A20A30 Offset: 0x1A1F030 VA: 0x181A20A30
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.MoveNext
	|
	|-RVA: 0x1A20190 Offset: 0x1A1E790 VA: 0x181A20190
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, float>.MoveNext
	|
	|-RVA: 0x1A232E0 Offset: 0x1A218E0 VA: 0x181A232E0
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, Resolution>.MoveNext
	|
	|-RVA: 0x1A21450 Offset: 0x1A1FA50 VA: 0x181A21450
	|-Enumerable.WhereSelectEnumerableIterator<SkinnedMultiMesh.Part, long>.MoveNext
	|
	|-RVA: 0x1A228C0 Offset: 0x1A20EC0 VA: 0x181A228C0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A21D70 Offset: 0x1A20370 VA: 0x181A21D70
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A212C0 Offset: 0x1A1F8C0 VA: 0x181A212C0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A1FE50 Offset: 0x1A1E450 VA: 0x181A1FE50
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Option>.MoveNext
	|
	|-RVA: 0x1A1F760 Offset: 0x1A1DD60 VA: 0x181A1F760
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A21BD0 Offset: 0x1A201D0 VA: 0x181A21BD0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A1CC20 Offset: 0x1A1B220 VA: 0x181A1CC20
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A25350 Offset: 0x1A23950 VA: 0x181A25350
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, bool>.MoveNext
	|
	|-RVA: 0x1A1C630 Offset: 0x1A1AC30 VA: 0x181A1C630
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A238C0 Offset: 0x1A21EC0 VA: 0x181A238C0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, int>.MoveNext
	|
	|-RVA: 0x1A1C4B0 Offset: 0x1A1AAB0 VA: 0x181A1C4B0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A222D0 Offset: 0x1A208D0 VA: 0x181A222D0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, long>.MoveNext
	|
	|-RVA: 0x1A1FAA0 Offset: 0x1A1E0A0 VA: 0x181A1FAA0
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, object>.MoveNext
	|
	|-RVA: 0x1A19F60 Offset: 0x1A18560 VA: 0x181A19F60
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, float>.MoveNext
	|
	|-RVA: 0x1A21690 Offset: 0x1A1FC90 VA: 0x181A21690
	|-Enumerable.WhereSelectEnumerableIterator<Achievement, Resolution>.MoveNext
	|
	|-RVA: 0x1A1BB50 Offset: 0x1A1A150 VA: 0x181A1BB50
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A1F180 Offset: 0x1A1D780 VA: 0x181A1F180
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A1CDC0 Offset: 0x1A1B3C0 VA: 0x181A1CDC0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A23C70 Offset: 0x1A22270 VA: 0x181A23C70
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Option>.MoveNext
	|
	|-RVA: 0x1A1BCE0 Offset: 0x1A1A2E0 VA: 0x181A1BCE0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A24DC0 Offset: 0x1A233C0 VA: 0x181A24DC0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A1BE80 Offset: 0x1A1A480 VA: 0x181A1BE80
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A1E610 Offset: 0x1A1CC10 VA: 0x181A1E610
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, bool>.MoveNext
	|
	|-RVA: 0x1A1DF70 Offset: 0x1A1C570 VA: 0x181A1DF70
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A1CF50 Offset: 0x1A1B550 VA: 0x181A1CF50
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, int>.MoveNext
	|
	|-RVA: 0x1A19DE0 Offset: 0x1A183E0 VA: 0x181A19DE0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A208B0 Offset: 0x1A1EEB0 VA: 0x181A208B0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, long>.MoveNext
	|
	|-RVA: 0x1A24F60 Offset: 0x1A23560 VA: 0x181A24F60
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, object>.MoveNext
	|
	|-RVA: 0x1A20450 Offset: 0x1A1EA50 VA: 0x181A20450
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, float>.MoveNext
	|
	|-RVA: 0x1A22D80 Offset: 0x1A21380 VA: 0x181A22D80
	|-Enumerable.WhereSelectEnumerableIterator<InventoryDefId, Resolution>.MoveNext
	|
	|-RVA: 0x1A1A790 Offset: 0x1A18D90 VA: 0x181A1A790
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, ServerInfo>.MoveNext
	|
	|-RVA: 0x1A1E100 Offset: 0x1A1C700 VA: 0x181A1E100
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, int>.MoveNext
	|
	|-RVA: 0x1A1D770 Offset: 0x1A1BD70 VA: 0x181A1D770
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, object>.MoveNext
	|
	|-RVA: 0x1A1FFF0 Offset: 0x1A1E5F0 VA: 0x181A1FFF0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A25700 Offset: 0x1A23D00 VA: 0x181A25700
	|-Enumerable.WhereSelectEnumerableIterator<Friend, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A1A3C0 Offset: 0x1A189C0 VA: 0x181A1A3C0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A22A60 Offset: 0x1A21060 VA: 0x181A22A60
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Option>.MoveNext
	|
	|-RVA: 0x1A1F900 Offset: 0x1A1DF00 VA: 0x181A1F900
	|-Enumerable.WhereSelectEnumerableIterator<Friend, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A1B760 Offset: 0x1A19D60 VA: 0x181A1B760
	|-Enumerable.WhereSelectEnumerableIterator<Friend, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A1D310 Offset: 0x1A1B910 VA: 0x181A1D310
	|-Enumerable.WhereSelectEnumerableIterator<Friend, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A23740 Offset: 0x1A21D40 VA: 0x181A23740
	|-Enumerable.WhereSelectEnumerableIterator<Friend, bool>.MoveNext
	|
	|-RVA: 0x1A21820 Offset: 0x1A1FE20 VA: 0x181A21820
	|-Enumerable.WhereSelectEnumerableIterator<Friend, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A21EF0 Offset: 0x1A204F0 VA: 0x181A21EF0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, int>.MoveNext
	|
	|-RVA: 0x1A20D00 Offset: 0x1A1F300 VA: 0x181A20D00
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A1CAA0 Offset: 0x1A1B0A0 VA: 0x181A1CAA0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, long>.MoveNext
	|
	|-RVA: 0x1A1E9C0 Offset: 0x1A1CFC0 VA: 0x181A1E9C0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, object>.MoveNext
	|
	|-RVA: 0x1A235B0 Offset: 0x1A21BB0 VA: 0x181A235B0
	|-Enumerable.WhereSelectEnumerableIterator<Friend, float>.MoveNext
	|
	|-RVA: 0x1A22F10 Offset: 0x1A21510 VA: 0x181A22F10
	|-Enumerable.WhereSelectEnumerableIterator<Friend, Resolution>.MoveNext
	|
	|-RVA: 0x1A1DA40 Offset: 0x1A1C040 VA: 0x181A1DA40
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A1A550 Offset: 0x1A18B50 VA: 0x181A1A550
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, FourBitNumber>.MoveNext
	|
	|-RVA: 0x1A1D0D0 Offset: 0x1A1B6D0 VA: 0x181A1D0D0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, SevenBitNumber>.MoveNext
	|
	|-RVA: 0x1A240D0 Offset: 0x1A226D0 VA: 0x181A240D0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A1B900 Offset: 0x1A19F00 VA: 0x181A1B900
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A25B40 Offset: 0x1A24140 VA: 0x181A25B40
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Option>.MoveNext
	|
	|-RVA: 0x1A19BA0 Offset: 0x1A181A0 VA: 0x181A19BA0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryItemId>.MoveNext
	|
	|-RVA: 0x1A22070 Offset: 0x1A20670 VA: 0x181A22070
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A250F0 Offset: 0x1A236F0 VA: 0x181A250F0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A246D0 Offset: 0x1A22CD0 VA: 0x181A246D0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A26060 Offset: 0x1A24660 VA: 0x181A26060
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, bool>.MoveNext
	|
	|-RVA: 0x1A1E3C0 Offset: 0x1A1C9C0 VA: 0x181A1E3C0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A2C500 Offset: 0x1A2AB00 VA: 0x181A2C500
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, int>.MoveNext
	|
	|-RVA: 0x1A32150 Offset: 0x1A30750 VA: 0x181A32150
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A2B760 Offset: 0x1A29D60 VA: 0x181A2B760
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, long>.MoveNext
	|
	|-RVA: 0x1A2B510 Offset: 0x1A29B10 VA: 0x181A2B510
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, object>.MoveNext
	|
	|-RVA: 0x1A325B0 Offset: 0x1A30BB0 VA: 0x181A325B0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, float>.MoveNext
	|
	|-RVA: 0x1A2AB50 Offset: 0x1A29150 VA: 0x181A2AB50
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, uint>.MoveNext
	|
	|-RVA: 0x1A34B40 Offset: 0x1A33140 VA: 0x181A34B40
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem, Resolution>.MoveNext
	|
	|-RVA: 0x1A2E1E0 Offset: 0x1A2C7E0 VA: 0x181A2E1E0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem.Amount, InventoryItemId>.MoveNext
	|
	|-RVA: 0x1A334D0 Offset: 0x1A31AD0 VA: 0x181A334D0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryItem.Amount, uint>.MoveNext
	|
	|-RVA: 0x1A30970 Offset: 0x1A2EF70 VA: 0x181A30970
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe, PlayerItemRecipe>.MoveNext
	|
	|-RVA: 0x1A2A600 Offset: 0x1A28C00 VA: 0x181A2A600
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe, object>.MoveNext
	|
	|-RVA: 0x1A34FE0 Offset: 0x1A335E0 VA: 0x181A34FE0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A2DE10 Offset: 0x1A2C410 VA: 0x181A2DE10
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A35750 Offset: 0x1A33D50 VA: 0x181A35750
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A35980 Offset: 0x1A33F80 VA: 0x181A35980
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A30510 Offset: 0x1A2EB10 VA: 0x181A30510
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Option>.MoveNext
	|
	|-RVA: 0x1A33730 Offset: 0x1A31D30 VA: 0x181A33730
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A34D90 Offset: 0x1A33390 VA: 0x181A34D90
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A35E00 Offset: 0x1A34400 VA: 0x181A35E00
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A31940 Offset: 0x1A2FF40 VA: 0x181A31940
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, bool>.MoveNext
	|
	|-RVA: 0x1A32D50 Offset: 0x1A31350 VA: 0x181A32D50
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A32F90 Offset: 0x1A31590 VA: 0x181A32F90
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, int>.MoveNext
	|
	|-RVA: 0x1A34340 Offset: 0x1A32940 VA: 0x181A34340
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A31B70 Offset: 0x1A30170 VA: 0x181A31B70
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, long>.MoveNext
	|
	|-RVA: 0x1A33980 Offset: 0x1A31F80 VA: 0x181A33980
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, object>.MoveNext
	|
	|-RVA: 0x1A33ED0 Offset: 0x1A324D0 VA: 0x181A33ED0
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, float>.MoveNext
	|
	|-RVA: 0x1A2FC60 Offset: 0x1A2E260 VA: 0x181A2FC60
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe.Ingredient, Resolution>.MoveNext
	|
	|-RVA: 0x1A2C970 Offset: 0x1A2AF70 VA: 0x181A2C970
	|-Enumerable.WhereSelectEnumerableIterator<DictionaryEntry, KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0x1A35220 Offset: 0x1A33820 VA: 0x181A35220
	|-Enumerable.WhereSelectEnumerableIterator<DictionaryEntry, object>.MoveNext
	|
	|-RVA: 0x1A34910 Offset: 0x1A32F10 VA: 0x181A34910
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A2D8D0 Offset: 0x1A2BED0 VA: 0x181A2D8D0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A2E5C0 Offset: 0x1A2CBC0 VA: 0x181A2E5C0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A2C740 Offset: 0x1A2AD40 VA: 0x181A2C740
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Option>.MoveNext
	|
	|-RVA: 0x1A31DA0 Offset: 0x1A303A0 VA: 0x181A31DA0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A2A180 Offset: 0x1A28780 VA: 0x181A2A180
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A35BC0 Offset: 0x1A341C0 VA: 0x181A35BC0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A2EE40 Offset: 0x1A2D440 VA: 0x181A2EE40
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, bool>.MoveNext
	|
	|-RVA: 0x1A302E0 Offset: 0x1A2E8E0 VA: 0x181A302E0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A2BD30 Offset: 0x1A2A330 VA: 0x181A2BD30
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, int>.MoveNext
	|
	|-RVA: 0x1A31040 Offset: 0x1A2F640 VA: 0x181A31040
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A2B9A0 Offset: 0x1A29FA0 VA: 0x181A2B9A0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, long>.MoveNext
	|
	|-RVA: 0x1A31250 Offset: 0x1A2F850 VA: 0x181A31250
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.MoveNext
	|
	|-RVA: 0x1A32800 Offset: 0x1A30E00 VA: 0x181A32800
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, float>.MoveNext
	|
	|-RVA: 0x1A2B2F0 Offset: 0x1A298F0 VA: 0x181A2B2F0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, Resolution>.MoveNext
	|
	|-RVA: 0x1A2FEA0 Offset: 0x1A2E4A0 VA: 0x181A2FEA0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A2C2F0 Offset: 0x1A2A8F0 VA: 0x181A2C2F0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A34570 Offset: 0x1A32B70 VA: 0x181A34570
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A2F370 Offset: 0x1A2D970 VA: 0x181A2F370
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Option>.MoveNext
	|
	|-RVA: 0x1A2BF40 Offset: 0x1A2A540 VA: 0x181A2BF40
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A2A3C0 Offset: 0x1A289C0 VA: 0x181A2A3C0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A2AF30 Offset: 0x1A29530 VA: 0x181A2AF30
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A30760 Offset: 0x1A2ED60 VA: 0x181A30760
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, bool>.MoveNext
	|
	|-RVA: 0x1A2D510 Offset: 0x1A2BB10 VA: 0x181A2D510
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A2CD40 Offset: 0x1A2B340 VA: 0x181A2CD40
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, int>.MoveNext
	|
	|-RVA: 0x1A300D0 Offset: 0x1A2E6D0 VA: 0x181A300D0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A2D160 Offset: 0x1A2B760 VA: 0x181A2D160
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, long>.MoveNext
	|
	|-RVA: 0x1A34120 Offset: 0x1A32720 VA: 0x181A34120
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, object>.MoveNext
	|
	|-RVA: 0x1A2F740 Offset: 0x1A2DD40 VA: 0x181A2F740
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, float>.MoveNext
	|
	|-RVA: 0x1A2CF50 Offset: 0x1A2B550 VA: 0x181A2CF50
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, uint>.MoveNext
	|
	|-RVA: 0x1A32390 Offset: 0x1A30990 VA: 0x181A32390
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<uint, object>, Resolution>.MoveNext
	|
	|-RVA: 0x1A2A9D0 Offset: 0x1A28FD0 VA: 0x181A2A9D0
	|-Enumerable.WhereSelectEnumerableIterator<int, FourBitNumber>.MoveNext
	|
	|-RVA: 0x1A331C0 Offset: 0x1A317C0 VA: 0x181A331C0
	|-Enumerable.WhereSelectEnumerableIterator<int, SevenBitNumber>.MoveNext
	|
	|-RVA: 0x1A30EC0 Offset: 0x1A2F4C0 VA: 0x181A30EC0
	|-Enumerable.WhereSelectEnumerableIterator<int, int>.MoveNext
	|
	|-RVA: 0x1A2F1D0 Offset: 0x1A2D7D0 VA: 0x181A2F1D0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A2C170 Offset: 0x1A2A770 VA: 0x181A2C170
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A33340 Offset: 0x1A31940 VA: 0x181A33340
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A2EB00 Offset: 0x1A2D100 VA: 0x181A2EB00
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Option>.MoveNext
	|
	|-RVA: 0x1A32BB0 Offset: 0x1A311B0 VA: 0x181A32BB0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A2CBA0 Offset: 0x1A2B1A0 VA: 0x181A2CBA0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A2E960 Offset: 0x1A2CF60 VA: 0x181A2E960
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A33BC0 Offset: 0x1A321C0 VA: 0x181A33BC0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, bool>.MoveNext
	|
	|-RVA: 0x1A317A0 Offset: 0x1A2FDA0 VA: 0x181A317A0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A2F050 Offset: 0x1A2D650 VA: 0x181A2F050
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, int>.MoveNext
	|
	|-RVA: 0x1A2BBB0 Offset: 0x1A2A1B0 VA: 0x181A2BBB0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A2B170 Offset: 0x1A29770 VA: 0x181A2B170
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, long>.MoveNext
	|
	|-RVA: 0x1A2D740 Offset: 0x1A2BD40 VA: 0x181A2D740
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, object>.MoveNext
	|
	|-RVA: 0x1A355D0 Offset: 0x1A33BD0 VA: 0x181A355D0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, float>.MoveNext
	|
	|-RVA: 0x1A31470 Offset: 0x1A2FA70 VA: 0x181A31470
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, Resolution>.MoveNext
	|
	|-RVA: 0x1A29FE0 Offset: 0x1A285E0 VA: 0x181A29FE0
	|-Enumerable.WhereSelectEnumerableIterator<object, Debugging.EntityInfo>.MoveNext
	|
	|-RVA: 0x1A2E440 Offset: 0x1A2CA40 VA: 0x181A2E440
	|-Enumerable.WhereSelectEnumerableIterator<object, FourBitNumber>.MoveNext
	|
	|-RVA: 0x1A30BB0 Offset: 0x1A2F1B0 VA: 0x181A30BB0
	|-Enumerable.WhereSelectEnumerableIterator<object, SevenBitNumber>.MoveNext
	|
	|-RVA: 0x1A2DAE0 Offset: 0x1A2C0E0 VA: 0x181A2DAE0
	|-Enumerable.WhereSelectEnumerableIterator<object, PathFinder.Point>.MoveNext
	|
	|-RVA: 0x1A2FAD0 Offset: 0x1A2E0D0 VA: 0x181A2FAD0
	|-Enumerable.WhereSelectEnumerableIterator<object, PlayerItemRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A2DC70 Offset: 0x1A2C270 VA: 0x181A2DC70
	|-Enumerable.WhereSelectEnumerableIterator<object, PlayerItemRecipe>.MoveNext
	|
	|-RVA: 0x1A2AD90 Offset: 0x1A29390 VA: 0x181A2AD90
	|-Enumerable.WhereSelectEnumerableIterator<object, ProjectileWeaponMod.Modifier>.MoveNext
	|
	|-RVA: 0x1A31600 Offset: 0x1A2FC00 VA: 0x181A31600
	|-Enumerable.WhereSelectEnumerableIterator<object, Option>.MoveNext
	|
	|-RVA: 0x1A33D40 Offset: 0x1A32340 VA: 0x181A33D40
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryItemId>.MoveNext
	|
	|-RVA: 0x1A2F5A0 Offset: 0x1A2DBA0 VA: 0x181A2F5A0
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryItem>.MoveNext
	|
	|-RVA: 0x1A32A10 Offset: 0x1A31010 VA: 0x181A32A10
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1A2E040 Offset: 0x1A2C640 VA: 0x181A2E040
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1A2E7E0 Offset: 0x1A2CDE0 VA: 0x181A2E7E0
	|-Enumerable.WhereSelectEnumerableIterator<object, bool>.MoveNext
	|
	|-RVA: 0x1A2ECA0 Offset: 0x1A2D2A0 VA: 0x181A2ECA0
	|-Enumerable.WhereSelectEnumerableIterator<object, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1A31FD0 Offset: 0x1A305D0 VA: 0x181A31FD0
	|-Enumerable.WhereSelectEnumerableIterator<object, int>.MoveNext
	|
	|-RVA: 0x1A34790 Offset: 0x1A32D90 VA: 0x181A34790
	|-Enumerable.WhereSelectEnumerableIterator<object, Int32Enum>.MoveNext
	|
	|-RVA: 0x1A30D30 Offset: 0x1A2F330 VA: 0x181A30D30
	|-Enumerable.WhereSelectEnumerableIterator<object, long>.MoveNext
	|
	|-RVA: 0x1A2A840 Offset: 0x1A28E40 VA: 0x181A2A840
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.MoveNext
	|
	|-RVA: 0x1A35440 Offset: 0x1A33A40 VA: 0x181A35440
	|-Enumerable.WhereSelectEnumerableIterator<object, float>.MoveNext
	|
	|-RVA: 0x1A2F950 Offset: 0x1A2DF50 VA: 0x181A2F950
	|-Enumerable.WhereSelectEnumerableIterator<object, uint>.MoveNext
	|
	|-RVA: 0x1A2D370 Offset: 0x1A2B970 VA: 0x181A2D370
	|-Enumerable.WhereSelectEnumerableIterator<object, Resolution>.MoveNext
	*/

	public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC8CEA0 Offset: 0xC8B4A0 VA: 0x180C8CEA0
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
	|-RVA: 0xC8CFE0 Offset: 0xC8B5E0 VA: 0x180C8CFE0
	|-Enumerable.WhereSelectEnumerableIterator<Option, Option>.Select<Option>
	|-Enumerable.WhereSelectEnumerableIterator<object, Option>.Select<Option>
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryItem>.Select<InventoryItemId>
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryItem>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryItem>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryItem>.Select<uint>
	|
	|-RVA: 0xC8D120 Offset: 0xC8B720 VA: 0x180C8D120
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, ServerInfo>.Select<int>
	|-Enumerable.WhereSelectEnumerableIterator<ServerInfo, ServerInfo>.Select<object>
	|
	|-RVA: 0xC8D080 Offset: 0xC8B680 VA: 0x180C8D080
	|-Enumerable.WhereSelectEnumerableIterator<InventoryRecipe, PlayerItemRecipe>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<DictionaryEntry, KeyValuePair<object, object>>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<object, ProjectileWeaponMod.Modifier>.Select<float>
	|
	|-RVA: 0xC8CF40 Offset: 0xC8B540 VA: 0x180C8CF40
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryRecipe.Ingredient>.Select<PlayerItemRecipe.Ingredient>
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryRecipe.Ingredient>.Select<object>
	|-Enumerable.WhereSelectEnumerableIterator<object, InventoryRecipe>.Select<PlayerItemRecipe>
	*/

	public override IEnumerable<TResult> Where(Func<TResult, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C2900 Offset: 0x19C0F00 VA: 0x1819C2900
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
	|-RVA: 0x16A8DE0 Offset: 0x16A73E0 VA: 0x1816A8DE0
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
	|-RVA: 0x16A8E70 Offset: 0x16A7470 VA: 0x1816A8E70
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
	|-RVA: 0x16A8F90 Offset: 0x16A7590 VA: 0x1816A8F90
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
	|-RVA: 0x16A8F00 Offset: 0x16A7500 VA: 0x1816A8F00
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
	|-RVA: 0x16A9020 Offset: 0x16A7620 VA: 0x1816A9020
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, ServerInfo>..ctor
	*/

	public override Enumerable.Iterator<TResult> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A3CC0 Offset: 0x16A22C0 VA: 0x1816A3CC0
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
	|-RVA: 0x16A3B80 Offset: 0x16A2180 VA: 0x1816A3B80
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
	|-RVA: 0x16A3C20 Offset: 0x16A2220 VA: 0x1816A3C20
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
	|-RVA: 0x16A3D60 Offset: 0x16A2360 VA: 0x1816A3D60
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
	|-RVA: 0x16A3E00 Offset: 0x16A2400 VA: 0x1816A3E00
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, ServerInfo>.Clone
	*/

	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A42E0 Offset: 0x16A28E0 VA: 0x1816A42E0
	|-Enumerable.WhereSelectArrayIterator<BurstCloth.Chain, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<BurstCloth.Chain, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe.Ingredient, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe.Ingredient, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Achievement, bool>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, bool>.MoveNext
	|
	|-RVA: 0x16A4C70 Offset: 0x16A3270 VA: 0x1816A4C70
	|-Enumerable.WhereSelectArrayIterator<BurstCloth.Chain, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe.Ingredient, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Achievement, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Achievement, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, Int32Enum>.MoveNext
	|
	|-RVA: 0x16A43C0 Offset: 0x16A29C0 VA: 0x1816A43C0
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x16A7E50 Offset: 0x16A6450 VA: 0x1816A7E50
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, long>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem.Amount, InventoryItemId>.MoveNext
	|
	|-RVA: 0x16A8C10 Offset: 0x16A7210 VA: 0x1816A8C10
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, Resolution>.MoveNext
	|
	|-RVA: 0x16A7060 Offset: 0x16A5660 VA: 0x1816A7060
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, Option>.MoveNext
	|
	|-RVA: 0x16A5B20 Offset: 0x16A4120 VA: 0x1816A5B20
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, InventoryItem>.MoveNext
	|
	|-RVA: 0x16A72D0 Offset: 0x16A58D0 VA: 0x1816A72D0
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x16A58C0 Offset: 0x16A3EC0 VA: 0x1816A58C0
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x16A7B30 Offset: 0x16A6130 VA: 0x1816A7B30
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, bool>.MoveNext
	|
	|-RVA: 0x16A4510 Offset: 0x16A2B10 VA: 0x1816A4510
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem.Amount, uint>.MoveNext
	|
	|-RVA: 0x16A6A20 Offset: 0x16A5020 VA: 0x1816A6A20
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, object>.MoveNext
	|
	|-RVA: 0x16A89A0 Offset: 0x16A6FA0 VA: 0x1816A89A0
	|-Enumerable.WhereSelectArrayIterator<SkeletonDefinition.Bone, float>.MoveNext
	|
	|-RVA: 0x16A4F70 Offset: 0x16A3570 VA: 0x1816A4F70
	|-Enumerable.WhereSelectArrayIterator<WeightedStringList.Container, float>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, float>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, float>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, float>.MoveNext
	|
	|-RVA: 0x16A7680 Offset: 0x16A5C80 VA: 0x1816A7680
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, KeyValuePair<object, int>>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<DictionaryEntry, KeyValuePair<object, object>>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, KeyValuePair<object, int>>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x16A3EA0 Offset: 0x16A24A0 VA: 0x1816A3EA0
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, long>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, long>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, long>.MoveNext
	|
	|-RVA: 0x16A82A0 Offset: 0x16A68A0 VA: 0x1816A82A0
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, Resolution>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Resolution>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, Resolution>.MoveNext
	|
	|-RVA: 0x16A8880 Offset: 0x16A6E80 VA: 0x1816A8880
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, Option>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Option>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, Option>.MoveNext
	|
	|-RVA: 0x16A6710 Offset: 0x16A4D10 VA: 0x1816A6710
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, InventoryItem>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, InventoryItem>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, InventoryItem>.MoveNext
	|
	|-RVA: 0x16A8760 Offset: 0x16A6D60 VA: 0x1816A8760
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, InventoryRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, InventoryRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x16A6E40 Offset: 0x16A5440 VA: 0x1816A6E40
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, InventoryRecipe>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, InventoryRecipe>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x16A81A0 Offset: 0x16A67A0 VA: 0x1816A81A0
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, bool>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, bool>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, bool>.MoveNext
	|
	|-RVA: 0x16A61C0 Offset: 0x16A47C0 VA: 0x1816A61C0
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, uint>.MoveNext
	|
	|-RVA: 0x16A6D30 Offset: 0x16A5330 VA: 0x1816A6D30
	|-Enumerable.WhereSelectArrayIterator<PlayerItemRecipe, object>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<DictionaryEntry, object>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<uint, object>, object>.MoveNext
	|
	|-RVA: 0x16A7F90 Offset: 0x16A6590 VA: 0x1816A7F90
	|-Enumerable.WhereSelectArrayIterator<ProjectileWeaponMod.Modifier, float>.MoveNext
	|
	|-RVA: 0x16A8AD0 Offset: 0x16A70D0 VA: 0x1816A8AD0
	|-Enumerable.WhereSelectArrayIterator<Option, Option>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, Option>.MoveNext
	|
	|-RVA: 0x16A5250 Offset: 0x16A3850 VA: 0x1816A5250
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x16A4750 Offset: 0x16A2D50 VA: 0x1816A4750
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, bool>.MoveNext
	|
	|-RVA: 0x16A62C0 Offset: 0x16A48C0 VA: 0x1816A62C0
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, long>.MoveNext
	|
	|-RVA: 0x16A64E0 Offset: 0x16A4AE0 VA: 0x1816A64E0
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, Resolution>.MoveNext
	|
	|-RVA: 0x16A7440 Offset: 0x16A5A40 VA: 0x1816A7440
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, Option>.MoveNext
	|
	|-RVA: 0x16A5F80 Offset: 0x16A4580 VA: 0x1816A5F80
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, InventoryItem>.MoveNext
	|
	|-RVA: 0x16A3FA0 Offset: 0x16A25A0 VA: 0x1816A3FA0
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x16A5590 Offset: 0x16A3B90 VA: 0x1816A5590
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x16A4A60 Offset: 0x16A3060 VA: 0x1816A4A60
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, int>.MoveNext
	|
	|-RVA: 0x16A4D50 Offset: 0x16A3350 VA: 0x1816A4D50
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, object>.MoveNext
	|
	|-RVA: 0x16A5070 Offset: 0x16A3670 VA: 0x1816A5070
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, float>.MoveNext
	|
	|-RVA: 0x16A5D70 Offset: 0x16A4370 VA: 0x1816A5D70
	|-Enumerable.WhereSelectArrayIterator<SkinnedMultiMesh.Part, long>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, InventoryItemId>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, long>.MoveNext
	|
	|-RVA: 0x16A57D0 Offset: 0x16A3DD0 VA: 0x1816A57D0
	|-Enumerable.WhereSelectArrayIterator<Achievement, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Achievement, KeyValuePair<object, int>>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x16A6C50 Offset: 0x16A5250 VA: 0x1816A6C50
	|-Enumerable.WhereSelectArrayIterator<Achievement, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Achievement, long>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, long>.MoveNext
	|
	|-RVA: 0x16A7D60 Offset: 0x16A6360 VA: 0x1816A7D60
	|-Enumerable.WhereSelectArrayIterator<Achievement, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Achievement, Resolution>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, Resolution>.MoveNext
	|
	|-RVA: 0x16A7790 Offset: 0x16A5D90 VA: 0x1816A7790
	|-Enumerable.WhereSelectArrayIterator<Achievement, Option>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, Option>.MoveNext
	|
	|-RVA: 0x16A6830 Offset: 0x16A4E30 VA: 0x1816A6830
	|-Enumerable.WhereSelectArrayIterator<Achievement, InventoryItem>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, InventoryItem>.MoveNext
	|
	|-RVA: 0x16A71D0 Offset: 0x16A57D0 VA: 0x1816A71D0
	|-Enumerable.WhereSelectArrayIterator<Achievement, InventoryRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x16A4960 Offset: 0x16A2F60 VA: 0x1816A4960
	|-Enumerable.WhereSelectArrayIterator<Achievement, InventoryRecipe>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x16A7C70 Offset: 0x16A6270 VA: 0x1816A7C70
	|-Enumerable.WhereSelectArrayIterator<Achievement, object>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, object>.MoveNext
	|
	|-RVA: 0x16A6B70 Offset: 0x16A5170 VA: 0x1816A6B70
	|-Enumerable.WhereSelectArrayIterator<Achievement, float>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Friend, float>.MoveNext
	|
	|-RVA: 0x16A5E90 Offset: 0x16A4490 VA: 0x1816A5E90
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x16A7A50 Offset: 0x16A6050 VA: 0x1816A7A50
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, long>.MoveNext
	|
	|-RVA: 0x16A6930 Offset: 0x16A4F30 VA: 0x1816A6930
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, Resolution>.MoveNext
	|
	|-RVA: 0x16A6F60 Offset: 0x16A5560 VA: 0x1816A6F60
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, Option>.MoveNext
	|
	|-RVA: 0x16A41E0 Offset: 0x16A27E0 VA: 0x1816A41E0
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, InventoryItem>.MoveNext
	|
	|-RVA: 0x16A80A0 Offset: 0x16A66A0 VA: 0x1816A80A0
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x16A4650 Offset: 0x16A2C50 VA: 0x1816A4650
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x16A5C90 Offset: 0x16A4290 VA: 0x1816A5C90
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, bool>.MoveNext
	|
	|-RVA: 0x16A7970 Offset: 0x16A5F70 VA: 0x1816A7970
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, Int32Enum>.MoveNext
	|
	|-RVA: 0x16A5A30 Offset: 0x16A4030 VA: 0x1816A5A30
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, object>.MoveNext
	|
	|-RVA: 0x16A7890 Offset: 0x16A5E90 VA: 0x1816A7890
	|-Enumerable.WhereSelectArrayIterator<InventoryDefId, float>.MoveNext
	|
	|-RVA: 0x16A84E0 Offset: 0x16A6AE0 VA: 0x1816A84E0
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, ServerInfo>.MoveNext
	|
	|-RVA: 0x16A83B0 Offset: 0x16A69B0 VA: 0x1816A83B0
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x16A5480 Offset: 0x16A3A80 VA: 0x1816A5480
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, bool>.MoveNext
	|
	|-RVA: 0x19BD560 Offset: 0x19BBB60 VA: 0x1819BD560
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, Resolution>.MoveNext
	|
	|-RVA: 0x19BE510 Offset: 0x19BCB10 VA: 0x1819BE510
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, InventoryItem>.MoveNext
	|
	|-RVA: 0x19BF670 Offset: 0x19BDC70 VA: 0x1819BF670
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x19BE030 Offset: 0x19BC630 VA: 0x1819BE030
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x19BF560 Offset: 0x19BDB60 VA: 0x1819BF560
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, uint>.MoveNext
	|
	|-RVA: 0x19BFAC0 Offset: 0x19BE0C0 VA: 0x1819BFAC0
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, object>.MoveNext
	|
	|-RVA: 0x19BF8B0 Offset: 0x19BDEB0 VA: 0x1819BF8B0
	|-Enumerable.WhereSelectArrayIterator<InventoryItem, float>.MoveNext
	|
	|-RVA: 0x19BDF00 Offset: 0x19BC500 VA: 0x1819BDF00
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe, PlayerItemRecipe>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x19BD340 Offset: 0x19BB940 VA: 0x1819BD340
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe, object>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, object>.MoveNext
	|
	|-RVA: 0x19BD9D0 Offset: 0x19BBFD0 VA: 0x1819BD9D0
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, long>.MoveNext
	|
	|-RVA: 0x19BD690 Offset: 0x19BBC90 VA: 0x1819BD690
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, Resolution>.MoveNext
	|
	|-RVA: 0x19BEF80 Offset: 0x19BD580 VA: 0x1819BEF80
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, Option>.MoveNext
	|
	|-RVA: 0x19BDAF0 Offset: 0x19BC0F0 VA: 0x1819BDAF0
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, InventoryItem>.MoveNext
	|
	|-RVA: 0x19BEB80 Offset: 0x19BD180 VA: 0x1819BEB80
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x19BE650 Offset: 0x19BCC50 VA: 0x1819BE650
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x19BD8B0 Offset: 0x19BBEB0 VA: 0x1819BD8B0
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, bool>.MoveNext
	|
	|-RVA: 0x19BDC20 Offset: 0x19BC220 VA: 0x1819BDC20
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, Int32Enum>.MoveNext
	|
	|-RVA: 0x19BE880 Offset: 0x19BCE80 VA: 0x1819BE880
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe.Ingredient, float>.MoveNext
	|
	|-RVA: 0x19BECB0 Offset: 0x19BD2B0 VA: 0x1819BECB0
	|-Enumerable.WhereSelectArrayIterator<int, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<int, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, bool>.MoveNext
	|
	|-RVA: 0x19BD260 Offset: 0x19BB860 VA: 0x1819BD260
	|-Enumerable.WhereSelectArrayIterator<int, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Int32Enum>.MoveNext
	|
	|-RVA: 0x19BE250 Offset: 0x19BC850 VA: 0x1819BE250
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x19BE430 Offset: 0x19BCA30 VA: 0x1819BE430
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, long>.MoveNext
	|
	|-RVA: 0x19BE990 Offset: 0x19BCF90 VA: 0x1819BE990
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Resolution>.MoveNext
	|
	|-RVA: 0x19BF9C0 Offset: 0x19BDFC0 VA: 0x1819BF9C0
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, Option>.MoveNext
	|
	|-RVA: 0x19BF7B0 Offset: 0x19BDDB0 VA: 0x1819BF7B0
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, InventoryItem>.MoveNext
	|
	|-RVA: 0x19BEA80 Offset: 0x19BD080 VA: 0x1819BEA80
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x19BE780 Offset: 0x19BCD80 VA: 0x1819BE780
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x19BE340 Offset: 0x19BC940 VA: 0x1819BE340
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, object>.MoveNext
	|
	|-RVA: 0x19BDD40 Offset: 0x19BC340 VA: 0x1819BDD40
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, float>.MoveNext
	|
	|-RVA: 0x19BD7C0 Offset: 0x19BBDC0 VA: 0x1819BD7C0
	|-Enumerable.WhereSelectArrayIterator<object, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, PlayerItemRecipe>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x19BE170 Offset: 0x19BC770 VA: 0x1819BE170
	|-Enumerable.WhereSelectArrayIterator<object, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, bool>.MoveNext
	|
	|-RVA: 0x19BDE20 Offset: 0x19BC420 VA: 0x1819BDE20
	|-Enumerable.WhereSelectArrayIterator<object, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, PlayerItemRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, InventoryItemId>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, long>.MoveNext
	|
	|-RVA: 0x19BF0B0 Offset: 0x19BD6B0 VA: 0x1819BF0B0
	|-Enumerable.WhereSelectArrayIterator<object, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, Resolution>.MoveNext
	|
	|-RVA: 0x19BF280 Offset: 0x19BD880 VA: 0x1819BF280
	|-Enumerable.WhereSelectArrayIterator<object, Option>.MoveNext
	|
	|-RVA: 0x19BF460 Offset: 0x19BDA60 VA: 0x1819BF460
	|-Enumerable.WhereSelectArrayIterator<object, InventoryItem>.MoveNext
	|
	|-RVA: 0x19BED90 Offset: 0x19BD390 VA: 0x1819BED90
	|-Enumerable.WhereSelectArrayIterator<object, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x19BD460 Offset: 0x19BBA60 VA: 0x1819BD460
	|-Enumerable.WhereSelectArrayIterator<object, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x19BF380 Offset: 0x19BD980 VA: 0x1819BF380
	|-Enumerable.WhereSelectArrayIterator<object, int>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectArrayIterator<object, uint>.MoveNext
	|
	|-RVA: 0x19BEE90 Offset: 0x19BD490 VA: 0x1819BEE90
	|-Enumerable.WhereSelectArrayIterator<object, object>.MoveNext
	|
	|-RVA: 0x19BF1A0 Offset: 0x19BD7A0 VA: 0x1819BF1A0
	|-Enumerable.WhereSelectArrayIterator<object, float>.MoveNext
	*/

	public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC8CEA0 Offset: 0xC8B4A0 VA: 0x180C8CEA0
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
	|-RVA: 0xC8CFE0 Offset: 0xC8B5E0 VA: 0x180C8CFE0
	|-Enumerable.WhereSelectArrayIterator<Option, Option>.Select<Option>
	|-Enumerable.WhereSelectArrayIterator<object, Option>.Select<Option>
	|-Enumerable.WhereSelectArrayIterator<object, InventoryItem>.Select<InventoryItemId>
	|-Enumerable.WhereSelectArrayIterator<object, InventoryItem>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<object, InventoryItem>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<object, InventoryItem>.Select<uint>
	|
	|-RVA: 0xC8D120 Offset: 0xC8B720 VA: 0x180C8D120
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, ServerInfo>.Select<int>
	|-Enumerable.WhereSelectArrayIterator<ServerInfo, ServerInfo>.Select<object>
	|
	|-RVA: 0xC8D080 Offset: 0xC8B680 VA: 0x180C8D080
	|-Enumerable.WhereSelectArrayIterator<InventoryRecipe, PlayerItemRecipe>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<DictionaryEntry, KeyValuePair<object, object>>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<object, ProjectileWeaponMod.Modifier>.Select<float>
	|
	|-RVA: 0xC8CF40 Offset: 0xC8B540 VA: 0x180C8CF40
	|-Enumerable.WhereSelectArrayIterator<object, InventoryRecipe.Ingredient>.Select<PlayerItemRecipe.Ingredient>
	|-Enumerable.WhereSelectArrayIterator<object, InventoryRecipe.Ingredient>.Select<object>
	|-Enumerable.WhereSelectArrayIterator<object, InventoryRecipe>.Select<PlayerItemRecipe>
	*/

	public override IEnumerable<TResult> Where(Func<TResult, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A8D60 Offset: 0x16A7360 VA: 0x1816A8D60
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
	|-RVA: 0x16A8DE0 Offset: 0x16A73E0 VA: 0x1816A8DE0
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
	|-RVA: 0x16A8E70 Offset: 0x16A7470 VA: 0x1816A8E70
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
	|-RVA: 0x16A8F90 Offset: 0x16A7590 VA: 0x1816A8F90
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
	|-RVA: 0x16A8F00 Offset: 0x16A7500 VA: 0x1816A8F00
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
	|-RVA: 0x16A9020 Offset: 0x16A7620 VA: 0x1816A9020
	|-Enumerable.WhereSelectListIterator<ServerInfo, ServerInfo>..ctor
	*/

	public override Enumerable.Iterator<TResult> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A3CC0 Offset: 0x16A22C0 VA: 0x1816A3CC0
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
	|-RVA: 0x16A3B80 Offset: 0x16A2180 VA: 0x1816A3B80
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
	|-RVA: 0x16A3C20 Offset: 0x16A2220 VA: 0x1816A3C20
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
	|-RVA: 0x16A3D60 Offset: 0x16A2360 VA: 0x1816A3D60
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
	|-RVA: 0x16A3E00 Offset: 0x16A2400 VA: 0x1816A3E00
	|-Enumerable.WhereSelectListIterator<ServerInfo, ServerInfo>.Clone
	*/

	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176DC50 Offset: 0x176C250 VA: 0x18176DC50
	|-Enumerable.WhereSelectListIterator<BurstCloth.Chain, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<BurstCloth.Chain, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<Achievement, bool>.MoveNext
	|
	|-RVA: 0x1770250 Offset: 0x176E850 VA: 0x181770250
	|-Enumerable.WhereSelectListIterator<BurstCloth.Chain, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<Achievement, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<Achievement, Int32Enum>.MoveNext
	|
	|-RVA: 0x176C100 Offset: 0x176A700 VA: 0x18176C100
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x176E910 Offset: 0x176CF10 VA: 0x18176E910
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, long>.MoveNext
	|
	|-RVA: 0x176C3C0 Offset: 0x176A9C0 VA: 0x18176C3C0
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, Resolution>.MoveNext
	|
	|-RVA: 0x1772D00 Offset: 0x1771300 VA: 0x181772D00
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, Option>.MoveNext
	|
	|-RVA: 0x176D2B0 Offset: 0x176B8B0 VA: 0x18176D2B0
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, InventoryItem>.MoveNext
	|
	|-RVA: 0x1773140 Offset: 0x1771740 VA: 0x181773140
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x17710A0 Offset: 0x176F6A0 VA: 0x1817710A0
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x17708F0 Offset: 0x176EEF0 VA: 0x1817708F0
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, bool>.MoveNext
	|
	|-RVA: 0x1771990 Offset: 0x176FF90 VA: 0x181771990
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, Int32Enum>.MoveNext
	|
	|-RVA: 0x1773830 Offset: 0x1771E30 VA: 0x181773830
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, object>.MoveNext
	|
	|-RVA: 0x176EE90 Offset: 0x176D490 VA: 0x18176EE90
	|-Enumerable.WhereSelectListIterator<SkeletonDefinition.Bone, float>.MoveNext
	|
	|-RVA: 0x176ED60 Offset: 0x176D360 VA: 0x18176ED60
	|-Enumerable.WhereSelectListIterator<WeightedStringList.Container, float>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, float>.MoveNext
	|
	|-RVA: 0x176E2C0 Offset: 0x176C8C0 VA: 0x18176E2C0
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, KeyValuePair<object, int>>.MoveNext
	|-Enumerable.WhereSelectListIterator<DictionaryEntry, KeyValuePair<object, object>>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x176CCE0 Offset: 0x176B2E0 VA: 0x18176CCE0
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, long>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, long>.MoveNext
	|
	|-RVA: 0x176DD70 Offset: 0x176C370 VA: 0x18176DD70
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, Resolution>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Resolution>.MoveNext
	|
	|-RVA: 0x17723E0 Offset: 0x17709E0 VA: 0x1817723E0
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, Option>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Option>.MoveNext
	|
	|-RVA: 0x176D850 Offset: 0x176BE50 VA: 0x18176D850
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, InventoryItem>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, InventoryItem>.MoveNext
	|
	|-RVA: 0x176E170 Offset: 0x176C770 VA: 0x18176E170
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, InventoryRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1770E10 Offset: 0x176F410 VA: 0x181770E10
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, InventoryRecipe>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x176FED0 Offset: 0x176E4D0 VA: 0x18176FED0
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, bool>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, bool>.MoveNext
	|
	|-RVA: 0x176D180 Offset: 0x176B780 VA: 0x18176D180
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, Int32Enum>.MoveNext
	|
	|-RVA: 0x1771C60 Offset: 0x1770260 VA: 0x181771C60
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, object>.MoveNext
	|-Enumerable.WhereSelectListIterator<DictionaryEntry, object>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.MoveNext
	|
	|-RVA: 0x176FDA0 Offset: 0x176E3A0 VA: 0x18176FDA0
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe, float>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, float>.MoveNext
	|
	|-RVA: 0x176FB10 Offset: 0x176E110 VA: 0x18176FB10
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe.Ingredient, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe.Ingredient, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<Friend, bool>.MoveNext
	|
	|-RVA: 0x1770130 Offset: 0x176E730 VA: 0x181770130
	|-Enumerable.WhereSelectListIterator<PlayerItemRecipe.Ingredient, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<Friend, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<Friend, Int32Enum>.MoveNext
	|
	|-RVA: 0x1770F60 Offset: 0x176F560 VA: 0x181770F60
	|-Enumerable.WhereSelectListIterator<ProjectileWeaponMod.Modifier, float>.MoveNext
	|
	|-RVA: 0x17736C0 Offset: 0x1771CC0 VA: 0x1817736C0
	|-Enumerable.WhereSelectListIterator<Option, Option>.MoveNext
	|
	|-RVA: 0x176D9A0 Offset: 0x176BFA0 VA: 0x18176D9A0
	|-Enumerable.WhereSelectListIterator<ServerInfo, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<ServerInfo, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x176BE60 Offset: 0x176A460 VA: 0x18176BE60
	|-Enumerable.WhereSelectListIterator<ServerInfo, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<ServerInfo, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<ServerInfo, bool>.MoveNext
	|
	|-RVA: 0x176F870 Offset: 0x176DE70 VA: 0x18176F870
	|-Enumerable.WhereSelectListIterator<ServerInfo, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<ServerInfo, long>.MoveNext
	|
	|-RVA: 0x176E520 Offset: 0x176CB20 VA: 0x18176E520
	|-Enumerable.WhereSelectListIterator<ServerInfo, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<ServerInfo, Resolution>.MoveNext
	|
	|-RVA: 0x176DEB0 Offset: 0x176C4B0 VA: 0x18176DEB0
	|-Enumerable.WhereSelectListIterator<ServerInfo, Option>.MoveNext
	|
	|-RVA: 0x1772A40 Offset: 0x1771040 VA: 0x181772A40
	|-Enumerable.WhereSelectListIterator<ServerInfo, InventoryItem>.MoveNext
	|
	|-RVA: 0x176F010 Offset: 0x176D610 VA: 0x18176F010
	|-Enumerable.WhereSelectListIterator<ServerInfo, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x176EAA0 Offset: 0x176D0A0 VA: 0x18176EAA0
	|-Enumerable.WhereSelectListIterator<ServerInfo, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x176F2D0 Offset: 0x176D8D0 VA: 0x18176F2D0
	|-Enumerable.WhereSelectListIterator<ServerInfo, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<ServerInfo, Int32Enum>.MoveNext
	|
	|-RVA: 0x1772EA0 Offset: 0x17714A0 VA: 0x181772EA0
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>.MoveNext
	|
	|-RVA: 0x1770A80 Offset: 0x176F080 VA: 0x181770A80
	|-Enumerable.WhereSelectListIterator<ServerInfo, float>.MoveNext
	|
	|-RVA: 0x1770620 Offset: 0x176EC20 VA: 0x181770620
	|-Enumerable.WhereSelectListIterator<SkinnedMultiMesh.Part, long>.MoveNext
	|
	|-RVA: 0x176D050 Offset: 0x176B650 VA: 0x18176D050
	|-Enumerable.WhereSelectListIterator<Achievement, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<Achievement, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x176CF30 Offset: 0x176B530 VA: 0x18176CF30
	|-Enumerable.WhereSelectListIterator<Achievement, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<Achievement, long>.MoveNext
	|
	|-RVA: 0x176C7E0 Offset: 0x176ADE0 VA: 0x18176C7E0
	|-Enumerable.WhereSelectListIterator<Achievement, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<Achievement, Resolution>.MoveNext
	|
	|-RVA: 0x1772900 Offset: 0x1770F00 VA: 0x181772900
	|-Enumerable.WhereSelectListIterator<Achievement, Option>.MoveNext
	|
	|-RVA: 0x1772160 Offset: 0x1770760 VA: 0x181772160
	|-Enumerable.WhereSelectListIterator<Achievement, InventoryItem>.MoveNext
	|
	|-RVA: 0x1770370 Offset: 0x176E970 VA: 0x181770370
	|-Enumerable.WhereSelectListIterator<Achievement, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1771850 Offset: 0x176FE50 VA: 0x181771850
	|-Enumerable.WhereSelectListIterator<Achievement, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x176D720 Offset: 0x176BD20 VA: 0x18176D720
	|-Enumerable.WhereSelectListIterator<Achievement, object>.MoveNext
	|
	|-RVA: 0x1772530 Offset: 0x1770B30 VA: 0x181772530
	|-Enumerable.WhereSelectListIterator<Achievement, float>.MoveNext
	|
	|-RVA: 0x1771240 Offset: 0x176F840 VA: 0x181771240
	|-Enumerable.WhereSelectListIterator<InventoryDefId, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryDefId, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x176C560 Offset: 0x176AB60 VA: 0x18176C560
	|-Enumerable.WhereSelectListIterator<InventoryDefId, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryDefId, long>.MoveNext
	|
	|-RVA: 0x1771490 Offset: 0x176FA90 VA: 0x181771490
	|-Enumerable.WhereSelectListIterator<InventoryDefId, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryDefId, Resolution>.MoveNext
	|
	|-RVA: 0x1771B20 Offset: 0x1770120 VA: 0x181771B20
	|-Enumerable.WhereSelectListIterator<InventoryDefId, Option>.MoveNext
	|
	|-RVA: 0x176E7D0 Offset: 0x176CDD0 VA: 0x18176E7D0
	|-Enumerable.WhereSelectListIterator<InventoryDefId, InventoryItem>.MoveNext
	|
	|-RVA: 0x17722A0 Offset: 0x17708A0 VA: 0x1817722A0
	|-Enumerable.WhereSelectListIterator<InventoryDefId, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x17727C0 Offset: 0x1770DC0 VA: 0x1817727C0
	|-Enumerable.WhereSelectListIterator<InventoryDefId, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x176E400 Offset: 0x176CA00 VA: 0x18176E400
	|-Enumerable.WhereSelectListIterator<InventoryDefId, bool>.MoveNext
	|
	|-RVA: 0x176C2A0 Offset: 0x176A8A0 VA: 0x18176C2A0
	|-Enumerable.WhereSelectListIterator<InventoryDefId, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryDefId, Int32Enum>.MoveNext
	|
	|-RVA: 0x1770000 Offset: 0x176E600 VA: 0x181770000
	|-Enumerable.WhereSelectListIterator<InventoryDefId, object>.MoveNext
	|
	|-RVA: 0x17715C0 Offset: 0x176FBC0 VA: 0x1817715C0
	|-Enumerable.WhereSelectListIterator<InventoryDefId, float>.MoveNext
	|
	|-RVA: 0x176F570 Offset: 0x176DB70 VA: 0x18176F570
	|-Enumerable.WhereSelectListIterator<ServerInfo, ServerInfo>.MoveNext
	|
	|-RVA: 0x1773420 Offset: 0x1771A20 VA: 0x181773420
	|-Enumerable.WhereSelectListIterator<ServerInfo, int>.MoveNext
	|
	|-RVA: 0x176CA40 Offset: 0x176B040 VA: 0x18176CA40
	|-Enumerable.WhereSelectListIterator<ServerInfo, object>.MoveNext
	|
	|-RVA: 0x176C910 Offset: 0x176AF10 VA: 0x18176C910
	|-Enumerable.WhereSelectListIterator<Friend, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<Friend, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x176CE10 Offset: 0x176B410 VA: 0x18176CE10
	|-Enumerable.WhereSelectListIterator<Friend, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<Friend, long>.MoveNext
	|
	|-RVA: 0x176BD30 Offset: 0x176A330 VA: 0x18176BD30
	|-Enumerable.WhereSelectListIterator<Friend, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<Friend, Resolution>.MoveNext
	|
	|-RVA: 0x1771EE0 Offset: 0x17704E0 VA: 0x181771EE0
	|-Enumerable.WhereSelectListIterator<Friend, Option>.MoveNext
	|
	|-RVA: 0x1771DA0 Offset: 0x17703A0 VA: 0x181771DA0
	|-Enumerable.WhereSelectListIterator<Friend, InventoryItem>.MoveNext
	|
	|-RVA: 0x1772020 Offset: 0x1770620 VA: 0x181772020
	|-Enumerable.WhereSelectListIterator<Friend, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x17732E0 Offset: 0x17718E0 VA: 0x1817732E0
	|-Enumerable.WhereSelectListIterator<Friend, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1770CE0 Offset: 0x176F2E0 VA: 0x181770CE0
	|-Enumerable.WhereSelectListIterator<Friend, object>.MoveNext
	|
	|-RVA: 0x1771370 Offset: 0x176F970 VA: 0x181771370
	|-Enumerable.WhereSelectListIterator<Friend, float>.MoveNext
	|
	|-RVA: 0x176D450 Offset: 0x176BA50 VA: 0x18176D450
	|-Enumerable.WhereSelectListIterator<InventoryItem, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryItem, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x176C680 Offset: 0x176AC80 VA: 0x18176C680
	|-Enumerable.WhereSelectListIterator<InventoryItem, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryItem, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryItem, bool>.MoveNext
	|
	|-RVA: 0x176D5C0 Offset: 0x176BBC0 VA: 0x18176D5C0
	|-Enumerable.WhereSelectListIterator<InventoryItem, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryItem, InventoryItemId>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryItem, long>.MoveNext
	|
	|-RVA: 0x176FC30 Offset: 0x176E230 VA: 0x18176FC30
	|-Enumerable.WhereSelectListIterator<InventoryItem, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryItem, Resolution>.MoveNext
	|
	|-RVA: 0x1770780 Offset: 0x176ED80 VA: 0x181770780
	|-Enumerable.WhereSelectListIterator<InventoryItem, Option>.MoveNext
	|
	|-RVA: 0x1772650 Offset: 0x1770C50 VA: 0x181772650
	|-Enumerable.WhereSelectListIterator<InventoryItem, InventoryItem>.MoveNext
	|
	|-RVA: 0x17716E0 Offset: 0x176FCE0 VA: 0x1817716E0
	|-Enumerable.WhereSelectListIterator<InventoryItem, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x17704B0 Offset: 0x176EAB0 VA: 0x1817704B0
	|-Enumerable.WhereSelectListIterator<InventoryItem, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1792970 Offset: 0x1790F70 VA: 0x181792970
	|-Enumerable.WhereSelectListIterator<InventoryItem, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryItem, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryItem, uint>.MoveNext
	|
	|-RVA: 0x1791320 Offset: 0x178F920 VA: 0x181791320
	|-Enumerable.WhereSelectListIterator<InventoryItem, object>.MoveNext
	|
	|-RVA: 0x1793740 Offset: 0x1791D40 VA: 0x181793740
	|-Enumerable.WhereSelectListIterator<InventoryItem, float>.MoveNext
	|
	|-RVA: 0x1792C00 Offset: 0x1791200 VA: 0x181792C00
	|-Enumerable.WhereSelectListIterator<InventoryItem.Amount, InventoryItemId>.MoveNext
	|
	|-RVA: 0x1792ED0 Offset: 0x17914D0 VA: 0x181792ED0
	|-Enumerable.WhereSelectListIterator<InventoryItem.Amount, uint>.MoveNext
	|
	|-RVA: 0x1791490 Offset: 0x178FA90 VA: 0x181791490
	|-Enumerable.WhereSelectListIterator<InventoryRecipe, PlayerItemRecipe>.MoveNext
	|
	|-RVA: 0x1793360 Offset: 0x1791960 VA: 0x181793360
	|-Enumerable.WhereSelectListIterator<InventoryRecipe, object>.MoveNext
	|
	|-RVA: 0x1790DF0 Offset: 0x178F3F0 VA: 0x181790DF0
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x17911B0 Offset: 0x178F7B0 VA: 0x1817911B0
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, long>.MoveNext
	|
	|-RVA: 0x1791A20 Offset: 0x1790020 VA: 0x181791A20
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, Resolution>.MoveNext
	|
	|-RVA: 0x1791890 Offset: 0x178FE90 VA: 0x181791890
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, Option>.MoveNext
	|
	|-RVA: 0x17922E0 Offset: 0x17908E0 VA: 0x1817922E0
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, InventoryItem>.MoveNext
	|
	|-RVA: 0x17931D0 Offset: 0x17917D0 VA: 0x1817931D0
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1793C30 Offset: 0x1792230 VA: 0x181793C30
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1792470 Offset: 0x1790A70 VA: 0x181792470
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, bool>.MoveNext
	|
	|-RVA: 0x1790550 Offset: 0x178EB50 VA: 0x181790550
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, Int32Enum>.MoveNext
	|
	|-RVA: 0x1793060 Offset: 0x1791660 VA: 0x181793060
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, object>.MoveNext
	|
	|-RVA: 0x1793F00 Offset: 0x1792500 VA: 0x181793F00
	|-Enumerable.WhereSelectListIterator<InventoryRecipe.Ingredient, float>.MoveNext
	|
	|-RVA: 0x1793AF0 Offset: 0x17920F0 VA: 0x181793AF0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1792AD0 Offset: 0x17910D0 VA: 0x181792AD0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, long>.MoveNext
	|
	|-RVA: 0x1790410 Offset: 0x178EA10 VA: 0x181790410
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, Resolution>.MoveNext
	|
	|-RVA: 0x17906C0 Offset: 0x178ECC0 VA: 0x1817906C0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, Option>.MoveNext
	|
	|-RVA: 0x1791CD0 Offset: 0x17902D0 VA: 0x181791CD0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, InventoryItem>.MoveNext
	|
	|-RVA: 0x1791610 Offset: 0x178FC10 VA: 0x181791610
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1790A60 Offset: 0x178F060 VA: 0x181790A60
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x17942E0 Offset: 0x17928E0 VA: 0x1817942E0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, bool>.MoveNext
	|
	|-RVA: 0x17921B0 Offset: 0x17907B0 VA: 0x1817921B0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, uint>.MoveNext
	|
	|-RVA: 0x1793600 Offset: 0x1791C00 VA: 0x181793600
	|-Enumerable.WhereSelectListIterator<KeyValuePair<uint, object>, object>.MoveNext
	|
	|-RVA: 0x1790BB0 Offset: 0x178F1B0 VA: 0x181790BB0
	|-Enumerable.WhereSelectListIterator<int, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<int, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<Int32Enum, bool>.MoveNext
	|
	|-RVA: 0x1792720 Offset: 0x1790D20 VA: 0x181792720
	|-Enumerable.WhereSelectListIterator<int, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<Int32Enum, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<Int32Enum, Int32Enum>.MoveNext
	|
	|-RVA: 0x1790930 Offset: 0x178EF30 VA: 0x181790930
	|-Enumerable.WhereSelectListIterator<Int32Enum, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<Int32Enum, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1791090 Offset: 0x178F690 VA: 0x181791090
	|-Enumerable.WhereSelectListIterator<Int32Enum, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<Int32Enum, long>.MoveNext
	|
	|-RVA: 0x1791760 Offset: 0x178FD60 VA: 0x181791760
	|-Enumerable.WhereSelectListIterator<Int32Enum, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<Int32Enum, Resolution>.MoveNext
	|
	|-RVA: 0x17925E0 Offset: 0x1790BE0 VA: 0x1817925E0
	|-Enumerable.WhereSelectListIterator<Int32Enum, Option>.MoveNext
	|
	|-RVA: 0x1792D90 Offset: 0x1791390 VA: 0x181792D90
	|-Enumerable.WhereSelectListIterator<Int32Enum, InventoryItem>.MoveNext
	|
	|-RVA: 0x17941A0 Offset: 0x17927A0 VA: 0x1817941A0
	|-Enumerable.WhereSelectListIterator<Int32Enum, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1793890 Offset: 0x1791E90 VA: 0x181793890
	|-Enumerable.WhereSelectListIterator<Int32Enum, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x17934D0 Offset: 0x1791AD0 VA: 0x1817934D0
	|-Enumerable.WhereSelectListIterator<Int32Enum, object>.MoveNext
	|
	|-RVA: 0x17939D0 Offset: 0x1791FD0 VA: 0x1817939D0
	|-Enumerable.WhereSelectListIterator<Int32Enum, float>.MoveNext
	|
	|-RVA: 0x1791BA0 Offset: 0x17901A0 VA: 0x181791BA0
	|-Enumerable.WhereSelectListIterator<object, Debugging.EntityInfo>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, PlayerItemRecipe>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x1790F70 Offset: 0x178F570 VA: 0x181790F70
	|-Enumerable.WhereSelectListIterator<object, FourBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, SevenBitNumber>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, bool>.MoveNext
	|
	|-RVA: 0x1790810 Offset: 0x178EE10 VA: 0x181790810
	|-Enumerable.WhereSelectListIterator<object, PathFinder.Point>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, PlayerItemRecipe.Ingredient>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, InventoryItemId>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, long>.MoveNext
	|
	|-RVA: 0x1792840 Offset: 0x1790E40 VA: 0x181792840
	|-Enumerable.WhereSelectListIterator<object, ProjectileWeaponMod.Modifier>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, Resolution>.MoveNext
	|
	|-RVA: 0x1793DC0 Offset: 0x17923C0 VA: 0x181793DC0
	|-Enumerable.WhereSelectListIterator<object, Option>.MoveNext
	|
	|-RVA: 0x1792070 Offset: 0x1790670 VA: 0x181792070
	|-Enumerable.WhereSelectListIterator<object, InventoryItem>.MoveNext
	|
	|-RVA: 0x1794410 Offset: 0x1792A10 VA: 0x181794410
	|-Enumerable.WhereSelectListIterator<object, InventoryRecipe.Ingredient>.MoveNext
	|
	|-RVA: 0x1794060 Offset: 0x1792660 VA: 0x181794060
	|-Enumerable.WhereSelectListIterator<object, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x1790CD0 Offset: 0x178F2D0 VA: 0x181790CD0
	|-Enumerable.WhereSelectListIterator<object, int>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, Int32Enum>.MoveNext
	|-Enumerable.WhereSelectListIterator<object, uint>.MoveNext
	|
	|-RVA: 0x1791F40 Offset: 0x1790540 VA: 0x181791F40
	|-Enumerable.WhereSelectListIterator<object, object>.MoveNext
	|
	|-RVA: 0x1791E20 Offset: 0x1790420 VA: 0x181791E20
	|-Enumerable.WhereSelectListIterator<object, float>.MoveNext
	*/

	public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC8CEA0 Offset: 0xC8B4A0 VA: 0x180C8CEA0
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
	|-RVA: 0xC8CFE0 Offset: 0xC8B5E0 VA: 0x180C8CFE0
	|-Enumerable.WhereSelectListIterator<Option, Option>.Select<Option>
	|-Enumerable.WhereSelectListIterator<object, Option>.Select<Option>
	|-Enumerable.WhereSelectListIterator<object, InventoryItem>.Select<InventoryItemId>
	|-Enumerable.WhereSelectListIterator<object, InventoryItem>.Select<int>
	|-Enumerable.WhereSelectListIterator<object, InventoryItem>.Select<object>
	|-Enumerable.WhereSelectListIterator<object, InventoryItem>.Select<uint>
	|
	|-RVA: 0xC8D120 Offset: 0xC8B720 VA: 0x180C8D120
	|-Enumerable.WhereSelectListIterator<ServerInfo, ServerInfo>.Select<int>
	|-Enumerable.WhereSelectListIterator<ServerInfo, ServerInfo>.Select<object>
	|
	|-RVA: 0xC8D080 Offset: 0xC8B680 VA: 0x180C8D080
	|-Enumerable.WhereSelectListIterator<InventoryRecipe, PlayerItemRecipe>.Select<object>
	|-Enumerable.WhereSelectListIterator<DictionaryEntry, KeyValuePair<object, object>>.Select<object>
	|-Enumerable.WhereSelectListIterator<object, ProjectileWeaponMod.Modifier>.Select<float>
	|
	|-RVA: 0xC8CF40 Offset: 0xC8B540 VA: 0x180C8CF40
	|-Enumerable.WhereSelectListIterator<object, InventoryRecipe.Ingredient>.Select<PlayerItemRecipe.Ingredient>
	|-Enumerable.WhereSelectListIterator<object, InventoryRecipe.Ingredient>.Select<object>
	|-Enumerable.WhereSelectListIterator<object, InventoryRecipe>.Select<PlayerItemRecipe>
	*/

	public override IEnumerable<TResult> Where(Func<TResult, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17739C0 Offset: 0x1771FC0 VA: 0x1817739C0
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
	|-RVA: 0xD5BAD0 Offset: 0xD5A0D0 VA: 0x180D5BAD0
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
	|-RVA: 0x19EFD70 Offset: 0x19EE370 VA: 0x1819EFD70
	|-Enumerable.<>c__DisplayClass6_0<Debugging.EntityInfo>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<GameStat.Stat>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<PlayerItemRecipe>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<KeyValuePair<object, int>>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<KeyValuePair<object, object>>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<KeyValuePair<uint, object>>.<CombinePredicates>b__0
	|
	|-RVA: 0x19EFE90 Offset: 0x19EE490 VA: 0x1819EFE90
	|-Enumerable.<>c__DisplayClass6_0<SkeletonDefinition.Bone>.<CombinePredicates>b__0
	|
	|-RVA: 0x19F0320 Offset: 0x19EE920 VA: 0x1819F0320
	|-Enumerable.<>c__DisplayClass6_0<ItemSkinDirectory.Skin>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<Option>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<SkinnedMultiMesh.Part>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<InventoryItem>.<CombinePredicates>b__0
	|
	|-RVA: 0x19F02A0 Offset: 0x19EE8A0 VA: 0x1819F02A0
	|-Enumerable.<>c__DisplayClass6_0<FourBitNumber>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<SevenBitNumber>.<CombinePredicates>b__0
	|
	|-RVA: 0x19F0220 Offset: 0x19EE820 VA: 0x1819F0220
	|-Enumerable.<>c__DisplayClass6_0<PathFinder.Point>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<PlayerItemRecipe.Ingredient>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<InventoryItemId>.<CombinePredicates>b__0
	|
	|-RVA: 0x19F00F0 Offset: 0x19EE6F0 VA: 0x1819F00F0
	|-Enumerable.<>c__DisplayClass6_0<ProjectileWeaponMod.Modifier>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<Resolution>.<CombinePredicates>b__0
	|
	|-RVA: 0x19EFF50 Offset: 0x19EE550 VA: 0x1819EFF50
	|-Enumerable.<>c__DisplayClass6_0<ServerInfo>.<CombinePredicates>b__0
	|
	|-RVA: 0x19F03D0 Offset: 0x19EE9D0 VA: 0x1819F03D0
	|-Enumerable.<>c__DisplayClass6_0<InventoryRecipe.Ingredient>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<InventoryRecipe>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<KeyValuePair<ulong, Dispatch.ResultCallback>>.<CombinePredicates>b__0
	|
	|-RVA: 0x19F0500 Offset: 0x19EEB00 VA: 0x1819F0500
	|-Enumerable.<>c__DisplayClass6_0<bool>.<CombinePredicates>b__0
	|
	|-RVA: 0x19F01A0 Offset: 0x19EE7A0 VA: 0x1819F01A0
	|-Enumerable.<>c__DisplayClass6_0<char>.<CombinePredicates>b__0
	|
	|-RVA: 0x19EFE10 Offset: 0x19EE410 VA: 0x1819EFE10
	|-Enumerable.<>c__DisplayClass6_0<int>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<Int32Enum>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<uint>.<CombinePredicates>b__0
	|
	|-RVA: 0x19F0070 Offset: 0x19EE670 VA: 0x1819F0070
	|-Enumerable.<>c__DisplayClass6_0<long>.<CombinePredicates>b__0
	|-Enumerable.<>c__DisplayClass6_0<object>.<CombinePredicates>b__0
	|
	|-RVA: 0x19F0480 Offset: 0x19EEA80 VA: 0x1819F0480
	|-Enumerable.<>c__DisplayClass6_0<float>.<CombinePredicates>b__0
	*/

}

private sealed class Enumerable.<>c__DisplayClass7_0<TSource, TMiddle, TResult> // TypeDefIndex: 3207
{	public Func<TMiddle, TResult> selector2; // 0x0
	public Func<TSource, TMiddle> selector1; // 0x0


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BAD0 Offset: 0xD5A0D0 VA: 0x180D5BAD0
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
	|-RVA: 0x144D280 Offset: 0x144B880 VA: 0x18144D280
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
	|-RVA: 0x144BC50 Offset: 0x144A250 VA: 0x18144BC50
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
	|-RVA: 0x19F0C00 Offset: 0x19EF200 VA: 0x1819F0C00
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, Debugging.EntityInfo, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, KeyValuePair<object, int>, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x19F0650 Offset: 0x19EEC50 VA: 0x1819F0650
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
	|-RVA: 0x19F0980 Offset: 0x19EEF80 VA: 0x1819F0980
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, Resolution, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x19F0780 Offset: 0x19EED80 VA: 0x1819F0780
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, Option, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, InventoryItem, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x19F0580 Offset: 0x19EEB80 VA: 0x1819F0580
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|
	|-RVA: 0x19F0850 Offset: 0x19EEE50 VA: 0x1819F0850
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, bool, bool>.<CombineSelectors>b__0
	|
	|-RVA: 0x19F0A50 Offset: 0x19EF050 VA: 0x1819F0A50
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, Int32Enum, Int32Enum>.<CombineSelectors>b__0
	|
	|-RVA: 0x19F0CC0 Offset: 0x19EF2C0 VA: 0x1819F0CC0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x19F0B50 Offset: 0x19EF150 VA: 0x1819F0B50
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x19F06D0 Offset: 0x19EECD0 VA: 0x1819F06D0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x19F08D0 Offset: 0x19EEED0 VA: 0x1819F08D0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, object, InventoryRecipe>.<CombineSelectors>b__0
	|
	|-RVA: 0x19F0AD0 Offset: 0x19EF0D0 VA: 0x1819F0AD0
	|-Enumerable.<>c__DisplayClass7_0<SkeletonDefinition.Bone, float, float>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C730 Offset: 0x144AD30 VA: 0x18144C730
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, Debugging.EntityInfo, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, KeyValuePair<object, int>, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, Debugging.EntityInfo, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, KeyValuePair<object, int>, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, Debugging.EntityInfo, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, KeyValuePair<object, int>, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x144BB30 Offset: 0x144A130 VA: 0x18144BB30
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
	|-RVA: 0x144BBA0 Offset: 0x144A1A0 VA: 0x18144BBA0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, Resolution, Resolution>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, Resolution, Resolution>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, Resolution, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144BF10 Offset: 0x144A510 VA: 0x18144BF10
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, Option, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, InventoryItem, InventoryItem>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, Option, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, InventoryItem, InventoryItem>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, Option, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, InventoryItem, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C980 Offset: 0x144AF80 VA: 0x18144C980
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D960 Offset: 0x144BF60 VA: 0x18144D960
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, bool, bool>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, bool, bool>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, bool, bool>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C4A0 Offset: 0x144AAA0 VA: 0x18144C4A0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, Int32Enum, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, Int32Enum, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, Int32Enum, Int32Enum>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C2D0 Offset: 0x144A8D0 VA: 0x18144C2D0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x144DF70 Offset: 0x144C570 VA: 0x18144DF70
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, Resolution>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, Resolution>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C8F0 Offset: 0x144AEF0 VA: 0x18144C8F0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, InventoryItem>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, InventoryItem>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x144CFE0 Offset: 0x144B5E0 VA: 0x18144CFE0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, object, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, object, InventoryRecipe>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D2E0 Offset: 0x144B8E0 VA: 0x18144D2E0
	|-Enumerable.<>c__DisplayClass7_0<PlayerItemRecipe, float, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, float, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<uint, object>, float, float>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C510 Offset: 0x144AB10 VA: 0x18144C510
	|-Enumerable.<>c__DisplayClass7_0<Option, Option, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, Option, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, InventoryItem, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x144CAD0 Offset: 0x144B0D0 VA: 0x18144CAD0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, Debugging.EntityInfo, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, KeyValuePair<object, int>, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E1C0 Offset: 0x144C7C0 VA: 0x18144E1C0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, FourBitNumber, FourBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, SevenBitNumber, SevenBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, bool, bool>.<CombineSelectors>b__0
	|
	|-RVA: 0x144CD70 Offset: 0x144B370 VA: 0x18144CD70
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
	|-RVA: 0x144DB50 Offset: 0x144C150 VA: 0x18144DB50
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, Resolution, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144BE10 Offset: 0x144A410 VA: 0x18144BE10
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, Option, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, InventoryItem, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D5D0 Offset: 0x144BBD0 VA: 0x18144D5D0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|
	|-RVA: 0x144DCE0 Offset: 0x144C2E0 VA: 0x18144DCE0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, int, FourBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, int, SevenBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, Int32Enum, Int32Enum>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, int, int>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E970 Offset: 0x144CF70 VA: 0x18144E970
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D9D0 Offset: 0x144BFD0 VA: 0x18144D9D0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D100 Offset: 0x144B700 VA: 0x18144D100
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E880 Offset: 0x144CE80 VA: 0x18144E880
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, object, InventoryRecipe>.<CombineSelectors>b__0
	|
	|-RVA: 0x144EA50 Offset: 0x144D050 VA: 0x18144EA50
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, float, float>.<CombineSelectors>b__0
	|
	|-RVA: 0x144CF50 Offset: 0x144B550 VA: 0x18144CF50
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
	|-RVA: 0x144BD30 Offset: 0x144A330 VA: 0x18144BD30
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
	|-RVA: 0x144C360 Offset: 0x144A960 VA: 0x18144C360
	|-Enumerable.<>c__DisplayClass7_0<Achievement, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, Resolution, Resolution>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, Resolution, Resolution>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, Resolution, Resolution>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, Resolution, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144CA30 Offset: 0x144B030 VA: 0x18144CA30
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
	|-RVA: 0x144C400 Offset: 0x144AA00 VA: 0x18144C400
	|-Enumerable.<>c__DisplayClass7_0<Achievement, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C7D0 Offset: 0x144ADD0 VA: 0x18144C7D0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x144DC50 Offset: 0x144C250 VA: 0x18144DC50
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, Resolution>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D1F0 Offset: 0x144B7F0 VA: 0x18144D1F0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, InventoryItem>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C1C0 Offset: 0x144A7C0 VA: 0x18144C1C0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, object, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, object, InventoryRecipe>.<CombineSelectors>b__0
	|
	|-RVA: 0x144BFC0 Offset: 0x144A5C0 VA: 0x18144BFC0
	|-Enumerable.<>c__DisplayClass7_0<Achievement, float, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, float, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Friend, float, float>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, float, float>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E140 Offset: 0x144C740 VA: 0x18144E140
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E280 Offset: 0x144C880 VA: 0x18144E280
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144CEC0 Offset: 0x144B4C0 VA: 0x18144CEC0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x144CE30 Offset: 0x144B430 VA: 0x18144CE30
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryDefId, object, InventoryRecipe>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D4B0 Offset: 0x144BAB0 VA: 0x18144D4B0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, ServerInfo, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<ServerInfo, ServerInfo, object>.<CombineSelectors>b__0
	|
	|-RVA: 0x144DAB0 Offset: 0x144C0B0 VA: 0x18144DAB0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, Debugging.EntityInfo, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, KeyValuePair<object, int>, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E0C0 Offset: 0x144C6C0 VA: 0x18144E0C0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, FourBitNumber, FourBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, SevenBitNumber, SevenBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, bool, bool>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C140 Offset: 0x144A740 VA: 0x18144C140
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
	|-RVA: 0x144C5D0 Offset: 0x144ABD0 VA: 0x18144C5D0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, Resolution, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E7C0 Offset: 0x144CDC0 VA: 0x18144E7C0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|
	|-RVA: 0x144CC60 Offset: 0x144B260 VA: 0x18144CC60
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, int, FourBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, int, SevenBitNumber>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, Int32Enum, Int32Enum>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D6D0 Offset: 0x144BCD0 VA: 0x18144D6D0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D770 Offset: 0x144BD70 VA: 0x18144D770
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C0A0 Offset: 0x144A6A0 VA: 0x18144C0A0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D350 Offset: 0x144B950 VA: 0x18144D350
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, object, InventoryRecipe>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D080 Offset: 0x144B680 VA: 0x18144D080
	|-Enumerable.<>c__DisplayClass7_0<InventoryItem, float, float>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D8D0 Offset: 0x144BED0 VA: 0x18144D8D0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe, PlayerItemRecipe, object>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C250 Offset: 0x144A850 VA: 0x18144C250
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
	|-RVA: 0x144BA80 Offset: 0x144A080 VA: 0x18144BA80
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, Debugging.EntityInfo, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, KeyValuePair<object, int>, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D810 Offset: 0x144BE10 VA: 0x18144D810
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, Resolution, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144D3F0 Offset: 0x144B9F0 VA: 0x18144D3F0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, Option, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, InventoryItem, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E000 Offset: 0x144C600 VA: 0x18144E000
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, InventoryRecipe, InventoryRecipe>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E630 Offset: 0x144CC30 VA: 0x18144E630
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, bool, bool>.<CombineSelectors>b__0
	|
	|-RVA: 0x144BD90 Offset: 0x144A390 VA: 0x18144BD90
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, int, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, Int32Enum, Int32Enum>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C850 Offset: 0x144AE50 VA: 0x18144C850
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x144DED0 Offset: 0x144C4D0 VA: 0x18144DED0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144DE30 Offset: 0x144C430 VA: 0x18144DE30
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x144CBC0 Offset: 0x144B1C0 VA: 0x18144CBC0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, object, InventoryRecipe>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E430 Offset: 0x144CA30 VA: 0x18144E430
	|-Enumerable.<>c__DisplayClass7_0<InventoryRecipe.Ingredient, float, float>.<CombineSelectors>b__0
	|
	|-RVA: 0x144BCB0 Offset: 0x144A2B0 VA: 0x18144BCB0
	|-Enumerable.<>c__DisplayClass7_0<DictionaryEntry, KeyValuePair<object, object>, object>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E4B0 Offset: 0x144CAB0 VA: 0x18144E4B0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E310 Offset: 0x144C910 VA: 0x18144E310
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E730 Offset: 0x144CD30 VA: 0x18144E730
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x144DDA0 Offset: 0x144C3A0 VA: 0x18144DDA0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, InventoryRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<Int32Enum, object, InventoryRecipe>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E6B0 Offset: 0x144CCB0 VA: 0x18144E6B0
	|-Enumerable.<>c__DisplayClass7_0<object, ProjectileWeaponMod.Modifier, float>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E5B0 Offset: 0x144CBB0 VA: 0x18144E5B0
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryItem, InventoryItemId>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryItem, int>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryItem, object>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryItem, uint>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C690 Offset: 0x144AC90 VA: 0x18144C690
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryRecipe, PlayerItemRecipe>.<CombineSelectors>b__0
	|
	|-RVA: 0x144C020 Offset: 0x144A620 VA: 0x18144C020
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, InventoryRecipe.Ingredient, object>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E530 Offset: 0x144CB30 VA: 0x18144E530
	|-Enumerable.<>c__DisplayClass7_0<object, object, Debugging.EntityInfo>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, object, KeyValuePair<object, int>>.<CombineSelectors>b__0
	|
	|-RVA: 0x144EB10 Offset: 0x144D110 VA: 0x18144EB10
	|-Enumerable.<>c__DisplayClass7_0<object, object, ProjectileWeaponMod.Modifier>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, object, Resolution>.<CombineSelectors>b__0
	|
	|-RVA: 0x144E3A0 Offset: 0x144C9A0 VA: 0x18144E3A0
	|-Enumerable.<>c__DisplayClass7_0<object, object, Option>.<CombineSelectors>b__0
	|-Enumerable.<>c__DisplayClass7_0<object, object, InventoryItem>.<CombineSelectors>b__0
	|
	|-RVA: 0x144CCE0 Offset: 0x144B2E0 VA: 0x18144CCE0
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
	|-RVA: 0x144AB90 Offset: 0x1449190 VA: 0x18144AB90
	|-Enumerable.<SelectManyIterator>d__17<object, PlayerItemRecipe>..ctor
	|
	|-RVA: 0x19D4280 Offset: 0x19D2880 VA: 0x1819D4280
	|-Enumerable.<SelectManyIterator>d__17<object, InventoryRecipe>..ctor
	|
	|-RVA: 0x144AB50 Offset: 0x1449150 VA: 0x18144AB50
	|-Enumerable.<SelectManyIterator>d__17<object, byte>..ctor
	|
	|-RVA: 0x144ABD0 Offset: 0x14491D0 VA: 0x18144ABD0
	|-Enumerable.<SelectManyIterator>d__17<object, object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D3F30 Offset: 0x19D2530 VA: 0x1819D3F30
	|-Enumerable.<SelectManyIterator>d__17<object, PlayerItemRecipe>.System.IDisposable.Dispose
	|-Enumerable.<SelectManyIterator>d__17<object, InventoryRecipe>.System.IDisposable.Dispose
	|-Enumerable.<SelectManyIterator>d__17<object, byte>.System.IDisposable.Dispose
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D3170 Offset: 0x19D1770 VA: 0x1819D3170
	|-Enumerable.<SelectManyIterator>d__17<object, PlayerItemRecipe>.MoveNext
	|
	|-RVA: 0x19D2E90 Offset: 0x19D1490 VA: 0x1819D2E90
	|-Enumerable.<SelectManyIterator>d__17<object, InventoryRecipe>.MoveNext
	|
	|-RVA: 0x19D3710 Offset: 0x19D1D10 VA: 0x1819D3710
	|-Enumerable.<SelectManyIterator>d__17<object, byte>.MoveNext
	|
	|-RVA: 0x19D3440 Offset: 0x19D1A40 VA: 0x1819D3440
	|-Enumerable.<SelectManyIterator>d__17<object, object>.MoveNext
	*/

	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D40F0 Offset: 0x19D26F0 VA: 0x1819D40F0
	|-Enumerable.<SelectManyIterator>d__17<object, PlayerItemRecipe>.<>m__Finally1
	|
	|-RVA: 0x19D40A0 Offset: 0x19D26A0 VA: 0x1819D40A0
	|-Enumerable.<SelectManyIterator>d__17<object, InventoryRecipe>.<>m__Finally1
	|
	|-RVA: 0x19D4000 Offset: 0x19D2600 VA: 0x1819D4000
	|-Enumerable.<SelectManyIterator>d__17<object, byte>.<>m__Finally1
	|
	|-RVA: 0x19D4050 Offset: 0x19D2650 VA: 0x1819D4050
	|-Enumerable.<SelectManyIterator>d__17<object, object>.<>m__Finally1
	*/

	private void <>m__Finally2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D4230 Offset: 0x19D2830 VA: 0x1819D4230
	|-Enumerable.<SelectManyIterator>d__17<object, PlayerItemRecipe>.<>m__Finally2
	|
	|-RVA: 0x19D4190 Offset: 0x19D2790 VA: 0x1819D4190
	|-Enumerable.<SelectManyIterator>d__17<object, InventoryRecipe>.<>m__Finally2
	|
	|-RVA: 0x19D4140 Offset: 0x19D2740 VA: 0x1819D4140
	|-Enumerable.<SelectManyIterator>d__17<object, byte>.<>m__Finally2
	|
	|-RVA: 0x19D41E0 Offset: 0x19D27E0 VA: 0x1819D41E0
	|-Enumerable.<SelectManyIterator>d__17<object, object>.<>m__Finally2
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB119C0 Offset: 0xB0FFC0 VA: 0x180B119C0
	|-Enumerable.<SelectManyIterator>d__17<object, PlayerItemRecipe>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0x1128360 Offset: 0x1126960 VA: 0x181128360
	|-Enumerable.<SelectManyIterator>d__17<object, InventoryRecipe>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0xA115B0 Offset: 0xA0FBB0 VA: 0x180A115B0
	|-Enumerable.<SelectManyIterator>d__17<object, byte>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D3DA0 Offset: 0x19D23A0 VA: 0x1819D3DA0
	|-Enumerable.<SelectManyIterator>d__17<object, PlayerItemRecipe>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D3D50 Offset: 0x19D2350 VA: 0x1819D3D50
	|-Enumerable.<SelectManyIterator>d__17<object, InventoryRecipe>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D3DF0 Offset: 0x19D23F0 VA: 0x1819D3DF0
	|-Enumerable.<SelectManyIterator>d__17<object, byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D3D00 Offset: 0x19D2300 VA: 0x1819D3D00
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D3EE0 Offset: 0x19D24E0 VA: 0x1819D3EE0
	|-Enumerable.<SelectManyIterator>d__17<object, PlayerItemRecipe>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D3E90 Offset: 0x19D2490 VA: 0x1819D3E90
	|-Enumerable.<SelectManyIterator>d__17<object, InventoryRecipe>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D3E40 Offset: 0x19D2440 VA: 0x1819D3E40
	|-Enumerable.<SelectManyIterator>d__17<object, byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D39D0 Offset: 0x19D1FD0 VA: 0x1819D39D0
	|-Enumerable.<SelectManyIterator>d__17<object, PlayerItemRecipe>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0x19D3A90 Offset: 0x19D2090 VA: 0x1819D3A90
	|-Enumerable.<SelectManyIterator>d__17<object, InventoryRecipe>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0x19D3C10 Offset: 0x19D2210 VA: 0x1819D3C10
	|-Enumerable.<SelectManyIterator>d__17<object, byte>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0x19D3B50 Offset: 0x19D2150 VA: 0x1819D3B50
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D3CD0 Offset: 0x19D22D0 VA: 0x1819D3CD0
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
	|-RVA: 0x19D5B80 Offset: 0x19D4180 VA: 0x1819D5B80
	|-Enumerable.<TakeIterator>d__25<Option>..ctor
	|-Enumerable.<TakeIterator>d__25<InventoryItem>..ctor
	|
	|-RVA: 0x144AB50 Offset: 0x1449150 VA: 0x18144AB50
	|-Enumerable.<TakeIterator>d__25<byte>..ctor
	|
	|-RVA: 0x144ABD0 Offset: 0x14491D0 VA: 0x18144ABD0
	|-Enumerable.<TakeIterator>d__25<double>..ctor
	|-Enumerable.<TakeIterator>d__25<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A890 Offset: 0x1448E90 VA: 0x18144A890
	|-Enumerable.<TakeIterator>d__25<Option>.System.IDisposable.Dispose
	|-Enumerable.<TakeIterator>d__25<InventoryItem>.System.IDisposable.Dispose
	|-Enumerable.<TakeIterator>d__25<byte>.System.IDisposable.Dispose
	|-Enumerable.<TakeIterator>d__25<double>.System.IDisposable.Dispose
	|-Enumerable.<TakeIterator>d__25<object>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D4D50 Offset: 0x19D3350 VA: 0x1819D4D50
	|-Enumerable.<TakeIterator>d__25<Option>.MoveNext
	|
	|-RVA: 0x19D52B0 Offset: 0x19D38B0 VA: 0x1819D52B0
	|-Enumerable.<TakeIterator>d__25<InventoryItem>.MoveNext
	|
	|-RVA: 0x19D50F0 Offset: 0x19D36F0 VA: 0x1819D50F0
	|-Enumerable.<TakeIterator>d__25<byte>.MoveNext
	|
	|-RVA: 0x19D4F30 Offset: 0x19D3530 VA: 0x1819D4F30
	|-Enumerable.<TakeIterator>d__25<double>.MoveNext
	|
	|-RVA: 0x19D5490 Offset: 0x19D3A90 VA: 0x1819D5490
	|-Enumerable.<TakeIterator>d__25<object>.MoveNext
	*/

	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D5A40 Offset: 0x19D4040 VA: 0x1819D5A40
	|-Enumerable.<TakeIterator>d__25<Option>.<>m__Finally1
	|
	|-RVA: 0x19D5AE0 Offset: 0x19D40E0 VA: 0x1819D5AE0
	|-Enumerable.<TakeIterator>d__25<InventoryItem>.<>m__Finally1
	|
	|-RVA: 0x19D59F0 Offset: 0x19D3FF0 VA: 0x1819D59F0
	|-Enumerable.<TakeIterator>d__25<byte>.<>m__Finally1
	|
	|-RVA: 0x19D5B30 Offset: 0x19D4130 VA: 0x1819D5B30
	|-Enumerable.<TakeIterator>d__25<double>.<>m__Finally1
	|
	|-RVA: 0x19D5A90 Offset: 0x19D4090 VA: 0x1819D5A90
	|-Enumerable.<TakeIterator>d__25<object>.<>m__Finally1
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176B2D0 Offset: 0x17698D0 VA: 0x18176B2D0
	|-Enumerable.<TakeIterator>d__25<Option>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|-Enumerable.<TakeIterator>d__25<InventoryItem>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0xA115B0 Offset: 0xA0FBB0 VA: 0x180A115B0
	|-Enumerable.<TakeIterator>d__25<byte>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0xB3C030 Offset: 0xB3A630 VA: 0x180B3C030
	|-Enumerable.<TakeIterator>d__25<double>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<TakeIterator>d__25<object>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D5950 Offset: 0x19D3F50 VA: 0x1819D5950
	|-Enumerable.<TakeIterator>d__25<Option>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D5900 Offset: 0x19D3F00 VA: 0x1819D5900
	|-Enumerable.<TakeIterator>d__25<InventoryItem>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D58B0 Offset: 0x19D3EB0 VA: 0x1819D58B0
	|-Enumerable.<TakeIterator>d__25<byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D5860 Offset: 0x19D3E60 VA: 0x1819D5860
	|-Enumerable.<TakeIterator>d__25<double>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D59A0 Offset: 0x19D3FA0 VA: 0x1819D59A0
	|-Enumerable.<TakeIterator>d__25<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176B7C0 Offset: 0x1769DC0 VA: 0x18176B7C0
	|-Enumerable.<TakeIterator>d__25<Option>.System.Collections.IEnumerator.get_Current
	|-Enumerable.<TakeIterator>d__25<InventoryItem>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D4C10 Offset: 0x19D3210 VA: 0x1819D4C10
	|-Enumerable.<TakeIterator>d__25<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x176B6E0 Offset: 0x1769CE0 VA: 0x18176B6E0
	|-Enumerable.<TakeIterator>d__25<double>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<TakeIterator>d__25<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D5700 Offset: 0x19D3D00 VA: 0x1819D5700
	|-Enumerable.<TakeIterator>d__25<Option>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|-Enumerable.<TakeIterator>d__25<InventoryItem>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x19D57B0 Offset: 0x19D3DB0 VA: 0x1819D57B0
	|-Enumerable.<TakeIterator>d__25<byte>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x19D5650 Offset: 0x19D3C50 VA: 0x1819D5650
	|-Enumerable.<TakeIterator>d__25<double>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|-Enumerable.<TakeIterator>d__25<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19B4540 Offset: 0x19B2B40 VA: 0x1819B4540
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
	|-RVA: 0x144ABD0 Offset: 0x14491D0 VA: 0x18144ABD0
	|-Enumerable.<TakeWhileIterator>d__27<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A890 Offset: 0x1448E90 VA: 0x18144A890
	|-Enumerable.<TakeWhileIterator>d__27<object>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D5BC0 Offset: 0x19D41C0 VA: 0x1819D5BC0
	|-Enumerable.<TakeWhileIterator>d__27<object>.MoveNext
	*/

	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D5E00 Offset: 0x19D4400 VA: 0x1819D5E00
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
	|-RVA: 0x19D5DB0 Offset: 0x19D43B0 VA: 0x1819D5DB0
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
	|-RVA: 0x144B430 Offset: 0x1449A30 VA: 0x18144B430
	|-Enumerable.<TakeWhileIterator>d__27<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144B5B0 Offset: 0x1449BB0 VA: 0x18144B5B0
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
	|-RVA: 0x144AB50 Offset: 0x1449150 VA: 0x18144AB50
	|-Enumerable.<SkipIterator>d__31<byte>..ctor
	|
	|-RVA: 0x144ABD0 Offset: 0x14491D0 VA: 0x18144ABD0
	|-Enumerable.<SkipIterator>d__31<double>..ctor
	|-Enumerable.<SkipIterator>d__31<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A890 Offset: 0x1448E90 VA: 0x18144A890
	|-Enumerable.<SkipIterator>d__31<byte>.System.IDisposable.Dispose
	|-Enumerable.<SkipIterator>d__31<double>.System.IDisposable.Dispose
	|-Enumerable.<SkipIterator>d__31<object>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D4770 Offset: 0x19D2D70 VA: 0x1819D4770
	|-Enumerable.<SkipIterator>d__31<byte>.MoveNext
	|
	|-RVA: 0x19D4520 Offset: 0x19D2B20 VA: 0x1819D4520
	|-Enumerable.<SkipIterator>d__31<double>.MoveNext
	|
	|-RVA: 0x19D42C0 Offset: 0x19D28C0 VA: 0x1819D42C0
	|-Enumerable.<SkipIterator>d__31<object>.MoveNext
	*/

	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D4D00 Offset: 0x19D3300 VA: 0x1819D4D00
	|-Enumerable.<SkipIterator>d__31<byte>.<>m__Finally1
	|
	|-RVA: 0x19D4CB0 Offset: 0x19D32B0 VA: 0x1819D4CB0
	|-Enumerable.<SkipIterator>d__31<double>.<>m__Finally1
	|
	|-RVA: 0x19D4C60 Offset: 0x19D3260 VA: 0x1819D4C60
	|-Enumerable.<SkipIterator>d__31<object>.<>m__Finally1
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA115B0 Offset: 0xA0FBB0 VA: 0x180A115B0
	|-Enumerable.<SkipIterator>d__31<byte>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0xB3C030 Offset: 0xB3A630 VA: 0x180B3C030
	|-Enumerable.<SkipIterator>d__31<double>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<SkipIterator>d__31<object>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D4B20 Offset: 0x19D3120 VA: 0x1819D4B20
	|-Enumerable.<SkipIterator>d__31<byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D4BC0 Offset: 0x19D31C0 VA: 0x1819D4BC0
	|-Enumerable.<SkipIterator>d__31<double>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D4B70 Offset: 0x19D3170 VA: 0x1819D4B70
	|-Enumerable.<SkipIterator>d__31<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D4C10 Offset: 0x19D3210 VA: 0x1819D4C10
	|-Enumerable.<SkipIterator>d__31<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x176B6E0 Offset: 0x1769CE0 VA: 0x18176B6E0
	|-Enumerable.<SkipIterator>d__31<double>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<SkipIterator>d__31<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D4A70 Offset: 0x19D3070 VA: 0x1819D4A70
	|-Enumerable.<SkipIterator>d__31<byte>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x19D49C0 Offset: 0x19D2FC0 VA: 0x1819D49C0
	|-Enumerable.<SkipIterator>d__31<double>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|-Enumerable.<SkipIterator>d__31<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19B4540 Offset: 0x19B2B40 VA: 0x1819B4540
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
	|-RVA: 0x144AB50 Offset: 0x1449150 VA: 0x18144AB50
	|-Enumerable.<ConcatIterator>d__59<byte>..ctor
	|
	|-RVA: 0x144ABD0 Offset: 0x14491D0 VA: 0x18144ABD0
	|-Enumerable.<ConcatIterator>d__59<long>..ctor
	|-Enumerable.<ConcatIterator>d__59<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144B770 Offset: 0x1449D70 VA: 0x18144B770
	|-Enumerable.<ConcatIterator>d__59<byte>.System.IDisposable.Dispose
	|-Enumerable.<ConcatIterator>d__59<long>.System.IDisposable.Dispose
	|-Enumerable.<ConcatIterator>d__59<object>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144AC10 Offset: 0x1449210 VA: 0x18144AC10
	|-Enumerable.<ConcatIterator>d__59<byte>.MoveNext
	|
	|-RVA: 0x144B180 Offset: 0x1449780 VA: 0x18144B180
	|-Enumerable.<ConcatIterator>d__59<long>.MoveNext
	|
	|-RVA: 0x144AEC0 Offset: 0x14494C0 VA: 0x18144AEC0
	|-Enumerable.<ConcatIterator>d__59<object>.MoveNext
	*/

	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144B940 Offset: 0x1449F40 VA: 0x18144B940
	|-Enumerable.<ConcatIterator>d__59<byte>.<>m__Finally1
	|
	|-RVA: 0x144B8F0 Offset: 0x1449EF0 VA: 0x18144B8F0
	|-Enumerable.<ConcatIterator>d__59<long>.<>m__Finally1
	|
	|-RVA: 0x144B8A0 Offset: 0x1449EA0 VA: 0x18144B8A0
	|-Enumerable.<ConcatIterator>d__59<object>.<>m__Finally1
	*/

	private void <>m__Finally2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144B9E0 Offset: 0x1449FE0 VA: 0x18144B9E0
	|-Enumerable.<ConcatIterator>d__59<byte>.<>m__Finally2
	|
	|-RVA: 0x144BA30 Offset: 0x144A030 VA: 0x18144BA30
	|-Enumerable.<ConcatIterator>d__59<long>.<>m__Finally2
	|
	|-RVA: 0x144B990 Offset: 0x1449F90 VA: 0x18144B990
	|-Enumerable.<ConcatIterator>d__59<object>.<>m__Finally2
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA115B0 Offset: 0xA0FBB0 VA: 0x180A115B0
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
	|-RVA: 0x144B5E0 Offset: 0x1449BE0 VA: 0x18144B5E0
	|-Enumerable.<ConcatIterator>d__59<byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x144B680 Offset: 0x1449C80 VA: 0x18144B680
	|-Enumerable.<ConcatIterator>d__59<long>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x144B630 Offset: 0x1449C30 VA: 0x18144B630
	|-Enumerable.<ConcatIterator>d__59<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144B6D0 Offset: 0x1449CD0 VA: 0x18144B6D0
	|-Enumerable.<ConcatIterator>d__59<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x144B720 Offset: 0x1449D20 VA: 0x18144B720
	|-Enumerable.<ConcatIterator>d__59<long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<ConcatIterator>d__59<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144B4F0 Offset: 0x1449AF0 VA: 0x18144B4F0
	|-Enumerable.<ConcatIterator>d__59<byte>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x144B430 Offset: 0x1449A30 VA: 0x18144B430
	|-Enumerable.<ConcatIterator>d__59<long>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|-Enumerable.<ConcatIterator>d__59<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144B5B0 Offset: 0x1449BB0 VA: 0x18144B5B0
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
	|-RVA: 0x144ABD0 Offset: 0x14491D0 VA: 0x18144ABD0
	|-Enumerable.<ZipIterator>d__65<object, long, object>..ctor
	|-Enumerable.<ZipIterator>d__65<object, object, object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D3F30 Offset: 0x19D2530 VA: 0x1819D3F30
	|-Enumerable.<ZipIterator>d__65<object, long, object>.System.IDisposable.Dispose
	|-Enumerable.<ZipIterator>d__65<object, object, object>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D6C20 Offset: 0x19D5220 VA: 0x1819D6C20
	|-Enumerable.<ZipIterator>d__65<object, long, object>.MoveNext
	|
	|-RVA: 0x19D6940 Offset: 0x19D4F40 VA: 0x1819D6940
	|-Enumerable.<ZipIterator>d__65<object, object, object>.MoveNext
	*/

	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D7070 Offset: 0x19D5670 VA: 0x1819D7070
	|-Enumerable.<ZipIterator>d__65<object, long, object>.<>m__Finally1
	|
	|-RVA: 0x19D70C0 Offset: 0x19D56C0 VA: 0x1819D70C0
	|-Enumerable.<ZipIterator>d__65<object, object, object>.<>m__Finally1
	*/

	private void <>m__Finally2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D7110 Offset: 0x19D5710 VA: 0x1819D7110
	|-Enumerable.<ZipIterator>d__65<object, long, object>.<>m__Finally2
	|
	|-RVA: 0x19D7160 Offset: 0x19D5760 VA: 0x1819D7160
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
	|-RVA: 0x19D6FD0 Offset: 0x19D55D0 VA: 0x1819D6FD0
	|-Enumerable.<ZipIterator>d__65<object, long, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D7020 Offset: 0x19D5620 VA: 0x1819D7020
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
	|-RVA: 0x19D6F00 Offset: 0x19D5500 VA: 0x1819D6F00
	|-Enumerable.<ZipIterator>d__65<object, long, object>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|-Enumerable.<ZipIterator>d__65<object, object, object>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D3CD0 Offset: 0x19D22D0 VA: 0x1819D3CD0
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
	|-RVA: 0x19D14E0 Offset: 0x19CFAE0 VA: 0x1819D14E0
	|-Enumerable.<DistinctIterator>d__68<ServerInfo>..ctor
	|
	|-RVA: 0x144ABD0 Offset: 0x14491D0 VA: 0x18144ABD0
	|-Enumerable.<DistinctIterator>d__68<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A890 Offset: 0x1448E90 VA: 0x18144A890
	|-Enumerable.<DistinctIterator>d__68<ServerInfo>.System.IDisposable.Dispose
	|-Enumerable.<DistinctIterator>d__68<object>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D0D80 Offset: 0x19CF380 VA: 0x1819D0D80
	|-Enumerable.<DistinctIterator>d__68<ServerInfo>.MoveNext
	|
	|-RVA: 0x19D0B30 Offset: 0x19CF130 VA: 0x1819D0B30
	|-Enumerable.<DistinctIterator>d__68<object>.MoveNext
	*/

	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D1490 Offset: 0x19CFA90 VA: 0x1819D1490
	|-Enumerable.<DistinctIterator>d__68<ServerInfo>.<>m__Finally1
	|
	|-RVA: 0x19D1440 Offset: 0x19CFA40 VA: 0x1819D1440
	|-Enumerable.<DistinctIterator>d__68<object>.<>m__Finally1
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDECE20 Offset: 0xDEB420 VA: 0x180DECE20
	|-Enumerable.<DistinctIterator>d__68<ServerInfo>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<DistinctIterator>d__68<object>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D1310 Offset: 0x19CF910 VA: 0x1819D1310
	|-Enumerable.<DistinctIterator>d__68<ServerInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D1360 Offset: 0x19CF960 VA: 0x1819D1360
	|-Enumerable.<DistinctIterator>d__68<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D13B0 Offset: 0x19CF9B0 VA: 0x1819D13B0
	|-Enumerable.<DistinctIterator>d__68<ServerInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<DistinctIterator>d__68<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D1150 Offset: 0x19CF750 VA: 0x1819D1150
	|-Enumerable.<DistinctIterator>d__68<ServerInfo>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x19D1220 Offset: 0x19CF820 VA: 0x1819D1220
	|-Enumerable.<DistinctIterator>d__68<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D12E0 Offset: 0x19CF8E0 VA: 0x1819D12E0
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
	|-RVA: 0x144AB50 Offset: 0x1449150 VA: 0x18144AB50
	|-Enumerable.<UnionIterator>d__71<char>..ctor
	|
	|-RVA: 0x144ABD0 Offset: 0x14491D0 VA: 0x18144ABD0
	|-Enumerable.<UnionIterator>d__71<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144B770 Offset: 0x1449D70 VA: 0x18144B770
	|-Enumerable.<UnionIterator>d__71<char>.System.IDisposable.Dispose
	|-Enumerable.<UnionIterator>d__71<object>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D61F0 Offset: 0x19D47F0 VA: 0x1819D61F0
	|-Enumerable.<UnionIterator>d__71<char>.MoveNext
	|
	|-RVA: 0x19D5E50 Offset: 0x19D4450 VA: 0x1819D5E50
	|-Enumerable.<UnionIterator>d__71<object>.MoveNext
	*/

	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D6800 Offset: 0x19D4E00 VA: 0x1819D6800
	|-Enumerable.<UnionIterator>d__71<char>.<>m__Finally1
	|
	|-RVA: 0x19D6850 Offset: 0x19D4E50 VA: 0x1819D6850
	|-Enumerable.<UnionIterator>d__71<object>.<>m__Finally1
	*/

	private void <>m__Finally2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D68F0 Offset: 0x19D4EF0 VA: 0x1819D68F0
	|-Enumerable.<UnionIterator>d__71<char>.<>m__Finally2
	|
	|-RVA: 0x19D68A0 Offset: 0x19D4EA0 VA: 0x1819D68A0
	|-Enumerable.<UnionIterator>d__71<object>.<>m__Finally2
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A540 Offset: 0x1448B40 VA: 0x18144A540
	|-Enumerable.<UnionIterator>d__71<char>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<UnionIterator>d__71<object>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D6760 Offset: 0x19D4D60 VA: 0x1819D6760
	|-Enumerable.<UnionIterator>d__71<char>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D6710 Offset: 0x19D4D10 VA: 0x1819D6710
	|-Enumerable.<UnionIterator>d__71<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D67B0 Offset: 0x19D4DB0 VA: 0x1819D67B0
	|-Enumerable.<UnionIterator>d__71<char>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<UnionIterator>d__71<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D6640 Offset: 0x19D4C40 VA: 0x1819D6640
	|-Enumerable.<UnionIterator>d__71<char>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x19D6570 Offset: 0x19D4B70 VA: 0x1819D6570
	|-Enumerable.<UnionIterator>d__71<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D3CD0 Offset: 0x19D22D0 VA: 0x1819D3CD0
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
	|-RVA: 0x144ABD0 Offset: 0x14491D0 VA: 0x18144ABD0
	|-Enumerable.<ExceptIterator>d__77<object>..ctor
	|
	|-RVA: 0x144AB50 Offset: 0x1449150 VA: 0x18144AB50
	|-Enumerable.<ExceptIterator>d__77<float>..ctor
	|
	|-RVA: 0x19D27E0 Offset: 0x19D0DE0 VA: 0x1819D27E0
	|-Enumerable.<ExceptIterator>d__77<Vector2>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A890 Offset: 0x1448E90 VA: 0x18144A890
	|-Enumerable.<ExceptIterator>d__77<object>.System.IDisposable.Dispose
	|-Enumerable.<ExceptIterator>d__77<float>.System.IDisposable.Dispose
	|-Enumerable.<ExceptIterator>d__77<Vector2>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D19C0 Offset: 0x19CFFC0 VA: 0x1819D19C0
	|-Enumerable.<ExceptIterator>d__77<object>.MoveNext
	|
	|-RVA: 0x19D1E50 Offset: 0x19D0450 VA: 0x1819D1E50
	|-Enumerable.<ExceptIterator>d__77<float>.MoveNext
	|
	|-RVA: 0x19D1520 Offset: 0x19CFB20 VA: 0x1819D1520
	|-Enumerable.<ExceptIterator>d__77<Vector2>.MoveNext
	*/

	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D2790 Offset: 0x19D0D90 VA: 0x1819D2790
	|-Enumerable.<ExceptIterator>d__77<object>.<>m__Finally1
	|
	|-RVA: 0x19D2740 Offset: 0x19D0D40 VA: 0x1819D2740
	|-Enumerable.<ExceptIterator>d__77<float>.<>m__Finally1
	|
	|-RVA: 0x19D26F0 Offset: 0x19D0CF0 VA: 0x1819D26F0
	|-Enumerable.<ExceptIterator>d__77<Vector2>.<>m__Finally1
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<ExceptIterator>d__77<object>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0xE73A80 Offset: 0xE72080 VA: 0x180E73A80
	|-Enumerable.<ExceptIterator>d__77<float>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x19D2540 Offset: 0x19D0B40 VA: 0x1819D2540
	|-Enumerable.<ExceptIterator>d__77<Vector2>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D25B0 Offset: 0x19D0BB0 VA: 0x1819D25B0
	|-Enumerable.<ExceptIterator>d__77<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D2600 Offset: 0x19D0C00 VA: 0x1819D2600
	|-Enumerable.<ExceptIterator>d__77<float>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D2560 Offset: 0x19D0B60 VA: 0x1819D2560
	|-Enumerable.<ExceptIterator>d__77<Vector2>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<ExceptIterator>d__77<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D2650 Offset: 0x19D0C50 VA: 0x1819D2650
	|-Enumerable.<ExceptIterator>d__77<float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D26A0 Offset: 0x19D0CA0 VA: 0x1819D26A0
	|-Enumerable.<ExceptIterator>d__77<Vector2>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D2470 Offset: 0x19D0A70 VA: 0x1819D2470
	|-Enumerable.<ExceptIterator>d__77<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x19D23A0 Offset: 0x19D09A0 VA: 0x1819D23A0
	|-Enumerable.<ExceptIterator>d__77<float>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x19D22D0 Offset: 0x19D08D0 VA: 0x1819D22D0
	|-Enumerable.<ExceptIterator>d__77<Vector2>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D12E0 Offset: 0x19CF8E0 VA: 0x1819D12E0
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
	|-RVA: 0x144AB50 Offset: 0x1449150 VA: 0x18144AB50
	|-Enumerable.<ReverseIterator>d__79<char>..ctor
	|
	|-RVA: 0x144ABD0 Offset: 0x14491D0 VA: 0x18144ABD0
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
	|-RVA: 0x19D2B80 Offset: 0x19D1180 VA: 0x1819D2B80
	|-Enumerable.<ReverseIterator>d__79<char>.MoveNext
	|
	|-RVA: 0x19D2C40 Offset: 0x19D1240 VA: 0x1819D2C40
	|-Enumerable.<ReverseIterator>d__79<long>.MoveNext
	|
	|-RVA: 0x19D2AC0 Offset: 0x19D10C0 VA: 0x1819D2AC0
	|-Enumerable.<ReverseIterator>d__79<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A540 Offset: 0x1448B40 VA: 0x18144A540
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
	|-RVA: 0x19D2DA0 Offset: 0x19D13A0 VA: 0x1819D2DA0
	|-Enumerable.<ReverseIterator>d__79<char>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D2D50 Offset: 0x19D1350 VA: 0x1819D2D50
	|-Enumerable.<ReverseIterator>d__79<long>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x19D2D00 Offset: 0x19D1300 VA: 0x1819D2D00
	|-Enumerable.<ReverseIterator>d__79<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D2E40 Offset: 0x19D1440 VA: 0x1819D2E40
	|-Enumerable.<ReverseIterator>d__79<char>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x19D2DF0 Offset: 0x19D13F0 VA: 0x1819D2DF0
	|-Enumerable.<ReverseIterator>d__79<long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<ReverseIterator>d__79<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A490 Offset: 0x1448A90 VA: 0x18144A490
	|-Enumerable.<ReverseIterator>d__79<char>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x144A3E0 Offset: 0x14489E0 VA: 0x18144A3E0
	|-Enumerable.<ReverseIterator>d__79<long>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|-Enumerable.<ReverseIterator>d__79<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A550 Offset: 0x1448B50 VA: 0x18144A550
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
	|-RVA: 0x144ABD0 Offset: 0x14491D0 VA: 0x18144ABD0
	|-Enumerable.<OfTypeIterator>d__97<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A890 Offset: 0x1448E90 VA: 0x18144A890
	|-Enumerable.<OfTypeIterator>d__97<object>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D2820 Offset: 0x19D0E20 VA: 0x1819D2820
	|-Enumerable.<OfTypeIterator>d__97<object>.MoveNext
	*/

	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D2A60 Offset: 0x19D1060 VA: 0x1819D2A60
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
	|-RVA: 0x19D2A10 Offset: 0x19D1010 VA: 0x1819D2A10
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
	|-RVA: 0x144A3E0 Offset: 0x14489E0 VA: 0x18144A3E0
	|-Enumerable.<OfTypeIterator>d__97<object>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A550 Offset: 0x1448B50 VA: 0x18144A550
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
	|-RVA: 0x144AB50 Offset: 0x1449150 VA: 0x18144AB50
	|-Enumerable.<CastIterator>d__99<bool>..ctor
	|-Enumerable.<CastIterator>d__99<byte>..ctor
	|-Enumerable.<CastIterator>d__99<short>..ctor
	|-Enumerable.<CastIterator>d__99<int>..ctor
	|
	|-RVA: 0x144AB90 Offset: 0x1449190 VA: 0x18144AB90
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>..ctor
	|
	|-RVA: 0x144ABD0 Offset: 0x14491D0 VA: 0x18144ABD0
	|-Enumerable.<CastIterator>d__99<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A890 Offset: 0x1448E90 VA: 0x18144A890
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
	|-RVA: 0x144A170 Offset: 0x1448770 VA: 0x18144A170
	|-Enumerable.<CastIterator>d__99<bool>.MoveNext
	|
	|-RVA: 0x14498A0 Offset: 0x1447EA0 VA: 0x1814498A0
	|-Enumerable.<CastIterator>d__99<byte>.MoveNext
	|
	|-RVA: 0x1449A60 Offset: 0x1448060 VA: 0x181449A60
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>.MoveNext
	|
	|-RVA: 0x1449FB0 Offset: 0x14485B0 VA: 0x181449FB0
	|-Enumerable.<CastIterator>d__99<short>.MoveNext
	|
	|-RVA: 0x1449C30 Offset: 0x1448230 VA: 0x181449C30
	|-Enumerable.<CastIterator>d__99<int>.MoveNext
	|
	|-RVA: 0x1449DF0 Offset: 0x14483F0 VA: 0x181449DF0
	|-Enumerable.<CastIterator>d__99<object>.MoveNext
	*/

	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144AAF0 Offset: 0x14490F0 VA: 0x18144AAF0
	|-Enumerable.<CastIterator>d__99<bool>.<>m__Finally1
	|
	|-RVA: 0x144A910 Offset: 0x1448F10 VA: 0x18144A910
	|-Enumerable.<CastIterator>d__99<byte>.<>m__Finally1
	|
	|-RVA: 0x144A9D0 Offset: 0x1448FD0 VA: 0x18144A9D0
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>.<>m__Finally1
	|
	|-RVA: 0x144AA90 Offset: 0x1449090 VA: 0x18144AA90
	|-Enumerable.<CastIterator>d__99<short>.<>m__Finally1
	|
	|-RVA: 0x144A970 Offset: 0x1448F70 VA: 0x18144A970
	|-Enumerable.<CastIterator>d__99<int>.<>m__Finally1
	|
	|-RVA: 0x144AA30 Offset: 0x1449030 VA: 0x18144AA30
	|-Enumerable.<CastIterator>d__99<object>.<>m__Finally1
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA115B0 Offset: 0xA0FBB0 VA: 0x180A115B0
	|-Enumerable.<CastIterator>d__99<bool>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|-Enumerable.<CastIterator>d__99<byte>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0xB119C0 Offset: 0xB0FFC0 VA: 0x180B119C0
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0x144A540 Offset: 0x1448B40 VA: 0x18144A540
	|-Enumerable.<CastIterator>d__99<short>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0x57C960 Offset: 0x57AF60 VA: 0x18057C960
	|-Enumerable.<CastIterator>d__99<int>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<CastIterator>d__99<object>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A620 Offset: 0x1448C20 VA: 0x18144A620
	|-Enumerable.<CastIterator>d__99<bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x144A6C0 Offset: 0x1448CC0 VA: 0x18144A6C0
	|-Enumerable.<CastIterator>d__99<byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x144A580 Offset: 0x1448B80 VA: 0x18144A580
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x144A670 Offset: 0x1448C70 VA: 0x18144A670
	|-Enumerable.<CastIterator>d__99<short>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x144A5D0 Offset: 0x1448BD0 VA: 0x18144A5D0
	|-Enumerable.<CastIterator>d__99<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x144A710 Offset: 0x1448D10 VA: 0x18144A710
	|-Enumerable.<CastIterator>d__99<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A760 Offset: 0x1448D60 VA: 0x18144A760
	|-Enumerable.<CastIterator>d__99<bool>.System.Collections.IEnumerator.get_Current
	|-Enumerable.<CastIterator>d__99<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x144A800 Offset: 0x1448E00 VA: 0x18144A800
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x144A7B0 Offset: 0x1448DB0 VA: 0x18144A7B0
	|-Enumerable.<CastIterator>d__99<short>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x144A850 Offset: 0x1448E50 VA: 0x18144A850
	|-Enumerable.<CastIterator>d__99<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Enumerable.<CastIterator>d__99<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A490 Offset: 0x1448A90 VA: 0x18144A490
	|-Enumerable.<CastIterator>d__99<bool>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|-Enumerable.<CastIterator>d__99<byte>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|-Enumerable.<CastIterator>d__99<short>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|-Enumerable.<CastIterator>d__99<int>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0x144A330 Offset: 0x1448930 VA: 0x18144A330
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0x144A3E0 Offset: 0x14489E0 VA: 0x18144A3E0
	|-Enumerable.<CastIterator>d__99<object>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A550 Offset: 0x1448B50 VA: 0x18144A550
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
	|-RVA: 0x178F310 Offset: 0x178D910 VA: 0x18178F310
	|-EnumerableSorter<Demos.DemoInfo>.Sort
	|
	|-RVA: 0x178F3F0 Offset: 0x178D9F0 VA: 0x18178F3F0
	|-EnumerableSorter<ServerInfo>.Sort
	|
	|-RVA: 0x178FA10 Offset: 0x178E010 VA: 0x18178FA10
	|-EnumerableSorter<Item>.Sort
	|
	|-RVA: 0x178F930 Offset: 0x178DF30 VA: 0x18178F930
	|-EnumerableSorter<KeyValuePair<object, int>>.Sort
	|
	|-RVA: 0x178F4D0 Offset: 0x178DAD0 VA: 0x18178F4D0
	|-EnumerableSorter<KeyValuePair<object, long>>.Sort
	|
	|-RVA: 0x178F850 Offset: 0x178DE50 VA: 0x18178F850
	|-EnumerableSorter<KeyValuePair<object, object>>.Sort
	|
	|-RVA: 0x178F5B0 Offset: 0x178DBB0 VA: 0x18178F5B0
	|-EnumerableSorter<double>.Sort
	|
	|-RVA: 0x178F690 Offset: 0x178DC90 VA: 0x18178F690
	|-EnumerableSorter<object>.Sort
	|
	|-RVA: 0x178F770 Offset: 0x178DD70 VA: 0x18178F770
	|-EnumerableSorter<Resolution>.Sort
	*/

	private void QuickSort(int[] map, int left, int right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178F0F0 Offset: 0x178D6F0 VA: 0x18178F0F0
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
	|-RVA: 0xD5BAD0 Offset: 0xD5A0D0 VA: 0x180D5BAD0
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
	|-RVA: 0x175EBD0 Offset: 0x175D1D0 VA: 0x18175EBD0
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
	|-RVA: 0x178FC00 Offset: 0x178E200 VA: 0x18178FC00
	|-EnumerableSorter<Demos.DemoInfo, DateTime>.ComputeKeys
	|-EnumerableSorter<Demos.DemoInfo, TimeSpan>.ComputeKeys
	|
	|-RVA: 0x178FD50 Offset: 0x178E350 VA: 0x18178FD50
	|-EnumerableSorter<Demos.DemoInfo, object>.ComputeKeys
	|
	|-RVA: 0x1790260 Offset: 0x178E860 VA: 0x181790260
	|-EnumerableSorter<ServerInfo, int>.ComputeKeys
	|-EnumerableSorter<ServerInfo, uint>.ComputeKeys
	|
	|-RVA: 0x178FEB0 Offset: 0x178E4B0 VA: 0x18178FEB0
	|-EnumerableSorter<ServerInfo, object>.ComputeKeys
	|
	|-RVA: 0x1790070 Offset: 0x178E670 VA: 0x181790070
	|-EnumerableSorter<Item, DateTime>.ComputeKeys
	|
	|-RVA: 0x175E270 Offset: 0x175C870 VA: 0x18175E270
	|-EnumerableSorter<KeyValuePair<object, int>, int>.ComputeKeys
	|
	|-RVA: 0x175E720 Offset: 0x175CD20 VA: 0x18175E720
	|-EnumerableSorter<KeyValuePair<object, long>, long>.ComputeKeys
	|-EnumerableSorter<KeyValuePair<object, object>, long>.ComputeKeys
	|
	|-RVA: 0x175E600 Offset: 0x175CC00 VA: 0x18175E600
	|-EnumerableSorter<double, double>.ComputeKeys
	|
	|-RVA: 0x175E990 Offset: 0x175CF90 VA: 0x18175E990
	|-EnumerableSorter<object, bool>.ComputeKeys
	|
	|-RVA: 0x175EAB0 Offset: 0x175D0B0 VA: 0x18175EAB0
	|-EnumerableSorter<object, DateTime>.ComputeKeys
	|
	|-RVA: 0x175E020 Offset: 0x175C620 VA: 0x18175E020
	|-EnumerableSorter<object, DateTimeOffset>.ComputeKeys
	|-EnumerableSorter<object, Guid>.ComputeKeys
	|
	|-RVA: 0x175E3A0 Offset: 0x175C9A0 VA: 0x18175E3A0
	|-EnumerableSorter<object, int>.ComputeKeys
	|-EnumerableSorter<object, Int32Enum>.ComputeKeys
	|-EnumerableSorter<object, uint>.ComputeKeys
	|
	|-RVA: 0x175E860 Offset: 0x175CE60 VA: 0x18175E860
	|-EnumerableSorter<object, object>.ComputeKeys
	|
	|-RVA: 0x175E150 Offset: 0x175C750 VA: 0x18175E150
	|-EnumerableSorter<object, float>.ComputeKeys
	|
	|-RVA: 0x175E4C0 Offset: 0x175CAC0 VA: 0x18175E4C0
	|-EnumerableSorter<Resolution, int>.ComputeKeys
	*/

	internal override int CompareKeys(int index1, int index2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178FAF0 Offset: 0x178E0F0 VA: 0x18178FAF0
	|-EnumerableSorter<Demos.DemoInfo, DateTime>.CompareKeys
	|-EnumerableSorter<Item, DateTime>.CompareKeys
	|
	|-RVA: 0x175D6A0 Offset: 0x175BCA0 VA: 0x18175D6A0
	|-EnumerableSorter<Demos.DemoInfo, object>.CompareKeys
	|-EnumerableSorter<ServerInfo, object>.CompareKeys
	|-EnumerableSorter<KeyValuePair<object, long>, long>.CompareKeys
	|-EnumerableSorter<KeyValuePair<object, object>, long>.CompareKeys
	|
	|-RVA: 0x175DBD0 Offset: 0x175C1D0 VA: 0x18175DBD0
	|-EnumerableSorter<Demos.DemoInfo, TimeSpan>.CompareKeys
	|-EnumerableSorter<object, DateTime>.CompareKeys
	|
	|-RVA: 0x175DD40 Offset: 0x175C340 VA: 0x18175DD40
	|-EnumerableSorter<ServerInfo, int>.CompareKeys
	|-EnumerableSorter<ServerInfo, uint>.CompareKeys
	|-EnumerableSorter<object, uint>.CompareKeys
	|
	|-RVA: 0x175D940 Offset: 0x175BF40 VA: 0x18175D940
	|-EnumerableSorter<KeyValuePair<object, int>, int>.CompareKeys
	|-EnumerableSorter<object, int>.CompareKeys
	|-EnumerableSorter<object, Int32Enum>.CompareKeys
	|-EnumerableSorter<Resolution, int>.CompareKeys
	|
	|-RVA: 0x175DA50 Offset: 0x175C050 VA: 0x18175DA50
	|-EnumerableSorter<double, double>.CompareKeys
	|
	|-RVA: 0x175D530 Offset: 0x175BB30 VA: 0x18175D530
	|-EnumerableSorter<object, bool>.CompareKeys
	|
	|-RVA: 0x175D7B0 Offset: 0x175BDB0 VA: 0x18175D7B0
	|-EnumerableSorter<object, DateTimeOffset>.CompareKeys
	|-EnumerableSorter<object, Guid>.CompareKeys
	|
	|-RVA: 0x175D3D0 Offset: 0x175B9D0 VA: 0x18175D3D0
	|-EnumerableSorter<object, object>.CompareKeys
	|
	|-RVA: 0x175DEA0 Offset: 0x175C4A0 VA: 0x18175DEA0
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

