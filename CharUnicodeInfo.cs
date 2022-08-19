public static class CharUnicodeInfo // TypeDefIndex: 685
{	// Fields
	private static ushort[] s_pCategoryLevel1Index; // 0x0
	private static byte[] s_pCategoriesValue; // 0x8
	private static ushort[] s_pNumericLevel1Index; // 0x10
	private static byte[] s_pNumericValues; // 0x18
	private static ushort[] s_pDigitValues; // 0x20

	// Methods

	// RVA: 0x10D3020 Offset: 0x10D1620 VA: 0x1810D3020
	internal static int InternalConvertToUtf32(string s, int index) { }

	// RVA: 0x10D2F50 Offset: 0x10D1550 VA: 0x1810D2F50
	internal static int InternalConvertToUtf32(string s, int index, out int charLength) { }

	// RVA: 0x10D3570 Offset: 0x10D1B70 VA: 0x1810D3570
	internal static bool IsWhiteSpace(string s, int index) { }

	// RVA: 0x10D3760 Offset: 0x10D1D60 VA: 0x1810D3760
	internal static bool IsWhiteSpace(char c) { }

	// RVA: 0x10D2F00 Offset: 0x10D1500 VA: 0x1810D2F00
	public static UnicodeCategory GetUnicodeCategory(char ch) { }

	// RVA: 0x10D2D60 Offset: 0x10D1360 VA: 0x1810D2D60
	public static UnicodeCategory GetUnicodeCategory(string s, int index) { }

	// RVA: 0x10D31F0 Offset: 0x10D17F0 VA: 0x1810D31F0
	internal static UnicodeCategory InternalGetUnicodeCategory(int ch) { }

	// RVA: 0x10D30E0 Offset: 0x10D16E0 VA: 0x1810D30E0
	internal static byte InternalGetCategoryValue(int ch, int offset) { }

	// RVA: 0x10D3330 Offset: 0x10D1930 VA: 0x1810D3330
	internal static UnicodeCategory InternalGetUnicodeCategory(string value, int index) { }

	// RVA: 0x10D3420 Offset: 0x10D1A20 VA: 0x1810D3420
	internal static UnicodeCategory InternalGetUnicodeCategory(string str, int index, out int charLength) { }

	// RVA: 0x10D3530 Offset: 0x10D1B30 VA: 0x1810D3530
	internal static bool IsCombiningCategory(UnicodeCategory uc) { }

	// RVA: 0x10D3800 Offset: 0x10D1E00 VA: 0x1810D3800
	private static void .cctor() { }

}

internal static class CharUnicodeInfo.Debug // TypeDefIndex: 686
{	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal static void Assert(bool condition, string message) { }

}

