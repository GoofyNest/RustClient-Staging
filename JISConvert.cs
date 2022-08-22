internal sealed class JISConvert // TypeDefIndex: 7835
{	// Fields
	private const int JISX0208_To_Unicode = 1;
	private const int JISX0212_To_Unicode = 2;
	private const int CJK_To_JIS = 3;
	private const int Greek_To_JIS = 4;
	private const int Extra_To_JIS = 5;
	public byte[] jisx0208ToUnicode; // 0x10
	public byte[] jisx0212ToUnicode; // 0x18
	public byte[] cjkToJis; // 0x20
	public byte[] greekToJis; // 0x28
	public byte[] extraToJis; // 0x30
	private static JISConvert convert; // 0x0
	private static readonly object lockobj; // 0x8

	// Properties
	public static JISConvert Convert { get; }

	// Methods

	// RVA: 0x22529C0 Offset: 0x2250FC0 VA: 0x1822529C0
	private void .ctor() { }

	// RVA: 0x2252960 Offset: 0x2250F60 VA: 0x182252960
	private static void .cctor() { }

	// RVA: 0x2252AF0 Offset: 0x22510F0 VA: 0x182252AF0
	public static JISConvert get_Convert() { }

}

