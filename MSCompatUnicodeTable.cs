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

	// RVA: 0x1644DC0 Offset: 0x16433C0 VA: 0x181644DC0
	public static TailoringInfo GetTailoringInfo(int lcid) { }

	// RVA: 0x1643FB0 Offset: 0x16425B0 VA: 0x181643FB0
	public static void BuildTailoringTables(CultureInfo culture, TailoringInfo t, ref Contraction[] contractions, ref Level2Map[] diacriticals) { }

	// RVA: 0x1645500 Offset: 0x1643B00 VA: 0x181645500
	private static void SetCJKReferences(string name, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table) { }

	// RVA: 0x1644580 Offset: 0x1642B80 VA: 0x181644580
	public static byte Category(int cp) { }

	// RVA: 0x16452C0 Offset: 0x16438C0 VA: 0x1816452C0
	public static byte Level1(int cp) { }

	// RVA: 0x1645380 Offset: 0x1643980 VA: 0x181645380
	public static byte Level2(int cp) { }

	// RVA: 0x1645440 Offset: 0x1643A40 VA: 0x181645440
	public static byte Level3(int cp) { }

	// RVA: 0x1645020 Offset: 0x1643620 VA: 0x181645020
	public static bool IsIgnorable(int cp, byte flag) { }

	// RVA: 0x1644FC0 Offset: 0x16435C0 VA: 0x181644FC0
	public static bool IsIgnorableNonSpacing(int cp) { }

	// RVA: 0x16457E0 Offset: 0x1643DE0 VA: 0x1816457E0
	public static int ToKanaTypeInsensitive(int i) { }

	// RVA: 0x1645800 Offset: 0x1643E00 VA: 0x181645800
	public static int ToWidthCompat(int i) { }

	// RVA: 0x1644F10 Offset: 0x1643510 VA: 0x181644F10
	public static bool HasSpecialWeight(char c) { }

	// RVA: 0x1644F80 Offset: 0x1643580 VA: 0x181644F80
	public static bool IsHalfWidthKana(char c) { }

	// RVA: 0x1644FA0 Offset: 0x16435A0 VA: 0x181644FA0
	public static bool IsHiragana(char c) { }

	// RVA: 0x1645150 Offset: 0x1643750 VA: 0x181645150
	public static bool IsJapaneseSmallLetter(char c) { }

	// RVA: 0x1645F40 Offset: 0x1644540 VA: 0x181645F40
	public static bool get_IsReady() { }

	// RVA: 0x1644D50 Offset: 0x1643350 VA: 0x181644D50
	private static IntPtr GetResource(string name) { }

	// RVA: 0x1645980 Offset: 0x1643F80 VA: 0x181645980
	private static uint UInt32FromBytePtr(byte* raw, uint idx) { }

	// RVA: 0x16459C0 Offset: 0x1643FC0 VA: 0x1816459C0
	private static void .cctor() { }

	// RVA: 0x1644BD0 Offset: 0x16431D0 VA: 0x181644BD0
	public static void FillCJK(string culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table) { }

	// RVA: 0x1644640 Offset: 0x1642C40 VA: 0x181644640
	private static void FillCJKCore(string culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer cjkLv2Indexer, ref byte* lv2Table) { }

}

private sealed class MSCompatUnicodeTable.<>c // TypeDefIndex: 36
{	// Fields
	public static readonly MSCompatUnicodeTable.<>c <>9; // 0x0
	public static Comparison<Level2Map> <>9__17_0; // 0x8

	// Methods

	// RVA: 0x1651930 Offset: 0x164FF30 VA: 0x181651930
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1651900 Offset: 0x164FF00 VA: 0x181651900
	internal int <BuildTailoringTables>b__17_0(Level2Map a, Level2Map b) { }

}

