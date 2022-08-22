internal struct Variant // TypeDefIndex: 418
{	// Fields
	public short vt; // 0x0
	public ushort wReserved1; // 0x2
	public ushort wReserved2; // 0x4
	public ushort wReserved3; // 0x6
	public long llVal; // 0x8
	public int lVal; // 0x8
	public byte bVal; // 0x8
	public short iVal; // 0x8
	public float fltVal; // 0x8
	public double dblVal; // 0x8
	public short boolVal; // 0x8
	public IntPtr bstrVal; // 0x8
	public sbyte cVal; // 0x8
	public ushort uiVal; // 0x8
	public uint ulVal; // 0x8
	public ulong ullVal; // 0x8
	public int intVal; // 0x8
	public uint uintVal; // 0x8
	public IntPtr pdispVal; // 0x8
	public BRECORD bRecord; // 0x8

	// Methods

	// RVA: 0x2346B0 Offset: 0x233AB0 VA: 0x1802346B0
	public void Clear() { }

}

public abstract class Variant : IConvertible // TypeDefIndex: 11588
{	// Fields
	protected static readonly IFormatProvider FormatProvider; // 0x1E0E1

	// Properties
	public virtual Variant Item { get; set; }
	public virtual Variant Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void Make<T>(out T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D8D00 Offset: 0x5D7300 VA: 0x1805D8D00
	|-Variant.Make<object>
	*/

	// RVA: -1 Offset: -1
	public T Make<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BAEB0 Offset: 0x15B94B0 VA: 0x1815BAEB0
	|-Variant.Make<object>
	*/

	// RVA: 0x873DF0 Offset: 0x8723F0 VA: 0x180873DF0
	public string ToJSON() { }

	// RVA: 0x5B1870 Offset: 0x5AFE70 VA: 0x1805B1870 Slot: 21
	public virtual TypeCode GetTypeCode() { }

	// RVA: 0x874080 Offset: 0x872680 VA: 0x180874080 Slot: 22
	public virtual object ToType(Type conversionType, IFormatProvider provider) { }

	// RVA: 0x873AF0 Offset: 0x8720F0 VA: 0x180873AF0 Slot: 23
	public virtual DateTime ToDateTime(IFormatProvider provider) { }

	// RVA: 0x873970 Offset: 0x871F70 VA: 0x180873970 Slot: 24
	public virtual bool ToBoolean(IFormatProvider provider) { }

	// RVA: 0x8739F0 Offset: 0x871FF0 VA: 0x1808739F0 Slot: 25
	public virtual byte ToByte(IFormatProvider provider) { }

	// RVA: 0x873A70 Offset: 0x872070 VA: 0x180873A70 Slot: 26
	public virtual char ToChar(IFormatProvider provider) { }

	// RVA: 0x873B70 Offset: 0x872170 VA: 0x180873B70 Slot: 27
	public virtual Decimal ToDecimal(IFormatProvider provider) { }

	// RVA: 0x873BF0 Offset: 0x8721F0 VA: 0x180873BF0 Slot: 28
	public virtual double ToDouble(IFormatProvider provider) { }

	// RVA: 0x873C70 Offset: 0x872270 VA: 0x180873C70 Slot: 29
	public virtual short ToInt16(IFormatProvider provider) { }

	// RVA: 0x873CF0 Offset: 0x8722F0 VA: 0x180873CF0 Slot: 30
	public virtual int ToInt32(IFormatProvider provider) { }

	// RVA: 0x873D70 Offset: 0x872370 VA: 0x180873D70 Slot: 31
	public virtual long ToInt64(IFormatProvider provider) { }

	// RVA: 0x873E90 Offset: 0x872490 VA: 0x180873E90 Slot: 32
	public virtual sbyte ToSByte(IFormatProvider provider) { }

	// RVA: 0x873F10 Offset: 0x872510 VA: 0x180873F10 Slot: 33
	public virtual float ToSingle(IFormatProvider provider) { }

	// RVA: 0x874000 Offset: 0x872600 VA: 0x180874000 Slot: 34
	public virtual string ToString(IFormatProvider provider) { }

	// RVA: 0x8741C0 Offset: 0x8727C0 VA: 0x1808741C0 Slot: 35
	public virtual ushort ToUInt16(IFormatProvider provider) { }

	// RVA: 0x874240 Offset: 0x872840 VA: 0x180874240 Slot: 36
	public virtual uint ToUInt32(IFormatProvider provider) { }

	// RVA: 0x8742C0 Offset: 0x8728C0 VA: 0x1808742C0 Slot: 37
	public virtual ulong ToUInt64(IFormatProvider provider) { }

	// RVA: 0x873F90 Offset: 0x872590 VA: 0x180873F90 Slot: 3
	public override string ToString() { }

	// RVA: 0x8743F0 Offset: 0x8729F0 VA: 0x1808743F0 Slot: 38
	public virtual Variant get_Item(string key) { }

	// RVA: 0x874A80 Offset: 0x873080 VA: 0x180874A80 Slot: 39
	public virtual void set_Item(string key, Variant value) { }

	// RVA: 0x8743A0 Offset: 0x8729A0 VA: 0x1808743A0 Slot: 40
	public virtual Variant get_Item(int index) { }

	// RVA: 0x874AD0 Offset: 0x8730D0 VA: 0x180874AD0 Slot: 41
	public virtual void set_Item(int index, Variant value) { }

	// RVA: 0x8746C0 Offset: 0x872CC0 VA: 0x1808746C0
	public static bool op_Implicit(Variant variant) { }

	// RVA: 0x874A00 Offset: 0x873000 VA: 0x180874A00
	public static float op_Implicit(Variant variant) { }

	// RVA: 0x8745C0 Offset: 0x872BC0 VA: 0x1808745C0
	public static double op_Implicit(Variant variant) { }

	// RVA: 0x8744C0 Offset: 0x872AC0 VA: 0x1808744C0
	public static ushort op_Implicit(Variant variant) { }

	// RVA: 0x874900 Offset: 0x872F00 VA: 0x180874900
	public static short op_Implicit(Variant variant) { }

	// RVA: 0x874980 Offset: 0x872F80 VA: 0x180874980
	public static uint op_Implicit(Variant variant) { }

	// RVA: 0x874540 Offset: 0x872B40 VA: 0x180874540
	public static int op_Implicit(Variant variant) { }

	// RVA: 0x8747E0 Offset: 0x872DE0 VA: 0x1808747E0
	public static ulong op_Implicit(Variant variant) { }

	// RVA: 0x874640 Offset: 0x872C40 VA: 0x180874640
	public static long op_Implicit(Variant variant) { }

	// RVA: 0x874740 Offset: 0x872D40 VA: 0x180874740
	public static Decimal op_Implicit(Variant variant) { }

	// RVA: 0x874440 Offset: 0x872A40 VA: 0x180874440
	public static string op_Implicit(Variant variant) { }

	// RVA: 0x874860 Offset: 0x872E60 VA: 0x180874860
	public static Guid op_Implicit(Variant variant) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x874340 Offset: 0x872940 VA: 0x180874340
	private static void .cctor() { }

}

