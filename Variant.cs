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
	protected static readonly IFormatProvider FormatProvider; // 0x2B10180

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
	|-RVA: 0x15BBB20 Offset: 0x15BA120 VA: 0x1815BBB20
	|-Variant.Make<object>
	*/

	// RVA: 0x8909A0 Offset: 0x88EFA0 VA: 0x1808909A0
	public string ToJSON() { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 21
	public virtual TypeCode GetTypeCode() { }

	// RVA: 0x890C30 Offset: 0x88F230 VA: 0x180890C30 Slot: 22
	public virtual object ToType(Type conversionType, IFormatProvider provider) { }

	// RVA: 0x8906A0 Offset: 0x88ECA0 VA: 0x1808906A0 Slot: 23
	public virtual DateTime ToDateTime(IFormatProvider provider) { }

	// RVA: 0x890520 Offset: 0x88EB20 VA: 0x180890520 Slot: 24
	public virtual bool ToBoolean(IFormatProvider provider) { }

	// RVA: 0x8905A0 Offset: 0x88EBA0 VA: 0x1808905A0 Slot: 25
	public virtual byte ToByte(IFormatProvider provider) { }

	// RVA: 0x890620 Offset: 0x88EC20 VA: 0x180890620 Slot: 26
	public virtual char ToChar(IFormatProvider provider) { }

	// RVA: 0x890720 Offset: 0x88ED20 VA: 0x180890720 Slot: 27
	public virtual Decimal ToDecimal(IFormatProvider provider) { }

	// RVA: 0x8907A0 Offset: 0x88EDA0 VA: 0x1808907A0 Slot: 28
	public virtual double ToDouble(IFormatProvider provider) { }

	// RVA: 0x890820 Offset: 0x88EE20 VA: 0x180890820 Slot: 29
	public virtual short ToInt16(IFormatProvider provider) { }

	// RVA: 0x8908A0 Offset: 0x88EEA0 VA: 0x1808908A0 Slot: 30
	public virtual int ToInt32(IFormatProvider provider) { }

	// RVA: 0x890920 Offset: 0x88EF20 VA: 0x180890920 Slot: 31
	public virtual long ToInt64(IFormatProvider provider) { }

	// RVA: 0x890A40 Offset: 0x88F040 VA: 0x180890A40 Slot: 32
	public virtual sbyte ToSByte(IFormatProvider provider) { }

	// RVA: 0x890AC0 Offset: 0x88F0C0 VA: 0x180890AC0 Slot: 33
	public virtual float ToSingle(IFormatProvider provider) { }

	// RVA: 0x890BB0 Offset: 0x88F1B0 VA: 0x180890BB0 Slot: 34
	public virtual string ToString(IFormatProvider provider) { }

	// RVA: 0x890D70 Offset: 0x88F370 VA: 0x180890D70 Slot: 35
	public virtual ushort ToUInt16(IFormatProvider provider) { }

	// RVA: 0x890DF0 Offset: 0x88F3F0 VA: 0x180890DF0 Slot: 36
	public virtual uint ToUInt32(IFormatProvider provider) { }

	// RVA: 0x890E70 Offset: 0x88F470 VA: 0x180890E70 Slot: 37
	public virtual ulong ToUInt64(IFormatProvider provider) { }

	// RVA: 0x890B40 Offset: 0x88F140 VA: 0x180890B40 Slot: 3
	public override string ToString() { }

	// RVA: 0x890FA0 Offset: 0x88F5A0 VA: 0x180890FA0 Slot: 38
	public virtual Variant get_Item(string key) { }

	// RVA: 0x891630 Offset: 0x88FC30 VA: 0x180891630 Slot: 39
	public virtual void set_Item(string key, Variant value) { }

	// RVA: 0x890F50 Offset: 0x88F550 VA: 0x180890F50 Slot: 40
	public virtual Variant get_Item(int index) { }

	// RVA: 0x891680 Offset: 0x88FC80 VA: 0x180891680 Slot: 41
	public virtual void set_Item(int index, Variant value) { }

	// RVA: 0x891270 Offset: 0x88F870 VA: 0x180891270
	public static bool op_Implicit(Variant variant) { }

	// RVA: 0x8915B0 Offset: 0x88FBB0 VA: 0x1808915B0
	public static float op_Implicit(Variant variant) { }

	// RVA: 0x891170 Offset: 0x88F770 VA: 0x180891170
	public static double op_Implicit(Variant variant) { }

	// RVA: 0x891070 Offset: 0x88F670 VA: 0x180891070
	public static ushort op_Implicit(Variant variant) { }

	// RVA: 0x8914B0 Offset: 0x88FAB0 VA: 0x1808914B0
	public static short op_Implicit(Variant variant) { }

	// RVA: 0x891530 Offset: 0x88FB30 VA: 0x180891530
	public static uint op_Implicit(Variant variant) { }

	// RVA: 0x8910F0 Offset: 0x88F6F0 VA: 0x1808910F0
	public static int op_Implicit(Variant variant) { }

	// RVA: 0x891390 Offset: 0x88F990 VA: 0x180891390
	public static ulong op_Implicit(Variant variant) { }

	// RVA: 0x8911F0 Offset: 0x88F7F0 VA: 0x1808911F0
	public static long op_Implicit(Variant variant) { }

	// RVA: 0x8912F0 Offset: 0x88F8F0 VA: 0x1808912F0
	public static Decimal op_Implicit(Variant variant) { }

	// RVA: 0x890FF0 Offset: 0x88F5F0 VA: 0x180890FF0
	public static string op_Implicit(Variant variant) { }

	// RVA: 0x891410 Offset: 0x88FA10 VA: 0x180891410
	public static Guid op_Implicit(Variant variant) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x890EF0 Offset: 0x88F4F0 VA: 0x180890EF0
	private static void .cctor() { }

}

