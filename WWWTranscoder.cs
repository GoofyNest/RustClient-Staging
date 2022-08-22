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

	// RVA: 0x22A3BB0 Offset: 0x22A21B0 VA: 0x1822A3BB0
	private static byte Hex2Byte(byte[] b, int offset) { }

	// RVA: 0x22A32F0 Offset: 0x22A18F0 VA: 0x1822A32F0
	private static byte[] Byte2Hex(byte b, byte[] hexChars) { }

	// RVA: 0x22A3ED0 Offset: 0x22A24D0 VA: 0x1822A3ED0
	public static byte[] URLEncode(byte[] toEncode) { }

	// RVA: 0x22A34B0 Offset: 0x22A1AB0 VA: 0x1822A34B0
	public static byte[] DataEncode(byte[] toEncode) { }

	// RVA: 0x22A3C40 Offset: 0x22A2240 VA: 0x1822A3C40
	public static string QPEncode(string toEncode, Encoding e) { }

	// RVA: 0x22A3830 Offset: 0x22A1E30 VA: 0x1822A3830
	public static byte[] Encode(byte[] input, byte escapeChar, byte[] space, byte[] forbidden, bool uppercase) { }

	// RVA: 0x22A33C0 Offset: 0x22A19C0 VA: 0x1822A33C0
	private static bool ByteArrayContains(byte[] array, byte b) { }

	// RVA: 0x22A3E60 Offset: 0x22A2460 VA: 0x1822A3E60
	public static byte[] URLDecode(byte[] toEncode) { }

	// RVA: 0x22A3410 Offset: 0x22A1A10 VA: 0x1822A3410
	private static bool ByteSubArrayEquals(byte[] array, int index, byte[] comperand) { }

	// RVA: 0x22A3530 Offset: 0x22A1B30 VA: 0x1822A3530
	public static byte[] Decode(byte[] input, byte escapeChar, byte[] space) { }

	// RVA: 0x22A3D30 Offset: 0x22A2330 VA: 0x1822A3D30
	public static bool SevenBitClean(string s, Encoding e) { }

	// RVA: 0x22A3E00 Offset: 0x22A2400 VA: 0x1822A3E00
	public static bool SevenBitClean(byte[] input) { }

	// RVA: 0x22A3F50 Offset: 0x22A2550 VA: 0x1822A3F50
	private static void .cctor() { }

}

