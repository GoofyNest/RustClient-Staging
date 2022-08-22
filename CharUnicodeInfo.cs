public static class CharUnicodeInfo // TypeDefIndex: 685
{	// Fields
	private static ushort[] s_pCategoryLevel1Index; // 0x0
	private static byte[] s_pCategoriesValue; // 0x8
	private static ushort[] s_pNumericLevel1Index; // 0x10
	private static byte[] s_pNumericValues; // 0x18
	private static ushort[] s_pDigitValues; // 0x20

	// Methods

	// RVA: 0x10D3D50 Offset: 0x10D2350 VA: 0x1810D3D50
	internal static int InternalConvertToUtf32(string s, int index) { }

	// RVA: 0x10D3C80 Offset: 0x10D2280 VA: 0x1810D3C80
	internal static int InternalConvertToUtf32(string s, int index, out int charLength) { }

	// RVA: 0x10D42A0 Offset: 0x10D28A0 VA: 0x1810D42A0
	internal static bool IsWhiteSpace(string s, int index) { }

	// RVA: 0x10D4490 Offset: 0x10D2A90 VA: 0x1810D4490
	internal static bool IsWhiteSpace(char c) { }

	// RVA: 0x10D3C30 Offset: 0x10D2230 VA: 0x1810D3C30
	public static UnicodeCategory GetUnicodeCategory(char ch) { }

	// RVA: 0x10D3A90 Offset: 0x10D2090 VA: 0x1810D3A90
	public static UnicodeCategory GetUnicodeCategory(string s, int index) { }

	// RVA: 0x10D3F20 Offset: 0x10D2520 VA: 0x1810D3F20
	internal static UnicodeCategory InternalGetUnicodeCategory(int ch) { }

	// RVA: 0x10D3E10 Offset: 0x10D2410 VA: 0x1810D3E10
	internal static byte InternalGetCategoryValue(int ch, int offset) { }

	// RVA: 0x10D4060 Offset: 0x10D2660 VA: 0x1810D4060
	internal static UnicodeCategory InternalGetUnicodeCategory(string value, int index) { }

	// RVA: 0x10D4150 Offset: 0x10D2750 VA: 0x1810D4150
	internal static UnicodeCategory InternalGetUnicodeCategory(string str, int index, out int charLength) { }

	// RVA: 0x10D4260 Offset: 0x10D2860 VA: 0x1810D4260
	internal static bool IsCombiningCategory(UnicodeCategory uc) { }

	// RVA: 0x10D4530 Offset: 0x10D2B30 VA: 0x1810D4530
	private static void .cctor() { }

}

internal static class CharUnicodeInfo.Debug // TypeDefIndex: 686
{	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal static void Assert(bool condition, string message) { }

}

