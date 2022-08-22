public static class CharUnicodeInfo // TypeDefIndex: 685
{	// Fields
	private static ushort[] s_pCategoryLevel1Index; // 0x0
	private static byte[] s_pCategoriesValue; // 0x8
	private static ushort[] s_pNumericLevel1Index; // 0x10
	private static byte[] s_pNumericValues; // 0x18
	private static ushort[] s_pDigitValues; // 0x20

	// Methods

	// RVA: 0x10D32E0 Offset: 0x10D18E0 VA: 0x1810D32E0
	internal static int InternalConvertToUtf32(string s, int index) { }

	// RVA: 0x10D3210 Offset: 0x10D1810 VA: 0x1810D3210
	internal static int InternalConvertToUtf32(string s, int index, out int charLength) { }

	// RVA: 0x10D3830 Offset: 0x10D1E30 VA: 0x1810D3830
	internal static bool IsWhiteSpace(string s, int index) { }

	// RVA: 0x10D3A20 Offset: 0x10D2020 VA: 0x1810D3A20
	internal static bool IsWhiteSpace(char c) { }

	// RVA: 0x10D31C0 Offset: 0x10D17C0 VA: 0x1810D31C0
	public static UnicodeCategory GetUnicodeCategory(char ch) { }

	// RVA: 0x10D3020 Offset: 0x10D1620 VA: 0x1810D3020
	public static UnicodeCategory GetUnicodeCategory(string s, int index) { }

	// RVA: 0x10D34B0 Offset: 0x10D1AB0 VA: 0x1810D34B0
	internal static UnicodeCategory InternalGetUnicodeCategory(int ch) { }

	// RVA: 0x10D33A0 Offset: 0x10D19A0 VA: 0x1810D33A0
	internal static byte InternalGetCategoryValue(int ch, int offset) { }

	// RVA: 0x10D35F0 Offset: 0x10D1BF0 VA: 0x1810D35F0
	internal static UnicodeCategory InternalGetUnicodeCategory(string value, int index) { }

	// RVA: 0x10D36E0 Offset: 0x10D1CE0 VA: 0x1810D36E0
	internal static UnicodeCategory InternalGetUnicodeCategory(string str, int index, out int charLength) { }

	// RVA: 0x10D37F0 Offset: 0x10D1DF0 VA: 0x1810D37F0
	internal static bool IsCombiningCategory(UnicodeCategory uc) { }

	// RVA: 0x10D3AC0 Offset: 0x10D20C0 VA: 0x1810D3AC0
	private static void .cctor() { }

}

internal static class CharUnicodeInfo.Debug // TypeDefIndex: 686
{	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal static void Assert(bool condition, string message) { }

}

