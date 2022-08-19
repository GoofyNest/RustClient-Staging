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

	// RVA: 0x22A3D70 Offset: 0x22A2370 VA: 0x1822A3D70
	private static byte Hex2Byte(byte[] b, int offset) { }

	// RVA: 0x22A34B0 Offset: 0x22A1AB0 VA: 0x1822A34B0
	private static byte[] Byte2Hex(byte b, byte[] hexChars) { }

	// RVA: 0x22A4090 Offset: 0x22A2690 VA: 0x1822A4090
	public static byte[] URLEncode(byte[] toEncode) { }

	// RVA: 0x22A3670 Offset: 0x22A1C70 VA: 0x1822A3670
	public static byte[] DataEncode(byte[] toEncode) { }

	// RVA: 0x22A3E00 Offset: 0x22A2400 VA: 0x1822A3E00
	public static string QPEncode(string toEncode, Encoding e) { }

	// RVA: 0x22A39F0 Offset: 0x22A1FF0 VA: 0x1822A39F0
	public static byte[] Encode(byte[] input, byte escapeChar, byte[] space, byte[] forbidden, bool uppercase) { }

	// RVA: 0x22A3580 Offset: 0x22A1B80 VA: 0x1822A3580
	private static bool ByteArrayContains(byte[] array, byte b) { }

	// RVA: 0x22A4020 Offset: 0x22A2620 VA: 0x1822A4020
	public static byte[] URLDecode(byte[] toEncode) { }

	// RVA: 0x22A35D0 Offset: 0x22A1BD0 VA: 0x1822A35D0
	private static bool ByteSubArrayEquals(byte[] array, int index, byte[] comperand) { }

	// RVA: 0x22A36F0 Offset: 0x22A1CF0 VA: 0x1822A36F0
	public static byte[] Decode(byte[] input, byte escapeChar, byte[] space) { }

	// RVA: 0x22A3EF0 Offset: 0x22A24F0 VA: 0x1822A3EF0
	public static bool SevenBitClean(string s, Encoding e) { }

	// RVA: 0x22A3FC0 Offset: 0x22A25C0 VA: 0x1822A3FC0
	public static bool SevenBitClean(byte[] input) { }

	// RVA: 0x22A4110 Offset: 0x22A2710 VA: 0x1822A4110
	private static void .cctor() { }

}

