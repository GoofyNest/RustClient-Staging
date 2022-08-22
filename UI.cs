public interface SmallXmlParser.IContentHandler // TypeDefIndex: 25
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnStartParsing(SmallXmlParser parser);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnEndParsing(SmallXmlParser parser);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnStartElement(string name, SmallXmlParser.IAttrList attrs);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnEndElement(string name);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnProcessingInstruction(string name, string text);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnChars(string text);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void OnIgnorableWhitespace(string text);

}

public interface SmallXmlParser.IAttrList // TypeDefIndex: 26
{	// Properties
	public abstract int Length { get; }
	public abstract string[] Names { get; }
	public abstract string[] Values { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_Length();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string GetName(int i);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string GetValue(int i);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string GetValue(string name);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string[] get_Names();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string[] get_Values();

}

internal interface IRegistryApi // TypeDefIndex: 100
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract RegistryKey OpenSubKey(RegistryKey rkey, string keyname, bool writtable);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Flush(RegistryKey rkey);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Close(RegistryKey rkey);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract object GetValue(RegistryKey rkey, string name, object default_value, RegistryValueOptions options);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string[] GetSubKeyNames(RegistryKey rkey);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string ToString(RegistryKey rkey);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IntPtr GetHandle(RegistryKey key);

}

internal interface ITupleInternal // TypeDefIndex: 134
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string ToString(StringBuilder sb);

}

public interface IAsyncResult // TypeDefIndex: 246
{	// Properties
	public abstract bool IsCompleted { get; }
	public abstract WaitHandle AsyncWaitHandle { get; }
	public abstract object AsyncState { get; }
	public abstract bool CompletedSynchronously { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsCompleted();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract WaitHandle get_AsyncWaitHandle();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract object get_AsyncState();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool get_CompletedSynchronously();

}

public interface ICloneable // TypeDefIndex: 247
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object Clone();

}

public interface IComparable // TypeDefIndex: 248
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int CompareTo(object obj);

}

public interface IComparable<T> // TypeDefIndex: 249
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int CompareTo(T other);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IComparable<object>.CompareTo
	*/

}

public interface IConvertible // TypeDefIndex: 250
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TypeCode GetTypeCode();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool ToBoolean(IFormatProvider provider);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract char ToChar(IFormatProvider provider);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract sbyte ToSByte(IFormatProvider provider);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract byte ToByte(IFormatProvider provider);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract short ToInt16(IFormatProvider provider);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract ushort ToUInt16(IFormatProvider provider);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int ToInt32(IFormatProvider provider);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract uint ToUInt32(IFormatProvider provider);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract long ToInt64(IFormatProvider provider);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract ulong ToUInt64(IFormatProvider provider);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract float ToSingle(IFormatProvider provider);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract double ToDouble(IFormatProvider provider);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract Decimal ToDecimal(IFormatProvider provider);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract DateTime ToDateTime(IFormatProvider provider);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract string ToString(IFormatProvider provider);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract object ToType(Type conversionType, IFormatProvider provider);

}

public interface ICustomFormatter // TypeDefIndex: 251
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string Format(string format, object arg, IFormatProvider formatProvider);

}

public interface IDisposable // TypeDefIndex: 252
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Dispose();

}

public interface IEquatable<T> // TypeDefIndex: 253
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Equals(T other);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IEquatable<object>.Equals
	*/

}

public interface IFormatProvider // TypeDefIndex: 254
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object GetFormat(Type formatType);

}

public interface IFormattable // TypeDefIndex: 255
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string ToString(string format, IFormatProvider formatProvider);

}

public interface IProgress<T> // TypeDefIndex: 264
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Report(T value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IProgress<object>.Report
	*/

}

public interface IServiceProvider // TypeDefIndex: 265
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object GetService(Type serviceType);

}

public struct UInt16 : IComparable, IFormattable, IConvertible, IComparable<ushort>, IEquatable<ushort> // TypeDefIndex: 326
{	// Fields
	private ushort m_value; // 0x0
	public const ushort MaxValue = 65535;
	public const ushort MinValue = 0;

	// Methods

	// RVA: 0x232A70 Offset: 0x231E70 VA: 0x180232A70 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x1F3220 Offset: 0x1F2620 VA: 0x1801F3220 Slot: 23
	public int CompareTo(ushort value) { }

	// RVA: 0x232B40 Offset: 0x231F40 VA: 0x180232B40 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1F3390 Offset: 0x1F2790 VA: 0x1801F3390 Slot: 24
	public bool Equals(ushort obj) { }

	// RVA: 0x120EA0 Offset: 0x1202A0 VA: 0x180120EA0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x233160 Offset: 0x232560 VA: 0x180233160 Slot: 3
	public override string ToString() { }

	// RVA: 0x233190 Offset: 0x232590 VA: 0x180233190 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x233120 Offset: 0x232520 VA: 0x180233120
	public string ToString(string format) { }

	// RVA: 0x2331C0 Offset: 0x2325C0 VA: 0x1802331C0 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x2145C10 Offset: 0x2144210 VA: 0x182145C10
	public static ushort Parse(string s, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x2145C40 Offset: 0x2144240 VA: 0x182145C40
	public static ushort Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x2145B20 Offset: 0x2144120 VA: 0x182145B20
	private static ushort Parse(string s, NumberStyles style, NumberFormatInfo info) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x2145E90 Offset: 0x2144490 VA: 0x182145E90
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out ushort result) { }

	// RVA: 0x2145E40 Offset: 0x2144440 VA: 0x182145E40
	private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out ushort result) { }

	// RVA: 0x232BD0 Offset: 0x231FD0 VA: 0x180232BD0 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x232BE0 Offset: 0x231FE0 VA: 0x180232BE0 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x232CA0 Offset: 0x2320A0 VA: 0x180232CA0 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x232F10 Offset: 0x232310 VA: 0x180232F10 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x232C40 Offset: 0x232040 VA: 0x180232C40 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x232DF0 Offset: 0x2321F0 VA: 0x180232DF0 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x120EA0 Offset: 0x1202A0 VA: 0x180120EA0 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x232E50 Offset: 0x232250 VA: 0x180232E50 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x233060 Offset: 0x232460 VA: 0x180233060 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x232EB0 Offset: 0x2322B0 VA: 0x180232EB0 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x2330C0 Offset: 0x2324C0 VA: 0x1802330C0 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x232F70 Offset: 0x232370 VA: 0x180232F70 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x232D90 Offset: 0x232190 VA: 0x180232D90 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x232D10 Offset: 0x232110 VA: 0x180232D10 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x232D00 Offset: 0x232100 VA: 0x180232D00 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x232FD0 Offset: 0x2323D0 VA: 0x180232FD0 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

}

public struct UInt32 : IComparable, IFormattable, IConvertible, IComparable<uint>, IEquatable<uint> // TypeDefIndex: 327
{	// Fields
	private uint m_value; // 0x0
	public const uint MaxValue = 4294967295;
	public const uint MinValue = 0;

	// Methods

	// RVA: 0x233200 Offset: 0x232600 VA: 0x180233200 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x233300 Offset: 0x232700 VA: 0x180233300 Slot: 23
	public int CompareTo(uint value) { }

	// RVA: 0x233320 Offset: 0x232720 VA: 0x180233320 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1E5480 Offset: 0x1E4880 VA: 0x1801E5480 Slot: 24
	public bool Equals(uint obj) { }

	// RVA: 0xF3720 Offset: 0xF2B20 VA: 0x1800F3720 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x233920 Offset: 0x232D20 VA: 0x180233920 Slot: 3
	public override string ToString() { }

	// RVA: 0x233950 Offset: 0x232D50 VA: 0x180233950 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x2338E0 Offset: 0x232CE0 VA: 0x1802338E0 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x21460A0 Offset: 0x21446A0 VA: 0x1821460A0
	public static uint Parse(string s) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x21460D0 Offset: 0x21446D0 VA: 0x1821460D0
	public static uint Parse(string s, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x2146100 Offset: 0x2144700 VA: 0x182146100
	public static uint Parse(string s, NumberStyles style, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x21462C0 Offset: 0x21448C0 VA: 0x1821462C0
	public static bool TryParse(string s, out uint result) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x2146300 Offset: 0x2144900 VA: 0x182146300
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out uint result) { }

	// RVA: 0x2333A0 Offset: 0x2327A0 VA: 0x1802333A0 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x2333B0 Offset: 0x2327B0 VA: 0x1802333B0 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x233470 Offset: 0x232870 VA: 0x180233470 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x2336D0 Offset: 0x232AD0 VA: 0x1802336D0 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x233410 Offset: 0x232810 VA: 0x180233410 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x2335B0 Offset: 0x2329B0 VA: 0x1802335B0 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x233820 Offset: 0x232C20 VA: 0x180233820 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x233610 Offset: 0x232A10 VA: 0x180233610 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0xF3720 Offset: 0xF2B20 VA: 0x1800F3720 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x233670 Offset: 0x232A70 VA: 0x180233670 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x233880 Offset: 0x232C80 VA: 0x180233880 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x233730 Offset: 0x232B30 VA: 0x180233730 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x233550 Offset: 0x232950 VA: 0x180233550 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x2334E0 Offset: 0x2328E0 VA: 0x1802334E0 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x2334D0 Offset: 0x2328D0 VA: 0x1802334D0 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x233790 Offset: 0x232B90 VA: 0x180233790 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

}

public struct UInt64 : IComparable, IFormattable, IConvertible, IComparable<ulong>, IEquatable<ulong> // TypeDefIndex: 328
{	// Fields
	private ulong m_value; // 0x0
	public const ulong MaxValue = 18446744073709551615;
	public const ulong MinValue = 0;

	// Methods

	// RVA: 0x2339A0 Offset: 0x232DA0 VA: 0x1802339A0 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x233980 Offset: 0x232D80 VA: 0x180233980 Slot: 23
	public int CompareTo(ulong value) { }

	// RVA: 0x233AA0 Offset: 0x232EA0 VA: 0x180233AA0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1F49A0 Offset: 0x1F3DA0 VA: 0x1801F49A0 Slot: 24
	public bool Equals(ulong obj) { }

	// RVA: 0x233B30 Offset: 0x232F30 VA: 0x180233B30 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x234100 Offset: 0x233500 VA: 0x180234100 Slot: 3
	public override string ToString() { }

	// RVA: 0x2340D0 Offset: 0x2334D0 VA: 0x1802340D0 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x234090 Offset: 0x233490 VA: 0x180234090
	public string ToString(string format) { }

	// RVA: 0x234130 Offset: 0x233530 VA: 0x180234130 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x2146580 Offset: 0x2144B80 VA: 0x182146580
	public static ulong Parse(string s) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x2146500 Offset: 0x2144B00 VA: 0x182146500
	public static ulong Parse(string s, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x2146530 Offset: 0x2144B30 VA: 0x182146530
	public static ulong Parse(string s, NumberStyles style, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x21467C0 Offset: 0x2144DC0 VA: 0x1821467C0
	public static bool TryParse(string s, out ulong result) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x2146760 Offset: 0x2144D60 VA: 0x182146760
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out ulong result) { }

	// RVA: 0x233B40 Offset: 0x232F40 VA: 0x180233B40 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x233B50 Offset: 0x232F50 VA: 0x180233B50 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x233C10 Offset: 0x233010 VA: 0x180233C10 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x233E80 Offset: 0x233280 VA: 0x180233E80 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x233BB0 Offset: 0x232FB0 VA: 0x180233BB0 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x233D60 Offset: 0x233160 VA: 0x180233D60 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x233FD0 Offset: 0x2333D0 VA: 0x180233FD0 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x233DC0 Offset: 0x2331C0 VA: 0x180233DC0 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x234030 Offset: 0x233430 VA: 0x180234030 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x233E20 Offset: 0x233220 VA: 0x180233E20 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0xFC840 Offset: 0xFBC40 VA: 0x1800FC840 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x233EE0 Offset: 0x2332E0 VA: 0x180233EE0 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x233D00 Offset: 0x233100 VA: 0x180233D00 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x233C80 Offset: 0x233080 VA: 0x180233C80 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x233C70 Offset: 0x233070 VA: 0x180233C70 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x233F40 Offset: 0x233340 VA: 0x180233F40 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

}

internal enum UInt16Enum // TypeDefIndex: 365
{	// Fields
	public ushort value__; // 0x0

}

internal enum UInt32Enum // TypeDefIndex: 366
{	// Fields
	public uint value__; // 0x0

}

internal enum UInt64Enum // TypeDefIndex: 367
{	// Fields
	public ulong value__; // 0x0

}

internal interface IConsoleDriver // TypeDefIndex: 368
{	// Properties
	public abstract ConsoleColor BackgroundColor { get; set; }
	public abstract int BufferWidth { get; }
	public abstract int CursorLeft { set; }
	public abstract int CursorTop { get; set; }
	public abstract ConsoleColor ForegroundColor { get; set; }
	public abstract bool KeyAvailable { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ConsoleColor get_BackgroundColor();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_BackgroundColor(ConsoleColor value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_BufferWidth();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_CursorLeft(int value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_CursorTop();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void set_CursorTop(int value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract ConsoleColor get_ForegroundColor();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void set_ForegroundColor(ConsoleColor value);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_KeyAvailable();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract ConsoleKeyInfo ReadKey(bool intercept);

}

internal interface TypeName : IEquatable<TypeName> // TypeDefIndex: 405
{	// Properties
	public abstract string DisplayName { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_DisplayName();

}

internal interface TypeIdentifier : TypeName, IEquatable<TypeName> // TypeDefIndex: 406
{	// Properties
	public abstract string InternalName { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_InternalName();

}

internal interface ModifierSpec // TypeDefIndex: 411
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Type Resolve(Type type);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract StringBuilder Append(StringBuilder sb);

}

public struct UIntPtr : ISerializable // TypeDefIndex: 416
{	// Fields
	public static readonly UIntPtr Zero; // 0x0
	private void* _pointer; // 0x0

	// Properties
	public static int Size { get; }

	// Methods

	// RVA: 0x234300 Offset: 0x233700 VA: 0x180234300
	public void .ctor(uint value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1D3520 Offset: 0x1D2920 VA: 0x1801D3520
	public void .ctor(void* value) { }

	// RVA: 0x234170 Offset: 0x233570 VA: 0x180234170 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xF3720 Offset: 0xF2B20 VA: 0x1800F3720 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x234290 Offset: 0x233690 VA: 0x180234290 Slot: 3
	public override string ToString() { }

	// RVA: 0x234200 Offset: 0x233600 VA: 0x180234200 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xAE6170 Offset: 0xAE4770 VA: 0x180AE6170
	public static bool op_Equality(UIntPtr value1, UIntPtr value2) { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80
	public static ulong op_Explicit(UIntPtr value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80
	public static UIntPtr op_Explicit(void* value) { }

	// RVA: 0x8C1310 Offset: 0x8BF910 VA: 0x1808C1310
	public static int get_Size() { }

	// RVA: 0x2146890 Offset: 0x2144E90 VA: 0x182146890
	private static void .cctor() { }

}

internal interface IResourceGroveler // TypeDefIndex: 483
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ResourceSet GrovelForResourceSet(CultureInfo culture, Dictionary<string, ResourceSet> localResourceSets, bool tryParents, bool createIfNotExists, ref StackCrawlMark stackMark);

}

public interface IResourceReader : IEnumerable, IDisposable // TypeDefIndex: 484
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Close();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IDictionaryEnumerator GetEnumerator();

}

public interface ICustomAttributeProvider // TypeDefIndex: 527
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object[] GetCustomAttributes(Type attributeType, bool inherit);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object[] GetCustomAttributes(bool inherit);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool IsDefined(Type attributeType, bool inherit);

}

public interface IReflectableType // TypeDefIndex: 530
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TypeInfo GetTypeInfo();

}

internal interface IAsyncLocal // TypeDefIndex: 775
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnValueChanged(object previousValue, object currentValue, bool contextChanged);

}

internal interface IThreadPoolWorkItem // TypeDefIndex: 805
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ExecuteWorkItem();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void MarkAborted(ThreadAbortException tae);

}

internal interface ITaskCompletionAction // TypeDefIndex: 867
{
// Namespace: System.Threading.Tasks
internal interface ITaskCompletionAction // TypeDefIndex: 867
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Invoke(Task completingTask);

}

public interface IPermission : ISecurityEncodable // TypeDefIndex: 899
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Demand();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool IsSubsetOf(IPermission target);

}

public interface ISecurityEncodable // TypeDefIndex: 900
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract SecurityElement ToXml();

}

internal interface Tokenizer.ITokenReader // TypeDefIndex: 923
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int Read();

}

public interface IIdentity // TypeDefIndex: 928
{	// Properties
	public abstract string AuthenticationType { get; }
	public abstract string Name { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_AuthenticationType();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_Name();

}

public interface ICryptoTransform : IDisposable // TypeDefIndex: 967
{	// Properties
	public abstract int InputBlockSize { get; }
	public abstract int OutputBlockSize { get; }
	public abstract bool CanTransformMultipleBlocks { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_InputBlockSize();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_OutputBlockSize();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_CanTransformMultipleBlocks();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount);

}

internal interface INativeCertificateHelper // TypeDefIndex: 1016
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract X509CertificateImpl Import(X509Certificate cert);

}

public interface IDeserializationCallback // TypeDefIndex: 1029
{
// Namespace: System.Runtime.Serialization
[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
public interface IDeserializationCallback // TypeDefIndex: 1029
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnDeserialization(object sender);

}

public interface IFormatterConverter // TypeDefIndex: 1030
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object Convert(object value, Type type);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool ToBoolean(object value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int ToInt32(object value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract long ToInt64(object value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract float ToSingle(object value);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string ToString(object value);

}

public interface IObjectReference // TypeDefIndex: 1031
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object GetRealObject(StreamingContext context);

}

public interface ISerializable // TypeDefIndex: 1032
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void GetObjectData(SerializationInfo info, StreamingContext context);

}

public interface ISerializationSurrogate // TypeDefIndex: 1033
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void GetObjectData(object obj, SerializationInfo info, StreamingContext context);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector);

}

public interface ISurrogateSelector // TypeDefIndex: 1034
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector selector);

}

public interface ISafeSerializationData // TypeDefIndex: 1046
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void CompleteDeserialization(object deserialized);

}

public interface IChannelInfo // TypeDefIndex: 1130
{	// Properties
	public abstract object[] ChannelData { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object[] get_ChannelData();

}

public interface IEnvoyInfo // TypeDefIndex: 1131
{	// Properties
	public abstract IMessageSink EnvoySinks { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IMessageSink get_EnvoySinks();

}

public interface IRemotingTypeInfo // TypeDefIndex: 1132
{	// Properties
	public abstract string TypeName { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_TypeName();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool CanCastTo(Type fromType, object o);

}

public interface ITrackingHandler // TypeDefIndex: 1157
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void DisconnectedObject(object obj);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void MarshaledObject(object obj, ObjRef or);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void UnmarshaledObject(object obj, ObjRef or);

}

public interface ILease // TypeDefIndex: 1163
{	// Properties
	public abstract TimeSpan CurrentLeaseTime { get; }
	public abstract LeaseState CurrentState { get; }
	public abstract TimeSpan RenewOnCallTime { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TimeSpan get_CurrentLeaseTime();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract LeaseState get_CurrentState();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract TimeSpan get_RenewOnCallTime();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract TimeSpan Renew(TimeSpan renewalTime);

}

public interface ISponsor // TypeDefIndex: 1164
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TimeSpan Renewal(ILease lease);

}

public interface IContextAttribute // TypeDefIndex: 1178
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void GetPropertiesForNewContext(IConstructionCallMessage msg);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool IsContextOK(Context ctx, IConstructionCallMessage msg);

}

public interface IContextProperty // TypeDefIndex: 1179
{	// Properties
	public abstract string Name { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Freeze(Context newContext);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool IsNewContextOK(Context newCtx);

}

public interface IContributeClientContextSink // TypeDefIndex: 1180
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IMessageSink GetClientContextSink(IMessageSink nextSink);

}

public interface IContributeDynamicSink // TypeDefIndex: 1181
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IDynamicMessageSink GetDynamicSink();

}

public interface IContributeEnvoySink // TypeDefIndex: 1182
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IMessageSink GetEnvoySink(MarshalByRefObject obj, IMessageSink nextSink);

}

public interface IContributeObjectSink // TypeDefIndex: 1183
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IMessageSink GetObjectSink(MarshalByRefObject obj, IMessageSink nextSink);

}

public interface IContributeServerContextSink // TypeDefIndex: 1184
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IMessageSink GetServerContextSink(IMessageSink nextSink);

}

public interface IDynamicMessageSink // TypeDefIndex: 1185
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ProcessMessageFinish(IMessage replyMsg, bool bCliSide, bool bAsync);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void ProcessMessageStart(IMessage reqMsg, bool bCliSide, bool bAsync);

}

public interface IDynamicProperty // TypeDefIndex: 1186
{	// Properties
	public abstract string Name { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Name();

}

public interface IChannel // TypeDefIndex: 1194
{	// Properties
	public abstract string ChannelName { get; }
	public abstract int ChannelPriority { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_ChannelName();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_ChannelPriority();

}

public interface IChannelReceiver : IChannel // TypeDefIndex: 1196
{
// Namespace: System.Runtime.Remoting.Channels
[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
public interface IChannelReceiver : IChannel // TypeDefIndex: 1196
	// Properties
	public abstract object ChannelData { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_ChannelData();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void StartListening(object data);

}

public interface IChannelSender : IChannel // TypeDefIndex: 1197
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IMessageSink CreateMessageSink(string url, object remoteChannelData, out string objectURI);

}

public interface IClientChannelSinkProvider // TypeDefIndex: 1198
{	// Properties
	public abstract IClientChannelSinkProvider Next { set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void set_Next(IClientChannelSinkProvider value);

}

public interface ISecurableChannel // TypeDefIndex: 1199
{	// Properties
	public abstract bool IsSecured { set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void set_IsSecured(bool value);

}

public interface IServerChannelSinkProvider // TypeDefIndex: 1200
{	// Properties
	public abstract IServerChannelSinkProvider Next { set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void set_Next(IServerChannelSinkProvider value);

}

public interface IActivator // TypeDefIndex: 1206
{	// Properties
	public abstract IActivator NextActivator { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IActivator get_NextActivator();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IConstructionReturnMessage Activate(IConstructionCallMessage msg);

}

public interface IConstructionCallMessage : IMessage, IMethodCallMessage, IMethodMessage // TypeDefIndex: 1207
{	// Properties
	public abstract Type ActivationType { get; }
	public abstract string ActivationTypeName { get; }
	public abstract IActivator Activator { get; set; }
	public abstract object[] CallSiteActivationAttributes { get; }
	public abstract IList ContextProperties { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Type get_ActivationType();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_ActivationTypeName();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IActivator get_Activator();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_Activator(IActivator value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract object[] get_CallSiteActivationAttributes();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IList get_ContextProperties();

}

internal interface IInternalMessage // TypeDefIndex: 1239
{	// Properties
	public abstract Identity TargetIdentity { get; set; }
	public abstract string Uri { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Identity get_TargetIdentity();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_TargetIdentity(Identity value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_Uri();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_Uri(string value);

}

public interface IMessage // TypeDefIndex: 1240
{	// Properties
	public abstract IDictionary Properties { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IDictionary get_Properties();

}

public interface IMessageSink // TypeDefIndex: 1242
{
// Namespace: System.Runtime.Remoting.Messaging
[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
public interface IMessageSink // TypeDefIndex: 1242
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IMessage SyncProcessMessage(IMessage msg);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink);

}

public interface IMethodMessage : IMessage // TypeDefIndex: 1244
{
// Namespace: System.Runtime.Remoting.Messaging
[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
public interface IMethodMessage : IMessage // TypeDefIndex: 1244
	// Properties
	public abstract int ArgCount { get; }
	public abstract object[] Args { get; }
	public abstract LogicalCallContext LogicalCallContext { get; }
	public abstract MethodBase MethodBase { get; }
	public abstract string MethodName { get; }
	public abstract object MethodSignature { get; }
	public abstract string TypeName { get; }
	public abstract string Uri { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_ArgCount();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object[] get_Args();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract LogicalCallContext get_LogicalCallContext();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract MethodBase get_MethodBase();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string get_MethodName();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract object get_MethodSignature();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string get_TypeName();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string get_Uri();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract object GetArg(int argNum);

}

public interface IMethodReturnMessage : IMethodMessage, IMessage // TypeDefIndex: 1245
{	// Properties
	public abstract Exception Exception { get; }
	public abstract object[] OutArgs { get; }
	public abstract object ReturnValue { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Exception get_Exception();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object[] get_OutArgs();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract object get_ReturnValue();

}

public interface IAsyncStateMachine // TypeDefIndex: 1283
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void MoveNext();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetStateMachine(IAsyncStateMachine stateMachine);

}

public interface INotifyCompletion // TypeDefIndex: 1284
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnCompleted(Action continuation);

}

public interface ICriticalNotifyCompletion : INotifyCompletion // TypeDefIndex: 1285
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void UnsafeOnCompleted(Action continuation);

}

public interface ICustomMarshaler // TypeDefIndex: 1349
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object MarshalNativeToManaged(IntPtr pNativeData);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IntPtr MarshalManagedToNative(object ManagedObj);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void CleanUpNativeData(IntPtr pNativeData);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void CleanUpManagedData(object ManagedObj);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int GetNativeDataSize();

}

public interface ICollection : IEnumerable // TypeDefIndex: 1397
{	// Properties
	public abstract int Count { get; }
	public abstract object SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void CopyTo(Array array, int index);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_Count();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract object get_SyncRoot();

}

public interface IComparer // TypeDefIndex: 1398
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int Compare(object x, object y);

}

public interface IDictionary : ICollection, IEnumerable // TypeDefIndex: 1399
{	// Properties
	public abstract object Item { get; set; }
	public abstract ICollection Keys { get; }
	public abstract ICollection Values { get; }
	public abstract bool IsReadOnly { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_Item(object key);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Item(object key, object value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract ICollection get_Keys();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract ICollection get_Values();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool Contains(object key);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Add(object key, object value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Clear();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_IsReadOnly();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract IDictionaryEnumerator GetEnumerator();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void Remove(object key);

}

public interface IDictionaryEnumerator : IEnumerator // TypeDefIndex: 1400
{	// Properties
	public abstract object Key { get; }
	public abstract object Value { get; }
	public abstract DictionaryEntry Entry { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_Key();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object get_Value();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract DictionaryEntry get_Entry();

}

public interface IEnumerable // TypeDefIndex: 1401
{	// Methods

	[DispIdAttribute] // RVA: 0xE7FB0 Offset: 0xE73B0 VA: 0x1800E7FB0
	// RVA: -1 Offset: -1 Slot: 0
	public abstract IEnumerator GetEnumerator();

}

public interface IEnumerator // TypeDefIndex: 1402
{	// Properties
	public abstract object Current { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool MoveNext();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object get_Current();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Reset();

}

public interface IEqualityComparer // TypeDefIndex: 1403
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Equals(object x, object y);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int GetHashCode(object obj);

}

public interface IHashCodeProvider // TypeDefIndex: 1404
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int GetHashCode(object obj);

}

public interface IList : ICollection, IEnumerable // TypeDefIndex: 1405
{	// Properties
	public abstract object Item { get; set; }
	public abstract bool IsReadOnly { get; }
	public abstract bool IsFixedSize { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_Item(int index);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Item(int index, object value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int Add(object value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool Contains(object value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Clear();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsReadOnly();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_IsFixedSize();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int IndexOf(object value);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Insert(int index, object value);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void Remove(object value);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void RemoveAt(int index);

}

public interface IStructuralComparable // TypeDefIndex: 1406
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int CompareTo(object other, IComparer comparer);

}

public interface IStructuralEquatable // TypeDefIndex: 1407
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Equals(object other, IEqualityComparer comparer);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int GetHashCode(IEqualityComparer comparer);

}

public interface ICollection<T> : IEnumerable<T>, IEnumerable // TypeDefIndex: 1478
{	// Properties
	public abstract int Count { get; }
	public abstract bool IsReadOnly { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_Count();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ICollection<object>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_IsReadOnly();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ICollection<object>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Add(T item);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ICollection<object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Clear();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ICollection<object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool Contains(T item);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ICollection<object>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void CopyTo(T[] array, int arrayIndex);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ICollection<object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool Remove(T item);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ICollection<object>.Remove
	*/

}

public interface IComparer<T> // TypeDefIndex: 1479
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int Compare(T x, T y);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IComparer<object>.Compare
	*/

}

public interface IDictionary<TKey, TValue> : ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable // TypeDefIndex: 1480
{	// Properties
	public abstract TValue Item { get; set; }
	public abstract ICollection<TKey> Keys { get; }
	public abstract ICollection<TValue> Values { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TValue get_Item(TKey key);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDictionary<object, object>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Item(TKey key, TValue value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDictionary<object, object>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract ICollection<TKey> get_Keys();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDictionary<object, object>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public abstract ICollection<TValue> get_Values();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDictionary<object, object>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool ContainsKey(TKey key);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDictionary<object, object>.ContainsKey
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Add(TKey key, TValue value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDictionary<object, object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool Remove(TKey key);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDictionary<object, object>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool TryGetValue(TKey key, out TValue value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDictionary<object, object>.TryGetValue
	*/

}

public interface IEnumerable<T> : IEnumerable // TypeDefIndex: 1481
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IEnumerator<T> GetEnumerator();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IEnumerable<object>.GetEnumerator
	*/

}

public interface IEnumerator<T> : IDisposable, IEnumerator // TypeDefIndex: 1482
{	// Properties
	public abstract T Current { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T get_Current();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IEnumerator<object>.get_Current
	*/

}

public interface IEqualityComparer<T> // TypeDefIndex: 1483
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Equals(T x, T y);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IEqualityComparer<object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int GetHashCode(T obj);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IEqualityComparer<object>.GetHashCode
	*/

}

public interface IList<T> : ICollection<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 1484
{	// Properties
	public abstract T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T get_Item(int index);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IList<object>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Item(int index, T value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IList<object>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int IndexOf(T item);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IList<object>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Insert(int index, T item);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IList<object>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void RemoveAt(int index);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IList<object>.RemoveAt
	*/

}

public interface IReadOnlyCollection<T> : IEnumerable<T>, IEnumerable // TypeDefIndex: 1485
{	// Properties
	public abstract int Count { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_Count();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyCollection<object>.get_Count
	*/

}

public interface IReadOnlyDictionary<TKey, TValue> : IReadOnlyCollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable // TypeDefIndex: 1486
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool TryGetValue(TKey key, out TValue value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyDictionary<object, object>.TryGetValue
	*/

}

public interface IReadOnlyList<T> : IReadOnlyCollection<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 1487
{	// Properties
	public abstract T Item { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T get_Item(int index);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyList<object>.get_Item
	*/

}

internal sealed class UInt16TypeInfo : TraceLoggingTypeInfo<ushort> // TypeDefIndex: 1536
{	// Methods

	// RVA: 0x10EAD40 Offset: 0x10E9340 VA: 0x1810EAD40 Slot: 4
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

	// RVA: 0x10EACE0 Offset: 0x10E92E0 VA: 0x1810EACE0 Slot: 7
	public override void WriteData(TraceLoggingDataCollector collector, ref ushort value) { }

	// RVA: 0x10EADD0 Offset: 0x10E93D0 VA: 0x1810EADD0
	public void .ctor() { }

}

internal sealed class UInt32TypeInfo : TraceLoggingTypeInfo<uint> // TypeDefIndex: 1538
{	// Methods

	// RVA: 0x10EAFC0 Offset: 0x10E95C0 VA: 0x1810EAFC0 Slot: 4
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

	// RVA: 0x10EAF60 Offset: 0x10E9560 VA: 0x1810EAF60 Slot: 7
	public override void WriteData(TraceLoggingDataCollector collector, ref uint value) { }

	// RVA: 0x10EB050 Offset: 0x10E9650 VA: 0x1810EB050
	public void .ctor() { }

}

internal sealed class UInt64TypeInfo : TraceLoggingTypeInfo<ulong> // TypeDefIndex: 1540
{	// Methods

	// RVA: 0x10EB290 Offset: 0x10E9890 VA: 0x1810EB290 Slot: 4
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

	// RVA: 0x10EB230 Offset: 0x10E9830 VA: 0x1810EB230 Slot: 7
	public override void WriteData(TraceLoggingDataCollector collector, ref ulong value) { }

	// RVA: 0x10EB370 Offset: 0x10E9970 VA: 0x1810EB370
	public void .ctor() { }

}

internal sealed class UIntPtrTypeInfo : TraceLoggingTypeInfo<UIntPtr> // TypeDefIndex: 1542
{	// Methods

	// RVA: 0x10EB650 Offset: 0x10E9C50 VA: 0x1810EB650 Slot: 4
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

	// RVA: 0x10EB5C0 Offset: 0x10E9BC0 VA: 0x1810EB5C0 Slot: 7
	public override void WriteData(TraceLoggingDataCollector collector, ref UIntPtr value) { }

	// RVA: 0x10EB760 Offset: 0x10E9D60 VA: 0x1810EB760
	public void .ctor() { }

}

internal sealed class UInt16ArrayTypeInfo : TraceLoggingTypeInfo<ushort[]> // TypeDefIndex: 1550
{	// Methods

	// RVA: 0x10EAC10 Offset: 0x10E9210 VA: 0x1810EAC10 Slot: 4
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

	// RVA: 0x10EAB90 Offset: 0x10E9190 VA: 0x1810EAB90 Slot: 7
	public override void WriteData(TraceLoggingDataCollector collector, ref ushort[] value) { }

	// RVA: 0x10EACA0 Offset: 0x10E92A0 VA: 0x1810EACA0
	public void .ctor() { }

}

internal sealed class UInt32ArrayTypeInfo : TraceLoggingTypeInfo<uint[]> // TypeDefIndex: 1552
{	// Methods

	// RVA: 0x10EAE90 Offset: 0x10E9490 VA: 0x1810EAE90 Slot: 4
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

	// RVA: 0x10EAE10 Offset: 0x10E9410 VA: 0x1810EAE10 Slot: 7
	public override void WriteData(TraceLoggingDataCollector collector, ref uint[] value) { }

	// RVA: 0x10EAF20 Offset: 0x10E9520 VA: 0x1810EAF20
	public void .ctor() { }

}

internal sealed class UInt64ArrayTypeInfo : TraceLoggingTypeInfo<ulong[]> // TypeDefIndex: 1554
{	// Methods

	// RVA: 0x10EB110 Offset: 0x10E9710 VA: 0x1810EB110 Slot: 4
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

	// RVA: 0x10EB090 Offset: 0x10E9690 VA: 0x1810EB090 Slot: 7
	public override void WriteData(TraceLoggingDataCollector collector, ref ulong[] value) { }

	// RVA: 0x10EB1F0 Offset: 0x10E97F0 VA: 0x1810EB1F0
	public void .ctor() { }

}

internal sealed class UIntPtrArrayTypeInfo : TraceLoggingTypeInfo<UIntPtr[]> // TypeDefIndex: 1556
{	// Methods

	// RVA: 0x10EB470 Offset: 0x10E9A70 VA: 0x1810EB470 Slot: 4
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

	// RVA: 0x10EB3B0 Offset: 0x10E99B0 VA: 0x1810EB3B0 Slot: 7
	public override void WriteData(TraceLoggingDataCollector collector, ref UIntPtr[] value) { }

	// RVA: 0x10EB580 Offset: 0x10E9B80 VA: 0x1810EB580
	public void .ctor() { }

}

public interface ICertificateValidator // TypeDefIndex: 1738
{	// Properties
	public abstract MonoTlsSettings Settings { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract MonoTlsSettings get_Settings();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool SelectClientCertificate(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers, out X509Certificate clientCertificate);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract ValidationResult ValidateCertificate(string targetHost, bool serverMode, X509CertificateCollection certificates);

}

internal interface ICertificateValidator2 : ICertificateValidator // TypeDefIndex: 1739
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ValidationResult ValidateCertificate(string targetHost, bool serverMode, X509Certificate leaf, X509Chain chain);

}

public interface IMonoSslStream : IDisposable // TypeDefIndex: 1742
{	// Properties
	public abstract bool IsAuthenticated { get; }
	public abstract bool CanRead { get; }
	public abstract bool CanWrite { get; }
	public abstract long Length { get; }
	public abstract long Position { get; }
	public abstract AuthenticatedStream AuthenticatedStream { get; }
	public abstract int ReadTimeout { get; }
	public abstract int WriteTimeout { get; }
	public abstract X509Certificate InternalLocalCertificate { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IAsyncResult BeginAuthenticateAsServer(X509Certificate serverCertificate, bool clientCertificateRequired, SslProtocols enabledSslProtocols, bool checkCertificateRevocation, AsyncCallback asyncCallback, object asyncState);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void EndAuthenticateAsServer(IAsyncResult asyncResult);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int Read(byte[] buffer, int offset, int count);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Write(byte[] buffer, int offset, int count);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int EndRead(IAsyncResult asyncResult);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void EndWrite(IAsyncResult asyncResult);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool get_IsAuthenticated();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool get_CanRead();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool get_CanWrite();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract long get_Length();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract long get_Position();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void SetLength(long value);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract AuthenticatedStream get_AuthenticatedStream();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract int get_ReadTimeout();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract int get_WriteTimeout();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract X509Certificate get_InternalLocalCertificate();

}

internal interface IDtdInfo // TypeDefIndex: 1844
{	// Properties
	public abstract XmlQualifiedName Name { get; }
	public abstract string InternalDtdSubset { get; }
	public abstract bool HasDefaultAttributes { get; }
	public abstract bool HasNonCDataAttributes { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract XmlQualifiedName get_Name();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_InternalDtdSubset();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_HasDefaultAttributes();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool get_HasNonCDataAttributes();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IDtdAttributeListInfo LookupAttributeList(string prefix, string localName);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IDtdEntityInfo LookupEntity(string name);

}

internal interface IDtdAttributeListInfo // TypeDefIndex: 1845
{	// Properties
	public abstract bool HasNonCDataAttributes { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_HasNonCDataAttributes();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IDtdAttributeInfo LookupAttribute(string prefix, string localName);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IEnumerable<IDtdDefaultAttributeInfo> LookupDefaultAttributes();

}

internal interface IDtdAttributeInfo // TypeDefIndex: 1846
{	// Properties
	public abstract string Prefix { get; }
	public abstract string LocalName { get; }
	public abstract int LineNumber { get; }
	public abstract int LinePosition { get; }
	public abstract bool IsNonCDataType { get; }
	public abstract bool IsDeclaredInExternal { get; }
	public abstract bool IsXmlAttribute { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Prefix();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_LocalName();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_LineNumber();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int get_LinePosition();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_IsNonCDataType();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsDeclaredInExternal();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_IsXmlAttribute();

}

internal interface IDtdDefaultAttributeInfo : IDtdAttributeInfo // TypeDefIndex: 1847
{	// Properties
	public abstract string DefaultValueExpanded { get; }
	public abstract object DefaultValueTyped { get; }
	public abstract int ValueLineNumber { get; }
	public abstract int ValueLinePosition { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_DefaultValueExpanded();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object get_DefaultValueTyped();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_ValueLineNumber();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int get_ValueLinePosition();

}

internal interface IDtdEntityInfo // TypeDefIndex: 1848
{	// Properties
	public abstract string Name { get; }
	public abstract bool IsExternal { get; }
	public abstract bool IsDeclaredInExternal { get; }
	public abstract bool IsUnparsedEntity { get; }
	public abstract bool IsParameterEntity { get; }
	public abstract string BaseUriString { get; }
	public abstract string DeclaredUriString { get; }
	public abstract string SystemId { get; }
	public abstract string PublicId { get; }
	public abstract string Text { get; }
	public abstract int LineNumber { get; }
	public abstract int LinePosition { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_IsExternal();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_IsDeclaredInExternal();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool get_IsUnparsedEntity();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_IsParameterEntity();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_BaseUriString();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string get_DeclaredUriString();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string get_SystemId();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string get_PublicId();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract string get_Text();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int get_LineNumber();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int get_LinePosition();

}

internal interface IDtdParser // TypeDefIndex: 1849
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IDtdInfo ParseInternalDtd(IDtdParserAdapter adapter, bool saveInternalSubset);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IDtdInfo ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter);

}

internal interface IDtdParserAdapter // TypeDefIndex: 1850
{	// Properties
	public abstract XmlNameTable NameTable { get; }
	public abstract IXmlNamespaceResolver NamespaceResolver { get; }
	public abstract Uri BaseUri { get; }
	public abstract char[] ParsingBuffer { get; }
	public abstract int ParsingBufferLength { get; }
	public abstract int CurrentPosition { get; set; }
	public abstract int LineNo { get; }
	public abstract int LineStartPosition { get; }
	public abstract bool IsEof { get; }
	public abstract int EntityStackLength { get; }
	public abstract bool IsEntityEolNormalized { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract XmlNameTable get_NameTable();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IXmlNamespaceResolver get_NamespaceResolver();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Uri get_BaseUri();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract char[] get_ParsingBuffer();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_ParsingBufferLength();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int get_CurrentPosition();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void set_CurrentPosition(int value);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int get_LineNo();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int get_LineStartPosition();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool get_IsEof();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int get_EntityStackLength();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool get_IsEntityEolNormalized();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract int ReadData();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void OnNewLine(int pos);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract int ParseNumericCharRef(StringBuilder internalSubsetBuilder);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract int ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void ParsePI(StringBuilder sb);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void ParseComment(StringBuilder sb);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract bool PushEntity(IDtdEntityInfo entity, out int entityId);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract bool PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract bool PushExternalSubset(string systemId, string publicId);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void PushInternalDtd(string baseUri, string internalDtd);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract void OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void Throw(Exception e);

}

internal interface IDtdParserAdapterWithValidation : IDtdParserAdapter // TypeDefIndex: 1851
{	// Properties
	public abstract bool DtdValidation { get; }
	public abstract IValidationEventHandling ValidationEventHandling { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_DtdValidation();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IValidationEventHandling get_ValidationEventHandling();

}

internal interface IDtdParserAdapterV1 : IDtdParserAdapterWithValidation, IDtdParserAdapter // TypeDefIndex: 1852
{	// Properties
	public abstract bool V1CompatibilityMode { get; }
	public abstract bool Normalization { get; }
	public abstract bool Namespaces { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_V1CompatibilityMode();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_Normalization();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_Namespaces();

}

internal interface IValidationEventHandling // TypeDefIndex: 1854
{	// Properties
	public abstract object EventHandler { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_EventHandler();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SendEvent(Exception exception, XmlSeverityType severity);

}

public interface IXmlLineInfo // TypeDefIndex: 1985
{	// Properties
	public abstract int LineNumber { get; }
	public abstract int LinePosition { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool HasLineInfo();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_LineNumber();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_LinePosition();

}

public interface IXmlNamespaceResolver // TypeDefIndex: 1988
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string LookupNamespace(string prefix);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string LookupPrefix(string namespaceName);

}

public interface IXmlSerializable // TypeDefIndex: 2054
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract XmlSchema GetSchema();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void ReadXml(XmlReader reader);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void WriteXml(XmlWriter writer);

}

public interface IXmlTextParser // TypeDefIndex: 2055
{	// Properties
	public abstract bool Normalized { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_Normalized();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Normalized(bool value);

}

public interface IXmlSchemaInfo // TypeDefIndex: 2258
{	// Properties
	public abstract XmlSchemaValidity Validity { get; }
	public abstract bool IsDefault { get; }
	public abstract bool IsNil { get; }
	public abstract XmlSchemaSimpleType MemberType { get; }
	public abstract XmlSchemaType SchemaType { get; }
	public abstract XmlSchemaElement SchemaElement { get; }
	public abstract XmlSchemaAttribute SchemaAttribute { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract XmlSchemaValidity get_Validity();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_IsDefault();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_IsNil();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract XmlSchemaSimpleType get_MemberType();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract XmlSchemaType get_SchemaType();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract XmlSchemaElement get_SchemaElement();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract XmlSchemaAttribute get_SchemaAttribute();

}

public interface IChangeTracking // TypeDefIndex: 2711
{
// Namespace: System.ComponentModel
public interface IBindingList : IList, ICollection, IEnumerable // TypeDefIndex: 2710

// Namespace: System.ComponentModel
public interface IChangeTracking // TypeDefIndex: 2711
	// Properties
	public abstract bool IsChanged { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsChanged();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void AcceptChanges();

}

public interface IComponent : IDisposable // TypeDefIndex: 2712
{	// Properties
	public abstract ISite Site { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ISite get_Site();

}

public interface IContainer : IDisposable // TypeDefIndex: 2713
{	// Properties
	public abstract ComponentCollection Components { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ComponentCollection get_Components();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Remove(IComponent component);

}

public interface ICustomTypeDescriptor // TypeDefIndex: 2714
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract AttributeCollection GetAttributes();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract TypeConverter GetConverter();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract PropertyDescriptorCollection GetProperties();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract PropertyDescriptorCollection GetProperties(Attribute[] attributes);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract object GetPropertyOwner(PropertyDescriptor pd);

}

public interface IExtenderProvider // TypeDefIndex: 2715
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool CanExtend(object extendee);

}

public interface IRevertibleChangeTracking : IChangeTracking // TypeDefIndex: 2716
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void RejectChanges();

}

public interface ISite : IServiceProvider // TypeDefIndex: 2717
{	// Properties
	public abstract IContainer Container { get; }
	public abstract bool DesignMode { get; }
	public abstract string Name { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IContainer get_Container();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_DesignMode();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_Name();

}

public interface ISynchronizeInvoke // TypeDefIndex: 2718
{	// Properties
	public abstract bool InvokeRequired { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_InvokeRequired();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IAsyncResult BeginInvoke(Delegate method, object[] args);

}

public class UInt16Converter : BaseNumberConverter // TypeDefIndex: 2769
{
// Namespace: 
private sealed class TypeDescriptor.TypeDescriptorInterface // TypeDefIndex: 2768

// Namespace: System.ComponentModel
public class UInt16Converter : BaseNumberConverter // TypeDefIndex: 2769
	// Properties
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0x173F210 Offset: 0x173D810 VA: 0x18173F210 Slot: 17
	internal override Type get_TargetType() { }

	// RVA: 0x173F100 Offset: 0x173D700 VA: 0x18173F100 Slot: 18
	internal override object FromString(string value, int radix) { }

	// RVA: 0x173F0A0 Offset: 0x173D6A0 VA: 0x18173F0A0 Slot: 19
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x173F180 Offset: 0x173D780 VA: 0x18173F180 Slot: 21
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

}

public class UInt32Converter : BaseNumberConverter // TypeDefIndex: 2770
{	// Properties
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0x173F3D0 Offset: 0x173D9D0 VA: 0x18173F3D0 Slot: 17
	internal override Type get_TargetType() { }

	// RVA: 0x173F2D0 Offset: 0x173D8D0 VA: 0x18173F2D0 Slot: 18
	internal override object FromString(string value, int radix) { }

	// RVA: 0x173F270 Offset: 0x173D870 VA: 0x18173F270 Slot: 19
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x173F350 Offset: 0x173D950 VA: 0x18173F350 Slot: 21
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

}

public class UInt64Converter : BaseNumberConverter // TypeDefIndex: 2771
{	// Properties
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0x173F5A0 Offset: 0x173DBA0 VA: 0x18173F5A0 Slot: 17
	internal override Type get_TargetType() { }

	// RVA: 0x173F430 Offset: 0x173DA30 VA: 0x18173F430 Slot: 18
	internal override object FromString(string value, int radix) { }

	// RVA: 0x173F4B0 Offset: 0x173DAB0 VA: 0x18173F4B0 Slot: 19
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x173F510 Offset: 0x173DB10 VA: 0x18173F510 Slot: 21
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

}

public interface IComponentChangeService // TypeDefIndex: 2780
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnComponentChanged(object component, MemberDescriptor member, object oldValue, object newValue);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnComponentChanging(object component, MemberDescriptor member);

}

public interface IDesignerHost : IServiceProvider // TypeDefIndex: 2782
{
// Namespace: System.ComponentModel.Design
[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
public interface IDesignerHost : IServiceProvider // TypeDefIndex: 2782
	// Properties
	public abstract IComponent RootComponent { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IComponent get_RootComponent();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IDesigner GetDesigner(IComponent component);

}

public interface IDictionaryService // TypeDefIndex: 2783
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object GetValue(object key);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetValue(object key, object value);

}

public interface IExtenderListService // TypeDefIndex: 2784
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IExtenderProvider[] GetExtenderProviders();

}

public interface ITypeDescriptorFilterService // TypeDefIndex: 2786
{
// Namespace: System.ComponentModel.Design
public interface ITypeDescriptorFilterService // TypeDefIndex: 2786
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool FilterAttributes(IComponent component, IDictionary attributes);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool FilterEvents(IComponent component, IDictionary events);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool FilterProperties(IComponent component, IDictionary properties);

}

internal interface IFileWatcher // TypeDefIndex: 2849
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void StartDispatching(FileSystemWatcher fsw);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void StopDispatching(FileSystemWatcher fsw);

}

public interface IAuthenticationModule // TypeDefIndex: 2879
{	// Properties
	public abstract string AuthenticationType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Authorization PreAuthenticate(WebRequest request, ICredentials credentials);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_AuthenticationType();

}

public interface ICertificatePolicy // TypeDefIndex: 2880
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool CheckValidationResult(ServicePoint srvPoint, X509Certificate certificate, WebRequest request, int certificateProblem);

}

public interface ICredentials // TypeDefIndex: 2881
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract NetworkCredential GetCredential(Uri uri, string authType);

}

public interface IWebRequestCreate // TypeDefIndex: 2885
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract WebRequest Create(Uri uri);

}

internal interface ICloseEx // TypeDefIndex: 2918
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void CloseEx(CloseExState closeState);

}

public interface IWebProxy // TypeDefIndex: 2952
{	// Properties
	public abstract ICredentials Credentials { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Uri GetProxy(Uri destination);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool IsBypassed(Uri host);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract ICredentials get_Credentials();

}

internal interface IWebConnectionState // TypeDefIndex: 3013
{	// Properties
	public abstract WebConnectionGroup Group { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract WebConnectionGroup get_Group();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool TrySetBusy();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void SetIdle();

}

public interface IOrderedEnumerable<TElement> : IEnumerable<TElement>, IEnumerable // TypeDefIndex: 3224
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IOrderedEnumerable<TElement> CreateOrderedEnumerable<TKey>(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IOrderedEnumerable<object>.CreateOrderedEnumerable<object>
	*/

}

public interface IGrouping<TKey, TElement> : IEnumerable<TElement>, IEnumerable // TypeDefIndex: 3225
{	// Properties
	public abstract TKey Key { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TKey get_Key();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IGrouping<object, object>.get_Key
	*/

}

public interface IJob // TypeDefIndex: 3298
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Execute();

}

public interface IJobParallelFor // TypeDefIndex: 3302
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Execute(int index);

}

public interface ILogger : ILogHandler // TypeDefIndex: 3456
{	// Properties
	public abstract ILogHandler logHandler { get; }
	public abstract bool logEnabled { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ILogHandler get_logHandler();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_logEnabled();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void set_logEnabled(bool value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Log(LogType logType, object message);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Log(LogType logType, object message, Object context);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void LogFormat(LogType logType, string format, object[] args);

}

public interface ILogHandler // TypeDefIndex: 3457
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void LogFormat(LogType logType, Object context, string format, object[] args);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void LogException(Exception exception, Object context);

}

internal interface IPlayerEditorConnectionNative // TypeDefIndex: 3474
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Initialize();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void DisconnectAll();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void SendMessage(Guid messageId, byte[] data, int playerId);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool TrySendMessage(Guid messageId, byte[] data, int playerId);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Poll();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void RegisterInternal(Guid messageId);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void UnregisterInternal(Guid messageId);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool IsConnected();

}

public interface ISerializationCallbackReceiver // TypeDefIndex: 3548
{
// Namespace: UnityEngine
[AttributeUsageAttribute] // RVA: 0xB8F40 Offset: 0xB8340 VA: 0x1800B8F40
[RequiredByNativeCodeAttribute] // RVA: 0xB8F40 Offset: 0xB8340 VA: 0x1800B8F40
public sealed class PreferBinarySerialization : Attribute // TypeDefIndex: 3547

// Namespace: UnityEngine
[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
public interface ISerializationCallbackReceiver // TypeDefIndex: 3548
	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnBeforeSerialize();

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnAfterDeserialize();

}

public interface IJobParallelForTransform // TypeDefIndex: 3585
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Execute(int index, TransformAccess transform);

}

public interface INotificationReceiver // TypeDefIndex: 3862
{
// Namespace: UnityEngine.Playables
[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
public interface INotificationReceiver // TypeDefIndex: 3862
	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnNotify(Playable origin, INotification notification, object context);

}

public interface IPlayableBehaviour // TypeDefIndex: 3863
{	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnGraphStart(Playable playable);

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnGraphStop(Playable playable);

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnPlayableCreate(Playable playable);

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnPlayableDestroy(Playable playable);

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnBehaviourPlay(Playable playable, FrameData info);

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnBehaviourPause(Playable playable, FrameData info);

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 6
	public abstract void PrepareFrame(Playable playable, FrameData info);

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 7
	public abstract void ProcessFrame(Playable playable, FrameData info, object playerData);

}

public interface IScriptableRuntimeReflectionSystem : IDisposable // TypeDefIndex: 3896
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool TickRealtimeProbes();

}

internal interface ISubsystemDescriptorImpl : ISubsystemDescriptor // TypeDefIndex: 3938
{
// Namespace: UnityEngine
public interface ISubsystemDescriptor // TypeDefIndex: 3937

// Namespace: UnityEngine
internal interface ISubsystemDescriptorImpl : ISubsystemDescriptor // TypeDefIndex: 3938
	// Properties
	public abstract IntPtr ptr { set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void set_ptr(IntPtr value);

}

public struct UICharInfo // TypeDefIndex: 3956
{	// Fields
	public Vector2 cursorPos; // 0x0
	public float charWidth; // 0x8

}

public struct UILineInfo // TypeDefIndex: 3957
{	// Fields
	public int startCharIdx; // 0x0
	public int height; // 0x4
	public float topY; // 0x8
	public float leading; // 0xC

}

public struct UIVertex // TypeDefIndex: 3958
{	// Fields
	public Vector3 position; // 0x0
	public Vector3 normal; // 0xC
	public Vector4 tangent; // 0x18
	public Color32 color; // 0x28
	public Vector2 uv0; // 0x2C
	public Vector2 uv1; // 0x34
	public Vector2 uv2; // 0x3C
	public Vector2 uv3; // 0x44
	private static readonly Color32 s_DefaultColor; // 0x0
	private static readonly Vector4 s_DefaultTangent; // 0x4
	public static UIVertex simpleVert; // 0x14

	// Methods

	// RVA: 0x230D2C0 Offset: 0x230B8C0 VA: 0x18230D2C0
	private static void .cctor() { }

}

public interface IEnlistmentNotification // TypeDefIndex: 3978
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Rollback(Enlistment enlistment);

}

public interface IPromotableSinglePhaseNotification // TypeDefIndex: 3979
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Rollback(SinglePhaseEnlistment singlePhaseEnlistment);

}

internal interface IFilter // TypeDefIndex: 4262
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Invoke(DataRow row, DataRowVersion version);

}

public interface IDataReader : IDisposable, IDataRecord // TypeDefIndex: 4269
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Close();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract DataTable GetSchemaTable();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool Read();

}

public interface IDataRecord // TypeDefIndex: 4270
{	// Properties
	public abstract int FieldCount { get; }
	public abstract object Item { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_FieldCount();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object get_Item(int i);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string GetName(int i);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string GetDataTypeName(int i);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Type GetFieldType(int i);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int GetValues(object[] values);

}

public interface IDbDataAdapter // TypeDefIndex: 4272
{
// Namespace: System.Data
public interface IDbDataAdapter // TypeDefIndex: 4272
	// Properties
	public abstract IDbCommand SelectCommand { get; }
	public abstract IDbCommand InsertCommand { get; set; }
	public abstract IDbCommand UpdateCommand { get; set; }
	public abstract IDbCommand DeleteCommand { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IDbCommand get_SelectCommand();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IDbCommand get_InsertCommand();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void set_InsertCommand(IDbCommand value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IDbCommand get_UpdateCommand();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void set_UpdateCommand(IDbCommand value);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IDbCommand get_DeleteCommand();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void set_DeleteCommand(IDbCommand value);

}

public interface INullable // TypeDefIndex: 4336
{	// Properties
	public abstract bool IsNull { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsNull();

}

internal sealed class UInt16Storage : DataStorage // TypeDefIndex: 4433
{	// Fields
	private static readonly ushort s_defaultValue; // 0x0
	private ushort[] _values; // 0x50

	// Methods

	// RVA: 0x1242F60 Offset: 0x1241560 VA: 0x181242F60
	public void .ctor(DataColumn column) { }

	// RVA: 0x1241EA0 Offset: 0x12404A0 VA: 0x181241EA0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1242740 Offset: 0x1240D40 VA: 0x181242740 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1242620 Offset: 0x1240C20 VA: 0x181242620 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x12428A0 Offset: 0x1240EA0 VA: 0x1812428A0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1242B10 Offset: 0x1241110 VA: 0x181242B10 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1242BD0 Offset: 0x12411D0 VA: 0x181242BD0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1242E10 Offset: 0x1241410 VA: 0x181242E10 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1242C90 Offset: 0x1241290 VA: 0x181242C90 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1242980 Offset: 0x1240F80 VA: 0x181242980 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1242820 Offset: 0x1240E20 VA: 0x181242820 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1242B90 Offset: 0x1241190 VA: 0x181242B90 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x12429F0 Offset: 0x1240FF0 VA: 0x1812429F0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1242D70 Offset: 0x1241370 VA: 0x181242D70 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

internal sealed class UInt32Storage : DataStorage // TypeDefIndex: 4434
{	// Fields
	private static readonly uint s_defaultValue; // 0x0
	private uint[] _values; // 0x50

	// Methods

	// RVA: 0x12440D0 Offset: 0x12426D0 VA: 0x1812440D0
	public void .ctor(DataColumn column) { }

	// RVA: 0x1243050 Offset: 0x1241650 VA: 0x181243050 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x12438D0 Offset: 0x1241ED0 VA: 0x1812438D0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x12437B0 Offset: 0x1241DB0 VA: 0x1812437B0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1243A30 Offset: 0x1242030 VA: 0x181243A30 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1243C90 Offset: 0x1242290 VA: 0x181243C90 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1243D50 Offset: 0x1242350 VA: 0x181243D50 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1243F90 Offset: 0x1242590 VA: 0x181243F90 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1243E10 Offset: 0x1242410 VA: 0x181243E10 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1243B00 Offset: 0x1242100 VA: 0x181243B00 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x12439B0 Offset: 0x1241FB0 VA: 0x1812439B0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1243D10 Offset: 0x1242310 VA: 0x181243D10 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1243B70 Offset: 0x1242170 VA: 0x181243B70 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1243EF0 Offset: 0x12424F0 VA: 0x181243EF0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

internal sealed class UInt64Storage : DataStorage // TypeDefIndex: 4435
{	// Fields
	private static readonly ulong s_defaultValue; // 0x0
	private ulong[] _values; // 0x50

	// Methods

	// RVA: 0x1245310 Offset: 0x1243910 VA: 0x181245310
	public void .ctor(DataColumn column) { }

	// RVA: 0x12441C0 Offset: 0x12427C0 VA: 0x1812441C0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1244AA0 Offset: 0x12430A0 VA: 0x181244AA0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1244980 Offset: 0x1242F80 VA: 0x181244980 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1244C50 Offset: 0x1243250 VA: 0x181244C50 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1244EC0 Offset: 0x12434C0 VA: 0x181244EC0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1244F80 Offset: 0x1243580 VA: 0x181244F80 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x12451C0 Offset: 0x12437C0 VA: 0x1812451C0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1245040 Offset: 0x1243640 VA: 0x181245040 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1244D30 Offset: 0x1243330 VA: 0x181244D30 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1244BD0 Offset: 0x12431D0 VA: 0x181244BD0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1244F40 Offset: 0x1243540 VA: 0x181244F40 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1244DA0 Offset: 0x12433A0 VA: 0x181244DA0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1245120 Offset: 0x1243720 VA: 0x181245120 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

public interface IJobParticleSystem // TypeDefIndex: 4546
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Execute(ParticleSystemJobData jobData);

}

public interface IFocusRing // TypeDefIndex: 4588
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction);

}

public interface ITransform // TypeDefIndex: 4593
{	// Properties
	public abstract Matrix4x4 matrix { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Matrix4x4 get_matrix();

}

public interface IPanel : IDisposable // TypeDefIndex: 4599
{	// Properties
	public abstract VisualElement visualTree { get; }
	public abstract EventDispatcher dispatcher { get; }
	public abstract ContextType contextType { get; }
	public abstract FocusController focusController { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract VisualElement get_visualTree();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract EventDispatcher get_dispatcher();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract ContextType get_contextType();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract FocusController get_focusController();

}

internal static class UIElementsRuntimeUtility // TypeDefIndex: 4608
{	// Fields
	private static EventDispatcher s_RuntimeDispatcher; // 0x0
	private static bool s_RegisteredPlayerloopCallback; // 0x8
	private static List<Panel> panelsIteration; // 0x10
	internal static readonly string s_RepaintProfilerMarkerName; // 0x18
	private static readonly ProfilerMarker s_RepaintProfilerMarker; // 0x20

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEBD2C0 Offset: 0xEBB8C0 VA: 0x180EBD2C0
	public static void RepaintOverlayPanels() { }

	// RVA: 0xEBD720 Offset: 0xEBBD20 VA: 0x180EBD720
	private static void .cctor() { }

}

internal static class UIElementsUtility // TypeDefIndex: 4609
{	// Fields
	private static Stack<IMGUIContainer> s_ContainerStack; // 0x0
	private static Dictionary<int, Panel> s_UIElementsCache; // 0x8
	private static Event s_EventInstance; // 0x10
	internal static Color editorPlayModeTintColor; // 0x18
	internal static readonly string s_RepaintProfilerMarkerName; // 0x28
	internal static readonly string s_EventProfilerMarkerName; // 0x30
	private static readonly ProfilerMarker s_RepaintProfilerMarker; // 0x38
	private static readonly ProfilerMarker s_EventProfilerMarker; // 0x40

	// Methods

	// RVA: 0xEBF1B0 Offset: 0xEBD7B0 VA: 0x180EBF1B0
	private static void .cctor() { }

	// RVA: 0xEBED50 Offset: 0xEBD350 VA: 0x180EBED50
	internal static void MakeCurrentIMGUIContainerDirty() { }

	// RVA: 0xEBEFD0 Offset: 0xEBD5D0 VA: 0x180EBEFD0
	private static void TakeCapture() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void ReleaseCapture() { }

	// RVA: 0xEBEE20 Offset: 0xEBD420 VA: 0x180EBEE20
	private static bool ProcessEvent(int instanceID, IntPtr nativeEventPtr) { }

	// RVA: 0xEBEF50 Offset: 0xEBD550 VA: 0x180EBEF50
	public static void RemoveCachedPanel(int instanceID) { }

	// RVA: 0xEBDAA0 Offset: 0xEBC0A0 VA: 0x180EBDAA0
	private static void CleanupRoots() { }

	// RVA: 0xEBE830 Offset: 0xEBCE30 VA: 0x180EBE830
	private static bool EndContainerGUIFromException(Exception exception) { }

	// RVA: 0xEBD820 Offset: 0xEBBE20 VA: 0x180EBD820
	internal static void BeginContainerGUI(GUILayoutUtility.LayoutCache cache, Event evt, IMGUIContainer container) { }

	// RVA: 0xEBE8F0 Offset: 0xEBCEF0 VA: 0x180EBE8F0
	internal static void EndContainerGUI(Event evt, Rect layoutSize) { }

	// RVA: 0xEBE220 Offset: 0xEBC820 VA: 0x180EBE220
	internal static EventBase CreateEvent(Event systemEvent) { }

	// RVA: 0xEBDB40 Offset: 0xEBC140 VA: 0x180EBDB40
	internal static EventBase CreateEvent(Event systemEvent, EventType eventType) { }

	// RVA: 0xEBE2A0 Offset: 0xEBC8A0 VA: 0x180EBE2A0
	private static bool DoDispatch(BaseVisualElementPanel panel) { }

	// RVA: 0xEBEB30 Offset: 0xEBD130 VA: 0x180EBEB30
	internal static void GetAllPanels(List<Panel> panels, ContextType contextType) { }

	// RVA: 0xEBECA0 Offset: 0xEBD2A0 VA: 0x180EBECA0
	internal static Dictionary.Enumerator<int, Panel> GetPanelsIterator() { }

}

internal interface IVisualTreeUpdater : IDisposable // TypeDefIndex: 4620
{	// Properties
	public abstract ProfilerMarker profilerMarker { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ProfilerMarker get_profilerMarker();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Update();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType);

}

public interface IEventHandler // TypeDefIndex: 4649
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SendEvent(EventBase e);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void HandleEvent(EventBase evt);

}

internal interface IEventDispatchingStrategy // TypeDefIndex: 4657
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool CanDispatchEvent(EventBase evt);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void DispatchEvent(EventBase evt, IPanel panel);

}

public interface IMouseEvent // TypeDefIndex: 4668
{	// Properties
	public abstract EventModifiers modifiers { get; }
	public abstract Vector2 mousePosition { get; }
	public abstract Vector2 mouseDelta { get; }
	public abstract int clickCount { get; }
	public abstract int button { get; }
	public abstract int pressedButtons { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract EventModifiers get_modifiers();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Vector2 get_mousePosition();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Vector2 get_mouseDelta();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int get_clickCount();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_button();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int get_pressedButtons();

}

internal interface IMouseEventInternal // TypeDefIndex: 4669
{	// Properties
	public abstract bool triggeredByOS { get; set; }
	public abstract bool recomputeTopElementUnderMouse { get; set; }
	public abstract IPointerEvent sourcePointerEvent { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_triggeredByOS();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_triggeredByOS(bool value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_recomputeTopElementUnderMouse();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_recomputeTopElementUnderMouse(bool value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IPointerEvent get_sourcePointerEvent();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void set_sourcePointerEvent(IPointerEvent value);

}

public interface IPointerEvent // TypeDefIndex: 4689
{	// Properties
	public abstract int pointerId { get; }
	public abstract string pointerType { get; }
	public abstract bool isPrimary { get; }
	public abstract int button { get; }
	public abstract int pressedButtons { get; }
	public abstract Vector3 position { get; }
	public abstract Vector3 localPosition { get; }
	public abstract Vector3 deltaPosition { get; }
	public abstract float deltaTime { get; }
	public abstract int clickCount { get; }
	public abstract float pressure { get; }
	public abstract float tangentialPressure { get; }
	public abstract float altitudeAngle { get; }
	public abstract float azimuthAngle { get; }
	public abstract float twist { get; }
	public abstract Vector2 radius { get; }
	public abstract Vector2 radiusVariance { get; }
	public abstract EventModifiers modifiers { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_pointerId();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_pointerType();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_isPrimary();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int get_button();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_pressedButtons();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Vector3 get_position();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract Vector3 get_localPosition();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract Vector3 get_deltaPosition();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract float get_deltaTime();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract int get_clickCount();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract float get_pressure();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract float get_tangentialPressure();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract float get_altitudeAngle();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract float get_azimuthAngle();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract float get_twist();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract Vector2 get_radius();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract Vector2 get_radiusVariance();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract EventModifiers get_modifiers();

}

internal interface IPointerEventInternal // TypeDefIndex: 4690
{	// Properties
	public abstract bool triggeredByOS { get; set; }
	public abstract bool recomputeTopElementUnderPointer { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_triggeredByOS();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_triggeredByOS(bool value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_recomputeTopElementUnderPointer();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_recomputeTopElementUnderPointer(bool value);

}

public interface IResolvedStyle // TypeDefIndex: 4707
{	// Properties
	public abstract Visibility visibility { get; }
	public abstract DisplayStyle display { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Visibility get_visibility();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract DisplayStyle get_display();

}

internal interface IStyleValue<T> // TypeDefIndex: 4716
{	// Properties
	public abstract T value { get; }
	public abstract StyleKeyword keyword { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T get_value();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IStyleValue<object>.get_value
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract StyleKeyword get_keyword();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IStyleValue<object>.get_keyword
	*/

}

public interface ICanvasRaycastFilter // TypeDefIndex: 4730
{
// Namespace: UnityEngine
public interface ICanvasRaycastFilter // TypeDefIndex: 4730
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera);

}

public static class UISystemProfilerApi // TypeDefIndex: 4738
{	// Methods

	// RVA: 0x230AF20 Offset: 0x2309520 VA: 0x18230AF20
	public static void BeginSample(UISystemProfilerApi.SampleType type) { }

	// RVA: 0x230AF60 Offset: 0x2309560 VA: 0x18230AF60
	public static void EndSample(UISystemProfilerApi.SampleType type) { }

	// RVA: 0x230AED0 Offset: 0x23094D0 VA: 0x18230AED0
	public static void AddMarker(string name, Object obj) { }

}

public enum UISystemProfilerApi.SampleType // TypeDefIndex: 4739
{	// Fields
	public int value__; // 0x0
	public const UISystemProfilerApi.SampleType Layout = 0;
	public const UISystemProfilerApi.SampleType Render = 1;

}

public interface IImmutableStack<T> : IEnumerable<T>, IEnumerable // TypeDefIndex: 4797
{	// Properties
	public abstract int Count { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_Count();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IImmutableStack<object>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IImmutableStack<T> Push(T value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IImmutableStack<object>.Push
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IImmutableStack<T> Pop();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IImmutableStack<object>.Pop
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public abstract T Peek();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IImmutableStack<object>.Peek
	*/

}

public interface ILinkedListNode<T> // TypeDefIndex: 4803
{	// Properties
	public abstract T next { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T get_next();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ILinkedListNode<object>.get_next
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_next(T value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ILinkedListNode<object>.set_next
	*/

}

public interface IMinHeapNode<T> // TypeDefIndex: 4805
{	// Properties
	public abstract T child { get; set; }
	public abstract int order { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T get_child();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IMinHeapNode<object>.get_child
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_child(T value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IMinHeapNode<object>.set_child
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_order();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IMinHeapNode<object>.get_order
	*/

}

public interface Pool.IPooled // TypeDefIndex: 4836
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void EnterPool();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void LeavePool();

}

public interface Pool.ICollection // TypeDefIndex: 4837
{	// Properties
	public abstract long ItemsInStack { get; }
	public abstract long ItemsInUse { get; }
	public abstract long ItemsCreated { get; }
	public abstract long ItemsTaken { get; }
	public abstract long ItemsSpilled { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract long get_ItemsInStack();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract long get_ItemsInUse();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract long get_ItemsCreated();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract long get_ItemsTaken();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract long get_ItemsSpilled();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Reset();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Add(object obj);

}

internal interface ISQLiteSchemaExtensions // TypeDefIndex: 4857
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void BuildTempSchema(SqliteConnection cnn);

}

public interface ICanvasElement // TypeDefIndex: 4909
{	// Properties
	public abstract Transform transform { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Rebuild(CanvasUpdate executing);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Transform get_transform();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void LayoutComplete();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void GraphicUpdateComplete();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool IsDestroyed();

}

public interface IClipper // TypeDefIndex: 4914
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void PerformClipping();

}

public interface IClippable // TypeDefIndex: 4915
{	// Properties
	public abstract GameObject gameObject { get; }
	public abstract RectTransform rectTransform { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract GameObject get_gameObject();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void RecalculateClipping();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract RectTransform get_rectTransform();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Cull(Rect clipRect, bool validRect);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void SetClipRect(Rect value, bool validRect);

}

public interface DefaultControls.IFactoryControls // TypeDefIndex: 4918
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract GameObject CreateGameObject(string name, Type[] components);

}

internal interface IGraphicEnabledDisabled // TypeDefIndex: 4935
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnSiblingGraphicEnabledDisabled();

}

public interface IMask // TypeDefIndex: 4936
{	// Properties
	public abstract RectTransform rectTransform { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Enabled();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract RectTransform get_rectTransform();

}

public interface IMaskable // TypeDefIndex: 4937
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void RecalculateMasking();

}

public interface ILayoutElement // TypeDefIndex: 4971
{	// Properties
	public abstract float minWidth { get; }
	public abstract float preferredWidth { get; }
	public abstract float flexibleWidth { get; }
	public abstract float minHeight { get; }
	public abstract float preferredHeight { get; }
	public abstract float flexibleHeight { get; }
	public abstract int layoutPriority { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void CalculateLayoutInputHorizontal();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void CalculateLayoutInputVertical();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract float get_minWidth();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract float get_preferredWidth();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract float get_flexibleWidth();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract float get_minHeight();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract float get_preferredHeight();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract float get_flexibleHeight();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int get_layoutPriority();

}

public interface ILayoutController // TypeDefIndex: 4972
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetLayoutHorizontal();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetLayoutVertical();

}

public interface ILayoutIgnorer // TypeDefIndex: 4975
{
// Namespace: UnityEngine.UI
public interface ILayoutSelfController : ILayoutController // TypeDefIndex: 4974

// Namespace: UnityEngine.UI
public interface ILayoutIgnorer // TypeDefIndex: 4975
	// Properties
	public abstract bool ignoreLayout { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_ignoreLayout();

}

public interface IMaterialModifier // TypeDefIndex: 4988
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Material GetModifiedMaterial(Material baseMaterial);

}

public interface IVertexModifier // TypeDefIndex: 5032
{	// Methods

	[EditorBrowsableAttribute] // RVA: 0x7FDF0 Offset: 0x7F1F0 VA: 0x18007FDF0
	[ObsoleteAttribute] // RVA: 0x7FDF0 Offset: 0x7F1F0 VA: 0x18007FDF0
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ModifyVertices(List<UIVertex> verts);

}

public interface IMeshModifier // TypeDefIndex: 5033
{	// Methods

	[ObsoleteAttribute] // RVA: 0x7FF60 Offset: 0x7F360 VA: 0x18007FF60
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ModifyMesh(Mesh mesh);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void ModifyMesh(VertexHelper verts);

}

internal interface ITweenValue // TypeDefIndex: 5038
{	// Properties
	public abstract bool ignoreTimeScale { get; }
	public abstract float duration { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void TweenValue(float floatPercentage);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_ignoreTimeScale();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract float get_duration();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool ValidTarget();

}

public interface IPointerEnterHandler : IEventSystemHandler // TypeDefIndex: 5054
{
// Namespace: UnityEngine.EventSystems
public interface IPointerEnterHandler : IEventSystemHandler // TypeDefIndex: 5054
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnPointerEnter(PointerEventData eventData);

}

public interface IPointerExitHandler : IEventSystemHandler // TypeDefIndex: 5055
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnPointerExit(PointerEventData eventData);

}

public interface IPointerDownHandler : IEventSystemHandler // TypeDefIndex: 5056
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnPointerDown(PointerEventData eventData);

}

public interface IPointerUpHandler : IEventSystemHandler // TypeDefIndex: 5057
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnPointerUp(PointerEventData eventData);

}

public interface IPointerClickHandler : IEventSystemHandler // TypeDefIndex: 5058
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnPointerClick(PointerEventData eventData);

}

public interface IBeginDragHandler : IEventSystemHandler // TypeDefIndex: 5059
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnBeginDrag(PointerEventData eventData);

}

public interface IInitializePotentialDragHandler : IEventSystemHandler // TypeDefIndex: 5060
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnInitializePotentialDrag(PointerEventData eventData);

}

public interface IDragHandler : IEventSystemHandler // TypeDefIndex: 5061
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnDrag(PointerEventData eventData);

}

public interface IEndDragHandler : IEventSystemHandler // TypeDefIndex: 5062
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnEndDrag(PointerEventData eventData);

}

public interface IDropHandler : IEventSystemHandler // TypeDefIndex: 5063
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnDrop(PointerEventData eventData);

}

public interface IScrollHandler : IEventSystemHandler // TypeDefIndex: 5064
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnScroll(PointerEventData eventData);

}

public interface IUpdateSelectedHandler : IEventSystemHandler // TypeDefIndex: 5065
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnUpdateSelected(BaseEventData eventData);

}

public interface ISelectHandler : IEventSystemHandler // TypeDefIndex: 5066
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnSelect(BaseEventData eventData);

}

public interface IDeselectHandler : IEventSystemHandler // TypeDefIndex: 5067
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnDeselect(BaseEventData eventData);

}

public interface IMoveHandler : IEventSystemHandler // TypeDefIndex: 5068
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnMove(AxisEventData eventData);

}

public interface ISubmitHandler : IEventSystemHandler // TypeDefIndex: 5069
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnSubmit(BaseEventData eventData);

}

public interface ICancelHandler : IEventSystemHandler // TypeDefIndex: 5070
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnCancel(BaseEventData eventData);

}

public abstract class UIBehaviour : MonoBehaviour // TypeDefIndex: 5095
{	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	protected virtual void OnEnable() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 6
	protected virtual void Start() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	protected virtual void OnDisable() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	protected virtual void OnDestroy() { }

	// RVA: 0x10CFB40 Offset: 0x10CE140 VA: 0x1810CFB40 Slot: 9
	public virtual bool IsActive() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	protected virtual void OnRectTransformDimensionsChange() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 11
	protected virtual void OnBeforeTransformParentChanged() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 12
	protected virtual void OnTransformParentChanged() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 13
	protected virtual void OnDidApplyAnimationProperties() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 14
	protected virtual void OnCanvasGroupChanged() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 15
	protected virtual void OnCanvasHierarchyChanged() { }

	// RVA: 0x10CFB50 Offset: 0x10CE150 VA: 0x1810CFB50 Slot: 16
	public bool IsDestroyed() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	protected void .ctor() { }

}

internal interface ICallbackData // TypeDefIndex: 5102
{	// Properties
	public abstract CallbackType CallbackType { get; }
	public abstract int DataSize { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract CallbackType get_CallbackType();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_DataSize();

}

public interface IConnectionManager // TypeDefIndex: 5180
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnConnecting(ConnectionInfo info);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnConnected(ConnectionInfo info);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnDisconnected(ConnectionInfo info);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnMessage(IntPtr data, int size, long messageNum, long recvTime, int channel);

}

public interface ISocketManager // TypeDefIndex: 5181
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnConnecting(Connection connection, ConnectionInfo info);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnConnected(Connection connection, ConnectionInfo info);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnDisconnected(Connection connection, ConnectionInfo info);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnMessage(Connection connection, NetIdentity identity, IntPtr data, int size, long messageNum, long recvTime, int channel);

}

internal interface ICommandCenterListener // TypeDefIndex: 5633
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnCommandCenterUpdated();

}

public interface IAchievement // TypeDefIndex: 5686
{	// Properties
	public abstract string Key { get; }
	public abstract bool IsUnlocked { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Key();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_IsUnlocked();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Unlock();

}

public interface IAuthTicket : IDisposable // TypeDefIndex: 5687
{	// Properties
	public abstract string Token { get; }
	public abstract byte[] Data { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Token();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract byte[] get_Data();

}

public interface IDownloadableContent // TypeDefIndex: 5688
{	// Properties
	public abstract int AppId { get; }
	public abstract bool IsInstalled { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_AppId();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_IsInstalled();

}

public interface IPlatformHooks // TypeDefIndex: 5689
{	// Properties
	public abstract uint SteamAppId { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract uint get_SteamAppId();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Abort();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnItemDefinitionsChanged();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnInventoryChanged(IPlayerInventory inventory);

}

public interface IPlatformService // TypeDefIndex: 5690
{	// Properties
	public abstract bool IsValid { get; }
	public abstract ulong UserId { get; }
	public abstract string UserName { get; }
	public abstract string Country { get; }
	public abstract string Language { get; }
	public abstract string Version { get; }
	public abstract string Branch { get; }
	public abstract IEnumerable<IPlayerInfo> Friends { get; }
	public abstract IReadOnlyList<ServerInfo> FavoriteServers { get; }
	public abstract uint OptimalSampleRate { get; }
	public abstract bool VoiceRecord { get; set; }
	public abstract bool HasVoiceData { get; }
	public abstract IReadOnlyList<IPlayerItemDefinition> ItemDefinitions { get; }
	public abstract IReadOnlyList<IPlayerItem> Items { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Initialize(IPlatformHooks hooks);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Shutdown();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Update();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool get_IsValid();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract ulong get_UserId();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_UserName();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string get_Country();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string get_Language();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string get_Version();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract string get_Branch();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract IAuthTicket GetAuthSessionTicket();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract Task<IAuthTicket> GetAuthSessionTicketAsync();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract IEnumerable<IPlayerInfo> get_Friends();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract IPlayerInfo GetPlayerInformation(ulong userId);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract Task<IPlayerInfo> GetPlayerInformationAsync(ulong userId);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract Texture2D GetAvatarTexture(ulong userId);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract IServerQuery CreateServerQuery(ServerQuerySet querySet);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract IServerQuery CreateServerQuery(IEnumerable<string> endpoints);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void AddServerToHistory(ServerInfo server);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void RemoveServerFromHistory(ServerInfo server);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract IReadOnlyList<ServerInfo> get_FavoriteServers();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void AddServerToFavorites(ServerInfo server);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract void RemoveServerFromFavorites(ServerInfo server);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract string FilterChat(ulong userId, string message);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract string FilterName(ulong userId, string name);

	// RVA: -1 Offset: -1 Slot: 25
	public abstract string FilterGeneric(string text);

	// RVA: -1 Offset: -1 Slot: 26
	public abstract uint get_OptimalSampleRate();

	// RVA: -1 Offset: -1 Slot: 27
	public abstract bool get_VoiceRecord();

	// RVA: -1 Offset: -1 Slot: 28
	public abstract void set_VoiceRecord(bool value);

	// RVA: -1 Offset: -1 Slot: 29
	public abstract bool get_HasVoiceData();

	// RVA: -1 Offset: -1 Slot: 30
	public abstract byte[] GetCompressedVoiceData();

	// RVA: -1 Offset: -1 Slot: 31
	public abstract int DecompressVoiceData(byte[] data, MemoryStream outputStream);

	// RVA: -1 Offset: -1 Slot: 32
	public abstract IReadOnlyList<IPlayerItemDefinition> get_ItemDefinitions();

	// RVA: -1 Offset: -1 Slot: 33
	public abstract void RefreshItemDefinitions();

	// RVA: -1 Offset: -1 Slot: 34
	public abstract IPlayerItemDefinition GetItemDefinition(int definitionId);

	// RVA: -1 Offset: -1 Slot: 35
	public abstract IReadOnlyList<IPlayerItem> get_Items();

	// RVA: -1 Offset: -1 Slot: 36
	public abstract void RefreshItems();

	// RVA: -1 Offset: -1 Slot: 37
	public abstract Task<IPlayerInventory> RefreshAndGetItems();

	// RVA: -1 Offset: -1 Slot: 38
	public abstract Task<IPlayerInventory> CraftItem(IEnumerable<IPlayerItem> inputs, IPlayerItemDefinition output);

	// RVA: -1 Offset: -1 Slot: 39
	public abstract Task<List<IPlayerItemDefinition>> GetItemDefinitionsWithPrices();

	// RVA: -1 Offset: -1 Slot: 40
	public abstract string FormatPrice(int price);

	// RVA: -1 Offset: -1 Slot: 41
	public abstract IDownloadableContent GetDownloadableContent(int appId);

	// RVA: -1 Offset: -1 Slot: 42
	public abstract IWorkshopContent GetWorkshopContent(ulong workshopId);

	// RVA: -1 Offset: -1 Slot: 43
	public abstract void ClearRichPresence();

	// RVA: -1 Offset: -1 Slot: 44
	public abstract string GetRichPresence(string key);

	// RVA: -1 Offset: -1 Slot: 45
	public abstract void SetRichPresence(string key, string value);

	// RVA: -1 Offset: -1 Slot: 46
	public abstract IAchievement GetAchievement(string key);

	// RVA: -1 Offset: -1 Slot: 47
	public abstract void RequestCurrentStats();

	// RVA: -1 Offset: -1 Slot: 48
	public abstract long GetGlobalStatInt(string key);

	// RVA: -1 Offset: -1 Slot: 49
	public abstract long GetPlayerStatInt(string key);

	// RVA: -1 Offset: -1 Slot: 50
	public abstract void SetPlayerStatInt(string key, long value);

	// RVA: -1 Offset: -1 Slot: 51
	public abstract double GetGlobalStatFloat(string key);

	// RVA: -1 Offset: -1 Slot: 52
	public abstract double GetPlayerStatFloat(string key);

	// RVA: -1 Offset: -1 Slot: 53
	public abstract void SetPlayerStatFloat(string key, double value);

}

public interface IPlayerInfo // TypeDefIndex: 5691
{	// Properties
	public abstract ulong UserId { get; }
	public abstract string UserName { get; }
	public abstract bool IsOnline { get; }
	public abstract bool IsMe { get; }
	public abstract bool IsFriend { get; }
	public abstract bool IsPlayingThisGame { get; }
	public abstract string ServerEndpoint { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ulong get_UserId();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_UserName();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_IsOnline();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool get_IsMe();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_IsFriend();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsPlayingThisGame();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string get_ServerEndpoint();

}

public interface IPlayerInventory : IDisposable // TypeDefIndex: 5692
{	// Properties
	public abstract IReadOnlyList<IPlayerItem> Items { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool BelongsTo(ulong userId);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IReadOnlyList<IPlayerItem> get_Items();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract byte[] Serialize();

}

public interface IPlayerItem // TypeDefIndex: 5693
{	// Properties
	public abstract int DefinitionId { get; }
	public abstract int Quantity { get; }
	public abstract DateTimeOffset Acquired { get; }
	public abstract ulong WorkshopId { get; }
	public abstract string ItemShortName { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_DefinitionId();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_Quantity();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract DateTimeOffset get_Acquired();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract ulong get_WorkshopId();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string get_ItemShortName();

}

public interface IPlayerItemDefinition : IEquatable<IPlayerItemDefinition> // TypeDefIndex: 5694
{	// Properties
	public abstract int DefinitionId { get; }
	public abstract string Name { get; }
	public abstract string Description { get; }
	public abstract string Type { get; }
	public abstract string IconUrl { get; }
	public abstract int LocalPrice { get; }
	public abstract string LocalPriceFormatted { get; }
	public abstract string PriceCategory { get; }
	public abstract bool IsGenerator { get; }
	public abstract bool IsMarketable { get; }
	public abstract string StoreTags { get; }
	public abstract string ItemShortName { get; }
	public abstract ulong WorkshopId { get; }
	public abstract ulong WorkshopDownload { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_DefinitionId();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_Description();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string get_Type();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string get_IconUrl();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int get_LocalPrice();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string get_LocalPriceFormatted();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string get_PriceCategory();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_IsGenerator();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool get_IsMarketable();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract string get_StoreTags();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract string get_ItemShortName();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract ulong get_WorkshopId();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract ulong get_WorkshopDownload();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract IEnumerable<PlayerItemRecipe> GetRecipesContainingThis();

}

public interface IServerQuery : IDisposable // TypeDefIndex: 5696
{	// Properties
	public abstract ServerQuerySet QuerySet { get; }
	public abstract IReadOnlyList<ServerInfo> Servers { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ServerQuerySet get_QuerySet();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IReadOnlyList<ServerInfo> get_Servers();

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void add_OnServerFound(Action<ServerInfo> value);

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 3
	public abstract void remove_OnServerFound(Action<ServerInfo> value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void AddFilter(string key, string value);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Task RunQueryAsync(double timeoutInSeconds);

}

public interface IWorkshopContent // TypeDefIndex: 5697
{	// Properties
	public abstract ulong WorkshopId { get; }
	public abstract string Title { get; }
	public abstract string Description { get; }
	public abstract IEnumerable<string> Tags { get; }
	public abstract string Url { get; }
	public abstract string PreviewImageUrl { get; }
	public abstract ulong OwnerId { get; }
	public abstract IPlayerInfo Owner { get; }
	public abstract bool IsInstalled { get; }
	public abstract bool IsDownloadPending { get; }
	public abstract bool IsDownloading { get; }
	public abstract string Directory { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ulong get_WorkshopId();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_Title();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_Description();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IEnumerable<string> get_Tags();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string get_Url();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_PreviewImageUrl();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract ulong get_OwnerId();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IPlayerInfo get_Owner();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_IsInstalled();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool get_IsDownloadPending();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool get_IsDownloading();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract string get_Directory();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool Download();

}

public interface IArrayPool<T> // TypeDefIndex: 5871
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T[] Rent(int minimumLength);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IArrayPool<object>.Rent
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Return(T[] array);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IArrayPool<object>.Return
	*/

}

public interface IJsonLineInfo // TypeDefIndex: 5883
{	// Properties
	public abstract int LineNumber { get; }
	public abstract int LinePosition { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool HasLineInfo();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_LineNumber();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_LinePosition();

}

internal interface IWrappedCollection : IList, ICollection, IEnumerable // TypeDefIndex: 5947
{	// Properties
	public abstract object UnderlyingCollection { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_UnderlyingCollection();

}

internal interface IWrappedDictionary : IDictionary, ICollection, IEnumerable // TypeDefIndex: 5950
{	// Properties
	public abstract object UnderlyingDictionary { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_UnderlyingDictionary();

}

public interface ITraceWriter // TypeDefIndex: 5976
{
// Namespace: Newtonsoft.Json.Serialization
[PreserveAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
public interface ITraceWriter // TypeDefIndex: 5976
	// Properties
	public abstract TraceLevel LevelFilter { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TraceLevel get_LevelFilter();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Trace(TraceLevel level, string message, Exception ex);

}

public interface IContractResolver // TypeDefIndex: 6003
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract JsonContract ResolveContract(Type type);

}

public interface IValueProvider // TypeDefIndex: 6004
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetValue(object target, object value);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object GetValue(object target);

}

public interface IReferenceResolver // TypeDefIndex: 6017
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object ResolveReference(object context, string reference);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string GetReference(object context, object value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool IsReferenced(object context, object value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void AddReference(object context, string reference, object value);

}

internal interface IXmlDocument : IXmlNode // TypeDefIndex: 6116
{	// Properties
	public abstract IXmlElement DocumentElement { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IXmlNode CreateComment(string text);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IXmlNode CreateTextNode(string text);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IXmlNode CreateCDataSection(string data);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IXmlNode CreateWhitespace(string text);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IXmlNode CreateSignificantWhitespace(string text);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IXmlNode CreateProcessingInstruction(string target, string data);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract IXmlElement CreateElement(string elementName);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract IXmlElement CreateElement(string qualifiedName, string namespaceUri);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract IXmlNode CreateAttribute(string name, string value);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract IXmlElement get_DocumentElement();

}

internal interface IXmlDeclaration : IXmlNode // TypeDefIndex: 6117
{	// Properties
	public abstract string Version { get; }
	public abstract string Encoding { get; }
	public abstract string Standalone { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Version();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_Encoding();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_Standalone();

}

internal interface IXmlDocumentType : IXmlNode // TypeDefIndex: 6118
{	// Properties
	public abstract string Name { get; }
	public abstract string System { get; }
	public abstract string Public { get; }
	public abstract string InternalSubset { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_System();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_Public();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string get_InternalSubset();

}

internal interface IXmlElement : IXmlNode // TypeDefIndex: 6119
{	// Properties
	public abstract bool IsEmpty { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetAttributeNode(IXmlNode attribute);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string GetPrefixOfNamespace(string namespaceUri);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_IsEmpty();

}

internal interface IXmlNode // TypeDefIndex: 6120
{	// Properties
	public abstract XmlNodeType NodeType { get; }
	public abstract string LocalName { get; }
	public abstract List<IXmlNode> ChildNodes { get; }
	public abstract List<IXmlNode> Attributes { get; }
	public abstract IXmlNode ParentNode { get; }
	public abstract string Value { get; }
	public abstract string NamespaceUri { get; }
	public abstract object WrappedNode { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract XmlNodeType get_NodeType();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_LocalName();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract List<IXmlNode> get_ChildNodes();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract List<IXmlNode> get_Attributes();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IXmlNode get_ParentNode();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_Value();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IXmlNode AppendChild(IXmlNode newChild);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string get_NamespaceUri();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract object get_WrappedNode();

}

public interface IProto // TypeDefIndex: 6279
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void WriteToStream(Stream stream);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void ReadFromStream(Stream stream, int size, bool isDelta = False);

}

public interface ICustomMaterialReplacer // TypeDefIndex: 6573
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Replace(Material[] find, Material[] replace);

}

public interface IPrefabPreProcess // TypeDefIndex: 6578
{
// Namespace: 
public interface IServerComponent // TypeDefIndex: 6576

// Namespace: 
public interface IClientComponent // TypeDefIndex: 6577

// Namespace: 
public interface IPrefabPreProcess // TypeDefIndex: 6578
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling);

}

public interface IPrefabPostProcess // TypeDefIndex: 6579
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void PostProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling);

}

public interface IPrefabProcessor // TypeDefIndex: 6580
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void RemoveComponent(Component component);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void NominateForDeletion(GameObject obj);

}

public interface IServerComponentEx // TypeDefIndex: 6581
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void PreServerComponentCull(IPrefabProcessor p);

}

public interface IClientComponentEx // TypeDefIndex: 6582
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void PreClientComponentCull(IPrefabProcessor p);

}

public interface IPropRenderNotify // TypeDefIndex: 6583
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void PreRender();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void PostRender();

}

public interface IEntity // TypeDefIndex: 6622
{	// Properties
	public abstract bool IsDestroyed { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsDestroyed();

}

public interface INetworkCryptocraphy // TypeDefIndex: 6678
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool IsEnabledIncoming(Connection connection);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool IsEnabledOutgoing(Connection connection);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract MemoryStream EncryptCopy(Connection connection, MemoryStream stream, int offset);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract MemoryStream DecryptCopy(Connection connection, MemoryStream stream, int offset);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Encrypt(Connection connection, MemoryStream stream, int offset);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Decrypt(Connection connection, MemoryStream stream, int offset);

}

public interface IDemoHeader // TypeDefIndex: 6681
{	// Properties
	public abstract long Length { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract long get_Length();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Length(long value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Write(BinaryWriter writer);

}

public interface IClientCallback // TypeDefIndex: 6686
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnNetworkMessage(Message message);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnClientDisconnected(string reason);

}

public interface NetworkHandler // TypeDefIndex: 6699
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnNetworkSubscribersEnter(List<Connection> connections);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnNetworkSubscribersLeave(List<Connection> connections);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnNetworkGroupChange();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnNetworkGroupLeave(Group group);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnNetworkGroupEnter(Group group);

}

public interface IServerCallback // TypeDefIndex: 6702
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnNetworkMessage(Message message);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool OnUnconnectedMessage(int type, NetRead read, uint ip, int port);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnDisconnected(string reason, Connection connection);

}

public interface Provider // TypeDefIndex: 6706
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnGroupAdded(Group group);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool IsInside(Group group, Vector3 vPos);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Group GetGroup(Vector3 vPos);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void GetVisibleFromFar(Group group, List<Group> groups);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void GetVisibleFromNear(Group group, List<Group> groups);

}

public interface ILocalize // TypeDefIndex: 6720
{	// Properties
	public abstract string LanguageToken { get; }
	public abstract string LanguageEnglish { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_LanguageToken();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_LanguageEnglish();

}

internal interface ITweenValue // TypeDefIndex: 6749
{	// Properties
	public abstract bool ignoreTimeScale { get; }
	public abstract float duration { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void TweenValue(float floatPercentage);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_ignoreTimeScale();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract float get_duration();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool ValidTarget();

}

public interface ITextElement // TypeDefIndex: 6825
{	// Properties
	public abstract Material sharedMaterial { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Material get_sharedMaterial();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Rebuild(CanvasUpdate update);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int GetInstanceID();

}

public interface ConsoleSystem.IConsoleCommand // TypeDefIndex: 6882
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Call(ConsoleSystem.Arg arg);

}

public interface ConsoleSystem.IConsoleButton // TypeDefIndex: 6883
{	// Properties
	public abstract bool IsPressed { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsPressed();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_IsPressed(bool value);

}

public interface IHandler : IDisposable // TypeDefIndex: 6909
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Receive(Span<byte> newData);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract MemoryBuffer CreateHandshake();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract MemoryBuffer FrameText(string text);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract MemoryBuffer FrameClose(ushort code);

}

public interface ISocket // TypeDefIndex: 6910
{	// Properties
	public abstract bool Connected { get; }
	public abstract IPAddress RemoteIpAddress { get; }
	public abstract int RemotePort { get; }
	public abstract Stream Stream { get; }
	public abstract bool NoDelay { set; }
	public abstract EndPoint LocalEndPoint { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_Connected();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IPAddress get_RemoteIpAddress();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_RemotePort();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract Stream get_Stream();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void set_NoDelay(bool value);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract EndPoint get_LocalEndPoint();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract Task<ISocket> Accept(Action<ISocket> callback, Action<Exception> error);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract Task Authenticate(X509Certificate2 certificate, SslProtocols enabledSslProtocols, Action callback, Action<Exception> error);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Dispose();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void Close();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void Bind(EndPoint ipLocal);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void Listen(int backlog);

}

public interface IWebSocketConnection // TypeDefIndex: 6912
{	// Properties
	public abstract Action OnOpen { set; }
	public abstract Action OnClose { get; set; }
	public abstract Action<string> OnMessage { get; set; }
	public abstract BinaryDataHandler OnBinary { get; }
	public abstract BinaryDataHandler OnPing { get; }
	public abstract BinaryDataHandler OnPong { get; }
	public abstract Action<Exception> OnError { set; }
	public abstract IWebSocketConnectionInfo ConnectionInfo { get; }
	public abstract bool IsAvailable { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void set_OnOpen(Action value);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Action get_OnClose();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void set_OnClose(Action value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract Action<string> get_OnMessage();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void set_OnMessage(Action<string> value);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract BinaryDataHandler get_OnBinary();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract BinaryDataHandler get_OnPing();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract BinaryDataHandler get_OnPong();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void set_OnError(Action<Exception> value);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void Send(string message);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void Close();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract IWebSocketConnectionInfo get_ConnectionInfo();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool get_IsAvailable();

}

public interface IWebSocketConnectionInfo // TypeDefIndex: 6913
{	// Properties
	public abstract string Path { get; }
	public abstract IPAddress ClientIpAddress { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Path();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IPAddress get_ClientIpAddress();

}

internal interface ILZ4Service // TypeDefIndex: 6985
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int Encode(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int EncodeHC(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int Decode(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength, bool knownOutputLength);

}

public interface IAutoLayout // TypeDefIndex: 7001
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void DoLayout();

}

public static class UIBehaviourEx // TypeDefIndex: 7003
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFDA270 Offset: 0xFD8870 VA: 0x180FDA270
	public static void SetParent(UIBehaviour self, Transform parent) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFDA1A0 Offset: 0xFD87A0 VA: 0x180FDA1A0
	public static void SetParent(UIBehaviour self, Canvas parent) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFDA1A0 Offset: 0xFD87A0 VA: 0x180FDA1A0
	public static void SetParent(UIBehaviour self, UIBehaviour parent) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFDA060 Offset: 0xFD8660 VA: 0x180FDA060
	public static void SetParentRootCanvas(UIBehaviour self, Transform tx) { }

}

public interface IValueTaskSource // TypeDefIndex: 7089
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ValueTaskSourceStatus GetStatus(short token);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnCompleted(Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void GetResult(short token);

}

public interface IValueTaskSource<TResult> // TypeDefIndex: 7090
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ValueTaskSourceStatus GetStatus(short token);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IValueTaskSource<object>.GetStatus
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnCompleted(Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IValueTaskSource<object>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract TResult GetResult(short token);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IValueTaskSource<object>.GetResult
	*/

}

private interface NativeClient.INativeModule // TypeDefIndex: 7160
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IntPtr Create();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Destroy(IntPtr Instance);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Initialize(IntPtr Instance, NativeClient.CallbackProgress OnProgress, NativeClient.CallbackFinished OnFinished, IntPtr CallbackParameter);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void ConnectionReset(IntPtr Instance);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool PopNetworkMessage(IntPtr Instance, ref byte[] MessageBuffer, out int MessageLength);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void PushNetworkMessage(IntPtr Instance, byte[] MessageBuffer, int MessageLength);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void PollStatus(IntPtr Instance, NativeClient.CallbackIntegrity OnIntegrityViolation, NativeClient.CallbackHostValidation OnHostValidation, IntPtr CallbackParameter);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void SetPlatformUserAuthTicket(IntPtr Instance, string PlatformName, byte[] AuthTicket, int AuthTicketLength);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract IntPtr NetProtect(IntPtr Instance);

}

public interface INetProtect // TypeDefIndex: 7164
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool ProtectMessage(MemoryStream Input, long InputOffset, MemoryStream Output, long OutputOffset);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool UnprotectMessage(MemoryStream Input, long InputOffset, MemoryStream Output, long OutputOffset);

}

public interface IFrameDecoder // TypeDefIndex: 7399
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void DecodeFrame();

}

public interface ILengthedObject : ITimedObject // TypeDefIndex: 7436
{	// Properties
	public abstract long Length { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract long get_Length();

}

internal interface ITempoMapValuesCache // TypeDefIndex: 7450
{	// Properties
	public abstract IEnumerable<TempoMapLine> InvalidateOnLines { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IEnumerable<TempoMapLine> get_InvalidateOnLines();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Invalidate(TempoMap tempoMap);

}

public interface ITimedObject // TypeDefIndex: 7463
{	// Properties
	public abstract long Time { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract long get_Time();

}

internal interface ITimeSpanConverter // TypeDefIndex: 7472
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ITimeSpan ConvertTo(long timeSpan, long time, TempoMap tempoMap);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract long ConvertFrom(ITimeSpan timeSpan, long time, TempoMap tempoMap);

}

public interface ITimeSpan : IComparable // TypeDefIndex: 7482
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ITimeSpan Subtract(ITimeSpan timeSpan, TimeSpanMode mode);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract ITimeSpan Clone();

}

internal interface IEventReader // TypeDefIndex: 7554
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract MidiEvent Read(MidiReader reader, ReadingSettings settings, byte currentStatusByte);

}

public interface IRgbService // TypeDefIndex: 7677
{	// Properties
	public abstract bool IsConnected { get; }
	public abstract Vector3 ColorCorrection { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsConnected();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Vector3 get_ColorCorrection();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void set_ColorCorrection(Vector3 value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract ValueTask Start();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract ValueTask Stop();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract ValueTask Update();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void StaticColor(Color color);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void PulseColor(Color color, float duration);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Event(RgbEventType type);

}

public interface IImageEffect // TypeDefIndex: 8029
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool IsActive();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnRenderImage(RenderTexture source, RenderTexture destination);

}

public interface IRemoteControllable // TypeDefIndex: 8682
{	// Properties
	public abstract bool RequiresMouse { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Transform GetEyes();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract BaseEntity GetEnt();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool Occupied();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void UpdateIdentifier(string newID, bool clientSend = False);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string GetIdentifier();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void RCSetup();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void RCShutdown();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool CanControl();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_RequiresMouse();

}

public interface IVendingMachineInterface // TypeDefIndex: 8733
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void BuyButtonClicked(int index, int multiplier);

}

public class UIMarketSearch : MonoBehaviour // TypeDefIndex: 8803
{	// Fields
	public GameObjectRef StoreEntryRef; // 0x18
	public RectTransform StoreRoot; // 0x20
	public UIMarketTerminal Terminal; // 0x28

	// Methods

	// RVA: 0x4ED4F0 Offset: 0x4EBAF0 VA: 0x1804ED4F0
	public void UpdateFilter(string filter) { }

	// RVA: 0x4ED1F0 Offset: 0x4EB7F0 VA: 0x1804ED1F0
	private void FilterSellOrders(VendingMachine machine, string filter, List<VendingMachine.SellOrder> orders) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4ED430 Offset: 0x4EBA30 VA: 0x1804ED430
	private void <UpdateFilter>g__CreateStoreEntry|3_0(VendingMachineMapMarker marker, List<VendingMachine.SellOrder> matchingOrders) { }

}

public class UIMarketSearchOrderEntry : MonoBehaviour // TypeDefIndex: 8804
{	// Fields
	public RustText ItemName; // 0x18
	public GameObject OutOfStockRoot; // 0x20
	public GameObject BpRoot; // 0x28

	// Methods

	// RVA: 0x4ECD80 Offset: 0x4EB380 VA: 0x1804ECD80
	public void Populate(VendingMachine.SellOrder order) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class UIMarketSearchStore : MonoBehaviour // TypeDefIndex: 8805
{	// Fields
	public RustText StoreName; // 0x18
	public List<UIMarketSearchOrderEntry> Entries; // 0x20
	private VendingMachineMapMarker cachedMarker; // 0x28
	private UIMarketTerminal cachedTerminal; // 0x30

	// Methods

	// RVA: 0x4ED030 Offset: 0x4EB630 VA: 0x1804ED030
	public void Populate(VendingMachineMapMarker machine, List<VendingMachine.SellOrder> matchingEntries, UIMarketTerminal terminal) { }

	// RVA: 0x4ECEB0 Offset: 0x4EB4B0 VA: 0x1804ECEB0
	public void OnCLickedGoTo() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class UIMarketTerminal : UIDialog, IVendingMachineInterface // TypeDefIndex: 8806
{	// Fields
	public static readonly Translate.Phrase PendingDeliveryPluralPhrase; // 0x0
	public static readonly Translate.Phrase PendingDeliverySingularPhrase; // 0x8
	public Canvas canvas; // 0x30
	public MapView mapView; // 0x38
	public RectTransform shopDetailsPanel; // 0x40
	public float shopDetailsMargin; // 0x48
	public float easeDuration; // 0x4C
	public LeanTweenType easeType; // 0x50
	public RustText shopName; // 0x58
	public GameObject shopOrderingPanel; // 0x60
	public RectTransform sellOrderContainer; // 0x68
	public GameObjectRef sellOrderPrefab; // 0x70
	public VirtualItemIcon deliveryFeeIcon; // 0x78
	public GameObject deliveryFeeCantAffordIndicator; // 0x80
	public GameObject inventoryFullIndicator; // 0x88
	public GameObject notEligiblePanel; // 0x90
	public GameObject pendingDeliveryPanel; // 0x98
	public RustText pendingDeliveryLabel; // 0xA0
	public RectTransform itemNoticesContainer; // 0xA8
	public GameObjectRef itemRemovedPrefab; // 0xB0
	public GameObjectRef itemPendingPrefab; // 0xB8
	public GameObjectRef itemAddedPrefab; // 0xC0
	public CanvasGroup gettingStartedTip; // 0xC8
	public SoundDefinition buyItemSoundDef; // 0xD0
	public SoundDefinition buttonPressSoundDef; // 0xD8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private MarketTerminal <currentTerminal>k__BackingField; // 0xE0
	private uint _currentVendingMachine; // 0xE8
	private HashSet<uint> _eligibleVendingMachines; // 0xF0
	private List<SellOrderEntry> _shopEntries; // 0xF8
	private Action<SellOrderEntry, int> _onShopEntryAmountChangedCached; // 0x100

	// Properties
	public MarketTerminal currentTerminal { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4EF330 Offset: 0x4ED930 VA: 0x1804EF330
	public MarketTerminal get_currentTerminal() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4EF340 Offset: 0x4ED940 VA: 0x1804EF340
	private void set_currentTerminal(MarketTerminal value) { }

	// RVA: 0x4EEB30 Offset: 0x4ED130 VA: 0x1804EEB30
	public void Setup(MarketTerminal terminal, List<uint> eligibleVendingMachineIds) { }

	// RVA: 0x4EE5E0 Offset: 0x4ECBE0 VA: 0x1804EE5E0 Slot: 8
	public override void OpenDialog() { }

	// RVA: 0x4EDF70 Offset: 0x4EC570 VA: 0x1804EDF70 Slot: 9
	public override void CloseDialog() { }

	// RVA: 0x4EE5C0 Offset: 0x4ECBC0 VA: 0x1804EE5C0
	public void OnVendingMachineClicked(UIMapVendingMachineMarker marker) { }

	// RVA: 0x4EE8F0 Offset: 0x4ECEF0 VA: 0x1804EE8F0
	public void SelectVendingMachine(VendingMachine vmData) { }

	// RVA: 0x4EE120 Offset: 0x4EC720 VA: 0x1804EE120
	public void HideVendingMachine(bool immediate = False) { }

	// RVA: 0x4EDAC0 Offset: 0x4EC0C0 VA: 0x1804EDAC0 Slot: 10
	public void BuyButtonClicked(int index, int multiplier) { }

	// RVA: 0x4ED8C0 Offset: 0x4EBEC0 VA: 0x1804ED8C0
	public void AddItemNotice(int itemDefId, int quantity, bool isPending) { }

	// RVA: 0x4EEEC0 Offset: 0x4ED4C0 VA: 0x1804EEEC0
	public void UpdateShopDetails(VendingMachine vmData) { }

	// RVA: 0x4EE440 Offset: 0x4ECA40 VA: 0x1804EE440
	private void OnShopEntryAmountChanged(SellOrderEntry changedEntry, int newAmount) { }

	// RVA: 0x4EEC50 Offset: 0x4ED250 VA: 0x1804EEC50
	public void UpdateIndicators() { }

	// RVA: 0x4EDD40 Offset: 0x4EC340 VA: 0x1804EDD40
	private bool CanAffordCurrentOrder() { }

	// RVA: 0x4EE350 Offset: 0x4EC950 VA: 0x1804EE350
	public static bool IsOpen(out UIMarketTerminal marketTerminal) { }

	// RVA: 0x4EF2C0 Offset: 0x4ED8C0 VA: 0x1804EF2C0
	public void .ctor() { }

	// RVA: 0x4EF210 Offset: 0x4ED810 VA: 0x1804EF210
	private static void .cctor() { }

}

private sealed class UIMarketTerminal.<>c // TypeDefIndex: 8807
{	// Fields
	public static readonly UIMarketTerminal.<>c <>9; // 0x0
	public static Predicate<SellOrderEntry> <>9__44_0; // 0x8

	// Methods

	// RVA: 0xA00710 Offset: 0x9FED10 VA: 0x180A00710
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xA006B0 Offset: 0x9FECB0 VA: 0x180A006B0
	internal bool <CanAffordCurrentOrder>b__44_0(SellOrderEntry e) { }

}

public class UITwitchTrophy : UIDialog // TypeDefIndex: 8819
{	// Fields
	public HttpImage EventImage; // 0x30
	public RustText EventName; // 0x38
	public RustText WinningTeamName; // 0x40
	public RectTransform TeamMembersRoot; // 0x48
	public GameObject TeamMemberNamePrefab; // 0x50
	public GameObject MissingDataOverlay; // 0x58

	// Methods

	// RVA: 0xA04D30 Offset: 0xA03330 VA: 0x180A04D30 Slot: 8
	public override void OpenDialog() { }

	// RVA: 0x4C1A40 Offset: 0x4C0040 VA: 0x1804C1A40
	public void .ctor() { }

}

private class UITwitchTrophy.TrophyPage // TypeDefIndex: 8820
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <EventTitle>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Logo>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <WinningTeam>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private List<string> <TeamMembers>k__BackingField; // 0x28

	// Properties
	public string EventTitle { get; set; }
	public string Logo { get; set; }
	public string WinningTeam { get; set; }
	public List<string> TeamMembers { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_EventTitle() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	public void set_EventTitle(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Logo() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	public void set_Logo(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_WinningTeam() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_WinningTeam(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public List<string> get_TeamMembers() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE9E0 Offset: 0x7ECFE0 VA: 0x1807EE9E0
	public void set_TeamMembers(List<string> value) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public interface IConversationProvider // TypeDefIndex: 8848
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ResponsePressed(int index);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void EndConversation(bool fromServer);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void DoAction(string actionString);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract Vector3 GetConversationWorldOrigin();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool ProviderBusy();

}

public interface IThinker // TypeDefIndex: 8932
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void TryThink();

}

public interface ISoundBudgetedUpdate // TypeDefIndex: 8996
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void DoUpdate();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool IsSyncedToParent();

}

public interface ILerpInfo // TypeDefIndex: 9220
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract float GetExtrapolationTime();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract float GetInterpolationDelay();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract float GetInterpolationSmoothing();

}

public interface IPosLerpTarget : ILerpInfo // TypeDefIndex: 9221
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract float GetInterpolationInertia();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Vector3 GetNetworkPosition();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Quaternion GetNetworkRotation();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void SetNetworkPosition(Vector3 pos);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void SetNetworkRotation(Quaternion rot);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void DrawInterpolationState(Interpolator.Segment<TransformSnapshot> segment, List<TransformSnapshot> entries);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void LerpIdleDisable();

}

internal interface IRagdollInhert // TypeDefIndex: 9227
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Transform RagdollInhertTransform();

}

public interface IEffectRecycle // TypeDefIndex: 9336
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Recycle();

}

public interface IEffect // TypeDefIndex: 9337
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetupEffect(Effect effect);

}

public interface IAnimationEventReceiver // TypeDefIndex: 9350
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnAnimationEvent(string eventName);

}

public interface IAIEventListener // TypeDefIndex: 9400
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void EventTriggeredStateChange(int newStateContainerID, int sourceEventID);

}

internal interface IAIDesign // TypeDefIndex: 9427
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool CanPlayerDesignAI(BasePlayer player);

}

public interface IPet // TypeDefIndex: 9432
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool IsPet();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetPetOwner(BasePlayer player);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool IsOwnedBy(BasePlayer player);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool IssuePetCommand(PetCommandType cmd, int param, Nullable<Ray> ray);

}

public interface ICassettePlayer // TypeDefIndex: 9438
{	// Properties
	public abstract BaseEntity ToBaseEntity { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract BaseEntity get_ToBaseEntity();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnLoadedWithCassette(Cassette c);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnCensorRecordingsChanged();

}

public interface IAudioConnectionSource // TypeDefIndex: 9444
{	// Properties
	public abstract float VolumeVisualisationMultiplier { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SpeakerConnected(ConnectedSpeaker speaker);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SpeakerDisconnected(ConnectedSpeaker repeater);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract AudioSource GetSource();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract float get_VolumeVisualisationMultiplier();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract float GetFakeInput();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IOEntity ToEntity();

}

public interface IServerFileReceiver // TypeDefIndex: 9458
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnServerFileReceived(FileStorage.Type type, uint numId, uint crc, byte[] data);

}

public interface IFlagNotify // TypeDefIndex: 9496
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnFlagToggled(bool state);

}

public interface IImageReceiver // TypeDefIndex: 9513
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnImageLoaded(Texture2D texture);

}

public interface ISignage // TypeDefIndex: 9518
{	// Properties
	public abstract Vector2i TextureSize { get; }
	public abstract int TextureCount { get; }
	public abstract uint NetworkID { get; }
	public abstract FileStorage.Type FileType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool CanUpdateSign(BasePlayer player);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract float Distance(Vector3 position);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Vector2i get_TextureSize();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int get_TextureCount();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract uint[] GetTextureCRCs();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract uint get_NetworkID();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract FileStorage.Type get_FileType();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void OnTextureWasEdited(int frame, Texture2D texture, bool fromFile);

}

public interface IItemContainerEntity // TypeDefIndex: 9548
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int GetMoveToContainerIndex(BasePlayer player, Item item);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int GetMoveToSlotIndex(BasePlayer player, Item item);

}

public interface IVehicleLockUser // TypeDefIndex: 9743
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool PlayerHasUnlockPermission(BasePlayer player);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool PlayerCanUseThis(BasePlayer player, ModularCarLock.LockType lockType);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool PlayerCanDestroyLock(BasePlayer player, BaseVehicleModule viaModule);

}

public interface ITrainCollidable // TypeDefIndex: 9764
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool CustomCollision(TrainCar train, TriggerTrainCollisions trainTrigger);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool EqualNetID(BaseNetworkable other);

}

public interface VehicleChassisVisuals.IClientWheelUser<T> // TypeDefIndex: 9782
{	// Properties
	public abstract Vector3 Velocity { get; }
	public abstract float DriveWheelVelocity { get; }
	public abstract float SteerAngle { get; }
	public abstract float MaxSteerAngle { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Vector3 get_Velocity();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VehicleChassisVisuals.IClientWheelUser<object>.get_Velocity
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract float get_DriveWheelVelocity();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VehicleChassisVisuals.IClientWheelUser<object>.get_DriveWheelVelocity
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract float get_SteerAngle();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VehicleChassisVisuals.IClientWheelUser<object>.get_SteerAngle
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public abstract float get_MaxSteerAngle();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VehicleChassisVisuals.IClientWheelUser<object>.get_MaxSteerAngle
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract float GetThrottleInput();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VehicleChassisVisuals.IClientWheelUser<object>.GetThrottleInput
	*/

}

public interface IEngineControllerUser : IEntity // TypeDefIndex: 9786
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool HasFlag(BaseEntity.Flags f);

}

public interface IRFObject // TypeDefIndex: 9813
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ClientSetFrequency(int newFreq);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int GetFrequency();

}

public interface IInstanceDataReceiver // TypeDefIndex: 9904
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ReceiveInstanceData(Item.InstanceData data);

}

public interface IOnParentDestroying // TypeDefIndex: 9905
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnParentDestroying();

}

public interface IOnParentSpawning // TypeDefIndex: 9907
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnParentSpawning();

}

public interface IOnPostNetworkUpdate // TypeDefIndex: 9909
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnPostNetworkUpdate(BaseEntity entity);

}

public interface IOnSendNetworkUpdate // TypeDefIndex: 9911
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnSendNetworkUpdate(BaseEntity entity);

}

public interface ILOD // TypeDefIndex: 9928
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ChangeLOD();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void RefreshLOD();

}

public interface INotifyLOD // TypeDefIndex: 9945
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Show();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Hide();

}

public interface ISpawnGroup // TypeDefIndex: 10000
{	// Properties
	public abstract int currentPopulation { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Clear();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Fill();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void SpawnInitial();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void SpawnRepeating();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_currentPopulation();

}

public interface ISpawnPointUser // TypeDefIndex: 10001
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ObjectSpawned(SpawnPointInstance instance);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void ObjectRetired(SpawnPointInstance instance);

}

public interface TriggerHurtNotChild.IHurtTriggerUser // TypeDefIndex: 10028
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract BasePlayer GetPlayerDamageInitiator();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract float GetPlayerDamageMultiplier();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnHurtTriggerOccupant(BaseEntity hurtEntity, DamageType damageType, float damageTotal);

}

public interface INotifyTrigger // TypeDefIndex: 10033
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnObjects(TriggerNotify trigger);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnEmpty();

}

public interface INotifyEntityTrigger // TypeDefIndex: 10035
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnEntityEnter(BaseEntity ent);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnEntityLeave(BaseEntity ent);

}

public interface IItemUpdate // TypeDefIndex: 10109
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnItemUpdate(Item item);

}

public interface IItemSetup // TypeDefIndex: 10110
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnItemSetup(Item item);

}

public interface IAirSupply // TypeDefIndex: 10161
{	// Properties
	public abstract ItemModGiveOxygen.AirSupplyType AirType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ItemModGiveOxygen.AirSupplyType get_AirType();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract float GetAirTimeRemaining();

}

public interface IMissionProvider // TypeDefIndex: 10213
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract uint ProviderID();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Vector3 ProviderPosition();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract BaseEntity Entity();

}

public class UIAIDesignerScreen : SingletonComponent<UIAIDesignerScreen>, IUIScreen // TypeDefIndex: 10817
{	// Fields
	public GameObject SaveEntityButton; // 0x18
	public GameObject SaveServerButton; // 0x20
	public GameObject SaveDefaultButton; // 0x28
	public RustInput InputAIDescription; // 0x30
	public RustText TextDefaultStateContainer; // 0x38
	public Transform PrefabAddNewStateButton; // 0x40
	public Transform StateContainer; // 0x48
	public Transform PrefabState; // 0x50
	public EnumListUI PopupList; // 0x58
	public static EnumListUI EnumList; // 0x0
	public NeedsCursor needsCursor; // 0x60
	protected CanvasGroup canvasGroup; // 0x68
	public GameObject RootPanel; // 0x70
	private bool visible; // 0x78
	public AIDesign DesignProto; // 0x80
	private Transform addNewStateButton; // 0x88

	// Methods

	// RVA: 0x4D61C0 Offset: 0x4D47C0 VA: 0x1804D61C0 Slot: 6
	protected override void Awake() { }

	// RVA: 0x4D7530 Offset: 0x4D5B30 VA: 0x1804D7530
	public void Init(AIDesign design) { }

	[IteratorStateMachineAttribute] // RVA: 0x7C9E0 Offset: 0x7BDE0 VA: 0x18007C9E0
	// RVA: 0x4D7F80 Offset: 0x4D6580 VA: 0x1804D7F80
	private IEnumerator SetInitialStateContainer(int id) { }

	// RVA: 0x4D8000 Offset: 0x4D6600 VA: 0x1804D8000 Slot: 8
	public void SetVisible(bool flag) { }

	// RVA: 0x4D6250 Offset: 0x4D4850 VA: 0x1804D6250
	public void ClearStates() { }

	// RVA: 0x4D5FF0 Offset: 0x4D45F0 VA: 0x1804D5FF0
	private void AddNewStateButton() { }

	// RVA: 0x4D6C30 Offset: 0x4D5230 VA: 0x1804D6C30
	public List<AIState> GetAvailableStates() { }

	// RVA: 0x4D7050 Offset: 0x4D5650 VA: 0x1804D7050
	public List<int> GetStateContainerIDs() { }

	// RVA: 0x4D72D0 Offset: 0x4D58D0 VA: 0x1804D72D0
	private BaseStateUI GetStateContainer(int id) { }

	// RVA: 0x4D6DA0 Offset: 0x4D53A0 VA: 0x1804D6DA0
	public int GetNextStateContainerID() { }

	// RVA: 0x4D60C0 Offset: 0x4D46C0 VA: 0x1804D60C0
	public BaseStateUI AddState(AIState state, int stateContainerID) { }

	// RVA: 0x4D6540 Offset: 0x4D4B40 VA: 0x1804D6540
	public void DeleteState(BaseStateUI state) { }

	// RVA: 0x4D69B0 Offset: 0x4D4FB0 VA: 0x1804D69B0
	public void DuplicateState(BaseStateUI state) { }

	// RVA: 0x4D7780 Offset: 0x4D5D80 VA: 0x1804D7780
	public void OnDebugStateChanged(int previousStateContainerID, int newStateContainerID, int triggerEventID) { }

	// RVA: 0x4D78C0 Offset: 0x4D5EC0 VA: 0x1804D78C0
	public void OnSetDefaultStateClicked() { }

	// RVA: 0x4D7EE0 Offset: 0x4D64E0 VA: 0x1804D7EE0
	public void SetDefaultStateClicked(object value) { }

	// RVA: 0x4D7EA0 Offset: 0x4D64A0 VA: 0x1804D7EA0
	private void SetDefaultOutputStateContainer(int id) { }

	// RVA: 0x4D6A30 Offset: 0x4D5030 VA: 0x1804D6A30
	public void Exit() { }

	// RVA: 0x4D6240 Offset: 0x4D4840 VA: 0x1804D6240
	public void ClearClicked() { }

	// RVA: 0x4D6440 Offset: 0x4D4A40 VA: 0x1804D6440
	private void Clear() { }

	// RVA: 0x4D7890 Offset: 0x4D5E90 VA: 0x1804D7890
	public void OnSaveClicked() { }

	// RVA: 0x4D7890 Offset: 0x4D5E90 VA: 0x1804D7890
	public void OnSaveEntityClicked() { }

	// RVA: 0x4D78B0 Offset: 0x4D5EB0 VA: 0x1804D78B0
	public void OnSaveServerWideClicked() { }

	// RVA: 0x4D78A0 Offset: 0x4D5EA0 VA: 0x1804D78A0
	public void OnSaveDefaultClicked() { }

	// RVA: 0x4D7AA0 Offset: 0x4D60A0 VA: 0x1804D7AA0
	public void Save(AIDesignScope scope) { }

	// RVA: 0x4D82D0 Offset: 0x4D68D0 VA: 0x1804D82D0
	public void ToggleFade() { }

	// RVA: 0x4D8320 Offset: 0x4D6920 VA: 0x1804D8320
	public void .ctor() { }

}

private sealed class UIAIDesignerScreen.<SetInitialStateContainer>d__18 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10818
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public UIAIDesignerScreen <>4__this; // 0x20
	public int id; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x4D5630 Offset: 0x4D3C30 VA: 0x1804D5630 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D57C0 Offset: 0x4D3DC0 VA: 0x1804D57C0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

public class UIChat : PriorityListComponent<UIChat> // TypeDefIndex: 10830
{	// Fields
	public GameObject inputArea; // 0x18
	public GameObject chatArea; // 0x20
	public TMP_InputField inputField; // 0x28
	public TextMeshProUGUI channelLabel; // 0x30
	public ScrollRect scrollRect; // 0x38
	public CanvasGroup canvasGroup; // 0x40
	public GameObjectRef chatItemPlayer; // 0x48
	public GameObject userPopup; // 0x50
	public static bool isOpen; // 0x0
	private Chat.ChatChannel activeChannel; // 0x58
	private UIChatPopup popup; // 0x60

	// Methods

	// RVA: 0x4DD050 Offset: 0x4DB650 VA: 0x1804DD050
	protected void Awake() { }

	// RVA: 0x4DE640 Offset: 0x4DCC40 VA: 0x1804DE640
	public static void Open() { }

	// RVA: 0x4DE590 Offset: 0x4DCB90 VA: 0x1804DE590 Slot: 6
	protected override void OnEnable() { }

	// RVA: 0x4DE200 Offset: 0x4DC800 VA: 0x1804DE200
	public void FocusInput() { }

	// RVA: 0x4DEBF0 Offset: 0x4DD1F0 VA: 0x1804DEBF0
	public void SetChannel(Chat.ChatChannel channel, bool autoSwitched = False) { }

	// RVA: 0x4DEA90 Offset: 0x4DD090 VA: 0x1804DEA90
	private void SetChannelLabel(Chat.ChatChannel channel) { }

	// RVA: 0x4DF150 Offset: 0x4DD750 VA: 0x1804DF150
	public void SubmitText() { }

	// RVA: 0x4DD6D0 Offset: 0x4DBCD0 VA: 0x1804DD6D0
	public bool ClickedInsideTransformOrChild(Transform t) { }

	// RVA: 0x4DD250 Offset: 0x4DB850 VA: 0x1804DD250
	public void Cancel() { }

	// RVA: 0x4DF650 Offset: 0x4DDC50 VA: 0x1804DF650
	private void TrimMessages() { }

	// RVA: 0x4DD620 Offset: 0x4DBC20 VA: 0x1804DD620
	private void ClearText() { }

	// RVA: 0x4DD530 Offset: 0x4DBB30 VA: 0x1804DD530
	public void ClearChat() { }

	// RVA: 0x4DF760 Offset: 0x4DDD60 VA: 0x1804DF760
	public void Update() { }

	// RVA: 0x4DD9A0 Offset: 0x4DBFA0 VA: 0x1804DD9A0
	private void CycleActiveChatChannel() { }

	// RVA: 0x4DCE80 Offset: 0x4DB480 VA: 0x1804DCE80
	public static void Add(Chat.ChatChannel channel, ulong steamid, string text, float volume) { }

	// RVA: 0x4DE2B0 Offset: 0x4DC8B0 VA: 0x1804DE2B0
	private void InternalAdd(Chat.ChatChannel channel, ulong steamid, string text, float volume) { }

	// RVA: 0x4DE5B0 Offset: 0x4DCBB0 VA: 0x1804DE5B0
	public static void OnMessageClicked(ChatEntry entry) { }

	// RVA: 0x4DEEA0 Offset: 0x4DD4A0 VA: 0x1804DEEA0
	public void ShowUserMenu(ChatEntry entry) { }

	// RVA: 0x4DE600 Offset: 0x4DCC00 VA: 0x1804DE600
	public void OpenMuteList() { }

	// RVA: 0x4DF7F0 Offset: 0x4DDDF0 VA: 0x1804DF7F0
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4DF730 Offset: 0x4DDD30 VA: 0x1804DF730
	private void <Cancel>b__19_0() { }

}

public class UIChatPopup : MonoBehaviour // TypeDefIndex: 10831
{	// Fields
	public TextMeshProUGUI TextToggleMute; // 0x18
	public TextMeshProUGUI TextToggleGlobalMute; // 0x20
	public Button MuteButton; // 0x28
	public Button ReportButton; // 0x30
	public GameObject InviteToTeamButton; // 0x38
	private ulong steamID; // 0x40
	private string text; // 0x48

	// Methods

	// RVA: 0x4DC420 Offset: 0x4DAA20 VA: 0x1804DC420
	public void Init(ChatEntry entry) { }

	// RVA: 0x4DCDF0 Offset: 0x4DB3F0 VA: 0x1804DCDF0
	private void Update() { }

	// RVA: 0x4DCC30 Offset: 0x4DB230 VA: 0x1804DCC30
	public void OnToggleMuteGlobalClicked() { }

	// RVA: 0x4DCB20 Offset: 0x4DB120 VA: 0x1804DCB20
	public void OnToggleMuteClicked() { }

	// RVA: 0x4DC810 Offset: 0x4DAE10 VA: 0x1804DC810
	public void OnInviteToTeamClicked() { }

	// RVA: 0x4DCD40 Offset: 0x4DB340 VA: 0x1804DCD40
	public void OnViewSteamProfileClicked() { }

	// RVA: 0x4DC740 Offset: 0x4DAD40 VA: 0x1804DC740
	public void OnCopyTextClicked() { }

	// RVA: 0x4DC5A0 Offset: 0x4DABA0 VA: 0x1804DC5A0
	public void OnClearChatClicked() { }

	// RVA: 0x4DC9A0 Offset: 0x4DAFA0 VA: 0x1804DC9A0
	public void OnReportClicked() { }

	// RVA: 0x4DC3B0 Offset: 0x4DA9B0 VA: 0x1804DC3B0
	public void Hide() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public interface CardTableUI.ICardGameSubUI // TypeDefIndex: 10879
{	// Properties
	public abstract int DynamicBetAmount { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_DynamicBetAmount();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void UpdateInGameUI(CardTableUI ui, CardGameController game);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string GetSecondaryInfo(CardTableUI ui, CardGameController game, out CardTableUI.InfoTextUI.Attitude attitude);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void UpdateInGameUI_NoPlayer(CardTableUI ui);

}

public class UIColorPickerButton : MonoBehaviour // TypeDefIndex: 10890
{	// Fields
	public Image Image; // 0x18
	public Color Color; // 0x20

	// Methods

	// RVA: 0x4DF830 Offset: 0x4DDE30 VA: 0x1804DF830
	public void .ctor() { }

}

public class UIFireworkDesignItem : MonoBehaviour // TypeDefIndex: 10891
{	// Fields
	public static readonly Translate.Phrase EmptyPhrase; // 0x0
	public static readonly Translate.Phrase UntitledPhrase; // 0x8
	public RustText Title; // 0x18
	public RustButton LoadButton; // 0x20
	public RustButton SaveButton; // 0x28
	public RustButton EraseButton; // 0x30
	public UIFireworkDesigner Designer; // 0x38
	public int Index; // 0x40
	private PatternFirework.SavedDesign _saved; // 0x48

	// Properties
	private string Key { get; }

	// Methods

	// RVA: 0x4E4CF0 Offset: 0x4E32F0 VA: 0x1804E4CF0
	private string get_Key() { }

	// RVA: 0x4E4860 Offset: 0x4E2E60 VA: 0x1804E4860
	public void OnEnable() { }

	// RVA: 0x4E4820 Offset: 0x4E2E20 VA: 0x1804E4820
	public void OnDisable() { }

	// RVA: 0x4E4790 Offset: 0x4E2D90 VA: 0x1804E4790
	public void Load() { }

	// RVA: 0x4E4980 Offset: 0x4E2F80 VA: 0x1804E4980
	public void Save() { }

	// RVA: 0x4E45E0 Offset: 0x4E2BE0 VA: 0x1804E45E0
	public void Erase() { }

	// RVA: 0x4E4B40 Offset: 0x4E3140 VA: 0x1804E4B40
	private void UpdateState() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0x4E4C40 Offset: 0x4E3240 VA: 0x1804E4C40
	private static void .cctor() { }

}

public class UIFireworkDesigner : UIDialog // TypeDefIndex: 10892
{	// Fields
	public RustInput Title; // 0x30
	public RustText StarsPlaced; // 0x38
	public RectTransform Canvas; // 0x40
	public RectTransform InnerCanvas; // 0x48
	public GameObject StarPrefab; // 0x50
	public UIFireworkDesigner.Tools Tool; // 0x58
	public Color SelectedColor; // 0x5C
	private PatternFirework _firework; // 0x70
	private Dictionary<int, UIFireworkStar> _stars; // 0x78

	// Methods

	// RVA: 0x4E56E0 Offset: 0x4E3CE0 VA: 0x1804E56E0
	public void Initialize(PatternFirework firework) { }

	// RVA: 0x4E5CE0 Offset: 0x4E42E0 VA: 0x1804E5CE0
	public void Save() { }

	// RVA: 0x4E5D50 Offset: 0x4E4350 VA: 0x1804E5D50
	public void SelectPlacer() { }

	// RVA: 0x4E5D60 Offset: 0x4E4360 VA: 0x1804E5D60
	public void SelectRemover() { }

	// RVA: 0x4E5D30 Offset: 0x4E4330 VA: 0x1804E5D30
	public void SelectColor(UIColorPickerButton colorButton) { }

	// RVA: 0x4E4E00 Offset: 0x4E3400 VA: 0x1804E4E00
	public void ClearCanvas() { }

	// RVA: 0x4E5840 Offset: 0x4E3E40 VA: 0x1804E5840
	private void PlaceStar(Vector2 localPosition, Color color) { }

	// RVA: 0x4E57F0 Offset: 0x4E3DF0 VA: 0x1804E57F0
	public void PlaceStar() { }

	// RVA: 0x4E5B60 Offset: 0x4E4160 VA: 0x1804E5B60
	public void RemoveStar(UIFireworkStar star) { }

	// RVA: 0x4E5D70 Offset: 0x4E4370 VA: 0x1804E5D70
	private void UpdateStarsPlacedCount() { }

	// RVA: 0x4E5240 Offset: 0x4E3840 VA: 0x1804E5240
	public Vector2 GetMousePositionOnCanvas() { }

	// RVA: 0x4E4D50 Offset: 0x4E3350 VA: 0x1804E4D50
	private Nullable<int> ChooseIndex() { }

	// RVA: 0x4E54D0 Offset: 0x4E3AD0 VA: 0x1804E54D0
	public void Import(PatternFirework.Design design) { }

	// RVA: 0x4E4F80 Offset: 0x4E3580 VA: 0x1804E4F80
	public PatternFirework.Design Export() { }

	// RVA: 0x4E53B0 Offset: 0x4E39B0 VA: 0x1804E53B0
	private Vector2 GetScaledPositionOnCanvas(Vector2 localPosition) { }

	// RVA: 0x4E5EE0 Offset: 0x4E44E0 VA: 0x1804E5EE0
	public void .ctor() { }

}

public enum UIFireworkDesigner.Tools // TypeDefIndex: 10893
{	// Fields
	public int value__; // 0x0
	public const UIFireworkDesigner.Tools Placer = 0;
	public const UIFireworkDesigner.Tools Remover = 1;

}

public class UIFireworkStar : EventTrigger // TypeDefIndex: 10894
{	// Fields
	public Image Image; // 0x20
	public RustText Text; // 0x28
	private UIFireworkDesigner _designer; // 0x30
	public int Index; // 0x38
	public Color Color; // 0x3C

	// Methods

	// RVA: 0x4E5F50 Offset: 0x4E4550 VA: 0x1804E5F50
	public void Initialize(UIFireworkDesigner designer, int index, Color color) { }

	// RVA: 0x4E6330 Offset: 0x4E4930 VA: 0x1804E6330
	private void SetColor(Color color) { }

	// RVA: 0x4E6140 Offset: 0x4E4740 VA: 0x1804E6140 Slot: 27
	public override void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x4E6060 Offset: 0x4E4660 VA: 0x1804E6060 Slot: 23
	public override void OnDrag(PointerEventData eventData) { }

	// RVA: 0x4BAE40 Offset: 0x4B9440 VA: 0x1804BAE40
	public void .ctor() { }

}

public class UIDialog : ListComponent<UIDialog> // TypeDefIndex: 10920
{	// Fields
	public SoundDefinition openSoundDef; // 0x18
	public SoundDefinition closeSoundDef; // 0x20
	public bool isClosing; // 0x28

	// Properties
	public static bool isOpen { get; }

	// Methods

	// RVA: 0x4E41E0 Offset: 0x4E27E0 VA: 0x1804E41E0
	public static bool get_isOpen() { }

	// RVA: 0x4E40E0 Offset: 0x4E26E0 VA: 0x1804E40E0 Slot: 8
	public virtual void OpenDialog() { }

	// RVA: 0x4E4000 Offset: 0x4E2600 VA: 0x1804E4000 Slot: 9
	public virtual void CloseDialog() { }

	// RVA: -1 Offset: -1
	public static T Spawn<T>(string prefab) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BA830 Offset: 0x15B8E30 VA: 0x1815BA830
	|-UIDialog.Spawn<ChangeSignText>
	|-UIDialog.Spawn<MLRSUIDialog>
	|-UIDialog.Spawn<MuteListController>
	|-UIDialog.Spawn<ReportBug>
	|-UIDialog.Spawn<ReportPlayer>
	|-UIDialog.Spawn<object>
	|-UIDialog.Spawn<UIMarketTerminal>
	|-UIDialog.Spawn<UITwitchTrophy>
	*/

	// RVA: 0x4E4180 Offset: 0x4E2780 VA: 0x1804E4180
	public void .ctor() { }

}

public class UIMapExplosion : MonoBehaviour // TypeDefIndex: 10963
{	// Methods

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class UIMapGenericRadius : MonoBehaviour // TypeDefIndex: 10964
{	// Fields
	public Image radialImage; // 0x18
	public Image outlineImage; // 0x20
	public float radius; // 0x28
	public CanvasGroup fade; // 0x30
	public RectTransform rect; // 0x38

	// Methods

	// RVA: 0x4EB680 Offset: 0x4E9C80 VA: 0x1804EB680
	public void UpdateColors(Color col, Color col2, float totalAlpha) { }

	// RVA: 0x4EB5A0 Offset: 0x4E9BA0 VA: 0x1804EB5A0
	public void SetRadius(float newRadius, bool force = False) { }

	// RVA: 0x4EB710 Offset: 0x4E9D10 VA: 0x1804EB710
	public void Update() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class UIMapVendingMachineMarker : MonoBehaviour // TypeDefIndex: 10965
{	// Fields
	public Color inStock; // 0x18
	public Color outOfStock; // 0x28
	public Image colorBackground; // 0x38
	public string displayName; // 0x40
	public Tooltip toolTip; // 0x48
	public RustButton button; // 0x50
	public bool isInStock; // 0x58
	public EntityRef<VendingMachine> vendingMachine; // 0x60
	public VendingMachine vendingMachineData; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<UIMapVendingMachineMarker> onClicked; // 0x0

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4ECC20 Offset: 0x4EB220 VA: 0x1804ECC20
	public static void add_onClicked(Action<UIMapVendingMachineMarker> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4ECCD0 Offset: 0x4EB2D0 VA: 0x1804ECCD0
	public static void remove_onClicked(Action<UIMapVendingMachineMarker> value) { }

	// RVA: 0x4EC1F0 Offset: 0x4EA7F0 VA: 0x1804EC1F0
	public void SetOutOfStock(bool stock) { }

	// RVA: 0x4EC250 Offset: 0x4EA850 VA: 0x1804EC250
	public void UpdateInfo(VendingMachine vendingMachineData) { }

	// RVA: 0x4EC150 Offset: 0x4EA750 VA: 0x1804EC150
	public void Clicked() { }

	// RVA: 0x4EC1B0 Offset: 0x4EA7B0 VA: 0x1804EC1B0
	public static void RemoveAllHandlers() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class UIMapVendingMachineMarkerCluster : MonoBehaviour // TypeDefIndex: 10966
{	// Fields
	public List<UIMapVendingMachineMarker> markers; // 0x18
	public GameObject OpenRoot; // 0x20
	public TextMeshProUGUI CountText; // 0x28
	public static UIMapVendingMachineMarkerCluster currentlyOpen; // 0x0
	private bool open; // 0x30

	// Methods

	// RVA: 0x4EBA50 Offset: 0x4EA050 VA: 0x1804EBA50
	private void OnEnable() { }

	// RVA: 0x4EBE80 Offset: 0x4EA480 VA: 0x1804EBE80
	public void UpdateDisplay(List<VendingMachine> vendingMachines, List<bool> outOfStock) { }

	// RVA: 0x4EB860 Offset: 0x4E9E60 VA: 0x1804EB860
	private UIMapVendingMachineMarker GetLine() { }

	// RVA: 0x4EBB00 Offset: 0x4EA100 VA: 0x1804EBB00
	public void ToggleOpen() { }

	// RVA: 0x4EC0E0 Offset: 0x4EA6E0 VA: 0x1804EC0E0
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4EBE50 Offset: 0x4EA450 VA: 0x1804EBE50
	private void <ToggleOpen>b__8_0() { }

}

public class UIPaintBox : MonoBehaviour // TypeDefIndex: 10967
{	// Fields
	public UIPaintBox.OnBrushChanged onBrushChanged; // 0x18
	public Brush brush; // 0x20

	// Methods

	// RVA: 0xA00EF0 Offset: 0x9FF4F0 VA: 0x180A00EF0
	public void UpdateBrushSize(int size) { }

	// RVA: 0xA01030 Offset: 0x9FF630 VA: 0x180A01030
	public void UpdateBrushTexture(Texture2D tex) { }

	// RVA: 0xA00E50 Offset: 0x9FF450 VA: 0x180A00E50
	public void UpdateBrushColor(Color col) { }

	// RVA: 0xA00DF0 Offset: 0x9FF3F0 VA: 0x180A00DF0
	public void UpdateBrushAlpha(float a) { }

	// RVA: 0xA00ED0 Offset: 0x9FF4D0 VA: 0x180A00ED0
	public void UpdateBrushEraser(bool b) { }

	// RVA: 0xA00DA0 Offset: 0x9FF3A0 VA: 0x180A00DA0
	private void OnChanged() { }

	// RVA: 0xA01090 Offset: 0x9FF690 VA: 0x180A01090
	public void .ctor() { }

}

public class UIPaintBox.OnBrushChanged : UnityEvent<Brush> // TypeDefIndex: 10968
{	// Methods

	// RVA: 0x9FE7F0 Offset: 0x9FCDF0 VA: 0x1809FE7F0
	public void .ctor() { }

}

public class UIBuffs : SingletonComponent<UIBuffs> // TypeDefIndex: 10971
{	// Fields
	public bool Enabled; // 0x18
	public Transform PrefabBuffIcon; // 0x20

	// Methods

	// RVA: 0x4DBCB0 Offset: 0x4DA2B0 VA: 0x1804DBCB0
	public void Refresh(PlayerModifiers modifiers) { }

	// RVA: 0x4DBE70 Offset: 0x4DA470 VA: 0x1804DBE70
	private void RemoveAll() { }

	// RVA: 0x4DC070 Offset: 0x4DA670 VA: 0x1804DC070
	public void .ctor() { }

}

public class UIBuffsIcon : SingletonComponent<UIBuffsIcon>, IPointerEnterHandler, IEventSystemHandler // TypeDefIndex: 10972
{	// Fields
	public TextMeshProUGUI Text; // 0x18
	public Tooltip ToolTip; // 0x20
	public CanvasGroup Group; // 0x28
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public string Buffs; // 0x30

	// Methods

	// RVA: 0x4DB550 Offset: 0x4D9B50 VA: 0x1804DB550 Slot: 9
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x4DB560 Offset: 0x4D9B60 VA: 0x1804DB560
	private void Refresh() { }

	// RVA: 0x4DB730 Offset: 0x4D9D30 VA: 0x1804DB730
	public void Refresh(PlayerModifiers modifiers) { }

	// RVA: 0x4DBC50 Offset: 0x4DA250 VA: 0x1804DBC50
	public void .ctor() { }

}

public class UICompass : MonoBehaviour // TypeDefIndex: 10973
{	// Fields
	public RawImage compassStrip; // 0x18
	public CanvasGroup compassGroup; // 0x20
	public CompassMapMarker CompassMarker; // 0x28
	public CompassMapMarker TeamLeaderCompassMarker; // 0x30
	public List<CompassMissionMarker> MissionMarkers; // 0x38
	private bool compassToggle; // 0x40
	private Material compassStripMaterial; // 0x48
	private Material compassStripMaterialInst; // 0x50

	// Properties
	private static BasePlayer LocalPlayerEntity { get; }

	// Methods

	// RVA: 0x4E07D0 Offset: 0x4DEDD0 VA: 0x1804E07D0
	private static BasePlayer get_LocalPlayerEntity() { }

	// RVA: 0x4E0420 Offset: 0x4DEA20 VA: 0x1804E0420
	private void OnEnable() { }

	// RVA: 0x4DFB10 Offset: 0x4DE110 VA: 0x1804DFB10
	public void CompassUpdate() { }

	// RVA: 0x4E0650 Offset: 0x4DEC50 VA: 0x1804E0650
	private void UpdateCompassMarker(Vector3 rot, CompassMapMarker marker, MapNote forNote) { }

	// RVA: 0x4E0510 Offset: 0x4DEB10 VA: 0x1804E0510
	private void UpdateCompassMarker(Vector3 rot, CompassMissionMarker marker, BaseMission.MissionInstance mission) { }

	// RVA: 0x4DF860 Offset: 0x4DDE60 VA: 0x1804DF860
	private void CalculateCompassPosition(Vector3 worldPosition, Vector3 eyeRot, out bool show, out float xPos) { }

	// RVA: 0x4E03C0 Offset: 0x4DE9C0 VA: 0x1804E03C0
	private void OnDisable() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class UIFadeOut : MonoBehaviour // TypeDefIndex: 10974
{	// Fields
	public float secondsToFadeOut; // 0x18
	public bool destroyOnFaded; // 0x1C
	public CanvasGroup targetGroup; // 0x20
	public float fadeDelay; // 0x28
	private float timeStarted; // 0x2C

	// Methods

	// RVA: 0x4E4470 Offset: 0x4E2A70 VA: 0x1804E4470
	private void Start() { }

	// RVA: 0x4E4490 Offset: 0x4E2A90 VA: 0x1804E4490
	private void Update() { }

	// RVA: 0x4E45C0 Offset: 0x4E2BC0 VA: 0x1804E45C0
	public void .ctor() { }

}

public class UIFishing : SingletonComponent<UIFishing> // TypeDefIndex: 10975
{	// Fields
	public Slider TensionLine; // 0x18
	public Image FillImage; // 0x20
	public Gradient FillGradient; // 0x28
	private float lerpedValue; // 0x30

	// Methods

	// RVA: 0x4E6380 Offset: 0x4E4980 VA: 0x1804E6380
	private void Start() { }

	// RVA: 0x4E63B0 Offset: 0x4E49B0 VA: 0x1804E63B0
	public void Toggle(bool state) { }

	// RVA: 0x4E6370 Offset: 0x4E4970 VA: 0x1804E6370
	public void ForceSetValue(float value) { }

	// RVA: 0x4E6450 Offset: 0x4E4A50 VA: 0x1804E6450
	public void UpdateInfo(float tension) { }

	// RVA: 0x4E6560 Offset: 0x4E4B60 VA: 0x1804E6560
	public void .ctor() { }

}

public class UIHUD : SingletonComponent<UIHUD>, IUIScreen // TypeDefIndex: 10976
{	// Fields
	public UIChat chatPanel; // 0x18
	public HudElement Hunger; // 0x20
	public HudElement Thirst; // 0x28
	public HudElement Health; // 0x30
	public HudElement PendingHealth; // 0x38
	public HudElement VehicleHealth; // 0x40
	public HudElement AnimalStamina; // 0x48
	public HudElement AnimalStaminaMax; // 0x50
	public RectTransform vitalsRect; // 0x58
	public Canvas healthCanvas; // 0x60
	public UICompass CompassWidget; // 0x68
	public GameObject KeyboardCaptureMode; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private CanvasGroup <canvasGroup>k__BackingField; // 0x78
	private bool visible; // 0x80

	// Properties
	public CanvasGroup canvasGroup { get; set; }
	private bool shouldShowHud { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E84B0 Offset: 0x4E6AB0 VA: 0x1804E84B0
	public CanvasGroup get_canvasGroup() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E87D0 Offset: 0x4E6DD0 VA: 0x1804E87D0
	private void set_canvasGroup(CanvasGroup value) { }

	// RVA: 0x4E7A40 Offset: 0x4E6040 VA: 0x1804E7A40 Slot: 6
	protected override void Awake() { }

	// RVA: 0x4E8100 Offset: 0x4E6700 VA: 0x1804E8100
	private void Update() { }

	// RVA: 0x4E7B80 Offset: 0x4E6180 VA: 0x1804E7B80
	private void UpdateVitals() { }

	// RVA: 0x4E84C0 Offset: 0x4E6AC0 VA: 0x1804E84C0
	private bool get_shouldShowHud() { }

	// RVA: 0x4E7AE0 Offset: 0x4E60E0 VA: 0x1804E7AE0 Slot: 8
	public void SetVisible(bool b) { }

	// RVA: 0x4E8450 Offset: 0x4E6A50 VA: 0x1804E8450
	public void .ctor() { }

}

public class UIRecordingInfo : SingletonComponent<UIRecordingInfo> // TypeDefIndex: 10977
{	// Fields
	public RustText CountdownText; // 0x18
	public Slider TapeProgressSlider; // 0x20
	public GameObject CountdownRoot; // 0x28
	public GameObject RecordingRoot; // 0x30
	public Transform Spinner; // 0x38
	public float SpinSpeed; // 0x40
	public Image CassetteImage; // 0x48
	private RecorderTool cachedRecorder; // 0x50

	// Methods

	// RVA: 0x4E6380 Offset: 0x4E4980 VA: 0x1804E6380
	private void Start() { }

	// RVA: 0xA03770 Offset: 0xA01D70 VA: 0x180A03770
	public void StartRecording(RecorderTool forRecorder) { }

	// RVA: 0xA037E0 Offset: 0xA01DE0 VA: 0x180A037E0
	public void StopRecording() { }

	// RVA: 0xA03830 Offset: 0xA01E30 VA: 0x180A03830
	private void Update() { }

	// RVA: 0xA03750 Offset: 0xA01D50 VA: 0x180A03750
	public void OnEscape() { }

	// RVA: 0xA03AA0 Offset: 0xA020A0 VA: 0x180A03AA0
	public void .ctor() { }

}

public class UIUnderlay : SingletonComponent<UIUnderlay> // TypeDefIndex: 10978
{	// Fields
	public GameObject damageDirectional; // 0x18
	public GameObject waterDirectional; // 0x20

	// Methods

	// RVA: 0xA05520 Offset: 0xA03B20 VA: 0x180A05520
	public void DirectionalDamage(Vector3 pos, DamageType dmgType, float damageTotal) { }

	// RVA: 0xA05030 Offset: 0xA03630 VA: 0x180A05030
	public void DirectionalDamage_OLD(Vector3 pos, DamageType dmgType) { }

	// RVA: 0xA05900 Offset: 0xA03F00 VA: 0x180A05900
	private GameObject GetDamageTypePrefab(DamageType dmgType) { }

	// RVA: 0xA05AE0 Offset: 0xA040E0 VA: 0x180A05AE0
	private Vector2 RectProjectEdge(Rect r, Vector2 v) { }

	// RVA: 0xA05C90 Offset: 0xA04290 VA: 0x180A05C90
	public void .ctor() { }

}

public class UIBlueprints : ListComponent<UIBlueprints> // TypeDefIndex: 10995
{	// Fields
	public GameObjectRef buttonPrefab; // 0x18
	public ScrollRect scrollRect; // 0x20
	public CanvasGroup ScrollRectCanvasGroup; // 0x28
	public InputField searchField; // 0x30
	public GameObject searchFieldPlaceholder; // 0x38
	public GameObject listAvailable; // 0x40
	public GameObject listLocked; // 0x48
	public GameObject Categories; // 0x50
	public VerticalLayoutGroup CategoryVerticalLayoutGroup; // 0x58
	public BlueprintCategoryButton FavouriteCategoryButton; // 0x60
	public bool needsResort; // 0x68
	private ItemCategory category; // 0x6C
	private List<BlueprintButton> buttons; // 0x70
	private BlueprintCategoryButton[] categoryButtons; // 0x78
	private static ItemCategory[] miscInclusive; // 0x0

	// Methods

	// RVA: 0x4D9490 Offset: 0x4D7A90 VA: 0x1804D9490
	public void ChangeCategory(string strCategory) { }

	// RVA: 0x4DB2A0 Offset: 0x4D98A0 VA: 0x1804DB2A0
	private void UpdateFlash() { }

	// RVA: 0x4DA610 Offset: 0x4D8C10 VA: 0x1804DA610
	private void RetireChildren(GameObject go) { }

	// RVA: 0x4DA3F0 Offset: 0x4D89F0 VA: 0x1804DA3F0 Slot: 6
	protected override void OnEnable() { }

	// RVA: 0x4DA1F0 Offset: 0x4D87F0 VA: 0x1804DA1F0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x4D99D0 Offset: 0x4D7FD0 VA: 0x1804D99D0
	public static IEnumerable<ItemBlueprint> GetForCategory(ItemCategory category) { }

	// RVA: 0x4D9980 Offset: 0x4D7F80 VA: 0x1804D9980
	public static IEnumerable<ItemBlueprint> GetCraftableForCategory(ItemCategory category) { }

	// RVA: 0x4D95D0 Offset: 0x4D7BD0 VA: 0x1804D95D0
	public static int CountCraftableForCategory(ItemCategory category) { }

	// RVA: 0x4D9630 Offset: 0x4D7C30 VA: 0x1804D9630
	public static int CountForCategory(ItemCategory category, bool onlyUnlocked = True) { }

	// RVA: 0x4DAA00 Offset: 0x4D9000 VA: 0x1804DAA00
	public void UpdateBlueprintList() { }

	// RVA: 0x4D9910 Offset: 0x4D7F10 VA: 0x1804D9910
	private BlueprintCategoryButton[] GetCategoryButtons() { }

	// RVA: 0x4DAD80 Offset: 0x4D9380 VA: 0x1804DAD80
	private void UpdateBlueprints(IEnumerable<ItemBlueprint> list) { }

	// RVA: 0x4DA430 Offset: 0x4D8A30 VA: 0x1804DA430
	public static void Refresh() { }

	// RVA: 0x4DA6E0 Offset: 0x4D8CE0 VA: 0x1804DA6E0
	public void Search(string search) { }

	// RVA: 0x4D9290 Offset: 0x4D7890 VA: 0x1804D9290
	public static void BounceFavouriteCategories() { }

	// RVA: 0x4D9470 Offset: 0x4D7A70 VA: 0x1804D9470
	public void BounceFavouriteCategory() { }

	// RVA: 0x4DB4B0 Offset: 0x4D9AB0 VA: 0x1804DB4B0
	public void .ctor() { }

	// RVA: 0x4DB430 Offset: 0x4D9A30 VA: 0x1804DB430
	private static void .cctor() { }

}

private sealed class UIBlueprints.<>c__DisplayClass20_0 // TypeDefIndex: 10996
{	// Fields
	public ItemCategory category; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4D5A40 Offset: 0x4D4040 VA: 0x1804D5A40
	internal bool <GetForCategory>b__3(ItemBlueprint x) { }

	// RVA: 0x4D5B50 Offset: 0x4D4150 VA: 0x1804D5B50
	internal bool <GetForCategory>b__6(ItemBlueprint x) { }

}

private sealed class UIBlueprints.<>c // TypeDefIndex: 10997
{	// Fields
	public static readonly UIBlueprints.<>c <>9; // 0x0
	public static Func<ItemBlueprint, bool> <>9__20_0; // 0x8
	public static Func<ItemBlueprint, bool> <>9__20_1; // 0x10
	public static Func<ItemBlueprint, int> <>9__20_2; // 0x18
	public static Func<ItemBlueprint, bool> <>9__20_4; // 0x20
	public static Func<ItemBlueprint, Rarity> <>9__20_5; // 0x28
	public static Func<ItemBlueprint, bool> <>9__20_7; // 0x30
	public static Func<ItemBlueprint, Rarity> <>9__20_8; // 0x38

	// Methods

	// RVA: 0x4D5F90 Offset: 0x4D4590 VA: 0x1804D5F90
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4D5830 Offset: 0x4D3E30 VA: 0x1804D5830
	internal bool <GetForCategory>b__20_0(ItemBlueprint x) { }

	// RVA: 0x4D58A0 Offset: 0x4D3EA0 VA: 0x1804D58A0
	internal bool <GetForCategory>b__20_1(ItemBlueprint x) { }

	// RVA: 0x4D5900 Offset: 0x4D3F00 VA: 0x1804D5900
	internal int <GetForCategory>b__20_2(ItemBlueprint y) { }

	// RVA: 0x4D5960 Offset: 0x4D3F60 VA: 0x1804D5960
	internal bool <GetForCategory>b__20_4(ItemBlueprint x) { }

	// RVA: 0x4D59C0 Offset: 0x4D3FC0 VA: 0x1804D59C0
	internal Rarity <GetForCategory>b__20_5(ItemBlueprint x) { }

	// RVA: 0x4D59E0 Offset: 0x4D3FE0 VA: 0x1804D59E0
	internal bool <GetForCategory>b__20_7(ItemBlueprint x) { }

	// RVA: 0x4D59C0 Offset: 0x4D3FC0 VA: 0x1804D59C0
	internal Rarity <GetForCategory>b__20_8(ItemBlueprint x) { }

}

private sealed class UIBlueprints.<>c__DisplayClass28_0 // TypeDefIndex: 10998
{	// Fields
	public string search; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4D5BF0 Offset: 0x4D41F0 VA: 0x1804D5BF0
	internal bool <Search>b__0(ItemBlueprint x) { }

}

public interface LootPanel.IHasLootPanel // TypeDefIndex: 11027
{	// Properties
	public abstract Translate.Phrase LootPanelTitle { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Translate.Phrase get_LootPanelTitle();

}

public class UIBelt : SingletonComponent<UIBelt> // TypeDefIndex: 11052
{	// Fields
	public List<ItemIcon> ItemIcons; // 0x18

	// Methods

	// RVA: 0x4D87B0 Offset: 0x4D6DB0 VA: 0x1804D87B0 Slot: 6
	protected override void Awake() { }

	// RVA: 0x4D88F0 Offset: 0x4D6EF0 VA: 0x1804D88F0
	public ItemIcon GetItemIconAtSlot(int slot) { }

	// RVA: 0x4D8960 Offset: 0x4D6F60 VA: 0x1804D8960
	public void .ctor() { }

}

private sealed class UIBelt.<>c // TypeDefIndex: 11053
{	// Fields
	public static readonly UIBelt.<>c <>9; // 0x0
	public static Func<ItemIcon, int> <>9__1_0; // 0x8

	// Methods

	// RVA: 0x4D5ED0 Offset: 0x4D44D0 VA: 0x1804D5ED0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4D5810 Offset: 0x4D3E10 VA: 0x1804D5810
	internal int <Awake>b__1_0(ItemIcon s) { }

}

public class UIContacts : SingletonComponent<UIContacts> // TypeDefIndex: 11054
{	// Fields
	public static bool isOpen; // 0x0
	public static float LastOpened; // 0x4
	public ContactsPanel contactsPanel; // 0x18
	private GameObject Inset; // 0x20
	private float returnX; // 0x28
	private static CanvasGroup canvasGroup; // 0x8
	private static GraphicRaycaster graphicRaycster; // 0x10
	private ItemIcon[] inventoryItemIcons; // 0x30

	// Methods

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x4E1440 Offset: 0x4DFA40 VA: 0x1804E1440
	public static void togglecontacts() { }

	// RVA: 0x4E0870 Offset: 0x4DEE70 VA: 0x1804E0870 Slot: 6
	protected override void Awake() { }

	// RVA: 0x4E0D90 Offset: 0x4DF390 VA: 0x1804E0D90
	public static void Open() { }

	// RVA: 0x4E1240 Offset: 0x4DF840 VA: 0x1804E1240
	public static void Toggle() { }

	// RVA: 0x4E0A90 Offset: 0x4DF090 VA: 0x1804E0A90
	public static void Close() { }

	// RVA: 0x4E1350 Offset: 0x4DF950 VA: 0x1804E1350
	private void Update() { }

	// RVA: 0x4E1020 Offset: 0x4DF620 VA: 0x1804E1020
	private bool ShouldShow() { }

	// RVA: 0x4E0D20 Offset: 0x4DF320 VA: 0x1804E0D20
	public void ContactsPressed() { }

	// RVA: 0x4E13E0 Offset: 0x4DF9E0 VA: 0x1804E13E0
	public void .ctor() { }

}

public class UICrafting : SingletonComponent<UICrafting> // TypeDefIndex: 11055
{	// Fields
	public static bool isOpen; // 0x0
	public static float LastOpened; // 0x4
	private static CanvasGroup canvasGroup; // 0x8
	private static GraphicRaycaster graphicRaycster; // 0x10
	private GameObject Inset; // 0x18
	private float returnX; // 0x20

	// Methods

	// RVA: 0x4E1D30 Offset: 0x4E0330 VA: 0x1804E1D30 Slot: 6
	protected override void Awake() { }

	// RVA: 0x4E2320 Offset: 0x4E0920 VA: 0x1804E2320
	public static void Open() { }

	// RVA: 0x4E2800 Offset: 0x4E0E00 VA: 0x1804E2800
	public static void Toggle() { }

	// RVA: 0x4E1F50 Offset: 0x4E0550 VA: 0x1804E1F50
	public static void Close() { }

	// RVA: 0x4E2910 Offset: 0x4E0F10 VA: 0x1804E2910
	private void Update() { }

	// RVA: 0x4E25A0 Offset: 0x4E0BA0 VA: 0x1804E25A0
	private bool ShouldShow() { }

	// RVA: 0x4E29A0 Offset: 0x4E0FA0 VA: 0x1804E29A0
	public void .ctor() { }

}

public class UIIntegerEntry : MonoBehaviour // TypeDefIndex: 11056
{	// Fields
	public InputField textEntry; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Action textChanged; // 0x20

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E9270 Offset: 0x4E7870 VA: 0x1804E9270
	public void add_textChanged(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E9310 Offset: 0x4E7910 VA: 0x1804E9310
	public void remove_textChanged(Action value) { }

	// RVA: 0x4E9120 Offset: 0x4E7720 VA: 0x1804E9120
	public void OnAmountTextChanged() { }

	// RVA: 0x4E91F0 Offset: 0x4E77F0 VA: 0x1804E91F0
	public void SetAmount(int amount) { }

	// RVA: 0x4E90E0 Offset: 0x4E76E0 VA: 0x1804E90E0
	public int GetIntAmount() { }

	// RVA: 0x4E9140 Offset: 0x4E7740 VA: 0x1804E9140
	public void PlusMinus(int delta) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class UIInventory : SingletonComponent<UIInventory> // TypeDefIndex: 11057
{	// Fields
	public TextMeshProUGUI PlayerName; // 0x18
	public static bool isOpen; // 0x0
	public static float LastOpened; // 0x4
	public VerticalLayoutGroup rightContents; // 0x20
	public GameObject QuickCraft; // 0x28
	public Transform InventoryIconContainer; // 0x30
	public ContactsPanel contactsPanel; // 0x38
	private static uint currentQuickLootContainerID; // 0x8
	private GameObject Inset; // 0x40
	private float returnX; // 0x48
	private static CanvasGroup canvasGroup; // 0x10
	private static GraphicRaycaster graphicRaycster; // 0x18
	private ItemIcon[] inventoryItemIcons; // 0x50
	public UnderwearSkinPicker underwearSkinPicker; // 0x58
	private static TimeSince lastCloseSoundPlay; // 0x20

	// Methods

	// RVA: 0x4E93B0 Offset: 0x4E79B0 VA: 0x1804E93B0 Slot: 6
	protected override void Awake() { }

	// RVA: 0x4EA010 Offset: 0x4E8610 VA: 0x1804EA010
	public static void Open(bool selectHeldItem = True) { }

	// RVA: 0x4EAEC0 Offset: 0x4E94C0 VA: 0x1804EAEC0
	public static void ToggleInventory() { }

	// RVA: 0x4E9760 Offset: 0x4E7D60 VA: 0x1804E9760
	public static void Close() { }

	// RVA: 0x4EA620 Offset: 0x4E8C20 VA: 0x1804EA620
	private static void PlayCloseSound() { }

	// RVA: 0x4E9F50 Offset: 0x4E8550 VA: 0x1804E9F50
	public static void OpenLoot(string lootType) { }

	// RVA: 0x4E9620 Offset: 0x4E7C20 VA: 0x1804E9620
	public static bool CanQuickLootItem(Item item, ItemContainerSource containerSource) { }

	// RVA: 0x4EB0E0 Offset: 0x4E96E0 VA: 0x1804EB0E0
	private void Update() { }

	// RVA: 0x4EAC60 Offset: 0x4E9260 VA: 0x1804EAC60
	private bool ShouldShow() { }

	// RVA: 0x4E9730 Offset: 0x4E7D30 VA: 0x1804E9730
	public void CloseUnderwearPicker() { }

	// RVA: 0x4EB040 Offset: 0x4E9640 VA: 0x1804EB040
	public void ToggleUnderwearPicker() { }

	// RVA: 0x4E9EE0 Offset: 0x4E84E0 VA: 0x1804E9EE0
	public void ContactsPressed() { }

	// RVA: 0x4EB3F0 Offset: 0x4E99F0 VA: 0x1804EB3F0
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

public interface IContainerSounds // TypeDefIndex: 11058
{	// Properties
	public abstract SoundDefinition OpenSound { get; }
	public abstract SoundDefinition CloseSound { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract SoundDefinition get_OpenSound();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract SoundDefinition get_CloseSound();

}

public class UIMixingTableItem : MonoBehaviour // TypeDefIndex: 11059
{	// Fields
	public Image ItemIcon; // 0x18
	public Tooltip ItemTooltip; // 0x20
	public RustText TextItemNameAndQuantity; // 0x28
	public UIMixingTableItemIngredient[] Ingredients; // 0x30

	// Methods

	// RVA: 0xA00BA0 Offset: 0x9FF1A0 VA: 0x180A00BA0
	public void Init(Recipe recipe) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class UIMixingTableItemIngredient : MonoBehaviour // TypeDefIndex: 11060
{	// Fields
	public Image ItemIcon; // 0x18
	public Text ItemCount; // 0x20
	public Tooltip ToolTip; // 0x28

	// Methods

	// RVA: 0xA00A50 Offset: 0x9FF050 VA: 0x180A00A50
	public void Init(Recipe.RecipeIngredient ingredient) { }

	// RVA: 0xA00A00 Offset: 0x9FF000 VA: 0x180A00A00
	public void InitBlank() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public interface VehicleModuleInformationPanel.IVehicleModuleInfo // TypeDefIndex: 11066
{	// Properties
	public abstract int SocketsTaken { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_SocketsTaken();

}

public class UIPaintableImage : MonoBehaviour // TypeDefIndex: 11190
{	// Fields
	public RawImage image; // 0x18
	public int texSize; // 0x20
	public Color clearColor; // 0x24
	public FilterMode filterMode; // 0x34
	public bool mipmaps; // 0x38
	public int imageNumber; // 0x3C
	public uint imageHash; // 0x40
	public bool isLocked; // 0x44
	public bool isLoading; // 0x45
	public bool isBlank; // 0x46
	public bool needsApply; // 0x47
	internal Texture2D texture; // 0x48

	// Properties
	public RectTransform rectTransform { get; }

	// Methods

	// RVA: 0xA021D0 Offset: 0xA007D0 VA: 0x180A021D0
	public RectTransform get_rectTransform() { }

	// RVA: 0xA01F40 Offset: 0xA00540 VA: 0x180A01F40
	private void Start() { }

	// RVA: 0xA020F0 Offset: 0xA006F0 VA: 0x180A020F0
	private void Update() { }

	// RVA: 0xA01D90 Offset: 0xA00390 VA: 0x180A01D90
	public void SetupTexture() { }

	// RVA: 0xA011B0 Offset: 0x9FF7B0 VA: 0x180A011B0
	public void Clear() { }

	// RVA: 0xA01CB0 Offset: 0xA002B0 VA: 0x180A01CB0
	private void OnDestroy() { }

	// RVA: 0xA01120 Offset: 0x9FF720 VA: 0x180A01120
	public void ClearTexture() { }

	// RVA: 0xA01C70 Offset: 0xA00270 VA: 0x180A01C70
	public void FromData(byte[] data) { }

	// RVA: 0xA02030 Offset: 0xA00630 VA: 0x180A02030
	public byte[] ToPng(BaseEntity ent) { }

	// RVA: 0xA01F60 Offset: 0xA00560 VA: 0x180A01F60
	public byte[] ToJpg(BaseEntity ent, int quality) { }

	// RVA: 0xA011C0 Offset: 0x9FF7C0 VA: 0x180A011C0
	public void DrawTexture(Vector2 pos, Vector2 size, Texture2D brush, Color textureColor, UIPaintableImage.DrawMode mode) { }

	// RVA: 0xA02180 Offset: 0xA00780 VA: 0x180A02180
	public void .ctor() { }

}

public enum UIPaintableImage.DrawMode // TypeDefIndex: 11191
{	// Fields
	public int value__; // 0x0
	public const UIPaintableImage.DrawMode AlphaBlended = 0;
	public const UIPaintableImage.DrawMode Additive = 1;
	public const UIPaintableImage.DrawMode Lighten = 2;
	public const UIPaintableImage.DrawMode Erase = 3;

}

public class UIParticle : BaseMonoBehaviour // TypeDefIndex: 11192
{	// Fields
	public Vector2 LifeTime; // 0x18
	public Vector2 Gravity; // 0x20
	public Vector2 InitialX; // 0x28
	public Vector2 InitialY; // 0x30
	public Vector2 InitialScale; // 0x38
	public Vector2 InitialDelay; // 0x40
	public Vector2 ScaleVelocity; // 0x48
	public Gradient InitialColor; // 0x50
	private float lifetime; // 0x58
	private float gravity; // 0x5C
	private Vector2 velocity; // 0x60
	private float scaleVelocity; // 0x68

	// Methods

	// RVA: 0xA02230 Offset: 0xA00830 VA: 0x180A02230
	public static void Add(UIParticle particleSource, RectTransform spawnPosition, RectTransform particleCanvas) { }

	// RVA: 0xA025C0 Offset: 0xA00BC0 VA: 0x180A025C0
	private void Start() { }

	// RVA: 0xA02850 Offset: 0xA00E50 VA: 0x180A02850
	private void Update() { }

	// RVA: 0xA02560 Offset: 0xA00B60 VA: 0x180A02560
	private void Die() { }

	// RVA: 0xA02B80 Offset: 0xA01180 VA: 0x180A02B80
	public void .ctor() { }

}

public static class UISound // TypeDefIndex: 11199
{	// Fields
	private static AudioSource source; // 0x30B0

	// Methods

	// RVA: 0xA04B20 Offset: 0xA03120 VA: 0x180A04B20
	private static AudioSource GetAudioSource() { }

	// RVA: 0xA04C40 Offset: 0xA03240 VA: 0x180A04C40
	public static void Play(AudioClip clip, float volume = 1) { }

}

public class UIPlayerPreviewControls : SingletonComponent<UIPlayerPreviewControls>, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler // TypeDefIndex: 11204
{	// Fields
	public float RotationSpeed; // 0x18
	public float RotationLerpSpeed; // 0x1C
	public float RotationStopLerpSpeed; // 0x20
	private bool rotating; // 0x24
	private bool pointerInControlArea; // 0x25
	private float rotationVelocity; // 0x28
	private float horizRotationPerc; // 0x2C
	private float startingRotation; // 0x30
	private Vector3 dragInputPos; // 0x34
	private Vector3 currentDragInputPos; // 0x40
	private Vector3 rotation; // 0x4C
	private Transform previewModel; // 0x58
	private CanvasGroup canvasGroup; // 0x60
	private bool showInventoryPlayer; // 0x68

	// Methods

	// RVA: 0xA02E70 Offset: 0xA01470 VA: 0x180A02E70 Slot: 6
	protected override void Awake() { }

	// RVA: 0xA03210 Offset: 0xA01810 VA: 0x180A03210 Slot: 8
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0xA03220 Offset: 0xA01820 VA: 0x180A03220 Slot: 9
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0xA033C0 Offset: 0xA019C0 VA: 0x180A033C0
	private void Update() { }

	// RVA: 0xA03300 Offset: 0xA01900 VA: 0x180A03300
	private void ToggleDisplay() { }

	// RVA: 0xA02C20 Offset: 0xA01220 VA: 0x180A02C20
	private void ApplyRotation() { }

	// RVA: 0xA03030 Offset: 0xA01630 VA: 0x180A03030
	private void HandleRotationControl() { }

	// RVA: 0xA03230 Offset: 0xA01830 VA: 0x180A03230
	public void ResetToDefault() { }

	// RVA: 0xA02F00 Offset: 0xA01500 VA: 0x180A02F00
	private Transform GetPlayerModel() { }

	// RVA: 0xA034F0 Offset: 0xA01AF0 VA: 0x180A034F0
	public void .ctor() { }

}

public class UIInvertedMaskImage : Image // TypeDefIndex: 11207
{	// Fields
	private Material cachedMaterial; // 0x100

	// Properties
	public override Material materialForRendering { get; }

	// Methods

	// RVA: 0x4EB4B0 Offset: 0x4E9AB0 VA: 0x1804EB4B0 Slot: 34
	public override Material get_materialForRendering() { }

	// RVA: 0x4EB450 Offset: 0x4E9A50 VA: 0x1804EB450
	public void .ctor() { }

}

public class UIAutoPanelCloser : MonoBehaviour // TypeDefIndex: 11245
{	// Fields
	public UIDialog Dialog; // 0x18

	// Methods

	// RVA: 0x4D8380 Offset: 0x4D6980 VA: 0x1804D8380
	private void Update() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class UIBackgroundBlur : ListComponent<UIBackgroundBlur>, IClientComponent // TypeDefIndex: 11246
{	// Fields
	public float amount; // 0x18

	// Properties
	public static float currentMax { get; }

	// Methods

	// RVA: 0x4D8610 Offset: 0x4D6C10 VA: 0x1804D8610
	public static float get_currentMax() { }

	// RVA: 0x4D85B0 Offset: 0x4D6BB0 VA: 0x1804D85B0
	public void .ctor() { }

}

public class UIBlackoutOverlay : MonoBehaviour // TypeDefIndex: 11247
{	// Fields
	public CanvasGroup group; // 0x18
	public static Dictionary<UIBlackoutOverlay.blackoutType, UIBlackoutOverlay> instances; // 0x0
	public UIBlackoutOverlay.blackoutType overlayType; // 0x20
	private Vector3 initialPosition; // 0x24
	private float myAlpha; // 0x30

	// Methods

	// RVA: 0x4D89C0 Offset: 0x4D6FC0 VA: 0x1804D89C0
	public static void AddOverlay(UIBlackoutOverlay.blackoutType type, UIBlackoutOverlay overlay) { }

	// RVA: 0x4D8C20 Offset: 0x4D7220 VA: 0x1804D8C20
	public static UIBlackoutOverlay Get(UIBlackoutOverlay.blackoutType type) { }

	// RVA: 0x4D8D00 Offset: 0x4D7300 VA: 0x1804D8D00
	public static void HideAll() { }

	// RVA: 0x4D8A80 Offset: 0x4D7080 VA: 0x1804D8A80
	private void Awake() { }

	// RVA: 0x4D8E60 Offset: 0x4D7460 VA: 0x1804D8E60
	public void ResetPosition() { }

	// RVA: 0x4D8FF0 Offset: 0x4D75F0 VA: 0x1804D8FF0
	public void SetPosition(Vector3 position) { }

	// RVA: 0x2FA9E0 Offset: 0x2F8FE0 VA: 0x1802FA9E0
	public Vector3 GetPosition() { }

	// RVA: 0x4D9090 Offset: 0x4D7690 VA: 0x1804D9090
	public void Update() { }

	// RVA: 0x4D8F40 Offset: 0x4D7540 VA: 0x1804D8F40
	public void SetAlpha(float alpha) { }

	// RVA: 0x4D8B90 Offset: 0x4D7190 VA: 0x1804D8B90
	public float GetAlpha() { }

	// RVA: 0x4D9210 Offset: 0x4D7810 VA: 0x1804D9210
	public void .ctor() { }

}

public enum UIBlackoutOverlay.blackoutType // TypeDefIndex: 11248
{	// Fields
	public int value__; // 0x0
	public const UIBlackoutOverlay.blackoutType FULLBLACK = 0;
	public const UIBlackoutOverlay.blackoutType BINOCULAR = 1;
	public const UIBlackoutOverlay.blackoutType SCOPE = 2;
	public const UIBlackoutOverlay.blackoutType HELMETSLIT = 3;
	public const UIBlackoutOverlay.blackoutType SNORKELGOGGLE = 4;
	public const UIBlackoutOverlay.blackoutType NVG = 5;
	public const UIBlackoutOverlay.blackoutType FULLWHITE = 6;
	public const UIBlackoutOverlay.blackoutType SUNGLASSES = 7;
	public const UIBlackoutOverlay.blackoutType NONE = 64;

}

public class UICameraOverlay : SingletonComponent<UICameraOverlay> // TypeDefIndex: 11249
{	// Fields
	public static readonly Translate.Phrase FocusOffText; // 0x0
	public static readonly Translate.Phrase FocusAutoText; // 0x8
	public static readonly Translate.Phrase FocusManualText; // 0x10
	public CanvasGroup CanvasGroup; // 0x18
	public RustText FocusModeLabel; // 0x20

	// Methods

	// RVA: 0x4DC220 Offset: 0x4DA820 VA: 0x1804DC220
	public void Show() { }

	// RVA: 0x4DC0D0 Offset: 0x4DA6D0 VA: 0x1804DC0D0
	public void Hide() { }

	// RVA: 0x4DC100 Offset: 0x4DA700 VA: 0x1804DC100
	public void SetFocusMode(CameraFocusMode mode) { }

	// RVA: 0x4DC350 Offset: 0x4DA950 VA: 0x1804DC350
	public void .ctor() { }

	// RVA: 0x4DC250 Offset: 0x4DA850 VA: 0x1804DC250
	private static void .cctor() { }

}

public class UIConversationScreen : SingletonComponent<UIConversationScreen>, IUIScreen // TypeDefIndex: 11250
{	// Fields
	public NeedsCursor needsCursor; // 0x18
	public RectTransform conversationPanel; // 0x20
	public RustText conversationSpeechBody; // 0x28
	public RustText conversationProviderName; // 0x30
	public RustButton[] responseButtons; // 0x38
	public RectTransform letterBoxTop; // 0x40
	public RectTransform letterBoxBottom; // 0x48
	protected CanvasGroup canvasGroup; // 0x50
	private int currentlyDisplayedSpeechIndex; // 0x58
	private bool visible; // 0x5C
	private LayoutGroup[] layoutGroups; // 0x60
	private bool wasTalking; // 0x68

	// Methods

	// RVA: 0x4E1560 Offset: 0x4DFB60 VA: 0x1804E1560 Slot: 6
	protected override void Awake() { }

	// RVA: 0x4E1AC0 Offset: 0x4E00C0 VA: 0x1804E1AC0 Slot: 8
	public void SetVisible(bool b) { }

	// RVA: 0x4E15E0 Offset: 0x4DFBE0 VA: 0x1804E15E0
	public void Exit() { }

	// RVA: 0x4E15F0 Offset: 0x4DFBF0 VA: 0x1804E15F0
	public void FastForward() { }

	// RVA: 0x4E1CC0 Offset: 0x4E02C0 VA: 0x1804E1CC0
	public void Update() { }

	// RVA: 0x4E1600 Offset: 0x4DFC00 VA: 0x1804E1600
	public void Refresh(bool force = False) { }

	// RVA: 0x4E1A00 Offset: 0x4E0000 VA: 0x1804E1A00
	public void ResponsePressed(int responseIndex) { }

	// RVA: 0x4E1CD0 Offset: 0x4E02D0 VA: 0x1804E1CD0
	public void .ctor() { }

}

public class UIDeathScreen : SingletonComponent<UIDeathScreen>, IUIScreen // TypeDefIndex: 11251
{	// Fields
	public LifeInfographic previousLifeInfographic; // 0x18
	public Animator screenAnimator; // 0x20
	public bool fadeIn; // 0x28
	public Button ReportCheatButton; // 0x30
	public MapView View; // 0x38
	public List<SleepingBagButton> sleepingBagButtons; // 0x40
	public UIDeathScreen.RespawnColourScheme[] RespawnColourSchemes; // 0x48
	public GameObject RespawnScrollGradient; // 0x50
	public ScrollRect RespawnScrollRect; // 0x58
	public ExpandedLifeStats ExpandedStats; // 0x60
	public CanvasGroup StreamerModeContainer; // 0x68
	protected CanvasGroup canvasGroup; // 0x70
	protected GraphicRaycaster graphicRaycaster; // 0x78
	protected NeedsCursor needsCursor; // 0x80
	private bool visible; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private RespawnInformation <currentRespawnInfo>k__BackingField; // 0x90

	// Properties
	public RespawnInformation currentRespawnInfo { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E3FE0 Offset: 0x4E25E0 VA: 0x1804E3FE0
	public RespawnInformation get_currentRespawnInfo() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E3FF0 Offset: 0x4E25F0 VA: 0x1804E3FF0
	private void set_currentRespawnInfo(RespawnInformation value) { }

	// RVA: 0x4E2A00 Offset: 0x4E1000 VA: 0x1804E2A00 Slot: 6
	protected override void Awake() { }

	// RVA: 0x4E30B0 Offset: 0x4E16B0 VA: 0x1804E30B0 Slot: 8
	public void SetVisible(bool b) { }

	// RVA: 0x4E2D10 Offset: 0x4E1310 VA: 0x1804E2D10
	private void OnEnable() { }

	// RVA: 0x4E2E80 Offset: 0x4E1480 VA: 0x1804E2E80
	public void OnRespawn() { }

	// RVA: 0x4E38E0 Offset: 0x4E1EE0 VA: 0x1804E38E0
	private void UpdateRespawnInformation(RespawnInformation info) { }

	// RVA: 0x4E3B90 Offset: 0x4E2190 VA: 0x1804E3B90
	private void UpdateRespawnOptions(List<RespawnInformation.SpawnOptions> spawnOptions) { }

	// RVA: 0x4E2C30 Offset: 0x4E1230 VA: 0x1804E2C30
	private SleepingBagButton GetSleepingBagButton() { }

	// RVA: 0x4E2F10 Offset: 0x4E1510 VA: 0x1804E2F10
	public void PopulateDeathInfo() { }

	// RVA: 0x4E2A20 Offset: 0x4E1020 VA: 0x1804E2A20
	public void EnableInteraction() { }

	// RVA: 0x4E2DA0 Offset: 0x4E13A0 VA: 0x1804E2DA0
	public static void OnRespawnInformation(RespawnInformation info) { }

	// RVA: 0x4E2F30 Offset: 0x4E1530 VA: 0x1804E2F30
	public void ReportCheater() { }

	// RVA: 0x4E2AC0 Offset: 0x4E10C0 VA: 0x1804E2AC0
	public UIDeathScreen.RespawnColourScheme GetRespawnColourScheme(RespawnInformation.SpawnOptions option) { }

	// RVA: 0x4E2A50 Offset: 0x4E1050 VA: 0x1804E2A50
	public UIDeathScreen.RespawnColourScheme GetRespawnColourScheme(int index) { }

	// RVA: 0x4E37F0 Offset: 0x4E1DF0 VA: 0x1804E37F0
	public void UpdateBottomScrollGradient() { }

	// RVA: 0x4E3F50 Offset: 0x4E2550 VA: 0x1804E3F50
	public void .ctor() { }

}

public struct UIDeathScreen.RespawnColourScheme // TypeDefIndex: 11252
{	// Fields
	public Color BackgroundColour; // 0x0
	public Color CircleRimColour; // 0x10
	public Color CircleFillColour; // 0x20

}

public class UIEscapeCapture : ListComponent<UIEscapeCapture> // TypeDefIndex: 11253
{	// Fields
	public UnityEvent onEscape; // 0x18

	// Methods

	// RVA: 0x4E4260 Offset: 0x4E2860 VA: 0x1804E4260
	public static bool EscapePressed() { }

	// RVA: 0x4E43E0 Offset: 0x4E29E0 VA: 0x1804E43E0
	public void .ctor() { }

}

public class UIFogOverlay : MonoBehaviour // TypeDefIndex: 11254
{	// Fields
	public static UIFogOverlay Instance; // 0x0
	public CanvasGroup group; // 0x18
	public Color baseColor; // 0x20
	public Image overlayImage; // 0x30

	// Methods

	// RVA: 0x4E6630 Offset: 0x4E4C30 VA: 0x1804E6630
	public static void SetAlpha(float alpha) { }

	// RVA: 0x4E65C0 Offset: 0x4E4BC0 VA: 0x1804E65C0
	public void OnEnable() { }

	// RVA: 0x4E6690 Offset: 0x4E4C90 VA: 0x1804E6690
	public void Update() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class UIGene : MonoBehaviour // TypeDefIndex: 11255
{	// Fields
	public GameObject Child; // 0x18
	public Color PositiveColour; // 0x20
	public Color NegativeColour; // 0x30
	public Color PositiveTextColour; // 0x40
	public Color NegativeTextColour; // 0x50
	public Image ImageBG; // 0x60
	public Text TextGene; // 0x68

	// Methods

	// RVA: 0x4E6DD0 Offset: 0x4E53D0 VA: 0x1804E6DD0
	public void Init(GrowableGene gene) { }

	// RVA: 0x4E6CE0 Offset: 0x4E52E0 VA: 0x1804E6CE0
	public void InitPrevious(GrowableGene gene) { }

	// RVA: 0x4E6CB0 Offset: 0x4E52B0 VA: 0x1804E6CB0
	public void Hide() { }

	// RVA: 0x4E6ED0 Offset: 0x4E54D0 VA: 0x1804E6ED0
	public void Show() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class UIGenesDisplay : MonoBehaviour // TypeDefIndex: 11256
{	// Fields
	public UIGene[] GeneUI; // 0x18
	public Text[] TextLinks; // 0x20
	public Text[] TextDiagLinks; // 0x28

	// Methods

	// RVA: 0x4E7630 Offset: 0x4E5C30 VA: 0x1804E7630
	public void Init(GrowableGenes genes) { }

	// RVA: 0x4E6F00 Offset: 0x4E5500 VA: 0x1804E6F00
	public void InitDualRow(GrowableGenes genes, bool firstRow) { }

	// RVA: 0x4E6F20 Offset: 0x4E5520 VA: 0x1804E6F20
	private void InitFirstRow(GrowableGenes genes) { }

	// RVA: 0x4E7260 Offset: 0x4E5860 VA: 0x1804E7260
	private void InitSecondRow(GrowableGenes genes) { }

	// RVA: 0x4E7820 Offset: 0x4E5E20 VA: 0x1804E7820
	private void ShowDiagLink(int index, float rotation, GrowableGene nextGene) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class UIIngame : SingletonComponent<UIIngame> // TypeDefIndex: 11257
{	// Methods

	// RVA: 0x4E8D90 Offset: 0x4E7390 VA: 0x1804E8D90
	private void Update() { }

	// RVA: 0x4E87E0 Offset: 0x4E6DE0 VA: 0x1804E87E0
	private IUIScreen DetermineActiveUI() { }

	// RVA: 0x4E9080 Offset: 0x4E7680 VA: 0x1804E9080
	public void .ctor() { }

}

public class UIPrefab : MonoBehaviour // TypeDefIndex: 11258
{	// Fields
	public GameObject prefabSource; // 0x18
	internal GameObject createdGameObject; // 0x20

	// Methods

	// RVA: 0xA03560 Offset: 0xA01B60 VA: 0x180A03560
	private void Awake() { }

	// RVA: 0xA036A0 Offset: 0xA01CA0 VA: 0x180A036A0
	public void SetVisible(bool visible) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public abstract class UIRoot : MonoBehaviour // TypeDefIndex: 11259
{	// Fields
	private GraphicRaycaster[] graphicRaycasters; // 0x18
	public Canvas overlayCanvas; // 0x20

	// Methods

	// RVA: 0xA03F10 Offset: 0xA02510 VA: 0x180A03F10
	private void ToggleRaycasters(bool state) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0xA03EC0 Offset: 0xA024C0 VA: 0x180A03EC0 Slot: 5
	protected virtual void Start() { }

	// RVA: 0x95FF30 Offset: 0x95E530 VA: 0x18095FF30
	protected void Update() { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void Refresh();

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	protected void .ctor() { }

}

public class UIRootPixel : UIRoot // TypeDefIndex: 11260
{	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 6
	protected override void Refresh() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class UIRootScaled : UIRoot // TypeDefIndex: 11261
{	// Fields
	private static UIRootScaled Instance; // 0x0
	public bool OverrideReference; // 0x28
	public Vector2 TargetReference; // 0x2C
	public CanvasScaler scaler; // 0x38

	// Properties
	public static Canvas DragOverlayCanvas { get; }

	// Methods

	// RVA: 0xA03E50 Offset: 0xA02450 VA: 0x180A03E50
	public static Canvas get_DragOverlayCanvas() { }

	// RVA: 0xA03B00 Offset: 0xA02100 VA: 0x180A03B00 Slot: 4
	protected override void Awake() { }

	// RVA: 0xA03B60 Offset: 0xA02160 VA: 0x180A03B60 Slot: 6
	protected override void Refresh() { }

	// RVA: 0xA03E00 Offset: 0xA02400 VA: 0x180A03E00
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

public class UIScale : MonoBehaviour, IClientComponent // TypeDefIndex: 11262
{	// Fields
	public CanvasScaler scaler; // 0x18

	// Methods

	// RVA: 0xA03FC0 Offset: 0xA025C0 VA: 0x180A03FC0
	private void Update() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class UIScalerOverride : MonoBehaviour // TypeDefIndex: 11263
{	// Fields
	public AnimationCurve scaleCurve; // 0x18
	private CanvasScaler rootScaler; // 0x20
	private Canvas rootCanvas; // 0x28
	private Vector3 defaultScale; // 0x30

	// Methods

	// RVA: 0xA04160 Offset: 0xA02760 VA: 0x180A04160
	private void Start() { }

	// RVA: 0xA04210 Offset: 0xA02810 VA: 0x180A04210
	private void Update() { }

	// RVA: 0xA043A0 Offset: 0xA029A0 VA: 0x180A043A0
	public void .ctor() { }

}

public class UIScopeOverlay : MonoBehaviour // TypeDefIndex: 11264
{	// Fields
	public CanvasGroup group; // 0x18
	public static UIScopeOverlay instance; // 0x0
	public Image scopeImage; // 0x20
	private Vector3 initialPosition; // 0x28

	// Methods

	// RVA: 0xA04780 Offset: 0xA02D80 VA: 0x180A04780
	public void SetScopeMaterial(Material newMat) { }

	// RVA: 0xA04440 Offset: 0xA02A40 VA: 0x180A04440
	private void Awake() { }

	// RVA: 0xA046E0 Offset: 0xA02CE0 VA: 0x180A046E0
	public void SetPosition(Vector3 position) { }

	// RVA: 0x2FA9E0 Offset: 0x2F8FE0 VA: 0x1802FA9E0
	public Vector3 GetPosition() { }

	// RVA: 0xA04550 Offset: 0xA02B50 VA: 0x180A04550
	public void SetAlpha(float alpha) { }

	// RVA: 0xA044C0 Offset: 0xA02AC0 VA: 0x180A044C0
	public float GetAlpha() { }

	// RVA: 0xA047B0 Offset: 0xA02DB0 VA: 0x180A047B0
	public void .ctor() { }

}

public interface IUIScreen // TypeDefIndex: 11265
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetVisible(bool b);

}

public class UISleepingScreen : SingletonComponent<UISleepingScreen>, IUIScreen // TypeDefIndex: 11266
{	// Fields
	protected CanvasGroup canvasGroup; // 0x18
	private bool visible; // 0x20

	// Methods

	// RVA: 0xA04820 Offset: 0xA02E20 VA: 0x180A04820 Slot: 6
	protected override void Awake() { }

	// RVA: 0xA04880 Offset: 0xA02E80 VA: 0x180A04880 Slot: 8
	public void SetVisible(bool b) { }

	// RVA: 0xA04940 Offset: 0xA02F40 VA: 0x180A04940
	public void .ctor() { }

}

public class UISoundPlayer : MonoBehaviour // TypeDefIndex: 11267
{	// Methods

	// RVA: 0xA049E0 Offset: 0xA02FE0 VA: 0x180A049E0
	public void PlaySound(AudioClip clip) { }

	// RVA: 0xA049A0 Offset: 0xA02FA0 VA: 0x180A049A0
	public void PlaySoundDef(SoundDefinition sound) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class UIVoiceIcon : MonoBehaviour // TypeDefIndex: 11268
{	// Fields
	public Text nameText; // 0x18
	public RawImage avatar; // 0x20

	// Methods

	// RVA: 0xA05CF0 Offset: 0xA042F0 VA: 0x180A05CF0
	public void Setup(ulong steamid, string name) { }

	// RVA: 0xA05E20 Offset: 0xA04420 VA: 0x180A05E20
	public void UpdateVolume(float volume) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class UIWounded : MonoBehaviour // TypeDefIndex: 11269
{	// Fields
	public CanvasGroup group; // 0x18

	// Methods

	// RVA: 0xA06130 Offset: 0xA04730 VA: 0x180A06130
	private void Update() { }

	// RVA: 0xA05F90 Offset: 0xA04590 VA: 0x180A05F90
	private bool ShouldShow() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class UI_LocalVoice : PriorityListComponent<UI_LocalVoice> // TypeDefIndex: 11270
{	// Fields
	public CanvasGroup voiceCanvas; // 0x18
	public CanvasGroup levelImage; // 0x20

	// Methods

	// RVA: 0xA06300 Offset: 0xA04900 VA: 0x180A06300 Slot: 6
	protected override void OnEnable() { }

	// RVA: 0xA06370 Offset: 0xA04970 VA: 0x180A06370
	public void SetRecording(bool b) { }

	// RVA: 0xA06350 Offset: 0xA04950 VA: 0x180A06350
	public void SetLevel(float f) { }

	// RVA: 0xA063A0 Offset: 0xA049A0 VA: 0x180A063A0
	public void .ctor() { }

}

public interface IDraggable // TypeDefIndex: 11272
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object GetDragData();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string GetDragType();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Sprite GetDragSprite();

}

public interface IVitalNotice // TypeDefIndex: 11281
{	// Properties
	public abstract bool IsActive { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Refresh();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_IsActive();

}

public interface IInventoryChanged // TypeDefIndex: 11378
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnInventoryChanged();

}

public interface IViewModeChanged // TypeDefIndex: 11379
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnViewModeChanged();

}

public interface IClothingChanged // TypeDefIndex: 11380
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnClothingChanged();

}

public interface IViewModelUpdated // TypeDefIndex: 11381
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnViewModelUpdated();

}

public interface IBlueprintsChanged // TypeDefIndex: 11382
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnBlueprintsChanged();

}

public interface IItemAmountChanged // TypeDefIndex: 11383
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnItemAmountChanged();

}

public interface IItemIconChanged // TypeDefIndex: 11384
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnItemIconChanged();

}

public interface IProvider // TypeDefIndex: 11675
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Info GetMenuInformation(GameObject primaryObject, BasePlayer player);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract List<Option> GetMenuItems(BasePlayer player);

}

public static class UIEx // TypeDefIndex: 11710
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1128FF0 Offset: 0x11275F0 VA: 0x181128FF0
	public static Vector2 Unpivot(RectTransform rect, Vector2 localPos) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1128C90 Offset: 0x1127290 VA: 0x181128C90
	public static void CenterOnPosition(ScrollRect scrollrect, Vector2 pos) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1128FA0 Offset: 0x11275A0 VA: 0x181128FA0
	public static void RebuildHackUnity2019(Image image) { }

}

public class UICircle : UIPrimitiveBase // TypeDefIndex: 11716
{	// Fields
	[TooltipAttribute] // RVA: 0xD97F0 Offset: 0xD8BF0 VA: 0x1800D97F0
	public bool ArcInvert; // 0xF0
	[TooltipAttribute] // RVA: 0xD9A60 Offset: 0xD8E60 VA: 0x1800D9A60
	[RangeAttribute] // RVA: 0xD9A60 Offset: 0xD8E60 VA: 0x1800D9A60
	public float Arc; // 0xF4
	[TooltipAttribute] // RVA: 0xD9B40 Offset: 0xD8F40 VA: 0x1800D9B40
	[RangeAttribute] // RVA: 0xD9B40 Offset: 0xD8F40 VA: 0x1800D9B40
	public int ArcSteps; // 0xF8
	[TooltipAttribute] // RVA: 0xD9D30 Offset: 0xD9130 VA: 0x1800D9D30
	[RangeAttribute] // RVA: 0xD9D30 Offset: 0xD9130 VA: 0x1800D9D30
	public int ArcRotation; // 0xFC
	[TooltipAttribute] // RVA: 0xD9E40 Offset: 0xD9240 VA: 0x1800D9E40
	[RangeAttribute] // RVA: 0xD9E40 Offset: 0xD9240 VA: 0x1800D9E40
	public float Progress; // 0x100
	private float _progress; // 0x104
	public Color ProgressColor; // 0x108
	public bool Fill; // 0x118
	public float Thickness; // 0x11C
	public int Padding; // 0x120
	private List<int> indices; // 0x128
	private List<UIVertex> vertices; // 0x130
	private Vector2 uvCenter; // 0x138

	// Methods

	// RVA: 0x11E8F50 Offset: 0x11E7550 VA: 0x1811E8F50 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x11E9B90 Offset: 0x11E8190 VA: 0x1811E9B90
	public void SetProgress(float progress) { }

	// RVA: 0x1133E10 Offset: 0x1132410 VA: 0x181133E10
	public void SetArcSteps(int steps) { }

	// RVA: 0x11E9B30 Offset: 0x11E8130 VA: 0x1811E9B30
	public void SetInvertArc(bool invert) { }

	// RVA: 0x11E9AF0 Offset: 0x11E80F0 VA: 0x1811E9AF0
	public void SetArcRotation(int rotation) { }

	// RVA: 0x11E9B10 Offset: 0x11E8110 VA: 0x1811E9B10
	public void SetFill(bool fill) { }

	// RVA: 0x1133E30 Offset: 0x1132430 VA: 0x181133E30
	public void SetBaseColor(Color color) { }

	// RVA: 0x1133E70 Offset: 0x1132470 VA: 0x181133E70
	public void UpdateBaseAlpha(float value) { }

	// RVA: 0x11E9B70 Offset: 0x11E8170 VA: 0x1811E9B70
	public void SetProgressColor(Color color) { }

	// RVA: 0x11E9BD0 Offset: 0x11E81D0 VA: 0x1811E9BD0
	public void UpdateProgressAlpha(float value) { }

	// RVA: 0x11E9B50 Offset: 0x11E8150 VA: 0x1811E9B50
	public void SetPadding(int padding) { }

	// RVA: 0x11E9BB0 Offset: 0x11E81B0 VA: 0x1811E9BB0
	public void SetThickness(int thickness) { }

	// RVA: 0x11E9BF0 Offset: 0x11E81F0 VA: 0x1811E9BF0
	public void .ctor() { }

}

public class UICircleSimple : UIPrimitiveBase // TypeDefIndex: 11717
{	// Fields
	[TooltipAttribute] // RVA: 0xD9B40 Offset: 0xD8F40 VA: 0x1800D9B40
	[RangeAttribute] // RVA: 0xD9B40 Offset: 0xD8F40 VA: 0x1800D9B40
	public int ArcSteps; // 0xF0
	public bool Fill; // 0xF4
	public float Thickness; // 0xF8
	public bool ThicknessIsOutside; // 0xFC
	private List<int> indices; // 0x100
	private List<UIVertex> vertices; // 0x108
	private Vector2 uvCenter; // 0x110

	// Methods

	// RVA: 0x11E8270 Offset: 0x11E6870 VA: 0x1811E8270 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x11E8DE0 Offset: 0x11E73E0 VA: 0x1811E8DE0
	public void SetArcSteps(int steps) { }

	// RVA: 0x11E8E00 Offset: 0x11E7400 VA: 0x1811E8E00
	public void SetFill(bool fill) { }

	// RVA: 0x1133E30 Offset: 0x1132430 VA: 0x181133E30
	public void SetBaseColor(Color color) { }

	// RVA: 0x1133E70 Offset: 0x1132470 VA: 0x181133E70
	public void UpdateBaseAlpha(float value) { }

	// RVA: 0x11E8E20 Offset: 0x11E7420 VA: 0x1811E8E20
	public void SetThickness(int thickness) { }

	// RVA: 0x11E8E40 Offset: 0x11E7440 VA: 0x1811E8E40
	public void .ctor() { }

}

public class UICornerCut : UIPrimitiveBase // TypeDefIndex: 11718
{	// Fields
	public Vector2 cornerSize; // 0xF0
	[HeaderAttribute] // RVA: 0xDA170 Offset: 0xD9570 VA: 0x1800DA170
	[SerializeField] // RVA: 0xDA170 Offset: 0xD9570 VA: 0x1800DA170
	private bool m_cutUL; // 0xF8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_cutUR; // 0xF9
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_cutLL; // 0xFA
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_cutLR; // 0xFB
	[TooltipAttribute] // RVA: 0xDA3A0 Offset: 0xD97A0 VA: 0x1800DA3A0
	[SerializeField] // RVA: 0xDA3A0 Offset: 0xD97A0 VA: 0x1800DA3A0
	private bool m_makeColumns; // 0xFC
	[HeaderAttribute] // RVA: 0xDA670 Offset: 0xD9A70 VA: 0x1800DA670
	[SerializeField] // RVA: 0xDA670 Offset: 0xD9A70 VA: 0x1800DA670
	private bool m_useColorUp; // 0xFD
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Color32 m_colorUp; // 0x100
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_useColorDown; // 0x104
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Color32 m_colorDown; // 0x108

	// Properties
	public bool CutUL { get; set; }
	public bool CutUR { get; set; }
	public bool CutLL { get; set; }
	public bool CutLR { get; set; }
	public bool MakeColumns { get; set; }
	public bool UseColorUp { get; set; }
	public Color32 ColorUp { get; set; }
	public bool UseColorDown { get; set; }
	public Color32 ColorDown { get; set; }

	// Methods

	// RVA: 0x11EAA10 Offset: 0x11E9010 VA: 0x1811EAA10
	public bool get_CutUL() { }

	// RVA: 0x11EAA70 Offset: 0x11E9070 VA: 0x1811EAA70
	public void set_CutUL(bool value) { }

	// RVA: 0x11EAA20 Offset: 0x11E9020 VA: 0x1811EAA20
	public bool get_CutUR() { }

	// RVA: 0x11EAA90 Offset: 0x11E9090 VA: 0x1811EAA90
	public void set_CutUR(bool value) { }

	// RVA: 0x11EA9F0 Offset: 0x11E8FF0 VA: 0x1811EA9F0
	public bool get_CutLL() { }

	// RVA: 0x11EAA30 Offset: 0x11E9030 VA: 0x1811EAA30
	public void set_CutLL(bool value) { }

	// RVA: 0x11EAA00 Offset: 0x11E9000 VA: 0x1811EAA00
	public bool get_CutLR() { }

	// RVA: 0x11EAA50 Offset: 0x11E9050 VA: 0x1811EAA50
	public void set_CutLR(bool value) { }

	// RVA: 0x112CE20 Offset: 0x112B420 VA: 0x18112CE20
	public bool get_MakeColumns() { }

	// RVA: 0x112CED0 Offset: 0x112B4D0 VA: 0x18112CED0
	public void set_MakeColumns(bool value) { }

	// RVA: 0x112CE00 Offset: 0x112B400 VA: 0x18112CE00
	public bool get_UseColorUp() { }

	// RVA: 0x11EAAC0 Offset: 0x11E90C0 VA: 0x1811EAAC0
	public void set_UseColorUp(bool value) { }

	// RVA: 0xC74210 Offset: 0xC72810 VA: 0x180C74210
	public Color32 get_ColorUp() { }

	// RVA: 0xC74350 Offset: 0xC72950 VA: 0x180C74350
	public void set_ColorUp(Color32 value) { }

	// RVA: 0x112FBE0 Offset: 0x112E1E0 VA: 0x18112FBE0
	public bool get_UseColorDown() { }

	// RVA: 0x11EAAB0 Offset: 0x11E90B0 VA: 0x1811EAAB0
	public void set_UseColorDown(bool value) { }

	// RVA: 0x88D820 Offset: 0x88BE20 VA: 0x18088D820
	public Color32 get_ColorDown() { }

	// RVA: 0x88D9C0 Offset: 0x88BFC0 VA: 0x18088D9C0
	public void set_ColorDown(Color32 value) { }

	// RVA: 0x11EA190 Offset: 0x11E8790 VA: 0x1811EA190 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x11E9E80 Offset: 0x11E8480 VA: 0x1811E9E80
	private static void AddSquare(Rect rect, Rect rectUV, Color32 color32, VertexHelper vh) { }

	// RVA: 0x11E9D50 Offset: 0x11E8350 VA: 0x1811E9D50
	private static void AddSquare(Vector2 a, Vector2 b, Vector2 c, Vector2 d, Rect rectUV, Color32 color32, VertexHelper vh) { }

	// RVA: 0x11EA010 Offset: 0x11E8610 VA: 0x1811EA010
	private static int AddVert(float x, float y, Rect area, Color32 color32, VertexHelper vh) { }

	// RVA: 0x11EA960 Offset: 0x11E8F60 VA: 0x1811EA960
	public void .ctor() { }

}

public class UIGoldenRatioRenderer : UILineRenderer // TypeDefIndex: 11719
{	// Fields
	private readonly List<Vector2> _points; // 0x118
	private readonly List<Rect> _rects; // 0x120
	private int canvasWidth; // 0x128
	private int canvasHeight; // 0x12C
	public float lineThickness2; // 0x130

	// Methods

	// RVA: 0x1129830 Offset: 0x1127E30 VA: 0x181129830
	private void DrawSpiral(VertexHelper vh) { }

	// RVA: 0x11290B0 Offset: 0x11276B0 VA: 0x1811290B0
	private void DrawPhiRectangles(VertexHelper vh, List<Vector2> points, float x, float y, float width, float height, UIGoldenRatioRenderer.Orientations orientation) { }

	// RVA: 0x1129CE0 Offset: 0x11282E0 VA: 0x181129CE0 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x1129370 Offset: 0x1127970 VA: 0x181129370
	private void DrawRect(VertexHelper vh, Rect rect) { }

	// RVA: 0x112A150 Offset: 0x1128750 VA: 0x18112A150
	public void .ctor() { }

}

private enum UIGoldenRatioRenderer.Orientations // TypeDefIndex: 11720
{	// Fields
	public int value__; // 0x0
	public const UIGoldenRatioRenderer.Orientations Left = 0;
	public const UIGoldenRatioRenderer.Orientations Top = 1;
	public const UIGoldenRatioRenderer.Orientations Right = 2;
	public const UIGoldenRatioRenderer.Orientations Bottom = 3;

}

public class UIGridRenderer : UILineRenderer // TypeDefIndex: 11721
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int m_GridColumns; // 0x118
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int m_GridRows; // 0x11C

	// Properties
	public int GridColumns { get; set; }
	public int GridRows { get; set; }

	// Methods

	// RVA: 0x92DF60 Offset: 0x92C560 VA: 0x18092DF60
	public int get_GridColumns() { }

	// RVA: 0x112A7F0 Offset: 0x1128DF0 VA: 0x18112A7F0
	public void set_GridColumns(int value) { }

	// RVA: 0x107ABF0 Offset: 0x10791F0 VA: 0x18107ABF0
	public int get_GridRows() { }

	// RVA: 0x112A810 Offset: 0x1128E10 VA: 0x18112A810
	public void set_GridRows(int value) { }

	// RVA: 0x112A250 Offset: 0x1128850 VA: 0x18112A250 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x112A770 Offset: 0x1128D70 VA: 0x18112A770
	public void .ctor() { }

}

public class UILineRenderer : UIPrimitiveBase // TypeDefIndex: 11722
{	// Fields
	private const float MIN_MITER_JOIN = 0,2617994;
	private const float MIN_BEVEL_NICE_JOIN = 0,5235988;
	private static Vector2 UV_TOP_LEFT; // 0x0
	private static Vector2 UV_BOTTOM_LEFT; // 0x8
	private static Vector2 UV_TOP_CENTER_LEFT; // 0x10
	private static Vector2 UV_TOP_CENTER_RIGHT; // 0x18
	private static Vector2 UV_BOTTOM_CENTER_LEFT; // 0x20
	private static Vector2 UV_BOTTOM_CENTER_RIGHT; // 0x28
	private static Vector2 UV_TOP_RIGHT; // 0x30
	private static Vector2 UV_BOTTOM_RIGHT; // 0x38
	private static Vector2[] startUvs; // 0x40
	private static Vector2[] middleUvs; // 0x48
	private static Vector2[] endUvs; // 0x50
	private static Vector2[] fullUvs; // 0x58
	[SerializeField] // RVA: 0xDADC0 Offset: 0xDA1C0 VA: 0x1800DADC0
	[TooltipAttribute] // RVA: 0xDADC0 Offset: 0xDA1C0 VA: 0x1800DADC0
	internal Vector2[] m_points; // 0xF0
	[SerializeField] // RVA: 0xDAF70 Offset: 0xDA370 VA: 0x1800DAF70
	[TooltipAttribute] // RVA: 0xDAF70 Offset: 0xDA370 VA: 0x1800DAF70
	internal List<Vector2[]> m_segments; // 0xF8
	[SerializeField] // RVA: 0xDB0A0 Offset: 0xDA4A0 VA: 0x1800DB0A0
	[TooltipAttribute] // RVA: 0xDB0A0 Offset: 0xDA4A0 VA: 0x1800DB0A0
	internal float lineThickness; // 0x100
	[SerializeField] // RVA: 0xDB320 Offset: 0xDA720 VA: 0x1800DB320
	[TooltipAttribute] // RVA: 0xDB320 Offset: 0xDA720 VA: 0x1800DB320
	internal bool relativeSize; // 0x104
	[SerializeField] // RVA: 0xDB450 Offset: 0xDA850 VA: 0x1800DB450
	[TooltipAttribute] // RVA: 0xDB450 Offset: 0xDA850 VA: 0x1800DB450
	internal bool lineList; // 0x105
	[SerializeField] // RVA: 0xDB600 Offset: 0xDAA00 VA: 0x1800DB600
	[TooltipAttribute] // RVA: 0xDB600 Offset: 0xDAA00 VA: 0x1800DB600
	internal bool lineCaps; // 0x106
	[SerializeField] // RVA: 0xDB7C0 Offset: 0xDABC0 VA: 0x1800DB7C0
	[TooltipAttribute] // RVA: 0xDB7C0 Offset: 0xDABC0 VA: 0x1800DB7C0
	internal int bezierSegmentsPerCurve; // 0x108
	[TooltipAttribute] // RVA: 0xDB950 Offset: 0xDAD50 VA: 0x1800DB950
	public UILineRenderer.JoinType LineJoins; // 0x10C
	[TooltipAttribute] // RVA: 0xDBC40 Offset: 0xDB040 VA: 0x1800DBC40
	public UILineRenderer.BezierType BezierMode; // 0x110
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public bool drivenExternally; // 0x114

	// Properties
	public float LineThickness { get; set; }
	public bool RelativeSize { get; set; }
	public bool LineList { get; set; }
	public bool LineCaps { get; set; }
	public int BezierSegmentsPerCurve { get; set; }
	public Vector2[] Points { get; set; }
	public List<Vector2[]> Segments { get; set; }

	// Methods

	// RVA: 0x7B27E0 Offset: 0x7B0DE0 VA: 0x1807B27E0
	public float get_LineThickness() { }

	// RVA: 0x112FC30 Offset: 0x112E230 VA: 0x18112FC30
	public void set_LineThickness(float value) { }

	// RVA: 0x112FBE0 Offset: 0x112E1E0 VA: 0x18112FBE0
	public bool get_RelativeSize() { }

	// RVA: 0x112FC50 Offset: 0x112E250 VA: 0x18112FC50
	public void set_RelativeSize(bool value) { }

	// RVA: 0x112FBD0 Offset: 0x112E1D0 VA: 0x18112FBD0
	public bool get_LineList() { }

	// RVA: 0x112FC10 Offset: 0x112E210 VA: 0x18112FC10
	public void set_LineList(bool value) { }

	// RVA: 0x112FBC0 Offset: 0x112E1C0 VA: 0x18112FBC0
	public bool get_LineCaps() { }

	// RVA: 0x112FBF0 Offset: 0x112E1F0 VA: 0x18112FBF0
	public void set_LineCaps(bool value) { }

	// RVA: 0x88D820 Offset: 0x88BE20 VA: 0x18088D820
	public int get_BezierSegmentsPerCurve() { }

	// RVA: 0x88D9C0 Offset: 0x88BFC0 VA: 0x18088D9C0
	public void set_BezierSegmentsPerCurve(int value) { }

	// RVA: 0xC742E0 Offset: 0xC728E0 VA: 0x180C742E0
	public Vector2[] get_Points() { }

	// RVA: 0x112CE90 Offset: 0x112B490 VA: 0x18112CE90
	public void set_Points(Vector2[] value) { }

	// RVA: 0xB0F550 Offset: 0xB0DB50 VA: 0x180B0F550
	public List<Vector2[]> get_Segments() { }

	// RVA: 0x112FC70 Offset: 0x112E270 VA: 0x18112FC70
	public void set_Segments(List<Vector2[]> value) { }

	// RVA: 0x112E7B0 Offset: 0x112CDB0 VA: 0x18112E7B0
	private void PopulateMesh(VertexHelper vh, Vector2[] pointsToDraw) { }

	// RVA: 0x112E670 Offset: 0x112CC70 VA: 0x18112E670 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x112CEF0 Offset: 0x112B4F0 VA: 0x18112CEF0
	private UIVertex[] CreateLineCap(Vector2 start, Vector2 end, UILineRenderer.SegmentType type) { }

	// RVA: 0x112D0C0 Offset: 0x112B6C0 VA: 0x18112D0C0
	private UIVertex[] CreateLineSegment(Vector2 start, Vector2 end, UILineRenderer.SegmentType type, UIVertex[] previousVert) { }

	// RVA: 0x112D730 Offset: 0x112BD30 VA: 0x18112D730 Slot: 73
	protected override void GeneratedUVs() { }

	// RVA: 0x112FA70 Offset: 0x112E070 VA: 0x18112FA70 Slot: 74
	protected override void ResolutionToNativeSize(float distance) { }

	// RVA: 0x112E530 Offset: 0x112CB30 VA: 0x18112E530
	private int GetSegmentPointCount() { }

	// RVA: 0x112E2D0 Offset: 0x112C8D0 VA: 0x18112E2D0
	public Vector2 GetPosition(int index, int segmentIndex = 0) { }

	// RVA: 0x112E230 Offset: 0x112C830 VA: 0x18112E230
	public Vector2 GetPositionBySegment(int index, int segment) { }

	// RVA: 0x112E110 Offset: 0x112C710 VA: 0x18112E110
	public Vector2 GetClosestPoint(Vector2 p1, Vector2 p2, Vector2 p3) { }

	// RVA: 0x112FB50 Offset: 0x112E150 VA: 0x18112FB50
	public void .ctor() { }

}

private enum UILineRenderer.SegmentType // TypeDefIndex: 11723
{	// Fields
	public int value__; // 0x0
	public const UILineRenderer.SegmentType Start = 0;
	public const UILineRenderer.SegmentType Middle = 1;
	public const UILineRenderer.SegmentType End = 2;
	public const UILineRenderer.SegmentType Full = 3;

}

public enum UILineRenderer.JoinType // TypeDefIndex: 11724
{	// Fields
	public int value__; // 0x0
	public const UILineRenderer.JoinType Bevel = 0;
	public const UILineRenderer.JoinType Miter = 1;

}

public enum UILineRenderer.BezierType // TypeDefIndex: 11725
{	// Fields
	public int value__; // 0x0
	public const UILineRenderer.BezierType None = 0;
	public const UILineRenderer.BezierType Quick = 1;
	public const UILineRenderer.BezierType Basic = 2;
	public const UILineRenderer.BezierType Improved = 3;
	public const UILineRenderer.BezierType Catenary = 4;

}

public class UILineRendererList : UIPrimitiveBase // TypeDefIndex: 11726
{	// Fields
	private const float MIN_MITER_JOIN = 0,2617994;
	private const float MIN_BEVEL_NICE_JOIN = 0,5235988;
	private static Vector2 UV_TOP_LEFT; // 0x0
	private static Vector2 UV_BOTTOM_LEFT; // 0x8
	private static Vector2 UV_TOP_CENTER_LEFT; // 0x10
	private static Vector2 UV_TOP_CENTER_RIGHT; // 0x18
	private static Vector2 UV_BOTTOM_CENTER_LEFT; // 0x20
	private static Vector2 UV_BOTTOM_CENTER_RIGHT; // 0x28
	private static Vector2 UV_TOP_RIGHT; // 0x30
	private static Vector2 UV_BOTTOM_RIGHT; // 0x38
	private static Vector2[] startUvs; // 0x40
	private static Vector2[] middleUvs; // 0x48
	private static Vector2[] endUvs; // 0x50
	private static Vector2[] fullUvs; // 0x58
	[SerializeField] // RVA: 0xDADC0 Offset: 0xDA1C0 VA: 0x1800DADC0
	[TooltipAttribute] // RVA: 0xDADC0 Offset: 0xDA1C0 VA: 0x1800DADC0
	internal List<Vector2> m_points; // 0xF0
	[SerializeField] // RVA: 0xDB0A0 Offset: 0xDA4A0 VA: 0x1800DB0A0
	[TooltipAttribute] // RVA: 0xDB0A0 Offset: 0xDA4A0 VA: 0x1800DB0A0
	internal float lineThickness; // 0xF8
	[SerializeField] // RVA: 0xDB320 Offset: 0xDA720 VA: 0x1800DB320
	[TooltipAttribute] // RVA: 0xDB320 Offset: 0xDA720 VA: 0x1800DB320
	internal bool relativeSize; // 0xFC
	[SerializeField] // RVA: 0xDB450 Offset: 0xDA850 VA: 0x1800DB450
	[TooltipAttribute] // RVA: 0xDB450 Offset: 0xDA850 VA: 0x1800DB450
	internal bool lineList; // 0xFD
	[SerializeField] // RVA: 0xDB600 Offset: 0xDAA00 VA: 0x1800DB600
	[TooltipAttribute] // RVA: 0xDB600 Offset: 0xDAA00 VA: 0x1800DB600
	internal bool lineCaps; // 0xFE
	[SerializeField] // RVA: 0xDB7C0 Offset: 0xDABC0 VA: 0x1800DB7C0
	[TooltipAttribute] // RVA: 0xDB7C0 Offset: 0xDABC0 VA: 0x1800DB7C0
	internal int bezierSegmentsPerCurve; // 0x100
	[TooltipAttribute] // RVA: 0xDB950 Offset: 0xDAD50 VA: 0x1800DB950
	public UILineRendererList.JoinType LineJoins; // 0x104
	[TooltipAttribute] // RVA: 0xDBC40 Offset: 0xDB040 VA: 0x1800DBC40
	public UILineRendererList.BezierType BezierMode; // 0x108
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public bool drivenExternally; // 0x10C

	// Properties
	public float LineThickness { get; set; }
	public bool RelativeSize { get; set; }
	public bool LineList { get; set; }
	public bool LineCaps { get; set; }
	public int BezierSegmentsPerCurve { get; set; }
	public List<Vector2> Points { get; set; }

	// Methods

	// RVA: 0x112CE10 Offset: 0x112B410 VA: 0x18112CE10
	public float get_LineThickness() { }

	// RVA: 0x112CE70 Offset: 0x112B470 VA: 0x18112CE70
	public void set_LineThickness(float value) { }

	// RVA: 0x112CE20 Offset: 0x112B420 VA: 0x18112CE20
	public bool get_RelativeSize() { }

	// RVA: 0x112CED0 Offset: 0x112B4D0 VA: 0x18112CED0
	public void set_RelativeSize(bool value) { }

	// RVA: 0x112CE00 Offset: 0x112B400 VA: 0x18112CE00
	public bool get_LineList() { }

	// RVA: 0x112CE50 Offset: 0x112B450 VA: 0x18112CE50
	public void set_LineList(bool value) { }

	// RVA: 0x112CDF0 Offset: 0x112B3F0 VA: 0x18112CDF0
	public bool get_LineCaps() { }

	// RVA: 0x112CE30 Offset: 0x112B430 VA: 0x18112CE30
	public void set_LineCaps(bool value) { }

	// RVA: 0xC74210 Offset: 0xC72810 VA: 0x180C74210
	public int get_BezierSegmentsPerCurve() { }

	// RVA: 0xC74350 Offset: 0xC72950 VA: 0x180C74350
	public void set_BezierSegmentsPerCurve(int value) { }

	// RVA: 0xC742E0 Offset: 0xC728E0 VA: 0x180C742E0
	public List<Vector2> get_Points() { }

	// RVA: 0x112CE90 Offset: 0x112B490 VA: 0x18112CE90
	public void set_Points(List<Vector2> value) { }

	// RVA: 0x112A830 Offset: 0x1128E30 VA: 0x18112A830
	public void AddPoint(Vector2 pointToAdd) { }

	// RVA: 0x112CC30 Offset: 0x112B230 VA: 0x18112CC30
	public void RemovePoint(Vector2 pointToRemove) { }

	// RVA: 0x112A8A0 Offset: 0x1128EA0 VA: 0x18112A8A0
	public void ClearPoints() { }

	// RVA: 0x112BA80 Offset: 0x112A080 VA: 0x18112BA80
	private void PopulateMesh(VertexHelper vh, List<Vector2> pointsToDraw) { }

	// RVA: 0x112B9F0 Offset: 0x1129FF0 VA: 0x18112B9F0 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x112A900 Offset: 0x1128F00 VA: 0x18112A900
	private UIVertex[] CreateLineCap(Vector2 start, Vector2 end, UILineRendererList.SegmentType type) { }

	// RVA: 0x112AAC0 Offset: 0x11290C0 VA: 0x18112AAC0
	private UIVertex[] CreateLineSegment(Vector2 start, Vector2 end, UILineRendererList.SegmentType type) { }

	// RVA: 0x112B010 Offset: 0x1129610 VA: 0x18112B010 Slot: 73
	protected override void GeneratedUVs() { }

	// RVA: 0x112CCA0 Offset: 0x112B2A0 VA: 0x18112CCA0 Slot: 74
	protected override void ResolutionToNativeSize(float distance) { }

	// RVA: 0x112CD80 Offset: 0x112B380 VA: 0x18112CD80
	public void .ctor() { }

}

private enum UILineRendererList.SegmentType // TypeDefIndex: 11727
{	// Fields
	public int value__; // 0x0
	public const UILineRendererList.SegmentType Start = 0;
	public const UILineRendererList.SegmentType Middle = 1;
	public const UILineRendererList.SegmentType End = 2;
	public const UILineRendererList.SegmentType Full = 3;

}

public enum UILineRendererList.JoinType // TypeDefIndex: 11728
{	// Fields
	public int value__; // 0x0
	public const UILineRendererList.JoinType Bevel = 0;
	public const UILineRendererList.JoinType Miter = 1;

}

public enum UILineRendererList.BezierType // TypeDefIndex: 11729
{	// Fields
	public int value__; // 0x0
	public const UILineRendererList.BezierType None = 0;
	public const UILineRendererList.BezierType Quick = 1;
	public const UILineRendererList.BezierType Basic = 2;
	public const UILineRendererList.BezierType Improved = 3;
	public const UILineRendererList.BezierType Catenary = 4;

}

public class UILineTextureRenderer : UIPrimitiveBase // TypeDefIndex: 11730
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Rect m_UVRect; // 0xF0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector2[] m_points; // 0x100
	public float LineThickness; // 0x108
	public bool UseMargins; // 0x10C
	public Vector2 Margin; // 0x110
	public bool relativeSize; // 0x118

	// Properties
	public Rect uvRect { get; set; }
	public Vector2[] Points { get; set; }

	// Methods

	// RVA: 0x1131170 Offset: 0x112F770 VA: 0x181131170
	public Rect get_uvRect() { }

	// RVA: 0x11311C0 Offset: 0x112F7C0 VA: 0x1811311C0
	public void set_uvRect(Rect value) { }

	// RVA: 0xA2B0D0 Offset: 0xA296D0 VA: 0x180A2B0D0
	public Vector2[] get_Points() { }

	// RVA: 0x1131180 Offset: 0x112F780 VA: 0x181131180
	public void set_Points(Vector2[] value) { }

	// RVA: 0x112FCB0 Offset: 0x112E2B0 VA: 0x18112FCB0 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x1130F70 Offset: 0x112F570 VA: 0x181130F70
	public Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Vector3 angles) { }

	// RVA: 0x11310D0 Offset: 0x112F6D0 VA: 0x1811310D0
	public void .ctor() { }

}

public class UIPolygon : UIPrimitiveBase // TypeDefIndex: 11731
{	// Fields
	public bool fill; // 0xF0
	public float thickness; // 0xF4
	[RangeAttribute] // RVA: 0xDF320 Offset: 0xDE720 VA: 0x1800DF320
	public int sides; // 0xF8
	[RangeAttribute] // RVA: 0x9F1C0 Offset: 0x9E5C0 VA: 0x18009F1C0
	public float rotation; // 0xFC
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float[] VerticesDistances; // 0x100
	private float size; // 0x108

	// Methods

	// RVA: 0x1131230 Offset: 0x112F830 VA: 0x181131230
	public void DrawPolygon(int _sides) { }

	// RVA: 0x1131350 Offset: 0x112F950 VA: 0x181131350
	public void DrawPolygon(int _sides, float[] _VerticesDistances) { }

	// RVA: 0x1131300 Offset: 0x112F900 VA: 0x181131300
	public void DrawPolygon(int _sides, float[] _VerticesDistances, float _rotation) { }

	// RVA: 0x1131AC0 Offset: 0x11300C0 VA: 0x181131AC0
	private void Update() { }

	// RVA: 0x11313A0 Offset: 0x112F9A0 VA: 0x1811313A0 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x1131C80 Offset: 0x1130280 VA: 0x181131C80
	public void .ctor() { }

}

public class UIPrimitiveBase : MaskableGraphic, ILayoutElement, ICanvasRaycastFilter // TypeDefIndex: 11734
{	// Fields
	protected static Material s_ETC1DefaultUI; // 0x0
	private List<Vector2> outputList; // 0xC8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Sprite m_Sprite; // 0xD0
	private Sprite m_OverrideSprite; // 0xD8
	internal float m_EventAlphaThreshold; // 0xE0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ResolutionMode m_improveResolution; // 0xE4
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected float m_Resolution; // 0xE8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_useNativeSize; // 0xEC

	// Properties
	public Sprite sprite { get; set; }
	public Sprite overrideSprite { get; set; }
	protected Sprite activeSprite { get; }
	public float eventAlphaThreshold { get; set; }
	public ResolutionMode ImproveResolution { get; set; }
	public float Resoloution { get; set; }
	public bool UseNativeSize { get; set; }
	public static Material defaultETC1GraphicMaterial { get; }
	public override Texture mainTexture { get; }
	public bool hasBorder { get; }
	public float pixelsPerUnit { get; }
	public override Material material { get; set; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }

	// Methods

	// RVA: 0x79BDF0 Offset: 0x79A3F0 VA: 0x18079BDF0
	public Sprite get_sprite() { }

	// RVA: 0x1133710 Offset: 0x1131D10 VA: 0x181133710
	public void set_sprite(Sprite value) { }

	// RVA: 0x1133330 Offset: 0x1131930 VA: 0x181133330
	public Sprite get_overrideSprite() { }

	// RVA: 0x1133690 Offset: 0x1131C90 VA: 0x181133690
	public void set_overrideSprite(Sprite value) { }

	// RVA: 0x1132CE0 Offset: 0x11312E0 VA: 0x181132CE0
	protected Sprite get_activeSprite() { }

	// RVA: 0x1132E70 Offset: 0x1131470 VA: 0x181132E70
	public float get_eventAlphaThreshold() { }

	// RVA: 0x1133670 Offset: 0x1131C70 VA: 0x181133670
	public void set_eventAlphaThreshold(float value) { }

	// RVA: 0x107AB10 Offset: 0x1079110 VA: 0x18107AB10
	public ResolutionMode get_ImproveResolution() { }

	// RVA: 0x1133610 Offset: 0x1131C10 VA: 0x181133610
	public void set_ImproveResolution(ResolutionMode value) { }

	// RVA: 0x1132CC0 Offset: 0x11312C0 VA: 0x181132CC0
	public float get_Resoloution() { }

	// RVA: 0x1133630 Offset: 0x1131C30 VA: 0x181133630
	public void set_Resoloution(float value) { }

	// RVA: 0x1132CD0 Offset: 0x11312D0 VA: 0x181132CD0
	public bool get_UseNativeSize() { }

	// RVA: 0x1133650 Offset: 0x1131C50 VA: 0x181133650
	public void set_UseNativeSize(bool value) { }

	// RVA: 0x1132C40 Offset: 0x1131240 VA: 0x181132C40
	protected void .ctor() { }

	// RVA: 0x1132D70 Offset: 0x1131370 VA: 0x181132D70
	public static Material get_defaultETC1GraphicMaterial() { }

	// RVA: 0x1132F40 Offset: 0x1131540 VA: 0x181132F40 Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0x1132E80 Offset: 0x1131480 VA: 0x181132E80
	public bool get_hasBorder() { }

	// RVA: 0x1133340 Offset: 0x1131940 VA: 0x181133340
	public float get_pixelsPerUnit() { }

	// RVA: 0x11330E0 Offset: 0x11316E0 VA: 0x1811330E0 Slot: 32
	public override Material get_material() { }

	// RVA: 0x1133680 Offset: 0x1131C80 VA: 0x181133680 Slot: 33
	public override void set_material(Material value) { }

	// RVA: 0x11329E0 Offset: 0x1130FE0 VA: 0x1811329E0
	protected UIVertex[] SetVbo(Vector2[] vertices, Vector2[] uvs) { }

	// RVA: 0x1131E50 Offset: 0x1130450 VA: 0x181131E50
	protected Vector2[] IncreaseResolution(Vector2[] input) { }

	// RVA: 0x1131EE0 Offset: 0x11304E0 VA: 0x181131EE0
	protected List<Vector2> IncreaseResolution(List<Vector2> input) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 73
	protected virtual void GeneratedUVs() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 74
	protected virtual void ResolutionToNativeSize(float distance) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 75
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 76
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x568670 Offset: 0x566C70 VA: 0x180568670 Slot: 77
	public virtual float get_minWidth() { }

	// RVA: 0x1133530 Offset: 0x1131B30 VA: 0x181133530 Slot: 78
	public virtual float get_preferredWidth() { }

	// RVA: 0xC835F0 Offset: 0xC81BF0 VA: 0x180C835F0 Slot: 79
	public virtual float get_flexibleWidth() { }

	// RVA: 0x568670 Offset: 0x566C70 VA: 0x180568670 Slot: 80
	public virtual float get_minHeight() { }

	// RVA: 0x1133450 Offset: 0x1131A50 VA: 0x181133450 Slot: 81
	public virtual float get_preferredHeight() { }

	// RVA: 0xC835F0 Offset: 0xC81BF0 VA: 0x180C835F0 Slot: 82
	public virtual float get_flexibleHeight() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 83
	public virtual int get_layoutPriority() { }

	// RVA: 0x11324B0 Offset: 0x1130AB0 VA: 0x1811324B0 Slot: 84
	public virtual bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera) { }

	// RVA: 0x1132920 Offset: 0x1130F20 VA: 0x181132920
	private Vector2 MapCoordinate(Vector2 local, Rect rect) { }

	// RVA: 0x1131D10 Offset: 0x1130310 VA: 0x181131D10
	private Vector4 GetAdjustedBorders(Vector4 border, Rect rect) { }

	// RVA: 0x11329B0 Offset: 0x1130FB0 VA: 0x1811329B0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

public class UIRing : UIPrimitiveBase // TypeDefIndex: 11735
{	// Fields
	public float innerRadius; // 0xF0
	public float outerRadius; // 0xF4
	[TooltipAttribute] // RVA: 0xD9B40 Offset: 0xD8F40 VA: 0x1800D9B40
	[RangeAttribute] // RVA: 0xD9B40 Offset: 0xD8F40 VA: 0x1800D9B40
	public int ArcSteps; // 0xF8
	private List<int> indices; // 0x100
	private List<UIVertex> vertices; // 0x108

	// Methods

	// RVA: 0x1133790 Offset: 0x1131D90 VA: 0x181133790 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x1133E10 Offset: 0x1132410 VA: 0x181133E10
	public void SetArcSteps(int steps) { }

	// RVA: 0x1133E30 Offset: 0x1132430 VA: 0x181133E30
	public void SetBaseColor(Color color) { }

	// RVA: 0x1133E70 Offset: 0x1132470 VA: 0x181133E70
	public void UpdateBaseAlpha(float value) { }

	// RVA: 0x1133EF0 Offset: 0x11324F0 VA: 0x181133EF0
	public void .ctor() { }

}

internal interface IAmbientOcclusionMethod // TypeDefIndex: 11761
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract DepthTextureMode GetCameraFlags();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void RenderAfterOpaque(PostProcessRenderContext context);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void RenderAmbientOnly(PostProcessRenderContext context);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void CompositeAmbientOnly(PostProcessRenderContext context);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Release();

}

public class UI : ConsoleSystem // TypeDefIndex: 11971
{	// Fields
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool showinventoryplayer; // 0x0
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool autoswitchchannel; // 0x1

	// Methods

	// RVA: 0x36D730 Offset: 0x36BD30 VA: 0x18036D730
	public void .ctor() { }

	// RVA: 0x36D6E0 Offset: 0x36BCE0 VA: 0x18036D6E0
	private static void .cctor() { }

}

public interface VirtualScroll.IDataSource // TypeDefIndex: 12002
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int GetItemCount();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetItemData(int i, GameObject obj);

}

public interface IGenericLerpTarget<T> : ILerpInfo // TypeDefIndex: 12119
{	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetFrom(T snapshot);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IGenericLerpTarget<object>.SetFrom
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract T GetCurrentState();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IGenericLerpTarget<object>.GetCurrentState
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void DebugInterpolationState(Interpolator.Segment<T> segment, List<T> entries);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IGenericLerpTarget<object>.DebugInterpolationState
	*/

}

public interface ISnapshot<T> // TypeDefIndex: 12121
{	// Properties
	public abstract float Time { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract float get_Time();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISnapshot<object>.get_Time
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Time(float value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISnapshot<object>.set_Time
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void MatchValuesTo(T entry);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISnapshot<object>.MatchValuesTo
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Lerp(T prev, T next, float delta);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISnapshot<object>.Lerp
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract T GetNew();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISnapshot<object>.GetNew
	*/

}

