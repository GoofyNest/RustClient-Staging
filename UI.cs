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

	// RVA: 0x232AF0 Offset: 0x231EF0 VA: 0x180232AF0 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x1F2E80 Offset: 0x1F2280 VA: 0x1801F2E80 Slot: 23
	public int CompareTo(ushort value) { }

	// RVA: 0x232BC0 Offset: 0x231FC0 VA: 0x180232BC0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1F2FF0 Offset: 0x1F23F0 VA: 0x1801F2FF0 Slot: 24
	public bool Equals(ushort obj) { }

	// RVA: 0x121100 Offset: 0x120500 VA: 0x180121100 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2331E0 Offset: 0x2325E0 VA: 0x1802331E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x233210 Offset: 0x232610 VA: 0x180233210 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x2331A0 Offset: 0x2325A0 VA: 0x1802331A0
	public string ToString(string format) { }

	// RVA: 0x233240 Offset: 0x232640 VA: 0x180233240 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x21452F0 Offset: 0x21438F0 VA: 0x1821452F0
	public static ushort Parse(string s, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x2145320 Offset: 0x2143920 VA: 0x182145320
	public static ushort Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x2145200 Offset: 0x2143800 VA: 0x182145200
	private static ushort Parse(string s, NumberStyles style, NumberFormatInfo info) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x2145570 Offset: 0x2143B70 VA: 0x182145570
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out ushort result) { }

	// RVA: 0x2145520 Offset: 0x2143B20 VA: 0x182145520
	private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out ushort result) { }

	// RVA: 0x232C50 Offset: 0x232050 VA: 0x180232C50 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x232C60 Offset: 0x232060 VA: 0x180232C60 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x232D20 Offset: 0x232120 VA: 0x180232D20 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x232F90 Offset: 0x232390 VA: 0x180232F90 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x232CC0 Offset: 0x2320C0 VA: 0x180232CC0 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x232E70 Offset: 0x232270 VA: 0x180232E70 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x121100 Offset: 0x120500 VA: 0x180121100 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x232ED0 Offset: 0x2322D0 VA: 0x180232ED0 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x2330E0 Offset: 0x2324E0 VA: 0x1802330E0 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x232F30 Offset: 0x232330 VA: 0x180232F30 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x233140 Offset: 0x232540 VA: 0x180233140 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x232FF0 Offset: 0x2323F0 VA: 0x180232FF0 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x232E10 Offset: 0x232210 VA: 0x180232E10 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x232D90 Offset: 0x232190 VA: 0x180232D90 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x232D80 Offset: 0x232180 VA: 0x180232D80 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x233050 Offset: 0x232450 VA: 0x180233050 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

}

public struct UInt32 : IComparable, IFormattable, IConvertible, IComparable<uint>, IEquatable<uint> // TypeDefIndex: 327
{	// Fields
	private uint m_value; // 0x0
	public const uint MaxValue = 4294967295;
	public const uint MinValue = 0;

	// Methods

	// RVA: 0x233280 Offset: 0x232680 VA: 0x180233280 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x233380 Offset: 0x232780 VA: 0x180233380 Slot: 23
	public int CompareTo(uint value) { }

	// RVA: 0x2333A0 Offset: 0x2327A0 VA: 0x1802333A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1E50E0 Offset: 0x1E44E0 VA: 0x1801E50E0 Slot: 24
	public bool Equals(uint obj) { }

	// RVA: 0xF37A0 Offset: 0xF2BA0 VA: 0x1800F37A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2339A0 Offset: 0x232DA0 VA: 0x1802339A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2339D0 Offset: 0x232DD0 VA: 0x1802339D0 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x233960 Offset: 0x232D60 VA: 0x180233960 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x2145780 Offset: 0x2143D80 VA: 0x182145780
	public static uint Parse(string s) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x21457B0 Offset: 0x2143DB0 VA: 0x1821457B0
	public static uint Parse(string s, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x21457E0 Offset: 0x2143DE0 VA: 0x1821457E0
	public static uint Parse(string s, NumberStyles style, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x21459A0 Offset: 0x2143FA0 VA: 0x1821459A0
	public static bool TryParse(string s, out uint result) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x21459E0 Offset: 0x2143FE0 VA: 0x1821459E0
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out uint result) { }

	// RVA: 0x233420 Offset: 0x232820 VA: 0x180233420 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x233430 Offset: 0x232830 VA: 0x180233430 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x2334F0 Offset: 0x2328F0 VA: 0x1802334F0 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x233750 Offset: 0x232B50 VA: 0x180233750 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x233490 Offset: 0x232890 VA: 0x180233490 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x233630 Offset: 0x232A30 VA: 0x180233630 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x2338A0 Offset: 0x232CA0 VA: 0x1802338A0 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x233690 Offset: 0x232A90 VA: 0x180233690 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0xF37A0 Offset: 0xF2BA0 VA: 0x1800F37A0 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x2336F0 Offset: 0x232AF0 VA: 0x1802336F0 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x233900 Offset: 0x232D00 VA: 0x180233900 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x2337B0 Offset: 0x232BB0 VA: 0x1802337B0 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x2335D0 Offset: 0x2329D0 VA: 0x1802335D0 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x233560 Offset: 0x232960 VA: 0x180233560 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x233550 Offset: 0x232950 VA: 0x180233550 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x233810 Offset: 0x232C10 VA: 0x180233810 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

}

public struct UInt64 : IComparable, IFormattable, IConvertible, IComparable<ulong>, IEquatable<ulong> // TypeDefIndex: 328
{	// Fields
	private ulong m_value; // 0x0
	public const ulong MaxValue = 18446744073709551615;
	public const ulong MinValue = 0;

	// Methods

	// RVA: 0x233A20 Offset: 0x232E20 VA: 0x180233A20 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x233A00 Offset: 0x232E00 VA: 0x180233A00 Slot: 23
	public int CompareTo(ulong value) { }

	// RVA: 0x233B20 Offset: 0x232F20 VA: 0x180233B20 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1F5BD0 Offset: 0x1F4FD0 VA: 0x1801F5BD0 Slot: 24
	public bool Equals(ulong obj) { }

	// RVA: 0x233BB0 Offset: 0x232FB0 VA: 0x180233BB0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x234180 Offset: 0x233580 VA: 0x180234180 Slot: 3
	public override string ToString() { }

	// RVA: 0x234150 Offset: 0x233550 VA: 0x180234150 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x234110 Offset: 0x233510 VA: 0x180234110
	public string ToString(string format) { }

	// RVA: 0x2341B0 Offset: 0x2335B0 VA: 0x1802341B0 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x2145C60 Offset: 0x2144260 VA: 0x182145C60
	public static ulong Parse(string s) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x2145BE0 Offset: 0x21441E0 VA: 0x182145BE0
	public static ulong Parse(string s, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x2145C10 Offset: 0x2144210 VA: 0x182145C10
	public static ulong Parse(string s, NumberStyles style, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x2145EA0 Offset: 0x21444A0 VA: 0x182145EA0
	public static bool TryParse(string s, out ulong result) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x2145E40 Offset: 0x2144440 VA: 0x182145E40
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out ulong result) { }

	// RVA: 0x233BC0 Offset: 0x232FC0 VA: 0x180233BC0 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x233BD0 Offset: 0x232FD0 VA: 0x180233BD0 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x233C90 Offset: 0x233090 VA: 0x180233C90 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x233F00 Offset: 0x233300 VA: 0x180233F00 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x233C30 Offset: 0x233030 VA: 0x180233C30 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x233DE0 Offset: 0x2331E0 VA: 0x180233DE0 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x234050 Offset: 0x233450 VA: 0x180234050 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x233E40 Offset: 0x233240 VA: 0x180233E40 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x2340B0 Offset: 0x2334B0 VA: 0x1802340B0 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x233EA0 Offset: 0x2332A0 VA: 0x180233EA0 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0xFC8C0 Offset: 0xFBCC0 VA: 0x1800FC8C0 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x233F60 Offset: 0x233360 VA: 0x180233F60 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x233D80 Offset: 0x233180 VA: 0x180233D80 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x233D00 Offset: 0x233100 VA: 0x180233D00 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x233CF0 Offset: 0x2330F0 VA: 0x180233CF0 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x233FC0 Offset: 0x2333C0 VA: 0x180233FC0 Slot: 22
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

	// RVA: 0x234380 Offset: 0x233780 VA: 0x180234380
	public void .ctor(uint value) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x1D2F30 Offset: 0x1D2330 VA: 0x1801D2F30
	public void .ctor(void* value) { }

	// RVA: 0x2341F0 Offset: 0x2335F0 VA: 0x1802341F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xF37A0 Offset: 0xF2BA0 VA: 0x1800F37A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x234310 Offset: 0x233710 VA: 0x180234310 Slot: 3
	public override string ToString() { }

	// RVA: 0x234280 Offset: 0x233680 VA: 0x180234280 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xAE59E0 Offset: 0xAE3FE0 VA: 0x180AE59E0
	public static bool op_Equality(UIntPtr value1, UIntPtr value2) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0
	public static ulong op_Explicit(UIntPtr value) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0
	public static UIntPtr op_Explicit(void* value) { }

	// RVA: 0x8C0CF0 Offset: 0x8BF2F0 VA: 0x1808C0CF0
	public static int get_Size() { }

	// RVA: 0x2145F70 Offset: 0x2144570 VA: 0x182145F70
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
[ComVisibleAttribute] // RVA: 0x75F80 Offset: 0x75380 VA: 0x180075F80
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
[ComVisibleAttribute] // RVA: 0x75F80 Offset: 0x75380 VA: 0x180075F80
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
[ComVisibleAttribute] // RVA: 0x75F80 Offset: 0x75380 VA: 0x180075F80
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
[ComVisibleAttribute] // RVA: 0x75F80 Offset: 0x75380 VA: 0x180075F80
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

	[DispIdAttribute] // RVA: 0xE92F0 Offset: 0xE86F0 VA: 0x1800E92F0
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

	// RVA: 0x10EA010 Offset: 0x10E8610 VA: 0x1810EA010 Slot: 4
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

	// RVA: 0x10E9FB0 Offset: 0x10E85B0 VA: 0x1810E9FB0 Slot: 7
	public override void WriteData(TraceLoggingDataCollector collector, ref ushort value) { }

	// RVA: 0x10EA0A0 Offset: 0x10E86A0 VA: 0x1810EA0A0
	public void .ctor() { }

}

internal sealed class UInt32TypeInfo : TraceLoggingTypeInfo<uint> // TypeDefIndex: 1538
{	// Methods

	// RVA: 0x10EA290 Offset: 0x10E8890 VA: 0x1810EA290 Slot: 4
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

	// RVA: 0x10EA230 Offset: 0x10E8830 VA: 0x1810EA230 Slot: 7
	public override void WriteData(TraceLoggingDataCollector collector, ref uint value) { }

	// RVA: 0x10EA320 Offset: 0x10E8920 VA: 0x1810EA320
	public void .ctor() { }

}

internal sealed class UInt64TypeInfo : TraceLoggingTypeInfo<ulong> // TypeDefIndex: 1540
{	// Methods

	// RVA: 0x10EA560 Offset: 0x10E8B60 VA: 0x1810EA560 Slot: 4
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

	// RVA: 0x10EA500 Offset: 0x10E8B00 VA: 0x1810EA500 Slot: 7
	public override void WriteData(TraceLoggingDataCollector collector, ref ulong value) { }

	// RVA: 0x10EA640 Offset: 0x10E8C40 VA: 0x1810EA640
	public void .ctor() { }

}

internal sealed class UIntPtrTypeInfo : TraceLoggingTypeInfo<UIntPtr> // TypeDefIndex: 1542
{	// Methods

	// RVA: 0x10EA920 Offset: 0x10E8F20 VA: 0x1810EA920 Slot: 4
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

	// RVA: 0x10EA890 Offset: 0x10E8E90 VA: 0x1810EA890 Slot: 7
	public override void WriteData(TraceLoggingDataCollector collector, ref UIntPtr value) { }

	// RVA: 0x10EAA30 Offset: 0x10E9030 VA: 0x1810EAA30
	public void .ctor() { }

}

internal sealed class UInt16ArrayTypeInfo : TraceLoggingTypeInfo<ushort[]> // TypeDefIndex: 1550
{	// Methods

	// RVA: 0x10E9EE0 Offset: 0x10E84E0 VA: 0x1810E9EE0 Slot: 4
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

	// RVA: 0x10E9E60 Offset: 0x10E8460 VA: 0x1810E9E60 Slot: 7
	public override void WriteData(TraceLoggingDataCollector collector, ref ushort[] value) { }

	// RVA: 0x10E9F70 Offset: 0x10E8570 VA: 0x1810E9F70
	public void .ctor() { }

}

internal sealed class UInt32ArrayTypeInfo : TraceLoggingTypeInfo<uint[]> // TypeDefIndex: 1552
{	// Methods

	// RVA: 0x10EA160 Offset: 0x10E8760 VA: 0x1810EA160 Slot: 4
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

	// RVA: 0x10EA0E0 Offset: 0x10E86E0 VA: 0x1810EA0E0 Slot: 7
	public override void WriteData(TraceLoggingDataCollector collector, ref uint[] value) { }

	// RVA: 0x10EA1F0 Offset: 0x10E87F0 VA: 0x1810EA1F0
	public void .ctor() { }

}

internal sealed class UInt64ArrayTypeInfo : TraceLoggingTypeInfo<ulong[]> // TypeDefIndex: 1554
{	// Methods

	// RVA: 0x10EA3E0 Offset: 0x10E89E0 VA: 0x1810EA3E0 Slot: 4
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

	// RVA: 0x10EA360 Offset: 0x10E8960 VA: 0x1810EA360 Slot: 7
	public override void WriteData(TraceLoggingDataCollector collector, ref ulong[] value) { }

	// RVA: 0x10EA4C0 Offset: 0x10E8AC0 VA: 0x1810EA4C0
	public void .ctor() { }

}

internal sealed class UIntPtrArrayTypeInfo : TraceLoggingTypeInfo<UIntPtr[]> // TypeDefIndex: 1556
{	// Methods

	// RVA: 0x10EA740 Offset: 0x10E8D40 VA: 0x1810EA740 Slot: 4
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

	// RVA: 0x10EA680 Offset: 0x10E8C80 VA: 0x1810EA680 Slot: 7
	public override void WriteData(TraceLoggingDataCollector collector, ref UIntPtr[] value) { }

	// RVA: 0x10EA850 Offset: 0x10E8E50 VA: 0x1810EA850
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

	// RVA: 0x1741390 Offset: 0x173F990 VA: 0x181741390 Slot: 17
	internal override Type get_TargetType() { }

	// RVA: 0x1741280 Offset: 0x173F880 VA: 0x181741280 Slot: 18
	internal override object FromString(string value, int radix) { }

	// RVA: 0x1741220 Offset: 0x173F820 VA: 0x181741220 Slot: 19
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x1741300 Offset: 0x173F900 VA: 0x181741300 Slot: 21
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

}

public class UInt32Converter : BaseNumberConverter // TypeDefIndex: 2770
{	// Properties
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0x1741550 Offset: 0x173FB50 VA: 0x181741550 Slot: 17
	internal override Type get_TargetType() { }

	// RVA: 0x1741450 Offset: 0x173FA50 VA: 0x181741450 Slot: 18
	internal override object FromString(string value, int radix) { }

	// RVA: 0x17413F0 Offset: 0x173F9F0 VA: 0x1817413F0 Slot: 19
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x17414D0 Offset: 0x173FAD0 VA: 0x1817414D0 Slot: 21
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

}

public class UInt64Converter : BaseNumberConverter // TypeDefIndex: 2771
{	// Properties
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0x1741720 Offset: 0x173FD20 VA: 0x181741720 Slot: 17
	internal override Type get_TargetType() { }

	// RVA: 0x17415B0 Offset: 0x173FBB0 VA: 0x1817415B0 Slot: 18
	internal override object FromString(string value, int radix) { }

	// RVA: 0x1741630 Offset: 0x173FC30 VA: 0x181741630 Slot: 19
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x1741690 Offset: 0x173FC90 VA: 0x181741690 Slot: 21
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
[ComVisibleAttribute] // RVA: 0x75F80 Offset: 0x75380 VA: 0x180075F80
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
[RequiredByNativeCodeAttribute] // RVA: 0xC8E10 Offset: 0xC8210 VA: 0x1800C8E10
[AttributeUsageAttribute] // RVA: 0xC8E10 Offset: 0xC8210 VA: 0x1800C8E10
public sealed class PreferBinarySerialization : Attribute // TypeDefIndex: 3547

// Namespace: UnityEngine
[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
public interface ISerializationCallbackReceiver // TypeDefIndex: 3548
	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnBeforeSerialize();

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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
[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
public interface INotificationReceiver // TypeDefIndex: 3862
	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnNotify(Playable origin, INotification notification, object context);

}

public interface IPlayableBehaviour // TypeDefIndex: 3863
{	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnGraphStart(Playable playable);

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnGraphStop(Playable playable);

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnPlayableCreate(Playable playable);

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnPlayableDestroy(Playable playable);

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnBehaviourPlay(Playable playable, FrameData info);

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnBehaviourPause(Playable playable, FrameData info);

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1 Slot: 6
	public abstract void PrepareFrame(Playable playable, FrameData info);

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0x230C9A0 Offset: 0x230AFA0 VA: 0x18230C9A0
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

	// RVA: 0x1242600 Offset: 0x1240C00 VA: 0x181242600
	public void .ctor(DataColumn column) { }

	// RVA: 0x1241540 Offset: 0x123FB40 VA: 0x181241540 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1241DE0 Offset: 0x12403E0 VA: 0x181241DE0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1241CC0 Offset: 0x12402C0 VA: 0x181241CC0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1241F40 Offset: 0x1240540 VA: 0x181241F40 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x12421B0 Offset: 0x12407B0 VA: 0x1812421B0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1242270 Offset: 0x1240870 VA: 0x181242270 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x12424B0 Offset: 0x1240AB0 VA: 0x1812424B0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1242330 Offset: 0x1240930 VA: 0x181242330 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1242020 Offset: 0x1240620 VA: 0x181242020 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1241EC0 Offset: 0x12404C0 VA: 0x181241EC0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1242230 Offset: 0x1240830 VA: 0x181242230 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1242090 Offset: 0x1240690 VA: 0x181242090 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1242410 Offset: 0x1240A10 VA: 0x181242410 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

internal sealed class UInt32Storage : DataStorage // TypeDefIndex: 4434
{	// Fields
	private static readonly uint s_defaultValue; // 0x0
	private uint[] _values; // 0x50

	// Methods

	// RVA: 0x1243770 Offset: 0x1241D70 VA: 0x181243770
	public void .ctor(DataColumn column) { }

	// RVA: 0x12426F0 Offset: 0x1240CF0 VA: 0x1812426F0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1242F70 Offset: 0x1241570 VA: 0x181242F70 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1242E50 Offset: 0x1241450 VA: 0x181242E50 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x12430D0 Offset: 0x12416D0 VA: 0x1812430D0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1243330 Offset: 0x1241930 VA: 0x181243330 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x12433F0 Offset: 0x12419F0 VA: 0x1812433F0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1243630 Offset: 0x1241C30 VA: 0x181243630 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x12434B0 Offset: 0x1241AB0 VA: 0x1812434B0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x12431A0 Offset: 0x12417A0 VA: 0x1812431A0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1243050 Offset: 0x1241650 VA: 0x181243050 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x12433B0 Offset: 0x12419B0 VA: 0x1812433B0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1243210 Offset: 0x1241810 VA: 0x181243210 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1243590 Offset: 0x1241B90 VA: 0x181243590 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

internal sealed class UInt64Storage : DataStorage // TypeDefIndex: 4435
{	// Fields
	private static readonly ulong s_defaultValue; // 0x0
	private ulong[] _values; // 0x50

	// Methods

	// RVA: 0x12449B0 Offset: 0x1242FB0 VA: 0x1812449B0
	public void .ctor(DataColumn column) { }

	// RVA: 0x1243860 Offset: 0x1241E60 VA: 0x181243860 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1244140 Offset: 0x1242740 VA: 0x181244140 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1244020 Offset: 0x1242620 VA: 0x181244020 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x12442F0 Offset: 0x12428F0 VA: 0x1812442F0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1244560 Offset: 0x1242B60 VA: 0x181244560 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1244620 Offset: 0x1242C20 VA: 0x181244620 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1244860 Offset: 0x1242E60 VA: 0x181244860 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x12446E0 Offset: 0x1242CE0 VA: 0x1812446E0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x12443D0 Offset: 0x12429D0 VA: 0x1812443D0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1244270 Offset: 0x1242870 VA: 0x181244270 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x12445E0 Offset: 0x1242BE0 VA: 0x1812445E0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1244440 Offset: 0x1242A40 VA: 0x181244440 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x12447C0 Offset: 0x1242DC0 VA: 0x1812447C0 Slot: 20
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

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xEBC550 Offset: 0xEBAB50 VA: 0x180EBC550
	public static void RepaintOverlayPanels() { }

	// RVA: 0xEBC9B0 Offset: 0xEBAFB0 VA: 0x180EBC9B0
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

	// RVA: 0xEBE440 Offset: 0xEBCA40 VA: 0x180EBE440
	private static void .cctor() { }

	// RVA: 0xEBDFE0 Offset: 0xEBC5E0 VA: 0x180EBDFE0
	internal static void MakeCurrentIMGUIContainerDirty() { }

	// RVA: 0xEBE260 Offset: 0xEBC860 VA: 0x180EBE260
	private static void TakeCapture() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void ReleaseCapture() { }

	// RVA: 0xEBE0B0 Offset: 0xEBC6B0 VA: 0x180EBE0B0
	private static bool ProcessEvent(int instanceID, IntPtr nativeEventPtr) { }

	// RVA: 0xEBE1E0 Offset: 0xEBC7E0 VA: 0x180EBE1E0
	public static void RemoveCachedPanel(int instanceID) { }

	// RVA: 0xEBCD30 Offset: 0xEBB330 VA: 0x180EBCD30
	private static void CleanupRoots() { }

	// RVA: 0xEBDAC0 Offset: 0xEBC0C0 VA: 0x180EBDAC0
	private static bool EndContainerGUIFromException(Exception exception) { }

	// RVA: 0xEBCAB0 Offset: 0xEBB0B0 VA: 0x180EBCAB0
	internal static void BeginContainerGUI(GUILayoutUtility.LayoutCache cache, Event evt, IMGUIContainer container) { }

	// RVA: 0xEBDB80 Offset: 0xEBC180 VA: 0x180EBDB80
	internal static void EndContainerGUI(Event evt, Rect layoutSize) { }

	// RVA: 0xEBD4B0 Offset: 0xEBBAB0 VA: 0x180EBD4B0
	internal static EventBase CreateEvent(Event systemEvent) { }

	// RVA: 0xEBCDD0 Offset: 0xEBB3D0 VA: 0x180EBCDD0
	internal static EventBase CreateEvent(Event systemEvent, EventType eventType) { }

	// RVA: 0xEBD530 Offset: 0xEBBB30 VA: 0x180EBD530
	private static bool DoDispatch(BaseVisualElementPanel panel) { }

	// RVA: 0xEBDDC0 Offset: 0xEBC3C0 VA: 0x180EBDDC0
	internal static void GetAllPanels(List<Panel> panels, ContextType contextType) { }

	// RVA: 0xEBDF30 Offset: 0xEBC530 VA: 0x180EBDF30
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

	// RVA: 0x230A600 Offset: 0x2308C00 VA: 0x18230A600
	public static void BeginSample(UISystemProfilerApi.SampleType type) { }

	// RVA: 0x230A640 Offset: 0x2308C40 VA: 0x18230A640
	public static void EndSample(UISystemProfilerApi.SampleType type) { }

	// RVA: 0x230A5B0 Offset: 0x2308BB0 VA: 0x18230A5B0
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

	[EditorBrowsableAttribute] // RVA: 0x7FD30 Offset: 0x7F130 VA: 0x18007FD30
	[ObsoleteAttribute] // RVA: 0x7FD30 Offset: 0x7F130 VA: 0x18007FD30
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ModifyVertices(List<UIVertex> verts);

}

public interface IMeshModifier // TypeDefIndex: 5033
{	// Methods

	[ObsoleteAttribute] // RVA: 0x7FEA0 Offset: 0x7F2A0 VA: 0x18007FEA0
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

	// RVA: 0x10CEE10 Offset: 0x10CD410 VA: 0x1810CEE10 Slot: 9
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

	// RVA: 0x10CEE20 Offset: 0x10CD420 VA: 0x1810CEE20 Slot: 16
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

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void add_OnServerFound(Action<ServerInfo> value);

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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
[PreserveAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xFD9510 Offset: 0xFD7B10 VA: 0x180FD9510
	public static void SetParent(UIBehaviour self, Transform parent) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xFD9440 Offset: 0xFD7A40 VA: 0x180FD9440
	public static void SetParent(UIBehaviour self, Canvas parent) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xFD9440 Offset: 0xFD7A40 VA: 0x180FD9440
	public static void SetParent(UIBehaviour self, UIBehaviour parent) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xFD9300 Offset: 0xFD7900 VA: 0x180FD9300
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

	// RVA: 0x4ED560 Offset: 0x4EBB60 VA: 0x1804ED560
	public void UpdateFilter(string filter) { }

	// RVA: 0x4ED260 Offset: 0x4EB860 VA: 0x1804ED260
	private void FilterSellOrders(VendingMachine machine, string filter, List<VendingMachine.SellOrder> orders) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4ED4A0 Offset: 0x4EBAA0 VA: 0x1804ED4A0
	private void <UpdateFilter>g__CreateStoreEntry|3_0(VendingMachineMapMarker marker, List<VendingMachine.SellOrder> matchingOrders) { }

}

public class UIMarketSearchOrderEntry : MonoBehaviour // TypeDefIndex: 8804
{	// Fields
	public RustText ItemName; // 0x18
	public GameObject OutOfStockRoot; // 0x20
	public GameObject BpRoot; // 0x28

	// Methods

	// RVA: 0x4ECDF0 Offset: 0x4EB3F0 VA: 0x1804ECDF0
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

	// RVA: 0x4ED0A0 Offset: 0x4EB6A0 VA: 0x1804ED0A0
	public void Populate(VendingMachineMapMarker machine, List<VendingMachine.SellOrder> matchingEntries, UIMarketTerminal terminal) { }

	// RVA: 0x4ECF20 Offset: 0x4EB520 VA: 0x1804ECF20
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
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private MarketTerminal <currentTerminal>k__BackingField; // 0xE0
	private uint _currentVendingMachine; // 0xE8
	private HashSet<uint> _eligibleVendingMachines; // 0xF0
	private List<SellOrderEntry> _shopEntries; // 0xF8
	private Action<SellOrderEntry, int> _onShopEntryAmountChangedCached; // 0x100

	// Properties
	public MarketTerminal currentTerminal { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4EF3A0 Offset: 0x4ED9A0 VA: 0x1804EF3A0
	public MarketTerminal get_currentTerminal() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4EF3B0 Offset: 0x4ED9B0 VA: 0x1804EF3B0
	private void set_currentTerminal(MarketTerminal value) { }

	// RVA: 0x4EEBA0 Offset: 0x4ED1A0 VA: 0x1804EEBA0
	public void Setup(MarketTerminal terminal, List<uint> eligibleVendingMachineIds) { }

	// RVA: 0x4EE650 Offset: 0x4ECC50 VA: 0x1804EE650 Slot: 8
	public override void OpenDialog() { }

	// RVA: 0x4EDFE0 Offset: 0x4EC5E0 VA: 0x1804EDFE0 Slot: 9
	public override void CloseDialog() { }

	// RVA: 0x4EE630 Offset: 0x4ECC30 VA: 0x1804EE630
	public void OnVendingMachineClicked(UIMapVendingMachineMarker marker) { }

	// RVA: 0x4EE960 Offset: 0x4ECF60 VA: 0x1804EE960
	public void SelectVendingMachine(VendingMachine vmData) { }

	// RVA: 0x4EE190 Offset: 0x4EC790 VA: 0x1804EE190
	public void HideVendingMachine(bool immediate = False) { }

	// RVA: 0x4EDB30 Offset: 0x4EC130 VA: 0x1804EDB30 Slot: 10
	public void BuyButtonClicked(int index, int multiplier) { }

	// RVA: 0x4ED930 Offset: 0x4EBF30 VA: 0x1804ED930
	public void AddItemNotice(int itemDefId, int quantity, bool isPending) { }

	// RVA: 0x4EEF30 Offset: 0x4ED530 VA: 0x1804EEF30
	public void UpdateShopDetails(VendingMachine vmData) { }

	// RVA: 0x4EE4B0 Offset: 0x4ECAB0 VA: 0x1804EE4B0
	private void OnShopEntryAmountChanged(SellOrderEntry changedEntry, int newAmount) { }

	// RVA: 0x4EECC0 Offset: 0x4ED2C0 VA: 0x1804EECC0
	public void UpdateIndicators() { }

	// RVA: 0x4EDDB0 Offset: 0x4EC3B0 VA: 0x1804EDDB0
	private bool CanAffordCurrentOrder() { }

	// RVA: 0x4EE3C0 Offset: 0x4EC9C0 VA: 0x1804EE3C0
	public static bool IsOpen(out UIMarketTerminal marketTerminal) { }

	// RVA: 0x4EF330 Offset: 0x4ED930 VA: 0x1804EF330
	public void .ctor() { }

	// RVA: 0x4EF280 Offset: 0x4ED880 VA: 0x1804EF280
	private static void .cctor() { }

}

private sealed class UIMarketTerminal.<>c // TypeDefIndex: 8807
{	// Fields
	public static readonly UIMarketTerminal.<>c <>9; // 0x0
	public static Predicate<SellOrderEntry> <>9__44_0; // 0x8

	// Methods

	// RVA: 0x9FFF60 Offset: 0x9FE560 VA: 0x1809FFF60
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x9FFF00 Offset: 0x9FE500 VA: 0x1809FFF00
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

	// RVA: 0xA04580 Offset: 0xA02B80 VA: 0x180A04580 Slot: 8
	public override void OpenDialog() { }

	// RVA: 0x4C1AB0 Offset: 0x4C00B0 VA: 0x1804C1AB0
	public void .ctor() { }

}

private class UITwitchTrophy.TrophyPage // TypeDefIndex: 8820
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private string <EventTitle>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private string <Logo>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private string <WinningTeam>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private List<string> <TeamMembers>k__BackingField; // 0x28

	// Properties
	public string EventTitle { get; set; }
	public string Logo { get; set; }
	public string WinningTeam { get; set; }
	public List<string> TeamMembers { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_EventTitle() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	public void set_EventTitle(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Logo() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_Logo(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_WinningTeam() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_WinningTeam(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public List<string> get_TeamMembers() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7EE340 Offset: 0x7EC940 VA: 0x1807EE340
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

	// RVA: 0x4D6230 Offset: 0x4D4830 VA: 0x1804D6230 Slot: 6
	protected override void Awake() { }

	// RVA: 0x4D75A0 Offset: 0x4D5BA0 VA: 0x1804D75A0
	public void Init(AIDesign design) { }

	[IteratorStateMachineAttribute] // RVA: 0x7C8D0 Offset: 0x7BCD0 VA: 0x18007C8D0
	// RVA: 0x4D7FF0 Offset: 0x4D65F0 VA: 0x1804D7FF0
	private IEnumerator SetInitialStateContainer(int id) { }

	// RVA: 0x4D8070 Offset: 0x4D6670 VA: 0x1804D8070 Slot: 8
	public void SetVisible(bool flag) { }

	// RVA: 0x4D62C0 Offset: 0x4D48C0 VA: 0x1804D62C0
	public void ClearStates() { }

	// RVA: 0x4D6060 Offset: 0x4D4660 VA: 0x1804D6060
	private void AddNewStateButton() { }

	// RVA: 0x4D6CA0 Offset: 0x4D52A0 VA: 0x1804D6CA0
	public List<AIState> GetAvailableStates() { }

	// RVA: 0x4D70C0 Offset: 0x4D56C0 VA: 0x1804D70C0
	public List<int> GetStateContainerIDs() { }

	// RVA: 0x4D7340 Offset: 0x4D5940 VA: 0x1804D7340
	private BaseStateUI GetStateContainer(int id) { }

	// RVA: 0x4D6E10 Offset: 0x4D5410 VA: 0x1804D6E10
	public int GetNextStateContainerID() { }

	// RVA: 0x4D6130 Offset: 0x4D4730 VA: 0x1804D6130
	public BaseStateUI AddState(AIState state, int stateContainerID) { }

	// RVA: 0x4D65B0 Offset: 0x4D4BB0 VA: 0x1804D65B0
	public void DeleteState(BaseStateUI state) { }

	// RVA: 0x4D6A20 Offset: 0x4D5020 VA: 0x1804D6A20
	public void DuplicateState(BaseStateUI state) { }

	// RVA: 0x4D77F0 Offset: 0x4D5DF0 VA: 0x1804D77F0
	public void OnDebugStateChanged(int previousStateContainerID, int newStateContainerID, int triggerEventID) { }

	// RVA: 0x4D7930 Offset: 0x4D5F30 VA: 0x1804D7930
	public void OnSetDefaultStateClicked() { }

	// RVA: 0x4D7F50 Offset: 0x4D6550 VA: 0x1804D7F50
	public void SetDefaultStateClicked(object value) { }

	// RVA: 0x4D7F10 Offset: 0x4D6510 VA: 0x1804D7F10
	private void SetDefaultOutputStateContainer(int id) { }

	// RVA: 0x4D6AA0 Offset: 0x4D50A0 VA: 0x1804D6AA0
	public void Exit() { }

	// RVA: 0x4D62B0 Offset: 0x4D48B0 VA: 0x1804D62B0
	public void ClearClicked() { }

	// RVA: 0x4D64B0 Offset: 0x4D4AB0 VA: 0x1804D64B0
	private void Clear() { }

	// RVA: 0x4D7900 Offset: 0x4D5F00 VA: 0x1804D7900
	public void OnSaveClicked() { }

	// RVA: 0x4D7900 Offset: 0x4D5F00 VA: 0x1804D7900
	public void OnSaveEntityClicked() { }

	// RVA: 0x4D7920 Offset: 0x4D5F20 VA: 0x1804D7920
	public void OnSaveServerWideClicked() { }

	// RVA: 0x4D7910 Offset: 0x4D5F10 VA: 0x1804D7910
	public void OnSaveDefaultClicked() { }

	// RVA: 0x4D7B10 Offset: 0x4D6110 VA: 0x1804D7B10
	public void Save(AIDesignScope scope) { }

	// RVA: 0x4D8340 Offset: 0x4D6940 VA: 0x1804D8340
	public void ToggleFade() { }

	// RVA: 0x4D8390 Offset: 0x4D6990 VA: 0x1804D8390
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

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x4D56A0 Offset: 0x4D3CA0 VA: 0x1804D56A0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4D5830 Offset: 0x4D3E30 VA: 0x1804D5830 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0x4DD0C0 Offset: 0x4DB6C0 VA: 0x1804DD0C0
	protected void Awake() { }

	// RVA: 0x4DE6B0 Offset: 0x4DCCB0 VA: 0x1804DE6B0
	public static void Open() { }

	// RVA: 0x4DE600 Offset: 0x4DCC00 VA: 0x1804DE600 Slot: 6
	protected override void OnEnable() { }

	// RVA: 0x4DE270 Offset: 0x4DC870 VA: 0x1804DE270
	public void FocusInput() { }

	// RVA: 0x4DEC60 Offset: 0x4DD260 VA: 0x1804DEC60
	public void SetChannel(Chat.ChatChannel channel, bool autoSwitched = False) { }

	// RVA: 0x4DEB00 Offset: 0x4DD100 VA: 0x1804DEB00
	private void SetChannelLabel(Chat.ChatChannel channel) { }

	// RVA: 0x4DF1C0 Offset: 0x4DD7C0 VA: 0x1804DF1C0
	public void SubmitText() { }

	// RVA: 0x4DD740 Offset: 0x4DBD40 VA: 0x1804DD740
	public bool ClickedInsideTransformOrChild(Transform t) { }

	// RVA: 0x4DD2C0 Offset: 0x4DB8C0 VA: 0x1804DD2C0
	public void Cancel() { }

	// RVA: 0x4DF6C0 Offset: 0x4DDCC0 VA: 0x1804DF6C0
	private void TrimMessages() { }

	// RVA: 0x4DD690 Offset: 0x4DBC90 VA: 0x1804DD690
	private void ClearText() { }

	// RVA: 0x4DD5A0 Offset: 0x4DBBA0 VA: 0x1804DD5A0
	public void ClearChat() { }

	// RVA: 0x4DF7D0 Offset: 0x4DDDD0 VA: 0x1804DF7D0
	public void Update() { }

	// RVA: 0x4DDA10 Offset: 0x4DC010 VA: 0x1804DDA10
	private void CycleActiveChatChannel() { }

	// RVA: 0x4DCEF0 Offset: 0x4DB4F0 VA: 0x1804DCEF0
	public static void Add(Chat.ChatChannel channel, ulong steamid, string text, float volume) { }

	// RVA: 0x4DE320 Offset: 0x4DC920 VA: 0x1804DE320
	private void InternalAdd(Chat.ChatChannel channel, ulong steamid, string text, float volume) { }

	// RVA: 0x4DE620 Offset: 0x4DCC20 VA: 0x1804DE620
	public static void OnMessageClicked(ChatEntry entry) { }

	// RVA: 0x4DEF10 Offset: 0x4DD510 VA: 0x1804DEF10
	public void ShowUserMenu(ChatEntry entry) { }

	// RVA: 0x4DE670 Offset: 0x4DCC70 VA: 0x1804DE670
	public void OpenMuteList() { }

	// RVA: 0x4DF860 Offset: 0x4DDE60 VA: 0x1804DF860
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4DF7A0 Offset: 0x4DDDA0 VA: 0x1804DF7A0
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

	// RVA: 0x4DC490 Offset: 0x4DAA90 VA: 0x1804DC490
	public void Init(ChatEntry entry) { }

	// RVA: 0x4DCE60 Offset: 0x4DB460 VA: 0x1804DCE60
	private void Update() { }

	// RVA: 0x4DCCA0 Offset: 0x4DB2A0 VA: 0x1804DCCA0
	public void OnToggleMuteGlobalClicked() { }

	// RVA: 0x4DCB90 Offset: 0x4DB190 VA: 0x1804DCB90
	public void OnToggleMuteClicked() { }

	// RVA: 0x4DC880 Offset: 0x4DAE80 VA: 0x1804DC880
	public void OnInviteToTeamClicked() { }

	// RVA: 0x4DCDB0 Offset: 0x4DB3B0 VA: 0x1804DCDB0
	public void OnViewSteamProfileClicked() { }

	// RVA: 0x4DC7B0 Offset: 0x4DADB0 VA: 0x1804DC7B0
	public void OnCopyTextClicked() { }

	// RVA: 0x4DC610 Offset: 0x4DAC10 VA: 0x1804DC610
	public void OnClearChatClicked() { }

	// RVA: 0x4DCA10 Offset: 0x4DB010 VA: 0x1804DCA10
	public void OnReportClicked() { }

	// RVA: 0x4DC420 Offset: 0x4DAA20 VA: 0x1804DC420
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

	// RVA: 0x4DF8A0 Offset: 0x4DDEA0 VA: 0x1804DF8A0
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

	// RVA: 0x4E4D60 Offset: 0x4E3360 VA: 0x1804E4D60
	private string get_Key() { }

	// RVA: 0x4E48D0 Offset: 0x4E2ED0 VA: 0x1804E48D0
	public void OnEnable() { }

	// RVA: 0x4E4890 Offset: 0x4E2E90 VA: 0x1804E4890
	public void OnDisable() { }

	// RVA: 0x4E4800 Offset: 0x4E2E00 VA: 0x1804E4800
	public void Load() { }

	// RVA: 0x4E49F0 Offset: 0x4E2FF0 VA: 0x1804E49F0
	public void Save() { }

	// RVA: 0x4E4650 Offset: 0x4E2C50 VA: 0x1804E4650
	public void Erase() { }

	// RVA: 0x4E4BB0 Offset: 0x4E31B0 VA: 0x1804E4BB0
	private void UpdateState() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0x4E4CB0 Offset: 0x4E32B0 VA: 0x1804E4CB0
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

	// RVA: 0x4E5750 Offset: 0x4E3D50 VA: 0x1804E5750
	public void Initialize(PatternFirework firework) { }

	// RVA: 0x4E5D50 Offset: 0x4E4350 VA: 0x1804E5D50
	public void Save() { }

	// RVA: 0x4E5DC0 Offset: 0x4E43C0 VA: 0x1804E5DC0
	public void SelectPlacer() { }

	// RVA: 0x4E5DD0 Offset: 0x4E43D0 VA: 0x1804E5DD0
	public void SelectRemover() { }

	// RVA: 0x4E5DA0 Offset: 0x4E43A0 VA: 0x1804E5DA0
	public void SelectColor(UIColorPickerButton colorButton) { }

	// RVA: 0x4E4E70 Offset: 0x4E3470 VA: 0x1804E4E70
	public void ClearCanvas() { }

	// RVA: 0x4E58B0 Offset: 0x4E3EB0 VA: 0x1804E58B0
	private void PlaceStar(Vector2 localPosition, Color color) { }

	// RVA: 0x4E5860 Offset: 0x4E3E60 VA: 0x1804E5860
	public void PlaceStar() { }

	// RVA: 0x4E5BD0 Offset: 0x4E41D0 VA: 0x1804E5BD0
	public void RemoveStar(UIFireworkStar star) { }

	// RVA: 0x4E5DE0 Offset: 0x4E43E0 VA: 0x1804E5DE0
	private void UpdateStarsPlacedCount() { }

	// RVA: 0x4E52B0 Offset: 0x4E38B0 VA: 0x1804E52B0
	public Vector2 GetMousePositionOnCanvas() { }

	// RVA: 0x4E4DC0 Offset: 0x4E33C0 VA: 0x1804E4DC0
	private Nullable<int> ChooseIndex() { }

	// RVA: 0x4E5540 Offset: 0x4E3B40 VA: 0x1804E5540
	public void Import(PatternFirework.Design design) { }

	// RVA: 0x4E4FF0 Offset: 0x4E35F0 VA: 0x1804E4FF0
	public PatternFirework.Design Export() { }

	// RVA: 0x4E5420 Offset: 0x4E3A20 VA: 0x1804E5420
	private Vector2 GetScaledPositionOnCanvas(Vector2 localPosition) { }

	// RVA: 0x4E5F50 Offset: 0x4E4550 VA: 0x1804E5F50
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

	// RVA: 0x4E5FC0 Offset: 0x4E45C0 VA: 0x1804E5FC0
	public void Initialize(UIFireworkDesigner designer, int index, Color color) { }

	// RVA: 0x4E63A0 Offset: 0x4E49A0 VA: 0x1804E63A0
	private void SetColor(Color color) { }

	// RVA: 0x4E61B0 Offset: 0x4E47B0 VA: 0x1804E61B0 Slot: 27
	public override void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x4E60D0 Offset: 0x4E46D0 VA: 0x1804E60D0 Slot: 23
	public override void OnDrag(PointerEventData eventData) { }

	// RVA: 0x4BAEB0 Offset: 0x4B94B0 VA: 0x1804BAEB0
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

	// RVA: 0x4E4250 Offset: 0x4E2850 VA: 0x1804E4250
	public static bool get_isOpen() { }

	// RVA: 0x4E4150 Offset: 0x4E2750 VA: 0x1804E4150 Slot: 8
	public virtual void OpenDialog() { }

	// RVA: 0x4E4070 Offset: 0x4E2670 VA: 0x1804E4070 Slot: 9
	public virtual void CloseDialog() { }

	// RVA: -1 Offset: -1
	public static T Spawn<T>(string prefab) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BB4A0 Offset: 0x15B9AA0 VA: 0x1815BB4A0
	|-UIDialog.Spawn<ChangeSignText>
	|-UIDialog.Spawn<MLRSUIDialog>
	|-UIDialog.Spawn<MuteListController>
	|-UIDialog.Spawn<ReportBug>
	|-UIDialog.Spawn<ReportPlayer>
	|-UIDialog.Spawn<object>
	|-UIDialog.Spawn<UIMarketTerminal>
	|-UIDialog.Spawn<UITwitchTrophy>
	*/

	// RVA: 0x4E41F0 Offset: 0x4E27F0 VA: 0x1804E41F0
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

	// RVA: 0x4EB6F0 Offset: 0x4E9CF0 VA: 0x1804EB6F0
	public void UpdateColors(Color col, Color col2, float totalAlpha) { }

	// RVA: 0x4EB610 Offset: 0x4E9C10 VA: 0x1804EB610
	public void SetRadius(float newRadius, bool force = False) { }

	// RVA: 0x4EB780 Offset: 0x4E9D80 VA: 0x1804EB780
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
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static Action<UIMapVendingMachineMarker> onClicked; // 0x0

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4ECC90 Offset: 0x4EB290 VA: 0x1804ECC90
	public static void add_onClicked(Action<UIMapVendingMachineMarker> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4ECD40 Offset: 0x4EB340 VA: 0x1804ECD40
	public static void remove_onClicked(Action<UIMapVendingMachineMarker> value) { }

	// RVA: 0x4EC260 Offset: 0x4EA860 VA: 0x1804EC260
	public void SetOutOfStock(bool stock) { }

	// RVA: 0x4EC2C0 Offset: 0x4EA8C0 VA: 0x1804EC2C0
	public void UpdateInfo(VendingMachine vendingMachineData) { }

	// RVA: 0x4EC1C0 Offset: 0x4EA7C0 VA: 0x1804EC1C0
	public void Clicked() { }

	// RVA: 0x4EC220 Offset: 0x4EA820 VA: 0x1804EC220
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

	// RVA: 0x4EBAC0 Offset: 0x4EA0C0 VA: 0x1804EBAC0
	private void OnEnable() { }

	// RVA: 0x4EBEF0 Offset: 0x4EA4F0 VA: 0x1804EBEF0
	public void UpdateDisplay(List<VendingMachine> vendingMachines, List<bool> outOfStock) { }

	// RVA: 0x4EB8D0 Offset: 0x4E9ED0 VA: 0x1804EB8D0
	private UIMapVendingMachineMarker GetLine() { }

	// RVA: 0x4EBB70 Offset: 0x4EA170 VA: 0x1804EBB70
	public void ToggleOpen() { }

	// RVA: 0x4EC150 Offset: 0x4EA750 VA: 0x1804EC150
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4EBEC0 Offset: 0x4EA4C0 VA: 0x1804EBEC0
	private void <ToggleOpen>b__8_0() { }

}

public class UIPaintBox : MonoBehaviour // TypeDefIndex: 10967
{	// Fields
	public UIPaintBox.OnBrushChanged onBrushChanged; // 0x18
	public Brush brush; // 0x20

	// Methods

	// RVA: 0xA00740 Offset: 0x9FED40 VA: 0x180A00740
	public void UpdateBrushSize(int size) { }

	// RVA: 0xA00880 Offset: 0x9FEE80 VA: 0x180A00880
	public void UpdateBrushTexture(Texture2D tex) { }

	// RVA: 0xA006A0 Offset: 0x9FECA0 VA: 0x180A006A0
	public void UpdateBrushColor(Color col) { }

	// RVA: 0xA00640 Offset: 0x9FEC40 VA: 0x180A00640
	public void UpdateBrushAlpha(float a) { }

	// RVA: 0xA00720 Offset: 0x9FED20 VA: 0x180A00720
	public void UpdateBrushEraser(bool b) { }

	// RVA: 0xA005F0 Offset: 0x9FEBF0 VA: 0x180A005F0
	private void OnChanged() { }

	// RVA: 0xA008E0 Offset: 0x9FEEE0 VA: 0x180A008E0
	public void .ctor() { }

}

public class UIPaintBox.OnBrushChanged : UnityEvent<Brush> // TypeDefIndex: 10968
{	// Methods

	// RVA: 0x9FE040 Offset: 0x9FC640 VA: 0x1809FE040
	public void .ctor() { }

}

public class UIBuffs : SingletonComponent<UIBuffs> // TypeDefIndex: 10971
{	// Fields
	public bool Enabled; // 0x18
	public Transform PrefabBuffIcon; // 0x20

	// Methods

	// RVA: 0x4DBD20 Offset: 0x4DA320 VA: 0x1804DBD20
	public void Refresh(PlayerModifiers modifiers) { }

	// RVA: 0x4DBEE0 Offset: 0x4DA4E0 VA: 0x1804DBEE0
	private void RemoveAll() { }

	// RVA: 0x4DC0E0 Offset: 0x4DA6E0 VA: 0x1804DC0E0
	public void .ctor() { }

}

public class UIBuffsIcon : SingletonComponent<UIBuffsIcon>, IPointerEnterHandler, IEventSystemHandler // TypeDefIndex: 10972
{	// Fields
	public TextMeshProUGUI Text; // 0x18
	public Tooltip ToolTip; // 0x20
	public CanvasGroup Group; // 0x28
	[HideInInspector] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public string Buffs; // 0x30

	// Methods

	// RVA: 0x4DB5C0 Offset: 0x4D9BC0 VA: 0x1804DB5C0 Slot: 9
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x4DB5D0 Offset: 0x4D9BD0 VA: 0x1804DB5D0
	private void Refresh() { }

	// RVA: 0x4DB7A0 Offset: 0x4D9DA0 VA: 0x1804DB7A0
	public void Refresh(PlayerModifiers modifiers) { }

	// RVA: 0x4DBCC0 Offset: 0x4DA2C0 VA: 0x1804DBCC0
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

	// RVA: 0x4E0840 Offset: 0x4DEE40 VA: 0x1804E0840
	private static BasePlayer get_LocalPlayerEntity() { }

	// RVA: 0x4E0490 Offset: 0x4DEA90 VA: 0x1804E0490
	private void OnEnable() { }

	// RVA: 0x4DFB80 Offset: 0x4DE180 VA: 0x1804DFB80
	public void CompassUpdate() { }

	// RVA: 0x4E06C0 Offset: 0x4DECC0 VA: 0x1804E06C0
	private void UpdateCompassMarker(Vector3 rot, CompassMapMarker marker, MapNote forNote) { }

	// RVA: 0x4E0580 Offset: 0x4DEB80 VA: 0x1804E0580
	private void UpdateCompassMarker(Vector3 rot, CompassMissionMarker marker, BaseMission.MissionInstance mission) { }

	// RVA: 0x4DF8D0 Offset: 0x4DDED0 VA: 0x1804DF8D0
	private void CalculateCompassPosition(Vector3 worldPosition, Vector3 eyeRot, out bool show, out float xPos) { }

	// RVA: 0x4E0430 Offset: 0x4DEA30 VA: 0x1804E0430
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

	// RVA: 0x4E44E0 Offset: 0x4E2AE0 VA: 0x1804E44E0
	private void Start() { }

	// RVA: 0x4E4500 Offset: 0x4E2B00 VA: 0x1804E4500
	private void Update() { }

	// RVA: 0x4E4630 Offset: 0x4E2C30 VA: 0x1804E4630
	public void .ctor() { }

}

public class UIFishing : SingletonComponent<UIFishing> // TypeDefIndex: 10975
{	// Fields
	public Slider TensionLine; // 0x18
	public Image FillImage; // 0x20
	public Gradient FillGradient; // 0x28
	private float lerpedValue; // 0x30

	// Methods

	// RVA: 0x4E63F0 Offset: 0x4E49F0 VA: 0x1804E63F0
	private void Start() { }

	// RVA: 0x4E6420 Offset: 0x4E4A20 VA: 0x1804E6420
	public void Toggle(bool state) { }

	// RVA: 0x4E63E0 Offset: 0x4E49E0 VA: 0x1804E63E0
	public void ForceSetValue(float value) { }

	// RVA: 0x4E64C0 Offset: 0x4E4AC0 VA: 0x1804E64C0
	public void UpdateInfo(float tension) { }

	// RVA: 0x4E65D0 Offset: 0x4E4BD0 VA: 0x1804E65D0
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
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private CanvasGroup <canvasGroup>k__BackingField; // 0x78
	private bool visible; // 0x80

	// Properties
	public CanvasGroup canvasGroup { get; set; }
	private bool shouldShowHud { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4E8520 Offset: 0x4E6B20 VA: 0x1804E8520
	public CanvasGroup get_canvasGroup() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4E8840 Offset: 0x4E6E40 VA: 0x1804E8840
	private void set_canvasGroup(CanvasGroup value) { }

	// RVA: 0x4E7AB0 Offset: 0x4E60B0 VA: 0x1804E7AB0 Slot: 6
	protected override void Awake() { }

	// RVA: 0x4E8170 Offset: 0x4E6770 VA: 0x1804E8170
	private void Update() { }

	// RVA: 0x4E7BF0 Offset: 0x4E61F0 VA: 0x1804E7BF0
	private void UpdateVitals() { }

	// RVA: 0x4E8530 Offset: 0x4E6B30 VA: 0x1804E8530
	private bool get_shouldShowHud() { }

	// RVA: 0x4E7B50 Offset: 0x4E6150 VA: 0x1804E7B50 Slot: 8
	public void SetVisible(bool b) { }

	// RVA: 0x4E84C0 Offset: 0x4E6AC0 VA: 0x1804E84C0
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

	// RVA: 0x4E63F0 Offset: 0x4E49F0 VA: 0x1804E63F0
	private void Start() { }

	// RVA: 0xA02FC0 Offset: 0xA015C0 VA: 0x180A02FC0
	public void StartRecording(RecorderTool forRecorder) { }

	// RVA: 0xA03030 Offset: 0xA01630 VA: 0x180A03030
	public void StopRecording() { }

	// RVA: 0xA03080 Offset: 0xA01680 VA: 0x180A03080
	private void Update() { }

	// RVA: 0xA02FA0 Offset: 0xA015A0 VA: 0x180A02FA0
	public void OnEscape() { }

	// RVA: 0xA032F0 Offset: 0xA018F0 VA: 0x180A032F0
	public void .ctor() { }

}

public class UIUnderlay : SingletonComponent<UIUnderlay> // TypeDefIndex: 10978
{	// Fields
	public GameObject damageDirectional; // 0x18
	public GameObject waterDirectional; // 0x20

	// Methods

	// RVA: 0xA04D70 Offset: 0xA03370 VA: 0x180A04D70
	public void DirectionalDamage(Vector3 pos, DamageType dmgType, float damageTotal) { }

	// RVA: 0xA04880 Offset: 0xA02E80 VA: 0x180A04880
	public void DirectionalDamage_OLD(Vector3 pos, DamageType dmgType) { }

	// RVA: 0xA05150 Offset: 0xA03750 VA: 0x180A05150
	private GameObject GetDamageTypePrefab(DamageType dmgType) { }

	// RVA: 0xA05330 Offset: 0xA03930 VA: 0x180A05330
	private Vector2 RectProjectEdge(Rect r, Vector2 v) { }

	// RVA: 0xA054E0 Offset: 0xA03AE0 VA: 0x180A054E0
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

	// RVA: 0x4D9500 Offset: 0x4D7B00 VA: 0x1804D9500
	public void ChangeCategory(string strCategory) { }

	// RVA: 0x4DB310 Offset: 0x4D9910 VA: 0x1804DB310
	private void UpdateFlash() { }

	// RVA: 0x4DA680 Offset: 0x4D8C80 VA: 0x1804DA680
	private void RetireChildren(GameObject go) { }

	// RVA: 0x4DA460 Offset: 0x4D8A60 VA: 0x1804DA460 Slot: 6
	protected override void OnEnable() { }

	// RVA: 0x4DA260 Offset: 0x4D8860 VA: 0x1804DA260 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x4D9A40 Offset: 0x4D8040 VA: 0x1804D9A40
	public static IEnumerable<ItemBlueprint> GetForCategory(ItemCategory category) { }

	// RVA: 0x4D99F0 Offset: 0x4D7FF0 VA: 0x1804D99F0
	public static IEnumerable<ItemBlueprint> GetCraftableForCategory(ItemCategory category) { }

	// RVA: 0x4D9640 Offset: 0x4D7C40 VA: 0x1804D9640
	public static int CountCraftableForCategory(ItemCategory category) { }

	// RVA: 0x4D96A0 Offset: 0x4D7CA0 VA: 0x1804D96A0
	public static int CountForCategory(ItemCategory category, bool onlyUnlocked = True) { }

	// RVA: 0x4DAA70 Offset: 0x4D9070 VA: 0x1804DAA70
	public void UpdateBlueprintList() { }

	// RVA: 0x4D9980 Offset: 0x4D7F80 VA: 0x1804D9980
	private BlueprintCategoryButton[] GetCategoryButtons() { }

	// RVA: 0x4DADF0 Offset: 0x4D93F0 VA: 0x1804DADF0
	private void UpdateBlueprints(IEnumerable<ItemBlueprint> list) { }

	// RVA: 0x4DA4A0 Offset: 0x4D8AA0 VA: 0x1804DA4A0
	public static void Refresh() { }

	// RVA: 0x4DA750 Offset: 0x4D8D50 VA: 0x1804DA750
	public void Search(string search) { }

	// RVA: 0x4D9300 Offset: 0x4D7900 VA: 0x1804D9300
	public static void BounceFavouriteCategories() { }

	// RVA: 0x4D94E0 Offset: 0x4D7AE0 VA: 0x1804D94E0
	public void BounceFavouriteCategory() { }

	// RVA: 0x4DB520 Offset: 0x4D9B20 VA: 0x1804DB520
	public void .ctor() { }

	// RVA: 0x4DB4A0 Offset: 0x4D9AA0 VA: 0x1804DB4A0
	private static void .cctor() { }

}

private sealed class UIBlueprints.<>c__DisplayClass20_0 // TypeDefIndex: 10996
{	// Fields
	public ItemCategory category; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4D5AB0 Offset: 0x4D40B0 VA: 0x1804D5AB0
	internal bool <GetForCategory>b__3(ItemBlueprint x) { }

	// RVA: 0x4D5BC0 Offset: 0x4D41C0 VA: 0x1804D5BC0
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

	// RVA: 0x4D6000 Offset: 0x4D4600 VA: 0x1804D6000
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4D58A0 Offset: 0x4D3EA0 VA: 0x1804D58A0
	internal bool <GetForCategory>b__20_0(ItemBlueprint x) { }

	// RVA: 0x4D5910 Offset: 0x4D3F10 VA: 0x1804D5910
	internal bool <GetForCategory>b__20_1(ItemBlueprint x) { }

	// RVA: 0x4D5970 Offset: 0x4D3F70 VA: 0x1804D5970
	internal int <GetForCategory>b__20_2(ItemBlueprint y) { }

	// RVA: 0x4D59D0 Offset: 0x4D3FD0 VA: 0x1804D59D0
	internal bool <GetForCategory>b__20_4(ItemBlueprint x) { }

	// RVA: 0x4D5A30 Offset: 0x4D4030 VA: 0x1804D5A30
	internal Rarity <GetForCategory>b__20_5(ItemBlueprint x) { }

	// RVA: 0x4D5A50 Offset: 0x4D4050 VA: 0x1804D5A50
	internal bool <GetForCategory>b__20_7(ItemBlueprint x) { }

	// RVA: 0x4D5A30 Offset: 0x4D4030 VA: 0x1804D5A30
	internal Rarity <GetForCategory>b__20_8(ItemBlueprint x) { }

}

private sealed class UIBlueprints.<>c__DisplayClass28_0 // TypeDefIndex: 10998
{	// Fields
	public string search; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4D5C60 Offset: 0x4D4260 VA: 0x1804D5C60
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

	// RVA: 0x4D8820 Offset: 0x4D6E20 VA: 0x1804D8820 Slot: 6
	protected override void Awake() { }

	// RVA: 0x4D8960 Offset: 0x4D6F60 VA: 0x1804D8960
	public ItemIcon GetItemIconAtSlot(int slot) { }

	// RVA: 0x4D89D0 Offset: 0x4D6FD0 VA: 0x1804D89D0
	public void .ctor() { }

}

private sealed class UIBelt.<>c // TypeDefIndex: 11053
{	// Fields
	public static readonly UIBelt.<>c <>9; // 0x0
	public static Func<ItemIcon, int> <>9__1_0; // 0x8

	// Methods

	// RVA: 0x4D5F40 Offset: 0x4D4540 VA: 0x1804D5F40
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4D5880 Offset: 0x4D3E80 VA: 0x1804D5880
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

	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	// RVA: 0x4E14B0 Offset: 0x4DFAB0 VA: 0x1804E14B0
	public static void togglecontacts() { }

	// RVA: 0x4E08E0 Offset: 0x4DEEE0 VA: 0x1804E08E0 Slot: 6
	protected override void Awake() { }

	// RVA: 0x4E0E00 Offset: 0x4DF400 VA: 0x1804E0E00
	public static void Open() { }

	// RVA: 0x4E12B0 Offset: 0x4DF8B0 VA: 0x1804E12B0
	public static void Toggle() { }

	// RVA: 0x4E0B00 Offset: 0x4DF100 VA: 0x1804E0B00
	public static void Close() { }

	// RVA: 0x4E13C0 Offset: 0x4DF9C0 VA: 0x1804E13C0
	private void Update() { }

	// RVA: 0x4E1090 Offset: 0x4DF690 VA: 0x1804E1090
	private bool ShouldShow() { }

	// RVA: 0x4E0D90 Offset: 0x4DF390 VA: 0x1804E0D90
	public void ContactsPressed() { }

	// RVA: 0x4E1450 Offset: 0x4DFA50 VA: 0x1804E1450
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

	// RVA: 0x4E1DA0 Offset: 0x4E03A0 VA: 0x1804E1DA0 Slot: 6
	protected override void Awake() { }

	// RVA: 0x4E2390 Offset: 0x4E0990 VA: 0x1804E2390
	public static void Open() { }

	// RVA: 0x4E2870 Offset: 0x4E0E70 VA: 0x1804E2870
	public static void Toggle() { }

	// RVA: 0x4E1FC0 Offset: 0x4E05C0 VA: 0x1804E1FC0
	public static void Close() { }

	// RVA: 0x4E2980 Offset: 0x4E0F80 VA: 0x1804E2980
	private void Update() { }

	// RVA: 0x4E2610 Offset: 0x4E0C10 VA: 0x1804E2610
	private bool ShouldShow() { }

	// RVA: 0x4E2A10 Offset: 0x4E1010 VA: 0x1804E2A10
	public void .ctor() { }

}

public class UIIntegerEntry : MonoBehaviour // TypeDefIndex: 11056
{	// Fields
	public InputField textEntry; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Action textChanged; // 0x20

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4E92E0 Offset: 0x4E78E0 VA: 0x1804E92E0
	public void add_textChanged(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4E9380 Offset: 0x4E7980 VA: 0x1804E9380
	public void remove_textChanged(Action value) { }

	// RVA: 0x4E9190 Offset: 0x4E7790 VA: 0x1804E9190
	public void OnAmountTextChanged() { }

	// RVA: 0x4E9260 Offset: 0x4E7860 VA: 0x1804E9260
	public void SetAmount(int amount) { }

	// RVA: 0x4E9150 Offset: 0x4E7750 VA: 0x1804E9150
	public int GetIntAmount() { }

	// RVA: 0x4E91B0 Offset: 0x4E77B0 VA: 0x1804E91B0
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

	// RVA: 0x4E9420 Offset: 0x4E7A20 VA: 0x1804E9420 Slot: 6
	protected override void Awake() { }

	// RVA: 0x4EA080 Offset: 0x4E8680 VA: 0x1804EA080
	public static void Open(bool selectHeldItem = True) { }

	// RVA: 0x4EAF30 Offset: 0x4E9530 VA: 0x1804EAF30
	public static void ToggleInventory() { }

	// RVA: 0x4E97D0 Offset: 0x4E7DD0 VA: 0x1804E97D0
	public static void Close() { }

	// RVA: 0x4EA690 Offset: 0x4E8C90 VA: 0x1804EA690
	private static void PlayCloseSound() { }

	// RVA: 0x4E9FC0 Offset: 0x4E85C0 VA: 0x1804E9FC0
	public static void OpenLoot(string lootType) { }

	// RVA: 0x4E9690 Offset: 0x4E7C90 VA: 0x1804E9690
	public static bool CanQuickLootItem(Item item, ItemContainerSource containerSource) { }

	// RVA: 0x4EB150 Offset: 0x4E9750 VA: 0x1804EB150
	private void Update() { }

	// RVA: 0x4EACD0 Offset: 0x4E92D0 VA: 0x1804EACD0
	private bool ShouldShow() { }

	// RVA: 0x4E97A0 Offset: 0x4E7DA0 VA: 0x1804E97A0
	public void CloseUnderwearPicker() { }

	// RVA: 0x4EB0B0 Offset: 0x4E96B0 VA: 0x1804EB0B0
	public void ToggleUnderwearPicker() { }

	// RVA: 0x4E9F50 Offset: 0x4E8550 VA: 0x1804E9F50
	public void ContactsPressed() { }

	// RVA: 0x4EB460 Offset: 0x4E9A60 VA: 0x1804EB460
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

	// RVA: 0xA003F0 Offset: 0x9FE9F0 VA: 0x180A003F0
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

	// RVA: 0xA002A0 Offset: 0x9FE8A0 VA: 0x180A002A0
	public void Init(Recipe.RecipeIngredient ingredient) { }

	// RVA: 0xA00250 Offset: 0x9FE850 VA: 0x180A00250
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

	// RVA: 0xA01A20 Offset: 0xA00020 VA: 0x180A01A20
	public RectTransform get_rectTransform() { }

	// RVA: 0xA01790 Offset: 0x9FFD90 VA: 0x180A01790
	private void Start() { }

	// RVA: 0xA01940 Offset: 0x9FFF40 VA: 0x180A01940
	private void Update() { }

	// RVA: 0xA015E0 Offset: 0x9FFBE0 VA: 0x180A015E0
	public void SetupTexture() { }

	// RVA: 0xA00A00 Offset: 0x9FF000 VA: 0x180A00A00
	public void Clear() { }

	// RVA: 0xA01500 Offset: 0x9FFB00 VA: 0x180A01500
	private void OnDestroy() { }

	// RVA: 0xA00970 Offset: 0x9FEF70 VA: 0x180A00970
	public void ClearTexture() { }

	// RVA: 0xA014C0 Offset: 0x9FFAC0 VA: 0x180A014C0
	public void FromData(byte[] data) { }

	// RVA: 0xA01880 Offset: 0x9FFE80 VA: 0x180A01880
	public byte[] ToPng(BaseEntity ent) { }

	// RVA: 0xA017B0 Offset: 0x9FFDB0 VA: 0x180A017B0
	public byte[] ToJpg(BaseEntity ent, int quality) { }

	// RVA: 0xA00A10 Offset: 0x9FF010 VA: 0x180A00A10
	public void DrawTexture(Vector2 pos, Vector2 size, Texture2D brush, Color textureColor, UIPaintableImage.DrawMode mode) { }

	// RVA: 0xA019D0 Offset: 0x9FFFD0 VA: 0x180A019D0
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

	// RVA: 0xA01A80 Offset: 0xA00080 VA: 0x180A01A80
	public static void Add(UIParticle particleSource, RectTransform spawnPosition, RectTransform particleCanvas) { }

	// RVA: 0xA01E10 Offset: 0xA00410 VA: 0x180A01E10
	private void Start() { }

	// RVA: 0xA020A0 Offset: 0xA006A0 VA: 0x180A020A0
	private void Update() { }

	// RVA: 0xA01DB0 Offset: 0xA003B0 VA: 0x180A01DB0
	private void Die() { }

	// RVA: 0xA023D0 Offset: 0xA009D0 VA: 0x180A023D0
	public void .ctor() { }

}

public static class UISound // TypeDefIndex: 11199
{	// Fields
	private static AudioSource source; // 0x32FF

	// Methods

	// RVA: 0xA04370 Offset: 0xA02970 VA: 0x180A04370
	private static AudioSource GetAudioSource() { }

	// RVA: 0xA04490 Offset: 0xA02A90 VA: 0x180A04490
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

	// RVA: 0xA026C0 Offset: 0xA00CC0 VA: 0x180A026C0 Slot: 6
	protected override void Awake() { }

	// RVA: 0xA02A60 Offset: 0xA01060 VA: 0x180A02A60 Slot: 8
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0xA02A70 Offset: 0xA01070 VA: 0x180A02A70 Slot: 9
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0xA02C10 Offset: 0xA01210 VA: 0x180A02C10
	private void Update() { }

	// RVA: 0xA02B50 Offset: 0xA01150 VA: 0x180A02B50
	private void ToggleDisplay() { }

	// RVA: 0xA02470 Offset: 0xA00A70 VA: 0x180A02470
	private void ApplyRotation() { }

	// RVA: 0xA02880 Offset: 0xA00E80 VA: 0x180A02880
	private void HandleRotationControl() { }

	// RVA: 0xA02A80 Offset: 0xA01080 VA: 0x180A02A80
	public void ResetToDefault() { }

	// RVA: 0xA02750 Offset: 0xA00D50 VA: 0x180A02750
	private Transform GetPlayerModel() { }

	// RVA: 0xA02D40 Offset: 0xA01340 VA: 0x180A02D40
	public void .ctor() { }

}

public class UIInvertedMaskImage : Image // TypeDefIndex: 11207
{	// Fields
	private Material cachedMaterial; // 0x100

	// Properties
	public override Material materialForRendering { get; }

	// Methods

	// RVA: 0x4EB520 Offset: 0x4E9B20 VA: 0x1804EB520 Slot: 34
	public override Material get_materialForRendering() { }

	// RVA: 0x4EB4C0 Offset: 0x4E9AC0 VA: 0x1804EB4C0
	public void .ctor() { }

}

public class UIAutoPanelCloser : MonoBehaviour // TypeDefIndex: 11245
{	// Fields
	public UIDialog Dialog; // 0x18

	// Methods

	// RVA: 0x4D83F0 Offset: 0x4D69F0 VA: 0x1804D83F0
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

	// RVA: 0x4D8680 Offset: 0x4D6C80 VA: 0x1804D8680
	public static float get_currentMax() { }

	// RVA: 0x4D8620 Offset: 0x4D6C20 VA: 0x1804D8620
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

	// RVA: 0x4D8A30 Offset: 0x4D7030 VA: 0x1804D8A30
	public static void AddOverlay(UIBlackoutOverlay.blackoutType type, UIBlackoutOverlay overlay) { }

	// RVA: 0x4D8C90 Offset: 0x4D7290 VA: 0x1804D8C90
	public static UIBlackoutOverlay Get(UIBlackoutOverlay.blackoutType type) { }

	// RVA: 0x4D8D70 Offset: 0x4D7370 VA: 0x1804D8D70
	public static void HideAll() { }

	// RVA: 0x4D8AF0 Offset: 0x4D70F0 VA: 0x1804D8AF0
	private void Awake() { }

	// RVA: 0x4D8ED0 Offset: 0x4D74D0 VA: 0x1804D8ED0
	public void ResetPosition() { }

	// RVA: 0x4D9060 Offset: 0x4D7660 VA: 0x1804D9060
	public void SetPosition(Vector3 position) { }

	// RVA: 0x2FA9E0 Offset: 0x2F8FE0 VA: 0x1802FA9E0
	public Vector3 GetPosition() { }

	// RVA: 0x4D9100 Offset: 0x4D7700 VA: 0x1804D9100
	public void Update() { }

	// RVA: 0x4D8FB0 Offset: 0x4D75B0 VA: 0x1804D8FB0
	public void SetAlpha(float alpha) { }

	// RVA: 0x4D8C00 Offset: 0x4D7200 VA: 0x1804D8C00
	public float GetAlpha() { }

	// RVA: 0x4D9280 Offset: 0x4D7880 VA: 0x1804D9280
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

	// RVA: 0x4DC290 Offset: 0x4DA890 VA: 0x1804DC290
	public void Show() { }

	// RVA: 0x4DC140 Offset: 0x4DA740 VA: 0x1804DC140
	public void Hide() { }

	// RVA: 0x4DC170 Offset: 0x4DA770 VA: 0x1804DC170
	public void SetFocusMode(CameraFocusMode mode) { }

	// RVA: 0x4DC3C0 Offset: 0x4DA9C0 VA: 0x1804DC3C0
	public void .ctor() { }

	// RVA: 0x4DC2C0 Offset: 0x4DA8C0 VA: 0x1804DC2C0
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

	// RVA: 0x4E15D0 Offset: 0x4DFBD0 VA: 0x1804E15D0 Slot: 6
	protected override void Awake() { }

	// RVA: 0x4E1B30 Offset: 0x4E0130 VA: 0x1804E1B30 Slot: 8
	public void SetVisible(bool b) { }

	// RVA: 0x4E1650 Offset: 0x4DFC50 VA: 0x1804E1650
	public void Exit() { }

	// RVA: 0x4E1660 Offset: 0x4DFC60 VA: 0x1804E1660
	public void FastForward() { }

	// RVA: 0x4E1D30 Offset: 0x4E0330 VA: 0x1804E1D30
	public void Update() { }

	// RVA: 0x4E1670 Offset: 0x4DFC70 VA: 0x1804E1670
	public void Refresh(bool force = False) { }

	// RVA: 0x4E1A70 Offset: 0x4E0070 VA: 0x1804E1A70
	public void ResponsePressed(int responseIndex) { }

	// RVA: 0x4E1D40 Offset: 0x4E0340 VA: 0x1804E1D40
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
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private RespawnInformation <currentRespawnInfo>k__BackingField; // 0x90

	// Properties
	public RespawnInformation currentRespawnInfo { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4E4050 Offset: 0x4E2650 VA: 0x1804E4050
	public RespawnInformation get_currentRespawnInfo() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4E4060 Offset: 0x4E2660 VA: 0x1804E4060
	private void set_currentRespawnInfo(RespawnInformation value) { }

	// RVA: 0x4E2A70 Offset: 0x4E1070 VA: 0x1804E2A70 Slot: 6
	protected override void Awake() { }

	// RVA: 0x4E3120 Offset: 0x4E1720 VA: 0x1804E3120 Slot: 8
	public void SetVisible(bool b) { }

	// RVA: 0x4E2D80 Offset: 0x4E1380 VA: 0x1804E2D80
	private void OnEnable() { }

	// RVA: 0x4E2EF0 Offset: 0x4E14F0 VA: 0x1804E2EF0
	public void OnRespawn() { }

	// RVA: 0x4E3950 Offset: 0x4E1F50 VA: 0x1804E3950
	private void UpdateRespawnInformation(RespawnInformation info) { }

	// RVA: 0x4E3C00 Offset: 0x4E2200 VA: 0x1804E3C00
	private void UpdateRespawnOptions(List<RespawnInformation.SpawnOptions> spawnOptions) { }

	// RVA: 0x4E2CA0 Offset: 0x4E12A0 VA: 0x1804E2CA0
	private SleepingBagButton GetSleepingBagButton() { }

	// RVA: 0x4E2F80 Offset: 0x4E1580 VA: 0x1804E2F80
	public void PopulateDeathInfo() { }

	// RVA: 0x4E2A90 Offset: 0x4E1090 VA: 0x1804E2A90
	public void EnableInteraction() { }

	// RVA: 0x4E2E10 Offset: 0x4E1410 VA: 0x1804E2E10
	public static void OnRespawnInformation(RespawnInformation info) { }

	// RVA: 0x4E2FA0 Offset: 0x4E15A0 VA: 0x1804E2FA0
	public void ReportCheater() { }

	// RVA: 0x4E2B30 Offset: 0x4E1130 VA: 0x1804E2B30
	public UIDeathScreen.RespawnColourScheme GetRespawnColourScheme(RespawnInformation.SpawnOptions option) { }

	// RVA: 0x4E2AC0 Offset: 0x4E10C0 VA: 0x1804E2AC0
	public UIDeathScreen.RespawnColourScheme GetRespawnColourScheme(int index) { }

	// RVA: 0x4E3860 Offset: 0x4E1E60 VA: 0x1804E3860
	public void UpdateBottomScrollGradient() { }

	// RVA: 0x4E3FC0 Offset: 0x4E25C0 VA: 0x1804E3FC0
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

	// RVA: 0x4E42D0 Offset: 0x4E28D0 VA: 0x1804E42D0
	public static bool EscapePressed() { }

	// RVA: 0x4E4450 Offset: 0x4E2A50 VA: 0x1804E4450
	public void .ctor() { }

}

public class UIFogOverlay : MonoBehaviour // TypeDefIndex: 11254
{	// Fields
	public static UIFogOverlay Instance; // 0x0
	public CanvasGroup group; // 0x18
	public Color baseColor; // 0x20
	public Image overlayImage; // 0x30

	// Methods

	// RVA: 0x4E66A0 Offset: 0x4E4CA0 VA: 0x1804E66A0
	public static void SetAlpha(float alpha) { }

	// RVA: 0x4E6630 Offset: 0x4E4C30 VA: 0x1804E6630
	public void OnEnable() { }

	// RVA: 0x4E6700 Offset: 0x4E4D00 VA: 0x1804E6700
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

	// RVA: 0x4E6E40 Offset: 0x4E5440 VA: 0x1804E6E40
	public void Init(GrowableGene gene) { }

	// RVA: 0x4E6D50 Offset: 0x4E5350 VA: 0x1804E6D50
	public void InitPrevious(GrowableGene gene) { }

	// RVA: 0x4E6D20 Offset: 0x4E5320 VA: 0x1804E6D20
	public void Hide() { }

	// RVA: 0x4E6F40 Offset: 0x4E5540 VA: 0x1804E6F40
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

	// RVA: 0x4E76A0 Offset: 0x4E5CA0 VA: 0x1804E76A0
	public void Init(GrowableGenes genes) { }

	// RVA: 0x4E6F70 Offset: 0x4E5570 VA: 0x1804E6F70
	public void InitDualRow(GrowableGenes genes, bool firstRow) { }

	// RVA: 0x4E6F90 Offset: 0x4E5590 VA: 0x1804E6F90
	private void InitFirstRow(GrowableGenes genes) { }

	// RVA: 0x4E72D0 Offset: 0x4E58D0 VA: 0x1804E72D0
	private void InitSecondRow(GrowableGenes genes) { }

	// RVA: 0x4E7890 Offset: 0x4E5E90 VA: 0x1804E7890
	private void ShowDiagLink(int index, float rotation, GrowableGene nextGene) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class UIIngame : SingletonComponent<UIIngame> // TypeDefIndex: 11257
{	// Methods

	// RVA: 0x4E8E00 Offset: 0x4E7400 VA: 0x1804E8E00
	private void Update() { }

	// RVA: 0x4E8850 Offset: 0x4E6E50 VA: 0x1804E8850
	private IUIScreen DetermineActiveUI() { }

	// RVA: 0x4E90F0 Offset: 0x4E76F0 VA: 0x1804E90F0
	public void .ctor() { }

}

public class UIPrefab : MonoBehaviour // TypeDefIndex: 11258
{	// Fields
	public GameObject prefabSource; // 0x18
	internal GameObject createdGameObject; // 0x20

	// Methods

	// RVA: 0xA02DB0 Offset: 0xA013B0 VA: 0x180A02DB0
	private void Awake() { }

	// RVA: 0xA02EF0 Offset: 0xA014F0 VA: 0x180A02EF0
	public void SetVisible(bool visible) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public abstract class UIRoot : MonoBehaviour // TypeDefIndex: 11259
{	// Fields
	private GraphicRaycaster[] graphicRaycasters; // 0x18
	public Canvas overlayCanvas; // 0x20

	// Methods

	// RVA: 0xA03760 Offset: 0xA01D60 VA: 0x180A03760
	private void ToggleRaycasters(bool state) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0xA03710 Offset: 0xA01D10 VA: 0x180A03710 Slot: 5
	protected virtual void Start() { }

	// RVA: 0x95F920 Offset: 0x95DF20 VA: 0x18095F920
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

	// RVA: 0xA036A0 Offset: 0xA01CA0 VA: 0x180A036A0
	public static Canvas get_DragOverlayCanvas() { }

	// RVA: 0xA03350 Offset: 0xA01950 VA: 0x180A03350 Slot: 4
	protected override void Awake() { }

	// RVA: 0xA033B0 Offset: 0xA019B0 VA: 0x180A033B0 Slot: 6
	protected override void Refresh() { }

	// RVA: 0xA03650 Offset: 0xA01C50 VA: 0x180A03650
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

public class UIScale : MonoBehaviour, IClientComponent // TypeDefIndex: 11262
{	// Fields
	public CanvasScaler scaler; // 0x18

	// Methods

	// RVA: 0xA03810 Offset: 0xA01E10 VA: 0x180A03810
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

	// RVA: 0xA039B0 Offset: 0xA01FB0 VA: 0x180A039B0
	private void Start() { }

	// RVA: 0xA03A60 Offset: 0xA02060 VA: 0x180A03A60
	private void Update() { }

	// RVA: 0xA03BF0 Offset: 0xA021F0 VA: 0x180A03BF0
	public void .ctor() { }

}

public class UIScopeOverlay : MonoBehaviour // TypeDefIndex: 11264
{	// Fields
	public CanvasGroup group; // 0x18
	public static UIScopeOverlay instance; // 0x0
	public Image scopeImage; // 0x20
	private Vector3 initialPosition; // 0x28

	// Methods

	// RVA: 0xA03FD0 Offset: 0xA025D0 VA: 0x180A03FD0
	public void SetScopeMaterial(Material newMat) { }

	// RVA: 0xA03C90 Offset: 0xA02290 VA: 0x180A03C90
	private void Awake() { }

	// RVA: 0xA03F30 Offset: 0xA02530 VA: 0x180A03F30
	public void SetPosition(Vector3 position) { }

	// RVA: 0x2FA9E0 Offset: 0x2F8FE0 VA: 0x1802FA9E0
	public Vector3 GetPosition() { }

	// RVA: 0xA03DA0 Offset: 0xA023A0 VA: 0x180A03DA0
	public void SetAlpha(float alpha) { }

	// RVA: 0xA03D10 Offset: 0xA02310 VA: 0x180A03D10
	public float GetAlpha() { }

	// RVA: 0xA04000 Offset: 0xA02600 VA: 0x180A04000
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

	// RVA: 0xA04070 Offset: 0xA02670 VA: 0x180A04070 Slot: 6
	protected override void Awake() { }

	// RVA: 0xA040D0 Offset: 0xA026D0 VA: 0x180A040D0 Slot: 8
	public void SetVisible(bool b) { }

	// RVA: 0xA04190 Offset: 0xA02790 VA: 0x180A04190
	public void .ctor() { }

}

public class UISoundPlayer : MonoBehaviour // TypeDefIndex: 11267
{	// Methods

	// RVA: 0xA04230 Offset: 0xA02830 VA: 0x180A04230
	public void PlaySound(AudioClip clip) { }

	// RVA: 0xA041F0 Offset: 0xA027F0 VA: 0x180A041F0
	public void PlaySoundDef(SoundDefinition sound) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class UIVoiceIcon : MonoBehaviour // TypeDefIndex: 11268
{	// Fields
	public Text nameText; // 0x18
	public RawImage avatar; // 0x20

	// Methods

	// RVA: 0xA05540 Offset: 0xA03B40 VA: 0x180A05540
	public void Setup(ulong steamid, string name) { }

	// RVA: 0xA05670 Offset: 0xA03C70 VA: 0x180A05670
	public void UpdateVolume(float volume) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class UIWounded : MonoBehaviour // TypeDefIndex: 11269
{	// Fields
	public CanvasGroup group; // 0x18

	// Methods

	// RVA: 0xA05980 Offset: 0xA03F80 VA: 0x180A05980
	private void Update() { }

	// RVA: 0xA057E0 Offset: 0xA03DE0 VA: 0x180A057E0
	private bool ShouldShow() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class UI_LocalVoice : PriorityListComponent<UI_LocalVoice> // TypeDefIndex: 11270
{	// Fields
	public CanvasGroup voiceCanvas; // 0x18
	public CanvasGroup levelImage; // 0x20

	// Methods

	// RVA: 0xA05B50 Offset: 0xA04150 VA: 0x180A05B50 Slot: 6
	protected override void OnEnable() { }

	// RVA: 0xA05BC0 Offset: 0xA041C0 VA: 0x180A05BC0
	public void SetRecording(bool b) { }

	// RVA: 0xA05BA0 Offset: 0xA041A0 VA: 0x180A05BA0
	public void SetLevel(float f) { }

	// RVA: 0xA05BF0 Offset: 0xA041F0 VA: 0x180A05BF0
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

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x11282C0 Offset: 0x11268C0 VA: 0x1811282C0
	public static Vector2 Unpivot(RectTransform rect, Vector2 localPos) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1127F60 Offset: 0x1126560 VA: 0x181127F60
	public static void CenterOnPosition(ScrollRect scrollrect, Vector2 pos) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1128270 Offset: 0x1126870 VA: 0x181128270
	public static void RebuildHackUnity2019(Image image) { }

}

public class UICircle : UIPrimitiveBase // TypeDefIndex: 11716
{	// Fields
	[TooltipAttribute] // RVA: 0xD9740 Offset: 0xD8B40 VA: 0x1800D9740
	public bool ArcInvert; // 0xF0
	[TooltipAttribute] // RVA: 0xD9970 Offset: 0xD8D70 VA: 0x1800D9970
	[RangeAttribute] // RVA: 0xD9970 Offset: 0xD8D70 VA: 0x1800D9970
	public float Arc; // 0xF4
	[TooltipAttribute] // RVA: 0xD9A50 Offset: 0xD8E50 VA: 0x1800D9A50
	[RangeAttribute] // RVA: 0xD9A50 Offset: 0xD8E50 VA: 0x1800D9A50
	public int ArcSteps; // 0xF8
	[TooltipAttribute] // RVA: 0xD9B60 Offset: 0xD8F60 VA: 0x1800D9B60
	[RangeAttribute] // RVA: 0xD9B60 Offset: 0xD8F60 VA: 0x1800D9B60
	public int ArcRotation; // 0xFC
	[TooltipAttribute] // RVA: 0xD9DA0 Offset: 0xD91A0 VA: 0x1800D9DA0
	[RangeAttribute] // RVA: 0xD9DA0 Offset: 0xD91A0 VA: 0x1800D9DA0
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

	// RVA: 0x11E85F0 Offset: 0x11E6BF0 VA: 0x1811E85F0 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x11E9230 Offset: 0x11E7830 VA: 0x1811E9230
	public void SetProgress(float progress) { }

	// RVA: 0x11330E0 Offset: 0x11316E0 VA: 0x1811330E0
	public void SetArcSteps(int steps) { }

	// RVA: 0x11E91D0 Offset: 0x11E77D0 VA: 0x1811E91D0
	public void SetInvertArc(bool invert) { }

	// RVA: 0x11E9190 Offset: 0x11E7790 VA: 0x1811E9190
	public void SetArcRotation(int rotation) { }

	// RVA: 0x11E91B0 Offset: 0x11E77B0 VA: 0x1811E91B0
	public void SetFill(bool fill) { }

	// RVA: 0x1133100 Offset: 0x1131700 VA: 0x181133100
	public void SetBaseColor(Color color) { }

	// RVA: 0x1133140 Offset: 0x1131740 VA: 0x181133140
	public void UpdateBaseAlpha(float value) { }

	// RVA: 0x11E9210 Offset: 0x11E7810 VA: 0x1811E9210
	public void SetProgressColor(Color color) { }

	// RVA: 0x11E9270 Offset: 0x11E7870 VA: 0x1811E9270
	public void UpdateProgressAlpha(float value) { }

	// RVA: 0x11E91F0 Offset: 0x11E77F0 VA: 0x1811E91F0
	public void SetPadding(int padding) { }

	// RVA: 0x11E9250 Offset: 0x11E7850 VA: 0x1811E9250
	public void SetThickness(int thickness) { }

	// RVA: 0x11E9290 Offset: 0x11E7890 VA: 0x1811E9290
	public void .ctor() { }

}

public class UICircleSimple : UIPrimitiveBase // TypeDefIndex: 11717
{	// Fields
	[TooltipAttribute] // RVA: 0xD9A50 Offset: 0xD8E50 VA: 0x1800D9A50
	[RangeAttribute] // RVA: 0xD9A50 Offset: 0xD8E50 VA: 0x1800D9A50
	public int ArcSteps; // 0xF0
	public bool Fill; // 0xF4
	public float Thickness; // 0xF8
	public bool ThicknessIsOutside; // 0xFC
	private List<int> indices; // 0x100
	private List<UIVertex> vertices; // 0x108
	private Vector2 uvCenter; // 0x110

	// Methods

	// RVA: 0x11E7910 Offset: 0x11E5F10 VA: 0x1811E7910 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x11E8480 Offset: 0x11E6A80 VA: 0x1811E8480
	public void SetArcSteps(int steps) { }

	// RVA: 0x11E84A0 Offset: 0x11E6AA0 VA: 0x1811E84A0
	public void SetFill(bool fill) { }

	// RVA: 0x1133100 Offset: 0x1131700 VA: 0x181133100
	public void SetBaseColor(Color color) { }

	// RVA: 0x1133140 Offset: 0x1131740 VA: 0x181133140
	public void UpdateBaseAlpha(float value) { }

	// RVA: 0x11E84C0 Offset: 0x11E6AC0 VA: 0x1811E84C0
	public void SetThickness(int thickness) { }

	// RVA: 0x11E84E0 Offset: 0x11E6AE0 VA: 0x1811E84E0
	public void .ctor() { }

}

public class UICornerCut : UIPrimitiveBase // TypeDefIndex: 11718
{	// Fields
	public Vector2 cornerSize; // 0xF0
	[HeaderAttribute] // RVA: 0xDA140 Offset: 0xD9540 VA: 0x1800DA140
	[SerializeField] // RVA: 0xDA140 Offset: 0xD9540 VA: 0x1800DA140
	private bool m_cutUL; // 0xF8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool m_cutUR; // 0xF9
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool m_cutLL; // 0xFA
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool m_cutLR; // 0xFB
	[TooltipAttribute] // RVA: 0xDA320 Offset: 0xD9720 VA: 0x1800DA320
	[SerializeField] // RVA: 0xDA320 Offset: 0xD9720 VA: 0x1800DA320
	private bool m_makeColumns; // 0xFC
	[HeaderAttribute] // RVA: 0xDA640 Offset: 0xD9A40 VA: 0x1800DA640
	[SerializeField] // RVA: 0xDA640 Offset: 0xD9A40 VA: 0x1800DA640
	private bool m_useColorUp; // 0xFD
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Color32 m_colorUp; // 0x100
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool m_useColorDown; // 0x104
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0x11EA0B0 Offset: 0x11E86B0 VA: 0x1811EA0B0
	public bool get_CutUL() { }

	// RVA: 0x11EA110 Offset: 0x11E8710 VA: 0x1811EA110
	public void set_CutUL(bool value) { }

	// RVA: 0x11EA0C0 Offset: 0x11E86C0 VA: 0x1811EA0C0
	public bool get_CutUR() { }

	// RVA: 0x11EA130 Offset: 0x11E8730 VA: 0x1811EA130
	public void set_CutUR(bool value) { }

	// RVA: 0x11EA090 Offset: 0x11E8690 VA: 0x1811EA090
	public bool get_CutLL() { }

	// RVA: 0x11EA0D0 Offset: 0x11E86D0 VA: 0x1811EA0D0
	public void set_CutLL(bool value) { }

	// RVA: 0x11EA0A0 Offset: 0x11E86A0 VA: 0x1811EA0A0
	public bool get_CutLR() { }

	// RVA: 0x11EA0F0 Offset: 0x11E86F0 VA: 0x1811EA0F0
	public void set_CutLR(bool value) { }

	// RVA: 0x112C0F0 Offset: 0x112A6F0 VA: 0x18112C0F0
	public bool get_MakeColumns() { }

	// RVA: 0x112C1A0 Offset: 0x112A7A0 VA: 0x18112C1A0
	public void set_MakeColumns(bool value) { }

	// RVA: 0x112C0D0 Offset: 0x112A6D0 VA: 0x18112C0D0
	public bool get_UseColorUp() { }

	// RVA: 0x11EA160 Offset: 0x11E8760 VA: 0x1811EA160
	public void set_UseColorUp(bool value) { }

	// RVA: 0xC73A90 Offset: 0xC72090 VA: 0x180C73A90
	public Color32 get_ColorUp() { }

	// RVA: 0xC73BE0 Offset: 0xC721E0 VA: 0x180C73BE0
	public void set_ColorUp(Color32 value) { }

	// RVA: 0x112EEB0 Offset: 0x112D4B0 VA: 0x18112EEB0
	public bool get_UseColorDown() { }

	// RVA: 0x11EA150 Offset: 0x11E8750 VA: 0x1811EA150
	public void set_UseColorDown(bool value) { }

	// RVA: 0x871FF0 Offset: 0x8705F0 VA: 0x180871FF0
	public Color32 get_ColorDown() { }

	// RVA: 0x872190 Offset: 0x870790 VA: 0x180872190
	public void set_ColorDown(Color32 value) { }

	// RVA: 0x11E9830 Offset: 0x11E7E30 VA: 0x1811E9830 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x11E9520 Offset: 0x11E7B20 VA: 0x1811E9520
	private static void AddSquare(Rect rect, Rect rectUV, Color32 color32, VertexHelper vh) { }

	// RVA: 0x11E93F0 Offset: 0x11E79F0 VA: 0x1811E93F0
	private static void AddSquare(Vector2 a, Vector2 b, Vector2 c, Vector2 d, Rect rectUV, Color32 color32, VertexHelper vh) { }

	// RVA: 0x11E96B0 Offset: 0x11E7CB0 VA: 0x1811E96B0
	private static int AddVert(float x, float y, Rect area, Color32 color32, VertexHelper vh) { }

	// RVA: 0x11EA000 Offset: 0x11E8600 VA: 0x1811EA000
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

	// RVA: 0x1128B00 Offset: 0x1127100 VA: 0x181128B00
	private void DrawSpiral(VertexHelper vh) { }

	// RVA: 0x1128380 Offset: 0x1126980 VA: 0x181128380
	private void DrawPhiRectangles(VertexHelper vh, List<Vector2> points, float x, float y, float width, float height, UIGoldenRatioRenderer.Orientations orientation) { }

	// RVA: 0x1128FB0 Offset: 0x11275B0 VA: 0x181128FB0 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x1128640 Offset: 0x1126C40 VA: 0x181128640
	private void DrawRect(VertexHelper vh, Rect rect) { }

	// RVA: 0x1129420 Offset: 0x1127A20 VA: 0x181129420
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
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int m_GridColumns; // 0x118
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int m_GridRows; // 0x11C

	// Properties
	public int GridColumns { get; set; }
	public int GridRows { get; set; }

	// Methods

	// RVA: 0x92D940 Offset: 0x92BF40 VA: 0x18092D940
	public int get_GridColumns() { }

	// RVA: 0x1129AC0 Offset: 0x11280C0 VA: 0x181129AC0
	public void set_GridColumns(int value) { }

	// RVA: 0x1079EC0 Offset: 0x10784C0 VA: 0x181079EC0
	public int get_GridRows() { }

	// RVA: 0x1129AE0 Offset: 0x11280E0 VA: 0x181129AE0
	public void set_GridRows(int value) { }

	// RVA: 0x1129520 Offset: 0x1127B20 VA: 0x181129520 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x1129A40 Offset: 0x1128040 VA: 0x181129A40
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
	[SerializeField] // RVA: 0xDACF0 Offset: 0xDA0F0 VA: 0x1800DACF0
	[TooltipAttribute] // RVA: 0xDACF0 Offset: 0xDA0F0 VA: 0x1800DACF0
	internal Vector2[] m_points; // 0xF0
	[SerializeField] // RVA: 0xDAEA0 Offset: 0xDA2A0 VA: 0x1800DAEA0
	[TooltipAttribute] // RVA: 0xDAEA0 Offset: 0xDA2A0 VA: 0x1800DAEA0
	internal List<Vector2[]> m_segments; // 0xF8
	[SerializeField] // RVA: 0xDAFF0 Offset: 0xDA3F0 VA: 0x1800DAFF0
	[TooltipAttribute] // RVA: 0xDAFF0 Offset: 0xDA3F0 VA: 0x1800DAFF0
	internal float lineThickness; // 0x100
	[SerializeField] // RVA: 0xDB2B0 Offset: 0xDA6B0 VA: 0x1800DB2B0
	[TooltipAttribute] // RVA: 0xDB2B0 Offset: 0xDA6B0 VA: 0x1800DB2B0
	internal bool relativeSize; // 0x104
	[SerializeField] // RVA: 0xDB3E0 Offset: 0xDA7E0 VA: 0x1800DB3E0
	[TooltipAttribute] // RVA: 0xDB3E0 Offset: 0xDA7E0 VA: 0x1800DB3E0
	internal bool lineList; // 0x105
	[SerializeField] // RVA: 0xDB590 Offset: 0xDA990 VA: 0x1800DB590
	[TooltipAttribute] // RVA: 0xDB590 Offset: 0xDA990 VA: 0x1800DB590
	internal bool lineCaps; // 0x106
	[SerializeField] // RVA: 0xDB740 Offset: 0xDAB40 VA: 0x1800DB740
	[TooltipAttribute] // RVA: 0xDB740 Offset: 0xDAB40 VA: 0x1800DB740
	internal int bezierSegmentsPerCurve; // 0x108
	[TooltipAttribute] // RVA: 0xDB8A0 Offset: 0xDACA0 VA: 0x1800DB8A0
	public UILineRenderer.JoinType LineJoins; // 0x10C
	[TooltipAttribute] // RVA: 0xDBB60 Offset: 0xDAF60 VA: 0x1800DBB60
	public UILineRenderer.BezierType BezierMode; // 0x110
	[HideInInspector] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0x7E6DB0 Offset: 0x7E53B0 VA: 0x1807E6DB0
	public float get_LineThickness() { }

	// RVA: 0x112EF00 Offset: 0x112D500 VA: 0x18112EF00
	public void set_LineThickness(float value) { }

	// RVA: 0x112EEB0 Offset: 0x112D4B0 VA: 0x18112EEB0
	public bool get_RelativeSize() { }

	// RVA: 0x112EF20 Offset: 0x112D520 VA: 0x18112EF20
	public void set_RelativeSize(bool value) { }

	// RVA: 0x112EEA0 Offset: 0x112D4A0 VA: 0x18112EEA0
	public bool get_LineList() { }

	// RVA: 0x112EEE0 Offset: 0x112D4E0 VA: 0x18112EEE0
	public void set_LineList(bool value) { }

	// RVA: 0x112EE90 Offset: 0x112D490 VA: 0x18112EE90
	public bool get_LineCaps() { }

	// RVA: 0x112EEC0 Offset: 0x112D4C0 VA: 0x18112EEC0
	public void set_LineCaps(bool value) { }

	// RVA: 0x871FF0 Offset: 0x8705F0 VA: 0x180871FF0
	public int get_BezierSegmentsPerCurve() { }

	// RVA: 0x872190 Offset: 0x870790 VA: 0x180872190
	public void set_BezierSegmentsPerCurve(int value) { }

	// RVA: 0xC73B60 Offset: 0xC72160 VA: 0x180C73B60
	public Vector2[] get_Points() { }

	// RVA: 0x112C160 Offset: 0x112A760 VA: 0x18112C160
	public void set_Points(Vector2[] value) { }

	// RVA: 0xB0EDC0 Offset: 0xB0D3C0 VA: 0x180B0EDC0
	public List<Vector2[]> get_Segments() { }

	// RVA: 0x112EF40 Offset: 0x112D540 VA: 0x18112EF40
	public void set_Segments(List<Vector2[]> value) { }

	// RVA: 0x112DA80 Offset: 0x112C080 VA: 0x18112DA80
	private void PopulateMesh(VertexHelper vh, Vector2[] pointsToDraw) { }

	// RVA: 0x112D940 Offset: 0x112BF40 VA: 0x18112D940 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x112C1C0 Offset: 0x112A7C0 VA: 0x18112C1C0
	private UIVertex[] CreateLineCap(Vector2 start, Vector2 end, UILineRenderer.SegmentType type) { }

	// RVA: 0x112C390 Offset: 0x112A990 VA: 0x18112C390
	private UIVertex[] CreateLineSegment(Vector2 start, Vector2 end, UILineRenderer.SegmentType type, UIVertex[] previousVert) { }

	// RVA: 0x112CA00 Offset: 0x112B000 VA: 0x18112CA00 Slot: 73
	protected override void GeneratedUVs() { }

	// RVA: 0x112ED40 Offset: 0x112D340 VA: 0x18112ED40 Slot: 74
	protected override void ResolutionToNativeSize(float distance) { }

	// RVA: 0x112D800 Offset: 0x112BE00 VA: 0x18112D800
	private int GetSegmentPointCount() { }

	// RVA: 0x112D5A0 Offset: 0x112BBA0 VA: 0x18112D5A0
	public Vector2 GetPosition(int index, int segmentIndex = 0) { }

	// RVA: 0x112D500 Offset: 0x112BB00 VA: 0x18112D500
	public Vector2 GetPositionBySegment(int index, int segment) { }

	// RVA: 0x112D3E0 Offset: 0x112B9E0 VA: 0x18112D3E0
	public Vector2 GetClosestPoint(Vector2 p1, Vector2 p2, Vector2 p3) { }

	// RVA: 0x112EE20 Offset: 0x112D420 VA: 0x18112EE20
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
	[SerializeField] // RVA: 0xDACF0 Offset: 0xDA0F0 VA: 0x1800DACF0
	[TooltipAttribute] // RVA: 0xDACF0 Offset: 0xDA0F0 VA: 0x1800DACF0
	internal List<Vector2> m_points; // 0xF0
	[SerializeField] // RVA: 0xDAFF0 Offset: 0xDA3F0 VA: 0x1800DAFF0
	[TooltipAttribute] // RVA: 0xDAFF0 Offset: 0xDA3F0 VA: 0x1800DAFF0
	internal float lineThickness; // 0xF8
	[SerializeField] // RVA: 0xDB2B0 Offset: 0xDA6B0 VA: 0x1800DB2B0
	[TooltipAttribute] // RVA: 0xDB2B0 Offset: 0xDA6B0 VA: 0x1800DB2B0
	internal bool relativeSize; // 0xFC
	[SerializeField] // RVA: 0xDB3E0 Offset: 0xDA7E0 VA: 0x1800DB3E0
	[TooltipAttribute] // RVA: 0xDB3E0 Offset: 0xDA7E0 VA: 0x1800DB3E0
	internal bool lineList; // 0xFD
	[SerializeField] // RVA: 0xDB590 Offset: 0xDA990 VA: 0x1800DB590
	[TooltipAttribute] // RVA: 0xDB590 Offset: 0xDA990 VA: 0x1800DB590
	internal bool lineCaps; // 0xFE
	[SerializeField] // RVA: 0xDB740 Offset: 0xDAB40 VA: 0x1800DB740
	[TooltipAttribute] // RVA: 0xDB740 Offset: 0xDAB40 VA: 0x1800DB740
	internal int bezierSegmentsPerCurve; // 0x100
	[TooltipAttribute] // RVA: 0xDB8A0 Offset: 0xDACA0 VA: 0x1800DB8A0
	public UILineRendererList.JoinType LineJoins; // 0x104
	[TooltipAttribute] // RVA: 0xDBB60 Offset: 0xDAF60 VA: 0x1800DBB60
	public UILineRendererList.BezierType BezierMode; // 0x108
	[HideInInspector] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public bool drivenExternally; // 0x10C

	// Properties
	public float LineThickness { get; set; }
	public bool RelativeSize { get; set; }
	public bool LineList { get; set; }
	public bool LineCaps { get; set; }
	public int BezierSegmentsPerCurve { get; set; }
	public List<Vector2> Points { get; set; }

	// Methods

	// RVA: 0x112C0E0 Offset: 0x112A6E0 VA: 0x18112C0E0
	public float get_LineThickness() { }

	// RVA: 0x112C140 Offset: 0x112A740 VA: 0x18112C140
	public void set_LineThickness(float value) { }

	// RVA: 0x112C0F0 Offset: 0x112A6F0 VA: 0x18112C0F0
	public bool get_RelativeSize() { }

	// RVA: 0x112C1A0 Offset: 0x112A7A0 VA: 0x18112C1A0
	public void set_RelativeSize(bool value) { }

	// RVA: 0x112C0D0 Offset: 0x112A6D0 VA: 0x18112C0D0
	public bool get_LineList() { }

	// RVA: 0x112C120 Offset: 0x112A720 VA: 0x18112C120
	public void set_LineList(bool value) { }

	// RVA: 0x112C0C0 Offset: 0x112A6C0 VA: 0x18112C0C0
	public bool get_LineCaps() { }

	// RVA: 0x112C100 Offset: 0x112A700 VA: 0x18112C100
	public void set_LineCaps(bool value) { }

	// RVA: 0xC73A90 Offset: 0xC72090 VA: 0x180C73A90
	public int get_BezierSegmentsPerCurve() { }

	// RVA: 0xC73BE0 Offset: 0xC721E0 VA: 0x180C73BE0
	public void set_BezierSegmentsPerCurve(int value) { }

	// RVA: 0xC73B60 Offset: 0xC72160 VA: 0x180C73B60
	public List<Vector2> get_Points() { }

	// RVA: 0x112C160 Offset: 0x112A760 VA: 0x18112C160
	public void set_Points(List<Vector2> value) { }

	// RVA: 0x1129B00 Offset: 0x1128100 VA: 0x181129B00
	public void AddPoint(Vector2 pointToAdd) { }

	// RVA: 0x112BF00 Offset: 0x112A500 VA: 0x18112BF00
	public void RemovePoint(Vector2 pointToRemove) { }

	// RVA: 0x1129B70 Offset: 0x1128170 VA: 0x181129B70
	public void ClearPoints() { }

	// RVA: 0x112AD50 Offset: 0x1129350 VA: 0x18112AD50
	private void PopulateMesh(VertexHelper vh, List<Vector2> pointsToDraw) { }

	// RVA: 0x112ACC0 Offset: 0x11292C0 VA: 0x18112ACC0 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x1129BD0 Offset: 0x11281D0 VA: 0x181129BD0
	private UIVertex[] CreateLineCap(Vector2 start, Vector2 end, UILineRendererList.SegmentType type) { }

	// RVA: 0x1129D90 Offset: 0x1128390 VA: 0x181129D90
	private UIVertex[] CreateLineSegment(Vector2 start, Vector2 end, UILineRendererList.SegmentType type) { }

	// RVA: 0x112A2E0 Offset: 0x11288E0 VA: 0x18112A2E0 Slot: 73
	protected override void GeneratedUVs() { }

	// RVA: 0x112BF70 Offset: 0x112A570 VA: 0x18112BF70 Slot: 74
	protected override void ResolutionToNativeSize(float distance) { }

	// RVA: 0x112C050 Offset: 0x112A650 VA: 0x18112C050
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
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Rect m_UVRect; // 0xF0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Vector2[] m_points; // 0x100
	public float LineThickness; // 0x108
	public bool UseMargins; // 0x10C
	public Vector2 Margin; // 0x110
	public bool relativeSize; // 0x118

	// Properties
	public Rect uvRect { get; set; }
	public Vector2[] Points { get; set; }

	// Methods

	// RVA: 0x1130440 Offset: 0x112EA40 VA: 0x181130440
	public Rect get_uvRect() { }

	// RVA: 0x1130490 Offset: 0x112EA90 VA: 0x181130490
	public void set_uvRect(Rect value) { }

	// RVA: 0xA2A920 Offset: 0xA28F20 VA: 0x180A2A920
	public Vector2[] get_Points() { }

	// RVA: 0x1130450 Offset: 0x112EA50 VA: 0x181130450
	public void set_Points(Vector2[] value) { }

	// RVA: 0x112EF80 Offset: 0x112D580 VA: 0x18112EF80 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x1130240 Offset: 0x112E840 VA: 0x181130240
	public Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Vector3 angles) { }

	// RVA: 0x11303A0 Offset: 0x112E9A0 VA: 0x1811303A0
	public void .ctor() { }

}

public class UIPolygon : UIPrimitiveBase // TypeDefIndex: 11731
{	// Fields
	public bool fill; // 0xF0
	public float thickness; // 0xF4
	[RangeAttribute] // RVA: 0xDF2A0 Offset: 0xDE6A0 VA: 0x1800DF2A0
	public int sides; // 0xF8
	[RangeAttribute] // RVA: 0x9F130 Offset: 0x9E530 VA: 0x18009F130
	public float rotation; // 0xFC
	[RangeAttribute] // RVA: 0x71300 Offset: 0x70700 VA: 0x180071300
	public float[] VerticesDistances; // 0x100
	private float size; // 0x108

	// Methods

	// RVA: 0x1130500 Offset: 0x112EB00 VA: 0x181130500
	public void DrawPolygon(int _sides) { }

	// RVA: 0x1130620 Offset: 0x112EC20 VA: 0x181130620
	public void DrawPolygon(int _sides, float[] _VerticesDistances) { }

	// RVA: 0x11305D0 Offset: 0x112EBD0 VA: 0x1811305D0
	public void DrawPolygon(int _sides, float[] _VerticesDistances, float _rotation) { }

	// RVA: 0x1130D90 Offset: 0x112F390 VA: 0x181130D90
	private void Update() { }

	// RVA: 0x1130670 Offset: 0x112EC70 VA: 0x181130670 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x1130F50 Offset: 0x112F550 VA: 0x181130F50
	public void .ctor() { }

}

public class UIPrimitiveBase : MaskableGraphic, ILayoutElement, ICanvasRaycastFilter // TypeDefIndex: 11734
{	// Fields
	protected static Material s_ETC1DefaultUI; // 0x0
	private List<Vector2> outputList; // 0xC8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Sprite m_Sprite; // 0xD0
	private Sprite m_OverrideSprite; // 0xD8
	internal float m_EventAlphaThreshold; // 0xE0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ResolutionMode m_improveResolution; // 0xE4
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected float m_Resolution; // 0xE8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0xC73A80 Offset: 0xC72080 VA: 0x180C73A80
	public Sprite get_sprite() { }

	// RVA: 0x11329E0 Offset: 0x1130FE0 VA: 0x1811329E0
	public void set_sprite(Sprite value) { }

	// RVA: 0x1132600 Offset: 0x1130C00 VA: 0x181132600
	public Sprite get_overrideSprite() { }

	// RVA: 0x1132960 Offset: 0x1130F60 VA: 0x181132960
	public void set_overrideSprite(Sprite value) { }

	// RVA: 0x1131FB0 Offset: 0x11305B0 VA: 0x181131FB0
	protected Sprite get_activeSprite() { }

	// RVA: 0x1132140 Offset: 0x1130740 VA: 0x181132140
	public float get_eventAlphaThreshold() { }

	// RVA: 0x1132940 Offset: 0x1130F40 VA: 0x181132940
	public void set_eventAlphaThreshold(float value) { }

	// RVA: 0x1079DE0 Offset: 0x10783E0 VA: 0x181079DE0
	public ResolutionMode get_ImproveResolution() { }

	// RVA: 0x11328E0 Offset: 0x1130EE0 VA: 0x1811328E0
	public void set_ImproveResolution(ResolutionMode value) { }

	// RVA: 0x1131F90 Offset: 0x1130590 VA: 0x181131F90
	public float get_Resoloution() { }

	// RVA: 0x1132900 Offset: 0x1130F00 VA: 0x181132900
	public void set_Resoloution(float value) { }

	// RVA: 0x1131FA0 Offset: 0x11305A0 VA: 0x181131FA0
	public bool get_UseNativeSize() { }

	// RVA: 0x1132920 Offset: 0x1130F20 VA: 0x181132920
	public void set_UseNativeSize(bool value) { }

	// RVA: 0x1131F10 Offset: 0x1130510 VA: 0x181131F10
	protected void .ctor() { }

	// RVA: 0x1132040 Offset: 0x1130640 VA: 0x181132040
	public static Material get_defaultETC1GraphicMaterial() { }

	// RVA: 0x1132210 Offset: 0x1130810 VA: 0x181132210 Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0x1132150 Offset: 0x1130750 VA: 0x181132150
	public bool get_hasBorder() { }

	// RVA: 0x1132610 Offset: 0x1130C10 VA: 0x181132610
	public float get_pixelsPerUnit() { }

	// RVA: 0x11323B0 Offset: 0x11309B0 VA: 0x1811323B0 Slot: 32
	public override Material get_material() { }

	// RVA: 0x1132950 Offset: 0x1130F50 VA: 0x181132950 Slot: 33
	public override void set_material(Material value) { }

	// RVA: 0x1131CB0 Offset: 0x11302B0 VA: 0x181131CB0
	protected UIVertex[] SetVbo(Vector2[] vertices, Vector2[] uvs) { }

	// RVA: 0x1131120 Offset: 0x112F720 VA: 0x181131120
	protected Vector2[] IncreaseResolution(Vector2[] input) { }

	// RVA: 0x11311B0 Offset: 0x112F7B0 VA: 0x1811311B0
	protected List<Vector2> IncreaseResolution(List<Vector2> input) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 73
	protected virtual void GeneratedUVs() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 74
	protected virtual void ResolutionToNativeSize(float distance) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 75
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 76
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0 Slot: 77
	public virtual float get_minWidth() { }

	// RVA: 0x1132800 Offset: 0x1130E00 VA: 0x181132800 Slot: 78
	public virtual float get_preferredWidth() { }

	// RVA: 0xC82E90 Offset: 0xC81490 VA: 0x180C82E90 Slot: 79
	public virtual float get_flexibleWidth() { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0 Slot: 80
	public virtual float get_minHeight() { }

	// RVA: 0x1132720 Offset: 0x1130D20 VA: 0x181132720 Slot: 81
	public virtual float get_preferredHeight() { }

	// RVA: 0xC82E90 Offset: 0xC81490 VA: 0x180C82E90 Slot: 82
	public virtual float get_flexibleHeight() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 83
	public virtual int get_layoutPriority() { }

	// RVA: 0x1131780 Offset: 0x112FD80 VA: 0x181131780 Slot: 84
	public virtual bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera) { }

	// RVA: 0x1131BF0 Offset: 0x11301F0 VA: 0x181131BF0
	private Vector2 MapCoordinate(Vector2 local, Rect rect) { }

	// RVA: 0x1130FE0 Offset: 0x112F5E0 VA: 0x181130FE0
	private Vector4 GetAdjustedBorders(Vector4 border, Rect rect) { }

	// RVA: 0x1131C80 Offset: 0x1130280 VA: 0x181131C80 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

public class UIRing : UIPrimitiveBase // TypeDefIndex: 11735
{	// Fields
	public float innerRadius; // 0xF0
	public float outerRadius; // 0xF4
	[TooltipAttribute] // RVA: 0xD9A50 Offset: 0xD8E50 VA: 0x1800D9A50
	[RangeAttribute] // RVA: 0xD9A50 Offset: 0xD8E50 VA: 0x1800D9A50
	public int ArcSteps; // 0xF8
	private List<int> indices; // 0x100
	private List<UIVertex> vertices; // 0x108

	// Methods

	// RVA: 0x1132A60 Offset: 0x1131060 VA: 0x181132A60 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x11330E0 Offset: 0x11316E0 VA: 0x1811330E0
	public void SetArcSteps(int steps) { }

	// RVA: 0x1133100 Offset: 0x1131700 VA: 0x181133100
	public void SetBaseColor(Color color) { }

	// RVA: 0x1133140 Offset: 0x1131740 VA: 0x181133140
	public void UpdateBaseAlpha(float value) { }

	// RVA: 0x11331C0 Offset: 0x11317C0 VA: 0x1811331C0
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
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static bool showinventoryplayer; // 0x0
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
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
