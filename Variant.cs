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
	protected static readonly IFormatProvider FormatProvider; // 0x2B111C0

	// Properties
	public virtual Variant Item { get; set; }
	public virtual Variant Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void Make<T>(out T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D8D70 Offset: 0x5D7370 VA: 0x1805D8D70
	|-Variant.Make<object>
	*/

	// RVA: -1 Offset: -1
	public T Make<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BBDE0 Offset: 0x15BA3E0 VA: 0x1815BBDE0
	|-Variant.Make<object>
	*/

	// RVA: 0x890AB0 Offset: 0x88F0B0 VA: 0x180890AB0
	public string ToJSON() { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 21
	public virtual TypeCode GetTypeCode() { }

	// RVA: 0x890D40 Offset: 0x88F340 VA: 0x180890D40 Slot: 22
	public virtual object ToType(Type conversionType, IFormatProvider provider) { }

	// RVA: 0x8907B0 Offset: 0x88EDB0 VA: 0x1808907B0 Slot: 23
	public virtual DateTime ToDateTime(IFormatProvider provider) { }

	// RVA: 0x890630 Offset: 0x88EC30 VA: 0x180890630 Slot: 24
	public virtual bool ToBoolean(IFormatProvider provider) { }

	// RVA: 0x8906B0 Offset: 0x88ECB0 VA: 0x1808906B0 Slot: 25
	public virtual byte ToByte(IFormatProvider provider) { }

	// RVA: 0x890730 Offset: 0x88ED30 VA: 0x180890730 Slot: 26
	public virtual char ToChar(IFormatProvider provider) { }

	// RVA: 0x890830 Offset: 0x88EE30 VA: 0x180890830 Slot: 27
	public virtual Decimal ToDecimal(IFormatProvider provider) { }

	// RVA: 0x8908B0 Offset: 0x88EEB0 VA: 0x1808908B0 Slot: 28
	public virtual double ToDouble(IFormatProvider provider) { }

	// RVA: 0x890930 Offset: 0x88EF30 VA: 0x180890930 Slot: 29
	public virtual short ToInt16(IFormatProvider provider) { }

	// RVA: 0x8909B0 Offset: 0x88EFB0 VA: 0x1808909B0 Slot: 30
	public virtual int ToInt32(IFormatProvider provider) { }

	// RVA: 0x890A30 Offset: 0x88F030 VA: 0x180890A30 Slot: 31
	public virtual long ToInt64(IFormatProvider provider) { }

	// RVA: 0x890B50 Offset: 0x88F150 VA: 0x180890B50 Slot: 32
	public virtual sbyte ToSByte(IFormatProvider provider) { }

	// RVA: 0x890BD0 Offset: 0x88F1D0 VA: 0x180890BD0 Slot: 33
	public virtual float ToSingle(IFormatProvider provider) { }

	// RVA: 0x890CC0 Offset: 0x88F2C0 VA: 0x180890CC0 Slot: 34
	public virtual string ToString(IFormatProvider provider) { }

	// RVA: 0x890E80 Offset: 0x88F480 VA: 0x180890E80 Slot: 35
	public virtual ushort ToUInt16(IFormatProvider provider) { }

	// RVA: 0x890F00 Offset: 0x88F500 VA: 0x180890F00 Slot: 36
	public virtual uint ToUInt32(IFormatProvider provider) { }

	// RVA: 0x890F80 Offset: 0x88F580 VA: 0x180890F80 Slot: 37
	public virtual ulong ToUInt64(IFormatProvider provider) { }

	// RVA: 0x890C50 Offset: 0x88F250 VA: 0x180890C50 Slot: 3
	public override string ToString() { }

	// RVA: 0x8910B0 Offset: 0x88F6B0 VA: 0x1808910B0 Slot: 38
	public virtual Variant get_Item(string key) { }

	// RVA: 0x891740 Offset: 0x88FD40 VA: 0x180891740 Slot: 39
	public virtual void set_Item(string key, Variant value) { }

	// RVA: 0x891060 Offset: 0x88F660 VA: 0x180891060 Slot: 40
	public virtual Variant get_Item(int index) { }

	// RVA: 0x891790 Offset: 0x88FD90 VA: 0x180891790 Slot: 41
	public virtual void set_Item(int index, Variant value) { }

	// RVA: 0x891380 Offset: 0x88F980 VA: 0x180891380
	public static bool op_Implicit(Variant variant) { }

	// RVA: 0x8916C0 Offset: 0x88FCC0 VA: 0x1808916C0
	public static float op_Implicit(Variant variant) { }

	// RVA: 0x891280 Offset: 0x88F880 VA: 0x180891280
	public static double op_Implicit(Variant variant) { }

	// RVA: 0x891180 Offset: 0x88F780 VA: 0x180891180
	public static ushort op_Implicit(Variant variant) { }

	// RVA: 0x8915C0 Offset: 0x88FBC0 VA: 0x1808915C0
	public static short op_Implicit(Variant variant) { }

	// RVA: 0x891640 Offset: 0x88FC40 VA: 0x180891640
	public static uint op_Implicit(Variant variant) { }

	// RVA: 0x891200 Offset: 0x88F800 VA: 0x180891200
	public static int op_Implicit(Variant variant) { }

	// RVA: 0x8914A0 Offset: 0x88FAA0 VA: 0x1808914A0
	public static ulong op_Implicit(Variant variant) { }

	// RVA: 0x891300 Offset: 0x88F900 VA: 0x180891300
	public static long op_Implicit(Variant variant) { }

	// RVA: 0x891400 Offset: 0x88FA00 VA: 0x180891400
	public static Decimal op_Implicit(Variant variant) { }

	// RVA: 0x891100 Offset: 0x88F700 VA: 0x180891100
	public static string op_Implicit(Variant variant) { }

	// RVA: 0x891520 Offset: 0x88FB20 VA: 0x180891520
	public static Guid op_Implicit(Variant variant) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x891000 Offset: 0x88F600 VA: 0x180891000
	private static void .cctor() { }

}

