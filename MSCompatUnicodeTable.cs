internal class MSCompatUnicodeTable // TypeDefIndex: 35
{	// Fields
	public static int MaxExpansionLength; // 0x0
	private static readonly byte* ignorableFlags; // 0x8
	private static readonly byte* categories; // 0x10
	private static readonly byte* level1; // 0x18
	private static readonly byte* level2; // 0x20
	private static readonly byte* level3; // 0x28
	private static byte* cjkCHScategory; // 0x30
	private static byte* cjkCHTcategory; // 0x38
	private static byte* cjkJAcategory; // 0x40
	private static byte* cjkKOcategory; // 0x48
	private static byte* cjkCHSlv1; // 0x50
	private static byte* cjkCHTlv1; // 0x58
	private static byte* cjkJAlv1; // 0x60
	private static byte* cjkKOlv1; // 0x68
	private static byte* cjkKOlv2; // 0x70
	private static readonly char[] tailoringArr; // 0x78
	private static readonly TailoringInfo[] tailoringInfos; // 0x80
	private static object forLock; // 0x88
	public static readonly bool isReady; // 0x90

	// Properties
	public static bool IsReady { get; }

	// Methods

	// RVA: 0x16323A0 Offset: 0x16309A0 VA: 0x1816323A0
	public static TailoringInfo GetTailoringInfo(int lcid) { }

	// RVA: 0x1631590 Offset: 0x162FB90 VA: 0x181631590
	public static void BuildTailoringTables(CultureInfo culture, TailoringInfo t, ref Contraction[] contractions, ref Level2Map[] diacriticals) { }

	// RVA: 0x1632AE0 Offset: 0x16310E0 VA: 0x181632AE0
	private static void SetCJKReferences(string name, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table) { }

	// RVA: 0x1631B60 Offset: 0x1630160 VA: 0x181631B60
	public static byte Category(int cp) { }

	// RVA: 0x16328A0 Offset: 0x1630EA0 VA: 0x1816328A0
	public static byte Level1(int cp) { }

	// RVA: 0x1632960 Offset: 0x1630F60 VA: 0x181632960
	public static byte Level2(int cp) { }

	// RVA: 0x1632A20 Offset: 0x1631020 VA: 0x181632A20
	public static byte Level3(int cp) { }

	// RVA: 0x1632600 Offset: 0x1630C00 VA: 0x181632600
	public static bool IsIgnorable(int cp, byte flag) { }

	// RVA: 0x16325A0 Offset: 0x1630BA0 VA: 0x1816325A0
	public static bool IsIgnorableNonSpacing(int cp) { }

	// RVA: 0x1632DC0 Offset: 0x16313C0 VA: 0x181632DC0
	public static int ToKanaTypeInsensitive(int i) { }

	// RVA: 0x1632DE0 Offset: 0x16313E0 VA: 0x181632DE0
	public static int ToWidthCompat(int i) { }

	// RVA: 0x16324F0 Offset: 0x1630AF0 VA: 0x1816324F0
	public static bool HasSpecialWeight(char c) { }

	// RVA: 0x1632560 Offset: 0x1630B60 VA: 0x181632560
	public static bool IsHalfWidthKana(char c) { }

	// RVA: 0x1632580 Offset: 0x1630B80 VA: 0x181632580
	public static bool IsHiragana(char c) { }

	// RVA: 0x1632730 Offset: 0x1630D30 VA: 0x181632730
	public static bool IsJapaneseSmallLetter(char c) { }

	// RVA: 0x1633520 Offset: 0x1631B20 VA: 0x181633520
	public static bool get_IsReady() { }

	// RVA: 0x1632330 Offset: 0x1630930 VA: 0x181632330
	private static IntPtr GetResource(string name) { }

	// RVA: 0x1632F60 Offset: 0x1631560 VA: 0x181632F60
	private static uint UInt32FromBytePtr(byte* raw, uint idx) { }

	// RVA: 0x1632FA0 Offset: 0x16315A0 VA: 0x181632FA0
	private static void .cctor() { }

	// RVA: 0x16321B0 Offset: 0x16307B0 VA: 0x1816321B0
	public static void FillCJK(string culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table) { }

	// RVA: 0x1631C20 Offset: 0x1630220 VA: 0x181631C20
	private static void FillCJKCore(string culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer cjkLv2Indexer, ref byte* lv2Table) { }

}

private sealed class MSCompatUnicodeTable.<>c // TypeDefIndex: 36
{	// Fields
	public static readonly MSCompatUnicodeTable.<>c <>9; // 0x0
	public static Comparison<Level2Map> <>9__17_0; // 0x8

	// Methods

	// RVA: 0x163EF10 Offset: 0x163D510 VA: 0x18163EF10
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x163EEE0 Offset: 0x163D4E0 VA: 0x18163EEE0
	internal int <BuildTailoringTables>b__17_0(Level2Map a, Level2Map b) { }

}

