internal class WWWTranscoder // TypeDefIndex: 4126
{	// Fields
	private static byte[] ucHexChars; // 0x0
	private static byte[] lcHexChars; // 0x8
	private static byte urlEscapeChar; // 0x10
	private static byte[] urlSpace; // 0x18
	private static byte[] dataSpace; // 0x20
	private static byte[] urlForbidden; // 0x28
	private static byte qpEscapeChar; // 0x30
	private static byte[] qpSpace; // 0x38
	private static byte[] qpForbidden; // 0x40

	// Methods

	// RVA: 0x22A3E70 Offset: 0x22A2470 VA: 0x1822A3E70
	private static byte Hex2Byte(byte[] b, int offset) { }

	// RVA: 0x22A35B0 Offset: 0x22A1BB0 VA: 0x1822A35B0
	private static byte[] Byte2Hex(byte b, byte[] hexChars) { }

	// RVA: 0x22A4190 Offset: 0x22A2790 VA: 0x1822A4190
	public static byte[] URLEncode(byte[] toEncode) { }

	// RVA: 0x22A3770 Offset: 0x22A1D70 VA: 0x1822A3770
	public static byte[] DataEncode(byte[] toEncode) { }

	// RVA: 0x22A3F00 Offset: 0x22A2500 VA: 0x1822A3F00
	public static string QPEncode(string toEncode, Encoding e) { }

	// RVA: 0x22A3AF0 Offset: 0x22A20F0 VA: 0x1822A3AF0
	public static byte[] Encode(byte[] input, byte escapeChar, byte[] space, byte[] forbidden, bool uppercase) { }

	// RVA: 0x22A3680 Offset: 0x22A1C80 VA: 0x1822A3680
	private static bool ByteArrayContains(byte[] array, byte b) { }

	// RVA: 0x22A4120 Offset: 0x22A2720 VA: 0x1822A4120
	public static byte[] URLDecode(byte[] toEncode) { }

	// RVA: 0x22A36D0 Offset: 0x22A1CD0 VA: 0x1822A36D0
	private static bool ByteSubArrayEquals(byte[] array, int index, byte[] comperand) { }

	// RVA: 0x22A37F0 Offset: 0x22A1DF0 VA: 0x1822A37F0
	public static byte[] Decode(byte[] input, byte escapeChar, byte[] space) { }

	// RVA: 0x22A3FF0 Offset: 0x22A25F0 VA: 0x1822A3FF0
	public static bool SevenBitClean(string s, Encoding e) { }

	// RVA: 0x22A40C0 Offset: 0x22A26C0 VA: 0x1822A40C0
	public static bool SevenBitClean(byte[] input) { }

	// RVA: 0x22A4210 Offset: 0x22A2810 VA: 0x1822A4210
	private static void .cctor() { }

}

