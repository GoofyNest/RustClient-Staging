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

	// RVA: 0x1645080 Offset: 0x1643680 VA: 0x181645080
	public static TailoringInfo GetTailoringInfo(int lcid) { }

	// RVA: 0x1644270 Offset: 0x1642870 VA: 0x181644270
	public static void BuildTailoringTables(CultureInfo culture, TailoringInfo t, ref Contraction[] contractions, ref Level2Map[] diacriticals) { }

	// RVA: 0x16457C0 Offset: 0x1643DC0 VA: 0x1816457C0
	private static void SetCJKReferences(string name, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table) { }

	// RVA: 0x1644840 Offset: 0x1642E40 VA: 0x181644840
	public static byte Category(int cp) { }

	// RVA: 0x1645580 Offset: 0x1643B80 VA: 0x181645580
	public static byte Level1(int cp) { }

	// RVA: 0x1645640 Offset: 0x1643C40 VA: 0x181645640
	public static byte Level2(int cp) { }

	// RVA: 0x1645700 Offset: 0x1643D00 VA: 0x181645700
	public static byte Level3(int cp) { }

	// RVA: 0x16452E0 Offset: 0x16438E0 VA: 0x1816452E0
	public static bool IsIgnorable(int cp, byte flag) { }

	// RVA: 0x1645280 Offset: 0x1643880 VA: 0x181645280
	public static bool IsIgnorableNonSpacing(int cp) { }

	// RVA: 0x1645AA0 Offset: 0x16440A0 VA: 0x181645AA0
	public static int ToKanaTypeInsensitive(int i) { }

	// RVA: 0x1645AC0 Offset: 0x16440C0 VA: 0x181645AC0
	public static int ToWidthCompat(int i) { }

	// RVA: 0x16451D0 Offset: 0x16437D0 VA: 0x1816451D0
	public static bool HasSpecialWeight(char c) { }

	// RVA: 0x1645240 Offset: 0x1643840 VA: 0x181645240
	public static bool IsHalfWidthKana(char c) { }

	// RVA: 0x1645260 Offset: 0x1643860 VA: 0x181645260
	public static bool IsHiragana(char c) { }

	// RVA: 0x1645410 Offset: 0x1643A10 VA: 0x181645410
	public static bool IsJapaneseSmallLetter(char c) { }

	// RVA: 0x1646200 Offset: 0x1644800 VA: 0x181646200
	public static bool get_IsReady() { }

	// RVA: 0x1645010 Offset: 0x1643610 VA: 0x181645010
	private static IntPtr GetResource(string name) { }

	// RVA: 0x1645C40 Offset: 0x1644240 VA: 0x181645C40
	private static uint UInt32FromBytePtr(byte* raw, uint idx) { }

	// RVA: 0x1645C80 Offset: 0x1644280 VA: 0x181645C80
	private static void .cctor() { }

	// RVA: 0x1644E90 Offset: 0x1643490 VA: 0x181644E90
	public static void FillCJK(string culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table) { }

	// RVA: 0x1644900 Offset: 0x1642F00 VA: 0x181644900
	private static void FillCJKCore(string culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer cjkLv2Indexer, ref byte* lv2Table) { }

}

private sealed class MSCompatUnicodeTable.<>c // TypeDefIndex: 36
{	// Fields
	public static readonly MSCompatUnicodeTable.<>c <>9; // 0x0
	public static Comparison<Level2Map> <>9__17_0; // 0x8

	// Methods

	// RVA: 0x1651BF0 Offset: 0x16501F0 VA: 0x181651BF0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1651BC0 Offset: 0x16501C0 VA: 0x181651BC0
	internal int <BuildTailoringTables>b__17_0(Level2Map a, Level2Map b) { }

}

