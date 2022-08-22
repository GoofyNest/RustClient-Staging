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

	// RVA: 0x22A4690 Offset: 0x22A2C90 VA: 0x1822A4690
	private static byte Hex2Byte(byte[] b, int offset) { }

	// RVA: 0x22A3DD0 Offset: 0x22A23D0 VA: 0x1822A3DD0
	private static byte[] Byte2Hex(byte b, byte[] hexChars) { }

	// RVA: 0x22A49B0 Offset: 0x22A2FB0 VA: 0x1822A49B0
	public static byte[] URLEncode(byte[] toEncode) { }

	// RVA: 0x22A3F90 Offset: 0x22A2590 VA: 0x1822A3F90
	public static byte[] DataEncode(byte[] toEncode) { }

	// RVA: 0x22A4720 Offset: 0x22A2D20 VA: 0x1822A4720
	public static string QPEncode(string toEncode, Encoding e) { }

	// RVA: 0x22A4310 Offset: 0x22A2910 VA: 0x1822A4310
	public static byte[] Encode(byte[] input, byte escapeChar, byte[] space, byte[] forbidden, bool uppercase) { }

	// RVA: 0x22A3EA0 Offset: 0x22A24A0 VA: 0x1822A3EA0
	private static bool ByteArrayContains(byte[] array, byte b) { }

	// RVA: 0x22A4940 Offset: 0x22A2F40 VA: 0x1822A4940
	public static byte[] URLDecode(byte[] toEncode) { }

	// RVA: 0x22A3EF0 Offset: 0x22A24F0 VA: 0x1822A3EF0
	private static bool ByteSubArrayEquals(byte[] array, int index, byte[] comperand) { }

	// RVA: 0x22A4010 Offset: 0x22A2610 VA: 0x1822A4010
	public static byte[] Decode(byte[] input, byte escapeChar, byte[] space) { }

	// RVA: 0x22A4810 Offset: 0x22A2E10 VA: 0x1822A4810
	public static bool SevenBitClean(string s, Encoding e) { }

	// RVA: 0x22A48E0 Offset: 0x22A2EE0 VA: 0x1822A48E0
	public static bool SevenBitClean(byte[] input) { }

	// RVA: 0x22A4A30 Offset: 0x22A3030 VA: 0x1822A4A30
	private static void .cctor() { }

}

